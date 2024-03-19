using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkEncodedGradientEstimator
	/// </summary>
	/// <remarks>
	///    Superclass for gradient estimation
	///
	/// vtkEncodedGradientEstimator is an abstract superclass for gradient
	/// estimation. It takes a scalar input of vtkImageData, computes
	/// a gradient value for every point, and encodes this value into a
	/// three byte value (2 for direction, 1 for magnitude) using the
	/// vtkDirectionEncoder. The direction encoder is defaulted to a
	/// vtkRecursiveSphereDirectionEncoder, but can be overridden with the
	/// SetDirectionEncoder method. The scale and the bias values for the gradient
	/// magnitude are used to convert it into a one byte value according to
	/// v = m*scale + bias where m is the magnitude and v is the resulting
	/// one byte value.
	/// </remarks>
	/// <seealso>
	///
	/// vtkFiniteDifferenceGradientEstimator vtkDirectionEncoder
	/// </seealso>
	// Token: 0x02000392 RID: 914
	public abstract class vtkEncodedGradientEstimator : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600A60A RID: 42506 RVA: 0x000EBB2F File Offset: 0x000E9D2F
		static vtkEncodedGradientEstimator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEncodedGradientEstimator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEncodedGradientEstimator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600A60B RID: 42507 RVA: 0x000EBB57 File Offset: 0x000E9D57
		public vtkEncodedGradientEstimator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600A60C RID: 42508 RVA: 0x000EBB65 File Offset: 0x000E9D65
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600A60D RID: 42509
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEncodedGradientEstimator_BoundsClipOff_01(HandleRef pThis);

		/// <summary>
		/// Turn on / off the bounding of the normal computation by
		/// the this-&gt;Bounds bounding box
		/// </summary>
		// Token: 0x0600A60E RID: 42510 RVA: 0x000EBB70 File Offset: 0x000E9D70
		public virtual void BoundsClipOff()
		{
			vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_BoundsClipOff_01(base.GetCppThis());
		}

		// Token: 0x0600A60F RID: 42511
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEncodedGradientEstimator_BoundsClipOn_02(HandleRef pThis);

		/// <summary>
		/// Turn on / off the bounding of the normal computation by
		/// the this-&gt;Bounds bounding box
		/// </summary>
		// Token: 0x0600A610 RID: 42512 RVA: 0x000EBB7F File Offset: 0x000E9D7F
		public virtual void BoundsClipOn()
		{
			vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_BoundsClipOn_02(base.GetCppThis());
		}

		// Token: 0x0600A611 RID: 42513
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEncodedGradientEstimator_ComputeGradientMagnitudesOff_03(HandleRef pThis);

		/// <summary>
		/// If you don't want to compute gradient magnitudes (but you
		/// do want normals for shading) this can be used. Be careful - if
		/// if you a non-constant gradient magnitude transfer function and
		/// you turn this on, it may crash
		/// </summary>
		// Token: 0x0600A612 RID: 42514 RVA: 0x000EBB8E File Offset: 0x000E9D8E
		public virtual void ComputeGradientMagnitudesOff()
		{
			vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_ComputeGradientMagnitudesOff_03(base.GetCppThis());
		}

		// Token: 0x0600A613 RID: 42515
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEncodedGradientEstimator_ComputeGradientMagnitudesOn_04(HandleRef pThis);

		/// <summary>
		/// If you don't want to compute gradient magnitudes (but you
		/// do want normals for shading) this can be used. Be careful - if
		/// if you a non-constant gradient magnitude transfer function and
		/// you turn this on, it may crash
		/// </summary>
		// Token: 0x0600A614 RID: 42516 RVA: 0x000EBB9D File Offset: 0x000E9D9D
		public virtual void ComputeGradientMagnitudesOn()
		{
			vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_ComputeGradientMagnitudesOn_04(base.GetCppThis());
		}

		// Token: 0x0600A615 RID: 42517
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEncodedGradientEstimator_CylinderClipOff_05(HandleRef pThis);

		/// <summary>
		/// If the data in each slice is only contained within a circle circumscribed
		/// within the slice, and the slice is square, then don't compute anything
		/// outside the circle. This circle through the slices forms a cylinder.
		/// </summary>
		// Token: 0x0600A616 RID: 42518 RVA: 0x000EBBAC File Offset: 0x000E9DAC
		public virtual void CylinderClipOff()
		{
			vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_CylinderClipOff_05(base.GetCppThis());
		}

		// Token: 0x0600A617 RID: 42519
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEncodedGradientEstimator_CylinderClipOn_06(HandleRef pThis);

		/// <summary>
		/// If the data in each slice is only contained within a circle circumscribed
		/// within the slice, and the slice is square, then don't compute anything
		/// outside the circle. This circle through the slices forms a cylinder.
		/// </summary>
		// Token: 0x0600A618 RID: 42520 RVA: 0x000EBBBB File Offset: 0x000E9DBB
		public virtual void CylinderClipOn()
		{
			vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_CylinderClipOn_06(base.GetCppThis());
		}

		// Token: 0x0600A619 RID: 42521
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEncodedGradientEstimator_GetBounds_07(HandleRef pThis);

		/// <summary>
		/// Set / Get the bounds of the computation (used if
		/// this-&gt;ComputationBounds is 1.) The bounds are specified
		/// xmin, xmax, ymin, ymax, zmin, zmax.
		/// </summary>
		// Token: 0x0600A61A RID: 42522 RVA: 0x000EBBCC File Offset: 0x000E9DCC
		public virtual int[] GetBounds()
		{
			IntPtr intPtr = vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetBounds_07(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600A61B RID: 42523
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEncodedGradientEstimator_GetBounds_08(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set / Get the bounds of the computation (used if
		/// this-&gt;ComputationBounds is 1.) The bounds are specified
		/// xmin, xmax, ymin, ymax, zmin, zmax.
		/// </summary>
		// Token: 0x0600A61C RID: 42524 RVA: 0x000EBC14 File Offset: 0x000E9E14
		public virtual void GetBounds(IntPtr data)
		{
			vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetBounds_08(base.GetCppThis(), data);
		}

		// Token: 0x0600A61D RID: 42525
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEncodedGradientEstimator_GetBoundsClip_09(HandleRef pThis);

		/// <summary>
		/// Turn on / off the bounding of the normal computation by
		/// the this-&gt;Bounds bounding box
		/// </summary>
		// Token: 0x0600A61E RID: 42526 RVA: 0x000EBC24 File Offset: 0x000E9E24
		public virtual int GetBoundsClip()
		{
			return vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetBoundsClip_09(base.GetCppThis());
		}

		// Token: 0x0600A61F RID: 42527
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEncodedGradientEstimator_GetBoundsClipMaxValue_10(HandleRef pThis);

		/// <summary>
		/// Turn on / off the bounding of the normal computation by
		/// the this-&gt;Bounds bounding box
		/// </summary>
		// Token: 0x0600A620 RID: 42528 RVA: 0x000EBC44 File Offset: 0x000E9E44
		public virtual int GetBoundsClipMaxValue()
		{
			return vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetBoundsClipMaxValue_10(base.GetCppThis());
		}

		// Token: 0x0600A621 RID: 42529
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEncodedGradientEstimator_GetBoundsClipMinValue_11(HandleRef pThis);

		/// <summary>
		/// Turn on / off the bounding of the normal computation by
		/// the this-&gt;Bounds bounding box
		/// </summary>
		// Token: 0x0600A622 RID: 42530 RVA: 0x000EBC64 File Offset: 0x000E9E64
		public virtual int GetBoundsClipMinValue()
		{
			return vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetBoundsClipMinValue_11(base.GetCppThis());
		}

		// Token: 0x0600A623 RID: 42531
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEncodedGradientEstimator_GetCircleLimits_12(HandleRef pThis);

		/// <summary>
		/// Get the time required for the last update in seconds or cpu seconds
		/// </summary>
		// Token: 0x0600A624 RID: 42532 RVA: 0x000EBC84 File Offset: 0x000E9E84
		public IntPtr GetCircleLimits()
		{
			return vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetCircleLimits_12(base.GetCppThis());
		}

		// Token: 0x0600A625 RID: 42533
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEncodedGradientEstimator_GetComputeGradientMagnitudes_13(HandleRef pThis);

		/// <summary>
		/// If you don't want to compute gradient magnitudes (but you
		/// do want normals for shading) this can be used. Be careful - if
		/// if you a non-constant gradient magnitude transfer function and
		/// you turn this on, it may crash
		/// </summary>
		// Token: 0x0600A626 RID: 42534 RVA: 0x000EBCA4 File Offset: 0x000E9EA4
		public virtual int GetComputeGradientMagnitudes()
		{
			return vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetComputeGradientMagnitudes_13(base.GetCppThis());
		}

		// Token: 0x0600A627 RID: 42535
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEncodedGradientEstimator_GetCylinderClip_14(HandleRef pThis);

		/// <summary>
		/// If the data in each slice is only contained within a circle circumscribed
		/// within the slice, and the slice is square, then don't compute anything
		/// outside the circle. This circle through the slices forms a cylinder.
		/// </summary>
		// Token: 0x0600A628 RID: 42536 RVA: 0x000EBCC4 File Offset: 0x000E9EC4
		public virtual int GetCylinderClip()
		{
			return vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetCylinderClip_14(base.GetCppThis());
		}

		// Token: 0x0600A629 RID: 42537
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEncodedGradientEstimator_GetDirectionEncoder_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set / Get the direction encoder used to encode normal directions
		/// to fit within two bytes
		/// </summary>
		// Token: 0x0600A62A RID: 42538 RVA: 0x000EBCE4 File Offset: 0x000E9EE4
		public virtual vtkDirectionEncoder GetDirectionEncoder()
		{
			vtkDirectionEncoder vtkDirectionEncoder = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetDirectionEncoder_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDirectionEncoder = (vtkDirectionEncoder)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDirectionEncoder.Register(null);
				}
			}
			return vtkDirectionEncoder;
		}

		// Token: 0x0600A62B RID: 42539
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEncodedGradientEstimator_GetEncodedNormalIndex_16(HandleRef pThis, long xyzIndex);

		/// <summary>
		/// Get the encoded normal at an x,y,z location in the volume
		/// </summary>
		// Token: 0x0600A62C RID: 42540 RVA: 0x000EBD54 File Offset: 0x000E9F54
		public int GetEncodedNormalIndex(long xyzIndex)
		{
			return vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetEncodedNormalIndex_16(base.GetCppThis(), xyzIndex);
		}

		// Token: 0x0600A62D RID: 42541
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEncodedGradientEstimator_GetEncodedNormalIndex_17(HandleRef pThis, int xIndex, int yIndex, int zIndex);

		/// <summary>
		/// Get the encoded normal at an x,y,z location in the volume
		/// </summary>
		// Token: 0x0600A62E RID: 42542 RVA: 0x000EBD74 File Offset: 0x000E9F74
		public int GetEncodedNormalIndex(int xIndex, int yIndex, int zIndex)
		{
			return vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetEncodedNormalIndex_17(base.GetCppThis(), xIndex, yIndex, zIndex);
		}

		// Token: 0x0600A62F RID: 42543
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEncodedGradientEstimator_GetEncodedNormals_18(HandleRef pThis);

		/// <summary>
		/// Get the encoded normals.
		/// </summary>
		// Token: 0x0600A630 RID: 42544 RVA: 0x000EBD98 File Offset: 0x000E9F98
		public IntPtr GetEncodedNormals()
		{
			return vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetEncodedNormals_18(base.GetCppThis());
		}

		// Token: 0x0600A631 RID: 42545
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkEncodedGradientEstimator_GetGradientMagnitudeBias_19(HandleRef pThis);

		/// <summary>
		/// Set/Get the scale and bias for the gradient magnitude
		/// </summary>
		// Token: 0x0600A632 RID: 42546 RVA: 0x000EBDB8 File Offset: 0x000E9FB8
		public virtual float GetGradientMagnitudeBias()
		{
			return vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetGradientMagnitudeBias_19(base.GetCppThis());
		}

		// Token: 0x0600A633 RID: 42547
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkEncodedGradientEstimator_GetGradientMagnitudeScale_20(HandleRef pThis);

		/// <summary>
		/// Set/Get the scale and bias for the gradient magnitude
		/// </summary>
		// Token: 0x0600A634 RID: 42548 RVA: 0x000EBDD8 File Offset: 0x000E9FD8
		public virtual float GetGradientMagnitudeScale()
		{
			return vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetGradientMagnitudeScale_20(base.GetCppThis());
		}

		// Token: 0x0600A635 RID: 42549
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEncodedGradientEstimator_GetGradientMagnitudes_21(HandleRef pThis);

		/// <summary>
		/// Get the gradient magnitudes
		/// </summary>
		// Token: 0x0600A636 RID: 42550 RVA: 0x000EBDF8 File Offset: 0x000E9FF8
		public IntPtr GetGradientMagnitudes()
		{
			return vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetGradientMagnitudes_21(base.GetCppThis());
		}

		// Token: 0x0600A637 RID: 42551
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEncodedGradientEstimator_GetInputAspect_22(HandleRef pThis);

		/// <summary>
		/// Assume that the data value outside the volume is zero when
		/// computing normals.
		/// </summary>
		// Token: 0x0600A638 RID: 42552 RVA: 0x000EBE18 File Offset: 0x000EA018
		public virtual float[] GetInputAspect()
		{
			IntPtr intPtr = vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetInputAspect_22(base.GetCppThis());
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600A639 RID: 42553
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEncodedGradientEstimator_GetInputAspect_23(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Assume that the data value outside the volume is zero when
		/// computing normals.
		/// </summary>
		// Token: 0x0600A63A RID: 42554 RVA: 0x000EBE60 File Offset: 0x000EA060
		public virtual void GetInputAspect(IntPtr data)
		{
			vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetInputAspect_23(base.GetCppThis(), data);
		}

		// Token: 0x0600A63B RID: 42555
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEncodedGradientEstimator_GetInputData_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the scalar input for which the normals will be
		/// calculated. Note that this call does not setup a pipeline
		/// connection. vtkEncodedGradientEstimator is not an algorithm
		/// and does not update its input. If you are directly using this
		/// class, you may need to manually update the algorithm that produces
		/// this data object.
		/// </summary>
		// Token: 0x0600A63C RID: 42556 RVA: 0x000EBE70 File Offset: 0x000EA070
		public virtual vtkImageData GetInputData()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetInputData_24(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		// Token: 0x0600A63D RID: 42557
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEncodedGradientEstimator_GetInputSize_25(HandleRef pThis);

		/// <summary>
		/// Assume that the data value outside the volume is zero when
		/// computing normals.
		/// </summary>
		// Token: 0x0600A63E RID: 42558 RVA: 0x000EBEE0 File Offset: 0x000EA0E0
		public virtual int[] GetInputSize()
		{
			IntPtr intPtr = vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetInputSize_25(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600A63F RID: 42559
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEncodedGradientEstimator_GetInputSize_26(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Assume that the data value outside the volume is zero when
		/// computing normals.
		/// </summary>
		// Token: 0x0600A640 RID: 42560 RVA: 0x000EBF28 File Offset: 0x000EA128
		public virtual void GetInputSize(IntPtr data)
		{
			vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetInputSize_26(base.GetCppThis(), data);
		}

		// Token: 0x0600A641 RID: 42561
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkEncodedGradientEstimator_GetLastUpdateTimeInCPUSeconds_27(HandleRef pThis);

		/// <summary>
		/// Get the time required for the last update in seconds or cpu seconds
		/// </summary>
		// Token: 0x0600A642 RID: 42562 RVA: 0x000EBF38 File Offset: 0x000EA138
		public virtual float GetLastUpdateTimeInCPUSeconds()
		{
			return vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetLastUpdateTimeInCPUSeconds_27(base.GetCppThis());
		}

		// Token: 0x0600A643 RID: 42563
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkEncodedGradientEstimator_GetLastUpdateTimeInSeconds_28(HandleRef pThis);

		/// <summary>
		/// Get the time required for the last update in seconds or cpu seconds
		/// </summary>
		// Token: 0x0600A644 RID: 42564 RVA: 0x000EBF58 File Offset: 0x000EA158
		public virtual float GetLastUpdateTimeInSeconds()
		{
			return vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetLastUpdateTimeInSeconds_28(base.GetCppThis());
		}

		// Token: 0x0600A645 RID: 42565
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEncodedGradientEstimator_GetNumberOfGenerationsFromBase_29(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A646 RID: 42566 RVA: 0x000EBF78 File Offset: 0x000EA178
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetNumberOfGenerationsFromBase_29(base.GetCppThis(), type);
		}

		// Token: 0x0600A647 RID: 42567
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEncodedGradientEstimator_GetNumberOfGenerationsFromBaseType_30([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A648 RID: 42568 RVA: 0x000EBF98 File Offset: 0x000EA198
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetNumberOfGenerationsFromBaseType_30(type);
		}

		// Token: 0x0600A649 RID: 42569
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEncodedGradientEstimator_GetNumberOfThreads_31(HandleRef pThis);

		/// <summary>
		/// Get/Set the number of threads to create when encoding normals
		/// This defaults to the number of available processors on the machine
		/// </summary>
		// Token: 0x0600A64A RID: 42570 RVA: 0x000EBFB4 File Offset: 0x000EA1B4
		public virtual int GetNumberOfThreads()
		{
			return vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetNumberOfThreads_31(base.GetCppThis());
		}

		// Token: 0x0600A64B RID: 42571
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEncodedGradientEstimator_GetNumberOfThreadsMaxValue_32(HandleRef pThis);

		/// <summary>
		/// Get/Set the number of threads to create when encoding normals
		/// This defaults to the number of available processors on the machine
		/// </summary>
		// Token: 0x0600A64C RID: 42572 RVA: 0x000EBFD4 File Offset: 0x000EA1D4
		public virtual int GetNumberOfThreadsMaxValue()
		{
			return vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetNumberOfThreadsMaxValue_32(base.GetCppThis());
		}

		// Token: 0x0600A64D RID: 42573
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEncodedGradientEstimator_GetNumberOfThreadsMinValue_33(HandleRef pThis);

		/// <summary>
		/// Get/Set the number of threads to create when encoding normals
		/// This defaults to the number of available processors on the machine
		/// </summary>
		// Token: 0x0600A64E RID: 42574 RVA: 0x000EBFF4 File Offset: 0x000EA1F4
		public virtual int GetNumberOfThreadsMinValue()
		{
			return vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetNumberOfThreadsMinValue_33(base.GetCppThis());
		}

		// Token: 0x0600A64F RID: 42575
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEncodedGradientEstimator_GetUseCylinderClip_34(HandleRef pThis);

		/// <summary>
		/// Get the time required for the last update in seconds or cpu seconds
		/// </summary>
		// Token: 0x0600A650 RID: 42576 RVA: 0x000EC014 File Offset: 0x000EA214
		public virtual int GetUseCylinderClip()
		{
			return vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetUseCylinderClip_34(base.GetCppThis());
		}

		// Token: 0x0600A651 RID: 42577
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkEncodedGradientEstimator_GetZeroNormalThreshold_35(HandleRef pThis);

		/// <summary>
		/// Set / Get the ZeroNormalThreshold - this defines the minimum magnitude
		/// of a gradient that is considered sufficient to define a
		/// direction. Gradients with magnitudes at or less than this value are given
		/// a "zero normal" index. These are handled specially in the shader,
		/// and you can set the intensity of light for these zero normals in
		/// the gradient shader.
		/// </summary>
		// Token: 0x0600A652 RID: 42578 RVA: 0x000EC034 File Offset: 0x000EA234
		public virtual float GetZeroNormalThreshold()
		{
			return vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetZeroNormalThreshold_35(base.GetCppThis());
		}

		// Token: 0x0600A653 RID: 42579
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEncodedGradientEstimator_GetZeroPad_36(HandleRef pThis);

		/// <summary>
		/// Assume that the data value outside the volume is zero when
		/// computing normals.
		/// </summary>
		// Token: 0x0600A654 RID: 42580 RVA: 0x000EC054 File Offset: 0x000EA254
		public virtual int GetZeroPad()
		{
			return vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetZeroPad_36(base.GetCppThis());
		}

		// Token: 0x0600A655 RID: 42581
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEncodedGradientEstimator_GetZeroPadMaxValue_37(HandleRef pThis);

		/// <summary>
		/// Assume that the data value outside the volume is zero when
		/// computing normals.
		/// </summary>
		// Token: 0x0600A656 RID: 42582 RVA: 0x000EC074 File Offset: 0x000EA274
		public virtual int GetZeroPadMaxValue()
		{
			return vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetZeroPadMaxValue_37(base.GetCppThis());
		}

		// Token: 0x0600A657 RID: 42583
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEncodedGradientEstimator_GetZeroPadMinValue_38(HandleRef pThis);

		/// <summary>
		/// Assume that the data value outside the volume is zero when
		/// computing normals.
		/// </summary>
		// Token: 0x0600A658 RID: 42584 RVA: 0x000EC094 File Offset: 0x000EA294
		public virtual int GetZeroPadMinValue()
		{
			return vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetZeroPadMinValue_38(base.GetCppThis());
		}

		// Token: 0x0600A659 RID: 42585
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEncodedGradientEstimator_IsA_39(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A65A RID: 42586 RVA: 0x000EC0B4 File Offset: 0x000EA2B4
		public override int IsA(string type)
		{
			return vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_IsA_39(base.GetCppThis(), type);
		}

		// Token: 0x0600A65B RID: 42587
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEncodedGradientEstimator_IsTypeOf_40([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A65C RID: 42588 RVA: 0x000EC0D4 File Offset: 0x000EA2D4
		public new static int IsTypeOf(string type)
		{
			return vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_IsTypeOf_40(type);
		}

		// Token: 0x0600A65D RID: 42589
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEncodedGradientEstimator_NewInstance_41(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A65E RID: 42590 RVA: 0x000EC0F0 File Offset: 0x000EA2F0
		public new vtkEncodedGradientEstimator NewInstance()
		{
			vtkEncodedGradientEstimator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_NewInstance_41(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEncodedGradientEstimator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600A65F RID: 42591
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEncodedGradientEstimator_SafeDownCast_42(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A660 RID: 42592 RVA: 0x000EC14C File Offset: 0x000EA34C
		public new static vtkEncodedGradientEstimator SafeDownCast(vtkObjectBase o)
		{
			vtkEncodedGradientEstimator vtkEncodedGradientEstimator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_SafeDownCast_42((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEncodedGradientEstimator = (vtkEncodedGradientEstimator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEncodedGradientEstimator.Register(null);
				}
			}
			return vtkEncodedGradientEstimator;
		}

		// Token: 0x0600A661 RID: 42593
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEncodedGradientEstimator_SetBounds_43(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		/// <summary>
		/// Set / Get the bounds of the computation (used if
		/// this-&gt;ComputationBounds is 1.) The bounds are specified
		/// xmin, xmax, ymin, ymax, zmin, zmax.
		/// </summary>
		// Token: 0x0600A662 RID: 42594 RVA: 0x000EC1CB File Offset: 0x000EA3CB
		public virtual void SetBounds(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_SetBounds_43(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x0600A663 RID: 42595
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEncodedGradientEstimator_SetBounds_44(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set / Get the bounds of the computation (used if
		/// this-&gt;ComputationBounds is 1.) The bounds are specified
		/// xmin, xmax, ymin, ymax, zmin, zmax.
		/// </summary>
		// Token: 0x0600A664 RID: 42596 RVA: 0x000EC1E3 File Offset: 0x000EA3E3
		public virtual void SetBounds(IntPtr _arg)
		{
			vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_SetBounds_44(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A665 RID: 42597
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEncodedGradientEstimator_SetBoundsClip_45(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on / off the bounding of the normal computation by
		/// the this-&gt;Bounds bounding box
		/// </summary>
		// Token: 0x0600A666 RID: 42598 RVA: 0x000EC1F3 File Offset: 0x000EA3F3
		public virtual void SetBoundsClip(int _arg)
		{
			vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_SetBoundsClip_45(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A667 RID: 42599
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEncodedGradientEstimator_SetComputeGradientMagnitudes_46(HandleRef pThis, int _arg);

		/// <summary>
		/// If you don't want to compute gradient magnitudes (but you
		/// do want normals for shading) this can be used. Be careful - if
		/// if you a non-constant gradient magnitude transfer function and
		/// you turn this on, it may crash
		/// </summary>
		// Token: 0x0600A668 RID: 42600 RVA: 0x000EC203 File Offset: 0x000EA403
		public virtual void SetComputeGradientMagnitudes(int _arg)
		{
			vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_SetComputeGradientMagnitudes_46(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A669 RID: 42601
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEncodedGradientEstimator_SetCylinderClip_47(HandleRef pThis, int _arg);

		/// <summary>
		/// If the data in each slice is only contained within a circle circumscribed
		/// within the slice, and the slice is square, then don't compute anything
		/// outside the circle. This circle through the slices forms a cylinder.
		/// </summary>
		// Token: 0x0600A66A RID: 42602 RVA: 0x000EC213 File Offset: 0x000EA413
		public virtual void SetCylinderClip(int _arg)
		{
			vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_SetCylinderClip_47(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A66B RID: 42603
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEncodedGradientEstimator_SetDirectionEncoder_48(HandleRef pThis, HandleRef direnc);

		/// <summary>
		/// Set / Get the direction encoder used to encode normal directions
		/// to fit within two bytes
		/// </summary>
		// Token: 0x0600A66C RID: 42604 RVA: 0x000EC224 File Offset: 0x000EA424
		public void SetDirectionEncoder(vtkDirectionEncoder direnc)
		{
			vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_SetDirectionEncoder_48(base.GetCppThis(), (direnc == null) ? default(HandleRef) : direnc.GetCppThis());
		}

		// Token: 0x0600A66D RID: 42605
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEncodedGradientEstimator_SetGradientMagnitudeBias_49(HandleRef pThis, float _arg);

		/// <summary>
		/// Set/Get the scale and bias for the gradient magnitude
		/// </summary>
		// Token: 0x0600A66E RID: 42606 RVA: 0x000EC253 File Offset: 0x000EA453
		public virtual void SetGradientMagnitudeBias(float _arg)
		{
			vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_SetGradientMagnitudeBias_49(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A66F RID: 42607
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEncodedGradientEstimator_SetGradientMagnitudeScale_50(HandleRef pThis, float _arg);

		/// <summary>
		/// Set/Get the scale and bias for the gradient magnitude
		/// </summary>
		// Token: 0x0600A670 RID: 42608 RVA: 0x000EC263 File Offset: 0x000EA463
		public virtual void SetGradientMagnitudeScale(float _arg)
		{
			vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_SetGradientMagnitudeScale_50(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A671 RID: 42609
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEncodedGradientEstimator_SetInputData_51(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the scalar input for which the normals will be
		/// calculated. Note that this call does not setup a pipeline
		/// connection. vtkEncodedGradientEstimator is not an algorithm
		/// and does not update its input. If you are directly using this
		/// class, you may need to manually update the algorithm that produces
		/// this data object.
		/// </summary>
		// Token: 0x0600A672 RID: 42610 RVA: 0x000EC274 File Offset: 0x000EA474
		public virtual void SetInputData(vtkImageData arg0)
		{
			vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_SetInputData_51(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600A673 RID: 42611
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEncodedGradientEstimator_SetNumberOfThreads_52(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the number of threads to create when encoding normals
		/// This defaults to the number of available processors on the machine
		/// </summary>
		// Token: 0x0600A674 RID: 42612 RVA: 0x000EC2A3 File Offset: 0x000EA4A3
		public virtual void SetNumberOfThreads(int _arg)
		{
			vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_SetNumberOfThreads_52(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A675 RID: 42613
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEncodedGradientEstimator_SetZeroNormalThreshold_53(HandleRef pThis, float v);

		/// <summary>
		/// Set / Get the ZeroNormalThreshold - this defines the minimum magnitude
		/// of a gradient that is considered sufficient to define a
		/// direction. Gradients with magnitudes at or less than this value are given
		/// a "zero normal" index. These are handled specially in the shader,
		/// and you can set the intensity of light for these zero normals in
		/// the gradient shader.
		/// </summary>
		// Token: 0x0600A676 RID: 42614 RVA: 0x000EC2B3 File Offset: 0x000EA4B3
		public void SetZeroNormalThreshold(float v)
		{
			vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_SetZeroNormalThreshold_53(base.GetCppThis(), v);
		}

		// Token: 0x0600A677 RID: 42615
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEncodedGradientEstimator_SetZeroPad_54(HandleRef pThis, int _arg);

		/// <summary>
		/// Assume that the data value outside the volume is zero when
		/// computing normals.
		/// </summary>
		// Token: 0x0600A678 RID: 42616 RVA: 0x000EC2C3 File Offset: 0x000EA4C3
		public virtual void SetZeroPad(int _arg)
		{
			vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_SetZeroPad_54(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A679 RID: 42617
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEncodedGradientEstimator_Update_55(HandleRef pThis);

		/// <summary>
		/// Recompute the encoded normals and gradient magnitudes.
		/// </summary>
		// Token: 0x0600A67A RID: 42618 RVA: 0x000EC2D3 File Offset: 0x000EA4D3
		public void Update()
		{
			vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_Update_55(base.GetCppThis());
		}

		// Token: 0x0600A67B RID: 42619
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEncodedGradientEstimator_ZeroPadOff_56(HandleRef pThis);

		/// <summary>
		/// Assume that the data value outside the volume is zero when
		/// computing normals.
		/// </summary>
		// Token: 0x0600A67C RID: 42620 RVA: 0x000EC2E2 File Offset: 0x000EA4E2
		public virtual void ZeroPadOff()
		{
			vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_ZeroPadOff_56(base.GetCppThis());
		}

		// Token: 0x0600A67D RID: 42621
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEncodedGradientEstimator_ZeroPadOn_57(HandleRef pThis);

		/// <summary>
		/// Assume that the data value outside the volume is zero when
		/// computing normals.
		/// </summary>
		// Token: 0x0600A67E RID: 42622 RVA: 0x000EC2F1 File Offset: 0x000EA4F1
		public virtual void ZeroPadOn()
		{
			vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_ZeroPadOn_57(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D59 RID: 3417
		public new const string MRFullTypeName = "Kitware.VTK.vtkEncodedGradientEstimator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D5A RID: 3418
		public new static readonly string MRClassNameKey = "class vtkEncodedGradientEstimator";
	}
}
