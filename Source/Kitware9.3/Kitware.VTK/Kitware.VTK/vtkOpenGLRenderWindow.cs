using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenGLRenderWindow
	/// </summary>
	/// <remarks>
	///    OpenGL rendering window
	///
	/// vtkOpenGLRenderWindow is a concrete implementation of the abstract class
	/// vtkRenderWindow. vtkOpenGLRenderer interfaces to the OpenGL graphics
	/// library. Application programmers should normally use vtkRenderWindow
	/// instead of the OpenGL specific version.
	/// </remarks>
	// Token: 0x02000092 RID: 146
	public abstract class vtkOpenGLRenderWindow : vtkRenderWindow
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06001DA9 RID: 7593 RVA: 0x0002E131 File Offset: 0x0002C331
		static vtkOpenGLRenderWindow()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLRenderWindow.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLRenderWindow"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06001DAA RID: 7594 RVA: 0x0002E159 File Offset: 0x0002C359
		public vtkOpenGLRenderWindow(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06001DAB RID: 7595 RVA: 0x0002E167 File Offset: 0x0002C367
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06001DAC RID: 7596
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLRenderWindow_BlitDisplayFramebuffer_01(HandleRef pThis);

		/// <summary>
		/// Blit a display framebuffer into a currently bound draw destination
		/// </summary>
		// Token: 0x06001DAD RID: 7597 RVA: 0x0002E172 File Offset: 0x0002C372
		public void BlitDisplayFramebuffer()
		{
			vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_BlitDisplayFramebuffer_01(base.GetCppThis());
		}

		// Token: 0x06001DAE RID: 7598
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLRenderWindow_BlitDisplayFramebuffer_02(HandleRef pThis, int right, int srcX, int srcY, int srcWidth, int srcHeight, int destX, int destY, int destWidth, int destHeight, int bufferMode, int interpolation);

		/// <summary>
		/// Blit a display buffer into a currently bound draw destination
		/// </summary>
		// Token: 0x06001DAF RID: 7599 RVA: 0x0002E184 File Offset: 0x0002C384
		public void BlitDisplayFramebuffer(int right, int srcX, int srcY, int srcWidth, int srcHeight, int destX, int destY, int destWidth, int destHeight, int bufferMode, int interpolation)
		{
			vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_BlitDisplayFramebuffer_02(base.GetCppThis(), right, srcX, srcY, srcWidth, srcHeight, destX, destY, destWidth, destHeight, bufferMode, interpolation);
		}

		// Token: 0x06001DB0 RID: 7600
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLRenderWindow_BlitToRenderFramebuffer_03(HandleRef pThis, byte includeDepth);

		/// <summary>
		/// Blit the currently bound read buffer to the renderbuffer. This is useful for
		/// taking rendering from an external system and then having VTK draw on top of it.
		/// </summary>
		// Token: 0x06001DB1 RID: 7601 RVA: 0x0002E1B1 File Offset: 0x0002C3B1
		public void BlitToRenderFramebuffer(bool includeDepth)
		{
			vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_BlitToRenderFramebuffer_03(base.GetCppThis(), includeDepth ? (byte)1 : (byte)0);
		}

		// Token: 0x06001DB2 RID: 7602
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLRenderWindow_BlitToRenderFramebuffer_04(HandleRef pThis, int srcX, int srcY, int srcWidth, int srcHeight, int destX, int destY, int destWidth, int destHeight, int bufferMode, int interpolation);

		/// <summary>
		/// Blit the currently bound read buffer to the renderbuffer. This is useful for
		/// taking rendering from an external system and then having VTK draw on top of it.
		/// </summary>
		// Token: 0x06001DB3 RID: 7603 RVA: 0x0002E1CC File Offset: 0x0002C3CC
		public void BlitToRenderFramebuffer(int srcX, int srcY, int srcWidth, int srcHeight, int destX, int destY, int destWidth, int destHeight, int bufferMode, int interpolation)
		{
			vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_BlitToRenderFramebuffer_04(base.GetCppThis(), srcX, srcY, srcWidth, srcHeight, destX, destY, destWidth, destHeight, bufferMode, interpolation);
		}

		// Token: 0x06001DB4 RID: 7604
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLRenderWindow_DrawPixels_05(HandleRef pThis, int x1, int y1, int x2, int y2, int numComponents, int dataType, IntPtr data);

		/// <summary>
		/// Replacement for the old glDrawPixels function
		/// </summary>
		// Token: 0x06001DB5 RID: 7605 RVA: 0x0002E1F7 File Offset: 0x0002C3F7
		public virtual void DrawPixels(int x1, int y1, int x2, int y2, int numComponents, int dataType, IntPtr data)
		{
			vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_DrawPixels_05(base.GetCppThis(), x1, y1, x2, y2, numComponents, dataType, data);
		}

		// Token: 0x06001DB6 RID: 7606
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLRenderWindow_DrawPixels_06(HandleRef pThis, int dstXmin, int dstYmin, int dstXmax, int dstYmax, int srcXmin, int srcYmin, int srcXmax, int srcYmax, int srcWidth, int srcHeight, int numComponents, int dataType, IntPtr data);

		/// <summary>
		/// Replacement for the old glDrawPixels function, but it allows
		/// for scaling the data and using only part of the texture
		/// </summary>
		// Token: 0x06001DB7 RID: 7607 RVA: 0x0002E214 File Offset: 0x0002C414
		public virtual void DrawPixels(int dstXmin, int dstYmin, int dstXmax, int dstYmax, int srcXmin, int srcYmin, int srcXmax, int srcYmax, int srcWidth, int srcHeight, int numComponents, int dataType, IntPtr data)
		{
			vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_DrawPixels_06(base.GetCppThis(), dstXmin, dstYmin, dstXmax, dstYmax, srcXmin, srcYmin, srcXmax, srcYmax, srcWidth, srcHeight, numComponents, dataType, data);
		}

		// Token: 0x06001DB8 RID: 7608
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLRenderWindow_DrawPixels_07(HandleRef pThis, int srcWidth, int srcHeight, int numComponents, int dataType, IntPtr data);

		/// <summary>
		/// Replacement for the old glDrawPixels function.  This simple version draws all
		/// the data to the entire current viewport scaling as needed.
		/// </summary>
		// Token: 0x06001DB9 RID: 7609 RVA: 0x0002E245 File Offset: 0x0002C445
		public virtual void DrawPixels(int srcWidth, int srcHeight, int numComponents, int dataType, IntPtr data)
		{
			vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_DrawPixels_07(base.GetCppThis(), srcWidth, srcHeight, numComponents, dataType, data);
		}

		// Token: 0x06001DBA RID: 7610
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLRenderWindow_End_08(HandleRef pThis);

		/// <summary>
		/// Update the system, if needed, at end of render process
		/// </summary>
		// Token: 0x06001DBB RID: 7611 RVA: 0x0002E25B File Offset: 0x0002C45B
		public override void End()
		{
			vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_End_08(base.GetCppThis());
		}

		// Token: 0x06001DBC RID: 7612
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLRenderWindow_Frame_09(HandleRef pThis);

		/// <summary>
		/// A termination method performed at the end of the rendering process
		/// to do things like swapping buffers (if necessary) or similar actions.
		/// </summary>
		// Token: 0x06001DBD RID: 7613 RVA: 0x0002E26A File Offset: 0x0002C46A
		public override void Frame()
		{
			vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_Frame_09(base.GetCppThis());
		}

		// Token: 0x06001DBE RID: 7614
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLRenderWindow_FramebufferFlipYOff_10(HandleRef pThis);

		/// <summary>
		/// Enable/Disable flipping the Y axis of the rendered texture.
		/// </summary>
		// Token: 0x06001DBF RID: 7615 RVA: 0x0002E279 File Offset: 0x0002C479
		public virtual void FramebufferFlipYOff()
		{
			vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_FramebufferFlipYOff_10(base.GetCppThis());
		}

		// Token: 0x06001DC0 RID: 7616
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLRenderWindow_FramebufferFlipYOn_11(HandleRef pThis);

		/// <summary>
		/// Enable/Disable flipping the Y axis of the rendered texture.
		/// </summary>
		// Token: 0x06001DC1 RID: 7617 RVA: 0x0002E288 File Offset: 0x0002C488
		public virtual void FramebufferFlipYOn()
		{
			vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_FramebufferFlipYOn_11(base.GetCppThis());
		}

		// Token: 0x06001DC2 RID: 7618
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenGLRenderWindow_GetBufferNeedsResolving_12(HandleRef pThis);

		/// <summary>
		/// Intermediate method performs operations required between the rendering
		/// of the left and right eye.
		/// </summary>
		// Token: 0x06001DC3 RID: 7619 RVA: 0x0002E298 File Offset: 0x0002C498
		public bool GetBufferNeedsResolving()
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_GetBufferNeedsResolving_12(base.GetCppThis()) != 0;
		}

		// Token: 0x06001DC4 RID: 7620
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLRenderWindow_GetColorBufferInternalFormat_13(HandleRef pThis, int attachmentPoint);

		/// <summary>
		/// Get the internal format of current attached texture or render buffer.
		/// attachmentPoint is the index of attachment.
		/// Returns 0 if not able to determine.
		/// </summary>
		// Token: 0x06001DC5 RID: 7621 RVA: 0x0002E2C0 File Offset: 0x0002C4C0
		public int GetColorBufferInternalFormat(int attachmentPoint)
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_GetColorBufferInternalFormat_13(base.GetCppThis(), attachmentPoint);
		}

		// Token: 0x06001DC6 RID: 7622
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLRenderWindow_GetColorBufferSizes_14(HandleRef pThis, IntPtr rgba);

		/// <summary>
		/// Get the size of the color buffer.
		/// Returns 0 if not able to determine otherwise sets R G B and A into buffer.
		/// </summary>
		// Token: 0x06001DC7 RID: 7623 RVA: 0x0002E2E0 File Offset: 0x0002C4E0
		public override int GetColorBufferSizes(IntPtr rgba)
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_GetColorBufferSizes_14(base.GetCppThis(), rgba);
		}

		// Token: 0x06001DC8 RID: 7624
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkOpenGLRenderWindow_GetContextCreationTime_15(HandleRef pThis);

		/// <summary>
		/// Get the time when the OpenGL context was created.
		/// </summary>
		// Token: 0x06001DC9 RID: 7625 RVA: 0x0002E300 File Offset: 0x0002C500
		public virtual ulong GetContextCreationTime()
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_GetContextCreationTime_15(base.GetCppThis());
		}

		// Token: 0x06001DCA RID: 7626
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLRenderWindow_GetDefaultTextureInternalFormat_16(HandleRef pThis, int vtktype, int numComponents, byte needInteger, byte needFloat, byte needSRGB);

		/// <summary>
		/// Get a mapping of vtk data types to native texture formats for this window
		/// we put this on the RenderWindow so that every texture does not have to
		/// build these structures themselves
		/// </summary>
		// Token: 0x06001DCB RID: 7627 RVA: 0x0002E320 File Offset: 0x0002C520
		public int GetDefaultTextureInternalFormat(int vtktype, int numComponents, bool needInteger, bool needFloat, bool needSRGB)
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_GetDefaultTextureInternalFormat_16(base.GetCppThis(), vtktype, numComponents, needInteger ? (byte)1 : (byte)0, needFloat ? (byte)1 : (byte)0, needSRGB ? (byte)1 : (byte)0);
		}

		// Token: 0x06001DCC RID: 7628
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLRenderWindow_GetDepthBufferSize_17(HandleRef pThis);

		/// <summary>
		/// Get the size of the depth buffer.
		/// </summary>
		// Token: 0x06001DCD RID: 7629 RVA: 0x0002E360 File Offset: 0x0002C560
		public override int GetDepthBufferSize()
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_GetDepthBufferSize_17(base.GetCppThis());
		}

		// Token: 0x06001DCE RID: 7630
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLRenderWindow_GetDisplayFramebuffer_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the display framebuffer object.
		/// </summary>
		// Token: 0x06001DCF RID: 7631 RVA: 0x0002E380 File Offset: 0x0002C580
		public virtual vtkOpenGLFramebufferObject GetDisplayFramebuffer()
		{
			vtkOpenGLFramebufferObject vtkOpenGLFramebufferObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_GetDisplayFramebuffer_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06001DD0 RID: 7632
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkOpenGLRenderWindow.FrameBlitModes vtkOpenGLRenderWindow_GetFrameBlitMode_19(HandleRef pThis);

		/// <summary>
		/// SetGet how to handle blits at the end of a Frame() call.
		/// Only happens when SwapBuffers is true.
		///
		/// The “blit” operation means copying something (pixels) from one region
		/// in memory to another. This is a common OpenGL operation: check out the
		/// glBlitFramebuffer OpenGL method. VTK OpenGL rasterizes 3D/2D geometry
		/// into color/depth attachments of an in-memory framebuffer: in the graphics
		/// world, this is called offscreen rendering.
		///
		/// The FrameBlitMode tells VTK where to copy the offscreen
		/// buffer. Either the default hardware framebuffer or the currently bound
		/// framebuffer. Here are the available modes:
		/// - BlitToHardware: This mode blits to the default framebuffer managed by
		///   platform(Win32/X/Cocoa) render windows. This is the default mode when VTK
		///   is used through one of the platform render windows (with vtkRenderWindow).
		/// - BlitToCurrent: This mode blits to the currently bound framebuffer.
		///   It is useful when an external framebuffer is bound just before
		///   the vtkRenderWindow::Frame() call. You’ll need this when integrating
		///   VTK with other UI frameworks because these UI frameworks create/have
		///   their own framebuffers.
		/// - NoBlit: no blit. The GUI or external code will handle the blit.
		/// </summary>
		// Token: 0x06001DD1 RID: 7633 RVA: 0x0002E3F0 File Offset: 0x0002C5F0
		public virtual vtkOpenGLRenderWindow.FrameBlitModes GetFrameBlitMode()
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_GetFrameBlitMode_19(base.GetCppThis());
		}

		// Token: 0x06001DD2 RID: 7634
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkOpenGLRenderWindow.FrameBlitModes vtkOpenGLRenderWindow_GetFrameBlitModeMaxValue_20(HandleRef pThis);

		/// <summary>
		/// SetGet how to handle blits at the end of a Frame() call.
		/// Only happens when SwapBuffers is true.
		///
		/// The “blit” operation means copying something (pixels) from one region
		/// in memory to another. This is a common OpenGL operation: check out the
		/// glBlitFramebuffer OpenGL method. VTK OpenGL rasterizes 3D/2D geometry
		/// into color/depth attachments of an in-memory framebuffer: in the graphics
		/// world, this is called offscreen rendering.
		///
		/// The FrameBlitMode tells VTK where to copy the offscreen
		/// buffer. Either the default hardware framebuffer or the currently bound
		/// framebuffer. Here are the available modes:
		/// - BlitToHardware: This mode blits to the default framebuffer managed by
		///   platform(Win32/X/Cocoa) render windows. This is the default mode when VTK
		///   is used through one of the platform render windows (with vtkRenderWindow).
		/// - BlitToCurrent: This mode blits to the currently bound framebuffer.
		///   It is useful when an external framebuffer is bound just before
		///   the vtkRenderWindow::Frame() call. You’ll need this when integrating
		///   VTK with other UI frameworks because these UI frameworks create/have
		///   their own framebuffers.
		/// - NoBlit: no blit. The GUI or external code will handle the blit.
		/// </summary>
		// Token: 0x06001DD3 RID: 7635 RVA: 0x0002E410 File Offset: 0x0002C610
		public virtual vtkOpenGLRenderWindow.FrameBlitModes GetFrameBlitModeMaxValue()
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_GetFrameBlitModeMaxValue_20(base.GetCppThis());
		}

		// Token: 0x06001DD4 RID: 7636
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkOpenGLRenderWindow.FrameBlitModes vtkOpenGLRenderWindow_GetFrameBlitModeMinValue_21(HandleRef pThis);

		/// <summary>
		/// SetGet how to handle blits at the end of a Frame() call.
		/// Only happens when SwapBuffers is true.
		///
		/// The “blit” operation means copying something (pixels) from one region
		/// in memory to another. This is a common OpenGL operation: check out the
		/// glBlitFramebuffer OpenGL method. VTK OpenGL rasterizes 3D/2D geometry
		/// into color/depth attachments of an in-memory framebuffer: in the graphics
		/// world, this is called offscreen rendering.
		///
		/// The FrameBlitMode tells VTK where to copy the offscreen
		/// buffer. Either the default hardware framebuffer or the currently bound
		/// framebuffer. Here are the available modes:
		/// - BlitToHardware: This mode blits to the default framebuffer managed by
		///   platform(Win32/X/Cocoa) render windows. This is the default mode when VTK
		///   is used through one of the platform render windows (with vtkRenderWindow).
		/// - BlitToCurrent: This mode blits to the currently bound framebuffer.
		///   It is useful when an external framebuffer is bound just before
		///   the vtkRenderWindow::Frame() call. You’ll need this when integrating
		///   VTK with other UI frameworks because these UI frameworks create/have
		///   their own framebuffers.
		/// - NoBlit: no blit. The GUI or external code will handle the blit.
		/// </summary>
		// Token: 0x06001DD5 RID: 7637 RVA: 0x0002E430 File Offset: 0x0002C630
		public virtual vtkOpenGLRenderWindow.FrameBlitModes GetFrameBlitModeMinValue()
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_GetFrameBlitModeMinValue_21(base.GetCppThis());
		}

		// Token: 0x06001DD6 RID: 7638
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenGLRenderWindow_GetFramebufferFlipY_22(HandleRef pThis);

		/// <summary>
		/// Enable/Disable flipping the Y axis of the rendered texture.
		/// </summary>
		// Token: 0x06001DD7 RID: 7639 RVA: 0x0002E450 File Offset: 0x0002C650
		public virtual bool GetFramebufferFlipY()
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_GetFramebufferFlipY_22(base.GetCppThis()) != 0;
		}

		// Token: 0x06001DD8 RID: 7640
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLRenderWindow_GetGlobalMaximumNumberOfMultiSamples_23();

		/// <summary>
		/// Set/Get the maximum number of multisamples
		/// </summary>
		// Token: 0x06001DD9 RID: 7641 RVA: 0x0002E478 File Offset: 0x0002C678
		public static int GetGlobalMaximumNumberOfMultiSamples()
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_GetGlobalMaximumNumberOfMultiSamples_23();
		}

		// Token: 0x06001DDA RID: 7642
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkOpenGLRenderWindow_GetMaximumHardwareLineWidth_24(HandleRef pThis);

		/// <summary>
		/// Return the largest line width supported by the hardware
		/// </summary>
		// Token: 0x06001DDB RID: 7643 RVA: 0x0002E494 File Offset: 0x0002C694
		public virtual float GetMaximumHardwareLineWidth()
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_GetMaximumHardwareLineWidth_24(base.GetCppThis());
		}

		// Token: 0x06001DDC RID: 7644
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLRenderWindow_GetNoiseTextureUnit_25(HandleRef pThis);

		/// <summary>
		/// Set the number of vertical syncs required between frames.
		/// A value of 0 means swap buffers as quickly as possible
		/// regardless of the vertical refresh. A value of 1 means swap
		/// buffers in sync with the vertical refresh to eliminate tearing.
		/// A value of -1 means use a value of 1 unless we missed a frame
		/// in which case swap immediately. Returns true if the call
		/// succeeded.
		/// </summary>
		// Token: 0x06001DDD RID: 7645 RVA: 0x0002E4B4 File Offset: 0x0002C6B4
		public int GetNoiseTextureUnit()
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_GetNoiseTextureUnit_25(base.GetCppThis());
		}

		// Token: 0x06001DDE RID: 7646
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLRenderWindow_GetNumberOfGenerationsFromBase_26(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001DDF RID: 7647 RVA: 0x0002E4D4 File Offset: 0x0002C6D4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_GetNumberOfGenerationsFromBase_26(base.GetCppThis(), type);
		}

		// Token: 0x06001DE0 RID: 7648
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLRenderWindow_GetNumberOfGenerationsFromBaseType_27([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001DE1 RID: 7649 RVA: 0x0002E4F4 File Offset: 0x0002C6F4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_GetNumberOfGenerationsFromBaseType_27(type);
		}

		// Token: 0x06001DE2 RID: 7650
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkOpenGLRenderWindow_GetOpenGLSupportMessage_28(HandleRef pThis);

		/// <summary>
		/// Return a message profiding additional details about the
		/// results of calling SupportsOpenGL()  This can be used
		/// to retrieve more specifics about what failed
		/// </summary>
		// Token: 0x06001DE3 RID: 7651 RVA: 0x0002E510 File Offset: 0x0002C710
		public string GetOpenGLSupportMessage()
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_GetOpenGLSupportMessage_28(base.GetCppThis());
		}

		// Token: 0x06001DE4 RID: 7652
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLRenderWindow_GetOpenGLVersion_29(HandleRef pThis, ref int major, ref int minor);

		/// <summary>
		/// Get the major and minor version numbers of the OpenGL context we are using
		/// ala 3.2, 3.3, 4.0, etc... returns 0,0 if opengl has not been initialized
		/// yet
		/// </summary>
		// Token: 0x06001DE5 RID: 7653 RVA: 0x0002E52F File Offset: 0x0002C72F
		public void GetOpenGLVersion(ref int major, ref int minor)
		{
			vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_GetOpenGLVersion_29(base.GetCppThis(), ref major, ref minor);
		}

		// Token: 0x06001DE6 RID: 7654
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLRenderWindow_GetPixelData_30(HandleRef pThis, int x, int y, int x2, int y2, int front, int right);

		/// <summary>
		/// Set/Get the pixel data of an image, transmitted as RGBRGB...
		/// front in this context indicates that the read should come from the
		/// display buffer versus the render buffer
		/// </summary>
		// Token: 0x06001DE7 RID: 7655 RVA: 0x0002E540 File Offset: 0x0002C740
		public override IntPtr GetPixelData(int x, int y, int x2, int y2, int front, int right)
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_GetPixelData_30(base.GetCppThis(), x, y, x2, y2, front, right);
		}

		// Token: 0x06001DE8 RID: 7656
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLRenderWindow_GetPixelData_31(HandleRef pThis, int x, int y, int x2, int y2, int front, HandleRef data, int right);

		/// <summary>
		/// Set/Get the pixel data of an image, transmitted as RGBRGB...
		/// front in this context indicates that the read should come from the
		/// display buffer versus the render buffer
		/// </summary>
		// Token: 0x06001DE9 RID: 7657 RVA: 0x0002E568 File Offset: 0x0002C768
		public override int GetPixelData(int x, int y, int x2, int y2, int front, vtkUnsignedCharArray data, int right)
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_GetPixelData_31(base.GetCppThis(), x, y, x2, y2, front, (data == null) ? default(HandleRef) : data.GetCppThis(), right);
		}

		// Token: 0x06001DEA RID: 7658
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLRenderWindow_GetRGBACharPixelData_32(HandleRef pThis, int x, int y, int x2, int y2, int front, int right);

		/// <summary>
		/// Set/Get the pixel data of an image, transmitted as RGBARGBA...
		/// </summary>
		// Token: 0x06001DEB RID: 7659 RVA: 0x0002E5A8 File Offset: 0x0002C7A8
		public override IntPtr GetRGBACharPixelData(int x, int y, int x2, int y2, int front, int right)
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_GetRGBACharPixelData_32(base.GetCppThis(), x, y, x2, y2, front, right);
		}

		// Token: 0x06001DEC RID: 7660
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLRenderWindow_GetRGBACharPixelData_33(HandleRef pThis, int x, int y, int x2, int y2, int front, HandleRef data, int right);

		/// <summary>
		/// Set/Get the pixel data of an image, transmitted as RGBARGBA...
		/// </summary>
		// Token: 0x06001DED RID: 7661 RVA: 0x0002E5D0 File Offset: 0x0002C7D0
		public override int GetRGBACharPixelData(int x, int y, int x2, int y2, int front, vtkUnsignedCharArray data, int right)
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_GetRGBACharPixelData_33(base.GetCppThis(), x, y, x2, y2, front, (data == null) ? default(HandleRef) : data.GetCppThis(), right);
		}

		// Token: 0x06001DEE RID: 7662
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLRenderWindow_GetRGBAPixelData_34(HandleRef pThis, int x, int y, int x2, int y2, int front, int right);

		/// <summary>
		/// Set/Get the pixel data of an image, transmitted as RGBARGBA...
		/// </summary>
		// Token: 0x06001DEF RID: 7663 RVA: 0x0002E610 File Offset: 0x0002C810
		public override IntPtr GetRGBAPixelData(int x, int y, int x2, int y2, int front, int right)
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_GetRGBAPixelData_34(base.GetCppThis(), x, y, x2, y2, front, right);
		}

		// Token: 0x06001DF0 RID: 7664
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLRenderWindow_GetRGBAPixelData_35(HandleRef pThis, int x, int y, int x2, int y2, int front, HandleRef data, int right);

		/// <summary>
		/// Set/Get the pixel data of an image, transmitted as RGBARGBA...
		/// </summary>
		// Token: 0x06001DF1 RID: 7665 RVA: 0x0002E638 File Offset: 0x0002C838
		public override int GetRGBAPixelData(int x, int y, int x2, int y2, int front, vtkFloatArray data, int right)
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_GetRGBAPixelData_35(base.GetCppThis(), x, y, x2, y2, front, (data == null) ? default(HandleRef) : data.GetCppThis(), right);
		}

		// Token: 0x06001DF2 RID: 7666
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLRenderWindow_GetRenderFramebuffer_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the render framebuffer object.
		/// </summary>
		// Token: 0x06001DF3 RID: 7667 RVA: 0x0002E678 File Offset: 0x0002C878
		public virtual vtkOpenGLFramebufferObject GetRenderFramebuffer()
		{
			vtkOpenGLFramebufferObject vtkOpenGLFramebufferObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_GetRenderFramebuffer_36(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06001DF4 RID: 7668
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLRenderWindow_GetRenderingBackend_37(HandleRef pThis);

		/// <summary>
		/// What rendering backend has the user requested
		/// </summary>
		// Token: 0x06001DF5 RID: 7669 RVA: 0x0002E6E8 File Offset: 0x0002C8E8
		public override string GetRenderingBackend()
		{
			string s = Marshal.PtrToStringAnsi(vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_GetRenderingBackend_37(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06001DF6 RID: 7670
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLRenderWindow_GetTQuad2DVBO_38(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the number of vertical syncs required between frames.
		/// A value of 0 means swap buffers as quickly as possible
		/// regardless of the vertical refresh. A value of 1 means swap
		/// buffers in sync with the vertical refresh to eliminate tearing.
		/// A value of -1 means use a value of 1 unless we missed a frame
		/// in which case swap immediately. Returns true if the call
		/// succeeded.
		/// </summary>
		// Token: 0x06001DF7 RID: 7671 RVA: 0x0002E724 File Offset: 0x0002C924
		public vtkOpenGLBufferObject GetTQuad2DVBO()
		{
			vtkOpenGLBufferObject vtkOpenGLBufferObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_GetTQuad2DVBO_38(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLBufferObject = (vtkOpenGLBufferObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLBufferObject.Register(null);
				}
			}
			return vtkOpenGLBufferObject;
		}

		// Token: 0x06001DF8 RID: 7672
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenGLRenderWindow_GetUsingSRGBColorSpace_39(HandleRef pThis);

		/// <summary>
		/// Is this window/fo in sRGB colorspace
		/// </summary>
		// Token: 0x06001DF9 RID: 7673 RVA: 0x0002E794 File Offset: 0x0002C994
		public bool GetUsingSRGBColorSpace()
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_GetUsingSRGBColorSpace_39(base.GetCppThis()) != 0;
		}

		// Token: 0x06001DFA RID: 7674
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLRenderWindow_GetZbufferData_40(HandleRef pThis, int x1, int y1, int x2, int y2);

		/// <summary>
		/// Set/Get the zbuffer data from an image
		/// </summary>
		// Token: 0x06001DFB RID: 7675 RVA: 0x0002E7BC File Offset: 0x0002C9BC
		public override IntPtr GetZbufferData(int x1, int y1, int x2, int y2)
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_GetZbufferData_40(base.GetCppThis(), x1, y1, x2, y2);
		}

		// Token: 0x06001DFC RID: 7676
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLRenderWindow_GetZbufferData_41(HandleRef pThis, int x1, int y1, int x2, int y2, IntPtr z);

		/// <summary>
		/// Set/Get the zbuffer data from an image
		/// </summary>
		// Token: 0x06001DFD RID: 7677 RVA: 0x0002E7E0 File Offset: 0x0002C9E0
		public override int GetZbufferData(int x1, int y1, int x2, int y2, IntPtr z)
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_GetZbufferData_41(base.GetCppThis(), x1, y1, x2, y2, z);
		}

		// Token: 0x06001DFE RID: 7678
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLRenderWindow_GetZbufferData_42(HandleRef pThis, int x1, int y1, int x2, int y2, HandleRef buffer);

		/// <summary>
		/// Set/Get the zbuffer data from an image
		/// </summary>
		// Token: 0x06001DFF RID: 7679 RVA: 0x0002E808 File Offset: 0x0002CA08
		public override int GetZbufferData(int x1, int y1, int x2, int y2, vtkFloatArray buffer)
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_GetZbufferData_42(base.GetCppThis(), x1, y1, x2, y2, (buffer == null) ? default(HandleRef) : buffer.GetCppThis());
		}

		// Token: 0x06001E00 RID: 7680
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLRenderWindow_Initialize_43(HandleRef pThis);

		/// <summary>
		/// Initialize the rendering window.  This will setup all system-specific
		/// resources.  This method and Finalize() must be symmetric and it
		/// should be possible to call them multiple times, even changing WindowId
		/// in-between.  This is what WindowRemap does.
		/// </summary>
		// Token: 0x06001E01 RID: 7681 RVA: 0x0002E843 File Offset: 0x0002CA43
		public virtual void Initialize()
		{
			vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_Initialize_43(base.GetCppThis());
		}

		// Token: 0x06001E02 RID: 7682
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenGLRenderWindow_InitializeFromCurrentContext_44(HandleRef pThis);

		/// <summary>
		/// Initialize the render window from the information associated
		/// with the currently activated OpenGL context.
		/// </summary>
		// Token: 0x06001E03 RID: 7683 RVA: 0x0002E854 File Offset: 0x0002CA54
		public override bool InitializeFromCurrentContext()
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_InitializeFromCurrentContext_44(base.GetCppThis()) != 0;
		}

		// Token: 0x06001E04 RID: 7684
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLRenderWindow_IsA_45(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001E05 RID: 7685 RVA: 0x0002E87C File Offset: 0x0002CA7C
		public override int IsA(string type)
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_IsA_45(base.GetCppThis(), type);
		}

		// Token: 0x06001E06 RID: 7686
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenGLRenderWindow_IsPointSpriteBugPresent_46(HandleRef pThis);

		/// <summary>
		/// Returns true if driver has an
		/// EGL/OpenGL bug that makes vtkChartsCoreCxx-TestChartDoubleColors and other tests to fail
		/// because point sprites don't work correctly (gl_PointCoord is undefined) unless
		/// glEnable(GL_POINT_SPRITE)
		/// </summary>
		// Token: 0x06001E07 RID: 7687 RVA: 0x0002E89C File Offset: 0x0002CA9C
		public virtual bool IsPointSpriteBugPresent()
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_IsPointSpriteBugPresent_46(base.GetCppThis()) != 0;
		}

		// Token: 0x06001E08 RID: 7688
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLRenderWindow_IsTypeOf_47([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001E09 RID: 7689 RVA: 0x0002E8C4 File Offset: 0x0002CAC4
		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_IsTypeOf_47(type);
		}

		// Token: 0x06001E0A RID: 7690
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLRenderWindow_NewInstance_48(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001E0B RID: 7691 RVA: 0x0002E8E0 File Offset: 0x0002CAE0
		public new vtkOpenGLRenderWindow NewInstance()
		{
			vtkOpenGLRenderWindow result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_NewInstance_48(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLRenderWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06001E0C RID: 7692
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLRenderWindow_OpenGLInit_49(HandleRef pThis);

		/// <summary>
		/// Initialize OpenGL for this window.
		/// </summary>
		// Token: 0x06001E0D RID: 7693 RVA: 0x0002E93A File Offset: 0x0002CB3A
		public virtual void OpenGLInit()
		{
			vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_OpenGLInit_49(base.GetCppThis());
		}

		// Token: 0x06001E0E RID: 7694
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLRenderWindow_OpenGLInitContext_50(HandleRef pThis);

		/// <summary>
		/// Initialize OpenGL for this window.
		/// </summary>
		// Token: 0x06001E0F RID: 7695 RVA: 0x0002E949 File Offset: 0x0002CB49
		public virtual void OpenGLInitContext()
		{
			vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_OpenGLInitContext_50(base.GetCppThis());
		}

		// Token: 0x06001E10 RID: 7696
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLRenderWindow_OpenGLInitState_51(HandleRef pThis);

		/// <summary>
		/// Initialize OpenGL for this window.
		/// </summary>
		// Token: 0x06001E11 RID: 7697 RVA: 0x0002E958 File Offset: 0x0002CB58
		public virtual void OpenGLInitState()
		{
			vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_OpenGLInitState_51(base.GetCppThis());
		}

		// Token: 0x06001E12 RID: 7698
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLRenderWindow_PopContext_52(HandleRef pThis);

		/// <summary>
		/// Ability to push and pop this window's context
		/// as the current context. The idea being to
		/// if needed make this window's context current
		/// and when done releasing resources restore
		/// the prior context.  The default implementation
		/// here is only meant as a backup for subclasses
		/// that lack a proper implementation.
		/// </summary>
		// Token: 0x06001E13 RID: 7699 RVA: 0x0002E967 File Offset: 0x0002CB67
		public virtual void PopContext()
		{
			vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_PopContext_52(base.GetCppThis());
		}

		// Token: 0x06001E14 RID: 7700
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLRenderWindow_PushContext_53(HandleRef pThis);

		/// <summary>
		/// Ability to push and pop this window's context
		/// as the current context. The idea being to
		/// if needed make this window's context current
		/// and when done releasing resources restore
		/// the prior context.  The default implementation
		/// here is only meant as a backup for subclasses
		/// that lack a proper implementation.
		/// </summary>
		// Token: 0x06001E15 RID: 7701 RVA: 0x0002E976 File Offset: 0x0002CB76
		public virtual void PushContext()
		{
			vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_PushContext_53(base.GetCppThis());
		}

		// Token: 0x06001E16 RID: 7702
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLRenderWindow_ReleaseGraphicsResources_54(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Free up any graphics resources associated with this window
		/// a value of NULL means the context may already be destroyed
		/// </summary>
		// Token: 0x06001E17 RID: 7703 RVA: 0x0002E988 File Offset: 0x0002CB88
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_ReleaseGraphicsResources_54(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06001E18 RID: 7704
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLRenderWindow_ReleaseRGBAPixelData_55(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get the pixel data of an image, transmitted as RGBARGBA...
		/// </summary>
		// Token: 0x06001E19 RID: 7705 RVA: 0x0002E9B7 File Offset: 0x0002CBB7
		public override void ReleaseRGBAPixelData(IntPtr data)
		{
			vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_ReleaseRGBAPixelData_55(base.GetCppThis(), data);
		}

		// Token: 0x06001E1A RID: 7706
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLRenderWindow_Render_56(HandleRef pThis);

		/// <summary>
		/// Handle opengl specific code and calls superclass
		/// </summary>
		// Token: 0x06001E1B RID: 7707 RVA: 0x0002E9C7 File Offset: 0x0002CBC7
		public override void Render()
		{
			vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_Render_56(base.GetCppThis());
		}

		// Token: 0x06001E1C RID: 7708
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLRenderWindow_ReportCapabilities_57(HandleRef pThis);

		/// <summary>
		/// Get report of capabilities for the render window
		/// </summary>
		// Token: 0x06001E1D RID: 7709 RVA: 0x0002E9D8 File Offset: 0x0002CBD8
		public override string ReportCapabilities()
		{
			string s = Marshal.PtrToStringAnsi(vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_ReportCapabilities_57(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06001E1E RID: 7710
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLRenderWindow_SafeDownCast_58(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001E1F RID: 7711 RVA: 0x0002EA14 File Offset: 0x0002CC14
		public new static vtkOpenGLRenderWindow SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLRenderWindow vtkOpenGLRenderWindow = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_SafeDownCast_58((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06001E20 RID: 7712
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLRenderWindow_SetFrameBlitMode_59(HandleRef pThis, vtkOpenGLRenderWindow.FrameBlitModes _arg);

		/// <summary>
		/// SetGet how to handle blits at the end of a Frame() call.
		/// Only happens when SwapBuffers is true.
		///
		/// The “blit” operation means copying something (pixels) from one region
		/// in memory to another. This is a common OpenGL operation: check out the
		/// glBlitFramebuffer OpenGL method. VTK OpenGL rasterizes 3D/2D geometry
		/// into color/depth attachments of an in-memory framebuffer: in the graphics
		/// world, this is called offscreen rendering.
		///
		/// The FrameBlitMode tells VTK where to copy the offscreen
		/// buffer. Either the default hardware framebuffer or the currently bound
		/// framebuffer. Here are the available modes:
		/// - BlitToHardware: This mode blits to the default framebuffer managed by
		///   platform(Win32/X/Cocoa) render windows. This is the default mode when VTK
		///   is used through one of the platform render windows (with vtkRenderWindow).
		/// - BlitToCurrent: This mode blits to the currently bound framebuffer.
		///   It is useful when an external framebuffer is bound just before
		///   the vtkRenderWindow::Frame() call. You’ll need this when integrating
		///   VTK with other UI frameworks because these UI frameworks create/have
		///   their own framebuffers.
		/// - NoBlit: no blit. The GUI or external code will handle the blit.
		/// </summary>
		// Token: 0x06001E21 RID: 7713 RVA: 0x0002EA93 File Offset: 0x0002CC93
		public virtual void SetFrameBlitMode(vtkOpenGLRenderWindow.FrameBlitModes _arg)
		{
			vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_SetFrameBlitMode_59(base.GetCppThis(), _arg);
		}

		// Token: 0x06001E22 RID: 7714
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLRenderWindow_SetFrameBlitModeToBlitToCurrent_60(HandleRef pThis);

		/// <summary>
		/// SetGet how to handle blits at the end of a Frame() call.
		/// Only happens when SwapBuffers is true.
		///
		/// The “blit” operation means copying something (pixels) from one region
		/// in memory to another. This is a common OpenGL operation: check out the
		/// glBlitFramebuffer OpenGL method. VTK OpenGL rasterizes 3D/2D geometry
		/// into color/depth attachments of an in-memory framebuffer: in the graphics
		/// world, this is called offscreen rendering.
		///
		/// The FrameBlitMode tells VTK where to copy the offscreen
		/// buffer. Either the default hardware framebuffer or the currently bound
		/// framebuffer. Here are the available modes:
		/// - BlitToHardware: This mode blits to the default framebuffer managed by
		///   platform(Win32/X/Cocoa) render windows. This is the default mode when VTK
		///   is used through one of the platform render windows (with vtkRenderWindow).
		/// - BlitToCurrent: This mode blits to the currently bound framebuffer.
		///   It is useful when an external framebuffer is bound just before
		///   the vtkRenderWindow::Frame() call. You’ll need this when integrating
		///   VTK with other UI frameworks because these UI frameworks create/have
		///   their own framebuffers.
		/// - NoBlit: no blit. The GUI or external code will handle the blit.
		/// </summary>
		// Token: 0x06001E23 RID: 7715 RVA: 0x0002EAA3 File Offset: 0x0002CCA3
		public void SetFrameBlitModeToBlitToCurrent()
		{
			vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_SetFrameBlitModeToBlitToCurrent_60(base.GetCppThis());
		}

		// Token: 0x06001E24 RID: 7716
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLRenderWindow_SetFrameBlitModeToBlitToHardware_61(HandleRef pThis);

		/// <summary>
		/// SetGet how to handle blits at the end of a Frame() call.
		/// Only happens when SwapBuffers is true.
		///
		/// The “blit” operation means copying something (pixels) from one region
		/// in memory to another. This is a common OpenGL operation: check out the
		/// glBlitFramebuffer OpenGL method. VTK OpenGL rasterizes 3D/2D geometry
		/// into color/depth attachments of an in-memory framebuffer: in the graphics
		/// world, this is called offscreen rendering.
		///
		/// The FrameBlitMode tells VTK where to copy the offscreen
		/// buffer. Either the default hardware framebuffer or the currently bound
		/// framebuffer. Here are the available modes:
		/// - BlitToHardware: This mode blits to the default framebuffer managed by
		///   platform(Win32/X/Cocoa) render windows. This is the default mode when VTK
		///   is used through one of the platform render windows (with vtkRenderWindow).
		/// - BlitToCurrent: This mode blits to the currently bound framebuffer.
		///   It is useful when an external framebuffer is bound just before
		///   the vtkRenderWindow::Frame() call. You’ll need this when integrating
		///   VTK with other UI frameworks because these UI frameworks create/have
		///   their own framebuffers.
		/// - NoBlit: no blit. The GUI or external code will handle the blit.
		/// </summary>
		// Token: 0x06001E25 RID: 7717 RVA: 0x0002EAB2 File Offset: 0x0002CCB2
		public void SetFrameBlitModeToBlitToHardware()
		{
			vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_SetFrameBlitModeToBlitToHardware_61(base.GetCppThis());
		}

		// Token: 0x06001E26 RID: 7718
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLRenderWindow_SetFrameBlitModeToNoBlit_62(HandleRef pThis);

		/// <summary>
		/// SetGet how to handle blits at the end of a Frame() call.
		/// Only happens when SwapBuffers is true.
		///
		/// The “blit” operation means copying something (pixels) from one region
		/// in memory to another. This is a common OpenGL operation: check out the
		/// glBlitFramebuffer OpenGL method. VTK OpenGL rasterizes 3D/2D geometry
		/// into color/depth attachments of an in-memory framebuffer: in the graphics
		/// world, this is called offscreen rendering.
		///
		/// The FrameBlitMode tells VTK where to copy the offscreen
		/// buffer. Either the default hardware framebuffer or the currently bound
		/// framebuffer. Here are the available modes:
		/// - BlitToHardware: This mode blits to the default framebuffer managed by
		///   platform(Win32/X/Cocoa) render windows. This is the default mode when VTK
		///   is used through one of the platform render windows (with vtkRenderWindow).
		/// - BlitToCurrent: This mode blits to the currently bound framebuffer.
		///   It is useful when an external framebuffer is bound just before
		///   the vtkRenderWindow::Frame() call. You’ll need this when integrating
		///   VTK with other UI frameworks because these UI frameworks create/have
		///   their own framebuffers.
		/// - NoBlit: no blit. The GUI or external code will handle the blit.
		/// </summary>
		// Token: 0x06001E27 RID: 7719 RVA: 0x0002EAC1 File Offset: 0x0002CCC1
		public void SetFrameBlitModeToNoBlit()
		{
			vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_SetFrameBlitModeToNoBlit_62(base.GetCppThis());
		}

		// Token: 0x06001E28 RID: 7720
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLRenderWindow_SetFramebufferFlipY_63(HandleRef pThis, byte _arg);

		/// <summary>
		/// Enable/Disable flipping the Y axis of the rendered texture.
		/// </summary>
		// Token: 0x06001E29 RID: 7721 RVA: 0x0002EAD0 File Offset: 0x0002CCD0
		public virtual void SetFramebufferFlipY(bool _arg)
		{
			vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_SetFramebufferFlipY_63(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06001E2A RID: 7722
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLRenderWindow_SetGlobalMaximumNumberOfMultiSamples_64(int val);

		/// <summary>
		/// Set/Get the maximum number of multisamples
		/// </summary>
		// Token: 0x06001E2B RID: 7723 RVA: 0x0002EAE8 File Offset: 0x0002CCE8
		public static void SetGlobalMaximumNumberOfMultiSamples(int val)
		{
			vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_SetGlobalMaximumNumberOfMultiSamples_64(val);
		}

		// Token: 0x06001E2C RID: 7724
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLRenderWindow_SetPixelData_65(HandleRef pThis, int x, int y, int x2, int y2, IntPtr data, int front, int right);

		/// <summary>
		/// Set/Get the pixel data of an image, transmitted as RGBRGB...
		/// front in this context indicates that the read should come from the
		/// display buffer versus the render buffer
		/// </summary>
		// Token: 0x06001E2D RID: 7725 RVA: 0x0002EAF4 File Offset: 0x0002CCF4
		public override int SetPixelData(int x, int y, int x2, int y2, IntPtr data, int front, int right)
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_SetPixelData_65(base.GetCppThis(), x, y, x2, y2, data, front, right);
		}

		// Token: 0x06001E2E RID: 7726
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLRenderWindow_SetPixelData_66(HandleRef pThis, int x, int y, int x2, int y2, HandleRef data, int front, int right);

		/// <summary>
		/// Set/Get the pixel data of an image, transmitted as RGBRGB...
		/// front in this context indicates that the read should come from the
		/// display buffer versus the render buffer
		/// </summary>
		// Token: 0x06001E2F RID: 7727 RVA: 0x0002EB20 File Offset: 0x0002CD20
		public override int SetPixelData(int x, int y, int x2, int y2, vtkUnsignedCharArray data, int front, int right)
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_SetPixelData_66(base.GetCppThis(), x, y, x2, y2, (data == null) ? default(HandleRef) : data.GetCppThis(), front, right);
		}

		// Token: 0x06001E30 RID: 7728
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLRenderWindow_SetRGBACharPixelData_67(HandleRef pThis, int x, int y, int x2, int y2, IntPtr data, int front, int blend, int right);

		/// <summary>
		/// Set/Get the pixel data of an image, transmitted as RGBARGBA...
		/// </summary>
		// Token: 0x06001E31 RID: 7729 RVA: 0x0002EB60 File Offset: 0x0002CD60
		public override int SetRGBACharPixelData(int x, int y, int x2, int y2, IntPtr data, int front, int blend, int right)
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_SetRGBACharPixelData_67(base.GetCppThis(), x, y, x2, y2, data, front, blend, right);
		}

		// Token: 0x06001E32 RID: 7730
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLRenderWindow_SetRGBACharPixelData_68(HandleRef pThis, int x, int y, int x2, int y2, HandleRef data, int front, int blend, int right);

		/// <summary>
		/// Set/Get the pixel data of an image, transmitted as RGBARGBA...
		/// </summary>
		// Token: 0x06001E33 RID: 7731 RVA: 0x0002EB8C File Offset: 0x0002CD8C
		public override int SetRGBACharPixelData(int x, int y, int x2, int y2, vtkUnsignedCharArray data, int front, int blend, int right)
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_SetRGBACharPixelData_68(base.GetCppThis(), x, y, x2, y2, (data == null) ? default(HandleRef) : data.GetCppThis(), front, blend, right);
		}

		// Token: 0x06001E34 RID: 7732
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLRenderWindow_SetRGBAPixelData_69(HandleRef pThis, int x, int y, int x2, int y2, IntPtr data, int front, int blend, int right);

		/// <summary>
		/// Set/Get the pixel data of an image, transmitted as RGBARGBA...
		/// </summary>
		// Token: 0x06001E35 RID: 7733 RVA: 0x0002EBD0 File Offset: 0x0002CDD0
		public override int SetRGBAPixelData(int x, int y, int x2, int y2, IntPtr data, int front, int blend, int right)
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_SetRGBAPixelData_69(base.GetCppThis(), x, y, x2, y2, data, front, blend, right);
		}

		// Token: 0x06001E36 RID: 7734
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLRenderWindow_SetRGBAPixelData_70(HandleRef pThis, int x, int y, int x2, int y2, HandleRef data, int front, int blend, int right);

		/// <summary>
		/// Set/Get the pixel data of an image, transmitted as RGBARGBA...
		/// </summary>
		// Token: 0x06001E37 RID: 7735 RVA: 0x0002EBFC File Offset: 0x0002CDFC
		public override int SetRGBAPixelData(int x, int y, int x2, int y2, vtkFloatArray data, int front, int blend, int right)
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_SetRGBAPixelData_70(base.GetCppThis(), x, y, x2, y2, (data == null) ? default(HandleRef) : data.GetCppThis(), front, blend, right);
		}

		// Token: 0x06001E38 RID: 7736
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenGLRenderWindow_SetSwapControl_71(HandleRef pThis, int arg0);

		/// <summary>
		/// Set the number of vertical syncs required between frames.
		/// A value of 0 means swap buffers as quickly as possible
		/// regardless of the vertical refresh. A value of 1 means swap
		/// buffers in sync with the vertical refresh to eliminate tearing.
		/// A value of -1 means use a value of 1 unless we missed a frame
		/// in which case swap immediately. Returns true if the call
		/// succeeded.
		/// </summary>
		// Token: 0x06001E39 RID: 7737 RVA: 0x0002EC40 File Offset: 0x0002CE40
		public virtual bool SetSwapControl(int arg0)
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_SetSwapControl_71(base.GetCppThis(), arg0) != 0;
		}

		// Token: 0x06001E3A RID: 7738
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLRenderWindow_SetZbufferData_72(HandleRef pThis, int x1, int y1, int x2, int y2, IntPtr buffer);

		/// <summary>
		/// Set/Get the zbuffer data from an image
		/// </summary>
		// Token: 0x06001E3B RID: 7739 RVA: 0x0002EC68 File Offset: 0x0002CE68
		public override int SetZbufferData(int x1, int y1, int x2, int y2, IntPtr buffer)
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_SetZbufferData_72(base.GetCppThis(), x1, y1, x2, y2, buffer);
		}

		// Token: 0x06001E3C RID: 7740
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLRenderWindow_SetZbufferData_73(HandleRef pThis, int x1, int y1, int x2, int y2, HandleRef buffer);

		/// <summary>
		/// Set/Get the zbuffer data from an image
		/// </summary>
		// Token: 0x06001E3D RID: 7741 RVA: 0x0002EC90 File Offset: 0x0002CE90
		public override int SetZbufferData(int x1, int y1, int x2, int y2, vtkFloatArray buffer)
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_SetZbufferData_73(base.GetCppThis(), x1, y1, x2, y2, (buffer == null) ? default(HandleRef) : buffer.GetCppThis());
		}

		// Token: 0x06001E3E RID: 7742
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLRenderWindow_Start_74(HandleRef pThis);

		/// <summary>
		/// Begin the rendering process.
		/// </summary>
		// Token: 0x06001E3F RID: 7743 RVA: 0x0002ECCB File Offset: 0x0002CECB
		public override void Start()
		{
			vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_Start_74(base.GetCppThis());
		}

		// Token: 0x06001E40 RID: 7744
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLRenderWindow_StereoMidpoint_75(HandleRef pThis);

		/// <summary>
		/// Intermediate method performs operations required between the rendering
		/// of the left and right eye.
		/// </summary>
		// Token: 0x06001E41 RID: 7745 RVA: 0x0002ECDA File Offset: 0x0002CEDA
		public override void StereoMidpoint()
		{
			vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_StereoMidpoint_75(base.GetCppThis());
		}

		// Token: 0x06001E42 RID: 7746
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLRenderWindow_SupportsOpenGL_76(HandleRef pThis);

		/// <summary>
		/// Does this render window support OpenGL? 0-false, 1-true
		/// </summary>
		// Token: 0x06001E43 RID: 7747 RVA: 0x0002ECEC File Offset: 0x0002CEEC
		public override int SupportsOpenGL()
		{
			return vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_SupportsOpenGL_76(base.GetCppThis());
		}

		// Token: 0x06001E44 RID: 7748
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLRenderWindow_WaitForCompletion_77(HandleRef pThis);

		/// <summary>
		/// Block the thread until the actual rendering is finished().
		/// Useful for measurement only.
		/// </summary>
		// Token: 0x06001E45 RID: 7749 RVA: 0x0002ED0B File Offset: 0x0002CF0B
		public override void WaitForCompletion()
		{
			vtkOpenGLRenderWindow.vtkOpenGLRenderWindow_WaitForCompletion_77(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000501 RID: 1281
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLRenderWindow";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000502 RID: 1282
		public new static readonly string MRClassNameKey = "class vtkOpenGLRenderWindow";

		/// <summary>
		/// Define how the resulting image should be blitted when at the end of the Frame() call if
		/// SwapBuffers is true
		/// </summary>
		// Token: 0x02000093 RID: 147
		public enum FrameBlitModes
		{
			/// <summary>enum member</summary>
			// Token: 0x04000504 RID: 1284
			BlitToCurrent = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000505 RID: 1285
			BlitToHardware = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000506 RID: 1286
			NoBlit = 2
		}
	}
}
