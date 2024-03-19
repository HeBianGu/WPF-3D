using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCamera
	/// </summary>
	/// <remarks>
	///    a virtual camera for 3D rendering
	///
	/// vtkCamera is a virtual camera for 3D rendering. It provides methods
	/// to position and orient the view point and focal point. Convenience
	/// methods for moving about the focal point also are provided. More
	/// complex methods allow the manipulation of the computer graphics
	/// model including view up vector, clipping planes, and
	/// camera perspective.
	/// </remarks>
	/// <seealso>
	///
	/// vtkPerspectiveTransform
	/// </seealso>
	// Token: 0x0200009E RID: 158
	public class vtkCamera : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06002157 RID: 8535 RVA: 0x00032413 File Offset: 0x00030613
		static vtkCamera()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCamera.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCamera"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06002158 RID: 8536 RVA: 0x0003243B File Offset: 0x0003063B
		public vtkCamera(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06002159 RID: 8537
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCamera_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct camera instance with its focal point at the origin,
		/// and position=(0,0,1). The view up is along the y-axis,
		/// view angle is 30 degrees, and the clipping range is (.1,1000).
		/// </summary>
		// Token: 0x0600215A RID: 8538 RVA: 0x0003244C File Offset: 0x0003064C
		public new static vtkCamera New()
		{
			vtkCamera result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCamera.vtkCamera_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCamera)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct camera instance with its focal point at the origin,
		/// and position=(0,0,1). The view up is along the y-axis,
		/// view angle is 30 degrees, and the clipping range is (.1,1000).
		/// </summary>
		// Token: 0x0600215B RID: 8539 RVA: 0x000324A0 File Offset: 0x000306A0
		public vtkCamera() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCamera.vtkCamera_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600215C RID: 8540 RVA: 0x000324E4 File Offset: 0x000306E4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600215D RID: 8541
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_ApplyTransform_01(HandleRef pThis, HandleRef t);

		/// <summary>
		/// Apply a transform to the camera.  The camera position, focal-point,
		/// and view-up are re-calculated using the transform's matrix to
		/// multiply the old points by the new transform.
		/// </summary>
		// Token: 0x0600215E RID: 8542 RVA: 0x000324F0 File Offset: 0x000306F0
		public void ApplyTransform(vtkTransform t)
		{
			vtkCamera.vtkCamera_ApplyTransform_01(base.GetCppThis(), (t == null) ? default(HandleRef) : t.GetCppThis());
		}

		// Token: 0x0600215F RID: 8543
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_Azimuth_02(HandleRef pThis, double angle);

		/// <summary>
		/// Rotate the camera about the view up vector centered at the focal point.
		/// Note that the view up vector is whatever was set via SetViewUp, and is
		/// not necessarily perpendicular to the direction of projection.  The
		/// result is a horizontal rotation of the camera.
		/// </summary>
		// Token: 0x06002160 RID: 8544 RVA: 0x0003251F File Offset: 0x0003071F
		public void Azimuth(double angle)
		{
			vtkCamera.vtkCamera_Azimuth_02(base.GetCppThis(), angle);
		}

		// Token: 0x06002161 RID: 8545
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_ComputeViewPlaneNormal_03(HandleRef pThis);

		/// <summary>
		/// This method is called automatically whenever necessary, it
		/// should never be used outside of vtkCamera.cxx.
		/// </summary>
		// Token: 0x06002162 RID: 8546 RVA: 0x0003252F File Offset: 0x0003072F
		public void ComputeViewPlaneNormal()
		{
			vtkCamera.vtkCamera_ComputeViewPlaneNormal_03(base.GetCppThis());
		}

		// Token: 0x06002163 RID: 8547
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_DeepCopy_04(HandleRef pThis, HandleRef source);

		/// <summary>
		/// Copy the properties of `source' into `this'.
		/// Copy the contents of the matrices.
		/// \pre source_exists!=0
		/// \pre not_this: source!=this
		/// </summary>
		// Token: 0x06002164 RID: 8548 RVA: 0x00032540 File Offset: 0x00030740
		public void DeepCopy(vtkCamera source)
		{
			vtkCamera.vtkCamera_DeepCopy_04(base.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x06002165 RID: 8549
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_Dolly_05(HandleRef pThis, double value);

		/// <summary>
		/// Divide the camera's distance from the focal point by the given
		/// dolly value.  Use a value greater than one to dolly-in toward
		/// the focal point, and use a value less than one to dolly-out away
		/// from the focal point.
		/// </summary>
		// Token: 0x06002166 RID: 8550 RVA: 0x0003256F File Offset: 0x0003076F
		public void Dolly(double value)
		{
			vtkCamera.vtkCamera_Dolly_05(base.GetCppThis(), value);
		}

		// Token: 0x06002167 RID: 8551
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_Elevation_06(HandleRef pThis, double angle);

		/// <summary>
		/// Rotate the camera about the cross product of the negative of the
		/// direction of projection and the view up vector, using the focal point
		/// as the center of rotation.  The result is a vertical rotation of the
		/// scene.
		/// </summary>
		// Token: 0x06002168 RID: 8552 RVA: 0x0003257F File Offset: 0x0003077F
		public void Elevation(double angle)
		{
			vtkCamera.vtkCamera_Elevation_06(base.GetCppThis(), angle);
		}

		// Token: 0x06002169 RID: 8553
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCamera_GetCameraLightTransformMatrix_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns a transformation matrix for a coordinate frame attached to
		/// the camera, where the camera is located at (0, 0, 1) looking at the
		/// focal point at (0, 0, 0), with up being (0, 1, 0).
		/// </summary>
		// Token: 0x0600216A RID: 8554 RVA: 0x00032590 File Offset: 0x00030790
		public vtkMatrix4x4 GetCameraLightTransformMatrix()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCamera.vtkCamera_GetCameraLightTransformMatrix_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrix4x = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrix4x.Register(null);
				}
			}
			return vtkMatrix4x;
		}

		// Token: 0x0600216B RID: 8555
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCamera_GetClippingRange_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the location of the near and far clipping planes along the
		/// direction of projection.  Both of these values must be positive.
		/// How the clipping planes are set can have a large impact on how
		/// well z-buffering works.  In particular the front clipping
		/// plane can make a very big difference. Setting it to 0.01 when it
		/// really could be 1.0 can have a big impact on your z-buffer resolution
		/// farther away.  The default clipping range is (0.1,1000).
		/// Clipping distance is measured in world coordinate unless a scale factor
		/// exists in camera's ModelTransformMatrix.
		/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
		/// is true.
		/// </summary>
		// Token: 0x0600216C RID: 8556 RVA: 0x00032600 File Offset: 0x00030800
		public virtual double[] GetClippingRange()
		{
			IntPtr intPtr = vtkCamera.vtkCamera_GetClippingRange_08(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600216D RID: 8557
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_GetClippingRange_09(HandleRef pThis, ref double _arg1, ref double _arg2);

		/// <summary>
		/// Set/Get the location of the near and far clipping planes along the
		/// direction of projection.  Both of these values must be positive.
		/// How the clipping planes are set can have a large impact on how
		/// well z-buffering works.  In particular the front clipping
		/// plane can make a very big difference. Setting it to 0.01 when it
		/// really could be 1.0 can have a big impact on your z-buffer resolution
		/// farther away.  The default clipping range is (0.1,1000).
		/// Clipping distance is measured in world coordinate unless a scale factor
		/// exists in camera's ModelTransformMatrix.
		/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
		/// is true.
		/// </summary>
		// Token: 0x0600216E RID: 8558 RVA: 0x00032648 File Offset: 0x00030848
		public virtual void GetClippingRange(ref double _arg1, ref double _arg2)
		{
			vtkCamera.vtkCamera_GetClippingRange_09(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x0600216F RID: 8559
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_GetClippingRange_10(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the location of the near and far clipping planes along the
		/// direction of projection.  Both of these values must be positive.
		/// How the clipping planes are set can have a large impact on how
		/// well z-buffering works.  In particular the front clipping
		/// plane can make a very big difference. Setting it to 0.01 when it
		/// really could be 1.0 can have a big impact on your z-buffer resolution
		/// farther away.  The default clipping range is (0.1,1000).
		/// Clipping distance is measured in world coordinate unless a scale factor
		/// exists in camera's ModelTransformMatrix.
		/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
		/// is true.
		/// </summary>
		// Token: 0x06002170 RID: 8560 RVA: 0x00032659 File Offset: 0x00030859
		public virtual void GetClippingRange(IntPtr _arg)
		{
			vtkCamera.vtkCamera_GetClippingRange_10(base.GetCppThis(), _arg);
		}

		// Token: 0x06002171 RID: 8561
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCamera_GetCompositeProjectionTransformMatrix_11(HandleRef pThis, double aspect, double nearz, double farz, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the concatenation of the ViewTransform and the
		/// ProjectionTransform. This transform will convert world
		/// coordinates to viewport coordinates. The 'aspect' is the
		/// width/height for the viewport, and the nearz and farz are the
		/// Z-buffer values that map to the near and far clipping planes.
		/// The viewport coordinates of a point located inside the frustum are in the
		/// range ([-1,+1],[-1,+1],[nearz,farz]).
		/// aspect is ignored if UseExplicitAspectRatio is true.
		/// @sa ExplicitProjectionTransformMatrix
		/// </summary>
		// Token: 0x06002172 RID: 8562 RVA: 0x0003266C File Offset: 0x0003086C
		public virtual vtkMatrix4x4 GetCompositeProjectionTransformMatrix(double aspect, double nearz, double farz)
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCamera.vtkCamera_GetCompositeProjectionTransformMatrix_11(base.GetCppThis(), aspect, nearz, farz, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrix4x = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrix4x.Register(null);
				}
			}
			return vtkMatrix4x;
		}

		// Token: 0x06002173 RID: 8563
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCamera_GetDirectionOfProjection_12(HandleRef pThis);

		/// <summary>
		/// Get the vector in the direction from the camera position to the
		/// focal point.  This is usually the opposite of the ViewPlaneNormal,
		/// the vector perpendicular to the screen, unless the view is oblique.
		/// </summary>
		// Token: 0x06002174 RID: 8564 RVA: 0x000326E0 File Offset: 0x000308E0
		public virtual double[] GetDirectionOfProjection()
		{
			IntPtr intPtr = vtkCamera.vtkCamera_GetDirectionOfProjection_12(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06002175 RID: 8565
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_GetDirectionOfProjection_13(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Get the vector in the direction from the camera position to the
		/// focal point.  This is usually the opposite of the ViewPlaneNormal,
		/// the vector perpendicular to the screen, unless the view is oblique.
		/// </summary>
		// Token: 0x06002176 RID: 8566 RVA: 0x00032728 File Offset: 0x00030928
		public virtual void GetDirectionOfProjection(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkCamera.vtkCamera_GetDirectionOfProjection_13(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06002177 RID: 8567
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_GetDirectionOfProjection_14(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get the vector in the direction from the camera position to the
		/// focal point.  This is usually the opposite of the ViewPlaneNormal,
		/// the vector perpendicular to the screen, unless the view is oblique.
		/// </summary>
		// Token: 0x06002178 RID: 8568 RVA: 0x0003273A File Offset: 0x0003093A
		public virtual void GetDirectionOfProjection(IntPtr _arg)
		{
			vtkCamera.vtkCamera_GetDirectionOfProjection_14(base.GetCppThis(), _arg);
		}

		// Token: 0x06002179 RID: 8569
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCamera_GetDistance_15(HandleRef pThis);

		/// <summary>
		/// Return the distance from the camera position to the focal point.
		/// This distance is positive.
		/// </summary>
		// Token: 0x0600217A RID: 8570 RVA: 0x0003274C File Offset: 0x0003094C
		public virtual double GetDistance()
		{
			return vtkCamera.vtkCamera_GetDistance_15(base.GetCppThis());
		}

		// Token: 0x0600217B RID: 8571
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCamera_GetExplicitAspectRatio_16(HandleRef pThis);

		/// <summary>
		/// Set/get an explicit aspect to use, rather than computing it from the renderer.
		/// Only used when UseExplicitAspect is true.
		/// @{
		/// </summary>
		// Token: 0x0600217C RID: 8572 RVA: 0x0003276C File Offset: 0x0003096C
		public virtual double GetExplicitAspectRatio()
		{
			return vtkCamera.vtkCamera_GetExplicitAspectRatio_16(base.GetCppThis());
		}

		// Token: 0x0600217D RID: 8573
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCamera_GetExplicitProjectionTransformMatrix_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get an explicit 4x4 projection matrix to use, rather than computing
		/// one from other state variables. Only used when
		/// UseExplicitProjectionTransformMatrix is true.
		/// @{
		/// </summary>
		// Token: 0x0600217E RID: 8574 RVA: 0x0003278C File Offset: 0x0003098C
		public virtual vtkMatrix4x4 GetExplicitProjectionTransformMatrix()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCamera.vtkCamera_GetExplicitProjectionTransformMatrix_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrix4x = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrix4x.Register(null);
				}
			}
			return vtkMatrix4x;
		}

		// Token: 0x0600217F RID: 8575
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCamera_GetEyeAngle_18(HandleRef pThis);

		/// <summary>
		/// Set/Get the separation between eyes (in degrees). This is used
		/// when generating stereo images.
		/// </summary>
		// Token: 0x06002180 RID: 8576 RVA: 0x000327FC File Offset: 0x000309FC
		public virtual double GetEyeAngle()
		{
			return vtkCamera.vtkCamera_GetEyeAngle_18(base.GetCppThis());
		}

		// Token: 0x06002181 RID: 8577
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_GetEyePlaneNormal_19(HandleRef pThis, IntPtr normal);

		/// <summary>
		/// Get normal vector from eye to screen rotated by EyeTransformMatrix.
		/// This will be used only for offaxis frustum calculation.
		/// </summary>
		// Token: 0x06002182 RID: 8578 RVA: 0x0003281B File Offset: 0x00030A1B
		public void GetEyePlaneNormal(IntPtr normal)
		{
			vtkCamera.vtkCamera_GetEyePlaneNormal_19(base.GetCppThis(), normal);
		}

		// Token: 0x06002183 RID: 8579
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_GetEyePosition_20(HandleRef pThis, IntPtr eyePosition);

		/// <summary>
		/// Set/Get the eye position (center point between two eyes).
		/// This is a convenience function that sets the translation
		/// component of EyeTransformMatrix.
		/// This will be used only for offaxis frustum calculation.
		/// </summary>
		// Token: 0x06002184 RID: 8580 RVA: 0x0003282B File Offset: 0x00030A2B
		public void GetEyePosition(IntPtr eyePosition)
		{
			vtkCamera.vtkCamera_GetEyePosition_20(base.GetCppThis(), eyePosition);
		}

		// Token: 0x06002185 RID: 8581
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCamera_GetEyeSeparation_21(HandleRef pThis);

		/// <summary>
		/// Set/Get distance between the eyes.
		/// This will be used only for offaxis frustum calculation.
		/// Default is 0.06.
		/// </summary>
		// Token: 0x06002186 RID: 8582 RVA: 0x0003283C File Offset: 0x00030A3C
		public virtual double GetEyeSeparation()
		{
			return vtkCamera.vtkCamera_GetEyeSeparation_21(base.GetCppThis());
		}

		// Token: 0x06002187 RID: 8583
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCamera_GetEyeTransformMatrix_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get eye transformation matrix.
		/// This is the transformation matrix for the point between eyes.
		/// This will be used only for offaxis frustum calculation.
		/// Default is identity.
		/// </summary>
		// Token: 0x06002188 RID: 8584 RVA: 0x0003285C File Offset: 0x00030A5C
		public virtual vtkMatrix4x4 GetEyeTransformMatrix()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCamera.vtkCamera_GetEyeTransformMatrix_22(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrix4x = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrix4x.Register(null);
				}
			}
			return vtkMatrix4x;
		}

		// Token: 0x06002189 RID: 8585
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCamera_GetFocalDisk_23(HandleRef pThis);

		/// <summary>
		/// Set the size of the cameras lens in world coordinates. This is only
		/// used when the renderer is doing focal depth rendering. When that is
		/// being done the size of the focal disk will effect how significant the
		/// depth effects will be.
		/// </summary>
		// Token: 0x0600218A RID: 8586 RVA: 0x000328CC File Offset: 0x00030ACC
		public virtual double GetFocalDisk()
		{
			return vtkCamera.vtkCamera_GetFocalDisk_23(base.GetCppThis());
		}

		// Token: 0x0600218B RID: 8587
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCamera_GetFocalDistance_24(HandleRef pThis);

		/// <summary>
		/// Sets the distance at which rendering is in focus. This is currently
		/// only used by the ray tracing renderers. 0 (default) disables
		/// ray traced depth of field.
		/// Not to be confused with FocalPoint that is the camera target and
		/// is centered on screen. Using a separate focal distance property
		/// enables out-of-focus areas anywhere on screen.
		/// </summary>
		// Token: 0x0600218C RID: 8588 RVA: 0x000328EC File Offset: 0x00030AEC
		public virtual double GetFocalDistance()
		{
			return vtkCamera.vtkCamera_GetFocalDistance_24(base.GetCppThis());
		}

		// Token: 0x0600218D RID: 8589
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCamera_GetFocalPoint_25(HandleRef pThis);

		/// <summary>
		/// Set/Get the focal of the camera in world coordinates.
		/// The default focal point is the origin.
		/// </summary>
		// Token: 0x0600218E RID: 8590 RVA: 0x0003290C File Offset: 0x00030B0C
		public virtual double[] GetFocalPoint()
		{
			IntPtr intPtr = vtkCamera.vtkCamera_GetFocalPoint_25(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600218F RID: 8591
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_GetFocalPoint_26(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the focal of the camera in world coordinates.
		/// The default focal point is the origin.
		/// </summary>
		// Token: 0x06002190 RID: 8592 RVA: 0x00032954 File Offset: 0x00030B54
		public virtual void GetFocalPoint(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkCamera.vtkCamera_GetFocalPoint_26(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06002191 RID: 8593
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_GetFocalPoint_27(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the focal of the camera in world coordinates.
		/// The default focal point is the origin.
		/// </summary>
		// Token: 0x06002192 RID: 8594 RVA: 0x00032966 File Offset: 0x00030B66
		public virtual void GetFocalPoint(IntPtr _arg)
		{
			vtkCamera.vtkCamera_GetFocalPoint_27(base.GetCppThis(), _arg);
		}

		// Token: 0x06002193 RID: 8595
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCamera_GetFocalPointScale_28(HandleRef pThis);

		/// <summary>
		/// The following methods are used to support view dependent methods
		/// for normalizing data (typically point coordinates). When dealing with
		/// data that can exceed floating point resolution sometimes is it best
		/// to normalize that data based on the current camera view such that
		/// what is seen will be in the sweet spot for floating point resolution.
		/// Input datasets may be double precision but the rendering engine
		/// is currently single precision which also can lead to these issues.
		/// See vtkOpenGLVertexBufferObject for related information.
		/// </summary>
		// Token: 0x06002194 RID: 8596 RVA: 0x00032978 File Offset: 0x00030B78
		public virtual double GetFocalPointScale()
		{
			return vtkCamera.vtkCamera_GetFocalPointScale_28(base.GetCppThis());
		}

		// Token: 0x06002195 RID: 8597
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCamera_GetFocalPointShift_29(HandleRef pThis);

		/// <summary>
		/// The following methods are used to support view dependent methods
		/// for normalizing data (typically point coordinates). When dealing with
		/// data that can exceed floating point resolution sometimes is it best
		/// to normalize that data based on the current camera view such that
		/// what is seen will be in the sweet spot for floating point resolution.
		/// Input datasets may be double precision but the rendering engine
		/// is currently single precision which also can lead to these issues.
		/// See vtkOpenGLVertexBufferObject for related information.
		/// </summary>
		// Token: 0x06002196 RID: 8598 RVA: 0x00032998 File Offset: 0x00030B98
		public virtual double[] GetFocalPointShift()
		{
			IntPtr intPtr = vtkCamera.vtkCamera_GetFocalPointShift_29(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06002197 RID: 8599
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_GetFocalPointShift_30(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// The following methods are used to support view dependent methods
		/// for normalizing data (typically point coordinates). When dealing with
		/// data that can exceed floating point resolution sometimes is it best
		/// to normalize that data based on the current camera view such that
		/// what is seen will be in the sweet spot for floating point resolution.
		/// Input datasets may be double precision but the rendering engine
		/// is currently single precision which also can lead to these issues.
		/// See vtkOpenGLVertexBufferObject for related information.
		/// </summary>
		// Token: 0x06002198 RID: 8600 RVA: 0x000329E0 File Offset: 0x00030BE0
		public virtual void GetFocalPointShift(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkCamera.vtkCamera_GetFocalPointShift_30(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06002199 RID: 8601
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_GetFocalPointShift_31(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// The following methods are used to support view dependent methods
		/// for normalizing data (typically point coordinates). When dealing with
		/// data that can exceed floating point resolution sometimes is it best
		/// to normalize that data based on the current camera view such that
		/// what is seen will be in the sweet spot for floating point resolution.
		/// Input datasets may be double precision but the rendering engine
		/// is currently single precision which also can lead to these issues.
		/// See vtkOpenGLVertexBufferObject for related information.
		/// </summary>
		// Token: 0x0600219A RID: 8602 RVA: 0x000329F2 File Offset: 0x00030BF2
		public virtual void GetFocalPointShift(IntPtr _arg)
		{
			vtkCamera.vtkCamera_GetFocalPointShift_31(base.GetCppThis(), _arg);
		}

		// Token: 0x0600219B RID: 8603
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCamera_GetFreezeFocalPoint_32(HandleRef pThis);

		/// <summary>
		/// Set/Get the value of the FreezeDolly instance variable. This
		/// determines if the camera should move the focal point with the camera position.
		/// HACK!!!
		/// </summary>
		// Token: 0x0600219C RID: 8604 RVA: 0x00032A04 File Offset: 0x00030C04
		public virtual bool GetFreezeFocalPoint()
		{
			return vtkCamera.vtkCamera_GetFreezeFocalPoint_32(base.GetCppThis()) != 0;
		}

		// Token: 0x0600219D RID: 8605
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_GetFrustumPlanes_33(HandleRef pThis, double aspect, IntPtr planes);

		/// <summary>
		/// Get the plane equations that bound the view frustum.
		/// The plane normals point inward. The planes array contains six
		/// plane equations of the form (Ax+By+Cz+D=0), the first four
		/// values are (A,B,C,D) which repeats for each of the planes.
		/// The planes are given in the following order: -x,+x,-y,+y,-z,+z.
		/// Warning: it means left,right,bottom,top,far,near (NOT near,far)
		/// The aspect of the viewport is needed to correctly compute the planes.
		/// aspect is ignored if UseExplicitAspectRatio is true.
		/// </summary>
		// Token: 0x0600219E RID: 8606 RVA: 0x00032A2A File Offset: 0x00030C2A
		public virtual void GetFrustumPlanes(double aspect, IntPtr planes)
		{
			vtkCamera.vtkCamera_GetFrustumPlanes_33(base.GetCppThis(), aspect, planes);
		}

		// Token: 0x0600219F RID: 8607
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCamera_GetInformation_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the information object associated with this camera.
		/// </summary>
		// Token: 0x060021A0 RID: 8608 RVA: 0x00032A3C File Offset: 0x00030C3C
		public virtual vtkInformation GetInformation()
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCamera.vtkCamera_GetInformation_34(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformation = (vtkInformation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformation.Register(null);
				}
			}
			return vtkInformation;
		}

		// Token: 0x060021A1 RID: 8609
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCamera_GetLeftEye_35(HandleRef pThis);

		/// <summary>
		/// Set the Left Eye setting
		/// </summary>
		// Token: 0x060021A2 RID: 8610 RVA: 0x00032AAC File Offset: 0x00030CAC
		public virtual int GetLeftEye()
		{
			return vtkCamera.vtkCamera_GetLeftEye_35(base.GetCppThis());
		}

		// Token: 0x060021A3 RID: 8611
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCamera_GetModelTransformMatrix_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get model transformation matrix.
		/// This matrix could be used for model related transformations
		/// such as scale, shear, rotations and translations.
		/// </summary>
		// Token: 0x060021A4 RID: 8612 RVA: 0x00032ACC File Offset: 0x00030CCC
		public virtual vtkMatrix4x4 GetModelTransformMatrix()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCamera.vtkCamera_GetModelTransformMatrix_36(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrix4x = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrix4x.Register(null);
				}
			}
			return vtkMatrix4x;
		}

		// Token: 0x060021A5 RID: 8613
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCamera_GetModelViewTransformMatrix_37(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the model view matrix of model view transform.
		/// </summary>
		// Token: 0x060021A6 RID: 8614 RVA: 0x00032B3C File Offset: 0x00030D3C
		public virtual vtkMatrix4x4 GetModelViewTransformMatrix()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCamera.vtkCamera_GetModelViewTransformMatrix_37(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrix4x = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrix4x.Register(null);
				}
			}
			return vtkMatrix4x;
		}

		// Token: 0x060021A7 RID: 8615
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCamera_GetModelViewTransformObject_38(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the model view transform.
		/// </summary>
		// Token: 0x060021A8 RID: 8616 RVA: 0x00032BAC File Offset: 0x00030DAC
		public virtual vtkTransform GetModelViewTransformObject()
		{
			vtkTransform vtkTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCamera.vtkCamera_GetModelViewTransformObject_38(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransform = (vtkTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransform.Register(null);
				}
			}
			return vtkTransform;
		}

		// Token: 0x060021A9 RID: 8617
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCamera_GetNearPlaneScale_39(HandleRef pThis);

		/// <summary>
		/// The following methods are used to support view dependent methods
		/// for normalizing data (typically point coordinates). When dealing with
		/// data that can exceed floating point resolution sometimes is it best
		/// to normalize that data based on the current camera view such that
		/// what is seen will be in the sweet spot for floating point resolution.
		/// Input datasets may be double precision but the rendering engine
		/// is currently single precision which also can lead to these issues.
		/// See vtkOpenGLVertexBufferObject for related information.
		/// </summary>
		// Token: 0x060021AA RID: 8618 RVA: 0x00032C1C File Offset: 0x00030E1C
		public virtual double GetNearPlaneScale()
		{
			return vtkCamera.vtkCamera_GetNearPlaneScale_39(base.GetCppThis());
		}

		// Token: 0x060021AB RID: 8619
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCamera_GetNearPlaneShift_40(HandleRef pThis);

		/// <summary>
		/// The following methods are used to support view dependent methods
		/// for normalizing data (typically point coordinates). When dealing with
		/// data that can exceed floating point resolution sometimes is it best
		/// to normalize that data based on the current camera view such that
		/// what is seen will be in the sweet spot for floating point resolution.
		/// Input datasets may be double precision but the rendering engine
		/// is currently single precision which also can lead to these issues.
		/// See vtkOpenGLVertexBufferObject for related information.
		/// </summary>
		// Token: 0x060021AC RID: 8620 RVA: 0x00032C3C File Offset: 0x00030E3C
		public virtual double[] GetNearPlaneShift()
		{
			IntPtr intPtr = vtkCamera.vtkCamera_GetNearPlaneShift_40(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060021AD RID: 8621
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_GetNearPlaneShift_41(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// The following methods are used to support view dependent methods
		/// for normalizing data (typically point coordinates). When dealing with
		/// data that can exceed floating point resolution sometimes is it best
		/// to normalize that data based on the current camera view such that
		/// what is seen will be in the sweet spot for floating point resolution.
		/// Input datasets may be double precision but the rendering engine
		/// is currently single precision which also can lead to these issues.
		/// See vtkOpenGLVertexBufferObject for related information.
		/// </summary>
		// Token: 0x060021AE RID: 8622 RVA: 0x00032C84 File Offset: 0x00030E84
		public virtual void GetNearPlaneShift(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkCamera.vtkCamera_GetNearPlaneShift_41(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060021AF RID: 8623
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_GetNearPlaneShift_42(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// The following methods are used to support view dependent methods
		/// for normalizing data (typically point coordinates). When dealing with
		/// data that can exceed floating point resolution sometimes is it best
		/// to normalize that data based on the current camera view such that
		/// what is seen will be in the sweet spot for floating point resolution.
		/// Input datasets may be double precision but the rendering engine
		/// is currently single precision which also can lead to these issues.
		/// See vtkOpenGLVertexBufferObject for related information.
		/// </summary>
		// Token: 0x060021B0 RID: 8624 RVA: 0x00032C96 File Offset: 0x00030E96
		public virtual void GetNearPlaneShift(IntPtr _arg)
		{
			vtkCamera.vtkCamera_GetNearPlaneShift_42(base.GetCppThis(), _arg);
		}

		// Token: 0x060021B1 RID: 8625
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCamera_GetNumberOfGenerationsFromBase_43(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060021B2 RID: 8626 RVA: 0x00032CA8 File Offset: 0x00030EA8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCamera.vtkCamera_GetNumberOfGenerationsFromBase_43(base.GetCppThis(), type);
		}

		// Token: 0x060021B3 RID: 8627
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCamera_GetNumberOfGenerationsFromBaseType_44([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060021B4 RID: 8628 RVA: 0x00032CC8 File Offset: 0x00030EC8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCamera.vtkCamera_GetNumberOfGenerationsFromBaseType_44(type);
		}

		// Token: 0x060021B5 RID: 8629
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCamera_GetOffAxisClippingAdjustment_45(HandleRef pThis);

		/// <summary>
		/// Get adjustment to clipping thickness, computed by camera based on the
		/// physical size of the screen and the direction to the tracked head/eye.
		/// </summary>
		// Token: 0x060021B6 RID: 8630 RVA: 0x00032CE4 File Offset: 0x00030EE4
		public double GetOffAxisClippingAdjustment()
		{
			return vtkCamera.vtkCamera_GetOffAxisClippingAdjustment_45(base.GetCppThis());
		}

		// Token: 0x060021B7 RID: 8631
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCamera_GetOrientation_46(HandleRef pThis);

		/// <summary>
		/// Get the orientation of the camera.
		/// </summary>
		// Token: 0x060021B8 RID: 8632 RVA: 0x00032D04 File Offset: 0x00030F04
		public double[] GetOrientation()
		{
			IntPtr intPtr = vtkCamera.vtkCamera_GetOrientation_46(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060021B9 RID: 8633
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCamera_GetOrientationWXYZ_47(HandleRef pThis);

		/// <summary>
		/// Get the orientation of the camera.
		/// </summary>
		// Token: 0x060021BA RID: 8634 RVA: 0x00032D4C File Offset: 0x00030F4C
		public double[] GetOrientationWXYZ()
		{
			IntPtr intPtr = vtkCamera.vtkCamera_GetOrientationWXYZ_47(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060021BB RID: 8635
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCamera_GetParallelProjection_48(HandleRef pThis);

		/// <summary>
		/// Set/Get the value of the ParallelProjection instance variable. This
		/// determines if the camera should do a perspective or parallel projection.
		/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
		/// is true.
		/// </summary>
		// Token: 0x060021BC RID: 8636 RVA: 0x00032D94 File Offset: 0x00030F94
		public virtual int GetParallelProjection()
		{
			return vtkCamera.vtkCamera_GetParallelProjection_48(base.GetCppThis());
		}

		// Token: 0x060021BD RID: 8637
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCamera_GetParallelScale_49(HandleRef pThis);

		/// <summary>
		/// Set/Get the scaling used for a parallel projection, i.e. the half of the height
		/// of the viewport in world-coordinate distances. The default is 1.
		/// Note that the "scale" parameter works as an "inverse scale" ---
		/// larger numbers produce smaller images.
		/// This method has no effect in perspective projection mode.
		/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
		/// is true.
		/// </summary>
		// Token: 0x060021BE RID: 8638 RVA: 0x00032DB4 File Offset: 0x00030FB4
		public virtual double GetParallelScale()
		{
			return vtkCamera.vtkCamera_GetParallelScale_49(base.GetCppThis());
		}

		// Token: 0x060021BF RID: 8639
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCamera_GetPosition_50(HandleRef pThis);

		/// <summary>
		/// Set/Get the position of the camera in world coordinates.
		/// The default position is (0,0,1).
		/// </summary>
		// Token: 0x060021C0 RID: 8640 RVA: 0x00032DD4 File Offset: 0x00030FD4
		public virtual double[] GetPosition()
		{
			IntPtr intPtr = vtkCamera.vtkCamera_GetPosition_50(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060021C1 RID: 8641
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_GetPosition_51(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the position of the camera in world coordinates.
		/// The default position is (0,0,1).
		/// </summary>
		// Token: 0x060021C2 RID: 8642 RVA: 0x00032E1C File Offset: 0x0003101C
		public virtual void GetPosition(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkCamera.vtkCamera_GetPosition_51(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060021C3 RID: 8643
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_GetPosition_52(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the position of the camera in world coordinates.
		/// The default position is (0,0,1).
		/// </summary>
		// Token: 0x060021C4 RID: 8644 RVA: 0x00032E2E File Offset: 0x0003102E
		public virtual void GetPosition(IntPtr _arg)
		{
			vtkCamera.vtkCamera_GetPosition_52(base.GetCppThis(), _arg);
		}

		// Token: 0x060021C5 RID: 8645
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCamera_GetProjectionTransformMatrix_53(HandleRef pThis, double aspect, double nearz, double farz, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the projection transform matrix, which converts from camera
		/// coordinates to viewport coordinates.  The 'aspect' is the
		/// width/height for the viewport, and the nearz and farz are the
		/// Z-buffer values that map to the near and far clipping planes.
		/// The viewport coordinates of a point located inside the frustum are in the
		/// range ([-1,+1],[-1,+1],[nearz,farz]).
		/// aspect is ignored if UseExplicitAspectRatio is true.
		/// @sa ExplicitProjectionTransformMatrix
		/// </summary>
		// Token: 0x060021C6 RID: 8646 RVA: 0x00032E40 File Offset: 0x00031040
		public virtual vtkMatrix4x4 GetProjectionTransformMatrix(double aspect, double nearz, double farz)
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCamera.vtkCamera_GetProjectionTransformMatrix_53(base.GetCppThis(), aspect, nearz, farz, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrix4x = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrix4x.Register(null);
				}
			}
			return vtkMatrix4x;
		}

		// Token: 0x060021C7 RID: 8647
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCamera_GetProjectionTransformMatrix_54(HandleRef pThis, HandleRef ren, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the projection transform matrix, which converts from camera
		/// coordinates to viewport coordinates. This method computes
		/// the aspect, nearz and farz, then calls the more specific
		/// signature of GetCompositeProjectionTransformMatrix
		/// @sa ExplicitProjectionTransformMatrix
		/// </summary>
		// Token: 0x060021C8 RID: 8648 RVA: 0x00032EB4 File Offset: 0x000310B4
		public virtual vtkMatrix4x4 GetProjectionTransformMatrix(vtkRenderer ren)
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCamera.vtkCamera_GetProjectionTransformMatrix_54(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrix4x = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrix4x.Register(null);
				}
			}
			return vtkMatrix4x;
		}

		// Token: 0x060021C9 RID: 8649
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCamera_GetProjectionTransformObject_55(HandleRef pThis, double aspect, double nearz, double farz, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the projection transform matrix, which converts from camera
		/// coordinates to viewport coordinates. The 'aspect' is the
		/// width/height for the viewport, and the nearz and farz are the
		/// Z-buffer values that map to the near and far clipping planes.
		/// The viewport coordinates of a point located inside the frustum are in the
		/// range ([-1,+1],[-1,+1],[nearz,farz]).
		/// aspect is ignored if UseExplicitAspectRatio is true.
		/// @sa ExplicitProjectionTransformMatrix
		/// </summary>
		// Token: 0x060021CA RID: 8650 RVA: 0x00032F3C File Offset: 0x0003113C
		public virtual vtkPerspectiveTransform GetProjectionTransformObject(double aspect, double nearz, double farz)
		{
			vtkPerspectiveTransform vtkPerspectiveTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCamera.vtkCamera_GetProjectionTransformObject_55(base.GetCppThis(), aspect, nearz, farz, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060021CB RID: 8651
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCamera_GetRoll_56(HandleRef pThis);

		/// <summary>
		/// Set the roll angle of the camera about the direction of projection.
		/// </summary>
		// Token: 0x060021CC RID: 8652 RVA: 0x00032FB0 File Offset: 0x000311B0
		public double GetRoll()
		{
			return vtkCamera.vtkCamera_GetRoll_56(base.GetCppThis());
		}

		// Token: 0x060021CD RID: 8653
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_GetScissorRect_57(HandleRef pThis, HandleRef scissorRect);

		/// <summary>
		/// Set/Get the vtkRect value of the scissor
		/// </summary>
		// Token: 0x060021CE RID: 8654 RVA: 0x00032FD0 File Offset: 0x000311D0
		public void GetScissorRect(vtkRecti scissorRect)
		{
			vtkCamera.vtkCamera_GetScissorRect_57(base.GetCppThis(), (scissorRect == null) ? default(HandleRef) : scissorRect.GetCppThis());
		}

		// Token: 0x060021CF RID: 8655
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_GetScreenBottomLeft_58(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get top left corner point of the screen.
		/// This will be used only for offaxis frustum calculation.
		/// Default is (-1.0, -1.0, -1.0).
		/// </summary>
		// Token: 0x060021D0 RID: 8656 RVA: 0x00032FFF File Offset: 0x000311FF
		public virtual void GetScreenBottomLeft(IntPtr _arg)
		{
			vtkCamera.vtkCamera_GetScreenBottomLeft_58(base.GetCppThis(), _arg);
		}

		// Token: 0x060021D1 RID: 8657
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCamera_GetScreenBottomLeft_59(HandleRef pThis);

		/// <summary>
		/// Set/Get top left corner point of the screen.
		/// This will be used only for offaxis frustum calculation.
		/// Default is (-1.0, -1.0, -1.0).
		/// </summary>
		// Token: 0x060021D2 RID: 8658 RVA: 0x00033010 File Offset: 0x00031210
		public virtual double[] GetScreenBottomLeft()
		{
			IntPtr intPtr = vtkCamera.vtkCamera_GetScreenBottomLeft_59(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060021D3 RID: 8659
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_GetScreenBottomLeft_60(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get top left corner point of the screen.
		/// This will be used only for offaxis frustum calculation.
		/// Default is (-1.0, -1.0, -1.0).
		/// </summary>
		// Token: 0x060021D4 RID: 8660 RVA: 0x00033058 File Offset: 0x00031258
		public virtual void GetScreenBottomLeft(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkCamera.vtkCamera_GetScreenBottomLeft_60(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060021D5 RID: 8661
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCamera_GetScreenBottomRight_61(HandleRef pThis);

		/// <summary>
		/// Set/Get bottom left corner point of the screen.
		/// This will be used only for offaxis frustum calculation.
		/// Default is (1.0, -1.0, -1.0).
		/// </summary>
		// Token: 0x060021D6 RID: 8662 RVA: 0x0003306C File Offset: 0x0003126C
		public virtual double[] GetScreenBottomRight()
		{
			IntPtr intPtr = vtkCamera.vtkCamera_GetScreenBottomRight_61(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060021D7 RID: 8663
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_GetScreenBottomRight_62(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get bottom left corner point of the screen.
		/// This will be used only for offaxis frustum calculation.
		/// Default is (1.0, -1.0, -1.0).
		/// </summary>
		// Token: 0x060021D8 RID: 8664 RVA: 0x000330B4 File Offset: 0x000312B4
		public virtual void GetScreenBottomRight(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkCamera.vtkCamera_GetScreenBottomRight_62(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060021D9 RID: 8665
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_GetScreenBottomRight_63(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get bottom left corner point of the screen.
		/// This will be used only for offaxis frustum calculation.
		/// Default is (1.0, -1.0, -1.0).
		/// </summary>
		// Token: 0x060021DA RID: 8666 RVA: 0x000330C6 File Offset: 0x000312C6
		public virtual void GetScreenBottomRight(IntPtr _arg)
		{
			vtkCamera.vtkCamera_GetScreenBottomRight_63(base.GetCppThis(), _arg);
		}

		// Token: 0x060021DB RID: 8667
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCamera_GetScreenTopRight_64(HandleRef pThis);

		/// <summary>
		/// Set/Get top right corner point of the screen.
		/// This will be used only for offaxis frustum calculation.
		/// Default is (1.0, 1.0, -1.0).
		/// </summary>
		// Token: 0x060021DC RID: 8668 RVA: 0x000330D8 File Offset: 0x000312D8
		public virtual double[] GetScreenTopRight()
		{
			IntPtr intPtr = vtkCamera.vtkCamera_GetScreenTopRight_64(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060021DD RID: 8669
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_GetScreenTopRight_65(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get top right corner point of the screen.
		/// This will be used only for offaxis frustum calculation.
		/// Default is (1.0, 1.0, -1.0).
		/// </summary>
		// Token: 0x060021DE RID: 8670 RVA: 0x00033120 File Offset: 0x00031320
		public virtual void GetScreenTopRight(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkCamera.vtkCamera_GetScreenTopRight_65(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060021DF RID: 8671
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_GetScreenTopRight_66(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get top right corner point of the screen.
		/// This will be used only for offaxis frustum calculation.
		/// Default is (1.0, 1.0, -1.0).
		/// </summary>
		// Token: 0x060021E0 RID: 8672 RVA: 0x00033132 File Offset: 0x00031332
		public virtual void GetScreenTopRight(IntPtr _arg)
		{
			vtkCamera.vtkCamera_GetScreenTopRight_66(base.GetCppThis(), _arg);
		}

		// Token: 0x060021E1 RID: 8673
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCamera_GetShiftScaleThreshold_67(HandleRef pThis);

		/// <summary>
		/// The following methods are used to support view dependent methods
		/// for normalizing data (typically point coordinates). When dealing with
		/// data that can exceed floating point resolution sometimes is it best
		/// to normalize that data based on the current camera view such that
		/// what is seen will be in the sweet spot for floating point resolution.
		/// Input datasets may be double precision but the rendering engine
		/// is currently single precision which also can lead to these issues.
		/// See vtkOpenGLVertexBufferObject for related information.
		/// </summary>
		// Token: 0x060021E2 RID: 8674 RVA: 0x00033144 File Offset: 0x00031344
		public virtual double GetShiftScaleThreshold()
		{
			return vtkCamera.vtkCamera_GetShiftScaleThreshold_67(base.GetCppThis());
		}

		// Token: 0x060021E3 RID: 8675
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCamera_GetStereo_68(HandleRef pThis);

		/// <summary>
		/// Get the stereo setting
		/// </summary>
		// Token: 0x060021E4 RID: 8676 RVA: 0x00033164 File Offset: 0x00031364
		public virtual int GetStereo()
		{
			return vtkCamera.vtkCamera_GetStereo_68(base.GetCppThis());
		}

		// Token: 0x060021E5 RID: 8677
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCamera_GetThickness_69(HandleRef pThis);

		/// <summary>
		/// Set the distance between clipping planes.  This method adjusts the
		/// far clipping plane to be set a distance 'thickness' beyond the
		/// near clipping plane.
		/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
		/// is true.
		/// </summary>
		// Token: 0x060021E6 RID: 8678 RVA: 0x00033184 File Offset: 0x00031384
		public virtual double GetThickness()
		{
			return vtkCamera.vtkCamera_GetThickness_69(base.GetCppThis());
		}

		// Token: 0x060021E7 RID: 8679
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCamera_GetUseExplicitAspectRatio_70(HandleRef pThis);

		/// <summary>
		/// If true, the ExplicitAspect is used for the projection
		/// transformation, rather than computing it from the renderer.
		/// Default is false.
		/// @{
		/// </summary>
		// Token: 0x060021E8 RID: 8680 RVA: 0x000331A4 File Offset: 0x000313A4
		public virtual bool GetUseExplicitAspectRatio()
		{
			return vtkCamera.vtkCamera_GetUseExplicitAspectRatio_70(base.GetCppThis()) != 0;
		}

		// Token: 0x060021E9 RID: 8681
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCamera_GetUseExplicitProjectionTransformMatrix_71(HandleRef pThis);

		/// <summary>
		/// If true, the ExplicitProjectionTransformMatrix is used for the projection
		/// transformation, rather than computing a transform from internal state.
		/// @{
		/// </summary>
		// Token: 0x060021EA RID: 8682 RVA: 0x000331CC File Offset: 0x000313CC
		public virtual bool GetUseExplicitProjectionTransformMatrix()
		{
			return vtkCamera.vtkCamera_GetUseExplicitProjectionTransformMatrix_71(base.GetCppThis()) != 0;
		}

		// Token: 0x060021EB RID: 8683
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCamera_GetUseHorizontalViewAngle_72(HandleRef pThis);

		/// <summary>
		/// Set/Get the value of the UseHorizontalViewAngle instance variable. If
		/// set, the camera's view angle represents a horizontal view angle, rather
		/// than the default vertical view angle. This is useful if the application
		/// uses a display device which whose specs indicate a particular horizontal
		/// view angle, or if the application varies the window height but wants to
		/// keep the perspective transform unchanges.
		/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
		/// is true.
		/// </summary>
		// Token: 0x060021EC RID: 8684 RVA: 0x000331F4 File Offset: 0x000313F4
		public virtual int GetUseHorizontalViewAngle()
		{
			return vtkCamera.vtkCamera_GetUseHorizontalViewAngle_72(base.GetCppThis());
		}

		// Token: 0x060021ED RID: 8685
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCamera_GetUseOffAxisProjection_73(HandleRef pThis);

		/// <summary>
		/// Set/Get use offaxis frustum.
		/// OffAxis frustum is used for off-axis frustum calculations specifically
		/// for head-tracking with stereo rendering.
		/// For reference see "Generalized Perspective Projection" by Robert Kooima,
		/// 2008.
		/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
		/// is true.
		/// </summary>
		// Token: 0x060021EE RID: 8686 RVA: 0x00033214 File Offset: 0x00031414
		public virtual int GetUseOffAxisProjection()
		{
			return vtkCamera.vtkCamera_GetUseOffAxisProjection_73(base.GetCppThis());
		}

		// Token: 0x060021EF RID: 8687
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCamera_GetUseScissor_74(HandleRef pThis);

		/// <summary>
		/// Enable/Disable the scissor
		/// </summary>
		// Token: 0x060021F0 RID: 8688 RVA: 0x00033234 File Offset: 0x00031434
		public virtual bool GetUseScissor()
		{
			return vtkCamera.vtkCamera_GetUseScissor_74(base.GetCppThis()) != 0;
		}

		// Token: 0x060021F1 RID: 8689
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCamera_GetUserTransform_75(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// In addition to the instance variables such as position and orientation,
		/// you can add an additional transformation for your own use. This
		/// transformation is concatenated to the camera's ProjectionTransform
		/// </summary>
		// Token: 0x060021F2 RID: 8690 RVA: 0x0003325C File Offset: 0x0003145C
		public virtual vtkHomogeneousTransform GetUserTransform()
		{
			vtkHomogeneousTransform vtkHomogeneousTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCamera.vtkCamera_GetUserTransform_75(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060021F3 RID: 8691
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCamera_GetUserViewTransform_76(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// In addition to the instance variables such as position and orientation,
		/// you can add an additional transformation for your own use.  This
		/// transformation is concatenated to the camera's ViewTransform
		/// </summary>
		// Token: 0x060021F4 RID: 8692 RVA: 0x000332CC File Offset: 0x000314CC
		public virtual vtkHomogeneousTransform GetUserViewTransform()
		{
			vtkHomogeneousTransform vtkHomogeneousTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCamera.vtkCamera_GetUserViewTransform_76(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060021F5 RID: 8693
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCamera_GetViewAngle_77(HandleRef pThis);

		/// <summary>
		/// Set/Get the camera view angle, which is the angular height of the
		/// camera view measured in degrees.  The default angle is 30 degrees.
		/// This method has no effect in parallel projection mode.
		/// The formula for setting the angle up for perfect perspective viewing
		/// is: angle = 2*atan((h/2)/d) where h is the height of the RenderWindow
		/// (measured by holding a ruler up to your screen) and d is the
		/// distance from your eyes to the screen.
		/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
		/// is true.
		/// </summary>
		// Token: 0x060021F6 RID: 8694 RVA: 0x0003333C File Offset: 0x0003153C
		public virtual double GetViewAngle()
		{
			return vtkCamera.vtkCamera_GetViewAngle_77(base.GetCppThis());
		}

		// Token: 0x060021F7 RID: 8695
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCamera_GetViewPlaneNormal_78(HandleRef pThis);

		/// <summary>
		/// Get the ViewPlaneNormal.  This vector will point opposite to
		/// the direction of projection, unless you have created a sheared output
		/// view using SetViewShear/SetObliqueAngles.
		/// </summary>
		// Token: 0x060021F8 RID: 8696 RVA: 0x0003335C File Offset: 0x0003155C
		public virtual double[] GetViewPlaneNormal()
		{
			IntPtr intPtr = vtkCamera.vtkCamera_GetViewPlaneNormal_78(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060021F9 RID: 8697
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_GetViewPlaneNormal_79(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Get the ViewPlaneNormal.  This vector will point opposite to
		/// the direction of projection, unless you have created a sheared output
		/// view using SetViewShear/SetObliqueAngles.
		/// </summary>
		// Token: 0x060021FA RID: 8698 RVA: 0x000333A4 File Offset: 0x000315A4
		public virtual void GetViewPlaneNormal(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkCamera.vtkCamera_GetViewPlaneNormal_79(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060021FB RID: 8699
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_GetViewPlaneNormal_80(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get the ViewPlaneNormal.  This vector will point opposite to
		/// the direction of projection, unless you have created a sheared output
		/// view using SetViewShear/SetObliqueAngles.
		/// </summary>
		// Token: 0x060021FC RID: 8700 RVA: 0x000333B6 File Offset: 0x000315B6
		public virtual void GetViewPlaneNormal(IntPtr _arg)
		{
			vtkCamera.vtkCamera_GetViewPlaneNormal_80(base.GetCppThis(), _arg);
		}

		// Token: 0x060021FD RID: 8701
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCamera_GetViewShear_81(HandleRef pThis);

		/// <summary>
		/// Set/get the shear transform of the viewing frustum.  Parameters are
		/// dx/dz, dy/dz, and center.  center is a factor that describes where
		/// to shear around. The distance dshear from the camera where
		/// no shear occurs is given by (dshear = center * FocalDistance).
		/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
		/// is true.
		/// </summary>
		// Token: 0x060021FE RID: 8702 RVA: 0x000333C8 File Offset: 0x000315C8
		public virtual double[] GetViewShear()
		{
			IntPtr intPtr = vtkCamera.vtkCamera_GetViewShear_81(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060021FF RID: 8703
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_GetViewShear_82(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/get the shear transform of the viewing frustum.  Parameters are
		/// dx/dz, dy/dz, and center.  center is a factor that describes where
		/// to shear around. The distance dshear from the camera where
		/// no shear occurs is given by (dshear = center * FocalDistance).
		/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
		/// is true.
		/// </summary>
		// Token: 0x06002200 RID: 8704 RVA: 0x00033410 File Offset: 0x00031610
		public virtual void GetViewShear(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkCamera.vtkCamera_GetViewShear_82(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06002201 RID: 8705
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_GetViewShear_83(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/get the shear transform of the viewing frustum.  Parameters are
		/// dx/dz, dy/dz, and center.  center is a factor that describes where
		/// to shear around. The distance dshear from the camera where
		/// no shear occurs is given by (dshear = center * FocalDistance).
		/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
		/// is true.
		/// </summary>
		// Token: 0x06002202 RID: 8706 RVA: 0x00033422 File Offset: 0x00031622
		public virtual void GetViewShear(IntPtr _arg)
		{
			vtkCamera.vtkCamera_GetViewShear_83(base.GetCppThis(), _arg);
		}

		// Token: 0x06002203 RID: 8707
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCamera_GetViewTransformMatrix_84(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// For backward compatibility. Use GetModelViewTransformMatrix() now.
		/// Return the matrix of the view transform.
		/// The ViewTransform depends on only three ivars:  the Position, the
		/// FocalPoint, and the ViewUp vector.  All the other methods are there
		/// simply for the sake of the users' convenience.
		/// </summary>
		// Token: 0x06002204 RID: 8708 RVA: 0x00033434 File Offset: 0x00031634
		public virtual vtkMatrix4x4 GetViewTransformMatrix()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCamera.vtkCamera_GetViewTransformMatrix_84(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrix4x = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrix4x.Register(null);
				}
			}
			return vtkMatrix4x;
		}

		// Token: 0x06002205 RID: 8709
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCamera_GetViewTransformObject_85(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// For backward compatibility. Use GetModelViewTransformObject() now.
		/// Return the view transform.
		/// If the camera's ModelTransformMatrix is identity then
		/// the ViewTransform depends on only three ivars:
		/// the Position, the FocalPoint, and the ViewUp vector.
		/// All the other methods are there simply for the sake of the users'
		/// convenience.
		/// </summary>
		// Token: 0x06002206 RID: 8710 RVA: 0x000334A4 File Offset: 0x000316A4
		public virtual vtkTransform GetViewTransformObject()
		{
			vtkTransform vtkTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCamera.vtkCamera_GetViewTransformObject_85(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransform = (vtkTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransform.Register(null);
				}
			}
			return vtkTransform;
		}

		// Token: 0x06002207 RID: 8711
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCamera_GetViewUp_86(HandleRef pThis);

		/// <summary>
		/// Set/Get the view up direction for the camera.  The default
		/// is (0,1,0).
		/// </summary>
		// Token: 0x06002208 RID: 8712 RVA: 0x00033514 File Offset: 0x00031714
		public virtual double[] GetViewUp()
		{
			IntPtr intPtr = vtkCamera.vtkCamera_GetViewUp_86(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06002209 RID: 8713
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_GetViewUp_87(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the view up direction for the camera.  The default
		/// is (0,1,0).
		/// </summary>
		// Token: 0x0600220A RID: 8714 RVA: 0x0003355C File Offset: 0x0003175C
		public virtual void GetViewUp(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkCamera.vtkCamera_GetViewUp_87(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600220B RID: 8715
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_GetViewUp_88(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the view up direction for the camera.  The default
		/// is (0,1,0).
		/// </summary>
		// Token: 0x0600220C RID: 8716 RVA: 0x0003356E File Offset: 0x0003176E
		public virtual void GetViewUp(IntPtr _arg)
		{
			vtkCamera.vtkCamera_GetViewUp_88(base.GetCppThis(), _arg);
		}

		// Token: 0x0600220D RID: 8717
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkCamera_GetViewingRaysMTime_89(HandleRef pThis);

		/// <summary>
		/// Return the MTime that concerns recomputing the view rays of the camera.
		/// </summary>
		// Token: 0x0600220E RID: 8718 RVA: 0x00033580 File Offset: 0x00031780
		public ulong GetViewingRaysMTime()
		{
			return vtkCamera.vtkCamera_GetViewingRaysMTime_89(base.GetCppThis());
		}

		// Token: 0x0600220F RID: 8719
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCamera_GetWindowCenter_90(HandleRef pThis);

		/// <summary>
		/// Set/Get the center of the window in viewport coordinates.
		/// The viewport coordinate range is ([-1,+1],[-1,+1]).  This method
		/// is for if you have one window which consists of several viewports,
		/// or if you have several screens which you want to act together as
		/// one large screen.
		/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
		/// is true.
		/// </summary>
		// Token: 0x06002210 RID: 8720 RVA: 0x000335A0 File Offset: 0x000317A0
		public virtual double[] GetWindowCenter()
		{
			IntPtr intPtr = vtkCamera.vtkCamera_GetWindowCenter_90(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06002211 RID: 8721
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_GetWindowCenter_91(HandleRef pThis, ref double _arg1, ref double _arg2);

		/// <summary>
		/// Set/Get the center of the window in viewport coordinates.
		/// The viewport coordinate range is ([-1,+1],[-1,+1]).  This method
		/// is for if you have one window which consists of several viewports,
		/// or if you have several screens which you want to act together as
		/// one large screen.
		/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
		/// is true.
		/// </summary>
		// Token: 0x06002212 RID: 8722 RVA: 0x000335E8 File Offset: 0x000317E8
		public virtual void GetWindowCenter(ref double _arg1, ref double _arg2)
		{
			vtkCamera.vtkCamera_GetWindowCenter_91(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06002213 RID: 8723
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_GetWindowCenter_92(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the center of the window in viewport coordinates.
		/// The viewport coordinate range is ([-1,+1],[-1,+1]).  This method
		/// is for if you have one window which consists of several viewports,
		/// or if you have several screens which you want to act together as
		/// one large screen.
		/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
		/// is true.
		/// </summary>
		// Token: 0x06002214 RID: 8724 RVA: 0x000335F9 File Offset: 0x000317F9
		public virtual void GetWindowCenter(IntPtr _arg)
		{
			vtkCamera.vtkCamera_GetWindowCenter_92(base.GetCppThis(), _arg);
		}

		// Token: 0x06002215 RID: 8725
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCamera_IsA_93(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002216 RID: 8726 RVA: 0x0003360C File Offset: 0x0003180C
		public override int IsA(string type)
		{
			return vtkCamera.vtkCamera_IsA_93(base.GetCppThis(), type);
		}

		// Token: 0x06002217 RID: 8727
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCamera_IsTypeOf_94([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002218 RID: 8728 RVA: 0x0003362C File Offset: 0x0003182C
		public new static int IsTypeOf(string type)
		{
			return vtkCamera.vtkCamera_IsTypeOf_94(type);
		}

		// Token: 0x06002219 RID: 8729
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCamera_NewInstance_96(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600221A RID: 8730 RVA: 0x00033648 File Offset: 0x00031848
		public new vtkCamera NewInstance()
		{
			vtkCamera result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCamera.vtkCamera_NewInstance_96(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCamera)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600221B RID: 8731
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_OrthogonalizeViewUp_97(HandleRef pThis);

		/// <summary>
		/// Recompute the ViewUp vector to force it to be perpendicular to
		/// camera-&gt;focalpoint vector.  Unless you are going to use
		/// Yaw or Azimuth on the camera, there is no need to do this.
		/// </summary>
		// Token: 0x0600221C RID: 8732 RVA: 0x000336A2 File Offset: 0x000318A2
		public void OrthogonalizeViewUp()
		{
			vtkCamera.vtkCamera_OrthogonalizeViewUp_97(base.GetCppThis());
		}

		// Token: 0x0600221D RID: 8733
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_ParallelProjectionOff_98(HandleRef pThis);

		/// <summary>
		/// Set/Get the value of the ParallelProjection instance variable. This
		/// determines if the camera should do a perspective or parallel projection.
		/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
		/// is true.
		/// </summary>
		// Token: 0x0600221E RID: 8734 RVA: 0x000336B1 File Offset: 0x000318B1
		public virtual void ParallelProjectionOff()
		{
			vtkCamera.vtkCamera_ParallelProjectionOff_98(base.GetCppThis());
		}

		// Token: 0x0600221F RID: 8735
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_ParallelProjectionOn_99(HandleRef pThis);

		/// <summary>
		/// Set/Get the value of the ParallelProjection instance variable. This
		/// determines if the camera should do a perspective or parallel projection.
		/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
		/// is true.
		/// </summary>
		// Token: 0x06002220 RID: 8736 RVA: 0x000336C0 File Offset: 0x000318C0
		public virtual void ParallelProjectionOn()
		{
			vtkCamera.vtkCamera_ParallelProjectionOn_99(base.GetCppThis());
		}

		// Token: 0x06002221 RID: 8737
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_Pitch_100(HandleRef pThis, double angle);

		/// <summary>
		/// Rotate the focal point about the cross product of the view up vector
		/// and the direction of projection, using the camera's position as the
		/// center of rotation.  The result is a vertical rotation of the camera.
		/// </summary>
		// Token: 0x06002222 RID: 8738 RVA: 0x000336CF File Offset: 0x000318CF
		public void Pitch(double angle)
		{
			vtkCamera.vtkCamera_Pitch_100(base.GetCppThis(), angle);
		}

		// Token: 0x06002223 RID: 8739
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_Render_101(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// This method causes the camera to set up whatever is required for
		/// viewing the scene. This is actually handled by an subclass of
		/// vtkCamera, which is created through New()
		/// </summary>
		// Token: 0x06002224 RID: 8740 RVA: 0x000336E0 File Offset: 0x000318E0
		public virtual void Render(vtkRenderer arg0)
		{
			vtkCamera.vtkCamera_Render_101(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002225 RID: 8741
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_Roll_102(HandleRef pThis, double angle);

		/// <summary>
		/// Rotate the camera about the direction of projection.  This will
		/// spin the camera about its axis.
		/// </summary>
		// Token: 0x06002226 RID: 8742 RVA: 0x0003370F File Offset: 0x0003190F
		public void Roll(double angle)
		{
			vtkCamera.vtkCamera_Roll_102(base.GetCppThis(), angle);
		}

		// Token: 0x06002227 RID: 8743
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCamera_SafeDownCast_103(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002228 RID: 8744 RVA: 0x00033720 File Offset: 0x00031920
		public new static vtkCamera SafeDownCast(vtkObjectBase o)
		{
			vtkCamera vtkCamera = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCamera.vtkCamera_SafeDownCast_103((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCamera = (vtkCamera)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCamera.Register(null);
				}
			}
			return vtkCamera;
		}

		// Token: 0x06002229 RID: 8745
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_SetClippingRange_104(HandleRef pThis, double dNear, double dFar);

		/// <summary>
		/// Set/Get the location of the near and far clipping planes along the
		/// direction of projection.  Both of these values must be positive.
		/// How the clipping planes are set can have a large impact on how
		/// well z-buffering works.  In particular the front clipping
		/// plane can make a very big difference. Setting it to 0.01 when it
		/// really could be 1.0 can have a big impact on your z-buffer resolution
		/// farther away.  The default clipping range is (0.1,1000).
		/// Clipping distance is measured in world coordinate unless a scale factor
		/// exists in camera's ModelTransformMatrix.
		/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
		/// is true.
		/// </summary>
		// Token: 0x0600222A RID: 8746 RVA: 0x0003379F File Offset: 0x0003199F
		public void SetClippingRange(double dNear, double dFar)
		{
			vtkCamera.vtkCamera_SetClippingRange_104(base.GetCppThis(), dNear, dFar);
		}

		// Token: 0x0600222B RID: 8747
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_SetClippingRange_105(HandleRef pThis, IntPtr a);

		/// <summary>
		/// Set/Get the location of the near and far clipping planes along the
		/// direction of projection.  Both of these values must be positive.
		/// How the clipping planes are set can have a large impact on how
		/// well z-buffering works.  In particular the front clipping
		/// plane can make a very big difference. Setting it to 0.01 when it
		/// really could be 1.0 can have a big impact on your z-buffer resolution
		/// farther away.  The default clipping range is (0.1,1000).
		/// Clipping distance is measured in world coordinate unless a scale factor
		/// exists in camera's ModelTransformMatrix.
		/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
		/// is true.
		/// </summary>
		// Token: 0x0600222C RID: 8748 RVA: 0x000337B0 File Offset: 0x000319B0
		public void SetClippingRange(IntPtr a)
		{
			vtkCamera.vtkCamera_SetClippingRange_105(base.GetCppThis(), a);
		}

		// Token: 0x0600222D RID: 8749
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_SetDistance_106(HandleRef pThis, double arg0);

		/// <summary>
		/// Move the focal point so that it is the specified distance from
		/// the camera position.  This distance must be positive.
		/// </summary>
		// Token: 0x0600222E RID: 8750 RVA: 0x000337C0 File Offset: 0x000319C0
		public void SetDistance(double arg0)
		{
			vtkCamera.vtkCamera_SetDistance_106(base.GetCppThis(), arg0);
		}

		// Token: 0x0600222F RID: 8751
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_SetExplicitAspectRatio_107(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/get an explicit aspect to use, rather than computing it from the renderer.
		/// Only used when UseExplicitAspect is true.
		/// @{
		/// </summary>
		// Token: 0x06002230 RID: 8752 RVA: 0x000337D0 File Offset: 0x000319D0
		public virtual void SetExplicitAspectRatio(double _arg)
		{
			vtkCamera.vtkCamera_SetExplicitAspectRatio_107(base.GetCppThis(), _arg);
		}

		// Token: 0x06002231 RID: 8753
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_SetExplicitProjectionTransformMatrix_108(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/get an explicit 4x4 projection matrix to use, rather than computing
		/// one from other state variables. Only used when
		/// UseExplicitProjectionTransformMatrix is true.
		/// @{
		/// </summary>
		// Token: 0x06002232 RID: 8754 RVA: 0x000337E0 File Offset: 0x000319E0
		public virtual void SetExplicitProjectionTransformMatrix(vtkMatrix4x4 arg0)
		{
			vtkCamera.vtkCamera_SetExplicitProjectionTransformMatrix_108(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002233 RID: 8755
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_SetEyeAngle_109(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the separation between eyes (in degrees). This is used
		/// when generating stereo images.
		/// </summary>
		// Token: 0x06002234 RID: 8756 RVA: 0x0003380F File Offset: 0x00031A0F
		public virtual void SetEyeAngle(double _arg)
		{
			vtkCamera.vtkCamera_SetEyeAngle_109(base.GetCppThis(), _arg);
		}

		// Token: 0x06002235 RID: 8757
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_SetEyePosition_110(HandleRef pThis, IntPtr eyePosition);

		/// <summary>
		/// Set/Get the eye position (center point between two eyes).
		/// This is a convenience function that sets the translation
		/// component of EyeTransformMatrix.
		/// This will be used only for offaxis frustum calculation.
		/// </summary>
		// Token: 0x06002236 RID: 8758 RVA: 0x0003381F File Offset: 0x00031A1F
		public void SetEyePosition(IntPtr eyePosition)
		{
			vtkCamera.vtkCamera_SetEyePosition_110(base.GetCppThis(), eyePosition);
		}

		// Token: 0x06002237 RID: 8759
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_SetEyeSeparation_111(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get distance between the eyes.
		/// This will be used only for offaxis frustum calculation.
		/// Default is 0.06.
		/// </summary>
		// Token: 0x06002238 RID: 8760 RVA: 0x0003382F File Offset: 0x00031A2F
		public virtual void SetEyeSeparation(double _arg)
		{
			vtkCamera.vtkCamera_SetEyeSeparation_111(base.GetCppThis(), _arg);
		}

		// Token: 0x06002239 RID: 8761
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_SetEyeTransformMatrix_112(HandleRef pThis, HandleRef matrix);

		/// <summary>
		/// Set/Get eye transformation matrix.
		/// This is the transformation matrix for the point between eyes.
		/// This will be used only for offaxis frustum calculation.
		/// Default is identity.
		/// </summary>
		// Token: 0x0600223A RID: 8762 RVA: 0x00033840 File Offset: 0x00031A40
		public void SetEyeTransformMatrix(vtkMatrix4x4 matrix)
		{
			vtkCamera.vtkCamera_SetEyeTransformMatrix_112(base.GetCppThis(), (matrix == null) ? default(HandleRef) : matrix.GetCppThis());
		}

		// Token: 0x0600223B RID: 8763
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_SetEyeTransformMatrix_113(HandleRef pThis, IntPtr elements);

		/// <summary>
		/// Set/Get eye transformation matrix.
		/// This is the transformation matrix for the point between eyes.
		/// This will be used only for offaxis frustum calculation.
		/// Default is identity.
		/// </summary>
		// Token: 0x0600223C RID: 8764 RVA: 0x0003386F File Offset: 0x00031A6F
		public void SetEyeTransformMatrix(IntPtr elements)
		{
			vtkCamera.vtkCamera_SetEyeTransformMatrix_113(base.GetCppThis(), elements);
		}

		// Token: 0x0600223D RID: 8765
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_SetFocalDisk_114(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the size of the cameras lens in world coordinates. This is only
		/// used when the renderer is doing focal depth rendering. When that is
		/// being done the size of the focal disk will effect how significant the
		/// depth effects will be.
		/// </summary>
		// Token: 0x0600223E RID: 8766 RVA: 0x0003387F File Offset: 0x00031A7F
		public virtual void SetFocalDisk(double _arg)
		{
			vtkCamera.vtkCamera_SetFocalDisk_114(base.GetCppThis(), _arg);
		}

		// Token: 0x0600223F RID: 8767
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_SetFocalDistance_115(HandleRef pThis, double _arg);

		/// <summary>
		/// Sets the distance at which rendering is in focus. This is currently
		/// only used by the ray tracing renderers. 0 (default) disables
		/// ray traced depth of field.
		/// Not to be confused with FocalPoint that is the camera target and
		/// is centered on screen. Using a separate focal distance property
		/// enables out-of-focus areas anywhere on screen.
		/// </summary>
		// Token: 0x06002240 RID: 8768 RVA: 0x0003388F File Offset: 0x00031A8F
		public virtual void SetFocalDistance(double _arg)
		{
			vtkCamera.vtkCamera_SetFocalDistance_115(base.GetCppThis(), _arg);
		}

		// Token: 0x06002241 RID: 8769
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_SetFocalPoint_116(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Set/Get the focal of the camera in world coordinates.
		/// The default focal point is the origin.
		/// </summary>
		// Token: 0x06002242 RID: 8770 RVA: 0x0003389F File Offset: 0x00031A9F
		public void SetFocalPoint(double x, double y, double z)
		{
			vtkCamera.vtkCamera_SetFocalPoint_116(base.GetCppThis(), x, y, z);
		}

		// Token: 0x06002243 RID: 8771
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_SetFocalPoint_117(HandleRef pThis, IntPtr a);

		/// <summary>
		/// Set/Get the focal of the camera in world coordinates.
		/// The default focal point is the origin.
		/// </summary>
		// Token: 0x06002244 RID: 8772 RVA: 0x000338B1 File Offset: 0x00031AB1
		public void SetFocalPoint(IntPtr a)
		{
			vtkCamera.vtkCamera_SetFocalPoint_117(base.GetCppThis(), a);
		}

		// Token: 0x06002245 RID: 8773
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_SetFreezeFocalPoint_118(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get the value of the FreezeDolly instance variable. This
		/// determines if the camera should move the focal point with the camera position.
		/// HACK!!!
		/// </summary>
		// Token: 0x06002246 RID: 8774 RVA: 0x000338C1 File Offset: 0x00031AC1
		public virtual void SetFreezeFocalPoint(bool _arg)
		{
			vtkCamera.vtkCamera_SetFreezeFocalPoint_118(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06002247 RID: 8775
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_SetInformation_119(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the information object associated with this camera.
		/// </summary>
		// Token: 0x06002248 RID: 8776 RVA: 0x000338DC File Offset: 0x00031ADC
		public virtual void SetInformation(vtkInformation arg0)
		{
			vtkCamera.vtkCamera_SetInformation_119(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002249 RID: 8777
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_SetLeftEye_120(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the Left Eye setting
		/// </summary>
		// Token: 0x0600224A RID: 8778 RVA: 0x0003390B File Offset: 0x00031B0B
		public virtual void SetLeftEye(int _arg)
		{
			vtkCamera.vtkCamera_SetLeftEye_120(base.GetCppThis(), _arg);
		}

		// Token: 0x0600224B RID: 8779
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_SetModelTransformMatrix_121(HandleRef pThis, HandleRef matrix);

		/// <summary>
		/// Set/Get model transformation matrix.
		/// This matrix could be used for model related transformations
		/// such as scale, shear, rotations and translations.
		/// </summary>
		// Token: 0x0600224C RID: 8780 RVA: 0x0003391C File Offset: 0x00031B1C
		public void SetModelTransformMatrix(vtkMatrix4x4 matrix)
		{
			vtkCamera.vtkCamera_SetModelTransformMatrix_121(base.GetCppThis(), (matrix == null) ? default(HandleRef) : matrix.GetCppThis());
		}

		// Token: 0x0600224D RID: 8781
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_SetModelTransformMatrix_122(HandleRef pThis, IntPtr elements);

		/// <summary>
		/// Set/Get model transformation matrix.
		/// This matrix could be used for model related transformations
		/// such as scale, shear, rotations and translations.
		/// </summary>
		// Token: 0x0600224E RID: 8782 RVA: 0x0003394B File Offset: 0x00031B4B
		public void SetModelTransformMatrix(IntPtr elements)
		{
			vtkCamera.vtkCamera_SetModelTransformMatrix_122(base.GetCppThis(), elements);
		}

		// Token: 0x0600224F RID: 8783
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_SetObliqueAngles_123(HandleRef pThis, double alpha, double beta);

		/// <summary>
		/// Get/Set the oblique viewing angles.  The first angle, alpha, is the
		/// angle (measured from the horizontal) that rays along the direction
		/// of projection will follow once projected onto the 2D screen.
		/// The second angle, beta, is the angle between the view plane and
		/// the direction of projection.  This creates a shear transform
		/// x' = x + dz*cos(alpha)/tan(beta), y' = dz*sin(alpha)/tan(beta)
		/// where dz is the distance of the point from the focal plane.
		/// The angles are (45,90) by default.  Oblique projections
		/// commonly use (30,63.435).
		/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
		/// is true.
		/// </summary>
		// Token: 0x06002250 RID: 8784 RVA: 0x0003395B File Offset: 0x00031B5B
		public void SetObliqueAngles(double alpha, double beta)
		{
			vtkCamera.vtkCamera_SetObliqueAngles_123(base.GetCppThis(), alpha, beta);
		}

		// Token: 0x06002251 RID: 8785
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_SetParallelProjection_124(HandleRef pThis, int flag);

		/// <summary>
		/// Set/Get the value of the ParallelProjection instance variable. This
		/// determines if the camera should do a perspective or parallel projection.
		/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
		/// is true.
		/// </summary>
		// Token: 0x06002252 RID: 8786 RVA: 0x0003396C File Offset: 0x00031B6C
		public void SetParallelProjection(int flag)
		{
			vtkCamera.vtkCamera_SetParallelProjection_124(base.GetCppThis(), flag);
		}

		// Token: 0x06002253 RID: 8787
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_SetParallelScale_125(HandleRef pThis, double scale);

		/// <summary>
		/// Set/Get the scaling used for a parallel projection, i.e. the half of the height
		/// of the viewport in world-coordinate distances. The default is 1.
		/// Note that the "scale" parameter works as an "inverse scale" ---
		/// larger numbers produce smaller images.
		/// This method has no effect in perspective projection mode.
		/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
		/// is true.
		/// </summary>
		// Token: 0x06002254 RID: 8788 RVA: 0x0003397C File Offset: 0x00031B7C
		public void SetParallelScale(double scale)
		{
			vtkCamera.vtkCamera_SetParallelScale_125(base.GetCppThis(), scale);
		}

		// Token: 0x06002255 RID: 8789
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_SetPosition_126(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Set/Get the position of the camera in world coordinates.
		/// The default position is (0,0,1).
		/// </summary>
		// Token: 0x06002256 RID: 8790 RVA: 0x0003398C File Offset: 0x00031B8C
		public void SetPosition(double x, double y, double z)
		{
			vtkCamera.vtkCamera_SetPosition_126(base.GetCppThis(), x, y, z);
		}

		// Token: 0x06002257 RID: 8791
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_SetPosition_127(HandleRef pThis, IntPtr a);

		/// <summary>
		/// Set/Get the position of the camera in world coordinates.
		/// The default position is (0,0,1).
		/// </summary>
		// Token: 0x06002258 RID: 8792 RVA: 0x0003399E File Offset: 0x00031B9E
		public void SetPosition(IntPtr a)
		{
			vtkCamera.vtkCamera_SetPosition_127(base.GetCppThis(), a);
		}

		// Token: 0x06002259 RID: 8793
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_SetRoll_128(HandleRef pThis, double angle);

		/// <summary>
		/// Set the roll angle of the camera about the direction of projection.
		/// </summary>
		// Token: 0x0600225A RID: 8794 RVA: 0x000339AE File Offset: 0x00031BAE
		public void SetRoll(double angle)
		{
			vtkCamera.vtkCamera_SetRoll_128(base.GetCppThis(), angle);
		}

		// Token: 0x0600225B RID: 8795
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_SetScissorRect_129(HandleRef pThis, HandleRef scissorRect);

		/// <summary>
		/// Set/Get the vtkRect value of the scissor
		/// </summary>
		// Token: 0x0600225C RID: 8796 RVA: 0x000339C0 File Offset: 0x00031BC0
		public void SetScissorRect(vtkRecti scissorRect)
		{
			vtkCamera.vtkCamera_SetScissorRect_129(base.GetCppThis(), (scissorRect == null) ? default(HandleRef) : scissorRect.GetCppThis());
		}

		// Token: 0x0600225D RID: 8797
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_SetScreenBottomLeft_130(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get top left corner point of the screen.
		/// This will be used only for offaxis frustum calculation.
		/// Default is (-1.0, -1.0, -1.0).
		/// </summary>
		// Token: 0x0600225E RID: 8798 RVA: 0x000339EF File Offset: 0x00031BEF
		public virtual void SetScreenBottomLeft(double _arg1, double _arg2, double _arg3)
		{
			vtkCamera.vtkCamera_SetScreenBottomLeft_130(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600225F RID: 8799
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_SetScreenBottomLeft_131(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get top left corner point of the screen.
		/// This will be used only for offaxis frustum calculation.
		/// Default is (-1.0, -1.0, -1.0).
		/// </summary>
		// Token: 0x06002260 RID: 8800 RVA: 0x00033A01 File Offset: 0x00031C01
		public virtual void SetScreenBottomLeft(IntPtr _arg)
		{
			vtkCamera.vtkCamera_SetScreenBottomLeft_131(base.GetCppThis(), _arg);
		}

		// Token: 0x06002261 RID: 8801
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_SetScreenBottomRight_132(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get bottom left corner point of the screen.
		/// This will be used only for offaxis frustum calculation.
		/// Default is (1.0, -1.0, -1.0).
		/// </summary>
		// Token: 0x06002262 RID: 8802 RVA: 0x00033A11 File Offset: 0x00031C11
		public virtual void SetScreenBottomRight(double _arg1, double _arg2, double _arg3)
		{
			vtkCamera.vtkCamera_SetScreenBottomRight_132(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06002263 RID: 8803
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_SetScreenBottomRight_133(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get bottom left corner point of the screen.
		/// This will be used only for offaxis frustum calculation.
		/// Default is (1.0, -1.0, -1.0).
		/// </summary>
		// Token: 0x06002264 RID: 8804 RVA: 0x00033A23 File Offset: 0x00031C23
		public virtual void SetScreenBottomRight(IntPtr _arg)
		{
			vtkCamera.vtkCamera_SetScreenBottomRight_133(base.GetCppThis(), _arg);
		}

		// Token: 0x06002265 RID: 8805
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_SetScreenTopRight_134(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get top right corner point of the screen.
		/// This will be used only for offaxis frustum calculation.
		/// Default is (1.0, 1.0, -1.0).
		/// </summary>
		// Token: 0x06002266 RID: 8806 RVA: 0x00033A33 File Offset: 0x00031C33
		public virtual void SetScreenTopRight(double _arg1, double _arg2, double _arg3)
		{
			vtkCamera.vtkCamera_SetScreenTopRight_134(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06002267 RID: 8807
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_SetScreenTopRight_135(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get top right corner point of the screen.
		/// This will be used only for offaxis frustum calculation.
		/// Default is (1.0, 1.0, -1.0).
		/// </summary>
		// Token: 0x06002268 RID: 8808 RVA: 0x00033A45 File Offset: 0x00031C45
		public virtual void SetScreenTopRight(IntPtr _arg)
		{
			vtkCamera.vtkCamera_SetScreenTopRight_135(base.GetCppThis(), _arg);
		}

		// Token: 0x06002269 RID: 8809
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_SetShiftScaleThreshold_136(HandleRef pThis, double _arg);

		/// <summary>
		/// The following methods are used to support view dependent methods
		/// for normalizing data (typically point coordinates). When dealing with
		/// data that can exceed floating point resolution sometimes is it best
		/// to normalize that data based on the current camera view such that
		/// what is seen will be in the sweet spot for floating point resolution.
		/// Input datasets may be double precision but the rendering engine
		/// is currently single precision which also can lead to these issues.
		/// See vtkOpenGLVertexBufferObject for related information.
		/// </summary>
		// Token: 0x0600226A RID: 8810 RVA: 0x00033A55 File Offset: 0x00031C55
		public virtual void SetShiftScaleThreshold(double _arg)
		{
			vtkCamera.vtkCamera_SetShiftScaleThreshold_136(base.GetCppThis(), _arg);
		}

		// Token: 0x0600226B RID: 8811
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_SetThickness_137(HandleRef pThis, double arg0);

		/// <summary>
		/// Set the distance between clipping planes.  This method adjusts the
		/// far clipping plane to be set a distance 'thickness' beyond the
		/// near clipping plane.
		/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
		/// is true.
		/// </summary>
		// Token: 0x0600226C RID: 8812 RVA: 0x00033A65 File Offset: 0x00031C65
		public void SetThickness(double arg0)
		{
			vtkCamera.vtkCamera_SetThickness_137(base.GetCppThis(), arg0);
		}

		// Token: 0x0600226D RID: 8813
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_SetUseExplicitAspectRatio_138(HandleRef pThis, byte _arg);

		/// <summary>
		/// If true, the ExplicitAspect is used for the projection
		/// transformation, rather than computing it from the renderer.
		/// Default is false.
		/// @{
		/// </summary>
		// Token: 0x0600226E RID: 8814 RVA: 0x00033A75 File Offset: 0x00031C75
		public virtual void SetUseExplicitAspectRatio(bool _arg)
		{
			vtkCamera.vtkCamera_SetUseExplicitAspectRatio_138(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600226F RID: 8815
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_SetUseExplicitProjectionTransformMatrix_139(HandleRef pThis, byte _arg);

		/// <summary>
		/// If true, the ExplicitProjectionTransformMatrix is used for the projection
		/// transformation, rather than computing a transform from internal state.
		/// @{
		/// </summary>
		// Token: 0x06002270 RID: 8816 RVA: 0x00033A8D File Offset: 0x00031C8D
		public virtual void SetUseExplicitProjectionTransformMatrix(bool _arg)
		{
			vtkCamera.vtkCamera_SetUseExplicitProjectionTransformMatrix_139(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06002271 RID: 8817
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_SetUseHorizontalViewAngle_140(HandleRef pThis, int flag);

		/// <summary>
		/// Set/Get the value of the UseHorizontalViewAngle instance variable. If
		/// set, the camera's view angle represents a horizontal view angle, rather
		/// than the default vertical view angle. This is useful if the application
		/// uses a display device which whose specs indicate a particular horizontal
		/// view angle, or if the application varies the window height but wants to
		/// keep the perspective transform unchanges.
		/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
		/// is true.
		/// </summary>
		// Token: 0x06002272 RID: 8818 RVA: 0x00033AA5 File Offset: 0x00031CA5
		public void SetUseHorizontalViewAngle(int flag)
		{
			vtkCamera.vtkCamera_SetUseHorizontalViewAngle_140(base.GetCppThis(), flag);
		}

		// Token: 0x06002273 RID: 8819
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_SetUseOffAxisProjection_141(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get use offaxis frustum.
		/// OffAxis frustum is used for off-axis frustum calculations specifically
		/// for head-tracking with stereo rendering.
		/// For reference see "Generalized Perspective Projection" by Robert Kooima,
		/// 2008.
		/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
		/// is true.
		/// </summary>
		// Token: 0x06002274 RID: 8820 RVA: 0x00033AB5 File Offset: 0x00031CB5
		public virtual void SetUseOffAxisProjection(int _arg)
		{
			vtkCamera.vtkCamera_SetUseOffAxisProjection_141(base.GetCppThis(), _arg);
		}

		// Token: 0x06002275 RID: 8821
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_SetUseScissor_142(HandleRef pThis, byte _arg);

		/// <summary>
		/// Enable/Disable the scissor
		/// </summary>
		// Token: 0x06002276 RID: 8822 RVA: 0x00033AC5 File Offset: 0x00031CC5
		public virtual void SetUseScissor(bool _arg)
		{
			vtkCamera.vtkCamera_SetUseScissor_142(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06002277 RID: 8823
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_SetUserTransform_143(HandleRef pThis, HandleRef transform);

		/// <summary>
		/// In addition to the instance variables such as position and orientation,
		/// you can add an additional transformation for your own use. This
		/// transformation is concatenated to the camera's ProjectionTransform
		/// </summary>
		// Token: 0x06002278 RID: 8824 RVA: 0x00033AE0 File Offset: 0x00031CE0
		public void SetUserTransform(vtkHomogeneousTransform transform)
		{
			vtkCamera.vtkCamera_SetUserTransform_143(base.GetCppThis(), (transform == null) ? default(HandleRef) : transform.GetCppThis());
		}

		// Token: 0x06002279 RID: 8825
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_SetUserViewTransform_144(HandleRef pThis, HandleRef transform);

		/// <summary>
		/// In addition to the instance variables such as position and orientation,
		/// you can add an additional transformation for your own use.  This
		/// transformation is concatenated to the camera's ViewTransform
		/// </summary>
		// Token: 0x0600227A RID: 8826 RVA: 0x00033B10 File Offset: 0x00031D10
		public void SetUserViewTransform(vtkHomogeneousTransform transform)
		{
			vtkCamera.vtkCamera_SetUserViewTransform_144(base.GetCppThis(), (transform == null) ? default(HandleRef) : transform.GetCppThis());
		}

		// Token: 0x0600227B RID: 8827
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_SetViewAngle_145(HandleRef pThis, double angle);

		/// <summary>
		/// Set/Get the camera view angle, which is the angular height of the
		/// camera view measured in degrees.  The default angle is 30 degrees.
		/// This method has no effect in parallel projection mode.
		/// The formula for setting the angle up for perfect perspective viewing
		/// is: angle = 2*atan((h/2)/d) where h is the height of the RenderWindow
		/// (measured by holding a ruler up to your screen) and d is the
		/// distance from your eyes to the screen.
		/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
		/// is true.
		/// </summary>
		// Token: 0x0600227C RID: 8828 RVA: 0x00033B3F File Offset: 0x00031D3F
		public void SetViewAngle(double angle)
		{
			vtkCamera.vtkCamera_SetViewAngle_145(base.GetCppThis(), angle);
		}

		// Token: 0x0600227D RID: 8829
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_SetViewShear_146(HandleRef pThis, double dxdz, double dydz, double center);

		/// <summary>
		/// Set/get the shear transform of the viewing frustum.  Parameters are
		/// dx/dz, dy/dz, and center.  center is a factor that describes where
		/// to shear around. The distance dshear from the camera where
		/// no shear occurs is given by (dshear = center * FocalDistance).
		/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
		/// is true.
		/// </summary>
		// Token: 0x0600227E RID: 8830 RVA: 0x00033B4F File Offset: 0x00031D4F
		public void SetViewShear(double dxdz, double dydz, double center)
		{
			vtkCamera.vtkCamera_SetViewShear_146(base.GetCppThis(), dxdz, dydz, center);
		}

		// Token: 0x0600227F RID: 8831
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_SetViewShear_147(HandleRef pThis, IntPtr d);

		/// <summary>
		/// Set/get the shear transform of the viewing frustum.  Parameters are
		/// dx/dz, dy/dz, and center.  center is a factor that describes where
		/// to shear around. The distance dshear from the camera where
		/// no shear occurs is given by (dshear = center * FocalDistance).
		/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
		/// is true.
		/// </summary>
		// Token: 0x06002280 RID: 8832 RVA: 0x00033B61 File Offset: 0x00031D61
		public void SetViewShear(IntPtr d)
		{
			vtkCamera.vtkCamera_SetViewShear_147(base.GetCppThis(), d);
		}

		// Token: 0x06002281 RID: 8833
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_SetViewUp_148(HandleRef pThis, double vx, double vy, double vz);

		/// <summary>
		/// Set/Get the view up direction for the camera.  The default
		/// is (0,1,0).
		/// </summary>
		// Token: 0x06002282 RID: 8834 RVA: 0x00033B71 File Offset: 0x00031D71
		public void SetViewUp(double vx, double vy, double vz)
		{
			vtkCamera.vtkCamera_SetViewUp_148(base.GetCppThis(), vx, vy, vz);
		}

		// Token: 0x06002283 RID: 8835
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_SetViewUp_149(HandleRef pThis, IntPtr a);

		/// <summary>
		/// Set/Get the view up direction for the camera.  The default
		/// is (0,1,0).
		/// </summary>
		// Token: 0x06002284 RID: 8836 RVA: 0x00033B83 File Offset: 0x00031D83
		public void SetViewUp(IntPtr a)
		{
			vtkCamera.vtkCamera_SetViewUp_149(base.GetCppThis(), a);
		}

		// Token: 0x06002285 RID: 8837
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_SetWindowCenter_150(HandleRef pThis, double x, double y);

		/// <summary>
		/// Set/Get the center of the window in viewport coordinates.
		/// The viewport coordinate range is ([-1,+1],[-1,+1]).  This method
		/// is for if you have one window which consists of several viewports,
		/// or if you have several screens which you want to act together as
		/// one large screen.
		/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
		/// is true.
		/// </summary>
		// Token: 0x06002286 RID: 8838 RVA: 0x00033B93 File Offset: 0x00031D93
		public void SetWindowCenter(double x, double y)
		{
			vtkCamera.vtkCamera_SetWindowCenter_150(base.GetCppThis(), x, y);
		}

		// Token: 0x06002287 RID: 8839
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_ShallowCopy_151(HandleRef pThis, HandleRef source);

		/// <summary>
		/// Copy the properties of `source' into `this'.
		/// Copy pointers of matrices.
		/// \pre source_exists!=0
		/// \pre not_this: source!=this
		/// </summary>
		// Token: 0x06002288 RID: 8840 RVA: 0x00033BA4 File Offset: 0x00031DA4
		public void ShallowCopy(vtkCamera source)
		{
			vtkCamera.vtkCamera_ShallowCopy_151(base.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x06002289 RID: 8841
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_UpdateIdealShiftScale_152(HandleRef pThis, double aspect);

		/// <summary>
		/// The following methods are used to support view dependent methods
		/// for normalizing data (typically point coordinates). When dealing with
		/// data that can exceed floating point resolution sometimes is it best
		/// to normalize that data based on the current camera view such that
		/// what is seen will be in the sweet spot for floating point resolution.
		/// Input datasets may be double precision but the rendering engine
		/// is currently single precision which also can lead to these issues.
		/// See vtkOpenGLVertexBufferObject for related information.
		/// </summary>
		// Token: 0x0600228A RID: 8842 RVA: 0x00033BD3 File Offset: 0x00031DD3
		public virtual void UpdateIdealShiftScale(double aspect)
		{
			vtkCamera.vtkCamera_UpdateIdealShiftScale_152(base.GetCppThis(), aspect);
		}

		// Token: 0x0600228B RID: 8843
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_UpdateViewport_153(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Update the viewport
		/// </summary>
		// Token: 0x0600228C RID: 8844 RVA: 0x00033BE4 File Offset: 0x00031DE4
		public virtual void UpdateViewport(vtkRenderer arg0)
		{
			vtkCamera.vtkCamera_UpdateViewport_153(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600228D RID: 8845
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_UseExplicitAspectRatioOff_154(HandleRef pThis);

		/// <summary>
		/// If true, the ExplicitAspect is used for the projection
		/// transformation, rather than computing it from the renderer.
		/// Default is false.
		/// @{
		/// </summary>
		// Token: 0x0600228E RID: 8846 RVA: 0x00033C13 File Offset: 0x00031E13
		public virtual void UseExplicitAspectRatioOff()
		{
			vtkCamera.vtkCamera_UseExplicitAspectRatioOff_154(base.GetCppThis());
		}

		// Token: 0x0600228F RID: 8847
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_UseExplicitAspectRatioOn_155(HandleRef pThis);

		/// <summary>
		/// If true, the ExplicitAspect is used for the projection
		/// transformation, rather than computing it from the renderer.
		/// Default is false.
		/// @{
		/// </summary>
		// Token: 0x06002290 RID: 8848 RVA: 0x00033C22 File Offset: 0x00031E22
		public virtual void UseExplicitAspectRatioOn()
		{
			vtkCamera.vtkCamera_UseExplicitAspectRatioOn_155(base.GetCppThis());
		}

		// Token: 0x06002291 RID: 8849
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_UseExplicitProjectionTransformMatrixOff_156(HandleRef pThis);

		/// <summary>
		/// If true, the ExplicitProjectionTransformMatrix is used for the projection
		/// transformation, rather than computing a transform from internal state.
		/// @{
		/// </summary>
		// Token: 0x06002292 RID: 8850 RVA: 0x00033C31 File Offset: 0x00031E31
		public virtual void UseExplicitProjectionTransformMatrixOff()
		{
			vtkCamera.vtkCamera_UseExplicitProjectionTransformMatrixOff_156(base.GetCppThis());
		}

		// Token: 0x06002293 RID: 8851
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_UseExplicitProjectionTransformMatrixOn_157(HandleRef pThis);

		/// <summary>
		/// If true, the ExplicitProjectionTransformMatrix is used for the projection
		/// transformation, rather than computing a transform from internal state.
		/// @{
		/// </summary>
		// Token: 0x06002294 RID: 8852 RVA: 0x00033C40 File Offset: 0x00031E40
		public virtual void UseExplicitProjectionTransformMatrixOn()
		{
			vtkCamera.vtkCamera_UseExplicitProjectionTransformMatrixOn_157(base.GetCppThis());
		}

		// Token: 0x06002295 RID: 8853
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_UseHorizontalViewAngleOff_158(HandleRef pThis);

		/// <summary>
		/// Set/Get the value of the UseHorizontalViewAngle instance variable. If
		/// set, the camera's view angle represents a horizontal view angle, rather
		/// than the default vertical view angle. This is useful if the application
		/// uses a display device which whose specs indicate a particular horizontal
		/// view angle, or if the application varies the window height but wants to
		/// keep the perspective transform unchanges.
		/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
		/// is true.
		/// </summary>
		// Token: 0x06002296 RID: 8854 RVA: 0x00033C4F File Offset: 0x00031E4F
		public virtual void UseHorizontalViewAngleOff()
		{
			vtkCamera.vtkCamera_UseHorizontalViewAngleOff_158(base.GetCppThis());
		}

		// Token: 0x06002297 RID: 8855
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_UseHorizontalViewAngleOn_159(HandleRef pThis);

		/// <summary>
		/// Set/Get the value of the UseHorizontalViewAngle instance variable. If
		/// set, the camera's view angle represents a horizontal view angle, rather
		/// than the default vertical view angle. This is useful if the application
		/// uses a display device which whose specs indicate a particular horizontal
		/// view angle, or if the application varies the window height but wants to
		/// keep the perspective transform unchanges.
		/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
		/// is true.
		/// </summary>
		// Token: 0x06002298 RID: 8856 RVA: 0x00033C5E File Offset: 0x00031E5E
		public virtual void UseHorizontalViewAngleOn()
		{
			vtkCamera.vtkCamera_UseHorizontalViewAngleOn_159(base.GetCppThis());
		}

		// Token: 0x06002299 RID: 8857
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_UseOffAxisProjectionOff_160(HandleRef pThis);

		/// <summary>
		/// Set/Get use offaxis frustum.
		/// OffAxis frustum is used for off-axis frustum calculations specifically
		/// for head-tracking with stereo rendering.
		/// For reference see "Generalized Perspective Projection" by Robert Kooima,
		/// 2008.
		/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
		/// is true.
		/// </summary>
		// Token: 0x0600229A RID: 8858 RVA: 0x00033C6D File Offset: 0x00031E6D
		public virtual void UseOffAxisProjectionOff()
		{
			vtkCamera.vtkCamera_UseOffAxisProjectionOff_160(base.GetCppThis());
		}

		// Token: 0x0600229B RID: 8859
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_UseOffAxisProjectionOn_161(HandleRef pThis);

		/// <summary>
		/// Set/Get use offaxis frustum.
		/// OffAxis frustum is used for off-axis frustum calculations specifically
		/// for head-tracking with stereo rendering.
		/// For reference see "Generalized Perspective Projection" by Robert Kooima,
		/// 2008.
		/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
		/// is true.
		/// </summary>
		// Token: 0x0600229C RID: 8860 RVA: 0x00033C7C File Offset: 0x00031E7C
		public virtual void UseOffAxisProjectionOn()
		{
			vtkCamera.vtkCamera_UseOffAxisProjectionOn_161(base.GetCppThis());
		}

		// Token: 0x0600229D RID: 8861
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_ViewingRaysModified_162(HandleRef pThis);

		/// <summary>
		/// Mark that something has changed which requires the view rays
		/// to be recomputed.
		/// </summary>
		// Token: 0x0600229E RID: 8862 RVA: 0x00033C8B File Offset: 0x00031E8B
		public void ViewingRaysModified()
		{
			vtkCamera.vtkCamera_ViewingRaysModified_162(base.GetCppThis());
		}

		// Token: 0x0600229F RID: 8863
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_Yaw_163(HandleRef pThis, double angle);

		/// <summary>
		/// Rotate the focal point about the view up vector, using the camera's
		/// position as the center of rotation. Note that the view up vector is
		/// whatever was set via SetViewUp, and is not necessarily perpendicular
		/// to the direction of projection.  The result is a horizontal rotation
		/// of the scene.
		/// </summary>
		// Token: 0x060022A0 RID: 8864 RVA: 0x00033C9A File Offset: 0x00031E9A
		public void Yaw(double angle)
		{
			vtkCamera.vtkCamera_Yaw_163(base.GetCppThis(), angle);
		}

		// Token: 0x060022A1 RID: 8865
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera_Zoom_164(HandleRef pThis, double factor);

		/// <summary>
		/// In perspective mode, decrease the view angle by the specified factor.
		/// In parallel mode, decrease the parallel scale by the specified factor.
		/// A value greater than 1 is a zoom-in, a value less than 1 is a zoom-out.
		/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
		/// is true.
		/// </summary>
		// Token: 0x060022A2 RID: 8866 RVA: 0x00033CAA File Offset: 0x00031EAA
		public void Zoom(double factor)
		{
			vtkCamera.vtkCamera_Zoom_164(base.GetCppThis(), factor);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400051D RID: 1309
		public new const string MRFullTypeName = "Kitware.VTK.vtkCamera";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400051E RID: 1310
		public new static readonly string MRClassNameKey = "class vtkCamera";
	}
}
