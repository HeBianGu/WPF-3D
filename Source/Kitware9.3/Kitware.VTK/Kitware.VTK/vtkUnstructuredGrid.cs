using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkUnstructuredGrid
	/// </summary>
	/// <remarks>
	///    dataset represents arbitrary combinations of
	/// all possible cell types
	///
	/// vtkUnstructuredGrid is a data object that is a concrete implementation of
	/// vtkDataSet. vtkUnstructuredGrid represents any combinations of any cell
	/// types. This includes 0D (e.g., points), 1D (e.g., lines, polylines), 2D
	/// (e.g., triangles, polygons), and 3D (e.g., hexahedron, tetrahedron,
	/// polyhedron, etc.). vtkUnstructuredGrid provides random access to cells, as
	/// well as topological information (such as lists of cells using each point).
	/// </remarks>
	// Token: 0x02000ADE RID: 2782
	public class vtkUnstructuredGrid : vtkUnstructuredGridBase
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D518 RID: 120088 RVA: 0x0029602B File Offset: 0x0029422B
		static vtkUnstructuredGrid()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUnstructuredGrid.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGrid"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D519 RID: 120089 RVA: 0x00296053 File Offset: 0x00294253
		public vtkUnstructuredGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601D51A RID: 120090
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard instantiation method.
		/// </summary>
		// Token: 0x0601D51B RID: 120091 RVA: 0x00296064 File Offset: 0x00294264
		public new static vtkUnstructuredGrid New()
		{
			vtkUnstructuredGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGrid.vtkUnstructuredGrid_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard instantiation method.
		/// </summary>
		// Token: 0x0601D51C RID: 120092 RVA: 0x002960B8 File Offset: 0x002942B8
		public vtkUnstructuredGrid() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkUnstructuredGrid.vtkUnstructuredGrid_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D51D RID: 120093 RVA: 0x002960FC File Offset: 0x002942FC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D51E RID: 120094
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGrid_AddReferenceToCell_01(HandleRef pThis, long ptId, long cellId);

		/// <summary>
		/// Use these methods only if the dataset has been specified as
		/// Editable. See vtkPointSet for more information.
		/// </summary>
		// Token: 0x0601D51F RID: 120095 RVA: 0x00296107 File Offset: 0x00294307
		public void AddReferenceToCell(long ptId, long cellId)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_AddReferenceToCell_01(base.GetCppThis(), ptId, cellId);
		}

		// Token: 0x0601D520 RID: 120096
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGrid_Allocate_02(HandleRef pThis, long numCells, int arg1);

		/// <summary>
		/// Method allocates initial storage for the cell connectivity. Use this
		/// method before the method InsertNextCell(). The array capacity is
		/// doubled when the inserting a cell exceeds the current capacity.
		/// extSize is no longer used.
		///
		/// @note Prefer AllocateExact or AllocateEstimate, which give more control
		/// over how allocations are distributed.
		/// </summary>
		// Token: 0x0601D521 RID: 120097 RVA: 0x00296118 File Offset: 0x00294318
		public override void Allocate(long numCells, int arg1)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_Allocate_02(base.GetCppThis(), numCells, arg1);
		}

		// Token: 0x0601D522 RID: 120098
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkUnstructuredGrid_AllocateEstimate_03(HandleRef pThis, long numCells, long maxCellSize);

		/// <summary>
		/// @brief Pre-allocate memory in internal data structures. Does not change
		/// the number of cells, only the array capacities. Existing data is NOT
		/// preserved.
		/// @param numCells The number of expected cells in the dataset.
		/// @param maxCellSize The number of points per cell to allocate memory for.
		/// @return True if allocation succeeds.
		/// @sa Squeeze();
		/// </summary>
		// Token: 0x0601D523 RID: 120099 RVA: 0x0029612C File Offset: 0x0029432C
		public bool AllocateEstimate(long numCells, long maxCellSize)
		{
			return vtkUnstructuredGrid.vtkUnstructuredGrid_AllocateEstimate_03(base.GetCppThis(), numCells, maxCellSize) != 0;
		}

		// Token: 0x0601D524 RID: 120100
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkUnstructuredGrid_AllocateExact_04(HandleRef pThis, long numCells, long connectivitySize);

		/// <summary>
		/// @brief Pre-allocate memory in internal data structures. Does not change
		/// the number of cells, only the array capacities. Existing data is NOT
		/// preserved.
		/// @param numCells The number of expected cells in the dataset.
		/// @param connectivitySize The total number of pointIds stored for all cells.
		/// @return True if allocation succeeds.
		/// @sa Squeeze();
		/// </summary>
		// Token: 0x0601D525 RID: 120101 RVA: 0x00296154 File Offset: 0x00294354
		public bool AllocateExact(long numCells, long connectivitySize)
		{
			return vtkUnstructuredGrid.vtkUnstructuredGrid_AllocateExact_04(base.GetCppThis(), numCells, connectivitySize) != 0;
		}

		// Token: 0x0601D526 RID: 120102
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGrid_BuildLinks_05(HandleRef pThis);

		/// <summary>
		/// Build topological links from points to lists of cells that use each point.
		/// See vtkAbstractCellLinks for more information.
		/// </summary>
		// Token: 0x0601D527 RID: 120103 RVA: 0x0029617C File Offset: 0x0029437C
		public void BuildLinks()
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_BuildLinks_05(base.GetCppThis());
		}

		// Token: 0x0601D528 RID: 120104
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGrid_ConvertFaceStreamPointIds_06(HandleRef faceStream, IntPtr idMap);

		/// <summary>
		/// Convert pid in a face stream into idMap[pid]. The face stream is of format
		/// [nCellFaces, nFace0Pts, i, j, k, nFace1Pts, i, j, k, ...]. The user is
		/// responsible to make sure all the Ids in faceStream do not exceed the
		/// range of idMap.
		/// </summary>
		// Token: 0x0601D529 RID: 120105 RVA: 0x0029618C File Offset: 0x0029438C
		public static void ConvertFaceStreamPointIds(vtkIdList faceStream, IntPtr idMap)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_ConvertFaceStreamPointIds_06((faceStream == null) ? default(HandleRef) : faceStream.GetCppThis(), idMap);
		}

		// Token: 0x0601D52A RID: 120106
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGrid_ConvertFaceStreamPointIds_07(long nfaces, IntPtr faceStream, IntPtr idMap);

		/// <summary>
		/// Convert pid in a face stream into idMap[pid]. The face stream is of format
		/// [nFace0Pts, i, j, k, nFace1Pts, i, j, k, ...]. The user is responsible to
		/// make sure all the Ids in faceStream do not exceed the range of idMap.
		/// </summary>
		// Token: 0x0601D52B RID: 120107 RVA: 0x002961B6 File Offset: 0x002943B6
		public static void ConvertFaceStreamPointIds(long nfaces, IntPtr faceStream, IntPtr idMap)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_ConvertFaceStreamPointIds_07(nfaces, faceStream, idMap);
		}

		// Token: 0x0601D52C RID: 120108
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGrid_CopyStructure_08(HandleRef pThis, HandleRef ds);

		/// <summary>
		/// Standard vtkDataSet methods; see vtkDataSet.h for documentation.
		/// </summary>
		// Token: 0x0601D52D RID: 120109 RVA: 0x002961C4 File Offset: 0x002943C4
		public override void CopyStructure(vtkDataSet ds)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_CopyStructure_08(base.GetCppThis(), (ds == null) ? default(HandleRef) : ds.GetCppThis());
		}

		// Token: 0x0601D52E RID: 120110
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGrid_DecomposeAPolyhedronCell_09(HandleRef polyhedronCellArray, ref long nCellpts, ref long nCellfaces, HandleRef cellArray, HandleRef faces);

		/// <summary>
		/// A static method for converting a polyhedron vtkCellArray of format
		/// [nCellFaces, nFace0Pts, i, j, k, nFace1Pts, i, j, k, ...]
		/// into three components: (1) an integer indicating the number of faces
		/// (2) a standard vtkCellArray storing point ids [nCell0Pts, i, j, k]
		/// and (3) an vtkIdTypeArray storing face connectivity in format
		/// [nFace0Pts, i, j, k, nFace1Pts, i, j, k, ...]
		/// Note: input is assumed to contain only one polyhedron cell.
		/// Outputs (2) and (3) will be stacked at the end of the input
		/// cellArray and faces. The original data in the input will not
		/// be touched.
		/// </summary>
		// Token: 0x0601D52F RID: 120111 RVA: 0x002961F4 File Offset: 0x002943F4
		public static void DecomposeAPolyhedronCell(vtkCellArray polyhedronCellArray, ref long nCellpts, ref long nCellfaces, vtkCellArray cellArray, vtkIdTypeArray faces)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_DecomposeAPolyhedronCell_09((polyhedronCellArray == null) ? default(HandleRef) : polyhedronCellArray.GetCppThis(), ref nCellpts, ref nCellfaces, (cellArray == null) ? default(HandleRef) : cellArray.GetCppThis(), (faces == null) ? default(HandleRef) : faces.GetCppThis());
		}

		// Token: 0x0601D530 RID: 120112
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGrid_DecomposeAPolyhedronCell_10(IntPtr polyhedronCellStream, ref long nCellpts, ref long nCellfaces, HandleRef cellArray, HandleRef faces);

		/// <summary>
		/// A static method for converting a polyhedron vtkCellArray of format
		/// [nCellFaces, nFace0Pts, i, j, k, nFace1Pts, i, j, k, ...]
		/// into three components: (1) an integer indicating the number of faces
		/// (2) a standard vtkCellArray storing point ids [nCell0Pts, i, j, k]
		/// and (3) an vtkIdTypeArray storing face connectivity in format
		/// [nFace0Pts, i, j, k, nFace1Pts, i, j, k, ...]
		/// Note: input is assumed to contain only one polyhedron cell.
		/// Outputs (2) and (3) will be stacked at the end of the input
		/// cellArray and faces. The original data in the input will not
		/// be touched.
		/// </summary>
		// Token: 0x0601D531 RID: 120113 RVA: 0x0029624C File Offset: 0x0029444C
		public static void DecomposeAPolyhedronCell(IntPtr polyhedronCellStream, ref long nCellpts, ref long nCellfaces, vtkCellArray cellArray, vtkIdTypeArray faces)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_DecomposeAPolyhedronCell_10(polyhedronCellStream, ref nCellpts, ref nCellfaces, (cellArray == null) ? default(HandleRef) : cellArray.GetCppThis(), (faces == null) ? default(HandleRef) : faces.GetCppThis());
		}

		// Token: 0x0601D532 RID: 120114
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGrid_DecomposeAPolyhedronCell_11(long nCellFaces, IntPtr inFaceStream, ref long nCellpts, HandleRef cellArray, HandleRef faces);

		/// <summary>
		/// A static method for converting an input polyhedron cell stream of format
		/// [nFace0Pts, i, j, k, nFace1Pts, i, j, k, ...]
		/// into three components: (1) an integer indicating the number of faces
		/// (2) a standard vtkCellArray storing point ids [nCell0Pts, i, j, k]
		/// and (3) an vtkIdTypeArray storing face connectivity in format
		/// [nFace0Pts, i, j, k, nFace1Pts, i, j, k, ...]
		/// Note: input is assumed to contain only one polyhedron cell.
		/// Outputs (2) and (3) will be stacked at the end of the input
		/// cellArray and faces. The original data in the input will not
		/// be touched.
		/// </summary>
		// Token: 0x0601D533 RID: 120115 RVA: 0x00296290 File Offset: 0x00294490
		public static void DecomposeAPolyhedronCell(long nCellFaces, IntPtr inFaceStream, ref long nCellpts, vtkCellArray cellArray, vtkIdTypeArray faces)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_DecomposeAPolyhedronCell_11(nCellFaces, inFaceStream, ref nCellpts, (cellArray == null) ? default(HandleRef) : cellArray.GetCppThis(), (faces == null) ? default(HandleRef) : faces.GetCppThis());
		}

		// Token: 0x0601D534 RID: 120116
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGrid_DeepCopy_12(HandleRef pThis, HandleRef src);

		/// <summary>
		/// Shallow and Deep copy.
		/// </summary>
		// Token: 0x0601D535 RID: 120117 RVA: 0x002962D4 File Offset: 0x002944D4
		public override void DeepCopy(vtkDataObject src)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_DeepCopy_12(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		// Token: 0x0601D536 RID: 120118
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGrid_ExtendedNew_13(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard instantiation method.
		/// </summary>
		// Token: 0x0601D537 RID: 120119 RVA: 0x00296304 File Offset: 0x00294504
		public new static vtkUnstructuredGrid ExtendedNew()
		{
			vtkUnstructuredGrid vtkUnstructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGrid.vtkUnstructuredGrid_ExtendedNew_13(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGrid = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGrid.Register(null);
				}
			}
			return vtkUnstructuredGrid;
		}

		// Token: 0x0601D538 RID: 120120
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkUnstructuredGrid_GetActualMemorySize_14(HandleRef pThis);

		/// <summary>
		/// Return the actual size of the data in kibibytes (1024 bytes). This number
		/// is valid only after the pipeline has updated. The memory size
		/// returned is guaranteed to be greater than or equal to the
		/// memory required to represent the data (e.g., extra space in
		/// arrays, etc. are not included in the return value). THIS METHOD
		/// IS THREAD SAFE.
		/// </summary>
		// Token: 0x0601D539 RID: 120121 RVA: 0x00296370 File Offset: 0x00294570
		public override uint GetActualMemorySize()
		{
			return vtkUnstructuredGrid.vtkUnstructuredGrid_GetActualMemorySize_14(base.GetCppThis());
		}

		// Token: 0x0601D53A RID: 120122
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGrid_GetCell_15(HandleRef pThis, long cellId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard vtkDataSet methods; see vtkDataSet.h for documentation.
		/// </summary>
		// Token: 0x0601D53B RID: 120123 RVA: 0x00296390 File Offset: 0x00294590
		public override vtkCell GetCell(long cellId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGrid.vtkUnstructuredGrid_GetCell_15(base.GetCppThis(), cellId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601D53C RID: 120124
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGrid_GetCell_16(HandleRef pThis, long cellId, HandleRef cell);

		/// <summary>
		/// Standard vtkDataSet methods; see vtkDataSet.h for documentation.
		/// </summary>
		// Token: 0x0601D53D RID: 120125 RVA: 0x00296400 File Offset: 0x00294600
		public override void GetCell(long cellId, vtkGenericCell cell)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_GetCell_16(base.GetCppThis(), cellId, (cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x0601D53E RID: 120126
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGrid_GetCellBounds_17(HandleRef pThis, long cellId, IntPtr bounds);

		/// <summary>
		/// Standard vtkDataSet methods; see vtkDataSet.h for documentation.
		/// </summary>
		// Token: 0x0601D53F RID: 120127 RVA: 0x00296430 File Offset: 0x00294630
		public override void GetCellBounds(long cellId, IntPtr bounds)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_GetCellBounds_17(base.GetCppThis(), cellId, bounds);
		}

		// Token: 0x0601D540 RID: 120128
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGrid_GetCellLocationsArray_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the array of all the starting indices of cell definitions
		/// in the cell array.
		///
		/// @warning vtkCellArray supports random access now. This array is no
		/// longer used.
		/// </summary>
		// Token: 0x0601D541 RID: 120129 RVA: 0x00296444 File Offset: 0x00294644
		public vtkIdTypeArray GetCellLocationsArray()
		{
			vtkIdTypeArray vtkIdTypeArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGrid.vtkUnstructuredGrid_GetCellLocationsArray_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdTypeArray = (vtkIdTypeArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdTypeArray.Register(null);
				}
			}
			return vtkIdTypeArray;
		}

		// Token: 0x0601D542 RID: 120130
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGrid_GetCellNeighbors_19(HandleRef pThis, long cellId, HandleRef ptIds, HandleRef cellIds);

		/// <summary>
		/// A topological inquiry to retrieve all of the cells using list of points
		/// exclusive of the current cell specified (e.g., cellId).  THIS METHOD IS
		/// THREAD SAFE IF FIRST CALLED FROM A SINGLE THREAD AND THE DATASET IS NOT
		/// MODIFIED.
		/// </summary>
		// Token: 0x0601D543 RID: 120131 RVA: 0x002964B4 File Offset: 0x002946B4
		public override void GetCellNeighbors(long cellId, vtkIdList ptIds, vtkIdList cellIds)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_GetCellNeighbors_19(base.GetCppThis(), cellId, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis(), (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis());
		}

		// Token: 0x0601D544 RID: 120132
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGrid_GetCellNeighbors_20(HandleRef pThis, long cellId, long npts, IntPtr ptIds, HandleRef cellIds);

		/// <summary>
		/// A topological inquiry to retrieve all of the cells using list of points
		/// exclusive of the current cell specified (e.g., cellId).  THIS METHOD IS
		/// THREAD SAFE IF FIRST CALLED FROM A SINGLE THREAD AND THE DATASET IS NOT
		/// MODIFIED.
		/// </summary>
		// Token: 0x0601D545 RID: 120133 RVA: 0x002964FC File Offset: 0x002946FC
		public void GetCellNeighbors(long cellId, long npts, IntPtr ptIds, vtkIdList cellIds)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_GetCellNeighbors_20(base.GetCppThis(), cellId, npts, ptIds, (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis());
		}

		// Token: 0x0601D546 RID: 120134
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGrid_GetCellPoints_21(HandleRef pThis, long cellId, HandleRef ptIds);

		/// <summary>
		/// Standard vtkDataSet methods; see vtkDataSet.h for documentation.
		/// </summary>
		// Token: 0x0601D547 RID: 120135 RVA: 0x00296530 File Offset: 0x00294730
		public override void GetCellPoints(long cellId, vtkIdList ptIds)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_GetCellPoints_21(base.GetCppThis(), cellId, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		// Token: 0x0601D548 RID: 120136
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGrid_GetCellSize_22(HandleRef pThis, long cellId);

		/// <summary>
		/// Get the size of the cell with given cellId.
		/// </summary>
		// Token: 0x0601D549 RID: 120137 RVA: 0x00296560 File Offset: 0x00294760
		public override long GetCellSize(long cellId)
		{
			return vtkUnstructuredGrid.vtkUnstructuredGrid_GetCellSize_22(base.GetCppThis(), cellId);
		}

		// Token: 0x0601D54A RID: 120138
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGrid_GetCellType_23(HandleRef pThis, long cellId);

		/// <summary>
		/// Get the type of the cell with the given cellId.
		/// </summary>
		// Token: 0x0601D54B RID: 120139 RVA: 0x00296580 File Offset: 0x00294780
		public override int GetCellType(long cellId)
		{
			return vtkUnstructuredGrid.vtkUnstructuredGrid_GetCellType_23(base.GetCppThis(), cellId);
		}

		// Token: 0x0601D54C RID: 120140
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGrid_GetCellTypes_24(HandleRef pThis, HandleRef types);

		/// <summary>
		/// Get a list of types of cells in a dataset. The list consists of an array
		/// of types (not necessarily in any order), with a single entry per type.
		/// For example a dataset with 5 triangles, 3 lines, and 100 hexahedra would
		/// result in a list of three entries, corresponding to the types VTK_TRIANGLE,
		/// VTK_LINE, and VTK_HEXAHEDRON. This override implements an optimization that
		/// recomputes cell types only when the types of cells may have changed.
		///
		/// THIS METHOD IS THREAD SAFE IF FIRST CALLED FROM A SINGLE THREAD AND
		/// THE DATASET IS NOT MODIFIED
		/// </summary>
		// Token: 0x0601D54D RID: 120141 RVA: 0x002965A0 File Offset: 0x002947A0
		public override void GetCellTypes(vtkCellTypes types)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_GetCellTypes_24(base.GetCppThis(), (types == null) ? default(HandleRef) : types.GetCppThis());
		}

		// Token: 0x0601D54E RID: 120142
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGrid_GetCellTypesArray_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the array of all cell types in the grid. Each single-component
		/// tuple in the array at an index that corresponds to the type of the cell
		/// with the same index. To get an array of only the distinct cell types in
		/// the dataset, use GetCellTypes().
		/// </summary>
		// Token: 0x0601D54F RID: 120143 RVA: 0x002965D0 File Offset: 0x002947D0
		public vtkUnsignedCharArray GetCellTypesArray()
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGrid.vtkUnstructuredGrid_GetCellTypesArray_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedCharArray = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedCharArray.Register(null);
				}
			}
			return vtkUnsignedCharArray;
		}

		// Token: 0x0601D550 RID: 120144
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGrid_GetCells_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the unstructured grid connectivity array.
		/// </summary>
		// Token: 0x0601D551 RID: 120145 RVA: 0x00296640 File Offset: 0x00294840
		public vtkCellArray GetCells()
		{
			vtkCellArray vtkCellArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGrid.vtkUnstructuredGrid_GetCells_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601D552 RID: 120146
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGrid_GetData_27(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x0601D553 RID: 120147 RVA: 0x002966B0 File Offset: 0x002948B0
		public new static vtkUnstructuredGrid GetData(vtkInformation info)
		{
			vtkUnstructuredGrid vtkUnstructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGrid.vtkUnstructuredGrid_GetData_27((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGrid = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGrid.Register(null);
				}
			}
			return vtkUnstructuredGrid;
		}

		// Token: 0x0601D554 RID: 120148
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGrid_GetData_28(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x0601D555 RID: 120149 RVA: 0x00296730 File Offset: 0x00294930
		public new static vtkUnstructuredGrid GetData(vtkInformationVector v, int i)
		{
			vtkUnstructuredGrid vtkUnstructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGrid.vtkUnstructuredGrid_GetData_28((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGrid = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGrid.Register(null);
				}
			}
			return vtkUnstructuredGrid;
		}

		// Token: 0x0601D556 RID: 120150
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGrid_GetDataObjectType_29(HandleRef pThis);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601D557 RID: 120151 RVA: 0x002967B0 File Offset: 0x002949B0
		public override int GetDataObjectType()
		{
			return vtkUnstructuredGrid.vtkUnstructuredGrid_GetDataObjectType_29(base.GetCppThis());
		}

		// Token: 0x0601D558 RID: 120152
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGrid_GetDistinctCellTypesArray_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get a list of types of cells in a dataset. The list consists of an array
		/// of types (not necessarily in any order), with a single entry per type.
		/// For example a dataset with 5 triangles, 3 lines, and 100 hexahedra would
		/// result in a list of three entries, corresponding to the types VTK_TRIANGLE,
		/// VTK_LINE, and VTK_HEXAHEDRON. This override implements an optimization that
		/// recomputes cell types only when the types of cells may have changed.
		/// This method never returns `nullptr`.
		///
		/// THIS METHOD IS THREAD SAFE IF FIRST CALLED FROM A SINGLE THREAD AND
		/// THE DATASET IS NOT MODIFIED
		/// </summary>
		// Token: 0x0601D559 RID: 120153 RVA: 0x002967D0 File Offset: 0x002949D0
		public vtkUnsignedCharArray GetDistinctCellTypesArray()
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGrid.vtkUnstructuredGrid_GetDistinctCellTypesArray_30(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedCharArray = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedCharArray.Register(null);
				}
			}
			return vtkUnsignedCharArray;
		}

		// Token: 0x0601D55A RID: 120154
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGrid_GetFaceLocations_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get pointer to faces and facelocations. Support for polyhedron cells.
		/// </summary>
		// Token: 0x0601D55B RID: 120155 RVA: 0x00296840 File Offset: 0x00294A40
		public vtkIdTypeArray GetFaceLocations()
		{
			vtkIdTypeArray vtkIdTypeArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGrid.vtkUnstructuredGrid_GetFaceLocations_31(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdTypeArray = (vtkIdTypeArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdTypeArray.Register(null);
				}
			}
			return vtkIdTypeArray;
		}

		// Token: 0x0601D55C RID: 120156
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGrid_GetFaceStream_32(HandleRef pThis, long cellId, HandleRef ptIds);

		/// <summary>
		/// Get the face stream of a polyhedron cell in the following format:
		/// (numCellFaces, numFace0Pts, id1, id2, id3, numFace1Pts,id1, id2, id3, ...).
		/// If the requested cell is not a polyhedron, then the standard GetCellPoints
		/// is called to return a list of unique point ids (id1, id2, id3, ...).
		/// </summary>
		// Token: 0x0601D55D RID: 120157 RVA: 0x002968B0 File Offset: 0x00294AB0
		public void GetFaceStream(long cellId, vtkIdList ptIds)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_GetFaceStream_32(base.GetCppThis(), cellId, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		// Token: 0x0601D55E RID: 120158
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGrid_GetFaces_33(HandleRef pThis, long cellId);

		/// <summary>
		/// Special support for polyhedron. Return nullptr for all other cell types.
		/// </summary>
		// Token: 0x0601D55F RID: 120159 RVA: 0x002968E0 File Offset: 0x00294AE0
		public IntPtr GetFaces(long cellId)
		{
			return vtkUnstructuredGrid.vtkUnstructuredGrid_GetFaces_33(base.GetCppThis(), cellId);
		}

		// Token: 0x0601D560 RID: 120160
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGrid_GetFaces_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get pointer to faces and facelocations. Support for polyhedron cells.
		/// </summary>
		// Token: 0x0601D561 RID: 120161 RVA: 0x00296900 File Offset: 0x00294B00
		public vtkIdTypeArray GetFaces()
		{
			vtkIdTypeArray vtkIdTypeArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGrid.vtkUnstructuredGrid_GetFaces_34(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdTypeArray = (vtkIdTypeArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdTypeArray.Register(null);
				}
			}
			return vtkIdTypeArray;
		}

		// Token: 0x0601D562 RID: 120162
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGrid_GetGhostLevel_35(HandleRef pThis);

		/// <summary>
		/// Get the ghost level.
		/// </summary>
		// Token: 0x0601D563 RID: 120163 RVA: 0x00296970 File Offset: 0x00294B70
		public virtual int GetGhostLevel()
		{
			return vtkUnstructuredGrid.vtkUnstructuredGrid_GetGhostLevel_35(base.GetCppThis());
		}

		// Token: 0x0601D564 RID: 120164
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGrid_GetIdsOfCellsOfType_36(HandleRef pThis, int type, HandleRef array);

		/// <summary>
		/// Fill vtkIdTypeArray container with list of cell Ids.  This
		/// method traverses all cells and, for a particular cell type,
		/// inserts the cell Id into the container.
		/// </summary>
		// Token: 0x0601D565 RID: 120165 RVA: 0x00296990 File Offset: 0x00294B90
		public override void GetIdsOfCellsOfType(int type, vtkIdTypeArray array)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_GetIdsOfCellsOfType_36(base.GetCppThis(), type, (array == null) ? default(HandleRef) : array.GetCppThis());
		}

		// Token: 0x0601D566 RID: 120166
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGrid_GetLinks_37(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the links that you created possibly without using BuildLinks.
		/// </summary>
		// Token: 0x0601D567 RID: 120167 RVA: 0x002969C0 File Offset: 0x00294BC0
		public virtual vtkAbstractCellLinks GetLinks()
		{
			vtkAbstractCellLinks vtkAbstractCellLinks = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGrid.vtkUnstructuredGrid_GetLinks_37(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601D568 RID: 120168
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGrid_GetMaxCellSize_38(HandleRef pThis);

		/// <summary>
		/// Get the size, in number of points, of the largest cell.
		/// </summary>
		// Token: 0x0601D569 RID: 120169 RVA: 0x00296A30 File Offset: 0x00294C30
		public override int GetMaxCellSize()
		{
			return vtkUnstructuredGrid.vtkUnstructuredGrid_GetMaxCellSize_38(base.GetCppThis());
		}

		// Token: 0x0601D56A RID: 120170
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGrid_GetMaxSpatialDimension_39(HandleRef pThis);

		/// <summary>
		/// Get the maximum spatial dimensionality of the data
		/// which is the maximum dimension of all cells.
		/// </summary>
		// Token: 0x0601D56B RID: 120171 RVA: 0x00296A50 File Offset: 0x00294C50
		public override int GetMaxSpatialDimension()
		{
			return vtkUnstructuredGrid.vtkUnstructuredGrid_GetMaxSpatialDimension_39(base.GetCppThis());
		}

		// Token: 0x0601D56C RID: 120172
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkUnstructuredGrid_GetMeshMTime_40(HandleRef pThis);

		/// <summary>
		/// Return the mesh (geometry/topology) modification time.
		/// This time is different from the usual MTime which also takes into
		/// account the modification of data arrays. This function can be used to
		/// track the changes on the mesh separately from the data arrays
		/// (eg. static mesh over time with transient data).
		/// </summary>
		// Token: 0x0601D56D RID: 120173 RVA: 0x00296A70 File Offset: 0x00294C70
		public virtual ulong GetMeshMTime()
		{
			return vtkUnstructuredGrid.vtkUnstructuredGrid_GetMeshMTime_40(base.GetCppThis());
		}

		// Token: 0x0601D56E RID: 120174
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGrid_GetNumberOfCells_41(HandleRef pThis);

		/// <summary>
		/// Standard vtkDataSet methods; see vtkDataSet.h for documentation.
		/// </summary>
		// Token: 0x0601D56F RID: 120175 RVA: 0x00296A90 File Offset: 0x00294C90
		public override long GetNumberOfCells()
		{
			return vtkUnstructuredGrid.vtkUnstructuredGrid_GetNumberOfCells_41(base.GetCppThis());
		}

		// Token: 0x0601D570 RID: 120176
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGrid_GetNumberOfGenerationsFromBase_42(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0601D571 RID: 120177 RVA: 0x00296AB0 File Offset: 0x00294CB0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkUnstructuredGrid.vtkUnstructuredGrid_GetNumberOfGenerationsFromBase_42(base.GetCppThis(), type);
		}

		// Token: 0x0601D572 RID: 120178
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGrid_GetNumberOfGenerationsFromBaseType_43([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0601D573 RID: 120179 RVA: 0x00296AD0 File Offset: 0x00294CD0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkUnstructuredGrid.vtkUnstructuredGrid_GetNumberOfGenerationsFromBaseType_43(type);
		}

		// Token: 0x0601D574 RID: 120180
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGrid_GetNumberOfPieces_44(HandleRef pThis);

		/// <summary>
		/// Set / Get the piece and the number of pieces. Similar to extent in 3D.
		/// </summary>
		// Token: 0x0601D575 RID: 120181 RVA: 0x00296AEC File Offset: 0x00294CEC
		public virtual int GetNumberOfPieces()
		{
			return vtkUnstructuredGrid.vtkUnstructuredGrid_GetNumberOfPieces_44(base.GetCppThis());
		}

		// Token: 0x0601D576 RID: 120182
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGrid_GetPiece_45(HandleRef pThis);

		/// <summary>
		/// Set / Get the piece and the number of pieces. Similar to extent in 3D.
		/// </summary>
		// Token: 0x0601D577 RID: 120183 RVA: 0x00296B0C File Offset: 0x00294D0C
		public virtual int GetPiece()
		{
			return vtkUnstructuredGrid.vtkUnstructuredGrid_GetPiece_45(base.GetCppThis());
		}

		// Token: 0x0601D578 RID: 120184
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGrid_GetPointCells_46(HandleRef pThis, long ptId, HandleRef cellIds);

		/// <summary>
		/// Standard vtkDataSet methods; see vtkDataSet.h for documentation.
		/// </summary>
		// Token: 0x0601D579 RID: 120185 RVA: 0x00296B2C File Offset: 0x00294D2C
		public override void GetPointCells(long ptId, vtkIdList cellIds)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_GetPointCells_46(base.GetCppThis(), ptId, (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis());
		}

		// Token: 0x0601D57A RID: 120186
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGrid_Initialize_47(HandleRef pThis);

		/// <summary>
		/// Reset the grid to an empty state and free any memory.
		/// </summary>
		// Token: 0x0601D57B RID: 120187 RVA: 0x00296B5C File Offset: 0x00294D5C
		public override void Initialize()
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_Initialize_47(base.GetCppThis());
		}

		// Token: 0x0601D57C RID: 120188
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGrid_InitializeFacesRepresentation_48(HandleRef pThis, long numPrevCells);

		/// <summary>
		/// Special function used by vtkUnstructuredGridReader.
		/// By default vtkUnstructuredGrid does not contain face information, which is
		/// only used by polyhedron cells. If so far no polyhedron cells have been
		/// added, Faces and FaceLocations pointers will be nullptr. In this case, need to
		/// initialize the arrays and assign values to the previous non-polyhedron cells.
		/// </summary>
		// Token: 0x0601D57D RID: 120189 RVA: 0x00296B6C File Offset: 0x00294D6C
		public int InitializeFacesRepresentation(long numPrevCells)
		{
			return vtkUnstructuredGrid.vtkUnstructuredGrid_InitializeFacesRepresentation_48(base.GetCppThis(), numPrevCells);
		}

		// Token: 0x0601D57E RID: 120190
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGrid_InsertNextLinkedCell_49(HandleRef pThis, int type, int npts, IntPtr pts);

		/// <summary>
		/// Use these methods only if the dataset has been specified as
		/// Editable. See vtkPointSet for more information.
		/// </summary>
		// Token: 0x0601D57F RID: 120191 RVA: 0x00296B8C File Offset: 0x00294D8C
		public long InsertNextLinkedCell(int type, int npts, IntPtr pts)
		{
			return vtkUnstructuredGrid.vtkUnstructuredGrid_InsertNextLinkedCell_49(base.GetCppThis(), type, npts, pts);
		}

		// Token: 0x0601D580 RID: 120192
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGrid_IsA_50(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0601D581 RID: 120193 RVA: 0x00296BB0 File Offset: 0x00294DB0
		public override int IsA(string type)
		{
			return vtkUnstructuredGrid.vtkUnstructuredGrid_IsA_50(base.GetCppThis(), type);
		}

		// Token: 0x0601D582 RID: 120194
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkUnstructuredGrid_IsCellBoundary_51(HandleRef pThis, long cellId, long npts, IntPtr ptIds, ref long neighborCellId);

		/// <summary>
		/// A topological inquiry to determine whether a topological entity (e.g.,
		/// point, edge, or face) defined by the point ids (ptIds of length npts) is
		/// a boundary entity of a specified cell (indicated by cellId). A boundary
		/// entity is a topological feature used by exactly one cell. This method is
		/// related to GetCellNeighbors() except that it simply indicates whether a
		/// topological feature is boundary - hence the method is faster.
		/// THIS METHOD IS THREAD SAFE IF FIRST CALLED FROM A
		/// SINGLE THREAD AND THE DATASET IS NOT MODIFIED.
		/// </summary>
		// Token: 0x0601D583 RID: 120195 RVA: 0x00296BD0 File Offset: 0x00294DD0
		public bool IsCellBoundary(long cellId, long npts, IntPtr ptIds, ref long neighborCellId)
		{
			return vtkUnstructuredGrid.vtkUnstructuredGrid_IsCellBoundary_51(base.GetCppThis(), cellId, npts, ptIds, ref neighborCellId) != 0;
		}

		// Token: 0x0601D584 RID: 120196
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkUnstructuredGrid_IsCellBoundary_52(HandleRef pThis, long cellId, long npts, IntPtr ptIds);

		/// <summary>
		/// A topological inquiry to determine whether a topological entity (e.g.,
		/// point, edge, or face) defined by the point ids (ptIds of length npts) is
		/// a boundary entity of a specified cell (indicated by cellId). A boundary
		/// entity is a topological feature used by exactly one cell. This method is
		/// related to GetCellNeighbors() except that it simply indicates whether a
		/// topological feature is boundary - hence the method is faster.
		/// THIS METHOD IS THREAD SAFE IF FIRST CALLED FROM A
		/// SINGLE THREAD AND THE DATASET IS NOT MODIFIED.
		/// </summary>
		// Token: 0x0601D585 RID: 120197 RVA: 0x00296BFC File Offset: 0x00294DFC
		public bool IsCellBoundary(long cellId, long npts, IntPtr ptIds)
		{
			return vtkUnstructuredGrid.vtkUnstructuredGrid_IsCellBoundary_52(base.GetCppThis(), cellId, npts, ptIds) != 0;
		}

		// Token: 0x0601D586 RID: 120198
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGrid_IsHomogeneous_53(HandleRef pThis);

		/// <summary>
		/// Returns whether cells are all of the same type.
		/// </summary>
		// Token: 0x0601D587 RID: 120199 RVA: 0x00296C28 File Offset: 0x00294E28
		public override int IsHomogeneous()
		{
			return vtkUnstructuredGrid.vtkUnstructuredGrid_IsHomogeneous_53(base.GetCppThis());
		}

		// Token: 0x0601D588 RID: 120200
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGrid_IsTypeOf_54([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0601D589 RID: 120201 RVA: 0x00296C48 File Offset: 0x00294E48
		public new static int IsTypeOf(string type)
		{
			return vtkUnstructuredGrid.vtkUnstructuredGrid_IsTypeOf_54(type);
		}

		// Token: 0x0601D58A RID: 120202
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGrid_NewCellIterator_56(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard vtkDataSet methods; see vtkDataSet.h for documentation.
		/// </summary>
		// Token: 0x0601D58B RID: 120203 RVA: 0x00296C64 File Offset: 0x00294E64
		public override vtkCellIterator NewCellIterator()
		{
			vtkCellIterator vtkCellIterator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGrid.vtkUnstructuredGrid_NewCellIterator_56(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellIterator = (vtkCellIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellIterator.Register(null);
				}
			}
			return vtkCellIterator;
		}

		// Token: 0x0601D58C RID: 120204
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGrid_NewInstance_57(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0601D58D RID: 120205 RVA: 0x00296CD4 File Offset: 0x00294ED4
		public new vtkUnstructuredGrid NewInstance()
		{
			vtkUnstructuredGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGrid.vtkUnstructuredGrid_NewInstance_57(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601D58E RID: 120206
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGrid_RemoveGhostCells_58(HandleRef pThis);

		/// <summary>
		/// This method will remove any cell that is marked as ghost
		/// (has the vtkDataSetAttributes::DUPLICATECELL or
		/// the vtkDataSetAttributes::HIDDENCELL bit set).
		/// </summary>
		// Token: 0x0601D58F RID: 120207 RVA: 0x00296D2E File Offset: 0x00294F2E
		public void RemoveGhostCells()
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_RemoveGhostCells_58(base.GetCppThis());
		}

		// Token: 0x0601D590 RID: 120208
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGrid_RemoveReferenceToCell_59(HandleRef pThis, long ptId, long cellId);

		/// <summary>
		/// Use these methods only if the dataset has been specified as
		/// Editable. See vtkPointSet for more information.
		/// </summary>
		// Token: 0x0601D591 RID: 120209 RVA: 0x00296D3D File Offset: 0x00294F3D
		public void RemoveReferenceToCell(long ptId, long cellId)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_RemoveReferenceToCell_59(base.GetCppThis(), ptId, cellId);
		}

		// Token: 0x0601D592 RID: 120210
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGrid_Reset_60(HandleRef pThis);

		/// <summary>
		/// Standard vtkDataSet methods; see vtkDataSet.h for documentation.
		/// </summary>
		// Token: 0x0601D593 RID: 120211 RVA: 0x00296D4E File Offset: 0x00294F4E
		public void Reset()
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_Reset_60(base.GetCppThis());
		}

		// Token: 0x0601D594 RID: 120212
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGrid_ResizeCellList_61(HandleRef pThis, long ptId, int size);

		/// <summary>
		/// Use these methods only if the dataset has been specified as
		/// Editable. See vtkPointSet for more information.
		/// </summary>
		// Token: 0x0601D595 RID: 120213 RVA: 0x00296D5D File Offset: 0x00294F5D
		public void ResizeCellList(long ptId, int size)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_ResizeCellList_61(base.GetCppThis(), ptId, size);
		}

		// Token: 0x0601D596 RID: 120214
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGrid_SafeDownCast_62(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0601D597 RID: 120215 RVA: 0x00296D70 File Offset: 0x00294F70
		public new static vtkUnstructuredGrid SafeDownCast(vtkObjectBase o)
		{
			vtkUnstructuredGrid vtkUnstructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGrid.vtkUnstructuredGrid_SafeDownCast_62((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGrid = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGrid.Register(null);
				}
			}
			return vtkUnstructuredGrid;
		}

		// Token: 0x0601D598 RID: 120216
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGrid_SetCells_63(HandleRef pThis, int type, HandleRef cells);

		/// <summary>
		/// Provide cell information to define the dataset.
		///
		/// Cells like vtkPolyhedron require points plus a list of faces. To handle
		/// vtkPolyhedron, SetCells() support a special input cellConnectivities format
		/// (numCellFaces, numFace0Pts, id1, id2, id3, numFace1Pts,id1, id2, id3, ...)
		/// The functions use vtkPolyhedron::DecomposeAPolyhedronCell() to convert
		/// polyhedron cells into standard format.
		/// </summary>
		// Token: 0x0601D599 RID: 120217 RVA: 0x00296DF0 File Offset: 0x00294FF0
		public void SetCells(int type, vtkCellArray cells)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_SetCells_63(base.GetCppThis(), type, (cells == null) ? default(HandleRef) : cells.GetCppThis());
		}

		// Token: 0x0601D59A RID: 120218
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGrid_SetCells_64(HandleRef pThis, IntPtr types, HandleRef cells);

		/// <summary>
		/// Provide cell information to define the dataset.
		///
		/// Cells like vtkPolyhedron require points plus a list of faces. To handle
		/// vtkPolyhedron, SetCells() support a special input cellConnectivities format
		/// (numCellFaces, numFace0Pts, id1, id2, id3, numFace1Pts,id1, id2, id3, ...)
		/// The functions use vtkPolyhedron::DecomposeAPolyhedronCell() to convert
		/// polyhedron cells into standard format.
		/// </summary>
		// Token: 0x0601D59B RID: 120219 RVA: 0x00296E20 File Offset: 0x00295020
		public void SetCells(IntPtr types, vtkCellArray cells)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_SetCells_64(base.GetCppThis(), types, (cells == null) ? default(HandleRef) : cells.GetCppThis());
		}

		// Token: 0x0601D59C RID: 120220
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGrid_SetCells_65(HandleRef pThis, HandleRef cellTypes, HandleRef cells);

		/// <summary>
		/// Provide cell information to define the dataset.
		///
		/// Cells like vtkPolyhedron require points plus a list of faces. To handle
		/// vtkPolyhedron, SetCells() support a special input cellConnectivities format
		/// (numCellFaces, numFace0Pts, id1, id2, id3, numFace1Pts,id1, id2, id3, ...)
		/// The functions use vtkPolyhedron::DecomposeAPolyhedronCell() to convert
		/// polyhedron cells into standard format.
		/// </summary>
		// Token: 0x0601D59D RID: 120221 RVA: 0x00296E50 File Offset: 0x00295050
		public void SetCells(vtkUnsignedCharArray cellTypes, vtkCellArray cells)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_SetCells_65(base.GetCppThis(), (cellTypes == null) ? default(HandleRef) : cellTypes.GetCppThis(), (cells == null) ? default(HandleRef) : cells.GetCppThis());
		}

		// Token: 0x0601D59E RID: 120222
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGrid_SetCells_66(HandleRef pThis, HandleRef cellTypes, HandleRef cells, HandleRef faceLocations, HandleRef faces);

		/// <summary>
		/// Provide cell information to define the dataset.
		///
		/// Cells like vtkPolyhedron require points plus a list of faces. To handle
		/// vtkPolyhedron, SetCells() support a special input cellConnectivities format
		/// (numCellFaces, numFace0Pts, id1, id2, id3, numFace1Pts,id1, id2, id3, ...)
		/// The functions use vtkPolyhedron::DecomposeAPolyhedronCell() to convert
		/// polyhedron cells into standard format.
		/// </summary>
		// Token: 0x0601D59F RID: 120223 RVA: 0x00296E94 File Offset: 0x00295094
		public void SetCells(vtkUnsignedCharArray cellTypes, vtkCellArray cells, vtkIdTypeArray faceLocations, vtkIdTypeArray faces)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_SetCells_66(base.GetCppThis(), (cellTypes == null) ? default(HandleRef) : cellTypes.GetCppThis(), (cells == null) ? default(HandleRef) : cells.GetCppThis(), (faceLocations == null) ? default(HandleRef) : faceLocations.GetCppThis(), (faces == null) ? default(HandleRef) : faces.GetCppThis());
		}

		// Token: 0x0601D5A0 RID: 120224
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGrid_SetCells_67(HandleRef pThis, HandleRef cellTypes, HandleRef cellLocations, HandleRef cells);

		/// <summary>
		/// Special methods specific to vtkUnstructuredGrid for defining the cells
		/// composing the dataset. Most cells require just arrays of cellTypes,
		/// cellLocations and cellConnectivities which implicitly define the set of
		/// points in each cell and their ordering. In those cases the
		/// cellConnectivities are of the format
		/// (numFace0Pts, id1, id2, id3, numFace1Pts, id1, id2, id3...). However, some
		/// cells like vtkPolyhedron require points plus a list of faces. To handle
		/// vtkPolyhedron, SetCells() support a special input cellConnectivities format
		/// (numCellFaces, numFace0Pts, id1, id2, id3, numFace1Pts,id1, id2, id3, ...)
		/// The functions use vtkPolyhedron::DecomposeAPolyhedronCell() to convert
		/// polyhedron cells into standard format.
		///
		/// @warning The cellLocations array is no longer used; this information
		/// is stored in vtkCellArray. Use the other SetCells overloads.
		/// </summary>
		// Token: 0x0601D5A1 RID: 120225 RVA: 0x00296F04 File Offset: 0x00295104
		public void SetCells(vtkUnsignedCharArray cellTypes, vtkIdTypeArray cellLocations, vtkCellArray cells)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_SetCells_67(base.GetCppThis(), (cellTypes == null) ? default(HandleRef) : cellTypes.GetCppThis(), (cellLocations == null) ? default(HandleRef) : cellLocations.GetCppThis(), (cells == null) ? default(HandleRef) : cells.GetCppThis());
		}

		// Token: 0x0601D5A2 RID: 120226
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGrid_SetCells_68(HandleRef pThis, HandleRef cellTypes, HandleRef cellLocations, HandleRef cells, HandleRef faceLocations, HandleRef faces);

		/// <summary>
		/// Special methods specific to vtkUnstructuredGrid for defining the cells
		/// composing the dataset. Most cells require just arrays of cellTypes,
		/// cellLocations and cellConnectivities which implicitly define the set of
		/// points in each cell and their ordering. In those cases the
		/// cellConnectivities are of the format
		/// (numFace0Pts, id1, id2, id3, numFace1Pts, id1, id2, id3...). However, some
		/// cells like vtkPolyhedron require points plus a list of faces. To handle
		/// vtkPolyhedron, SetCells() support a special input cellConnectivities format
		/// (numCellFaces, numFace0Pts, id1, id2, id3, numFace1Pts,id1, id2, id3, ...)
		/// The functions use vtkPolyhedron::DecomposeAPolyhedronCell() to convert
		/// polyhedron cells into standard format.
		///
		/// @warning The cellLocations array is no longer used; this information
		/// is stored in vtkCellArray. Use the other SetCells overloads.
		/// </summary>
		// Token: 0x0601D5A3 RID: 120227 RVA: 0x00296F60 File Offset: 0x00295160
		public void SetCells(vtkUnsignedCharArray cellTypes, vtkIdTypeArray cellLocations, vtkCellArray cells, vtkIdTypeArray faceLocations, vtkIdTypeArray faces)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_SetCells_68(base.GetCppThis(), (cellTypes == null) ? default(HandleRef) : cellTypes.GetCppThis(), (cellLocations == null) ? default(HandleRef) : cellLocations.GetCppThis(), (cells == null) ? default(HandleRef) : cells.GetCppThis(), (faceLocations == null) ? default(HandleRef) : faceLocations.GetCppThis(), (faces == null) ? default(HandleRef) : faces.GetCppThis());
		}

		// Token: 0x0601D5A4 RID: 120228
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGrid_SetLinks_69(HandleRef pThis, HandleRef _arg);

		/// <summary>
		/// Set/Get the links that you created possibly without using BuildLinks.
		/// </summary>
		// Token: 0x0601D5A5 RID: 120229 RVA: 0x00296FE8 File Offset: 0x002951E8
		public virtual void SetLinks(vtkAbstractCellLinks _arg)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_SetLinks_69(base.GetCppThis(), (_arg == null) ? default(HandleRef) : _arg.GetCppThis());
		}

		// Token: 0x0601D5A6 RID: 120230
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGrid_ShallowCopy_70(HandleRef pThis, HandleRef src);

		/// <summary>
		/// Shallow and Deep copy.
		/// </summary>
		// Token: 0x0601D5A7 RID: 120231 RVA: 0x00297018 File Offset: 0x00295218
		public override void ShallowCopy(vtkDataObject src)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_ShallowCopy_70(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		// Token: 0x0601D5A8 RID: 120232
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGrid_Squeeze_71(HandleRef pThis);

		/// <summary>
		/// Squeeze all arrays in the grid to conserve memory.
		/// </summary>
		// Token: 0x0601D5A9 RID: 120233 RVA: 0x00297047 File Offset: 0x00295247
		public override void Squeeze()
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_Squeeze_71(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EE3 RID: 7907
		public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGrid";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EE4 RID: 7908
		public new static readonly string MRClassNameKey = "class vtkUnstructuredGrid";
	}
}
