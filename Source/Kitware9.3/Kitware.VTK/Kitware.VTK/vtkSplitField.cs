using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSplitField
	/// </summary>
	/// <remarks>
	///    Split a field into single component fields
	///
	/// vtkSplitField is used to split a multi-component field (vtkDataArray)
	/// into multiple single component fields. The new fields are put in
	/// the same field data as the original field. The output arrays
	/// are of the same type as the input array. Example:
	/// @verbatim
	/// sf-&gt;SetInputField("gradient", vtkSplitField::POINT_DATA);
	/// sf-&gt;Split(0, "firstcomponent");
	/// @endverbatim
	/// tells vtkSplitField to extract the first component of the field
	/// called gradient and create an array called firstcomponent (the
	/// new field will be in the output's point data).
	/// Note that, by default, the original array is also passed through.
	///
	/// @warning
	/// When using Java, Python or Visual Basic bindings, the array name
	/// can not be one of the  AttributeTypes when calling Split() which takes
	/// strings as arguments. The wrapped command will
	/// always assume the string corresponds to an attribute type when
	/// the argument is one of the AttributeTypes. In this situation,
	/// use the Split() which takes enums.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkFieldData vtkDataSet vtkDataObjectToDataSetFilter
	/// vtkDataSetAttributes vtkDataArray vtkRearrangeFields
	/// vtkAssignAttribute vtkMergeFields
	/// </seealso>
	// Token: 0x020008E5 RID: 2277
	public class vtkSplitField : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06017835 RID: 96309 RVA: 0x0020FDBB File Offset: 0x0020DFBB
		static vtkSplitField()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSplitField.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSplitField"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06017836 RID: 96310 RVA: 0x0020FDE3 File Offset: 0x0020DFE3
		public vtkSplitField(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06017837 RID: 96311
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSplitField_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create a new vtkSplitField.
		/// </summary>
		// Token: 0x06017838 RID: 96312 RVA: 0x0020FDF4 File Offset: 0x0020DFF4
		public new static vtkSplitField New()
		{
			vtkSplitField result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSplitField.vtkSplitField_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSplitField)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Create a new vtkSplitField.
		/// </summary>
		// Token: 0x06017839 RID: 96313 RVA: 0x0020FE48 File Offset: 0x0020E048
		public vtkSplitField() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSplitField.vtkSplitField_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601783A RID: 96314 RVA: 0x0020FE8C File Offset: 0x0020E08C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601783B RID: 96315
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSplitField_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601783C RID: 96316 RVA: 0x0020FE98 File Offset: 0x0020E098
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSplitField.vtkSplitField_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601783D RID: 96317
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSplitField_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601783E RID: 96318 RVA: 0x0020FEB8 File Offset: 0x0020E0B8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSplitField.vtkSplitField_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601783F RID: 96319
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSplitField_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017840 RID: 96320 RVA: 0x0020FED4 File Offset: 0x0020E0D4
		public override int IsA(string type)
		{
			return vtkSplitField.vtkSplitField_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06017841 RID: 96321
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSplitField_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017842 RID: 96322 RVA: 0x0020FEF4 File Offset: 0x0020E0F4
		public new static int IsTypeOf(string type)
		{
			return vtkSplitField.vtkSplitField_IsTypeOf_04(type);
		}

		// Token: 0x06017843 RID: 96323
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSplitField_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017844 RID: 96324 RVA: 0x0020FF10 File Offset: 0x0020E110
		public new vtkSplitField NewInstance()
		{
			vtkSplitField result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSplitField.vtkSplitField_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSplitField)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06017845 RID: 96325
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSplitField_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017846 RID: 96326 RVA: 0x0020FF6C File Offset: 0x0020E16C
		public new static vtkSplitField SafeDownCast(vtkObjectBase o)
		{
			vtkSplitField vtkSplitField = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSplitField.vtkSplitField_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSplitField = (vtkSplitField)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSplitField.Register(null);
				}
			}
			return vtkSplitField;
		}

		// Token: 0x06017847 RID: 96327
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplitField_SetInputField_08(HandleRef pThis, int attributeType, int fieldLoc);

		/// <summary>
		/// Use the given attribute in the field data given
		/// by fieldLoc as input.
		/// </summary>
		// Token: 0x06017848 RID: 96328 RVA: 0x0020FFEB File Offset: 0x0020E1EB
		public void SetInputField(int attributeType, int fieldLoc)
		{
			vtkSplitField.vtkSplitField_SetInputField_08(base.GetCppThis(), attributeType, fieldLoc);
		}

		// Token: 0x06017849 RID: 96329
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplitField_SetInputField_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int fieldLoc);

		/// <summary>
		/// Use the array with given name in the field data given
		/// by fieldLoc as input.
		/// </summary>
		// Token: 0x0601784A RID: 96330 RVA: 0x0020FFFC File Offset: 0x0020E1FC
		public void SetInputField(string name, int fieldLoc)
		{
			vtkSplitField.vtkSplitField_SetInputField_09(base.GetCppThis(), name, fieldLoc);
		}

		// Token: 0x0601784B RID: 96331
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplitField_SetInputField_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, [MarshalAs(UnmanagedType.LPUTF8Str)] string fieldLoc);

		/// <summary>
		/// Helper method used by other language bindings. Allows the caller to
		/// specify arguments as strings instead of enums.
		/// </summary>
		// Token: 0x0601784C RID: 96332 RVA: 0x0021000D File Offset: 0x0020E20D
		public void SetInputField(string name, string fieldLoc)
		{
			vtkSplitField.vtkSplitField_SetInputField_10(base.GetCppThis(), name, fieldLoc);
		}

		// Token: 0x0601784D RID: 96333
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplitField_Split_11(HandleRef pThis, int component, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName);

		/// <summary>
		/// Create a new array with the given component.
		/// </summary>
		// Token: 0x0601784E RID: 96334 RVA: 0x0021001E File Offset: 0x0020E21E
		public void Split(int component, string arrayName)
		{
			vtkSplitField.vtkSplitField_Split_11(base.GetCppThis(), component, arrayName);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A42 RID: 6722
		public new const string MRFullTypeName = "Kitware.VTK.vtkSplitField";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A43 RID: 6723
		public new static readonly string MRClassNameKey = "class vtkSplitField";

		/// <summary>
		/// Create a new array with the given component.
		/// </summary>
		// Token: 0x020008E6 RID: 2278
		public enum FieldLocations
		{
			/// <summary>enum member</summary>
			// Token: 0x04001A45 RID: 6725
			CELL_DATA = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001A46 RID: 6726
			DATA_OBJECT = 0,
			/// <summary>enum member</summary>
			// Token: 0x04001A47 RID: 6727
			POINT_DATA
		}
	}
}
