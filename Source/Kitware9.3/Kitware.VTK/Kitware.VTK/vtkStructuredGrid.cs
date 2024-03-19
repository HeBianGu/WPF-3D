using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkStructuredGrid
	/// </summary>
	/// <remarks>
	///    topologically regular array of data
	///
	/// vtkStructuredGrid is a data object that is a concrete implementation of
	/// vtkDataSet. vtkStructuredGrid represents a geometric structure that is a
	/// topologically regular array of points. The topology is that of a cube that
	/// has been subdivided into a regular array of smaller cubes. Each point/cell
	/// can be addressed with i-j-k indices. Examples include finite difference
	/// grids.
	///
	/// The order and number of points must match that specified by the dimensions
	/// of the grid. The point order increases in i fastest (from 0&lt;=i&lt;dims[0]),
	/// then j (0&lt;=j&lt;dims[1]), then k (0&lt;=k&lt;dims[2]) where dims[] are the
	/// dimensions of the grid in the i-j-k topological directions. The number of
	/// points is dims[0]*dims[1]*dims[2]. The same is true for the cells of the
	/// grid. The order and number of cells must match that specified by the
	/// dimensions of the grid. The cell order increases in i fastest (from
	/// 0&lt;=i&lt;(dims[0]-1)), then j (0&lt;=j&lt;(dims[1]-1)), then k (0&lt;=k&lt;(dims[2]-1))
	/// The number of cells is (dims[0]-1)*(dims[1]-1)*(dims[2]-1).
	///
	/// vtkStructuredGrid has the ability to blank,
	/// or "turn-off" points and cells in the dataset. This is done by setting
	/// vtkDataSetAttributes::HIDDENPOINT or vtkDataSetAttributes::HIDDENCELL
	/// in the ghost array for each point / cell that needs to be blanked.
	/// </remarks>
	// Token: 0x02000ACE RID: 2766
	public class vtkStructuredGrid : vtkPointSet
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D1C1 RID: 119233 RVA: 0x00290945 File Offset: 0x0028EB45
		static vtkStructuredGrid()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStructuredGrid.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStructuredGrid"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D1C2 RID: 119234 RVA: 0x0029096D File Offset: 0x0028EB6D
		public vtkStructuredGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601D1C3 RID: 119235
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D1C4 RID: 119236 RVA: 0x0029097C File Offset: 0x0028EB7C
		public new static vtkStructuredGrid New()
		{
			vtkStructuredGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredGrid.vtkStructuredGrid_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D1C5 RID: 119237 RVA: 0x002909D0 File Offset: 0x0028EBD0
		public vtkStructuredGrid() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkStructuredGrid.vtkStructuredGrid_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D1C6 RID: 119238 RVA: 0x00290A14 File Offset: 0x0028EC14
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D1C7 RID: 119239
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGrid_BlankCell_01(HandleRef pThis, long ptId);

		/// <summary>
		/// Methods for supporting blanking of cells. Blanking turns on or off
		/// cells in the structured grid, and hence the points connected to them.
		/// These methods should be called only after the dimensions of the
		/// grid are set.
		/// </summary>
		// Token: 0x0601D1C8 RID: 119240 RVA: 0x00290A1F File Offset: 0x0028EC1F
		public void BlankCell(long ptId)
		{
			vtkStructuredGrid.vtkStructuredGrid_BlankCell_01(base.GetCppThis(), ptId);
		}

		// Token: 0x0601D1C9 RID: 119241
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGrid_BlankPoint_02(HandleRef pThis, long ptId);

		/// <summary>
		/// Methods for supporting blanking of cells. Blanking turns on or off
		/// points in the structured grid, and hence the cells connected to them.
		/// These methods should be called only after the dimensions of the
		/// grid are set.
		/// </summary>
		// Token: 0x0601D1CA RID: 119242 RVA: 0x00290A2F File Offset: 0x0028EC2F
		public void BlankPoint(long ptId)
		{
			vtkStructuredGrid.vtkStructuredGrid_BlankPoint_02(base.GetCppThis(), ptId);
		}

		// Token: 0x0601D1CB RID: 119243
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGrid_CopyStructure_03(HandleRef pThis, HandleRef ds);

		/// <summary>
		/// Copy the geometric and topological structure of an input poly data object.
		/// </summary>
		// Token: 0x0601D1CC RID: 119244 RVA: 0x00290A40 File Offset: 0x0028EC40
		public override void CopyStructure(vtkDataSet ds)
		{
			vtkStructuredGrid.vtkStructuredGrid_CopyStructure_03(base.GetCppThis(), (ds == null) ? default(HandleRef) : ds.GetCppThis());
		}

		// Token: 0x0601D1CD RID: 119245
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGrid_Crop_04(HandleRef pThis, IntPtr updateExtent);

		/// <summary>
		/// Reallocates and copies to set the Extent to the UpdateExtent.
		/// This is used internally when the exact extent is requested,
		/// and the source generated more than the update extent.
		/// </summary>
		// Token: 0x0601D1CE RID: 119246 RVA: 0x00290A6F File Offset: 0x0028EC6F
		public override void Crop(IntPtr updateExtent)
		{
			vtkStructuredGrid.vtkStructuredGrid_Crop_04(base.GetCppThis(), updateExtent);
		}

		// Token: 0x0601D1CF RID: 119247
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGrid_DeepCopy_05(HandleRef pThis, HandleRef src);

		/// <summary>
		/// Shallow and Deep copy.
		/// </summary>
		// Token: 0x0601D1D0 RID: 119248 RVA: 0x00290A80 File Offset: 0x0028EC80
		public override void DeepCopy(vtkDataObject src)
		{
			vtkStructuredGrid.vtkStructuredGrid_DeepCopy_05(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		// Token: 0x0601D1D1 RID: 119249
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredGrid_ExtendedNew_06(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D1D2 RID: 119250 RVA: 0x00290AB0 File Offset: 0x0028ECB0
		public new static vtkStructuredGrid ExtendedNew()
		{
			vtkStructuredGrid vtkStructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredGrid.vtkStructuredGrid_ExtendedNew_06(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredGrid = (vtkStructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredGrid.Register(null);
				}
			}
			return vtkStructuredGrid;
		}

		// Token: 0x0601D1D3 RID: 119251
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkStructuredGrid_GetActualMemorySize_07(HandleRef pThis);

		/// <summary>
		/// Return the actual size of the data in kibibytes (1024 bytes). This number
		/// is valid only after the pipeline has updated. The memory size
		/// returned is guaranteed to be greater than or equal to the
		/// memory required to represent the data (e.g., extra space in
		/// arrays, etc. are not included in the return value). THIS METHOD
		/// IS THREAD SAFE.
		/// </summary>
		// Token: 0x0601D1D4 RID: 119252 RVA: 0x00290B1C File Offset: 0x0028ED1C
		public override uint GetActualMemorySize()
		{
			return vtkStructuredGrid.vtkStructuredGrid_GetActualMemorySize_07(base.GetCppThis());
		}

		// Token: 0x0601D1D5 RID: 119253
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredGrid_GetCell_08(HandleRef pThis, long cellId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601D1D6 RID: 119254 RVA: 0x00290B3C File Offset: 0x0028ED3C
		public override vtkCell GetCell(long cellId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredGrid.vtkStructuredGrid_GetCell_08(base.GetCppThis(), cellId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601D1D7 RID: 119255
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredGrid_GetCell_09(HandleRef pThis, int i, int j, int k, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601D1D8 RID: 119256 RVA: 0x00290BAC File Offset: 0x0028EDAC
		public override vtkCell GetCell(int i, int j, int k)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredGrid.vtkStructuredGrid_GetCell_09(base.GetCppThis(), i, j, k, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601D1D9 RID: 119257
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGrid_GetCell_10(HandleRef pThis, long cellId, HandleRef cell);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601D1DA RID: 119258 RVA: 0x00290C20 File Offset: 0x0028EE20
		public override void GetCell(long cellId, vtkGenericCell cell)
		{
			vtkStructuredGrid.vtkStructuredGrid_GetCell_10(base.GetCppThis(), cellId, (cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x0601D1DB RID: 119259
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGrid_GetCellBounds_11(HandleRef pThis, long cellId, IntPtr bounds);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601D1DC RID: 119260 RVA: 0x00290C50 File Offset: 0x0028EE50
		public override void GetCellBounds(long cellId, IntPtr bounds)
		{
			vtkStructuredGrid.vtkStructuredGrid_GetCellBounds_11(base.GetCppThis(), cellId, bounds);
		}

		// Token: 0x0601D1DD RID: 119261
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGrid_GetCellDims_12(HandleRef pThis, IntPtr cellDims);

		/// <summary>
		/// Given the node dimensions of this grid instance, this method computes the
		/// node dimensions. The value in each dimension can will have a lowest value
		/// of "1" such that computing the total number of cells can be achieved by
		/// simply by cellDims[0]*cellDims[1]*cellDims[2].
		/// </summary>
		// Token: 0x0601D1DE RID: 119262 RVA: 0x00290C61 File Offset: 0x0028EE61
		public void GetCellDims(IntPtr cellDims)
		{
			vtkStructuredGrid.vtkStructuredGrid_GetCellDims_12(base.GetCppThis(), cellDims);
		}

		// Token: 0x0601D1DF RID: 119263
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGrid_GetCellNeighbors_13(HandleRef pThis, long cellId, HandleRef ptIds, HandleRef cellIds);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601D1E0 RID: 119264 RVA: 0x00290C74 File Offset: 0x0028EE74
		public override void GetCellNeighbors(long cellId, vtkIdList ptIds, vtkIdList cellIds)
		{
			vtkStructuredGrid.vtkStructuredGrid_GetCellNeighbors_13(base.GetCppThis(), cellId, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis(), (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis());
		}

		// Token: 0x0601D1E1 RID: 119265
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGrid_GetCellNeighbors_14(HandleRef pThis, long cellId, HandleRef ptIds, HandleRef cellIds, IntPtr seedLoc);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601D1E2 RID: 119266 RVA: 0x00290CBC File Offset: 0x0028EEBC
		public void GetCellNeighbors(long cellId, vtkIdList ptIds, vtkIdList cellIds, IntPtr seedLoc)
		{
			vtkStructuredGrid.vtkStructuredGrid_GetCellNeighbors_14(base.GetCppThis(), cellId, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis(), (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis(), seedLoc);
		}

		// Token: 0x0601D1E3 RID: 119267
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGrid_GetCellPoints_15(HandleRef pThis, long cellId, HandleRef ptIds);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601D1E4 RID: 119268 RVA: 0x00290D04 File Offset: 0x0028EF04
		public override void GetCellPoints(long cellId, vtkIdList ptIds)
		{
			vtkStructuredGrid.vtkStructuredGrid_GetCellPoints_15(base.GetCppThis(), cellId, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		// Token: 0x0601D1E5 RID: 119269
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStructuredGrid_GetCellSize_16(HandleRef pThis, long cellId);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601D1E6 RID: 119270 RVA: 0x00290D34 File Offset: 0x0028EF34
		public override long GetCellSize(long cellId)
		{
			return vtkStructuredGrid.vtkStructuredGrid_GetCellSize_16(base.GetCppThis(), cellId);
		}

		// Token: 0x0601D1E7 RID: 119271
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredGrid_GetCellType_17(HandleRef pThis, long cellId);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601D1E8 RID: 119272 RVA: 0x00290D54 File Offset: 0x0028EF54
		public override int GetCellType(long cellId)
		{
			return vtkStructuredGrid.vtkStructuredGrid_GetCellType_17(base.GetCppThis(), cellId);
		}

		// Token: 0x0601D1E9 RID: 119273
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredGrid_GetData_18(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x0601D1EA RID: 119274 RVA: 0x00290D74 File Offset: 0x0028EF74
		public new static vtkStructuredGrid GetData(vtkInformation info)
		{
			vtkStructuredGrid vtkStructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredGrid.vtkStructuredGrid_GetData_18((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredGrid = (vtkStructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredGrid.Register(null);
				}
			}
			return vtkStructuredGrid;
		}

		// Token: 0x0601D1EB RID: 119275
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredGrid_GetData_19(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x0601D1EC RID: 119276 RVA: 0x00290DF4 File Offset: 0x0028EFF4
		public new static vtkStructuredGrid GetData(vtkInformationVector v, int i)
		{
			vtkStructuredGrid vtkStructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredGrid.vtkStructuredGrid_GetData_19((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredGrid = (vtkStructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredGrid.Register(null);
				}
			}
			return vtkStructuredGrid;
		}

		// Token: 0x0601D1ED RID: 119277
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredGrid_GetDataDimension_20(HandleRef pThis);

		/// <summary>
		/// Return the dimensionality of the data.
		/// </summary>
		// Token: 0x0601D1EE RID: 119278 RVA: 0x00290E74 File Offset: 0x0028F074
		public int GetDataDimension()
		{
			return vtkStructuredGrid.vtkStructuredGrid_GetDataDimension_20(base.GetCppThis());
		}

		// Token: 0x0601D1EF RID: 119279
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredGrid_GetDataObjectType_21(HandleRef pThis);

		/// <summary>
		/// Return what type of dataset this is.
		/// </summary>
		// Token: 0x0601D1F0 RID: 119280 RVA: 0x00290E94 File Offset: 0x0028F094
		public override int GetDataObjectType()
		{
			return vtkStructuredGrid.vtkStructuredGrid_GetDataObjectType_21(base.GetCppThis());
		}

		// Token: 0x0601D1F1 RID: 119281
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGrid_GetDimensions_22(HandleRef pThis, IntPtr dims);

		/// <summary>
		/// Get dimensions of this structured grid based on its extent.
		/// </summary>
		// Token: 0x0601D1F2 RID: 119282 RVA: 0x00290EB3 File Offset: 0x0028F0B3
		public virtual void GetDimensions(IntPtr dims)
		{
			vtkStructuredGrid.vtkStructuredGrid_GetDimensions_22(base.GetCppThis(), dims);
		}

		// Token: 0x0601D1F3 RID: 119283
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredGrid_GetExtent_23(HandleRef pThis);

		/// <summary>
		/// Different ways to set the extent of the data array.  The extent
		/// should be set before the "Scalars" are set or allocated.
		/// The Extent is stored in the order (X, Y, Z).
		/// </summary>
		// Token: 0x0601D1F4 RID: 119284 RVA: 0x00290EC4 File Offset: 0x0028F0C4
		public virtual int[] GetExtent()
		{
			IntPtr intPtr = vtkStructuredGrid.vtkStructuredGrid_GetExtent_23(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601D1F5 RID: 119285
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGrid_GetExtent_24(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		/// <summary>
		/// Different ways to set the extent of the data array.  The extent
		/// should be set before the "Scalars" are set or allocated.
		/// The Extent is stored in the order (X, Y, Z).
		/// </summary>
		// Token: 0x0601D1F6 RID: 119286 RVA: 0x00290F0C File Offset: 0x0028F10C
		public virtual void GetExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkStructuredGrid.vtkStructuredGrid_GetExtent_24(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		// Token: 0x0601D1F7 RID: 119287
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGrid_GetExtent_25(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Different ways to set the extent of the data array.  The extent
		/// should be set before the "Scalars" are set or allocated.
		/// The Extent is stored in the order (X, Y, Z).
		/// </summary>
		// Token: 0x0601D1F8 RID: 119288 RVA: 0x00290F24 File Offset: 0x0028F124
		public virtual void GetExtent(IntPtr _arg)
		{
			vtkStructuredGrid.vtkStructuredGrid_GetExtent_25(base.GetCppThis(), _arg);
		}

		// Token: 0x0601D1F9 RID: 119289
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredGrid_GetExtentType_26(HandleRef pThis);

		/// <summary>
		/// The extent type is a 3D extent
		/// </summary>
		// Token: 0x0601D1FA RID: 119290 RVA: 0x00290F34 File Offset: 0x0028F134
		public override int GetExtentType()
		{
			return vtkStructuredGrid.vtkStructuredGrid_GetExtentType_26(base.GetCppThis());
		}

		// Token: 0x0601D1FB RID: 119291
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredGrid_GetMaxCellSize_27(HandleRef pThis);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601D1FC RID: 119292 RVA: 0x00290F54 File Offset: 0x0028F154
		public override int GetMaxCellSize()
		{
			return vtkStructuredGrid.vtkStructuredGrid_GetMaxCellSize_27(base.GetCppThis());
		}

		// Token: 0x0601D1FD RID: 119293
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredGrid_GetMaxSpatialDimension_28(HandleRef pThis);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601D1FE RID: 119294 RVA: 0x00290F74 File Offset: 0x0028F174
		public override int GetMaxSpatialDimension()
		{
			return vtkStructuredGrid.vtkStructuredGrid_GetMaxSpatialDimension_28(base.GetCppThis());
		}

		// Token: 0x0601D1FF RID: 119295
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStructuredGrid_GetNumberOfCells_29(HandleRef pThis);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601D200 RID: 119296 RVA: 0x00290F94 File Offset: 0x0028F194
		public override long GetNumberOfCells()
		{
			return vtkStructuredGrid.vtkStructuredGrid_GetNumberOfCells_29(base.GetCppThis());
		}

		// Token: 0x0601D201 RID: 119297
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStructuredGrid_GetNumberOfGenerationsFromBase_30(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D202 RID: 119298 RVA: 0x00290FB4 File Offset: 0x0028F1B4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkStructuredGrid.vtkStructuredGrid_GetNumberOfGenerationsFromBase_30(base.GetCppThis(), type);
		}

		// Token: 0x0601D203 RID: 119299
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStructuredGrid_GetNumberOfGenerationsFromBaseType_31([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D204 RID: 119300 RVA: 0x00290FD4 File Offset: 0x0028F1D4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkStructuredGrid.vtkStructuredGrid_GetNumberOfGenerationsFromBaseType_31(type);
		}

		// Token: 0x0601D205 RID: 119301
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStructuredGrid_GetNumberOfPoints_32(HandleRef pThis);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601D206 RID: 119302 RVA: 0x00290FF0 File Offset: 0x0028F1F0
		public override long GetNumberOfPoints()
		{
			return vtkStructuredGrid.vtkStructuredGrid_GetNumberOfPoints_32(base.GetCppThis());
		}

		// Token: 0x0601D207 RID: 119303
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredGrid_GetPoint_33(HandleRef pThis, long ptId);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601D208 RID: 119304 RVA: 0x00291010 File Offset: 0x0028F210
		public override double[] GetPoint(long ptId)
		{
			IntPtr intPtr = vtkStructuredGrid.vtkStructuredGrid_GetPoint_33(base.GetCppThis(), ptId);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601D209 RID: 119305
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGrid_GetPoint_34(HandleRef pThis, long ptId, IntPtr p);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601D20A RID: 119306 RVA: 0x00291059 File Offset: 0x0028F259
		public override void GetPoint(long ptId, IntPtr p)
		{
			vtkStructuredGrid.vtkStructuredGrid_GetPoint_34(base.GetCppThis(), ptId, p);
		}

		// Token: 0x0601D20B RID: 119307
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGrid_GetPoint_35(HandleRef pThis, int i, int j, int k, IntPtr p, byte adjustForExtent);

		/// <summary>
		/// Get a point in the grid. If adjustForExtent is true, (i,j,k) is
		/// interpreted as a position relative to the beginning of the extent.
		/// If adjustForExtent is false, (i,j,k) is interpreted literally
		/// and the (i,j,k) point of the grid is returned regardless of the
		/// extent beginning.
		/// The point coordinate is returned in 'p'.
		/// The default adjustForExtent is true.
		/// </summary>
		// Token: 0x0601D20C RID: 119308 RVA: 0x0029106A File Offset: 0x0028F26A
		public void GetPoint(int i, int j, int k, IntPtr p, bool adjustForExtent)
		{
			vtkStructuredGrid.vtkStructuredGrid_GetPoint_35(base.GetCppThis(), i, j, k, p, adjustForExtent ? (byte)1 : (byte)0);
		}

		// Token: 0x0601D20D RID: 119309
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGrid_GetPointCells_36(HandleRef pThis, long ptId, HandleRef cellIds);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601D20E RID: 119310 RVA: 0x00291088 File Offset: 0x0028F288
		public override void GetPointCells(long ptId, vtkIdList cellIds)
		{
			vtkStructuredGrid.vtkStructuredGrid_GetPointCells_36(base.GetCppThis(), ptId, (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis());
		}

		// Token: 0x0601D20F RID: 119311
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStructuredGrid_HasAnyBlankCells_37(HandleRef pThis);

		/// <summary>
		/// Returns 1 if there is any visibility constraint on the cells,
		/// 0 otherwise.
		/// </summary>
		// Token: 0x0601D210 RID: 119312 RVA: 0x002910B8 File Offset: 0x0028F2B8
		public override bool HasAnyBlankCells()
		{
			return vtkStructuredGrid.vtkStructuredGrid_HasAnyBlankCells_37(base.GetCppThis()) != 0;
		}

		// Token: 0x0601D211 RID: 119313
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStructuredGrid_HasAnyBlankPoints_38(HandleRef pThis);

		/// <summary>
		/// Returns 1 if there is any visibility constraint on the points,
		/// 0 otherwise.
		/// </summary>
		// Token: 0x0601D212 RID: 119314 RVA: 0x002910E0 File Offset: 0x0028F2E0
		public override bool HasAnyBlankPoints()
		{
			return vtkStructuredGrid.vtkStructuredGrid_HasAnyBlankPoints_38(base.GetCppThis()) != 0;
		}

		// Token: 0x0601D213 RID: 119315
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGrid_Initialize_39(HandleRef pThis);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601D214 RID: 119316 RVA: 0x00291106 File Offset: 0x0028F306
		public override void Initialize()
		{
			vtkStructuredGrid.vtkStructuredGrid_Initialize_39(base.GetCppThis());
		}

		// Token: 0x0601D215 RID: 119317
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredGrid_IsA_40(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D216 RID: 119318 RVA: 0x00291118 File Offset: 0x0028F318
		public override int IsA(string type)
		{
			return vtkStructuredGrid.vtkStructuredGrid_IsA_40(base.GetCppThis(), type);
		}

		// Token: 0x0601D217 RID: 119319
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStructuredGrid_IsCellVisible_41(HandleRef pThis, long cellId);

		/// <summary>
		/// Return non-zero value if specified point is visible.
		/// These methods should be called only after the dimensions of the
		/// grid are set.
		/// </summary>
		// Token: 0x0601D218 RID: 119320 RVA: 0x00291138 File Offset: 0x0028F338
		public byte IsCellVisible(long cellId)
		{
			return vtkStructuredGrid.vtkStructuredGrid_IsCellVisible_41(base.GetCppThis(), cellId);
		}

		// Token: 0x0601D219 RID: 119321
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStructuredGrid_IsPointVisible_42(HandleRef pThis, long ptId);

		/// <summary>
		/// Return non-zero value if specified point is visible.
		/// These methods should be called only after the dimensions of the
		/// grid are set.
		/// </summary>
		// Token: 0x0601D21A RID: 119322 RVA: 0x00291158 File Offset: 0x0028F358
		public byte IsPointVisible(long ptId)
		{
			return vtkStructuredGrid.vtkStructuredGrid_IsPointVisible_42(base.GetCppThis(), ptId);
		}

		// Token: 0x0601D21B RID: 119323
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredGrid_IsTypeOf_43([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D21C RID: 119324 RVA: 0x00291178 File Offset: 0x0028F378
		public new static int IsTypeOf(string type)
		{
			return vtkStructuredGrid.vtkStructuredGrid_IsTypeOf_43(type);
		}

		// Token: 0x0601D21D RID: 119325
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredGrid_NewInstance_45(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D21E RID: 119326 RVA: 0x00291194 File Offset: 0x0028F394
		public new vtkStructuredGrid NewInstance()
		{
			vtkStructuredGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredGrid.vtkStructuredGrid_NewInstance_45(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601D21F RID: 119327
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredGrid_SafeDownCast_46(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D220 RID: 119328 RVA: 0x002911F0 File Offset: 0x0028F3F0
		public new static vtkStructuredGrid SafeDownCast(vtkObjectBase o)
		{
			vtkStructuredGrid vtkStructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredGrid.vtkStructuredGrid_SafeDownCast_46((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredGrid = (vtkStructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredGrid.Register(null);
				}
			}
			return vtkStructuredGrid;
		}

		// Token: 0x0601D221 RID: 119329
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGrid_SetDimensions_47(HandleRef pThis, int i, int j, int k);

		/// <summary>
		/// Sets the extent to be 0 to i-1, 0 to j-1, and 0 to k-1.
		/// </summary>
		// Token: 0x0601D222 RID: 119330 RVA: 0x0029126F File Offset: 0x0028F46F
		public void SetDimensions(int i, int j, int k)
		{
			vtkStructuredGrid.vtkStructuredGrid_SetDimensions_47(base.GetCppThis(), i, j, k);
		}

		// Token: 0x0601D223 RID: 119331
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGrid_SetDimensions_48(HandleRef pThis, IntPtr dims);

		/// <summary>
		/// Sets the extent to be 0 to dim[i]-1 in all 3 dimensions.
		/// </summary>
		// Token: 0x0601D224 RID: 119332 RVA: 0x00291281 File Offset: 0x0028F481
		public void SetDimensions(IntPtr dims)
		{
			vtkStructuredGrid.vtkStructuredGrid_SetDimensions_48(base.GetCppThis(), dims);
		}

		// Token: 0x0601D225 RID: 119333
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGrid_SetExtent_49(HandleRef pThis, IntPtr extent);

		/// <summary>
		/// Different ways to set the extent of the data array.  The extent
		/// should be set before the "Scalars" are set or allocated.
		/// The Extent is stored in the order (X, Y, Z).
		/// </summary>
		// Token: 0x0601D226 RID: 119334 RVA: 0x00291291 File Offset: 0x0028F491
		public void SetExtent(IntPtr extent)
		{
			vtkStructuredGrid.vtkStructuredGrid_SetExtent_49(base.GetCppThis(), extent);
		}

		// Token: 0x0601D227 RID: 119335
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGrid_SetExtent_50(HandleRef pThis, int xMin, int xMax, int yMin, int yMax, int zMin, int zMax);

		/// <summary>
		/// Different ways to set the extent of the data array.  The extent
		/// should be set before the "Scalars" are set or allocated.
		/// The Extent is stored in the order (X, Y, Z).
		/// </summary>
		// Token: 0x0601D228 RID: 119336 RVA: 0x002912A1 File Offset: 0x0028F4A1
		public void SetExtent(int xMin, int xMax, int yMin, int yMax, int zMin, int zMax)
		{
			vtkStructuredGrid.vtkStructuredGrid_SetExtent_50(base.GetCppThis(), xMin, xMax, yMin, yMax, zMin, zMax);
		}

		// Token: 0x0601D229 RID: 119337
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGrid_ShallowCopy_51(HandleRef pThis, HandleRef src);

		/// <summary>
		/// Shallow and Deep copy.
		/// </summary>
		// Token: 0x0601D22A RID: 119338 RVA: 0x002912BC File Offset: 0x0028F4BC
		public override void ShallowCopy(vtkDataObject src)
		{
			vtkStructuredGrid.vtkStructuredGrid_ShallowCopy_51(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		// Token: 0x0601D22B RID: 119339
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGrid_UnBlankCell_52(HandleRef pThis, long ptId);

		/// <summary>
		/// Methods for supporting blanking of cells. Blanking turns on or off
		/// cells in the structured grid, and hence the points connected to them.
		/// These methods should be called only after the dimensions of the
		/// grid are set.
		/// </summary>
		// Token: 0x0601D22C RID: 119340 RVA: 0x002912EB File Offset: 0x0028F4EB
		public void UnBlankCell(long ptId)
		{
			vtkStructuredGrid.vtkStructuredGrid_UnBlankCell_52(base.GetCppThis(), ptId);
		}

		// Token: 0x0601D22D RID: 119341
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGrid_UnBlankPoint_53(HandleRef pThis, long ptId);

		/// <summary>
		/// Methods for supporting blanking of cells. Blanking turns on or off
		/// points in the structured grid, and hence the cells connected to them.
		/// These methods should be called only after the dimensions of the
		/// grid are set.
		/// </summary>
		// Token: 0x0601D22E RID: 119342 RVA: 0x002912FB File Offset: 0x0028F4FB
		public void UnBlankPoint(long ptId)
		{
			vtkStructuredGrid.vtkStructuredGrid_UnBlankPoint_53(base.GetCppThis(), ptId);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EC2 RID: 7874
		public new const string MRFullTypeName = "Kitware.VTK.vtkStructuredGrid";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EC3 RID: 7875
		public new static readonly string MRClassNameKey = "class vtkStructuredGrid";
	}
}
