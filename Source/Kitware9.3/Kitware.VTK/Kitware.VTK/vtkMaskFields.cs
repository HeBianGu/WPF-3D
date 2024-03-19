using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMaskFields
	/// </summary>
	/// <remarks>
	///    Allow control of which fields get passed
	/// to the output
	///
	/// vtkMaskFields is used to mark which fields in the input dataset
	/// get copied to the output.  The output will contain only those fields
	/// marked as on by the filter.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkFieldData vtkDataSet vtkDataObjectToDataSetFilter
	/// vtkDataSetAttributes vtkDataArray vtkRearrangeFields
	/// vtkSplitField vtkMergeFields vtkAssignAttribute
	/// </seealso>
	// Token: 0x02000979 RID: 2425
	public class vtkMaskFields : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06019475 RID: 103541 RVA: 0x00233794 File Offset: 0x00231994
		static vtkMaskFields()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMaskFields.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMaskFields"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06019476 RID: 103542 RVA: 0x002337BC File Offset: 0x002319BC
		public vtkMaskFields(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06019477 RID: 103543
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMaskFields_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create a new vtkMaskFields.
		/// </summary>
		// Token: 0x06019478 RID: 103544 RVA: 0x002337CC File Offset: 0x002319CC
		public new static vtkMaskFields New()
		{
			vtkMaskFields result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMaskFields.vtkMaskFields_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMaskFields)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Create a new vtkMaskFields.
		/// </summary>
		// Token: 0x06019479 RID: 103545 RVA: 0x00233820 File Offset: 0x00231A20
		public vtkMaskFields() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMaskFields.vtkMaskFields_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601947A RID: 103546 RVA: 0x00233864 File Offset: 0x00231A64
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601947B RID: 103547
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMaskFields_CopyAllOff_01(HandleRef pThis);

		/// <summary>
		/// Turn off copying of all data.
		/// During the copying/passing, the following rules are followed for each
		/// array:
		/// 1. If the copy flag for an array is set (on or off), it is applied
		/// This overrides rule 2.
		/// 2. If CopyAllOn is set, copy the array.
		/// If CopyAllOff is set, do not copy the array
		/// </summary>
		// Token: 0x0601947C RID: 103548 RVA: 0x0023386F File Offset: 0x00231A6F
		public virtual void CopyAllOff()
		{
			vtkMaskFields.vtkMaskFields_CopyAllOff_01(base.GetCppThis());
		}

		// Token: 0x0601947D RID: 103549
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMaskFields_CopyAllOn_02(HandleRef pThis);

		/// <summary>
		/// Turn on copying of all data.
		/// During the copying/passing, the following rules are followed for each
		/// array:
		/// 1. If the copy flag for an array is set (on or off), it is applied
		/// This overrides rule 2.
		/// 2. If CopyAllOn is set, copy the array.
		/// If CopyAllOff is set, do not copy the array
		/// </summary>
		// Token: 0x0601947E RID: 103550 RVA: 0x0023387E File Offset: 0x00231A7E
		public virtual void CopyAllOn()
		{
			vtkMaskFields.vtkMaskFields_CopyAllOn_02(base.GetCppThis());
		}

		// Token: 0x0601947F RID: 103551
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMaskFields_CopyAttributeOff_03(HandleRef pThis, int attributeLocation, int attributeType);

		/// <summary>
		/// Turn on/off the copying of the attribute or specified by vtkDataSetAttributes:AttributeTypes.
		/// During the copying/passing, the following rules are followed for each
		/// array:
		/// 1. If the copy flag for an array is set (on or off), it is applied
		/// This overrides rule 2.
		/// 2. If CopyAllOn is set, copy the array.
		/// If CopyAllOff is set, do not copy the array
		/// An attribute type and a location must be specified. For example:
		/// @verbatim
		/// maskFields-&gt;CopyAttributeOff(vtkMaskFields::POINT_DATA, vtkDataSetAttributes::SCALARS);
		/// @endverbatim
		/// causes the scalars on the input point data to not get copied
		/// to the output.
		/// </summary>
		// Token: 0x06019480 RID: 103552 RVA: 0x0023388D File Offset: 0x00231A8D
		public void CopyAttributeOff(int attributeLocation, int attributeType)
		{
			vtkMaskFields.vtkMaskFields_CopyAttributeOff_03(base.GetCppThis(), attributeLocation, attributeType);
		}

		// Token: 0x06019481 RID: 103553
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMaskFields_CopyAttributeOff_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string attributeLoc, [MarshalAs(UnmanagedType.LPUTF8Str)] string attributeType);

		/// <summary>
		/// Helper methods used by other language bindings. Allows the caller to
		/// specify arguments as strings instead of enums.
		/// </summary>
		// Token: 0x06019482 RID: 103554 RVA: 0x0023389E File Offset: 0x00231A9E
		public void CopyAttributeOff(string attributeLoc, string attributeType)
		{
			vtkMaskFields.vtkMaskFields_CopyAttributeOff_04(base.GetCppThis(), attributeLoc, attributeType);
		}

		// Token: 0x06019483 RID: 103555
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMaskFields_CopyAttributeOn_05(HandleRef pThis, int attributeLocation, int attributeType);

		/// <summary>
		/// Turn on/off the copying of the attribute or specified by vtkDataSetAttributes:AttributeTypes.
		/// During the copying/passing, the following rules are followed for each
		/// array:
		/// 1. If the copy flag for an array is set (on or off), it is applied
		/// This overrides rule 2.
		/// 2. If CopyAllOn is set, copy the array.
		/// If CopyAllOff is set, do not copy the array
		/// An attribute type and a location must be specified. For example:
		/// @verbatim
		/// maskFields-&gt;CopyAttributeOff(vtkMaskFields::POINT_DATA, vtkDataSetAttributes::SCALARS);
		/// @endverbatim
		/// causes the scalars on the input point data to not get copied
		/// to the output.
		/// </summary>
		// Token: 0x06019484 RID: 103556 RVA: 0x002338AF File Offset: 0x00231AAF
		public void CopyAttributeOn(int attributeLocation, int attributeType)
		{
			vtkMaskFields.vtkMaskFields_CopyAttributeOn_05(base.GetCppThis(), attributeLocation, attributeType);
		}

		// Token: 0x06019485 RID: 103557
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMaskFields_CopyAttributeOn_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string attributeLoc, [MarshalAs(UnmanagedType.LPUTF8Str)] string attributeType);

		/// <summary>
		/// Helper methods used by other language bindings. Allows the caller to
		/// specify arguments as strings instead of enums.
		/// </summary>
		// Token: 0x06019486 RID: 103558 RVA: 0x002338C0 File Offset: 0x00231AC0
		public void CopyAttributeOn(string attributeLoc, string attributeType)
		{
			vtkMaskFields.vtkMaskFields_CopyAttributeOn_06(base.GetCppThis(), attributeLoc, attributeType);
		}

		// Token: 0x06019487 RID: 103559
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMaskFields_CopyAttributesOff_07(HandleRef pThis);

		/// <summary>
		/// Convenience methods which operate on all field data or
		/// attribute data.  More specific than CopyAllOn or CopyAllOff
		/// </summary>
		// Token: 0x06019488 RID: 103560 RVA: 0x002338D1 File Offset: 0x00231AD1
		public void CopyAttributesOff()
		{
			vtkMaskFields.vtkMaskFields_CopyAttributesOff_07(base.GetCppThis());
		}

		// Token: 0x06019489 RID: 103561
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMaskFields_CopyAttributesOn_08(HandleRef pThis);

		/// <summary>
		/// Convenience methods which operate on all field data or
		/// attribute data.  More specific than CopyAllOn or CopyAllOff
		/// </summary>
		// Token: 0x0601948A RID: 103562 RVA: 0x002338E0 File Offset: 0x00231AE0
		public void CopyAttributesOn()
		{
			vtkMaskFields.vtkMaskFields_CopyAttributesOn_08(base.GetCppThis());
		}

		// Token: 0x0601948B RID: 103563
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMaskFields_CopyFieldOff_09(HandleRef pThis, int fieldLocation, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Turn on/off the copying of the field or specified by name.
		/// During the copying/passing, the following rules are followed for each
		/// array:
		/// 1. If the copy flag for an array is set (on or off), it is applied
		/// This overrides rule 2.
		/// 2. If CopyAllOn is set, copy the array.
		/// If CopyAllOff is set, do not copy the array
		/// A field name and a location must be specified. For example:
		/// @verbatim
		/// maskFields-&gt;CopyFieldOff(vtkMaskFields::CELL_DATA, "foo");
		/// @endverbatim
		/// causes the field "foo" on the input cell data to not get copied
		/// to the output.
		/// </summary>
		// Token: 0x0601948C RID: 103564 RVA: 0x002338EF File Offset: 0x00231AEF
		public void CopyFieldOff(int fieldLocation, string name)
		{
			vtkMaskFields.vtkMaskFields_CopyFieldOff_09(base.GetCppThis(), fieldLocation, name);
		}

		// Token: 0x0601948D RID: 103565
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMaskFields_CopyFieldOff_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fieldLoc, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Helper methods used by other language bindings. Allows the caller to
		/// specify arguments as strings instead of enums.
		/// </summary>
		// Token: 0x0601948E RID: 103566 RVA: 0x00233900 File Offset: 0x00231B00
		public void CopyFieldOff(string fieldLoc, string name)
		{
			vtkMaskFields.vtkMaskFields_CopyFieldOff_10(base.GetCppThis(), fieldLoc, name);
		}

		// Token: 0x0601948F RID: 103567
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMaskFields_CopyFieldOn_11(HandleRef pThis, int fieldLocation, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Turn on/off the copying of the field or specified by name.
		/// During the copying/passing, the following rules are followed for each
		/// array:
		/// 1. If the copy flag for an array is set (on or off), it is applied
		/// This overrides rule 2.
		/// 2. If CopyAllOn is set, copy the array.
		/// If CopyAllOff is set, do not copy the array
		/// A field name and a location must be specified. For example:
		/// @verbatim
		/// maskFields-&gt;CopyFieldOff(vtkMaskFields::CELL_DATA, "foo");
		/// @endverbatim
		/// causes the field "foo" on the input cell data to not get copied
		/// to the output.
		/// </summary>
		// Token: 0x06019490 RID: 103568 RVA: 0x00233911 File Offset: 0x00231B11
		public void CopyFieldOn(int fieldLocation, string name)
		{
			vtkMaskFields.vtkMaskFields_CopyFieldOn_11(base.GetCppThis(), fieldLocation, name);
		}

		// Token: 0x06019491 RID: 103569
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMaskFields_CopyFieldOn_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fieldLoc, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Helper methods used by other language bindings. Allows the caller to
		/// specify arguments as strings instead of enums.
		/// </summary>
		// Token: 0x06019492 RID: 103570 RVA: 0x00233922 File Offset: 0x00231B22
		public void CopyFieldOn(string fieldLoc, string name)
		{
			vtkMaskFields.vtkMaskFields_CopyFieldOn_12(base.GetCppThis(), fieldLoc, name);
		}

		// Token: 0x06019493 RID: 103571
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMaskFields_CopyFieldsOff_13(HandleRef pThis);

		/// <summary>
		/// Convenience methods which operate on all field data or
		/// attribute data.  More specific than CopyAllOn or CopyAllOff
		/// </summary>
		// Token: 0x06019494 RID: 103572 RVA: 0x00233933 File Offset: 0x00231B33
		public void CopyFieldsOff()
		{
			vtkMaskFields.vtkMaskFields_CopyFieldsOff_13(base.GetCppThis());
		}

		// Token: 0x06019495 RID: 103573
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMaskFields_CopyFieldsOn_14(HandleRef pThis);

		/// <summary>
		/// Convenience methods which operate on all field data or
		/// attribute data.  More specific than CopyAllOn or CopyAllOff
		/// </summary>
		// Token: 0x06019496 RID: 103574 RVA: 0x00233942 File Offset: 0x00231B42
		public void CopyFieldsOn()
		{
			vtkMaskFields.vtkMaskFields_CopyFieldsOn_14(base.GetCppThis());
		}

		// Token: 0x06019497 RID: 103575
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMaskFields_GetNumberOfGenerationsFromBase_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019498 RID: 103576 RVA: 0x00233954 File Offset: 0x00231B54
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMaskFields.vtkMaskFields_GetNumberOfGenerationsFromBase_15(base.GetCppThis(), type);
		}

		// Token: 0x06019499 RID: 103577
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMaskFields_GetNumberOfGenerationsFromBaseType_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601949A RID: 103578 RVA: 0x00233974 File Offset: 0x00231B74
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMaskFields.vtkMaskFields_GetNumberOfGenerationsFromBaseType_16(type);
		}

		// Token: 0x0601949B RID: 103579
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMaskFields_IsA_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601949C RID: 103580 RVA: 0x00233990 File Offset: 0x00231B90
		public override int IsA(string type)
		{
			return vtkMaskFields.vtkMaskFields_IsA_17(base.GetCppThis(), type);
		}

		// Token: 0x0601949D RID: 103581
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMaskFields_IsTypeOf_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601949E RID: 103582 RVA: 0x002339B0 File Offset: 0x00231BB0
		public new static int IsTypeOf(string type)
		{
			return vtkMaskFields.vtkMaskFields_IsTypeOf_18(type);
		}

		// Token: 0x0601949F RID: 103583
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMaskFields_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060194A0 RID: 103584 RVA: 0x002339CC File Offset: 0x00231BCC
		public new vtkMaskFields NewInstance()
		{
			vtkMaskFields result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMaskFields.vtkMaskFields_NewInstance_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMaskFields)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060194A1 RID: 103585
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMaskFields_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060194A2 RID: 103586 RVA: 0x00233A28 File Offset: 0x00231C28
		public new static vtkMaskFields SafeDownCast(vtkObjectBase o)
		{
			vtkMaskFields vtkMaskFields = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMaskFields.vtkMaskFields_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMaskFields = (vtkMaskFields)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMaskFields.Register(null);
				}
			}
			return vtkMaskFields;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BAC RID: 7084
		public new const string MRFullTypeName = "Kitware.VTK.vtkMaskFields";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BAD RID: 7085
		public new static readonly string MRClassNameKey = "class vtkMaskFields";

		/// <summary>
		/// Turn off copying of all data.
		/// During the copying/passing, the following rules are followed for each
		/// array:
		/// 1. If the copy flag for an array is set (on or off), it is applied
		/// This overrides rule 2.
		/// 2. If CopyAllOn is set, copy the array.
		/// If CopyAllOff is set, do not copy the array
		/// </summary>
		// Token: 0x0200097A RID: 2426
		public enum FieldLocation
		{
			/// <summary>enum member</summary>
			// Token: 0x04001BAF RID: 7087
			CELL_DATA = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001BB0 RID: 7088
			OBJECT_DATA = 0,
			/// <summary>enum member</summary>
			// Token: 0x04001BB1 RID: 7089
			POINT_DATA
		}
	}
}
