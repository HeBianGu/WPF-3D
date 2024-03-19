using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMarchingContourFilter
	/// </summary>
	/// <remarks>
	///    generate isosurfaces/isolines from scalar values
	///
	/// vtkMarchingContourFilter is a filter that takes as input any dataset and
	/// generates on output isosurfaces and/or isolines. The exact form
	/// of the output depends upon the dimensionality of the input data.
	/// Data consisting of 3D cells will generate isosurfaces, data
	/// consisting of 2D cells will generate isolines, and data with 1D
	/// or 0D cells will generate isopoints. Combinations of output type
	/// are possible if the input dimension is mixed.
	///
	/// This filter will identify special dataset types (e.g., structured
	/// points) and use the appropriate specialized filter to process the
	/// data. For examples, if the input dataset type is a volume, this
	/// filter will create an internal vtkMarchingCubes instance and use
	/// it. This gives much better performance.
	///
	/// To use this filter you must specify one or more contour values.
	/// You can either use the method SetValue() to specify each contour
	/// value, or use GenerateValues() to generate a series of evenly
	/// spaced contours. It is also possible to accelerate the operation of
	/// this filter (at the cost of extra memory) by using a
	/// vtkScalarTree. A scalar tree is used to quickly locate cells that
	/// contain a contour surface. This is especially effective if multiple
	/// contours are being extracted. If you want to use a scalar tree,
	/// invoke the method UseScalarTreeOn().
	///
	/// @warning
	/// For unstructured data or structured grids, normals and gradients
	/// are not computed.  This calculation will be implemented in the
	/// future. In the mean time, use vtkPolyDataNormals to compute the surface
	/// normals.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkMarchingCubes vtkSliceCubes vtkDividingCubes vtkMarchingSquares
	/// vtkImageMarchingCubes
	/// </seealso>
	// Token: 0x020008B8 RID: 2232
	public class vtkMarchingContourFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060171FA RID: 94714 RVA: 0x00207768 File Offset: 0x00205968
		static vtkMarchingContourFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMarchingContourFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMarchingContourFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060171FB RID: 94715 RVA: 0x00207790 File Offset: 0x00205990
		public vtkMarchingContourFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060171FC RID: 94716
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMarchingContourFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with initial range (0,1) and single contour value
		/// of 0.0.
		/// </summary>
		// Token: 0x060171FD RID: 94717 RVA: 0x002077A0 File Offset: 0x002059A0
		public new static vtkMarchingContourFilter New()
		{
			vtkMarchingContourFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMarchingContourFilter.vtkMarchingContourFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMarchingContourFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object with initial range (0,1) and single contour value
		/// of 0.0.
		/// </summary>
		// Token: 0x060171FE RID: 94718 RVA: 0x002077F4 File Offset: 0x002059F4
		public vtkMarchingContourFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMarchingContourFilter.vtkMarchingContourFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060171FF RID: 94719 RVA: 0x00207838 File Offset: 0x00205A38
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06017200 RID: 94720
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMarchingContourFilter_ComputeGradientsOff_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of gradients. Gradient computation is
		/// fairly expensive in both time and storage. Note that if
		/// ComputeNormals is on, gradients will have to be calculated, but
		/// will not be stored in the output dataset.  If the output data
		/// will be processed by filters that modify topology or geometry, it
		/// may be wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x06017201 RID: 94721 RVA: 0x00207843 File Offset: 0x00205A43
		public virtual void ComputeGradientsOff()
		{
			vtkMarchingContourFilter.vtkMarchingContourFilter_ComputeGradientsOff_01(base.GetCppThis());
		}

		// Token: 0x06017202 RID: 94722
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMarchingContourFilter_ComputeGradientsOn_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of gradients. Gradient computation is
		/// fairly expensive in both time and storage. Note that if
		/// ComputeNormals is on, gradients will have to be calculated, but
		/// will not be stored in the output dataset.  If the output data
		/// will be processed by filters that modify topology or geometry, it
		/// may be wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x06017203 RID: 94723 RVA: 0x00207852 File Offset: 0x00205A52
		public virtual void ComputeGradientsOn()
		{
			vtkMarchingContourFilter.vtkMarchingContourFilter_ComputeGradientsOn_02(base.GetCppThis());
		}

		// Token: 0x06017204 RID: 94724
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMarchingContourFilter_ComputeNormalsOff_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. Normal computation is fairly
		/// expensive in both time and storage. If the output data will be
		/// processed by filters that modify topology or geometry, it may be
		/// wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x06017205 RID: 94725 RVA: 0x00207861 File Offset: 0x00205A61
		public virtual void ComputeNormalsOff()
		{
			vtkMarchingContourFilter.vtkMarchingContourFilter_ComputeNormalsOff_03(base.GetCppThis());
		}

		// Token: 0x06017206 RID: 94726
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMarchingContourFilter_ComputeNormalsOn_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. Normal computation is fairly
		/// expensive in both time and storage. If the output data will be
		/// processed by filters that modify topology or geometry, it may be
		/// wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x06017207 RID: 94727 RVA: 0x00207870 File Offset: 0x00205A70
		public virtual void ComputeNormalsOn()
		{
			vtkMarchingContourFilter.vtkMarchingContourFilter_ComputeNormalsOn_04(base.GetCppThis());
		}

		// Token: 0x06017208 RID: 94728
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMarchingContourFilter_ComputeScalarsOff_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of scalars.
		/// </summary>
		// Token: 0x06017209 RID: 94729 RVA: 0x0020787F File Offset: 0x00205A7F
		public virtual void ComputeScalarsOff()
		{
			vtkMarchingContourFilter.vtkMarchingContourFilter_ComputeScalarsOff_05(base.GetCppThis());
		}

		// Token: 0x0601720A RID: 94730
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMarchingContourFilter_ComputeScalarsOn_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of scalars.
		/// </summary>
		// Token: 0x0601720B RID: 94731 RVA: 0x0020788E File Offset: 0x00205A8E
		public virtual void ComputeScalarsOn()
		{
			vtkMarchingContourFilter.vtkMarchingContourFilter_ComputeScalarsOn_06(base.GetCppThis());
		}

		// Token: 0x0601720C RID: 94732
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMarchingContourFilter_CreateDefaultLocator_07(HandleRef pThis);

		/// <summary>
		/// Create default locator. Used to create one when none is
		/// specified. The locator is used to merge coincident points.
		/// </summary>
		// Token: 0x0601720D RID: 94733 RVA: 0x0020789D File Offset: 0x00205A9D
		public void CreateDefaultLocator()
		{
			vtkMarchingContourFilter.vtkMarchingContourFilter_CreateDefaultLocator_07(base.GetCppThis());
		}

		// Token: 0x0601720E RID: 94734
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMarchingContourFilter_GenerateValues_08(HandleRef pThis, int numContours, IntPtr range);

		/// <summary>
		/// Methods to set / get contour values.
		/// </summary>
		// Token: 0x0601720F RID: 94735 RVA: 0x002078AC File Offset: 0x00205AAC
		public void GenerateValues(int numContours, IntPtr range)
		{
			vtkMarchingContourFilter.vtkMarchingContourFilter_GenerateValues_08(base.GetCppThis(), numContours, range);
		}

		// Token: 0x06017210 RID: 94736
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMarchingContourFilter_GenerateValues_09(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

		/// <summary>
		/// Methods to set / get contour values.
		/// </summary>
		// Token: 0x06017211 RID: 94737 RVA: 0x002078BD File Offset: 0x00205ABD
		public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
		{
			vtkMarchingContourFilter.vtkMarchingContourFilter_GenerateValues_09(base.GetCppThis(), numContours, rangeStart, rangeEnd);
		}

		// Token: 0x06017212 RID: 94738
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMarchingContourFilter_GetComputeGradients_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of gradients. Gradient computation is
		/// fairly expensive in both time and storage. Note that if
		/// ComputeNormals is on, gradients will have to be calculated, but
		/// will not be stored in the output dataset.  If the output data
		/// will be processed by filters that modify topology or geometry, it
		/// may be wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x06017213 RID: 94739 RVA: 0x002078D0 File Offset: 0x00205AD0
		public virtual int GetComputeGradients()
		{
			return vtkMarchingContourFilter.vtkMarchingContourFilter_GetComputeGradients_10(base.GetCppThis());
		}

		// Token: 0x06017214 RID: 94740
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMarchingContourFilter_GetComputeNormals_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. Normal computation is fairly
		/// expensive in both time and storage. If the output data will be
		/// processed by filters that modify topology or geometry, it may be
		/// wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x06017215 RID: 94741 RVA: 0x002078F0 File Offset: 0x00205AF0
		public virtual int GetComputeNormals()
		{
			return vtkMarchingContourFilter.vtkMarchingContourFilter_GetComputeNormals_11(base.GetCppThis());
		}

		// Token: 0x06017216 RID: 94742
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMarchingContourFilter_GetComputeScalars_12(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of scalars.
		/// </summary>
		// Token: 0x06017217 RID: 94743 RVA: 0x00207910 File Offset: 0x00205B10
		public virtual int GetComputeScalars()
		{
			return vtkMarchingContourFilter.vtkMarchingContourFilter_GetComputeScalars_12(base.GetCppThis());
		}

		// Token: 0x06017218 RID: 94744
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMarchingContourFilter_GetLocator_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set / get a spatial locator for merging points. By default,
		/// an instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x06017219 RID: 94745 RVA: 0x00207930 File Offset: 0x00205B30
		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMarchingContourFilter.vtkMarchingContourFilter_GetLocator_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIncrementalPointLocator = (vtkIncrementalPointLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIncrementalPointLocator.Register(null);
				}
			}
			return vtkIncrementalPointLocator;
		}

		// Token: 0x0601721A RID: 94746
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkMarchingContourFilter_GetMTime_14(HandleRef pThis);

		/// <summary>
		/// Modified GetMTime Because we delegate to vtkContourValues
		/// </summary>
		// Token: 0x0601721B RID: 94747 RVA: 0x002079A0 File Offset: 0x00205BA0
		public override ulong GetMTime()
		{
			return vtkMarchingContourFilter.vtkMarchingContourFilter_GetMTime_14(base.GetCppThis());
		}

		// Token: 0x0601721C RID: 94748
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMarchingContourFilter_GetNumberOfContours_15(HandleRef pThis);

		/// <summary>
		/// Methods to set / get contour values.
		/// </summary>
		// Token: 0x0601721D RID: 94749 RVA: 0x002079C0 File Offset: 0x00205BC0
		public long GetNumberOfContours()
		{
			return vtkMarchingContourFilter.vtkMarchingContourFilter_GetNumberOfContours_15(base.GetCppThis());
		}

		// Token: 0x0601721E RID: 94750
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMarchingContourFilter_GetNumberOfGenerationsFromBase_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601721F RID: 94751 RVA: 0x002079E0 File Offset: 0x00205BE0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMarchingContourFilter.vtkMarchingContourFilter_GetNumberOfGenerationsFromBase_16(base.GetCppThis(), type);
		}

		// Token: 0x06017220 RID: 94752
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMarchingContourFilter_GetNumberOfGenerationsFromBaseType_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017221 RID: 94753 RVA: 0x00207A00 File Offset: 0x00205C00
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMarchingContourFilter.vtkMarchingContourFilter_GetNumberOfGenerationsFromBaseType_17(type);
		}

		// Token: 0x06017222 RID: 94754
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMarchingContourFilter_GetUseScalarTree_18(HandleRef pThis);

		/// <summary>
		/// Enable the use of a scalar tree to accelerate contour extraction.
		/// </summary>
		// Token: 0x06017223 RID: 94755 RVA: 0x00207A1C File Offset: 0x00205C1C
		public virtual int GetUseScalarTree()
		{
			return vtkMarchingContourFilter.vtkMarchingContourFilter_GetUseScalarTree_18(base.GetCppThis());
		}

		// Token: 0x06017224 RID: 94756
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMarchingContourFilter_GetValue_19(HandleRef pThis, int i);

		/// <summary>
		/// Methods to set / get contour values.
		/// </summary>
		// Token: 0x06017225 RID: 94757 RVA: 0x00207A3C File Offset: 0x00205C3C
		public double GetValue(int i)
		{
			return vtkMarchingContourFilter.vtkMarchingContourFilter_GetValue_19(base.GetCppThis(), i);
		}

		// Token: 0x06017226 RID: 94758
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMarchingContourFilter_GetValues_20(HandleRef pThis);

		/// <summary>
		/// Methods to set / get contour values.
		/// </summary>
		// Token: 0x06017227 RID: 94759 RVA: 0x00207A5C File Offset: 0x00205C5C
		public IntPtr GetValues()
		{
			return vtkMarchingContourFilter.vtkMarchingContourFilter_GetValues_20(base.GetCppThis());
		}

		// Token: 0x06017228 RID: 94760
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMarchingContourFilter_GetValues_21(HandleRef pThis, IntPtr contourValues);

		/// <summary>
		/// Methods to set / get contour values.
		/// </summary>
		// Token: 0x06017229 RID: 94761 RVA: 0x00207A7B File Offset: 0x00205C7B
		public void GetValues(IntPtr contourValues)
		{
			vtkMarchingContourFilter.vtkMarchingContourFilter_GetValues_21(base.GetCppThis(), contourValues);
		}

		// Token: 0x0601722A RID: 94762
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMarchingContourFilter_IsA_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601722B RID: 94763 RVA: 0x00207A8C File Offset: 0x00205C8C
		public override int IsA(string type)
		{
			return vtkMarchingContourFilter.vtkMarchingContourFilter_IsA_22(base.GetCppThis(), type);
		}

		// Token: 0x0601722C RID: 94764
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMarchingContourFilter_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601722D RID: 94765 RVA: 0x00207AAC File Offset: 0x00205CAC
		public new static int IsTypeOf(string type)
		{
			return vtkMarchingContourFilter.vtkMarchingContourFilter_IsTypeOf_23(type);
		}

		// Token: 0x0601722E RID: 94766
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMarchingContourFilter_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601722F RID: 94767 RVA: 0x00207AC8 File Offset: 0x00205CC8
		public new vtkMarchingContourFilter NewInstance()
		{
			vtkMarchingContourFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMarchingContourFilter.vtkMarchingContourFilter_NewInstance_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMarchingContourFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06017230 RID: 94768
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMarchingContourFilter_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017231 RID: 94769 RVA: 0x00207B24 File Offset: 0x00205D24
		public new static vtkMarchingContourFilter SafeDownCast(vtkObjectBase o)
		{
			vtkMarchingContourFilter vtkMarchingContourFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMarchingContourFilter.vtkMarchingContourFilter_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMarchingContourFilter = (vtkMarchingContourFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMarchingContourFilter.Register(null);
				}
			}
			return vtkMarchingContourFilter;
		}

		// Token: 0x06017232 RID: 94770
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMarchingContourFilter_SetComputeGradients_27(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the computation of gradients. Gradient computation is
		/// fairly expensive in both time and storage. Note that if
		/// ComputeNormals is on, gradients will have to be calculated, but
		/// will not be stored in the output dataset.  If the output data
		/// will be processed by filters that modify topology or geometry, it
		/// may be wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x06017233 RID: 94771 RVA: 0x00207BA3 File Offset: 0x00205DA3
		public virtual void SetComputeGradients(int _arg)
		{
			vtkMarchingContourFilter.vtkMarchingContourFilter_SetComputeGradients_27(base.GetCppThis(), _arg);
		}

		// Token: 0x06017234 RID: 94772
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMarchingContourFilter_SetComputeNormals_28(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the computation of normals. Normal computation is fairly
		/// expensive in both time and storage. If the output data will be
		/// processed by filters that modify topology or geometry, it may be
		/// wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x06017235 RID: 94773 RVA: 0x00207BB3 File Offset: 0x00205DB3
		public virtual void SetComputeNormals(int _arg)
		{
			vtkMarchingContourFilter.vtkMarchingContourFilter_SetComputeNormals_28(base.GetCppThis(), _arg);
		}

		// Token: 0x06017236 RID: 94774
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMarchingContourFilter_SetComputeScalars_29(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the computation of scalars.
		/// </summary>
		// Token: 0x06017237 RID: 94775 RVA: 0x00207BC3 File Offset: 0x00205DC3
		public virtual void SetComputeScalars(int _arg)
		{
			vtkMarchingContourFilter.vtkMarchingContourFilter_SetComputeScalars_29(base.GetCppThis(), _arg);
		}

		// Token: 0x06017238 RID: 94776
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMarchingContourFilter_SetLocator_30(HandleRef pThis, HandleRef locator);

		/// <summary>
		/// Set / get a spatial locator for merging points. By default,
		/// an instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x06017239 RID: 94777 RVA: 0x00207BD4 File Offset: 0x00205DD4
		public void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkMarchingContourFilter.vtkMarchingContourFilter_SetLocator_30(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		// Token: 0x0601723A RID: 94778
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMarchingContourFilter_SetNumberOfContours_31(HandleRef pThis, int number);

		/// <summary>
		/// Methods to set / get contour values.
		/// </summary>
		// Token: 0x0601723B RID: 94779 RVA: 0x00207C03 File Offset: 0x00205E03
		public void SetNumberOfContours(int number)
		{
			vtkMarchingContourFilter.vtkMarchingContourFilter_SetNumberOfContours_31(base.GetCppThis(), number);
		}

		// Token: 0x0601723C RID: 94780
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMarchingContourFilter_SetUseScalarTree_32(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable the use of a scalar tree to accelerate contour extraction.
		/// </summary>
		// Token: 0x0601723D RID: 94781 RVA: 0x00207C13 File Offset: 0x00205E13
		public virtual void SetUseScalarTree(int _arg)
		{
			vtkMarchingContourFilter.vtkMarchingContourFilter_SetUseScalarTree_32(base.GetCppThis(), _arg);
		}

		// Token: 0x0601723E RID: 94782
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMarchingContourFilter_SetValue_33(HandleRef pThis, int i, double value);

		/// <summary>
		/// Methods to set / get contour values.
		/// </summary>
		// Token: 0x0601723F RID: 94783 RVA: 0x00207C23 File Offset: 0x00205E23
		public void SetValue(int i, double value)
		{
			vtkMarchingContourFilter.vtkMarchingContourFilter_SetValue_33(base.GetCppThis(), i, value);
		}

		// Token: 0x06017240 RID: 94784
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMarchingContourFilter_UseScalarTreeOff_34(HandleRef pThis);

		/// <summary>
		/// Enable the use of a scalar tree to accelerate contour extraction.
		/// </summary>
		// Token: 0x06017241 RID: 94785 RVA: 0x00207C34 File Offset: 0x00205E34
		public virtual void UseScalarTreeOff()
		{
			vtkMarchingContourFilter.vtkMarchingContourFilter_UseScalarTreeOff_34(base.GetCppThis());
		}

		// Token: 0x06017242 RID: 94786
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMarchingContourFilter_UseScalarTreeOn_35(HandleRef pThis);

		/// <summary>
		/// Enable the use of a scalar tree to accelerate contour extraction.
		/// </summary>
		// Token: 0x06017243 RID: 94787 RVA: 0x00207C43 File Offset: 0x00205E43
		public virtual void UseScalarTreeOn()
		{
			vtkMarchingContourFilter.vtkMarchingContourFilter_UseScalarTreeOn_35(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019DE RID: 6622
		public new const string MRFullTypeName = "Kitware.VTK.vtkMarchingContourFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019DF RID: 6623
		public new static readonly string MRClassNameKey = "class vtkMarchingContourFilter";
	}
}
