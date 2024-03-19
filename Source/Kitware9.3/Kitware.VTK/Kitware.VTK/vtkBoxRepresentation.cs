using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBoxRepresentation
	/// </summary>
	/// <remarks>
	///    a class defining the representation for the vtkBoxWidget2
	///
	/// This class is a concrete representation for the vtkBoxWidget2. It
	/// represents a box with seven handles: one on each of the six faces, plus a
	/// center handle. Through interaction with the widget, the box
	/// representation can be arbitrarily positioned in the 3D space.
	///
	/// To use this representation, you normally use the PlaceWidget() method
	/// to position the widget at a specified region in space.
	///
	/// @warning
	/// This class, and vtkBoxWidget2, are second generation VTK
	/// widgets. An earlier version of this functionality was defined in the
	/// class vtkBoxWidget.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkBoxWidget2 vtkBoxWidget
	/// </seealso>
	// Token: 0x020002D6 RID: 726
	public class vtkBoxRepresentation : vtkWidgetRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600826F RID: 33391 RVA: 0x000BAA29 File Offset: 0x000B8C29
		static vtkBoxRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBoxRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBoxRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06008270 RID: 33392 RVA: 0x000BAA51 File Offset: 0x000B8C51
		public vtkBoxRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06008271 RID: 33393
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBoxRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x06008272 RID: 33394 RVA: 0x000BAA60 File Offset: 0x000B8C60
		public new static vtkBoxRepresentation New()
		{
			vtkBoxRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBoxRepresentation.vtkBoxRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBoxRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x06008273 RID: 33395 RVA: 0x000BAAB4 File Offset: 0x000B8CB4
		public vtkBoxRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBoxRepresentation.vtkBoxRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06008274 RID: 33396 RVA: 0x000BAAF8 File Offset: 0x000B8CF8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06008275 RID: 33397
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxRepresentation_BuildRepresentation_01(HandleRef pThis);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x06008276 RID: 33398 RVA: 0x000BAB03 File Offset: 0x000B8D03
		public override void BuildRepresentation()
		{
			vtkBoxRepresentation.vtkBoxRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06008277 RID: 33399
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxRepresentation_ComplexInteraction_02(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x06008278 RID: 33400 RVA: 0x000BAB14 File Offset: 0x000B8D14
		public override void ComplexInteraction(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata)
		{
			vtkBoxRepresentation.vtkBoxRepresentation_ComplexInteraction_02(base.GetCppThis(), (iren == null) ? default(HandleRef) : iren.GetCppThis(), (widget == null) ? default(HandleRef) : widget.GetCppThis(), arg2, calldata);
		}

		// Token: 0x06008279 RID: 33401
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBoxRepresentation_ComputeComplexInteractionState_03(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata, int modify);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x0600827A RID: 33402 RVA: 0x000BAB5C File Offset: 0x000B8D5C
		public override int ComputeComplexInteractionState(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata, int modify)
		{
			return vtkBoxRepresentation.vtkBoxRepresentation_ComputeComplexInteractionState_03(base.GetCppThis(), (iren == null) ? default(HandleRef) : iren.GetCppThis(), (widget == null) ? default(HandleRef) : widget.GetCppThis(), arg2, calldata, modify);
		}

		// Token: 0x0600827B RID: 33403
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBoxRepresentation_ComputeInteractionState_04(HandleRef pThis, int X, int Y, int modify);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x0600827C RID: 33404 RVA: 0x000BABAC File Offset: 0x000B8DAC
		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkBoxRepresentation.vtkBoxRepresentation_ComputeInteractionState_04(base.GetCppThis(), X, Y, modify);
		}

		// Token: 0x0600827D RID: 33405
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxRepresentation_EndComplexInteraction_05(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x0600827E RID: 33406 RVA: 0x000BABD0 File Offset: 0x000B8DD0
		public override void EndComplexInteraction(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata)
		{
			vtkBoxRepresentation.vtkBoxRepresentation_EndComplexInteraction_05(base.GetCppThis(), (iren == null) ? default(HandleRef) : iren.GetCppThis(), (widget == null) ? default(HandleRef) : widget.GetCppThis(), arg2, calldata);
		}

		// Token: 0x0600827F RID: 33407
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxRepresentation_GetActors_06(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp (i.e., support rendering).
		/// GetActors adds all the internal props used by this representation to the supplied collection.
		/// </summary>
		// Token: 0x06008280 RID: 33408 RVA: 0x000BAC18 File Offset: 0x000B8E18
		public override void GetActors(vtkPropCollection arg0)
		{
			vtkBoxRepresentation.vtkBoxRepresentation_GetActors_06(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06008281 RID: 33409
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBoxRepresentation_GetBounds_07(HandleRef pThis);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x06008282 RID: 33410 RVA: 0x000BAC48 File Offset: 0x000B8E48
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkBoxRepresentation.vtkBoxRepresentation_GetBounds_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06008283 RID: 33411
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBoxRepresentation_GetFaceProperty_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the face properties (the faces of the box). The
		/// properties of the face when selected and normal can be
		/// set.
		/// </summary>
		// Token: 0x06008284 RID: 33412 RVA: 0x000BAC90 File Offset: 0x000B8E90
		public virtual vtkProperty GetFaceProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBoxRepresentation.vtkBoxRepresentation_GetFaceProperty_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008285 RID: 33413
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBoxRepresentation_GetHandleProperty_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the handle properties (the little balls are the handles). The
		/// properties of the handles, when selected or normal, can be
		/// specified.
		/// </summary>
		// Token: 0x06008286 RID: 33414 RVA: 0x000BAD00 File Offset: 0x000B8F00
		public virtual vtkProperty GetHandleProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBoxRepresentation.vtkBoxRepresentation_GetHandleProperty_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008287 RID: 33415
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBoxRepresentation_GetInsideOut_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the InsideOut flag. This data member is used in conjunction
		/// with the GetPlanes() method. When off, the normals point out of the
		/// box. When on, the normals point into the hexahedron.  InsideOut is off
		/// by default.
		/// </summary>
		// Token: 0x06008288 RID: 33416 RVA: 0x000BAD70 File Offset: 0x000B8F70
		public virtual int GetInsideOut()
		{
			return vtkBoxRepresentation.vtkBoxRepresentation_GetInsideOut_10(base.GetCppThis());
		}

		// Token: 0x06008289 RID: 33417
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBoxRepresentation_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x0600828A RID: 33418 RVA: 0x000BAD90 File Offset: 0x000B8F90
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBoxRepresentation.vtkBoxRepresentation_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x0600828B RID: 33419
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBoxRepresentation_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x0600828C RID: 33420 RVA: 0x000BADB0 File Offset: 0x000B8FB0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBoxRepresentation.vtkBoxRepresentation_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x0600828D RID: 33421
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBoxRepresentation_GetOutlineCursorWires_13(HandleRef pThis);

		/// <summary>
		/// Control the representation of the outline. This flag enables
		/// the cursor lines running between the handles. By default cursor
		/// wires are on.
		/// </summary>
		// Token: 0x0600828E RID: 33422 RVA: 0x000BADCC File Offset: 0x000B8FCC
		public virtual int GetOutlineCursorWires()
		{
			return vtkBoxRepresentation.vtkBoxRepresentation_GetOutlineCursorWires_13(base.GetCppThis());
		}

		// Token: 0x0600828F RID: 33423
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBoxRepresentation_GetOutlineFaceWires_14(HandleRef pThis);

		/// <summary>
		/// Control the representation of the outline. This flag enables
		/// face wires. By default face wires are off.
		/// </summary>
		// Token: 0x06008290 RID: 33424 RVA: 0x000BADEC File Offset: 0x000B8FEC
		public virtual int GetOutlineFaceWires()
		{
			return vtkBoxRepresentation.vtkBoxRepresentation_GetOutlineFaceWires_14(base.GetCppThis());
		}

		// Token: 0x06008291 RID: 33425
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBoxRepresentation_GetOutlineProperty_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the outline properties (the outline of the box). The
		/// properties of the outline when selected and normal can be
		/// set.
		/// </summary>
		// Token: 0x06008292 RID: 33426 RVA: 0x000BAE0C File Offset: 0x000B900C
		public virtual vtkProperty GetOutlineProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBoxRepresentation.vtkBoxRepresentation_GetOutlineProperty_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008293 RID: 33427
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxRepresentation_GetPlanes_16(HandleRef pThis, HandleRef planes);

		/// <summary>
		/// Get the planes describing the implicit function defined by the box
		/// widget. The user must provide the instance of the class vtkPlanes. Note
		/// that vtkPlanes is a subclass of vtkImplicitFunction, meaning that it can
		/// be used by a variety of filters to perform clipping, cutting, and
		/// selection of data.  (The direction of the normals of the planes can be
		/// reversed enabling the InsideOut flag.)
		/// </summary>
		// Token: 0x06008294 RID: 33428 RVA: 0x000BAE7C File Offset: 0x000B907C
		public void GetPlanes(vtkPlanes planes)
		{
			vtkBoxRepresentation.vtkBoxRepresentation_GetPlanes_16(base.GetCppThis(), (planes == null) ? default(HandleRef) : planes.GetCppThis());
		}

		// Token: 0x06008295 RID: 33429
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxRepresentation_GetPolyData_17(HandleRef pThis, HandleRef pd);

		/// <summary>
		/// Grab the polydata (including points) that define the box widget. The
		/// polydata consists of 6 quadrilateral faces and 15 points. The first
		/// eight points define the eight corner vertices; the next six define the
		/// -x,+x, -y,+y, -z,+z face points; and the final point (the 15th out of 15
		/// points) defines the center of the box. These point values are guaranteed
		/// to be up-to-date when either the widget's corresponding InteractionEvent
		/// or EndInteractionEvent events are invoked. The user provides the
		/// vtkPolyData and the points and cells are added to it.
		/// </summary>
		// Token: 0x06008296 RID: 33430 RVA: 0x000BAEAC File Offset: 0x000B90AC
		public void GetPolyData(vtkPolyData pd)
		{
			vtkBoxRepresentation.vtkBoxRepresentation_GetPolyData_17(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x06008297 RID: 33431
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBoxRepresentation_GetSelectedFaceProperty_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the face properties (the faces of the box). The
		/// properties of the face when selected and normal can be
		/// set.
		/// </summary>
		// Token: 0x06008298 RID: 33432 RVA: 0x000BAEDC File Offset: 0x000B90DC
		public virtual vtkProperty GetSelectedFaceProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBoxRepresentation.vtkBoxRepresentation_GetSelectedFaceProperty_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008299 RID: 33433
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBoxRepresentation_GetSelectedHandleProperty_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the handle properties (the little balls are the handles). The
		/// properties of the handles, when selected or normal, can be
		/// specified.
		/// </summary>
		// Token: 0x0600829A RID: 33434 RVA: 0x000BAF4C File Offset: 0x000B914C
		public virtual vtkProperty GetSelectedHandleProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBoxRepresentation.vtkBoxRepresentation_GetSelectedHandleProperty_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600829B RID: 33435
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBoxRepresentation_GetSelectedOutlineProperty_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the outline properties (the outline of the box). The
		/// properties of the outline when selected and normal can be
		/// set.
		/// </summary>
		// Token: 0x0600829C RID: 33436 RVA: 0x000BAFBC File Offset: 0x000B91BC
		public virtual vtkProperty GetSelectedOutlineProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBoxRepresentation.vtkBoxRepresentation_GetSelectedOutlineProperty_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600829D RID: 33437
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkBoxRepresentation_GetSnapToAxes_21(HandleRef pThis);

		/// <summary>
		/// For complex events should we snap orientations to
		/// be aligned with the x y z axes
		/// </summary>
		// Token: 0x0600829E RID: 33438 RVA: 0x000BB02C File Offset: 0x000B922C
		public virtual bool GetSnapToAxes()
		{
			return vtkBoxRepresentation.vtkBoxRepresentation_GetSnapToAxes_21(base.GetCppThis()) != 0;
		}

		// Token: 0x0600829F RID: 33439
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxRepresentation_GetTransform_22(HandleRef pThis, HandleRef t);

		/// <summary>
		/// Retrieve a linear transform characterizing the transformation of the
		/// box. Note that the transformation is relative to where PlaceWidget()
		/// was initially called. This method modifies the transform provided. The
		/// transform can be used to control the position of vtkProp3D's, as well as
		/// other transformation operations (e.g., vtkTransformPolyData).
		/// </summary>
		// Token: 0x060082A0 RID: 33440 RVA: 0x000BB054 File Offset: 0x000B9254
		public virtual void GetTransform(vtkTransform t)
		{
			vtkBoxRepresentation.vtkBoxRepresentation_GetTransform_22(base.GetCppThis(), (t == null) ? default(HandleRef) : t.GetCppThis());
		}

		// Token: 0x060082A1 RID: 33441
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBoxRepresentation_GetTranslationAxis_23(HandleRef pThis);

		/// <summary>
		/// Gets/Sets the constraint axis for translations. Returns Axis::NONE
		/// if none.
		/// </summary>
		// Token: 0x060082A2 RID: 33442 RVA: 0x000BB084 File Offset: 0x000B9284
		public virtual int GetTranslationAxis()
		{
			return vtkBoxRepresentation.vtkBoxRepresentation_GetTranslationAxis_23(base.GetCppThis());
		}

		// Token: 0x060082A3 RID: 33443
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBoxRepresentation_GetTranslationAxisMaxValue_24(HandleRef pThis);

		/// <summary>
		/// Gets/Sets the constraint axis for translations. Returns Axis::NONE
		/// if none.
		/// </summary>
		// Token: 0x060082A4 RID: 33444 RVA: 0x000BB0A4 File Offset: 0x000B92A4
		public virtual int GetTranslationAxisMaxValue()
		{
			return vtkBoxRepresentation.vtkBoxRepresentation_GetTranslationAxisMaxValue_24(base.GetCppThis());
		}

		// Token: 0x060082A5 RID: 33445
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBoxRepresentation_GetTranslationAxisMinValue_25(HandleRef pThis);

		/// <summary>
		/// Gets/Sets the constraint axis for translations. Returns Axis::NONE
		/// if none.
		/// </summary>
		// Token: 0x060082A6 RID: 33446 RVA: 0x000BB0C4 File Offset: 0x000B92C4
		public virtual int GetTranslationAxisMinValue()
		{
			return vtkBoxRepresentation.vtkBoxRepresentation_GetTranslationAxisMinValue_25(base.GetCppThis());
		}

		// Token: 0x060082A7 RID: 33447
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkBoxRepresentation_GetTwoPlaneMode_26(HandleRef pThis);

		/// <summary>
		/// In two plane mode only the X planes are shown
		/// this is useful for defining thick slabs
		/// </summary>
		// Token: 0x060082A8 RID: 33448 RVA: 0x000BB0E4 File Offset: 0x000B92E4
		public virtual bool GetTwoPlaneMode()
		{
			return vtkBoxRepresentation.vtkBoxRepresentation_GetTwoPlaneMode_26(base.GetCppThis()) != 0;
		}

		// Token: 0x060082A9 RID: 33449
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBoxRepresentation_GetUnderlyingPlane_27(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the planes describing the implicit function defined by the box
		/// widget. The user must provide the instance of the class vtkPlanes. Note
		/// that vtkPlanes is a subclass of vtkImplicitFunction, meaning that it can
		/// be used by a variety of filters to perform clipping, cutting, and
		/// selection of data.  (The direction of the normals of the planes can be
		/// reversed enabling the InsideOut flag.)
		/// </summary>
		// Token: 0x060082AA RID: 33450 RVA: 0x000BB10C File Offset: 0x000B930C
		public vtkPlane GetUnderlyingPlane(int i)
		{
			vtkPlane vtkPlane = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBoxRepresentation.vtkBoxRepresentation_GetUnderlyingPlane_27(base.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlane = (vtkPlane)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlane.Register(null);
				}
			}
			return vtkPlane;
		}

		// Token: 0x060082AB RID: 33451
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxRepresentation_HandlesOff_28(HandleRef pThis);

		/// <summary>
		/// Switches handles (the spheres) on or off by manipulating the underlying
		/// actor visibility.
		/// </summary>
		// Token: 0x060082AC RID: 33452 RVA: 0x000BB17C File Offset: 0x000B937C
		public virtual void HandlesOff()
		{
			vtkBoxRepresentation.vtkBoxRepresentation_HandlesOff_28(base.GetCppThis());
		}

		// Token: 0x060082AD RID: 33453
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxRepresentation_HandlesOn_29(HandleRef pThis);

		/// <summary>
		/// Switches handles (the spheres) on or off by manipulating the underlying
		/// actor visibility.
		/// </summary>
		// Token: 0x060082AE RID: 33454 RVA: 0x000BB18B File Offset: 0x000B938B
		public virtual void HandlesOn()
		{
			vtkBoxRepresentation.vtkBoxRepresentation_HandlesOn_29(base.GetCppThis());
		}

		// Token: 0x060082AF RID: 33455
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBoxRepresentation_HasTranslucentPolygonalGeometry_30(HandleRef pThis);

		/// <summary>
		/// Methods supporting, and required by, the rendering process.
		/// </summary>
		// Token: 0x060082B0 RID: 33456 RVA: 0x000BB19C File Offset: 0x000B939C
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkBoxRepresentation.vtkBoxRepresentation_HasTranslucentPolygonalGeometry_30(base.GetCppThis());
		}

		// Token: 0x060082B1 RID: 33457
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxRepresentation_InsideOutOff_31(HandleRef pThis);

		/// <summary>
		/// Set/Get the InsideOut flag. This data member is used in conjunction
		/// with the GetPlanes() method. When off, the normals point out of the
		/// box. When on, the normals point into the hexahedron.  InsideOut is off
		/// by default.
		/// </summary>
		// Token: 0x060082B2 RID: 33458 RVA: 0x000BB1BB File Offset: 0x000B93BB
		public virtual void InsideOutOff()
		{
			vtkBoxRepresentation.vtkBoxRepresentation_InsideOutOff_31(base.GetCppThis());
		}

		// Token: 0x060082B3 RID: 33459
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxRepresentation_InsideOutOn_32(HandleRef pThis);

		/// <summary>
		/// Set/Get the InsideOut flag. This data member is used in conjunction
		/// with the GetPlanes() method. When off, the normals point out of the
		/// box. When on, the normals point into the hexahedron.  InsideOut is off
		/// by default.
		/// </summary>
		// Token: 0x060082B4 RID: 33460 RVA: 0x000BB1CA File Offset: 0x000B93CA
		public virtual void InsideOutOn()
		{
			vtkBoxRepresentation.vtkBoxRepresentation_InsideOutOn_32(base.GetCppThis());
		}

		// Token: 0x060082B5 RID: 33461
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBoxRepresentation_IsA_33(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x060082B6 RID: 33462 RVA: 0x000BB1DC File Offset: 0x000B93DC
		public override int IsA(string type)
		{
			return vtkBoxRepresentation.vtkBoxRepresentation_IsA_33(base.GetCppThis(), type);
		}

		// Token: 0x060082B7 RID: 33463
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkBoxRepresentation_IsTranslationConstrained_34(HandleRef pThis);

		/// <summary>
		/// Returns true if ConstrainedAxis
		/// </summary>
		// Token: 0x060082B8 RID: 33464 RVA: 0x000BB1FC File Offset: 0x000B93FC
		public bool IsTranslationConstrained()
		{
			return vtkBoxRepresentation.vtkBoxRepresentation_IsTranslationConstrained_34(base.GetCppThis()) != 0;
		}

		// Token: 0x060082B9 RID: 33465
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBoxRepresentation_IsTypeOf_35([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x060082BA RID: 33466 RVA: 0x000BB224 File Offset: 0x000B9424
		public new static int IsTypeOf(string type)
		{
			return vtkBoxRepresentation.vtkBoxRepresentation_IsTypeOf_35(type);
		}

		// Token: 0x060082BB RID: 33467
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBoxRepresentation_NewInstance_37(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x060082BC RID: 33468 RVA: 0x000BB240 File Offset: 0x000B9440
		public new vtkBoxRepresentation NewInstance()
		{
			vtkBoxRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBoxRepresentation.vtkBoxRepresentation_NewInstance_37(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBoxRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060082BD RID: 33469
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxRepresentation_OutlineCursorWiresOff_38(HandleRef pThis);

		/// <summary>
		/// Control the representation of the outline. This flag enables
		/// the cursor lines running between the handles. By default cursor
		/// wires are on.
		/// </summary>
		// Token: 0x060082BE RID: 33470 RVA: 0x000BB29A File Offset: 0x000B949A
		public void OutlineCursorWiresOff()
		{
			vtkBoxRepresentation.vtkBoxRepresentation_OutlineCursorWiresOff_38(base.GetCppThis());
		}

		// Token: 0x060082BF RID: 33471
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxRepresentation_OutlineCursorWiresOn_39(HandleRef pThis);

		/// <summary>
		/// Control the representation of the outline. This flag enables
		/// the cursor lines running between the handles. By default cursor
		/// wires are on.
		/// </summary>
		// Token: 0x060082C0 RID: 33472 RVA: 0x000BB2A9 File Offset: 0x000B94A9
		public void OutlineCursorWiresOn()
		{
			vtkBoxRepresentation.vtkBoxRepresentation_OutlineCursorWiresOn_39(base.GetCppThis());
		}

		// Token: 0x060082C1 RID: 33473
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxRepresentation_OutlineFaceWiresOff_40(HandleRef pThis);

		/// <summary>
		/// Control the representation of the outline. This flag enables
		/// face wires. By default face wires are off.
		/// </summary>
		// Token: 0x060082C2 RID: 33474 RVA: 0x000BB2B8 File Offset: 0x000B94B8
		public void OutlineFaceWiresOff()
		{
			vtkBoxRepresentation.vtkBoxRepresentation_OutlineFaceWiresOff_40(base.GetCppThis());
		}

		// Token: 0x060082C3 RID: 33475
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxRepresentation_OutlineFaceWiresOn_41(HandleRef pThis);

		/// <summary>
		/// Control the representation of the outline. This flag enables
		/// face wires. By default face wires are off.
		/// </summary>
		// Token: 0x060082C4 RID: 33476 RVA: 0x000BB2C7 File Offset: 0x000B94C7
		public void OutlineFaceWiresOn()
		{
			vtkBoxRepresentation.vtkBoxRepresentation_OutlineFaceWiresOn_41(base.GetCppThis());
		}

		// Token: 0x060082C5 RID: 33477
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxRepresentation_PlaceWidget_42(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x060082C6 RID: 33478 RVA: 0x000BB2D6 File Offset: 0x000B94D6
		public override void PlaceWidget(IntPtr bounds)
		{
			vtkBoxRepresentation.vtkBoxRepresentation_PlaceWidget_42(base.GetCppThis(), bounds);
		}

		// Token: 0x060082C7 RID: 33479
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxRepresentation_RegisterPickers_43(HandleRef pThis);

		/// <summary>
		/// For complex events should we snap orientations to
		/// be aligned with the x y z axes
		/// </summary>
		// Token: 0x060082C8 RID: 33480 RVA: 0x000BB2E6 File Offset: 0x000B94E6
		public override void RegisterPickers()
		{
			vtkBoxRepresentation.vtkBoxRepresentation_RegisterPickers_43(base.GetCppThis());
		}

		// Token: 0x060082C9 RID: 33481
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxRepresentation_ReleaseGraphicsResources_44(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods supporting, and required by, the rendering process.
		/// </summary>
		// Token: 0x060082CA RID: 33482 RVA: 0x000BB2F8 File Offset: 0x000B94F8
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkBoxRepresentation.vtkBoxRepresentation_ReleaseGraphicsResources_44(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060082CB RID: 33483
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBoxRepresentation_RenderOpaqueGeometry_45(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods supporting, and required by, the rendering process.
		/// </summary>
		// Token: 0x060082CC RID: 33484 RVA: 0x000BB328 File Offset: 0x000B9528
		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkBoxRepresentation.vtkBoxRepresentation_RenderOpaqueGeometry_45(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060082CD RID: 33485
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBoxRepresentation_RenderTranslucentPolygonalGeometry_46(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods supporting, and required by, the rendering process.
		/// </summary>
		// Token: 0x060082CE RID: 33486 RVA: 0x000BB35C File Offset: 0x000B955C
		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkBoxRepresentation.vtkBoxRepresentation_RenderTranslucentPolygonalGeometry_46(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060082CF RID: 33487
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBoxRepresentation_SafeDownCast_47(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x060082D0 RID: 33488 RVA: 0x000BB390 File Offset: 0x000B9590
		public new static vtkBoxRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkBoxRepresentation vtkBoxRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBoxRepresentation.vtkBoxRepresentation_SafeDownCast_47((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBoxRepresentation = (vtkBoxRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBoxRepresentation.Register(null);
				}
			}
			return vtkBoxRepresentation;
		}

		// Token: 0x060082D1 RID: 33489
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxRepresentation_SetForegroundColor_48(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set the foreground color (the outline of the box).
		/// </summary>
		// Token: 0x060082D2 RID: 33490 RVA: 0x000BB40F File Offset: 0x000B960F
		public void SetForegroundColor(double _arg1, double _arg2, double _arg3)
		{
			vtkBoxRepresentation.vtkBoxRepresentation_SetForegroundColor_48(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x060082D3 RID: 33491
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxRepresentation_SetForegroundColor_49(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the foreground color (the outline of the box).
		/// </summary>
		// Token: 0x060082D4 RID: 33492 RVA: 0x000BB421 File Offset: 0x000B9621
		public void SetForegroundColor(IntPtr _arg)
		{
			vtkBoxRepresentation.vtkBoxRepresentation_SetForegroundColor_49(base.GetCppThis(), _arg);
		}

		// Token: 0x060082D5 RID: 33493
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxRepresentation_SetInsideOut_50(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the InsideOut flag. This data member is used in conjunction
		/// with the GetPlanes() method. When off, the normals point out of the
		/// box. When on, the normals point into the hexahedron.  InsideOut is off
		/// by default.
		/// </summary>
		// Token: 0x060082D6 RID: 33494 RVA: 0x000BB431 File Offset: 0x000B9631
		public virtual void SetInsideOut(int _arg)
		{
			vtkBoxRepresentation.vtkBoxRepresentation_SetInsideOut_50(base.GetCppThis(), _arg);
		}

		// Token: 0x060082D7 RID: 33495
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxRepresentation_SetInteractionColor_51(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set the interaction color. Applies to the handle and outline
		/// when interaction is happening.
		/// </summary>
		// Token: 0x060082D8 RID: 33496 RVA: 0x000BB441 File Offset: 0x000B9641
		public void SetInteractionColor(double _arg1, double _arg2, double _arg3)
		{
			vtkBoxRepresentation.vtkBoxRepresentation_SetInteractionColor_51(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x060082D9 RID: 33497
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxRepresentation_SetInteractionColor_52(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the interaction color. Applies to the handle and outline
		/// when interaction is happening.
		/// </summary>
		// Token: 0x060082DA RID: 33498 RVA: 0x000BB453 File Offset: 0x000B9653
		public void SetInteractionColor(IntPtr _arg)
		{
			vtkBoxRepresentation.vtkBoxRepresentation_SetInteractionColor_52(base.GetCppThis(), _arg);
		}

		// Token: 0x060082DB RID: 33499
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxRepresentation_SetInteractionState_53(HandleRef pThis, int state);

		/// <summary>
		/// The interaction state may be set from a widget (e.g., vtkBoxWidget2) or
		/// other object. This controls how the interaction with the widget
		/// proceeds. Normally this method is used as part of a handshaking
		/// process with the widget: First ComputeInteractionState() is invoked that
		/// returns a state based on geometric considerations (i.e., cursor near a
		/// widget feature), then based on events, the widget may modify this
		/// further.
		/// </summary>
		// Token: 0x060082DC RID: 33500 RVA: 0x000BB463 File Offset: 0x000B9663
		public void SetInteractionState(int state)
		{
			vtkBoxRepresentation.vtkBoxRepresentation_SetInteractionState_53(base.GetCppThis(), state);
		}

		// Token: 0x060082DD RID: 33501
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxRepresentation_SetOutlineCursorWires_54(HandleRef pThis, int arg0);

		/// <summary>
		/// Control the representation of the outline. This flag enables
		/// the cursor lines running between the handles. By default cursor
		/// wires are on.
		/// </summary>
		// Token: 0x060082DE RID: 33502 RVA: 0x000BB473 File Offset: 0x000B9673
		public void SetOutlineCursorWires(int arg0)
		{
			vtkBoxRepresentation.vtkBoxRepresentation_SetOutlineCursorWires_54(base.GetCppThis(), arg0);
		}

		// Token: 0x060082DF RID: 33503
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxRepresentation_SetOutlineFaceWires_55(HandleRef pThis, int arg0);

		/// <summary>
		/// Control the representation of the outline. This flag enables
		/// face wires. By default face wires are off.
		/// </summary>
		// Token: 0x060082E0 RID: 33504 RVA: 0x000BB483 File Offset: 0x000B9683
		public void SetOutlineFaceWires(int arg0)
		{
			vtkBoxRepresentation.vtkBoxRepresentation_SetOutlineFaceWires_55(base.GetCppThis(), arg0);
		}

		// Token: 0x060082E1 RID: 33505
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxRepresentation_SetSnapToAxes_56(HandleRef pThis, byte _arg);

		/// <summary>
		/// For complex events should we snap orientations to
		/// be aligned with the x y z axes
		/// </summary>
		// Token: 0x060082E2 RID: 33506 RVA: 0x000BB493 File Offset: 0x000B9693
		public virtual void SetSnapToAxes(bool _arg)
		{
			vtkBoxRepresentation.vtkBoxRepresentation_SetSnapToAxes_56(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060082E3 RID: 33507
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxRepresentation_SetTransform_57(HandleRef pThis, HandleRef t);

		/// <summary>
		/// Set the position, scale and orientation of the box widget using the
		/// transform specified. Note that the transformation is relative to
		/// where PlaceWidget() was initially called (i.e., the original bounding
		/// box).
		/// </summary>
		// Token: 0x060082E4 RID: 33508 RVA: 0x000BB4AC File Offset: 0x000B96AC
		public virtual void SetTransform(vtkTransform t)
		{
			vtkBoxRepresentation.vtkBoxRepresentation_SetTransform_57(base.GetCppThis(), (t == null) ? default(HandleRef) : t.GetCppThis());
		}

		// Token: 0x060082E5 RID: 33509
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxRepresentation_SetTranslationAxis_58(HandleRef pThis, int _arg);

		/// <summary>
		/// Gets/Sets the constraint axis for translations. Returns Axis::NONE
		/// if none.
		/// </summary>
		// Token: 0x060082E6 RID: 33510 RVA: 0x000BB4DB File Offset: 0x000B96DB
		public virtual void SetTranslationAxis(int _arg)
		{
			vtkBoxRepresentation.vtkBoxRepresentation_SetTranslationAxis_58(base.GetCppThis(), _arg);
		}

		// Token: 0x060082E7 RID: 33511
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxRepresentation_SetTranslationAxisOff_59(HandleRef pThis);

		/// <summary>
		/// Toggles constraint translation axis on/off.
		/// </summary>
		// Token: 0x060082E8 RID: 33512 RVA: 0x000BB4EB File Offset: 0x000B96EB
		public void SetTranslationAxisOff()
		{
			vtkBoxRepresentation.vtkBoxRepresentation_SetTranslationAxisOff_59(base.GetCppThis());
		}

		// Token: 0x060082E9 RID: 33513
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxRepresentation_SetTwoPlaneMode_60(HandleRef pThis, byte arg0);

		/// <summary>
		/// In two plane mode only the X planes are shown
		/// this is useful for defining thick slabs
		/// </summary>
		// Token: 0x060082EA RID: 33514 RVA: 0x000BB4FA File Offset: 0x000B96FA
		public void SetTwoPlaneMode(bool arg0)
		{
			vtkBoxRepresentation.vtkBoxRepresentation_SetTwoPlaneMode_60(base.GetCppThis(), arg0 ? (byte)1 : (byte)0);
		}

		// Token: 0x060082EB RID: 33515
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxRepresentation_SetXTranslationAxisOn_61(HandleRef pThis);

		/// <summary>
		/// Toggles constraint translation axis on/off.
		/// </summary>
		// Token: 0x060082EC RID: 33516 RVA: 0x000BB512 File Offset: 0x000B9712
		public void SetXTranslationAxisOn()
		{
			vtkBoxRepresentation.vtkBoxRepresentation_SetXTranslationAxisOn_61(base.GetCppThis());
		}

		// Token: 0x060082ED RID: 33517
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxRepresentation_SetYTranslationAxisOn_62(HandleRef pThis);

		/// <summary>
		/// Toggles constraint translation axis on/off.
		/// </summary>
		// Token: 0x060082EE RID: 33518 RVA: 0x000BB521 File Offset: 0x000B9721
		public void SetYTranslationAxisOn()
		{
			vtkBoxRepresentation.vtkBoxRepresentation_SetYTranslationAxisOn_62(base.GetCppThis());
		}

		// Token: 0x060082EF RID: 33519
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxRepresentation_SetZTranslationAxisOn_63(HandleRef pThis);

		/// <summary>
		/// Toggles constraint translation axis on/off.
		/// </summary>
		// Token: 0x060082F0 RID: 33520 RVA: 0x000BB530 File Offset: 0x000B9730
		public void SetZTranslationAxisOn()
		{
			vtkBoxRepresentation.vtkBoxRepresentation_SetZTranslationAxisOn_63(base.GetCppThis());
		}

		// Token: 0x060082F1 RID: 33521
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxRepresentation_StartComplexInteraction_64(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x060082F2 RID: 33522 RVA: 0x000BB540 File Offset: 0x000B9740
		public override void StartComplexInteraction(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata)
		{
			vtkBoxRepresentation.vtkBoxRepresentation_StartComplexInteraction_64(base.GetCppThis(), (iren == null) ? default(HandleRef) : iren.GetCppThis(), (widget == null) ? default(HandleRef) : widget.GetCppThis(), arg2, calldata);
		}

		// Token: 0x060082F3 RID: 33523
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxRepresentation_StartWidgetInteraction_65(HandleRef pThis, IntPtr e);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x060082F4 RID: 33524 RVA: 0x000BB587 File Offset: 0x000B9787
		public override void StartWidgetInteraction(IntPtr e)
		{
			vtkBoxRepresentation.vtkBoxRepresentation_StartWidgetInteraction_65(base.GetCppThis(), e);
		}

		// Token: 0x060082F5 RID: 33525
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxRepresentation_StepBackward_66(HandleRef pThis);

		/// <summary>
		/// For complex events should we snap orientations to
		/// be aligned with the x y z axes
		/// </summary>
		// Token: 0x060082F6 RID: 33526 RVA: 0x000BB597 File Offset: 0x000B9797
		public void StepBackward()
		{
			vtkBoxRepresentation.vtkBoxRepresentation_StepBackward_66(base.GetCppThis());
		}

		// Token: 0x060082F7 RID: 33527
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxRepresentation_StepForward_67(HandleRef pThis);

		/// <summary>
		/// For complex events should we snap orientations to
		/// be aligned with the x y z axes
		/// </summary>
		// Token: 0x060082F8 RID: 33528 RVA: 0x000BB5A6 File Offset: 0x000B97A6
		public void StepForward()
		{
			vtkBoxRepresentation.vtkBoxRepresentation_StepForward_67(base.GetCppThis());
		}

		// Token: 0x060082F9 RID: 33529
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxRepresentation_WidgetInteraction_68(HandleRef pThis, IntPtr e);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x060082FA RID: 33530 RVA: 0x000BB5B5 File Offset: 0x000B97B5
		public override void WidgetInteraction(IntPtr e)
		{
			vtkBoxRepresentation.vtkBoxRepresentation_WidgetInteraction_68(base.GetCppThis(), e);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B16 RID: 2838
		public new const string MRFullTypeName = "Kitware.VTK.vtkBoxRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B17 RID: 2839
		public new static readonly string MRClassNameKey = "class vtkBoxRepresentation";

		/// <summary>
		/// Methods supporting, and required by, the rendering process.
		/// </summary>
		// Token: 0x020002D7 RID: 727
		public enum MoveF0_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000B19 RID: 2841
			MoveF0 = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000B1A RID: 2842
			MoveF1,
			/// <summary>enum member</summary>
			// Token: 0x04000B1B RID: 2843
			MoveF2,
			/// <summary>enum member</summary>
			// Token: 0x04000B1C RID: 2844
			MoveF3,
			/// <summary>enum member</summary>
			// Token: 0x04000B1D RID: 2845
			MoveF4,
			/// <summary>enum member</summary>
			// Token: 0x04000B1E RID: 2846
			MoveF5,
			/// <summary>enum member</summary>
			// Token: 0x04000B1F RID: 2847
			Outside = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000B20 RID: 2848
			Rotating = 8,
			/// <summary>enum member</summary>
			// Token: 0x04000B21 RID: 2849
			Scaling,
			/// <summary>enum member</summary>
			// Token: 0x04000B22 RID: 2850
			Translating = 7
		}
	}
}
