using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBoxWidget
	/// </summary>
	/// <remarks>
	///    orthogonal hexahedron 3D widget
	///
	/// This 3D widget defines a region of interest that is represented by an
	/// arbitrarily oriented hexahedron with interior face angles of 90 degrees
	/// (orthogonal faces). The object creates 7 handles that can be moused on and
	/// manipulated. The first six correspond to the six faces, the seventh is in
	/// the center of the hexahedron. In addition, a bounding box outline is shown,
	/// the "faces" of which can be selected for object rotation or scaling. A
	/// nice feature of the object is that the vtkBoxWidget, like any 3D widget,
	/// will work with the current interactor style. That is, if vtkBoxWidget does
	/// not handle an event, then all other registered observers (including the
	/// interactor style) have an opportunity to process the event. Otherwise, the
	/// vtkBoxWidget will terminate the processing of the event that it handles.
	///
	/// To use this object, just invoke SetInteractor() with the argument of the
	/// method a vtkRenderWindowInteractor.  You may also wish to invoke
	/// "PlaceWidget()" to initially position the widget. The interactor will act
	/// normally until the "i" key (for "interactor") is pressed, at which point the
	/// vtkBoxWidget will appear. (See superclass documentation for information
	/// about changing this behavior.) By grabbing the six face handles (use the
	/// left mouse button), faces can be moved. By grabbing the center handle
	/// (with the left mouse button), the entire hexahedron can be
	/// translated. (Translation can also be employed by using the
	/// "shift-left-mouse-button" combination inside of the widget.) Scaling is
	/// achieved by using the right mouse button "up" the render window (makes the
	/// widget bigger) or "down" the render window (makes the widget smaller). To
	/// rotate vtkBoxWidget, pick a face (but not a face handle) and move the left
	/// mouse. (Note: the mouse button must be held down during manipulation.)
	/// Events that occur outside of the widget (i.e., no part of the widget is
	/// picked) are propagated to any other registered obsevers (such as the
	/// interaction style).  Turn off the widget by pressing the "i" key again.
	/// (See the superclass documentation on key press activiation.)
	///
	/// The vtkBoxWidget is very flexible. It can be used to select, cut, clip, or
	/// perform any other operation that depends on an implicit function (use the
	/// GetPlanes() method); or it can be used to transform objects using a linear
	/// transformation (use the GetTransform() method). Typical usage of the
	/// widget is to make use of the StartInteractionEvent, InteractionEvent, and
	/// EndInteractionEvent events. The InteractionEvent is called on mouse
	/// motion; the other two events are called on button down and button up
	/// (either left or right button).
	///
	/// Some additional features of this class include the ability to control the
	/// rendered properties of the widget. You can set the properties of the
	/// selected and unselected representations of the parts of the widget. For
	/// example, you can set the property for the handles, faces, and outline in
	/// their normal and selected states.
	///
	/// The box widget can be oriented by specifying a transformation matrix.
	/// This transformation is applied to the initial bounding box as defined by
	/// the PlaceWidget() method. DO NOT ASSUME that the transformation is applied
	/// to a unit box centered at the origin; this is wrong!
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtk3DWidget vtkPointWidget vtkLineWidget vtkPlaneWidget
	/// vtkImplicitPlaneWidget vtkImagePlaneWidget
	/// </seealso>
	// Token: 0x020002D8 RID: 728
	public class vtkBoxWidget : vtk3DWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060082FB RID: 33531 RVA: 0x000BB5C5 File Offset: 0x000B97C5
		static vtkBoxWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBoxWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBoxWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060082FC RID: 33532 RVA: 0x000BB5ED File Offset: 0x000B97ED
		public vtkBoxWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060082FD RID: 33533
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBoxWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x060082FE RID: 33534 RVA: 0x000BB5FC File Offset: 0x000B97FC
		public new static vtkBoxWidget New()
		{
			vtkBoxWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBoxWidget.vtkBoxWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBoxWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x060082FF RID: 33535 RVA: 0x000BB650 File Offset: 0x000B9850
		public vtkBoxWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBoxWidget.vtkBoxWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06008300 RID: 33536 RVA: 0x000BB694 File Offset: 0x000B9894
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06008301 RID: 33537
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBoxWidget_GetFaceProperty_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the face properties (the faces of the box). The
		/// properties of the face when selected and normal can be
		/// set.
		/// </summary>
		// Token: 0x06008302 RID: 33538 RVA: 0x000BB6A0 File Offset: 0x000B98A0
		public virtual vtkProperty GetFaceProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBoxWidget.vtkBoxWidget_GetFaceProperty_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008303 RID: 33539
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBoxWidget_GetHandleProperty_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the handle properties (the little balls are the handles). The
		/// properties of the handles when selected and normal can be
		/// set.
		/// </summary>
		// Token: 0x06008304 RID: 33540 RVA: 0x000BB710 File Offset: 0x000B9910
		public virtual vtkProperty GetHandleProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBoxWidget.vtkBoxWidget_GetHandleProperty_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008305 RID: 33541
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBoxWidget_GetInsideOut_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the InsideOut flag. When off, the normals point out of the
		/// box. When on, the normals point into the hexahedron.  InsideOut
		/// is off by default.
		/// </summary>
		// Token: 0x06008306 RID: 33542 RVA: 0x000BB780 File Offset: 0x000B9980
		public virtual int GetInsideOut()
		{
			return vtkBoxWidget.vtkBoxWidget_GetInsideOut_03(base.GetCppThis());
		}

		// Token: 0x06008307 RID: 33543
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBoxWidget_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x06008308 RID: 33544 RVA: 0x000BB7A0 File Offset: 0x000B99A0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBoxWidget.vtkBoxWidget_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06008309 RID: 33545
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBoxWidget_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x0600830A RID: 33546 RVA: 0x000BB7C0 File Offset: 0x000B99C0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBoxWidget.vtkBoxWidget_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0600830B RID: 33547
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBoxWidget_GetOutlineCursorWires_06(HandleRef pThis);

		/// <summary>
		/// Control the representation of the outline. This flag enables
		/// the cursor lines running between the handles. By default cursor
		/// wires are on.
		/// </summary>
		// Token: 0x0600830C RID: 33548 RVA: 0x000BB7DC File Offset: 0x000B99DC
		public virtual int GetOutlineCursorWires()
		{
			return vtkBoxWidget.vtkBoxWidget_GetOutlineCursorWires_06(base.GetCppThis());
		}

		// Token: 0x0600830D RID: 33549
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBoxWidget_GetOutlineFaceWires_07(HandleRef pThis);

		/// <summary>
		/// Control the representation of the outline. This flag enables
		/// face wires. By default face wires are off.
		/// </summary>
		// Token: 0x0600830E RID: 33550 RVA: 0x000BB7FC File Offset: 0x000B99FC
		public virtual int GetOutlineFaceWires()
		{
			return vtkBoxWidget.vtkBoxWidget_GetOutlineFaceWires_07(base.GetCppThis());
		}

		// Token: 0x0600830F RID: 33551
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBoxWidget_GetOutlineProperty_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the outline properties (the outline of the box). The
		/// properties of the outline when selected and normal can be
		/// set.
		/// </summary>
		// Token: 0x06008310 RID: 33552 RVA: 0x000BB81C File Offset: 0x000B9A1C
		public virtual vtkProperty GetOutlineProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBoxWidget.vtkBoxWidget_GetOutlineProperty_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008311 RID: 33553
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxWidget_GetPlanes_09(HandleRef pThis, HandleRef planes);

		/// <summary>
		/// Get the planes describing the implicit function defined by the box
		/// widget. The user must provide the instance of the class vtkPlanes. Note
		/// that vtkPlanes is a subclass of vtkImplicitFunction, meaning that it can
		/// be used by a variety of filters to perform clipping, cutting, and
		/// selection of data.  (The direction of the normals of the planes can be
		/// reversed enabling the InsideOut flag.)
		/// </summary>
		// Token: 0x06008312 RID: 33554 RVA: 0x000BB88C File Offset: 0x000B9A8C
		public void GetPlanes(vtkPlanes planes)
		{
			vtkBoxWidget.vtkBoxWidget_GetPlanes_09(base.GetCppThis(), (planes == null) ? default(HandleRef) : planes.GetCppThis());
		}

		// Token: 0x06008313 RID: 33555
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxWidget_GetPolyData_10(HandleRef pThis, HandleRef pd);

		/// <summary>
		/// Grab the polydata (including points) that define the box widget. The
		/// polydata consists of 6 quadrilateral faces and 15 points. The first
		/// eight points define the eight corner vertices; the next six define the
		/// -x,+x, -y,+y, -z,+z face points; and the final point (the 15th out of 15
		/// points) defines the center of the hexahedron. These point values are
		/// guaranteed to be up-to-date when either the InteractionEvent or
		/// EndInteractionEvent events are invoked. The user provides the
		/// vtkPolyData and the points and cells are added to it.
		/// </summary>
		// Token: 0x06008314 RID: 33556 RVA: 0x000BB8BC File Offset: 0x000B9ABC
		public void GetPolyData(vtkPolyData pd)
		{
			vtkBoxWidget.vtkBoxWidget_GetPolyData_10(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x06008315 RID: 33557
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBoxWidget_GetRotationEnabled_11(HandleRef pThis);

		/// <summary>
		/// Control the behavior of the widget. Translation, rotation, and
		/// scaling can all be enabled and disabled.
		/// </summary>
		// Token: 0x06008316 RID: 33558 RVA: 0x000BB8EC File Offset: 0x000B9AEC
		public virtual int GetRotationEnabled()
		{
			return vtkBoxWidget.vtkBoxWidget_GetRotationEnabled_11(base.GetCppThis());
		}

		// Token: 0x06008317 RID: 33559
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBoxWidget_GetScalingEnabled_12(HandleRef pThis);

		/// <summary>
		/// Control the behavior of the widget. Translation, rotation, and
		/// scaling can all be enabled and disabled.
		/// </summary>
		// Token: 0x06008318 RID: 33560 RVA: 0x000BB90C File Offset: 0x000B9B0C
		public virtual int GetScalingEnabled()
		{
			return vtkBoxWidget.vtkBoxWidget_GetScalingEnabled_12(base.GetCppThis());
		}

		// Token: 0x06008319 RID: 33561
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBoxWidget_GetSelectedFaceProperty_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the face properties (the faces of the box). The
		/// properties of the face when selected and normal can be
		/// set.
		/// </summary>
		// Token: 0x0600831A RID: 33562 RVA: 0x000BB92C File Offset: 0x000B9B2C
		public virtual vtkProperty GetSelectedFaceProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBoxWidget.vtkBoxWidget_GetSelectedFaceProperty_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600831B RID: 33563
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBoxWidget_GetSelectedHandleProperty_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the handle properties (the little balls are the handles). The
		/// properties of the handles when selected and normal can be
		/// set.
		/// </summary>
		// Token: 0x0600831C RID: 33564 RVA: 0x000BB99C File Offset: 0x000B9B9C
		public virtual vtkProperty GetSelectedHandleProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBoxWidget.vtkBoxWidget_GetSelectedHandleProperty_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600831D RID: 33565
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBoxWidget_GetSelectedOutlineProperty_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the outline properties (the outline of the box). The
		/// properties of the outline when selected and normal can be
		/// set.
		/// </summary>
		// Token: 0x0600831E RID: 33566 RVA: 0x000BBA0C File Offset: 0x000B9C0C
		public virtual vtkProperty GetSelectedOutlineProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBoxWidget.vtkBoxWidget_GetSelectedOutlineProperty_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600831F RID: 33567
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxWidget_GetTransform_16(HandleRef pThis, HandleRef t);

		/// <summary>
		/// Retrieve a linear transform characterizing the transformation of the
		/// box. Note that the transformation is relative to where PlaceWidget
		/// was initially called. This method modifies the transform provided. The
		/// transform can be used to control the position of vtkProp3D's, as well as
		/// other transformation operations (e.g., vtkTransformPolyData).
		/// </summary>
		// Token: 0x06008320 RID: 33568 RVA: 0x000BBA7C File Offset: 0x000B9C7C
		public virtual void GetTransform(vtkTransform t)
		{
			vtkBoxWidget.vtkBoxWidget_GetTransform_16(base.GetCppThis(), (t == null) ? default(HandleRef) : t.GetCppThis());
		}

		// Token: 0x06008321 RID: 33569
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBoxWidget_GetTranslationEnabled_17(HandleRef pThis);

		/// <summary>
		/// Control the behavior of the widget. Translation, rotation, and
		/// scaling can all be enabled and disabled.
		/// </summary>
		// Token: 0x06008322 RID: 33570 RVA: 0x000BBAAC File Offset: 0x000B9CAC
		public virtual int GetTranslationEnabled()
		{
			return vtkBoxWidget.vtkBoxWidget_GetTranslationEnabled_17(base.GetCppThis());
		}

		// Token: 0x06008323 RID: 33571
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxWidget_HandlesOff_18(HandleRef pThis);

		/// <summary>
		/// Switches handles (the spheres) on or off by manipulating the actor
		/// visibility.
		/// </summary>
		// Token: 0x06008324 RID: 33572 RVA: 0x000BBACB File Offset: 0x000B9CCB
		public void HandlesOff()
		{
			vtkBoxWidget.vtkBoxWidget_HandlesOff_18(base.GetCppThis());
		}

		// Token: 0x06008325 RID: 33573
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxWidget_HandlesOn_19(HandleRef pThis);

		/// <summary>
		/// Switches handles (the spheres) on or off by manipulating the actor
		/// visibility.
		/// </summary>
		// Token: 0x06008326 RID: 33574 RVA: 0x000BBADA File Offset: 0x000B9CDA
		public void HandlesOn()
		{
			vtkBoxWidget.vtkBoxWidget_HandlesOn_19(base.GetCppThis());
		}

		// Token: 0x06008327 RID: 33575
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxWidget_InsideOutOff_20(HandleRef pThis);

		/// <summary>
		/// Set/Get the InsideOut flag. When off, the normals point out of the
		/// box. When on, the normals point into the hexahedron.  InsideOut
		/// is off by default.
		/// </summary>
		// Token: 0x06008328 RID: 33576 RVA: 0x000BBAE9 File Offset: 0x000B9CE9
		public virtual void InsideOutOff()
		{
			vtkBoxWidget.vtkBoxWidget_InsideOutOff_20(base.GetCppThis());
		}

		// Token: 0x06008329 RID: 33577
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxWidget_InsideOutOn_21(HandleRef pThis);

		/// <summary>
		/// Set/Get the InsideOut flag. When off, the normals point out of the
		/// box. When on, the normals point into the hexahedron.  InsideOut
		/// is off by default.
		/// </summary>
		// Token: 0x0600832A RID: 33578 RVA: 0x000BBAF8 File Offset: 0x000B9CF8
		public virtual void InsideOutOn()
		{
			vtkBoxWidget.vtkBoxWidget_InsideOutOn_21(base.GetCppThis());
		}

		// Token: 0x0600832B RID: 33579
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBoxWidget_IsA_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x0600832C RID: 33580 RVA: 0x000BBB08 File Offset: 0x000B9D08
		public override int IsA(string type)
		{
			return vtkBoxWidget.vtkBoxWidget_IsA_22(base.GetCppThis(), type);
		}

		// Token: 0x0600832D RID: 33581
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBoxWidget_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x0600832E RID: 33582 RVA: 0x000BBB28 File Offset: 0x000B9D28
		public new static int IsTypeOf(string type)
		{
			return vtkBoxWidget.vtkBoxWidget_IsTypeOf_23(type);
		}

		// Token: 0x0600832F RID: 33583
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBoxWidget_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x06008330 RID: 33584 RVA: 0x000BBB44 File Offset: 0x000B9D44
		public new vtkBoxWidget NewInstance()
		{
			vtkBoxWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBoxWidget.vtkBoxWidget_NewInstance_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBoxWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06008331 RID: 33585
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxWidget_OutlineCursorWiresOff_26(HandleRef pThis);

		/// <summary>
		/// Control the representation of the outline. This flag enables
		/// the cursor lines running between the handles. By default cursor
		/// wires are on.
		/// </summary>
		// Token: 0x06008332 RID: 33586 RVA: 0x000BBB9E File Offset: 0x000B9D9E
		public void OutlineCursorWiresOff()
		{
			vtkBoxWidget.vtkBoxWidget_OutlineCursorWiresOff_26(base.GetCppThis());
		}

		// Token: 0x06008333 RID: 33587
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxWidget_OutlineCursorWiresOn_27(HandleRef pThis);

		/// <summary>
		/// Control the representation of the outline. This flag enables
		/// the cursor lines running between the handles. By default cursor
		/// wires are on.
		/// </summary>
		// Token: 0x06008334 RID: 33588 RVA: 0x000BBBAD File Offset: 0x000B9DAD
		public void OutlineCursorWiresOn()
		{
			vtkBoxWidget.vtkBoxWidget_OutlineCursorWiresOn_27(base.GetCppThis());
		}

		// Token: 0x06008335 RID: 33589
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxWidget_OutlineFaceWiresOff_28(HandleRef pThis);

		/// <summary>
		/// Control the representation of the outline. This flag enables
		/// face wires. By default face wires are off.
		/// </summary>
		// Token: 0x06008336 RID: 33590 RVA: 0x000BBBBC File Offset: 0x000B9DBC
		public void OutlineFaceWiresOff()
		{
			vtkBoxWidget.vtkBoxWidget_OutlineFaceWiresOff_28(base.GetCppThis());
		}

		// Token: 0x06008337 RID: 33591
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxWidget_OutlineFaceWiresOn_29(HandleRef pThis);

		/// <summary>
		/// Control the representation of the outline. This flag enables
		/// face wires. By default face wires are off.
		/// </summary>
		// Token: 0x06008338 RID: 33592 RVA: 0x000BBBCB File Offset: 0x000B9DCB
		public void OutlineFaceWiresOn()
		{
			vtkBoxWidget.vtkBoxWidget_OutlineFaceWiresOn_29(base.GetCppThis());
		}

		// Token: 0x06008339 RID: 33593
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxWidget_PlaceWidget_30(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Methods that satisfy the superclass' API.
		/// </summary>
		// Token: 0x0600833A RID: 33594 RVA: 0x000BBBDA File Offset: 0x000B9DDA
		public override void PlaceWidget(IntPtr bounds)
		{
			vtkBoxWidget.vtkBoxWidget_PlaceWidget_30(base.GetCppThis(), bounds);
		}

		// Token: 0x0600833B RID: 33595
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxWidget_PlaceWidget_31(HandleRef pThis);

		/// <summary>
		/// Methods that satisfy the superclass' API.
		/// </summary>
		// Token: 0x0600833C RID: 33596 RVA: 0x000BBBEA File Offset: 0x000B9DEA
		public override void PlaceWidget()
		{
			vtkBoxWidget.vtkBoxWidget_PlaceWidget_31(base.GetCppThis());
		}

		// Token: 0x0600833D RID: 33597
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxWidget_PlaceWidget_32(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

		/// <summary>
		/// Methods that satisfy the superclass' API.
		/// </summary>
		// Token: 0x0600833E RID: 33598 RVA: 0x000BBBF9 File Offset: 0x000B9DF9
		public override void PlaceWidget(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
		{
			vtkBoxWidget.vtkBoxWidget_PlaceWidget_32(base.GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
		}

		// Token: 0x0600833F RID: 33599
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxWidget_RotationEnabledOff_33(HandleRef pThis);

		/// <summary>
		/// Control the behavior of the widget. Translation, rotation, and
		/// scaling can all be enabled and disabled.
		/// </summary>
		// Token: 0x06008340 RID: 33600 RVA: 0x000BBC11 File Offset: 0x000B9E11
		public virtual void RotationEnabledOff()
		{
			vtkBoxWidget.vtkBoxWidget_RotationEnabledOff_33(base.GetCppThis());
		}

		// Token: 0x06008341 RID: 33601
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxWidget_RotationEnabledOn_34(HandleRef pThis);

		/// <summary>
		/// Control the behavior of the widget. Translation, rotation, and
		/// scaling can all be enabled and disabled.
		/// </summary>
		// Token: 0x06008342 RID: 33602 RVA: 0x000BBC20 File Offset: 0x000B9E20
		public virtual void RotationEnabledOn()
		{
			vtkBoxWidget.vtkBoxWidget_RotationEnabledOn_34(base.GetCppThis());
		}

		// Token: 0x06008343 RID: 33603
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBoxWidget_SafeDownCast_35(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x06008344 RID: 33604 RVA: 0x000BBC30 File Offset: 0x000B9E30
		public new static vtkBoxWidget SafeDownCast(vtkObjectBase o)
		{
			vtkBoxWidget vtkBoxWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBoxWidget.vtkBoxWidget_SafeDownCast_35((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBoxWidget = (vtkBoxWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBoxWidget.Register(null);
				}
			}
			return vtkBoxWidget;
		}

		// Token: 0x06008345 RID: 33605
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxWidget_ScalingEnabledOff_36(HandleRef pThis);

		/// <summary>
		/// Control the behavior of the widget. Translation, rotation, and
		/// scaling can all be enabled and disabled.
		/// </summary>
		// Token: 0x06008346 RID: 33606 RVA: 0x000BBCAF File Offset: 0x000B9EAF
		public virtual void ScalingEnabledOff()
		{
			vtkBoxWidget.vtkBoxWidget_ScalingEnabledOff_36(base.GetCppThis());
		}

		// Token: 0x06008347 RID: 33607
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxWidget_ScalingEnabledOn_37(HandleRef pThis);

		/// <summary>
		/// Control the behavior of the widget. Translation, rotation, and
		/// scaling can all be enabled and disabled.
		/// </summary>
		// Token: 0x06008348 RID: 33608 RVA: 0x000BBCBE File Offset: 0x000B9EBE
		public virtual void ScalingEnabledOn()
		{
			vtkBoxWidget.vtkBoxWidget_ScalingEnabledOn_37(base.GetCppThis());
		}

		// Token: 0x06008349 RID: 33609
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxWidget_SetEnabled_38(HandleRef pThis, int arg0);

		/// <summary>
		/// Methods that satisfy the superclass' API.
		/// </summary>
		// Token: 0x0600834A RID: 33610 RVA: 0x000BBCCD File Offset: 0x000B9ECD
		public override void SetEnabled(int arg0)
		{
			vtkBoxWidget.vtkBoxWidget_SetEnabled_38(base.GetCppThis(), arg0);
		}

		// Token: 0x0600834B RID: 33611
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxWidget_SetInsideOut_39(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the InsideOut flag. When off, the normals point out of the
		/// box. When on, the normals point into the hexahedron.  InsideOut
		/// is off by default.
		/// </summary>
		// Token: 0x0600834C RID: 33612 RVA: 0x000BBCDD File Offset: 0x000B9EDD
		public virtual void SetInsideOut(int _arg)
		{
			vtkBoxWidget.vtkBoxWidget_SetInsideOut_39(base.GetCppThis(), _arg);
		}

		// Token: 0x0600834D RID: 33613
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxWidget_SetOutlineCursorWires_40(HandleRef pThis, int arg0);

		/// <summary>
		/// Control the representation of the outline. This flag enables
		/// the cursor lines running between the handles. By default cursor
		/// wires are on.
		/// </summary>
		// Token: 0x0600834E RID: 33614 RVA: 0x000BBCED File Offset: 0x000B9EED
		public void SetOutlineCursorWires(int arg0)
		{
			vtkBoxWidget.vtkBoxWidget_SetOutlineCursorWires_40(base.GetCppThis(), arg0);
		}

		// Token: 0x0600834F RID: 33615
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxWidget_SetOutlineFaceWires_41(HandleRef pThis, int arg0);

		/// <summary>
		/// Control the representation of the outline. This flag enables
		/// face wires. By default face wires are off.
		/// </summary>
		// Token: 0x06008350 RID: 33616 RVA: 0x000BBCFD File Offset: 0x000B9EFD
		public void SetOutlineFaceWires(int arg0)
		{
			vtkBoxWidget.vtkBoxWidget_SetOutlineFaceWires_41(base.GetCppThis(), arg0);
		}

		// Token: 0x06008351 RID: 33617
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxWidget_SetRotationEnabled_42(HandleRef pThis, int _arg);

		/// <summary>
		/// Control the behavior of the widget. Translation, rotation, and
		/// scaling can all be enabled and disabled.
		/// </summary>
		// Token: 0x06008352 RID: 33618 RVA: 0x000BBD0D File Offset: 0x000B9F0D
		public virtual void SetRotationEnabled(int _arg)
		{
			vtkBoxWidget.vtkBoxWidget_SetRotationEnabled_42(base.GetCppThis(), _arg);
		}

		// Token: 0x06008353 RID: 33619
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxWidget_SetScalingEnabled_43(HandleRef pThis, int _arg);

		/// <summary>
		/// Control the behavior of the widget. Translation, rotation, and
		/// scaling can all be enabled and disabled.
		/// </summary>
		// Token: 0x06008354 RID: 33620 RVA: 0x000BBD1D File Offset: 0x000B9F1D
		public virtual void SetScalingEnabled(int _arg)
		{
			vtkBoxWidget.vtkBoxWidget_SetScalingEnabled_43(base.GetCppThis(), _arg);
		}

		// Token: 0x06008355 RID: 33621
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxWidget_SetTransform_44(HandleRef pThis, HandleRef t);

		/// <summary>
		/// Set the position, scale and orientation of the box widget using the
		/// transform specified. Note that the transformation is relative to
		/// where PlaceWidget was initially called (i.e., the original bounding
		/// box).
		/// </summary>
		// Token: 0x06008356 RID: 33622 RVA: 0x000BBD30 File Offset: 0x000B9F30
		public virtual void SetTransform(vtkTransform t)
		{
			vtkBoxWidget.vtkBoxWidget_SetTransform_44(base.GetCppThis(), (t == null) ? default(HandleRef) : t.GetCppThis());
		}

		// Token: 0x06008357 RID: 33623
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxWidget_SetTranslationEnabled_45(HandleRef pThis, int _arg);

		/// <summary>
		/// Control the behavior of the widget. Translation, rotation, and
		/// scaling can all be enabled and disabled.
		/// </summary>
		// Token: 0x06008358 RID: 33624 RVA: 0x000BBD5F File Offset: 0x000B9F5F
		public virtual void SetTranslationEnabled(int _arg)
		{
			vtkBoxWidget.vtkBoxWidget_SetTranslationEnabled_45(base.GetCppThis(), _arg);
		}

		// Token: 0x06008359 RID: 33625
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxWidget_TranslationEnabledOff_46(HandleRef pThis);

		/// <summary>
		/// Control the behavior of the widget. Translation, rotation, and
		/// scaling can all be enabled and disabled.
		/// </summary>
		// Token: 0x0600835A RID: 33626 RVA: 0x000BBD6F File Offset: 0x000B9F6F
		public virtual void TranslationEnabledOff()
		{
			vtkBoxWidget.vtkBoxWidget_TranslationEnabledOff_46(base.GetCppThis());
		}

		// Token: 0x0600835B RID: 33627
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxWidget_TranslationEnabledOn_47(HandleRef pThis);

		/// <summary>
		/// Control the behavior of the widget. Translation, rotation, and
		/// scaling can all be enabled and disabled.
		/// </summary>
		// Token: 0x0600835C RID: 33628 RVA: 0x000BBD7E File Offset: 0x000B9F7E
		public virtual void TranslationEnabledOn()
		{
			vtkBoxWidget.vtkBoxWidget_TranslationEnabledOn_47(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B23 RID: 2851
		public new const string MRFullTypeName = "Kitware.VTK.vtkBoxWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B24 RID: 2852
		public new static readonly string MRClassNameKey = "class vtkBoxWidget";
	}
}
