using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTransposeTable
	/// </summary>
	/// <remarks>
	///    Transpose an input table.
	///
	///
	/// This algorithm allows to transpose a vtkTable as a matrix.
	/// Columns become rows and vice versa. A new column can be added to
	/// the result table at index 0 to collect the name of the initial
	/// columns (when AddIdColumn is true). Such a column can be used
	/// to name the columns of the result.
	/// Note that columns of the output table will have a variant type
	/// is the columns of the initial table are not consistent.
	/// </remarks>
	// Token: 0x020009B7 RID: 2487
	public class vtkTransposeTable : vtkTableAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06019FBB RID: 106427 RVA: 0x00240804 File Offset: 0x0023EA04
		static vtkTransposeTable()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTransposeTable.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTransposeTable"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06019FBC RID: 106428 RVA: 0x0024082C File Offset: 0x0023EA2C
		public vtkTransposeTable(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06019FBD RID: 106429
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransposeTable_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019FBE RID: 106430 RVA: 0x0024083C File Offset: 0x0023EA3C
		public new static vtkTransposeTable New()
		{
			vtkTransposeTable result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransposeTable.vtkTransposeTable_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransposeTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019FBF RID: 106431 RVA: 0x00240890 File Offset: 0x0023EA90
		public vtkTransposeTable() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTransposeTable.vtkTransposeTable_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06019FC0 RID: 106432 RVA: 0x002408D4 File Offset: 0x0023EAD4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06019FC1 RID: 106433
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransposeTable_AddIdColumnOff_01(HandleRef pThis);

		/// <summary>
		/// This flag indicates if a column must be inserted at index 0
		/// with the names (ids) of the input columns.
		/// Default: true
		/// </summary>
		// Token: 0x06019FC2 RID: 106434 RVA: 0x002408DF File Offset: 0x0023EADF
		public virtual void AddIdColumnOff()
		{
			vtkTransposeTable.vtkTransposeTable_AddIdColumnOff_01(base.GetCppThis());
		}

		// Token: 0x06019FC3 RID: 106435
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransposeTable_AddIdColumnOn_02(HandleRef pThis);

		/// <summary>
		/// This flag indicates if a column must be inserted at index 0
		/// with the names (ids) of the input columns.
		/// Default: true
		/// </summary>
		// Token: 0x06019FC4 RID: 106436 RVA: 0x002408EE File Offset: 0x0023EAEE
		public virtual void AddIdColumnOn()
		{
			vtkTransposeTable.vtkTransposeTable_AddIdColumnOn_02(base.GetCppThis());
		}

		// Token: 0x06019FC5 RID: 106437
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTransposeTable_GetAddIdColumn_03(HandleRef pThis);

		/// <summary>
		/// This flag indicates if a column must be inserted at index 0
		/// with the names (ids) of the input columns.
		/// Default: true
		/// </summary>
		// Token: 0x06019FC6 RID: 106438 RVA: 0x00240900 File Offset: 0x0023EB00
		public virtual bool GetAddIdColumn()
		{
			return vtkTransposeTable.vtkTransposeTable_GetAddIdColumn_03(base.GetCppThis()) != 0;
		}

		// Token: 0x06019FC7 RID: 106439
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransposeTable_GetIdColumnName_04(HandleRef pThis);

		/// <summary>
		/// Get/Set the name of the id column added by option AddIdColumn.
		/// Default: ColName
		/// </summary>
		// Token: 0x06019FC8 RID: 106440 RVA: 0x00240928 File Offset: 0x0023EB28
		public virtual string GetIdColumnName()
		{
			string s = Marshal.PtrToStringAnsi(vtkTransposeTable.vtkTransposeTable_GetIdColumnName_04(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06019FC9 RID: 106441
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTransposeTable_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019FCA RID: 106442 RVA: 0x00240964 File Offset: 0x0023EB64
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTransposeTable.vtkTransposeTable_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06019FCB RID: 106443
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTransposeTable_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019FCC RID: 106444 RVA: 0x00240984 File Offset: 0x0023EB84
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTransposeTable.vtkTransposeTable_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06019FCD RID: 106445
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTransposeTable_GetUseIdColumn_07(HandleRef pThis);

		/// <summary>
		/// This flag indicates if the output column must be named using the
		/// names listed in the index 0 column.
		/// Default: false
		/// </summary>
		// Token: 0x06019FCE RID: 106446 RVA: 0x002409A0 File Offset: 0x0023EBA0
		public virtual bool GetUseIdColumn()
		{
			return vtkTransposeTable.vtkTransposeTable_GetUseIdColumn_07(base.GetCppThis()) != 0;
		}

		// Token: 0x06019FCF RID: 106447
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransposeTable_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019FD0 RID: 106448 RVA: 0x002409C8 File Offset: 0x0023EBC8
		public override int IsA(string type)
		{
			return vtkTransposeTable.vtkTransposeTable_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x06019FD1 RID: 106449
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransposeTable_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019FD2 RID: 106450 RVA: 0x002409E8 File Offset: 0x0023EBE8
		public new static int IsTypeOf(string type)
		{
			return vtkTransposeTable.vtkTransposeTable_IsTypeOf_09(type);
		}

		// Token: 0x06019FD3 RID: 106451
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransposeTable_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019FD4 RID: 106452 RVA: 0x00240A04 File Offset: 0x0023EC04
		public new vtkTransposeTable NewInstance()
		{
			vtkTransposeTable result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransposeTable.vtkTransposeTable_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransposeTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06019FD5 RID: 106453
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransposeTable_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019FD6 RID: 106454 RVA: 0x00240A60 File Offset: 0x0023EC60
		public new static vtkTransposeTable SafeDownCast(vtkObjectBase o)
		{
			vtkTransposeTable vtkTransposeTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransposeTable.vtkTransposeTable_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransposeTable = (vtkTransposeTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransposeTable.Register(null);
				}
			}
			return vtkTransposeTable;
		}

		// Token: 0x06019FD7 RID: 106455
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransposeTable_SetAddIdColumn_13(HandleRef pThis, byte _arg);

		/// <summary>
		/// This flag indicates if a column must be inserted at index 0
		/// with the names (ids) of the input columns.
		/// Default: true
		/// </summary>
		// Token: 0x06019FD8 RID: 106456 RVA: 0x00240ADF File Offset: 0x0023ECDF
		public virtual void SetAddIdColumn(bool _arg)
		{
			vtkTransposeTable.vtkTransposeTable_SetAddIdColumn_13(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06019FD9 RID: 106457
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransposeTable_SetIdColumnName_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Get/Set the name of the id column added by option AddIdColumn.
		/// Default: ColName
		/// </summary>
		// Token: 0x06019FDA RID: 106458 RVA: 0x00240AF7 File Offset: 0x0023ECF7
		public virtual void SetIdColumnName(string _arg)
		{
			vtkTransposeTable.vtkTransposeTable_SetIdColumnName_14(base.GetCppThis(), _arg);
		}

		// Token: 0x06019FDB RID: 106459
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransposeTable_SetUseIdColumn_15(HandleRef pThis, byte _arg);

		/// <summary>
		/// This flag indicates if the output column must be named using the
		/// names listed in the index 0 column.
		/// Default: false
		/// </summary>
		// Token: 0x06019FDC RID: 106460 RVA: 0x00240B07 File Offset: 0x0023ED07
		public virtual void SetUseIdColumn(bool _arg)
		{
			vtkTransposeTable.vtkTransposeTable_SetUseIdColumn_15(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06019FDD RID: 106461
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransposeTable_UseIdColumnOff_16(HandleRef pThis);

		/// <summary>
		/// This flag indicates if the output column must be named using the
		/// names listed in the index 0 column.
		/// Default: false
		/// </summary>
		// Token: 0x06019FDE RID: 106462 RVA: 0x00240B1F File Offset: 0x0023ED1F
		public virtual void UseIdColumnOff()
		{
			vtkTransposeTable.vtkTransposeTable_UseIdColumnOff_16(base.GetCppThis());
		}

		// Token: 0x06019FDF RID: 106463
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransposeTable_UseIdColumnOn_17(HandleRef pThis);

		/// <summary>
		/// This flag indicates if the output column must be named using the
		/// names listed in the index 0 column.
		/// Default: false
		/// </summary>
		// Token: 0x06019FE0 RID: 106464 RVA: 0x00240B2E File Offset: 0x0023ED2E
		public virtual void UseIdColumnOn()
		{
			vtkTransposeTable.vtkTransposeTable_UseIdColumnOn_17(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C34 RID: 7220
		public new const string MRFullTypeName = "Kitware.VTK.vtkTransposeTable";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C35 RID: 7221
		public new static readonly string MRClassNameKey = "class vtkTransposeTable";
	}
}
