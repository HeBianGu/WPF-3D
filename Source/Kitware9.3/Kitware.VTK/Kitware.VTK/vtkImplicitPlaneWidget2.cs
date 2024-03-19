using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImplicitPlaneWidget2
	/// </summary>
	/// <remarks>
	///    3D widget for manipulating an infinite plane
	///
	/// This 3D widget defines an infinite plane that can be interactively placed
	/// in a scene. The widget is assumed to consist of four parts: 1) a plane
	/// contained in a 2) bounding box, with a 3) plane normal, which is rooted
	/// at a 4) point on the plane. (The representation paired with this widget
	/// determines the actual geometry of the widget.)
	///
	/// To use this widget, you generally pair it with a vtkImplicitPlaneRepresentation
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
	/// If the mouse is over the outline:
	///   LeftButtonPressEvent - select outline
	///   LeftButtonReleaseEvent - release outline (if selected)
	///   MouseMoveEvent - move the outline
	/// If the keypress characters are used
	///   'Down/Left' Move plane down
	///   'Up/Right' Move plane up
	/// In all the cases, independent of what is picked, the widget responds to the
	/// following VTK events:
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
	/// into the vtkImplicitPlaneWidget2's widget events:
	/// &lt;pre&gt;
	///   vtkWidgetEvent::Select -- some part of the widget has been selected
	///   vtkWidgetEvent::EndSelect -- the selection process has completed
	///   vtkWidgetEvent::Move -- a request for widget motion has been invoked
	///   vtkWidgetEvent::Up and vtkWidgetEvent::Down -- MovePlaneAction
	/// &lt;/pre&gt;
	///
	/// @par Event Bindings:
	/// In turn, when these widget events are processed, the vtkImplicitPlaneWidget2
	/// invokes the following VTK events on itself (which observers can listen for):
	/// &lt;pre&gt;
	///   vtkCommand::StartInteractionEvent (on vtkWidgetEvent::Select)
	///   vtkCommand::EndInteractionEvent (on vtkWidgetEvent::EndSelect)
	///   vtkCommand::InteractionEvent (on vtkWidgetEvent::Move)
	/// &lt;/pre&gt;
	///
	///
	/// @par Event Bindings:
	/// This class, and vtkImplicitPlaneRepresentation, are next generation VTK
	/// widgets. An earlier version of this functionality was defined in the class
	/// vtkImplicitPlaneWidget.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtk3DWidget vtkBoxWidget vtkPlaneWidget vtkLineWidget vtkPointWidget
	/// vtkSphereWidget vtkImagePlaneWidget vtkImplicitCylinderWidget
	/// </seealso>
	// Token: 0x02000331 RID: 817
	public class vtkImplicitPlaneWidget2 : vtkAbstractWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600948F RID: 38031 RVA: 0x000D2535 File Offset: 0x000D0735
		static vtkImplicitPlaneWidget2()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImplicitPlaneWidget2.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImplicitPlaneWidget2"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06009490 RID: 38032 RVA: 0x000D255D File Offset: 0x000D075D
		public vtkImplicitPlaneWidget2(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06009491 RID: 38033
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitPlaneWidget2_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x06009492 RID: 38034 RVA: 0x000D256C File Offset: 0x000D076C
		public new static vtkImplicitPlaneWidget2 New()
		{
			vtkImplicitPlaneWidget2 result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitPlaneWidget2.vtkImplicitPlaneWidget2_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitPlaneWidget2)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x06009493 RID: 38035 RVA: 0x000D25C0 File Offset: 0x000D07C0
		public vtkImplicitPlaneWidget2() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImplicitPlaneWidget2.vtkImplicitPlaneWidget2_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06009494 RID: 38036 RVA: 0x000D2604 File Offset: 0x000D0804
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06009495 RID: 38037
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneWidget2_CreateDefaultRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Create the default widget representation if one is not set.
		/// </summary>
		// Token: 0x06009496 RID: 38038 RVA: 0x000D260F File Offset: 0x000D080F
		public override void CreateDefaultRepresentation()
		{
			vtkImplicitPlaneWidget2.vtkImplicitPlaneWidget2_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06009497 RID: 38039
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitPlaneWidget2_GetImplicitPlaneRepresentation_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the representation as a vtkImplicitPlaneRepresentation.
		/// </summary>
		// Token: 0x06009498 RID: 38040 RVA: 0x000D2620 File Offset: 0x000D0820
		public vtkImplicitPlaneRepresentation GetImplicitPlaneRepresentation()
		{
			vtkImplicitPlaneRepresentation vtkImplicitPlaneRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitPlaneWidget2.vtkImplicitPlaneWidget2_GetImplicitPlaneRepresentation_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitPlaneRepresentation = (vtkImplicitPlaneRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitPlaneRepresentation.Register(null);
				}
			}
			return vtkImplicitPlaneRepresentation;
		}

		// Token: 0x06009499 RID: 38041
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImplicitPlaneWidget2_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x0600949A RID: 38042 RVA: 0x000D2690 File Offset: 0x000D0890
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImplicitPlaneWidget2.vtkImplicitPlaneWidget2_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0600949B RID: 38043
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImplicitPlaneWidget2_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x0600949C RID: 38044 RVA: 0x000D26B0 File Offset: 0x000D08B0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImplicitPlaneWidget2.vtkImplicitPlaneWidget2_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0600949D RID: 38045
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitPlaneWidget2_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x0600949E RID: 38046 RVA: 0x000D26CC File Offset: 0x000D08CC
		public override int IsA(string type)
		{
			return vtkImplicitPlaneWidget2.vtkImplicitPlaneWidget2_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600949F RID: 38047
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitPlaneWidget2_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x060094A0 RID: 38048 RVA: 0x000D26EC File Offset: 0x000D08EC
		public new static int IsTypeOf(string type)
		{
			return vtkImplicitPlaneWidget2.vtkImplicitPlaneWidget2_IsTypeOf_06(type);
		}

		// Token: 0x060094A1 RID: 38049
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitPlaneWidget2_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x060094A2 RID: 38050 RVA: 0x000D2708 File Offset: 0x000D0908
		public new vtkImplicitPlaneWidget2 NewInstance()
		{
			vtkImplicitPlaneWidget2 result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitPlaneWidget2.vtkImplicitPlaneWidget2_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitPlaneWidget2)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060094A3 RID: 38051
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitPlaneWidget2_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x060094A4 RID: 38052 RVA: 0x000D2764 File Offset: 0x000D0964
		public new static vtkImplicitPlaneWidget2 SafeDownCast(vtkObjectBase o)
		{
			vtkImplicitPlaneWidget2 vtkImplicitPlaneWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitPlaneWidget2.vtkImplicitPlaneWidget2_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitPlaneWidget = (vtkImplicitPlaneWidget2)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitPlaneWidget.Register(null);
				}
			}
			return vtkImplicitPlaneWidget;
		}

		// Token: 0x060094A5 RID: 38053
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneWidget2_SetEnabled_10(HandleRef pThis, int enabling);

		/// <summary>
		/// Specify an instance of vtkWidgetRepresentation used to represent this
		/// widget in the scene. Note that the representation is a subclass of vtkProp
		/// so it can be added to the renderer independent of the widget.
		/// </summary>
		// Token: 0x060094A6 RID: 38054 RVA: 0x000D27E3 File Offset: 0x000D09E3
		public override void SetEnabled(int enabling)
		{
			vtkImplicitPlaneWidget2.vtkImplicitPlaneWidget2_SetEnabled_10(base.GetCppThis(), enabling);
		}

		// Token: 0x060094A7 RID: 38055
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneWidget2_SetLockNormalToCamera_11(HandleRef pThis, int arg0);

		/// <summary>
		/// Observe/Unobserve the camera if the widget is locked/unlocked to update the
		/// vtkImplicitePlaneRepresentation's normal.
		/// </summary>
		// Token: 0x060094A8 RID: 38056 RVA: 0x000D27F3 File Offset: 0x000D09F3
		public void SetLockNormalToCamera(int arg0)
		{
			vtkImplicitPlaneWidget2.vtkImplicitPlaneWidget2_SetLockNormalToCamera_11(base.GetCppThis(), arg0);
		}

		// Token: 0x060094A9 RID: 38057
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneWidget2_SetRepresentation_12(HandleRef pThis, HandleRef rep);

		/// <summary>
		/// Specify an instance of vtkWidgetRepresentation used to represent this
		/// widget in the scene. Note that the representation is a subclass of vtkProp
		/// so it can be added to the renderer independent of the widget.
		/// </summary>
		// Token: 0x060094AA RID: 38058 RVA: 0x000D2804 File Offset: 0x000D0A04
		public void SetRepresentation(vtkImplicitPlaneRepresentation rep)
		{
			vtkImplicitPlaneWidget2.vtkImplicitPlaneWidget2_SetRepresentation_12(base.GetCppThis(), (rep == null) ? default(HandleRef) : rep.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C31 RID: 3121
		public new const string MRFullTypeName = "Kitware.VTK.vtkImplicitPlaneWidget2";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C32 RID: 3122
		public new static readonly string MRClassNameKey = "class vtkImplicitPlaneWidget2";
	}
}
