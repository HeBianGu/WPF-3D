using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAxesTransformWidget
	/// </summary>
	/// <remarks>
	///    3D widget for performing 3D transformations around an axes
	///
	/// This 3D widget defines an axes which is used to guide transformation. The
	/// widget can translate, scale, and rotate around one of the three coordinate
	/// axes. The widget consists of a handle at the origin (used for
	/// translation), three axes (around which rotations occur), and three end
	/// arrows (or cones depending on the representation) that can be stretched to
	/// scale an object.  Optionally a text label can be used to indicate the
	/// amount of the transformation.
	///
	/// To use this widget, you generally pair it with a
	/// vtkAxesTransformRepresentation (or a subclass). Various options are
	/// available in the representation for controlling how the widget appears,
	/// and how the widget functions.
	///
	/// @par Event Bindings:
	/// By default, the widget responds to the following VTK events (i.e., it
	/// watches the vtkRenderWindowInteractor for these events):
	/// &lt;pre&gt;
	/// If the origin handle is selected:
	///   LeftButtonPressEvent - activate the associated handle widget
	///   LeftButtonReleaseEvent - release the handle widget associated with the point
	///   MouseMoveEvent - move the handle and hence the origin and the widget
	/// If one of the lines is selected:
	///   LeftButtonPressEvent - activate rotation by selecting one of the three axes.
	///   LeftButtonReleaseEvent - end rotation
	///   MouseMoveEvent - moving along the selected axis causes rotation to occur.
	/// If one of the arrows/cones is selected:
	///   LeftButtonPressEvent - activate scaling by selecting the ends of one of the three axes.
	///   LeftButtonReleaseEvent - end scaling
	///   MouseMoveEvent - moving along the selected axis causes scaling to occur.
	/// &lt;/pre&gt;
	///
	/// @par Event Bindings:
	/// Note that the event bindings described above can be changed using this
	/// class's vtkWidgetEventTranslator. This class translates VTK events
	/// into the vtkAxesTransformWidget's widget events:
	/// &lt;pre&gt;
	///   vtkWidgetEvent::Select -- some part of the widget has been selected
	///   vtkWidgetEvent::EndSelect -- the selection process has completed
	///   vtkWidgetEvent::Move -- a request for slider motion has been invoked
	/// &lt;/pre&gt;
	///
	/// @par Event Bindings:
	/// In turn, when these widget events are processed, the vtkAxesTransformWidget
	/// invokes the following VTK events on itself (which observers can listen for):
	/// &lt;pre&gt;
	///   vtkCommand::StartInteractionEvent (on vtkWidgetEvent::Select)
	///   vtkCommand::EndInteractionEvent (on vtkWidgetEvent::EndSelect)
	///   vtkCommand::InteractionEvent (on vtkWidgetEvent::Move)
	/// &lt;/pre&gt;
	///
	///
	/// @warning
	/// Note that the widget can be picked even when it is "behind"
	/// other actors.  This is an intended feature and not a bug.
	///
	/// @warning
	/// This class, and vtkAxesTransformRepresentation, are next generation VTK widgets.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkAxesTransformRepresentation vtkAffineWidget vtkBoxWidget2
	/// </seealso>
	// Token: 0x020002BF RID: 703
	public class vtkAxesTransformWidget : vtkAbstractWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06007F03 RID: 32515 RVA: 0x000B6351 File Offset: 0x000B4551
		static vtkAxesTransformWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAxesTransformWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAxesTransformWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06007F04 RID: 32516 RVA: 0x000B6379 File Offset: 0x000B4579
		public vtkAxesTransformWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06007F05 RID: 32517
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxesTransformWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x06007F06 RID: 32518 RVA: 0x000B6388 File Offset: 0x000B4588
		public new static vtkAxesTransformWidget New()
		{
			vtkAxesTransformWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxesTransformWidget.vtkAxesTransformWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAxesTransformWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x06007F07 RID: 32519 RVA: 0x000B63DC File Offset: 0x000B45DC
		public vtkAxesTransformWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAxesTransformWidget.vtkAxesTransformWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06007F08 RID: 32520 RVA: 0x000B6420 File Offset: 0x000B4620
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06007F09 RID: 32521
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesTransformWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Create the default widget representation if one is not set.
		/// </summary>
		// Token: 0x06007F0A RID: 32522 RVA: 0x000B642B File Offset: 0x000B462B
		public override void CreateDefaultRepresentation()
		{
			vtkAxesTransformWidget.vtkAxesTransformWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06007F0B RID: 32523
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxesTransformWidget_GetLineRepresentation_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the representation as a vtkAxesTransformRepresentation.
		/// </summary>
		// Token: 0x06007F0C RID: 32524 RVA: 0x000B643C File Offset: 0x000B463C
		public vtkAxesTransformRepresentation GetLineRepresentation()
		{
			vtkAxesTransformRepresentation vtkAxesTransformRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxesTransformWidget.vtkAxesTransformWidget_GetLineRepresentation_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAxesTransformRepresentation = (vtkAxesTransformRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAxesTransformRepresentation.Register(null);
				}
			}
			return vtkAxesTransformRepresentation;
		}

		// Token: 0x06007F0D RID: 32525
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAxesTransformWidget_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x06007F0E RID: 32526 RVA: 0x000B64AC File Offset: 0x000B46AC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAxesTransformWidget.vtkAxesTransformWidget_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06007F0F RID: 32527
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAxesTransformWidget_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x06007F10 RID: 32528 RVA: 0x000B64CC File Offset: 0x000B46CC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAxesTransformWidget.vtkAxesTransformWidget_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06007F11 RID: 32529
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxesTransformWidget_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x06007F12 RID: 32530 RVA: 0x000B64E8 File Offset: 0x000B46E8
		public override int IsA(string type)
		{
			return vtkAxesTransformWidget.vtkAxesTransformWidget_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06007F13 RID: 32531
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxesTransformWidget_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x06007F14 RID: 32532 RVA: 0x000B6508 File Offset: 0x000B4708
		public new static int IsTypeOf(string type)
		{
			return vtkAxesTransformWidget.vtkAxesTransformWidget_IsTypeOf_06(type);
		}

		// Token: 0x06007F15 RID: 32533
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxesTransformWidget_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x06007F16 RID: 32534 RVA: 0x000B6524 File Offset: 0x000B4724
		public new vtkAxesTransformWidget NewInstance()
		{
			vtkAxesTransformWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxesTransformWidget.vtkAxesTransformWidget_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAxesTransformWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06007F17 RID: 32535
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxesTransformWidget_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x06007F18 RID: 32536 RVA: 0x000B6580 File Offset: 0x000B4780
		public new static vtkAxesTransformWidget SafeDownCast(vtkObjectBase o)
		{
			vtkAxesTransformWidget vtkAxesTransformWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxesTransformWidget.vtkAxesTransformWidget_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAxesTransformWidget = (vtkAxesTransformWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAxesTransformWidget.Register(null);
				}
			}
			return vtkAxesTransformWidget;
		}

		// Token: 0x06007F19 RID: 32537
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesTransformWidget_SetEnabled_10(HandleRef pThis, int enabling);

		/// <summary>
		/// Override superclasses' SetEnabled() method because the line
		/// widget must enable its internal handle widgets.
		/// </summary>
		// Token: 0x06007F1A RID: 32538 RVA: 0x000B65FF File Offset: 0x000B47FF
		public override void SetEnabled(int enabling)
		{
			vtkAxesTransformWidget.vtkAxesTransformWidget_SetEnabled_10(base.GetCppThis(), enabling);
		}

		// Token: 0x06007F1B RID: 32539
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesTransformWidget_SetProcessEvents_11(HandleRef pThis, int arg0);

		/// <summary>
		/// Methods to change the whether the widget responds to interaction.
		/// Overridden to pass the state to component widgets.
		/// </summary>
		// Token: 0x06007F1C RID: 32540 RVA: 0x000B660F File Offset: 0x000B480F
		public override void SetProcessEvents(int arg0)
		{
			vtkAxesTransformWidget.vtkAxesTransformWidget_SetProcessEvents_11(base.GetCppThis(), arg0);
		}

		// Token: 0x06007F1D RID: 32541
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesTransformWidget_SetRepresentation_12(HandleRef pThis, HandleRef r);

		/// <summary>
		/// Specify an instance of vtkWidgetRepresentation used to represent this
		/// widget in the scene. Note that the representation is a subclass of vtkProp
		/// so it can be added to the renderer independent of the widget.
		/// </summary>
		// Token: 0x06007F1E RID: 32542 RVA: 0x000B6620 File Offset: 0x000B4820
		public void SetRepresentation(vtkAxesTransformRepresentation r)
		{
			vtkAxesTransformWidget.vtkAxesTransformWidget_SetRepresentation_12(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000ABB RID: 2747
		public new const string MRFullTypeName = "Kitware.VTK.vtkAxesTransformWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000ABC RID: 2748
		public new static readonly string MRClassNameKey = "class vtkAxesTransformWidget";
	}
}
