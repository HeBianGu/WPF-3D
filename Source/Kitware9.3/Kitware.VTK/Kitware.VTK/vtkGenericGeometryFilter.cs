using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGenericGeometryFilter
	/// </summary>
	/// <remarks>
	///    extract geometry from data (or convert data to polygonal type)
	///
	/// vtkGenericGeometryFilter is a general-purpose filter to extract geometry (and
	/// associated data) from any type of dataset. Geometry is obtained as
	/// follows: all 0D, 1D, and 2D cells are extracted. All 2D faces that are
	/// used by only one 3D cell (i.e., boundary faces) are extracted. It also is
	/// possible to specify conditions on point ids, cell ids, and on
	/// bounding box (referred to as "Extent") to control the extraction process.
	///
	/// This filter also may be used to convert any type of data to polygonal
	/// type. The conversion process may be less than satisfactory for some 3D
	/// datasets. For example, this filter will extract the outer surface of a
	/// volume or structured grid dataset. (For structured data you may want to
	/// use vtkImageDataGeometryFilter, vtkStructuredGridGeometryFilter,
	/// vtkExtractUnstructuredGrid, vtkRectilinearGridGeometryFilter, or
	/// vtkExtractVOI.)
	///
	/// @warning
	/// When vtkGenericGeometryFilter extracts cells (or boundaries of cells) it
	/// will (by default) merge duplicate vertices. This may cause problems
	/// in some cases. For example, if you've run vtkPolyDataNormals to
	/// generate normals, which may split meshes and create duplicate
	/// vertices, vtkGenericGeometryFilter will merge these points back
	/// together. Turn merging off to prevent this from occurring.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkImageDataGeometryFilter vtkStructuredGridGeometryFilter
	/// vtkExtractGeometry vtkExtractVOI
	/// </seealso>
	// Token: 0x0200049C RID: 1180
	public class vtkGenericGeometryFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D938 RID: 55608 RVA: 0x0012DCFB File Offset: 0x0012BEFB
		static vtkGenericGeometryFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenericGeometryFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericGeometryFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D939 RID: 55609 RVA: 0x0012DD23 File Offset: 0x0012BF23
		public vtkGenericGeometryFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600D93A RID: 55610
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericGeometryFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D93B RID: 55611 RVA: 0x0012DD34 File Offset: 0x0012BF34
		public new static vtkGenericGeometryFilter New()
		{
			vtkGenericGeometryFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericGeometryFilter.vtkGenericGeometryFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericGeometryFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D93C RID: 55612 RVA: 0x0012DD88 File Offset: 0x0012BF88
		public vtkGenericGeometryFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGenericGeometryFilter.vtkGenericGeometryFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D93D RID: 55613 RVA: 0x0012DDCC File Offset: 0x0012BFCC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D93E RID: 55614
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGeometryFilter_CellClippingOff_01(HandleRef pThis);

		/// <summary>
		/// Turn on/off selection of geometry by cell id.
		/// </summary>
		// Token: 0x0600D93F RID: 55615 RVA: 0x0012DDD7 File Offset: 0x0012BFD7
		public virtual void CellClippingOff()
		{
			vtkGenericGeometryFilter.vtkGenericGeometryFilter_CellClippingOff_01(base.GetCppThis());
		}

		// Token: 0x0600D940 RID: 55616
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGeometryFilter_CellClippingOn_02(HandleRef pThis);

		/// <summary>
		/// Turn on/off selection of geometry by cell id.
		/// </summary>
		// Token: 0x0600D941 RID: 55617 RVA: 0x0012DDE6 File Offset: 0x0012BFE6
		public virtual void CellClippingOn()
		{
			vtkGenericGeometryFilter.vtkGenericGeometryFilter_CellClippingOn_02(base.GetCppThis());
		}

		// Token: 0x0600D942 RID: 55618
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGeometryFilter_CreateDefaultLocator_03(HandleRef pThis);

		/// <summary>
		/// Create default locator. Used to create one when none is specified.
		/// </summary>
		// Token: 0x0600D943 RID: 55619 RVA: 0x0012DDF5 File Offset: 0x0012BFF5
		public void CreateDefaultLocator()
		{
			vtkGenericGeometryFilter.vtkGenericGeometryFilter_CreateDefaultLocator_03(base.GetCppThis());
		}

		// Token: 0x0600D944 RID: 55620
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGeometryFilter_ExtentClippingOff_04(HandleRef pThis);

		/// <summary>
		/// Turn on/off selection of geometry via bounding box.
		/// </summary>
		// Token: 0x0600D945 RID: 55621 RVA: 0x0012DE04 File Offset: 0x0012C004
		public virtual void ExtentClippingOff()
		{
			vtkGenericGeometryFilter.vtkGenericGeometryFilter_ExtentClippingOff_04(base.GetCppThis());
		}

		// Token: 0x0600D946 RID: 55622
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGeometryFilter_ExtentClippingOn_05(HandleRef pThis);

		/// <summary>
		/// Turn on/off selection of geometry via bounding box.
		/// </summary>
		// Token: 0x0600D947 RID: 55623 RVA: 0x0012DE13 File Offset: 0x0012C013
		public virtual void ExtentClippingOn()
		{
			vtkGenericGeometryFilter.vtkGenericGeometryFilter_ExtentClippingOn_05(base.GetCppThis());
		}

		// Token: 0x0600D948 RID: 55624
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericGeometryFilter_GetCellClipping_06(HandleRef pThis);

		/// <summary>
		/// Turn on/off selection of geometry by cell id.
		/// </summary>
		// Token: 0x0600D949 RID: 55625 RVA: 0x0012DE24 File Offset: 0x0012C024
		public virtual int GetCellClipping()
		{
			return vtkGenericGeometryFilter.vtkGenericGeometryFilter_GetCellClipping_06(base.GetCppThis());
		}

		// Token: 0x0600D94A RID: 55626
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericGeometryFilter_GetCellMaximum_07(HandleRef pThis);

		/// <summary>
		/// Specify the maximum cell id for point id selection.
		/// </summary>
		// Token: 0x0600D94B RID: 55627 RVA: 0x0012DE44 File Offset: 0x0012C044
		public virtual long GetCellMaximum()
		{
			return vtkGenericGeometryFilter.vtkGenericGeometryFilter_GetCellMaximum_07(base.GetCppThis());
		}

		// Token: 0x0600D94C RID: 55628
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericGeometryFilter_GetCellMaximumMaxValue_08(HandleRef pThis);

		/// <summary>
		/// Specify the maximum cell id for point id selection.
		/// </summary>
		// Token: 0x0600D94D RID: 55629 RVA: 0x0012DE64 File Offset: 0x0012C064
		public virtual long GetCellMaximumMaxValue()
		{
			return vtkGenericGeometryFilter.vtkGenericGeometryFilter_GetCellMaximumMaxValue_08(base.GetCppThis());
		}

		// Token: 0x0600D94E RID: 55630
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericGeometryFilter_GetCellMaximumMinValue_09(HandleRef pThis);

		/// <summary>
		/// Specify the maximum cell id for point id selection.
		/// </summary>
		// Token: 0x0600D94F RID: 55631 RVA: 0x0012DE84 File Offset: 0x0012C084
		public virtual long GetCellMaximumMinValue()
		{
			return vtkGenericGeometryFilter.vtkGenericGeometryFilter_GetCellMaximumMinValue_09(base.GetCppThis());
		}

		// Token: 0x0600D950 RID: 55632
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericGeometryFilter_GetCellMinimum_10(HandleRef pThis);

		/// <summary>
		/// Specify the minimum cell id for point id selection.
		/// </summary>
		// Token: 0x0600D951 RID: 55633 RVA: 0x0012DEA4 File Offset: 0x0012C0A4
		public virtual long GetCellMinimum()
		{
			return vtkGenericGeometryFilter.vtkGenericGeometryFilter_GetCellMinimum_10(base.GetCppThis());
		}

		// Token: 0x0600D952 RID: 55634
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericGeometryFilter_GetCellMinimumMaxValue_11(HandleRef pThis);

		/// <summary>
		/// Specify the minimum cell id for point id selection.
		/// </summary>
		// Token: 0x0600D953 RID: 55635 RVA: 0x0012DEC4 File Offset: 0x0012C0C4
		public virtual long GetCellMinimumMaxValue()
		{
			return vtkGenericGeometryFilter.vtkGenericGeometryFilter_GetCellMinimumMaxValue_11(base.GetCppThis());
		}

		// Token: 0x0600D954 RID: 55636
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericGeometryFilter_GetCellMinimumMinValue_12(HandleRef pThis);

		/// <summary>
		/// Specify the minimum cell id for point id selection.
		/// </summary>
		// Token: 0x0600D955 RID: 55637 RVA: 0x0012DEE4 File Offset: 0x0012C0E4
		public virtual long GetCellMinimumMinValue()
		{
			return vtkGenericGeometryFilter.vtkGenericGeometryFilter_GetCellMinimumMinValue_12(base.GetCppThis());
		}

		// Token: 0x0600D956 RID: 55638
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericGeometryFilter_GetExtent_13(HandleRef pThis);

		/// <summary>
		/// Set / get a (xmin,xmax, ymin,ymax, zmin,zmax) bounding box to clip data.
		/// </summary>
		// Token: 0x0600D957 RID: 55639 RVA: 0x0012DF04 File Offset: 0x0012C104
		public IntPtr GetExtent()
		{
			return vtkGenericGeometryFilter.vtkGenericGeometryFilter_GetExtent_13(base.GetCppThis());
		}

		// Token: 0x0600D958 RID: 55640
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericGeometryFilter_GetExtentClipping_14(HandleRef pThis);

		/// <summary>
		/// Turn on/off selection of geometry via bounding box.
		/// </summary>
		// Token: 0x0600D959 RID: 55641 RVA: 0x0012DF24 File Offset: 0x0012C124
		public virtual int GetExtentClipping()
		{
			return vtkGenericGeometryFilter.vtkGenericGeometryFilter_GetExtentClipping_14(base.GetCppThis());
		}

		// Token: 0x0600D95A RID: 55642
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericGeometryFilter_GetLocator_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set / get a spatial locator for merging points. By
		/// default an instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x0600D95B RID: 55643 RVA: 0x0012DF44 File Offset: 0x0012C144
		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericGeometryFilter.vtkGenericGeometryFilter_GetLocator_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600D95C RID: 55644
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkGenericGeometryFilter_GetMTime_16(HandleRef pThis);

		/// <summary>
		/// Return the MTime also considering the locator.
		/// </summary>
		// Token: 0x0600D95D RID: 55645 RVA: 0x0012DFB4 File Offset: 0x0012C1B4
		public override ulong GetMTime()
		{
			return vtkGenericGeometryFilter.vtkGenericGeometryFilter_GetMTime_16(base.GetCppThis());
		}

		// Token: 0x0600D95E RID: 55646
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericGeometryFilter_GetMerging_17(HandleRef pThis);

		/// <summary>
		/// Turn on/off merging of coincident points. Note that is merging is
		/// on, points with different point attributes (e.g., normals) are merged,
		/// which may cause rendering artifacts.
		/// </summary>
		// Token: 0x0600D95F RID: 55647 RVA: 0x0012DFD4 File Offset: 0x0012C1D4
		public virtual int GetMerging()
		{
			return vtkGenericGeometryFilter.vtkGenericGeometryFilter_GetMerging_17(base.GetCppThis());
		}

		// Token: 0x0600D960 RID: 55648
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericGeometryFilter_GetNumberOfGenerationsFromBase_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D961 RID: 55649 RVA: 0x0012DFF4 File Offset: 0x0012C1F4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGenericGeometryFilter.vtkGenericGeometryFilter_GetNumberOfGenerationsFromBase_18(base.GetCppThis(), type);
		}

		// Token: 0x0600D962 RID: 55650
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericGeometryFilter_GetNumberOfGenerationsFromBaseType_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D963 RID: 55651 RVA: 0x0012E014 File Offset: 0x0012C214
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGenericGeometryFilter.vtkGenericGeometryFilter_GetNumberOfGenerationsFromBaseType_19(type);
		}

		// Token: 0x0600D964 RID: 55652
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericGeometryFilter_GetPassThroughCellIds_20(HandleRef pThis);

		/// <summary>
		/// If on, the output polygonal dataset will have a celldata array that
		/// holds the cell index of the original 3D cell that produced each output
		/// cell. This is useful for cell picking. The default is off to conserve
		/// memory.
		/// </summary>
		// Token: 0x0600D965 RID: 55653 RVA: 0x0012E030 File Offset: 0x0012C230
		public virtual int GetPassThroughCellIds()
		{
			return vtkGenericGeometryFilter.vtkGenericGeometryFilter_GetPassThroughCellIds_20(base.GetCppThis());
		}

		// Token: 0x0600D966 RID: 55654
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericGeometryFilter_GetPointClipping_21(HandleRef pThis);

		/// <summary>
		/// Turn on/off selection of geometry by point id.
		/// </summary>
		// Token: 0x0600D967 RID: 55655 RVA: 0x0012E050 File Offset: 0x0012C250
		public virtual int GetPointClipping()
		{
			return vtkGenericGeometryFilter.vtkGenericGeometryFilter_GetPointClipping_21(base.GetCppThis());
		}

		// Token: 0x0600D968 RID: 55656
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericGeometryFilter_GetPointMaximum_22(HandleRef pThis);

		/// <summary>
		/// Specify the maximum point id for point id selection.
		/// </summary>
		// Token: 0x0600D969 RID: 55657 RVA: 0x0012E070 File Offset: 0x0012C270
		public virtual long GetPointMaximum()
		{
			return vtkGenericGeometryFilter.vtkGenericGeometryFilter_GetPointMaximum_22(base.GetCppThis());
		}

		// Token: 0x0600D96A RID: 55658
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericGeometryFilter_GetPointMaximumMaxValue_23(HandleRef pThis);

		/// <summary>
		/// Specify the maximum point id for point id selection.
		/// </summary>
		// Token: 0x0600D96B RID: 55659 RVA: 0x0012E090 File Offset: 0x0012C290
		public virtual long GetPointMaximumMaxValue()
		{
			return vtkGenericGeometryFilter.vtkGenericGeometryFilter_GetPointMaximumMaxValue_23(base.GetCppThis());
		}

		// Token: 0x0600D96C RID: 55660
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericGeometryFilter_GetPointMaximumMinValue_24(HandleRef pThis);

		/// <summary>
		/// Specify the maximum point id for point id selection.
		/// </summary>
		// Token: 0x0600D96D RID: 55661 RVA: 0x0012E0B0 File Offset: 0x0012C2B0
		public virtual long GetPointMaximumMinValue()
		{
			return vtkGenericGeometryFilter.vtkGenericGeometryFilter_GetPointMaximumMinValue_24(base.GetCppThis());
		}

		// Token: 0x0600D96E RID: 55662
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericGeometryFilter_GetPointMinimum_25(HandleRef pThis);

		/// <summary>
		/// Specify the minimum point id for point id selection.
		/// </summary>
		// Token: 0x0600D96F RID: 55663 RVA: 0x0012E0D0 File Offset: 0x0012C2D0
		public virtual long GetPointMinimum()
		{
			return vtkGenericGeometryFilter.vtkGenericGeometryFilter_GetPointMinimum_25(base.GetCppThis());
		}

		// Token: 0x0600D970 RID: 55664
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericGeometryFilter_GetPointMinimumMaxValue_26(HandleRef pThis);

		/// <summary>
		/// Specify the minimum point id for point id selection.
		/// </summary>
		// Token: 0x0600D971 RID: 55665 RVA: 0x0012E0F0 File Offset: 0x0012C2F0
		public virtual long GetPointMinimumMaxValue()
		{
			return vtkGenericGeometryFilter.vtkGenericGeometryFilter_GetPointMinimumMaxValue_26(base.GetCppThis());
		}

		// Token: 0x0600D972 RID: 55666
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericGeometryFilter_GetPointMinimumMinValue_27(HandleRef pThis);

		/// <summary>
		/// Specify the minimum point id for point id selection.
		/// </summary>
		// Token: 0x0600D973 RID: 55667 RVA: 0x0012E110 File Offset: 0x0012C310
		public virtual long GetPointMinimumMinValue()
		{
			return vtkGenericGeometryFilter.vtkGenericGeometryFilter_GetPointMinimumMinValue_27(base.GetCppThis());
		}

		// Token: 0x0600D974 RID: 55668
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericGeometryFilter_IsA_28(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D975 RID: 55669 RVA: 0x0012E130 File Offset: 0x0012C330
		public override int IsA(string type)
		{
			return vtkGenericGeometryFilter.vtkGenericGeometryFilter_IsA_28(base.GetCppThis(), type);
		}

		// Token: 0x0600D976 RID: 55670
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericGeometryFilter_IsTypeOf_29([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D977 RID: 55671 RVA: 0x0012E150 File Offset: 0x0012C350
		public new static int IsTypeOf(string type)
		{
			return vtkGenericGeometryFilter.vtkGenericGeometryFilter_IsTypeOf_29(type);
		}

		// Token: 0x0600D978 RID: 55672
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGeometryFilter_MergingOff_30(HandleRef pThis);

		/// <summary>
		/// Turn on/off merging of coincident points. Note that is merging is
		/// on, points with different point attributes (e.g., normals) are merged,
		/// which may cause rendering artifacts.
		/// </summary>
		// Token: 0x0600D979 RID: 55673 RVA: 0x0012E16A File Offset: 0x0012C36A
		public virtual void MergingOff()
		{
			vtkGenericGeometryFilter.vtkGenericGeometryFilter_MergingOff_30(base.GetCppThis());
		}

		// Token: 0x0600D97A RID: 55674
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGeometryFilter_MergingOn_31(HandleRef pThis);

		/// <summary>
		/// Turn on/off merging of coincident points. Note that is merging is
		/// on, points with different point attributes (e.g., normals) are merged,
		/// which may cause rendering artifacts.
		/// </summary>
		// Token: 0x0600D97B RID: 55675 RVA: 0x0012E179 File Offset: 0x0012C379
		public virtual void MergingOn()
		{
			vtkGenericGeometryFilter.vtkGenericGeometryFilter_MergingOn_31(base.GetCppThis());
		}

		// Token: 0x0600D97C RID: 55676
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericGeometryFilter_NewInstance_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D97D RID: 55677 RVA: 0x0012E188 File Offset: 0x0012C388
		public new vtkGenericGeometryFilter NewInstance()
		{
			vtkGenericGeometryFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericGeometryFilter.vtkGenericGeometryFilter_NewInstance_33(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericGeometryFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D97E RID: 55678
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGeometryFilter_PassThroughCellIdsOff_34(HandleRef pThis);

		/// <summary>
		/// If on, the output polygonal dataset will have a celldata array that
		/// holds the cell index of the original 3D cell that produced each output
		/// cell. This is useful for cell picking. The default is off to conserve
		/// memory.
		/// </summary>
		// Token: 0x0600D97F RID: 55679 RVA: 0x0012E1E2 File Offset: 0x0012C3E2
		public virtual void PassThroughCellIdsOff()
		{
			vtkGenericGeometryFilter.vtkGenericGeometryFilter_PassThroughCellIdsOff_34(base.GetCppThis());
		}

		// Token: 0x0600D980 RID: 55680
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGeometryFilter_PassThroughCellIdsOn_35(HandleRef pThis);

		/// <summary>
		/// If on, the output polygonal dataset will have a celldata array that
		/// holds the cell index of the original 3D cell that produced each output
		/// cell. This is useful for cell picking. The default is off to conserve
		/// memory.
		/// </summary>
		// Token: 0x0600D981 RID: 55681 RVA: 0x0012E1F1 File Offset: 0x0012C3F1
		public virtual void PassThroughCellIdsOn()
		{
			vtkGenericGeometryFilter.vtkGenericGeometryFilter_PassThroughCellIdsOn_35(base.GetCppThis());
		}

		// Token: 0x0600D982 RID: 55682
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGeometryFilter_PointClippingOff_36(HandleRef pThis);

		/// <summary>
		/// Turn on/off selection of geometry by point id.
		/// </summary>
		// Token: 0x0600D983 RID: 55683 RVA: 0x0012E200 File Offset: 0x0012C400
		public virtual void PointClippingOff()
		{
			vtkGenericGeometryFilter.vtkGenericGeometryFilter_PointClippingOff_36(base.GetCppThis());
		}

		// Token: 0x0600D984 RID: 55684
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGeometryFilter_PointClippingOn_37(HandleRef pThis);

		/// <summary>
		/// Turn on/off selection of geometry by point id.
		/// </summary>
		// Token: 0x0600D985 RID: 55685 RVA: 0x0012E20F File Offset: 0x0012C40F
		public virtual void PointClippingOn()
		{
			vtkGenericGeometryFilter.vtkGenericGeometryFilter_PointClippingOn_37(base.GetCppThis());
		}

		// Token: 0x0600D986 RID: 55686
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericGeometryFilter_SafeDownCast_38(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D987 RID: 55687 RVA: 0x0012E220 File Offset: 0x0012C420
		public new static vtkGenericGeometryFilter SafeDownCast(vtkObjectBase o)
		{
			vtkGenericGeometryFilter vtkGenericGeometryFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericGeometryFilter.vtkGenericGeometryFilter_SafeDownCast_38((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericGeometryFilter = (vtkGenericGeometryFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericGeometryFilter.Register(null);
				}
			}
			return vtkGenericGeometryFilter;
		}

		// Token: 0x0600D988 RID: 55688
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGeometryFilter_SetCellClipping_39(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off selection of geometry by cell id.
		/// </summary>
		// Token: 0x0600D989 RID: 55689 RVA: 0x0012E29F File Offset: 0x0012C49F
		public virtual void SetCellClipping(int _arg)
		{
			vtkGenericGeometryFilter.vtkGenericGeometryFilter_SetCellClipping_39(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D98A RID: 55690
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGeometryFilter_SetCellMaximum_40(HandleRef pThis, long _arg);

		/// <summary>
		/// Specify the maximum cell id for point id selection.
		/// </summary>
		// Token: 0x0600D98B RID: 55691 RVA: 0x0012E2AF File Offset: 0x0012C4AF
		public virtual void SetCellMaximum(long _arg)
		{
			vtkGenericGeometryFilter.vtkGenericGeometryFilter_SetCellMaximum_40(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D98C RID: 55692
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGeometryFilter_SetCellMinimum_41(HandleRef pThis, long _arg);

		/// <summary>
		/// Specify the minimum cell id for point id selection.
		/// </summary>
		// Token: 0x0600D98D RID: 55693 RVA: 0x0012E2BF File Offset: 0x0012C4BF
		public virtual void SetCellMinimum(long _arg)
		{
			vtkGenericGeometryFilter.vtkGenericGeometryFilter_SetCellMinimum_41(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D98E RID: 55694
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGeometryFilter_SetExtent_42(HandleRef pThis, double xMin, double xMax, double yMin, double yMax, double zMin, double zMax);

		/// <summary>
		/// Specify a (xmin,xmax, ymin,ymax, zmin,zmax) bounding box to clip data.
		/// </summary>
		// Token: 0x0600D98F RID: 55695 RVA: 0x0012E2CF File Offset: 0x0012C4CF
		public void SetExtent(double xMin, double xMax, double yMin, double yMax, double zMin, double zMax)
		{
			vtkGenericGeometryFilter.vtkGenericGeometryFilter_SetExtent_42(base.GetCppThis(), xMin, xMax, yMin, yMax, zMin, zMax);
		}

		// Token: 0x0600D990 RID: 55696
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGeometryFilter_SetExtent_43(HandleRef pThis, IntPtr extent);

		/// <summary>
		/// Set / get a (xmin,xmax, ymin,ymax, zmin,zmax) bounding box to clip data.
		/// </summary>
		// Token: 0x0600D991 RID: 55697 RVA: 0x0012E2E7 File Offset: 0x0012C4E7
		public void SetExtent(IntPtr extent)
		{
			vtkGenericGeometryFilter.vtkGenericGeometryFilter_SetExtent_43(base.GetCppThis(), extent);
		}

		// Token: 0x0600D992 RID: 55698
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGeometryFilter_SetExtentClipping_44(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off selection of geometry via bounding box.
		/// </summary>
		// Token: 0x0600D993 RID: 55699 RVA: 0x0012E2F7 File Offset: 0x0012C4F7
		public virtual void SetExtentClipping(int _arg)
		{
			vtkGenericGeometryFilter.vtkGenericGeometryFilter_SetExtentClipping_44(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D994 RID: 55700
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGeometryFilter_SetLocator_45(HandleRef pThis, HandleRef locator);

		/// <summary>
		/// Set / get a spatial locator for merging points. By
		/// default an instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x0600D995 RID: 55701 RVA: 0x0012E308 File Offset: 0x0012C508
		public void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkGenericGeometryFilter.vtkGenericGeometryFilter_SetLocator_45(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		// Token: 0x0600D996 RID: 55702
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGeometryFilter_SetMerging_46(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off merging of coincident points. Note that is merging is
		/// on, points with different point attributes (e.g., normals) are merged,
		/// which may cause rendering artifacts.
		/// </summary>
		// Token: 0x0600D997 RID: 55703 RVA: 0x0012E337 File Offset: 0x0012C537
		public virtual void SetMerging(int _arg)
		{
			vtkGenericGeometryFilter.vtkGenericGeometryFilter_SetMerging_46(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D998 RID: 55704
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGeometryFilter_SetPassThroughCellIds_47(HandleRef pThis, int _arg);

		/// <summary>
		/// If on, the output polygonal dataset will have a celldata array that
		/// holds the cell index of the original 3D cell that produced each output
		/// cell. This is useful for cell picking. The default is off to conserve
		/// memory.
		/// </summary>
		// Token: 0x0600D999 RID: 55705 RVA: 0x0012E347 File Offset: 0x0012C547
		public virtual void SetPassThroughCellIds(int _arg)
		{
			vtkGenericGeometryFilter.vtkGenericGeometryFilter_SetPassThroughCellIds_47(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D99A RID: 55706
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGeometryFilter_SetPointClipping_48(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off selection of geometry by point id.
		/// </summary>
		// Token: 0x0600D99B RID: 55707 RVA: 0x0012E357 File Offset: 0x0012C557
		public virtual void SetPointClipping(int _arg)
		{
			vtkGenericGeometryFilter.vtkGenericGeometryFilter_SetPointClipping_48(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D99C RID: 55708
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGeometryFilter_SetPointMaximum_49(HandleRef pThis, long _arg);

		/// <summary>
		/// Specify the maximum point id for point id selection.
		/// </summary>
		// Token: 0x0600D99D RID: 55709 RVA: 0x0012E367 File Offset: 0x0012C567
		public virtual void SetPointMaximum(long _arg)
		{
			vtkGenericGeometryFilter.vtkGenericGeometryFilter_SetPointMaximum_49(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D99E RID: 55710
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericGeometryFilter_SetPointMinimum_50(HandleRef pThis, long _arg);

		/// <summary>
		/// Specify the minimum point id for point id selection.
		/// </summary>
		// Token: 0x0600D99F RID: 55711 RVA: 0x0012E377 File Offset: 0x0012C577
		public virtual void SetPointMinimum(long _arg)
		{
			vtkGenericGeometryFilter.vtkGenericGeometryFilter_SetPointMinimum_50(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FE0 RID: 4064
		public new const string MRFullTypeName = "Kitware.VTK.vtkGenericGeometryFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FE1 RID: 4065
		public new static readonly string MRClassNameKey = "class vtkGenericGeometryFilter";
	}
}
