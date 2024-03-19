using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkSelection
	/// </summary>
	/// <remarks>
	///  data object that represents a "selection" in VTK.
	///
	/// vtkSelection defines a selection. A selection is a data-object that defines
	/// which entities from another data-object are to treated as "selected". Filters like
	/// `vtkExtractSelection` or `vtkExtractDataArraysOverTime` can then be used to
	/// extract these selected entities from the *other* data-object.
	///
	/// vtkSelection comprises of `vtkSelectionNode`s and optionally, an expression
	/// specified using `vtkSelection::SetExpression`. If non-empty, the expression
	/// is a boolean expression that defines now the selection nodes present in the
	/// selection are to be combined together to form the selection. If no expression
	/// is specified and there are multiple selection nodes, then the default
	/// expression simply combines all the selection nodes using an `or` operator.
	///
	/// Each vtkSelectionNode is used to define the selection criteria.
	/// vtkSelectionNode API lets one select what kind of entities are being selected
	/// (vtkSelectionNode::FieldType) and how they are being selected
	/// (vtkSelectionNode::ContentType).
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkSelectionNode
	/// </seealso>
	// Token: 0x02000ABB RID: 2747
	public class vtkSelection : vtkDataObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601CEAC RID: 118444 RVA: 0x0028BCD7 File Offset: 0x00289ED7
		static vtkSelection()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSelection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSelection"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601CEAD RID: 118445 RVA: 0x0028BCFF File Offset: 0x00289EFF
		public vtkSelection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601CEAE RID: 118446
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CEAF RID: 118447 RVA: 0x0028BD10 File Offset: 0x00289F10
		public new static vtkSelection New()
		{
			vtkSelection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelection.vtkSelection_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CEB0 RID: 118448 RVA: 0x0028BD64 File Offset: 0x00289F64
		public vtkSelection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSelection.vtkSelection_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601CEB1 RID: 118449 RVA: 0x0028BDA8 File Offset: 0x00289FA8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601CEB2 RID: 118450
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkSelection_AddNode_01(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Adds a selection node. Assigns the node a unique name and returns that
		/// name. This API is primarily provided for backwards compatibility and
		/// `SetNode` is the preferred method.
		/// </summary>
		// Token: 0x0601CEB3 RID: 118451 RVA: 0x0028BDB4 File Offset: 0x00289FB4
		public virtual string AddNode(vtkSelectionNode arg0)
		{
			return vtkSelection.vtkSelection_AddNode_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601CEB4 RID: 118452
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelection_DeepCopy_02(HandleRef pThis, HandleRef src);

		/// <summary>
		/// Copy selection nodes of the input.
		/// </summary>
		// Token: 0x0601CEB5 RID: 118453 RVA: 0x0028BDE8 File Offset: 0x00289FE8
		public override void DeepCopy(vtkDataObject src)
		{
			vtkSelection.vtkSelection_DeepCopy_02(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		// Token: 0x0601CEB6 RID: 118454
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelection_Dump_03(HandleRef pThis);

		/// <summary>
		/// Dumps the contents of the selection, giving basic information only.
		/// </summary>
		// Token: 0x0601CEB7 RID: 118455 RVA: 0x0028BE17 File Offset: 0x0028A017
		public virtual void Dump()
		{
			vtkSelection.vtkSelection_Dump_03(base.GetCppThis());
		}

		// Token: 0x0601CEB8 RID: 118456
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelection_GetData_04(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve a vtkSelection stored inside an invormation object.
		/// </summary>
		// Token: 0x0601CEB9 RID: 118457 RVA: 0x0028BE28 File Offset: 0x0028A028
		public new static vtkSelection GetData(vtkInformation info)
		{
			vtkSelection vtkSelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelection.vtkSelection_GetData_04((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601CEBA RID: 118458
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelection_GetData_05(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve a vtkSelection stored inside an invormation object.
		/// </summary>
		// Token: 0x0601CEBB RID: 118459 RVA: 0x0028BEA8 File Offset: 0x0028A0A8
		public new static vtkSelection GetData(vtkInformationVector v, int i)
		{
			vtkSelection vtkSelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelection.vtkSelection_GetData_05((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601CEBC RID: 118460
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelection_GetDataObjectType_06(HandleRef pThis);

		/// <summary>
		/// Returns VTK_SELECTION enumeration value.
		/// </summary>
		// Token: 0x0601CEBD RID: 118461 RVA: 0x0028BF28 File Offset: 0x0028A128
		public override int GetDataObjectType()
		{
			return vtkSelection.vtkSelection_GetDataObjectType_06(base.GetCppThis());
		}

		// Token: 0x0601CEBE RID: 118462
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkSelection_GetExpression_07(HandleRef pThis);

		/// <summary>
		/// Get/Set the expression that defines the boolean expression to combine the
		/// selection nodes. Expression consists of node name identifiers, `|` for
		/// boolean-or, '^' for boolean-xor, '&amp;' for boolean and, '!' for boolean not,
		/// and parenthesis `(` and `)`. If the expression consists of a node name identifier
		/// that is not assigned any `vtkSelectionNode` (using `SetNode`) then it is evaluates
		/// to `false`.
		///
		/// `SetExpression` does not validate the expression. It will be validated in
		/// `Evaluate` call.
		/// </summary>
		// Token: 0x0601CEBF RID: 118463 RVA: 0x0028BF48 File Offset: 0x0028A148
		public virtual string GetExpression()
		{
			return vtkSelection.vtkSelection_GetExpression_07(base.GetCppThis());
		}

		// Token: 0x0601CEC0 RID: 118464
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkSelection_GetMTime_08(HandleRef pThis);

		/// <summary>
		/// Return the MTime taking into account changes to the properties
		/// </summary>
		// Token: 0x0601CEC1 RID: 118465 RVA: 0x0028BF68 File Offset: 0x0028A168
		public override ulong GetMTime()
		{
			return vtkSelection.vtkSelection_GetMTime_08(base.GetCppThis());
		}

		// Token: 0x0601CEC2 RID: 118466
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelection_GetNode_09(HandleRef pThis, uint idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns a node given it's index. Performs bound checking
		/// and will return nullptr if out-of-bounds.
		/// </summary>
		// Token: 0x0601CEC3 RID: 118467 RVA: 0x0028BF88 File Offset: 0x0028A188
		public virtual vtkSelectionNode GetNode(uint idx)
		{
			vtkSelectionNode vtkSelectionNode = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelection.vtkSelection_GetNode_09(base.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSelectionNode = (vtkSelectionNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSelectionNode.Register(null);
				}
			}
			return vtkSelectionNode;
		}

		// Token: 0x0601CEC4 RID: 118468
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelection_GetNode_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns a node with the given name, if present, else nullptr is returned.
		/// </summary>
		// Token: 0x0601CEC5 RID: 118469 RVA: 0x0028BFF8 File Offset: 0x0028A1F8
		public virtual vtkSelectionNode GetNode(string name)
		{
			vtkSelectionNode vtkSelectionNode = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelection.vtkSelection_GetNode_10(base.GetCppThis(), name, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSelectionNode = (vtkSelectionNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSelectionNode.Register(null);
				}
			}
			return vtkSelectionNode;
		}

		// Token: 0x0601CEC6 RID: 118470
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkSelection_GetNodeNameAtIndex_11(HandleRef pThis, uint idx);

		/// <summary>
		/// Returns the name for a node at the given index.
		/// </summary>
		// Token: 0x0601CEC7 RID: 118471 RVA: 0x0028C068 File Offset: 0x0028A268
		public virtual string GetNodeNameAtIndex(uint idx)
		{
			return vtkSelection.vtkSelection_GetNodeNameAtIndex_11(base.GetCppThis(), idx);
		}

		// Token: 0x0601CEC8 RID: 118472
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSelection_GetNumberOfGenerationsFromBase_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CEC9 RID: 118473 RVA: 0x0028C088 File Offset: 0x0028A288
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSelection.vtkSelection_GetNumberOfGenerationsFromBase_12(base.GetCppThis(), type);
		}

		// Token: 0x0601CECA RID: 118474
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSelection_GetNumberOfGenerationsFromBaseType_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CECB RID: 118475 RVA: 0x0028C0A8 File Offset: 0x0028A2A8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSelection.vtkSelection_GetNumberOfGenerationsFromBaseType_13(type);
		}

		// Token: 0x0601CECC RID: 118476
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkSelection_GetNumberOfNodes_14(HandleRef pThis);

		/// <summary>
		/// Returns the number of nodes in this selection.
		/// Each node contains information about part of the selection.
		/// </summary>
		// Token: 0x0601CECD RID: 118477 RVA: 0x0028C0C4 File Offset: 0x0028A2C4
		public uint GetNumberOfNodes()
		{
			return vtkSelection.vtkSelection_GetNumberOfNodes_14(base.GetCppThis());
		}

		// Token: 0x0601CECE RID: 118478
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelection_Initialize_15(HandleRef pThis);

		/// <summary>
		/// Restore data object to initial state,
		/// </summary>
		// Token: 0x0601CECF RID: 118479 RVA: 0x0028C0E3 File Offset: 0x0028A2E3
		public override void Initialize()
		{
			vtkSelection.vtkSelection_Initialize_15(base.GetCppThis());
		}

		// Token: 0x0601CED0 RID: 118480
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelection_IsA_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CED1 RID: 118481 RVA: 0x0028C0F4 File Offset: 0x0028A2F4
		public override int IsA(string type)
		{
			return vtkSelection.vtkSelection_IsA_16(base.GetCppThis(), type);
		}

		// Token: 0x0601CED2 RID: 118482
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelection_IsTypeOf_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CED3 RID: 118483 RVA: 0x0028C114 File Offset: 0x0028A314
		public new static int IsTypeOf(string type)
		{
			return vtkSelection.vtkSelection_IsTypeOf_17(type);
		}

		// Token: 0x0601CED4 RID: 118484
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelection_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CED5 RID: 118485 RVA: 0x0028C130 File Offset: 0x0028A330
		public new vtkSelection NewInstance()
		{
			vtkSelection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelection.vtkSelection_NewInstance_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601CED6 RID: 118486
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelection_RemoveAllNodes_20(HandleRef pThis);

		/// <summary>
		/// Removes all selection nodes.
		/// </summary>
		// Token: 0x0601CED7 RID: 118487 RVA: 0x0028C18A File Offset: 0x0028A38A
		public virtual void RemoveAllNodes()
		{
			vtkSelection.vtkSelection_RemoveAllNodes_20(base.GetCppThis());
		}

		// Token: 0x0601CED8 RID: 118488
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelection_RemoveNode_21(HandleRef pThis, uint idx);

		/// <summary>
		/// Removes a selection node.
		/// </summary>
		// Token: 0x0601CED9 RID: 118489 RVA: 0x0028C199 File Offset: 0x0028A399
		public virtual void RemoveNode(uint idx)
		{
			vtkSelection.vtkSelection_RemoveNode_21(base.GetCppThis(), idx);
		}

		// Token: 0x0601CEDA RID: 118490
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelection_RemoveNode_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Removes a selection node.
		/// </summary>
		// Token: 0x0601CEDB RID: 118491 RVA: 0x0028C1A9 File Offset: 0x0028A3A9
		public virtual void RemoveNode(string name)
		{
			vtkSelection.vtkSelection_RemoveNode_22(base.GetCppThis(), name);
		}

		// Token: 0x0601CEDC RID: 118492
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelection_RemoveNode_23(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Removes a selection node.
		/// </summary>
		// Token: 0x0601CEDD RID: 118493 RVA: 0x0028C1BC File Offset: 0x0028A3BC
		public virtual void RemoveNode(vtkSelectionNode arg0)
		{
			vtkSelection.vtkSelection_RemoveNode_23(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601CEDE RID: 118494
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelection_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CEDF RID: 118495 RVA: 0x0028C1EC File Offset: 0x0028A3EC
		public new static vtkSelection SafeDownCast(vtkObjectBase o)
		{
			vtkSelection vtkSelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelection.vtkSelection_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601CEE0 RID: 118496
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelection_SetExpression_25(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Get/Set the expression that defines the boolean expression to combine the
		/// selection nodes. Expression consists of node name identifiers, `|` for
		/// boolean-or, '^' for boolean-xor, '&amp;' for boolean and, '!' for boolean not,
		/// and parenthesis `(` and `)`. If the expression consists of a node name identifier
		/// that is not assigned any `vtkSelectionNode` (using `SetNode`) then it is evaluates
		/// to `false`.
		///
		/// `SetExpression` does not validate the expression. It will be validated in
		/// `Evaluate` call.
		/// </summary>
		// Token: 0x0601CEE1 RID: 118497 RVA: 0x0028C26B File Offset: 0x0028A46B
		public virtual void SetExpression(string _arg)
		{
			vtkSelection.vtkSelection_SetExpression_25(base.GetCppThis(), _arg);
		}

		// Token: 0x0601CEE2 RID: 118498
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelection_SetNode_26(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, HandleRef arg1);

		/// <summary>
		/// Adds a vtkSelectionNode and assigns it the specified name. The name
		/// must be a non-empty string. If an item with the same name
		/// has already been added, it will be removed.
		/// </summary>
		// Token: 0x0601CEE3 RID: 118499 RVA: 0x0028C27C File Offset: 0x0028A47C
		public virtual void SetNode(string name, vtkSelectionNode arg1)
		{
			vtkSelection.vtkSelection_SetNode_26(base.GetCppThis(), name, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x0601CEE4 RID: 118500
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelection_ShallowCopy_27(HandleRef pThis, HandleRef src);

		/// <summary>
		/// Copy selection nodes of the input.
		/// This is a shallow copy: selection lists and pointers in the
		/// properties are passed by reference.
		/// </summary>
		// Token: 0x0601CEE5 RID: 118501 RVA: 0x0028C2AC File Offset: 0x0028A4AC
		public override void ShallowCopy(vtkDataObject src)
		{
			vtkSelection.vtkSelection_ShallowCopy_27(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		// Token: 0x0601CEE6 RID: 118502
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelection_Subtract_28(HandleRef pThis, HandleRef selection);

		/// <summary>
		/// Remove the nodes from the specified selection from this selection.
		/// Assumes that selection node internal arrays are vtkIdTypeArrays.
		/// </summary>
		// Token: 0x0601CEE7 RID: 118503 RVA: 0x0028C2DC File Offset: 0x0028A4DC
		public virtual void Subtract(vtkSelection selection)
		{
			vtkSelection.vtkSelection_Subtract_28(base.GetCppThis(), (selection == null) ? default(HandleRef) : selection.GetCppThis());
		}

		// Token: 0x0601CEE8 RID: 118504
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelection_Subtract_29(HandleRef pThis, HandleRef node);

		/// <summary>
		/// Remove the nodes from the specified selection from this selection.
		/// Assumes that selection node internal arrays are vtkIdTypeArrays.
		/// </summary>
		// Token: 0x0601CEE9 RID: 118505 RVA: 0x0028C30C File Offset: 0x0028A50C
		public virtual void Subtract(vtkSelectionNode node)
		{
			vtkSelection.vtkSelection_Subtract_29(base.GetCppThis(), (node == null) ? default(HandleRef) : node.GetCppThis());
		}

		// Token: 0x0601CEEA RID: 118506
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelection_Union_30(HandleRef pThis, HandleRef selection);

		/// <summary>
		/// Union this selection with the specified selection.
		/// Attempts to reuse selection nodes in this selection if properties
		/// match exactly. Otherwise, creates new selection nodes.
		/// </summary>
		// Token: 0x0601CEEB RID: 118507 RVA: 0x0028C33C File Offset: 0x0028A53C
		public virtual void Union(vtkSelection selection)
		{
			vtkSelection.vtkSelection_Union_30(base.GetCppThis(), (selection == null) ? default(HandleRef) : selection.GetCppThis());
		}

		// Token: 0x0601CEEC RID: 118508
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelection_Union_31(HandleRef pThis, HandleRef node);

		/// <summary>
		/// Union this selection with the specified selection node.
		/// Attempts to reuse a selection node in this selection if properties
		/// match exactly. Otherwise, creates a new selection node.
		/// </summary>
		// Token: 0x0601CEED RID: 118509 RVA: 0x0028C36C File Offset: 0x0028A56C
		public virtual void Union(vtkSelectionNode node)
		{
			vtkSelection.vtkSelection_Union_31(base.GetCppThis(), (node == null) ? default(HandleRef) : node.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E81 RID: 7809
		public new const string MRFullTypeName = "Kitware.VTK.vtkSelection";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E82 RID: 7810
		public new static readonly string MRClassNameKey = "class vtkSelection";
	}
}
