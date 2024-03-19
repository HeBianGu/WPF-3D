using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSQLDatabaseSchema
	/// </summary>
	/// <remarks>
	///    represent an SQL database schema
	///
	///
	/// This class stores the information required to create
	/// an SQL database from scratch.
	/// Information on each table's columns, indices, and triggers is stored.
	/// You may also store an arbitrary number of preamble statements, intended
	/// to be executed before any tables are created;
	/// this provides a way to create procedures or functions that may be
	/// invoked as part of a trigger action.
	/// Triggers and table options may be specified differently for each backend
	/// database type you wish to support.
	///
	/// @par Thanks:
	/// Thanks to Philippe Pebay and David Thompson from Sandia National
	/// Laboratories for implementing this class.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkSQLDatabase
	/// </seealso>
	// Token: 0x02000268 RID: 616
	public class vtkSQLDatabaseSchema : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060070E7 RID: 28903 RVA: 0x000A2C8A File Offset: 0x000A0E8A
		static vtkSQLDatabaseSchema()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSQLDatabaseSchema.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSQLDatabaseSchema"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060070E8 RID: 28904 RVA: 0x000A2CB2 File Offset: 0x000A0EB2
		public vtkSQLDatabaseSchema(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060070E9 RID: 28905
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSQLDatabaseSchema_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060070EA RID: 28906 RVA: 0x000A2CC0 File Offset: 0x000A0EC0
		public new static vtkSQLDatabaseSchema New()
		{
			vtkSQLDatabaseSchema result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSQLDatabaseSchema)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060070EB RID: 28907 RVA: 0x000A2D14 File Offset: 0x000A0F14
		public vtkSQLDatabaseSchema() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060070EC RID: 28908 RVA: 0x000A2D58 File Offset: 0x000A0F58
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060070ED RID: 28909
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSQLDatabaseSchema_AddColumnToIndex_01(HandleRef pThis, int tblHandle, int idxHandle, int colHandle);

		/// <summary>
		/// Add a column to a table index.
		///
		/// The returned value is an index-column handle or -1 if an error occurred.
		/// </summary>
		// Token: 0x060070EE RID: 28910 RVA: 0x000A2D64 File Offset: 0x000A0F64
		public virtual int AddColumnToIndex(int tblHandle, int idxHandle, int colHandle)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_AddColumnToIndex_01(base.GetCppThis(), tblHandle, idxHandle, colHandle);
		}

		// Token: 0x060070EF RID: 28911
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSQLDatabaseSchema_AddColumnToIndex_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string tblName, [MarshalAs(UnmanagedType.LPUTF8Str)] string idxName, [MarshalAs(UnmanagedType.LPUTF8Str)] string colName);

		/// <summary>
		/// Add a column to a table index.
		///
		/// The returned value is an index-column handle or -1 if an error occurred.
		/// </summary>
		// Token: 0x060070F0 RID: 28912 RVA: 0x000A2D88 File Offset: 0x000A0F88
		public virtual int AddColumnToIndex(string tblName, string idxName, string colName)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_AddColumnToIndex_02(base.GetCppThis(), tblName, idxName, colName);
		}

		// Token: 0x060070F1 RID: 28913
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSQLDatabaseSchema_AddColumnToTable_03(HandleRef pThis, int tblHandle, int colType, [MarshalAs(UnmanagedType.LPUTF8Str)] string colName, int colSize, [MarshalAs(UnmanagedType.LPUTF8Str)] string colOpts);

		/// <summary>
		/// Add a column to table.
		///
		/// The returned value is a column handle or -1 if an error occurred.
		/// </summary>
		// Token: 0x060070F2 RID: 28914 RVA: 0x000A2DAC File Offset: 0x000A0FAC
		public virtual int AddColumnToTable(int tblHandle, int colType, string colName, int colSize, string colOpts)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_AddColumnToTable_03(base.GetCppThis(), tblHandle, colType, colName, colSize, colOpts);
		}

		// Token: 0x060070F3 RID: 28915
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSQLDatabaseSchema_AddColumnToTable_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string tblName, int colType, [MarshalAs(UnmanagedType.LPUTF8Str)] string colName, int colSize, [MarshalAs(UnmanagedType.LPUTF8Str)] string colAttribs);

		/// <summary>
		/// Add a column to table.
		///
		/// The returned value is a column handle or -1 if an error occurred.
		/// </summary>
		// Token: 0x060070F4 RID: 28916 RVA: 0x000A2DD4 File Offset: 0x000A0FD4
		public virtual int AddColumnToTable(string tblName, int colType, string colName, int colSize, string colAttribs)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_AddColumnToTable_04(base.GetCppThis(), tblName, colType, colName, colSize, colAttribs);
		}

		// Token: 0x060070F5 RID: 28917
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSQLDatabaseSchema_AddIndexToTable_05(HandleRef pThis, int tblHandle, int idxType, [MarshalAs(UnmanagedType.LPUTF8Str)] string idxName);

		/// <summary>
		/// Add an index to table.
		///
		/// The returned value is an index handle or -1 if an error occurred.
		/// </summary>
		// Token: 0x060070F6 RID: 28918 RVA: 0x000A2DFC File Offset: 0x000A0FFC
		public virtual int AddIndexToTable(int tblHandle, int idxType, string idxName)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_AddIndexToTable_05(base.GetCppThis(), tblHandle, idxType, idxName);
		}

		// Token: 0x060070F7 RID: 28919
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSQLDatabaseSchema_AddIndexToTable_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string tblName, int idxType, [MarshalAs(UnmanagedType.LPUTF8Str)] string idxName);

		/// <summary>
		/// Add an index to table.
		///
		/// The returned value is an index handle or -1 if an error occurred.
		/// </summary>
		// Token: 0x060070F8 RID: 28920 RVA: 0x000A2E20 File Offset: 0x000A1020
		public virtual int AddIndexToTable(string tblName, int idxType, string idxName)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_AddIndexToTable_06(base.GetCppThis(), tblName, idxType, idxName);
		}

		// Token: 0x060070F9 RID: 28921
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSQLDatabaseSchema_AddOptionToTable_07(HandleRef pThis, int tblHandle, [MarshalAs(UnmanagedType.LPUTF8Str)] string optText, [MarshalAs(UnmanagedType.LPUTF8Str)] string optBackend);

		/// <summary>
		/// Add (possibly backend-specific) text to the end of a
		/// CREATE TABLE (...) statement.
		///
		/// This is most useful for specifying storage semantics of tables
		/// that are specific to the backend. For example, table options
		/// can be used to specify the TABLESPACE of a PostgreSQL table or
		/// the ENGINE of a MySQL table.
		///
		/// The returned value is an option handle or -1 if an error occurred.
		/// </summary>
		// Token: 0x060070FA RID: 28922 RVA: 0x000A2E44 File Offset: 0x000A1044
		public virtual int AddOptionToTable(int tblHandle, string optText, string optBackend)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_AddOptionToTable_07(base.GetCppThis(), tblHandle, optText, optBackend);
		}

		// Token: 0x060070FB RID: 28923
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSQLDatabaseSchema_AddOptionToTable_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string tblName, [MarshalAs(UnmanagedType.LPUTF8Str)] string optStr, [MarshalAs(UnmanagedType.LPUTF8Str)] string optBackend);

		/// <summary>
		/// Add (possibly backend-specific) text to the end of a
		/// CREATE TABLE (...) statement.
		///
		/// This is most useful for specifying storage semantics of tables
		/// that are specific to the backend. For example, table options
		/// can be used to specify the TABLESPACE of a PostgreSQL table or
		/// the ENGINE of a MySQL table.
		///
		/// The returned value is an option handle or -1 if an error occurred.
		/// </summary>
		// Token: 0x060070FC RID: 28924 RVA: 0x000A2E68 File Offset: 0x000A1068
		public virtual int AddOptionToTable(string tblName, string optStr, string optBackend)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_AddOptionToTable_08(base.GetCppThis(), tblName, optStr, optBackend);
		}

		// Token: 0x060070FD RID: 28925
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSQLDatabaseSchema_AddPreamble_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string preName, [MarshalAs(UnmanagedType.LPUTF8Str)] string preAction, [MarshalAs(UnmanagedType.LPUTF8Str)] string preBackend);

		/// <summary>
		/// Add a preamble to the schema
		/// This can be used, in particular, to create functions and/or
		/// load languages in a backend-specific manner.
		/// Example usage:
		/// vtkSQLDatabaseSchema* schema = vtkSQLDatabaseSchema::New();
		/// schema-&gt;SetName( "Example" );
		/// schema-&gt;AddPreamble( "dropPLPGSQL", "DROP LANGUAGE IF EXISTS PLPGSQL CASCADE",
		/// VTK_SQL_POSTGRESQL ); schema-&gt;AddPreamble( "loadPLPGSQL", "CREATE LANGUAGE PLPGSQL",
		/// VTK_SQL_POSTGRESQL ); schema-&gt;AddPreamble( "createsomefunction", "CREATE OR REPLACE FUNCTION
		/// somefunction() RETURNS TRIGGER AS $btable$ " "BEGIN " "INSERT INTO btable (somevalue) VALUES
		/// (NEW.somenmbr); " "RETURN NEW; " "END; $btable$ LANGUAGE PLPGSQL", VTK_SQL_POSTGRESQL );
		/// </summary>
		// Token: 0x060070FE RID: 28926 RVA: 0x000A2E8C File Offset: 0x000A108C
		public virtual int AddPreamble(string preName, string preAction, string preBackend)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_AddPreamble_09(base.GetCppThis(), preName, preAction, preBackend);
		}

		// Token: 0x060070FF RID: 28927
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSQLDatabaseSchema_AddTable_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string tblName);

		/// <summary>
		/// Add a table to the schema
		/// </summary>
		// Token: 0x06007100 RID: 28928 RVA: 0x000A2EB0 File Offset: 0x000A10B0
		public virtual int AddTable(string tblName)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_AddTable_10(base.GetCppThis(), tblName);
		}

		// Token: 0x06007101 RID: 28929
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSQLDatabaseSchema_AddTableMultipleArguments_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string tblName);

		/// <summary>
		/// An unwrappable but useful routine to construct built-in schema.
		/// Example usage:
		/// int main()
		/// {
		/// vtkSQLDatabaseSchema* schema = vtkSQLDatabaseSchema::New();
		/// schema-&gt;SetName( "Example" );
		/// schema-&gt;AddTableMultipleArguments( "atable",
		/// vtkSQLDatabaseSchema::COLUMN_TOKEN, vtkSQLDatabaseSchema::INTEGER, "tablekey",  0, "",
		/// vtkSQLDatabaseSchema::COLUMN_TOKEN, vtkSQLDatabaseSchema::VARCHAR, "somename", 11, "NOT
		/// nullptr", vtkSQLDatabaseSchema::COLUMN_TOKEN, vtkSQLDatabaseSchema::BIGINT,  "somenmbr", 17,
		/// "DEFAULT 0", vtkSQLDatabaseSchema::INDEX_TOKEN, vtkSQLDatabaseSchema::PRIMARY_KEY, "bigkey",
		/// vtkSQLDatabaseSchema::INDEX_COLUMN_TOKEN, "tablekey",
		/// vtkSQLDatabaseSchema::END_INDEX_TOKEN,
		/// vtkSQLDatabaseSchema::INDEX_TOKEN,  vtkSQLDatabaseSchema::UNIQUE, "reverselookup",
		/// vtkSQLDatabaseSchema::INDEX_COLUMN_TOKEN, "somename",
		/// vtkSQLDatabaseSchema::INDEX_COLUMN_TOKEN, "somenmbr",
		/// vtkSQLDatabaseSchema::END_INDEX_TOKEN,
		/// vtkSQLDatabaseSchema::TRIGGER_TOKEN,  vtkSQLDatabaseSchema::AFTER_INSERT,
		/// "InsertTrigger", "DO NOTHING", VTK_SQL_SQLITE,
		/// vtkSQLDatabaseSchema::TRIGGER_TOKEN,  vtkSQLDatabaseSchema::AFTER_INSERT,
		/// "InsertTrigger", "FOR EACH ROW EXECUTE PROCEDURE somefunction ()", VTK_SQL_POSTGRESQL,
		/// vtkSQLDatabaseSchema::TRIGGER_TOKEN,  vtkSQLDatabaseSchema::AFTER_INSERT,
		/// "InsertTrigger", "FOR EACH ROW INSERT INTO btable SET SomeValue = NEW.SomeNmbr", VTK_SQL_MYSQL,
		/// vtkSQLDatabaseSchema::END_TABLE_TOKEN
		/// );
		/// return 0;
		/// }
		/// </summary>
		// Token: 0x06007102 RID: 28930 RVA: 0x000A2ED0 File Offset: 0x000A10D0
		public int AddTableMultipleArguments(string tblName)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_AddTableMultipleArguments_11(base.GetCppThis(), tblName);
		}

		// Token: 0x06007103 RID: 28931
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSQLDatabaseSchema_AddTriggerToTable_12(HandleRef pThis, int tblHandle, int trgType, [MarshalAs(UnmanagedType.LPUTF8Str)] string trgName, [MarshalAs(UnmanagedType.LPUTF8Str)] string trgAction, [MarshalAs(UnmanagedType.LPUTF8Str)] string trgBackend);

		/// <summary>
		/// Add a (possibly backend-specific) trigger action to a table.
		///
		/// Triggers must be given unique, non-nullptr names as some database backends require them.
		/// The returned value is a trigger handle or -1 if an error occurred.
		/// </summary>
		// Token: 0x06007104 RID: 28932 RVA: 0x000A2EF0 File Offset: 0x000A10F0
		public virtual int AddTriggerToTable(int tblHandle, int trgType, string trgName, string trgAction, string trgBackend)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_AddTriggerToTable_12(base.GetCppThis(), tblHandle, trgType, trgName, trgAction, trgBackend);
		}

		// Token: 0x06007105 RID: 28933
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSQLDatabaseSchema_AddTriggerToTable_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string tblName, int trgType, [MarshalAs(UnmanagedType.LPUTF8Str)] string trgName, [MarshalAs(UnmanagedType.LPUTF8Str)] string trgAction, [MarshalAs(UnmanagedType.LPUTF8Str)] string trgBackend);

		/// <summary>
		/// Add a (possibly backend-specific) trigger action to a table.
		///
		/// Triggers must be given unique, non-nullptr names as some database backends require them.
		/// The returned value is a trigger handle or -1 if an error occurred.
		/// </summary>
		// Token: 0x06007106 RID: 28934 RVA: 0x000A2F18 File Offset: 0x000A1118
		public virtual int AddTriggerToTable(string tblName, int trgType, string trgName, string trgAction, string trgBackend)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_AddTriggerToTable_13(base.GetCppThis(), tblName, trgType, trgName, trgAction, trgBackend);
		}

		// Token: 0x06007107 RID: 28935
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSQLDatabaseSchema_GetColumnAttributesFromHandle_14(HandleRef pThis, int tblHandle, int colHandle);

		/// <summary>
		/// Given the handles of a table and a column, get the attributes of the column.
		/// </summary>
		// Token: 0x06007108 RID: 28936 RVA: 0x000A2F40 File Offset: 0x000A1140
		public string GetColumnAttributesFromHandle(int tblHandle, int colHandle)
		{
			string s = Marshal.PtrToStringAnsi(vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetColumnAttributesFromHandle_14(base.GetCppThis(), tblHandle, colHandle));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06007109 RID: 28937
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSQLDatabaseSchema_GetColumnHandleFromName_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string tblName, [MarshalAs(UnmanagedType.LPUTF8Str)] string colName);

		/// <summary>
		/// Given the names of a table and a column, get the handle of the column in this table.
		/// </summary>
		// Token: 0x0600710A RID: 28938 RVA: 0x000A2F7C File Offset: 0x000A117C
		public int GetColumnHandleFromName(string tblName, string colName)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetColumnHandleFromName_15(base.GetCppThis(), tblName, colName);
		}

		// Token: 0x0600710B RID: 28939
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSQLDatabaseSchema_GetColumnNameFromHandle_16(HandleRef pThis, int tblHandle, int colHandle);

		/// <summary>
		/// Given the handles of a table and a column, get the name of the column.
		/// </summary>
		// Token: 0x0600710C RID: 28940 RVA: 0x000A2FA0 File Offset: 0x000A11A0
		public string GetColumnNameFromHandle(int tblHandle, int colHandle)
		{
			string s = Marshal.PtrToStringAnsi(vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetColumnNameFromHandle_16(base.GetCppThis(), tblHandle, colHandle));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600710D RID: 28941
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSQLDatabaseSchema_GetColumnSizeFromHandle_17(HandleRef pThis, int tblHandle, int colHandle);

		/// <summary>
		/// Given the handles of a table and a column, get the size of the column.
		/// </summary>
		// Token: 0x0600710E RID: 28942 RVA: 0x000A2FDC File Offset: 0x000A11DC
		public int GetColumnSizeFromHandle(int tblHandle, int colHandle)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetColumnSizeFromHandle_17(base.GetCppThis(), tblHandle, colHandle);
		}

		// Token: 0x0600710F RID: 28943
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSQLDatabaseSchema_GetColumnTypeFromHandle_18(HandleRef pThis, int tblHandle, int colHandle);

		/// <summary>
		/// Given the handles of a table and a column, get the type of the column.
		/// </summary>
		// Token: 0x06007110 RID: 28944 RVA: 0x000A3000 File Offset: 0x000A1200
		public int GetColumnTypeFromHandle(int tblHandle, int colHandle)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetColumnTypeFromHandle_18(base.GetCppThis(), tblHandle, colHandle);
		}

		// Token: 0x06007111 RID: 28945
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSQLDatabaseSchema_GetIndexColumnNameFromHandle_19(HandleRef pThis, int tblHandle, int idxHandle, int cnmHandle);

		/// <summary>
		/// Given the handles of a table, an index, and a column name, get the column name.
		/// </summary>
		// Token: 0x06007112 RID: 28946 RVA: 0x000A3024 File Offset: 0x000A1224
		public string GetIndexColumnNameFromHandle(int tblHandle, int idxHandle, int cnmHandle)
		{
			string s = Marshal.PtrToStringAnsi(vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetIndexColumnNameFromHandle_19(base.GetCppThis(), tblHandle, idxHandle, cnmHandle));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06007113 RID: 28947
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSQLDatabaseSchema_GetIndexHandleFromName_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string tblName, [MarshalAs(UnmanagedType.LPUTF8Str)] string idxName);

		/// <summary>
		/// Given the names of a table and an index, get the handle of the index in this table.
		/// </summary>
		// Token: 0x06007114 RID: 28948 RVA: 0x000A3064 File Offset: 0x000A1264
		public int GetIndexHandleFromName(string tblName, string idxName)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetIndexHandleFromName_20(base.GetCppThis(), tblName, idxName);
		}

		// Token: 0x06007115 RID: 28949
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSQLDatabaseSchema_GetIndexNameFromHandle_21(HandleRef pThis, int tblHandle, int idxHandle);

		/// <summary>
		/// Given the handles of a table and an index, get the name of the index.
		/// </summary>
		// Token: 0x06007116 RID: 28950 RVA: 0x000A3088 File Offset: 0x000A1288
		public string GetIndexNameFromHandle(int tblHandle, int idxHandle)
		{
			string s = Marshal.PtrToStringAnsi(vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetIndexNameFromHandle_21(base.GetCppThis(), tblHandle, idxHandle));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06007117 RID: 28951
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSQLDatabaseSchema_GetIndexTypeFromHandle_22(HandleRef pThis, int tblHandle, int idxHandle);

		/// <summary>
		/// Given the handles of a table and an index, get the type of the index.
		/// </summary>
		// Token: 0x06007118 RID: 28952 RVA: 0x000A30C4 File Offset: 0x000A12C4
		public int GetIndexTypeFromHandle(int tblHandle, int idxHandle)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetIndexTypeFromHandle_22(base.GetCppThis(), tblHandle, idxHandle);
		}

		// Token: 0x06007119 RID: 28953
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSQLDatabaseSchema_GetName_23(HandleRef pThis);

		/// <summary>
		/// Set/Get the name of the schema.
		/// </summary>
		// Token: 0x0600711A RID: 28954 RVA: 0x000A30E8 File Offset: 0x000A12E8
		public virtual string GetName()
		{
			string s = Marshal.PtrToStringAnsi(vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetName_23(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600711B RID: 28955
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSQLDatabaseSchema_GetNumberOfColumnNamesInIndex_24(HandleRef pThis, int tblHandle, int idxHandle);

		/// <summary>
		/// Get the number of column names associated to a particular index in a particular table .
		/// </summary>
		// Token: 0x0600711C RID: 28956 RVA: 0x000A3124 File Offset: 0x000A1324
		public int GetNumberOfColumnNamesInIndex(int tblHandle, int idxHandle)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetNumberOfColumnNamesInIndex_24(base.GetCppThis(), tblHandle, idxHandle);
		}

		// Token: 0x0600711D RID: 28957
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSQLDatabaseSchema_GetNumberOfColumnsInTable_25(HandleRef pThis, int tblHandle);

		/// <summary>
		/// Get the number of columns in a particular table .
		/// </summary>
		// Token: 0x0600711E RID: 28958 RVA: 0x000A3148 File Offset: 0x000A1348
		public int GetNumberOfColumnsInTable(int tblHandle)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetNumberOfColumnsInTable_25(base.GetCppThis(), tblHandle);
		}

		// Token: 0x0600711F RID: 28959
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSQLDatabaseSchema_GetNumberOfGenerationsFromBase_26(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007120 RID: 28960 RVA: 0x000A3168 File Offset: 0x000A1368
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetNumberOfGenerationsFromBase_26(base.GetCppThis(), type);
		}

		// Token: 0x06007121 RID: 28961
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSQLDatabaseSchema_GetNumberOfGenerationsFromBaseType_27([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007122 RID: 28962 RVA: 0x000A3188 File Offset: 0x000A1388
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetNumberOfGenerationsFromBaseType_27(type);
		}

		// Token: 0x06007123 RID: 28963
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSQLDatabaseSchema_GetNumberOfIndicesInTable_28(HandleRef pThis, int tblHandle);

		/// <summary>
		/// Get the number of indices in a particular table .
		/// </summary>
		// Token: 0x06007124 RID: 28964 RVA: 0x000A31A4 File Offset: 0x000A13A4
		public int GetNumberOfIndicesInTable(int tblHandle)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetNumberOfIndicesInTable_28(base.GetCppThis(), tblHandle);
		}

		// Token: 0x06007125 RID: 28965
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSQLDatabaseSchema_GetNumberOfOptionsInTable_29(HandleRef pThis, int tblHandle);

		/// <summary>
		/// Get the number of options associated with a particular table.
		/// </summary>
		// Token: 0x06007126 RID: 28966 RVA: 0x000A31C4 File Offset: 0x000A13C4
		public int GetNumberOfOptionsInTable(int tblHandle)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetNumberOfOptionsInTable_29(base.GetCppThis(), tblHandle);
		}

		// Token: 0x06007127 RID: 28967
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSQLDatabaseSchema_GetNumberOfPreambles_30(HandleRef pThis);

		/// <summary>
		/// Get the number of preambles.
		/// </summary>
		// Token: 0x06007128 RID: 28968 RVA: 0x000A31E4 File Offset: 0x000A13E4
		public int GetNumberOfPreambles()
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetNumberOfPreambles_30(base.GetCppThis());
		}

		// Token: 0x06007129 RID: 28969
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSQLDatabaseSchema_GetNumberOfTables_31(HandleRef pThis);

		/// <summary>
		/// Get the number of tables.
		/// </summary>
		// Token: 0x0600712A RID: 28970 RVA: 0x000A3204 File Offset: 0x000A1404
		public int GetNumberOfTables()
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetNumberOfTables_31(base.GetCppThis());
		}

		// Token: 0x0600712B RID: 28971
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSQLDatabaseSchema_GetNumberOfTriggersInTable_32(HandleRef pThis, int tblHandle);

		/// <summary>
		/// Get the number of triggers defined for a particular table.
		/// </summary>
		// Token: 0x0600712C RID: 28972 RVA: 0x000A3224 File Offset: 0x000A1424
		public int GetNumberOfTriggersInTable(int tblHandle)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetNumberOfTriggersInTable_32(base.GetCppThis(), tblHandle);
		}

		// Token: 0x0600712D RID: 28973
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSQLDatabaseSchema_GetOptionBackendFromHandle_33(HandleRef pThis, int tblHandle, int optHandle);

		/// <summary>
		/// Given the handles of a table and one of its options, get the backend of the option.
		/// </summary>
		// Token: 0x0600712E RID: 28974 RVA: 0x000A3244 File Offset: 0x000A1444
		public string GetOptionBackendFromHandle(int tblHandle, int optHandle)
		{
			string s = Marshal.PtrToStringAnsi(vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetOptionBackendFromHandle_33(base.GetCppThis(), tblHandle, optHandle));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600712F RID: 28975
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSQLDatabaseSchema_GetOptionTextFromHandle_34(HandleRef pThis, int tblHandle, int optHandle);

		/// <summary>
		/// Given the handles of a table and one of its options, return the text of the option.
		/// </summary>
		// Token: 0x06007130 RID: 28976 RVA: 0x000A3280 File Offset: 0x000A1480
		public string GetOptionTextFromHandle(int tblHandle, int optHandle)
		{
			string s = Marshal.PtrToStringAnsi(vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetOptionTextFromHandle_34(base.GetCppThis(), tblHandle, optHandle));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06007131 RID: 28977
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSQLDatabaseSchema_GetPreambleActionFromHandle_35(HandleRef pThis, int preHandle);

		/// <summary>
		/// Given a preamble handle, get its action.
		/// </summary>
		// Token: 0x06007132 RID: 28978 RVA: 0x000A32BC File Offset: 0x000A14BC
		public string GetPreambleActionFromHandle(int preHandle)
		{
			string s = Marshal.PtrToStringAnsi(vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetPreambleActionFromHandle_35(base.GetCppThis(), preHandle));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06007133 RID: 28979
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSQLDatabaseSchema_GetPreambleBackendFromHandle_36(HandleRef pThis, int preHandle);

		/// <summary>
		/// Given a preamble handle, get its backend.
		/// </summary>
		// Token: 0x06007134 RID: 28980 RVA: 0x000A32F8 File Offset: 0x000A14F8
		public string GetPreambleBackendFromHandle(int preHandle)
		{
			string s = Marshal.PtrToStringAnsi(vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetPreambleBackendFromHandle_36(base.GetCppThis(), preHandle));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06007135 RID: 28981
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSQLDatabaseSchema_GetPreambleHandleFromName_37(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string preName);

		/// <summary>
		/// Given a preamble name, get its handle.
		/// </summary>
		// Token: 0x06007136 RID: 28982 RVA: 0x000A3334 File Offset: 0x000A1534
		public int GetPreambleHandleFromName(string preName)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetPreambleHandleFromName_37(base.GetCppThis(), preName);
		}

		// Token: 0x06007137 RID: 28983
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSQLDatabaseSchema_GetPreambleNameFromHandle_38(HandleRef pThis, int preHandle);

		/// <summary>
		/// Given a preamble handle, get its name.
		/// </summary>
		// Token: 0x06007138 RID: 28984 RVA: 0x000A3354 File Offset: 0x000A1554
		public string GetPreambleNameFromHandle(int preHandle)
		{
			string s = Marshal.PtrToStringAnsi(vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetPreambleNameFromHandle_38(base.GetCppThis(), preHandle));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06007139 RID: 28985
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSQLDatabaseSchema_GetTableHandleFromName_39(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string tblName);

		/// <summary>
		/// Given a table name, get its handle.
		/// </summary>
		// Token: 0x0600713A RID: 28986 RVA: 0x000A3390 File Offset: 0x000A1590
		public int GetTableHandleFromName(string tblName)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetTableHandleFromName_39(base.GetCppThis(), tblName);
		}

		// Token: 0x0600713B RID: 28987
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSQLDatabaseSchema_GetTableNameFromHandle_40(HandleRef pThis, int tblHandle);

		/// <summary>
		/// Given a table handle, get its name.
		/// </summary>
		// Token: 0x0600713C RID: 28988 RVA: 0x000A33B0 File Offset: 0x000A15B0
		public string GetTableNameFromHandle(int tblHandle)
		{
			string s = Marshal.PtrToStringAnsi(vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetTableNameFromHandle_40(base.GetCppThis(), tblHandle));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600713D RID: 28989
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSQLDatabaseSchema_GetTriggerActionFromHandle_41(HandleRef pThis, int tblHandle, int trgHandle);

		/// <summary>
		/// Given the handles of a table and a trigger, get the action of the trigger.
		/// </summary>
		// Token: 0x0600713E RID: 28990 RVA: 0x000A33EC File Offset: 0x000A15EC
		public string GetTriggerActionFromHandle(int tblHandle, int trgHandle)
		{
			string s = Marshal.PtrToStringAnsi(vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetTriggerActionFromHandle_41(base.GetCppThis(), tblHandle, trgHandle));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600713F RID: 28991
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSQLDatabaseSchema_GetTriggerBackendFromHandle_42(HandleRef pThis, int tblHandle, int trgHandle);

		/// <summary>
		/// Given the handles of a table and a trigger, get the backend of the trigger.
		/// </summary>
		// Token: 0x06007140 RID: 28992 RVA: 0x000A3428 File Offset: 0x000A1628
		public string GetTriggerBackendFromHandle(int tblHandle, int trgHandle)
		{
			string s = Marshal.PtrToStringAnsi(vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetTriggerBackendFromHandle_42(base.GetCppThis(), tblHandle, trgHandle));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06007141 RID: 28993
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSQLDatabaseSchema_GetTriggerHandleFromName_43(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string tblName, [MarshalAs(UnmanagedType.LPUTF8Str)] string trgName);

		/// <summary>
		/// Given the names of a trigger and a table, get the handle of the trigger in this table.
		/// </summary>
		// Token: 0x06007142 RID: 28994 RVA: 0x000A3464 File Offset: 0x000A1664
		public int GetTriggerHandleFromName(string tblName, string trgName)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetTriggerHandleFromName_43(base.GetCppThis(), tblName, trgName);
		}

		// Token: 0x06007143 RID: 28995
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSQLDatabaseSchema_GetTriggerNameFromHandle_44(HandleRef pThis, int tblHandle, int trgHandle);

		/// <summary>
		/// Given the handles of a table and a trigger, get the name of the trigger.
		/// </summary>
		// Token: 0x06007144 RID: 28996 RVA: 0x000A3488 File Offset: 0x000A1688
		public string GetTriggerNameFromHandle(int tblHandle, int trgHandle)
		{
			string s = Marshal.PtrToStringAnsi(vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetTriggerNameFromHandle_44(base.GetCppThis(), tblHandle, trgHandle));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06007145 RID: 28997
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSQLDatabaseSchema_GetTriggerTypeFromHandle_45(HandleRef pThis, int tblHandle, int trgHandle);

		/// <summary>
		/// Given the handles of a table and a trigger, get the type of the trigger.
		/// </summary>
		// Token: 0x06007146 RID: 28998 RVA: 0x000A34C4 File Offset: 0x000A16C4
		public int GetTriggerTypeFromHandle(int tblHandle, int trgHandle)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetTriggerTypeFromHandle_45(base.GetCppThis(), tblHandle, trgHandle);
		}

		// Token: 0x06007147 RID: 28999
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSQLDatabaseSchema_IsA_46(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007148 RID: 29000 RVA: 0x000A34E8 File Offset: 0x000A16E8
		public override int IsA(string type)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_IsA_46(base.GetCppThis(), type);
		}

		// Token: 0x06007149 RID: 29001
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSQLDatabaseSchema_IsTypeOf_47([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600714A RID: 29002 RVA: 0x000A3508 File Offset: 0x000A1708
		public new static int IsTypeOf(string type)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_IsTypeOf_47(type);
		}

		// Token: 0x0600714B RID: 29003
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSQLDatabaseSchema_NewInstance_49(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600714C RID: 29004 RVA: 0x000A3524 File Offset: 0x000A1724
		public new vtkSQLDatabaseSchema NewInstance()
		{
			vtkSQLDatabaseSchema result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_NewInstance_49(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSQLDatabaseSchema)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600714D RID: 29005
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSQLDatabaseSchema_Reset_50(HandleRef pThis);

		/// <summary>
		/// Reset the schema to its initial, empty state.
		/// </summary>
		// Token: 0x0600714E RID: 29006 RVA: 0x000A357E File Offset: 0x000A177E
		public void Reset()
		{
			vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_Reset_50(base.GetCppThis());
		}

		// Token: 0x0600714F RID: 29007
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSQLDatabaseSchema_SafeDownCast_51(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007150 RID: 29008 RVA: 0x000A3590 File Offset: 0x000A1790
		public new static vtkSQLDatabaseSchema SafeDownCast(vtkObjectBase o)
		{
			vtkSQLDatabaseSchema vtkSQLDatabaseSchema = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_SafeDownCast_51((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSQLDatabaseSchema = (vtkSQLDatabaseSchema)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSQLDatabaseSchema.Register(null);
				}
			}
			return vtkSQLDatabaseSchema;
		}

		// Token: 0x06007151 RID: 29009
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSQLDatabaseSchema_SetName_52(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the name of the schema.
		/// </summary>
		// Token: 0x06007152 RID: 29010 RVA: 0x000A360F File Offset: 0x000A180F
		public virtual void SetName(string _arg)
		{
			vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_SetName_52(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009C3 RID: 2499
		public new const string MRFullTypeName = "Kitware.VTK.vtkSQLDatabaseSchema";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009C4 RID: 2500
		public new static readonly string MRClassNameKey = "class vtkSQLDatabaseSchema";

		/// <summary>
		/// Basic data types for database columns
		/// </summary>
		// Token: 0x02000269 RID: 617
		public enum DatabaseColumnType
		{
			/// <summary>enum member</summary>
			// Token: 0x040009C6 RID: 2502
			BIGINT = 3,
			/// <summary>enum member</summary>
			// Token: 0x040009C7 RID: 2503
			BLOB = 8,
			/// <summary>enum member</summary>
			// Token: 0x040009C8 RID: 2504
			DATE = 10,
			/// <summary>enum member</summary>
			// Token: 0x040009C9 RID: 2505
			DOUBLE = 7,
			/// <summary>enum member</summary>
			// Token: 0x040009CA RID: 2506
			INTEGER = 2,
			/// <summary>enum member</summary>
			// Token: 0x040009CB RID: 2507
			REAL = 6,
			/// <summary>enum member</summary>
			// Token: 0x040009CC RID: 2508
			SERIAL = 0,
			/// <summary>enum member</summary>
			// Token: 0x040009CD RID: 2509
			SMALLINT,
			/// <summary>enum member</summary>
			// Token: 0x040009CE RID: 2510
			TEXT = 5,
			/// <summary>enum member</summary>
			// Token: 0x040009CF RID: 2511
			TIME = 9,
			/// <summary>enum member</summary>
			// Token: 0x040009D0 RID: 2512
			TIMESTAMP = 11,
			/// <summary>enum member</summary>
			// Token: 0x040009D1 RID: 2513
			VARCHAR = 4
		}

		/// <summary>
		/// Types of indices that can be generated for database tables
		/// </summary>
		// Token: 0x0200026A RID: 618
		public enum DatabaseIndexType
		{
			/// <summary>enum member</summary>
			// Token: 0x040009D3 RID: 2515
			INDEX,
			/// <summary>enum member</summary>
			// Token: 0x040009D4 RID: 2516
			PRIMARY_KEY = 2,
			/// <summary>enum member</summary>
			// Token: 0x040009D5 RID: 2517
			UNIQUE = 1
		}

		/// <summary>
		/// Events where database triggers can be registered.
		/// </summary>
		// Token: 0x0200026B RID: 619
		public enum DatabaseTriggerType
		{
			/// <summary>enum member</summary>
			// Token: 0x040009D7 RID: 2519
			AFTER_DELETE = 5,
			/// <summary>enum member</summary>
			// Token: 0x040009D8 RID: 2520
			AFTER_INSERT = 1,
			/// <summary>enum member</summary>
			// Token: 0x040009D9 RID: 2521
			AFTER_UPDATE = 3,
			/// <summary>enum member</summary>
			// Token: 0x040009DA RID: 2522
			BEFORE_DELETE,
			/// <summary>enum member</summary>
			// Token: 0x040009DB RID: 2523
			BEFORE_INSERT = 0,
			/// <summary>enum member</summary>
			// Token: 0x040009DC RID: 2524
			BEFORE_UPDATE = 2
		}

		/// <summary>
		/// Set/Get the name of the schema.
		/// </summary>
		// Token: 0x0200026C RID: 620
		public enum VarargTokens
		{
			/// <summary>enum member</summary>
			// Token: 0x040009DE RID: 2526
			COLUMN_TOKEN = 58,
			/// <summary>enum member</summary>
			// Token: 0x040009DF RID: 2527
			END_INDEX_TOKEN = 75,
			/// <summary>enum member</summary>
			// Token: 0x040009E0 RID: 2528
			END_TABLE_TOKEN = 99,
			/// <summary>enum member</summary>
			// Token: 0x040009E1 RID: 2529
			INDEX_COLUMN_TOKEN = 65,
			/// <summary>enum member</summary>
			// Token: 0x040009E2 RID: 2530
			INDEX_TOKEN = 63,
			/// <summary>enum member</summary>
			// Token: 0x040009E3 RID: 2531
			OPTION_TOKEN = 86,
			/// <summary>enum member</summary>
			// Token: 0x040009E4 RID: 2532
			TRIGGER_TOKEN = 81
		}
	}
}
