using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAssignAttribute
	/// </summary>
	/// <remarks>
	///    Labels/marks a field as an attribute
	///
	/// vtkAssignAttribute is used to label/mark a field (vtkDataArray) as an attribute.
	/// A field name or an attribute to labeled can be specified. For example:
	/// @verbatim
	/// aa-&gt;Assign("foo", vtkDataSetAttributes::SCALARS,
	///            vtkAssignAttribute::POINT_DATA);
	/// @endverbatim
	/// tells vtkAssignAttribute to make the array in the point data called
	/// "foo" the active scalars. On the other hand,
	/// @verbatim
	/// aa-&gt;Assign(vtkDataSetAttributes::VECTORS, vtkDataSetAttributes::SCALARS,
	///            vtkAssignAttribute::POINT_DATA);
	/// @endverbatim
	/// tells vtkAssignAttribute to make the active vectors also the active
	/// scalars.
	///
	/// @warning
	/// When using Java, Python or Visual Basic bindings, the array name
	/// can not be one of the  AttributeTypes when calling Assign() which takes
	/// strings as arguments. The wrapped command will
	/// always assume the string corresponds to an attribute type when
	/// the argument is one of the AttributeTypes. In this situation,
	/// use the Assign() which takes enums.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkFieldData vtkDataSet vtkDataObjectToDataSetFilter
	/// vtkDataSetAttributes vtkDataArray vtkRearrangeFields
	/// vtkSplitField vtkMergeFields
	/// </seealso>
	// Token: 0x0200093F RID: 2367
	public class vtkAssignAttribute : vtkPassInputTypeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060188C2 RID: 100546 RVA: 0x00225033 File Offset: 0x00223233
		static vtkAssignAttribute()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAssignAttribute.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAssignAttribute"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060188C3 RID: 100547 RVA: 0x0022505B File Offset: 0x0022325B
		public vtkAssignAttribute(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060188C4 RID: 100548
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAssignAttribute_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create a new vtkAssignAttribute.
		/// </summary>
		// Token: 0x060188C5 RID: 100549 RVA: 0x0022506C File Offset: 0x0022326C
		public new static vtkAssignAttribute New()
		{
			vtkAssignAttribute result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAssignAttribute.vtkAssignAttribute_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAssignAttribute)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Create a new vtkAssignAttribute.
		/// </summary>
		// Token: 0x060188C6 RID: 100550 RVA: 0x002250C0 File Offset: 0x002232C0
		public vtkAssignAttribute() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAssignAttribute.vtkAssignAttribute_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060188C7 RID: 100551 RVA: 0x00225104 File Offset: 0x00223304
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060188C8 RID: 100552
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAssignAttribute_Assign_01(HandleRef pThis, int inputAttributeType, int attributeType, int attributeLoc);

		/// <summary>
		/// Label an attribute as another attribute.
		/// </summary>
		// Token: 0x060188C9 RID: 100553 RVA: 0x0022510F File Offset: 0x0022330F
		public void Assign(int inputAttributeType, int attributeType, int attributeLoc)
		{
			vtkAssignAttribute.vtkAssignAttribute_Assign_01(base.GetCppThis(), inputAttributeType, attributeType, attributeLoc);
		}

		// Token: 0x060188CA RID: 100554
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAssignAttribute_Assign_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fieldName, int attributeType, int attributeLoc);

		/// <summary>
		/// Label an array as an attribute.
		/// </summary>
		// Token: 0x060188CB RID: 100555 RVA: 0x00225121 File Offset: 0x00223321
		public void Assign(string fieldName, int attributeType, int attributeLoc)
		{
			vtkAssignAttribute.vtkAssignAttribute_Assign_02(base.GetCppThis(), fieldName, attributeType, attributeLoc);
		}

		// Token: 0x060188CC RID: 100556
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAssignAttribute_Assign_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, [MarshalAs(UnmanagedType.LPUTF8Str)] string attributeType, [MarshalAs(UnmanagedType.LPUTF8Str)] string attributeLoc);

		/// <summary>
		/// Helper method used by other language bindings. Allows the caller to
		/// specify arguments as strings instead of enums.
		/// </summary>
		// Token: 0x060188CD RID: 100557 RVA: 0x00225133 File Offset: 0x00223333
		public void Assign(string name, string attributeType, string attributeLoc)
		{
			vtkAssignAttribute.vtkAssignAttribute_Assign_03(base.GetCppThis(), name, attributeType, attributeLoc);
		}

		// Token: 0x060188CE RID: 100558
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAssignAttribute_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060188CF RID: 100559 RVA: 0x00225148 File Offset: 0x00223348
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAssignAttribute.vtkAssignAttribute_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x060188D0 RID: 100560
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAssignAttribute_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060188D1 RID: 100561 RVA: 0x00225168 File Offset: 0x00223368
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAssignAttribute.vtkAssignAttribute_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x060188D2 RID: 100562
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAssignAttribute_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060188D3 RID: 100563 RVA: 0x00225184 File Offset: 0x00223384
		public override int IsA(string type)
		{
			return vtkAssignAttribute.vtkAssignAttribute_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x060188D4 RID: 100564
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAssignAttribute_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060188D5 RID: 100565 RVA: 0x002251A4 File Offset: 0x002233A4
		public new static int IsTypeOf(string type)
		{
			return vtkAssignAttribute.vtkAssignAttribute_IsTypeOf_07(type);
		}

		// Token: 0x060188D6 RID: 100566
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAssignAttribute_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060188D7 RID: 100567 RVA: 0x002251C0 File Offset: 0x002233C0
		public new vtkAssignAttribute NewInstance()
		{
			vtkAssignAttribute result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAssignAttribute.vtkAssignAttribute_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAssignAttribute)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060188D8 RID: 100568
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAssignAttribute_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060188D9 RID: 100569 RVA: 0x0022521C File Offset: 0x0022341C
		public new static vtkAssignAttribute SafeDownCast(vtkObjectBase o)
		{
			vtkAssignAttribute vtkAssignAttribute = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAssignAttribute.vtkAssignAttribute_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAssignAttribute = (vtkAssignAttribute)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAssignAttribute.Register(null);
				}
			}
			return vtkAssignAttribute;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B2A RID: 6954
		public new const string MRFullTypeName = "Kitware.VTK.vtkAssignAttribute";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B2B RID: 6955
		public new static readonly string MRClassNameKey = "class vtkAssignAttribute";

		/// <summary>
		/// Helper method used by other language bindings. Allows the caller to
		/// specify arguments as strings instead of enums.
		/// </summary>
		// Token: 0x02000940 RID: 2368
		public enum AttributeLocation
		{
			/// <summary>enum member</summary>
			// Token: 0x04001B2D RID: 6957
			CELL_DATA = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001B2E RID: 6958
			EDGE_DATA = 3,
			/// <summary>enum member</summary>
			// Token: 0x04001B2F RID: 6959
			NUM_ATTRIBUTE_LOCS,
			/// <summary>enum member</summary>
			// Token: 0x04001B30 RID: 6960
			POINT_DATA = 0,
			/// <summary>enum member</summary>
			// Token: 0x04001B31 RID: 6961
			VERTEX_DATA = 2
		}
	}
}
