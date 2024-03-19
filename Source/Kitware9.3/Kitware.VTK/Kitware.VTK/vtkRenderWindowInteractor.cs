using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRenderWindowInteractor
	/// </summary>
	/// <remarks>
	///    platform-independent render window
	/// interaction including picking and frame rate control.
	///
	///
	/// vtkRenderWindowInteractor provides a platform-independent interaction
	/// mechanism for mouse/key/time events. It serves as a base class for
	/// platform-dependent implementations that handle routing of mouse/key/timer
	/// messages to vtkInteractorObserver and its subclasses. vtkRenderWindowInteractor
	/// also provides controls for picking, rendering frame rate, and headlights.
	///
	/// vtkRenderWindowInteractor has changed from previous implementations and
	/// now serves only as a shell to hold user preferences and route messages to
	/// vtkInteractorStyle. Callbacks are available for many events.  Platform
	/// specific subclasses should provide methods for manipulating timers,
	/// TerminateApp, and an event loop if required via
	/// Initialize/Start/Enable/Disable.
	///
	/// @warning
	/// vtkRenderWindowInteractor routes events through VTK's command/observer
	/// design pattern. That is, when vtkRenderWindowInteractor (actually, one of
	/// its subclasses) sees a platform-dependent event, it translates this into
	/// a VTK event using the InvokeEvent() method. Then any vtkInteractorObservers
	/// registered for that event are expected to respond as appropriate.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkInteractorObserver
	/// </seealso>
	// Token: 0x02000099 RID: 153
	public class vtkRenderWindowInteractor : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06001F27 RID: 7975 RVA: 0x0002FF58 File Offset: 0x0002E158
		static vtkRenderWindowInteractor()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRenderWindowInteractor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRenderWindowInteractor"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06001F28 RID: 7976 RVA: 0x0002FF80 File Offset: 0x0002E180
		public vtkRenderWindowInteractor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06001F29 RID: 7977
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindowInteractor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001F2A RID: 7978 RVA: 0x0002FF90 File Offset: 0x0002E190
		public new static vtkRenderWindowInteractor New()
		{
			vtkRenderWindowInteractor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderWindowInteractor.vtkRenderWindowInteractor_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001F2B RID: 7979 RVA: 0x0002FFE4 File Offset: 0x0002E1E4
		public vtkRenderWindowInteractor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRenderWindowInteractor.vtkRenderWindowInteractor_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		// Token: 0x06001F2C RID: 7980
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_UnRegister_191(HandleRef pThis, HandleRef o);

		/// <summary>
		/// This Method detects loops of RenderWindow-Interactor,
		/// so objects are freed properly.
		/// </summary>
		// Token: 0x06001F2D RID: 7981 RVA: 0x00030028 File Offset: 0x0002E228
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (base.GetCallDisposalMethod())
				{
					vtkRenderWindowInteractor.vtkRenderWindowInteractor_UnRegister_191(base.GetCppThis(), default(HandleRef));
					base.ClearCppThis();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06001F2E RID: 7982
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_CharEvent_01(HandleRef pThis);

		/// <summary>
		/// Fire various events. SetEventInformation should be called just prior
		/// to calling any of these methods. These methods will Invoke the
		/// corresponding vtk event.
		/// </summary>
		// Token: 0x06001F2F RID: 7983 RVA: 0x00030084 File Offset: 0x0002E284
		public virtual void CharEvent()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_CharEvent_01(base.GetCppThis());
		}

		// Token: 0x06001F30 RID: 7984
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_ClearContact_02(HandleRef pThis, ulong contactID);

		/// <summary>
		/// Most multitouch systems use persistent contact/pointer ids to
		/// track events/motion during multitouch events. We keep an array
		/// that maps these system dependent contact ids to our pointer index
		/// These functions return -1 if the ID is not found or if there
		/// is no more room for contacts
		/// </summary>
		// Token: 0x06001F31 RID: 7985 RVA: 0x00030093 File Offset: 0x0002E293
		public void ClearContact(ulong contactID)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_ClearContact_02(base.GetCppThis(), contactID);
		}

		// Token: 0x06001F32 RID: 7986
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_ClearPointerIndex_03(HandleRef pThis, int i);

		/// <summary>
		/// Most multitouch systems use persistent contact/pointer ids to
		/// track events/motion during multitouch events. We keep an array
		/// that maps these system dependent contact ids to our pointer index
		/// These functions return -1 if the ID is not found or if there
		/// is no more room for contacts
		/// </summary>
		// Token: 0x06001F33 RID: 7987 RVA: 0x000300A3 File Offset: 0x0002E2A3
		public void ClearPointerIndex(int i)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_ClearPointerIndex_03(base.GetCppThis(), i);
		}

		// Token: 0x06001F34 RID: 7988
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_ConfigureEvent_04(HandleRef pThis);

		/// <summary>
		/// Fire various events. SetEventInformation should be called just prior
		/// to calling any of these methods. These methods will Invoke the
		/// corresponding vtk event.
		/// </summary>
		// Token: 0x06001F35 RID: 7989 RVA: 0x000300B3 File Offset: 0x0002E2B3
		public virtual void ConfigureEvent()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_ConfigureEvent_04(base.GetCppThis());
		}

		// Token: 0x06001F36 RID: 7990
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindowInteractor_CreateDefaultPicker_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create default picker. Used to create one when none is specified.
		/// Default is an instance of vtkPropPicker.
		/// </summary>
		// Token: 0x06001F37 RID: 7991 RVA: 0x000300C4 File Offset: 0x0002E2C4
		public virtual vtkAbstractPropPicker CreateDefaultPicker()
		{
			vtkAbstractPropPicker vtkAbstractPropPicker = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderWindowInteractor.vtkRenderWindowInteractor_CreateDefaultPicker_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractPropPicker = (vtkAbstractPropPicker)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractPropPicker.Register(null);
				}
			}
			return vtkAbstractPropPicker;
		}

		// Token: 0x06001F38 RID: 7992
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindowInteractor_CreateOneShotTimer_06(HandleRef pThis, uint duration);

		/// <summary>
		/// Create a one shot timer, with the specified duration (in milliseconds).
		/// \return the timer id.
		/// </summary>
		// Token: 0x06001F39 RID: 7993 RVA: 0x00030134 File Offset: 0x0002E334
		public int CreateOneShotTimer(uint duration)
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_CreateOneShotTimer_06(base.GetCppThis(), duration);
		}

		// Token: 0x06001F3A RID: 7994
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindowInteractor_CreateRepeatingTimer_07(HandleRef pThis, uint duration);

		/// <summary>
		/// Create a repeating timer, with the specified duration (in milliseconds).
		/// \return the timer id.
		/// </summary>
		// Token: 0x06001F3B RID: 7995 RVA: 0x00030154 File Offset: 0x0002E354
		public int CreateRepeatingTimer(uint duration)
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_CreateRepeatingTimer_07(base.GetCppThis(), duration);
		}

		// Token: 0x06001F3C RID: 7996
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindowInteractor_CreateTimer_08(HandleRef pThis, int timerType);

		/// <summary>
		/// This class provides two groups of methods for manipulating timers.  The
		/// first group (CreateTimer(timerType) and DestroyTimer()) implicitly use
		/// an internal timer id (and are present for backward compatibility). The
		/// second group (CreateRepeatingTimer(long),CreateOneShotTimer(long),
		/// ResetTimer(int),DestroyTimer(int)) use timer ids so multiple timers can
		/// be independently managed. In the first group, the CreateTimer() method
		/// takes an argument indicating whether the timer is created the first time
		/// (timerType==VTKI_TIMER_FIRST) or whether it is being reset
		/// (timerType==VTKI_TIMER_UPDATE). (In initial implementations of VTK this
		/// was how one shot and repeating timers were managed.) In the second
		/// group, the create methods take a timer duration argument (in
		/// milliseconds) and return a timer id. Thus the ResetTimer(timerId) and
		/// DestroyTimer(timerId) methods take this timer id and operate on the
		/// timer as appropriate. Methods are also available for determining
		/// </summary>
		// Token: 0x06001F3D RID: 7997 RVA: 0x00030174 File Offset: 0x0002E374
		public virtual int CreateTimer(int timerType)
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_CreateTimer_08(base.GetCppThis(), timerType);
		}

		// Token: 0x06001F3E RID: 7998
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindowInteractor_DestroyTimer_09(HandleRef pThis);

		/// <summary>
		/// This class provides two groups of methods for manipulating timers.  The
		/// first group (CreateTimer(timerType) and DestroyTimer()) implicitly use
		/// an internal timer id (and are present for backward compatibility). The
		/// second group (CreateRepeatingTimer(long),CreateOneShotTimer(long),
		/// ResetTimer(int),DestroyTimer(int)) use timer ids so multiple timers can
		/// be independently managed. In the first group, the CreateTimer() method
		/// takes an argument indicating whether the timer is created the first time
		/// (timerType==VTKI_TIMER_FIRST) or whether it is being reset
		/// (timerType==VTKI_TIMER_UPDATE). (In initial implementations of VTK this
		/// was how one shot and repeating timers were managed.) In the second
		/// group, the create methods take a timer duration argument (in
		/// milliseconds) and return a timer id. Thus the ResetTimer(timerId) and
		/// DestroyTimer(timerId) methods take this timer id and operate on the
		/// timer as appropriate. Methods are also available for determining
		/// </summary>
		// Token: 0x06001F3F RID: 7999 RVA: 0x00030194 File Offset: 0x0002E394
		public virtual int DestroyTimer()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_DestroyTimer_09(base.GetCppThis());
		}

		// Token: 0x06001F40 RID: 8000
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindowInteractor_DestroyTimer_10(HandleRef pThis, int timerId);

		/// <summary>
		/// Destroy the timer specified by timerId.
		/// \return 1 if the timer was destroyed.
		/// </summary>
		// Token: 0x06001F41 RID: 8001 RVA: 0x000301B4 File Offset: 0x0002E3B4
		public int DestroyTimer(int timerId)
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_DestroyTimer_10(base.GetCppThis(), timerId);
		}

		// Token: 0x06001F42 RID: 8002
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_Disable_11(HandleRef pThis);

		/// <summary>
		/// Enable/Disable interactions.  By default interactors are enabled when
		/// initialized.  Initialize() must be called prior to enabling/disabling
		/// interaction. These methods are used when a window/widget is being
		/// shared by multiple renderers and interactors.  This allows a "modal"
		/// display where one interactor is active when its data is to be displayed
		/// and all other interactors associated with the widget are disabled
		/// when their data is not displayed.
		/// </summary>
		// Token: 0x06001F43 RID: 8003 RVA: 0x000301D4 File Offset: 0x0002E3D4
		public virtual void Disable()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_Disable_11(base.GetCppThis());
		}

		// Token: 0x06001F44 RID: 8004
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_Enable_12(HandleRef pThis);

		/// <summary>
		/// Enable/Disable interactions.  By default interactors are enabled when
		/// initialized.  Initialize() must be called prior to enabling/disabling
		/// interaction. These methods are used when a window/widget is being
		/// shared by multiple renderers and interactors.  This allows a "modal"
		/// display where one interactor is active when its data is to be displayed
		/// and all other interactors associated with the widget are disabled
		/// when their data is not displayed.
		/// </summary>
		// Token: 0x06001F45 RID: 8005 RVA: 0x000301E3 File Offset: 0x0002E3E3
		public virtual void Enable()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_Enable_12(base.GetCppThis());
		}

		// Token: 0x06001F46 RID: 8006
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_EnableRenderOff_13(HandleRef pThis);

		/// <summary>
		/// Enable/Disable whether vtkRenderWindowInteractor::Render() calls
		/// this-&gt;RenderWindow-&gt;Render().
		/// </summary>
		// Token: 0x06001F47 RID: 8007 RVA: 0x000301F2 File Offset: 0x0002E3F2
		public virtual void EnableRenderOff()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_EnableRenderOff_13(base.GetCppThis());
		}

		// Token: 0x06001F48 RID: 8008
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_EnableRenderOn_14(HandleRef pThis);

		/// <summary>
		/// Enable/Disable whether vtkRenderWindowInteractor::Render() calls
		/// this-&gt;RenderWindow-&gt;Render().
		/// </summary>
		// Token: 0x06001F49 RID: 8009 RVA: 0x00030201 File Offset: 0x0002E401
		public virtual void EnableRenderOn()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_EnableRenderOn_14(base.GetCppThis());
		}

		// Token: 0x06001F4A RID: 8010
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_EndPanEvent_15(HandleRef pThis);

		/// <summary>
		/// Fire various gesture based events.  These methods will Invoke the
		/// corresponding vtk event.
		/// </summary>
		// Token: 0x06001F4B RID: 8011 RVA: 0x00030210 File Offset: 0x0002E410
		public virtual void EndPanEvent()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_EndPanEvent_15(base.GetCppThis());
		}

		// Token: 0x06001F4C RID: 8012
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_EndPickCallback_16(HandleRef pThis);

		/// <summary>
		/// These methods correspond to the Exit, User and Pick
		/// callbacks. They allow for the Style to invoke them.
		/// </summary>
		// Token: 0x06001F4D RID: 8013 RVA: 0x0003021F File Offset: 0x0002E41F
		public virtual void EndPickCallback()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_EndPickCallback_16(base.GetCppThis());
		}

		// Token: 0x06001F4E RID: 8014
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_EndPinchEvent_17(HandleRef pThis);

		/// <summary>
		/// Fire various gesture based events.  These methods will Invoke the
		/// corresponding vtk event.
		/// </summary>
		// Token: 0x06001F4F RID: 8015 RVA: 0x0003022E File Offset: 0x0002E42E
		public virtual void EndPinchEvent()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_EndPinchEvent_17(base.GetCppThis());
		}

		// Token: 0x06001F50 RID: 8016
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_EndRotateEvent_18(HandleRef pThis);

		/// <summary>
		/// Fire various gesture based events.  These methods will Invoke the
		/// corresponding vtk event.
		/// </summary>
		// Token: 0x06001F51 RID: 8017 RVA: 0x0003023D File Offset: 0x0002E43D
		public virtual void EndRotateEvent()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_EndRotateEvent_18(base.GetCppThis());
		}

		// Token: 0x06001F52 RID: 8018
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_EnterEvent_19(HandleRef pThis);

		/// <summary>
		/// Fire various events. SetEventInformation should be called just prior
		/// to calling any of these methods. These methods will Invoke the
		/// corresponding vtk event.
		/// </summary>
		// Token: 0x06001F53 RID: 8019 RVA: 0x0003024C File Offset: 0x0002E44C
		public virtual void EnterEvent()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_EnterEvent_19(base.GetCppThis());
		}

		// Token: 0x06001F54 RID: 8020
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_ExitCallback_20(HandleRef pThis);

		/// <summary>
		/// These methods correspond to the Exit, User and Pick
		/// callbacks. They allow for the Style to invoke them.
		/// </summary>
		// Token: 0x06001F55 RID: 8021 RVA: 0x0003025B File Offset: 0x0002E45B
		public virtual void ExitCallback()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_ExitCallback_20(base.GetCppThis());
		}

		// Token: 0x06001F56 RID: 8022
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_ExitEvent_21(HandleRef pThis);

		/// <summary>
		/// Fire various events. SetEventInformation should be called just prior
		/// to calling any of these methods. These methods will Invoke the
		/// corresponding vtk event.
		/// </summary>
		// Token: 0x06001F57 RID: 8023 RVA: 0x0003026A File Offset: 0x0002E46A
		public virtual void ExitEvent()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_ExitEvent_21(base.GetCppThis());
		}

		// Token: 0x06001F58 RID: 8024
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_ExposeEvent_22(HandleRef pThis);

		/// <summary>
		/// Fire various events. SetEventInformation should be called just prior
		/// to calling any of these methods. These methods will Invoke the
		/// corresponding vtk event.
		/// </summary>
		// Token: 0x06001F59 RID: 8025 RVA: 0x00030279 File Offset: 0x0002E479
		public virtual void ExposeEvent()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_ExposeEvent_22(base.GetCppThis());
		}

		// Token: 0x06001F5A RID: 8026
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_FifthButtonPressEvent_23(HandleRef pThis);

		/// <summary>
		/// Fire various events. SetEventInformation should be called just prior
		/// to calling any of these methods. These methods will Invoke the
		/// corresponding vtk event.
		/// </summary>
		// Token: 0x06001F5B RID: 8027 RVA: 0x00030288 File Offset: 0x0002E488
		public virtual void FifthButtonPressEvent()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_FifthButtonPressEvent_23(base.GetCppThis());
		}

		// Token: 0x06001F5C RID: 8028
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_FifthButtonReleaseEvent_24(HandleRef pThis);

		/// <summary>
		/// Fire various events. SetEventInformation should be called just prior
		/// to calling any of these methods. These methods will Invoke the
		/// corresponding vtk event.
		/// </summary>
		// Token: 0x06001F5D RID: 8029 RVA: 0x00030297 File Offset: 0x0002E497
		public virtual void FifthButtonReleaseEvent()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_FifthButtonReleaseEvent_24(base.GetCppThis());
		}

		// Token: 0x06001F5E RID: 8030
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindowInteractor_FindPokedRenderer_25(HandleRef pThis, int arg0, int arg1, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// When an event occurs, we must determine which Renderer the event
		/// occurred within, since one RenderWindow may contain multiple
		/// renderers.
		/// </summary>
		// Token: 0x06001F5F RID: 8031 RVA: 0x000302A8 File Offset: 0x0002E4A8
		public virtual vtkRenderer FindPokedRenderer(int arg0, int arg1)
		{
			vtkRenderer vtkRenderer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderWindowInteractor.vtkRenderWindowInteractor_FindPokedRenderer_25(base.GetCppThis(), arg0, arg1, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderer = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderer.Register(null);
				}
			}
			return vtkRenderer;
		}

		// Token: 0x06001F60 RID: 8032
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_FlyTo_26(HandleRef pThis, HandleRef ren, double x, double y, double z);

		/// <summary>
		/// Given a position x, move the current camera's focal point to x.
		/// The movement is animated over the number of frames specified in
		/// NumberOfFlyFrames. The LOD desired frame rate is used.
		/// </summary>
		// Token: 0x06001F61 RID: 8033 RVA: 0x0003031C File Offset: 0x0002E51C
		public void FlyTo(vtkRenderer ren, double x, double y, double z)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_FlyTo_26(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), x, y, z);
		}

		// Token: 0x06001F62 RID: 8034
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_FlyTo_27(HandleRef pThis, HandleRef ren, IntPtr x);

		/// <summary>
		/// Given a position x, move the current camera's focal point to x.
		/// The movement is animated over the number of frames specified in
		/// NumberOfFlyFrames. The LOD desired frame rate is used.
		/// </summary>
		// Token: 0x06001F63 RID: 8035 RVA: 0x00030350 File Offset: 0x0002E550
		public void FlyTo(vtkRenderer ren, IntPtr x)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_FlyTo_27(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), x);
		}

		// Token: 0x06001F64 RID: 8036
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_FlyToImage_28(HandleRef pThis, HandleRef ren, double x, double y);

		/// <summary>
		/// Given a position x, move the current camera's focal point to x.
		/// The movement is animated over the number of frames specified in
		/// NumberOfFlyFrames. The LOD desired frame rate is used.
		/// </summary>
		// Token: 0x06001F65 RID: 8037 RVA: 0x00030380 File Offset: 0x0002E580
		public void FlyToImage(vtkRenderer ren, double x, double y)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_FlyToImage_28(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), x, y);
		}

		// Token: 0x06001F66 RID: 8038
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_FlyToImage_29(HandleRef pThis, HandleRef ren, IntPtr x);

		/// <summary>
		/// Given a position x, move the current camera's focal point to x.
		/// The movement is animated over the number of frames specified in
		/// NumberOfFlyFrames. The LOD desired frame rate is used.
		/// </summary>
		// Token: 0x06001F67 RID: 8039 RVA: 0x000303B4 File Offset: 0x0002E5B4
		public void FlyToImage(vtkRenderer ren, IntPtr x)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_FlyToImage_29(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), x);
		}

		// Token: 0x06001F68 RID: 8040
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_FourthButtonPressEvent_30(HandleRef pThis);

		/// <summary>
		/// Fire various events. SetEventInformation should be called just prior
		/// to calling any of these methods. These methods will Invoke the
		/// corresponding vtk event.
		/// </summary>
		// Token: 0x06001F69 RID: 8041 RVA: 0x000303E4 File Offset: 0x0002E5E4
		public virtual void FourthButtonPressEvent()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_FourthButtonPressEvent_30(base.GetCppThis());
		}

		// Token: 0x06001F6A RID: 8042
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_FourthButtonReleaseEvent_31(HandleRef pThis);

		/// <summary>
		/// Fire various events. SetEventInformation should be called just prior
		/// to calling any of these methods. These methods will Invoke the
		/// corresponding vtk event.
		/// </summary>
		// Token: 0x06001F6B RID: 8043 RVA: 0x000303F3 File Offset: 0x0002E5F3
		public virtual void FourthButtonReleaseEvent()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_FourthButtonReleaseEvent_31(base.GetCppThis());
		}

		// Token: 0x06001F6C RID: 8044
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindowInteractor_GetAltKey_32(HandleRef pThis);

		/// <summary>
		/// Set/get whether alt modifier key was pressed.
		/// </summary>
		// Token: 0x06001F6D RID: 8045 RVA: 0x00030404 File Offset: 0x0002E604
		public virtual int GetAltKey()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetAltKey_32(base.GetCppThis());
		}

		// Token: 0x06001F6E RID: 8046
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindowInteractor_GetControlKey_33(HandleRef pThis);

		/// <summary>
		/// Set/get whether control modifier key was pressed.
		/// </summary>
		// Token: 0x06001F6F RID: 8047 RVA: 0x00030424 File Offset: 0x0002E624
		public virtual int GetControlKey()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetControlKey_33(base.GetCppThis());
		}

		// Token: 0x06001F70 RID: 8048
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRenderWindowInteractor_GetDesiredUpdateRate_34(HandleRef pThis);

		/// <summary>
		/// Set/Get the desired update rate. This is used by vtkLODActor's to tell
		/// them how quickly they need to render.  This update is in effect only
		/// when the camera is being rotated, or zoomed.  When the interactor is
		/// still, the StillUpdateRate is used instead.
		/// The default is 15.
		/// </summary>
		// Token: 0x06001F71 RID: 8049 RVA: 0x00030444 File Offset: 0x0002E644
		public virtual double GetDesiredUpdateRate()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetDesiredUpdateRate_34(base.GetCppThis());
		}

		// Token: 0x06001F72 RID: 8050
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRenderWindowInteractor_GetDesiredUpdateRateMaxValue_35(HandleRef pThis);

		/// <summary>
		/// Set/Get the desired update rate. This is used by vtkLODActor's to tell
		/// them how quickly they need to render.  This update is in effect only
		/// when the camera is being rotated, or zoomed.  When the interactor is
		/// still, the StillUpdateRate is used instead.
		/// The default is 15.
		/// </summary>
		// Token: 0x06001F73 RID: 8051 RVA: 0x00030464 File Offset: 0x0002E664
		public virtual double GetDesiredUpdateRateMaxValue()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetDesiredUpdateRateMaxValue_35(base.GetCppThis());
		}

		// Token: 0x06001F74 RID: 8052
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRenderWindowInteractor_GetDesiredUpdateRateMinValue_36(HandleRef pThis);

		/// <summary>
		/// Set/Get the desired update rate. This is used by vtkLODActor's to tell
		/// them how quickly they need to render.  This update is in effect only
		/// when the camera is being rotated, or zoomed.  When the interactor is
		/// still, the StillUpdateRate is used instead.
		/// The default is 15.
		/// </summary>
		// Token: 0x06001F75 RID: 8053 RVA: 0x00030484 File Offset: 0x0002E684
		public virtual double GetDesiredUpdateRateMinValue()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetDesiredUpdateRateMinValue_36(base.GetCppThis());
		}

		// Token: 0x06001F76 RID: 8054
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRenderWindowInteractor_GetDolly_37(HandleRef pThis);

		/// <summary>
		/// Set the total Dolly value to use when flying to (FlyTo()) a
		/// specified point. Negative values fly away from the point.
		/// </summary>
		// Token: 0x06001F77 RID: 8055 RVA: 0x000304A4 File Offset: 0x0002E6A4
		public virtual double GetDolly()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetDolly_37(base.GetCppThis());
		}

		// Token: 0x06001F78 RID: 8056
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderWindowInteractor_GetDone_38(HandleRef pThis);

		/// <summary>
		/// Is the interactor loop done
		/// </summary>
		// Token: 0x06001F79 RID: 8057 RVA: 0x000304C4 File Offset: 0x0002E6C4
		public virtual bool GetDone()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetDone_38(base.GetCppThis()) != 0;
		}

		// Token: 0x06001F7A RID: 8058
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderWindowInteractor_GetEnableRender_39(HandleRef pThis);

		/// <summary>
		/// Enable/Disable whether vtkRenderWindowInteractor::Render() calls
		/// this-&gt;RenderWindow-&gt;Render().
		/// </summary>
		// Token: 0x06001F7B RID: 8059 RVA: 0x000304EC File Offset: 0x0002E6EC
		public virtual bool GetEnableRender()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetEnableRender_39(base.GetCppThis()) != 0;
		}

		// Token: 0x06001F7C RID: 8060
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindowInteractor_GetEnabled_40(HandleRef pThis);

		/// <summary>
		/// Enable/Disable interactions.  By default interactors are enabled when
		/// initialized.  Initialize() must be called prior to enabling/disabling
		/// interaction. These methods are used when a window/widget is being
		/// shared by multiple renderers and interactors.  This allows a "modal"
		/// display where one interactor is active when its data is to be displayed
		/// and all other interactors associated with the widget are disabled
		/// when their data is not displayed.
		/// </summary>
		// Token: 0x06001F7D RID: 8061 RVA: 0x00030514 File Offset: 0x0002E714
		public virtual int GetEnabled()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetEnabled_40(base.GetCppThis());
		}

		// Token: 0x06001F7E RID: 8062
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindowInteractor_GetEventPosition_41(HandleRef pThis);

		/// <summary>
		/// Set/Get information about the current event.
		/// The current x,y position is in the EventPosition, and the previous
		/// event position is in LastEventPosition, updated automatically each
		/// time EventPosition is set using its Set() method. Mouse positions
		/// are measured in pixels.
		/// The other information is about key board input.
		/// </summary>
		// Token: 0x06001F7F RID: 8063 RVA: 0x00030534 File Offset: 0x0002E734
		public virtual int[] GetEventPosition()
		{
			IntPtr intPtr = vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetEventPosition_41(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06001F80 RID: 8064
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_GetEventPosition_42(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Set/Get information about the current event.
		/// The current x,y position is in the EventPosition, and the previous
		/// event position is in LastEventPosition, updated automatically each
		/// time EventPosition is set using its Set() method. Mouse positions
		/// are measured in pixels.
		/// The other information is about key board input.
		/// </summary>
		// Token: 0x06001F81 RID: 8065 RVA: 0x0003057C File Offset: 0x0002E77C
		public virtual void GetEventPosition(ref int _arg1, ref int _arg2)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetEventPosition_42(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06001F82 RID: 8066
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_GetEventPosition_43(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get information about the current event.
		/// The current x,y position is in the EventPosition, and the previous
		/// event position is in LastEventPosition, updated automatically each
		/// time EventPosition is set using its Set() method. Mouse positions
		/// are measured in pixels.
		/// The other information is about key board input.
		/// </summary>
		// Token: 0x06001F83 RID: 8067 RVA: 0x0003058D File Offset: 0x0002E78D
		public virtual void GetEventPosition(IntPtr _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetEventPosition_43(base.GetCppThis(), _arg);
		}

		// Token: 0x06001F84 RID: 8068
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindowInteractor_GetEventPositions_44(HandleRef pThis, int pointerIndex);

		/// <summary>
		/// Set/Get information about the current event.
		/// The current x,y position is in the EventPosition, and the previous
		/// event position is in LastEventPosition, updated automatically each
		/// time EventPosition is set using its Set() method. Mouse positions
		/// are measured in pixels.
		/// The other information is about key board input.
		/// </summary>
		// Token: 0x06001F85 RID: 8069 RVA: 0x000305A0 File Offset: 0x0002E7A0
		public virtual IntPtr GetEventPositions(int pointerIndex)
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetEventPositions_44(base.GetCppThis(), pointerIndex);
		}

		// Token: 0x06001F86 RID: 8070
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindowInteractor_GetEventSize_45(HandleRef pThis);

		/// <summary>
		/// This methods sets the Size ivar of the interactor without
		/// actually changing the size of the window. Normally
		/// application programmers would use UpdateSize if anything.
		/// This is useful for letting someone else change the size of
		/// the rendering window and just letting the interactor
		/// know about the change.
		/// The current event width/height (if any) is in EventSize
		/// (Expose event, for example).
		/// Window size is measured in pixels.
		/// </summary>
		// Token: 0x06001F87 RID: 8071 RVA: 0x000305C0 File Offset: 0x0002E7C0
		public virtual int[] GetEventSize()
		{
			IntPtr intPtr = vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetEventSize_45(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06001F88 RID: 8072
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_GetEventSize_46(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// This methods sets the Size ivar of the interactor without
		/// actually changing the size of the window. Normally
		/// application programmers would use UpdateSize if anything.
		/// This is useful for letting someone else change the size of
		/// the rendering window and just letting the interactor
		/// know about the change.
		/// The current event width/height (if any) is in EventSize
		/// (Expose event, for example).
		/// Window size is measured in pixels.
		/// </summary>
		// Token: 0x06001F89 RID: 8073 RVA: 0x00030608 File Offset: 0x0002E808
		public virtual void GetEventSize(ref int _arg1, ref int _arg2)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetEventSize_46(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06001F8A RID: 8074
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_GetEventSize_47(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// This methods sets the Size ivar of the interactor without
		/// actually changing the size of the window. Normally
		/// application programmers would use UpdateSize if anything.
		/// This is useful for letting someone else change the size of
		/// the rendering window and just letting the interactor
		/// know about the change.
		/// The current event width/height (if any) is in EventSize
		/// (Expose event, for example).
		/// Window size is measured in pixels.
		/// </summary>
		// Token: 0x06001F8B RID: 8075 RVA: 0x00030619 File Offset: 0x0002E819
		public virtual void GetEventSize(IntPtr _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetEventSize_47(base.GetCppThis(), _arg);
		}

		// Token: 0x06001F8C RID: 8076
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindowInteractor_GetHardwareWindow_48(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the hardware window being controlled by this object.
		/// For opengl the hardware window is not used as the opengl
		/// subclasses of RenderWindow provide the functionality.
		/// </summary>
		// Token: 0x06001F8D RID: 8077 RVA: 0x0003062C File Offset: 0x0002E82C
		public virtual vtkHardwareWindow GetHardwareWindow()
		{
			vtkHardwareWindow vtkHardwareWindow = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetHardwareWindow_48(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHardwareWindow = (vtkHardwareWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHardwareWindow.Register(null);
				}
			}
			return vtkHardwareWindow;
		}

		// Token: 0x06001F8E RID: 8078
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindowInteractor_GetInitialized_49(HandleRef pThis);

		/// <summary>
		/// See whether interactor has been initialized yet.
		/// Default is 0.
		/// </summary>
		// Token: 0x06001F8F RID: 8079 RVA: 0x0003069C File Offset: 0x0002E89C
		public virtual int GetInitialized()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetInitialized_49(base.GetCppThis());
		}

		// Token: 0x06001F90 RID: 8080
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindowInteractor_GetInteractorStyle_50(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// External switching between joystick/trackball/new? modes. Initial value
		/// is a vtkInteractorStyleSwitch object.
		/// </summary>
		// Token: 0x06001F91 RID: 8081 RVA: 0x000306BC File Offset: 0x0002E8BC
		public virtual vtkInteractorObserver GetInteractorStyle()
		{
			vtkInteractorObserver vtkInteractorObserver = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetInteractorStyle_50(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInteractorObserver = (vtkInteractorObserver)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInteractorObserver.Register(null);
				}
			}
			return vtkInteractorObserver;
		}

		// Token: 0x06001F92 RID: 8082
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern sbyte vtkRenderWindowInteractor_GetKeyCode_51(HandleRef pThis);

		/// <summary>
		/// Set/get the key code for the key that was pressed.
		/// </summary>
		// Token: 0x06001F93 RID: 8083 RVA: 0x0003072C File Offset: 0x0002E92C
		public virtual sbyte GetKeyCode()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetKeyCode_51(base.GetCppThis());
		}

		// Token: 0x06001F94 RID: 8084
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindowInteractor_GetKeySym_52(HandleRef pThis);

		/// <summary>
		/// Set/get the key symbol for the key that was pressed. This is the key
		/// symbol as defined by the relevant X headers. On X based platforms this
		/// corresponds to the installed X server, whereas on other platforms the
		/// native key codes are translated into a string representation.
		/// </summary>
		// Token: 0x06001F95 RID: 8085 RVA: 0x0003074C File Offset: 0x0002E94C
		public virtual string GetKeySym()
		{
			string s = Marshal.PtrToStringAnsi(vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetKeySym_52(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06001F96 RID: 8086
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindowInteractor_GetLastEventPosition_53(HandleRef pThis);

		/// <summary>
		/// Set/Get information about the current event.
		/// The current x,y position is in the EventPosition, and the previous
		/// event position is in LastEventPosition, updated automatically each
		/// time EventPosition is set using its Set() method. Mouse positions
		/// are measured in pixels.
		/// The other information is about key board input.
		/// </summary>
		// Token: 0x06001F97 RID: 8087 RVA: 0x00030788 File Offset: 0x0002E988
		public virtual int[] GetLastEventPosition()
		{
			IntPtr intPtr = vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetLastEventPosition_53(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06001F98 RID: 8088
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_GetLastEventPosition_54(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Set/Get information about the current event.
		/// The current x,y position is in the EventPosition, and the previous
		/// event position is in LastEventPosition, updated automatically each
		/// time EventPosition is set using its Set() method. Mouse positions
		/// are measured in pixels.
		/// The other information is about key board input.
		/// </summary>
		// Token: 0x06001F99 RID: 8089 RVA: 0x000307D0 File Offset: 0x0002E9D0
		public virtual void GetLastEventPosition(ref int _arg1, ref int _arg2)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetLastEventPosition_54(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06001F9A RID: 8090
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_GetLastEventPosition_55(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get information about the current event.
		/// The current x,y position is in the EventPosition, and the previous
		/// event position is in LastEventPosition, updated automatically each
		/// time EventPosition is set using its Set() method. Mouse positions
		/// are measured in pixels.
		/// The other information is about key board input.
		/// </summary>
		// Token: 0x06001F9B RID: 8091 RVA: 0x000307E1 File Offset: 0x0002E9E1
		public virtual void GetLastEventPosition(IntPtr _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetLastEventPosition_55(base.GetCppThis(), _arg);
		}

		// Token: 0x06001F9C RID: 8092
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindowInteractor_GetLastEventPositions_56(HandleRef pThis, int pointerIndex);

		/// <summary>
		/// Set/Get information about the current event.
		/// The current x,y position is in the EventPosition, and the previous
		/// event position is in LastEventPosition, updated automatically each
		/// time EventPosition is set using its Set() method. Mouse positions
		/// are measured in pixels.
		/// The other information is about key board input.
		/// </summary>
		// Token: 0x06001F9D RID: 8093 RVA: 0x000307F4 File Offset: 0x0002E9F4
		public virtual IntPtr GetLastEventPositions(int pointerIndex)
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetLastEventPositions_56(base.GetCppThis(), pointerIndex);
		}

		// Token: 0x06001F9E RID: 8094
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRenderWindowInteractor_GetLastRotation_57(HandleRef pThis);

		/// <summary>
		/// Set/get the rotation for the gesture in degrees, update LastRotation
		/// </summary>
		// Token: 0x06001F9F RID: 8095 RVA: 0x00030814 File Offset: 0x0002EA14
		public virtual double GetLastRotation()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetLastRotation_57(base.GetCppThis());
		}

		// Token: 0x06001FA0 RID: 8096
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRenderWindowInteractor_GetLastScale_58(HandleRef pThis);

		/// <summary>
		/// Set/get the scale for the gesture, updates LastScale
		/// </summary>
		// Token: 0x06001FA1 RID: 8097 RVA: 0x00030834 File Offset: 0x0002EA34
		public virtual double GetLastScale()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetLastScale_58(base.GetCppThis());
		}

		// Token: 0x06001FA2 RID: 8098
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindowInteractor_GetLastTranslation_59(HandleRef pThis);

		/// <summary>
		/// Set/get the translation for pan/swipe gestures, update LastTranslation
		/// </summary>
		// Token: 0x06001FA3 RID: 8099 RVA: 0x00030854 File Offset: 0x0002EA54
		public virtual double[] GetLastTranslation()
		{
			IntPtr intPtr = vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetLastTranslation_59(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06001FA4 RID: 8100
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_GetLastTranslation_60(HandleRef pThis, ref double _arg1, ref double _arg2);

		/// <summary>
		/// Set/get the translation for pan/swipe gestures, update LastTranslation
		/// </summary>
		// Token: 0x06001FA5 RID: 8101 RVA: 0x0003089C File Offset: 0x0002EA9C
		public virtual void GetLastTranslation(ref double _arg1, ref double _arg2)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetLastTranslation_60(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06001FA6 RID: 8102
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_GetLastTranslation_61(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/get the translation for pan/swipe gestures, update LastTranslation
		/// </summary>
		// Token: 0x06001FA7 RID: 8103 RVA: 0x000308AD File Offset: 0x0002EAAD
		public virtual void GetLastTranslation(IntPtr _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetLastTranslation_61(base.GetCppThis(), _arg);
		}

		// Token: 0x06001FA8 RID: 8104
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindowInteractor_GetLightFollowCamera_62(HandleRef pThis);

		/// <summary>
		/// Turn on/off the automatic repositioning of lights as the camera moves.
		/// Default is On.
		/// </summary>
		// Token: 0x06001FA9 RID: 8105 RVA: 0x000308C0 File Offset: 0x0002EAC0
		public virtual int GetLightFollowCamera()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetLightFollowCamera_62(base.GetCppThis());
		}

		// Token: 0x06001FAA RID: 8106
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_GetMousePosition_63(HandleRef pThis, IntPtr x, IntPtr y);

		/// <summary>
		/// Get the current position of the mouse.
		/// </summary>
		// Token: 0x06001FAB RID: 8107 RVA: 0x000308DF File Offset: 0x0002EADF
		public virtual void GetMousePosition(IntPtr x, IntPtr y)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetMousePosition_63(base.GetCppThis(), x, y);
		}

		// Token: 0x06001FAC RID: 8108
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindowInteractor_GetNumberOfFlyFrames_64(HandleRef pThis);

		/// <summary>
		/// Set the number of frames to fly to when FlyTo is invoked.
		/// </summary>
		// Token: 0x06001FAD RID: 8109 RVA: 0x000308F0 File Offset: 0x0002EAF0
		public virtual int GetNumberOfFlyFrames()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetNumberOfFlyFrames_64(base.GetCppThis());
		}

		// Token: 0x06001FAE RID: 8110
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindowInteractor_GetNumberOfFlyFramesMaxValue_65(HandleRef pThis);

		/// <summary>
		/// Set the number of frames to fly to when FlyTo is invoked.
		/// </summary>
		// Token: 0x06001FAF RID: 8111 RVA: 0x00030910 File Offset: 0x0002EB10
		public virtual int GetNumberOfFlyFramesMaxValue()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetNumberOfFlyFramesMaxValue_65(base.GetCppThis());
		}

		// Token: 0x06001FB0 RID: 8112
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindowInteractor_GetNumberOfFlyFramesMinValue_66(HandleRef pThis);

		/// <summary>
		/// Set the number of frames to fly to when FlyTo is invoked.
		/// </summary>
		// Token: 0x06001FB1 RID: 8113 RVA: 0x00030930 File Offset: 0x0002EB30
		public virtual int GetNumberOfFlyFramesMinValue()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetNumberOfFlyFramesMinValue_66(base.GetCppThis());
		}

		// Token: 0x06001FB2 RID: 8114
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRenderWindowInteractor_GetNumberOfGenerationsFromBase_67(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001FB3 RID: 8115 RVA: 0x00030950 File Offset: 0x0002EB50
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetNumberOfGenerationsFromBase_67(base.GetCppThis(), type);
		}

		// Token: 0x06001FB4 RID: 8116
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRenderWindowInteractor_GetNumberOfGenerationsFromBaseType_68([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001FB5 RID: 8117 RVA: 0x00030970 File Offset: 0x0002EB70
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetNumberOfGenerationsFromBaseType_68(type);
		}

		// Token: 0x06001FB6 RID: 8118
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindowInteractor_GetObserverMediator_69(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the object used to mediate between vtkInteractorObservers
		/// contending for resources. Multiple interactor observers will often
		/// request different resources (e.g., cursor shape); the mediator uses a
		/// strategy to provide the resource based on priority of the observer plus
		/// the particular request (default versus non-default cursor shape).
		/// </summary>
		// Token: 0x06001FB7 RID: 8119 RVA: 0x0003098C File Offset: 0x0002EB8C
		public vtkObserverMediator GetObserverMediator()
		{
			vtkObserverMediator vtkObserverMediator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetObserverMediator_69(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkObserverMediator = (vtkObserverMediator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkObserverMediator.Register(null);
				}
			}
			return vtkObserverMediator;
		}

		// Token: 0x06001FB8 RID: 8120
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindowInteractor_GetPicker_70(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the object used to perform pick operations. In order to
		/// pick instances of vtkProp, the picker must be a subclass of
		/// vtkAbstractPropPicker, meaning that it can identify a particular
		/// instance of vtkProp.
		/// </summary>
		// Token: 0x06001FB9 RID: 8121 RVA: 0x000309FC File Offset: 0x0002EBFC
		public virtual vtkAbstractPicker GetPicker()
		{
			vtkAbstractPicker vtkAbstractPicker = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetPicker_70(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractPicker = (vtkAbstractPicker)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractPicker.Register(null);
				}
			}
			return vtkAbstractPicker;
		}

		// Token: 0x06001FBA RID: 8122
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindowInteractor_GetPickingManager_71(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the picking manager.
		/// Set/Get the object used to perform operations through the interactor
		/// By default, a valid but disabled picking manager is instantiated.
		/// </summary>
		// Token: 0x06001FBB RID: 8123 RVA: 0x00030A6C File Offset: 0x0002EC6C
		public virtual vtkPickingManager GetPickingManager()
		{
			vtkPickingManager vtkPickingManager = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetPickingManager_71(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPickingManager = (vtkPickingManager)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPickingManager.Register(null);
				}
			}
			return vtkPickingManager;
		}

		// Token: 0x06001FBC RID: 8124
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindowInteractor_GetPointerIndex_72(HandleRef pThis);

		/// <summary>
		/// Set/get the index of the most recent pointer to have an event
		/// </summary>
		// Token: 0x06001FBD RID: 8125 RVA: 0x00030ADC File Offset: 0x0002ECDC
		public virtual int GetPointerIndex()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetPointerIndex_72(base.GetCppThis());
		}

		// Token: 0x06001FBE RID: 8126
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindowInteractor_GetPointerIndexForContact_73(HandleRef pThis, ulong contactID);

		/// <summary>
		/// Most multitouch systems use persistent contact/pointer ids to
		/// track events/motion during multitouch events. We keep an array
		/// that maps these system dependent contact ids to our pointer index
		/// These functions return -1 if the ID is not found or if there
		/// is no more room for contacts
		/// </summary>
		// Token: 0x06001FBF RID: 8127 RVA: 0x00030AFC File Offset: 0x0002ECFC
		public int GetPointerIndexForContact(ulong contactID)
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetPointerIndexForContact_73(base.GetCppThis(), contactID);
		}

		// Token: 0x06001FC0 RID: 8128
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindowInteractor_GetPointerIndexForExistingContact_74(HandleRef pThis, ulong contactID);

		/// <summary>
		/// Most multitouch systems use persistent contact/pointer ids to
		/// track events/motion during multitouch events. We keep an array
		/// that maps these system dependent contact ids to our pointer index
		/// These functions return -1 if the ID is not found or if there
		/// is no more room for contacts
		/// </summary>
		// Token: 0x06001FC1 RID: 8129 RVA: 0x00030B1C File Offset: 0x0002ED1C
		public int GetPointerIndexForExistingContact(ulong contactID)
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetPointerIndexForExistingContact_74(base.GetCppThis(), contactID);
		}

		// Token: 0x06001FC2 RID: 8130
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindowInteractor_GetPointersDownCount_75(HandleRef pThis);

		/// <summary>
		/// When handling gestures you can query this value to
		/// determine how many pointers are down for the gesture
		/// this is useful for pan gestures for example
		/// </summary>
		// Token: 0x06001FC3 RID: 8131 RVA: 0x00030B3C File Offset: 0x0002ED3C
		public virtual int GetPointersDownCount()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetPointersDownCount_75(base.GetCppThis());
		}

		// Token: 0x06001FC4 RID: 8132
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderWindowInteractor_GetRecognizeGestures_76(HandleRef pThis);

		/// <summary>
		/// Convert multitouch events into gestures. When this is on
		/// (its default) multitouch events received by this interactor
		/// will be converted into gestures by VTK. If turned off the
		/// raw multitouch events will be passed down.
		/// </summary>
		// Token: 0x06001FC5 RID: 8133 RVA: 0x00030B5C File Offset: 0x0002ED5C
		public virtual bool GetRecognizeGestures()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetRecognizeGestures_76(base.GetCppThis()) != 0;
		}

		// Token: 0x06001FC6 RID: 8134
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindowInteractor_GetRenderWindow_77(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the rendering window being controlled by this object.
		/// </summary>
		// Token: 0x06001FC7 RID: 8135 RVA: 0x00030B84 File Offset: 0x0002ED84
		public virtual vtkRenderWindow GetRenderWindow()
		{
			vtkRenderWindow vtkRenderWindow = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetRenderWindow_77(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06001FC8 RID: 8136
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindowInteractor_GetRepeatCount_78(HandleRef pThis);

		/// <summary>
		/// Set/get the repear count for the key or mouse event. This specifies how
		/// many times a key has been pressed.
		/// </summary>
		// Token: 0x06001FC9 RID: 8137 RVA: 0x00030BF4 File Offset: 0x0002EDF4
		public virtual int GetRepeatCount()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetRepeatCount_78(base.GetCppThis());
		}

		// Token: 0x06001FCA RID: 8138
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRenderWindowInteractor_GetRotation_79(HandleRef pThis);

		/// <summary>
		/// Set/get the rotation for the gesture in degrees, update LastRotation
		/// </summary>
		// Token: 0x06001FCB RID: 8139 RVA: 0x00030C14 File Offset: 0x0002EE14
		public virtual double GetRotation()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetRotation_79(base.GetCppThis());
		}

		// Token: 0x06001FCC RID: 8140
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRenderWindowInteractor_GetScale_80(HandleRef pThis);

		/// <summary>
		/// Set/get the scale for the gesture, updates LastScale
		/// </summary>
		// Token: 0x06001FCD RID: 8141 RVA: 0x00030C34 File Offset: 0x0002EE34
		public virtual double GetScale()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetScale_80(base.GetCppThis());
		}

		// Token: 0x06001FCE RID: 8142
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindowInteractor_GetShiftKey_81(HandleRef pThis);

		/// <summary>
		/// Set/get whether shift modifier key was pressed.
		/// </summary>
		// Token: 0x06001FCF RID: 8143 RVA: 0x00030C54 File Offset: 0x0002EE54
		public virtual int GetShiftKey()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetShiftKey_81(base.GetCppThis());
		}

		// Token: 0x06001FD0 RID: 8144
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindowInteractor_GetSize_82(HandleRef pThis);

		/// <summary>
		/// This methods sets the Size ivar of the interactor without
		/// actually changing the size of the window. Normally
		/// application programmers would use UpdateSize if anything.
		/// This is useful for letting someone else change the size of
		/// the rendering window and just letting the interactor
		/// know about the change.
		/// The current event width/height (if any) is in EventSize
		/// (Expose event, for example).
		/// Window size is measured in pixels.
		/// </summary>
		// Token: 0x06001FD1 RID: 8145 RVA: 0x00030C74 File Offset: 0x0002EE74
		public virtual int[] GetSize()
		{
			IntPtr intPtr = vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetSize_82(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06001FD2 RID: 8146
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_GetSize_83(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// This methods sets the Size ivar of the interactor without
		/// actually changing the size of the window. Normally
		/// application programmers would use UpdateSize if anything.
		/// This is useful for letting someone else change the size of
		/// the rendering window and just letting the interactor
		/// know about the change.
		/// The current event width/height (if any) is in EventSize
		/// (Expose event, for example).
		/// Window size is measured in pixels.
		/// </summary>
		// Token: 0x06001FD3 RID: 8147 RVA: 0x00030CBC File Offset: 0x0002EEBC
		public virtual void GetSize(ref int _arg1, ref int _arg2)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetSize_83(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06001FD4 RID: 8148
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_GetSize_84(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// This methods sets the Size ivar of the interactor without
		/// actually changing the size of the window. Normally
		/// application programmers would use UpdateSize if anything.
		/// This is useful for letting someone else change the size of
		/// the rendering window and just letting the interactor
		/// know about the change.
		/// The current event width/height (if any) is in EventSize
		/// (Expose event, for example).
		/// Window size is measured in pixels.
		/// </summary>
		// Token: 0x06001FD5 RID: 8149 RVA: 0x00030CCD File Offset: 0x0002EECD
		public virtual void GetSize(IntPtr _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetSize_84(base.GetCppThis(), _arg);
		}

		// Token: 0x06001FD6 RID: 8150
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRenderWindowInteractor_GetStillUpdateRate_85(HandleRef pThis);

		/// <summary>
		/// Set/Get the desired update rate when movement has stopped.
		/// For the non-still update rate, see the SetDesiredUpdateRate method.
		/// The default is 0.0001
		/// </summary>
		// Token: 0x06001FD7 RID: 8151 RVA: 0x00030CE0 File Offset: 0x0002EEE0
		public virtual double GetStillUpdateRate()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetStillUpdateRate_85(base.GetCppThis());
		}

		// Token: 0x06001FD8 RID: 8152
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRenderWindowInteractor_GetStillUpdateRateMaxValue_86(HandleRef pThis);

		/// <summary>
		/// Set/Get the desired update rate when movement has stopped.
		/// For the non-still update rate, see the SetDesiredUpdateRate method.
		/// The default is 0.0001
		/// </summary>
		// Token: 0x06001FD9 RID: 8153 RVA: 0x00030D00 File Offset: 0x0002EF00
		public virtual double GetStillUpdateRateMaxValue()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetStillUpdateRateMaxValue_86(base.GetCppThis());
		}

		// Token: 0x06001FDA RID: 8154
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRenderWindowInteractor_GetStillUpdateRateMinValue_87(HandleRef pThis);

		/// <summary>
		/// Set/Get the desired update rate when movement has stopped.
		/// For the non-still update rate, see the SetDesiredUpdateRate method.
		/// The default is 0.0001
		/// </summary>
		// Token: 0x06001FDB RID: 8155 RVA: 0x00030D20 File Offset: 0x0002EF20
		public virtual double GetStillUpdateRateMinValue()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetStillUpdateRateMinValue_87(base.GetCppThis());
		}

		// Token: 0x06001FDC RID: 8156
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkRenderWindowInteractor_GetTimerDuration_88(HandleRef pThis, int timerId);

		/// <summary>
		/// Get the duration (in milliseconds) for the specified timerId.
		/// </summary>
		// Token: 0x06001FDD RID: 8157 RVA: 0x00030D40 File Offset: 0x0002EF40
		public uint GetTimerDuration(int timerId)
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetTimerDuration_88(base.GetCppThis(), timerId);
		}

		// Token: 0x06001FDE RID: 8158
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkRenderWindowInteractor_GetTimerDuration_89(HandleRef pThis);

		/// <summary>
		/// Specify the default timer interval (in milliseconds). (This is used in
		/// conjunction with the timer methods described previously, e.g.,
		/// CreateTimer() uses this value; and CreateRepeatingTimer(duration) and
		/// CreateOneShotTimer(duration) use the default value if the parameter
		/// "duration" is less than or equal to zero.) Care must be taken when
		/// adjusting the timer interval from the default value of 10
		/// milliseconds--it may adversely affect the interactors.
		/// </summary>
		// Token: 0x06001FDF RID: 8159 RVA: 0x00030D60 File Offset: 0x0002EF60
		public virtual uint GetTimerDuration()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetTimerDuration_89(base.GetCppThis());
		}

		// Token: 0x06001FE0 RID: 8160
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkRenderWindowInteractor_GetTimerDurationMaxValue_90(HandleRef pThis);

		/// <summary>
		/// Specify the default timer interval (in milliseconds). (This is used in
		/// conjunction with the timer methods described previously, e.g.,
		/// CreateTimer() uses this value; and CreateRepeatingTimer(duration) and
		/// CreateOneShotTimer(duration) use the default value if the parameter
		/// "duration" is less than or equal to zero.) Care must be taken when
		/// adjusting the timer interval from the default value of 10
		/// milliseconds--it may adversely affect the interactors.
		/// </summary>
		// Token: 0x06001FE1 RID: 8161 RVA: 0x00030D80 File Offset: 0x0002EF80
		public virtual uint GetTimerDurationMaxValue()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetTimerDurationMaxValue_90(base.GetCppThis());
		}

		// Token: 0x06001FE2 RID: 8162
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkRenderWindowInteractor_GetTimerDurationMinValue_91(HandleRef pThis);

		/// <summary>
		/// Specify the default timer interval (in milliseconds). (This is used in
		/// conjunction with the timer methods described previously, e.g.,
		/// CreateTimer() uses this value; and CreateRepeatingTimer(duration) and
		/// CreateOneShotTimer(duration) use the default value if the parameter
		/// "duration" is less than or equal to zero.) Care must be taken when
		/// adjusting the timer interval from the default value of 10
		/// milliseconds--it may adversely affect the interactors.
		/// </summary>
		// Token: 0x06001FE3 RID: 8163 RVA: 0x00030DA0 File Offset: 0x0002EFA0
		public virtual uint GetTimerDurationMinValue()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetTimerDurationMinValue_91(base.GetCppThis());
		}

		// Token: 0x06001FE4 RID: 8164
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindowInteractor_GetTimerEventDuration_92(HandleRef pThis);

		/// <summary>
		/// These methods are used to communicate information about the currently
		/// firing CreateTimerEvent or DestroyTimerEvent. The caller of
		/// CreateTimerEvent sets up TimerEventId, TimerEventType and
		/// TimerEventDuration. The observer of CreateTimerEvent should set up an
		/// appropriate platform specific timer based on those values and set the
		/// TimerEventPlatformId before returning. The caller of DestroyTimerEvent
		/// sets up TimerEventPlatformId. The observer of DestroyTimerEvent should
		/// simply destroy the platform specific timer created by CreateTimerEvent.
		/// See vtkGenericRenderWindowInteractor's InternalCreateTimer and
		/// InternalDestroyTimer for an example.
		/// </summary>
		// Token: 0x06001FE5 RID: 8165 RVA: 0x00030DC0 File Offset: 0x0002EFC0
		public virtual int GetTimerEventDuration()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetTimerEventDuration_92(base.GetCppThis());
		}

		// Token: 0x06001FE6 RID: 8166
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindowInteractor_GetTimerEventId_93(HandleRef pThis);

		/// <summary>
		/// These methods are used to communicate information about the currently
		/// firing CreateTimerEvent or DestroyTimerEvent. The caller of
		/// CreateTimerEvent sets up TimerEventId, TimerEventType and
		/// TimerEventDuration. The observer of CreateTimerEvent should set up an
		/// appropriate platform specific timer based on those values and set the
		/// TimerEventPlatformId before returning. The caller of DestroyTimerEvent
		/// sets up TimerEventPlatformId. The observer of DestroyTimerEvent should
		/// simply destroy the platform specific timer created by CreateTimerEvent.
		/// See vtkGenericRenderWindowInteractor's InternalCreateTimer and
		/// InternalDestroyTimer for an example.
		/// </summary>
		// Token: 0x06001FE7 RID: 8167 RVA: 0x00030DE0 File Offset: 0x0002EFE0
		public virtual int GetTimerEventId()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetTimerEventId_93(base.GetCppThis());
		}

		// Token: 0x06001FE8 RID: 8168
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindowInteractor_GetTimerEventPlatformId_94(HandleRef pThis);

		/// <summary>
		/// These methods are used to communicate information about the currently
		/// firing CreateTimerEvent or DestroyTimerEvent. The caller of
		/// CreateTimerEvent sets up TimerEventId, TimerEventType and
		/// TimerEventDuration. The observer of CreateTimerEvent should set up an
		/// appropriate platform specific timer based on those values and set the
		/// TimerEventPlatformId before returning. The caller of DestroyTimerEvent
		/// sets up TimerEventPlatformId. The observer of DestroyTimerEvent should
		/// simply destroy the platform specific timer created by CreateTimerEvent.
		/// See vtkGenericRenderWindowInteractor's InternalCreateTimer and
		/// InternalDestroyTimer for an example.
		/// </summary>
		// Token: 0x06001FE9 RID: 8169 RVA: 0x00030E00 File Offset: 0x0002F000
		public virtual int GetTimerEventPlatformId()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetTimerEventPlatformId_94(base.GetCppThis());
		}

		// Token: 0x06001FEA RID: 8170
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindowInteractor_GetTimerEventType_95(HandleRef pThis);

		/// <summary>
		/// These methods are used to communicate information about the currently
		/// firing CreateTimerEvent or DestroyTimerEvent. The caller of
		/// CreateTimerEvent sets up TimerEventId, TimerEventType and
		/// TimerEventDuration. The observer of CreateTimerEvent should set up an
		/// appropriate platform specific timer based on those values and set the
		/// TimerEventPlatformId before returning. The caller of DestroyTimerEvent
		/// sets up TimerEventPlatformId. The observer of DestroyTimerEvent should
		/// simply destroy the platform specific timer created by CreateTimerEvent.
		/// See vtkGenericRenderWindowInteractor's InternalCreateTimer and
		/// InternalDestroyTimer for an example.
		/// </summary>
		// Token: 0x06001FEB RID: 8171 RVA: 0x00030E20 File Offset: 0x0002F020
		public virtual int GetTimerEventType()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetTimerEventType_95(base.GetCppThis());
		}

		// Token: 0x06001FEC RID: 8172
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindowInteractor_GetTranslation_96(HandleRef pThis);

		/// <summary>
		/// Set/get the translation for pan/swipe gestures, update LastTranslation
		/// </summary>
		// Token: 0x06001FED RID: 8173 RVA: 0x00030E40 File Offset: 0x0002F040
		public virtual double[] GetTranslation()
		{
			IntPtr intPtr = vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetTranslation_96(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06001FEE RID: 8174
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_GetTranslation_97(HandleRef pThis, ref double _arg1, ref double _arg2);

		/// <summary>
		/// Set/get the translation for pan/swipe gestures, update LastTranslation
		/// </summary>
		// Token: 0x06001FEF RID: 8175 RVA: 0x00030E88 File Offset: 0x0002F088
		public virtual void GetTranslation(ref double _arg1, ref double _arg2)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetTranslation_97(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06001FF0 RID: 8176
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_GetTranslation_98(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/get the translation for pan/swipe gestures, update LastTranslation
		/// </summary>
		// Token: 0x06001FF1 RID: 8177 RVA: 0x00030E99 File Offset: 0x0002F099
		public virtual void GetTranslation(IntPtr _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetTranslation_98(base.GetCppThis(), _arg);
		}

		// Token: 0x06001FF2 RID: 8178
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderWindowInteractor_GetUseTDx_99(HandleRef pThis);

		/// <summary>
		/// Use a 3DConnexion device. Initial value is false.
		/// If VTK is not build with the TDx option, this is no-op.
		/// If VTK is build with the TDx option, and a device is not connected,
		/// a warning is emitted.
		/// It is must be called before the first Render to be effective, otherwise
		/// it is ignored.
		/// </summary>
		// Token: 0x06001FF3 RID: 8179 RVA: 0x00030EAC File Offset: 0x0002F0AC
		public virtual bool GetUseTDx()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetUseTDx_99(base.GetCppThis()) != 0;
		}

		// Token: 0x06001FF4 RID: 8180
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindowInteractor_GetVTKTimerId_100(HandleRef pThis, int platformTimerId);

		/// <summary>
		/// Get the VTK timer ID that corresponds to the supplied platform ID.
		/// </summary>
		// Token: 0x06001FF5 RID: 8181 RVA: 0x00030ED4 File Offset: 0x0002F0D4
		public virtual int GetVTKTimerId(int platformTimerId)
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetVTKTimerId_100(base.GetCppThis(), platformTimerId);
		}

		// Token: 0x06001FF6 RID: 8182
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_HideCursor_101(HandleRef pThis);

		/// <summary>
		/// Hide or show the mouse cursor, it is nice to be able to hide the
		/// default cursor if you want VTK to display a 3D cursor instead.
		/// </summary>
		// Token: 0x06001FF7 RID: 8183 RVA: 0x00030EF4 File Offset: 0x0002F0F4
		public void HideCursor()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_HideCursor_101(base.GetCppThis());
		}

		// Token: 0x06001FF8 RID: 8184
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_Initialize_102(HandleRef pThis);

		/// <summary>
		/// Prepare for handling events and set the Enabled flag to true.
		/// This will be called automatically by Start() if the interactor
		/// is not initialized, but it can be called manually if you need
		/// to perform any operations between initialization and the start
		/// of the event loop.
		/// </summary>
		// Token: 0x06001FF9 RID: 8185 RVA: 0x00030F03 File Offset: 0x0002F103
		public virtual void Initialize()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_Initialize_102(base.GetCppThis());
		}

		// Token: 0x06001FFA RID: 8186
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindowInteractor_IsA_103(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001FFB RID: 8187 RVA: 0x00030F14 File Offset: 0x0002F114
		public override int IsA(string type)
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_IsA_103(base.GetCppThis(), type);
		}

		// Token: 0x06001FFC RID: 8188
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindowInteractor_IsOneShotTimer_104(HandleRef pThis, int timerId);

		/// <summary>
		/// Query whether the specified timerId is a one shot timer.
		/// \return 1 if the timer is a one shot timer.
		/// </summary>
		// Token: 0x06001FFD RID: 8189 RVA: 0x00030F34 File Offset: 0x0002F134
		public int IsOneShotTimer(int timerId)
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_IsOneShotTimer_104(base.GetCppThis(), timerId);
		}

		// Token: 0x06001FFE RID: 8190
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderWindowInteractor_IsPointerIndexSet_105(HandleRef pThis, int i);

		/// <summary>
		/// Most multitouch systems use persistent contact/pointer ids to
		/// track events/motion during multitouch events. We keep an array
		/// that maps these system dependent contact ids to our pointer index
		/// These functions return -1 if the ID is not found or if there
		/// is no more room for contacts
		/// </summary>
		// Token: 0x06001FFF RID: 8191 RVA: 0x00030F54 File Offset: 0x0002F154
		public bool IsPointerIndexSet(int i)
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_IsPointerIndexSet_105(base.GetCppThis(), i) != 0;
		}

		// Token: 0x06002000 RID: 8192
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindowInteractor_IsTypeOf_106([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002001 RID: 8193 RVA: 0x00030F7C File Offset: 0x0002F17C
		public new static int IsTypeOf(string type)
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_IsTypeOf_106(type);
		}

		// Token: 0x06002002 RID: 8194
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_KeyPressEvent_107(HandleRef pThis);

		/// <summary>
		/// Fire various events. SetEventInformation should be called just prior
		/// to calling any of these methods. These methods will Invoke the
		/// corresponding vtk event.
		/// </summary>
		// Token: 0x06002003 RID: 8195 RVA: 0x00030F96 File Offset: 0x0002F196
		public virtual void KeyPressEvent()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_KeyPressEvent_107(base.GetCppThis());
		}

		// Token: 0x06002004 RID: 8196
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_KeyReleaseEvent_108(HandleRef pThis);

		/// <summary>
		/// Fire various events. SetEventInformation should be called just prior
		/// to calling any of these methods. These methods will Invoke the
		/// corresponding vtk event.
		/// </summary>
		// Token: 0x06002005 RID: 8197 RVA: 0x00030FA5 File Offset: 0x0002F1A5
		public virtual void KeyReleaseEvent()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_KeyReleaseEvent_108(base.GetCppThis());
		}

		// Token: 0x06002006 RID: 8198
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_LeaveEvent_109(HandleRef pThis);

		/// <summary>
		/// Fire various events. SetEventInformation should be called just prior
		/// to calling any of these methods. These methods will Invoke the
		/// corresponding vtk event.
		/// </summary>
		// Token: 0x06002007 RID: 8199 RVA: 0x00030FB4 File Offset: 0x0002F1B4
		public virtual void LeaveEvent()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_LeaveEvent_109(base.GetCppThis());
		}

		// Token: 0x06002008 RID: 8200
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_LeftButtonPressEvent_110(HandleRef pThis);

		/// <summary>
		/// Fire various events. SetEventInformation should be called just prior
		/// to calling any of these methods. These methods will Invoke the
		/// corresponding vtk event.
		/// </summary>
		// Token: 0x06002009 RID: 8201 RVA: 0x00030FC3 File Offset: 0x0002F1C3
		public virtual void LeftButtonPressEvent()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_LeftButtonPressEvent_110(base.GetCppThis());
		}

		// Token: 0x0600200A RID: 8202
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_LeftButtonReleaseEvent_111(HandleRef pThis);

		/// <summary>
		/// Fire various events. SetEventInformation should be called just prior
		/// to calling any of these methods. These methods will Invoke the
		/// corresponding vtk event.
		/// </summary>
		// Token: 0x0600200B RID: 8203 RVA: 0x00030FD2 File Offset: 0x0002F1D2
		public virtual void LeftButtonReleaseEvent()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_LeftButtonReleaseEvent_111(base.GetCppThis());
		}

		// Token: 0x0600200C RID: 8204
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_LightFollowCameraOff_112(HandleRef pThis);

		/// <summary>
		/// Turn on/off the automatic repositioning of lights as the camera moves.
		/// Default is On.
		/// </summary>
		// Token: 0x0600200D RID: 8205 RVA: 0x00030FE1 File Offset: 0x0002F1E1
		public virtual void LightFollowCameraOff()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_LightFollowCameraOff_112(base.GetCppThis());
		}

		// Token: 0x0600200E RID: 8206
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_LightFollowCameraOn_113(HandleRef pThis);

		/// <summary>
		/// Turn on/off the automatic repositioning of lights as the camera moves.
		/// Default is On.
		/// </summary>
		// Token: 0x0600200F RID: 8207 RVA: 0x00030FF0 File Offset: 0x0002F1F0
		public virtual void LightFollowCameraOn()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_LightFollowCameraOn_113(base.GetCppThis());
		}

		// Token: 0x06002010 RID: 8208
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_LongTapEvent_114(HandleRef pThis);

		/// <summary>
		/// Fire various gesture based events.  These methods will Invoke the
		/// corresponding vtk event.
		/// </summary>
		// Token: 0x06002011 RID: 8209 RVA: 0x00030FFF File Offset: 0x0002F1FF
		public virtual void LongTapEvent()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_LongTapEvent_114(base.GetCppThis());
		}

		// Token: 0x06002012 RID: 8210
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_MiddleButtonPressEvent_115(HandleRef pThis);

		/// <summary>
		/// Fire various events. SetEventInformation should be called just prior
		/// to calling any of these methods. These methods will Invoke the
		/// corresponding vtk event.
		/// </summary>
		// Token: 0x06002013 RID: 8211 RVA: 0x0003100E File Offset: 0x0002F20E
		public virtual void MiddleButtonPressEvent()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_MiddleButtonPressEvent_115(base.GetCppThis());
		}

		// Token: 0x06002014 RID: 8212
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_MiddleButtonReleaseEvent_116(HandleRef pThis);

		/// <summary>
		/// Fire various events. SetEventInformation should be called just prior
		/// to calling any of these methods. These methods will Invoke the
		/// corresponding vtk event.
		/// </summary>
		// Token: 0x06002015 RID: 8213 RVA: 0x0003101D File Offset: 0x0002F21D
		public virtual void MiddleButtonReleaseEvent()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_MiddleButtonReleaseEvent_116(base.GetCppThis());
		}

		// Token: 0x06002016 RID: 8214
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_MouseMoveEvent_117(HandleRef pThis);

		/// <summary>
		/// Fire various events. SetEventInformation should be called just prior
		/// to calling any of these methods. These methods will Invoke the
		/// corresponding vtk event.
		/// </summary>
		// Token: 0x06002017 RID: 8215 RVA: 0x0003102C File Offset: 0x0002F22C
		public virtual void MouseMoveEvent()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_MouseMoveEvent_117(base.GetCppThis());
		}

		// Token: 0x06002018 RID: 8216
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_MouseWheelBackwardEvent_118(HandleRef pThis);

		/// <summary>
		/// Fire various events. SetEventInformation should be called just prior
		/// to calling any of these methods. These methods will Invoke the
		/// corresponding vtk event.
		/// </summary>
		// Token: 0x06002019 RID: 8217 RVA: 0x0003103B File Offset: 0x0002F23B
		public virtual void MouseWheelBackwardEvent()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_MouseWheelBackwardEvent_118(base.GetCppThis());
		}

		// Token: 0x0600201A RID: 8218
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_MouseWheelForwardEvent_119(HandleRef pThis);

		/// <summary>
		/// Fire various events. SetEventInformation should be called just prior
		/// to calling any of these methods. These methods will Invoke the
		/// corresponding vtk event.
		/// </summary>
		// Token: 0x0600201B RID: 8219 RVA: 0x0003104A File Offset: 0x0002F24A
		public virtual void MouseWheelForwardEvent()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_MouseWheelForwardEvent_119(base.GetCppThis());
		}

		// Token: 0x0600201C RID: 8220
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_MouseWheelLeftEvent_120(HandleRef pThis);

		/// <summary>
		/// Fire various events. SetEventInformation should be called just prior
		/// to calling any of these methods. These methods will Invoke the
		/// corresponding vtk event.
		/// </summary>
		// Token: 0x0600201D RID: 8221 RVA: 0x00031059 File Offset: 0x0002F259
		public virtual void MouseWheelLeftEvent()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_MouseWheelLeftEvent_120(base.GetCppThis());
		}

		// Token: 0x0600201E RID: 8222
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_MouseWheelRightEvent_121(HandleRef pThis);

		/// <summary>
		/// Fire various events. SetEventInformation should be called just prior
		/// to calling any of these methods. These methods will Invoke the
		/// corresponding vtk event.
		/// </summary>
		// Token: 0x0600201F RID: 8223 RVA: 0x00031068 File Offset: 0x0002F268
		public virtual void MouseWheelRightEvent()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_MouseWheelRightEvent_121(base.GetCppThis());
		}

		// Token: 0x06002020 RID: 8224
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindowInteractor_NewInstance_123(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002021 RID: 8225 RVA: 0x00031078 File Offset: 0x0002F278
		public new vtkRenderWindowInteractor NewInstance()
		{
			vtkRenderWindowInteractor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderWindowInteractor.vtkRenderWindowInteractor_NewInstance_123(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06002022 RID: 8226
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_PanEvent_124(HandleRef pThis);

		/// <summary>
		/// Fire various gesture based events.  These methods will Invoke the
		/// corresponding vtk event.
		/// </summary>
		// Token: 0x06002023 RID: 8227 RVA: 0x000310D2 File Offset: 0x0002F2D2
		public virtual void PanEvent()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_PanEvent_124(base.GetCppThis());
		}

		// Token: 0x06002024 RID: 8228
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_PinchEvent_125(HandleRef pThis);

		/// <summary>
		/// Fire various gesture based events.  These methods will Invoke the
		/// corresponding vtk event.
		/// </summary>
		// Token: 0x06002025 RID: 8229 RVA: 0x000310E1 File Offset: 0x0002F2E1
		public virtual void PinchEvent()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_PinchEvent_125(base.GetCppThis());
		}

		// Token: 0x06002026 RID: 8230
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_ProcessEvents_126(HandleRef pThis);

		/// <summary>
		/// Process all user-interaction, timer events and return.
		/// If there are no events, this method returns immediately.
		/// This method is implemented only on desktop (macOS, linux, windows) and WebAssembly (SDL2).
		/// It is not implemented on iOS and Android platforms.
		/// </summary>
		// Token: 0x06002027 RID: 8231 RVA: 0x000310F0 File Offset: 0x0002F2F0
		public virtual void ProcessEvents()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_ProcessEvents_126(base.GetCppThis());
		}

		// Token: 0x06002028 RID: 8232
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_ReInitialize_127(HandleRef pThis);

		/// <summary>
		/// Prepare for handling events and set the Enabled flag to true.
		/// This will be called automatically by Start() if the interactor
		/// is not initialized, but it can be called manually if you need
		/// to perform any operations between initialization and the start
		/// of the event loop.
		/// </summary>
		// Token: 0x06002029 RID: 8233 RVA: 0x000310FF File Offset: 0x0002F2FF
		public void ReInitialize()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_ReInitialize_127(base.GetCppThis());
		}

		// Token: 0x0600202A RID: 8234
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_Render_128(HandleRef pThis);

		/// <summary>
		/// Render the scene. Just pass the render call on to the
		/// associated vtkRenderWindow.
		/// </summary>
		// Token: 0x0600202B RID: 8235 RVA: 0x0003110E File Offset: 0x0002F30E
		public virtual void Render()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_Render_128(base.GetCppThis());
		}

		// Token: 0x0600202C RID: 8236
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindowInteractor_ResetTimer_129(HandleRef pThis, int timerId);

		/// <summary>
		/// Reset the specified timer.
		/// </summary>
		// Token: 0x0600202D RID: 8237 RVA: 0x00031120 File Offset: 0x0002F320
		public int ResetTimer(int timerId)
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_ResetTimer_129(base.GetCppThis(), timerId);
		}

		// Token: 0x0600202E RID: 8238
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_RightButtonPressEvent_130(HandleRef pThis);

		/// <summary>
		/// Fire various events. SetEventInformation should be called just prior
		/// to calling any of these methods. These methods will Invoke the
		/// corresponding vtk event.
		/// </summary>
		// Token: 0x0600202F RID: 8239 RVA: 0x00031140 File Offset: 0x0002F340
		public virtual void RightButtonPressEvent()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_RightButtonPressEvent_130(base.GetCppThis());
		}

		// Token: 0x06002030 RID: 8240
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_RightButtonReleaseEvent_131(HandleRef pThis);

		/// <summary>
		/// Fire various events. SetEventInformation should be called just prior
		/// to calling any of these methods. These methods will Invoke the
		/// corresponding vtk event.
		/// </summary>
		// Token: 0x06002031 RID: 8241 RVA: 0x0003114F File Offset: 0x0002F34F
		public virtual void RightButtonReleaseEvent()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_RightButtonReleaseEvent_131(base.GetCppThis());
		}

		// Token: 0x06002032 RID: 8242
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_RotateEvent_132(HandleRef pThis);

		/// <summary>
		/// Fire various gesture based events.  These methods will Invoke the
		/// corresponding vtk event.
		/// </summary>
		// Token: 0x06002033 RID: 8243 RVA: 0x0003115E File Offset: 0x0002F35E
		public virtual void RotateEvent()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_RotateEvent_132(base.GetCppThis());
		}

		// Token: 0x06002034 RID: 8244
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindowInteractor_SafeDownCast_133(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002035 RID: 8245 RVA: 0x00031170 File Offset: 0x0002F370
		public new static vtkRenderWindowInteractor SafeDownCast(vtkObjectBase o)
		{
			vtkRenderWindowInteractor vtkRenderWindowInteractor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderWindowInteractor.vtkRenderWindowInteractor_SafeDownCast_133((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06002036 RID: 8246
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_SetAltKey_134(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get whether alt modifier key was pressed.
		/// </summary>
		// Token: 0x06002037 RID: 8247 RVA: 0x000311EF File Offset: 0x0002F3EF
		public virtual void SetAltKey(int _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetAltKey_134(base.GetCppThis(), _arg);
		}

		// Token: 0x06002038 RID: 8248
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_SetControlKey_135(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get whether control modifier key was pressed.
		/// </summary>
		// Token: 0x06002039 RID: 8249 RVA: 0x000311FF File Offset: 0x0002F3FF
		public virtual void SetControlKey(int _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetControlKey_135(base.GetCppThis(), _arg);
		}

		// Token: 0x0600203A RID: 8250
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_SetDesiredUpdateRate_136(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the desired update rate. This is used by vtkLODActor's to tell
		/// them how quickly they need to render.  This update is in effect only
		/// when the camera is being rotated, or zoomed.  When the interactor is
		/// still, the StillUpdateRate is used instead.
		/// The default is 15.
		/// </summary>
		// Token: 0x0600203B RID: 8251 RVA: 0x0003120F File Offset: 0x0002F40F
		public virtual void SetDesiredUpdateRate(double _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetDesiredUpdateRate_136(base.GetCppThis(), _arg);
		}

		// Token: 0x0600203C RID: 8252
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_SetDolly_137(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the total Dolly value to use when flying to (FlyTo()) a
		/// specified point. Negative values fly away from the point.
		/// </summary>
		// Token: 0x0600203D RID: 8253 RVA: 0x0003121F File Offset: 0x0002F41F
		public virtual void SetDolly(double _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetDolly_137(base.GetCppThis(), _arg);
		}

		// Token: 0x0600203E RID: 8254
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_SetDone_138(HandleRef pThis, byte _arg);

		/// <summary>
		/// Is the interactor loop done
		/// </summary>
		// Token: 0x0600203F RID: 8255 RVA: 0x0003122F File Offset: 0x0002F42F
		public virtual void SetDone(bool _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetDone_138(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06002040 RID: 8256
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_SetEnableRender_139(HandleRef pThis, byte _arg);

		/// <summary>
		/// Enable/Disable whether vtkRenderWindowInteractor::Render() calls
		/// this-&gt;RenderWindow-&gt;Render().
		/// </summary>
		// Token: 0x06002041 RID: 8257 RVA: 0x00031247 File Offset: 0x0002F447
		public virtual void SetEnableRender(bool _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetEnableRender_139(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06002042 RID: 8258
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_SetEventInformation_140(HandleRef pThis, int x, int y, int ctrl, int shift, sbyte keycode, int repeatcount, [MarshalAs(UnmanagedType.LPUTF8Str)] string keysym, int pointerIndex);

		/// <summary>
		/// Set all the event information in one call.
		/// </summary>
		// Token: 0x06002043 RID: 8259 RVA: 0x00031260 File Offset: 0x0002F460
		public void SetEventInformation(int x, int y, int ctrl, int shift, sbyte keycode, int repeatcount, string keysym, int pointerIndex)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetEventInformation_140(base.GetCppThis(), x, y, ctrl, shift, keycode, repeatcount, keysym, pointerIndex);
		}

		// Token: 0x06002044 RID: 8260
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_SetEventInformation_141(HandleRef pThis, int x, int y, int ctrl, int shift, sbyte keycode, int repeatcount, [MarshalAs(UnmanagedType.LPUTF8Str)] string keysym);

		/// <summary>
		/// Set all the event information in one call.
		/// </summary>
		// Token: 0x06002045 RID: 8261 RVA: 0x00031287 File Offset: 0x0002F487
		public void SetEventInformation(int x, int y, int ctrl, int shift, sbyte keycode, int repeatcount, string keysym)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetEventInformation_141(base.GetCppThis(), x, y, ctrl, shift, keycode, repeatcount, keysym);
		}

		// Token: 0x06002046 RID: 8262
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_SetEventInformationFlipY_142(HandleRef pThis, int x, int y, int ctrl, int shift, sbyte keycode, int repeatcount, [MarshalAs(UnmanagedType.LPUTF8Str)] string keysym, int pointerIndex);

		/// <summary>
		/// Calls SetEventInformation, but flips the Y based on the current Size[1]
		/// value (i.e. y = this-&gt;Size[1] - y - 1).
		/// </summary>
		// Token: 0x06002047 RID: 8263 RVA: 0x000312A4 File Offset: 0x0002F4A4
		public void SetEventInformationFlipY(int x, int y, int ctrl, int shift, sbyte keycode, int repeatcount, string keysym, int pointerIndex)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetEventInformationFlipY_142(base.GetCppThis(), x, y, ctrl, shift, keycode, repeatcount, keysym, pointerIndex);
		}

		// Token: 0x06002048 RID: 8264
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_SetEventInformationFlipY_143(HandleRef pThis, int x, int y, int ctrl, int shift, sbyte keycode, int repeatcount, [MarshalAs(UnmanagedType.LPUTF8Str)] string keysym);

		/// <summary>
		/// Calls SetEventInformation, but flips the Y based on the current Size[1]
		/// value (i.e. y = this-&gt;Size[1] - y - 1).
		/// </summary>
		// Token: 0x06002049 RID: 8265 RVA: 0x000312CB File Offset: 0x0002F4CB
		public void SetEventInformationFlipY(int x, int y, int ctrl, int shift, sbyte keycode, int repeatcount, string keysym)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetEventInformationFlipY_143(base.GetCppThis(), x, y, ctrl, shift, keycode, repeatcount, keysym);
		}

		// Token: 0x0600204A RID: 8266
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_SetEventPosition_144(HandleRef pThis, int x, int y);

		/// <summary>
		/// Set/Get information about the current event.
		/// The current x,y position is in the EventPosition, and the previous
		/// event position is in LastEventPosition, updated automatically each
		/// time EventPosition is set using its Set() method. Mouse positions
		/// are measured in pixels.
		/// The other information is about key board input.
		/// </summary>
		// Token: 0x0600204B RID: 8267 RVA: 0x000312E5 File Offset: 0x0002F4E5
		public virtual void SetEventPosition(int x, int y)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetEventPosition_144(base.GetCppThis(), x, y);
		}

		// Token: 0x0600204C RID: 8268
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_SetEventPosition_145(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Set/Get information about the current event.
		/// The current x,y position is in the EventPosition, and the previous
		/// event position is in LastEventPosition, updated automatically each
		/// time EventPosition is set using its Set() method. Mouse positions
		/// are measured in pixels.
		/// The other information is about key board input.
		/// </summary>
		// Token: 0x0600204D RID: 8269 RVA: 0x000312F6 File Offset: 0x0002F4F6
		public virtual void SetEventPosition(IntPtr pos)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetEventPosition_145(base.GetCppThis(), pos);
		}

		// Token: 0x0600204E RID: 8270
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_SetEventPosition_146(HandleRef pThis, int x, int y, int pointerIndex);

		/// <summary>
		/// Set/Get information about the current event.
		/// The current x,y position is in the EventPosition, and the previous
		/// event position is in LastEventPosition, updated automatically each
		/// time EventPosition is set using its Set() method. Mouse positions
		/// are measured in pixels.
		/// The other information is about key board input.
		/// </summary>
		// Token: 0x0600204F RID: 8271 RVA: 0x00031306 File Offset: 0x0002F506
		public virtual void SetEventPosition(int x, int y, int pointerIndex)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetEventPosition_146(base.GetCppThis(), x, y, pointerIndex);
		}

		// Token: 0x06002050 RID: 8272
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_SetEventPosition_147(HandleRef pThis, IntPtr pos, int pointerIndex);

		/// <summary>
		/// Set/Get information about the current event.
		/// The current x,y position is in the EventPosition, and the previous
		/// event position is in LastEventPosition, updated automatically each
		/// time EventPosition is set using its Set() method. Mouse positions
		/// are measured in pixels.
		/// The other information is about key board input.
		/// </summary>
		// Token: 0x06002051 RID: 8273 RVA: 0x00031318 File Offset: 0x0002F518
		public virtual void SetEventPosition(IntPtr pos, int pointerIndex)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetEventPosition_147(base.GetCppThis(), pos, pointerIndex);
		}

		// Token: 0x06002052 RID: 8274
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_SetEventPositionFlipY_148(HandleRef pThis, int x, int y);

		/// <summary>
		/// Set/Get information about the current event.
		/// The current x,y position is in the EventPosition, and the previous
		/// event position is in LastEventPosition, updated automatically each
		/// time EventPosition is set using its Set() method. Mouse positions
		/// are measured in pixels.
		/// The other information is about key board input.
		/// </summary>
		// Token: 0x06002053 RID: 8275 RVA: 0x00031329 File Offset: 0x0002F529
		public virtual void SetEventPositionFlipY(int x, int y)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetEventPositionFlipY_148(base.GetCppThis(), x, y);
		}

		// Token: 0x06002054 RID: 8276
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_SetEventPositionFlipY_149(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Set/Get information about the current event.
		/// The current x,y position is in the EventPosition, and the previous
		/// event position is in LastEventPosition, updated automatically each
		/// time EventPosition is set using its Set() method. Mouse positions
		/// are measured in pixels.
		/// The other information is about key board input.
		/// </summary>
		// Token: 0x06002055 RID: 8277 RVA: 0x0003133A File Offset: 0x0002F53A
		public virtual void SetEventPositionFlipY(IntPtr pos)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetEventPositionFlipY_149(base.GetCppThis(), pos);
		}

		// Token: 0x06002056 RID: 8278
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_SetEventPositionFlipY_150(HandleRef pThis, int x, int y, int pointerIndex);

		/// <summary>
		/// Set/Get information about the current event.
		/// The current x,y position is in the EventPosition, and the previous
		/// event position is in LastEventPosition, updated automatically each
		/// time EventPosition is set using its Set() method. Mouse positions
		/// are measured in pixels.
		/// The other information is about key board input.
		/// </summary>
		// Token: 0x06002057 RID: 8279 RVA: 0x0003134A File Offset: 0x0002F54A
		public virtual void SetEventPositionFlipY(int x, int y, int pointerIndex)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetEventPositionFlipY_150(base.GetCppThis(), x, y, pointerIndex);
		}

		// Token: 0x06002058 RID: 8280
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_SetEventPositionFlipY_151(HandleRef pThis, IntPtr pos, int pointerIndex);

		/// <summary>
		/// Set/Get information about the current event.
		/// The current x,y position is in the EventPosition, and the previous
		/// event position is in LastEventPosition, updated automatically each
		/// time EventPosition is set using its Set() method. Mouse positions
		/// are measured in pixels.
		/// The other information is about key board input.
		/// </summary>
		// Token: 0x06002059 RID: 8281 RVA: 0x0003135C File Offset: 0x0002F55C
		public virtual void SetEventPositionFlipY(IntPtr pos, int pointerIndex)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetEventPositionFlipY_151(base.GetCppThis(), pos, pointerIndex);
		}

		// Token: 0x0600205A RID: 8282
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_SetEventSize_152(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// This methods sets the Size ivar of the interactor without
		/// actually changing the size of the window. Normally
		/// application programmers would use UpdateSize if anything.
		/// This is useful for letting someone else change the size of
		/// the rendering window and just letting the interactor
		/// know about the change.
		/// The current event width/height (if any) is in EventSize
		/// (Expose event, for example).
		/// Window size is measured in pixels.
		/// </summary>
		// Token: 0x0600205B RID: 8283 RVA: 0x0003136D File Offset: 0x0002F56D
		public virtual void SetEventSize(int _arg1, int _arg2)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetEventSize_152(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600205C RID: 8284
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_SetEventSize_153(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// This methods sets the Size ivar of the interactor without
		/// actually changing the size of the window. Normally
		/// application programmers would use UpdateSize if anything.
		/// This is useful for letting someone else change the size of
		/// the rendering window and just letting the interactor
		/// know about the change.
		/// The current event width/height (if any) is in EventSize
		/// (Expose event, for example).
		/// Window size is measured in pixels.
		/// </summary>
		// Token: 0x0600205D RID: 8285 RVA: 0x0003137E File Offset: 0x0002F57E
		public void SetEventSize(IntPtr _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetEventSize_153(base.GetCppThis(), _arg);
		}

		// Token: 0x0600205E RID: 8286
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_SetHardwareWindow_154(HandleRef pThis, HandleRef aren);

		/// <summary>
		/// Set/Get the hardware window being controlled by this object.
		/// For opengl the hardware window is not used as the opengl
		/// subclasses of RenderWindow provide the functionality.
		/// </summary>
		// Token: 0x0600205F RID: 8287 RVA: 0x00031390 File Offset: 0x0002F590
		public void SetHardwareWindow(vtkHardwareWindow aren)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetHardwareWindow_154(base.GetCppThis(), (aren == null) ? default(HandleRef) : aren.GetCppThis());
		}

		// Token: 0x06002060 RID: 8288
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_SetInteractorStyle_155(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// External switching between joystick/trackball/new? modes. Initial value
		/// is a vtkInteractorStyleSwitch object.
		/// </summary>
		// Token: 0x06002061 RID: 8289 RVA: 0x000313C0 File Offset: 0x0002F5C0
		public virtual void SetInteractorStyle(vtkInteractorObserver arg0)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetInteractorStyle_155(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002062 RID: 8290
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_SetKeyCode_156(HandleRef pThis, sbyte _arg);

		/// <summary>
		/// Set/get the key code for the key that was pressed.
		/// </summary>
		// Token: 0x06002063 RID: 8291 RVA: 0x000313EF File Offset: 0x0002F5EF
		public virtual void SetKeyCode(sbyte _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetKeyCode_156(base.GetCppThis(), _arg);
		}

		// Token: 0x06002064 RID: 8292
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_SetKeyEventInformation_157(HandleRef pThis, int ctrl, int shift, sbyte keycode, int repeatcount, [MarshalAs(UnmanagedType.LPUTF8Str)] string keysym);

		/// <summary>
		/// Set all the keyboard-related event information in one call.
		/// </summary>
		// Token: 0x06002065 RID: 8293 RVA: 0x000313FF File Offset: 0x0002F5FF
		public void SetKeyEventInformation(int ctrl, int shift, sbyte keycode, int repeatcount, string keysym)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetKeyEventInformation_157(base.GetCppThis(), ctrl, shift, keycode, repeatcount, keysym);
		}

		// Token: 0x06002066 RID: 8294
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_SetKeySym_158(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/get the key symbol for the key that was pressed. This is the key
		/// symbol as defined by the relevant X headers. On X based platforms this
		/// corresponds to the installed X server, whereas on other platforms the
		/// native key codes are translated into a string representation.
		/// </summary>
		// Token: 0x06002067 RID: 8295 RVA: 0x00031415 File Offset: 0x0002F615
		public virtual void SetKeySym(string _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetKeySym_158(base.GetCppThis(), _arg);
		}

		// Token: 0x06002068 RID: 8296
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_SetLastEventPosition_159(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Set/Get information about the current event.
		/// The current x,y position is in the EventPosition, and the previous
		/// event position is in LastEventPosition, updated automatically each
		/// time EventPosition is set using its Set() method. Mouse positions
		/// are measured in pixels.
		/// The other information is about key board input.
		/// </summary>
		// Token: 0x06002069 RID: 8297 RVA: 0x00031425 File Offset: 0x0002F625
		public virtual void SetLastEventPosition(int _arg1, int _arg2)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetLastEventPosition_159(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600206A RID: 8298
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_SetLastEventPosition_160(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get information about the current event.
		/// The current x,y position is in the EventPosition, and the previous
		/// event position is in LastEventPosition, updated automatically each
		/// time EventPosition is set using its Set() method. Mouse positions
		/// are measured in pixels.
		/// The other information is about key board input.
		/// </summary>
		// Token: 0x0600206B RID: 8299 RVA: 0x00031436 File Offset: 0x0002F636
		public void SetLastEventPosition(IntPtr _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetLastEventPosition_160(base.GetCppThis(), _arg);
		}

		// Token: 0x0600206C RID: 8300
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_SetLightFollowCamera_161(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the automatic repositioning of lights as the camera moves.
		/// Default is On.
		/// </summary>
		// Token: 0x0600206D RID: 8301 RVA: 0x00031446 File Offset: 0x0002F646
		public virtual void SetLightFollowCamera(int _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetLightFollowCamera_161(base.GetCppThis(), _arg);
		}

		// Token: 0x0600206E RID: 8302
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_SetNumberOfFlyFrames_162(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the number of frames to fly to when FlyTo is invoked.
		/// </summary>
		// Token: 0x0600206F RID: 8303 RVA: 0x00031456 File Offset: 0x0002F656
		public virtual void SetNumberOfFlyFrames(int _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetNumberOfFlyFrames_162(base.GetCppThis(), _arg);
		}

		// Token: 0x06002070 RID: 8304
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_SetPicker_163(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the object used to perform pick operations. In order to
		/// pick instances of vtkProp, the picker must be a subclass of
		/// vtkAbstractPropPicker, meaning that it can identify a particular
		/// instance of vtkProp.
		/// </summary>
		// Token: 0x06002071 RID: 8305 RVA: 0x00031468 File Offset: 0x0002F668
		public virtual void SetPicker(vtkAbstractPicker arg0)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetPicker_163(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002072 RID: 8306
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_SetPickingManager_164(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the picking manager.
		/// Set/Get the object used to perform operations through the interactor
		/// By default, a valid but disabled picking manager is instantiated.
		/// </summary>
		// Token: 0x06002073 RID: 8307 RVA: 0x00031498 File Offset: 0x0002F698
		public virtual void SetPickingManager(vtkPickingManager arg0)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetPickingManager_164(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002074 RID: 8308
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_SetPointerIndex_165(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the index of the most recent pointer to have an event
		/// </summary>
		// Token: 0x06002075 RID: 8309 RVA: 0x000314C7 File Offset: 0x0002F6C7
		public virtual void SetPointerIndex(int _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetPointerIndex_165(base.GetCppThis(), _arg);
		}

		// Token: 0x06002076 RID: 8310
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_SetRecognizeGestures_166(HandleRef pThis, byte _arg);

		/// <summary>
		/// Convert multitouch events into gestures. When this is on
		/// (its default) multitouch events received by this interactor
		/// will be converted into gestures by VTK. If turned off the
		/// raw multitouch events will be passed down.
		/// </summary>
		// Token: 0x06002077 RID: 8311 RVA: 0x000314D7 File Offset: 0x0002F6D7
		public virtual void SetRecognizeGestures(bool _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetRecognizeGestures_166(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06002078 RID: 8312
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_SetRenderWindow_167(HandleRef pThis, HandleRef aren);

		/// <summary>
		/// Set/Get the rendering window being controlled by this object.
		/// </summary>
		// Token: 0x06002079 RID: 8313 RVA: 0x000314F0 File Offset: 0x0002F6F0
		public void SetRenderWindow(vtkRenderWindow aren)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetRenderWindow_167(base.GetCppThis(), (aren == null) ? default(HandleRef) : aren.GetCppThis());
		}

		// Token: 0x0600207A RID: 8314
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_SetRepeatCount_168(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the repear count for the key or mouse event. This specifies how
		/// many times a key has been pressed.
		/// </summary>
		// Token: 0x0600207B RID: 8315 RVA: 0x0003151F File Offset: 0x0002F71F
		public virtual void SetRepeatCount(int _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetRepeatCount_168(base.GetCppThis(), _arg);
		}

		// Token: 0x0600207C RID: 8316
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_SetRotation_169(HandleRef pThis, double rotation);

		/// <summary>
		/// Set/get the rotation for the gesture in degrees, update LastRotation
		/// </summary>
		// Token: 0x0600207D RID: 8317 RVA: 0x0003152F File Offset: 0x0002F72F
		public void SetRotation(double rotation)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetRotation_169(base.GetCppThis(), rotation);
		}

		// Token: 0x0600207E RID: 8318
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_SetScale_170(HandleRef pThis, double scale);

		/// <summary>
		/// Set/get the scale for the gesture, updates LastScale
		/// </summary>
		// Token: 0x0600207F RID: 8319 RVA: 0x0003153F File Offset: 0x0002F73F
		public void SetScale(double scale)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetScale_170(base.GetCppThis(), scale);
		}

		// Token: 0x06002080 RID: 8320
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_SetShiftKey_171(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get whether shift modifier key was pressed.
		/// </summary>
		// Token: 0x06002081 RID: 8321 RVA: 0x0003154F File Offset: 0x0002F74F
		public virtual void SetShiftKey(int _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetShiftKey_171(base.GetCppThis(), _arg);
		}

		// Token: 0x06002082 RID: 8322
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_SetSize_172(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// This methods sets the Size ivar of the interactor without
		/// actually changing the size of the window. Normally
		/// application programmers would use UpdateSize if anything.
		/// This is useful for letting someone else change the size of
		/// the rendering window and just letting the interactor
		/// know about the change.
		/// The current event width/height (if any) is in EventSize
		/// (Expose event, for example).
		/// Window size is measured in pixels.
		/// </summary>
		// Token: 0x06002083 RID: 8323 RVA: 0x0003155F File Offset: 0x0002F75F
		public virtual void SetSize(int _arg1, int _arg2)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetSize_172(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x06002084 RID: 8324
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_SetSize_173(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// This methods sets the Size ivar of the interactor without
		/// actually changing the size of the window. Normally
		/// application programmers would use UpdateSize if anything.
		/// This is useful for letting someone else change the size of
		/// the rendering window and just letting the interactor
		/// know about the change.
		/// The current event width/height (if any) is in EventSize
		/// (Expose event, for example).
		/// Window size is measured in pixels.
		/// </summary>
		// Token: 0x06002085 RID: 8325 RVA: 0x00031570 File Offset: 0x0002F770
		public void SetSize(IntPtr _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetSize_173(base.GetCppThis(), _arg);
		}

		// Token: 0x06002086 RID: 8326
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_SetStillUpdateRate_174(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the desired update rate when movement has stopped.
		/// For the non-still update rate, see the SetDesiredUpdateRate method.
		/// The default is 0.0001
		/// </summary>
		// Token: 0x06002087 RID: 8327 RVA: 0x00031580 File Offset: 0x0002F780
		public virtual void SetStillUpdateRate(double _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetStillUpdateRate_174(base.GetCppThis(), _arg);
		}

		// Token: 0x06002088 RID: 8328
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_SetTimerDuration_175(HandleRef pThis, uint _arg);

		/// <summary>
		/// Specify the default timer interval (in milliseconds). (This is used in
		/// conjunction with the timer methods described previously, e.g.,
		/// CreateTimer() uses this value; and CreateRepeatingTimer(duration) and
		/// CreateOneShotTimer(duration) use the default value if the parameter
		/// "duration" is less than or equal to zero.) Care must be taken when
		/// adjusting the timer interval from the default value of 10
		/// milliseconds--it may adversely affect the interactors.
		/// </summary>
		// Token: 0x06002089 RID: 8329 RVA: 0x00031590 File Offset: 0x0002F790
		public virtual void SetTimerDuration(uint _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetTimerDuration_175(base.GetCppThis(), _arg);
		}

		// Token: 0x0600208A RID: 8330
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_SetTimerEventDuration_176(HandleRef pThis, int _arg);

		/// <summary>
		/// These methods are used to communicate information about the currently
		/// firing CreateTimerEvent or DestroyTimerEvent. The caller of
		/// CreateTimerEvent sets up TimerEventId, TimerEventType and
		/// TimerEventDuration. The observer of CreateTimerEvent should set up an
		/// appropriate platform specific timer based on those values and set the
		/// TimerEventPlatformId before returning. The caller of DestroyTimerEvent
		/// sets up TimerEventPlatformId. The observer of DestroyTimerEvent should
		/// simply destroy the platform specific timer created by CreateTimerEvent.
		/// See vtkGenericRenderWindowInteractor's InternalCreateTimer and
		/// InternalDestroyTimer for an example.
		/// </summary>
		// Token: 0x0600208B RID: 8331 RVA: 0x000315A0 File Offset: 0x0002F7A0
		public virtual void SetTimerEventDuration(int _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetTimerEventDuration_176(base.GetCppThis(), _arg);
		}

		// Token: 0x0600208C RID: 8332
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_SetTimerEventId_177(HandleRef pThis, int _arg);

		/// <summary>
		/// These methods are used to communicate information about the currently
		/// firing CreateTimerEvent or DestroyTimerEvent. The caller of
		/// CreateTimerEvent sets up TimerEventId, TimerEventType and
		/// TimerEventDuration. The observer of CreateTimerEvent should set up an
		/// appropriate platform specific timer based on those values and set the
		/// TimerEventPlatformId before returning. The caller of DestroyTimerEvent
		/// sets up TimerEventPlatformId. The observer of DestroyTimerEvent should
		/// simply destroy the platform specific timer created by CreateTimerEvent.
		/// See vtkGenericRenderWindowInteractor's InternalCreateTimer and
		/// InternalDestroyTimer for an example.
		/// </summary>
		// Token: 0x0600208D RID: 8333 RVA: 0x000315B0 File Offset: 0x0002F7B0
		public virtual void SetTimerEventId(int _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetTimerEventId_177(base.GetCppThis(), _arg);
		}

		// Token: 0x0600208E RID: 8334
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_SetTimerEventPlatformId_178(HandleRef pThis, int _arg);

		/// <summary>
		/// These methods are used to communicate information about the currently
		/// firing CreateTimerEvent or DestroyTimerEvent. The caller of
		/// CreateTimerEvent sets up TimerEventId, TimerEventType and
		/// TimerEventDuration. The observer of CreateTimerEvent should set up an
		/// appropriate platform specific timer based on those values and set the
		/// TimerEventPlatformId before returning. The caller of DestroyTimerEvent
		/// sets up TimerEventPlatformId. The observer of DestroyTimerEvent should
		/// simply destroy the platform specific timer created by CreateTimerEvent.
		/// See vtkGenericRenderWindowInteractor's InternalCreateTimer and
		/// InternalDestroyTimer for an example.
		/// </summary>
		// Token: 0x0600208F RID: 8335 RVA: 0x000315C0 File Offset: 0x0002F7C0
		public virtual void SetTimerEventPlatformId(int _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetTimerEventPlatformId_178(base.GetCppThis(), _arg);
		}

		// Token: 0x06002090 RID: 8336
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_SetTimerEventType_179(HandleRef pThis, int _arg);

		/// <summary>
		/// These methods are used to communicate information about the currently
		/// firing CreateTimerEvent or DestroyTimerEvent. The caller of
		/// CreateTimerEvent sets up TimerEventId, TimerEventType and
		/// TimerEventDuration. The observer of CreateTimerEvent should set up an
		/// appropriate platform specific timer based on those values and set the
		/// TimerEventPlatformId before returning. The caller of DestroyTimerEvent
		/// sets up TimerEventPlatformId. The observer of DestroyTimerEvent should
		/// simply destroy the platform specific timer created by CreateTimerEvent.
		/// See vtkGenericRenderWindowInteractor's InternalCreateTimer and
		/// InternalDestroyTimer for an example.
		/// </summary>
		// Token: 0x06002091 RID: 8337 RVA: 0x000315D0 File Offset: 0x0002F7D0
		public virtual void SetTimerEventType(int _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetTimerEventType_179(base.GetCppThis(), _arg);
		}

		// Token: 0x06002092 RID: 8338
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_SetTranslation_180(HandleRef pThis, IntPtr val);

		/// <summary>
		/// Set/get the translation for pan/swipe gestures, update LastTranslation
		/// </summary>
		// Token: 0x06002093 RID: 8339 RVA: 0x000315E0 File Offset: 0x0002F7E0
		public void SetTranslation(IntPtr val)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetTranslation_180(base.GetCppThis(), val);
		}

		// Token: 0x06002094 RID: 8340
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_SetUseTDx_181(HandleRef pThis, byte _arg);

		/// <summary>
		/// Use a 3DConnexion device. Initial value is false.
		/// If VTK is not build with the TDx option, this is no-op.
		/// If VTK is build with the TDx option, and a device is not connected,
		/// a warning is emitted.
		/// It is must be called before the first Render to be effective, otherwise
		/// it is ignored.
		/// </summary>
		// Token: 0x06002095 RID: 8341 RVA: 0x000315F0 File Offset: 0x0002F7F0
		public virtual void SetUseTDx(bool _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetUseTDx_181(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06002096 RID: 8342
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_ShowCursor_182(HandleRef pThis);

		/// <summary>
		/// Hide or show the mouse cursor, it is nice to be able to hide the
		/// default cursor if you want VTK to display a 3D cursor instead.
		/// </summary>
		// Token: 0x06002097 RID: 8343 RVA: 0x00031608 File Offset: 0x0002F808
		public void ShowCursor()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_ShowCursor_182(base.GetCppThis());
		}

		// Token: 0x06002098 RID: 8344
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_Start_183(HandleRef pThis);

		/// <summary>
		/// Start the event loop. This is provided so that you do not have to
		/// implement your own event loop. You still can use your own
		/// event loop if you want.
		/// </summary>
		// Token: 0x06002099 RID: 8345 RVA: 0x00031617 File Offset: 0x0002F817
		public virtual void Start()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_Start_183(base.GetCppThis());
		}

		// Token: 0x0600209A RID: 8346
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_StartPanEvent_184(HandleRef pThis);

		/// <summary>
		/// Fire various gesture based events.  These methods will Invoke the
		/// corresponding vtk event.
		/// </summary>
		// Token: 0x0600209B RID: 8347 RVA: 0x00031626 File Offset: 0x0002F826
		public virtual void StartPanEvent()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_StartPanEvent_184(base.GetCppThis());
		}

		// Token: 0x0600209C RID: 8348
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_StartPickCallback_185(HandleRef pThis);

		/// <summary>
		/// These methods correspond to the Exit, User and Pick
		/// callbacks. They allow for the Style to invoke them.
		/// </summary>
		// Token: 0x0600209D RID: 8349 RVA: 0x00031635 File Offset: 0x0002F835
		public virtual void StartPickCallback()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_StartPickCallback_185(base.GetCppThis());
		}

		// Token: 0x0600209E RID: 8350
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_StartPinchEvent_186(HandleRef pThis);

		/// <summary>
		/// Fire various gesture based events.  These methods will Invoke the
		/// corresponding vtk event.
		/// </summary>
		// Token: 0x0600209F RID: 8351 RVA: 0x00031644 File Offset: 0x0002F844
		public virtual void StartPinchEvent()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_StartPinchEvent_186(base.GetCppThis());
		}

		// Token: 0x060020A0 RID: 8352
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_StartRotateEvent_187(HandleRef pThis);

		/// <summary>
		/// Fire various gesture based events.  These methods will Invoke the
		/// corresponding vtk event.
		/// </summary>
		// Token: 0x060020A1 RID: 8353 RVA: 0x00031653 File Offset: 0x0002F853
		public virtual void StartRotateEvent()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_StartRotateEvent_187(base.GetCppThis());
		}

		// Token: 0x060020A2 RID: 8354
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_SwipeEvent_188(HandleRef pThis);

		/// <summary>
		/// Fire various gesture based events.  These methods will Invoke the
		/// corresponding vtk event.
		/// </summary>
		// Token: 0x060020A3 RID: 8355 RVA: 0x00031662 File Offset: 0x0002F862
		public virtual void SwipeEvent()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SwipeEvent_188(base.GetCppThis());
		}

		// Token: 0x060020A4 RID: 8356
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_TapEvent_189(HandleRef pThis);

		/// <summary>
		/// Fire various gesture based events.  These methods will Invoke the
		/// corresponding vtk event.
		/// </summary>
		// Token: 0x060020A5 RID: 8357 RVA: 0x00031671 File Offset: 0x0002F871
		public virtual void TapEvent()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_TapEvent_189(base.GetCppThis());
		}

		// Token: 0x060020A6 RID: 8358
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_TerminateApp_190(HandleRef pThis);

		/// <summary>
		/// This function is called on 'q','e' keypress if exitmethod is not
		/// specified and should be overridden by platform dependent subclasses
		/// to provide a termination procedure if one is required.
		/// </summary>
		// Token: 0x060020A7 RID: 8359 RVA: 0x00031680 File Offset: 0x0002F880
		public virtual void TerminateApp()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_TerminateApp_190(base.GetCppThis());
		}

		// Token: 0x060020A8 RID: 8360
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_UpdateSize_192(HandleRef pThis, int x, int y);

		/// <summary>
		/// Event loop notification member for window size change.
		/// Window size is measured in pixels.
		///
		/// If the size has changed, this method will fire
		/// vtkCommand::WindowResizeEvent.
		/// </summary>
		// Token: 0x060020A9 RID: 8361 RVA: 0x0003168F File Offset: 0x0002F88F
		public virtual void UpdateSize(int x, int y)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_UpdateSize_192(base.GetCppThis(), x, y);
		}

		// Token: 0x060020AA RID: 8362
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor_UserCallback_193(HandleRef pThis);

		/// <summary>
		/// These methods correspond to the Exit, User and Pick
		/// callbacks. They allow for the Style to invoke them.
		/// </summary>
		// Token: 0x060020AB RID: 8363 RVA: 0x000316A0 File Offset: 0x0002F8A0
		public virtual void UserCallback()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_UserCallback_193(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000512 RID: 1298
		public new const string MRFullTypeName = "Kitware.VTK.vtkRenderWindowInteractor";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000513 RID: 1299
		public new static readonly string MRClassNameKey = "class vtkRenderWindowInteractor";

		/// <summary>
		/// Get the VTK timer ID that corresponds to the supplied platform ID.
		/// </summary>
		// Token: 0x0200009A RID: 154
		public enum OneShotTimer_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000515 RID: 1301
			OneShotTimer = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000516 RID: 1302
			RepeatingTimer
		}
	}
}
