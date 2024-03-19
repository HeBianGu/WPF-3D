using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBorderWidget
	/// </summary>
	/// <remarks>
	///    place a border around a 2D rectangular region
	///
	/// This class is a superclass for 2D widgets that may require a rectangular
	/// border. Besides drawing a border, the widget provides methods for resizing
	/// and moving the rectangular region (and associated border). The widget
	/// provides methods and internal data members so that subclasses can take
	/// advantage of this widgets capabilities, requiring only that the subclass
	/// defines a "representation", i.e., some combination of props or actors
	/// that can be managed in the 2D rectangular region.
	///
	/// The class defines basic positioning functionality, including the ability
	/// to size the widget with locked x/y proportions. The area within the border
	/// may be made "selectable" as well, meaning that a selection event interior
	/// to the widget invokes a virtual SelectRegion() method, which can be used
	/// to pick objects or otherwise manipulate data interior to the widget.
	///
	/// @par Event Bindings:
	/// By default, the widget responds to the following VTK events (i.e., it
	/// watches the vtkRenderWindowInteractor for these events):
	/// &lt;pre&gt;
	/// On the boundary of the widget:
	///   LeftButtonPressEvent - select boundary
	///   LeftButtonReleaseEvent - deselect boundary
	///   MouseMoveEvent - move/resize widget depending on which portion of the
	///                    boundary was selected.
	/// On the interior of the widget:
	///   LeftButtonPressEvent - invoke SelectButton() callback (if the ivar
	///                          Selectable is on)
	/// Anywhere on the widget:
	///   MiddleButtonPressEvent - move the widget
	/// &lt;/pre&gt;
	///
	/// @par Event Bindings:
	/// Note that the event bindings described above can be changed using this
	/// class's vtkWidgetEventTranslator. This class translates VTK events
	/// into the vtkBorderWidget's widget events:
	/// &lt;pre&gt;
	///   vtkWidgetEvent::Select -- some part of the widget has been selected
	///   vtkWidgetEvent::EndSelect -- the selection process has completed
	///   vtkWidgetEvent::Translate -- the widget is to be translated
	///   vtkWidgetEvent::Move -- a request for slider motion has been invoked
	/// &lt;/pre&gt;
	///
	/// @par Event Bindings:
	/// In turn, when these widget events are processed, this widget invokes the
	/// following VTK events on itself (which observers can listen for):
	/// &lt;pre&gt;
	///   vtkCommand::StartInteractionEvent (on vtkWidgetEvent::Select)
	///   vtkCommand::EndInteractionEvent (on vtkWidgetEvent::EndSelect)
	///   vtkCommand::InteractionEvent (on vtkWidgetEvent::Move)
	/// &lt;/pre&gt;
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkInteractorObserver vtkCameraInterpolator
	/// </seealso>
	// Token: 0x020002D2 RID: 722
	public class vtkBorderWidget : vtkAbstractWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060081D3 RID: 33235 RVA: 0x000B9C3D File Offset: 0x000B7E3D
		static vtkBorderWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBorderWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBorderWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060081D4 RID: 33236 RVA: 0x000B9C65 File Offset: 0x000B7E65
		public vtkBorderWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060081D5 RID: 33237
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBorderWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Method to instantiate class.
		/// </summary>
		// Token: 0x060081D6 RID: 33238 RVA: 0x000B9C74 File Offset: 0x000B7E74
		public new static vtkBorderWidget New()
		{
			vtkBorderWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBorderWidget.vtkBorderWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBorderWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Method to instantiate class.
		/// </summary>
		// Token: 0x060081D7 RID: 33239 RVA: 0x000B9CC8 File Offset: 0x000B7EC8
		public vtkBorderWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBorderWidget.vtkBorderWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060081D8 RID: 33240 RVA: 0x000B9D0C File Offset: 0x000B7F0C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060081D9 RID: 33241
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Create the default widget representation if one is not set.
		/// </summary>
		// Token: 0x060081DA RID: 33242 RVA: 0x000B9D17 File Offset: 0x000B7F17
		public override void CreateDefaultRepresentation()
		{
			vtkBorderWidget.vtkBorderWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		// Token: 0x060081DB RID: 33243
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBorderWidget_GetBorderRepresentation_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the representation as a vtkBorderRepresentation.
		/// </summary>
		// Token: 0x060081DC RID: 33244 RVA: 0x000B9D28 File Offset: 0x000B7F28
		public vtkBorderRepresentation GetBorderRepresentation()
		{
			vtkBorderRepresentation vtkBorderRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBorderWidget.vtkBorderWidget_GetBorderRepresentation_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBorderRepresentation = (vtkBorderRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBorderRepresentation.Register(null);
				}
			}
			return vtkBorderRepresentation;
		}

		// Token: 0x060081DD RID: 33245
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBorderWidget_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for class.
		/// </summary>
		// Token: 0x060081DE RID: 33246 RVA: 0x000B9D98 File Offset: 0x000B7F98
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBorderWidget.vtkBorderWidget_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x060081DF RID: 33247
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBorderWidget_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for class.
		/// </summary>
		// Token: 0x060081E0 RID: 33248 RVA: 0x000B9DB8 File Offset: 0x000B7FB8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBorderWidget.vtkBorderWidget_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x060081E1 RID: 33249
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBorderWidget_GetProcessEvents_05(HandleRef pThis);

		/// <summary>
		/// Reimplement ProcessEvents to disable it when using relative location with
		/// windowLocation. When using exact location this override has no effect.
		/// </summary>
		// Token: 0x060081E2 RID: 33250 RVA: 0x000B9DD4 File Offset: 0x000B7FD4
		public override int GetProcessEvents()
		{
			return vtkBorderWidget.vtkBorderWidget_GetProcessEvents_05(base.GetCppThis());
		}

		// Token: 0x060081E3 RID: 33251
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBorderWidget_GetResizable_06(HandleRef pThis);

		/// <summary>
		/// Indicate whether the boundary of the widget can be resized.
		/// If not, the cursor will not change to "resize" type when mouse
		/// over the boundary.
		/// </summary>
		// Token: 0x060081E4 RID: 33252 RVA: 0x000B9DF4 File Offset: 0x000B7FF4
		public virtual int GetResizable()
		{
			return vtkBorderWidget.vtkBorderWidget_GetResizable_06(base.GetCppThis());
		}

		// Token: 0x060081E5 RID: 33253
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBorderWidget_GetSelectable_07(HandleRef pThis);

		/// <summary>
		/// Indicate whether the interior region of the widget can be selected or
		/// not. If not, then events (such as left mouse down) allow the user to
		/// "move" the widget, and no selection is possible. Otherwise the
		/// SelectRegion() method is invoked.
		/// </summary>
		// Token: 0x060081E6 RID: 33254 RVA: 0x000B9E14 File Offset: 0x000B8014
		public virtual int GetSelectable()
		{
			return vtkBorderWidget.vtkBorderWidget_GetSelectable_07(base.GetCppThis());
		}

		// Token: 0x060081E7 RID: 33255
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBorderWidget_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for class.
		/// </summary>
		// Token: 0x060081E8 RID: 33256 RVA: 0x000B9E34 File Offset: 0x000B8034
		public override int IsA(string type)
		{
			return vtkBorderWidget.vtkBorderWidget_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x060081E9 RID: 33257
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBorderWidget_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for class.
		/// </summary>
		// Token: 0x060081EA RID: 33258 RVA: 0x000B9E54 File Offset: 0x000B8054
		public new static int IsTypeOf(string type)
		{
			return vtkBorderWidget.vtkBorderWidget_IsTypeOf_09(type);
		}

		// Token: 0x060081EB RID: 33259
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBorderWidget_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for class.
		/// </summary>
		// Token: 0x060081EC RID: 33260 RVA: 0x000B9E70 File Offset: 0x000B8070
		public new vtkBorderWidget NewInstance()
		{
			vtkBorderWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBorderWidget.vtkBorderWidget_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBorderWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060081ED RID: 33261
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderWidget_ResizableOff_12(HandleRef pThis);

		/// <summary>
		/// Indicate whether the boundary of the widget can be resized.
		/// If not, the cursor will not change to "resize" type when mouse
		/// over the boundary.
		/// </summary>
		// Token: 0x060081EE RID: 33262 RVA: 0x000B9ECA File Offset: 0x000B80CA
		public virtual void ResizableOff()
		{
			vtkBorderWidget.vtkBorderWidget_ResizableOff_12(base.GetCppThis());
		}

		// Token: 0x060081EF RID: 33263
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderWidget_ResizableOn_13(HandleRef pThis);

		/// <summary>
		/// Indicate whether the boundary of the widget can be resized.
		/// If not, the cursor will not change to "resize" type when mouse
		/// over the boundary.
		/// </summary>
		// Token: 0x060081F0 RID: 33264 RVA: 0x000B9ED9 File Offset: 0x000B80D9
		public virtual void ResizableOn()
		{
			vtkBorderWidget.vtkBorderWidget_ResizableOn_13(base.GetCppThis());
		}

		// Token: 0x060081F1 RID: 33265
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBorderWidget_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for class.
		/// </summary>
		// Token: 0x060081F2 RID: 33266 RVA: 0x000B9EE8 File Offset: 0x000B80E8
		public new static vtkBorderWidget SafeDownCast(vtkObjectBase o)
		{
			vtkBorderWidget vtkBorderWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBorderWidget.vtkBorderWidget_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBorderWidget = (vtkBorderWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBorderWidget.Register(null);
				}
			}
			return vtkBorderWidget;
		}

		// Token: 0x060081F3 RID: 33267
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderWidget_SelectableOff_15(HandleRef pThis);

		/// <summary>
		/// Indicate whether the interior region of the widget can be selected or
		/// not. If not, then events (such as left mouse down) allow the user to
		/// "move" the widget, and no selection is possible. Otherwise the
		/// SelectRegion() method is invoked.
		/// </summary>
		// Token: 0x060081F4 RID: 33268 RVA: 0x000B9F67 File Offset: 0x000B8167
		public virtual void SelectableOff()
		{
			vtkBorderWidget.vtkBorderWidget_SelectableOff_15(base.GetCppThis());
		}

		// Token: 0x060081F5 RID: 33269
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderWidget_SelectableOn_16(HandleRef pThis);

		/// <summary>
		/// Indicate whether the interior region of the widget can be selected or
		/// not. If not, then events (such as left mouse down) allow the user to
		/// "move" the widget, and no selection is possible. Otherwise the
		/// SelectRegion() method is invoked.
		/// </summary>
		// Token: 0x060081F6 RID: 33270 RVA: 0x000B9F76 File Offset: 0x000B8176
		public virtual void SelectableOn()
		{
			vtkBorderWidget.vtkBorderWidget_SelectableOn_16(base.GetCppThis());
		}

		// Token: 0x060081F7 RID: 33271
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderWidget_SetRepresentation_17(HandleRef pThis, HandleRef r);

		/// <summary>
		/// Specify an instance of vtkWidgetRepresentation used to represent this
		/// widget in the scene. Note that the representation is a subclass of vtkProp
		/// so it can be added to the renderer independent of the widget.
		/// </summary>
		// Token: 0x060081F8 RID: 33272 RVA: 0x000B9F88 File Offset: 0x000B8188
		public void SetRepresentation(vtkBorderRepresentation r)
		{
			vtkBorderWidget.vtkBorderWidget_SetRepresentation_17(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}

		// Token: 0x060081F9 RID: 33273
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderWidget_SetResizable_18(HandleRef pThis, int _arg);

		/// <summary>
		/// Indicate whether the boundary of the widget can be resized.
		/// If not, the cursor will not change to "resize" type when mouse
		/// over the boundary.
		/// </summary>
		// Token: 0x060081FA RID: 33274 RVA: 0x000B9FB7 File Offset: 0x000B81B7
		public virtual void SetResizable(int _arg)
		{
			vtkBorderWidget.vtkBorderWidget_SetResizable_18(base.GetCppThis(), _arg);
		}

		// Token: 0x060081FB RID: 33275
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderWidget_SetSelectable_19(HandleRef pThis, int _arg);

		/// <summary>
		/// Indicate whether the interior region of the widget can be selected or
		/// not. If not, then events (such as left mouse down) allow the user to
		/// "move" the widget, and no selection is possible. Otherwise the
		/// SelectRegion() method is invoked.
		/// </summary>
		// Token: 0x060081FC RID: 33276 RVA: 0x000B9FC7 File Offset: 0x000B81C7
		public virtual void SetSelectable(int _arg)
		{
			vtkBorderWidget.vtkBorderWidget_SetSelectable_19(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B0B RID: 2827
		public new const string MRFullTypeName = "Kitware.VTK.vtkBorderWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B0C RID: 2828
		public new static readonly string MRClassNameKey = "class vtkBorderWidget";
	}
}
