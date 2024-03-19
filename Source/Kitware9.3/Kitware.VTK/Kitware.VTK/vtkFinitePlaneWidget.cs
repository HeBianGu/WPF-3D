using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkFinitePlaneWidget
	/// </summary>
	/// <remarks>
	///    3D widget for manipulating a finite plane
	///
	/// This 3D widget interacts with a vtkFinitePlaneRepresentation class (i.e., it
	/// handles the events that drive its corresponding representation). This 3D
	/// widget defines a finite plane that can be interactively placed in a scene.
	/// The widget is assumed to consist of four parts: 1) a plane with 2) a normal
	/// and 3) three handles that can be moused on and manipulated.
	/// The green and red handles represent the semi finite plane definition,
	/// the third is in the center of the plane.
	/// Operation like rotation of the plane (using normal), origin translation and
	/// geometry plane modification using green and red handles are availables.
	///
	/// To use this widget, you generally pair it with a vtkFinitePlaneRepresentation
	/// (or a subclass). Various options are available in the representation for
	/// controlling how the widget appears, and how the widget reacts.
	///
	/// @par Event Bindings:
	/// By default, the widget responds to the following VTK events (i.e., it
	/// watches the vtkRenderWindowInteractor for these events):
	/// &lt;pre&gt;
	/// If one of the 3 handles are selected:
	///   LeftButtonPressEvent - select the appropriate handle
	///   LeftButtonReleaseEvent - release the currently selected handle
	///   MouseMoveEvent - move the handle
	/// In all the cases, independent of what is picked, the widget responds to the
	/// following VTK events:
	///   LeftButtonPressEvent - start select action
	///   LeftButtonReleaseEvent - stop select action
	/// &lt;/pre&gt;
	///
	/// @par Event Bindings:
	/// Note that the event bindings described above can be changed using this
	/// class's vtkWidgetEventTranslator. This class translates VTK events
	/// into the vtkFinitePlaneWidget's widget events:
	/// &lt;pre&gt;
	///   vtkWidgetEvent::Select -- some part of the widget has been selected
	///   vtkWidgetEvent::EndSelect -- the selection process has completed
	///   vtkWidgetEvent::Move -- a request for motion has been invoked
	/// &lt;/pre&gt;
	///
	/// @par Event Bindings:
	/// In turn, when these widget events are processed, the vtkFinitePlaneWidget
	/// invokes the following VTK events on itself (which observers can listen for):
	/// &lt;pre&gt;
	///   vtkCommand::StartInteractionEvent (on vtkWidgetEvent::Select)
	///   vtkCommand::EndInteractionEvent (on vtkWidgetEvent::EndSelect)
	///   vtkCommand::InteractionEvent (on vtkWidgetEvent::Move)
	/// &lt;/pre&gt;
	/// </remarks>
	/// <seealso>
	///
	/// vtkFinitePlaneRepresentation
	/// </seealso>
	// Token: 0x02000319 RID: 793
	public class vtkFinitePlaneWidget : vtkAbstractWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06008E6F RID: 36463 RVA: 0x000CAFBC File Offset: 0x000C91BC
		static vtkFinitePlaneWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFinitePlaneWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFinitePlaneWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06008E70 RID: 36464 RVA: 0x000CAFE4 File Offset: 0x000C91E4
		public vtkFinitePlaneWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06008E71 RID: 36465
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFinitePlaneWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x06008E72 RID: 36466 RVA: 0x000CAFF4 File Offset: 0x000C91F4
		public new static vtkFinitePlaneWidget New()
		{
			vtkFinitePlaneWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFinitePlaneWidget.vtkFinitePlaneWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFinitePlaneWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x06008E73 RID: 36467 RVA: 0x000CB048 File Offset: 0x000C9248
		public vtkFinitePlaneWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkFinitePlaneWidget.vtkFinitePlaneWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06008E74 RID: 36468 RVA: 0x000CB08C File Offset: 0x000C928C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06008E75 RID: 36469
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFinitePlaneWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Create the default widget representation if one is not set. By default,
		/// this is an instance of the vtkFinitePlaneRepresentation class.
		/// </summary>
		// Token: 0x06008E76 RID: 36470 RVA: 0x000CB097 File Offset: 0x000C9297
		public override void CreateDefaultRepresentation()
		{
			vtkFinitePlaneWidget.vtkFinitePlaneWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06008E77 RID: 36471
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFinitePlaneWidget_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x06008E78 RID: 36472 RVA: 0x000CB0A8 File Offset: 0x000C92A8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkFinitePlaneWidget.vtkFinitePlaneWidget_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06008E79 RID: 36473
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFinitePlaneWidget_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x06008E7A RID: 36474 RVA: 0x000CB0C8 File Offset: 0x000C92C8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkFinitePlaneWidget.vtkFinitePlaneWidget_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06008E7B RID: 36475
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFinitePlaneWidget_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x06008E7C RID: 36476 RVA: 0x000CB0E4 File Offset: 0x000C92E4
		public override int IsA(string type)
		{
			return vtkFinitePlaneWidget.vtkFinitePlaneWidget_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06008E7D RID: 36477
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFinitePlaneWidget_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x06008E7E RID: 36478 RVA: 0x000CB104 File Offset: 0x000C9304
		public new static int IsTypeOf(string type)
		{
			return vtkFinitePlaneWidget.vtkFinitePlaneWidget_IsTypeOf_05(type);
		}

		// Token: 0x06008E7F RID: 36479
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFinitePlaneWidget_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x06008E80 RID: 36480 RVA: 0x000CB120 File Offset: 0x000C9320
		public new vtkFinitePlaneWidget NewInstance()
		{
			vtkFinitePlaneWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFinitePlaneWidget.vtkFinitePlaneWidget_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFinitePlaneWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06008E81 RID: 36481
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFinitePlaneWidget_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x06008E82 RID: 36482 RVA: 0x000CB17C File Offset: 0x000C937C
		public new static vtkFinitePlaneWidget SafeDownCast(vtkObjectBase o)
		{
			vtkFinitePlaneWidget vtkFinitePlaneWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFinitePlaneWidget.vtkFinitePlaneWidget_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFinitePlaneWidget = (vtkFinitePlaneWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFinitePlaneWidget.Register(null);
				}
			}
			return vtkFinitePlaneWidget;
		}

		// Token: 0x06008E83 RID: 36483
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFinitePlaneWidget_SetRepresentation_09(HandleRef pThis, HandleRef r);

		/// <summary>
		/// Specify an instance of vtkWidgetRepresentation used to represent this
		/// widget in the scene. Note that the representation is a subclass of vtkProp
		/// so it can be added to the renderer independent of the widget.
		/// </summary>
		// Token: 0x06008E84 RID: 36484 RVA: 0x000CB1FC File Offset: 0x000C93FC
		public void SetRepresentation(vtkFinitePlaneRepresentation r)
		{
			vtkFinitePlaneWidget.vtkFinitePlaneWidget_SetRepresentation_09(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000BEC RID: 3052
		public new const string MRFullTypeName = "Kitware.VTK.vtkFinitePlaneWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000BED RID: 3053
		public new static readonly string MRClassNameKey = "class vtkFinitePlaneWidget";
	}
}
