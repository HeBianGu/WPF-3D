using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkViewNode
	/// </summary>
	/// <remarks>
	///    a node within a VTK scene graph
	///
	/// This is the superclass for all nodes within a VTK scene graph. It
	/// contains the API for a node. It supports the essential operations such
	/// as graph creation, state storage and traversal. Child classes adapt this
	/// to VTK's major rendering classes. Grandchild classes adapt those to
	/// for APIs of different rendering libraries.
	/// </remarks>
	// Token: 0x02000216 RID: 534
	public class vtkViewNode : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060065C4 RID: 26052 RVA: 0x000926AC File Offset: 0x000908AC
		static vtkViewNode()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkViewNode.MRClassNameKey, Type.GetType("Kitware.VTK.vtkViewNode"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060065C5 RID: 26053 RVA: 0x000926D4 File Offset: 0x000908D4
		public vtkViewNode(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060065C6 RID: 26054 RVA: 0x000926E2 File Offset: 0x000908E2
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060065C7 RID: 26055
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewNode_Build_01(HandleRef pThis, byte arg0);

		/// <summary>
		/// Builds myself.
		/// </summary>
		// Token: 0x060065C8 RID: 26056 RVA: 0x000926ED File Offset: 0x000908ED
		public virtual void Build(bool arg0)
		{
			vtkViewNode.vtkViewNode_Build_01(base.GetCppThis(), arg0 ? (byte)1 : (byte)0);
		}

		// Token: 0x060065C9 RID: 26057
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewNode_GetFirstAncestorOfType_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Find the first parent/grandparent of the desired type
		/// </summary>
		// Token: 0x060065CA RID: 26058 RVA: 0x00092708 File Offset: 0x00090908
		public vtkViewNode GetFirstAncestorOfType(string type)
		{
			vtkViewNode vtkViewNode = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkViewNode.vtkViewNode_GetFirstAncestorOfType_02(base.GetCppThis(), type, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkViewNode = (vtkViewNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkViewNode.Register(null);
				}
			}
			return vtkViewNode;
		}

		// Token: 0x060065CB RID: 26059
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewNode_GetFirstChildOfType_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Find the first child of the desired type
		/// </summary>
		// Token: 0x060065CC RID: 26060 RVA: 0x00092778 File Offset: 0x00090978
		public vtkViewNode GetFirstChildOfType(string type)
		{
			vtkViewNode vtkViewNode = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkViewNode.vtkViewNode_GetFirstChildOfType_03(base.GetCppThis(), type, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkViewNode = (vtkViewNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkViewNode.Register(null);
				}
			}
			return vtkViewNode;
		}

		// Token: 0x060065CD RID: 26061
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewNode_GetMyFactory_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// A factory that creates particular subclasses for different
		/// rendering back ends.
		/// </summary>
		// Token: 0x060065CE RID: 26062 RVA: 0x000927E8 File Offset: 0x000909E8
		public virtual vtkViewNodeFactory GetMyFactory()
		{
			vtkViewNodeFactory vtkViewNodeFactory = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkViewNode.vtkViewNode_GetMyFactory_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkViewNodeFactory = (vtkViewNodeFactory)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkViewNodeFactory.Register(null);
				}
			}
			return vtkViewNodeFactory;
		}

		// Token: 0x060065CF RID: 26063
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkViewNode_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060065D0 RID: 26064 RVA: 0x00092858 File Offset: 0x00090A58
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkViewNode.vtkViewNode_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x060065D1 RID: 26065
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkViewNode_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060065D2 RID: 26066 RVA: 0x00092878 File Offset: 0x00090A78
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkViewNode.vtkViewNode_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x060065D3 RID: 26067
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewNode_GetParent_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Access the node that owns this one.
		/// </summary>
		// Token: 0x060065D4 RID: 26068 RVA: 0x00092894 File Offset: 0x00090A94
		public virtual vtkViewNode GetParent()
		{
			vtkViewNode vtkViewNode = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkViewNode.vtkViewNode_GetParent_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkViewNode = (vtkViewNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkViewNode.Register(null);
				}
			}
			return vtkViewNode;
		}

		// Token: 0x060065D5 RID: 26069
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewNode_GetRenderable_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This is the VTK class that this node stands in for.
		/// </summary>
		// Token: 0x060065D6 RID: 26070 RVA: 0x00092904 File Offset: 0x00090B04
		public virtual vtkObject GetRenderable()
		{
			vtkObject vtkObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkViewNode.vtkViewNode_GetRenderable_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkObject = (vtkObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkObject.Register(null);
				}
			}
			return vtkObject;
		}

		// Token: 0x060065D7 RID: 26071
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewNode_GetViewNodeFor_09(HandleRef pThis, HandleRef arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the view node that corresponding to the provided object
		/// Will return NULL if a match is not found in self or descendents
		/// </summary>
		// Token: 0x060065D8 RID: 26072 RVA: 0x00092974 File Offset: 0x00090B74
		public vtkViewNode GetViewNodeFor(vtkObject arg0)
		{
			vtkViewNode vtkViewNode = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkViewNode.vtkViewNode_GetViewNodeFor_09(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkViewNode = (vtkViewNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkViewNode.Register(null);
				}
			}
			return vtkViewNode;
		}

		// Token: 0x060065D9 RID: 26073
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewNode_Invalidate_10(HandleRef pThis, byte arg0);

		/// <summary>
		/// Clear any cached data.
		/// </summary>
		// Token: 0x060065DA RID: 26074 RVA: 0x000929F9 File Offset: 0x00090BF9
		public virtual void Invalidate(bool arg0)
		{
			vtkViewNode.vtkViewNode_Invalidate_10(base.GetCppThis(), arg0 ? (byte)1 : (byte)0);
		}

		// Token: 0x060065DB RID: 26075
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkViewNode_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060065DC RID: 26076 RVA: 0x00092A14 File Offset: 0x00090C14
		public override int IsA(string type)
		{
			return vtkViewNode.vtkViewNode_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x060065DD RID: 26077
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkViewNode_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060065DE RID: 26078 RVA: 0x00092A34 File Offset: 0x00090C34
		public new static int IsTypeOf(string type)
		{
			return vtkViewNode.vtkViewNode_IsTypeOf_12(type);
		}

		// Token: 0x060065DF RID: 26079
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewNode_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060065E0 RID: 26080 RVA: 0x00092A50 File Offset: 0x00090C50
		public new vtkViewNode NewInstance()
		{
			vtkViewNode result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkViewNode.vtkViewNode_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkViewNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060065E1 RID: 26081
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewNode_Render_14(HandleRef pThis, byte arg0);

		/// <summary>
		/// Makes calls to make self visible.
		/// </summary>
		// Token: 0x060065E2 RID: 26082 RVA: 0x00092AAA File Offset: 0x00090CAA
		public virtual void Render(bool arg0)
		{
			vtkViewNode.vtkViewNode_Render_14(base.GetCppThis(), arg0 ? (byte)1 : (byte)0);
		}

		// Token: 0x060065E3 RID: 26083
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewNode_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060065E4 RID: 26084 RVA: 0x00092AC4 File Offset: 0x00090CC4
		public new static vtkViewNode SafeDownCast(vtkObjectBase o)
		{
			vtkViewNode vtkViewNode = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkViewNode.vtkViewNode_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkViewNode = (vtkViewNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkViewNode.Register(null);
				}
			}
			return vtkViewNode;
		}

		// Token: 0x060065E5 RID: 26085
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewNode_SetMyFactory_16(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// A factory that creates particular subclasses for different
		/// rendering back ends.
		/// </summary>
		// Token: 0x060065E6 RID: 26086 RVA: 0x00092B44 File Offset: 0x00090D44
		public virtual void SetMyFactory(vtkViewNodeFactory arg0)
		{
			vtkViewNode.vtkViewNode_SetMyFactory_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060065E7 RID: 26087
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewNode_SetParent_17(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Access the node that owns this one.
		/// </summary>
		// Token: 0x060065E8 RID: 26088 RVA: 0x00092B74 File Offset: 0x00090D74
		public virtual void SetParent(vtkViewNode arg0)
		{
			vtkViewNode.vtkViewNode_SetParent_17(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060065E9 RID: 26089
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewNode_SetRenderable_18(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Allow explicit setting of the renderable for a
		/// view node.
		/// </summary>
		// Token: 0x060065EA RID: 26090 RVA: 0x00092BA4 File Offset: 0x00090DA4
		public virtual void SetRenderable(vtkObject arg0)
		{
			vtkViewNode.vtkViewNode_SetRenderable_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060065EB RID: 26091
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewNode_Synchronize_19(HandleRef pThis, byte arg0);

		/// <summary>
		/// Ensures that my state agrees with my Renderable's.
		/// </summary>
		// Token: 0x060065EC RID: 26092 RVA: 0x00092BD3 File Offset: 0x00090DD3
		public virtual void Synchronize(bool arg0)
		{
			vtkViewNode.vtkViewNode_Synchronize_19(base.GetCppThis(), arg0 ? (byte)1 : (byte)0);
		}

		// Token: 0x060065ED RID: 26093
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewNode_Traverse_20(HandleRef pThis, int operation);

		/// <summary>
		/// Allow explicit setting of the renderable for a
		/// view node.
		/// </summary>
		// Token: 0x060065EE RID: 26094 RVA: 0x00092BEB File Offset: 0x00090DEB
		public virtual void Traverse(int operation)
		{
			vtkViewNode.vtkViewNode_Traverse_20(base.GetCppThis(), operation);
		}

		// Token: 0x060065EF RID: 26095
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewNode_TraverseAllPasses_21(HandleRef pThis);

		/// <summary>
		/// Allow explicit setting of the renderable for a
		/// view node.
		/// </summary>
		// Token: 0x060065F0 RID: 26096 RVA: 0x00092BFB File Offset: 0x00090DFB
		public virtual void TraverseAllPasses()
		{
			vtkViewNode.vtkViewNode_TraverseAllPasses_21(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400090F RID: 2319
		public new const string MRFullTypeName = "Kitware.VTK.vtkViewNode";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000910 RID: 2320
		public new static readonly string MRClassNameKey = "class vtkViewNode";

		/// <summary>
		/// internal mechanics of graph traversal and actions
		/// </summary>
		// Token: 0x02000217 RID: 535
		public enum operation_type
		{
			/// <summary>enum member</summary>
			// Token: 0x04000912 RID: 2322
			build = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000913 RID: 2323
			invalidate = 4,
			/// <summary>enum member</summary>
			// Token: 0x04000914 RID: 2324
			noop = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000915 RID: 2325
			render = 3,
			/// <summary>enum member</summary>
			// Token: 0x04000916 RID: 2326
			synchronize = 2
		}
	}
}
