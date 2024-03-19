using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVolumeNode
	/// </summary>
	/// <remarks>
	///    vtkViewNode specialized for vtkActors
	///
	/// State storage and graph traversal for vtkActor/Mapper and Property
	/// Made a choice to merge actor, mapper and property together. If there
	/// is a compelling reason to separate them we can.
	/// </remarks>
	// Token: 0x0200021F RID: 543
	public class vtkVolumeNode : vtkViewNode
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006691 RID: 26257 RVA: 0x00093D2F File Offset: 0x00091F2F
		static vtkVolumeNode()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVolumeNode.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVolumeNode"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006692 RID: 26258 RVA: 0x00093D57 File Offset: 0x00091F57
		public vtkVolumeNode(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006693 RID: 26259
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeNode_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006694 RID: 26260 RVA: 0x00093D68 File Offset: 0x00091F68
		public new static vtkVolumeNode New()
		{
			vtkVolumeNode result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeNode.vtkVolumeNode_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumeNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006695 RID: 26261 RVA: 0x00093DBC File Offset: 0x00091FBC
		public vtkVolumeNode() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkVolumeNode.vtkVolumeNode_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006696 RID: 26262 RVA: 0x00093E00 File Offset: 0x00092000
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006697 RID: 26263
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeNode_Build_01(HandleRef pThis, byte prepass);

		/// <summary>
		/// Build containers for our child nodes.
		/// </summary>
		// Token: 0x06006698 RID: 26264 RVA: 0x00093E0B File Offset: 0x0009200B
		public override void Build(bool prepass)
		{
			vtkVolumeNode.vtkVolumeNode_Build_01(base.GetCppThis(), prepass ? (byte)1 : (byte)0);
		}

		// Token: 0x06006699 RID: 26265
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVolumeNode_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600669A RID: 26266 RVA: 0x00093E24 File Offset: 0x00092024
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVolumeNode.vtkVolumeNode_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600669B RID: 26267
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVolumeNode_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600669C RID: 26268 RVA: 0x00093E44 File Offset: 0x00092044
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVolumeNode.vtkVolumeNode_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600669D RID: 26269
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeNode_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600669E RID: 26270 RVA: 0x00093E60 File Offset: 0x00092060
		public override int IsA(string type)
		{
			return vtkVolumeNode.vtkVolumeNode_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600669F RID: 26271
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeNode_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060066A0 RID: 26272 RVA: 0x00093E80 File Offset: 0x00092080
		public new static int IsTypeOf(string type)
		{
			return vtkVolumeNode.vtkVolumeNode_IsTypeOf_05(type);
		}

		// Token: 0x060066A1 RID: 26273
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeNode_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060066A2 RID: 26274 RVA: 0x00093E9C File Offset: 0x0009209C
		public new vtkVolumeNode NewInstance()
		{
			vtkVolumeNode result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeNode.vtkVolumeNode_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumeNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060066A3 RID: 26275
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeNode_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060066A4 RID: 26276 RVA: 0x00093EF8 File Offset: 0x000920F8
		public new static vtkVolumeNode SafeDownCast(vtkObjectBase o)
		{
			vtkVolumeNode vtkVolumeNode = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeNode.vtkVolumeNode_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVolumeNode = (vtkVolumeNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVolumeNode.Register(null);
				}
			}
			return vtkVolumeNode;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000925 RID: 2341
		public new const string MRFullTypeName = "Kitware.VTK.vtkVolumeNode";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000926 RID: 2342
		public new static readonly string MRClassNameKey = "class vtkVolumeNode";
	}
}
