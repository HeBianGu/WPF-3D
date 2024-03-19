using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRenderStepsPass
	/// </summary>
	/// <remarks>
	///    Execute render passes sequentially.
	///
	/// vtkRenderStepsPass executes a standard list of render passes sequentially.
	/// This class allows to define a sequence of render passes at run time.
	/// You can set a step to NULL in order to skip that step. Likewise you
	/// can replace any of the default steps with your own step. Typically in
	/// such a case you would get the current step, replace it with your own
	/// and likely have your step call the current step as a delegate. For example
	/// to replace the translucent step with a depthpeeling step you would get the
	/// current tranlucent step and set it as a delegate on the depthpeeling step.
	/// Then set this classes translparent step to the depthpeelnig step.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRenderPass
	/// </seealso>
	// Token: 0x020005E4 RID: 1508
	public class vtkRenderStepsPass : vtkRenderPass
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060106E7 RID: 67303 RVA: 0x0016E7A7 File Offset: 0x0016C9A7
		static vtkRenderStepsPass()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRenderStepsPass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRenderStepsPass"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060106E8 RID: 67304 RVA: 0x0016E7CF File Offset: 0x0016C9CF
		public vtkRenderStepsPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060106E9 RID: 67305
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderStepsPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060106EA RID: 67306 RVA: 0x0016E7E0 File Offset: 0x0016C9E0
		public new static vtkRenderStepsPass New()
		{
			vtkRenderStepsPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderStepsPass.vtkRenderStepsPass_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderStepsPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060106EB RID: 67307 RVA: 0x0016E834 File Offset: 0x0016CA34
		public vtkRenderStepsPass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRenderStepsPass.vtkRenderStepsPass_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060106EC RID: 67308 RVA: 0x0016E878 File Offset: 0x0016CA78
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060106ED RID: 67309
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderStepsPass_GetCameraPass_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the RenderPass used for the Camera Step
		/// </summary>
		// Token: 0x060106EE RID: 67310 RVA: 0x0016E884 File Offset: 0x0016CA84
		public virtual vtkCameraPass GetCameraPass()
		{
			vtkCameraPass vtkCameraPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderStepsPass.vtkRenderStepsPass_GetCameraPass_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCameraPass = (vtkCameraPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCameraPass.Register(null);
				}
			}
			return vtkCameraPass;
		}

		// Token: 0x060106EF RID: 67311
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderStepsPass_GetLightsPass_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the RenderPass used for the Lights Step
		/// </summary>
		// Token: 0x060106F0 RID: 67312 RVA: 0x0016E8F4 File Offset: 0x0016CAF4
		public virtual vtkRenderPass GetLightsPass()
		{
			vtkRenderPass vtkRenderPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderStepsPass.vtkRenderStepsPass_GetLightsPass_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060106F1 RID: 67313
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRenderStepsPass_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060106F2 RID: 67314 RVA: 0x0016E964 File Offset: 0x0016CB64
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRenderStepsPass.vtkRenderStepsPass_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x060106F3 RID: 67315
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRenderStepsPass_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060106F4 RID: 67316 RVA: 0x0016E984 File Offset: 0x0016CB84
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRenderStepsPass.vtkRenderStepsPass_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x060106F5 RID: 67317
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderStepsPass_GetOpaquePass_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the RenderPass used for the Opaque Step
		/// </summary>
		// Token: 0x060106F6 RID: 67318 RVA: 0x0016E9A0 File Offset: 0x0016CBA0
		public virtual vtkRenderPass GetOpaquePass()
		{
			vtkRenderPass vtkRenderPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderStepsPass.vtkRenderStepsPass_GetOpaquePass_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060106F7 RID: 67319
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderStepsPass_GetOverlayPass_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the RenderPass used for the Overlay Step
		/// </summary>
		// Token: 0x060106F8 RID: 67320 RVA: 0x0016EA10 File Offset: 0x0016CC10
		public virtual vtkRenderPass GetOverlayPass()
		{
			vtkRenderPass vtkRenderPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderStepsPass.vtkRenderStepsPass_GetOverlayPass_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060106F9 RID: 67321
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderStepsPass_GetPostProcessPass_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the RenderPass used for the PostProcess Step
		/// </summary>
		// Token: 0x060106FA RID: 67322 RVA: 0x0016EA80 File Offset: 0x0016CC80
		public virtual vtkRenderPass GetPostProcessPass()
		{
			vtkRenderPass vtkRenderPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderStepsPass.vtkRenderStepsPass_GetPostProcessPass_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060106FB RID: 67323
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderStepsPass_GetTranslucentPass_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the RenderPass used for the translucent Step
		/// </summary>
		// Token: 0x060106FC RID: 67324 RVA: 0x0016EAF0 File Offset: 0x0016CCF0
		public virtual vtkRenderPass GetTranslucentPass()
		{
			vtkRenderPass vtkRenderPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderStepsPass.vtkRenderStepsPass_GetTranslucentPass_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060106FD RID: 67325
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderStepsPass_GetVolumetricPass_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the RenderPass used for the Volume Step
		/// </summary>
		// Token: 0x060106FE RID: 67326 RVA: 0x0016EB60 File Offset: 0x0016CD60
		public virtual vtkRenderPass GetVolumetricPass()
		{
			vtkRenderPass vtkRenderPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderStepsPass.vtkRenderStepsPass_GetVolumetricPass_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060106FF RID: 67327
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderStepsPass_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010700 RID: 67328 RVA: 0x0016EBD0 File Offset: 0x0016CDD0
		public override int IsA(string type)
		{
			return vtkRenderStepsPass.vtkRenderStepsPass_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x06010701 RID: 67329
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderStepsPass_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010702 RID: 67330 RVA: 0x0016EBF0 File Offset: 0x0016CDF0
		public new static int IsTypeOf(string type)
		{
			return vtkRenderStepsPass.vtkRenderStepsPass_IsTypeOf_11(type);
		}

		// Token: 0x06010703 RID: 67331
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderStepsPass_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010704 RID: 67332 RVA: 0x0016EC0C File Offset: 0x0016CE0C
		public new vtkRenderStepsPass NewInstance()
		{
			vtkRenderStepsPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderStepsPass.vtkRenderStepsPass_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderStepsPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010705 RID: 67333
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderStepsPass_ReleaseGraphicsResources_14(HandleRef pThis, HandleRef w);

		/// <summary>
		/// Release graphics resources and ask components to release their own
		/// resources.
		/// \pre w_exists: w!=0
		/// </summary>
		// Token: 0x06010706 RID: 67334 RVA: 0x0016EC68 File Offset: 0x0016CE68
		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkRenderStepsPass.vtkRenderStepsPass_ReleaseGraphicsResources_14(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		// Token: 0x06010707 RID: 67335
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderStepsPass_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010708 RID: 67336 RVA: 0x0016EC98 File Offset: 0x0016CE98
		public new static vtkRenderStepsPass SafeDownCast(vtkObjectBase o)
		{
			vtkRenderStepsPass vtkRenderStepsPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderStepsPass.vtkRenderStepsPass_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderStepsPass = (vtkRenderStepsPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderStepsPass.Register(null);
				}
			}
			return vtkRenderStepsPass;
		}

		// Token: 0x06010709 RID: 67337
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderStepsPass_SetCameraPass_16(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get the RenderPass used for the Camera Step
		/// </summary>
		// Token: 0x0601070A RID: 67338 RVA: 0x0016ED18 File Offset: 0x0016CF18
		public void SetCameraPass(vtkCameraPass arg0)
		{
			vtkRenderStepsPass.vtkRenderStepsPass_SetCameraPass_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601070B RID: 67339
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderStepsPass_SetLightsPass_17(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get the RenderPass used for the Lights Step
		/// </summary>
		// Token: 0x0601070C RID: 67340 RVA: 0x0016ED48 File Offset: 0x0016CF48
		public void SetLightsPass(vtkRenderPass arg0)
		{
			vtkRenderStepsPass.vtkRenderStepsPass_SetLightsPass_17(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601070D RID: 67341
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderStepsPass_SetOpaquePass_18(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get the RenderPass used for the Opaque Step
		/// </summary>
		// Token: 0x0601070E RID: 67342 RVA: 0x0016ED78 File Offset: 0x0016CF78
		public void SetOpaquePass(vtkRenderPass arg0)
		{
			vtkRenderStepsPass.vtkRenderStepsPass_SetOpaquePass_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601070F RID: 67343
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderStepsPass_SetOverlayPass_19(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get the RenderPass used for the Overlay Step
		/// </summary>
		// Token: 0x06010710 RID: 67344 RVA: 0x0016EDA8 File Offset: 0x0016CFA8
		public void SetOverlayPass(vtkRenderPass arg0)
		{
			vtkRenderStepsPass.vtkRenderStepsPass_SetOverlayPass_19(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06010711 RID: 67345
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderStepsPass_SetPostProcessPass_20(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get the RenderPass used for the PostProcess Step
		/// </summary>
		// Token: 0x06010712 RID: 67346 RVA: 0x0016EDD8 File Offset: 0x0016CFD8
		public void SetPostProcessPass(vtkRenderPass arg0)
		{
			vtkRenderStepsPass.vtkRenderStepsPass_SetPostProcessPass_20(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06010713 RID: 67347
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderStepsPass_SetTranslucentPass_21(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get the RenderPass used for the translucent Step
		/// </summary>
		// Token: 0x06010714 RID: 67348 RVA: 0x0016EE08 File Offset: 0x0016D008
		public void SetTranslucentPass(vtkRenderPass arg0)
		{
			vtkRenderStepsPass.vtkRenderStepsPass_SetTranslucentPass_21(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06010715 RID: 67349
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderStepsPass_SetVolumetricPass_22(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get the RenderPass used for the Volume Step
		/// </summary>
		// Token: 0x06010716 RID: 67350 RVA: 0x0016EE38 File Offset: 0x0016D038
		public void SetVolumetricPass(vtkRenderPass arg0)
		{
			vtkRenderStepsPass.vtkRenderStepsPass_SetVolumetricPass_22(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001314 RID: 4884
		public new const string MRFullTypeName = "Kitware.VTK.vtkRenderStepsPass";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001315 RID: 4885
		public new static readonly string MRClassNameKey = "class vtkRenderStepsPass";
	}
}
