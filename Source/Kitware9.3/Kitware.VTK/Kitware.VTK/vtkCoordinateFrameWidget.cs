using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCoordinateFrameWidget
	/// </summary>
	/// <remarks>
	///    3D widget for manipulating a display sized coordinate frame widget
	///
	/// This 3D widget defines a display sized coordinate frame
	/// that can be interactively placed in a scene. The widget is assumed
	/// to consist of three parts: 1) an origin, 2) 3 axis normals which are rooted at the origin
	/// and 3 axis lockers. (The representation paired with this widget determines the actual
	/// geometry of the widget.)
	///
	/// To use this widget, you generally pair it with a vtkCoordinateFrameRepresentation
	/// (or a subclass). Various options are available for controlling how the
	/// representation appears, and how the widget functions.
	///
	/// @par Event Bindings:
	/// By default, the widget responds to the following VTK events (i.e., it
	/// watches the vtkRenderWindowInteractor for these events):
	/// &lt;pre&gt;
	/// If the mouse is over the one of the axis normals:
	///   LeftButtonPressEvent - select normal
	///   LeftButtonReleaseEvent - release normal
	///   MouseMoveEvent - orient the axis normal vectors (possibly constrained to
	///   one of the axis' planes)
	/// If the mouse is over the origin point (handle):
	///   LeftButtonPressEvent - select handle
	///   LeftButtonReleaseEvent - release handle (if selected)
	///   MouseMoveEvent - move the origin point (possibly constrained to one of the axis' planes)
	/// If the mouse is over one of the axis lockers:
	///   LeftButtonPressEvent - select axis locker
	///   LeftButtonReleaseEvent - unlock/lock and axis locker (and unlock all the other lockers)
	/// If the keypress characters are used
	///   'Down/Left' Move plane down
	///   'Up/Right' Move plane up
	///   'P/p' Pick a new origin from the intersection with a mesh cell rendered by the renderer
	///   'Ctrl' + 'P/p' Snap to a new origin from the closest mesh point rendered by the renderer
	///   'N/n' Pick a new normal from the intersection with a mesh cell rendered by the renderer
	///   'Ctrl' + 'N/n' Snap to a new normal from the closest mesh point rendered by the renderer
	///   'D/d' Pick a new point to define the direction normal which will be the new normal
	///   'Ctrl' + 'D/d' Snap to a new point to define the direction normal which will be the new normal
	/// &lt;/pre&gt;
	///
	/// @par Event Bindings:
	/// Note that the event bindings described above can be changed using this
	/// class's vtkWidgetEventTranslator. This class translates VTK events
	/// into the vtkCoordinateFrameWidget's widget events:
	/// &lt;pre&gt;
	///   vtkWidgetEvent::Select -- some part of the widget has been selected
	///   vtkWidgetEvent::EndSelect -- the selection process has completed
	///   vtkWidgetEvent::Move -- a request for widget motion has been invoked
	///   vtkWidgetEvent::PickPoint -- PickOriginAction
	///   vtkWidgetEvent::PickNormal -- PickNormalAction
	///   vtkWidgetEvent::PickDirectionPoint -- PickDirectionPointAction
	/// &lt;/pre&gt;
	///
	/// @par Event Bindings:
	/// In turn, when these widget events are processed, the vtkCoordinateFrameWidget
	/// invokes the following VTK events on itself (which observers can listen for):
	/// &lt;pre&gt;
	///   vtkCommand::StartInteractionEvent (on vtkWidgetEvent::Select)
	///   vtkCommand::EndInteractionEvent (on vtkWidgetEvent::EndSelect)
	///   vtkCommand::InteractionEvent (on vtkWidgetEvent::Move)
	/// &lt;/pre&gt;
	///
	///
	/// @par Event Bindings:
	/// This class, and vtkCoordinateFrameRepresentation, are next generation VTK
	/// widgets.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtk3DWidget vtkBoxWidget vtkPlaneWidget vtkLineWidget vtkPointWidget
	/// vtkSphereWidget vtkImagePlaneWidget vtkImplicitCylinderWidget, vtkImplicitPlaneWidget2
	/// vtkDisplaySizedImplicitPlaneWidget
	/// </seealso>
	// Token: 0x02000307 RID: 775
	public class vtkCoordinateFrameWidget : vtkAbstractWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06008AE3 RID: 35555 RVA: 0x000C6445 File Offset: 0x000C4645
		static vtkCoordinateFrameWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCoordinateFrameWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCoordinateFrameWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06008AE4 RID: 35556 RVA: 0x000C646D File Offset: 0x000C466D
		public vtkCoordinateFrameWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06008AE5 RID: 35557
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinateFrameWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x06008AE6 RID: 35558 RVA: 0x000C647C File Offset: 0x000C467C
		public new static vtkCoordinateFrameWidget New()
		{
			vtkCoordinateFrameWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCoordinateFrameWidget.vtkCoordinateFrameWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCoordinateFrameWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x06008AE7 RID: 35559 RVA: 0x000C64D0 File Offset: 0x000C46D0
		public vtkCoordinateFrameWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCoordinateFrameWidget.vtkCoordinateFrameWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06008AE8 RID: 35560 RVA: 0x000C6514 File Offset: 0x000C4714
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06008AE9 RID: 35561
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrameWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Create the default widget representation if one is not set.
		/// </summary>
		// Token: 0x06008AEA RID: 35562 RVA: 0x000C651F File Offset: 0x000C471F
		public override void CreateDefaultRepresentation()
		{
			vtkCoordinateFrameWidget.vtkCoordinateFrameWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06008AEB RID: 35563
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinateFrameWidget_GetCoordinateFrameRepresentation_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the representation as a vtkCoordinateFrameRepresentation.
		/// </summary>
		// Token: 0x06008AEC RID: 35564 RVA: 0x000C6530 File Offset: 0x000C4730
		public vtkCoordinateFrameRepresentation GetCoordinateFrameRepresentation()
		{
			vtkCoordinateFrameRepresentation vtkCoordinateFrameRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCoordinateFrameWidget.vtkCoordinateFrameWidget_GetCoordinateFrameRepresentation_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCoordinateFrameRepresentation = (vtkCoordinateFrameRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCoordinateFrameRepresentation.Register(null);
				}
			}
			return vtkCoordinateFrameRepresentation;
		}

		// Token: 0x06008AED RID: 35565
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCoordinateFrameWidget_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x06008AEE RID: 35566 RVA: 0x000C65A0 File Offset: 0x000C47A0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCoordinateFrameWidget.vtkCoordinateFrameWidget_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06008AEF RID: 35567
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCoordinateFrameWidget_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x06008AF0 RID: 35568 RVA: 0x000C65C0 File Offset: 0x000C47C0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCoordinateFrameWidget.vtkCoordinateFrameWidget_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06008AF1 RID: 35569
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCoordinateFrameWidget_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x06008AF2 RID: 35570 RVA: 0x000C65DC File Offset: 0x000C47DC
		public override int IsA(string type)
		{
			return vtkCoordinateFrameWidget.vtkCoordinateFrameWidget_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06008AF3 RID: 35571
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCoordinateFrameWidget_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x06008AF4 RID: 35572 RVA: 0x000C65FC File Offset: 0x000C47FC
		public new static int IsTypeOf(string type)
		{
			return vtkCoordinateFrameWidget.vtkCoordinateFrameWidget_IsTypeOf_06(type);
		}

		// Token: 0x06008AF5 RID: 35573
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinateFrameWidget_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x06008AF6 RID: 35574 RVA: 0x000C6618 File Offset: 0x000C4818
		public new vtkCoordinateFrameWidget NewInstance()
		{
			vtkCoordinateFrameWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCoordinateFrameWidget.vtkCoordinateFrameWidget_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCoordinateFrameWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06008AF7 RID: 35575
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinateFrameWidget_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x06008AF8 RID: 35576 RVA: 0x000C6674 File Offset: 0x000C4874
		public new static vtkCoordinateFrameWidget SafeDownCast(vtkObjectBase o)
		{
			vtkCoordinateFrameWidget vtkCoordinateFrameWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCoordinateFrameWidget.vtkCoordinateFrameWidget_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCoordinateFrameWidget = (vtkCoordinateFrameWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCoordinateFrameWidget.Register(null);
				}
			}
			return vtkCoordinateFrameWidget;
		}

		// Token: 0x06008AF9 RID: 35577
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrameWidget_SetEnabled_10(HandleRef pThis, int enabling);

		/// <summary>
		/// Specify an instance of vtkWidgetRepresentation used to represent this
		/// widget in the scene. Note that the representation is a subclass of vtkProp
		/// so it can be added to the renderer independent of the widget.
		/// </summary>
		// Token: 0x06008AFA RID: 35578 RVA: 0x000C66F3 File Offset: 0x000C48F3
		public override void SetEnabled(int enabling)
		{
			vtkCoordinateFrameWidget.vtkCoordinateFrameWidget_SetEnabled_10(base.GetCppThis(), enabling);
		}

		// Token: 0x06008AFB RID: 35579
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrameWidget_SetRepresentation_11(HandleRef pThis, HandleRef rep);

		/// <summary>
		/// Specify an instance of vtkWidgetRepresentation used to represent this
		/// widget in the scene. Note that the representation is a subclass of vtkProp
		/// so it can be added to the renderer independent of the widget.
		/// </summary>
		// Token: 0x06008AFC RID: 35580 RVA: 0x000C6704 File Offset: 0x000C4904
		public void SetRepresentation(vtkCoordinateFrameRepresentation rep)
		{
			vtkCoordinateFrameWidget.vtkCoordinateFrameWidget_SetRepresentation_11(base.GetCppThis(), (rep == null) ? default(HandleRef) : rep.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000BB3 RID: 2995
		public new const string MRFullTypeName = "Kitware.VTK.vtkCoordinateFrameWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000BB4 RID: 2996
		public new static readonly string MRClassNameKey = "class vtkCoordinateFrameWidget";
	}
}
