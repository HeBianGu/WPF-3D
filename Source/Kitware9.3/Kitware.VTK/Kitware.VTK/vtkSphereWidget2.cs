using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSphereWidget2
	/// </summary>
	/// <remarks>
	///    3D widget for manipulating a point on a sphere
	///
	/// This 3D widget interacts with a vtkSphereRepresentation class (i.e., it
	/// handles the events that drive its corresponding representation). It can be
	/// used to position a point on a sphere (for example, to place a light or
	/// camera), or to position a sphere in a scene, including translating and
	/// scaling the sphere.
	///
	/// A nice feature of vtkSphereWidget2, like any 3D widget, is that it will
	/// work in combination with the current interactor style (or any other
	/// interactor observer). That is, if vtkSphereWidget2 does not handle an
	/// event, then all other registered observers (including the interactor
	/// style) have an opportunity to process the event. Otherwise, the
	/// vtkSphereWidget2 will terminate the processing of the event that it
	/// handles.
	///
	/// To use this widget, you generally pair it with a vtkSphereRepresentation
	/// (or a subclass). Various options are available in the representation for
	/// controlling how the widget appears, and how the widget functions.
	///
	/// @par Event Bindings:
	/// By default, the widget responds to the following VTK events (i.e., it
	/// watches the vtkRenderWindowInteractor for these events):
	/// &lt;pre&gt;
	/// If the handle or sphere are selected:
	///   LeftButtonPressEvent - select the handle or sphere
	///   LeftButtonReleaseEvent - release the handle to sphere
	///   MouseMoveEvent - move the handle or translate the sphere
	/// In all the cases, independent of what is picked, the widget responds to the
	/// following VTK events:
	///   MiddleButtonPressEvent - translate the representation
	///   MiddleButtonReleaseEvent - stop translating the representation
	///   RightButtonPressEvent - scale the widget's representation
	///   RightButtonReleaseEvent - stop scaling the representation
	///   MouseMoveEvent - scale (if right button) or move (if middle button) the widget
	/// &lt;/pre&gt;
	///
	/// @par Event Bindings:
	/// Note that the event bindings described above can be changed using this
	/// class's vtkWidgetEventTranslator. This class translates VTK events
	/// into the vtkSphereWidget2's widget events:
	/// &lt;pre&gt;
	///   vtkWidgetEvent::Select -- some part of the widget has been selected
	///   vtkWidgetEvent::EndSelect -- the selection process has completed
	///   vtkWidgetEvent::Scale -- some part of the widget has been selected
	///   vtkWidgetEvent::EndScale -- the selection process has completed
	///   vtkWidgetEvent::Translate -- some part of the widget has been selected
	///   vtkWidgetEvent::EndTranslate -- the selection process has completed
	///   vtkWidgetEvent::Move -- a request for motion has been invoked
	/// &lt;/pre&gt;
	///
	/// @par Event Bindings:
	/// In turn, when these widget events are processed, the vtkSphereWidget2
	/// invokes the following VTK events on itself (which observers can listen for):
	/// &lt;pre&gt;
	///   vtkCommand::StartInteractionEvent (on vtkWidgetEvent::Select)
	///   vtkCommand::EndInteractionEvent (on vtkWidgetEvent::EndSelect)
	///   vtkCommand::InteractionEvent (on vtkWidgetEvent::Move)
	/// &lt;/pre&gt;
	///
	///
	/// @par Event Bindings:
	/// This class, and the affiliated vtkSphereRepresentation, are second generation
	/// VTK widgets. An earlier version of this functionality was defined in the
	/// class vtkSphereWidget.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkSphereRepresentation vtkSphereWidget
	/// </seealso>
	// Token: 0x0200037C RID: 892
	public class vtkSphereWidget2 : vtkAbstractWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600A26F RID: 41583 RVA: 0x000E64C4 File Offset: 0x000E46C4
		static vtkSphereWidget2()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSphereWidget2.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSphereWidget2"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600A270 RID: 41584 RVA: 0x000E64EC File Offset: 0x000E46EC
		public vtkSphereWidget2(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600A271 RID: 41585
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphereWidget2_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x0600A272 RID: 41586 RVA: 0x000E64FC File Offset: 0x000E46FC
		public new static vtkSphereWidget2 New()
		{
			vtkSphereWidget2 result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSphereWidget2.vtkSphereWidget2_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSphereWidget2)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x0600A273 RID: 41587 RVA: 0x000E6550 File Offset: 0x000E4750
		public vtkSphereWidget2() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSphereWidget2.vtkSphereWidget2_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600A274 RID: 41588 RVA: 0x000E6594 File Offset: 0x000E4794
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600A275 RID: 41589
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereWidget2_CreateDefaultRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Create the default widget representation if one is not set. By default,
		/// this is an instance of the vtkSphereRepresentation class.
		/// </summary>
		// Token: 0x0600A276 RID: 41590 RVA: 0x000E659F File Offset: 0x000E479F
		public override void CreateDefaultRepresentation()
		{
			vtkSphereWidget2.vtkSphereWidget2_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		// Token: 0x0600A277 RID: 41591
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSphereWidget2_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard class methods for type information and printing.
		/// </summary>
		// Token: 0x0600A278 RID: 41592 RVA: 0x000E65B0 File Offset: 0x000E47B0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSphereWidget2.vtkSphereWidget2_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600A279 RID: 41593
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSphereWidget2_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard class methods for type information and printing.
		/// </summary>
		// Token: 0x0600A27A RID: 41594 RVA: 0x000E65D0 File Offset: 0x000E47D0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSphereWidget2.vtkSphereWidget2_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600A27B RID: 41595
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereWidget2_GetScalingEnabled_04(HandleRef pThis);

		/// <summary>
		/// Control the behavior of the widget (i.e., how it processes
		/// events). Translation, and scaling can all be enabled and disabled.
		/// </summary>
		// Token: 0x0600A27C RID: 41596 RVA: 0x000E65EC File Offset: 0x000E47EC
		public virtual int GetScalingEnabled()
		{
			return vtkSphereWidget2.vtkSphereWidget2_GetScalingEnabled_04(base.GetCppThis());
		}

		// Token: 0x0600A27D RID: 41597
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereWidget2_GetTranslationEnabled_05(HandleRef pThis);

		/// <summary>
		/// Control the behavior of the widget (i.e., how it processes
		/// events). Translation, and scaling can all be enabled and disabled.
		/// </summary>
		// Token: 0x0600A27E RID: 41598 RVA: 0x000E660C File Offset: 0x000E480C
		public virtual int GetTranslationEnabled()
		{
			return vtkSphereWidget2.vtkSphereWidget2_GetTranslationEnabled_05(base.GetCppThis());
		}

		// Token: 0x0600A27F RID: 41599
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereWidget2_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard class methods for type information and printing.
		/// </summary>
		// Token: 0x0600A280 RID: 41600 RVA: 0x000E662C File Offset: 0x000E482C
		public override int IsA(string type)
		{
			return vtkSphereWidget2.vtkSphereWidget2_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0600A281 RID: 41601
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereWidget2_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard class methods for type information and printing.
		/// </summary>
		// Token: 0x0600A282 RID: 41602 RVA: 0x000E664C File Offset: 0x000E484C
		public new static int IsTypeOf(string type)
		{
			return vtkSphereWidget2.vtkSphereWidget2_IsTypeOf_07(type);
		}

		// Token: 0x0600A283 RID: 41603
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphereWidget2_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard class methods for type information and printing.
		/// </summary>
		// Token: 0x0600A284 RID: 41604 RVA: 0x000E6668 File Offset: 0x000E4868
		public new vtkSphereWidget2 NewInstance()
		{
			vtkSphereWidget2 result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSphereWidget2.vtkSphereWidget2_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSphereWidget2)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600A285 RID: 41605
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphereWidget2_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard class methods for type information and printing.
		/// </summary>
		// Token: 0x0600A286 RID: 41606 RVA: 0x000E66C4 File Offset: 0x000E48C4
		public new static vtkSphereWidget2 SafeDownCast(vtkObjectBase o)
		{
			vtkSphereWidget2 vtkSphereWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSphereWidget2.vtkSphereWidget2_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSphereWidget = (vtkSphereWidget2)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSphereWidget.Register(null);
				}
			}
			return vtkSphereWidget;
		}

		// Token: 0x0600A287 RID: 41607
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereWidget2_ScalingEnabledOff_11(HandleRef pThis);

		/// <summary>
		/// Control the behavior of the widget (i.e., how it processes
		/// events). Translation, and scaling can all be enabled and disabled.
		/// </summary>
		// Token: 0x0600A288 RID: 41608 RVA: 0x000E6743 File Offset: 0x000E4943
		public virtual void ScalingEnabledOff()
		{
			vtkSphereWidget2.vtkSphereWidget2_ScalingEnabledOff_11(base.GetCppThis());
		}

		// Token: 0x0600A289 RID: 41609
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereWidget2_ScalingEnabledOn_12(HandleRef pThis);

		/// <summary>
		/// Control the behavior of the widget (i.e., how it processes
		/// events). Translation, and scaling can all be enabled and disabled.
		/// </summary>
		// Token: 0x0600A28A RID: 41610 RVA: 0x000E6752 File Offset: 0x000E4952
		public virtual void ScalingEnabledOn()
		{
			vtkSphereWidget2.vtkSphereWidget2_ScalingEnabledOn_12(base.GetCppThis());
		}

		// Token: 0x0600A28B RID: 41611
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereWidget2_SetEnabled_13(HandleRef pThis, int enabling);

		/// <summary>
		/// Override superclasses' SetEnabled() method because the line
		/// widget must enable its internal handle widgets.
		/// </summary>
		// Token: 0x0600A28C RID: 41612 RVA: 0x000E6761 File Offset: 0x000E4961
		public override void SetEnabled(int enabling)
		{
			vtkSphereWidget2.vtkSphereWidget2_SetEnabled_13(base.GetCppThis(), enabling);
		}

		// Token: 0x0600A28D RID: 41613
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereWidget2_SetRepresentation_14(HandleRef pThis, HandleRef r);

		/// <summary>
		/// Specify an instance of vtkWidgetRepresentation used to represent this
		/// widget in the scene. Note that the representation is a subclass of
		/// vtkProp so it can be added to the renderer independent of the widget.
		/// </summary>
		// Token: 0x0600A28E RID: 41614 RVA: 0x000E6774 File Offset: 0x000E4974
		public void SetRepresentation(vtkSphereRepresentation r)
		{
			vtkSphereWidget2.vtkSphereWidget2_SetRepresentation_14(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}

		// Token: 0x0600A28F RID: 41615
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereWidget2_SetScalingEnabled_15(HandleRef pThis, int _arg);

		/// <summary>
		/// Control the behavior of the widget (i.e., how it processes
		/// events). Translation, and scaling can all be enabled and disabled.
		/// </summary>
		// Token: 0x0600A290 RID: 41616 RVA: 0x000E67A3 File Offset: 0x000E49A3
		public virtual void SetScalingEnabled(int _arg)
		{
			vtkSphereWidget2.vtkSphereWidget2_SetScalingEnabled_15(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A291 RID: 41617
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereWidget2_SetTranslationEnabled_16(HandleRef pThis, int _arg);

		/// <summary>
		/// Control the behavior of the widget (i.e., how it processes
		/// events). Translation, and scaling can all be enabled and disabled.
		/// </summary>
		// Token: 0x0600A292 RID: 41618 RVA: 0x000E67B3 File Offset: 0x000E49B3
		public virtual void SetTranslationEnabled(int _arg)
		{
			vtkSphereWidget2.vtkSphereWidget2_SetTranslationEnabled_16(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A293 RID: 41619
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereWidget2_TranslationEnabledOff_17(HandleRef pThis);

		/// <summary>
		/// Control the behavior of the widget (i.e., how it processes
		/// events). Translation, and scaling can all be enabled and disabled.
		/// </summary>
		// Token: 0x0600A294 RID: 41620 RVA: 0x000E67C3 File Offset: 0x000E49C3
		public virtual void TranslationEnabledOff()
		{
			vtkSphereWidget2.vtkSphereWidget2_TranslationEnabledOff_17(base.GetCppThis());
		}

		// Token: 0x0600A295 RID: 41621
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereWidget2_TranslationEnabledOn_18(HandleRef pThis);

		/// <summary>
		/// Control the behavior of the widget (i.e., how it processes
		/// events). Translation, and scaling can all be enabled and disabled.
		/// </summary>
		// Token: 0x0600A296 RID: 41622 RVA: 0x000E67D2 File Offset: 0x000E49D2
		public virtual void TranslationEnabledOn()
		{
			vtkSphereWidget2.vtkSphereWidget2_TranslationEnabledOn_18(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D06 RID: 3334
		public new const string MRFullTypeName = "Kitware.VTK.vtkSphereWidget2";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D07 RID: 3335
		public new static readonly string MRClassNameKey = "class vtkSphereWidget2";
	}
}
