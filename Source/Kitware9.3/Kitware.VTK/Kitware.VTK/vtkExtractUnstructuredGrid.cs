using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExtractUnstructuredGrid
	/// </summary>
	/// <remarks>
	///    extract subset of unstructured grid geometry
	///
	/// vtkExtractUnstructuredGrid is a general-purpose filter to
	/// extract geometry (and associated data) from an unstructured grid
	/// dataset. The extraction process is controlled by specifying a range
	/// of point ids, cell ids, or a bounding box (referred to as "Extent").
	/// Those cells laying within these regions are sent to the output.
	/// The user has the choice of merging coincident points (Merging is on)
	/// or using the original point set (Merging is off).
	///
	/// @warning
	/// If merging is off, the input points are copied through to the
	/// output. This means unused points may be present in the output data.
	/// If merging is on, then coincident points with different point attribute
	/// values are merged.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkImageDataGeometryFilter vtkStructuredGridGeometryFilter
	/// vtkRectilinearGridGeometryFilter
	/// vtkExtractGeometry vtkExtractVOI
	/// </seealso>
	// Token: 0x020006BC RID: 1724
	public class vtkExtractUnstructuredGrid : vtkUnstructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012667 RID: 75367 RVA: 0x0019C564 File Offset: 0x0019A764
		static vtkExtractUnstructuredGrid()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractUnstructuredGrid.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractUnstructuredGrid"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012668 RID: 75368 RVA: 0x0019C58C File Offset: 0x0019A78C
		public vtkExtractUnstructuredGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012669 RID: 75369
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractUnstructuredGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct with all types of clipping turned off.
		/// </summary>
		// Token: 0x0601266A RID: 75370 RVA: 0x0019C59C File Offset: 0x0019A79C
		public new static vtkExtractUnstructuredGrid New()
		{
			vtkExtractUnstructuredGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct with all types of clipping turned off.
		/// </summary>
		// Token: 0x0601266B RID: 75371 RVA: 0x0019C5F0 File Offset: 0x0019A7F0
		public vtkExtractUnstructuredGrid() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601266C RID: 75372 RVA: 0x0019C634 File Offset: 0x0019A834
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601266D RID: 75373
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractUnstructuredGrid_CellClippingOff_01(HandleRef pThis);

		/// <summary>
		/// Turn on/off selection of geometry by cell id.
		/// </summary>
		// Token: 0x0601266E RID: 75374 RVA: 0x0019C63F File Offset: 0x0019A83F
		public virtual void CellClippingOff()
		{
			vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_CellClippingOff_01(base.GetCppThis());
		}

		// Token: 0x0601266F RID: 75375
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractUnstructuredGrid_CellClippingOn_02(HandleRef pThis);

		/// <summary>
		/// Turn on/off selection of geometry by cell id.
		/// </summary>
		// Token: 0x06012670 RID: 75376 RVA: 0x0019C64E File Offset: 0x0019A84E
		public virtual void CellClippingOn()
		{
			vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_CellClippingOn_02(base.GetCppThis());
		}

		// Token: 0x06012671 RID: 75377
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractUnstructuredGrid_CreateDefaultLocator_03(HandleRef pThis);

		/// <summary>
		/// Create default locator. Used to create one when none is specified.
		/// </summary>
		// Token: 0x06012672 RID: 75378 RVA: 0x0019C65D File Offset: 0x0019A85D
		public void CreateDefaultLocator()
		{
			vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_CreateDefaultLocator_03(base.GetCppThis());
		}

		// Token: 0x06012673 RID: 75379
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractUnstructuredGrid_ExtentClippingOff_04(HandleRef pThis);

		/// <summary>
		/// Turn on/off selection of geometry via bounding box.
		/// </summary>
		// Token: 0x06012674 RID: 75380 RVA: 0x0019C66C File Offset: 0x0019A86C
		public virtual void ExtentClippingOff()
		{
			vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_ExtentClippingOff_04(base.GetCppThis());
		}

		// Token: 0x06012675 RID: 75381
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractUnstructuredGrid_ExtentClippingOn_05(HandleRef pThis);

		/// <summary>
		/// Turn on/off selection of geometry via bounding box.
		/// </summary>
		// Token: 0x06012676 RID: 75382 RVA: 0x0019C67B File Offset: 0x0019A87B
		public virtual void ExtentClippingOn()
		{
			vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_ExtentClippingOn_05(base.GetCppThis());
		}

		// Token: 0x06012677 RID: 75383
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractUnstructuredGrid_GetCellClipping_06(HandleRef pThis);

		/// <summary>
		/// Turn on/off selection of geometry by cell id.
		/// </summary>
		// Token: 0x06012678 RID: 75384 RVA: 0x0019C68C File Offset: 0x0019A88C
		public virtual int GetCellClipping()
		{
			return vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_GetCellClipping_06(base.GetCppThis());
		}

		// Token: 0x06012679 RID: 75385
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractUnstructuredGrid_GetCellMaximum_07(HandleRef pThis);

		/// <summary>
		/// Specify the maximum cell id for point id selection.
		/// </summary>
		// Token: 0x0601267A RID: 75386 RVA: 0x0019C6AC File Offset: 0x0019A8AC
		public virtual long GetCellMaximum()
		{
			return vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_GetCellMaximum_07(base.GetCppThis());
		}

		// Token: 0x0601267B RID: 75387
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractUnstructuredGrid_GetCellMaximumMaxValue_08(HandleRef pThis);

		/// <summary>
		/// Specify the maximum cell id for point id selection.
		/// </summary>
		// Token: 0x0601267C RID: 75388 RVA: 0x0019C6CC File Offset: 0x0019A8CC
		public virtual long GetCellMaximumMaxValue()
		{
			return vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_GetCellMaximumMaxValue_08(base.GetCppThis());
		}

		// Token: 0x0601267D RID: 75389
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractUnstructuredGrid_GetCellMaximumMinValue_09(HandleRef pThis);

		/// <summary>
		/// Specify the maximum cell id for point id selection.
		/// </summary>
		// Token: 0x0601267E RID: 75390 RVA: 0x0019C6EC File Offset: 0x0019A8EC
		public virtual long GetCellMaximumMinValue()
		{
			return vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_GetCellMaximumMinValue_09(base.GetCppThis());
		}

		// Token: 0x0601267F RID: 75391
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractUnstructuredGrid_GetCellMinimum_10(HandleRef pThis);

		/// <summary>
		/// Specify the minimum cell id for point id selection.
		/// </summary>
		// Token: 0x06012680 RID: 75392 RVA: 0x0019C70C File Offset: 0x0019A90C
		public virtual long GetCellMinimum()
		{
			return vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_GetCellMinimum_10(base.GetCppThis());
		}

		// Token: 0x06012681 RID: 75393
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractUnstructuredGrid_GetCellMinimumMaxValue_11(HandleRef pThis);

		/// <summary>
		/// Specify the minimum cell id for point id selection.
		/// </summary>
		// Token: 0x06012682 RID: 75394 RVA: 0x0019C72C File Offset: 0x0019A92C
		public virtual long GetCellMinimumMaxValue()
		{
			return vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_GetCellMinimumMaxValue_11(base.GetCppThis());
		}

		// Token: 0x06012683 RID: 75395
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractUnstructuredGrid_GetCellMinimumMinValue_12(HandleRef pThis);

		/// <summary>
		/// Specify the minimum cell id for point id selection.
		/// </summary>
		// Token: 0x06012684 RID: 75396 RVA: 0x0019C74C File Offset: 0x0019A94C
		public virtual long GetCellMinimumMinValue()
		{
			return vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_GetCellMinimumMinValue_12(base.GetCppThis());
		}

		// Token: 0x06012685 RID: 75397
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractUnstructuredGrid_GetExtent_13(HandleRef pThis);

		/// <summary>
		/// Set / get a (xmin,xmax, ymin,ymax, zmin,zmax) bounding box to clip data.
		/// </summary>
		// Token: 0x06012686 RID: 75398 RVA: 0x0019C76C File Offset: 0x0019A96C
		public double[] GetExtent()
		{
			IntPtr intPtr = vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_GetExtent_13(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06012687 RID: 75399
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractUnstructuredGrid_GetExtentClipping_14(HandleRef pThis);

		/// <summary>
		/// Turn on/off selection of geometry via bounding box.
		/// </summary>
		// Token: 0x06012688 RID: 75400 RVA: 0x0019C7B4 File Offset: 0x0019A9B4
		public virtual int GetExtentClipping()
		{
			return vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_GetExtentClipping_14(base.GetCppThis());
		}

		// Token: 0x06012689 RID: 75401
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractUnstructuredGrid_GetLocator_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set / get a spatial locator for merging points. By
		/// default an instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x0601268A RID: 75402 RVA: 0x0019C7D4 File Offset: 0x0019A9D4
		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_GetLocator_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601268B RID: 75403
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkExtractUnstructuredGrid_GetMTime_16(HandleRef pThis);

		/// <summary>
		/// Return the MTime also considering the locator.
		/// </summary>
		// Token: 0x0601268C RID: 75404 RVA: 0x0019C844 File Offset: 0x0019AA44
		public override ulong GetMTime()
		{
			return vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_GetMTime_16(base.GetCppThis());
		}

		// Token: 0x0601268D RID: 75405
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractUnstructuredGrid_GetMerging_17(HandleRef pThis);

		/// <summary>
		/// Turn on/off merging of coincident points. Note that is merging is
		/// on, points with different point attributes (e.g., normals) are merged,
		/// which may cause rendering artifacts.
		/// </summary>
		// Token: 0x0601268E RID: 75406 RVA: 0x0019C864 File Offset: 0x0019AA64
		public virtual int GetMerging()
		{
			return vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_GetMerging_17(base.GetCppThis());
		}

		// Token: 0x0601268F RID: 75407
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractUnstructuredGrid_GetNumberOfGenerationsFromBase_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012690 RID: 75408 RVA: 0x0019C884 File Offset: 0x0019AA84
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_GetNumberOfGenerationsFromBase_18(base.GetCppThis(), type);
		}

		// Token: 0x06012691 RID: 75409
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractUnstructuredGrid_GetNumberOfGenerationsFromBaseType_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012692 RID: 75410 RVA: 0x0019C8A4 File Offset: 0x0019AAA4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_GetNumberOfGenerationsFromBaseType_19(type);
		}

		// Token: 0x06012693 RID: 75411
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractUnstructuredGrid_GetPointClipping_20(HandleRef pThis);

		/// <summary>
		/// Turn on/off selection of geometry by point id.
		/// </summary>
		// Token: 0x06012694 RID: 75412 RVA: 0x0019C8C0 File Offset: 0x0019AAC0
		public virtual int GetPointClipping()
		{
			return vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_GetPointClipping_20(base.GetCppThis());
		}

		// Token: 0x06012695 RID: 75413
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractUnstructuredGrid_GetPointMaximum_21(HandleRef pThis);

		/// <summary>
		/// Specify the maximum point id for point id selection.
		/// </summary>
		// Token: 0x06012696 RID: 75414 RVA: 0x0019C8E0 File Offset: 0x0019AAE0
		public virtual long GetPointMaximum()
		{
			return vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_GetPointMaximum_21(base.GetCppThis());
		}

		// Token: 0x06012697 RID: 75415
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractUnstructuredGrid_GetPointMaximumMaxValue_22(HandleRef pThis);

		/// <summary>
		/// Specify the maximum point id for point id selection.
		/// </summary>
		// Token: 0x06012698 RID: 75416 RVA: 0x0019C900 File Offset: 0x0019AB00
		public virtual long GetPointMaximumMaxValue()
		{
			return vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_GetPointMaximumMaxValue_22(base.GetCppThis());
		}

		// Token: 0x06012699 RID: 75417
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractUnstructuredGrid_GetPointMaximumMinValue_23(HandleRef pThis);

		/// <summary>
		/// Specify the maximum point id for point id selection.
		/// </summary>
		// Token: 0x0601269A RID: 75418 RVA: 0x0019C920 File Offset: 0x0019AB20
		public virtual long GetPointMaximumMinValue()
		{
			return vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_GetPointMaximumMinValue_23(base.GetCppThis());
		}

		// Token: 0x0601269B RID: 75419
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractUnstructuredGrid_GetPointMinimum_24(HandleRef pThis);

		/// <summary>
		/// Specify the minimum point id for point id selection.
		/// </summary>
		// Token: 0x0601269C RID: 75420 RVA: 0x0019C940 File Offset: 0x0019AB40
		public virtual long GetPointMinimum()
		{
			return vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_GetPointMinimum_24(base.GetCppThis());
		}

		// Token: 0x0601269D RID: 75421
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractUnstructuredGrid_GetPointMinimumMaxValue_25(HandleRef pThis);

		/// <summary>
		/// Specify the minimum point id for point id selection.
		/// </summary>
		// Token: 0x0601269E RID: 75422 RVA: 0x0019C960 File Offset: 0x0019AB60
		public virtual long GetPointMinimumMaxValue()
		{
			return vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_GetPointMinimumMaxValue_25(base.GetCppThis());
		}

		// Token: 0x0601269F RID: 75423
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractUnstructuredGrid_GetPointMinimumMinValue_26(HandleRef pThis);

		/// <summary>
		/// Specify the minimum point id for point id selection.
		/// </summary>
		// Token: 0x060126A0 RID: 75424 RVA: 0x0019C980 File Offset: 0x0019AB80
		public virtual long GetPointMinimumMinValue()
		{
			return vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_GetPointMinimumMinValue_26(base.GetCppThis());
		}

		// Token: 0x060126A1 RID: 75425
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractUnstructuredGrid_IsA_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060126A2 RID: 75426 RVA: 0x0019C9A0 File Offset: 0x0019ABA0
		public override int IsA(string type)
		{
			return vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_IsA_27(base.GetCppThis(), type);
		}

		// Token: 0x060126A3 RID: 75427
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractUnstructuredGrid_IsTypeOf_28([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060126A4 RID: 75428 RVA: 0x0019C9C0 File Offset: 0x0019ABC0
		public new static int IsTypeOf(string type)
		{
			return vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_IsTypeOf_28(type);
		}

		// Token: 0x060126A5 RID: 75429
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractUnstructuredGrid_MergingOff_29(HandleRef pThis);

		/// <summary>
		/// Turn on/off merging of coincident points. Note that is merging is
		/// on, points with different point attributes (e.g., normals) are merged,
		/// which may cause rendering artifacts.
		/// </summary>
		// Token: 0x060126A6 RID: 75430 RVA: 0x0019C9DA File Offset: 0x0019ABDA
		public virtual void MergingOff()
		{
			vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_MergingOff_29(base.GetCppThis());
		}

		// Token: 0x060126A7 RID: 75431
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractUnstructuredGrid_MergingOn_30(HandleRef pThis);

		/// <summary>
		/// Turn on/off merging of coincident points. Note that is merging is
		/// on, points with different point attributes (e.g., normals) are merged,
		/// which may cause rendering artifacts.
		/// </summary>
		// Token: 0x060126A8 RID: 75432 RVA: 0x0019C9E9 File Offset: 0x0019ABE9
		public virtual void MergingOn()
		{
			vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_MergingOn_30(base.GetCppThis());
		}

		// Token: 0x060126A9 RID: 75433
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractUnstructuredGrid_NewInstance_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060126AA RID: 75434 RVA: 0x0019C9F8 File Offset: 0x0019ABF8
		public new vtkExtractUnstructuredGrid NewInstance()
		{
			vtkExtractUnstructuredGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_NewInstance_32(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060126AB RID: 75435
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractUnstructuredGrid_PointClippingOff_33(HandleRef pThis);

		/// <summary>
		/// Turn on/off selection of geometry by point id.
		/// </summary>
		// Token: 0x060126AC RID: 75436 RVA: 0x0019CA52 File Offset: 0x0019AC52
		public virtual void PointClippingOff()
		{
			vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_PointClippingOff_33(base.GetCppThis());
		}

		// Token: 0x060126AD RID: 75437
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractUnstructuredGrid_PointClippingOn_34(HandleRef pThis);

		/// <summary>
		/// Turn on/off selection of geometry by point id.
		/// </summary>
		// Token: 0x060126AE RID: 75438 RVA: 0x0019CA61 File Offset: 0x0019AC61
		public virtual void PointClippingOn()
		{
			vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_PointClippingOn_34(base.GetCppThis());
		}

		// Token: 0x060126AF RID: 75439
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractUnstructuredGrid_SafeDownCast_35(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060126B0 RID: 75440 RVA: 0x0019CA70 File Offset: 0x0019AC70
		public new static vtkExtractUnstructuredGrid SafeDownCast(vtkObjectBase o)
		{
			vtkExtractUnstructuredGrid vtkExtractUnstructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_SafeDownCast_35((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractUnstructuredGrid = (vtkExtractUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractUnstructuredGrid.Register(null);
				}
			}
			return vtkExtractUnstructuredGrid;
		}

		// Token: 0x060126B1 RID: 75441
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractUnstructuredGrid_SetCellClipping_36(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off selection of geometry by cell id.
		/// </summary>
		// Token: 0x060126B2 RID: 75442 RVA: 0x0019CAEF File Offset: 0x0019ACEF
		public virtual void SetCellClipping(int _arg)
		{
			vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_SetCellClipping_36(base.GetCppThis(), _arg);
		}

		// Token: 0x060126B3 RID: 75443
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractUnstructuredGrid_SetCellMaximum_37(HandleRef pThis, long _arg);

		/// <summary>
		/// Specify the maximum cell id for point id selection.
		/// </summary>
		// Token: 0x060126B4 RID: 75444 RVA: 0x0019CAFF File Offset: 0x0019ACFF
		public virtual void SetCellMaximum(long _arg)
		{
			vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_SetCellMaximum_37(base.GetCppThis(), _arg);
		}

		// Token: 0x060126B5 RID: 75445
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractUnstructuredGrid_SetCellMinimum_38(HandleRef pThis, long _arg);

		/// <summary>
		/// Specify the minimum cell id for point id selection.
		/// </summary>
		// Token: 0x060126B6 RID: 75446 RVA: 0x0019CB0F File Offset: 0x0019AD0F
		public virtual void SetCellMinimum(long _arg)
		{
			vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_SetCellMinimum_38(base.GetCppThis(), _arg);
		}

		// Token: 0x060126B7 RID: 75447
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractUnstructuredGrid_SetExtent_39(HandleRef pThis, double xMin, double xMax, double yMin, double yMax, double zMin, double zMax);

		/// <summary>
		/// Specify a (xmin,xmax, ymin,ymax, zmin,zmax) bounding box to clip data.
		/// </summary>
		// Token: 0x060126B8 RID: 75448 RVA: 0x0019CB1F File Offset: 0x0019AD1F
		public void SetExtent(double xMin, double xMax, double yMin, double yMax, double zMin, double zMax)
		{
			vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_SetExtent_39(base.GetCppThis(), xMin, xMax, yMin, yMax, zMin, zMax);
		}

		// Token: 0x060126B9 RID: 75449
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractUnstructuredGrid_SetExtent_40(HandleRef pThis, IntPtr extent);

		/// <summary>
		/// Set / get a (xmin,xmax, ymin,ymax, zmin,zmax) bounding box to clip data.
		/// </summary>
		// Token: 0x060126BA RID: 75450 RVA: 0x0019CB37 File Offset: 0x0019AD37
		public void SetExtent(IntPtr extent)
		{
			vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_SetExtent_40(base.GetCppThis(), extent);
		}

		// Token: 0x060126BB RID: 75451
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractUnstructuredGrid_SetExtentClipping_41(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off selection of geometry via bounding box.
		/// </summary>
		// Token: 0x060126BC RID: 75452 RVA: 0x0019CB47 File Offset: 0x0019AD47
		public virtual void SetExtentClipping(int _arg)
		{
			vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_SetExtentClipping_41(base.GetCppThis(), _arg);
		}

		// Token: 0x060126BD RID: 75453
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractUnstructuredGrid_SetLocator_42(HandleRef pThis, HandleRef locator);

		/// <summary>
		/// Set / get a spatial locator for merging points. By
		/// default an instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x060126BE RID: 75454 RVA: 0x0019CB58 File Offset: 0x0019AD58
		public void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_SetLocator_42(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		// Token: 0x060126BF RID: 75455
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractUnstructuredGrid_SetMerging_43(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off merging of coincident points. Note that is merging is
		/// on, points with different point attributes (e.g., normals) are merged,
		/// which may cause rendering artifacts.
		/// </summary>
		// Token: 0x060126C0 RID: 75456 RVA: 0x0019CB87 File Offset: 0x0019AD87
		public virtual void SetMerging(int _arg)
		{
			vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_SetMerging_43(base.GetCppThis(), _arg);
		}

		// Token: 0x060126C1 RID: 75457
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractUnstructuredGrid_SetPointClipping_44(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off selection of geometry by point id.
		/// </summary>
		// Token: 0x060126C2 RID: 75458 RVA: 0x0019CB97 File Offset: 0x0019AD97
		public virtual void SetPointClipping(int _arg)
		{
			vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_SetPointClipping_44(base.GetCppThis(), _arg);
		}

		// Token: 0x060126C3 RID: 75459
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractUnstructuredGrid_SetPointMaximum_45(HandleRef pThis, long _arg);

		/// <summary>
		/// Specify the maximum point id for point id selection.
		/// </summary>
		// Token: 0x060126C4 RID: 75460 RVA: 0x0019CBA7 File Offset: 0x0019ADA7
		public virtual void SetPointMaximum(long _arg)
		{
			vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_SetPointMaximum_45(base.GetCppThis(), _arg);
		}

		// Token: 0x060126C5 RID: 75461
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractUnstructuredGrid_SetPointMinimum_46(HandleRef pThis, long _arg);

		/// <summary>
		/// Specify the minimum point id for point id selection.
		/// </summary>
		// Token: 0x060126C6 RID: 75462 RVA: 0x0019CBB7 File Offset: 0x0019ADB7
		public virtual void SetPointMinimum(long _arg)
		{
			vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_SetPointMinimum_46(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001528 RID: 5416
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractUnstructuredGrid";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001529 RID: 5417
		public new static readonly string MRClassNameKey = "class vtkExtractUnstructuredGrid";
	}
}
