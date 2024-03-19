using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTableToDatabaseWriter
	/// in a SQL database.
	///
	/// vtkTableToDatabaseWriter abstract parent class that reads a vtkTable and
	/// inserts it into an SQL database.
	/// </summary>
	// Token: 0x02000273 RID: 627
	public abstract class vtkTableToDatabaseWriter : vtkWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06007244 RID: 29252 RVA: 0x000A4DAF File Offset: 0x000A2FAF
		static vtkTableToDatabaseWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTableToDatabaseWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTableToDatabaseWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06007245 RID: 29253 RVA: 0x000A4DD7 File Offset: 0x000A2FD7
		public vtkTableToDatabaseWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06007246 RID: 29254 RVA: 0x000A4DE5 File Offset: 0x000A2FE5
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06007247 RID: 29255
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableToDatabaseWriter_GetDatabase_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Check if the currently specified table name exists in the database.
		/// </summary>
		// Token: 0x06007248 RID: 29256 RVA: 0x000A4DF0 File Offset: 0x000A2FF0
		public vtkSQLDatabase GetDatabase()
		{
			vtkSQLDatabase vtkSQLDatabase = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTableToDatabaseWriter.vtkTableToDatabaseWriter_GetDatabase_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06007249 RID: 29257
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableToDatabaseWriter_GetInput_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input to this writer.
		/// </summary>
		// Token: 0x0600724A RID: 29258 RVA: 0x000A4E60 File Offset: 0x000A3060
		public new vtkTable GetInput()
		{
			vtkTable vtkTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTableToDatabaseWriter.vtkTableToDatabaseWriter_GetInput_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600724B RID: 29259
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableToDatabaseWriter_GetInput_03(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input to this writer.
		/// </summary>
		// Token: 0x0600724C RID: 29260 RVA: 0x000A4ED0 File Offset: 0x000A30D0
		public new vtkTable GetInput(int port)
		{
			vtkTable vtkTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTableToDatabaseWriter.vtkTableToDatabaseWriter_GetInput_03(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600724D RID: 29261
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTableToDatabaseWriter_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600724E RID: 29262 RVA: 0x000A4F40 File Offset: 0x000A3140
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTableToDatabaseWriter.vtkTableToDatabaseWriter_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0600724F RID: 29263
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTableToDatabaseWriter_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007250 RID: 29264 RVA: 0x000A4F60 File Offset: 0x000A3160
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTableToDatabaseWriter.vtkTableToDatabaseWriter_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06007251 RID: 29265
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableToDatabaseWriter_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007252 RID: 29266 RVA: 0x000A4F7C File Offset: 0x000A317C
		public override int IsA(string type)
		{
			return vtkTableToDatabaseWriter.vtkTableToDatabaseWriter_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06007253 RID: 29267
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableToDatabaseWriter_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007254 RID: 29268 RVA: 0x000A4F9C File Offset: 0x000A319C
		public new static int IsTypeOf(string type)
		{
			return vtkTableToDatabaseWriter.vtkTableToDatabaseWriter_IsTypeOf_07(type);
		}

		// Token: 0x06007255 RID: 29269
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableToDatabaseWriter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007256 RID: 29270 RVA: 0x000A4FB8 File Offset: 0x000A31B8
		public new vtkTableToDatabaseWriter NewInstance()
		{
			vtkTableToDatabaseWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTableToDatabaseWriter.vtkTableToDatabaseWriter_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTableToDatabaseWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06007257 RID: 29271
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableToDatabaseWriter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007258 RID: 29272 RVA: 0x000A5014 File Offset: 0x000A3214
		public new static vtkTableToDatabaseWriter SafeDownCast(vtkObjectBase o)
		{
			vtkTableToDatabaseWriter vtkTableToDatabaseWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTableToDatabaseWriter.vtkTableToDatabaseWriter_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTableToDatabaseWriter = (vtkTableToDatabaseWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTableToDatabaseWriter.Register(null);
				}
			}
			return vtkTableToDatabaseWriter;
		}

		// Token: 0x06007259 RID: 29273
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTableToDatabaseWriter_SetDatabase_10(HandleRef pThis, HandleRef db);

		/// <summary>
		/// Set the database.  Must already be open.
		/// </summary>
		// Token: 0x0600725A RID: 29274 RVA: 0x000A5094 File Offset: 0x000A3294
		public bool SetDatabase(vtkSQLDatabase db)
		{
			return vtkTableToDatabaseWriter.vtkTableToDatabaseWriter_SetDatabase_10(base.GetCppThis(), (db == null) ? default(HandleRef) : db.GetCppThis()) != 0;
		}

		// Token: 0x0600725B RID: 29275
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTableToDatabaseWriter_SetTableName_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Set the name of the new SQL table that you'd this writer to create.
		/// Returns false if the specified table already exists in the database.
		/// </summary>
		// Token: 0x0600725C RID: 29276 RVA: 0x000A50D0 File Offset: 0x000A32D0
		public bool SetTableName(string name)
		{
			return vtkTableToDatabaseWriter.vtkTableToDatabaseWriter_SetTableName_11(base.GetCppThis(), name) != 0;
		}

		// Token: 0x0600725D RID: 29277
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTableToDatabaseWriter_TableNameIsNew_12(HandleRef pThis);

		/// <summary>
		/// Check if the currently specified table name exists in the database.
		/// </summary>
		// Token: 0x0600725E RID: 29278 RVA: 0x000A50F8 File Offset: 0x000A32F8
		public bool TableNameIsNew()
		{
			return vtkTableToDatabaseWriter.vtkTableToDatabaseWriter_TableNameIsNew_12(base.GetCppThis()) != 0;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009F4 RID: 2548
		public new const string MRFullTypeName = "Kitware.VTK.vtkTableToDatabaseWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009F5 RID: 2549
		public new static readonly string MRClassNameKey = "class vtkTableToDatabaseWriter";
	}
}
