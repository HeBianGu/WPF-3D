using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSplineWidget
	/// </summary>
	/// <remarks>
	///    3D widget for manipulating a spline
	///
	/// This 3D widget defines a spline that can be interactively placed in a
	/// scene. The spline has handles, the number of which can be changed, plus it
	/// can be picked on the spline itself to translate or rotate it in the scene.
	/// A nice feature of the object is that the vtkSplineWidget, like any 3D
	/// widget, will work with the current interactor style. That is, if
	/// vtkSplineWidget does not handle an event, then all other registered
	/// observers (including the interactor style) have an opportunity to process
	/// the event. Otherwise, the vtkSplineWidget will terminate the processing of
	/// the event that it handles.
	///
	/// To use this object, just invoke SetInteractor() with the argument of the
	/// method a vtkRenderWindowInteractor.  You may also wish to invoke
	/// "PlaceWidget()" to initially position the widget. The interactor will act
	/// normally until the "i" key (for "interactor") is pressed, at which point the
	/// vtkSplineWidget will appear. (See superclass documentation for information
	/// about changing this behavior.) Events that occur outside of the widget
	/// (i.e., no part of the widget is picked) are propagated to any other
	/// registered obsevers (such as the interaction style).  Turn off the widget
	/// by pressing the "i" key again (or invoke the Off() method).
	///
	/// The button actions and key modifiers are as follows for controlling the
	/// widget:
	/// 1) left button down on and drag one of the spherical handles to change the
	/// shape of the spline: the handles act as "control points".
	/// 2) left button or middle button down on a line segment forming the spline
	/// allows uniform translation of the widget.
	/// 3) ctrl + middle button down on the widget enables spinning of the widget
	/// about its center.
	/// 4) right button down on the widget enables scaling of the widget. By moving
	/// the mouse "up" the render window the spline will be made bigger; by moving
	/// "down" the render window the widget will be made smaller.
	/// 5) ctrl key + right button down on any handle will erase it providing there
	/// will be two or more points remaining to form a spline.
	/// 6) shift key + right button down on any line segment will insert a handle
	/// onto the spline at the cursor position.
	///
	/// The vtkSplineWidget has several methods that can be used in conjunction with
	/// other VTK objects. The Set/GetResolution() methods control the number of
	/// subdivisions of the spline; the GetPolyData() method can be used to get the
	/// polygonal representation and can be used for things like seeding
	/// streamlines or probing other data sets. Typical usage of the widget is to
	/// make use of the StartInteractionEvent, InteractionEvent, and
	/// EndInteractionEvent events. The InteractionEvent is called on mouse motion;
	/// the other two events are called on button down and button up (either left or
	/// right button).
	///
	/// Some additional features of this class include the ability to control the
	/// properties of the widget. You can set the properties of the selected and
	/// unselected representations of the spline. For example, you can set the
	/// property for the handles and spline. In addition there are methods to
	/// constrain the spline so that it is aligned with a plane.  Note that a simple
	/// ruler widget can be derived by setting the resolution to 1, the number of
	/// handles to 2, and calling the GetSummedLength method!
	///
	/// @par Thanks:
	/// Thanks to Dean Inglis for developing and contributing this class.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtk3DWidget vtkBoxWidget vtkLineWidget vtkPointWidget vtkSphereWidget
	/// vtkImagePlaneWidget vtkImplicitPlaneWidget vtkPlaneWidget
	/// </seealso>
	// Token: 0x0200037E RID: 894
	public class vtkSplineWidget : vtk3DWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600A2B1 RID: 41649 RVA: 0x000E6A8F File Offset: 0x000E4C8F
		static vtkSplineWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSplineWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSplineWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600A2B2 RID: 41650 RVA: 0x000E6AB7 File Offset: 0x000E4CB7
		public vtkSplineWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600A2B3 RID: 41651
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSplineWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x0600A2B4 RID: 41652 RVA: 0x000E6AC8 File Offset: 0x000E4CC8
		public new static vtkSplineWidget New()
		{
			vtkSplineWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSplineWidget.vtkSplineWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSplineWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x0600A2B5 RID: 41653 RVA: 0x000E6B1C File Offset: 0x000E4D1C
		public vtkSplineWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSplineWidget.vtkSplineWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600A2B6 RID: 41654 RVA: 0x000E6B60 File Offset: 0x000E4D60
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600A2B7 RID: 41655
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineWidget_ClosedOff_01(HandleRef pThis);

		/// <summary>
		/// Control whether the spline is open or closed. A closed spline forms
		/// a continuous loop: the first and last points are the same, and
		/// derivatives are continuous.  A minimum of 3 handles are required to
		/// form a closed loop.  This method enforces consistency with
		/// user supplied subclasses of vtkSpline.
		/// </summary>
		// Token: 0x0600A2B8 RID: 41656 RVA: 0x000E6B6B File Offset: 0x000E4D6B
		public virtual void ClosedOff()
		{
			vtkSplineWidget.vtkSplineWidget_ClosedOff_01(base.GetCppThis());
		}

		// Token: 0x0600A2B9 RID: 41657
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineWidget_ClosedOn_02(HandleRef pThis);

		/// <summary>
		/// Control whether the spline is open or closed. A closed spline forms
		/// a continuous loop: the first and last points are the same, and
		/// derivatives are continuous.  A minimum of 3 handles are required to
		/// form a closed loop.  This method enforces consistency with
		/// user supplied subclasses of vtkSpline.
		/// </summary>
		// Token: 0x0600A2BA RID: 41658 RVA: 0x000E6B7A File Offset: 0x000E4D7A
		public virtual void ClosedOn()
		{
			vtkSplineWidget.vtkSplineWidget_ClosedOn_02(base.GetCppThis());
		}

		// Token: 0x0600A2BB RID: 41659
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSplineWidget_GetClosed_03(HandleRef pThis);

		/// <summary>
		/// Control whether the spline is open or closed. A closed spline forms
		/// a continuous loop: the first and last points are the same, and
		/// derivatives are continuous.  A minimum of 3 handles are required to
		/// form a closed loop.  This method enforces consistency with
		/// user supplied subclasses of vtkSpline.
		/// </summary>
		// Token: 0x0600A2BC RID: 41660 RVA: 0x000E6B8C File Offset: 0x000E4D8C
		public virtual int GetClosed()
		{
			return vtkSplineWidget.vtkSplineWidget_GetClosed_03(base.GetCppThis());
		}

		// Token: 0x0600A2BD RID: 41661
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineWidget_GetHandlePosition_04(HandleRef pThis, int handle, IntPtr xyz);

		/// <summary>
		/// Set/Get the position of the spline handles. Call GetNumberOfHandles
		/// to determine the valid range of handle indices.
		/// </summary>
		// Token: 0x0600A2BE RID: 41662 RVA: 0x000E6BAB File Offset: 0x000E4DAB
		public void GetHandlePosition(int handle, IntPtr xyz)
		{
			vtkSplineWidget.vtkSplineWidget_GetHandlePosition_04(base.GetCppThis(), handle, xyz);
		}

		// Token: 0x0600A2BF RID: 41663
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSplineWidget_GetHandlePosition_05(HandleRef pThis, int handle);

		/// <summary>
		/// Set/Get the position of the spline handles. Call GetNumberOfHandles
		/// to determine the valid range of handle indices.
		/// </summary>
		// Token: 0x0600A2C0 RID: 41664 RVA: 0x000E6BBC File Offset: 0x000E4DBC
		public double[] GetHandlePosition(int handle)
		{
			IntPtr intPtr = vtkSplineWidget.vtkSplineWidget_GetHandlePosition_05(base.GetCppThis(), handle);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600A2C1 RID: 41665
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSplineWidget_GetHandleProperty_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the handle properties (the spheres are the handles). The
		/// properties of the handles when selected and unselected can be manipulated.
		/// </summary>
		// Token: 0x0600A2C2 RID: 41666 RVA: 0x000E6C08 File Offset: 0x000E4E08
		public virtual vtkProperty GetHandleProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSplineWidget.vtkSplineWidget_GetHandleProperty_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600A2C3 RID: 41667
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSplineWidget_GetLineProperty_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the line properties. The properties of the line when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x0600A2C4 RID: 41668 RVA: 0x000E6C78 File Offset: 0x000E4E78
		public virtual vtkProperty GetLineProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSplineWidget.vtkSplineWidget_GetLineProperty_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600A2C5 RID: 41669
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSplineWidget_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x0600A2C6 RID: 41670 RVA: 0x000E6CE8 File Offset: 0x000E4EE8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSplineWidget.vtkSplineWidget_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x0600A2C7 RID: 41671
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSplineWidget_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x0600A2C8 RID: 41672 RVA: 0x000E6D08 File Offset: 0x000E4F08
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSplineWidget.vtkSplineWidget_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x0600A2C9 RID: 41673
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSplineWidget_GetNumberOfHandles_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of handles for this widget.
		/// </summary>
		// Token: 0x0600A2CA RID: 41674 RVA: 0x000E6D24 File Offset: 0x000E4F24
		public virtual int GetNumberOfHandles()
		{
			return vtkSplineWidget.vtkSplineWidget_GetNumberOfHandles_10(base.GetCppThis());
		}

		// Token: 0x0600A2CB RID: 41675
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSplineWidget_GetParametricSpline_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the parametric spline object. Through vtkParametricSpline's API, the
		/// user can supply and configure one of currently two types of spline:
		/// vtkCardinalSpline, vtkKochanekSpline. The widget controls the open
		/// or closed configuration of the spline.
		/// WARNING: The widget does not enforce internal consistency so that all
		/// three are of the same type.
		/// </summary>
		// Token: 0x0600A2CC RID: 41676 RVA: 0x000E6D44 File Offset: 0x000E4F44
		public virtual vtkParametricSpline GetParametricSpline()
		{
			vtkParametricSpline vtkParametricSpline = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSplineWidget.vtkSplineWidget_GetParametricSpline_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParametricSpline = (vtkParametricSpline)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParametricSpline.Register(null);
				}
			}
			return vtkParametricSpline;
		}

		// Token: 0x0600A2CD RID: 41677
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineWidget_GetPolyData_12(HandleRef pThis, HandleRef pd);

		/// <summary>
		/// Grab the polydata (including points) that defines the spline.  The
		/// polydata consists of points and line segments numbering Resolution + 1
		/// and Resolution, respectively. Points are guaranteed to be up-to-date when
		/// either the InteractionEvent or EndInteraction events are invoked. The
		/// user provides the vtkPolyData and the points and polyline are added to it.
		/// </summary>
		// Token: 0x0600A2CE RID: 41678 RVA: 0x000E6DB4 File Offset: 0x000E4FB4
		public void GetPolyData(vtkPolyData pd)
		{
			vtkSplineWidget.vtkSplineWidget_GetPolyData_12(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x0600A2CF RID: 41679
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSplineWidget_GetProcessEvents_13(HandleRef pThis);

		/// <summary>
		/// Turn on / off event processing for this widget. If off, the widget will
		/// not respond to user interaction
		/// </summary>
		// Token: 0x0600A2D0 RID: 41680 RVA: 0x000E6DE4 File Offset: 0x000E4FE4
		public virtual int GetProcessEvents()
		{
			return vtkSplineWidget.vtkSplineWidget_GetProcessEvents_13(base.GetCppThis());
		}

		// Token: 0x0600A2D1 RID: 41681
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSplineWidget_GetProcessEventsMaxValue_14(HandleRef pThis);

		/// <summary>
		/// Turn on / off event processing for this widget. If off, the widget will
		/// not respond to user interaction
		/// </summary>
		// Token: 0x0600A2D2 RID: 41682 RVA: 0x000E6E04 File Offset: 0x000E5004
		public virtual int GetProcessEventsMaxValue()
		{
			return vtkSplineWidget.vtkSplineWidget_GetProcessEventsMaxValue_14(base.GetCppThis());
		}

		// Token: 0x0600A2D3 RID: 41683
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSplineWidget_GetProcessEventsMinValue_15(HandleRef pThis);

		/// <summary>
		/// Turn on / off event processing for this widget. If off, the widget will
		/// not respond to user interaction
		/// </summary>
		// Token: 0x0600A2D4 RID: 41684 RVA: 0x000E6E24 File Offset: 0x000E5024
		public virtual int GetProcessEventsMinValue()
		{
			return vtkSplineWidget.vtkSplineWidget_GetProcessEventsMinValue_15(base.GetCppThis());
		}

		// Token: 0x0600A2D5 RID: 41685
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSplineWidget_GetProjectToPlane_16(HandleRef pThis);

		/// <summary>
		/// Force the spline widget to be projected onto one of the orthogonal planes.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the spline to the plane if it is originally
		/// not aligned.  The normal in SetProjectionNormal is 0,1,2 for YZ,XZ,XY
		/// planes respectively and 3 for arbitrary oblique planes when the widget
		/// is tied to a vtkPlaneSource.
		/// </summary>
		// Token: 0x0600A2D6 RID: 41686 RVA: 0x000E6E44 File Offset: 0x000E5044
		public virtual int GetProjectToPlane()
		{
			return vtkSplineWidget.vtkSplineWidget_GetProjectToPlane_16(base.GetCppThis());
		}

		// Token: 0x0600A2D7 RID: 41687
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSplineWidget_GetProjectionNormal_17(HandleRef pThis);

		/// <summary>
		/// Set up a reference to a vtkPlaneSource that could be from another widget
		/// object, e.g. a vtkPolyDataSourceWidget.
		/// </summary>
		// Token: 0x0600A2D8 RID: 41688 RVA: 0x000E6E64 File Offset: 0x000E5064
		public virtual int GetProjectionNormal()
		{
			return vtkSplineWidget.vtkSplineWidget_GetProjectionNormal_17(base.GetCppThis());
		}

		// Token: 0x0600A2D9 RID: 41689
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSplineWidget_GetProjectionNormalMaxValue_18(HandleRef pThis);

		/// <summary>
		/// Set up a reference to a vtkPlaneSource that could be from another widget
		/// object, e.g. a vtkPolyDataSourceWidget.
		/// </summary>
		// Token: 0x0600A2DA RID: 41690 RVA: 0x000E6E84 File Offset: 0x000E5084
		public virtual int GetProjectionNormalMaxValue()
		{
			return vtkSplineWidget.vtkSplineWidget_GetProjectionNormalMaxValue_18(base.GetCppThis());
		}

		// Token: 0x0600A2DB RID: 41691
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSplineWidget_GetProjectionNormalMinValue_19(HandleRef pThis);

		/// <summary>
		/// Set up a reference to a vtkPlaneSource that could be from another widget
		/// object, e.g. a vtkPolyDataSourceWidget.
		/// </summary>
		// Token: 0x0600A2DC RID: 41692 RVA: 0x000E6EA4 File Offset: 0x000E50A4
		public virtual int GetProjectionNormalMinValue()
		{
			return vtkSplineWidget.vtkSplineWidget_GetProjectionNormalMinValue_19(base.GetCppThis());
		}

		// Token: 0x0600A2DD RID: 41693
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSplineWidget_GetProjectionPosition_20(HandleRef pThis);

		/// <summary>
		/// Set the position of spline handles and points in terms of a plane's
		/// position. i.e., if ProjectionNormal is 0, all of the x-coordinate
		/// values of the points are set to position. Any value can be passed (and is
		/// ignored) to update the spline points when Projection normal is set to 3
		/// for arbitrary plane orientations.
		/// </summary>
		// Token: 0x0600A2DE RID: 41694 RVA: 0x000E6EC4 File Offset: 0x000E50C4
		public virtual double GetProjectionPosition()
		{
			return vtkSplineWidget.vtkSplineWidget_GetProjectionPosition_20(base.GetCppThis());
		}

		// Token: 0x0600A2DF RID: 41695
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSplineWidget_GetResolution_21(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of line segments representing the spline for
		/// this widget.
		/// </summary>
		// Token: 0x0600A2E0 RID: 41696 RVA: 0x000E6EE4 File Offset: 0x000E50E4
		public virtual int GetResolution()
		{
			return vtkSplineWidget.vtkSplineWidget_GetResolution_21(base.GetCppThis());
		}

		// Token: 0x0600A2E1 RID: 41697
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSplineWidget_GetSelectedHandleProperty_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the handle properties (the spheres are the handles). The
		/// properties of the handles when selected and unselected can be manipulated.
		/// </summary>
		// Token: 0x0600A2E2 RID: 41698 RVA: 0x000E6F04 File Offset: 0x000E5104
		public virtual vtkProperty GetSelectedHandleProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSplineWidget.vtkSplineWidget_GetSelectedHandleProperty_22(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600A2E3 RID: 41699
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSplineWidget_GetSelectedLineProperty_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the line properties. The properties of the line when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x0600A2E4 RID: 41700 RVA: 0x000E6F74 File Offset: 0x000E5174
		public virtual vtkProperty GetSelectedLineProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSplineWidget.vtkSplineWidget_GetSelectedLineProperty_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600A2E5 RID: 41701
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSplineWidget_GetSummedLength_24(HandleRef pThis);

		/// <summary>
		/// Get the approximate vs. the true arc length of the spline. Calculated as
		/// the summed lengths of the individual straight line segments. Use
		/// SetResolution to control the accuracy.
		/// </summary>
		// Token: 0x0600A2E6 RID: 41702 RVA: 0x000E6FE4 File Offset: 0x000E51E4
		public double GetSummedLength()
		{
			return vtkSplineWidget.vtkSplineWidget_GetSummedLength_24(base.GetCppThis());
		}

		// Token: 0x0600A2E7 RID: 41703
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineWidget_InitializeHandles_25(HandleRef pThis, HandleRef points);

		/// <summary>
		/// Convenience method to allocate and set the handles from a vtkPoints
		/// instance.  If the first and last points are the same, the spline sets
		/// Closed to the on state and disregards the last point, otherwise Closed
		/// remains unchanged.
		/// </summary>
		// Token: 0x0600A2E8 RID: 41704 RVA: 0x000E7004 File Offset: 0x000E5204
		public void InitializeHandles(vtkPoints points)
		{
			vtkSplineWidget.vtkSplineWidget_InitializeHandles_25(base.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis());
		}

		// Token: 0x0600A2E9 RID: 41705
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSplineWidget_IsA_26(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x0600A2EA RID: 41706 RVA: 0x000E7034 File Offset: 0x000E5234
		public override int IsA(string type)
		{
			return vtkSplineWidget.vtkSplineWidget_IsA_26(base.GetCppThis(), type);
		}

		// Token: 0x0600A2EB RID: 41707
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSplineWidget_IsClosed_27(HandleRef pThis);

		/// <summary>
		/// Convenience method to determine whether the spline is
		/// closed in a geometric sense.  The widget may be set "closed" but still
		/// be geometrically open (e.g., a straight line).
		/// </summary>
		// Token: 0x0600A2EC RID: 41708 RVA: 0x000E7054 File Offset: 0x000E5254
		public int IsClosed()
		{
			return vtkSplineWidget.vtkSplineWidget_IsClosed_27(base.GetCppThis());
		}

		// Token: 0x0600A2ED RID: 41709
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSplineWidget_IsTypeOf_28([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x0600A2EE RID: 41710 RVA: 0x000E7074 File Offset: 0x000E5274
		public new static int IsTypeOf(string type)
		{
			return vtkSplineWidget.vtkSplineWidget_IsTypeOf_28(type);
		}

		// Token: 0x0600A2EF RID: 41711
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSplineWidget_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x0600A2F0 RID: 41712 RVA: 0x000E7090 File Offset: 0x000E5290
		public new vtkSplineWidget NewInstance()
		{
			vtkSplineWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSplineWidget.vtkSplineWidget_NewInstance_30(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSplineWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600A2F1 RID: 41713
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineWidget_PlaceWidget_31(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Methods that satisfy the superclass' API.
		/// </summary>
		// Token: 0x0600A2F2 RID: 41714 RVA: 0x000E70EA File Offset: 0x000E52EA
		public override void PlaceWidget(IntPtr bounds)
		{
			vtkSplineWidget.vtkSplineWidget_PlaceWidget_31(base.GetCppThis(), bounds);
		}

		// Token: 0x0600A2F3 RID: 41715
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineWidget_PlaceWidget_32(HandleRef pThis);

		/// <summary>
		/// Methods that satisfy the superclass' API.
		/// </summary>
		// Token: 0x0600A2F4 RID: 41716 RVA: 0x000E70FA File Offset: 0x000E52FA
		public override void PlaceWidget()
		{
			vtkSplineWidget.vtkSplineWidget_PlaceWidget_32(base.GetCppThis());
		}

		// Token: 0x0600A2F5 RID: 41717
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineWidget_PlaceWidget_33(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

		/// <summary>
		/// Methods that satisfy the superclass' API.
		/// </summary>
		// Token: 0x0600A2F6 RID: 41718 RVA: 0x000E7109 File Offset: 0x000E5309
		public override void PlaceWidget(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
		{
			vtkSplineWidget.vtkSplineWidget_PlaceWidget_33(base.GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
		}

		// Token: 0x0600A2F7 RID: 41719
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineWidget_ProcessEventsOff_34(HandleRef pThis);

		/// <summary>
		/// Turn on / off event processing for this widget. If off, the widget will
		/// not respond to user interaction
		/// </summary>
		// Token: 0x0600A2F8 RID: 41720 RVA: 0x000E7121 File Offset: 0x000E5321
		public virtual void ProcessEventsOff()
		{
			vtkSplineWidget.vtkSplineWidget_ProcessEventsOff_34(base.GetCppThis());
		}

		// Token: 0x0600A2F9 RID: 41721
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineWidget_ProcessEventsOn_35(HandleRef pThis);

		/// <summary>
		/// Turn on / off event processing for this widget. If off, the widget will
		/// not respond to user interaction
		/// </summary>
		// Token: 0x0600A2FA RID: 41722 RVA: 0x000E7130 File Offset: 0x000E5330
		public virtual void ProcessEventsOn()
		{
			vtkSplineWidget.vtkSplineWidget_ProcessEventsOn_35(base.GetCppThis());
		}

		// Token: 0x0600A2FB RID: 41723
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineWidget_ProjectToPlaneOff_36(HandleRef pThis);

		/// <summary>
		/// Force the spline widget to be projected onto one of the orthogonal planes.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the spline to the plane if it is originally
		/// not aligned.  The normal in SetProjectionNormal is 0,1,2 for YZ,XZ,XY
		/// planes respectively and 3 for arbitrary oblique planes when the widget
		/// is tied to a vtkPlaneSource.
		/// </summary>
		// Token: 0x0600A2FC RID: 41724 RVA: 0x000E713F File Offset: 0x000E533F
		public virtual void ProjectToPlaneOff()
		{
			vtkSplineWidget.vtkSplineWidget_ProjectToPlaneOff_36(base.GetCppThis());
		}

		// Token: 0x0600A2FD RID: 41725
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineWidget_ProjectToPlaneOn_37(HandleRef pThis);

		/// <summary>
		/// Force the spline widget to be projected onto one of the orthogonal planes.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the spline to the plane if it is originally
		/// not aligned.  The normal in SetProjectionNormal is 0,1,2 for YZ,XZ,XY
		/// planes respectively and 3 for arbitrary oblique planes when the widget
		/// is tied to a vtkPlaneSource.
		/// </summary>
		// Token: 0x0600A2FE RID: 41726 RVA: 0x000E714E File Offset: 0x000E534E
		public virtual void ProjectToPlaneOn()
		{
			vtkSplineWidget.vtkSplineWidget_ProjectToPlaneOn_37(base.GetCppThis());
		}

		// Token: 0x0600A2FF RID: 41727
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSplineWidget_SafeDownCast_38(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x0600A300 RID: 41728 RVA: 0x000E7160 File Offset: 0x000E5360
		public new static vtkSplineWidget SafeDownCast(vtkObjectBase o)
		{
			vtkSplineWidget vtkSplineWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSplineWidget.vtkSplineWidget_SafeDownCast_38((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSplineWidget = (vtkSplineWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSplineWidget.Register(null);
				}
			}
			return vtkSplineWidget;
		}

		// Token: 0x0600A301 RID: 41729
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineWidget_SetClosed_39(HandleRef pThis, int closed);

		/// <summary>
		/// Control whether the spline is open or closed. A closed spline forms
		/// a continuous loop: the first and last points are the same, and
		/// derivatives are continuous.  A minimum of 3 handles are required to
		/// form a closed loop.  This method enforces consistency with
		/// user supplied subclasses of vtkSpline.
		/// </summary>
		// Token: 0x0600A302 RID: 41730 RVA: 0x000E71DF File Offset: 0x000E53DF
		public void SetClosed(int closed)
		{
			vtkSplineWidget.vtkSplineWidget_SetClosed_39(base.GetCppThis(), closed);
		}

		// Token: 0x0600A303 RID: 41731
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineWidget_SetEnabled_40(HandleRef pThis, int arg0);

		/// <summary>
		/// Methods that satisfy the superclass' API.
		/// </summary>
		// Token: 0x0600A304 RID: 41732 RVA: 0x000E71EF File Offset: 0x000E53EF
		public override void SetEnabled(int arg0)
		{
			vtkSplineWidget.vtkSplineWidget_SetEnabled_40(base.GetCppThis(), arg0);
		}

		// Token: 0x0600A305 RID: 41733
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineWidget_SetHandlePosition_41(HandleRef pThis, int handle, double x, double y, double z);

		/// <summary>
		/// Set/Get the position of the spline handles. Call GetNumberOfHandles
		/// to determine the valid range of handle indices.
		/// </summary>
		// Token: 0x0600A306 RID: 41734 RVA: 0x000E71FF File Offset: 0x000E53FF
		public void SetHandlePosition(int handle, double x, double y, double z)
		{
			vtkSplineWidget.vtkSplineWidget_SetHandlePosition_41(base.GetCppThis(), handle, x, y, z);
		}

		// Token: 0x0600A307 RID: 41735
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineWidget_SetHandlePosition_42(HandleRef pThis, int handle, IntPtr xyz);

		/// <summary>
		/// Set/Get the position of the spline handles. Call GetNumberOfHandles
		/// to determine the valid range of handle indices.
		/// </summary>
		// Token: 0x0600A308 RID: 41736 RVA: 0x000E7213 File Offset: 0x000E5413
		public void SetHandlePosition(int handle, IntPtr xyz)
		{
			vtkSplineWidget.vtkSplineWidget_SetHandlePosition_42(base.GetCppThis(), handle, xyz);
		}

		// Token: 0x0600A309 RID: 41737
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineWidget_SetHandleProperty_43(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the handle properties (the spheres are the handles). The
		/// properties of the handles when selected and unselected can be manipulated.
		/// </summary>
		// Token: 0x0600A30A RID: 41738 RVA: 0x000E7224 File Offset: 0x000E5424
		public virtual void SetHandleProperty(vtkProperty arg0)
		{
			vtkSplineWidget.vtkSplineWidget_SetHandleProperty_43(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600A30B RID: 41739
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineWidget_SetLineProperty_44(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the line properties. The properties of the line when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x0600A30C RID: 41740 RVA: 0x000E7254 File Offset: 0x000E5454
		public virtual void SetLineProperty(vtkProperty arg0)
		{
			vtkSplineWidget.vtkSplineWidget_SetLineProperty_44(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600A30D RID: 41741
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineWidget_SetNumberOfHandles_45(HandleRef pThis, int npts);

		/// <summary>
		/// Set/Get the number of handles for this widget.
		/// </summary>
		// Token: 0x0600A30E RID: 41742 RVA: 0x000E7283 File Offset: 0x000E5483
		public virtual void SetNumberOfHandles(int npts)
		{
			vtkSplineWidget.vtkSplineWidget_SetNumberOfHandles_45(base.GetCppThis(), npts);
		}

		// Token: 0x0600A30F RID: 41743
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineWidget_SetParametricSpline_46(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the parametric spline object. Through vtkParametricSpline's API, the
		/// user can supply and configure one of currently two types of spline:
		/// vtkCardinalSpline, vtkKochanekSpline. The widget controls the open
		/// or closed configuration of the spline.
		/// WARNING: The widget does not enforce internal consistency so that all
		/// three are of the same type.
		/// </summary>
		// Token: 0x0600A310 RID: 41744 RVA: 0x000E7294 File Offset: 0x000E5494
		public virtual void SetParametricSpline(vtkParametricSpline arg0)
		{
			vtkSplineWidget.vtkSplineWidget_SetParametricSpline_46(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600A311 RID: 41745
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineWidget_SetPlaneSource_47(HandleRef pThis, HandleRef plane);

		/// <summary>
		/// Set up a reference to a vtkPlaneSource that could be from another widget
		/// object, e.g. a vtkPolyDataSourceWidget.
		/// </summary>
		// Token: 0x0600A312 RID: 41746 RVA: 0x000E72C4 File Offset: 0x000E54C4
		public void SetPlaneSource(vtkPlaneSource plane)
		{
			vtkSplineWidget.vtkSplineWidget_SetPlaneSource_47(base.GetCppThis(), (plane == null) ? default(HandleRef) : plane.GetCppThis());
		}

		// Token: 0x0600A313 RID: 41747
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineWidget_SetProcessEvents_48(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on / off event processing for this widget. If off, the widget will
		/// not respond to user interaction
		/// </summary>
		// Token: 0x0600A314 RID: 41748 RVA: 0x000E72F3 File Offset: 0x000E54F3
		public virtual void SetProcessEvents(int _arg)
		{
			vtkSplineWidget.vtkSplineWidget_SetProcessEvents_48(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A315 RID: 41749
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineWidget_SetProjectToPlane_49(HandleRef pThis, int _arg);

		/// <summary>
		/// Force the spline widget to be projected onto one of the orthogonal planes.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the spline to the plane if it is originally
		/// not aligned.  The normal in SetProjectionNormal is 0,1,2 for YZ,XZ,XY
		/// planes respectively and 3 for arbitrary oblique planes when the widget
		/// is tied to a vtkPlaneSource.
		/// </summary>
		// Token: 0x0600A316 RID: 41750 RVA: 0x000E7303 File Offset: 0x000E5503
		public virtual void SetProjectToPlane(int _arg)
		{
			vtkSplineWidget.vtkSplineWidget_SetProjectToPlane_49(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A317 RID: 41751
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineWidget_SetProjectionNormal_50(HandleRef pThis, int _arg);

		/// <summary>
		/// Set up a reference to a vtkPlaneSource that could be from another widget
		/// object, e.g. a vtkPolyDataSourceWidget.
		/// </summary>
		// Token: 0x0600A318 RID: 41752 RVA: 0x000E7313 File Offset: 0x000E5513
		public virtual void SetProjectionNormal(int _arg)
		{
			vtkSplineWidget.vtkSplineWidget_SetProjectionNormal_50(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A319 RID: 41753
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineWidget_SetProjectionNormalToOblique_51(HandleRef pThis);

		/// <summary>
		/// Set up a reference to a vtkPlaneSource that could be from another widget
		/// object, e.g. a vtkPolyDataSourceWidget.
		/// </summary>
		// Token: 0x0600A31A RID: 41754 RVA: 0x000E7323 File Offset: 0x000E5523
		public void SetProjectionNormalToOblique()
		{
			vtkSplineWidget.vtkSplineWidget_SetProjectionNormalToOblique_51(base.GetCppThis());
		}

		// Token: 0x0600A31B RID: 41755
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineWidget_SetProjectionNormalToXAxes_52(HandleRef pThis);

		/// <summary>
		/// Set up a reference to a vtkPlaneSource that could be from another widget
		/// object, e.g. a vtkPolyDataSourceWidget.
		/// </summary>
		// Token: 0x0600A31C RID: 41756 RVA: 0x000E7332 File Offset: 0x000E5532
		public void SetProjectionNormalToXAxes()
		{
			vtkSplineWidget.vtkSplineWidget_SetProjectionNormalToXAxes_52(base.GetCppThis());
		}

		// Token: 0x0600A31D RID: 41757
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineWidget_SetProjectionNormalToYAxes_53(HandleRef pThis);

		/// <summary>
		/// Set up a reference to a vtkPlaneSource that could be from another widget
		/// object, e.g. a vtkPolyDataSourceWidget.
		/// </summary>
		// Token: 0x0600A31E RID: 41758 RVA: 0x000E7341 File Offset: 0x000E5541
		public void SetProjectionNormalToYAxes()
		{
			vtkSplineWidget.vtkSplineWidget_SetProjectionNormalToYAxes_53(base.GetCppThis());
		}

		// Token: 0x0600A31F RID: 41759
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineWidget_SetProjectionNormalToZAxes_54(HandleRef pThis);

		/// <summary>
		/// Set up a reference to a vtkPlaneSource that could be from another widget
		/// object, e.g. a vtkPolyDataSourceWidget.
		/// </summary>
		// Token: 0x0600A320 RID: 41760 RVA: 0x000E7350 File Offset: 0x000E5550
		public void SetProjectionNormalToZAxes()
		{
			vtkSplineWidget.vtkSplineWidget_SetProjectionNormalToZAxes_54(base.GetCppThis());
		}

		// Token: 0x0600A321 RID: 41761
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineWidget_SetProjectionPosition_55(HandleRef pThis, double position);

		/// <summary>
		/// Set the position of spline handles and points in terms of a plane's
		/// position. i.e., if ProjectionNormal is 0, all of the x-coordinate
		/// values of the points are set to position. Any value can be passed (and is
		/// ignored) to update the spline points when Projection normal is set to 3
		/// for arbitrary plane orientations.
		/// </summary>
		// Token: 0x0600A322 RID: 41762 RVA: 0x000E735F File Offset: 0x000E555F
		public void SetProjectionPosition(double position)
		{
			vtkSplineWidget.vtkSplineWidget_SetProjectionPosition_55(base.GetCppThis(), position);
		}

		// Token: 0x0600A323 RID: 41763
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineWidget_SetResolution_56(HandleRef pThis, int resolution);

		/// <summary>
		/// Set/Get the number of line segments representing the spline for
		/// this widget.
		/// </summary>
		// Token: 0x0600A324 RID: 41764 RVA: 0x000E736F File Offset: 0x000E556F
		public void SetResolution(int resolution)
		{
			vtkSplineWidget.vtkSplineWidget_SetResolution_56(base.GetCppThis(), resolution);
		}

		// Token: 0x0600A325 RID: 41765
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineWidget_SetSelectedHandleProperty_57(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the handle properties (the spheres are the handles). The
		/// properties of the handles when selected and unselected can be manipulated.
		/// </summary>
		// Token: 0x0600A326 RID: 41766 RVA: 0x000E7380 File Offset: 0x000E5580
		public virtual void SetSelectedHandleProperty(vtkProperty arg0)
		{
			vtkSplineWidget.vtkSplineWidget_SetSelectedHandleProperty_57(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600A327 RID: 41767
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineWidget_SetSelectedLineProperty_58(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the line properties. The properties of the line when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x0600A328 RID: 41768 RVA: 0x000E73B0 File Offset: 0x000E55B0
		public virtual void SetSelectedLineProperty(vtkProperty arg0)
		{
			vtkSplineWidget.vtkSplineWidget_SetSelectedLineProperty_58(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D0A RID: 3338
		public new const string MRFullTypeName = "Kitware.VTK.vtkSplineWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D0B RID: 3339
		public new static readonly string MRClassNameKey = "class vtkSplineWidget";
	}
}
