using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLineWidget2
	/// </summary>
	/// <remarks>
	///    3D widget for manipulating a finite, straight line
	///
	/// This 3D widget defines a straight line that can be interactively placed in
	/// a scene. The widget is assumed to consist of two parts: 1) two end points
	/// and 2) a straight line connecting the two points. (The representation
	/// paired with this widget determines the actual geometry of the widget.) The
	/// positioning of the two end points is facilitated by using vtkHandleWidgets
	/// to position the points.
	///
	/// To use this widget, you generally pair it with a vtkLineRepresentation
	/// (or a subclass). Various options are available in the representation for
	/// controlling how the widget appears, and how the widget functions.
	///
	/// @par Event Bindings:
	/// By default, the widget responds to the following VTK events (i.e., it
	/// watches the vtkRenderWindowInteractor for these events):
	/// &lt;pre&gt;
	/// If one of the two end points are selected:
	///   LeftButtonPressEvent - activate the associated handle widget
	///   LeftButtonReleaseEvent - release the handle widget associated with the point
	///   MouseMoveEvent - move the point
	/// If the line is selected:
	///   LeftButtonPressEvent - activate a handle widget associated with the line
	///   LeftButtonReleaseEvent - release the handle widget associated with the line
	///   MouseMoveEvent - translate the line
	/// In all the cases, independent of what is picked, the widget responds to the
	/// following VTK events:
	///   MiddleButtonPressEvent - translate the widget
	///   MiddleButtonReleaseEvent - release the widget
	///   RightButtonPressEvent - scale the widget's representation
	///   RightButtonReleaseEvent - stop scaling the widget
	///   MouseMoveEvent - scale (if right button) or move (if middle button) the widget
	/// &lt;/pre&gt;
	///
	/// @par Event Bindings:
	/// Note that the event bindings described above can be changed using this
	/// class's vtkWidgetEventTranslator. This class translates VTK events
	/// into the vtkLineWidget2's widget events:
	/// &lt;pre&gt;
	///   vtkWidgetEvent::Select -- some part of the widget has been selected
	///   vtkWidgetEvent::EndSelect -- the selection process has completed
	///   vtkWidgetEvent::Move -- a request for slider motion has been invoked
	/// &lt;/pre&gt;
	///
	/// @par Event Bindings:
	/// In turn, when these widget events are processed, the vtkLineWidget2
	/// invokes the following VTK events on itself (which observers can listen for):
	/// &lt;pre&gt;
	///   vtkCommand::StartInteractionEvent (on vtkWidgetEvent::Select)
	///   vtkCommand::EndInteractionEvent (on vtkWidgetEvent::EndSelect)
	///   vtkCommand::InteractionEvent (on vtkWidgetEvent::Move)
	/// &lt;/pre&gt;
	///
	///
	///
	/// @par Event Bindings:
	/// This class, and vtkLineRepresentation, are next generation VTK widgets. An
	/// earlier version of this functionality was defined in the class
	/// vtkLineWidget.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkLineRepresentation vtkLineWidget vtk3DWidget vtkImplicitPlaneWidget
	/// vtkImplicitPlaneWidget2
	/// </seealso>
	// Token: 0x0200033A RID: 826
	public class vtkLineWidget2 : vtkAbstractWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600960D RID: 38413 RVA: 0x000D47B3 File Offset: 0x000D29B3
		static vtkLineWidget2()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLineWidget2.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLineWidget2"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600960E RID: 38414 RVA: 0x000D47DB File Offset: 0x000D29DB
		public vtkLineWidget2(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600960F RID: 38415
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLineWidget2_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x06009610 RID: 38416 RVA: 0x000D47EC File Offset: 0x000D29EC
		public new static vtkLineWidget2 New()
		{
			vtkLineWidget2 result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLineWidget2.vtkLineWidget2_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLineWidget2)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x06009611 RID: 38417 RVA: 0x000D4840 File Offset: 0x000D2A40
		public vtkLineWidget2() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLineWidget2.vtkLineWidget2_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06009612 RID: 38418 RVA: 0x000D4884 File Offset: 0x000D2A84
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06009613 RID: 38419
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineWidget2_CreateDefaultRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Create the default widget representation if one is not set.
		/// </summary>
		// Token: 0x06009614 RID: 38420 RVA: 0x000D488F File Offset: 0x000D2A8F
		public override void CreateDefaultRepresentation()
		{
			vtkLineWidget2.vtkLineWidget2_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06009615 RID: 38421
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLineWidget2_GetLineRepresentation_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the representation as a vtkLineRepresentation.
		/// </summary>
		// Token: 0x06009616 RID: 38422 RVA: 0x000D48A0 File Offset: 0x000D2AA0
		public vtkLineRepresentation GetLineRepresentation()
		{
			vtkLineRepresentation vtkLineRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLineWidget2.vtkLineWidget2_GetLineRepresentation_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLineRepresentation = (vtkLineRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLineRepresentation.Register(null);
				}
			}
			return vtkLineRepresentation;
		}

		// Token: 0x06009617 RID: 38423
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLineWidget2_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x06009618 RID: 38424 RVA: 0x000D4910 File Offset: 0x000D2B10
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLineWidget2.vtkLineWidget2_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06009619 RID: 38425
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLineWidget2_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x0600961A RID: 38426 RVA: 0x000D4930 File Offset: 0x000D2B30
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLineWidget2.vtkLineWidget2_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0600961B RID: 38427
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLineWidget2_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x0600961C RID: 38428 RVA: 0x000D494C File Offset: 0x000D2B4C
		public override int IsA(string type)
		{
			return vtkLineWidget2.vtkLineWidget2_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600961D RID: 38429
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLineWidget2_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x0600961E RID: 38430 RVA: 0x000D496C File Offset: 0x000D2B6C
		public new static int IsTypeOf(string type)
		{
			return vtkLineWidget2.vtkLineWidget2_IsTypeOf_06(type);
		}

		// Token: 0x0600961F RID: 38431
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLineWidget2_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x06009620 RID: 38432 RVA: 0x000D4988 File Offset: 0x000D2B88
		public new vtkLineWidget2 NewInstance()
		{
			vtkLineWidget2 result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLineWidget2.vtkLineWidget2_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLineWidget2)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06009621 RID: 38433
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLineWidget2_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x06009622 RID: 38434 RVA: 0x000D49E4 File Offset: 0x000D2BE4
		public new static vtkLineWidget2 SafeDownCast(vtkObjectBase o)
		{
			vtkLineWidget2 vtkLineWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLineWidget2.vtkLineWidget2_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLineWidget = (vtkLineWidget2)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLineWidget.Register(null);
				}
			}
			return vtkLineWidget;
		}

		// Token: 0x06009623 RID: 38435
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineWidget2_SetEnabled_10(HandleRef pThis, int enabling);

		/// <summary>
		/// Override superclasses' SetEnabled() method because the line
		/// widget must enable its internal handle widgets.
		/// </summary>
		// Token: 0x06009624 RID: 38436 RVA: 0x000D4A63 File Offset: 0x000D2C63
		public override void SetEnabled(int enabling)
		{
			vtkLineWidget2.vtkLineWidget2_SetEnabled_10(base.GetCppThis(), enabling);
		}

		// Token: 0x06009625 RID: 38437
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineWidget2_SetProcessEvents_11(HandleRef pThis, int arg0);

		/// <summary>
		/// Methods to change the whether the widget responds to interaction.
		/// Overridden to pass the state to component widgets.
		/// </summary>
		// Token: 0x06009626 RID: 38438 RVA: 0x000D4A73 File Offset: 0x000D2C73
		public override void SetProcessEvents(int arg0)
		{
			vtkLineWidget2.vtkLineWidget2_SetProcessEvents_11(base.GetCppThis(), arg0);
		}

		// Token: 0x06009627 RID: 38439
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineWidget2_SetRepresentation_12(HandleRef pThis, HandleRef r);

		/// <summary>
		/// Specify an instance of vtkWidgetRepresentation used to represent this
		/// widget in the scene. Note that the representation is a subclass of vtkProp
		/// so it can be added to the renderer independent of the widget.
		/// </summary>
		// Token: 0x06009628 RID: 38440 RVA: 0x000D4A84 File Offset: 0x000D2C84
		public void SetRepresentation(vtkLineRepresentation r)
		{
			vtkLineWidget2.vtkLineWidget2_SetRepresentation_12(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C50 RID: 3152
		public new const string MRFullTypeName = "Kitware.VTK.vtkLineWidget2";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C51 RID: 3153
		public new static readonly string MRClassNameKey = "class vtkLineWidget2";
	}
}
