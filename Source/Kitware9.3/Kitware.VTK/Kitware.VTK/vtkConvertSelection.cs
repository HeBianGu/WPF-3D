using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkConvertSelection
	/// </summary>
	/// <remarks>
	///    Convert a selection from one type to another
	///
	///
	/// vtkConvertSelection converts an input selection from one type to another
	/// in the context of a data object being selected. The first input is the
	/// selection, while the second input is the data object that the selection
	/// relates to.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkSelection vtkSelectionNode vtkExtractSelection vtkExtractSelectedGraph
	/// </seealso>
	// Token: 0x020006A4 RID: 1700
	public class vtkConvertSelection : vtkSelectionAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060122DA RID: 74458 RVA: 0x001974AF File Offset: 0x001956AF
		static vtkConvertSelection()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkConvertSelection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkConvertSelection"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060122DB RID: 74459 RVA: 0x001974D7 File Offset: 0x001956D7
		public vtkConvertSelection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060122DC RID: 74460
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConvertSelection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060122DD RID: 74461 RVA: 0x001974E8 File Offset: 0x001956E8
		public new static vtkConvertSelection New()
		{
			vtkConvertSelection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConvertSelection.vtkConvertSelection_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkConvertSelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060122DE RID: 74462 RVA: 0x0019753C File Offset: 0x0019573C
		public vtkConvertSelection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkConvertSelection.vtkConvertSelection_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060122DF RID: 74463 RVA: 0x00197580 File Offset: 0x00195780
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060122E0 RID: 74464
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConvertSelection_AddArrayName_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Convenience methods used by UI
		/// </summary>
		// Token: 0x060122E1 RID: 74465 RVA: 0x0019758B File Offset: 0x0019578B
		public void AddArrayName(string arg0)
		{
			vtkConvertSelection.vtkConvertSelection_AddArrayName_01(base.GetCppThis(), arg0);
		}

		// Token: 0x060122E2 RID: 74466
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConvertSelection_AllowMissingArrayOff_02(HandleRef pThis);

		/// <summary>
		/// When enabled, not finding expected array will not return an error.
		/// Defaults to OFF.
		/// </summary>
		// Token: 0x060122E3 RID: 74467 RVA: 0x0019759B File Offset: 0x0019579B
		public virtual void AllowMissingArrayOff()
		{
			vtkConvertSelection.vtkConvertSelection_AllowMissingArrayOff_02(base.GetCppThis());
		}

		// Token: 0x060122E4 RID: 74468
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConvertSelection_AllowMissingArrayOn_03(HandleRef pThis);

		/// <summary>
		/// When enabled, not finding expected array will not return an error.
		/// Defaults to OFF.
		/// </summary>
		// Token: 0x060122E5 RID: 74469 RVA: 0x001975AA File Offset: 0x001957AA
		public virtual void AllowMissingArrayOn()
		{
			vtkConvertSelection.vtkConvertSelection_AllowMissingArrayOn_03(base.GetCppThis());
		}

		// Token: 0x060122E6 RID: 74470
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConvertSelection_ClearArrayNames_04(HandleRef pThis);

		/// <summary>
		/// Convenience methods used by UI
		/// </summary>
		// Token: 0x060122E7 RID: 74471 RVA: 0x001975B9 File Offset: 0x001957B9
		public void ClearArrayNames()
		{
			vtkConvertSelection.vtkConvertSelection_ClearArrayNames_04(base.GetCppThis());
		}

		// Token: 0x060122E8 RID: 74472
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkConvertSelection_GetAllowMissingArray_05(HandleRef pThis);

		/// <summary>
		/// When enabled, not finding expected array will not return an error.
		/// Defaults to OFF.
		/// </summary>
		// Token: 0x060122E9 RID: 74473 RVA: 0x001975C8 File Offset: 0x001957C8
		public virtual bool GetAllowMissingArray()
		{
			return vtkConvertSelection.vtkConvertSelection_GetAllowMissingArray_05(base.GetCppThis()) != 0;
		}

		// Token: 0x060122EA RID: 74474
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConvertSelection_GetArrayName_06(HandleRef pThis);

		/// <summary>
		/// The output array name for value or threshold selections.
		/// </summary>
		// Token: 0x060122EB RID: 74475 RVA: 0x001975F0 File Offset: 0x001957F0
		public virtual string GetArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkConvertSelection.vtkConvertSelection_GetArrayName_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060122EC RID: 74476
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConvertSelection_GetArrayNames_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The output array names for value selection.
		/// </summary>
		// Token: 0x060122ED RID: 74477 RVA: 0x0019762C File Offset: 0x0019582C
		public virtual vtkStringArray GetArrayNames()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConvertSelection.vtkConvertSelection_GetArrayNames_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringArray = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringArray.Register(null);
				}
			}
			return vtkStringArray;
		}

		// Token: 0x060122EE RID: 74478
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConvertSelection_GetInputFieldType_08(HandleRef pThis);

		/// <summary>
		/// The input field type.
		/// If this is set to a number other than -1, ignores the input selection
		/// field type and instead assumes that all selection nodes have the
		/// field type specified.
		/// This should be one of the constants defined in vtkSelectionNode.h.
		/// Default is -1.
		/// </summary>
		// Token: 0x060122EF RID: 74479 RVA: 0x0019769C File Offset: 0x0019589C
		public virtual int GetInputFieldType()
		{
			return vtkConvertSelection.vtkConvertSelection_GetInputFieldType_08(base.GetCppThis());
		}

		// Token: 0x060122F0 RID: 74480
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkConvertSelection_GetMatchAnyValues_09(HandleRef pThis);

		/// <summary>
		/// When on, creates a separate selection node for each array.
		/// Defaults to OFF.
		/// </summary>
		// Token: 0x060122F1 RID: 74481 RVA: 0x001976BC File Offset: 0x001958BC
		public virtual bool GetMatchAnyValues()
		{
			return vtkConvertSelection.vtkConvertSelection_GetMatchAnyValues_09(base.GetCppThis()) != 0;
		}

		// Token: 0x060122F2 RID: 74482
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkConvertSelection_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060122F3 RID: 74483 RVA: 0x001976E4 File Offset: 0x001958E4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkConvertSelection.vtkConvertSelection_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x060122F4 RID: 74484
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkConvertSelection_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060122F5 RID: 74485 RVA: 0x00197704 File Offset: 0x00195904
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkConvertSelection.vtkConvertSelection_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x060122F6 RID: 74486
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConvertSelection_GetOutputType_12(HandleRef pThis);

		/// <summary>
		/// The output selection content type.
		/// This should be one of the constants defined in vtkSelectionNode.h.
		/// </summary>
		// Token: 0x060122F7 RID: 74487 RVA: 0x00197720 File Offset: 0x00195920
		public virtual int GetOutputType()
		{
			return vtkConvertSelection.vtkConvertSelection_GetOutputType_12(base.GetCppThis());
		}

		// Token: 0x060122F8 RID: 74488
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConvertSelection_GetSelectedCells_13(HandleRef input, HandleRef data, HandleRef indices);

		/// <summary>
		/// Static methods for easily obtaining selected items from a data object.
		/// The array argument will be filled with the selected items.
		/// </summary>
		// Token: 0x060122F9 RID: 74489 RVA: 0x00197740 File Offset: 0x00195940
		public static void GetSelectedCells(vtkSelection input, vtkDataSet data, vtkIdTypeArray indices)
		{
			vtkConvertSelection.vtkConvertSelection_GetSelectedCells_13((input == null) ? default(HandleRef) : input.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), (indices == null) ? default(HandleRef) : indices.GetCppThis());
		}

		// Token: 0x060122FA RID: 74490
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConvertSelection_GetSelectedEdges_14(HandleRef input, HandleRef data, HandleRef indices);

		/// <summary>
		/// Static methods for easily obtaining selected items from a data object.
		/// The array argument will be filled with the selected items.
		/// </summary>
		// Token: 0x060122FB RID: 74491 RVA: 0x00197794 File Offset: 0x00195994
		public static void GetSelectedEdges(vtkSelection input, vtkGraph data, vtkIdTypeArray indices)
		{
			vtkConvertSelection.vtkConvertSelection_GetSelectedEdges_14((input == null) ? default(HandleRef) : input.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), (indices == null) ? default(HandleRef) : indices.GetCppThis());
		}

		// Token: 0x060122FC RID: 74492
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConvertSelection_GetSelectedItems_15(HandleRef input, HandleRef data, int fieldType, HandleRef indices);

		/// <summary>
		/// Static generic method for obtaining selected items from a data object.
		/// Other static methods (e.g. GetSelectedVertices) call this one.
		/// </summary>
		// Token: 0x060122FD RID: 74493 RVA: 0x001977E8 File Offset: 0x001959E8
		public static void GetSelectedItems(vtkSelection input, vtkDataObject data, int fieldType, vtkIdTypeArray indices)
		{
			vtkConvertSelection.vtkConvertSelection_GetSelectedItems_15((input == null) ? default(HandleRef) : input.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), fieldType, (indices == null) ? default(HandleRef) : indices.GetCppThis());
		}

		// Token: 0x060122FE RID: 74494
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConvertSelection_GetSelectedPoints_16(HandleRef input, HandleRef data, HandleRef indices);

		/// <summary>
		/// Static methods for easily obtaining selected items from a data object.
		/// The array argument will be filled with the selected items.
		/// </summary>
		// Token: 0x060122FF RID: 74495 RVA: 0x0019783C File Offset: 0x00195A3C
		public static void GetSelectedPoints(vtkSelection input, vtkDataSet data, vtkIdTypeArray indices)
		{
			vtkConvertSelection.vtkConvertSelection_GetSelectedPoints_16((input == null) ? default(HandleRef) : input.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), (indices == null) ? default(HandleRef) : indices.GetCppThis());
		}

		// Token: 0x06012300 RID: 74496
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConvertSelection_GetSelectedRows_17(HandleRef input, HandleRef data, HandleRef indices);

		/// <summary>
		/// Static methods for easily obtaining selected items from a data object.
		/// The array argument will be filled with the selected items.
		/// </summary>
		// Token: 0x06012301 RID: 74497 RVA: 0x00197890 File Offset: 0x00195A90
		public static void GetSelectedRows(vtkSelection input, vtkTable data, vtkIdTypeArray indices)
		{
			vtkConvertSelection.vtkConvertSelection_GetSelectedRows_17((input == null) ? default(HandleRef) : input.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), (indices == null) ? default(HandleRef) : indices.GetCppThis());
		}

		// Token: 0x06012302 RID: 74498
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConvertSelection_GetSelectedVertices_18(HandleRef input, HandleRef data, HandleRef indices);

		/// <summary>
		/// Static methods for easily obtaining selected items from a data object.
		/// The array argument will be filled with the selected items.
		/// </summary>
		// Token: 0x06012303 RID: 74499 RVA: 0x001978E4 File Offset: 0x00195AE4
		public static void GetSelectedVertices(vtkSelection input, vtkGraph data, vtkIdTypeArray indices)
		{
			vtkConvertSelection.vtkConvertSelection_GetSelectedVertices_18((input == null) ? default(HandleRef) : input.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), (indices == null) ? default(HandleRef) : indices.GetCppThis());
		}

		// Token: 0x06012304 RID: 74500
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConvertSelection_GetSelectionExtractor_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get a selection extractor used in some conversions to
		/// obtain IDs.
		/// </summary>
		// Token: 0x06012305 RID: 74501 RVA: 0x00197938 File Offset: 0x00195B38
		public virtual vtkExtractSelection GetSelectionExtractor()
		{
			vtkExtractSelection vtkExtractSelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConvertSelection.vtkConvertSelection_GetSelectionExtractor_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractSelection = (vtkExtractSelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractSelection.Register(null);
				}
			}
			return vtkExtractSelection;
		}

		// Token: 0x06012306 RID: 74502
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConvertSelection_IsA_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012307 RID: 74503 RVA: 0x001979A8 File Offset: 0x00195BA8
		public override int IsA(string type)
		{
			return vtkConvertSelection.vtkConvertSelection_IsA_20(base.GetCppThis(), type);
		}

		// Token: 0x06012308 RID: 74504
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConvertSelection_IsTypeOf_21([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012309 RID: 74505 RVA: 0x001979C8 File Offset: 0x00195BC8
		public new static int IsTypeOf(string type)
		{
			return vtkConvertSelection.vtkConvertSelection_IsTypeOf_21(type);
		}

		// Token: 0x0601230A RID: 74506
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConvertSelection_MatchAnyValuesOff_22(HandleRef pThis);

		/// <summary>
		/// When on, creates a separate selection node for each array.
		/// Defaults to OFF.
		/// </summary>
		// Token: 0x0601230B RID: 74507 RVA: 0x001979E2 File Offset: 0x00195BE2
		public virtual void MatchAnyValuesOff()
		{
			vtkConvertSelection.vtkConvertSelection_MatchAnyValuesOff_22(base.GetCppThis());
		}

		// Token: 0x0601230C RID: 74508
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConvertSelection_MatchAnyValuesOn_23(HandleRef pThis);

		/// <summary>
		/// When on, creates a separate selection node for each array.
		/// Defaults to OFF.
		/// </summary>
		// Token: 0x0601230D RID: 74509 RVA: 0x001979F1 File Offset: 0x00195BF1
		public virtual void MatchAnyValuesOn()
		{
			vtkConvertSelection.vtkConvertSelection_MatchAnyValuesOn_23(base.GetCppThis());
		}

		// Token: 0x0601230E RID: 74510
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConvertSelection_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601230F RID: 74511 RVA: 0x00197A00 File Offset: 0x00195C00
		public new vtkConvertSelection NewInstance()
		{
			vtkConvertSelection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConvertSelection.vtkConvertSelection_NewInstance_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkConvertSelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012310 RID: 74512
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConvertSelection_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012311 RID: 74513 RVA: 0x00197A5C File Offset: 0x00195C5C
		public new static vtkConvertSelection SafeDownCast(vtkObjectBase o)
		{
			vtkConvertSelection vtkConvertSelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConvertSelection.vtkConvertSelection_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkConvertSelection = (vtkConvertSelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkConvertSelection.Register(null);
				}
			}
			return vtkConvertSelection;
		}

		// Token: 0x06012312 RID: 74514
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConvertSelection_SetAllowMissingArray_27(HandleRef pThis, byte _arg);

		/// <summary>
		/// When enabled, not finding expected array will not return an error.
		/// Defaults to OFF.
		/// </summary>
		// Token: 0x06012313 RID: 74515 RVA: 0x00197ADB File Offset: 0x00195CDB
		public virtual void SetAllowMissingArray(bool _arg)
		{
			vtkConvertSelection.vtkConvertSelection_SetAllowMissingArray_27(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06012314 RID: 74516
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConvertSelection_SetArrayName_28(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// The output array name for value or threshold selections.
		/// </summary>
		// Token: 0x06012315 RID: 74517 RVA: 0x00197AF3 File Offset: 0x00195CF3
		public virtual void SetArrayName(string arg0)
		{
			vtkConvertSelection.vtkConvertSelection_SetArrayName_28(base.GetCppThis(), arg0);
		}

		// Token: 0x06012316 RID: 74518
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConvertSelection_SetArrayNames_29(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// The output array names for value selection.
		/// </summary>
		// Token: 0x06012317 RID: 74519 RVA: 0x00197B04 File Offset: 0x00195D04
		public virtual void SetArrayNames(vtkStringArray arg0)
		{
			vtkConvertSelection.vtkConvertSelection_SetArrayNames_29(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06012318 RID: 74520
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConvertSelection_SetDataObjectConnection_30(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// A convenience method for setting the second input (i.e. the data object).
		/// </summary>
		// Token: 0x06012319 RID: 74521 RVA: 0x00197B34 File Offset: 0x00195D34
		public void SetDataObjectConnection(vtkAlgorithmOutput arg0)
		{
			vtkConvertSelection.vtkConvertSelection_SetDataObjectConnection_30(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601231A RID: 74522
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConvertSelection_SetInputFieldType_31(HandleRef pThis, int _arg);

		/// <summary>
		/// The input field type.
		/// If this is set to a number other than -1, ignores the input selection
		/// field type and instead assumes that all selection nodes have the
		/// field type specified.
		/// This should be one of the constants defined in vtkSelectionNode.h.
		/// Default is -1.
		/// </summary>
		// Token: 0x0601231B RID: 74523 RVA: 0x00197B63 File Offset: 0x00195D63
		public virtual void SetInputFieldType(int _arg)
		{
			vtkConvertSelection.vtkConvertSelection_SetInputFieldType_31(base.GetCppThis(), _arg);
		}

		// Token: 0x0601231C RID: 74524
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConvertSelection_SetMatchAnyValues_32(HandleRef pThis, byte _arg);

		/// <summary>
		/// When on, creates a separate selection node for each array.
		/// Defaults to OFF.
		/// </summary>
		// Token: 0x0601231D RID: 74525 RVA: 0x00197B73 File Offset: 0x00195D73
		public virtual void SetMatchAnyValues(bool _arg)
		{
			vtkConvertSelection.vtkConvertSelection_SetMatchAnyValues_32(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0601231E RID: 74526
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConvertSelection_SetOutputType_33(HandleRef pThis, int _arg);

		/// <summary>
		/// The output selection content type.
		/// This should be one of the constants defined in vtkSelectionNode.h.
		/// </summary>
		// Token: 0x0601231F RID: 74527 RVA: 0x00197B8B File Offset: 0x00195D8B
		public virtual void SetOutputType(int _arg)
		{
			vtkConvertSelection.vtkConvertSelection_SetOutputType_33(base.GetCppThis(), _arg);
		}

		// Token: 0x06012320 RID: 74528
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConvertSelection_SetSelectionExtractor_34(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/get a selection extractor used in some conversions to
		/// obtain IDs.
		/// </summary>
		// Token: 0x06012321 RID: 74529 RVA: 0x00197B9C File Offset: 0x00195D9C
		public virtual void SetSelectionExtractor(vtkExtractSelection arg0)
		{
			vtkConvertSelection.vtkConvertSelection_SetSelectionExtractor_34(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06012322 RID: 74530
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConvertSelection_ToGlobalIdSelection_35(HandleRef input, HandleRef data, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Static methods for easily converting between selection types.
		/// NOTE: The returned selection pointer IS reference counted,
		/// so be sure to Delete() it when you are done with it.
		/// </summary>
		// Token: 0x06012323 RID: 74531 RVA: 0x00197BCC File Offset: 0x00195DCC
		public static vtkSelection ToGlobalIdSelection(vtkSelection input, vtkDataObject data)
		{
			vtkSelection vtkSelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConvertSelection.vtkConvertSelection_ToGlobalIdSelection_35((input == null) ? default(HandleRef) : input.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSelection = (vtkSelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSelection.Register(null);
				}
			}
			return vtkSelection;
		}

		// Token: 0x06012324 RID: 74532
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConvertSelection_ToIndexSelection_36(HandleRef input, HandleRef data, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Static methods for easily converting between selection types.
		/// NOTE: The returned selection pointer IS reference counted,
		/// so be sure to Delete() it when you are done with it.
		/// </summary>
		// Token: 0x06012325 RID: 74533 RVA: 0x00197C64 File Offset: 0x00195E64
		public static vtkSelection ToIndexSelection(vtkSelection input, vtkDataObject data)
		{
			vtkSelection vtkSelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConvertSelection.vtkConvertSelection_ToIndexSelection_36((input == null) ? default(HandleRef) : input.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSelection = (vtkSelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSelection.Register(null);
				}
			}
			return vtkSelection;
		}

		// Token: 0x06012326 RID: 74534
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConvertSelection_ToPedigreeIdSelection_37(HandleRef input, HandleRef data, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Static methods for easily converting between selection types.
		/// NOTE: The returned selection pointer IS reference counted,
		/// so be sure to Delete() it when you are done with it.
		/// </summary>
		// Token: 0x06012327 RID: 74535 RVA: 0x00197CFC File Offset: 0x00195EFC
		public static vtkSelection ToPedigreeIdSelection(vtkSelection input, vtkDataObject data)
		{
			vtkSelection vtkSelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConvertSelection.vtkConvertSelection_ToPedigreeIdSelection_37((input == null) ? default(HandleRef) : input.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSelection = (vtkSelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSelection.Register(null);
				}
			}
			return vtkSelection;
		}

		// Token: 0x06012328 RID: 74536
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConvertSelection_ToSelectionType_38(HandleRef input, HandleRef data, int type, HandleRef arrayNames, int inputFieldType, byte allowMissingArray, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// A generic static method for converting selection types.
		/// The type should be an integer constant defined in vtkSelectionNode.h.
		/// </summary>
		// Token: 0x06012329 RID: 74537 RVA: 0x00197D94 File Offset: 0x00195F94
		public static vtkSelection ToSelectionType(vtkSelection input, vtkDataObject data, int type, vtkStringArray arrayNames, int inputFieldType, bool allowMissingArray)
		{
			vtkSelection vtkSelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConvertSelection.vtkConvertSelection_ToSelectionType_38((input == null) ? default(HandleRef) : input.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), type, (arrayNames == null) ? default(HandleRef) : arrayNames.GetCppThis(), inputFieldType, allowMissingArray ? (byte)1 : (byte)0, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSelection = (vtkSelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSelection.Register(null);
				}
			}
			return vtkSelection;
		}

		// Token: 0x0601232A RID: 74538
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConvertSelection_ToValueSelection_39(HandleRef input, HandleRef data, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Static methods for easily converting between selection types.
		/// NOTE: The returned selection pointer IS reference counted,
		/// so be sure to Delete() it when you are done with it.
		/// </summary>
		// Token: 0x0601232B RID: 74539 RVA: 0x00197E4C File Offset: 0x0019604C
		public static vtkSelection ToValueSelection(vtkSelection input, vtkDataObject data, string arrayName)
		{
			vtkSelection vtkSelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConvertSelection.vtkConvertSelection_ToValueSelection_39((input == null) ? default(HandleRef) : input.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), arrayName, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSelection = (vtkSelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSelection.Register(null);
				}
			}
			return vtkSelection;
		}

		// Token: 0x0601232C RID: 74540
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConvertSelection_ToValueSelection_40(HandleRef input, HandleRef data, HandleRef arrayNames, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Static methods for easily converting between selection types.
		/// NOTE: The returned selection pointer IS reference counted,
		/// so be sure to Delete() it when you are done with it.
		/// </summary>
		// Token: 0x0601232D RID: 74541 RVA: 0x00197EE4 File Offset: 0x001960E4
		public static vtkSelection ToValueSelection(vtkSelection input, vtkDataObject data, vtkStringArray arrayNames)
		{
			vtkSelection vtkSelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConvertSelection.vtkConvertSelection_ToValueSelection_40((input == null) ? default(HandleRef) : input.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), (arrayNames == null) ? default(HandleRef) : arrayNames.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSelection = (vtkSelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSelection.Register(null);
				}
			}
			return vtkSelection;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014F6 RID: 5366
		public new const string MRFullTypeName = "Kitware.VTK.vtkConvertSelection";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014F7 RID: 5367
		public new static readonly string MRClassNameKey = "class vtkConvertSelection";
	}
}
