using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLabelHierarchyCompositeIterator
	/// </summary>
	/// <remarks>
	///    Iterator over sub-iterators
	///
	///
	/// Iterates over child iterators in a round-robin order. Each iterator may
	/// have its own count, which is the number of times it is repeated until
	/// moving to the next iterator.
	///
	/// For example, if you initialize the iterator with
	/// &lt;pre&gt;
	/// it-&gt;AddIterator(A, 1);
	/// it-&gt;AddIterator(B, 3);
	/// &lt;/pre&gt;
	/// The order of iterators will be A,B,B,B,A,B,B,B,...
	/// </remarks>
	// Token: 0x020000EF RID: 239
	public class vtkLabelHierarchyCompositeIterator : vtkLabelHierarchyIterator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060031A7 RID: 12711 RVA: 0x00049307 File Offset: 0x00047507
		static vtkLabelHierarchyCompositeIterator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLabelHierarchyCompositeIterator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLabelHierarchyCompositeIterator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060031A8 RID: 12712 RVA: 0x0004932F File Offset: 0x0004752F
		public vtkLabelHierarchyCompositeIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060031A9 RID: 12713
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabelHierarchyCompositeIterator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060031AA RID: 12714 RVA: 0x00049340 File Offset: 0x00047540
		public new static vtkLabelHierarchyCompositeIterator New()
		{
			vtkLabelHierarchyCompositeIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabelHierarchyCompositeIterator.vtkLabelHierarchyCompositeIterator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLabelHierarchyCompositeIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060031AB RID: 12715 RVA: 0x00049394 File Offset: 0x00047594
		public vtkLabelHierarchyCompositeIterator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLabelHierarchyCompositeIterator.vtkLabelHierarchyCompositeIterator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060031AC RID: 12716 RVA: 0x000493D8 File Offset: 0x000475D8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060031AD RID: 12717
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelHierarchyCompositeIterator_AddIterator_01(HandleRef pThis, HandleRef it);

		/// <summary>
		/// Adds a label iterator to this composite iterator.
		/// The second optional argument is the number of times to repeat the iterator
		/// before moving to the next one round-robin style. Default is 1.
		/// </summary>
		// Token: 0x060031AE RID: 12718 RVA: 0x000493E4 File Offset: 0x000475E4
		public virtual void AddIterator(vtkLabelHierarchyIterator it)
		{
			vtkLabelHierarchyCompositeIterator.vtkLabelHierarchyCompositeIterator_AddIterator_01(base.GetCppThis(), (it == null) ? default(HandleRef) : it.GetCppThis());
		}

		// Token: 0x060031AF RID: 12719
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelHierarchyCompositeIterator_AddIterator_02(HandleRef pThis, HandleRef it, int count);

		/// <summary>
		/// Adds a label iterator to this composite iterator.
		/// The second optional argument is the number of times to repeat the iterator
		/// before moving to the next one round-robin style. Default is 1.
		/// </summary>
		// Token: 0x060031B0 RID: 12720 RVA: 0x00049414 File Offset: 0x00047614
		public virtual void AddIterator(vtkLabelHierarchyIterator it, int count)
		{
			vtkLabelHierarchyCompositeIterator.vtkLabelHierarchyCompositeIterator_AddIterator_02(base.GetCppThis(), (it == null) ? default(HandleRef) : it.GetCppThis(), count);
		}

		// Token: 0x060031B1 RID: 12721
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelHierarchyCompositeIterator_Begin_03(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Initializes the iterator. lastLabels is an array holding labels
		/// which should be traversed before any other labels in the hierarchy.
		/// This could include labels placed during a previous rendering or
		/// a label located under the mouse pointer. You may pass a null pointer.
		/// </summary>
		// Token: 0x060031B2 RID: 12722 RVA: 0x00049444 File Offset: 0x00047644
		public override void Begin(vtkIdTypeArray arg0)
		{
			vtkLabelHierarchyCompositeIterator.vtkLabelHierarchyCompositeIterator_Begin_03(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060031B3 RID: 12723
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelHierarchyCompositeIterator_BoxAllNodes_04(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Not implemented.
		/// </summary>
		// Token: 0x060031B4 RID: 12724 RVA: 0x00049474 File Offset: 0x00047674
		public override void BoxAllNodes(vtkPolyData arg0)
		{
			vtkLabelHierarchyCompositeIterator.vtkLabelHierarchyCompositeIterator_BoxAllNodes_04(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060031B5 RID: 12725
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelHierarchyCompositeIterator_BoxNode_05(HandleRef pThis);

		/// <summary>
		/// Not implemented.
		/// </summary>
		// Token: 0x060031B6 RID: 12726 RVA: 0x000494A3 File Offset: 0x000476A3
		public override void BoxNode()
		{
			vtkLabelHierarchyCompositeIterator.vtkLabelHierarchyCompositeIterator_BoxNode_05(base.GetCppThis());
		}

		// Token: 0x060031B7 RID: 12727
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelHierarchyCompositeIterator_ClearIterators_06(HandleRef pThis);

		/// <summary>
		/// Remove all iterators from this composite iterator.
		/// </summary>
		// Token: 0x060031B8 RID: 12728 RVA: 0x000494B2 File Offset: 0x000476B2
		public virtual void ClearIterators()
		{
			vtkLabelHierarchyCompositeIterator.vtkLabelHierarchyCompositeIterator_ClearIterators_06(base.GetCppThis());
		}

		// Token: 0x060031B9 RID: 12729
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabelHierarchyCompositeIterator_GetHierarchy_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve the current label hierarchy.
		/// </summary>
		// Token: 0x060031BA RID: 12730 RVA: 0x000494C4 File Offset: 0x000476C4
		public override vtkLabelHierarchy GetHierarchy()
		{
			vtkLabelHierarchy vtkLabelHierarchy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabelHierarchyCompositeIterator.vtkLabelHierarchyCompositeIterator_GetHierarchy_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLabelHierarchy = (vtkLabelHierarchy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLabelHierarchy.Register(null);
				}
			}
			return vtkLabelHierarchy;
		}

		// Token: 0x060031BB RID: 12731
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLabelHierarchyCompositeIterator_GetLabelId_08(HandleRef pThis);

		/// <summary>
		/// Retrieves the current label id.
		/// </summary>
		// Token: 0x060031BC RID: 12732 RVA: 0x00049534 File Offset: 0x00047734
		public override long GetLabelId()
		{
			return vtkLabelHierarchyCompositeIterator.vtkLabelHierarchyCompositeIterator_GetLabelId_08(base.GetCppThis());
		}

		// Token: 0x060031BD RID: 12733
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelHierarchyCompositeIterator_GetNodeGeometry_09(HandleRef pThis, IntPtr ctr, ref double size);

		/// <summary>
		/// Retrieve the coordinates of the center of the current hierarchy node
		/// and the size of the node.
		/// Nodes are n-cubes, so the size is the length of any edge of the cube.
		/// This is used by BoxNode().
		/// </summary>
		// Token: 0x060031BE RID: 12734 RVA: 0x00049553 File Offset: 0x00047753
		public override void GetNodeGeometry(IntPtr ctr, ref double size)
		{
			vtkLabelHierarchyCompositeIterator.vtkLabelHierarchyCompositeIterator_GetNodeGeometry_09(base.GetCppThis(), ctr, ref size);
		}

		// Token: 0x060031BF RID: 12735
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLabelHierarchyCompositeIterator_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060031C0 RID: 12736 RVA: 0x00049564 File Offset: 0x00047764
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLabelHierarchyCompositeIterator.vtkLabelHierarchyCompositeIterator_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x060031C1 RID: 12737
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLabelHierarchyCompositeIterator_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060031C2 RID: 12738 RVA: 0x00049584 File Offset: 0x00047784
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLabelHierarchyCompositeIterator.vtkLabelHierarchyCompositeIterator_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x060031C3 RID: 12739
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLabelHierarchyCompositeIterator_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060031C4 RID: 12740 RVA: 0x000495A0 File Offset: 0x000477A0
		public override int IsA(string type)
		{
			return vtkLabelHierarchyCompositeIterator.vtkLabelHierarchyCompositeIterator_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x060031C5 RID: 12741
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkLabelHierarchyCompositeIterator_IsAtEnd_13(HandleRef pThis);

		/// <summary>
		/// Returns true if the iterator is at the end.
		/// </summary>
		// Token: 0x060031C6 RID: 12742 RVA: 0x000495C0 File Offset: 0x000477C0
		public override bool IsAtEnd()
		{
			return vtkLabelHierarchyCompositeIterator.vtkLabelHierarchyCompositeIterator_IsAtEnd_13(base.GetCppThis()) != 0;
		}

		// Token: 0x060031C7 RID: 12743
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLabelHierarchyCompositeIterator_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060031C8 RID: 12744 RVA: 0x000495E8 File Offset: 0x000477E8
		public new static int IsTypeOf(string type)
		{
			return vtkLabelHierarchyCompositeIterator.vtkLabelHierarchyCompositeIterator_IsTypeOf_14(type);
		}

		// Token: 0x060031C9 RID: 12745
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabelHierarchyCompositeIterator_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060031CA RID: 12746 RVA: 0x00049604 File Offset: 0x00047804
		public new vtkLabelHierarchyCompositeIterator NewInstance()
		{
			vtkLabelHierarchyCompositeIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabelHierarchyCompositeIterator.vtkLabelHierarchyCompositeIterator_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLabelHierarchyCompositeIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060031CB RID: 12747
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelHierarchyCompositeIterator_Next_17(HandleRef pThis);

		/// <summary>
		/// Advance the iterator.
		/// </summary>
		// Token: 0x060031CC RID: 12748 RVA: 0x0004965E File Offset: 0x0004785E
		public override void Next()
		{
			vtkLabelHierarchyCompositeIterator.vtkLabelHierarchyCompositeIterator_Next_17(base.GetCppThis());
		}

		// Token: 0x060031CD RID: 12749
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabelHierarchyCompositeIterator_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060031CE RID: 12750 RVA: 0x00049670 File Offset: 0x00047870
		public new static vtkLabelHierarchyCompositeIterator SafeDownCast(vtkObjectBase o)
		{
			vtkLabelHierarchyCompositeIterator vtkLabelHierarchyCompositeIterator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabelHierarchyCompositeIterator.vtkLabelHierarchyCompositeIterator_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLabelHierarchyCompositeIterator = (vtkLabelHierarchyCompositeIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLabelHierarchyCompositeIterator.Register(null);
				}
			}
			return vtkLabelHierarchyCompositeIterator;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040005E8 RID: 1512
		public new const string MRFullTypeName = "Kitware.VTK.vtkLabelHierarchyCompositeIterator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040005E9 RID: 1513
		public new static readonly string MRClassNameKey = "class vtkLabelHierarchyCompositeIterator";
	}
}
