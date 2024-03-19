using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkHandleWidget
	/// </summary>
	/// <remarks>
	///    a general widget for moving handles
	///
	/// The vtkHandleWidget is used to position a handle.  A handle is a widget
	/// with a position (in display and world space). Various appearances are
	/// available depending on its associated representation. The widget provides
	/// methods for translation, including constrained translation along
	/// coordinate axes. To use this widget, create and associate a representation
	/// with the widget.
	///
	/// @par Event Bindings:
	/// By default, the widget responds to the following VTK events (i.e., it
	/// watches the vtkRenderWindowInteractor for these events):
	/// &lt;pre&gt;
	///   LeftButtonPressEvent - select focal point of widget
	///   LeftButtonReleaseEvent - end selection
	///   MiddleButtonPressEvent - translate widget
	///   MiddleButtonReleaseEvent - end translation
	///   RightButtonPressEvent - scale widget
	///   RightButtonReleaseEvent - end scaling
	///   MouseMoveEvent - interactive movement across widget
	/// &lt;/pre&gt;
	///
	/// @par Event Bindings:
	/// Note that the event bindings described above can be changed using this
	/// class's vtkWidgetEventTranslator. This class translates VTK events
	/// into the vtkHandleWidget's widget events:
	/// &lt;pre&gt;
	///   vtkWidgetEvent::Select -- focal point is being selected
	///   vtkWidgetEvent::EndSelect -- the selection process has completed
	///   vtkWidgetEvent::Translate -- translate the widget
	///   vtkWidgetEvent::EndTranslate -- end widget translation
	///   vtkWidgetEvent::Scale -- scale the widget
	///   vtkWidgetEvent::EndScale -- end scaling the widget
	///   vtkWidgetEvent::Move -- a request for widget motion
	/// &lt;/pre&gt;
	///
	/// @par Event Bindings:
	/// In turn, when these widget events are processed, the vtkHandleWidget
	/// invokes the following VTK events on itself (which observers can listen for):
	/// &lt;pre&gt;
	///   vtkCommand::StartInteractionEvent (on vtkWidgetEvent::Select)
	///   vtkCommand::EndInteractionEvent (on vtkWidgetEvent::EndSelect)
	///   vtkCommand::InteractionEvent (on vtkWidgetEvent::Move)
	/// &lt;/pre&gt;
	///
	/// </remarks>
	// Token: 0x0200031E RID: 798
	public class vtkHandleWidget : vtkAbstractWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06008F04 RID: 36612 RVA: 0x000CBE05 File Offset: 0x000CA005
		static vtkHandleWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHandleWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHandleWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06008F05 RID: 36613 RVA: 0x000CBE2D File Offset: 0x000CA02D
		public vtkHandleWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06008F06 RID: 36614
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHandleWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06008F07 RID: 36615 RVA: 0x000CBE3C File Offset: 0x000CA03C
		public new static vtkHandleWidget New()
		{
			vtkHandleWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHandleWidget.vtkHandleWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHandleWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06008F08 RID: 36616 RVA: 0x000CBE90 File Offset: 0x000CA090
		public vtkHandleWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkHandleWidget.vtkHandleWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06008F09 RID: 36617 RVA: 0x000CBED4 File Offset: 0x000CA0D4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06008F0A RID: 36618
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleWidget_AllowHandleResizeOff_01(HandleRef pThis);

		/// <summary>
		/// Allow resizing of handles ? By default the right mouse button scales
		/// the handle size.
		/// </summary>
		// Token: 0x06008F0B RID: 36619 RVA: 0x000CBEDF File Offset: 0x000CA0DF
		public virtual void AllowHandleResizeOff()
		{
			vtkHandleWidget.vtkHandleWidget_AllowHandleResizeOff_01(base.GetCppThis());
		}

		// Token: 0x06008F0C RID: 36620
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleWidget_AllowHandleResizeOn_02(HandleRef pThis);

		/// <summary>
		/// Allow resizing of handles ? By default the right mouse button scales
		/// the handle size.
		/// </summary>
		// Token: 0x06008F0D RID: 36621 RVA: 0x000CBEEE File Offset: 0x000CA0EE
		public virtual void AllowHandleResizeOn()
		{
			vtkHandleWidget.vtkHandleWidget_AllowHandleResizeOn_02(base.GetCppThis());
		}

		// Token: 0x06008F0E RID: 36622
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleWidget_CreateDefaultRepresentation_03(HandleRef pThis);

		/// <summary>
		/// Create the default widget representation if one is not set. By default
		/// an instance of vtkPointHandleRepresentation3D is created.
		/// </summary>
		// Token: 0x06008F0F RID: 36623 RVA: 0x000CBEFD File Offset: 0x000CA0FD
		public override void CreateDefaultRepresentation()
		{
			vtkHandleWidget.vtkHandleWidget_CreateDefaultRepresentation_03(base.GetCppThis());
		}

		// Token: 0x06008F10 RID: 36624
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleWidget_EnableAxisConstraintOff_04(HandleRef pThis);

		/// <summary>
		/// Enable / disable axis constrained motion of the handles. By default the
		/// widget responds to the shift modifier to constrain the handle along the
		/// axis closest aligned with the motion vector.
		/// </summary>
		// Token: 0x06008F11 RID: 36625 RVA: 0x000CBF0C File Offset: 0x000CA10C
		public virtual void EnableAxisConstraintOff()
		{
			vtkHandleWidget.vtkHandleWidget_EnableAxisConstraintOff_04(base.GetCppThis());
		}

		// Token: 0x06008F12 RID: 36626
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleWidget_EnableAxisConstraintOn_05(HandleRef pThis);

		/// <summary>
		/// Enable / disable axis constrained motion of the handles. By default the
		/// widget responds to the shift modifier to constrain the handle along the
		/// axis closest aligned with the motion vector.
		/// </summary>
		// Token: 0x06008F13 RID: 36627 RVA: 0x000CBF1B File Offset: 0x000CA11B
		public virtual void EnableAxisConstraintOn()
		{
			vtkHandleWidget.vtkHandleWidget_EnableAxisConstraintOn_05(base.GetCppThis());
		}

		// Token: 0x06008F14 RID: 36628
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleWidget_EnableTranslationOff_06(HandleRef pThis);

		/// <summary>
		/// Enable moving of handles. By default, the handle can be moved.
		/// </summary>
		// Token: 0x06008F15 RID: 36629 RVA: 0x000CBF2A File Offset: 0x000CA12A
		public virtual void EnableTranslationOff()
		{
			vtkHandleWidget.vtkHandleWidget_EnableTranslationOff_06(base.GetCppThis());
		}

		// Token: 0x06008F16 RID: 36630
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleWidget_EnableTranslationOn_07(HandleRef pThis);

		/// <summary>
		/// Enable moving of handles. By default, the handle can be moved.
		/// </summary>
		// Token: 0x06008F17 RID: 36631 RVA: 0x000CBF39 File Offset: 0x000CA139
		public virtual void EnableTranslationOn()
		{
			vtkHandleWidget.vtkHandleWidget_EnableTranslationOn_07(base.GetCppThis());
		}

		// Token: 0x06008F18 RID: 36632
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHandleWidget_GetAllowHandleResize_08(HandleRef pThis);

		/// <summary>
		/// Allow resizing of handles ? By default the right mouse button scales
		/// the handle size.
		/// </summary>
		// Token: 0x06008F19 RID: 36633 RVA: 0x000CBF48 File Offset: 0x000CA148
		public virtual int GetAllowHandleResize()
		{
			return vtkHandleWidget.vtkHandleWidget_GetAllowHandleResize_08(base.GetCppThis());
		}

		// Token: 0x06008F1A RID: 36634
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHandleWidget_GetEnableAxisConstraint_09(HandleRef pThis);

		/// <summary>
		/// Enable / disable axis constrained motion of the handles. By default the
		/// widget responds to the shift modifier to constrain the handle along the
		/// axis closest aligned with the motion vector.
		/// </summary>
		// Token: 0x06008F1B RID: 36635 RVA: 0x000CBF68 File Offset: 0x000CA168
		public virtual int GetEnableAxisConstraint()
		{
			return vtkHandleWidget.vtkHandleWidget_GetEnableAxisConstraint_09(base.GetCppThis());
		}

		// Token: 0x06008F1C RID: 36636
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHandleWidget_GetEnableTranslation_10(HandleRef pThis);

		/// <summary>
		/// Enable moving of handles. By default, the handle can be moved.
		/// </summary>
		// Token: 0x06008F1D RID: 36637 RVA: 0x000CBF88 File Offset: 0x000CA188
		public virtual int GetEnableTranslation()
		{
			return vtkHandleWidget.vtkHandleWidget_GetEnableTranslation_10(base.GetCppThis());
		}

		// Token: 0x06008F1E RID: 36638
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHandleWidget_GetHandleRepresentation_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the representation as a vtkHandleRepresentation.
		/// </summary>
		// Token: 0x06008F1F RID: 36639 RVA: 0x000CBFA8 File Offset: 0x000CA1A8
		public vtkHandleRepresentation GetHandleRepresentation()
		{
			vtkHandleRepresentation vtkHandleRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHandleWidget.vtkHandleWidget_GetHandleRepresentation_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHandleRepresentation = (vtkHandleRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHandleRepresentation.Register(null);
				}
			}
			return vtkHandleRepresentation;
		}

		// Token: 0x06008F20 RID: 36640
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHandleWidget_GetNumberOfGenerationsFromBase_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class macros.
		/// </summary>
		// Token: 0x06008F21 RID: 36641 RVA: 0x000CC018 File Offset: 0x000CA218
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkHandleWidget.vtkHandleWidget_GetNumberOfGenerationsFromBase_12(base.GetCppThis(), type);
		}

		// Token: 0x06008F22 RID: 36642
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHandleWidget_GetNumberOfGenerationsFromBaseType_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class macros.
		/// </summary>
		// Token: 0x06008F23 RID: 36643 RVA: 0x000CC038 File Offset: 0x000CA238
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkHandleWidget.vtkHandleWidget_GetNumberOfGenerationsFromBaseType_13(type);
		}

		// Token: 0x06008F24 RID: 36644
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHandleWidget_GetShowInactive_14(HandleRef pThis);

		/// <summary>
		/// Allow the widget to be visible as an inactive representation when disabled.
		/// By default, this is false i.e. the representation is not visible when the
		/// widget is disabled.
		/// </summary>
		// Token: 0x06008F25 RID: 36645 RVA: 0x000CC054 File Offset: 0x000CA254
		public virtual int GetShowInactive()
		{
			return vtkHandleWidget.vtkHandleWidget_GetShowInactive_14(base.GetCppThis());
		}

		// Token: 0x06008F26 RID: 36646
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHandleWidget_GetWidgetState_15(HandleRef pThis);

		/// <summary>
		/// Get the widget state.
		/// </summary>
		// Token: 0x06008F27 RID: 36647 RVA: 0x000CC074 File Offset: 0x000CA274
		public virtual int GetWidgetState()
		{
			return vtkHandleWidget.vtkHandleWidget_GetWidgetState_15(base.GetCppThis());
		}

		// Token: 0x06008F28 RID: 36648
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHandleWidget_IsA_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class macros.
		/// </summary>
		// Token: 0x06008F29 RID: 36649 RVA: 0x000CC094 File Offset: 0x000CA294
		public override int IsA(string type)
		{
			return vtkHandleWidget.vtkHandleWidget_IsA_16(base.GetCppThis(), type);
		}

		// Token: 0x06008F2A RID: 36650
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHandleWidget_IsTypeOf_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class macros.
		/// </summary>
		// Token: 0x06008F2B RID: 36651 RVA: 0x000CC0B4 File Offset: 0x000CA2B4
		public new static int IsTypeOf(string type)
		{
			return vtkHandleWidget.vtkHandleWidget_IsTypeOf_17(type);
		}

		// Token: 0x06008F2C RID: 36652
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHandleWidget_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK class macros.
		/// </summary>
		// Token: 0x06008F2D RID: 36653 RVA: 0x000CC0D0 File Offset: 0x000CA2D0
		public new vtkHandleWidget NewInstance()
		{
			vtkHandleWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHandleWidget.vtkHandleWidget_NewInstance_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHandleWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06008F2E RID: 36654
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHandleWidget_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK class macros.
		/// </summary>
		// Token: 0x06008F2F RID: 36655 RVA: 0x000CC12C File Offset: 0x000CA32C
		public new static vtkHandleWidget SafeDownCast(vtkObjectBase o)
		{
			vtkHandleWidget vtkHandleWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHandleWidget.vtkHandleWidget_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHandleWidget = (vtkHandleWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHandleWidget.Register(null);
				}
			}
			return vtkHandleWidget;
		}

		// Token: 0x06008F30 RID: 36656
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleWidget_SetAllowHandleResize_21(HandleRef pThis, int _arg);

		/// <summary>
		/// Allow resizing of handles ? By default the right mouse button scales
		/// the handle size.
		/// </summary>
		// Token: 0x06008F31 RID: 36657 RVA: 0x000CC1AB File Offset: 0x000CA3AB
		public virtual void SetAllowHandleResize(int _arg)
		{
			vtkHandleWidget.vtkHandleWidget_SetAllowHandleResize_21(base.GetCppThis(), _arg);
		}

		// Token: 0x06008F32 RID: 36658
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleWidget_SetEnableAxisConstraint_22(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable / disable axis constrained motion of the handles. By default the
		/// widget responds to the shift modifier to constrain the handle along the
		/// axis closest aligned with the motion vector.
		/// </summary>
		// Token: 0x06008F33 RID: 36659 RVA: 0x000CC1BB File Offset: 0x000CA3BB
		public virtual void SetEnableAxisConstraint(int _arg)
		{
			vtkHandleWidget.vtkHandleWidget_SetEnableAxisConstraint_22(base.GetCppThis(), _arg);
		}

		// Token: 0x06008F34 RID: 36660
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleWidget_SetEnableTranslation_23(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable moving of handles. By default, the handle can be moved.
		/// </summary>
		// Token: 0x06008F35 RID: 36661 RVA: 0x000CC1CB File Offset: 0x000CA3CB
		public virtual void SetEnableTranslation(int _arg)
		{
			vtkHandleWidget.vtkHandleWidget_SetEnableTranslation_23(base.GetCppThis(), _arg);
		}

		// Token: 0x06008F36 RID: 36662
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleWidget_SetEnabled_24(HandleRef pThis, int enabling);

		/// <summary>
		/// Enable/disable widget.
		/// Custom override for the SetEnabled method to allow for the inactive state.
		/// </summary>
		// Token: 0x06008F37 RID: 36663 RVA: 0x000CC1DB File Offset: 0x000CA3DB
		public override void SetEnabled(int enabling)
		{
			vtkHandleWidget.vtkHandleWidget_SetEnabled_24(base.GetCppThis(), enabling);
		}

		// Token: 0x06008F38 RID: 36664
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleWidget_SetRepresentation_25(HandleRef pThis, HandleRef r);

		/// <summary>
		/// Specify an instance of vtkWidgetRepresentation used to represent this
		/// widget in the scene. Note that the representation is a subclass of vtkProp
		/// so it can be added to the renderer independent of the widget.
		/// </summary>
		// Token: 0x06008F39 RID: 36665 RVA: 0x000CC1EC File Offset: 0x000CA3EC
		public void SetRepresentation(vtkHandleRepresentation r)
		{
			vtkHandleWidget.vtkHandleWidget_SetRepresentation_25(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}

		// Token: 0x06008F3A RID: 36666
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleWidget_SetShowInactive_26(HandleRef pThis, int _arg);

		/// <summary>
		/// Allow the widget to be visible as an inactive representation when disabled.
		/// By default, this is false i.e. the representation is not visible when the
		/// widget is disabled.
		/// </summary>
		// Token: 0x06008F3B RID: 36667 RVA: 0x000CC21B File Offset: 0x000CA41B
		public virtual void SetShowInactive(int _arg)
		{
			vtkHandleWidget.vtkHandleWidget_SetShowInactive_26(base.GetCppThis(), _arg);
		}

		// Token: 0x06008F3C RID: 36668
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleWidget_ShowInactiveOff_27(HandleRef pThis);

		/// <summary>
		/// Allow the widget to be visible as an inactive representation when disabled.
		/// By default, this is false i.e. the representation is not visible when the
		/// widget is disabled.
		/// </summary>
		// Token: 0x06008F3D RID: 36669 RVA: 0x000CC22B File Offset: 0x000CA42B
		public virtual void ShowInactiveOff()
		{
			vtkHandleWidget.vtkHandleWidget_ShowInactiveOff_27(base.GetCppThis());
		}

		// Token: 0x06008F3E RID: 36670
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleWidget_ShowInactiveOn_28(HandleRef pThis);

		/// <summary>
		/// Allow the widget to be visible as an inactive representation when disabled.
		/// By default, this is false i.e. the representation is not visible when the
		/// widget is disabled.
		/// </summary>
		// Token: 0x06008F3F RID: 36671 RVA: 0x000CC23A File Offset: 0x000CA43A
		public virtual void ShowInactiveOn()
		{
			vtkHandleWidget.vtkHandleWidget_ShowInactiveOn_28(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000BF6 RID: 3062
		public new const string MRFullTypeName = "Kitware.VTK.vtkHandleWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000BF7 RID: 3063
		public new static readonly string MRClassNameKey = "class vtkHandleWidget";

		/// <summary>
		/// Allow the widget to be visible as an inactive representation when disabled.
		/// By default, this is false i.e. the representation is not visible when the
		/// widget is disabled.
		/// </summary>
		// Token: 0x0200031F RID: 799
		public enum WidgetStateType
		{
			/// <summary>enum member</summary>
			// Token: 0x04000BF9 RID: 3065
			Active = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000BFA RID: 3066
			Inactive,
			/// <summary>enum member</summary>
			// Token: 0x04000BFB RID: 3067
			Start = 0
		}
	}
}
