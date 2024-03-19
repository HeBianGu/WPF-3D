using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAddMembershipArray
	/// </summary>
	/// <remarks>
	///    Add an array to the output indicating
	/// membership within an input selection.
	///
	///
	/// This filter takes an input selection, vtkDataSetAttribute
	/// information, and data object and adds a bit array to the output
	/// vtkDataSetAttributes indicating whether each index was selected or not.
	/// </remarks>
	// Token: 0x0200066E RID: 1646
	public class vtkAddMembershipArray : vtkPassInputTypeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011C4D RID: 72781 RVA: 0x0018DAAD File Offset: 0x0018BCAD
		static vtkAddMembershipArray()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAddMembershipArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAddMembershipArray"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011C4E RID: 72782 RVA: 0x0018DAD5 File Offset: 0x0018BCD5
		public vtkAddMembershipArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011C4F RID: 72783
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAddMembershipArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011C50 RID: 72784 RVA: 0x0018DAE4 File Offset: 0x0018BCE4
		public new static vtkAddMembershipArray New()
		{
			vtkAddMembershipArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAddMembershipArray.vtkAddMembershipArray_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAddMembershipArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011C51 RID: 72785 RVA: 0x0018DB38 File Offset: 0x0018BD38
		public vtkAddMembershipArray() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAddMembershipArray.vtkAddMembershipArray_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011C52 RID: 72786 RVA: 0x0018DB7C File Offset: 0x0018BD7C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011C53 RID: 72787
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAddMembershipArray_GetFieldType_01(HandleRef pThis);

		/// <summary>
		/// The field type to add the membership array to.
		/// </summary>
		// Token: 0x06011C54 RID: 72788 RVA: 0x0018DB88 File Offset: 0x0018BD88
		public virtual int GetFieldType()
		{
			return vtkAddMembershipArray.vtkAddMembershipArray_GetFieldType_01(base.GetCppThis());
		}

		// Token: 0x06011C55 RID: 72789
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAddMembershipArray_GetFieldTypeMaxValue_02(HandleRef pThis);

		/// <summary>
		/// The field type to add the membership array to.
		/// </summary>
		// Token: 0x06011C56 RID: 72790 RVA: 0x0018DBA8 File Offset: 0x0018BDA8
		public virtual int GetFieldTypeMaxValue()
		{
			return vtkAddMembershipArray.vtkAddMembershipArray_GetFieldTypeMaxValue_02(base.GetCppThis());
		}

		// Token: 0x06011C57 RID: 72791
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAddMembershipArray_GetFieldTypeMinValue_03(HandleRef pThis);

		/// <summary>
		/// The field type to add the membership array to.
		/// </summary>
		// Token: 0x06011C58 RID: 72792 RVA: 0x0018DBC8 File Offset: 0x0018BDC8
		public virtual int GetFieldTypeMinValue()
		{
			return vtkAddMembershipArray.vtkAddMembershipArray_GetFieldTypeMinValue_03(base.GetCppThis());
		}

		// Token: 0x06011C59 RID: 72793
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAddMembershipArray_GetInputArrayName_04(HandleRef pThis);

		/// <summary>
		/// The name of the array added to the output vtkDataSetAttributes
		/// indicating membership. Defaults to "membership".
		/// </summary>
		// Token: 0x06011C5A RID: 72794 RVA: 0x0018DBE8 File Offset: 0x0018BDE8
		public virtual string GetInputArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkAddMembershipArray.vtkAddMembershipArray_GetInputArrayName_04(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06011C5B RID: 72795
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAddMembershipArray_GetInputValues_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The name of the array added to the output vtkDataSetAttributes
		/// indicating membership. Defaults to "membership".
		/// </summary>
		// Token: 0x06011C5C RID: 72796 RVA: 0x0018DC24 File Offset: 0x0018BE24
		public virtual vtkAbstractArray GetInputValues()
		{
			vtkAbstractArray vtkAbstractArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAddMembershipArray.vtkAddMembershipArray_GetInputValues_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractArray = (vtkAbstractArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractArray.Register(null);
				}
			}
			return vtkAbstractArray;
		}

		// Token: 0x06011C5D RID: 72797
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAddMembershipArray_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011C5E RID: 72798 RVA: 0x0018DC94 File Offset: 0x0018BE94
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAddMembershipArray.vtkAddMembershipArray_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x06011C5F RID: 72799
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAddMembershipArray_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011C60 RID: 72800 RVA: 0x0018DCB4 File Offset: 0x0018BEB4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAddMembershipArray.vtkAddMembershipArray_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x06011C61 RID: 72801
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAddMembershipArray_GetOutputArrayName_08(HandleRef pThis);

		/// <summary>
		/// The name of the array added to the output vtkDataSetAttributes
		/// indicating membership. Defaults to "membership".
		/// </summary>
		// Token: 0x06011C62 RID: 72802 RVA: 0x0018DCD0 File Offset: 0x0018BED0
		public virtual string GetOutputArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkAddMembershipArray.vtkAddMembershipArray_GetOutputArrayName_08(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06011C63 RID: 72803
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAddMembershipArray_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011C64 RID: 72804 RVA: 0x0018DD0C File Offset: 0x0018BF0C
		public override int IsA(string type)
		{
			return vtkAddMembershipArray.vtkAddMembershipArray_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x06011C65 RID: 72805
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAddMembershipArray_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011C66 RID: 72806 RVA: 0x0018DD2C File Offset: 0x0018BF2C
		public new static int IsTypeOf(string type)
		{
			return vtkAddMembershipArray.vtkAddMembershipArray_IsTypeOf_10(type);
		}

		// Token: 0x06011C67 RID: 72807
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAddMembershipArray_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011C68 RID: 72808 RVA: 0x0018DD48 File Offset: 0x0018BF48
		public new vtkAddMembershipArray NewInstance()
		{
			vtkAddMembershipArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAddMembershipArray.vtkAddMembershipArray_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAddMembershipArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011C69 RID: 72809
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAddMembershipArray_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011C6A RID: 72810 RVA: 0x0018DDA4 File Offset: 0x0018BFA4
		public new static vtkAddMembershipArray SafeDownCast(vtkObjectBase o)
		{
			vtkAddMembershipArray vtkAddMembershipArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAddMembershipArray.vtkAddMembershipArray_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAddMembershipArray = (vtkAddMembershipArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAddMembershipArray.Register(null);
				}
			}
			return vtkAddMembershipArray;
		}

		// Token: 0x06011C6B RID: 72811
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAddMembershipArray_SetFieldType_14(HandleRef pThis, int _arg);

		/// <summary>
		/// The field type to add the membership array to.
		/// </summary>
		// Token: 0x06011C6C RID: 72812 RVA: 0x0018DE23 File Offset: 0x0018C023
		public virtual void SetFieldType(int _arg)
		{
			vtkAddMembershipArray.vtkAddMembershipArray_SetFieldType_14(base.GetCppThis(), _arg);
		}

		// Token: 0x06011C6D RID: 72813
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAddMembershipArray_SetInputArrayName_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The name of the array added to the output vtkDataSetAttributes
		/// indicating membership. Defaults to "membership".
		/// </summary>
		// Token: 0x06011C6E RID: 72814 RVA: 0x0018DE33 File Offset: 0x0018C033
		public virtual void SetInputArrayName(string _arg)
		{
			vtkAddMembershipArray.vtkAddMembershipArray_SetInputArrayName_15(base.GetCppThis(), _arg);
		}

		// Token: 0x06011C6F RID: 72815
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAddMembershipArray_SetInputValues_16(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// The name of the array added to the output vtkDataSetAttributes
		/// indicating membership. Defaults to "membership".
		/// </summary>
		// Token: 0x06011C70 RID: 72816 RVA: 0x0018DE44 File Offset: 0x0018C044
		public void SetInputValues(vtkAbstractArray arg0)
		{
			vtkAddMembershipArray.vtkAddMembershipArray_SetInputValues_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06011C71 RID: 72817
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAddMembershipArray_SetOutputArrayName_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The name of the array added to the output vtkDataSetAttributes
		/// indicating membership. Defaults to "membership".
		/// </summary>
		// Token: 0x06011C72 RID: 72818 RVA: 0x0018DE73 File Offset: 0x0018C073
		public virtual void SetOutputArrayName(string _arg)
		{
			vtkAddMembershipArray.vtkAddMembershipArray_SetOutputArrayName_17(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001478 RID: 5240
		public new const string MRFullTypeName = "Kitware.VTK.vtkAddMembershipArray";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001479 RID: 5241
		public new static readonly string MRClassNameKey = "class vtkAddMembershipArray";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0200066F RID: 1647
		public enum CELL_DATA_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x0400147B RID: 5243
			CELL_DATA = 2,
			/// <summary>enum member</summary>
			// Token: 0x0400147C RID: 5244
			EDGE_DATA = 4,
			/// <summary>enum member</summary>
			// Token: 0x0400147D RID: 5245
			FIELD_DATA = 0,
			/// <summary>enum member</summary>
			// Token: 0x0400147E RID: 5246
			POINT_DATA,
			/// <summary>enum member</summary>
			// Token: 0x0400147F RID: 5247
			ROW_DATA = 5,
			/// <summary>enum member</summary>
			// Token: 0x04001480 RID: 5248
			VERTEX_DATA = 3
		}
	}
}
