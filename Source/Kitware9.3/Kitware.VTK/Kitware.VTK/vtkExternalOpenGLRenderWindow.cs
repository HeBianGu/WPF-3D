using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExternalOpenGLRenderWindow
	/// </summary>
	/// <remarks>
	///    OpenGL render window that allows using
	/// an external window to render vtk objects
	///
	/// vtkExternalOpenGLRenderWindow is a concrete implementation of the abstract
	/// class vtkRenderWindow. vtkExternalOpenGLRenderer interfaces to the OpenGL
	/// graphics library.
	///
	/// This class extends vtkGenericOpenGLRenderWindow to allow sharing the
	/// same OpenGL context by various visualization applications. Basically, this
	/// class prevents VTK from creating a new OpenGL context. Thus, it requires that
	/// an OpenGL context be initialized before Render is called.
	/// \sa Render()
	///
	/// It is a generic implementation; this window is platform agnostic. However,
	/// the application user must explicitly make sure the window size is
	/// synchronized when the external application window/viewport resizes.
	/// \sa SetSize()
	///
	/// It has the same requirements as the vtkGenericOpenGLRenderWindow, whereby,
	/// one must register an observer for WindowMakeCurrentEvent,
	/// WindowIsCurrentEvent and WindowFrameEvent.
	/// \sa vtkGenericOpenGLRenderWindow
	/// </remarks>
	// Token: 0x0200011C RID: 284
	public class vtkExternalOpenGLRenderWindow : vtkGenericOpenGLRenderWindow
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003A3D RID: 14909 RVA: 0x00054A8E File Offset: 0x00052C8E
		static vtkExternalOpenGLRenderWindow()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExternalOpenGLRenderWindow.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExternalOpenGLRenderWindow"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003A3E RID: 14910 RVA: 0x00054AB6 File Offset: 0x00052CB6
		public vtkExternalOpenGLRenderWindow(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06003A3F RID: 14911
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExternalOpenGLRenderWindow_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003A40 RID: 14912 RVA: 0x00054AC4 File Offset: 0x00052CC4
		public new static vtkExternalOpenGLRenderWindow New()
		{
			vtkExternalOpenGLRenderWindow result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExternalOpenGLRenderWindow.vtkExternalOpenGLRenderWindow_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExternalOpenGLRenderWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003A41 RID: 14913 RVA: 0x00054B18 File Offset: 0x00052D18
		public vtkExternalOpenGLRenderWindow() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExternalOpenGLRenderWindow.vtkExternalOpenGLRenderWindow_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003A42 RID: 14914 RVA: 0x00054B5C File Offset: 0x00052D5C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003A43 RID: 14915
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExternalOpenGLRenderWindow_AutomaticWindowPositionAndResizeOff_01(HandleRef pThis);

		/// <summary>
		/// Turn on/off a flag which enables/disables automatic positioning and
		/// resizing of the render window. By default, vtkExternalOpenGLRenderWindow
		/// queries the viewport position and size (glViewport) from the OpenGL state
		/// and uses it to resize itself. However, in special circumstances this
		/// feature is undesirable. One such circumstance may be to avoid performance
		/// penalty of querying OpenGL state variables. So the following boolean is
		/// provided to disable automatic window resize.
		/// (Turn AutomaticWindowPositionAndResize off if you do not want the viewport
		/// to be queried from the OpenGL state.)
		/// </summary>
		// Token: 0x06003A44 RID: 14916 RVA: 0x00054B67 File Offset: 0x00052D67
		public virtual void AutomaticWindowPositionAndResizeOff()
		{
			vtkExternalOpenGLRenderWindow.vtkExternalOpenGLRenderWindow_AutomaticWindowPositionAndResizeOff_01(base.GetCppThis());
		}

		// Token: 0x06003A45 RID: 14917
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExternalOpenGLRenderWindow_AutomaticWindowPositionAndResizeOn_02(HandleRef pThis);

		/// <summary>
		/// Turn on/off a flag which enables/disables automatic positioning and
		/// resizing of the render window. By default, vtkExternalOpenGLRenderWindow
		/// queries the viewport position and size (glViewport) from the OpenGL state
		/// and uses it to resize itself. However, in special circumstances this
		/// feature is undesirable. One such circumstance may be to avoid performance
		/// penalty of querying OpenGL state variables. So the following boolean is
		/// provided to disable automatic window resize.
		/// (Turn AutomaticWindowPositionAndResize off if you do not want the viewport
		/// to be queried from the OpenGL state.)
		/// </summary>
		// Token: 0x06003A46 RID: 14918 RVA: 0x00054B76 File Offset: 0x00052D76
		public virtual void AutomaticWindowPositionAndResizeOn()
		{
			vtkExternalOpenGLRenderWindow.vtkExternalOpenGLRenderWindow_AutomaticWindowPositionAndResizeOn_02(base.GetCppThis());
		}

		// Token: 0x06003A47 RID: 14919
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExternalOpenGLRenderWindow_GetAutomaticWindowPositionAndResize_03(HandleRef pThis);

		/// <summary>
		/// Turn on/off a flag which enables/disables automatic positioning and
		/// resizing of the render window. By default, vtkExternalOpenGLRenderWindow
		/// queries the viewport position and size (glViewport) from the OpenGL state
		/// and uses it to resize itself. However, in special circumstances this
		/// feature is undesirable. One such circumstance may be to avoid performance
		/// penalty of querying OpenGL state variables. So the following boolean is
		/// provided to disable automatic window resize.
		/// (Turn AutomaticWindowPositionAndResize off if you do not want the viewport
		/// to be queried from the OpenGL state.)
		/// </summary>
		// Token: 0x06003A48 RID: 14920 RVA: 0x00054B88 File Offset: 0x00052D88
		public virtual int GetAutomaticWindowPositionAndResize()
		{
			return vtkExternalOpenGLRenderWindow.vtkExternalOpenGLRenderWindow_GetAutomaticWindowPositionAndResize_03(base.GetCppThis());
		}

		// Token: 0x06003A49 RID: 14921
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExternalOpenGLRenderWindow_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003A4A RID: 14922 RVA: 0x00054BA8 File Offset: 0x00052DA8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExternalOpenGLRenderWindow.vtkExternalOpenGLRenderWindow_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06003A4B RID: 14923
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExternalOpenGLRenderWindow_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003A4C RID: 14924 RVA: 0x00054BC8 File Offset: 0x00052DC8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExternalOpenGLRenderWindow.vtkExternalOpenGLRenderWindow_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06003A4D RID: 14925
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExternalOpenGLRenderWindow_GetUseExternalContent_06(HandleRef pThis);

		/// <summary>
		/// Turn on/off a flag which enables/disables using the content from an
		/// outside application.  When on the active read buffer is first blitted
		/// into VTK and becomes the starting point for VTK's rendering.
		/// </summary>
		// Token: 0x06003A4E RID: 14926 RVA: 0x00054BE4 File Offset: 0x00052DE4
		public virtual bool GetUseExternalContent()
		{
			return vtkExternalOpenGLRenderWindow.vtkExternalOpenGLRenderWindow_GetUseExternalContent_06(base.GetCppThis()) != 0;
		}

		// Token: 0x06003A4F RID: 14927
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExternalOpenGLRenderWindow_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003A50 RID: 14928 RVA: 0x00054C0C File Offset: 0x00052E0C
		public override int IsA(string type)
		{
			return vtkExternalOpenGLRenderWindow.vtkExternalOpenGLRenderWindow_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06003A51 RID: 14929
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExternalOpenGLRenderWindow_IsCurrent_08(HandleRef pThis);

		/// <summary>
		/// Tells if this window is the current graphics context for the calling
		/// thread.
		/// </summary>
		// Token: 0x06003A52 RID: 14930 RVA: 0x00054C2C File Offset: 0x00052E2C
		public override bool IsCurrent()
		{
			return vtkExternalOpenGLRenderWindow.vtkExternalOpenGLRenderWindow_IsCurrent_08(base.GetCppThis()) != 0;
		}

		// Token: 0x06003A53 RID: 14931
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExternalOpenGLRenderWindow_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003A54 RID: 14932 RVA: 0x00054C54 File Offset: 0x00052E54
		public new static int IsTypeOf(string type)
		{
			return vtkExternalOpenGLRenderWindow.vtkExternalOpenGLRenderWindow_IsTypeOf_09(type);
		}

		// Token: 0x06003A55 RID: 14933
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExternalOpenGLRenderWindow_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003A56 RID: 14934 RVA: 0x00054C70 File Offset: 0x00052E70
		public new vtkExternalOpenGLRenderWindow NewInstance()
		{
			vtkExternalOpenGLRenderWindow result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExternalOpenGLRenderWindow.vtkExternalOpenGLRenderWindow_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExternalOpenGLRenderWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003A57 RID: 14935
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExternalOpenGLRenderWindow_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003A58 RID: 14936 RVA: 0x00054CCC File Offset: 0x00052ECC
		public new static vtkExternalOpenGLRenderWindow SafeDownCast(vtkObjectBase o)
		{
			vtkExternalOpenGLRenderWindow vtkExternalOpenGLRenderWindow = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExternalOpenGLRenderWindow.vtkExternalOpenGLRenderWindow_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExternalOpenGLRenderWindow = (vtkExternalOpenGLRenderWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExternalOpenGLRenderWindow.Register(null);
				}
			}
			return vtkExternalOpenGLRenderWindow;
		}

		// Token: 0x06003A59 RID: 14937
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExternalOpenGLRenderWindow_SetAutomaticWindowPositionAndResize_13(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off a flag which enables/disables automatic positioning and
		/// resizing of the render window. By default, vtkExternalOpenGLRenderWindow
		/// queries the viewport position and size (glViewport) from the OpenGL state
		/// and uses it to resize itself. However, in special circumstances this
		/// feature is undesirable. One such circumstance may be to avoid performance
		/// penalty of querying OpenGL state variables. So the following boolean is
		/// provided to disable automatic window resize.
		/// (Turn AutomaticWindowPositionAndResize off if you do not want the viewport
		/// to be queried from the OpenGL state.)
		/// </summary>
		// Token: 0x06003A5A RID: 14938 RVA: 0x00054D4B File Offset: 0x00052F4B
		public virtual void SetAutomaticWindowPositionAndResize(int _arg)
		{
			vtkExternalOpenGLRenderWindow.vtkExternalOpenGLRenderWindow_SetAutomaticWindowPositionAndResize_13(base.GetCppThis(), _arg);
		}

		// Token: 0x06003A5B RID: 14939
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExternalOpenGLRenderWindow_SetUseExternalContent_14(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on/off a flag which enables/disables using the content from an
		/// outside application.  When on the active read buffer is first blitted
		/// into VTK and becomes the starting point for VTK's rendering.
		/// </summary>
		// Token: 0x06003A5C RID: 14940 RVA: 0x00054D5B File Offset: 0x00052F5B
		public virtual void SetUseExternalContent(bool _arg)
		{
			vtkExternalOpenGLRenderWindow.vtkExternalOpenGLRenderWindow_SetUseExternalContent_14(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06003A5D RID: 14941
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExternalOpenGLRenderWindow_Start_15(HandleRef pThis);

		/// <summary>
		/// Begin the rendering process using the existing context.
		/// </summary>
		// Token: 0x06003A5E RID: 14942 RVA: 0x00054D73 File Offset: 0x00052F73
		public override void Start()
		{
			vtkExternalOpenGLRenderWindow.vtkExternalOpenGLRenderWindow_Start_15(base.GetCppThis());
		}

		// Token: 0x06003A5F RID: 14943
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExternalOpenGLRenderWindow_UseExternalContentOff_16(HandleRef pThis);

		/// <summary>
		/// Turn on/off a flag which enables/disables using the content from an
		/// outside application.  When on the active read buffer is first blitted
		/// into VTK and becomes the starting point for VTK's rendering.
		/// </summary>
		// Token: 0x06003A60 RID: 14944 RVA: 0x00054D82 File Offset: 0x00052F82
		public virtual void UseExternalContentOff()
		{
			vtkExternalOpenGLRenderWindow.vtkExternalOpenGLRenderWindow_UseExternalContentOff_16(base.GetCppThis());
		}

		// Token: 0x06003A61 RID: 14945
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExternalOpenGLRenderWindow_UseExternalContentOn_17(HandleRef pThis);

		/// <summary>
		/// Turn on/off a flag which enables/disables using the content from an
		/// outside application.  When on the active read buffer is first blitted
		/// into VTK and becomes the starting point for VTK's rendering.
		/// </summary>
		// Token: 0x06003A62 RID: 14946 RVA: 0x00054D91 File Offset: 0x00052F91
		public virtual void UseExternalContentOn()
		{
			vtkExternalOpenGLRenderWindow.vtkExternalOpenGLRenderWindow_UseExternalContentOn_17(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000671 RID: 1649
		public new const string MRFullTypeName = "Kitware.VTK.vtkExternalOpenGLRenderWindow";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000672 RID: 1650
		public new static readonly string MRClassNameKey = "class vtkExternalOpenGLRenderWindow";
	}
}
