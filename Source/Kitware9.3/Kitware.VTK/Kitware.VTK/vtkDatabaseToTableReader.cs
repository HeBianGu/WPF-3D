using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDatabaseToTableReader
	/// </summary>
	/// <remarks>
	///    Read an SQL table as a vtkTable
	///
	/// vtkDatabaseToTableReader reads a table from an SQL database, outputting
	/// it as a vtkTable.
	/// </remarks>
	// Token: 0x02000263 RID: 611
	public abstract class vtkDatabaseToTableReader : vtkTableAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600704E RID: 28750 RVA: 0x000A1CCF File Offset: 0x0009FECF
		static vtkDatabaseToTableReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDatabaseToTableReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDatabaseToTableReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600704F RID: 28751 RVA: 0x000A1CF7 File Offset: 0x0009FEF7
		public vtkDatabaseToTableReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06007050 RID: 28752 RVA: 0x000A1D05 File Offset: 0x0009FF05
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06007051 RID: 28753
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDatabaseToTableReader_CheckIfTableExists_01(HandleRef pThis);

		/// <summary>
		/// Check if the currently specified table name exists in the database.
		/// </summary>
		// Token: 0x06007052 RID: 28754 RVA: 0x000A1D10 File Offset: 0x0009FF10
		public bool CheckIfTableExists()
		{
			return vtkDatabaseToTableReader.vtkDatabaseToTableReader_CheckIfTableExists_01(base.GetCppThis()) != 0;
		}

		// Token: 0x06007053 RID: 28755
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDatabaseToTableReader_GetDatabase_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Check if the currently specified table name exists in the database.
		/// </summary>
		// Token: 0x06007054 RID: 28756 RVA: 0x000A1D38 File Offset: 0x0009FF38
		public vtkSQLDatabase GetDatabase()
		{
			vtkSQLDatabase vtkSQLDatabase = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDatabaseToTableReader.vtkDatabaseToTableReader_GetDatabase_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06007055 RID: 28757
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDatabaseToTableReader_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007056 RID: 28758 RVA: 0x000A1DA8 File Offset: 0x0009FFA8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDatabaseToTableReader.vtkDatabaseToTableReader_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06007057 RID: 28759
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDatabaseToTableReader_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007058 RID: 28760 RVA: 0x000A1DC8 File Offset: 0x0009FFC8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDatabaseToTableReader.vtkDatabaseToTableReader_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06007059 RID: 28761
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDatabaseToTableReader_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600705A RID: 28762 RVA: 0x000A1DE4 File Offset: 0x0009FFE4
		public override int IsA(string type)
		{
			return vtkDatabaseToTableReader.vtkDatabaseToTableReader_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600705B RID: 28763
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDatabaseToTableReader_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600705C RID: 28764 RVA: 0x000A1E04 File Offset: 0x000A0004
		public new static int IsTypeOf(string type)
		{
			return vtkDatabaseToTableReader.vtkDatabaseToTableReader_IsTypeOf_06(type);
		}

		// Token: 0x0600705D RID: 28765
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDatabaseToTableReader_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600705E RID: 28766 RVA: 0x000A1E20 File Offset: 0x000A0020
		public new vtkDatabaseToTableReader NewInstance()
		{
			vtkDatabaseToTableReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDatabaseToTableReader.vtkDatabaseToTableReader_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDatabaseToTableReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600705F RID: 28767
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDatabaseToTableReader_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007060 RID: 28768 RVA: 0x000A1E7C File Offset: 0x000A007C
		public new static vtkDatabaseToTableReader SafeDownCast(vtkObjectBase o)
		{
			vtkDatabaseToTableReader vtkDatabaseToTableReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDatabaseToTableReader.vtkDatabaseToTableReader_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDatabaseToTableReader = (vtkDatabaseToTableReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDatabaseToTableReader.Register(null);
				}
			}
			return vtkDatabaseToTableReader;
		}

		// Token: 0x06007061 RID: 28769
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDatabaseToTableReader_SetDatabase_09(HandleRef pThis, HandleRef db);

		/// <summary>
		/// Set the database associated with this reader
		/// </summary>
		// Token: 0x06007062 RID: 28770 RVA: 0x000A1EFC File Offset: 0x000A00FC
		public bool SetDatabase(vtkSQLDatabase db)
		{
			return vtkDatabaseToTableReader.vtkDatabaseToTableReader_SetDatabase_09(base.GetCppThis(), (db == null) ? default(HandleRef) : db.GetCppThis()) != 0;
		}

		// Token: 0x06007063 RID: 28771
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDatabaseToTableReader_SetTableName_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Set the name of the table that you'd like to convert to a vtkTable
		/// Returns false if the specified table does not exist in the database.
		/// </summary>
		// Token: 0x06007064 RID: 28772 RVA: 0x000A1F38 File Offset: 0x000A0138
		public bool SetTableName(string name)
		{
			return vtkDatabaseToTableReader.vtkDatabaseToTableReader_SetTableName_10(base.GetCppThis(), name) != 0;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009BB RID: 2491
		public new const string MRFullTypeName = "Kitware.VTK.vtkDatabaseToTableReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009BC RID: 2492
		public new static readonly string MRClassNameKey = "class vtkDatabaseToTableReader";
	}
}
