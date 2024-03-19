using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAppendSelection
	/// </summary>
	/// <remarks>
	///    appends one or more selections together
	///
	/// vtkAppendSelection is a filter that appends one of more selections into
	/// a single selection.
	///
	/// If AppendByUnion is true, all selections must have the same content
	/// type and they are combined together to form a single vtkSelection output.
	///
	/// If AppendByUnion is false, the output is a composite selection with
	/// input selections as the children of the composite selection. This allows
	/// for selections with different content types and properties.
	///
	/// If AppendByUnion is true, an Expression can be defined which uses the input
	/// selection names to define the relation between the selections. If the Expression
	/// is not defined, all the selection are combined using the '| 'boolean operator.
	///
	/// @warning It should be noted that this filter is not responsible for checking if
	/// the field type is the same across all selections nodes of all selections.
	/// </remarks>
	// Token: 0x0200093B RID: 2363
	public class vtkAppendSelection : vtkSelectionAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06018788 RID: 100232 RVA: 0x00223AAA File Offset: 0x00221CAA
		static vtkAppendSelection()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAppendSelection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAppendSelection"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06018789 RID: 100233 RVA: 0x00223AD2 File Offset: 0x00221CD2
		public vtkAppendSelection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601878A RID: 100234
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAppendSelection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601878B RID: 100235 RVA: 0x00223AE0 File Offset: 0x00221CE0
		public new static vtkAppendSelection New()
		{
			vtkAppendSelection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAppendSelection.vtkAppendSelection_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAppendSelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601878C RID: 100236 RVA: 0x00223B34 File Offset: 0x00221D34
		public vtkAppendSelection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAppendSelection.vtkAppendSelection_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601878D RID: 100237 RVA: 0x00223B78 File Offset: 0x00221D78
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601878E RID: 100238
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendSelection_AddInputData_01(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Add a dataset to the list of data to append. Should not be
		/// used when UserManagedInputs is true, use SetInputByNumber instead.
		/// </summary>
		// Token: 0x0601878F RID: 100239 RVA: 0x00223B84 File Offset: 0x00221D84
		public void AddInputData(vtkSelection arg0)
		{
			vtkAppendSelection.vtkAppendSelection_AddInputData_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06018790 RID: 100240
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendSelection_AppendByUnionOff_02(HandleRef pThis);

		/// <summary>
		/// When set to true, all the selections are combined together to form a single
		/// vtkSelection output.
		/// When set to false, the output is a composite selection with
		/// input selections as the children of the composite selection. This allows
		/// for selections with different content types and properties.
		///
		/// The default is true.
		/// </summary>
		// Token: 0x06018791 RID: 100241 RVA: 0x00223BB3 File Offset: 0x00221DB3
		public virtual void AppendByUnionOff()
		{
			vtkAppendSelection.vtkAppendSelection_AppendByUnionOff_02(base.GetCppThis());
		}

		// Token: 0x06018792 RID: 100242
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendSelection_AppendByUnionOn_03(HandleRef pThis);

		/// <summary>
		/// When set to true, all the selections are combined together to form a single
		/// vtkSelection output.
		/// When set to false, the output is a composite selection with
		/// input selections as the children of the composite selection. This allows
		/// for selections with different content types and properties.
		///
		/// The default is true.
		/// </summary>
		// Token: 0x06018793 RID: 100243 RVA: 0x00223BC2 File Offset: 0x00221DC2
		public virtual void AppendByUnionOn()
		{
			vtkAppendSelection.vtkAppendSelection_AppendByUnionOn_03(base.GetCppThis());
		}

		// Token: 0x06018794 RID: 100244
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAppendSelection_GetAppendByUnion_04(HandleRef pThis);

		/// <summary>
		/// When set to true, all the selections are combined together to form a single
		/// vtkSelection output.
		/// When set to false, the output is a composite selection with
		/// input selections as the children of the composite selection. This allows
		/// for selections with different content types and properties.
		///
		/// The default is true.
		/// </summary>
		// Token: 0x06018795 RID: 100245 RVA: 0x00223BD4 File Offset: 0x00221DD4
		public virtual int GetAppendByUnion()
		{
			return vtkAppendSelection.vtkAppendSelection_GetAppendByUnion_04(base.GetCppThis());
		}

		// Token: 0x06018796 RID: 100246
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAppendSelection_GetColorArrayName_05();

		/// <summary>
		/// Return the specific name used for the selection color array.
		/// </summary>
		// Token: 0x06018797 RID: 100247 RVA: 0x00223BF4 File Offset: 0x00221DF4
		public static string GetColorArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkAppendSelection.vtkAppendSelection_GetColorArrayName_05());
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06018798 RID: 100248
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAppendSelection_GetExpression_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the expression that defines the boolean expression to combine the
		/// selections. Expression consists of node name identifiers, `|` for
		/// boolean-or, '^' for boolean-xor, '&amp;' for boolean and, '!' for boolean not,
		/// and parenthesis `(` and `)`. If you want to set the expression, be sure to
		/// define the node names. If no expression is specified and there are multiple
		/// selections, then the default expression simply combines all the selection nodes
		/// using an `or` operator.
		///
		/// `SetExpression` does not validate the expression. It will be validated
		/// `internally.
		///
		/// NOTE: If you want to use the expression, AppendByUnion MUST be set to false,
		/// and the input selection names MUST be defined.
		/// </summary>
		// Token: 0x06018799 RID: 100249 RVA: 0x00223C28 File Offset: 0x00221E28
		public virtual string GetExpression()
		{
			string s = Marshal.PtrToStringAnsi(vtkAppendSelection.vtkAppendSelection_GetExpression_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601879A RID: 100250
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAppendSelection_GetInput_07(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get any input of this filter.
		/// </summary>
		// Token: 0x0601879B RID: 100251 RVA: 0x00223C64 File Offset: 0x00221E64
		public vtkSelection GetInput(int idx)
		{
			vtkSelection vtkSelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAppendSelection.vtkAppendSelection_GetInput_07(base.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSelection = (vtkSelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSelection.Register(null);
				}
			}
			return vtkSelection;
		}

		// Token: 0x0601879C RID: 100252
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAppendSelection_GetInput_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get any input of this filter.
		/// </summary>
		// Token: 0x0601879D RID: 100253 RVA: 0x00223CD4 File Offset: 0x00221ED4
		public vtkSelection GetInput()
		{
			vtkSelection vtkSelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAppendSelection.vtkAppendSelection_GetInput_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSelection = (vtkSelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSelection.Register(null);
				}
			}
			return vtkSelection;
		}

		// Token: 0x0601879E RID: 100254
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAppendSelection_GetInputColor_09(HandleRef pThis, int index);

		/// <summary>
		/// Set/Get colors for inputs selections.
		///
		/// Assign a color to a selection specified by its index.
		/// If defined, the given color will be used to display this selection.
		/// </summary>
		// Token: 0x0601879F RID: 100255 RVA: 0x00223D44 File Offset: 0x00221F44
		public IntPtr GetInputColor(int index)
		{
			return vtkAppendSelection.vtkAppendSelection_GetInputColor_09(base.GetCppThis(), index);
		}

		// Token: 0x060187A0 RID: 100256
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAppendSelection_GetInputName_10(HandleRef pThis, int index);

		/// <summary>
		/// Set/Get names for inputs selections.
		///
		/// NOTE: Input selection names are useful only if you have set the Expression, and
		/// AppendByUnion is set to false.
		/// </summary>
		// Token: 0x060187A1 RID: 100257 RVA: 0x00223D64 File Offset: 0x00221F64
		public string GetInputName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkAppendSelection.vtkAppendSelection_GetInputName_10(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060187A2 RID: 100258
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAppendSelection_GetInverse_11(HandleRef pThis);

		/// <summary>
		/// Determines whether the selection describes what to include or exclude.
		///
		/// The default is false, meaning include.
		///
		/// NOTE: If you want to use Inverse, AppendByUnion MUST be set to false.
		/// If Expression is set, then the inverse flag inverses it (internally) without modifying it.
		/// </summary>
		// Token: 0x060187A3 RID: 100259 RVA: 0x00223DA0 File Offset: 0x00221FA0
		public virtual bool GetInverse()
		{
			return vtkAppendSelection.vtkAppendSelection_GetInverse_11(base.GetCppThis()) != 0;
		}

		// Token: 0x060187A4 RID: 100260
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAppendSelection_GetNumberOfGenerationsFromBase_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060187A5 RID: 100261 RVA: 0x00223DC8 File Offset: 0x00221FC8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAppendSelection.vtkAppendSelection_GetNumberOfGenerationsFromBase_12(base.GetCppThis(), type);
		}

		// Token: 0x060187A6 RID: 100262
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAppendSelection_GetNumberOfGenerationsFromBaseType_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060187A7 RID: 100263 RVA: 0x00223DE8 File Offset: 0x00221FE8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAppendSelection.vtkAppendSelection_GetNumberOfGenerationsFromBaseType_13(type);
		}

		// Token: 0x060187A8 RID: 100264
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAppendSelection_GetUserManagedInputs_14(HandleRef pThis);

		/// <summary>
		/// UserManagedInputs allows the user to set inputs by number instead of
		/// using the AddInput/RemoveInput functions. Calls to
		/// SetNumberOfInputs/SetInputByNumber should not be mixed with calls
		/// to AddInput/RemoveInput.
		///
		/// The default is false.
		/// </summary>
		// Token: 0x060187A9 RID: 100265 RVA: 0x00223E04 File Offset: 0x00222004
		public virtual int GetUserManagedInputs()
		{
			return vtkAppendSelection.vtkAppendSelection_GetUserManagedInputs_14(base.GetCppThis());
		}

		// Token: 0x060187AA RID: 100266
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendSelection_InverseOff_15(HandleRef pThis);

		/// <summary>
		/// Determines whether the selection describes what to include or exclude.
		///
		/// The default is false, meaning include.
		///
		/// NOTE: If you want to use Inverse, AppendByUnion MUST be set to false.
		/// If Expression is set, then the inverse flag inverses it (internally) without modifying it.
		/// </summary>
		// Token: 0x060187AB RID: 100267 RVA: 0x00223E23 File Offset: 0x00222023
		public virtual void InverseOff()
		{
			vtkAppendSelection.vtkAppendSelection_InverseOff_15(base.GetCppThis());
		}

		// Token: 0x060187AC RID: 100268
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendSelection_InverseOn_16(HandleRef pThis);

		/// <summary>
		/// Determines whether the selection describes what to include or exclude.
		///
		/// The default is false, meaning include.
		///
		/// NOTE: If you want to use Inverse, AppendByUnion MUST be set to false.
		/// If Expression is set, then the inverse flag inverses it (internally) without modifying it.
		/// </summary>
		// Token: 0x060187AD RID: 100269 RVA: 0x00223E32 File Offset: 0x00222032
		public virtual void InverseOn()
		{
			vtkAppendSelection.vtkAppendSelection_InverseOn_16(base.GetCppThis());
		}

		// Token: 0x060187AE RID: 100270
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAppendSelection_IsA_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060187AF RID: 100271 RVA: 0x00223E44 File Offset: 0x00222044
		public override int IsA(string type)
		{
			return vtkAppendSelection.vtkAppendSelection_IsA_17(base.GetCppThis(), type);
		}

		// Token: 0x060187B0 RID: 100272
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAppendSelection_IsTypeOf_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060187B1 RID: 100273 RVA: 0x00223E64 File Offset: 0x00222064
		public new static int IsTypeOf(string type)
		{
			return vtkAppendSelection.vtkAppendSelection_IsTypeOf_18(type);
		}

		// Token: 0x060187B2 RID: 100274
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAppendSelection_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060187B3 RID: 100275 RVA: 0x00223E80 File Offset: 0x00222080
		public new vtkAppendSelection NewInstance()
		{
			vtkAppendSelection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAppendSelection.vtkAppendSelection_NewInstance_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAppendSelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060187B4 RID: 100276
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendSelection_RemoveAllInputColors_21(HandleRef pThis);

		/// <summary>
		/// Remove all assigned input selection colors.
		/// </summary>
		// Token: 0x060187B5 RID: 100277 RVA: 0x00223EDA File Offset: 0x002220DA
		public void RemoveAllInputColors()
		{
			vtkAppendSelection.vtkAppendSelection_RemoveAllInputColors_21(base.GetCppThis());
		}

		// Token: 0x060187B6 RID: 100278
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendSelection_RemoveAllInputNames_22(HandleRef pThis);

		/// <summary>
		/// Remove all assigned input selection names.
		/// </summary>
		// Token: 0x060187B7 RID: 100279 RVA: 0x00223EE9 File Offset: 0x002220E9
		public void RemoveAllInputNames()
		{
			vtkAppendSelection.vtkAppendSelection_RemoveAllInputNames_22(base.GetCppThis());
		}

		// Token: 0x060187B8 RID: 100280
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendSelection_RemoveInputData_23(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Remove a dataset from the list of data to append. Should not be
		/// used when UserManagedInputs is true, use SetInputByNumber (nullptr) instead.
		/// </summary>
		// Token: 0x060187B9 RID: 100281 RVA: 0x00223EF8 File Offset: 0x002220F8
		public void RemoveInputData(vtkSelection arg0)
		{
			vtkAppendSelection.vtkAppendSelection_RemoveInputData_23(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060187BA RID: 100282
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAppendSelection_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060187BB RID: 100283 RVA: 0x00223F28 File Offset: 0x00222128
		public new static vtkAppendSelection SafeDownCast(vtkObjectBase o)
		{
			vtkAppendSelection vtkAppendSelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAppendSelection.vtkAppendSelection_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAppendSelection = (vtkAppendSelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAppendSelection.Register(null);
				}
			}
			return vtkAppendSelection;
		}

		// Token: 0x060187BC RID: 100284
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendSelection_SetAppendByUnion_25(HandleRef pThis, int _arg);

		/// <summary>
		/// When set to true, all the selections are combined together to form a single
		/// vtkSelection output.
		/// When set to false, the output is a composite selection with
		/// input selections as the children of the composite selection. This allows
		/// for selections with different content types and properties.
		///
		/// The default is true.
		/// </summary>
		// Token: 0x060187BD RID: 100285 RVA: 0x00223FA7 File Offset: 0x002221A7
		public virtual void SetAppendByUnion(int _arg)
		{
			vtkAppendSelection.vtkAppendSelection_SetAppendByUnion_25(base.GetCppThis(), _arg);
		}

		// Token: 0x060187BE RID: 100286
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendSelection_SetExpression_26(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg);

		/// <summary>
		/// Set/Get the expression that defines the boolean expression to combine the
		/// selections. Expression consists of node name identifiers, `|` for
		/// boolean-or, '^' for boolean-xor, '&amp;' for boolean and, '!' for boolean not,
		/// and parenthesis `(` and `)`. If you want to set the expression, be sure to
		/// define the node names. If no expression is specified and there are multiple
		/// selections, then the default expression simply combines all the selection nodes
		/// using an `or` operator.
		///
		/// `SetExpression` does not validate the expression. It will be validated
		/// `internally.
		///
		/// NOTE: If you want to use the expression, AppendByUnion MUST be set to false,
		/// and the input selection names MUST be defined.
		/// </summary>
		// Token: 0x060187BF RID: 100287 RVA: 0x00223FB7 File Offset: 0x002221B7
		public virtual void SetExpression(string arg)
		{
			vtkAppendSelection.vtkAppendSelection_SetExpression_26(base.GetCppThis(), arg);
		}

		// Token: 0x060187C0 RID: 100288
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendSelection_SetInputColor_27(HandleRef pThis, int index, double r, double g, double b);

		/// <summary>
		/// Set/Get colors for inputs selections.
		///
		/// Assign a color to a selection specified by its index.
		/// If defined, the given color will be used to display this selection.
		/// </summary>
		// Token: 0x060187C1 RID: 100289 RVA: 0x00223FC7 File Offset: 0x002221C7
		public void SetInputColor(int index, double r, double g, double b)
		{
			vtkAppendSelection.vtkAppendSelection_SetInputColor_27(base.GetCppThis(), index, r, g, b);
		}

		// Token: 0x060187C2 RID: 100290
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendSelection_SetInputConnectionByNumber_28(HandleRef pThis, int num, HandleRef input);

		/// <summary>
		/// Directly set(allocate) number of inputs, should only be used
		/// when UserManagedInputs is true.
		/// </summary>
		// Token: 0x060187C3 RID: 100291 RVA: 0x00223FDC File Offset: 0x002221DC
		public void SetInputConnectionByNumber(int num, vtkAlgorithmOutput input)
		{
			vtkAppendSelection.vtkAppendSelection_SetInputConnectionByNumber_28(base.GetCppThis(), num, (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x060187C4 RID: 100292
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendSelection_SetInputName_29(HandleRef pThis, int index, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Set/Get names for inputs selections.
		///
		/// NOTE: Input selection names are useful only if you have set the Expression, and
		/// AppendByUnion is set to false.
		/// </summary>
		// Token: 0x060187C5 RID: 100293 RVA: 0x0022400C File Offset: 0x0022220C
		public void SetInputName(int index, string name)
		{
			vtkAppendSelection.vtkAppendSelection_SetInputName_29(base.GetCppThis(), index, name);
		}

		// Token: 0x060187C6 RID: 100294
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendSelection_SetInverse_30(HandleRef pThis, byte _arg);

		/// <summary>
		/// Determines whether the selection describes what to include or exclude.
		///
		/// The default is false, meaning include.
		///
		/// NOTE: If you want to use Inverse, AppendByUnion MUST be set to false.
		/// If Expression is set, then the inverse flag inverses it (internally) without modifying it.
		/// </summary>
		// Token: 0x060187C7 RID: 100295 RVA: 0x0022401D File Offset: 0x0022221D
		public virtual void SetInverse(bool _arg)
		{
			vtkAppendSelection.vtkAppendSelection_SetInverse_30(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060187C8 RID: 100296
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendSelection_SetNumberOfInputs_31(HandleRef pThis, int num);

		/// <summary>
		/// Directly set(allocate) number of inputs, should only be used
		/// when UserManagedInputs is true.
		/// </summary>
		// Token: 0x060187C9 RID: 100297 RVA: 0x00224035 File Offset: 0x00222235
		public void SetNumberOfInputs(int num)
		{
			vtkAppendSelection.vtkAppendSelection_SetNumberOfInputs_31(base.GetCppThis(), num);
		}

		// Token: 0x060187CA RID: 100298
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendSelection_SetUserManagedInputs_32(HandleRef pThis, int _arg);

		/// <summary>
		/// UserManagedInputs allows the user to set inputs by number instead of
		/// using the AddInput/RemoveInput functions. Calls to
		/// SetNumberOfInputs/SetInputByNumber should not be mixed with calls
		/// to AddInput/RemoveInput.
		///
		/// The default is false.
		/// </summary>
		// Token: 0x060187CB RID: 100299 RVA: 0x00224045 File Offset: 0x00222245
		public virtual void SetUserManagedInputs(int _arg)
		{
			vtkAppendSelection.vtkAppendSelection_SetUserManagedInputs_32(base.GetCppThis(), _arg);
		}

		// Token: 0x060187CC RID: 100300
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendSelection_UserManagedInputsOff_33(HandleRef pThis);

		/// <summary>
		/// UserManagedInputs allows the user to set inputs by number instead of
		/// using the AddInput/RemoveInput functions. Calls to
		/// SetNumberOfInputs/SetInputByNumber should not be mixed with calls
		/// to AddInput/RemoveInput.
		///
		/// The default is false.
		/// </summary>
		// Token: 0x060187CD RID: 100301 RVA: 0x00224055 File Offset: 0x00222255
		public virtual void UserManagedInputsOff()
		{
			vtkAppendSelection.vtkAppendSelection_UserManagedInputsOff_33(base.GetCppThis());
		}

		// Token: 0x060187CE RID: 100302
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendSelection_UserManagedInputsOn_34(HandleRef pThis);

		/// <summary>
		/// UserManagedInputs allows the user to set inputs by number instead of
		/// using the AddInput/RemoveInput functions. Calls to
		/// SetNumberOfInputs/SetInputByNumber should not be mixed with calls
		/// to AddInput/RemoveInput.
		///
		/// The default is false.
		/// </summary>
		// Token: 0x060187CF RID: 100303 RVA: 0x00224064 File Offset: 0x00222264
		public virtual void UserManagedInputsOn()
		{
			vtkAppendSelection.vtkAppendSelection_UserManagedInputsOn_34(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B20 RID: 6944
		public new const string MRFullTypeName = "Kitware.VTK.vtkAppendSelection";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B21 RID: 6945
		public new static readonly string MRClassNameKey = "class vtkAppendSelection";
	}
}
