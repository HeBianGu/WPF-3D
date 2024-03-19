using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMergeFields
	/// </summary>
	/// <remarks>
	///    Merge multiple fields into one.
	///
	/// vtkMergeFields is used to merge multiple field into one.
	/// The new field is put in the same field data as the original field.
	/// For example
	/// @verbatim
	/// mf-&gt;SetOutputField("foo", vtkMergeFields::POINT_DATA);
	/// mf-&gt;SetNumberOfComponents(2);
	/// mf-&gt;Merge(0, "array1", 1);
	/// mf-&gt;Merge(1, "array2", 0);
	/// @endverbatim
	/// will tell vtkMergeFields to use the 2nd component of array1 and
	/// the 1st component of array2 to create a 2 component field called foo.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkFieldData vtkDataSet vtkDataObjectToDataSetFilter
	/// vtkDataSetAttributes vtkDataArray vtkRearrangeFields
	/// vtkSplitField vtkAssignAttribute
	/// </seealso>
	// Token: 0x0200097E RID: 2430
	public class vtkMergeFields : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601950F RID: 103695 RVA: 0x00234494 File Offset: 0x00232694
		static vtkMergeFields()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMergeFields.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMergeFields"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06019510 RID: 103696 RVA: 0x002344BC File Offset: 0x002326BC
		public vtkMergeFields(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06019511 RID: 103697
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMergeFields_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create a new vtkMergeFields.
		/// </summary>
		// Token: 0x06019512 RID: 103698 RVA: 0x002344CC File Offset: 0x002326CC
		public new static vtkMergeFields New()
		{
			vtkMergeFields result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMergeFields.vtkMergeFields_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMergeFields)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Create a new vtkMergeFields.
		/// </summary>
		// Token: 0x06019513 RID: 103699 RVA: 0x00234520 File Offset: 0x00232720
		public vtkMergeFields() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMergeFields.vtkMergeFields_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06019514 RID: 103700 RVA: 0x00234564 File Offset: 0x00232764
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06019515 RID: 103701
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMergeFields_GetNumberOfComponents_01(HandleRef pThis);

		/// <summary>
		/// Set the number of the components in the output field.
		/// This has to be set before execution. Default value is 0.
		/// </summary>
		// Token: 0x06019516 RID: 103702 RVA: 0x00234570 File Offset: 0x00232770
		public virtual int GetNumberOfComponents()
		{
			return vtkMergeFields.vtkMergeFields_GetNumberOfComponents_01(base.GetCppThis());
		}

		// Token: 0x06019517 RID: 103703
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMergeFields_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019518 RID: 103704 RVA: 0x00234590 File Offset: 0x00232790
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMergeFields.vtkMergeFields_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06019519 RID: 103705
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMergeFields_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601951A RID: 103706 RVA: 0x002345B0 File Offset: 0x002327B0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMergeFields.vtkMergeFields_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601951B RID: 103707
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMergeFields_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601951C RID: 103708 RVA: 0x002345CC File Offset: 0x002327CC
		public override int IsA(string type)
		{
			return vtkMergeFields.vtkMergeFields_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0601951D RID: 103709
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMergeFields_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601951E RID: 103710 RVA: 0x002345EC File Offset: 0x002327EC
		public new static int IsTypeOf(string type)
		{
			return vtkMergeFields.vtkMergeFields_IsTypeOf_05(type);
		}

		// Token: 0x0601951F RID: 103711
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeFields_Merge_06(HandleRef pThis, int component, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, int sourceComp);

		/// <summary>
		/// Add a component (arrayName,sourceComp) to the output field.
		/// </summary>
		// Token: 0x06019520 RID: 103712 RVA: 0x00234606 File Offset: 0x00232806
		public void Merge(int component, string arrayName, int sourceComp)
		{
			vtkMergeFields.vtkMergeFields_Merge_06(base.GetCppThis(), component, arrayName, sourceComp);
		}

		// Token: 0x06019521 RID: 103713
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMergeFields_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019522 RID: 103714 RVA: 0x00234618 File Offset: 0x00232818
		public new vtkMergeFields NewInstance()
		{
			vtkMergeFields result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMergeFields.vtkMergeFields_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMergeFields)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06019523 RID: 103715
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMergeFields_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019524 RID: 103716 RVA: 0x00234674 File Offset: 0x00232874
		public new static vtkMergeFields SafeDownCast(vtkObjectBase o)
		{
			vtkMergeFields vtkMergeFields = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMergeFields.vtkMergeFields_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMergeFields = (vtkMergeFields)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMergeFields.Register(null);
				}
			}
			return vtkMergeFields;
		}

		// Token: 0x06019525 RID: 103717
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeFields_SetNumberOfComponents_10(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the number of the components in the output field.
		/// This has to be set before execution. Default value is 0.
		/// </summary>
		// Token: 0x06019526 RID: 103718 RVA: 0x002346F3 File Offset: 0x002328F3
		public virtual void SetNumberOfComponents(int _arg)
		{
			vtkMergeFields.vtkMergeFields_SetNumberOfComponents_10(base.GetCppThis(), _arg);
		}

		// Token: 0x06019527 RID: 103719
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeFields_SetOutputField_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int fieldLoc);

		/// <summary>
		/// The output field will have the given name and it will be in
		/// fieldLoc (the input fields also have to be in fieldLoc).
		/// </summary>
		// Token: 0x06019528 RID: 103720 RVA: 0x00234703 File Offset: 0x00232903
		public void SetOutputField(string name, int fieldLoc)
		{
			vtkMergeFields.vtkMergeFields_SetOutputField_11(base.GetCppThis(), name, fieldLoc);
		}

		// Token: 0x06019529 RID: 103721
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeFields_SetOutputField_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, [MarshalAs(UnmanagedType.LPUTF8Str)] string fieldLoc);

		/// <summary>
		/// Helper method used by the other language bindings. Allows the caller to
		/// specify arguments as strings instead of enums.Returns an operation id
		/// which can later be used to remove the operation.
		/// </summary>
		// Token: 0x0601952A RID: 103722 RVA: 0x00234714 File Offset: 0x00232914
		public void SetOutputField(string name, string fieldLoc)
		{
			vtkMergeFields.vtkMergeFields_SetOutputField_12(base.GetCppThis(), name, fieldLoc);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BB8 RID: 7096
		public new const string MRFullTypeName = "Kitware.VTK.vtkMergeFields";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BB9 RID: 7097
		public new static readonly string MRClassNameKey = "class vtkMergeFields";

		/// <summary>
		/// Set the number of the components in the output field.
		/// This has to be set before execution. Default value is 0.
		/// </summary>
		// Token: 0x0200097F RID: 2431
		public enum FieldLocations
		{
			/// <summary>enum member</summary>
			// Token: 0x04001BBB RID: 7099
			CELL_DATA = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001BBC RID: 7100
			DATA_OBJECT = 0,
			/// <summary>enum member</summary>
			// Token: 0x04001BBD RID: 7101
			POINT_DATA
		}
	}
}
