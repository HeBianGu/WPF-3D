using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRendererNode
	/// </summary>
	/// <remarks>
	///    vtkViewNode specialized for vtkRenderers
	///
	/// State storage and graph traversal for vtkRenderer
	/// </remarks>
	// Token: 0x0200021D RID: 541
	public class vtkRendererNode : vtkViewNode
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600664D RID: 26189 RVA: 0x0009370F File Offset: 0x0009190F
		static vtkRendererNode()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRendererNode.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRendererNode"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600664E RID: 26190 RVA: 0x00093737 File Offset: 0x00091937
		public vtkRendererNode(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600664F RID: 26191
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRendererNode_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006650 RID: 26192 RVA: 0x00093748 File Offset: 0x00091948
		public new static vtkRendererNode New()
		{
			vtkRendererNode result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRendererNode.vtkRendererNode_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRendererNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006651 RID: 26193 RVA: 0x0009379C File Offset: 0x0009199C
		public vtkRendererNode() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRendererNode.vtkRendererNode_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006652 RID: 26194 RVA: 0x000937E0 File Offset: 0x000919E0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006653 RID: 26195
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRendererNode_Build_01(HandleRef pThis, byte prepass);

		/// <summary>
		/// Build containers for our child nodes.
		/// </summary>
		// Token: 0x06006654 RID: 26196 RVA: 0x000937EB File Offset: 0x000919EB
		public override void Build(bool prepass)
		{
			vtkRendererNode.vtkRendererNode_Build_01(base.GetCppThis(), prepass ? (byte)1 : (byte)0);
		}

		// Token: 0x06006655 RID: 26197
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRendererNode_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006656 RID: 26198 RVA: 0x00093804 File Offset: 0x00091A04
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRendererNode.vtkRendererNode_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06006657 RID: 26199
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRendererNode_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006658 RID: 26200 RVA: 0x00093824 File Offset: 0x00091A24
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRendererNode.vtkRendererNode_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06006659 RID: 26201
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRendererNode_GetScale_04(HandleRef pThis);

		/// <summary>
		/// Get/Set the window tile scale
		/// </summary>
		// Token: 0x0600665A RID: 26202 RVA: 0x00093840 File Offset: 0x00091A40
		public virtual int[] GetScale()
		{
			IntPtr intPtr = vtkRendererNode.vtkRendererNode_GetScale_04(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600665B RID: 26203
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRendererNode_GetScale_05(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Get/Set the window tile scale
		/// </summary>
		// Token: 0x0600665C RID: 26204 RVA: 0x00093888 File Offset: 0x00091A88
		public virtual void GetScale(ref int _arg1, ref int _arg2)
		{
			vtkRendererNode.vtkRendererNode_GetScale_05(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x0600665D RID: 26205
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRendererNode_GetScale_06(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the window tile scale
		/// </summary>
		// Token: 0x0600665E RID: 26206 RVA: 0x00093899 File Offset: 0x00091A99
		public virtual void GetScale(IntPtr _arg)
		{
			vtkRendererNode.vtkRendererNode_GetScale_06(base.GetCppThis(), _arg);
		}

		// Token: 0x0600665F RID: 26207
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRendererNode_GetSize_07(HandleRef pThis);

		/// <summary>
		/// Get/Set the framebuffer size
		/// </summary>
		// Token: 0x06006660 RID: 26208 RVA: 0x000938AC File Offset: 0x00091AAC
		public virtual int[] GetSize()
		{
			IntPtr intPtr = vtkRendererNode.vtkRendererNode_GetSize_07(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06006661 RID: 26209
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRendererNode_GetSize_08(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Get/Set the framebuffer size
		/// </summary>
		// Token: 0x06006662 RID: 26210 RVA: 0x000938F4 File Offset: 0x00091AF4
		public virtual void GetSize(ref int _arg1, ref int _arg2)
		{
			vtkRendererNode.vtkRendererNode_GetSize_08(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06006663 RID: 26211
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRendererNode_GetSize_09(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the framebuffer size
		/// </summary>
		// Token: 0x06006664 RID: 26212 RVA: 0x00093905 File Offset: 0x00091B05
		public virtual void GetSize(IntPtr _arg)
		{
			vtkRendererNode.vtkRendererNode_GetSize_09(base.GetCppThis(), _arg);
		}

		// Token: 0x06006665 RID: 26213
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRendererNode_GetViewport_10(HandleRef pThis);

		/// <summary>
		/// Get/Set the window viewport
		/// </summary>
		// Token: 0x06006666 RID: 26214 RVA: 0x00093918 File Offset: 0x00091B18
		public virtual double[] GetViewport()
		{
			IntPtr intPtr = vtkRendererNode.vtkRendererNode_GetViewport_10(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06006667 RID: 26215
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRendererNode_GetViewport_11(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

		/// <summary>
		/// Get/Set the window viewport
		/// </summary>
		// Token: 0x06006668 RID: 26216 RVA: 0x00093960 File Offset: 0x00091B60
		public virtual void GetViewport(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
		{
			vtkRendererNode.vtkRendererNode_GetViewport_11(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		// Token: 0x06006669 RID: 26217
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRendererNode_GetViewport_12(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the window viewport
		/// </summary>
		// Token: 0x0600666A RID: 26218 RVA: 0x00093974 File Offset: 0x00091B74
		public virtual void GetViewport(IntPtr _arg)
		{
			vtkRendererNode.vtkRendererNode_GetViewport_12(base.GetCppThis(), _arg);
		}

		// Token: 0x0600666B RID: 26219
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRendererNode_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600666C RID: 26220 RVA: 0x00093984 File Offset: 0x00091B84
		public override int IsA(string type)
		{
			return vtkRendererNode.vtkRendererNode_IsA_13(base.GetCppThis(), type);
		}

		// Token: 0x0600666D RID: 26221
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRendererNode_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600666E RID: 26222 RVA: 0x000939A4 File Offset: 0x00091BA4
		public new static int IsTypeOf(string type)
		{
			return vtkRendererNode.vtkRendererNode_IsTypeOf_14(type);
		}

		// Token: 0x0600666F RID: 26223
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRendererNode_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006670 RID: 26224 RVA: 0x000939C0 File Offset: 0x00091BC0
		public new vtkRendererNode NewInstance()
		{
			vtkRendererNode result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRendererNode.vtkRendererNode_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRendererNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006671 RID: 26225
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRendererNode_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006672 RID: 26226 RVA: 0x00093A1C File Offset: 0x00091C1C
		public new static vtkRendererNode SafeDownCast(vtkObjectBase o)
		{
			vtkRendererNode vtkRendererNode = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRendererNode.vtkRendererNode_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRendererNode = (vtkRendererNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRendererNode.Register(null);
				}
			}
			return vtkRendererNode;
		}

		// Token: 0x06006673 RID: 26227
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRendererNode_SetScale_18(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Get/Set the window tile scale
		/// </summary>
		// Token: 0x06006674 RID: 26228 RVA: 0x00093A9B File Offset: 0x00091C9B
		public virtual void SetScale(int _arg1, int _arg2)
		{
			vtkRendererNode.vtkRendererNode_SetScale_18(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x06006675 RID: 26229
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRendererNode_SetScale_19(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the window tile scale
		/// </summary>
		// Token: 0x06006676 RID: 26230 RVA: 0x00093AAC File Offset: 0x00091CAC
		public void SetScale(IntPtr _arg)
		{
			vtkRendererNode.vtkRendererNode_SetScale_19(base.GetCppThis(), _arg);
		}

		// Token: 0x06006677 RID: 26231
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRendererNode_SetSize_20(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Get/Set the framebuffer size
		/// </summary>
		// Token: 0x06006678 RID: 26232 RVA: 0x00093ABC File Offset: 0x00091CBC
		public virtual void SetSize(int _arg1, int _arg2)
		{
			vtkRendererNode.vtkRendererNode_SetSize_20(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x06006679 RID: 26233
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRendererNode_SetSize_21(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the framebuffer size
		/// </summary>
		// Token: 0x0600667A RID: 26234 RVA: 0x00093ACD File Offset: 0x00091CCD
		public void SetSize(IntPtr _arg)
		{
			vtkRendererNode.vtkRendererNode_SetSize_21(base.GetCppThis(), _arg);
		}

		// Token: 0x0600667B RID: 26235
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRendererNode_SetViewport_22(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

		/// <summary>
		/// Get/Set the window viewport
		/// </summary>
		// Token: 0x0600667C RID: 26236 RVA: 0x00093ADD File Offset: 0x00091CDD
		public virtual void SetViewport(double _arg1, double _arg2, double _arg3, double _arg4)
		{
			vtkRendererNode.vtkRendererNode_SetViewport_22(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		// Token: 0x0600667D RID: 26237
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRendererNode_SetViewport_23(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the window viewport
		/// </summary>
		// Token: 0x0600667E RID: 26238 RVA: 0x00093AF1 File Offset: 0x00091CF1
		public virtual void SetViewport(IntPtr _arg)
		{
			vtkRendererNode.vtkRendererNode_SetViewport_23(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000921 RID: 2337
		public new const string MRFullTypeName = "Kitware.VTK.vtkRendererNode";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000922 RID: 2338
		public new static readonly string MRClassNameKey = "class vtkRendererNode";
	}
}
