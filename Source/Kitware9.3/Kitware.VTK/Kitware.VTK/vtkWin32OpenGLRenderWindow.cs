using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkWin32OpenGL2RenderWindow
	/// </summary>
	/// <remarks>
	///    OpenGL rendering window
	///
	/// vtkWin32OpenGL2RenderWindow is a concrete implementation of the abstract
	/// class vtkRenderWindow. vtkWin32OpenGL2Renderer interfaces to the standard
	/// OpenGL graphics library in the Windows/NT environment..
	/// </remarks>
	// Token: 0x020005F9 RID: 1529
	public class vtkWin32OpenGLRenderWindow : vtkOpenGLRenderWindow
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601094B RID: 67915 RVA: 0x001726DF File Offset: 0x001708DF
		static vtkWin32OpenGLRenderWindow()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkWin32OpenGLRenderWindow.MRClassNameKey, Type.GetType("Kitware.VTK.vtkWin32OpenGLRenderWindow"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601094C RID: 67916 RVA: 0x00172707 File Offset: 0x00170907
		public vtkWin32OpenGLRenderWindow(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601094D RID: 67917
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWin32OpenGLRenderWindow_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601094E RID: 67918 RVA: 0x00172718 File Offset: 0x00170918
		public new static vtkWin32OpenGLRenderWindow New()
		{
			vtkWin32OpenGLRenderWindow result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWin32OpenGLRenderWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601094F RID: 67919 RVA: 0x0017276C File Offset: 0x0017096C
		public vtkWin32OpenGLRenderWindow() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010950 RID: 67920 RVA: 0x001727B0 File Offset: 0x001709B0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06010951 RID: 67921
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32OpenGLRenderWindow_Clean_01(HandleRef pThis);

		/// <summary>
		/// Clean up device contexts, rendering contexts, etc.
		/// </summary>
		// Token: 0x06010952 RID: 67922 RVA: 0x001727BB File Offset: 0x001709BB
		public void Clean()
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_Clean_01(base.GetCppThis());
		}

		// Token: 0x06010953 RID: 67923
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkWin32OpenGLRenderWindow_DetectDPI_02(HandleRef pThis);

		/// <summary>
		/// Change the shape of the cursor
		/// </summary>
		// Token: 0x06010954 RID: 67924 RVA: 0x001727CC File Offset: 0x001709CC
		public override bool DetectDPI()
		{
			return vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_DetectDPI_02(base.GetCppThis()) != 0;
		}

		// Token: 0x06010955 RID: 67925
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32OpenGLRenderWindow_Finalize_03(HandleRef pThis);

		/// <summary>
		/// Finalize the rendering window.  This will shutdown all system-specific
		/// resources.  After having called this, it should be possible to destroy
		/// a window that was used for a SetWindowId() call without any ill effects.
		/// </summary>
		// Token: 0x06010956 RID: 67926 RVA: 0x001727F2 File Offset: 0x001709F2
		public override void FinalizeWrapper()
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_Finalize_03(base.GetCppThis());
		}

		// Token: 0x06010957 RID: 67927
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32OpenGLRenderWindow_Frame_04(HandleRef pThis);

		/// <summary>
		/// End the rendering process and display the image.
		/// </summary>
		// Token: 0x06010958 RID: 67928 RVA: 0x00172801 File Offset: 0x00170A01
		public override void Frame()
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_Frame_04(base.GetCppThis());
		}

		// Token: 0x06010959 RID: 67929
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWin32OpenGLRenderWindow_GetEventPending_05(HandleRef pThis);

		/// <summary>
		/// Check to see if a mouse button has been pressed or mouse wheel activated.
		/// All other events are ignored by this method.
		/// This is a useful check to abort a long render.
		/// </summary>
		// Token: 0x0601095A RID: 67930 RVA: 0x00172810 File Offset: 0x00170A10
		public override int GetEventPending()
		{
			return vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_GetEventPending_05(base.GetCppThis());
		}

		// Token: 0x0601095B RID: 67931
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWin32OpenGLRenderWindow_GetGenericContext_06(HandleRef pThis);

		/// <summary>
		/// Sets the HWND id of the window that WILL BE created.
		/// </summary>
		// Token: 0x0601095C RID: 67932 RVA: 0x00172830 File Offset: 0x00170A30
		public override IntPtr GetGenericContext()
		{
			return vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_GetGenericContext_06(base.GetCppThis());
		}

		// Token: 0x0601095D RID: 67933
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWin32OpenGLRenderWindow_GetGenericDisplayId_07(HandleRef pThis);

		/// <summary>
		/// Sets the HWND id of the window that WILL BE created.
		/// </summary>
		// Token: 0x0601095E RID: 67934 RVA: 0x00172850 File Offset: 0x00170A50
		public override IntPtr GetGenericDisplayId()
		{
			return vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_GetGenericDisplayId_07(base.GetCppThis());
		}

		// Token: 0x0601095F RID: 67935
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWin32OpenGLRenderWindow_GetGenericDrawable_08(HandleRef pThis);

		/// <summary>
		/// Sets the HWND id of the window that WILL BE created.
		/// </summary>
		// Token: 0x06010960 RID: 67936 RVA: 0x00172870 File Offset: 0x00170A70
		public override IntPtr GetGenericDrawable()
		{
			return vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_GetGenericDrawable_08(base.GetCppThis());
		}

		// Token: 0x06010961 RID: 67937
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWin32OpenGLRenderWindow_GetGenericParentId_09(HandleRef pThis);

		/// <summary>
		/// Sets the HWND id of the window that WILL BE created.
		/// </summary>
		// Token: 0x06010962 RID: 67938 RVA: 0x00172890 File Offset: 0x00170A90
		public override IntPtr GetGenericParentId()
		{
			return vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_GetGenericParentId_09(base.GetCppThis());
		}

		// Token: 0x06010963 RID: 67939
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWin32OpenGLRenderWindow_GetGenericWindowId_10(HandleRef pThis);

		/// <summary>
		/// Sets the HWND id of the window that WILL BE created.
		/// </summary>
		// Token: 0x06010964 RID: 67940 RVA: 0x001728B0 File Offset: 0x00170AB0
		public override IntPtr GetGenericWindowId()
		{
			return vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_GetGenericWindowId_10(base.GetCppThis());
		}

		// Token: 0x06010965 RID: 67941
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWin32OpenGLRenderWindow_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010966 RID: 67942 RVA: 0x001728D0 File Offset: 0x00170AD0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x06010967 RID: 67943
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWin32OpenGLRenderWindow_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010968 RID: 67944 RVA: 0x001728F0 File Offset: 0x00170AF0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x06010969 RID: 67945
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkWin32OpenGLRenderWindow_GetPlatformSupportsRenderWindowSharing_13(HandleRef pThis);

		/// <summary>
		/// Does this platform support render window data sharing.
		/// </summary>
		// Token: 0x0601096A RID: 67946 RVA: 0x0017290C File Offset: 0x00170B0C
		public override bool GetPlatformSupportsRenderWindowSharing()
		{
			return vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_GetPlatformSupportsRenderWindowSharing_13(base.GetCppThis()) != 0;
		}

		// Token: 0x0601096B RID: 67947
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWin32OpenGLRenderWindow_GetPosition_14(HandleRef pThis);

		/// <summary>
		/// Get the position (x and y) of the rendering window in
		/// screen coordinates (in pixels).
		/// </summary>
		// Token: 0x0601096C RID: 67948 RVA: 0x00172934 File Offset: 0x00170B34
		public override int[] GetPosition()
		{
			IntPtr intPtr = vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_GetPosition_14(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601096D RID: 67949
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWin32OpenGLRenderWindow_GetScreenSize_15(HandleRef pThis);

		/// <summary>
		/// Get the current size of the screen in pixels.
		/// An HDTV for example would be 1920 x 1080 pixels.
		/// </summary>
		// Token: 0x0601096E RID: 67950 RVA: 0x0017297C File Offset: 0x00170B7C
		public override int[] GetScreenSize()
		{
			IntPtr intPtr = vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_GetScreenSize_15(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601096F RID: 67951
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWin32OpenGLRenderWindow_GetSize_16(HandleRef pThis);

		/// <summary>
		/// Get the size (width and height) of the rendering window in
		/// screen coordinates (in pixels).
		/// </summary>
		// Token: 0x06010970 RID: 67952 RVA: 0x001729C4 File Offset: 0x00170BC4
		public override int[] GetSize()
		{
			IntPtr intPtr = vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_GetSize_16(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06010971 RID: 67953
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32OpenGLRenderWindow_HideCursor_17(HandleRef pThis);

		/// <summary>
		/// Hide or Show the mouse cursor, it is nice to be able to hide the
		/// default cursor if you want VTK to display a 3D cursor instead.
		/// Set cursor position in window (note that (0,0) is the lower left
		/// corner).
		/// </summary>
		// Token: 0x06010972 RID: 67954 RVA: 0x00172A0C File Offset: 0x00170C0C
		public override void HideCursor()
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_HideCursor_17(base.GetCppThis());
		}

		// Token: 0x06010973 RID: 67955
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32OpenGLRenderWindow_Initialize_18(HandleRef pThis);

		/// <summary>
		/// Initialize the rendering window.  This will setup all system-specific
		/// resources.  This method and Finalize() must be symmetric and it
		/// should be possible to call them multiple times, even changing WindowId
		/// in-between.  This is what WindowRemap does.
		/// </summary>
		// Token: 0x06010974 RID: 67956 RVA: 0x00172A1B File Offset: 0x00170C1B
		public override void Initialize()
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_Initialize_18(base.GetCppThis());
		}

		// Token: 0x06010975 RID: 67957
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkWin32OpenGLRenderWindow_InitializeFromCurrentContext_19(HandleRef pThis);

		/// <summary>
		/// Initialize the render window from the information associated
		/// with the currently activated OpenGL context.
		/// </summary>
		// Token: 0x06010976 RID: 67958 RVA: 0x00172A2C File Offset: 0x00170C2C
		public override bool InitializeFromCurrentContext()
		{
			return vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_InitializeFromCurrentContext_19(base.GetCppThis()) != 0;
		}

		// Token: 0x06010977 RID: 67959
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWin32OpenGLRenderWindow_IsA_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010978 RID: 67960 RVA: 0x00172A54 File Offset: 0x00170C54
		public override int IsA(string type)
		{
			return vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_IsA_20(base.GetCppThis(), type);
		}

		// Token: 0x06010979 RID: 67961
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkWin32OpenGLRenderWindow_IsCurrent_21(HandleRef pThis);

		/// <summary>
		/// Tells if this window is the current OpenGL context for the calling thread.
		/// </summary>
		// Token: 0x0601097A RID: 67962 RVA: 0x00172A74 File Offset: 0x00170C74
		public override bool IsCurrent()
		{
			return vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_IsCurrent_21(base.GetCppThis()) != 0;
		}

		// Token: 0x0601097B RID: 67963
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWin32OpenGLRenderWindow_IsDirect_22(HandleRef pThis);

		/// <summary>
		/// Is this render window using hardware acceleration? 0-false, 1-true
		/// </summary>
		// Token: 0x0601097C RID: 67964 RVA: 0x00172A9C File Offset: 0x00170C9C
		public override int IsDirect()
		{
			return vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_IsDirect_22(base.GetCppThis());
		}

		// Token: 0x0601097D RID: 67965
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWin32OpenGLRenderWindow_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601097E RID: 67966 RVA: 0x00172ABC File Offset: 0x00170CBC
		public new static int IsTypeOf(string type)
		{
			return vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_IsTypeOf_23(type);
		}

		// Token: 0x0601097F RID: 67967
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32OpenGLRenderWindow_MakeCurrent_24(HandleRef pThis);

		/// <summary>
		/// Make this windows OpenGL context the current context.
		/// </summary>
		// Token: 0x06010980 RID: 67968 RVA: 0x00172AD6 File Offset: 0x00170CD6
		public override void MakeCurrent()
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_MakeCurrent_24(base.GetCppThis());
		}

		// Token: 0x06010981 RID: 67969
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWin32OpenGLRenderWindow_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010982 RID: 67970 RVA: 0x00172AE8 File Offset: 0x00170CE8
		public new vtkWin32OpenGLRenderWindow NewInstance()
		{
			vtkWin32OpenGLRenderWindow result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_NewInstance_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWin32OpenGLRenderWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010983 RID: 67971
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32OpenGLRenderWindow_PopContext_27(HandleRef pThis);

		/// <summary>
		/// Ability to push and pop this window's context
		/// as the current context. The idea being to
		/// if needed make this window's context current
		/// and when done releasing resources restore
		/// the prior context
		/// </summary>
		// Token: 0x06010984 RID: 67972 RVA: 0x00172B42 File Offset: 0x00170D42
		public override void PopContext()
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_PopContext_27(base.GetCppThis());
		}

		// Token: 0x06010985 RID: 67973
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32OpenGLRenderWindow_PrefFullScreen_28(HandleRef pThis);

		/// <summary>
		/// Set the preferred window size to full screen.
		/// </summary>
		// Token: 0x06010986 RID: 67974 RVA: 0x00172B51 File Offset: 0x00170D51
		public virtual void PrefFullScreen()
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_PrefFullScreen_28(base.GetCppThis());
		}

		// Token: 0x06010987 RID: 67975
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32OpenGLRenderWindow_PushContext_29(HandleRef pThis);

		/// <summary>
		/// Ability to push and pop this window's context
		/// as the current context. The idea being to
		/// if needed make this window's context current
		/// and when done releasing resources restore
		/// the prior context
		/// </summary>
		// Token: 0x06010988 RID: 67976 RVA: 0x00172B60 File Offset: 0x00170D60
		public override void PushContext()
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_PushContext_29(base.GetCppThis());
		}

		// Token: 0x06010989 RID: 67977
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32OpenGLRenderWindow_ReleaseCurrent_30(HandleRef pThis);

		/// <summary>
		/// Release the current context.
		/// </summary>
		// Token: 0x0601098A RID: 67978 RVA: 0x00172B6F File Offset: 0x00170D6F
		public override void ReleaseCurrent()
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_ReleaseCurrent_30(base.GetCppThis());
		}

		// Token: 0x0601098B RID: 67979
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWin32OpenGLRenderWindow_ReportCapabilities_31(HandleRef pThis);

		/// <summary>
		/// Get report of capabilities for the render window
		/// </summary>
		// Token: 0x0601098C RID: 67980 RVA: 0x00172B80 File Offset: 0x00170D80
		public override string ReportCapabilities()
		{
			string s = Marshal.PtrToStringAnsi(vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_ReportCapabilities_31(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601098D RID: 67981
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWin32OpenGLRenderWindow_SafeDownCast_32(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601098E RID: 67982 RVA: 0x00172BBC File Offset: 0x00170DBC
		public new static vtkWin32OpenGLRenderWindow SafeDownCast(vtkObjectBase o)
		{
			vtkWin32OpenGLRenderWindow vtkWin32OpenGLRenderWindow = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_SafeDownCast_32((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWin32OpenGLRenderWindow = (vtkWin32OpenGLRenderWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWin32OpenGLRenderWindow.Register(null);
				}
			}
			return vtkWin32OpenGLRenderWindow;
		}

		// Token: 0x0601098F RID: 67983
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32OpenGLRenderWindow_SetCurrentCursor_33(HandleRef pThis, int arg0);

		/// <summary>
		/// Change the shape of the cursor
		/// </summary>
		// Token: 0x06010990 RID: 67984 RVA: 0x00172C3B File Offset: 0x00170E3B
		public override void SetCurrentCursor(int arg0)
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_SetCurrentCursor_33(base.GetCppThis(), arg0);
		}

		// Token: 0x06010991 RID: 67985
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32OpenGLRenderWindow_SetCursorPosition_34(HandleRef pThis, int x, int y);

		/// <summary>
		/// Hide or Show the mouse cursor, it is nice to be able to hide the
		/// default cursor if you want VTK to display a 3D cursor instead.
		/// Set cursor position in window (note that (0,0) is the lower left
		/// corner).
		/// </summary>
		// Token: 0x06010992 RID: 67986 RVA: 0x00172C4B File Offset: 0x00170E4B
		public override void SetCursorPosition(int x, int y)
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_SetCursorPosition_34(base.GetCppThis(), x, y);
		}

		// Token: 0x06010993 RID: 67987
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32OpenGLRenderWindow_SetDisplayId_35(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// Sets the HWND id of the window that WILL BE created.
		/// </summary>
		// Token: 0x06010994 RID: 67988 RVA: 0x00172C5C File Offset: 0x00170E5C
		public override void SetDisplayId(IntPtr arg0)
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_SetDisplayId_35(base.GetCppThis(), arg0);
		}

		// Token: 0x06010995 RID: 67989
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32OpenGLRenderWindow_SetFullScreen_36(HandleRef pThis, int arg0);

		/// <summary>
		/// Change the window to fill the entire screen.
		/// </summary>
		// Token: 0x06010996 RID: 67990 RVA: 0x00172C6C File Offset: 0x00170E6C
		public override void SetFullScreen(int arg0)
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_SetFullScreen_36(base.GetCppThis(), arg0);
		}

		// Token: 0x06010997 RID: 67991
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32OpenGLRenderWindow_SetIcon_37(HandleRef pThis, HandleRef img);

		/// <summary>
		/// Set the icon displayed in the title bar and the taskbar.
		/// </summary>
		// Token: 0x06010998 RID: 67992 RVA: 0x00172C7C File Offset: 0x00170E7C
		public override void SetIcon(vtkImageData img)
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_SetIcon_37(base.GetCppThis(), (img == null) ? default(HandleRef) : img.GetCppThis());
		}

		// Token: 0x06010999 RID: 67993
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32OpenGLRenderWindow_SetNextWindowId_38(HandleRef pThis, IntPtr arg);

		/// <summary>
		/// Set the window id of the new window once a WindowRemap is done.
		/// This is the generic prototype as required by the vtkRenderWindow
		/// parent.
		/// </summary>
		// Token: 0x0601099A RID: 67994 RVA: 0x00172CAB File Offset: 0x00170EAB
		public override void SetNextWindowId(IntPtr arg)
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_SetNextWindowId_38(base.GetCppThis(), arg);
		}

		// Token: 0x0601099B RID: 67995
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32OpenGLRenderWindow_SetNextWindowInfo_39(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Sets the WindowInfo that will be used after a WindowRemap.
		/// </summary>
		// Token: 0x0601099C RID: 67996 RVA: 0x00172CBB File Offset: 0x00170EBB
		public override void SetNextWindowInfo(string arg0)
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_SetNextWindowInfo_39(base.GetCppThis(), arg0);
		}

		// Token: 0x0601099D RID: 67997
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32OpenGLRenderWindow_SetParentId_40(HandleRef pThis, IntPtr foo);

		/// <summary>
		/// Set the window's parent id to a pre-existing window.
		/// </summary>
		// Token: 0x0601099E RID: 67998 RVA: 0x00172CCB File Offset: 0x00170ECB
		public override void SetParentId(IntPtr foo)
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_SetParentId_40(base.GetCppThis(), foo);
		}

		// Token: 0x0601099F RID: 67999
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32OpenGLRenderWindow_SetParentInfo_41(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Sets the HWND id of the window that WILL BE created.
		/// </summary>
		// Token: 0x060109A0 RID: 68000 RVA: 0x00172CDB File Offset: 0x00170EDB
		public override void SetParentInfo(string arg0)
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_SetParentInfo_41(base.GetCppThis(), arg0);
		}

		// Token: 0x060109A1 RID: 68001
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32OpenGLRenderWindow_SetPosition_42(HandleRef pThis, int x, int y);

		/// <summary>
		/// Set the position (x and y) of the rendering window in
		/// screen coordinates (in pixels). This resizes the operating
		/// system's view/window and redraws it.
		/// </summary>
		// Token: 0x060109A2 RID: 68002 RVA: 0x00172CEB File Offset: 0x00170EEB
		public override void SetPosition(int x, int y)
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_SetPosition_42(base.GetCppThis(), x, y);
		}

		// Token: 0x060109A3 RID: 68003
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32OpenGLRenderWindow_SetPosition_43(HandleRef pThis, IntPtr a);

		/// <summary>
		/// Set the position (x and y) of the rendering window in
		/// screen coordinates (in pixels). This resizes the operating
		/// system's view/window and redraws it.
		/// </summary>
		// Token: 0x060109A4 RID: 68004 RVA: 0x00172CFC File Offset: 0x00170EFC
		public override void SetPosition(IntPtr a)
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_SetPosition_43(base.GetCppThis(), a);
		}

		// Token: 0x060109A5 RID: 68005
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32OpenGLRenderWindow_SetShowWindow_44(HandleRef pThis, byte val);

		/// <summary>
		/// Show or not Show the window
		/// </summary>
		// Token: 0x060109A6 RID: 68006 RVA: 0x00172D0C File Offset: 0x00170F0C
		public override void SetShowWindow(bool val)
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_SetShowWindow_44(base.GetCppThis(), val ? (byte)1 : (byte)0);
		}

		// Token: 0x060109A7 RID: 68007
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32OpenGLRenderWindow_SetSize_45(HandleRef pThis, int width, int height);

		/// <summary>
		/// Set the size (width and height) of the rendering window in
		/// screen coordinates (in pixels). This resizes the operating
		/// system's view/window and redraws it.
		///
		/// If the size has changed, this method will fire
		/// vtkCommand::WindowResizeEvent.
		/// </summary>
		// Token: 0x060109A8 RID: 68008 RVA: 0x00172D24 File Offset: 0x00170F24
		public override void SetSize(int width, int height)
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_SetSize_45(base.GetCppThis(), width, height);
		}

		// Token: 0x060109A9 RID: 68009
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32OpenGLRenderWindow_SetSize_46(HandleRef pThis, IntPtr a);

		/// <summary>
		/// Set the size (width and height) of the rendering window in
		/// screen coordinates (in pixels). This resizes the operating
		/// system's view/window and redraws it.
		///
		/// If the size has changed, this method will fire
		/// vtkCommand::WindowResizeEvent.
		/// </summary>
		// Token: 0x060109AA RID: 68010 RVA: 0x00172D35 File Offset: 0x00170F35
		public override void SetSize(IntPtr a)
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_SetSize_46(base.GetCppThis(), a);
		}

		// Token: 0x060109AB RID: 68011
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32OpenGLRenderWindow_SetStereoCapableWindow_47(HandleRef pThis, int capable);

		/// <summary>
		/// Prescribe that the window be created in a stereo-capable mode. This
		/// method must be called before the window is realized. This method
		/// overrides the superclass method since this class can actually check
		/// whether the window has been realized yet.
		/// </summary>
		// Token: 0x060109AC RID: 68012 RVA: 0x00172D45 File Offset: 0x00170F45
		public override void SetStereoCapableWindow(int capable)
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_SetStereoCapableWindow_47(base.GetCppThis(), capable);
		}

		// Token: 0x060109AD RID: 68013
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkWin32OpenGLRenderWindow_SetSwapControl_48(HandleRef pThis, int i);

		/// <summary>
		/// Set the number of vertical syncs required between frames.
		/// A value of 0 means swap buffers as quickly as possible
		/// regardless of the vertical refresh. A value of 1 means swap
		/// buffers in sync with the vertical refresh to eliminate tearing.
		/// A value of -1 means use a value of 1 unless we missed a frame
		/// in which case swap immediately. Returns true if the call
		/// succeeded.
		/// </summary>
		// Token: 0x060109AE RID: 68014 RVA: 0x00172D58 File Offset: 0x00170F58
		public override bool SetSwapControl(int i)
		{
			return vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_SetSwapControl_48(base.GetCppThis(), i) != 0;
		}

		// Token: 0x060109AF RID: 68015
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32OpenGLRenderWindow_SetWindowId_49(HandleRef pThis, IntPtr foo);

		/// <summary>
		/// Set the window id to a pre-existing window.
		/// </summary>
		// Token: 0x060109B0 RID: 68016 RVA: 0x00172D7F File Offset: 0x00170F7F
		public override void SetWindowId(IntPtr foo)
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_SetWindowId_49(base.GetCppThis(), foo);
		}

		// Token: 0x060109B1 RID: 68017
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32OpenGLRenderWindow_SetWindowInfo_50(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Set this RenderWindow's window id to a pre-existing window.
		/// </summary>
		// Token: 0x060109B2 RID: 68018 RVA: 0x00172D8F File Offset: 0x00170F8F
		public override void SetWindowInfo(string arg0)
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_SetWindowInfo_50(base.GetCppThis(), arg0);
		}

		// Token: 0x060109B3 RID: 68019
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32OpenGLRenderWindow_SetWindowName_51(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Set the name of the window. This appears at the top of the window
		/// normally.
		/// </summary>
		// Token: 0x060109B4 RID: 68020 RVA: 0x00172D9F File Offset: 0x00170F9F
		public override void SetWindowName(string arg0)
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_SetWindowName_51(base.GetCppThis(), arg0);
		}

		// Token: 0x060109B5 RID: 68021
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32OpenGLRenderWindow_ShowCursor_52(HandleRef pThis);

		/// <summary>
		/// Hide or Show the mouse cursor, it is nice to be able to hide the
		/// default cursor if you want VTK to display a 3D cursor instead.
		/// Set cursor position in window (note that (0,0) is the lower left
		/// corner).
		/// </summary>
		// Token: 0x060109B6 RID: 68022 RVA: 0x00172DAF File Offset: 0x00170FAF
		public override void ShowCursor()
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_ShowCursor_52(base.GetCppThis());
		}

		// Token: 0x060109B7 RID: 68023
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32OpenGLRenderWindow_WindowInitialize_53(HandleRef pThis);

		/// <summary>
		/// Create the window
		/// </summary>
		// Token: 0x060109B8 RID: 68024 RVA: 0x00172DBE File Offset: 0x00170FBE
		public virtual void WindowInitialize()
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_WindowInitialize_53(base.GetCppThis());
		}

		// Token: 0x060109B9 RID: 68025
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32OpenGLRenderWindow_WindowRemap_54(HandleRef pThis);

		/// <summary>
		/// Remap the window.
		/// </summary>
		// Token: 0x060109BA RID: 68026 RVA: 0x00172DCD File Offset: 0x00170FCD
		public override void WindowRemap()
		{
			vtkWin32OpenGLRenderWindow.vtkWin32OpenGLRenderWindow_WindowRemap_54(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001348 RID: 4936
		public new const string MRFullTypeName = "Kitware.VTK.vtkWin32OpenGLRenderWindow";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001349 RID: 4937
		public new static readonly string MRClassNameKey = "class vtkWin32OpenGLRenderWindow";
	}
}
