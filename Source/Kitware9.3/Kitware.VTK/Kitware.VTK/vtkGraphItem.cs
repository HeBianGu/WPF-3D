using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGraphItem
	/// </summary>
	/// <remarks>
	///    A 2D graphics item for rendering a graph.
	///
	///
	/// This item draws a graph as a part of a vtkContextScene. This simple
	/// class has minimal state and delegates the determination of visual
	/// vertex and edge properties like color, size, width, etc. to
	/// a set of virtual functions. To influence the rendering of the graph,
	/// subclass this item and override the property functions you wish to
	/// customize.
	/// </remarks>
	// Token: 0x02000064 RID: 100
	public class vtkGraphItem : vtkContextItem
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06001216 RID: 4630 RVA: 0x000200E3 File Offset: 0x0001E2E3
		static vtkGraphItem()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGraphItem.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGraphItem"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06001217 RID: 4631 RVA: 0x0002010B File Offset: 0x0001E30B
		public vtkGraphItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06001218 RID: 4632
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphItem_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001219 RID: 4633 RVA: 0x0002011C File Offset: 0x0001E31C
		public new static vtkGraphItem New()
		{
			vtkGraphItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphItem.vtkGraphItem_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600121A RID: 4634 RVA: 0x00020170 File Offset: 0x0001E370
		public vtkGraphItem() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGraphItem.vtkGraphItem_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600121B RID: 4635 RVA: 0x000201B4 File Offset: 0x0001E3B4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600121C RID: 4636
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphItem_GetGraph_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The graph that this item draws.
		/// </summary>
		// Token: 0x0600121D RID: 4637 RVA: 0x000201C0 File Offset: 0x0001E3C0
		public virtual vtkGraph GetGraph()
		{
			vtkGraph vtkGraph = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphItem.vtkGraphItem_GetGraph_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraph = (vtkGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraph.Register(null);
				}
			}
			return vtkGraph;
		}

		// Token: 0x0600121E RID: 4638
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphItem_GetLayout_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Exposes the incremental graph layout for updating parameters.
		/// </summary>
		// Token: 0x0600121F RID: 4639 RVA: 0x00020230 File Offset: 0x0001E430
		public virtual vtkIncrementalForceLayout GetLayout()
		{
			vtkIncrementalForceLayout vtkIncrementalForceLayout = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphItem.vtkGraphItem_GetLayout_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIncrementalForceLayout = (vtkIncrementalForceLayout)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIncrementalForceLayout.Register(null);
				}
			}
			return vtkIncrementalForceLayout;
		}

		// Token: 0x06001220 RID: 4640
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraphItem_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001221 RID: 4641 RVA: 0x000202A0 File Offset: 0x0001E4A0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGraphItem.vtkGraphItem_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06001222 RID: 4642
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraphItem_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001223 RID: 4643 RVA: 0x000202C0 File Offset: 0x0001E4C0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGraphItem.vtkGraphItem_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06001224 RID: 4644
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphItem_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001225 RID: 4645 RVA: 0x000202DC File Offset: 0x0001E4DC
		public override int IsA(string type)
		{
			return vtkGraphItem.vtkGraphItem_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06001226 RID: 4646
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphItem_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001227 RID: 4647 RVA: 0x000202FC File Offset: 0x0001E4FC
		public new static int IsTypeOf(string type)
		{
			return vtkGraphItem.vtkGraphItem_IsTypeOf_06(type);
		}

		// Token: 0x06001228 RID: 4648
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphItem_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001229 RID: 4649 RVA: 0x00020318 File Offset: 0x0001E518
		public new vtkGraphItem NewInstance()
		{
			vtkGraphItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphItem.vtkGraphItem_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600122A RID: 4650
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphItem_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600122B RID: 4651 RVA: 0x00020374 File Offset: 0x0001E574
		public new static vtkGraphItem SafeDownCast(vtkObjectBase o)
		{
			vtkGraphItem vtkGraphItem = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphItem.vtkGraphItem_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraphItem = (vtkGraphItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraphItem.Register(null);
				}
			}
			return vtkGraphItem;
		}

		// Token: 0x0600122C RID: 4652
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphItem_SetGraph_10(HandleRef pThis, HandleRef graph);

		/// <summary>
		/// The graph that this item draws.
		/// </summary>
		// Token: 0x0600122D RID: 4653 RVA: 0x000203F4 File Offset: 0x0001E5F4
		public virtual void SetGraph(vtkGraph graph)
		{
			vtkGraphItem.vtkGraphItem_SetGraph_10(base.GetCppThis(), (graph == null) ? default(HandleRef) : graph.GetCppThis());
		}

		// Token: 0x0600122E RID: 4654
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphItem_StartLayoutAnimation_11(HandleRef pThis, HandleRef interactor);

		/// <summary>
		/// Begins or ends the layout animation.
		/// </summary>
		// Token: 0x0600122F RID: 4655 RVA: 0x00020424 File Offset: 0x0001E624
		public virtual void StartLayoutAnimation(vtkRenderWindowInteractor interactor)
		{
			vtkGraphItem.vtkGraphItem_StartLayoutAnimation_11(base.GetCppThis(), (interactor == null) ? default(HandleRef) : interactor.GetCppThis());
		}

		// Token: 0x06001230 RID: 4656
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphItem_StopLayoutAnimation_12(HandleRef pThis);

		/// <summary>
		/// Begins or ends the layout animation.
		/// </summary>
		// Token: 0x06001231 RID: 4657 RVA: 0x00020453 File Offset: 0x0001E653
		public virtual void StopLayoutAnimation()
		{
			vtkGraphItem.vtkGraphItem_StopLayoutAnimation_12(base.GetCppThis());
		}

		// Token: 0x06001232 RID: 4658
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphItem_UpdateLayout_13(HandleRef pThis);

		/// <summary>
		/// Incrementally updates the graph layout.
		/// </summary>
		// Token: 0x06001233 RID: 4659 RVA: 0x00020462 File Offset: 0x0001E662
		public virtual void UpdateLayout()
		{
			vtkGraphItem.vtkGraphItem_UpdateLayout_13(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400044E RID: 1102
		public new const string MRFullTypeName = "Kitware.VTK.vtkGraphItem";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400044F RID: 1103
		public new static readonly string MRClassNameKey = "class vtkGraphItem";
	}
}
