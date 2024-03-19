using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenGLFramebufferObject
	/// </summary>
	/// <remarks>
	///    Internal class which encapsulates OpenGL FramebufferObject
	///
	/// Before delving into this class it is best to have some background
	/// in some OpenGL terms. OpenGL has a notion of a currently
	/// bound Framebuffers for drawing and reading. It can be the default
	/// framebuffer such as created with a standard window/context or
	/// it can be a user created Framebuffer objects. When draw and read
	/// commands are invoked, they apply to the current draw and/or read
	/// framebuffers.
	///
	/// A framebuffer consists of color buffers and an optional depth buffer.
	/// The FramebufferObject does not hold the memory for these buffers, it
	/// just keeps track of what buffers are attached to it. The buffers themselves
	/// hold the storage for the pixels/depths.
	///
	/// In the context of this discussion a buffer can be either a
	/// vtkTextureObject (both 2D or a slice of a 3D texture) or
	/// a vtkRenderbuffer. In some cases a renderbuffer may be faster
	/// or more lightweight but you cannot pass a renderbuffer into
	/// a shader for sampling in a later pass like you can a texture.
	///
	/// You attach these buffers to the Framebuffer using methods
	/// such as AddColorAttachment or AddDepthAttachment
	/// In normal usage a buffer is Attached to a FramebufferObject
	/// and then some or all of the attached buffers are activated for drawing
	/// or reading.
	///
	/// When you have a framebuffer bound along with some buffers attached to it
	/// you can then activate specific buffers for drawing or reading. So you
	/// have draw and read framebuffer objects (bindings) and then for the currently
	/// bound FramebufferObjects you have active draw and read buffers.
	///
	/// A single FramebufferObject can be bound to both Draw and Read. You
	/// cannot assign and activate a TextureObject for drawing on the FO and
	/// at the same time pass it in as a Texture to the shader program. That
	/// type of operation is very common and must be done in two steps.
	///  - Render to the FO with the Texture attached as an active buffer
	///  - deactivate the texture obj and then render with the texture obj
	///    as a texture passed into the shader
	///
	/// Typical use cases:
	/// The simplest example
	///             <code>{.cpp}
	/// fbo-&gt;SetContext(renWin);
	/// fbo-&gt;SaveCurrentBindingsAndBuffers();
	/// fbo-&gt;PopulateFramebuffer(width, height);
	///
	/// ...
	///
	/// fbo-&gt;RestorePreviousBindingsAndBuffers();
	///             </code>
	///
	/// If you wish to use a texture you created
	///
	///             <code>{.cpp}
	/// fbo-&gt;SetContext(renWin);
	/// fbo-&gt;SaveCurrentBindingsAndBuffers();
	/// fbo-&gt;Bind();
	/// fbo-&gt;AddColorAttachment(0, vtkTextureObj);
	/// fbo-&gt;AddDepthAttachment(); // auto create depth buffer
	/// fbo-&gt;ActivateBuffer(0);
	///
	/// ...
	///
	/// fbo-&gt;RestorePreviousBindingsAndBuffers();
	///             </code>
	///
	/// If you will be using a FO repeatedly then it is best to create it
	/// attach the buffers and then use as needed for example
	///
	/// Typical use case:
	///             <code>{.cpp}
	/// // setup the FBO once
	/// fbo-&gt;SetContext(renWin);
	/// fbo-&gt;SaveCurrentBindingsAndBuffers();
	/// fbo-&gt;AddColorAttachment(0, vtkTextureObj);
	/// fbo-&gt;AddDepthAttachment(); // auto create depth buffer
	/// fbo-&gt;RestorePreviousBindingsAndBuffers();
	///
	/// // use it many times
	/// fbo-&gt;SaveCurrentBindingsAndBuffers();
	/// fbo-&gt;Bind();
	/// fbo-&gt;ActivateBuffer(0);
	/// ... // render here etc
	/// fbo-&gt;RestorePreviousBindingsAndBuffers();
	///             </code>
	///
	/// If you with to only bind the framebuffer for drawing or reading there
	/// are mode specific versions of some methods that only apply to the
	/// mode specified Draw/Read/Both. The mode argument uses OpenGL constants
	/// so this class provides convenience methods to return them named
	/// GetDrawMode() GetReadMode() and GetBothMode() so that your code
	/// does not need to be polluted with OpenGL headers/constants.
	///
	/// This class replaces both vtkFrameBufferObject and vtkFrameBufferObject2
	/// and contains methods from both of them. Most methods from FO2 should
	/// work with this class. Just rename FBO2 to FBO and make sure to Save and
	/// Restore the bindings and buffers.
	/// If you have been using the old FO class, which had comments
	/// in the header saying not to use it. Then you are in for a bit more of
	/// a conversion but generally it should still be easy. Use the code
	/// samples above (or any of the classes in OpenGL2 that currently use FBOs)
	/// to guide you. They have all been converted to this class. Where previously
	/// a DepthBuffer was automatically created for you, you now need to do it
	/// explicitly using AddDepthAttachment().
	///
	/// Note the capitalization of FramebufferObject
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkTextureObject, vtkRenderbufferObject
	/// </seealso>
	// Token: 0x020005A9 RID: 1449
	public class vtkOpenGLFramebufferObject : vtkFrameBufferObjectBase
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600FDE0 RID: 64992 RVA: 0x001619B3 File Offset: 0x0015FBB3
		static vtkOpenGLFramebufferObject()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLFramebufferObject.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLFramebufferObject"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600FDE1 RID: 64993 RVA: 0x001619DB File Offset: 0x0015FBDB
		public vtkOpenGLFramebufferObject(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600FDE2 RID: 64994
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLFramebufferObject_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FDE3 RID: 64995 RVA: 0x001619EC File Offset: 0x0015FBEC
		public new static vtkOpenGLFramebufferObject New()
		{
			vtkOpenGLFramebufferObject result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLFramebufferObject.vtkOpenGLFramebufferObject_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLFramebufferObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FDE4 RID: 64996 RVA: 0x00161A40 File Offset: 0x0015FC40
		public vtkOpenGLFramebufferObject() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenGLFramebufferObject.vtkOpenGLFramebufferObject_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600FDE5 RID: 64997 RVA: 0x00161A84 File Offset: 0x0015FC84
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600FDE6 RID: 64998
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFramebufferObject_ActivateBuffer_01(HandleRef pThis, uint id);

		/// <summary>
		/// Set up ortho viewport with scissor, lighting, blend, and depth
		/// disabled. The method affects the current bound FBO.
		/// </summary>
		// Token: 0x0600FDE7 RID: 64999 RVA: 0x00161A8F File Offset: 0x0015FC8F
		public void ActivateBuffer(uint id)
		{
			vtkOpenGLFramebufferObject.vtkOpenGLFramebufferObject_ActivateBuffer_01(base.GetCppThis(), id);
		}

		// Token: 0x0600FDE8 RID: 65000
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFramebufferObject_ActivateDrawBuffer_02(HandleRef pThis, uint id);

		/// <summary>
		/// Set up ortho viewport with scissor, lighting, blend, and depth
		/// disabled. The method affects the current bound FBO.
		/// </summary>
		// Token: 0x0600FDE9 RID: 65001 RVA: 0x00161A9F File Offset: 0x0015FC9F
		public void ActivateDrawBuffer(uint id)
		{
			vtkOpenGLFramebufferObject.vtkOpenGLFramebufferObject_ActivateDrawBuffer_02(base.GetCppThis(), id);
		}

		// Token: 0x0600FDEA RID: 65002
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFramebufferObject_ActivateDrawBuffers_03(HandleRef pThis, uint n);

		/// <summary>
		/// Set up ortho viewport with scissor, lighting, blend, and depth
		/// disabled. The method affects the current bound FBO.
		/// </summary>
		// Token: 0x0600FDEB RID: 65003 RVA: 0x00161AAF File Offset: 0x0015FCAF
		public void ActivateDrawBuffers(uint n)
		{
			vtkOpenGLFramebufferObject.vtkOpenGLFramebufferObject_ActivateDrawBuffers_03(base.GetCppThis(), n);
		}

		// Token: 0x0600FDEC RID: 65004
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFramebufferObject_ActivateDrawBuffers_04(HandleRef pThis, IntPtr ids, int n);

		/// <summary>
		/// Set up ortho viewport with scissor, lighting, blend, and depth
		/// disabled. The method affects the current bound FBO.
		/// </summary>
		// Token: 0x0600FDED RID: 65005 RVA: 0x00161ABF File Offset: 0x0015FCBF
		public void ActivateDrawBuffers(IntPtr ids, int n)
		{
			vtkOpenGLFramebufferObject.vtkOpenGLFramebufferObject_ActivateDrawBuffers_04(base.GetCppThis(), ids, n);
		}

		// Token: 0x0600FDEE RID: 65006
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFramebufferObject_ActivateReadBuffer_05(HandleRef pThis, uint id);

		/// <summary>
		/// Set up ortho viewport with scissor, lighting, blend, and depth
		/// disabled. The method affects the current bound FBO.
		/// </summary>
		// Token: 0x0600FDEF RID: 65007 RVA: 0x00161AD0 File Offset: 0x0015FCD0
		public void ActivateReadBuffer(uint id)
		{
			vtkOpenGLFramebufferObject.vtkOpenGLFramebufferObject_ActivateReadBuffer_05(base.GetCppThis(), id);
		}

		// Token: 0x0600FDF0 RID: 65008
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFramebufferObject_AddDepthAttachment_06(HandleRef pThis);

		/// <summary>
		/// Directly assign/remove a texture/renderbuffer to depth attachments.
		/// </summary>
		// Token: 0x0600FDF1 RID: 65009 RVA: 0x00161AE0 File Offset: 0x0015FCE0
		public void AddDepthAttachment()
		{
			vtkOpenGLFramebufferObject.vtkOpenGLFramebufferObject_AddDepthAttachment_06(base.GetCppThis());
		}

		// Token: 0x0600FDF2 RID: 65010
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFramebufferObject_Bind_07(HandleRef pThis);

		/// <summary>
		/// Make the draw frame buffer active.
		/// </summary>
		// Token: 0x0600FDF3 RID: 65011 RVA: 0x00161AEF File Offset: 0x0015FCEF
		public void Bind()
		{
			vtkOpenGLFramebufferObject.vtkOpenGLFramebufferObject_Bind_07(base.GetCppThis());
		}

		// Token: 0x0600FDF4 RID: 65012
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFramebufferObject_Bind_08(HandleRef pThis, uint mode);

		/// <summary>
		/// Make the draw frame buffer active.
		/// </summary>
		// Token: 0x0600FDF5 RID: 65013 RVA: 0x00161AFE File Offset: 0x0015FCFE
		public void Bind(uint mode)
		{
			vtkOpenGLFramebufferObject.vtkOpenGLFramebufferObject_Bind_08(base.GetCppThis(), mode);
		}

		// Token: 0x0600FDF6 RID: 65014
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLFramebufferObject_Blit_09(IntPtr srcExt, IntPtr destExt, uint bits, uint mapping);

		/// <summary>
		/// Copy from the currently bound READ FBO to the currently
		/// bound DRAW FBO. The method is static so that one doesn't
		/// need to ccreate an instance when transferring between attachments
		/// in the default FBO.
		/// </summary>
		// Token: 0x0600FDF7 RID: 65015 RVA: 0x00161B10 File Offset: 0x0015FD10
		public static int Blit(IntPtr srcExt, IntPtr destExt, uint bits, uint mapping)
		{
			return vtkOpenGLFramebufferObject.vtkOpenGLFramebufferObject_Blit_09(srcExt, destExt, bits, mapping);
		}

		// Token: 0x0600FDF8 RID: 65016
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLFramebufferObject_CheckFrameBufferStatus_10(HandleRef pThis, uint mode);

		/// <summary>
		/// Validate the current FBO configuration (attachments, formats, etc)
		/// prints detected errors to vtkErrorMacro.
		/// </summary>
		// Token: 0x0600FDF9 RID: 65017 RVA: 0x00161B30 File Offset: 0x0015FD30
		public int CheckFrameBufferStatus(uint mode)
		{
			return vtkOpenGLFramebufferObject.vtkOpenGLFramebufferObject_CheckFrameBufferStatus_10(base.GetCppThis(), mode);
		}

		// Token: 0x0600FDFA RID: 65018
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFramebufferObject_DeactivateDrawBuffers_11(HandleRef pThis);

		/// <summary>
		/// Set up ortho viewport with scissor, lighting, blend, and depth
		/// disabled. The method affects the current bound FBO.
		/// </summary>
		// Token: 0x0600FDFB RID: 65019 RVA: 0x00161B50 File Offset: 0x0015FD50
		public void DeactivateDrawBuffers()
		{
			vtkOpenGLFramebufferObject.vtkOpenGLFramebufferObject_DeactivateDrawBuffers_11(base.GetCppThis());
		}

		// Token: 0x0600FDFC RID: 65020
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFramebufferObject_DeactivateReadBuffer_12(HandleRef pThis);

		/// <summary>
		/// Set up ortho viewport with scissor, lighting, blend, and depth
		/// disabled. The method affects the current bound FBO.
		/// </summary>
		// Token: 0x0600FDFD RID: 65021 RVA: 0x00161B5F File Offset: 0x0015FD5F
		public void DeactivateReadBuffer()
		{
			vtkOpenGLFramebufferObject.vtkOpenGLFramebufferObject_DeactivateReadBuffer_12(base.GetCppThis());
		}

		// Token: 0x0600FDFE RID: 65022
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkOpenGLFramebufferObject_GetActiveDrawBuffer_13(HandleRef pThis, uint id);

		/// <summary>
		/// Set up ortho viewport with scissor, lighting, blend, and depth
		/// disabled. The method affects the current bound FBO.
		/// </summary>
		// Token: 0x0600FDFF RID: 65023 RVA: 0x00161B70 File Offset: 0x0015FD70
		public uint GetActiveDrawBuffer(uint id)
		{
			return vtkOpenGLFramebufferObject.vtkOpenGLFramebufferObject_GetActiveDrawBuffer_13(base.GetCppThis(), id);
		}

		// Token: 0x0600FE00 RID: 65024
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkOpenGLFramebufferObject_GetActiveReadBuffer_14(HandleRef pThis);

		/// <summary>
		/// Set up ortho viewport with scissor, lighting, blend, and depth
		/// disabled. The method affects the current bound FBO.
		/// </summary>
		// Token: 0x0600FE01 RID: 65025 RVA: 0x00161B90 File Offset: 0x0015FD90
		public virtual uint GetActiveReadBuffer()
		{
			return vtkOpenGLFramebufferObject.vtkOpenGLFramebufferObject_GetActiveReadBuffer_14(base.GetCppThis());
		}

		// Token: 0x0600FE02 RID: 65026
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkOpenGLFramebufferObject_GetBothMode_15();

		/// <summary>
		/// Download data from the read buffer of the current FBO. These
		/// are low level methods. In the static variant a PBO must be
		/// passed in since we don't have access to a context. The static
		/// method is provided so that one may download from the default
		/// FBO.
		/// </summary>
		// Token: 0x0600FE03 RID: 65027 RVA: 0x00161BB0 File Offset: 0x0015FDB0
		public static uint GetBothMode()
		{
			return vtkOpenGLFramebufferObject.vtkOpenGLFramebufferObject_GetBothMode_15();
		}

		// Token: 0x0600FE04 RID: 65028
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLFramebufferObject_GetContext_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the context. Context must be a vtkOpenGLRenderWindow.
		/// This does not increase the reference count of the
		/// context to avoid reference loops.
		/// SetContext() may raise an error if the OpenGL context does not support the
		/// required OpenGL extensions.
		/// </summary>
		// Token: 0x0600FE05 RID: 65029 RVA: 0x00161BCC File Offset: 0x0015FDCC
		public vtkOpenGLRenderWindow GetContext()
		{
			vtkOpenGLRenderWindow vtkOpenGLRenderWindow = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLFramebufferObject.vtkOpenGLFramebufferObject_GetContext_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLRenderWindow = (vtkOpenGLRenderWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLRenderWindow.Register(null);
				}
			}
			return vtkOpenGLRenderWindow;
		}

		// Token: 0x0600FE06 RID: 65030
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkOpenGLFramebufferObject_GetDrawMode_17();

		/// <summary>
		/// Download data from the read buffer of the current FBO. These
		/// are low level methods. In the static variant a PBO must be
		/// passed in since we don't have access to a context. The static
		/// method is provided so that one may download from the default
		/// FBO.
		/// </summary>
		// Token: 0x0600FE07 RID: 65031 RVA: 0x00161C3C File Offset: 0x0015FE3C
		public static uint GetDrawMode()
		{
			return vtkOpenGLFramebufferObject.vtkOpenGLFramebufferObject_GetDrawMode_17();
		}

		// Token: 0x0600FE08 RID: 65032
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkOpenGLFramebufferObject_GetFBOIndex_18(HandleRef pThis);

		/// <summary>
		/// Validate the current FBO configuration (attachments, formats, etc)
		/// return false if the FBO is incomplete. Assigns description a literal
		/// containing a description of the status.
		/// Low level api.
		/// </summary>
		// Token: 0x0600FE09 RID: 65033 RVA: 0x00161C58 File Offset: 0x0015FE58
		public virtual uint GetFBOIndex()
		{
			return vtkOpenGLFramebufferObject.vtkOpenGLFramebufferObject_GetFBOIndex_18(base.GetCppThis());
		}

		// Token: 0x0600FE0A RID: 65034
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLFramebufferObject_GetLastSize_19(HandleRef pThis);

		/// <summary>
		/// Dimensions in pixels of the framebuffer.
		/// </summary>
		// Token: 0x0600FE0B RID: 65035 RVA: 0x00161C78 File Offset: 0x0015FE78
		public override IntPtr GetLastSize()
		{
			return vtkOpenGLFramebufferObject.vtkOpenGLFramebufferObject_GetLastSize_19(base.GetCppThis());
		}

		// Token: 0x0600FE0C RID: 65036
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFramebufferObject_GetLastSize_20(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Dimensions in pixels of the framebuffer.
		/// </summary>
		// Token: 0x0600FE0D RID: 65037 RVA: 0x00161C97 File Offset: 0x0015FE97
		public override void GetLastSize(ref int _arg1, ref int _arg2)
		{
			vtkOpenGLFramebufferObject.vtkOpenGLFramebufferObject_GetLastSize_20(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x0600FE0E RID: 65038
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFramebufferObject_GetLastSize_21(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Dimensions in pixels of the framebuffer.
		/// </summary>
		// Token: 0x0600FE0F RID: 65039 RVA: 0x00161CA8 File Offset: 0x0015FEA8
		public override void GetLastSize(IntPtr _arg)
		{
			vtkOpenGLFramebufferObject.vtkOpenGLFramebufferObject_GetLastSize_21(base.GetCppThis(), _arg);
		}

		// Token: 0x0600FE10 RID: 65040
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkOpenGLFramebufferObject_GetMaximumNumberOfActiveTargets_22(HandleRef pThis);

		/// <summary>
		/// Returns the maximum number of targets that can be rendered to at one time.
		/// This limits the active targets set by SetActiveTargets().
		/// The return value is valid only if GetContext is non-null.
		/// </summary>
		// Token: 0x0600FE11 RID: 65041 RVA: 0x00161CB8 File Offset: 0x0015FEB8
		public uint GetMaximumNumberOfActiveTargets()
		{
			return vtkOpenGLFramebufferObject.vtkOpenGLFramebufferObject_GetMaximumNumberOfActiveTargets_22(base.GetCppThis());
		}

		// Token: 0x0600FE12 RID: 65042
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkOpenGLFramebufferObject_GetMaximumNumberOfRenderTargets_23(HandleRef pThis);

		/// <summary>
		/// Returns the maximum number of render targets available. This limits the
		/// available attachment points for SetColorAttachment().
		/// The return value is valid only if GetContext is non-null.
		/// </summary>
		// Token: 0x0600FE13 RID: 65043 RVA: 0x00161CD8 File Offset: 0x0015FED8
		public uint GetMaximumNumberOfRenderTargets()
		{
			return vtkOpenGLFramebufferObject.vtkOpenGLFramebufferObject_GetMaximumNumberOfRenderTargets_23(base.GetCppThis());
		}

		// Token: 0x0600FE14 RID: 65044
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLFramebufferObject_GetMultiSamples_24(HandleRef pThis);

		/// <summary>
		/// Resize all FO attachments
		/// </summary>
		// Token: 0x0600FE15 RID: 65045 RVA: 0x00161CF8 File Offset: 0x0015FEF8
		public int GetMultiSamples()
		{
			return vtkOpenGLFramebufferObject.vtkOpenGLFramebufferObject_GetMultiSamples_24(base.GetCppThis());
		}

		// Token: 0x0600FE16 RID: 65046
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLFramebufferObject_GetNumberOfColorAttachments_25(HandleRef pThis);

		/// <summary>
		/// Return the number of color attachments for the given mode
		/// </summary>
		// Token: 0x0600FE17 RID: 65047 RVA: 0x00161D18 File Offset: 0x0015FF18
		public int GetNumberOfColorAttachments()
		{
			return vtkOpenGLFramebufferObject.vtkOpenGLFramebufferObject_GetNumberOfColorAttachments_25(base.GetCppThis());
		}

		// Token: 0x0600FE18 RID: 65048
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLFramebufferObject_GetNumberOfGenerationsFromBase_26(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FE19 RID: 65049 RVA: 0x00161D38 File Offset: 0x0015FF38
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenGLFramebufferObject.vtkOpenGLFramebufferObject_GetNumberOfGenerationsFromBase_26(base.GetCppThis(), type);
		}

		// Token: 0x0600FE1A RID: 65050
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLFramebufferObject_GetNumberOfGenerationsFromBaseType_27([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FE1B RID: 65051 RVA: 0x00161D58 File Offset: 0x0015FF58
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenGLFramebufferObject.vtkOpenGLFramebufferObject_GetNumberOfGenerationsFromBaseType_27(type);
		}

		// Token: 0x0600FE1C RID: 65052
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkOpenGLFramebufferObject_GetReadMode_28();

		/// <summary>
		/// Download data from the read buffer of the current FBO. These
		/// are low level methods. In the static variant a PBO must be
		/// passed in since we don't have access to a context. The static
		/// method is provided so that one may download from the default
		/// FBO.
		/// </summary>
		// Token: 0x0600FE1D RID: 65053 RVA: 0x00161D74 File Offset: 0x0015FF74
		public static uint GetReadMode()
		{
			return vtkOpenGLFramebufferObject.vtkOpenGLFramebufferObject_GetReadMode_28();
		}

		// Token: 0x0600FE1E RID: 65054
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFramebufferObject_InitializeViewport_29(HandleRef pThis, int width, int height);

		/// <summary>
		/// Set up ortho viewport with scissor, lighting, blend, and depth
		/// disabled. The method affects the current bound FBO.
		/// </summary>
		// Token: 0x0600FE1F RID: 65055 RVA: 0x00161D8D File Offset: 0x0015FF8D
		public void InitializeViewport(int width, int height)
		{
			vtkOpenGLFramebufferObject.vtkOpenGLFramebufferObject_InitializeViewport_29(base.GetCppThis(), width, height);
		}

		// Token: 0x0600FE20 RID: 65056
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLFramebufferObject_IsA_30(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FE21 RID: 65057 RVA: 0x00161DA0 File Offset: 0x0015FFA0
		public override int IsA(string type)
		{
			return vtkOpenGLFramebufferObject.vtkOpenGLFramebufferObject_IsA_30(base.GetCppThis(), type);
		}

		// Token: 0x0600FE22 RID: 65058
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenGLFramebufferObject_IsSupported_31(HandleRef arg0);

		/// <summary>
		/// Returns if the context supports the required extensions.
		/// Extension will be loaded when the context is set.
		/// </summary>
		// Token: 0x0600FE23 RID: 65059 RVA: 0x00161DC0 File Offset: 0x0015FFC0
		public static bool IsSupported(vtkOpenGLRenderWindow arg0)
		{
			return vtkOpenGLFramebufferObject.vtkOpenGLFramebufferObject_IsSupported_31((arg0 == null) ? default(HandleRef) : arg0.GetCppThis()) != 0;
		}

		// Token: 0x0600FE24 RID: 65060
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLFramebufferObject_IsTypeOf_32([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FE25 RID: 65061 RVA: 0x00161DF8 File Offset: 0x0015FFF8
		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLFramebufferObject.vtkOpenGLFramebufferObject_IsTypeOf_32(type);
		}

		// Token: 0x0600FE26 RID: 65062
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLFramebufferObject_NewInstance_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FE27 RID: 65063 RVA: 0x00161E14 File Offset: 0x00160014
		public new vtkOpenGLFramebufferObject NewInstance()
		{
			vtkOpenGLFramebufferObject result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLFramebufferObject.vtkOpenGLFramebufferObject_NewInstance_34(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLFramebufferObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600FE28 RID: 65064
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenGLFramebufferObject_PopulateFramebuffer_35(HandleRef pThis, int width, int height);

		/// <summary>
		/// Convenience method to populate a framebuffer with
		/// attachments created as well. Returns true if a
		/// complete valid Framebuffer was created
		/// </summary>
		// Token: 0x0600FE29 RID: 65065 RVA: 0x00161E70 File Offset: 0x00160070
		public bool PopulateFramebuffer(int width, int height)
		{
			return vtkOpenGLFramebufferObject.vtkOpenGLFramebufferObject_PopulateFramebuffer_35(base.GetCppThis(), width, height) != 0;
		}

		// Token: 0x0600FE2A RID: 65066
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenGLFramebufferObject_PopulateFramebuffer_36(HandleRef pThis, int width, int height, byte useTextures, int numberOfColorAttachments, int colorDataType, byte wantDepthAttachment, int depthBitplanes, int multisamples, byte wantStencilAttachment);

		/// <summary>
		/// Convenience method to populate a framebuffer with
		/// attachments created as well. Returns true if a
		/// complete valid Framebuffer was created
		/// </summary>
		// Token: 0x0600FE2B RID: 65067 RVA: 0x00161E98 File Offset: 0x00160098
		public bool PopulateFramebuffer(int width, int height, bool useTextures, int numberOfColorAttachments, int colorDataType, bool wantDepthAttachment, int depthBitplanes, int multisamples, bool wantStencilAttachment)
		{
			return vtkOpenGLFramebufferObject.vtkOpenGLFramebufferObject_PopulateFramebuffer_36(base.GetCppThis(), width, height, useTextures ? (byte)1 : (byte)0, numberOfColorAttachments, colorDataType, wantDepthAttachment ? (byte)1 : (byte)0, depthBitplanes, multisamples, wantStencilAttachment ? (byte)1 : (byte)0) != 0;
		}

		// Token: 0x0600FE2C RID: 65068
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFramebufferObject_ReleaseGraphicsResources_37(HandleRef pThis, HandleRef win);

		/// <summary>
		/// Deactivate and UnBind
		/// </summary>
		// Token: 0x0600FE2D RID: 65069 RVA: 0x00161EE8 File Offset: 0x001600E8
		public virtual void ReleaseGraphicsResources(vtkWindow win)
		{
			vtkOpenGLFramebufferObject.vtkOpenGLFramebufferObject_ReleaseGraphicsResources_37(base.GetCppThis(), (win == null) ? default(HandleRef) : win.GetCppThis());
		}

		// Token: 0x0600FE2E RID: 65070
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFramebufferObject_RemoveColorAttachment_38(HandleRef pThis, uint index);

		/// <summary>
		/// Directly assign/remove a texture to color attachments.
		/// </summary>
		// Token: 0x0600FE2F RID: 65071 RVA: 0x00161F17 File Offset: 0x00160117
		public void RemoveColorAttachment(uint index)
		{
			vtkOpenGLFramebufferObject.vtkOpenGLFramebufferObject_RemoveColorAttachment_38(base.GetCppThis(), index);
		}

		// Token: 0x0600FE30 RID: 65072
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFramebufferObject_RemoveColorAttachments_39(HandleRef pThis, uint num);

		/// <summary>
		/// Directly assign/remove a texture to color attachments.
		/// </summary>
		// Token: 0x0600FE31 RID: 65073 RVA: 0x00161F27 File Offset: 0x00160127
		public void RemoveColorAttachments(uint num)
		{
			vtkOpenGLFramebufferObject.vtkOpenGLFramebufferObject_RemoveColorAttachments_39(base.GetCppThis(), num);
		}

		// Token: 0x0600FE32 RID: 65074
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFramebufferObject_RemoveDepthAttachment_40(HandleRef pThis);

		/// <summary>
		/// Directly assign/remove a texture/renderbuffer to depth attachments.
		/// </summary>
		// Token: 0x0600FE33 RID: 65075 RVA: 0x00161F37 File Offset: 0x00160137
		public void RemoveDepthAttachment()
		{
			vtkOpenGLFramebufferObject.vtkOpenGLFramebufferObject_RemoveDepthAttachment_40(base.GetCppThis());
		}

		// Token: 0x0600FE34 RID: 65076
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFramebufferObject_Resize_41(HandleRef pThis, int width, int height);

		/// <summary>
		/// Resize all FO attachments
		/// </summary>
		// Token: 0x0600FE35 RID: 65077 RVA: 0x00161F46 File Offset: 0x00160146
		public void Resize(int width, int height)
		{
			vtkOpenGLFramebufferObject.vtkOpenGLFramebufferObject_Resize_41(base.GetCppThis(), width, height);
		}

		// Token: 0x0600FE36 RID: 65078
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFramebufferObject_RestorePreviousBindingsAndBuffers_42(HandleRef pThis);

		/// <summary>
		/// Store/Restore the current framebuffer bindings and buffers.
		/// </summary>
		// Token: 0x0600FE37 RID: 65079 RVA: 0x00161F57 File Offset: 0x00160157
		public void RestorePreviousBindingsAndBuffers()
		{
			vtkOpenGLFramebufferObject.vtkOpenGLFramebufferObject_RestorePreviousBindingsAndBuffers_42(base.GetCppThis());
		}

		// Token: 0x0600FE38 RID: 65080
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFramebufferObject_RestorePreviousBindingsAndBuffers_43(HandleRef pThis, uint mode);

		/// <summary>
		/// Store/Restore the current framebuffer bindings and buffers.
		/// </summary>
		// Token: 0x0600FE39 RID: 65081 RVA: 0x00161F66 File Offset: 0x00160166
		public void RestorePreviousBindingsAndBuffers(uint mode)
		{
			vtkOpenGLFramebufferObject.vtkOpenGLFramebufferObject_RestorePreviousBindingsAndBuffers_43(base.GetCppThis(), mode);
		}

		// Token: 0x0600FE3A RID: 65082
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLFramebufferObject_SafeDownCast_44(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FE3B RID: 65083 RVA: 0x00161F78 File Offset: 0x00160178
		public new static vtkOpenGLFramebufferObject SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLFramebufferObject vtkOpenGLFramebufferObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLFramebufferObject.vtkOpenGLFramebufferObject_SafeDownCast_44((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLFramebufferObject = (vtkOpenGLFramebufferObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLFramebufferObject.Register(null);
				}
			}
			return vtkOpenGLFramebufferObject;
		}

		// Token: 0x0600FE3C RID: 65084
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFramebufferObject_SaveCurrentBindingsAndBuffers_45(HandleRef pThis);

		/// <summary>
		/// Store/Restore the current framebuffer bindings and buffers.
		/// </summary>
		// Token: 0x0600FE3D RID: 65085 RVA: 0x00161FF7 File Offset: 0x001601F7
		public void SaveCurrentBindingsAndBuffers()
		{
			vtkOpenGLFramebufferObject.vtkOpenGLFramebufferObject_SaveCurrentBindingsAndBuffers_45(base.GetCppThis());
		}

		// Token: 0x0600FE3E RID: 65086
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFramebufferObject_SaveCurrentBindingsAndBuffers_46(HandleRef pThis, uint mode);

		/// <summary>
		/// Store/Restore the current framebuffer bindings and buffers.
		/// </summary>
		// Token: 0x0600FE3F RID: 65087 RVA: 0x00162006 File Offset: 0x00160206
		public void SaveCurrentBindingsAndBuffers(uint mode)
		{
			vtkOpenGLFramebufferObject.vtkOpenGLFramebufferObject_SaveCurrentBindingsAndBuffers_46(base.GetCppThis(), mode);
		}

		// Token: 0x0600FE40 RID: 65088
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFramebufferObject_SetContext_47(HandleRef pThis, HandleRef context);

		/// <summary>
		/// Get/Set the context. Context must be a vtkOpenGLRenderWindow.
		/// This does not increase the reference count of the
		/// context to avoid reference loops.
		/// SetContext() may raise an error if the OpenGL context does not support the
		/// required OpenGL extensions.
		/// </summary>
		// Token: 0x0600FE41 RID: 65089 RVA: 0x00162018 File Offset: 0x00160218
		public void SetContext(vtkRenderWindow context)
		{
			vtkOpenGLFramebufferObject.vtkOpenGLFramebufferObject_SetContext_47(base.GetCppThis(), (context == null) ? default(HandleRef) : context.GetCppThis());
		}

		// Token: 0x0600FE42 RID: 65090
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenGLFramebufferObject_Start_48(HandleRef pThis, int width, int height);

		/// <summary>
		/// User must take care that width/height match the dimensions of
		/// the user defined texture attachments.
		/// This method makes the "active buffers" the buffers that will get drawn
		/// into by subsequent drawing calls.
		/// Note that this does not clear the render buffers i.e. no glClear() calls
		/// are made by either of these methods. It's up to the caller to clear the
		/// buffers if needed.
		/// </summary>
		// Token: 0x0600FE43 RID: 65091 RVA: 0x00162048 File Offset: 0x00160248
		public bool Start(int width, int height)
		{
			return vtkOpenGLFramebufferObject.vtkOpenGLFramebufferObject_Start_48(base.GetCppThis(), width, height) != 0;
		}

		// Token: 0x0600FE44 RID: 65092
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenGLFramebufferObject_StartNonOrtho_49(HandleRef pThis, int width, int height);

		/// <summary>
		/// User must take care that width/height match the dimensions of
		/// the user defined texture attachments.
		/// This method makes the "active buffers" the buffers that will get drawn
		/// into by subsequent drawing calls.
		/// Note that this does not clear the render buffers i.e. no glClear() calls
		/// are made by either of these methods. It's up to the caller to clear the
		/// buffers if needed.
		/// </summary>
		// Token: 0x0600FE45 RID: 65093 RVA: 0x00162070 File Offset: 0x00160270
		public bool StartNonOrtho(int width, int height)
		{
			return vtkOpenGLFramebufferObject.vtkOpenGLFramebufferObject_StartNonOrtho_49(base.GetCppThis(), width, height) != 0;
		}

		// Token: 0x0600FE46 RID: 65094
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFramebufferObject_UnBind_50(HandleRef pThis);

		/// <summary>
		/// Unbind this buffer
		/// </summary>
		// Token: 0x0600FE47 RID: 65095 RVA: 0x00162098 File Offset: 0x00160298
		public void UnBind()
		{
			vtkOpenGLFramebufferObject.vtkOpenGLFramebufferObject_UnBind_50(base.GetCppThis());
		}

		// Token: 0x0600FE48 RID: 65096
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFramebufferObject_UnBind_51(HandleRef pThis, uint mode);

		/// <summary>
		/// Unbind this buffer
		/// </summary>
		// Token: 0x0600FE49 RID: 65097 RVA: 0x001620A7 File Offset: 0x001602A7
		public void UnBind(uint mode)
		{
			vtkOpenGLFramebufferObject.vtkOpenGLFramebufferObject_UnBind_51(base.GetCppThis(), mode);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001284 RID: 4740
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLFramebufferObject";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001285 RID: 4741
		public new static readonly string MRClassNameKey = "class vtkOpenGLFramebufferObject";
	}
}
