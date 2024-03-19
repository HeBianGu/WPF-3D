using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDataSetSurfaceFilter
	/// </summary>
	/// <remarks>
	///    Extracts outer surface (as vtkPolyData) of any dataset
	///
	/// vtkDataSetSurfaceFilter is a general-purpose filter to extract boundary
	/// geometry (and associated data) from any type of dataset. Geometry is
	/// obtained as follows: all 0D, 1D, and 2D cells are extracted. All 2D faces
	/// that are used by only one 3D cell (i.e., boundary faces) are
	/// extracted. The filter will handle any type of dataset, including
	/// unstructured grids with non-linear cells. (See also vtkGeometryFilter for
	/// additional documentation and information - vtkGeometryFilter is the
	/// preferred filter to use in most cases and may be deprecated in the
	/// future.)
	///
	/// The filter only has only a few options: methods for passing through
	/// point and cell ids (to support picking); and controls for nonlinear cell
	/// subdivision. At this time vtkDataSetSurfaceFilter has the distinction of
	/// being able to process non-linear cells requiring subdivision. For this
	/// reason, vtkDataSetSurfaceFilter should be used with non-linear cells;
	/// otherwise vtkGeometryFilter should be used. (Note: by default this filter
	/// will delegate processing of linear vtkUnstructuredGrids to
	/// vtkGeometryFilter as vtkGeometryFilter is so much faster. And
	/// vtkGeometryFilter will delegate to vtkDataSetSurfaceFilter when it
	/// encounters nonlinear cells.)
	///
	/// @section FastMode Fast Mode
	///
	/// vtkDataSetSurfaceFilter is sometimes used to simply render a 3D
	/// dataset. In which case we only are concerned about an approximate
	/// representation of the data and not necessarily the true exterior surface. In
	/// that case, simply set the FastMode flag to true.
	///
	/// Currently FastMode is used when extracting surface from a structured dataset
	/// or when `Delegation` is true. When Delegation is true, the flag is passed on
	/// to `vtkGeometryFilter` (see `vtkGeometryFilter:SetFastMode`).
	///
	/// @warning
	/// At one time, vtkDataSetSurfaceFilter was a faster version of
	/// vtkGeometryFilter when processing unstructured grids, however
	/// vtkGeometryFilter is now faster. Also, vtkDataSetSurfaceFilter typically
	/// uses more memory than vtkGeometryFilter.  Consequently as a convenience to
	/// the user, vtkDataSetSurfaceFilter will delegate to vtkGeometryFilter when
	/// processing linear vtkUnstructuredGrids. This typically produces a 5-10x
	/// speed up. (See vtkGeometryFilter for more information.) This delegation can
	/// be disabled by setting the Delegation data member.
	///
	/// @warning
	/// vtkDataSetSurfaceFilter will generally not preserve topological
	/// connectivity.  In other words, the output polygonal primitives may not be
	/// connected although in the originating dataset the boundary entities (e.g.,
	/// faces) may have been connected. This can result in issues for filters that
	/// expect proper topological connectivity (e.g., vtkQuadricDecimation or
	/// vtkFeatureEdges).
	///
	/// @warning
	/// A key step in this algorithm (for 3D cells) is to count the number times a
	/// face is used by a cell. If used only once, then the face is considered a
	/// boundary face and sent to the filter output. The filter determines this by
	/// creating a hash table of faces: faces that are placed into the hash table
	/// a single time are used only once, and therefore sent to the output. Thus
	/// large amounts of extra memory is necessary to build the hash table. This
	/// obsoleted approach requires a significant amount of memory, and is a
	/// significant bottleneck to threading.
	///
	/// @warning
	/// This filter may create duplicate points. Unlike vtkGeometryFilter, it does
	/// not have the option to merge points. However it will eliminate points
	/// not used by any output polygonal primitive (i.e., not on the boundary).
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkGeometryFilter vtkStructuredGridGeometryFilter
	/// </seealso>
	// Token: 0x02000908 RID: 2312
	public class vtkDataSetSurfaceFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06017F7C RID: 98172 RVA: 0x00218A17 File Offset: 0x00216C17
		static vtkDataSetSurfaceFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataSetSurfaceFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataSetSurfaceFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06017F7D RID: 98173 RVA: 0x00218A3F File Offset: 0x00216C3F
		public vtkDataSetSurfaceFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06017F7E RID: 98174
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetSurfaceFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Statndard methods for object instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06017F7F RID: 98175 RVA: 0x00218A50 File Offset: 0x00216C50
		public new static vtkDataSetSurfaceFilter New()
		{
			vtkDataSetSurfaceFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataSetSurfaceFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Statndard methods for object instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06017F80 RID: 98176 RVA: 0x00218AA4 File Offset: 0x00216CA4
		public vtkDataSetSurfaceFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06017F81 RID: 98177 RVA: 0x00218AE8 File Offset: 0x00216CE8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06017F82 RID: 98178
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetSurfaceFilter_DataSetExecute_01(HandleRef pThis, HandleRef input, HandleRef output);

		/// <summary>
		/// Execute the filter on \a input and store the result in \a output.
		/// The correct function should be used accordingly to the type of the input.
		/// </summary>
		// Token: 0x06017F83 RID: 98179 RVA: 0x00218AF4 File Offset: 0x00216CF4
		public virtual int DataSetExecute(vtkDataSet input, vtkPolyData output)
		{
			return vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_DataSetExecute_01(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		// Token: 0x06017F84 RID: 98180
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetSurfaceFilter_DelegationOff_02(HandleRef pThis);

		/// <summary>
		/// Disable delegation to an internal vtkGeometryFilter. The geometry filter runs
		/// much faster (especially for unstructured grids); however the two filters
		/// produce slightly different output. Hence by default delegation is disabled.
		/// </summary>
		// Token: 0x06017F85 RID: 98181 RVA: 0x00218B3D File Offset: 0x00216D3D
		public virtual void DelegationOff()
		{
			vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_DelegationOff_02(base.GetCppThis());
		}

		// Token: 0x06017F86 RID: 98182
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetSurfaceFilter_DelegationOn_03(HandleRef pThis);

		/// <summary>
		/// Disable delegation to an internal vtkGeometryFilter. The geometry filter runs
		/// much faster (especially for unstructured grids); however the two filters
		/// produce slightly different output. Hence by default delegation is disabled.
		/// </summary>
		// Token: 0x06017F87 RID: 98183 RVA: 0x00218B4C File Offset: 0x00216D4C
		public virtual void DelegationOn()
		{
			vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_DelegationOn_03(base.GetCppThis());
		}

		// Token: 0x06017F88 RID: 98184
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetSurfaceFilter_FastModeOff_04(HandleRef pThis);

		/// <summary>
		/// Turn on/off fast mode execution. If enabled, fast mode typically runs
		/// much faster (2-3x) than the standard algorithm, however the output is an
		/// approximation to the correct result. Also, note that the FastMode
		/// depends on the data member Degree for its execution.
		/// </summary>
		// Token: 0x06017F89 RID: 98185 RVA: 0x00218B5B File Offset: 0x00216D5B
		public virtual void FastModeOff()
		{
			vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_FastModeOff_04(base.GetCppThis());
		}

		// Token: 0x06017F8A RID: 98186
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetSurfaceFilter_FastModeOn_05(HandleRef pThis);

		/// <summary>
		/// Turn on/off fast mode execution. If enabled, fast mode typically runs
		/// much faster (2-3x) than the standard algorithm, however the output is an
		/// approximation to the correct result. Also, note that the FastMode
		/// depends on the data member Degree for its execution.
		/// </summary>
		// Token: 0x06017F8B RID: 98187 RVA: 0x00218B6A File Offset: 0x00216D6A
		public virtual void FastModeOn()
		{
			vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_FastModeOn_05(base.GetCppThis());
		}

		// Token: 0x06017F8C RID: 98188
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetSurfaceFilter_GetDelegation_06(HandleRef pThis);

		/// <summary>
		/// Disable delegation to an internal vtkGeometryFilter. The geometry filter runs
		/// much faster (especially for unstructured grids); however the two filters
		/// produce slightly different output. Hence by default delegation is disabled.
		/// </summary>
		// Token: 0x06017F8D RID: 98189 RVA: 0x00218B7C File Offset: 0x00216D7C
		public virtual int GetDelegation()
		{
			return vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_GetDelegation_06(base.GetCppThis());
		}

		// Token: 0x06017F8E RID: 98190
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDataSetSurfaceFilter_GetFastMode_07(HandleRef pThis);

		/// <summary>
		/// Turn on/off fast mode execution. If enabled, fast mode typically runs
		/// much faster (2-3x) than the standard algorithm, however the output is an
		/// approximation to the correct result. Also, note that the FastMode
		/// depends on the data member Degree for its execution.
		/// </summary>
		// Token: 0x06017F8F RID: 98191 RVA: 0x00218B9C File Offset: 0x00216D9C
		public virtual bool GetFastMode()
		{
			return vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_GetFastMode_07(base.GetCppThis()) != 0;
		}

		// Token: 0x06017F90 RID: 98192
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetSurfaceFilter_GetMatchBoundariesIgnoringCellOrder_08(HandleRef pThis);

		/// <summary>
		/// When two volumetric cells of different order are connected by their corners (for instance, a
		/// quadratic hexahedron next to a linear hexahedron ), the internal face is rendered and is not
		/// considered as a ghost cell. To remove these faces, switch MatchBoundariesIgnoringCellOrder to 1
		/// (default is 0).
		/// </summary>
		// Token: 0x06017F91 RID: 98193 RVA: 0x00218BC4 File Offset: 0x00216DC4
		public virtual int GetMatchBoundariesIgnoringCellOrder()
		{
			return vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_GetMatchBoundariesIgnoringCellOrder_08(base.GetCppThis());
		}

		// Token: 0x06017F92 RID: 98194
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetSurfaceFilter_GetNonlinearSubdivisionLevel_09(HandleRef pThis);

		/// <summary>
		/// If the input is an unstructured grid with nonlinear faces, this parameter
		/// determines how many times the face is subdivided into linear faces.  If 0,
		/// the output is the equivalent of its linear counterpart (and the midpoints
		/// determining the nonlinear interpolation are discarded).  If 1 (the
		/// default), the nonlinear face is triangulated based on the midpoints.  If
		/// greater than 1, the triangulated pieces are recursively subdivided to reach
		/// the desired subdivision.  Setting the value to greater than 1 may cause
		/// some point data to not be passed even if no nonlinear faces exist.  This
		/// option has no effect if the input is not an unstructured grid.
		/// </summary>
		// Token: 0x06017F93 RID: 98195 RVA: 0x00218BE4 File Offset: 0x00216DE4
		public virtual int GetNonlinearSubdivisionLevel()
		{
			return vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_GetNonlinearSubdivisionLevel_09(base.GetCppThis());
		}

		// Token: 0x06017F94 RID: 98196
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataSetSurfaceFilter_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Statndard methods for object instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06017F95 RID: 98197 RVA: 0x00218C04 File Offset: 0x00216E04
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x06017F96 RID: 98198
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataSetSurfaceFilter_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Statndard methods for object instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06017F97 RID: 98199 RVA: 0x00218C24 File Offset: 0x00216E24
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x06017F98 RID: 98200
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetSurfaceFilter_GetOriginalCellIdsName_12(HandleRef pThis);

		/// <summary>
		/// If PassThroughCellIds or PassThroughPointIds is on, then these ivars
		/// control the name given to the field in which the ids are written into.  If
		/// set to nullptr, then vtkOriginalCellIds or vtkOriginalPointIds (the default)
		/// is used, respectively.
		/// </summary>
		// Token: 0x06017F99 RID: 98201 RVA: 0x00218C40 File Offset: 0x00216E40
		public virtual string GetOriginalCellIdsName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_GetOriginalCellIdsName_12(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06017F9A RID: 98202
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetSurfaceFilter_GetOriginalPointIdsName_13(HandleRef pThis);

		/// <summary>
		/// If PassThroughCellIds or PassThroughPointIds is on, then these ivars
		/// control the name given to the field in which the ids are written into.  If
		/// set to nullptr, then vtkOriginalCellIds or vtkOriginalPointIds (the default)
		/// is used, respectively.
		/// </summary>
		// Token: 0x06017F9B RID: 98203 RVA: 0x00218C7C File Offset: 0x00216E7C
		public virtual string GetOriginalPointIdsName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_GetOriginalPointIdsName_13(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06017F9C RID: 98204
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetSurfaceFilter_GetPassThroughCellIds_14(HandleRef pThis);

		/// <summary>
		/// If on, the output polygonal dataset will have a celldata array that
		/// holds the cell index of the original 3D cell that produced each output
		/// cell. This is useful for cell picking. The default is off to conserve
		/// memory.
		/// </summary>
		// Token: 0x06017F9D RID: 98205 RVA: 0x00218CB8 File Offset: 0x00216EB8
		public virtual int GetPassThroughCellIds()
		{
			return vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_GetPassThroughCellIds_14(base.GetCppThis());
		}

		// Token: 0x06017F9E RID: 98206
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetSurfaceFilter_GetPassThroughPointIds_15(HandleRef pThis);

		/// <summary>
		/// If on, the output polygonal dataset will have a celldata array that
		/// holds the cell index of the original 3D cell that produced each output
		/// cell. This is useful for cell picking. The default is off to conserve
		/// memory.
		/// </summary>
		// Token: 0x06017F9F RID: 98207 RVA: 0x00218CD8 File Offset: 0x00216ED8
		public virtual int GetPassThroughPointIds()
		{
			return vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_GetPassThroughPointIds_15(base.GetCppThis());
		}

		// Token: 0x06017FA0 RID: 98208
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetSurfaceFilter_GetPieceInvariant_16(HandleRef pThis);

		/// <summary>
		/// If PieceInvariant is true, vtkDataSetSurfaceFilter requests
		/// 1 ghost level from input in order to remove internal surface
		/// that are between processes. False by default.
		/// </summary>
		// Token: 0x06017FA1 RID: 98209 RVA: 0x00218CF8 File Offset: 0x00216EF8
		public virtual int GetPieceInvariant()
		{
			return vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_GetPieceInvariant_16(base.GetCppThis());
		}

		// Token: 0x06017FA2 RID: 98210
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetSurfaceFilter_IsA_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Statndard methods for object instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06017FA3 RID: 98211 RVA: 0x00218D18 File Offset: 0x00216F18
		public override int IsA(string type)
		{
			return vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_IsA_17(base.GetCppThis(), type);
		}

		// Token: 0x06017FA4 RID: 98212
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetSurfaceFilter_IsTypeOf_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Statndard methods for object instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06017FA5 RID: 98213 RVA: 0x00218D38 File Offset: 0x00216F38
		public new static int IsTypeOf(string type)
		{
			return vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_IsTypeOf_18(type);
		}

		// Token: 0x06017FA6 RID: 98214
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetSurfaceFilter_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Statndard methods for object instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06017FA7 RID: 98215 RVA: 0x00218D54 File Offset: 0x00216F54
		public new vtkDataSetSurfaceFilter NewInstance()
		{
			vtkDataSetSurfaceFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_NewInstance_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataSetSurfaceFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06017FA8 RID: 98216
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetSurfaceFilter_PassThroughCellIdsOff_21(HandleRef pThis);

		/// <summary>
		/// If on, the output polygonal dataset will have a celldata array that
		/// holds the cell index of the original 3D cell that produced each output
		/// cell. This is useful for cell picking. The default is off to conserve
		/// memory.
		/// </summary>
		// Token: 0x06017FA9 RID: 98217 RVA: 0x00218DAE File Offset: 0x00216FAE
		public virtual void PassThroughCellIdsOff()
		{
			vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_PassThroughCellIdsOff_21(base.GetCppThis());
		}

		// Token: 0x06017FAA RID: 98218
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetSurfaceFilter_PassThroughCellIdsOn_22(HandleRef pThis);

		/// <summary>
		/// If on, the output polygonal dataset will have a celldata array that
		/// holds the cell index of the original 3D cell that produced each output
		/// cell. This is useful for cell picking. The default is off to conserve
		/// memory.
		/// </summary>
		// Token: 0x06017FAB RID: 98219 RVA: 0x00218DBD File Offset: 0x00216FBD
		public virtual void PassThroughCellIdsOn()
		{
			vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_PassThroughCellIdsOn_22(base.GetCppThis());
		}

		// Token: 0x06017FAC RID: 98220
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetSurfaceFilter_PassThroughPointIdsOff_23(HandleRef pThis);

		/// <summary>
		/// If on, the output polygonal dataset will have a celldata array that
		/// holds the cell index of the original 3D cell that produced each output
		/// cell. This is useful for cell picking. The default is off to conserve
		/// memory.
		/// </summary>
		// Token: 0x06017FAD RID: 98221 RVA: 0x00218DCC File Offset: 0x00216FCC
		public virtual void PassThroughPointIdsOff()
		{
			vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_PassThroughPointIdsOff_23(base.GetCppThis());
		}

		// Token: 0x06017FAE RID: 98222
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetSurfaceFilter_PassThroughPointIdsOn_24(HandleRef pThis);

		/// <summary>
		/// If on, the output polygonal dataset will have a celldata array that
		/// holds the cell index of the original 3D cell that produced each output
		/// cell. This is useful for cell picking. The default is off to conserve
		/// memory.
		/// </summary>
		// Token: 0x06017FAF RID: 98223 RVA: 0x00218DDB File Offset: 0x00216FDB
		public virtual void PassThroughPointIdsOn()
		{
			vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_PassThroughPointIdsOn_24(base.GetCppThis());
		}

		// Token: 0x06017FB0 RID: 98224
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetSurfaceFilter_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Statndard methods for object instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06017FB1 RID: 98225 RVA: 0x00218DEC File Offset: 0x00216FEC
		public new static vtkDataSetSurfaceFilter SafeDownCast(vtkObjectBase o)
		{
			vtkDataSetSurfaceFilter vtkDataSetSurfaceFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_SafeDownCast_25((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSetSurfaceFilter = (vtkDataSetSurfaceFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSetSurfaceFilter.Register(null);
				}
			}
			return vtkDataSetSurfaceFilter;
		}

		// Token: 0x06017FB2 RID: 98226
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetSurfaceFilter_SetDelegation_26(HandleRef pThis, int _arg);

		/// <summary>
		/// Disable delegation to an internal vtkGeometryFilter. The geometry filter runs
		/// much faster (especially for unstructured grids); however the two filters
		/// produce slightly different output. Hence by default delegation is disabled.
		/// </summary>
		// Token: 0x06017FB3 RID: 98227 RVA: 0x00218E6B File Offset: 0x0021706B
		public virtual void SetDelegation(int _arg)
		{
			vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_SetDelegation_26(base.GetCppThis(), _arg);
		}

		// Token: 0x06017FB4 RID: 98228
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetSurfaceFilter_SetFastMode_27(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on/off fast mode execution. If enabled, fast mode typically runs
		/// much faster (2-3x) than the standard algorithm, however the output is an
		/// approximation to the correct result. Also, note that the FastMode
		/// depends on the data member Degree for its execution.
		/// </summary>
		// Token: 0x06017FB5 RID: 98229 RVA: 0x00218E7B File Offset: 0x0021707B
		public virtual void SetFastMode(bool _arg)
		{
			vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_SetFastMode_27(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06017FB6 RID: 98230
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetSurfaceFilter_SetMatchBoundariesIgnoringCellOrder_28(HandleRef pThis, int _arg);

		/// <summary>
		/// When two volumetric cells of different order are connected by their corners (for instance, a
		/// quadratic hexahedron next to a linear hexahedron ), the internal face is rendered and is not
		/// considered as a ghost cell. To remove these faces, switch MatchBoundariesIgnoringCellOrder to 1
		/// (default is 0).
		/// </summary>
		// Token: 0x06017FB7 RID: 98231 RVA: 0x00218E93 File Offset: 0x00217093
		public virtual void SetMatchBoundariesIgnoringCellOrder(int _arg)
		{
			vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_SetMatchBoundariesIgnoringCellOrder_28(base.GetCppThis(), _arg);
		}

		// Token: 0x06017FB8 RID: 98232
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetSurfaceFilter_SetNonlinearSubdivisionLevel_29(HandleRef pThis, int _arg);

		/// <summary>
		/// If the input is an unstructured grid with nonlinear faces, this parameter
		/// determines how many times the face is subdivided into linear faces.  If 0,
		/// the output is the equivalent of its linear counterpart (and the midpoints
		/// determining the nonlinear interpolation are discarded).  If 1 (the
		/// default), the nonlinear face is triangulated based on the midpoints.  If
		/// greater than 1, the triangulated pieces are recursively subdivided to reach
		/// the desired subdivision.  Setting the value to greater than 1 may cause
		/// some point data to not be passed even if no nonlinear faces exist.  This
		/// option has no effect if the input is not an unstructured grid.
		/// </summary>
		// Token: 0x06017FB9 RID: 98233 RVA: 0x00218EA3 File Offset: 0x002170A3
		public virtual void SetNonlinearSubdivisionLevel(int _arg)
		{
			vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_SetNonlinearSubdivisionLevel_29(base.GetCppThis(), _arg);
		}

		// Token: 0x06017FBA RID: 98234
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetSurfaceFilter_SetOriginalCellIdsName_30(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// If PassThroughCellIds or PassThroughPointIds is on, then these ivars
		/// control the name given to the field in which the ids are written into.  If
		/// set to nullptr, then vtkOriginalCellIds or vtkOriginalPointIds (the default)
		/// is used, respectively.
		/// </summary>
		// Token: 0x06017FBB RID: 98235 RVA: 0x00218EB3 File Offset: 0x002170B3
		public virtual void SetOriginalCellIdsName(string _arg)
		{
			vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_SetOriginalCellIdsName_30(base.GetCppThis(), _arg);
		}

		// Token: 0x06017FBC RID: 98236
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetSurfaceFilter_SetOriginalPointIdsName_31(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// If PassThroughCellIds or PassThroughPointIds is on, then these ivars
		/// control the name given to the field in which the ids are written into.  If
		/// set to nullptr, then vtkOriginalCellIds or vtkOriginalPointIds (the default)
		/// is used, respectively.
		/// </summary>
		// Token: 0x06017FBD RID: 98237 RVA: 0x00218EC3 File Offset: 0x002170C3
		public virtual void SetOriginalPointIdsName(string _arg)
		{
			vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_SetOriginalPointIdsName_31(base.GetCppThis(), _arg);
		}

		// Token: 0x06017FBE RID: 98238
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetSurfaceFilter_SetPassThroughCellIds_32(HandleRef pThis, int _arg);

		/// <summary>
		/// If on, the output polygonal dataset will have a celldata array that
		/// holds the cell index of the original 3D cell that produced each output
		/// cell. This is useful for cell picking. The default is off to conserve
		/// memory.
		/// </summary>
		// Token: 0x06017FBF RID: 98239 RVA: 0x00218ED3 File Offset: 0x002170D3
		public virtual void SetPassThroughCellIds(int _arg)
		{
			vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_SetPassThroughCellIds_32(base.GetCppThis(), _arg);
		}

		// Token: 0x06017FC0 RID: 98240
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetSurfaceFilter_SetPassThroughPointIds_33(HandleRef pThis, int _arg);

		/// <summary>
		/// If on, the output polygonal dataset will have a celldata array that
		/// holds the cell index of the original 3D cell that produced each output
		/// cell. This is useful for cell picking. The default is off to conserve
		/// memory.
		/// </summary>
		// Token: 0x06017FC1 RID: 98241 RVA: 0x00218EE3 File Offset: 0x002170E3
		public virtual void SetPassThroughPointIds(int _arg)
		{
			vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_SetPassThroughPointIds_33(base.GetCppThis(), _arg);
		}

		// Token: 0x06017FC2 RID: 98242
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetSurfaceFilter_SetPieceInvariant_34(HandleRef pThis, int _arg);

		/// <summary>
		/// If PieceInvariant is true, vtkDataSetSurfaceFilter requests
		/// 1 ghost level from input in order to remove internal surface
		/// that are between processes. False by default.
		/// </summary>
		// Token: 0x06017FC3 RID: 98243 RVA: 0x00218EF3 File Offset: 0x002170F3
		public virtual void SetPieceInvariant(int _arg)
		{
			vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_SetPieceInvariant_34(base.GetCppThis(), _arg);
		}

		// Token: 0x06017FC4 RID: 98244
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetSurfaceFilter_StructuredExecute_35(HandleRef pThis, HandleRef input, HandleRef output, IntPtr ext, IntPtr wholeExt);

		/// <summary>
		/// Direct access methods so that this class can be used as an
		/// algorithm without using it as a filter (i.e., no pipeline updates).
		/// </summary>
		// Token: 0x06017FC5 RID: 98245 RVA: 0x00218F04 File Offset: 0x00217104
		public virtual int StructuredExecute(vtkDataSet input, vtkPolyData output, IntPtr ext, IntPtr wholeExt)
		{
			return vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_StructuredExecute_35(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis(), ext, wholeExt);
		}

		// Token: 0x06017FC6 RID: 98246
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetSurfaceFilter_UniformGridExecute_36(HandleRef pThis, HandleRef input, HandleRef output, IntPtr ext, IntPtr wholeExt, IntPtr extractface);

		/// <summary>
		/// Execute the filter on \a input and store the result in \a output.
		/// The correct function should be used accordingly to the type of the input.
		/// </summary>
		// Token: 0x06017FC7 RID: 98247 RVA: 0x00218F50 File Offset: 0x00217150
		public virtual int UniformGridExecute(vtkDataSet input, vtkPolyData output, IntPtr ext, IntPtr wholeExt, IntPtr extractface)
		{
			return vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_UniformGridExecute_36(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis(), ext, wholeExt, extractface);
		}

		// Token: 0x06017FC8 RID: 98248
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetSurfaceFilter_UnstructuredGridExecute_37(HandleRef pThis, HandleRef input, HandleRef output);

		/// <summary>
		/// Execute the filter on \a input and store the result in \a output.
		/// The correct function should be used accordingly to the type of the input.
		///
		/// Input can be any subclass of \a vtkUnstructuredGridBase.
		/// In case of a \a vtkUnstructuredGrid or subclass instance, an optimized version
		/// of the filter is executed.
		/// </summary>
		// Token: 0x06017FC9 RID: 98249 RVA: 0x00218FA0 File Offset: 0x002171A0
		public virtual int UnstructuredGridExecute(vtkDataSet input, vtkPolyData output)
		{
			return vtkDataSetSurfaceFilter.vtkDataSetSurfaceFilter_UnstructuredGridExecute_37(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001ABA RID: 6842
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataSetSurfaceFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001ABB RID: 6843
		public new static readonly string MRClassNameKey = "class vtkDataSetSurfaceFilter";
	}
}
