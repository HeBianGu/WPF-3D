using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPassArrays
	/// </summary>
	/// <remarks>
	///    Passes a subset of arrays to the output
	///
	///
	/// This filter preserves all the topology of the input, but only a subset of
	/// arrays are passed to the output. Add an array to be passed to the output
	/// data object with AddArray(). If RemoveArrays is on, the specified arrays will
	/// be the ones that are removed instead of the ones that are kept.
	///
	/// Arrays with special attributes (scalars, pedigree ids, etc.) will retain those
	/// attributes in the output.
	///
	/// By default, only those field types with at least one array specified through
	/// AddArray will be processed. If instead UseFieldTypes
	/// is turned on, you explicitly set which field types to process with AddFieldType.
	///
	/// By default, ghost arrays will be passed unless RemoveArrays is selected
	/// and those arrays are specifically chosen to be removed.
	///
	/// Example 1:
	///
	/// &lt;pre&gt;
	/// passArray-&gt;AddArray(vtkDataObject::POINT, "velocity");
	/// &lt;/pre&gt;
	///
	/// The output will have only that one array "velocity" in the
	/// point data, but cell and field data will be untouched.
	///
	/// Example 2:
	///
	/// &lt;pre&gt;
	/// passArray-&gt;AddArray(vtkDataObject::POINT, "velocity");
	/// passArray-&gt;UseFieldTypesOn();
	/// passArray-&gt;AddFieldType(vtkDataObject::POINT);
	/// passArray-&gt;AddFieldType(vtkDataObject::CELL);
	/// &lt;/pre&gt;
	///
	/// The point data would still contain the single array, but the cell data
	/// would be cleared since you did not specify any arrays to pass. Field data would
	/// still be untouched.
	///
	/// @section Note
	///
	/// vtkPassArrays has been replaced by `vtkPassSelectedArrays`. It is recommended
	/// that newer code uses `vtkPassSelectedArrays` instead of this filter.
	/// `vtkPassSelectedArrays` uses `vtkDataArraySelection` to select arrays and
	/// hence provides a more typical API. `vtkPassArrays` may be deprecated in
	/// future releases.
	/// </remarks>
	// Token: 0x020008C7 RID: 2247
	public class vtkPassArrays : vtkDataObjectAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601739E RID: 95134 RVA: 0x00209C0F File Offset: 0x00207E0F
		static vtkPassArrays()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPassArrays.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPassArrays"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601739F RID: 95135 RVA: 0x00209C37 File Offset: 0x00207E37
		public vtkPassArrays(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060173A0 RID: 95136
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPassArrays_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060173A1 RID: 95137 RVA: 0x00209C48 File Offset: 0x00207E48
		public new static vtkPassArrays New()
		{
			vtkPassArrays result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPassArrays.vtkPassArrays_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPassArrays)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060173A2 RID: 95138 RVA: 0x00209C9C File Offset: 0x00207E9C
		public vtkPassArrays() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPassArrays.vtkPassArrays_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060173A3 RID: 95139 RVA: 0x00209CE0 File Offset: 0x00207EE0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060173A4 RID: 95140
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPassArrays_AddArray_01(HandleRef pThis, int fieldType, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Adds an array to pass through.
		/// fieldType where the array that should be passed (point data, cell data, etc.).
		/// It should be one of the constants defined in the vtkDataObject::AttributeTypes
		/// enumeration.
		/// </summary>
		// Token: 0x060173A5 RID: 95141 RVA: 0x00209CEB File Offset: 0x00207EEB
		public virtual void AddArray(int fieldType, string name)
		{
			vtkPassArrays.vtkPassArrays_AddArray_01(base.GetCppThis(), fieldType, name);
		}

		// Token: 0x060173A6 RID: 95142
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPassArrays_AddCellDataArray_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Adds an array to pass through.
		/// fieldType where the array that should be passed (point data, cell data, etc.).
		/// It should be one of the constants defined in the vtkDataObject::AttributeTypes
		/// enumeration.
		/// </summary>
		// Token: 0x060173A7 RID: 95143 RVA: 0x00209CFC File Offset: 0x00207EFC
		public virtual void AddCellDataArray(string name)
		{
			vtkPassArrays.vtkPassArrays_AddCellDataArray_02(base.GetCppThis(), name);
		}

		// Token: 0x060173A8 RID: 95144
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPassArrays_AddFieldDataArray_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Adds an array to pass through.
		/// fieldType where the array that should be passed (point data, cell data, etc.).
		/// It should be one of the constants defined in the vtkDataObject::AttributeTypes
		/// enumeration.
		/// </summary>
		// Token: 0x060173A9 RID: 95145 RVA: 0x00209D0C File Offset: 0x00207F0C
		public virtual void AddFieldDataArray(string name)
		{
			vtkPassArrays.vtkPassArrays_AddFieldDataArray_03(base.GetCppThis(), name);
		}

		// Token: 0x060173AA RID: 95146
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPassArrays_AddFieldType_04(HandleRef pThis, int fieldType);

		/// <summary>
		/// Add a field type to process.
		/// fieldType where the array that should be passed (point data, cell data, etc.).
		/// It should be one of the constants defined in the vtkDataObject::AttributeTypes
		/// enumeration.
		/// NOTE: These are only used if UseFieldType is turned on.
		/// </summary>
		// Token: 0x060173AB RID: 95147 RVA: 0x00209D1C File Offset: 0x00207F1C
		public virtual void AddFieldType(int fieldType)
		{
			vtkPassArrays.vtkPassArrays_AddFieldType_04(base.GetCppThis(), fieldType);
		}

		// Token: 0x060173AC RID: 95148
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPassArrays_AddPointDataArray_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Adds an array to pass through.
		/// fieldType where the array that should be passed (point data, cell data, etc.).
		/// It should be one of the constants defined in the vtkDataObject::AttributeTypes
		/// enumeration.
		/// </summary>
		// Token: 0x060173AD RID: 95149 RVA: 0x00209D2C File Offset: 0x00207F2C
		public virtual void AddPointDataArray(string name)
		{
			vtkPassArrays.vtkPassArrays_AddPointDataArray_05(base.GetCppThis(), name);
		}

		// Token: 0x060173AE RID: 95150
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPassArrays_ClearArrays_06(HandleRef pThis);

		/// <summary>
		/// Clear all arrays to pass through.
		/// </summary>
		// Token: 0x060173AF RID: 95151 RVA: 0x00209D3C File Offset: 0x00207F3C
		public virtual void ClearArrays()
		{
			vtkPassArrays.vtkPassArrays_ClearArrays_06(base.GetCppThis());
		}

		// Token: 0x060173B0 RID: 95152
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPassArrays_ClearCellDataArrays_07(HandleRef pThis);

		/// <summary>
		/// Clear all arrays to pass through.
		/// </summary>
		// Token: 0x060173B1 RID: 95153 RVA: 0x00209D4B File Offset: 0x00207F4B
		public virtual void ClearCellDataArrays()
		{
			vtkPassArrays.vtkPassArrays_ClearCellDataArrays_07(base.GetCppThis());
		}

		// Token: 0x060173B2 RID: 95154
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPassArrays_ClearFieldDataArrays_08(HandleRef pThis);

		/// <summary>
		/// Clear all arrays to pass through.
		/// </summary>
		// Token: 0x060173B3 RID: 95155 RVA: 0x00209D5A File Offset: 0x00207F5A
		public virtual void ClearFieldDataArrays()
		{
			vtkPassArrays.vtkPassArrays_ClearFieldDataArrays_08(base.GetCppThis());
		}

		// Token: 0x060173B4 RID: 95156
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPassArrays_ClearFieldTypes_09(HandleRef pThis);

		/// <summary>
		/// Clear all field types to process.
		/// </summary>
		// Token: 0x060173B5 RID: 95157 RVA: 0x00209D69 File Offset: 0x00207F69
		public virtual void ClearFieldTypes()
		{
			vtkPassArrays.vtkPassArrays_ClearFieldTypes_09(base.GetCppThis());
		}

		// Token: 0x060173B6 RID: 95158
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPassArrays_ClearPointDataArrays_10(HandleRef pThis);

		/// <summary>
		/// Clear all arrays to pass through.
		/// </summary>
		// Token: 0x060173B7 RID: 95159 RVA: 0x00209D78 File Offset: 0x00207F78
		public virtual void ClearPointDataArrays()
		{
			vtkPassArrays.vtkPassArrays_ClearPointDataArrays_10(base.GetCppThis());
		}

		// Token: 0x060173B8 RID: 95160
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPassArrays_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060173B9 RID: 95161 RVA: 0x00209D88 File Offset: 0x00207F88
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPassArrays.vtkPassArrays_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x060173BA RID: 95162
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPassArrays_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060173BB RID: 95163 RVA: 0x00209DA8 File Offset: 0x00207FA8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPassArrays.vtkPassArrays_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x060173BC RID: 95164
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPassArrays_GetRemoveArrays_13(HandleRef pThis);

		/// <summary>
		/// Instead of passing only the specified arrays, remove the specified arrays
		/// and keep all other arrays. Default is off.
		/// </summary>
		// Token: 0x060173BD RID: 95165 RVA: 0x00209DC4 File Offset: 0x00207FC4
		public virtual bool GetRemoveArrays()
		{
			return vtkPassArrays.vtkPassArrays_GetRemoveArrays_13(base.GetCppThis()) != 0;
		}

		// Token: 0x060173BE RID: 95166
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPassArrays_GetUseFieldTypes_14(HandleRef pThis);

		/// <summary>
		/// Process only those field types explicitly specified with AddFieldType.
		/// Otherwise, processes field types associated with at least one specified
		/// array. Default is off.
		/// </summary>
		// Token: 0x060173BF RID: 95167 RVA: 0x00209DEC File Offset: 0x00207FEC
		public virtual bool GetUseFieldTypes()
		{
			return vtkPassArrays.vtkPassArrays_GetUseFieldTypes_14(base.GetCppThis()) != 0;
		}

		// Token: 0x060173C0 RID: 95168
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPassArrays_IsA_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060173C1 RID: 95169 RVA: 0x00209E14 File Offset: 0x00208014
		public override int IsA(string type)
		{
			return vtkPassArrays.vtkPassArrays_IsA_15(base.GetCppThis(), type);
		}

		// Token: 0x060173C2 RID: 95170
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPassArrays_IsTypeOf_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060173C3 RID: 95171 RVA: 0x00209E34 File Offset: 0x00208034
		public new static int IsTypeOf(string type)
		{
			return vtkPassArrays.vtkPassArrays_IsTypeOf_16(type);
		}

		// Token: 0x060173C4 RID: 95172
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPassArrays_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060173C5 RID: 95173 RVA: 0x00209E50 File Offset: 0x00208050
		public new vtkPassArrays NewInstance()
		{
			vtkPassArrays result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPassArrays.vtkPassArrays_NewInstance_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPassArrays)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060173C6 RID: 95174
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPassArrays_RemoveArray_19(HandleRef pThis, int fieldType, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Adds an array to pass through.
		/// fieldType where the array that should be passed (point data, cell data, etc.).
		/// It should be one of the constants defined in the vtkDataObject::AttributeTypes
		/// enumeration.
		/// </summary>
		// Token: 0x060173C7 RID: 95175 RVA: 0x00209EAA File Offset: 0x002080AA
		public virtual void RemoveArray(int fieldType, string name)
		{
			vtkPassArrays.vtkPassArrays_RemoveArray_19(base.GetCppThis(), fieldType, name);
		}

		// Token: 0x060173C8 RID: 95176
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPassArrays_RemoveArraysOff_20(HandleRef pThis);

		/// <summary>
		/// Instead of passing only the specified arrays, remove the specified arrays
		/// and keep all other arrays. Default is off.
		/// </summary>
		// Token: 0x060173C9 RID: 95177 RVA: 0x00209EBB File Offset: 0x002080BB
		public virtual void RemoveArraysOff()
		{
			vtkPassArrays.vtkPassArrays_RemoveArraysOff_20(base.GetCppThis());
		}

		// Token: 0x060173CA RID: 95178
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPassArrays_RemoveArraysOn_21(HandleRef pThis);

		/// <summary>
		/// Instead of passing only the specified arrays, remove the specified arrays
		/// and keep all other arrays. Default is off.
		/// </summary>
		// Token: 0x060173CB RID: 95179 RVA: 0x00209ECA File Offset: 0x002080CA
		public virtual void RemoveArraysOn()
		{
			vtkPassArrays.vtkPassArrays_RemoveArraysOn_21(base.GetCppThis());
		}

		// Token: 0x060173CC RID: 95180
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPassArrays_RemoveCellDataArray_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Adds an array to pass through.
		/// fieldType where the array that should be passed (point data, cell data, etc.).
		/// It should be one of the constants defined in the vtkDataObject::AttributeTypes
		/// enumeration.
		/// </summary>
		// Token: 0x060173CD RID: 95181 RVA: 0x00209ED9 File Offset: 0x002080D9
		public virtual void RemoveCellDataArray(string name)
		{
			vtkPassArrays.vtkPassArrays_RemoveCellDataArray_22(base.GetCppThis(), name);
		}

		// Token: 0x060173CE RID: 95182
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPassArrays_RemoveFieldDataArray_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Adds an array to pass through.
		/// fieldType where the array that should be passed (point data, cell data, etc.).
		/// It should be one of the constants defined in the vtkDataObject::AttributeTypes
		/// enumeration.
		/// </summary>
		// Token: 0x060173CF RID: 95183 RVA: 0x00209EE9 File Offset: 0x002080E9
		public virtual void RemoveFieldDataArray(string name)
		{
			vtkPassArrays.vtkPassArrays_RemoveFieldDataArray_23(base.GetCppThis(), name);
		}

		// Token: 0x060173D0 RID: 95184
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPassArrays_RemovePointDataArray_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Adds an array to pass through.
		/// fieldType where the array that should be passed (point data, cell data, etc.).
		/// It should be one of the constants defined in the vtkDataObject::AttributeTypes
		/// enumeration.
		/// </summary>
		// Token: 0x060173D1 RID: 95185 RVA: 0x00209EF9 File Offset: 0x002080F9
		public virtual void RemovePointDataArray(string name)
		{
			vtkPassArrays.vtkPassArrays_RemovePointDataArray_24(base.GetCppThis(), name);
		}

		// Token: 0x060173D2 RID: 95186
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPassArrays_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060173D3 RID: 95187 RVA: 0x00209F0C File Offset: 0x0020810C
		public new static vtkPassArrays SafeDownCast(vtkObjectBase o)
		{
			vtkPassArrays vtkPassArrays = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPassArrays.vtkPassArrays_SafeDownCast_25((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPassArrays = (vtkPassArrays)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPassArrays.Register(null);
				}
			}
			return vtkPassArrays;
		}

		// Token: 0x060173D4 RID: 95188
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPassArrays_SetRemoveArrays_26(HandleRef pThis, byte _arg);

		/// <summary>
		/// Instead of passing only the specified arrays, remove the specified arrays
		/// and keep all other arrays. Default is off.
		/// </summary>
		// Token: 0x060173D5 RID: 95189 RVA: 0x00209F8B File Offset: 0x0020818B
		public virtual void SetRemoveArrays(bool _arg)
		{
			vtkPassArrays.vtkPassArrays_SetRemoveArrays_26(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060173D6 RID: 95190
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPassArrays_SetUseFieldTypes_27(HandleRef pThis, byte _arg);

		/// <summary>
		/// Process only those field types explicitly specified with AddFieldType.
		/// Otherwise, processes field types associated with at least one specified
		/// array. Default is off.
		/// </summary>
		// Token: 0x060173D7 RID: 95191 RVA: 0x00209FA3 File Offset: 0x002081A3
		public virtual void SetUseFieldTypes(bool _arg)
		{
			vtkPassArrays.vtkPassArrays_SetUseFieldTypes_27(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060173D8 RID: 95192
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPassArrays_UseFieldTypesOff_28(HandleRef pThis);

		/// <summary>
		/// Process only those field types explicitly specified with AddFieldType.
		/// Otherwise, processes field types associated with at least one specified
		/// array. Default is off.
		/// </summary>
		// Token: 0x060173D9 RID: 95193 RVA: 0x00209FBB File Offset: 0x002081BB
		public virtual void UseFieldTypesOff()
		{
			vtkPassArrays.vtkPassArrays_UseFieldTypesOff_28(base.GetCppThis());
		}

		// Token: 0x060173DA RID: 95194
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPassArrays_UseFieldTypesOn_29(HandleRef pThis);

		/// <summary>
		/// Process only those field types explicitly specified with AddFieldType.
		/// Otherwise, processes field types associated with at least one specified
		/// array. Default is off.
		/// </summary>
		// Token: 0x060173DB RID: 95195 RVA: 0x00209FCA File Offset: 0x002081CA
		public virtual void UseFieldTypesOn()
		{
			vtkPassArrays.vtkPassArrays_UseFieldTypesOn_29(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A01 RID: 6657
		public new const string MRFullTypeName = "Kitware.VTK.vtkPassArrays";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A02 RID: 6658
		public new static readonly string MRClassNameKey = "class vtkPassArrays";
	}
}
