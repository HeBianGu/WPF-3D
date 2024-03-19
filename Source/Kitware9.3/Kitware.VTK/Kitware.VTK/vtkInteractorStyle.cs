using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInteractorStyle
	/// </summary>
	/// <remarks>
	///    provide event-driven interface to the rendering window (defines trackball mode)
	///
	/// vtkInteractorStyle is a base class implementing the majority of motion
	/// control routines and defines an event driven interface to support
	/// vtkRenderWindowInteractor. vtkRenderWindowInteractor implements
	/// platform dependent key/mouse routing and timer control, which forwards
	/// events in a neutral form to vtkInteractorStyle.
	///
	/// vtkInteractorStyle implements the "joystick" style of interaction. That
	/// is, holding down the mouse keys generates a stream of events that cause
	/// continuous actions (e.g., rotate, translate, pan, zoom). (The class
	/// vtkInteractorStyleTrackball implements a grab and move style.) The event
	/// bindings for this class include the following:
	/// - Keypress j / Keypress t: toggle between joystick (position sensitive) and
	/// trackball (motion sensitive) styles. In joystick style, motion occurs
	/// continuously as long as a mouse button is pressed. In trackball style,
	/// motion occurs when the mouse button is pressed and the mouse pointer
	/// moves.
	/// - Keypress c / Keypress a: toggle between camera and actor modes. In
	/// camera mode, mouse events affect the camera position and focal point. In
	/// actor mode, mouse events affect the actor that is under the mouse pointer.
	/// - Button 1: rotate the camera around its focal point (if camera mode) or
	/// rotate the actor around its origin (if actor mode). The rotation is in the
	/// direction defined from the center of the renderer's viewport towards
	/// the mouse position. In joystick mode, the magnitude of the rotation is
	/// determined by the distance the mouse is from the center of the render
	/// window.
	/// - Button 2: pan the camera (if camera mode) or translate the actor (if
	/// actor mode). In joystick mode, the direction of pan or translation is
	/// from the center of the viewport towards the mouse position. In trackball
	/// mode, the direction of motion is the direction the mouse moves. (Note:
	/// with 2-button mice, pan is defined as \&lt;Shift\&gt;-Button 1.)
	/// - Button 3: zoom the camera (if camera mode) or scale the actor (if
	/// actor mode). Zoom in/increase scale if the mouse position is in the top
	/// half of the viewport; zoom out/decrease scale if the mouse position is in
	/// the bottom half. In joystick mode, the amount of zoom is controlled by the
	/// distance of the mouse pointer from the horizontal centerline of the
	/// window.
	/// - Keypress 3: toggle the render window into and out of stereo mode. By
	/// default, red-blue stereo pairs are created. Some systems support Crystal
	/// Eyes LCD stereo glasses; you have to invoke SetStereoTypeToCrystalEyes()
	/// on the rendering window.
	/// - Keypress e: exit the application.
	/// - Keypress f: fly to the picked point
	/// - Keypress p: perform a pick operation. The render window interactor has
	/// an internal instance of vtkCellPicker that it uses to pick.
	/// - Keypress r: reset the camera view along the current view
	/// direction. Centers the actors and moves the camera so that all actors are
	/// visible.
	/// - Keypress s: modify the representation of all actors so that they are
	/// surfaces.
	/// - Keypress u: invoke the user-defined function. Typically,
	/// this keypress will bring up an interactor that you can type commands in.
	/// Typing u calls UserCallBack() on the vtkRenderWindowInteractor, which
	/// invokes a vtkCommand::UserEvent. In other words, to define a user-defined
	/// callback, just add an observer to the vtkCommand::UserEvent on the
	/// vtkRenderWindowInteractor object.
	/// - Keypress w: modify the representation of all actors so that they are
	/// wireframe.
	///
	/// vtkInteractorStyle can be subclassed to provide new interaction styles and
	/// a facility to override any of the default mouse/key operations which
	/// currently handle trackball or joystick styles is provided. Note that this
	/// class will fire a variety of events that can be watched using an observer,
	/// such as LeftButtonPressEvent, LeftButtonReleaseEvent,
	/// MiddleButtonPressEvent, MiddleButtonReleaseEvent, RightButtonPressEvent,
	/// RightButtonReleaseEvent, EnterEvent, LeaveEvent, KeyPressEvent,
	/// KeyReleaseEvent, CharEvent, ExposeEvent, ConfigureEvent, TimerEvent,
	/// MouseMoveEvent,
	///
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkInteractorStyleTrackball
	/// </seealso>
	// Token: 0x02000054 RID: 84
	public class vtkInteractorStyle : vtkInteractorObserver
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06000E60 RID: 3680 RVA: 0x0001B35F File Offset: 0x0001955F
		static vtkInteractorStyle()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInteractorStyle.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyle"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06000E61 RID: 3681 RVA: 0x0001B387 File Offset: 0x00019587
		public vtkInteractorStyle(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06000E62 RID: 3682
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyle_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This class must be supplied with a vtkRenderWindowInteractor wrapper or
		/// parent. This class should not normally be instantiated by application
		/// programmers.
		/// </summary>
		// Token: 0x06000E63 RID: 3683 RVA: 0x0001B398 File Offset: 0x00019598
		public new static vtkInteractorStyle New()
		{
			vtkInteractorStyle result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyle.vtkInteractorStyle_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyle)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// This class must be supplied with a vtkRenderWindowInteractor wrapper or
		/// parent. This class should not normally be instantiated by application
		/// programmers.
		/// </summary>
		// Token: 0x06000E64 RID: 3684 RVA: 0x0001B3EC File Offset: 0x000195EC
		public vtkInteractorStyle() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkInteractorStyle.vtkInteractorStyle_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06000E65 RID: 3685 RVA: 0x0001B430 File Offset: 0x00019630
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06000E66 RID: 3686
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_AutoAdjustCameraClippingRangeOff_01(HandleRef pThis);

		/// <summary>
		/// If AutoAdjustCameraClippingRange is on, then before each render the
		/// camera clipping range will be adjusted to "fit" the whole scene. Clipping
		/// will still occur if objects in the scene are behind the camera or
		/// come very close. If AutoAdjustCameraClippingRange is off, no adjustment
		/// will be made per render, but the camera clipping range will still
		/// be reset when the camera is reset.
		/// </summary>
		// Token: 0x06000E67 RID: 3687 RVA: 0x0001B43B File Offset: 0x0001963B
		public virtual void AutoAdjustCameraClippingRangeOff()
		{
			vtkInteractorStyle.vtkInteractorStyle_AutoAdjustCameraClippingRangeOff_01(base.GetCppThis());
		}

		// Token: 0x06000E68 RID: 3688
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_AutoAdjustCameraClippingRangeOn_02(HandleRef pThis);

		/// <summary>
		/// If AutoAdjustCameraClippingRange is on, then before each render the
		/// camera clipping range will be adjusted to "fit" the whole scene. Clipping
		/// will still occur if objects in the scene are behind the camera or
		/// come very close. If AutoAdjustCameraClippingRange is off, no adjustment
		/// will be made per render, but the camera clipping range will still
		/// be reset when the camera is reset.
		/// </summary>
		// Token: 0x06000E69 RID: 3689 RVA: 0x0001B44A File Offset: 0x0001964A
		public virtual void AutoAdjustCameraClippingRangeOn()
		{
			vtkInteractorStyle.vtkInteractorStyle_AutoAdjustCameraClippingRangeOn_02(base.GetCppThis());
		}

		// Token: 0x06000E6A RID: 3690
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_DelegateTDxEvent_03(HandleRef pThis, uint arg0, IntPtr calldata);

		/// <summary>
		/// Called by the callback to process 3DConnexion device events.
		/// </summary>
		// Token: 0x06000E6B RID: 3691 RVA: 0x0001B459 File Offset: 0x00019659
		public void DelegateTDxEvent(uint arg0, IntPtr calldata)
		{
			vtkInteractorStyle.vtkInteractorStyle_DelegateTDxEvent_03(base.GetCppThis(), arg0, calldata);
		}

		// Token: 0x06000E6C RID: 3692
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_Dolly_04(HandleRef pThis);

		/// <summary>
		/// These methods for the different interactions in different modes
		/// are overridden in subclasses to perform the correct motion. Since
		/// they might be called from OnTimer, they do not have mouse coord parameters
		/// (use interactor's GetEventPosition and GetLastEventPosition)
		/// </summary>
		// Token: 0x06000E6D RID: 3693 RVA: 0x0001B46A File Offset: 0x0001966A
		public virtual void Dolly()
		{
			vtkInteractorStyle.vtkInteractorStyle_Dolly_04(base.GetCppThis());
		}

		// Token: 0x06000E6E RID: 3694
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_EndDolly_05(HandleRef pThis);

		/// <summary>
		/// Interaction mode entry points used internally.
		/// </summary>
		// Token: 0x06000E6F RID: 3695 RVA: 0x0001B479 File Offset: 0x00019679
		public virtual void EndDolly()
		{
			vtkInteractorStyle.vtkInteractorStyle_EndDolly_05(base.GetCppThis());
		}

		// Token: 0x06000E70 RID: 3696
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_EndEnvRotate_06(HandleRef pThis);

		/// <summary>
		/// Interaction mode entry points used internally.
		/// </summary>
		// Token: 0x06000E71 RID: 3697 RVA: 0x0001B488 File Offset: 0x00019688
		public virtual void EndEnvRotate()
		{
			vtkInteractorStyle.vtkInteractorStyle_EndEnvRotate_06(base.GetCppThis());
		}

		// Token: 0x06000E72 RID: 3698
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_EndGesture_07(HandleRef pThis);

		/// <summary>
		/// Interaction mode entry points used internally.
		/// </summary>
		// Token: 0x06000E73 RID: 3699 RVA: 0x0001B497 File Offset: 0x00019697
		public virtual void EndGesture()
		{
			vtkInteractorStyle.vtkInteractorStyle_EndGesture_07(base.GetCppThis());
		}

		// Token: 0x06000E74 RID: 3700
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_EndPan_08(HandleRef pThis);

		/// <summary>
		/// Interaction mode entry points used internally.
		/// </summary>
		// Token: 0x06000E75 RID: 3701 RVA: 0x0001B4A6 File Offset: 0x000196A6
		public virtual void EndPan()
		{
			vtkInteractorStyle.vtkInteractorStyle_EndPan_08(base.GetCppThis());
		}

		// Token: 0x06000E76 RID: 3702
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_EndRotate_09(HandleRef pThis);

		/// <summary>
		/// Interaction mode entry points used internally.
		/// </summary>
		// Token: 0x06000E77 RID: 3703 RVA: 0x0001B4B5 File Offset: 0x000196B5
		public virtual void EndRotate()
		{
			vtkInteractorStyle.vtkInteractorStyle_EndRotate_09(base.GetCppThis());
		}

		// Token: 0x06000E78 RID: 3704
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_EndSpin_10(HandleRef pThis);

		/// <summary>
		/// Interaction mode entry points used internally.
		/// </summary>
		// Token: 0x06000E79 RID: 3705 RVA: 0x0001B4C4 File Offset: 0x000196C4
		public virtual void EndSpin()
		{
			vtkInteractorStyle.vtkInteractorStyle_EndSpin_10(base.GetCppThis());
		}

		// Token: 0x06000E7A RID: 3706
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_EndTimer_11(HandleRef pThis);

		/// <summary>
		/// Interaction mode entry points used internally.
		/// </summary>
		// Token: 0x06000E7B RID: 3707 RVA: 0x0001B4D3 File Offset: 0x000196D3
		public virtual void EndTimer()
		{
			vtkInteractorStyle.vtkInteractorStyle_EndTimer_11(base.GetCppThis());
		}

		// Token: 0x06000E7C RID: 3708
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_EndTwoPointer_12(HandleRef pThis);

		/// <summary>
		/// Interaction mode entry points used internally.
		/// </summary>
		// Token: 0x06000E7D RID: 3709 RVA: 0x0001B4E2 File Offset: 0x000196E2
		public virtual void EndTwoPointer()
		{
			vtkInteractorStyle.vtkInteractorStyle_EndTwoPointer_12(base.GetCppThis());
		}

		// Token: 0x06000E7E RID: 3710
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_EndUniformScale_13(HandleRef pThis);

		/// <summary>
		/// Interaction mode entry points used internally.
		/// </summary>
		// Token: 0x06000E7F RID: 3711 RVA: 0x0001B4F1 File Offset: 0x000196F1
		public virtual void EndUniformScale()
		{
			vtkInteractorStyle.vtkInteractorStyle_EndUniformScale_13(base.GetCppThis());
		}

		// Token: 0x06000E80 RID: 3712
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_EndZoom_14(HandleRef pThis);

		/// <summary>
		/// Interaction mode entry points used internally.
		/// </summary>
		// Token: 0x06000E81 RID: 3713 RVA: 0x0001B500 File Offset: 0x00019700
		public virtual void EndZoom()
		{
			vtkInteractorStyle.vtkInteractorStyle_EndZoom_14(base.GetCppThis());
		}

		// Token: 0x06000E82 RID: 3714
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_EnvironmentRotate_15(HandleRef pThis);

		/// <summary>
		/// These methods for the different interactions in different modes
		/// are overridden in subclasses to perform the correct motion. Since
		/// they might be called from OnTimer, they do not have mouse coord parameters
		/// (use interactor's GetEventPosition and GetLastEventPosition)
		/// </summary>
		// Token: 0x06000E83 RID: 3715 RVA: 0x0001B50F File Offset: 0x0001970F
		public virtual void EnvironmentRotate()
		{
			vtkInteractorStyle.vtkInteractorStyle_EnvironmentRotate_15(base.GetCppThis());
		}

		// Token: 0x06000E84 RID: 3716
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_FindPokedRenderer_16(HandleRef pThis, int arg0, int arg1);

		/// <summary>
		/// When an event occurs, we must determine which Renderer the event
		/// occurred within, since one RenderWindow may contain multiple
		/// renderers.
		/// </summary>
		// Token: 0x06000E85 RID: 3717 RVA: 0x0001B51E File Offset: 0x0001971E
		public void FindPokedRenderer(int arg0, int arg1)
		{
			vtkInteractorStyle.vtkInteractorStyle_FindPokedRenderer_16(base.GetCppThis(), arg0, arg1);
		}

		// Token: 0x06000E86 RID: 3718
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyle_GetAutoAdjustCameraClippingRange_17(HandleRef pThis);

		/// <summary>
		/// If AutoAdjustCameraClippingRange is on, then before each render the
		/// camera clipping range will be adjusted to "fit" the whole scene. Clipping
		/// will still occur if objects in the scene are behind the camera or
		/// come very close. If AutoAdjustCameraClippingRange is off, no adjustment
		/// will be made per render, but the camera clipping range will still
		/// be reset when the camera is reset.
		/// </summary>
		// Token: 0x06000E87 RID: 3719 RVA: 0x0001B530 File Offset: 0x00019730
		public virtual int GetAutoAdjustCameraClippingRange()
		{
			return vtkInteractorStyle.vtkInteractorStyle_GetAutoAdjustCameraClippingRange_17(base.GetCppThis());
		}

		// Token: 0x06000E88 RID: 3720
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyle_GetAutoAdjustCameraClippingRangeMaxValue_18(HandleRef pThis);

		/// <summary>
		/// If AutoAdjustCameraClippingRange is on, then before each render the
		/// camera clipping range will be adjusted to "fit" the whole scene. Clipping
		/// will still occur if objects in the scene are behind the camera or
		/// come very close. If AutoAdjustCameraClippingRange is off, no adjustment
		/// will be made per render, but the camera clipping range will still
		/// be reset when the camera is reset.
		/// </summary>
		// Token: 0x06000E89 RID: 3721 RVA: 0x0001B550 File Offset: 0x00019750
		public virtual int GetAutoAdjustCameraClippingRangeMaxValue()
		{
			return vtkInteractorStyle.vtkInteractorStyle_GetAutoAdjustCameraClippingRangeMaxValue_18(base.GetCppThis());
		}

		// Token: 0x06000E8A RID: 3722
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyle_GetAutoAdjustCameraClippingRangeMinValue_19(HandleRef pThis);

		/// <summary>
		/// If AutoAdjustCameraClippingRange is on, then before each render the
		/// camera clipping range will be adjusted to "fit" the whole scene. Clipping
		/// will still occur if objects in the scene are behind the camera or
		/// come very close. If AutoAdjustCameraClippingRange is off, no adjustment
		/// will be made per render, but the camera clipping range will still
		/// be reset when the camera is reset.
		/// </summary>
		// Token: 0x06000E8B RID: 3723 RVA: 0x0001B570 File Offset: 0x00019770
		public virtual int GetAutoAdjustCameraClippingRangeMinValue()
		{
			return vtkInteractorStyle.vtkInteractorStyle_GetAutoAdjustCameraClippingRangeMinValue_19(base.GetCppThis());
		}

		// Token: 0x06000E8C RID: 3724
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyle_GetHandleObservers_20(HandleRef pThis);

		/// <summary>
		/// Does ProcessEvents handle observers on this class or not
		/// </summary>
		// Token: 0x06000E8D RID: 3725 RVA: 0x0001B590 File Offset: 0x00019790
		public virtual int GetHandleObservers()
		{
			return vtkInteractorStyle.vtkInteractorStyle_GetHandleObservers_20(base.GetCppThis());
		}

		// Token: 0x06000E8E RID: 3726
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkInteractorStyle_GetMouseWheelMotionFactor_21(HandleRef pThis);

		/// <summary>
		/// Set/Get the mouse wheel motion factor. Default to 1.0. Set it to a
		/// different value to emphasize or de-emphasize the action triggered by
		/// mouse wheel motion.
		/// </summary>
		// Token: 0x06000E8F RID: 3727 RVA: 0x0001B5B0 File Offset: 0x000197B0
		public virtual double GetMouseWheelMotionFactor()
		{
			return vtkInteractorStyle.vtkInteractorStyle_GetMouseWheelMotionFactor_21(base.GetCppThis());
		}

		// Token: 0x06000E90 RID: 3728
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInteractorStyle_GetNumberOfGenerationsFromBase_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// This class must be supplied with a vtkRenderWindowInteractor wrapper or
		/// parent. This class should not normally be instantiated by application
		/// programmers.
		/// </summary>
		// Token: 0x06000E91 RID: 3729 RVA: 0x0001B5D0 File Offset: 0x000197D0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInteractorStyle.vtkInteractorStyle_GetNumberOfGenerationsFromBase_22(base.GetCppThis(), type);
		}

		// Token: 0x06000E92 RID: 3730
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInteractorStyle_GetNumberOfGenerationsFromBaseType_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// This class must be supplied with a vtkRenderWindowInteractor wrapper or
		/// parent. This class should not normally be instantiated by application
		/// programmers.
		/// </summary>
		// Token: 0x06000E93 RID: 3731 RVA: 0x0001B5F0 File Offset: 0x000197F0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInteractorStyle.vtkInteractorStyle_GetNumberOfGenerationsFromBaseType_23(type);
		}

		// Token: 0x06000E94 RID: 3732
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyle_GetPickColor_24(HandleRef pThis);

		/// <summary>
		/// Set/Get the pick color (used by default to color vtkActor2D's).
		/// The color is expressed as red/green/blue values between (0.0,1.0).
		/// </summary>
		// Token: 0x06000E95 RID: 3733 RVA: 0x0001B60C File Offset: 0x0001980C
		public virtual double[] GetPickColor()
		{
			IntPtr intPtr = vtkInteractorStyle.vtkInteractorStyle_GetPickColor_24(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06000E96 RID: 3734
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_GetPickColor_25(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get the pick color (used by default to color vtkActor2D's).
		/// The color is expressed as red/green/blue values between (0.0,1.0).
		/// </summary>
		// Token: 0x06000E97 RID: 3735 RVA: 0x0001B654 File Offset: 0x00019854
		public virtual void GetPickColor(IntPtr data)
		{
			vtkInteractorStyle.vtkInteractorStyle_GetPickColor_25(base.GetCppThis(), data);
		}

		// Token: 0x06000E98 RID: 3736
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyle_GetState_26(HandleRef pThis);

		/// <summary>
		/// Some useful information for interaction
		/// </summary>
		// Token: 0x06000E99 RID: 3737 RVA: 0x0001B664 File Offset: 0x00019864
		public virtual int GetState()
		{
			return vtkInteractorStyle.vtkInteractorStyle_GetState_26(base.GetCppThis());
		}

		// Token: 0x06000E9A RID: 3738
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyle_GetTDxStyle_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// 3Dconnexion device interactor style. Initial value is a pointer to an
		/// object of class vtkTdxInteractorStyleCamera.
		/// </summary>
		// Token: 0x06000E9B RID: 3739 RVA: 0x0001B684 File Offset: 0x00019884
		public virtual vtkTDxInteractorStyle GetTDxStyle()
		{
			vtkTDxInteractorStyle vtkTDxInteractorStyle = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyle.vtkInteractorStyle_GetTDxStyle_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTDxInteractorStyle = (vtkTDxInteractorStyle)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTDxInteractorStyle.Register(null);
				}
			}
			return vtkTDxInteractorStyle;
		}

		// Token: 0x06000E9C RID: 3740
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkInteractorStyle_GetTimerDuration_28(HandleRef pThis);

		/// <summary>
		/// If using timers, specify the default timer interval (in
		/// milliseconds). Care must be taken when adjusting the timer interval from
		/// the default value of 10 milliseconds--it may adversely affect the
		/// interactors.
		/// </summary>
		// Token: 0x06000E9D RID: 3741 RVA: 0x0001B6F4 File Offset: 0x000198F4
		public virtual uint GetTimerDuration()
		{
			return vtkInteractorStyle.vtkInteractorStyle_GetTimerDuration_28(base.GetCppThis());
		}

		// Token: 0x06000E9E RID: 3742
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkInteractorStyle_GetTimerDurationMaxValue_29(HandleRef pThis);

		/// <summary>
		/// If using timers, specify the default timer interval (in
		/// milliseconds). Care must be taken when adjusting the timer interval from
		/// the default value of 10 milliseconds--it may adversely affect the
		/// interactors.
		/// </summary>
		// Token: 0x06000E9F RID: 3743 RVA: 0x0001B714 File Offset: 0x00019914
		public virtual uint GetTimerDurationMaxValue()
		{
			return vtkInteractorStyle.vtkInteractorStyle_GetTimerDurationMaxValue_29(base.GetCppThis());
		}

		// Token: 0x06000EA0 RID: 3744
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkInteractorStyle_GetTimerDurationMinValue_30(HandleRef pThis);

		/// <summary>
		/// If using timers, specify the default timer interval (in
		/// milliseconds). Care must be taken when adjusting the timer interval from
		/// the default value of 10 milliseconds--it may adversely affect the
		/// interactors.
		/// </summary>
		// Token: 0x06000EA1 RID: 3745 RVA: 0x0001B734 File Offset: 0x00019934
		public virtual uint GetTimerDurationMinValue()
		{
			return vtkInteractorStyle.vtkInteractorStyle_GetTimerDurationMinValue_30(base.GetCppThis());
		}

		// Token: 0x06000EA2 RID: 3746
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyle_GetUseTimers_31(HandleRef pThis);

		/// <summary>
		/// Set/Get timer hint
		/// </summary>
		// Token: 0x06000EA3 RID: 3747 RVA: 0x0001B754 File Offset: 0x00019954
		public virtual int GetUseTimers()
		{
			return vtkInteractorStyle.vtkInteractorStyle_GetUseTimers_31(base.GetCppThis());
		}

		// Token: 0x06000EA4 RID: 3748
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_HandleObserversOff_32(HandleRef pThis);

		/// <summary>
		/// Does ProcessEvents handle observers on this class or not
		/// </summary>
		// Token: 0x06000EA5 RID: 3749 RVA: 0x0001B773 File Offset: 0x00019973
		public virtual void HandleObserversOff()
		{
			vtkInteractorStyle.vtkInteractorStyle_HandleObserversOff_32(base.GetCppThis());
		}

		// Token: 0x06000EA6 RID: 3750
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_HandleObserversOn_33(HandleRef pThis);

		/// <summary>
		/// Does ProcessEvents handle observers on this class or not
		/// </summary>
		// Token: 0x06000EA7 RID: 3751 RVA: 0x0001B782 File Offset: 0x00019982
		public virtual void HandleObserversOn()
		{
			vtkInteractorStyle.vtkInteractorStyle_HandleObserversOn_33(base.GetCppThis());
		}

		// Token: 0x06000EA8 RID: 3752
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_HighlightActor2D_34(HandleRef pThis, HandleRef actor2D);

		/// <summary>
		/// When picking successfully selects an actor, this method highlights the
		/// picked prop appropriately. Currently this is done by placing a bounding
		/// box around a picked vtkProp3D, and using the PickColor to highlight a
		/// vtkProp2D.
		/// </summary>
		// Token: 0x06000EA9 RID: 3753 RVA: 0x0001B794 File Offset: 0x00019994
		public virtual void HighlightActor2D(vtkActor2D actor2D)
		{
			vtkInteractorStyle.vtkInteractorStyle_HighlightActor2D_34(base.GetCppThis(), (actor2D == null) ? default(HandleRef) : actor2D.GetCppThis());
		}

		// Token: 0x06000EAA RID: 3754
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_HighlightProp_35(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// When picking successfully selects an actor, this method highlights the
		/// picked prop appropriately. Currently this is done by placing a bounding
		/// box around a picked vtkProp3D, and using the PickColor to highlight a
		/// vtkProp2D.
		/// </summary>
		// Token: 0x06000EAB RID: 3755 RVA: 0x0001B7C4 File Offset: 0x000199C4
		public virtual void HighlightProp(vtkProp prop)
		{
			vtkInteractorStyle.vtkInteractorStyle_HighlightProp_35(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		// Token: 0x06000EAC RID: 3756
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_HighlightProp3D_36(HandleRef pThis, HandleRef prop3D);

		/// <summary>
		/// When picking successfully selects an actor, this method highlights the
		/// picked prop appropriately. Currently this is done by placing a bounding
		/// box around a picked vtkProp3D, and using the PickColor to highlight a
		/// vtkProp2D.
		/// </summary>
		// Token: 0x06000EAD RID: 3757 RVA: 0x0001B7F4 File Offset: 0x000199F4
		public virtual void HighlightProp3D(vtkProp3D prop3D)
		{
			vtkInteractorStyle.vtkInteractorStyle_HighlightProp3D_36(base.GetCppThis(), (prop3D == null) ? default(HandleRef) : prop3D.GetCppThis());
		}

		// Token: 0x06000EAE RID: 3758
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyle_IsA_37(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// This class must be supplied with a vtkRenderWindowInteractor wrapper or
		/// parent. This class should not normally be instantiated by application
		/// programmers.
		/// </summary>
		// Token: 0x06000EAF RID: 3759 RVA: 0x0001B824 File Offset: 0x00019A24
		public override int IsA(string type)
		{
			return vtkInteractorStyle.vtkInteractorStyle_IsA_37(base.GetCppThis(), type);
		}

		// Token: 0x06000EB0 RID: 3760
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyle_IsTypeOf_38([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// This class must be supplied with a vtkRenderWindowInteractor wrapper or
		/// parent. This class should not normally be instantiated by application
		/// programmers.
		/// </summary>
		// Token: 0x06000EB1 RID: 3761 RVA: 0x0001B844 File Offset: 0x00019A44
		public new static int IsTypeOf(string type)
		{
			return vtkInteractorStyle.vtkInteractorStyle_IsTypeOf_38(type);
		}

		// Token: 0x06000EB2 RID: 3762
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyle_NewInstance_40(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This class must be supplied with a vtkRenderWindowInteractor wrapper or
		/// parent. This class should not normally be instantiated by application
		/// programmers.
		/// </summary>
		// Token: 0x06000EB3 RID: 3763 RVA: 0x0001B860 File Offset: 0x00019A60
		public new vtkInteractorStyle NewInstance()
		{
			vtkInteractorStyle result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyle.vtkInteractorStyle_NewInstance_40(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyle)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000EB4 RID: 3764
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnButton3D_41(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Generic 3D event bindings can be overridden in subclasses
		/// </summary>
		// Token: 0x06000EB5 RID: 3765 RVA: 0x0001B8BC File Offset: 0x00019ABC
		public virtual void OnButton3D(vtkEventData arg0)
		{
			vtkInteractorStyle.vtkInteractorStyle_OnButton3D_41(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06000EB6 RID: 3766
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnChar_42(HandleRef pThis);

		/// <summary>
		/// OnChar is triggered when an ASCII key is pressed. Some basic key presses
		/// are handled here ('q' for Quit, 'p' for Pick, etc)
		/// </summary>
		// Token: 0x06000EB7 RID: 3767 RVA: 0x0001B8EB File Offset: 0x00019AEB
		public override void OnChar()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnChar_42(base.GetCppThis());
		}

		// Token: 0x06000EB8 RID: 3768
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnClip3D_43(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Generic 3D event bindings can be overridden in subclasses
		/// </summary>
		// Token: 0x06000EB9 RID: 3769 RVA: 0x0001B8FC File Offset: 0x00019AFC
		public virtual void OnClip3D(vtkEventData arg0)
		{
			vtkInteractorStyle.vtkInteractorStyle_OnClip3D_43(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06000EBA RID: 3770
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnConfigure_44(HandleRef pThis);

		/// <summary>
		/// These are more esoteric events, but are useful in some cases.
		/// </summary>
		// Token: 0x06000EBB RID: 3771 RVA: 0x0001B92B File Offset: 0x00019B2B
		public virtual void OnConfigure()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnConfigure_44(base.GetCppThis());
		}

		// Token: 0x06000EBC RID: 3772
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnDropFiles_45(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// When files are dropped on the render window.
		/// The argument contains the list of file paths dropped.
		/// It is called after OnDropLocation.
		/// </summary>
		// Token: 0x06000EBD RID: 3773 RVA: 0x0001B93C File Offset: 0x00019B3C
		public virtual void OnDropFiles(vtkStringArray arg0)
		{
			vtkInteractorStyle.vtkInteractorStyle_OnDropFiles_45(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06000EBE RID: 3774
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnDropLocation_46(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// When the mouse location is updated while dragging files.
		/// The argument contains the position relative to the window of the mouse
		/// where the files are dropped.
		/// It is called before OnDropFiles.
		/// </summary>
		// Token: 0x06000EBF RID: 3775 RVA: 0x0001B96B File Offset: 0x00019B6B
		public virtual void OnDropLocation(IntPtr arg0)
		{
			vtkInteractorStyle.vtkInteractorStyle_OnDropLocation_46(base.GetCppThis(), arg0);
		}

		// Token: 0x06000EC0 RID: 3776
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnElevation3D_47(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Generic 3D event bindings can be overridden in subclasses
		/// </summary>
		// Token: 0x06000EC1 RID: 3777 RVA: 0x0001B97C File Offset: 0x00019B7C
		public virtual void OnElevation3D(vtkEventData arg0)
		{
			vtkInteractorStyle.vtkInteractorStyle_OnElevation3D_47(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06000EC2 RID: 3778
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnEndPan_48(HandleRef pThis);

		/// <summary>
		/// gesture based events
		/// </summary>
		// Token: 0x06000EC3 RID: 3779 RVA: 0x0001B9AB File Offset: 0x00019BAB
		public virtual void OnEndPan()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnEndPan_48(base.GetCppThis());
		}

		// Token: 0x06000EC4 RID: 3780
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnEndPinch_49(HandleRef pThis);

		/// <summary>
		/// gesture based events
		/// </summary>
		// Token: 0x06000EC5 RID: 3781 RVA: 0x0001B9BA File Offset: 0x00019BBA
		public virtual void OnEndPinch()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnEndPinch_49(base.GetCppThis());
		}

		// Token: 0x06000EC6 RID: 3782
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnEndRotate_50(HandleRef pThis);

		/// <summary>
		/// gesture based events
		/// </summary>
		// Token: 0x06000EC7 RID: 3783 RVA: 0x0001B9C9 File Offset: 0x00019BC9
		public virtual void OnEndRotate()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnEndRotate_50(base.GetCppThis());
		}

		// Token: 0x06000EC8 RID: 3784
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnEndSwipe_51(HandleRef pThis);

		/// <summary>
		/// gesture based events
		/// </summary>
		// Token: 0x06000EC9 RID: 3785 RVA: 0x0001B9D8 File Offset: 0x00019BD8
		public virtual void OnEndSwipe()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnEndSwipe_51(base.GetCppThis());
		}

		// Token: 0x06000ECA RID: 3786
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnEnter_52(HandleRef pThis);

		/// <summary>
		/// These are more esoteric events, but are useful in some cases.
		/// </summary>
		// Token: 0x06000ECB RID: 3787 RVA: 0x0001B9E7 File Offset: 0x00019BE7
		public virtual void OnEnter()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnEnter_52(base.GetCppThis());
		}

		// Token: 0x06000ECC RID: 3788
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnExpose_53(HandleRef pThis);

		/// <summary>
		/// These are more esoteric events, but are useful in some cases.
		/// </summary>
		// Token: 0x06000ECD RID: 3789 RVA: 0x0001B9F6 File Offset: 0x00019BF6
		public virtual void OnExpose()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnExpose_53(base.GetCppThis());
		}

		// Token: 0x06000ECE RID: 3790
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnFifthButtonDown_54(HandleRef pThis);

		/// <summary>
		/// Generic event bindings can be overridden in subclasses
		/// </summary>
		// Token: 0x06000ECF RID: 3791 RVA: 0x0001BA05 File Offset: 0x00019C05
		public virtual void OnFifthButtonDown()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnFifthButtonDown_54(base.GetCppThis());
		}

		// Token: 0x06000ED0 RID: 3792
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnFifthButtonUp_55(HandleRef pThis);

		/// <summary>
		/// Generic event bindings can be overridden in subclasses
		/// </summary>
		// Token: 0x06000ED1 RID: 3793 RVA: 0x0001BA14 File Offset: 0x00019C14
		public virtual void OnFifthButtonUp()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnFifthButtonUp_55(base.GetCppThis());
		}

		// Token: 0x06000ED2 RID: 3794
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnFourthButtonDown_56(HandleRef pThis);

		/// <summary>
		/// Generic event bindings can be overridden in subclasses
		/// </summary>
		// Token: 0x06000ED3 RID: 3795 RVA: 0x0001BA23 File Offset: 0x00019C23
		public virtual void OnFourthButtonDown()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnFourthButtonDown_56(base.GetCppThis());
		}

		// Token: 0x06000ED4 RID: 3796
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnFourthButtonUp_57(HandleRef pThis);

		/// <summary>
		/// Generic event bindings can be overridden in subclasses
		/// </summary>
		// Token: 0x06000ED5 RID: 3797 RVA: 0x0001BA32 File Offset: 0x00019C32
		public virtual void OnFourthButtonUp()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnFourthButtonUp_57(base.GetCppThis());
		}

		// Token: 0x06000ED6 RID: 3798
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnKeyDown_58(HandleRef pThis);

		/// <summary>
		/// OnChar is triggered when an ASCII key is pressed. Some basic key presses
		/// are handled here ('q' for Quit, 'p' for Pick, etc)
		/// </summary>
		// Token: 0x06000ED7 RID: 3799 RVA: 0x0001BA41 File Offset: 0x00019C41
		public virtual void OnKeyDown()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnKeyDown_58(base.GetCppThis());
		}

		// Token: 0x06000ED8 RID: 3800
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnKeyPress_59(HandleRef pThis);

		/// <summary>
		/// OnChar is triggered when an ASCII key is pressed. Some basic key presses
		/// are handled here ('q' for Quit, 'p' for Pick, etc)
		/// </summary>
		// Token: 0x06000ED9 RID: 3801 RVA: 0x0001BA50 File Offset: 0x00019C50
		public virtual void OnKeyPress()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnKeyPress_59(base.GetCppThis());
		}

		// Token: 0x06000EDA RID: 3802
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnKeyRelease_60(HandleRef pThis);

		/// <summary>
		/// OnChar is triggered when an ASCII key is pressed. Some basic key presses
		/// are handled here ('q' for Quit, 'p' for Pick, etc)
		/// </summary>
		// Token: 0x06000EDB RID: 3803 RVA: 0x0001BA5F File Offset: 0x00019C5F
		public virtual void OnKeyRelease()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnKeyRelease_60(base.GetCppThis());
		}

		// Token: 0x06000EDC RID: 3804
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnKeyUp_61(HandleRef pThis);

		/// <summary>
		/// OnChar is triggered when an ASCII key is pressed. Some basic key presses
		/// are handled here ('q' for Quit, 'p' for Pick, etc)
		/// </summary>
		// Token: 0x06000EDD RID: 3805 RVA: 0x0001BA6E File Offset: 0x00019C6E
		public virtual void OnKeyUp()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnKeyUp_61(base.GetCppThis());
		}

		// Token: 0x06000EDE RID: 3806
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnLeave_62(HandleRef pThis);

		/// <summary>
		/// These are more esoteric events, but are useful in some cases.
		/// </summary>
		// Token: 0x06000EDF RID: 3807 RVA: 0x0001BA7D File Offset: 0x00019C7D
		public virtual void OnLeave()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnLeave_62(base.GetCppThis());
		}

		// Token: 0x06000EE0 RID: 3808
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnLeftButtonDoubleClick_63(HandleRef pThis);

		/// <summary>
		/// Generic event bindings can be overridden in subclasses
		/// </summary>
		// Token: 0x06000EE1 RID: 3809 RVA: 0x0001BA8C File Offset: 0x00019C8C
		public virtual void OnLeftButtonDoubleClick()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnLeftButtonDoubleClick_63(base.GetCppThis());
		}

		// Token: 0x06000EE2 RID: 3810
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnLeftButtonDown_64(HandleRef pThis);

		/// <summary>
		/// Generic event bindings can be overridden in subclasses
		/// </summary>
		// Token: 0x06000EE3 RID: 3811 RVA: 0x0001BA9B File Offset: 0x00019C9B
		public virtual void OnLeftButtonDown()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnLeftButtonDown_64(base.GetCppThis());
		}

		// Token: 0x06000EE4 RID: 3812
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnLeftButtonUp_65(HandleRef pThis);

		/// <summary>
		/// Generic event bindings can be overridden in subclasses
		/// </summary>
		// Token: 0x06000EE5 RID: 3813 RVA: 0x0001BAAA File Offset: 0x00019CAA
		public virtual void OnLeftButtonUp()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnLeftButtonUp_65(base.GetCppThis());
		}

		// Token: 0x06000EE6 RID: 3814
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnLongTap_66(HandleRef pThis);

		/// <summary>
		/// gesture based events
		/// </summary>
		// Token: 0x06000EE7 RID: 3815 RVA: 0x0001BAB9 File Offset: 0x00019CB9
		public virtual void OnLongTap()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnLongTap_66(base.GetCppThis());
		}

		// Token: 0x06000EE8 RID: 3816
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnMenu3D_67(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Generic 3D event bindings can be overridden in subclasses
		/// </summary>
		// Token: 0x06000EE9 RID: 3817 RVA: 0x0001BAC8 File Offset: 0x00019CC8
		public virtual void OnMenu3D(vtkEventData arg0)
		{
			vtkInteractorStyle.vtkInteractorStyle_OnMenu3D_67(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06000EEA RID: 3818
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnMiddleButtonDoubleClick_68(HandleRef pThis);

		/// <summary>
		/// Generic event bindings can be overridden in subclasses
		/// </summary>
		// Token: 0x06000EEB RID: 3819 RVA: 0x0001BAF7 File Offset: 0x00019CF7
		public virtual void OnMiddleButtonDoubleClick()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnMiddleButtonDoubleClick_68(base.GetCppThis());
		}

		// Token: 0x06000EEC RID: 3820
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnMiddleButtonDown_69(HandleRef pThis);

		/// <summary>
		/// Generic event bindings can be overridden in subclasses
		/// </summary>
		// Token: 0x06000EED RID: 3821 RVA: 0x0001BB06 File Offset: 0x00019D06
		public virtual void OnMiddleButtonDown()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnMiddleButtonDown_69(base.GetCppThis());
		}

		// Token: 0x06000EEE RID: 3822
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnMiddleButtonUp_70(HandleRef pThis);

		/// <summary>
		/// Generic event bindings can be overridden in subclasses
		/// </summary>
		// Token: 0x06000EEF RID: 3823 RVA: 0x0001BB15 File Offset: 0x00019D15
		public virtual void OnMiddleButtonUp()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnMiddleButtonUp_70(base.GetCppThis());
		}

		// Token: 0x06000EF0 RID: 3824
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnMouseMove_71(HandleRef pThis);

		/// <summary>
		/// Generic event bindings can be overridden in subclasses
		/// </summary>
		// Token: 0x06000EF1 RID: 3825 RVA: 0x0001BB24 File Offset: 0x00019D24
		public virtual void OnMouseMove()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnMouseMove_71(base.GetCppThis());
		}

		// Token: 0x06000EF2 RID: 3826
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnMouseWheelBackward_72(HandleRef pThis);

		/// <summary>
		/// Generic event bindings can be overridden in subclasses
		/// </summary>
		// Token: 0x06000EF3 RID: 3827 RVA: 0x0001BB33 File Offset: 0x00019D33
		public virtual void OnMouseWheelBackward()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnMouseWheelBackward_72(base.GetCppThis());
		}

		// Token: 0x06000EF4 RID: 3828
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnMouseWheelForward_73(HandleRef pThis);

		/// <summary>
		/// Generic event bindings can be overridden in subclasses
		/// </summary>
		// Token: 0x06000EF5 RID: 3829 RVA: 0x0001BB42 File Offset: 0x00019D42
		public virtual void OnMouseWheelForward()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnMouseWheelForward_73(base.GetCppThis());
		}

		// Token: 0x06000EF6 RID: 3830
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnMouseWheelLeft_74(HandleRef pThis);

		/// <summary>
		/// Generic event bindings can be overridden in subclasses
		/// </summary>
		// Token: 0x06000EF7 RID: 3831 RVA: 0x0001BB51 File Offset: 0x00019D51
		public virtual void OnMouseWheelLeft()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnMouseWheelLeft_74(base.GetCppThis());
		}

		// Token: 0x06000EF8 RID: 3832
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnMouseWheelRight_75(HandleRef pThis);

		/// <summary>
		/// Generic event bindings can be overridden in subclasses
		/// </summary>
		// Token: 0x06000EF9 RID: 3833 RVA: 0x0001BB60 File Offset: 0x00019D60
		public virtual void OnMouseWheelRight()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnMouseWheelRight_75(base.GetCppThis());
		}

		// Token: 0x06000EFA RID: 3834
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnMove3D_76(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Generic 3D event bindings can be overridden in subclasses
		/// </summary>
		// Token: 0x06000EFB RID: 3835 RVA: 0x0001BB70 File Offset: 0x00019D70
		public virtual void OnMove3D(vtkEventData arg0)
		{
			vtkInteractorStyle.vtkInteractorStyle_OnMove3D_76(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06000EFC RID: 3836
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnNextPose3D_77(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Generic 3D event bindings can be overridden in subclasses
		/// </summary>
		// Token: 0x06000EFD RID: 3837 RVA: 0x0001BBA0 File Offset: 0x00019DA0
		public virtual void OnNextPose3D(vtkEventData arg0)
		{
			vtkInteractorStyle.vtkInteractorStyle_OnNextPose3D_77(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06000EFE RID: 3838
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnPan_78(HandleRef pThis);

		/// <summary>
		/// gesture based events
		/// </summary>
		// Token: 0x06000EFF RID: 3839 RVA: 0x0001BBCF File Offset: 0x00019DCF
		public virtual void OnPan()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnPan_78(base.GetCppThis());
		}

		// Token: 0x06000F00 RID: 3840
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnPick3D_79(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Generic 3D event bindings can be overridden in subclasses
		/// </summary>
		// Token: 0x06000F01 RID: 3841 RVA: 0x0001BBE0 File Offset: 0x00019DE0
		public virtual void OnPick3D(vtkEventData arg0)
		{
			vtkInteractorStyle.vtkInteractorStyle_OnPick3D_79(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06000F02 RID: 3842
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnPinch_80(HandleRef pThis);

		/// <summary>
		/// gesture based events
		/// </summary>
		// Token: 0x06000F03 RID: 3843 RVA: 0x0001BC0F File Offset: 0x00019E0F
		public virtual void OnPinch()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnPinch_80(base.GetCppThis());
		}

		// Token: 0x06000F04 RID: 3844
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnPositionProp3D_81(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Generic 3D event bindings can be overridden in subclasses
		/// </summary>
		// Token: 0x06000F05 RID: 3845 RVA: 0x0001BC20 File Offset: 0x00019E20
		public virtual void OnPositionProp3D(vtkEventData arg0)
		{
			vtkInteractorStyle.vtkInteractorStyle_OnPositionProp3D_81(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06000F06 RID: 3846
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnRightButtonDoubleClick_82(HandleRef pThis);

		/// <summary>
		/// Generic event bindings can be overridden in subclasses
		/// </summary>
		// Token: 0x06000F07 RID: 3847 RVA: 0x0001BC4F File Offset: 0x00019E4F
		public virtual void OnRightButtonDoubleClick()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnRightButtonDoubleClick_82(base.GetCppThis());
		}

		// Token: 0x06000F08 RID: 3848
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnRightButtonDown_83(HandleRef pThis);

		/// <summary>
		/// Generic event bindings can be overridden in subclasses
		/// </summary>
		// Token: 0x06000F09 RID: 3849 RVA: 0x0001BC5E File Offset: 0x00019E5E
		public virtual void OnRightButtonDown()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnRightButtonDown_83(base.GetCppThis());
		}

		// Token: 0x06000F0A RID: 3850
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnRightButtonUp_84(HandleRef pThis);

		/// <summary>
		/// Generic event bindings can be overridden in subclasses
		/// </summary>
		// Token: 0x06000F0B RID: 3851 RVA: 0x0001BC6D File Offset: 0x00019E6D
		public virtual void OnRightButtonUp()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnRightButtonUp_84(base.GetCppThis());
		}

		// Token: 0x06000F0C RID: 3852
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnRotate_85(HandleRef pThis);

		/// <summary>
		/// gesture based events
		/// </summary>
		// Token: 0x06000F0D RID: 3853 RVA: 0x0001BC7C File Offset: 0x00019E7C
		public virtual void OnRotate()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnRotate_85(base.GetCppThis());
		}

		// Token: 0x06000F0E RID: 3854
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnSelect3D_86(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Generic 3D event bindings can be overridden in subclasses
		/// </summary>
		// Token: 0x06000F0F RID: 3855 RVA: 0x0001BC8C File Offset: 0x00019E8C
		public virtual void OnSelect3D(vtkEventData arg0)
		{
			vtkInteractorStyle.vtkInteractorStyle_OnSelect3D_86(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06000F10 RID: 3856
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnStartPan_87(HandleRef pThis);

		/// <summary>
		/// gesture based events
		/// </summary>
		// Token: 0x06000F11 RID: 3857 RVA: 0x0001BCBB File Offset: 0x00019EBB
		public virtual void OnStartPan()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnStartPan_87(base.GetCppThis());
		}

		// Token: 0x06000F12 RID: 3858
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnStartPinch_88(HandleRef pThis);

		/// <summary>
		/// gesture based events
		/// </summary>
		// Token: 0x06000F13 RID: 3859 RVA: 0x0001BCCA File Offset: 0x00019ECA
		public virtual void OnStartPinch()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnStartPinch_88(base.GetCppThis());
		}

		// Token: 0x06000F14 RID: 3860
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnStartRotate_89(HandleRef pThis);

		/// <summary>
		/// gesture based events
		/// </summary>
		// Token: 0x06000F15 RID: 3861 RVA: 0x0001BCD9 File Offset: 0x00019ED9
		public virtual void OnStartRotate()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnStartRotate_89(base.GetCppThis());
		}

		// Token: 0x06000F16 RID: 3862
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnStartSwipe_90(HandleRef pThis);

		/// <summary>
		/// gesture based events
		/// </summary>
		// Token: 0x06000F17 RID: 3863 RVA: 0x0001BCE8 File Offset: 0x00019EE8
		public virtual void OnStartSwipe()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnStartSwipe_90(base.GetCppThis());
		}

		// Token: 0x06000F18 RID: 3864
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnSwipe_91(HandleRef pThis);

		/// <summary>
		/// gesture based events
		/// </summary>
		// Token: 0x06000F19 RID: 3865 RVA: 0x0001BCF7 File Offset: 0x00019EF7
		public virtual void OnSwipe()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnSwipe_91(base.GetCppThis());
		}

		// Token: 0x06000F1A RID: 3866
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnTap_92(HandleRef pThis);

		/// <summary>
		/// gesture based events
		/// </summary>
		// Token: 0x06000F1B RID: 3867 RVA: 0x0001BD06 File Offset: 0x00019F06
		public virtual void OnTap()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnTap_92(base.GetCppThis());
		}

		// Token: 0x06000F1C RID: 3868
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnTimer_93(HandleRef pThis);

		/// <summary>
		/// OnTimer calls Rotate, Rotate etc which should be overridden by
		/// style subclasses.
		/// </summary>
		// Token: 0x06000F1D RID: 3869 RVA: 0x0001BD15 File Offset: 0x00019F15
		public virtual void OnTimer()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnTimer_93(base.GetCppThis());
		}

		// Token: 0x06000F1E RID: 3870
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_OnViewerMovement3D_94(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Generic 3D event bindings can be overridden in subclasses
		/// </summary>
		// Token: 0x06000F1F RID: 3871 RVA: 0x0001BD24 File Offset: 0x00019F24
		public virtual void OnViewerMovement3D(vtkEventData arg0)
		{
			vtkInteractorStyle.vtkInteractorStyle_OnViewerMovement3D_94(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06000F20 RID: 3872
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_Pan_95(HandleRef pThis);

		/// <summary>
		/// These methods for the different interactions in different modes
		/// are overridden in subclasses to perform the correct motion. Since
		/// they might be called from OnTimer, they do not have mouse coord parameters
		/// (use interactor's GetEventPosition and GetLastEventPosition)
		/// </summary>
		// Token: 0x06000F21 RID: 3873 RVA: 0x0001BD53 File Offset: 0x00019F53
		public virtual void Pan()
		{
			vtkInteractorStyle.vtkInteractorStyle_Pan_95(base.GetCppThis());
		}

		// Token: 0x06000F22 RID: 3874
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_Rotate_96(HandleRef pThis);

		/// <summary>
		/// These methods for the different interactions in different modes
		/// are overridden in subclasses to perform the correct motion. Since
		/// they might be called from OnTimer, they do not have mouse coord parameters
		/// (use interactor's GetEventPosition and GetLastEventPosition)
		/// </summary>
		// Token: 0x06000F23 RID: 3875 RVA: 0x0001BD62 File Offset: 0x00019F62
		public virtual void Rotate()
		{
			vtkInteractorStyle.vtkInteractorStyle_Rotate_96(base.GetCppThis());
		}

		// Token: 0x06000F24 RID: 3876
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyle_SafeDownCast_97(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This class must be supplied with a vtkRenderWindowInteractor wrapper or
		/// parent. This class should not normally be instantiated by application
		/// programmers.
		/// </summary>
		// Token: 0x06000F25 RID: 3877 RVA: 0x0001BD74 File Offset: 0x00019F74
		public new static vtkInteractorStyle SafeDownCast(vtkObjectBase o)
		{
			vtkInteractorStyle vtkInteractorStyle = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyle.vtkInteractorStyle_SafeDownCast_97((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInteractorStyle = (vtkInteractorStyle)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInteractorStyle.Register(null);
				}
			}
			return vtkInteractorStyle;
		}

		// Token: 0x06000F26 RID: 3878
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_SetAutoAdjustCameraClippingRange_98(HandleRef pThis, int _arg);

		/// <summary>
		/// If AutoAdjustCameraClippingRange is on, then before each render the
		/// camera clipping range will be adjusted to "fit" the whole scene. Clipping
		/// will still occur if objects in the scene are behind the camera or
		/// come very close. If AutoAdjustCameraClippingRange is off, no adjustment
		/// will be made per render, but the camera clipping range will still
		/// be reset when the camera is reset.
		/// </summary>
		// Token: 0x06000F27 RID: 3879 RVA: 0x0001BDF3 File Offset: 0x00019FF3
		public virtual void SetAutoAdjustCameraClippingRange(int _arg)
		{
			vtkInteractorStyle.vtkInteractorStyle_SetAutoAdjustCameraClippingRange_98(base.GetCppThis(), _arg);
		}

		// Token: 0x06000F28 RID: 3880
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_SetEnabled_99(HandleRef pThis, int arg0);

		/// <summary>
		/// Turn on/off this interactor. Interactor styles operate a little
		/// bit differently than other types of interactor observers. When
		/// the SetInteractor() method is invoked, the automatically enable
		/// themselves. This is a legacy requirement, and convenient for the
		/// user.
		/// </summary>
		// Token: 0x06000F29 RID: 3881 RVA: 0x0001BE03 File Offset: 0x0001A003
		public override void SetEnabled(int arg0)
		{
			vtkInteractorStyle.vtkInteractorStyle_SetEnabled_99(base.GetCppThis(), arg0);
		}

		// Token: 0x06000F2A RID: 3882
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_SetHandleObservers_100(HandleRef pThis, int _arg);

		/// <summary>
		/// Does ProcessEvents handle observers on this class or not
		/// </summary>
		// Token: 0x06000F2B RID: 3883 RVA: 0x0001BE13 File Offset: 0x0001A013
		public virtual void SetHandleObservers(int _arg)
		{
			vtkInteractorStyle.vtkInteractorStyle_SetHandleObservers_100(base.GetCppThis(), _arg);
		}

		// Token: 0x06000F2C RID: 3884
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_SetInteractor_101(HandleRef pThis, HandleRef interactor);

		/// <summary>
		/// Set/Get the Interactor wrapper being controlled by this object.
		/// (Satisfy superclass API.)
		/// </summary>
		// Token: 0x06000F2D RID: 3885 RVA: 0x0001BE24 File Offset: 0x0001A024
		public override void SetInteractor(vtkRenderWindowInteractor interactor)
		{
			vtkInteractorStyle.vtkInteractorStyle_SetInteractor_101(base.GetCppThis(), (interactor == null) ? default(HandleRef) : interactor.GetCppThis());
		}

		// Token: 0x06000F2E RID: 3886
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_SetMouseWheelMotionFactor_102(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the mouse wheel motion factor. Default to 1.0. Set it to a
		/// different value to emphasize or de-emphasize the action triggered by
		/// mouse wheel motion.
		/// </summary>
		// Token: 0x06000F2F RID: 3887 RVA: 0x0001BE53 File Offset: 0x0001A053
		public virtual void SetMouseWheelMotionFactor(double _arg)
		{
			vtkInteractorStyle.vtkInteractorStyle_SetMouseWheelMotionFactor_102(base.GetCppThis(), _arg);
		}

		// Token: 0x06000F30 RID: 3888
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_SetPickColor_103(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the pick color (used by default to color vtkActor2D's).
		/// The color is expressed as red/green/blue values between (0.0,1.0).
		/// </summary>
		// Token: 0x06000F31 RID: 3889 RVA: 0x0001BE63 File Offset: 0x0001A063
		public virtual void SetPickColor(double _arg1, double _arg2, double _arg3)
		{
			vtkInteractorStyle.vtkInteractorStyle_SetPickColor_103(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06000F32 RID: 3890
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_SetPickColor_104(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the pick color (used by default to color vtkActor2D's).
		/// The color is expressed as red/green/blue values between (0.0,1.0).
		/// </summary>
		// Token: 0x06000F33 RID: 3891 RVA: 0x0001BE75 File Offset: 0x0001A075
		public virtual void SetPickColor(IntPtr _arg)
		{
			vtkInteractorStyle.vtkInteractorStyle_SetPickColor_104(base.GetCppThis(), _arg);
		}

		// Token: 0x06000F34 RID: 3892
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_SetTDxStyle_105(HandleRef pThis, HandleRef tdxStyle);

		/// <summary>
		/// 3Dconnexion device interactor style. Initial value is a pointer to an
		/// object of class vtkTdxInteractorStyleCamera.
		/// </summary>
		// Token: 0x06000F35 RID: 3893 RVA: 0x0001BE88 File Offset: 0x0001A088
		public virtual void SetTDxStyle(vtkTDxInteractorStyle tdxStyle)
		{
			vtkInteractorStyle.vtkInteractorStyle_SetTDxStyle_105(base.GetCppThis(), (tdxStyle == null) ? default(HandleRef) : tdxStyle.GetCppThis());
		}

		// Token: 0x06000F36 RID: 3894
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_SetTimerDuration_106(HandleRef pThis, uint _arg);

		/// <summary>
		/// If using timers, specify the default timer interval (in
		/// milliseconds). Care must be taken when adjusting the timer interval from
		/// the default value of 10 milliseconds--it may adversely affect the
		/// interactors.
		/// </summary>
		// Token: 0x06000F37 RID: 3895 RVA: 0x0001BEB7 File Offset: 0x0001A0B7
		public virtual void SetTimerDuration(uint _arg)
		{
			vtkInteractorStyle.vtkInteractorStyle_SetTimerDuration_106(base.GetCppThis(), _arg);
		}

		// Token: 0x06000F38 RID: 3896
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_SetUseTimers_107(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get timer hint
		/// </summary>
		// Token: 0x06000F39 RID: 3897 RVA: 0x0001BEC7 File Offset: 0x0001A0C7
		public virtual void SetUseTimers(int _arg)
		{
			vtkInteractorStyle.vtkInteractorStyle_SetUseTimers_107(base.GetCppThis(), _arg);
		}

		// Token: 0x06000F3A RID: 3898
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_Spin_108(HandleRef pThis);

		/// <summary>
		/// These methods for the different interactions in different modes
		/// are overridden in subclasses to perform the correct motion. Since
		/// they might be called from OnTimer, they do not have mouse coord parameters
		/// (use interactor's GetEventPosition and GetLastEventPosition)
		/// </summary>
		// Token: 0x06000F3B RID: 3899 RVA: 0x0001BED7 File Offset: 0x0001A0D7
		public virtual void Spin()
		{
			vtkInteractorStyle.vtkInteractorStyle_Spin_108(base.GetCppThis());
		}

		// Token: 0x06000F3C RID: 3900
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_StartAnimate_109(HandleRef pThis);

		/// <summary>
		/// Interaction mode entry points used internally.
		/// </summary>
		// Token: 0x06000F3D RID: 3901 RVA: 0x0001BEE6 File Offset: 0x0001A0E6
		public virtual void StartAnimate()
		{
			vtkInteractorStyle.vtkInteractorStyle_StartAnimate_109(base.GetCppThis());
		}

		// Token: 0x06000F3E RID: 3902
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_StartDolly_110(HandleRef pThis);

		/// <summary>
		/// Interaction mode entry points used internally.
		/// </summary>
		// Token: 0x06000F3F RID: 3903 RVA: 0x0001BEF5 File Offset: 0x0001A0F5
		public virtual void StartDolly()
		{
			vtkInteractorStyle.vtkInteractorStyle_StartDolly_110(base.GetCppThis());
		}

		// Token: 0x06000F40 RID: 3904
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_StartEnvRotate_111(HandleRef pThis);

		/// <summary>
		/// Interaction mode entry points used internally.
		/// </summary>
		// Token: 0x06000F41 RID: 3905 RVA: 0x0001BF04 File Offset: 0x0001A104
		public virtual void StartEnvRotate()
		{
			vtkInteractorStyle.vtkInteractorStyle_StartEnvRotate_111(base.GetCppThis());
		}

		// Token: 0x06000F42 RID: 3906
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_StartGesture_112(HandleRef pThis);

		/// <summary>
		/// Interaction mode entry points used internally.
		/// </summary>
		// Token: 0x06000F43 RID: 3907 RVA: 0x0001BF13 File Offset: 0x0001A113
		public virtual void StartGesture()
		{
			vtkInteractorStyle.vtkInteractorStyle_StartGesture_112(base.GetCppThis());
		}

		// Token: 0x06000F44 RID: 3908
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_StartPan_113(HandleRef pThis);

		/// <summary>
		/// Interaction mode entry points used internally.
		/// </summary>
		// Token: 0x06000F45 RID: 3909 RVA: 0x0001BF22 File Offset: 0x0001A122
		public virtual void StartPan()
		{
			vtkInteractorStyle.vtkInteractorStyle_StartPan_113(base.GetCppThis());
		}

		// Token: 0x06000F46 RID: 3910
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_StartRotate_114(HandleRef pThis);

		/// <summary>
		/// Interaction mode entry points used internally.
		/// </summary>
		// Token: 0x06000F47 RID: 3911 RVA: 0x0001BF31 File Offset: 0x0001A131
		public virtual void StartRotate()
		{
			vtkInteractorStyle.vtkInteractorStyle_StartRotate_114(base.GetCppThis());
		}

		// Token: 0x06000F48 RID: 3912
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_StartSpin_115(HandleRef pThis);

		/// <summary>
		/// Interaction mode entry points used internally.
		/// </summary>
		// Token: 0x06000F49 RID: 3913 RVA: 0x0001BF40 File Offset: 0x0001A140
		public virtual void StartSpin()
		{
			vtkInteractorStyle.vtkInteractorStyle_StartSpin_115(base.GetCppThis());
		}

		// Token: 0x06000F4A RID: 3914
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_StartState_116(HandleRef pThis, int newstate);

		/// <summary>
		/// utility routines used by state changes
		/// </summary>
		// Token: 0x06000F4B RID: 3915 RVA: 0x0001BF4F File Offset: 0x0001A14F
		public virtual void StartState(int newstate)
		{
			vtkInteractorStyle.vtkInteractorStyle_StartState_116(base.GetCppThis(), newstate);
		}

		// Token: 0x06000F4C RID: 3916
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_StartTimer_117(HandleRef pThis);

		/// <summary>
		/// Interaction mode entry points used internally.
		/// </summary>
		// Token: 0x06000F4D RID: 3917 RVA: 0x0001BF5F File Offset: 0x0001A15F
		public virtual void StartTimer()
		{
			vtkInteractorStyle.vtkInteractorStyle_StartTimer_117(base.GetCppThis());
		}

		// Token: 0x06000F4E RID: 3918
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_StartTwoPointer_118(HandleRef pThis);

		/// <summary>
		/// Interaction mode entry points used internally.
		/// </summary>
		// Token: 0x06000F4F RID: 3919 RVA: 0x0001BF6E File Offset: 0x0001A16E
		public virtual void StartTwoPointer()
		{
			vtkInteractorStyle.vtkInteractorStyle_StartTwoPointer_118(base.GetCppThis());
		}

		// Token: 0x06000F50 RID: 3920
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_StartUniformScale_119(HandleRef pThis);

		/// <summary>
		/// Interaction mode entry points used internally.
		/// </summary>
		// Token: 0x06000F51 RID: 3921 RVA: 0x0001BF7D File Offset: 0x0001A17D
		public virtual void StartUniformScale()
		{
			vtkInteractorStyle.vtkInteractorStyle_StartUniformScale_119(base.GetCppThis());
		}

		// Token: 0x06000F52 RID: 3922
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_StartZoom_120(HandleRef pThis);

		/// <summary>
		/// Interaction mode entry points used internally.
		/// </summary>
		// Token: 0x06000F53 RID: 3923 RVA: 0x0001BF8C File Offset: 0x0001A18C
		public virtual void StartZoom()
		{
			vtkInteractorStyle.vtkInteractorStyle_StartZoom_120(base.GetCppThis());
		}

		// Token: 0x06000F54 RID: 3924
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_StopAnimate_121(HandleRef pThis);

		/// <summary>
		/// Interaction mode entry points used internally.
		/// </summary>
		// Token: 0x06000F55 RID: 3925 RVA: 0x0001BF9B File Offset: 0x0001A19B
		public virtual void StopAnimate()
		{
			vtkInteractorStyle.vtkInteractorStyle_StopAnimate_121(base.GetCppThis());
		}

		// Token: 0x06000F56 RID: 3926
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_StopState_122(HandleRef pThis);

		/// <summary>
		/// utility routines used by state changes
		/// </summary>
		// Token: 0x06000F57 RID: 3927 RVA: 0x0001BFAA File Offset: 0x0001A1AA
		public virtual void StopState()
		{
			vtkInteractorStyle.vtkInteractorStyle_StopState_122(base.GetCppThis());
		}

		// Token: 0x06000F58 RID: 3928
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_UniformScale_123(HandleRef pThis);

		/// <summary>
		/// These methods for the different interactions in different modes
		/// are overridden in subclasses to perform the correct motion. Since
		/// they might be called from OnTimer, they do not have mouse coord parameters
		/// (use interactor's GetEventPosition and GetLastEventPosition)
		/// </summary>
		// Token: 0x06000F59 RID: 3929 RVA: 0x0001BFB9 File Offset: 0x0001A1B9
		public virtual void UniformScale()
		{
			vtkInteractorStyle.vtkInteractorStyle_UniformScale_123(base.GetCppThis());
		}

		// Token: 0x06000F5A RID: 3930
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_UseTimersOff_124(HandleRef pThis);

		/// <summary>
		/// Set/Get timer hint
		/// </summary>
		// Token: 0x06000F5B RID: 3931 RVA: 0x0001BFC8 File Offset: 0x0001A1C8
		public virtual void UseTimersOff()
		{
			vtkInteractorStyle.vtkInteractorStyle_UseTimersOff_124(base.GetCppThis());
		}

		// Token: 0x06000F5C RID: 3932
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_UseTimersOn_125(HandleRef pThis);

		/// <summary>
		/// Set/Get timer hint
		/// </summary>
		// Token: 0x06000F5D RID: 3933 RVA: 0x0001BFD7 File Offset: 0x0001A1D7
		public virtual void UseTimersOn()
		{
			vtkInteractorStyle.vtkInteractorStyle_UseTimersOn_125(base.GetCppThis());
		}

		// Token: 0x06000F5E RID: 3934
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyle_Zoom_126(HandleRef pThis);

		/// <summary>
		/// These methods for the different interactions in different modes
		/// are overridden in subclasses to perform the correct motion. Since
		/// they might be called from OnTimer, they do not have mouse coord parameters
		/// (use interactor's GetEventPosition and GetLastEventPosition)
		/// </summary>
		// Token: 0x06000F5F RID: 3935 RVA: 0x0001BFE6 File Offset: 0x0001A1E6
		public virtual void Zoom()
		{
			vtkInteractorStyle.vtkInteractorStyle_Zoom_126(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400042A RID: 1066
		public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyle";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400042B RID: 1067
		public new static readonly string MRClassNameKey = "class vtkInteractorStyle";
	}
}
