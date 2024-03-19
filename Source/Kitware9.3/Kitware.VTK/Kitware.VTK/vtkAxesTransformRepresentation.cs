using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAxesTransformRepresentation
	/// </summary>
	/// <remarks>
	///    represent the vtkAxesTransformWidget
	///
	/// The vtkAxesTransformRepresentation is a representation for the
	/// vtkAxesTransformWidget. This representation consists of a origin sphere
	/// with three tubed axes with cones at the end of the axes. In addition an
	/// optional label provides delta values of motion. Note that this particular
	/// widget draws its representation in 3D space, so the widget can be
	/// occluded.
	/// </remarks>
	/// <seealso>
	///
	/// vtkDistanceWidget vtkDistanceRepresentation vtkDistanceRepresentation2D
	/// </seealso>
	// Token: 0x020002BD RID: 701
	public class vtkAxesTransformRepresentation : vtkWidgetRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06007EB9 RID: 32441 RVA: 0x000B5CF1 File Offset: 0x000B3EF1
		static vtkAxesTransformRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAxesTransformRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAxesTransformRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06007EBA RID: 32442 RVA: 0x000B5D19 File Offset: 0x000B3F19
		public vtkAxesTransformRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06007EBB RID: 32443
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxesTransformRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate class.
		/// </summary>
		// Token: 0x06007EBC RID: 32444 RVA: 0x000B5D28 File Offset: 0x000B3F28
		public new static vtkAxesTransformRepresentation New()
		{
			vtkAxesTransformRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAxesTransformRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate class.
		/// </summary>
		// Token: 0x06007EBD RID: 32445 RVA: 0x000B5D7C File Offset: 0x000B3F7C
		public vtkAxesTransformRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06007EBE RID: 32446 RVA: 0x000B5DC0 File Offset: 0x000B3FC0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06007EBF RID: 32447
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesTransformRepresentation_BuildRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Method to satisfy superclasses' API.
		/// </summary>
		// Token: 0x06007EC0 RID: 32448 RVA: 0x000B5DCB File Offset: 0x000B3FCB
		public override void BuildRepresentation()
		{
			vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06007EC1 RID: 32449
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxesTransformRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

		/// <summary>
		/// Method to satisfy superclasses' API.
		/// </summary>
		// Token: 0x06007EC2 RID: 32450 RVA: 0x000B5DDC File Offset: 0x000B3FDC
		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_ComputeInteractionState_02(base.GetCppThis(), X, Y, modify);
		}

		// Token: 0x06007EC3 RID: 32451
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxesTransformRepresentation_GetBounds_03(HandleRef pThis);

		/// <summary>
		/// Method to satisfy superclasses' API.
		/// </summary>
		// Token: 0x06007EC4 RID: 32452 RVA: 0x000B5E00 File Offset: 0x000B4000
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_GetBounds_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06007EC5 RID: 32453
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxesTransformRepresentation_GetInteractionStateMaxValue_04(HandleRef pThis);

		/// <summary>
		/// The interaction state may be set from a widget (e.g., vtkLineWidget2) or
		/// other object. This controls how the interaction with the widget
		/// proceeds. Normally this method is used as part of a handshaking
		/// process with the widget: First ComputeInteractionState() is invoked that
		/// returns a state based on geometric considerations (i.e., cursor near a
		/// widget feature), then based on events, the widget may modify this
		/// further.
		/// </summary>
		// Token: 0x06007EC6 RID: 32454 RVA: 0x000B5E48 File Offset: 0x000B4048
		public virtual int GetInteractionStateMaxValue()
		{
			return vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_GetInteractionStateMaxValue_04(base.GetCppThis());
		}

		// Token: 0x06007EC7 RID: 32455
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxesTransformRepresentation_GetInteractionStateMinValue_05(HandleRef pThis);

		/// <summary>
		/// The interaction state may be set from a widget (e.g., vtkLineWidget2) or
		/// other object. This controls how the interaction with the widget
		/// proceeds. Normally this method is used as part of a handshaking
		/// process with the widget: First ComputeInteractionState() is invoked that
		/// returns a state based on geometric considerations (i.e., cursor near a
		/// widget feature), then based on events, the widget may modify this
		/// further.
		/// </summary>
		// Token: 0x06007EC8 RID: 32456 RVA: 0x000B5E68 File Offset: 0x000B4068
		public virtual int GetInteractionStateMinValue()
		{
			return vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_GetInteractionStateMinValue_05(base.GetCppThis());
		}

		// Token: 0x06007EC9 RID: 32457
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxesTransformRepresentation_GetLabelFormat_06(HandleRef pThis);

		/// <summary>
		/// Specify the format to use for labelling information during
		/// transformation. Note that an empty string results in no label, or a
		/// format string without a "%" character will not print numeric values.
		/// </summary>
		// Token: 0x06007ECA RID: 32458 RVA: 0x000B5E88 File Offset: 0x000B4088
		public virtual string GetLabelFormat()
		{
			string s = Marshal.PtrToStringAnsi(vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_GetLabelFormat_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06007ECB RID: 32459
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxesTransformRepresentation_GetLabelProperty_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the distance annotation property
		/// </summary>
		// Token: 0x06007ECC RID: 32460 RVA: 0x000B5EC4 File Offset: 0x000B40C4
		public virtual vtkProperty GetLabelProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_GetLabelProperty_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06007ECD RID: 32461
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxesTransformRepresentation_GetLabelScale_08(HandleRef pThis);

		/// <summary>
		/// Scale text (font size along each dimension). This helps control
		/// the appearance of the 3D text.
		/// </summary>
		// Token: 0x06007ECE RID: 32462 RVA: 0x000B5F34 File Offset: 0x000B4134
		public virtual IntPtr GetLabelScale()
		{
			return vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_GetLabelScale_08(base.GetCppThis());
		}

		// Token: 0x06007ECF RID: 32463
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAxesTransformRepresentation_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06007ED0 RID: 32464 RVA: 0x000B5F54 File Offset: 0x000B4154
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x06007ED1 RID: 32465
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAxesTransformRepresentation_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06007ED2 RID: 32466 RVA: 0x000B5F74 File Offset: 0x000B4174
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x06007ED3 RID: 32467
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesTransformRepresentation_GetOriginDisplayPosition_11(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06007ED4 RID: 32468 RVA: 0x000B5F8E File Offset: 0x000B418E
		public void GetOriginDisplayPosition(IntPtr pos)
		{
			vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_GetOriginDisplayPosition_11(base.GetCppThis(), pos);
		}

		// Token: 0x06007ED5 RID: 32469
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxesTransformRepresentation_GetOriginRepresentation_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the two handle representations used for the
		/// vtkAxesTransformWidget. (Note: properties can be set by grabbing these
		/// representations and setting the properties appropriately.)
		/// </summary>
		// Token: 0x06007ED6 RID: 32470 RVA: 0x000B5FA0 File Offset: 0x000B41A0
		public virtual vtkHandleRepresentation GetOriginRepresentation()
		{
			vtkHandleRepresentation vtkHandleRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_GetOriginRepresentation_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06007ED7 RID: 32471
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxesTransformRepresentation_GetOriginWorldPosition_13(HandleRef pThis);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06007ED8 RID: 32472 RVA: 0x000B6010 File Offset: 0x000B4210
		public IntPtr GetOriginWorldPosition()
		{
			return vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_GetOriginWorldPosition_13(base.GetCppThis());
		}

		// Token: 0x06007ED9 RID: 32473
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesTransformRepresentation_GetOriginWorldPosition_14(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06007EDA RID: 32474 RVA: 0x000B602F File Offset: 0x000B422F
		public void GetOriginWorldPosition(IntPtr pos)
		{
			vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_GetOriginWorldPosition_14(base.GetCppThis(), pos);
		}

		// Token: 0x06007EDB RID: 32475
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxesTransformRepresentation_GetSelectionRepresentation_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the two handle representations used for the
		/// vtkAxesTransformWidget. (Note: properties can be set by grabbing these
		/// representations and setting the properties appropriately.)
		/// </summary>
		// Token: 0x06007EDC RID: 32476 RVA: 0x000B6040 File Offset: 0x000B4240
		public virtual vtkHandleRepresentation GetSelectionRepresentation()
		{
			vtkHandleRepresentation vtkHandleRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_GetSelectionRepresentation_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06007EDD RID: 32477
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxesTransformRepresentation_GetTolerance_16(HandleRef pThis);

		/// <summary>
		/// The tolerance representing the distance to the widget (in pixels) in
		/// which the cursor is considered near enough to the end points of
		/// the widget to be active.
		/// </summary>
		// Token: 0x06007EDE RID: 32478 RVA: 0x000B60B0 File Offset: 0x000B42B0
		public virtual int GetTolerance()
		{
			return vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_GetTolerance_16(base.GetCppThis());
		}

		// Token: 0x06007EDF RID: 32479
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxesTransformRepresentation_GetToleranceMaxValue_17(HandleRef pThis);

		/// <summary>
		/// The tolerance representing the distance to the widget (in pixels) in
		/// which the cursor is considered near enough to the end points of
		/// the widget to be active.
		/// </summary>
		// Token: 0x06007EE0 RID: 32480 RVA: 0x000B60D0 File Offset: 0x000B42D0
		public virtual int GetToleranceMaxValue()
		{
			return vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_GetToleranceMaxValue_17(base.GetCppThis());
		}

		// Token: 0x06007EE1 RID: 32481
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxesTransformRepresentation_GetToleranceMinValue_18(HandleRef pThis);

		/// <summary>
		/// The tolerance representing the distance to the widget (in pixels) in
		/// which the cursor is considered near enough to the end points of
		/// the widget to be active.
		/// </summary>
		// Token: 0x06007EE2 RID: 32482 RVA: 0x000B60F0 File Offset: 0x000B42F0
		public virtual int GetToleranceMinValue()
		{
			return vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_GetToleranceMinValue_18(base.GetCppThis());
		}

		// Token: 0x06007EE3 RID: 32483
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxesTransformRepresentation_IsA_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06007EE4 RID: 32484 RVA: 0x000B6110 File Offset: 0x000B4310
		public override int IsA(string type)
		{
			return vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_IsA_19(base.GetCppThis(), type);
		}

		// Token: 0x06007EE5 RID: 32485
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxesTransformRepresentation_IsTypeOf_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06007EE6 RID: 32486 RVA: 0x000B6130 File Offset: 0x000B4330
		public new static int IsTypeOf(string type)
		{
			return vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_IsTypeOf_20(type);
		}

		// Token: 0x06007EE7 RID: 32487
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxesTransformRepresentation_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06007EE8 RID: 32488 RVA: 0x000B614C File Offset: 0x000B434C
		public new vtkAxesTransformRepresentation NewInstance()
		{
			vtkAxesTransformRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_NewInstance_22(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAxesTransformRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06007EE9 RID: 32489
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesTransformRepresentation_ReleaseGraphicsResources_23(HandleRef pThis, HandleRef w);

		/// <summary>
		/// Methods required by vtkProp superclass.
		/// </summary>
		// Token: 0x06007EEA RID: 32490 RVA: 0x000B61A8 File Offset: 0x000B43A8
		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_ReleaseGraphicsResources_23(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		// Token: 0x06007EEB RID: 32491
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxesTransformRepresentation_RenderOpaqueGeometry_24(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Methods required by vtkProp superclass.
		/// </summary>
		// Token: 0x06007EEC RID: 32492 RVA: 0x000B61D8 File Offset: 0x000B43D8
		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_RenderOpaqueGeometry_24(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x06007EED RID: 32493
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxesTransformRepresentation_RenderTranslucentPolygonalGeometry_25(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Methods required by vtkProp superclass.
		/// </summary>
		// Token: 0x06007EEE RID: 32494 RVA: 0x000B620C File Offset: 0x000B440C
		public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
		{
			return vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_RenderTranslucentPolygonalGeometry_25(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x06007EEF RID: 32495
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxesTransformRepresentation_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06007EF0 RID: 32496 RVA: 0x000B6240 File Offset: 0x000B4440
		public new static vtkAxesTransformRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkAxesTransformRepresentation vtkAxesTransformRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAxesTransformRepresentation = (vtkAxesTransformRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAxesTransformRepresentation.Register(null);
				}
			}
			return vtkAxesTransformRepresentation;
		}

		// Token: 0x06007EF1 RID: 32497
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesTransformRepresentation_SetInteractionState_27(HandleRef pThis, int _arg);

		/// <summary>
		/// The interaction state may be set from a widget (e.g., vtkLineWidget2) or
		/// other object. This controls how the interaction with the widget
		/// proceeds. Normally this method is used as part of a handshaking
		/// process with the widget: First ComputeInteractionState() is invoked that
		/// returns a state based on geometric considerations (i.e., cursor near a
		/// widget feature), then based on events, the widget may modify this
		/// further.
		/// </summary>
		// Token: 0x06007EF2 RID: 32498 RVA: 0x000B62BF File Offset: 0x000B44BF
		public virtual void SetInteractionState(int _arg)
		{
			vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_SetInteractionState_27(base.GetCppThis(), _arg);
		}

		// Token: 0x06007EF3 RID: 32499
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesTransformRepresentation_SetLabelFormat_28(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify the format to use for labelling information during
		/// transformation. Note that an empty string results in no label, or a
		/// format string without a "%" character will not print numeric values.
		/// </summary>
		// Token: 0x06007EF4 RID: 32500 RVA: 0x000B62CF File Offset: 0x000B44CF
		public virtual void SetLabelFormat(string _arg)
		{
			vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_SetLabelFormat_28(base.GetCppThis(), _arg);
		}

		// Token: 0x06007EF5 RID: 32501
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesTransformRepresentation_SetLabelScale_29(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Scale text (font size along each dimension). This helps control
		/// the appearance of the 3D text.
		/// </summary>
		// Token: 0x06007EF6 RID: 32502 RVA: 0x000B62DF File Offset: 0x000B44DF
		public void SetLabelScale(double x, double y, double z)
		{
			vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_SetLabelScale_29(base.GetCppThis(), x, y, z);
		}

		// Token: 0x06007EF7 RID: 32503
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesTransformRepresentation_SetLabelScale_30(HandleRef pThis, IntPtr scale);

		/// <summary>
		/// Scale text (font size along each dimension). This helps control
		/// the appearance of the 3D text.
		/// </summary>
		// Token: 0x06007EF8 RID: 32504 RVA: 0x000B62F1 File Offset: 0x000B44F1
		public virtual void SetLabelScale(IntPtr scale)
		{
			vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_SetLabelScale_30(base.GetCppThis(), scale);
		}

		// Token: 0x06007EF9 RID: 32505
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesTransformRepresentation_SetOriginDisplayPosition_31(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06007EFA RID: 32506 RVA: 0x000B6301 File Offset: 0x000B4501
		public void SetOriginDisplayPosition(IntPtr pos)
		{
			vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_SetOriginDisplayPosition_31(base.GetCppThis(), pos);
		}

		// Token: 0x06007EFB RID: 32507
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesTransformRepresentation_SetOriginWorldPosition_32(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06007EFC RID: 32508 RVA: 0x000B6311 File Offset: 0x000B4511
		public void SetOriginWorldPosition(IntPtr pos)
		{
			vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_SetOriginWorldPosition_32(base.GetCppThis(), pos);
		}

		// Token: 0x06007EFD RID: 32509
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesTransformRepresentation_SetTolerance_33(HandleRef pThis, int _arg);

		/// <summary>
		/// The tolerance representing the distance to the widget (in pixels) in
		/// which the cursor is considered near enough to the end points of
		/// the widget to be active.
		/// </summary>
		// Token: 0x06007EFE RID: 32510 RVA: 0x000B6321 File Offset: 0x000B4521
		public virtual void SetTolerance(int _arg)
		{
			vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_SetTolerance_33(base.GetCppThis(), _arg);
		}

		// Token: 0x06007EFF RID: 32511
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesTransformRepresentation_StartWidgetInteraction_34(HandleRef pThis, IntPtr e);

		/// <summary>
		/// Method to satisfy superclasses' API.
		/// </summary>
		// Token: 0x06007F00 RID: 32512 RVA: 0x000B6331 File Offset: 0x000B4531
		public override void StartWidgetInteraction(IntPtr e)
		{
			vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_StartWidgetInteraction_34(base.GetCppThis(), e);
		}

		// Token: 0x06007F01 RID: 32513
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesTransformRepresentation_WidgetInteraction_35(HandleRef pThis, IntPtr e);

		/// <summary>
		/// Method to satisfy superclasses' API.
		/// </summary>
		// Token: 0x06007F02 RID: 32514 RVA: 0x000B6341 File Offset: 0x000B4541
		public override void WidgetInteraction(IntPtr e)
		{
			vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_WidgetInteraction_35(base.GetCppThis(), e);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000AB0 RID: 2736
		public new const string MRFullTypeName = "Kitware.VTK.vtkAxesTransformRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000AB1 RID: 2737
		public new static readonly string MRClassNameKey = "class vtkAxesTransformRepresentation";

		/// <summary>
		/// Enum used to communicate interaction state.
		/// </summary>
		// Token: 0x020002BE RID: 702
		public enum OnOrigin_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000AB3 RID: 2739
			OnOrigin = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000AB4 RID: 2740
			OnX,
			/// <summary>enum member</summary>
			// Token: 0x04000AB5 RID: 2741
			OnXEnd = 5,
			/// <summary>enum member</summary>
			// Token: 0x04000AB6 RID: 2742
			OnY = 3,
			/// <summary>enum member</summary>
			// Token: 0x04000AB7 RID: 2743
			OnYEnd = 6,
			/// <summary>enum member</summary>
			// Token: 0x04000AB8 RID: 2744
			OnZ = 4,
			/// <summary>enum member</summary>
			// Token: 0x04000AB9 RID: 2745
			OnZEnd = 7,
			/// <summary>enum member</summary>
			// Token: 0x04000ABA RID: 2746
			Outside = 0
		}
	}
}
