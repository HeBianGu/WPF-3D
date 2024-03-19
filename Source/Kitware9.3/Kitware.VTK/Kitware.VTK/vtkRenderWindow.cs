using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRenderWindow
	/// </summary>
	/// <remarks>
	///    create a window for renderers to draw into
	///
	/// vtkRenderWindow is an abstract object to specify the behavior of a
	/// rendering window. A rendering window is a window in a graphical user
	/// interface where renderers draw their images. Methods are provided to
	/// synchronize the rendering process, set window size, and control double
	/// buffering.  The window also allows rendering in stereo.  The interlaced
	/// render stereo type is for output to a VRex stereo projector.  All of the
	/// odd horizontal lines are from the left eye, and the even lines are from
	/// the right eye.  The user has to make the render window aligned with the
	/// VRex projector, or the eye will be swapped.
	///
	/// @warning
	/// In VTK versions 4 and later, the vtkWindowToImageFilter class is
	/// part of the canonical way to output an image of a window to a file
	/// (replacing the obsolete SaveImageAsPPM method for vtkRenderWindows
	/// that existed in 3.2 and earlier).  Connect one of these filters to
	/// the output of the window, and filter's output to a writer such as
	/// vtkPNGWriter.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRenderer vtkRenderWindowInteractor vtkWindowToImageFilter
	/// </seealso>
	// Token: 0x02000091 RID: 145
	public class vtkRenderWindow : vtkWindow
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06001C58 RID: 7256 RVA: 0x0002CBDE File Offset: 0x0002ADDE
		static vtkRenderWindow()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRenderWindow.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRenderWindow"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06001C59 RID: 7257 RVA: 0x0002CC06 File Offset: 0x0002AE06
		public vtkRenderWindow(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06001C5A RID: 7258
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindow_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct an instance of  vtkRenderWindow with its screen size
		/// set to 300x300, borders turned on, positioned at (0,0), double
		/// buffering turned on.
		/// </summary>
		// Token: 0x06001C5B RID: 7259 RVA: 0x0002CC14 File Offset: 0x0002AE14
		public new static vtkRenderWindow New()
		{
			vtkRenderWindow result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderWindow.vtkRenderWindow_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct an instance of  vtkRenderWindow with its screen size
		/// set to 300x300, borders turned on, positioned at (0,0), double
		/// buffering turned on.
		/// </summary>
		// Token: 0x06001C5C RID: 7260 RVA: 0x0002CC68 File Offset: 0x0002AE68
		public vtkRenderWindow() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRenderWindow.vtkRenderWindow_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		// Token: 0x06001C5D RID: 7261
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_UnRegister_163(HandleRef pThis, HandleRef o);

		/// <summary>
		/// This Method detects loops of RenderWindow&lt;-&gt;Interactor,
		/// so objects are freed properly.
		/// </summary>
		// Token: 0x06001C5E RID: 7262 RVA: 0x0002CCAC File Offset: 0x0002AEAC
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (base.GetCallDisposalMethod())
				{
					vtkRenderWindow.vtkRenderWindow_UnRegister_163(base.GetCppThis(), default(HandleRef));
					base.ClearCppThis();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06001C5F RID: 7263
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_AddRenderer_01(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Add a renderer to the list of renderers.
		/// </summary>
		// Token: 0x06001C60 RID: 7264 RVA: 0x0002CD08 File Offset: 0x0002AF08
		public virtual void AddRenderer(vtkRenderer arg0)
		{
			vtkRenderWindow.vtkRenderWindow_AddRenderer_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06001C61 RID: 7265
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_AlphaBitPlanesOff_02(HandleRef pThis);

		/// <summary>
		/// Turn on/off the use of alpha bitplanes.
		/// </summary>
		// Token: 0x06001C62 RID: 7266 RVA: 0x0002CD37 File Offset: 0x0002AF37
		public virtual void AlphaBitPlanesOff()
		{
			vtkRenderWindow.vtkRenderWindow_AlphaBitPlanesOff_02(base.GetCppThis());
		}

		// Token: 0x06001C63 RID: 7267
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_AlphaBitPlanesOn_03(HandleRef pThis);

		/// <summary>
		/// Turn on/off the use of alpha bitplanes.
		/// </summary>
		// Token: 0x06001C64 RID: 7268 RVA: 0x0002CD46 File Offset: 0x0002AF46
		public virtual void AlphaBitPlanesOn()
		{
			vtkRenderWindow.vtkRenderWindow_AlphaBitPlanesOn_03(base.GetCppThis());
		}

		// Token: 0x06001C65 RID: 7269
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_BordersOff_04(HandleRef pThis);

		/// <summary>
		/// Turn on/off window manager borders. Typically, you shouldn't turn the
		/// borders off, because that bypasses the window manager and can cause
		/// undesirable behavior.
		/// </summary>
		// Token: 0x06001C66 RID: 7270 RVA: 0x0002CD55 File Offset: 0x0002AF55
		public virtual void BordersOff()
		{
			vtkRenderWindow.vtkRenderWindow_BordersOff_04(base.GetCppThis());
		}

		// Token: 0x06001C67 RID: 7271
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_BordersOn_05(HandleRef pThis);

		/// <summary>
		/// Turn on/off window manager borders. Typically, you shouldn't turn the
		/// borders off, because that bypasses the window manager and can cause
		/// undesirable behavior.
		/// </summary>
		// Token: 0x06001C68 RID: 7272 RVA: 0x0002CD64 File Offset: 0x0002AF64
		public virtual void BordersOn()
		{
			vtkRenderWindow.vtkRenderWindow_BordersOn_05(base.GetCppThis());
		}

		// Token: 0x06001C69 RID: 7273
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_CaptureGL2PSSpecialProps_06(HandleRef pThis, HandleRef specialProps);

		/// <summary>
		/// The GL2PS exporter must handle certain props in a special way (e.g. text).
		/// This method performs a render and captures all "GL2PS-special" props in
		/// the specified collection. The collection will contain a
		/// vtkPropCollection for each vtkRenderer in this-&gt;GetRenderers(), each
		/// containing the special props rendered by the corresponding renderer.
		/// </summary>
		// Token: 0x06001C6A RID: 7274 RVA: 0x0002CD74 File Offset: 0x0002AF74
		public void CaptureGL2PSSpecialProps(vtkCollection specialProps)
		{
			vtkRenderWindow.vtkRenderWindow_CaptureGL2PSSpecialProps_06(base.GetCppThis(), (specialProps == null) ? default(HandleRef) : specialProps.GetCppThis());
		}

		// Token: 0x06001C6B RID: 7275
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindow_CheckAbortStatus_07(HandleRef pThis);

		/// <summary>
		/// This is a flag that can be set to interrupt a rendering that is in
		/// progress.
		/// </summary>
		// Token: 0x06001C6C RID: 7276 RVA: 0x0002CDA4 File Offset: 0x0002AFA4
		public virtual int CheckAbortStatus()
		{
			return vtkRenderWindow.vtkRenderWindow_CheckAbortStatus_07(base.GetCppThis());
		}

		// Token: 0x06001C6D RID: 7277
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindow_CheckInRenderStatus_08(HandleRef pThis);

		/// <summary>
		/// Are we rendering at the moment
		/// </summary>
		// Token: 0x06001C6E RID: 7278 RVA: 0x0002CDC4 File Offset: 0x0002AFC4
		public virtual int CheckInRenderStatus()
		{
			return vtkRenderWindow.vtkRenderWindow_CheckInRenderStatus_08(base.GetCppThis());
		}

		// Token: 0x06001C6F RID: 7279
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_ClearInRenderStatus_09(HandleRef pThis);

		/// <summary>
		/// Clear status (after an exception was thrown for example)
		/// </summary>
		// Token: 0x06001C70 RID: 7280 RVA: 0x0002CDE3 File Offset: 0x0002AFE3
		public virtual void ClearInRenderStatus()
		{
			vtkRenderWindow.vtkRenderWindow_ClearInRenderStatus_09(base.GetCppThis());
		}

		// Token: 0x06001C71 RID: 7281
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_CopyResultFrame_10(HandleRef pThis);

		/// <summary>
		/// Performed at the end of the rendering process to generate image.
		/// This is typically done right before swapping buffers.
		/// </summary>
		// Token: 0x06001C72 RID: 7282 RVA: 0x0002CDF2 File Offset: 0x0002AFF2
		public virtual void CopyResultFrame()
		{
			vtkRenderWindow.vtkRenderWindow_CopyResultFrame_10(base.GetCppThis());
		}

		// Token: 0x06001C73 RID: 7283
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_End_11(HandleRef pThis);

		/// <summary>
		/// Update the system, if needed, at end of render process
		/// </summary>
		// Token: 0x06001C74 RID: 7284 RVA: 0x0002CE01 File Offset: 0x0002B001
		public virtual void End()
		{
			vtkRenderWindow.vtkRenderWindow_End_11(base.GetCppThis());
		}

		// Token: 0x06001C75 RID: 7285
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_Finalize_12(HandleRef pThis);

		/// <summary>
		/// Finalize the rendering process.
		/// </summary>
		// Token: 0x06001C76 RID: 7286 RVA: 0x0002CE10 File Offset: 0x0002B010
		public virtual void FinalizeWrapper()
		{
			vtkRenderWindow.vtkRenderWindow_Finalize_12(base.GetCppThis());
		}

		// Token: 0x06001C77 RID: 7287
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_Frame_13(HandleRef pThis);

		/// <summary>
		/// A termination method performed at the end of the rendering process
		/// to do things like swapping buffers (if necessary) or similar actions.
		/// </summary>
		// Token: 0x06001C78 RID: 7288 RVA: 0x0002CE1F File Offset: 0x0002B01F
		public virtual void Frame()
		{
			vtkRenderWindow.vtkRenderWindow_Frame_13(base.GetCppThis());
		}

		// Token: 0x06001C79 RID: 7289
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_FullScreenOff_14(HandleRef pThis);

		/// <summary>
		/// Turn on/off rendering full screen window size.
		/// </summary>
		// Token: 0x06001C7A RID: 7290 RVA: 0x0002CE2E File Offset: 0x0002B02E
		public virtual void FullScreenOff()
		{
			vtkRenderWindow.vtkRenderWindow_FullScreenOff_14(base.GetCppThis());
		}

		// Token: 0x06001C7B RID: 7291
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_FullScreenOn_15(HandleRef pThis);

		/// <summary>
		/// Turn on/off rendering full screen window size.
		/// </summary>
		// Token: 0x06001C7C RID: 7292 RVA: 0x0002CE3D File Offset: 0x0002B03D
		public virtual void FullScreenOn()
		{
			vtkRenderWindow.vtkRenderWindow_FullScreenOn_15(base.GetCppThis());
		}

		// Token: 0x06001C7D RID: 7293
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindow_GetAbortRender_16(HandleRef pThis);

		/// <summary>
		/// This is a flag that can be set to interrupt a rendering that is in
		/// progress.
		/// </summary>
		// Token: 0x06001C7E RID: 7294 RVA: 0x0002CE4C File Offset: 0x0002B04C
		public virtual int GetAbortRender()
		{
			return vtkRenderWindow.vtkRenderWindow_GetAbortRender_16(base.GetCppThis());
		}

		// Token: 0x06001C7F RID: 7295
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindow_GetAlphaBitPlanes_17(HandleRef pThis);

		/// <summary>
		/// Turn on/off the use of alpha bitplanes.
		/// </summary>
		// Token: 0x06001C80 RID: 7296 RVA: 0x0002CE6C File Offset: 0x0002B06C
		public virtual int GetAlphaBitPlanes()
		{
			return vtkRenderWindow.vtkRenderWindow_GetAlphaBitPlanes_17(base.GetCppThis());
		}

		// Token: 0x06001C81 RID: 7297
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindow_GetAnaglyphColorMask_18(HandleRef pThis);

		/// <summary>
		/// Set/get the anaglyph color mask values.  These two numbers are bits
		/// mask that control which color channels of the original stereo
		/// images are used to produce the final anaglyph image.  The first
		/// value is the color mask for the left view, the second the mask
		/// for the right view.  If a bit in the mask is on for a particular
		/// color for a view, that color is passed on to the final view; if
		/// it is not set, that channel for that view is ignored.
		/// The bits are arranged as r, g, and b, so r = 4, g = 2, and b = 1.
		/// By default, the first value (the left view) is set to 4, and the
		/// second value is set to 3.  That means that the red output channel
		/// comes from the left view, and the green and blue values come from
		/// the right view.
		/// </summary>
		// Token: 0x06001C82 RID: 7298 RVA: 0x0002CE8C File Offset: 0x0002B08C
		public virtual int[] GetAnaglyphColorMask()
		{
			IntPtr intPtr = vtkRenderWindow.vtkRenderWindow_GetAnaglyphColorMask_18(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06001C83 RID: 7299
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_GetAnaglyphColorMask_19(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/get the anaglyph color mask values.  These two numbers are bits
		/// mask that control which color channels of the original stereo
		/// images are used to produce the final anaglyph image.  The first
		/// value is the color mask for the left view, the second the mask
		/// for the right view.  If a bit in the mask is on for a particular
		/// color for a view, that color is passed on to the final view; if
		/// it is not set, that channel for that view is ignored.
		/// The bits are arranged as r, g, and b, so r = 4, g = 2, and b = 1.
		/// By default, the first value (the left view) is set to 4, and the
		/// second value is set to 3.  That means that the red output channel
		/// comes from the left view, and the green and blue values come from
		/// the right view.
		/// </summary>
		// Token: 0x06001C84 RID: 7300 RVA: 0x0002CED4 File Offset: 0x0002B0D4
		public virtual void GetAnaglyphColorMask(IntPtr data)
		{
			vtkRenderWindow.vtkRenderWindow_GetAnaglyphColorMask_19(base.GetCppThis(), data);
		}

		// Token: 0x06001C85 RID: 7301
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkRenderWindow_GetAnaglyphColorSaturation_20(HandleRef pThis);

		/// <summary>
		/// Set/get the anaglyph color saturation factor.  This number ranges from
		/// 0.0 to 1.0:  0.0 means that no color from the original object is
		/// maintained, 1.0 means all of the color is maintained.  The default
		/// value is 0.65.  Too much saturation can produce uncomfortable 3D
		/// viewing because anaglyphs also use color to encode 3D.
		/// </summary>
		// Token: 0x06001C86 RID: 7302 RVA: 0x0002CEE4 File Offset: 0x0002B0E4
		public virtual float GetAnaglyphColorSaturation()
		{
			return vtkRenderWindow.vtkRenderWindow_GetAnaglyphColorSaturation_20(base.GetCppThis());
		}

		// Token: 0x06001C87 RID: 7303
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkRenderWindow_GetAnaglyphColorSaturationMaxValue_21(HandleRef pThis);

		/// <summary>
		/// Set/get the anaglyph color saturation factor.  This number ranges from
		/// 0.0 to 1.0:  0.0 means that no color from the original object is
		/// maintained, 1.0 means all of the color is maintained.  The default
		/// value is 0.65.  Too much saturation can produce uncomfortable 3D
		/// viewing because anaglyphs also use color to encode 3D.
		/// </summary>
		// Token: 0x06001C88 RID: 7304 RVA: 0x0002CF04 File Offset: 0x0002B104
		public virtual float GetAnaglyphColorSaturationMaxValue()
		{
			return vtkRenderWindow.vtkRenderWindow_GetAnaglyphColorSaturationMaxValue_21(base.GetCppThis());
		}

		// Token: 0x06001C89 RID: 7305
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkRenderWindow_GetAnaglyphColorSaturationMinValue_22(HandleRef pThis);

		/// <summary>
		/// Set/get the anaglyph color saturation factor.  This number ranges from
		/// 0.0 to 1.0:  0.0 means that no color from the original object is
		/// maintained, 1.0 means all of the color is maintained.  The default
		/// value is 0.65.  Too much saturation can produce uncomfortable 3D
		/// viewing because anaglyphs also use color to encode 3D.
		/// </summary>
		// Token: 0x06001C8A RID: 7306 RVA: 0x0002CF24 File Offset: 0x0002B124
		public virtual float GetAnaglyphColorSaturationMinValue()
		{
			return vtkRenderWindow.vtkRenderWindow_GetAnaglyphColorSaturationMinValue_22(base.GetCppThis());
		}

		// Token: 0x06001C8B RID: 7307
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindow_GetBorders_23(HandleRef pThis);

		/// <summary>
		/// Turn on/off window manager borders. Typically, you shouldn't turn the
		/// borders off, because that bypasses the window manager and can cause
		/// undesirable behavior.
		/// </summary>
		// Token: 0x06001C8C RID: 7308 RVA: 0x0002CF44 File Offset: 0x0002B144
		public virtual int GetBorders()
		{
			return vtkRenderWindow.vtkRenderWindow_GetBorders_23(base.GetCppThis());
		}

		// Token: 0x06001C8D RID: 7309
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindow_GetCapturingGL2PSSpecialProps_24(HandleRef pThis);

		/// <summary>
		/// Returns true if the render process is capturing text actors.
		/// </summary>
		// Token: 0x06001C8E RID: 7310 RVA: 0x0002CF64 File Offset: 0x0002B164
		public virtual int GetCapturingGL2PSSpecialProps()
		{
			return vtkRenderWindow.vtkRenderWindow_GetCapturingGL2PSSpecialProps_24(base.GetCppThis());
		}

		// Token: 0x06001C8F RID: 7311
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindow_GetColorBufferSizes_25(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// Get the size of the color buffer.
		/// Returns 0 if not able to determine otherwise sets R G B and A into buffer.
		/// </summary>
		// Token: 0x06001C90 RID: 7312 RVA: 0x0002CF84 File Offset: 0x0002B184
		public virtual int GetColorBufferSizes(IntPtr arg0)
		{
			return vtkRenderWindow.vtkRenderWindow_GetColorBufferSizes_25(base.GetCppThis(), arg0);
		}

		// Token: 0x06001C91 RID: 7313
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindow_GetCurrentCursor_26(HandleRef pThis);

		/// <summary>
		/// Change the shape of the cursor.
		/// </summary>
		// Token: 0x06001C92 RID: 7314 RVA: 0x0002CFA4 File Offset: 0x0002B1A4
		public virtual int GetCurrentCursor()
		{
			return vtkRenderWindow.vtkRenderWindow_GetCurrentCursor_26(base.GetCppThis());
		}

		// Token: 0x06001C93 RID: 7315
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindow_GetCursorFileName_27(HandleRef pThis);

		/// <summary>
		/// Set/Get the full path to the custom cursor.
		/// This is used when the current cursor is set to VTK_CURSOR_CUSTOM.
		/// </summary>
		// Token: 0x06001C94 RID: 7316 RVA: 0x0002CFC4 File Offset: 0x0002B1C4
		public virtual string GetCursorFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkRenderWindow.vtkRenderWindow_GetCursorFileName_27(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06001C95 RID: 7317
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindow_GetDepthBufferSize_28(HandleRef pThis);

		/// <summary>
		/// This method should be defined by the subclass. How many bits of
		/// precision are there in the zbuffer?
		/// </summary>
		// Token: 0x06001C96 RID: 7318 RVA: 0x0002D000 File Offset: 0x0002B200
		public virtual int GetDepthBufferSize()
		{
			return vtkRenderWindow.vtkRenderWindow_GetDepthBufferSize_28(base.GetCppThis());
		}

		// Token: 0x06001C97 RID: 7319
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRenderWindow_GetDesiredUpdateRate_29(HandleRef pThis);

		/// <summary>
		/// Set/Get the desired update rate. This is used with
		/// the vtkLODActor class. When using level of detail actors you
		/// need to specify what update rate you require. The LODActors then
		/// will pick the correct resolution to meet your desired update rate
		/// in frames per second. A value of zero indicates that they can use
		/// all the time they want to.
		/// </summary>
		// Token: 0x06001C98 RID: 7320 RVA: 0x0002D020 File Offset: 0x0002B220
		public virtual double GetDesiredUpdateRate()
		{
			return vtkRenderWindow.vtkRenderWindow_GetDesiredUpdateRate_29(base.GetCppThis());
		}

		// Token: 0x06001C99 RID: 7321
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindow_GetDeviceIndex_30(HandleRef pThis);

		/// <summary>
		/// If there are several graphics card installed on a system,
		/// this index can be used to specify which card you want to render to.
		/// the default is 0. This may not work on all derived render window and
		/// it may need to be set before the first render.
		/// </summary>
		// Token: 0x06001C9A RID: 7322 RVA: 0x0002D040 File Offset: 0x0002B240
		public virtual int GetDeviceIndex()
		{
			return vtkRenderWindow.vtkRenderWindow_GetDeviceIndex_30(base.GetCppThis());
		}

		// Token: 0x06001C9B RID: 7323
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderWindow_GetDeviceToWorldMatrixForDevice_31(HandleRef pThis, vtkEventDataDevice device, HandleRef deviceToWorldMatrix);

		/// <summary>
		/// Store in \p deviceToWorldMatrix the matrix that goes from device coordinates
		/// to world coordinates. e.g. if you push 0,0,0,1 through this matrix you will get
		/// the location of the device in world coordinates.
		/// Return true if the query is valid, else false.
		/// </summary>
		// Token: 0x06001C9C RID: 7324 RVA: 0x0002D060 File Offset: 0x0002B260
		public virtual bool GetDeviceToWorldMatrixForDevice(vtkEventDataDevice device, vtkMatrix4x4 deviceToWorldMatrix)
		{
			return vtkRenderWindow.vtkRenderWindow_GetDeviceToWorldMatrixForDevice_31(base.GetCppThis(), device, (deviceToWorldMatrix == null) ? default(HandleRef) : deviceToWorldMatrix.GetCppThis()) != 0;
		}

		// Token: 0x06001C9D RID: 7325
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindow_GetEventPending_32(HandleRef pThis);

		/// <summary>
		/// Check to see if a mouse button has been pressed.  All other events
		/// are ignored by this method.  Ideally, you want to abort the render
		/// on any event which causes the DesiredUpdateRate to switch from
		/// a high-quality rate to a more interactive rate.
		/// </summary>
		// Token: 0x06001C9E RID: 7326 RVA: 0x0002D09C File Offset: 0x0002B29C
		public virtual int GetEventPending()
		{
			return vtkRenderWindow.vtkRenderWindow_GetEventPending_32(base.GetCppThis());
		}

		// Token: 0x06001C9F RID: 7327
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindow_GetFullScreen_33(HandleRef pThis);

		/// <summary>
		/// Turn on/off rendering full screen window size.
		/// </summary>
		// Token: 0x06001CA0 RID: 7328 RVA: 0x0002D0BC File Offset: 0x0002B2BC
		public virtual int GetFullScreen()
		{
			return vtkRenderWindow.vtkRenderWindow_GetFullScreen_33(base.GetCppThis());
		}

		// Token: 0x06001CA1 RID: 7329
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindow_GetGenericContext_34(HandleRef pThis);

		/// <summary>
		/// Dummy stubs for vtkWindow API.
		/// </summary>
		// Token: 0x06001CA2 RID: 7330 RVA: 0x0002D0DC File Offset: 0x0002B2DC
		public override IntPtr GetGenericContext()
		{
			return vtkRenderWindow.vtkRenderWindow_GetGenericContext_34(base.GetCppThis());
		}

		// Token: 0x06001CA3 RID: 7331
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindow_GetGenericDisplayId_35(HandleRef pThis);

		/// <summary>
		/// Dummy stubs for vtkWindow API.
		/// </summary>
		// Token: 0x06001CA4 RID: 7332 RVA: 0x0002D0FC File Offset: 0x0002B2FC
		public override IntPtr GetGenericDisplayId()
		{
			return vtkRenderWindow.vtkRenderWindow_GetGenericDisplayId_35(base.GetCppThis());
		}

		// Token: 0x06001CA5 RID: 7333
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindow_GetGenericDrawable_36(HandleRef pThis);

		/// <summary>
		/// Dummy stubs for vtkWindow API.
		/// </summary>
		// Token: 0x06001CA6 RID: 7334 RVA: 0x0002D11C File Offset: 0x0002B31C
		public override IntPtr GetGenericDrawable()
		{
			return vtkRenderWindow.vtkRenderWindow_GetGenericDrawable_36(base.GetCppThis());
		}

		// Token: 0x06001CA7 RID: 7335
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindow_GetGenericParentId_37(HandleRef pThis);

		/// <summary>
		/// Dummy stubs for vtkWindow API.
		/// </summary>
		// Token: 0x06001CA8 RID: 7336 RVA: 0x0002D13C File Offset: 0x0002B33C
		public override IntPtr GetGenericParentId()
		{
			return vtkRenderWindow.vtkRenderWindow_GetGenericParentId_37(base.GetCppThis());
		}

		// Token: 0x06001CA9 RID: 7337
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindow_GetGenericWindowId_38(HandleRef pThis);

		/// <summary>
		/// Dummy stubs for vtkWindow API.
		/// </summary>
		// Token: 0x06001CAA RID: 7338 RVA: 0x0002D15C File Offset: 0x0002B35C
		public override IntPtr GetGenericWindowId()
		{
			return vtkRenderWindow.vtkRenderWindow_GetGenericWindowId_38(base.GetCppThis());
		}

		// Token: 0x06001CAB RID: 7339
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindow_GetInAbortCheck_39(HandleRef pThis);

		/// <summary>
		/// This is a flag that can be set to interrupt a rendering that is in
		/// progress.
		/// </summary>
		// Token: 0x06001CAC RID: 7340 RVA: 0x0002D17C File Offset: 0x0002B37C
		public virtual int GetInAbortCheck()
		{
			return vtkRenderWindow.vtkRenderWindow_GetInAbortCheck_39(base.GetCppThis());
		}

		// Token: 0x06001CAD RID: 7341
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindow_GetInteractor_40(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the interactor associated with this render window
		/// </summary>
		// Token: 0x06001CAE RID: 7342 RVA: 0x0002D19C File Offset: 0x0002B39C
		public virtual vtkRenderWindowInteractor GetInteractor()
		{
			vtkRenderWindowInteractor vtkRenderWindowInteractor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderWindow.vtkRenderWindow_GetInteractor_40(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderWindowInteractor = (vtkRenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderWindowInteractor.Register(null);
				}
			}
			return vtkRenderWindowInteractor;
		}

		// Token: 0x06001CAF RID: 7343
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindow_GetLineSmoothing_41(HandleRef pThis);

		/// <summary>
		/// Turn on/off line smoothing. Default is off.
		/// This must be applied before the first Render.
		/// </summary>
		// Token: 0x06001CB0 RID: 7344 RVA: 0x0002D20C File Offset: 0x0002B40C
		public virtual int GetLineSmoothing()
		{
			return vtkRenderWindow.vtkRenderWindow_GetLineSmoothing_41(base.GetCppThis());
		}

		// Token: 0x06001CB1 RID: 7345
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindow_GetMultiSamples_42(HandleRef pThis);

		/// <summary>
		/// Set / Get the number of multisamples to use for hardware antialiasing.
		/// A value of 1 will be set to 0.
		/// </summary>
		// Token: 0x06001CB2 RID: 7346 RVA: 0x0002D22C File Offset: 0x0002B42C
		public virtual int GetMultiSamples()
		{
			return vtkRenderWindow.vtkRenderWindow_GetMultiSamples_42(base.GetCppThis());
		}

		// Token: 0x06001CB3 RID: 7347
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindow_GetNeverRendered_43(HandleRef pThis);

		/// <summary>
		/// This flag is set if the window hasn't rendered since it was created
		/// </summary>
		// Token: 0x06001CB4 RID: 7348 RVA: 0x0002D24C File Offset: 0x0002B44C
		public virtual int GetNeverRendered()
		{
			return vtkRenderWindow.vtkRenderWindow_GetNeverRendered_43(base.GetCppThis());
		}

		// Token: 0x06001CB5 RID: 7349
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindow_GetNumberOfDevices_44(HandleRef pThis);

		/// <summary>
		/// Returns the number of devices (graphics cards) on a system.
		/// This may not work on all derived render windows.
		/// </summary>
		// Token: 0x06001CB6 RID: 7350 RVA: 0x0002D26C File Offset: 0x0002B46C
		public virtual int GetNumberOfDevices()
		{
			return vtkRenderWindow.vtkRenderWindow_GetNumberOfDevices_44(base.GetCppThis());
		}

		// Token: 0x06001CB7 RID: 7351
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRenderWindow_GetNumberOfGenerationsFromBase_45(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001CB8 RID: 7352 RVA: 0x0002D28C File Offset: 0x0002B48C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRenderWindow.vtkRenderWindow_GetNumberOfGenerationsFromBase_45(base.GetCppThis(), type);
		}

		// Token: 0x06001CB9 RID: 7353
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRenderWindow_GetNumberOfGenerationsFromBaseType_46([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001CBA RID: 7354 RVA: 0x0002D2AC File Offset: 0x0002B4AC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRenderWindow.vtkRenderWindow_GetNumberOfGenerationsFromBaseType_46(type);
		}

		// Token: 0x06001CBB RID: 7355
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindow_GetNumberOfLayers_47(HandleRef pThis);

		/// <summary>
		/// Get the number of layers for renderers.  Each renderer should have
		/// its layer set individually.  Some algorithms iterate through all layers,
		/// so it is not wise to set the number of layers to be exorbitantly large
		/// (say bigger than 100).
		/// </summary>
		// Token: 0x06001CBC RID: 7356 RVA: 0x0002D2C8 File Offset: 0x0002B4C8
		public virtual int GetNumberOfLayers()
		{
			return vtkRenderWindow.vtkRenderWindow_GetNumberOfLayers_47(base.GetCppThis());
		}

		// Token: 0x06001CBD RID: 7357
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindow_GetNumberOfLayersMaxValue_48(HandleRef pThis);

		/// <summary>
		/// Get the number of layers for renderers.  Each renderer should have
		/// its layer set individually.  Some algorithms iterate through all layers,
		/// so it is not wise to set the number of layers to be exorbitantly large
		/// (say bigger than 100).
		/// </summary>
		// Token: 0x06001CBE RID: 7358 RVA: 0x0002D2E8 File Offset: 0x0002B4E8
		public virtual int GetNumberOfLayersMaxValue()
		{
			return vtkRenderWindow.vtkRenderWindow_GetNumberOfLayersMaxValue_48(base.GetCppThis());
		}

		// Token: 0x06001CBF RID: 7359
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindow_GetNumberOfLayersMinValue_49(HandleRef pThis);

		/// <summary>
		/// Get the number of layers for renderers.  Each renderer should have
		/// its layer set individually.  Some algorithms iterate through all layers,
		/// so it is not wise to set the number of layers to be exorbitantly large
		/// (say bigger than 100).
		/// </summary>
		// Token: 0x06001CC0 RID: 7360 RVA: 0x0002D308 File Offset: 0x0002B508
		public virtual int GetNumberOfLayersMinValue()
		{
			return vtkRenderWindow.vtkRenderWindow_GetNumberOfLayersMinValue_49(base.GetCppThis());
		}

		// Token: 0x06001CC1 RID: 7361
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_GetPhysicalToWorldMatrix_50(HandleRef pThis, HandleRef matrix);

		/// <summary>
		/// Get physical to world transform matrix. Some subclasses may define a
		/// Physical coordinate system such as in VR. This method provides access
		/// to the matrix mapping that space to world coordinates.
		/// </summary>
		// Token: 0x06001CC2 RID: 7362 RVA: 0x0002D328 File Offset: 0x0002B528
		public virtual void GetPhysicalToWorldMatrix(vtkMatrix4x4 matrix)
		{
			vtkRenderWindow.vtkRenderWindow_GetPhysicalToWorldMatrix_50(base.GetCppThis(), (matrix == null) ? default(HandleRef) : matrix.GetCppThis());
		}

		// Token: 0x06001CC3 RID: 7363
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderWindow_GetPlatformSupportsRenderWindowSharing_51(HandleRef pThis);

		/// <summary>
		/// Set/Get an already existing window that this window should
		/// share data with if possible. This must be set
		/// after the shared render window has been created and initialized
		/// but before this window has been initialized. Not all platforms
		/// support data sharing.
		/// </summary>
		// Token: 0x06001CC4 RID: 7364 RVA: 0x0002D358 File Offset: 0x0002B558
		public virtual bool GetPlatformSupportsRenderWindowSharing()
		{
			return vtkRenderWindow.vtkRenderWindow_GetPlatformSupportsRenderWindowSharing_51(base.GetCppThis()) != 0;
		}

		// Token: 0x06001CC5 RID: 7365
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindow_GetPointSmoothing_52(HandleRef pThis);

		/// <summary>
		/// Turn on/off point smoothing. Default is off.
		/// This must be applied before the first Render.
		/// </summary>
		// Token: 0x06001CC6 RID: 7366 RVA: 0x0002D380 File Offset: 0x0002B580
		public virtual int GetPointSmoothing()
		{
			return vtkRenderWindow.vtkRenderWindow_GetPointSmoothing_52(base.GetCppThis());
		}

		// Token: 0x06001CC7 RID: 7367
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindow_GetPolygonSmoothing_53(HandleRef pThis);

		/// <summary>
		/// Turn on/off polygon smoothing. Default is off.
		/// This must be applied before the first Render.
		/// </summary>
		// Token: 0x06001CC8 RID: 7368 RVA: 0x0002D3A0 File Offset: 0x0002B5A0
		public virtual int GetPolygonSmoothing()
		{
			return vtkRenderWindow.vtkRenderWindow_GetPolygonSmoothing_53(base.GetCppThis());
		}

		// Token: 0x06001CC9 RID: 7369
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindow_GetRGBACharPixelData_54(HandleRef pThis, int arg0, int arg1, int arg2, int arg3, int arg4, int arg5);

		/// <summary>
		/// Same as Get/SetPixelData except that the image also contains an alpha
		/// component. The image is transmitted as RGBARGBARGBA... each of which is a
		/// float value. The "blend" parameter controls whether the SetRGBAPixelData
		/// method blends the data with the previous contents of the frame buffer
		/// or completely replaces the frame buffer data.
		/// </summary>
		// Token: 0x06001CCA RID: 7370 RVA: 0x0002D3C0 File Offset: 0x0002B5C0
		public virtual IntPtr GetRGBACharPixelData(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
		{
			return vtkRenderWindow.vtkRenderWindow_GetRGBACharPixelData_54(base.GetCppThis(), arg0, arg1, arg2, arg3, arg4, arg5);
		}

		// Token: 0x06001CCB RID: 7371
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindow_GetRGBACharPixelData_55(HandleRef pThis, int arg0, int arg1, int arg2, int arg3, int arg4, HandleRef arg5, int arg6);

		/// <summary>
		/// Same as Get/SetPixelData except that the image also contains an alpha
		/// component. The image is transmitted as RGBARGBARGBA... each of which is a
		/// float value. The "blend" parameter controls whether the SetRGBAPixelData
		/// method blends the data with the previous contents of the frame buffer
		/// or completely replaces the frame buffer data.
		/// </summary>
		// Token: 0x06001CCC RID: 7372 RVA: 0x0002D3E8 File Offset: 0x0002B5E8
		public virtual int GetRGBACharPixelData(int arg0, int arg1, int arg2, int arg3, int arg4, vtkUnsignedCharArray arg5, int arg6)
		{
			return vtkRenderWindow.vtkRenderWindow_GetRGBACharPixelData_55(base.GetCppThis(), arg0, arg1, arg2, arg3, arg4, (arg5 == null) ? default(HandleRef) : arg5.GetCppThis(), arg6);
		}

		// Token: 0x06001CCD RID: 7373
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindow_GetRGBAPixelData_56(HandleRef pThis, int arg0, int arg1, int arg2, int arg3, int arg4, int arg5);

		/// <summary>
		/// Same as Get/SetPixelData except that the image also contains an alpha
		/// component. The image is transmitted as RGBARGBARGBA... each of which is a
		/// float value. The "blend" parameter controls whether the SetRGBAPixelData
		/// method blends the data with the previous contents of the frame buffer
		/// or completely replaces the frame buffer data.
		/// </summary>
		// Token: 0x06001CCE RID: 7374 RVA: 0x0002D428 File Offset: 0x0002B628
		public virtual IntPtr GetRGBAPixelData(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
		{
			return vtkRenderWindow.vtkRenderWindow_GetRGBAPixelData_56(base.GetCppThis(), arg0, arg1, arg2, arg3, arg4, arg5);
		}

		// Token: 0x06001CCF RID: 7375
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindow_GetRGBAPixelData_57(HandleRef pThis, int arg0, int arg1, int arg2, int arg3, int arg4, HandleRef arg5, int arg6);

		/// <summary>
		/// Same as Get/SetPixelData except that the image also contains an alpha
		/// component. The image is transmitted as RGBARGBARGBA... each of which is a
		/// float value. The "blend" parameter controls whether the SetRGBAPixelData
		/// method blends the data with the previous contents of the frame buffer
		/// or completely replaces the frame buffer data.
		/// </summary>
		// Token: 0x06001CD0 RID: 7376 RVA: 0x0002D450 File Offset: 0x0002B650
		public virtual int GetRGBAPixelData(int arg0, int arg1, int arg2, int arg3, int arg4, vtkFloatArray arg5, int arg6)
		{
			return vtkRenderWindow.vtkRenderWindow_GetRGBAPixelData_57(base.GetCppThis(), arg0, arg1, arg2, arg3, arg4, (arg5 == null) ? default(HandleRef) : arg5.GetCppThis(), arg6);
		}

		// Token: 0x06001CD1 RID: 7377
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindow_GetRenderLibrary_58();

		/// <summary>
		/// What rendering library has the user requested
		/// </summary>
		// Token: 0x06001CD2 RID: 7378 RVA: 0x0002D490 File Offset: 0x0002B690
		public static string GetRenderLibrary()
		{
			string s = Marshal.PtrToStringAnsi(vtkRenderWindow.vtkRenderWindow_GetRenderLibrary_58());
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06001CD3 RID: 7379
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindow_GetRenderTimer_59(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the render timer log for this window.
		/// </summary>
		// Token: 0x06001CD4 RID: 7380 RVA: 0x0002D4C4 File Offset: 0x0002B6C4
		public virtual vtkRenderTimerLog GetRenderTimer()
		{
			vtkRenderTimerLog vtkRenderTimerLog = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderWindow.vtkRenderWindow_GetRenderTimer_59(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderTimerLog = (vtkRenderTimerLog)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderTimerLog.Register(null);
				}
			}
			return vtkRenderTimerLog;
		}

		// Token: 0x06001CD5 RID: 7381
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindow_GetRenderers_60(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the collection of renderers in the render window.
		/// </summary>
		// Token: 0x06001CD6 RID: 7382 RVA: 0x0002D534 File Offset: 0x0002B734
		public vtkRendererCollection GetRenderers()
		{
			vtkRendererCollection vtkRendererCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderWindow.vtkRenderWindow_GetRenderers_60(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRendererCollection = (vtkRendererCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRendererCollection.Register(null);
				}
			}
			return vtkRendererCollection;
		}

		// Token: 0x06001CD7 RID: 7383
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindow_GetRenderingBackend_61(HandleRef pThis);

		/// <summary>
		/// What rendering backend has the user requested
		/// </summary>
		// Token: 0x06001CD8 RID: 7384 RVA: 0x0002D5A4 File Offset: 0x0002B7A4
		public virtual string GetRenderingBackend()
		{
			string s = Marshal.PtrToStringAnsi(vtkRenderWindow.vtkRenderWindow_GetRenderingBackend_61(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06001CD9 RID: 7385
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindow_GetSharedRenderWindow_62(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get an already existing window that this window should
		/// share data with if possible. This must be set
		/// after the shared render window has been created and initialized
		/// but before this window has been initialized. Not all platforms
		/// support data sharing.
		/// </summary>
		// Token: 0x06001CDA RID: 7386 RVA: 0x0002D5E0 File Offset: 0x0002B7E0
		public virtual vtkRenderWindow GetSharedRenderWindow()
		{
			vtkRenderWindow vtkRenderWindow = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderWindow.vtkRenderWindow_GetSharedRenderWindow_62(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderWindow = (vtkRenderWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderWindow.Register(null);
				}
			}
			return vtkRenderWindow;
		}

		// Token: 0x06001CDB RID: 7387
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindow_GetStencilCapable_63(HandleRef pThis);

		/// <summary>
		/// Set / Get the availability of the stencil buffer.
		/// </summary>
		// Token: 0x06001CDC RID: 7388 RVA: 0x0002D650 File Offset: 0x0002B850
		public virtual int GetStencilCapable()
		{
			return vtkRenderWindow.vtkRenderWindow_GetStencilCapable_63(base.GetCppThis());
		}

		// Token: 0x06001CDD RID: 7389
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindow_GetStereoCapableWindow_64(HandleRef pThis);

		/// <summary>
		/// Prescribe that the window be created in a stereo-capable mode. This
		/// method must be called before the window is realized. Default is off.
		/// </summary>
		// Token: 0x06001CDE RID: 7390 RVA: 0x0002D670 File Offset: 0x0002B870
		public virtual int GetStereoCapableWindow()
		{
			return vtkRenderWindow.vtkRenderWindow_GetStereoCapableWindow_64(base.GetCppThis());
		}

		// Token: 0x06001CDF RID: 7391
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindow_GetStereoRender_65(HandleRef pThis);

		/// <summary>
		/// Turn on/off stereo rendering.
		/// </summary>
		// Token: 0x06001CE0 RID: 7392 RVA: 0x0002D690 File Offset: 0x0002B890
		public virtual int GetStereoRender()
		{
			return vtkRenderWindow.vtkRenderWindow_GetStereoRender_65(base.GetCppThis());
		}

		// Token: 0x06001CE1 RID: 7393
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindow_GetStereoType_66(HandleRef pThis);

		/// <summary>
		/// Set/Get what type of stereo rendering to use.  CrystalEyes
		/// mode uses frame-sequential capabilities available in OpenGL
		/// to drive LCD shutter glasses and stereo projectors.  RedBlue
		/// mode is a simple type of stereo for use with red-blue glasses.
		/// Anaglyph mode is a superset of RedBlue mode, but the color
		/// output channels can be configured using the AnaglyphColorMask
		/// and the color of the original image can be (somewhat) maintained
		/// using AnaglyphColorSaturation;  the default colors for Anaglyph
		/// mode is red-cyan.  Interlaced stereo mode produces a composite
		/// image where horizontal lines alternate between left and right
		/// views.  StereoLeft and StereoRight modes choose one or the other
		/// stereo view.  Dresden mode is yet another stereoscopic
		/// interleaving. Fake simply causes the window to render twice without
		/// actually swapping the camera from left eye to right eye. This is useful in
		/// certain applications that want to emulate the rendering passes without
		/// actually rendering in stereo mode. Emulate is similar to Fake, except that
		/// it does render left and right eye. There is no compositing of the resulting
		/// images from the two eyes at the end of each render in this mode, hence the
		/// result onscreen will be the right eye.
		/// </summary>
		// Token: 0x06001CE2 RID: 7394 RVA: 0x0002D6B0 File Offset: 0x0002B8B0
		public virtual int GetStereoType()
		{
			return vtkRenderWindow.vtkRenderWindow_GetStereoType_66(base.GetCppThis());
		}

		// Token: 0x06001CE3 RID: 7395
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindow_GetStereoTypeAsString_67(HandleRef pThis);

		/// <summary>
		/// Returns the stereo type as a string.
		/// </summary>
		// Token: 0x06001CE4 RID: 7396 RVA: 0x0002D6D0 File Offset: 0x0002B8D0
		public string GetStereoTypeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkRenderWindow.vtkRenderWindow_GetStereoTypeAsString_67(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06001CE5 RID: 7397
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindow_GetStereoTypeAsString_68(int type);

		/// <summary>
		/// Returns the stereo type as a string.
		/// </summary>
		// Token: 0x06001CE6 RID: 7398 RVA: 0x0002D70C File Offset: 0x0002B90C
		public static string GetStereoTypeAsString(int type)
		{
			string s = Marshal.PtrToStringAnsi(vtkRenderWindow.vtkRenderWindow_GetStereoTypeAsString_68(type));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06001CE7 RID: 7399
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindow_GetSwapBuffers_69(HandleRef pThis);

		/// <summary>
		/// Turn on/off buffer swapping between images.
		/// </summary>
		// Token: 0x06001CE8 RID: 7400 RVA: 0x0002D744 File Offset: 0x0002B944
		public virtual int GetSwapBuffers()
		{
			return vtkRenderWindow.vtkRenderWindow_GetSwapBuffers_69(base.GetCppThis());
		}

		// Token: 0x06001CE9 RID: 7401
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderWindow_GetUseSRGBColorSpace_70(HandleRef pThis);

		/// <summary>
		/// Set/Get if we want this window to use the sRGB color space.
		/// Some hardware/drivers do not fully support this.
		/// </summary>
		// Token: 0x06001CEA RID: 7402 RVA: 0x0002D764 File Offset: 0x0002B964
		public virtual bool GetUseSRGBColorSpace()
		{
			return vtkRenderWindow.vtkRenderWindow_GetUseSRGBColorSpace_70(base.GetCppThis()) != 0;
		}

		// Token: 0x06001CEB RID: 7403
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindow_GetZbufferData_71(HandleRef pThis, int arg0, int arg1, int arg2, int arg3);

		/// <summary>
		/// Set/Get the zbuffer data from the frame buffer.
		/// (x,y) is any corner of the rectangle. (x2,y2) is its opposite corner on
		/// the diagonal.
		/// </summary>
		// Token: 0x06001CEC RID: 7404 RVA: 0x0002D78C File Offset: 0x0002B98C
		public virtual IntPtr GetZbufferData(int arg0, int arg1, int arg2, int arg3)
		{
			return vtkRenderWindow.vtkRenderWindow_GetZbufferData_71(base.GetCppThis(), arg0, arg1, arg2, arg3);
		}

		// Token: 0x06001CED RID: 7405
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindow_GetZbufferData_72(HandleRef pThis, int arg0, int arg1, int arg2, int arg3, IntPtr arg4);

		/// <summary>
		/// Set/Get the zbuffer data from the frame buffer.
		/// (x,y) is any corner of the rectangle. (x2,y2) is its opposite corner on
		/// the diagonal.
		/// </summary>
		// Token: 0x06001CEE RID: 7406 RVA: 0x0002D7B0 File Offset: 0x0002B9B0
		public virtual int GetZbufferData(int arg0, int arg1, int arg2, int arg3, IntPtr arg4)
		{
			return vtkRenderWindow.vtkRenderWindow_GetZbufferData_72(base.GetCppThis(), arg0, arg1, arg2, arg3, arg4);
		}

		// Token: 0x06001CEF RID: 7407
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindow_GetZbufferData_73(HandleRef pThis, int arg0, int arg1, int arg2, int arg3, HandleRef arg4);

		/// <summary>
		/// Set/Get the zbuffer data from the frame buffer.
		/// (x,y) is any corner of the rectangle. (x2,y2) is its opposite corner on
		/// the diagonal.
		/// </summary>
		// Token: 0x06001CF0 RID: 7408 RVA: 0x0002D7D8 File Offset: 0x0002B9D8
		public virtual int GetZbufferData(int arg0, int arg1, int arg2, int arg3, vtkFloatArray arg4)
		{
			return vtkRenderWindow.vtkRenderWindow_GetZbufferData_73(base.GetCppThis(), arg0, arg1, arg2, arg3, (arg4 == null) ? default(HandleRef) : arg4.GetCppThis());
		}

		// Token: 0x06001CF1 RID: 7409
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkRenderWindow_GetZbufferDataAtPoint_74(HandleRef pThis, int x, int y);

		/// <summary>
		/// Set/Get the zbuffer data from the frame buffer.
		/// (x,y) is any corner of the rectangle. (x2,y2) is its opposite corner on
		/// the diagonal.
		/// </summary>
		// Token: 0x06001CF2 RID: 7410 RVA: 0x0002D814 File Offset: 0x0002BA14
		public float GetZbufferDataAtPoint(int x, int y)
		{
			return vtkRenderWindow.vtkRenderWindow_GetZbufferDataAtPoint_74(base.GetCppThis(), x, y);
		}

		// Token: 0x06001CF3 RID: 7411
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindow_HasRenderer_75(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Query if a renderer is in the list of renderers.
		/// </summary>
		// Token: 0x06001CF4 RID: 7412 RVA: 0x0002D838 File Offset: 0x0002BA38
		public int HasRenderer(vtkRenderer arg0)
		{
			return vtkRenderWindow.vtkRenderWindow_HasRenderer_75(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06001CF5 RID: 7413
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_HideCursor_76(HandleRef pThis);

		/// <summary>
		/// Hide or Show the mouse cursor, it is nice to be able to hide the
		/// default cursor if you want VTK to display a 3D cursor instead.
		/// Set cursor position in window (note that (0,0) is the lower left
		/// corner).
		/// </summary>
		// Token: 0x06001CF6 RID: 7414 RVA: 0x0002D86C File Offset: 0x0002BA6C
		public virtual void HideCursor()
		{
			vtkRenderWindow.vtkRenderWindow_HideCursor_76(base.GetCppThis());
		}

		// Token: 0x06001CF7 RID: 7415
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderWindow_InitializeFromCurrentContext_77(HandleRef pThis);

		/// <summary>
		/// Initialize the render window from the information associated
		/// with the currently activated OpenGL context.
		/// </summary>
		// Token: 0x06001CF8 RID: 7416 RVA: 0x0002D87C File Offset: 0x0002BA7C
		public virtual bool InitializeFromCurrentContext()
		{
			return vtkRenderWindow.vtkRenderWindow_InitializeFromCurrentContext_77(base.GetCppThis()) != 0;
		}

		// Token: 0x06001CF9 RID: 7417
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindow_IsA_78(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001CFA RID: 7418 RVA: 0x0002D8A4 File Offset: 0x0002BAA4
		public override int IsA(string type)
		{
			return vtkRenderWindow.vtkRenderWindow_IsA_78(base.GetCppThis(), type);
		}

		// Token: 0x06001CFB RID: 7419
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderWindow_IsCurrent_79(HandleRef pThis);

		/// <summary>
		/// Tells if this window is the current graphics context for the calling
		/// thread.
		/// </summary>
		// Token: 0x06001CFC RID: 7420 RVA: 0x0002D8C4 File Offset: 0x0002BAC4
		public virtual bool IsCurrent()
		{
			return vtkRenderWindow.vtkRenderWindow_IsCurrent_79(base.GetCppThis()) != 0;
		}

		// Token: 0x06001CFD RID: 7421
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindow_IsDirect_80(HandleRef pThis);

		/// <summary>
		/// Is this render window using hardware acceleration? 0-false, 1-true
		/// </summary>
		// Token: 0x06001CFE RID: 7422 RVA: 0x0002D8EC File Offset: 0x0002BAEC
		public virtual int IsDirect()
		{
			return vtkRenderWindow.vtkRenderWindow_IsDirect_80(base.GetCppThis());
		}

		// Token: 0x06001CFF RID: 7423
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindow_IsTypeOf_81([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001D00 RID: 7424 RVA: 0x0002D90C File Offset: 0x0002BB0C
		public new static int IsTypeOf(string type)
		{
			return vtkRenderWindow.vtkRenderWindow_IsTypeOf_81(type);
		}

		// Token: 0x06001D01 RID: 7425
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_LineSmoothingOff_82(HandleRef pThis);

		/// <summary>
		/// Turn on/off line smoothing. Default is off.
		/// This must be applied before the first Render.
		/// </summary>
		// Token: 0x06001D02 RID: 7426 RVA: 0x0002D926 File Offset: 0x0002BB26
		public virtual void LineSmoothingOff()
		{
			vtkRenderWindow.vtkRenderWindow_LineSmoothingOff_82(base.GetCppThis());
		}

		// Token: 0x06001D03 RID: 7427
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_LineSmoothingOn_83(HandleRef pThis);

		/// <summary>
		/// Turn on/off line smoothing. Default is off.
		/// This must be applied before the first Render.
		/// </summary>
		// Token: 0x06001D04 RID: 7428 RVA: 0x0002D935 File Offset: 0x0002BB35
		public virtual void LineSmoothingOn()
		{
			vtkRenderWindow.vtkRenderWindow_LineSmoothingOn_83(base.GetCppThis());
		}

		// Token: 0x06001D05 RID: 7429
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindow_MakeRenderWindowInteractor_84(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create an interactor to control renderers in this window. We need
		/// to know what type of interactor to create, because we might be in
		/// X Windows or MS Windows.
		/// </summary>
		// Token: 0x06001D06 RID: 7430 RVA: 0x0002D944 File Offset: 0x0002BB44
		public virtual vtkRenderWindowInteractor MakeRenderWindowInteractor()
		{
			vtkRenderWindowInteractor vtkRenderWindowInteractor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderWindow.vtkRenderWindow_MakeRenderWindowInteractor_84(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderWindowInteractor = (vtkRenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderWindowInteractor.Register(null);
				}
			}
			return vtkRenderWindowInteractor;
		}

		// Token: 0x06001D07 RID: 7431
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindow_NewInstance_86(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001D08 RID: 7432 RVA: 0x0002D9B4 File Offset: 0x0002BBB4
		public new vtkRenderWindow NewInstance()
		{
			vtkRenderWindow result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderWindow.vtkRenderWindow_NewInstance_86(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06001D09 RID: 7433
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_PointSmoothingOff_87(HandleRef pThis);

		/// <summary>
		/// Turn on/off point smoothing. Default is off.
		/// This must be applied before the first Render.
		/// </summary>
		// Token: 0x06001D0A RID: 7434 RVA: 0x0002DA0E File Offset: 0x0002BC0E
		public virtual void PointSmoothingOff()
		{
			vtkRenderWindow.vtkRenderWindow_PointSmoothingOff_87(base.GetCppThis());
		}

		// Token: 0x06001D0B RID: 7435
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_PointSmoothingOn_88(HandleRef pThis);

		/// <summary>
		/// Turn on/off point smoothing. Default is off.
		/// This must be applied before the first Render.
		/// </summary>
		// Token: 0x06001D0C RID: 7436 RVA: 0x0002DA1D File Offset: 0x0002BC1D
		public virtual void PointSmoothingOn()
		{
			vtkRenderWindow.vtkRenderWindow_PointSmoothingOn_88(base.GetCppThis());
		}

		// Token: 0x06001D0D RID: 7437
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_PolygonSmoothingOff_89(HandleRef pThis);

		/// <summary>
		/// Turn on/off polygon smoothing. Default is off.
		/// This must be applied before the first Render.
		/// </summary>
		// Token: 0x06001D0E RID: 7438 RVA: 0x0002DA2C File Offset: 0x0002BC2C
		public virtual void PolygonSmoothingOff()
		{
			vtkRenderWindow.vtkRenderWindow_PolygonSmoothingOff_89(base.GetCppThis());
		}

		// Token: 0x06001D0F RID: 7439
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_PolygonSmoothingOn_90(HandleRef pThis);

		/// <summary>
		/// Turn on/off polygon smoothing. Default is off.
		/// This must be applied before the first Render.
		/// </summary>
		// Token: 0x06001D10 RID: 7440 RVA: 0x0002DA3B File Offset: 0x0002BC3B
		public virtual void PolygonSmoothingOn()
		{
			vtkRenderWindow.vtkRenderWindow_PolygonSmoothingOn_90(base.GetCppThis());
		}

		// Token: 0x06001D11 RID: 7441
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_ReleaseRGBAPixelData_91(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// Same as Get/SetPixelData except that the image also contains an alpha
		/// component. The image is transmitted as RGBARGBARGBA... each of which is a
		/// float value. The "blend" parameter controls whether the SetRGBAPixelData
		/// method blends the data with the previous contents of the frame buffer
		/// or completely replaces the frame buffer data.
		/// </summary>
		// Token: 0x06001D12 RID: 7442 RVA: 0x0002DA4A File Offset: 0x0002BC4A
		public virtual void ReleaseRGBAPixelData(IntPtr arg0)
		{
			vtkRenderWindow.vtkRenderWindow_ReleaseRGBAPixelData_91(base.GetCppThis(), arg0);
		}

		// Token: 0x06001D13 RID: 7443
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_RemoveRenderer_92(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Remove a renderer from the list of renderers.
		/// </summary>
		// Token: 0x06001D14 RID: 7444 RVA: 0x0002DA5C File Offset: 0x0002BC5C
		public void RemoveRenderer(vtkRenderer arg0)
		{
			vtkRenderWindow.vtkRenderWindow_RemoveRenderer_92(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06001D15 RID: 7445
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_Render_93(HandleRef pThis);

		/// <summary>
		/// Ask each renderer owned by this RenderWindow to render its image and
		/// synchronize this process.
		/// </summary>
		// Token: 0x06001D16 RID: 7446 RVA: 0x0002DA8B File Offset: 0x0002BC8B
		public override void Render()
		{
			vtkRenderWindow.vtkRenderWindow_Render_93(base.GetCppThis());
		}

		// Token: 0x06001D17 RID: 7447
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindow_ReportCapabilities_94(HandleRef pThis);

		/// <summary>
		/// Get report of capabilities for the render window
		/// </summary>
		// Token: 0x06001D18 RID: 7448 RVA: 0x0002DA9C File Offset: 0x0002BC9C
		public virtual string ReportCapabilities()
		{
			string s = Marshal.PtrToStringAnsi(vtkRenderWindow.vtkRenderWindow_ReportCapabilities_94(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06001D19 RID: 7449
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindow_SafeDownCast_95(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001D1A RID: 7450 RVA: 0x0002DAD8 File Offset: 0x0002BCD8
		public new static vtkRenderWindow SafeDownCast(vtkObjectBase o)
		{
			vtkRenderWindow vtkRenderWindow = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderWindow.vtkRenderWindow_SafeDownCast_95((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderWindow = (vtkRenderWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderWindow.Register(null);
				}
			}
			return vtkRenderWindow;
		}

		// Token: 0x06001D1B RID: 7451
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_SetAbortRender_96(HandleRef pThis, int _arg);

		/// <summary>
		/// This is a flag that can be set to interrupt a rendering that is in
		/// progress.
		/// </summary>
		// Token: 0x06001D1C RID: 7452 RVA: 0x0002DB57 File Offset: 0x0002BD57
		public virtual void SetAbortRender(int _arg)
		{
			vtkRenderWindow.vtkRenderWindow_SetAbortRender_96(base.GetCppThis(), _arg);
		}

		// Token: 0x06001D1D RID: 7453
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_SetAlphaBitPlanes_97(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the use of alpha bitplanes.
		/// </summary>
		// Token: 0x06001D1E RID: 7454 RVA: 0x0002DB67 File Offset: 0x0002BD67
		public virtual void SetAlphaBitPlanes(int _arg)
		{
			vtkRenderWindow.vtkRenderWindow_SetAlphaBitPlanes_97(base.GetCppThis(), _arg);
		}

		// Token: 0x06001D1F RID: 7455
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_SetAnaglyphColorMask_98(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Set/get the anaglyph color mask values.  These two numbers are bits
		/// mask that control which color channels of the original stereo
		/// images are used to produce the final anaglyph image.  The first
		/// value is the color mask for the left view, the second the mask
		/// for the right view.  If a bit in the mask is on for a particular
		/// color for a view, that color is passed on to the final view; if
		/// it is not set, that channel for that view is ignored.
		/// The bits are arranged as r, g, and b, so r = 4, g = 2, and b = 1.
		/// By default, the first value (the left view) is set to 4, and the
		/// second value is set to 3.  That means that the red output channel
		/// comes from the left view, and the green and blue values come from
		/// the right view.
		/// </summary>
		// Token: 0x06001D20 RID: 7456 RVA: 0x0002DB77 File Offset: 0x0002BD77
		public virtual void SetAnaglyphColorMask(int _arg1, int _arg2)
		{
			vtkRenderWindow.vtkRenderWindow_SetAnaglyphColorMask_98(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x06001D21 RID: 7457
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_SetAnaglyphColorMask_99(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/get the anaglyph color mask values.  These two numbers are bits
		/// mask that control which color channels of the original stereo
		/// images are used to produce the final anaglyph image.  The first
		/// value is the color mask for the left view, the second the mask
		/// for the right view.  If a bit in the mask is on for a particular
		/// color for a view, that color is passed on to the final view; if
		/// it is not set, that channel for that view is ignored.
		/// The bits are arranged as r, g, and b, so r = 4, g = 2, and b = 1.
		/// By default, the first value (the left view) is set to 4, and the
		/// second value is set to 3.  That means that the red output channel
		/// comes from the left view, and the green and blue values come from
		/// the right view.
		/// </summary>
		// Token: 0x06001D22 RID: 7458 RVA: 0x0002DB88 File Offset: 0x0002BD88
		public void SetAnaglyphColorMask(IntPtr _arg)
		{
			vtkRenderWindow.vtkRenderWindow_SetAnaglyphColorMask_99(base.GetCppThis(), _arg);
		}

		// Token: 0x06001D23 RID: 7459
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_SetAnaglyphColorSaturation_100(HandleRef pThis, float _arg);

		/// <summary>
		/// Set/get the anaglyph color saturation factor.  This number ranges from
		/// 0.0 to 1.0:  0.0 means that no color from the original object is
		/// maintained, 1.0 means all of the color is maintained.  The default
		/// value is 0.65.  Too much saturation can produce uncomfortable 3D
		/// viewing because anaglyphs also use color to encode 3D.
		/// </summary>
		// Token: 0x06001D24 RID: 7460 RVA: 0x0002DB98 File Offset: 0x0002BD98
		public virtual void SetAnaglyphColorSaturation(float _arg)
		{
			vtkRenderWindow.vtkRenderWindow_SetAnaglyphColorSaturation_100(base.GetCppThis(), _arg);
		}

		// Token: 0x06001D25 RID: 7461
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_SetBorders_101(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off window manager borders. Typically, you shouldn't turn the
		/// borders off, because that bypasses the window manager and can cause
		/// undesirable behavior.
		/// </summary>
		// Token: 0x06001D26 RID: 7462 RVA: 0x0002DBA8 File Offset: 0x0002BDA8
		public virtual void SetBorders(int _arg)
		{
			vtkRenderWindow.vtkRenderWindow_SetBorders_101(base.GetCppThis(), _arg);
		}

		// Token: 0x06001D27 RID: 7463
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_SetCurrentCursor_102(HandleRef pThis, int _arg);

		/// <summary>
		/// Change the shape of the cursor.
		/// </summary>
		// Token: 0x06001D28 RID: 7464 RVA: 0x0002DBB8 File Offset: 0x0002BDB8
		public virtual void SetCurrentCursor(int _arg)
		{
			vtkRenderWindow.vtkRenderWindow_SetCurrentCursor_102(base.GetCppThis(), _arg);
		}

		// Token: 0x06001D29 RID: 7465
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_SetCursorFileName_103(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the full path to the custom cursor.
		/// This is used when the current cursor is set to VTK_CURSOR_CUSTOM.
		/// </summary>
		// Token: 0x06001D2A RID: 7466 RVA: 0x0002DBC8 File Offset: 0x0002BDC8
		public virtual void SetCursorFileName(string _arg)
		{
			vtkRenderWindow.vtkRenderWindow_SetCursorFileName_103(base.GetCppThis(), _arg);
		}

		// Token: 0x06001D2B RID: 7467
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_SetCursorPosition_104(HandleRef pThis, int arg0, int arg1);

		/// <summary>
		/// Hide or Show the mouse cursor, it is nice to be able to hide the
		/// default cursor if you want VTK to display a 3D cursor instead.
		/// Set cursor position in window (note that (0,0) is the lower left
		/// corner).
		/// </summary>
		// Token: 0x06001D2C RID: 7468 RVA: 0x0002DBD8 File Offset: 0x0002BDD8
		public virtual void SetCursorPosition(int arg0, int arg1)
		{
			vtkRenderWindow.vtkRenderWindow_SetCursorPosition_104(base.GetCppThis(), arg0, arg1);
		}

		// Token: 0x06001D2D RID: 7469
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_SetDesiredUpdateRate_105(HandleRef pThis, double arg0);

		/// <summary>
		/// Set/Get the desired update rate. This is used with
		/// the vtkLODActor class. When using level of detail actors you
		/// need to specify what update rate you require. The LODActors then
		/// will pick the correct resolution to meet your desired update rate
		/// in frames per second. A value of zero indicates that they can use
		/// all the time they want to.
		/// </summary>
		// Token: 0x06001D2E RID: 7470 RVA: 0x0002DBE9 File Offset: 0x0002BDE9
		public virtual void SetDesiredUpdateRate(double arg0)
		{
			vtkRenderWindow.vtkRenderWindow_SetDesiredUpdateRate_105(base.GetCppThis(), arg0);
		}

		// Token: 0x06001D2F RID: 7471
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_SetDeviceIndex_106(HandleRef pThis, int _arg);

		/// <summary>
		/// If there are several graphics card installed on a system,
		/// this index can be used to specify which card you want to render to.
		/// the default is 0. This may not work on all derived render window and
		/// it may need to be set before the first render.
		/// </summary>
		// Token: 0x06001D30 RID: 7472 RVA: 0x0002DBF9 File Offset: 0x0002BDF9
		public virtual void SetDeviceIndex(int _arg)
		{
			vtkRenderWindow.vtkRenderWindow_SetDeviceIndex_106(base.GetCppThis(), _arg);
		}

		// Token: 0x06001D31 RID: 7473
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_SetDisplayId_107(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// Dummy stubs for vtkWindow API.
		/// </summary>
		// Token: 0x06001D32 RID: 7474 RVA: 0x0002DC09 File Offset: 0x0002BE09
		public override void SetDisplayId(IntPtr arg0)
		{
			vtkRenderWindow.vtkRenderWindow_SetDisplayId_107(base.GetCppThis(), arg0);
		}

		// Token: 0x06001D33 RID: 7475
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_SetForceMakeCurrent_108(HandleRef pThis);

		/// <summary>
		/// If called, allow MakeCurrent() to skip cache-check when called.
		/// MakeCurrent() reverts to original behavior of cache-checking
		/// on the next render.
		/// </summary>
		// Token: 0x06001D34 RID: 7476 RVA: 0x0002DC19 File Offset: 0x0002BE19
		public virtual void SetForceMakeCurrent()
		{
			vtkRenderWindow.vtkRenderWindow_SetForceMakeCurrent_108(base.GetCppThis());
		}

		// Token: 0x06001D35 RID: 7477
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_SetFullScreen_109(HandleRef pThis, int arg0);

		/// <summary>
		/// Turn on/off rendering full screen window size.
		/// </summary>
		// Token: 0x06001D36 RID: 7478 RVA: 0x0002DC28 File Offset: 0x0002BE28
		public virtual void SetFullScreen(int arg0)
		{
			vtkRenderWindow.vtkRenderWindow_SetFullScreen_109(base.GetCppThis(), arg0);
		}

		// Token: 0x06001D37 RID: 7479
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_SetInAbortCheck_110(HandleRef pThis, int _arg);

		/// <summary>
		/// This is a flag that can be set to interrupt a rendering that is in
		/// progress.
		/// </summary>
		// Token: 0x06001D38 RID: 7480 RVA: 0x0002DC38 File Offset: 0x0002BE38
		public virtual void SetInAbortCheck(int _arg)
		{
			vtkRenderWindow.vtkRenderWindow_SetInAbortCheck_110(base.GetCppThis(), _arg);
		}

		// Token: 0x06001D39 RID: 7481
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_SetInteractor_111(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the interactor to the render window
		/// </summary>
		// Token: 0x06001D3A RID: 7482 RVA: 0x0002DC48 File Offset: 0x0002BE48
		public virtual void SetInteractor(vtkRenderWindowInteractor arg0)
		{
			vtkRenderWindow.vtkRenderWindow_SetInteractor_111(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06001D3B RID: 7483
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_SetLineSmoothing_112(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off line smoothing. Default is off.
		/// This must be applied before the first Render.
		/// </summary>
		// Token: 0x06001D3C RID: 7484 RVA: 0x0002DC77 File Offset: 0x0002BE77
		public virtual void SetLineSmoothing(int _arg)
		{
			vtkRenderWindow.vtkRenderWindow_SetLineSmoothing_112(base.GetCppThis(), _arg);
		}

		// Token: 0x06001D3D RID: 7485
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_SetMultiSamples_113(HandleRef pThis, int arg0);

		/// <summary>
		/// Set / Get the number of multisamples to use for hardware antialiasing.
		/// A value of 1 will be set to 0.
		/// </summary>
		// Token: 0x06001D3E RID: 7486 RVA: 0x0002DC87 File Offset: 0x0002BE87
		public virtual void SetMultiSamples(int arg0)
		{
			vtkRenderWindow.vtkRenderWindow_SetMultiSamples_113(base.GetCppThis(), arg0);
		}

		// Token: 0x06001D3F RID: 7487
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_SetNextWindowId_114(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// Dummy stubs for vtkWindow API.
		/// </summary>
		// Token: 0x06001D40 RID: 7488 RVA: 0x0002DC97 File Offset: 0x0002BE97
		public virtual void SetNextWindowId(IntPtr arg0)
		{
			vtkRenderWindow.vtkRenderWindow_SetNextWindowId_114(base.GetCppThis(), arg0);
		}

		// Token: 0x06001D41 RID: 7489
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_SetNextWindowInfo_115(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Dummy stubs for vtkWindow API.
		/// </summary>
		// Token: 0x06001D42 RID: 7490 RVA: 0x0002DCA7 File Offset: 0x0002BEA7
		public virtual void SetNextWindowInfo(string arg0)
		{
			vtkRenderWindow.vtkRenderWindow_SetNextWindowInfo_115(base.GetCppThis(), arg0);
		}

		// Token: 0x06001D43 RID: 7491
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_SetNumberOfLayers_116(HandleRef pThis, int _arg);

		/// <summary>
		/// Get the number of layers for renderers.  Each renderer should have
		/// its layer set individually.  Some algorithms iterate through all layers,
		/// so it is not wise to set the number of layers to be exorbitantly large
		/// (say bigger than 100).
		/// </summary>
		// Token: 0x06001D44 RID: 7492 RVA: 0x0002DCB7 File Offset: 0x0002BEB7
		public virtual void SetNumberOfLayers(int _arg)
		{
			vtkRenderWindow.vtkRenderWindow_SetNumberOfLayers_116(base.GetCppThis(), _arg);
		}

		// Token: 0x06001D45 RID: 7493
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_SetParentId_117(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// Dummy stubs for vtkWindow API.
		/// </summary>
		// Token: 0x06001D46 RID: 7494 RVA: 0x0002DCC7 File Offset: 0x0002BEC7
		public override void SetParentId(IntPtr arg0)
		{
			vtkRenderWindow.vtkRenderWindow_SetParentId_117(base.GetCppThis(), arg0);
		}

		// Token: 0x06001D47 RID: 7495
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_SetParentInfo_118(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Dummy stubs for vtkWindow API.
		/// </summary>
		// Token: 0x06001D48 RID: 7496 RVA: 0x0002DCD7 File Offset: 0x0002BED7
		public override void SetParentInfo(string arg0)
		{
			vtkRenderWindow.vtkRenderWindow_SetParentInfo_118(base.GetCppThis(), arg0);
		}

		// Token: 0x06001D49 RID: 7497
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindow_SetPixelData_119(HandleRef pThis, int arg0, int arg1, int arg2, int arg3, IntPtr arg4, int arg5, int arg6);

		/// <summary>
		/// Set/Get the pixel data of an image, transmitted as RGBRGBRGB. The
		/// front argument indicates if the front buffer should be used or the back
		/// buffer. It is the caller's responsibility to delete the resulting
		/// array. It is very important to realize that the memory in this array
		/// is organized from the bottom of the window to the top. The origin
		/// of the screen is in the lower left corner. The y axis increases as
		/// you go up the screen. So the storage of pixels is from left to right
		/// and from bottom to top.
		/// (x,y) is any corner of the rectangle. (x2,y2) is its opposite corner on
		/// the diagonal.
		/// </summary>
		// Token: 0x06001D4A RID: 7498 RVA: 0x0002DCE8 File Offset: 0x0002BEE8
		public virtual int SetPixelData(int arg0, int arg1, int arg2, int arg3, IntPtr arg4, int arg5, int arg6)
		{
			return vtkRenderWindow.vtkRenderWindow_SetPixelData_119(base.GetCppThis(), arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		}

		// Token: 0x06001D4B RID: 7499
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindow_SetPixelData_120(HandleRef pThis, int arg0, int arg1, int arg2, int arg3, HandleRef arg4, int arg5, int arg6);

		/// <summary>
		/// Set/Get the pixel data of an image, transmitted as RGBRGBRGB. The
		/// front argument indicates if the front buffer should be used or the back
		/// buffer. It is the caller's responsibility to delete the resulting
		/// array. It is very important to realize that the memory in this array
		/// is organized from the bottom of the window to the top. The origin
		/// of the screen is in the lower left corner. The y axis increases as
		/// you go up the screen. So the storage of pixels is from left to right
		/// and from bottom to top.
		/// (x,y) is any corner of the rectangle. (x2,y2) is its opposite corner on
		/// the diagonal.
		/// </summary>
		// Token: 0x06001D4C RID: 7500 RVA: 0x0002DD14 File Offset: 0x0002BF14
		public virtual int SetPixelData(int arg0, int arg1, int arg2, int arg3, vtkUnsignedCharArray arg4, int arg5, int arg6)
		{
			return vtkRenderWindow.vtkRenderWindow_SetPixelData_120(base.GetCppThis(), arg0, arg1, arg2, arg3, (arg4 == null) ? default(HandleRef) : arg4.GetCppThis(), arg5, arg6);
		}

		// Token: 0x06001D4D RID: 7501
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_SetPointSmoothing_121(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off point smoothing. Default is off.
		/// This must be applied before the first Render.
		/// </summary>
		// Token: 0x06001D4E RID: 7502 RVA: 0x0002DD53 File Offset: 0x0002BF53
		public virtual void SetPointSmoothing(int _arg)
		{
			vtkRenderWindow.vtkRenderWindow_SetPointSmoothing_121(base.GetCppThis(), _arg);
		}

		// Token: 0x06001D4F RID: 7503
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_SetPolygonSmoothing_122(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off polygon smoothing. Default is off.
		/// This must be applied before the first Render.
		/// </summary>
		// Token: 0x06001D50 RID: 7504 RVA: 0x0002DD63 File Offset: 0x0002BF63
		public virtual void SetPolygonSmoothing(int _arg)
		{
			vtkRenderWindow.vtkRenderWindow_SetPolygonSmoothing_122(base.GetCppThis(), _arg);
		}

		// Token: 0x06001D51 RID: 7505
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindow_SetRGBACharPixelData_123(HandleRef pThis, int arg0, int arg1, int arg2, int arg3, IntPtr arg4, int arg5, int arg6, int arg7);

		/// <summary>
		/// Same as Get/SetPixelData except that the image also contains an alpha
		/// component. The image is transmitted as RGBARGBARGBA... each of which is a
		/// float value. The "blend" parameter controls whether the SetRGBAPixelData
		/// method blends the data with the previous contents of the frame buffer
		/// or completely replaces the frame buffer data.
		/// </summary>
		// Token: 0x06001D52 RID: 7506 RVA: 0x0002DD74 File Offset: 0x0002BF74
		public virtual int SetRGBACharPixelData(int arg0, int arg1, int arg2, int arg3, IntPtr arg4, int arg5, int arg6, int arg7)
		{
			return vtkRenderWindow.vtkRenderWindow_SetRGBACharPixelData_123(base.GetCppThis(), arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
		}

		// Token: 0x06001D53 RID: 7507
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindow_SetRGBACharPixelData_124(HandleRef pThis, int arg0, int arg1, int arg2, int arg3, HandleRef arg4, int arg5, int arg6, int arg7);

		/// <summary>
		/// Same as Get/SetPixelData except that the image also contains an alpha
		/// component. The image is transmitted as RGBARGBARGBA... each of which is a
		/// float value. The "blend" parameter controls whether the SetRGBAPixelData
		/// method blends the data with the previous contents of the frame buffer
		/// or completely replaces the frame buffer data.
		/// </summary>
		// Token: 0x06001D54 RID: 7508 RVA: 0x0002DDA0 File Offset: 0x0002BFA0
		public virtual int SetRGBACharPixelData(int arg0, int arg1, int arg2, int arg3, vtkUnsignedCharArray arg4, int arg5, int arg6, int arg7)
		{
			return vtkRenderWindow.vtkRenderWindow_SetRGBACharPixelData_124(base.GetCppThis(), arg0, arg1, arg2, arg3, (arg4 == null) ? default(HandleRef) : arg4.GetCppThis(), arg5, arg6, arg7);
		}

		// Token: 0x06001D55 RID: 7509
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindow_SetRGBAPixelData_125(HandleRef pThis, int arg0, int arg1, int arg2, int arg3, IntPtr arg4, int arg5, int arg6, int arg7);

		/// <summary>
		/// Same as Get/SetPixelData except that the image also contains an alpha
		/// component. The image is transmitted as RGBARGBARGBA... each of which is a
		/// float value. The "blend" parameter controls whether the SetRGBAPixelData
		/// method blends the data with the previous contents of the frame buffer
		/// or completely replaces the frame buffer data.
		/// </summary>
		// Token: 0x06001D56 RID: 7510 RVA: 0x0002DDE4 File Offset: 0x0002BFE4
		public virtual int SetRGBAPixelData(int arg0, int arg1, int arg2, int arg3, IntPtr arg4, int arg5, int arg6, int arg7)
		{
			return vtkRenderWindow.vtkRenderWindow_SetRGBAPixelData_125(base.GetCppThis(), arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
		}

		// Token: 0x06001D57 RID: 7511
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindow_SetRGBAPixelData_126(HandleRef pThis, int arg0, int arg1, int arg2, int arg3, HandleRef arg4, int arg5, int arg6, int arg7);

		/// <summary>
		/// Same as Get/SetPixelData except that the image also contains an alpha
		/// component. The image is transmitted as RGBARGBARGBA... each of which is a
		/// float value. The "blend" parameter controls whether the SetRGBAPixelData
		/// method blends the data with the previous contents of the frame buffer
		/// or completely replaces the frame buffer data.
		/// </summary>
		// Token: 0x06001D58 RID: 7512 RVA: 0x0002DE10 File Offset: 0x0002C010
		public virtual int SetRGBAPixelData(int arg0, int arg1, int arg2, int arg3, vtkFloatArray arg4, int arg5, int arg6, int arg7)
		{
			return vtkRenderWindow.vtkRenderWindow_SetRGBAPixelData_126(base.GetCppThis(), arg0, arg1, arg2, arg3, (arg4 == null) ? default(HandleRef) : arg4.GetCppThis(), arg5, arg6, arg7);
		}

		// Token: 0x06001D59 RID: 7513
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_SetSharedRenderWindow_127(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get an already existing window that this window should
		/// share data with if possible. This must be set
		/// after the shared render window has been created and initialized
		/// but before this window has been initialized. Not all platforms
		/// support data sharing.
		/// </summary>
		// Token: 0x06001D5A RID: 7514 RVA: 0x0002DE54 File Offset: 0x0002C054
		public virtual void SetSharedRenderWindow(vtkRenderWindow arg0)
		{
			vtkRenderWindow.vtkRenderWindow_SetSharedRenderWindow_127(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06001D5B RID: 7515
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_SetStencilCapable_128(HandleRef pThis, int _arg);

		/// <summary>
		/// Set / Get the availability of the stencil buffer.
		/// </summary>
		// Token: 0x06001D5C RID: 7516 RVA: 0x0002DE83 File Offset: 0x0002C083
		public virtual void SetStencilCapable(int _arg)
		{
			vtkRenderWindow.vtkRenderWindow_SetStencilCapable_128(base.GetCppThis(), _arg);
		}

		// Token: 0x06001D5D RID: 7517
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_SetStereoCapableWindow_129(HandleRef pThis, int capable);

		/// <summary>
		/// Prescribe that the window be created in a stereo-capable mode. This
		/// method must be called before the window is realized. Default is off.
		/// </summary>
		// Token: 0x06001D5E RID: 7518 RVA: 0x0002DE93 File Offset: 0x0002C093
		public virtual void SetStereoCapableWindow(int capable)
		{
			vtkRenderWindow.vtkRenderWindow_SetStereoCapableWindow_129(base.GetCppThis(), capable);
		}

		// Token: 0x06001D5F RID: 7519
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_SetStereoRender_130(HandleRef pThis, int stereo);

		/// <summary>
		/// Turn on/off stereo rendering.
		/// </summary>
		// Token: 0x06001D60 RID: 7520 RVA: 0x0002DEA3 File Offset: 0x0002C0A3
		public void SetStereoRender(int stereo)
		{
			vtkRenderWindow.vtkRenderWindow_SetStereoRender_130(base.GetCppThis(), stereo);
		}

		// Token: 0x06001D61 RID: 7521
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_SetStereoType_131(HandleRef pThis, int arg0);

		/// <summary>
		/// Set/Get what type of stereo rendering to use.  CrystalEyes
		/// mode uses frame-sequential capabilities available in OpenGL
		/// to drive LCD shutter glasses and stereo projectors.  RedBlue
		/// mode is a simple type of stereo for use with red-blue glasses.
		/// Anaglyph mode is a superset of RedBlue mode, but the color
		/// output channels can be configured using the AnaglyphColorMask
		/// and the color of the original image can be (somewhat) maintained
		/// using AnaglyphColorSaturation;  the default colors for Anaglyph
		/// mode is red-cyan.  Interlaced stereo mode produces a composite
		/// image where horizontal lines alternate between left and right
		/// views.  StereoLeft and StereoRight modes choose one or the other
		/// stereo view.  Dresden mode is yet another stereoscopic
		/// interleaving. Fake simply causes the window to render twice without
		/// actually swapping the camera from left eye to right eye. This is useful in
		/// certain applications that want to emulate the rendering passes without
		/// actually rendering in stereo mode. Emulate is similar to Fake, except that
		/// it does render left and right eye. There is no compositing of the resulting
		/// images from the two eyes at the end of each render in this mode, hence the
		/// result onscreen will be the right eye.
		/// </summary>
		// Token: 0x06001D62 RID: 7522 RVA: 0x0002DEB3 File Offset: 0x0002C0B3
		public void SetStereoType(int arg0)
		{
			vtkRenderWindow.vtkRenderWindow_SetStereoType_131(base.GetCppThis(), arg0);
		}

		// Token: 0x06001D63 RID: 7523
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_SetStereoTypeToAnaglyph_132(HandleRef pThis);

		/// <summary>
		/// Set/Get what type of stereo rendering to use.  CrystalEyes
		/// mode uses frame-sequential capabilities available in OpenGL
		/// to drive LCD shutter glasses and stereo projectors.  RedBlue
		/// mode is a simple type of stereo for use with red-blue glasses.
		/// Anaglyph mode is a superset of RedBlue mode, but the color
		/// output channels can be configured using the AnaglyphColorMask
		/// and the color of the original image can be (somewhat) maintained
		/// using AnaglyphColorSaturation;  the default colors for Anaglyph
		/// mode is red-cyan.  Interlaced stereo mode produces a composite
		/// image where horizontal lines alternate between left and right
		/// views.  StereoLeft and StereoRight modes choose one or the other
		/// stereo view.  Dresden mode is yet another stereoscopic
		/// interleaving. Fake simply causes the window to render twice without
		/// actually swapping the camera from left eye to right eye. This is useful in
		/// certain applications that want to emulate the rendering passes without
		/// actually rendering in stereo mode. Emulate is similar to Fake, except that
		/// it does render left and right eye. There is no compositing of the resulting
		/// images from the two eyes at the end of each render in this mode, hence the
		/// result onscreen will be the right eye.
		/// </summary>
		// Token: 0x06001D64 RID: 7524 RVA: 0x0002DEC3 File Offset: 0x0002C0C3
		public void SetStereoTypeToAnaglyph()
		{
			vtkRenderWindow.vtkRenderWindow_SetStereoTypeToAnaglyph_132(base.GetCppThis());
		}

		// Token: 0x06001D65 RID: 7525
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_SetStereoTypeToCheckerboard_133(HandleRef pThis);

		/// <summary>
		/// Set/Get what type of stereo rendering to use.  CrystalEyes
		/// mode uses frame-sequential capabilities available in OpenGL
		/// to drive LCD shutter glasses and stereo projectors.  RedBlue
		/// mode is a simple type of stereo for use with red-blue glasses.
		/// Anaglyph mode is a superset of RedBlue mode, but the color
		/// output channels can be configured using the AnaglyphColorMask
		/// and the color of the original image can be (somewhat) maintained
		/// using AnaglyphColorSaturation;  the default colors for Anaglyph
		/// mode is red-cyan.  Interlaced stereo mode produces a composite
		/// image where horizontal lines alternate between left and right
		/// views.  StereoLeft and StereoRight modes choose one or the other
		/// stereo view.  Dresden mode is yet another stereoscopic
		/// interleaving. Fake simply causes the window to render twice without
		/// actually swapping the camera from left eye to right eye. This is useful in
		/// certain applications that want to emulate the rendering passes without
		/// actually rendering in stereo mode. Emulate is similar to Fake, except that
		/// it does render left and right eye. There is no compositing of the resulting
		/// images from the two eyes at the end of each render in this mode, hence the
		/// result onscreen will be the right eye.
		/// </summary>
		// Token: 0x06001D66 RID: 7526 RVA: 0x0002DED2 File Offset: 0x0002C0D2
		public void SetStereoTypeToCheckerboard()
		{
			vtkRenderWindow.vtkRenderWindow_SetStereoTypeToCheckerboard_133(base.GetCppThis());
		}

		// Token: 0x06001D67 RID: 7527
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_SetStereoTypeToCrystalEyes_134(HandleRef pThis);

		/// <summary>
		/// Set/Get what type of stereo rendering to use.  CrystalEyes
		/// mode uses frame-sequential capabilities available in OpenGL
		/// to drive LCD shutter glasses and stereo projectors.  RedBlue
		/// mode is a simple type of stereo for use with red-blue glasses.
		/// Anaglyph mode is a superset of RedBlue mode, but the color
		/// output channels can be configured using the AnaglyphColorMask
		/// and the color of the original image can be (somewhat) maintained
		/// using AnaglyphColorSaturation;  the default colors for Anaglyph
		/// mode is red-cyan.  Interlaced stereo mode produces a composite
		/// image where horizontal lines alternate between left and right
		/// views.  StereoLeft and StereoRight modes choose one or the other
		/// stereo view.  Dresden mode is yet another stereoscopic
		/// interleaving. Fake simply causes the window to render twice without
		/// actually swapping the camera from left eye to right eye. This is useful in
		/// certain applications that want to emulate the rendering passes without
		/// actually rendering in stereo mode. Emulate is similar to Fake, except that
		/// it does render left and right eye. There is no compositing of the resulting
		/// images from the two eyes at the end of each render in this mode, hence the
		/// result onscreen will be the right eye.
		/// </summary>
		// Token: 0x06001D68 RID: 7528 RVA: 0x0002DEE1 File Offset: 0x0002C0E1
		public void SetStereoTypeToCrystalEyes()
		{
			vtkRenderWindow.vtkRenderWindow_SetStereoTypeToCrystalEyes_134(base.GetCppThis());
		}

		// Token: 0x06001D69 RID: 7529
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_SetStereoTypeToDresden_135(HandleRef pThis);

		/// <summary>
		/// Set/Get what type of stereo rendering to use.  CrystalEyes
		/// mode uses frame-sequential capabilities available in OpenGL
		/// to drive LCD shutter glasses and stereo projectors.  RedBlue
		/// mode is a simple type of stereo for use with red-blue glasses.
		/// Anaglyph mode is a superset of RedBlue mode, but the color
		/// output channels can be configured using the AnaglyphColorMask
		/// and the color of the original image can be (somewhat) maintained
		/// using AnaglyphColorSaturation;  the default colors for Anaglyph
		/// mode is red-cyan.  Interlaced stereo mode produces a composite
		/// image where horizontal lines alternate between left and right
		/// views.  StereoLeft and StereoRight modes choose one or the other
		/// stereo view.  Dresden mode is yet another stereoscopic
		/// interleaving. Fake simply causes the window to render twice without
		/// actually swapping the camera from left eye to right eye. This is useful in
		/// certain applications that want to emulate the rendering passes without
		/// actually rendering in stereo mode. Emulate is similar to Fake, except that
		/// it does render left and right eye. There is no compositing of the resulting
		/// images from the two eyes at the end of each render in this mode, hence the
		/// result onscreen will be the right eye.
		/// </summary>
		// Token: 0x06001D6A RID: 7530 RVA: 0x0002DEF0 File Offset: 0x0002C0F0
		public void SetStereoTypeToDresden()
		{
			vtkRenderWindow.vtkRenderWindow_SetStereoTypeToDresden_135(base.GetCppThis());
		}

		// Token: 0x06001D6B RID: 7531
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_SetStereoTypeToEmulate_136(HandleRef pThis);

		/// <summary>
		/// Set/Get what type of stereo rendering to use.  CrystalEyes
		/// mode uses frame-sequential capabilities available in OpenGL
		/// to drive LCD shutter glasses and stereo projectors.  RedBlue
		/// mode is a simple type of stereo for use with red-blue glasses.
		/// Anaglyph mode is a superset of RedBlue mode, but the color
		/// output channels can be configured using the AnaglyphColorMask
		/// and the color of the original image can be (somewhat) maintained
		/// using AnaglyphColorSaturation;  the default colors for Anaglyph
		/// mode is red-cyan.  Interlaced stereo mode produces a composite
		/// image where horizontal lines alternate between left and right
		/// views.  StereoLeft and StereoRight modes choose one or the other
		/// stereo view.  Dresden mode is yet another stereoscopic
		/// interleaving. Fake simply causes the window to render twice without
		/// actually swapping the camera from left eye to right eye. This is useful in
		/// certain applications that want to emulate the rendering passes without
		/// actually rendering in stereo mode. Emulate is similar to Fake, except that
		/// it does render left and right eye. There is no compositing of the resulting
		/// images from the two eyes at the end of each render in this mode, hence the
		/// result onscreen will be the right eye.
		/// </summary>
		// Token: 0x06001D6C RID: 7532 RVA: 0x0002DEFF File Offset: 0x0002C0FF
		public void SetStereoTypeToEmulate()
		{
			vtkRenderWindow.vtkRenderWindow_SetStereoTypeToEmulate_136(base.GetCppThis());
		}

		// Token: 0x06001D6D RID: 7533
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_SetStereoTypeToFake_137(HandleRef pThis);

		/// <summary>
		/// Set/Get what type of stereo rendering to use.  CrystalEyes
		/// mode uses frame-sequential capabilities available in OpenGL
		/// to drive LCD shutter glasses and stereo projectors.  RedBlue
		/// mode is a simple type of stereo for use with red-blue glasses.
		/// Anaglyph mode is a superset of RedBlue mode, but the color
		/// output channels can be configured using the AnaglyphColorMask
		/// and the color of the original image can be (somewhat) maintained
		/// using AnaglyphColorSaturation;  the default colors for Anaglyph
		/// mode is red-cyan.  Interlaced stereo mode produces a composite
		/// image where horizontal lines alternate between left and right
		/// views.  StereoLeft and StereoRight modes choose one or the other
		/// stereo view.  Dresden mode is yet another stereoscopic
		/// interleaving. Fake simply causes the window to render twice without
		/// actually swapping the camera from left eye to right eye. This is useful in
		/// certain applications that want to emulate the rendering passes without
		/// actually rendering in stereo mode. Emulate is similar to Fake, except that
		/// it does render left and right eye. There is no compositing of the resulting
		/// images from the two eyes at the end of each render in this mode, hence the
		/// result onscreen will be the right eye.
		/// </summary>
		// Token: 0x06001D6E RID: 7534 RVA: 0x0002DF0E File Offset: 0x0002C10E
		public void SetStereoTypeToFake()
		{
			vtkRenderWindow.vtkRenderWindow_SetStereoTypeToFake_137(base.GetCppThis());
		}

		// Token: 0x06001D6F RID: 7535
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_SetStereoTypeToInterlaced_138(HandleRef pThis);

		/// <summary>
		/// Set/Get what type of stereo rendering to use.  CrystalEyes
		/// mode uses frame-sequential capabilities available in OpenGL
		/// to drive LCD shutter glasses and stereo projectors.  RedBlue
		/// mode is a simple type of stereo for use with red-blue glasses.
		/// Anaglyph mode is a superset of RedBlue mode, but the color
		/// output channels can be configured using the AnaglyphColorMask
		/// and the color of the original image can be (somewhat) maintained
		/// using AnaglyphColorSaturation;  the default colors for Anaglyph
		/// mode is red-cyan.  Interlaced stereo mode produces a composite
		/// image where horizontal lines alternate between left and right
		/// views.  StereoLeft and StereoRight modes choose one or the other
		/// stereo view.  Dresden mode is yet another stereoscopic
		/// interleaving. Fake simply causes the window to render twice without
		/// actually swapping the camera from left eye to right eye. This is useful in
		/// certain applications that want to emulate the rendering passes without
		/// actually rendering in stereo mode. Emulate is similar to Fake, except that
		/// it does render left and right eye. There is no compositing of the resulting
		/// images from the two eyes at the end of each render in this mode, hence the
		/// result onscreen will be the right eye.
		/// </summary>
		// Token: 0x06001D70 RID: 7536 RVA: 0x0002DF1D File Offset: 0x0002C11D
		public void SetStereoTypeToInterlaced()
		{
			vtkRenderWindow.vtkRenderWindow_SetStereoTypeToInterlaced_138(base.GetCppThis());
		}

		// Token: 0x06001D71 RID: 7537
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_SetStereoTypeToLeft_139(HandleRef pThis);

		/// <summary>
		/// Set/Get what type of stereo rendering to use.  CrystalEyes
		/// mode uses frame-sequential capabilities available in OpenGL
		/// to drive LCD shutter glasses and stereo projectors.  RedBlue
		/// mode is a simple type of stereo for use with red-blue glasses.
		/// Anaglyph mode is a superset of RedBlue mode, but the color
		/// output channels can be configured using the AnaglyphColorMask
		/// and the color of the original image can be (somewhat) maintained
		/// using AnaglyphColorSaturation;  the default colors for Anaglyph
		/// mode is red-cyan.  Interlaced stereo mode produces a composite
		/// image where horizontal lines alternate between left and right
		/// views.  StereoLeft and StereoRight modes choose one or the other
		/// stereo view.  Dresden mode is yet another stereoscopic
		/// interleaving. Fake simply causes the window to render twice without
		/// actually swapping the camera from left eye to right eye. This is useful in
		/// certain applications that want to emulate the rendering passes without
		/// actually rendering in stereo mode. Emulate is similar to Fake, except that
		/// it does render left and right eye. There is no compositing of the resulting
		/// images from the two eyes at the end of each render in this mode, hence the
		/// result onscreen will be the right eye.
		/// </summary>
		// Token: 0x06001D72 RID: 7538 RVA: 0x0002DF2C File Offset: 0x0002C12C
		public void SetStereoTypeToLeft()
		{
			vtkRenderWindow.vtkRenderWindow_SetStereoTypeToLeft_139(base.GetCppThis());
		}

		// Token: 0x06001D73 RID: 7539
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_SetStereoTypeToRedBlue_140(HandleRef pThis);

		/// <summary>
		/// Set/Get what type of stereo rendering to use.  CrystalEyes
		/// mode uses frame-sequential capabilities available in OpenGL
		/// to drive LCD shutter glasses and stereo projectors.  RedBlue
		/// mode is a simple type of stereo for use with red-blue glasses.
		/// Anaglyph mode is a superset of RedBlue mode, but the color
		/// output channels can be configured using the AnaglyphColorMask
		/// and the color of the original image can be (somewhat) maintained
		/// using AnaglyphColorSaturation;  the default colors for Anaglyph
		/// mode is red-cyan.  Interlaced stereo mode produces a composite
		/// image where horizontal lines alternate between left and right
		/// views.  StereoLeft and StereoRight modes choose one or the other
		/// stereo view.  Dresden mode is yet another stereoscopic
		/// interleaving. Fake simply causes the window to render twice without
		/// actually swapping the camera from left eye to right eye. This is useful in
		/// certain applications that want to emulate the rendering passes without
		/// actually rendering in stereo mode. Emulate is similar to Fake, except that
		/// it does render left and right eye. There is no compositing of the resulting
		/// images from the two eyes at the end of each render in this mode, hence the
		/// result onscreen will be the right eye.
		/// </summary>
		// Token: 0x06001D74 RID: 7540 RVA: 0x0002DF3B File Offset: 0x0002C13B
		public void SetStereoTypeToRedBlue()
		{
			vtkRenderWindow.vtkRenderWindow_SetStereoTypeToRedBlue_140(base.GetCppThis());
		}

		// Token: 0x06001D75 RID: 7541
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_SetStereoTypeToRight_141(HandleRef pThis);

		/// <summary>
		/// Set/Get what type of stereo rendering to use.  CrystalEyes
		/// mode uses frame-sequential capabilities available in OpenGL
		/// to drive LCD shutter glasses and stereo projectors.  RedBlue
		/// mode is a simple type of stereo for use with red-blue glasses.
		/// Anaglyph mode is a superset of RedBlue mode, but the color
		/// output channels can be configured using the AnaglyphColorMask
		/// and the color of the original image can be (somewhat) maintained
		/// using AnaglyphColorSaturation;  the default colors for Anaglyph
		/// mode is red-cyan.  Interlaced stereo mode produces a composite
		/// image where horizontal lines alternate between left and right
		/// views.  StereoLeft and StereoRight modes choose one or the other
		/// stereo view.  Dresden mode is yet another stereoscopic
		/// interleaving. Fake simply causes the window to render twice without
		/// actually swapping the camera from left eye to right eye. This is useful in
		/// certain applications that want to emulate the rendering passes without
		/// actually rendering in stereo mode. Emulate is similar to Fake, except that
		/// it does render left and right eye. There is no compositing of the resulting
		/// images from the two eyes at the end of each render in this mode, hence the
		/// result onscreen will be the right eye.
		/// </summary>
		// Token: 0x06001D76 RID: 7542 RVA: 0x0002DF4A File Offset: 0x0002C14A
		public void SetStereoTypeToRight()
		{
			vtkRenderWindow.vtkRenderWindow_SetStereoTypeToRight_141(base.GetCppThis());
		}

		// Token: 0x06001D77 RID: 7543
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_SetStereoTypeToSplitViewportHorizontal_142(HandleRef pThis);

		/// <summary>
		/// Set/Get what type of stereo rendering to use.  CrystalEyes
		/// mode uses frame-sequential capabilities available in OpenGL
		/// to drive LCD shutter glasses and stereo projectors.  RedBlue
		/// mode is a simple type of stereo for use with red-blue glasses.
		/// Anaglyph mode is a superset of RedBlue mode, but the color
		/// output channels can be configured using the AnaglyphColorMask
		/// and the color of the original image can be (somewhat) maintained
		/// using AnaglyphColorSaturation;  the default colors for Anaglyph
		/// mode is red-cyan.  Interlaced stereo mode produces a composite
		/// image where horizontal lines alternate between left and right
		/// views.  StereoLeft and StereoRight modes choose one or the other
		/// stereo view.  Dresden mode is yet another stereoscopic
		/// interleaving. Fake simply causes the window to render twice without
		/// actually swapping the camera from left eye to right eye. This is useful in
		/// certain applications that want to emulate the rendering passes without
		/// actually rendering in stereo mode. Emulate is similar to Fake, except that
		/// it does render left and right eye. There is no compositing of the resulting
		/// images from the two eyes at the end of each render in this mode, hence the
		/// result onscreen will be the right eye.
		/// </summary>
		// Token: 0x06001D78 RID: 7544 RVA: 0x0002DF59 File Offset: 0x0002C159
		public void SetStereoTypeToSplitViewportHorizontal()
		{
			vtkRenderWindow.vtkRenderWindow_SetStereoTypeToSplitViewportHorizontal_142(base.GetCppThis());
		}

		// Token: 0x06001D79 RID: 7545
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_SetSwapBuffers_143(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off buffer swapping between images.
		/// </summary>
		// Token: 0x06001D7A RID: 7546 RVA: 0x0002DF68 File Offset: 0x0002C168
		public virtual void SetSwapBuffers(int _arg)
		{
			vtkRenderWindow.vtkRenderWindow_SetSwapBuffers_143(base.GetCppThis(), _arg);
		}

		// Token: 0x06001D7B RID: 7547
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_SetUseSRGBColorSpace_144(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get if we want this window to use the sRGB color space.
		/// Some hardware/drivers do not fully support this.
		/// </summary>
		// Token: 0x06001D7C RID: 7548 RVA: 0x0002DF78 File Offset: 0x0002C178
		public virtual void SetUseSRGBColorSpace(bool _arg)
		{
			vtkRenderWindow.vtkRenderWindow_SetUseSRGBColorSpace_144(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06001D7D RID: 7549
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_SetWindowId_145(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// Dummy stubs for vtkWindow API.
		/// </summary>
		// Token: 0x06001D7E RID: 7550 RVA: 0x0002DF90 File Offset: 0x0002C190
		public override void SetWindowId(IntPtr arg0)
		{
			vtkRenderWindow.vtkRenderWindow_SetWindowId_145(base.GetCppThis(), arg0);
		}

		// Token: 0x06001D7F RID: 7551
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_SetWindowInfo_146(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Dummy stubs for vtkWindow API.
		/// </summary>
		// Token: 0x06001D80 RID: 7552 RVA: 0x0002DFA0 File Offset: 0x0002C1A0
		public override void SetWindowInfo(string arg0)
		{
			vtkRenderWindow.vtkRenderWindow_SetWindowInfo_146(base.GetCppThis(), arg0);
		}

		// Token: 0x06001D81 RID: 7553
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindow_SetZbufferData_147(HandleRef pThis, int arg0, int arg1, int arg2, int arg3, IntPtr arg4);

		/// <summary>
		/// Set/Get the zbuffer data from the frame buffer.
		/// (x,y) is any corner of the rectangle. (x2,y2) is its opposite corner on
		/// the diagonal.
		/// </summary>
		// Token: 0x06001D82 RID: 7554 RVA: 0x0002DFB0 File Offset: 0x0002C1B0
		public virtual int SetZbufferData(int arg0, int arg1, int arg2, int arg3, IntPtr arg4)
		{
			return vtkRenderWindow.vtkRenderWindow_SetZbufferData_147(base.GetCppThis(), arg0, arg1, arg2, arg3, arg4);
		}

		// Token: 0x06001D83 RID: 7555
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindow_SetZbufferData_148(HandleRef pThis, int arg0, int arg1, int arg2, int arg3, HandleRef arg4);

		/// <summary>
		/// Set/Get the zbuffer data from the frame buffer.
		/// (x,y) is any corner of the rectangle. (x2,y2) is its opposite corner on
		/// the diagonal.
		/// </summary>
		// Token: 0x06001D84 RID: 7556 RVA: 0x0002DFD8 File Offset: 0x0002C1D8
		public virtual int SetZbufferData(int arg0, int arg1, int arg2, int arg3, vtkFloatArray arg4)
		{
			return vtkRenderWindow.vtkRenderWindow_SetZbufferData_148(base.GetCppThis(), arg0, arg1, arg2, arg3, (arg4 == null) ? default(HandleRef) : arg4.GetCppThis());
		}

		// Token: 0x06001D85 RID: 7557
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_ShowCursor_149(HandleRef pThis);

		/// <summary>
		/// Hide or Show the mouse cursor, it is nice to be able to hide the
		/// default cursor if you want VTK to display a 3D cursor instead.
		/// Set cursor position in window (note that (0,0) is the lower left
		/// corner).
		/// </summary>
		// Token: 0x06001D86 RID: 7558 RVA: 0x0002E013 File Offset: 0x0002C213
		public virtual void ShowCursor()
		{
			vtkRenderWindow.vtkRenderWindow_ShowCursor_149(base.GetCppThis());
		}

		// Token: 0x06001D87 RID: 7559
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_Start_150(HandleRef pThis);

		/// <summary>
		/// Start the rendering process for a frame
		/// </summary>
		// Token: 0x06001D88 RID: 7560 RVA: 0x0002E022 File Offset: 0x0002C222
		public virtual void Start()
		{
			vtkRenderWindow.vtkRenderWindow_Start_150(base.GetCppThis());
		}

		// Token: 0x06001D89 RID: 7561
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_StencilCapableOff_151(HandleRef pThis);

		/// <summary>
		/// Set / Get the availability of the stencil buffer.
		/// </summary>
		// Token: 0x06001D8A RID: 7562 RVA: 0x0002E031 File Offset: 0x0002C231
		public virtual void StencilCapableOff()
		{
			vtkRenderWindow.vtkRenderWindow_StencilCapableOff_151(base.GetCppThis());
		}

		// Token: 0x06001D8B RID: 7563
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_StencilCapableOn_152(HandleRef pThis);

		/// <summary>
		/// Set / Get the availability of the stencil buffer.
		/// </summary>
		// Token: 0x06001D8C RID: 7564 RVA: 0x0002E040 File Offset: 0x0002C240
		public virtual void StencilCapableOn()
		{
			vtkRenderWindow.vtkRenderWindow_StencilCapableOn_152(base.GetCppThis());
		}

		// Token: 0x06001D8D RID: 7565
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_StereoCapableWindowOff_153(HandleRef pThis);

		/// <summary>
		/// Prescribe that the window be created in a stereo-capable mode. This
		/// method must be called before the window is realized. Default is off.
		/// </summary>
		// Token: 0x06001D8E RID: 7566 RVA: 0x0002E04F File Offset: 0x0002C24F
		public virtual void StereoCapableWindowOff()
		{
			vtkRenderWindow.vtkRenderWindow_StereoCapableWindowOff_153(base.GetCppThis());
		}

		// Token: 0x06001D8F RID: 7567
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_StereoCapableWindowOn_154(HandleRef pThis);

		/// <summary>
		/// Prescribe that the window be created in a stereo-capable mode. This
		/// method must be called before the window is realized. Default is off.
		/// </summary>
		// Token: 0x06001D90 RID: 7568 RVA: 0x0002E05E File Offset: 0x0002C25E
		public virtual void StereoCapableWindowOn()
		{
			vtkRenderWindow.vtkRenderWindow_StereoCapableWindowOn_154(base.GetCppThis());
		}

		// Token: 0x06001D91 RID: 7569
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_StereoMidpoint_155(HandleRef pThis);

		/// <summary>
		/// Intermediate method performs operations required between the rendering
		/// of the left and right eye.
		/// </summary>
		// Token: 0x06001D92 RID: 7570 RVA: 0x0002E06D File Offset: 0x0002C26D
		public virtual void StereoMidpoint()
		{
			vtkRenderWindow.vtkRenderWindow_StereoMidpoint_155(base.GetCppThis());
		}

		// Token: 0x06001D93 RID: 7571
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_StereoRenderComplete_156(HandleRef pThis);

		/// <summary>
		/// Handles work required once both views have been rendered when using
		/// stereo rendering.
		/// </summary>
		// Token: 0x06001D94 RID: 7572 RVA: 0x0002E07C File Offset: 0x0002C27C
		public virtual void StereoRenderComplete()
		{
			vtkRenderWindow.vtkRenderWindow_StereoRenderComplete_156(base.GetCppThis());
		}

		// Token: 0x06001D95 RID: 7573
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_StereoRenderOff_157(HandleRef pThis);

		/// <summary>
		/// Turn on/off stereo rendering.
		/// </summary>
		// Token: 0x06001D96 RID: 7574 RVA: 0x0002E08B File Offset: 0x0002C28B
		public virtual void StereoRenderOff()
		{
			vtkRenderWindow.vtkRenderWindow_StereoRenderOff_157(base.GetCppThis());
		}

		// Token: 0x06001D97 RID: 7575
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_StereoRenderOn_158(HandleRef pThis);

		/// <summary>
		/// Turn on/off stereo rendering.
		/// </summary>
		// Token: 0x06001D98 RID: 7576 RVA: 0x0002E09A File Offset: 0x0002C29A
		public virtual void StereoRenderOn()
		{
			vtkRenderWindow.vtkRenderWindow_StereoRenderOn_158(base.GetCppThis());
		}

		// Token: 0x06001D99 RID: 7577
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_StereoUpdate_159(HandleRef pThis);

		/// <summary>
		/// Update the system, if needed, due to stereo rendering. For some stereo
		/// methods, subclasses might need to switch some hardware settings here.
		/// </summary>
		// Token: 0x06001D9A RID: 7578 RVA: 0x0002E0A9 File Offset: 0x0002C2A9
		public virtual void StereoUpdate()
		{
			vtkRenderWindow.vtkRenderWindow_StereoUpdate_159(base.GetCppThis());
		}

		// Token: 0x06001D9B RID: 7579
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindow_SupportsOpenGL_160(HandleRef pThis);

		/// <summary>
		/// Does this render window support OpenGL? 0-false, 1-true
		/// </summary>
		// Token: 0x06001D9C RID: 7580 RVA: 0x0002E0B8 File Offset: 0x0002C2B8
		public virtual int SupportsOpenGL()
		{
			return vtkRenderWindow.vtkRenderWindow_SupportsOpenGL_160(base.GetCppThis());
		}

		// Token: 0x06001D9D RID: 7581
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_SwapBuffersOff_161(HandleRef pThis);

		/// <summary>
		/// Turn on/off buffer swapping between images.
		/// </summary>
		// Token: 0x06001D9E RID: 7582 RVA: 0x0002E0D7 File Offset: 0x0002C2D7
		public virtual void SwapBuffersOff()
		{
			vtkRenderWindow.vtkRenderWindow_SwapBuffersOff_161(base.GetCppThis());
		}

		// Token: 0x06001D9F RID: 7583
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_SwapBuffersOn_162(HandleRef pThis);

		/// <summary>
		/// Turn on/off buffer swapping between images.
		/// </summary>
		// Token: 0x06001DA0 RID: 7584 RVA: 0x0002E0E6 File Offset: 0x0002C2E6
		public virtual void SwapBuffersOn()
		{
			vtkRenderWindow.vtkRenderWindow_SwapBuffersOn_162(base.GetCppThis());
		}

		// Token: 0x06001DA1 RID: 7585
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_UseSRGBColorSpaceOff_164(HandleRef pThis);

		/// <summary>
		/// Set/Get if we want this window to use the sRGB color space.
		/// Some hardware/drivers do not fully support this.
		/// </summary>
		// Token: 0x06001DA2 RID: 7586 RVA: 0x0002E0F5 File Offset: 0x0002C2F5
		public virtual void UseSRGBColorSpaceOff()
		{
			vtkRenderWindow.vtkRenderWindow_UseSRGBColorSpaceOff_164(base.GetCppThis());
		}

		// Token: 0x06001DA3 RID: 7587
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_UseSRGBColorSpaceOn_165(HandleRef pThis);

		/// <summary>
		/// Set/Get if we want this window to use the sRGB color space.
		/// Some hardware/drivers do not fully support this.
		/// </summary>
		// Token: 0x06001DA4 RID: 7588 RVA: 0x0002E104 File Offset: 0x0002C304
		public virtual void UseSRGBColorSpaceOn()
		{
			vtkRenderWindow.vtkRenderWindow_UseSRGBColorSpaceOn_165(base.GetCppThis());
		}

		// Token: 0x06001DA5 RID: 7589
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_WaitForCompletion_166(HandleRef pThis);

		/// <summary>
		/// Block the thread until the actual rendering is finished().
		/// Useful for measurement only.
		/// </summary>
		// Token: 0x06001DA6 RID: 7590 RVA: 0x0002E113 File Offset: 0x0002C313
		public virtual void WaitForCompletion()
		{
			vtkRenderWindow.vtkRenderWindow_WaitForCompletion_166(base.GetCppThis());
		}

		// Token: 0x06001DA7 RID: 7591
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindow_WindowRemap_167(HandleRef pThis);

		/// <summary>
		/// Remap the rendering window. This probably only works on UNIX right now.
		/// It is useful for changing properties that can't normally be changed
		/// once the window is up.
		/// </summary>
		// Token: 0x06001DA8 RID: 7592 RVA: 0x0002E122 File Offset: 0x0002C322
		public virtual void WindowRemap()
		{
			vtkRenderWindow.vtkRenderWindow_WindowRemap_167(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040004FF RID: 1279
		public new const string MRFullTypeName = "Kitware.VTK.vtkRenderWindow";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000500 RID: 1280
		public new static readonly string MRClassNameKey = "class vtkRenderWindow";
	}
}
