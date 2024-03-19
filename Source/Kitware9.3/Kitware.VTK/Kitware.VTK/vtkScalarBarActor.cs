using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkScalarBarActor
	/// </summary>
	/// <remarks>
	///    Create a scalar bar with labels
	///
	/// vtkScalarBarActor creates a scalar bar with tick marks. A scalar
	/// bar is a legend that indicates to the viewer the correspondence between
	/// color value and data value. The legend consists of a rectangular bar
	/// made of rectangular pieces each colored a constant value. Since
	/// vtkScalarBarActor is a subclass of vtkActor2D, it is drawn in the image
	/// plane (i.e., in the renderer's viewport) on top of the 3D graphics window.
	///
	/// To use vtkScalarBarActor you must associate a vtkScalarsToColors (or
	/// subclass) with it. The lookup table defines the colors and the
	/// range of scalar values used to map scalar data.  Typically, the
	/// number of colors shown in the scalar bar is not equal to the number
	/// of colors in the lookup table, in which case sampling of
	/// the lookup table is performed.
	///
	/// Other optional capabilities include specifying the fraction of the
	/// viewport size (both x and y directions) which will control the size
	/// of the scalar bar and the number of tick labels. The actual position
	/// of the scalar bar on the screen is controlled by using the
	/// vtkActor2D::SetPosition() method (by default the scalar bar is
	/// centered in the viewport).  Other features include the ability to
	/// orient the scalar bar horizontally of vertically and controlling
	/// the format (printf style) with which to print the labels on the
	/// scalar bar. Also, the vtkScalarBarActor's property is applied to
	/// the scalar bar and annotations (including layer, and
	/// compositing operator).
	///
	/// Set the text property/attributes of the title and the labels through the
	/// vtkTextProperty objects associated to this actor.
	///
	/// @warning
	/// If a vtkLogLookupTable is specified as the lookup table to use, then the
	/// labels are created using a logarithmic scale.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkActor2D vtkTextProperty vtkTextMapper vtkPolyDataMapper2D
	/// </seealso>
	// Token: 0x020003D8 RID: 984
	public class vtkScalarBarActor : vtkActor2D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600B984 RID: 47492 RVA: 0x001045CB File Offset: 0x001027CB
		static vtkScalarBarActor()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkScalarBarActor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkScalarBarActor"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600B985 RID: 47493 RVA: 0x001045F3 File Offset: 0x001027F3
		public vtkScalarBarActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600B986 RID: 47494
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScalarBarActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate object with 64 maximum colors; 5 labels; %%-#6.3g label
		/// format, no title, and vertical orientation. The initial scalar bar
		/// size is (0.05 x 0.8) of the viewport size.
		/// </summary>
		// Token: 0x0600B987 RID: 47495 RVA: 0x00104604 File Offset: 0x00102804
		public new static vtkScalarBarActor New()
		{
			vtkScalarBarActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScalarBarActor.vtkScalarBarActor_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkScalarBarActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate object with 64 maximum colors; 5 labels; %%-#6.3g label
		/// format, no title, and vertical orientation. The initial scalar bar
		/// size is (0.05 x 0.8) of the viewport size.
		/// </summary>
		// Token: 0x0600B988 RID: 47496 RVA: 0x00104658 File Offset: 0x00102858
		public vtkScalarBarActor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkScalarBarActor.vtkScalarBarActor_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600B989 RID: 47497 RVA: 0x0010469C File Offset: 0x0010289C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600B98A RID: 47498
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_AnnotationTextScalingOff_01(HandleRef pThis);

		/// <summary>
		/// Set/get whether annotation labels should be scaled with the viewport.
		///
		/// The default value is 0 (no scaling).
		/// If non-zero, the vtkTextActor instances used to render annotation
		/// labels will have their TextScaleMode set to viewport-based scaling,
		/// which nonlinearly scales font size with the viewport size.
		/// </summary>
		// Token: 0x0600B98B RID: 47499 RVA: 0x001046A7 File Offset: 0x001028A7
		public virtual void AnnotationTextScalingOff()
		{
			vtkScalarBarActor.vtkScalarBarActor_AnnotationTextScalingOff_01(base.GetCppThis());
		}

		// Token: 0x0600B98C RID: 47500
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_AnnotationTextScalingOn_02(HandleRef pThis);

		/// <summary>
		/// Set/get whether annotation labels should be scaled with the viewport.
		///
		/// The default value is 0 (no scaling).
		/// If non-zero, the vtkTextActor instances used to render annotation
		/// labels will have their TextScaleMode set to viewport-based scaling,
		/// which nonlinearly scales font size with the viewport size.
		/// </summary>
		// Token: 0x0600B98D RID: 47501 RVA: 0x001046B6 File Offset: 0x001028B6
		public virtual void AnnotationTextScalingOn()
		{
			vtkScalarBarActor.vtkScalarBarActor_AnnotationTextScalingOn_02(base.GetCppThis());
		}

		// Token: 0x0600B98E RID: 47502
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_DrawAboveRangeSwatchOff_03(HandleRef pThis);

		/// <summary>
		/// Set/get whether the Above range swatch should be rendered or not.
		/// This only affects rendering when \a DrawAnnotations is true.
		/// The default is false.
		/// </summary>
		// Token: 0x0600B98F RID: 47503 RVA: 0x001046C5 File Offset: 0x001028C5
		public virtual void DrawAboveRangeSwatchOff()
		{
			vtkScalarBarActor.vtkScalarBarActor_DrawAboveRangeSwatchOff_03(base.GetCppThis());
		}

		// Token: 0x0600B990 RID: 47504
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_DrawAboveRangeSwatchOn_04(HandleRef pThis);

		/// <summary>
		/// Set/get whether the Above range swatch should be rendered or not.
		/// This only affects rendering when \a DrawAnnotations is true.
		/// The default is false.
		/// </summary>
		// Token: 0x0600B991 RID: 47505 RVA: 0x001046D4 File Offset: 0x001028D4
		public virtual void DrawAboveRangeSwatchOn()
		{
			vtkScalarBarActor.vtkScalarBarActor_DrawAboveRangeSwatchOn_04(base.GetCppThis());
		}

		// Token: 0x0600B992 RID: 47506
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_DrawAnnotationsOff_05(HandleRef pThis);

		/// <summary>
		/// Set/get whether text annotations should be rendered or not.
		/// Currently, this only affects rendering when \a IndexedLookup is true.
		/// The default is true.
		/// </summary>
		// Token: 0x0600B993 RID: 47507 RVA: 0x001046E3 File Offset: 0x001028E3
		public virtual void DrawAnnotationsOff()
		{
			vtkScalarBarActor.vtkScalarBarActor_DrawAnnotationsOff_05(base.GetCppThis());
		}

		// Token: 0x0600B994 RID: 47508
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_DrawAnnotationsOn_06(HandleRef pThis);

		/// <summary>
		/// Set/get whether text annotations should be rendered or not.
		/// Currently, this only affects rendering when \a IndexedLookup is true.
		/// The default is true.
		/// </summary>
		// Token: 0x0600B995 RID: 47509 RVA: 0x001046F2 File Offset: 0x001028F2
		public virtual void DrawAnnotationsOn()
		{
			vtkScalarBarActor.vtkScalarBarActor_DrawAnnotationsOn_06(base.GetCppThis());
		}

		// Token: 0x0600B996 RID: 47510
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_DrawBackgroundOff_07(HandleRef pThis);

		/// <summary>
		/// Set/Get whether a background should be drawn around the scalar bar.
		/// Default is off.
		/// </summary>
		// Token: 0x0600B997 RID: 47511 RVA: 0x00104701 File Offset: 0x00102901
		public virtual void DrawBackgroundOff()
		{
			vtkScalarBarActor.vtkScalarBarActor_DrawBackgroundOff_07(base.GetCppThis());
		}

		// Token: 0x0600B998 RID: 47512
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_DrawBackgroundOn_08(HandleRef pThis);

		/// <summary>
		/// Set/Get whether a background should be drawn around the scalar bar.
		/// Default is off.
		/// </summary>
		// Token: 0x0600B999 RID: 47513 RVA: 0x00104710 File Offset: 0x00102910
		public virtual void DrawBackgroundOn()
		{
			vtkScalarBarActor.vtkScalarBarActor_DrawBackgroundOn_08(base.GetCppThis());
		}

		// Token: 0x0600B99A RID: 47514
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_DrawBelowRangeSwatchOff_09(HandleRef pThis);

		/// <summary>
		/// Set/get whether the Below range swatch should be rendered or not.
		/// This only affects rendering when \a DrawAnnotations is true.
		/// The default is false.
		/// </summary>
		// Token: 0x0600B99B RID: 47515 RVA: 0x0010471F File Offset: 0x0010291F
		public virtual void DrawBelowRangeSwatchOff()
		{
			vtkScalarBarActor.vtkScalarBarActor_DrawBelowRangeSwatchOff_09(base.GetCppThis());
		}

		// Token: 0x0600B99C RID: 47516
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_DrawBelowRangeSwatchOn_10(HandleRef pThis);

		/// <summary>
		/// Set/get whether the Below range swatch should be rendered or not.
		/// This only affects rendering when \a DrawAnnotations is true.
		/// The default is false.
		/// </summary>
		// Token: 0x0600B99D RID: 47517 RVA: 0x0010472E File Offset: 0x0010292E
		public virtual void DrawBelowRangeSwatchOn()
		{
			vtkScalarBarActor.vtkScalarBarActor_DrawBelowRangeSwatchOn_10(base.GetCppThis());
		}

		// Token: 0x0600B99E RID: 47518
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_DrawColorBarOff_11(HandleRef pThis);

		/// <summary>
		/// Set/Get whether the color bar should be drawn. If off, only the tickmarks
		/// and text will be drawn. Default is on.
		/// </summary>
		// Token: 0x0600B99F RID: 47519 RVA: 0x0010473D File Offset: 0x0010293D
		public virtual void DrawColorBarOff()
		{
			vtkScalarBarActor.vtkScalarBarActor_DrawColorBarOff_11(base.GetCppThis());
		}

		// Token: 0x0600B9A0 RID: 47520
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_DrawColorBarOn_12(HandleRef pThis);

		/// <summary>
		/// Set/Get whether the color bar should be drawn. If off, only the tickmarks
		/// and text will be drawn. Default is on.
		/// </summary>
		// Token: 0x0600B9A1 RID: 47521 RVA: 0x0010474C File Offset: 0x0010294C
		public virtual void DrawColorBarOn()
		{
			vtkScalarBarActor.vtkScalarBarActor_DrawColorBarOn_12(base.GetCppThis());
		}

		// Token: 0x0600B9A2 RID: 47522
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_DrawFrameOff_13(HandleRef pThis);

		/// <summary>
		/// Set/Get whether a frame should be drawn around the scalar bar.
		/// Default is off.
		/// </summary>
		// Token: 0x0600B9A3 RID: 47523 RVA: 0x0010475B File Offset: 0x0010295B
		public virtual void DrawFrameOff()
		{
			vtkScalarBarActor.vtkScalarBarActor_DrawFrameOff_13(base.GetCppThis());
		}

		// Token: 0x0600B9A4 RID: 47524
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_DrawFrameOn_14(HandleRef pThis);

		/// <summary>
		/// Set/Get whether a frame should be drawn around the scalar bar.
		/// Default is off.
		/// </summary>
		// Token: 0x0600B9A5 RID: 47525 RVA: 0x0010476A File Offset: 0x0010296A
		public virtual void DrawFrameOn()
		{
			vtkScalarBarActor.vtkScalarBarActor_DrawFrameOn_14(base.GetCppThis());
		}

		// Token: 0x0600B9A6 RID: 47526
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_DrawNanAnnotationOff_15(HandleRef pThis);

		/// <summary>
		/// Set/get whether the NaN annotation should be rendered or not.
		/// This only affects rendering when \a DrawAnnotations is true.
		/// The default is false.
		/// </summary>
		// Token: 0x0600B9A7 RID: 47527 RVA: 0x00104779 File Offset: 0x00102979
		public virtual void DrawNanAnnotationOff()
		{
			vtkScalarBarActor.vtkScalarBarActor_DrawNanAnnotationOff_15(base.GetCppThis());
		}

		// Token: 0x0600B9A8 RID: 47528
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_DrawNanAnnotationOn_16(HandleRef pThis);

		/// <summary>
		/// Set/get whether the NaN annotation should be rendered or not.
		/// This only affects rendering when \a DrawAnnotations is true.
		/// The default is false.
		/// </summary>
		// Token: 0x0600B9A9 RID: 47529 RVA: 0x00104788 File Offset: 0x00102988
		public virtual void DrawNanAnnotationOn()
		{
			vtkScalarBarActor.vtkScalarBarActor_DrawNanAnnotationOn_16(base.GetCppThis());
		}

		// Token: 0x0600B9AA RID: 47530
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_DrawTickLabelsOff_17(HandleRef pThis);

		/// <summary>
		/// Set/Get whether the tick labels should be drawn. Default is on.
		/// </summary>
		// Token: 0x0600B9AB RID: 47531 RVA: 0x00104797 File Offset: 0x00102997
		public virtual void DrawTickLabelsOff()
		{
			vtkScalarBarActor.vtkScalarBarActor_DrawTickLabelsOff_17(base.GetCppThis());
		}

		// Token: 0x0600B9AC RID: 47532
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_DrawTickLabelsOn_18(HandleRef pThis);

		/// <summary>
		/// Set/Get whether the tick labels should be drawn. Default is on.
		/// </summary>
		// Token: 0x0600B9AD RID: 47533 RVA: 0x001047A6 File Offset: 0x001029A6
		public virtual void DrawTickLabelsOn()
		{
			vtkScalarBarActor.vtkScalarBarActor_DrawTickLabelsOn_18(base.GetCppThis());
		}

		// Token: 0x0600B9AE RID: 47534
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_FixedAnnotationLeaderLineColorOff_19(HandleRef pThis);

		/// <summary>
		/// Set/get how leader lines connecting annotations to values should be colored.
		///
		/// When true, leader lines are all the same color (and match the LabelTextProperty color).
		/// When false, leader lines take on the color of the value they correspond to.
		/// This only affects rendering when \a DrawAnnotations is true.
		/// The default is false.
		/// </summary>
		// Token: 0x0600B9AF RID: 47535 RVA: 0x001047B5 File Offset: 0x001029B5
		public virtual void FixedAnnotationLeaderLineColorOff()
		{
			vtkScalarBarActor.vtkScalarBarActor_FixedAnnotationLeaderLineColorOff_19(base.GetCppThis());
		}

		// Token: 0x0600B9B0 RID: 47536
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_FixedAnnotationLeaderLineColorOn_20(HandleRef pThis);

		/// <summary>
		/// Set/get how leader lines connecting annotations to values should be colored.
		///
		/// When true, leader lines are all the same color (and match the LabelTextProperty color).
		/// When false, leader lines take on the color of the value they correspond to.
		/// This only affects rendering when \a DrawAnnotations is true.
		/// The default is false.
		/// </summary>
		// Token: 0x0600B9B1 RID: 47537 RVA: 0x001047C4 File Offset: 0x001029C4
		public virtual void FixedAnnotationLeaderLineColorOn()
		{
			vtkScalarBarActor.vtkScalarBarActor_FixedAnnotationLeaderLineColorOn_20(base.GetCppThis());
		}

		// Token: 0x0600B9B2 RID: 47538
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScalarBarActor_GetAboveRangeAnnotation_21(HandleRef pThis);

		/// <summary>
		/// Set/get the annotation text for "Above Range Swatch" values.
		/// </summary>
		// Token: 0x0600B9B3 RID: 47539 RVA: 0x001047D4 File Offset: 0x001029D4
		public virtual string GetAboveRangeAnnotation()
		{
			string s = Marshal.PtrToStringAnsi(vtkScalarBarActor.vtkScalarBarActor_GetAboveRangeAnnotation_21(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600B9B4 RID: 47540
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkScalarBarActor_GetAnnotationLeaderPadding_22(HandleRef pThis);

		/// <summary>
		/// Set/get the padding between the scalar bar and the text annotations.
		/// This space is used to draw leader lines.
		/// The default is 8 pixels.
		/// </summary>
		// Token: 0x0600B9B5 RID: 47541 RVA: 0x00104810 File Offset: 0x00102A10
		public virtual double GetAnnotationLeaderPadding()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetAnnotationLeaderPadding_22(base.GetCppThis());
		}

		// Token: 0x0600B9B6 RID: 47542
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScalarBarActor_GetAnnotationTextProperty_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the annotation text property.
		/// </summary>
		// Token: 0x0600B9B7 RID: 47543 RVA: 0x00104830 File Offset: 0x00102A30
		public virtual vtkTextProperty GetAnnotationTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScalarBarActor.vtkScalarBarActor_GetAnnotationTextProperty_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600B9B8 RID: 47544
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarBarActor_GetAnnotationTextScaling_24(HandleRef pThis);

		/// <summary>
		/// Set/get whether annotation labels should be scaled with the viewport.
		///
		/// The default value is 0 (no scaling).
		/// If non-zero, the vtkTextActor instances used to render annotation
		/// labels will have their TextScaleMode set to viewport-based scaling,
		/// which nonlinearly scales font size with the viewport size.
		/// </summary>
		// Token: 0x0600B9B9 RID: 47545 RVA: 0x001048A0 File Offset: 0x00102AA0
		public virtual int GetAnnotationTextScaling()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetAnnotationTextScaling_24(base.GetCppThis());
		}

		// Token: 0x0600B9BA RID: 47546
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScalarBarActor_GetBackgroundProperty_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the background property.
		/// </summary>
		// Token: 0x0600B9BB RID: 47547 RVA: 0x001048C0 File Offset: 0x00102AC0
		public virtual vtkProperty2D GetBackgroundProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScalarBarActor.vtkScalarBarActor_GetBackgroundProperty_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty2D = (vtkProperty2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty2D.Register(null);
				}
			}
			return vtkProperty2D;
		}

		// Token: 0x0600B9BC RID: 47548
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkScalarBarActor_GetBarRatio_26(HandleRef pThis);

		/// <summary>
		/// Set/get the thickness of the color bar relative to the widget frame.
		/// The default is 0.375 and must always be in the range ]0, 1[.
		/// </summary>
		// Token: 0x0600B9BD RID: 47549 RVA: 0x00104930 File Offset: 0x00102B30
		public virtual double GetBarRatio()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetBarRatio_26(base.GetCppThis());
		}

		// Token: 0x0600B9BE RID: 47550
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkScalarBarActor_GetBarRatioMaxValue_27(HandleRef pThis);

		/// <summary>
		/// Set/get the thickness of the color bar relative to the widget frame.
		/// The default is 0.375 and must always be in the range ]0, 1[.
		/// </summary>
		// Token: 0x0600B9BF RID: 47551 RVA: 0x00104950 File Offset: 0x00102B50
		public virtual double GetBarRatioMaxValue()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetBarRatioMaxValue_27(base.GetCppThis());
		}

		// Token: 0x0600B9C0 RID: 47552
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkScalarBarActor_GetBarRatioMinValue_28(HandleRef pThis);

		/// <summary>
		/// Set/get the thickness of the color bar relative to the widget frame.
		/// The default is 0.375 and must always be in the range ]0, 1[.
		/// </summary>
		// Token: 0x0600B9C1 RID: 47553 RVA: 0x00104970 File Offset: 0x00102B70
		public virtual double GetBarRatioMinValue()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetBarRatioMinValue_28(base.GetCppThis());
		}

		// Token: 0x0600B9C2 RID: 47554
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScalarBarActor_GetBelowRangeAnnotation_29(HandleRef pThis);

		/// <summary>
		/// Set/get the annotation text for "Below Range" values.
		/// </summary>
		// Token: 0x0600B9C3 RID: 47555 RVA: 0x00104990 File Offset: 0x00102B90
		public virtual string GetBelowRangeAnnotation()
		{
			string s = Marshal.PtrToStringAnsi(vtkScalarBarActor.vtkScalarBarActor_GetBelowRangeAnnotation_29(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600B9C4 RID: 47556
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScalarBarActor_GetComponentTitle_30(HandleRef pThis);

		/// <summary>
		/// Set/Get the title for the component that is selected,
		/// </summary>
		// Token: 0x0600B9C5 RID: 47557 RVA: 0x001049CC File Offset: 0x00102BCC
		public virtual string GetComponentTitle()
		{
			string s = Marshal.PtrToStringAnsi(vtkScalarBarActor.vtkScalarBarActor_GetComponentTitle_30(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600B9C6 RID: 47558
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScalarBarActor_GetCustomLabels_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the fixed locations to use.
		/// </summary>
		// Token: 0x0600B9C7 RID: 47559 RVA: 0x00104A08 File Offset: 0x00102C08
		public virtual vtkDoubleArray GetCustomLabels()
		{
			vtkDoubleArray vtkDoubleArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScalarBarActor.vtkScalarBarActor_GetCustomLabels_31(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDoubleArray = (vtkDoubleArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDoubleArray.Register(null);
				}
			}
			return vtkDoubleArray;
		}

		// Token: 0x0600B9C8 RID: 47560
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkScalarBarActor_GetDrawAboveRangeSwatch_32(HandleRef pThis);

		/// <summary>
		/// Set/get whether the Above range swatch should be rendered or not.
		/// This only affects rendering when \a DrawAnnotations is true.
		/// The default is false.
		/// </summary>
		// Token: 0x0600B9C9 RID: 47561 RVA: 0x00104A78 File Offset: 0x00102C78
		public virtual bool GetDrawAboveRangeSwatch()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetDrawAboveRangeSwatch_32(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B9CA RID: 47562
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarBarActor_GetDrawAnnotations_33(HandleRef pThis);

		/// <summary>
		/// Set/get whether text annotations should be rendered or not.
		/// Currently, this only affects rendering when \a IndexedLookup is true.
		/// The default is true.
		/// </summary>
		// Token: 0x0600B9CB RID: 47563 RVA: 0x00104AA0 File Offset: 0x00102CA0
		public virtual int GetDrawAnnotations()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetDrawAnnotations_33(base.GetCppThis());
		}

		// Token: 0x0600B9CC RID: 47564
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarBarActor_GetDrawBackground_34(HandleRef pThis);

		/// <summary>
		/// Set/Get whether a background should be drawn around the scalar bar.
		/// Default is off.
		/// </summary>
		// Token: 0x0600B9CD RID: 47565 RVA: 0x00104AC0 File Offset: 0x00102CC0
		public virtual int GetDrawBackground()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetDrawBackground_34(base.GetCppThis());
		}

		// Token: 0x0600B9CE RID: 47566
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkScalarBarActor_GetDrawBelowRangeSwatch_35(HandleRef pThis);

		/// <summary>
		/// Set/get whether the Below range swatch should be rendered or not.
		/// This only affects rendering when \a DrawAnnotations is true.
		/// The default is false.
		/// </summary>
		// Token: 0x0600B9CF RID: 47567 RVA: 0x00104AE0 File Offset: 0x00102CE0
		public virtual bool GetDrawBelowRangeSwatch()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetDrawBelowRangeSwatch_35(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B9D0 RID: 47568
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarBarActor_GetDrawColorBar_36(HandleRef pThis);

		/// <summary>
		/// Set/Get whether the color bar should be drawn. If off, only the tickmarks
		/// and text will be drawn. Default is on.
		/// </summary>
		// Token: 0x0600B9D1 RID: 47569 RVA: 0x00104B08 File Offset: 0x00102D08
		public virtual int GetDrawColorBar()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetDrawColorBar_36(base.GetCppThis());
		}

		// Token: 0x0600B9D2 RID: 47570
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarBarActor_GetDrawFrame_37(HandleRef pThis);

		/// <summary>
		/// Set/Get whether a frame should be drawn around the scalar bar.
		/// Default is off.
		/// </summary>
		// Token: 0x0600B9D3 RID: 47571 RVA: 0x00104B28 File Offset: 0x00102D28
		public virtual int GetDrawFrame()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetDrawFrame_37(base.GetCppThis());
		}

		// Token: 0x0600B9D4 RID: 47572
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarBarActor_GetDrawNanAnnotation_38(HandleRef pThis);

		/// <summary>
		/// Set/get whether the NaN annotation should be rendered or not.
		/// This only affects rendering when \a DrawAnnotations is true.
		/// The default is false.
		/// </summary>
		// Token: 0x0600B9D5 RID: 47573 RVA: 0x00104B48 File Offset: 0x00102D48
		public virtual int GetDrawNanAnnotation()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetDrawNanAnnotation_38(base.GetCppThis());
		}

		// Token: 0x0600B9D6 RID: 47574
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarBarActor_GetDrawTickLabels_39(HandleRef pThis);

		/// <summary>
		/// Set/Get whether the tick labels should be drawn. Default is on.
		/// </summary>
		// Token: 0x0600B9D7 RID: 47575 RVA: 0x00104B68 File Offset: 0x00102D68
		public virtual int GetDrawTickLabels()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetDrawTickLabels_39(base.GetCppThis());
		}

		// Token: 0x0600B9D8 RID: 47576
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarBarActor_GetFixedAnnotationLeaderLineColor_40(HandleRef pThis);

		/// <summary>
		/// Set/get how leader lines connecting annotations to values should be colored.
		///
		/// When true, leader lines are all the same color (and match the LabelTextProperty color).
		/// When false, leader lines take on the color of the value they correspond to.
		/// This only affects rendering when \a DrawAnnotations is true.
		/// The default is false.
		/// </summary>
		// Token: 0x0600B9D9 RID: 47577 RVA: 0x00104B88 File Offset: 0x00102D88
		public virtual int GetFixedAnnotationLeaderLineColor()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetFixedAnnotationLeaderLineColor_40(base.GetCppThis());
		}

		// Token: 0x0600B9DA RID: 47578
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkScalarBarActor_GetForceVerticalTitle_41(HandleRef pThis);

		/// <summary>
		/// Force the scalar bar title to be vertical.
		/// </summary>
		// Token: 0x0600B9DB RID: 47579 RVA: 0x00104BA8 File Offset: 0x00102DA8
		public virtual bool GetForceVerticalTitle()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetForceVerticalTitle_41(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B9DC RID: 47580
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScalarBarActor_GetFrameProperty_42(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the frame property.
		/// </summary>
		// Token: 0x0600B9DD RID: 47581 RVA: 0x00104BD0 File Offset: 0x00102DD0
		public virtual vtkProperty2D GetFrameProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScalarBarActor.vtkScalarBarActor_GetFrameProperty_42(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty2D = (vtkProperty2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty2D.Register(null);
				}
			}
			return vtkProperty2D;
		}

		// Token: 0x0600B9DE RID: 47582
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScalarBarActor_GetLabelFormat_43(HandleRef pThis);

		/// <summary>
		/// Set/Get the format with which to print the labels on the scalar
		/// bar.
		/// </summary>
		// Token: 0x0600B9DF RID: 47583 RVA: 0x00104C40 File Offset: 0x00102E40
		public virtual string GetLabelFormat()
		{
			string s = Marshal.PtrToStringAnsi(vtkScalarBarActor.vtkScalarBarActor_GetLabelFormat_43(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600B9E0 RID: 47584
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScalarBarActor_GetLabelTextProperty_44(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the labels text property.
		/// </summary>
		// Token: 0x0600B9E1 RID: 47585 RVA: 0x00104C7C File Offset: 0x00102E7C
		public virtual vtkTextProperty GetLabelTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScalarBarActor.vtkScalarBarActor_GetLabelTextProperty_44(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600B9E2 RID: 47586
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScalarBarActor_GetLookupTable_45(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the lookup table to use. The lookup table specifies the number
		/// of colors to use in the table (if not overridden), the scalar range,
		/// and any annotated values.
		/// Annotated values are rendered using vtkTextActor.
		/// </summary>
		// Token: 0x0600B9E3 RID: 47587 RVA: 0x00104CEC File Offset: 0x00102EEC
		public virtual vtkScalarsToColors GetLookupTable()
		{
			vtkScalarsToColors vtkScalarsToColors = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScalarBarActor.vtkScalarBarActor_GetLookupTable_45(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScalarsToColors = (vtkScalarsToColors)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScalarsToColors.Register(null);
				}
			}
			return vtkScalarsToColors;
		}

		// Token: 0x0600B9E4 RID: 47588
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarBarActor_GetMaximumHeightInPixels_46(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum width and height in pixels. Specifying the size as
		/// a relative fraction of the viewport can sometimes undesirably stretch
		/// the size of the actor too much. These methods allow the user to set
		/// bounds on the maximum size of the scalar bar in pixels along any
		/// direction. Defaults to unbounded.
		/// </summary>
		// Token: 0x0600B9E5 RID: 47589 RVA: 0x00104D5C File Offset: 0x00102F5C
		public virtual int GetMaximumHeightInPixels()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetMaximumHeightInPixels_46(base.GetCppThis());
		}

		// Token: 0x0600B9E6 RID: 47590
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarBarActor_GetMaximumNumberOfColors_47(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum number of scalar bar segments to show. This may
		/// differ from the number of colors in the lookup table, in which case
		/// the colors are samples from the lookup table.
		/// </summary>
		// Token: 0x0600B9E7 RID: 47591 RVA: 0x00104D7C File Offset: 0x00102F7C
		public virtual int GetMaximumNumberOfColors()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetMaximumNumberOfColors_47(base.GetCppThis());
		}

		// Token: 0x0600B9E8 RID: 47592
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarBarActor_GetMaximumNumberOfColorsMaxValue_48(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum number of scalar bar segments to show. This may
		/// differ from the number of colors in the lookup table, in which case
		/// the colors are samples from the lookup table.
		/// </summary>
		// Token: 0x0600B9E9 RID: 47593 RVA: 0x00104D9C File Offset: 0x00102F9C
		public virtual int GetMaximumNumberOfColorsMaxValue()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetMaximumNumberOfColorsMaxValue_48(base.GetCppThis());
		}

		// Token: 0x0600B9EA RID: 47594
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarBarActor_GetMaximumNumberOfColorsMinValue_49(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum number of scalar bar segments to show. This may
		/// differ from the number of colors in the lookup table, in which case
		/// the colors are samples from the lookup table.
		/// </summary>
		// Token: 0x0600B9EB RID: 47595 RVA: 0x00104DBC File Offset: 0x00102FBC
		public virtual int GetMaximumNumberOfColorsMinValue()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetMaximumNumberOfColorsMinValue_49(base.GetCppThis());
		}

		// Token: 0x0600B9EC RID: 47596
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarBarActor_GetMaximumWidthInPixels_50(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum width and height in pixels. Specifying the size as
		/// a relative fraction of the viewport can sometimes undesirably stretch
		/// the size of the actor too much. These methods allow the user to set
		/// bounds on the maximum size of the scalar bar in pixels along any
		/// direction. Defaults to unbounded.
		/// </summary>
		// Token: 0x0600B9ED RID: 47597 RVA: 0x00104DDC File Offset: 0x00102FDC
		public virtual int GetMaximumWidthInPixels()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetMaximumWidthInPixels_50(base.GetCppThis());
		}

		// Token: 0x0600B9EE RID: 47598
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScalarBarActor_GetNanAnnotation_51(HandleRef pThis);

		/// <summary>
		/// Set/get the annotation text for "NaN" values.
		/// </summary>
		// Token: 0x0600B9EF RID: 47599 RVA: 0x00104DFC File Offset: 0x00102FFC
		public virtual string GetNanAnnotation()
		{
			string s = Marshal.PtrToStringAnsi(vtkScalarBarActor.vtkScalarBarActor_GetNanAnnotation_51(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600B9F0 RID: 47600
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkScalarBarActor_GetNumberOfGenerationsFromBase_52(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B9F1 RID: 47601 RVA: 0x00104E38 File Offset: 0x00103038
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetNumberOfGenerationsFromBase_52(base.GetCppThis(), type);
		}

		// Token: 0x0600B9F2 RID: 47602
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkScalarBarActor_GetNumberOfGenerationsFromBaseType_53([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B9F3 RID: 47603 RVA: 0x00104E58 File Offset: 0x00103058
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetNumberOfGenerationsFromBaseType_53(type);
		}

		// Token: 0x0600B9F4 RID: 47604
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarBarActor_GetNumberOfLabels_54(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of automatic tick labels to show.
		/// </summary>
		// Token: 0x0600B9F5 RID: 47605 RVA: 0x00104E74 File Offset: 0x00103074
		public virtual int GetNumberOfLabels()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetNumberOfLabels_54(base.GetCppThis());
		}

		// Token: 0x0600B9F6 RID: 47606
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarBarActor_GetNumberOfLabelsMaxValue_55(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of automatic tick labels to show.
		/// </summary>
		// Token: 0x0600B9F7 RID: 47607 RVA: 0x00104E94 File Offset: 0x00103094
		public virtual int GetNumberOfLabelsMaxValue()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetNumberOfLabelsMaxValue_55(base.GetCppThis());
		}

		// Token: 0x0600B9F8 RID: 47608
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarBarActor_GetNumberOfLabelsMinValue_56(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of automatic tick labels to show.
		/// </summary>
		// Token: 0x0600B9F9 RID: 47609 RVA: 0x00104EB4 File Offset: 0x001030B4
		public virtual int GetNumberOfLabelsMinValue()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetNumberOfLabelsMinValue_56(base.GetCppThis());
		}

		// Token: 0x0600B9FA RID: 47610
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarBarActor_GetOrientation_57(HandleRef pThis);

		/// <summary>
		/// Control the orientation of the scalar bar.
		/// </summary>
		// Token: 0x0600B9FB RID: 47611 RVA: 0x00104ED4 File Offset: 0x001030D4
		public virtual int GetOrientation()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetOrientation_57(base.GetCppThis());
		}

		// Token: 0x0600B9FC RID: 47612
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarBarActor_GetOrientationMaxValue_58(HandleRef pThis);

		/// <summary>
		/// Control the orientation of the scalar bar.
		/// </summary>
		// Token: 0x0600B9FD RID: 47613 RVA: 0x00104EF4 File Offset: 0x001030F4
		public virtual int GetOrientationMaxValue()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetOrientationMaxValue_58(base.GetCppThis());
		}

		// Token: 0x0600B9FE RID: 47614
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarBarActor_GetOrientationMinValue_59(HandleRef pThis);

		/// <summary>
		/// Control the orientation of the scalar bar.
		/// </summary>
		// Token: 0x0600B9FF RID: 47615 RVA: 0x00104F14 File Offset: 0x00103114
		public virtual int GetOrientationMinValue()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetOrientationMinValue_59(base.GetCppThis());
		}

		// Token: 0x0600BA00 RID: 47616
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_GetScalarBarRect_60(HandleRef pThis, IntPtr rect, HandleRef viewport);

		/// <summary>
		/// Fills rect with the dimensions of the scalar bar in viewport coordinates.
		/// Only the color bar is considered -- text labels are not considered.
		/// rect is {xmin, xmax, width, height}
		/// </summary>
		// Token: 0x0600BA01 RID: 47617 RVA: 0x00104F34 File Offset: 0x00103134
		public virtual void GetScalarBarRect(IntPtr rect, vtkViewport viewport)
		{
			vtkScalarBarActor.vtkScalarBarActor_GetScalarBarRect_60(base.GetCppThis(), rect, (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x0600BA02 RID: 47618
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarBarActor_GetTextPad_61(HandleRef pThis);

		/// <summary>
		/// Set/get the amount of padding around text boxes.
		/// The default is 1 pixel.
		/// </summary>
		// Token: 0x0600BA03 RID: 47619 RVA: 0x00104F64 File Offset: 0x00103164
		public virtual int GetTextPad()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetTextPad_61(base.GetCppThis());
		}

		// Token: 0x0600BA04 RID: 47620
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarBarActor_GetTextPosition_62(HandleRef pThis);

		/// <summary>
		/// Should the title and tick marks precede the scalar bar or succeed it?
		/// This is measured along the viewport coordinate direction perpendicular
		/// to the long axis of the scalar bar, not the reading direction.
		/// Thus, succeed implies the that the text is above scalar bar if
		/// the orientation is horizontal or right of scalar bar if the orientation
		/// is vertical. Precede is the opposite.
		/// </summary>
		// Token: 0x0600BA05 RID: 47621 RVA: 0x00104F84 File Offset: 0x00103184
		public virtual int GetTextPosition()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetTextPosition_62(base.GetCppThis());
		}

		// Token: 0x0600BA06 RID: 47622
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarBarActor_GetTextPositionMaxValue_63(HandleRef pThis);

		/// <summary>
		/// Should the title and tick marks precede the scalar bar or succeed it?
		/// This is measured along the viewport coordinate direction perpendicular
		/// to the long axis of the scalar bar, not the reading direction.
		/// Thus, succeed implies the that the text is above scalar bar if
		/// the orientation is horizontal or right of scalar bar if the orientation
		/// is vertical. Precede is the opposite.
		/// </summary>
		// Token: 0x0600BA07 RID: 47623 RVA: 0x00104FA4 File Offset: 0x001031A4
		public virtual int GetTextPositionMaxValue()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetTextPositionMaxValue_63(base.GetCppThis());
		}

		// Token: 0x0600BA08 RID: 47624
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarBarActor_GetTextPositionMinValue_64(HandleRef pThis);

		/// <summary>
		/// Should the title and tick marks precede the scalar bar or succeed it?
		/// This is measured along the viewport coordinate direction perpendicular
		/// to the long axis of the scalar bar, not the reading direction.
		/// Thus, succeed implies the that the text is above scalar bar if
		/// the orientation is horizontal or right of scalar bar if the orientation
		/// is vertical. Precede is the opposite.
		/// </summary>
		// Token: 0x0600BA09 RID: 47625 RVA: 0x00104FC4 File Offset: 0x001031C4
		public virtual int GetTextPositionMinValue()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetTextPositionMinValue_64(base.GetCppThis());
		}

		// Token: 0x0600BA0A RID: 47626
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScalarBarActor_GetTextureActor_65(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the texture actor.. you may want to change some properties on it
		/// </summary>
		// Token: 0x0600BA0B RID: 47627 RVA: 0x00104FE4 File Offset: 0x001031E4
		public virtual vtkTexturedActor2D GetTextureActor()
		{
			vtkTexturedActor2D vtkTexturedActor2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScalarBarActor.vtkScalarBarActor_GetTextureActor_65(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTexturedActor2D = (vtkTexturedActor2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTexturedActor2D.Register(null);
				}
			}
			return vtkTexturedActor2D;
		}

		// Token: 0x0600BA0C RID: 47628
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkScalarBarActor_GetTextureGridWidth_66(HandleRef pThis);

		/// <summary>
		/// Set the width of the texture grid. Used only if UseOpacity is ON.
		/// </summary>
		// Token: 0x0600BA0D RID: 47629 RVA: 0x00105054 File Offset: 0x00103254
		public virtual double GetTextureGridWidth()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetTextureGridWidth_66(base.GetCppThis());
		}

		// Token: 0x0600BA0E RID: 47630
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScalarBarActor_GetTitle_67(HandleRef pThis);

		/// <summary>
		/// Set/Get the title of the scalar bar actor,
		/// </summary>
		// Token: 0x0600BA0F RID: 47631 RVA: 0x00105074 File Offset: 0x00103274
		public virtual string GetTitle()
		{
			string s = Marshal.PtrToStringAnsi(vtkScalarBarActor.vtkScalarBarActor_GetTitle_67(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600BA10 RID: 47632
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkScalarBarActor_GetTitleRatio_68(HandleRef pThis);

		/// <summary>
		/// Set/get the ratio of the title height to the tick label height
		/// (used only when the \a Orientation is horizontal).
		/// The default is 0.5, which attempts to make the labels and title
		/// the same size. This must be a number in the range ]0, 1[.
		/// </summary>
		// Token: 0x0600BA11 RID: 47633 RVA: 0x001050B0 File Offset: 0x001032B0
		public virtual double GetTitleRatio()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetTitleRatio_68(base.GetCppThis());
		}

		// Token: 0x0600BA12 RID: 47634
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkScalarBarActor_GetTitleRatioMaxValue_69(HandleRef pThis);

		/// <summary>
		/// Set/get the ratio of the title height to the tick label height
		/// (used only when the \a Orientation is horizontal).
		/// The default is 0.5, which attempts to make the labels and title
		/// the same size. This must be a number in the range ]0, 1[.
		/// </summary>
		// Token: 0x0600BA13 RID: 47635 RVA: 0x001050D0 File Offset: 0x001032D0
		public virtual double GetTitleRatioMaxValue()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetTitleRatioMaxValue_69(base.GetCppThis());
		}

		// Token: 0x0600BA14 RID: 47636
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkScalarBarActor_GetTitleRatioMinValue_70(HandleRef pThis);

		/// <summary>
		/// Set/get the ratio of the title height to the tick label height
		/// (used only when the \a Orientation is horizontal).
		/// The default is 0.5, which attempts to make the labels and title
		/// the same size. This must be a number in the range ]0, 1[.
		/// </summary>
		// Token: 0x0600BA15 RID: 47637 RVA: 0x001050F0 File Offset: 0x001032F0
		public virtual double GetTitleRatioMinValue()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetTitleRatioMinValue_70(base.GetCppThis());
		}

		// Token: 0x0600BA16 RID: 47638
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScalarBarActor_GetTitleTextProperty_71(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the title text property.
		/// </summary>
		// Token: 0x0600BA17 RID: 47639 RVA: 0x00105110 File Offset: 0x00103310
		public virtual vtkTextProperty GetTitleTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScalarBarActor.vtkScalarBarActor_GetTitleTextProperty_71(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600BA18 RID: 47640
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkScalarBarActor_GetUnconstrainedFontSize_72(HandleRef pThis);

		/// <summary>
		/// Set/Get whether the font size of title and labels is unconstrained. Default is off.
		/// When it is constrained, the size of the scalar bar will constrain the font size.
		/// When it is not, the size of the font will always be respected.
		/// Using custom labels will force this mode to be on.
		/// </summary>
		// Token: 0x0600BA19 RID: 47641 RVA: 0x00105180 File Offset: 0x00103380
		public virtual bool GetUnconstrainedFontSize()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetUnconstrainedFontSize_72(base.GetCppThis()) != 0;
		}

		// Token: 0x0600BA1A RID: 47642
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkScalarBarActor_GetUseCustomLabels_73(HandleRef pThis);

		/// <summary>
		/// Get/Set whether custom labels will be used.
		/// bonds. Default: Off.
		/// </summary>
		// Token: 0x0600BA1B RID: 47643 RVA: 0x001051A8 File Offset: 0x001033A8
		public virtual bool GetUseCustomLabels()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetUseCustomLabels_73(base.GetCppThis()) != 0;
		}

		// Token: 0x0600BA1C RID: 47644
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarBarActor_GetUseOpacity_74(HandleRef pThis);

		/// <summary>
		/// Should be display the opacity as well. This is displayed by changing
		/// the opacity of the scalar bar in accordance with the opacity of the
		/// given color. For clarity, a texture grid is placed in the background
		/// if Opacity is ON. You might also want to play with SetTextureGridWith
		/// in that case. [Default: off]
		/// </summary>
		// Token: 0x0600BA1D RID: 47645 RVA: 0x001051D0 File Offset: 0x001033D0
		public virtual int GetUseOpacity()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetUseOpacity_74(base.GetCppThis());
		}

		// Token: 0x0600BA1E RID: 47646
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarBarActor_GetVerticalTitleSeparation_75(HandleRef pThis);

		/// <summary>
		/// Set/get the margin in pixels, between the title and the bar,
		/// when the \a Orientation is vertical.
		/// The default is 0 pixels.
		/// </summary>
		// Token: 0x0600BA1F RID: 47647 RVA: 0x001051F0 File Offset: 0x001033F0
		public virtual int GetVerticalTitleSeparation()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetVerticalTitleSeparation_75(base.GetCppThis());
		}

		// Token: 0x0600BA20 RID: 47648
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarBarActor_HasTranslucentPolygonalGeometry_76(HandleRef pThis);

		/// <summary>
		/// Does this prop have some translucent polygonal geometry?
		/// </summary>
		// Token: 0x0600BA21 RID: 47649 RVA: 0x00105210 File Offset: 0x00103410
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkScalarBarActor.vtkScalarBarActor_HasTranslucentPolygonalGeometry_76(base.GetCppThis());
		}

		// Token: 0x0600BA22 RID: 47650
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarBarActor_IsA_77(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BA23 RID: 47651 RVA: 0x00105230 File Offset: 0x00103430
		public override int IsA(string type)
		{
			return vtkScalarBarActor.vtkScalarBarActor_IsA_77(base.GetCppThis(), type);
		}

		// Token: 0x0600BA24 RID: 47652
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarBarActor_IsTypeOf_78([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BA25 RID: 47653 RVA: 0x00105250 File Offset: 0x00103450
		public new static int IsTypeOf(string type)
		{
			return vtkScalarBarActor.vtkScalarBarActor_IsTypeOf_78(type);
		}

		// Token: 0x0600BA26 RID: 47654
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScalarBarActor_NewInstance_80(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BA27 RID: 47655 RVA: 0x0010526C File Offset: 0x0010346C
		public new vtkScalarBarActor NewInstance()
		{
			vtkScalarBarActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScalarBarActor.vtkScalarBarActor_NewInstance_80(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkScalarBarActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600BA28 RID: 47656
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_ReleaseGraphicsResources_81(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Release any graphics resources that are being consumed by this actor.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x0600BA29 RID: 47657 RVA: 0x001052C8 File Offset: 0x001034C8
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkScalarBarActor.vtkScalarBarActor_ReleaseGraphicsResources_81(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600BA2A RID: 47658
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarBarActor_RenderOpaqueGeometry_82(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Draw the scalar bar and annotation text to the screen.
		/// </summary>
		// Token: 0x0600BA2B RID: 47659 RVA: 0x001052F8 File Offset: 0x001034F8
		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkScalarBarActor.vtkScalarBarActor_RenderOpaqueGeometry_82(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x0600BA2C RID: 47660
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarBarActor_RenderOverlay_83(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Draw the scalar bar and annotation text to the screen.
		/// </summary>
		// Token: 0x0600BA2D RID: 47661 RVA: 0x0010532C File Offset: 0x0010352C
		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkScalarBarActor.vtkScalarBarActor_RenderOverlay_83(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x0600BA2E RID: 47662
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarBarActor_RenderTranslucentPolygonalGeometry_84(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Draw the scalar bar and annotation text to the screen.
		/// </summary>
		// Token: 0x0600BA2F RID: 47663 RVA: 0x00105360 File Offset: 0x00103560
		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkScalarBarActor.vtkScalarBarActor_RenderTranslucentPolygonalGeometry_84(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600BA30 RID: 47664
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScalarBarActor_SafeDownCast_85(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BA31 RID: 47665 RVA: 0x00105394 File Offset: 0x00103594
		public new static vtkScalarBarActor SafeDownCast(vtkObjectBase o)
		{
			vtkScalarBarActor vtkScalarBarActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScalarBarActor.vtkScalarBarActor_SafeDownCast_85((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScalarBarActor = (vtkScalarBarActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScalarBarActor.Register(null);
				}
			}
			return vtkScalarBarActor;
		}

		// Token: 0x0600BA32 RID: 47666
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_SetAboveRangeAnnotation_86(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/get the annotation text for "Above Range Swatch" values.
		/// </summary>
		// Token: 0x0600BA33 RID: 47667 RVA: 0x00105413 File Offset: 0x00103613
		public virtual void SetAboveRangeAnnotation(string _arg)
		{
			vtkScalarBarActor.vtkScalarBarActor_SetAboveRangeAnnotation_86(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BA34 RID: 47668
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_SetAnnotationLeaderPadding_87(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/get the padding between the scalar bar and the text annotations.
		/// This space is used to draw leader lines.
		/// The default is 8 pixels.
		/// </summary>
		// Token: 0x0600BA35 RID: 47669 RVA: 0x00105423 File Offset: 0x00103623
		public virtual void SetAnnotationLeaderPadding(double _arg)
		{
			vtkScalarBarActor.vtkScalarBarActor_SetAnnotationLeaderPadding_87(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BA36 RID: 47670
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_SetAnnotationTextProperty_88(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Set/Get the annotation text property.
		/// </summary>
		// Token: 0x0600BA37 RID: 47671 RVA: 0x00105434 File Offset: 0x00103634
		public virtual void SetAnnotationTextProperty(vtkTextProperty p)
		{
			vtkScalarBarActor.vtkScalarBarActor_SetAnnotationTextProperty_88(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x0600BA38 RID: 47672
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_SetAnnotationTextScaling_89(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get whether annotation labels should be scaled with the viewport.
		///
		/// The default value is 0 (no scaling).
		/// If non-zero, the vtkTextActor instances used to render annotation
		/// labels will have their TextScaleMode set to viewport-based scaling,
		/// which nonlinearly scales font size with the viewport size.
		/// </summary>
		// Token: 0x0600BA39 RID: 47673 RVA: 0x00105463 File Offset: 0x00103663
		public virtual void SetAnnotationTextScaling(int _arg)
		{
			vtkScalarBarActor.vtkScalarBarActor_SetAnnotationTextScaling_89(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BA3A RID: 47674
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_SetBackgroundProperty_90(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Set/Get the background property.
		/// </summary>
		// Token: 0x0600BA3B RID: 47675 RVA: 0x00105474 File Offset: 0x00103674
		public virtual void SetBackgroundProperty(vtkProperty2D p)
		{
			vtkScalarBarActor.vtkScalarBarActor_SetBackgroundProperty_90(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x0600BA3C RID: 47676
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_SetBarRatio_91(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/get the thickness of the color bar relative to the widget frame.
		/// The default is 0.375 and must always be in the range ]0, 1[.
		/// </summary>
		// Token: 0x0600BA3D RID: 47677 RVA: 0x001054A3 File Offset: 0x001036A3
		public virtual void SetBarRatio(double _arg)
		{
			vtkScalarBarActor.vtkScalarBarActor_SetBarRatio_91(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BA3E RID: 47678
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_SetBelowRangeAnnotation_92(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/get the annotation text for "Below Range" values.
		/// </summary>
		// Token: 0x0600BA3F RID: 47679 RVA: 0x001054B3 File Offset: 0x001036B3
		public virtual void SetBelowRangeAnnotation(string _arg)
		{
			vtkScalarBarActor.vtkScalarBarActor_SetBelowRangeAnnotation_92(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BA40 RID: 47680
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_SetComponentTitle_93(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the title for the component that is selected,
		/// </summary>
		// Token: 0x0600BA41 RID: 47681 RVA: 0x001054C3 File Offset: 0x001036C3
		public virtual void SetComponentTitle(string _arg)
		{
			vtkScalarBarActor.vtkScalarBarActor_SetComponentTitle_93(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BA42 RID: 47682
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_SetCustomLabels_94(HandleRef pThis, HandleRef labels);

		/// <summary>
		/// Set/Get the fixed locations to use.
		/// </summary>
		// Token: 0x0600BA43 RID: 47683 RVA: 0x001054D4 File Offset: 0x001036D4
		public virtual void SetCustomLabels(vtkDoubleArray labels)
		{
			vtkScalarBarActor.vtkScalarBarActor_SetCustomLabels_94(base.GetCppThis(), (labels == null) ? default(HandleRef) : labels.GetCppThis());
		}

		// Token: 0x0600BA44 RID: 47684
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_SetDrawAboveRangeSwatch_95(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/get whether the Above range swatch should be rendered or not.
		/// This only affects rendering when \a DrawAnnotations is true.
		/// The default is false.
		/// </summary>
		// Token: 0x0600BA45 RID: 47685 RVA: 0x00105503 File Offset: 0x00103703
		public virtual void SetDrawAboveRangeSwatch(bool _arg)
		{
			vtkScalarBarActor.vtkScalarBarActor_SetDrawAboveRangeSwatch_95(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600BA46 RID: 47686
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_SetDrawAnnotations_96(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get whether text annotations should be rendered or not.
		/// Currently, this only affects rendering when \a IndexedLookup is true.
		/// The default is true.
		/// </summary>
		// Token: 0x0600BA47 RID: 47687 RVA: 0x0010551B File Offset: 0x0010371B
		public virtual void SetDrawAnnotations(int _arg)
		{
			vtkScalarBarActor.vtkScalarBarActor_SetDrawAnnotations_96(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BA48 RID: 47688
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_SetDrawBackground_97(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get whether a background should be drawn around the scalar bar.
		/// Default is off.
		/// </summary>
		// Token: 0x0600BA49 RID: 47689 RVA: 0x0010552B File Offset: 0x0010372B
		public virtual void SetDrawBackground(int _arg)
		{
			vtkScalarBarActor.vtkScalarBarActor_SetDrawBackground_97(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BA4A RID: 47690
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_SetDrawBelowRangeSwatch_98(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/get whether the Below range swatch should be rendered or not.
		/// This only affects rendering when \a DrawAnnotations is true.
		/// The default is false.
		/// </summary>
		// Token: 0x0600BA4B RID: 47691 RVA: 0x0010553B File Offset: 0x0010373B
		public virtual void SetDrawBelowRangeSwatch(bool _arg)
		{
			vtkScalarBarActor.vtkScalarBarActor_SetDrawBelowRangeSwatch_98(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600BA4C RID: 47692
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_SetDrawColorBar_99(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get whether the color bar should be drawn. If off, only the tickmarks
		/// and text will be drawn. Default is on.
		/// </summary>
		// Token: 0x0600BA4D RID: 47693 RVA: 0x00105553 File Offset: 0x00103753
		public virtual void SetDrawColorBar(int _arg)
		{
			vtkScalarBarActor.vtkScalarBarActor_SetDrawColorBar_99(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BA4E RID: 47694
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_SetDrawFrame_100(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get whether a frame should be drawn around the scalar bar.
		/// Default is off.
		/// </summary>
		// Token: 0x0600BA4F RID: 47695 RVA: 0x00105563 File Offset: 0x00103763
		public virtual void SetDrawFrame(int _arg)
		{
			vtkScalarBarActor.vtkScalarBarActor_SetDrawFrame_100(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BA50 RID: 47696
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_SetDrawNanAnnotation_101(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get whether the NaN annotation should be rendered or not.
		/// This only affects rendering when \a DrawAnnotations is true.
		/// The default is false.
		/// </summary>
		// Token: 0x0600BA51 RID: 47697 RVA: 0x00105573 File Offset: 0x00103773
		public virtual void SetDrawNanAnnotation(int _arg)
		{
			vtkScalarBarActor.vtkScalarBarActor_SetDrawNanAnnotation_101(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BA52 RID: 47698
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_SetDrawTickLabels_102(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get whether the tick labels should be drawn. Default is on.
		/// </summary>
		// Token: 0x0600BA53 RID: 47699 RVA: 0x00105583 File Offset: 0x00103783
		public virtual void SetDrawTickLabels(int _arg)
		{
			vtkScalarBarActor.vtkScalarBarActor_SetDrawTickLabels_102(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BA54 RID: 47700
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_SetFixedAnnotationLeaderLineColor_103(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get how leader lines connecting annotations to values should be colored.
		///
		/// When true, leader lines are all the same color (and match the LabelTextProperty color).
		/// When false, leader lines take on the color of the value they correspond to.
		/// This only affects rendering when \a DrawAnnotations is true.
		/// The default is false.
		/// </summary>
		// Token: 0x0600BA55 RID: 47701 RVA: 0x00105593 File Offset: 0x00103793
		public virtual void SetFixedAnnotationLeaderLineColor(int _arg)
		{
			vtkScalarBarActor.vtkScalarBarActor_SetFixedAnnotationLeaderLineColor_103(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BA56 RID: 47702
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_SetForceVerticalTitle_104(HandleRef pThis, byte _arg);

		/// <summary>
		/// Force the scalar bar title to be vertical.
		/// </summary>
		// Token: 0x0600BA57 RID: 47703 RVA: 0x001055A3 File Offset: 0x001037A3
		public virtual void SetForceVerticalTitle(bool _arg)
		{
			vtkScalarBarActor.vtkScalarBarActor_SetForceVerticalTitle_104(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600BA58 RID: 47704
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_SetFrameProperty_105(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Set/Get the frame property.
		/// </summary>
		// Token: 0x0600BA59 RID: 47705 RVA: 0x001055BC File Offset: 0x001037BC
		public virtual void SetFrameProperty(vtkProperty2D p)
		{
			vtkScalarBarActor.vtkScalarBarActor_SetFrameProperty_105(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x0600BA5A RID: 47706
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_SetLabelFormat_106(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the format with which to print the labels on the scalar
		/// bar.
		/// </summary>
		// Token: 0x0600BA5B RID: 47707 RVA: 0x001055EB File Offset: 0x001037EB
		public virtual void SetLabelFormat(string _arg)
		{
			vtkScalarBarActor.vtkScalarBarActor_SetLabelFormat_106(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BA5C RID: 47708
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_SetLabelTextProperty_107(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Set/Get the labels text property.
		/// </summary>
		// Token: 0x0600BA5D RID: 47709 RVA: 0x001055FC File Offset: 0x001037FC
		public virtual void SetLabelTextProperty(vtkTextProperty p)
		{
			vtkScalarBarActor.vtkScalarBarActor_SetLabelTextProperty_107(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x0600BA5E RID: 47710
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_SetLookupTable_108(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the lookup table to use. The lookup table specifies the number
		/// of colors to use in the table (if not overridden), the scalar range,
		/// and any annotated values.
		/// Annotated values are rendered using vtkTextActor.
		/// </summary>
		// Token: 0x0600BA5F RID: 47711 RVA: 0x0010562C File Offset: 0x0010382C
		public virtual void SetLookupTable(vtkScalarsToColors arg0)
		{
			vtkScalarBarActor.vtkScalarBarActor_SetLookupTable_108(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600BA60 RID: 47712
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_SetMaximumHeightInPixels_109(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the maximum width and height in pixels. Specifying the size as
		/// a relative fraction of the viewport can sometimes undesirably stretch
		/// the size of the actor too much. These methods allow the user to set
		/// bounds on the maximum size of the scalar bar in pixels along any
		/// direction. Defaults to unbounded.
		/// </summary>
		// Token: 0x0600BA61 RID: 47713 RVA: 0x0010565B File Offset: 0x0010385B
		public virtual void SetMaximumHeightInPixels(int _arg)
		{
			vtkScalarBarActor.vtkScalarBarActor_SetMaximumHeightInPixels_109(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BA62 RID: 47714
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_SetMaximumNumberOfColors_110(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the maximum number of scalar bar segments to show. This may
		/// differ from the number of colors in the lookup table, in which case
		/// the colors are samples from the lookup table.
		/// </summary>
		// Token: 0x0600BA63 RID: 47715 RVA: 0x0010566B File Offset: 0x0010386B
		public virtual void SetMaximumNumberOfColors(int _arg)
		{
			vtkScalarBarActor.vtkScalarBarActor_SetMaximumNumberOfColors_110(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BA64 RID: 47716
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_SetMaximumWidthInPixels_111(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the maximum width and height in pixels. Specifying the size as
		/// a relative fraction of the viewport can sometimes undesirably stretch
		/// the size of the actor too much. These methods allow the user to set
		/// bounds on the maximum size of the scalar bar in pixels along any
		/// direction. Defaults to unbounded.
		/// </summary>
		// Token: 0x0600BA65 RID: 47717 RVA: 0x0010567B File Offset: 0x0010387B
		public virtual void SetMaximumWidthInPixels(int _arg)
		{
			vtkScalarBarActor.vtkScalarBarActor_SetMaximumWidthInPixels_111(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BA66 RID: 47718
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_SetNanAnnotation_112(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/get the annotation text for "NaN" values.
		/// </summary>
		// Token: 0x0600BA67 RID: 47719 RVA: 0x0010568B File Offset: 0x0010388B
		public virtual void SetNanAnnotation(string _arg)
		{
			vtkScalarBarActor.vtkScalarBarActor_SetNanAnnotation_112(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BA68 RID: 47720
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_SetNumberOfLabels_113(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the number of automatic tick labels to show.
		/// </summary>
		// Token: 0x0600BA69 RID: 47721 RVA: 0x0010569B File Offset: 0x0010389B
		public virtual void SetNumberOfLabels(int _arg)
		{
			vtkScalarBarActor.vtkScalarBarActor_SetNumberOfLabels_113(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BA6A RID: 47722
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_SetOrientation_114(HandleRef pThis, int _arg);

		/// <summary>
		/// Control the orientation of the scalar bar.
		/// </summary>
		// Token: 0x0600BA6B RID: 47723 RVA: 0x001056AB File Offset: 0x001038AB
		public virtual void SetOrientation(int _arg)
		{
			vtkScalarBarActor.vtkScalarBarActor_SetOrientation_114(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BA6C RID: 47724
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_SetOrientationToHorizontal_115(HandleRef pThis);

		/// <summary>
		/// Control the orientation of the scalar bar.
		/// </summary>
		// Token: 0x0600BA6D RID: 47725 RVA: 0x001056BB File Offset: 0x001038BB
		public void SetOrientationToHorizontal()
		{
			vtkScalarBarActor.vtkScalarBarActor_SetOrientationToHorizontal_115(base.GetCppThis());
		}

		// Token: 0x0600BA6E RID: 47726
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_SetOrientationToVertical_116(HandleRef pThis);

		/// <summary>
		/// Control the orientation of the scalar bar.
		/// </summary>
		// Token: 0x0600BA6F RID: 47727 RVA: 0x001056CA File Offset: 0x001038CA
		public void SetOrientationToVertical()
		{
			vtkScalarBarActor.vtkScalarBarActor_SetOrientationToVertical_116(base.GetCppThis());
		}

		// Token: 0x0600BA70 RID: 47728
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_SetTextPad_117(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the amount of padding around text boxes.
		/// The default is 1 pixel.
		/// </summary>
		// Token: 0x0600BA71 RID: 47729 RVA: 0x001056D9 File Offset: 0x001038D9
		public virtual void SetTextPad(int _arg)
		{
			vtkScalarBarActor.vtkScalarBarActor_SetTextPad_117(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BA72 RID: 47730
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_SetTextPosition_118(HandleRef pThis, int _arg);

		/// <summary>
		/// Should the title and tick marks precede the scalar bar or succeed it?
		/// This is measured along the viewport coordinate direction perpendicular
		/// to the long axis of the scalar bar, not the reading direction.
		/// Thus, succeed implies the that the text is above scalar bar if
		/// the orientation is horizontal or right of scalar bar if the orientation
		/// is vertical. Precede is the opposite.
		/// </summary>
		// Token: 0x0600BA73 RID: 47731 RVA: 0x001056E9 File Offset: 0x001038E9
		public virtual void SetTextPosition(int _arg)
		{
			vtkScalarBarActor.vtkScalarBarActor_SetTextPosition_118(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BA74 RID: 47732
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_SetTextPositionToPrecedeScalarBar_119(HandleRef pThis);

		/// <summary>
		/// Should the title and tick marks precede the scalar bar or succeed it?
		/// This is measured along the viewport coordinate direction perpendicular
		/// to the long axis of the scalar bar, not the reading direction.
		/// Thus, succeed implies the that the text is above scalar bar if
		/// the orientation is horizontal or right of scalar bar if the orientation
		/// is vertical. Precede is the opposite.
		/// </summary>
		// Token: 0x0600BA75 RID: 47733 RVA: 0x001056F9 File Offset: 0x001038F9
		public virtual void SetTextPositionToPrecedeScalarBar()
		{
			vtkScalarBarActor.vtkScalarBarActor_SetTextPositionToPrecedeScalarBar_119(base.GetCppThis());
		}

		// Token: 0x0600BA76 RID: 47734
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_SetTextPositionToSucceedScalarBar_120(HandleRef pThis);

		/// <summary>
		/// Should the title and tick marks precede the scalar bar or succeed it?
		/// This is measured along the viewport coordinate direction perpendicular
		/// to the long axis of the scalar bar, not the reading direction.
		/// Thus, succeed implies the that the text is above scalar bar if
		/// the orientation is horizontal or right of scalar bar if the orientation
		/// is vertical. Precede is the opposite.
		/// </summary>
		// Token: 0x0600BA77 RID: 47735 RVA: 0x00105708 File Offset: 0x00103908
		public virtual void SetTextPositionToSucceedScalarBar()
		{
			vtkScalarBarActor.vtkScalarBarActor_SetTextPositionToSucceedScalarBar_120(base.GetCppThis());
		}

		// Token: 0x0600BA78 RID: 47736
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_SetTextureGridWidth_121(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the width of the texture grid. Used only if UseOpacity is ON.
		/// </summary>
		// Token: 0x0600BA79 RID: 47737 RVA: 0x00105717 File Offset: 0x00103917
		public virtual void SetTextureGridWidth(double _arg)
		{
			vtkScalarBarActor.vtkScalarBarActor_SetTextureGridWidth_121(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BA7A RID: 47738
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_SetTitle_122(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the title of the scalar bar actor,
		/// </summary>
		// Token: 0x0600BA7B RID: 47739 RVA: 0x00105727 File Offset: 0x00103927
		public virtual void SetTitle(string _arg)
		{
			vtkScalarBarActor.vtkScalarBarActor_SetTitle_122(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BA7C RID: 47740
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_SetTitleRatio_123(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/get the ratio of the title height to the tick label height
		/// (used only when the \a Orientation is horizontal).
		/// The default is 0.5, which attempts to make the labels and title
		/// the same size. This must be a number in the range ]0, 1[.
		/// </summary>
		// Token: 0x0600BA7D RID: 47741 RVA: 0x00105737 File Offset: 0x00103937
		public virtual void SetTitleRatio(double _arg)
		{
			vtkScalarBarActor.vtkScalarBarActor_SetTitleRatio_123(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BA7E RID: 47742
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_SetTitleTextProperty_124(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Set/Get the title text property.
		/// </summary>
		// Token: 0x0600BA7F RID: 47743 RVA: 0x00105748 File Offset: 0x00103948
		public virtual void SetTitleTextProperty(vtkTextProperty p)
		{
			vtkScalarBarActor.vtkScalarBarActor_SetTitleTextProperty_124(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x0600BA80 RID: 47744
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_SetUnconstrainedFontSize_125(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get whether the font size of title and labels is unconstrained. Default is off.
		/// When it is constrained, the size of the scalar bar will constrain the font size.
		/// When it is not, the size of the font will always be respected.
		/// Using custom labels will force this mode to be on.
		/// </summary>
		// Token: 0x0600BA81 RID: 47745 RVA: 0x00105777 File Offset: 0x00103977
		public virtual void SetUnconstrainedFontSize(bool _arg)
		{
			vtkScalarBarActor.vtkScalarBarActor_SetUnconstrainedFontSize_125(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600BA82 RID: 47746
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_SetUseCustomLabels_126(HandleRef pThis, byte _arg);

		/// <summary>
		/// Get/Set whether custom labels will be used.
		/// bonds. Default: Off.
		/// </summary>
		// Token: 0x0600BA83 RID: 47747 RVA: 0x0010578F File Offset: 0x0010398F
		public virtual void SetUseCustomLabels(bool _arg)
		{
			vtkScalarBarActor.vtkScalarBarActor_SetUseCustomLabels_126(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600BA84 RID: 47748
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_SetUseOpacity_127(HandleRef pThis, int _arg);

		/// <summary>
		/// Should be display the opacity as well. This is displayed by changing
		/// the opacity of the scalar bar in accordance with the opacity of the
		/// given color. For clarity, a texture grid is placed in the background
		/// if Opacity is ON. You might also want to play with SetTextureGridWith
		/// in that case. [Default: off]
		/// </summary>
		// Token: 0x0600BA85 RID: 47749 RVA: 0x001057A7 File Offset: 0x001039A7
		public virtual void SetUseOpacity(int _arg)
		{
			vtkScalarBarActor.vtkScalarBarActor_SetUseOpacity_127(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BA86 RID: 47750
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_SetVerticalTitleSeparation_128(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the margin in pixels, between the title and the bar,
		/// when the \a Orientation is vertical.
		/// The default is 0 pixels.
		/// </summary>
		// Token: 0x0600BA87 RID: 47751 RVA: 0x001057B7 File Offset: 0x001039B7
		public virtual void SetVerticalTitleSeparation(int _arg)
		{
			vtkScalarBarActor.vtkScalarBarActor_SetVerticalTitleSeparation_128(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BA88 RID: 47752
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_ShallowCopy_129(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Shallow copy of a scalar bar actor. Overloads the virtual vtkProp method.
		/// </summary>
		// Token: 0x0600BA89 RID: 47753 RVA: 0x001057C8 File Offset: 0x001039C8
		public override void ShallowCopy(vtkProp prop)
		{
			vtkScalarBarActor.vtkScalarBarActor_ShallowCopy_129(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		// Token: 0x0600BA8A RID: 47754
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_UnconstrainedFontSizeOff_130(HandleRef pThis);

		/// <summary>
		/// Set/Get whether the font size of title and labels is unconstrained. Default is off.
		/// When it is constrained, the size of the scalar bar will constrain the font size.
		/// When it is not, the size of the font will always be respected.
		/// Using custom labels will force this mode to be on.
		/// </summary>
		// Token: 0x0600BA8B RID: 47755 RVA: 0x001057F7 File Offset: 0x001039F7
		public virtual void UnconstrainedFontSizeOff()
		{
			vtkScalarBarActor.vtkScalarBarActor_UnconstrainedFontSizeOff_130(base.GetCppThis());
		}

		// Token: 0x0600BA8C RID: 47756
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_UnconstrainedFontSizeOn_131(HandleRef pThis);

		/// <summary>
		/// Set/Get whether the font size of title and labels is unconstrained. Default is off.
		/// When it is constrained, the size of the scalar bar will constrain the font size.
		/// When it is not, the size of the font will always be respected.
		/// Using custom labels will force this mode to be on.
		/// </summary>
		// Token: 0x0600BA8D RID: 47757 RVA: 0x00105806 File Offset: 0x00103A06
		public virtual void UnconstrainedFontSizeOn()
		{
			vtkScalarBarActor.vtkScalarBarActor_UnconstrainedFontSizeOn_131(base.GetCppThis());
		}

		// Token: 0x0600BA8E RID: 47758
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_UseCustomLabelsOff_132(HandleRef pThis);

		/// <summary>
		/// Get/Set whether custom labels will be used.
		/// bonds. Default: Off.
		/// </summary>
		// Token: 0x0600BA8F RID: 47759 RVA: 0x00105815 File Offset: 0x00103A15
		public virtual void UseCustomLabelsOff()
		{
			vtkScalarBarActor.vtkScalarBarActor_UseCustomLabelsOff_132(base.GetCppThis());
		}

		// Token: 0x0600BA90 RID: 47760
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_UseCustomLabelsOn_133(HandleRef pThis);

		/// <summary>
		/// Get/Set whether custom labels will be used.
		/// bonds. Default: Off.
		/// </summary>
		// Token: 0x0600BA91 RID: 47761 RVA: 0x00105824 File Offset: 0x00103A24
		public virtual void UseCustomLabelsOn()
		{
			vtkScalarBarActor.vtkScalarBarActor_UseCustomLabelsOn_133(base.GetCppThis());
		}

		// Token: 0x0600BA92 RID: 47762
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_UseOpacityOff_134(HandleRef pThis);

		/// <summary>
		/// Should be display the opacity as well. This is displayed by changing
		/// the opacity of the scalar bar in accordance with the opacity of the
		/// given color. For clarity, a texture grid is placed in the background
		/// if Opacity is ON. You might also want to play with SetTextureGridWith
		/// in that case. [Default: off]
		/// </summary>
		// Token: 0x0600BA93 RID: 47763 RVA: 0x00105833 File Offset: 0x00103A33
		public virtual void UseOpacityOff()
		{
			vtkScalarBarActor.vtkScalarBarActor_UseOpacityOff_134(base.GetCppThis());
		}

		// Token: 0x0600BA94 RID: 47764
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarActor_UseOpacityOn_135(HandleRef pThis);

		/// <summary>
		/// Should be display the opacity as well. This is displayed by changing
		/// the opacity of the scalar bar in accordance with the opacity of the
		/// given color. For clarity, a texture grid is placed in the background
		/// if Opacity is ON. You might also want to play with SetTextureGridWith
		/// in that case. [Default: off]
		/// </summary>
		// Token: 0x0600BA95 RID: 47765 RVA: 0x00105842 File Offset: 0x00103A42
		public virtual void UseOpacityOn()
		{
			vtkScalarBarActor.vtkScalarBarActor_UseOpacityOn_135(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E0E RID: 3598
		public new const string MRFullTypeName = "Kitware.VTK.vtkScalarBarActor";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E0F RID: 3599
		public new static readonly string MRClassNameKey = "class vtkScalarBarActor";

		/// <summary>
		/// Get the texture actor.. you may want to change some properties on it
		/// </summary>
		// Token: 0x020003D9 RID: 985
		public enum PrecedeScalarBar_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000E11 RID: 3601
			PrecedeScalarBar,
			/// <summary>enum member</summary>
			// Token: 0x04000E12 RID: 3602
			SucceedScalarBar
		}
	}
}
