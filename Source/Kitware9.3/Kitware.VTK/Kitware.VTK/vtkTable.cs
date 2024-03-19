using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTable
	/// </summary>
	/// <remarks>
	///    A table, which contains similar-typed columns of data
	///
	///
	/// vtkTable is a basic data structure for storing columns of data.
	/// Internally, columns are stored in a vtkDataSetAttributes structure called
	/// RowData. However, using the vtkTable API additionally ensures that every column
	/// has the same number of entries, and provides row access (using vtkVariantArray)
	/// and single entry access (using vtkVariant).
	///
	/// Inserting or removing rows via the class API preserves existing table data where possible.
	///
	/// The "RemoveRow*" and SetNumberOfRows() operations will not release memory. Call on SqueezeRows()
	/// to achieve this after performing the operations.
	///
	/// The field data inherited from vtkDataObject may be used to store metadata
	/// related to the table.
	///
	/// @warning
	/// You should use the vtkTable API to change the table data. Performing
	/// operations on the object returned by GetRowData() may
	/// yield unexpected results. vtkTable does allow the user to set the field
	/// data using SetRowData(); the number of rows in the table is determined
	/// by the number of tuples in the first array (it is assumed that all arrays
	/// are the same length).
	///
	/// @warning
	/// Each column added with AddColumn &lt;b&gt;must&lt;/b&gt; have its name set to a unique,
	/// non-empty string in order for GetValue() to function properly.
	///
	/// @par Thanks:
	/// Thanks to Patricia Crossno, Ken Moreland, Andrew Wilson and Brian Wylie from
	/// Sandia National Laboratories for their help in developing this class API.
	/// </remarks>
	// Token: 0x02000AD2 RID: 2770
	public class vtkTable : vtkDataObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D29B RID: 119451 RVA: 0x00291CD1 File Offset: 0x0028FED1
		static vtkTable()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTable.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTable"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D29C RID: 119452 RVA: 0x00291CF9 File Offset: 0x0028FEF9
		public vtkTable(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601D29D RID: 119453
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTable_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D29E RID: 119454 RVA: 0x00291D08 File Offset: 0x0028FF08
		public new static vtkTable New()
		{
			vtkTable result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTable.vtkTable_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D29F RID: 119455 RVA: 0x00291D5C File Offset: 0x0028FF5C
		public vtkTable() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTable.vtkTable_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D2A0 RID: 119456 RVA: 0x00291DA0 File Offset: 0x0028FFA0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D2A1 RID: 119457
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTable_AddColumn_01(HandleRef pThis, HandleRef arr);

		/// <summary>
		/// Add a column to the table.
		/// </summary>
		// Token: 0x0601D2A2 RID: 119458 RVA: 0x00291DAC File Offset: 0x0028FFAC
		public void AddColumn(vtkAbstractArray arr)
		{
			vtkTable.vtkTable_AddColumn_01(base.GetCppThis(), (arr == null) ? default(HandleRef) : arr.GetCppThis());
		}

		// Token: 0x0601D2A3 RID: 119459
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTable_DeepCopy_02(HandleRef pThis, HandleRef src);

		/// <summary>
		/// Shallow/deep copy the data from src into this object.
		/// </summary>
		// Token: 0x0601D2A4 RID: 119460 RVA: 0x00291DDC File Offset: 0x0028FFDC
		public override void DeepCopy(vtkDataObject src)
		{
			vtkTable.vtkTable_DeepCopy_02(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		// Token: 0x0601D2A5 RID: 119461
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTable_Dump_03(HandleRef pThis, uint colWidth, int rowLimit);

		/// <summary>
		/// Dump table contents.  If rowLimit is -1 then the full table
		/// is printed out (Default).  If rowLimit is 0 then only the
		/// header row will be displayed.  Otherwise, if rowLimit &gt; 0
		/// then Dump will print the first rowLimit rows of data.
		/// </summary>
		// Token: 0x0601D2A6 RID: 119462 RVA: 0x00291E0B File Offset: 0x0029000B
		public void Dump(uint colWidth, int rowLimit)
		{
			vtkTable.vtkTable_Dump_03(base.GetCppThis(), colWidth, rowLimit);
		}

		// Token: 0x0601D2A7 RID: 119463
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTable_ExtendedNew_04(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D2A8 RID: 119464 RVA: 0x00291E1C File Offset: 0x0029001C
		public static vtkTable ExtendedNew()
		{
			vtkTable vtkTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTable.vtkTable_ExtendedNew_04(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTable = (vtkTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTable.Register(null);
				}
			}
			return vtkTable;
		}

		// Token: 0x0601D2A9 RID: 119465
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkTable_GetActualMemorySize_05(HandleRef pThis);

		/// <summary>
		/// Return the actual size of the data in kibibytes (1024 bytes). This number
		/// is valid only after the pipeline has updated. The memory size
		/// returned is guaranteed to be greater than or equal to the
		/// memory required to represent the data (e.g., extra space in
		/// arrays, etc. are not included in the return value).
		/// </summary>
		// Token: 0x0601D2AA RID: 119466 RVA: 0x00291E88 File Offset: 0x00290088
		public override uint GetActualMemorySize()
		{
			return vtkTable.vtkTable_GetActualMemorySize_05(base.GetCppThis());
		}

		// Token: 0x0601D2AB RID: 119467
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTable_GetAttributesAsFieldData_06(HandleRef pThis, int type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the attributes of the data object as a vtkFieldData.
		/// This returns non-null values in all the same cases as GetAttributes,
		/// in addition to the case of FIELD, which will return the field data
		/// for any vtkDataObject subclass.
		/// </summary>
		// Token: 0x0601D2AC RID: 119468 RVA: 0x00291EA8 File Offset: 0x002900A8
		public override vtkFieldData GetAttributesAsFieldData(int type)
		{
			vtkFieldData vtkFieldData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTable.vtkTable_GetAttributesAsFieldData_06(base.GetCppThis(), type, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFieldData = (vtkFieldData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFieldData.Register(null);
				}
			}
			return vtkFieldData;
		}

		// Token: 0x0601D2AD RID: 119469
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTable_GetColumn_07(HandleRef pThis, long col, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get a column of the table by its column index.
		/// </summary>
		// Token: 0x0601D2AE RID: 119470 RVA: 0x00291F18 File Offset: 0x00290118
		public vtkAbstractArray GetColumn(long col)
		{
			vtkAbstractArray vtkAbstractArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTable.vtkTable_GetColumn_07(base.GetCppThis(), col, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractArray = (vtkAbstractArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractArray.Register(null);
				}
			}
			return vtkAbstractArray;
		}

		// Token: 0x0601D2AF RID: 119471
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTable_GetColumnByName_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get a column of the table by its name.
		/// </summary>
		// Token: 0x0601D2B0 RID: 119472 RVA: 0x00291F88 File Offset: 0x00290188
		public vtkAbstractArray GetColumnByName(string name)
		{
			vtkAbstractArray vtkAbstractArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTable.vtkTable_GetColumnByName_08(base.GetCppThis(), name, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractArray = (vtkAbstractArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractArray.Register(null);
				}
			}
			return vtkAbstractArray;
		}

		// Token: 0x0601D2B1 RID: 119473
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTable_GetColumnIndex_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Get the column index for a name.
		/// If name is not found returns -1.
		/// </summary>
		// Token: 0x0601D2B2 RID: 119474 RVA: 0x00291FF8 File Offset: 0x002901F8
		public long GetColumnIndex(string name)
		{
			return vtkTable.vtkTable_GetColumnIndex_09(base.GetCppThis(), name);
		}

		// Token: 0x0601D2B3 RID: 119475
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTable_GetColumnName_10(HandleRef pThis, long col);

		/// <summary>
		/// Get the number of columns in the table.
		/// </summary>
		// Token: 0x0601D2B4 RID: 119476 RVA: 0x00292018 File Offset: 0x00290218
		public string GetColumnName(long col)
		{
			string s = Marshal.PtrToStringAnsi(vtkTable.vtkTable_GetColumnName_10(base.GetCppThis(), col));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601D2B5 RID: 119477
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTable_GetData_11(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve the table from vtkInformation.
		/// </summary>
		// Token: 0x0601D2B6 RID: 119478 RVA: 0x00292054 File Offset: 0x00290254
		public new static vtkTable GetData(vtkInformation info)
		{
			vtkTable vtkTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTable.vtkTable_GetData_11((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTable = (vtkTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTable.Register(null);
				}
			}
			return vtkTable;
		}

		// Token: 0x0601D2B7 RID: 119479
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTable_GetData_12(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve the table from vtkInformation.
		/// </summary>
		// Token: 0x0601D2B8 RID: 119480 RVA: 0x002920D4 File Offset: 0x002902D4
		public new static vtkTable GetData(vtkInformationVector v, int i)
		{
			vtkTable vtkTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTable.vtkTable_GetData_12((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTable = (vtkTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTable.Register(null);
				}
			}
			return vtkTable;
		}

		// Token: 0x0601D2B9 RID: 119481
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTable_GetDataObjectType_13(HandleRef pThis);

		/// <summary>
		/// Return what type of dataset this is.
		/// </summary>
		// Token: 0x0601D2BA RID: 119482 RVA: 0x00292154 File Offset: 0x00290354
		public override int GetDataObjectType()
		{
			return vtkTable.vtkTable_GetDataObjectType_13(base.GetCppThis());
		}

		// Token: 0x0601D2BB RID: 119483
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTable_GetNumberOfColumns_14(HandleRef pThis);

		/// <summary>
		/// Get the number of columns in the table.
		/// </summary>
		// Token: 0x0601D2BC RID: 119484 RVA: 0x00292174 File Offset: 0x00290374
		public long GetNumberOfColumns()
		{
			return vtkTable.vtkTable_GetNumberOfColumns_14(base.GetCppThis());
		}

		// Token: 0x0601D2BD RID: 119485
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTable_GetNumberOfElements_15(HandleRef pThis, int type);

		/// <summary>
		/// Get the number of elements for a specific attribute type (ROW, etc.).
		/// </summary>
		// Token: 0x0601D2BE RID: 119486 RVA: 0x00292194 File Offset: 0x00290394
		public override long GetNumberOfElements(int type)
		{
			return vtkTable.vtkTable_GetNumberOfElements_15(base.GetCppThis(), type);
		}

		// Token: 0x0601D2BF RID: 119487
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTable_GetNumberOfGenerationsFromBase_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D2C0 RID: 119488 RVA: 0x002921B4 File Offset: 0x002903B4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTable.vtkTable_GetNumberOfGenerationsFromBase_16(base.GetCppThis(), type);
		}

		// Token: 0x0601D2C1 RID: 119489
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTable_GetNumberOfGenerationsFromBaseType_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D2C2 RID: 119490 RVA: 0x002921D4 File Offset: 0x002903D4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTable.vtkTable_GetNumberOfGenerationsFromBaseType_17(type);
		}

		// Token: 0x0601D2C3 RID: 119491
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTable_GetNumberOfRows_18(HandleRef pThis);

		/// <summary>
		/// Get the number of rows in the table.
		/// </summary>
		// Token: 0x0601D2C4 RID: 119492 RVA: 0x002921F0 File Offset: 0x002903F0
		public long GetNumberOfRows()
		{
			return vtkTable.vtkTable_GetNumberOfRows_18(base.GetCppThis());
		}

		// Token: 0x0601D2C5 RID: 119493
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTable_GetRow_19(HandleRef pThis, long row, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get a row of the table as a vtkVariantArray which has one entry for each column.
		/// NOTE: This version of the method is NOT thread safe.
		/// </summary>
		// Token: 0x0601D2C6 RID: 119494 RVA: 0x00292210 File Offset: 0x00290410
		public vtkVariantArray GetRow(long row)
		{
			vtkVariantArray vtkVariantArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTable.vtkTable_GetRow_19(base.GetCppThis(), row, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVariantArray = (vtkVariantArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVariantArray.Register(null);
				}
			}
			return vtkVariantArray;
		}

		// Token: 0x0601D2C7 RID: 119495
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTable_GetRow_20(HandleRef pThis, long row, HandleRef values);

		/// <summary>
		/// Get a row of the table as a vtkVariantArray which has one entry for each column.
		/// </summary>
		// Token: 0x0601D2C8 RID: 119496 RVA: 0x00292280 File Offset: 0x00290480
		public void GetRow(long row, vtkVariantArray values)
		{
			vtkTable.vtkTable_GetRow_20(base.GetCppThis(), row, (values == null) ? default(HandleRef) : values.GetCppThis());
		}

		// Token: 0x0601D2C9 RID: 119497
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTable_GetRowData_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the main data (columns) of the table.
		/// </summary>
		// Token: 0x0601D2CA RID: 119498 RVA: 0x002922B0 File Offset: 0x002904B0
		public virtual vtkDataSetAttributes GetRowData()
		{
			vtkDataSetAttributes vtkDataSetAttributes = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTable.vtkTable_GetRowData_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSetAttributes = (vtkDataSetAttributes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSetAttributes.Register(null);
				}
			}
			return vtkDataSetAttributes;
		}

		// Token: 0x0601D2CB RID: 119499
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTable_GetValue_22(HandleRef pThis, long row, long col, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve a value in the table by row and column index as a variant.
		/// Note that this calls GetValueByName internally so that each column
		/// array must have its name set (and that name should be unique within
		/// the table).
		/// </summary>
		// Token: 0x0601D2CC RID: 119500 RVA: 0x00292320 File Offset: 0x00290520
		public vtkVariant GetValue(long row, long col)
		{
			vtkVariant result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTable.vtkTable_GetValue_22(base.GetCppThis(), row, col, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVariant)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601D2CD RID: 119501
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTable_GetValueByName_23(HandleRef pThis, long row, [MarshalAs(UnmanagedType.LPUTF8Str)] string col, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve a value in the table by row index and column name as a variant.
		/// </summary>
		// Token: 0x0601D2CE RID: 119502 RVA: 0x0029237C File Offset: 0x0029057C
		public vtkVariant GetValueByName(long row, string col)
		{
			vtkVariant result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTable.vtkTable_GetValueByName_23(base.GetCppThis(), row, col, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVariant)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601D2CF RID: 119503
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTable_Initialize_24(HandleRef pThis);

		/// <summary>
		/// Initialize to an empty table.
		/// </summary>
		// Token: 0x0601D2D0 RID: 119504 RVA: 0x002923D8 File Offset: 0x002905D8
		public override void Initialize()
		{
			vtkTable.vtkTable_Initialize_24(base.GetCppThis());
		}

		// Token: 0x0601D2D1 RID: 119505
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTable_InsertColumn_25(HandleRef pThis, HandleRef arr, long index);

		/// <summary>
		/// Insert a column into the table at given column index.
		/// </summary>
		// Token: 0x0601D2D2 RID: 119506 RVA: 0x002923E8 File Offset: 0x002905E8
		public void InsertColumn(vtkAbstractArray arr, long index)
		{
			vtkTable.vtkTable_InsertColumn_25(base.GetCppThis(), (arr == null) ? default(HandleRef) : arr.GetCppThis(), index);
		}

		// Token: 0x0601D2D3 RID: 119507
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTable_InsertNextBlankRow_26(HandleRef pThis, double default_num_val);

		/// <summary>
		/// Insert a blank row at the end of the table.
		/// </summary>
		// Token: 0x0601D2D4 RID: 119508 RVA: 0x00292418 File Offset: 0x00290618
		public long InsertNextBlankRow(double default_num_val)
		{
			return vtkTable.vtkTable_InsertNextBlankRow_26(base.GetCppThis(), default_num_val);
		}

		// Token: 0x0601D2D5 RID: 119509
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTable_InsertNextRow_27(HandleRef pThis, HandleRef values);

		/// <summary>
		/// Insert a row at the end of the tablespecified by a vtkVariantArray. The number of entries in
		/// the array should match the number of columns in the table.
		/// </summary>
		// Token: 0x0601D2D6 RID: 119510 RVA: 0x00292438 File Offset: 0x00290638
		public long InsertNextRow(vtkVariantArray values)
		{
			return vtkTable.vtkTable_InsertNextRow_27(base.GetCppThis(), (values == null) ? default(HandleRef) : values.GetCppThis());
		}

		// Token: 0x0601D2D7 RID: 119511
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTable_InsertRow_28(HandleRef pThis, long row);

		/// <summary>
		/// Insert a single row at the index.
		/// </summary>
		// Token: 0x0601D2D8 RID: 119512 RVA: 0x0029246C File Offset: 0x0029066C
		public void InsertRow(long row)
		{
			vtkTable.vtkTable_InsertRow_28(base.GetCppThis(), row);
		}

		// Token: 0x0601D2D9 RID: 119513
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTable_InsertRows_29(HandleRef pThis, long row, long n);

		/// <summary>
		/// Insert n rows before row. If row &lt; 0 then the rows will be prepended to the table.
		/// </summary>
		// Token: 0x0601D2DA RID: 119514 RVA: 0x0029247C File Offset: 0x0029067C
		public void InsertRows(long row, long n)
		{
			vtkTable.vtkTable_InsertRows_29(base.GetCppThis(), row, n);
		}

		// Token: 0x0601D2DB RID: 119515
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTable_IsA_30(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D2DC RID: 119516 RVA: 0x00292490 File Offset: 0x00290690
		public override int IsA(string type)
		{
			return vtkTable.vtkTable_IsA_30(base.GetCppThis(), type);
		}

		// Token: 0x0601D2DD RID: 119517
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTable_IsTypeOf_31([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D2DE RID: 119518 RVA: 0x002924B0 File Offset: 0x002906B0
		public new static int IsTypeOf(string type)
		{
			return vtkTable.vtkTable_IsTypeOf_31(type);
		}

		// Token: 0x0601D2DF RID: 119519
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTable_NewInstance_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D2E0 RID: 119520 RVA: 0x002924CC File Offset: 0x002906CC
		public new vtkTable NewInstance()
		{
			vtkTable result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTable.vtkTable_NewInstance_33(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601D2E1 RID: 119521
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTable_RemoveAllColumns_34(HandleRef pThis);

		/// <summary>
		/// Remove all columns from the table.
		/// </summary>
		// Token: 0x0601D2E2 RID: 119522 RVA: 0x00292526 File Offset: 0x00290726
		public void RemoveAllColumns()
		{
			vtkTable.vtkTable_RemoveAllColumns_34(base.GetCppThis());
		}

		// Token: 0x0601D2E3 RID: 119523
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTable_RemoveAllRows_35(HandleRef pThis);

		/// <summary>
		/// Delete all rows from the table. The column arrays are not delete, they are just empty
		/// after this operation.
		/// </summary>
		// Token: 0x0601D2E4 RID: 119524 RVA: 0x00292535 File Offset: 0x00290735
		public void RemoveAllRows()
		{
			vtkTable.vtkTable_RemoveAllRows_35(base.GetCppThis());
		}

		// Token: 0x0601D2E5 RID: 119525
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTable_RemoveColumn_36(HandleRef pThis, long col);

		/// <summary>
		/// Remove a column from the table by its column index.
		/// </summary>
		// Token: 0x0601D2E6 RID: 119526 RVA: 0x00292544 File Offset: 0x00290744
		public void RemoveColumn(long col)
		{
			vtkTable.vtkTable_RemoveColumn_36(base.GetCppThis(), col);
		}

		// Token: 0x0601D2E7 RID: 119527
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTable_RemoveColumnByName_37(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Remove a column from the table by its name.
		/// </summary>
		// Token: 0x0601D2E8 RID: 119528 RVA: 0x00292554 File Offset: 0x00290754
		public void RemoveColumnByName(string name)
		{
			vtkTable.vtkTable_RemoveColumnByName_37(base.GetCppThis(), name);
		}

		// Token: 0x0601D2E9 RID: 119529
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTable_RemoveRow_38(HandleRef pThis, long row);

		/// <summary>
		/// Delete a single row from the table. Rows below the deleted row are shifted up.
		/// </summary>
		// Token: 0x0601D2EA RID: 119530 RVA: 0x00292564 File Offset: 0x00290764
		public void RemoveRow(long row)
		{
			vtkTable.vtkTable_RemoveRow_38(base.GetCppThis(), row);
		}

		// Token: 0x0601D2EB RID: 119531
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTable_RemoveRows_39(HandleRef pThis, long row, long n);

		/// <summary>
		/// Delete n rows from the table, starting at row. Rows below the deleted rows are shifted up.
		/// </summary>
		// Token: 0x0601D2EC RID: 119532 RVA: 0x00292574 File Offset: 0x00290774
		public void RemoveRows(long row, long n)
		{
			vtkTable.vtkTable_RemoveRows_39(base.GetCppThis(), row, n);
		}

		// Token: 0x0601D2ED RID: 119533
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTable_SafeDownCast_40(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D2EE RID: 119534 RVA: 0x00292588 File Offset: 0x00290788
		public new static vtkTable SafeDownCast(vtkObjectBase o)
		{
			vtkTable vtkTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTable.vtkTable_SafeDownCast_40((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTable = (vtkTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTable.Register(null);
				}
			}
			return vtkTable;
		}

		// Token: 0x0601D2EF RID: 119535
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTable_SetNumberOfRows_41(HandleRef pThis, long arg0);

		/// <summary>
		/// Set the number of rows in the table. Note that memory allocation might be performed
		/// as a result of this, but no memory will be released. Existing data is preserved if the table is
		/// expanding.
		/// </summary>
		// Token: 0x0601D2F0 RID: 119536 RVA: 0x00292607 File Offset: 0x00290807
		public void SetNumberOfRows(long arg0)
		{
			vtkTable.vtkTable_SetNumberOfRows_41(base.GetCppThis(), arg0);
		}

		// Token: 0x0601D2F1 RID: 119537
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTable_SetRow_42(HandleRef pThis, long row, HandleRef values);

		/// <summary>
		/// Set a row of the table with a vtkVariantArray which has one entry for each column.
		/// </summary>
		// Token: 0x0601D2F2 RID: 119538 RVA: 0x00292618 File Offset: 0x00290818
		public void SetRow(long row, vtkVariantArray values)
		{
			vtkTable.vtkTable_SetRow_42(base.GetCppThis(), row, (values == null) ? default(HandleRef) : values.GetCppThis());
		}

		// Token: 0x0601D2F3 RID: 119539
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTable_SetRowData_43(HandleRef pThis, HandleRef data);

		/// <summary>
		/// Get/Set the main data (columns) of the table.
		/// </summary>
		// Token: 0x0601D2F4 RID: 119540 RVA: 0x00292648 File Offset: 0x00290848
		public virtual void SetRowData(vtkDataSetAttributes data)
		{
			vtkTable.vtkTable_SetRowData_43(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis());
		}

		// Token: 0x0601D2F5 RID: 119541
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTable_SetValue_44(HandleRef pThis, long row, long col, HandleRef value);

		/// <summary>
		/// Set a value in the table by row and column index as a variant.
		/// </summary>
		// Token: 0x0601D2F6 RID: 119542 RVA: 0x00292678 File Offset: 0x00290878
		public void SetValue(long row, long col, vtkVariant value)
		{
			vtkTable.vtkTable_SetValue_44(base.GetCppThis(), row, col, (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601D2F7 RID: 119543
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTable_SetValueByName_45(HandleRef pThis, long row, [MarshalAs(UnmanagedType.LPUTF8Str)] string col, HandleRef value);

		/// <summary>
		/// Set a value in the table by row index and column name as a variant.
		/// </summary>
		// Token: 0x0601D2F8 RID: 119544 RVA: 0x002926AC File Offset: 0x002908AC
		public void SetValueByName(long row, string col, vtkVariant value)
		{
			vtkTable.vtkTable_SetValueByName_45(base.GetCppThis(), row, col, (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601D2F9 RID: 119545
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTable_ShallowCopy_46(HandleRef pThis, HandleRef src);

		/// <summary>
		/// Shallow/deep copy the data from src into this object.
		/// </summary>
		// Token: 0x0601D2FA RID: 119546 RVA: 0x002926E0 File Offset: 0x002908E0
		public override void ShallowCopy(vtkDataObject src)
		{
			vtkTable.vtkTable_ShallowCopy_46(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		// Token: 0x0601D2FB RID: 119547
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTable_SqueezeRows_47(HandleRef pThis);

		/// <summary>
		/// Release previously allocated and now unused memory after performing resizing operations.
		/// </summary>
		// Token: 0x0601D2FC RID: 119548 RVA: 0x0029270F File Offset: 0x0029090F
		public void SqueezeRows()
		{
			vtkTable.vtkTable_SqueezeRows_47(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001ECA RID: 7882
		public new const string MRFullTypeName = "Kitware.VTK.vtkTable";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001ECB RID: 7883
		public new static readonly string MRClassNameKey = "class vtkTable";
	}
}
