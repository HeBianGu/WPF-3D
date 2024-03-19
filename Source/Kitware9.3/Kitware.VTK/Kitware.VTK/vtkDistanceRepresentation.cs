using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDistanceRepresentation
	/// </summary>
	/// <remarks>
	///    represent the vtkDistanceWidget
	///
	/// The vtkDistanceRepresentation is a superclass for various types of
	/// representations for the vtkDistanceWidget. Logically subclasses consist of
	/// an axis and two handles for placing/manipulating the end points.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkDistanceWidget vtkHandleRepresentation vtkDistanceRepresentation2D vtkDistanceRepresentation
	/// </seealso>
	// Token: 0x0200030C RID: 780
	public abstract class vtkDistanceRepresentation : vtkWidgetRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06008C4F RID: 35919 RVA: 0x000C81AA File Offset: 0x000C63AA
		static vtkDistanceRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDistanceRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDistanceRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06008C50 RID: 35920 RVA: 0x000C81D2 File Offset: 0x000C63D2
		public vtkDistanceRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06008C51 RID: 35921 RVA: 0x000C81E0 File Offset: 0x000C63E0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06008C52 RID: 35922
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceRepresentation_BuildRepresentation_01(HandleRef pThis);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x06008C53 RID: 35923 RVA: 0x000C81EB File Offset: 0x000C63EB
		public override void BuildRepresentation()
		{
			vtkDistanceRepresentation.vtkDistanceRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06008C54 RID: 35924
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceRepresentation_ComplexInteraction_02(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x06008C55 RID: 35925 RVA: 0x000C81FC File Offset: 0x000C63FC
		public override void ComplexInteraction(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata)
		{
			vtkDistanceRepresentation.vtkDistanceRepresentation_ComplexInteraction_02(base.GetCppThis(), (iren == null) ? default(HandleRef) : iren.GetCppThis(), (widget == null) ? default(HandleRef) : widget.GetCppThis(), arg2, calldata);
		}

		// Token: 0x06008C56 RID: 35926
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDistanceRepresentation_ComputeComplexInteractionState_03(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata, int modify);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x06008C57 RID: 35927 RVA: 0x000C8244 File Offset: 0x000C6444
		public override int ComputeComplexInteractionState(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata, int modify)
		{
			return vtkDistanceRepresentation.vtkDistanceRepresentation_ComputeComplexInteractionState_03(base.GetCppThis(), (iren == null) ? default(HandleRef) : iren.GetCppThis(), (widget == null) ? default(HandleRef) : widget.GetCppThis(), arg2, calldata, modify);
		}

		// Token: 0x06008C58 RID: 35928
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDistanceRepresentation_ComputeInteractionState_04(HandleRef pThis, int X, int Y, int modify);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x06008C59 RID: 35929 RVA: 0x000C8294 File Offset: 0x000C6494
		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkDistanceRepresentation.vtkDistanceRepresentation_ComputeInteractionState_04(base.GetCppThis(), X, Y, modify);
		}

		// Token: 0x06008C5A RID: 35930
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDistanceRepresentation_GetDistance_05(HandleRef pThis);

		/// <summary>
		/// This representation and all subclasses must keep a distance
		/// consistent with the state of the widget.
		/// </summary>
		// Token: 0x06008C5B RID: 35931 RVA: 0x000C82B8 File Offset: 0x000C64B8
		public virtual double GetDistance()
		{
			return vtkDistanceRepresentation.vtkDistanceRepresentation_GetDistance_05(base.GetCppThis());
		}

		// Token: 0x06008C5C RID: 35932
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDistanceRepresentation_GetLabelFormat_06(HandleRef pThis);

		/// <summary>
		/// Specify the format to use for labelling the distance. Note that an empty
		/// string results in no label, or a format string without a "%" character
		/// will not print the distance value.
		/// </summary>
		// Token: 0x06008C5D RID: 35933 RVA: 0x000C82D8 File Offset: 0x000C64D8
		public virtual string GetLabelFormat()
		{
			string s = Marshal.PtrToStringAnsi(vtkDistanceRepresentation.vtkDistanceRepresentation_GetLabelFormat_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06008C5E RID: 35934
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDistanceRepresentation_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06008C5F RID: 35935 RVA: 0x000C8314 File Offset: 0x000C6514
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDistanceRepresentation.vtkDistanceRepresentation_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x06008C60 RID: 35936
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDistanceRepresentation_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06008C61 RID: 35937 RVA: 0x000C8334 File Offset: 0x000C6534
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDistanceRepresentation.vtkDistanceRepresentation_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x06008C62 RID: 35938
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDistanceRepresentation_GetNumberOfRulerTicks_09(HandleRef pThis);

		/// <summary>
		/// Specify the number of major ruler ticks. This overrides any subclasses
		/// (e.g., vtkDistanceRepresentation2D) that have alternative methods to
		/// specify the number of major ticks. Note: the number of ticks is the
		/// number between the two handle endpoints. This ivar only has effect
		/// when the RulerMode is off.
		/// </summary>
		// Token: 0x06008C63 RID: 35939 RVA: 0x000C8350 File Offset: 0x000C6550
		public virtual int GetNumberOfRulerTicks()
		{
			return vtkDistanceRepresentation.vtkDistanceRepresentation_GetNumberOfRulerTicks_09(base.GetCppThis());
		}

		// Token: 0x06008C64 RID: 35940
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDistanceRepresentation_GetNumberOfRulerTicksMaxValue_10(HandleRef pThis);

		/// <summary>
		/// Specify the number of major ruler ticks. This overrides any subclasses
		/// (e.g., vtkDistanceRepresentation2D) that have alternative methods to
		/// specify the number of major ticks. Note: the number of ticks is the
		/// number between the two handle endpoints. This ivar only has effect
		/// when the RulerMode is off.
		/// </summary>
		// Token: 0x06008C65 RID: 35941 RVA: 0x000C8370 File Offset: 0x000C6570
		public virtual int GetNumberOfRulerTicksMaxValue()
		{
			return vtkDistanceRepresentation.vtkDistanceRepresentation_GetNumberOfRulerTicksMaxValue_10(base.GetCppThis());
		}

		// Token: 0x06008C66 RID: 35942
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDistanceRepresentation_GetNumberOfRulerTicksMinValue_11(HandleRef pThis);

		/// <summary>
		/// Specify the number of major ruler ticks. This overrides any subclasses
		/// (e.g., vtkDistanceRepresentation2D) that have alternative methods to
		/// specify the number of major ticks. Note: the number of ticks is the
		/// number between the two handle endpoints. This ivar only has effect
		/// when the RulerMode is off.
		/// </summary>
		// Token: 0x06008C67 RID: 35943 RVA: 0x000C8390 File Offset: 0x000C6590
		public virtual int GetNumberOfRulerTicksMinValue()
		{
			return vtkDistanceRepresentation.vtkDistanceRepresentation_GetNumberOfRulerTicksMinValue_11(base.GetCppThis());
		}

		// Token: 0x06008C68 RID: 35944
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceRepresentation_GetPoint1DisplayPosition_12(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06008C69 RID: 35945 RVA: 0x000C83AF File Offset: 0x000C65AF
		public virtual void GetPoint1DisplayPosition(IntPtr pos)
		{
			vtkDistanceRepresentation.vtkDistanceRepresentation_GetPoint1DisplayPosition_12(base.GetCppThis(), pos);
		}

		// Token: 0x06008C6A RID: 35946
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDistanceRepresentation_GetPoint1Representation_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the two handle representations used for the vtkDistanceWidget. (Note:
		/// properties can be set by grabbing these representations and setting the
		/// properties appropriately.)
		/// </summary>
		// Token: 0x06008C6B RID: 35947 RVA: 0x000C83C0 File Offset: 0x000C65C0
		public virtual vtkHandleRepresentation GetPoint1Representation()
		{
			vtkHandleRepresentation vtkHandleRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDistanceRepresentation.vtkDistanceRepresentation_GetPoint1Representation_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHandleRepresentation = (vtkHandleRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHandleRepresentation.Register(null);
				}
			}
			return vtkHandleRepresentation;
		}

		// Token: 0x06008C6C RID: 35948
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceRepresentation_GetPoint1WorldPosition_14(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06008C6D RID: 35949 RVA: 0x000C842F File Offset: 0x000C662F
		public virtual void GetPoint1WorldPosition(IntPtr pos)
		{
			vtkDistanceRepresentation.vtkDistanceRepresentation_GetPoint1WorldPosition_14(base.GetCppThis(), pos);
		}

		// Token: 0x06008C6E RID: 35950
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDistanceRepresentation_GetPoint1WorldPosition_15(HandleRef pThis);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06008C6F RID: 35951 RVA: 0x000C8440 File Offset: 0x000C6640
		public virtual double[] GetPoint1WorldPosition()
		{
			IntPtr intPtr = vtkDistanceRepresentation.vtkDistanceRepresentation_GetPoint1WorldPosition_15(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06008C70 RID: 35952
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceRepresentation_GetPoint2DisplayPosition_16(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06008C71 RID: 35953 RVA: 0x000C8488 File Offset: 0x000C6688
		public virtual void GetPoint2DisplayPosition(IntPtr pos)
		{
			vtkDistanceRepresentation.vtkDistanceRepresentation_GetPoint2DisplayPosition_16(base.GetCppThis(), pos);
		}

		// Token: 0x06008C72 RID: 35954
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDistanceRepresentation_GetPoint2Representation_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the two handle representations used for the vtkDistanceWidget. (Note:
		/// properties can be set by grabbing these representations and setting the
		/// properties appropriately.)
		/// </summary>
		// Token: 0x06008C73 RID: 35955 RVA: 0x000C8498 File Offset: 0x000C6698
		public virtual vtkHandleRepresentation GetPoint2Representation()
		{
			vtkHandleRepresentation vtkHandleRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDistanceRepresentation.vtkDistanceRepresentation_GetPoint2Representation_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHandleRepresentation = (vtkHandleRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHandleRepresentation.Register(null);
				}
			}
			return vtkHandleRepresentation;
		}

		// Token: 0x06008C74 RID: 35956
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceRepresentation_GetPoint2WorldPosition_18(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06008C75 RID: 35957 RVA: 0x000C8507 File Offset: 0x000C6707
		public virtual void GetPoint2WorldPosition(IntPtr pos)
		{
			vtkDistanceRepresentation.vtkDistanceRepresentation_GetPoint2WorldPosition_18(base.GetCppThis(), pos);
		}

		// Token: 0x06008C76 RID: 35958
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDistanceRepresentation_GetPoint2WorldPosition_19(HandleRef pThis);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06008C77 RID: 35959 RVA: 0x000C8518 File Offset: 0x000C6718
		public virtual double[] GetPoint2WorldPosition()
		{
			IntPtr intPtr = vtkDistanceRepresentation.vtkDistanceRepresentation_GetPoint2WorldPosition_19(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06008C78 RID: 35960
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDistanceRepresentation_GetRulerDistance_20(HandleRef pThis);

		/// <summary>
		/// Specify the RulerDistance which indicates the spacing of the major ticks.
		/// This ivar only has effect when the RulerMode is on.
		/// </summary>
		// Token: 0x06008C79 RID: 35961 RVA: 0x000C8560 File Offset: 0x000C6760
		public virtual double GetRulerDistance()
		{
			return vtkDistanceRepresentation.vtkDistanceRepresentation_GetRulerDistance_20(base.GetCppThis());
		}

		// Token: 0x06008C7A RID: 35962
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDistanceRepresentation_GetRulerDistanceMaxValue_21(HandleRef pThis);

		/// <summary>
		/// Specify the RulerDistance which indicates the spacing of the major ticks.
		/// This ivar only has effect when the RulerMode is on.
		/// </summary>
		// Token: 0x06008C7B RID: 35963 RVA: 0x000C8580 File Offset: 0x000C6780
		public virtual double GetRulerDistanceMaxValue()
		{
			return vtkDistanceRepresentation.vtkDistanceRepresentation_GetRulerDistanceMaxValue_21(base.GetCppThis());
		}

		// Token: 0x06008C7C RID: 35964
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDistanceRepresentation_GetRulerDistanceMinValue_22(HandleRef pThis);

		/// <summary>
		/// Specify the RulerDistance which indicates the spacing of the major ticks.
		/// This ivar only has effect when the RulerMode is on.
		/// </summary>
		// Token: 0x06008C7D RID: 35965 RVA: 0x000C85A0 File Offset: 0x000C67A0
		public virtual double GetRulerDistanceMinValue()
		{
			return vtkDistanceRepresentation.vtkDistanceRepresentation_GetRulerDistanceMinValue_22(base.GetCppThis());
		}

		// Token: 0x06008C7E RID: 35966
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDistanceRepresentation_GetRulerMode_23(HandleRef pThis);

		/// <summary>
		/// Enable or disable ruler mode. When enabled, the ticks on the distance widget
		/// are separated by the amount specified by RulerDistance. Otherwise, the ivar
		/// NumberOfRulerTicks is used to draw the tick marks.
		/// </summary>
		// Token: 0x06008C7F RID: 35967 RVA: 0x000C85C0 File Offset: 0x000C67C0
		public virtual int GetRulerMode()
		{
			return vtkDistanceRepresentation.vtkDistanceRepresentation_GetRulerMode_23(base.GetCppThis());
		}

		// Token: 0x06008C80 RID: 35968
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDistanceRepresentation_GetScale_24(HandleRef pThis);

		/// <summary>
		/// Set the scale factor from VTK world coordinates. The ruler marks and label
		/// will be defined in terms of the scaled space. For example, if the VTK world
		/// coordinates are assumed to be in inches, but the desired distance units
		/// should be defined in terms of centimeters, the scale factor should be set
		/// to 2.54. The ruler marks will then be spaced in terms of centimeters, and
		/// the label will show the measurement in centimeters.
		/// </summary>
		// Token: 0x06008C81 RID: 35969 RVA: 0x000C85E0 File Offset: 0x000C67E0
		public virtual double GetScale()
		{
			return vtkDistanceRepresentation.vtkDistanceRepresentation_GetScale_24(base.GetCppThis());
		}

		// Token: 0x06008C82 RID: 35970
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDistanceRepresentation_GetTolerance_25(HandleRef pThis);

		/// <summary>
		/// The tolerance representing the distance to the widget (in pixels) in
		/// which the cursor is considered near enough to the end points of
		/// the widget to be active.
		/// </summary>
		// Token: 0x06008C83 RID: 35971 RVA: 0x000C8600 File Offset: 0x000C6800
		public virtual int GetTolerance()
		{
			return vtkDistanceRepresentation.vtkDistanceRepresentation_GetTolerance_25(base.GetCppThis());
		}

		// Token: 0x06008C84 RID: 35972
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDistanceRepresentation_GetToleranceMaxValue_26(HandleRef pThis);

		/// <summary>
		/// The tolerance representing the distance to the widget (in pixels) in
		/// which the cursor is considered near enough to the end points of
		/// the widget to be active.
		/// </summary>
		// Token: 0x06008C85 RID: 35973 RVA: 0x000C8620 File Offset: 0x000C6820
		public virtual int GetToleranceMaxValue()
		{
			return vtkDistanceRepresentation.vtkDistanceRepresentation_GetToleranceMaxValue_26(base.GetCppThis());
		}

		// Token: 0x06008C86 RID: 35974
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDistanceRepresentation_GetToleranceMinValue_27(HandleRef pThis);

		/// <summary>
		/// The tolerance representing the distance to the widget (in pixels) in
		/// which the cursor is considered near enough to the end points of
		/// the widget to be active.
		/// </summary>
		// Token: 0x06008C87 RID: 35975 RVA: 0x000C8640 File Offset: 0x000C6840
		public virtual int GetToleranceMinValue()
		{
			return vtkDistanceRepresentation.vtkDistanceRepresentation_GetToleranceMinValue_27(base.GetCppThis());
		}

		// Token: 0x06008C88 RID: 35976
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceRepresentation_InstantiateHandleRepresentation_28(HandleRef pThis);

		/// <summary>
		/// This method is used to specify the type of handle representation to
		/// use for the two internal vtkHandleWidgets within vtkDistanceWidget.
		/// To use this method, create a dummy vtkHandleWidget (or subclass),
		/// and then invoke this method with this dummy. Then the
		/// vtkDistanceRepresentation uses this dummy to clone two vtkHandleWidgets
		/// of the same type. Make sure you set the handle representation before
		/// the widget is enabled. (The method InstantiateHandleRepresentation()
		/// is invoked by the vtkDistance widget.)
		/// </summary>
		// Token: 0x06008C89 RID: 35977 RVA: 0x000C865F File Offset: 0x000C685F
		public void InstantiateHandleRepresentation()
		{
			vtkDistanceRepresentation.vtkDistanceRepresentation_InstantiateHandleRepresentation_28(base.GetCppThis());
		}

		// Token: 0x06008C8A RID: 35978
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDistanceRepresentation_IsA_29(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06008C8B RID: 35979 RVA: 0x000C8670 File Offset: 0x000C6870
		public override int IsA(string type)
		{
			return vtkDistanceRepresentation.vtkDistanceRepresentation_IsA_29(base.GetCppThis(), type);
		}

		// Token: 0x06008C8C RID: 35980
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDistanceRepresentation_IsTypeOf_30([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06008C8D RID: 35981 RVA: 0x000C8690 File Offset: 0x000C6890
		public new static int IsTypeOf(string type)
		{
			return vtkDistanceRepresentation.vtkDistanceRepresentation_IsTypeOf_30(type);
		}

		// Token: 0x06008C8E RID: 35982
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDistanceRepresentation_NewInstance_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06008C8F RID: 35983 RVA: 0x000C86AC File Offset: 0x000C68AC
		public new vtkDistanceRepresentation NewInstance()
		{
			vtkDistanceRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDistanceRepresentation.vtkDistanceRepresentation_NewInstance_31(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDistanceRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06008C90 RID: 35984
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceRepresentation_RulerModeOff_32(HandleRef pThis);

		/// <summary>
		/// Enable or disable ruler mode. When enabled, the ticks on the distance widget
		/// are separated by the amount specified by RulerDistance. Otherwise, the ivar
		/// NumberOfRulerTicks is used to draw the tick marks.
		/// </summary>
		// Token: 0x06008C91 RID: 35985 RVA: 0x000C8706 File Offset: 0x000C6906
		public virtual void RulerModeOff()
		{
			vtkDistanceRepresentation.vtkDistanceRepresentation_RulerModeOff_32(base.GetCppThis());
		}

		// Token: 0x06008C92 RID: 35986
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceRepresentation_RulerModeOn_33(HandleRef pThis);

		/// <summary>
		/// Enable or disable ruler mode. When enabled, the ticks on the distance widget
		/// are separated by the amount specified by RulerDistance. Otherwise, the ivar
		/// NumberOfRulerTicks is used to draw the tick marks.
		/// </summary>
		// Token: 0x06008C93 RID: 35987 RVA: 0x000C8715 File Offset: 0x000C6915
		public virtual void RulerModeOn()
		{
			vtkDistanceRepresentation.vtkDistanceRepresentation_RulerModeOn_33(base.GetCppThis());
		}

		// Token: 0x06008C94 RID: 35988
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDistanceRepresentation_SafeDownCast_34(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06008C95 RID: 35989 RVA: 0x000C8724 File Offset: 0x000C6924
		public new static vtkDistanceRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkDistanceRepresentation vtkDistanceRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDistanceRepresentation.vtkDistanceRepresentation_SafeDownCast_34((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDistanceRepresentation = (vtkDistanceRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDistanceRepresentation.Register(null);
				}
			}
			return vtkDistanceRepresentation;
		}

		// Token: 0x06008C96 RID: 35990
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceRepresentation_SetHandleRepresentation_35(HandleRef pThis, HandleRef handle);

		/// <summary>
		/// This method is used to specify the type of handle representation to
		/// use for the two internal vtkHandleWidgets within vtkDistanceWidget.
		/// To use this method, create a dummy vtkHandleWidget (or subclass),
		/// and then invoke this method with this dummy. Then the
		/// vtkDistanceRepresentation uses this dummy to clone two vtkHandleWidgets
		/// of the same type. Make sure you set the handle representation before
		/// the widget is enabled. (The method InstantiateHandleRepresentation()
		/// is invoked by the vtkDistance widget.)
		/// </summary>
		// Token: 0x06008C97 RID: 35991 RVA: 0x000C87A4 File Offset: 0x000C69A4
		public void SetHandleRepresentation(vtkHandleRepresentation handle)
		{
			vtkDistanceRepresentation.vtkDistanceRepresentation_SetHandleRepresentation_35(base.GetCppThis(), (handle == null) ? default(HandleRef) : handle.GetCppThis());
		}

		// Token: 0x06008C98 RID: 35992
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceRepresentation_SetLabelFormat_36(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify the format to use for labelling the distance. Note that an empty
		/// string results in no label, or a format string without a "%" character
		/// will not print the distance value.
		/// </summary>
		// Token: 0x06008C99 RID: 35993 RVA: 0x000C87D3 File Offset: 0x000C69D3
		public virtual void SetLabelFormat(string _arg)
		{
			vtkDistanceRepresentation.vtkDistanceRepresentation_SetLabelFormat_36(base.GetCppThis(), _arg);
		}

		// Token: 0x06008C9A RID: 35994
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceRepresentation_SetNumberOfRulerTicks_37(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the number of major ruler ticks. This overrides any subclasses
		/// (e.g., vtkDistanceRepresentation2D) that have alternative methods to
		/// specify the number of major ticks. Note: the number of ticks is the
		/// number between the two handle endpoints. This ivar only has effect
		/// when the RulerMode is off.
		/// </summary>
		// Token: 0x06008C9B RID: 35995 RVA: 0x000C87E3 File Offset: 0x000C69E3
		public virtual void SetNumberOfRulerTicks(int _arg)
		{
			vtkDistanceRepresentation.vtkDistanceRepresentation_SetNumberOfRulerTicks_37(base.GetCppThis(), _arg);
		}

		// Token: 0x06008C9C RID: 35996
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceRepresentation_SetPoint1DisplayPosition_38(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06008C9D RID: 35997 RVA: 0x000C87F3 File Offset: 0x000C69F3
		public virtual void SetPoint1DisplayPosition(IntPtr pos)
		{
			vtkDistanceRepresentation.vtkDistanceRepresentation_SetPoint1DisplayPosition_38(base.GetCppThis(), pos);
		}

		// Token: 0x06008C9E RID: 35998
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceRepresentation_SetPoint1WorldPosition_39(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06008C9F RID: 35999 RVA: 0x000C8803 File Offset: 0x000C6A03
		public virtual void SetPoint1WorldPosition(IntPtr pos)
		{
			vtkDistanceRepresentation.vtkDistanceRepresentation_SetPoint1WorldPosition_39(base.GetCppThis(), pos);
		}

		// Token: 0x06008CA0 RID: 36000
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceRepresentation_SetPoint2DisplayPosition_40(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06008CA1 RID: 36001 RVA: 0x000C8813 File Offset: 0x000C6A13
		public virtual void SetPoint2DisplayPosition(IntPtr pos)
		{
			vtkDistanceRepresentation.vtkDistanceRepresentation_SetPoint2DisplayPosition_40(base.GetCppThis(), pos);
		}

		// Token: 0x06008CA2 RID: 36002
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceRepresentation_SetPoint2WorldPosition_41(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06008CA3 RID: 36003 RVA: 0x000C8823 File Offset: 0x000C6A23
		public virtual void SetPoint2WorldPosition(IntPtr pos)
		{
			vtkDistanceRepresentation.vtkDistanceRepresentation_SetPoint2WorldPosition_41(base.GetCppThis(), pos);
		}

		// Token: 0x06008CA4 RID: 36004
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceRepresentation_SetRulerDistance_42(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the RulerDistance which indicates the spacing of the major ticks.
		/// This ivar only has effect when the RulerMode is on.
		/// </summary>
		// Token: 0x06008CA5 RID: 36005 RVA: 0x000C8833 File Offset: 0x000C6A33
		public virtual void SetRulerDistance(double _arg)
		{
			vtkDistanceRepresentation.vtkDistanceRepresentation_SetRulerDistance_42(base.GetCppThis(), _arg);
		}

		// Token: 0x06008CA6 RID: 36006
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceRepresentation_SetRulerMode_43(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable or disable ruler mode. When enabled, the ticks on the distance widget
		/// are separated by the amount specified by RulerDistance. Otherwise, the ivar
		/// NumberOfRulerTicks is used to draw the tick marks.
		/// </summary>
		// Token: 0x06008CA7 RID: 36007 RVA: 0x000C8843 File Offset: 0x000C6A43
		public virtual void SetRulerMode(int _arg)
		{
			vtkDistanceRepresentation.vtkDistanceRepresentation_SetRulerMode_43(base.GetCppThis(), _arg);
		}

		// Token: 0x06008CA8 RID: 36008
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceRepresentation_SetScale_44(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the scale factor from VTK world coordinates. The ruler marks and label
		/// will be defined in terms of the scaled space. For example, if the VTK world
		/// coordinates are assumed to be in inches, but the desired distance units
		/// should be defined in terms of centimeters, the scale factor should be set
		/// to 2.54. The ruler marks will then be spaced in terms of centimeters, and
		/// the label will show the measurement in centimeters.
		/// </summary>
		// Token: 0x06008CA9 RID: 36009 RVA: 0x000C8853 File Offset: 0x000C6A53
		public virtual void SetScale(double _arg)
		{
			vtkDistanceRepresentation.vtkDistanceRepresentation_SetScale_44(base.GetCppThis(), _arg);
		}

		// Token: 0x06008CAA RID: 36010
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceRepresentation_SetTolerance_45(HandleRef pThis, int _arg);

		/// <summary>
		/// The tolerance representing the distance to the widget (in pixels) in
		/// which the cursor is considered near enough to the end points of
		/// the widget to be active.
		/// </summary>
		// Token: 0x06008CAB RID: 36011 RVA: 0x000C8863 File Offset: 0x000C6A63
		public virtual void SetTolerance(int _arg)
		{
			vtkDistanceRepresentation.vtkDistanceRepresentation_SetTolerance_45(base.GetCppThis(), _arg);
		}

		// Token: 0x06008CAC RID: 36012
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceRepresentation_StartComplexInteraction_46(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x06008CAD RID: 36013 RVA: 0x000C8874 File Offset: 0x000C6A74
		public override void StartComplexInteraction(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata)
		{
			vtkDistanceRepresentation.vtkDistanceRepresentation_StartComplexInteraction_46(base.GetCppThis(), (iren == null) ? default(HandleRef) : iren.GetCppThis(), (widget == null) ? default(HandleRef) : widget.GetCppThis(), arg2, calldata);
		}

		// Token: 0x06008CAE RID: 36014
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceRepresentation_StartWidgetInteraction_47(HandleRef pThis, IntPtr e);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x06008CAF RID: 36015 RVA: 0x000C88BB File Offset: 0x000C6ABB
		public override void StartWidgetInteraction(IntPtr e)
		{
			vtkDistanceRepresentation.vtkDistanceRepresentation_StartWidgetInteraction_47(base.GetCppThis(), e);
		}

		// Token: 0x06008CB0 RID: 36016
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceRepresentation_WidgetInteraction_48(HandleRef pThis, IntPtr e);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x06008CB1 RID: 36017 RVA: 0x000C88CB File Offset: 0x000C6ACB
		public override void WidgetInteraction(IntPtr e)
		{
			vtkDistanceRepresentation.vtkDistanceRepresentation_WidgetInteraction_48(base.GetCppThis(), e);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000BC4 RID: 3012
		public new const string MRFullTypeName = "Kitware.VTK.vtkDistanceRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000BC5 RID: 3013
		public new static readonly string MRClassNameKey = "class vtkDistanceRepresentation";

		/// <summary>
		/// Specify the number of major ruler ticks. This overrides any subclasses
		/// (e.g., vtkDistanceRepresentation2D) that have alternative methods to
		/// specify the number of major ticks. Note: the number of ticks is the
		/// number between the two handle endpoints. This ivar only has effect
		/// when the RulerMode is off.
		/// </summary>
		// Token: 0x0200030D RID: 781
		public enum NearP1_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000BC7 RID: 3015
			NearP1 = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000BC8 RID: 3016
			NearP2,
			/// <summary>enum member</summary>
			// Token: 0x04000BC9 RID: 3017
			Outside = 0
		}
	}
}
