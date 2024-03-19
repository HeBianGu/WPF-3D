using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkContinuousValueWidget
	/// </summary>
	/// <remarks>
	///    set a value by manipulating something
	///
	/// The vtkContinuousValueWidget is used to adjust a scalar value in an
	/// application. Note that the actual appearance of the widget depends on
	/// the specific representation for the widget.
	///
	/// To use this widget, set the widget representation. (the details may
	/// vary depending on the particulars of the representation).
	///
	///
	/// @par Event Bindings:
	/// By default, the widget responds to the following VTK events (i.e., it
	/// watches the vtkRenderWindowInteractor for these events):
	/// &lt;pre&gt;
	/// If the slider bead is selected:
	///   LeftButtonPressEvent - select slider
	///   LeftButtonReleaseEvent - release slider
	///   MouseMoveEvent - move slider
	/// &lt;/pre&gt;
	///
	/// @par Event Bindings:
	/// Note that the event bindings described above can be changed using this
	/// class's vtkWidgetEventTranslator. This class translates VTK events
	/// into the vtkContinuousValueWidget's widget events:
	/// &lt;pre&gt;
	///   vtkWidgetEvent::Select -- some part of the widget has been selected
	///   vtkWidgetEvent::EndSelect -- the selection process has completed
	///   vtkWidgetEvent::Move -- a request for slider motion has been invoked
	/// &lt;/pre&gt;
	///
	/// @par Event Bindings:
	/// In turn, when these widget events are processed, the vtkContinuousValueWidget
	/// invokes the following VTK events on itself (which observers can listen for):
	/// &lt;pre&gt;
	///   vtkCommand::StartInteractionEvent (on vtkWidgetEvent::Select)
	///   vtkCommand::EndInteractionEvent (on vtkWidgetEvent::EndSelect)
	///   vtkCommand::InteractionEvent (on vtkWidgetEvent::Move)
	/// &lt;/pre&gt;
	///
	/// </remarks>
	// Token: 0x020002FF RID: 767
	public abstract class vtkContinuousValueWidget : vtkAbstractWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06008929 RID: 35113 RVA: 0x000C3FB3 File Offset: 0x000C21B3
		static vtkContinuousValueWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkContinuousValueWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkContinuousValueWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600892A RID: 35114 RVA: 0x000C3FDB File Offset: 0x000C21DB
		public vtkContinuousValueWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600892B RID: 35115 RVA: 0x000C3FE9 File Offset: 0x000C21E9
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600892C RID: 35116
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContinuousValueWidget_GetContinuousValueWidgetRepresentation_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the representation as a vtkContinuousValueWidgetRepresentation.
		/// </summary>
		// Token: 0x0600892D RID: 35117 RVA: 0x000C3FF4 File Offset: 0x000C21F4
		public vtkContinuousValueWidgetRepresentation GetContinuousValueWidgetRepresentation()
		{
			vtkContinuousValueWidgetRepresentation vtkContinuousValueWidgetRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContinuousValueWidget.vtkContinuousValueWidget_GetContinuousValueWidgetRepresentation_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkContinuousValueWidgetRepresentation = (vtkContinuousValueWidgetRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkContinuousValueWidgetRepresentation.Register(null);
				}
			}
			return vtkContinuousValueWidgetRepresentation;
		}

		// Token: 0x0600892E RID: 35118
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkContinuousValueWidget_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x0600892F RID: 35119 RVA: 0x000C4064 File Offset: 0x000C2264
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkContinuousValueWidget.vtkContinuousValueWidget_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06008930 RID: 35120
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkContinuousValueWidget_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x06008931 RID: 35121 RVA: 0x000C4084 File Offset: 0x000C2284
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkContinuousValueWidget.vtkContinuousValueWidget_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06008932 RID: 35122
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkContinuousValueWidget_GetValue_04(HandleRef pThis);

		/// <summary>
		/// Get the value for this widget.
		/// </summary>
		// Token: 0x06008933 RID: 35123 RVA: 0x000C40A0 File Offset: 0x000C22A0
		public double GetValue()
		{
			return vtkContinuousValueWidget.vtkContinuousValueWidget_GetValue_04(base.GetCppThis());
		}

		// Token: 0x06008934 RID: 35124
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContinuousValueWidget_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x06008935 RID: 35125 RVA: 0x000C40C0 File Offset: 0x000C22C0
		public override int IsA(string type)
		{
			return vtkContinuousValueWidget.vtkContinuousValueWidget_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06008936 RID: 35126
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContinuousValueWidget_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x06008937 RID: 35127 RVA: 0x000C40E0 File Offset: 0x000C22E0
		public new static int IsTypeOf(string type)
		{
			return vtkContinuousValueWidget.vtkContinuousValueWidget_IsTypeOf_06(type);
		}

		// Token: 0x06008938 RID: 35128
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContinuousValueWidget_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x06008939 RID: 35129 RVA: 0x000C40FC File Offset: 0x000C22FC
		public new vtkContinuousValueWidget NewInstance()
		{
			vtkContinuousValueWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContinuousValueWidget.vtkContinuousValueWidget_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContinuousValueWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600893A RID: 35130
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContinuousValueWidget_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x0600893B RID: 35131 RVA: 0x000C4158 File Offset: 0x000C2358
		public new static vtkContinuousValueWidget SafeDownCast(vtkObjectBase o)
		{
			vtkContinuousValueWidget vtkContinuousValueWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContinuousValueWidget.vtkContinuousValueWidget_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkContinuousValueWidget = (vtkContinuousValueWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkContinuousValueWidget.Register(null);
				}
			}
			return vtkContinuousValueWidget;
		}

		// Token: 0x0600893C RID: 35132
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContinuousValueWidget_SetRepresentation_09(HandleRef pThis, HandleRef r);

		/// <summary>
		/// Specify an instance of vtkWidgetRepresentation used to represent this
		/// widget in the scene. Note that the representation is a subclass of vtkProp
		/// so it can be added to the renderer independent of the widget.
		/// </summary>
		// Token: 0x0600893D RID: 35133 RVA: 0x000C41D8 File Offset: 0x000C23D8
		public void SetRepresentation(vtkContinuousValueWidgetRepresentation r)
		{
			vtkContinuousValueWidget.vtkContinuousValueWidget_SetRepresentation_09(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}

		// Token: 0x0600893E RID: 35134
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContinuousValueWidget_SetValue_10(HandleRef pThis, double v);

		/// <summary>
		/// Get the value for this widget.
		/// </summary>
		// Token: 0x0600893F RID: 35135 RVA: 0x000C4207 File Offset: 0x000C2407
		public void SetValue(double v)
		{
			vtkContinuousValueWidget.vtkContinuousValueWidget_SetValue_10(base.GetCppThis(), v);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B95 RID: 2965
		public new const string MRFullTypeName = "Kitware.VTK.vtkContinuousValueWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B96 RID: 2966
		public new static readonly string MRClassNameKey = "class vtkContinuousValueWidget";
	}
}
