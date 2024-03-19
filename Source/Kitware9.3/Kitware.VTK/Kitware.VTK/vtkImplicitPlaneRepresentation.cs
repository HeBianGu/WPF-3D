using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImplicitPlaneRepresentation
	/// </summary>
	/// <remarks>
	///    a class defining the representation for a vtkImplicitPlaneWidget2
	///
	/// This class is a concrete representation for the
	/// vtkImplicitPlaneWidget2. It represents an infinite plane defined by a
	/// normal and point in the context of a bounding box. Through interaction
	/// with the widget, the plane can be manipulated by adjusting the plane
	/// normal or moving the origin point.
	///
	/// To use this representation, you normally define a (plane) origin and (plane)
	/// normal. The PlaceWidget() method is also used to initially position the
	/// representation.
	///
	/// @warning
	/// This class, and vtkImplicitPlaneWidget2, are next generation VTK
	/// widgets. An earlier version of this functionality was defined in the
	/// class vtkImplicitPlaneWidget.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkImplicitPlaneWidget2 vtkImplicitPlaneWidget vtkImplicitImageRepresentation
	/// </seealso>
	// Token: 0x0200032D RID: 813
	public class vtkImplicitPlaneRepresentation : vtkWidgetRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060092BD RID: 37565 RVA: 0x000D0393 File Offset: 0x000CE593
		static vtkImplicitPlaneRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImplicitPlaneRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImplicitPlaneRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060092BE RID: 37566 RVA: 0x000D03BB File Offset: 0x000CE5BB
		public vtkImplicitPlaneRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060092BF RID: 37567
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitPlaneRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x060092C0 RID: 37568 RVA: 0x000D03CC File Offset: 0x000CE5CC
		public new static vtkImplicitPlaneRepresentation New()
		{
			vtkImplicitPlaneRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitPlaneRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x060092C1 RID: 37569 RVA: 0x000D0420 File Offset: 0x000CE620
		public vtkImplicitPlaneRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060092C2 RID: 37570 RVA: 0x000D0464 File Offset: 0x000CE664
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060092C3 RID: 37571
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_BuildRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Methods to interface with the vtkImplicitPlaneWidget2.
		/// </summary>
		// Token: 0x060092C4 RID: 37572 RVA: 0x000D046F File Offset: 0x000CE66F
		public override void BuildRepresentation()
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		// Token: 0x060092C5 RID: 37573
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_BumpPlane_02(HandleRef pThis, int dir, double factor);

		/// <summary>
		/// Translate the plane in the direction of the normal by the
		/// specified BumpDistance.  The dir parameter controls which
		/// direction the pushing occurs, either in the same direction
		/// as the normal, or when negative, in the opposite direction.
		/// The factor controls whether what percentage of the bump is
		/// used.
		/// </summary>
		// Token: 0x060092C6 RID: 37574 RVA: 0x000D047E File Offset: 0x000CE67E
		public void BumpPlane(int dir, double factor)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_BumpPlane_02(base.GetCppThis(), dir, factor);
		}

		// Token: 0x060092C7 RID: 37575
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_ComplexInteraction_03(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata);

		/// <summary>
		/// Methods to interface with the vtkImplicitPlaneWidget2.
		/// </summary>
		// Token: 0x060092C8 RID: 37576 RVA: 0x000D0490 File Offset: 0x000CE690
		public override void ComplexInteraction(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_ComplexInteraction_03(base.GetCppThis(), (iren == null) ? default(HandleRef) : iren.GetCppThis(), (widget == null) ? default(HandleRef) : widget.GetCppThis(), arg2, calldata);
		}

		// Token: 0x060092C9 RID: 37577
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitPlaneRepresentation_ComputeComplexInteractionState_04(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata, int modify);

		/// <summary>
		/// Methods to interface with the vtkImplicitPlaneWidget2.
		/// </summary>
		// Token: 0x060092CA RID: 37578 RVA: 0x000D04D8 File Offset: 0x000CE6D8
		public override int ComputeComplexInteractionState(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata, int modify)
		{
			return vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_ComputeComplexInteractionState_04(base.GetCppThis(), (iren == null) ? default(HandleRef) : iren.GetCppThis(), (widget == null) ? default(HandleRef) : widget.GetCppThis(), arg2, calldata, modify);
		}

		// Token: 0x060092CB RID: 37579
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitPlaneRepresentation_ComputeInteractionState_05(HandleRef pThis, int X, int Y, int modify);

		/// <summary>
		/// Methods to interface with the vtkImplicitPlaneWidget2.
		/// </summary>
		// Token: 0x060092CC RID: 37580 RVA: 0x000D0528 File Offset: 0x000CE728
		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_ComputeInteractionState_05(base.GetCppThis(), X, Y, modify);
		}

		// Token: 0x060092CD RID: 37581
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_ConstrainToWidgetBoundsOff_06(HandleRef pThis);

		/// <summary>
		/// Turn on/off whether the plane should be constrained to the widget bounds.
		/// If on, the origin will not be allowed to move outside the set widget bounds.
		/// This is the default behaviour.
		/// If off, the origin can be freely moved and the widget outline will change
		/// accordingly.
		/// </summary>
		// Token: 0x060092CE RID: 37582 RVA: 0x000D054A File Offset: 0x000CE74A
		public virtual void ConstrainToWidgetBoundsOff()
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_ConstrainToWidgetBoundsOff_06(base.GetCppThis());
		}

		// Token: 0x060092CF RID: 37583
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_ConstrainToWidgetBoundsOn_07(HandleRef pThis);

		/// <summary>
		/// Turn on/off whether the plane should be constrained to the widget bounds.
		/// If on, the origin will not be allowed to move outside the set widget bounds.
		/// This is the default behaviour.
		/// If off, the origin can be freely moved and the widget outline will change
		/// accordingly.
		/// </summary>
		// Token: 0x060092D0 RID: 37584 RVA: 0x000D0559 File Offset: 0x000CE759
		public virtual void ConstrainToWidgetBoundsOn()
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_ConstrainToWidgetBoundsOn_07(base.GetCppThis());
		}

		// Token: 0x060092D1 RID: 37585
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_CropPlaneToBoundingBoxOff_08(HandleRef pThis);

		/// <summary>
		/// Control if the plane should be drawn cropped by the bounding box
		/// or without cropping. Defaults to on.
		/// </summary>
		// Token: 0x060092D2 RID: 37586 RVA: 0x000D0568 File Offset: 0x000CE768
		public virtual void CropPlaneToBoundingBoxOff()
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_CropPlaneToBoundingBoxOff_08(base.GetCppThis());
		}

		// Token: 0x060092D3 RID: 37587
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_CropPlaneToBoundingBoxOn_09(HandleRef pThis);

		/// <summary>
		/// Control if the plane should be drawn cropped by the bounding box
		/// or without cropping. Defaults to on.
		/// </summary>
		// Token: 0x060092D4 RID: 37588 RVA: 0x000D0577 File Offset: 0x000CE777
		public virtual void CropPlaneToBoundingBoxOn()
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_CropPlaneToBoundingBoxOn_09(base.GetCppThis());
		}

		// Token: 0x060092D5 RID: 37589
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_DrawOutlineOff_10(HandleRef pThis);

		/// <summary>
		/// Enable/disable the drawing of the outline.
		/// </summary>
		// Token: 0x060092D6 RID: 37590 RVA: 0x000D0586 File Offset: 0x000CE786
		public virtual void DrawOutlineOff()
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_DrawOutlineOff_10(base.GetCppThis());
		}

		// Token: 0x060092D7 RID: 37591
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_DrawOutlineOn_11(HandleRef pThis);

		/// <summary>
		/// Enable/disable the drawing of the outline.
		/// </summary>
		// Token: 0x060092D8 RID: 37592 RVA: 0x000D0595 File Offset: 0x000CE795
		public virtual void DrawOutlineOn()
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_DrawOutlineOn_11(base.GetCppThis());
		}

		// Token: 0x060092D9 RID: 37593
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_DrawPlaneOff_12(HandleRef pThis);

		/// <summary>
		/// Enable/disable the drawing of the plane. In some cases the plane
		/// interferes with the object that it is operating on (i.e., the
		/// plane interferes with the cut surface it produces producing
		/// z-buffer artifacts.)
		/// </summary>
		// Token: 0x060092DA RID: 37594 RVA: 0x000D05A4 File Offset: 0x000CE7A4
		public virtual void DrawPlaneOff()
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_DrawPlaneOff_12(base.GetCppThis());
		}

		// Token: 0x060092DB RID: 37595
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_DrawPlaneOn_13(HandleRef pThis);

		/// <summary>
		/// Enable/disable the drawing of the plane. In some cases the plane
		/// interferes with the object that it is operating on (i.e., the
		/// plane interferes with the cut surface it produces producing
		/// z-buffer artifacts.)
		/// </summary>
		// Token: 0x060092DC RID: 37596 RVA: 0x000D05B3 File Offset: 0x000CE7B3
		public virtual void DrawPlaneOn()
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_DrawPlaneOn_13(base.GetCppThis());
		}

		// Token: 0x060092DD RID: 37597
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_EndComplexInteraction_14(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata);

		/// <summary>
		/// Methods to interface with the vtkImplicitPlaneWidget2.
		/// </summary>
		// Token: 0x060092DE RID: 37598 RVA: 0x000D05C4 File Offset: 0x000CE7C4
		public override void EndComplexInteraction(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_EndComplexInteraction_14(base.GetCppThis(), (iren == null) ? default(HandleRef) : iren.GetCppThis(), (widget == null) ? default(HandleRef) : widget.GetCppThis(), arg2, calldata);
		}

		// Token: 0x060092DF RID: 37599
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_EndWidgetInteraction_15(HandleRef pThis, IntPtr newEventPos);

		/// <summary>
		/// Methods to interface with the vtkImplicitPlaneWidget2.
		/// </summary>
		// Token: 0x060092E0 RID: 37600 RVA: 0x000D060B File Offset: 0x000CE80B
		public override void EndWidgetInteraction(IntPtr newEventPos)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_EndWidgetInteraction_15(base.GetCppThis(), newEventPos);
		}

		// Token: 0x060092E1 RID: 37601
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_GetActors_16(HandleRef pThis, HandleRef pc);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x060092E2 RID: 37602 RVA: 0x000D061C File Offset: 0x000CE81C
		public override void GetActors(vtkPropCollection pc)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetActors_16(base.GetCppThis(), (pc == null) ? default(HandleRef) : pc.GetCppThis());
		}

		// Token: 0x060092E3 RID: 37603
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkImplicitPlaneRepresentation_GetAlwaysSnapToNearestAxis_17(HandleRef pThis);

		/// <summary>
		/// Forces the plane's normal to be aligned with x, y or z axis.
		/// The alignment happens when calling SetNormal.
		/// It defers with SnapToAxes from it is always applicable, and SnapToAxes
		/// only snaps when the angle difference exceeds 16 degrees in complex interactions.
		/// </summary>
		// Token: 0x060092E4 RID: 37604 RVA: 0x000D064C File Offset: 0x000CE84C
		public virtual bool GetAlwaysSnapToNearestAxis()
		{
			return vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetAlwaysSnapToNearestAxis_17(base.GetCppThis()) != 0;
		}

		// Token: 0x060092E5 RID: 37605
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitPlaneRepresentation_GetBounds_18(HandleRef pThis);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x060092E6 RID: 37606 RVA: 0x000D0674 File Offset: 0x000CE874
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetBounds_18(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060092E7 RID: 37607
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImplicitPlaneRepresentation_GetBumpDistance_19(HandleRef pThis);

		/// <summary>
		/// Specify a translation distance used by the BumpPlane() method. Note that the
		/// distance is normalized; it is the fraction of the length of the bounding
		/// box of the wire outline.
		/// </summary>
		// Token: 0x060092E8 RID: 37608 RVA: 0x000D06BC File Offset: 0x000CE8BC
		public virtual double GetBumpDistance()
		{
			return vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetBumpDistance_19(base.GetCppThis());
		}

		// Token: 0x060092E9 RID: 37609
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImplicitPlaneRepresentation_GetBumpDistanceMaxValue_20(HandleRef pThis);

		/// <summary>
		/// Specify a translation distance used by the BumpPlane() method. Note that the
		/// distance is normalized; it is the fraction of the length of the bounding
		/// box of the wire outline.
		/// </summary>
		// Token: 0x060092EA RID: 37610 RVA: 0x000D06DC File Offset: 0x000CE8DC
		public virtual double GetBumpDistanceMaxValue()
		{
			return vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetBumpDistanceMaxValue_20(base.GetCppThis());
		}

		// Token: 0x060092EB RID: 37611
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImplicitPlaneRepresentation_GetBumpDistanceMinValue_21(HandleRef pThis);

		/// <summary>
		/// Specify a translation distance used by the BumpPlane() method. Note that the
		/// distance is normalized; it is the fraction of the length of the bounding
		/// box of the wire outline.
		/// </summary>
		// Token: 0x060092EC RID: 37612 RVA: 0x000D06FC File Offset: 0x000CE8FC
		public virtual double GetBumpDistanceMinValue()
		{
			return vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetBumpDistanceMinValue_21(base.GetCppThis());
		}

		// Token: 0x060092ED RID: 37613
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitPlaneRepresentation_GetConstrainToWidgetBounds_22(HandleRef pThis);

		/// <summary>
		/// Turn on/off whether the plane should be constrained to the widget bounds.
		/// If on, the origin will not be allowed to move outside the set widget bounds.
		/// This is the default behaviour.
		/// If off, the origin can be freely moved and the widget outline will change
		/// accordingly.
		/// </summary>
		// Token: 0x060092EE RID: 37614 RVA: 0x000D071C File Offset: 0x000CE91C
		public virtual int GetConstrainToWidgetBounds()
		{
			return vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetConstrainToWidgetBounds_22(base.GetCppThis());
		}

		// Token: 0x060092EF RID: 37615
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkImplicitPlaneRepresentation_GetCropPlaneToBoundingBox_23(HandleRef pThis);

		/// <summary>
		/// Control if the plane should be drawn cropped by the bounding box
		/// or without cropping. Defaults to on.
		/// </summary>
		// Token: 0x060092F0 RID: 37616 RVA: 0x000D073C File Offset: 0x000CE93C
		public virtual bool GetCropPlaneToBoundingBox()
		{
			return vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetCropPlaneToBoundingBox_23(base.GetCppThis()) != 0;
		}

		// Token: 0x060092F1 RID: 37617
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitPlaneRepresentation_GetDrawOutline_24(HandleRef pThis);

		/// <summary>
		/// Enable/disable the drawing of the outline.
		/// </summary>
		// Token: 0x060092F2 RID: 37618 RVA: 0x000D0764 File Offset: 0x000CE964
		public virtual int GetDrawOutline()
		{
			return vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetDrawOutline_24(base.GetCppThis());
		}

		// Token: 0x060092F3 RID: 37619
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitPlaneRepresentation_GetDrawPlane_25(HandleRef pThis);

		/// <summary>
		/// Enable/disable the drawing of the plane. In some cases the plane
		/// interferes with the object that it is operating on (i.e., the
		/// plane interferes with the cut surface it produces producing
		/// z-buffer artifacts.)
		/// </summary>
		// Token: 0x060092F4 RID: 37620 RVA: 0x000D0784 File Offset: 0x000CE984
		public virtual int GetDrawPlane()
		{
			return vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetDrawPlane_25(base.GetCppThis());
		}

		// Token: 0x060092F5 RID: 37621
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitPlaneRepresentation_GetEdgesProperty_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the property of the intersection edges. (This property also
		/// applies to the edges when tubed.)
		/// </summary>
		// Token: 0x060092F6 RID: 37622 RVA: 0x000D07A4 File Offset: 0x000CE9A4
		public virtual vtkProperty GetEdgesProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetEdgesProperty_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x060092F7 RID: 37623
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitPlaneRepresentation_GetInteractionStateMaxValue_27(HandleRef pThis);

		/// <summary>
		/// The interaction state may be set from a widget (e.g.,
		/// vtkImplicitPlaneWidget2) or other object. This controls how the
		/// interaction with the widget proceeds. Normally this method is used as
		/// part of a handshaking process with the widget: First
		/// ComputeInteractionState() is invoked that returns a state based on
		/// geometric considerations (i.e., cursor near a widget feature), then
		/// based on events, the widget may modify this further.
		/// </summary>
		// Token: 0x060092F8 RID: 37624 RVA: 0x000D0814 File Offset: 0x000CEA14
		public virtual int GetInteractionStateMaxValue()
		{
			return vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetInteractionStateMaxValue_27(base.GetCppThis());
		}

		// Token: 0x060092F9 RID: 37625
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitPlaneRepresentation_GetInteractionStateMinValue_28(HandleRef pThis);

		/// <summary>
		/// The interaction state may be set from a widget (e.g.,
		/// vtkImplicitPlaneWidget2) or other object. This controls how the
		/// interaction with the widget proceeds. Normally this method is used as
		/// part of a handshaking process with the widget: First
		/// ComputeInteractionState() is invoked that returns a state based on
		/// geometric considerations (i.e., cursor near a widget feature), then
		/// based on events, the widget may modify this further.
		/// </summary>
		// Token: 0x060092FA RID: 37626 RVA: 0x000D0834 File Offset: 0x000CEA34
		public virtual int GetInteractionStateMinValue()
		{
			return vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetInteractionStateMinValue_28(base.GetCppThis());
		}

		// Token: 0x060092FB RID: 37627
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitPlaneRepresentation_GetLockNormalToCamera_29(HandleRef pThis);

		/// <summary>
		/// If enabled, and a vtkCamera is available through the renderer, then
		/// LockNormalToCamera will cause the normal to follow the camera's
		/// normal.
		/// </summary>
		// Token: 0x060092FC RID: 37628 RVA: 0x000D0854 File Offset: 0x000CEA54
		public virtual int GetLockNormalToCamera()
		{
			return vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetLockNormalToCamera_29(base.GetCppThis());
		}

		// Token: 0x060092FD RID: 37629
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitPlaneRepresentation_GetNormal_30(HandleRef pThis);

		/// <summary>
		/// Get the normal to the plane.
		/// </summary>
		// Token: 0x060092FE RID: 37630 RVA: 0x000D0874 File Offset: 0x000CEA74
		public double[] GetNormal()
		{
			IntPtr intPtr = vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetNormal_30(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060092FF RID: 37631
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_GetNormal_31(HandleRef pThis, IntPtr xyz);

		/// <summary>
		/// Get the normal to the plane.
		/// </summary>
		// Token: 0x06009300 RID: 37632 RVA: 0x000D08BC File Offset: 0x000CEABC
		public void GetNormal(IntPtr xyz)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetNormal_31(base.GetCppThis(), xyz);
		}

		// Token: 0x06009301 RID: 37633
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitPlaneRepresentation_GetNormalProperty_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the properties on the normal (line and cone).
		/// </summary>
		// Token: 0x06009302 RID: 37634 RVA: 0x000D08CC File Offset: 0x000CEACC
		public virtual vtkProperty GetNormalProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetNormalProperty_32(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x06009303 RID: 37635
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitPlaneRepresentation_GetNormalToXAxis_33(HandleRef pThis);

		/// <summary>
		/// Force the plane widget to be aligned with one of the x-y-z axes.
		/// If one axis is set on, the other two will be set off.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the plane to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x06009304 RID: 37636 RVA: 0x000D093C File Offset: 0x000CEB3C
		public virtual int GetNormalToXAxis()
		{
			return vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetNormalToXAxis_33(base.GetCppThis());
		}

		// Token: 0x06009305 RID: 37637
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitPlaneRepresentation_GetNormalToYAxis_34(HandleRef pThis);

		/// <summary>
		/// Force the plane widget to be aligned with one of the x-y-z axes.
		/// If one axis is set on, the other two will be set off.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the plane to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x06009306 RID: 37638 RVA: 0x000D095C File Offset: 0x000CEB5C
		public virtual int GetNormalToYAxis()
		{
			return vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetNormalToYAxis_34(base.GetCppThis());
		}

		// Token: 0x06009307 RID: 37639
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitPlaneRepresentation_GetNormalToZAxis_35(HandleRef pThis);

		/// <summary>
		/// Force the plane widget to be aligned with one of the x-y-z axes.
		/// If one axis is set on, the other two will be set off.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the plane to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x06009308 RID: 37640 RVA: 0x000D097C File Offset: 0x000CEB7C
		public virtual int GetNormalToZAxis()
		{
			return vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetNormalToZAxis_35(base.GetCppThis());
		}

		// Token: 0x06009309 RID: 37641
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImplicitPlaneRepresentation_GetNumberOfGenerationsFromBase_36(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x0600930A RID: 37642 RVA: 0x000D099C File Offset: 0x000CEB9C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetNumberOfGenerationsFromBase_36(base.GetCppThis(), type);
		}

		// Token: 0x0600930B RID: 37643
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImplicitPlaneRepresentation_GetNumberOfGenerationsFromBaseType_37([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x0600930C RID: 37644 RVA: 0x000D09BC File Offset: 0x000CEBBC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetNumberOfGenerationsFromBaseType_37(type);
		}

		// Token: 0x0600930D RID: 37645
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitPlaneRepresentation_GetOrigin_38(HandleRef pThis);

		/// <summary>
		/// Get the origin of the plane.
		/// </summary>
		// Token: 0x0600930E RID: 37646 RVA: 0x000D09D8 File Offset: 0x000CEBD8
		public double[] GetOrigin()
		{
			IntPtr intPtr = vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetOrigin_38(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600930F RID: 37647
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_GetOrigin_39(HandleRef pThis, IntPtr xyz);

		/// <summary>
		/// Get the origin of the plane.
		/// </summary>
		// Token: 0x06009310 RID: 37648 RVA: 0x000D0A20 File Offset: 0x000CEC20
		public void GetOrigin(IntPtr xyz)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetOrigin_39(base.GetCppThis(), xyz);
		}

		// Token: 0x06009311 RID: 37649
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitPlaneRepresentation_GetOutlineProperty_40(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the property of the outline.
		/// </summary>
		// Token: 0x06009312 RID: 37650 RVA: 0x000D0A30 File Offset: 0x000CEC30
		public virtual vtkProperty GetOutlineProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetOutlineProperty_40(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x06009313 RID: 37651
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitPlaneRepresentation_GetOutlineTranslation_41(HandleRef pThis);

		/// <summary>
		/// Turn on/off the ability to translate the bounding box by grabbing it
		/// with the left mouse button.
		/// </summary>
		// Token: 0x06009314 RID: 37652 RVA: 0x000D0AA0 File Offset: 0x000CECA0
		public virtual int GetOutlineTranslation()
		{
			return vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetOutlineTranslation_41(base.GetCppThis());
		}

		// Token: 0x06009315 RID: 37653
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitPlaneRepresentation_GetOutsideBounds_42(HandleRef pThis);

		/// <summary>
		/// Turn on/off the ability to move the widget outside of the bounds
		/// specified in the initial PlaceWidget() invocation.
		/// </summary>
		// Token: 0x06009316 RID: 37654 RVA: 0x000D0AC0 File Offset: 0x000CECC0
		public virtual int GetOutsideBounds()
		{
			return vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetOutsideBounds_42(base.GetCppThis());
		}

		// Token: 0x06009317 RID: 37655
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_GetPlane_43(HandleRef pThis, HandleRef plane);

		/// <summary>
		/// Get the implicit function for the plane by copying the origin and normal
		/// of the cut plane into the provided vtkPlane. The user must provide the
		/// instance of the class vtkPlane. Note that vtkPlane is a subclass of
		/// vtkImplicitFunction, meaning that it can be used by a variety of filters
		/// to perform clipping, cutting, and selection of data.
		/// </summary>
		// Token: 0x06009318 RID: 37656 RVA: 0x000D0AE0 File Offset: 0x000CECE0
		public void GetPlane(vtkPlane plane)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetPlane_43(base.GetCppThis(), (plane == null) ? default(HandleRef) : plane.GetCppThis());
		}

		// Token: 0x06009319 RID: 37657
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitPlaneRepresentation_GetPlaneProperty_44(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the plane properties. The properties of the plane when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x0600931A RID: 37658 RVA: 0x000D0B10 File Offset: 0x000CED10
		public virtual vtkProperty GetPlaneProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetPlaneProperty_44(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x0600931B RID: 37659
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_GetPolyData_45(HandleRef pThis, HandleRef pd);

		/// <summary>
		/// Grab the polydata that defines the plane. The polydata contains a single
		/// polygon that is clipped by the bounding box.
		/// </summary>
		// Token: 0x0600931C RID: 37660 RVA: 0x000D0B80 File Offset: 0x000CED80
		public void GetPolyData(vtkPolyData pd)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetPolyData_45(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x0600931D RID: 37661
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitPlaneRepresentation_GetPolyDataAlgorithm_46(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Satisfies superclass API.  This returns a pointer to the underlying
		/// PolyData (which represents the plane).
		/// </summary>
		// Token: 0x0600931E RID: 37662 RVA: 0x000D0BB0 File Offset: 0x000CEDB0
		public vtkPolyDataAlgorithm GetPolyDataAlgorithm()
		{
			vtkPolyDataAlgorithm vtkPolyDataAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetPolyDataAlgorithm_46(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataAlgorithm = (vtkPolyDataAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataAlgorithm.Register(null);
				}
			}
			return vtkPolyDataAlgorithm;
		}

		// Token: 0x0600931F RID: 37663
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitPlaneRepresentation_GetRepresentationState_47(HandleRef pThis);

		/// <summary>
		/// Sets the visual appearance of the representation based on the
		/// state it is in. This state is usually the same as InteractionState.
		/// </summary>
		// Token: 0x06009320 RID: 37664 RVA: 0x000D0C20 File Offset: 0x000CEE20
		public virtual int GetRepresentationState()
		{
			return vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetRepresentationState_47(base.GetCppThis());
		}

		// Token: 0x06009321 RID: 37665
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitPlaneRepresentation_GetScaleEnabled_48(HandleRef pThis);

		/// <summary>
		/// Turn on/off the ability to scale the widget with the mouse.
		/// </summary>
		// Token: 0x06009322 RID: 37666 RVA: 0x000D0C40 File Offset: 0x000CEE40
		public virtual int GetScaleEnabled()
		{
			return vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetScaleEnabled_48(base.GetCppThis());
		}

		// Token: 0x06009323 RID: 37667
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitPlaneRepresentation_GetSelectedNormalProperty_49(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the properties on the normal (line and cone).
		/// </summary>
		// Token: 0x06009324 RID: 37668 RVA: 0x000D0C60 File Offset: 0x000CEE60
		public virtual vtkProperty GetSelectedNormalProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetSelectedNormalProperty_49(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x06009325 RID: 37669
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitPlaneRepresentation_GetSelectedOutlineProperty_50(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the property of the outline.
		/// </summary>
		// Token: 0x06009326 RID: 37670 RVA: 0x000D0CD0 File Offset: 0x000CEED0
		public virtual vtkProperty GetSelectedOutlineProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetSelectedOutlineProperty_50(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x06009327 RID: 37671
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitPlaneRepresentation_GetSelectedPlaneProperty_51(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the plane properties. The properties of the plane when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x06009328 RID: 37672 RVA: 0x000D0D40 File Offset: 0x000CEF40
		public virtual vtkProperty GetSelectedPlaneProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetSelectedPlaneProperty_51(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x06009329 RID: 37673
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkImplicitPlaneRepresentation_GetSnapToAxes_52(HandleRef pThis);

		/// <summary>
		/// For complex events should we snap orientations to
		/// be aligned with the x y z axes
		/// </summary>
		// Token: 0x0600932A RID: 37674 RVA: 0x000D0DB0 File Offset: 0x000CEFB0
		public virtual bool GetSnapToAxes()
		{
			return vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetSnapToAxes_52(base.GetCppThis()) != 0;
		}

		// Token: 0x0600932B RID: 37675
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitPlaneRepresentation_GetTubing_53(HandleRef pThis);

		/// <summary>
		/// Turn on/off tubing of the wire outline of the plane. The tube thickens
		/// the line by wrapping with a vtkTubeFilter.
		/// </summary>
		// Token: 0x0600932C RID: 37676 RVA: 0x000D0DD8 File Offset: 0x000CEFD8
		public virtual int GetTubing()
		{
			return vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetTubing_53(base.GetCppThis());
		}

		// Token: 0x0600932D RID: 37677
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitPlaneRepresentation_GetUnderlyingPlane_54(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Sets the visual appearance of the representation based on the
		/// state it is in. This state is usually the same as InteractionState.
		/// </summary>
		// Token: 0x0600932E RID: 37678 RVA: 0x000D0DF8 File Offset: 0x000CEFF8
		public vtkPlane GetUnderlyingPlane()
		{
			vtkPlane vtkPlane = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetUnderlyingPlane_54(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlane = (vtkPlane)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlane.Register(null);
				}
			}
			return vtkPlane;
		}

		// Token: 0x0600932F RID: 37679
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitPlaneRepresentation_GetWidgetBounds_55(HandleRef pThis);

		/// <summary>
		/// Set/Get the bounds of the widget representation. PlaceWidget can also be
		/// used to set the bounds of the widget but it may also have other effects
		/// on the internal state of the representation. Use this function when only
		/// the widget bounds are needs to be modified.
		/// </summary>
		// Token: 0x06009330 RID: 37680 RVA: 0x000D0E68 File Offset: 0x000CF068
		public virtual double[] GetWidgetBounds()
		{
			IntPtr intPtr = vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetWidgetBounds_55(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06009331 RID: 37681
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_GetWidgetBounds_56(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6);

		/// <summary>
		/// Set/Get the bounds of the widget representation. PlaceWidget can also be
		/// used to set the bounds of the widget but it may also have other effects
		/// on the internal state of the representation. Use this function when only
		/// the widget bounds are needs to be modified.
		/// </summary>
		// Token: 0x06009332 RID: 37682 RVA: 0x000D0EB0 File Offset: 0x000CF0B0
		public virtual void GetWidgetBounds(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetWidgetBounds_56(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		// Token: 0x06009333 RID: 37683
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_GetWidgetBounds_57(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the bounds of the widget representation. PlaceWidget can also be
		/// used to set the bounds of the widget but it may also have other effects
		/// on the internal state of the representation. Use this function when only
		/// the widget bounds are needs to be modified.
		/// </summary>
		// Token: 0x06009334 RID: 37684 RVA: 0x000D0EC8 File Offset: 0x000CF0C8
		public virtual void GetWidgetBounds(IntPtr _arg)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetWidgetBounds_57(base.GetCppThis(), _arg);
		}

		// Token: 0x06009335 RID: 37685
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitPlaneRepresentation_HasTranslucentPolygonalGeometry_58(HandleRef pThis);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x06009336 RID: 37686 RVA: 0x000D0ED8 File Offset: 0x000CF0D8
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_HasTranslucentPolygonalGeometry_58(base.GetCppThis());
		}

		// Token: 0x06009337 RID: 37687
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitPlaneRepresentation_IsA_59(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06009338 RID: 37688 RVA: 0x000D0EF8 File Offset: 0x000CF0F8
		public override int IsA(string type)
		{
			return vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_IsA_59(base.GetCppThis(), type);
		}

		// Token: 0x06009339 RID: 37689
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkImplicitPlaneRepresentation_IsTranslationConstrained_60(HandleRef pThis);

		/// <summary>
		/// Returns true if ConstrainedAxis
		/// </summary>
		// Token: 0x0600933A RID: 37690 RVA: 0x000D0F18 File Offset: 0x000CF118
		public bool IsTranslationConstrained()
		{
			return vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_IsTranslationConstrained_60(base.GetCppThis()) != 0;
		}

		// Token: 0x0600933B RID: 37691
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitPlaneRepresentation_IsTypeOf_61([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x0600933C RID: 37692 RVA: 0x000D0F40 File Offset: 0x000CF140
		public new static int IsTypeOf(string type)
		{
			return vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_IsTypeOf_61(type);
		}

		// Token: 0x0600933D RID: 37693
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_LockNormalToCameraOff_62(HandleRef pThis);

		/// <summary>
		/// If enabled, and a vtkCamera is available through the renderer, then
		/// LockNormalToCamera will cause the normal to follow the camera's
		/// normal.
		/// </summary>
		// Token: 0x0600933E RID: 37694 RVA: 0x000D0F5A File Offset: 0x000CF15A
		public virtual void LockNormalToCameraOff()
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_LockNormalToCameraOff_62(base.GetCppThis());
		}

		// Token: 0x0600933F RID: 37695
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_LockNormalToCameraOn_63(HandleRef pThis);

		/// <summary>
		/// If enabled, and a vtkCamera is available through the renderer, then
		/// LockNormalToCamera will cause the normal to follow the camera's
		/// normal.
		/// </summary>
		// Token: 0x06009340 RID: 37696 RVA: 0x000D0F69 File Offset: 0x000CF169
		public virtual void LockNormalToCameraOn()
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_LockNormalToCameraOn_63(base.GetCppThis());
		}

		// Token: 0x06009341 RID: 37697
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitPlaneRepresentation_NewInstance_65(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06009342 RID: 37698 RVA: 0x000D0F78 File Offset: 0x000CF178
		public new vtkImplicitPlaneRepresentation NewInstance()
		{
			vtkImplicitPlaneRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_NewInstance_65(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitPlaneRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06009343 RID: 37699
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_NormalToXAxisOff_66(HandleRef pThis);

		/// <summary>
		/// Force the plane widget to be aligned with one of the x-y-z axes.
		/// If one axis is set on, the other two will be set off.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the plane to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x06009344 RID: 37700 RVA: 0x000D0FD2 File Offset: 0x000CF1D2
		public virtual void NormalToXAxisOff()
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_NormalToXAxisOff_66(base.GetCppThis());
		}

		// Token: 0x06009345 RID: 37701
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_NormalToXAxisOn_67(HandleRef pThis);

		/// <summary>
		/// Force the plane widget to be aligned with one of the x-y-z axes.
		/// If one axis is set on, the other two will be set off.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the plane to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x06009346 RID: 37702 RVA: 0x000D0FE1 File Offset: 0x000CF1E1
		public virtual void NormalToXAxisOn()
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_NormalToXAxisOn_67(base.GetCppThis());
		}

		// Token: 0x06009347 RID: 37703
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_NormalToYAxisOff_68(HandleRef pThis);

		/// <summary>
		/// Force the plane widget to be aligned with one of the x-y-z axes.
		/// If one axis is set on, the other two will be set off.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the plane to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x06009348 RID: 37704 RVA: 0x000D0FF0 File Offset: 0x000CF1F0
		public virtual void NormalToYAxisOff()
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_NormalToYAxisOff_68(base.GetCppThis());
		}

		// Token: 0x06009349 RID: 37705
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_NormalToYAxisOn_69(HandleRef pThis);

		/// <summary>
		/// Force the plane widget to be aligned with one of the x-y-z axes.
		/// If one axis is set on, the other two will be set off.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the plane to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x0600934A RID: 37706 RVA: 0x000D0FFF File Offset: 0x000CF1FF
		public virtual void NormalToYAxisOn()
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_NormalToYAxisOn_69(base.GetCppThis());
		}

		// Token: 0x0600934B RID: 37707
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_NormalToZAxisOff_70(HandleRef pThis);

		/// <summary>
		/// Force the plane widget to be aligned with one of the x-y-z axes.
		/// If one axis is set on, the other two will be set off.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the plane to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x0600934C RID: 37708 RVA: 0x000D100E File Offset: 0x000CF20E
		public virtual void NormalToZAxisOff()
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_NormalToZAxisOff_70(base.GetCppThis());
		}

		// Token: 0x0600934D RID: 37709
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_NormalToZAxisOn_71(HandleRef pThis);

		/// <summary>
		/// Force the plane widget to be aligned with one of the x-y-z axes.
		/// If one axis is set on, the other two will be set off.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the plane to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x0600934E RID: 37710 RVA: 0x000D101D File Offset: 0x000CF21D
		public virtual void NormalToZAxisOn()
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_NormalToZAxisOn_71(base.GetCppThis());
		}

		// Token: 0x0600934F RID: 37711
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_OutlineTranslationOff_72(HandleRef pThis);

		/// <summary>
		/// Turn on/off the ability to translate the bounding box by grabbing it
		/// with the left mouse button.
		/// </summary>
		// Token: 0x06009350 RID: 37712 RVA: 0x000D102C File Offset: 0x000CF22C
		public virtual void OutlineTranslationOff()
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_OutlineTranslationOff_72(base.GetCppThis());
		}

		// Token: 0x06009351 RID: 37713
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_OutlineTranslationOn_73(HandleRef pThis);

		/// <summary>
		/// Turn on/off the ability to translate the bounding box by grabbing it
		/// with the left mouse button.
		/// </summary>
		// Token: 0x06009352 RID: 37714 RVA: 0x000D103B File Offset: 0x000CF23B
		public virtual void OutlineTranslationOn()
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_OutlineTranslationOn_73(base.GetCppThis());
		}

		// Token: 0x06009353 RID: 37715
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_OutsideBoundsOff_74(HandleRef pThis);

		/// <summary>
		/// Turn on/off the ability to move the widget outside of the bounds
		/// specified in the initial PlaceWidget() invocation.
		/// </summary>
		// Token: 0x06009354 RID: 37716 RVA: 0x000D104A File Offset: 0x000CF24A
		public virtual void OutsideBoundsOff()
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_OutsideBoundsOff_74(base.GetCppThis());
		}

		// Token: 0x06009355 RID: 37717
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_OutsideBoundsOn_75(HandleRef pThis);

		/// <summary>
		/// Turn on/off the ability to move the widget outside of the bounds
		/// specified in the initial PlaceWidget() invocation.
		/// </summary>
		// Token: 0x06009356 RID: 37718 RVA: 0x000D1059 File Offset: 0x000CF259
		public virtual void OutsideBoundsOn()
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_OutsideBoundsOn_75(base.GetCppThis());
		}

		// Token: 0x06009357 RID: 37719
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_PlaceWidget_76(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Methods to interface with the vtkImplicitPlaneWidget2.
		/// </summary>
		// Token: 0x06009358 RID: 37720 RVA: 0x000D1068 File Offset: 0x000CF268
		public override void PlaceWidget(IntPtr bounds)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_PlaceWidget_76(base.GetCppThis(), bounds);
		}

		// Token: 0x06009359 RID: 37721
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_PushPlane_77(HandleRef pThis, double distance);

		/// <summary>
		/// Push the plane the distance specified along the normal. Positive
		/// values are in the direction of the normal; negative values are
		/// in the opposite direction of the normal. The distance value is
		/// expressed in world coordinates.
		/// </summary>
		// Token: 0x0600935A RID: 37722 RVA: 0x000D1078 File Offset: 0x000CF278
		public void PushPlane(double distance)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_PushPlane_77(base.GetCppThis(), distance);
		}

		// Token: 0x0600935B RID: 37723
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_ReleaseGraphicsResources_78(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x0600935C RID: 37724 RVA: 0x000D1088 File Offset: 0x000CF288
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_ReleaseGraphicsResources_78(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600935D RID: 37725
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitPlaneRepresentation_RenderOpaqueGeometry_79(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x0600935E RID: 37726 RVA: 0x000D10B8 File Offset: 0x000CF2B8
		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_RenderOpaqueGeometry_79(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600935F RID: 37727
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitPlaneRepresentation_RenderTranslucentPolygonalGeometry_80(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x06009360 RID: 37728 RVA: 0x000D10EC File Offset: 0x000CF2EC
		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_RenderTranslucentPolygonalGeometry_80(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06009361 RID: 37729
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitPlaneRepresentation_SafeDownCast_81(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06009362 RID: 37730 RVA: 0x000D1120 File Offset: 0x000CF320
		public new static vtkImplicitPlaneRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkImplicitPlaneRepresentation vtkImplicitPlaneRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SafeDownCast_81((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitPlaneRepresentation = (vtkImplicitPlaneRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitPlaneRepresentation.Register(null);
				}
			}
			return vtkImplicitPlaneRepresentation;
		}

		// Token: 0x06009363 RID: 37731
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_ScaleEnabledOff_82(HandleRef pThis);

		/// <summary>
		/// Turn on/off the ability to scale the widget with the mouse.
		/// </summary>
		// Token: 0x06009364 RID: 37732 RVA: 0x000D119F File Offset: 0x000CF39F
		public virtual void ScaleEnabledOff()
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_ScaleEnabledOff_82(base.GetCppThis());
		}

		// Token: 0x06009365 RID: 37733
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_ScaleEnabledOn_83(HandleRef pThis);

		/// <summary>
		/// Turn on/off the ability to scale the widget with the mouse.
		/// </summary>
		// Token: 0x06009366 RID: 37734 RVA: 0x000D11AE File Offset: 0x000CF3AE
		public virtual void ScaleEnabledOn()
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_ScaleEnabledOn_83(base.GetCppThis());
		}

		// Token: 0x06009367 RID: 37735
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_SetAlwaysSnapToNearestAxis_84(HandleRef pThis, byte snap);

		/// <summary>
		/// Forces the plane's normal to be aligned with x, y or z axis.
		/// The alignment happens when calling SetNormal.
		/// It defers with SnapToAxes from it is always applicable, and SnapToAxes
		/// only snaps when the angle difference exceeds 16 degrees in complex interactions.
		/// </summary>
		// Token: 0x06009368 RID: 37736 RVA: 0x000D11BD File Offset: 0x000CF3BD
		public virtual void SetAlwaysSnapToNearestAxis(bool snap)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SetAlwaysSnapToNearestAxis_84(base.GetCppThis(), snap ? (byte)1 : (byte)0);
		}

		// Token: 0x06009369 RID: 37737
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_SetBumpDistance_85(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify a translation distance used by the BumpPlane() method. Note that the
		/// distance is normalized; it is the fraction of the length of the bounding
		/// box of the wire outline.
		/// </summary>
		// Token: 0x0600936A RID: 37738 RVA: 0x000D11D5 File Offset: 0x000CF3D5
		public virtual void SetBumpDistance(double _arg)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SetBumpDistance_85(base.GetCppThis(), _arg);
		}

		// Token: 0x0600936B RID: 37739
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_SetConstrainToWidgetBounds_86(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off whether the plane should be constrained to the widget bounds.
		/// If on, the origin will not be allowed to move outside the set widget bounds.
		/// This is the default behaviour.
		/// If off, the origin can be freely moved and the widget outline will change
		/// accordingly.
		/// </summary>
		// Token: 0x0600936C RID: 37740 RVA: 0x000D11E5 File Offset: 0x000CF3E5
		public virtual void SetConstrainToWidgetBounds(int _arg)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SetConstrainToWidgetBounds_86(base.GetCppThis(), _arg);
		}

		// Token: 0x0600936D RID: 37741
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_SetCropPlaneToBoundingBox_87(HandleRef pThis, byte arg0);

		/// <summary>
		/// Control if the plane should be drawn cropped by the bounding box
		/// or without cropping. Defaults to on.
		/// </summary>
		// Token: 0x0600936E RID: 37742 RVA: 0x000D11F5 File Offset: 0x000CF3F5
		public virtual void SetCropPlaneToBoundingBox(bool arg0)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SetCropPlaneToBoundingBox_87(base.GetCppThis(), arg0 ? (byte)1 : (byte)0);
		}

		// Token: 0x0600936F RID: 37743
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_SetDrawOutline_88(HandleRef pThis, int plane);

		/// <summary>
		/// Enable/disable the drawing of the outline.
		/// </summary>
		// Token: 0x06009370 RID: 37744 RVA: 0x000D120D File Offset: 0x000CF40D
		public void SetDrawOutline(int plane)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SetDrawOutline_88(base.GetCppThis(), plane);
		}

		// Token: 0x06009371 RID: 37745
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_SetDrawPlane_89(HandleRef pThis, int plane);

		/// <summary>
		/// Enable/disable the drawing of the plane. In some cases the plane
		/// interferes with the object that it is operating on (i.e., the
		/// plane interferes with the cut surface it produces producing
		/// z-buffer artifacts.)
		/// </summary>
		// Token: 0x06009372 RID: 37746 RVA: 0x000D121D File Offset: 0x000CF41D
		public void SetDrawPlane(int plane)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SetDrawPlane_89(base.GetCppThis(), plane);
		}

		// Token: 0x06009373 RID: 37747
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_SetEdgeColor_90(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set color to the edge
		/// </summary>
		// Token: 0x06009374 RID: 37748 RVA: 0x000D1230 File Offset: 0x000CF430
		public void SetEdgeColor(vtkLookupTable arg0)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SetEdgeColor_90(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06009375 RID: 37749
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_SetEdgeColor_91(HandleRef pThis, double arg0, double arg1, double arg2);

		/// <summary>
		/// Set color to the edge
		/// </summary>
		// Token: 0x06009376 RID: 37750 RVA: 0x000D125F File Offset: 0x000CF45F
		public void SetEdgeColor(double arg0, double arg1, double arg2)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SetEdgeColor_91(base.GetCppThis(), arg0, arg1, arg2);
		}

		// Token: 0x06009377 RID: 37751
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_SetEdgeColor_92(HandleRef pThis, IntPtr c);

		/// <summary>
		/// Set color to the edge
		/// </summary>
		// Token: 0x06009378 RID: 37752 RVA: 0x000D1271 File Offset: 0x000CF471
		public void SetEdgeColor(IntPtr c)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SetEdgeColor_92(base.GetCppThis(), c);
		}

		// Token: 0x06009379 RID: 37753
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_SetForegroundColor_93(HandleRef pThis, double arg0, double arg1, double arg2);

		/// <summary>
		/// Set the color of all the widget's handles (edges, cone1, cone2, line, sphere, selected plane)
		/// and their color during interaction. Foreground color applies to the outlines and unselected
		/// plane.
		/// </summary>
		// Token: 0x0600937A RID: 37754 RVA: 0x000D1281 File Offset: 0x000CF481
		public void SetForegroundColor(double arg0, double arg1, double arg2)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SetForegroundColor_93(base.GetCppThis(), arg0, arg1, arg2);
		}

		// Token: 0x0600937B RID: 37755
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_SetForegroundColor_94(HandleRef pThis, IntPtr c);

		/// <summary>
		/// Set the color of all the widget's handles (edges, cone1, cone2, line, sphere, selected plane)
		/// and their color during interaction. Foreground color applies to the outlines and unselected
		/// plane.
		/// </summary>
		// Token: 0x0600937C RID: 37756 RVA: 0x000D1293 File Offset: 0x000CF493
		public void SetForegroundColor(IntPtr c)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SetForegroundColor_94(base.GetCppThis(), c);
		}

		// Token: 0x0600937D RID: 37757
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_SetHandleColor_95(HandleRef pThis, IntPtr c);

		/// <summary>
		/// Set the color of all the widget's handles (edges, cone1, cone2, line, sphere, selected plane)
		/// and their color during interaction. Foreground color applies to the outlines and unselected
		/// plane.
		/// </summary>
		// Token: 0x0600937E RID: 37758 RVA: 0x000D12A3 File Offset: 0x000CF4A3
		public void SetHandleColor(IntPtr c)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SetHandleColor_95(base.GetCppThis(), c);
		}

		// Token: 0x0600937F RID: 37759
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_SetHandleColor_96(HandleRef pThis, double arg0, double arg1, double arg2);

		/// <summary>
		/// Set the color of all the widget's handles (edges, cone1, cone2, line, sphere, selected plane)
		/// and their color during interaction. Foreground color applies to the outlines and unselected
		/// plane.
		/// </summary>
		// Token: 0x06009380 RID: 37760 RVA: 0x000D12B3 File Offset: 0x000CF4B3
		public void SetHandleColor(double arg0, double arg1, double arg2)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SetHandleColor_96(base.GetCppThis(), arg0, arg1, arg2);
		}

		// Token: 0x06009381 RID: 37761
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_SetInteractionColor_97(HandleRef pThis, double arg0, double arg1, double arg2);

		/// <summary>
		/// Set the color of all the widget's handles (edges, cone1, cone2, line, sphere, selected plane)
		/// and their color during interaction. Foreground color applies to the outlines and unselected
		/// plane.
		/// </summary>
		// Token: 0x06009382 RID: 37762 RVA: 0x000D12C5 File Offset: 0x000CF4C5
		public void SetInteractionColor(double arg0, double arg1, double arg2)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SetInteractionColor_97(base.GetCppThis(), arg0, arg1, arg2);
		}

		// Token: 0x06009383 RID: 37763
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_SetInteractionColor_98(HandleRef pThis, IntPtr c);

		/// <summary>
		/// Set the color of all the widget's handles (edges, cone1, cone2, line, sphere, selected plane)
		/// and their color during interaction. Foreground color applies to the outlines and unselected
		/// plane.
		/// </summary>
		// Token: 0x06009384 RID: 37764 RVA: 0x000D12D7 File Offset: 0x000CF4D7
		public void SetInteractionColor(IntPtr c)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SetInteractionColor_98(base.GetCppThis(), c);
		}

		// Token: 0x06009385 RID: 37765
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_SetInteractionState_99(HandleRef pThis, int _arg);

		/// <summary>
		/// The interaction state may be set from a widget (e.g.,
		/// vtkImplicitPlaneWidget2) or other object. This controls how the
		/// interaction with the widget proceeds. Normally this method is used as
		/// part of a handshaking process with the widget: First
		/// ComputeInteractionState() is invoked that returns a state based on
		/// geometric considerations (i.e., cursor near a widget feature), then
		/// based on events, the widget may modify this further.
		/// </summary>
		// Token: 0x06009386 RID: 37766 RVA: 0x000D12E7 File Offset: 0x000CF4E7
		public virtual void SetInteractionState(int _arg)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SetInteractionState_99(base.GetCppThis(), _arg);
		}

		// Token: 0x06009387 RID: 37767
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_SetLockNormalToCamera_100(HandleRef pThis, int arg0);

		/// <summary>
		/// If enabled, and a vtkCamera is available through the renderer, then
		/// LockNormalToCamera will cause the normal to follow the camera's
		/// normal.
		/// </summary>
		// Token: 0x06009388 RID: 37768 RVA: 0x000D12F7 File Offset: 0x000CF4F7
		public virtual void SetLockNormalToCamera(int arg0)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SetLockNormalToCamera_100(base.GetCppThis(), arg0);
		}

		// Token: 0x06009389 RID: 37769
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_SetNormal_101(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Get the normal to the plane.
		/// </summary>
		// Token: 0x0600938A RID: 37770 RVA: 0x000D1307 File Offset: 0x000CF507
		public void SetNormal(double x, double y, double z)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SetNormal_101(base.GetCppThis(), x, y, z);
		}

		// Token: 0x0600938B RID: 37771
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_SetNormal_102(HandleRef pThis, IntPtr n);

		/// <summary>
		/// Get the normal to the plane.
		/// </summary>
		// Token: 0x0600938C RID: 37772 RVA: 0x000D1319 File Offset: 0x000CF519
		public void SetNormal(IntPtr n)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SetNormal_102(base.GetCppThis(), n);
		}

		// Token: 0x0600938D RID: 37773
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_SetNormalToCamera_103(HandleRef pThis);

		/// <summary>
		/// Get the normal to the plane.
		/// </summary>
		// Token: 0x0600938E RID: 37774 RVA: 0x000D1329 File Offset: 0x000CF529
		public void SetNormalToCamera()
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SetNormalToCamera_103(base.GetCppThis());
		}

		// Token: 0x0600938F RID: 37775
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_SetNormalToXAxis_104(HandleRef pThis, int arg0);

		/// <summary>
		/// Force the plane widget to be aligned with one of the x-y-z axes.
		/// If one axis is set on, the other two will be set off.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the plane to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x06009390 RID: 37776 RVA: 0x000D1338 File Offset: 0x000CF538
		public void SetNormalToXAxis(int arg0)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SetNormalToXAxis_104(base.GetCppThis(), arg0);
		}

		// Token: 0x06009391 RID: 37777
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_SetNormalToYAxis_105(HandleRef pThis, int arg0);

		/// <summary>
		/// Force the plane widget to be aligned with one of the x-y-z axes.
		/// If one axis is set on, the other two will be set off.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the plane to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x06009392 RID: 37778 RVA: 0x000D1348 File Offset: 0x000CF548
		public void SetNormalToYAxis(int arg0)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SetNormalToYAxis_105(base.GetCppThis(), arg0);
		}

		// Token: 0x06009393 RID: 37779
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_SetNormalToZAxis_106(HandleRef pThis, int arg0);

		/// <summary>
		/// Force the plane widget to be aligned with one of the x-y-z axes.
		/// If one axis is set on, the other two will be set off.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the plane to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x06009394 RID: 37780 RVA: 0x000D1358 File Offset: 0x000CF558
		public void SetNormalToZAxis(int arg0)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SetNormalToZAxis_106(base.GetCppThis(), arg0);
		}

		// Token: 0x06009395 RID: 37781
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_SetOrigin_107(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Get the origin of the plane.
		/// </summary>
		// Token: 0x06009396 RID: 37782 RVA: 0x000D1368 File Offset: 0x000CF568
		public void SetOrigin(double x, double y, double z)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SetOrigin_107(base.GetCppThis(), x, y, z);
		}

		// Token: 0x06009397 RID: 37783
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_SetOrigin_108(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Get the origin of the plane.
		/// </summary>
		// Token: 0x06009398 RID: 37784 RVA: 0x000D137A File Offset: 0x000CF57A
		public void SetOrigin(IntPtr x)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SetOrigin_108(base.GetCppThis(), x);
		}

		// Token: 0x06009399 RID: 37785
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_SetOutlineTranslation_109(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the ability to translate the bounding box by grabbing it
		/// with the left mouse button.
		/// </summary>
		// Token: 0x0600939A RID: 37786 RVA: 0x000D138A File Offset: 0x000CF58A
		public virtual void SetOutlineTranslation(int _arg)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SetOutlineTranslation_109(base.GetCppThis(), _arg);
		}

		// Token: 0x0600939B RID: 37787
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_SetOutsideBounds_110(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the ability to move the widget outside of the bounds
		/// specified in the initial PlaceWidget() invocation.
		/// </summary>
		// Token: 0x0600939C RID: 37788 RVA: 0x000D139A File Offset: 0x000CF59A
		public virtual void SetOutsideBounds(int _arg)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SetOutsideBounds_110(base.GetCppThis(), _arg);
		}

		// Token: 0x0600939D RID: 37789
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_SetPlane_111(HandleRef pThis, HandleRef plane);

		/// <summary>
		/// Alternative way to define the cutting plane. The normal and origin of
		/// the plane provided is copied into the internal instance of the class
		/// cutting vtkPlane.
		/// </summary>
		// Token: 0x0600939E RID: 37790 RVA: 0x000D13AC File Offset: 0x000CF5AC
		public void SetPlane(vtkPlane plane)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SetPlane_111(base.GetCppThis(), (plane == null) ? default(HandleRef) : plane.GetCppThis());
		}

		// Token: 0x0600939F RID: 37791
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_SetRepresentationState_112(HandleRef pThis, int arg0);

		/// <summary>
		/// Sets the visual appearance of the representation based on the
		/// state it is in. This state is usually the same as InteractionState.
		/// </summary>
		// Token: 0x060093A0 RID: 37792 RVA: 0x000D13DB File Offset: 0x000CF5DB
		public virtual void SetRepresentationState(int arg0)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SetRepresentationState_112(base.GetCppThis(), arg0);
		}

		// Token: 0x060093A1 RID: 37793
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_SetScaleEnabled_113(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the ability to scale the widget with the mouse.
		/// </summary>
		// Token: 0x060093A2 RID: 37794 RVA: 0x000D13EB File Offset: 0x000CF5EB
		public virtual void SetScaleEnabled(int _arg)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SetScaleEnabled_113(base.GetCppThis(), _arg);
		}

		// Token: 0x060093A3 RID: 37795
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_SetSnapToAxes_114(HandleRef pThis, byte _arg);

		/// <summary>
		/// For complex events should we snap orientations to
		/// be aligned with the x y z axes
		/// </summary>
		// Token: 0x060093A4 RID: 37796 RVA: 0x000D13FB File Offset: 0x000CF5FB
		public virtual void SetSnapToAxes(bool _arg)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SetSnapToAxes_114(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060093A5 RID: 37797
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_SetTranslationAxisOff_115(HandleRef pThis);

		/// <summary>
		/// Toggles constraint translation axis on/off.
		/// </summary>
		// Token: 0x060093A6 RID: 37798 RVA: 0x000D1413 File Offset: 0x000CF613
		public void SetTranslationAxisOff()
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SetTranslationAxisOff_115(base.GetCppThis());
		}

		// Token: 0x060093A7 RID: 37799
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_SetTubing_116(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off tubing of the wire outline of the plane. The tube thickens
		/// the line by wrapping with a vtkTubeFilter.
		/// </summary>
		// Token: 0x060093A8 RID: 37800 RVA: 0x000D1422 File Offset: 0x000CF622
		public virtual void SetTubing(int _arg)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SetTubing_116(base.GetCppThis(), _arg);
		}

		// Token: 0x060093A9 RID: 37801
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_SetWidgetBounds_117(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		/// <summary>
		/// Set/Get the bounds of the widget representation. PlaceWidget can also be
		/// used to set the bounds of the widget but it may also have other effects
		/// on the internal state of the representation. Use this function when only
		/// the widget bounds are needs to be modified.
		/// </summary>
		// Token: 0x060093AA RID: 37802 RVA: 0x000D1432 File Offset: 0x000CF632
		public virtual void SetWidgetBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SetWidgetBounds_117(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x060093AB RID: 37803
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_SetWidgetBounds_118(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the bounds of the widget representation. PlaceWidget can also be
		/// used to set the bounds of the widget but it may also have other effects
		/// on the internal state of the representation. Use this function when only
		/// the widget bounds are needs to be modified.
		/// </summary>
		// Token: 0x060093AC RID: 37804 RVA: 0x000D144A File Offset: 0x000CF64A
		public virtual void SetWidgetBounds(IntPtr _arg)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SetWidgetBounds_118(base.GetCppThis(), _arg);
		}

		// Token: 0x060093AD RID: 37805
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_SetXTranslationAxisOn_119(HandleRef pThis);

		/// <summary>
		/// Toggles constraint translation axis on/off.
		/// </summary>
		// Token: 0x060093AE RID: 37806 RVA: 0x000D145A File Offset: 0x000CF65A
		public void SetXTranslationAxisOn()
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SetXTranslationAxisOn_119(base.GetCppThis());
		}

		// Token: 0x060093AF RID: 37807
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_SetYTranslationAxisOn_120(HandleRef pThis);

		/// <summary>
		/// Toggles constraint translation axis on/off.
		/// </summary>
		// Token: 0x060093B0 RID: 37808 RVA: 0x000D1469 File Offset: 0x000CF669
		public void SetYTranslationAxisOn()
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SetYTranslationAxisOn_120(base.GetCppThis());
		}

		// Token: 0x060093B1 RID: 37809
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_SetZTranslationAxisOn_121(HandleRef pThis);

		/// <summary>
		/// Toggles constraint translation axis on/off.
		/// </summary>
		// Token: 0x060093B2 RID: 37810 RVA: 0x000D1478 File Offset: 0x000CF678
		public void SetZTranslationAxisOn()
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SetZTranslationAxisOn_121(base.GetCppThis());
		}

		// Token: 0x060093B3 RID: 37811
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_StartComplexInteraction_122(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata);

		/// <summary>
		/// Methods to interface with the vtkImplicitPlaneWidget2.
		/// </summary>
		// Token: 0x060093B4 RID: 37812 RVA: 0x000D1488 File Offset: 0x000CF688
		public override void StartComplexInteraction(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_StartComplexInteraction_122(base.GetCppThis(), (iren == null) ? default(HandleRef) : iren.GetCppThis(), (widget == null) ? default(HandleRef) : widget.GetCppThis(), arg2, calldata);
		}

		// Token: 0x060093B5 RID: 37813
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_StartWidgetInteraction_123(HandleRef pThis, IntPtr eventPos);

		/// <summary>
		/// Methods to interface with the vtkImplicitPlaneWidget2.
		/// </summary>
		// Token: 0x060093B6 RID: 37814 RVA: 0x000D14CF File Offset: 0x000CF6CF
		public override void StartWidgetInteraction(IntPtr eventPos)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_StartWidgetInteraction_123(base.GetCppThis(), eventPos);
		}

		// Token: 0x060093B7 RID: 37815
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_TubingOff_124(HandleRef pThis);

		/// <summary>
		/// Turn on/off tubing of the wire outline of the plane. The tube thickens
		/// the line by wrapping with a vtkTubeFilter.
		/// </summary>
		// Token: 0x060093B8 RID: 37816 RVA: 0x000D14DF File Offset: 0x000CF6DF
		public virtual void TubingOff()
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_TubingOff_124(base.GetCppThis());
		}

		// Token: 0x060093B9 RID: 37817
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_TubingOn_125(HandleRef pThis);

		/// <summary>
		/// Turn on/off tubing of the wire outline of the plane. The tube thickens
		/// the line by wrapping with a vtkTubeFilter.
		/// </summary>
		// Token: 0x060093BA RID: 37818 RVA: 0x000D14EE File Offset: 0x000CF6EE
		public virtual void TubingOn()
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_TubingOn_125(base.GetCppThis());
		}

		// Token: 0x060093BB RID: 37819
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_UpdatePlacement_126(HandleRef pThis);

		/// <summary>
		/// Satisfies the superclass API.  This will change the state of the widget
		/// to match changes that have been made to the underlying PolyDataSource
		/// </summary>
		// Token: 0x060093BC RID: 37820 RVA: 0x000D14FD File Offset: 0x000CF6FD
		public void UpdatePlacement()
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_UpdatePlacement_126(base.GetCppThis());
		}

		// Token: 0x060093BD RID: 37821
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPlaneRepresentation_WidgetInteraction_127(HandleRef pThis, IntPtr newEventPos);

		/// <summary>
		/// Methods to interface with the vtkImplicitPlaneWidget2.
		/// </summary>
		// Token: 0x060093BE RID: 37822 RVA: 0x000D150C File Offset: 0x000CF70C
		public override void WidgetInteraction(IntPtr newEventPos)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_WidgetInteraction_127(base.GetCppThis(), newEventPos);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C23 RID: 3107
		public new const string MRFullTypeName = "Kitware.VTK.vtkImplicitPlaneRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C24 RID: 3108
		public new static readonly string MRClassNameKey = "class vtkImplicitPlaneRepresentation";

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x0200032E RID: 814
		public enum InteractionStateType
		{
			/// <summary>enum member</summary>
			// Token: 0x04000C26 RID: 3110
			Moving = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000C27 RID: 3111
			MovingOrigin = 3,
			/// <summary>enum member</summary>
			// Token: 0x04000C28 RID: 3112
			MovingOutline = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000C29 RID: 3113
			Outside = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000C2A RID: 3114
			Pushing = 5,
			/// <summary>enum member</summary>
			// Token: 0x04000C2B RID: 3115
			Rotating = 4,
			/// <summary>enum member</summary>
			// Token: 0x04000C2C RID: 3116
			Scaling = 6
		}
	}
}
