using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExplicitStructuredGrid
	/// </summary>
	/// <remarks>
	///    structured grid with explicit topology and geometry
	///
	/// vtkExplicitStructuredGrid is a data object that is a concrete implementation
	/// of vtkDataSet. vtkExplicitStructuredGrid represents a geometric structure
	/// that is a topologically regular array of hexahedron. The topology is that of
	/// a cube that has been subdivided into a regular array of smaller cubes.
	/// Each cell can be addressed with i-j-k indices, however neighbor hexahedrons
	/// does not necessarily share a face and hexahedron can be blanked (turned-off).
	///
	/// Like unstructured grid, vtkExplicitStructuredGrid has explicit point coordinates
	/// and cell to point indexing.
	/// Unlike unstructured grid, vtkExplicitStructuredGrid does not keep a cell type
	/// list as all visible cells are known to be hexahedra.
	/// vtkExplicitStructuredGrid can take advantage of its layout to perform operations
	/// based on the i, j, k parameters, similar to structured grid. This makes some
	/// operations faster on this class, without losing the flexibility of the
	/// cell -&gt; points mapping.
	/// The most common use of this class would be in situations where you have all
	/// hexahedra but the points used by the cells are not exactly defined by the
	/// i, j, k parameters. One example of this is a structured grid with a half voxel
	/// shift occurring in the middle of it such as with a geologic fault.
	///
	/// The order and number of points is arbitrary.
	/// The order and number of cells must match that specified by the dimensions
	/// of the grid minus 1, because in vtk structured datasets the dimensions
	/// correspond to the points.
	/// The cells order increases in i fastest (from 0 &lt;= i &lt;= dims[0] - 2),
	/// then j (0 &lt;= j &lt;= dims[1] - 2), then k ( 0 &lt;= k &lt;= dims[2] - 2) where dims[]
	/// are the dimensions of the grid in the i-j-k topological directions.
	/// The number of cells is (dims[0] - 1) * (dims[1] - 1) * (dims[2] - 1).
	///
	/// In order for an ESG to be usable by most other ESG specific filters,
	/// it is needed to call the ComputeFacesConnectivityFlagsArray method.
	/// It is also recommended to call CheckAndReorderFaces method to fix any
	/// faces issues in the dataset.
	/// </remarks>
	// Token: 0x02000A47 RID: 2631
	public class vtkExplicitStructuredGrid : vtkPointSet
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601B674 RID: 112244 RVA: 0x0026581D File Offset: 0x00263A1D
		static vtkExplicitStructuredGrid()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExplicitStructuredGrid.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExplicitStructuredGrid"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601B675 RID: 112245 RVA: 0x00265845 File Offset: 0x00263A45
		public vtkExplicitStructuredGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601B676 RID: 112246
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExplicitStructuredGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601B677 RID: 112247 RVA: 0x00265854 File Offset: 0x00263A54
		public new static vtkExplicitStructuredGrid New()
		{
			vtkExplicitStructuredGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExplicitStructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601B678 RID: 112248 RVA: 0x002658A8 File Offset: 0x00263AA8
		public vtkExplicitStructuredGrid() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601B679 RID: 112249 RVA: 0x002658EC File Offset: 0x00263AEC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601B67A RID: 112250
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExplicitStructuredGrid_BlankCell_01(HandleRef pThis, long cellId);

		/// <summary>
		/// Methods for supporting blanking of cells. Blanking turns on or off
		/// cells in the structured grid.
		/// These methods should be called only after the dimensions of the
		/// grid are set.
		/// </summary>
		// Token: 0x0601B67B RID: 112251 RVA: 0x002658F7 File Offset: 0x00263AF7
		public void BlankCell(long cellId)
		{
			vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_BlankCell_01(base.GetCppThis(), cellId);
		}

		// Token: 0x0601B67C RID: 112252
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExplicitStructuredGrid_BuildLinks_02(HandleRef pThis);

		/// <summary>
		/// Build topological links from points to lists of cells that use each point.
		/// See vtkAbstractCellLinks for more information.
		/// </summary>
		// Token: 0x0601B67D RID: 112253 RVA: 0x00265907 File Offset: 0x00263B07
		public void BuildLinks()
		{
			vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_BuildLinks_02(base.GetCppThis());
		}

		// Token: 0x0601B67E RID: 112254
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExplicitStructuredGrid_CheckAndReorderFaces_03(HandleRef pThis);

		/// <summary>
		/// Check faces are numbered correctly regarding ijk numbering
		/// If not this will reorganize cell points order
		/// so face order is valid.
		/// This is made in two pass, first it check that faces are on
		/// the correct axis and corrects it
		/// Then it check if faces are mirrored and corrects it.
		/// Make sure cells and extent have been set before calling this method
		/// and recompute face connectivity afterwards.
		/// </summary>
		// Token: 0x0601B67F RID: 112255 RVA: 0x00265916 File Offset: 0x00263B16
		public void CheckAndReorderFaces()
		{
			vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_CheckAndReorderFaces_03(base.GetCppThis());
		}

		// Token: 0x0601B680 RID: 112256
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExplicitStructuredGrid_ComputeCellId_04(HandleRef pThis, int i, int j, int k, byte adjustForExtent);

		/// <summary>
		/// Given a location in structured coordinates (i-j-k), return the cell id.
		/// If adjustForExtent is true, (i,j,k) is interpreted as a position relative
		/// to the beginning of the extent.
		/// If adjustForExtent is false, (i,j,k) is interpreted literally
		/// and the cell id is returned regardless of the extent beginning.
		/// The default adjustForExtent is true.
		/// </summary>
		// Token: 0x0601B681 RID: 112257 RVA: 0x00265928 File Offset: 0x00263B28
		public long ComputeCellId(int i, int j, int k, bool adjustForExtent)
		{
			return vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_ComputeCellId_04(base.GetCppThis(), i, j, k, adjustForExtent ? (byte)1 : (byte)0);
		}

		// Token: 0x0601B682 RID: 112258
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExplicitStructuredGrid_ComputeCellStructuredCoords_05(HandleRef pThis, long cellId, ref int i, ref int j, ref int k, byte adjustForExtent);

		/// <summary>
		/// Given a cellId, get the structured coordinates (i-j-k).
		/// If adjustForExtent is true, (i,j,k) is computed as a position relative
		/// to the beginning of the extent.
		/// If adjustForExtent is false, (i,j,k) is computed regardless of the
		/// extent beginning.
		/// The default adjustForExtent is true.
		/// </summary>
		// Token: 0x0601B683 RID: 112259 RVA: 0x00265954 File Offset: 0x00263B54
		public void ComputeCellStructuredCoords(long cellId, ref int i, ref int j, ref int k, bool adjustForExtent)
		{
			vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_ComputeCellStructuredCoords_05(base.GetCppThis(), cellId, ref i, ref j, ref k, adjustForExtent ? (byte)1 : (byte)0);
		}

		// Token: 0x0601B684 RID: 112260
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExplicitStructuredGrid_ComputeFacesConnectivityFlagsArray_06(HandleRef pThis);

		/// <summary>
		/// Compute the faces connectivity flags array. This method should
		/// be called after the construction if the ESG is to be used by
		/// other filters.
		/// </summary>
		// Token: 0x0601B685 RID: 112261 RVA: 0x00265972 File Offset: 0x00263B72
		public void ComputeFacesConnectivityFlagsArray()
		{
			vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_ComputeFacesConnectivityFlagsArray_06(base.GetCppThis());
		}

		// Token: 0x0601B686 RID: 112262
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExplicitStructuredGrid_CopyStructure_07(HandleRef pThis, HandleRef ds);

		/// <summary>
		/// Copy the geometric and topological structure of an input poly data object.
		/// </summary>
		// Token: 0x0601B687 RID: 112263 RVA: 0x00265984 File Offset: 0x00263B84
		public override void CopyStructure(vtkDataSet ds)
		{
			vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_CopyStructure_07(base.GetCppThis(), (ds == null) ? default(HandleRef) : ds.GetCppThis());
		}

		// Token: 0x0601B688 RID: 112264
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExplicitStructuredGrid_Crop_08(HandleRef pThis, IntPtr updateExtent);

		/// <summary>
		/// Reallocates and copies to set the Extent to the UpdateExtent.
		/// This is used internally when the exact extent is requested,
		/// and the source generated more than the update extent.
		/// </summary>
		// Token: 0x0601B689 RID: 112265 RVA: 0x002659B3 File Offset: 0x00263BB3
		public override void Crop(IntPtr updateExtent)
		{
			vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_Crop_08(base.GetCppThis(), updateExtent);
		}

		// Token: 0x0601B68A RID: 112266
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExplicitStructuredGrid_Crop_09(HandleRef pThis, HandleRef input, IntPtr updateExtent, byte generateOriginalCellIds);

		/// <summary>
		/// Reallocates and copies to set the Extent to the UpdateExtent.
		/// This is used internally when the exact extent is requested,
		/// and the source generated more than the update extent.
		/// </summary>
		// Token: 0x0601B68B RID: 112267 RVA: 0x002659C4 File Offset: 0x00263BC4
		public virtual void Crop(vtkExplicitStructuredGrid input, IntPtr updateExtent, bool generateOriginalCellIds)
		{
			vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_Crop_09(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis(), updateExtent, generateOriginalCellIds ? (byte)1 : (byte)0);
		}

		// Token: 0x0601B68C RID: 112268
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExplicitStructuredGrid_DeepCopy_10(HandleRef pThis, HandleRef src);

		/// <summary>
		/// Shallow and Deep copy.
		/// </summary>
		// Token: 0x0601B68D RID: 112269 RVA: 0x00265A00 File Offset: 0x00263C00
		public override void DeepCopy(vtkDataObject src)
		{
			vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_DeepCopy_10(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		// Token: 0x0601B68E RID: 112270
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExplicitStructuredGrid_GenerateGhostArray_11(HandleRef pThis, IntPtr zeroExt, byte cellOnly);

		/// <summary>
		/// Normally called by pipeline executives or algorithms only. This method
		/// computes the ghost arrays for a given dataset. The zeroExt argument
		/// specifies the extent of the region which ghost type = 0.
		/// </summary>
		// Token: 0x0601B68F RID: 112271 RVA: 0x00265A2F File Offset: 0x00263C2F
		public override void GenerateGhostArray(IntPtr zeroExt, bool cellOnly)
		{
			vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_GenerateGhostArray_11(base.GetCppThis(), zeroExt, cellOnly ? (byte)1 : (byte)0);
		}

		// Token: 0x0601B690 RID: 112272
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkExplicitStructuredGrid_GetActualMemorySize_12(HandleRef pThis);

		/// <summary>
		/// Return the actual size of the data in kilobytes. This number
		/// is valid only after the pipeline has updated. The memory size
		/// returned is guaranteed to be greater than or equal to the
		/// memory required to represent the data (e.g., extra space in
		/// arrays, etc. are not included in the return value). THIS METHOD
		/// IS THREAD SAFE.
		/// </summary>
		// Token: 0x0601B691 RID: 112273 RVA: 0x00265A48 File Offset: 0x00263C48
		public override uint GetActualMemorySize()
		{
			return vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_GetActualMemorySize_12(base.GetCppThis());
		}

		// Token: 0x0601B692 RID: 112274
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExplicitStructuredGrid_GetCell_13(HandleRef pThis, long cellId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601B693 RID: 112275 RVA: 0x00265A68 File Offset: 0x00263C68
		public override vtkCell GetCell(long cellId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_GetCell_13(base.GetCppThis(), cellId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601B694 RID: 112276
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExplicitStructuredGrid_GetCell_14(HandleRef pThis, long cellId, HandleRef cell);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601B695 RID: 112277 RVA: 0x00265AD8 File Offset: 0x00263CD8
		public override void GetCell(long cellId, vtkGenericCell cell)
		{
			vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_GetCell_14(base.GetCppThis(), cellId, (cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x0601B696 RID: 112278
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExplicitStructuredGrid_GetCellBounds_15(HandleRef pThis, long cellId, IntPtr bounds);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601B697 RID: 112279 RVA: 0x00265B08 File Offset: 0x00263D08
		public override void GetCellBounds(long cellId, IntPtr bounds)
		{
			vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_GetCellBounds_15(base.GetCppThis(), cellId, bounds);
		}

		// Token: 0x0601B698 RID: 112280
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExplicitStructuredGrid_GetCellDims_16(HandleRef pThis, IntPtr cellDims);

		/// <summary>
		/// Computes the cell dimensions according to internal point dimensions.
		/// The total number of cells can be achieved simply by
		/// cellDims[0] * cellDims[1] * cellDims[2].
		/// </summary>
		// Token: 0x0601B699 RID: 112281 RVA: 0x00265B19 File Offset: 0x00263D19
		public void GetCellDims(IntPtr cellDims)
		{
			vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_GetCellDims_16(base.GetCppThis(), cellDims);
		}

		// Token: 0x0601B69A RID: 112282
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExplicitStructuredGrid_GetCellNeighbors_17(HandleRef pThis, long cellId, HandleRef ptIds, HandleRef cellIds);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601B69B RID: 112283 RVA: 0x00265B2C File Offset: 0x00263D2C
		public override void GetCellNeighbors(long cellId, vtkIdList ptIds, vtkIdList cellIds)
		{
			vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_GetCellNeighbors_17(base.GetCppThis(), cellId, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis(), (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis());
		}

		// Token: 0x0601B69C RID: 112284
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExplicitStructuredGrid_GetCellNeighbors_18(HandleRef pThis, long cellId, IntPtr neighbors, IntPtr wholeExtent);

		/// <summary>
		/// Get cell neighbors of the cell for every faces.
		/// </summary>
		// Token: 0x0601B69D RID: 112285 RVA: 0x00265B71 File Offset: 0x00263D71
		public void GetCellNeighbors(long cellId, IntPtr neighbors, IntPtr wholeExtent)
		{
			vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_GetCellNeighbors_18(base.GetCppThis(), cellId, neighbors, wholeExtent);
		}

		// Token: 0x0601B69E RID: 112286
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExplicitStructuredGrid_GetCellPoints_19(HandleRef pThis, long cellId, HandleRef ptIds);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601B69F RID: 112287 RVA: 0x00265B84 File Offset: 0x00263D84
		public override void GetCellPoints(long cellId, vtkIdList ptIds)
		{
			vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_GetCellPoints_19(base.GetCppThis(), cellId, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		// Token: 0x0601B6A0 RID: 112288
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExplicitStructuredGrid_GetCellPoints_20(HandleRef pThis, long cellId);

		/// <summary>
		/// Get direct raw pointer to the 8 points indices of an hexahedra.
		///
		/// Note: This method MAY NOT be thread-safe. (See GetCellAtId at vtkCellArray)
		/// </summary>
		// Token: 0x0601B6A1 RID: 112289 RVA: 0x00265BB4 File Offset: 0x00263DB4
		public IntPtr GetCellPoints(long cellId)
		{
			return vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_GetCellPoints_20(base.GetCppThis(), cellId);
		}

		// Token: 0x0601B6A2 RID: 112290
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExplicitStructuredGrid_GetCellSize_21(HandleRef pThis, long cellId);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601B6A3 RID: 112291 RVA: 0x00265BD4 File Offset: 0x00263DD4
		public override long GetCellSize(long cellId)
		{
			return vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_GetCellSize_21(base.GetCppThis(), cellId);
		}

		// Token: 0x0601B6A4 RID: 112292
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExplicitStructuredGrid_GetCellType_22(HandleRef pThis, long cellId);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601B6A5 RID: 112293 RVA: 0x00265BF4 File Offset: 0x00263DF4
		public override int GetCellType(long cellId)
		{
			return vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_GetCellType_22(base.GetCppThis(), cellId);
		}

		// Token: 0x0601B6A6 RID: 112294
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExplicitStructuredGrid_GetCells_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the cell array defining hexahedron.
		/// </summary>
		// Token: 0x0601B6A7 RID: 112295 RVA: 0x00265C14 File Offset: 0x00263E14
		public virtual vtkCellArray GetCells()
		{
			vtkCellArray vtkCellArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_GetCells_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellArray = (vtkCellArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellArray.Register(null);
				}
			}
			return vtkCellArray;
		}

		// Token: 0x0601B6A8 RID: 112296
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExplicitStructuredGrid_GetData_24(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x0601B6A9 RID: 112297 RVA: 0x00265C84 File Offset: 0x00263E84
		public new static vtkExplicitStructuredGrid GetData(vtkInformation info)
		{
			vtkExplicitStructuredGrid vtkExplicitStructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_GetData_24((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExplicitStructuredGrid = (vtkExplicitStructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExplicitStructuredGrid.Register(null);
				}
			}
			return vtkExplicitStructuredGrid;
		}

		// Token: 0x0601B6AA RID: 112298
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExplicitStructuredGrid_GetData_25(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x0601B6AB RID: 112299 RVA: 0x00265D04 File Offset: 0x00263F04
		public new static vtkExplicitStructuredGrid GetData(vtkInformationVector v, int i)
		{
			vtkExplicitStructuredGrid vtkExplicitStructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_GetData_25((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExplicitStructuredGrid = (vtkExplicitStructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExplicitStructuredGrid.Register(null);
				}
			}
			return vtkExplicitStructuredGrid;
		}

		// Token: 0x0601B6AC RID: 112300
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExplicitStructuredGrid_GetDataDimension_26(HandleRef pThis);

		/// <summary>
		/// Return the dimensionality of the data.
		/// </summary>
		// Token: 0x0601B6AD RID: 112301 RVA: 0x00265D84 File Offset: 0x00263F84
		public int GetDataDimension()
		{
			return vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_GetDataDimension_26(base.GetCppThis());
		}

		// Token: 0x0601B6AE RID: 112302
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExplicitStructuredGrid_GetDataObjectType_27(HandleRef pThis);

		/// <summary>
		/// Return what type of dataset this is.
		/// </summary>
		// Token: 0x0601B6AF RID: 112303 RVA: 0x00265DA4 File Offset: 0x00263FA4
		public override int GetDataObjectType()
		{
			return vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_GetDataObjectType_27(base.GetCppThis());
		}

		// Token: 0x0601B6B0 RID: 112304
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExplicitStructuredGrid_GetDimensions_28(HandleRef pThis, IntPtr dim);

		/// <summary>
		/// Set/Get the dimensions of this structured dataset in term of number
		/// of points along each direction.
		/// This is just a convenience method which calls Set/GetExtent internally.
		/// </summary>
		// Token: 0x0601B6B1 RID: 112305 RVA: 0x00265DC3 File Offset: 0x00263FC3
		public void GetDimensions(IntPtr dim)
		{
			vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_GetDimensions_28(base.GetCppThis(), dim);
		}

		// Token: 0x0601B6B2 RID: 112306
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExplicitStructuredGrid_GetExtent_29(HandleRef pThis);

		/// <summary>
		/// Set/Get the extent of this structured dataset in term of number
		/// of points along each direction.
		/// Setting the extent will reset the internal CellArray and Links
		/// and a correctly sized cell array will be created.
		/// The Extent is stored  in the order (X, Y, Z).
		/// </summary>
		// Token: 0x0601B6B3 RID: 112307 RVA: 0x00265DD4 File Offset: 0x00263FD4
		public virtual int[] GetExtent()
		{
			IntPtr intPtr = vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_GetExtent_29(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601B6B4 RID: 112308
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExplicitStructuredGrid_GetExtent_30(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		/// <summary>
		/// Set/Get the extent of this structured dataset in term of number
		/// of points along each direction.
		/// Setting the extent will reset the internal CellArray and Links
		/// and a correctly sized cell array will be created.
		/// The Extent is stored  in the order (X, Y, Z).
		/// </summary>
		// Token: 0x0601B6B5 RID: 112309 RVA: 0x00265E1C File Offset: 0x0026401C
		public virtual void GetExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_GetExtent_30(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		// Token: 0x0601B6B6 RID: 112310
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExplicitStructuredGrid_GetExtent_31(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the extent of this structured dataset in term of number
		/// of points along each direction.
		/// Setting the extent will reset the internal CellArray and Links
		/// and a correctly sized cell array will be created.
		/// The Extent is stored  in the order (X, Y, Z).
		/// </summary>
		// Token: 0x0601B6B7 RID: 112311 RVA: 0x00265E34 File Offset: 0x00264034
		public virtual void GetExtent(IntPtr _arg)
		{
			vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_GetExtent_31(base.GetCppThis(), _arg);
		}

		// Token: 0x0601B6B8 RID: 112312
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExplicitStructuredGrid_GetExtentType_32(HandleRef pThis);

		/// <summary>
		/// The extent type is a 3D extent
		/// </summary>
		// Token: 0x0601B6B9 RID: 112313 RVA: 0x00265E44 File Offset: 0x00264044
		public override int GetExtentType()
		{
			return vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_GetExtentType_32(base.GetCppThis());
		}

		// Token: 0x0601B6BA RID: 112314
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExplicitStructuredGrid_GetFacesConnectivityFlagsArrayName_33(HandleRef pThis);

		/// <summary>
		/// Set/Get the name of the faces connectivity flags array.
		/// </summary>
		// Token: 0x0601B6BB RID: 112315 RVA: 0x00265E64 File Offset: 0x00264064
		public virtual string GetFacesConnectivityFlagsArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_GetFacesConnectivityFlagsArrayName_33(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601B6BC RID: 112316
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExplicitStructuredGrid_GetLinks_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the links that you created possibly without using BuildLinks.
		/// </summary>
		// Token: 0x0601B6BD RID: 112317 RVA: 0x00265EA0 File Offset: 0x002640A0
		public virtual vtkAbstractCellLinks GetLinks()
		{
			vtkAbstractCellLinks vtkAbstractCellLinks = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_GetLinks_34(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractCellLinks = (vtkAbstractCellLinks)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractCellLinks.Register(null);
				}
			}
			return vtkAbstractCellLinks;
		}

		// Token: 0x0601B6BE RID: 112318
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExplicitStructuredGrid_GetMaxCellSize_35(HandleRef pThis);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601B6BF RID: 112319 RVA: 0x00265F10 File Offset: 0x00264110
		public override int GetMaxCellSize()
		{
			return vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_GetMaxCellSize_35(base.GetCppThis());
		}

		// Token: 0x0601B6C0 RID: 112320
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExplicitStructuredGrid_GetMaxSpatialDimension_36(HandleRef pThis);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601B6C1 RID: 112321 RVA: 0x00265F30 File Offset: 0x00264130
		public override int GetMaxSpatialDimension()
		{
			return vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_GetMaxSpatialDimension_36(base.GetCppThis());
		}

		// Token: 0x0601B6C2 RID: 112322
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExplicitStructuredGrid_GetNumberOfCells_37(HandleRef pThis);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601B6C3 RID: 112323 RVA: 0x00265F50 File Offset: 0x00264150
		public override long GetNumberOfCells()
		{
			return vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_GetNumberOfCells_37(base.GetCppThis());
		}

		// Token: 0x0601B6C4 RID: 112324
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExplicitStructuredGrid_GetNumberOfGenerationsFromBase_38(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601B6C5 RID: 112325 RVA: 0x00265F70 File Offset: 0x00264170
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_GetNumberOfGenerationsFromBase_38(base.GetCppThis(), type);
		}

		// Token: 0x0601B6C6 RID: 112326
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExplicitStructuredGrid_GetNumberOfGenerationsFromBaseType_39([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601B6C7 RID: 112327 RVA: 0x00265F90 File Offset: 0x00264190
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_GetNumberOfGenerationsFromBaseType_39(type);
		}

		// Token: 0x0601B6C8 RID: 112328
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExplicitStructuredGrid_GetPointCells_40(HandleRef pThis, long ptId, HandleRef cellIds);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601B6C9 RID: 112329 RVA: 0x00265FAC File Offset: 0x002641AC
		public override void GetPointCells(long ptId, vtkIdList cellIds)
		{
			vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_GetPointCells_40(base.GetCppThis(), ptId, (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis());
		}

		// Token: 0x0601B6CA RID: 112330
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExplicitStructuredGrid_HasAnyBlankCells_41(HandleRef pThis);

		/// <summary>
		/// Returns true if one or more cells are blanked, false otherwise.
		/// </summary>
		// Token: 0x0601B6CB RID: 112331 RVA: 0x00265FDC File Offset: 0x002641DC
		public override bool HasAnyBlankCells()
		{
			return vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_HasAnyBlankCells_41(base.GetCppThis()) != 0;
		}

		// Token: 0x0601B6CC RID: 112332
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExplicitStructuredGrid_HasAnyGhostCells_42(HandleRef pThis);

		/// <summary>
		/// Returns true if one or more cells are ghost, false otherwise.
		/// </summary>
		// Token: 0x0601B6CD RID: 112333 RVA: 0x00266004 File Offset: 0x00264204
		public new bool HasAnyGhostCells()
		{
			return vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_HasAnyGhostCells_42(base.GetCppThis()) != 0;
		}

		// Token: 0x0601B6CE RID: 112334
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExplicitStructuredGrid_Initialize_43(HandleRef pThis);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601B6CF RID: 112335 RVA: 0x0026602A File Offset: 0x0026422A
		public override void Initialize()
		{
			vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_Initialize_43(base.GetCppThis());
		}

		// Token: 0x0601B6D0 RID: 112336
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExplicitStructuredGrid_IsA_44(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601B6D1 RID: 112337 RVA: 0x0026603C File Offset: 0x0026423C
		public override int IsA(string type)
		{
			return vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_IsA_44(base.GetCppThis(), type);
		}

		// Token: 0x0601B6D2 RID: 112338
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExplicitStructuredGrid_IsCellGhost_45(HandleRef pThis, long cellId);

		/// <summary>
		/// Return non-zero value if specified cell is a ghost cell.
		/// These methods should be called only after the dimensions of the
		/// grid are set.
		/// </summary>
		// Token: 0x0601B6D3 RID: 112339 RVA: 0x0026605C File Offset: 0x0026425C
		public byte IsCellGhost(long cellId)
		{
			return vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_IsCellGhost_45(base.GetCppThis(), cellId);
		}

		// Token: 0x0601B6D4 RID: 112340
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExplicitStructuredGrid_IsCellVisible_46(HandleRef pThis, long cellId);

		/// <summary>
		/// Return non-zero value if specified cell is visible.
		/// These methods should be called only after the dimensions of the
		/// grid are set.
		/// </summary>
		// Token: 0x0601B6D5 RID: 112341 RVA: 0x0026607C File Offset: 0x0026427C
		public byte IsCellVisible(long cellId)
		{
			return vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_IsCellVisible_46(base.GetCppThis(), cellId);
		}

		// Token: 0x0601B6D6 RID: 112342
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExplicitStructuredGrid_IsTypeOf_47([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601B6D7 RID: 112343 RVA: 0x0026609C File Offset: 0x0026429C
		public new static int IsTypeOf(string type)
		{
			return vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_IsTypeOf_47(type);
		}

		// Token: 0x0601B6D8 RID: 112344
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExplicitStructuredGrid_NewInstance_49(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601B6D9 RID: 112345 RVA: 0x002660B8 File Offset: 0x002642B8
		public new vtkExplicitStructuredGrid NewInstance()
		{
			vtkExplicitStructuredGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_NewInstance_49(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExplicitStructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601B6DA RID: 112346
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExplicitStructuredGrid_SafeDownCast_50(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601B6DB RID: 112347 RVA: 0x00266114 File Offset: 0x00264314
		public new static vtkExplicitStructuredGrid SafeDownCast(vtkObjectBase o)
		{
			vtkExplicitStructuredGrid vtkExplicitStructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_SafeDownCast_50((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExplicitStructuredGrid = (vtkExplicitStructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExplicitStructuredGrid.Register(null);
				}
			}
			return vtkExplicitStructuredGrid;
		}

		// Token: 0x0601B6DC RID: 112348
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExplicitStructuredGrid_SetCells_51(HandleRef pThis, HandleRef _arg);

		/// <summary>
		/// Set/Get the cell array defining hexahedron.
		/// </summary>
		// Token: 0x0601B6DD RID: 112349 RVA: 0x00266194 File Offset: 0x00264394
		public virtual void SetCells(vtkCellArray _arg)
		{
			vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_SetCells_51(base.GetCppThis(), (_arg == null) ? default(HandleRef) : _arg.GetCppThis());
		}

		// Token: 0x0601B6DE RID: 112350
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExplicitStructuredGrid_SetDimensions_52(HandleRef pThis, int i, int j, int k);

		/// <summary>
		/// Set/Get the dimensions of this structured dataset in term of number
		/// of points along each direction.
		/// This is just a convenience method which calls Set/GetExtent internally.
		/// </summary>
		// Token: 0x0601B6DF RID: 112351 RVA: 0x002661C3 File Offset: 0x002643C3
		public void SetDimensions(int i, int j, int k)
		{
			vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_SetDimensions_52(base.GetCppThis(), i, j, k);
		}

		// Token: 0x0601B6E0 RID: 112352
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExplicitStructuredGrid_SetDimensions_53(HandleRef pThis, IntPtr dim);

		/// <summary>
		/// Set/Get the dimensions of this structured dataset in term of number
		/// of points along each direction.
		/// This is just a convenience method which calls Set/GetExtent internally.
		/// </summary>
		// Token: 0x0601B6E1 RID: 112353 RVA: 0x002661D5 File Offset: 0x002643D5
		public void SetDimensions(IntPtr dim)
		{
			vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_SetDimensions_53(base.GetCppThis(), dim);
		}

		// Token: 0x0601B6E2 RID: 112354
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExplicitStructuredGrid_SetExtent_54(HandleRef pThis, int x0, int x1, int y0, int y1, int z0, int z1);

		/// <summary>
		/// Set/Get the extent of this structured dataset in term of number
		/// of points along each direction.
		/// Setting the extent will reset the internal CellArray and Links
		/// and a correctly sized cell array will be created.
		/// The Extent is stored  in the order (X, Y, Z).
		/// </summary>
		// Token: 0x0601B6E3 RID: 112355 RVA: 0x002661E5 File Offset: 0x002643E5
		public void SetExtent(int x0, int x1, int y0, int y1, int z0, int z1)
		{
			vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_SetExtent_54(base.GetCppThis(), x0, x1, y0, y1, z0, z1);
		}

		// Token: 0x0601B6E4 RID: 112356
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExplicitStructuredGrid_SetExtent_55(HandleRef pThis, IntPtr extent);

		/// <summary>
		/// Set/Get the extent of this structured dataset in term of number
		/// of points along each direction.
		/// Setting the extent will reset the internal CellArray and Links
		/// and a correctly sized cell array will be created.
		/// The Extent is stored  in the order (X, Y, Z).
		/// </summary>
		// Token: 0x0601B6E5 RID: 112357 RVA: 0x002661FD File Offset: 0x002643FD
		public void SetExtent(IntPtr extent)
		{
			vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_SetExtent_55(base.GetCppThis(), extent);
		}

		// Token: 0x0601B6E6 RID: 112358
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExplicitStructuredGrid_SetFacesConnectivityFlagsArrayName_56(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the name of the faces connectivity flags array.
		/// </summary>
		// Token: 0x0601B6E7 RID: 112359 RVA: 0x0026620D File Offset: 0x0026440D
		public virtual void SetFacesConnectivityFlagsArrayName(string _arg)
		{
			vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_SetFacesConnectivityFlagsArrayName_56(base.GetCppThis(), _arg);
		}

		// Token: 0x0601B6E8 RID: 112360
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExplicitStructuredGrid_SetLinks_57(HandleRef pThis, HandleRef _arg);

		/// <summary>
		/// Set/Get the links that you created possibly without using BuildLinks.
		/// </summary>
		// Token: 0x0601B6E9 RID: 112361 RVA: 0x00266220 File Offset: 0x00264420
		public virtual void SetLinks(vtkAbstractCellLinks _arg)
		{
			vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_SetLinks_57(base.GetCppThis(), (_arg == null) ? default(HandleRef) : _arg.GetCppThis());
		}

		// Token: 0x0601B6EA RID: 112362
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExplicitStructuredGrid_ShallowCopy_58(HandleRef pThis, HandleRef src);

		/// <summary>
		/// Shallow and Deep copy.
		/// </summary>
		// Token: 0x0601B6EB RID: 112363 RVA: 0x00266250 File Offset: 0x00264450
		public override void ShallowCopy(vtkDataObject src)
		{
			vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_ShallowCopy_58(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		// Token: 0x0601B6EC RID: 112364
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExplicitStructuredGrid_UnBlankCell_59(HandleRef pThis, long cellId);

		/// <summary>
		/// Methods for supporting blanking of cells. Blanking turns on or off
		/// cells in the structured grid.
		/// These methods should be called only after the dimensions of the
		/// grid are set.
		/// </summary>
		// Token: 0x0601B6ED RID: 112365 RVA: 0x0026627F File Offset: 0x0026447F
		public void UnBlankCell(long cellId)
		{
			vtkExplicitStructuredGrid.vtkExplicitStructuredGrid_UnBlankCell_59(base.GetCppThis(), cellId);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D82 RID: 7554
		public new const string MRFullTypeName = "Kitware.VTK.vtkExplicitStructuredGrid";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D83 RID: 7555
		public new static readonly string MRClassNameKey = "class vtkExplicitStructuredGrid";
	}
}
