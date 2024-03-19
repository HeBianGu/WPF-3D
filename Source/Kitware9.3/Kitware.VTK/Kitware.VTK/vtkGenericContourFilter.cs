using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGenericContourFilter
	/// </summary>
	/// <remarks>
	///    generate isocontours from input dataset
	///
	/// vtkGenericContourFilter is a filter that takes as input any (generic)
	/// dataset and generates on output isosurfaces and/or isolines. The exact
	/// form of the output depends upon the dimensionality of the input data.
	/// Data consisting of 3D cells will generate isosurfaces, data consisting of
	/// 2D cells will generate isolines, and data with 1D or 0D cells will
	/// generate isopoints. Combinations of output type are possible if the input
	/// dimension is mixed.
	///
	/// To use this filter you must specify one or more contour values.
	/// You can either use the method SetValue() to specify each contour
	/// value, or use GenerateValues() to generate a series of evenly
	/// spaced contours. You can use ComputeNormalsOn to compute the normals
	/// without the need of a vtkPolyDataNormals
	///
	/// This filter has been implemented to operate on generic datasets, rather
	/// than the typical vtkDataSet (and subclasses). vtkGenericDataSet is a more
	/// complex cousin of vtkDataSet, typically consisting of nonlinear,
	/// higher-order cells. To process this type of data, generic cells are
	/// automatically tessellated into linear cells prior to isocontouring.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkContourFilter vtkGenericDataSet
	/// </seealso>
	// Token: 0x02000499 RID: 1177
	public class vtkGenericContourFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D892 RID: 55442 RVA: 0x0012CFD7 File Offset: 0x0012B1D7
		static vtkGenericContourFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenericContourFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericContourFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D893 RID: 55443 RVA: 0x0012CFFF File Offset: 0x0012B1FF
		public vtkGenericContourFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600D894 RID: 55444
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericContourFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with initial range (0,1) and single contour value
		/// of 0.0.
		/// </summary>
		// Token: 0x0600D895 RID: 55445 RVA: 0x0012D010 File Offset: 0x0012B210
		public new static vtkGenericContourFilter New()
		{
			vtkGenericContourFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericContourFilter.vtkGenericContourFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericContourFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object with initial range (0,1) and single contour value
		/// of 0.0.
		/// </summary>
		// Token: 0x0600D896 RID: 55446 RVA: 0x0012D064 File Offset: 0x0012B264
		public vtkGenericContourFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGenericContourFilter.vtkGenericContourFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D897 RID: 55447 RVA: 0x0012D0A8 File Offset: 0x0012B2A8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D898 RID: 55448
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericContourFilter_ComputeGradientsOff_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of gradients. Gradient computation is
		/// fairly expensive in both time and storage. Note that if
		/// ComputeNormals is on, gradients will have to be calculated, but
		/// will not be stored in the output dataset.  If the output data
		/// will be processed by filters that modify topology or geometry, it
		/// may be wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x0600D899 RID: 55449 RVA: 0x0012D0B3 File Offset: 0x0012B2B3
		public virtual void ComputeGradientsOff()
		{
			vtkGenericContourFilter.vtkGenericContourFilter_ComputeGradientsOff_01(base.GetCppThis());
		}

		// Token: 0x0600D89A RID: 55450
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericContourFilter_ComputeGradientsOn_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of gradients. Gradient computation is
		/// fairly expensive in both time and storage. Note that if
		/// ComputeNormals is on, gradients will have to be calculated, but
		/// will not be stored in the output dataset.  If the output data
		/// will be processed by filters that modify topology or geometry, it
		/// may be wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x0600D89B RID: 55451 RVA: 0x0012D0C2 File Offset: 0x0012B2C2
		public virtual void ComputeGradientsOn()
		{
			vtkGenericContourFilter.vtkGenericContourFilter_ComputeGradientsOn_02(base.GetCppThis());
		}

		// Token: 0x0600D89C RID: 55452
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericContourFilter_ComputeNormalsOff_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. Normal computation is fairly
		/// expensive in both time and storage. If the output data will be
		/// processed by filters that modify topology or geometry, it may be
		/// wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x0600D89D RID: 55453 RVA: 0x0012D0D1 File Offset: 0x0012B2D1
		public virtual void ComputeNormalsOff()
		{
			vtkGenericContourFilter.vtkGenericContourFilter_ComputeNormalsOff_03(base.GetCppThis());
		}

		// Token: 0x0600D89E RID: 55454
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericContourFilter_ComputeNormalsOn_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. Normal computation is fairly
		/// expensive in both time and storage. If the output data will be
		/// processed by filters that modify topology or geometry, it may be
		/// wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x0600D89F RID: 55455 RVA: 0x0012D0E0 File Offset: 0x0012B2E0
		public virtual void ComputeNormalsOn()
		{
			vtkGenericContourFilter.vtkGenericContourFilter_ComputeNormalsOn_04(base.GetCppThis());
		}

		// Token: 0x0600D8A0 RID: 55456
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericContourFilter_ComputeScalarsOff_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of scalars.
		/// </summary>
		// Token: 0x0600D8A1 RID: 55457 RVA: 0x0012D0EF File Offset: 0x0012B2EF
		public virtual void ComputeScalarsOff()
		{
			vtkGenericContourFilter.vtkGenericContourFilter_ComputeScalarsOff_05(base.GetCppThis());
		}

		// Token: 0x0600D8A2 RID: 55458
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericContourFilter_ComputeScalarsOn_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of scalars.
		/// </summary>
		// Token: 0x0600D8A3 RID: 55459 RVA: 0x0012D0FE File Offset: 0x0012B2FE
		public virtual void ComputeScalarsOn()
		{
			vtkGenericContourFilter.vtkGenericContourFilter_ComputeScalarsOn_06(base.GetCppThis());
		}

		// Token: 0x0600D8A4 RID: 55460
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericContourFilter_CreateDefaultLocator_07(HandleRef pThis);

		/// <summary>
		/// Create default locator. Used to create one when none is
		/// specified. The locator is used to merge coincident points.
		/// </summary>
		// Token: 0x0600D8A5 RID: 55461 RVA: 0x0012D10D File Offset: 0x0012B30D
		public void CreateDefaultLocator()
		{
			vtkGenericContourFilter.vtkGenericContourFilter_CreateDefaultLocator_07(base.GetCppThis());
		}

		// Token: 0x0600D8A6 RID: 55462
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericContourFilter_GenerateValues_08(HandleRef pThis, int numContours, IntPtr range);

		/// <summary>
		/// Methods to set / get contour values.
		/// </summary>
		// Token: 0x0600D8A7 RID: 55463 RVA: 0x0012D11C File Offset: 0x0012B31C
		public void GenerateValues(int numContours, IntPtr range)
		{
			vtkGenericContourFilter.vtkGenericContourFilter_GenerateValues_08(base.GetCppThis(), numContours, range);
		}

		// Token: 0x0600D8A8 RID: 55464
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericContourFilter_GenerateValues_09(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

		/// <summary>
		/// Methods to set / get contour values.
		/// </summary>
		// Token: 0x0600D8A9 RID: 55465 RVA: 0x0012D12D File Offset: 0x0012B32D
		public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
		{
			vtkGenericContourFilter.vtkGenericContourFilter_GenerateValues_09(base.GetCppThis(), numContours, rangeStart, rangeEnd);
		}

		// Token: 0x0600D8AA RID: 55466
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericContourFilter_GetComputeGradients_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of gradients. Gradient computation is
		/// fairly expensive in both time and storage. Note that if
		/// ComputeNormals is on, gradients will have to be calculated, but
		/// will not be stored in the output dataset.  If the output data
		/// will be processed by filters that modify topology or geometry, it
		/// may be wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x0600D8AB RID: 55467 RVA: 0x0012D140 File Offset: 0x0012B340
		public virtual int GetComputeGradients()
		{
			return vtkGenericContourFilter.vtkGenericContourFilter_GetComputeGradients_10(base.GetCppThis());
		}

		// Token: 0x0600D8AC RID: 55468
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericContourFilter_GetComputeNormals_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. Normal computation is fairly
		/// expensive in both time and storage. If the output data will be
		/// processed by filters that modify topology or geometry, it may be
		/// wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x0600D8AD RID: 55469 RVA: 0x0012D160 File Offset: 0x0012B360
		public virtual int GetComputeNormals()
		{
			return vtkGenericContourFilter.vtkGenericContourFilter_GetComputeNormals_11(base.GetCppThis());
		}

		// Token: 0x0600D8AE RID: 55470
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericContourFilter_GetComputeScalars_12(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of scalars.
		/// </summary>
		// Token: 0x0600D8AF RID: 55471 RVA: 0x0012D180 File Offset: 0x0012B380
		public virtual int GetComputeScalars()
		{
			return vtkGenericContourFilter.vtkGenericContourFilter_GetComputeScalars_12(base.GetCppThis());
		}

		// Token: 0x0600D8B0 RID: 55472
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericContourFilter_GetInputScalarsSelection_13(HandleRef pThis);

		/// <summary>
		/// If you want to contour by an arbitrary scalar attribute, then set its
		/// name here.
		/// By default this in nullptr and the filter will use the active scalar array.
		/// </summary>
		// Token: 0x0600D8B1 RID: 55473 RVA: 0x0012D1A0 File Offset: 0x0012B3A0
		public virtual string GetInputScalarsSelection()
		{
			string s = Marshal.PtrToStringAnsi(vtkGenericContourFilter.vtkGenericContourFilter_GetInputScalarsSelection_13(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600D8B2 RID: 55474
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericContourFilter_GetLocator_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set / get a spatial locator for merging points. By default,
		/// an instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x0600D8B3 RID: 55475 RVA: 0x0012D1DC File Offset: 0x0012B3DC
		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericContourFilter.vtkGenericContourFilter_GetLocator_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600D8B4 RID: 55476
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkGenericContourFilter_GetMTime_15(HandleRef pThis);

		/// <summary>
		/// Modified GetMTime Because we delegate to vtkContourValues
		/// </summary>
		// Token: 0x0600D8B5 RID: 55477 RVA: 0x0012D24C File Offset: 0x0012B44C
		public override ulong GetMTime()
		{
			return vtkGenericContourFilter.vtkGenericContourFilter_GetMTime_15(base.GetCppThis());
		}

		// Token: 0x0600D8B6 RID: 55478
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericContourFilter_GetNumberOfContours_16(HandleRef pThis);

		/// <summary>
		/// Methods to set / get contour values.
		/// </summary>
		// Token: 0x0600D8B7 RID: 55479 RVA: 0x0012D26C File Offset: 0x0012B46C
		public long GetNumberOfContours()
		{
			return vtkGenericContourFilter.vtkGenericContourFilter_GetNumberOfContours_16(base.GetCppThis());
		}

		// Token: 0x0600D8B8 RID: 55480
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericContourFilter_GetNumberOfGenerationsFromBase_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D8B9 RID: 55481 RVA: 0x0012D28C File Offset: 0x0012B48C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGenericContourFilter.vtkGenericContourFilter_GetNumberOfGenerationsFromBase_17(base.GetCppThis(), type);
		}

		// Token: 0x0600D8BA RID: 55482
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericContourFilter_GetNumberOfGenerationsFromBaseType_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D8BB RID: 55483 RVA: 0x0012D2AC File Offset: 0x0012B4AC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGenericContourFilter.vtkGenericContourFilter_GetNumberOfGenerationsFromBaseType_18(type);
		}

		// Token: 0x0600D8BC RID: 55484
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGenericContourFilter_GetValue_19(HandleRef pThis, int i);

		/// <summary>
		/// Methods to set / get contour values.
		/// </summary>
		// Token: 0x0600D8BD RID: 55485 RVA: 0x0012D2C8 File Offset: 0x0012B4C8
		public double GetValue(int i)
		{
			return vtkGenericContourFilter.vtkGenericContourFilter_GetValue_19(base.GetCppThis(), i);
		}

		// Token: 0x0600D8BE RID: 55486
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericContourFilter_GetValues_20(HandleRef pThis);

		/// <summary>
		/// Methods to set / get contour values.
		/// </summary>
		// Token: 0x0600D8BF RID: 55487 RVA: 0x0012D2E8 File Offset: 0x0012B4E8
		public IntPtr GetValues()
		{
			return vtkGenericContourFilter.vtkGenericContourFilter_GetValues_20(base.GetCppThis());
		}

		// Token: 0x0600D8C0 RID: 55488
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericContourFilter_GetValues_21(HandleRef pThis, IntPtr contourValues);

		/// <summary>
		/// Methods to set / get contour values.
		/// </summary>
		// Token: 0x0600D8C1 RID: 55489 RVA: 0x0012D307 File Offset: 0x0012B507
		public void GetValues(IntPtr contourValues)
		{
			vtkGenericContourFilter.vtkGenericContourFilter_GetValues_21(base.GetCppThis(), contourValues);
		}

		// Token: 0x0600D8C2 RID: 55490
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericContourFilter_IsA_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D8C3 RID: 55491 RVA: 0x0012D318 File Offset: 0x0012B518
		public override int IsA(string type)
		{
			return vtkGenericContourFilter.vtkGenericContourFilter_IsA_22(base.GetCppThis(), type);
		}

		// Token: 0x0600D8C4 RID: 55492
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericContourFilter_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D8C5 RID: 55493 RVA: 0x0012D338 File Offset: 0x0012B538
		public new static int IsTypeOf(string type)
		{
			return vtkGenericContourFilter.vtkGenericContourFilter_IsTypeOf_23(type);
		}

		// Token: 0x0600D8C6 RID: 55494
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericContourFilter_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D8C7 RID: 55495 RVA: 0x0012D354 File Offset: 0x0012B554
		public new vtkGenericContourFilter NewInstance()
		{
			vtkGenericContourFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericContourFilter.vtkGenericContourFilter_NewInstance_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericContourFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D8C8 RID: 55496
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericContourFilter_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D8C9 RID: 55497 RVA: 0x0012D3B0 File Offset: 0x0012B5B0
		public new static vtkGenericContourFilter SafeDownCast(vtkObjectBase o)
		{
			vtkGenericContourFilter vtkGenericContourFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericContourFilter.vtkGenericContourFilter_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericContourFilter = (vtkGenericContourFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericContourFilter.Register(null);
				}
			}
			return vtkGenericContourFilter;
		}

		// Token: 0x0600D8CA RID: 55498
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericContourFilter_SelectInputScalars_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fieldName);

		/// <summary>
		/// If you want to contour by an arbitrary scalar attribute, then set its
		/// name here.
		/// By default this in nullptr and the filter will use the active scalar array.
		/// </summary>
		// Token: 0x0600D8CB RID: 55499 RVA: 0x0012D42F File Offset: 0x0012B62F
		public virtual void SelectInputScalars(string fieldName)
		{
			vtkGenericContourFilter.vtkGenericContourFilter_SelectInputScalars_27(base.GetCppThis(), fieldName);
		}

		// Token: 0x0600D8CC RID: 55500
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericContourFilter_SetComputeGradients_28(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the computation of gradients. Gradient computation is
		/// fairly expensive in both time and storage. Note that if
		/// ComputeNormals is on, gradients will have to be calculated, but
		/// will not be stored in the output dataset.  If the output data
		/// will be processed by filters that modify topology or geometry, it
		/// may be wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x0600D8CD RID: 55501 RVA: 0x0012D43F File Offset: 0x0012B63F
		public virtual void SetComputeGradients(int _arg)
		{
			vtkGenericContourFilter.vtkGenericContourFilter_SetComputeGradients_28(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D8CE RID: 55502
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericContourFilter_SetComputeNormals_29(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the computation of normals. Normal computation is fairly
		/// expensive in both time and storage. If the output data will be
		/// processed by filters that modify topology or geometry, it may be
		/// wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x0600D8CF RID: 55503 RVA: 0x0012D44F File Offset: 0x0012B64F
		public virtual void SetComputeNormals(int _arg)
		{
			vtkGenericContourFilter.vtkGenericContourFilter_SetComputeNormals_29(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D8D0 RID: 55504
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericContourFilter_SetComputeScalars_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the computation of scalars.
		/// </summary>
		// Token: 0x0600D8D1 RID: 55505 RVA: 0x0012D45F File Offset: 0x0012B65F
		public virtual void SetComputeScalars(int _arg)
		{
			vtkGenericContourFilter.vtkGenericContourFilter_SetComputeScalars_30(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D8D2 RID: 55506
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericContourFilter_SetLocator_31(HandleRef pThis, HandleRef locator);

		/// <summary>
		/// Set / get a spatial locator for merging points. By default,
		/// an instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x0600D8D3 RID: 55507 RVA: 0x0012D470 File Offset: 0x0012B670
		public void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkGenericContourFilter.vtkGenericContourFilter_SetLocator_31(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		// Token: 0x0600D8D4 RID: 55508
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericContourFilter_SetNumberOfContours_32(HandleRef pThis, int number);

		/// <summary>
		/// Methods to set / get contour values.
		/// </summary>
		// Token: 0x0600D8D5 RID: 55509 RVA: 0x0012D49F File Offset: 0x0012B69F
		public void SetNumberOfContours(int number)
		{
			vtkGenericContourFilter.vtkGenericContourFilter_SetNumberOfContours_32(base.GetCppThis(), number);
		}

		// Token: 0x0600D8D6 RID: 55510
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericContourFilter_SetValue_33(HandleRef pThis, int i, float value);

		/// <summary>
		/// Methods to set / get contour values.
		/// </summary>
		// Token: 0x0600D8D7 RID: 55511 RVA: 0x0012D4AF File Offset: 0x0012B6AF
		public void SetValue(int i, float value)
		{
			vtkGenericContourFilter.vtkGenericContourFilter_SetValue_33(base.GetCppThis(), i, value);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FDA RID: 4058
		public new const string MRFullTypeName = "Kitware.VTK.vtkGenericContourFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FDB RID: 4059
		public new static readonly string MRClassNameKey = "class vtkGenericContourFilter";
	}
}
