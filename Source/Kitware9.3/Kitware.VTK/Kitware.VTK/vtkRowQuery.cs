using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRowQuery
	/// </summary>
	/// <remarks>
	///    abstract interface for queries that return
	/// row-oriented results.
	///
	///
	/// The abstract superclass of query classes that return row-oriented (table)
	/// results.  A subclass will provide database-specific query parameters and
	/// implement the vtkRowQuery API to return query results:
	///
	/// Execute() - Execute the query.  No results need to be retrieved at this
	///             point, unless you are performing caching.
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
	/// @par Thanks:
	/// Thanks to Andrew Wilson from Sandia National Laboratories for his work
	/// on the database classes.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRowQueryToTable
	/// </seealso>
	// Token: 0x02000264 RID: 612
	public abstract class vtkRowQuery : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06007065 RID: 28773 RVA: 0x000A1F5F File Offset: 0x000A015F
		static vtkRowQuery()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRowQuery.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRowQuery"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06007066 RID: 28774 RVA: 0x000A1F87 File Offset: 0x000A0187
		public vtkRowQuery(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06007067 RID: 28775 RVA: 0x000A1F95 File Offset: 0x000A0195
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06007068 RID: 28776
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRowQuery_CaseSensitiveFieldNamesOff_01(HandleRef pThis);

		/// <summary>
		/// Many databases do not preserve case in field names.  This can
		/// cause GetFieldIndex to fail if you search for a field named
		/// someFieldName when the database actually stores it as
		/// SOMEFIELDNAME.  This ivar controls whether GetFieldIndex()
		/// expects field names to be case-sensitive.  The default is OFF,
		/// i.e. case is not preserved.
		/// </summary>
		// Token: 0x06007069 RID: 28777 RVA: 0x000A1FA0 File Offset: 0x000A01A0
		public virtual void CaseSensitiveFieldNamesOff()
		{
			vtkRowQuery.vtkRowQuery_CaseSensitiveFieldNamesOff_01(base.GetCppThis());
		}

		// Token: 0x0600706A RID: 28778
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRowQuery_CaseSensitiveFieldNamesOn_02(HandleRef pThis);

		/// <summary>
		/// Many databases do not preserve case in field names.  This can
		/// cause GetFieldIndex to fail if you search for a field named
		/// someFieldName when the database actually stores it as
		/// SOMEFIELDNAME.  This ivar controls whether GetFieldIndex()
		/// expects field names to be case-sensitive.  The default is OFF,
		/// i.e. case is not preserved.
		/// </summary>
		// Token: 0x0600706B RID: 28779 RVA: 0x000A1FAF File Offset: 0x000A01AF
		public virtual void CaseSensitiveFieldNamesOn()
		{
			vtkRowQuery.vtkRowQuery_CaseSensitiveFieldNamesOn_02(base.GetCppThis());
		}

		// Token: 0x0600706C RID: 28780
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRowQuery_DataValue_03(HandleRef pThis, long c, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return data in current row, field c
		/// </summary>
		// Token: 0x0600706D RID: 28781 RVA: 0x000A1FC0 File Offset: 0x000A01C0
		public virtual vtkVariant DataValue(long c)
		{
			vtkVariant result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRowQuery.vtkRowQuery_DataValue_03(base.GetCppThis(), c, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVariant)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600706E RID: 28782
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRowQuery_Execute_04(HandleRef pThis);

		/// <summary>
		/// Execute the query.  This must be performed
		/// before any field name or data access functions
		/// are used.
		/// </summary>
		// Token: 0x0600706F RID: 28783 RVA: 0x000A201C File Offset: 0x000A021C
		public virtual bool Execute()
		{
			return vtkRowQuery.vtkRowQuery_Execute_04(base.GetCppThis()) != 0;
		}

		// Token: 0x06007070 RID: 28784
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRowQuery_GetCaseSensitiveFieldNames_05(HandleRef pThis);

		/// <summary>
		/// Many databases do not preserve case in field names.  This can
		/// cause GetFieldIndex to fail if you search for a field named
		/// someFieldName when the database actually stores it as
		/// SOMEFIELDNAME.  This ivar controls whether GetFieldIndex()
		/// expects field names to be case-sensitive.  The default is OFF,
		/// i.e. case is not preserved.
		/// </summary>
		// Token: 0x06007071 RID: 28785 RVA: 0x000A2044 File Offset: 0x000A0244
		public virtual bool GetCaseSensitiveFieldNames()
		{
			return vtkRowQuery.vtkRowQuery_GetCaseSensitiveFieldNames_05(base.GetCppThis()) != 0;
		}

		// Token: 0x06007072 RID: 28786
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRowQuery_GetFieldIndex_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Return the index of the specified query field.
		/// Uses GetNumberOfFields() and GetFieldName()
		/// to match field name.
		/// </summary>
		// Token: 0x06007073 RID: 28787 RVA: 0x000A206C File Offset: 0x000A026C
		public int GetFieldIndex(string name)
		{
			return vtkRowQuery.vtkRowQuery_GetFieldIndex_06(base.GetCppThis(), name);
		}

		// Token: 0x06007074 RID: 28788
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRowQuery_GetFieldName_07(HandleRef pThis, int i);

		/// <summary>
		/// Return the name of the specified query field.
		/// </summary>
		// Token: 0x06007075 RID: 28789 RVA: 0x000A208C File Offset: 0x000A028C
		public virtual string GetFieldName(int i)
		{
			string s = Marshal.PtrToStringAnsi(vtkRowQuery.vtkRowQuery_GetFieldName_07(base.GetCppThis(), i));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06007076 RID: 28790
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRowQuery_GetFieldType_08(HandleRef pThis, int i);

		/// <summary>
		/// Return the type of the field, using the constants defined in vtkType.h.
		/// </summary>
		// Token: 0x06007077 RID: 28791 RVA: 0x000A20C8 File Offset: 0x000A02C8
		public virtual int GetFieldType(int i)
		{
			return vtkRowQuery.vtkRowQuery_GetFieldType_08(base.GetCppThis(), i);
		}

		// Token: 0x06007078 RID: 28792
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRowQuery_GetLastErrorText_09(HandleRef pThis);

		/// <summary>
		/// Get the last error text from the query
		/// </summary>
		// Token: 0x06007079 RID: 28793 RVA: 0x000A20E8 File Offset: 0x000A02E8
		public virtual string GetLastErrorText()
		{
			string s = Marshal.PtrToStringAnsi(vtkRowQuery.vtkRowQuery_GetLastErrorText_09(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600707A RID: 28794
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRowQuery_GetNumberOfFields_10(HandleRef pThis);

		/// <summary>
		/// The number of fields in the query result.
		/// </summary>
		// Token: 0x0600707B RID: 28795 RVA: 0x000A2124 File Offset: 0x000A0324
		public virtual int GetNumberOfFields()
		{
			return vtkRowQuery.vtkRowQuery_GetNumberOfFields_10(base.GetCppThis());
		}

		// Token: 0x0600707C RID: 28796
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRowQuery_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600707D RID: 28797 RVA: 0x000A2144 File Offset: 0x000A0344
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRowQuery.vtkRowQuery_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x0600707E RID: 28798
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRowQuery_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600707F RID: 28799 RVA: 0x000A2164 File Offset: 0x000A0364
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRowQuery.vtkRowQuery_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x06007080 RID: 28800
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRowQuery_HasError_13(HandleRef pThis);

		/// <summary>
		/// Returns true if an error is set, otherwise false.
		/// </summary>
		// Token: 0x06007081 RID: 28801 RVA: 0x000A2180 File Offset: 0x000A0380
		public virtual bool HasError()
		{
			return vtkRowQuery.vtkRowQuery_HasError_13(base.GetCppThis()) != 0;
		}

		// Token: 0x06007082 RID: 28802
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRowQuery_IsA_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007083 RID: 28803 RVA: 0x000A21A8 File Offset: 0x000A03A8
		public override int IsA(string type)
		{
			return vtkRowQuery.vtkRowQuery_IsA_14(base.GetCppThis(), type);
		}

		// Token: 0x06007084 RID: 28804
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRowQuery_IsActive_15(HandleRef pThis);

		/// <summary>
		/// Return true if the query is active (i.e. execution was successful
		/// and results are ready to be fetched).  Returns false on error or
		/// inactive query.
		/// </summary>
		// Token: 0x06007085 RID: 28805 RVA: 0x000A21C8 File Offset: 0x000A03C8
		public virtual bool IsActive()
		{
			return vtkRowQuery.vtkRowQuery_IsActive_15(base.GetCppThis()) != 0;
		}

		// Token: 0x06007086 RID: 28806
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRowQuery_IsTypeOf_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007087 RID: 28807 RVA: 0x000A21F0 File Offset: 0x000A03F0
		public new static int IsTypeOf(string type)
		{
			return vtkRowQuery.vtkRowQuery_IsTypeOf_16(type);
		}

		// Token: 0x06007088 RID: 28808
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRowQuery_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007089 RID: 28809 RVA: 0x000A220C File Offset: 0x000A040C
		public new vtkRowQuery NewInstance()
		{
			vtkRowQuery result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRowQuery.vtkRowQuery_NewInstance_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRowQuery)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600708A RID: 28810
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRowQuery_NextRow_18(HandleRef pThis);

		/// <summary>
		/// Advance row, return false if past end.
		/// </summary>
		// Token: 0x0600708B RID: 28811 RVA: 0x000A2268 File Offset: 0x000A0468
		public virtual bool NextRow()
		{
			return vtkRowQuery.vtkRowQuery_NextRow_18(base.GetCppThis()) != 0;
		}

		// Token: 0x0600708C RID: 28812
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRowQuery_NextRow_19(HandleRef pThis, HandleRef rowArray);

		/// <summary>
		/// Advance row, return false if past end.
		/// Also, fill array with row values.
		/// </summary>
		// Token: 0x0600708D RID: 28813 RVA: 0x000A2290 File Offset: 0x000A0490
		public bool NextRow(vtkVariantArray rowArray)
		{
			return vtkRowQuery.vtkRowQuery_NextRow_19(base.GetCppThis(), (rowArray == null) ? default(HandleRef) : rowArray.GetCppThis()) != 0;
		}

		// Token: 0x0600708E RID: 28814
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRowQuery_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600708F RID: 28815 RVA: 0x000A22CC File Offset: 0x000A04CC
		public new static vtkRowQuery SafeDownCast(vtkObjectBase o)
		{
			vtkRowQuery vtkRowQuery = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRowQuery.vtkRowQuery_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRowQuery = (vtkRowQuery)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRowQuery.Register(null);
				}
			}
			return vtkRowQuery;
		}

		// Token: 0x06007090 RID: 28816
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRowQuery_SetCaseSensitiveFieldNames_21(HandleRef pThis, byte _arg);

		/// <summary>
		/// Many databases do not preserve case in field names.  This can
		/// cause GetFieldIndex to fail if you search for a field named
		/// someFieldName when the database actually stores it as
		/// SOMEFIELDNAME.  This ivar controls whether GetFieldIndex()
		/// expects field names to be case-sensitive.  The default is OFF,
		/// i.e. case is not preserved.
		/// </summary>
		// Token: 0x06007091 RID: 28817 RVA: 0x000A234B File Offset: 0x000A054B
		public virtual void SetCaseSensitiveFieldNames(bool _arg)
		{
			vtkRowQuery.vtkRowQuery_SetCaseSensitiveFieldNames_21(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009BD RID: 2493
		public new const string MRFullTypeName = "Kitware.VTK.vtkRowQuery";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009BE RID: 2494
		public new static readonly string MRClassNameKey = "class vtkRowQuery";
	}
}
