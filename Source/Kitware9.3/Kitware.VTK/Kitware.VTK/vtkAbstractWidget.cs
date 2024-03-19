using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAbstractWidget
	/// </summary>
	/// <remarks>
	///    define the API for widget / widget representation
	///
	/// The vtkAbstractWidget defines an API and implements methods common to all
	/// widgets using the interaction/representation design. In this design, the
	/// term interaction means that part of the widget that performs event
	/// handling, while the representation corresponds to a vtkProp (or the
	/// subclass vtkWidgetRepresentation) used to represent the
	/// widget. vtkAbstractWidget also implements some methods common to all
	/// subclasses.
	///
	/// Note that vtkAbstractWidget provides access to the
	/// vtkWidgetEventTranslator.  This class is responsible for translating VTK
	/// events (defined in vtkCommand.h) into widget events (defined in
	/// vtkWidgetEvent.h). This class can be manipulated so that different VTK
	/// events can be mapped into widget events, thereby allowing the modification
	/// of event bindings. Each subclass of vtkAbstractWidget defines the events
	/// to which it responds.
	///
	/// @warning
	/// Note that the pair ( vtkAbstractWidget / vtkWidgetRepresentation ) is an
	/// implementation of the second generation VTK Widgets design. In the first
	/// generation design, widgets were implemented in a single monolithic
	/// class. This design was problematic because in client-server application
	/// it was difficult to manage widgets properly. Also, new "representations"
	/// or look-and-feel, for a widget required a whole new class, with a lot of
	/// redundant code. The separation of the widget event handling and
	/// representation enables users and developers to create new appearances for
	/// the widget. It also facilitates parallel processing, where the client
	/// application handles events, and remote representations of the widget are
	/// slaves to the client (and do not handle events).
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkWidgetRepresentation vtkWidgetEventTranslator vtkWidgetCallbackMapper
	/// </seealso>
	// Token: 0x020000C3 RID: 195
	public abstract class vtkAbstractWidget : vtkInteractorObserver
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06002A75 RID: 10869 RVA: 0x0003EBDB File Offset: 0x0003CDDB
		static vtkAbstractWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAbstractWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAbstractWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06002A76 RID: 10870 RVA: 0x0003EC03 File Offset: 0x0003CE03
		public vtkAbstractWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06002A77 RID: 10871 RVA: 0x0003EC11 File Offset: 0x0003CE11
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06002A78 RID: 10872
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Create the default widget representation if one is not set. The
		/// representation defines the geometry of the widget (i.e., how it appears)
		/// as well as providing special methods for manipulting the state and
		/// appearance of the widget.
		/// </summary>
		// Token: 0x06002A79 RID: 10873 RVA: 0x0003EC1C File Offset: 0x0003CE1C
		public virtual void CreateDefaultRepresentation()
		{
			vtkAbstractWidget.vtkAbstractWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06002A7A RID: 10874
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractWidget_GetEventTranslator_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the event translator. Careful manipulation of this class enables
		/// the user to override the default event bindings.
		/// </summary>
		// Token: 0x06002A7B RID: 10875 RVA: 0x0003EC2C File Offset: 0x0003CE2C
		public vtkWidgetEventTranslator GetEventTranslator()
		{
			vtkWidgetEventTranslator vtkWidgetEventTranslator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractWidget.vtkAbstractWidget_GetEventTranslator_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWidgetEventTranslator = (vtkWidgetEventTranslator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWidgetEventTranslator.Register(null);
				}
			}
			return vtkWidgetEventTranslator;
		}

		// Token: 0x06002A7C RID: 10876
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractWidget_GetManagesCursor_03(HandleRef pThis);

		/// <summary>
		/// Turn on or off the management of the cursor. Cursor management is
		/// typically disabled for subclasses when composite widgets are
		/// created. For example, vtkHandleWidgets are often used to create
		/// composite widgets, and the parent widget takes over the cursor
		/// management.
		/// </summary>
		// Token: 0x06002A7D RID: 10877 RVA: 0x0003EC9C File Offset: 0x0003CE9C
		public virtual int GetManagesCursor()
		{
			return vtkAbstractWidget.vtkAbstractWidget_GetManagesCursor_03(base.GetCppThis());
		}

		// Token: 0x06002A7E RID: 10878
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractWidget_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard macros implementing standard VTK methods.
		/// </summary>
		// Token: 0x06002A7F RID: 10879 RVA: 0x0003ECBC File Offset: 0x0003CEBC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAbstractWidget.vtkAbstractWidget_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06002A80 RID: 10880
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractWidget_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard macros implementing standard VTK methods.
		/// </summary>
		// Token: 0x06002A81 RID: 10881 RVA: 0x0003ECDC File Offset: 0x0003CEDC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAbstractWidget.vtkAbstractWidget_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06002A82 RID: 10882
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractWidget_GetParent_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specifying a parent to this widget is used when creating composite
		/// widgets. It is an internal method not meant to be used by the public.
		/// When a widget has a parent, it defers the rendering to the parent. It
		/// may also defer managing the cursor (see ManagesCursor ivar).
		/// </summary>
		// Token: 0x06002A83 RID: 10883 RVA: 0x0003ECF8 File Offset: 0x0003CEF8
		public virtual vtkAbstractWidget GetParent()
		{
			vtkAbstractWidget vtkAbstractWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractWidget.vtkAbstractWidget_GetParent_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractWidget = (vtkAbstractWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractWidget.Register(null);
				}
			}
			return vtkAbstractWidget;
		}

		// Token: 0x06002A84 RID: 10884
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractWidget_GetProcessEvents_07(HandleRef pThis);

		/// <summary>
		/// Methods to change whether the widget responds to interaction.
		/// Set this to Off to disable interaction. On by default.
		/// Subclasses must override SetProcessEvents() to make sure
		/// that they pass on the flag to all component widgets.
		/// </summary>
		// Token: 0x06002A85 RID: 10885 RVA: 0x0003ED68 File Offset: 0x0003CF68
		public virtual int GetProcessEvents()
		{
			return vtkAbstractWidget.vtkAbstractWidget_GetProcessEvents_07(base.GetCppThis());
		}

		// Token: 0x06002A86 RID: 10886
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractWidget_GetProcessEventsMaxValue_08(HandleRef pThis);

		/// <summary>
		/// Methods to change whether the widget responds to interaction.
		/// Set this to Off to disable interaction. On by default.
		/// Subclasses must override SetProcessEvents() to make sure
		/// that they pass on the flag to all component widgets.
		/// </summary>
		// Token: 0x06002A87 RID: 10887 RVA: 0x0003ED88 File Offset: 0x0003CF88
		public virtual int GetProcessEventsMaxValue()
		{
			return vtkAbstractWidget.vtkAbstractWidget_GetProcessEventsMaxValue_08(base.GetCppThis());
		}

		// Token: 0x06002A88 RID: 10888
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractWidget_GetProcessEventsMinValue_09(HandleRef pThis);

		/// <summary>
		/// Methods to change whether the widget responds to interaction.
		/// Set this to Off to disable interaction. On by default.
		/// Subclasses must override SetProcessEvents() to make sure
		/// that they pass on the flag to all component widgets.
		/// </summary>
		// Token: 0x06002A89 RID: 10889 RVA: 0x0003EDA8 File Offset: 0x0003CFA8
		public virtual int GetProcessEventsMinValue()
		{
			return vtkAbstractWidget.vtkAbstractWidget_GetProcessEventsMinValue_09(base.GetCppThis());
		}

		// Token: 0x06002A8A RID: 10890
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractWidget_GetRepresentation_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return an instance of vtkWidgetRepresentation used to represent this
		/// widget in the scene. Note that the representation is a subclass of
		/// vtkProp (typically a subclass of vtkWidgetRepresentation) so it can be
		/// added to the renderer independent of the widget.
		/// </summary>
		// Token: 0x06002A8B RID: 10891 RVA: 0x0003EDC8 File Offset: 0x0003CFC8
		public vtkWidgetRepresentation GetRepresentation()
		{
			vtkWidgetRepresentation vtkWidgetRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractWidget.vtkAbstractWidget_GetRepresentation_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06002A8C RID: 10892
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractWidget_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard macros implementing standard VTK methods.
		/// </summary>
		// Token: 0x06002A8D RID: 10893 RVA: 0x0003EE38 File Offset: 0x0003D038
		public override int IsA(string type)
		{
			return vtkAbstractWidget.vtkAbstractWidget_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x06002A8E RID: 10894
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractWidget_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard macros implementing standard VTK methods.
		/// </summary>
		// Token: 0x06002A8F RID: 10895 RVA: 0x0003EE58 File Offset: 0x0003D058
		public new static int IsTypeOf(string type)
		{
			return vtkAbstractWidget.vtkAbstractWidget_IsTypeOf_12(type);
		}

		// Token: 0x06002A90 RID: 10896
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractWidget_ManagesCursorOff_13(HandleRef pThis);

		/// <summary>
		/// Turn on or off the management of the cursor. Cursor management is
		/// typically disabled for subclasses when composite widgets are
		/// created. For example, vtkHandleWidgets are often used to create
		/// composite widgets, and the parent widget takes over the cursor
		/// management.
		/// </summary>
		// Token: 0x06002A91 RID: 10897 RVA: 0x0003EE72 File Offset: 0x0003D072
		public virtual void ManagesCursorOff()
		{
			vtkAbstractWidget.vtkAbstractWidget_ManagesCursorOff_13(base.GetCppThis());
		}

		// Token: 0x06002A92 RID: 10898
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractWidget_ManagesCursorOn_14(HandleRef pThis);

		/// <summary>
		/// Turn on or off the management of the cursor. Cursor management is
		/// typically disabled for subclasses when composite widgets are
		/// created. For example, vtkHandleWidgets are often used to create
		/// composite widgets, and the parent widget takes over the cursor
		/// management.
		/// </summary>
		// Token: 0x06002A93 RID: 10899 RVA: 0x0003EE81 File Offset: 0x0003D081
		public virtual void ManagesCursorOn()
		{
			vtkAbstractWidget.vtkAbstractWidget_ManagesCursorOn_14(base.GetCppThis());
		}

		// Token: 0x06002A94 RID: 10900
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractWidget_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard macros implementing standard VTK methods.
		/// </summary>
		// Token: 0x06002A95 RID: 10901 RVA: 0x0003EE90 File Offset: 0x0003D090
		public new vtkAbstractWidget NewInstance()
		{
			vtkAbstractWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractWidget.vtkAbstractWidget_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06002A96 RID: 10902
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractWidget_ProcessEventsOff_16(HandleRef pThis);

		/// <summary>
		/// Methods to change whether the widget responds to interaction.
		/// Set this to Off to disable interaction. On by default.
		/// Subclasses must override SetProcessEvents() to make sure
		/// that they pass on the flag to all component widgets.
		/// </summary>
		// Token: 0x06002A97 RID: 10903 RVA: 0x0003EEEA File Offset: 0x0003D0EA
		public virtual void ProcessEventsOff()
		{
			vtkAbstractWidget.vtkAbstractWidget_ProcessEventsOff_16(base.GetCppThis());
		}

		// Token: 0x06002A98 RID: 10904
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractWidget_ProcessEventsOn_17(HandleRef pThis);

		/// <summary>
		/// Methods to change whether the widget responds to interaction.
		/// Set this to Off to disable interaction. On by default.
		/// Subclasses must override SetProcessEvents() to make sure
		/// that they pass on the flag to all component widgets.
		/// </summary>
		// Token: 0x06002A99 RID: 10905 RVA: 0x0003EEF9 File Offset: 0x0003D0F9
		public virtual void ProcessEventsOn()
		{
			vtkAbstractWidget.vtkAbstractWidget_ProcessEventsOn_17(base.GetCppThis());
		}

		// Token: 0x06002A9A RID: 10906
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractWidget_Render_18(HandleRef pThis);

		/// <summary>
		/// This method is called by subclasses when a render method is to be
		/// invoked on the vtkRenderWindowInteractor. This method should be called
		/// (instead of vtkRenderWindow::Render() because it has built into it
		/// optimizations for minimizing renders and/or speeding renders.
		/// </summary>
		// Token: 0x06002A9B RID: 10907 RVA: 0x0003EF08 File Offset: 0x0003D108
		public void Render()
		{
			vtkAbstractWidget.vtkAbstractWidget_Render_18(base.GetCppThis());
		}

		// Token: 0x06002A9C RID: 10908
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractWidget_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard macros implementing standard VTK methods.
		/// </summary>
		// Token: 0x06002A9D RID: 10909 RVA: 0x0003EF18 File Offset: 0x0003D118
		public new static vtkAbstractWidget SafeDownCast(vtkObjectBase o)
		{
			vtkAbstractWidget vtkAbstractWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractWidget.vtkAbstractWidget_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractWidget = (vtkAbstractWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractWidget.Register(null);
				}
			}
			return vtkAbstractWidget;
		}

		// Token: 0x06002A9E RID: 10910
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractWidget_SetEnabled_20(HandleRef pThis, int arg0);

		/// <summary>
		/// Methods for activating this widget. Note that the widget representation
		/// must be specified or the widget will not appear.
		/// ProcessEvents (On by default) must be On for Enabled widget to respond
		/// to interaction. If ProcessEvents is Off, enabling/disabling a widget
		/// merely affects the visibility of the representation.
		/// </summary>
		// Token: 0x06002A9F RID: 10911 RVA: 0x0003EF97 File Offset: 0x0003D197
		public override void SetEnabled(int arg0)
		{
			vtkAbstractWidget.vtkAbstractWidget_SetEnabled_20(base.GetCppThis(), arg0);
		}

		// Token: 0x06002AA0 RID: 10912
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractWidget_SetManagesCursor_21(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on or off the management of the cursor. Cursor management is
		/// typically disabled for subclasses when composite widgets are
		/// created. For example, vtkHandleWidgets are often used to create
		/// composite widgets, and the parent widget takes over the cursor
		/// management.
		/// </summary>
		// Token: 0x06002AA1 RID: 10913 RVA: 0x0003EFA7 File Offset: 0x0003D1A7
		public virtual void SetManagesCursor(int _arg)
		{
			vtkAbstractWidget.vtkAbstractWidget_SetManagesCursor_21(base.GetCppThis(), _arg);
		}

		// Token: 0x06002AA2 RID: 10914
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractWidget_SetParent_22(HandleRef pThis, HandleRef parent);

		/// <summary>
		/// Specifying a parent to this widget is used when creating composite
		/// widgets. It is an internal method not meant to be used by the public.
		/// When a widget has a parent, it defers the rendering to the parent. It
		/// may also defer managing the cursor (see ManagesCursor ivar).
		/// </summary>
		// Token: 0x06002AA3 RID: 10915 RVA: 0x0003EFB8 File Offset: 0x0003D1B8
		public void SetParent(vtkAbstractWidget parent)
		{
			vtkAbstractWidget.vtkAbstractWidget_SetParent_22(base.GetCppThis(), (parent == null) ? default(HandleRef) : parent.GetCppThis());
		}

		// Token: 0x06002AA4 RID: 10916
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractWidget_SetPriority_23(HandleRef pThis, float arg0);

		/// <summary>
		/// Override the superclass method. This will automatically change the
		/// priority of the widget. Unlike the superclass documentation, no
		/// methods such as SetInteractor to null and reset it etc. are necessary
		/// </summary>
		// Token: 0x06002AA5 RID: 10917 RVA: 0x0003EFE7 File Offset: 0x0003D1E7
		public override void SetPriority(float arg0)
		{
			vtkAbstractWidget.vtkAbstractWidget_SetPriority_23(base.GetCppThis(), arg0);
		}

		// Token: 0x06002AA6 RID: 10918
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractWidget_SetProcessEvents_24(HandleRef pThis, int _arg);

		/// <summary>
		/// Methods to change whether the widget responds to interaction.
		/// Set this to Off to disable interaction. On by default.
		/// Subclasses must override SetProcessEvents() to make sure
		/// that they pass on the flag to all component widgets.
		/// </summary>
		// Token: 0x06002AA7 RID: 10919 RVA: 0x0003EFF7 File Offset: 0x0003D1F7
		public virtual void SetProcessEvents(int _arg)
		{
			vtkAbstractWidget.vtkAbstractWidget_SetProcessEvents_24(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000576 RID: 1398
		public new const string MRFullTypeName = "Kitware.VTK.vtkAbstractWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000577 RID: 1399
		public new static readonly string MRClassNameKey = "class vtkAbstractWidget";
	}
}
