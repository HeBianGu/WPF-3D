﻿using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkContinuousScatterplot
	/// </summary>
	/// <remarks>
	///  Given a 3D domain space represented by an
	/// unstructured grid composed of tetrahedral cells with bivariate fields, this filter
	/// tessellates each cell in the domain to polyhedral fragments by intersecting the
	/// projection of the cell into 2-D range space against two sets of cutting planes, one set
	/// is defined along the first field, the second set is defined along the second field. The
	/// volume of these subdivided polyhedral fragments can be computed and aggregated over
	/// cells to depict the density distribution of the data projection in the bivariate range
	/// space.
	///
	/// @section vtkContinuousScatterplot-introduction Introduction
	/// Given a bivariate field (f1,f2) defined on an unstructured grid which is
	/// composed of tetrahedral cells, we can initially subdivide each cell based on its
	/// projection in the range into a number of fragments along the first field f1, we refer
	/// to these polyhedral fragments as Frag(f1) = {frag(f1)_1, frag(f1)_2, ... , frag(f1)_n},
	/// where frag(f1)_n refers to the nth fragment along the first field subdivision. Each
	/// fragment has a range value and the value difference between the neighbouring fragments
	/// is represented as fragment width fw_f1, which is uniformly distributed across the
	/// range.
	/// Based on the structure of Frag(f1), for each of its cell "frag(f1)_n", we
	/// can further subdivide this cell based on the second field f2 using fragment width
	/// fw_f2. The tessellation along the second field results in an even finer fragment
	/// collection which we refer to as Frag(f1,f2) = {frag(f1,f2)_1, frag(f1,f2)_2, ... ,
	/// frag(f1,f2)_m}. We can observe that Frag(f1,f2) is a finer tessellation of the domain
	/// than Frag(f1) and will be used to compute the density distribution in the bivariate
	/// range space. The algorithm for fragment computation is similar to the first stage of
	/// the work in [0].
	/// Each fragment "s" in Frag(f1,f2) has range values (f1(s), f2(s)) in the bivariate
	/// fields. These values can be further mapped to a 2-D bin with a resolution rexX * resY.
	/// The mapped bin index (binIndexX, binIndexY) of the fragment can be computed by linear
	/// interpolation on its range values :
	///           binIndexX = (int) resX * (f1(s) - f1_min) / (f1_max - f1_min)
	///           binIndexY = (int) resY * (f2(s) - f2_min) / (f2_max - f2_min),
	///        where (f1_min, f1_max) is the range in first field.
	/// Once we know which bin a fragment coincides, the density value in each bin equals to
	/// the total geometric volume of the fragments in this bin. This volume distribution
	/// over the bins will be exported as a point data array in the output data structure.
	/// If we map this 2-D bin to a 2-D image with each bin corresponding to a pixel and
	/// bin density to pixel transparency, then the image can be displayed as a continuous
	/// scatterplot.
	///
	/// @section vtkContinuousScatterplot-algorithm Algorithm
	/// The algorithm of this filter can be described as:
	///   Require: R.1 The domain space is an unstructured grid data set composed of
	///                tetrahedral cells;
	///            R.2 The range space contains two scalar fields, say f1 and f2.
	///
	///   The most important step is to compute the fragments. The implementation processes
	///   the input grid one cell at a time, explicitly computing the intersection of the cell
	///   with the cutting planes defined by the fragment boundaries in each scalar field.
	///   In order to subdivide the cell, we need to define a list of cutting planes in each
	///   field. The interval between neighbouring cutting planes is related to the output 2-D
	///   bin resolution (resX, resY) and can be computed as :
	///                     fw_f1 = (f1_max - f1_min) / resX
	///                     fw_f2 = (f2_max - f2_min) / resY,
	///                 where (f1_max,f1_min) is the scalar range of first field.
	///
	///      1. For each tetrahedron T in the input grid:
	///
	///        1.1 Subdivide the cell T based on the first field f1, we will obtain a list
	///            of fragments: Frag(f1) = {frag(f1)_1, frag(f1)_2, ... , frag(f1)_n}. The
	///            steps for subdivision can be described as:
	///
	///            1.1.1 For each cutting plane s with respect to the first field f1,
	///                  its field value f1(s) = f1_min + n * fw_f1, where n refers to the n-th
	///                  cutting plane:
	///
	///              1.1.2. Traverse each edge e starting from point a to b in the cell, we
	///                     will maintain three data classes, namely fragmentFace,
	///                     residualFace and cutSet:
	///                     A. fragmentFace contains vertices in the current fragment.
	///                     B. cutSet contains vertices whose range values equal to f1(s).
	///                        This set contains the current cutting plane.
	///                     C. residualFace contains the rest of the vertices in the cell.
	///                     In order to classify edge vertices into these classes, the
	///                     following case table is used for each vertex "a" :
	///                       case 0 :          f1(a)------ f1(s) ------f1(b)
	///                              condition: f1(a) &lt; f1(s) , f1(b) &gt; f1(s)
	///                              class:     p(s,e), a -&gt; fragmentFace
	///                                         p(s,e) -&gt; cutSet
	///                                         p(s,e) -&gt; residualFace
	///
	///                       case 1 :          f1(b)------ f1(s) ------f1(a)
	///                              condition: f1(a) &gt; f1(s) , f1(b) &lt; f1(s)
	///                              class:     p(s,e) -&gt; fragmentFace
	///                                         p(s,e) -&gt; cutSet
	///                                         a -&gt; residualFace
	///
	///                       case 2 :    f1(s),f1(a)-------------------f1(b)
	///                              condition: f1(s) == f1(a), f1(s) &lt;= f1(b)
	///                              class:     a -&gt; fragmentFace
	///                                         a -&gt; residualFace
	///                                         a -&gt; cutSet
	///
	///                       case 3 :          f1(a)-------------------f1(b), f1(s)
	///                              condition: f1(s) &gt; f1(a), f1(s) == f1(b)
	///                              class:     a -&gt; fragmentFace
	///
	///                       case 4 :    f1(s),f1(b)-------------------f1(a)
	///                              condition: f1(s) &lt; f1(a), f1(s) == f1(b)
	///                              class:     a -&gt; residualFace
	///                       Remark: 1. we use "-&gt;" to indicate "belongs to" relation.
	///                               2. p(s,e) refers to the interpolated point of range value
	///                                  f1(s) on the edge e.
	///
	///             1.1.3. After we have traversed every edge in a cell for the cutting plane
	///                    s, three classes for storing fragment, cutting plane and residual
	///                    faces are updated. The faces of the current fragment frag(f1)
	///                    are the union of all elements in fragmentFace and cutSet.
	///
	///    1.2 Take the output of step 1.1, traverse each fragment in Frag(f1), define a list
	///        of cutting planes with respect to field f2, further subdivide the fragments in
	///        Frag(f1) following steps from 1.1.2 to 1.1.3. The output of this step will be
	///        the fragment collection Frag(f1,f2). Each fragment in Frag(f1,f2) can be further
	///        mapped to a 2-D bin based on its range values. The density value in each bin
	///        equals to the total geometric volume of the fragments in this bin. This volume
	///        distribution over the bins will be exported as a point data array in the output
	///        data structure.
	///
	/// @section vtkContinuousScatterplot-filter-design VTK Filter Design
	/// The input and output ports of the filter:
	///      Input port : the input data set should be a vtkUnstructuredGrid, with each of its
	///                   cell defined as a tetrahedron. At least two scalar fields are
	///                   associated with the data. The user needs to specify the name of the
	///                   two scalar arrays beforehand.
	///      Output port: the output data set is a 2D image stored as a vtkImageData.
	///                   The resolution of the output image can be set by the user.
	///                   The volume distribution of fragments in each pixel or bin
	///                   is stored in an point data array named "volume" in the output
	///                   vtkImageData.
	///
	/// @section vtkContinuousScatterplot-how-to-use How To Use This Filter
	/// Suppose we have a tetrahedral mesh stored in a vtkUnstructuredGrid, we call this
	/// data set "inputData". This data set has two scalar arrays whose names are "f1"
	/// and "f2" respectively. We would like the resolution of output image set to (resX,resY).
	/// Given these input, this filter can be called as follows in c++ sample code:
	///
	///     vtkSmartPointer&lt;vtkContinuousScatterplot&gt; csp =
	///                            vtkSmartPointer&lt;vtkContinuousScatterplot&gt;::New();
	///     csp-&gt;SetInputData(inputData);
	///     csp-&gt;SetField1("f1",resX);
	///     csp-&gt;SetField2("f2",resY);
	///     csp-&gt;Update();
	///
	/// Then the output, "csp-&gt;GetOutput()", will be a vtkImageData containing a scalar
	/// array whose name is "volume". This array contains the volume distribution of the
	/// fragments.
	///
	/// [0] H.Carr and D.Duke, Joint contour nets: Topological analysis of multivariate data.
	///     IEEE Transactions on Visualization and Computer Graphics, volume 20,
	///     issue 08, pages 1100-1113, 2014
	/// </remarks>
	// Token: 0x02000676 RID: 1654
	public class vtkContinuousScatterplot : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011D2F RID: 73007 RVA: 0x0018F0CB File Offset: 0x0018D2CB
		static vtkContinuousScatterplot()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkContinuousScatterplot.MRClassNameKey, Type.GetType("Kitware.VTK.vtkContinuousScatterplot"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011D30 RID: 73008 RVA: 0x0018F0F3 File Offset: 0x0018D2F3
		public vtkContinuousScatterplot(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011D31 RID: 73009
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContinuousScatterplot_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011D32 RID: 73010 RVA: 0x0018F104 File Offset: 0x0018D304
		public new static vtkContinuousScatterplot New()
		{
			vtkContinuousScatterplot result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContinuousScatterplot.vtkContinuousScatterplot_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContinuousScatterplot)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011D33 RID: 73011 RVA: 0x0018F158 File Offset: 0x0018D358
		public vtkContinuousScatterplot() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkContinuousScatterplot.vtkContinuousScatterplot_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011D34 RID: 73012 RVA: 0x0018F19C File Offset: 0x0018D39C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011D35 RID: 73013
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkContinuousScatterplot_GetEpsilon_01(HandleRef pThis);

		/// <summary>
		/// Get the tolerance used when comparing floating point numbers for equality.
		/// </summary>
		// Token: 0x06011D36 RID: 73014 RVA: 0x0018F1A8 File Offset: 0x0018D3A8
		public virtual double GetEpsilon()
		{
			return vtkContinuousScatterplot.vtkContinuousScatterplot_GetEpsilon_01(base.GetCppThis());
		}

		// Token: 0x06011D37 RID: 73015
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkContinuousScatterplot_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011D38 RID: 73016 RVA: 0x0018F1C8 File Offset: 0x0018D3C8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkContinuousScatterplot.vtkContinuousScatterplot_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06011D39 RID: 73017
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkContinuousScatterplot_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011D3A RID: 73018 RVA: 0x0018F1E8 File Offset: 0x0018D3E8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkContinuousScatterplot.vtkContinuousScatterplot_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06011D3B RID: 73019
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContinuousScatterplot_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011D3C RID: 73020 RVA: 0x0018F204 File Offset: 0x0018D404
		public override int IsA(string type)
		{
			return vtkContinuousScatterplot.vtkContinuousScatterplot_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06011D3D RID: 73021
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContinuousScatterplot_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011D3E RID: 73022 RVA: 0x0018F224 File Offset: 0x0018D424
		public new static int IsTypeOf(string type)
		{
			return vtkContinuousScatterplot.vtkContinuousScatterplot_IsTypeOf_05(type);
		}

		// Token: 0x06011D3F RID: 73023
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContinuousScatterplot_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011D40 RID: 73024 RVA: 0x0018F240 File Offset: 0x0018D440
		public new vtkContinuousScatterplot NewInstance()
		{
			vtkContinuousScatterplot result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContinuousScatterplot.vtkContinuousScatterplot_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContinuousScatterplot)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011D41 RID: 73025
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContinuousScatterplot_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011D42 RID: 73026 RVA: 0x0018F29C File Offset: 0x0018D49C
		public new static vtkContinuousScatterplot SafeDownCast(vtkObjectBase o)
		{
			vtkContinuousScatterplot vtkContinuousScatterplot = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContinuousScatterplot.vtkContinuousScatterplot_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkContinuousScatterplot = (vtkContinuousScatterplot)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkContinuousScatterplot.Register(null);
				}
			}
			return vtkContinuousScatterplot;
		}

		// Token: 0x06011D43 RID: 73027
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContinuousScatterplot_SetEpsilon_09(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the tolerance used when comparing floating point numbers for equality.
		/// </summary>
		// Token: 0x06011D44 RID: 73028 RVA: 0x0018F31B File Offset: 0x0018D51B
		public virtual void SetEpsilon(double _arg)
		{
			vtkContinuousScatterplot.vtkContinuousScatterplot_SetEpsilon_09(base.GetCppThis(), _arg);
		}

		// Token: 0x06011D45 RID: 73029
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContinuousScatterplot_SetField1_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fieldName, long ResX);

		/// <summary>
		/// Specify the name of the first field to be used in subdividing the dataset.
		/// Specify the resolution along x axis of the output image.
		/// </summary>
		// Token: 0x06011D46 RID: 73030 RVA: 0x0018F32B File Offset: 0x0018D52B
		public void SetField1(string fieldName, long ResX)
		{
			vtkContinuousScatterplot.vtkContinuousScatterplot_SetField1_10(base.GetCppThis(), fieldName, ResX);
		}

		// Token: 0x06011D47 RID: 73031
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContinuousScatterplot_SetField2_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fieldName, long ResY);

		/// <summary>
		/// Specify the name of the second field to be used in subdividing the dataset.
		/// Specify the resolution along y axis of the output image.
		/// </summary>
		// Token: 0x06011D48 RID: 73032 RVA: 0x0018F33C File Offset: 0x0018D53C
		public void SetField2(string fieldName, long ResY)
		{
			vtkContinuousScatterplot.vtkContinuousScatterplot_SetField2_11(base.GetCppThis(), fieldName, ResY);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400148D RID: 5261
		public new const string MRFullTypeName = "Kitware.VTK.vtkContinuousScatterplot";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400148E RID: 5262
		public new static readonly string MRClassNameKey = "class vtkContinuousScatterplot";
	}
}
