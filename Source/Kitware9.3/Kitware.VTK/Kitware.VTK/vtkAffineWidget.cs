using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAffineWidget
	/// </summary>
	/// <remarks>
	///    perform affine transformations
	///
	/// The vtkAffineWidget is used to perform affine transformations on objects.
	/// (Affine transformations are transformations that keep parallel lines parallel.
	/// Affine transformations include translation, scaling, rotation, and shearing.)
	///
	/// To use this widget, set the widget representation. The representation
	/// maintains a transformation matrix and other instance variables consistent
	/// with the transformations applied by this widget.
	///
	/// @par Event Bindings:
	/// By default, the widget responds to the following VTK events (i.e., it
	/// watches the vtkRenderWindowInteractor for these events):
	/// &lt;pre&gt;
	///   LeftButtonPressEvent - select widget: depending on which part is selected
	///                          translation, rotation, scaling, or shearing may follow.
	///   LeftButtonReleaseEvent - end selection of widget.
	///   MouseMoveEvent - interactive movement across widget
	/// &lt;/pre&gt;
	///
	/// @par Event Bindings:
	/// Note that the event bindings described above can be changed using this
	/// class's vtkWidgetEventTranslator. This class translates VTK events
	/// into the vtkAffineWidget's widget events:
	/// &lt;pre&gt;
	///   vtkWidgetEvent::Select -- focal point is being selected
	///   vtkWidgetEvent::EndSelect -- the selection process has completed
	///   vtkWidgetEvent::Move -- a request for widget motion
	/// &lt;/pre&gt;
	///
	/// @par Event Bindings:
	/// In turn, when these widget events are processed, the vtkAffineWidget
	/// invokes the following VTK events on itself (which observers can listen for):
	/// &lt;pre&gt;
	///   vtkCommand::StartInteractionEvent (on vtkWidgetEvent::Select)
	///   vtkCommand::EndInteractionEvent (on vtkWidgetEvent::EndSelect)
	///   vtkCommand::InteractionEvent (on vtkWidgetEvent::Move)
	/// &lt;/pre&gt;
	///
	/// </remarks>
	// Token: 0x020002B6 RID: 694
	public class vtkAffineWidget : vtkAbstractWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06007D9C RID: 32156 RVA: 0x000B4587 File Offset: 0x000B2787
		static vtkAffineWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAffineWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAffineWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06007D9D RID: 32157 RVA: 0x000B45AF File Offset: 0x000B27AF
		public vtkAffineWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06007D9E RID: 32158
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAffineWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06007D9F RID: 32159 RVA: 0x000B45C0 File Offset: 0x000B27C0
		public new static vtkAffineWidget New()
		{
			vtkAffineWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAffineWidget.vtkAffineWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAffineWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06007DA0 RID: 32160 RVA: 0x000B4614 File Offset: 0x000B2814
		public vtkAffineWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAffineWidget.vtkAffineWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06007DA1 RID: 32161 RVA: 0x000B4658 File Offset: 0x000B2858
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06007DA2 RID: 32162
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAffineWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Create the default widget representation if one is not set.
		/// </summary>
		// Token: 0x06007DA3 RID: 32163 RVA: 0x000B4663 File Offset: 0x000B2863
		public override void CreateDefaultRepresentation()
		{
			vtkAffineWidget.vtkAffineWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06007DA4 RID: 32164
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAffineWidget_GetAffineRepresentation_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the representation as a vtkAffineRepresentation.
		/// </summary>
		// Token: 0x06007DA5 RID: 32165 RVA: 0x000B4674 File Offset: 0x000B2874
		public vtkAffineRepresentation GetAffineRepresentation()
		{
			vtkAffineRepresentation vtkAffineRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAffineWidget.vtkAffineWidget_GetAffineRepresentation_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAffineRepresentation = (vtkAffineRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAffineRepresentation.Register(null);
				}
			}
			return vtkAffineRepresentation;
		}

		// Token: 0x06007DA6 RID: 32166
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAffineWidget_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class macros.
		/// </summary>
		// Token: 0x06007DA7 RID: 32167 RVA: 0x000B46E4 File Offset: 0x000B28E4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAffineWidget.vtkAffineWidget_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06007DA8 RID: 32168
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAffineWidget_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class macros.
		/// </summary>
		// Token: 0x06007DA9 RID: 32169 RVA: 0x000B4704 File Offset: 0x000B2904
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAffineWidget.vtkAffineWidget_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06007DAA RID: 32170
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAffineWidget_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class macros.
		/// </summary>
		// Token: 0x06007DAB RID: 32171 RVA: 0x000B4720 File Offset: 0x000B2920
		public override int IsA(string type)
		{
			return vtkAffineWidget.vtkAffineWidget_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06007DAC RID: 32172
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAffineWidget_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class macros.
		/// </summary>
		// Token: 0x06007DAD RID: 32173 RVA: 0x000B4740 File Offset: 0x000B2940
		public new static int IsTypeOf(string type)
		{
			return vtkAffineWidget.vtkAffineWidget_IsTypeOf_06(type);
		}

		// Token: 0x06007DAE RID: 32174
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAffineWidget_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK class macros.
		/// </summary>
		// Token: 0x06007DAF RID: 32175 RVA: 0x000B475C File Offset: 0x000B295C
		public new vtkAffineWidget NewInstance()
		{
			vtkAffineWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAffineWidget.vtkAffineWidget_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAffineWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06007DB0 RID: 32176
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAffineWidget_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK class macros.
		/// </summary>
		// Token: 0x06007DB1 RID: 32177 RVA: 0x000B47B8 File Offset: 0x000B29B8
		public new static vtkAffineWidget SafeDownCast(vtkObjectBase o)
		{
			vtkAffineWidget vtkAffineWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAffineWidget.vtkAffineWidget_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAffineWidget = (vtkAffineWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAffineWidget.Register(null);
				}
			}
			return vtkAffineWidget;
		}

		// Token: 0x06007DB2 RID: 32178
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAffineWidget_SetEnabled_10(HandleRef pThis, int arg0);

		/// <summary>
		/// Methods for activating this widget. This implementation extends the
		/// superclasses' in order to resize the widget handles due to a render
		/// start event.
		/// </summary>
		// Token: 0x06007DB3 RID: 32179 RVA: 0x000B4837 File Offset: 0x000B2A37
		public override void SetEnabled(int arg0)
		{
			vtkAffineWidget.vtkAffineWidget_SetEnabled_10(base.GetCppThis(), arg0);
		}

		// Token: 0x06007DB4 RID: 32180
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAffineWidget_SetRepresentation_11(HandleRef pThis, HandleRef r);

		/// <summary>
		/// Specify an instance of vtkWidgetRepresentation used to represent this
		/// widget in the scene. Note that the representation is a subclass of vtkProp
		/// so it can be added to the renderer independent of the widget.
		/// </summary>
		// Token: 0x06007DB5 RID: 32181 RVA: 0x000B4848 File Offset: 0x000B2A48
		public void SetRepresentation(vtkAffineRepresentation r)
		{
			vtkAffineWidget.vtkAffineWidget_SetRepresentation_11(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A9D RID: 2717
		public new const string MRFullTypeName = "Kitware.VTK.vtkAffineWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A9E RID: 2718
		public new static readonly string MRClassNameKey = "class vtkAffineWidget";
	}
}
