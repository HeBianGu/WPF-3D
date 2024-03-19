using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkStructuredData
	/// </summary>
	/// <remarks>
	///    Singleton class for topologically regular data
	///
	///
	/// vtkStructuredData is a singleton class that provides an interface for
	/// topologically regular data. Regular data is data that can be accessed
	/// in rectangular fashion using an i-j-k index. A finite difference grid,
	/// a volume, or a pixmap are all considered regular.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkStructuredGrid vtkUniformGrid vtkRectilinearGrid vtkRectilinearGrid
	/// </seealso>
	// Token: 0x02000ACC RID: 2764
	public class vtkStructuredData : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D15A RID: 119130 RVA: 0x002901C8 File Offset: 0x0028E3C8
		static vtkStructuredData()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStructuredData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStructuredData"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D15B RID: 119131 RVA: 0x002901F0 File Offset: 0x0028E3F0
		public vtkStructuredData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D15C RID: 119132 RVA: 0x002901FE File Offset: 0x0028E3FE
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D15D RID: 119133
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStructuredData_ComputeCellId_01(IntPtr dim, IntPtr ijk, int dataDescription);

		/// <summary>
		/// Given a location in structured coordinates (i-j-k), and the dimensions
		/// of the structured dataset, return the cell id.  This method does not
		/// adjust for the beginning of the extent.
		/// The dataDescription argument is not used.
		/// </summary>
		// Token: 0x0601D15E RID: 119134 RVA: 0x0029020C File Offset: 0x0028E40C
		public static long ComputeCellId(IntPtr dim, IntPtr ijk, int dataDescription)
		{
			return vtkStructuredData.vtkStructuredData_ComputeCellId_01(dim, ijk, dataDescription);
		}

		// Token: 0x0601D15F RID: 119135
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStructuredData_ComputeCellIdForExtent_02(IntPtr extent, IntPtr ijk, int dataDescription);

		/// <summary>
		/// Given a location in structured coordinates (i-j-k), and the extent
		/// of the structured dataset, return the point id.
		/// The dataDescription argument is not used.
		/// </summary>
		// Token: 0x0601D160 RID: 119136 RVA: 0x00290228 File Offset: 0x0028E428
		public static long ComputeCellIdForExtent(IntPtr extent, IntPtr ijk, int dataDescription)
		{
			return vtkStructuredData.vtkStructuredData_ComputeCellIdForExtent_02(extent, ijk, dataDescription);
		}

		// Token: 0x0601D161 RID: 119137
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredData_ComputeCellStructuredCoords_03(long cellId, IntPtr dim, IntPtr ijk, int dataDescription);

		/// <summary>
		/// Given a cellId and grid dimensions 'dim', get the structured coordinates
		/// (i-j-k). This method does not adjust for the beginning of the extent.
		/// The dataDescription argument is not used.
		/// </summary>
		// Token: 0x0601D162 RID: 119138 RVA: 0x00290244 File Offset: 0x0028E444
		public static void ComputeCellStructuredCoords(long cellId, IntPtr dim, IntPtr ijk, int dataDescription)
		{
			vtkStructuredData.vtkStructuredData_ComputeCellStructuredCoords_03(cellId, dim, ijk, dataDescription);
		}

		// Token: 0x0601D163 RID: 119139
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredData_ComputeCellStructuredCoordsForExtent_04(long cellIdx, IntPtr ext, IntPtr ijk, int dataDescription);

		/// <summary>
		/// Given the global grid extent and the linear index of a cell within the
		/// grid extent, this method computes the corresponding structured coordinates
		/// of the given cell. This method adjusts for the beginning of the extent.
		/// The dataDescription argument is not used.
		/// </summary>
		// Token: 0x0601D164 RID: 119140 RVA: 0x00290251 File Offset: 0x0028E451
		public static void ComputeCellStructuredCoordsForExtent(long cellIdx, IntPtr ext, IntPtr ijk, int dataDescription)
		{
			vtkStructuredData.vtkStructuredData_ComputeCellStructuredCoordsForExtent_04(cellIdx, ext, ijk, dataDescription);
		}

		// Token: 0x0601D165 RID: 119141
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStructuredData_ComputePointId_05(IntPtr dim, IntPtr ijk, int dataDescription);

		/// <summary>
		/// Given a location in structured coordinates (i-j-k), and the dimensions
		/// of the structured dataset, return the point id.  This method does not
		/// adjust for the beginning of the extent.
		/// The dataDescription argument is not used.
		/// </summary>
		// Token: 0x0601D166 RID: 119142 RVA: 0x00290260 File Offset: 0x0028E460
		public static long ComputePointId(IntPtr dim, IntPtr ijk, int dataDescription)
		{
			return vtkStructuredData.vtkStructuredData_ComputePointId_05(dim, ijk, dataDescription);
		}

		// Token: 0x0601D167 RID: 119143
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStructuredData_ComputePointIdForExtent_06(IntPtr extent, IntPtr ijk, int dataDescription);

		/// <summary>
		/// Given a location in structured coordinates (i-j-k), and the extent
		/// of the structured dataset, return the point id.
		/// The dataDescription argument is not used.
		/// </summary>
		// Token: 0x0601D168 RID: 119144 RVA: 0x0029027C File Offset: 0x0028E47C
		public static long ComputePointIdForExtent(IntPtr extent, IntPtr ijk, int dataDescription)
		{
			return vtkStructuredData.vtkStructuredData_ComputePointIdForExtent_06(extent, ijk, dataDescription);
		}

		// Token: 0x0601D169 RID: 119145
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredData_ComputePointStructuredCoords_07(long ptId, IntPtr dim, IntPtr ijk, int dataDescription);

		/// <summary>
		/// Given a pointId and grid dimensions 'dim', get the structured coordinates
		/// (i-j-k). This method does not adjust for the beginning of the extent.
		/// The dataDescription argument is not used.
		/// </summary>
		// Token: 0x0601D16A RID: 119146 RVA: 0x00290298 File Offset: 0x0028E498
		public static void ComputePointStructuredCoords(long ptId, IntPtr dim, IntPtr ijk, int dataDescription)
		{
			vtkStructuredData.vtkStructuredData_ComputePointStructuredCoords_07(ptId, dim, ijk, dataDescription);
		}

		// Token: 0x0601D16B RID: 119147
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredData_ComputePointStructuredCoordsForExtent_08(long ptId, IntPtr ext, IntPtr ijk, int dataDescription);

		/// <summary>
		/// Given a pointId and the grid extent ext, get the structured coordinates
		/// (i-j-k). This method adjusts for the beginning of the extent.
		/// The dataDescription argument is not used.
		/// </summary>
		// Token: 0x0601D16C RID: 119148 RVA: 0x002902A5 File Offset: 0x0028E4A5
		public static void ComputePointStructuredCoordsForExtent(long ptId, IntPtr ext, IntPtr ijk, int dataDescription)
		{
			vtkStructuredData.vtkStructuredData_ComputePointStructuredCoordsForExtent_08(ptId, ext, ijk, dataDescription);
		}

		// Token: 0x0601D16D RID: 119149
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredData_GetCellDimensionsFromExtent_09(IntPtr ext, IntPtr celldims, int dataDescription);

		/// <summary>
		/// Returns the cell dimensions, i.e., the number of cells along the i,j,k
		/// for the grid with the given grid extent. Note, the grid extent is the
		/// number of points.
		/// The dataDescription field is not used.
		/// </summary>
		// Token: 0x0601D16E RID: 119150 RVA: 0x002902B2 File Offset: 0x0028E4B2
		public static void GetCellDimensionsFromExtent(IntPtr ext, IntPtr celldims, int dataDescription)
		{
			vtkStructuredData.vtkStructuredData_GetCellDimensionsFromExtent_09(ext, celldims, dataDescription);
		}

		// Token: 0x0601D16F RID: 119151
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredData_GetCellDimensionsFromPointDimensions_10(IntPtr pntdims, IntPtr cellDims);

		/// <summary>
		/// Given the dimensions of the grid, in pntdims, this method returns
		/// the corresponding cell dimensions for the given grid.
		/// The dataDescription field is not used.
		/// </summary>
		// Token: 0x0601D170 RID: 119152 RVA: 0x002902BE File Offset: 0x0028E4BE
		public static void GetCellDimensionsFromPointDimensions(IntPtr pntdims, IntPtr cellDims)
		{
			vtkStructuredData.vtkStructuredData_GetCellDimensionsFromPointDimensions_10(pntdims, cellDims);
		}

		// Token: 0x0601D171 RID: 119153
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredData_GetCellExtentFromPointExtent_11(IntPtr pntExtent, IntPtr cellExtent, int dataDescription);

		/// <summary>
		/// Given the point extent of a grid, this method computes the corresponding
		/// cell extent for the grid.
		/// The dataDescription field is not used.
		/// </summary>
		// Token: 0x0601D172 RID: 119154 RVA: 0x002902C9 File Offset: 0x0028E4C9
		public static void GetCellExtentFromPointExtent(IntPtr pntExtent, IntPtr cellExtent, int dataDescription)
		{
			vtkStructuredData.vtkStructuredData_GetCellExtentFromPointExtent_11(pntExtent, cellExtent, dataDescription);
		}

		// Token: 0x0601D173 RID: 119155
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredData_GetCellNeighbors_12(long cellId, HandleRef ptIds, HandleRef cellIds, IntPtr dim);

		/// <summary>
		/// Get the cells using the points ptIds, exclusive of the cell cellId.
		/// (See vtkDataSet for more info.)
		/// </summary>
		// Token: 0x0601D174 RID: 119156 RVA: 0x002902D8 File Offset: 0x0028E4D8
		public static void GetCellNeighbors(long cellId, vtkIdList ptIds, vtkIdList cellIds, IntPtr dim)
		{
			vtkStructuredData.vtkStructuredData_GetCellNeighbors_12(cellId, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis(), (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis(), dim);
		}

		// Token: 0x0601D175 RID: 119157
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredData_GetCellNeighbors_13(long cellId, HandleRef ptIds, HandleRef cellIds, IntPtr dim, IntPtr seedLoc);

		/// <summary>
		/// Get the cells using the points ptIds, exclusive of the cell cellId.
		/// (See vtkDataSet for more info.)
		/// </summary>
		// Token: 0x0601D176 RID: 119158 RVA: 0x00290318 File Offset: 0x0028E518
		public static void GetCellNeighbors(long cellId, vtkIdList ptIds, vtkIdList cellIds, IntPtr dim, IntPtr seedLoc)
		{
			vtkStructuredData.vtkStructuredData_GetCellNeighbors_13(cellId, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis(), (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis(), dim, seedLoc);
		}

		// Token: 0x0601D177 RID: 119159
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredData_GetCellPoints_14(long cellId, HandleRef ptIds, int dataDescription, IntPtr dim);

		/// <summary>
		/// Get the points defining a cell. (See vtkDataSet for more info.)
		/// </summary>
		// Token: 0x0601D178 RID: 119160 RVA: 0x0029035C File Offset: 0x0028E55C
		public static void GetCellPoints(long cellId, vtkIdList ptIds, int dataDescription, IntPtr dim)
		{
			vtkStructuredData.vtkStructuredData_GetCellPoints_14(cellId, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis(), dataDescription, dim);
		}

		// Token: 0x0601D179 RID: 119161
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredData_GetDataDescription_15(IntPtr dims);

		/// <summary>
		/// Returns the data description given the dimensions (eg. VTK_SINGLE_POINT,
		/// VTK_X_LINE, VTK_XY_PLANE etc.)
		/// </summary>
		// Token: 0x0601D17A RID: 119162 RVA: 0x00290388 File Offset: 0x0028E588
		public static int GetDataDescription(IntPtr dims)
		{
			return vtkStructuredData.vtkStructuredData_GetDataDescription_15(dims);
		}

		// Token: 0x0601D17B RID: 119163
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredData_GetDataDescriptionFromExtent_16(IntPtr ext);

		/// <summary>
		/// Returns the data description given the dimensions (eg. VTK_SINGLE_POINT,
		/// VTK_X_LINE, VTK_XY_PLANE etc.)
		/// </summary>
		// Token: 0x0601D17C RID: 119164 RVA: 0x002903A4 File Offset: 0x0028E5A4
		public static int GetDataDescriptionFromExtent(IntPtr ext)
		{
			return vtkStructuredData.vtkStructuredData_GetDataDescriptionFromExtent_16(ext);
		}

		// Token: 0x0601D17D RID: 119165
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredData_GetDataDimension_17(int dataDescription);

		/// <summary>
		/// Return the topological dimension of the data (e.g., 0, 1, 2, or 3D).
		/// </summary>
		// Token: 0x0601D17E RID: 119166 RVA: 0x002903C0 File Offset: 0x0028E5C0
		public static int GetDataDimension(int dataDescription)
		{
			return vtkStructuredData.vtkStructuredData_GetDataDimension_17(dataDescription);
		}

		// Token: 0x0601D17F RID: 119167
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredData_GetDataDimension_18(IntPtr ext);

		/// <summary>
		/// Return the topological dimension of the data (e.g., 0, 1, 2, or 3D).
		/// </summary>
		// Token: 0x0601D180 RID: 119168 RVA: 0x002903DC File Offset: 0x0028E5DC
		public static int GetDataDimension(IntPtr ext)
		{
			return vtkStructuredData.vtkStructuredData_GetDataDimension_18(ext);
		}

		// Token: 0x0601D181 RID: 119169
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredData_GetDimensionsFromExtent_19(IntPtr ext, IntPtr dims, int dataDescription);

		/// <summary>
		/// Computes the structured grid dimensions based on the given extent.
		/// The dataDescription field is not used.
		/// </summary>
		// Token: 0x0601D182 RID: 119170 RVA: 0x002903F6 File Offset: 0x0028E5F6
		public static void GetDimensionsFromExtent(IntPtr ext, IntPtr dims, int dataDescription)
		{
			vtkStructuredData.vtkStructuredData_GetDimensionsFromExtent_19(ext, dims, dataDescription);
		}

		// Token: 0x0601D183 RID: 119171
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredData_GetGlobalStructuredCoordinates_20(IntPtr lijk, IntPtr ext, IntPtr ijk, int dataDescription);

		/// <summary>
		/// Given local structured coordinates, and the corresponding global sub-grid
		/// extent, this method computes the global ijk coordinates.
		/// The dataDescription parameter is not used.
		/// </summary>
		// Token: 0x0601D184 RID: 119172 RVA: 0x00290402 File Offset: 0x0028E602
		public static void GetGlobalStructuredCoordinates(IntPtr lijk, IntPtr ext, IntPtr ijk, int dataDescription)
		{
			vtkStructuredData.vtkStructuredData_GetGlobalStructuredCoordinates_20(lijk, ext, ijk, dataDescription);
		}

		// Token: 0x0601D185 RID: 119173
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredData_GetLocalStructuredCoordinates_21(IntPtr ijk, IntPtr ext, IntPtr lijk, int dataDescription);

		/// <summary>
		/// Given the global structured coordinates for a point or cell, ijk, w.r.t.
		/// as well as, the global sub-grid cell or point extent, this method computes
		/// the corresponding local structured coordinates, lijk, starting from 0.
		/// The dataDescription argument is not used.
		/// </summary>
		// Token: 0x0601D186 RID: 119174 RVA: 0x0029040F File Offset: 0x0028E60F
		public static void GetLocalStructuredCoordinates(IntPtr ijk, IntPtr ext, IntPtr lijk, int dataDescription)
		{
			vtkStructuredData.vtkStructuredData_GetLocalStructuredCoordinates_21(ijk, ext, lijk, dataDescription);
		}

		// Token: 0x0601D187 RID: 119175
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStructuredData_GetNumberOfCells_22(IntPtr ext, int dataDescription);

		/// <summary>
		/// Given the grid extent, this method returns the total number of cells
		/// within the extent.
		/// The dataDescription field is not used.
		/// </summary>
		// Token: 0x0601D188 RID: 119176 RVA: 0x0029041C File Offset: 0x0028E61C
		public static long GetNumberOfCells(IntPtr ext, int dataDescription)
		{
			return vtkStructuredData.vtkStructuredData_GetNumberOfCells_22(ext, dataDescription);
		}

		// Token: 0x0601D189 RID: 119177
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStructuredData_GetNumberOfGenerationsFromBase_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D18A RID: 119178 RVA: 0x00290438 File Offset: 0x0028E638
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkStructuredData.vtkStructuredData_GetNumberOfGenerationsFromBase_23(base.GetCppThis(), type);
		}

		// Token: 0x0601D18B RID: 119179
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStructuredData_GetNumberOfGenerationsFromBaseType_24([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D18C RID: 119180 RVA: 0x00290458 File Offset: 0x0028E658
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkStructuredData.vtkStructuredData_GetNumberOfGenerationsFromBaseType_24(type);
		}

		// Token: 0x0601D18D RID: 119181
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStructuredData_GetNumberOfPoints_25(IntPtr ext, int dataDescription);

		/// <summary>
		/// Given the grid extent, this method returns the total number of points
		/// within the extent.
		/// The dataDescription field is not used.
		/// </summary>
		// Token: 0x0601D18E RID: 119182 RVA: 0x00290474 File Offset: 0x0028E674
		public static long GetNumberOfPoints(IntPtr ext, int dataDescription)
		{
			return vtkStructuredData.vtkStructuredData_GetNumberOfPoints_25(ext, dataDescription);
		}

		// Token: 0x0601D18F RID: 119183
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredData_GetPointCells_26(long ptId, HandleRef cellIds, IntPtr dim);

		/// <summary>
		/// Get the cells using a point. (See vtkDataSet for more info.)
		/// </summary>
		// Token: 0x0601D190 RID: 119184 RVA: 0x00290490 File Offset: 0x0028E690
		public static void GetPointCells(long ptId, vtkIdList cellIds, IntPtr dim)
		{
			vtkStructuredData.vtkStructuredData_GetPointCells_26(ptId, (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis(), dim);
		}

		// Token: 0x0601D191 RID: 119185
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredData_IsA_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D192 RID: 119186 RVA: 0x002904BC File Offset: 0x0028E6BC
		public override int IsA(string type)
		{
			return vtkStructuredData.vtkStructuredData_IsA_27(base.GetCppThis(), type);
		}

		// Token: 0x0601D193 RID: 119187
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStructuredData_IsCellVisible_28(long cellId, IntPtr dimensions, int dataDescription, HandleRef cellGhostArray, HandleRef pointGhostArray);

		/// <summary>
		/// Return non-zero value if specified cell is visible.
		/// </summary>
		// Token: 0x0601D194 RID: 119188 RVA: 0x002904DC File Offset: 0x0028E6DC
		public static bool IsCellVisible(long cellId, IntPtr dimensions, int dataDescription, vtkUnsignedCharArray cellGhostArray, vtkUnsignedCharArray pointGhostArray)
		{
			return vtkStructuredData.vtkStructuredData_IsCellVisible_28(cellId, dimensions, dataDescription, (cellGhostArray == null) ? default(HandleRef) : cellGhostArray.GetCppThis(), (pointGhostArray == null) ? default(HandleRef) : pointGhostArray.GetCppThis()) != 0;
		}

		// Token: 0x0601D195 RID: 119189
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStructuredData_IsPointVisible_29(long cellId, HandleRef ghosts);

		/// <summary>
		/// Return non-zero value if specified point is visible.
		/// </summary>
		// Token: 0x0601D196 RID: 119190 RVA: 0x0029052C File Offset: 0x0028E72C
		public static bool IsPointVisible(long cellId, vtkUnsignedCharArray ghosts)
		{
			return vtkStructuredData.vtkStructuredData_IsPointVisible_29(cellId, (ghosts == null) ? default(HandleRef) : ghosts.GetCppThis()) != 0;
		}

		// Token: 0x0601D197 RID: 119191
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredData_IsTypeOf_30([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D198 RID: 119192 RVA: 0x00290564 File Offset: 0x0028E764
		public new static int IsTypeOf(string type)
		{
			return vtkStructuredData.vtkStructuredData_IsTypeOf_30(type);
		}

		// Token: 0x0601D199 RID: 119193
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredData_NewInstance_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D19A RID: 119194 RVA: 0x00290580 File Offset: 0x0028E780
		public new vtkStructuredData NewInstance()
		{
			vtkStructuredData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredData.vtkStructuredData_NewInstance_31(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601D19B RID: 119195
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredData_SafeDownCast_32(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D19C RID: 119196 RVA: 0x002905DC File Offset: 0x0028E7DC
		public new static vtkStructuredData SafeDownCast(vtkObjectBase o)
		{
			vtkStructuredData vtkStructuredData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredData.vtkStructuredData_SafeDownCast_32((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredData = (vtkStructuredData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredData.Register(null);
				}
			}
			return vtkStructuredData;
		}

		// Token: 0x0601D19D RID: 119197
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredData_SetDimensions_33(IntPtr inDim, IntPtr dim);

		/// <summary>
		/// Specify the dimensions of a regular, rectangular dataset. The input is
		/// the new dimensions (inDim) and the current dimensions (dim). The function
		/// returns the dimension of the dataset (0-3D). If the dimensions are
		/// improperly specified a -1 is returned. If the dimensions are unchanged, a
		/// value of 100 is returned.
		/// </summary>
		// Token: 0x0601D19E RID: 119198 RVA: 0x0029065C File Offset: 0x0028E85C
		public static int SetDimensions(IntPtr inDim, IntPtr dim)
		{
			return vtkStructuredData.vtkStructuredData_SetDimensions_33(inDim, dim);
		}

		// Token: 0x0601D19F RID: 119199
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredData_SetExtent_34(IntPtr inExt, IntPtr ext);

		/// <summary>
		/// Specify the dimensions of a regular, rectangular dataset. The input is
		/// the new dimensions (inDim) and the current dimensions (dim). The function
		/// returns the dimension of the dataset (0-3D). If the dimensions are
		/// improperly specified a -1 is returned. If the dimensions are unchanged, a
		/// value of 100 is returned.
		/// </summary>
		// Token: 0x0601D1A0 RID: 119200 RVA: 0x00290678 File Offset: 0x0028E878
		public static int SetExtent(IntPtr inExt, IntPtr ext)
		{
			return vtkStructuredData.vtkStructuredData_SetExtent_34(inExt, ext);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EBE RID: 7870
		public new const string MRFullTypeName = "Kitware.VTK.vtkStructuredData";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EBF RID: 7871
		public new static readonly string MRClassNameKey = "class vtkStructuredData";
	}
}
