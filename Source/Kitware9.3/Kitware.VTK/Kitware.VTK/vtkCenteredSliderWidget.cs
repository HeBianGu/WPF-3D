using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCenteredSliderWidget
	/// </summary>
	/// <remarks>
	///    set a value by manipulating a slider
	///
	/// The vtkCenteredSliderWidget is used to adjust a scalar value in an application.
	/// This class measures deviations form the center point on the slider.
	/// Moving the slider
	/// modifies the value of the widget, which can be used to set parameters on
	/// other objects. Note that the actual appearance of the widget depends on
	/// the specific representation for the widget.
	///
	/// To use this widget, set the widget representation. The representation is
	/// assumed to consist of a tube, two end caps, and a slider (the details may
	/// vary depending on the particulars of the representation). Then in the
	/// representation you will typically set minimum and maximum value, as well
	/// as the current value. The position of the slider must also be set, as well
	/// as various properties.
	///
	/// Note that the value should be obtain from the widget, not from the
	/// representation. Also note that Minimum and Maximum values are in terms of
	/// value per second. The value you get from this widget's GetValue method is
	/// multiplied by time.
	///
	/// @par Event Bindings:
	/// By default, the widget responds to the following VTK events (i.e., it
	/// watches the vtkRenderWindowInteractor for these events):
	/// &lt;pre&gt;
	/// If the slider bead is selected:
	///   LeftButtonPressEvent - select slider (if on slider)
	///   LeftButtonReleaseEvent - release slider (if selected)
	///   MouseMoveEvent - move slider
	/// If the end caps or slider tube are selected:
	///   LeftButtonPressEvent - move (or animate) to cap or point on tube;
	/// &lt;/pre&gt;
	///
	/// @par Event Bindings:
	/// Note that the event bindings described above can be changed using this
	/// class's vtkWidgetEventTranslator. This class translates VTK events
	/// into the vtkCenteredSliderWidget's widget events:
	/// &lt;pre&gt;
	///   vtkWidgetEvent::Select -- some part of the widget has been selected
	///   vtkWidgetEvent::EndSelect -- the selection process has completed
	///   vtkWidgetEvent::Move -- a request for slider motion has been invoked
	/// &lt;/pre&gt;
	///
	/// @par Event Bindings:
	/// In turn, when these widget events are processed, the vtkCenteredSliderWidget
	/// invokes the following VTK events on itself (which observers can listen for):
	/// &lt;pre&gt;
	///   vtkCommand::StartInteractionEvent (on vtkWidgetEvent::Select)
	///   vtkCommand::EndInteractionEvent (on vtkWidgetEvent::EndSelect)
	///   vtkCommand::InteractionEvent (on vtkWidgetEvent::Move)
	/// &lt;/pre&gt;
	///
	/// </remarks>
	// Token: 0x020002F3 RID: 755
	public class vtkCenteredSliderWidget : vtkAbstractWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06008778 RID: 34680 RVA: 0x000C168B File Offset: 0x000BF88B
		static vtkCenteredSliderWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCenteredSliderWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCenteredSliderWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06008779 RID: 34681 RVA: 0x000C16B3 File Offset: 0x000BF8B3
		public vtkCenteredSliderWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600877A RID: 34682
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCenteredSliderWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x0600877B RID: 34683 RVA: 0x000C16C4 File Offset: 0x000BF8C4
		public new static vtkCenteredSliderWidget New()
		{
			vtkCenteredSliderWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCenteredSliderWidget.vtkCenteredSliderWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCenteredSliderWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x0600877C RID: 34684 RVA: 0x000C1718 File Offset: 0x000BF918
		public vtkCenteredSliderWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCenteredSliderWidget.vtkCenteredSliderWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600877D RID: 34685 RVA: 0x000C175C File Offset: 0x000BF95C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600877E RID: 34686
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCenteredSliderWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Create the default widget representation if one is not set.
		/// </summary>
		// Token: 0x0600877F RID: 34687 RVA: 0x000C1767 File Offset: 0x000BF967
		public override void CreateDefaultRepresentation()
		{
			vtkCenteredSliderWidget.vtkCenteredSliderWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06008780 RID: 34688
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCenteredSliderWidget_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x06008781 RID: 34689 RVA: 0x000C1778 File Offset: 0x000BF978
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCenteredSliderWidget.vtkCenteredSliderWidget_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06008782 RID: 34690
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCenteredSliderWidget_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x06008783 RID: 34691 RVA: 0x000C1798 File Offset: 0x000BF998
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCenteredSliderWidget.vtkCenteredSliderWidget_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06008784 RID: 34692
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCenteredSliderWidget_GetSliderRepresentation_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the representation as a vtkSliderRepresentation.
		/// </summary>
		// Token: 0x06008785 RID: 34693 RVA: 0x000C17B4 File Offset: 0x000BF9B4
		public vtkSliderRepresentation GetSliderRepresentation()
		{
			vtkSliderRepresentation vtkSliderRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCenteredSliderWidget.vtkCenteredSliderWidget_GetSliderRepresentation_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSliderRepresentation = (vtkSliderRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSliderRepresentation.Register(null);
				}
			}
			return vtkSliderRepresentation;
		}

		// Token: 0x06008786 RID: 34694
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCenteredSliderWidget_GetValue_05(HandleRef pThis);

		/// <summary>
		/// Get the value fo this widget.
		/// </summary>
		// Token: 0x06008787 RID: 34695 RVA: 0x000C1824 File Offset: 0x000BFA24
		public double GetValue()
		{
			return vtkCenteredSliderWidget.vtkCenteredSliderWidget_GetValue_05(base.GetCppThis());
		}

		// Token: 0x06008788 RID: 34696
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCenteredSliderWidget_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x06008789 RID: 34697 RVA: 0x000C1844 File Offset: 0x000BFA44
		public override int IsA(string type)
		{
			return vtkCenteredSliderWidget.vtkCenteredSliderWidget_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0600878A RID: 34698
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCenteredSliderWidget_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x0600878B RID: 34699 RVA: 0x000C1864 File Offset: 0x000BFA64
		public new static int IsTypeOf(string type)
		{
			return vtkCenteredSliderWidget.vtkCenteredSliderWidget_IsTypeOf_07(type);
		}

		// Token: 0x0600878C RID: 34700
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCenteredSliderWidget_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x0600878D RID: 34701 RVA: 0x000C1880 File Offset: 0x000BFA80
		public new vtkCenteredSliderWidget NewInstance()
		{
			vtkCenteredSliderWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCenteredSliderWidget.vtkCenteredSliderWidget_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCenteredSliderWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600878E RID: 34702
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCenteredSliderWidget_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x0600878F RID: 34703 RVA: 0x000C18DC File Offset: 0x000BFADC
		public new static vtkCenteredSliderWidget SafeDownCast(vtkObjectBase o)
		{
			vtkCenteredSliderWidget vtkCenteredSliderWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCenteredSliderWidget.vtkCenteredSliderWidget_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCenteredSliderWidget = (vtkCenteredSliderWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCenteredSliderWidget.Register(null);
				}
			}
			return vtkCenteredSliderWidget;
		}

		// Token: 0x06008790 RID: 34704
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCenteredSliderWidget_SetRepresentation_11(HandleRef pThis, HandleRef r);

		/// <summary>
		/// Specify an instance of vtkWidgetRepresentation used to represent this
		/// widget in the scene. Note that the representation is a subclass of vtkProp
		/// so it can be added to the renderer independent of the widget.
		/// </summary>
		// Token: 0x06008791 RID: 34705 RVA: 0x000C195C File Offset: 0x000BFB5C
		public void SetRepresentation(vtkSliderRepresentation r)
		{
			vtkCenteredSliderWidget.vtkCenteredSliderWidget_SetRepresentation_11(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B6D RID: 2925
		public new const string MRFullTypeName = "Kitware.VTK.vtkCenteredSliderWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B6E RID: 2926
		public new static readonly string MRClassNameKey = "class vtkCenteredSliderWidget";
	}
}
