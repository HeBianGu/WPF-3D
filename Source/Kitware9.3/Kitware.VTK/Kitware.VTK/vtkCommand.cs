using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCommand
	/// </summary>
	/// <remarks>
	///    superclass for callback/observer methods
	///
	/// vtkCommand is an implementation of the observer/command design
	/// pattern.  In this design pattern, any instance of vtkObject can be
	/// "observed" for any events it might invoke. For example,
	/// vtkRenderer invokes a StartEvent as it begins to render and a
	/// EndEvent when it finishes rendering. Filters (subclasses of
	/// vtkProcessObject) invoke StartEvent, ProgressEvent, and EndEvent as
	/// the filter processes data. Observers of events are added with the
	/// AddObserver() method found in vtkObject.  AddObserver(), besides
	/// requiring an event id or name, also takes an instance of vtkCommand
	/// (or a subclasses). Note that vtkCommand is meant to be subclassed,
	/// so that you can package the information necessary to support your
	/// callback.
	///
	/// Event processing can be organized in priority lists, so it is
	/// possible to truncate the processing of a particular event by
	/// setting the AbortFlag variable. The priority is set using the
	/// AddObserver() method.  By default the priority is 0, events of the
	/// same priority are processed in last-in-first-processed order. The
	/// ordering/aborting of events is important for things like 3D
	/// widgets, which handle an event if the widget is selected (and then
	/// aborting further processing of that event).  Otherwise. the event
	/// is passed along for further processing.
	///
	/// When an instance of vtkObject invokes an event, it also passes an optional
	/// void pointer to a callData. This callData is nullptr most of the time.
	/// The callData is not specific to a type of event but specific to a type
	/// of vtkObject invoking a specific event. For instance, vtkCommand::PickEvent
	/// is invoked by vtkProp with a nullptr callData but is invoked by
	/// vtkInteractorStyleImage with a pointer to the vtkInteractorStyleImage object
	/// itself.
	///
	/// Here is the list of events that may be invoked with a non-nullptr callData.
	/// - vtkCommand::ProgressEvent
	///  - most of the objects return a pointer to a double value ranged between
	/// 0.0 and 1.0
	///  - Infovis/vtkFixedWidthTextReader returns a pointer to a float value equal
	/// to the number of lines read so far.
	/// - vtkCommand::ErrorEvent
	///  - an error message as a const char * string
	/// - vtkCommand::WarningEvent
	///  - a warning message as a const char * string
	/// - vtkCommand::StartAnimationCueEvent
	///  - a pointer to a vtkAnimationCue::AnimationCueInfo object
	/// - vtkCommand::EndAnimationCueEvent
	///  - a pointer to a vtkAnimationCue::AnimationCueInfo object
	/// - vtkCommand::AnimationCueTickEvent
	///  - a pointer to a vtkAnimationCue::AnimationCueInfo object
	/// - vtkCommand::PickEvent
	///  - Common/vtkProp returns nullptr
	///  - Rendering/vtkInteractorStyleImage returns a pointer to itself
	/// - vtkCommand::StartPickEvent
	///  - Rendering/vtkPropPicker returns nullptr
	///  - Rendering/vtkInteractorStyleImage returns a pointer to itself
	/// - vtkCommand::EndPickEvent
	///  - Rendering/vtkPropPicker returns nullptr
	///  - Rendering/vtkInteractorStyleImage returns a pointer to itself
	/// - vtkCommand::WrongTagEvent
	///  - Parallel/vtkSocketCommunicator returns a received tag as a char *
	/// - vtkCommand::SelectionChangedEvent
	///  - Views/vtkView returns nullptr
	///  - Views/vtkDataRepresentation returns a pointer to a vtkSelection
	///  - Rendering/vtkInteractorStyleRubberBand2D returns an array of 5 unsigned
	/// integers (p1x, p1y, p2x, p2y, mode), where mode is
	/// vtkInteractorStyleRubberBand2D::SELECT_UNION or
	/// vtkInteractorStyleRubberBand2D::SELECT_NORMAL
	/// - vtkCommand::AnnotationChangedEvent
	///  - GUISupport/Qt/vtkQtAnnotationView returns a pointer to a
	/// vtkAnnotationLayers
	/// - vtkCommand::PlacePointEvent
	///  - Widgets/vtkSeedWidget returns a pointer to an int, being the current
	/// handle number
	/// - vtkCommand::DeletePointEvent
	///  - Widgets/vtkSeedWidget returns a pointer to an int, being the
	/// handle number of the deleted point
	/// - vtkCommand::ResetWindowLevelEvent
	///  - Widgets/vtkImagePlaneWidget returns an array of 2 double values (window
	/// and level)
	///  - Rendering/vtkInteractorStyleImage returns a pointer to itself
	/// - vtkCommand::StartWindowLevelEvent
	///  - Widgets/vtkImagePlaneWidget returns an array of 2 double values (window
	/// and level)
	///  - Rendering/vtkInteractorStyleImage returns a pointer to itself
	/// - vtkCommand::EndWindowLevelEvent
	///  - Widgets/vtkImagePlaneWidget returns an array of 2 double values (window
	/// and level)
	///  - Rendering/vtkInteractorStyleImage returns a pointer to itself
	/// - vtkCommand::WindowLevelEvent
	///  - Widgets/vtkImagePlaneWidget returns an array of 2 double values (window
	/// and level)
	///  - Rendering/vtkInteractorStyleImage returns a pointer to itself
	/// - vtkCommand::CharEvent
	///  - most of the objects return nullptr
	///  - GUISupport/Qt/QVTKOpenGLStereoWidget returns a QKeyEvent *
	/// - vtkCommand::TimerEvent
	///  - most of the objects return a to an int representing a timer id
	///  - Widgets/vtkHoverWidget returns nullptr
	/// - vtkCommand::CreateTimerEvent
	///  - Rendering/vtkGenericRenderWindowInteractor returns a to an int
	/// representing a timer id
	/// - vtkCommand::DestroyTimerEvent
	///  - Rendering/vtkGenericRenderWindowInteractor returns a to an int
	/// representing a timer id
	/// - vtkCommand::UserEvent
	///  - most of the objects return nullptr
	///  - Infovis/vtkInteractorStyleTreeMapHover returns a pointer to a vtkIdType
	/// representing a pedigree id
	/// - vtkCommand::KeyPressEvent
	///  - most of the objects return nullptr
	///  - GUISupport/Qt/QVTKOpenGLStereoWidget returns a QKeyEvent*
	/// - vtkCommand::KeyReleaseEvent
	///  - most of the objects return nullptr
	///  - GUISupport/Qt/QVTKOpenGLStereoWidget returns a QKeyEvent*
	/// - vtkCommand::LeftButtonPressEvent
	///  - most of the objects return nullptr
	///  - GUISupport/Qt/QVTKOpenGLStereoWidget returns a QMouseEvent*
	/// - vtkCommand::LeftButtonReleaseEvent
	///  - most of the objects return nullptr
	///  - GUISupport/Qt/QVTKOpenGLStereoWidget returns a QMouseEvent*
	/// - vtkCommand::MouseMoveEvent
	///  - most of the objects return nullptr
	///  - GUISupport/Qt/QVTKOpenGLStereoWidget returns a QMouseEvent*
	/// - vtkCommand::MouseWheelForwardEvent
	///  - most of the objects return nullptr
	///  - GUISupport/Qt/QVTKOpenGLStereoWidget returns a QWheelEvent*
	/// - vtkCommand::MouseWheelBackwardEvent
	///  - most of the objects return nullptr
	///  - GUISupport/Qt/QVTKOpenGLStereoWidget returns a QWheelEvent*
	/// - vtkCommand::RightButtonPressEvent
	///  - most of the objects return nullptr
	///  - GUISupport/Qt/QVTKOpenGLStereoWidget returns a QMouseEvent*
	/// - vtkCommand::RightButtonReleaseEvent
	///  - most of the objects return nullptr
	///  - GUISupport/Qt/QVTKOpenGLStereoWidget returns a QMouseEvent*
	/// - vtkCommand::MiddleButtonPressEvent
	///  - most of the objects return nullptr
	///  - GUISupport/Qt/QVTKOpenGLStereoWidget returns a QMouseEvent*
	/// - vtkCommand::MiddleButtonReleaseEvent
	///  - most of the objects return nullptr
	///  - GUISupport/Qt/QVTKOpenGLStereoWidget returns a QMouseEvent*
	/// - vtkCommand::CursorChangedEvent
	///  - most of the objects return a pointer to an int representing a shape
	///  - Rendering/vtkInteractorObserver returns nullptr
	/// - vtkCommand::ResetCameraEvent
	///  - Rendering/vtkRenderer returns a pointer to itself
	/// - vtkCommand::ResetCameraClippingRangeEvent
	///  - Rendering/vtkRenderer returns a pointer to itself
	/// - vtkCommand::ActiveCameraEvent
	///  - Rendering/vtkRenderer returns a pointer to the active camera
	/// - vtkCommand::CreateCameraEvent
	///  - Rendering/vtkRenderer returns a pointer to the created camera
	/// - vtkCommand::EnterEvent
	///  - most of the objects return nullptr
	///  - GUISupport/Qt/QVTKOpenGLStereoWidget returns a QEvent*
	/// - vtkCommand::LeaveEvent
	///  - most of the objects return nullptr
	///  - GUISupport/Qt/QVTKOpenGLStereoWidget returns a QEvent*
	/// - vtkCommand::RenderWindowMessageEvent
	///  - Rendering/vtkWin32OpenGLRenderWindow return a pointer to a UINT message
	/// - vtkCommand::ComputeVisiblePropBoundsEvent
	///  - Rendering/vtkRenderer returns a pointer to itself
	/// - QVTKOpenGLStereoWidget::ContextMenuEvent
	///  - GUISupport/Qt/QVTKOpenGLStereoWidget returns a QContextMenuEvent*
	/// - QVTKOpenGLStereoWidget::DragEnterEvent
	///  - GUISupport/Qt/QVTKOpenGLStereoWidget returns a QDragEnterEvent*
	/// - QVTKOpenGLStereoWidget::DragMoveEvent
	///  - GUISupport/Qt/QVTKOpenGLStereoWidget returns a QDragMoveEvent*
	/// - QVTKOpenGLStereoWidget::DragLeaveEvent
	///  - GUISupport/Qt/QVTKOpenGLStereoWidget returns a QDragLeaveEvent*
	/// - QVTKOpenGLStereoWidget::DropEvent
	///  - GUISupport/Qt/QVTKOpenGLStereoWidget returns a QDropEvent*
	/// - vtkCommand::ViewProgressEvent
	///  - View/vtkView returns a ViewProgressEventCallData*
	/// - vtkCommand::VolumeMapperRenderProgressEvent
	///  - A pointer to a double value between 0.0 and 1.0
	/// - vtkCommand::VolumeMapperComputeGradientsProgressEvent
	///  - A pointer to a double value between 0.0 and 1.0
	/// - vtkCommand::TDxMotionEvent (TDx=3DConnexion)
	///  - A vtkTDxMotionEventInfo*
	/// - vtkCommand::TDxButtonPressEvent
	///  - A int* being the number of the button
	/// - vtkCommand::TDxButtonReleaseEvent
	///  - A int* being the number of the button
	/// - vtkCommand::UpdateShaderEvent
	///  - A vtkOpenGLHelper* currently being used
	/// - vtkCommand::FourthButtonPressEvent
	///  - most of the objects return nullptr
	/// - vtkCommand::FourthButtonReleaseEvent
	///  - most of the objects return nullptr
	/// - vtkCommand::FifthButtonPressEvent
	///  - most of the objects return nullptr
	/// - vtkCommand::FifthButtonReleaseEvent
	///  - most of the objects return nullptr
	/// - vtkCommand::MouseWheelLeftEvent
	///  - most of the objects return nullptr
	///  - GUISupport/Qt/QVTKOpenGLWidget returns a QWheelEvent*
	/// - vtkCommand::MouseWheelRightEvent
	///  - most of the objects return nullptr
	///  - GUISupport/Qt/QVTKOpenGLWidget returns a QWheelEvent*
	/// - vtkCommand::ErrorEvent
	///  - vtkOutputWindow fires this with `char char*` for the error message
	/// - vtkCommand::WarningEvent
	///  - vtkOutputWindow fires this with `char char*` for the warning message
	/// - vtkCommand::MessageEvent
	///  - vtkOutputWindow fires this with `char char*` for the message text
	/// - vtkCommand::TextEvent
	///  - vtkOutputWindow fires this with `char char*` for the text
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkObject vtkCallbackCommand vtkOldStyleCallbackCommand
	/// vtkInteractorObserver vtk3DWidget
	/// </seealso>
	// Token: 0x02000B4A RID: 2890
	public abstract class vtkCommand : vtkObjectBase
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E34E RID: 123726 RVA: 0x002ABAD3 File Offset: 0x002A9CD3
		static vtkCommand()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCommand.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCommand"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E34F RID: 123727 RVA: 0x002ABAFB File Offset: 0x002A9CFB
		public vtkCommand(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601E350 RID: 123728
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCommand_UnRegister_19(HandleRef pThis);

		/// <summary>
		/// Decrease the reference count (release by another object). This has
		/// the same effect as invoking Delete() (i.e., it reduces the reference
		/// count by 1).
		/// </summary>
		// Token: 0x0601E351 RID: 123729 RVA: 0x002ABB0C File Offset: 0x002A9D0C
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (base.GetCallDisposalMethod())
				{
					vtkCommand.vtkCommand_UnRegister_19(base.GetCppThis());
					base.ClearCppThis();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x0601E352 RID: 123730
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCommand_AbortFlagOff_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the abort flag. If this is set to true no further
		/// commands are executed.
		/// </summary>
		// Token: 0x0601E353 RID: 123731 RVA: 0x002ABB5C File Offset: 0x002A9D5C
		public void AbortFlagOff()
		{
			vtkCommand.vtkCommand_AbortFlagOff_01(base.GetCppThis());
		}

		// Token: 0x0601E354 RID: 123732
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCommand_AbortFlagOn_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the abort flag. If this is set to true no further
		/// commands are executed.
		/// </summary>
		// Token: 0x0601E355 RID: 123733 RVA: 0x002ABB6B File Offset: 0x002A9D6B
		public void AbortFlagOn()
		{
			vtkCommand.vtkCommand_AbortFlagOn_02(base.GetCppThis());
		}

		// Token: 0x0601E356 RID: 123734
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCommand_EventHasData_03(uint arg0);

		/// <summary>
		/// Does this event type contain vtkEventData
		/// </summary>
		// Token: 0x0601E357 RID: 123735 RVA: 0x002ABB7C File Offset: 0x002A9D7C
		public static bool EventHasData(uint arg0)
		{
			return vtkCommand.vtkCommand_EventHasData_03(arg0) != 0;
		}

		// Token: 0x0601E358 RID: 123736
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCommand_Execute_04(HandleRef pThis, HandleRef caller, uint eventId, IntPtr callData);

		/// <summary>
		/// All derived classes of vtkCommand must implement this
		/// method. This is the method that actually does the work of the
		/// callback. The caller argument is the object invoking the event,
		/// the eventId parameter is the id of the event, and callData
		/// parameter is data that can be passed into the execute
		/// method. (Note: vtkObject::InvokeEvent() takes two parameters: the
		/// event id (or name) and call data. Typically call data is nullptr,
		/// but the user can package data and pass it this
		/// way. Alternatively, a derived class of vtkCommand can be used to
		/// pass data.)
		/// </summary>
		// Token: 0x0601E359 RID: 123737 RVA: 0x002ABBA0 File Offset: 0x002A9DA0
		public virtual void Execute(vtkObject caller, uint eventId, IntPtr callData)
		{
			vtkCommand.vtkCommand_Execute_04(base.GetCppThis(), (caller == null) ? default(HandleRef) : caller.GetCppThis(), eventId, callData);
		}

		// Token: 0x0601E35A RID: 123738
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommand_GetAbortFlag_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the abort flag. If this is set to true no further
		/// commands are executed.
		/// </summary>
		// Token: 0x0601E35B RID: 123739 RVA: 0x002ABBD4 File Offset: 0x002A9DD4
		public int GetAbortFlag()
		{
			return vtkCommand.vtkCommand_GetAbortFlag_05(base.GetCppThis());
		}

		// Token: 0x0601E35C RID: 123740
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkCommand_GetEventIdFromString_06([MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Convenience methods for translating between event names and event
		/// ids.
		/// </summary>
		// Token: 0x0601E35D RID: 123741 RVA: 0x002ABBF4 File Offset: 0x002A9DF4
		public static uint GetEventIdFromString(string arg0)
		{
			return vtkCommand.vtkCommand_GetEventIdFromString_06(arg0);
		}

		// Token: 0x0601E35E RID: 123742
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCommand_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E35F RID: 123743 RVA: 0x002ABC10 File Offset: 0x002A9E10
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCommand.vtkCommand_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0601E360 RID: 123744
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCommand_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E361 RID: 123745 RVA: 0x002ABC30 File Offset: 0x002A9E30
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCommand.vtkCommand_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x0601E362 RID: 123746
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommand_GetPassiveObserver_09(HandleRef pThis);

		/// <summary>
		/// Set/Get the passive observer flag. If this is set to true, this
		/// indicates that this command does not change the state of the
		/// system in any way. Passive observers are processed first, and
		/// are not called even when another command has focus.
		/// </summary>
		// Token: 0x0601E363 RID: 123747 RVA: 0x002ABC4C File Offset: 0x002A9E4C
		public int GetPassiveObserver()
		{
			return vtkCommand.vtkCommand_GetPassiveObserver_09(base.GetCppThis());
		}

		// Token: 0x0601E364 RID: 123748
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCommand_GetStringFromEventId_10(uint arg0);

		/// <summary>
		/// Convenience methods for translating between event names and event
		/// ids.
		/// </summary>
		// Token: 0x0601E365 RID: 123749 RVA: 0x002ABC6C File Offset: 0x002A9E6C
		public static string GetStringFromEventId(uint arg0)
		{
			string s = Marshal.PtrToStringAnsi(vtkCommand.vtkCommand_GetStringFromEventId_10(arg0));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601E366 RID: 123750
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommand_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E367 RID: 123751 RVA: 0x002ABCA4 File Offset: 0x002A9EA4
		public override int IsA(string type)
		{
			return vtkCommand.vtkCommand_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x0601E368 RID: 123752
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommand_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E369 RID: 123753 RVA: 0x002ABCC4 File Offset: 0x002A9EC4
		public new static int IsTypeOf(string type)
		{
			return vtkCommand.vtkCommand_IsTypeOf_12(type);
		}

		// Token: 0x0601E36A RID: 123754
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCommand_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E36B RID: 123755 RVA: 0x002ABCE0 File Offset: 0x002A9EE0
		public vtkCommand NewInstance()
		{
			vtkCommand result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCommand.vtkCommand_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCommand)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E36C RID: 123756
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCommand_PassiveObserverOff_14(HandleRef pThis);

		/// <summary>
		/// Set/Get the passive observer flag. If this is set to true, this
		/// indicates that this command does not change the state of the
		/// system in any way. Passive observers are processed first, and
		/// are not called even when another command has focus.
		/// </summary>
		// Token: 0x0601E36D RID: 123757 RVA: 0x002ABD3A File Offset: 0x002A9F3A
		public void PassiveObserverOff()
		{
			vtkCommand.vtkCommand_PassiveObserverOff_14(base.GetCppThis());
		}

		// Token: 0x0601E36E RID: 123758
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCommand_PassiveObserverOn_15(HandleRef pThis);

		/// <summary>
		/// Set/Get the passive observer flag. If this is set to true, this
		/// indicates that this command does not change the state of the
		/// system in any way. Passive observers are processed first, and
		/// are not called even when another command has focus.
		/// </summary>
		// Token: 0x0601E36F RID: 123759 RVA: 0x002ABD49 File Offset: 0x002A9F49
		public void PassiveObserverOn()
		{
			vtkCommand.vtkCommand_PassiveObserverOn_15(base.GetCppThis());
		}

		// Token: 0x0601E370 RID: 123760
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCommand_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E371 RID: 123761 RVA: 0x002ABD58 File Offset: 0x002A9F58
		public static vtkCommand SafeDownCast(vtkObjectBase o)
		{
			vtkCommand vtkCommand = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCommand.vtkCommand_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCommand = (vtkCommand)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCommand.Register(null);
				}
			}
			return vtkCommand;
		}

		// Token: 0x0601E372 RID: 123762
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCommand_SetAbortFlag_17(HandleRef pThis, int f);

		/// <summary>
		/// Set/Get the abort flag. If this is set to true no further
		/// commands are executed.
		/// </summary>
		// Token: 0x0601E373 RID: 123763 RVA: 0x002ABDD7 File Offset: 0x002A9FD7
		public void SetAbortFlag(int f)
		{
			vtkCommand.vtkCommand_SetAbortFlag_17(base.GetCppThis(), f);
		}

		// Token: 0x0601E374 RID: 123764
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCommand_SetPassiveObserver_18(HandleRef pThis, int f);

		/// <summary>
		/// Set/Get the passive observer flag. If this is set to true, this
		/// indicates that this command does not change the state of the
		/// system in any way. Passive observers are processed first, and
		/// are not called even when another command has focus.
		/// </summary>
		// Token: 0x0601E375 RID: 123765 RVA: 0x002ABDE7 File Offset: 0x002A9FE7
		public void SetPassiveObserver(int f)
		{
			vtkCommand.vtkCommand_SetPassiveObserver_18(base.GetCppThis(), f);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FE7 RID: 8167
		public new const string MRFullTypeName = "Kitware.VTK.vtkCommand";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FE8 RID: 8168
		public new static readonly string MRClassNameKey = "class vtkCommand";

		/// <summary>
		/// All the currently defined events are listed here.  Developers can
		/// use -- vtkCommand::UserEvent + int to specify their own event
		/// ids.
		/// Add new events by updating vtkAllEventsMacro.
		/// </summary>
		// Token: 0x02000B4B RID: 2891
		public enum EventIds
		{
			/// <summary>enum member</summary>
			// Token: 0x04001FEA RID: 8170
			AbortCheckEvent = 10,
			/// <summary>enum member</summary>
			// Token: 0x04001FEB RID: 8171
			ActiveCameraEvent = 29,
			/// <summary>enum member</summary>
			// Token: 0x04001FEC RID: 8172
			AnimationCueTickEvent = 59,
			/// <summary>enum member</summary>
			// Token: 0x04001FED RID: 8173
			AnnotationChangedEvent = 78,
			/// <summary>enum member</summary>
			// Token: 0x04001FEE RID: 8174
			AnyEvent = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001FEF RID: 8175
			Button3DEvent = 122,
			/// <summary>enum member</summary>
			// Token: 0x04001FF0 RID: 8176
			CharEvent = 22,
			/// <summary>enum member</summary>
			// Token: 0x04001FF1 RID: 8177
			Clip3DEvent = 132,
			/// <summary>enum member</summary>
			// Token: 0x04001FF2 RID: 8178
			ComputeVisiblePropBoundsEvent = 84,
			/// <summary>enum member</summary>
			// Token: 0x04001FF3 RID: 8179
			ConfigureEvent = 24,
			/// <summary>enum member</summary>
			// Token: 0x04001FF4 RID: 8180
			ConnectionClosedEvent = 71,
			/// <summary>enum member</summary>
			// Token: 0x04001FF5 RID: 8181
			ConnectionCreatedEvent = 70,
			/// <summary>enum member</summary>
			// Token: 0x04001FF6 RID: 8182
			CreateCameraEvent = 30,
			/// <summary>enum member</summary>
			// Token: 0x04001FF7 RID: 8183
			CreateTimerEvent = 48,
			/// <summary>enum member</summary>
			// Token: 0x04001FF8 RID: 8184
			CurrentChangedEvent = 83,
			/// <summary>enum member</summary>
			// Token: 0x04001FF9 RID: 8185
			CursorChangedEvent = 53,
			/// <summary>enum member</summary>
			// Token: 0x04001FFA RID: 8186
			DeleteEvent = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001FFB RID: 8187
			DeletePointEvent = 51,
			/// <summary>enum member</summary>
			// Token: 0x04001FFC RID: 8188
			DestroyTimerEvent = 49,
			/// <summary>enum member</summary>
			// Token: 0x04001FFD RID: 8189
			DisableEvent = 47,
			/// <summary>enum member</summary>
			// Token: 0x04001FFE RID: 8190
			DomainModifiedEvent = 72,
			/// <summary>enum member</summary>
			// Token: 0x04001FFF RID: 8191
			DropFilesEvent = 42,
			/// <summary>enum member</summary>
			// Token: 0x04002000 RID: 8192
			Elevation3DEvent = 136,
			/// <summary>enum member</summary>
			// Token: 0x04002001 RID: 8193
			EnableEvent = 46,
			/// <summary>enum member</summary>
			// Token: 0x04002002 RID: 8194
			EndAnimationCueEvent = 60,
			/// <summary>enum member</summary>
			// Token: 0x04002003 RID: 8195
			EndEvent = 4,
			/// <summary>enum member</summary>
			// Token: 0x04002004 RID: 8196
			EndInteractionEvent = 45,
			/// <summary>enum member</summary>
			// Token: 0x04002005 RID: 8197
			EndPanEvent = 114,
			/// <summary>enum member</summary>
			// Token: 0x04002006 RID: 8198
			EndPickEvent = 9,
			/// <summary>enum member</summary>
			// Token: 0x04002007 RID: 8199
			EndPinchEvent = 108,
			/// <summary>enum member</summary>
			// Token: 0x04002008 RID: 8200
			EndRotateEvent = 111,
			/// <summary>enum member</summary>
			// Token: 0x04002009 RID: 8201
			EndSwipeEvent = 105,
			/// <summary>enum member</summary>
			// Token: 0x0400200A RID: 8202
			EndWindowLevelEvent = 36,
			/// <summary>enum member</summary>
			// Token: 0x0400200B RID: 8203
			EnterEvent = 18,
			/// <summary>enum member</summary>
			// Token: 0x0400200C RID: 8204
			ErrorEvent = 39,
			/// <summary>enum member</summary>
			// Token: 0x0400200D RID: 8205
			ExecuteInformationEvent = 54,
			/// <summary>enum member</summary>
			// Token: 0x0400200E RID: 8206
			ExitEvent = 11,
			/// <summary>enum member</summary>
			// Token: 0x0400200F RID: 8207
			ExposeEvent = 23,
			/// <summary>enum member</summary>
			// Token: 0x04002010 RID: 8208
			FifthButtonPressEvent = 119,
			/// <summary>enum member</summary>
			// Token: 0x04002011 RID: 8209
			FifthButtonReleaseEvent,
			/// <summary>enum member</summary>
			// Token: 0x04002012 RID: 8210
			FourthButtonPressEvent = 117,
			/// <summary>enum member</summary>
			// Token: 0x04002013 RID: 8211
			FourthButtonReleaseEvent,
			/// <summary>enum member</summary>
			// Token: 0x04002014 RID: 8212
			HighlightEvent = 95,
			/// <summary>enum member</summary>
			// Token: 0x04002015 RID: 8213
			HoverEvent = 88,
			/// <summary>enum member</summary>
			// Token: 0x04002016 RID: 8214
			InteractionEvent = 44,
			/// <summary>enum member</summary>
			// Token: 0x04002017 RID: 8215
			KeyPressEvent = 20,
			/// <summary>enum member</summary>
			// Token: 0x04002018 RID: 8216
			KeyReleaseEvent,
			/// <summary>enum member</summary>
			// Token: 0x04002019 RID: 8217
			LeaveEvent = 19,
			/// <summary>enum member</summary>
			// Token: 0x0400201A RID: 8218
			LeftButtonDoubleClickEvent = 124,
			/// <summary>enum member</summary>
			// Token: 0x0400201B RID: 8219
			LeftButtonPressEvent = 12,
			/// <summary>enum member</summary>
			// Token: 0x0400201C RID: 8220
			LeftButtonReleaseEvent,
			/// <summary>enum member</summary>
			// Token: 0x0400201D RID: 8221
			LoadStateEvent = 89,
			/// <summary>enum member</summary>
			// Token: 0x0400201E RID: 8222
			LongTapEvent = 116,
			/// <summary>enum member</summary>
			// Token: 0x0400201F RID: 8223
			Menu3DEvent = 130,
			/// <summary>enum member</summary>
			// Token: 0x04002020 RID: 8224
			MessageEvent = 102,
			/// <summary>enum member</summary>
			// Token: 0x04002021 RID: 8225
			MiddleButtonDoubleClickEvent = 125,
			/// <summary>enum member</summary>
			// Token: 0x04002022 RID: 8226
			MiddleButtonPressEvent = 14,
			/// <summary>enum member</summary>
			// Token: 0x04002023 RID: 8227
			MiddleButtonReleaseEvent,
			/// <summary>enum member</summary>
			// Token: 0x04002024 RID: 8228
			ModifiedEvent = 33,
			/// <summary>enum member</summary>
			// Token: 0x04002025 RID: 8229
			MouseMoveEvent = 26,
			/// <summary>enum member</summary>
			// Token: 0x04002026 RID: 8230
			MouseWheelBackwardEvent = 28,
			/// <summary>enum member</summary>
			// Token: 0x04002027 RID: 8231
			MouseWheelForwardEvent = 27,
			/// <summary>enum member</summary>
			// Token: 0x04002028 RID: 8232
			MouseWheelLeftEvent = 127,
			/// <summary>enum member</summary>
			// Token: 0x04002029 RID: 8233
			MouseWheelRightEvent,
			/// <summary>enum member</summary>
			// Token: 0x0400202A RID: 8234
			Move3DEvent = 121,
			/// <summary>enum member</summary>
			// Token: 0x0400202B RID: 8235
			NextPose3DEvent = 131,
			/// <summary>enum member</summary>
			// Token: 0x0400202C RID: 8236
			NoEvent = 0,
			/// <summary>enum member</summary>
			// Token: 0x0400202D RID: 8237
			PanEvent = 113,
			/// <summary>enum member</summary>
			// Token: 0x0400202E RID: 8238
			Pick3DEvent = 134,
			/// <summary>enum member</summary>
			// Token: 0x0400202F RID: 8239
			PickEvent = 7,
			/// <summary>enum member</summary>
			// Token: 0x04002030 RID: 8240
			PinchEvent = 107,
			/// <summary>enum member</summary>
			// Token: 0x04002031 RID: 8241
			PlacePointEvent = 50,
			/// <summary>enum member</summary>
			// Token: 0x04002032 RID: 8242
			PlaceWidgetEvent = 52,
			/// <summary>enum member</summary>
			// Token: 0x04002033 RID: 8243
			PositionProp3DEvent = 133,
			/// <summary>enum member</summary>
			// Token: 0x04002034 RID: 8244
			ProgressEvent = 6,
			/// <summary>enum member</summary>
			// Token: 0x04002035 RID: 8245
			PropertyModifiedEvent = 73,
			/// <summary>enum member</summary>
			// Token: 0x04002036 RID: 8246
			RegisterEvent = 75,
			/// <summary>enum member</summary>
			// Token: 0x04002037 RID: 8247
			RenderEvent = 5,
			/// <summary>enum member</summary>
			// Token: 0x04002038 RID: 8248
			RenderWindowMessageEvent = 55,
			/// <summary>enum member</summary>
			// Token: 0x04002039 RID: 8249
			ResetCameraClippingRangeEvent = 32,
			/// <summary>enum member</summary>
			// Token: 0x0400203A RID: 8250
			ResetCameraEvent = 31,
			/// <summary>enum member</summary>
			// Token: 0x0400203B RID: 8251
			ResetWindowLevelEvent = 37,
			/// <summary>enum member</summary>
			// Token: 0x0400203C RID: 8252
			ResliceAxesChangedEvent = 58,
			/// <summary>enum member</summary>
			// Token: 0x0400203D RID: 8253
			RightButtonDoubleClickEvent = 126,
			/// <summary>enum member</summary>
			// Token: 0x0400203E RID: 8254
			RightButtonPressEvent = 16,
			/// <summary>enum member</summary>
			// Token: 0x0400203F RID: 8255
			RightButtonReleaseEvent,
			/// <summary>enum member</summary>
			// Token: 0x04002040 RID: 8256
			RotateEvent = 110,
			/// <summary>enum member</summary>
			// Token: 0x04002041 RID: 8257
			SaveStateEvent = 90,
			/// <summary>enum member</summary>
			// Token: 0x04002042 RID: 8258
			Select3DEvent = 135,
			/// <summary>enum member</summary>
			// Token: 0x04002043 RID: 8259
			SelectionChangedEvent = 79,
			/// <summary>enum member</summary>
			// Token: 0x04002044 RID: 8260
			SetOutputEvent = 38,
			/// <summary>enum member</summary>
			// Token: 0x04002045 RID: 8261
			StartAnimationCueEvent = 57,
			/// <summary>enum member</summary>
			// Token: 0x04002046 RID: 8262
			StartEvent = 3,
			/// <summary>enum member</summary>
			// Token: 0x04002047 RID: 8263
			StartInteractionEvent = 41,
			/// <summary>enum member</summary>
			// Token: 0x04002048 RID: 8264
			StartPanEvent = 112,
			/// <summary>enum member</summary>
			// Token: 0x04002049 RID: 8265
			StartPickEvent = 8,
			/// <summary>enum member</summary>
			// Token: 0x0400204A RID: 8266
			StartPinchEvent = 106,
			/// <summary>enum member</summary>
			// Token: 0x0400204B RID: 8267
			StartRotateEvent = 109,
			/// <summary>enum member</summary>
			// Token: 0x0400204C RID: 8268
			StartSwipeEvent = 103,
			/// <summary>enum member</summary>
			// Token: 0x0400204D RID: 8269
			StartWindowLevelEvent = 35,
			/// <summary>enum member</summary>
			// Token: 0x0400204E RID: 8270
			StateChangedEvent = 91,
			/// <summary>enum member</summary>
			// Token: 0x0400204F RID: 8271
			SwipeEvent = 104,
			/// <summary>enum member</summary>
			// Token: 0x04002050 RID: 8272
			TDxButtonPressEvent = 86,
			/// <summary>enum member</summary>
			// Token: 0x04002051 RID: 8273
			TDxButtonReleaseEvent,
			/// <summary>enum member</summary>
			// Token: 0x04002052 RID: 8274
			TDxMotionEvent = 85,
			/// <summary>enum member</summary>
			// Token: 0x04002053 RID: 8275
			TapEvent = 115,
			/// <summary>enum member</summary>
			// Token: 0x04002054 RID: 8276
			TextEvent = 123,
			/// <summary>enum member</summary>
			// Token: 0x04002055 RID: 8277
			TimerEvent = 25,
			/// <summary>enum member</summary>
			// Token: 0x04002056 RID: 8278
			UnRegisterEvent = 76,
			/// <summary>enum member</summary>
			// Token: 0x04002057 RID: 8279
			UncheckedPropertyModifiedEvent = 100,
			/// <summary>enum member</summary>
			// Token: 0x04002058 RID: 8280
			UpdateDataEvent = 82,
			/// <summary>enum member</summary>
			// Token: 0x04002059 RID: 8281
			UpdateDropLocationEvent = 43,
			/// <summary>enum member</summary>
			// Token: 0x0400205A RID: 8282
			UpdateEvent = 74,
			/// <summary>enum member</summary>
			// Token: 0x0400205B RID: 8283
			UpdateInformationEvent = 77,
			/// <summary>enum member</summary>
			// Token: 0x0400205C RID: 8284
			UpdatePropertyEvent = 80,
			/// <summary>enum member</summary>
			// Token: 0x0400205D RID: 8285
			UpdateShaderEvent = 101,
			/// <summary>enum member</summary>
			// Token: 0x0400205E RID: 8286
			UserEvent = 1000,
			/// <summary>enum member</summary>
			// Token: 0x0400205F RID: 8287
			ViewProgressEvent = 81,
			/// <summary>enum member</summary>
			// Token: 0x04002060 RID: 8288
			ViewerMovement3DEvent = 129,
			/// <summary>enum member</summary>
			// Token: 0x04002061 RID: 8289
			VolumeMapperComputeGradientsEndEvent = 64,
			/// <summary>enum member</summary>
			// Token: 0x04002062 RID: 8290
			VolumeMapperComputeGradientsProgressEvent,
			/// <summary>enum member</summary>
			// Token: 0x04002063 RID: 8291
			VolumeMapperComputeGradientsStartEvent,
			/// <summary>enum member</summary>
			// Token: 0x04002064 RID: 8292
			VolumeMapperRenderEndEvent = 61,
			/// <summary>enum member</summary>
			// Token: 0x04002065 RID: 8293
			VolumeMapperRenderProgressEvent,
			/// <summary>enum member</summary>
			// Token: 0x04002066 RID: 8294
			VolumeMapperRenderStartEvent,
			/// <summary>enum member</summary>
			// Token: 0x04002067 RID: 8295
			WarningEvent = 40,
			/// <summary>enum member</summary>
			// Token: 0x04002068 RID: 8296
			WidgetActivateEvent = 69,
			/// <summary>enum member</summary>
			// Token: 0x04002069 RID: 8297
			WidgetModifiedEvent = 67,
			/// <summary>enum member</summary>
			// Token: 0x0400206A RID: 8298
			WidgetValueChangedEvent,
			/// <summary>enum member</summary>
			// Token: 0x0400206B RID: 8299
			WindowFrameEvent = 94,
			/// <summary>enum member</summary>
			// Token: 0x0400206C RID: 8300
			WindowIsCurrentEvent = 93,
			/// <summary>enum member</summary>
			// Token: 0x0400206D RID: 8301
			WindowIsDirectEvent = 97,
			/// <summary>enum member</summary>
			// Token: 0x0400206E RID: 8302
			WindowLevelEvent = 34,
			/// <summary>enum member</summary>
			// Token: 0x0400206F RID: 8303
			WindowMakeCurrentEvent = 92,
			/// <summary>enum member</summary>
			// Token: 0x04002070 RID: 8304
			WindowResizeEvent = 99,
			/// <summary>enum member</summary>
			// Token: 0x04002071 RID: 8305
			WindowStereoTypeChangedEvent = 98,
			/// <summary>enum member</summary>
			// Token: 0x04002072 RID: 8306
			WindowSupportsOpenGLEvent = 96,
			/// <summary>enum member</summary>
			// Token: 0x04002073 RID: 8307
			WrongTagEvent = 56
		}
	}
}
