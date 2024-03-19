using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPointWidget
	/// </summary>
	/// <remarks>
	///    position a point in 3D space
	///
	/// This 3D widget allows the user to position a point in 3D space using a 3D
	/// cursor. The cursor has an outline bounding box, axes-aligned cross-hairs,
	/// and axes shadows. (The outline and shadows can be turned off.) Any of
	/// these can be turned off. A nice feature of the object is that the
	/// vtkPointWidget, like any 3D widget, will work with the current interactor
	/// style. That is, if vtkPointWidget does not handle an event, then all other
	/// registered observers (including the interactor style) have an opportunity
	/// to process the event. Otherwise, the vtkPointWidget will terminate the
	/// processing of the event that it handles.
	///
	/// To use this object, just invoke SetInteractor() with the argument of the
	/// method a vtkRenderWindowInteractor.  You may also wish to invoke
	/// "PlaceWidget()" to initially position the widget. The interactor will act
	/// normally until the "i" key (for "interactor") is pressed, at which point
	/// the vtkPointWidget will appear. (See superclass documentation for
	/// information about changing this behavior.) To move the point, the user can
	/// grab (left mouse) on any widget line and "slide" the point into
	/// position. Scaling is achieved by using the right mouse button "up" the
	/// render window (makes the widget bigger) or "down" the render window (makes
	/// the widget smaller). To translate the widget use the middle mouse button.
	/// (Note: all of the translation interactions can be constrained to one of
	/// the x-y-z axes by using the "shift" key.) The vtkPointWidget produces as
	/// output a polydata with a single point and a vertex cell.
	///
	/// Some additional features of this class include the ability to control the
	/// rendered properties of the widget. You can set the properties of the
	/// selected and unselected representations of the parts of the widget. For
	/// example, you can set the property of the 3D cursor in its normal and
	/// selected states.
	///
	///
	/// The constrained translation/sliding action (i.e., when the "shift" key is
	/// depressed) along the axes is based on a combination of a "hot" spot around
	/// the cursor focus plus the initial mouse motion after selection. That is,
	/// if the user selects an axis outside of the hot spot, then the motion is
	/// constrained along that axis. If the user selects the point widget near the
	/// focus (within the hot spot), the initial motion defines a vector which is
	/// compared to the x-y-z axes. The motion is constrained to the axis that is
	/// most parallel to the initial motion vector.
	///
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtk3DWidget vtkLineWidget vtkBoxWidget vtkPlaneWidget
	/// </seealso>
	// Token: 0x02000355 RID: 853
	public class vtkPointWidget : vtk3DWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06009B4B RID: 39755 RVA: 0x000DBF37 File Offset: 0x000DA137
		static vtkPointWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPointWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06009B4C RID: 39756 RVA: 0x000DBF5F File Offset: 0x000DA15F
		public vtkPointWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06009B4D RID: 39757
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this widget
		/// </summary>
		// Token: 0x06009B4E RID: 39758 RVA: 0x000DBF70 File Offset: 0x000DA170
		public new static vtkPointWidget New()
		{
			vtkPointWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointWidget.vtkPointWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this widget
		/// </summary>
		// Token: 0x06009B4F RID: 39759 RVA: 0x000DBFC4 File Offset: 0x000DA1C4
		public vtkPointWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPointWidget.vtkPointWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06009B50 RID: 39760 RVA: 0x000DC008 File Offset: 0x000DA208
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06009B51 RID: 39761
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointWidget_AllOff_01(HandleRef pThis);

		/// <summary>
		/// Convenience methods to turn outline and shadows on and off.
		/// </summary>
		// Token: 0x06009B52 RID: 39762 RVA: 0x000DC013 File Offset: 0x000DA213
		public void AllOff()
		{
			vtkPointWidget.vtkPointWidget_AllOff_01(base.GetCppThis());
		}

		// Token: 0x06009B53 RID: 39763
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointWidget_AllOn_02(HandleRef pThis);

		/// <summary>
		/// Convenience methods to turn outline and shadows on and off.
		/// </summary>
		// Token: 0x06009B54 RID: 39764 RVA: 0x000DC022 File Offset: 0x000DA222
		public void AllOn()
		{
			vtkPointWidget.vtkPointWidget_AllOn_02(base.GetCppThis());
		}

		// Token: 0x06009B55 RID: 39765
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPointWidget_GetHotSpotSize_03(HandleRef pThis);

		/// <summary>
		/// Set the "hot spot" size; i.e., the region around the focus, in which the
		/// motion vector is used to control the constrained sliding action. Note the
		/// size is specified as a fraction of the length of the diagonal of the
		/// point widget's bounding box.
		/// </summary>
		// Token: 0x06009B56 RID: 39766 RVA: 0x000DC034 File Offset: 0x000DA234
		public virtual double GetHotSpotSize()
		{
			return vtkPointWidget.vtkPointWidget_GetHotSpotSize_03(base.GetCppThis());
		}

		// Token: 0x06009B57 RID: 39767
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPointWidget_GetHotSpotSizeMaxValue_04(HandleRef pThis);

		/// <summary>
		/// Set the "hot spot" size; i.e., the region around the focus, in which the
		/// motion vector is used to control the constrained sliding action. Note the
		/// size is specified as a fraction of the length of the diagonal of the
		/// point widget's bounding box.
		/// </summary>
		// Token: 0x06009B58 RID: 39768 RVA: 0x000DC054 File Offset: 0x000DA254
		public virtual double GetHotSpotSizeMaxValue()
		{
			return vtkPointWidget.vtkPointWidget_GetHotSpotSizeMaxValue_04(base.GetCppThis());
		}

		// Token: 0x06009B59 RID: 39769
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPointWidget_GetHotSpotSizeMinValue_05(HandleRef pThis);

		/// <summary>
		/// Set the "hot spot" size; i.e., the region around the focus, in which the
		/// motion vector is used to control the constrained sliding action. Note the
		/// size is specified as a fraction of the length of the diagonal of the
		/// point widget's bounding box.
		/// </summary>
		// Token: 0x06009B5A RID: 39770 RVA: 0x000DC074 File Offset: 0x000DA274
		public virtual double GetHotSpotSizeMinValue()
		{
			return vtkPointWidget.vtkPointWidget_GetHotSpotSizeMinValue_05(base.GetCppThis());
		}

		// Token: 0x06009B5B RID: 39771
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointWidget_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate this widget
		/// </summary>
		// Token: 0x06009B5C RID: 39772 RVA: 0x000DC094 File Offset: 0x000DA294
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPointWidget.vtkPointWidget_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x06009B5D RID: 39773
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointWidget_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate this widget
		/// </summary>
		// Token: 0x06009B5E RID: 39774 RVA: 0x000DC0B4 File Offset: 0x000DA2B4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPointWidget.vtkPointWidget_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x06009B5F RID: 39775
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointWidget_GetOutline_08(HandleRef pThis);

		/// <summary>
		/// Turn on/off the wireframe bounding box.
		/// </summary>
		// Token: 0x06009B60 RID: 39776 RVA: 0x000DC0D0 File Offset: 0x000DA2D0
		public int GetOutline()
		{
			return vtkPointWidget.vtkPointWidget_GetOutline_08(base.GetCppThis());
		}

		// Token: 0x06009B61 RID: 39777
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointWidget_GetPolyData_09(HandleRef pThis, HandleRef pd);

		/// <summary>
		/// Grab the polydata (including points) that defines the point. A
		/// single point and a vertex compose the vtkPolyData.
		/// </summary>
		// Token: 0x06009B62 RID: 39778 RVA: 0x000DC0F0 File Offset: 0x000DA2F0
		public void GetPolyData(vtkPolyData pd)
		{
			vtkPointWidget.vtkPointWidget_GetPolyData_09(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x06009B63 RID: 39779
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointWidget_GetPosition_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the position of the point. Note that if the position is set
		/// outside of the bounding box, it will be clamped to the boundary of
		/// the bounding box.
		/// </summary>
		// Token: 0x06009B64 RID: 39780 RVA: 0x000DC120 File Offset: 0x000DA320
		public double[] GetPosition()
		{
			IntPtr intPtr = vtkPointWidget.vtkPointWidget_GetPosition_10(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06009B65 RID: 39781
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointWidget_GetPosition_11(HandleRef pThis, IntPtr xyz);

		/// <summary>
		/// Set/Get the position of the point. Note that if the position is set
		/// outside of the bounding box, it will be clamped to the boundary of
		/// the bounding box.
		/// </summary>
		// Token: 0x06009B66 RID: 39782 RVA: 0x000DC168 File Offset: 0x000DA368
		public void GetPosition(IntPtr xyz)
		{
			vtkPointWidget.vtkPointWidget_GetPosition_11(base.GetCppThis(), xyz);
		}

		// Token: 0x06009B67 RID: 39783
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointWidget_GetProperty_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the handle properties (the little balls are the handles). The
		/// properties of the handles when selected and normal can be
		/// set.
		/// </summary>
		// Token: 0x06009B68 RID: 39784 RVA: 0x000DC178 File Offset: 0x000DA378
		public virtual vtkProperty GetProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointWidget.vtkPointWidget_GetProperty_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06009B69 RID: 39785
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointWidget_GetSelectedProperty_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the handle properties (the little balls are the handles). The
		/// properties of the handles when selected and normal can be
		/// set.
		/// </summary>
		// Token: 0x06009B6A RID: 39786 RVA: 0x000DC1E8 File Offset: 0x000DA3E8
		public virtual vtkProperty GetSelectedProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointWidget.vtkPointWidget_GetSelectedProperty_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06009B6B RID: 39787
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointWidget_GetTranslationMode_14(HandleRef pThis);

		/// <summary>
		/// If translation mode is on, as the widget is moved the bounding box,
		/// shadows, and cursor are all translated simultaneously as the point
		/// moves.
		/// </summary>
		// Token: 0x06009B6C RID: 39788 RVA: 0x000DC258 File Offset: 0x000DA458
		public int GetTranslationMode()
		{
			return vtkPointWidget.vtkPointWidget_GetTranslationMode_14(base.GetCppThis());
		}

		// Token: 0x06009B6D RID: 39789
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointWidget_GetXShadows_15(HandleRef pThis);

		/// <summary>
		/// Turn on/off the wireframe x-shadows.
		/// </summary>
		// Token: 0x06009B6E RID: 39790 RVA: 0x000DC278 File Offset: 0x000DA478
		public int GetXShadows()
		{
			return vtkPointWidget.vtkPointWidget_GetXShadows_15(base.GetCppThis());
		}

		// Token: 0x06009B6F RID: 39791
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointWidget_GetYShadows_16(HandleRef pThis);

		/// <summary>
		/// Turn on/off the wireframe y-shadows.
		/// </summary>
		// Token: 0x06009B70 RID: 39792 RVA: 0x000DC298 File Offset: 0x000DA498
		public int GetYShadows()
		{
			return vtkPointWidget.vtkPointWidget_GetYShadows_16(base.GetCppThis());
		}

		// Token: 0x06009B71 RID: 39793
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointWidget_GetZShadows_17(HandleRef pThis);

		/// <summary>
		/// Turn on/off the wireframe z-shadows.
		/// </summary>
		// Token: 0x06009B72 RID: 39794 RVA: 0x000DC2B8 File Offset: 0x000DA4B8
		public int GetZShadows()
		{
			return vtkPointWidget.vtkPointWidget_GetZShadows_17(base.GetCppThis());
		}

		// Token: 0x06009B73 RID: 39795
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointWidget_IsA_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate this widget
		/// </summary>
		// Token: 0x06009B74 RID: 39796 RVA: 0x000DC2D8 File Offset: 0x000DA4D8
		public override int IsA(string type)
		{
			return vtkPointWidget.vtkPointWidget_IsA_18(base.GetCppThis(), type);
		}

		// Token: 0x06009B75 RID: 39797
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointWidget_IsTypeOf_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate this widget
		/// </summary>
		// Token: 0x06009B76 RID: 39798 RVA: 0x000DC2F8 File Offset: 0x000DA4F8
		public new static int IsTypeOf(string type)
		{
			return vtkPointWidget.vtkPointWidget_IsTypeOf_19(type);
		}

		// Token: 0x06009B77 RID: 39799
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointWidget_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this widget
		/// </summary>
		// Token: 0x06009B78 RID: 39800 RVA: 0x000DC314 File Offset: 0x000DA514
		public new vtkPointWidget NewInstance()
		{
			vtkPointWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointWidget.vtkPointWidget_NewInstance_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06009B79 RID: 39801
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointWidget_OutlineOff_22(HandleRef pThis);

		/// <summary>
		/// Turn on/off the wireframe bounding box.
		/// </summary>
		// Token: 0x06009B7A RID: 39802 RVA: 0x000DC36E File Offset: 0x000DA56E
		public void OutlineOff()
		{
			vtkPointWidget.vtkPointWidget_OutlineOff_22(base.GetCppThis());
		}

		// Token: 0x06009B7B RID: 39803
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointWidget_OutlineOn_23(HandleRef pThis);

		/// <summary>
		/// Turn on/off the wireframe bounding box.
		/// </summary>
		// Token: 0x06009B7C RID: 39804 RVA: 0x000DC37D File Offset: 0x000DA57D
		public void OutlineOn()
		{
			vtkPointWidget.vtkPointWidget_OutlineOn_23(base.GetCppThis());
		}

		// Token: 0x06009B7D RID: 39805
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointWidget_PlaceWidget_24(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Methods that satisfy the superclass' API.
		/// </summary>
		// Token: 0x06009B7E RID: 39806 RVA: 0x000DC38C File Offset: 0x000DA58C
		public override void PlaceWidget(IntPtr bounds)
		{
			vtkPointWidget.vtkPointWidget_PlaceWidget_24(base.GetCppThis(), bounds);
		}

		// Token: 0x06009B7F RID: 39807
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointWidget_PlaceWidget_25(HandleRef pThis);

		/// <summary>
		/// Methods that satisfy the superclass' API.
		/// </summary>
		// Token: 0x06009B80 RID: 39808 RVA: 0x000DC39C File Offset: 0x000DA59C
		public override void PlaceWidget()
		{
			vtkPointWidget.vtkPointWidget_PlaceWidget_25(base.GetCppThis());
		}

		// Token: 0x06009B81 RID: 39809
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointWidget_PlaceWidget_26(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

		/// <summary>
		/// Methods that satisfy the superclass' API.
		/// </summary>
		// Token: 0x06009B82 RID: 39810 RVA: 0x000DC3AB File Offset: 0x000DA5AB
		public override void PlaceWidget(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
		{
			vtkPointWidget.vtkPointWidget_PlaceWidget_26(base.GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
		}

		// Token: 0x06009B83 RID: 39811
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointWidget_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this widget
		/// </summary>
		// Token: 0x06009B84 RID: 39812 RVA: 0x000DC3C4 File Offset: 0x000DA5C4
		public new static vtkPointWidget SafeDownCast(vtkObjectBase o)
		{
			vtkPointWidget vtkPointWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointWidget.vtkPointWidget_SafeDownCast_27((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointWidget = (vtkPointWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointWidget.Register(null);
				}
			}
			return vtkPointWidget;
		}

		// Token: 0x06009B85 RID: 39813
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointWidget_SetEnabled_28(HandleRef pThis, int arg0);

		/// <summary>
		/// Methods that satisfy the superclass' API.
		/// </summary>
		// Token: 0x06009B86 RID: 39814 RVA: 0x000DC443 File Offset: 0x000DA643
		public override void SetEnabled(int arg0)
		{
			vtkPointWidget.vtkPointWidget_SetEnabled_28(base.GetCppThis(), arg0);
		}

		// Token: 0x06009B87 RID: 39815
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointWidget_SetHotSpotSize_29(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the "hot spot" size; i.e., the region around the focus, in which the
		/// motion vector is used to control the constrained sliding action. Note the
		/// size is specified as a fraction of the length of the diagonal of the
		/// point widget's bounding box.
		/// </summary>
		// Token: 0x06009B88 RID: 39816 RVA: 0x000DC453 File Offset: 0x000DA653
		public virtual void SetHotSpotSize(double _arg)
		{
			vtkPointWidget.vtkPointWidget_SetHotSpotSize_29(base.GetCppThis(), _arg);
		}

		// Token: 0x06009B89 RID: 39817
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointWidget_SetOutline_30(HandleRef pThis, int o);

		/// <summary>
		/// Turn on/off the wireframe bounding box.
		/// </summary>
		// Token: 0x06009B8A RID: 39818 RVA: 0x000DC463 File Offset: 0x000DA663
		public void SetOutline(int o)
		{
			vtkPointWidget.vtkPointWidget_SetOutline_30(base.GetCppThis(), o);
		}

		// Token: 0x06009B8B RID: 39819
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointWidget_SetPosition_31(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Set/Get the position of the point. Note that if the position is set
		/// outside of the bounding box, it will be clamped to the boundary of
		/// the bounding box.
		/// </summary>
		// Token: 0x06009B8C RID: 39820 RVA: 0x000DC473 File Offset: 0x000DA673
		public void SetPosition(double x, double y, double z)
		{
			vtkPointWidget.vtkPointWidget_SetPosition_31(base.GetCppThis(), x, y, z);
		}

		// Token: 0x06009B8D RID: 39821
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointWidget_SetPosition_32(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Set/Get the position of the point. Note that if the position is set
		/// outside of the bounding box, it will be clamped to the boundary of
		/// the bounding box.
		/// </summary>
		// Token: 0x06009B8E RID: 39822 RVA: 0x000DC485 File Offset: 0x000DA685
		public void SetPosition(IntPtr x)
		{
			vtkPointWidget.vtkPointWidget_SetPosition_32(base.GetCppThis(), x);
		}

		// Token: 0x06009B8F RID: 39823
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointWidget_SetTranslationMode_33(HandleRef pThis, int mode);

		/// <summary>
		/// If translation mode is on, as the widget is moved the bounding box,
		/// shadows, and cursor are all translated simultaneously as the point
		/// moves.
		/// </summary>
		// Token: 0x06009B90 RID: 39824 RVA: 0x000DC495 File Offset: 0x000DA695
		public void SetTranslationMode(int mode)
		{
			vtkPointWidget.vtkPointWidget_SetTranslationMode_33(base.GetCppThis(), mode);
		}

		// Token: 0x06009B91 RID: 39825
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointWidget_SetXShadows_34(HandleRef pThis, int o);

		/// <summary>
		/// Turn on/off the wireframe x-shadows.
		/// </summary>
		// Token: 0x06009B92 RID: 39826 RVA: 0x000DC4A5 File Offset: 0x000DA6A5
		public void SetXShadows(int o)
		{
			vtkPointWidget.vtkPointWidget_SetXShadows_34(base.GetCppThis(), o);
		}

		// Token: 0x06009B93 RID: 39827
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointWidget_SetYShadows_35(HandleRef pThis, int o);

		/// <summary>
		/// Turn on/off the wireframe y-shadows.
		/// </summary>
		// Token: 0x06009B94 RID: 39828 RVA: 0x000DC4B5 File Offset: 0x000DA6B5
		public void SetYShadows(int o)
		{
			vtkPointWidget.vtkPointWidget_SetYShadows_35(base.GetCppThis(), o);
		}

		// Token: 0x06009B95 RID: 39829
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointWidget_SetZShadows_36(HandleRef pThis, int o);

		/// <summary>
		/// Turn on/off the wireframe z-shadows.
		/// </summary>
		// Token: 0x06009B96 RID: 39830 RVA: 0x000DC4C5 File Offset: 0x000DA6C5
		public void SetZShadows(int o)
		{
			vtkPointWidget.vtkPointWidget_SetZShadows_36(base.GetCppThis(), o);
		}

		// Token: 0x06009B97 RID: 39831
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointWidget_TranslationModeOff_37(HandleRef pThis);

		/// <summary>
		/// If translation mode is on, as the widget is moved the bounding box,
		/// shadows, and cursor are all translated simultaneously as the point
		/// moves.
		/// </summary>
		// Token: 0x06009B98 RID: 39832 RVA: 0x000DC4D5 File Offset: 0x000DA6D5
		public void TranslationModeOff()
		{
			vtkPointWidget.vtkPointWidget_TranslationModeOff_37(base.GetCppThis());
		}

		// Token: 0x06009B99 RID: 39833
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointWidget_TranslationModeOn_38(HandleRef pThis);

		/// <summary>
		/// If translation mode is on, as the widget is moved the bounding box,
		/// shadows, and cursor are all translated simultaneously as the point
		/// moves.
		/// </summary>
		// Token: 0x06009B9A RID: 39834 RVA: 0x000DC4E4 File Offset: 0x000DA6E4
		public void TranslationModeOn()
		{
			vtkPointWidget.vtkPointWidget_TranslationModeOn_38(base.GetCppThis());
		}

		// Token: 0x06009B9B RID: 39835
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointWidget_XShadowsOff_39(HandleRef pThis);

		/// <summary>
		/// Turn on/off the wireframe x-shadows.
		/// </summary>
		// Token: 0x06009B9C RID: 39836 RVA: 0x000DC4F3 File Offset: 0x000DA6F3
		public void XShadowsOff()
		{
			vtkPointWidget.vtkPointWidget_XShadowsOff_39(base.GetCppThis());
		}

		// Token: 0x06009B9D RID: 39837
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointWidget_XShadowsOn_40(HandleRef pThis);

		/// <summary>
		/// Turn on/off the wireframe x-shadows.
		/// </summary>
		// Token: 0x06009B9E RID: 39838 RVA: 0x000DC502 File Offset: 0x000DA702
		public void XShadowsOn()
		{
			vtkPointWidget.vtkPointWidget_XShadowsOn_40(base.GetCppThis());
		}

		// Token: 0x06009B9F RID: 39839
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointWidget_YShadowsOff_41(HandleRef pThis);

		/// <summary>
		/// Turn on/off the wireframe y-shadows.
		/// </summary>
		// Token: 0x06009BA0 RID: 39840 RVA: 0x000DC511 File Offset: 0x000DA711
		public void YShadowsOff()
		{
			vtkPointWidget.vtkPointWidget_YShadowsOff_41(base.GetCppThis());
		}

		// Token: 0x06009BA1 RID: 39841
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointWidget_YShadowsOn_42(HandleRef pThis);

		/// <summary>
		/// Turn on/off the wireframe y-shadows.
		/// </summary>
		// Token: 0x06009BA2 RID: 39842 RVA: 0x000DC520 File Offset: 0x000DA720
		public void YShadowsOn()
		{
			vtkPointWidget.vtkPointWidget_YShadowsOn_42(base.GetCppThis());
		}

		// Token: 0x06009BA3 RID: 39843
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointWidget_ZShadowsOff_43(HandleRef pThis);

		/// <summary>
		/// Turn on/off the wireframe z-shadows.
		/// </summary>
		// Token: 0x06009BA4 RID: 39844 RVA: 0x000DC52F File Offset: 0x000DA72F
		public void ZShadowsOff()
		{
			vtkPointWidget.vtkPointWidget_ZShadowsOff_43(base.GetCppThis());
		}

		// Token: 0x06009BA5 RID: 39845
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointWidget_ZShadowsOn_44(HandleRef pThis);

		/// <summary>
		/// Turn on/off the wireframe z-shadows.
		/// </summary>
		// Token: 0x06009BA6 RID: 39846 RVA: 0x000DC53E File Offset: 0x000DA73E
		public void ZShadowsOn()
		{
			vtkPointWidget.vtkPointWidget_ZShadowsOn_44(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C9D RID: 3229
		public new const string MRFullTypeName = "Kitware.VTK.vtkPointWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C9E RID: 3230
		public new static readonly string MRClassNameKey = "class vtkPointWidget";
	}
}
