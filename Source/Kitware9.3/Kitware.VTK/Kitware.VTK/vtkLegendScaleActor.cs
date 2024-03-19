using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLegendScaleActor
	/// </summary>
	/// <remarks>
	///    annotate the render window with scale and distance information
	///
	/// This class is used to annotate the render window. Its basic goal is to
	/// provide an indication of the scale of the scene. Four axes surrounding the
	/// render window indicate (in a variety of ways) the scale of what the camera
	/// is viewing. An option also exists for displaying a scale legend.
	///
	/// The axes can be programmed either to display distance scales or x-y
	/// coordinate values. By default, the scales display a distance. However,
	/// if you know that the view is down the z-axis, the scales can be programmed
	/// to display x-y coordinate values.
	///
	/// @warning
	/// Please be aware that the axes and scale values are subject to perspective
	/// effects. The distances are computed in the focal plane of the camera.
	/// When there are large view angles (i.e., perspective projection), the
	/// computed distances may provide users the wrong sense of scale. These
	/// effects are not present when parallel projection is enabled.
	/// </remarks>
	// Token: 0x020003CF RID: 975
	public class vtkLegendScaleActor : vtkProp
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600B5F8 RID: 46584 RVA: 0x00100281 File Offset: 0x000FE481
		static vtkLegendScaleActor()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLegendScaleActor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLegendScaleActor"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600B5F9 RID: 46585 RVA: 0x001002A9 File Offset: 0x000FE4A9
		public vtkLegendScaleActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600B5FA RID: 46586
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLegendScaleActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x0600B5FB RID: 46587 RVA: 0x001002B8 File Offset: 0x000FE4B8
		public new static vtkLegendScaleActor New()
		{
			vtkLegendScaleActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLegendScaleActor.vtkLegendScaleActor_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLegendScaleActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x0600B5FC RID: 46588 RVA: 0x0010030C File Offset: 0x000FE50C
		public vtkLegendScaleActor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLegendScaleActor.vtkLegendScaleActor_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600B5FD RID: 46589 RVA: 0x00100350 File Offset: 0x000FE550
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600B5FE RID: 46590
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendScaleActor_AllAnnotationsOff_01(HandleRef pThis);

		/// <summary>
		/// Convenience method that turns all the axes and the legend scale.
		/// </summary>
		// Token: 0x0600B5FF RID: 46591 RVA: 0x0010035B File Offset: 0x000FE55B
		public void AllAnnotationsOff()
		{
			vtkLegendScaleActor.vtkLegendScaleActor_AllAnnotationsOff_01(base.GetCppThis());
		}

		// Token: 0x0600B600 RID: 46592
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendScaleActor_AllAnnotationsOn_02(HandleRef pThis);

		/// <summary>
		/// Convenience method that turns all the axes and the legend scale.
		/// </summary>
		// Token: 0x0600B601 RID: 46593 RVA: 0x0010036A File Offset: 0x000FE56A
		public void AllAnnotationsOn()
		{
			vtkLegendScaleActor.vtkLegendScaleActor_AllAnnotationsOn_02(base.GetCppThis());
		}

		// Token: 0x0600B602 RID: 46594
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendScaleActor_AllAxesOff_03(HandleRef pThis);

		/// <summary>
		/// Convenience method that turns all the axes either on or off.
		/// </summary>
		// Token: 0x0600B603 RID: 46595 RVA: 0x00100379 File Offset: 0x000FE579
		public void AllAxesOff()
		{
			vtkLegendScaleActor.vtkLegendScaleActor_AllAxesOff_03(base.GetCppThis());
		}

		// Token: 0x0600B604 RID: 46596
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendScaleActor_AllAxesOn_04(HandleRef pThis);

		/// <summary>
		/// Convenience method that turns all the axes either on or off.
		/// </summary>
		// Token: 0x0600B605 RID: 46597 RVA: 0x00100388 File Offset: 0x000FE588
		public void AllAxesOn()
		{
			vtkLegendScaleActor.vtkLegendScaleActor_AllAxesOn_04(base.GetCppThis());
		}

		// Token: 0x0600B606 RID: 46598
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendScaleActor_BottomAxisVisibilityOff_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the flags that control which of the four axes to display (top,
		/// bottom, left and right). By default, all the axes are displayed.
		/// </summary>
		// Token: 0x0600B607 RID: 46599 RVA: 0x00100397 File Offset: 0x000FE597
		public virtual void BottomAxisVisibilityOff()
		{
			vtkLegendScaleActor.vtkLegendScaleActor_BottomAxisVisibilityOff_05(base.GetCppThis());
		}

		// Token: 0x0600B608 RID: 46600
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendScaleActor_BottomAxisVisibilityOn_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the flags that control which of the four axes to display (top,
		/// bottom, left and right). By default, all the axes are displayed.
		/// </summary>
		// Token: 0x0600B609 RID: 46601 RVA: 0x001003A6 File Offset: 0x000FE5A6
		public virtual void BottomAxisVisibilityOn()
		{
			vtkLegendScaleActor.vtkLegendScaleActor_BottomAxisVisibilityOn_06(base.GetCppThis());
		}

		// Token: 0x0600B60A RID: 46602
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendScaleActor_BuildRepresentation_07(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Standard methods supporting the rendering process.
		/// </summary>
		// Token: 0x0600B60B RID: 46603 RVA: 0x001003B8 File Offset: 0x000FE5B8
		public virtual void BuildRepresentation(vtkViewport viewport)
		{
			vtkLegendScaleActor.vtkLegendScaleActor_BuildRepresentation_07(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x0600B60C RID: 46604
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendScaleActor_GetActors2D_08(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Standard methods supporting the rendering process.
		/// </summary>
		// Token: 0x0600B60D RID: 46605 RVA: 0x001003E8 File Offset: 0x000FE5E8
		public override void GetActors2D(vtkPropCollection arg0)
		{
			vtkLegendScaleActor.vtkLegendScaleActor_GetActors2D_08(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B60E RID: 46606
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLegendScaleActor_GetBottomAxis_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// These are methods to retrieve the vtkAxisActors used to represent
		/// the four axes that form this representation. Users may retrieve and
		/// then modify these axes to control their appearance.
		/// </summary>
		// Token: 0x0600B60F RID: 46607 RVA: 0x00100418 File Offset: 0x000FE618
		public virtual vtkAxisActor2D GetBottomAxis()
		{
			vtkAxisActor2D vtkAxisActor2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLegendScaleActor.vtkLegendScaleActor_GetBottomAxis_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAxisActor2D = (vtkAxisActor2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAxisActor2D.Register(null);
				}
			}
			return vtkAxisActor2D;
		}

		// Token: 0x0600B610 RID: 46608
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLegendScaleActor_GetBottomAxisVisibility_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the flags that control which of the four axes to display (top,
		/// bottom, left and right). By default, all the axes are displayed.
		/// </summary>
		// Token: 0x0600B611 RID: 46609 RVA: 0x00100488 File Offset: 0x000FE688
		public virtual int GetBottomAxisVisibility()
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_GetBottomAxisVisibility_10(base.GetCppThis());
		}

		// Token: 0x0600B612 RID: 46610
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLegendScaleActor_GetBottomBorderOffset_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the offset of the bottom axis from the border. This number is expressed in
		/// pixels, and represents the approximate distance of the axes from the sides
		/// of the renderer. The default is 30.
		/// </summary>
		// Token: 0x0600B613 RID: 46611 RVA: 0x001004A8 File Offset: 0x000FE6A8
		public virtual int GetBottomBorderOffset()
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_GetBottomBorderOffset_11(base.GetCppThis());
		}

		// Token: 0x0600B614 RID: 46612
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLegendScaleActor_GetBottomBorderOffsetMaxValue_12(HandleRef pThis);

		/// <summary>
		/// Set/Get the offset of the bottom axis from the border. This number is expressed in
		/// pixels, and represents the approximate distance of the axes from the sides
		/// of the renderer. The default is 30.
		/// </summary>
		// Token: 0x0600B615 RID: 46613 RVA: 0x001004C8 File Offset: 0x000FE6C8
		public virtual int GetBottomBorderOffsetMaxValue()
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_GetBottomBorderOffsetMaxValue_12(base.GetCppThis());
		}

		// Token: 0x0600B616 RID: 46614
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLegendScaleActor_GetBottomBorderOffsetMinValue_13(HandleRef pThis);

		/// <summary>
		/// Set/Get the offset of the bottom axis from the border. This number is expressed in
		/// pixels, and represents the approximate distance of the axes from the sides
		/// of the renderer. The default is 30.
		/// </summary>
		// Token: 0x0600B617 RID: 46615 RVA: 0x001004E8 File Offset: 0x000FE6E8
		public virtual int GetBottomBorderOffsetMinValue()
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_GetBottomBorderOffsetMinValue_13(base.GetCppThis());
		}

		// Token: 0x0600B618 RID: 46616
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLegendScaleActor_GetCornerOffsetFactor_14(HandleRef pThis);

		/// <summary>
		/// Get/Set the corner offset. This is the offset factor used to offset the
		/// axes at the corners. Default value is 2.0.
		/// </summary>
		// Token: 0x0600B619 RID: 46617 RVA: 0x00100508 File Offset: 0x000FE708
		public virtual double GetCornerOffsetFactor()
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_GetCornerOffsetFactor_14(base.GetCppThis());
		}

		// Token: 0x0600B61A RID: 46618
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLegendScaleActor_GetCornerOffsetFactorMaxValue_15(HandleRef pThis);

		/// <summary>
		/// Get/Set the corner offset. This is the offset factor used to offset the
		/// axes at the corners. Default value is 2.0.
		/// </summary>
		// Token: 0x0600B61B RID: 46619 RVA: 0x00100528 File Offset: 0x000FE728
		public virtual double GetCornerOffsetFactorMaxValue()
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_GetCornerOffsetFactorMaxValue_15(base.GetCppThis());
		}

		// Token: 0x0600B61C RID: 46620
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLegendScaleActor_GetCornerOffsetFactorMinValue_16(HandleRef pThis);

		/// <summary>
		/// Get/Set the corner offset. This is the offset factor used to offset the
		/// axes at the corners. Default value is 2.0.
		/// </summary>
		// Token: 0x0600B61D RID: 46621 RVA: 0x00100548 File Offset: 0x000FE748
		public virtual double GetCornerOffsetFactorMinValue()
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_GetCornerOffsetFactorMinValue_16(base.GetCppThis());
		}

		// Token: 0x0600B61E RID: 46622
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLegendScaleActor_GetLabelMode_17(HandleRef pThis);

		/// <summary>
		/// Specify the mode for labeling the scale axes. By default, the axes are
		/// labeled with the distance between points (centered at a distance of
		/// 0.0). Alternatively if you know that the view is down the z-axis; the
		/// axes can be labeled with x-y coordinate values.
		/// </summary>
		// Token: 0x0600B61F RID: 46623 RVA: 0x00100568 File Offset: 0x000FE768
		public virtual int GetLabelMode()
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_GetLabelMode_17(base.GetCppThis());
		}

		// Token: 0x0600B620 RID: 46624
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLegendScaleActor_GetLabelModeMaxValue_18(HandleRef pThis);

		/// <summary>
		/// Specify the mode for labeling the scale axes. By default, the axes are
		/// labeled with the distance between points (centered at a distance of
		/// 0.0). Alternatively if you know that the view is down the z-axis; the
		/// axes can be labeled with x-y coordinate values.
		/// </summary>
		// Token: 0x0600B621 RID: 46625 RVA: 0x00100588 File Offset: 0x000FE788
		public virtual int GetLabelModeMaxValue()
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_GetLabelModeMaxValue_18(base.GetCppThis());
		}

		// Token: 0x0600B622 RID: 46626
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLegendScaleActor_GetLabelModeMinValue_19(HandleRef pThis);

		/// <summary>
		/// Specify the mode for labeling the scale axes. By default, the axes are
		/// labeled with the distance between points (centered at a distance of
		/// 0.0). Alternatively if you know that the view is down the z-axis; the
		/// axes can be labeled with x-y coordinate values.
		/// </summary>
		// Token: 0x0600B623 RID: 46627 RVA: 0x001005A8 File Offset: 0x000FE7A8
		public virtual int GetLabelModeMinValue()
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_GetLabelModeMinValue_19(base.GetCppThis());
		}

		// Token: 0x0600B624 RID: 46628
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLegendScaleActor_GetLeftAxis_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// These are methods to retrieve the vtkAxisActors used to represent
		/// the four axes that form this representation. Users may retrieve and
		/// then modify these axes to control their appearance.
		/// </summary>
		// Token: 0x0600B625 RID: 46629 RVA: 0x001005C8 File Offset: 0x000FE7C8
		public virtual vtkAxisActor2D GetLeftAxis()
		{
			vtkAxisActor2D vtkAxisActor2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLegendScaleActor.vtkLegendScaleActor_GetLeftAxis_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAxisActor2D = (vtkAxisActor2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAxisActor2D.Register(null);
				}
			}
			return vtkAxisActor2D;
		}

		// Token: 0x0600B626 RID: 46630
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLegendScaleActor_GetLeftAxisVisibility_21(HandleRef pThis);

		/// <summary>
		/// Set/Get the flags that control which of the four axes to display (top,
		/// bottom, left and right). By default, all the axes are displayed.
		/// </summary>
		// Token: 0x0600B627 RID: 46631 RVA: 0x00100638 File Offset: 0x000FE838
		public virtual int GetLeftAxisVisibility()
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_GetLeftAxisVisibility_21(base.GetCppThis());
		}

		// Token: 0x0600B628 RID: 46632
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLegendScaleActor_GetLeftBorderOffset_22(HandleRef pThis);

		/// <summary>
		/// Set/Get the offset of the left axis from the border. This number is expressed in
		/// pixels, and represents the approximate distance of the axes from the sides
		/// of the renderer. The default is 50.
		/// </summary>
		// Token: 0x0600B629 RID: 46633 RVA: 0x00100658 File Offset: 0x000FE858
		public virtual int GetLeftBorderOffset()
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_GetLeftBorderOffset_22(base.GetCppThis());
		}

		// Token: 0x0600B62A RID: 46634
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLegendScaleActor_GetLeftBorderOffsetMaxValue_23(HandleRef pThis);

		/// <summary>
		/// Set/Get the offset of the left axis from the border. This number is expressed in
		/// pixels, and represents the approximate distance of the axes from the sides
		/// of the renderer. The default is 50.
		/// </summary>
		// Token: 0x0600B62B RID: 46635 RVA: 0x00100678 File Offset: 0x000FE878
		public virtual int GetLeftBorderOffsetMaxValue()
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_GetLeftBorderOffsetMaxValue_23(base.GetCppThis());
		}

		// Token: 0x0600B62C RID: 46636
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLegendScaleActor_GetLeftBorderOffsetMinValue_24(HandleRef pThis);

		/// <summary>
		/// Set/Get the offset of the left axis from the border. This number is expressed in
		/// pixels, and represents the approximate distance of the axes from the sides
		/// of the renderer. The default is 50.
		/// </summary>
		// Token: 0x0600B62D RID: 46637 RVA: 0x00100698 File Offset: 0x000FE898
		public virtual int GetLeftBorderOffsetMinValue()
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_GetLeftBorderOffsetMinValue_24(base.GetCppThis());
		}

		// Token: 0x0600B62E RID: 46638
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLegendScaleActor_GetLegendLabelProperty_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the labels text properties for the legend title and labels.
		/// </summary>
		// Token: 0x0600B62F RID: 46639 RVA: 0x001006B8 File Offset: 0x000FE8B8
		public virtual vtkTextProperty GetLegendLabelProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLegendScaleActor.vtkLegendScaleActor_GetLegendLabelProperty_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		// Token: 0x0600B630 RID: 46640
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLegendScaleActor_GetLegendTitleProperty_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the labels text properties for the legend title and labels.
		/// </summary>
		// Token: 0x0600B631 RID: 46641 RVA: 0x00100728 File Offset: 0x000FE928
		public virtual vtkTextProperty GetLegendTitleProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLegendScaleActor.vtkLegendScaleActor_GetLegendTitleProperty_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		// Token: 0x0600B632 RID: 46642
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLegendScaleActor_GetLegendVisibility_27(HandleRef pThis);

		/// <summary>
		/// Indicate whether the legend scale should be displayed or not.
		/// The default is On.
		/// </summary>
		// Token: 0x0600B633 RID: 46643 RVA: 0x00100798 File Offset: 0x000FE998
		public virtual int GetLegendVisibility()
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_GetLegendVisibility_27(base.GetCppThis());
		}

		// Token: 0x0600B634 RID: 46644
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLegendScaleActor_GetNumberOfGenerationsFromBase_28(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x0600B635 RID: 46645 RVA: 0x001007B8 File Offset: 0x000FE9B8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_GetNumberOfGenerationsFromBase_28(base.GetCppThis(), type);
		}

		// Token: 0x0600B636 RID: 46646
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLegendScaleActor_GetNumberOfGenerationsFromBaseType_29([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x0600B637 RID: 46647 RVA: 0x001007D8 File Offset: 0x000FE9D8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_GetNumberOfGenerationsFromBaseType_29(type);
		}

		// Token: 0x0600B638 RID: 46648
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLegendScaleActor_GetRightAxis_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// These are methods to retrieve the vtkAxisActors used to represent
		/// the four axes that form this representation. Users may retrieve and
		/// then modify these axes to control their appearance.
		/// </summary>
		// Token: 0x0600B639 RID: 46649 RVA: 0x001007F4 File Offset: 0x000FE9F4
		public virtual vtkAxisActor2D GetRightAxis()
		{
			vtkAxisActor2D vtkAxisActor2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLegendScaleActor.vtkLegendScaleActor_GetRightAxis_30(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAxisActor2D = (vtkAxisActor2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAxisActor2D.Register(null);
				}
			}
			return vtkAxisActor2D;
		}

		// Token: 0x0600B63A RID: 46650
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLegendScaleActor_GetRightAxisVisibility_31(HandleRef pThis);

		/// <summary>
		/// Set/Get the flags that control which of the four axes to display (top,
		/// bottom, left and right). By default, all the axes are displayed.
		/// </summary>
		// Token: 0x0600B63B RID: 46651 RVA: 0x00100864 File Offset: 0x000FEA64
		public virtual int GetRightAxisVisibility()
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_GetRightAxisVisibility_31(base.GetCppThis());
		}

		// Token: 0x0600B63C RID: 46652
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLegendScaleActor_GetRightBorderOffset_32(HandleRef pThis);

		/// <summary>
		/// Set/Get the offset of the right axis from the border. This number is expressed in
		/// pixels, and represents the approximate distance of the axes from the sides
		/// of the renderer. The default is 50.
		/// </summary>
		// Token: 0x0600B63D RID: 46653 RVA: 0x00100884 File Offset: 0x000FEA84
		public virtual int GetRightBorderOffset()
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_GetRightBorderOffset_32(base.GetCppThis());
		}

		// Token: 0x0600B63E RID: 46654
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLegendScaleActor_GetRightBorderOffsetMaxValue_33(HandleRef pThis);

		/// <summary>
		/// Set/Get the offset of the right axis from the border. This number is expressed in
		/// pixels, and represents the approximate distance of the axes from the sides
		/// of the renderer. The default is 50.
		/// </summary>
		// Token: 0x0600B63F RID: 46655 RVA: 0x001008A4 File Offset: 0x000FEAA4
		public virtual int GetRightBorderOffsetMaxValue()
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_GetRightBorderOffsetMaxValue_33(base.GetCppThis());
		}

		// Token: 0x0600B640 RID: 46656
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLegendScaleActor_GetRightBorderOffsetMinValue_34(HandleRef pThis);

		/// <summary>
		/// Set/Get the offset of the right axis from the border. This number is expressed in
		/// pixels, and represents the approximate distance of the axes from the sides
		/// of the renderer. The default is 50.
		/// </summary>
		// Token: 0x0600B641 RID: 46657 RVA: 0x001008C4 File Offset: 0x000FEAC4
		public virtual int GetRightBorderOffsetMinValue()
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_GetRightBorderOffsetMinValue_34(base.GetCppThis());
		}

		// Token: 0x0600B642 RID: 46658
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLegendScaleActor_GetTopAxis_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// These are methods to retrieve the vtkAxisActors used to represent
		/// the four axes that form this representation. Users may retrieve and
		/// then modify these axes to control their appearance.
		/// </summary>
		// Token: 0x0600B643 RID: 46659 RVA: 0x001008E4 File Offset: 0x000FEAE4
		public virtual vtkAxisActor2D GetTopAxis()
		{
			vtkAxisActor2D vtkAxisActor2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLegendScaleActor.vtkLegendScaleActor_GetTopAxis_35(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAxisActor2D = (vtkAxisActor2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAxisActor2D.Register(null);
				}
			}
			return vtkAxisActor2D;
		}

		// Token: 0x0600B644 RID: 46660
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLegendScaleActor_GetTopAxisVisibility_36(HandleRef pThis);

		/// <summary>
		/// Set/Get the flags that control which of the four axes to display (top,
		/// bottom, left and right). By default, all the axes are displayed.
		/// </summary>
		// Token: 0x0600B645 RID: 46661 RVA: 0x00100954 File Offset: 0x000FEB54
		public virtual int GetTopAxisVisibility()
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_GetTopAxisVisibility_36(base.GetCppThis());
		}

		// Token: 0x0600B646 RID: 46662
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLegendScaleActor_GetTopBorderOffset_37(HandleRef pThis);

		/// <summary>
		/// Set/Get the offset of the top axis from the border. This number is expressed in
		/// pixels, and represents the approximate distance of the axes from the sides
		/// of the renderer. The default is 30.
		/// </summary>
		// Token: 0x0600B647 RID: 46663 RVA: 0x00100974 File Offset: 0x000FEB74
		public virtual int GetTopBorderOffset()
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_GetTopBorderOffset_37(base.GetCppThis());
		}

		// Token: 0x0600B648 RID: 46664
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLegendScaleActor_GetTopBorderOffsetMaxValue_38(HandleRef pThis);

		/// <summary>
		/// Set/Get the offset of the top axis from the border. This number is expressed in
		/// pixels, and represents the approximate distance of the axes from the sides
		/// of the renderer. The default is 30.
		/// </summary>
		// Token: 0x0600B649 RID: 46665 RVA: 0x00100994 File Offset: 0x000FEB94
		public virtual int GetTopBorderOffsetMaxValue()
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_GetTopBorderOffsetMaxValue_38(base.GetCppThis());
		}

		// Token: 0x0600B64A RID: 46666
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLegendScaleActor_GetTopBorderOffsetMinValue_39(HandleRef pThis);

		/// <summary>
		/// Set/Get the offset of the top axis from the border. This number is expressed in
		/// pixels, and represents the approximate distance of the axes from the sides
		/// of the renderer. The default is 30.
		/// </summary>
		// Token: 0x0600B64B RID: 46667 RVA: 0x001009B4 File Offset: 0x000FEBB4
		public virtual int GetTopBorderOffsetMinValue()
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_GetTopBorderOffsetMinValue_39(base.GetCppThis());
		}

		// Token: 0x0600B64C RID: 46668
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLegendScaleActor_IsA_40(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x0600B64D RID: 46669 RVA: 0x001009D4 File Offset: 0x000FEBD4
		public override int IsA(string type)
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_IsA_40(base.GetCppThis(), type);
		}

		// Token: 0x0600B64E RID: 46670
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLegendScaleActor_IsTypeOf_41([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x0600B64F RID: 46671 RVA: 0x001009F4 File Offset: 0x000FEBF4
		public new static int IsTypeOf(string type)
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_IsTypeOf_41(type);
		}

		// Token: 0x0600B650 RID: 46672
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendScaleActor_LeftAxisVisibilityOff_42(HandleRef pThis);

		/// <summary>
		/// Set/Get the flags that control which of the four axes to display (top,
		/// bottom, left and right). By default, all the axes are displayed.
		/// </summary>
		// Token: 0x0600B651 RID: 46673 RVA: 0x00100A0E File Offset: 0x000FEC0E
		public virtual void LeftAxisVisibilityOff()
		{
			vtkLegendScaleActor.vtkLegendScaleActor_LeftAxisVisibilityOff_42(base.GetCppThis());
		}

		// Token: 0x0600B652 RID: 46674
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendScaleActor_LeftAxisVisibilityOn_43(HandleRef pThis);

		/// <summary>
		/// Set/Get the flags that control which of the four axes to display (top,
		/// bottom, left and right). By default, all the axes are displayed.
		/// </summary>
		// Token: 0x0600B653 RID: 46675 RVA: 0x00100A1D File Offset: 0x000FEC1D
		public virtual void LeftAxisVisibilityOn()
		{
			vtkLegendScaleActor.vtkLegendScaleActor_LeftAxisVisibilityOn_43(base.GetCppThis());
		}

		// Token: 0x0600B654 RID: 46676
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendScaleActor_LegendVisibilityOff_44(HandleRef pThis);

		/// <summary>
		/// Indicate whether the legend scale should be displayed or not.
		/// The default is On.
		/// </summary>
		// Token: 0x0600B655 RID: 46677 RVA: 0x00100A2C File Offset: 0x000FEC2C
		public virtual void LegendVisibilityOff()
		{
			vtkLegendScaleActor.vtkLegendScaleActor_LegendVisibilityOff_44(base.GetCppThis());
		}

		// Token: 0x0600B656 RID: 46678
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendScaleActor_LegendVisibilityOn_45(HandleRef pThis);

		/// <summary>
		/// Indicate whether the legend scale should be displayed or not.
		/// The default is On.
		/// </summary>
		// Token: 0x0600B657 RID: 46679 RVA: 0x00100A3B File Offset: 0x000FEC3B
		public virtual void LegendVisibilityOn()
		{
			vtkLegendScaleActor.vtkLegendScaleActor_LegendVisibilityOn_45(base.GetCppThis());
		}

		// Token: 0x0600B658 RID: 46680
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLegendScaleActor_NewInstance_47(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x0600B659 RID: 46681 RVA: 0x00100A4C File Offset: 0x000FEC4C
		public new vtkLegendScaleActor NewInstance()
		{
			vtkLegendScaleActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLegendScaleActor.vtkLegendScaleActor_NewInstance_47(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLegendScaleActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600B65A RID: 46682
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendScaleActor_ReleaseGraphicsResources_48(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Standard methods supporting the rendering process.
		/// </summary>
		// Token: 0x0600B65B RID: 46683 RVA: 0x00100AA8 File Offset: 0x000FECA8
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkLegendScaleActor.vtkLegendScaleActor_ReleaseGraphicsResources_48(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B65C RID: 46684
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLegendScaleActor_RenderOpaqueGeometry_49(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Standard methods supporting the rendering process.
		/// </summary>
		// Token: 0x0600B65D RID: 46685 RVA: 0x00100AD8 File Offset: 0x000FECD8
		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_RenderOpaqueGeometry_49(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B65E RID: 46686
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLegendScaleActor_RenderOverlay_50(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Standard methods supporting the rendering process.
		/// </summary>
		// Token: 0x0600B65F RID: 46687 RVA: 0x00100B0C File Offset: 0x000FED0C
		public override int RenderOverlay(vtkViewport arg0)
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_RenderOverlay_50(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B660 RID: 46688
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendScaleActor_RightAxisVisibilityOff_51(HandleRef pThis);

		/// <summary>
		/// Set/Get the flags that control which of the four axes to display (top,
		/// bottom, left and right). By default, all the axes are displayed.
		/// </summary>
		// Token: 0x0600B661 RID: 46689 RVA: 0x00100B40 File Offset: 0x000FED40
		public virtual void RightAxisVisibilityOff()
		{
			vtkLegendScaleActor.vtkLegendScaleActor_RightAxisVisibilityOff_51(base.GetCppThis());
		}

		// Token: 0x0600B662 RID: 46690
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendScaleActor_RightAxisVisibilityOn_52(HandleRef pThis);

		/// <summary>
		/// Set/Get the flags that control which of the four axes to display (top,
		/// bottom, left and right). By default, all the axes are displayed.
		/// </summary>
		// Token: 0x0600B663 RID: 46691 RVA: 0x00100B4F File Offset: 0x000FED4F
		public virtual void RightAxisVisibilityOn()
		{
			vtkLegendScaleActor.vtkLegendScaleActor_RightAxisVisibilityOn_52(base.GetCppThis());
		}

		// Token: 0x0600B664 RID: 46692
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLegendScaleActor_SafeDownCast_53(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x0600B665 RID: 46693 RVA: 0x00100B60 File Offset: 0x000FED60
		public new static vtkLegendScaleActor SafeDownCast(vtkObjectBase o)
		{
			vtkLegendScaleActor vtkLegendScaleActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLegendScaleActor.vtkLegendScaleActor_SafeDownCast_53((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLegendScaleActor = (vtkLegendScaleActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLegendScaleActor.Register(null);
				}
			}
			return vtkLegendScaleActor;
		}

		// Token: 0x0600B666 RID: 46694
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendScaleActor_SetAdjustLabels_54(HandleRef pThis, byte adjust);

		/// <summary>
		/// Configuration forwarded to each axis.
		/// </summary>
		// Token: 0x0600B667 RID: 46695 RVA: 0x00100BDF File Offset: 0x000FEDDF
		public void SetAdjustLabels(bool adjust)
		{
			vtkLegendScaleActor.vtkLegendScaleActor_SetAdjustLabels_54(base.GetCppThis(), adjust ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B668 RID: 46696
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendScaleActor_SetAxesTextProperty_55(HandleRef pThis, HandleRef property);

		/// <summary>
		/// Configuration forwarded to each axis.
		/// </summary>
		// Token: 0x0600B669 RID: 46697 RVA: 0x00100BF8 File Offset: 0x000FEDF8
		public void SetAxesTextProperty(vtkTextProperty property)
		{
			vtkLegendScaleActor.vtkLegendScaleActor_SetAxesTextProperty_55(base.GetCppThis(), (property == null) ? default(HandleRef) : property.GetCppThis());
		}

		// Token: 0x0600B66A RID: 46698
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendScaleActor_SetBottomAxisVisibility_56(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the flags that control which of the four axes to display (top,
		/// bottom, left and right). By default, all the axes are displayed.
		/// </summary>
		// Token: 0x0600B66B RID: 46699 RVA: 0x00100C27 File Offset: 0x000FEE27
		public virtual void SetBottomAxisVisibility(int _arg)
		{
			vtkLegendScaleActor.vtkLegendScaleActor_SetBottomAxisVisibility_56(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B66C RID: 46700
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendScaleActor_SetBottomBorderOffset_57(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the offset of the bottom axis from the border. This number is expressed in
		/// pixels, and represents the approximate distance of the axes from the sides
		/// of the renderer. The default is 30.
		/// </summary>
		// Token: 0x0600B66D RID: 46701 RVA: 0x00100C37 File Offset: 0x000FEE37
		public virtual void SetBottomBorderOffset(int _arg)
		{
			vtkLegendScaleActor.vtkLegendScaleActor_SetBottomBorderOffset_57(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B66E RID: 46702
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendScaleActor_SetCornerOffsetFactor_58(HandleRef pThis, double _arg);

		/// <summary>
		/// Get/Set the corner offset. This is the offset factor used to offset the
		/// axes at the corners. Default value is 2.0.
		/// </summary>
		// Token: 0x0600B66F RID: 46703 RVA: 0x00100C47 File Offset: 0x000FEE47
		public virtual void SetCornerOffsetFactor(double _arg)
		{
			vtkLegendScaleActor.vtkLegendScaleActor_SetCornerOffsetFactor_58(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B670 RID: 46704
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendScaleActor_SetLabelMode_59(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the mode for labeling the scale axes. By default, the axes are
		/// labeled with the distance between points (centered at a distance of
		/// 0.0). Alternatively if you know that the view is down the z-axis; the
		/// axes can be labeled with x-y coordinate values.
		/// </summary>
		// Token: 0x0600B671 RID: 46705 RVA: 0x00100C57 File Offset: 0x000FEE57
		public virtual void SetLabelMode(int _arg)
		{
			vtkLegendScaleActor.vtkLegendScaleActor_SetLabelMode_59(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B672 RID: 46706
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendScaleActor_SetLabelModeToDistance_60(HandleRef pThis);

		/// <summary>
		/// Specify the mode for labeling the scale axes. By default, the axes are
		/// labeled with the distance between points (centered at a distance of
		/// 0.0). Alternatively if you know that the view is down the z-axis; the
		/// axes can be labeled with x-y coordinate values.
		/// </summary>
		// Token: 0x0600B673 RID: 46707 RVA: 0x00100C67 File Offset: 0x000FEE67
		public void SetLabelModeToDistance()
		{
			vtkLegendScaleActor.vtkLegendScaleActor_SetLabelModeToDistance_60(base.GetCppThis());
		}

		// Token: 0x0600B674 RID: 46708
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendScaleActor_SetLabelModeToXYCoordinates_61(HandleRef pThis);

		/// <summary>
		/// Specify the mode for labeling the scale axes. By default, the axes are
		/// labeled with the distance between points (centered at a distance of
		/// 0.0). Alternatively if you know that the view is down the z-axis; the
		/// axes can be labeled with x-y coordinate values.
		/// </summary>
		// Token: 0x0600B675 RID: 46709 RVA: 0x00100C76 File Offset: 0x000FEE76
		public void SetLabelModeToXYCoordinates()
		{
			vtkLegendScaleActor.vtkLegendScaleActor_SetLabelModeToXYCoordinates_61(base.GetCppThis());
		}

		// Token: 0x0600B676 RID: 46710
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendScaleActor_SetLeftAxisVisibility_62(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the flags that control which of the four axes to display (top,
		/// bottom, left and right). By default, all the axes are displayed.
		/// </summary>
		// Token: 0x0600B677 RID: 46711 RVA: 0x00100C85 File Offset: 0x000FEE85
		public virtual void SetLeftAxisVisibility(int _arg)
		{
			vtkLegendScaleActor.vtkLegendScaleActor_SetLeftAxisVisibility_62(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B678 RID: 46712
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendScaleActor_SetLeftBorderOffset_63(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the offset of the left axis from the border. This number is expressed in
		/// pixels, and represents the approximate distance of the axes from the sides
		/// of the renderer. The default is 50.
		/// </summary>
		// Token: 0x0600B679 RID: 46713 RVA: 0x00100C95 File Offset: 0x000FEE95
		public virtual void SetLeftBorderOffset(int _arg)
		{
			vtkLegendScaleActor.vtkLegendScaleActor_SetLeftBorderOffset_63(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B67A RID: 46714
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendScaleActor_SetLegendVisibility_64(HandleRef pThis, int _arg);

		/// <summary>
		/// Indicate whether the legend scale should be displayed or not.
		/// The default is On.
		/// </summary>
		// Token: 0x0600B67B RID: 46715 RVA: 0x00100CA5 File Offset: 0x000FEEA5
		public virtual void SetLegendVisibility(int _arg)
		{
			vtkLegendScaleActor.vtkLegendScaleActor_SetLegendVisibility_64(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B67C RID: 46716
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendScaleActor_SetRightAxisVisibility_65(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the flags that control which of the four axes to display (top,
		/// bottom, left and right). By default, all the axes are displayed.
		/// </summary>
		// Token: 0x0600B67D RID: 46717 RVA: 0x00100CB5 File Offset: 0x000FEEB5
		public virtual void SetRightAxisVisibility(int _arg)
		{
			vtkLegendScaleActor.vtkLegendScaleActor_SetRightAxisVisibility_65(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B67E RID: 46718
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendScaleActor_SetRightBorderOffset_66(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the offset of the right axis from the border. This number is expressed in
		/// pixels, and represents the approximate distance of the axes from the sides
		/// of the renderer. The default is 50.
		/// </summary>
		// Token: 0x0600B67F RID: 46719 RVA: 0x00100CC5 File Offset: 0x000FEEC5
		public virtual void SetRightBorderOffset(int _arg)
		{
			vtkLegendScaleActor.vtkLegendScaleActor_SetRightBorderOffset_66(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B680 RID: 46720
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendScaleActor_SetTopAxisVisibility_67(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the flags that control which of the four axes to display (top,
		/// bottom, left and right). By default, all the axes are displayed.
		/// </summary>
		// Token: 0x0600B681 RID: 46721 RVA: 0x00100CD5 File Offset: 0x000FEED5
		public virtual void SetTopAxisVisibility(int _arg)
		{
			vtkLegendScaleActor.vtkLegendScaleActor_SetTopAxisVisibility_67(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B682 RID: 46722
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendScaleActor_SetTopBorderOffset_68(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the offset of the top axis from the border. This number is expressed in
		/// pixels, and represents the approximate distance of the axes from the sides
		/// of the renderer. The default is 30.
		/// </summary>
		// Token: 0x0600B683 RID: 46723 RVA: 0x00100CE5 File Offset: 0x000FEEE5
		public virtual void SetTopBorderOffset(int _arg)
		{
			vtkLegendScaleActor.vtkLegendScaleActor_SetTopBorderOffset_68(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B684 RID: 46724
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendScaleActor_SetUseFontSizeFromProperty_69(HandleRef pThis, byte sizeFromProp);

		/// <summary>
		/// Configuration forwarded to each axis.
		/// </summary>
		// Token: 0x0600B685 RID: 46725 RVA: 0x00100CF5 File Offset: 0x000FEEF5
		public void SetUseFontSizeFromProperty(bool sizeFromProp)
		{
			vtkLegendScaleActor.vtkLegendScaleActor_SetUseFontSizeFromProperty_69(base.GetCppThis(), sizeFromProp ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B686 RID: 46726
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendScaleActor_TopAxisVisibilityOff_70(HandleRef pThis);

		/// <summary>
		/// Set/Get the flags that control which of the four axes to display (top,
		/// bottom, left and right). By default, all the axes are displayed.
		/// </summary>
		// Token: 0x0600B687 RID: 46727 RVA: 0x00100D0D File Offset: 0x000FEF0D
		public virtual void TopAxisVisibilityOff()
		{
			vtkLegendScaleActor.vtkLegendScaleActor_TopAxisVisibilityOff_70(base.GetCppThis());
		}

		// Token: 0x0600B688 RID: 46728
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendScaleActor_TopAxisVisibilityOn_71(HandleRef pThis);

		/// <summary>
		/// Set/Get the flags that control which of the four axes to display (top,
		/// bottom, left and right). By default, all the axes are displayed.
		/// </summary>
		// Token: 0x0600B689 RID: 46729 RVA: 0x00100D1C File Offset: 0x000FEF1C
		public virtual void TopAxisVisibilityOn()
		{
			vtkLegendScaleActor.vtkLegendScaleActor_TopAxisVisibilityOn_71(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000DF8 RID: 3576
		public new const string MRFullTypeName = "Kitware.VTK.vtkLegendScaleActor";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000DF9 RID: 3577
		public new static readonly string MRClassNameKey = "class vtkLegendScaleActor";

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x020003D0 RID: 976
		public enum AttributeLocation
		{
			/// <summary>enum member</summary>
			// Token: 0x04000DFB RID: 3579
			DISTANCE,
			/// <summary>enum member</summary>
			// Token: 0x04000DFC RID: 3580
			XY_COORDINATES
		}
	}
}
