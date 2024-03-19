using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkHoverWidget
	/// </summary>
	/// <remarks>
	///    invoke a vtkTimerEvent when hovering
	///
	/// The vtkHoverWidget is used to invoke an event when hovering in a render window.
	/// Hovering occurs when mouse motion (in the render window) does not occur
	/// for a specified amount of time (i.e., TimerDuration). This class can be used
	/// as is (by observing TimerEvents) or for class derivation for those classes
	/// wishing to do more with the hover event.
	///
	/// To use this widget, specify an instance of vtkHoverWidget and specify the
	/// time (in milliseconds) defining the hover period. Unlike most widgets,
	/// this widget does not require a representation (although subclasses like
	/// vtkBalloonWidget do require a representation).
	///
	/// @par Event Bindings:
	/// By default, the widget observes the following VTK events (i.e., it
	/// watches the vtkRenderWindowInteractor for these events):
	/// &lt;pre&gt;
	///   MouseMoveEvent - manages a timer used to determine whether the mouse
	///                    is hovering.
	///   TimerEvent - when the time between events (e.g., mouse move), then a
	///                timer event is invoked.
	///   KeyPressEvent - when the "Enter" key is pressed after the balloon appears,
	///                   a callback is activated (e.g., WidgetActivateEvent).
	/// &lt;/pre&gt;
	///
	/// @par Event Bindings:
	/// Note that the event bindings described above can be changed using this
	/// class's vtkWidgetEventTranslator. This class translates VTK events
	/// into the vtkHoverWidget's widget events:
	/// &lt;pre&gt;
	///   vtkWidgetEvent::Move -- start (or reset) the timer
	///   vtkWidgetEvent::TimedOut -- when enough time is elapsed between defined
	///                               VTK events the hover event is invoked.
	///   vtkWidgetEvent::SelectAction -- activate any callbacks associated
	///                                   with the balloon.
	/// &lt;/pre&gt;
	///
	/// @par Event Bindings:
	/// This widget invokes the following VTK events on itself when the widget
	/// determines that it is hovering. Note that observers of this widget can
	/// listen for these events and take appropriate action.
	/// &lt;pre&gt;
	///   vtkCommand::TimerEvent (when hovering is determined to occur)
	///   vtkCommand::EndInteractionEvent (after a hover has occurred and the
	///                                    mouse begins moving again).
	///   vtkCommand::WidgetActivateEvent (when the balloon is selected with a
	///                                    keypress).
	/// &lt;/pre&gt;
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkAbstractWidget
	/// </seealso>
	// Token: 0x020002C3 RID: 707
	public class vtkHoverWidget : vtkAbstractWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06007F81 RID: 32641 RVA: 0x000B6E37 File Offset: 0x000B5037
		static vtkHoverWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHoverWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHoverWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06007F82 RID: 32642 RVA: 0x000B6E5F File Offset: 0x000B505F
		public vtkHoverWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06007F83 RID: 32643
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHoverWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06007F84 RID: 32644 RVA: 0x000B6E70 File Offset: 0x000B5070
		public new static vtkHoverWidget New()
		{
			vtkHoverWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHoverWidget.vtkHoverWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHoverWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06007F85 RID: 32645 RVA: 0x000B6EC4 File Offset: 0x000B50C4
		public vtkHoverWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkHoverWidget.vtkHoverWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06007F86 RID: 32646 RVA: 0x000B6F08 File Offset: 0x000B5108
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06007F87 RID: 32647
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHoverWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		/// <summary>
		/// A default representation, of which there is none, is created. Note
		/// that the superclasses vtkAbstractWidget::GetRepresentation()
		/// method returns nullptr.
		/// </summary>
		// Token: 0x06007F88 RID: 32648 RVA: 0x000B6F13 File Offset: 0x000B5113
		public override void CreateDefaultRepresentation()
		{
			vtkHoverWidget.vtkHoverWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06007F89 RID: 32649
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHoverWidget_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x06007F8A RID: 32650 RVA: 0x000B6F24 File Offset: 0x000B5124
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkHoverWidget.vtkHoverWidget_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06007F8B RID: 32651
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHoverWidget_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x06007F8C RID: 32652 RVA: 0x000B6F44 File Offset: 0x000B5144
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkHoverWidget.vtkHoverWidget_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06007F8D RID: 32653
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHoverWidget_GetTimerDuration_04(HandleRef pThis);

		/// <summary>
		/// Specify the hovering interval (in milliseconds). If after moving the
		/// mouse the pointer stays over a vtkProp for this duration, then a
		/// vtkTimerEvent::TimerEvent is invoked.
		/// </summary>
		// Token: 0x06007F8E RID: 32654 RVA: 0x000B6F60 File Offset: 0x000B5160
		public virtual int GetTimerDuration()
		{
			return vtkHoverWidget.vtkHoverWidget_GetTimerDuration_04(base.GetCppThis());
		}

		// Token: 0x06007F8F RID: 32655
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHoverWidget_GetTimerDurationMaxValue_05(HandleRef pThis);

		/// <summary>
		/// Specify the hovering interval (in milliseconds). If after moving the
		/// mouse the pointer stays over a vtkProp for this duration, then a
		/// vtkTimerEvent::TimerEvent is invoked.
		/// </summary>
		// Token: 0x06007F90 RID: 32656 RVA: 0x000B6F80 File Offset: 0x000B5180
		public virtual int GetTimerDurationMaxValue()
		{
			return vtkHoverWidget.vtkHoverWidget_GetTimerDurationMaxValue_05(base.GetCppThis());
		}

		// Token: 0x06007F91 RID: 32657
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHoverWidget_GetTimerDurationMinValue_06(HandleRef pThis);

		/// <summary>
		/// Specify the hovering interval (in milliseconds). If after moving the
		/// mouse the pointer stays over a vtkProp for this duration, then a
		/// vtkTimerEvent::TimerEvent is invoked.
		/// </summary>
		// Token: 0x06007F92 RID: 32658 RVA: 0x000B6FA0 File Offset: 0x000B51A0
		public virtual int GetTimerDurationMinValue()
		{
			return vtkHoverWidget.vtkHoverWidget_GetTimerDurationMinValue_06(base.GetCppThis());
		}

		// Token: 0x06007F93 RID: 32659
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHoverWidget_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x06007F94 RID: 32660 RVA: 0x000B6FC0 File Offset: 0x000B51C0
		public override int IsA(string type)
		{
			return vtkHoverWidget.vtkHoverWidget_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06007F95 RID: 32661
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHoverWidget_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x06007F96 RID: 32662 RVA: 0x000B6FE0 File Offset: 0x000B51E0
		public new static int IsTypeOf(string type)
		{
			return vtkHoverWidget.vtkHoverWidget_IsTypeOf_08(type);
		}

		// Token: 0x06007F97 RID: 32663
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHoverWidget_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x06007F98 RID: 32664 RVA: 0x000B6FFC File Offset: 0x000B51FC
		public new vtkHoverWidget NewInstance()
		{
			vtkHoverWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHoverWidget.vtkHoverWidget_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHoverWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06007F99 RID: 32665
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHoverWidget_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x06007F9A RID: 32666 RVA: 0x000B7058 File Offset: 0x000B5258
		public new static vtkHoverWidget SafeDownCast(vtkObjectBase o)
		{
			vtkHoverWidget vtkHoverWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHoverWidget.vtkHoverWidget_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHoverWidget = (vtkHoverWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHoverWidget.Register(null);
				}
			}
			return vtkHoverWidget;
		}

		// Token: 0x06007F9B RID: 32667
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHoverWidget_SetEnabled_12(HandleRef pThis, int arg0);

		/// <summary>
		/// The method for activating and deactivating this widget. This method
		/// must be overridden because it performs special timer-related operations.
		/// </summary>
		// Token: 0x06007F9C RID: 32668 RVA: 0x000B70D7 File Offset: 0x000B52D7
		public override void SetEnabled(int arg0)
		{
			vtkHoverWidget.vtkHoverWidget_SetEnabled_12(base.GetCppThis(), arg0);
		}

		// Token: 0x06007F9D RID: 32669
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHoverWidget_SetTimerDuration_13(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the hovering interval (in milliseconds). If after moving the
		/// mouse the pointer stays over a vtkProp for this duration, then a
		/// vtkTimerEvent::TimerEvent is invoked.
		/// </summary>
		// Token: 0x06007F9E RID: 32670 RVA: 0x000B70E7 File Offset: 0x000B52E7
		public virtual void SetTimerDuration(int _arg)
		{
			vtkHoverWidget.vtkHoverWidget_SetTimerDuration_13(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000AC8 RID: 2760
		public new const string MRFullTypeName = "Kitware.VTK.vtkHoverWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000AC9 RID: 2761
		public new static readonly string MRClassNameKey = "class vtkHoverWidget";
	}
}
