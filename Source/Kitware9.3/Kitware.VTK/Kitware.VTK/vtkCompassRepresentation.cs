using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCompassRepresentation
	/// </summary>
	/// <remarks>
	///    provide a compass and distance, tilt sliders
	///
	/// This class is used to represent and render a compass to represent a heading, and two vertical
	/// sliders to manipulate distance and tilt.
	///
	/// If distance or tilt sliders are not required then their Visibility can be set to off when
	/// subclassing it.
	///
	/// Override the GetStatusText() method if you require a customized status text.
	/// </remarks>
	// Token: 0x020002FA RID: 762
	public class vtkCompassRepresentation : vtkContinuousValueWidgetRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06008837 RID: 34871 RVA: 0x000C2AB3 File Offset: 0x000C0CB3
		static vtkCompassRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCompassRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCompassRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06008838 RID: 34872 RVA: 0x000C2ADB File Offset: 0x000C0CDB
		public vtkCompassRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06008839 RID: 34873
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompassRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x0600883A RID: 34874 RVA: 0x000C2AEC File Offset: 0x000C0CEC
		public new static vtkCompassRepresentation New()
		{
			vtkCompassRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompassRepresentation.vtkCompassRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompassRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x0600883B RID: 34875 RVA: 0x000C2B40 File Offset: 0x000C0D40
		public vtkCompassRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCompassRepresentation.vtkCompassRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600883C RID: 34876 RVA: 0x000C2B84 File Offset: 0x000C0D84
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600883D RID: 34877
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompassRepresentation_BuildRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Methods to interface with the vtkSliderWidget. The PlaceWidget() method
		/// assumes that the parameter bounds[6] specifies the location in display
		/// space where the widget should be placed.
		/// </summary>
		// Token: 0x0600883E RID: 34878 RVA: 0x000C2B8F File Offset: 0x000C0D8F
		public override void BuildRepresentation()
		{
			vtkCompassRepresentation.vtkCompassRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		// Token: 0x0600883F RID: 34879
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompassRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

		/// <summary>
		/// Methods to interface with the vtkSliderWidget. The PlaceWidget() method
		/// assumes that the parameter bounds[6] specifies the location in display
		/// space where the widget should be placed.
		/// </summary>
		// Token: 0x06008840 RID: 34880 RVA: 0x000C2BA0 File Offset: 0x000C0DA0
		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkCompassRepresentation.vtkCompassRepresentation_ComputeInteractionState_02(base.GetCppThis(), X, Y, modify);
		}

		// Token: 0x06008841 RID: 34881
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompassRepresentation_DistanceWidgetInteraction_03(HandleRef pThis, IntPtr eventPos);

		/// <summary>
		/// Methods to interface with the vtkSliderWidget. The PlaceWidget() method
		/// assumes that the parameter bounds[6] specifies the location in display
		/// space where the widget should be placed.
		/// </summary>
		// Token: 0x06008842 RID: 34882 RVA: 0x000C2BC2 File Offset: 0x000C0DC2
		public virtual void DistanceWidgetInteraction(IntPtr eventPos)
		{
			vtkCompassRepresentation.vtkCompassRepresentation_DistanceWidgetInteraction_03(base.GetCppThis(), eventPos);
		}

		// Token: 0x06008843 RID: 34883
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompassRepresentation_EndDistance_04(HandleRef pThis);

		/// <summary>
		/// Update the distance by the given delta.
		/// </summary>
		// Token: 0x06008844 RID: 34884 RVA: 0x000C2BD2 File Offset: 0x000C0DD2
		public virtual void EndDistance()
		{
			vtkCompassRepresentation.vtkCompassRepresentation_EndDistance_04(base.GetCppThis());
		}

		// Token: 0x06008845 RID: 34885
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompassRepresentation_EndTilt_05(HandleRef pThis);

		/// <summary>
		/// Update the tilt by the given delta in degrees.
		/// </summary>
		// Token: 0x06008846 RID: 34886 RVA: 0x000C2BE1 File Offset: 0x000C0DE1
		public virtual void EndTilt()
		{
			vtkCompassRepresentation.vtkCompassRepresentation_EndTilt_05(base.GetCppThis());
		}

		// Token: 0x06008847 RID: 34887
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompassRepresentation_GetActors_06(HandleRef pThis, HandleRef propCollection);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x06008848 RID: 34888 RVA: 0x000C2BF0 File Offset: 0x000C0DF0
		public override void GetActors(vtkPropCollection propCollection)
		{
			vtkCompassRepresentation.vtkCompassRepresentation_GetActors_06(base.GetCppThis(), (propCollection == null) ? default(HandleRef) : propCollection.GetCppThis());
		}

		// Token: 0x06008849 RID: 34889
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCompassRepresentation_GetDistance_07(HandleRef pThis);

		/// <summary>
		/// Get/Set the distance. These methods ensure that the distance is in the range set by
		/// SetMaximumDistance() and SetMinimumDistance().
		/// </summary>
		// Token: 0x0600884A RID: 34890 RVA: 0x000C2C20 File Offset: 0x000C0E20
		public virtual double GetDistance()
		{
			return vtkCompassRepresentation.vtkCompassRepresentation_GetDistance_07(base.GetCppThis());
		}

		// Token: 0x0600884B RID: 34891
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCompassRepresentation_GetHeading_08(HandleRef pThis);

		/// <summary>
		/// Get/Set the heading in degrees. The methods ensure that the heading is in the range [0, 360)
		/// degrees.
		/// </summary>
		// Token: 0x0600884C RID: 34892 RVA: 0x000C2C40 File Offset: 0x000C0E40
		public virtual double GetHeading()
		{
			return vtkCompassRepresentation.vtkCompassRepresentation_GetHeading_08(base.GetCppThis());
		}

		// Token: 0x0600884D RID: 34893
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompassRepresentation_GetLabelProperty_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the properties for the label and title text.
		/// </summary>
		// Token: 0x0600884E RID: 34894 RVA: 0x000C2C60 File Offset: 0x000C0E60
		public virtual vtkTextProperty GetLabelProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompassRepresentation.vtkCompassRepresentation_GetLabelProperty_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600884F RID: 34895
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCompassRepresentation_GetMaximumDistance_10(HandleRef pThis);

		/// <summary>
		/// Get/Set the distance range. The default is [0.0, 2.0].
		/// </summary>
		// Token: 0x06008850 RID: 34896 RVA: 0x000C2CD0 File Offset: 0x000C0ED0
		public double GetMaximumDistance()
		{
			return vtkCompassRepresentation.vtkCompassRepresentation_GetMaximumDistance_10(base.GetCppThis());
		}

		// Token: 0x06008851 RID: 34897
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCompassRepresentation_GetMaximumTiltAngle_11(HandleRef pThis);

		/// <summary>
		/// Get/Set the tilt range. These default range is [-90, 90] degrees.
		/// </summary>
		// Token: 0x06008852 RID: 34898 RVA: 0x000C2CF0 File Offset: 0x000C0EF0
		public double GetMaximumTiltAngle()
		{
			return vtkCompassRepresentation.vtkCompassRepresentation_GetMaximumTiltAngle_11(base.GetCppThis());
		}

		// Token: 0x06008853 RID: 34899
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCompassRepresentation_GetMinimumDistance_12(HandleRef pThis);

		/// <summary>
		/// Get/Set the distance range. The default is [0.0, 2.0].
		/// </summary>
		// Token: 0x06008854 RID: 34900 RVA: 0x000C2D10 File Offset: 0x000C0F10
		public double GetMinimumDistance()
		{
			return vtkCompassRepresentation.vtkCompassRepresentation_GetMinimumDistance_12(base.GetCppThis());
		}

		// Token: 0x06008855 RID: 34901
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCompassRepresentation_GetMinimumTiltAngle_13(HandleRef pThis);

		/// <summary>
		/// Get/Set the tilt range. These default range is [-90, 90] degrees.
		/// </summary>
		// Token: 0x06008856 RID: 34902 RVA: 0x000C2D30 File Offset: 0x000C0F30
		public double GetMinimumTiltAngle()
		{
			return vtkCompassRepresentation.vtkCompassRepresentation_GetMinimumTiltAngle_13(base.GetCppThis());
		}

		// Token: 0x06008857 RID: 34903
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompassRepresentation_GetNumberOfGenerationsFromBase_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06008858 RID: 34904 RVA: 0x000C2D50 File Offset: 0x000C0F50
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCompassRepresentation.vtkCompassRepresentation_GetNumberOfGenerationsFromBase_14(base.GetCppThis(), type);
		}

		// Token: 0x06008859 RID: 34905
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompassRepresentation_GetNumberOfGenerationsFromBaseType_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x0600885A RID: 34906 RVA: 0x000C2D70 File Offset: 0x000C0F70
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCompassRepresentation.vtkCompassRepresentation_GetNumberOfGenerationsFromBaseType_15(type);
		}

		// Token: 0x0600885B RID: 34907
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompassRepresentation_GetPoint1Coordinate_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Position the first end point of the slider. Note that this point is an
		/// instance of vtkCoordinate, meaning that Point 1 can be specified in a
		/// variety of coordinate systems, and can even be relative to another
		/// point. To set the point, you'll want to get the Point1Coordinate and
		/// then invoke the necessary methods to put it into the correct coordinate
		/// system and set the correct initial value.
		/// </summary>
		// Token: 0x0600885C RID: 34908 RVA: 0x000C2D8C File Offset: 0x000C0F8C
		public vtkCoordinate GetPoint1Coordinate()
		{
			vtkCoordinate vtkCoordinate = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompassRepresentation.vtkCompassRepresentation_GetPoint1Coordinate_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600885D RID: 34909
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompassRepresentation_GetPoint2Coordinate_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Position the second end point of the slider. Note that this point is an
		/// instance of vtkCoordinate, meaning that Point 1 can be specified in a
		/// variety of coordinate systems, and can even be relative to another
		/// point. To set the point, you'll want to get the Point2Coordinate and
		/// then invoke the necessary methods to put it into the correct coordinate
		/// system and set the correct initial value.
		/// </summary>
		// Token: 0x0600885E RID: 34910 RVA: 0x000C2DFC File Offset: 0x000C0FFC
		public vtkCoordinate GetPoint2Coordinate()
		{
			vtkCoordinate vtkCoordinate = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompassRepresentation.vtkCompassRepresentation_GetPoint2Coordinate_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600885F RID: 34911
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompassRepresentation_GetRingProperty_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the slider properties. The properties of the slider when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x06008860 RID: 34912 RVA: 0x000C2E6C File Offset: 0x000C106C
		public virtual vtkProperty2D GetRingProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompassRepresentation.vtkCompassRepresentation_GetRingProperty_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008861 RID: 34913
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompassRepresentation_GetSelectedProperty_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the selection property. This property is used to modify the
		/// appearance of selected objects (e.g., the slider).
		/// </summary>
		// Token: 0x06008862 RID: 34914 RVA: 0x000C2EDC File Offset: 0x000C10DC
		public virtual vtkProperty2D GetSelectedProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompassRepresentation.vtkCompassRepresentation_GetSelectedProperty_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008863 RID: 34915
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCompassRepresentation_GetTilt_20(HandleRef pThis);

		/// <summary>
		/// Get/Set the tilt in degrees. The methods ensure that the tilt is in the range set by
		/// SetMaximumTiltAngle() and SetMinimumTiltAngle().
		/// </summary>
		// Token: 0x06008864 RID: 34916 RVA: 0x000C2F4C File Offset: 0x000C114C
		public virtual double GetTilt()
		{
			return vtkCompassRepresentation.vtkCompassRepresentation_GetTilt_20(base.GetCppThis());
		}

		// Token: 0x06008865 RID: 34917
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompassRepresentation_Highlight_21(HandleRef pThis, int arg0);

		/// <summary>
		/// Methods to interface with the vtkSliderWidget. The PlaceWidget() method
		/// assumes that the parameter bounds[6] specifies the location in display
		/// space where the widget should be placed.
		/// </summary>
		// Token: 0x06008866 RID: 34918 RVA: 0x000C2F6B File Offset: 0x000C116B
		public override void Highlight(int arg0)
		{
			vtkCompassRepresentation.vtkCompassRepresentation_Highlight_21(base.GetCppThis(), arg0);
		}

		// Token: 0x06008867 RID: 34919
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompassRepresentation_IsA_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06008868 RID: 34920 RVA: 0x000C2F7C File Offset: 0x000C117C
		public override int IsA(string type)
		{
			return vtkCompassRepresentation.vtkCompassRepresentation_IsA_22(base.GetCppThis(), type);
		}

		// Token: 0x06008869 RID: 34921
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompassRepresentation_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x0600886A RID: 34922 RVA: 0x000C2F9C File Offset: 0x000C119C
		public new static int IsTypeOf(string type)
		{
			return vtkCompassRepresentation.vtkCompassRepresentation_IsTypeOf_23(type);
		}

		// Token: 0x0600886B RID: 34923
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompassRepresentation_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x0600886C RID: 34924 RVA: 0x000C2FB8 File Offset: 0x000C11B8
		public new vtkCompassRepresentation NewInstance()
		{
			vtkCompassRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompassRepresentation.vtkCompassRepresentation_NewInstance_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompassRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600886D RID: 34925
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompassRepresentation_PlaceWidget_26(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Methods to interface with the vtkSliderWidget. The PlaceWidget() method
		/// assumes that the parameter bounds[6] specifies the location in display
		/// space where the widget should be placed.
		/// </summary>
		// Token: 0x0600886E RID: 34926 RVA: 0x000C3012 File Offset: 0x000C1212
		public override void PlaceWidget(IntPtr bounds)
		{
			vtkCompassRepresentation.vtkCompassRepresentation_PlaceWidget_26(base.GetCppThis(), bounds);
		}

		// Token: 0x0600886F RID: 34927
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompassRepresentation_ReleaseGraphicsResources_27(HandleRef pThis, HandleRef window);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x06008870 RID: 34928 RVA: 0x000C3024 File Offset: 0x000C1224
		public override void ReleaseGraphicsResources(vtkWindow window)
		{
			vtkCompassRepresentation.vtkCompassRepresentation_ReleaseGraphicsResources_27(base.GetCppThis(), (window == null) ? default(HandleRef) : window.GetCppThis());
		}

		// Token: 0x06008871 RID: 34929
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompassRepresentation_RenderOpaqueGeometry_28(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x06008872 RID: 34930 RVA: 0x000C3054 File Offset: 0x000C1254
		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkCompassRepresentation.vtkCompassRepresentation_RenderOpaqueGeometry_28(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06008873 RID: 34931
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompassRepresentation_RenderOverlay_29(HandleRef pThis, HandleRef viewPort);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x06008874 RID: 34932 RVA: 0x000C3088 File Offset: 0x000C1288
		public override int RenderOverlay(vtkViewport viewPort)
		{
			return vtkCompassRepresentation.vtkCompassRepresentation_RenderOverlay_29(base.GetCppThis(), (viewPort == null) ? default(HandleRef) : viewPort.GetCppThis());
		}

		// Token: 0x06008875 RID: 34933
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompassRepresentation_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06008876 RID: 34934 RVA: 0x000C30BC File Offset: 0x000C12BC
		public new static vtkCompassRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkCompassRepresentation vtkCompassRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompassRepresentation.vtkCompassRepresentation_SafeDownCast_30((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompassRepresentation = (vtkCompassRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompassRepresentation.Register(null);
				}
			}
			return vtkCompassRepresentation;
		}

		// Token: 0x06008877 RID: 34935
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompassRepresentation_SetDistance_31(HandleRef pThis, double distance);

		/// <summary>
		/// Get/Set the distance. These methods ensure that the distance is in the range set by
		/// SetMaximumDistance() and SetMinimumDistance().
		/// </summary>
		// Token: 0x06008878 RID: 34936 RVA: 0x000C313B File Offset: 0x000C133B
		public virtual void SetDistance(double distance)
		{
			vtkCompassRepresentation.vtkCompassRepresentation_SetDistance_31(base.GetCppThis(), distance);
		}

		// Token: 0x06008879 RID: 34937
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompassRepresentation_SetHeading_32(HandleRef pThis, double heading);

		/// <summary>
		/// Get/Set the heading in degrees. The methods ensure that the heading is in the range [0, 360)
		/// degrees.
		/// </summary>
		// Token: 0x0600887A RID: 34938 RVA: 0x000C314B File Offset: 0x000C134B
		public virtual void SetHeading(double heading)
		{
			vtkCompassRepresentation.vtkCompassRepresentation_SetHeading_32(base.GetCppThis(), heading);
		}

		// Token: 0x0600887B RID: 34939
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompassRepresentation_SetMaximumDistance_33(HandleRef pThis, double distance);

		/// <summary>
		/// Get/Set the distance range. The default is [0.0, 2.0].
		/// </summary>
		// Token: 0x0600887C RID: 34940 RVA: 0x000C315B File Offset: 0x000C135B
		public void SetMaximumDistance(double distance)
		{
			vtkCompassRepresentation.vtkCompassRepresentation_SetMaximumDistance_33(base.GetCppThis(), distance);
		}

		// Token: 0x0600887D RID: 34941
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompassRepresentation_SetMaximumTiltAngle_34(HandleRef pThis, double angle);

		/// <summary>
		/// Get/Set the tilt range. These default range is [-90, 90] degrees.
		/// </summary>
		// Token: 0x0600887E RID: 34942 RVA: 0x000C316B File Offset: 0x000C136B
		public void SetMaximumTiltAngle(double angle)
		{
			vtkCompassRepresentation.vtkCompassRepresentation_SetMaximumTiltAngle_34(base.GetCppThis(), angle);
		}

		// Token: 0x0600887F RID: 34943
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompassRepresentation_SetMinimumDistance_35(HandleRef pThis, double distance);

		/// <summary>
		/// Get/Set the distance range. The default is [0.0, 2.0].
		/// </summary>
		// Token: 0x06008880 RID: 34944 RVA: 0x000C317B File Offset: 0x000C137B
		public void SetMinimumDistance(double distance)
		{
			vtkCompassRepresentation.vtkCompassRepresentation_SetMinimumDistance_35(base.GetCppThis(), distance);
		}

		// Token: 0x06008881 RID: 34945
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompassRepresentation_SetMinimumTiltAngle_36(HandleRef pThis, double angle);

		/// <summary>
		/// Get/Set the tilt range. These default range is [-90, 90] degrees.
		/// </summary>
		// Token: 0x06008882 RID: 34946 RVA: 0x000C318B File Offset: 0x000C138B
		public void SetMinimumTiltAngle(double angle)
		{
			vtkCompassRepresentation.vtkCompassRepresentation_SetMinimumTiltAngle_36(base.GetCppThis(), angle);
		}

		// Token: 0x06008883 RID: 34947
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompassRepresentation_SetRenderer_37(HandleRef pThis, HandleRef renderer);

		/// <summary>
		/// Update the distance by the given delta.
		/// </summary>
		// Token: 0x06008884 RID: 34948 RVA: 0x000C319C File Offset: 0x000C139C
		public override void SetRenderer(vtkRenderer renderer)
		{
			vtkCompassRepresentation.vtkCompassRepresentation_SetRenderer_37(base.GetCppThis(), (renderer == null) ? default(HandleRef) : renderer.GetCppThis());
		}

		// Token: 0x06008885 RID: 34949
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompassRepresentation_SetTilt_38(HandleRef pThis, double tilt);

		/// <summary>
		/// Get/Set the tilt in degrees. The methods ensure that the tilt is in the range set by
		/// SetMaximumTiltAngle() and SetMinimumTiltAngle().
		/// </summary>
		// Token: 0x06008886 RID: 34950 RVA: 0x000C31CB File Offset: 0x000C13CB
		public virtual void SetTilt(double tilt)
		{
			vtkCompassRepresentation.vtkCompassRepresentation_SetTilt_38(base.GetCppThis(), tilt);
		}

		// Token: 0x06008887 RID: 34951
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompassRepresentation_StartWidgetInteraction_39(HandleRef pThis, IntPtr eventPos);

		/// <summary>
		/// Methods to interface with the vtkSliderWidget. The PlaceWidget() method
		/// assumes that the parameter bounds[6] specifies the location in display
		/// space where the widget should be placed.
		/// </summary>
		// Token: 0x06008888 RID: 34952 RVA: 0x000C31DB File Offset: 0x000C13DB
		public override void StartWidgetInteraction(IntPtr eventPos)
		{
			vtkCompassRepresentation.vtkCompassRepresentation_StartWidgetInteraction_39(base.GetCppThis(), eventPos);
		}

		// Token: 0x06008889 RID: 34953
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompassRepresentation_TiltWidgetInteraction_40(HandleRef pThis, IntPtr eventPos);

		/// <summary>
		/// Methods to interface with the vtkSliderWidget. The PlaceWidget() method
		/// assumes that the parameter bounds[6] specifies the location in display
		/// space where the widget should be placed.
		/// </summary>
		// Token: 0x0600888A RID: 34954 RVA: 0x000C31EB File Offset: 0x000C13EB
		public virtual void TiltWidgetInteraction(IntPtr eventPos)
		{
			vtkCompassRepresentation.vtkCompassRepresentation_TiltWidgetInteraction_40(base.GetCppThis(), eventPos);
		}

		// Token: 0x0600888B RID: 34955
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompassRepresentation_UpdateDistance_41(HandleRef pThis, double deltaDistance);

		/// <summary>
		/// Update the distance by the given delta.
		/// </summary>
		// Token: 0x0600888C RID: 34956 RVA: 0x000C31FB File Offset: 0x000C13FB
		public virtual void UpdateDistance(double deltaDistance)
		{
			vtkCompassRepresentation.vtkCompassRepresentation_UpdateDistance_41(base.GetCppThis(), deltaDistance);
		}

		// Token: 0x0600888D RID: 34957
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompassRepresentation_UpdateTilt_42(HandleRef pThis, double deltaTilt);

		/// <summary>
		/// Update the tilt by the given delta in degrees.
		/// </summary>
		// Token: 0x0600888E RID: 34958 RVA: 0x000C320B File Offset: 0x000C140B
		public virtual void UpdateTilt(double deltaTilt)
		{
			vtkCompassRepresentation.vtkCompassRepresentation_UpdateTilt_42(base.GetCppThis(), deltaTilt);
		}

		// Token: 0x0600888F RID: 34959
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompassRepresentation_WidgetInteraction_43(HandleRef pThis, IntPtr eventPos);

		/// <summary>
		/// Methods to interface with the vtkSliderWidget. The PlaceWidget() method
		/// assumes that the parameter bounds[6] specifies the location in display
		/// space where the widget should be placed.
		/// </summary>
		// Token: 0x06008890 RID: 34960 RVA: 0x000C321B File Offset: 0x000C141B
		public override void WidgetInteraction(IntPtr eventPos)
		{
			vtkCompassRepresentation.vtkCompassRepresentation_WidgetInteraction_43(base.GetCppThis(), eventPos);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B80 RID: 2944
		public new const string MRFullTypeName = "Kitware.VTK.vtkCompassRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B81 RID: 2945
		public new static readonly string MRClassNameKey = "class vtkCompassRepresentation";

		/// <summary>
		/// Update the distance by the given delta.
		/// </summary>
		// Token: 0x020002FB RID: 763
		public new enum InteractionStateType
		{
			/// <summary>enum member</summary>
			// Token: 0x04000B83 RID: 2947
			Adjusting = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000B84 RID: 2948
			DistanceAdjusting = 8,
			/// <summary>enum member</summary>
			// Token: 0x04000B85 RID: 2949
			DistanceIn = 7,
			/// <summary>enum member</summary>
			// Token: 0x04000B86 RID: 2950
			DistanceOut = 6,
			/// <summary>enum member</summary>
			// Token: 0x04000B87 RID: 2951
			Inside = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000B88 RID: 2952
			Outside = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000B89 RID: 2953
			TiltAdjusting = 5,
			/// <summary>enum member</summary>
			// Token: 0x04000B8A RID: 2954
			TiltDown = 3,
			/// <summary>enum member</summary>
			// Token: 0x04000B8B RID: 2955
			TiltUp
		}
	}
}
