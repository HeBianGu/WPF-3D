using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkUnstructuredGridGeometryFilter
	/// </summary>
	/// <remarks>
	///    extract geometry from an unstructured grid
	///
	/// vtkUnstructuredGridGeometryFilter is a filter that extracts
	/// geometry (and associated data) from an unstructured grid. It differs from
	/// vtkGeometryFilter by not tessellating higher order faces: 2D faces of
	/// quadratic 3D cells will be quadratic. A quadratic edge is extracted as a
	/// quadratic edge. For that purpose, the output of this filter is an
	/// unstructured grid, not a polydata.
	/// Also, the face of a voxel is a pixel, not a quad.
	/// Geometry is obtained as follows: all 0D, 1D, and 2D cells are extracted.
	/// All 2D faces that are used by only one 3D cell (i.e., boundary faces) are
	/// extracted. It also is possible to specify conditions on point ids, cell ids,
	/// and on bounding box (referred to as "Extent") to control the extraction
	/// process.
	///
	/// @warning
	/// When vtkUnstructuredGridGeometryFilter extracts cells (or boundaries of
	/// cells) it will (by default) merge duplicate vertices. This may cause
	/// problems in some cases. Turn merging off to prevent this from occurring.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkGeometryFilter vtkDataSetSurfaceFilter
	/// </seealso>
	// Token: 0x02000919 RID: 2329
	public class vtkUnstructuredGridGeometryFilter : vtkUnstructuredGridBaseAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060181E2 RID: 98786 RVA: 0x0021C34F File Offset: 0x0021A54F
		static vtkUnstructuredGridGeometryFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUnstructuredGridGeometryFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGridGeometryFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060181E3 RID: 98787 RVA: 0x0021C377 File Offset: 0x0021A577
		public vtkUnstructuredGridGeometryFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060181E4 RID: 98788
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridGeometryFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060181E5 RID: 98789 RVA: 0x0021C388 File Offset: 0x0021A588
		public new static vtkUnstructuredGridGeometryFilter New()
		{
			vtkUnstructuredGridGeometryFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridGeometryFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060181E6 RID: 98790 RVA: 0x0021C3DC File Offset: 0x0021A5DC
		public vtkUnstructuredGridGeometryFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060181E7 RID: 98791 RVA: 0x0021C420 File Offset: 0x0021A620
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060181E8 RID: 98792
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridGeometryFilter_CellClippingOff_01(HandleRef pThis);

		/// <summary>
		/// Turn on/off selection of geometry by cell id.
		/// </summary>
		// Token: 0x060181E9 RID: 98793 RVA: 0x0021C42B File Offset: 0x0021A62B
		public virtual void CellClippingOff()
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_CellClippingOff_01(base.GetCppThis());
		}

		// Token: 0x060181EA RID: 98794
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridGeometryFilter_CellClippingOn_02(HandleRef pThis);

		/// <summary>
		/// Turn on/off selection of geometry by cell id.
		/// </summary>
		// Token: 0x060181EB RID: 98795 RVA: 0x0021C43A File Offset: 0x0021A63A
		public virtual void CellClippingOn()
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_CellClippingOn_02(base.GetCppThis());
		}

		// Token: 0x060181EC RID: 98796
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridGeometryFilter_CreateDefaultLocator_03(HandleRef pThis);

		/// <summary>
		/// Create default locator. Used to create one when none is specified.
		/// </summary>
		// Token: 0x060181ED RID: 98797 RVA: 0x0021C449 File Offset: 0x0021A649
		public void CreateDefaultLocator()
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_CreateDefaultLocator_03(base.GetCppThis());
		}

		// Token: 0x060181EE RID: 98798
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridGeometryFilter_DuplicateGhostCellClippingOff_04(HandleRef pThis);

		/// <summary>
		/// Turn on/off clipping of ghost cells with type
		/// vtkDataSetAttributes::DUPLICATECELL. Defaults to on.
		/// </summary>
		// Token: 0x060181EF RID: 98799 RVA: 0x0021C458 File Offset: 0x0021A658
		public virtual void DuplicateGhostCellClippingOff()
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_DuplicateGhostCellClippingOff_04(base.GetCppThis());
		}

		// Token: 0x060181F0 RID: 98800
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridGeometryFilter_DuplicateGhostCellClippingOn_05(HandleRef pThis);

		/// <summary>
		/// Turn on/off clipping of ghost cells with type
		/// vtkDataSetAttributes::DUPLICATECELL. Defaults to on.
		/// </summary>
		// Token: 0x060181F1 RID: 98801 RVA: 0x0021C467 File Offset: 0x0021A667
		public virtual void DuplicateGhostCellClippingOn()
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_DuplicateGhostCellClippingOn_05(base.GetCppThis());
		}

		// Token: 0x060181F2 RID: 98802
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridGeometryFilter_ExtentClippingOff_06(HandleRef pThis);

		/// <summary>
		/// Turn on/off selection of geometry via bounding box.
		/// </summary>
		// Token: 0x060181F3 RID: 98803 RVA: 0x0021C476 File Offset: 0x0021A676
		public virtual void ExtentClippingOff()
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_ExtentClippingOff_06(base.GetCppThis());
		}

		// Token: 0x060181F4 RID: 98804
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridGeometryFilter_ExtentClippingOn_07(HandleRef pThis);

		/// <summary>
		/// Turn on/off selection of geometry via bounding box.
		/// </summary>
		// Token: 0x060181F5 RID: 98805 RVA: 0x0021C485 File Offset: 0x0021A685
		public virtual void ExtentClippingOn()
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_ExtentClippingOn_07(base.GetCppThis());
		}

		// Token: 0x060181F6 RID: 98806
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridGeometryFilter_GetCellClipping_08(HandleRef pThis);

		/// <summary>
		/// Turn on/off selection of geometry by cell id.
		/// </summary>
		// Token: 0x060181F7 RID: 98807 RVA: 0x0021C494 File Offset: 0x0021A694
		public virtual int GetCellClipping()
		{
			return vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_GetCellClipping_08(base.GetCppThis());
		}

		// Token: 0x060181F8 RID: 98808
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridGeometryFilter_GetCellMaximum_09(HandleRef pThis);

		/// <summary>
		/// Specify the maximum cell id for point id selection.
		/// </summary>
		// Token: 0x060181F9 RID: 98809 RVA: 0x0021C4B4 File Offset: 0x0021A6B4
		public virtual long GetCellMaximum()
		{
			return vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_GetCellMaximum_09(base.GetCppThis());
		}

		// Token: 0x060181FA RID: 98810
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridGeometryFilter_GetCellMaximumMaxValue_10(HandleRef pThis);

		/// <summary>
		/// Specify the maximum cell id for point id selection.
		/// </summary>
		// Token: 0x060181FB RID: 98811 RVA: 0x0021C4D4 File Offset: 0x0021A6D4
		public virtual long GetCellMaximumMaxValue()
		{
			return vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_GetCellMaximumMaxValue_10(base.GetCppThis());
		}

		// Token: 0x060181FC RID: 98812
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridGeometryFilter_GetCellMaximumMinValue_11(HandleRef pThis);

		/// <summary>
		/// Specify the maximum cell id for point id selection.
		/// </summary>
		// Token: 0x060181FD RID: 98813 RVA: 0x0021C4F4 File Offset: 0x0021A6F4
		public virtual long GetCellMaximumMinValue()
		{
			return vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_GetCellMaximumMinValue_11(base.GetCppThis());
		}

		// Token: 0x060181FE RID: 98814
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridGeometryFilter_GetCellMinimum_12(HandleRef pThis);

		/// <summary>
		/// Specify the minimum cell id for point id selection.
		/// </summary>
		// Token: 0x060181FF RID: 98815 RVA: 0x0021C514 File Offset: 0x0021A714
		public virtual long GetCellMinimum()
		{
			return vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_GetCellMinimum_12(base.GetCppThis());
		}

		// Token: 0x06018200 RID: 98816
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridGeometryFilter_GetCellMinimumMaxValue_13(HandleRef pThis);

		/// <summary>
		/// Specify the minimum cell id for point id selection.
		/// </summary>
		// Token: 0x06018201 RID: 98817 RVA: 0x0021C534 File Offset: 0x0021A734
		public virtual long GetCellMinimumMaxValue()
		{
			return vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_GetCellMinimumMaxValue_13(base.GetCppThis());
		}

		// Token: 0x06018202 RID: 98818
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridGeometryFilter_GetCellMinimumMinValue_14(HandleRef pThis);

		/// <summary>
		/// Specify the minimum cell id for point id selection.
		/// </summary>
		// Token: 0x06018203 RID: 98819 RVA: 0x0021C554 File Offset: 0x0021A754
		public virtual long GetCellMinimumMinValue()
		{
			return vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_GetCellMinimumMinValue_14(base.GetCppThis());
		}

		// Token: 0x06018204 RID: 98820
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridGeometryFilter_GetDuplicateGhostCellClipping_15(HandleRef pThis);

		/// <summary>
		/// Turn on/off clipping of ghost cells with type
		/// vtkDataSetAttributes::DUPLICATECELL. Defaults to on.
		/// </summary>
		// Token: 0x06018205 RID: 98821 RVA: 0x0021C574 File Offset: 0x0021A774
		public virtual int GetDuplicateGhostCellClipping()
		{
			return vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_GetDuplicateGhostCellClipping_15(base.GetCppThis());
		}

		// Token: 0x06018206 RID: 98822
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridGeometryFilter_GetExtent_16(HandleRef pThis);

		/// <summary>
		/// Set / get a (xmin,xmax, ymin,ymax, zmin,zmax) bounding box to clip data.
		/// </summary>
		// Token: 0x06018207 RID: 98823 RVA: 0x0021C594 File Offset: 0x0021A794
		public IntPtr GetExtent()
		{
			return vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_GetExtent_16(base.GetCppThis());
		}

		// Token: 0x06018208 RID: 98824
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridGeometryFilter_GetExtentClipping_17(HandleRef pThis);

		/// <summary>
		/// Turn on/off selection of geometry via bounding box.
		/// </summary>
		// Token: 0x06018209 RID: 98825 RVA: 0x0021C5B4 File Offset: 0x0021A7B4
		public virtual int GetExtentClipping()
		{
			return vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_GetExtentClipping_17(base.GetCppThis());
		}

		// Token: 0x0601820A RID: 98826
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridGeometryFilter_GetLocator_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set / get a spatial locator for merging points. By
		/// default an instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x0601820B RID: 98827 RVA: 0x0021C5D4 File Offset: 0x0021A7D4
		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_GetLocator_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601820C RID: 98828
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkUnstructuredGridGeometryFilter_GetMTime_19(HandleRef pThis);

		/// <summary>
		/// Return the MTime also considering the locator.
		/// </summary>
		// Token: 0x0601820D RID: 98829 RVA: 0x0021C644 File Offset: 0x0021A844
		public override ulong GetMTime()
		{
			return vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_GetMTime_19(base.GetCppThis());
		}

		// Token: 0x0601820E RID: 98830
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridGeometryFilter_GetMatchBoundariesIgnoringCellOrder_20(HandleRef pThis);

		/// <summary>
		/// When two volumetric cells of different order are connected by their corners (for instance, a
		/// quadratic hexahedron next to a linear hexahedron ), the internal face is rendered and is not
		/// considered as a ghost cell. To remove these faces, switch MatchBoundariesIgnoringCellOrder to 1
		/// (default is 0).
		/// </summary>
		// Token: 0x0601820F RID: 98831 RVA: 0x0021C664 File Offset: 0x0021A864
		public virtual int GetMatchBoundariesIgnoringCellOrder()
		{
			return vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_GetMatchBoundariesIgnoringCellOrder_20(base.GetCppThis());
		}

		// Token: 0x06018210 RID: 98832
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridGeometryFilter_GetMerging_21(HandleRef pThis);

		/// <summary>
		/// Turn on/off merging of coincident points. Note that is merging is
		/// on, points with different point attributes (e.g., normals) are merged,
		/// which may cause rendering artifacts.
		/// </summary>
		// Token: 0x06018211 RID: 98833 RVA: 0x0021C684 File Offset: 0x0021A884
		public virtual int GetMerging()
		{
			return vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_GetMerging_21(base.GetCppThis());
		}

		// Token: 0x06018212 RID: 98834
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridGeometryFilter_GetNumberOfGenerationsFromBase_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018213 RID: 98835 RVA: 0x0021C6A4 File Offset: 0x0021A8A4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_GetNumberOfGenerationsFromBase_22(base.GetCppThis(), type);
		}

		// Token: 0x06018214 RID: 98836
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridGeometryFilter_GetNumberOfGenerationsFromBaseType_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018215 RID: 98837 RVA: 0x0021C6C4 File Offset: 0x0021A8C4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_GetNumberOfGenerationsFromBaseType_23(type);
		}

		// Token: 0x06018216 RID: 98838
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridGeometryFilter_GetOriginalCellIdsName_24(HandleRef pThis);

		/// <summary>
		/// If PassThroughCellIds or PassThroughPointIds is on, then these ivars
		/// control the name given to the field in which the ids are written into.  If
		/// set to nullptr, then vtkOriginalCellIds or vtkOriginalPointIds (the default)
		/// is used, respectively.
		/// </summary>
		// Token: 0x06018217 RID: 98839 RVA: 0x0021C6E0 File Offset: 0x0021A8E0
		public virtual string GetOriginalCellIdsName()
		{
			string s = Marshal.PtrToStringAnsi(vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_GetOriginalCellIdsName_24(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06018218 RID: 98840
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridGeometryFilter_GetOriginalPointIdsName_25(HandleRef pThis);

		/// <summary>
		/// If PassThroughCellIds or PassThroughPointIds is on, then these ivars
		/// control the name given to the field in which the ids are written into.  If
		/// set to nullptr, then vtkOriginalCellIds or vtkOriginalPointIds (the default)
		/// is used, respectively.
		/// </summary>
		// Token: 0x06018219 RID: 98841 RVA: 0x0021C71C File Offset: 0x0021A91C
		public virtual string GetOriginalPointIdsName()
		{
			string s = Marshal.PtrToStringAnsi(vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_GetOriginalPointIdsName_25(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601821A RID: 98842
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridGeometryFilter_GetPassThroughCellIds_26(HandleRef pThis);

		/// <summary>
		/// If on, the output polygonal dataset will have a celldata array that
		/// holds the cell index of the original 3D cell that produced each output
		/// cell. This is useful for cell picking. The default is off to conserve
		/// memory. Note that PassThroughCellIds will be ignored if UseStrips is on,
		/// since in that case each tringle strip can represent more than on of the
		/// input cells.
		/// </summary>
		// Token: 0x0601821B RID: 98843 RVA: 0x0021C758 File Offset: 0x0021A958
		public virtual int GetPassThroughCellIds()
		{
			return vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_GetPassThroughCellIds_26(base.GetCppThis());
		}

		// Token: 0x0601821C RID: 98844
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridGeometryFilter_GetPassThroughPointIds_27(HandleRef pThis);

		/// <summary>
		/// If on, the output polygonal dataset will have a celldata array that
		/// holds the cell index of the original 3D cell that produced each output
		/// cell. This is useful for cell picking. The default is off to conserve
		/// memory. Note that PassThroughCellIds will be ignored if UseStrips is on,
		/// since in that case each tringle strip can represent more than on of the
		/// input cells.
		/// </summary>
		// Token: 0x0601821D RID: 98845 RVA: 0x0021C778 File Offset: 0x0021A978
		public virtual int GetPassThroughPointIds()
		{
			return vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_GetPassThroughPointIds_27(base.GetCppThis());
		}

		// Token: 0x0601821E RID: 98846
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridGeometryFilter_GetPointClipping_28(HandleRef pThis);

		/// <summary>
		/// Turn on/off selection of geometry by point id.
		/// </summary>
		// Token: 0x0601821F RID: 98847 RVA: 0x0021C798 File Offset: 0x0021A998
		public virtual int GetPointClipping()
		{
			return vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_GetPointClipping_28(base.GetCppThis());
		}

		// Token: 0x06018220 RID: 98848
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridGeometryFilter_GetPointMaximum_29(HandleRef pThis);

		/// <summary>
		/// Specify the maximum point id for point id selection.
		/// </summary>
		// Token: 0x06018221 RID: 98849 RVA: 0x0021C7B8 File Offset: 0x0021A9B8
		public virtual long GetPointMaximum()
		{
			return vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_GetPointMaximum_29(base.GetCppThis());
		}

		// Token: 0x06018222 RID: 98850
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridGeometryFilter_GetPointMaximumMaxValue_30(HandleRef pThis);

		/// <summary>
		/// Specify the maximum point id for point id selection.
		/// </summary>
		// Token: 0x06018223 RID: 98851 RVA: 0x0021C7D8 File Offset: 0x0021A9D8
		public virtual long GetPointMaximumMaxValue()
		{
			return vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_GetPointMaximumMaxValue_30(base.GetCppThis());
		}

		// Token: 0x06018224 RID: 98852
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridGeometryFilter_GetPointMaximumMinValue_31(HandleRef pThis);

		/// <summary>
		/// Specify the maximum point id for point id selection.
		/// </summary>
		// Token: 0x06018225 RID: 98853 RVA: 0x0021C7F8 File Offset: 0x0021A9F8
		public virtual long GetPointMaximumMinValue()
		{
			return vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_GetPointMaximumMinValue_31(base.GetCppThis());
		}

		// Token: 0x06018226 RID: 98854
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridGeometryFilter_GetPointMinimum_32(HandleRef pThis);

		/// <summary>
		/// Specify the minimum point id for point id selection.
		/// </summary>
		// Token: 0x06018227 RID: 98855 RVA: 0x0021C818 File Offset: 0x0021AA18
		public virtual long GetPointMinimum()
		{
			return vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_GetPointMinimum_32(base.GetCppThis());
		}

		// Token: 0x06018228 RID: 98856
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridGeometryFilter_GetPointMinimumMaxValue_33(HandleRef pThis);

		/// <summary>
		/// Specify the minimum point id for point id selection.
		/// </summary>
		// Token: 0x06018229 RID: 98857 RVA: 0x0021C838 File Offset: 0x0021AA38
		public virtual long GetPointMinimumMaxValue()
		{
			return vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_GetPointMinimumMaxValue_33(base.GetCppThis());
		}

		// Token: 0x0601822A RID: 98858
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridGeometryFilter_GetPointMinimumMinValue_34(HandleRef pThis);

		/// <summary>
		/// Specify the minimum point id for point id selection.
		/// </summary>
		// Token: 0x0601822B RID: 98859 RVA: 0x0021C858 File Offset: 0x0021AA58
		public virtual long GetPointMinimumMinValue()
		{
			return vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_GetPointMinimumMinValue_34(base.GetCppThis());
		}

		// Token: 0x0601822C RID: 98860
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridGeometryFilter_IsA_35(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601822D RID: 98861 RVA: 0x0021C878 File Offset: 0x0021AA78
		public override int IsA(string type)
		{
			return vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_IsA_35(base.GetCppThis(), type);
		}

		// Token: 0x0601822E RID: 98862
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridGeometryFilter_IsTypeOf_36([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601822F RID: 98863 RVA: 0x0021C898 File Offset: 0x0021AA98
		public new static int IsTypeOf(string type)
		{
			return vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_IsTypeOf_36(type);
		}

		// Token: 0x06018230 RID: 98864
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridGeometryFilter_MergingOff_37(HandleRef pThis);

		/// <summary>
		/// Turn on/off merging of coincident points. Note that is merging is
		/// on, points with different point attributes (e.g., normals) are merged,
		/// which may cause rendering artifacts.
		/// </summary>
		// Token: 0x06018231 RID: 98865 RVA: 0x0021C8B2 File Offset: 0x0021AAB2
		public virtual void MergingOff()
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_MergingOff_37(base.GetCppThis());
		}

		// Token: 0x06018232 RID: 98866
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridGeometryFilter_MergingOn_38(HandleRef pThis);

		/// <summary>
		/// Turn on/off merging of coincident points. Note that is merging is
		/// on, points with different point attributes (e.g., normals) are merged,
		/// which may cause rendering artifacts.
		/// </summary>
		// Token: 0x06018233 RID: 98867 RVA: 0x0021C8C1 File Offset: 0x0021AAC1
		public virtual void MergingOn()
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_MergingOn_38(base.GetCppThis());
		}

		// Token: 0x06018234 RID: 98868
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridGeometryFilter_NewInstance_40(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018235 RID: 98869 RVA: 0x0021C8D0 File Offset: 0x0021AAD0
		public new vtkUnstructuredGridGeometryFilter NewInstance()
		{
			vtkUnstructuredGridGeometryFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_NewInstance_40(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridGeometryFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06018236 RID: 98870
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridGeometryFilter_PassThroughCellIdsOff_41(HandleRef pThis);

		/// <summary>
		/// If on, the output polygonal dataset will have a celldata array that
		/// holds the cell index of the original 3D cell that produced each output
		/// cell. This is useful for cell picking. The default is off to conserve
		/// memory. Note that PassThroughCellIds will be ignored if UseStrips is on,
		/// since in that case each tringle strip can represent more than on of the
		/// input cells.
		/// </summary>
		// Token: 0x06018237 RID: 98871 RVA: 0x0021C92A File Offset: 0x0021AB2A
		public virtual void PassThroughCellIdsOff()
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_PassThroughCellIdsOff_41(base.GetCppThis());
		}

		// Token: 0x06018238 RID: 98872
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridGeometryFilter_PassThroughCellIdsOn_42(HandleRef pThis);

		/// <summary>
		/// If on, the output polygonal dataset will have a celldata array that
		/// holds the cell index of the original 3D cell that produced each output
		/// cell. This is useful for cell picking. The default is off to conserve
		/// memory. Note that PassThroughCellIds will be ignored if UseStrips is on,
		/// since in that case each tringle strip can represent more than on of the
		/// input cells.
		/// </summary>
		// Token: 0x06018239 RID: 98873 RVA: 0x0021C939 File Offset: 0x0021AB39
		public virtual void PassThroughCellIdsOn()
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_PassThroughCellIdsOn_42(base.GetCppThis());
		}

		// Token: 0x0601823A RID: 98874
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridGeometryFilter_PassThroughPointIdsOff_43(HandleRef pThis);

		/// <summary>
		/// If on, the output polygonal dataset will have a celldata array that
		/// holds the cell index of the original 3D cell that produced each output
		/// cell. This is useful for cell picking. The default is off to conserve
		/// memory. Note that PassThroughCellIds will be ignored if UseStrips is on,
		/// since in that case each tringle strip can represent more than on of the
		/// input cells.
		/// </summary>
		// Token: 0x0601823B RID: 98875 RVA: 0x0021C948 File Offset: 0x0021AB48
		public virtual void PassThroughPointIdsOff()
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_PassThroughPointIdsOff_43(base.GetCppThis());
		}

		// Token: 0x0601823C RID: 98876
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridGeometryFilter_PassThroughPointIdsOn_44(HandleRef pThis);

		/// <summary>
		/// If on, the output polygonal dataset will have a celldata array that
		/// holds the cell index of the original 3D cell that produced each output
		/// cell. This is useful for cell picking. The default is off to conserve
		/// memory. Note that PassThroughCellIds will be ignored if UseStrips is on,
		/// since in that case each tringle strip can represent more than on of the
		/// input cells.
		/// </summary>
		// Token: 0x0601823D RID: 98877 RVA: 0x0021C957 File Offset: 0x0021AB57
		public virtual void PassThroughPointIdsOn()
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_PassThroughPointIdsOn_44(base.GetCppThis());
		}

		// Token: 0x0601823E RID: 98878
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridGeometryFilter_PointClippingOff_45(HandleRef pThis);

		/// <summary>
		/// Turn on/off selection of geometry by point id.
		/// </summary>
		// Token: 0x0601823F RID: 98879 RVA: 0x0021C966 File Offset: 0x0021AB66
		public virtual void PointClippingOff()
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_PointClippingOff_45(base.GetCppThis());
		}

		// Token: 0x06018240 RID: 98880
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridGeometryFilter_PointClippingOn_46(HandleRef pThis);

		/// <summary>
		/// Turn on/off selection of geometry by point id.
		/// </summary>
		// Token: 0x06018241 RID: 98881 RVA: 0x0021C975 File Offset: 0x0021AB75
		public virtual void PointClippingOn()
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_PointClippingOn_46(base.GetCppThis());
		}

		// Token: 0x06018242 RID: 98882
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridGeometryFilter_SafeDownCast_47(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018243 RID: 98883 RVA: 0x0021C984 File Offset: 0x0021AB84
		public new static vtkUnstructuredGridGeometryFilter SafeDownCast(vtkObjectBase o)
		{
			vtkUnstructuredGridGeometryFilter vtkUnstructuredGridGeometryFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_SafeDownCast_47((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGridGeometryFilter = (vtkUnstructuredGridGeometryFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGridGeometryFilter.Register(null);
				}
			}
			return vtkUnstructuredGridGeometryFilter;
		}

		// Token: 0x06018244 RID: 98884
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridGeometryFilter_SetCellClipping_48(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off selection of geometry by cell id.
		/// </summary>
		// Token: 0x06018245 RID: 98885 RVA: 0x0021CA03 File Offset: 0x0021AC03
		public virtual void SetCellClipping(int _arg)
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_SetCellClipping_48(base.GetCppThis(), _arg);
		}

		// Token: 0x06018246 RID: 98886
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridGeometryFilter_SetCellMaximum_49(HandleRef pThis, long _arg);

		/// <summary>
		/// Specify the maximum cell id for point id selection.
		/// </summary>
		// Token: 0x06018247 RID: 98887 RVA: 0x0021CA13 File Offset: 0x0021AC13
		public virtual void SetCellMaximum(long _arg)
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_SetCellMaximum_49(base.GetCppThis(), _arg);
		}

		// Token: 0x06018248 RID: 98888
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridGeometryFilter_SetCellMinimum_50(HandleRef pThis, long _arg);

		/// <summary>
		/// Specify the minimum cell id for point id selection.
		/// </summary>
		// Token: 0x06018249 RID: 98889 RVA: 0x0021CA23 File Offset: 0x0021AC23
		public virtual void SetCellMinimum(long _arg)
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_SetCellMinimum_50(base.GetCppThis(), _arg);
		}

		// Token: 0x0601824A RID: 98890
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridGeometryFilter_SetDuplicateGhostCellClipping_51(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off clipping of ghost cells with type
		/// vtkDataSetAttributes::DUPLICATECELL. Defaults to on.
		/// </summary>
		// Token: 0x0601824B RID: 98891 RVA: 0x0021CA33 File Offset: 0x0021AC33
		public virtual void SetDuplicateGhostCellClipping(int _arg)
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_SetDuplicateGhostCellClipping_51(base.GetCppThis(), _arg);
		}

		// Token: 0x0601824C RID: 98892
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridGeometryFilter_SetExtent_52(HandleRef pThis, double xMin, double xMax, double yMin, double yMax, double zMin, double zMax);

		/// <summary>
		/// Specify a (xmin,xmax, ymin,ymax, zmin,zmax) bounding box to clip data.
		/// </summary>
		// Token: 0x0601824D RID: 98893 RVA: 0x0021CA43 File Offset: 0x0021AC43
		public void SetExtent(double xMin, double xMax, double yMin, double yMax, double zMin, double zMax)
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_SetExtent_52(base.GetCppThis(), xMin, xMax, yMin, yMax, zMin, zMax);
		}

		// Token: 0x0601824E RID: 98894
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridGeometryFilter_SetExtent_53(HandleRef pThis, IntPtr extent);

		/// <summary>
		/// Set / get a (xmin,xmax, ymin,ymax, zmin,zmax) bounding box to clip data.
		/// </summary>
		// Token: 0x0601824F RID: 98895 RVA: 0x0021CA5B File Offset: 0x0021AC5B
		public void SetExtent(IntPtr extent)
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_SetExtent_53(base.GetCppThis(), extent);
		}

		// Token: 0x06018250 RID: 98896
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridGeometryFilter_SetExtentClipping_54(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off selection of geometry via bounding box.
		/// </summary>
		// Token: 0x06018251 RID: 98897 RVA: 0x0021CA6B File Offset: 0x0021AC6B
		public virtual void SetExtentClipping(int _arg)
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_SetExtentClipping_54(base.GetCppThis(), _arg);
		}

		// Token: 0x06018252 RID: 98898
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridGeometryFilter_SetLocator_55(HandleRef pThis, HandleRef locator);

		/// <summary>
		/// Set / get a spatial locator for merging points. By
		/// default an instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x06018253 RID: 98899 RVA: 0x0021CA7C File Offset: 0x0021AC7C
		public void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_SetLocator_55(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		// Token: 0x06018254 RID: 98900
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridGeometryFilter_SetMatchBoundariesIgnoringCellOrder_56(HandleRef pThis, int _arg);

		/// <summary>
		/// When two volumetric cells of different order are connected by their corners (for instance, a
		/// quadratic hexahedron next to a linear hexahedron ), the internal face is rendered and is not
		/// considered as a ghost cell. To remove these faces, switch MatchBoundariesIgnoringCellOrder to 1
		/// (default is 0).
		/// </summary>
		// Token: 0x06018255 RID: 98901 RVA: 0x0021CAAB File Offset: 0x0021ACAB
		public virtual void SetMatchBoundariesIgnoringCellOrder(int _arg)
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_SetMatchBoundariesIgnoringCellOrder_56(base.GetCppThis(), _arg);
		}

		// Token: 0x06018256 RID: 98902
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridGeometryFilter_SetMerging_57(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off merging of coincident points. Note that is merging is
		/// on, points with different point attributes (e.g., normals) are merged,
		/// which may cause rendering artifacts.
		/// </summary>
		// Token: 0x06018257 RID: 98903 RVA: 0x0021CABB File Offset: 0x0021ACBB
		public virtual void SetMerging(int _arg)
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_SetMerging_57(base.GetCppThis(), _arg);
		}

		// Token: 0x06018258 RID: 98904
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridGeometryFilter_SetOriginalCellIdsName_58(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// If PassThroughCellIds or PassThroughPointIds is on, then these ivars
		/// control the name given to the field in which the ids are written into.  If
		/// set to nullptr, then vtkOriginalCellIds or vtkOriginalPointIds (the default)
		/// is used, respectively.
		/// </summary>
		// Token: 0x06018259 RID: 98905 RVA: 0x0021CACB File Offset: 0x0021ACCB
		public virtual void SetOriginalCellIdsName(string _arg)
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_SetOriginalCellIdsName_58(base.GetCppThis(), _arg);
		}

		// Token: 0x0601825A RID: 98906
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridGeometryFilter_SetOriginalPointIdsName_59(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// If PassThroughCellIds or PassThroughPointIds is on, then these ivars
		/// control the name given to the field in which the ids are written into.  If
		/// set to nullptr, then vtkOriginalCellIds or vtkOriginalPointIds (the default)
		/// is used, respectively.
		/// </summary>
		// Token: 0x0601825B RID: 98907 RVA: 0x0021CADB File Offset: 0x0021ACDB
		public virtual void SetOriginalPointIdsName(string _arg)
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_SetOriginalPointIdsName_59(base.GetCppThis(), _arg);
		}

		// Token: 0x0601825C RID: 98908
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridGeometryFilter_SetPassThroughCellIds_60(HandleRef pThis, int _arg);

		/// <summary>
		/// If on, the output polygonal dataset will have a celldata array that
		/// holds the cell index of the original 3D cell that produced each output
		/// cell. This is useful for cell picking. The default is off to conserve
		/// memory. Note that PassThroughCellIds will be ignored if UseStrips is on,
		/// since in that case each tringle strip can represent more than on of the
		/// input cells.
		/// </summary>
		// Token: 0x0601825D RID: 98909 RVA: 0x0021CAEB File Offset: 0x0021ACEB
		public virtual void SetPassThroughCellIds(int _arg)
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_SetPassThroughCellIds_60(base.GetCppThis(), _arg);
		}

		// Token: 0x0601825E RID: 98910
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridGeometryFilter_SetPassThroughPointIds_61(HandleRef pThis, int _arg);

		/// <summary>
		/// If on, the output polygonal dataset will have a celldata array that
		/// holds the cell index of the original 3D cell that produced each output
		/// cell. This is useful for cell picking. The default is off to conserve
		/// memory. Note that PassThroughCellIds will be ignored if UseStrips is on,
		/// since in that case each tringle strip can represent more than on of the
		/// input cells.
		/// </summary>
		// Token: 0x0601825F RID: 98911 RVA: 0x0021CAFB File Offset: 0x0021ACFB
		public virtual void SetPassThroughPointIds(int _arg)
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_SetPassThroughPointIds_61(base.GetCppThis(), _arg);
		}

		// Token: 0x06018260 RID: 98912
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridGeometryFilter_SetPointClipping_62(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off selection of geometry by point id.
		/// </summary>
		// Token: 0x06018261 RID: 98913 RVA: 0x0021CB0B File Offset: 0x0021AD0B
		public virtual void SetPointClipping(int _arg)
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_SetPointClipping_62(base.GetCppThis(), _arg);
		}

		// Token: 0x06018262 RID: 98914
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridGeometryFilter_SetPointMaximum_63(HandleRef pThis, long _arg);

		/// <summary>
		/// Specify the maximum point id for point id selection.
		/// </summary>
		// Token: 0x06018263 RID: 98915 RVA: 0x0021CB1B File Offset: 0x0021AD1B
		public virtual void SetPointMaximum(long _arg)
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_SetPointMaximum_63(base.GetCppThis(), _arg);
		}

		// Token: 0x06018264 RID: 98916
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridGeometryFilter_SetPointMinimum_64(HandleRef pThis, long _arg);

		/// <summary>
		/// Specify the minimum point id for point id selection.
		/// </summary>
		// Token: 0x06018265 RID: 98917 RVA: 0x0021CB2B File Offset: 0x0021AD2B
		public virtual void SetPointMinimum(long _arg)
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_SetPointMinimum_64(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001ADC RID: 6876
		public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGridGeometryFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001ADD RID: 6877
		public new static readonly string MRClassNameKey = "class vtkUnstructuredGridGeometryFilter";
	}
}
