using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDataObjectToTable
	/// </summary>
	/// <remarks>
	///    extract field data as a table
	///
	///
	/// This filter is used to extract either the field, cell or point data of
	/// any data object as a table.
	/// </remarks>
	// Token: 0x02000677 RID: 1655
	public class vtkDataObjectToTable : vtkTableAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011D49 RID: 73033 RVA: 0x0018F34D File Offset: 0x0018D54D
		static vtkDataObjectToTable()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataObjectToTable.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataObjectToTable"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011D4A RID: 73034 RVA: 0x0018F375 File Offset: 0x0018D575
		public vtkDataObjectToTable(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011D4B RID: 73035
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectToTable_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011D4C RID: 73036 RVA: 0x0018F384 File Offset: 0x0018D584
		public new static vtkDataObjectToTable New()
		{
			vtkDataObjectToTable result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectToTable.vtkDataObjectToTable_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataObjectToTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011D4D RID: 73037 RVA: 0x0018F3D8 File Offset: 0x0018D5D8
		public vtkDataObjectToTable() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDataObjectToTable.vtkDataObjectToTable_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011D4E RID: 73038 RVA: 0x0018F41C File Offset: 0x0018D61C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011D4F RID: 73039
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectToTable_GetFieldType_01(HandleRef pThis);

		/// <summary>
		/// The field type to copy into the output table.
		/// Should be one of FIELD_DATA, POINT_DATA, CELL_DATA, VERTEX_DATA, EDGE_DATA.
		/// </summary>
		// Token: 0x06011D50 RID: 73040 RVA: 0x0018F428 File Offset: 0x0018D628
		public virtual int GetFieldType()
		{
			return vtkDataObjectToTable.vtkDataObjectToTable_GetFieldType_01(base.GetCppThis());
		}

		// Token: 0x06011D51 RID: 73041
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectToTable_GetFieldTypeMaxValue_02(HandleRef pThis);

		/// <summary>
		/// The field type to copy into the output table.
		/// Should be one of FIELD_DATA, POINT_DATA, CELL_DATA, VERTEX_DATA, EDGE_DATA.
		/// </summary>
		// Token: 0x06011D52 RID: 73042 RVA: 0x0018F448 File Offset: 0x0018D648
		public virtual int GetFieldTypeMaxValue()
		{
			return vtkDataObjectToTable.vtkDataObjectToTable_GetFieldTypeMaxValue_02(base.GetCppThis());
		}

		// Token: 0x06011D53 RID: 73043
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectToTable_GetFieldTypeMinValue_03(HandleRef pThis);

		/// <summary>
		/// The field type to copy into the output table.
		/// Should be one of FIELD_DATA, POINT_DATA, CELL_DATA, VERTEX_DATA, EDGE_DATA.
		/// </summary>
		// Token: 0x06011D54 RID: 73044 RVA: 0x0018F468 File Offset: 0x0018D668
		public virtual int GetFieldTypeMinValue()
		{
			return vtkDataObjectToTable.vtkDataObjectToTable_GetFieldTypeMinValue_03(base.GetCppThis());
		}

		// Token: 0x06011D55 RID: 73045
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataObjectToTable_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011D56 RID: 73046 RVA: 0x0018F488 File Offset: 0x0018D688
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDataObjectToTable.vtkDataObjectToTable_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06011D57 RID: 73047
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataObjectToTable_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011D58 RID: 73048 RVA: 0x0018F4A8 File Offset: 0x0018D6A8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDataObjectToTable.vtkDataObjectToTable_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06011D59 RID: 73049
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectToTable_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011D5A RID: 73050 RVA: 0x0018F4C4 File Offset: 0x0018D6C4
		public override int IsA(string type)
		{
			return vtkDataObjectToTable.vtkDataObjectToTable_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06011D5B RID: 73051
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectToTable_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011D5C RID: 73052 RVA: 0x0018F4E4 File Offset: 0x0018D6E4
		public new static int IsTypeOf(string type)
		{
			return vtkDataObjectToTable.vtkDataObjectToTable_IsTypeOf_07(type);
		}

		// Token: 0x06011D5D RID: 73053
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectToTable_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011D5E RID: 73054 RVA: 0x0018F500 File Offset: 0x0018D700
		public new vtkDataObjectToTable NewInstance()
		{
			vtkDataObjectToTable result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectToTable.vtkDataObjectToTable_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataObjectToTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011D5F RID: 73055
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectToTable_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011D60 RID: 73056 RVA: 0x0018F55C File Offset: 0x0018D75C
		public new static vtkDataObjectToTable SafeDownCast(vtkObjectBase o)
		{
			vtkDataObjectToTable vtkDataObjectToTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectToTable.vtkDataObjectToTable_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObjectToTable = (vtkDataObjectToTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObjectToTable.Register(null);
				}
			}
			return vtkDataObjectToTable;
		}

		// Token: 0x06011D61 RID: 73057
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectToTable_SetFieldType_11(HandleRef pThis, int _arg);

		/// <summary>
		/// The field type to copy into the output table.
		/// Should be one of FIELD_DATA, POINT_DATA, CELL_DATA, VERTEX_DATA, EDGE_DATA.
		/// </summary>
		// Token: 0x06011D62 RID: 73058 RVA: 0x0018F5DB File Offset: 0x0018D7DB
		public virtual void SetFieldType(int _arg)
		{
			vtkDataObjectToTable.vtkDataObjectToTable_SetFieldType_11(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400148F RID: 5263
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataObjectToTable";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001490 RID: 5264
		public new static readonly string MRClassNameKey = "class vtkDataObjectToTable";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x02000678 RID: 1656
		public enum CELL_DATA_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04001492 RID: 5266
			CELL_DATA = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001493 RID: 5267
			EDGE_DATA = 4,
			/// <summary>enum member</summary>
			// Token: 0x04001494 RID: 5268
			FIELD_DATA = 0,
			/// <summary>enum member</summary>
			// Token: 0x04001495 RID: 5269
			POINT_DATA,
			/// <summary>enum member</summary>
			// Token: 0x04001496 RID: 5270
			VERTEX_DATA = 3
		}
	}
}
