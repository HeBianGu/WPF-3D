using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkActorNode
	/// </summary>
	/// <remarks>
	///    vtkViewNode specialized for vtkActors
	///
	/// State storage and graph traversal for vtkActor/Mapper and Property
	/// Made a choice to merge actor, mapper and property together. If there
	/// is a compelling reason to separate them we can.
	/// </remarks>
	// Token: 0x02000218 RID: 536
	public class vtkActorNode : vtkViewNode
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060065F1 RID: 26097 RVA: 0x00092C0A File Offset: 0x00090E0A
		static vtkActorNode()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkActorNode.MRClassNameKey, Type.GetType("Kitware.VTK.vtkActorNode"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060065F2 RID: 26098 RVA: 0x00092C32 File Offset: 0x00090E32
		public vtkActorNode(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060065F3 RID: 26099
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkActorNode_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060065F4 RID: 26100 RVA: 0x00092C40 File Offset: 0x00090E40
		public new static vtkActorNode New()
		{
			vtkActorNode result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkActorNode.vtkActorNode_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkActorNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060065F5 RID: 26101 RVA: 0x00092C94 File Offset: 0x00090E94
		public vtkActorNode() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkActorNode.vtkActorNode_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060065F6 RID: 26102 RVA: 0x00092CD8 File Offset: 0x00090ED8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060065F7 RID: 26103
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkActorNode_Build_01(HandleRef pThis, byte prepass);

		/// <summary>
		/// Build containers for our child nodes.
		/// </summary>
		// Token: 0x060065F8 RID: 26104 RVA: 0x00092CE3 File Offset: 0x00090EE3
		public override void Build(bool prepass)
		{
			vtkActorNode.vtkActorNode_Build_01(base.GetCppThis(), prepass ? (byte)1 : (byte)0);
		}

		// Token: 0x060065F9 RID: 26105
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkActorNode_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060065FA RID: 26106 RVA: 0x00092CFC File Offset: 0x00090EFC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkActorNode.vtkActorNode_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060065FB RID: 26107
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkActorNode_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060065FC RID: 26108 RVA: 0x00092D1C File Offset: 0x00090F1C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkActorNode.vtkActorNode_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x060065FD RID: 26109
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkActorNode_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060065FE RID: 26110 RVA: 0x00092D38 File Offset: 0x00090F38
		public override int IsA(string type)
		{
			return vtkActorNode.vtkActorNode_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x060065FF RID: 26111
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkActorNode_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006600 RID: 26112 RVA: 0x00092D58 File Offset: 0x00090F58
		public new static int IsTypeOf(string type)
		{
			return vtkActorNode.vtkActorNode_IsTypeOf_05(type);
		}

		// Token: 0x06006601 RID: 26113
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkActorNode_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006602 RID: 26114 RVA: 0x00092D74 File Offset: 0x00090F74
		public new vtkActorNode NewInstance()
		{
			vtkActorNode result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkActorNode.vtkActorNode_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkActorNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006603 RID: 26115
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkActorNode_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006604 RID: 26116 RVA: 0x00092DD0 File Offset: 0x00090FD0
		public new static vtkActorNode SafeDownCast(vtkObjectBase o)
		{
			vtkActorNode vtkActorNode = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkActorNode.vtkActorNode_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkActorNode = (vtkActorNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkActorNode.Register(null);
				}
			}
			return vtkActorNode;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000917 RID: 2327
		public new const string MRFullTypeName = "Kitware.VTK.vtkActorNode";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000918 RID: 2328
		public new static readonly string MRClassNameKey = "class vtkActorNode";
	}
}
