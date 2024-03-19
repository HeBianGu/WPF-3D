using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSQLQuery
	/// </summary>
	/// <remarks>
	///    executes an sql query and retrieves results
	///
	///
	/// The abstract superclass of SQL query classes.  Instances of subclasses
	/// of vtkSQLQuery are created using the GetQueryInstance() function in
	/// vtkSQLDatabase.  To implement a query connection for a new database
	/// type, subclass both vtkSQLDatabase and vtkSQLQuery, and implement the
	/// required functions.  For the query class, this involves the following:
	///
	/// Execute() - Execute the query on the database.  No results need to be
	///             retrieved at this point, unless you are performing caching.
	///
	/// GetNumberOfFields() - After Execute() is performed, returns the number
	///                       of fields in the query results.
	///
	/// GetFieldName() - The name of the field at an index.
	///
	/// GetFieldType() - The data type of the field at an index.
	///
	/// NextRow() - Advances the query results by one row, and returns whether
	///             there are more rows left in the query.
	///
	/// DataValue() - Extract a single data value from the current row.
	///
	/// Begin/Rollback/CommitTransaction() - These methods are optional but
	/// recommended if the database supports transactions.
	///
	/// @par Thanks:
	/// Thanks to Andrew Wilson from Sandia National Laboratories for his work
	/// on the database classes.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkSQLDatabase
	/// </seealso>
	// Token: 0x02000270 RID: 624
	public abstract class vtkSQLQuery : vtkRowQuery
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060071AB RID: 29099 RVA: 0x000A3EDF File Offset: 0x000A20DF
		static vtkSQLQuery()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSQLQuery.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSQLQuery"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060071AC RID: 29100 RVA: 0x000A3F07 File Offset: 0x000A2107
		public vtkSQLQuery(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060071AD RID: 29101 RVA: 0x000A3F15 File Offset: 0x000A2115
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060071AE RID: 29102
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLQuery_BeginTransaction_01(HandleRef pThis);

		/// <summary>
		/// Begin, commit, or roll back a transaction.  If the underlying
		/// database does not support transactions these calls will do
		/// nothing.
		/// </summary>
		// Token: 0x060071AF RID: 29103 RVA: 0x000A3F20 File Offset: 0x000A2120
		public virtual bool BeginTransaction()
		{
			return vtkSQLQuery.vtkSQLQuery_BeginTransaction_01(base.GetCppThis()) != 0;
		}

		// Token: 0x060071B0 RID: 29104
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLQuery_BindParameter_02(HandleRef pThis, int index, byte value);

		/// <summary>
		/// Bind a parameter to a placeholder in a query.  A full discussion
		/// of this feature is beyond the scope of this header file, but in
		/// short, here's how it works:
		///
		/// Instead of saying "SELECT foo FROM mytable WHERE myfield = 12345"
		/// you can say "SELECT foo FROM mytable WHERE myfield = ?".  The ?
		/// character is a placeholder for a parameter that must then be
		/// bound.  Call BindParameter(0, 12345) to bind the integer value
		/// 12345 to that field.  Placeholders are indexed starting at 0.
		///
		/// You are responsible for making sure that the types match when you
		/// call BindParameter.  You don't have to get it precisely correct:
		/// in general, the SQL driver is smart enough to do things like cast
		/// a short to a long or a float to a double.
		///
		/// Bound parameters were introduced in ANSI SQL 92.  Please see that
		/// standard for more information.
		///
		/// Most of these methods are excluded from wrapping because the Java
		/// wrapper treats all integer types from char up through 64-bit long
		/// as 'int'.  This is incorrect behavior but what else am I going to
		/// do?
		///
		/// Finally, the default implementation for BindParameter(int,
		/// vtkVariant) dispatches to one of the more type-specific versions.  It
		/// should be OK to use in database drivers without modification.
		/// </summary>
		// Token: 0x060071B1 RID: 29105 RVA: 0x000A3F48 File Offset: 0x000A2148
		public virtual bool BindParameter(int index, byte value)
		{
			return vtkSQLQuery.vtkSQLQuery_BindParameter_02(base.GetCppThis(), index, value) != 0;
		}

		// Token: 0x060071B2 RID: 29106
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLQuery_BindParameter_03(HandleRef pThis, int index, ushort value);

		/// <summary>
		/// Bind a parameter to a placeholder in a query.  A full discussion
		/// of this feature is beyond the scope of this header file, but in
		/// short, here's how it works:
		///
		/// Instead of saying "SELECT foo FROM mytable WHERE myfield = 12345"
		/// you can say "SELECT foo FROM mytable WHERE myfield = ?".  The ?
		/// character is a placeholder for a parameter that must then be
		/// bound.  Call BindParameter(0, 12345) to bind the integer value
		/// 12345 to that field.  Placeholders are indexed starting at 0.
		///
		/// You are responsible for making sure that the types match when you
		/// call BindParameter.  You don't have to get it precisely correct:
		/// in general, the SQL driver is smart enough to do things like cast
		/// a short to a long or a float to a double.
		///
		/// Bound parameters were introduced in ANSI SQL 92.  Please see that
		/// standard for more information.
		///
		/// Most of these methods are excluded from wrapping because the Java
		/// wrapper treats all integer types from char up through 64-bit long
		/// as 'int'.  This is incorrect behavior but what else am I going to
		/// do?
		///
		/// Finally, the default implementation for BindParameter(int,
		/// vtkVariant) dispatches to one of the more type-specific versions.  It
		/// should be OK to use in database drivers without modification.
		/// </summary>
		// Token: 0x060071B3 RID: 29107 RVA: 0x000A3F70 File Offset: 0x000A2170
		public virtual bool BindParameter(int index, ushort value)
		{
			return vtkSQLQuery.vtkSQLQuery_BindParameter_03(base.GetCppThis(), index, value) != 0;
		}

		// Token: 0x060071B4 RID: 29108
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLQuery_BindParameter_04(HandleRef pThis, int index, uint value);

		/// <summary>
		/// Bind a parameter to a placeholder in a query.  A full discussion
		/// of this feature is beyond the scope of this header file, but in
		/// short, here's how it works:
		///
		/// Instead of saying "SELECT foo FROM mytable WHERE myfield = 12345"
		/// you can say "SELECT foo FROM mytable WHERE myfield = ?".  The ?
		/// character is a placeholder for a parameter that must then be
		/// bound.  Call BindParameter(0, 12345) to bind the integer value
		/// 12345 to that field.  Placeholders are indexed starting at 0.
		///
		/// You are responsible for making sure that the types match when you
		/// call BindParameter.  You don't have to get it precisely correct:
		/// in general, the SQL driver is smart enough to do things like cast
		/// a short to a long or a float to a double.
		///
		/// Bound parameters were introduced in ANSI SQL 92.  Please see that
		/// standard for more information.
		///
		/// Most of these methods are excluded from wrapping because the Java
		/// wrapper treats all integer types from char up through 64-bit long
		/// as 'int'.  This is incorrect behavior but what else am I going to
		/// do?
		///
		/// Finally, the default implementation for BindParameter(int,
		/// vtkVariant) dispatches to one of the more type-specific versions.  It
		/// should be OK to use in database drivers without modification.
		/// </summary>
		// Token: 0x060071B5 RID: 29109 RVA: 0x000A3F98 File Offset: 0x000A2198
		public virtual bool BindParameter(int index, uint value)
		{
			return vtkSQLQuery.vtkSQLQuery_BindParameter_04(base.GetCppThis(), index, value) != 0;
		}

		// Token: 0x060071B6 RID: 29110
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLQuery_BindParameter_05(HandleRef pThis, int index, sbyte value);

		/// <summary>
		/// Bind a parameter to a placeholder in a query.  A full discussion
		/// of this feature is beyond the scope of this header file, but in
		/// short, here's how it works:
		///
		/// Instead of saying "SELECT foo FROM mytable WHERE myfield = 12345"
		/// you can say "SELECT foo FROM mytable WHERE myfield = ?".  The ?
		/// character is a placeholder for a parameter that must then be
		/// bound.  Call BindParameter(0, 12345) to bind the integer value
		/// 12345 to that field.  Placeholders are indexed starting at 0.
		///
		/// You are responsible for making sure that the types match when you
		/// call BindParameter.  You don't have to get it precisely correct:
		/// in general, the SQL driver is smart enough to do things like cast
		/// a short to a long or a float to a double.
		///
		/// Bound parameters were introduced in ANSI SQL 92.  Please see that
		/// standard for more information.
		///
		/// Most of these methods are excluded from wrapping because the Java
		/// wrapper treats all integer types from char up through 64-bit long
		/// as 'int'.  This is incorrect behavior but what else am I going to
		/// do?
		///
		/// Finally, the default implementation for BindParameter(int,
		/// vtkVariant) dispatches to one of the more type-specific versions.  It
		/// should be OK to use in database drivers without modification.
		/// </summary>
		// Token: 0x060071B7 RID: 29111 RVA: 0x000A3FC0 File Offset: 0x000A21C0
		public virtual bool BindParameter(int index, sbyte value)
		{
			return vtkSQLQuery.vtkSQLQuery_BindParameter_05(base.GetCppThis(), index, value) != 0;
		}

		// Token: 0x060071B8 RID: 29112
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLQuery_BindParameter_06(HandleRef pThis, int index, short value);

		/// <summary>
		/// Bind a parameter to a placeholder in a query.  A full discussion
		/// of this feature is beyond the scope of this header file, but in
		/// short, here's how it works:
		///
		/// Instead of saying "SELECT foo FROM mytable WHERE myfield = 12345"
		/// you can say "SELECT foo FROM mytable WHERE myfield = ?".  The ?
		/// character is a placeholder for a parameter that must then be
		/// bound.  Call BindParameter(0, 12345) to bind the integer value
		/// 12345 to that field.  Placeholders are indexed starting at 0.
		///
		/// You are responsible for making sure that the types match when you
		/// call BindParameter.  You don't have to get it precisely correct:
		/// in general, the SQL driver is smart enough to do things like cast
		/// a short to a long or a float to a double.
		///
		/// Bound parameters were introduced in ANSI SQL 92.  Please see that
		/// standard for more information.
		///
		/// Most of these methods are excluded from wrapping because the Java
		/// wrapper treats all integer types from char up through 64-bit long
		/// as 'int'.  This is incorrect behavior but what else am I going to
		/// do?
		///
		/// Finally, the default implementation for BindParameter(int,
		/// vtkVariant) dispatches to one of the more type-specific versions.  It
		/// should be OK to use in database drivers without modification.
		/// </summary>
		// Token: 0x060071B9 RID: 29113 RVA: 0x000A3FE8 File Offset: 0x000A21E8
		public virtual bool BindParameter(int index, short value)
		{
			return vtkSQLQuery.vtkSQLQuery_BindParameter_06(base.GetCppThis(), index, value) != 0;
		}

		// Token: 0x060071BA RID: 29114
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLQuery_BindParameter_07(HandleRef pThis, int index, int value);

		/// <summary>
		/// Bind a parameter to a placeholder in a query.  A full discussion
		/// of this feature is beyond the scope of this header file, but in
		/// short, here's how it works:
		///
		/// Instead of saying "SELECT foo FROM mytable WHERE myfield = 12345"
		/// you can say "SELECT foo FROM mytable WHERE myfield = ?".  The ?
		/// character is a placeholder for a parameter that must then be
		/// bound.  Call BindParameter(0, 12345) to bind the integer value
		/// 12345 to that field.  Placeholders are indexed starting at 0.
		///
		/// You are responsible for making sure that the types match when you
		/// call BindParameter.  You don't have to get it precisely correct:
		/// in general, the SQL driver is smart enough to do things like cast
		/// a short to a long or a float to a double.
		///
		/// Bound parameters were introduced in ANSI SQL 92.  Please see that
		/// standard for more information.
		///
		/// Most of these methods are excluded from wrapping because the Java
		/// wrapper treats all integer types from char up through 64-bit long
		/// as 'int'.  This is incorrect behavior but what else am I going to
		/// do?
		///
		/// Finally, the default implementation for BindParameter(int,
		/// vtkVariant) dispatches to one of the more type-specific versions.  It
		/// should be OK to use in database drivers without modification.
		/// </summary>
		// Token: 0x060071BB RID: 29115 RVA: 0x000A4010 File Offset: 0x000A2210
		public virtual bool BindParameter(int index, int value)
		{
			return vtkSQLQuery.vtkSQLQuery_BindParameter_07(base.GetCppThis(), index, value) != 0;
		}

		// Token: 0x060071BC RID: 29116
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLQuery_BindParameter_08(HandleRef pThis, int index, ulong value);

		/// <summary>
		/// Bind a parameter to a placeholder in a query.  A full discussion
		/// of this feature is beyond the scope of this header file, but in
		/// short, here's how it works:
		///
		/// Instead of saying "SELECT foo FROM mytable WHERE myfield = 12345"
		/// you can say "SELECT foo FROM mytable WHERE myfield = ?".  The ?
		/// character is a placeholder for a parameter that must then be
		/// bound.  Call BindParameter(0, 12345) to bind the integer value
		/// 12345 to that field.  Placeholders are indexed starting at 0.
		///
		/// You are responsible for making sure that the types match when you
		/// call BindParameter.  You don't have to get it precisely correct:
		/// in general, the SQL driver is smart enough to do things like cast
		/// a short to a long or a float to a double.
		///
		/// Bound parameters were introduced in ANSI SQL 92.  Please see that
		/// standard for more information.
		///
		/// Most of these methods are excluded from wrapping because the Java
		/// wrapper treats all integer types from char up through 64-bit long
		/// as 'int'.  This is incorrect behavior but what else am I going to
		/// do?
		///
		/// Finally, the default implementation for BindParameter(int,
		/// vtkVariant) dispatches to one of the more type-specific versions.  It
		/// should be OK to use in database drivers without modification.
		/// </summary>
		// Token: 0x060071BD RID: 29117 RVA: 0x000A4038 File Offset: 0x000A2238
		public virtual bool BindParameter(int index, ulong value)
		{
			return vtkSQLQuery.vtkSQLQuery_BindParameter_08(base.GetCppThis(), index, value) != 0;
		}

		// Token: 0x060071BE RID: 29118
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLQuery_BindParameter_09(HandleRef pThis, int index, long value);

		/// <summary>
		/// Bind a parameter to a placeholder in a query.  A full discussion
		/// of this feature is beyond the scope of this header file, but in
		/// short, here's how it works:
		///
		/// Instead of saying "SELECT foo FROM mytable WHERE myfield = 12345"
		/// you can say "SELECT foo FROM mytable WHERE myfield = ?".  The ?
		/// character is a placeholder for a parameter that must then be
		/// bound.  Call BindParameter(0, 12345) to bind the integer value
		/// 12345 to that field.  Placeholders are indexed starting at 0.
		///
		/// You are responsible for making sure that the types match when you
		/// call BindParameter.  You don't have to get it precisely correct:
		/// in general, the SQL driver is smart enough to do things like cast
		/// a short to a long or a float to a double.
		///
		/// Bound parameters were introduced in ANSI SQL 92.  Please see that
		/// standard for more information.
		///
		/// Most of these methods are excluded from wrapping because the Java
		/// wrapper treats all integer types from char up through 64-bit long
		/// as 'int'.  This is incorrect behavior but what else am I going to
		/// do?
		///
		/// Finally, the default implementation for BindParameter(int,
		/// vtkVariant) dispatches to one of the more type-specific versions.  It
		/// should be OK to use in database drivers without modification.
		/// </summary>
		// Token: 0x060071BF RID: 29119 RVA: 0x000A4060 File Offset: 0x000A2260
		public virtual bool BindParameter(int index, long value)
		{
			return vtkSQLQuery.vtkSQLQuery_BindParameter_09(base.GetCppThis(), index, value) != 0;
		}

		// Token: 0x060071C0 RID: 29120
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLQuery_BindParameter_10(HandleRef pThis, int index, float value);

		/// <summary>
		/// Bind a parameter to a placeholder in a query.  A full discussion
		/// of this feature is beyond the scope of this header file, but in
		/// short, here's how it works:
		///
		/// Instead of saying "SELECT foo FROM mytable WHERE myfield = 12345"
		/// you can say "SELECT foo FROM mytable WHERE myfield = ?".  The ?
		/// character is a placeholder for a parameter that must then be
		/// bound.  Call BindParameter(0, 12345) to bind the integer value
		/// 12345 to that field.  Placeholders are indexed starting at 0.
		///
		/// You are responsible for making sure that the types match when you
		/// call BindParameter.  You don't have to get it precisely correct:
		/// in general, the SQL driver is smart enough to do things like cast
		/// a short to a long or a float to a double.
		///
		/// Bound parameters were introduced in ANSI SQL 92.  Please see that
		/// standard for more information.
		///
		/// Most of these methods are excluded from wrapping because the Java
		/// wrapper treats all integer types from char up through 64-bit long
		/// as 'int'.  This is incorrect behavior but what else am I going to
		/// do?
		///
		/// Finally, the default implementation for BindParameter(int,
		/// vtkVariant) dispatches to one of the more type-specific versions.  It
		/// should be OK to use in database drivers without modification.
		/// </summary>
		// Token: 0x060071C1 RID: 29121 RVA: 0x000A4088 File Offset: 0x000A2288
		public virtual bool BindParameter(int index, float value)
		{
			return vtkSQLQuery.vtkSQLQuery_BindParameter_10(base.GetCppThis(), index, value) != 0;
		}

		// Token: 0x060071C2 RID: 29122
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLQuery_BindParameter_11(HandleRef pThis, int index, double value);

		/// <summary>
		/// Bind a parameter to a placeholder in a query.  A full discussion
		/// of this feature is beyond the scope of this header file, but in
		/// short, here's how it works:
		///
		/// Instead of saying "SELECT foo FROM mytable WHERE myfield = 12345"
		/// you can say "SELECT foo FROM mytable WHERE myfield = ?".  The ?
		/// character is a placeholder for a parameter that must then be
		/// bound.  Call BindParameter(0, 12345) to bind the integer value
		/// 12345 to that field.  Placeholders are indexed starting at 0.
		///
		/// You are responsible for making sure that the types match when you
		/// call BindParameter.  You don't have to get it precisely correct:
		/// in general, the SQL driver is smart enough to do things like cast
		/// a short to a long or a float to a double.
		///
		/// Bound parameters were introduced in ANSI SQL 92.  Please see that
		/// standard for more information.
		///
		/// Most of these methods are excluded from wrapping because the Java
		/// wrapper treats all integer types from char up through 64-bit long
		/// as 'int'.  This is incorrect behavior but what else am I going to
		/// do?
		///
		/// Finally, the default implementation for BindParameter(int,
		/// vtkVariant) dispatches to one of the more type-specific versions.  It
		/// should be OK to use in database drivers without modification.
		/// </summary>
		// Token: 0x060071C3 RID: 29123 RVA: 0x000A40B0 File Offset: 0x000A22B0
		public virtual bool BindParameter(int index, double value)
		{
			return vtkSQLQuery.vtkSQLQuery_BindParameter_11(base.GetCppThis(), index, value) != 0;
		}

		// Token: 0x060071C4 RID: 29124
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLQuery_BindParameter_12(HandleRef pThis, int index, [MarshalAs(UnmanagedType.LPUTF8Str)] string stringValue);

		/// <summary>
		/// Bind a string value -- string must be null-terminated
		/// </summary>
		// Token: 0x060071C5 RID: 29125 RVA: 0x000A40D8 File Offset: 0x000A22D8
		public virtual bool BindParameter(int index, string stringValue)
		{
			return vtkSQLQuery.vtkSQLQuery_BindParameter_12(base.GetCppThis(), index, stringValue) != 0;
		}

		// Token: 0x060071C6 RID: 29126
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLQuery_BindParameter_13(HandleRef pThis, int index, [MarshalAs(UnmanagedType.LPUTF8Str)] string stringValue, ulong length);

		/// <summary>
		/// Bind a string value by specifying an array and a size
		/// </summary>
		// Token: 0x060071C7 RID: 29127 RVA: 0x000A4100 File Offset: 0x000A2300
		public virtual bool BindParameter(int index, string stringValue, ulong length)
		{
			return vtkSQLQuery.vtkSQLQuery_BindParameter_13(base.GetCppThis(), index, stringValue, length) != 0;
		}

		// Token: 0x060071C8 RID: 29128
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLQuery_BindParameter_14(HandleRef pThis, int index, HandleRef var);

		/// <summary>
		/// Bind a string value by specifying an array and a size
		/// </summary>
		// Token: 0x060071C9 RID: 29129 RVA: 0x000A412C File Offset: 0x000A232C
		public virtual bool BindParameter(int index, vtkVariant var)
		{
			return vtkSQLQuery.vtkSQLQuery_BindParameter_14(base.GetCppThis(), index, (var == null) ? default(HandleRef) : var.GetCppThis()) != 0;
		}

		// Token: 0x060071CA RID: 29130
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLQuery_BindParameter_15(HandleRef pThis, int index, IntPtr data, ulong length);

		/// <summary>
		/// Bind a blob value.  Not all databases support blobs as a data
		/// type.  Check vtkSQLDatabase::IsSupported(VTK_SQL_FEATURE_BLOB) to
		/// make sure.
		/// </summary>
		// Token: 0x060071CB RID: 29131 RVA: 0x000A4168 File Offset: 0x000A2368
		public virtual bool BindParameter(int index, IntPtr data, ulong length)
		{
			return vtkSQLQuery.vtkSQLQuery_BindParameter_15(base.GetCppThis(), index, data, length) != 0;
		}

		// Token: 0x060071CC RID: 29132
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLQuery_ClearParameterBindings_16(HandleRef pThis);

		/// <summary>
		/// Reset all parameter bindings to nullptr.
		/// </summary>
		// Token: 0x060071CD RID: 29133 RVA: 0x000A4194 File Offset: 0x000A2394
		public virtual bool ClearParameterBindings()
		{
			return vtkSQLQuery.vtkSQLQuery_ClearParameterBindings_16(base.GetCppThis()) != 0;
		}

		// Token: 0x060071CE RID: 29134
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLQuery_CommitTransaction_17(HandleRef pThis);

		/// <summary>
		/// Begin, commit, or roll back a transaction.  If the underlying
		/// database does not support transactions these calls will do
		/// nothing.
		/// </summary>
		// Token: 0x060071CF RID: 29135 RVA: 0x000A41BC File Offset: 0x000A23BC
		public virtual bool CommitTransaction()
		{
			return vtkSQLQuery.vtkSQLQuery_CommitTransaction_17(base.GetCppThis()) != 0;
		}

		// Token: 0x060071D0 RID: 29136
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkSQLQuery_EscapeString_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string s, byte addSurroundingQuotes);

		/// <summary>
		/// Escape a string for inclusion into an SQL query.
		/// If \a addSurroundingQuotes is true, then quotation marks appropriate to the
		/// backend database will be added to enclose the escaped string. This argument
		/// defaults to true.
		///
		/// A default, simple-minded implementation is provided for
		/// database backends that do not provde a way to escape
		/// strings for use inside queries.
		/// </summary>
		// Token: 0x060071D1 RID: 29137 RVA: 0x000A41E4 File Offset: 0x000A23E4
		public virtual string EscapeString(string s, bool addSurroundingQuotes)
		{
			return vtkSQLQuery.vtkSQLQuery_EscapeString_18(base.GetCppThis(), s, addSurroundingQuotes ? (byte)1 : (byte)0);
		}

		// Token: 0x060071D2 RID: 29138
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLQuery_Execute_19(HandleRef pThis);

		/// <summary>
		/// Execute the query.  This must be performed
		/// before any field name or data access functions
		/// are used.
		/// </summary>
		// Token: 0x060071D3 RID: 29139 RVA: 0x000A4210 File Offset: 0x000A2410
		public override bool Execute()
		{
			return vtkSQLQuery.vtkSQLQuery_Execute_19(base.GetCppThis()) != 0;
		}

		// Token: 0x060071D4 RID: 29140
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSQLQuery_GetDatabase_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the database associated with the query.
		/// </summary>
		// Token: 0x060071D5 RID: 29141 RVA: 0x000A4238 File Offset: 0x000A2438
		public virtual vtkSQLDatabase GetDatabase()
		{
			vtkSQLDatabase vtkSQLDatabase = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSQLQuery.vtkSQLQuery_GetDatabase_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSQLDatabase = (vtkSQLDatabase)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSQLDatabase.Register(null);
				}
			}
			return vtkSQLDatabase;
		}

		// Token: 0x060071D6 RID: 29142
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSQLQuery_GetNumberOfGenerationsFromBase_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060071D7 RID: 29143 RVA: 0x000A42A8 File Offset: 0x000A24A8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSQLQuery.vtkSQLQuery_GetNumberOfGenerationsFromBase_21(base.GetCppThis(), type);
		}

		// Token: 0x060071D8 RID: 29144
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSQLQuery_GetNumberOfGenerationsFromBaseType_22([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060071D9 RID: 29145 RVA: 0x000A42C8 File Offset: 0x000A24C8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSQLQuery.vtkSQLQuery_GetNumberOfGenerationsFromBaseType_22(type);
		}

		// Token: 0x060071DA RID: 29146
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSQLQuery_GetQuery_23(HandleRef pThis);

		/// <summary>
		/// The query string to be executed.  Since some databases will
		/// process the query string as soon as it's set, this method returns
		/// a boolean to indicate success or failure.
		/// </summary>
		// Token: 0x060071DB RID: 29147 RVA: 0x000A42E4 File Offset: 0x000A24E4
		public virtual string GetQuery()
		{
			string s = Marshal.PtrToStringAnsi(vtkSQLQuery.vtkSQLQuery_GetQuery_23(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060071DC RID: 29148
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSQLQuery_IsA_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060071DD RID: 29149 RVA: 0x000A4320 File Offset: 0x000A2520
		public override int IsA(string type)
		{
			return vtkSQLQuery.vtkSQLQuery_IsA_24(base.GetCppThis(), type);
		}

		// Token: 0x060071DE RID: 29150
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLQuery_IsActive_25(HandleRef pThis);

		/// <summary>
		/// Return true if the query is active (i.e. execution was successful
		/// and results are ready to be fetched).  Returns false on error or
		/// inactive query.
		/// </summary>
		// Token: 0x060071DF RID: 29151 RVA: 0x000A4340 File Offset: 0x000A2540
		public override bool IsActive()
		{
			return vtkSQLQuery.vtkSQLQuery_IsActive_25(base.GetCppThis()) != 0;
		}

		// Token: 0x060071E0 RID: 29152
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSQLQuery_IsTypeOf_26([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060071E1 RID: 29153 RVA: 0x000A4368 File Offset: 0x000A2568
		public new static int IsTypeOf(string type)
		{
			return vtkSQLQuery.vtkSQLQuery_IsTypeOf_26(type);
		}

		// Token: 0x060071E2 RID: 29154
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSQLQuery_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060071E3 RID: 29155 RVA: 0x000A4384 File Offset: 0x000A2584
		public new vtkSQLQuery NewInstance()
		{
			vtkSQLQuery result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSQLQuery.vtkSQLQuery_NewInstance_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSQLQuery)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060071E4 RID: 29156
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLQuery_RollbackTransaction_28(HandleRef pThis);

		/// <summary>
		/// Begin, commit, or roll back a transaction.  If the underlying
		/// database does not support transactions these calls will do
		/// nothing.
		/// </summary>
		// Token: 0x060071E5 RID: 29157 RVA: 0x000A43E0 File Offset: 0x000A25E0
		public virtual bool RollbackTransaction()
		{
			return vtkSQLQuery.vtkSQLQuery_RollbackTransaction_28(base.GetCppThis()) != 0;
		}

		// Token: 0x060071E6 RID: 29158
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSQLQuery_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060071E7 RID: 29159 RVA: 0x000A4408 File Offset: 0x000A2608
		public new static vtkSQLQuery SafeDownCast(vtkObjectBase o)
		{
			vtkSQLQuery vtkSQLQuery = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSQLQuery.vtkSQLQuery_SafeDownCast_29((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSQLQuery = (vtkSQLQuery)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSQLQuery.Register(null);
				}
			}
			return vtkSQLQuery;
		}

		// Token: 0x060071E8 RID: 29160
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLQuery_SetQuery_30(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string query);

		/// <summary>
		/// The query string to be executed.  Since some databases will
		/// process the query string as soon as it's set, this method returns
		/// a boolean to indicate success or failure.
		/// </summary>
		// Token: 0x060071E9 RID: 29161 RVA: 0x000A4488 File Offset: 0x000A2688
		public virtual bool SetQuery(string query)
		{
			return vtkSQLQuery.vtkSQLQuery_SetQuery_30(base.GetCppThis(), query) != 0;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009EE RID: 2542
		public new const string MRFullTypeName = "Kitware.VTK.vtkSQLQuery";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009EF RID: 2543
		public new static readonly string MRClassNameKey = "class vtkSQLQuery";
	}
}
