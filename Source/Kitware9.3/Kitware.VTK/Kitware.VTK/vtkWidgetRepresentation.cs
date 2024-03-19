using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkWidgetRepresentation
	/// </summary>
	/// <remarks>
	///    abstract class defines interface between the widget and widget representation classes
	///
	/// This class is used to define the API for, and partially implement, a
	/// representation for different types of widgets. Note that the widget
	/// representation (i.e., subclasses of vtkWidgetRepresentation) are a type of
	/// vtkProp; meaning that they can be associated with a vtkRenderer end
	/// embedded in a scene like any other vtkActor. However,
	/// vtkWidgetRepresentation also defines an API that enables it to be paired
	/// with a subclass vtkAbstractWidget, meaning that it can be driven by a
	/// widget, serving to represent the widget as the widget responds to
	/// registered events.
	///
	/// The API defined here should be regarded as a guideline for implementing
	/// widgets and widget representations. Widget behavior is complex, as is the
	/// way the representation responds to the registered widget events, so the API
	/// may vary from widget to widget to reflect this complexity.
	///
	/// Clients of VTK, like ParaView, need a uniform way to set colors on widgets.
	/// Most widgets have standard color setters - new widgets should follow this pattern.
	/// The intended use of these colors is as follows:
	/// | Color       | Description |
	/// | ----------- | ----------- |
	/// | `HandleColor`      | Widget handles that are available to interact with via click+drag. | |
	/// `InteractionColor` | Widget handles the user is interacting with (via a click+drag) or hovering
	/// over.     | | `ForegroundColor`  | Widget elements meant to contrast with the background and
	/// which are not interactive. |
	///
	/// When hovering, the `InteractionColor` can also be used to show which parts
	/// of the widget will change if this handle is dragged. For instance, using the
	/// `vtkDisplaySizedImplicitPlaneRepresentation`, hovering the axis also displays
	/// the plane disc in the `InteractionColor`, to show it will change when the
	/// axis is rotated.
	///
	/// @warning
	/// The separation of the widget event handling and representation enables
	/// users and developers to create new appearances for the widget. It also
	/// facilitates parallel processing, where the client application handles
	/// events, and remote representations of the widget are slaves to the
	/// client (and do not handle events).
	/// </remarks>
	// Token: 0x020000C0 RID: 192
	public abstract class vtkWidgetRepresentation : vtkProp
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060029E2 RID: 10722 RVA: 0x0003DFAF File Offset: 0x0003C1AF
		static vtkWidgetRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkWidgetRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkWidgetRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060029E3 RID: 10723 RVA: 0x0003DFD7 File Offset: 0x0003C1D7
		public vtkWidgetRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060029E4 RID: 10724 RVA: 0x0003DFE5 File Offset: 0x0003C1E5
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060029E5 RID: 10725
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWidgetRepresentation_BuildRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Subclasses of vtkWidgetRepresentation must implement these methods. This is
		/// considered the minimum API for a widget representation.
		/// &lt;pre&gt;
		/// SetRenderer() - the renderer in which the representations draws itself.
		/// Typically the renderer is set by the associated widget.
		/// Use the widget's SetCurrentRenderer() method in most cases;
		/// otherwise there is a risk of inconsistent behavior as events
		/// and drawing may be performed in different viewports.
		/// BuildRepresentation() - update the geometry of the widget based on its
		/// current state.
		/// &lt;/pre&gt;
		/// WARNING: The renderer is NOT reference counted by the representation,
		/// in order to avoid reference loops.  Be sure that the representation
		/// lifetime does not extend beyond the renderer lifetime.
		/// </summary>
		// Token: 0x060029E6 RID: 10726 RVA: 0x0003DFF0 File Offset: 0x0003C1F0
		public virtual void BuildRepresentation()
		{
			vtkWidgetRepresentation.vtkWidgetRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		// Token: 0x060029E7 RID: 10727
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWidgetRepresentation_ComplexInteraction_02(HandleRef pThis, HandleRef arg0, HandleRef arg1, uint arg2, IntPtr arg3);

		/// <summary>
		/// The following is a suggested API for widget representations. These methods
		/// define the communication between the widget and its representation. These
		/// methods are only suggestions because widgets take on so many different
		/// forms that a universal API is not deemed practical. However, these methods
		/// should be implemented when possible to ensure that the VTK widget hierarchy
		/// remains self-consistent.
		/// &lt;pre&gt;
		/// PlaceWidget() - given a bounding box (xmin,xmax,ymin,ymax,zmin,zmax), place
		/// the widget inside of it. The current orientation of the widget
		/// is preserved, only scaling and translation is performed.
		/// StartWidgetInteraction() - generally corresponds to a initial event (e.g.,
		/// mouse down) that starts the interaction process
		/// with the widget.
		/// WidgetInteraction() - invoked when an event causes the widget to change
		/// appearance.
		/// EndWidgetInteraction() - generally corresponds to a final event (e.g., mouse up)
		/// and completes the interaction sequence.
		/// ComputeInteractionState() - given (X,Y) display coordinates in a renderer, with a
		/// possible flag that modifies the computation,
		/// what is the state of the widget?
		/// GetInteractionState() - return the current state of the widget. Note that the
		/// value of "0" typically refers to "outside". The
		/// interaction state is strictly a function of the
		/// representation, and the widget/represent must agree
		/// on what they mean.
		/// Highlight() - turn on or off any highlights associated with the widget.
		/// Highlights are generally turned on when the widget is selected.
		/// &lt;/pre&gt;
		/// Note that subclasses may ignore some of these methods and implement their own
		/// depending on the specifics of the widget.
		/// </summary>
		// Token: 0x060029E8 RID: 10728 RVA: 0x0003E000 File Offset: 0x0003C200
		public virtual void ComplexInteraction(vtkRenderWindowInteractor arg0, vtkAbstractWidget arg1, uint arg2, IntPtr arg3)
		{
			vtkWidgetRepresentation.vtkWidgetRepresentation_ComplexInteraction_02(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis(), arg2, arg3);
		}

		// Token: 0x060029E9 RID: 10729
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWidgetRepresentation_ComputeComplexInteractionState_03(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr callData, int modify);

		/// <summary>
		/// The following is a suggested API for widget representations. These methods
		/// define the communication between the widget and its representation. These
		/// methods are only suggestions because widgets take on so many different
		/// forms that a universal API is not deemed practical. However, these methods
		/// should be implemented when possible to ensure that the VTK widget hierarchy
		/// remains self-consistent.
		/// &lt;pre&gt;
		/// PlaceWidget() - given a bounding box (xmin,xmax,ymin,ymax,zmin,zmax), place
		/// the widget inside of it. The current orientation of the widget
		/// is preserved, only scaling and translation is performed.
		/// StartWidgetInteraction() - generally corresponds to a initial event (e.g.,
		/// mouse down) that starts the interaction process
		/// with the widget.
		/// WidgetInteraction() - invoked when an event causes the widget to change
		/// appearance.
		/// EndWidgetInteraction() - generally corresponds to a final event (e.g., mouse up)
		/// and completes the interaction sequence.
		/// ComputeInteractionState() - given (X,Y) display coordinates in a renderer, with a
		/// possible flag that modifies the computation,
		/// what is the state of the widget?
		/// GetInteractionState() - return the current state of the widget. Note that the
		/// value of "0" typically refers to "outside". The
		/// interaction state is strictly a function of the
		/// representation, and the widget/represent must agree
		/// on what they mean.
		/// Highlight() - turn on or off any highlights associated with the widget.
		/// Highlights are generally turned on when the widget is selected.
		/// &lt;/pre&gt;
		/// Note that subclasses may ignore some of these methods and implement their own
		/// depending on the specifics of the widget.
		/// </summary>
		// Token: 0x060029EA RID: 10730 RVA: 0x0003E048 File Offset: 0x0003C248
		public virtual int ComputeComplexInteractionState(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr callData, int modify)
		{
			return vtkWidgetRepresentation.vtkWidgetRepresentation_ComputeComplexInteractionState_03(base.GetCppThis(), (iren == null) ? default(HandleRef) : iren.GetCppThis(), (widget == null) ? default(HandleRef) : widget.GetCppThis(), arg2, callData, modify);
		}

		// Token: 0x060029EB RID: 10731
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWidgetRepresentation_ComputeInteractionState_04(HandleRef pThis, int X, int Y, int modify);

		/// <summary>
		/// The following is a suggested API for widget representations. These methods
		/// define the communication between the widget and its representation. These
		/// methods are only suggestions because widgets take on so many different
		/// forms that a universal API is not deemed practical. However, these methods
		/// should be implemented when possible to ensure that the VTK widget hierarchy
		/// remains self-consistent.
		/// &lt;pre&gt;
		/// PlaceWidget() - given a bounding box (xmin,xmax,ymin,ymax,zmin,zmax), place
		/// the widget inside of it. The current orientation of the widget
		/// is preserved, only scaling and translation is performed.
		/// StartWidgetInteraction() - generally corresponds to a initial event (e.g.,
		/// mouse down) that starts the interaction process
		/// with the widget.
		/// WidgetInteraction() - invoked when an event causes the widget to change
		/// appearance.
		/// EndWidgetInteraction() - generally corresponds to a final event (e.g., mouse up)
		/// and completes the interaction sequence.
		/// ComputeInteractionState() - given (X,Y) display coordinates in a renderer, with a
		/// possible flag that modifies the computation,
		/// what is the state of the widget?
		/// GetInteractionState() - return the current state of the widget. Note that the
		/// value of "0" typically refers to "outside". The
		/// interaction state is strictly a function of the
		/// representation, and the widget/represent must agree
		/// on what they mean.
		/// Highlight() - turn on or off any highlights associated with the widget.
		/// Highlights are generally turned on when the widget is selected.
		/// &lt;/pre&gt;
		/// Note that subclasses may ignore some of these methods and implement their own
		/// depending on the specifics of the widget.
		/// </summary>
		// Token: 0x060029EC RID: 10732 RVA: 0x0003E098 File Offset: 0x0003C298
		public virtual int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkWidgetRepresentation.vtkWidgetRepresentation_ComputeInteractionState_04(base.GetCppThis(), X, Y, modify);
		}

		// Token: 0x060029ED RID: 10733
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWidgetRepresentation_EndComplexInteraction_05(HandleRef pThis, HandleRef arg0, HandleRef arg1, uint arg2, IntPtr arg3);

		/// <summary>
		/// The following is a suggested API for widget representations. These methods
		/// define the communication between the widget and its representation. These
		/// methods are only suggestions because widgets take on so many different
		/// forms that a universal API is not deemed practical. However, these methods
		/// should be implemented when possible to ensure that the VTK widget hierarchy
		/// remains self-consistent.
		/// &lt;pre&gt;
		/// PlaceWidget() - given a bounding box (xmin,xmax,ymin,ymax,zmin,zmax), place
		/// the widget inside of it. The current orientation of the widget
		/// is preserved, only scaling and translation is performed.
		/// StartWidgetInteraction() - generally corresponds to a initial event (e.g.,
		/// mouse down) that starts the interaction process
		/// with the widget.
		/// WidgetInteraction() - invoked when an event causes the widget to change
		/// appearance.
		/// EndWidgetInteraction() - generally corresponds to a final event (e.g., mouse up)
		/// and completes the interaction sequence.
		/// ComputeInteractionState() - given (X,Y) display coordinates in a renderer, with a
		/// possible flag that modifies the computation,
		/// what is the state of the widget?
		/// GetInteractionState() - return the current state of the widget. Note that the
		/// value of "0" typically refers to "outside". The
		/// interaction state is strictly a function of the
		/// representation, and the widget/represent must agree
		/// on what they mean.
		/// Highlight() - turn on or off any highlights associated with the widget.
		/// Highlights are generally turned on when the widget is selected.
		/// &lt;/pre&gt;
		/// Note that subclasses may ignore some of these methods and implement their own
		/// depending on the specifics of the widget.
		/// </summary>
		// Token: 0x060029EE RID: 10734 RVA: 0x0003E0BC File Offset: 0x0003C2BC
		public virtual void EndComplexInteraction(vtkRenderWindowInteractor arg0, vtkAbstractWidget arg1, uint arg2, IntPtr arg3)
		{
			vtkWidgetRepresentation.vtkWidgetRepresentation_EndComplexInteraction_05(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis(), arg2, arg3);
		}

		// Token: 0x060029EF RID: 10735
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWidgetRepresentation_EndWidgetInteraction_06(HandleRef pThis, IntPtr newEventPos);

		/// <summary>
		/// The following is a suggested API for widget representations. These methods
		/// define the communication between the widget and its representation. These
		/// methods are only suggestions because widgets take on so many different
		/// forms that a universal API is not deemed practical. However, these methods
		/// should be implemented when possible to ensure that the VTK widget hierarchy
		/// remains self-consistent.
		/// &lt;pre&gt;
		/// PlaceWidget() - given a bounding box (xmin,xmax,ymin,ymax,zmin,zmax), place
		/// the widget inside of it. The current orientation of the widget
		/// is preserved, only scaling and translation is performed.
		/// StartWidgetInteraction() - generally corresponds to a initial event (e.g.,
		/// mouse down) that starts the interaction process
		/// with the widget.
		/// WidgetInteraction() - invoked when an event causes the widget to change
		/// appearance.
		/// EndWidgetInteraction() - generally corresponds to a final event (e.g., mouse up)
		/// and completes the interaction sequence.
		/// ComputeInteractionState() - given (X,Y) display coordinates in a renderer, with a
		/// possible flag that modifies the computation,
		/// what is the state of the widget?
		/// GetInteractionState() - return the current state of the widget. Note that the
		/// value of "0" typically refers to "outside". The
		/// interaction state is strictly a function of the
		/// representation, and the widget/represent must agree
		/// on what they mean.
		/// Highlight() - turn on or off any highlights associated with the widget.
		/// Highlights are generally turned on when the widget is selected.
		/// &lt;/pre&gt;
		/// Note that subclasses may ignore some of these methods and implement their own
		/// depending on the specifics of the widget.
		/// </summary>
		// Token: 0x060029F0 RID: 10736 RVA: 0x0003E103 File Offset: 0x0003C303
		public virtual void EndWidgetInteraction(IntPtr newEventPos)
		{
			vtkWidgetRepresentation.vtkWidgetRepresentation_EndWidgetInteraction_06(base.GetCppThis(), newEventPos);
		}

		// Token: 0x060029F1 RID: 10737
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWidgetRepresentation_GetActors_07(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods to make this class behave as a vtkProp. They are repeated here (from the
		/// vtkProp superclass) as a reminder to the widget implementor. Failure to implement
		/// these methods properly may result in the representation not appearing in the scene
		/// (i.e., not implementing the Render() methods properly) or leaking graphics resources
		/// (i.e., not implementing ReleaseGraphicsResources() properly).
		/// </summary>
		// Token: 0x060029F2 RID: 10738 RVA: 0x0003E114 File Offset: 0x0003C314
		public override void GetActors(vtkPropCollection arg0)
		{
			vtkWidgetRepresentation.vtkWidgetRepresentation_GetActors_07(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060029F3 RID: 10739
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWidgetRepresentation_GetActors2D_08(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods to make this class behave as a vtkProp. They are repeated here (from the
		/// vtkProp superclass) as a reminder to the widget implementor. Failure to implement
		/// these methods properly may result in the representation not appearing in the scene
		/// (i.e., not implementing the Render() methods properly) or leaking graphics resources
		/// (i.e., not implementing ReleaseGraphicsResources() properly).
		/// </summary>
		// Token: 0x060029F4 RID: 10740 RVA: 0x0003E144 File Offset: 0x0003C344
		public override void GetActors2D(vtkPropCollection arg0)
		{
			vtkWidgetRepresentation.vtkWidgetRepresentation_GetActors2D_08(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060029F5 RID: 10741
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWidgetRepresentation_GetBounds_09(HandleRef pThis);

		/// <summary>
		/// Methods to make this class behave as a vtkProp. They are repeated here (from the
		/// vtkProp superclass) as a reminder to the widget implementor. Failure to implement
		/// these methods properly may result in the representation not appearing in the scene
		/// (i.e., not implementing the Render() methods properly) or leaking graphics resources
		/// (i.e., not implementing ReleaseGraphicsResources() properly).
		/// </summary>
		// Token: 0x060029F6 RID: 10742 RVA: 0x0003E174 File Offset: 0x0003C374
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkWidgetRepresentation.vtkWidgetRepresentation_GetBounds_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060029F7 RID: 10743
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkWidgetRepresentation_GetHandleSize_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the factor that controls the size of the handles that appear as
		/// part of the widget (if any). These handles (like spheres, etc.)  are
		/// used to manipulate the widget. The HandleSize data member allows you
		/// to change the relative size of the handles. Note that while the handle
		/// size is typically expressed in pixels, some subclasses may use a relative size
		/// with respect to the viewport. (As a corollary, the value of this ivar is often
		/// set by subclasses of this class during instance instantiation.)
		/// </summary>
		// Token: 0x060029F8 RID: 10744 RVA: 0x0003E1BC File Offset: 0x0003C3BC
		public virtual double GetHandleSize()
		{
			return vtkWidgetRepresentation.vtkWidgetRepresentation_GetHandleSize_10(base.GetCppThis());
		}

		// Token: 0x060029F9 RID: 10745
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkWidgetRepresentation_GetHandleSizeMaxValue_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the factor that controls the size of the handles that appear as
		/// part of the widget (if any). These handles (like spheres, etc.)  are
		/// used to manipulate the widget. The HandleSize data member allows you
		/// to change the relative size of the handles. Note that while the handle
		/// size is typically expressed in pixels, some subclasses may use a relative size
		/// with respect to the viewport. (As a corollary, the value of this ivar is often
		/// set by subclasses of this class during instance instantiation.)
		/// </summary>
		// Token: 0x060029FA RID: 10746 RVA: 0x0003E1DC File Offset: 0x0003C3DC
		public virtual double GetHandleSizeMaxValue()
		{
			return vtkWidgetRepresentation.vtkWidgetRepresentation_GetHandleSizeMaxValue_11(base.GetCppThis());
		}

		// Token: 0x060029FB RID: 10747
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkWidgetRepresentation_GetHandleSizeMinValue_12(HandleRef pThis);

		/// <summary>
		/// Set/Get the factor that controls the size of the handles that appear as
		/// part of the widget (if any). These handles (like spheres, etc.)  are
		/// used to manipulate the widget. The HandleSize data member allows you
		/// to change the relative size of the handles. Note that while the handle
		/// size is typically expressed in pixels, some subclasses may use a relative size
		/// with respect to the viewport. (As a corollary, the value of this ivar is often
		/// set by subclasses of this class during instance instantiation.)
		/// </summary>
		// Token: 0x060029FC RID: 10748 RVA: 0x0003E1FC File Offset: 0x0003C3FC
		public virtual double GetHandleSizeMinValue()
		{
			return vtkWidgetRepresentation.vtkWidgetRepresentation_GetHandleSizeMinValue_12(base.GetCppThis());
		}

		// Token: 0x060029FD RID: 10749
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWidgetRepresentation_GetInteractionState_13(HandleRef pThis);

		/// <summary>
		/// The following is a suggested API for widget representations. These methods
		/// define the communication between the widget and its representation. These
		/// methods are only suggestions because widgets take on so many different
		/// forms that a universal API is not deemed practical. However, these methods
		/// should be implemented when possible to ensure that the VTK widget hierarchy
		/// remains self-consistent.
		/// &lt;pre&gt;
		/// PlaceWidget() - given a bounding box (xmin,xmax,ymin,ymax,zmin,zmax), place
		/// the widget inside of it. The current orientation of the widget
		/// is preserved, only scaling and translation is performed.
		/// StartWidgetInteraction() - generally corresponds to a initial event (e.g.,
		/// mouse down) that starts the interaction process
		/// with the widget.
		/// WidgetInteraction() - invoked when an event causes the widget to change
		/// appearance.
		/// EndWidgetInteraction() - generally corresponds to a final event (e.g., mouse up)
		/// and completes the interaction sequence.
		/// ComputeInteractionState() - given (X,Y) display coordinates in a renderer, with a
		/// possible flag that modifies the computation,
		/// what is the state of the widget?
		/// GetInteractionState() - return the current state of the widget. Note that the
		/// value of "0" typically refers to "outside". The
		/// interaction state is strictly a function of the
		/// representation, and the widget/represent must agree
		/// on what they mean.
		/// Highlight() - turn on or off any highlights associated with the widget.
		/// Highlights are generally turned on when the widget is selected.
		/// &lt;/pre&gt;
		/// Note that subclasses may ignore some of these methods and implement their own
		/// depending on the specifics of the widget.
		/// </summary>
		// Token: 0x060029FE RID: 10750 RVA: 0x0003E21C File Offset: 0x0003C41C
		public virtual int GetInteractionState()
		{
			return vtkWidgetRepresentation.vtkWidgetRepresentation_GetInteractionState_13(base.GetCppThis());
		}

		// Token: 0x060029FF RID: 10751
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWidgetRepresentation_GetNeedToRender_14(HandleRef pThis);

		/// <summary>
		/// Some subclasses use this data member to keep track of whether to render
		/// or not (i.e., to minimize the total number of renders).
		/// </summary>
		// Token: 0x06002A00 RID: 10752 RVA: 0x0003E23C File Offset: 0x0003C43C
		public virtual int GetNeedToRender()
		{
			return vtkWidgetRepresentation.vtkWidgetRepresentation_GetNeedToRender_14(base.GetCppThis());
		}

		// Token: 0x06002A01 RID: 10753
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWidgetRepresentation_GetNeedToRenderMaxValue_15(HandleRef pThis);

		/// <summary>
		/// Some subclasses use this data member to keep track of whether to render
		/// or not (i.e., to minimize the total number of renders).
		/// </summary>
		// Token: 0x06002A02 RID: 10754 RVA: 0x0003E25C File Offset: 0x0003C45C
		public virtual int GetNeedToRenderMaxValue()
		{
			return vtkWidgetRepresentation.vtkWidgetRepresentation_GetNeedToRenderMaxValue_15(base.GetCppThis());
		}

		// Token: 0x06002A03 RID: 10755
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWidgetRepresentation_GetNeedToRenderMinValue_16(HandleRef pThis);

		/// <summary>
		/// Some subclasses use this data member to keep track of whether to render
		/// or not (i.e., to minimize the total number of renders).
		/// </summary>
		// Token: 0x06002A04 RID: 10756 RVA: 0x0003E27C File Offset: 0x0003C47C
		public virtual int GetNeedToRenderMinValue()
		{
			return vtkWidgetRepresentation.vtkWidgetRepresentation_GetNeedToRenderMinValue_16(base.GetCppThis());
		}

		// Token: 0x06002A05 RID: 10757
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWidgetRepresentation_GetNumberOfGenerationsFromBase_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06002A06 RID: 10758 RVA: 0x0003E29C File Offset: 0x0003C49C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkWidgetRepresentation.vtkWidgetRepresentation_GetNumberOfGenerationsFromBase_17(base.GetCppThis(), type);
		}

		// Token: 0x06002A07 RID: 10759
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWidgetRepresentation_GetNumberOfGenerationsFromBaseType_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06002A08 RID: 10760 RVA: 0x0003E2BC File Offset: 0x0003C4BC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkWidgetRepresentation.vtkWidgetRepresentation_GetNumberOfGenerationsFromBaseType_18(type);
		}

		// Token: 0x06002A09 RID: 10761
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkWidgetRepresentation_GetPickingManaged_19(HandleRef pThis);

		/// <summary>
		/// Enable/Disable the use of a manager to process the picking.
		/// Enabled by default.
		/// </summary>
		// Token: 0x06002A0A RID: 10762 RVA: 0x0003E2D8 File Offset: 0x0003C4D8
		public virtual bool GetPickingManaged()
		{
			return vtkWidgetRepresentation.vtkWidgetRepresentation_GetPickingManaged_19(base.GetCppThis()) != 0;
		}

		// Token: 0x06002A0B RID: 10763
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkWidgetRepresentation_GetPlaceFactor_20(HandleRef pThis);

		/// <summary>
		/// Set/Get a factor representing the scaling of the widget upon placement
		/// (via the PlaceWidget() method). Normally the widget is placed so that
		/// it just fits within the bounding box defined in PlaceWidget(bounds).
		/// The PlaceFactor will make the widget larger (PlaceFactor &gt; 1) or smaller
		/// (PlaceFactor &lt; 1). By default, PlaceFactor is set to 0.5.
		/// </summary>
		// Token: 0x06002A0C RID: 10764 RVA: 0x0003E300 File Offset: 0x0003C500
		public virtual double GetPlaceFactor()
		{
			return vtkWidgetRepresentation.vtkWidgetRepresentation_GetPlaceFactor_20(base.GetCppThis());
		}

		// Token: 0x06002A0D RID: 10765
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkWidgetRepresentation_GetPlaceFactorMaxValue_21(HandleRef pThis);

		/// <summary>
		/// Set/Get a factor representing the scaling of the widget upon placement
		/// (via the PlaceWidget() method). Normally the widget is placed so that
		/// it just fits within the bounding box defined in PlaceWidget(bounds).
		/// The PlaceFactor will make the widget larger (PlaceFactor &gt; 1) or smaller
		/// (PlaceFactor &lt; 1). By default, PlaceFactor is set to 0.5.
		/// </summary>
		// Token: 0x06002A0E RID: 10766 RVA: 0x0003E320 File Offset: 0x0003C520
		public virtual double GetPlaceFactorMaxValue()
		{
			return vtkWidgetRepresentation.vtkWidgetRepresentation_GetPlaceFactorMaxValue_21(base.GetCppThis());
		}

		// Token: 0x06002A0F RID: 10767
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkWidgetRepresentation_GetPlaceFactorMinValue_22(HandleRef pThis);

		/// <summary>
		/// Set/Get a factor representing the scaling of the widget upon placement
		/// (via the PlaceWidget() method). Normally the widget is placed so that
		/// it just fits within the bounding box defined in PlaceWidget(bounds).
		/// The PlaceFactor will make the widget larger (PlaceFactor &gt; 1) or smaller
		/// (PlaceFactor &lt; 1). By default, PlaceFactor is set to 0.5.
		/// </summary>
		// Token: 0x06002A10 RID: 10768 RVA: 0x0003E340 File Offset: 0x0003C540
		public virtual double GetPlaceFactorMinValue()
		{
			return vtkWidgetRepresentation.vtkWidgetRepresentation_GetPlaceFactorMinValue_22(base.GetCppThis());
		}

		// Token: 0x06002A11 RID: 10769
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWidgetRepresentation_GetRenderer_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Subclasses of vtkWidgetRepresentation must implement these methods. This is
		/// considered the minimum API for a widget representation.
		/// &lt;pre&gt;
		/// SetRenderer() - the renderer in which the representations draws itself.
		/// Typically the renderer is set by the associated widget.
		/// Use the widget's SetCurrentRenderer() method in most cases;
		/// otherwise there is a risk of inconsistent behavior as events
		/// and drawing may be performed in different viewports.
		/// BuildRepresentation() - update the geometry of the widget based on its
		/// current state.
		/// &lt;/pre&gt;
		/// WARNING: The renderer is NOT reference counted by the representation,
		/// in order to avoid reference loops.  Be sure that the representation
		/// lifetime does not extend beyond the renderer lifetime.
		/// </summary>
		// Token: 0x06002A12 RID: 10770 RVA: 0x0003E360 File Offset: 0x0003C560
		public virtual vtkRenderer GetRenderer()
		{
			vtkRenderer vtkRenderer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWidgetRepresentation.vtkWidgetRepresentation_GetRenderer_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06002A13 RID: 10771
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWidgetRepresentation_GetVolumes_24(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods to make this class behave as a vtkProp. They are repeated here (from the
		/// vtkProp superclass) as a reminder to the widget implementor. Failure to implement
		/// these methods properly may result in the representation not appearing in the scene
		/// (i.e., not implementing the Render() methods properly) or leaking graphics resources
		/// (i.e., not implementing ReleaseGraphicsResources() properly).
		/// </summary>
		// Token: 0x06002A14 RID: 10772 RVA: 0x0003E3D0 File Offset: 0x0003C5D0
		public override void GetVolumes(vtkPropCollection arg0)
		{
			vtkWidgetRepresentation.vtkWidgetRepresentation_GetVolumes_24(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002A15 RID: 10773
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWidgetRepresentation_HasTranslucentPolygonalGeometry_25(HandleRef pThis);

		/// <summary>
		/// Methods to make this class behave as a vtkProp. They are repeated here (from the
		/// vtkProp superclass) as a reminder to the widget implementor. Failure to implement
		/// these methods properly may result in the representation not appearing in the scene
		/// (i.e., not implementing the Render() methods properly) or leaking graphics resources
		/// (i.e., not implementing ReleaseGraphicsResources() properly).
		/// </summary>
		// Token: 0x06002A16 RID: 10774 RVA: 0x0003E400 File Offset: 0x0003C600
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkWidgetRepresentation.vtkWidgetRepresentation_HasTranslucentPolygonalGeometry_25(base.GetCppThis());
		}

		// Token: 0x06002A17 RID: 10775
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWidgetRepresentation_Highlight_26(HandleRef pThis, int arg0);

		/// <summary>
		/// The following is a suggested API for widget representations. These methods
		/// define the communication between the widget and its representation. These
		/// methods are only suggestions because widgets take on so many different
		/// forms that a universal API is not deemed practical. However, these methods
		/// should be implemented when possible to ensure that the VTK widget hierarchy
		/// remains self-consistent.
		/// &lt;pre&gt;
		/// PlaceWidget() - given a bounding box (xmin,xmax,ymin,ymax,zmin,zmax), place
		/// the widget inside of it. The current orientation of the widget
		/// is preserved, only scaling and translation is performed.
		/// StartWidgetInteraction() - generally corresponds to a initial event (e.g.,
		/// mouse down) that starts the interaction process
		/// with the widget.
		/// WidgetInteraction() - invoked when an event causes the widget to change
		/// appearance.
		/// EndWidgetInteraction() - generally corresponds to a final event (e.g., mouse up)
		/// and completes the interaction sequence.
		/// ComputeInteractionState() - given (X,Y) display coordinates in a renderer, with a
		/// possible flag that modifies the computation,
		/// what is the state of the widget?
		/// GetInteractionState() - return the current state of the widget. Note that the
		/// value of "0" typically refers to "outside". The
		/// interaction state is strictly a function of the
		/// representation, and the widget/represent must agree
		/// on what they mean.
		/// Highlight() - turn on or off any highlights associated with the widget.
		/// Highlights are generally turned on when the widget is selected.
		/// &lt;/pre&gt;
		/// Note that subclasses may ignore some of these methods and implement their own
		/// depending on the specifics of the widget.
		/// </summary>
		// Token: 0x06002A18 RID: 10776 RVA: 0x0003E41F File Offset: 0x0003C61F
		public virtual void Highlight(int arg0)
		{
			vtkWidgetRepresentation.vtkWidgetRepresentation_Highlight_26(base.GetCppThis(), arg0);
		}

		// Token: 0x06002A19 RID: 10777
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWidgetRepresentation_IsA_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06002A1A RID: 10778 RVA: 0x0003E430 File Offset: 0x0003C630
		public override int IsA(string type)
		{
			return vtkWidgetRepresentation.vtkWidgetRepresentation_IsA_27(base.GetCppThis(), type);
		}

		// Token: 0x06002A1B RID: 10779
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWidgetRepresentation_IsTypeOf_28([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06002A1C RID: 10780 RVA: 0x0003E450 File Offset: 0x0003C650
		public new static int IsTypeOf(string type)
		{
			return vtkWidgetRepresentation.vtkWidgetRepresentation_IsTypeOf_28(type);
		}

		// Token: 0x06002A1D RID: 10781
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWidgetRepresentation_NeedToRenderOff_29(HandleRef pThis);

		/// <summary>
		/// Some subclasses use this data member to keep track of whether to render
		/// or not (i.e., to minimize the total number of renders).
		/// </summary>
		// Token: 0x06002A1E RID: 10782 RVA: 0x0003E46A File Offset: 0x0003C66A
		public virtual void NeedToRenderOff()
		{
			vtkWidgetRepresentation.vtkWidgetRepresentation_NeedToRenderOff_29(base.GetCppThis());
		}

		// Token: 0x06002A1F RID: 10783
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWidgetRepresentation_NeedToRenderOn_30(HandleRef pThis);

		/// <summary>
		/// Some subclasses use this data member to keep track of whether to render
		/// or not (i.e., to minimize the total number of renders).
		/// </summary>
		// Token: 0x06002A20 RID: 10784 RVA: 0x0003E479 File Offset: 0x0003C679
		public virtual void NeedToRenderOn()
		{
			vtkWidgetRepresentation.vtkWidgetRepresentation_NeedToRenderOn_30(base.GetCppThis());
		}

		// Token: 0x06002A21 RID: 10785
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWidgetRepresentation_NewInstance_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06002A22 RID: 10786 RVA: 0x0003E488 File Offset: 0x0003C688
		public new vtkWidgetRepresentation NewInstance()
		{
			vtkWidgetRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWidgetRepresentation.vtkWidgetRepresentation_NewInstance_31(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWidgetRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06002A23 RID: 10787
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWidgetRepresentation_PickingManagedOff_32(HandleRef pThis);

		/// <summary>
		/// Enable/Disable the use of a manager to process the picking.
		/// Enabled by default.
		/// </summary>
		// Token: 0x06002A24 RID: 10788 RVA: 0x0003E4E2 File Offset: 0x0003C6E2
		public virtual void PickingManagedOff()
		{
			vtkWidgetRepresentation.vtkWidgetRepresentation_PickingManagedOff_32(base.GetCppThis());
		}

		// Token: 0x06002A25 RID: 10789
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWidgetRepresentation_PickingManagedOn_33(HandleRef pThis);

		/// <summary>
		/// Enable/Disable the use of a manager to process the picking.
		/// Enabled by default.
		/// </summary>
		// Token: 0x06002A26 RID: 10790 RVA: 0x0003E4F1 File Offset: 0x0003C6F1
		public virtual void PickingManagedOn()
		{
			vtkWidgetRepresentation.vtkWidgetRepresentation_PickingManagedOn_33(base.GetCppThis());
		}

		// Token: 0x06002A27 RID: 10791
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWidgetRepresentation_PlaceWidget_34(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// The following is a suggested API for widget representations. These methods
		/// define the communication between the widget and its representation. These
		/// methods are only suggestions because widgets take on so many different
		/// forms that a universal API is not deemed practical. However, these methods
		/// should be implemented when possible to ensure that the VTK widget hierarchy
		/// remains self-consistent.
		/// &lt;pre&gt;
		/// PlaceWidget() - given a bounding box (xmin,xmax,ymin,ymax,zmin,zmax), place
		/// the widget inside of it. The current orientation of the widget
		/// is preserved, only scaling and translation is performed.
		/// StartWidgetInteraction() - generally corresponds to a initial event (e.g.,
		/// mouse down) that starts the interaction process
		/// with the widget.
		/// WidgetInteraction() - invoked when an event causes the widget to change
		/// appearance.
		/// EndWidgetInteraction() - generally corresponds to a final event (e.g., mouse up)
		/// and completes the interaction sequence.
		/// ComputeInteractionState() - given (X,Y) display coordinates in a renderer, with a
		/// possible flag that modifies the computation,
		/// what is the state of the widget?
		/// GetInteractionState() - return the current state of the widget. Note that the
		/// value of "0" typically refers to "outside". The
		/// interaction state is strictly a function of the
		/// representation, and the widget/represent must agree
		/// on what they mean.
		/// Highlight() - turn on or off any highlights associated with the widget.
		/// Highlights are generally turned on when the widget is selected.
		/// &lt;/pre&gt;
		/// Note that subclasses may ignore some of these methods and implement their own
		/// depending on the specifics of the widget.
		/// </summary>
		// Token: 0x06002A28 RID: 10792 RVA: 0x0003E500 File Offset: 0x0003C700
		public virtual void PlaceWidget(IntPtr arg0)
		{
			vtkWidgetRepresentation.vtkWidgetRepresentation_PlaceWidget_34(base.GetCppThis(), arg0);
		}

		// Token: 0x06002A29 RID: 10793
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWidgetRepresentation_RegisterPickers_35(HandleRef pThis);

		/// <summary>
		/// Register internal Pickers in the Picking Manager.
		/// Must be reimplemented by concrete widget representations to register
		/// their pickers.
		/// </summary>
		// Token: 0x06002A2A RID: 10794 RVA: 0x0003E510 File Offset: 0x0003C710
		public virtual void RegisterPickers()
		{
			vtkWidgetRepresentation.vtkWidgetRepresentation_RegisterPickers_35(base.GetCppThis());
		}

		// Token: 0x06002A2B RID: 10795
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWidgetRepresentation_ReleaseGraphicsResources_36(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods to make this class behave as a vtkProp. They are repeated here (from the
		/// vtkProp superclass) as a reminder to the widget implementor. Failure to implement
		/// these methods properly may result in the representation not appearing in the scene
		/// (i.e., not implementing the Render() methods properly) or leaking graphics resources
		/// (i.e., not implementing ReleaseGraphicsResources() properly).
		/// </summary>
		// Token: 0x06002A2C RID: 10796 RVA: 0x0003E520 File Offset: 0x0003C720
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkWidgetRepresentation.vtkWidgetRepresentation_ReleaseGraphicsResources_36(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002A2D RID: 10797
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWidgetRepresentation_RenderOpaqueGeometry_37(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods to make this class behave as a vtkProp. They are repeated here (from the
		/// vtkProp superclass) as a reminder to the widget implementor. Failure to implement
		/// these methods properly may result in the representation not appearing in the scene
		/// (i.e., not implementing the Render() methods properly) or leaking graphics resources
		/// (i.e., not implementing ReleaseGraphicsResources() properly).
		/// </summary>
		// Token: 0x06002A2E RID: 10798 RVA: 0x0003E550 File Offset: 0x0003C750
		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkWidgetRepresentation.vtkWidgetRepresentation_RenderOpaqueGeometry_37(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002A2F RID: 10799
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWidgetRepresentation_RenderOverlay_38(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods to make this class behave as a vtkProp. They are repeated here (from the
		/// vtkProp superclass) as a reminder to the widget implementor. Failure to implement
		/// these methods properly may result in the representation not appearing in the scene
		/// (i.e., not implementing the Render() methods properly) or leaking graphics resources
		/// (i.e., not implementing ReleaseGraphicsResources() properly).
		/// </summary>
		// Token: 0x06002A30 RID: 10800 RVA: 0x0003E584 File Offset: 0x0003C784
		public override int RenderOverlay(vtkViewport arg0)
		{
			return vtkWidgetRepresentation.vtkWidgetRepresentation_RenderOverlay_38(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002A31 RID: 10801
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWidgetRepresentation_RenderTranslucentPolygonalGeometry_39(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods to make this class behave as a vtkProp. They are repeated here (from the
		/// vtkProp superclass) as a reminder to the widget implementor. Failure to implement
		/// these methods properly may result in the representation not appearing in the scene
		/// (i.e., not implementing the Render() methods properly) or leaking graphics resources
		/// (i.e., not implementing ReleaseGraphicsResources() properly).
		/// </summary>
		// Token: 0x06002A32 RID: 10802 RVA: 0x0003E5B8 File Offset: 0x0003C7B8
		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkWidgetRepresentation.vtkWidgetRepresentation_RenderTranslucentPolygonalGeometry_39(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002A33 RID: 10803
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWidgetRepresentation_RenderVolumetricGeometry_40(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods to make this class behave as a vtkProp. They are repeated here (from the
		/// vtkProp superclass) as a reminder to the widget implementor. Failure to implement
		/// these methods properly may result in the representation not appearing in the scene
		/// (i.e., not implementing the Render() methods properly) or leaking graphics resources
		/// (i.e., not implementing ReleaseGraphicsResources() properly).
		/// </summary>
		// Token: 0x06002A34 RID: 10804 RVA: 0x0003E5EC File Offset: 0x0003C7EC
		public override int RenderVolumetricGeometry(vtkViewport arg0)
		{
			return vtkWidgetRepresentation.vtkWidgetRepresentation_RenderVolumetricGeometry_40(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002A35 RID: 10805
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWidgetRepresentation_SafeDownCast_41(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06002A36 RID: 10806 RVA: 0x0003E620 File Offset: 0x0003C820
		public new static vtkWidgetRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkWidgetRepresentation vtkWidgetRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWidgetRepresentation.vtkWidgetRepresentation_SafeDownCast_41((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWidgetRepresentation = (vtkWidgetRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWidgetRepresentation.Register(null);
				}
			}
			return vtkWidgetRepresentation;
		}

		// Token: 0x06002A37 RID: 10807
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWidgetRepresentation_SetHandleSize_42(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the factor that controls the size of the handles that appear as
		/// part of the widget (if any). These handles (like spheres, etc.)  are
		/// used to manipulate the widget. The HandleSize data member allows you
		/// to change the relative size of the handles. Note that while the handle
		/// size is typically expressed in pixels, some subclasses may use a relative size
		/// with respect to the viewport. (As a corollary, the value of this ivar is often
		/// set by subclasses of this class during instance instantiation.)
		/// </summary>
		// Token: 0x06002A38 RID: 10808 RVA: 0x0003E69F File Offset: 0x0003C89F
		public virtual void SetHandleSize(double _arg)
		{
			vtkWidgetRepresentation.vtkWidgetRepresentation_SetHandleSize_42(base.GetCppThis(), _arg);
		}

		// Token: 0x06002A39 RID: 10809
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWidgetRepresentation_SetNeedToRender_43(HandleRef pThis, int _arg);

		/// <summary>
		/// Some subclasses use this data member to keep track of whether to render
		/// or not (i.e., to minimize the total number of renders).
		/// </summary>
		// Token: 0x06002A3A RID: 10810 RVA: 0x0003E6AF File Offset: 0x0003C8AF
		public virtual void SetNeedToRender(int _arg)
		{
			vtkWidgetRepresentation.vtkWidgetRepresentation_SetNeedToRender_43(base.GetCppThis(), _arg);
		}

		// Token: 0x06002A3B RID: 10811
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWidgetRepresentation_SetPickingManaged_44(HandleRef pThis, byte managed);

		/// <summary>
		/// Enable/Disable the use of a manager to process the picking.
		/// Enabled by default.
		/// </summary>
		// Token: 0x06002A3C RID: 10812 RVA: 0x0003E6BF File Offset: 0x0003C8BF
		public void SetPickingManaged(bool managed)
		{
			vtkWidgetRepresentation.vtkWidgetRepresentation_SetPickingManaged_44(base.GetCppThis(), managed ? (byte)1 : (byte)0);
		}

		// Token: 0x06002A3D RID: 10813
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWidgetRepresentation_SetPlaceFactor_45(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get a factor representing the scaling of the widget upon placement
		/// (via the PlaceWidget() method). Normally the widget is placed so that
		/// it just fits within the bounding box defined in PlaceWidget(bounds).
		/// The PlaceFactor will make the widget larger (PlaceFactor &gt; 1) or smaller
		/// (PlaceFactor &lt; 1). By default, PlaceFactor is set to 0.5.
		/// </summary>
		// Token: 0x06002A3E RID: 10814 RVA: 0x0003E6D7 File Offset: 0x0003C8D7
		public virtual void SetPlaceFactor(double _arg)
		{
			vtkWidgetRepresentation.vtkWidgetRepresentation_SetPlaceFactor_45(base.GetCppThis(), _arg);
		}

		// Token: 0x06002A3F RID: 10815
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWidgetRepresentation_SetRenderer_46(HandleRef pThis, HandleRef ren);

		/// <summary>
		/// Subclasses of vtkWidgetRepresentation must implement these methods. This is
		/// considered the minimum API for a widget representation.
		/// &lt;pre&gt;
		/// SetRenderer() - the renderer in which the representations draws itself.
		/// Typically the renderer is set by the associated widget.
		/// Use the widget's SetCurrentRenderer() method in most cases;
		/// otherwise there is a risk of inconsistent behavior as events
		/// and drawing may be performed in different viewports.
		/// BuildRepresentation() - update the geometry of the widget based on its
		/// current state.
		/// &lt;/pre&gt;
		/// WARNING: The renderer is NOT reference counted by the representation,
		/// in order to avoid reference loops.  Be sure that the representation
		/// lifetime does not extend beyond the renderer lifetime.
		/// </summary>
		// Token: 0x06002A40 RID: 10816 RVA: 0x0003E6E8 File Offset: 0x0003C8E8
		public virtual void SetRenderer(vtkRenderer ren)
		{
			vtkWidgetRepresentation.vtkWidgetRepresentation_SetRenderer_46(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		// Token: 0x06002A41 RID: 10817
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWidgetRepresentation_ShallowCopy_47(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Methods to make this class behave as a vtkProp. They are repeated here (from the
		/// vtkProp superclass) as a reminder to the widget implementor. Failure to implement
		/// these methods properly may result in the representation not appearing in the scene
		/// (i.e., not implementing the Render() methods properly) or leaking graphics resources
		/// (i.e., not implementing ReleaseGraphicsResources() properly).
		/// </summary>
		// Token: 0x06002A42 RID: 10818 RVA: 0x0003E718 File Offset: 0x0003C918
		public override void ShallowCopy(vtkProp prop)
		{
			vtkWidgetRepresentation.vtkWidgetRepresentation_ShallowCopy_47(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		// Token: 0x06002A43 RID: 10819
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWidgetRepresentation_StartComplexInteraction_48(HandleRef pThis, HandleRef arg0, HandleRef arg1, uint arg2, IntPtr arg3);

		/// <summary>
		/// The following is a suggested API for widget representations. These methods
		/// define the communication between the widget and its representation. These
		/// methods are only suggestions because widgets take on so many different
		/// forms that a universal API is not deemed practical. However, these methods
		/// should be implemented when possible to ensure that the VTK widget hierarchy
		/// remains self-consistent.
		/// &lt;pre&gt;
		/// PlaceWidget() - given a bounding box (xmin,xmax,ymin,ymax,zmin,zmax), place
		/// the widget inside of it. The current orientation of the widget
		/// is preserved, only scaling and translation is performed.
		/// StartWidgetInteraction() - generally corresponds to a initial event (e.g.,
		/// mouse down) that starts the interaction process
		/// with the widget.
		/// WidgetInteraction() - invoked when an event causes the widget to change
		/// appearance.
		/// EndWidgetInteraction() - generally corresponds to a final event (e.g., mouse up)
		/// and completes the interaction sequence.
		/// ComputeInteractionState() - given (X,Y) display coordinates in a renderer, with a
		/// possible flag that modifies the computation,
		/// what is the state of the widget?
		/// GetInteractionState() - return the current state of the widget. Note that the
		/// value of "0" typically refers to "outside". The
		/// interaction state is strictly a function of the
		/// representation, and the widget/represent must agree
		/// on what they mean.
		/// Highlight() - turn on or off any highlights associated with the widget.
		/// Highlights are generally turned on when the widget is selected.
		/// &lt;/pre&gt;
		/// Note that subclasses may ignore some of these methods and implement their own
		/// depending on the specifics of the widget.
		/// </summary>
		// Token: 0x06002A44 RID: 10820 RVA: 0x0003E748 File Offset: 0x0003C948
		public virtual void StartComplexInteraction(vtkRenderWindowInteractor arg0, vtkAbstractWidget arg1, uint arg2, IntPtr arg3)
		{
			vtkWidgetRepresentation.vtkWidgetRepresentation_StartComplexInteraction_48(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis(), arg2, arg3);
		}

		// Token: 0x06002A45 RID: 10821
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWidgetRepresentation_StartWidgetInteraction_49(HandleRef pThis, IntPtr eventPos);

		/// <summary>
		/// The following is a suggested API for widget representations. These methods
		/// define the communication between the widget and its representation. These
		/// methods are only suggestions because widgets take on so many different
		/// forms that a universal API is not deemed practical. However, these methods
		/// should be implemented when possible to ensure that the VTK widget hierarchy
		/// remains self-consistent.
		/// &lt;pre&gt;
		/// PlaceWidget() - given a bounding box (xmin,xmax,ymin,ymax,zmin,zmax), place
		/// the widget inside of it. The current orientation of the widget
		/// is preserved, only scaling and translation is performed.
		/// StartWidgetInteraction() - generally corresponds to a initial event (e.g.,
		/// mouse down) that starts the interaction process
		/// with the widget.
		/// WidgetInteraction() - invoked when an event causes the widget to change
		/// appearance.
		/// EndWidgetInteraction() - generally corresponds to a final event (e.g., mouse up)
		/// and completes the interaction sequence.
		/// ComputeInteractionState() - given (X,Y) display coordinates in a renderer, with a
		/// possible flag that modifies the computation,
		/// what is the state of the widget?
		/// GetInteractionState() - return the current state of the widget. Note that the
		/// value of "0" typically refers to "outside". The
		/// interaction state is strictly a function of the
		/// representation, and the widget/represent must agree
		/// on what they mean.
		/// Highlight() - turn on or off any highlights associated with the widget.
		/// Highlights are generally turned on when the widget is selected.
		/// &lt;/pre&gt;
		/// Note that subclasses may ignore some of these methods and implement their own
		/// depending on the specifics of the widget.
		/// </summary>
		// Token: 0x06002A46 RID: 10822 RVA: 0x0003E78F File Offset: 0x0003C98F
		public virtual void StartWidgetInteraction(IntPtr eventPos)
		{
			vtkWidgetRepresentation.vtkWidgetRepresentation_StartWidgetInteraction_49(base.GetCppThis(), eventPos);
		}

		// Token: 0x06002A47 RID: 10823
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWidgetRepresentation_UnRegisterPickers_50(HandleRef pThis);

		/// <summary>
		/// Unregister internal pickers from the Picking Manager.
		/// </summary>
		// Token: 0x06002A48 RID: 10824 RVA: 0x0003E79F File Offset: 0x0003C99F
		public virtual void UnRegisterPickers()
		{
			vtkWidgetRepresentation.vtkWidgetRepresentation_UnRegisterPickers_50(base.GetCppThis());
		}

		// Token: 0x06002A49 RID: 10825
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWidgetRepresentation_WidgetInteraction_51(HandleRef pThis, IntPtr newEventPos);

		/// <summary>
		/// The following is a suggested API for widget representations. These methods
		/// define the communication between the widget and its representation. These
		/// methods are only suggestions because widgets take on so many different
		/// forms that a universal API is not deemed practical. However, these methods
		/// should be implemented when possible to ensure that the VTK widget hierarchy
		/// remains self-consistent.
		/// &lt;pre&gt;
		/// PlaceWidget() - given a bounding box (xmin,xmax,ymin,ymax,zmin,zmax), place
		/// the widget inside of it. The current orientation of the widget
		/// is preserved, only scaling and translation is performed.
		/// StartWidgetInteraction() - generally corresponds to a initial event (e.g.,
		/// mouse down) that starts the interaction process
		/// with the widget.
		/// WidgetInteraction() - invoked when an event causes the widget to change
		/// appearance.
		/// EndWidgetInteraction() - generally corresponds to a final event (e.g., mouse up)
		/// and completes the interaction sequence.
		/// ComputeInteractionState() - given (X,Y) display coordinates in a renderer, with a
		/// possible flag that modifies the computation,
		/// what is the state of the widget?
		/// GetInteractionState() - return the current state of the widget. Note that the
		/// value of "0" typically refers to "outside". The
		/// interaction state is strictly a function of the
		/// representation, and the widget/represent must agree
		/// on what they mean.
		/// Highlight() - turn on or off any highlights associated with the widget.
		/// Highlights are generally turned on when the widget is selected.
		/// &lt;/pre&gt;
		/// Note that subclasses may ignore some of these methods and implement their own
		/// depending on the specifics of the widget.
		/// </summary>
		// Token: 0x06002A4A RID: 10826 RVA: 0x0003E7AE File Offset: 0x0003C9AE
		public virtual void WidgetInteraction(IntPtr newEventPos)
		{
			vtkWidgetRepresentation.vtkWidgetRepresentation_WidgetInteraction_51(base.GetCppThis(), newEventPos);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400056C RID: 1388
		public new const string MRFullTypeName = "Kitware.VTK.vtkWidgetRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400056D RID: 1389
		public new static readonly string MRClassNameKey = "class vtkWidgetRepresentation";

		/// <summary>
		/// Axis labels
		/// </summary>
		// Token: 0x020000C1 RID: 193
		public enum Axis
		{
			/// <summary>enum member</summary>
			// Token: 0x0400056F RID: 1391
			Custom = 3,
			/// <summary>enum member</summary>
			// Token: 0x04000570 RID: 1392
			NONE = -1,
			/// <summary>enum member</summary>
			// Token: 0x04000571 RID: 1393
			XAxis,
			/// <summary>enum member</summary>
			// Token: 0x04000572 RID: 1394
			YAxis,
			/// <summary>enum member</summary>
			// Token: 0x04000573 RID: 1395
			ZAxis
		}
	}
}
