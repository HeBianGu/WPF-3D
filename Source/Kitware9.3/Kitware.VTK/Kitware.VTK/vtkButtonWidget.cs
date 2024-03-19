using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkButtonWidget
	/// </summary>
	/// <remarks>
	///    activate an n-state button
	///
	/// The vtkButtonWidget is used to interface with an n-state button. That is
	/// each selection moves to the next button state (e.g., moves from "on" to
	/// "off"). The widget uses modulo list traversal to transition through one or
	/// more states. (A single state is simply a "selection" event; traversal
	/// through the list can be in the forward or backward direction.)
	///
	/// Depending on the nature of the representation the appearance of the button
	/// can change dramatically, the specifics of appearance changes are a
	/// function of the associated vtkButtonRepresentation (or subclass).
	///
	/// @par Event Bindings:
	/// By default, the widget responds to the following VTK events (i.e., it
	/// watches the vtkRenderWindowInteractor for these events):
	/// &lt;pre&gt;
	///   LeftButtonPressEvent - select button
	///   LeftButtonReleaseEvent - end the button selection process
	/// &lt;/pre&gt;
	///
	/// @par Event Bindings:
	/// Note that the event bindings described above can be changed using this
	/// class's vtkWidgetEventTranslator. This class translates VTK events
	/// into the vtkButtonWidget's widget events:
	/// &lt;pre&gt;
	///   vtkWidgetEvent::Select -- some part of the widget has been selected
	///   vtkWidgetEvent::EndSelect -- the selection process has completed
	/// &lt;/pre&gt;
	///
	/// @par Event Bindings:
	/// In turn, when these widget events are processed, the vtkButtonWidget
	/// invokes the following VTK events on itself (which observers can listen for):
	/// &lt;pre&gt;
	///   vtkCommand::StateChangedEvent (on vtkWidgetEvent::EndSelect)
	/// &lt;/pre&gt;
	///
	/// </remarks>
	// Token: 0x020002DE RID: 734
	public class vtkButtonWidget : vtkAbstractWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06008426 RID: 33830 RVA: 0x000BCC23 File Offset: 0x000BAE23
		static vtkButtonWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkButtonWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkButtonWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06008427 RID: 33831 RVA: 0x000BCC4B File Offset: 0x000BAE4B
		public vtkButtonWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06008428 RID: 33832
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkButtonWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x06008429 RID: 33833 RVA: 0x000BCC5C File Offset: 0x000BAE5C
		public new static vtkButtonWidget New()
		{
			vtkButtonWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkButtonWidget.vtkButtonWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkButtonWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x0600842A RID: 33834 RVA: 0x000BCCB0 File Offset: 0x000BAEB0
		public vtkButtonWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkButtonWidget.vtkButtonWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600842B RID: 33835 RVA: 0x000BCCF4 File Offset: 0x000BAEF4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600842C RID: 33836
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkButtonWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Create the default widget representation if one is not set.
		/// </summary>
		// Token: 0x0600842D RID: 33837 RVA: 0x000BCCFF File Offset: 0x000BAEFF
		public override void CreateDefaultRepresentation()
		{
			vtkButtonWidget.vtkButtonWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		// Token: 0x0600842E RID: 33838
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkButtonWidget_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x0600842F RID: 33839 RVA: 0x000BCD10 File Offset: 0x000BAF10
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkButtonWidget.vtkButtonWidget_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06008430 RID: 33840
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkButtonWidget_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x06008431 RID: 33841 RVA: 0x000BCD30 File Offset: 0x000BAF30
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkButtonWidget.vtkButtonWidget_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06008432 RID: 33842
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkButtonWidget_GetSliderRepresentation_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the representation as a vtkButtonRepresentation.
		/// </summary>
		// Token: 0x06008433 RID: 33843 RVA: 0x000BCD4C File Offset: 0x000BAF4C
		public vtkButtonRepresentation GetSliderRepresentation()
		{
			vtkButtonRepresentation vtkButtonRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkButtonWidget.vtkButtonWidget_GetSliderRepresentation_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkButtonRepresentation = (vtkButtonRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkButtonRepresentation.Register(null);
				}
			}
			return vtkButtonRepresentation;
		}

		// Token: 0x06008434 RID: 33844
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkButtonWidget_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x06008435 RID: 33845 RVA: 0x000BCDBC File Offset: 0x000BAFBC
		public override int IsA(string type)
		{
			return vtkButtonWidget.vtkButtonWidget_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06008436 RID: 33846
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkButtonWidget_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x06008437 RID: 33847 RVA: 0x000BCDDC File Offset: 0x000BAFDC
		public new static int IsTypeOf(string type)
		{
			return vtkButtonWidget.vtkButtonWidget_IsTypeOf_06(type);
		}

		// Token: 0x06008438 RID: 33848
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkButtonWidget_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x06008439 RID: 33849 RVA: 0x000BCDF8 File Offset: 0x000BAFF8
		public new vtkButtonWidget NewInstance()
		{
			vtkButtonWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkButtonWidget.vtkButtonWidget_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkButtonWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600843A RID: 33850
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkButtonWidget_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x0600843B RID: 33851 RVA: 0x000BCE54 File Offset: 0x000BB054
		public new static vtkButtonWidget SafeDownCast(vtkObjectBase o)
		{
			vtkButtonWidget vtkButtonWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkButtonWidget.vtkButtonWidget_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkButtonWidget = (vtkButtonWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkButtonWidget.Register(null);
				}
			}
			return vtkButtonWidget;
		}

		// Token: 0x0600843C RID: 33852
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkButtonWidget_SetEnabled_10(HandleRef pThis, int arg0);

		/// <summary>
		/// The method for activating and deactivating this widget. This method
		/// must be overridden because it is a composite widget and does more than
		/// its superclasses' vtkAbstractWidget::SetEnabled() method. The
		/// method finds and sets the active viewport on the internal balloon
		/// representation.
		/// </summary>
		// Token: 0x0600843D RID: 33853 RVA: 0x000BCED3 File Offset: 0x000BB0D3
		public override void SetEnabled(int arg0)
		{
			vtkButtonWidget.vtkButtonWidget_SetEnabled_10(base.GetCppThis(), arg0);
		}

		// Token: 0x0600843E RID: 33854
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkButtonWidget_SetRepresentation_11(HandleRef pThis, HandleRef r);

		/// <summary>
		/// Specify an instance of vtkWidgetRepresentation used to represent this
		/// widget in the scene. Note that the representation is a subclass of vtkProp
		/// so it can be added to the renderer independent of the widget.
		/// </summary>
		// Token: 0x0600843F RID: 33855 RVA: 0x000BCEE4 File Offset: 0x000BB0E4
		public void SetRepresentation(vtkButtonRepresentation r)
		{
			vtkButtonWidget.vtkButtonWidget_SetRepresentation_11(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B32 RID: 2866
		public new const string MRFullTypeName = "Kitware.VTK.vtkButtonWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B33 RID: 2867
		public new static readonly string MRClassNameKey = "class vtkButtonWidget";
	}
}
