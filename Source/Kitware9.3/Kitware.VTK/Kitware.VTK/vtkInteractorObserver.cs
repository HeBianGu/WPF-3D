using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInteractorObserver
	/// </summary>
	/// <remarks>
	///    an abstract superclass for classes observing events invoked by vtkRenderWindowInteractor
	///
	/// vtkInteractorObserver is an abstract superclass for subclasses that observe
	/// events invoked by vtkRenderWindowInteractor. These subclasses are
	/// typically things like 3D widgets; objects that interact with actors
	/// in the scene, or interactively probe the scene for information.
	///
	/// vtkInteractorObserver defines the method SetInteractor() and enables and
	/// disables the processing of events by the vtkInteractorObserver. Use the
	/// methods EnabledOn() or SetEnabled(1) to turn on the interactor observer,
	/// and the methods EnabledOff() or SetEnabled(0) to turn off the interactor.
	/// Initial value is 0.
	///
	/// To support interactive manipulation of objects, this class (and
	/// subclasses) invoke the events StartInteractionEvent, InteractionEvent, and
	/// EndInteractionEvent.  These events are invoked when the
	/// vtkInteractorObserver enters a state where rapid response is desired:
	/// mouse motion, etc. The events can be used, for example, to set the desired
	/// update frame rate (StartInteractionEvent), operate on data or update a
	/// pipeline (InteractionEvent), and set the desired frame rate back to normal
	/// values (EndInteractionEvent). Two other events, EnableEvent and
	/// DisableEvent, are invoked when the interactor observer is enabled or
	/// disabled.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtk3DWidget vtkBoxWidget vtkLineWidget
	/// </seealso>
	// Token: 0x02000053 RID: 83
	public class vtkInteractorObserver : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06000E13 RID: 3603 RVA: 0x0001AD77 File Offset: 0x00018F77
		static vtkInteractorObserver()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInteractorObserver.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorObserver"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06000E14 RID: 3604 RVA: 0x0001AD9F File Offset: 0x00018F9F
		public vtkInteractorObserver(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06000E15 RID: 3605 RVA: 0x0001ADAD File Offset: 0x00018FAD
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06000E16 RID: 3606
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorObserver_ComputeDisplayToWorld_01(HandleRef ren, double x, double y, double z, IntPtr worldPt);

		/// <summary>
		/// Convenience methods for outside classes. Make sure that the
		/// parameter "ren" is not-null.
		/// </summary>
		// Token: 0x06000E17 RID: 3607 RVA: 0x0001ADB8 File Offset: 0x00018FB8
		public static void ComputeDisplayToWorld(vtkRenderer ren, double x, double y, double z, IntPtr worldPt)
		{
			vtkInteractorObserver.vtkInteractorObserver_ComputeDisplayToWorld_01((ren == null) ? default(HandleRef) : ren.GetCppThis(), x, y, z, worldPt);
		}

		// Token: 0x06000E18 RID: 3608
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorObserver_ComputeWorldToDisplay_02(HandleRef ren, double x, double y, double z, IntPtr displayPt);

		/// <summary>
		/// Convenience methods for outside classes. Make sure that the
		/// parameter "ren" is not-null.
		/// </summary>
		// Token: 0x06000E19 RID: 3609 RVA: 0x0001ADE8 File Offset: 0x00018FE8
		public static void ComputeWorldToDisplay(vtkRenderer ren, double x, double y, double z, IntPtr displayPt)
		{
			vtkInteractorObserver.vtkInteractorObserver_ComputeWorldToDisplay_02((ren == null) ? default(HandleRef) : ren.GetCppThis(), x, y, z, displayPt);
		}

		// Token: 0x06000E1A RID: 3610
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorObserver_EnabledOff_03(HandleRef pThis);

		/// <summary>
		/// Methods for turning the interactor observer on and off, and determining
		/// its state. All subclasses must provide the SetEnabled() method.
		/// Enabling a vtkInteractorObserver has the side effect of adding
		/// observers; disabling it removes the observers. Prior to enabling the
		/// vtkInteractorObserver you must set the render window interactor (via
		/// SetInteractor()). Initial value is 0.
		/// </summary>
		// Token: 0x06000E1B RID: 3611 RVA: 0x0001AE16 File Offset: 0x00019016
		public void EnabledOff()
		{
			vtkInteractorObserver.vtkInteractorObserver_EnabledOff_03(base.GetCppThis());
		}

		// Token: 0x06000E1C RID: 3612
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorObserver_EnabledOn_04(HandleRef pThis);

		/// <summary>
		/// Methods for turning the interactor observer on and off, and determining
		/// its state. All subclasses must provide the SetEnabled() method.
		/// Enabling a vtkInteractorObserver has the side effect of adding
		/// observers; disabling it removes the observers. Prior to enabling the
		/// vtkInteractorObserver you must set the render window interactor (via
		/// SetInteractor()). Initial value is 0.
		/// </summary>
		// Token: 0x06000E1D RID: 3613 RVA: 0x0001AE25 File Offset: 0x00019025
		public void EnabledOn()
		{
			vtkInteractorObserver.vtkInteractorObserver_EnabledOn_04(base.GetCppThis());
		}

		// Token: 0x06000E1E RID: 3614
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorObserver_GetCurrentRenderer_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the current renderer. Normally when the widget is activated
		/// (SetEnabled(1) or when keypress activation takes place), the renderer
		/// over which the mouse pointer is positioned is used and assigned to
		/// this Ivar. Alternatively, you might want to set the CurrentRenderer
		/// explicitly. This is especially true with multiple viewports (renderers).
		/// WARNING: note that if the DefaultRenderer Ivar is set (see above),
		/// it will always override the parameter passed to SetCurrentRenderer,
		/// unless it is NULL.
		/// (i.e., SetCurrentRenderer(foo) = SetCurrentRenderer(DefaultRenderer).
		/// </summary>
		// Token: 0x06000E1F RID: 3615 RVA: 0x0001AE34 File Offset: 0x00019034
		public virtual vtkRenderer GetCurrentRenderer()
		{
			vtkRenderer vtkRenderer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorObserver.vtkInteractorObserver_GetCurrentRenderer_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06000E20 RID: 3616
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorObserver_GetDefaultRenderer_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the default renderer to use when activating the interactor
		/// observer. Normally when the widget is activated (SetEnabled(1) or when
		/// keypress activation takes place), the renderer over which the mouse
		/// pointer is positioned is used. Alternatively, you can specify the
		/// renderer to bind the interactor to when the interactor observer is
		/// activated.
		/// </summary>
		// Token: 0x06000E21 RID: 3617 RVA: 0x0001AEA4 File Offset: 0x000190A4
		public virtual vtkRenderer GetDefaultRenderer()
		{
			vtkRenderer vtkRenderer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorObserver.vtkInteractorObserver_GetDefaultRenderer_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06000E22 RID: 3618
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorObserver_GetEnabled_07(HandleRef pThis);

		/// <summary>
		/// Methods for turning the interactor observer on and off, and determining
		/// its state. All subclasses must provide the SetEnabled() method.
		/// Enabling a vtkInteractorObserver has the side effect of adding
		/// observers; disabling it removes the observers. Prior to enabling the
		/// vtkInteractorObserver you must set the render window interactor (via
		/// SetInteractor()). Initial value is 0.
		/// </summary>
		// Token: 0x06000E23 RID: 3619 RVA: 0x0001AF14 File Offset: 0x00019114
		public int GetEnabled()
		{
			return vtkInteractorObserver.vtkInteractorObserver_GetEnabled_07(base.GetCppThis());
		}

		// Token: 0x06000E24 RID: 3620
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorObserver_GetInteractor_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This method is used to associate the widget with the render window
		/// interactor.  Observers of the appropriate events invoked in the render
		/// window interactor are set up as a result of this method invocation.
		/// The SetInteractor() method must be invoked prior to enabling the
		/// vtkInteractorObserver.
		/// It automatically registers available pickers to the Picking Manager.
		/// </summary>
		// Token: 0x06000E25 RID: 3621 RVA: 0x0001AF34 File Offset: 0x00019134
		public virtual vtkRenderWindowInteractor GetInteractor()
		{
			vtkRenderWindowInteractor vtkRenderWindowInteractor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorObserver.vtkInteractorObserver_GetInteractor_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06000E26 RID: 3622
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorObserver_GetKeyPressActivation_09(HandleRef pThis);

		/// <summary>
		/// Enable/Disable of the use of a keypress to turn on and off the
		/// interactor observer. (By default, the keypress is 'i' for "interactor
		/// observer".)  Set the KeyPressActivationValue to change which key
		/// activates the widget.)
		/// </summary>
		// Token: 0x06000E27 RID: 3623 RVA: 0x0001AFA4 File Offset: 0x000191A4
		public virtual int GetKeyPressActivation()
		{
			return vtkInteractorObserver.vtkInteractorObserver_GetKeyPressActivation_09(base.GetCppThis());
		}

		// Token: 0x06000E28 RID: 3624
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern sbyte vtkInteractorObserver_GetKeyPressActivationValue_10(HandleRef pThis);

		/// <summary>
		/// Specify which key press value to use to activate the interactor observer
		/// (if key press activation is enabled). By default, the key press
		/// activation value is 'i'. Note: once the SetInteractor() method is
		/// invoked, changing the key press activation value will not affect the key
		/// press until SetInteractor(NULL)/SetInteractor(iren) is called.
		/// </summary>
		// Token: 0x06000E29 RID: 3625 RVA: 0x0001AFC4 File Offset: 0x000191C4
		public virtual sbyte GetKeyPressActivationValue()
		{
			return vtkInteractorObserver.vtkInteractorObserver_GetKeyPressActivationValue_10(base.GetCppThis());
		}

		// Token: 0x06000E2A RID: 3626
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInteractorObserver_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000E2B RID: 3627 RVA: 0x0001AFE4 File Offset: 0x000191E4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInteractorObserver.vtkInteractorObserver_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x06000E2C RID: 3628
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInteractorObserver_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000E2D RID: 3629 RVA: 0x0001B004 File Offset: 0x00019204
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInteractorObserver.vtkInteractorObserver_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x06000E2E RID: 3630
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkInteractorObserver_GetPickingManaged_13(HandleRef pThis);

		/// <summary>
		/// Enable/Disable the use of a manager to process the picking.
		/// Enabled by default.
		/// </summary>
		// Token: 0x06000E2F RID: 3631 RVA: 0x0001B020 File Offset: 0x00019220
		public virtual bool GetPickingManaged()
		{
			return vtkInteractorObserver.vtkInteractorObserver_GetPickingManaged_13(base.GetCppThis()) != 0;
		}

		// Token: 0x06000E30 RID: 3632
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkInteractorObserver_GetPriority_14(HandleRef pThis);

		/// <summary>
		/// Set/Get the priority at which events are processed. This is used when
		/// multiple interactor observers are used simultaneously. The default value
		/// is 0.0 (lowest priority.) Note that when multiple interactor observer
		/// have the same priority, then the last observer added will process the
		/// event first. (Note: once the SetInteractor() method has been called,
		/// changing the priority does not effect event processing. You will have
		/// to SetInteractor(NULL), change priority, and then SetInteractor(iren)
		/// to have the priority take effect.)
		/// </summary>
		// Token: 0x06000E31 RID: 3633 RVA: 0x0001B048 File Offset: 0x00019248
		public virtual float GetPriority()
		{
			return vtkInteractorObserver.vtkInteractorObserver_GetPriority_14(base.GetCppThis());
		}

		// Token: 0x06000E32 RID: 3634
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkInteractorObserver_GetPriorityMaxValue_15(HandleRef pThis);

		/// <summary>
		/// Set/Get the priority at which events are processed. This is used when
		/// multiple interactor observers are used simultaneously. The default value
		/// is 0.0 (lowest priority.) Note that when multiple interactor observer
		/// have the same priority, then the last observer added will process the
		/// event first. (Note: once the SetInteractor() method has been called,
		/// changing the priority does not effect event processing. You will have
		/// to SetInteractor(NULL), change priority, and then SetInteractor(iren)
		/// to have the priority take effect.)
		/// </summary>
		// Token: 0x06000E33 RID: 3635 RVA: 0x0001B068 File Offset: 0x00019268
		public virtual float GetPriorityMaxValue()
		{
			return vtkInteractorObserver.vtkInteractorObserver_GetPriorityMaxValue_15(base.GetCppThis());
		}

		// Token: 0x06000E34 RID: 3636
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkInteractorObserver_GetPriorityMinValue_16(HandleRef pThis);

		/// <summary>
		/// Set/Get the priority at which events are processed. This is used when
		/// multiple interactor observers are used simultaneously. The default value
		/// is 0.0 (lowest priority.) Note that when multiple interactor observer
		/// have the same priority, then the last observer added will process the
		/// event first. (Note: once the SetInteractor() method has been called,
		/// changing the priority does not effect event processing. You will have
		/// to SetInteractor(NULL), change priority, and then SetInteractor(iren)
		/// to have the priority take effect.)
		/// </summary>
		// Token: 0x06000E35 RID: 3637 RVA: 0x0001B088 File Offset: 0x00019288
		public virtual float GetPriorityMinValue()
		{
			return vtkInteractorObserver.vtkInteractorObserver_GetPriorityMinValue_16(base.GetCppThis());
		}

		// Token: 0x06000E36 RID: 3638
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorObserver_GrabFocus_17(HandleRef pThis, HandleRef mouseEvents, HandleRef keypressEvents);

		/// <summary>
		/// These methods enable an interactor observer to exclusively grab all
		/// events invoked by its associated vtkRenderWindowInteractor. (This method
		/// is typically used by widgets to grab events once an event sequence
		/// begins.) The GrabFocus() signature takes up to two vtkCommands
		/// corresponding to mouse events and keypress events. (These two commands
		/// are separated so that the widget can listen for its activation keypress,
		/// as well as listening for DeleteEvents, without actually having to process
		/// mouse events.)
		/// </summary>
		// Token: 0x06000E37 RID: 3639 RVA: 0x0001B0A8 File Offset: 0x000192A8
		public void GrabFocus(vtkCommand mouseEvents, vtkCommand keypressEvents)
		{
			vtkInteractorObserver.vtkInteractorObserver_GrabFocus_17(base.GetCppThis(), (mouseEvents == null) ? default(HandleRef) : mouseEvents.GetCppThis(), (keypressEvents == null) ? default(HandleRef) : keypressEvents.GetCppThis());
		}

		// Token: 0x06000E38 RID: 3640
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorObserver_IsA_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000E39 RID: 3641 RVA: 0x0001B0EC File Offset: 0x000192EC
		public override int IsA(string type)
		{
			return vtkInteractorObserver.vtkInteractorObserver_IsA_18(base.GetCppThis(), type);
		}

		// Token: 0x06000E3A RID: 3642
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorObserver_IsTypeOf_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000E3B RID: 3643 RVA: 0x0001B10C File Offset: 0x0001930C
		public new static int IsTypeOf(string type)
		{
			return vtkInteractorObserver.vtkInteractorObserver_IsTypeOf_19(type);
		}

		// Token: 0x06000E3C RID: 3644
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorObserver_KeyPressActivationOff_20(HandleRef pThis);

		/// <summary>
		/// Enable/Disable of the use of a keypress to turn on and off the
		/// interactor observer. (By default, the keypress is 'i' for "interactor
		/// observer".)  Set the KeyPressActivationValue to change which key
		/// activates the widget.)
		/// </summary>
		// Token: 0x06000E3D RID: 3645 RVA: 0x0001B126 File Offset: 0x00019326
		public virtual void KeyPressActivationOff()
		{
			vtkInteractorObserver.vtkInteractorObserver_KeyPressActivationOff_20(base.GetCppThis());
		}

		// Token: 0x06000E3E RID: 3646
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorObserver_KeyPressActivationOn_21(HandleRef pThis);

		/// <summary>
		/// Enable/Disable of the use of a keypress to turn on and off the
		/// interactor observer. (By default, the keypress is 'i' for "interactor
		/// observer".)  Set the KeyPressActivationValue to change which key
		/// activates the widget.)
		/// </summary>
		// Token: 0x06000E3F RID: 3647 RVA: 0x0001B135 File Offset: 0x00019335
		public virtual void KeyPressActivationOn()
		{
			vtkInteractorObserver.vtkInteractorObserver_KeyPressActivationOn_21(base.GetCppThis());
		}

		// Token: 0x06000E40 RID: 3648
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorObserver_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000E41 RID: 3649 RVA: 0x0001B144 File Offset: 0x00019344
		public new vtkInteractorObserver NewInstance()
		{
			vtkInteractorObserver result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorObserver.vtkInteractorObserver_NewInstance_22(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorObserver)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000E42 RID: 3650
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorObserver_Off_23(HandleRef pThis);

		/// <summary>
		/// Methods for turning the interactor observer on and off, and determining
		/// its state. All subclasses must provide the SetEnabled() method.
		/// Enabling a vtkInteractorObserver has the side effect of adding
		/// observers; disabling it removes the observers. Prior to enabling the
		/// vtkInteractorObserver you must set the render window interactor (via
		/// SetInteractor()). Initial value is 0.
		/// </summary>
		// Token: 0x06000E43 RID: 3651 RVA: 0x0001B19E File Offset: 0x0001939E
		public void Off()
		{
			vtkInteractorObserver.vtkInteractorObserver_Off_23(base.GetCppThis());
		}

		// Token: 0x06000E44 RID: 3652
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorObserver_On_24(HandleRef pThis);

		/// <summary>
		/// Methods for turning the interactor observer on and off, and determining
		/// its state. All subclasses must provide the SetEnabled() method.
		/// Enabling a vtkInteractorObserver has the side effect of adding
		/// observers; disabling it removes the observers. Prior to enabling the
		/// vtkInteractorObserver you must set the render window interactor (via
		/// SetInteractor()). Initial value is 0.
		/// </summary>
		// Token: 0x06000E45 RID: 3653 RVA: 0x0001B1AD File Offset: 0x000193AD
		public void On()
		{
			vtkInteractorObserver.vtkInteractorObserver_On_24(base.GetCppThis());
		}

		// Token: 0x06000E46 RID: 3654
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorObserver_OnChar_25(HandleRef pThis);

		/// <summary>
		/// Sets up the keypress-i event.
		/// </summary>
		// Token: 0x06000E47 RID: 3655 RVA: 0x0001B1BC File Offset: 0x000193BC
		public virtual void OnChar()
		{
			vtkInteractorObserver.vtkInteractorObserver_OnChar_25(base.GetCppThis());
		}

		// Token: 0x06000E48 RID: 3656
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorObserver_PickingManagedOff_26(HandleRef pThis);

		/// <summary>
		/// Enable/Disable the use of a manager to process the picking.
		/// Enabled by default.
		/// </summary>
		// Token: 0x06000E49 RID: 3657 RVA: 0x0001B1CB File Offset: 0x000193CB
		public virtual void PickingManagedOff()
		{
			vtkInteractorObserver.vtkInteractorObserver_PickingManagedOff_26(base.GetCppThis());
		}

		// Token: 0x06000E4A RID: 3658
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorObserver_PickingManagedOn_27(HandleRef pThis);

		/// <summary>
		/// Enable/Disable the use of a manager to process the picking.
		/// Enabled by default.
		/// </summary>
		// Token: 0x06000E4B RID: 3659 RVA: 0x0001B1DA File Offset: 0x000193DA
		public virtual void PickingManagedOn()
		{
			vtkInteractorObserver.vtkInteractorObserver_PickingManagedOn_27(base.GetCppThis());
		}

		// Token: 0x06000E4C RID: 3660
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorObserver_ReleaseFocus_28(HandleRef pThis);

		/// <summary>
		/// These methods enable an interactor observer to exclusively grab all
		/// events invoked by its associated vtkRenderWindowInteractor. (This method
		/// is typically used by widgets to grab events once an event sequence
		/// begins.) The GrabFocus() signature takes up to two vtkCommands
		/// corresponding to mouse events and keypress events. (These two commands
		/// are separated so that the widget can listen for its activation keypress,
		/// as well as listening for DeleteEvents, without actually having to process
		/// mouse events.)
		/// </summary>
		// Token: 0x06000E4D RID: 3661 RVA: 0x0001B1E9 File Offset: 0x000193E9
		public void ReleaseFocus()
		{
			vtkInteractorObserver.vtkInteractorObserver_ReleaseFocus_28(base.GetCppThis());
		}

		// Token: 0x06000E4E RID: 3662
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorObserver_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000E4F RID: 3663 RVA: 0x0001B1F8 File Offset: 0x000193F8
		public new static vtkInteractorObserver SafeDownCast(vtkObjectBase o)
		{
			vtkInteractorObserver vtkInteractorObserver = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorObserver.vtkInteractorObserver_SafeDownCast_29((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06000E50 RID: 3664
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorObserver_SetCurrentRenderer_30(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the current renderer. Normally when the widget is activated
		/// (SetEnabled(1) or when keypress activation takes place), the renderer
		/// over which the mouse pointer is positioned is used and assigned to
		/// this Ivar. Alternatively, you might want to set the CurrentRenderer
		/// explicitly. This is especially true with multiple viewports (renderers).
		/// WARNING: note that if the DefaultRenderer Ivar is set (see above),
		/// it will always override the parameter passed to SetCurrentRenderer,
		/// unless it is NULL.
		/// (i.e., SetCurrentRenderer(foo) = SetCurrentRenderer(DefaultRenderer).
		/// </summary>
		// Token: 0x06000E51 RID: 3665 RVA: 0x0001B278 File Offset: 0x00019478
		public virtual void SetCurrentRenderer(vtkRenderer arg0)
		{
			vtkInteractorObserver.vtkInteractorObserver_SetCurrentRenderer_30(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06000E52 RID: 3666
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorObserver_SetDefaultRenderer_31(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the default renderer to use when activating the interactor
		/// observer. Normally when the widget is activated (SetEnabled(1) or when
		/// keypress activation takes place), the renderer over which the mouse
		/// pointer is positioned is used. Alternatively, you can specify the
		/// renderer to bind the interactor to when the interactor observer is
		/// activated.
		/// </summary>
		// Token: 0x06000E53 RID: 3667 RVA: 0x0001B2A8 File Offset: 0x000194A8
		public virtual void SetDefaultRenderer(vtkRenderer arg0)
		{
			vtkInteractorObserver.vtkInteractorObserver_SetDefaultRenderer_31(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06000E54 RID: 3668
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorObserver_SetEnabled_32(HandleRef pThis, int arg0);

		/// <summary>
		/// Methods for turning the interactor observer on and off, and determining
		/// its state. All subclasses must provide the SetEnabled() method.
		/// Enabling a vtkInteractorObserver has the side effect of adding
		/// observers; disabling it removes the observers. Prior to enabling the
		/// vtkInteractorObserver you must set the render window interactor (via
		/// SetInteractor()). Initial value is 0.
		/// </summary>
		// Token: 0x06000E55 RID: 3669 RVA: 0x0001B2D7 File Offset: 0x000194D7
		public virtual void SetEnabled(int arg0)
		{
			vtkInteractorObserver.vtkInteractorObserver_SetEnabled_32(base.GetCppThis(), arg0);
		}

		// Token: 0x06000E56 RID: 3670
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorObserver_SetInteractor_33(HandleRef pThis, HandleRef iren);

		/// <summary>
		/// This method is used to associate the widget with the render window
		/// interactor.  Observers of the appropriate events invoked in the render
		/// window interactor are set up as a result of this method invocation.
		/// The SetInteractor() method must be invoked prior to enabling the
		/// vtkInteractorObserver.
		/// It automatically registers available pickers to the Picking Manager.
		/// </summary>
		// Token: 0x06000E57 RID: 3671 RVA: 0x0001B2E8 File Offset: 0x000194E8
		public virtual void SetInteractor(vtkRenderWindowInteractor iren)
		{
			vtkInteractorObserver.vtkInteractorObserver_SetInteractor_33(base.GetCppThis(), (iren == null) ? default(HandleRef) : iren.GetCppThis());
		}

		// Token: 0x06000E58 RID: 3672
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorObserver_SetKeyPressActivation_34(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable/Disable of the use of a keypress to turn on and off the
		/// interactor observer. (By default, the keypress is 'i' for "interactor
		/// observer".)  Set the KeyPressActivationValue to change which key
		/// activates the widget.)
		/// </summary>
		// Token: 0x06000E59 RID: 3673 RVA: 0x0001B317 File Offset: 0x00019517
		public virtual void SetKeyPressActivation(int _arg)
		{
			vtkInteractorObserver.vtkInteractorObserver_SetKeyPressActivation_34(base.GetCppThis(), _arg);
		}

		// Token: 0x06000E5A RID: 3674
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorObserver_SetKeyPressActivationValue_35(HandleRef pThis, sbyte _arg);

		/// <summary>
		/// Specify which key press value to use to activate the interactor observer
		/// (if key press activation is enabled). By default, the key press
		/// activation value is 'i'. Note: once the SetInteractor() method is
		/// invoked, changing the key press activation value will not affect the key
		/// press until SetInteractor(NULL)/SetInteractor(iren) is called.
		/// </summary>
		// Token: 0x06000E5B RID: 3675 RVA: 0x0001B327 File Offset: 0x00019527
		public virtual void SetKeyPressActivationValue(sbyte _arg)
		{
			vtkInteractorObserver.vtkInteractorObserver_SetKeyPressActivationValue_35(base.GetCppThis(), _arg);
		}

		// Token: 0x06000E5C RID: 3676
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorObserver_SetPickingManaged_36(HandleRef pThis, byte managed);

		/// <summary>
		/// Enable/Disable the use of a manager to process the picking.
		/// Enabled by default.
		/// </summary>
		// Token: 0x06000E5D RID: 3677 RVA: 0x0001B337 File Offset: 0x00019537
		public virtual void SetPickingManaged(bool managed)
		{
			vtkInteractorObserver.vtkInteractorObserver_SetPickingManaged_36(base.GetCppThis(), managed ? (byte)1 : (byte)0);
		}

		// Token: 0x06000E5E RID: 3678
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorObserver_SetPriority_37(HandleRef pThis, float _arg);

		/// <summary>
		/// Set/Get the priority at which events are processed. This is used when
		/// multiple interactor observers are used simultaneously. The default value
		/// is 0.0 (lowest priority.) Note that when multiple interactor observer
		/// have the same priority, then the last observer added will process the
		/// event first. (Note: once the SetInteractor() method has been called,
		/// changing the priority does not effect event processing. You will have
		/// to SetInteractor(NULL), change priority, and then SetInteractor(iren)
		/// to have the priority take effect.)
		/// </summary>
		// Token: 0x06000E5F RID: 3679 RVA: 0x0001B34F File Offset: 0x0001954F
		public virtual void SetPriority(float _arg)
		{
			vtkInteractorObserver.vtkInteractorObserver_SetPriority_37(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000428 RID: 1064
		public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorObserver";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000429 RID: 1065
		public new static readonly string MRClassNameKey = "class vtkInteractorObserver";
	}
}
