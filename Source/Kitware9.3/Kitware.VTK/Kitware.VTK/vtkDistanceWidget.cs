using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDistanceWidget
	/// </summary>
	/// <remarks>
	///    measure the distance between two points
	///
	/// The vtkDistanceWidget is used to measure the distance between two points.
	/// The two end points can be positioned independently, and when they are
	/// released, a special PlacePointEvent is invoked so that special operations
	/// may be take to reposition the point (snap to grid, etc.) The widget has
	/// two different modes of interaction: when initially defined (i.e., placing
	/// the two points) and then a manipulate mode (adjusting the position of
	/// the two points).
	///
	/// To use this widget, specify an instance of vtkDistanceWidget and a
	/// representation (a subclass of vtkDistanceRepresentation). The widget is
	/// implemented using two instances of vtkHandleWidget which are used to
	/// position the end points of the line. The representations for these two
	/// handle widgets are provided by the vtkDistanceRepresentation.
	///
	/// @par Event Bindings:
	/// By default, the widget responds to the following VTK events (i.e., it
	/// watches the vtkRenderWindowInteractor for these events):
	/// &lt;pre&gt;
	///   LeftButtonPressEvent - add a point or select a handle
	///   MouseMoveEvent - position the second point or move a handle
	///   LeftButtonReleaseEvent - release the handle
	/// &lt;/pre&gt;
	///
	/// @par Event Bindings:
	/// Note that the event bindings described above can be changed using this
	/// class's vtkWidgetEventTranslator. This class translates VTK events
	/// into the vtkDistanceWidget's widget events:
	/// &lt;pre&gt;
	///   vtkWidgetEvent::AddPoint -- add one point; depending on the state
	///                               it may the first or second point added. Or,
	///                               if near a handle, select the handle.
	///   vtkWidgetEvent::Move -- move the second point or handle depending on the state.
	///   vtkWidgetEvent::EndSelect -- the handle manipulation process has completed.
	/// &lt;/pre&gt;
	///
	/// @par Event Bindings:
	/// This widget invokes the following VTK events on itself (which observers
	/// can listen for):
	/// &lt;pre&gt;
	///   vtkCommand::StartInteractionEvent (beginning to interact)
	///   vtkCommand::EndInteractionEvent (completing interaction)
	///   vtkCommand::InteractionEvent (moving after selecting something)
	///   vtkCommand::PlacePointEvent (after point is positioned;
	///                                call data includes handle id (0,1))
	/// &lt;/pre&gt;
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkHandleWidget
	/// </seealso>
	// Token: 0x02000310 RID: 784
	public class vtkDistanceWidget : vtkAbstractWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06008D38 RID: 36152 RVA: 0x000C9515 File Offset: 0x000C7715
		static vtkDistanceWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDistanceWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDistanceWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06008D39 RID: 36153 RVA: 0x000C953D File Offset: 0x000C773D
		public vtkDistanceWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06008D3A RID: 36154
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDistanceWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06008D3B RID: 36155 RVA: 0x000C954C File Offset: 0x000C774C
		public new static vtkDistanceWidget New()
		{
			vtkDistanceWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDistanceWidget.vtkDistanceWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDistanceWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06008D3C RID: 36156 RVA: 0x000C95A0 File Offset: 0x000C77A0
		public vtkDistanceWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDistanceWidget.vtkDistanceWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06008D3D RID: 36157 RVA: 0x000C95E4 File Offset: 0x000C77E4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06008D3E RID: 36158
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Create the default widget representation if one is not set.
		/// </summary>
		// Token: 0x06008D3F RID: 36159 RVA: 0x000C95EF File Offset: 0x000C77EF
		public override void CreateDefaultRepresentation()
		{
			vtkDistanceWidget.vtkDistanceWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06008D40 RID: 36160
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDistanceWidget_GetDistanceRepresentation_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the representation as a vtkDistanceRepresentation.
		/// </summary>
		// Token: 0x06008D41 RID: 36161 RVA: 0x000C9600 File Offset: 0x000C7800
		public vtkDistanceRepresentation GetDistanceRepresentation()
		{
			vtkDistanceRepresentation vtkDistanceRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDistanceWidget.vtkDistanceWidget_GetDistanceRepresentation_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDistanceRepresentation = (vtkDistanceRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDistanceRepresentation.Register(null);
				}
			}
			return vtkDistanceRepresentation;
		}

		// Token: 0x06008D42 RID: 36162
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDistanceWidget_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x06008D43 RID: 36163 RVA: 0x000C9670 File Offset: 0x000C7870
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDistanceWidget.vtkDistanceWidget_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06008D44 RID: 36164
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDistanceWidget_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x06008D45 RID: 36165 RVA: 0x000C9690 File Offset: 0x000C7890
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDistanceWidget.vtkDistanceWidget_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06008D46 RID: 36166
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDistanceWidget_GetWidgetState_05(HandleRef pThis);

		/// <summary>
		/// Return the current widget state.
		/// </summary>
		// Token: 0x06008D47 RID: 36167 RVA: 0x000C96AC File Offset: 0x000C78AC
		public virtual int GetWidgetState()
		{
			return vtkDistanceWidget.vtkDistanceWidget_GetWidgetState_05(base.GetCppThis());
		}

		// Token: 0x06008D48 RID: 36168
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDistanceWidget_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x06008D49 RID: 36169 RVA: 0x000C96CC File Offset: 0x000C78CC
		public override int IsA(string type)
		{
			return vtkDistanceWidget.vtkDistanceWidget_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06008D4A RID: 36170
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDistanceWidget_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x06008D4B RID: 36171 RVA: 0x000C96EC File Offset: 0x000C78EC
		public new static int IsTypeOf(string type)
		{
			return vtkDistanceWidget.vtkDistanceWidget_IsTypeOf_07(type);
		}

		// Token: 0x06008D4C RID: 36172
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDistanceWidget_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x06008D4D RID: 36173 RVA: 0x000C9708 File Offset: 0x000C7908
		public new vtkDistanceWidget NewInstance()
		{
			vtkDistanceWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDistanceWidget.vtkDistanceWidget_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDistanceWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06008D4E RID: 36174
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDistanceWidget_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x06008D4F RID: 36175 RVA: 0x000C9764 File Offset: 0x000C7964
		public new static vtkDistanceWidget SafeDownCast(vtkObjectBase o)
		{
			vtkDistanceWidget vtkDistanceWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDistanceWidget.vtkDistanceWidget_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDistanceWidget = (vtkDistanceWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDistanceWidget.Register(null);
				}
			}
			return vtkDistanceWidget;
		}

		// Token: 0x06008D50 RID: 36176
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceWidget_SetEnabled_11(HandleRef pThis, int arg0);

		/// <summary>
		/// The method for activating and deactivating this widget. This method
		/// must be overridden because it is a composite widget and does more than
		/// its superclasses' vtkAbstractWidget::SetEnabled() method.
		/// </summary>
		// Token: 0x06008D51 RID: 36177 RVA: 0x000C97E3 File Offset: 0x000C79E3
		public override void SetEnabled(int arg0)
		{
			vtkDistanceWidget.vtkDistanceWidget_SetEnabled_11(base.GetCppThis(), arg0);
		}

		// Token: 0x06008D52 RID: 36178
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceWidget_SetProcessEvents_12(HandleRef pThis, int arg0);

		/// <summary>
		/// Methods to change the whether the widget responds to interaction.
		/// Overridden to pass the state to component widgets.
		/// </summary>
		// Token: 0x06008D53 RID: 36179 RVA: 0x000C97F3 File Offset: 0x000C79F3
		public override void SetProcessEvents(int arg0)
		{
			vtkDistanceWidget.vtkDistanceWidget_SetProcessEvents_12(base.GetCppThis(), arg0);
		}

		// Token: 0x06008D54 RID: 36180
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceWidget_SetRepresentation_13(HandleRef pThis, HandleRef r);

		/// <summary>
		/// Specify an instance of vtkWidgetRepresentation used to represent this
		/// widget in the scene. Note that the representation is a subclass of vtkProp
		/// so it can be added to the renderer independent of the widget.
		/// </summary>
		// Token: 0x06008D55 RID: 36181 RVA: 0x000C9804 File Offset: 0x000C7A04
		public void SetRepresentation(vtkDistanceRepresentation r)
		{
			vtkDistanceWidget.vtkDistanceWidget_SetRepresentation_13(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}

		// Token: 0x06008D56 RID: 36182
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceWidget_SetWidgetStateToManipulate_14(HandleRef pThis);

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
		// Token: 0x06008D57 RID: 36183 RVA: 0x000C9833 File Offset: 0x000C7A33
		public virtual void SetWidgetStateToManipulate()
		{
			vtkDistanceWidget.vtkDistanceWidget_SetWidgetStateToManipulate_14(base.GetCppThis());
		}

		// Token: 0x06008D58 RID: 36184
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceWidget_SetWidgetStateToStart_15(HandleRef pThis);

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
		// Token: 0x06008D59 RID: 36185 RVA: 0x000C9842 File Offset: 0x000C7A42
		public virtual void SetWidgetStateToStart()
		{
			vtkDistanceWidget.vtkDistanceWidget_SetWidgetStateToStart_15(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000BCE RID: 3022
		public new const string MRFullTypeName = "Kitware.VTK.vtkDistanceWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000BCF RID: 3023
		public new static readonly string MRClassNameKey = "class vtkDistanceWidget";

		/// <summary>
		/// Description:
		/// Enum defining the state of the widget. By default the widget is in Start mode,
		/// and expects to be interactively placed. While placing the points the widget
		/// transitions to Define state. Once placed, the widget enters the Manipulate state.
		/// </summary>
		// Token: 0x02000311 RID: 785
		public enum Define_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000BD1 RID: 3025
			Define = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000BD2 RID: 3026
			Manipulate,
			/// <summary>enum member</summary>
			// Token: 0x04000BD3 RID: 3027
			Start = 0
		}
	}
}
