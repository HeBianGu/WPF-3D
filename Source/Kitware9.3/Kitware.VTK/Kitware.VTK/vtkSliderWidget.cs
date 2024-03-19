using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSliderWidget
	/// </summary>
	/// <remarks>
	///    set a value by manipulating a slider
	///
	/// The vtkSliderWidget is used to set a scalar value in an application.  This
	/// class assumes that a slider is moved along a 1D parameter space (e.g., a
	/// spherical bead that can be moved along a tube).  Moving the slider
	/// modifies the value of the widget, which can be used to set parameters on
	/// other objects. Note that the actual appearance of the widget depends on
	/// the specific representation for the widget.
	///
	/// To use this widget, set the widget representation. The representation is
	/// assumed to consist of a tube, two end caps, and a slider (the details may
	/// vary depending on the particulars of the representation). Then in the
	/// representation you will typically set minimum and maximum value, as well
	/// as the current value. The position of the slider must also be set, as well
	/// as various properties.
	///
	/// @par Event Bindings:
	/// By default, the widget responds to the following VTK events (i.e., it
	/// watches the vtkRenderWindowInteractor for these events):
	/// &lt;pre&gt;
	/// If the slider bead is selected:
	///   LeftButtonPressEvent - select slider (if on slider)
	///   LeftButtonReleaseEvent - release slider (if selected)
	///   MouseMoveEvent - move slider
	/// If the end caps or slider tube are selected:
	///   LeftButtonPressEvent - move (or animate) to cap or point on tube;
	/// &lt;/pre&gt;
	///
	/// @par Event Bindings:
	/// Note that the event bindings described above can be changed using this
	/// class's vtkWidgetEventTranslator. This class translates VTK events
	/// into the vtkSliderWidget's widget events:
	/// &lt;pre&gt;
	///   vtkWidgetEvent::Select -- some part of the widget has been selected
	///   vtkWidgetEvent::EndSelect -- the selection process has completed
	///   vtkWidgetEvent::Move -- a request for slider motion has been invoked
	/// &lt;/pre&gt;
	///
	/// @par Event Bindings:
	/// In turn, when these widget events are processed, the vtkSliderWidget
	/// invokes the following VTK events on itself (which observers can listen for):
	/// &lt;pre&gt;
	///   vtkCommand::StartInteractionEvent (on vtkWidgetEvent::Select)
	///   vtkCommand::EndInteractionEvent (on vtkWidgetEvent::EndSelect)
	///   vtkCommand::InteractionEvent (on vtkWidgetEvent::Move)
	/// &lt;/pre&gt;
	///
	/// </remarks>
	// Token: 0x02000377 RID: 887
	public class vtkSliderWidget : vtkAbstractWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600A0CB RID: 41163 RVA: 0x000E45CD File Offset: 0x000E27CD
		static vtkSliderWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSliderWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSliderWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600A0CC RID: 41164 RVA: 0x000E45F5 File Offset: 0x000E27F5
		public vtkSliderWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600A0CD RID: 41165
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSliderWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x0600A0CE RID: 41166 RVA: 0x000E4604 File Offset: 0x000E2804
		public new static vtkSliderWidget New()
		{
			vtkSliderWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSliderWidget.vtkSliderWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSliderWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x0600A0CF RID: 41167 RVA: 0x000E4658 File Offset: 0x000E2858
		public vtkSliderWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSliderWidget.vtkSliderWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600A0D0 RID: 41168 RVA: 0x000E469C File Offset: 0x000E289C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600A0D1 RID: 41169
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSliderWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Create the default widget representation if one is not set.
		/// </summary>
		// Token: 0x0600A0D2 RID: 41170 RVA: 0x000E46A7 File Offset: 0x000E28A7
		public override void CreateDefaultRepresentation()
		{
			vtkSliderWidget.vtkSliderWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		// Token: 0x0600A0D3 RID: 41171
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSliderWidget_GetAnimationMode_02(HandleRef pThis);

		/// <summary>
		/// Control the behavior of the slider when selecting the tube or caps. If
		/// Jump, then selecting the tube, left cap, or right cap causes the slider to
		/// jump to the selection point. If the mode is Animate, the slider moves
		/// towards the selection point in NumberOfAnimationSteps number of steps.
		/// If Off, then the slider does not move.
		/// </summary>
		// Token: 0x0600A0D4 RID: 41172 RVA: 0x000E46B8 File Offset: 0x000E28B8
		public virtual int GetAnimationMode()
		{
			return vtkSliderWidget.vtkSliderWidget_GetAnimationMode_02(base.GetCppThis());
		}

		// Token: 0x0600A0D5 RID: 41173
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSliderWidget_GetAnimationModeMaxValue_03(HandleRef pThis);

		/// <summary>
		/// Control the behavior of the slider when selecting the tube or caps. If
		/// Jump, then selecting the tube, left cap, or right cap causes the slider to
		/// jump to the selection point. If the mode is Animate, the slider moves
		/// towards the selection point in NumberOfAnimationSteps number of steps.
		/// If Off, then the slider does not move.
		/// </summary>
		// Token: 0x0600A0D6 RID: 41174 RVA: 0x000E46D8 File Offset: 0x000E28D8
		public virtual int GetAnimationModeMaxValue()
		{
			return vtkSliderWidget.vtkSliderWidget_GetAnimationModeMaxValue_03(base.GetCppThis());
		}

		// Token: 0x0600A0D7 RID: 41175
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSliderWidget_GetAnimationModeMinValue_04(HandleRef pThis);

		/// <summary>
		/// Control the behavior of the slider when selecting the tube or caps. If
		/// Jump, then selecting the tube, left cap, or right cap causes the slider to
		/// jump to the selection point. If the mode is Animate, the slider moves
		/// towards the selection point in NumberOfAnimationSteps number of steps.
		/// If Off, then the slider does not move.
		/// </summary>
		// Token: 0x0600A0D8 RID: 41176 RVA: 0x000E46F8 File Offset: 0x000E28F8
		public virtual int GetAnimationModeMinValue()
		{
			return vtkSliderWidget.vtkSliderWidget_GetAnimationModeMinValue_04(base.GetCppThis());
		}

		// Token: 0x0600A0D9 RID: 41177
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSliderWidget_GetNumberOfAnimationSteps_05(HandleRef pThis);

		/// <summary>
		/// Specify the number of animation steps to take if the animation mode
		/// is set to animate.
		/// </summary>
		// Token: 0x0600A0DA RID: 41178 RVA: 0x000E4718 File Offset: 0x000E2918
		public virtual int GetNumberOfAnimationSteps()
		{
			return vtkSliderWidget.vtkSliderWidget_GetNumberOfAnimationSteps_05(base.GetCppThis());
		}

		// Token: 0x0600A0DB RID: 41179
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSliderWidget_GetNumberOfAnimationStepsMaxValue_06(HandleRef pThis);

		/// <summary>
		/// Specify the number of animation steps to take if the animation mode
		/// is set to animate.
		/// </summary>
		// Token: 0x0600A0DC RID: 41180 RVA: 0x000E4738 File Offset: 0x000E2938
		public virtual int GetNumberOfAnimationStepsMaxValue()
		{
			return vtkSliderWidget.vtkSliderWidget_GetNumberOfAnimationStepsMaxValue_06(base.GetCppThis());
		}

		// Token: 0x0600A0DD RID: 41181
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSliderWidget_GetNumberOfAnimationStepsMinValue_07(HandleRef pThis);

		/// <summary>
		/// Specify the number of animation steps to take if the animation mode
		/// is set to animate.
		/// </summary>
		// Token: 0x0600A0DE RID: 41182 RVA: 0x000E4758 File Offset: 0x000E2958
		public virtual int GetNumberOfAnimationStepsMinValue()
		{
			return vtkSliderWidget.vtkSliderWidget_GetNumberOfAnimationStepsMinValue_07(base.GetCppThis());
		}

		// Token: 0x0600A0DF RID: 41183
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSliderWidget_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x0600A0E0 RID: 41184 RVA: 0x000E4778 File Offset: 0x000E2978
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSliderWidget.vtkSliderWidget_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x0600A0E1 RID: 41185
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSliderWidget_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x0600A0E2 RID: 41186 RVA: 0x000E4798 File Offset: 0x000E2998
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSliderWidget.vtkSliderWidget_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x0600A0E3 RID: 41187
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSliderWidget_GetSliderRepresentation_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the representation as a vtkSliderRepresentation.
		/// </summary>
		// Token: 0x0600A0E4 RID: 41188 RVA: 0x000E47B4 File Offset: 0x000E29B4
		public vtkSliderRepresentation GetSliderRepresentation()
		{
			vtkSliderRepresentation vtkSliderRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSliderWidget.vtkSliderWidget_GetSliderRepresentation_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSliderRepresentation = (vtkSliderRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSliderRepresentation.Register(null);
				}
			}
			return vtkSliderRepresentation;
		}

		// Token: 0x0600A0E5 RID: 41189
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSliderWidget_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x0600A0E6 RID: 41190 RVA: 0x000E4824 File Offset: 0x000E2A24
		public override int IsA(string type)
		{
			return vtkSliderWidget.vtkSliderWidget_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x0600A0E7 RID: 41191
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSliderWidget_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x0600A0E8 RID: 41192 RVA: 0x000E4844 File Offset: 0x000E2A44
		public new static int IsTypeOf(string type)
		{
			return vtkSliderWidget.vtkSliderWidget_IsTypeOf_12(type);
		}

		// Token: 0x0600A0E9 RID: 41193
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSliderWidget_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x0600A0EA RID: 41194 RVA: 0x000E4860 File Offset: 0x000E2A60
		public new vtkSliderWidget NewInstance()
		{
			vtkSliderWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSliderWidget.vtkSliderWidget_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSliderWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600A0EB RID: 41195
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSliderWidget_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x0600A0EC RID: 41196 RVA: 0x000E48BC File Offset: 0x000E2ABC
		public new static vtkSliderWidget SafeDownCast(vtkObjectBase o)
		{
			vtkSliderWidget vtkSliderWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSliderWidget.vtkSliderWidget_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSliderWidget = (vtkSliderWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSliderWidget.Register(null);
				}
			}
			return vtkSliderWidget;
		}

		// Token: 0x0600A0ED RID: 41197
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSliderWidget_SetAnimationMode_16(HandleRef pThis, int _arg);

		/// <summary>
		/// Control the behavior of the slider when selecting the tube or caps. If
		/// Jump, then selecting the tube, left cap, or right cap causes the slider to
		/// jump to the selection point. If the mode is Animate, the slider moves
		/// towards the selection point in NumberOfAnimationSteps number of steps.
		/// If Off, then the slider does not move.
		/// </summary>
		// Token: 0x0600A0EE RID: 41198 RVA: 0x000E493B File Offset: 0x000E2B3B
		public virtual void SetAnimationMode(int _arg)
		{
			vtkSliderWidget.vtkSliderWidget_SetAnimationMode_16(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A0EF RID: 41199
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSliderWidget_SetAnimationModeToAnimate_17(HandleRef pThis);

		/// <summary>
		/// Control the behavior of the slider when selecting the tube or caps. If
		/// Jump, then selecting the tube, left cap, or right cap causes the slider to
		/// jump to the selection point. If the mode is Animate, the slider moves
		/// towards the selection point in NumberOfAnimationSteps number of steps.
		/// If Off, then the slider does not move.
		/// </summary>
		// Token: 0x0600A0F0 RID: 41200 RVA: 0x000E494B File Offset: 0x000E2B4B
		public void SetAnimationModeToAnimate()
		{
			vtkSliderWidget.vtkSliderWidget_SetAnimationModeToAnimate_17(base.GetCppThis());
		}

		// Token: 0x0600A0F1 RID: 41201
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSliderWidget_SetAnimationModeToJump_18(HandleRef pThis);

		/// <summary>
		/// Control the behavior of the slider when selecting the tube or caps. If
		/// Jump, then selecting the tube, left cap, or right cap causes the slider to
		/// jump to the selection point. If the mode is Animate, the slider moves
		/// towards the selection point in NumberOfAnimationSteps number of steps.
		/// If Off, then the slider does not move.
		/// </summary>
		// Token: 0x0600A0F2 RID: 41202 RVA: 0x000E495A File Offset: 0x000E2B5A
		public void SetAnimationModeToJump()
		{
			vtkSliderWidget.vtkSliderWidget_SetAnimationModeToJump_18(base.GetCppThis());
		}

		// Token: 0x0600A0F3 RID: 41203
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSliderWidget_SetAnimationModeToOff_19(HandleRef pThis);

		/// <summary>
		/// Control the behavior of the slider when selecting the tube or caps. If
		/// Jump, then selecting the tube, left cap, or right cap causes the slider to
		/// jump to the selection point. If the mode is Animate, the slider moves
		/// towards the selection point in NumberOfAnimationSteps number of steps.
		/// If Off, then the slider does not move.
		/// </summary>
		// Token: 0x0600A0F4 RID: 41204 RVA: 0x000E4969 File Offset: 0x000E2B69
		public void SetAnimationModeToOff()
		{
			vtkSliderWidget.vtkSliderWidget_SetAnimationModeToOff_19(base.GetCppThis());
		}

		// Token: 0x0600A0F5 RID: 41205
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSliderWidget_SetNumberOfAnimationSteps_20(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the number of animation steps to take if the animation mode
		/// is set to animate.
		/// </summary>
		// Token: 0x0600A0F6 RID: 41206 RVA: 0x000E4978 File Offset: 0x000E2B78
		public virtual void SetNumberOfAnimationSteps(int _arg)
		{
			vtkSliderWidget.vtkSliderWidget_SetNumberOfAnimationSteps_20(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A0F7 RID: 41207
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSliderWidget_SetRepresentation_21(HandleRef pThis, HandleRef r);

		/// <summary>
		/// Specify an instance of vtkWidgetRepresentation used to represent this
		/// widget in the scene. Note that the representation is a subclass of vtkProp
		/// so it can be added to the renderer independent of the widget.
		/// </summary>
		// Token: 0x0600A0F8 RID: 41208 RVA: 0x000E4988 File Offset: 0x000E2B88
		public void SetRepresentation(vtkSliderRepresentation r)
		{
			vtkSliderWidget.vtkSliderWidget_SetRepresentation_21(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CF8 RID: 3320
		public new const string MRFullTypeName = "Kitware.VTK.vtkSliderWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CF9 RID: 3321
		public new static readonly string MRClassNameKey = "class vtkSliderWidget";
	}
}
