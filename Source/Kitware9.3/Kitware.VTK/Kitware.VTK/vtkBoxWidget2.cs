using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBoxWidget2
	/// </summary>
	/// <remarks>
	///    3D widget for manipulating a box
	///
	/// This 3D widget interacts with a vtkBoxRepresentation class (i.e., it
	/// handles the events that drive its corresponding representation). The
	/// representation is assumed to represent a region of interest that is
	/// represented by an arbitrarily oriented hexahedron (or box) with interior
	/// face angles of 90 degrees (i.e., orthogonal faces). The representation
	/// manifests seven handles that can be moused on and manipulated, plus the
	/// six faces can also be interacted with. The first six handles are placed on
	/// the six faces, the seventh is in the center of the box. In addition, a
	/// bounding box outline is shown, the "faces" of which can be selected for
	/// object rotation or scaling. A nice feature of vtkBoxWidget2, like any 3D
	/// widget, will work with the current interactor style. That is, if
	/// vtkBoxWidget2 does not handle an event, then all other registered
	/// observers (including the interactor style) have an opportunity to process
	/// the event. Otherwise, the vtkBoxWidget will terminate the processing of
	/// the event that it handles.
	///
	/// To use this widget, you generally pair it with a vtkBoxRepresentation
	/// (or a subclass). Various options are available in the representation for
	/// controlling how the widget appears, and how the widget functions.
	///
	/// @par Event Bindings:
	/// By default, the widget responds to the following VTK events (i.e., it
	/// watches the vtkRenderWindowInteractor for these events):
	/// &lt;pre&gt;
	/// If one of the seven handles are selected:
	///   LeftButtonPressEvent - select the appropriate handle
	///   LeftButtonReleaseEvent - release the currently selected handle
	///   MouseMoveEvent - move the handle
	/// If one of the faces is selected:
	///   LeftButtonPressEvent - select a box face
	///   LeftButtonReleaseEvent - release the box face
	///   MouseMoveEvent - rotate the box
	/// In all the cases, independent of what is picked, the widget responds to the
	/// following VTK events:
	///   MiddleButtonPressEvent - translate the widget
	///   MiddleButtonReleaseEvent - release the widget
	///   RightButtonPressEvent - scale the widget's representation
	///   RightButtonReleaseEvent - stop scaling the widget
	///   MouseMoveEvent - scale (if right button) or move (if middle button) the widget
	/// &lt;/pre&gt;
	///
	/// @par Event Bindings:
	/// Note that the event bindings described above can be changed using this
	/// class's vtkWidgetEventTranslator. This class translates VTK events
	/// into the vtkBoxWidget2's widget events:
	/// &lt;pre&gt;
	///   vtkWidgetEvent::Select -- some part of the widget has been selected
	///   vtkWidgetEvent::EndSelect -- the selection process has completed
	///   vtkWidgetEvent::Scale -- some part of the widget has been selected
	///   vtkWidgetEvent::EndScale -- the selection process has completed
	///   vtkWidgetEvent::Translate -- some part of the widget has been selected
	///   vtkWidgetEvent::EndTranslate -- the selection process has completed
	///   vtkWidgetEvent::Move -- a request for motion has been invoked
	/// &lt;/pre&gt;
	///
	/// @par Event Bindings:
	/// In turn, when these widget events are processed, the vtkBoxWidget2
	/// invokes the following VTK events on itself (which observers can listen for):
	/// &lt;pre&gt;
	///   vtkCommand::StartInteractionEvent (on vtkWidgetEvent::Select)
	///   vtkCommand::EndInteractionEvent (on vtkWidgetEvent::EndSelect)
	///   vtkCommand::InteractionEvent (on vtkWidgetEvent::Move)
	/// &lt;/pre&gt;
	///
	///
	/// @par Event Bindings:
	/// This class, and the affiliated vtkBoxRepresentation, are second generation
	/// VTK widgets. An earlier version of this functionality was defined in the
	/// class vtkBoxWidget.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkBoxRepresentation vtkBoxWidget
	/// </seealso>
	// Token: 0x020002D9 RID: 729
	public class vtkBoxWidget2 : vtkAbstractWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600835D RID: 33629 RVA: 0x000BBD8D File Offset: 0x000B9F8D
		static vtkBoxWidget2()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBoxWidget2.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBoxWidget2"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600835E RID: 33630 RVA: 0x000BBDB5 File Offset: 0x000B9FB5
		public vtkBoxWidget2(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600835F RID: 33631
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBoxWidget2_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x06008360 RID: 33632 RVA: 0x000BBDC4 File Offset: 0x000B9FC4
		public new static vtkBoxWidget2 New()
		{
			vtkBoxWidget2 result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBoxWidget2.vtkBoxWidget2_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBoxWidget2)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x06008361 RID: 33633 RVA: 0x000BBE18 File Offset: 0x000BA018
		public vtkBoxWidget2() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBoxWidget2.vtkBoxWidget2_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06008362 RID: 33634 RVA: 0x000BBE5C File Offset: 0x000BA05C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06008363 RID: 33635
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxWidget2_CreateDefaultRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Create the default widget representation if one is not set. By default,
		/// this is an instance of the vtkBoxRepresentation class.
		/// </summary>
		// Token: 0x06008364 RID: 33636 RVA: 0x000BBE67 File Offset: 0x000BA067
		public override void CreateDefaultRepresentation()
		{
			vtkBoxWidget2.vtkBoxWidget2_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06008365 RID: 33637
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBoxWidget2_GetMoveFacesEnabled_02(HandleRef pThis);

		/// <summary>
		/// Control the behavior of the widget (i.e., how it processes
		/// events). Translation, rotation, scaling and face movement can all be enabled and
		/// disabled. Scaling refers to scaling of the whole widget at once,
		/// (default is through right mouse button) while face movement refers to
		/// scaling of the widget one face (axis) at a time (default through grabbing
		/// one of the representation spherical handles).
		/// </summary>
		// Token: 0x06008366 RID: 33638 RVA: 0x000BBE78 File Offset: 0x000BA078
		public virtual int GetMoveFacesEnabled()
		{
			return vtkBoxWidget2.vtkBoxWidget2_GetMoveFacesEnabled_02(base.GetCppThis());
		}

		// Token: 0x06008367 RID: 33639
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBoxWidget2_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard class methods for type information and printing.
		/// </summary>
		// Token: 0x06008368 RID: 33640 RVA: 0x000BBE98 File Offset: 0x000BA098
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBoxWidget2.vtkBoxWidget2_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06008369 RID: 33641
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBoxWidget2_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard class methods for type information and printing.
		/// </summary>
		// Token: 0x0600836A RID: 33642 RVA: 0x000BBEB8 File Offset: 0x000BA0B8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBoxWidget2.vtkBoxWidget2_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0600836B RID: 33643
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBoxWidget2_GetRotationEnabled_05(HandleRef pThis);

		/// <summary>
		/// Control the behavior of the widget (i.e., how it processes
		/// events). Translation, rotation, scaling and face movement can all be enabled and
		/// disabled. Scaling refers to scaling of the whole widget at once,
		/// (default is through right mouse button) while face movement refers to
		/// scaling of the widget one face (axis) at a time (default through grabbing
		/// one of the representation spherical handles).
		/// </summary>
		// Token: 0x0600836C RID: 33644 RVA: 0x000BBED4 File Offset: 0x000BA0D4
		public virtual int GetRotationEnabled()
		{
			return vtkBoxWidget2.vtkBoxWidget2_GetRotationEnabled_05(base.GetCppThis());
		}

		// Token: 0x0600836D RID: 33645
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBoxWidget2_GetScalingEnabled_06(HandleRef pThis);

		/// <summary>
		/// Control the behavior of the widget (i.e., how it processes
		/// events). Translation, rotation, scaling and face movement can all be enabled and
		/// disabled. Scaling refers to scaling of the whole widget at once,
		/// (default is through right mouse button) while face movement refers to
		/// scaling of the widget one face (axis) at a time (default through grabbing
		/// one of the representation spherical handles).
		/// </summary>
		// Token: 0x0600836E RID: 33646 RVA: 0x000BBEF4 File Offset: 0x000BA0F4
		public virtual int GetScalingEnabled()
		{
			return vtkBoxWidget2.vtkBoxWidget2_GetScalingEnabled_06(base.GetCppThis());
		}

		// Token: 0x0600836F RID: 33647
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBoxWidget2_GetTranslationEnabled_07(HandleRef pThis);

		/// <summary>
		/// Control the behavior of the widget (i.e., how it processes
		/// events). Translation, rotation, scaling and face movement can all be enabled and
		/// disabled. Scaling refers to scaling of the whole widget at once,
		/// (default is through right mouse button) while face movement refers to
		/// scaling of the widget one face (axis) at a time (default through grabbing
		/// one of the representation spherical handles).
		/// </summary>
		// Token: 0x06008370 RID: 33648 RVA: 0x000BBF14 File Offset: 0x000BA114
		public virtual int GetTranslationEnabled()
		{
			return vtkBoxWidget2.vtkBoxWidget2_GetTranslationEnabled_07(base.GetCppThis());
		}

		// Token: 0x06008371 RID: 33649
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBoxWidget2_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard class methods for type information and printing.
		/// </summary>
		// Token: 0x06008372 RID: 33650 RVA: 0x000BBF34 File Offset: 0x000BA134
		public override int IsA(string type)
		{
			return vtkBoxWidget2.vtkBoxWidget2_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x06008373 RID: 33651
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBoxWidget2_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard class methods for type information and printing.
		/// </summary>
		// Token: 0x06008374 RID: 33652 RVA: 0x000BBF54 File Offset: 0x000BA154
		public new static int IsTypeOf(string type)
		{
			return vtkBoxWidget2.vtkBoxWidget2_IsTypeOf_09(type);
		}

		// Token: 0x06008375 RID: 33653
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxWidget2_MoveFacesEnabledOff_10(HandleRef pThis);

		/// <summary>
		/// Control the behavior of the widget (i.e., how it processes
		/// events). Translation, rotation, scaling and face movement can all be enabled and
		/// disabled. Scaling refers to scaling of the whole widget at once,
		/// (default is through right mouse button) while face movement refers to
		/// scaling of the widget one face (axis) at a time (default through grabbing
		/// one of the representation spherical handles).
		/// </summary>
		// Token: 0x06008376 RID: 33654 RVA: 0x000BBF6E File Offset: 0x000BA16E
		public virtual void MoveFacesEnabledOff()
		{
			vtkBoxWidget2.vtkBoxWidget2_MoveFacesEnabledOff_10(base.GetCppThis());
		}

		// Token: 0x06008377 RID: 33655
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxWidget2_MoveFacesEnabledOn_11(HandleRef pThis);

		/// <summary>
		/// Control the behavior of the widget (i.e., how it processes
		/// events). Translation, rotation, scaling and face movement can all be enabled and
		/// disabled. Scaling refers to scaling of the whole widget at once,
		/// (default is through right mouse button) while face movement refers to
		/// scaling of the widget one face (axis) at a time (default through grabbing
		/// one of the representation spherical handles).
		/// </summary>
		// Token: 0x06008378 RID: 33656 RVA: 0x000BBF7D File Offset: 0x000BA17D
		public virtual void MoveFacesEnabledOn()
		{
			vtkBoxWidget2.vtkBoxWidget2_MoveFacesEnabledOn_11(base.GetCppThis());
		}

		// Token: 0x06008379 RID: 33657
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBoxWidget2_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard class methods for type information and printing.
		/// </summary>
		// Token: 0x0600837A RID: 33658 RVA: 0x000BBF8C File Offset: 0x000BA18C
		public new vtkBoxWidget2 NewInstance()
		{
			vtkBoxWidget2 result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBoxWidget2.vtkBoxWidget2_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBoxWidget2)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600837B RID: 33659
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxWidget2_RotationEnabledOff_14(HandleRef pThis);

		/// <summary>
		/// Control the behavior of the widget (i.e., how it processes
		/// events). Translation, rotation, scaling and face movement can all be enabled and
		/// disabled. Scaling refers to scaling of the whole widget at once,
		/// (default is through right mouse button) while face movement refers to
		/// scaling of the widget one face (axis) at a time (default through grabbing
		/// one of the representation spherical handles).
		/// </summary>
		// Token: 0x0600837C RID: 33660 RVA: 0x000BBFE6 File Offset: 0x000BA1E6
		public virtual void RotationEnabledOff()
		{
			vtkBoxWidget2.vtkBoxWidget2_RotationEnabledOff_14(base.GetCppThis());
		}

		// Token: 0x0600837D RID: 33661
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxWidget2_RotationEnabledOn_15(HandleRef pThis);

		/// <summary>
		/// Control the behavior of the widget (i.e., how it processes
		/// events). Translation, rotation, scaling and face movement can all be enabled and
		/// disabled. Scaling refers to scaling of the whole widget at once,
		/// (default is through right mouse button) while face movement refers to
		/// scaling of the widget one face (axis) at a time (default through grabbing
		/// one of the representation spherical handles).
		/// </summary>
		// Token: 0x0600837E RID: 33662 RVA: 0x000BBFF5 File Offset: 0x000BA1F5
		public virtual void RotationEnabledOn()
		{
			vtkBoxWidget2.vtkBoxWidget2_RotationEnabledOn_15(base.GetCppThis());
		}

		// Token: 0x0600837F RID: 33663
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBoxWidget2_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard class methods for type information and printing.
		/// </summary>
		// Token: 0x06008380 RID: 33664 RVA: 0x000BC004 File Offset: 0x000BA204
		public new static vtkBoxWidget2 SafeDownCast(vtkObjectBase o)
		{
			vtkBoxWidget2 vtkBoxWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBoxWidget2.vtkBoxWidget2_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBoxWidget = (vtkBoxWidget2)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBoxWidget.Register(null);
				}
			}
			return vtkBoxWidget;
		}

		// Token: 0x06008381 RID: 33665
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxWidget2_ScalingEnabledOff_17(HandleRef pThis);

		/// <summary>
		/// Control the behavior of the widget (i.e., how it processes
		/// events). Translation, rotation, scaling and face movement can all be enabled and
		/// disabled. Scaling refers to scaling of the whole widget at once,
		/// (default is through right mouse button) while face movement refers to
		/// scaling of the widget one face (axis) at a time (default through grabbing
		/// one of the representation spherical handles).
		/// </summary>
		// Token: 0x06008382 RID: 33666 RVA: 0x000BC083 File Offset: 0x000BA283
		public virtual void ScalingEnabledOff()
		{
			vtkBoxWidget2.vtkBoxWidget2_ScalingEnabledOff_17(base.GetCppThis());
		}

		// Token: 0x06008383 RID: 33667
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxWidget2_ScalingEnabledOn_18(HandleRef pThis);

		/// <summary>
		/// Control the behavior of the widget (i.e., how it processes
		/// events). Translation, rotation, scaling and face movement can all be enabled and
		/// disabled. Scaling refers to scaling of the whole widget at once,
		/// (default is through right mouse button) while face movement refers to
		/// scaling of the widget one face (axis) at a time (default through grabbing
		/// one of the representation spherical handles).
		/// </summary>
		// Token: 0x06008384 RID: 33668 RVA: 0x000BC092 File Offset: 0x000BA292
		public virtual void ScalingEnabledOn()
		{
			vtkBoxWidget2.vtkBoxWidget2_ScalingEnabledOn_18(base.GetCppThis());
		}

		// Token: 0x06008385 RID: 33669
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxWidget2_SetEnabled_19(HandleRef pThis, int enabling);

		/// <summary>
		/// Override superclasses' SetEnabled() method because the line
		/// widget must enable its internal handle widgets.
		/// </summary>
		// Token: 0x06008386 RID: 33670 RVA: 0x000BC0A1 File Offset: 0x000BA2A1
		public override void SetEnabled(int enabling)
		{
			vtkBoxWidget2.vtkBoxWidget2_SetEnabled_19(base.GetCppThis(), enabling);
		}

		// Token: 0x06008387 RID: 33671
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxWidget2_SetMoveFacesEnabled_20(HandleRef pThis, int _arg);

		/// <summary>
		/// Control the behavior of the widget (i.e., how it processes
		/// events). Translation, rotation, scaling and face movement can all be enabled and
		/// disabled. Scaling refers to scaling of the whole widget at once,
		/// (default is through right mouse button) while face movement refers to
		/// scaling of the widget one face (axis) at a time (default through grabbing
		/// one of the representation spherical handles).
		/// </summary>
		// Token: 0x06008388 RID: 33672 RVA: 0x000BC0B1 File Offset: 0x000BA2B1
		public virtual void SetMoveFacesEnabled(int _arg)
		{
			vtkBoxWidget2.vtkBoxWidget2_SetMoveFacesEnabled_20(base.GetCppThis(), _arg);
		}

		// Token: 0x06008389 RID: 33673
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxWidget2_SetRepresentation_21(HandleRef pThis, HandleRef r);

		/// <summary>
		/// Specify an instance of vtkWidgetRepresentation used to represent this
		/// widget in the scene. Note that the representation is a subclass of vtkProp
		/// so it can be added to the renderer independent of the widget.
		/// </summary>
		// Token: 0x0600838A RID: 33674 RVA: 0x000BC0C4 File Offset: 0x000BA2C4
		public void SetRepresentation(vtkBoxRepresentation r)
		{
			vtkBoxWidget2.vtkBoxWidget2_SetRepresentation_21(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}

		// Token: 0x0600838B RID: 33675
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxWidget2_SetRotationEnabled_22(HandleRef pThis, int _arg);

		/// <summary>
		/// Control the behavior of the widget (i.e., how it processes
		/// events). Translation, rotation, scaling and face movement can all be enabled and
		/// disabled. Scaling refers to scaling of the whole widget at once,
		/// (default is through right mouse button) while face movement refers to
		/// scaling of the widget one face (axis) at a time (default through grabbing
		/// one of the representation spherical handles).
		/// </summary>
		// Token: 0x0600838C RID: 33676 RVA: 0x000BC0F3 File Offset: 0x000BA2F3
		public virtual void SetRotationEnabled(int _arg)
		{
			vtkBoxWidget2.vtkBoxWidget2_SetRotationEnabled_22(base.GetCppThis(), _arg);
		}

		// Token: 0x0600838D RID: 33677
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxWidget2_SetScalingEnabled_23(HandleRef pThis, int _arg);

		/// <summary>
		/// Control the behavior of the widget (i.e., how it processes
		/// events). Translation, rotation, scaling and face movement can all be enabled and
		/// disabled. Scaling refers to scaling of the whole widget at once,
		/// (default is through right mouse button) while face movement refers to
		/// scaling of the widget one face (axis) at a time (default through grabbing
		/// one of the representation spherical handles).
		/// </summary>
		// Token: 0x0600838E RID: 33678 RVA: 0x000BC103 File Offset: 0x000BA303
		public virtual void SetScalingEnabled(int _arg)
		{
			vtkBoxWidget2.vtkBoxWidget2_SetScalingEnabled_23(base.GetCppThis(), _arg);
		}

		// Token: 0x0600838F RID: 33679
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxWidget2_SetTranslationEnabled_24(HandleRef pThis, int _arg);

		/// <summary>
		/// Control the behavior of the widget (i.e., how it processes
		/// events). Translation, rotation, scaling and face movement can all be enabled and
		/// disabled. Scaling refers to scaling of the whole widget at once,
		/// (default is through right mouse button) while face movement refers to
		/// scaling of the widget one face (axis) at a time (default through grabbing
		/// one of the representation spherical handles).
		/// </summary>
		// Token: 0x06008390 RID: 33680 RVA: 0x000BC113 File Offset: 0x000BA313
		public virtual void SetTranslationEnabled(int _arg)
		{
			vtkBoxWidget2.vtkBoxWidget2_SetTranslationEnabled_24(base.GetCppThis(), _arg);
		}

		// Token: 0x06008391 RID: 33681
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxWidget2_TranslationEnabledOff_25(HandleRef pThis);

		/// <summary>
		/// Control the behavior of the widget (i.e., how it processes
		/// events). Translation, rotation, scaling and face movement can all be enabled and
		/// disabled. Scaling refers to scaling of the whole widget at once,
		/// (default is through right mouse button) while face movement refers to
		/// scaling of the widget one face (axis) at a time (default through grabbing
		/// one of the representation spherical handles).
		/// </summary>
		// Token: 0x06008392 RID: 33682 RVA: 0x000BC123 File Offset: 0x000BA323
		public virtual void TranslationEnabledOff()
		{
			vtkBoxWidget2.vtkBoxWidget2_TranslationEnabledOff_25(base.GetCppThis());
		}

		// Token: 0x06008393 RID: 33683
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxWidget2_TranslationEnabledOn_26(HandleRef pThis);

		/// <summary>
		/// Control the behavior of the widget (i.e., how it processes
		/// events). Translation, rotation, scaling and face movement can all be enabled and
		/// disabled. Scaling refers to scaling of the whole widget at once,
		/// (default is through right mouse button) while face movement refers to
		/// scaling of the widget one face (axis) at a time (default through grabbing
		/// one of the representation spherical handles).
		/// </summary>
		// Token: 0x06008394 RID: 33684 RVA: 0x000BC132 File Offset: 0x000BA332
		public virtual void TranslationEnabledOn()
		{
			vtkBoxWidget2.vtkBoxWidget2_TranslationEnabledOn_26(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B25 RID: 2853
		public new const string MRFullTypeName = "Kitware.VTK.vtkBoxWidget2";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B26 RID: 2854
		public new static readonly string MRClassNameKey = "class vtkBoxWidget2";
	}
}
