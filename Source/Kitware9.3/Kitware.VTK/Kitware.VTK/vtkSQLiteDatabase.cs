using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSQLiteDatabase
	/// </summary>
	/// <remarks>
	///    maintain a connection to an SQLite database
	///
	///
	///
	/// SQLite (http://www.sqlite.org) is a public-domain SQL database
	/// written in C++.  It's small, fast, and can be easily embedded
	/// inside other applications.  Its databases are stored in files.
	///
	/// This class provides a VTK interface to SQLite.  You do not need to
	/// download any external libraries: we include a copy of SQLite 3.3.16
	/// in VTK/Utilities/vtksqlite.
	///
	/// If you want to open a database that stays in memory and never gets
	/// written to disk, pass in the URL &lt;tt&gt;sqlite://:memory:&lt;/tt&gt;; otherwise,
	/// specify the file path by passing the URL &lt;tt&gt;sqlite://\&lt;file_path\&gt;&lt;/tt&gt;.
	///
	/// @par Thanks:
	/// Thanks to Andrew Wilson and Philippe Pebay from Sandia National
	/// Laboratories for implementing this class.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkSQLiteQuery
	/// </seealso>
	// Token: 0x0200026E RID: 622
	public class vtkSQLiteDatabase : vtkSQLDatabase
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600717B RID: 29051 RVA: 0x000A396B File Offset: 0x000A1B6B
		static vtkSQLiteDatabase()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSQLiteDatabase.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSQLiteDatabase"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600717C RID: 29052 RVA: 0x000A3993 File Offset: 0x000A1B93
		public vtkSQLiteDatabase(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600717D RID: 29053
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSQLiteDatabase_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600717E RID: 29054 RVA: 0x000A39A4 File Offset: 0x000A1BA4
		public new static vtkSQLiteDatabase New()
		{
			vtkSQLiteDatabase result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSQLiteDatabase.vtkSQLiteDatabase_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSQLiteDatabase)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600717F RID: 29055 RVA: 0x000A39F8 File Offset: 0x000A1BF8
		public vtkSQLiteDatabase() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSQLiteDatabase.vtkSQLiteDatabase_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06007180 RID: 29056 RVA: 0x000A3A3C File Offset: 0x000A1C3C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06007181 RID: 29057
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSQLiteDatabase_Close_01(HandleRef pThis);

		/// <summary>
		/// Close the connection to the database.
		/// </summary>
		// Token: 0x06007182 RID: 29058 RVA: 0x000A3A47 File Offset: 0x000A1C47
		public override void Close()
		{
			vtkSQLiteDatabase.vtkSQLiteDatabase_Close_01(base.GetCppThis());
		}

		// Token: 0x06007183 RID: 29059
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkSQLiteDatabase_GetColumnSpecification_02(HandleRef pThis, HandleRef schema, int tblHandle, int colHandle);

		/// <summary>
		/// Return the SQL string with the syntax to create a column inside a
		/// "CREATE TABLE" SQL statement.
		/// NB: this method implements the SQLite-specific syntax:
		/// <code>
		/// &lt;column name&gt; &lt;column type&gt; &lt;column attributes&gt;
		/// </code>
		/// </summary>
		// Token: 0x06007184 RID: 29060 RVA: 0x000A3A58 File Offset: 0x000A1C58
		public override string GetColumnSpecification(vtkSQLDatabaseSchema schema, int tblHandle, int colHandle)
		{
			return vtkSQLiteDatabase.vtkSQLiteDatabase_GetColumnSpecification_02(base.GetCppThis(), (schema == null) ? default(HandleRef) : schema.GetCppThis(), tblHandle, colHandle);
		}

		// Token: 0x06007185 RID: 29061
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSQLiteDatabase_GetDatabaseFileName_03(HandleRef pThis);

		/// <summary>
		/// String representing the database filename.
		/// </summary>
		// Token: 0x06007186 RID: 29062 RVA: 0x000A3A90 File Offset: 0x000A1C90
		public virtual string GetDatabaseFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkSQLiteDatabase.vtkSQLiteDatabase_GetDatabaseFileName_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06007187 RID: 29063
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSQLiteDatabase_GetDatabaseType_04(HandleRef pThis);

		/// <summary>
		/// String representing database type (e.g. "sqlite").
		/// </summary>
		// Token: 0x06007188 RID: 29064 RVA: 0x000A3ACC File Offset: 0x000A1CCC
		public override string GetDatabaseType()
		{
			string s = Marshal.PtrToStringAnsi(vtkSQLiteDatabase.vtkSQLiteDatabase_GetDatabaseType_04(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06007189 RID: 29065
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSQLiteDatabase_GetLastErrorText_05(HandleRef pThis);

		/// <summary>
		/// Get the last error text from the database
		/// </summary>
		// Token: 0x0600718A RID: 29066 RVA: 0x000A3B08 File Offset: 0x000A1D08
		public override string GetLastErrorText()
		{
			string s = Marshal.PtrToStringAnsi(vtkSQLiteDatabase.vtkSQLiteDatabase_GetLastErrorText_05(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600718B RID: 29067
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSQLiteDatabase_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600718C RID: 29068 RVA: 0x000A3B44 File Offset: 0x000A1D44
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSQLiteDatabase.vtkSQLiteDatabase_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0600718D RID: 29069
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSQLiteDatabase_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600718E RID: 29070 RVA: 0x000A3B64 File Offset: 0x000A1D64
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSQLiteDatabase.vtkSQLiteDatabase_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0600718F RID: 29071
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSQLiteDatabase_GetQueryInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return an empty query on this database.
		/// </summary>
		// Token: 0x06007190 RID: 29072 RVA: 0x000A3B80 File Offset: 0x000A1D80
		public override vtkSQLQuery GetQueryInstance()
		{
			vtkSQLQuery vtkSQLQuery = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSQLiteDatabase.vtkSQLiteDatabase_GetQueryInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06007191 RID: 29073
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSQLiteDatabase_GetRecord_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string table, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the list of fields for a particular table
		/// </summary>
		// Token: 0x06007192 RID: 29074 RVA: 0x000A3BF0 File Offset: 0x000A1DF0
		public override vtkStringArray GetRecord(string table)
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSQLiteDatabase.vtkSQLiteDatabase_GetRecord_09(base.GetCppThis(), table, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06007193 RID: 29075
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSQLiteDatabase_GetTables_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the list of tables from the database
		/// </summary>
		// Token: 0x06007194 RID: 29076 RVA: 0x000A3C60 File Offset: 0x000A1E60
		public override vtkStringArray GetTables()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSQLiteDatabase.vtkSQLiteDatabase_GetTables_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06007195 RID: 29077
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkSQLiteDatabase_GetURL_11(HandleRef pThis);

		/// <summary>
		/// Get the URL of the database.
		/// </summary>
		// Token: 0x06007196 RID: 29078 RVA: 0x000A3CD0 File Offset: 0x000A1ED0
		public override string GetURL()
		{
			return vtkSQLiteDatabase.vtkSQLiteDatabase_GetURL_11(base.GetCppThis());
		}

		// Token: 0x06007197 RID: 29079
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLiteDatabase_HasError_12(HandleRef pThis);

		/// <summary>
		/// Did the last operation generate an error
		/// </summary>
		// Token: 0x06007198 RID: 29080 RVA: 0x000A3CF0 File Offset: 0x000A1EF0
		public override bool HasError()
		{
			return vtkSQLiteDatabase.vtkSQLiteDatabase_HasError_12(base.GetCppThis()) != 0;
		}

		// Token: 0x06007199 RID: 29081
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSQLiteDatabase_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600719A RID: 29082 RVA: 0x000A3D18 File Offset: 0x000A1F18
		public override int IsA(string type)
		{
			return vtkSQLiteDatabase.vtkSQLiteDatabase_IsA_13(base.GetCppThis(), type);
		}

		// Token: 0x0600719B RID: 29083
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLiteDatabase_IsOpen_14(HandleRef pThis);

		/// <summary>
		/// Return whether the database has an open connection
		/// </summary>
		// Token: 0x0600719C RID: 29084 RVA: 0x000A3D38 File Offset: 0x000A1F38
		public override bool IsOpen()
		{
			return vtkSQLiteDatabase.vtkSQLiteDatabase_IsOpen_14(base.GetCppThis()) != 0;
		}

		// Token: 0x0600719D RID: 29085
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLiteDatabase_IsSupported_15(HandleRef pThis, int feature);

		/// <summary>
		/// Return whether a feature is supported by the database.
		/// </summary>
		// Token: 0x0600719E RID: 29086 RVA: 0x000A3D60 File Offset: 0x000A1F60
		public override bool IsSupported(int feature)
		{
			return vtkSQLiteDatabase.vtkSQLiteDatabase_IsSupported_15(base.GetCppThis(), feature) != 0;
		}

		// Token: 0x0600719F RID: 29087
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSQLiteDatabase_IsTypeOf_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060071A0 RID: 29088 RVA: 0x000A3D88 File Offset: 0x000A1F88
		public new static int IsTypeOf(string type)
		{
			return vtkSQLiteDatabase.vtkSQLiteDatabase_IsTypeOf_16(type);
		}

		// Token: 0x060071A1 RID: 29089
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSQLiteDatabase_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060071A2 RID: 29090 RVA: 0x000A3DA4 File Offset: 0x000A1FA4
		public new vtkSQLiteDatabase NewInstance()
		{
			vtkSQLiteDatabase result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSQLiteDatabase.vtkSQLiteDatabase_NewInstance_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSQLiteDatabase)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060071A3 RID: 29091
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLiteDatabase_Open_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string password);

		/// <summary>
		/// Open a new connection to the database.  You need to set the
		/// filename before calling this function.  Returns true if the
		/// database was opened successfully; false otherwise.
		/// - USE_EXISTING (default) - Fail if the file does not exist.
		/// - USE_EXISTING_OR_CREATE - Create a new file if necessary.
		/// - CREATE_OR_CLEAR - Create new or clear existing file.
		/// - CREATE - Create new, fail if file exists.
		/// </summary>
		// Token: 0x060071A4 RID: 29092 RVA: 0x000A3E00 File Offset: 0x000A2000
		public override bool Open(string password)
		{
			return vtkSQLiteDatabase.vtkSQLiteDatabase_Open_19(base.GetCppThis(), password) != 0;
		}

		// Token: 0x060071A5 RID: 29093
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLiteDatabase_Open_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string password, int mode);

		/// <summary>
		/// Open a new connection to the database.  You need to set the
		/// filename before calling this function.  Returns true if the
		/// database was opened successfully; false otherwise.
		/// - USE_EXISTING (default) - Fail if the file does not exist.
		/// - USE_EXISTING_OR_CREATE - Create a new file if necessary.
		/// - CREATE_OR_CLEAR - Create new or clear existing file.
		/// - CREATE - Create new, fail if file exists.
		/// </summary>
		// Token: 0x060071A6 RID: 29094 RVA: 0x000A3E28 File Offset: 0x000A2028
		public bool Open(string password, int mode)
		{
			return vtkSQLiteDatabase.vtkSQLiteDatabase_Open_20(base.GetCppThis(), password, mode) != 0;
		}

		// Token: 0x060071A7 RID: 29095
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSQLiteDatabase_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060071A8 RID: 29096 RVA: 0x000A3E50 File Offset: 0x000A2050
		public new static vtkSQLiteDatabase SafeDownCast(vtkObjectBase o)
		{
			vtkSQLiteDatabase vtkSQLiteDatabase = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSQLiteDatabase.vtkSQLiteDatabase_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSQLiteDatabase = (vtkSQLiteDatabase)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSQLiteDatabase.Register(null);
				}
			}
			return vtkSQLiteDatabase;
		}

		// Token: 0x060071A9 RID: 29097
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSQLiteDatabase_SetDatabaseFileName_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// String representing the database filename.
		/// </summary>
		// Token: 0x060071AA RID: 29098 RVA: 0x000A3ECF File Offset: 0x000A20CF
		public virtual void SetDatabaseFileName(string _arg)
		{
			vtkSQLiteDatabase.vtkSQLiteDatabase_SetDatabaseFileName_22(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009E7 RID: 2535
		public new const string MRFullTypeName = "Kitware.VTK.vtkSQLiteDatabase";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009E8 RID: 2536
		public new static readonly string MRClassNameKey = "class vtkSQLiteDatabase";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0200026F RID: 623
		public enum CREATE_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x040009EA RID: 2538
			CREATE = 3,
			/// <summary>enum member</summary>
			// Token: 0x040009EB RID: 2539
			CREATE_OR_CLEAR = 2,
			/// <summary>enum member</summary>
			// Token: 0x040009EC RID: 2540
			USE_EXISTING = 0,
			/// <summary>enum member</summary>
			// Token: 0x040009ED RID: 2541
			USE_EXISTING_OR_CREATE
		}
	}
}
