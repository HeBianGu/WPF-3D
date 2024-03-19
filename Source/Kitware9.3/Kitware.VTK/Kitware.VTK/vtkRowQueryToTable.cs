using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRowQueryToTable
	/// </summary>
	/// <remarks>
	///    executes an sql query and retrieves results into a table
	///
	///
	/// vtkRowQueryToTable creates a vtkTable with the results of an arbitrary SQL
	/// query.  To use this filter, you first need an instance of a vtkSQLDatabase
	/// subclass.  You may use the database class to obtain a vtkRowQuery instance.
	/// Set that query on this filter to extract the query as a table.
	///
	/// @par Thanks:
	/// Thanks to Andrew Wilson from Sandia National Laboratories for his work
	/// on the database classes.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkSQLDatabase vtkRowQuery
	/// </seealso>
	// Token: 0x02000265 RID: 613
	public class vtkRowQueryToTable : vtkTableAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06007092 RID: 28818 RVA: 0x000A2363 File Offset: 0x000A0563
		static vtkRowQueryToTable()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRowQueryToTable.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRowQueryToTable"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06007093 RID: 28819 RVA: 0x000A238B File Offset: 0x000A058B
		public vtkRowQueryToTable(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06007094 RID: 28820
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRowQueryToTable_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007095 RID: 28821 RVA: 0x000A239C File Offset: 0x000A059C
		public new static vtkRowQueryToTable New()
		{
			vtkRowQueryToTable result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRowQueryToTable.vtkRowQueryToTable_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRowQueryToTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007096 RID: 28822 RVA: 0x000A23F0 File Offset: 0x000A05F0
		public vtkRowQueryToTable() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRowQueryToTable.vtkRowQueryToTable_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06007097 RID: 28823 RVA: 0x000A2434 File Offset: 0x000A0634
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06007098 RID: 28824
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkRowQueryToTable_GetMTime_01(HandleRef pThis);

		/// <summary>
		/// Update the modified time based on the query.
		/// </summary>
		// Token: 0x06007099 RID: 28825 RVA: 0x000A2440 File Offset: 0x000A0640
		public override ulong GetMTime()
		{
			return vtkRowQueryToTable.vtkRowQueryToTable_GetMTime_01(base.GetCppThis());
		}

		// Token: 0x0600709A RID: 28826
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRowQueryToTable_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600709B RID: 28827 RVA: 0x000A2460 File Offset: 0x000A0660
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRowQueryToTable.vtkRowQueryToTable_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600709C RID: 28828
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRowQueryToTable_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600709D RID: 28829 RVA: 0x000A2480 File Offset: 0x000A0680
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRowQueryToTable.vtkRowQueryToTable_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600709E RID: 28830
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRowQueryToTable_GetQuery_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The query to execute.
		/// </summary>
		// Token: 0x0600709F RID: 28831 RVA: 0x000A249C File Offset: 0x000A069C
		public virtual vtkRowQuery GetQuery()
		{
			vtkRowQuery vtkRowQuery = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRowQueryToTable.vtkRowQueryToTable_GetQuery_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060070A0 RID: 28832
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRowQueryToTable_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060070A1 RID: 28833 RVA: 0x000A250C File Offset: 0x000A070C
		public override int IsA(string type)
		{
			return vtkRowQueryToTable.vtkRowQueryToTable_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x060070A2 RID: 28834
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRowQueryToTable_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060070A3 RID: 28835 RVA: 0x000A252C File Offset: 0x000A072C
		public new static int IsTypeOf(string type)
		{
			return vtkRowQueryToTable.vtkRowQueryToTable_IsTypeOf_06(type);
		}

		// Token: 0x060070A4 RID: 28836
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRowQueryToTable_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060070A5 RID: 28837 RVA: 0x000A2548 File Offset: 0x000A0748
		public new vtkRowQueryToTable NewInstance()
		{
			vtkRowQueryToTable result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRowQueryToTable.vtkRowQueryToTable_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRowQueryToTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060070A6 RID: 28838
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRowQueryToTable_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060070A7 RID: 28839 RVA: 0x000A25A4 File Offset: 0x000A07A4
		public new static vtkRowQueryToTable SafeDownCast(vtkObjectBase o)
		{
			vtkRowQueryToTable vtkRowQueryToTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRowQueryToTable.vtkRowQueryToTable_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRowQueryToTable = (vtkRowQueryToTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRowQueryToTable.Register(null);
				}
			}
			return vtkRowQueryToTable;
		}

		// Token: 0x060070A8 RID: 28840
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRowQueryToTable_SetQuery_10(HandleRef pThis, HandleRef query);

		/// <summary>
		/// The query to execute.
		/// </summary>
		// Token: 0x060070A9 RID: 28841 RVA: 0x000A2624 File Offset: 0x000A0824
		public void SetQuery(vtkRowQuery query)
		{
			vtkRowQueryToTable.vtkRowQueryToTable_SetQuery_10(base.GetCppThis(), (query == null) ? default(HandleRef) : query.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009BF RID: 2495
		public new const string MRFullTypeName = "Kitware.VTK.vtkRowQueryToTable";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009C0 RID: 2496
		public new static readonly string MRClassNameKey = "class vtkRowQueryToTable";
	}
}
