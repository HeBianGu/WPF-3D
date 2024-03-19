using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTensorRepresentation
	/// </summary>
	/// <remarks>
	///    class defining a representation for the vtkTensorWidget
	///
	/// This class is a concrete representation for the vtkTensorWidget. In
	/// summary, it allows the editing of a tensor glyph (by modifying the
	/// underlying tensor value). This includes controlling the position, scaling,
	/// and rotation of the glyph. The representation is simply an oriented,
	/// scaled box which can be manipulated to transform the tensor. Optionally,
	/// an ellipsoid defined by the tensor eigenvectors can be shown for
	/// informational purposes.
	///
	/// To use this representation, specify a 3x3 real, symmetric matrix defining
	/// the tensor. (This implicitly defines an orthogonal basis from the three
	/// tensor eigenvectors.) Then use PlaceWidget() to define a bounding box: the
	/// bounding box defines a position for the tensor from its center point, and
	/// the representation is scaled to fit in the bounding box.
	///
	/// Note: typical usage is to place a tensor glyph inside of the
	/// representation (i.e., the box) which is updated as the representation is
	/// manipulated by the user. The built-in ellipsoid can be used for this;
	/// alternatively through callbacks and such, it is possible to place
	/// other glyph types such as superquadrics.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkTensorWidget vtkBoxRepresentation
	/// </seealso>
	// Token: 0x02000381 RID: 897
	public class vtkTensorRepresentation : vtkWidgetRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600A359 RID: 41817 RVA: 0x000E793F File Offset: 0x000E5B3F
		static vtkTensorRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTensorRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTensorRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600A35A RID: 41818 RVA: 0x000E7967 File Offset: 0x000E5B67
		public vtkTensorRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600A35B RID: 41819
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTensorRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600A35C RID: 41820 RVA: 0x000E7978 File Offset: 0x000E5B78
		public new static vtkTensorRepresentation New()
		{
			vtkTensorRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTensorRepresentation.vtkTensorRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTensorRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600A35D RID: 41821 RVA: 0x000E79CC File Offset: 0x000E5BCC
		public vtkTensorRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTensorRepresentation.vtkTensorRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600A35E RID: 41822 RVA: 0x000E7A10 File Offset: 0x000E5C10
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600A35F RID: 41823
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorRepresentation_BuildRepresentation_01(HandleRef pThis);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x0600A360 RID: 41824 RVA: 0x000E7A1B File Offset: 0x000E5C1B
		public override void BuildRepresentation()
		{
			vtkTensorRepresentation.vtkTensorRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		// Token: 0x0600A361 RID: 41825
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorRepresentation_ComplexInteraction_02(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x0600A362 RID: 41826 RVA: 0x000E7A2C File Offset: 0x000E5C2C
		public override void ComplexInteraction(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata)
		{
			vtkTensorRepresentation.vtkTensorRepresentation_ComplexInteraction_02(base.GetCppThis(), (iren == null) ? default(HandleRef) : iren.GetCppThis(), (widget == null) ? default(HandleRef) : widget.GetCppThis(), arg2, calldata);
		}

		// Token: 0x0600A363 RID: 41827
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTensorRepresentation_ComputeComplexInteractionState_03(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata, int modify);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x0600A364 RID: 41828 RVA: 0x000E7A74 File Offset: 0x000E5C74
		public override int ComputeComplexInteractionState(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata, int modify)
		{
			return vtkTensorRepresentation.vtkTensorRepresentation_ComputeComplexInteractionState_03(base.GetCppThis(), (iren == null) ? default(HandleRef) : iren.GetCppThis(), (widget == null) ? default(HandleRef) : widget.GetCppThis(), arg2, calldata, modify);
		}

		// Token: 0x0600A365 RID: 41829
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTensorRepresentation_ComputeInteractionState_04(HandleRef pThis, int X, int Y, int modify);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x0600A366 RID: 41830 RVA: 0x000E7AC4 File Offset: 0x000E5CC4
		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkTensorRepresentation.vtkTensorRepresentation_ComputeInteractionState_04(base.GetCppThis(), X, Y, modify);
		}

		// Token: 0x0600A367 RID: 41831
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorRepresentation_EndComplexInteraction_05(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x0600A368 RID: 41832 RVA: 0x000E7AE8 File Offset: 0x000E5CE8
		public override void EndComplexInteraction(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata)
		{
			vtkTensorRepresentation.vtkTensorRepresentation_EndComplexInteraction_05(base.GetCppThis(), (iren == null) ? default(HandleRef) : iren.GetCppThis(), (widget == null) ? default(HandleRef) : widget.GetCppThis(), arg2, calldata);
		}

		// Token: 0x0600A369 RID: 41833
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTensorRepresentation_GetBounds_06(HandleRef pThis);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x0600A36A RID: 41834 RVA: 0x000E7B30 File Offset: 0x000E5D30
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkTensorRepresentation.vtkTensorRepresentation_GetBounds_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600A36B RID: 41835
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorRepresentation_GetEigenvalues_07(HandleRef pThis, IntPtr evals);

		/// <summary>
		/// These are methods used to retrieve derived information about the tensor.
		/// Specify (0&lt;=i&lt;3) to retrieve the ith eigenvector. The eigenvalues and
		/// associated eigenvectors are sorted in decreasing order.
		/// </summary>
		// Token: 0x0600A36C RID: 41836 RVA: 0x000E7B78 File Offset: 0x000E5D78
		public void GetEigenvalues(IntPtr evals)
		{
			vtkTensorRepresentation.vtkTensorRepresentation_GetEigenvalues_07(base.GetCppThis(), evals);
		}

		// Token: 0x0600A36D RID: 41837
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorRepresentation_GetEigenvector_08(HandleRef pThis, int n, IntPtr ev);

		/// <summary>
		/// These are methods used to retrieve derived information about the tensor.
		/// Specify (0&lt;=i&lt;3) to retrieve the ith eigenvector. The eigenvalues and
		/// associated eigenvectors are sorted in decreasing order.
		/// </summary>
		// Token: 0x0600A36E RID: 41838 RVA: 0x000E7B88 File Offset: 0x000E5D88
		public void GetEigenvector(int n, IntPtr ev)
		{
			vtkTensorRepresentation.vtkTensorRepresentation_GetEigenvector_08(base.GetCppThis(), n, ev);
		}

		// Token: 0x0600A36F RID: 41839
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTensorRepresentation_GetEllipsoidProperty_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the tensor ellipsoid properties. If visibility is enabled,
		/// the ellipsoid will be rendered with this property.
		/// </summary>
		// Token: 0x0600A370 RID: 41840 RVA: 0x000E7B9C File Offset: 0x000E5D9C
		public virtual vtkProperty GetEllipsoidProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTensorRepresentation.vtkTensorRepresentation_GetEllipsoidProperty_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600A371 RID: 41841
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTensorRepresentation_GetFaceProperty_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the face properties (the faces of the box). The
		/// properties of the face when selected and normal can be
		/// set.
		/// </summary>
		// Token: 0x0600A372 RID: 41842 RVA: 0x000E7C0C File Offset: 0x000E5E0C
		public virtual vtkProperty GetFaceProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTensorRepresentation.vtkTensorRepresentation_GetFaceProperty_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600A373 RID: 41843
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTensorRepresentation_GetHandleProperty_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the handle properties (the little balls are the handles). The
		/// properties of the handles, when selected or normal, can be
		/// specified.
		/// </summary>
		// Token: 0x0600A374 RID: 41844 RVA: 0x000E7C7C File Offset: 0x000E5E7C
		public virtual vtkProperty GetHandleProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTensorRepresentation.vtkTensorRepresentation_GetHandleProperty_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600A375 RID: 41845
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTensorRepresentation_GetNumberOfGenerationsFromBase_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600A376 RID: 41846 RVA: 0x000E7CEC File Offset: 0x000E5EEC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTensorRepresentation.vtkTensorRepresentation_GetNumberOfGenerationsFromBase_12(base.GetCppThis(), type);
		}

		// Token: 0x0600A377 RID: 41847
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTensorRepresentation_GetNumberOfGenerationsFromBaseType_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600A378 RID: 41848 RVA: 0x000E7D0C File Offset: 0x000E5F0C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTensorRepresentation.vtkTensorRepresentation_GetNumberOfGenerationsFromBaseType_13(type);
		}

		// Token: 0x0600A379 RID: 41849
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTensorRepresentation_GetOutlineCursorWires_14(HandleRef pThis);

		/// <summary>
		/// Control the representation of the outline. This flag enables
		/// the cursor lines running between the handles. By default cursor
		/// wires are on.
		/// </summary>
		// Token: 0x0600A37A RID: 41850 RVA: 0x000E7D28 File Offset: 0x000E5F28
		public virtual bool GetOutlineCursorWires()
		{
			return vtkTensorRepresentation.vtkTensorRepresentation_GetOutlineCursorWires_14(base.GetCppThis()) != 0;
		}

		// Token: 0x0600A37B RID: 41851
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTensorRepresentation_GetOutlineFaceWires_15(HandleRef pThis);

		/// <summary>
		/// Control the representation of the outline. This flag enables
		/// face wires. By default face wires are off.
		/// </summary>
		// Token: 0x0600A37C RID: 41852 RVA: 0x000E7D50 File Offset: 0x000E5F50
		public virtual bool GetOutlineFaceWires()
		{
			return vtkTensorRepresentation.vtkTensorRepresentation_GetOutlineFaceWires_15(base.GetCppThis()) != 0;
		}

		// Token: 0x0600A37D RID: 41853
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTensorRepresentation_GetOutlineProperty_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the outline properties (the outline of the box). The
		/// properties of the outline when selected and normal can be
		/// set.
		/// </summary>
		// Token: 0x0600A37E RID: 41854 RVA: 0x000E7D78 File Offset: 0x000E5F78
		public virtual vtkProperty GetOutlineProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTensorRepresentation.vtkTensorRepresentation_GetOutlineProperty_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600A37F RID: 41855
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorRepresentation_GetPolyData_17(HandleRef pThis, HandleRef pd);

		/// <summary>
		/// Grab the polydata (including points) that define the representation. The
		/// polydata consists of 6 quadrilateral faces and 15 points. The first
		/// eight points define the eight corner vertices; the next six define the
		/// -x,+x, -y,+y, -z,+z face points; and the final point (the 15th out of 15
		/// points) defines the center of the box. These point values are guaranteed
		/// to be up-to-date when either the widget's corresponding InteractionEvent
		/// or EndInteractionEvent events are invoked. The user provides the
		/// vtkPolyData and the points and cells are added to it.
		/// </summary>
		// Token: 0x0600A380 RID: 41856 RVA: 0x000E7DE8 File Offset: 0x000E5FE8
		public void GetPolyData(vtkPolyData pd)
		{
			vtkTensorRepresentation.vtkTensorRepresentation_GetPolyData_17(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x0600A381 RID: 41857
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorRepresentation_GetPosition_18(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Set/Get a position for the location of the tensor. Of course a tensor
		/// inherently has no position, but this is for the purpose of placing
		/// this widget representation.
		/// </summary>
		// Token: 0x0600A382 RID: 41858 RVA: 0x000E7E17 File Offset: 0x000E6017
		public void GetPosition(IntPtr pos)
		{
			vtkTensorRepresentation.vtkTensorRepresentation_GetPosition_18(base.GetCppThis(), pos);
		}

		// Token: 0x0600A383 RID: 41859
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTensorRepresentation_GetSelectedFaceProperty_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the face properties (the faces of the box). The
		/// properties of the face when selected and normal can be
		/// set.
		/// </summary>
		// Token: 0x0600A384 RID: 41860 RVA: 0x000E7E28 File Offset: 0x000E6028
		public virtual vtkProperty GetSelectedFaceProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTensorRepresentation.vtkTensorRepresentation_GetSelectedFaceProperty_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600A385 RID: 41861
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTensorRepresentation_GetSelectedHandleProperty_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the handle properties (the little balls are the handles). The
		/// properties of the handles, when selected or normal, can be
		/// specified.
		/// </summary>
		// Token: 0x0600A386 RID: 41862 RVA: 0x000E7E98 File Offset: 0x000E6098
		public virtual vtkProperty GetSelectedHandleProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTensorRepresentation.vtkTensorRepresentation_GetSelectedHandleProperty_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600A387 RID: 41863
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTensorRepresentation_GetSelectedOutlineProperty_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the outline properties (the outline of the box). The
		/// properties of the outline when selected and normal can be
		/// set.
		/// </summary>
		// Token: 0x0600A388 RID: 41864 RVA: 0x000E7F08 File Offset: 0x000E6108
		public virtual vtkProperty GetSelectedOutlineProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTensorRepresentation.vtkTensorRepresentation_GetSelectedOutlineProperty_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600A389 RID: 41865
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTensorRepresentation_GetSnapToAxes_22(HandleRef pThis);

		/// <summary>
		/// For complex events should we snap orientations to
		/// be aligned with the x y z axes
		/// </summary>
		// Token: 0x0600A38A RID: 41866 RVA: 0x000E7F78 File Offset: 0x000E6178
		public virtual bool GetSnapToAxes()
		{
			return vtkTensorRepresentation.vtkTensorRepresentation_GetSnapToAxes_22(base.GetCppThis()) != 0;
		}

		// Token: 0x0600A38B RID: 41867
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorRepresentation_GetSymmetricTensor_23(HandleRef pThis, IntPtr symTensor);

		/// <summary>
		/// These are the basic methods used to define the tensor (these methods
		/// coordinate with the overloaded PlaceWidget() method). The methods enable
		/// specification of a 3x3 symmetric tensor. This information is used to
		/// construct an oriented, appropriately ellipsoid that is (initially)
		/// centered and fits inside the bounding box defined by PlaceWidget(). As
		/// this widget is modified during user interaction, the tensor data member
		/// is continuously updated and can be queried. Note that a symmetric tensor
		/// can be defined with only six components. If a full 3x3 tensor is
		/// specified, only the symmetrical part of the tensor is used since the
		/// extracted eigenvalues/eigenvecters are required to be real valued. When
		/// a tensor is specified, the derived information (e.g.,
		/// eigenvalues/vectors and position) are immediately updated.
		/// </summary>
		// Token: 0x0600A38C RID: 41868 RVA: 0x000E7F9E File Offset: 0x000E619E
		public void GetSymmetricTensor(IntPtr symTensor)
		{
			vtkTensorRepresentation.vtkTensorRepresentation_GetSymmetricTensor_23(base.GetCppThis(), symTensor);
		}

		// Token: 0x0600A38D RID: 41869
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorRepresentation_GetTensor_24(HandleRef pThis, IntPtr tensor);

		/// <summary>
		/// These are the basic methods used to define the tensor (these methods
		/// coordinate with the overloaded PlaceWidget() method). The methods enable
		/// specification of a 3x3 symmetric tensor. This information is used to
		/// construct an oriented, appropriately ellipsoid that is (initially)
		/// centered and fits inside the bounding box defined by PlaceWidget(). As
		/// this widget is modified during user interaction, the tensor data member
		/// is continuously updated and can be queried. Note that a symmetric tensor
		/// can be defined with only six components. If a full 3x3 tensor is
		/// specified, only the symmetrical part of the tensor is used since the
		/// extracted eigenvalues/eigenvecters are required to be real valued. When
		/// a tensor is specified, the derived information (e.g.,
		/// eigenvalues/vectors and position) are immediately updated.
		/// </summary>
		// Token: 0x0600A38E RID: 41870 RVA: 0x000E7FAE File Offset: 0x000E61AE
		public void GetTensor(IntPtr tensor)
		{
			vtkTensorRepresentation.vtkTensorRepresentation_GetTensor_24(base.GetCppThis(), tensor);
		}

		// Token: 0x0600A38F RID: 41871
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTensorRepresentation_GetTensorEllipsoid_25(HandleRef pThis);

		/// <summary>
		/// Indicate whether to show the tensor ellipsoid. By default it is on.
		/// </summary>
		// Token: 0x0600A390 RID: 41872 RVA: 0x000E7FC0 File Offset: 0x000E61C0
		public virtual bool GetTensorEllipsoid()
		{
			return vtkTensorRepresentation.vtkTensorRepresentation_GetTensorEllipsoid_25(base.GetCppThis()) != 0;
		}

		// Token: 0x0600A391 RID: 41873
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTensorRepresentation_GetTranslationAxis_26(HandleRef pThis);

		/// <summary>
		/// Gets/Sets the constraint axis for translations. Returns Axis::NONE
		/// if none.
		/// </summary>
		// Token: 0x0600A392 RID: 41874 RVA: 0x000E7FE8 File Offset: 0x000E61E8
		public virtual int GetTranslationAxis()
		{
			return vtkTensorRepresentation.vtkTensorRepresentation_GetTranslationAxis_26(base.GetCppThis());
		}

		// Token: 0x0600A393 RID: 41875
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTensorRepresentation_GetTranslationAxisMaxValue_27(HandleRef pThis);

		/// <summary>
		/// Gets/Sets the constraint axis for translations. Returns Axis::NONE
		/// if none.
		/// </summary>
		// Token: 0x0600A394 RID: 41876 RVA: 0x000E8008 File Offset: 0x000E6208
		public virtual int GetTranslationAxisMaxValue()
		{
			return vtkTensorRepresentation.vtkTensorRepresentation_GetTranslationAxisMaxValue_27(base.GetCppThis());
		}

		// Token: 0x0600A395 RID: 41877
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTensorRepresentation_GetTranslationAxisMinValue_28(HandleRef pThis);

		/// <summary>
		/// Gets/Sets the constraint axis for translations. Returns Axis::NONE
		/// if none.
		/// </summary>
		// Token: 0x0600A396 RID: 41878 RVA: 0x000E8028 File Offset: 0x000E6228
		public virtual int GetTranslationAxisMinValue()
		{
			return vtkTensorRepresentation.vtkTensorRepresentation_GetTranslationAxisMinValue_28(base.GetCppThis());
		}

		// Token: 0x0600A397 RID: 41879
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorRepresentation_HandlesOff_29(HandleRef pThis);

		/// <summary>
		/// Switches handles (the spheres) on or off by manipulating the underlying
		/// actor visibility.
		/// </summary>
		// Token: 0x0600A398 RID: 41880 RVA: 0x000E8047 File Offset: 0x000E6247
		public virtual void HandlesOff()
		{
			vtkTensorRepresentation.vtkTensorRepresentation_HandlesOff_29(base.GetCppThis());
		}

		// Token: 0x0600A399 RID: 41881
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorRepresentation_HandlesOn_30(HandleRef pThis);

		/// <summary>
		/// Switches handles (the spheres) on or off by manipulating the underlying
		/// actor visibility.
		/// </summary>
		// Token: 0x0600A39A RID: 41882 RVA: 0x000E8056 File Offset: 0x000E6256
		public virtual void HandlesOn()
		{
			vtkTensorRepresentation.vtkTensorRepresentation_HandlesOn_30(base.GetCppThis());
		}

		// Token: 0x0600A39B RID: 41883
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTensorRepresentation_HasTranslucentPolygonalGeometry_31(HandleRef pThis);

		/// <summary>
		/// Methods supporting, and required by, the rendering process.
		/// </summary>
		// Token: 0x0600A39C RID: 41884 RVA: 0x000E8068 File Offset: 0x000E6268
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkTensorRepresentation.vtkTensorRepresentation_HasTranslucentPolygonalGeometry_31(base.GetCppThis());
		}

		// Token: 0x0600A39D RID: 41885
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTensorRepresentation_IsA_32(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600A39E RID: 41886 RVA: 0x000E8088 File Offset: 0x000E6288
		public override int IsA(string type)
		{
			return vtkTensorRepresentation.vtkTensorRepresentation_IsA_32(base.GetCppThis(), type);
		}

		// Token: 0x0600A39F RID: 41887
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTensorRepresentation_IsTranslationConstrained_33(HandleRef pThis);

		/// <summary>
		/// Returns true if ConstrainedAxis
		/// </summary>
		// Token: 0x0600A3A0 RID: 41888 RVA: 0x000E80A8 File Offset: 0x000E62A8
		public bool IsTranslationConstrained()
		{
			return vtkTensorRepresentation.vtkTensorRepresentation_IsTranslationConstrained_33(base.GetCppThis()) != 0;
		}

		// Token: 0x0600A3A1 RID: 41889
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTensorRepresentation_IsTypeOf_34([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600A3A2 RID: 41890 RVA: 0x000E80D0 File Offset: 0x000E62D0
		public new static int IsTypeOf(string type)
		{
			return vtkTensorRepresentation.vtkTensorRepresentation_IsTypeOf_34(type);
		}

		// Token: 0x0600A3A3 RID: 41891
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTensorRepresentation_NewInstance_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600A3A4 RID: 41892 RVA: 0x000E80EC File Offset: 0x000E62EC
		public new vtkTensorRepresentation NewInstance()
		{
			vtkTensorRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTensorRepresentation.vtkTensorRepresentation_NewInstance_36(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTensorRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600A3A5 RID: 41893
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorRepresentation_OutlineCursorWiresOff_37(HandleRef pThis);

		/// <summary>
		/// Control the representation of the outline. This flag enables
		/// the cursor lines running between the handles. By default cursor
		/// wires are on.
		/// </summary>
		// Token: 0x0600A3A6 RID: 41894 RVA: 0x000E8146 File Offset: 0x000E6346
		public void OutlineCursorWiresOff()
		{
			vtkTensorRepresentation.vtkTensorRepresentation_OutlineCursorWiresOff_37(base.GetCppThis());
		}

		// Token: 0x0600A3A7 RID: 41895
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorRepresentation_OutlineCursorWiresOn_38(HandleRef pThis);

		/// <summary>
		/// Control the representation of the outline. This flag enables
		/// the cursor lines running between the handles. By default cursor
		/// wires are on.
		/// </summary>
		// Token: 0x0600A3A8 RID: 41896 RVA: 0x000E8155 File Offset: 0x000E6355
		public void OutlineCursorWiresOn()
		{
			vtkTensorRepresentation.vtkTensorRepresentation_OutlineCursorWiresOn_38(base.GetCppThis());
		}

		// Token: 0x0600A3A9 RID: 41897
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorRepresentation_OutlineFaceWiresOff_39(HandleRef pThis);

		/// <summary>
		/// Control the representation of the outline. This flag enables
		/// face wires. By default face wires are off.
		/// </summary>
		// Token: 0x0600A3AA RID: 41898 RVA: 0x000E8164 File Offset: 0x000E6364
		public void OutlineFaceWiresOff()
		{
			vtkTensorRepresentation.vtkTensorRepresentation_OutlineFaceWiresOff_39(base.GetCppThis());
		}

		// Token: 0x0600A3AB RID: 41899
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorRepresentation_OutlineFaceWiresOn_40(HandleRef pThis);

		/// <summary>
		/// Control the representation of the outline. This flag enables
		/// face wires. By default face wires are off.
		/// </summary>
		// Token: 0x0600A3AC RID: 41900 RVA: 0x000E8173 File Offset: 0x000E6373
		public void OutlineFaceWiresOn()
		{
			vtkTensorRepresentation.vtkTensorRepresentation_OutlineFaceWiresOn_40(base.GetCppThis());
		}

		// Token: 0x0600A3AD RID: 41901
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorRepresentation_PlaceTensor_41(HandleRef pThis, IntPtr tensor, IntPtr position);

		/// <summary>
		/// This is a specialized place widget method for a tensor. Specify the
		/// tensor (an array of 9 components) and the position to place the tensor.
		/// Note that the PlaceFactor (defined in superclass) can be used to
		/// scale the representation when placed.
		/// </summary>
		// Token: 0x0600A3AE RID: 41902 RVA: 0x000E8182 File Offset: 0x000E6382
		public void PlaceTensor(IntPtr tensor, IntPtr position)
		{
			vtkTensorRepresentation.vtkTensorRepresentation_PlaceTensor_41(base.GetCppThis(), tensor, position);
		}

		// Token: 0x0600A3AF RID: 41903
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorRepresentation_PlaceWidget_42(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x0600A3B0 RID: 41904 RVA: 0x000E8193 File Offset: 0x000E6393
		public override void PlaceWidget(IntPtr bounds)
		{
			vtkTensorRepresentation.vtkTensorRepresentation_PlaceWidget_42(base.GetCppThis(), bounds);
		}

		// Token: 0x0600A3B1 RID: 41905
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorRepresentation_RegisterPickers_43(HandleRef pThis);

		/// <summary>
		/// For complex events should we snap orientations to
		/// be aligned with the x y z axes
		/// </summary>
		// Token: 0x0600A3B2 RID: 41906 RVA: 0x000E81A3 File Offset: 0x000E63A3
		public override void RegisterPickers()
		{
			vtkTensorRepresentation.vtkTensorRepresentation_RegisterPickers_43(base.GetCppThis());
		}

		// Token: 0x0600A3B3 RID: 41907
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorRepresentation_ReleaseGraphicsResources_44(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods supporting, and required by, the rendering process.
		/// </summary>
		// Token: 0x0600A3B4 RID: 41908 RVA: 0x000E81B4 File Offset: 0x000E63B4
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkTensorRepresentation.vtkTensorRepresentation_ReleaseGraphicsResources_44(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600A3B5 RID: 41909
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTensorRepresentation_RenderOpaqueGeometry_45(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods supporting, and required by, the rendering process.
		/// </summary>
		// Token: 0x0600A3B6 RID: 41910 RVA: 0x000E81E4 File Offset: 0x000E63E4
		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkTensorRepresentation.vtkTensorRepresentation_RenderOpaqueGeometry_45(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600A3B7 RID: 41911
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTensorRepresentation_RenderTranslucentPolygonalGeometry_46(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods supporting, and required by, the rendering process.
		/// </summary>
		// Token: 0x0600A3B8 RID: 41912 RVA: 0x000E8218 File Offset: 0x000E6418
		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkTensorRepresentation.vtkTensorRepresentation_RenderTranslucentPolygonalGeometry_46(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600A3B9 RID: 41913
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTensorRepresentation_SafeDownCast_47(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600A3BA RID: 41914 RVA: 0x000E824C File Offset: 0x000E644C
		public new static vtkTensorRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkTensorRepresentation vtkTensorRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTensorRepresentation.vtkTensorRepresentation_SafeDownCast_47((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTensorRepresentation = (vtkTensorRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTensorRepresentation.Register(null);
				}
			}
			return vtkTensorRepresentation;
		}

		// Token: 0x0600A3BB RID: 41915
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorRepresentation_SetInteractionState_48(HandleRef pThis, int state);

		/// <summary>
		/// The interaction state may be set from a widget (e.g., vtkTensorWidget) or
		/// other object. This controls how the interaction with the widget
		/// proceeds. Normally this method is used as part of a handshaking
		/// process with the widget: First ComputeInteractionState() is invoked that
		/// returns a state based on geometric considerations (i.e., cursor near a
		/// widget feature), then based on events, the widget may modify this
		/// further.
		/// </summary>
		// Token: 0x0600A3BC RID: 41916 RVA: 0x000E82CB File Offset: 0x000E64CB
		public void SetInteractionState(int state)
		{
			vtkTensorRepresentation.vtkTensorRepresentation_SetInteractionState_48(base.GetCppThis(), state);
		}

		// Token: 0x0600A3BD RID: 41917
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorRepresentation_SetOutlineCursorWires_49(HandleRef pThis, byte arg0);

		/// <summary>
		/// Control the representation of the outline. This flag enables
		/// the cursor lines running between the handles. By default cursor
		/// wires are on.
		/// </summary>
		// Token: 0x0600A3BE RID: 41918 RVA: 0x000E82DB File Offset: 0x000E64DB
		public void SetOutlineCursorWires(bool arg0)
		{
			vtkTensorRepresentation.vtkTensorRepresentation_SetOutlineCursorWires_49(base.GetCppThis(), arg0 ? (byte)1 : (byte)0);
		}

		// Token: 0x0600A3BF RID: 41919
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorRepresentation_SetOutlineFaceWires_50(HandleRef pThis, byte arg0);

		/// <summary>
		/// Control the representation of the outline. This flag enables
		/// face wires. By default face wires are off.
		/// </summary>
		// Token: 0x0600A3C0 RID: 41920 RVA: 0x000E82F3 File Offset: 0x000E64F3
		public void SetOutlineFaceWires(bool arg0)
		{
			vtkTensorRepresentation.vtkTensorRepresentation_SetOutlineFaceWires_50(base.GetCppThis(), arg0 ? (byte)1 : (byte)0);
		}

		// Token: 0x0600A3C1 RID: 41921
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorRepresentation_SetPosition_51(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Set/Get a position for the location of the tensor. Of course a tensor
		/// inherently has no position, but this is for the purpose of placing
		/// this widget representation.
		/// </summary>
		// Token: 0x0600A3C2 RID: 41922 RVA: 0x000E830B File Offset: 0x000E650B
		public void SetPosition(IntPtr pos)
		{
			vtkTensorRepresentation.vtkTensorRepresentation_SetPosition_51(base.GetCppThis(), pos);
		}

		// Token: 0x0600A3C3 RID: 41923
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorRepresentation_SetSnapToAxes_52(HandleRef pThis, byte _arg);

		/// <summary>
		/// For complex events should we snap orientations to
		/// be aligned with the x y z axes
		/// </summary>
		// Token: 0x0600A3C4 RID: 41924 RVA: 0x000E831B File Offset: 0x000E651B
		public virtual void SetSnapToAxes(bool _arg)
		{
			vtkTensorRepresentation.vtkTensorRepresentation_SetSnapToAxes_52(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600A3C5 RID: 41925
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorRepresentation_SetSymmetricTensor_53(HandleRef pThis, IntPtr symTensor);

		/// <summary>
		/// These are the basic methods used to define the tensor (these methods
		/// coordinate with the overloaded PlaceWidget() method). The methods enable
		/// specification of a 3x3 symmetric tensor. This information is used to
		/// construct an oriented, appropriately ellipsoid that is (initially)
		/// centered and fits inside the bounding box defined by PlaceWidget(). As
		/// this widget is modified during user interaction, the tensor data member
		/// is continuously updated and can be queried. Note that a symmetric tensor
		/// can be defined with only six components. If a full 3x3 tensor is
		/// specified, only the symmetrical part of the tensor is used since the
		/// extracted eigenvalues/eigenvecters are required to be real valued. When
		/// a tensor is specified, the derived information (e.g.,
		/// eigenvalues/vectors and position) are immediately updated.
		/// </summary>
		// Token: 0x0600A3C6 RID: 41926 RVA: 0x000E8333 File Offset: 0x000E6533
		public void SetSymmetricTensor(IntPtr symTensor)
		{
			vtkTensorRepresentation.vtkTensorRepresentation_SetSymmetricTensor_53(base.GetCppThis(), symTensor);
		}

		// Token: 0x0600A3C7 RID: 41927
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorRepresentation_SetTensor_54(HandleRef pThis, IntPtr tensor);

		/// <summary>
		/// These are the basic methods used to define the tensor (these methods
		/// coordinate with the overloaded PlaceWidget() method). The methods enable
		/// specification of a 3x3 symmetric tensor. This information is used to
		/// construct an oriented, appropriately ellipsoid that is (initially)
		/// centered and fits inside the bounding box defined by PlaceWidget(). As
		/// this widget is modified during user interaction, the tensor data member
		/// is continuously updated and can be queried. Note that a symmetric tensor
		/// can be defined with only six components. If a full 3x3 tensor is
		/// specified, only the symmetrical part of the tensor is used since the
		/// extracted eigenvalues/eigenvecters are required to be real valued. When
		/// a tensor is specified, the derived information (e.g.,
		/// eigenvalues/vectors and position) are immediately updated.
		/// </summary>
		// Token: 0x0600A3C8 RID: 41928 RVA: 0x000E8343 File Offset: 0x000E6543
		public void SetTensor(IntPtr tensor)
		{
			vtkTensorRepresentation.vtkTensorRepresentation_SetTensor_54(base.GetCppThis(), tensor);
		}

		// Token: 0x0600A3C9 RID: 41929
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorRepresentation_SetTensorEllipsoid_55(HandleRef pThis, byte arg0);

		/// <summary>
		/// Indicate whether to show the tensor ellipsoid. By default it is on.
		/// </summary>
		// Token: 0x0600A3CA RID: 41930 RVA: 0x000E8353 File Offset: 0x000E6553
		public void SetTensorEllipsoid(bool arg0)
		{
			vtkTensorRepresentation.vtkTensorRepresentation_SetTensorEllipsoid_55(base.GetCppThis(), arg0 ? (byte)1 : (byte)0);
		}

		// Token: 0x0600A3CB RID: 41931
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorRepresentation_SetTranslationAxis_56(HandleRef pThis, int _arg);

		/// <summary>
		/// Gets/Sets the constraint axis for translations. Returns Axis::NONE
		/// if none.
		/// </summary>
		// Token: 0x0600A3CC RID: 41932 RVA: 0x000E836B File Offset: 0x000E656B
		public virtual void SetTranslationAxis(int _arg)
		{
			vtkTensorRepresentation.vtkTensorRepresentation_SetTranslationAxis_56(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A3CD RID: 41933
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorRepresentation_SetTranslationAxisOff_57(HandleRef pThis);

		/// <summary>
		/// Toggles constraint translation axis on/off.
		/// </summary>
		// Token: 0x0600A3CE RID: 41934 RVA: 0x000E837B File Offset: 0x000E657B
		public void SetTranslationAxisOff()
		{
			vtkTensorRepresentation.vtkTensorRepresentation_SetTranslationAxisOff_57(base.GetCppThis());
		}

		// Token: 0x0600A3CF RID: 41935
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorRepresentation_SetXTranslationAxisOn_58(HandleRef pThis);

		/// <summary>
		/// Toggles constraint translation axis on/off.
		/// </summary>
		// Token: 0x0600A3D0 RID: 41936 RVA: 0x000E838A File Offset: 0x000E658A
		public void SetXTranslationAxisOn()
		{
			vtkTensorRepresentation.vtkTensorRepresentation_SetXTranslationAxisOn_58(base.GetCppThis());
		}

		// Token: 0x0600A3D1 RID: 41937
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorRepresentation_SetYTranslationAxisOn_59(HandleRef pThis);

		/// <summary>
		/// Toggles constraint translation axis on/off.
		/// </summary>
		// Token: 0x0600A3D2 RID: 41938 RVA: 0x000E8399 File Offset: 0x000E6599
		public void SetYTranslationAxisOn()
		{
			vtkTensorRepresentation.vtkTensorRepresentation_SetYTranslationAxisOn_59(base.GetCppThis());
		}

		// Token: 0x0600A3D3 RID: 41939
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorRepresentation_SetZTranslationAxisOn_60(HandleRef pThis);

		/// <summary>
		/// Toggles constraint translation axis on/off.
		/// </summary>
		// Token: 0x0600A3D4 RID: 41940 RVA: 0x000E83A8 File Offset: 0x000E65A8
		public void SetZTranslationAxisOn()
		{
			vtkTensorRepresentation.vtkTensorRepresentation_SetZTranslationAxisOn_60(base.GetCppThis());
		}

		// Token: 0x0600A3D5 RID: 41941
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorRepresentation_StartComplexInteraction_61(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x0600A3D6 RID: 41942 RVA: 0x000E83B8 File Offset: 0x000E65B8
		public override void StartComplexInteraction(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata)
		{
			vtkTensorRepresentation.vtkTensorRepresentation_StartComplexInteraction_61(base.GetCppThis(), (iren == null) ? default(HandleRef) : iren.GetCppThis(), (widget == null) ? default(HandleRef) : widget.GetCppThis(), arg2, calldata);
		}

		// Token: 0x0600A3D7 RID: 41943
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorRepresentation_StartWidgetInteraction_62(HandleRef pThis, IntPtr e);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x0600A3D8 RID: 41944 RVA: 0x000E83FF File Offset: 0x000E65FF
		public override void StartWidgetInteraction(IntPtr e)
		{
			vtkTensorRepresentation.vtkTensorRepresentation_StartWidgetInteraction_62(base.GetCppThis(), e);
		}

		// Token: 0x0600A3D9 RID: 41945
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorRepresentation_StepBackward_63(HandleRef pThis);

		/// <summary>
		/// For complex events should we snap orientations to
		/// be aligned with the x y z axes
		/// </summary>
		// Token: 0x0600A3DA RID: 41946 RVA: 0x000E840F File Offset: 0x000E660F
		public void StepBackward()
		{
			vtkTensorRepresentation.vtkTensorRepresentation_StepBackward_63(base.GetCppThis());
		}

		// Token: 0x0600A3DB RID: 41947
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorRepresentation_StepForward_64(HandleRef pThis);

		/// <summary>
		/// For complex events should we snap orientations to
		/// be aligned with the x y z axes
		/// </summary>
		// Token: 0x0600A3DC RID: 41948 RVA: 0x000E841E File Offset: 0x000E661E
		public void StepForward()
		{
			vtkTensorRepresentation.vtkTensorRepresentation_StepForward_64(base.GetCppThis());
		}

		// Token: 0x0600A3DD RID: 41949
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorRepresentation_TensorEllipsoidOff_65(HandleRef pThis);

		/// <summary>
		/// Indicate whether to show the tensor ellipsoid. By default it is on.
		/// </summary>
		// Token: 0x0600A3DE RID: 41950 RVA: 0x000E842D File Offset: 0x000E662D
		public void TensorEllipsoidOff()
		{
			vtkTensorRepresentation.vtkTensorRepresentation_TensorEllipsoidOff_65(base.GetCppThis());
		}

		// Token: 0x0600A3DF RID: 41951
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorRepresentation_TensorEllipsoidOn_66(HandleRef pThis);

		/// <summary>
		/// Indicate whether to show the tensor ellipsoid. By default it is on.
		/// </summary>
		// Token: 0x0600A3E0 RID: 41952 RVA: 0x000E843C File Offset: 0x000E663C
		public void TensorEllipsoidOn()
		{
			vtkTensorRepresentation.vtkTensorRepresentation_TensorEllipsoidOn_66(base.GetCppThis());
		}

		// Token: 0x0600A3E1 RID: 41953
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorRepresentation_WidgetInteraction_67(HandleRef pThis, IntPtr e);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x0600A3E2 RID: 41954 RVA: 0x000E844B File Offset: 0x000E664B
		public override void WidgetInteraction(IntPtr e)
		{
			vtkTensorRepresentation.vtkTensorRepresentation_WidgetInteraction_67(base.GetCppThis(), e);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D10 RID: 3344
		public new const string MRFullTypeName = "Kitware.VTK.vtkTensorRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D11 RID: 3345
		public new static readonly string MRClassNameKey = "class vtkTensorRepresentation";

		/// <summary>
		/// Methods supporting, and required by, the rendering process.
		/// </summary>
		// Token: 0x02000382 RID: 898
		public enum MoveF0_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000D13 RID: 3347
			MoveF0 = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000D14 RID: 3348
			MoveF1,
			/// <summary>enum member</summary>
			// Token: 0x04000D15 RID: 3349
			MoveF2,
			/// <summary>enum member</summary>
			// Token: 0x04000D16 RID: 3350
			MoveF3,
			/// <summary>enum member</summary>
			// Token: 0x04000D17 RID: 3351
			MoveF4,
			/// <summary>enum member</summary>
			// Token: 0x04000D18 RID: 3352
			MoveF5,
			/// <summary>enum member</summary>
			// Token: 0x04000D19 RID: 3353
			Outside = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000D1A RID: 3354
			Rotating = 8,
			/// <summary>enum member</summary>
			// Token: 0x04000D1B RID: 3355
			Scaling,
			/// <summary>enum member</summary>
			// Token: 0x04000D1C RID: 3356
			Translating = 7
		}
	}
}
