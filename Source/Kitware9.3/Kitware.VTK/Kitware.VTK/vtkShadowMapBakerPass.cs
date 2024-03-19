using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkShadowMapBakerPass
	/// </summary>
	/// <remarks>
	///    Implement a builder of shadow map pass.
	///
	/// Bake a list of shadow maps, once per spot light.
	/// It work in conjunction with the vtkShadowMapPass, which uses the
	/// shadow maps for rendering the opaque geometry (a technique to render hard
	/// shadows in hardware).
	///
	/// This pass expects an initialized depth buffer and color buffer.
	/// Initialized buffers means they have been cleared with farthest z-value and
	/// background color/gradient/transparent color.
	/// An opaque pass may have been performed right after the initialization.
	///
	///
	///
	/// Its delegate is usually set to a vtkOpaquePass.
	///
	/// @par Implementation:
	/// The first pass of the algorithm is to generate a shadow map per light
	/// (depth map from the light point of view) by rendering the opaque objects
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRenderPass, vtkOpaquePass, vtkShadowMapPass
	/// </seealso>
	// Token: 0x020005ED RID: 1517
	public class vtkShadowMapBakerPass : vtkOpenGLRenderPass
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601080B RID: 67595 RVA: 0x00170602 File Offset: 0x0016E802
		static vtkShadowMapBakerPass()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkShadowMapBakerPass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkShadowMapBakerPass"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601080C RID: 67596 RVA: 0x0017062A File Offset: 0x0016E82A
		public vtkShadowMapBakerPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601080D RID: 67597
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkShadowMapBakerPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601080E RID: 67598 RVA: 0x00170638 File Offset: 0x0016E838
		public new static vtkShadowMapBakerPass New()
		{
			vtkShadowMapBakerPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkShadowMapBakerPass.vtkShadowMapBakerPass_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkShadowMapBakerPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601080F RID: 67599 RVA: 0x0017068C File Offset: 0x0016E88C
		public vtkShadowMapBakerPass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkShadowMapBakerPass.vtkShadowMapBakerPass_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010810 RID: 67600 RVA: 0x001706D0 File Offset: 0x0016E8D0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06010811 RID: 67601
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkShadowMapBakerPass_GetCompositeZPass_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Delegate for compositing of the shadow maps across processors.
		/// If it is NULL, there is no z compositing.
		/// It is usually set to a vtkCompositeZPass (Parallel package).
		/// Initial value is a NULL pointer.
		/// </summary>
		// Token: 0x06010812 RID: 67602 RVA: 0x001706DC File Offset: 0x0016E8DC
		public virtual vtkRenderPass GetCompositeZPass()
		{
			vtkRenderPass vtkRenderPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkShadowMapBakerPass.vtkShadowMapBakerPass_GetCompositeZPass_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderPass = (vtkRenderPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderPass.Register(null);
				}
			}
			return vtkRenderPass;
		}

		// Token: 0x06010813 RID: 67603
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkShadowMapBakerPass_GetHasShadows_02(HandleRef pThis);

		/// <summary>
		/// INTERNAL USE ONLY.
		/// Internally used by vtkShadowMapBakerPass and vtkShadowMapPass.
		///
		/// Tell if there is at least one shadow.
		/// Initial value is false.
		/// </summary>
		// Token: 0x06010814 RID: 67604 RVA: 0x0017074C File Offset: 0x0016E94C
		public bool GetHasShadows()
		{
			return vtkShadowMapBakerPass.vtkShadowMapBakerPass_GetHasShadows_02(base.GetCppThis()) != 0;
		}

		// Token: 0x06010815 RID: 67605
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkShadowMapBakerPass_GetNeedUpdate_03(HandleRef pThis);

		/// <summary>
		/// INTERNAL USE ONLY.
		/// Internally used by vtkShadowMapBakerPass and vtkShadowMapPass.
		///
		/// Do the shadows need to be updated?
		/// Value changed by vtkShadowMapBakerPass and used by vtkShadowMapPass.
		/// Initial value is true.
		/// </summary>
		// Token: 0x06010816 RID: 67606 RVA: 0x00170774 File Offset: 0x0016E974
		public bool GetNeedUpdate()
		{
			return vtkShadowMapBakerPass.vtkShadowMapBakerPass_GetNeedUpdate_03(base.GetCppThis()) != 0;
		}

		// Token: 0x06010817 RID: 67607
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkShadowMapBakerPass_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010818 RID: 67608 RVA: 0x0017079C File Offset: 0x0016E99C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkShadowMapBakerPass.vtkShadowMapBakerPass_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06010819 RID: 67609
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkShadowMapBakerPass_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601081A RID: 67610 RVA: 0x001707BC File Offset: 0x0016E9BC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkShadowMapBakerPass.vtkShadowMapBakerPass_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601081B RID: 67611
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkShadowMapBakerPass_GetOpaqueSequence_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Delegate for rendering the camera, lights, and opaque geometry.
		/// If it is NULL, nothing will be rendered and a warning will be emitted.
		/// It defaults to a vtkCameraPass with a sequence of
		/// vtkLightPass/vtkOpaquePass.
		/// </summary>
		// Token: 0x0601081C RID: 67612 RVA: 0x001707D8 File Offset: 0x0016E9D8
		public virtual vtkRenderPass GetOpaqueSequence()
		{
			vtkRenderPass vtkRenderPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkShadowMapBakerPass.vtkShadowMapBakerPass_GetOpaqueSequence_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderPass = (vtkRenderPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderPass.Register(null);
				}
			}
			return vtkRenderPass;
		}

		// Token: 0x0601081D RID: 67613
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkShadowMapBakerPass_GetResolution_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of pixels in each dimension of the shadow maps
		/// (shadow maps are square). Initial value is 256. The greater the better.
		/// Resolution does not have to be a power-of-two value.
		/// </summary>
		// Token: 0x0601081E RID: 67614 RVA: 0x00170848 File Offset: 0x0016EA48
		public virtual uint GetResolution()
		{
			return vtkShadowMapBakerPass.vtkShadowMapBakerPass_GetResolution_07(base.GetCppThis());
		}

		// Token: 0x0601081F RID: 67615
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkShadowMapBakerPass_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010820 RID: 67616 RVA: 0x00170868 File Offset: 0x0016EA68
		public override int IsA(string type)
		{
			return vtkShadowMapBakerPass.vtkShadowMapBakerPass_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x06010821 RID: 67617
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkShadowMapBakerPass_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010822 RID: 67618 RVA: 0x00170888 File Offset: 0x0016EA88
		public new static int IsTypeOf(string type)
		{
			return vtkShadowMapBakerPass.vtkShadowMapBakerPass_IsTypeOf_09(type);
		}

		// Token: 0x06010823 RID: 67619
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkShadowMapBakerPass_LightCreatesShadow_10(HandleRef pThis, HandleRef l);

		/// <summary>
		/// INTERNAL USE ONLY.
		/// Internally used by vtkShadowMapBakerPass and vtkShadowMapPass.
		///
		/// Tell if the light `l' can create shadows.
		/// The light has to not be a head light and to be directional or
		/// positional with an angle less than 180 degrees.
		/// \pre l_exists: l!=0
		/// </summary>
		// Token: 0x06010824 RID: 67620 RVA: 0x001708A4 File Offset: 0x0016EAA4
		public bool LightCreatesShadow(vtkLight l)
		{
			return vtkShadowMapBakerPass.vtkShadowMapBakerPass_LightCreatesShadow_10(base.GetCppThis(), (l == null) ? default(HandleRef) : l.GetCppThis()) != 0;
		}

		// Token: 0x06010825 RID: 67621
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkShadowMapBakerPass_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010826 RID: 67622 RVA: 0x001708E0 File Offset: 0x0016EAE0
		public new vtkShadowMapBakerPass NewInstance()
		{
			vtkShadowMapBakerPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkShadowMapBakerPass.vtkShadowMapBakerPass_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkShadowMapBakerPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010827 RID: 67623
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkShadowMapBakerPass_ReleaseGraphicsResources_13(HandleRef pThis, HandleRef w);

		/// <summary>
		/// Release graphics resources and ask components to release their own
		/// resources.
		/// \pre w_exists: w!=0
		/// </summary>
		// Token: 0x06010828 RID: 67624 RVA: 0x0017093C File Offset: 0x0016EB3C
		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkShadowMapBakerPass.vtkShadowMapBakerPass_ReleaseGraphicsResources_13(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		// Token: 0x06010829 RID: 67625
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkShadowMapBakerPass_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601082A RID: 67626 RVA: 0x0017096C File Offset: 0x0016EB6C
		public new static vtkShadowMapBakerPass SafeDownCast(vtkObjectBase o)
		{
			vtkShadowMapBakerPass vtkShadowMapBakerPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkShadowMapBakerPass.vtkShadowMapBakerPass_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkShadowMapBakerPass = (vtkShadowMapBakerPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkShadowMapBakerPass.Register(null);
				}
			}
			return vtkShadowMapBakerPass;
		}

		// Token: 0x0601082B RID: 67627
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkShadowMapBakerPass_SetCompositeZPass_15(HandleRef pThis, HandleRef compositeZPass);

		/// <summary>
		/// Delegate for compositing of the shadow maps across processors.
		/// If it is NULL, there is no z compositing.
		/// It is usually set to a vtkCompositeZPass (Parallel package).
		/// Initial value is a NULL pointer.
		/// </summary>
		// Token: 0x0601082C RID: 67628 RVA: 0x001709EC File Offset: 0x0016EBEC
		public virtual void SetCompositeZPass(vtkRenderPass compositeZPass)
		{
			vtkShadowMapBakerPass.vtkShadowMapBakerPass_SetCompositeZPass_15(base.GetCppThis(), (compositeZPass == null) ? default(HandleRef) : compositeZPass.GetCppThis());
		}

		// Token: 0x0601082D RID: 67629
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkShadowMapBakerPass_SetOpaqueSequence_16(HandleRef pThis, HandleRef opaqueSequence);

		/// <summary>
		/// Delegate for rendering the camera, lights, and opaque geometry.
		/// If it is NULL, nothing will be rendered and a warning will be emitted.
		/// It defaults to a vtkCameraPass with a sequence of
		/// vtkLightPass/vtkOpaquePass.
		/// </summary>
		// Token: 0x0601082E RID: 67630 RVA: 0x00170A1C File Offset: 0x0016EC1C
		public virtual void SetOpaqueSequence(vtkRenderPass opaqueSequence)
		{
			vtkShadowMapBakerPass.vtkShadowMapBakerPass_SetOpaqueSequence_16(base.GetCppThis(), (opaqueSequence == null) ? default(HandleRef) : opaqueSequence.GetCppThis());
		}

		// Token: 0x0601082F RID: 67631
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkShadowMapBakerPass_SetResolution_17(HandleRef pThis, uint _arg);

		/// <summary>
		/// Set/Get the number of pixels in each dimension of the shadow maps
		/// (shadow maps are square). Initial value is 256. The greater the better.
		/// Resolution does not have to be a power-of-two value.
		/// </summary>
		// Token: 0x06010830 RID: 67632 RVA: 0x00170A4B File Offset: 0x0016EC4B
		public virtual void SetResolution(uint _arg)
		{
			vtkShadowMapBakerPass.vtkShadowMapBakerPass_SetResolution_17(base.GetCppThis(), _arg);
		}

		// Token: 0x06010831 RID: 67633
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkShadowMapBakerPass_SetUpToDate_18(HandleRef pThis);

		/// <summary>
		/// INTERNAL USE ONLY.
		/// Internally used by vtkShadowMapBakerPass and vtkShadowMapPass.
		///
		/// Do the shadows need to be updated?
		/// Value changed by vtkShadowMapBakerPass and used by vtkShadowMapPass.
		/// Initial value is true.
		/// </summary>
		// Token: 0x06010832 RID: 67634 RVA: 0x00170A5B File Offset: 0x0016EC5B
		public void SetUpToDate()
		{
			vtkShadowMapBakerPass.vtkShadowMapBakerPass_SetUpToDate_18(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400132C RID: 4908
		public new const string MRFullTypeName = "Kitware.VTK.vtkShadowMapBakerPass";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400132D RID: 4909
		public new static readonly string MRClassNameKey = "class vtkShadowMapBakerPass";
	}
}
