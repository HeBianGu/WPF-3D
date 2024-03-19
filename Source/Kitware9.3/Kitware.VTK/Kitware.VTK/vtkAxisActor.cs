using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAxisActor
	/// </summary>
	/// <remarks>
	///    Create an axis with tick marks and labels
	///
	/// vtkAxisActor creates an axis with tick marks, labels, and/or a title,
	/// depending on the particular instance variable settings. It is assumed that
	/// the axes is part of a bounding box and is orthogonal to one of the
	/// coordinate axes.  To use this class, you typically specify two points
	/// defining the start and end points of the line (xyz definition using
	/// vtkCoordinate class), the axis type (X, Y or Z), the axis location in
	/// relation to the bounding box, the bounding box, the number of labels, and
	/// the data range (min,max). You can also control what parts of the axis are
	/// visible including the line, the tick marks, the labels, and the title. It
	/// is also possible to control gridlines, and specify on which 'side' the
	/// tickmarks are drawn (again with respect to the underlying assumed
	/// bounding box). You can also specify the label format (a printf style format).
	///
	/// This class decides how to locate the labels, and how to create reasonable
	/// tick marks and labels.
	///
	/// Labels follow the camera so as to be legible from any viewpoint.
	///
	/// The instance variables Point1 and Point2 are instances of vtkCoordinate.
	/// All calculations and references are in World Coordinates.
	///
	/// @par Thanks:
	/// This class was written by:
	/// Hank Childs, Kathleen Bonnell, Amy Squillacote, Brad Whitlock,
	/// Eric Brugger, Claire Guilbaud, Nicolas Dolegieviez, Will Schroeder,
	/// Karthik Krishnan, Aashish Chaudhary, Philippe Pebay, David Gobbi,
	/// David Partyka, Utkarsh Ayachit David Cole, Francois Bertel, and Mark Olesen
	/// Part of this work was supported by CEA/DIF - Commissariat a l'Energie Atomique,
	/// Centre DAM Ile-De-France, BP12, F-91297 Arpajon, France.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkActor vtkVectorText vtkPolyDataMapper vtkAxisActor2D vtkCoordinate
	/// </seealso>
	// Token: 0x020003B5 RID: 949
	public class vtkAxisActor : vtkActor
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600AD9C RID: 44444 RVA: 0x000F655F File Offset: 0x000F475F
		static vtkAxisActor()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAxisActor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAxisActor"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600AD9D RID: 44445 RVA: 0x000F6587 File Offset: 0x000F4787
		public vtkAxisActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600AD9E RID: 44446
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxisActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate object.
		/// </summary>
		// Token: 0x0600AD9F RID: 44447 RVA: 0x000F6598 File Offset: 0x000F4798
		public new static vtkAxisActor New()
		{
			vtkAxisActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxisActor.vtkAxisActor_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAxisActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate object.
		/// </summary>
		// Token: 0x0600ADA0 RID: 44448 RVA: 0x000F65EC File Offset: 0x000F47EC
		public vtkAxisActor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAxisActor.vtkAxisActor_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600ADA1 RID: 44449 RVA: 0x000F6630 File Offset: 0x000F4830
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600ADA2 RID: 44450
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_AxisVisibilityOff_01(HandleRef pThis);

		/// <summary>
		/// Set/Get visibility of the axis line.
		/// Default: true.
		/// </summary>
		// Token: 0x0600ADA3 RID: 44451 RVA: 0x000F663B File Offset: 0x000F483B
		public virtual void AxisVisibilityOff()
		{
			vtkAxisActor.vtkAxisActor_AxisVisibilityOff_01(base.GetCppThis());
		}

		// Token: 0x0600ADA4 RID: 44452
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_AxisVisibilityOn_02(HandleRef pThis);

		/// <summary>
		/// Set/Get visibility of the axis line.
		/// Default: true.
		/// </summary>
		// Token: 0x0600ADA5 RID: 44453 RVA: 0x000F664A File Offset: 0x000F484A
		public virtual void AxisVisibilityOn()
		{
			vtkAxisActor.vtkAxisActor_AxisVisibilityOn_02(base.GetCppThis());
		}

		// Token: 0x0600ADA6 RID: 44454
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_BuildAxis_03(HandleRef pThis, HandleRef viewport, byte arg1);

		/// <summary>
		/// Set/Get the delta range for minor and major tick points that determine their spacing.
		/// Default: 1.0.
		/// </summary>
		// Token: 0x0600ADA7 RID: 44455 RVA: 0x000F665C File Offset: 0x000F485C
		public void BuildAxis(vtkViewport viewport, bool arg1)
		{
			vtkAxisActor.vtkAxisActor_BuildAxis_03(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis(), arg1 ? (byte)1 : (byte)0);
		}

		// Token: 0x0600ADA8 RID: 44456
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_CalculateLabelOffsetOff_04(HandleRef pThis);

		/// <summary>
		/// Set/Get flag whether to calculate label offset.
		/// Default: false.
		/// </summary>
		// Token: 0x0600ADA9 RID: 44457 RVA: 0x000F6694 File Offset: 0x000F4894
		public virtual void CalculateLabelOffsetOff()
		{
			vtkAxisActor.vtkAxisActor_CalculateLabelOffsetOff_04(base.GetCppThis());
		}

		// Token: 0x0600ADAA RID: 44458
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_CalculateLabelOffsetOn_05(HandleRef pThis);

		/// <summary>
		/// Set/Get flag whether to calculate label offset.
		/// Default: false.
		/// </summary>
		// Token: 0x0600ADAB RID: 44459 RVA: 0x000F66A3 File Offset: 0x000F48A3
		public virtual void CalculateLabelOffsetOn()
		{
			vtkAxisActor.vtkAxisActor_CalculateLabelOffsetOn_05(base.GetCppThis());
		}

		// Token: 0x0600ADAC RID: 44460
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_CalculateTitleOffsetOff_06(HandleRef pThis);

		/// <summary>
		/// Set/Get flag whether to calculate title offset.
		/// Default: false.
		/// </summary>
		// Token: 0x0600ADAD RID: 44461 RVA: 0x000F66B2 File Offset: 0x000F48B2
		public virtual void CalculateTitleOffsetOff()
		{
			vtkAxisActor.vtkAxisActor_CalculateTitleOffsetOff_06(base.GetCppThis());
		}

		// Token: 0x0600ADAE RID: 44462
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_CalculateTitleOffsetOn_07(HandleRef pThis);

		/// <summary>
		/// Set/Get flag whether to calculate title offset.
		/// Default: false.
		/// </summary>
		// Token: 0x0600ADAF RID: 44463 RVA: 0x000F66C1 File Offset: 0x000F48C1
		public virtual void CalculateTitleOffsetOn()
		{
			vtkAxisActor.vtkAxisActor_CalculateTitleOffsetOn_07(base.GetCppThis());
		}

		// Token: 0x0600ADB0 RID: 44464
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxisActor_ComputeMaxLabelLength_08(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// Release any graphics resources that are being consumed by this actor.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x0600ADB1 RID: 44465 RVA: 0x000F66D0 File Offset: 0x000F48D0
		public double ComputeMaxLabelLength(IntPtr arg0)
		{
			return vtkAxisActor.vtkAxisActor_ComputeMaxLabelLength_08(base.GetCppThis(), arg0);
		}

		// Token: 0x0600ADB2 RID: 44466
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxisActor_ComputeTitleLength_09(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// Release any graphics resources that are being consumed by this actor.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x0600ADB3 RID: 44467 RVA: 0x000F66F0 File Offset: 0x000F48F0
		public double ComputeTitleLength(IntPtr arg0)
		{
			return vtkAxisActor.vtkAxisActor_ComputeTitleLength_09(base.GetCppThis(), arg0);
		}

		// Token: 0x0600ADB4 RID: 44468
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_DrawGridlinesOff_10(HandleRef pThis);

		/// <summary>
		/// Set/Get whether gridlines should be drawn.
		/// Default: false.
		/// </summary>
		// Token: 0x0600ADB5 RID: 44469 RVA: 0x000F6710 File Offset: 0x000F4910
		public virtual void DrawGridlinesOff()
		{
			vtkAxisActor.vtkAxisActor_DrawGridlinesOff_10(base.GetCppThis());
		}

		// Token: 0x0600ADB6 RID: 44470
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_DrawGridlinesOn_11(HandleRef pThis);

		/// <summary>
		/// Set/Get whether gridlines should be drawn.
		/// Default: false.
		/// </summary>
		// Token: 0x0600ADB7 RID: 44471 RVA: 0x000F671F File Offset: 0x000F491F
		public virtual void DrawGridlinesOn()
		{
			vtkAxisActor.vtkAxisActor_DrawGridlinesOn_11(base.GetCppThis());
		}

		// Token: 0x0600ADB8 RID: 44472
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_DrawGridlinesOnlyOff_12(HandleRef pThis);

		/// <summary>
		/// Set/Get whether ONLY the gridlines should be drawn.
		/// This will only draw GridLines and will skip any other part of the rendering
		/// such as Axis/Tick/Title/...
		/// Default: false.
		/// </summary>
		// Token: 0x0600ADB9 RID: 44473 RVA: 0x000F672E File Offset: 0x000F492E
		public virtual void DrawGridlinesOnlyOff()
		{
			vtkAxisActor.vtkAxisActor_DrawGridlinesOnlyOff_12(base.GetCppThis());
		}

		// Token: 0x0600ADBA RID: 44474
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_DrawGridlinesOnlyOn_13(HandleRef pThis);

		/// <summary>
		/// Set/Get whether ONLY the gridlines should be drawn.
		/// This will only draw GridLines and will skip any other part of the rendering
		/// such as Axis/Tick/Title/...
		/// Default: false.
		/// </summary>
		// Token: 0x0600ADBB RID: 44475 RVA: 0x000F673D File Offset: 0x000F493D
		public virtual void DrawGridlinesOnlyOn()
		{
			vtkAxisActor.vtkAxisActor_DrawGridlinesOnlyOn_13(base.GetCppThis());
		}

		// Token: 0x0600ADBC RID: 44476
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_DrawGridpolysOff_14(HandleRef pThis);

		/// <summary>
		/// Set/Get whether gridpolys should be drawn.
		/// Default: false.
		/// </summary>
		// Token: 0x0600ADBD RID: 44477 RVA: 0x000F674C File Offset: 0x000F494C
		public virtual void DrawGridpolysOff()
		{
			vtkAxisActor.vtkAxisActor_DrawGridpolysOff_14(base.GetCppThis());
		}

		// Token: 0x0600ADBE RID: 44478
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_DrawGridpolysOn_15(HandleRef pThis);

		/// <summary>
		/// Set/Get whether gridpolys should be drawn.
		/// Default: false.
		/// </summary>
		// Token: 0x0600ADBF RID: 44479 RVA: 0x000F675B File Offset: 0x000F495B
		public virtual void DrawGridpolysOn()
		{
			vtkAxisActor.vtkAxisActor_DrawGridpolysOn_15(base.GetCppThis());
		}

		// Token: 0x0600ADC0 RID: 44480
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_DrawInnerGridlinesOff_16(HandleRef pThis);

		/// <summary>
		/// Set/Get whether inner gridlines should be drawn.
		/// Default: false.
		/// </summary>
		// Token: 0x0600ADC1 RID: 44481 RVA: 0x000F676A File Offset: 0x000F496A
		public virtual void DrawInnerGridlinesOff()
		{
			vtkAxisActor.vtkAxisActor_DrawInnerGridlinesOff_16(base.GetCppThis());
		}

		// Token: 0x0600ADC2 RID: 44482
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_DrawInnerGridlinesOn_17(HandleRef pThis);

		/// <summary>
		/// Set/Get whether inner gridlines should be drawn.
		/// Default: false.
		/// </summary>
		// Token: 0x0600ADC3 RID: 44483 RVA: 0x000F6779 File Offset: 0x000F4979
		public virtual void DrawInnerGridlinesOn()
		{
			vtkAxisActor.vtkAxisActor_DrawInnerGridlinesOn_17(base.GetCppThis());
		}

		// Token: 0x0600ADC4 RID: 44484
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_ExponentVisibilityOff_18(HandleRef pThis);

		/// <summary>
		/// Set/Get visibility of the axis detached exponent.
		/// Default: false.
		/// </summary>
		// Token: 0x0600ADC5 RID: 44485 RVA: 0x000F6788 File Offset: 0x000F4988
		public virtual void ExponentVisibilityOff()
		{
			vtkAxisActor.vtkAxisActor_ExponentVisibilityOff_18(base.GetCppThis());
		}

		// Token: 0x0600ADC6 RID: 44486
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_ExponentVisibilityOn_19(HandleRef pThis);

		/// <summary>
		/// Set/Get visibility of the axis detached exponent.
		/// Default: false.
		/// </summary>
		// Token: 0x0600ADC7 RID: 44487 RVA: 0x000F6797 File Offset: 0x000F4997
		public virtual void ExponentVisibilityOn()
		{
			vtkAxisActor.vtkAxisActor_ExponentVisibilityOn_19(base.GetCppThis());
		}

		// Token: 0x0600ADC8 RID: 44488
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxisActor_GetAxisBaseForX_20(HandleRef pThis);

		/// <summary>
		/// Provide real vector for non aligned axis.
		/// Default: (1.0, 0.0, 0.0).
		/// </summary>
		// Token: 0x0600ADC9 RID: 44489 RVA: 0x000F67A8 File Offset: 0x000F49A8
		public virtual double[] GetAxisBaseForX()
		{
			IntPtr intPtr = vtkAxisActor.vtkAxisActor_GetAxisBaseForX_20(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600ADCA RID: 44490
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_GetAxisBaseForX_21(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Provide real vector for non aligned axis.
		/// Default: (1.0, 0.0, 0.0).
		/// </summary>
		// Token: 0x0600ADCB RID: 44491 RVA: 0x000F67F0 File Offset: 0x000F49F0
		public virtual void GetAxisBaseForX(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkAxisActor.vtkAxisActor_GetAxisBaseForX_21(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600ADCC RID: 44492
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_GetAxisBaseForX_22(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Provide real vector for non aligned axis.
		/// Default: (1.0, 0.0, 0.0).
		/// </summary>
		// Token: 0x0600ADCD RID: 44493 RVA: 0x000F6802 File Offset: 0x000F4A02
		public virtual void GetAxisBaseForX(IntPtr _arg)
		{
			vtkAxisActor.vtkAxisActor_GetAxisBaseForX_22(base.GetCppThis(), _arg);
		}

		// Token: 0x0600ADCE RID: 44494
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxisActor_GetAxisBaseForY_23(HandleRef pThis);

		/// <summary>
		/// Provide real vector for non aligned axis.
		/// Default: (0.0, 1.0, 0.0).
		/// </summary>
		// Token: 0x0600ADCF RID: 44495 RVA: 0x000F6814 File Offset: 0x000F4A14
		public virtual double[] GetAxisBaseForY()
		{
			IntPtr intPtr = vtkAxisActor.vtkAxisActor_GetAxisBaseForY_23(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600ADD0 RID: 44496
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_GetAxisBaseForY_24(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Provide real vector for non aligned axis.
		/// Default: (0.0, 1.0, 0.0).
		/// </summary>
		// Token: 0x0600ADD1 RID: 44497 RVA: 0x000F685C File Offset: 0x000F4A5C
		public virtual void GetAxisBaseForY(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkAxisActor.vtkAxisActor_GetAxisBaseForY_24(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600ADD2 RID: 44498
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_GetAxisBaseForY_25(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Provide real vector for non aligned axis.
		/// Default: (0.0, 1.0, 0.0).
		/// </summary>
		// Token: 0x0600ADD3 RID: 44499 RVA: 0x000F686E File Offset: 0x000F4A6E
		public virtual void GetAxisBaseForY(IntPtr _arg)
		{
			vtkAxisActor.vtkAxisActor_GetAxisBaseForY_25(base.GetCppThis(), _arg);
		}

		// Token: 0x0600ADD4 RID: 44500
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxisActor_GetAxisBaseForZ_26(HandleRef pThis);

		/// <summary>
		/// Provide real vector for non aligned axis.
		/// Default: (0.0, 0.0, 1.0).
		/// </summary>
		// Token: 0x0600ADD5 RID: 44501 RVA: 0x000F6880 File Offset: 0x000F4A80
		public virtual double[] GetAxisBaseForZ()
		{
			IntPtr intPtr = vtkAxisActor.vtkAxisActor_GetAxisBaseForZ_26(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600ADD6 RID: 44502
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_GetAxisBaseForZ_27(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Provide real vector for non aligned axis.
		/// Default: (0.0, 0.0, 1.0).
		/// </summary>
		// Token: 0x0600ADD7 RID: 44503 RVA: 0x000F68C8 File Offset: 0x000F4AC8
		public virtual void GetAxisBaseForZ(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkAxisActor.vtkAxisActor_GetAxisBaseForZ_27(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600ADD8 RID: 44504
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_GetAxisBaseForZ_28(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Provide real vector for non aligned axis.
		/// Default: (0.0, 0.0, 1.0).
		/// </summary>
		// Token: 0x0600ADD9 RID: 44505 RVA: 0x000F68DA File Offset: 0x000F4ADA
		public virtual void GetAxisBaseForZ(IntPtr _arg)
		{
			vtkAxisActor.vtkAxisActor_GetAxisBaseForZ_28(base.GetCppThis(), _arg);
		}

		// Token: 0x0600ADDA RID: 44506
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxisActor_GetAxisLinesProperty_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set axis actor property (axis and its ticks) (kept for compatibility)
		/// </summary>
		// Token: 0x0600ADDB RID: 44507 RVA: 0x000F68EC File Offset: 0x000F4AEC
		public vtkProperty GetAxisLinesProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxisActor.vtkAxisActor_GetAxisLinesProperty_29(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600ADDC RID: 44508
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxisActor_GetAxisMainLineProperty_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set main line axis actor property
		/// </summary>
		// Token: 0x0600ADDD RID: 44509 RVA: 0x000F695C File Offset: 0x000F4B5C
		public vtkProperty GetAxisMainLineProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxisActor.vtkAxisActor_GetAxisMainLineProperty_30(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600ADDE RID: 44510
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxisActor_GetAxisMajorTicksProperty_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set axis actor property (axis and its ticks)
		/// </summary>
		// Token: 0x0600ADDF RID: 44511 RVA: 0x000F69CC File Offset: 0x000F4BCC
		public vtkProperty GetAxisMajorTicksProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxisActor.vtkAxisActor_GetAxisMajorTicksProperty_31(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600ADE0 RID: 44512
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxisActor_GetAxisMinorTicksProperty_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set axis actor property (axis and its ticks)
		/// </summary>
		// Token: 0x0600ADE1 RID: 44513 RVA: 0x000F6A3C File Offset: 0x000F4C3C
		public vtkProperty GetAxisMinorTicksProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxisActor.vtkAxisActor_GetAxisMinorTicksProperty_32(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600ADE2 RID: 44514
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAxisActor_GetAxisOnOrigin_33(HandleRef pThis);

		/// <summary>
		/// Notify the axes that is not part of a cube anymore.
		/// Default: false.
		/// </summary>
		// Token: 0x0600ADE3 RID: 44515 RVA: 0x000F6AAC File Offset: 0x000F4CAC
		public virtual bool GetAxisOnOrigin()
		{
			return vtkAxisActor.vtkAxisActor_GetAxisOnOrigin_33(base.GetCppThis()) != 0;
		}

		// Token: 0x0600ADE4 RID: 44516
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisActor_GetAxisPosition_34(HandleRef pThis);

		/// <summary>
		/// Set/Get the position of this axis (in relation to an an
		/// assumed bounding box).  For an x-type axis, MINMIN corresponds
		/// to the x-edge in the bounding box where Y values are minimum and
		/// Z values are minimum. For a y-type axis, MAXMIN corresponds to the
		/// y-edge where X values are maximum and Z values are minimum.
		/// Default: VTK_AXIS_POS_MINMIN.
		/// </summary>
		// Token: 0x0600ADE5 RID: 44517 RVA: 0x000F6AD4 File Offset: 0x000F4CD4
		public virtual int GetAxisPosition()
		{
			return vtkAxisActor.vtkAxisActor_GetAxisPosition_34(base.GetCppThis());
		}

		// Token: 0x0600ADE6 RID: 44518
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisActor_GetAxisPositionMaxValue_35(HandleRef pThis);

		/// <summary>
		/// Set/Get the position of this axis (in relation to an an
		/// assumed bounding box).  For an x-type axis, MINMIN corresponds
		/// to the x-edge in the bounding box where Y values are minimum and
		/// Z values are minimum. For a y-type axis, MAXMIN corresponds to the
		/// y-edge where X values are maximum and Z values are minimum.
		/// Default: VTK_AXIS_POS_MINMIN.
		/// </summary>
		// Token: 0x0600ADE7 RID: 44519 RVA: 0x000F6AF4 File Offset: 0x000F4CF4
		public virtual int GetAxisPositionMaxValue()
		{
			return vtkAxisActor.vtkAxisActor_GetAxisPositionMaxValue_35(base.GetCppThis());
		}

		// Token: 0x0600ADE8 RID: 44520
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisActor_GetAxisPositionMinValue_36(HandleRef pThis);

		/// <summary>
		/// Set/Get the position of this axis (in relation to an an
		/// assumed bounding box).  For an x-type axis, MINMIN corresponds
		/// to the x-edge in the bounding box where Y values are minimum and
		/// Z values are minimum. For a y-type axis, MAXMIN corresponds to the
		/// y-edge where X values are maximum and Z values are minimum.
		/// Default: VTK_AXIS_POS_MINMIN.
		/// </summary>
		// Token: 0x0600ADE9 RID: 44521 RVA: 0x000F6B14 File Offset: 0x000F4D14
		public virtual int GetAxisPositionMinValue()
		{
			return vtkAxisActor.vtkAxisActor_GetAxisPositionMinValue_36(base.GetCppThis());
		}

		// Token: 0x0600ADEA RID: 44522
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisActor_GetAxisType_37(HandleRef pThis);

		/// <summary>
		/// Set/Get the type of this axis.
		/// Default: VTK_AXIS_TYPE_X.
		/// </summary>
		// Token: 0x0600ADEB RID: 44523 RVA: 0x000F6B34 File Offset: 0x000F4D34
		public virtual int GetAxisType()
		{
			return vtkAxisActor.vtkAxisActor_GetAxisType_37(base.GetCppThis());
		}

		// Token: 0x0600ADEC RID: 44524
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisActor_GetAxisTypeMaxValue_38(HandleRef pThis);

		/// <summary>
		/// Set/Get the type of this axis.
		/// Default: VTK_AXIS_TYPE_X.
		/// </summary>
		// Token: 0x0600ADED RID: 44525 RVA: 0x000F6B54 File Offset: 0x000F4D54
		public virtual int GetAxisTypeMaxValue()
		{
			return vtkAxisActor.vtkAxisActor_GetAxisTypeMaxValue_38(base.GetCppThis());
		}

		// Token: 0x0600ADEE RID: 44526
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisActor_GetAxisTypeMinValue_39(HandleRef pThis);

		/// <summary>
		/// Set/Get the type of this axis.
		/// Default: VTK_AXIS_TYPE_X.
		/// </summary>
		// Token: 0x0600ADEF RID: 44527 RVA: 0x000F6B74 File Offset: 0x000F4D74
		public virtual int GetAxisTypeMinValue()
		{
			return vtkAxisActor.vtkAxisActor_GetAxisTypeMinValue_39(base.GetCppThis());
		}

		// Token: 0x0600ADF0 RID: 44528
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAxisActor_GetAxisVisibility_40(HandleRef pThis);

		/// <summary>
		/// Set/Get visibility of the axis line.
		/// Default: true.
		/// </summary>
		// Token: 0x0600ADF1 RID: 44529 RVA: 0x000F6B94 File Offset: 0x000F4D94
		public virtual bool GetAxisVisibility()
		{
			return vtkAxisActor.vtkAxisActor_GetAxisVisibility_40(base.GetCppThis()) != 0;
		}

		// Token: 0x0600ADF2 RID: 44530
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxisActor_GetBounds_41(HandleRef pThis);

		/// <summary>
		/// Set or get the bounds for this Actor as (Xmin,Xmax,Ymin,Ymax,Zmin,Zmax).
		/// Default: (-1, 1, -1, 1, -1, 1).
		/// </summary>
		// Token: 0x0600ADF3 RID: 44531 RVA: 0x000F6BBC File Offset: 0x000F4DBC
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkAxisActor.vtkAxisActor_GetBounds_41(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600ADF4 RID: 44532
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_GetBounds_42(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Set or get the bounds for this Actor as (Xmin,Xmax,Ymin,Ymax,Zmin,Zmax).
		/// Default: (-1, 1, -1, 1, -1, 1).
		/// </summary>
		// Token: 0x0600ADF5 RID: 44533 RVA: 0x000F6C04 File Offset: 0x000F4E04
		public new void GetBounds(IntPtr bounds)
		{
			vtkAxisActor.vtkAxisActor_GetBounds_42(base.GetCppThis(), bounds);
		}

		// Token: 0x0600ADF6 RID: 44534
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAxisActor_GetCalculateLabelOffset_43(HandleRef pThis);

		/// <summary>
		/// Set/Get flag whether to calculate label offset.
		/// Default: false.
		/// </summary>
		// Token: 0x0600ADF7 RID: 44535 RVA: 0x000F6C14 File Offset: 0x000F4E14
		public virtual bool GetCalculateLabelOffset()
		{
			return vtkAxisActor.vtkAxisActor_GetCalculateLabelOffset_43(base.GetCppThis()) != 0;
		}

		// Token: 0x0600ADF8 RID: 44536
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAxisActor_GetCalculateTitleOffset_44(HandleRef pThis);

		/// <summary>
		/// Set/Get flag whether to calculate title offset.
		/// Default: false.
		/// </summary>
		// Token: 0x0600ADF9 RID: 44537 RVA: 0x000F6C3C File Offset: 0x000F4E3C
		public virtual bool GetCalculateTitleOffset()
		{
			return vtkAxisActor.vtkAxisActor_GetCalculateTitleOffset_44(base.GetCppThis()) != 0;
		}

		// Token: 0x0600ADFA RID: 44538
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxisActor_GetCamera_45(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the camera for this axis.  The camera is used by the
		/// labels to 'follow' the camera and be legible from any viewpoint.
		/// </summary>
		// Token: 0x0600ADFB RID: 44539 RVA: 0x000F6C64 File Offset: 0x000F4E64
		public vtkCamera GetCamera()
		{
			vtkCamera vtkCamera = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxisActor.vtkAxisActor_GetCamera_45(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCamera = (vtkCamera)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCamera.Register(null);
				}
			}
			return vtkCamera;
		}

		// Token: 0x0600ADFC RID: 44540
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxisActor_GetDeltaMajor_46(HandleRef pThis, int axis);

		/// <summary>
		/// Set/Get the starting position for minor and major tick points,
		/// and the delta values that determine their spacing.
		/// </summary>
		// Token: 0x0600ADFD RID: 44541 RVA: 0x000F6CD4 File Offset: 0x000F4ED4
		public double GetDeltaMajor(int axis)
		{
			return vtkAxisActor.vtkAxisActor_GetDeltaMajor_46(base.GetCppThis(), axis);
		}

		// Token: 0x0600ADFE RID: 44542
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxisActor_GetDeltaMinor_47(HandleRef pThis);

		/// <summary>
		/// Set/Get the starting position for minor and major tick points,
		/// and the delta values that determine their spacing.
		/// </summary>
		// Token: 0x0600ADFF RID: 44543 RVA: 0x000F6CF4 File Offset: 0x000F4EF4
		public virtual double GetDeltaMinor()
		{
			return vtkAxisActor.vtkAxisActor_GetDeltaMinor_47(base.GetCppThis());
		}

		// Token: 0x0600AE00 RID: 44544
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxisActor_GetDeltaRangeMajor_48(HandleRef pThis);

		/// <summary>
		/// Set/Get the delta range for minor and major tick points that determine their spacing.
		/// Default: 1.0.
		/// </summary>
		// Token: 0x0600AE01 RID: 44545 RVA: 0x000F6D14 File Offset: 0x000F4F14
		public virtual double GetDeltaRangeMajor()
		{
			return vtkAxisActor.vtkAxisActor_GetDeltaRangeMajor_48(base.GetCppThis());
		}

		// Token: 0x0600AE02 RID: 44546
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxisActor_GetDeltaRangeMinor_49(HandleRef pThis);

		/// <summary>
		/// Set/Get the delta range for minor and major tick points that determine their spacing.
		/// Default: 1.0.
		/// </summary>
		// Token: 0x0600AE03 RID: 44547 RVA: 0x000F6D34 File Offset: 0x000F4F34
		public virtual double GetDeltaRangeMinor()
		{
			return vtkAxisActor.vtkAxisActor_GetDeltaRangeMinor_49(base.GetCppThis());
		}

		// Token: 0x0600AE04 RID: 44548
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAxisActor_GetDrawGridlines_50(HandleRef pThis);

		/// <summary>
		/// Set/Get whether gridlines should be drawn.
		/// Default: false.
		/// </summary>
		// Token: 0x0600AE05 RID: 44549 RVA: 0x000F6D54 File Offset: 0x000F4F54
		public virtual bool GetDrawGridlines()
		{
			return vtkAxisActor.vtkAxisActor_GetDrawGridlines_50(base.GetCppThis()) != 0;
		}

		// Token: 0x0600AE06 RID: 44550
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisActor_GetDrawGridlinesLocation_51(HandleRef pThis);

		/// <summary>
		/// Set/Get whether ONLY the gridlines should be drawn.
		/// This will only draw GridLines and will skip any other part of the rendering
		/// such as Axis/Tick/Title/...
		/// Default: false.
		/// </summary>
		// Token: 0x0600AE07 RID: 44551 RVA: 0x000F6D7C File Offset: 0x000F4F7C
		public virtual int GetDrawGridlinesLocation()
		{
			return vtkAxisActor.vtkAxisActor_GetDrawGridlinesLocation_51(base.GetCppThis());
		}

		// Token: 0x0600AE08 RID: 44552
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAxisActor_GetDrawGridlinesOnly_52(HandleRef pThis);

		/// <summary>
		/// Set/Get whether ONLY the gridlines should be drawn.
		/// This will only draw GridLines and will skip any other part of the rendering
		/// such as Axis/Tick/Title/...
		/// Default: false.
		/// </summary>
		// Token: 0x0600AE09 RID: 44553 RVA: 0x000F6D9C File Offset: 0x000F4F9C
		public virtual bool GetDrawGridlinesOnly()
		{
			return vtkAxisActor.vtkAxisActor_GetDrawGridlinesOnly_52(base.GetCppThis()) != 0;
		}

		// Token: 0x0600AE0A RID: 44554
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAxisActor_GetDrawGridpolys_53(HandleRef pThis);

		/// <summary>
		/// Set/Get whether gridpolys should be drawn.
		/// Default: false.
		/// </summary>
		// Token: 0x0600AE0B RID: 44555 RVA: 0x000F6DC4 File Offset: 0x000F4FC4
		public virtual bool GetDrawGridpolys()
		{
			return vtkAxisActor.vtkAxisActor_GetDrawGridpolys_53(base.GetCppThis()) != 0;
		}

		// Token: 0x0600AE0C RID: 44556
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAxisActor_GetDrawInnerGridlines_54(HandleRef pThis);

		/// <summary>
		/// Set/Get whether inner gridlines should be drawn.
		/// Default: false.
		/// </summary>
		// Token: 0x0600AE0D RID: 44557 RVA: 0x000F6DEC File Offset: 0x000F4FEC
		public virtual bool GetDrawInnerGridlines()
		{
			return vtkAxisActor.vtkAxisActor_GetDrawInnerGridlines_54(base.GetCppThis()) != 0;
		}

		// Token: 0x0600AE0E RID: 44558
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxisActor_GetExponent_55(HandleRef pThis);

		/// <summary>
		/// Set/Get the common exponent of the labels values.
		/// </summary>
		// Token: 0x0600AE0F RID: 44559 RVA: 0x000F6E14 File Offset: 0x000F5014
		public virtual string GetExponent()
		{
			string s = Marshal.PtrToStringAnsi(vtkAxisActor.vtkAxisActor_GetExponent_55(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600AE10 RID: 44560
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxisActor_GetExponentActor_56(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get exponent follower actor
		/// </summary>
		// Token: 0x0600AE11 RID: 44561 RVA: 0x000F6E50 File Offset: 0x000F5050
		public virtual vtkAxisFollower GetExponentActor()
		{
			vtkAxisFollower vtkAxisFollower = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxisActor.vtkAxisActor_GetExponentActor_56(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAxisFollower = (vtkAxisFollower)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAxisFollower.Register(null);
				}
			}
			return vtkAxisFollower;
		}

		// Token: 0x0600AE12 RID: 44562
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisActor_GetExponentLocation_57(HandleRef pThis);

		/// <summary>
		/// Get/Set the location of the Detached Exponent related to the axis.
		/// Possible Location: VTK_ALIGN_TOP, VTK_ALIGN_BOTTOM, VTK_ALIGN_POINT1, VTK_ALIGN_POINT2.
		/// Default: VTK_ALIGN_POINT2.
		/// </summary>
		// Token: 0x0600AE13 RID: 44563 RVA: 0x000F6EC0 File Offset: 0x000F50C0
		public virtual int GetExponentLocation()
		{
			return vtkAxisActor.vtkAxisActor_GetExponentLocation_57(base.GetCppThis());
		}

		// Token: 0x0600AE14 RID: 44564
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxisActor_GetExponentOffset_58(HandleRef pThis);

		/// <summary>
		/// Set/Get the Y-offset used to position exponent.
		/// Default: 20.0.
		/// </summary>
		// Token: 0x0600AE15 RID: 44565 RVA: 0x000F6EE0 File Offset: 0x000F50E0
		public virtual double GetExponentOffset()
		{
			return vtkAxisActor.vtkAxisActor_GetExponentOffset_58(base.GetCppThis());
		}

		// Token: 0x0600AE16 RID: 44566
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxisActor_GetExponentProp3D_59(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get title actor and it is responsible for drawing
		/// title text.
		/// </summary>
		// Token: 0x0600AE17 RID: 44567 RVA: 0x000F6F00 File Offset: 0x000F5100
		public virtual vtkProp3DAxisFollower GetExponentProp3D()
		{
			vtkProp3DAxisFollower vtkProp3DAxisFollower = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxisActor.vtkAxisActor_GetExponentProp3D_59(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProp3DAxisFollower = (vtkProp3DAxisFollower)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProp3DAxisFollower.Register(null);
				}
			}
			return vtkProp3DAxisFollower;
		}

		// Token: 0x0600AE18 RID: 44568
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAxisActor_GetExponentVisibility_60(HandleRef pThis);

		/// <summary>
		/// Set/Get visibility of the axis detached exponent.
		/// Default: false.
		/// </summary>
		// Token: 0x0600AE19 RID: 44569 RVA: 0x000F6F70 File Offset: 0x000F5170
		public virtual bool GetExponentVisibility()
		{
			return vtkAxisActor.vtkAxisActor_GetExponentVisibility_60(base.GetCppThis()) != 0;
		}

		// Token: 0x0600AE1A RID: 44570
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxisActor_GetGridlineXLength_61(HandleRef pThis);

		/// <summary>
		/// Set/Get the length to use when drawing gridlines.
		/// Default: 1.0.
		/// </summary>
		// Token: 0x0600AE1B RID: 44571 RVA: 0x000F6F98 File Offset: 0x000F5198
		public virtual double GetGridlineXLength()
		{
			return vtkAxisActor.vtkAxisActor_GetGridlineXLength_61(base.GetCppThis());
		}

		// Token: 0x0600AE1C RID: 44572
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxisActor_GetGridlineYLength_62(HandleRef pThis);

		/// <summary>
		/// Set/Get the length to use when drawing gridlines.
		/// Default: 1.0.
		/// </summary>
		// Token: 0x0600AE1D RID: 44573 RVA: 0x000F6FB8 File Offset: 0x000F51B8
		public virtual double GetGridlineYLength()
		{
			return vtkAxisActor.vtkAxisActor_GetGridlineYLength_62(base.GetCppThis());
		}

		// Token: 0x0600AE1E RID: 44574
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxisActor_GetGridlineZLength_63(HandleRef pThis);

		/// <summary>
		/// Set/Get the length to use when drawing gridlines.
		/// Default: 1.0.
		/// </summary>
		// Token: 0x0600AE1F RID: 44575 RVA: 0x000F6FD8 File Offset: 0x000F51D8
		public virtual double GetGridlineZLength()
		{
			return vtkAxisActor.vtkAxisActor_GetGridlineZLength_63(base.GetCppThis());
		}

		// Token: 0x0600AE20 RID: 44576
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxisActor_GetGridlinesProperty_64(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set gridlines actor property (outer grid lines)
		/// </summary>
		// Token: 0x0600AE21 RID: 44577 RVA: 0x000F6FF8 File Offset: 0x000F51F8
		public vtkProperty GetGridlinesProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxisActor.vtkAxisActor_GetGridlinesProperty_64(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600AE22 RID: 44578
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxisActor_GetGridpolysProperty_65(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set gridPolys actor property (grid quads)
		/// </summary>
		// Token: 0x0600AE23 RID: 44579 RVA: 0x000F7068 File Offset: 0x000F5268
		public vtkProperty GetGridpolysProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxisActor.vtkAxisActor_GetGridpolysProperty_65(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600AE24 RID: 44580
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxisActor_GetHorizontalOffsetYTitle2D_66(HandleRef pThis);

		/// <summary>
		/// Set/Get the 2D mode the horizontal offset for Y title in 2D mode.
		/// Default: -50.0.
		/// </summary>
		// Token: 0x0600AE25 RID: 44581 RVA: 0x000F70D8 File Offset: 0x000F52D8
		public virtual double GetHorizontalOffsetYTitle2D()
		{
			return vtkAxisActor.vtkAxisActor_GetHorizontalOffsetYTitle2D_66(base.GetCppThis());
		}

		// Token: 0x0600AE26 RID: 44582
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxisActor_GetInnerGridlinesProperty_67(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set inner gridlines actor property
		/// </summary>
		// Token: 0x0600AE27 RID: 44583 RVA: 0x000F70F8 File Offset: 0x000F52F8
		public vtkProperty GetInnerGridlinesProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxisActor.vtkAxisActor_GetInnerGridlinesProperty_67(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600AE28 RID: 44584
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxisActor_GetLabelFormat_68(HandleRef pThis);

		/// <summary>
		/// Set/Get the format with which to print the labels on the axis.
		/// </summary>
		// Token: 0x0600AE29 RID: 44585 RVA: 0x000F7168 File Offset: 0x000F5368
		public virtual string GetLabelFormat()
		{
			string s = Marshal.PtrToStringAnsi(vtkAxisActor.vtkAxisActor_GetLabelFormat_68(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600AE2A RID: 44586
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxisActor_GetLabelOffset_69(HandleRef pThis);

		/// <summary>
		/// Set/Get the Y-offset used to position label.
		/// Default: 30.0.
		/// </summary>
		// Token: 0x0600AE2B RID: 44587 RVA: 0x000F71A4 File Offset: 0x000F53A4
		public virtual double GetLabelOffset()
		{
			return vtkAxisActor.vtkAxisActor_GetLabelOffset_69(base.GetCppThis());
		}

		// Token: 0x0600AE2C RID: 44588
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxisActor_GetLabelTextProperty_70(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the axis labels text property.
		/// </summary>
		// Token: 0x0600AE2D RID: 44589 RVA: 0x000F71C4 File Offset: 0x000F53C4
		public vtkTextProperty GetLabelTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxisActor.vtkAxisActor_GetLabelTextProperty_70(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600AE2E RID: 44590
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAxisActor_GetLabelVisibility_71(HandleRef pThis);

		/// <summary>
		/// Set/Get visibility of the axis labels.
		/// Default: true.
		/// </summary>
		// Token: 0x0600AE2F RID: 44591 RVA: 0x000F7234 File Offset: 0x000F5434
		public virtual bool GetLabelVisibility()
		{
			return vtkAxisActor.vtkAxisActor_GetLabelVisibility_71(base.GetCppThis()) != 0;
		}

		// Token: 0x0600AE30 RID: 44592
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAxisActor_GetLastMajorTickPointCorrection_72(HandleRef pThis);

		/// <summary>
		/// Set/Get visibility of the axis detached exponent.
		/// Default: false.
		/// </summary>
		// Token: 0x0600AE31 RID: 44593 RVA: 0x000F725C File Offset: 0x000F545C
		public virtual bool GetLastMajorTickPointCorrection()
		{
			return vtkAxisActor.vtkAxisActor_GetLastMajorTickPointCorrection_72(base.GetCppThis()) != 0;
		}

		// Token: 0x0600AE32 RID: 44594
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAxisActor_GetLog_73(HandleRef pThis);

		/// <summary>
		/// Set/Get The type of scale, enable logarithmic scale or linear by default.
		/// Default: false.
		/// </summary>
		// Token: 0x0600AE33 RID: 44595 RVA: 0x000F7284 File Offset: 0x000F5484
		public virtual bool GetLog()
		{
			return vtkAxisActor.vtkAxisActor_GetLog_73(base.GetCppThis()) != 0;
		}

		// Token: 0x0600AE34 RID: 44596
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxisActor_GetMajorRangeStart_74(HandleRef pThis);

		/// <summary>
		/// Set/Get the starting position for minor and major tick points on
		/// the range. The range and the position need not be identical. ie the displayed
		/// values need not match the actual positions in 3D space.
		/// Default: 0.0.
		/// </summary>
		// Token: 0x0600AE35 RID: 44597 RVA: 0x000F72AC File Offset: 0x000F54AC
		public virtual double GetMajorRangeStart()
		{
			return vtkAxisActor.vtkAxisActor_GetMajorRangeStart_74(base.GetCppThis());
		}

		// Token: 0x0600AE36 RID: 44598
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxisActor_GetMajorStart_75(HandleRef pThis, int axis);

		/// <summary>
		/// Set/Get the starting position for minor and major tick points,
		/// and the delta values that determine their spacing.
		/// </summary>
		// Token: 0x0600AE37 RID: 44599 RVA: 0x000F72CC File Offset: 0x000F54CC
		public double GetMajorStart(int axis)
		{
			return vtkAxisActor.vtkAxisActor_GetMajorStart_75(base.GetCppThis(), axis);
		}

		// Token: 0x0600AE38 RID: 44600
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxisActor_GetMajorTickSize_76(HandleRef pThis);

		/// <summary>
		/// Set/Get the size of major tick marks.
		/// Default: 1.0.
		/// </summary>
		// Token: 0x0600AE39 RID: 44601 RVA: 0x000F72EC File Offset: 0x000F54EC
		public virtual double GetMajorTickSize()
		{
			return vtkAxisActor.vtkAxisActor_GetMajorTickSize_76(base.GetCppThis());
		}

		// Token: 0x0600AE3A RID: 44602
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxisActor_GetMinorRangeStart_77(HandleRef pThis);

		/// <summary>
		/// Set/Get the starting position for minor and major tick points on
		/// the range. The range and the position need not be identical. ie the displayed
		/// values need not match the actual positions in 3D space.
		/// Default: 0.0.
		/// </summary>
		// Token: 0x0600AE3B RID: 44603 RVA: 0x000F730C File Offset: 0x000F550C
		public virtual double GetMinorRangeStart()
		{
			return vtkAxisActor.vtkAxisActor_GetMinorRangeStart_77(base.GetCppThis());
		}

		// Token: 0x0600AE3C RID: 44604
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxisActor_GetMinorStart_78(HandleRef pThis);

		/// <summary>
		/// Set/Get the starting position for minor and major tick points,
		/// and the delta values that determine their spacing.
		/// </summary>
		// Token: 0x0600AE3D RID: 44605 RVA: 0x000F732C File Offset: 0x000F552C
		public virtual double GetMinorStart()
		{
			return vtkAxisActor.vtkAxisActor_GetMinorStart_78(base.GetCppThis());
		}

		// Token: 0x0600AE3E RID: 44606
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxisActor_GetMinorTickSize_79(HandleRef pThis);

		/// <summary>
		/// Set/Get the size of minor tick marks.
		/// Default: 0.5.
		/// </summary>
		// Token: 0x0600AE3F RID: 44607 RVA: 0x000F734C File Offset: 0x000F554C
		public virtual double GetMinorTickSize()
		{
			return vtkAxisActor.vtkAxisActor_GetMinorTickSize_79(base.GetCppThis());
		}

		// Token: 0x0600AE40 RID: 44608
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAxisActor_GetMinorTicksVisible_80(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag that controls whether the minor ticks are visible.
		/// Default: true.
		/// </summary>
		// Token: 0x0600AE41 RID: 44609 RVA: 0x000F736C File Offset: 0x000F556C
		public virtual bool GetMinorTicksVisible()
		{
			return vtkAxisActor.vtkAxisActor_GetMinorTicksVisible_80(base.GetCppThis()) != 0;
		}

		// Token: 0x0600AE42 RID: 44610
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAxisActor_GetNumberOfGenerationsFromBase_81(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AE43 RID: 44611 RVA: 0x000F7394 File Offset: 0x000F5594
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAxisActor.vtkAxisActor_GetNumberOfGenerationsFromBase_81(base.GetCppThis(), type);
		}

		// Token: 0x0600AE44 RID: 44612
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAxisActor_GetNumberOfGenerationsFromBaseType_82([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AE45 RID: 44613 RVA: 0x000F73B4 File Offset: 0x000F55B4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAxisActor.vtkAxisActor_GetNumberOfGenerationsFromBaseType_82(type);
		}

		// Token: 0x0600AE46 RID: 44614
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisActor_GetNumberOfLabelsBuilt_83(HandleRef pThis);

		/// <summary>
		/// Get total number of labels built. Once built
		/// this count does not change.
		/// </summary>
		// Token: 0x0600AE47 RID: 44615 RVA: 0x000F73D0 File Offset: 0x000F55D0
		public virtual int GetNumberOfLabelsBuilt()
		{
			return vtkAxisActor.vtkAxisActor_GetNumberOfLabelsBuilt_83(base.GetCppThis());
		}

		// Token: 0x0600AE48 RID: 44616
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxisActor_GetPoint1_84(HandleRef pThis);

		/// <summary>
		/// Specify the position of the first point defining the axis.
		/// </summary>
		// Token: 0x0600AE49 RID: 44617 RVA: 0x000F73F0 File Offset: 0x000F55F0
		public virtual IntPtr GetPoint1()
		{
			return vtkAxisActor.vtkAxisActor_GetPoint1_84(base.GetCppThis());
		}

		// Token: 0x0600AE4A RID: 44618
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxisActor_GetPoint1Coordinate_85(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the position of the first point defining the axis.
		/// </summary>
		// Token: 0x0600AE4B RID: 44619 RVA: 0x000F7410 File Offset: 0x000F5610
		public virtual vtkCoordinate GetPoint1Coordinate()
		{
			vtkCoordinate vtkCoordinate = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxisActor.vtkAxisActor_GetPoint1Coordinate_85(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCoordinate = (vtkCoordinate)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCoordinate.Register(null);
				}
			}
			return vtkCoordinate;
		}

		// Token: 0x0600AE4C RID: 44620
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxisActor_GetPoint2_86(HandleRef pThis);

		/// <summary>
		/// Specify the position of the second point defining the axis.
		/// </summary>
		// Token: 0x0600AE4D RID: 44621 RVA: 0x000F7480 File Offset: 0x000F5680
		public virtual IntPtr GetPoint2()
		{
			return vtkAxisActor.vtkAxisActor_GetPoint2_86(base.GetCppThis());
		}

		// Token: 0x0600AE4E RID: 44622
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxisActor_GetPoint2Coordinate_87(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the position of the second point defining the axis.
		/// </summary>
		// Token: 0x0600AE4F RID: 44623 RVA: 0x000F74A0 File Offset: 0x000F56A0
		public virtual vtkCoordinate GetPoint2Coordinate()
		{
			vtkCoordinate vtkCoordinate = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxisActor.vtkAxisActor_GetPoint2Coordinate_87(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCoordinate = (vtkCoordinate)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCoordinate.Register(null);
				}
			}
			return vtkCoordinate;
		}

		// Token: 0x0600AE50 RID: 44624
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxisActor_GetRange_88(HandleRef pThis);

		/// <summary>
		/// Specify the (min,max) axis range. This will be used in the generation
		/// of labels, if labels are visible.
		/// Default: (0.0, 1.0).
		/// </summary>
		// Token: 0x0600AE51 RID: 44625 RVA: 0x000F7510 File Offset: 0x000F5710
		public virtual double[] GetRange()
		{
			IntPtr intPtr = vtkAxisActor.vtkAxisActor_GetRange_88(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600AE52 RID: 44626
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_GetRange_89(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify the (min,max) axis range. This will be used in the generation
		/// of labels, if labels are visible.
		/// Default: (0.0, 1.0).
		/// </summary>
		// Token: 0x0600AE53 RID: 44627 RVA: 0x000F7558 File Offset: 0x000F5758
		public virtual void GetRange(IntPtr data)
		{
			vtkAxisActor.vtkAxisActor_GetRange_89(base.GetCppThis(), data);
		}

		// Token: 0x0600AE54 RID: 44628
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisActor_GetSaveTitlePosition_90(HandleRef pThis);

		/// <summary>
		/// Set/Get whether title position must be saved in 2D mode.
		/// Default: 0.
		/// </summary>
		// Token: 0x0600AE55 RID: 44629 RVA: 0x000F7568 File Offset: 0x000F5768
		public virtual int GetSaveTitlePosition()
		{
			return vtkAxisActor.vtkAxisActor_GetSaveTitlePosition_90(base.GetCppThis());
		}

		// Token: 0x0600AE56 RID: 44630
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxisActor_GetScreenSize_91(HandleRef pThis);

		/// <summary>
		/// Set/Get size factor for text, used for offsets.
		/// Default: 10.0.
		/// </summary>
		// Token: 0x0600AE57 RID: 44631 RVA: 0x000F7588 File Offset: 0x000F5788
		public virtual double GetScreenSize()
		{
			return vtkAxisActor.vtkAxisActor_GetScreenSize_91(base.GetCppThis());
		}

		// Token: 0x0600AE58 RID: 44632
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisActor_GetTickLocation_92(HandleRef pThis);

		/// <summary>
		/// Set/Get the location of the ticks.
		/// Inside: tick end toward positive direction of perpendicular axes.
		/// Outside: tick end toward negative direction of perpendicular axes.
		/// Default: VTK_TICKS_INSIDE.
		/// </summary>
		// Token: 0x0600AE59 RID: 44633 RVA: 0x000F75A8 File Offset: 0x000F57A8
		public virtual int GetTickLocation()
		{
			return vtkAxisActor.vtkAxisActor_GetTickLocation_92(base.GetCppThis());
		}

		// Token: 0x0600AE5A RID: 44634
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisActor_GetTickLocationMaxValue_93(HandleRef pThis);

		/// <summary>
		/// Set/Get the location of the ticks.
		/// Inside: tick end toward positive direction of perpendicular axes.
		/// Outside: tick end toward negative direction of perpendicular axes.
		/// Default: VTK_TICKS_INSIDE.
		/// </summary>
		// Token: 0x0600AE5B RID: 44635 RVA: 0x000F75C8 File Offset: 0x000F57C8
		public virtual int GetTickLocationMaxValue()
		{
			return vtkAxisActor.vtkAxisActor_GetTickLocationMaxValue_93(base.GetCppThis());
		}

		// Token: 0x0600AE5C RID: 44636
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisActor_GetTickLocationMinValue_94(HandleRef pThis);

		/// <summary>
		/// Set/Get the location of the ticks.
		/// Inside: tick end toward positive direction of perpendicular axes.
		/// Outside: tick end toward negative direction of perpendicular axes.
		/// Default: VTK_TICKS_INSIDE.
		/// </summary>
		// Token: 0x0600AE5D RID: 44637 RVA: 0x000F75E8 File Offset: 0x000F57E8
		public virtual int GetTickLocationMinValue()
		{
			return vtkAxisActor.vtkAxisActor_GetTickLocationMinValue_94(base.GetCppThis());
		}

		// Token: 0x0600AE5E RID: 44638
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAxisActor_GetTickVisibility_95(HandleRef pThis);

		/// <summary>
		/// Set/Get visibility of the axis major tick marks.
		/// Default: true.
		/// </summary>
		// Token: 0x0600AE5F RID: 44639 RVA: 0x000F7608 File Offset: 0x000F5808
		public virtual bool GetTickVisibility()
		{
			return vtkAxisActor.vtkAxisActor_GetTickVisibility_95(base.GetCppThis()) != 0;
		}

		// Token: 0x0600AE60 RID: 44640
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxisActor_GetTitle_96(HandleRef pThis);

		/// <summary>
		/// Set/Get the title of the axis actor.
		/// </summary>
		// Token: 0x0600AE61 RID: 44641 RVA: 0x000F7630 File Offset: 0x000F5830
		public virtual string GetTitle()
		{
			string s = Marshal.PtrToStringAnsi(vtkAxisActor.vtkAxisActor_GetTitle_96(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600AE62 RID: 44642
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxisActor_GetTitleActor_97(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get title actor and it is responsible for drawing
		/// title text.
		/// </summary>
		// Token: 0x0600AE63 RID: 44643 RVA: 0x000F766C File Offset: 0x000F586C
		public virtual vtkAxisFollower GetTitleActor()
		{
			vtkAxisFollower vtkAxisFollower = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxisActor.vtkAxisActor_GetTitleActor_97(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAxisFollower = (vtkAxisFollower)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAxisFollower.Register(null);
				}
			}
			return vtkAxisFollower;
		}

		// Token: 0x0600AE64 RID: 44644
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisActor_GetTitleAlignLocation_98(HandleRef pThis);

		/// <summary>
		/// Get/Set the alignment of the title related to the axis.
		/// Possible Alignment: VTK_ALIGN_TOP, VTK_ALIGN_BOTTOM, VTK_ALIGN_POINT1, VTK_ALIGN_POINT2.
		/// Default: VTK_ALIGN_BOTTOM.
		/// </summary>
		// Token: 0x0600AE65 RID: 44645 RVA: 0x000F76DC File Offset: 0x000F58DC
		public virtual int GetTitleAlignLocation()
		{
			return vtkAxisActor.vtkAxisActor_GetTitleAlignLocation_98(base.GetCppThis());
		}

		// Token: 0x0600AE66 RID: 44646
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_GetTitleOffset_99(HandleRef pThis, ref double titleOffsetX, ref double titleOffsetY);

		/// <summary>
		/// Set/Get the 2D-offsets used to position title texts.
		/// X-component is applied only when not center aligned
		/// Center aligned &lt;=&gt; VTK_ALIGN_TOP and VTK_ALIGN_BOTTOM
		/// Y-component is the same than other offsets.
		/// Default: (20.0, 20.0).
		/// </summary>
		// Token: 0x0600AE67 RID: 44647 RVA: 0x000F76FB File Offset: 0x000F58FB
		public void GetTitleOffset(ref double titleOffsetX, ref double titleOffsetY)
		{
			vtkAxisActor.vtkAxisActor_GetTitleOffset_99(base.GetCppThis(), ref titleOffsetX, ref titleOffsetY);
		}

		// Token: 0x0600AE68 RID: 44648
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxisActor_GetTitleProp3D_100(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get title actor and it is responsible for drawing
		/// title text.
		/// </summary>
		// Token: 0x0600AE69 RID: 44649 RVA: 0x000F770C File Offset: 0x000F590C
		public virtual vtkProp3DAxisFollower GetTitleProp3D()
		{
			vtkProp3DAxisFollower vtkProp3DAxisFollower = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxisActor.vtkAxisActor_GetTitleProp3D_100(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProp3DAxisFollower = (vtkProp3DAxisFollower)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProp3DAxisFollower.Register(null);
				}
			}
			return vtkProp3DAxisFollower;
		}

		// Token: 0x0600AE6A RID: 44650
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxisActor_GetTitleTextProperty_101(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the axis title text property.
		/// </summary>
		// Token: 0x0600AE6B RID: 44651 RVA: 0x000F777C File Offset: 0x000F597C
		public vtkTextProperty GetTitleTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxisActor.vtkAxisActor_GetTitleTextProperty_101(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600AE6C RID: 44652
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAxisActor_GetTitleVisibility_102(HandleRef pThis);

		/// <summary>
		/// Set/Get visibility of the axis title.
		/// Default: true.
		/// </summary>
		// Token: 0x0600AE6D RID: 44653 RVA: 0x000F77EC File Offset: 0x000F59EC
		public virtual bool GetTitleVisibility()
		{
			return vtkAxisActor.vtkAxisActor_GetTitleVisibility_102(base.GetCppThis()) != 0;
		}

		// Token: 0x0600AE6E RID: 44654
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAxisActor_GetUse2DMode_103(HandleRef pThis);

		/// <summary>
		/// Set/Get the 2D mode.
		/// Default: false.
		/// </summary>
		// Token: 0x0600AE6F RID: 44655 RVA: 0x000F7814 File Offset: 0x000F5A14
		public virtual bool GetUse2DMode()
		{
			return vtkAxisActor.vtkAxisActor_GetUse2DMode_103(base.GetCppThis()) != 0;
		}

		// Token: 0x0600AE70 RID: 44656
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAxisActor_GetUseTextActor3D_104(HandleRef pThis);

		/// <summary>
		/// Render text as polygons (vtkVectorText) or as sprites (vtkTextActor3D).
		/// In 2D mode, the value is ignored and text is rendered as vtkTextActor.
		/// False(0) by default.
		/// See Also:
		/// GetUse2DMode(), SetUse2DMode
		/// </summary>
		// Token: 0x0600AE71 RID: 44657 RVA: 0x000F783C File Offset: 0x000F5A3C
		public virtual bool GetUseTextActor3D()
		{
			return vtkAxisActor.vtkAxisActor_GetUseTextActor3D_104(base.GetCppThis()) != 0;
		}

		// Token: 0x0600AE72 RID: 44658
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxisActor_GetVerticalOffsetXTitle2D_105(HandleRef pThis);

		/// <summary>
		/// Set/Get the 2D mode the vertical offset for X title in 2D mode.
		/// Default: -40.0.
		/// </summary>
		// Token: 0x0600AE73 RID: 44659 RVA: 0x000F7864 File Offset: 0x000F5A64
		public virtual double GetVerticalOffsetXTitle2D()
		{
			return vtkAxisActor.vtkAxisActor_GetVerticalOffsetXTitle2D_105(base.GetCppThis());
		}

		// Token: 0x0600AE74 RID: 44660
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisActor_HasTranslucentPolygonalGeometry_106(HandleRef pThis);

		/// <summary>
		/// Draw the axis.
		/// </summary>
		// Token: 0x0600AE75 RID: 44661 RVA: 0x000F7884 File Offset: 0x000F5A84
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkAxisActor.vtkAxisActor_HasTranslucentPolygonalGeometry_106(base.GetCppThis());
		}

		// Token: 0x0600AE76 RID: 44662
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisActor_IsA_107(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AE77 RID: 44663 RVA: 0x000F78A4 File Offset: 0x000F5AA4
		public override int IsA(string type)
		{
			return vtkAxisActor.vtkAxisActor_IsA_107(base.GetCppThis(), type);
		}

		// Token: 0x0600AE78 RID: 44664
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisActor_IsTypeOf_108([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AE79 RID: 44665 RVA: 0x000F78C4 File Offset: 0x000F5AC4
		public new static int IsTypeOf(string type)
		{
			return vtkAxisActor.vtkAxisActor_IsTypeOf_108(type);
		}

		// Token: 0x0600AE7A RID: 44666
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_LabelVisibilityOff_109(HandleRef pThis);

		/// <summary>
		/// Set/Get visibility of the axis labels.
		/// Default: true.
		/// </summary>
		// Token: 0x0600AE7B RID: 44667 RVA: 0x000F78DE File Offset: 0x000F5ADE
		public virtual void LabelVisibilityOff()
		{
			vtkAxisActor.vtkAxisActor_LabelVisibilityOff_109(base.GetCppThis());
		}

		// Token: 0x0600AE7C RID: 44668
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_LabelVisibilityOn_110(HandleRef pThis);

		/// <summary>
		/// Set/Get visibility of the axis labels.
		/// Default: true.
		/// </summary>
		// Token: 0x0600AE7D RID: 44669 RVA: 0x000F78ED File Offset: 0x000F5AED
		public virtual void LabelVisibilityOn()
		{
			vtkAxisActor.vtkAxisActor_LabelVisibilityOn_110(base.GetCppThis());
		}

		// Token: 0x0600AE7E RID: 44670
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_LastMajorTickPointCorrectionOff_111(HandleRef pThis);

		/// <summary>
		/// Set/Get visibility of the axis detached exponent.
		/// Default: false.
		/// </summary>
		// Token: 0x0600AE7F RID: 44671 RVA: 0x000F78FC File Offset: 0x000F5AFC
		public virtual void LastMajorTickPointCorrectionOff()
		{
			vtkAxisActor.vtkAxisActor_LastMajorTickPointCorrectionOff_111(base.GetCppThis());
		}

		// Token: 0x0600AE80 RID: 44672
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_LastMajorTickPointCorrectionOn_112(HandleRef pThis);

		/// <summary>
		/// Set/Get visibility of the axis detached exponent.
		/// Default: false.
		/// </summary>
		// Token: 0x0600AE81 RID: 44673 RVA: 0x000F790B File Offset: 0x000F5B0B
		public virtual void LastMajorTickPointCorrectionOn()
		{
			vtkAxisActor.vtkAxisActor_LastMajorTickPointCorrectionOn_112(base.GetCppThis());
		}

		// Token: 0x0600AE82 RID: 44674
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_LogOff_113(HandleRef pThis);

		/// <summary>
		/// Set/Get The type of scale, enable logarithmic scale or linear by default.
		/// Default: false.
		/// </summary>
		// Token: 0x0600AE83 RID: 44675 RVA: 0x000F791A File Offset: 0x000F5B1A
		public virtual void LogOff()
		{
			vtkAxisActor.vtkAxisActor_LogOff_113(base.GetCppThis());
		}

		// Token: 0x0600AE84 RID: 44676
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_LogOn_114(HandleRef pThis);

		/// <summary>
		/// Set/Get The type of scale, enable logarithmic scale or linear by default.
		/// Default: false.
		/// </summary>
		// Token: 0x0600AE85 RID: 44677 RVA: 0x000F7929 File Offset: 0x000F5B29
		public virtual void LogOn()
		{
			vtkAxisActor.vtkAxisActor_LogOn_114(base.GetCppThis());
		}

		// Token: 0x0600AE86 RID: 44678
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_MinorTicksVisibleOff_115(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag that controls whether the minor ticks are visible.
		/// Default: true.
		/// </summary>
		// Token: 0x0600AE87 RID: 44679 RVA: 0x000F7938 File Offset: 0x000F5B38
		public virtual void MinorTicksVisibleOff()
		{
			vtkAxisActor.vtkAxisActor_MinorTicksVisibleOff_115(base.GetCppThis());
		}

		// Token: 0x0600AE88 RID: 44680
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_MinorTicksVisibleOn_116(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag that controls whether the minor ticks are visible.
		/// Default: true.
		/// </summary>
		// Token: 0x0600AE89 RID: 44681 RVA: 0x000F7947 File Offset: 0x000F5B47
		public virtual void MinorTicksVisibleOn()
		{
			vtkAxisActor.vtkAxisActor_MinorTicksVisibleOn_116(base.GetCppThis());
		}

		// Token: 0x0600AE8A RID: 44682
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxisActor_NewInstance_118(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AE8B RID: 44683 RVA: 0x000F7958 File Offset: 0x000F5B58
		public new vtkAxisActor NewInstance()
		{
			vtkAxisActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxisActor.vtkAxisActor_NewInstance_118(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAxisActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600AE8C RID: 44684
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_ReleaseGraphicsResources_119(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Release any graphics resources that are being consumed by this actor.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x0600AE8D RID: 44685 RVA: 0x000F79B4 File Offset: 0x000F5BB4
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkAxisActor.vtkAxisActor_ReleaseGraphicsResources_119(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600AE8E RID: 44686
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisActor_RenderOpaqueGeometry_120(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Draw the axis.
		/// </summary>
		// Token: 0x0600AE8F RID: 44687 RVA: 0x000F79E4 File Offset: 0x000F5BE4
		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkAxisActor.vtkAxisActor_RenderOpaqueGeometry_120(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x0600AE90 RID: 44688
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisActor_RenderOverlay_121(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Draw the axis.
		/// </summary>
		// Token: 0x0600AE91 RID: 44689 RVA: 0x000F7A18 File Offset: 0x000F5C18
		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkAxisActor.vtkAxisActor_RenderOverlay_121(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x0600AE92 RID: 44690
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisActor_RenderTranslucentGeometry_122(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Draw the axis.
		/// </summary>
		// Token: 0x0600AE93 RID: 44691 RVA: 0x000F7A4C File Offset: 0x000F5C4C
		public virtual int RenderTranslucentGeometry(vtkViewport viewport)
		{
			return vtkAxisActor.vtkAxisActor_RenderTranslucentGeometry_122(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x0600AE94 RID: 44692
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisActor_RenderTranslucentPolygonalGeometry_123(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Draw the axis.
		/// </summary>
		// Token: 0x0600AE95 RID: 44693 RVA: 0x000F7A80 File Offset: 0x000F5C80
		public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
		{
			return vtkAxisActor.vtkAxisActor_RenderTranslucentPolygonalGeometry_123(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x0600AE96 RID: 44694
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxisActor_SafeDownCast_124(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AE97 RID: 44695 RVA: 0x000F7AB4 File Offset: 0x000F5CB4
		public new static vtkAxisActor SafeDownCast(vtkObjectBase o)
		{
			vtkAxisActor vtkAxisActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxisActor.vtkAxisActor_SafeDownCast_124((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAxisActor = (vtkAxisActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAxisActor.Register(null);
				}
			}
			return vtkAxisActor;
		}

		// Token: 0x0600AE98 RID: 44696
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetAxisBaseForX_125(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Provide real vector for non aligned axis.
		/// Default: (1.0, 0.0, 0.0).
		/// </summary>
		// Token: 0x0600AE99 RID: 44697 RVA: 0x000F7B33 File Offset: 0x000F5D33
		public virtual void SetAxisBaseForX(double _arg1, double _arg2, double _arg3)
		{
			vtkAxisActor.vtkAxisActor_SetAxisBaseForX_125(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600AE9A RID: 44698
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetAxisBaseForX_126(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Provide real vector for non aligned axis.
		/// Default: (1.0, 0.0, 0.0).
		/// </summary>
		// Token: 0x0600AE9B RID: 44699 RVA: 0x000F7B45 File Offset: 0x000F5D45
		public virtual void SetAxisBaseForX(IntPtr _arg)
		{
			vtkAxisActor.vtkAxisActor_SetAxisBaseForX_126(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AE9C RID: 44700
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetAxisBaseForY_127(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Provide real vector for non aligned axis.
		/// Default: (0.0, 1.0, 0.0).
		/// </summary>
		// Token: 0x0600AE9D RID: 44701 RVA: 0x000F7B55 File Offset: 0x000F5D55
		public virtual void SetAxisBaseForY(double _arg1, double _arg2, double _arg3)
		{
			vtkAxisActor.vtkAxisActor_SetAxisBaseForY_127(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600AE9E RID: 44702
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetAxisBaseForY_128(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Provide real vector for non aligned axis.
		/// Default: (0.0, 1.0, 0.0).
		/// </summary>
		// Token: 0x0600AE9F RID: 44703 RVA: 0x000F7B67 File Offset: 0x000F5D67
		public virtual void SetAxisBaseForY(IntPtr _arg)
		{
			vtkAxisActor.vtkAxisActor_SetAxisBaseForY_128(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AEA0 RID: 44704
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetAxisBaseForZ_129(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Provide real vector for non aligned axis.
		/// Default: (0.0, 0.0, 1.0).
		/// </summary>
		// Token: 0x0600AEA1 RID: 44705 RVA: 0x000F7B77 File Offset: 0x000F5D77
		public virtual void SetAxisBaseForZ(double _arg1, double _arg2, double _arg3)
		{
			vtkAxisActor.vtkAxisActor_SetAxisBaseForZ_129(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600AEA2 RID: 44706
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetAxisBaseForZ_130(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Provide real vector for non aligned axis.
		/// Default: (0.0, 0.0, 1.0).
		/// </summary>
		// Token: 0x0600AEA3 RID: 44707 RVA: 0x000F7B89 File Offset: 0x000F5D89
		public virtual void SetAxisBaseForZ(IntPtr _arg)
		{
			vtkAxisActor.vtkAxisActor_SetAxisBaseForZ_130(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AEA4 RID: 44708
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetAxisLinesProperty_131(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get/Set axis actor property (axis and its ticks) (kept for compatibility)
		/// </summary>
		// Token: 0x0600AEA5 RID: 44709 RVA: 0x000F7B9C File Offset: 0x000F5D9C
		public void SetAxisLinesProperty(vtkProperty arg0)
		{
			vtkAxisActor.vtkAxisActor_SetAxisLinesProperty_131(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600AEA6 RID: 44710
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetAxisMainLineProperty_132(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get/Set main line axis actor property
		/// </summary>
		// Token: 0x0600AEA7 RID: 44711 RVA: 0x000F7BCC File Offset: 0x000F5DCC
		public void SetAxisMainLineProperty(vtkProperty arg0)
		{
			vtkAxisActor.vtkAxisActor_SetAxisMainLineProperty_132(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600AEA8 RID: 44712
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetAxisMajorTicksProperty_133(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get/Set axis actor property (axis and its ticks)
		/// </summary>
		// Token: 0x0600AEA9 RID: 44713 RVA: 0x000F7BFC File Offset: 0x000F5DFC
		public void SetAxisMajorTicksProperty(vtkProperty arg0)
		{
			vtkAxisActor.vtkAxisActor_SetAxisMajorTicksProperty_133(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600AEAA RID: 44714
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetAxisMinorTicksProperty_134(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get/Set axis actor property (axis and its ticks)
		/// </summary>
		// Token: 0x0600AEAB RID: 44715 RVA: 0x000F7C2C File Offset: 0x000F5E2C
		public void SetAxisMinorTicksProperty(vtkProperty arg0)
		{
			vtkAxisActor.vtkAxisActor_SetAxisMinorTicksProperty_134(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600AEAC RID: 44716
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetAxisOnOrigin_135(HandleRef pThis, byte _arg);

		/// <summary>
		/// Notify the axes that is not part of a cube anymore.
		/// Default: false.
		/// </summary>
		// Token: 0x0600AEAD RID: 44717 RVA: 0x000F7C5B File Offset: 0x000F5E5B
		public virtual void SetAxisOnOrigin(bool _arg)
		{
			vtkAxisActor.vtkAxisActor_SetAxisOnOrigin_135(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600AEAE RID: 44718
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetAxisPosition_136(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the position of this axis (in relation to an an
		/// assumed bounding box).  For an x-type axis, MINMIN corresponds
		/// to the x-edge in the bounding box where Y values are minimum and
		/// Z values are minimum. For a y-type axis, MAXMIN corresponds to the
		/// y-edge where X values are maximum and Z values are minimum.
		/// Default: VTK_AXIS_POS_MINMIN.
		/// </summary>
		// Token: 0x0600AEAF RID: 44719 RVA: 0x000F7C73 File Offset: 0x000F5E73
		public virtual void SetAxisPosition(int _arg)
		{
			vtkAxisActor.vtkAxisActor_SetAxisPosition_136(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AEB0 RID: 44720
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetAxisPositionToMaxMax_137(HandleRef pThis);

		/// <summary>
		/// Set/Get the position of this axis (in relation to an an
		/// assumed bounding box).  For an x-type axis, MINMIN corresponds
		/// to the x-edge in the bounding box where Y values are minimum and
		/// Z values are minimum. For a y-type axis, MAXMIN corresponds to the
		/// y-edge where X values are maximum and Z values are minimum.
		/// Default: VTK_AXIS_POS_MINMIN.
		/// </summary>
		// Token: 0x0600AEB1 RID: 44721 RVA: 0x000F7C83 File Offset: 0x000F5E83
		public void SetAxisPositionToMaxMax()
		{
			vtkAxisActor.vtkAxisActor_SetAxisPositionToMaxMax_137(base.GetCppThis());
		}

		// Token: 0x0600AEB2 RID: 44722
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetAxisPositionToMaxMin_138(HandleRef pThis);

		/// <summary>
		/// Set/Get the position of this axis (in relation to an an
		/// assumed bounding box).  For an x-type axis, MINMIN corresponds
		/// to the x-edge in the bounding box where Y values are minimum and
		/// Z values are minimum. For a y-type axis, MAXMIN corresponds to the
		/// y-edge where X values are maximum and Z values are minimum.
		/// Default: VTK_AXIS_POS_MINMIN.
		/// </summary>
		// Token: 0x0600AEB3 RID: 44723 RVA: 0x000F7C92 File Offset: 0x000F5E92
		public void SetAxisPositionToMaxMin()
		{
			vtkAxisActor.vtkAxisActor_SetAxisPositionToMaxMin_138(base.GetCppThis());
		}

		// Token: 0x0600AEB4 RID: 44724
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetAxisPositionToMinMax_139(HandleRef pThis);

		/// <summary>
		/// Set/Get the position of this axis (in relation to an an
		/// assumed bounding box).  For an x-type axis, MINMIN corresponds
		/// to the x-edge in the bounding box where Y values are minimum and
		/// Z values are minimum. For a y-type axis, MAXMIN corresponds to the
		/// y-edge where X values are maximum and Z values are minimum.
		/// Default: VTK_AXIS_POS_MINMIN.
		/// </summary>
		// Token: 0x0600AEB5 RID: 44725 RVA: 0x000F7CA1 File Offset: 0x000F5EA1
		public void SetAxisPositionToMinMax()
		{
			vtkAxisActor.vtkAxisActor_SetAxisPositionToMinMax_139(base.GetCppThis());
		}

		// Token: 0x0600AEB6 RID: 44726
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetAxisPositionToMinMin_140(HandleRef pThis);

		/// <summary>
		/// Set/Get the position of this axis (in relation to an an
		/// assumed bounding box).  For an x-type axis, MINMIN corresponds
		/// to the x-edge in the bounding box where Y values are minimum and
		/// Z values are minimum. For a y-type axis, MAXMIN corresponds to the
		/// y-edge where X values are maximum and Z values are minimum.
		/// Default: VTK_AXIS_POS_MINMIN.
		/// </summary>
		// Token: 0x0600AEB7 RID: 44727 RVA: 0x000F7CB0 File Offset: 0x000F5EB0
		public void SetAxisPositionToMinMin()
		{
			vtkAxisActor.vtkAxisActor_SetAxisPositionToMinMin_140(base.GetCppThis());
		}

		// Token: 0x0600AEB8 RID: 44728
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetAxisType_141(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the type of this axis.
		/// Default: VTK_AXIS_TYPE_X.
		/// </summary>
		// Token: 0x0600AEB9 RID: 44729 RVA: 0x000F7CBF File Offset: 0x000F5EBF
		public virtual void SetAxisType(int _arg)
		{
			vtkAxisActor.vtkAxisActor_SetAxisType_141(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AEBA RID: 44730
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetAxisTypeToX_142(HandleRef pThis);

		/// <summary>
		/// Set/Get the type of this axis.
		/// Default: VTK_AXIS_TYPE_X.
		/// </summary>
		// Token: 0x0600AEBB RID: 44731 RVA: 0x000F7CCF File Offset: 0x000F5ECF
		public void SetAxisTypeToX()
		{
			vtkAxisActor.vtkAxisActor_SetAxisTypeToX_142(base.GetCppThis());
		}

		// Token: 0x0600AEBC RID: 44732
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetAxisTypeToY_143(HandleRef pThis);

		/// <summary>
		/// Set/Get the type of this axis.
		/// Default: VTK_AXIS_TYPE_X.
		/// </summary>
		// Token: 0x0600AEBD RID: 44733 RVA: 0x000F7CDE File Offset: 0x000F5EDE
		public void SetAxisTypeToY()
		{
			vtkAxisActor.vtkAxisActor_SetAxisTypeToY_143(base.GetCppThis());
		}

		// Token: 0x0600AEBE RID: 44734
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetAxisTypeToZ_144(HandleRef pThis);

		/// <summary>
		/// Set/Get the type of this axis.
		/// Default: VTK_AXIS_TYPE_X.
		/// </summary>
		// Token: 0x0600AEBF RID: 44735 RVA: 0x000F7CED File Offset: 0x000F5EED
		public void SetAxisTypeToZ()
		{
			vtkAxisActor.vtkAxisActor_SetAxisTypeToZ_144(base.GetCppThis());
		}

		// Token: 0x0600AEC0 RID: 44736
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetAxisVisibility_145(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get visibility of the axis line.
		/// Default: true.
		/// </summary>
		// Token: 0x0600AEC1 RID: 44737 RVA: 0x000F7CFC File Offset: 0x000F5EFC
		public virtual void SetAxisVisibility(bool _arg)
		{
			vtkAxisActor.vtkAxisActor_SetAxisVisibility_145(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600AEC2 RID: 44738
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetBounds_146(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Set or get the bounds for this Actor as (Xmin,Xmax,Ymin,Ymax,Zmin,Zmax).
		/// Default: (-1, 1, -1, 1, -1, 1).
		/// </summary>
		// Token: 0x0600AEC3 RID: 44739 RVA: 0x000F7D14 File Offset: 0x000F5F14
		public void SetBounds(IntPtr bounds)
		{
			vtkAxisActor.vtkAxisActor_SetBounds_146(base.GetCppThis(), bounds);
		}

		// Token: 0x0600AEC4 RID: 44740
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetBounds_147(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

		/// <summary>
		/// Set or get the bounds for this Actor as (Xmin,Xmax,Ymin,Ymax,Zmin,Zmax).
		/// Default: (-1, 1, -1, 1, -1, 1).
		/// </summary>
		// Token: 0x0600AEC5 RID: 44741 RVA: 0x000F7D24 File Offset: 0x000F5F24
		public void SetBounds(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
		{
			vtkAxisActor.vtkAxisActor_SetBounds_147(base.GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
		}

		// Token: 0x0600AEC6 RID: 44742
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetCalculateLabelOffset_148(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get flag whether to calculate label offset.
		/// Default: false.
		/// </summary>
		// Token: 0x0600AEC7 RID: 44743 RVA: 0x000F7D3C File Offset: 0x000F5F3C
		public virtual void SetCalculateLabelOffset(bool _arg)
		{
			vtkAxisActor.vtkAxisActor_SetCalculateLabelOffset_148(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600AEC8 RID: 44744
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetCalculateTitleOffset_149(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get flag whether to calculate title offset.
		/// Default: false.
		/// </summary>
		// Token: 0x0600AEC9 RID: 44745 RVA: 0x000F7D54 File Offset: 0x000F5F54
		public virtual void SetCalculateTitleOffset(bool _arg)
		{
			vtkAxisActor.vtkAxisActor_SetCalculateTitleOffset_149(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600AECA RID: 44746
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetCamera_150(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the camera for this axis.  The camera is used by the
		/// labels to 'follow' the camera and be legible from any viewpoint.
		/// </summary>
		// Token: 0x0600AECB RID: 44747 RVA: 0x000F7D6C File Offset: 0x000F5F6C
		public virtual void SetCamera(vtkCamera arg0)
		{
			vtkAxisActor.vtkAxisActor_SetCamera_150(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600AECC RID: 44748
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetDeltaMajor_151(HandleRef pThis, int axis, double value);

		/// <summary>
		/// Set/Get the starting position for minor and major tick points,
		/// and the delta values that determine their spacing.
		/// </summary>
		// Token: 0x0600AECD RID: 44749 RVA: 0x000F7D9B File Offset: 0x000F5F9B
		public void SetDeltaMajor(int axis, double value)
		{
			vtkAxisActor.vtkAxisActor_SetDeltaMajor_151(base.GetCppThis(), axis, value);
		}

		// Token: 0x0600AECE RID: 44750
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetDeltaMinor_152(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the starting position for minor and major tick points,
		/// and the delta values that determine their spacing.
		/// </summary>
		// Token: 0x0600AECF RID: 44751 RVA: 0x000F7DAC File Offset: 0x000F5FAC
		public virtual void SetDeltaMinor(double _arg)
		{
			vtkAxisActor.vtkAxisActor_SetDeltaMinor_152(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AED0 RID: 44752
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetDeltaRangeMajor_153(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the delta range for minor and major tick points that determine their spacing.
		/// Default: 1.0.
		/// </summary>
		// Token: 0x0600AED1 RID: 44753 RVA: 0x000F7DBC File Offset: 0x000F5FBC
		public virtual void SetDeltaRangeMajor(double _arg)
		{
			vtkAxisActor.vtkAxisActor_SetDeltaRangeMajor_153(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AED2 RID: 44754
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetDeltaRangeMinor_154(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the delta range for minor and major tick points that determine their spacing.
		/// Default: 1.0.
		/// </summary>
		// Token: 0x0600AED3 RID: 44755 RVA: 0x000F7DCC File Offset: 0x000F5FCC
		public virtual void SetDeltaRangeMinor(double _arg)
		{
			vtkAxisActor.vtkAxisActor_SetDeltaRangeMinor_154(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AED4 RID: 44756
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetDrawGridlines_155(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get whether gridlines should be drawn.
		/// Default: false.
		/// </summary>
		// Token: 0x0600AED5 RID: 44757 RVA: 0x000F7DDC File Offset: 0x000F5FDC
		public virtual void SetDrawGridlines(bool _arg)
		{
			vtkAxisActor.vtkAxisActor_SetDrawGridlines_155(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600AED6 RID: 44758
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetDrawGridlinesLocation_156(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get whether ONLY the gridlines should be drawn.
		/// This will only draw GridLines and will skip any other part of the rendering
		/// such as Axis/Tick/Title/...
		/// Default: false.
		/// </summary>
		// Token: 0x0600AED7 RID: 44759 RVA: 0x000F7DF4 File Offset: 0x000F5FF4
		public virtual void SetDrawGridlinesLocation(int _arg)
		{
			vtkAxisActor.vtkAxisActor_SetDrawGridlinesLocation_156(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AED8 RID: 44760
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetDrawGridlinesOnly_157(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get whether ONLY the gridlines should be drawn.
		/// This will only draw GridLines and will skip any other part of the rendering
		/// such as Axis/Tick/Title/...
		/// Default: false.
		/// </summary>
		// Token: 0x0600AED9 RID: 44761 RVA: 0x000F7E04 File Offset: 0x000F6004
		public virtual void SetDrawGridlinesOnly(bool _arg)
		{
			vtkAxisActor.vtkAxisActor_SetDrawGridlinesOnly_157(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600AEDA RID: 44762
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetDrawGridpolys_158(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get whether gridpolys should be drawn.
		/// Default: false.
		/// </summary>
		// Token: 0x0600AEDB RID: 44763 RVA: 0x000F7E1C File Offset: 0x000F601C
		public virtual void SetDrawGridpolys(bool _arg)
		{
			vtkAxisActor.vtkAxisActor_SetDrawGridpolys_158(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600AEDC RID: 44764
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetDrawInnerGridlines_159(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get whether inner gridlines should be drawn.
		/// Default: false.
		/// </summary>
		// Token: 0x0600AEDD RID: 44765 RVA: 0x000F7E34 File Offset: 0x000F6034
		public virtual void SetDrawInnerGridlines(bool _arg)
		{
			vtkAxisActor.vtkAxisActor_SetDrawInnerGridlines_159(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600AEDE RID: 44766
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetExponent_160(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string t);

		/// <summary>
		/// Set/Get the common exponent of the labels values.
		/// </summary>
		// Token: 0x0600AEDF RID: 44767 RVA: 0x000F7E4C File Offset: 0x000F604C
		public void SetExponent(string t)
		{
			vtkAxisActor.vtkAxisActor_SetExponent_160(base.GetCppThis(), t);
		}

		// Token: 0x0600AEE0 RID: 44768
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetExponentLocation_161(HandleRef pThis, int location);

		/// <summary>
		/// Get/Set the location of the Detached Exponent related to the axis.
		/// Possible Location: VTK_ALIGN_TOP, VTK_ALIGN_BOTTOM, VTK_ALIGN_POINT1, VTK_ALIGN_POINT2.
		/// Default: VTK_ALIGN_POINT2.
		/// </summary>
		// Token: 0x0600AEE1 RID: 44769 RVA: 0x000F7E5C File Offset: 0x000F605C
		public virtual void SetExponentLocation(int location)
		{
			vtkAxisActor.vtkAxisActor_SetExponentLocation_161(base.GetCppThis(), location);
		}

		// Token: 0x0600AEE2 RID: 44770
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetExponentOffset_162(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the Y-offset used to position exponent.
		/// Default: 20.0.
		/// </summary>
		// Token: 0x0600AEE3 RID: 44771 RVA: 0x000F7E6C File Offset: 0x000F606C
		public virtual void SetExponentOffset(double _arg)
		{
			vtkAxisActor.vtkAxisActor_SetExponentOffset_162(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AEE4 RID: 44772
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetExponentVisibility_163(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get visibility of the axis detached exponent.
		/// Default: false.
		/// </summary>
		// Token: 0x0600AEE5 RID: 44773 RVA: 0x000F7E7C File Offset: 0x000F607C
		public virtual void SetExponentVisibility(bool _arg)
		{
			vtkAxisActor.vtkAxisActor_SetExponentVisibility_163(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600AEE6 RID: 44774
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetGridlineXLength_164(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the length to use when drawing gridlines.
		/// Default: 1.0.
		/// </summary>
		// Token: 0x0600AEE7 RID: 44775 RVA: 0x000F7E94 File Offset: 0x000F6094
		public virtual void SetGridlineXLength(double _arg)
		{
			vtkAxisActor.vtkAxisActor_SetGridlineXLength_164(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AEE8 RID: 44776
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetGridlineYLength_165(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the length to use when drawing gridlines.
		/// Default: 1.0.
		/// </summary>
		// Token: 0x0600AEE9 RID: 44777 RVA: 0x000F7EA4 File Offset: 0x000F60A4
		public virtual void SetGridlineYLength(double _arg)
		{
			vtkAxisActor.vtkAxisActor_SetGridlineYLength_165(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AEEA RID: 44778
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetGridlineZLength_166(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the length to use when drawing gridlines.
		/// Default: 1.0.
		/// </summary>
		// Token: 0x0600AEEB RID: 44779 RVA: 0x000F7EB4 File Offset: 0x000F60B4
		public virtual void SetGridlineZLength(double _arg)
		{
			vtkAxisActor.vtkAxisActor_SetGridlineZLength_166(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AEEC RID: 44780
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetGridlinesProperty_167(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get/Set gridlines actor property (outer grid lines)
		/// </summary>
		// Token: 0x0600AEED RID: 44781 RVA: 0x000F7EC4 File Offset: 0x000F60C4
		public void SetGridlinesProperty(vtkProperty arg0)
		{
			vtkAxisActor.vtkAxisActor_SetGridlinesProperty_167(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600AEEE RID: 44782
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetGridpolysProperty_168(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get/Set gridPolys actor property (grid quads)
		/// </summary>
		// Token: 0x0600AEEF RID: 44783 RVA: 0x000F7EF4 File Offset: 0x000F60F4
		public void SetGridpolysProperty(vtkProperty arg0)
		{
			vtkAxisActor.vtkAxisActor_SetGridpolysProperty_168(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600AEF0 RID: 44784
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetHorizontalOffsetYTitle2D_169(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the 2D mode the horizontal offset for Y title in 2D mode.
		/// Default: -50.0.
		/// </summary>
		// Token: 0x0600AEF1 RID: 44785 RVA: 0x000F7F23 File Offset: 0x000F6123
		public virtual void SetHorizontalOffsetYTitle2D(double _arg)
		{
			vtkAxisActor.vtkAxisActor_SetHorizontalOffsetYTitle2D_169(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AEF2 RID: 44786
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetInnerGridlinesProperty_170(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get/Set inner gridlines actor property
		/// </summary>
		// Token: 0x0600AEF3 RID: 44787 RVA: 0x000F7F34 File Offset: 0x000F6134
		public void SetInnerGridlinesProperty(vtkProperty arg0)
		{
			vtkAxisActor.vtkAxisActor_SetInnerGridlinesProperty_170(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600AEF4 RID: 44788
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetLabelFormat_171(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the format with which to print the labels on the axis.
		/// </summary>
		// Token: 0x0600AEF5 RID: 44789 RVA: 0x000F7F63 File Offset: 0x000F6163
		public virtual void SetLabelFormat(string _arg)
		{
			vtkAxisActor.vtkAxisActor_SetLabelFormat_171(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AEF6 RID: 44790
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetLabelOffset_172(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the Y-offset used to position label.
		/// Default: 30.0.
		/// </summary>
		// Token: 0x0600AEF7 RID: 44791 RVA: 0x000F7F73 File Offset: 0x000F6173
		public virtual void SetLabelOffset(double _arg)
		{
			vtkAxisActor.vtkAxisActor_SetLabelOffset_172(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AEF8 RID: 44792
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetLabelScale_173(HandleRef pThis, double scale);

		/// <summary>
		/// Release any graphics resources that are being consumed by this actor.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x0600AEF9 RID: 44793 RVA: 0x000F7F83 File Offset: 0x000F6183
		public void SetLabelScale(double scale)
		{
			vtkAxisActor.vtkAxisActor_SetLabelScale_173(base.GetCppThis(), scale);
		}

		// Token: 0x0600AEFA RID: 44794
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetLabelScale_174(HandleRef pThis, int labelIndex, double scale);

		/// <summary>
		/// Release any graphics resources that are being consumed by this actor.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x0600AEFB RID: 44795 RVA: 0x000F7F93 File Offset: 0x000F6193
		public void SetLabelScale(int labelIndex, double scale)
		{
			vtkAxisActor.vtkAxisActor_SetLabelScale_174(base.GetCppThis(), labelIndex, scale);
		}

		// Token: 0x0600AEFC RID: 44796
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetLabelTextProperty_175(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Set/Get the axis labels text property.
		/// </summary>
		// Token: 0x0600AEFD RID: 44797 RVA: 0x000F7FA4 File Offset: 0x000F61A4
		public virtual void SetLabelTextProperty(vtkTextProperty p)
		{
			vtkAxisActor.vtkAxisActor_SetLabelTextProperty_175(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x0600AEFE RID: 44798
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetLabelVisibility_176(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get visibility of the axis labels.
		/// Default: true.
		/// </summary>
		// Token: 0x0600AEFF RID: 44799 RVA: 0x000F7FD3 File Offset: 0x000F61D3
		public virtual void SetLabelVisibility(bool _arg)
		{
			vtkAxisActor.vtkAxisActor_SetLabelVisibility_176(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600AF00 RID: 44800
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetLabels_177(HandleRef pThis, HandleRef labels);

		/// <summary>
		/// Set/Get the delta range for minor and major tick points that determine their spacing.
		/// Default: 1.0.
		/// </summary>
		// Token: 0x0600AF01 RID: 44801 RVA: 0x000F7FEC File Offset: 0x000F61EC
		public void SetLabels(vtkStringArray labels)
		{
			vtkAxisActor.vtkAxisActor_SetLabels_177(base.GetCppThis(), (labels == null) ? default(HandleRef) : labels.GetCppThis());
		}

		// Token: 0x0600AF02 RID: 44802
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetLastMajorTickPointCorrection_178(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get visibility of the axis detached exponent.
		/// Default: false.
		/// </summary>
		// Token: 0x0600AF03 RID: 44803 RVA: 0x000F801B File Offset: 0x000F621B
		public virtual void SetLastMajorTickPointCorrection(bool _arg)
		{
			vtkAxisActor.vtkAxisActor_SetLastMajorTickPointCorrection_178(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600AF04 RID: 44804
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetLog_179(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get The type of scale, enable logarithmic scale or linear by default.
		/// Default: false.
		/// </summary>
		// Token: 0x0600AF05 RID: 44805 RVA: 0x000F8033 File Offset: 0x000F6233
		public virtual void SetLog(bool _arg)
		{
			vtkAxisActor.vtkAxisActor_SetLog_179(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600AF06 RID: 44806
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetMajorRangeStart_180(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the starting position for minor and major tick points on
		/// the range. The range and the position need not be identical. ie the displayed
		/// values need not match the actual positions in 3D space.
		/// Default: 0.0.
		/// </summary>
		// Token: 0x0600AF07 RID: 44807 RVA: 0x000F804B File Offset: 0x000F624B
		public virtual void SetMajorRangeStart(double _arg)
		{
			vtkAxisActor.vtkAxisActor_SetMajorRangeStart_180(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AF08 RID: 44808
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetMajorStart_181(HandleRef pThis, int axis, double value);

		/// <summary>
		/// Set/Get the starting position for minor and major tick points,
		/// and the delta values that determine their spacing.
		/// </summary>
		// Token: 0x0600AF09 RID: 44809 RVA: 0x000F805B File Offset: 0x000F625B
		public void SetMajorStart(int axis, double value)
		{
			vtkAxisActor.vtkAxisActor_SetMajorStart_181(base.GetCppThis(), axis, value);
		}

		// Token: 0x0600AF0A RID: 44810
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetMajorTickSize_182(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the size of major tick marks.
		/// Default: 1.0.
		/// </summary>
		// Token: 0x0600AF0B RID: 44811 RVA: 0x000F806C File Offset: 0x000F626C
		public virtual void SetMajorTickSize(double _arg)
		{
			vtkAxisActor.vtkAxisActor_SetMajorTickSize_182(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AF0C RID: 44812
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetMinorRangeStart_183(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the starting position for minor and major tick points on
		/// the range. The range and the position need not be identical. ie the displayed
		/// values need not match the actual positions in 3D space.
		/// Default: 0.0.
		/// </summary>
		// Token: 0x0600AF0D RID: 44813 RVA: 0x000F807C File Offset: 0x000F627C
		public virtual void SetMinorRangeStart(double _arg)
		{
			vtkAxisActor.vtkAxisActor_SetMinorRangeStart_183(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AF0E RID: 44814
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetMinorStart_184(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the starting position for minor and major tick points,
		/// and the delta values that determine their spacing.
		/// </summary>
		// Token: 0x0600AF0F RID: 44815 RVA: 0x000F808C File Offset: 0x000F628C
		public virtual void SetMinorStart(double _arg)
		{
			vtkAxisActor.vtkAxisActor_SetMinorStart_184(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AF10 RID: 44816
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetMinorTickSize_185(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the size of minor tick marks.
		/// Default: 0.5.
		/// </summary>
		// Token: 0x0600AF11 RID: 44817 RVA: 0x000F809C File Offset: 0x000F629C
		public virtual void SetMinorTickSize(double _arg)
		{
			vtkAxisActor.vtkAxisActor_SetMinorTickSize_185(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AF12 RID: 44818
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetMinorTicksVisible_186(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get the flag that controls whether the minor ticks are visible.
		/// Default: true.
		/// </summary>
		// Token: 0x0600AF13 RID: 44819 RVA: 0x000F80AC File Offset: 0x000F62AC
		public virtual void SetMinorTicksVisible(bool _arg)
		{
			vtkAxisActor.vtkAxisActor_SetMinorTicksVisible_186(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600AF14 RID: 44820
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetPoint1_187(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Specify the position of the first point defining the axis.
		/// </summary>
		// Token: 0x0600AF15 RID: 44821 RVA: 0x000F80C4 File Offset: 0x000F62C4
		public virtual void SetPoint1(IntPtr x)
		{
			vtkAxisActor.vtkAxisActor_SetPoint1_187(base.GetCppThis(), x);
		}

		// Token: 0x0600AF16 RID: 44822
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetPoint1_188(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Specify the position of the first point defining the axis.
		/// </summary>
		// Token: 0x0600AF17 RID: 44823 RVA: 0x000F80D4 File Offset: 0x000F62D4
		public virtual void SetPoint1(double x, double y, double z)
		{
			vtkAxisActor.vtkAxisActor_SetPoint1_188(base.GetCppThis(), x, y, z);
		}

		// Token: 0x0600AF18 RID: 44824
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetPoint2_189(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Specify the position of the second point defining the axis.
		/// </summary>
		// Token: 0x0600AF19 RID: 44825 RVA: 0x000F80E6 File Offset: 0x000F62E6
		public virtual void SetPoint2(IntPtr x)
		{
			vtkAxisActor.vtkAxisActor_SetPoint2_189(base.GetCppThis(), x);
		}

		// Token: 0x0600AF1A RID: 44826
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetPoint2_190(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Specify the position of the second point defining the axis.
		/// </summary>
		// Token: 0x0600AF1B RID: 44827 RVA: 0x000F80F6 File Offset: 0x000F62F6
		public virtual void SetPoint2(double x, double y, double z)
		{
			vtkAxisActor.vtkAxisActor_SetPoint2_190(base.GetCppThis(), x, y, z);
		}

		// Token: 0x0600AF1C RID: 44828
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetRange_191(HandleRef pThis, double _arg1, double _arg2);

		/// <summary>
		/// Specify the (min,max) axis range. This will be used in the generation
		/// of labels, if labels are visible.
		/// Default: (0.0, 1.0).
		/// </summary>
		// Token: 0x0600AF1D RID: 44829 RVA: 0x000F8108 File Offset: 0x000F6308
		public virtual void SetRange(double _arg1, double _arg2)
		{
			vtkAxisActor.vtkAxisActor_SetRange_191(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600AF1E RID: 44830
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetRange_192(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify the (min,max) axis range. This will be used in the generation
		/// of labels, if labels are visible.
		/// Default: (0.0, 1.0).
		/// </summary>
		// Token: 0x0600AF1F RID: 44831 RVA: 0x000F8119 File Offset: 0x000F6319
		public void SetRange(IntPtr _arg)
		{
			vtkAxisActor.vtkAxisActor_SetRange_192(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AF20 RID: 44832
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetSaveTitlePosition_193(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get whether title position must be saved in 2D mode.
		/// Default: 0.
		/// </summary>
		// Token: 0x0600AF21 RID: 44833 RVA: 0x000F8129 File Offset: 0x000F6329
		public virtual void SetSaveTitlePosition(int _arg)
		{
			vtkAxisActor.vtkAxisActor_SetSaveTitlePosition_193(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AF22 RID: 44834
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetScreenSize_194(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get size factor for text, used for offsets.
		/// Default: 10.0.
		/// </summary>
		// Token: 0x0600AF23 RID: 44835 RVA: 0x000F8139 File Offset: 0x000F6339
		public virtual void SetScreenSize(double _arg)
		{
			vtkAxisActor.vtkAxisActor_SetScreenSize_194(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AF24 RID: 44836
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetTickLocation_195(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the location of the ticks.
		/// Inside: tick end toward positive direction of perpendicular axes.
		/// Outside: tick end toward negative direction of perpendicular axes.
		/// Default: VTK_TICKS_INSIDE.
		/// </summary>
		// Token: 0x0600AF25 RID: 44837 RVA: 0x000F8149 File Offset: 0x000F6349
		public virtual void SetTickLocation(int _arg)
		{
			vtkAxisActor.vtkAxisActor_SetTickLocation_195(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AF26 RID: 44838
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetTickLocationToBoth_196(HandleRef pThis);

		/// <summary>
		/// Set/Get the location of the ticks.
		/// Inside: tick end toward positive direction of perpendicular axes.
		/// Outside: tick end toward negative direction of perpendicular axes.
		/// Default: VTK_TICKS_INSIDE.
		/// </summary>
		// Token: 0x0600AF27 RID: 44839 RVA: 0x000F8159 File Offset: 0x000F6359
		public void SetTickLocationToBoth()
		{
			vtkAxisActor.vtkAxisActor_SetTickLocationToBoth_196(base.GetCppThis());
		}

		// Token: 0x0600AF28 RID: 44840
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetTickLocationToInside_197(HandleRef pThis);

		/// <summary>
		/// Set/Get the location of the ticks.
		/// Inside: tick end toward positive direction of perpendicular axes.
		/// Outside: tick end toward negative direction of perpendicular axes.
		/// Default: VTK_TICKS_INSIDE.
		/// </summary>
		// Token: 0x0600AF29 RID: 44841 RVA: 0x000F8168 File Offset: 0x000F6368
		public void SetTickLocationToInside()
		{
			vtkAxisActor.vtkAxisActor_SetTickLocationToInside_197(base.GetCppThis());
		}

		// Token: 0x0600AF2A RID: 44842
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetTickLocationToOutside_198(HandleRef pThis);

		/// <summary>
		/// Set/Get the location of the ticks.
		/// Inside: tick end toward positive direction of perpendicular axes.
		/// Outside: tick end toward negative direction of perpendicular axes.
		/// Default: VTK_TICKS_INSIDE.
		/// </summary>
		// Token: 0x0600AF2B RID: 44843 RVA: 0x000F8177 File Offset: 0x000F6377
		public void SetTickLocationToOutside()
		{
			vtkAxisActor.vtkAxisActor_SetTickLocationToOutside_198(base.GetCppThis());
		}

		// Token: 0x0600AF2C RID: 44844
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetTickVisibility_199(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get visibility of the axis major tick marks.
		/// Default: true.
		/// </summary>
		// Token: 0x0600AF2D RID: 44845 RVA: 0x000F8186 File Offset: 0x000F6386
		public virtual void SetTickVisibility(bool _arg)
		{
			vtkAxisActor.vtkAxisActor_SetTickVisibility_199(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600AF2E RID: 44846
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetTitle_200(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string t);

		/// <summary>
		/// Set/Get the title of the axis actor.
		/// </summary>
		// Token: 0x0600AF2F RID: 44847 RVA: 0x000F819E File Offset: 0x000F639E
		public void SetTitle(string t)
		{
			vtkAxisActor.vtkAxisActor_SetTitle_200(base.GetCppThis(), t);
		}

		// Token: 0x0600AF30 RID: 44848
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetTitleAlignLocation_201(HandleRef pThis, int location);

		/// <summary>
		/// Get/Set the alignment of the title related to the axis.
		/// Possible Alignment: VTK_ALIGN_TOP, VTK_ALIGN_BOTTOM, VTK_ALIGN_POINT1, VTK_ALIGN_POINT2.
		/// Default: VTK_ALIGN_BOTTOM.
		/// </summary>
		// Token: 0x0600AF31 RID: 44849 RVA: 0x000F81AE File Offset: 0x000F63AE
		public virtual void SetTitleAlignLocation(int location)
		{
			vtkAxisActor.vtkAxisActor_SetTitleAlignLocation_201(base.GetCppThis(), location);
		}

		// Token: 0x0600AF32 RID: 44850
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetTitleOffset_202(HandleRef pThis, double _arg1, double _arg2);

		/// <summary>
		/// Set/Get the 2D-offsets used to position title texts.
		/// X-component is applied only when not center aligned
		/// Center aligned &lt;=&gt; VTK_ALIGN_TOP and VTK_ALIGN_BOTTOM
		/// Y-component is the same than other offsets.
		/// Default: (20.0, 20.0).
		/// </summary>
		// Token: 0x0600AF33 RID: 44851 RVA: 0x000F81BE File Offset: 0x000F63BE
		public virtual void SetTitleOffset(double _arg1, double _arg2)
		{
			vtkAxisActor.vtkAxisActor_SetTitleOffset_202(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600AF34 RID: 44852
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetTitleOffset_203(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the 2D-offsets used to position title texts.
		/// X-component is applied only when not center aligned
		/// Center aligned &lt;=&gt; VTK_ALIGN_TOP and VTK_ALIGN_BOTTOM
		/// Y-component is the same than other offsets.
		/// Default: (20.0, 20.0).
		/// </summary>
		// Token: 0x0600AF35 RID: 44853 RVA: 0x000F81CF File Offset: 0x000F63CF
		public void SetTitleOffset(IntPtr _arg)
		{
			vtkAxisActor.vtkAxisActor_SetTitleOffset_203(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AF36 RID: 44854
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetTitleScale_204(HandleRef pThis, double scale);

		/// <summary>
		/// Release any graphics resources that are being consumed by this actor.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x0600AF37 RID: 44855 RVA: 0x000F81DF File Offset: 0x000F63DF
		public void SetTitleScale(double scale)
		{
			vtkAxisActor.vtkAxisActor_SetTitleScale_204(base.GetCppThis(), scale);
		}

		// Token: 0x0600AF38 RID: 44856
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetTitleTextProperty_205(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Set/Get the axis title text property.
		/// </summary>
		// Token: 0x0600AF39 RID: 44857 RVA: 0x000F81F0 File Offset: 0x000F63F0
		public virtual void SetTitleTextProperty(vtkTextProperty p)
		{
			vtkAxisActor.vtkAxisActor_SetTitleTextProperty_205(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x0600AF3A RID: 44858
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetTitleVisibility_206(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get visibility of the axis title.
		/// Default: true.
		/// </summary>
		// Token: 0x0600AF3B RID: 44859 RVA: 0x000F821F File Offset: 0x000F641F
		public virtual void SetTitleVisibility(bool _arg)
		{
			vtkAxisActor.vtkAxisActor_SetTitleVisibility_206(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600AF3C RID: 44860
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetUse2DMode_207(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get the 2D mode.
		/// Default: false.
		/// </summary>
		// Token: 0x0600AF3D RID: 44861 RVA: 0x000F8237 File Offset: 0x000F6437
		public virtual void SetUse2DMode(bool _arg)
		{
			vtkAxisActor.vtkAxisActor_SetUse2DMode_207(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600AF3E RID: 44862
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetUseTextActor3D_208(HandleRef pThis, byte _arg);

		/// <summary>
		/// Render text as polygons (vtkVectorText) or as sprites (vtkTextActor3D).
		/// In 2D mode, the value is ignored and text is rendered as vtkTextActor.
		/// False(0) by default.
		/// See Also:
		/// GetUse2DMode(), SetUse2DMode
		/// </summary>
		// Token: 0x0600AF3F RID: 44863 RVA: 0x000F824F File Offset: 0x000F644F
		public virtual void SetUseTextActor3D(bool _arg)
		{
			vtkAxisActor.vtkAxisActor_SetUseTextActor3D_208(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600AF40 RID: 44864
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_SetVerticalOffsetXTitle2D_209(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the 2D mode the vertical offset for X title in 2D mode.
		/// Default: -40.0.
		/// </summary>
		// Token: 0x0600AF41 RID: 44865 RVA: 0x000F8267 File Offset: 0x000F6467
		public virtual void SetVerticalOffsetXTitle2D(double _arg)
		{
			vtkAxisActor.vtkAxisActor_SetVerticalOffsetXTitle2D_209(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AF42 RID: 44866
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_TickVisibilityOff_210(HandleRef pThis);

		/// <summary>
		/// Set/Get visibility of the axis major tick marks.
		/// Default: true.
		/// </summary>
		// Token: 0x0600AF43 RID: 44867 RVA: 0x000F8277 File Offset: 0x000F6477
		public virtual void TickVisibilityOff()
		{
			vtkAxisActor.vtkAxisActor_TickVisibilityOff_210(base.GetCppThis());
		}

		// Token: 0x0600AF44 RID: 44868
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_TickVisibilityOn_211(HandleRef pThis);

		/// <summary>
		/// Set/Get visibility of the axis major tick marks.
		/// Default: true.
		/// </summary>
		// Token: 0x0600AF45 RID: 44869 RVA: 0x000F8286 File Offset: 0x000F6486
		public virtual void TickVisibilityOn()
		{
			vtkAxisActor.vtkAxisActor_TickVisibilityOn_211(base.GetCppThis());
		}

		// Token: 0x0600AF46 RID: 44870
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_TitleVisibilityOff_212(HandleRef pThis);

		/// <summary>
		/// Set/Get visibility of the axis title.
		/// Default: true.
		/// </summary>
		// Token: 0x0600AF47 RID: 44871 RVA: 0x000F8295 File Offset: 0x000F6495
		public virtual void TitleVisibilityOff()
		{
			vtkAxisActor.vtkAxisActor_TitleVisibilityOff_212(base.GetCppThis());
		}

		// Token: 0x0600AF48 RID: 44872
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor_TitleVisibilityOn_213(HandleRef pThis);

		/// <summary>
		/// Set/Get visibility of the axis title.
		/// Default: true.
		/// </summary>
		// Token: 0x0600AF49 RID: 44873 RVA: 0x000F82A4 File Offset: 0x000F64A4
		public virtual void TitleVisibilityOn()
		{
			vtkAxisActor.vtkAxisActor_TitleVisibilityOn_213(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000DA3 RID: 3491
		public new const string MRFullTypeName = "Kitware.VTK.vtkAxisActor";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000DA4 RID: 3492
		public new static readonly string MRClassNameKey = "class vtkAxisActor";

		/// <summary>
		/// Set/Get visibility of the axis detached exponent.
		/// Default: false.
		/// </summary>
		// Token: 0x020003B6 RID: 950
		public enum AlignLocation
		{
			/// <summary>enum member</summary>
			// Token: 0x04000DA6 RID: 3494
			VTK_ALIGN_BOTTOM = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000DA7 RID: 3495
			VTK_ALIGN_POINT1,
			/// <summary>enum member</summary>
			// Token: 0x04000DA8 RID: 3496
			VTK_ALIGN_POINT2,
			/// <summary>enum member</summary>
			// Token: 0x04000DA9 RID: 3497
			VTK_ALIGN_TOP = 0
		}

		/// <summary>
		/// Set/Get the type of this axis.
		/// Default: VTK_AXIS_TYPE_X.
		/// </summary>
		// Token: 0x020003B7 RID: 951
		public enum AxisPosition
		{
			/// <summary>enum member</summary>
			// Token: 0x04000DAB RID: 3499
			VTK_AXIS_POS_MAXMAX = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000DAC RID: 3500
			VTK_AXIS_POS_MAXMIN,
			/// <summary>enum member</summary>
			// Token: 0x04000DAD RID: 3501
			VTK_AXIS_POS_MINMAX = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000DAE RID: 3502
			VTK_AXIS_POS_MINMIN = 0
		}

		/// <summary>
		/// Set/Get whether gridpolys should be drawn.
		/// Default: false.
		/// </summary>
		// Token: 0x020003B8 RID: 952
		public enum AxisType
		{
			/// <summary>enum member</summary>
			// Token: 0x04000DB0 RID: 3504
			VTK_AXIS_TYPE_X,
			/// <summary>enum member</summary>
			// Token: 0x04000DB1 RID: 3505
			VTK_AXIS_TYPE_Y,
			/// <summary>enum member</summary>
			// Token: 0x04000DB2 RID: 3506
			VTK_AXIS_TYPE_Z
		}

		/// <summary>
		/// Set/Get the size of minor tick marks.
		/// Default: 0.5.
		/// </summary>
		// Token: 0x020003B9 RID: 953
		public enum TickLocation
		{
			/// <summary>enum member</summary>
			// Token: 0x04000DB4 RID: 3508
			VTK_TICKS_BOTH = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000DB5 RID: 3509
			VTK_TICKS_INSIDE = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000DB6 RID: 3510
			VTK_TICKS_OUTSIDE
		}
	}
}
