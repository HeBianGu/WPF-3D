using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRenderPass
	/// </summary>
	/// <remarks>
	///    Perform part of the rendering of a vtkRenderer.
	///
	/// vtkRenderPass is a deferred class with a simple deferred method Render.
	/// This method performs a rendering pass of the scene described in
	/// vtkRenderState.
	/// Subclasses define what really happens during rendering.
	///
	/// Directions to write a subclass of vtkRenderPass:
	/// It is up to the subclass to decide if it needs to delegate part of its job
	/// to some other vtkRenderPass objects ("delegates").
	/// - The subclass has to define ivar to set/get its delegates.
	/// - The documentation of the subclass has to describe:
	///  - what each delegate is supposed to perform
	///  - if a delegate is supposed to be used once or multiple times
	///  - what it expects to have in the framebuffer before starting (status
	/// of colorbuffers, depth buffer, stencil buffer)
	///  - what it will change in the framebuffer.
	/// - A pass cannot modify the vtkRenderState where it will perform but
	/// it can build a new vtkRenderState (it can change the FrameBuffer, change the
	/// prop array, changed the required prop properties keys (usually adding some
	/// to a copy of the existing list) but it has to keep the same vtkRenderer
	/// object), make it current and pass it to its delegate.
	/// - at the end of the execution of Render, the pass has to ensure the
	/// current vtkRenderState is the one it has in argument.
	/// </remarks>
	/// <seealso>
	///
	/// vtkRenderState vtkRenderer
	/// </seealso>
	// Token: 0x0200057B RID: 1403
	public abstract class vtkRenderPass : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600F886 RID: 63622 RVA: 0x00159577 File Offset: 0x00157777
		static vtkRenderPass()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRenderPass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRenderPass"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600F887 RID: 63623 RVA: 0x0015959F File Offset: 0x0015779F
		public vtkRenderPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600F888 RID: 63624 RVA: 0x001595AD File Offset: 0x001577AD
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600F889 RID: 63625
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRenderPass_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F88A RID: 63626 RVA: 0x001595B8 File Offset: 0x001577B8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRenderPass.vtkRenderPass_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600F88B RID: 63627
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRenderPass_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F88C RID: 63628 RVA: 0x001595D8 File Offset: 0x001577D8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRenderPass.vtkRenderPass_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600F88D RID: 63629
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderPass_GetNumberOfRenderedProps_03(HandleRef pThis);

		/// <summary>
		/// Number of props rendered at the last Render call.
		/// </summary>
		// Token: 0x0600F88E RID: 63630 RVA: 0x001595F4 File Offset: 0x001577F4
		public virtual int GetNumberOfRenderedProps()
		{
			return vtkRenderPass.vtkRenderPass_GetNumberOfRenderedProps_03(base.GetCppThis());
		}

		// Token: 0x0600F88F RID: 63631
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderPass_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F890 RID: 63632 RVA: 0x00159614 File Offset: 0x00157814
		public override int IsA(string type)
		{
			return vtkRenderPass.vtkRenderPass_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600F891 RID: 63633
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderPass_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F892 RID: 63634 RVA: 0x00159634 File Offset: 0x00157834
		public new static int IsTypeOf(string type)
		{
			return vtkRenderPass.vtkRenderPass_IsTypeOf_05(type);
		}

		// Token: 0x0600F893 RID: 63635
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderPass_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F894 RID: 63636 RVA: 0x00159650 File Offset: 0x00157850
		public new vtkRenderPass NewInstance()
		{
			vtkRenderPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderPass.vtkRenderPass_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600F895 RID: 63637
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderPass_ReleaseGraphicsResources_07(HandleRef pThis, HandleRef w);

		/// <summary>
		/// Release graphics resources and ask components to release their own
		/// resources. Default implementation is empty.
		/// \pre w_exists: w!=0
		/// </summary>
		// Token: 0x0600F896 RID: 63638 RVA: 0x001596AC File Offset: 0x001578AC
		public virtual void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkRenderPass.vtkRenderPass_ReleaseGraphicsResources_07(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		// Token: 0x0600F897 RID: 63639
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderPass_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F898 RID: 63640 RVA: 0x001596DC File Offset: 0x001578DC
		public new static vtkRenderPass SafeDownCast(vtkObjectBase o)
		{
			vtkRenderPass vtkRenderPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderPass.vtkRenderPass_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400120F RID: 4623
		public new const string MRFullTypeName = "Kitware.VTK.vtkRenderPass";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001210 RID: 4624
		public new static readonly string MRClassNameKey = "class vtkRenderPass";
	}
}
