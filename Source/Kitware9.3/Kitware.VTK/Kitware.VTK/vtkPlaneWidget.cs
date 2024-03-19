using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPlaneWidget
	/// </summary>
	/// <remarks>
	///    3D widget for manipulating a finite plane
	///
	/// This 3D widget defines a finite (bounded) plane that can be interactively
	/// placed in a scene. The plane has four handles (at its corner vertices), a
	/// normal vector, and the plane itself. The handles are used to resize the
	/// plane; the normal vector to rotate it, and the plane can be picked and
	/// translated. Selecting the plane while pressing CTRL makes it spin around
	/// the normal. A nice feature of the object is that the vtkPlaneWidget, like
	/// any 3D widget, will work with the current interactor style. That is, if
	/// vtkPlaneWidget does not handle an event, then all other registered
	/// observers (including the interactor style) have an opportunity to process
	/// the event. Otherwise, the vtkPlaneWidget will terminate the processing of
	/// the event that it handles.
	///
	/// To use this object, just invoke SetInteractor() with the argument of the
	/// method a vtkRenderWindowInteractor.  You may also wish to invoke
	/// "PlaceWidget()" to initially position the widget. If the "i" key (for
	/// "interactor") is pressed, the vtkPlaneWidget will appear. (See superclass
	/// documentation for information about changing this behavior.) By grabbing
	/// the one of the four handles (use the left mouse button), the plane can be
	/// resized.  By grabbing the plane itself, the entire plane can be
	/// arbitrarily translated. Pressing CTRL while grabbing the plane will spin
	/// the plane around the normal. If you select the normal vector, the plane can be
	/// arbitrarily rotated. Selecting any part of the widget with the middle
	/// mouse button enables translation of the plane along its normal. (Once
	/// selected using middle mouse, moving the mouse in the direction of the
	/// normal translates the plane in the direction of the normal; moving in the
	/// direction opposite the normal translates the plane in the direction
	/// opposite the normal.) Scaling (about the center of the plane) is achieved
	/// by using the right mouse button. By moving the mouse "up" the render
	/// window the plane will be made bigger; by moving "down" the render window
	/// the widget will be made smaller. Events that occur outside of the widget
	/// (i.e., no part of the widget is picked) are propagated to any other
	/// registered obsevers (such as the interaction style).  Turn off the widget
	/// by pressing the "i" key again (or invoke the Off() method).
	///
	/// The vtkPlaneWidget has several methods that can be used in conjunction
	/// with other VTK objects. The Set/GetResolution() methods control the number
	/// of subdivisions of the plane; the GetPolyData() method can be used to get
	/// the polygonal representation and can be used for things like seeding
	/// stream lines. GetPlane() can be used to update a vtkPlane implicit
	/// function. Typical usage of the widget is to make use of the
	/// StartInteractionEvent, InteractionEvent, and EndInteractionEvent
	/// events. The InteractionEvent is called on mouse motion; the other two
	/// events are called on button down and button up (either left or right
	/// button).
	///
	/// Some additional features of this class include the ability to control the
	/// properties of the widget. You can set the properties of the selected and
	/// unselected representations of the plane. For example, you can set the
	/// property for the handles and plane. In addition there are methods to
	/// constrain the plane so that it is perpendicular to the x-y-z axes.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtk3DWidget vtkBoxWidget vtkLineWidget vtkSphereWidget
	/// vtkImplicitPlaneWidget
	/// </seealso>
	// Token: 0x0200034C RID: 844
	public class vtkPlaneWidget : vtkPolyDataSourceWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600994D RID: 39245 RVA: 0x000D95EF File Offset: 0x000D77EF
		static vtkPlaneWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPlaneWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlaneWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600994E RID: 39246 RVA: 0x000D9617 File Offset: 0x000D7817
		public vtkPlaneWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600994F RID: 39247
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlaneWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x06009950 RID: 39248 RVA: 0x000D9628 File Offset: 0x000D7828
		public new static vtkPlaneWidget New()
		{
			vtkPlaneWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlaneWidget.vtkPlaneWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlaneWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x06009951 RID: 39249 RVA: 0x000D967C File Offset: 0x000D787C
		public vtkPlaneWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPlaneWidget.vtkPlaneWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06009952 RID: 39250 RVA: 0x000D96C0 File Offset: 0x000D78C0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06009953 RID: 39251
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlaneWidget_GetCenter_01(HandleRef pThis);

		/// <summary>
		/// Get the center of the plane.
		/// </summary>
		// Token: 0x06009954 RID: 39252 RVA: 0x000D96CC File Offset: 0x000D78CC
		public double[] GetCenter()
		{
			IntPtr intPtr = vtkPlaneWidget.vtkPlaneWidget_GetCenter_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06009955 RID: 39253
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneWidget_GetCenter_02(HandleRef pThis, IntPtr xyz);

		/// <summary>
		/// Get the center of the plane.
		/// </summary>
		// Token: 0x06009956 RID: 39254 RVA: 0x000D9714 File Offset: 0x000D7914
		public void GetCenter(IntPtr xyz)
		{
			vtkPlaneWidget.vtkPlaneWidget_GetCenter_02(base.GetCppThis(), xyz);
		}

		// Token: 0x06009957 RID: 39255
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlaneWidget_GetHandleProperty_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the handle properties (the little balls are the handles). The
		/// properties of the handles when selected and normal can be
		/// manipulated.
		/// </summary>
		// Token: 0x06009958 RID: 39256 RVA: 0x000D9724 File Offset: 0x000D7924
		public virtual vtkProperty GetHandleProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlaneWidget.vtkPlaneWidget_GetHandleProperty_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06009959 RID: 39257
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlaneWidget_GetNormal_04(HandleRef pThis);

		/// <summary>
		/// Get the normal to the plane.
		/// </summary>
		// Token: 0x0600995A RID: 39258 RVA: 0x000D9794 File Offset: 0x000D7994
		public double[] GetNormal()
		{
			IntPtr intPtr = vtkPlaneWidget.vtkPlaneWidget_GetNormal_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600995B RID: 39259
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneWidget_GetNormal_05(HandleRef pThis, IntPtr xyz);

		/// <summary>
		/// Get the normal to the plane.
		/// </summary>
		// Token: 0x0600995C RID: 39260 RVA: 0x000D97DC File Offset: 0x000D79DC
		public void GetNormal(IntPtr xyz)
		{
			vtkPlaneWidget.vtkPlaneWidget_GetNormal_05(base.GetCppThis(), xyz);
		}

		// Token: 0x0600995D RID: 39261
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlaneWidget_GetNormalToXAxis_06(HandleRef pThis);

		/// <summary>
		/// Force the plane widget to be aligned with one of the x-y-z axes.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the plane to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x0600995E RID: 39262 RVA: 0x000D97EC File Offset: 0x000D79EC
		public virtual int GetNormalToXAxis()
		{
			return vtkPlaneWidget.vtkPlaneWidget_GetNormalToXAxis_06(base.GetCppThis());
		}

		// Token: 0x0600995F RID: 39263
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlaneWidget_GetNormalToYAxis_07(HandleRef pThis);

		/// <summary>
		/// Force the plane widget to be aligned with one of the x-y-z axes.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the plane to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x06009960 RID: 39264 RVA: 0x000D980C File Offset: 0x000D7A0C
		public virtual int GetNormalToYAxis()
		{
			return vtkPlaneWidget.vtkPlaneWidget_GetNormalToYAxis_07(base.GetCppThis());
		}

		// Token: 0x06009961 RID: 39265
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlaneWidget_GetNormalToZAxis_08(HandleRef pThis);

		/// <summary>
		/// Force the plane widget to be aligned with one of the x-y-z axes.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the plane to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x06009962 RID: 39266 RVA: 0x000D982C File Offset: 0x000D7A2C
		public virtual int GetNormalToZAxis()
		{
			return vtkPlaneWidget.vtkPlaneWidget_GetNormalToZAxis_08(base.GetCppThis());
		}

		// Token: 0x06009963 RID: 39267
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlaneWidget_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x06009964 RID: 39268 RVA: 0x000D984C File Offset: 0x000D7A4C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPlaneWidget.vtkPlaneWidget_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x06009965 RID: 39269
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlaneWidget_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x06009966 RID: 39270 RVA: 0x000D986C File Offset: 0x000D7A6C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPlaneWidget.vtkPlaneWidget_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x06009967 RID: 39271
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlaneWidget_GetOrigin_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the origin of the plane.
		/// </summary>
		// Token: 0x06009968 RID: 39272 RVA: 0x000D9888 File Offset: 0x000D7A88
		public double[] GetOrigin()
		{
			IntPtr intPtr = vtkPlaneWidget.vtkPlaneWidget_GetOrigin_11(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06009969 RID: 39273
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneWidget_GetOrigin_12(HandleRef pThis, IntPtr xyz);

		/// <summary>
		/// Set/Get the origin of the plane.
		/// </summary>
		// Token: 0x0600996A RID: 39274 RVA: 0x000D98D0 File Offset: 0x000D7AD0
		public void GetOrigin(IntPtr xyz)
		{
			vtkPlaneWidget.vtkPlaneWidget_GetOrigin_12(base.GetCppThis(), xyz);
		}

		// Token: 0x0600996B RID: 39275
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneWidget_GetPlane_13(HandleRef pThis, HandleRef plane);

		/// <summary>
		/// Get the planes describing the implicit function defined by the plane
		/// widget. The user must provide the instance of the class vtkPlane. Note
		/// that vtkPlane is a subclass of vtkImplicitFunction, meaning that it can
		/// be used by a variety of filters to perform clipping, cutting, and
		/// selection of data.
		/// </summary>
		// Token: 0x0600996C RID: 39276 RVA: 0x000D98E0 File Offset: 0x000D7AE0
		public void GetPlane(vtkPlane plane)
		{
			vtkPlaneWidget.vtkPlaneWidget_GetPlane_13(base.GetCppThis(), (plane == null) ? default(HandleRef) : plane.GetCppThis());
		}

		// Token: 0x0600996D RID: 39277
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlaneWidget_GetPlaneProperty_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the plane properties. The properties of the plane when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x0600996E RID: 39278 RVA: 0x000D9910 File Offset: 0x000D7B10
		public virtual vtkProperty GetPlaneProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlaneWidget.vtkPlaneWidget_GetPlaneProperty_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600996F RID: 39279
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlaneWidget_GetPoint1_15(HandleRef pThis);

		/// <summary>
		/// Set/Get the position of the point defining the first axis of the plane.
		/// </summary>
		// Token: 0x06009970 RID: 39280 RVA: 0x000D9980 File Offset: 0x000D7B80
		public double[] GetPoint1()
		{
			IntPtr intPtr = vtkPlaneWidget.vtkPlaneWidget_GetPoint1_15(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06009971 RID: 39281
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneWidget_GetPoint1_16(HandleRef pThis, IntPtr xyz);

		/// <summary>
		/// Set/Get the position of the point defining the first axis of the plane.
		/// </summary>
		// Token: 0x06009972 RID: 39282 RVA: 0x000D99C8 File Offset: 0x000D7BC8
		public void GetPoint1(IntPtr xyz)
		{
			vtkPlaneWidget.vtkPlaneWidget_GetPoint1_16(base.GetCppThis(), xyz);
		}

		// Token: 0x06009973 RID: 39283
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlaneWidget_GetPoint2_17(HandleRef pThis);

		/// <summary>
		/// Set/Get the position of the point defining the second axis of the plane.
		/// </summary>
		// Token: 0x06009974 RID: 39284 RVA: 0x000D99D8 File Offset: 0x000D7BD8
		public double[] GetPoint2()
		{
			IntPtr intPtr = vtkPlaneWidget.vtkPlaneWidget_GetPoint2_17(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06009975 RID: 39285
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneWidget_GetPoint2_18(HandleRef pThis, IntPtr xyz);

		/// <summary>
		/// Set/Get the position of the point defining the second axis of the plane.
		/// </summary>
		// Token: 0x06009976 RID: 39286 RVA: 0x000D9A20 File Offset: 0x000D7C20
		public void GetPoint2(IntPtr xyz)
		{
			vtkPlaneWidget.vtkPlaneWidget_GetPoint2_18(base.GetCppThis(), xyz);
		}

		// Token: 0x06009977 RID: 39287
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneWidget_GetPolyData_19(HandleRef pThis, HandleRef pd);

		/// <summary>
		/// Grab the polydata (including points) that defines the plane.  The
		/// polydata consists of (res+1)*(res+1) points, and res*res quadrilateral
		/// polygons, where res is the resolution of the plane. These point values
		/// are guaranteed to be up-to-date when either the InteractionEvent or
		/// EndInteraction events are invoked. The user provides the vtkPolyData and
		/// the points and polyplane are added to it.
		/// </summary>
		// Token: 0x06009978 RID: 39288 RVA: 0x000D9A30 File Offset: 0x000D7C30
		public void GetPolyData(vtkPolyData pd)
		{
			vtkPlaneWidget.vtkPlaneWidget_GetPolyData_19(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x06009979 RID: 39289
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlaneWidget_GetPolyDataAlgorithm_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Satisfies superclass API.  This returns a pointer to the underlying
		/// PolyData.  Make changes to this before calling the initial PlaceWidget()
		/// to have the initial placement follow suit.  Or, make changes after the
		/// widget has been initialised and call UpdatePlacement() to realise.
		/// </summary>
		// Token: 0x0600997A RID: 39290 RVA: 0x000D9A60 File Offset: 0x000D7C60
		public override vtkPolyDataAlgorithm GetPolyDataAlgorithm()
		{
			vtkPolyDataAlgorithm vtkPolyDataAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlaneWidget.vtkPlaneWidget_GetPolyDataAlgorithm_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataAlgorithm = (vtkPolyDataAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataAlgorithm.Register(null);
				}
			}
			return vtkPolyDataAlgorithm;
		}

		// Token: 0x0600997B RID: 39291
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlaneWidget_GetRepresentation_21(HandleRef pThis);

		/// <summary>
		/// Control how the plane appears when GetPolyData() is invoked.
		/// If the mode is "outline", then just the outline of the plane
		/// is shown. If the mode is "wireframe" then the plane is drawn
		/// with the outline plus the interior mesh (corresponding to the
		/// resolution specified). If the mode is "surface" then the plane
		/// is drawn as a surface.
		/// </summary>
		// Token: 0x0600997C RID: 39292 RVA: 0x000D9AD0 File Offset: 0x000D7CD0
		public virtual int GetRepresentation()
		{
			return vtkPlaneWidget.vtkPlaneWidget_GetRepresentation_21(base.GetCppThis());
		}

		// Token: 0x0600997D RID: 39293
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlaneWidget_GetRepresentationMaxValue_22(HandleRef pThis);

		/// <summary>
		/// Control how the plane appears when GetPolyData() is invoked.
		/// If the mode is "outline", then just the outline of the plane
		/// is shown. If the mode is "wireframe" then the plane is drawn
		/// with the outline plus the interior mesh (corresponding to the
		/// resolution specified). If the mode is "surface" then the plane
		/// is drawn as a surface.
		/// </summary>
		// Token: 0x0600997E RID: 39294 RVA: 0x000D9AF0 File Offset: 0x000D7CF0
		public virtual int GetRepresentationMaxValue()
		{
			return vtkPlaneWidget.vtkPlaneWidget_GetRepresentationMaxValue_22(base.GetCppThis());
		}

		// Token: 0x0600997F RID: 39295
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlaneWidget_GetRepresentationMinValue_23(HandleRef pThis);

		/// <summary>
		/// Control how the plane appears when GetPolyData() is invoked.
		/// If the mode is "outline", then just the outline of the plane
		/// is shown. If the mode is "wireframe" then the plane is drawn
		/// with the outline plus the interior mesh (corresponding to the
		/// resolution specified). If the mode is "surface" then the plane
		/// is drawn as a surface.
		/// </summary>
		// Token: 0x06009980 RID: 39296 RVA: 0x000D9B10 File Offset: 0x000D7D10
		public virtual int GetRepresentationMinValue()
		{
			return vtkPlaneWidget.vtkPlaneWidget_GetRepresentationMinValue_23(base.GetCppThis());
		}

		// Token: 0x06009981 RID: 39297
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlaneWidget_GetResolution_24(HandleRef pThis);

		/// <summary>
		/// Set/Get the resolution (number of subdivisions) of the plane.
		/// </summary>
		// Token: 0x06009982 RID: 39298 RVA: 0x000D9B30 File Offset: 0x000D7D30
		public int GetResolution()
		{
			return vtkPlaneWidget.vtkPlaneWidget_GetResolution_24(base.GetCppThis());
		}

		// Token: 0x06009983 RID: 39299
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlaneWidget_GetSelectedHandleProperty_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the handle properties (the little balls are the handles). The
		/// properties of the handles when selected and normal can be
		/// manipulated.
		/// </summary>
		// Token: 0x06009984 RID: 39300 RVA: 0x000D9B50 File Offset: 0x000D7D50
		public virtual vtkProperty GetSelectedHandleProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlaneWidget.vtkPlaneWidget_GetSelectedHandleProperty_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06009985 RID: 39301
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlaneWidget_GetSelectedPlaneProperty_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the plane properties. The properties of the plane when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x06009986 RID: 39302 RVA: 0x000D9BC0 File Offset: 0x000D7DC0
		public virtual vtkProperty GetSelectedPlaneProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlaneWidget.vtkPlaneWidget_GetSelectedPlaneProperty_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06009987 RID: 39303
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlaneWidget_IsA_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x06009988 RID: 39304 RVA: 0x000D9C30 File Offset: 0x000D7E30
		public override int IsA(string type)
		{
			return vtkPlaneWidget.vtkPlaneWidget_IsA_27(base.GetCppThis(), type);
		}

		// Token: 0x06009989 RID: 39305
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlaneWidget_IsTypeOf_28([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x0600998A RID: 39306 RVA: 0x000D9C50 File Offset: 0x000D7E50
		public new static int IsTypeOf(string type)
		{
			return vtkPlaneWidget.vtkPlaneWidget_IsTypeOf_28(type);
		}

		// Token: 0x0600998B RID: 39307
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlaneWidget_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x0600998C RID: 39308 RVA: 0x000D9C6C File Offset: 0x000D7E6C
		public new vtkPlaneWidget NewInstance()
		{
			vtkPlaneWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlaneWidget.vtkPlaneWidget_NewInstance_30(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlaneWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600998D RID: 39309
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneWidget_NormalToXAxisOff_31(HandleRef pThis);

		/// <summary>
		/// Force the plane widget to be aligned with one of the x-y-z axes.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the plane to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x0600998E RID: 39310 RVA: 0x000D9CC6 File Offset: 0x000D7EC6
		public virtual void NormalToXAxisOff()
		{
			vtkPlaneWidget.vtkPlaneWidget_NormalToXAxisOff_31(base.GetCppThis());
		}

		// Token: 0x0600998F RID: 39311
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneWidget_NormalToXAxisOn_32(HandleRef pThis);

		/// <summary>
		/// Force the plane widget to be aligned with one of the x-y-z axes.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the plane to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x06009990 RID: 39312 RVA: 0x000D9CD5 File Offset: 0x000D7ED5
		public virtual void NormalToXAxisOn()
		{
			vtkPlaneWidget.vtkPlaneWidget_NormalToXAxisOn_32(base.GetCppThis());
		}

		// Token: 0x06009991 RID: 39313
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneWidget_NormalToYAxisOff_33(HandleRef pThis);

		/// <summary>
		/// Force the plane widget to be aligned with one of the x-y-z axes.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the plane to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x06009992 RID: 39314 RVA: 0x000D9CE4 File Offset: 0x000D7EE4
		public virtual void NormalToYAxisOff()
		{
			vtkPlaneWidget.vtkPlaneWidget_NormalToYAxisOff_33(base.GetCppThis());
		}

		// Token: 0x06009993 RID: 39315
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneWidget_NormalToYAxisOn_34(HandleRef pThis);

		/// <summary>
		/// Force the plane widget to be aligned with one of the x-y-z axes.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the plane to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x06009994 RID: 39316 RVA: 0x000D9CF3 File Offset: 0x000D7EF3
		public virtual void NormalToYAxisOn()
		{
			vtkPlaneWidget.vtkPlaneWidget_NormalToYAxisOn_34(base.GetCppThis());
		}

		// Token: 0x06009995 RID: 39317
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneWidget_NormalToZAxisOff_35(HandleRef pThis);

		/// <summary>
		/// Force the plane widget to be aligned with one of the x-y-z axes.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the plane to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x06009996 RID: 39318 RVA: 0x000D9D02 File Offset: 0x000D7F02
		public virtual void NormalToZAxisOff()
		{
			vtkPlaneWidget.vtkPlaneWidget_NormalToZAxisOff_35(base.GetCppThis());
		}

		// Token: 0x06009997 RID: 39319
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneWidget_NormalToZAxisOn_36(HandleRef pThis);

		/// <summary>
		/// Force the plane widget to be aligned with one of the x-y-z axes.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the plane to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x06009998 RID: 39320 RVA: 0x000D9D11 File Offset: 0x000D7F11
		public virtual void NormalToZAxisOn()
		{
			vtkPlaneWidget.vtkPlaneWidget_NormalToZAxisOn_36(base.GetCppThis());
		}

		// Token: 0x06009999 RID: 39321
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneWidget_PlaceWidget_37(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Methods that satisfy the superclass' API.
		/// </summary>
		// Token: 0x0600999A RID: 39322 RVA: 0x000D9D20 File Offset: 0x000D7F20
		public override void PlaceWidget(IntPtr bounds)
		{
			vtkPlaneWidget.vtkPlaneWidget_PlaceWidget_37(base.GetCppThis(), bounds);
		}

		// Token: 0x0600999B RID: 39323
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneWidget_PlaceWidget_38(HandleRef pThis);

		/// <summary>
		/// Methods that satisfy the superclass' API.
		/// </summary>
		// Token: 0x0600999C RID: 39324 RVA: 0x000D9D30 File Offset: 0x000D7F30
		public override void PlaceWidget()
		{
			vtkPlaneWidget.vtkPlaneWidget_PlaceWidget_38(base.GetCppThis());
		}

		// Token: 0x0600999D RID: 39325
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneWidget_PlaceWidget_39(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

		/// <summary>
		/// Methods that satisfy the superclass' API.
		/// </summary>
		// Token: 0x0600999E RID: 39326 RVA: 0x000D9D3F File Offset: 0x000D7F3F
		public override void PlaceWidget(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
		{
			vtkPlaneWidget.vtkPlaneWidget_PlaceWidget_39(base.GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
		}

		// Token: 0x0600999F RID: 39327
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlaneWidget_SafeDownCast_40(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x060099A0 RID: 39328 RVA: 0x000D9D58 File Offset: 0x000D7F58
		public new static vtkPlaneWidget SafeDownCast(vtkObjectBase o)
		{
			vtkPlaneWidget vtkPlaneWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlaneWidget.vtkPlaneWidget_SafeDownCast_40((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlaneWidget = (vtkPlaneWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlaneWidget.Register(null);
				}
			}
			return vtkPlaneWidget;
		}

		// Token: 0x060099A1 RID: 39329
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneWidget_SetCenter_41(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Get the center of the plane.
		/// </summary>
		// Token: 0x060099A2 RID: 39330 RVA: 0x000D9DD7 File Offset: 0x000D7FD7
		public void SetCenter(double x, double y, double z)
		{
			vtkPlaneWidget.vtkPlaneWidget_SetCenter_41(base.GetCppThis(), x, y, z);
		}

		// Token: 0x060099A3 RID: 39331
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneWidget_SetCenter_42(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Get the center of the plane.
		/// </summary>
		// Token: 0x060099A4 RID: 39332 RVA: 0x000D9DE9 File Offset: 0x000D7FE9
		public void SetCenter(IntPtr x)
		{
			vtkPlaneWidget.vtkPlaneWidget_SetCenter_42(base.GetCppThis(), x);
		}

		// Token: 0x060099A5 RID: 39333
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneWidget_SetEnabled_43(HandleRef pThis, int arg0);

		/// <summary>
		/// Methods that satisfy the superclass' API.
		/// </summary>
		// Token: 0x060099A6 RID: 39334 RVA: 0x000D9DF9 File Offset: 0x000D7FF9
		public override void SetEnabled(int arg0)
		{
			vtkPlaneWidget.vtkPlaneWidget_SetEnabled_43(base.GetCppThis(), arg0);
		}

		// Token: 0x060099A7 RID: 39335
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneWidget_SetNormal_44(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Get the normal to the plane.
		/// </summary>
		// Token: 0x060099A8 RID: 39336 RVA: 0x000D9E09 File Offset: 0x000D8009
		public void SetNormal(double x, double y, double z)
		{
			vtkPlaneWidget.vtkPlaneWidget_SetNormal_44(base.GetCppThis(), x, y, z);
		}

		// Token: 0x060099A9 RID: 39337
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneWidget_SetNormal_45(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Get the normal to the plane.
		/// </summary>
		// Token: 0x060099AA RID: 39338 RVA: 0x000D9E1B File Offset: 0x000D801B
		public void SetNormal(IntPtr x)
		{
			vtkPlaneWidget.vtkPlaneWidget_SetNormal_45(base.GetCppThis(), x);
		}

		// Token: 0x060099AB RID: 39339
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneWidget_SetNormalToXAxis_46(HandleRef pThis, int _arg);

		/// <summary>
		/// Force the plane widget to be aligned with one of the x-y-z axes.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the plane to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x060099AC RID: 39340 RVA: 0x000D9E2B File Offset: 0x000D802B
		public virtual void SetNormalToXAxis(int _arg)
		{
			vtkPlaneWidget.vtkPlaneWidget_SetNormalToXAxis_46(base.GetCppThis(), _arg);
		}

		// Token: 0x060099AD RID: 39341
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneWidget_SetNormalToYAxis_47(HandleRef pThis, int _arg);

		/// <summary>
		/// Force the plane widget to be aligned with one of the x-y-z axes.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the plane to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x060099AE RID: 39342 RVA: 0x000D9E3B File Offset: 0x000D803B
		public virtual void SetNormalToYAxis(int _arg)
		{
			vtkPlaneWidget.vtkPlaneWidget_SetNormalToYAxis_47(base.GetCppThis(), _arg);
		}

		// Token: 0x060099AF RID: 39343
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneWidget_SetNormalToZAxis_48(HandleRef pThis, int _arg);

		/// <summary>
		/// Force the plane widget to be aligned with one of the x-y-z axes.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the plane to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x060099B0 RID: 39344 RVA: 0x000D9E4B File Offset: 0x000D804B
		public virtual void SetNormalToZAxis(int _arg)
		{
			vtkPlaneWidget.vtkPlaneWidget_SetNormalToZAxis_48(base.GetCppThis(), _arg);
		}

		// Token: 0x060099B1 RID: 39345
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneWidget_SetOrigin_49(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Set/Get the origin of the plane.
		/// </summary>
		// Token: 0x060099B2 RID: 39346 RVA: 0x000D9E5B File Offset: 0x000D805B
		public void SetOrigin(double x, double y, double z)
		{
			vtkPlaneWidget.vtkPlaneWidget_SetOrigin_49(base.GetCppThis(), x, y, z);
		}

		// Token: 0x060099B3 RID: 39347
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneWidget_SetOrigin_50(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Set/Get the origin of the plane.
		/// </summary>
		// Token: 0x060099B4 RID: 39348 RVA: 0x000D9E6D File Offset: 0x000D806D
		public void SetOrigin(IntPtr x)
		{
			vtkPlaneWidget.vtkPlaneWidget_SetOrigin_50(base.GetCppThis(), x);
		}

		// Token: 0x060099B5 RID: 39349
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneWidget_SetPlaneProperty_51(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get the plane properties. The properties of the plane when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x060099B6 RID: 39350 RVA: 0x000D9E80 File Offset: 0x000D8080
		public virtual void SetPlaneProperty(vtkProperty arg0)
		{
			vtkPlaneWidget.vtkPlaneWidget_SetPlaneProperty_51(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060099B7 RID: 39351
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneWidget_SetPoint1_52(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Set/Get the position of the point defining the first axis of the plane.
		/// </summary>
		// Token: 0x060099B8 RID: 39352 RVA: 0x000D9EAF File Offset: 0x000D80AF
		public void SetPoint1(double x, double y, double z)
		{
			vtkPlaneWidget.vtkPlaneWidget_SetPoint1_52(base.GetCppThis(), x, y, z);
		}

		// Token: 0x060099B9 RID: 39353
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneWidget_SetPoint1_53(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Set/Get the position of the point defining the first axis of the plane.
		/// </summary>
		// Token: 0x060099BA RID: 39354 RVA: 0x000D9EC1 File Offset: 0x000D80C1
		public void SetPoint1(IntPtr x)
		{
			vtkPlaneWidget.vtkPlaneWidget_SetPoint1_53(base.GetCppThis(), x);
		}

		// Token: 0x060099BB RID: 39355
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneWidget_SetPoint2_54(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Set/Get the position of the point defining the second axis of the plane.
		/// </summary>
		// Token: 0x060099BC RID: 39356 RVA: 0x000D9ED1 File Offset: 0x000D80D1
		public void SetPoint2(double x, double y, double z)
		{
			vtkPlaneWidget.vtkPlaneWidget_SetPoint2_54(base.GetCppThis(), x, y, z);
		}

		// Token: 0x060099BD RID: 39357
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneWidget_SetPoint2_55(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Set/Get the position of the point defining the second axis of the plane.
		/// </summary>
		// Token: 0x060099BE RID: 39358 RVA: 0x000D9EE3 File Offset: 0x000D80E3
		public void SetPoint2(IntPtr x)
		{
			vtkPlaneWidget.vtkPlaneWidget_SetPoint2_55(base.GetCppThis(), x);
		}

		// Token: 0x060099BF RID: 39359
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneWidget_SetRepresentation_56(HandleRef pThis, int _arg);

		/// <summary>
		/// Control how the plane appears when GetPolyData() is invoked.
		/// If the mode is "outline", then just the outline of the plane
		/// is shown. If the mode is "wireframe" then the plane is drawn
		/// with the outline plus the interior mesh (corresponding to the
		/// resolution specified). If the mode is "surface" then the plane
		/// is drawn as a surface.
		/// </summary>
		// Token: 0x060099C0 RID: 39360 RVA: 0x000D9EF3 File Offset: 0x000D80F3
		public virtual void SetRepresentation(int _arg)
		{
			vtkPlaneWidget.vtkPlaneWidget_SetRepresentation_56(base.GetCppThis(), _arg);
		}

		// Token: 0x060099C1 RID: 39361
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneWidget_SetRepresentationToOff_57(HandleRef pThis);

		/// <summary>
		/// Control how the plane appears when GetPolyData() is invoked.
		/// If the mode is "outline", then just the outline of the plane
		/// is shown. If the mode is "wireframe" then the plane is drawn
		/// with the outline plus the interior mesh (corresponding to the
		/// resolution specified). If the mode is "surface" then the plane
		/// is drawn as a surface.
		/// </summary>
		// Token: 0x060099C2 RID: 39362 RVA: 0x000D9F03 File Offset: 0x000D8103
		public void SetRepresentationToOff()
		{
			vtkPlaneWidget.vtkPlaneWidget_SetRepresentationToOff_57(base.GetCppThis());
		}

		// Token: 0x060099C3 RID: 39363
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneWidget_SetRepresentationToOutline_58(HandleRef pThis);

		/// <summary>
		/// Control how the plane appears when GetPolyData() is invoked.
		/// If the mode is "outline", then just the outline of the plane
		/// is shown. If the mode is "wireframe" then the plane is drawn
		/// with the outline plus the interior mesh (corresponding to the
		/// resolution specified). If the mode is "surface" then the plane
		/// is drawn as a surface.
		/// </summary>
		// Token: 0x060099C4 RID: 39364 RVA: 0x000D9F12 File Offset: 0x000D8112
		public void SetRepresentationToOutline()
		{
			vtkPlaneWidget.vtkPlaneWidget_SetRepresentationToOutline_58(base.GetCppThis());
		}

		// Token: 0x060099C5 RID: 39365
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneWidget_SetRepresentationToSurface_59(HandleRef pThis);

		/// <summary>
		/// Control how the plane appears when GetPolyData() is invoked.
		/// If the mode is "outline", then just the outline of the plane
		/// is shown. If the mode is "wireframe" then the plane is drawn
		/// with the outline plus the interior mesh (corresponding to the
		/// resolution specified). If the mode is "surface" then the plane
		/// is drawn as a surface.
		/// </summary>
		// Token: 0x060099C6 RID: 39366 RVA: 0x000D9F21 File Offset: 0x000D8121
		public void SetRepresentationToSurface()
		{
			vtkPlaneWidget.vtkPlaneWidget_SetRepresentationToSurface_59(base.GetCppThis());
		}

		// Token: 0x060099C7 RID: 39367
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneWidget_SetRepresentationToWireframe_60(HandleRef pThis);

		/// <summary>
		/// Control how the plane appears when GetPolyData() is invoked.
		/// If the mode is "outline", then just the outline of the plane
		/// is shown. If the mode is "wireframe" then the plane is drawn
		/// with the outline plus the interior mesh (corresponding to the
		/// resolution specified). If the mode is "surface" then the plane
		/// is drawn as a surface.
		/// </summary>
		// Token: 0x060099C8 RID: 39368 RVA: 0x000D9F30 File Offset: 0x000D8130
		public void SetRepresentationToWireframe()
		{
			vtkPlaneWidget.vtkPlaneWidget_SetRepresentationToWireframe_60(base.GetCppThis());
		}

		// Token: 0x060099C9 RID: 39369
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneWidget_SetResolution_61(HandleRef pThis, int r);

		/// <summary>
		/// Set/Get the resolution (number of subdivisions) of the plane.
		/// </summary>
		// Token: 0x060099CA RID: 39370 RVA: 0x000D9F3F File Offset: 0x000D813F
		public void SetResolution(int r)
		{
			vtkPlaneWidget.vtkPlaneWidget_SetResolution_61(base.GetCppThis(), r);
		}

		// Token: 0x060099CB RID: 39371
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneWidget_UpdatePlacement_62(HandleRef pThis);

		/// <summary>
		/// Satisfies superclass API.  This will change the state of the widget to
		/// match changes that have been made to the underlying PolyDataSource
		/// </summary>
		// Token: 0x060099CC RID: 39372 RVA: 0x000D9F4F File Offset: 0x000D814F
		public override void UpdatePlacement()
		{
			vtkPlaneWidget.vtkPlaneWidget_UpdatePlacement_62(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C87 RID: 3207
		public new const string MRFullTypeName = "Kitware.VTK.vtkPlaneWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C88 RID: 3208
		public new static readonly string MRClassNameKey = "class vtkPlaneWidget";
	}
}
