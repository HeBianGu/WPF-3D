using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSliderRepresentation
	/// </summary>
	/// <remarks>
	///    abstract class defines the representation for a vtkSliderWidget
	///
	/// This abstract class is used to specify how the vtkSliderWidget should
	/// interact with representations of the vtkSliderWidget. This class may be
	/// subclassed so that alternative representations can be created. The class
	/// defines an API, and a default implementation, that the vtkSliderWidget
	/// interacts with to render itself in the scene.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkSliderWidget
	/// </seealso>
	// Token: 0x020002F0 RID: 752
	public abstract class vtkSliderRepresentation : vtkWidgetRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060086DB RID: 34523 RVA: 0x000C09D9 File Offset: 0x000BEBD9
		static vtkSliderRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSliderRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSliderRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060086DC RID: 34524 RVA: 0x000C0A01 File Offset: 0x000BEC01
		public vtkSliderRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060086DD RID: 34525 RVA: 0x000C0A0F File Offset: 0x000BEC0F
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060086DE RID: 34526
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSliderRepresentation_GetCurrentT_01(HandleRef pThis);

		/// <summary>
		/// Methods to interface with the vtkSliderWidget. Subclasses of this class
		/// actually do something.
		/// </summary>
		// Token: 0x060086DF RID: 34527 RVA: 0x000C0A1C File Offset: 0x000BEC1C
		public virtual double GetCurrentT()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetCurrentT_01(base.GetCppThis());
		}

		// Token: 0x060086E0 RID: 34528
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSliderRepresentation_GetEndCapLength_02(HandleRef pThis);

		/// <summary>
		/// Specify the length of each end cap (in normalized coordinates
		/// [0.0,0.25]). By default the length is 0.025. If the end cap length
		/// is set to 0.0, then the end cap will not display at all.
		/// </summary>
		// Token: 0x060086E1 RID: 34529 RVA: 0x000C0A3C File Offset: 0x000BEC3C
		public virtual double GetEndCapLength()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetEndCapLength_02(base.GetCppThis());
		}

		// Token: 0x060086E2 RID: 34530
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSliderRepresentation_GetEndCapLengthMaxValue_03(HandleRef pThis);

		/// <summary>
		/// Specify the length of each end cap (in normalized coordinates
		/// [0.0,0.25]). By default the length is 0.025. If the end cap length
		/// is set to 0.0, then the end cap will not display at all.
		/// </summary>
		// Token: 0x060086E3 RID: 34531 RVA: 0x000C0A5C File Offset: 0x000BEC5C
		public virtual double GetEndCapLengthMaxValue()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetEndCapLengthMaxValue_03(base.GetCppThis());
		}

		// Token: 0x060086E4 RID: 34532
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSliderRepresentation_GetEndCapLengthMinValue_04(HandleRef pThis);

		/// <summary>
		/// Specify the length of each end cap (in normalized coordinates
		/// [0.0,0.25]). By default the length is 0.025. If the end cap length
		/// is set to 0.0, then the end cap will not display at all.
		/// </summary>
		// Token: 0x060086E5 RID: 34533 RVA: 0x000C0A7C File Offset: 0x000BEC7C
		public virtual double GetEndCapLengthMinValue()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetEndCapLengthMinValue_04(base.GetCppThis());
		}

		// Token: 0x060086E6 RID: 34534
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSliderRepresentation_GetEndCapWidth_05(HandleRef pThis);

		/// <summary>
		/// Specify the width of each end cap (in normalized coordinates
		/// [0.0,0.25]). By default the width is twice the tube width.
		/// </summary>
		// Token: 0x060086E7 RID: 34535 RVA: 0x000C0A9C File Offset: 0x000BEC9C
		public virtual double GetEndCapWidth()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetEndCapWidth_05(base.GetCppThis());
		}

		// Token: 0x060086E8 RID: 34536
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSliderRepresentation_GetEndCapWidthMaxValue_06(HandleRef pThis);

		/// <summary>
		/// Specify the width of each end cap (in normalized coordinates
		/// [0.0,0.25]). By default the width is twice the tube width.
		/// </summary>
		// Token: 0x060086E9 RID: 34537 RVA: 0x000C0ABC File Offset: 0x000BECBC
		public virtual double GetEndCapWidthMaxValue()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetEndCapWidthMaxValue_06(base.GetCppThis());
		}

		// Token: 0x060086EA RID: 34538
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSliderRepresentation_GetEndCapWidthMinValue_07(HandleRef pThis);

		/// <summary>
		/// Specify the width of each end cap (in normalized coordinates
		/// [0.0,0.25]). By default the width is twice the tube width.
		/// </summary>
		// Token: 0x060086EB RID: 34539 RVA: 0x000C0ADC File Offset: 0x000BECDC
		public virtual double GetEndCapWidthMinValue()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetEndCapWidthMinValue_07(base.GetCppThis());
		}

		// Token: 0x060086EC RID: 34540
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSliderRepresentation_GetLabelFormat_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the format with which to print the slider value.
		/// </summary>
		// Token: 0x060086ED RID: 34541 RVA: 0x000C0AFC File Offset: 0x000BECFC
		public virtual string GetLabelFormat()
		{
			string s = Marshal.PtrToStringAnsi(vtkSliderRepresentation.vtkSliderRepresentation_GetLabelFormat_08(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060086EE RID: 34542
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSliderRepresentation_GetLabelHeight_09(HandleRef pThis);

		/// <summary>
		/// Specify the relative height of the label as compared to the length of the
		/// slider.
		/// </summary>
		// Token: 0x060086EF RID: 34543 RVA: 0x000C0B38 File Offset: 0x000BED38
		public virtual double GetLabelHeight()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetLabelHeight_09(base.GetCppThis());
		}

		// Token: 0x060086F0 RID: 34544
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSliderRepresentation_GetLabelHeightMaxValue_10(HandleRef pThis);

		/// <summary>
		/// Specify the relative height of the label as compared to the length of the
		/// slider.
		/// </summary>
		// Token: 0x060086F1 RID: 34545 RVA: 0x000C0B58 File Offset: 0x000BED58
		public virtual double GetLabelHeightMaxValue()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetLabelHeightMaxValue_10(base.GetCppThis());
		}

		// Token: 0x060086F2 RID: 34546
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSliderRepresentation_GetLabelHeightMinValue_11(HandleRef pThis);

		/// <summary>
		/// Specify the relative height of the label as compared to the length of the
		/// slider.
		/// </summary>
		// Token: 0x060086F3 RID: 34547 RVA: 0x000C0B78 File Offset: 0x000BED78
		public virtual double GetLabelHeightMinValue()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetLabelHeightMinValue_11(base.GetCppThis());
		}

		// Token: 0x060086F4 RID: 34548
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSliderRepresentation_GetMaximumValue_12(HandleRef pThis);

		/// <summary>
		/// Set the current maximum value that the slider can take. Setting the
		/// maximum value less than the minimum value will cause the minimum
		/// value to change to (maximum value - 1).
		/// </summary>
		// Token: 0x060086F5 RID: 34549 RVA: 0x000C0B98 File Offset: 0x000BED98
		public virtual double GetMaximumValue()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetMaximumValue_12(base.GetCppThis());
		}

		// Token: 0x060086F6 RID: 34550
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSliderRepresentation_GetMinimumValue_13(HandleRef pThis);

		/// <summary>
		/// Set the current minimum value that the slider can take. Setting the
		/// minimum value greater than the maximum value will cause the maximum
		/// value to grow to (minimum value + 1).
		/// </summary>
		// Token: 0x060086F7 RID: 34551 RVA: 0x000C0BB8 File Offset: 0x000BEDB8
		public virtual double GetMinimumValue()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetMinimumValue_13(base.GetCppThis());
		}

		// Token: 0x060086F8 RID: 34552
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSliderRepresentation_GetNumberOfGenerationsFromBase_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x060086F9 RID: 34553 RVA: 0x000C0BD8 File Offset: 0x000BEDD8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetNumberOfGenerationsFromBase_14(base.GetCppThis(), type);
		}

		// Token: 0x060086FA RID: 34554
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSliderRepresentation_GetNumberOfGenerationsFromBaseType_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x060086FB RID: 34555 RVA: 0x000C0BF8 File Offset: 0x000BEDF8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetNumberOfGenerationsFromBaseType_15(type);
		}

		// Token: 0x060086FC RID: 34556
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSliderRepresentation_GetPickedT_16(HandleRef pThis);

		/// <summary>
		/// Methods to interface with the vtkSliderWidget. Subclasses of this class
		/// actually do something.
		/// </summary>
		// Token: 0x060086FD RID: 34557 RVA: 0x000C0C14 File Offset: 0x000BEE14
		public virtual double GetPickedT()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetPickedT_16(base.GetCppThis());
		}

		// Token: 0x060086FE RID: 34558
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSliderRepresentation_GetShowSliderLabel_17(HandleRef pThis);

		/// <summary>
		/// Indicate whether the slider text label should be displayed. This is
		/// a number corresponding to the current Value of this widget.
		/// </summary>
		// Token: 0x060086FF RID: 34559 RVA: 0x000C0C34 File Offset: 0x000BEE34
		public virtual int GetShowSliderLabel()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetShowSliderLabel_17(base.GetCppThis());
		}

		// Token: 0x06008700 RID: 34560
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSliderRepresentation_GetSliderLength_18(HandleRef pThis);

		/// <summary>
		/// Specify the length of the slider shape (in normalized display coordinates
		/// [0.01,0.5]). The slider length by default is 0.05.
		/// </summary>
		// Token: 0x06008701 RID: 34561 RVA: 0x000C0C54 File Offset: 0x000BEE54
		public virtual double GetSliderLength()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetSliderLength_18(base.GetCppThis());
		}

		// Token: 0x06008702 RID: 34562
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSliderRepresentation_GetSliderLengthMaxValue_19(HandleRef pThis);

		/// <summary>
		/// Specify the length of the slider shape (in normalized display coordinates
		/// [0.01,0.5]). The slider length by default is 0.05.
		/// </summary>
		// Token: 0x06008703 RID: 34563 RVA: 0x000C0C74 File Offset: 0x000BEE74
		public virtual double GetSliderLengthMaxValue()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetSliderLengthMaxValue_19(base.GetCppThis());
		}

		// Token: 0x06008704 RID: 34564
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSliderRepresentation_GetSliderLengthMinValue_20(HandleRef pThis);

		/// <summary>
		/// Specify the length of the slider shape (in normalized display coordinates
		/// [0.01,0.5]). The slider length by default is 0.05.
		/// </summary>
		// Token: 0x06008705 RID: 34565 RVA: 0x000C0C94 File Offset: 0x000BEE94
		public virtual double GetSliderLengthMinValue()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetSliderLengthMinValue_20(base.GetCppThis());
		}

		// Token: 0x06008706 RID: 34566
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSliderRepresentation_GetSliderWidth_21(HandleRef pThis);

		/// <summary>
		/// Set the width of the slider in the directions orthogonal to the
		/// slider axis. Using this it is possible to create ellipsoidal and hockey
		/// puck sliders (in some subclasses). By default the width is 0.05.
		/// </summary>
		// Token: 0x06008707 RID: 34567 RVA: 0x000C0CB4 File Offset: 0x000BEEB4
		public virtual double GetSliderWidth()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetSliderWidth_21(base.GetCppThis());
		}

		// Token: 0x06008708 RID: 34568
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSliderRepresentation_GetSliderWidthMaxValue_22(HandleRef pThis);

		/// <summary>
		/// Set the width of the slider in the directions orthogonal to the
		/// slider axis. Using this it is possible to create ellipsoidal and hockey
		/// puck sliders (in some subclasses). By default the width is 0.05.
		/// </summary>
		// Token: 0x06008709 RID: 34569 RVA: 0x000C0CD4 File Offset: 0x000BEED4
		public virtual double GetSliderWidthMaxValue()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetSliderWidthMaxValue_22(base.GetCppThis());
		}

		// Token: 0x0600870A RID: 34570
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSliderRepresentation_GetSliderWidthMinValue_23(HandleRef pThis);

		/// <summary>
		/// Set the width of the slider in the directions orthogonal to the
		/// slider axis. Using this it is possible to create ellipsoidal and hockey
		/// puck sliders (in some subclasses). By default the width is 0.05.
		/// </summary>
		// Token: 0x0600870B RID: 34571 RVA: 0x000C0CF4 File Offset: 0x000BEEF4
		public virtual double GetSliderWidthMinValue()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetSliderWidthMinValue_23(base.GetCppThis());
		}

		// Token: 0x0600870C RID: 34572
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSliderRepresentation_GetTitleHeight_24(HandleRef pThis);

		/// <summary>
		/// Specify the relative height of the title as compared to the length of the
		/// slider.
		/// </summary>
		// Token: 0x0600870D RID: 34573 RVA: 0x000C0D14 File Offset: 0x000BEF14
		public virtual double GetTitleHeight()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetTitleHeight_24(base.GetCppThis());
		}

		// Token: 0x0600870E RID: 34574
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSliderRepresentation_GetTitleHeightMaxValue_25(HandleRef pThis);

		/// <summary>
		/// Specify the relative height of the title as compared to the length of the
		/// slider.
		/// </summary>
		// Token: 0x0600870F RID: 34575 RVA: 0x000C0D34 File Offset: 0x000BEF34
		public virtual double GetTitleHeightMaxValue()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetTitleHeightMaxValue_25(base.GetCppThis());
		}

		// Token: 0x06008710 RID: 34576
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSliderRepresentation_GetTitleHeightMinValue_26(HandleRef pThis);

		/// <summary>
		/// Specify the relative height of the title as compared to the length of the
		/// slider.
		/// </summary>
		// Token: 0x06008711 RID: 34577 RVA: 0x000C0D54 File Offset: 0x000BEF54
		public virtual double GetTitleHeightMinValue()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetTitleHeightMinValue_26(base.GetCppThis());
		}

		// Token: 0x06008712 RID: 34578
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSliderRepresentation_GetTitleText_27(HandleRef pThis);

		/// <summary>
		/// Specify the label text for this widget. If the value is not set, or set
		/// to the empty string "", then the label text is not displayed.
		/// </summary>
		// Token: 0x06008713 RID: 34579 RVA: 0x000C0D74 File Offset: 0x000BEF74
		public virtual string GetTitleText()
		{
			string s = Marshal.PtrToStringAnsi(vtkSliderRepresentation.vtkSliderRepresentation_GetTitleText_27(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06008714 RID: 34580
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSliderRepresentation_GetTubeWidth_28(HandleRef pThis);

		/// <summary>
		/// Set the width of the tube (in normalized display coordinates) on which
		/// the slider moves. By default the width is 0.05.
		/// </summary>
		// Token: 0x06008715 RID: 34581 RVA: 0x000C0DB0 File Offset: 0x000BEFB0
		public virtual double GetTubeWidth()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetTubeWidth_28(base.GetCppThis());
		}

		// Token: 0x06008716 RID: 34582
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSliderRepresentation_GetTubeWidthMaxValue_29(HandleRef pThis);

		/// <summary>
		/// Set the width of the tube (in normalized display coordinates) on which
		/// the slider moves. By default the width is 0.05.
		/// </summary>
		// Token: 0x06008717 RID: 34583 RVA: 0x000C0DD0 File Offset: 0x000BEFD0
		public virtual double GetTubeWidthMaxValue()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetTubeWidthMaxValue_29(base.GetCppThis());
		}

		// Token: 0x06008718 RID: 34584
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSliderRepresentation_GetTubeWidthMinValue_30(HandleRef pThis);

		/// <summary>
		/// Set the width of the tube (in normalized display coordinates) on which
		/// the slider moves. By default the width is 0.05.
		/// </summary>
		// Token: 0x06008719 RID: 34585 RVA: 0x000C0DF0 File Offset: 0x000BEFF0
		public virtual double GetTubeWidthMinValue()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetTubeWidthMinValue_30(base.GetCppThis());
		}

		// Token: 0x0600871A RID: 34586
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSliderRepresentation_GetValue_31(HandleRef pThis);

		/// <summary>
		/// Specify the current value for the widget. The value should lie between
		/// the minimum and maximum values.
		/// </summary>
		// Token: 0x0600871B RID: 34587 RVA: 0x000C0E10 File Offset: 0x000BF010
		public virtual double GetValue()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetValue_31(base.GetCppThis());
		}

		// Token: 0x0600871C RID: 34588
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSliderRepresentation_IsA_32(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x0600871D RID: 34589 RVA: 0x000C0E30 File Offset: 0x000BF030
		public override int IsA(string type)
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_IsA_32(base.GetCppThis(), type);
		}

		// Token: 0x0600871E RID: 34590
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSliderRepresentation_IsTypeOf_33([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x0600871F RID: 34591 RVA: 0x000C0E50 File Offset: 0x000BF050
		public new static int IsTypeOf(string type)
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_IsTypeOf_33(type);
		}

		// Token: 0x06008720 RID: 34592
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSliderRepresentation_NewInstance_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06008721 RID: 34593 RVA: 0x000C0E6C File Offset: 0x000BF06C
		public new vtkSliderRepresentation NewInstance()
		{
			vtkSliderRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSliderRepresentation.vtkSliderRepresentation_NewInstance_34(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSliderRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06008722 RID: 34594
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSliderRepresentation_SafeDownCast_35(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06008723 RID: 34595 RVA: 0x000C0EC8 File Offset: 0x000BF0C8
		public new static vtkSliderRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkSliderRepresentation vtkSliderRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSliderRepresentation.vtkSliderRepresentation_SafeDownCast_35((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008724 RID: 34596
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSliderRepresentation_SetEndCapLength_36(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the length of each end cap (in normalized coordinates
		/// [0.0,0.25]). By default the length is 0.025. If the end cap length
		/// is set to 0.0, then the end cap will not display at all.
		/// </summary>
		// Token: 0x06008725 RID: 34597 RVA: 0x000C0F47 File Offset: 0x000BF147
		public virtual void SetEndCapLength(double _arg)
		{
			vtkSliderRepresentation.vtkSliderRepresentation_SetEndCapLength_36(base.GetCppThis(), _arg);
		}

		// Token: 0x06008726 RID: 34598
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSliderRepresentation_SetEndCapWidth_37(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the width of each end cap (in normalized coordinates
		/// [0.0,0.25]). By default the width is twice the tube width.
		/// </summary>
		// Token: 0x06008727 RID: 34599 RVA: 0x000C0F57 File Offset: 0x000BF157
		public virtual void SetEndCapWidth(double _arg)
		{
			vtkSliderRepresentation.vtkSliderRepresentation_SetEndCapWidth_37(base.GetCppThis(), _arg);
		}

		// Token: 0x06008728 RID: 34600
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSliderRepresentation_SetLabelFormat_38(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the format with which to print the slider value.
		/// </summary>
		// Token: 0x06008729 RID: 34601 RVA: 0x000C0F67 File Offset: 0x000BF167
		public virtual void SetLabelFormat(string _arg)
		{
			vtkSliderRepresentation.vtkSliderRepresentation_SetLabelFormat_38(base.GetCppThis(), _arg);
		}

		// Token: 0x0600872A RID: 34602
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSliderRepresentation_SetLabelHeight_39(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the relative height of the label as compared to the length of the
		/// slider.
		/// </summary>
		// Token: 0x0600872B RID: 34603 RVA: 0x000C0F77 File Offset: 0x000BF177
		public virtual void SetLabelHeight(double _arg)
		{
			vtkSliderRepresentation.vtkSliderRepresentation_SetLabelHeight_39(base.GetCppThis(), _arg);
		}

		// Token: 0x0600872C RID: 34604
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSliderRepresentation_SetMaximumValue_40(HandleRef pThis, double value);

		/// <summary>
		/// Set the current maximum value that the slider can take. Setting the
		/// maximum value less than the minimum value will cause the minimum
		/// value to change to (maximum value - 1).
		/// </summary>
		// Token: 0x0600872D RID: 34605 RVA: 0x000C0F87 File Offset: 0x000BF187
		public void SetMaximumValue(double value)
		{
			vtkSliderRepresentation.vtkSliderRepresentation_SetMaximumValue_40(base.GetCppThis(), value);
		}

		// Token: 0x0600872E RID: 34606
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSliderRepresentation_SetMinimumValue_41(HandleRef pThis, double value);

		/// <summary>
		/// Set the current minimum value that the slider can take. Setting the
		/// minimum value greater than the maximum value will cause the maximum
		/// value to grow to (minimum value + 1).
		/// </summary>
		// Token: 0x0600872F RID: 34607 RVA: 0x000C0F97 File Offset: 0x000BF197
		public void SetMinimumValue(double value)
		{
			vtkSliderRepresentation.vtkSliderRepresentation_SetMinimumValue_41(base.GetCppThis(), value);
		}

		// Token: 0x06008730 RID: 34608
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSliderRepresentation_SetShowSliderLabel_42(HandleRef pThis, int _arg);

		/// <summary>
		/// Indicate whether the slider text label should be displayed. This is
		/// a number corresponding to the current Value of this widget.
		/// </summary>
		// Token: 0x06008731 RID: 34609 RVA: 0x000C0FA7 File Offset: 0x000BF1A7
		public virtual void SetShowSliderLabel(int _arg)
		{
			vtkSliderRepresentation.vtkSliderRepresentation_SetShowSliderLabel_42(base.GetCppThis(), _arg);
		}

		// Token: 0x06008732 RID: 34610
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSliderRepresentation_SetSliderLength_43(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the length of the slider shape (in normalized display coordinates
		/// [0.01,0.5]). The slider length by default is 0.05.
		/// </summary>
		// Token: 0x06008733 RID: 34611 RVA: 0x000C0FB7 File Offset: 0x000BF1B7
		public virtual void SetSliderLength(double _arg)
		{
			vtkSliderRepresentation.vtkSliderRepresentation_SetSliderLength_43(base.GetCppThis(), _arg);
		}

		// Token: 0x06008734 RID: 34612
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSliderRepresentation_SetSliderWidth_44(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the width of the slider in the directions orthogonal to the
		/// slider axis. Using this it is possible to create ellipsoidal and hockey
		/// puck sliders (in some subclasses). By default the width is 0.05.
		/// </summary>
		// Token: 0x06008735 RID: 34613 RVA: 0x000C0FC7 File Offset: 0x000BF1C7
		public virtual void SetSliderWidth(double _arg)
		{
			vtkSliderRepresentation.vtkSliderRepresentation_SetSliderWidth_44(base.GetCppThis(), _arg);
		}

		// Token: 0x06008736 RID: 34614
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSliderRepresentation_SetTitleHeight_45(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the relative height of the title as compared to the length of the
		/// slider.
		/// </summary>
		// Token: 0x06008737 RID: 34615 RVA: 0x000C0FD7 File Offset: 0x000BF1D7
		public virtual void SetTitleHeight(double _arg)
		{
			vtkSliderRepresentation.vtkSliderRepresentation_SetTitleHeight_45(base.GetCppThis(), _arg);
		}

		// Token: 0x06008738 RID: 34616
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSliderRepresentation_SetTitleText_46(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Specify the label text for this widget. If the value is not set, or set
		/// to the empty string "", then the label text is not displayed.
		/// </summary>
		// Token: 0x06008739 RID: 34617 RVA: 0x000C0FE7 File Offset: 0x000BF1E7
		public virtual void SetTitleText(string arg0)
		{
			vtkSliderRepresentation.vtkSliderRepresentation_SetTitleText_46(base.GetCppThis(), arg0);
		}

		// Token: 0x0600873A RID: 34618
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSliderRepresentation_SetTubeWidth_47(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the width of the tube (in normalized display coordinates) on which
		/// the slider moves. By default the width is 0.05.
		/// </summary>
		// Token: 0x0600873B RID: 34619 RVA: 0x000C0FF7 File Offset: 0x000BF1F7
		public virtual void SetTubeWidth(double _arg)
		{
			vtkSliderRepresentation.vtkSliderRepresentation_SetTubeWidth_47(base.GetCppThis(), _arg);
		}

		// Token: 0x0600873C RID: 34620
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSliderRepresentation_SetValue_48(HandleRef pThis, double value);

		/// <summary>
		/// Specify the current value for the widget. The value should lie between
		/// the minimum and maximum values.
		/// </summary>
		// Token: 0x0600873D RID: 34621 RVA: 0x000C1007 File Offset: 0x000BF207
		public void SetValue(double value)
		{
			vtkSliderRepresentation.vtkSliderRepresentation_SetValue_48(base.GetCppThis(), value);
		}

		// Token: 0x0600873E RID: 34622
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSliderRepresentation_ShowSliderLabelOff_49(HandleRef pThis);

		/// <summary>
		/// Indicate whether the slider text label should be displayed. This is
		/// a number corresponding to the current Value of this widget.
		/// </summary>
		// Token: 0x0600873F RID: 34623 RVA: 0x000C1017 File Offset: 0x000BF217
		public virtual void ShowSliderLabelOff()
		{
			vtkSliderRepresentation.vtkSliderRepresentation_ShowSliderLabelOff_49(base.GetCppThis());
		}

		// Token: 0x06008740 RID: 34624
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSliderRepresentation_ShowSliderLabelOn_50(HandleRef pThis);

		/// <summary>
		/// Indicate whether the slider text label should be displayed. This is
		/// a number corresponding to the current Value of this widget.
		/// </summary>
		// Token: 0x06008741 RID: 34625 RVA: 0x000C1026 File Offset: 0x000BF226
		public virtual void ShowSliderLabelOn()
		{
			vtkSliderRepresentation.vtkSliderRepresentation_ShowSliderLabelOn_50(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B63 RID: 2915
		public new const string MRFullTypeName = "Kitware.VTK.vtkSliderRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B64 RID: 2916
		public new static readonly string MRClassNameKey = "class vtkSliderRepresentation";

		/// <summary>
		/// Methods to interface with the vtkSliderWidget. Subclasses of this class
		/// actually do something.
		/// </summary>
		// Token: 0x020002F1 RID: 753
		public enum InteractionStateType
		{
			/// <summary>enum member</summary>
			// Token: 0x04000B66 RID: 2918
			LeftCap = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000B67 RID: 2919
			Outside = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000B68 RID: 2920
			RightCap = 3,
			/// <summary>enum member</summary>
			// Token: 0x04000B69 RID: 2921
			Slider,
			/// <summary>enum member</summary>
			// Token: 0x04000B6A RID: 2922
			Tube = 1
		}
	}
}
