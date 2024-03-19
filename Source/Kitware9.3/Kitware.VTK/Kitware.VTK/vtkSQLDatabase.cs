using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSQLDatabase
	/// </summary>
	/// <remarks>
	///    maintain a connection to an sql database
	///
	///
	/// Abstract base class for all SQL database connection classes.
	/// Manages a connection to the database, and is responsible for creating
	/// instances of the associated vtkSQLQuery objects associated with this
	/// class in order to perform execute queries on the database.
	/// To allow connections to a new type of database, create both a subclass
	/// of this class and vtkSQLQuery, and implement the required functions:
	///
	/// Open() - open the database connection, if possible.
	/// Close() - close the connection.
	/// GetQueryInstance() - create and return an instance of the vtkSQLQuery
	///                      subclass associated with the database type.
	///
	/// The subclass should also provide API to set connection parameters.
	///
	/// This class also provides the function EffectSchema to transform a
	/// database schema into a SQL database.
	///
	/// @par Thanks:
	/// Thanks to Andrew Wilson from Sandia National Laboratories for his work
	/// on the database classes and for the SQLite example. Thanks to David Thompson
	/// and Philippe Pebay from Sandia National Laboratories for implementing
	/// this class.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkSQLQuery
	/// vtkSQLDatabaseSchema
	/// </seealso>
	// Token: 0x02000266 RID: 614
	public abstract class vtkSQLDatabase : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060070AA RID: 28842 RVA: 0x000A2653 File Offset: 0x000A0853
		static vtkSQLDatabase()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSQLDatabase.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSQLDatabase"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060070AB RID: 28843 RVA: 0x000A267B File Offset: 0x000A087B
		public vtkSQLDatabase(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060070AC RID: 28844 RVA: 0x000A2689 File Offset: 0x000A0889
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060070AD RID: 28845
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSQLDatabase_Close_01(HandleRef pThis);

		/// <summary>
		/// Close the connection to the database.
		/// </summary>
		// Token: 0x060070AE RID: 28846 RVA: 0x000A2694 File Offset: 0x000A0894
		public virtual void Close()
		{
			vtkSQLDatabase.vtkSQLDatabase_Close_01(base.GetCppThis());
		}

		// Token: 0x060070AF RID: 28847
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSQLDatabase_CreateFromURL_02([MarshalAs(UnmanagedType.LPUTF8Str)] string URL, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create a the proper subclass given a URL.
		/// The URL format for SQL databases is a true URL of the form:
		/// 'protocol://'[[username[':'password]'@']hostname[':'port]]'/'[dbname] .
		/// </summary>
		// Token: 0x060070B0 RID: 28848 RVA: 0x000A26A4 File Offset: 0x000A08A4
		public static vtkSQLDatabase CreateFromURL(string URL)
		{
			vtkSQLDatabase vtkSQLDatabase = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSQLDatabase.vtkSQLDatabase_CreateFromURL_02(URL, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060070B1 RID: 28849
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSQLDatabase_DATABASE_03(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Stores the database class pointer as an information key. This is currently
		/// used to store database pointers as part of 'data on demand' data objects.
		/// For example: The application may have a table/tree/whatever of documents,
		/// the data structure is storing the meta-data but not the full text. Further
		/// down the pipeline algorithms or views may want to retrieve additional
		/// information (full text)for specific documents.
		/// </summary>
		// Token: 0x060070B2 RID: 28850 RVA: 0x000A2710 File Offset: 0x000A0910
		public static vtkInformationObjectBaseKey DATABASE()
		{
			vtkInformationObjectBaseKey vtkInformationObjectBaseKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSQLDatabase.vtkSQLDatabase_DATABASE_03(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationObjectBaseKey = (vtkInformationObjectBaseKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationObjectBaseKey.Register(null);
				}
			}
			return vtkInformationObjectBaseKey;
		}

		// Token: 0x060070B3 RID: 28851
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLDatabase_EffectSchema_04(HandleRef pThis, HandleRef arg0, byte dropIfExists);

		/// <summary>
		/// Effect a database schema.
		/// </summary>
		// Token: 0x060070B4 RID: 28852 RVA: 0x000A277C File Offset: 0x000A097C
		public virtual bool EffectSchema(vtkSQLDatabaseSchema arg0, bool dropIfExists)
		{
			return vtkSQLDatabase.vtkSQLDatabase_EffectSchema_04(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), dropIfExists ? (byte)1 : (byte)0) != 0;
		}

		// Token: 0x060070B5 RID: 28853
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkSQLDatabase_GetColumnSpecification_05(HandleRef pThis, HandleRef schema, int tblHandle, int colHandle);

		/// <summary>
		/// Return the SQL string with the syntax to create a column inside a
		/// "CREATE TABLE" SQL statement.
		/// NB: this method implements the following minimally-portable syntax:
		/// <code>
		/// &lt;column name&gt; &lt;column type&gt; &lt;column attributes&gt;
		/// </code>
		/// It must be overwritten for those SQL backends which have a different
		/// syntax such as, e.g., MySQL.
		/// </summary>
		// Token: 0x060070B6 RID: 28854 RVA: 0x000A27C0 File Offset: 0x000A09C0
		public virtual string GetColumnSpecification(vtkSQLDatabaseSchema schema, int tblHandle, int colHandle)
		{
			return vtkSQLDatabase.vtkSQLDatabase_GetColumnSpecification_05(base.GetCppThis(), (schema == null) ? default(HandleRef) : schema.GetCppThis(), tblHandle, colHandle);
		}

		// Token: 0x060070B7 RID: 28855
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSQLDatabase_GetDatabaseType_06(HandleRef pThis);

		/// <summary>
		/// Get the type of the database (e.g. mysql, psql,..).
		/// </summary>
		// Token: 0x060070B8 RID: 28856 RVA: 0x000A27F8 File Offset: 0x000A09F8
		public virtual string GetDatabaseType()
		{
			string s = Marshal.PtrToStringAnsi(vtkSQLDatabase.vtkSQLDatabase_GetDatabaseType_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060070B9 RID: 28857
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkSQLDatabase_GetIndexSpecification_07(HandleRef pThis, HandleRef schema, int tblHandle, int idxHandle, ref byte skipped);

		/// <summary>
		/// Return the SQL string with the syntax to create an index inside a
		/// "CREATE TABLE" SQL statement.
		/// NB1: this method implements the following minimally-portable syntax:
		/// <code>
		/// &lt;index type&gt; [&lt;index name&gt;] (&lt;column name 1&gt;,... )
		/// </code>
		/// It must be overwritten for those SQL backends which have a different
		/// syntax such as, e.g., MySQL.
		/// NB2: this method does not assume that INDEX creation is supported
		/// within a CREATE TABLE statement. Therefore, should such an INDEX arise
		/// in the schema, a CREATE INDEX statement is returned and skipped is
		/// set to true. Otherwise, skipped will always be returned false.
		/// </summary>
		// Token: 0x060070BA RID: 28858 RVA: 0x000A2834 File Offset: 0x000A0A34
		public virtual string GetIndexSpecification(vtkSQLDatabaseSchema schema, int tblHandle, int idxHandle, ref byte skipped)
		{
			return vtkSQLDatabase.vtkSQLDatabase_GetIndexSpecification_07(base.GetCppThis(), (schema == null) ? default(HandleRef) : schema.GetCppThis(), tblHandle, idxHandle, ref skipped);
		}

		// Token: 0x060070BB RID: 28859
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSQLDatabase_GetLastErrorText_08(HandleRef pThis);

		/// <summary>
		/// Get the last error text from the database
		/// I'm using const so that people do NOT
		/// use the standard vtkGetStringMacro in their
		/// implementation, because 99% of the time that
		/// will not be the correct thing to do...
		/// </summary>
		// Token: 0x060070BC RID: 28860 RVA: 0x000A286C File Offset: 0x000A0A6C
		public virtual string GetLastErrorText()
		{
			string s = Marshal.PtrToStringAnsi(vtkSQLDatabase.vtkSQLDatabase_GetLastErrorText_08(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060070BD RID: 28861
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSQLDatabase_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060070BE RID: 28862 RVA: 0x000A28A8 File Offset: 0x000A0AA8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSQLDatabase.vtkSQLDatabase_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x060070BF RID: 28863
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSQLDatabase_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060070C0 RID: 28864 RVA: 0x000A28C8 File Offset: 0x000A0AC8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSQLDatabase.vtkSQLDatabase_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x060070C1 RID: 28865
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSQLDatabase_GetQueryInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return an empty query on this database.
		/// </summary>
		// Token: 0x060070C2 RID: 28866 RVA: 0x000A28E4 File Offset: 0x000A0AE4
		public virtual vtkSQLQuery GetQueryInstance()
		{
			vtkSQLQuery vtkSQLQuery = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSQLDatabase.vtkSQLDatabase_GetQueryInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060070C3 RID: 28867
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSQLDatabase_GetRecord_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string table, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the list of fields for a particular table.
		/// </summary>
		// Token: 0x060070C4 RID: 28868 RVA: 0x000A2954 File Offset: 0x000A0B54
		public virtual vtkStringArray GetRecord(string table)
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSQLDatabase.vtkSQLDatabase_GetRecord_12(base.GetCppThis(), table, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060070C5 RID: 28869
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkSQLDatabase_GetTablePreamble_13(HandleRef pThis, byte arg0);

		/// <summary>
		/// Return the SQL string with the syntax of the preamble following a
		/// "CREATE TABLE" SQL statement.
		/// NB: by default, this method returns an empty string.
		/// It must be overwritten for those SQL backends which allow such
		/// preambles such as, e.g., MySQL.
		/// </summary>
		// Token: 0x060070C6 RID: 28870 RVA: 0x000A29C4 File Offset: 0x000A0BC4
		public virtual string GetTablePreamble(bool arg0)
		{
			return vtkSQLDatabase.vtkSQLDatabase_GetTablePreamble_13(base.GetCppThis(), arg0 ? (byte)1 : (byte)0);
		}

		// Token: 0x060070C7 RID: 28871
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSQLDatabase_GetTables_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the list of tables from the database.
		/// </summary>
		// Token: 0x060070C8 RID: 28872 RVA: 0x000A29EC File Offset: 0x000A0BEC
		public virtual vtkStringArray GetTables()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSQLDatabase.vtkSQLDatabase_GetTables_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060070C9 RID: 28873
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkSQLDatabase_GetTriggerSpecification_15(HandleRef pThis, HandleRef schema, int tblHandle, int trgHandle);

		/// <summary>
		/// Return the SQL string with the syntax to create a trigger using a
		/// "CREATE TRIGGER" SQL statement.
		/// NB1: support is contingent on VTK_FEATURE_TRIGGERS being recognized as
		/// a supported feature. Not all backends (e.g., SQLite) support it.
		/// NB2: this method implements the following minimally-portable syntax:
		/// <code>
		/// &lt;trigger name&gt; {BEFORE | AFTER} &lt;event&gt; ON &lt;table name&gt; FOR EACH ROW &lt;trigger action&gt;
		/// </code>
		/// It must be overwritten for those SQL backends which have a different
		/// syntax such as, e.g., PostgreSQL.
		/// </summary>
		// Token: 0x060070CA RID: 28874 RVA: 0x000A2A5C File Offset: 0x000A0C5C
		public virtual string GetTriggerSpecification(vtkSQLDatabaseSchema schema, int tblHandle, int trgHandle)
		{
			return vtkSQLDatabase.vtkSQLDatabase_GetTriggerSpecification_15(base.GetCppThis(), (schema == null) ? default(HandleRef) : schema.GetCppThis(), tblHandle, trgHandle);
		}

		// Token: 0x060070CB RID: 28875
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkSQLDatabase_GetURL_16(HandleRef pThis);

		/// <summary>
		/// Get the URL of the database.
		/// </summary>
		// Token: 0x060070CC RID: 28876 RVA: 0x000A2A94 File Offset: 0x000A0C94
		public virtual string GetURL()
		{
			return vtkSQLDatabase.vtkSQLDatabase_GetURL_16(base.GetCppThis());
		}

		// Token: 0x060070CD RID: 28877
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLDatabase_HasError_17(HandleRef pThis);

		/// <summary>
		/// Did the last operation generate an error
		/// </summary>
		// Token: 0x060070CE RID: 28878 RVA: 0x000A2AB4 File Offset: 0x000A0CB4
		public virtual bool HasError()
		{
			return vtkSQLDatabase.vtkSQLDatabase_HasError_17(base.GetCppThis()) != 0;
		}

		// Token: 0x060070CF RID: 28879
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSQLDatabase_IsA_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060070D0 RID: 28880 RVA: 0x000A2ADC File Offset: 0x000A0CDC
		public override int IsA(string type)
		{
			return vtkSQLDatabase.vtkSQLDatabase_IsA_18(base.GetCppThis(), type);
		}

		// Token: 0x060070D1 RID: 28881
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLDatabase_IsOpen_19(HandleRef pThis);

		/// <summary>
		/// Return whether the database has an open connection.
		/// </summary>
		// Token: 0x060070D2 RID: 28882 RVA: 0x000A2AFC File Offset: 0x000A0CFC
		public virtual bool IsOpen()
		{
			return vtkSQLDatabase.vtkSQLDatabase_IsOpen_19(base.GetCppThis()) != 0;
		}

		// Token: 0x060070D3 RID: 28883
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLDatabase_IsSupported_20(HandleRef pThis, int arg0);

		/// <summary>
		/// Return whether a feature is supported by the database.
		/// </summary>
		// Token: 0x060070D4 RID: 28884 RVA: 0x000A2B24 File Offset: 0x000A0D24
		public virtual bool IsSupported(int arg0)
		{
			return vtkSQLDatabase.vtkSQLDatabase_IsSupported_20(base.GetCppThis(), arg0) != 0;
		}

		// Token: 0x060070D5 RID: 28885
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSQLDatabase_IsTypeOf_21([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060070D6 RID: 28886 RVA: 0x000A2B4C File Offset: 0x000A0D4C
		public new static int IsTypeOf(string type)
		{
			return vtkSQLDatabase.vtkSQLDatabase_IsTypeOf_21(type);
		}

		// Token: 0x060070D7 RID: 28887
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSQLDatabase_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060070D8 RID: 28888 RVA: 0x000A2B68 File Offset: 0x000A0D68
		public new vtkSQLDatabase NewInstance()
		{
			vtkSQLDatabase result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSQLDatabase.vtkSQLDatabase_NewInstance_22(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSQLDatabase)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060070D9 RID: 28889
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLDatabase_Open_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string password);

		/// <summary>
		/// Open a new connection to the database.
		/// You need to set up any database parameters before calling this function.
		/// For database connections that do not require a password, pass an empty string.
		/// Returns true is the database was opened successfully, and false otherwise.
		/// </summary>
		// Token: 0x060070DA RID: 28890 RVA: 0x000A2BC4 File Offset: 0x000A0DC4
		public virtual bool Open(string password)
		{
			return vtkSQLDatabase.vtkSQLDatabase_Open_23(base.GetCppThis(), password) != 0;
		}

		// Token: 0x060070DB RID: 28891
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSQLDatabase_RegisterCreateFromURLCallback_24(vtkSQLDatabase.CreateFunction callback);

		/// <summary>
		/// Provides mechanism to register/unregister additional callbacks to create
		/// concrete subclasses of vtkSQLDatabase to handle different protocols.
		/// The registered callbacks are tried in the order they are registered.
		/// </summary>
		// Token: 0x060070DC RID: 28892 RVA: 0x000A2BEB File Offset: 0x000A0DEB
		public static void RegisterCreateFromURLCallback(vtkSQLDatabase.CreateFunction callback)
		{
			vtkSQLDatabase.vtkSQLDatabase_RegisterCreateFromURLCallback_24(callback);
		}

		// Token: 0x060070DD RID: 28893
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSQLDatabase_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060070DE RID: 28894 RVA: 0x000A2BF8 File Offset: 0x000A0DF8
		public new static vtkSQLDatabase SafeDownCast(vtkObjectBase o)
		{
			vtkSQLDatabase vtkSQLDatabase = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSQLDatabase.vtkSQLDatabase_SafeDownCast_25((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060070DF RID: 28895
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSQLDatabase_UnRegisterAllCreateFromURLCallbacks_26();

		/// <summary>
		/// Provides mechanism to register/unregister additional callbacks to create
		/// concrete subclasses of vtkSQLDatabase to handle different protocols.
		/// The registered callbacks are tried in the order they are registered.
		/// </summary>
		// Token: 0x060070E0 RID: 28896 RVA: 0x000A2C77 File Offset: 0x000A0E77
		public static void UnRegisterAllCreateFromURLCallbacks()
		{
			vtkSQLDatabase.vtkSQLDatabase_UnRegisterAllCreateFromURLCallbacks_26();
		}

		// Token: 0x060070E1 RID: 28897
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSQLDatabase_UnRegisterCreateFromURLCallback_27(vtkSQLDatabase.CreateFunction callback);

		/// <summary>
		/// Provides mechanism to register/unregister additional callbacks to create
		/// concrete subclasses of vtkSQLDatabase to handle different protocols.
		/// The registered callbacks are tried in the order they are registered.
		/// </summary>
		// Token: 0x060070E2 RID: 28898 RVA: 0x000A2C80 File Offset: 0x000A0E80
		public static void UnRegisterCreateFromURLCallback(vtkSQLDatabase.CreateFunction callback)
		{
			vtkSQLDatabase.vtkSQLDatabase_UnRegisterCreateFromURLCallback_27(callback);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009C1 RID: 2497
		public new const string MRFullTypeName = "Kitware.VTK.vtkSQLDatabase";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009C2 RID: 2498
		public new static readonly string MRClassNameKey = "class vtkSQLDatabase";

		/// <summary>
		/// Type for CreateFromURL callback.
		/// </summary>
		// Token: 0x02000267 RID: 615
		// (Invoke) Token: 0x060070E4 RID: 28900
		public delegate IntPtr CreateFunction([MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);
	}
}
