using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLightNode
	/// </summary>
	/// <remarks>
	///    vtkViewNode specialized for vtkLights
	///
	/// State storage and graph traversal for vtkLight
	/// </remarks>
	// Token: 0x0200021A RID: 538
	public class vtkLightNode : vtkViewNode
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006617 RID: 26135 RVA: 0x0009307F File Offset: 0x0009127F
		static vtkLightNode()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLightNode.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLightNode"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006618 RID: 26136 RVA: 0x000930A7 File Offset: 0x000912A7
		public vtkLightNode(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006619 RID: 26137
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLightNode_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600661A RID: 26138 RVA: 0x000930B8 File Offset: 0x000912B8
		public new static vtkLightNode New()
		{
			vtkLightNode result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLightNode.vtkLightNode_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLightNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600661B RID: 26139 RVA: 0x0009310C File Offset: 0x0009130C
		public vtkLightNode() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLightNode.vtkLightNode_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600661C RID: 26140 RVA: 0x00093150 File Offset: 0x00091350
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600661D RID: 26141
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLightNode_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600661E RID: 26142 RVA: 0x0009315C File Offset: 0x0009135C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLightNode.vtkLightNode_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600661F RID: 26143
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLightNode_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006620 RID: 26144 RVA: 0x0009317C File Offset: 0x0009137C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLightNode.vtkLightNode_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06006621 RID: 26145
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLightNode_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006622 RID: 26146 RVA: 0x00093198 File Offset: 0x00091398
		public override int IsA(string type)
		{
			return vtkLightNode.vtkLightNode_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06006623 RID: 26147
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLightNode_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006624 RID: 26148 RVA: 0x000931B8 File Offset: 0x000913B8
		public new static int IsTypeOf(string type)
		{
			return vtkLightNode.vtkLightNode_IsTypeOf_04(type);
		}

		// Token: 0x06006625 RID: 26149
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLightNode_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006626 RID: 26150 RVA: 0x000931D4 File Offset: 0x000913D4
		public new vtkLightNode NewInstance()
		{
			vtkLightNode result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLightNode.vtkLightNode_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLightNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006627 RID: 26151
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLightNode_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006628 RID: 26152 RVA: 0x00093230 File Offset: 0x00091430
		public new static vtkLightNode SafeDownCast(vtkObjectBase o)
		{
			vtkLightNode vtkLightNode = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLightNode.vtkLightNode_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLightNode = (vtkLightNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLightNode.Register(null);
				}
			}
			return vtkLightNode;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400091B RID: 2331
		public new const string MRFullTypeName = "Kitware.VTK.vtkLightNode";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400091C RID: 2332
		public new static readonly string MRClassNameKey = "class vtkLightNode";
	}
}
