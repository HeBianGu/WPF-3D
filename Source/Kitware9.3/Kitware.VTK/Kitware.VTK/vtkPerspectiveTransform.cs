using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPerspectiveTransform
	/// </summary>
	/// <remarks>
	///    describes a 4x4 matrix transformation
	///
	/// A vtkPerspectiveTransform can be used to describe the full range of
	/// homogeneous transformations.  It was designed in particular
	/// to describe a camera-view of a scene.
	/// &lt;P&gt;The order in which you set up the display coordinates (via
	/// AdjustZBuffer() and AdjustViewport()), the projection (via Perspective(),
	/// Frustum(), or Ortho()) and the camera view (via SetupCamera()) are
	/// important.  If the transform is in PreMultiply mode, which is the
	/// default, set the Viewport and ZBuffer first, then the projection, and
	/// finally the camera view.  Once the view is set up, the Translate
	/// and Rotate methods can be used to move the camera around in world
	/// coordinates.  If the Oblique() or Stereo() methods are used, they
	/// should be called just before SetupCamera().
	/// &lt;P&gt;In PostMultiply mode, you must perform all transformations
	/// in the opposite order.  This is necessary, for example, if you
	/// already have a perspective transformation set up but must adjust
	/// the viewport.  Another example is if you have a view transformation,
	/// and wish to perform translations and rotations in the camera's
	/// coordinate system rather than in world coordinates.
	/// &lt;P&gt;The SetInput and Concatenate methods can be used to create
	/// a transformation pipeline with vtkPerspectiveTransform.  See vtkTransform
	/// for more information on the transformation pipeline.
	/// </remarks>
	/// <seealso>
	///
	/// vtkGeneralTransform vtkTransform vtkMatrix4x4 vtkCamera
	/// </seealso>
	// Token: 0x02000B0C RID: 2828
	public class vtkPerspectiveTransform : vtkHomogeneousTransform
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601DB35 RID: 121653 RVA: 0x0029F283 File Offset: 0x0029D483
		static vtkPerspectiveTransform()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPerspectiveTransform.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPerspectiveTransform"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601DB36 RID: 121654 RVA: 0x0029F2AB File Offset: 0x0029D4AB
		public vtkPerspectiveTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601DB37 RID: 121655
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPerspectiveTransform_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DB38 RID: 121656 RVA: 0x0029F2BC File Offset: 0x0029D4BC
		public new static vtkPerspectiveTransform New()
		{
			vtkPerspectiveTransform result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPerspectiveTransform.vtkPerspectiveTransform_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPerspectiveTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DB39 RID: 121657 RVA: 0x0029F310 File Offset: 0x0029D510
		public vtkPerspectiveTransform() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPerspectiveTransform.vtkPerspectiveTransform_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601DB3A RID: 121658 RVA: 0x0029F354 File Offset: 0x0029D554
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601DB3B RID: 121659
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPerspectiveTransform_AdjustViewport_01(HandleRef pThis, double oldXMin, double oldXMax, double oldYMin, double oldYMax, double newXMin, double newXMax, double newYMin, double newYMax);

		/// <summary>
		/// Perform an adjustment to the viewport coordinates.  By default Ortho,
		/// Frustum, and Perspective provide a window of ([-1,+1],[-1,+1]).
		/// In PreMultiply mode, you call this method before calling Ortho, Frustum,
		/// or Perspective.  In PostMultiply mode you can call it after.  Note
		/// that if you must apply both AdjustZBuffer and AdjustViewport, it
		/// makes no difference which order you apply them in.
		/// </summary>
		// Token: 0x0601DB3C RID: 121660 RVA: 0x0029F360 File Offset: 0x0029D560
		public void AdjustViewport(double oldXMin, double oldXMax, double oldYMin, double oldYMax, double newXMin, double newXMax, double newYMin, double newYMax)
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_AdjustViewport_01(base.GetCppThis(), oldXMin, oldXMax, oldYMin, oldYMax, newXMin, newXMax, newYMin, newYMax);
		}

		// Token: 0x0601DB3D RID: 121661
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPerspectiveTransform_AdjustZBuffer_02(HandleRef pThis, double oldNearZ, double oldFarZ, double newNearZ, double newFarZ);

		/// <summary>
		/// Perform an adjustment to the Z-Buffer range that the near and far
		/// clipping planes map to.  By default Ortho, Frustum, and Perspective
		/// map the near clipping plane to -1 and the far clipping plane to +1.
		/// In PreMultiply mode, you call this method before calling Ortho, Frustum,
		/// or Perspective.  In PostMultiply mode you can call it after.
		/// </summary>
		// Token: 0x0601DB3E RID: 121662 RVA: 0x0029F387 File Offset: 0x0029D587
		public void AdjustZBuffer(double oldNearZ, double oldFarZ, double newNearZ, double newFarZ)
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_AdjustZBuffer_02(base.GetCppThis(), oldNearZ, oldFarZ, newNearZ, newFarZ);
		}

		// Token: 0x0601DB3F RID: 121663
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPerspectiveTransform_CircuitCheck_03(HandleRef pThis, HandleRef transform);

		/// <summary>
		/// Check for self-reference.  Will return true if concatenating
		/// with the specified transform, setting it to be our inverse,
		/// or setting it to be our input will create a circular reference.
		/// CircuitCheck is automatically called by SetInput(), SetInverse(),
		/// and Concatenate(vtkXTransform *).  Avoid using this function,
		/// it is experimental.
		/// </summary>
		// Token: 0x0601DB40 RID: 121664 RVA: 0x0029F39C File Offset: 0x0029D59C
		public override int CircuitCheck(vtkAbstractTransform transform)
		{
			return vtkPerspectiveTransform.vtkPerspectiveTransform_CircuitCheck_03(base.GetCppThis(), (transform == null) ? default(HandleRef) : transform.GetCppThis());
		}

		// Token: 0x0601DB41 RID: 121665
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPerspectiveTransform_Concatenate_04(HandleRef pThis, HandleRef matrix);

		/// <summary>
		/// Concatenates the matrix with the current transformation according
		/// to PreMultiply or PostMultiply semantics.
		/// </summary>
		// Token: 0x0601DB42 RID: 121666 RVA: 0x0029F3D0 File Offset: 0x0029D5D0
		public void Concatenate(vtkMatrix4x4 matrix)
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_Concatenate_04(base.GetCppThis(), (matrix == null) ? default(HandleRef) : matrix.GetCppThis());
		}

		// Token: 0x0601DB43 RID: 121667
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPerspectiveTransform_Concatenate_05(HandleRef pThis, IntPtr elements);

		/// <summary>
		/// Concatenates the matrix with the current transformation according
		/// to PreMultiply or PostMultiply semantics.
		/// </summary>
		// Token: 0x0601DB44 RID: 121668 RVA: 0x0029F3FF File Offset: 0x0029D5FF
		public void Concatenate(IntPtr elements)
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_Concatenate_05(base.GetCppThis(), elements);
		}

		// Token: 0x0601DB45 RID: 121669
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPerspectiveTransform_Concatenate_06(HandleRef pThis, HandleRef transform);

		/// <summary>
		/// Concatenate the specified transform with the current transformation
		/// according to PreMultiply or PostMultiply semantics.
		/// The concatenation is pipelined, meaning that if any of the
		/// transformations are changed, even after Concatenate() is called,
		/// those changes will be reflected when you call TransformPoint().
		/// </summary>
		// Token: 0x0601DB46 RID: 121670 RVA: 0x0029F410 File Offset: 0x0029D610
		public void Concatenate(vtkHomogeneousTransform transform)
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_Concatenate_06(base.GetCppThis(), (transform == null) ? default(HandleRef) : transform.GetCppThis());
		}

		// Token: 0x0601DB47 RID: 121671
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPerspectiveTransform_Frustum_07(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double znear, double zfar);

		/// <summary>
		/// Create an perspective projection matrix and concatenate it by the
		/// current transformation.  The matrix maps a frustum with a back
		/// plane at -zfar and a front plane at -znear with extent
		/// [xmin,xmax],[ymin,ymax] to [-1,+1], [-1,+1], [+1,-1].
		/// </summary>
		// Token: 0x0601DB48 RID: 121672 RVA: 0x0029F43F File Offset: 0x0029D63F
		public void Frustum(double xmin, double xmax, double ymin, double ymax, double znear, double zfar)
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_Frustum_07(base.GetCppThis(), xmin, xmax, ymin, ymax, znear, zfar);
		}

		// Token: 0x0601DB49 RID: 121673
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPerspectiveTransform_GetConcatenatedTransform_08(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get one of the concatenated transformations as a vtkAbstractTransform.
		/// These transformations are applied, in series, every time the
		/// transformation of a coordinate occurs.  This method is provided
		/// to make it possible to decompose a transformation into its
		/// constituents, for example to save a transformation to a file.
		/// </summary>
		// Token: 0x0601DB4A RID: 121674 RVA: 0x0029F458 File Offset: 0x0029D658
		public vtkHomogeneousTransform GetConcatenatedTransform(int i)
		{
			vtkHomogeneousTransform vtkHomogeneousTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPerspectiveTransform.vtkPerspectiveTransform_GetConcatenatedTransform_08(base.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHomogeneousTransform = (vtkHomogeneousTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHomogeneousTransform.Register(null);
				}
			}
			return vtkHomogeneousTransform;
		}

		// Token: 0x0601DB4B RID: 121675
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPerspectiveTransform_GetInput_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the input for this transformation.  This will be used as the
		/// base transformation if it is set.  This method allows you to build
		/// a transform pipeline: if the input is modified, then this transformation
		/// will automatically update accordingly.  Note that the InverseFlag,
		/// controlled via Inverse(), determines whether this transformation
		/// will use the Input or the inverse of the Input.
		/// </summary>
		// Token: 0x0601DB4C RID: 121676 RVA: 0x0029F4C8 File Offset: 0x0029D6C8
		public vtkHomogeneousTransform GetInput()
		{
			vtkHomogeneousTransform vtkHomogeneousTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPerspectiveTransform.vtkPerspectiveTransform_GetInput_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHomogeneousTransform = (vtkHomogeneousTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHomogeneousTransform.Register(null);
				}
			}
			return vtkHomogeneousTransform;
		}

		// Token: 0x0601DB4D RID: 121677
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPerspectiveTransform_GetInverseFlag_10(HandleRef pThis);

		/// <summary>
		/// Get the inverse flag of the transformation.  This controls
		/// whether it is the Input or the inverse of the Input that
		/// is used as the base transformation.  The InverseFlag is
		/// flipped every time Inverse() is called.  The InverseFlag
		/// is off when a transform is first created.
		/// </summary>
		// Token: 0x0601DB4E RID: 121678 RVA: 0x0029F538 File Offset: 0x0029D738
		public int GetInverseFlag()
		{
			return vtkPerspectiveTransform.vtkPerspectiveTransform_GetInverseFlag_10(base.GetCppThis());
		}

		// Token: 0x0601DB4F RID: 121679
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkPerspectiveTransform_GetMTime_11(HandleRef pThis);

		/// <summary>
		/// Override GetMTime to account for input and concatenation.
		/// </summary>
		// Token: 0x0601DB50 RID: 121680 RVA: 0x0029F558 File Offset: 0x0029D758
		public override ulong GetMTime()
		{
			return vtkPerspectiveTransform.vtkPerspectiveTransform_GetMTime_11(base.GetCppThis());
		}

		// Token: 0x0601DB51 RID: 121681
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPerspectiveTransform_GetNumberOfConcatenatedTransforms_12(HandleRef pThis);

		/// <summary>
		/// Get the total number of transformations that are linked into this
		/// one via Concatenate() operations or via SetInput().
		/// </summary>
		// Token: 0x0601DB52 RID: 121682 RVA: 0x0029F578 File Offset: 0x0029D778
		public int GetNumberOfConcatenatedTransforms()
		{
			return vtkPerspectiveTransform.vtkPerspectiveTransform_GetNumberOfConcatenatedTransforms_12(base.GetCppThis());
		}

		// Token: 0x0601DB53 RID: 121683
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPerspectiveTransform_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DB54 RID: 121684 RVA: 0x0029F598 File Offset: 0x0029D798
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPerspectiveTransform.vtkPerspectiveTransform_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x0601DB55 RID: 121685
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPerspectiveTransform_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DB56 RID: 121686 RVA: 0x0029F5B8 File Offset: 0x0029D7B8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPerspectiveTransform.vtkPerspectiveTransform_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x0601DB57 RID: 121687
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPerspectiveTransform_Identity_15(HandleRef pThis);

		/// <summary>
		/// Set this transformation to the identity transformation.  If
		/// the transform has an Input, then the transformation will be
		/// reset so that it is the same as the Input.
		/// </summary>
		// Token: 0x0601DB58 RID: 121688 RVA: 0x0029F5D2 File Offset: 0x0029D7D2
		public void Identity()
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_Identity_15(base.GetCppThis());
		}

		// Token: 0x0601DB59 RID: 121689
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPerspectiveTransform_Inverse_16(HandleRef pThis);

		/// <summary>
		/// Invert the transformation.  This will also set a flag so that
		/// the transformation will use the inverse of its Input, if an Input
		/// has been set.
		/// </summary>
		// Token: 0x0601DB5A RID: 121690 RVA: 0x0029F5E1 File Offset: 0x0029D7E1
		public override void Inverse()
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_Inverse_16(base.GetCppThis());
		}

		// Token: 0x0601DB5B RID: 121691
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPerspectiveTransform_IsA_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DB5C RID: 121692 RVA: 0x0029F5F0 File Offset: 0x0029D7F0
		public override int IsA(string type)
		{
			return vtkPerspectiveTransform.vtkPerspectiveTransform_IsA_17(base.GetCppThis(), type);
		}

		// Token: 0x0601DB5D RID: 121693
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPerspectiveTransform_IsTypeOf_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DB5E RID: 121694 RVA: 0x0029F610 File Offset: 0x0029D810
		public new static int IsTypeOf(string type)
		{
			return vtkPerspectiveTransform.vtkPerspectiveTransform_IsTypeOf_18(type);
		}

		// Token: 0x0601DB5F RID: 121695
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPerspectiveTransform_MakeTransform_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Make a new transform of the same type -- you are responsible for
		/// deleting the transform when you are done with it.
		/// </summary>
		// Token: 0x0601DB60 RID: 121696 RVA: 0x0029F62C File Offset: 0x0029D82C
		public override vtkAbstractTransform MakeTransform()
		{
			vtkAbstractTransform result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPerspectiveTransform.vtkPerspectiveTransform_MakeTransform_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601DB61 RID: 121697
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPerspectiveTransform_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DB62 RID: 121698 RVA: 0x0029F688 File Offset: 0x0029D888
		public new vtkPerspectiveTransform NewInstance()
		{
			vtkPerspectiveTransform result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPerspectiveTransform.vtkPerspectiveTransform_NewInstance_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPerspectiveTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601DB63 RID: 121699
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPerspectiveTransform_Ortho_22(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double znear, double zfar);

		/// <summary>
		/// Create an orthogonal projection matrix and concatenate it by the
		/// current transformation.  The matrix maps [xmin,xmax], [ymin,ymax],
		/// [-znear,-zfar] to [-1,+1], [-1,+1], [+1,-1].
		/// </summary>
		// Token: 0x0601DB64 RID: 121700 RVA: 0x0029F6E2 File Offset: 0x0029D8E2
		public void Ortho(double xmin, double xmax, double ymin, double ymax, double znear, double zfar)
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_Ortho_22(base.GetCppThis(), xmin, xmax, ymin, ymax, znear, zfar);
		}

		// Token: 0x0601DB65 RID: 121701
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPerspectiveTransform_Perspective_23(HandleRef pThis, double angle, double aspect, double znear, double zfar);

		/// <summary>
		/// Create a perspective projection matrix by specifying the view angle
		/// (this angle is in the y direction), the aspect ratio, and the near
		/// and far clipping range.  The projection matrix is concatenated
		/// with the current transformation.  This method works via Frustum.
		/// </summary>
		// Token: 0x0601DB66 RID: 121702 RVA: 0x0029F6FA File Offset: 0x0029D8FA
		public void Perspective(double angle, double aspect, double znear, double zfar)
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_Perspective_23(base.GetCppThis(), angle, aspect, znear, zfar);
		}

		// Token: 0x0601DB67 RID: 121703
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPerspectiveTransform_Pop_24(HandleRef pThis);

		/// <summary>
		/// Deletes the transformation on the top of the stack and sets the top
		/// to the next transformation on the stack.
		/// </summary>
		// Token: 0x0601DB68 RID: 121704 RVA: 0x0029F70E File Offset: 0x0029D90E
		public void Pop()
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_Pop_24(base.GetCppThis());
		}

		// Token: 0x0601DB69 RID: 121705
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPerspectiveTransform_PostMultiply_25(HandleRef pThis);

		/// <summary>
		/// Sets the internal state of the transform to PostMultiply. All subsequent
		/// operations will occur after those already represented in the
		/// current transformation.  In homogeneous matrix notation, M = A*M where
		/// M is the current transformation matrix and A is the applied matrix.
		/// The default is PreMultiply.
		/// </summary>
		// Token: 0x0601DB6A RID: 121706 RVA: 0x0029F71D File Offset: 0x0029D91D
		public void PostMultiply()
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_PostMultiply_25(base.GetCppThis());
		}

		// Token: 0x0601DB6B RID: 121707
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPerspectiveTransform_PreMultiply_26(HandleRef pThis);

		/// <summary>
		/// Sets the internal state of the transform to PreMultiply. All subsequent
		/// operations will occur before those already represented in the
		/// current transformation.  In homogeneous matrix notation, M = M*A where
		/// M is the current transformation matrix and A is the applied matrix.
		/// The default is PreMultiply.
		/// </summary>
		// Token: 0x0601DB6C RID: 121708 RVA: 0x0029F72C File Offset: 0x0029D92C
		public void PreMultiply()
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_PreMultiply_26(base.GetCppThis());
		}

		// Token: 0x0601DB6D RID: 121709
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPerspectiveTransform_Push_27(HandleRef pThis);

		/// <summary>
		/// Pushes the current transformation onto the transformation stack.
		/// </summary>
		// Token: 0x0601DB6E RID: 121710 RVA: 0x0029F73B File Offset: 0x0029D93B
		public void Push()
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_Push_27(base.GetCppThis());
		}

		// Token: 0x0601DB6F RID: 121711
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPerspectiveTransform_RotateWXYZ_28(HandleRef pThis, double angle, double x, double y, double z);

		/// <summary>
		/// Create a rotation matrix and concatenate it with the current
		/// transformation according to PreMultiply or PostMultiply semantics.
		/// The angle is in degrees, and (x,y,z) specifies the axis that the
		/// rotation will be performed around.
		/// </summary>
		// Token: 0x0601DB70 RID: 121712 RVA: 0x0029F74A File Offset: 0x0029D94A
		public void RotateWXYZ(double angle, double x, double y, double z)
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_RotateWXYZ_28(base.GetCppThis(), angle, x, y, z);
		}

		// Token: 0x0601DB71 RID: 121713
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPerspectiveTransform_RotateWXYZ_29(HandleRef pThis, double angle, IntPtr axis);

		/// <summary>
		/// Create a rotation matrix and concatenate it with the current
		/// transformation according to PreMultiply or PostMultiply semantics.
		/// The angle is in degrees, and (x,y,z) specifies the axis that the
		/// rotation will be performed around.
		/// </summary>
		// Token: 0x0601DB72 RID: 121714 RVA: 0x0029F75E File Offset: 0x0029D95E
		public void RotateWXYZ(double angle, IntPtr axis)
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_RotateWXYZ_29(base.GetCppThis(), angle, axis);
		}

		// Token: 0x0601DB73 RID: 121715
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPerspectiveTransform_RotateX_30(HandleRef pThis, double angle);

		/// <summary>
		/// Create a rotation matrix about the X, Y, or Z axis and concatenate
		/// it with the current transformation according to PreMultiply or
		/// PostMultiply semantics.  The angle is expressed in degrees.
		/// </summary>
		// Token: 0x0601DB74 RID: 121716 RVA: 0x0029F76F File Offset: 0x0029D96F
		public void RotateX(double angle)
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_RotateX_30(base.GetCppThis(), angle);
		}

		// Token: 0x0601DB75 RID: 121717
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPerspectiveTransform_RotateY_31(HandleRef pThis, double angle);

		/// <summary>
		/// Create a rotation matrix about the X, Y, or Z axis and concatenate
		/// it with the current transformation according to PreMultiply or
		/// PostMultiply semantics.  The angle is expressed in degrees.
		/// </summary>
		// Token: 0x0601DB76 RID: 121718 RVA: 0x0029F77F File Offset: 0x0029D97F
		public void RotateY(double angle)
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_RotateY_31(base.GetCppThis(), angle);
		}

		// Token: 0x0601DB77 RID: 121719
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPerspectiveTransform_RotateZ_32(HandleRef pThis, double angle);

		/// <summary>
		/// Create a rotation matrix about the X, Y, or Z axis and concatenate
		/// it with the current transformation according to PreMultiply or
		/// PostMultiply semantics.  The angle is expressed in degrees.
		/// </summary>
		// Token: 0x0601DB78 RID: 121720 RVA: 0x0029F78F File Offset: 0x0029D98F
		public void RotateZ(double angle)
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_RotateZ_32(base.GetCppThis(), angle);
		}

		// Token: 0x0601DB79 RID: 121721
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPerspectiveTransform_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DB7A RID: 121722 RVA: 0x0029F7A0 File Offset: 0x0029D9A0
		public new static vtkPerspectiveTransform SafeDownCast(vtkObjectBase o)
		{
			vtkPerspectiveTransform vtkPerspectiveTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPerspectiveTransform.vtkPerspectiveTransform_SafeDownCast_33((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPerspectiveTransform = (vtkPerspectiveTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPerspectiveTransform.Register(null);
				}
			}
			return vtkPerspectiveTransform;
		}

		// Token: 0x0601DB7B RID: 121723
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPerspectiveTransform_Scale_34(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Create a scale matrix (i.e. set the diagonal elements to x, y, z)
		/// and concatenate it with the current transformation according to
		/// PreMultiply or PostMultiply semantics.
		/// </summary>
		// Token: 0x0601DB7C RID: 121724 RVA: 0x0029F81F File Offset: 0x0029DA1F
		public void Scale(double x, double y, double z)
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_Scale_34(base.GetCppThis(), x, y, z);
		}

		// Token: 0x0601DB7D RID: 121725
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPerspectiveTransform_Scale_35(HandleRef pThis, IntPtr s);

		/// <summary>
		/// Create a scale matrix (i.e. set the diagonal elements to x, y, z)
		/// and concatenate it with the current transformation according to
		/// PreMultiply or PostMultiply semantics.
		/// </summary>
		// Token: 0x0601DB7E RID: 121726 RVA: 0x0029F831 File Offset: 0x0029DA31
		public void Scale(IntPtr s)
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_Scale_35(base.GetCppThis(), s);
		}

		// Token: 0x0601DB7F RID: 121727
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPerspectiveTransform_SetInput_36(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Set the input for this transformation.  This will be used as the
		/// base transformation if it is set.  This method allows you to build
		/// a transform pipeline: if the input is modified, then this transformation
		/// will automatically update accordingly.  Note that the InverseFlag,
		/// controlled via Inverse(), determines whether this transformation
		/// will use the Input or the inverse of the Input.
		/// </summary>
		// Token: 0x0601DB80 RID: 121728 RVA: 0x0029F844 File Offset: 0x0029DA44
		public void SetInput(vtkHomogeneousTransform input)
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_SetInput_36(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x0601DB81 RID: 121729
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPerspectiveTransform_SetMatrix_37(HandleRef pThis, HandleRef matrix);

		/// <summary>
		/// Set the current matrix directly.  This actually calls Identity(),
		/// followed by Concatenate(matrix).
		/// </summary>
		// Token: 0x0601DB82 RID: 121730 RVA: 0x0029F874 File Offset: 0x0029DA74
		public void SetMatrix(vtkMatrix4x4 matrix)
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_SetMatrix_37(base.GetCppThis(), (matrix == null) ? default(HandleRef) : matrix.GetCppThis());
		}

		// Token: 0x0601DB83 RID: 121731
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPerspectiveTransform_SetMatrix_38(HandleRef pThis, IntPtr elements);

		/// <summary>
		/// Set the current matrix directly.  This actually calls Identity(),
		/// followed by Concatenate(matrix).
		/// </summary>
		// Token: 0x0601DB84 RID: 121732 RVA: 0x0029F8A3 File Offset: 0x0029DAA3
		public void SetMatrix(IntPtr elements)
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_SetMatrix_38(base.GetCppThis(), elements);
		}

		// Token: 0x0601DB85 RID: 121733
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPerspectiveTransform_SetupCamera_39(HandleRef pThis, IntPtr position, IntPtr focalpoint, IntPtr viewup);

		/// <summary>
		/// Set a view transformation matrix for the camera (this matrix does
		/// not contain any perspective) and concatenate it with the current
		/// transformation.
		/// </summary>
		// Token: 0x0601DB86 RID: 121734 RVA: 0x0029F8B3 File Offset: 0x0029DAB3
		public void SetupCamera(IntPtr position, IntPtr focalpoint, IntPtr viewup)
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_SetupCamera_39(base.GetCppThis(), position, focalpoint, viewup);
		}

		// Token: 0x0601DB87 RID: 121735
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPerspectiveTransform_SetupCamera_40(HandleRef pThis, double p0, double p1, double p2, double fp0, double fp1, double fp2, double vup0, double vup1, double vup2);

		/// <summary>
		/// Set a view transformation matrix for the camera (this matrix does
		/// not contain any perspective) and concatenate it with the current
		/// transformation.
		/// </summary>
		// Token: 0x0601DB88 RID: 121736 RVA: 0x0029F8C8 File Offset: 0x0029DAC8
		public void SetupCamera(double p0, double p1, double p2, double fp0, double fp1, double fp2, double vup0, double vup1, double vup2)
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_SetupCamera_40(base.GetCppThis(), p0, p1, p2, fp0, fp1, fp2, vup0, vup1, vup2);
		}

		// Token: 0x0601DB89 RID: 121737
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPerspectiveTransform_Shear_41(HandleRef pThis, double dxdz, double dydz, double zplane);

		/// <summary>
		/// Create a shear transformation about a plane at distance z from
		/// the camera.  The values dxdz (i.e. dx/dz) and dydz specify the
		/// amount of shear in the x and y directions.  The 'zplane' specifies
		/// the distance from the camera to the plane at which the shear
		/// causes zero displacement.  Generally you want this plane to be the
		/// focal plane.
		/// This transformation can be used in combination with Ortho to create
		/// an oblique projection.  It can also be used in combination with
		/// Perspective to provide correct stereo views when the eye is at
		/// arbitrary but known positions relative to the center of a flat
		/// viewing screen.
		/// </summary>
		// Token: 0x0601DB8A RID: 121738 RVA: 0x0029F8F1 File Offset: 0x0029DAF1
		public void Shear(double dxdz, double dydz, double zplane)
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_Shear_41(base.GetCppThis(), dxdz, dydz, zplane);
		}

		// Token: 0x0601DB8B RID: 121739
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPerspectiveTransform_Stereo_42(HandleRef pThis, double angle, double focaldistance);

		/// <summary>
		/// Create a stereo shear matrix and concatenate it with the
		/// current transformation.  This can be applied in conjunction with either a
		/// perspective transformation (via Frustum or Projection) or an
		/// orthographic projection.  You must specify the distance from
		/// the camera plane to the focal plane, and the angle between
		/// the distance vector and the eye.  The angle should be negative
		/// for the left eye, and positive for the right.  This method
		/// works via Oblique.
		/// </summary>
		// Token: 0x0601DB8C RID: 121740 RVA: 0x0029F903 File Offset: 0x0029DB03
		public void Stereo(double angle, double focaldistance)
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_Stereo_42(base.GetCppThis(), angle, focaldistance);
		}

		// Token: 0x0601DB8D RID: 121741
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPerspectiveTransform_Translate_43(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Create a translation matrix and concatenate it with the current
		/// transformation according to PreMultiply or PostMultiply semantics.
		/// </summary>
		// Token: 0x0601DB8E RID: 121742 RVA: 0x0029F914 File Offset: 0x0029DB14
		public void Translate(double x, double y, double z)
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_Translate_43(base.GetCppThis(), x, y, z);
		}

		// Token: 0x0601DB8F RID: 121743
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPerspectiveTransform_Translate_44(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Create a translation matrix and concatenate it with the current
		/// transformation according to PreMultiply or PostMultiply semantics.
		/// </summary>
		// Token: 0x0601DB90 RID: 121744 RVA: 0x0029F926 File Offset: 0x0029DB26
		public void Translate(IntPtr x)
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_Translate_44(base.GetCppThis(), x);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F49 RID: 8009
		public new const string MRFullTypeName = "Kitware.VTK.vtkPerspectiveTransform";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F4A RID: 8010
		public new static readonly string MRClassNameKey = "class vtkPerspectiveTransform";
	}
}
