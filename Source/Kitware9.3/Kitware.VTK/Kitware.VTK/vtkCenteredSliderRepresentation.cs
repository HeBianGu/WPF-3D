using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCenteredSliderRepresentation
	/// </summary>
	/// <remarks>
	///    provide the representation for a vtkCenteredSliderWidget
	///
	/// This class is used to represent and render a vtkCenteredSliderWidget. To use this
	/// class, you must at a minimum specify the end points of the
	/// slider. Optional instance variable can be used to modify the appearance of
	/// the widget.
	///
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkSliderWidget
	/// </seealso>
	// Token: 0x020002F2 RID: 754
	public class vtkCenteredSliderRepresentation : vtkSliderRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06008742 RID: 34626 RVA: 0x000C1035 File Offset: 0x000BF235
		static vtkCenteredSliderRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCenteredSliderRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCenteredSliderRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06008743 RID: 34627 RVA: 0x000C105D File Offset: 0x000BF25D
		public vtkCenteredSliderRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06008744 RID: 34628
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCenteredSliderRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x06008745 RID: 34629 RVA: 0x000C106C File Offset: 0x000BF26C
		public new static vtkCenteredSliderRepresentation New()
		{
			vtkCenteredSliderRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCenteredSliderRepresentation.vtkCenteredSliderRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCenteredSliderRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x06008746 RID: 34630 RVA: 0x000C10C0 File Offset: 0x000BF2C0
		public vtkCenteredSliderRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCenteredSliderRepresentation.vtkCenteredSliderRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06008747 RID: 34631 RVA: 0x000C1104 File Offset: 0x000BF304
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06008748 RID: 34632
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCenteredSliderRepresentation_BuildRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Methods to interface with the vtkSliderWidget. The PlaceWidget() method
		/// assumes that the parameter bounds[6] specifies the location in display
		/// space where the widget should be placed.
		/// </summary>
		// Token: 0x06008749 RID: 34633 RVA: 0x000C110F File Offset: 0x000BF30F
		public override void BuildRepresentation()
		{
			vtkCenteredSliderRepresentation.vtkCenteredSliderRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		// Token: 0x0600874A RID: 34634
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCenteredSliderRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

		/// <summary>
		/// Methods to interface with the vtkSliderWidget. The PlaceWidget() method
		/// assumes that the parameter bounds[6] specifies the location in display
		/// space where the widget should be placed.
		/// </summary>
		// Token: 0x0600874B RID: 34635 RVA: 0x000C1120 File Offset: 0x000BF320
		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkCenteredSliderRepresentation.vtkCenteredSliderRepresentation_ComputeInteractionState_02(base.GetCppThis(), X, Y, modify);
		}

		// Token: 0x0600874C RID: 34636
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCenteredSliderRepresentation_GetActors_03(HandleRef pThis, HandleRef propCollections);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x0600874D RID: 34637 RVA: 0x000C1144 File Offset: 0x000BF344
		public override void GetActors(vtkPropCollection propCollections)
		{
			vtkCenteredSliderRepresentation.vtkCenteredSliderRepresentation_GetActors_03(base.GetCppThis(), (propCollections == null) ? default(HandleRef) : propCollections.GetCppThis());
		}

		// Token: 0x0600874E RID: 34638
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCenteredSliderRepresentation_GetLabelProperty_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the properties for the label and title text.
		/// </summary>
		// Token: 0x0600874F RID: 34639 RVA: 0x000C1174 File Offset: 0x000BF374
		public virtual vtkTextProperty GetLabelProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCenteredSliderRepresentation.vtkCenteredSliderRepresentation_GetLabelProperty_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008750 RID: 34640
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCenteredSliderRepresentation_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06008751 RID: 34641 RVA: 0x000C11E4 File Offset: 0x000BF3E4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCenteredSliderRepresentation.vtkCenteredSliderRepresentation_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06008752 RID: 34642
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCenteredSliderRepresentation_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06008753 RID: 34643 RVA: 0x000C1204 File Offset: 0x000BF404
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCenteredSliderRepresentation.vtkCenteredSliderRepresentation_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06008754 RID: 34644
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCenteredSliderRepresentation_GetPoint1Coordinate_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Position the first end point of the slider. Note that this point is an
		/// instance of vtkCoordinate, meaning that Point 1 can be specified in a
		/// variety of coordinate systems, and can even be relative to another
		/// point. To set the point, you'll want to get the Point1Coordinate and
		/// then invoke the necessary methods to put it into the correct coordinate
		/// system and set the correct initial value.
		/// </summary>
		// Token: 0x06008755 RID: 34645 RVA: 0x000C1220 File Offset: 0x000BF420
		public vtkCoordinate GetPoint1Coordinate()
		{
			vtkCoordinate vtkCoordinate = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCenteredSliderRepresentation.vtkCenteredSliderRepresentation_GetPoint1Coordinate_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008756 RID: 34646
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCenteredSliderRepresentation_GetPoint2Coordinate_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Position the second end point of the slider. Note that this point is an
		/// instance of vtkCoordinate, meaning that Point 1 can be specified in a
		/// variety of coordinate systems, and can even be relative to another
		/// point. To set the point, you'll want to get the Point2Coordinate and
		/// then invoke the necessary methods to put it into the correct coordinate
		/// system and set the correct initial value.
		/// </summary>
		// Token: 0x06008757 RID: 34647 RVA: 0x000C1290 File Offset: 0x000BF490
		public vtkCoordinate GetPoint2Coordinate()
		{
			vtkCoordinate vtkCoordinate = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCenteredSliderRepresentation.vtkCenteredSliderRepresentation_GetPoint2Coordinate_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008758 RID: 34648
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCenteredSliderRepresentation_GetSelectedProperty_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the selection property. This property is used to modify the
		/// appearance of selected objects (e.g., the slider).
		/// </summary>
		// Token: 0x06008759 RID: 34649 RVA: 0x000C1300 File Offset: 0x000BF500
		public virtual vtkProperty2D GetSelectedProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCenteredSliderRepresentation.vtkCenteredSliderRepresentation_GetSelectedProperty_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600875A RID: 34650
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCenteredSliderRepresentation_GetSliderProperty_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the properties for the tube and slider
		/// </summary>
		// Token: 0x0600875B RID: 34651 RVA: 0x000C1370 File Offset: 0x000BF570
		public virtual vtkProperty2D GetSliderProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCenteredSliderRepresentation.vtkCenteredSliderRepresentation_GetSliderProperty_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600875C RID: 34652
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCenteredSliderRepresentation_GetTitleText_11(HandleRef pThis);

		/// <summary>
		/// Specify the label text for this widget. If the value is not set, or set
		/// to the empty string "", then the label text is not displayed.
		/// </summary>
		// Token: 0x0600875D RID: 34653 RVA: 0x000C13E0 File Offset: 0x000BF5E0
		public override string GetTitleText()
		{
			string s = Marshal.PtrToStringAnsi(vtkCenteredSliderRepresentation.vtkCenteredSliderRepresentation_GetTitleText_11(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600875E RID: 34654
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCenteredSliderRepresentation_GetTubeProperty_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the properties for the tube and slider
		/// </summary>
		// Token: 0x0600875F RID: 34655 RVA: 0x000C141C File Offset: 0x000BF61C
		public virtual vtkProperty2D GetTubeProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCenteredSliderRepresentation.vtkCenteredSliderRepresentation_GetTubeProperty_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008760 RID: 34656
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCenteredSliderRepresentation_Highlight_13(HandleRef pThis, int arg0);

		/// <summary>
		/// Methods to interface with the vtkSliderWidget. The PlaceWidget() method
		/// assumes that the parameter bounds[6] specifies the location in display
		/// space where the widget should be placed.
		/// </summary>
		// Token: 0x06008761 RID: 34657 RVA: 0x000C148B File Offset: 0x000BF68B
		public override void Highlight(int arg0)
		{
			vtkCenteredSliderRepresentation.vtkCenteredSliderRepresentation_Highlight_13(base.GetCppThis(), arg0);
		}

		// Token: 0x06008762 RID: 34658
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCenteredSliderRepresentation_IsA_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06008763 RID: 34659 RVA: 0x000C149C File Offset: 0x000BF69C
		public override int IsA(string type)
		{
			return vtkCenteredSliderRepresentation.vtkCenteredSliderRepresentation_IsA_14(base.GetCppThis(), type);
		}

		// Token: 0x06008764 RID: 34660
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCenteredSliderRepresentation_IsTypeOf_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06008765 RID: 34661 RVA: 0x000C14BC File Offset: 0x000BF6BC
		public new static int IsTypeOf(string type)
		{
			return vtkCenteredSliderRepresentation.vtkCenteredSliderRepresentation_IsTypeOf_15(type);
		}

		// Token: 0x06008766 RID: 34662
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCenteredSliderRepresentation_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06008767 RID: 34663 RVA: 0x000C14D8 File Offset: 0x000BF6D8
		public new vtkCenteredSliderRepresentation NewInstance()
		{
			vtkCenteredSliderRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCenteredSliderRepresentation.vtkCenteredSliderRepresentation_NewInstance_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCenteredSliderRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06008768 RID: 34664
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCenteredSliderRepresentation_PlaceWidget_18(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Methods to interface with the vtkSliderWidget. The PlaceWidget() method
		/// assumes that the parameter bounds[6] specifies the location in display
		/// space where the widget should be placed.
		/// </summary>
		// Token: 0x06008769 RID: 34665 RVA: 0x000C1532 File Offset: 0x000BF732
		public override void PlaceWidget(IntPtr bounds)
		{
			vtkCenteredSliderRepresentation.vtkCenteredSliderRepresentation_PlaceWidget_18(base.GetCppThis(), bounds);
		}

		// Token: 0x0600876A RID: 34666
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCenteredSliderRepresentation_ReleaseGraphicsResources_19(HandleRef pThis, HandleRef window);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x0600876B RID: 34667 RVA: 0x000C1544 File Offset: 0x000BF744
		public override void ReleaseGraphicsResources(vtkWindow window)
		{
			vtkCenteredSliderRepresentation.vtkCenteredSliderRepresentation_ReleaseGraphicsResources_19(base.GetCppThis(), (window == null) ? default(HandleRef) : window.GetCppThis());
		}

		// Token: 0x0600876C RID: 34668
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCenteredSliderRepresentation_RenderOpaqueGeometry_20(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x0600876D RID: 34669 RVA: 0x000C1574 File Offset: 0x000BF774
		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkCenteredSliderRepresentation.vtkCenteredSliderRepresentation_RenderOpaqueGeometry_20(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600876E RID: 34670
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCenteredSliderRepresentation_RenderOverlay_21(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x0600876F RID: 34671 RVA: 0x000C15A8 File Offset: 0x000BF7A8
		public override int RenderOverlay(vtkViewport arg0)
		{
			return vtkCenteredSliderRepresentation.vtkCenteredSliderRepresentation_RenderOverlay_21(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06008770 RID: 34672
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCenteredSliderRepresentation_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06008771 RID: 34673 RVA: 0x000C15DC File Offset: 0x000BF7DC
		public new static vtkCenteredSliderRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkCenteredSliderRepresentation vtkCenteredSliderRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCenteredSliderRepresentation.vtkCenteredSliderRepresentation_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCenteredSliderRepresentation = (vtkCenteredSliderRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCenteredSliderRepresentation.Register(null);
				}
			}
			return vtkCenteredSliderRepresentation;
		}

		// Token: 0x06008772 RID: 34674
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCenteredSliderRepresentation_SetTitleText_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Specify the label text for this widget. If the value is not set, or set
		/// to the empty string "", then the label text is not displayed.
		/// </summary>
		// Token: 0x06008773 RID: 34675 RVA: 0x000C165B File Offset: 0x000BF85B
		public override void SetTitleText(string arg0)
		{
			vtkCenteredSliderRepresentation.vtkCenteredSliderRepresentation_SetTitleText_23(base.GetCppThis(), arg0);
		}

		// Token: 0x06008774 RID: 34676
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCenteredSliderRepresentation_StartWidgetInteraction_24(HandleRef pThis, IntPtr eventPos);

		/// <summary>
		/// Methods to interface with the vtkSliderWidget. The PlaceWidget() method
		/// assumes that the parameter bounds[6] specifies the location in display
		/// space where the widget should be placed.
		/// </summary>
		// Token: 0x06008775 RID: 34677 RVA: 0x000C166B File Offset: 0x000BF86B
		public override void StartWidgetInteraction(IntPtr eventPos)
		{
			vtkCenteredSliderRepresentation.vtkCenteredSliderRepresentation_StartWidgetInteraction_24(base.GetCppThis(), eventPos);
		}

		// Token: 0x06008776 RID: 34678
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCenteredSliderRepresentation_WidgetInteraction_25(HandleRef pThis, IntPtr eventPos);

		/// <summary>
		/// Methods to interface with the vtkSliderWidget. The PlaceWidget() method
		/// assumes that the parameter bounds[6] specifies the location in display
		/// space where the widget should be placed.
		/// </summary>
		// Token: 0x06008777 RID: 34679 RVA: 0x000C167B File Offset: 0x000BF87B
		public override void WidgetInteraction(IntPtr eventPos)
		{
			vtkCenteredSliderRepresentation.vtkCenteredSliderRepresentation_WidgetInteraction_25(base.GetCppThis(), eventPos);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B6B RID: 2923
		public new const string MRFullTypeName = "Kitware.VTK.vtkCenteredSliderRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B6C RID: 2924
		public new static readonly string MRClassNameKey = "class vtkCenteredSliderRepresentation";
	}
}
