using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRectilinearGrid
	/// </summary>
	/// <remarks>
	///    a dataset that is topologically regular with variable spacing in the three coordinate
	/// directions
	///
	/// vtkRectilinearGrid is a data object that is a concrete implementation of
	/// vtkDataSet. vtkRectilinearGrid represents a geometric structure that is
	/// topologically regular with variable spacing in the three coordinate
	/// directions x-y-z.
	///
	/// To define a vtkRectilinearGrid, you must specify the dimensions of the
	/// data and provide three arrays of values specifying the coordinates
	/// along the x-y-z axes. The coordinate arrays are specified using three
	/// vtkDataArray objects (one for x, one for y, one for z).
	///
	/// @warning
	/// Make sure that the dimensions of the grid match the number of coordinates
	/// in the x-y-z directions. If not, unpredictable results (including
	/// program failure) may result. Also, you must supply coordinates in all
	/// three directions, even if the dataset topology is 2D, 1D, or 0D.
	/// </remarks>
	// Token: 0x02000AB7 RID: 2743
	public class vtkRectilinearGrid : vtkDataSet
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601CDCA RID: 118218 RVA: 0x0028A5CF File Offset: 0x002887CF
		static vtkRectilinearGrid()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRectilinearGrid.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRectilinearGrid"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601CDCB RID: 118219 RVA: 0x0028A5F7 File Offset: 0x002887F7
		public vtkRectilinearGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601CDCC RID: 118220
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CDCD RID: 118221 RVA: 0x0028A608 File Offset: 0x00288808
		public new static vtkRectilinearGrid New()
		{
			vtkRectilinearGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearGrid.vtkRectilinearGrid_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRectilinearGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CDCE RID: 118222 RVA: 0x0028A65C File Offset: 0x0028885C
		public vtkRectilinearGrid() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRectilinearGrid.vtkRectilinearGrid_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601CDCF RID: 118223 RVA: 0x0028A6A0 File Offset: 0x002888A0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601CDD0 RID: 118224
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGrid_ComputeBounds_01(HandleRef pThis);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601CDD1 RID: 118225 RVA: 0x0028A6AB File Offset: 0x002888AB
		public override void ComputeBounds()
		{
			vtkRectilinearGrid.vtkRectilinearGrid_ComputeBounds_01(base.GetCppThis());
		}

		// Token: 0x0601CDD2 RID: 118226
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRectilinearGrid_ComputeCellId_02(HandleRef pThis, IntPtr ijk);

		/// <summary>
		/// Given a location in structured coordinates (i-j-k), return the cell id.
		/// </summary>
		// Token: 0x0601CDD3 RID: 118227 RVA: 0x0028A6BC File Offset: 0x002888BC
		public long ComputeCellId(IntPtr ijk)
		{
			return vtkRectilinearGrid.vtkRectilinearGrid_ComputeCellId_02(base.GetCppThis(), ijk);
		}

		// Token: 0x0601CDD4 RID: 118228
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRectilinearGrid_ComputePointId_03(HandleRef pThis, IntPtr ijk);

		/// <summary>
		/// Given a location in structured coordinates (i-j-k), return the point id.
		/// </summary>
		// Token: 0x0601CDD5 RID: 118229 RVA: 0x0028A6DC File Offset: 0x002888DC
		public long ComputePointId(IntPtr ijk)
		{
			return vtkRectilinearGrid.vtkRectilinearGrid_ComputePointId_03(base.GetCppThis(), ijk);
		}

		// Token: 0x0601CDD6 RID: 118230
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearGrid_ComputeStructuredCoordinates_04(HandleRef pThis, IntPtr x, IntPtr ijk, IntPtr pcoords);

		/// <summary>
		/// Convenience function computes the structured coordinates for a point x[3].
		/// The cell is specified by the array ijk[3], and the parametric coordinates
		/// in the cell are specified with pcoords[3]. The function returns a 0 if the
		/// point x is outside of the grid, and a 1 if inside the grid.
		/// </summary>
		// Token: 0x0601CDD7 RID: 118231 RVA: 0x0028A6FC File Offset: 0x002888FC
		public int ComputeStructuredCoordinates(IntPtr x, IntPtr ijk, IntPtr pcoords)
		{
			return vtkRectilinearGrid.vtkRectilinearGrid_ComputeStructuredCoordinates_04(base.GetCppThis(), x, ijk, pcoords);
		}

		// Token: 0x0601CDD8 RID: 118232
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGrid_CopyStructure_05(HandleRef pThis, HandleRef ds);

		/// <summary>
		/// Copy the geometric and topological structure of an input rectilinear grid
		/// object.
		/// </summary>
		// Token: 0x0601CDD9 RID: 118233 RVA: 0x0028A720 File Offset: 0x00288920
		public override void CopyStructure(vtkDataSet ds)
		{
			vtkRectilinearGrid.vtkRectilinearGrid_CopyStructure_05(base.GetCppThis(), (ds == null) ? default(HandleRef) : ds.GetCppThis());
		}

		// Token: 0x0601CDDA RID: 118234
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGrid_Crop_06(HandleRef pThis, IntPtr updateExtent);

		/// <summary>
		/// Reallocates and copies to set the Extent to the UpdateExtent.
		/// This is used internally when the exact extent is requested,
		/// and the source generated more than the update extent.
		/// </summary>
		// Token: 0x0601CDDB RID: 118235 RVA: 0x0028A74F File Offset: 0x0028894F
		public override void Crop(IntPtr updateExtent)
		{
			vtkRectilinearGrid.vtkRectilinearGrid_Crop_06(base.GetCppThis(), updateExtent);
		}

		// Token: 0x0601CDDC RID: 118236
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGrid_DeepCopy_07(HandleRef pThis, HandleRef src);

		/// <summary>
		/// Shallow and Deep copy.
		/// </summary>
		// Token: 0x0601CDDD RID: 118237 RVA: 0x0028A760 File Offset: 0x00288960
		public override void DeepCopy(vtkDataObject src)
		{
			vtkRectilinearGrid.vtkRectilinearGrid_DeepCopy_07(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		// Token: 0x0601CDDE RID: 118238
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGrid_ExtendedNew_08(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CDDF RID: 118239 RVA: 0x0028A790 File Offset: 0x00288990
		public static vtkRectilinearGrid ExtendedNew()
		{
			vtkRectilinearGrid vtkRectilinearGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearGrid.vtkRectilinearGrid_ExtendedNew_08(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRectilinearGrid = (vtkRectilinearGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRectilinearGrid.Register(null);
				}
			}
			return vtkRectilinearGrid;
		}

		// Token: 0x0601CDE0 RID: 118240
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGrid_FindAndGetCell_09(HandleRef pThis, IntPtr x, HandleRef cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601CDE1 RID: 118241 RVA: 0x0028A7FC File Offset: 0x002889FC
		public override vtkCell FindAndGetCell(IntPtr x, vtkCell cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearGrid.vtkRectilinearGrid_FindAndGetCell_09(base.GetCppThis(), x, (cell == null) ? default(HandleRef) : cell.GetCppThis(), cellId, tol2, ref subId, pcoords, weights, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCell = (vtkCell)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCell.Register(null);
				}
			}
			return vtkCell;
		}

		// Token: 0x0601CDE2 RID: 118242
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRectilinearGrid_FindCell_10(HandleRef pThis, IntPtr x, HandleRef cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601CDE3 RID: 118243 RVA: 0x0028A88C File Offset: 0x00288A8C
		public override long FindCell(IntPtr x, vtkCell cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights)
		{
			return vtkRectilinearGrid.vtkRectilinearGrid_FindCell_10(base.GetCppThis(), x, (cell == null) ? default(HandleRef) : cell.GetCppThis(), cellId, tol2, ref subId, pcoords, weights);
		}

		// Token: 0x0601CDE4 RID: 118244
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRectilinearGrid_FindCell_11(HandleRef pThis, IntPtr x, HandleRef cell, HandleRef gencell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601CDE5 RID: 118245 RVA: 0x0028A8CC File Offset: 0x00288ACC
		public override long FindCell(IntPtr x, vtkCell cell, vtkGenericCell gencell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights)
		{
			return vtkRectilinearGrid.vtkRectilinearGrid_FindCell_11(base.GetCppThis(), x, (cell == null) ? default(HandleRef) : cell.GetCppThis(), (gencell == null) ? default(HandleRef) : gencell.GetCppThis(), cellId, tol2, ref subId, pcoords, weights);
		}

		// Token: 0x0601CDE6 RID: 118246
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRectilinearGrid_FindPoint_12(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601CDE7 RID: 118247 RVA: 0x0028A920 File Offset: 0x00288B20
		public new long FindPoint(double x, double y, double z)
		{
			return vtkRectilinearGrid.vtkRectilinearGrid_FindPoint_12(base.GetCppThis(), x, y, z);
		}

		// Token: 0x0601CDE8 RID: 118248
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRectilinearGrid_FindPoint_13(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601CDE9 RID: 118249 RVA: 0x0028A944 File Offset: 0x00288B44
		public override long FindPoint(IntPtr x)
		{
			return vtkRectilinearGrid.vtkRectilinearGrid_FindPoint_13(base.GetCppThis(), x);
		}

		// Token: 0x0601CDEA RID: 118250
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkRectilinearGrid_GetActualMemorySize_14(HandleRef pThis);

		/// <summary>
		/// Return the actual size of the data in kibibytes (1024 bytes). This number
		/// is valid only after the pipeline has updated. The memory size
		/// returned is guaranteed to be greater than or equal to the
		/// memory required to represent the data (e.g., extra space in
		/// arrays, etc. are not included in the return value). THIS METHOD
		/// IS THREAD SAFE.
		/// </summary>
		// Token: 0x0601CDEB RID: 118251 RVA: 0x0028A964 File Offset: 0x00288B64
		public override uint GetActualMemorySize()
		{
			return vtkRectilinearGrid.vtkRectilinearGrid_GetActualMemorySize_14(base.GetCppThis());
		}

		// Token: 0x0601CDEC RID: 118252
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGrid_GetCell_15(HandleRef pThis, long cellId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601CDED RID: 118253 RVA: 0x0028A984 File Offset: 0x00288B84
		public override vtkCell GetCell(long cellId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearGrid.vtkRectilinearGrid_GetCell_15(base.GetCppThis(), cellId, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCell = (vtkCell)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCell.Register(null);
				}
			}
			return vtkCell;
		}

		// Token: 0x0601CDEE RID: 118254
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGrid_GetCell_16(HandleRef pThis, int i, int j, int k, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601CDEF RID: 118255 RVA: 0x0028A9F4 File Offset: 0x00288BF4
		public override vtkCell GetCell(int i, int j, int k)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearGrid.vtkRectilinearGrid_GetCell_16(base.GetCppThis(), i, j, k, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCell = (vtkCell)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCell.Register(null);
				}
			}
			return vtkCell;
		}

		// Token: 0x0601CDF0 RID: 118256
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGrid_GetCell_17(HandleRef pThis, long cellId, HandleRef cell);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601CDF1 RID: 118257 RVA: 0x0028AA68 File Offset: 0x00288C68
		public override void GetCell(long cellId, vtkGenericCell cell)
		{
			vtkRectilinearGrid.vtkRectilinearGrid_GetCell_17(base.GetCppThis(), cellId, (cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x0601CDF2 RID: 118258
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGrid_GetCellBounds_18(HandleRef pThis, long cellId, IntPtr bounds);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601CDF3 RID: 118259 RVA: 0x0028AA98 File Offset: 0x00288C98
		public override void GetCellBounds(long cellId, IntPtr bounds)
		{
			vtkRectilinearGrid.vtkRectilinearGrid_GetCellBounds_18(base.GetCppThis(), cellId, bounds);
		}

		// Token: 0x0601CDF4 RID: 118260
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGrid_GetCellDims_19(HandleRef pThis, IntPtr cellDims);

		/// <summary>
		/// Given the node dimensions of this grid instance, this method computes the
		/// node dimensions. The value in each dimension can will have a lowest value
		/// of "1" such that computing the total number of cells can be achieved by
		/// simply by cellDims[0]*cellDims[1]*cellDims[2].
		/// </summary>
		// Token: 0x0601CDF5 RID: 118261 RVA: 0x0028AAA9 File Offset: 0x00288CA9
		public void GetCellDims(IntPtr cellDims)
		{
			vtkRectilinearGrid.vtkRectilinearGrid_GetCellDims_19(base.GetCppThis(), cellDims);
		}

		// Token: 0x0601CDF6 RID: 118262
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGrid_GetCellNeighbors_20(HandleRef pThis, long cellId, HandleRef ptIds, HandleRef cellIds);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601CDF7 RID: 118263 RVA: 0x0028AABC File Offset: 0x00288CBC
		public override void GetCellNeighbors(long cellId, vtkIdList ptIds, vtkIdList cellIds)
		{
			vtkRectilinearGrid.vtkRectilinearGrid_GetCellNeighbors_20(base.GetCppThis(), cellId, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis(), (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis());
		}

		// Token: 0x0601CDF8 RID: 118264
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGrid_GetCellNeighbors_21(HandleRef pThis, long cellId, HandleRef ptIds, HandleRef cellIds, IntPtr seedLoc);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601CDF9 RID: 118265 RVA: 0x0028AB04 File Offset: 0x00288D04
		public void GetCellNeighbors(long cellId, vtkIdList ptIds, vtkIdList cellIds, IntPtr seedLoc)
		{
			vtkRectilinearGrid.vtkRectilinearGrid_GetCellNeighbors_21(base.GetCppThis(), cellId, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis(), (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis(), seedLoc);
		}

		// Token: 0x0601CDFA RID: 118266
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGrid_GetCellPoints_22(HandleRef pThis, long cellId, HandleRef ptIds);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601CDFB RID: 118267 RVA: 0x0028AB4C File Offset: 0x00288D4C
		public override void GetCellPoints(long cellId, vtkIdList ptIds)
		{
			vtkRectilinearGrid.vtkRectilinearGrid_GetCellPoints_22(base.GetCppThis(), cellId, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		// Token: 0x0601CDFC RID: 118268
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRectilinearGrid_GetCellSize_23(HandleRef pThis, long cellId);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601CDFD RID: 118269 RVA: 0x0028AB7C File Offset: 0x00288D7C
		public override long GetCellSize(long cellId)
		{
			return vtkRectilinearGrid.vtkRectilinearGrid_GetCellSize_23(base.GetCppThis(), cellId);
		}

		// Token: 0x0601CDFE RID: 118270
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearGrid_GetCellType_24(HandleRef pThis, long cellId);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601CDFF RID: 118271 RVA: 0x0028AB9C File Offset: 0x00288D9C
		public override int GetCellType(long cellId)
		{
			return vtkRectilinearGrid.vtkRectilinearGrid_GetCellType_24(base.GetCppThis(), cellId);
		}

		// Token: 0x0601CE00 RID: 118272
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGrid_GetData_25(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x0601CE01 RID: 118273 RVA: 0x0028ABBC File Offset: 0x00288DBC
		public new static vtkRectilinearGrid GetData(vtkInformation info)
		{
			vtkRectilinearGrid vtkRectilinearGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearGrid.vtkRectilinearGrid_GetData_25((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRectilinearGrid = (vtkRectilinearGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRectilinearGrid.Register(null);
				}
			}
			return vtkRectilinearGrid;
		}

		// Token: 0x0601CE02 RID: 118274
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGrid_GetData_26(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x0601CE03 RID: 118275 RVA: 0x0028AC3C File Offset: 0x00288E3C
		public new static vtkRectilinearGrid GetData(vtkInformationVector v, int i)
		{
			vtkRectilinearGrid vtkRectilinearGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearGrid.vtkRectilinearGrid_GetData_26((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRectilinearGrid = (vtkRectilinearGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRectilinearGrid.Register(null);
				}
			}
			return vtkRectilinearGrid;
		}

		// Token: 0x0601CE04 RID: 118276
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearGrid_GetDataDimension_27(HandleRef pThis);

		/// <summary>
		/// Return the dimensionality of the data.
		/// </summary>
		// Token: 0x0601CE05 RID: 118277 RVA: 0x0028ACBC File Offset: 0x00288EBC
		public int GetDataDimension()
		{
			return vtkRectilinearGrid.vtkRectilinearGrid_GetDataDimension_27(base.GetCppThis());
		}

		// Token: 0x0601CE06 RID: 118278
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearGrid_GetDataObjectType_28(HandleRef pThis);

		/// <summary>
		/// Return what type of dataset this is.
		/// </summary>
		// Token: 0x0601CE07 RID: 118279 RVA: 0x0028ACDC File Offset: 0x00288EDC
		public override int GetDataObjectType()
		{
			return vtkRectilinearGrid.vtkRectilinearGrid_GetDataObjectType_28(base.GetCppThis());
		}

		// Token: 0x0601CE08 RID: 118280
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGrid_GetDimensions_29(HandleRef pThis);

		/// <summary>
		/// Get dimensions of this rectilinear grid dataset.
		/// </summary>
		// Token: 0x0601CE09 RID: 118281 RVA: 0x0028ACFC File Offset: 0x00288EFC
		public virtual int[] GetDimensions()
		{
			IntPtr intPtr = vtkRectilinearGrid.vtkRectilinearGrid_GetDimensions_29(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601CE0A RID: 118282
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGrid_GetDimensions_30(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Get dimensions of this rectilinear grid dataset.
		/// </summary>
		// Token: 0x0601CE0B RID: 118283 RVA: 0x0028AD44 File Offset: 0x00288F44
		public virtual void GetDimensions(IntPtr data)
		{
			vtkRectilinearGrid.vtkRectilinearGrid_GetDimensions_30(base.GetCppThis(), data);
		}

		// Token: 0x0601CE0C RID: 118284
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGrid_GetExtent_31(HandleRef pThis);

		/// <summary>
		/// Different ways to set the extent of the data array.  The extent
		/// should be set before the "Scalars" are set or allocated.
		/// The Extent is stored in the order (X, Y, Z).
		/// </summary>
		// Token: 0x0601CE0D RID: 118285 RVA: 0x0028AD54 File Offset: 0x00288F54
		public virtual int[] GetExtent()
		{
			IntPtr intPtr = vtkRectilinearGrid.vtkRectilinearGrid_GetExtent_31(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601CE0E RID: 118286
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGrid_GetExtent_32(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		/// <summary>
		/// Different ways to set the extent of the data array.  The extent
		/// should be set before the "Scalars" are set or allocated.
		/// The Extent is stored in the order (X, Y, Z).
		/// </summary>
		// Token: 0x0601CE0F RID: 118287 RVA: 0x0028AD9C File Offset: 0x00288F9C
		public virtual void GetExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkRectilinearGrid.vtkRectilinearGrid_GetExtent_32(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		// Token: 0x0601CE10 RID: 118288
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGrid_GetExtent_33(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Different ways to set the extent of the data array.  The extent
		/// should be set before the "Scalars" are set or allocated.
		/// The Extent is stored in the order (X, Y, Z).
		/// </summary>
		// Token: 0x0601CE11 RID: 118289 RVA: 0x0028ADB4 File Offset: 0x00288FB4
		public virtual void GetExtent(IntPtr _arg)
		{
			vtkRectilinearGrid.vtkRectilinearGrid_GetExtent_33(base.GetCppThis(), _arg);
		}

		// Token: 0x0601CE12 RID: 118290
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearGrid_GetExtentType_34(HandleRef pThis);

		/// <summary>
		/// Structured extent. The extent type is a 3D extent
		/// </summary>
		// Token: 0x0601CE13 RID: 118291 RVA: 0x0028ADC4 File Offset: 0x00288FC4
		public override int GetExtentType()
		{
			return vtkRectilinearGrid.vtkRectilinearGrid_GetExtentType_34(base.GetCppThis());
		}

		// Token: 0x0601CE14 RID: 118292
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearGrid_GetMaxCellSize_35(HandleRef pThis);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601CE15 RID: 118293 RVA: 0x0028ADE4 File Offset: 0x00288FE4
		public override int GetMaxCellSize()
		{
			return vtkRectilinearGrid.vtkRectilinearGrid_GetMaxCellSize_35(base.GetCppThis());
		}

		// Token: 0x0601CE16 RID: 118294
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearGrid_GetMaxSpatialDimension_36(HandleRef pThis);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601CE17 RID: 118295 RVA: 0x0028AE04 File Offset: 0x00289004
		public override int GetMaxSpatialDimension()
		{
			return vtkRectilinearGrid.vtkRectilinearGrid_GetMaxSpatialDimension_36(base.GetCppThis());
		}

		// Token: 0x0601CE18 RID: 118296
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRectilinearGrid_GetNumberOfCells_37(HandleRef pThis);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601CE19 RID: 118297 RVA: 0x0028AE24 File Offset: 0x00289024
		public override long GetNumberOfCells()
		{
			return vtkRectilinearGrid.vtkRectilinearGrid_GetNumberOfCells_37(base.GetCppThis());
		}

		// Token: 0x0601CE1A RID: 118298
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRectilinearGrid_GetNumberOfGenerationsFromBase_38(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CE1B RID: 118299 RVA: 0x0028AE44 File Offset: 0x00289044
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRectilinearGrid.vtkRectilinearGrid_GetNumberOfGenerationsFromBase_38(base.GetCppThis(), type);
		}

		// Token: 0x0601CE1C RID: 118300
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRectilinearGrid_GetNumberOfGenerationsFromBaseType_39([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CE1D RID: 118301 RVA: 0x0028AE64 File Offset: 0x00289064
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRectilinearGrid.vtkRectilinearGrid_GetNumberOfGenerationsFromBaseType_39(type);
		}

		// Token: 0x0601CE1E RID: 118302
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRectilinearGrid_GetNumberOfPoints_40(HandleRef pThis);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601CE1F RID: 118303 RVA: 0x0028AE80 File Offset: 0x00289080
		public override long GetNumberOfPoints()
		{
			return vtkRectilinearGrid.vtkRectilinearGrid_GetNumberOfPoints_40(base.GetCppThis());
		}

		// Token: 0x0601CE20 RID: 118304
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearGrid_GetNumberOfScalarComponents_41(HandleRef meta_data);

		/// <summary>
		/// Set/Get the number of scalar components for points. As with the
		/// SetScalarType method this is setting pipeline info.
		/// </summary>
		// Token: 0x0601CE21 RID: 118305 RVA: 0x0028AEA0 File Offset: 0x002890A0
		public static int GetNumberOfScalarComponents(vtkInformation meta_data)
		{
			return vtkRectilinearGrid.vtkRectilinearGrid_GetNumberOfScalarComponents_41((meta_data == null) ? default(HandleRef) : meta_data.GetCppThis());
		}

		// Token: 0x0601CE22 RID: 118306
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearGrid_GetNumberOfScalarComponents_42(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of scalar components for points. As with the
		/// SetScalarType method this is setting pipeline info.
		/// </summary>
		// Token: 0x0601CE23 RID: 118307 RVA: 0x0028AED0 File Offset: 0x002890D0
		public int GetNumberOfScalarComponents()
		{
			return vtkRectilinearGrid.vtkRectilinearGrid_GetNumberOfScalarComponents_42(base.GetCppThis());
		}

		// Token: 0x0601CE24 RID: 118308
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGrid_GetPoint_43(HandleRef pThis, long ptId);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601CE25 RID: 118309 RVA: 0x0028AEF0 File Offset: 0x002890F0
		public override double[] GetPoint(long ptId)
		{
			IntPtr intPtr = vtkRectilinearGrid.vtkRectilinearGrid_GetPoint_43(base.GetCppThis(), ptId);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601CE26 RID: 118310
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGrid_GetPoint_44(HandleRef pThis, long id, IntPtr x);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601CE27 RID: 118311 RVA: 0x0028AF39 File Offset: 0x00289139
		public override void GetPoint(long id, IntPtr x)
		{
			vtkRectilinearGrid.vtkRectilinearGrid_GetPoint_44(base.GetCppThis(), id, x);
		}

		// Token: 0x0601CE28 RID: 118312
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGrid_GetPoint_45(HandleRef pThis, int i, int j, int k, IntPtr p);

		/// <summary>
		/// Given the IJK-coordinates of the point, it returns the corresponding
		/// xyz-coordinates. The xyz coordinates are stored in the user-supplied
		/// array p.
		/// </summary>
		// Token: 0x0601CE29 RID: 118313 RVA: 0x0028AF4A File Offset: 0x0028914A
		public void GetPoint(int i, int j, int k, IntPtr p)
		{
			vtkRectilinearGrid.vtkRectilinearGrid_GetPoint_45(base.GetCppThis(), i, j, k, p);
		}

		// Token: 0x0601CE2A RID: 118314
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGrid_GetPointCells_46(HandleRef pThis, long ptId, HandleRef cellIds);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601CE2B RID: 118315 RVA: 0x0028AF60 File Offset: 0x00289160
		public override void GetPointCells(long ptId, vtkIdList cellIds)
		{
			vtkRectilinearGrid.vtkRectilinearGrid_GetPointCells_46(base.GetCppThis(), ptId, (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis());
		}

		// Token: 0x0601CE2C RID: 118316
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGrid_GetPoints_47(HandleRef pThis, HandleRef pnts);

		/// <summary>
		/// Given a user-supplied vtkPoints container object, this method fills in all
		/// the points of the RectilinearGrid.
		/// </summary>
		// Token: 0x0601CE2D RID: 118317 RVA: 0x0028AF90 File Offset: 0x00289190
		public void GetPoints(vtkPoints pnts)
		{
			vtkRectilinearGrid.vtkRectilinearGrid_GetPoints_47(base.GetCppThis(), (pnts == null) ? default(HandleRef) : pnts.GetCppThis());
		}

		// Token: 0x0601CE2E RID: 118318
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearGrid_GetScalarType_48(HandleRef meta_data);

		/// <summary>
		/// Set/Get the scalar data type for the points. This is setting pipeline info.
		/// </summary>
		// Token: 0x0601CE2F RID: 118319 RVA: 0x0028AFC0 File Offset: 0x002891C0
		public static int GetScalarType(vtkInformation meta_data)
		{
			return vtkRectilinearGrid.vtkRectilinearGrid_GetScalarType_48((meta_data == null) ? default(HandleRef) : meta_data.GetCppThis());
		}

		// Token: 0x0601CE30 RID: 118320
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearGrid_GetScalarType_49(HandleRef pThis);

		/// <summary>
		/// Set/Get the scalar data type for the points. This is setting pipeline info.
		/// </summary>
		// Token: 0x0601CE31 RID: 118321 RVA: 0x0028AFF0 File Offset: 0x002891F0
		public int GetScalarType()
		{
			return vtkRectilinearGrid.vtkRectilinearGrid_GetScalarType_49(base.GetCppThis());
		}

		// Token: 0x0601CE32 RID: 118322
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGrid_GetScalarTypeAsString_50(HandleRef pThis);

		/// <summary>
		/// Set/Get the scalar data type for the points. This is setting pipeline info.
		/// </summary>
		// Token: 0x0601CE33 RID: 118323 RVA: 0x0028B010 File Offset: 0x00289210
		public string GetScalarTypeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkRectilinearGrid.vtkRectilinearGrid_GetScalarTypeAsString_50(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601CE34 RID: 118324
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGrid_GetXCoordinates_51(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the grid coordinates in the x-direction.
		/// </summary>
		// Token: 0x0601CE35 RID: 118325 RVA: 0x0028B04C File Offset: 0x0028924C
		public virtual vtkDataArray GetXCoordinates()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearGrid.vtkRectilinearGrid_GetXCoordinates_51(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		// Token: 0x0601CE36 RID: 118326
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGrid_GetYCoordinates_52(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the grid coordinates in the y-direction.
		/// </summary>
		// Token: 0x0601CE37 RID: 118327 RVA: 0x0028B0BC File Offset: 0x002892BC
		public virtual vtkDataArray GetYCoordinates()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearGrid.vtkRectilinearGrid_GetYCoordinates_52(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		// Token: 0x0601CE38 RID: 118328
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGrid_GetZCoordinates_53(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the grid coordinates in the z-direction.
		/// </summary>
		// Token: 0x0601CE39 RID: 118329 RVA: 0x0028B12C File Offset: 0x0028932C
		public virtual vtkDataArray GetZCoordinates()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearGrid.vtkRectilinearGrid_GetZCoordinates_53(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		// Token: 0x0601CE3A RID: 118330
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRectilinearGrid_HasAnyBlankCells_54(HandleRef pThis);

		/// <summary>
		/// Returns 1 if there is any visibility constraint on the cells,
		/// 0 otherwise.
		/// </summary>
		// Token: 0x0601CE3B RID: 118331 RVA: 0x0028B19C File Offset: 0x0028939C
		public override bool HasAnyBlankCells()
		{
			return vtkRectilinearGrid.vtkRectilinearGrid_HasAnyBlankCells_54(base.GetCppThis()) != 0;
		}

		// Token: 0x0601CE3C RID: 118332
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRectilinearGrid_HasAnyBlankPoints_55(HandleRef pThis);

		/// <summary>
		/// Returns 1 if there is any visibility constraint on the points,
		/// 0 otherwise.
		/// </summary>
		// Token: 0x0601CE3D RID: 118333 RVA: 0x0028B1C4 File Offset: 0x002893C4
		public override bool HasAnyBlankPoints()
		{
			return vtkRectilinearGrid.vtkRectilinearGrid_HasAnyBlankPoints_55(base.GetCppThis()) != 0;
		}

		// Token: 0x0601CE3E RID: 118334
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRectilinearGrid_HasNumberOfScalarComponents_56(HandleRef meta_data);

		/// <summary>
		/// Set/Get the number of scalar components for points. As with the
		/// SetScalarType method this is setting pipeline info.
		/// </summary>
		// Token: 0x0601CE3F RID: 118335 RVA: 0x0028B1EC File Offset: 0x002893EC
		public static bool HasNumberOfScalarComponents(vtkInformation meta_data)
		{
			return vtkRectilinearGrid.vtkRectilinearGrid_HasNumberOfScalarComponents_56((meta_data == null) ? default(HandleRef) : meta_data.GetCppThis()) != 0;
		}

		// Token: 0x0601CE40 RID: 118336
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRectilinearGrid_HasScalarType_57(HandleRef meta_data);

		/// <summary>
		/// Set/Get the scalar data type for the points. This is setting pipeline info.
		/// </summary>
		// Token: 0x0601CE41 RID: 118337 RVA: 0x0028B224 File Offset: 0x00289424
		public static bool HasScalarType(vtkInformation meta_data)
		{
			return vtkRectilinearGrid.vtkRectilinearGrid_HasScalarType_57((meta_data == null) ? default(HandleRef) : meta_data.GetCppThis()) != 0;
		}

		// Token: 0x0601CE42 RID: 118338
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGrid_Initialize_58(HandleRef pThis);

		/// <summary>
		/// Restore object to initial state. Release memory back to system.
		/// </summary>
		// Token: 0x0601CE43 RID: 118339 RVA: 0x0028B259 File Offset: 0x00289459
		public override void Initialize()
		{
			vtkRectilinearGrid.vtkRectilinearGrid_Initialize_58(base.GetCppThis());
		}

		// Token: 0x0601CE44 RID: 118340
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearGrid_IsA_59(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CE45 RID: 118341 RVA: 0x0028B268 File Offset: 0x00289468
		public override int IsA(string type)
		{
			return vtkRectilinearGrid.vtkRectilinearGrid_IsA_59(base.GetCppThis(), type);
		}

		// Token: 0x0601CE46 RID: 118342
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRectilinearGrid_IsCellVisible_60(HandleRef pThis, long cellId);

		/// <summary>
		/// Return non-zero value if specified point is visible.
		/// These methods should be called only after the dimensions of the
		/// grid are set.
		/// </summary>
		// Token: 0x0601CE47 RID: 118343 RVA: 0x0028B288 File Offset: 0x00289488
		public byte IsCellVisible(long cellId)
		{
			return vtkRectilinearGrid.vtkRectilinearGrid_IsCellVisible_60(base.GetCppThis(), cellId);
		}

		// Token: 0x0601CE48 RID: 118344
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRectilinearGrid_IsPointVisible_61(HandleRef pThis, long ptId);

		/// <summary>
		/// Return non-zero value if specified point is visible.
		/// These methods should be called only after the dimensions of the
		/// grid are set.
		/// </summary>
		// Token: 0x0601CE49 RID: 118345 RVA: 0x0028B2A8 File Offset: 0x002894A8
		public byte IsPointVisible(long ptId)
		{
			return vtkRectilinearGrid.vtkRectilinearGrid_IsPointVisible_61(base.GetCppThis(), ptId);
		}

		// Token: 0x0601CE4A RID: 118346
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearGrid_IsTypeOf_62([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CE4B RID: 118347 RVA: 0x0028B2C8 File Offset: 0x002894C8
		public new static int IsTypeOf(string type)
		{
			return vtkRectilinearGrid.vtkRectilinearGrid_IsTypeOf_62(type);
		}

		// Token: 0x0601CE4C RID: 118348
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGrid_NewInstance_64(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CE4D RID: 118349 RVA: 0x0028B2E4 File Offset: 0x002894E4
		public new vtkRectilinearGrid NewInstance()
		{
			vtkRectilinearGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearGrid.vtkRectilinearGrid_NewInstance_64(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRectilinearGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601CE4E RID: 118350
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGrid_SafeDownCast_65(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CE4F RID: 118351 RVA: 0x0028B340 File Offset: 0x00289540
		public new static vtkRectilinearGrid SafeDownCast(vtkObjectBase o)
		{
			vtkRectilinearGrid vtkRectilinearGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearGrid.vtkRectilinearGrid_SafeDownCast_65((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRectilinearGrid = (vtkRectilinearGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRectilinearGrid.Register(null);
				}
			}
			return vtkRectilinearGrid;
		}

		// Token: 0x0601CE50 RID: 118352
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGrid_SetDimensions_66(HandleRef pThis, int i, int j, int k);

		/// <summary>
		/// Set dimensions of rectilinear grid dataset.
		/// This also sets the extent.
		/// </summary>
		// Token: 0x0601CE51 RID: 118353 RVA: 0x0028B3BF File Offset: 0x002895BF
		public void SetDimensions(int i, int j, int k)
		{
			vtkRectilinearGrid.vtkRectilinearGrid_SetDimensions_66(base.GetCppThis(), i, j, k);
		}

		// Token: 0x0601CE52 RID: 118354
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGrid_SetDimensions_67(HandleRef pThis, IntPtr dim);

		/// <summary>
		/// Set dimensions of rectilinear grid dataset.
		/// This also sets the extent.
		/// </summary>
		// Token: 0x0601CE53 RID: 118355 RVA: 0x0028B3D1 File Offset: 0x002895D1
		public void SetDimensions(IntPtr dim)
		{
			vtkRectilinearGrid.vtkRectilinearGrid_SetDimensions_67(base.GetCppThis(), dim);
		}

		// Token: 0x0601CE54 RID: 118356
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGrid_SetExtent_68(HandleRef pThis, IntPtr extent);

		/// <summary>
		/// Different ways to set the extent of the data array.  The extent
		/// should be set before the "Scalars" are set or allocated.
		/// The Extent is stored in the order (X, Y, Z).
		/// </summary>
		// Token: 0x0601CE55 RID: 118357 RVA: 0x0028B3E1 File Offset: 0x002895E1
		public void SetExtent(IntPtr extent)
		{
			vtkRectilinearGrid.vtkRectilinearGrid_SetExtent_68(base.GetCppThis(), extent);
		}

		// Token: 0x0601CE56 RID: 118358
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGrid_SetExtent_69(HandleRef pThis, int xMin, int xMax, int yMin, int yMax, int zMin, int zMax);

		/// <summary>
		/// Different ways to set the extent of the data array.  The extent
		/// should be set before the "Scalars" are set or allocated.
		/// The Extent is stored in the order (X, Y, Z).
		/// </summary>
		// Token: 0x0601CE57 RID: 118359 RVA: 0x0028B3F1 File Offset: 0x002895F1
		public void SetExtent(int xMin, int xMax, int yMin, int yMax, int zMin, int zMax)
		{
			vtkRectilinearGrid.vtkRectilinearGrid_SetExtent_69(base.GetCppThis(), xMin, xMax, yMin, yMax, zMin, zMax);
		}

		// Token: 0x0601CE58 RID: 118360
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGrid_SetNumberOfScalarComponents_70(int n, HandleRef meta_data);

		/// <summary>
		/// Set/Get the number of scalar components for points. As with the
		/// SetScalarType method this is setting pipeline info.
		/// </summary>
		// Token: 0x0601CE59 RID: 118361 RVA: 0x0028B40C File Offset: 0x0028960C
		public static void SetNumberOfScalarComponents(int n, vtkInformation meta_data)
		{
			vtkRectilinearGrid.vtkRectilinearGrid_SetNumberOfScalarComponents_70(n, (meta_data == null) ? default(HandleRef) : meta_data.GetCppThis());
		}

		// Token: 0x0601CE5A RID: 118362
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGrid_SetScalarType_71(int arg0, HandleRef meta_data);

		/// <summary>
		/// Set/Get the scalar data type for the points. This is setting pipeline info.
		/// </summary>
		// Token: 0x0601CE5B RID: 118363 RVA: 0x0028B438 File Offset: 0x00289638
		public static void SetScalarType(int arg0, vtkInformation meta_data)
		{
			vtkRectilinearGrid.vtkRectilinearGrid_SetScalarType_71(arg0, (meta_data == null) ? default(HandleRef) : meta_data.GetCppThis());
		}

		// Token: 0x0601CE5C RID: 118364
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGrid_SetXCoordinates_72(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the grid coordinates in the x-direction.
		/// </summary>
		// Token: 0x0601CE5D RID: 118365 RVA: 0x0028B464 File Offset: 0x00289664
		public virtual void SetXCoordinates(vtkDataArray arg0)
		{
			vtkRectilinearGrid.vtkRectilinearGrid_SetXCoordinates_72(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601CE5E RID: 118366
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGrid_SetYCoordinates_73(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the grid coordinates in the y-direction.
		/// </summary>
		// Token: 0x0601CE5F RID: 118367 RVA: 0x0028B494 File Offset: 0x00289694
		public virtual void SetYCoordinates(vtkDataArray arg0)
		{
			vtkRectilinearGrid.vtkRectilinearGrid_SetYCoordinates_73(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601CE60 RID: 118368
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGrid_SetZCoordinates_74(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the grid coordinates in the z-direction.
		/// </summary>
		// Token: 0x0601CE61 RID: 118369 RVA: 0x0028B4C4 File Offset: 0x002896C4
		public virtual void SetZCoordinates(vtkDataArray arg0)
		{
			vtkRectilinearGrid.vtkRectilinearGrid_SetZCoordinates_74(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601CE62 RID: 118370
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGrid_ShallowCopy_75(HandleRef pThis, HandleRef src);

		/// <summary>
		/// Shallow and Deep copy.
		/// </summary>
		// Token: 0x0601CE63 RID: 118371 RVA: 0x0028B4F4 File Offset: 0x002896F4
		public override void ShallowCopy(vtkDataObject src)
		{
			vtkRectilinearGrid.vtkRectilinearGrid_ShallowCopy_75(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E77 RID: 7799
		public new const string MRFullTypeName = "Kitware.VTK.vtkRectilinearGrid";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E78 RID: 7800
		public new static readonly string MRClassNameKey = "class vtkRectilinearGrid";
	}
}
