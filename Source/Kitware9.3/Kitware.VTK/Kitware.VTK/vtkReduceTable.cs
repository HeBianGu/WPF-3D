using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkReduceTable
	/// </summary>
	/// <remarks>
	///    combine some of the rows of a table
	///
	///
	/// Collapses the rows of the input table so that one particular
	/// column (the IndexColumn) does not contain any duplicate values.
	/// Thus the output table will have the same columns as the input
	/// table, but potentially fewer rows.  One example use of this
	/// class would be to generate a summary table from a table of
	/// observations.
	/// When two or more rows of the input table share a value in the
	/// IndexColumn, the values from these rows will be combined on a
	/// column-by-column basis.  By default, such numerical values will be
	/// reduced to their mean, and non-numerical values will be reduced to
	/// their mode.  This default behavior can be changed by calling
	/// SetNumericalReductionMethod() or SetNonNumericalReductionMethod().
	/// You can also specify the reduction method to use for a particular
	/// column by calling SetReductionMethodForColumn().
	/// </remarks>
	// Token: 0x0200068C RID: 1676
	public class vtkReduceTable : vtkTableAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011FF7 RID: 73719 RVA: 0x0019317B File Offset: 0x0019137B
		static vtkReduceTable()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkReduceTable.MRClassNameKey, Type.GetType("Kitware.VTK.vtkReduceTable"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011FF8 RID: 73720 RVA: 0x001931A3 File Offset: 0x001913A3
		public vtkReduceTable(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011FF9 RID: 73721
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkReduceTable_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011FFA RID: 73722 RVA: 0x001931B4 File Offset: 0x001913B4
		public new static vtkReduceTable New()
		{
			vtkReduceTable result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkReduceTable.vtkReduceTable_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkReduceTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011FFB RID: 73723 RVA: 0x00193208 File Offset: 0x00191408
		public vtkReduceTable() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkReduceTable.vtkReduceTable_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011FFC RID: 73724 RVA: 0x0019324C File Offset: 0x0019144C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011FFD RID: 73725
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkReduceTable_GetIndexColumn_01(HandleRef pThis);

		/// <summary>
		/// Get/Set the column that will be used to reduce the input table.
		/// Any rows sharing a value in this column will be collapsed into
		/// a single row in the output table.
		/// </summary>
		// Token: 0x06011FFE RID: 73726 RVA: 0x00193258 File Offset: 0x00191458
		public virtual long GetIndexColumn()
		{
			return vtkReduceTable.vtkReduceTable_GetIndexColumn_01(base.GetCppThis());
		}

		// Token: 0x06011FFF RID: 73727
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkReduceTable_GetNonNumericalReductionMethod_02(HandleRef pThis);

		/// <summary>
		/// Get/Set the method that should be used to combine non-numerical
		/// values.
		/// </summary>
		// Token: 0x06012000 RID: 73728 RVA: 0x00193278 File Offset: 0x00191478
		public virtual int GetNonNumericalReductionMethod()
		{
			return vtkReduceTable.vtkReduceTable_GetNonNumericalReductionMethod_02(base.GetCppThis());
		}

		// Token: 0x06012001 RID: 73729
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkReduceTable_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012002 RID: 73730 RVA: 0x00193298 File Offset: 0x00191498
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkReduceTable.vtkReduceTable_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06012003 RID: 73731
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkReduceTable_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012004 RID: 73732 RVA: 0x001932B8 File Offset: 0x001914B8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkReduceTable.vtkReduceTable_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06012005 RID: 73733
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkReduceTable_GetNumericalReductionMethod_05(HandleRef pThis);

		/// <summary>
		/// Get/Set the method that should be used to combine numerical
		/// values.
		/// </summary>
		// Token: 0x06012006 RID: 73734 RVA: 0x001932D4 File Offset: 0x001914D4
		public virtual int GetNumericalReductionMethod()
		{
			return vtkReduceTable.vtkReduceTable_GetNumericalReductionMethod_05(base.GetCppThis());
		}

		// Token: 0x06012007 RID: 73735
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkReduceTable_GetReductionMethodForColumn_06(HandleRef pThis, long col);

		/// <summary>
		/// Get the method that should be used to combine the values within
		/// the specified column.  Returns -1 if no method has been set for
		/// this particular column.
		/// </summary>
		// Token: 0x06012008 RID: 73736 RVA: 0x001932F4 File Offset: 0x001914F4
		public int GetReductionMethodForColumn(long col)
		{
			return vtkReduceTable.vtkReduceTable_GetReductionMethodForColumn_06(base.GetCppThis(), col);
		}

		// Token: 0x06012009 RID: 73737
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkReduceTable_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601200A RID: 73738 RVA: 0x00193314 File Offset: 0x00191514
		public override int IsA(string type)
		{
			return vtkReduceTable.vtkReduceTable_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601200B RID: 73739
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkReduceTable_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601200C RID: 73740 RVA: 0x00193334 File Offset: 0x00191534
		public new static int IsTypeOf(string type)
		{
			return vtkReduceTable.vtkReduceTable_IsTypeOf_08(type);
		}

		// Token: 0x0601200D RID: 73741
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkReduceTable_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601200E RID: 73742 RVA: 0x00193350 File Offset: 0x00191550
		public new vtkReduceTable NewInstance()
		{
			vtkReduceTable result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkReduceTable.vtkReduceTable_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkReduceTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601200F RID: 73743
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkReduceTable_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012010 RID: 73744 RVA: 0x001933AC File Offset: 0x001915AC
		public new static vtkReduceTable SafeDownCast(vtkObjectBase o)
		{
			vtkReduceTable vtkReduceTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkReduceTable.vtkReduceTable_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkReduceTable = (vtkReduceTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkReduceTable.Register(null);
				}
			}
			return vtkReduceTable;
		}

		// Token: 0x06012011 RID: 73745
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkReduceTable_SetIndexColumn_12(HandleRef pThis, long _arg);

		/// <summary>
		/// Get/Set the column that will be used to reduce the input table.
		/// Any rows sharing a value in this column will be collapsed into
		/// a single row in the output table.
		/// </summary>
		// Token: 0x06012012 RID: 73746 RVA: 0x0019342B File Offset: 0x0019162B
		public virtual void SetIndexColumn(long _arg)
		{
			vtkReduceTable.vtkReduceTable_SetIndexColumn_12(base.GetCppThis(), _arg);
		}

		// Token: 0x06012013 RID: 73747
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkReduceTable_SetNonNumericalReductionMethod_13(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the method that should be used to combine non-numerical
		/// values.
		/// </summary>
		// Token: 0x06012014 RID: 73748 RVA: 0x0019343B File Offset: 0x0019163B
		public virtual void SetNonNumericalReductionMethod(int _arg)
		{
			vtkReduceTable.vtkReduceTable_SetNonNumericalReductionMethod_13(base.GetCppThis(), _arg);
		}

		// Token: 0x06012015 RID: 73749
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkReduceTable_SetNumericalReductionMethod_14(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the method that should be used to combine numerical
		/// values.
		/// </summary>
		// Token: 0x06012016 RID: 73750 RVA: 0x0019344B File Offset: 0x0019164B
		public virtual void SetNumericalReductionMethod(int _arg)
		{
			vtkReduceTable.vtkReduceTable_SetNumericalReductionMethod_14(base.GetCppThis(), _arg);
		}

		// Token: 0x06012017 RID: 73751
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkReduceTable_SetReductionMethodForColumn_15(HandleRef pThis, long col, int method);

		/// <summary>
		/// Set the method that should be used to combine the values within
		/// the specified column.
		/// </summary>
		// Token: 0x06012018 RID: 73752 RVA: 0x0019345B File Offset: 0x0019165B
		public void SetReductionMethodForColumn(long col, int method)
		{
			vtkReduceTable.vtkReduceTable_SetReductionMethodForColumn_15(base.GetCppThis(), col, method);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014C1 RID: 5313
		public new const string MRFullTypeName = "Kitware.VTK.vtkReduceTable";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014C2 RID: 5314
		public new static readonly string MRClassNameKey = "class vtkReduceTable";

		/// <summary>
		/// Enum for methods of reduction
		/// </summary>
		// Token: 0x0200068D RID: 1677
		public enum MEAN_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x040014C4 RID: 5316
			MEAN,
			/// <summary>enum member</summary>
			// Token: 0x040014C5 RID: 5317
			MEDIAN,
			/// <summary>enum member</summary>
			// Token: 0x040014C6 RID: 5318
			MODE
		}
	}
}
