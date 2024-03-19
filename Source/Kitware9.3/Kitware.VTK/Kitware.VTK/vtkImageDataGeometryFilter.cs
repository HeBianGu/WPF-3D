using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageDataGeometryFilter
	/// </summary>
	/// <remarks>
	///    extract geometry for structured points
	///
	/// vtkImageDataGeometryFilter is a filter that extracts geometry from a
	/// structured points dataset. By specifying appropriate i-j-k indices (via the
	/// "Extent" instance variable), it is possible to extract a point, a line, a
	/// plane (i.e., image), or a "volume" from dataset. (Since the output is
	/// of type polydata, the volume is actually a (n x m x o) region of points.)
	///
	/// The extent specification is zero-offset. That is, the first k-plane in
	/// a 50x50x50 volume is given by (0,49, 0,49, 0,0).
	/// @warning
	/// If you don't know the dimensions of the input dataset, you can use a large
	/// number to specify extent (the number will be clamped appropriately). For
	/// example, if the dataset dimensions are 50x50x50, and you want a the fifth
	/// k-plane, you can use the extents (0,100, 0,100, 4,4). The 100 will
	/// automatically be clamped to 49.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkGeometryFilter vtkStructuredGridSource
	/// </seealso>
	// Token: 0x0200090C RID: 2316
	public class vtkImageDataGeometryFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06018032 RID: 98354 RVA: 0x002199AF File Offset: 0x00217BAF
		static vtkImageDataGeometryFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageDataGeometryFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageDataGeometryFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06018033 RID: 98355 RVA: 0x002199D7 File Offset: 0x00217BD7
		public vtkImageDataGeometryFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06018034 RID: 98356
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageDataGeometryFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct with initial extent of all the data
		/// </summary>
		// Token: 0x06018035 RID: 98357 RVA: 0x002199E8 File Offset: 0x00217BE8
		public new static vtkImageDataGeometryFilter New()
		{
			vtkImageDataGeometryFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageDataGeometryFilter.vtkImageDataGeometryFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageDataGeometryFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct with initial extent of all the data
		/// </summary>
		// Token: 0x06018036 RID: 98358 RVA: 0x00219A3C File Offset: 0x00217C3C
		public vtkImageDataGeometryFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageDataGeometryFilter.vtkImageDataGeometryFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06018037 RID: 98359 RVA: 0x00219A80 File Offset: 0x00217C80
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06018038 RID: 98360
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageDataGeometryFilter_GetExtent_01(HandleRef pThis);

		/// <summary>
		/// Set / get the extent (imin,imax, jmin,jmax, kmin,kmax) indices.
		/// </summary>
		// Token: 0x06018039 RID: 98361 RVA: 0x00219A8C File Offset: 0x00217C8C
		public IntPtr GetExtent()
		{
			return vtkImageDataGeometryFilter.vtkImageDataGeometryFilter_GetExtent_01(base.GetCppThis());
		}

		// Token: 0x0601803A RID: 98362
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageDataGeometryFilter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601803B RID: 98363 RVA: 0x00219AAC File Offset: 0x00217CAC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageDataGeometryFilter.vtkImageDataGeometryFilter_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601803C RID: 98364
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageDataGeometryFilter_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601803D RID: 98365 RVA: 0x00219ACC File Offset: 0x00217CCC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageDataGeometryFilter.vtkImageDataGeometryFilter_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601803E RID: 98366
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageDataGeometryFilter_GetOutputTriangles_04(HandleRef pThis);

		/// <summary>
		/// Set OutputTriangles to true if you wish to generate triangles instead of quads
		/// when extracting cells from 2D imagedata
		/// Currently this functionality is only implemented for 2D imagedata
		/// </summary>
		// Token: 0x0601803F RID: 98367 RVA: 0x00219AE8 File Offset: 0x00217CE8
		public virtual int GetOutputTriangles()
		{
			return vtkImageDataGeometryFilter.vtkImageDataGeometryFilter_GetOutputTriangles_04(base.GetCppThis());
		}

		// Token: 0x06018040 RID: 98368
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageDataGeometryFilter_GetThresholdCells_05(HandleRef pThis);

		/// <summary>
		/// Set ThresholdCells to true if you wish to skip any voxel/pixels which have scalar
		/// values less than the specified threshold.
		/// Currently this functionality is only implemented for 2D imagedata
		/// </summary>
		// Token: 0x06018041 RID: 98369 RVA: 0x00219B08 File Offset: 0x00217D08
		public virtual int GetThresholdCells()
		{
			return vtkImageDataGeometryFilter.vtkImageDataGeometryFilter_GetThresholdCells_05(base.GetCppThis());
		}

		// Token: 0x06018042 RID: 98370
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageDataGeometryFilter_GetThresholdValue_06(HandleRef pThis);

		/// <summary>
		/// Set ThresholdValue to the scalar value by which to threshold cells when extracting geometry
		/// when ThresholdCells is true. Cells with scalar values greater than the threshold will be
		/// output.
		/// </summary>
		// Token: 0x06018043 RID: 98371 RVA: 0x00219B28 File Offset: 0x00217D28
		public virtual double GetThresholdValue()
		{
			return vtkImageDataGeometryFilter.vtkImageDataGeometryFilter_GetThresholdValue_06(base.GetCppThis());
		}

		// Token: 0x06018044 RID: 98372
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageDataGeometryFilter_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018045 RID: 98373 RVA: 0x00219B48 File Offset: 0x00217D48
		public override int IsA(string type)
		{
			return vtkImageDataGeometryFilter.vtkImageDataGeometryFilter_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06018046 RID: 98374
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageDataGeometryFilter_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018047 RID: 98375 RVA: 0x00219B68 File Offset: 0x00217D68
		public new static int IsTypeOf(string type)
		{
			return vtkImageDataGeometryFilter.vtkImageDataGeometryFilter_IsTypeOf_08(type);
		}

		// Token: 0x06018048 RID: 98376
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageDataGeometryFilter_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018049 RID: 98377 RVA: 0x00219B84 File Offset: 0x00217D84
		public new vtkImageDataGeometryFilter NewInstance()
		{
			vtkImageDataGeometryFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageDataGeometryFilter.vtkImageDataGeometryFilter_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageDataGeometryFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601804A RID: 98378
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageDataGeometryFilter_OutputTrianglesOff_11(HandleRef pThis);

		/// <summary>
		/// Set OutputTriangles to true if you wish to generate triangles instead of quads
		/// when extracting cells from 2D imagedata
		/// Currently this functionality is only implemented for 2D imagedata
		/// </summary>
		// Token: 0x0601804B RID: 98379 RVA: 0x00219BDE File Offset: 0x00217DDE
		public virtual void OutputTrianglesOff()
		{
			vtkImageDataGeometryFilter.vtkImageDataGeometryFilter_OutputTrianglesOff_11(base.GetCppThis());
		}

		// Token: 0x0601804C RID: 98380
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageDataGeometryFilter_OutputTrianglesOn_12(HandleRef pThis);

		/// <summary>
		/// Set OutputTriangles to true if you wish to generate triangles instead of quads
		/// when extracting cells from 2D imagedata
		/// Currently this functionality is only implemented for 2D imagedata
		/// </summary>
		// Token: 0x0601804D RID: 98381 RVA: 0x00219BED File Offset: 0x00217DED
		public virtual void OutputTrianglesOn()
		{
			vtkImageDataGeometryFilter.vtkImageDataGeometryFilter_OutputTrianglesOn_12(base.GetCppThis());
		}

		// Token: 0x0601804E RID: 98382
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageDataGeometryFilter_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601804F RID: 98383 RVA: 0x00219BFC File Offset: 0x00217DFC
		public new static vtkImageDataGeometryFilter SafeDownCast(vtkObjectBase o)
		{
			vtkImageDataGeometryFilter vtkImageDataGeometryFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageDataGeometryFilter.vtkImageDataGeometryFilter_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageDataGeometryFilter = (vtkImageDataGeometryFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageDataGeometryFilter.Register(null);
				}
			}
			return vtkImageDataGeometryFilter;
		}

		// Token: 0x06018050 RID: 98384
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageDataGeometryFilter_SetExtent_14(HandleRef pThis, IntPtr extent);

		/// <summary>
		/// Set / get the extent (imin,imax, jmin,jmax, kmin,kmax) indices.
		/// </summary>
		// Token: 0x06018051 RID: 98385 RVA: 0x00219C7B File Offset: 0x00217E7B
		public void SetExtent(IntPtr extent)
		{
			vtkImageDataGeometryFilter.vtkImageDataGeometryFilter_SetExtent_14(base.GetCppThis(), extent);
		}

		// Token: 0x06018052 RID: 98386
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageDataGeometryFilter_SetExtent_15(HandleRef pThis, int iMin, int iMax, int jMin, int jMax, int kMin, int kMax);

		/// <summary>
		/// Set / get the extent (imin,imax, jmin,jmax, kmin,kmax) indices.
		/// </summary>
		// Token: 0x06018053 RID: 98387 RVA: 0x00219C8B File Offset: 0x00217E8B
		public void SetExtent(int iMin, int iMax, int jMin, int jMax, int kMin, int kMax)
		{
			vtkImageDataGeometryFilter.vtkImageDataGeometryFilter_SetExtent_15(base.GetCppThis(), iMin, iMax, jMin, jMax, kMin, kMax);
		}

		// Token: 0x06018054 RID: 98388
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageDataGeometryFilter_SetOutputTriangles_16(HandleRef pThis, int _arg);

		/// <summary>
		/// Set OutputTriangles to true if you wish to generate triangles instead of quads
		/// when extracting cells from 2D imagedata
		/// Currently this functionality is only implemented for 2D imagedata
		/// </summary>
		// Token: 0x06018055 RID: 98389 RVA: 0x00219CA3 File Offset: 0x00217EA3
		public virtual void SetOutputTriangles(int _arg)
		{
			vtkImageDataGeometryFilter.vtkImageDataGeometryFilter_SetOutputTriangles_16(base.GetCppThis(), _arg);
		}

		// Token: 0x06018056 RID: 98390
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageDataGeometryFilter_SetThresholdCells_17(HandleRef pThis, int _arg);

		/// <summary>
		/// Set ThresholdCells to true if you wish to skip any voxel/pixels which have scalar
		/// values less than the specified threshold.
		/// Currently this functionality is only implemented for 2D imagedata
		/// </summary>
		// Token: 0x06018057 RID: 98391 RVA: 0x00219CB3 File Offset: 0x00217EB3
		public virtual void SetThresholdCells(int _arg)
		{
			vtkImageDataGeometryFilter.vtkImageDataGeometryFilter_SetThresholdCells_17(base.GetCppThis(), _arg);
		}

		// Token: 0x06018058 RID: 98392
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageDataGeometryFilter_SetThresholdValue_18(HandleRef pThis, double _arg);

		/// <summary>
		/// Set ThresholdValue to the scalar value by which to threshold cells when extracting geometry
		/// when ThresholdCells is true. Cells with scalar values greater than the threshold will be
		/// output.
		/// </summary>
		// Token: 0x06018059 RID: 98393 RVA: 0x00219CC3 File Offset: 0x00217EC3
		public virtual void SetThresholdValue(double _arg)
		{
			vtkImageDataGeometryFilter.vtkImageDataGeometryFilter_SetThresholdValue_18(base.GetCppThis(), _arg);
		}

		// Token: 0x0601805A RID: 98394
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageDataGeometryFilter_ThresholdCellsOff_19(HandleRef pThis);

		/// <summary>
		/// Set ThresholdCells to true if you wish to skip any voxel/pixels which have scalar
		/// values less than the specified threshold.
		/// Currently this functionality is only implemented for 2D imagedata
		/// </summary>
		// Token: 0x0601805B RID: 98395 RVA: 0x00219CD3 File Offset: 0x00217ED3
		public virtual void ThresholdCellsOff()
		{
			vtkImageDataGeometryFilter.vtkImageDataGeometryFilter_ThresholdCellsOff_19(base.GetCppThis());
		}

		// Token: 0x0601805C RID: 98396
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageDataGeometryFilter_ThresholdCellsOn_20(HandleRef pThis);

		/// <summary>
		/// Set ThresholdCells to true if you wish to skip any voxel/pixels which have scalar
		/// values less than the specified threshold.
		/// Currently this functionality is only implemented for 2D imagedata
		/// </summary>
		// Token: 0x0601805D RID: 98397 RVA: 0x00219CE2 File Offset: 0x00217EE2
		public virtual void ThresholdCellsOn()
		{
			vtkImageDataGeometryFilter.vtkImageDataGeometryFilter_ThresholdCellsOn_20(base.GetCppThis());
		}

		// Token: 0x0601805E RID: 98398
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageDataGeometryFilter_ThresholdValueOff_21(HandleRef pThis);

		/// <summary>
		/// Set ThresholdValue to the scalar value by which to threshold cells when extracting geometry
		/// when ThresholdCells is true. Cells with scalar values greater than the threshold will be
		/// output.
		/// </summary>
		// Token: 0x0601805F RID: 98399 RVA: 0x00219CF1 File Offset: 0x00217EF1
		public virtual void ThresholdValueOff()
		{
			vtkImageDataGeometryFilter.vtkImageDataGeometryFilter_ThresholdValueOff_21(base.GetCppThis());
		}

		// Token: 0x06018060 RID: 98400
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageDataGeometryFilter_ThresholdValueOn_22(HandleRef pThis);

		/// <summary>
		/// Set ThresholdValue to the scalar value by which to threshold cells when extracting geometry
		/// when ThresholdCells is true. Cells with scalar values greater than the threshold will be
		/// output.
		/// </summary>
		// Token: 0x06018061 RID: 98401 RVA: 0x00219D00 File Offset: 0x00217F00
		public virtual void ThresholdValueOn()
		{
			vtkImageDataGeometryFilter.vtkImageDataGeometryFilter_ThresholdValueOn_22(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AC2 RID: 6850
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageDataGeometryFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AC3 RID: 6851
		public new static readonly string MRClassNameKey = "class vtkImageDataGeometryFilter";
	}
}
