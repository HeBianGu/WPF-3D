using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAngleWidget
	/// </summary>
	/// <remarks>
	///    measure the angle between two rays (defined by three points)
	///
	/// The vtkAngleWidget is used to measure the angle between two rays (defined
	/// by three points). The three points (two end points and a center)
	/// can be positioned independently, and when they are released, a special
	/// PlacePointEvent is invoked so that special operations may be take to
	/// reposition the point (snap to grid, etc.) The widget has two different
	/// modes of interaction: when initially defined (i.e., placing the three
	/// points) and then a manipulate mode (adjusting the position of the
	/// three points).
	///
	/// To use this widget, specify an instance of vtkAngleWidget and a
	/// representation (a subclass of vtkAngleRepresentation). The widget is
	/// implemented using three instances of vtkHandleWidget which are used to
	/// position the three points. The representations for these handle widgets
	/// are provided by the vtkAngleRepresentation.
	///
	/// @par Event Bindings:
	/// By default, the widget responds to the following VTK events (i.e., it
	/// watches the vtkRenderWindowInteractor for these events):
	/// &lt;pre&gt;
	///   LeftButtonPressEvent - add a point or select a handle
	///   MouseMoveEvent - position the second or third point, or move a handle
	///   LeftButtonReleaseEvent - release the selected handle
	/// &lt;/pre&gt;
	///
	/// @par Event Bindings:
	/// Note that the event bindings described above can be changed using this
	/// class's vtkWidgetEventTranslator. This class translates VTK events
	/// into the vtkAngleWidget's widget events:
	/// &lt;pre&gt;
	///   vtkWidgetEvent::AddPoint -- add one point; depending on the state
	///                               it may the first, second or third point
	///                               added. Or, if near a handle, select the handle.
	///   vtkWidgetEvent::Move -- position the second or third point, or move the
	///                           handle depending on the state.
	///   vtkWidgetEvent::EndSelect -- the handle manipulation process has completed.
	/// &lt;/pre&gt;
	///
	/// @par Event Bindings:
	/// This widget invokes the following VTK events on itself (which observers
	/// can listen for):
	/// &lt;pre&gt;
	///   vtkCommand::StartInteractionEvent (beginning to interact)
	///   vtkCommand::EndInteractionEvent (completing interaction)
	///   vtkCommand::InteractionEvent (moving a handle)
	///   vtkCommand::PlacePointEvent (after a point is positioned;
	///                                call data includes handle id (0,1,2))
	/// &lt;/pre&gt;
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkHandleWidget vtkDistanceWidget
	/// </seealso>
	// Token: 0x020002BB RID: 699
	public class vtkAngleWidget : vtkAbstractWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06007E95 RID: 32405 RVA: 0x000B5993 File Offset: 0x000B3B93
		static vtkAngleWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAngleWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAngleWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06007E96 RID: 32406 RVA: 0x000B59BB File Offset: 0x000B3BBB
		public vtkAngleWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06007E97 RID: 32407
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAngleWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06007E98 RID: 32408 RVA: 0x000B59CC File Offset: 0x000B3BCC
		public new static vtkAngleWidget New()
		{
			vtkAngleWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAngleWidget.vtkAngleWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAngleWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06007E99 RID: 32409 RVA: 0x000B5A20 File Offset: 0x000B3C20
		public vtkAngleWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAngleWidget.vtkAngleWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06007E9A RID: 32410 RVA: 0x000B5A64 File Offset: 0x000B3C64
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06007E9B RID: 32411
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Create the default widget representation if one is not set.
		/// </summary>
		// Token: 0x06007E9C RID: 32412 RVA: 0x000B5A6F File Offset: 0x000B3C6F
		public override void CreateDefaultRepresentation()
		{
			vtkAngleWidget.vtkAngleWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06007E9D RID: 32413
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAngleWidget_GetAngleRepresentation_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the representation as a vtkAngleRepresentation.
		/// </summary>
		// Token: 0x06007E9E RID: 32414 RVA: 0x000B5A80 File Offset: 0x000B3C80
		public vtkAngleRepresentation GetAngleRepresentation()
		{
			vtkAngleRepresentation vtkAngleRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAngleWidget.vtkAngleWidget_GetAngleRepresentation_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAngleRepresentation = (vtkAngleRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAngleRepresentation.Register(null);
				}
			}
			return vtkAngleRepresentation;
		}

		// Token: 0x06007E9F RID: 32415
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAngleWidget_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x06007EA0 RID: 32416 RVA: 0x000B5AF0 File Offset: 0x000B3CF0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAngleWidget.vtkAngleWidget_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06007EA1 RID: 32417
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAngleWidget_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x06007EA2 RID: 32418 RVA: 0x000B5B10 File Offset: 0x000B3D10
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAngleWidget.vtkAngleWidget_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06007EA3 RID: 32419
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAngleWidget_GetWidgetState_05(HandleRef pThis);

		/// <summary>
		/// Return the current widget state.
		/// </summary>
		// Token: 0x06007EA4 RID: 32420 RVA: 0x000B5B2C File Offset: 0x000B3D2C
		public virtual int GetWidgetState()
		{
			return vtkAngleWidget.vtkAngleWidget_GetWidgetState_05(base.GetCppThis());
		}

		// Token: 0x06007EA5 RID: 32421
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAngleWidget_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x06007EA6 RID: 32422 RVA: 0x000B5B4C File Offset: 0x000B3D4C
		public override int IsA(string type)
		{
			return vtkAngleWidget.vtkAngleWidget_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06007EA7 RID: 32423
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAngleWidget_IsAngleValid_07(HandleRef pThis);

		/// <summary>
		/// A flag indicates whether the angle is valid. The angle value only becomes
		/// valid after two of the three points are placed.
		/// </summary>
		// Token: 0x06007EA8 RID: 32424 RVA: 0x000B5B6C File Offset: 0x000B3D6C
		public int IsAngleValid()
		{
			return vtkAngleWidget.vtkAngleWidget_IsAngleValid_07(base.GetCppThis());
		}

		// Token: 0x06007EA9 RID: 32425
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAngleWidget_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x06007EAA RID: 32426 RVA: 0x000B5B8C File Offset: 0x000B3D8C
		public new static int IsTypeOf(string type)
		{
			return vtkAngleWidget.vtkAngleWidget_IsTypeOf_08(type);
		}

		// Token: 0x06007EAB RID: 32427
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAngleWidget_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x06007EAC RID: 32428 RVA: 0x000B5BA8 File Offset: 0x000B3DA8
		public new vtkAngleWidget NewInstance()
		{
			vtkAngleWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAngleWidget.vtkAngleWidget_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAngleWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06007EAD RID: 32429
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAngleWidget_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x06007EAE RID: 32430 RVA: 0x000B5C04 File Offset: 0x000B3E04
		public new static vtkAngleWidget SafeDownCast(vtkObjectBase o)
		{
			vtkAngleWidget vtkAngleWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAngleWidget.vtkAngleWidget_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAngleWidget = (vtkAngleWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAngleWidget.Register(null);
				}
			}
			return vtkAngleWidget;
		}

		// Token: 0x06007EAF RID: 32431
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleWidget_SetEnabled_12(HandleRef pThis, int arg0);

		/// <summary>
		/// The method for activating and deactivating this widget. This method
		/// must be overridden because it is a composite widget and does more than
		/// its superclasses' vtkAbstractWidget::SetEnabled() method.
		/// </summary>
		// Token: 0x06007EB0 RID: 32432 RVA: 0x000B5C83 File Offset: 0x000B3E83
		public override void SetEnabled(int arg0)
		{
			vtkAngleWidget.vtkAngleWidget_SetEnabled_12(base.GetCppThis(), arg0);
		}

		// Token: 0x06007EB1 RID: 32433
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleWidget_SetProcessEvents_13(HandleRef pThis, int arg0);

		/// <summary>
		/// Methods to change the whether the widget responds to interaction.
		/// Overridden to pass the state to component widgets.
		/// </summary>
		// Token: 0x06007EB2 RID: 32434 RVA: 0x000B5C93 File Offset: 0x000B3E93
		public override void SetProcessEvents(int arg0)
		{
			vtkAngleWidget.vtkAngleWidget_SetProcessEvents_13(base.GetCppThis(), arg0);
		}

		// Token: 0x06007EB3 RID: 32435
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleWidget_SetRepresentation_14(HandleRef pThis, HandleRef r);

		/// <summary>
		/// Specify an instance of vtkWidgetRepresentation used to represent this
		/// widget in the scene. Note that the representation is a subclass of vtkProp
		/// so it can be added to the renderer independent of the widget.
		/// </summary>
		// Token: 0x06007EB4 RID: 32436 RVA: 0x000B5CA4 File Offset: 0x000B3EA4
		public void SetRepresentation(vtkAngleRepresentation r)
		{
			vtkAngleWidget.vtkAngleWidget_SetRepresentation_14(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}

		// Token: 0x06007EB5 RID: 32437
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleWidget_SetWidgetStateToManipulate_15(HandleRef pThis);

		/// <summary>
		/// Set the state of the widget. If the state is set to "Manipulate" then it
		/// is assumed that the widget and its representation will be initialized
		/// programmatically and is not interactively placed. Initially the widget
		/// state is set to "Start" which means nothing will appear and the user
		/// must interactively place the widget with repeated mouse selections. Set
		/// the state to "Start" if you want interactive placement. Generally state
		/// changes must be followed by a Render() for things to visually take
		/// effect.
		/// </summary>
		// Token: 0x06007EB6 RID: 32438 RVA: 0x000B5CD3 File Offset: 0x000B3ED3
		public virtual void SetWidgetStateToManipulate()
		{
			vtkAngleWidget.vtkAngleWidget_SetWidgetStateToManipulate_15(base.GetCppThis());
		}

		// Token: 0x06007EB7 RID: 32439
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleWidget_SetWidgetStateToStart_16(HandleRef pThis);

		/// <summary>
		/// Set the state of the widget. If the state is set to "Manipulate" then it
		/// is assumed that the widget and its representation will be initialized
		/// programmatically and is not interactively placed. Initially the widget
		/// state is set to "Start" which means nothing will appear and the user
		/// must interactively place the widget with repeated mouse selections. Set
		/// the state to "Start" if you want interactive placement. Generally state
		/// changes must be followed by a Render() for things to visually take
		/// effect.
		/// </summary>
		// Token: 0x06007EB8 RID: 32440 RVA: 0x000B5CE2 File Offset: 0x000B3EE2
		public virtual void SetWidgetStateToStart()
		{
			vtkAngleWidget.vtkAngleWidget_SetWidgetStateToStart_16(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000AAA RID: 2730
		public new const string MRFullTypeName = "Kitware.VTK.vtkAngleWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000AAB RID: 2731
		public new static readonly string MRClassNameKey = "class vtkAngleWidget";

		/// <summary>
		/// Enum defining the state of the widget. By default the widget is in Start mode,
		/// and expects to be interactively placed. While placing the points the widget
		/// transitions to Define state. Once placed, the widget enters the Manipulate state.
		/// </summary>
		// Token: 0x020002BC RID: 700
		public enum Define_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000AAD RID: 2733
			Define = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000AAE RID: 2734
			Manipulate,
			/// <summary>enum member</summary>
			// Token: 0x04000AAF RID: 2735
			Start = 0
		}
	}
}
