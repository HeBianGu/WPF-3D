using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCellArray
	/// </summary>
	/// <remarks>
	///    object to represent cell connectivity
	///
	/// vtkCellArray stores dataset topologies as an explicit connectivity table
	/// listing the point ids that make up each cell.
	///
	/// Internally, the connectivity table is represented as two arrays: Offsets and
	/// Connectivity.
	///
	/// Offsets is an array of [numCells+1] values indicating the index in the
	/// Connectivity array where each cell's points start. The last value is always
	/// the length of the Connectivity array.
	///
	/// The Connectivity array stores the lists of point ids for each cell.
	///
	/// Thus, for a dataset consisting of 2 triangles, a quad, and a line, the
	/// internal arrays will appear as follows:
	///
	/// ```
	/// Topology:
	/// ---------
	/// Cell 0: Triangle | point ids: {0, 1, 2}
	/// Cell 1: Triangle | point ids: {5, 7, 2}
	/// Cell 2: Quad     | point ids: {3, 4, 6, 7}
	/// Cell 4: Line     | point ids: {5, 8}
	///
	/// vtkCellArray (current):
	/// -----------------------
	/// Offsets:      {0, 3, 6, 10, 12}
	/// Connectivity: {0, 1, 2, 5, 7, 2, 3, 4, 6, 7, 5, 8}
	/// ```
	///
	/// While this class provides traversal methods (the legacy InitTraversal(),
	/// GetNextCell() methods, and the newer method GetCellAtId()) these are in
	/// general not thread-safe. Whenever possible it is preferable to use a
	/// local thread-safe, vtkCellArrayIterator object, which can be obtained via:
	///
	/// ```
	/// auto iter = vtk::TakeSmartPointer(cellArray-&gt;NewIterator());
	/// for (iter-&gt;GoToFirstCell(); !iter-&gt;IsDoneWithTraversal(); iter-&gt;GoToNextCell())
	/// {
	///   // do work with iter
	/// }
	/// ```
	/// (Note however that depending on the type and structure of internal
	/// storage, a cell array iterator may be significantly slower than direct
	/// traversal over the cell array due to extra data copying. Factors of 3-4X
	/// are not uncommon. See vtkCellArrayIterator for more information. Also note
	/// that an iterator may become invalid if the internal vtkCellArray storage
	/// is modified.)
	///
	/// Other methods are also available for allocation and memory-related
	/// management; insertion of new cells into the vtkCellArray; and limited
	/// editing operations such as replacing one cell with a new cell of the
	/// same size.
	///
	/// The internal arrays may store either 32- or 64-bit values, though most of
	/// the API will prefer to use vtkIdType to refer to items in these
	/// arrays. This enables significant memory savings when vtkIdType is 64-bit,
	/// but 32 bits are sufficient to store all of the values in the connectivity
	/// table. Using 64-bit storage with a 32-bit vtkIdType is permitted, but
	/// values too large to fit in a 32-bit signed integer will be truncated when
	/// accessed through the API. (The particular internal storage type has
	/// implications on performance depending on vtkIdType. If the internal
	/// storage is equivalent to vtkIdType, then methods that return pointers to
	/// arrays of point ids can share the internal storage; otherwise a copy of
	/// internal memory must be performed.)
	///
	/// Methods for managing the storage type are:
	///
	/// - `bool IsStorage64Bit()`
	/// - `bool IsStorageShareable() // Can pointers to internal storage be shared`
	/// - `void Use32BitStorage()`
	/// - `void Use64BitStorage()`
	/// - `void UseDefaultStorage() // Depends on vtkIdType`
	/// - `bool CanConvertTo32BitStorage()`
	/// - `bool CanConvertTo64BitStorage()`
	/// - `bool CanConvertToDefaultStorage() // Depends on vtkIdType`
	/// - `bool ConvertTo32BitStorage()`
	/// - `bool ConvertTo64BitStorage()`
	/// - `bool ConvertToDefaultStorage() // Depends on vtkIdType`
	/// - `bool ConvertToSmallestStorage() // Depends on current values in arrays`
	///
	/// Note that some legacy methods are still available that reflect the
	/// previous storage format of this data, which embedded the cell sizes into
	/// the Connectivity array:
	///
	/// ```
	/// vtkCellArray (legacy):
	/// ----------------------
	/// Connectivity: {3, 0, 1, 2, 3, 5, 7, 2, 4, 3, 4, 6, 7, 2, 5, 8}
	///                |--Cell 0--||--Cell 1--||----Cell 2---||--C3-|
	/// ```
	///
	/// The methods require an external lookup table to allow random access, which
	/// was historically stored in the vtkCellTypes object. The following methods in
	/// vtkCellArray still support this style of indexing for compatibility
	/// purposes, but these are slow as they must perform some complex computations
	/// to convert the old "location" into the new "offset" and should be avoided.
	/// These methods (and their modern equivalents) are:
	///
	/// - GetCell (Prefer GetCellAtId)
	/// - GetInsertLocation (Prefer GetNumberOfCells)
	/// - GetTraversalLocation (Prefer GetTraversalCellId, or better, NewIterator)
	/// - SetTraversalLocation (Prefer SetTraversalLocation, or better, NewIterator)
	/// - ReverseCell (Prefer ReverseCellAtId)
	/// - ReplaceCell (Prefer ReplaceCellAtId)
	/// - SetCells (Use ImportLegacyFormat, or SetData)
	/// - GetData (Use ExportLegacyFormat, or Get[Offsets|Connectivity]Array[|32|64])
	///
	/// Some other legacy methods were completely removed, such as GetPointer() /
	/// WritePointer(), since they are cannot be effectively emulated under the
	/// current design. If external code needs to support both the old and new
	/// version of the vtkCellArray API, the VTK_CELL_ARRAY_V2 preprocessor
	/// definition may be used to detect which API is being compiled against.
	///
	/// </remarks>
	/// <seealso>
	///  vtkCellTypes vtkCellLinks
	/// </seealso>
	// Token: 0x02000A13 RID: 2579
	public class vtkCellArray : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601AD62 RID: 109922 RVA: 0x0025650F File Offset: 0x0025470F
		static vtkCellArray()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellArray"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601AD63 RID: 109923 RVA: 0x00256537 File Offset: 0x00254737
		public vtkCellArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601AD64 RID: 109924
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and
		/// printing.
		/// </summary>
		// Token: 0x0601AD65 RID: 109925 RVA: 0x00256548 File Offset: 0x00254748
		public new static vtkCellArray New()
		{
			vtkCellArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellArray.vtkCellArray_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, type information, and
		/// printing.
		/// </summary>
		// Token: 0x0601AD66 RID: 109926 RVA: 0x0025659C File Offset: 0x0025479C
		public vtkCellArray() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCellArray.vtkCellArray_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601AD67 RID: 109927 RVA: 0x002565E0 File Offset: 0x002547E0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601AD68 RID: 109928
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellArray_Allocate_01(HandleRef pThis, long sz, long arg1);

		/// <summary>
		/// Allocate memory.
		///
		/// This currently allocates both the offsets and connectivity arrays to @a sz.
		///
		/// @note It is preferable to use AllocateEstimate(numCells, maxCellSize)
		/// or AllocateExact(numCells, connectivitySize) instead.
		/// </summary>
		// Token: 0x0601AD69 RID: 109929 RVA: 0x002565EC File Offset: 0x002547EC
		public int Allocate(long sz, long arg1)
		{
			return vtkCellArray.vtkCellArray_Allocate_01(base.GetCppThis(), sz, arg1);
		}

		// Token: 0x0601AD6A RID: 109930
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCellArray_AllocateCopy_02(HandleRef pThis, HandleRef other);

		/// <summary>
		/// @brief Pre-allocate memory in internal data structures to match the used
		/// size of the input vtkCellArray. Does not change
		/// the number of cells, only the array capacities. Existing data is NOT
		/// preserved.
		/// @param other The vtkCellArray to use as a reference.
		/// @return True if allocation succeeds.
		/// @sa Squeeze AllocateEstimate AllocateExact
		/// </summary>
		// Token: 0x0601AD6B RID: 109931 RVA: 0x00256610 File Offset: 0x00254810
		public bool AllocateCopy(vtkCellArray other)
		{
			return vtkCellArray.vtkCellArray_AllocateCopy_02(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis()) != 0;
		}

		// Token: 0x0601AD6C RID: 109932
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCellArray_AllocateEstimate_03(HandleRef pThis, long numCells, long maxCellSize);

		/// <summary>
		/// @brief Pre-allocate memory in internal data structures. Does not change
		/// the number of cells, only the array capacities. Existing data is NOT
		/// preserved.
		/// @param numCells The number of expected cells in the dataset.
		/// @param maxCellSize The number of points per cell to allocate memory for.
		/// @return True if allocation succeeds.
		/// @sa Squeeze AllocateExact AllocateCopy
		/// </summary>
		// Token: 0x0601AD6D RID: 109933 RVA: 0x0025664C File Offset: 0x0025484C
		public bool AllocateEstimate(long numCells, long maxCellSize)
		{
			return vtkCellArray.vtkCellArray_AllocateEstimate_03(base.GetCppThis(), numCells, maxCellSize) != 0;
		}

		// Token: 0x0601AD6E RID: 109934
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCellArray_AllocateExact_04(HandleRef pThis, long numCells, long connectivitySize);

		/// <summary>
		/// @brief Pre-allocate memory in internal data structures. Does not change
		/// the number of cells, only the array capacities. Existing data is NOT
		/// preserved.
		/// @param numCells The number of expected cells in the dataset.
		/// @param connectivitySize The total number of pointIds stored for all cells.
		/// @return True if allocation succeeds.
		/// @sa Squeeze AllocateEstimate AllocateCopy
		/// </summary>
		// Token: 0x0601AD6F RID: 109935 RVA: 0x00256674 File Offset: 0x00254874
		public bool AllocateExact(long numCells, long connectivitySize)
		{
			return vtkCellArray.vtkCellArray_AllocateExact_04(base.GetCppThis(), numCells, connectivitySize) != 0;
		}

		// Token: 0x0601AD70 RID: 109936
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellArray_Append_05(HandleRef pThis, HandleRef src, long pointOffset);

		/// <summary>
		/// Append cells from src into this. Point ids are offset by @a pointOffset.
		/// </summary>
		// Token: 0x0601AD71 RID: 109937 RVA: 0x0025669C File Offset: 0x0025489C
		public void Append(vtkCellArray src, long pointOffset)
		{
			vtkCellArray.vtkCellArray_Append_05(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis(), pointOffset);
		}

		// Token: 0x0601AD72 RID: 109938
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellArray_AppendLegacyFormat_06(HandleRef pThis, HandleRef data, long ptOffset);

		/// <summary>
		/// Append an array of data with the legacy vtkCellArray layout, e.g.:
		///
		/// ```
		/// { n0, p0_0, p0_1, ..., p0_n, n1, p1_0, p1_1, ..., p1_n, ... }
		/// ```
		///
		/// where `n0` is the number of points in cell 0, and `pX_Y` is the Y'th point
		/// in cell X.
		/// @{
		/// </summary>
		// Token: 0x0601AD73 RID: 109939 RVA: 0x002566CC File Offset: 0x002548CC
		public void AppendLegacyFormat(vtkIdTypeArray data, long ptOffset)
		{
			vtkCellArray.vtkCellArray_AppendLegacyFormat_06(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), ptOffset);
		}

		// Token: 0x0601AD74 RID: 109940
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellArray_AppendLegacyFormat_07(HandleRef pThis, IntPtr data, long len, long ptOffset);

		/// <summary>
		/// Append an array of data with the legacy vtkCellArray layout, e.g.:
		///
		/// ```
		/// { n0, p0_0, p0_1, ..., p0_n, n1, p1_0, p1_1, ..., p1_n, ... }
		/// ```
		///
		/// where `n0` is the number of points in cell 0, and `pX_Y` is the Y'th point
		/// in cell X.
		/// @{
		/// </summary>
		// Token: 0x0601AD75 RID: 109941 RVA: 0x002566FC File Offset: 0x002548FC
		public void AppendLegacyFormat(IntPtr data, long len, long ptOffset)
		{
			vtkCellArray.vtkCellArray_AppendLegacyFormat_07(base.GetCppThis(), data, len, ptOffset);
		}

		// Token: 0x0601AD76 RID: 109942
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCellArray_CanConvertTo32BitStorage_08(HandleRef pThis);

		/// <summary>
		/// Check if the existing data can safely be converted to use 32- or 64- bit
		/// storage. Ensures that all values can be converted to the target storage
		/// without truncating.
		/// If selecting default storage, the storage depends on the VTK_USE_64BIT_IDS
		/// setting.
		/// @{
		/// </summary>
		// Token: 0x0601AD77 RID: 109943 RVA: 0x00256710 File Offset: 0x00254910
		public bool CanConvertTo32BitStorage()
		{
			return vtkCellArray.vtkCellArray_CanConvertTo32BitStorage_08(base.GetCppThis()) != 0;
		}

		// Token: 0x0601AD78 RID: 109944
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCellArray_CanConvertTo64BitStorage_09(HandleRef pThis);

		/// <summary>
		/// Check if the existing data can safely be converted to use 32- or 64- bit
		/// storage. Ensures that all values can be converted to the target storage
		/// without truncating.
		/// If selecting default storage, the storage depends on the VTK_USE_64BIT_IDS
		/// setting.
		/// @{
		/// </summary>
		// Token: 0x0601AD79 RID: 109945 RVA: 0x00256738 File Offset: 0x00254938
		public bool CanConvertTo64BitStorage()
		{
			return vtkCellArray.vtkCellArray_CanConvertTo64BitStorage_09(base.GetCppThis()) != 0;
		}

		// Token: 0x0601AD7A RID: 109946
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCellArray_CanConvertToDefaultStorage_10(HandleRef pThis);

		/// <summary>
		/// Check if the existing data can safely be converted to use 32- or 64- bit
		/// storage. Ensures that all values can be converted to the target storage
		/// without truncating.
		/// If selecting default storage, the storage depends on the VTK_USE_64BIT_IDS
		/// setting.
		/// @{
		/// </summary>
		// Token: 0x0601AD7B RID: 109947 RVA: 0x00256760 File Offset: 0x00254960
		public bool CanConvertToDefaultStorage()
		{
			return vtkCellArray.vtkCellArray_CanConvertToDefaultStorage_10(base.GetCppThis()) != 0;
		}

		// Token: 0x0601AD7C RID: 109948
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCellArray_ConvertTo32BitStorage_11(HandleRef pThis);

		/// <summary>
		/// Convert internal data structures to use 32- or 64-bit storage.
		///
		/// If selecting default storage, the storage depends on the VTK_USE_64BIT_IDS
		/// setting.
		///
		/// If selecting smallest storage, the data is checked to see what the smallest
		/// safe storage for the existing data is, and then converts to it.
		///
		/// Existing data is preserved.
		///
		/// @return True on success, false on failure. If this algorithm fails, the
		/// cell array will be in an unspecified state.
		///
		/// @{
		/// </summary>
		// Token: 0x0601AD7D RID: 109949 RVA: 0x00256788 File Offset: 0x00254988
		public bool ConvertTo32BitStorage()
		{
			return vtkCellArray.vtkCellArray_ConvertTo32BitStorage_11(base.GetCppThis()) != 0;
		}

		// Token: 0x0601AD7E RID: 109950
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCellArray_ConvertTo64BitStorage_12(HandleRef pThis);

		/// <summary>
		/// Convert internal data structures to use 32- or 64-bit storage.
		///
		/// If selecting default storage, the storage depends on the VTK_USE_64BIT_IDS
		/// setting.
		///
		/// If selecting smallest storage, the data is checked to see what the smallest
		/// safe storage for the existing data is, and then converts to it.
		///
		/// Existing data is preserved.
		///
		/// @return True on success, false on failure. If this algorithm fails, the
		/// cell array will be in an unspecified state.
		///
		/// @{
		/// </summary>
		// Token: 0x0601AD7F RID: 109951 RVA: 0x002567B0 File Offset: 0x002549B0
		public bool ConvertTo64BitStorage()
		{
			return vtkCellArray.vtkCellArray_ConvertTo64BitStorage_12(base.GetCppThis()) != 0;
		}

		// Token: 0x0601AD80 RID: 109952
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCellArray_ConvertToDefaultStorage_13(HandleRef pThis);

		/// <summary>
		/// Convert internal data structures to use 32- or 64-bit storage.
		///
		/// If selecting default storage, the storage depends on the VTK_USE_64BIT_IDS
		/// setting.
		///
		/// If selecting smallest storage, the data is checked to see what the smallest
		/// safe storage for the existing data is, and then converts to it.
		///
		/// Existing data is preserved.
		///
		/// @return True on success, false on failure. If this algorithm fails, the
		/// cell array will be in an unspecified state.
		///
		/// @{
		/// </summary>
		// Token: 0x0601AD81 RID: 109953 RVA: 0x002567D8 File Offset: 0x002549D8
		public bool ConvertToDefaultStorage()
		{
			return vtkCellArray.vtkCellArray_ConvertToDefaultStorage_13(base.GetCppThis()) != 0;
		}

		// Token: 0x0601AD82 RID: 109954
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCellArray_ConvertToSmallestStorage_14(HandleRef pThis);

		/// <summary>
		/// Convert internal data structures to use 32- or 64-bit storage.
		///
		/// If selecting default storage, the storage depends on the VTK_USE_64BIT_IDS
		/// setting.
		///
		/// If selecting smallest storage, the data is checked to see what the smallest
		/// safe storage for the existing data is, and then converts to it.
		///
		/// Existing data is preserved.
		///
		/// @return True on success, false on failure. If this algorithm fails, the
		/// cell array will be in an unspecified state.
		///
		/// @{
		/// </summary>
		// Token: 0x0601AD83 RID: 109955 RVA: 0x00256800 File Offset: 0x00254A00
		public bool ConvertToSmallestStorage()
		{
			return vtkCellArray.vtkCellArray_ConvertToSmallestStorage_14(base.GetCppThis()) != 0;
		}

		// Token: 0x0601AD84 RID: 109956
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellArray_DeepCopy_15(HandleRef pThis, HandleRef ca);

		/// <summary>
		/// Perform a deep copy (no reference counting) of the given cell array.
		/// </summary>
		// Token: 0x0601AD85 RID: 109957 RVA: 0x00256828 File Offset: 0x00254A28
		public void DeepCopy(vtkCellArray ca)
		{
			vtkCellArray.vtkCellArray_DeepCopy_15(base.GetCppThis(), (ca == null) ? default(HandleRef) : ca.GetCppThis());
		}

		// Token: 0x0601AD86 RID: 109958
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellArray_EstimateSize_16(HandleRef pThis, long numCells, int maxPtsPerCell);

		/// <summary>
		/// Utility routines help manage memory of cell array. EstimateSize()
		/// returns a value used to initialize and allocate memory for array based
		/// on number of cells and maximum number of points making up cell.  If
		/// every cell is the same size (in terms of number of points), then the
		/// memory estimate is guaranteed exact. (If not exact, use Squeeze() to
		/// reclaim any extra memory.)
		///
		/// @note This method was often misused (e.g. called alone and then
		/// discarding the result). Use AllocateEstimate directly instead.
		/// </summary>
		// Token: 0x0601AD87 RID: 109959 RVA: 0x00256858 File Offset: 0x00254A58
		public long EstimateSize(long numCells, int maxPtsPerCell)
		{
			return vtkCellArray.vtkCellArray_EstimateSize_16(base.GetCppThis(), numCells, maxPtsPerCell);
		}

		// Token: 0x0601AD88 RID: 109960
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellArray_ExportLegacyFormat_17(HandleRef pThis, HandleRef data);

		/// <summary>
		/// Fill @a data with the old-style vtkCellArray data layout, e.g.
		///
		/// ```
		/// { n0, p0_0, p0_1, ..., p0_n, n1, p1_0, p1_1, ..., p1_n, ... }
		/// ```
		///
		/// where `n0` is the number of points in cell 0, and `pX_Y` is the Y'th point
		/// in cell X.
		/// </summary>
		// Token: 0x0601AD89 RID: 109961 RVA: 0x0025687C File Offset: 0x00254A7C
		public void ExportLegacyFormat(vtkIdTypeArray data)
		{
			vtkCellArray.vtkCellArray_ExportLegacyFormat_17(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis());
		}

		// Token: 0x0601AD8A RID: 109962
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkCellArray_GetActualMemorySize_18(HandleRef pThis);

		/// <summary>
		/// Return the memory in kibibytes (1024 bytes) consumed by this cell array. Used to
		/// support streaming and reading/writing data. The value returned is
		/// guaranteed to be greater than or equal to the memory required to
		/// actually represent the data represented by this object. The
		/// information returned is valid only after the pipeline has
		/// been updated.
		/// </summary>
		// Token: 0x0601AD8B RID: 109963 RVA: 0x002568AC File Offset: 0x00254AAC
		public uint GetActualMemorySize()
		{
			return vtkCellArray.vtkCellArray_GetActualMemorySize_18(base.GetCppThis());
		}

		// Token: 0x0601AD8C RID: 109964
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellArray_GetCell_19(HandleRef pThis, long loc, HandleRef pts);

		/// <summary>
		/// Internal method used to retrieve a cell given a legacy offset location.
		///
		/// @note The location-based API is now a super-slow compatibility layer.
		/// Prefer GetCellAtId.
		/// </summary>
		// Token: 0x0601AD8D RID: 109965 RVA: 0x002568CC File Offset: 0x00254ACC
		public void GetCell(long loc, vtkIdList pts)
		{
			vtkCellArray.vtkCellArray_GetCell_19(base.GetCppThis(), loc, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601AD8E RID: 109966
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellArray_GetCellAtId_20(HandleRef pThis, long cellId, HandleRef pts);

		/// <summary>
		/// Return the point ids for the cell at @a cellId. This always copies
		/// the cell ids (i.e., the list of points @a pts into the supplied
		/// vtkIdList). This method is thread safe.
		/// </summary>
		// Token: 0x0601AD8F RID: 109967 RVA: 0x002568FC File Offset: 0x00254AFC
		public void GetCellAtId(long cellId, vtkIdList pts)
		{
			vtkCellArray.vtkCellArray_GetCellAtId_20(base.GetCppThis(), cellId, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601AD90 RID: 109968
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellArray_GetCellSize_21(HandleRef pThis, long cellId);

		/// <summary>
		/// Return the size of the cell at @a cellId.
		/// </summary>
		// Token: 0x0601AD91 RID: 109969 RVA: 0x0025692C File Offset: 0x00254B2C
		public long GetCellSize(long cellId)
		{
			return vtkCellArray.vtkCellArray_GetCellSize_21(base.GetCppThis(), cellId);
		}

		// Token: 0x0601AD92 RID: 109970
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellArray_GetConnectivityArray_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the array used to store the point ids that define the cells'
		/// connectivity. The 32/64 variants are only valid when IsStorage64Bit()
		/// returns the appropriate value.
		/// @{
		/// </summary>
		// Token: 0x0601AD93 RID: 109971 RVA: 0x0025694C File Offset: 0x00254B4C
		public vtkDataArray GetConnectivityArray()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellArray.vtkCellArray_GetConnectivityArray_22(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601AD94 RID: 109972
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellArray_GetConnectivityArray32_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the array used to store the point ids that define the cells'
		/// connectivity. The 32/64 variants are only valid when IsStorage64Bit()
		/// returns the appropriate value.
		/// @{
		/// </summary>
		// Token: 0x0601AD95 RID: 109973 RVA: 0x002569BC File Offset: 0x00254BBC
		public vtkTypeInt32Array GetConnectivityArray32()
		{
			vtkTypeInt32Array vtkTypeInt32Array = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellArray.vtkCellArray_GetConnectivityArray32_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTypeInt32Array = (vtkTypeInt32Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTypeInt32Array.Register(null);
				}
			}
			return vtkTypeInt32Array;
		}

		// Token: 0x0601AD96 RID: 109974
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellArray_GetConnectivityArray64_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the array used to store the point ids that define the cells'
		/// connectivity. The 32/64 variants are only valid when IsStorage64Bit()
		/// returns the appropriate value.
		/// @{
		/// </summary>
		// Token: 0x0601AD97 RID: 109975 RVA: 0x00256A2C File Offset: 0x00254C2C
		public vtkTypeInt64Array GetConnectivityArray64()
		{
			vtkTypeInt64Array vtkTypeInt64Array = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellArray.vtkCellArray_GetConnectivityArray64_24(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTypeInt64Array = (vtkTypeInt64Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTypeInt64Array.Register(null);
				}
			}
			return vtkTypeInt64Array;
		}

		// Token: 0x0601AD98 RID: 109976
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellArray_GetData_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the underlying data as a data array.
		///
		/// @warning The returned array is not the actual internal representation used
		/// by vtkCellArray. Modifications to the returned array will not change the
		/// vtkCellArray's topology.
		///
		/// @note Use ExportLegacyFormat, or GetOffsetsArray/GetConnectivityArray
		/// instead.
		/// </summary>
		// Token: 0x0601AD99 RID: 109977 RVA: 0x00256A9C File Offset: 0x00254C9C
		public vtkIdTypeArray GetData()
		{
			vtkIdTypeArray vtkIdTypeArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellArray.vtkCellArray_GetData_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601AD9A RID: 109978
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellArray_GetInsertLocation_26(HandleRef pThis, int npts);

		/// <summary>
		/// Computes the current legacy insertion location within the internal array.
		/// Used in conjunction with GetCell(int loc,...).
		///
		/// @note The location-based API is now a super-slow compatibility layer.
		/// </summary>
		// Token: 0x0601AD9B RID: 109979 RVA: 0x00256B0C File Offset: 0x00254D0C
		public long GetInsertLocation(int npts)
		{
			return vtkCellArray.vtkCellArray_GetInsertLocation_26(base.GetCppThis(), npts);
		}

		// Token: 0x0601AD9C RID: 109980
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellArray_GetMaxCellSize_27(HandleRef pThis);

		/// <summary>
		/// Returns the size of the largest cell. The size is the number of points
		/// defining the cell.
		/// </summary>
		// Token: 0x0601AD9D RID: 109981 RVA: 0x00256B2C File Offset: 0x00254D2C
		public int GetMaxCellSize()
		{
			return vtkCellArray.vtkCellArray_GetMaxCellSize_27(base.GetCppThis());
		}

		// Token: 0x0601AD9E RID: 109982
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellArray_GetNextCell_28(HandleRef pThis, HandleRef pts);

		/// <summary>
		/// @warning This method is not thread-safe. Consider using the NewIterator()
		/// iterator instead.
		///
		/// GetNextCell() gets the next cell in the list. If end of list is
		/// encountered, 0 is returned.
		///
		/// @note This method is not thread-safe and has tricky syntax to use
		/// correctly. Prefer the use of vtkCellArrayIterator (see NewIterator()).
		/// </summary>
		// Token: 0x0601AD9F RID: 109983 RVA: 0x00256B4C File Offset: 0x00254D4C
		public int GetNextCell(vtkIdList pts)
		{
			return vtkCellArray.vtkCellArray_GetNextCell_28(base.GetCppThis(), (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601ADA0 RID: 109984
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellArray_GetNumberOfCells_29(HandleRef pThis);

		/// <summary>
		/// Get the number of cells in the array.
		/// </summary>
		// Token: 0x0601ADA1 RID: 109985 RVA: 0x00256B80 File Offset: 0x00254D80
		public long GetNumberOfCells()
		{
			return vtkCellArray.vtkCellArray_GetNumberOfCells_29(base.GetCppThis());
		}

		// Token: 0x0601ADA2 RID: 109986
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellArray_GetNumberOfConnectivityEntries_30(HandleRef pThis);

		/// <summary>
		/// Return the size of the array that would be returned from
		/// ExportLegacyFormat().
		///
		/// @note Method incompatible with current internal storage.
		/// </summary>
		// Token: 0x0601ADA3 RID: 109987 RVA: 0x00256BA0 File Offset: 0x00254DA0
		public long GetNumberOfConnectivityEntries()
		{
			return vtkCellArray.vtkCellArray_GetNumberOfConnectivityEntries_30(base.GetCppThis());
		}

		// Token: 0x0601ADA4 RID: 109988
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellArray_GetNumberOfConnectivityIds_31(HandleRef pThis);

		/// <summary>
		/// Get the size of the connectivity array that stores the point ids.
		/// @note Do not confuse this with the deprecated
		/// GetNumberOfConnectivityEntries(), which refers to the legacy memory
		/// layout.
		/// </summary>
		// Token: 0x0601ADA5 RID: 109989 RVA: 0x00256BC0 File Offset: 0x00254DC0
		public long GetNumberOfConnectivityIds()
		{
			return vtkCellArray.vtkCellArray_GetNumberOfConnectivityIds_31(base.GetCppThis());
		}

		// Token: 0x0601ADA6 RID: 109990
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellArray_GetNumberOfGenerationsFromBase_32(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and
		/// printing.
		/// </summary>
		// Token: 0x0601ADA7 RID: 109991 RVA: 0x00256BE0 File Offset: 0x00254DE0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCellArray.vtkCellArray_GetNumberOfGenerationsFromBase_32(base.GetCppThis(), type);
		}

		// Token: 0x0601ADA8 RID: 109992
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellArray_GetNumberOfGenerationsFromBaseType_33([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and
		/// printing.
		/// </summary>
		// Token: 0x0601ADA9 RID: 109993 RVA: 0x00256C00 File Offset: 0x00254E00
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCellArray.vtkCellArray_GetNumberOfGenerationsFromBaseType_33(type);
		}

		// Token: 0x0601ADAA RID: 109994
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellArray_GetNumberOfOffsets_34(HandleRef pThis);

		/// <summary>
		/// Get the number of elements in the offsets array. This will be the number of
		/// cells + 1.
		/// </summary>
		// Token: 0x0601ADAB RID: 109995 RVA: 0x00256C1C File Offset: 0x00254E1C
		public long GetNumberOfOffsets()
		{
			return vtkCellArray.vtkCellArray_GetNumberOfOffsets_34(base.GetCppThis());
		}

		// Token: 0x0601ADAC RID: 109996
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellArray_GetOffset_35(HandleRef pThis, long cellId);

		/// <summary>
		/// Get the offset (into the connectivity) for a specified cell id.
		/// </summary>
		// Token: 0x0601ADAD RID: 109997 RVA: 0x00256C3C File Offset: 0x00254E3C
		public long GetOffset(long cellId)
		{
			return vtkCellArray.vtkCellArray_GetOffset_35(base.GetCppThis(), cellId);
		}

		// Token: 0x0601ADAE RID: 109998
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellArray_GetOffsetsArray_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the array used to store cell offsets. The 32/64 variants are only
		/// valid when IsStorage64Bit() returns the appropriate value.
		/// @{
		/// </summary>
		// Token: 0x0601ADAF RID: 109999 RVA: 0x00256C5C File Offset: 0x00254E5C
		public vtkDataArray GetOffsetsArray()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellArray.vtkCellArray_GetOffsetsArray_36(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601ADB0 RID: 110000
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellArray_GetOffsetsArray32_37(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the array used to store cell offsets. The 32/64 variants are only
		/// valid when IsStorage64Bit() returns the appropriate value.
		/// @{
		/// </summary>
		// Token: 0x0601ADB1 RID: 110001 RVA: 0x00256CCC File Offset: 0x00254ECC
		public vtkTypeInt32Array GetOffsetsArray32()
		{
			vtkTypeInt32Array vtkTypeInt32Array = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellArray.vtkCellArray_GetOffsetsArray32_37(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTypeInt32Array = (vtkTypeInt32Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTypeInt32Array.Register(null);
				}
			}
			return vtkTypeInt32Array;
		}

		// Token: 0x0601ADB2 RID: 110002
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellArray_GetOffsetsArray64_38(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the array used to store cell offsets. The 32/64 variants are only
		/// valid when IsStorage64Bit() returns the appropriate value.
		/// @{
		/// </summary>
		// Token: 0x0601ADB3 RID: 110003 RVA: 0x00256D3C File Offset: 0x00254F3C
		public vtkTypeInt64Array GetOffsetsArray64()
		{
			vtkTypeInt64Array vtkTypeInt64Array = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellArray.vtkCellArray_GetOffsetsArray64_38(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTypeInt64Array = (vtkTypeInt64Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTypeInt64Array.Register(null);
				}
			}
			return vtkTypeInt64Array;
		}

		// Token: 0x0601ADB4 RID: 110004
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellArray_GetSize_39(HandleRef pThis);

		/// <summary>
		/// Get the size of the allocated connectivity array.
		///
		/// @warning This returns the allocated capacity of the internal arrays as a
		/// number of elements, NOT the number of elements in use.
		///
		/// @note Method incompatible with current internal storage.
		/// </summary>
		// Token: 0x0601ADB5 RID: 110005 RVA: 0x00256DAC File Offset: 0x00254FAC
		public long GetSize()
		{
			return vtkCellArray.vtkCellArray_GetSize_39(base.GetCppThis());
		}

		// Token: 0x0601ADB6 RID: 110006
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellArray_GetTraversalCellId_40(HandleRef pThis);

		/// <summary>
		/// Get/Set the current cellId for traversal.
		///
		/// @note This method is not thread-safe and has tricky syntax to use
		/// correctly. Prefer the use of vtkCellArrayIterator (see NewIterator()).
		/// @{
		/// </summary>
		// Token: 0x0601ADB7 RID: 110007 RVA: 0x00256DCC File Offset: 0x00254FCC
		public long GetTraversalCellId()
		{
			return vtkCellArray.vtkCellArray_GetTraversalCellId_40(base.GetCppThis());
		}

		// Token: 0x0601ADB8 RID: 110008
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellArray_GetTraversalLocation_41(HandleRef pThis);

		/// <summary>
		/// Get/Set the current traversal legacy location.
		///
		/// @note The location-based API is now a super-slow compatibility layer.
		/// Prefer Get/SetTraversalCellId.
		/// @{
		/// </summary>
		// Token: 0x0601ADB9 RID: 110009 RVA: 0x00256DEC File Offset: 0x00254FEC
		public long GetTraversalLocation()
		{
			return vtkCellArray.vtkCellArray_GetTraversalLocation_41(base.GetCppThis());
		}

		// Token: 0x0601ADBA RID: 110010
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellArray_GetTraversalLocation_42(HandleRef pThis, long npts);

		/// <summary>
		/// Get/Set the current traversal legacy location.
		///
		/// @note The location-based API is now a super-slow compatibility layer.
		/// Prefer Get/SetTraversalCellId.
		/// @{
		/// </summary>
		// Token: 0x0601ADBB RID: 110011 RVA: 0x00256E0C File Offset: 0x0025500C
		public long GetTraversalLocation(long npts)
		{
			return vtkCellArray.vtkCellArray_GetTraversalLocation_42(base.GetCppThis(), npts);
		}

		// Token: 0x0601ADBC RID: 110012
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellArray_ImportLegacyFormat_43(HandleRef pThis, HandleRef data);

		/// <summary>
		/// Import an array of data with the legacy vtkCellArray layout, e.g.:
		///
		/// ```
		/// { n0, p0_0, p0_1, ..., p0_n, n1, p1_0, p1_1, ..., p1_n, ... }
		/// ```
		///
		/// where `n0` is the number of points in cell 0, and `pX_Y` is the Y'th point
		/// in cell X.
		/// @{
		/// </summary>
		// Token: 0x0601ADBD RID: 110013 RVA: 0x00256E2C File Offset: 0x0025502C
		public void ImportLegacyFormat(vtkIdTypeArray data)
		{
			vtkCellArray.vtkCellArray_ImportLegacyFormat_43(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis());
		}

		// Token: 0x0601ADBE RID: 110014
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellArray_ImportLegacyFormat_44(HandleRef pThis, IntPtr data, long len);

		/// <summary>
		/// Import an array of data with the legacy vtkCellArray layout, e.g.:
		///
		/// ```
		/// { n0, p0_0, p0_1, ..., p0_n, n1, p1_0, p1_1, ..., p1_n, ... }
		/// ```
		///
		/// where `n0` is the number of points in cell 0, and `pX_Y` is the Y'th point
		/// in cell X.
		/// @{
		/// </summary>
		// Token: 0x0601ADBF RID: 110015 RVA: 0x00256E5B File Offset: 0x0025505B
		public void ImportLegacyFormat(IntPtr data, long len)
		{
			vtkCellArray.vtkCellArray_ImportLegacyFormat_44(base.GetCppThis(), data, len);
		}

		// Token: 0x0601ADC0 RID: 110016
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellArray_InitTraversal_45(HandleRef pThis);

		/// <summary>
		/// @warning This method is not thread-safe. Consider using the NewIterator()
		/// iterator instead.
		///
		/// InitTraversal() initializes the traversal of the list of cells.
		///
		/// @note This method is not thread-safe and has tricky syntax to use
		/// correctly. Prefer the use of vtkCellArrayIterator (see NewIterator()).
		/// </summary>
		// Token: 0x0601ADC1 RID: 110017 RVA: 0x00256E6C File Offset: 0x0025506C
		public void InitTraversal()
		{
			vtkCellArray.vtkCellArray_InitTraversal_45(base.GetCppThis());
		}

		// Token: 0x0601ADC2 RID: 110018
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellArray_Initialize_46(HandleRef pThis);

		/// <summary>
		/// Free any memory and reset to an empty state.
		/// </summary>
		// Token: 0x0601ADC3 RID: 110019 RVA: 0x00256E7B File Offset: 0x0025507B
		public void Initialize()
		{
			vtkCellArray.vtkCellArray_Initialize_46(base.GetCppThis());
		}

		// Token: 0x0601ADC4 RID: 110020
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellArray_InsertCellPoint_47(HandleRef pThis, long id);

		/// <summary>
		/// Used in conjunction with InsertNextCell(npts) to add another point
		/// to the list of cells.
		/// </summary>
		// Token: 0x0601ADC5 RID: 110021 RVA: 0x00256E8A File Offset: 0x0025508A
		public void InsertCellPoint(long id)
		{
			vtkCellArray.vtkCellArray_InsertCellPoint_47(base.GetCppThis(), id);
		}

		// Token: 0x0601ADC6 RID: 110022
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellArray_InsertNextCell_48(HandleRef pThis, HandleRef cell);

		/// <summary>
		/// Insert a cell object. Return the cell id of the cell.
		/// </summary>
		// Token: 0x0601ADC7 RID: 110023 RVA: 0x00256E9C File Offset: 0x0025509C
		public long InsertNextCell(vtkCell cell)
		{
			return vtkCellArray.vtkCellArray_InsertNextCell_48(base.GetCppThis(), (cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x0601ADC8 RID: 110024
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellArray_InsertNextCell_49(HandleRef pThis, long npts, IntPtr pts);

		/// <summary>
		/// Create a cell by specifying the number of points and an array of point
		/// id's.  Return the cell id of the cell.
		/// </summary>
		// Token: 0x0601ADC9 RID: 110025 RVA: 0x00256ED0 File Offset: 0x002550D0
		public long InsertNextCell(long npts, IntPtr pts)
		{
			return vtkCellArray.vtkCellArray_InsertNextCell_49(base.GetCppThis(), npts, pts);
		}

		// Token: 0x0601ADCA RID: 110026
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellArray_InsertNextCell_50(HandleRef pThis, HandleRef pts);

		/// <summary>
		/// Create a cell by specifying a list of point ids. Return the cell id of
		/// the cell.
		/// </summary>
		// Token: 0x0601ADCB RID: 110027 RVA: 0x00256EF4 File Offset: 0x002550F4
		public long InsertNextCell(vtkIdList pts)
		{
			return vtkCellArray.vtkCellArray_InsertNextCell_50(base.GetCppThis(), (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601ADCC RID: 110028
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellArray_InsertNextCell_51(HandleRef pThis, int npts);

		/// <summary>
		/// Create cells by specifying a count of total points to be inserted, and
		/// then adding points one at a time using method InsertCellPoint(). If you
		/// don't know the count initially, use the method UpdateCellCount() to
		/// complete the cell. Return the cell id of the cell.
		/// </summary>
		// Token: 0x0601ADCD RID: 110029 RVA: 0x00256F28 File Offset: 0x00255128
		public long InsertNextCell(int npts)
		{
			return vtkCellArray.vtkCellArray_InsertNextCell_51(base.GetCppThis(), npts);
		}

		// Token: 0x0601ADCE RID: 110030
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellArray_IsA_52(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and
		/// printing.
		/// </summary>
		// Token: 0x0601ADCF RID: 110031 RVA: 0x00256F48 File Offset: 0x00255148
		public override int IsA(string type)
		{
			return vtkCellArray.vtkCellArray_IsA_52(base.GetCppThis(), type);
		}

		// Token: 0x0601ADD0 RID: 110032
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellArray_IsHomogeneous_53(HandleRef pThis);

		/// <summary>
		/// Check if all cells have the same number of vertices.
		///
		/// The return value is coded as:
		/// * -1 = heterogeneous
		/// * 0 = Cell array empty
		/// * n (positive integer) = homogeneous array of cell size n
		/// </summary>
		// Token: 0x0601ADD1 RID: 110033 RVA: 0x00256F68 File Offset: 0x00255168
		public long IsHomogeneous()
		{
			return vtkCellArray.vtkCellArray_IsHomogeneous_53(base.GetCppThis());
		}

		// Token: 0x0601ADD2 RID: 110034
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCellArray_IsStorage64Bit_54(HandleRef pThis);

		/// <summary>
		/// @return True if the internal storage is using 64 bit arrays. If false,
		/// the storage is using 32 bit arrays.
		/// </summary>
		// Token: 0x0601ADD3 RID: 110035 RVA: 0x00256F88 File Offset: 0x00255188
		public bool IsStorage64Bit()
		{
			return vtkCellArray.vtkCellArray_IsStorage64Bit_54(base.GetCppThis()) != 0;
		}

		// Token: 0x0601ADD4 RID: 110036
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCellArray_IsStorageShareable_55(HandleRef pThis);

		/// <summary>
		/// @return True if the internal storage can be shared as a
		/// pointer to vtkIdType, i.e., the type and organization of internal
		/// storage is such that copying of data can be avoided, and instead
		/// a pointer to vtkIdType can be used.
		/// </summary>
		// Token: 0x0601ADD5 RID: 110037 RVA: 0x00256FB0 File Offset: 0x002551B0
		public bool IsStorageShareable()
		{
			return vtkCellArray.vtkCellArray_IsStorageShareable_55(base.GetCppThis()) != 0;
		}

		// Token: 0x0601ADD6 RID: 110038
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellArray_IsTypeOf_56([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and
		/// printing.
		/// </summary>
		// Token: 0x0601ADD7 RID: 110039 RVA: 0x00256FD8 File Offset: 0x002551D8
		public new static int IsTypeOf(string type)
		{
			return vtkCellArray.vtkCellArray_IsTypeOf_56(type);
		}

		// Token: 0x0601ADD8 RID: 110040
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCellArray_IsValid_57(HandleRef pThis);

		/// <summary>
		/// Check that internal storage is consistent and in a valid state.
		///
		/// Specifically, this function returns true if and only if:
		/// - The offset and connectivity arrays have exactly one component.
		/// - The offset array has at least one value and starts at 0.
		/// - The offset array values never decrease.
		/// - The connectivity array has as many entries as the last value in the
		///   offset array.
		/// </summary>
		// Token: 0x0601ADD9 RID: 110041 RVA: 0x00256FF4 File Offset: 0x002551F4
		public bool IsValid()
		{
			return vtkCellArray.vtkCellArray_IsValid_57(base.GetCppThis()) != 0;
		}

		// Token: 0x0601ADDA RID: 110042
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellArray_NewInstance_59(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and
		/// printing.
		/// </summary>
		// Token: 0x0601ADDB RID: 110043 RVA: 0x0025701C File Offset: 0x0025521C
		public new vtkCellArray NewInstance()
		{
			vtkCellArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellArray.vtkCellArray_NewInstance_59(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601ADDC RID: 110044
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellArray_NewIterator_60(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// @brief NewIterator returns a new instance of vtkCellArrayIterator that
		/// is initialized to point at the first cell's data. The caller is responsible
		/// for Delete()'ing the object.
		/// </summary>
		// Token: 0x0601ADDD RID: 110045 RVA: 0x00257078 File Offset: 0x00255278
		public vtkCellArrayIterator NewIterator()
		{
			vtkCellArrayIterator vtkCellArrayIterator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellArray.vtkCellArray_NewIterator_60(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellArrayIterator = (vtkCellArrayIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellArrayIterator.Register(null);
				}
			}
			return vtkCellArrayIterator;
		}

		// Token: 0x0601ADDE RID: 110046
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellArray_ReplaceCell_61(HandleRef pThis, long loc, int npts, IntPtr pts);

		/// <summary>
		/// Replace the point ids of the cell at the legacy location with a different
		/// list of point ids. Calling this method does not mark the vtkCellArray as
		/// modified. This is the responsibility of the caller and may be done after
		/// multiple calls to ReplaceCell. This call does not support changing the
		/// number of points in the cell -- the caller must ensure that the target
		/// cell has npts points.
		///
		/// @note The location-based API is now a super-slow compatibility layer.
		/// Prefer ReplaceCellAtId.
		/// </summary>
		// Token: 0x0601ADDF RID: 110047 RVA: 0x002570E7 File Offset: 0x002552E7
		public void ReplaceCell(long loc, int npts, IntPtr pts)
		{
			vtkCellArray.vtkCellArray_ReplaceCell_61(base.GetCppThis(), loc, npts, pts);
		}

		// Token: 0x0601ADE0 RID: 110048
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellArray_ReplaceCellAtId_62(HandleRef pThis, long cellId, HandleRef list);

		/// <summary>
		/// Replaces the point ids for the specified cell with the supplied list.
		///
		/// @warning This can ONLY replace the cell if the size does not change.
		/// Attempting to change cell size through this method will have undefined
		/// results.
		/// @{
		/// </summary>
		// Token: 0x0601ADE1 RID: 110049 RVA: 0x002570FC File Offset: 0x002552FC
		public void ReplaceCellAtId(long cellId, vtkIdList list)
		{
			vtkCellArray.vtkCellArray_ReplaceCellAtId_62(base.GetCppThis(), cellId, (list == null) ? default(HandleRef) : list.GetCppThis());
		}

		// Token: 0x0601ADE2 RID: 110050
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellArray_ReplaceCellAtId_63(HandleRef pThis, long cellId, long cellSize, IntPtr cellPoints);

		/// <summary>
		/// Replaces the point ids for the specified cell with the supplied list.
		///
		/// @warning This can ONLY replace the cell if the size does not change.
		/// Attempting to change cell size through this method will have undefined
		/// results.
		/// @{
		/// </summary>
		// Token: 0x0601ADE3 RID: 110051 RVA: 0x0025712C File Offset: 0x0025532C
		public void ReplaceCellAtId(long cellId, long cellSize, IntPtr cellPoints)
		{
			vtkCellArray.vtkCellArray_ReplaceCellAtId_63(base.GetCppThis(), cellId, cellSize, cellPoints);
		}

		// Token: 0x0601ADE4 RID: 110052
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellArray_ReplaceCellPointAtId_64(HandleRef pThis, long cellId, long cellPointIndex, long newPointId);

		/// <summary>
		/// Replaces the pointId at cellPointIndex of a cell with newPointId.
		///
		/// @warning This can ONLY replace the cell if the size does not change.
		/// Attempting to change cell size through this method will have undefined
		/// results.
		/// </summary>
		// Token: 0x0601ADE5 RID: 110053 RVA: 0x0025713E File Offset: 0x0025533E
		public void ReplaceCellPointAtId(long cellId, long cellPointIndex, long newPointId)
		{
			vtkCellArray.vtkCellArray_ReplaceCellPointAtId_64(base.GetCppThis(), cellId, cellPointIndex, newPointId);
		}

		// Token: 0x0601ADE6 RID: 110054
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellArray_Reset_65(HandleRef pThis);

		/// <summary>
		/// Reuse list. Reset to initial state without freeing memory.
		/// </summary>
		// Token: 0x0601ADE7 RID: 110055 RVA: 0x00257150 File Offset: 0x00255350
		public void Reset()
		{
			vtkCellArray.vtkCellArray_Reset_65(base.GetCppThis());
		}

		// Token: 0x0601ADE8 RID: 110056
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCellArray_ResizeExact_66(HandleRef pThis, long numCells, long connectivitySize);

		/// <summary>
		/// @brief ResizeExact() resizes the internal structures to hold @a numCells
		/// total cell offsets and @a connectivitySize total pointIds. Old data is
		/// preserved, and newly-available memory is not initialized.
		///
		/// @warning For advanced use only. You probably want an Allocate method.
		///
		/// @return True if allocation succeeds.
		/// </summary>
		// Token: 0x0601ADE9 RID: 110057 RVA: 0x00257160 File Offset: 0x00255360
		public bool ResizeExact(long numCells, long connectivitySize)
		{
			return vtkCellArray.vtkCellArray_ResizeExact_66(base.GetCppThis(), numCells, connectivitySize) != 0;
		}

		// Token: 0x0601ADEA RID: 110058
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellArray_ReverseCell_67(HandleRef pThis, long loc);

		/// <summary>
		/// Special method inverts ordering of cell at the specified legacy location.
		/// Must be called carefully or the cell topology may be corrupted.
		///
		/// @note The location-based API is now a super-slow compatibility layer.
		/// Prefer ReverseCellAtId;
		/// </summary>
		// Token: 0x0601ADEB RID: 110059 RVA: 0x00257188 File Offset: 0x00255388
		public void ReverseCell(long loc)
		{
			vtkCellArray.vtkCellArray_ReverseCell_67(base.GetCppThis(), loc);
		}

		// Token: 0x0601ADEC RID: 110060
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellArray_ReverseCellAtId_68(HandleRef pThis, long cellId);

		/// <summary>
		/// Reverses the order of the point ids for the specified cell.
		/// </summary>
		// Token: 0x0601ADED RID: 110061 RVA: 0x00257198 File Offset: 0x00255398
		public void ReverseCellAtId(long cellId)
		{
			vtkCellArray.vtkCellArray_ReverseCellAtId_68(base.GetCppThis(), cellId);
		}

		// Token: 0x0601ADEE RID: 110062
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellArray_SafeDownCast_69(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and
		/// printing.
		/// </summary>
		// Token: 0x0601ADEF RID: 110063 RVA: 0x002571A8 File Offset: 0x002553A8
		public new static vtkCellArray SafeDownCast(vtkObjectBase o)
		{
			vtkCellArray vtkCellArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellArray.vtkCellArray_SafeDownCast_69((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601ADF0 RID: 110064
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellArray_SetCells_70(HandleRef pThis, long ncells, HandleRef cells);

		/// <summary>
		/// Define multiple cells by providing a connectivity list. The list is in
		/// the form (npts,p0,p1,...p(npts-1), repeated for each cell). Be careful
		/// using this method because it discards the old cells, and anything
		/// referring these cells becomes invalid (for example, if BuildCells() has
		/// been called see vtkPolyData).  The traversal location is reset to the
		/// beginning of the list; the insertion location is set to the end of the
		/// list.
		///
		/// @warning The vtkCellArray will not hold a reference to `cells`. This
		/// function merely calls ImportLegacyFormat.
		///
		/// @note Use ImportLegacyFormat or SetData instead.
		/// </summary>
		// Token: 0x0601ADF1 RID: 110065 RVA: 0x00257228 File Offset: 0x00255428
		public void SetCells(long ncells, vtkIdTypeArray cells)
		{
			vtkCellArray.vtkCellArray_SetCells_70(base.GetCppThis(), ncells, (cells == null) ? default(HandleRef) : cells.GetCppThis());
		}

		// Token: 0x0601ADF2 RID: 110066
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellArray_SetData_71(HandleRef pThis, HandleRef offsets, HandleRef connectivity);

		/// <summary>
		/// Set the internal data arrays to the supplied offsets and connectivity
		/// arrays.
		///
		/// Note that the input arrays may be copied and not used directly. To avoid
		/// copying, use vtkIdTypeArray, vtkCellArray::ArrayType32, or
		/// vtkCellArray::ArrayType64.
		///
		/// @{
		/// </summary>
		// Token: 0x0601ADF3 RID: 110067 RVA: 0x00257258 File Offset: 0x00255458
		public void SetData(vtkIdTypeArray offsets, vtkIdTypeArray connectivity)
		{
			vtkCellArray.vtkCellArray_SetData_71(base.GetCppThis(), (offsets == null) ? default(HandleRef) : offsets.GetCppThis(), (connectivity == null) ? default(HandleRef) : connectivity.GetCppThis());
		}

		// Token: 0x0601ADF4 RID: 110068
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellArray_SetData_72(HandleRef pThis, HandleRef offsets, HandleRef connectivity);

		/// <summary>
		/// Set the internal data arrays to the supplied offsets and connectivity
		/// arrays.
		///
		/// Note that the input arrays may be copied and not used directly. To avoid
		/// copying, use vtkIdTypeArray, vtkCellArray::ArrayType32, or
		/// vtkCellArray::ArrayType64.
		///
		/// @{
		/// </summary>
		// Token: 0x0601ADF5 RID: 110069 RVA: 0x0025729C File Offset: 0x0025549C
		public void SetData(vtkTypeInt32Array offsets, vtkTypeInt32Array connectivity)
		{
			vtkCellArray.vtkCellArray_SetData_72(base.GetCppThis(), (offsets == null) ? default(HandleRef) : offsets.GetCppThis(), (connectivity == null) ? default(HandleRef) : connectivity.GetCppThis());
		}

		// Token: 0x0601ADF6 RID: 110070
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellArray_SetData_73(HandleRef pThis, HandleRef offsets, HandleRef connectivity);

		/// <summary>
		/// Set the internal data arrays to the supplied offsets and connectivity
		/// arrays.
		///
		/// Note that the input arrays may be copied and not used directly. To avoid
		/// copying, use vtkIdTypeArray, vtkCellArray::ArrayType32, or
		/// vtkCellArray::ArrayType64.
		///
		/// @{
		/// </summary>
		// Token: 0x0601ADF7 RID: 110071 RVA: 0x002572E0 File Offset: 0x002554E0
		public void SetData(vtkTypeInt64Array offsets, vtkTypeInt64Array connectivity)
		{
			vtkCellArray.vtkCellArray_SetData_73(base.GetCppThis(), (offsets == null) ? default(HandleRef) : offsets.GetCppThis(), (connectivity == null) ? default(HandleRef) : connectivity.GetCppThis());
		}

		// Token: 0x0601ADF8 RID: 110072
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCellArray_SetData_74(HandleRef pThis, HandleRef offsets, HandleRef connectivity);

		/// <summary>
		/// Sets the internal arrays to the supplied offsets and connectivity arrays.
		///
		/// This is a convenience method, and may fail if the following conditions
		/// are not met:
		///
		/// - Both arrays must be of the same type.
		/// - The array type must be one of the types in InputArrayList.
		///
		/// If invalid arrays are passed in, an error is logged and the function
		/// will return false.
		/// </summary>
		// Token: 0x0601ADF9 RID: 110073 RVA: 0x00257324 File Offset: 0x00255524
		public bool SetData(vtkDataArray offsets, vtkDataArray connectivity)
		{
			return vtkCellArray.vtkCellArray_SetData_74(base.GetCppThis(), (offsets == null) ? default(HandleRef) : offsets.GetCppThis(), (connectivity == null) ? default(HandleRef) : connectivity.GetCppThis()) != 0;
		}

		// Token: 0x0601ADFA RID: 110074
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCellArray_SetData_75(HandleRef pThis, long cellSize, HandleRef connectivity);

		/// <summary>
		/// Sets the internal arrays to the supported connectivity array with an
		/// offsets array automatically generated given the fixed cells size.
		///
		/// This is a convenience method, and may fail if the following conditions
		/// are not met:
		///
		/// - The `connectivity` array must be one of the types in InputArrayList.
		/// - The `connectivity` array size must be a multiple of `cellSize`.
		///
		/// If invalid arrays are passed in, an error is logged and the function
		/// will return false.
		/// </summary>
		// Token: 0x0601ADFB RID: 110075 RVA: 0x00257374 File Offset: 0x00255574
		public bool SetData(long cellSize, vtkDataArray connectivity)
		{
			return vtkCellArray.vtkCellArray_SetData_75(base.GetCppThis(), cellSize, (connectivity == null) ? default(HandleRef) : connectivity.GetCppThis()) != 0;
		}

		// Token: 0x0601ADFC RID: 110076
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellArray_SetNumberOfCells_76(HandleRef pThis, long arg0);

		/// <summary>
		/// Set the number of cells in the array.
		/// DO NOT do any kind of allocation, advanced use only.
		///
		/// @note This call has no effect.
		/// </summary>
		// Token: 0x0601ADFD RID: 110077 RVA: 0x002573B0 File Offset: 0x002555B0
		public virtual void SetNumberOfCells(long arg0)
		{
			vtkCellArray.vtkCellArray_SetNumberOfCells_76(base.GetCppThis(), arg0);
		}

		// Token: 0x0601ADFE RID: 110078
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellArray_SetTraversalCellId_77(HandleRef pThis, long cellId);

		/// <summary>
		/// Get/Set the current cellId for traversal.
		///
		/// @note This method is not thread-safe and has tricky syntax to use
		/// correctly. Prefer the use of vtkCellArrayIterator (see NewIterator()).
		/// @{
		/// </summary>
		// Token: 0x0601ADFF RID: 110079 RVA: 0x002573C0 File Offset: 0x002555C0
		public void SetTraversalCellId(long cellId)
		{
			vtkCellArray.vtkCellArray_SetTraversalCellId_77(base.GetCppThis(), cellId);
		}

		// Token: 0x0601AE00 RID: 110080
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellArray_SetTraversalLocation_78(HandleRef pThis, long loc);

		/// <summary>
		/// Get/Set the current traversal legacy location.
		///
		/// @note The location-based API is now a super-slow compatibility layer.
		/// Prefer Get/SetTraversalCellId.
		/// @{
		/// </summary>
		// Token: 0x0601AE01 RID: 110081 RVA: 0x002573D0 File Offset: 0x002555D0
		public void SetTraversalLocation(long loc)
		{
			vtkCellArray.vtkCellArray_SetTraversalLocation_78(base.GetCppThis(), loc);
		}

		// Token: 0x0601AE02 RID: 110082
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellArray_ShallowCopy_79(HandleRef pThis, HandleRef ca);

		/// <summary>
		/// Shallow copy @a ca into this cell array.
		/// </summary>
		// Token: 0x0601AE03 RID: 110083 RVA: 0x002573E0 File Offset: 0x002555E0
		public void ShallowCopy(vtkCellArray ca)
		{
			vtkCellArray.vtkCellArray_ShallowCopy_79(base.GetCppThis(), (ca == null) ? default(HandleRef) : ca.GetCppThis());
		}

		// Token: 0x0601AE04 RID: 110084
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellArray_Squeeze_80(HandleRef pThis);

		/// <summary>
		/// Reclaim any extra memory while preserving data.
		///
		/// @sa ConvertToSmallestStorage
		/// </summary>
		// Token: 0x0601AE05 RID: 110085 RVA: 0x0025740F File Offset: 0x0025560F
		public void Squeeze()
		{
			vtkCellArray.vtkCellArray_Squeeze_80(base.GetCppThis());
		}

		// Token: 0x0601AE06 RID: 110086
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellArray_UpdateCellCount_81(HandleRef pThis, int npts);

		/// <summary>
		/// Used in conjunction with InsertNextCell(int npts) and InsertCellPoint() to
		/// update the number of points defining the cell.
		/// </summary>
		// Token: 0x0601AE07 RID: 110087 RVA: 0x0025741E File Offset: 0x0025561E
		public void UpdateCellCount(int npts)
		{
			vtkCellArray.vtkCellArray_UpdateCellCount_81(base.GetCppThis(), npts);
		}

		// Token: 0x0601AE08 RID: 110088
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellArray_Use32BitStorage_82(HandleRef pThis);

		/// <summary>
		/// Initialize internal data structures to use 32- or 64-bit storage.
		/// If selecting default storage, the storage depends on the VTK_USE_64BIT_IDS
		/// setting.
		///
		/// All existing data is erased.
		/// @{
		/// </summary>
		// Token: 0x0601AE09 RID: 110089 RVA: 0x0025742E File Offset: 0x0025562E
		public void Use32BitStorage()
		{
			vtkCellArray.vtkCellArray_Use32BitStorage_82(base.GetCppThis());
		}

		// Token: 0x0601AE0A RID: 110090
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellArray_Use64BitStorage_83(HandleRef pThis);

		/// <summary>
		/// Initialize internal data structures to use 32- or 64-bit storage.
		/// If selecting default storage, the storage depends on the VTK_USE_64BIT_IDS
		/// setting.
		///
		/// All existing data is erased.
		/// @{
		/// </summary>
		// Token: 0x0601AE0B RID: 110091 RVA: 0x0025743D File Offset: 0x0025563D
		public void Use64BitStorage()
		{
			vtkCellArray.vtkCellArray_Use64BitStorage_83(base.GetCppThis());
		}

		// Token: 0x0601AE0C RID: 110092
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellArray_UseDefaultStorage_84(HandleRef pThis);

		/// <summary>
		/// Initialize internal data structures to use 32- or 64-bit storage.
		/// If selecting default storage, the storage depends on the VTK_USE_64BIT_IDS
		/// setting.
		///
		/// All existing data is erased.
		/// @{
		/// </summary>
		// Token: 0x0601AE0D RID: 110093 RVA: 0x0025744C File Offset: 0x0025564C
		public void UseDefaultStorage()
		{
			vtkCellArray.vtkCellArray_UseDefaultStorage_84(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CFE RID: 7422
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellArray";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CFF RID: 7423
		public new static readonly string MRClassNameKey = "class vtkCellArray";
	}
}
