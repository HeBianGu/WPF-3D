using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExtractCells
	/// </summary>
	/// <remarks>
	///    subset a vtkDataSet to create a vtkUnstructuredGrid
	///
	/// Given a vtkDataSet and a list of cell ids, create a vtkUnstructuredGrid
	/// composed of these cells.  If the cell list is empty when vtkExtractCells
	/// executes, it will set up the ugrid, point and cell arrays, with no points,
	/// cells or data.
	///
	/// @warning
	/// This class is templated. It may run slower than serial execution if the code
	/// is not optimized during compilation. Build in Release or ReleaseWithDebugInfo.
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	/// </remarks>
	// Token: 0x02000963 RID: 2403
	public class vtkExtractCells : vtkUnstructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06018FD6 RID: 102358 RVA: 0x0022DCAB File Offset: 0x0022BEAB
		static vtkExtractCells()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractCells.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractCells"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06018FD7 RID: 102359 RVA: 0x0022DCD3 File Offset: 0x0022BED3
		public vtkExtractCells(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06018FD8 RID: 102360
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractCells_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for construction, type info, and printing.
		/// </summary>
		// Token: 0x06018FD9 RID: 102361 RVA: 0x0022DCE4 File Offset: 0x0022BEE4
		public new static vtkExtractCells New()
		{
			vtkExtractCells result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractCells.vtkExtractCells_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractCells)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for construction, type info, and printing.
		/// </summary>
		// Token: 0x06018FDA RID: 102362 RVA: 0x0022DD38 File Offset: 0x0022BF38
		public vtkExtractCells() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExtractCells.vtkExtractCells_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06018FDB RID: 102363 RVA: 0x0022DD7C File Offset: 0x0022BF7C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06018FDC RID: 102364
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractCells_AddCellIds_01(HandleRef pThis, IntPtr ptr, long numValues);

		/// <summary>
		/// Another way to provide ids using a pointer to vtkIdType array.
		/// </summary>
		// Token: 0x06018FDD RID: 102365 RVA: 0x0022DD87 File Offset: 0x0022BF87
		public void AddCellIds(IntPtr ptr, long numValues)
		{
			vtkExtractCells.vtkExtractCells_AddCellIds_01(base.GetCppThis(), ptr, numValues);
		}

		// Token: 0x06018FDE RID: 102366
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractCells_AddCellList_02(HandleRef pThis, HandleRef l);

		/// <summary>
		/// Add the supplied list of cell IDs to those that will be included in the
		/// output vtkUnstructuredGrid. The cell ids should be &gt;=0.
		/// </summary>
		// Token: 0x06018FDF RID: 102367 RVA: 0x0022DD98 File Offset: 0x0022BF98
		public void AddCellList(vtkIdList l)
		{
			vtkExtractCells.vtkExtractCells_AddCellList_02(base.GetCppThis(), (l == null) ? default(HandleRef) : l.GetCppThis());
		}

		// Token: 0x06018FE0 RID: 102368
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractCells_AddCellRange_03(HandleRef pThis, long from, long to);

		/// <summary>
		/// Add this range of cell IDs to those that will be included in the output
		/// vtkUnstructuredGrid. Note that (from &lt; to), and (from &gt;= 0).
		/// </summary>
		// Token: 0x06018FE1 RID: 102369 RVA: 0x0022DDC7 File Offset: 0x0022BFC7
		public void AddCellRange(long from, long to)
		{
			vtkExtractCells.vtkExtractCells_AddCellRange_03(base.GetCppThis(), from, to);
		}

		// Token: 0x06018FE2 RID: 102370
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractCells_AssumeSortedAndUniqueIdsOff_04(HandleRef pThis);

		/// <summary>
		/// If the cell ids specified are already sorted and unique, then set this to
		/// true to avoid the filter from doing time-consuming sorts and uniquification
		/// operations. Defaults to false.
		/// </summary>
		// Token: 0x06018FE3 RID: 102371 RVA: 0x0022DDD8 File Offset: 0x0022BFD8
		public virtual void AssumeSortedAndUniqueIdsOff()
		{
			vtkExtractCells.vtkExtractCells_AssumeSortedAndUniqueIdsOff_04(base.GetCppThis());
		}

		// Token: 0x06018FE4 RID: 102372
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractCells_AssumeSortedAndUniqueIdsOn_05(HandleRef pThis);

		/// <summary>
		/// If the cell ids specified are already sorted and unique, then set this to
		/// true to avoid the filter from doing time-consuming sorts and uniquification
		/// operations. Defaults to false.
		/// </summary>
		// Token: 0x06018FE5 RID: 102373 RVA: 0x0022DDE7 File Offset: 0x0022BFE7
		public virtual void AssumeSortedAndUniqueIdsOn()
		{
			vtkExtractCells.vtkExtractCells_AssumeSortedAndUniqueIdsOn_05(base.GetCppThis());
		}

		// Token: 0x06018FE6 RID: 102374
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractCells_ExtractAllCellsOff_06(HandleRef pThis);

		/// <summary>
		/// If all cells are being extracted, this filter can use fast path to speed up
		/// the extraction. In that case, one can set this flag to true. When set to
		/// true, cell ids added via the various methods are simply ignored.
		/// Defaults to false.
		/// </summary>
		// Token: 0x06018FE7 RID: 102375 RVA: 0x0022DDF6 File Offset: 0x0022BFF6
		public virtual void ExtractAllCellsOff()
		{
			vtkExtractCells.vtkExtractCells_ExtractAllCellsOff_06(base.GetCppThis());
		}

		// Token: 0x06018FE8 RID: 102376
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractCells_ExtractAllCellsOn_07(HandleRef pThis);

		/// <summary>
		/// If all cells are being extracted, this filter can use fast path to speed up
		/// the extraction. In that case, one can set this flag to true. When set to
		/// true, cell ids added via the various methods are simply ignored.
		/// Defaults to false.
		/// </summary>
		// Token: 0x06018FE9 RID: 102377 RVA: 0x0022DE05 File Offset: 0x0022C005
		public virtual void ExtractAllCellsOn()
		{
			vtkExtractCells.vtkExtractCells_ExtractAllCellsOn_07(base.GetCppThis());
		}

		// Token: 0x06018FEA RID: 102378
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExtractCells_GetAssumeSortedAndUniqueIds_08(HandleRef pThis);

		/// <summary>
		/// If the cell ids specified are already sorted and unique, then set this to
		/// true to avoid the filter from doing time-consuming sorts and uniquification
		/// operations. Defaults to false.
		/// </summary>
		// Token: 0x06018FEB RID: 102379 RVA: 0x0022DE14 File Offset: 0x0022C014
		public virtual bool GetAssumeSortedAndUniqueIds()
		{
			return vtkExtractCells.vtkExtractCells_GetAssumeSortedAndUniqueIds_08(base.GetCppThis()) != 0;
		}

		// Token: 0x06018FEC RID: 102380
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkExtractCells_GetBatchSize_09(HandleRef pThis);

		/// <summary>
		/// Specify the number of input cells in a batch, where a batch defines
		/// a subset of the input cells operated on during threaded
		/// execution. Generally this is only used for debugging or performance
		/// studies (since batch size affects the thread workload).
		///
		/// Default is 1000.
		/// </summary>
		// Token: 0x06018FED RID: 102381 RVA: 0x0022DE3C File Offset: 0x0022C03C
		public virtual uint GetBatchSize()
		{
			return vtkExtractCells.vtkExtractCells_GetBatchSize_09(base.GetCppThis());
		}

		// Token: 0x06018FEE RID: 102382
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkExtractCells_GetBatchSizeMaxValue_10(HandleRef pThis);

		/// <summary>
		/// Specify the number of input cells in a batch, where a batch defines
		/// a subset of the input cells operated on during threaded
		/// execution. Generally this is only used for debugging or performance
		/// studies (since batch size affects the thread workload).
		///
		/// Default is 1000.
		/// </summary>
		// Token: 0x06018FEF RID: 102383 RVA: 0x0022DE5C File Offset: 0x0022C05C
		public virtual uint GetBatchSizeMaxValue()
		{
			return vtkExtractCells.vtkExtractCells_GetBatchSizeMaxValue_10(base.GetCppThis());
		}

		// Token: 0x06018FF0 RID: 102384
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkExtractCells_GetBatchSizeMinValue_11(HandleRef pThis);

		/// <summary>
		/// Specify the number of input cells in a batch, where a batch defines
		/// a subset of the input cells operated on during threaded
		/// execution. Generally this is only used for debugging or performance
		/// studies (since batch size affects the thread workload).
		///
		/// Default is 1000.
		/// </summary>
		// Token: 0x06018FF1 RID: 102385 RVA: 0x0022DE7C File Offset: 0x0022C07C
		public virtual uint GetBatchSizeMinValue()
		{
			return vtkExtractCells.vtkExtractCells_GetBatchSizeMinValue_11(base.GetCppThis());
		}

		// Token: 0x06018FF2 RID: 102386
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExtractCells_GetExtractAllCells_12(HandleRef pThis);

		/// <summary>
		/// If all cells are being extracted, this filter can use fast path to speed up
		/// the extraction. In that case, one can set this flag to true. When set to
		/// true, cell ids added via the various methods are simply ignored.
		/// Defaults to false.
		/// </summary>
		// Token: 0x06018FF3 RID: 102387 RVA: 0x0022DE9C File Offset: 0x0022C09C
		public virtual bool GetExtractAllCells()
		{
			return vtkExtractCells.vtkExtractCells_GetExtractAllCells_12(base.GetCppThis()) != 0;
		}

		// Token: 0x06018FF4 RID: 102388
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractCells_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for construction, type info, and printing.
		/// </summary>
		// Token: 0x06018FF5 RID: 102389 RVA: 0x0022DEC4 File Offset: 0x0022C0C4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExtractCells.vtkExtractCells_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x06018FF6 RID: 102390
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractCells_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for construction, type info, and printing.
		/// </summary>
		// Token: 0x06018FF7 RID: 102391 RVA: 0x0022DEE4 File Offset: 0x0022C0E4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExtractCells.vtkExtractCells_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x06018FF8 RID: 102392
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractCells_GetOutputPointsPrecision_15(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06018FF9 RID: 102393 RVA: 0x0022DF00 File Offset: 0x0022C100
		public virtual int GetOutputPointsPrecision()
		{
			return vtkExtractCells.vtkExtractCells_GetOutputPointsPrecision_15(base.GetCppThis());
		}

		// Token: 0x06018FFA RID: 102394
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExtractCells_GetPassThroughCellIds_16(HandleRef pThis);

		/// <summary>
		/// If on, the output dataset will have a celldata array that
		/// holds the cell index of the original 3D cell that produced each output
		/// cell. The default is on
		/// </summary>
		// Token: 0x06018FFB RID: 102395 RVA: 0x0022DF20 File Offset: 0x0022C120
		public virtual bool GetPassThroughCellIds()
		{
			return vtkExtractCells.vtkExtractCells_GetPassThroughCellIds_16(base.GetCppThis()) != 0;
		}

		// Token: 0x06018FFC RID: 102396
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractCells_IsA_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for construction, type info, and printing.
		/// </summary>
		// Token: 0x06018FFD RID: 102397 RVA: 0x0022DF48 File Offset: 0x0022C148
		public override int IsA(string type)
		{
			return vtkExtractCells.vtkExtractCells_IsA_17(base.GetCppThis(), type);
		}

		// Token: 0x06018FFE RID: 102398
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractCells_IsTypeOf_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for construction, type info, and printing.
		/// </summary>
		// Token: 0x06018FFF RID: 102399 RVA: 0x0022DF68 File Offset: 0x0022C168
		public new static int IsTypeOf(string type)
		{
			return vtkExtractCells.vtkExtractCells_IsTypeOf_18(type);
		}

		// Token: 0x06019000 RID: 102400
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractCells_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for construction, type info, and printing.
		/// </summary>
		// Token: 0x06019001 RID: 102401 RVA: 0x0022DF84 File Offset: 0x0022C184
		public new vtkExtractCells NewInstance()
		{
			vtkExtractCells result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractCells.vtkExtractCells_NewInstance_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractCells)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06019002 RID: 102402
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractCells_PassThroughCellIdsOff_21(HandleRef pThis);

		/// <summary>
		/// If on, the output dataset will have a celldata array that
		/// holds the cell index of the original 3D cell that produced each output
		/// cell. The default is on
		/// </summary>
		// Token: 0x06019003 RID: 102403 RVA: 0x0022DFDE File Offset: 0x0022C1DE
		public virtual void PassThroughCellIdsOff()
		{
			vtkExtractCells.vtkExtractCells_PassThroughCellIdsOff_21(base.GetCppThis());
		}

		// Token: 0x06019004 RID: 102404
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractCells_PassThroughCellIdsOn_22(HandleRef pThis);

		/// <summary>
		/// If on, the output dataset will have a celldata array that
		/// holds the cell index of the original 3D cell that produced each output
		/// cell. The default is on
		/// </summary>
		// Token: 0x06019005 RID: 102405 RVA: 0x0022DFED File Offset: 0x0022C1ED
		public virtual void PassThroughCellIdsOn()
		{
			vtkExtractCells.vtkExtractCells_PassThroughCellIdsOn_22(base.GetCppThis());
		}

		// Token: 0x06019006 RID: 102406
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractCells_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for construction, type info, and printing.
		/// </summary>
		// Token: 0x06019007 RID: 102407 RVA: 0x0022DFFC File Offset: 0x0022C1FC
		public new static vtkExtractCells SafeDownCast(vtkObjectBase o)
		{
			vtkExtractCells vtkExtractCells = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractCells.vtkExtractCells_SafeDownCast_23((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractCells = (vtkExtractCells)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractCells.Register(null);
				}
			}
			return vtkExtractCells;
		}

		// Token: 0x06019008 RID: 102408
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractCells_SetAssumeSortedAndUniqueIds_24(HandleRef pThis, byte _arg);

		/// <summary>
		/// If the cell ids specified are already sorted and unique, then set this to
		/// true to avoid the filter from doing time-consuming sorts and uniquification
		/// operations. Defaults to false.
		/// </summary>
		// Token: 0x06019009 RID: 102409 RVA: 0x0022E07B File Offset: 0x0022C27B
		public virtual void SetAssumeSortedAndUniqueIds(bool _arg)
		{
			vtkExtractCells.vtkExtractCells_SetAssumeSortedAndUniqueIds_24(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0601900A RID: 102410
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractCells_SetBatchSize_25(HandleRef pThis, uint _arg);

		/// <summary>
		/// Specify the number of input cells in a batch, where a batch defines
		/// a subset of the input cells operated on during threaded
		/// execution. Generally this is only used for debugging or performance
		/// studies (since batch size affects the thread workload).
		///
		/// Default is 1000.
		/// </summary>
		// Token: 0x0601900B RID: 102411 RVA: 0x0022E093 File Offset: 0x0022C293
		public virtual void SetBatchSize(uint _arg)
		{
			vtkExtractCells.vtkExtractCells_SetBatchSize_25(base.GetCppThis(), _arg);
		}

		// Token: 0x0601900C RID: 102412
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractCells_SetCellIds_26(HandleRef pThis, IntPtr ptr, long numValues);

		/// <summary>
		/// Another way to provide ids using a pointer to vtkIdType array.
		/// </summary>
		// Token: 0x0601900D RID: 102413 RVA: 0x0022E0A3 File Offset: 0x0022C2A3
		public void SetCellIds(IntPtr ptr, long numValues)
		{
			vtkExtractCells.vtkExtractCells_SetCellIds_26(base.GetCppThis(), ptr, numValues);
		}

		// Token: 0x0601900E RID: 102414
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractCells_SetCellList_27(HandleRef pThis, HandleRef l);

		/// <summary>
		/// Set the list of cell IDs that the output vtkUnstructuredGrid will be
		/// composed of.  Replaces any other cell ID list supplied so far.  (Set to
		/// nullptr to free memory used by cell list.)  The cell ids should be &gt;=0.
		/// </summary>
		// Token: 0x0601900F RID: 102415 RVA: 0x0022E0B4 File Offset: 0x0022C2B4
		public void SetCellList(vtkIdList l)
		{
			vtkExtractCells.vtkExtractCells_SetCellList_27(base.GetCppThis(), (l == null) ? default(HandleRef) : l.GetCppThis());
		}

		// Token: 0x06019010 RID: 102416
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractCells_SetExtractAllCells_28(HandleRef pThis, byte _arg);

		/// <summary>
		/// If all cells are being extracted, this filter can use fast path to speed up
		/// the extraction. In that case, one can set this flag to true. When set to
		/// true, cell ids added via the various methods are simply ignored.
		/// Defaults to false.
		/// </summary>
		// Token: 0x06019011 RID: 102417 RVA: 0x0022E0E3 File Offset: 0x0022C2E3
		public virtual void SetExtractAllCells(bool _arg)
		{
			vtkExtractCells.vtkExtractCells_SetExtractAllCells_28(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06019012 RID: 102418
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractCells_SetOutputPointsPrecision_29(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06019013 RID: 102419 RVA: 0x0022E0FB File Offset: 0x0022C2FB
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkExtractCells.vtkExtractCells_SetOutputPointsPrecision_29(base.GetCppThis(), _arg);
		}

		// Token: 0x06019014 RID: 102420
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractCells_SetPassThroughCellIds_30(HandleRef pThis, byte _arg);

		/// <summary>
		/// If on, the output dataset will have a celldata array that
		/// holds the cell index of the original 3D cell that produced each output
		/// cell. The default is on
		/// </summary>
		// Token: 0x06019015 RID: 102421 RVA: 0x0022E10B File Offset: 0x0022C30B
		public virtual void SetPassThroughCellIds(bool _arg)
		{
			vtkExtractCells.vtkExtractCells_SetPassThroughCellIds_30(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B7F RID: 7039
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractCells";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B80 RID: 7040
		public new static readonly string MRClassNameKey = "class vtkExtractCells";
	}
}
