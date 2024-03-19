using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCheckerboardWidget
	/// </summary>
	/// <remarks>
	///    interactively set the number of divisions in 2D image checkerboard
	///
	/// The vtkCheckerboardWidget is used to interactively control an instance of
	/// vtkImageCheckerboard (and an associated vtkImageActor used to display the
	/// checkerboard). The user can adjust the number of divisions in each of the
	/// i-j directions in a 2D image. A frame appears around the vtkImageActor
	/// with sliders along each side of the frame. The user can interactively
	/// adjust the sliders to the desired number of checkerboard subdivisions.
	///
	/// To use this widget, specify an instance of vtkImageCheckerboard and an
	/// instance of vtkImageActor. By default, the widget responds to the
	/// following events:
	/// &lt;pre&gt;
	/// If the slider bead is selected:
	///   LeftButtonPressEvent - select slider (if on slider)
	///   LeftButtonReleaseEvent - release slider
	///   MouseMoveEvent - move slider
	/// If the end caps or slider tube of a slider are selected:
	///   LeftButtonPressEvent - jump (or animate) to cap or point on tube;
	/// &lt;/pre&gt;
	/// It is possible to change these event bindings. Please refer to the
	/// documentation for vtkSliderWidget for more information. Advanced users may
	/// directly access and manipulate the sliders by obtaining the instances of
	/// vtkSliderWidget composing the vtkCheckerboard widget.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkImageCheckerboard vtkImageActor vtkSliderWidget vtkRectilinearWipeWidget
	/// </seealso>
	// Token: 0x020002F6 RID: 758
	public class vtkCheckerboardWidget : vtkAbstractWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060087D4 RID: 34772 RVA: 0x000C2127 File Offset: 0x000C0327
		static vtkCheckerboardWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCheckerboardWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCheckerboardWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060087D5 RID: 34773 RVA: 0x000C214F File Offset: 0x000C034F
		public vtkCheckerboardWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060087D6 RID: 34774
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCheckerboardWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x060087D7 RID: 34775 RVA: 0x000C2160 File Offset: 0x000C0360
		public new static vtkCheckerboardWidget New()
		{
			vtkCheckerboardWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCheckerboardWidget.vtkCheckerboardWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCheckerboardWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x060087D8 RID: 34776 RVA: 0x000C21B4 File Offset: 0x000C03B4
		public vtkCheckerboardWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCheckerboardWidget.vtkCheckerboardWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060087D9 RID: 34777 RVA: 0x000C21F8 File Offset: 0x000C03F8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060087DA RID: 34778
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCheckerboardWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Create the default widget representation if one is not set.
		/// </summary>
		// Token: 0x060087DB RID: 34779 RVA: 0x000C2203 File Offset: 0x000C0403
		public override void CreateDefaultRepresentation()
		{
			vtkCheckerboardWidget.vtkCheckerboardWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		// Token: 0x060087DC RID: 34780
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCheckerboardWidget_GetCheckerboardRepresentation_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the representation as a vtkCheckerboardRepresentation.
		/// </summary>
		// Token: 0x060087DD RID: 34781 RVA: 0x000C2214 File Offset: 0x000C0414
		public vtkCheckerboardRepresentation GetCheckerboardRepresentation()
		{
			vtkCheckerboardRepresentation vtkCheckerboardRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCheckerboardWidget.vtkCheckerboardWidget_GetCheckerboardRepresentation_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCheckerboardRepresentation = (vtkCheckerboardRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCheckerboardRepresentation.Register(null);
				}
			}
			return vtkCheckerboardRepresentation;
		}

		// Token: 0x060087DE RID: 34782
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCheckerboardWidget_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x060087DF RID: 34783 RVA: 0x000C2284 File Offset: 0x000C0484
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCheckerboardWidget.vtkCheckerboardWidget_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x060087E0 RID: 34784
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCheckerboardWidget_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x060087E1 RID: 34785 RVA: 0x000C22A4 File Offset: 0x000C04A4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCheckerboardWidget.vtkCheckerboardWidget_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x060087E2 RID: 34786
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCheckerboardWidget_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x060087E3 RID: 34787 RVA: 0x000C22C0 File Offset: 0x000C04C0
		public override int IsA(string type)
		{
			return vtkCheckerboardWidget.vtkCheckerboardWidget_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x060087E4 RID: 34788
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCheckerboardWidget_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x060087E5 RID: 34789 RVA: 0x000C22E0 File Offset: 0x000C04E0
		public new static int IsTypeOf(string type)
		{
			return vtkCheckerboardWidget.vtkCheckerboardWidget_IsTypeOf_06(type);
		}

		// Token: 0x060087E6 RID: 34790
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCheckerboardWidget_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x060087E7 RID: 34791 RVA: 0x000C22FC File Offset: 0x000C04FC
		public new vtkCheckerboardWidget NewInstance()
		{
			vtkCheckerboardWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCheckerboardWidget.vtkCheckerboardWidget_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCheckerboardWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060087E8 RID: 34792
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCheckerboardWidget_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x060087E9 RID: 34793 RVA: 0x000C2358 File Offset: 0x000C0558
		public new static vtkCheckerboardWidget SafeDownCast(vtkObjectBase o)
		{
			vtkCheckerboardWidget vtkCheckerboardWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCheckerboardWidget.vtkCheckerboardWidget_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCheckerboardWidget = (vtkCheckerboardWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCheckerboardWidget.Register(null);
				}
			}
			return vtkCheckerboardWidget;
		}

		// Token: 0x060087EA RID: 34794
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCheckerboardWidget_SetEnabled_10(HandleRef pThis, int arg0);

		/// <summary>
		/// The method for activating and deactivating this widget. This method
		/// must be overridden because it is a composite widget and does more than
		/// its superclasses' vtkAbstractWidget::SetEnabled() method.
		/// </summary>
		// Token: 0x060087EB RID: 34795 RVA: 0x000C23D7 File Offset: 0x000C05D7
		public override void SetEnabled(int arg0)
		{
			vtkCheckerboardWidget.vtkCheckerboardWidget_SetEnabled_10(base.GetCppThis(), arg0);
		}

		// Token: 0x060087EC RID: 34796
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCheckerboardWidget_SetRepresentation_11(HandleRef pThis, HandleRef r);

		/// <summary>
		/// Specify an instance of vtkWidgetRepresentation used to represent this
		/// widget in the scene. Note that the representation is a subclass of vtkProp
		/// so it can be added to the renderer independent of the widget.
		/// </summary>
		// Token: 0x060087ED RID: 34797 RVA: 0x000C23E8 File Offset: 0x000C05E8
		public void SetRepresentation(vtkCheckerboardRepresentation r)
		{
			vtkCheckerboardWidget.vtkCheckerboardWidget_SetRepresentation_11(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B76 RID: 2934
		public new const string MRFullTypeName = "Kitware.VTK.vtkCheckerboardWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B77 RID: 2935
		public new static readonly string MRClassNameKey = "class vtkCheckerboardWidget";
	}
}
