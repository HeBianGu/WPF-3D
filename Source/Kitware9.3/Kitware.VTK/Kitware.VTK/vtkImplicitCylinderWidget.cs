using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImplicitCylinderWidget
	/// </summary>
	/// <remarks>
	///    3D widget for manipulating an infinite cylinder
	///
	/// This 3D widget defines an infinite cylinder that can be
	/// interactively placed in a scene. The widget is assumed to consist
	/// of four parts: 1) a cylinder contained in a 2) bounding box, with a
	/// 3) cylinder axis, which is rooted at a 4) center point in the bounding
	/// box. (The representation paired with this widget determines the
	/// actual geometry of the widget.)
	///
	/// To use this widget, you generally pair it with a vtkImplicitCylinderRepresentation
	/// (or a subclass). Various options are available for controlling how the
	/// representation appears, and how the widget functions.
	///
	/// @par Event Bindings:
	/// By default, the widget responds to the following VTK events (i.e., it
	/// watches the vtkRenderWindowInteractor for these events):
	/// &lt;pre&gt;
	/// If the cylinder axis is selected:
	///   LeftButtonPressEvent - select normal
	///   LeftButtonReleaseEvent - release (end select) normal
	///   MouseMoveEvent - orient the normal vector
	/// If the center point (handle) is selected:
	///   LeftButtonPressEvent - select handle (if on slider)
	///   LeftButtonReleaseEvent - release handle (if selected)
	///   MouseMoveEvent - move the center point (constrained to plane or on the
	///                    axis if CTRL key is pressed)
	/// If the cylinder is selected:
	///   LeftButtonPressEvent - select cylinder
	///   LeftButtonReleaseEvent - release cylinder
	///   MouseMoveEvent - increase/decrease cylinder radius
	/// If the outline is selected:
	///   LeftButtonPressEvent - select outline
	///   LeftButtonReleaseEvent - release outline
	///   MouseMoveEvent - move the outline
	/// If the keypress characters are used
	///   'Down/Left' Move cylinder away from viewer
	///   'Up/Right' Move cylinder towards viewer
	/// In all the cases, independent of what is picked, the widget responds to the
	/// following VTK events:
	///   MiddleButtonPressEvent - move the cylinder
	///   MiddleButtonReleaseEvent - release the cylinder
	///   RightButtonPressEvent - scale the widget's representation
	///   RightButtonReleaseEvent - stop scaling the widget
	///   MouseMoveEvent - scale (if right button) or move (if middle button) the widget
	/// &lt;/pre&gt;
	///
	/// @par Event Bindings:
	/// Note that the event bindings described above can be changed using this
	/// class's vtkWidgetEventTranslator. This class translates VTK events
	/// into the vtkImplicitCylinderWidget's widget events:
	/// &lt;pre&gt;
	///   vtkWidgetEvent::Select -- some part of the widget has been selected
	///   vtkWidgetEvent::EndSelect -- the selection process has completed
	///   vtkWidgetEvent::Move -- a request for widget motion has been invoked
	///   vtkWidgetEvent::Up and vtkWidgetEvent::Down -- MoveCylinderAction
	/// &lt;/pre&gt;
	///
	/// @par Event Bindings:
	/// In turn, when these widget events are processed, the vtkImplicitCylinderWidget
	/// invokes the following VTK events on itself (which observers can listen for):
	/// &lt;pre&gt;
	///   vtkCommand::StartInteractionEvent (on vtkWidgetEvent::Select)
	///   vtkCommand::EndInteractionEvent (on vtkWidgetEvent::EndSelect)
	///   vtkCommand::InteractionEvent (on vtkWidgetEvent::Move)
	/// &lt;/pre&gt;
	///
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtk3DWidget vtkImplicitPlaneWidget
	/// </seealso>
	// Token: 0x0200032C RID: 812
	public class vtkImplicitCylinderWidget : vtkAbstractWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060092A5 RID: 37541 RVA: 0x000D00B4 File Offset: 0x000CE2B4
		static vtkImplicitCylinderWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImplicitCylinderWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImplicitCylinderWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060092A6 RID: 37542 RVA: 0x000D00DC File Offset: 0x000CE2DC
		public vtkImplicitCylinderWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060092A7 RID: 37543
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitCylinderWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x060092A8 RID: 37544 RVA: 0x000D00EC File Offset: 0x000CE2EC
		public new static vtkImplicitCylinderWidget New()
		{
			vtkImplicitCylinderWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitCylinderWidget.vtkImplicitCylinderWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitCylinderWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x060092A9 RID: 37545 RVA: 0x000D0140 File Offset: 0x000CE340
		public vtkImplicitCylinderWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImplicitCylinderWidget.vtkImplicitCylinderWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060092AA RID: 37546 RVA: 0x000D0184 File Offset: 0x000CE384
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060092AB RID: 37547
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Create the default widget representation if one is not set.
		/// </summary>
		// Token: 0x060092AC RID: 37548 RVA: 0x000D018F File Offset: 0x000CE38F
		public override void CreateDefaultRepresentation()
		{
			vtkImplicitCylinderWidget.vtkImplicitCylinderWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		// Token: 0x060092AD RID: 37549
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitCylinderWidget_GetCylinderRepresentation_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the representation as a vtkImplicitCylinderRepresentation.
		/// </summary>
		// Token: 0x060092AE RID: 37550 RVA: 0x000D01A0 File Offset: 0x000CE3A0
		public vtkImplicitCylinderRepresentation GetCylinderRepresentation()
		{
			vtkImplicitCylinderRepresentation vtkImplicitCylinderRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitCylinderWidget.vtkImplicitCylinderWidget_GetCylinderRepresentation_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitCylinderRepresentation = (vtkImplicitCylinderRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitCylinderRepresentation.Register(null);
				}
			}
			return vtkImplicitCylinderRepresentation;
		}

		// Token: 0x060092AF RID: 37551
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImplicitCylinderWidget_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x060092B0 RID: 37552 RVA: 0x000D0210 File Offset: 0x000CE410
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImplicitCylinderWidget.vtkImplicitCylinderWidget_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x060092B1 RID: 37553
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImplicitCylinderWidget_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x060092B2 RID: 37554 RVA: 0x000D0230 File Offset: 0x000CE430
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImplicitCylinderWidget.vtkImplicitCylinderWidget_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x060092B3 RID: 37555
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitCylinderWidget_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x060092B4 RID: 37556 RVA: 0x000D024C File Offset: 0x000CE44C
		public override int IsA(string type)
		{
			return vtkImplicitCylinderWidget.vtkImplicitCylinderWidget_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x060092B5 RID: 37557
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitCylinderWidget_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x060092B6 RID: 37558 RVA: 0x000D026C File Offset: 0x000CE46C
		public new static int IsTypeOf(string type)
		{
			return vtkImplicitCylinderWidget.vtkImplicitCylinderWidget_IsTypeOf_06(type);
		}

		// Token: 0x060092B7 RID: 37559
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitCylinderWidget_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x060092B8 RID: 37560 RVA: 0x000D0288 File Offset: 0x000CE488
		public new vtkImplicitCylinderWidget NewInstance()
		{
			vtkImplicitCylinderWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitCylinderWidget.vtkImplicitCylinderWidget_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitCylinderWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060092B9 RID: 37561
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitCylinderWidget_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x060092BA RID: 37562 RVA: 0x000D02E4 File Offset: 0x000CE4E4
		public new static vtkImplicitCylinderWidget SafeDownCast(vtkObjectBase o)
		{
			vtkImplicitCylinderWidget vtkImplicitCylinderWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitCylinderWidget.vtkImplicitCylinderWidget_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitCylinderWidget = (vtkImplicitCylinderWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitCylinderWidget.Register(null);
				}
			}
			return vtkImplicitCylinderWidget;
		}

		// Token: 0x060092BB RID: 37563
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderWidget_SetRepresentation_10(HandleRef pThis, HandleRef rep);

		/// <summary>
		/// Specify an instance of vtkWidgetRepresentation used to represent this
		/// widget in the scene. Note that the representation is a subclass of vtkProp
		/// so it can be added to the renderer independent of the widget.
		/// </summary>
		// Token: 0x060092BC RID: 37564 RVA: 0x000D0364 File Offset: 0x000CE564
		public void SetRepresentation(vtkImplicitCylinderRepresentation rep)
		{
			vtkImplicitCylinderWidget.vtkImplicitCylinderWidget_SetRepresentation_10(base.GetCppThis(), (rep == null) ? default(HandleRef) : rep.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C21 RID: 3105
		public new const string MRFullTypeName = "Kitware.VTK.vtkImplicitCylinderWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C22 RID: 3106
		public new static readonly string MRClassNameKey = "class vtkImplicitCylinderWidget";
	}
}
