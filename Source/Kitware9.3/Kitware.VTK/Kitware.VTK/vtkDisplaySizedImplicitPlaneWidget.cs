using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDisplaySizedImplicitPlaneWidget
	/// </summary>
	/// <remarks>
	///    3D widget for manipulating a display sized plane
	///
	/// This 3D widget defines a display sized plane represented as a disk,
	/// that can be interactively placed in a scene. The widget is assumed
	/// to consist of three parts: 1) a disk plane with a 2) plane normal, which
	/// is rooted at a 3) point on the plane. (The representation paired
	/// with this widget determines the actual geometry of the widget.)
	///
	/// To use this widget, you generally pair it with a vtkDisplaySizedImplicitPlaneRepresentation
	/// (or a subclass). Various options are available for controlling how the
	/// representation appears, and how the widget functions.
	///
	/// @par Event Bindings:
	/// By default, the widget responds to the following VTK events (i.e., it
	/// watches the vtkRenderWindowInteractor for these events):
	/// &lt;pre&gt;
	/// If the mouse is over the plane normal:
	///   LeftButtonPressEvent - select normal
	///   LeftButtonReleaseEvent - release normal
	///   MouseMoveEvent - orient the normal vector
	/// If the mouse is over the origin point (handle):
	///   LeftButtonPressEvent - select handle
	///   LeftButtonReleaseEvent - release handle (if selected)
	///   MouseMoveEvent - move the origin point (constrained to the plane)
	/// If the mouse is over the plane:
	///   LeftButtonPressEvent - select plane
	///   LeftButtonReleaseEvent - release plane (if selected)
	///   MouseMoveEvent - move the plane
	/// If the mouse is over the perimeter of the disk plane:
	///   LeftButtonPressEvent - select perimeter
	///   LeftButtonReleaseEvent - release perimeter (if selected)
	///   MouseMoveEvent - resize the perimeter -&gt; radius of the disk plane
	/// If the keypress characters are used
	///   'Down/Left' Move plane down
	///   'Up/Right' Move plane up
	///   'P/p' Pick a new origin from the intersection with a mesh cell rendered by the renderer
	///   'Ctrl' + 'P/p' Snap to a new origin from the closest mesh point rendered by the renderer
	///   'N/n' Pick a new normal from the intersection with a mesh cell rendered by the renderer
	///   'Ctrl' + 'N/n' Snap to a new normal from the closest mesh point rendered by the renderer
	/// In all the cases, independent of what is picked, the widget responds to the following VTK events:
	///   MiddleButtonPressEvent - move the plane
	///   MiddleButtonReleaseEvent - release the plane
	///   RightButtonPressEvent - scale the widget's representation
	///   RightButtonReleaseEvent - stop scaling the widget
	///   MouseMoveEvent - scale (if right button) or move (if middle button) the widget
	/// &lt;/pre&gt;
	///
	/// @par Event Bindings:
	/// Note that the event bindings described above can be changed using this
	/// class's vtkWidgetEventTranslator. This class translates VTK events
	/// into the vtkDisplaySizedImplicitPlaneWidget's widget events:
	/// &lt;pre&gt;
	///   vtkWidgetEvent::Select -- some part of the widget has been selected
	///   vtkWidgetEvent::EndSelect -- the selection process has completed
	///   vtkWidgetEvent::Move -- a request for widget motion has been invoked
	///   vtkWidgetEvent::Up and vtkWidgetEvent::Down -- MovePlaneAction
	///   vtkWidgetEvent::PickPoint -- PickOriginAction
	///   vtkWidgetEvent::PickNormal -- PickNormalAction
	/// &lt;/pre&gt;
	///
	/// @par Event Bindings:
	/// In turn, when these widget events are processed, the vtkDisplaySizedImplicitPlaneWidget
	/// invokes the following VTK events on itself (which observers can listen for):
	/// &lt;pre&gt;
	///   vtkCommand::StartInteractionEvent (on vtkWidgetEvent::Select)
	///   vtkCommand::EndInteractionEvent (on vtkWidgetEvent::EndSelect)
	///   vtkCommand::InteractionEvent (on vtkWidgetEvent::Move)
	/// &lt;/pre&gt;
	///
	///
	/// @par Event Bindings:
	/// This class, and vtkDisplaySizedImplicitPlaneRepresentation, are next generation VTK
	/// widgets.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtk3DWidget vtkBoxWidget vtkPlaneWidget vtkLineWidget vtkPointWidget
	/// vtkSphereWidget vtkImagePlaneWidget vtkImplicitCylinderWidget, vtkImplicitPlaneWidget2
	/// </seealso>
	// Token: 0x02000309 RID: 777
	public class vtkDisplaySizedImplicitPlaneWidget : vtkAbstractWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06008B17 RID: 35607 RVA: 0x000C6ABF File Offset: 0x000C4CBF
		static vtkDisplaySizedImplicitPlaneWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDisplaySizedImplicitPlaneWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDisplaySizedImplicitPlaneWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06008B18 RID: 35608 RVA: 0x000C6AE7 File Offset: 0x000C4CE7
		public vtkDisplaySizedImplicitPlaneWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06008B19 RID: 35609
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDisplaySizedImplicitPlaneWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x06008B1A RID: 35610 RVA: 0x000C6AF8 File Offset: 0x000C4CF8
		public new static vtkDisplaySizedImplicitPlaneWidget New()
		{
			vtkDisplaySizedImplicitPlaneWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDisplaySizedImplicitPlaneWidget.vtkDisplaySizedImplicitPlaneWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDisplaySizedImplicitPlaneWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x06008B1B RID: 35611 RVA: 0x000C6B4C File Offset: 0x000C4D4C
		public vtkDisplaySizedImplicitPlaneWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDisplaySizedImplicitPlaneWidget.vtkDisplaySizedImplicitPlaneWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06008B1C RID: 35612 RVA: 0x000C6B90 File Offset: 0x000C4D90
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06008B1D RID: 35613
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Create the default widget representation if one is not set.
		/// </summary>
		// Token: 0x06008B1E RID: 35614 RVA: 0x000C6B9B File Offset: 0x000C4D9B
		public override void CreateDefaultRepresentation()
		{
			vtkDisplaySizedImplicitPlaneWidget.vtkDisplaySizedImplicitPlaneWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06008B1F RID: 35615
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDisplaySizedImplicitPlaneWidget_GetDisplaySizedImplicitPlaneRepresentation_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the representation as a vtkDisplaySizedImplicitPlaneRepresentation.
		/// </summary>
		// Token: 0x06008B20 RID: 35616 RVA: 0x000C6BAC File Offset: 0x000C4DAC
		public vtkDisplaySizedImplicitPlaneRepresentation GetDisplaySizedImplicitPlaneRepresentation()
		{
			vtkDisplaySizedImplicitPlaneRepresentation vtkDisplaySizedImplicitPlaneRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDisplaySizedImplicitPlaneWidget.vtkDisplaySizedImplicitPlaneWidget_GetDisplaySizedImplicitPlaneRepresentation_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDisplaySizedImplicitPlaneRepresentation = (vtkDisplaySizedImplicitPlaneRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDisplaySizedImplicitPlaneRepresentation.Register(null);
				}
			}
			return vtkDisplaySizedImplicitPlaneRepresentation;
		}

		// Token: 0x06008B21 RID: 35617
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDisplaySizedImplicitPlaneWidget_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x06008B22 RID: 35618 RVA: 0x000C6C1C File Offset: 0x000C4E1C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDisplaySizedImplicitPlaneWidget.vtkDisplaySizedImplicitPlaneWidget_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06008B23 RID: 35619
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDisplaySizedImplicitPlaneWidget_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x06008B24 RID: 35620 RVA: 0x000C6C3C File Offset: 0x000C4E3C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDisplaySizedImplicitPlaneWidget.vtkDisplaySizedImplicitPlaneWidget_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06008B25 RID: 35621
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDisplaySizedImplicitPlaneWidget_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x06008B26 RID: 35622 RVA: 0x000C6C58 File Offset: 0x000C4E58
		public override int IsA(string type)
		{
			return vtkDisplaySizedImplicitPlaneWidget.vtkDisplaySizedImplicitPlaneWidget_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06008B27 RID: 35623
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDisplaySizedImplicitPlaneWidget_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x06008B28 RID: 35624 RVA: 0x000C6C78 File Offset: 0x000C4E78
		public new static int IsTypeOf(string type)
		{
			return vtkDisplaySizedImplicitPlaneWidget.vtkDisplaySizedImplicitPlaneWidget_IsTypeOf_06(type);
		}

		// Token: 0x06008B29 RID: 35625
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDisplaySizedImplicitPlaneWidget_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x06008B2A RID: 35626 RVA: 0x000C6C94 File Offset: 0x000C4E94
		public new vtkDisplaySizedImplicitPlaneWidget NewInstance()
		{
			vtkDisplaySizedImplicitPlaneWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDisplaySizedImplicitPlaneWidget.vtkDisplaySizedImplicitPlaneWidget_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDisplaySizedImplicitPlaneWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06008B2B RID: 35627
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDisplaySizedImplicitPlaneWidget_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x06008B2C RID: 35628 RVA: 0x000C6CF0 File Offset: 0x000C4EF0
		public new static vtkDisplaySizedImplicitPlaneWidget SafeDownCast(vtkObjectBase o)
		{
			vtkDisplaySizedImplicitPlaneWidget vtkDisplaySizedImplicitPlaneWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDisplaySizedImplicitPlaneWidget.vtkDisplaySizedImplicitPlaneWidget_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDisplaySizedImplicitPlaneWidget = (vtkDisplaySizedImplicitPlaneWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDisplaySizedImplicitPlaneWidget.Register(null);
				}
			}
			return vtkDisplaySizedImplicitPlaneWidget;
		}

		// Token: 0x06008B2D RID: 35629
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneWidget_SetEnabled_10(HandleRef pThis, int enabling);

		/// <summary>
		/// Specify an instance of vtkWidgetRepresentation used to represent this
		/// widget in the scene. Note that the representation is a subclass of vtkProp
		/// so it can be added to the renderer independent of the widget.
		/// </summary>
		// Token: 0x06008B2E RID: 35630 RVA: 0x000C6D6F File Offset: 0x000C4F6F
		public override void SetEnabled(int enabling)
		{
			vtkDisplaySizedImplicitPlaneWidget.vtkDisplaySizedImplicitPlaneWidget_SetEnabled_10(base.GetCppThis(), enabling);
		}

		// Token: 0x06008B2F RID: 35631
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneWidget_SetLockNormalToCamera_11(HandleRef pThis, int arg0);

		/// <summary>
		/// Observe/Unobserve the camera if the widget is locked/unlocked to update the
		/// vtkImplicitePlaneRepresentation's normal.
		/// </summary>
		// Token: 0x06008B30 RID: 35632 RVA: 0x000C6D7F File Offset: 0x000C4F7F
		public void SetLockNormalToCamera(int arg0)
		{
			vtkDisplaySizedImplicitPlaneWidget.vtkDisplaySizedImplicitPlaneWidget_SetLockNormalToCamera_11(base.GetCppThis(), arg0);
		}

		// Token: 0x06008B31 RID: 35633
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneWidget_SetRepresentation_12(HandleRef pThis, HandleRef rep);

		/// <summary>
		/// Specify an instance of vtkWidgetRepresentation used to represent this
		/// widget in the scene. Note that the representation is a subclass of vtkProp
		/// so it can be added to the renderer independent of the widget.
		/// </summary>
		// Token: 0x06008B32 RID: 35634 RVA: 0x000C6D90 File Offset: 0x000C4F90
		public void SetRepresentation(vtkDisplaySizedImplicitPlaneRepresentation rep)
		{
			vtkDisplaySizedImplicitPlaneWidget.vtkDisplaySizedImplicitPlaneWidget_SetRepresentation_12(base.GetCppThis(), (rep == null) ? default(HandleRef) : rep.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000BB7 RID: 2999
		public new const string MRFullTypeName = "Kitware.VTK.vtkDisplaySizedImplicitPlaneWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000BB8 RID: 3000
		public new static readonly string MRClassNameKey = "class vtkDisplaySizedImplicitPlaneWidget";
	}
}
