using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBiDimensionalWidget
	/// </summary>
	/// <remarks>
	///    measure the bi-dimensional lengths of an object
	///
	/// The vtkBiDimensionalWidget is used to measure the bi-dimensional length of
	/// an object. The bi-dimensional measure is defined by two finite, orthogonal
	/// lines that intersect within the finite extent of both lines.
	/// The lengths of these two lines gives the bi-dimensional measure. Each line
	/// is defined by two handle widgets at the end points of each line.
	///
	/// The orthogonal constraint on the two lines limits how the four end points
	/// can be positioned. The first two points can be placed arbitrarily to define
	/// the first line (similar to vtkDistanceWidget). The placement of the third
	/// point is limited by the finite extent of the first line. As the third point
	/// is placed, the fourth point is placed on the opposite side of the first
	/// line. Once the third point is placed, the second line is defined since the
	/// fourth point is defined at the same time, but the fourth point can be moved
	/// along the second line (i.e., maintaining the orthogonal relationship between
	/// the two lines). Once defined, any of the four points can be moved along
	/// their constraint lines. Also, each line can be translated along the other
	/// line (in an orthogonal direction), and the whole bi-dimensional widget can
	/// be rotated about its center point (see the description of the event
	/// bindings). Finally, selecting the point where the two orthogonal axes
	/// intersect, the entire widget can be translated in any direction.
	///
	/// Placement of any point results in a special PlacePointEvent invocation so
	/// that special operations may be performed to reposition the point. Motion of
	/// any point, moving the lines, or rotating the widget cause InteractionEvents
	/// to be invoked. Note that the widget has two fundamental modes: a define mode
	/// (when initially placing the points) and a manipulate mode (after the points
	/// are placed). Line translation and rotation are only possible in manipulate
	/// mode.
	///
	/// To use this widget, specify an instance of vtkBiDimensionalWidget and a
	/// representation (e.g., vtkBiDimensionalRepresentation2D). The widget is
	/// implemented using four instances of vtkHandleWidget which are used to
	/// position the end points of the two intersecting lines. The representations
	/// for these handle widgets are provided by the vtkBiDimensionalRepresentation
	/// class.
	///
	/// @par Event Bindings:
	/// By default, the widget responds to the following VTK events (i.e., it
	/// watches the vtkRenderWindowInteractor for these events):
	/// &lt;pre&gt;
	///   LeftButtonPressEvent - define a point or manipulate a handle, line,
	///                          perform rotation or translate the widget.
	///   MouseMoveEvent - position the points, move a line, rotate or translate the widget
	///   LeftButtonReleaseEvent - release the selected handle and end interaction
	/// &lt;/pre&gt;
	///
	/// @par Event Bindings:
	/// Note that the event bindings described above can be changed using this
	/// class's vtkWidgetEventTranslator. This class translates VTK events
	/// into the vtkBiDimensionalWidget's widget events:
	/// &lt;pre&gt;
	///   vtkWidgetEvent::AddPoint -- (In Define mode:) Add one point; depending on the
	///                               state it may the first, second, third or fourth
	///                               point added. (In Manipulate mode:) If near a handle,
	///                               select the handle. Or if near a line, select the line.
	///   vtkWidgetEvent::Move -- (In Define mode:) Position the second, third or fourth
	///                           point. (In Manipulate mode:) Move the handle, line or widget.
	///   vtkWidgetEvent::EndSelect -- the manipulation process has completed.
	/// &lt;/pre&gt;
	///
	/// @par Event Bindings:
	/// This widget invokes the following VTK events on itself (which observers
	/// can listen for):
	/// &lt;pre&gt;
	///   vtkCommand::StartInteractionEvent (beginning to interact)
	///   vtkCommand::EndInteractionEvent (completing interaction)
	///   vtkCommand::InteractionEvent (moving a handle, line or performing rotation)
	///   vtkCommand::PlacePointEvent (after a point is positioned;
	///                                call data includes handle id (0,1,2,4))
	/// &lt;/pre&gt;
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkHandleWidget vtkDistanceWidget
	/// </seealso>
	// Token: 0x020002CB RID: 715
	public class vtkBiDimensionalWidget : vtkAbstractWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060080B5 RID: 32949 RVA: 0x000B896F File Offset: 0x000B6B6F
		static vtkBiDimensionalWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBiDimensionalWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBiDimensionalWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060080B6 RID: 32950 RVA: 0x000B8997 File Offset: 0x000B6B97
		public vtkBiDimensionalWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060080B7 RID: 32951
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiDimensionalWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x060080B8 RID: 32952 RVA: 0x000B89A8 File Offset: 0x000B6BA8
		public new static vtkBiDimensionalWidget New()
		{
			vtkBiDimensionalWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBiDimensionalWidget.vtkBiDimensionalWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBiDimensionalWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x060080B9 RID: 32953 RVA: 0x000B89FC File Offset: 0x000B6BFC
		public vtkBiDimensionalWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBiDimensionalWidget.vtkBiDimensionalWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060080BA RID: 32954 RVA: 0x000B8A40 File Offset: 0x000B6C40
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060080BB RID: 32955
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiDimensionalWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Create the default widget representation if one is not set.
		/// </summary>
		// Token: 0x060080BC RID: 32956 RVA: 0x000B8A4B File Offset: 0x000B6C4B
		public override void CreateDefaultRepresentation()
		{
			vtkBiDimensionalWidget.vtkBiDimensionalWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		// Token: 0x060080BD RID: 32957
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiDimensionalWidget_GetBiDimensionalRepresentation_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the representation as a vtkBiDimensionalRepresentation.
		/// </summary>
		// Token: 0x060080BE RID: 32958 RVA: 0x000B8A5C File Offset: 0x000B6C5C
		public vtkBiDimensionalRepresentation GetBiDimensionalRepresentation()
		{
			vtkBiDimensionalRepresentation vtkBiDimensionalRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBiDimensionalWidget.vtkBiDimensionalWidget_GetBiDimensionalRepresentation_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBiDimensionalRepresentation = (vtkBiDimensionalRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBiDimensionalRepresentation.Register(null);
				}
			}
			return vtkBiDimensionalRepresentation;
		}

		// Token: 0x060080BF RID: 32959
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBiDimensionalWidget_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x060080C0 RID: 32960 RVA: 0x000B8ACC File Offset: 0x000B6CCC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBiDimensionalWidget.vtkBiDimensionalWidget_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x060080C1 RID: 32961
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBiDimensionalWidget_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x060080C2 RID: 32962 RVA: 0x000B8AEC File Offset: 0x000B6CEC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBiDimensionalWidget.vtkBiDimensionalWidget_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x060080C3 RID: 32963
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiDimensionalWidget_GetWidgetState_05(HandleRef pThis);

		/// <summary>
		/// Return the current widget state.
		/// </summary>
		// Token: 0x060080C4 RID: 32964 RVA: 0x000B8B08 File Offset: 0x000B6D08
		public virtual int GetWidgetState()
		{
			return vtkBiDimensionalWidget.vtkBiDimensionalWidget_GetWidgetState_05(base.GetCppThis());
		}

		// Token: 0x060080C5 RID: 32965
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiDimensionalWidget_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x060080C6 RID: 32966 RVA: 0x000B8B28 File Offset: 0x000B6D28
		public override int IsA(string type)
		{
			return vtkBiDimensionalWidget.vtkBiDimensionalWidget_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x060080C7 RID: 32967
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiDimensionalWidget_IsMeasureValid_07(HandleRef pThis);

		/// <summary>
		/// A flag indicates whether the bi-dimensional measure is valid. The widget
		/// becomes valid after two of the four points are placed.
		/// </summary>
		// Token: 0x060080C8 RID: 32968 RVA: 0x000B8B48 File Offset: 0x000B6D48
		public int IsMeasureValid()
		{
			return vtkBiDimensionalWidget.vtkBiDimensionalWidget_IsMeasureValid_07(base.GetCppThis());
		}

		// Token: 0x060080C9 RID: 32969
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiDimensionalWidget_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x060080CA RID: 32970 RVA: 0x000B8B68 File Offset: 0x000B6D68
		public new static int IsTypeOf(string type)
		{
			return vtkBiDimensionalWidget.vtkBiDimensionalWidget_IsTypeOf_08(type);
		}

		// Token: 0x060080CB RID: 32971
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiDimensionalWidget_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x060080CC RID: 32972 RVA: 0x000B8B84 File Offset: 0x000B6D84
		public new vtkBiDimensionalWidget NewInstance()
		{
			vtkBiDimensionalWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBiDimensionalWidget.vtkBiDimensionalWidget_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBiDimensionalWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060080CD RID: 32973
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiDimensionalWidget_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x060080CE RID: 32974 RVA: 0x000B8BE0 File Offset: 0x000B6DE0
		public new static vtkBiDimensionalWidget SafeDownCast(vtkObjectBase o)
		{
			vtkBiDimensionalWidget vtkBiDimensionalWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBiDimensionalWidget.vtkBiDimensionalWidget_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBiDimensionalWidget = (vtkBiDimensionalWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBiDimensionalWidget.Register(null);
				}
			}
			return vtkBiDimensionalWidget;
		}

		// Token: 0x060080CF RID: 32975
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiDimensionalWidget_SetEnabled_12(HandleRef pThis, int arg0);

		/// <summary>
		/// The method for activating and deactivating this widget. This method
		/// must be overridden because it is a composite widget and does more than
		/// its superclasses' vtkAbstractWidget::SetEnabled() method.
		/// </summary>
		// Token: 0x060080D0 RID: 32976 RVA: 0x000B8C5F File Offset: 0x000B6E5F
		public override void SetEnabled(int arg0)
		{
			vtkBiDimensionalWidget.vtkBiDimensionalWidget_SetEnabled_12(base.GetCppThis(), arg0);
		}

		// Token: 0x060080D1 RID: 32977
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiDimensionalWidget_SetProcessEvents_13(HandleRef pThis, int arg0);

		/// <summary>
		/// Methods to change the whether the widget responds to interaction.
		/// Overridden to pass the state to component widgets.
		/// </summary>
		// Token: 0x060080D2 RID: 32978 RVA: 0x000B8C6F File Offset: 0x000B6E6F
		public override void SetProcessEvents(int arg0)
		{
			vtkBiDimensionalWidget.vtkBiDimensionalWidget_SetProcessEvents_13(base.GetCppThis(), arg0);
		}

		// Token: 0x060080D3 RID: 32979
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiDimensionalWidget_SetRepresentation_14(HandleRef pThis, HandleRef r);

		/// <summary>
		/// Specify an instance of vtkWidgetRepresentation used to represent this
		/// widget in the scene. Note that the representation is a subclass of vtkProp
		/// so it can be added to the renderer independent of the widget.
		/// </summary>
		// Token: 0x060080D4 RID: 32980 RVA: 0x000B8C80 File Offset: 0x000B6E80
		public void SetRepresentation(vtkBiDimensionalRepresentation r)
		{
			vtkBiDimensionalWidget.vtkBiDimensionalWidget_SetRepresentation_14(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}

		// Token: 0x060080D5 RID: 32981
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiDimensionalWidget_SetWidgetStateToManipulate_15(HandleRef pThis);

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
		// Token: 0x060080D6 RID: 32982 RVA: 0x000B8CAF File Offset: 0x000B6EAF
		public virtual void SetWidgetStateToManipulate()
		{
			vtkBiDimensionalWidget.vtkBiDimensionalWidget_SetWidgetStateToManipulate_15(base.GetCppThis());
		}

		// Token: 0x060080D7 RID: 32983
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiDimensionalWidget_SetWidgetStateToStart_16(HandleRef pThis);

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
		// Token: 0x060080D8 RID: 32984 RVA: 0x000B8CBE File Offset: 0x000B6EBE
		public virtual void SetWidgetStateToStart()
		{
			vtkBiDimensionalWidget.vtkBiDimensionalWidget_SetWidgetStateToStart_16(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000AEA RID: 2794
		public new const string MRFullTypeName = "Kitware.VTK.vtkBiDimensionalWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000AEB RID: 2795
		public new static readonly string MRClassNameKey = "class vtkBiDimensionalWidget";

		/// <summary>
		/// Events.
		/// </summary>
		// Token: 0x020002CC RID: 716
		public enum EndWidgetSelectEvent_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000AED RID: 2797
			EndWidgetSelectEvent = 10050
		}

		/// <summary>
		/// Enum defining the state of the widget. By default the widget is in Start mode,
		/// and expects to be interactively placed. While placing the points the widget
		/// transitions to Define state. Once placed, the widget enters the Manipulate state.
		/// </summary>
		// Token: 0x020002CD RID: 717
		public enum Define_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000AEF RID: 2799
			Define = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000AF0 RID: 2800
			Manipulate,
			/// <summary>enum member</summary>
			// Token: 0x04000AF1 RID: 2801
			Start = 0
		}
	}
}
