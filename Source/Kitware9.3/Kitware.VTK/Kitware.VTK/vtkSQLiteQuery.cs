using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSQLiteQuery
	/// </summary>
	/// <remarks>
	///    vtkSQLQuery implementation for SQLite databases
	///
	///
	///
	/// This is an implementation of vtkSQLQuery for SQLite databases.  See
	/// the documentation for vtkSQLQuery for information about what the
	/// methods do.
	///
	///
	/// @bug
	/// Sometimes Execute() will return false (meaning an error) but
	/// GetLastErrorText() winds up null.  I am not certain why this is
	/// happening.
	///
	/// @par Thanks:
	/// Thanks to Andrew Wilson from Sandia National Laboratories for implementing
	/// this class.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkSQLDatabase vtkSQLQuery vtkSQLiteDatabase
	/// </seealso>
	// Token: 0x02000271 RID: 625
	public class vtkSQLiteQuery : vtkSQLQuery
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060071EA RID: 29162 RVA: 0x000A44AF File Offset: 0x000A26AF
		static vtkSQLiteQuery()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSQLiteQuery.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSQLiteQuery"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060071EB RID: 29163 RVA: 0x000A44D7 File Offset: 0x000A26D7
		public vtkSQLiteQuery(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060071EC RID: 29164
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSQLiteQuery_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060071ED RID: 29165 RVA: 0x000A44E8 File Offset: 0x000A26E8
		public new static vtkSQLiteQuery New()
		{
			vtkSQLiteQuery result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSQLiteQuery.vtkSQLiteQuery_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSQLiteQuery)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060071EE RID: 29166 RVA: 0x000A453C File Offset: 0x000A273C
		public vtkSQLiteQuery() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSQLiteQuery.vtkSQLiteQuery_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060071EF RID: 29167 RVA: 0x000A4580 File Offset: 0x000A2780
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060071F0 RID: 29168
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLiteQuery_BeginTransaction_01(HandleRef pThis);

		/// <summary>
		/// Begin, abort (roll back), or commit a transaction.
		/// </summary>
		// Token: 0x060071F1 RID: 29169 RVA: 0x000A458C File Offset: 0x000A278C
		public override bool BeginTransaction()
		{
			return vtkSQLiteQuery.vtkSQLiteQuery_BeginTransaction_01(base.GetCppThis()) != 0;
		}

		// Token: 0x060071F2 RID: 29170
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLiteQuery_BindParameter_02(HandleRef pThis, int index, byte value);

		/// <summary>
		/// The following methods bind a parameter value to a placeholder in
		/// the SQL string.  See the documentation for vtkSQLQuery for
		/// further explanation.  The driver makes internal copies of string
		/// and BLOB parameters so you don't need to worry about keeping them
		/// in scope until the query finishes executing.
		/// </summary>
		// Token: 0x060071F3 RID: 29171 RVA: 0x000A45B4 File Offset: 0x000A27B4
		public override bool BindParameter(int index, byte value)
		{
			return vtkSQLiteQuery.vtkSQLiteQuery_BindParameter_02(base.GetCppThis(), index, value) != 0;
		}

		// Token: 0x060071F4 RID: 29172
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLiteQuery_BindParameter_03(HandleRef pThis, int index, sbyte value);

		/// <summary>
		/// The following methods bind a parameter value to a placeholder in
		/// the SQL string.  See the documentation for vtkSQLQuery for
		/// further explanation.  The driver makes internal copies of string
		/// and BLOB parameters so you don't need to worry about keeping them
		/// in scope until the query finishes executing.
		/// </summary>
		// Token: 0x060071F5 RID: 29173 RVA: 0x000A45DC File Offset: 0x000A27DC
		public override bool BindParameter(int index, sbyte value)
		{
			return vtkSQLiteQuery.vtkSQLiteQuery_BindParameter_03(base.GetCppThis(), index, value) != 0;
		}

		// Token: 0x060071F6 RID: 29174
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLiteQuery_BindParameter_04(HandleRef pThis, int index, ushort value);

		/// <summary>
		/// The following methods bind a parameter value to a placeholder in
		/// the SQL string.  See the documentation for vtkSQLQuery for
		/// further explanation.  The driver makes internal copies of string
		/// and BLOB parameters so you don't need to worry about keeping them
		/// in scope until the query finishes executing.
		/// </summary>
		// Token: 0x060071F7 RID: 29175 RVA: 0x000A4604 File Offset: 0x000A2804
		public override bool BindParameter(int index, ushort value)
		{
			return vtkSQLiteQuery.vtkSQLiteQuery_BindParameter_04(base.GetCppThis(), index, value) != 0;
		}

		// Token: 0x060071F8 RID: 29176
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLiteQuery_BindParameter_05(HandleRef pThis, int index, short value);

		/// <summary>
		/// The following methods bind a parameter value to a placeholder in
		/// the SQL string.  See the documentation for vtkSQLQuery for
		/// further explanation.  The driver makes internal copies of string
		/// and BLOB parameters so you don't need to worry about keeping them
		/// in scope until the query finishes executing.
		/// </summary>
		// Token: 0x060071F9 RID: 29177 RVA: 0x000A462C File Offset: 0x000A282C
		public override bool BindParameter(int index, short value)
		{
			return vtkSQLiteQuery.vtkSQLiteQuery_BindParameter_05(base.GetCppThis(), index, value) != 0;
		}

		// Token: 0x060071FA RID: 29178
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLiteQuery_BindParameter_06(HandleRef pThis, int index, uint value);

		/// <summary>
		/// The following methods bind a parameter value to a placeholder in
		/// the SQL string.  See the documentation for vtkSQLQuery for
		/// further explanation.  The driver makes internal copies of string
		/// and BLOB parameters so you don't need to worry about keeping them
		/// in scope until the query finishes executing.
		/// </summary>
		// Token: 0x060071FB RID: 29179 RVA: 0x000A4654 File Offset: 0x000A2854
		public override bool BindParameter(int index, uint value)
		{
			return vtkSQLiteQuery.vtkSQLiteQuery_BindParameter_06(base.GetCppThis(), index, value) != 0;
		}

		// Token: 0x060071FC RID: 29180
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLiteQuery_BindParameter_07(HandleRef pThis, int index, int value);

		/// <summary>
		/// The following methods bind a parameter value to a placeholder in
		/// the SQL string.  See the documentation for vtkSQLQuery for
		/// further explanation.  The driver makes internal copies of string
		/// and BLOB parameters so you don't need to worry about keeping them
		/// in scope until the query finishes executing.
		/// </summary>
		// Token: 0x060071FD RID: 29181 RVA: 0x000A467C File Offset: 0x000A287C
		public override bool BindParameter(int index, int value)
		{
			return vtkSQLiteQuery.vtkSQLiteQuery_BindParameter_07(base.GetCppThis(), index, value) != 0;
		}

		// Token: 0x060071FE RID: 29182
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLiteQuery_BindParameter_08(HandleRef pThis, int index, ulong value);

		/// <summary>
		/// The following methods bind a parameter value to a placeholder in
		/// the SQL string.  See the documentation for vtkSQLQuery for
		/// further explanation.  The driver makes internal copies of string
		/// and BLOB parameters so you don't need to worry about keeping them
		/// in scope until the query finishes executing.
		/// </summary>
		// Token: 0x060071FF RID: 29183 RVA: 0x000A46A4 File Offset: 0x000A28A4
		public override bool BindParameter(int index, ulong value)
		{
			return vtkSQLiteQuery.vtkSQLiteQuery_BindParameter_08(base.GetCppThis(), index, value) != 0;
		}

		// Token: 0x06007200 RID: 29184
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLiteQuery_BindParameter_09(HandleRef pThis, int index, long value);

		/// <summary>
		/// The following methods bind a parameter value to a placeholder in
		/// the SQL string.  See the documentation for vtkSQLQuery for
		/// further explanation.  The driver makes internal copies of string
		/// and BLOB parameters so you don't need to worry about keeping them
		/// in scope until the query finishes executing.
		/// </summary>
		// Token: 0x06007201 RID: 29185 RVA: 0x000A46CC File Offset: 0x000A28CC
		public override bool BindParameter(int index, long value)
		{
			return vtkSQLiteQuery.vtkSQLiteQuery_BindParameter_09(base.GetCppThis(), index, value) != 0;
		}

		// Token: 0x06007202 RID: 29186
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLiteQuery_BindParameter_10(HandleRef pThis, int index, float value);

		/// <summary>
		/// The following methods bind a parameter value to a placeholder in
		/// the SQL string.  See the documentation for vtkSQLQuery for
		/// further explanation.  The driver makes internal copies of string
		/// and BLOB parameters so you don't need to worry about keeping them
		/// in scope until the query finishes executing.
		/// </summary>
		// Token: 0x06007203 RID: 29187 RVA: 0x000A46F4 File Offset: 0x000A28F4
		public override bool BindParameter(int index, float value)
		{
			return vtkSQLiteQuery.vtkSQLiteQuery_BindParameter_10(base.GetCppThis(), index, value) != 0;
		}

		// Token: 0x06007204 RID: 29188
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLiteQuery_BindParameter_11(HandleRef pThis, int index, double value);

		/// <summary>
		/// The following methods bind a parameter value to a placeholder in
		/// the SQL string.  See the documentation for vtkSQLQuery for
		/// further explanation.  The driver makes internal copies of string
		/// and BLOB parameters so you don't need to worry about keeping them
		/// in scope until the query finishes executing.
		/// </summary>
		// Token: 0x06007205 RID: 29189 RVA: 0x000A471C File Offset: 0x000A291C
		public override bool BindParameter(int index, double value)
		{
			return vtkSQLiteQuery.vtkSQLiteQuery_BindParameter_11(base.GetCppThis(), index, value) != 0;
		}

		// Token: 0x06007206 RID: 29190
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLiteQuery_BindParameter_12(HandleRef pThis, int index, [MarshalAs(UnmanagedType.LPUTF8Str)] string stringValue);

		/// <summary>
		/// Bind a string value -- string must be null-terminated
		/// </summary>
		// Token: 0x06007207 RID: 29191 RVA: 0x000A4744 File Offset: 0x000A2944
		public override bool BindParameter(int index, string stringValue)
		{
			return vtkSQLiteQuery.vtkSQLiteQuery_BindParameter_12(base.GetCppThis(), index, stringValue) != 0;
		}

		// Token: 0x06007208 RID: 29192
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLiteQuery_BindParameter_13(HandleRef pThis, int index, [MarshalAs(UnmanagedType.LPUTF8Str)] string stringValue, ulong length);

		/// <summary>
		/// Bind a string value by specifying an array and a size
		/// </summary>
		// Token: 0x06007209 RID: 29193 RVA: 0x000A476C File Offset: 0x000A296C
		public override bool BindParameter(int index, string stringValue, ulong length)
		{
			return vtkSQLiteQuery.vtkSQLiteQuery_BindParameter_13(base.GetCppThis(), index, stringValue, length) != 0;
		}

		// Token: 0x0600720A RID: 29194
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLiteQuery_BindParameter_14(HandleRef pThis, int index, HandleRef value);

		/// <summary>
		/// Bind a string value by specifying an array and a size
		/// </summary>
		// Token: 0x0600720B RID: 29195 RVA: 0x000A4798 File Offset: 0x000A2998
		public override bool BindParameter(int index, vtkVariant value)
		{
			return vtkSQLiteQuery.vtkSQLiteQuery_BindParameter_14(base.GetCppThis(), index, (value == null) ? default(HandleRef) : value.GetCppThis()) != 0;
		}

		// Token: 0x0600720C RID: 29196
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLiteQuery_BindParameter_15(HandleRef pThis, int index, IntPtr data, ulong length);

		/// <summary>
		/// Bind a blob value.  Not all databases support blobs as a data
		/// type.  Check vtkSQLDatabase::IsSupported(VTK_SQL_FEATURE_BLOB) to
		/// make sure.
		/// </summary>
		// Token: 0x0600720D RID: 29197 RVA: 0x000A47D4 File Offset: 0x000A29D4
		public override bool BindParameter(int index, IntPtr data, ulong length)
		{
			return vtkSQLiteQuery.vtkSQLiteQuery_BindParameter_15(base.GetCppThis(), index, data, length) != 0;
		}

		// Token: 0x0600720E RID: 29198
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLiteQuery_ClearParameterBindings_16(HandleRef pThis);

		/// <summary>
		/// Bind a blob value.  Not all databases support blobs as a data
		/// type.  Check vtkSQLDatabase::IsSupported(VTK_SQL_FEATURE_BLOB) to
		/// make sure.
		/// </summary>
		// Token: 0x0600720F RID: 29199 RVA: 0x000A4800 File Offset: 0x000A2A00
		public override bool ClearParameterBindings()
		{
			return vtkSQLiteQuery.vtkSQLiteQuery_ClearParameterBindings_16(base.GetCppThis()) != 0;
		}

		// Token: 0x06007210 RID: 29200
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLiteQuery_CommitTransaction_17(HandleRef pThis);

		/// <summary>
		/// Begin, abort (roll back), or commit a transaction.
		/// </summary>
		// Token: 0x06007211 RID: 29201 RVA: 0x000A4828 File Offset: 0x000A2A28
		public override bool CommitTransaction()
		{
			return vtkSQLiteQuery.vtkSQLiteQuery_CommitTransaction_17(base.GetCppThis()) != 0;
		}

		// Token: 0x06007212 RID: 29202
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSQLiteQuery_DataValue_18(HandleRef pThis, long c, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return data in current row, field c
		/// </summary>
		// Token: 0x06007213 RID: 29203 RVA: 0x000A4850 File Offset: 0x000A2A50
		public override vtkVariant DataValue(long c)
		{
			vtkVariant result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSQLiteQuery.vtkSQLiteQuery_DataValue_18(base.GetCppThis(), c, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVariant)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06007214 RID: 29204
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLiteQuery_Execute_19(HandleRef pThis);

		/// <summary>
		/// Execute the query.  This must be performed
		/// before any field name or data access functions
		/// are used.
		/// </summary>
		// Token: 0x06007215 RID: 29205 RVA: 0x000A48AC File Offset: 0x000A2AAC
		public override bool Execute()
		{
			return vtkSQLiteQuery.vtkSQLiteQuery_Execute_19(base.GetCppThis()) != 0;
		}

		// Token: 0x06007216 RID: 29206
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSQLiteQuery_GetFieldName_20(HandleRef pThis, int i);

		/// <summary>
		/// Return the name of the specified query field.
		/// </summary>
		// Token: 0x06007217 RID: 29207 RVA: 0x000A48D4 File Offset: 0x000A2AD4
		public override string GetFieldName(int i)
		{
			string s = Marshal.PtrToStringAnsi(vtkSQLiteQuery.vtkSQLiteQuery_GetFieldName_20(base.GetCppThis(), i));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06007218 RID: 29208
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSQLiteQuery_GetFieldType_21(HandleRef pThis, int i);

		/// <summary>
		/// Return the type of the field, using the constants defined in vtkType.h.
		/// </summary>
		// Token: 0x06007219 RID: 29209 RVA: 0x000A4910 File Offset: 0x000A2B10
		public override int GetFieldType(int i)
		{
			return vtkSQLiteQuery.vtkSQLiteQuery_GetFieldType_21(base.GetCppThis(), i);
		}

		// Token: 0x0600721A RID: 29210
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSQLiteQuery_GetLastErrorText_22(HandleRef pThis);

		/// <summary>
		/// Get the last error text from the query
		/// </summary>
		// Token: 0x0600721B RID: 29211 RVA: 0x000A4930 File Offset: 0x000A2B30
		public override string GetLastErrorText()
		{
			string s = Marshal.PtrToStringAnsi(vtkSQLiteQuery.vtkSQLiteQuery_GetLastErrorText_22(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600721C RID: 29212
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSQLiteQuery_GetNumberOfFields_23(HandleRef pThis);

		/// <summary>
		/// The number of fields in the query result.
		/// </summary>
		// Token: 0x0600721D RID: 29213 RVA: 0x000A496C File Offset: 0x000A2B6C
		public override int GetNumberOfFields()
		{
			return vtkSQLiteQuery.vtkSQLiteQuery_GetNumberOfFields_23(base.GetCppThis());
		}

		// Token: 0x0600721E RID: 29214
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSQLiteQuery_GetNumberOfGenerationsFromBase_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600721F RID: 29215 RVA: 0x000A498C File Offset: 0x000A2B8C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSQLiteQuery.vtkSQLiteQuery_GetNumberOfGenerationsFromBase_24(base.GetCppThis(), type);
		}

		// Token: 0x06007220 RID: 29216
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSQLiteQuery_GetNumberOfGenerationsFromBaseType_25([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007221 RID: 29217 RVA: 0x000A49AC File Offset: 0x000A2BAC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSQLiteQuery.vtkSQLiteQuery_GetNumberOfGenerationsFromBaseType_25(type);
		}

		// Token: 0x06007222 RID: 29218
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLiteQuery_HasError_26(HandleRef pThis);

		/// <summary>
		/// Return true if there is an error on the current query.
		/// </summary>
		// Token: 0x06007223 RID: 29219 RVA: 0x000A49C8 File Offset: 0x000A2BC8
		public override bool HasError()
		{
			return vtkSQLiteQuery.vtkSQLiteQuery_HasError_26(base.GetCppThis()) != 0;
		}

		// Token: 0x06007224 RID: 29220
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSQLiteQuery_IsA_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007225 RID: 29221 RVA: 0x000A49F0 File Offset: 0x000A2BF0
		public override int IsA(string type)
		{
			return vtkSQLiteQuery.vtkSQLiteQuery_IsA_27(base.GetCppThis(), type);
		}

		// Token: 0x06007226 RID: 29222
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSQLiteQuery_IsTypeOf_28([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007227 RID: 29223 RVA: 0x000A4A10 File Offset: 0x000A2C10
		public new static int IsTypeOf(string type)
		{
			return vtkSQLiteQuery.vtkSQLiteQuery_IsTypeOf_28(type);
		}

		// Token: 0x06007228 RID: 29224
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSQLiteQuery_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007229 RID: 29225 RVA: 0x000A4A2C File Offset: 0x000A2C2C
		public new vtkSQLiteQuery NewInstance()
		{
			vtkSQLiteQuery result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSQLiteQuery.vtkSQLiteQuery_NewInstance_30(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSQLiteQuery)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600722A RID: 29226
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLiteQuery_NextRow_31(HandleRef pThis);

		/// <summary>
		/// Advance row, return false if past end.
		/// </summary>
		// Token: 0x0600722B RID: 29227 RVA: 0x000A4A88 File Offset: 0x000A2C88
		public override bool NextRow()
		{
			return vtkSQLiteQuery.vtkSQLiteQuery_NextRow_31(base.GetCppThis()) != 0;
		}

		// Token: 0x0600722C RID: 29228
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLiteQuery_RollbackTransaction_32(HandleRef pThis);

		/// <summary>
		/// Begin, abort (roll back), or commit a transaction.
		/// </summary>
		// Token: 0x0600722D RID: 29229 RVA: 0x000A4AB0 File Offset: 0x000A2CB0
		public override bool RollbackTransaction()
		{
			return vtkSQLiteQuery.vtkSQLiteQuery_RollbackTransaction_32(base.GetCppThis()) != 0;
		}

		// Token: 0x0600722E RID: 29230
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSQLiteQuery_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600722F RID: 29231 RVA: 0x000A4AD8 File Offset: 0x000A2CD8
		public new static vtkSQLiteQuery SafeDownCast(vtkObjectBase o)
		{
			vtkSQLiteQuery vtkSQLiteQuery = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSQLiteQuery.vtkSQLiteQuery_SafeDownCast_33((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSQLiteQuery = (vtkSQLiteQuery)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSQLiteQuery.Register(null);
				}
			}
			return vtkSQLiteQuery;
		}

		// Token: 0x06007230 RID: 29232
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLiteQuery_SetQuery_34(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string query);

		/// <summary>
		/// Set the SQL query string.  This must be performed before
		/// Execute() or BindParameter() can be called.
		/// </summary>
		// Token: 0x06007231 RID: 29233 RVA: 0x000A4B58 File Offset: 0x000A2D58
		public override bool SetQuery(string query)
		{
			return vtkSQLiteQuery.vtkSQLiteQuery_SetQuery_34(base.GetCppThis(), query) != 0;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009F0 RID: 2544
		public new const string MRFullTypeName = "Kitware.VTK.vtkSQLiteQuery";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009F1 RID: 2545
		public new static readonly string MRClassNameKey = "class vtkSQLiteQuery";
	}
}
