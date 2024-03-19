using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGPUVolumeRayCastMapper
	/// </summary>
	/// <remarks>
	///    Ray casting performed on the GPU.
	///
	/// vtkGPUVolumeRayCastMapper is a volume mapper that performs ray casting on
	/// the GPU using fragment programs.
	///
	/// This mapper supports connections in multiple ports of input 0 (port 0 being
	/// the only required connection). It is up to the concrete implementation
	/// whether additional inputs will be used during rendering. This class maintains
	/// a list of the currently active input ports (Ports) as well as a list of the
	/// ports that have been disconnected (RemovedPorts). RemovedPorts is used the
	/// the concrete implementation to clean up internal structures.
	///
	/// </remarks>
	// Token: 0x020000D3 RID: 211
	public abstract class vtkGPUVolumeRayCastMapper : vtkVolumeMapper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06002CB9 RID: 11449 RVA: 0x00041DC7 File Offset: 0x0003FFC7
		static vtkGPUVolumeRayCastMapper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGPUVolumeRayCastMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGPUVolumeRayCastMapper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06002CBA RID: 11450 RVA: 0x00041DEF File Offset: 0x0003FFEF
		public vtkGPUVolumeRayCastMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06002CBB RID: 11451
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGPUVolumeRayCastMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002CBC RID: 11452 RVA: 0x00041E00 File Offset: 0x00040000
		public new static vtkGPUVolumeRayCastMapper New()
		{
			vtkGPUVolumeRayCastMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGPUVolumeRayCastMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002CBD RID: 11453 RVA: 0x00041E54 File Offset: 0x00040054
		public vtkGPUVolumeRayCastMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06002CBE RID: 11454 RVA: 0x00041E98 File Offset: 0x00040098
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06002CBF RID: 11455
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUVolumeRayCastMapper_AutoAdjustSampleDistancesOff_01(HandleRef pThis);

		/// <summary>
		/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
		/// will be varied to achieve the allocated render time of this
		/// prop (controlled by the desired update rate and any culling in
		/// use).
		/// </summary>
		// Token: 0x06002CC0 RID: 11456 RVA: 0x00041EA3 File Offset: 0x000400A3
		public virtual void AutoAdjustSampleDistancesOff()
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_AutoAdjustSampleDistancesOff_01(base.GetCppThis());
		}

		// Token: 0x06002CC1 RID: 11457
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUVolumeRayCastMapper_AutoAdjustSampleDistancesOn_02(HandleRef pThis);

		/// <summary>
		/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
		/// will be varied to achieve the allocated render time of this
		/// prop (controlled by the desired update rate and any culling in
		/// use).
		/// </summary>
		// Token: 0x06002CC2 RID: 11458 RVA: 0x00041EB2 File Offset: 0x000400B2
		public virtual void AutoAdjustSampleDistancesOn()
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_AutoAdjustSampleDistancesOn_02(base.GetCppThis());
		}

		// Token: 0x06002CC3 RID: 11459
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUVolumeRayCastMapper_ClampDepthToBackfaceOff_03(HandleRef pThis);

		/// <summary>
		/// Enable or disable clamping the depth value of the fully
		/// transparent voxel to the depth of the back-face of the
		/// volume. This parameter is used when RenderToImage mode is
		/// enabled. When ClampDepthToBackFace is false, the fully transparent
		/// voxels will have a value of 1.0 in the depth image. When
		/// this is true, the fully transparent voxels will have the
		/// depth value of the face at which the ray exits the volume.
		/// By default, this is set to 0 (off).
		/// \sa SetRenderToImage(), GetDepthImage()
		/// </summary>
		// Token: 0x06002CC4 RID: 11460 RVA: 0x00041EC1 File Offset: 0x000400C1
		public virtual void ClampDepthToBackfaceOff()
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_ClampDepthToBackfaceOff_03(base.GetCppThis());
		}

		// Token: 0x06002CC5 RID: 11461
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUVolumeRayCastMapper_ClampDepthToBackfaceOn_04(HandleRef pThis);

		/// <summary>
		/// Enable or disable clamping the depth value of the fully
		/// transparent voxel to the depth of the back-face of the
		/// volume. This parameter is used when RenderToImage mode is
		/// enabled. When ClampDepthToBackFace is false, the fully transparent
		/// voxels will have a value of 1.0 in the depth image. When
		/// this is true, the fully transparent voxels will have the
		/// depth value of the face at which the ray exits the volume.
		/// By default, this is set to 0 (off).
		/// \sa SetRenderToImage(), GetDepthImage()
		/// </summary>
		// Token: 0x06002CC6 RID: 11462 RVA: 0x00041ED0 File Offset: 0x000400D0
		public virtual void ClampDepthToBackfaceOn()
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_ClampDepthToBackfaceOn_04(base.GetCppThis());
		}

		// Token: 0x06002CC7 RID: 11463
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUVolumeRayCastMapper_CreateCanonicalView_05(HandleRef pThis, HandleRef ren, HandleRef volume, HandleRef image, int blend_mode, IntPtr viewDirection, IntPtr viewUp);

		/// <summary>
		/// Based on hardware and properties, we may or may not be able to
		/// render using 3D texture mapping. This indicates if 3D texture
		/// mapping is supported by the hardware, and if the other extensions
		/// necessary to support the specific properties are available.
		/// </summary>
		// Token: 0x06002CC8 RID: 11464 RVA: 0x00041EE0 File Offset: 0x000400E0
		public void CreateCanonicalView(vtkRenderer ren, vtkVolume volume, vtkImageData image, int blend_mode, IntPtr viewDirection, IntPtr viewUp)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_CreateCanonicalView_05(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (volume == null) ? default(HandleRef) : volume.GetCppThis(), (image == null) ? default(HandleRef) : image.GetCppThis(), blend_mode, viewDirection, viewUp);
		}

		// Token: 0x06002CC9 RID: 11465
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUVolumeRayCastMapper_GPURender_06(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		/// <summary>
		/// Handled in the subclass - the actual render method
		/// \pre input is up-to-date.
		/// </summary>
		// Token: 0x06002CCA RID: 11466 RVA: 0x00041F40 File Offset: 0x00040140
		public virtual void GPURender(vtkRenderer arg0, vtkVolume arg1)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GPURender_06(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x06002CCB RID: 11467
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGPUVolumeRayCastMapper_GetAutoAdjustSampleDistances_07(HandleRef pThis);

		/// <summary>
		/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
		/// will be varied to achieve the allocated render time of this
		/// prop (controlled by the desired update rate and any culling in
		/// use).
		/// </summary>
		// Token: 0x06002CCC RID: 11468 RVA: 0x00041F84 File Offset: 0x00040184
		public virtual int GetAutoAdjustSampleDistances()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetAutoAdjustSampleDistances_07(base.GetCppThis());
		}

		// Token: 0x06002CCD RID: 11469
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGPUVolumeRayCastMapper_GetAutoAdjustSampleDistancesMaxValue_08(HandleRef pThis);

		/// <summary>
		/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
		/// will be varied to achieve the allocated render time of this
		/// prop (controlled by the desired update rate and any culling in
		/// use).
		/// </summary>
		// Token: 0x06002CCE RID: 11470 RVA: 0x00041FA4 File Offset: 0x000401A4
		public virtual int GetAutoAdjustSampleDistancesMaxValue()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetAutoAdjustSampleDistancesMaxValue_08(base.GetCppThis());
		}

		// Token: 0x06002CCF RID: 11471
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGPUVolumeRayCastMapper_GetAutoAdjustSampleDistancesMinValue_09(HandleRef pThis);

		/// <summary>
		/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
		/// will be varied to achieve the allocated render time of this
		/// prop (controlled by the desired update rate and any culling in
		/// use).
		/// </summary>
		// Token: 0x06002CD0 RID: 11472 RVA: 0x00041FC4 File Offset: 0x000401C4
		public virtual int GetAutoAdjustSampleDistancesMinValue()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetAutoAdjustSampleDistancesMinValue_09(base.GetCppThis());
		}

		// Token: 0x06002CD1 RID: 11473
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGPUVolumeRayCastMapper_GetBoundsFromPort_10(HandleRef pThis, int port);

		/// <summary>
		/// Number of currently active ports.
		/// </summary>
		// Token: 0x06002CD2 RID: 11474 RVA: 0x00041FE4 File Offset: 0x000401E4
		public IntPtr GetBoundsFromPort(int port)
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetBoundsFromPort_10(base.GetCppThis(), port);
		}

		// Token: 0x06002CD3 RID: 11475
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGPUVolumeRayCastMapper_GetClampDepthToBackface_11(HandleRef pThis);

		/// <summary>
		/// Enable or disable clamping the depth value of the fully
		/// transparent voxel to the depth of the back-face of the
		/// volume. This parameter is used when RenderToImage mode is
		/// enabled. When ClampDepthToBackFace is false, the fully transparent
		/// voxels will have a value of 1.0 in the depth image. When
		/// this is true, the fully transparent voxels will have the
		/// depth value of the face at which the ray exits the volume.
		/// By default, this is set to 0 (off).
		/// \sa SetRenderToImage(), GetDepthImage()
		/// </summary>
		// Token: 0x06002CD4 RID: 11476 RVA: 0x00042004 File Offset: 0x00040204
		public virtual int GetClampDepthToBackface()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetClampDepthToBackface_11(base.GetCppThis());
		}

		// Token: 0x06002CD5 RID: 11477
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUVolumeRayCastMapper_GetColorImage_12(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Low level API to export the color texture as vtkImageData in
		/// RenderToImage mode.
		/// Should be implemented by the graphics API specific mapper (GL or other).
		/// \sa SetRenderToImage()
		/// </summary>
		// Token: 0x06002CD6 RID: 11478 RVA: 0x00042024 File Offset: 0x00040224
		public virtual void GetColorImage(vtkImageData arg0)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetColorImage_12(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002CD7 RID: 11479
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGPUVolumeRayCastMapper_GetColorRangeType_13(HandleRef pThis);

		/// <summary>
		/// Set whether to use the scalar range or the native transfer function range
		/// when looking up transfer functions for color and opacity values. When the
		/// range is set to TransferFunctionRange::SCALAR, the function is distributed
		/// over the entire scalar range. If it is set to
		/// TransferFunctionRange::NATIVE, the scalar values outside the native
		/// transfer function range will be truncated to native range. By
		/// default, the volume scalar range is used.
		///
		/// \note The native range of the transfer function is the range returned by
		/// vtkColorTransferFunction::GetRange() or vtkPiecewiseFunction::GetRange().
		///
		/// \note There is no special API provided for 2D transfer functions
		/// considering that they are set as a pre-generated vtkImageData on this
		/// class i.e. the range is already encoded.
		/// </summary>
		// Token: 0x06002CD8 RID: 11480 RVA: 0x00042054 File Offset: 0x00040254
		public virtual int GetColorRangeType()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetColorRangeType_13(base.GetCppThis());
		}

		// Token: 0x06002CD9 RID: 11481
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUVolumeRayCastMapper_GetDepthImage_14(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Low level API to export the depth texture as vtkImageData in
		/// RenderToImage mode.
		/// Should be implemented by the graphics API specific mapper (GL or other).
		/// \sa SetRenderToImage()
		/// </summary>
		// Token: 0x06002CDA RID: 11482 RVA: 0x00042074 File Offset: 0x00040274
		public virtual void GetDepthImage(vtkImageData arg0)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetDepthImage_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002CDB RID: 11483
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGPUVolumeRayCastMapper_GetDepthImageScalarType_15(HandleRef pThis);

		/// <summary>
		/// Set/Get the scalar type of the depth texture in RenderToImage mode.
		/// By default, the type if VTK_FLOAT.
		/// \sa SetRenderToImage()
		/// </summary>
		// Token: 0x06002CDC RID: 11484 RVA: 0x000420A4 File Offset: 0x000402A4
		public virtual int GetDepthImageScalarType()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetDepthImageScalarType_15(base.GetCppThis());
		}

		// Token: 0x06002CDD RID: 11485
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGPUVolumeRayCastMapper_GetDepthPassContourValues_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return handle to contour values container so
		/// that values can be set by the application. Contour values
		/// will be used only when UseDepthPass is on.
		/// </summary>
		// Token: 0x06002CDE RID: 11486 RVA: 0x000420C4 File Offset: 0x000402C4
		public vtkContourValues GetDepthPassContourValues()
		{
			vtkContourValues vtkContourValues = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetDepthPassContourValues_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkContourValues = (vtkContourValues)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkContourValues.Register(null);
				}
			}
			return vtkContourValues;
		}

		// Token: 0x06002CDF RID: 11487
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkGPUVolumeRayCastMapper_GetFinalColorLevel_17(HandleRef pThis);

		/// <summary>
		/// Set/Get the window / level applied to the final color.
		/// This allows brightness / contrast adjustments on the
		/// final image.
		/// window is the width of the window.
		/// level is the center of the window.
		/// Initial window value is 1.0
		/// Initial level value is 0.5
		/// window cannot be null but can be negative, this way
		/// values will be reversed.
		/// |window| can be larger than 1.0
		/// level can be any real value.
		/// </summary>
		// Token: 0x06002CE0 RID: 11488 RVA: 0x00042134 File Offset: 0x00040334
		public virtual float GetFinalColorLevel()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetFinalColorLevel_17(base.GetCppThis());
		}

		// Token: 0x06002CE1 RID: 11489
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkGPUVolumeRayCastMapper_GetFinalColorWindow_18(HandleRef pThis);

		/// <summary>
		/// Set/Get the window / level applied to the final color.
		/// This allows brightness / contrast adjustments on the
		/// final image.
		/// window is the width of the window.
		/// level is the center of the window.
		/// Initial window value is 1.0
		/// Initial level value is 0.5
		/// window cannot be null but can be negative, this way
		/// values will be reversed.
		/// |window| can be larger than 1.0
		/// level can be any real value.
		/// </summary>
		// Token: 0x06002CE2 RID: 11490 RVA: 0x00042154 File Offset: 0x00040354
		public virtual float GetFinalColorWindow()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetFinalColorWindow_18(base.GetCppThis());
		}

		// Token: 0x06002CE3 RID: 11491
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkGPUVolumeRayCastMapper_GetGlobalIlluminationReach_19(HandleRef pThis);

		/// <summary>
		/// This parameter acts as a balance between localness
		/// and globalness of shadows.
		/// A value of 0.0 will be faster, but we'll only capture local shadows.
		/// A value of 1.0 will be slower, but we'll capture all shadows.
		/// The default value is 0.0.
		/// </summary>
		// Token: 0x06002CE4 RID: 11492 RVA: 0x00042174 File Offset: 0x00040374
		public virtual float GetGlobalIlluminationReach()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetGlobalIlluminationReach_19(base.GetCppThis());
		}

		// Token: 0x06002CE5 RID: 11493
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkGPUVolumeRayCastMapper_GetGlobalIlluminationReachMaxValue_20(HandleRef pThis);

		/// <summary>
		/// This parameter acts as a balance between localness
		/// and globalness of shadows.
		/// A value of 0.0 will be faster, but we'll only capture local shadows.
		/// A value of 1.0 will be slower, but we'll capture all shadows.
		/// The default value is 0.0.
		/// </summary>
		// Token: 0x06002CE6 RID: 11494 RVA: 0x00042194 File Offset: 0x00040394
		public virtual float GetGlobalIlluminationReachMaxValue()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetGlobalIlluminationReachMaxValue_20(base.GetCppThis());
		}

		// Token: 0x06002CE7 RID: 11495
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkGPUVolumeRayCastMapper_GetGlobalIlluminationReachMinValue_21(HandleRef pThis);

		/// <summary>
		/// This parameter acts as a balance between localness
		/// and globalness of shadows.
		/// A value of 0.0 will be faster, but we'll only capture local shadows.
		/// A value of 1.0 will be slower, but we'll capture all shadows.
		/// The default value is 0.0.
		/// </summary>
		// Token: 0x06002CE8 RID: 11496 RVA: 0x000421B4 File Offset: 0x000403B4
		public virtual float GetGlobalIlluminationReachMinValue()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetGlobalIlluminationReachMinValue_21(base.GetCppThis());
		}

		// Token: 0x06002CE9 RID: 11497
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGPUVolumeRayCastMapper_GetGradientOpacityRangeType_22(HandleRef pThis);

		/// <summary>
		/// Set whether to use the scalar range or the native transfer function range
		/// when looking up transfer functions for color and opacity values. When the
		/// range is set to TransferFunctionRange::SCALAR, the function is distributed
		/// over the entire scalar range. If it is set to
		/// TransferFunctionRange::NATIVE, the scalar values outside the native
		/// transfer function range will be truncated to native range. By
		/// default, the volume scalar range is used.
		///
		/// \note The native range of the transfer function is the range returned by
		/// vtkColorTransferFunction::GetRange() or vtkPiecewiseFunction::GetRange().
		///
		/// \note There is no special API provided for 2D transfer functions
		/// considering that they are set as a pre-generated vtkImageData on this
		/// class i.e. the range is already encoded.
		/// </summary>
		// Token: 0x06002CEA RID: 11498 RVA: 0x000421D4 File Offset: 0x000403D4
		public virtual int GetGradientOpacityRangeType()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetGradientOpacityRangeType_22(base.GetCppThis());
		}

		// Token: 0x06002CEB RID: 11499
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkGPUVolumeRayCastMapper_GetImageSampleDistance_23(HandleRef pThis);

		/// <summary>
		/// Sampling distance in the XY image dimensions. Default value of 1 meaning
		/// 1 ray cast per pixel. If set to 0.5, 4 rays will be cast per pixel. If
		/// set to 2.0, 1 ray will be cast for every 4 (2 by 2) pixels. This value
		/// will be adjusted to meet a desired frame rate when AutoAdjustSampleDistances
		/// is on.
		/// </summary>
		// Token: 0x06002CEC RID: 11500 RVA: 0x000421F4 File Offset: 0x000403F4
		public virtual float GetImageSampleDistance()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetImageSampleDistance_23(base.GetCppThis());
		}

		// Token: 0x06002CED RID: 11501
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkGPUVolumeRayCastMapper_GetImageSampleDistanceMaxValue_24(HandleRef pThis);

		/// <summary>
		/// Sampling distance in the XY image dimensions. Default value of 1 meaning
		/// 1 ray cast per pixel. If set to 0.5, 4 rays will be cast per pixel. If
		/// set to 2.0, 1 ray will be cast for every 4 (2 by 2) pixels. This value
		/// will be adjusted to meet a desired frame rate when AutoAdjustSampleDistances
		/// is on.
		/// </summary>
		// Token: 0x06002CEE RID: 11502 RVA: 0x00042214 File Offset: 0x00040414
		public virtual float GetImageSampleDistanceMaxValue()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetImageSampleDistanceMaxValue_24(base.GetCppThis());
		}

		// Token: 0x06002CEF RID: 11503
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkGPUVolumeRayCastMapper_GetImageSampleDistanceMinValue_25(HandleRef pThis);

		/// <summary>
		/// Sampling distance in the XY image dimensions. Default value of 1 meaning
		/// 1 ray cast per pixel. If set to 0.5, 4 rays will be cast per pixel. If
		/// set to 2.0, 1 ray will be cast for every 4 (2 by 2) pixels. This value
		/// will be adjusted to meet a desired frame rate when AutoAdjustSampleDistances
		/// is on.
		/// </summary>
		// Token: 0x06002CF0 RID: 11504 RVA: 0x00042234 File Offset: 0x00040434
		public virtual float GetImageSampleDistanceMinValue()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetImageSampleDistanceMinValue_25(base.GetCppThis());
		}

		// Token: 0x06002CF1 RID: 11505
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGPUVolumeRayCastMapper_GetInput_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set whether to use the scalar range or the native transfer function range
		/// when looking up transfer functions for color and opacity values. When the
		/// range is set to TransferFunctionRange::SCALAR, the function is distributed
		/// over the entire scalar range. If it is set to
		/// TransferFunctionRange::NATIVE, the scalar values outside the native
		/// transfer function range will be truncated to native range. By
		/// default, the volume scalar range is used.
		///
		/// \note The native range of the transfer function is the range returned by
		/// vtkColorTransferFunction::GetRange() or vtkPiecewiseFunction::GetRange().
		///
		/// \note There is no special API provided for 2D transfer functions
		/// considering that they are set as a pre-generated vtkImageData on this
		/// class i.e. the range is already encoded.
		/// </summary>
		// Token: 0x06002CF2 RID: 11506 RVA: 0x00042254 File Offset: 0x00040454
		public override vtkDataSet GetInput()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetInput_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		// Token: 0x06002CF3 RID: 11507
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGPUVolumeRayCastMapper_GetInputCount_27(HandleRef pThis);

		/// <summary>
		/// Number of currently active ports.
		/// </summary>
		// Token: 0x06002CF4 RID: 11508 RVA: 0x000422C4 File Offset: 0x000404C4
		public int GetInputCount()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetInputCount_27(base.GetCppThis());
		}

		// Token: 0x06002CF5 RID: 11509
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGPUVolumeRayCastMapper_GetLockSampleDistanceToInputSpacing_28(HandleRef pThis);

		/// <summary>
		/// Compute the sample distance from the data spacing.  When the number of
		/// voxels is 8, the sample distance will be roughly 1/200 the average voxel
		/// size. The distance will grow proportionally to numVoxels^(1/3). Off by default.
		/// </summary>
		// Token: 0x06002CF6 RID: 11510 RVA: 0x000422E4 File Offset: 0x000404E4
		public virtual int GetLockSampleDistanceToInputSpacing()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetLockSampleDistanceToInputSpacing_28(base.GetCppThis());
		}

		// Token: 0x06002CF7 RID: 11511
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGPUVolumeRayCastMapper_GetLockSampleDistanceToInputSpacingMaxValue_29(HandleRef pThis);

		/// <summary>
		/// Compute the sample distance from the data spacing.  When the number of
		/// voxels is 8, the sample distance will be roughly 1/200 the average voxel
		/// size. The distance will grow proportionally to numVoxels^(1/3). Off by default.
		/// </summary>
		// Token: 0x06002CF8 RID: 11512 RVA: 0x00042304 File Offset: 0x00040504
		public virtual int GetLockSampleDistanceToInputSpacingMaxValue()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetLockSampleDistanceToInputSpacingMaxValue_29(base.GetCppThis());
		}

		// Token: 0x06002CF9 RID: 11513
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGPUVolumeRayCastMapper_GetLockSampleDistanceToInputSpacingMinValue_30(HandleRef pThis);

		/// <summary>
		/// Compute the sample distance from the data spacing.  When the number of
		/// voxels is 8, the sample distance will be roughly 1/200 the average voxel
		/// size. The distance will grow proportionally to numVoxels^(1/3). Off by default.
		/// </summary>
		// Token: 0x06002CFA RID: 11514 RVA: 0x00042324 File Offset: 0x00040524
		public virtual int GetLockSampleDistanceToInputSpacingMinValue()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetLockSampleDistanceToInputSpacingMinValue_30(base.GetCppThis());
		}

		// Token: 0x06002CFB RID: 11515
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkGPUVolumeRayCastMapper_GetMaskBlendFactor_31(HandleRef pThis);

		/// <summary>
		/// Tells how much mask color transfer function is used compared to the
		/// standard color transfer function when the mask is true. This is relevant
		/// only for the label map mask.
		/// 0.0 means only standard color transfer function.
		/// 1.0 means only mask color transfer function.
		/// The default value is 1.0.
		/// </summary>
		// Token: 0x06002CFC RID: 11516 RVA: 0x00042344 File Offset: 0x00040544
		public virtual float GetMaskBlendFactor()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetMaskBlendFactor_31(base.GetCppThis());
		}

		// Token: 0x06002CFD RID: 11517
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkGPUVolumeRayCastMapper_GetMaskBlendFactorMaxValue_32(HandleRef pThis);

		/// <summary>
		/// Tells how much mask color transfer function is used compared to the
		/// standard color transfer function when the mask is true. This is relevant
		/// only for the label map mask.
		/// 0.0 means only standard color transfer function.
		/// 1.0 means only mask color transfer function.
		/// The default value is 1.0.
		/// </summary>
		// Token: 0x06002CFE RID: 11518 RVA: 0x00042364 File Offset: 0x00040564
		public virtual float GetMaskBlendFactorMaxValue()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetMaskBlendFactorMaxValue_32(base.GetCppThis());
		}

		// Token: 0x06002CFF RID: 11519
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkGPUVolumeRayCastMapper_GetMaskBlendFactorMinValue_33(HandleRef pThis);

		/// <summary>
		/// Tells how much mask color transfer function is used compared to the
		/// standard color transfer function when the mask is true. This is relevant
		/// only for the label map mask.
		/// 0.0 means only standard color transfer function.
		/// 1.0 means only mask color transfer function.
		/// The default value is 1.0.
		/// </summary>
		// Token: 0x06002D00 RID: 11520 RVA: 0x00042384 File Offset: 0x00040584
		public virtual float GetMaskBlendFactorMinValue()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetMaskBlendFactorMinValue_33(base.GetCppThis());
		}

		// Token: 0x06002D01 RID: 11521
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGPUVolumeRayCastMapper_GetMaskInput_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Optionally, set a mask input. This mask may be a binary mask or a label
		/// map. This must be specified via SetMaskType.
		///
		/// If the mask is a binary mask, the volume rendering is confined to regions
		/// within the binary mask. The binary mask is assumed to have a datatype of
		/// UCHAR and values of 255 (inside) and 0 (outside).
		///
		/// The mask may also be a label map. The label map must have a datatype of
		/// UCHAR i.e. it can have upto 256 labels. The label 0 is reserved as a
		/// special label. In voxels with label value of 0, the default transfer
		/// functions supplied by vtkVolumeProperty are used.
		///
		/// For voxels with a label values greater than 0, the color transfer functions
		/// supplied using vtkVolumeProperty's label API are used.
		///
		/// For voxels with a label value greater than 0, the color transfer function
		/// is blended with the default color transfer function, with the blending
		/// weight determined by MaskBlendFactor.
		/// </summary>
		// Token: 0x06002D02 RID: 11522 RVA: 0x000423A4 File Offset: 0x000405A4
		public virtual vtkImageData GetMaskInput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetMaskInput_34(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06002D03 RID: 11523
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGPUVolumeRayCastMapper_GetMaskType_35(HandleRef pThis);

		/// <summary>
		/// Set the mask type, if mask is to be used. See documentation for
		/// SetMaskInput(). The default is a LabelMapMaskType.
		/// </summary>
		// Token: 0x06002D04 RID: 11524 RVA: 0x00042414 File Offset: 0x00040614
		public virtual int GetMaskType()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetMaskType_35(base.GetCppThis());
		}

		// Token: 0x06002D05 RID: 11525
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkGPUVolumeRayCastMapper_GetMaxMemoryFraction_36(HandleRef pThis);

		/// <summary>
		/// Maximum fraction of the MaxMemoryInBytes that should
		/// be used to hold the texture. Valid values are 0.1 to
		/// 1.0.
		/// </summary>
		// Token: 0x06002D06 RID: 11526 RVA: 0x00042434 File Offset: 0x00040634
		public virtual float GetMaxMemoryFraction()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetMaxMemoryFraction_36(base.GetCppThis());
		}

		// Token: 0x06002D07 RID: 11527
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkGPUVolumeRayCastMapper_GetMaxMemoryFractionMaxValue_37(HandleRef pThis);

		/// <summary>
		/// Maximum fraction of the MaxMemoryInBytes that should
		/// be used to hold the texture. Valid values are 0.1 to
		/// 1.0.
		/// </summary>
		// Token: 0x06002D08 RID: 11528 RVA: 0x00042454 File Offset: 0x00040654
		public virtual float GetMaxMemoryFractionMaxValue()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetMaxMemoryFractionMaxValue_37(base.GetCppThis());
		}

		// Token: 0x06002D09 RID: 11529
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkGPUVolumeRayCastMapper_GetMaxMemoryFractionMinValue_38(HandleRef pThis);

		/// <summary>
		/// Maximum fraction of the MaxMemoryInBytes that should
		/// be used to hold the texture. Valid values are 0.1 to
		/// 1.0.
		/// </summary>
		// Token: 0x06002D0A RID: 11530 RVA: 0x00042474 File Offset: 0x00040674
		public virtual float GetMaxMemoryFractionMinValue()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetMaxMemoryFractionMinValue_38(base.GetCppThis());
		}

		// Token: 0x06002D0B RID: 11531
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGPUVolumeRayCastMapper_GetMaxMemoryInBytes_39(HandleRef pThis);

		/// <summary>
		/// Maximum size of the 3D texture in GPU memory.
		/// Will default to the size computed from the graphics
		/// card. Can be adjusted by the user.
		/// </summary>
		// Token: 0x06002D0C RID: 11532 RVA: 0x00042494 File Offset: 0x00040694
		public virtual long GetMaxMemoryInBytes()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetMaxMemoryInBytes_39(base.GetCppThis());
		}

		// Token: 0x06002D0D RID: 11533
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkGPUVolumeRayCastMapper_GetMaximumImageSampleDistance_40(HandleRef pThis);

		/// <summary>
		/// This is the maximum image sample distance allow when the image
		/// sample distance is being automatically adjusted.
		/// </summary>
		// Token: 0x06002D0E RID: 11534 RVA: 0x000424B4 File Offset: 0x000406B4
		public virtual float GetMaximumImageSampleDistance()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetMaximumImageSampleDistance_40(base.GetCppThis());
		}

		// Token: 0x06002D0F RID: 11535
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkGPUVolumeRayCastMapper_GetMaximumImageSampleDistanceMaxValue_41(HandleRef pThis);

		/// <summary>
		/// This is the maximum image sample distance allow when the image
		/// sample distance is being automatically adjusted.
		/// </summary>
		// Token: 0x06002D10 RID: 11536 RVA: 0x000424D4 File Offset: 0x000406D4
		public virtual float GetMaximumImageSampleDistanceMaxValue()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetMaximumImageSampleDistanceMaxValue_41(base.GetCppThis());
		}

		// Token: 0x06002D11 RID: 11537
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkGPUVolumeRayCastMapper_GetMaximumImageSampleDistanceMinValue_42(HandleRef pThis);

		/// <summary>
		/// This is the maximum image sample distance allow when the image
		/// sample distance is being automatically adjusted.
		/// </summary>
		// Token: 0x06002D12 RID: 11538 RVA: 0x000424F4 File Offset: 0x000406F4
		public virtual float GetMaximumImageSampleDistanceMinValue()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetMaximumImageSampleDistanceMinValue_42(base.GetCppThis());
		}

		// Token: 0x06002D13 RID: 11539
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkGPUVolumeRayCastMapper_GetMinimumImageSampleDistance_43(HandleRef pThis);

		/// <summary>
		/// This is the minimum image sample distance allow when the image
		/// sample distance is being automatically adjusted.
		/// </summary>
		// Token: 0x06002D14 RID: 11540 RVA: 0x00042514 File Offset: 0x00040714
		public virtual float GetMinimumImageSampleDistance()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetMinimumImageSampleDistance_43(base.GetCppThis());
		}

		// Token: 0x06002D15 RID: 11541
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkGPUVolumeRayCastMapper_GetMinimumImageSampleDistanceMaxValue_44(HandleRef pThis);

		/// <summary>
		/// This is the minimum image sample distance allow when the image
		/// sample distance is being automatically adjusted.
		/// </summary>
		// Token: 0x06002D16 RID: 11542 RVA: 0x00042534 File Offset: 0x00040734
		public virtual float GetMinimumImageSampleDistanceMaxValue()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetMinimumImageSampleDistanceMaxValue_44(base.GetCppThis());
		}

		// Token: 0x06002D17 RID: 11543
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkGPUVolumeRayCastMapper_GetMinimumImageSampleDistanceMinValue_45(HandleRef pThis);

		/// <summary>
		/// This is the minimum image sample distance allow when the image
		/// sample distance is being automatically adjusted.
		/// </summary>
		// Token: 0x06002D18 RID: 11544 RVA: 0x00042554 File Offset: 0x00040754
		public virtual float GetMinimumImageSampleDistanceMinValue()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetMinimumImageSampleDistanceMinValue_45(base.GetCppThis());
		}

		// Token: 0x06002D19 RID: 11545
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGPUVolumeRayCastMapper_GetNumberOfGenerationsFromBase_46(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002D1A RID: 11546 RVA: 0x00042574 File Offset: 0x00040774
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetNumberOfGenerationsFromBase_46(base.GetCppThis(), type);
		}

		// Token: 0x06002D1B RID: 11547
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGPUVolumeRayCastMapper_GetNumberOfGenerationsFromBaseType_47([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002D1C RID: 11548 RVA: 0x00042594 File Offset: 0x00040794
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetNumberOfGenerationsFromBaseType_47(type);
		}

		// Token: 0x06002D1D RID: 11549
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUVolumeRayCastMapper_GetReductionRatio_48(HandleRef pThis, IntPtr ratio);

		/// <summary>
		/// Return how much the dataset has to be reduced in each dimension to
		/// fit on the GPU. If the value is 1.0, there is no need to reduce the
		/// dataset.
		/// \pre the calling thread has a current OpenGL context.
		/// \pre mapper_supported: IsRenderSupported(renderer-&gt;GetRenderWindow(),0)
		/// The computation is based on hardware limits (3D texture indexable size)
		/// and MaxMemoryInBytes.
		/// \post valid_i_ratio: ratio[0]&gt;0 &amp;&amp; ratio[0]&lt;=1.0
		/// \post valid_j_ratio: ratio[1]&gt;0 &amp;&amp; ratio[1]&lt;=1.0
		/// \post valid_k_ratio: ratio[2]&gt;0 &amp;&amp; ratio[2]&lt;=1.0
		/// </summary>
		// Token: 0x06002D1E RID: 11550 RVA: 0x000425AE File Offset: 0x000407AE
		public virtual void GetReductionRatio(IntPtr ratio)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetReductionRatio_48(base.GetCppThis(), ratio);
		}

		// Token: 0x06002D1F RID: 11551
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGPUVolumeRayCastMapper_GetRenderToImage_49(HandleRef pThis);

		/// <summary>
		/// Enable or disable setting output of volume rendering to be
		/// color and depth textures. By default this is set to 0 (off).
		/// It should be noted that it is possible that underlying API specific
		/// mapper may not supoport RenderToImage mode.
		/// \warning
		/// \li This method ignores any other volumes / props in the scene.
		/// \li This method does not respect the general attributes of the
		/// scene i.e. background color, etc. It always produces a color
		/// image that has a transparent white background outside the
		/// bounds of the volume.
		///
		/// \sa GetDepthImage(), GetColorImage()
		/// </summary>
		// Token: 0x06002D20 RID: 11552 RVA: 0x000425C0 File Offset: 0x000407C0
		public virtual int GetRenderToImage()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetRenderToImage_49(base.GetCppThis());
		}

		// Token: 0x06002D21 RID: 11553
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGPUVolumeRayCastMapper_GetReportProgress_50(HandleRef pThis);

		/// <summary>
		/// Tells if the mapper will report intermediate progress.
		/// Initial value is true. As the progress works with a GL blocking
		/// call (glFinish()), this can be useful for huge dataset but can
		/// slow down rendering of small dataset. It should be set to true
		/// for big dataset or complex shading and streaming but to false for
		/// small datasets.
		/// </summary>
		// Token: 0x06002D22 RID: 11554 RVA: 0x000425E0 File Offset: 0x000407E0
		public virtual bool GetReportProgress()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetReportProgress_50(base.GetCppThis()) != 0;
		}

		// Token: 0x06002D23 RID: 11555
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkGPUVolumeRayCastMapper_GetSampleDistance_51(HandleRef pThis);

		/// <summary>
		/// Set/Get the distance between samples used for rendering
		/// when AutoAdjustSampleDistances is off, or when this mapper
		/// has more than 1 second allocated to it for rendering.
		/// Initial value is 1.0.
		/// </summary>
		// Token: 0x06002D24 RID: 11556 RVA: 0x00042608 File Offset: 0x00040808
		public virtual float GetSampleDistance()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetSampleDistance_51(base.GetCppThis());
		}

		// Token: 0x06002D25 RID: 11557
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGPUVolumeRayCastMapper_GetScalarOpacityRangeType_52(HandleRef pThis);

		/// <summary>
		/// Set whether to use the scalar range or the native transfer function range
		/// when looking up transfer functions for color and opacity values. When the
		/// range is set to TransferFunctionRange::SCALAR, the function is distributed
		/// over the entire scalar range. If it is set to
		/// TransferFunctionRange::NATIVE, the scalar values outside the native
		/// transfer function range will be truncated to native range. By
		/// default, the volume scalar range is used.
		///
		/// \note The native range of the transfer function is the range returned by
		/// vtkColorTransferFunction::GetRange() or vtkPiecewiseFunction::GetRange().
		///
		/// \note There is no special API provided for 2D transfer functions
		/// considering that they are set as a pre-generated vtkImageData on this
		/// class i.e. the range is already encoded.
		/// </summary>
		// Token: 0x06002D26 RID: 11558 RVA: 0x00042628 File Offset: 0x00040828
		public virtual int GetScalarOpacityRangeType()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetScalarOpacityRangeType_52(base.GetCppThis());
		}

		// Token: 0x06002D27 RID: 11559
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGPUVolumeRayCastMapper_GetTransfer2DYAxisArray_53(HandleRef pThis);

		/// <summary>
		/// Set/Get the transfer 2D Y axis array
		/// </summary>
		// Token: 0x06002D28 RID: 11560 RVA: 0x00042648 File Offset: 0x00040848
		public virtual string GetTransfer2DYAxisArray()
		{
			string s = Marshal.PtrToStringAnsi(vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetTransfer2DYAxisArray_53(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06002D29 RID: 11561
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGPUVolumeRayCastMapper_GetTransformedInput_54(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Number of currently active ports.
		/// </summary>
		// Token: 0x06002D2A RID: 11562 RVA: 0x00042684 File Offset: 0x00040884
		public vtkDataSet GetTransformedInput(int port)
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetTransformedInput_54(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		// Token: 0x06002D2B RID: 11563
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGPUVolumeRayCastMapper_GetUseDepthPass_55(HandleRef pThis);

		/// <summary>
		/// If UseDepthPass is on, the mapper will use two passes. In the first
		/// pass, an isocontour depth buffer will be utilized as starting point
		/// for ray-casting hence eliminating traversal on voxels that are
		/// not going to participate in final rendering. UseDepthPass requires
		/// reasonable contour values to be set which can be set by calling
		/// GetDepthPassContourValues() method and using vtkControurValues API.
		/// </summary>
		// Token: 0x06002D2C RID: 11564 RVA: 0x000426F4 File Offset: 0x000408F4
		public virtual int GetUseDepthPass()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetUseDepthPass_55(base.GetCppThis());
		}

		// Token: 0x06002D2D RID: 11565
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGPUVolumeRayCastMapper_GetUseDepthPassMaxValue_56(HandleRef pThis);

		/// <summary>
		/// If UseDepthPass is on, the mapper will use two passes. In the first
		/// pass, an isocontour depth buffer will be utilized as starting point
		/// for ray-casting hence eliminating traversal on voxels that are
		/// not going to participate in final rendering. UseDepthPass requires
		/// reasonable contour values to be set which can be set by calling
		/// GetDepthPassContourValues() method and using vtkControurValues API.
		/// </summary>
		// Token: 0x06002D2E RID: 11566 RVA: 0x00042714 File Offset: 0x00040914
		public virtual int GetUseDepthPassMaxValue()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetUseDepthPassMaxValue_56(base.GetCppThis());
		}

		// Token: 0x06002D2F RID: 11567
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGPUVolumeRayCastMapper_GetUseDepthPassMinValue_57(HandleRef pThis);

		/// <summary>
		/// If UseDepthPass is on, the mapper will use two passes. In the first
		/// pass, an isocontour depth buffer will be utilized as starting point
		/// for ray-casting hence eliminating traversal on voxels that are
		/// not going to participate in final rendering. UseDepthPass requires
		/// reasonable contour values to be set which can be set by calling
		/// GetDepthPassContourValues() method and using vtkControurValues API.
		/// </summary>
		// Token: 0x06002D30 RID: 11568 RVA: 0x00042734 File Offset: 0x00040934
		public virtual int GetUseDepthPassMinValue()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetUseDepthPassMinValue_57(base.GetCppThis());
		}

		// Token: 0x06002D31 RID: 11569
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGPUVolumeRayCastMapper_GetUseJittering_58(HandleRef pThis);

		/// <summary>
		/// If UseJittering is on, each ray traversal direction will be
		/// perturbed slightly using a noise-texture to get rid of wood-grain
		/// effect.
		/// </summary>
		// Token: 0x06002D32 RID: 11570 RVA: 0x00042754 File Offset: 0x00040954
		public virtual int GetUseJittering()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetUseJittering_58(base.GetCppThis());
		}

		// Token: 0x06002D33 RID: 11571
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGPUVolumeRayCastMapper_GetUseJitteringMaxValue_59(HandleRef pThis);

		/// <summary>
		/// If UseJittering is on, each ray traversal direction will be
		/// perturbed slightly using a noise-texture to get rid of wood-grain
		/// effect.
		/// </summary>
		// Token: 0x06002D34 RID: 11572 RVA: 0x00042774 File Offset: 0x00040974
		public virtual int GetUseJitteringMaxValue()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetUseJitteringMaxValue_59(base.GetCppThis());
		}

		// Token: 0x06002D35 RID: 11573
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGPUVolumeRayCastMapper_GetUseJitteringMinValue_60(HandleRef pThis);

		/// <summary>
		/// If UseJittering is on, each ray traversal direction will be
		/// perturbed slightly using a noise-texture to get rid of wood-grain
		/// effect.
		/// </summary>
		// Token: 0x06002D36 RID: 11574 RVA: 0x00042794 File Offset: 0x00040994
		public virtual int GetUseJitteringMinValue()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetUseJitteringMinValue_60(base.GetCppThis());
		}

		// Token: 0x06002D37 RID: 11575
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkGPUVolumeRayCastMapper_GetVolumetricScatteringBlending_61(HandleRef pThis);

		/// <summary>
		/// This parameter controls the blending between surfacic approximation
		/// and volumetric multi-scattering. It is only considered when
		/// Shade is enabled.
		/// A value of 0.0 means that no scattered rays will be cast, no volumetric shadows
		/// A value of 1.0 means that the shader will smartly blend between the two models
		/// A value of 2.0 means that the shader only uses the volumetric scattering model.
		/// The blending is not uniform, and is done in the following way:
		/// a value in [0, 1] biases the shader to choose between the two models, and a value
		/// in [1, 2] forces the shader to use more the volumetric model.
		/// </summary>
		// Token: 0x06002D38 RID: 11576 RVA: 0x000427B4 File Offset: 0x000409B4
		public virtual float GetVolumetricScatteringBlending()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetVolumetricScatteringBlending_61(base.GetCppThis());
		}

		// Token: 0x06002D39 RID: 11577
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkGPUVolumeRayCastMapper_GetVolumetricScatteringBlendingMaxValue_62(HandleRef pThis);

		/// <summary>
		/// This parameter controls the blending between surfacic approximation
		/// and volumetric multi-scattering. It is only considered when
		/// Shade is enabled.
		/// A value of 0.0 means that no scattered rays will be cast, no volumetric shadows
		/// A value of 1.0 means that the shader will smartly blend between the two models
		/// A value of 2.0 means that the shader only uses the volumetric scattering model.
		/// The blending is not uniform, and is done in the following way:
		/// a value in [0, 1] biases the shader to choose between the two models, and a value
		/// in [1, 2] forces the shader to use more the volumetric model.
		/// </summary>
		// Token: 0x06002D3A RID: 11578 RVA: 0x000427D4 File Offset: 0x000409D4
		public virtual float GetVolumetricScatteringBlendingMaxValue()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetVolumetricScatteringBlendingMaxValue_62(base.GetCppThis());
		}

		// Token: 0x06002D3B RID: 11579
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkGPUVolumeRayCastMapper_GetVolumetricScatteringBlendingMinValue_63(HandleRef pThis);

		/// <summary>
		/// This parameter controls the blending between surfacic approximation
		/// and volumetric multi-scattering. It is only considered when
		/// Shade is enabled.
		/// A value of 0.0 means that no scattered rays will be cast, no volumetric shadows
		/// A value of 1.0 means that the shader will smartly blend between the two models
		/// A value of 2.0 means that the shader only uses the volumetric scattering model.
		/// The blending is not uniform, and is done in the following way:
		/// a value in [0, 1] biases the shader to choose between the two models, and a value
		/// in [1, 2] forces the shader to use more the volumetric model.
		/// </summary>
		// Token: 0x06002D3C RID: 11580 RVA: 0x000427F4 File Offset: 0x000409F4
		public virtual float GetVolumetricScatteringBlendingMinValue()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetVolumetricScatteringBlendingMinValue_63(base.GetCppThis());
		}

		// Token: 0x06002D3D RID: 11581
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGPUVolumeRayCastMapper_IsA_64(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002D3E RID: 11582 RVA: 0x00042814 File Offset: 0x00040A14
		public override int IsA(string type)
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_IsA_64(base.GetCppThis(), type);
		}

		// Token: 0x06002D3F RID: 11583
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGPUVolumeRayCastMapper_IsRenderSupported_65(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		/// <summary>
		/// Based on hardware and properties, we may or may not be able to
		/// render using 3D texture mapping. This indicates if 3D texture
		/// mapping is supported by the hardware, and if the other extensions
		/// necessary to support the specific properties are available.
		/// </summary>
		// Token: 0x06002D40 RID: 11584 RVA: 0x00042834 File Offset: 0x00040A34
		public virtual int IsRenderSupported(vtkRenderWindow arg0, vtkVolumeProperty arg1)
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_IsRenderSupported_65(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x06002D41 RID: 11585
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGPUVolumeRayCastMapper_IsTypeOf_66([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002D42 RID: 11586 RVA: 0x00042880 File Offset: 0x00040A80
		public new static int IsTypeOf(string type)
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_IsTypeOf_66(type);
		}

		// Token: 0x06002D43 RID: 11587
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUVolumeRayCastMapper_LockSampleDistanceToInputSpacingOff_67(HandleRef pThis);

		/// <summary>
		/// Compute the sample distance from the data spacing.  When the number of
		/// voxels is 8, the sample distance will be roughly 1/200 the average voxel
		/// size. The distance will grow proportionally to numVoxels^(1/3). Off by default.
		/// </summary>
		// Token: 0x06002D44 RID: 11588 RVA: 0x0004289A File Offset: 0x00040A9A
		public virtual void LockSampleDistanceToInputSpacingOff()
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_LockSampleDistanceToInputSpacingOff_67(base.GetCppThis());
		}

		// Token: 0x06002D45 RID: 11589
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUVolumeRayCastMapper_LockSampleDistanceToInputSpacingOn_68(HandleRef pThis);

		/// <summary>
		/// Compute the sample distance from the data spacing.  When the number of
		/// voxels is 8, the sample distance will be roughly 1/200 the average voxel
		/// size. The distance will grow proportionally to numVoxels^(1/3). Off by default.
		/// </summary>
		// Token: 0x06002D46 RID: 11590 RVA: 0x000428A9 File Offset: 0x00040AA9
		public virtual void LockSampleDistanceToInputSpacingOn()
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_LockSampleDistanceToInputSpacingOn_68(base.GetCppThis());
		}

		// Token: 0x06002D47 RID: 11591
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGPUVolumeRayCastMapper_NewInstance_70(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002D48 RID: 11592 RVA: 0x000428B8 File Offset: 0x00040AB8
		public new vtkGPUVolumeRayCastMapper NewInstance()
		{
			vtkGPUVolumeRayCastMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_NewInstance_70(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGPUVolumeRayCastMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06002D49 RID: 11593
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUVolumeRayCastMapper_ReleaseGraphicsResources_71(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Release any graphics resources that are being consumed by this mapper.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// \warning INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// </summary>
		// Token: 0x06002D4A RID: 11594 RVA: 0x00042914 File Offset: 0x00040B14
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_ReleaseGraphicsResources_71(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002D4B RID: 11595
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUVolumeRayCastMapper_RemoveInputConnection_72(HandleRef pThis, int port, HandleRef input);

		/// <summary>
		/// Add/Remove input connections. Active and removed ports are cached in
		/// Ports and RemovedPorts respectively.
		/// </summary>
		// Token: 0x06002D4C RID: 11596 RVA: 0x00042944 File Offset: 0x00040B44
		public override void RemoveInputConnection(int port, vtkAlgorithmOutput input)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_RemoveInputConnection_72(base.GetCppThis(), port, (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x06002D4D RID: 11597
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUVolumeRayCastMapper_RemoveInputConnection_73(HandleRef pThis, int port, int idx);

		/// <summary>
		/// Add/Remove input connections. Active and removed ports are cached in
		/// Ports and RemovedPorts respectively.
		/// </summary>
		// Token: 0x06002D4E RID: 11598 RVA: 0x00042974 File Offset: 0x00040B74
		public override void RemoveInputConnection(int port, int idx)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_RemoveInputConnection_73(base.GetCppThis(), port, idx);
		}

		// Token: 0x06002D4F RID: 11599
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUVolumeRayCastMapper_Render_74(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		/// <summary>
		/// Initialize rendering for this volume.
		/// \warning INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// </summary>
		// Token: 0x06002D50 RID: 11600 RVA: 0x00042988 File Offset: 0x00040B88
		public override void Render(vtkRenderer arg0, vtkVolume arg1)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_Render_74(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x06002D51 RID: 11601
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUVolumeRayCastMapper_RenderToImageOff_75(HandleRef pThis);

		/// <summary>
		/// Enable or disable setting output of volume rendering to be
		/// color and depth textures. By default this is set to 0 (off).
		/// It should be noted that it is possible that underlying API specific
		/// mapper may not supoport RenderToImage mode.
		/// \warning
		/// \li This method ignores any other volumes / props in the scene.
		/// \li This method does not respect the general attributes of the
		/// scene i.e. background color, etc. It always produces a color
		/// image that has a transparent white background outside the
		/// bounds of the volume.
		///
		/// \sa GetDepthImage(), GetColorImage()
		/// </summary>
		// Token: 0x06002D52 RID: 11602 RVA: 0x000429CC File Offset: 0x00040BCC
		public virtual void RenderToImageOff()
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_RenderToImageOff_75(base.GetCppThis());
		}

		// Token: 0x06002D53 RID: 11603
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUVolumeRayCastMapper_RenderToImageOn_76(HandleRef pThis);

		/// <summary>
		/// Enable or disable setting output of volume rendering to be
		/// color and depth textures. By default this is set to 0 (off).
		/// It should be noted that it is possible that underlying API specific
		/// mapper may not supoport RenderToImage mode.
		/// \warning
		/// \li This method ignores any other volumes / props in the scene.
		/// \li This method does not respect the general attributes of the
		/// scene i.e. background color, etc. It always produces a color
		/// image that has a transparent white background outside the
		/// bounds of the volume.
		///
		/// \sa GetDepthImage(), GetColorImage()
		/// </summary>
		// Token: 0x06002D54 RID: 11604 RVA: 0x000429DB File Offset: 0x00040BDB
		public virtual void RenderToImageOn()
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_RenderToImageOn_76(base.GetCppThis());
		}

		// Token: 0x06002D55 RID: 11605
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGPUVolumeRayCastMapper_SafeDownCast_77(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002D56 RID: 11606 RVA: 0x000429EC File Offset: 0x00040BEC
		public new static vtkGPUVolumeRayCastMapper SafeDownCast(vtkObjectBase o)
		{
			vtkGPUVolumeRayCastMapper vtkGPUVolumeRayCastMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_SafeDownCast_77((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGPUVolumeRayCastMapper = (vtkGPUVolumeRayCastMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGPUVolumeRayCastMapper.Register(null);
				}
			}
			return vtkGPUVolumeRayCastMapper;
		}

		// Token: 0x06002D57 RID: 11607
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUVolumeRayCastMapper_SetAutoAdjustSampleDistances_78(HandleRef pThis, int _arg);

		/// <summary>
		/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
		/// will be varied to achieve the allocated render time of this
		/// prop (controlled by the desired update rate and any culling in
		/// use).
		/// </summary>
		// Token: 0x06002D58 RID: 11608 RVA: 0x00042A6B File Offset: 0x00040C6B
		public virtual void SetAutoAdjustSampleDistances(int _arg)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_SetAutoAdjustSampleDistances_78(base.GetCppThis(), _arg);
		}

		// Token: 0x06002D59 RID: 11609
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUVolumeRayCastMapper_SetClampDepthToBackface_79(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable or disable clamping the depth value of the fully
		/// transparent voxel to the depth of the back-face of the
		/// volume. This parameter is used when RenderToImage mode is
		/// enabled. When ClampDepthToBackFace is false, the fully transparent
		/// voxels will have a value of 1.0 in the depth image. When
		/// this is true, the fully transparent voxels will have the
		/// depth value of the face at which the ray exits the volume.
		/// By default, this is set to 0 (off).
		/// \sa SetRenderToImage(), GetDepthImage()
		/// </summary>
		// Token: 0x06002D5A RID: 11610 RVA: 0x00042A7B File Offset: 0x00040C7B
		public virtual void SetClampDepthToBackface(int _arg)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_SetClampDepthToBackface_79(base.GetCppThis(), _arg);
		}

		// Token: 0x06002D5B RID: 11611
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUVolumeRayCastMapper_SetColorRangeType_80(HandleRef pThis, int _arg);

		/// <summary>
		/// Set whether to use the scalar range or the native transfer function range
		/// when looking up transfer functions for color and opacity values. When the
		/// range is set to TransferFunctionRange::SCALAR, the function is distributed
		/// over the entire scalar range. If it is set to
		/// TransferFunctionRange::NATIVE, the scalar values outside the native
		/// transfer function range will be truncated to native range. By
		/// default, the volume scalar range is used.
		///
		/// \note The native range of the transfer function is the range returned by
		/// vtkColorTransferFunction::GetRange() or vtkPiecewiseFunction::GetRange().
		///
		/// \note There is no special API provided for 2D transfer functions
		/// considering that they are set as a pre-generated vtkImageData on this
		/// class i.e. the range is already encoded.
		/// </summary>
		// Token: 0x06002D5C RID: 11612 RVA: 0x00042A8B File Offset: 0x00040C8B
		public virtual void SetColorRangeType(int _arg)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_SetColorRangeType_80(base.GetCppThis(), _arg);
		}

		// Token: 0x06002D5D RID: 11613
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUVolumeRayCastMapper_SetDepthImageScalarType_81(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the scalar type of the depth texture in RenderToImage mode.
		/// By default, the type if VTK_FLOAT.
		/// \sa SetRenderToImage()
		/// </summary>
		// Token: 0x06002D5E RID: 11614 RVA: 0x00042A9B File Offset: 0x00040C9B
		public virtual void SetDepthImageScalarType(int _arg)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_SetDepthImageScalarType_81(base.GetCppThis(), _arg);
		}

		// Token: 0x06002D5F RID: 11615
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUVolumeRayCastMapper_SetDepthImageScalarTypeToFloat_82(HandleRef pThis);

		/// <summary>
		/// Set/Get the scalar type of the depth texture in RenderToImage mode.
		/// By default, the type if VTK_FLOAT.
		/// \sa SetRenderToImage()
		/// </summary>
		// Token: 0x06002D60 RID: 11616 RVA: 0x00042AAB File Offset: 0x00040CAB
		public void SetDepthImageScalarTypeToFloat()
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_SetDepthImageScalarTypeToFloat_82(base.GetCppThis());
		}

		// Token: 0x06002D61 RID: 11617
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUVolumeRayCastMapper_SetDepthImageScalarTypeToUnsignedChar_83(HandleRef pThis);

		/// <summary>
		/// Set/Get the scalar type of the depth texture in RenderToImage mode.
		/// By default, the type if VTK_FLOAT.
		/// \sa SetRenderToImage()
		/// </summary>
		// Token: 0x06002D62 RID: 11618 RVA: 0x00042ABA File Offset: 0x00040CBA
		public void SetDepthImageScalarTypeToUnsignedChar()
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_SetDepthImageScalarTypeToUnsignedChar_83(base.GetCppThis());
		}

		// Token: 0x06002D63 RID: 11619
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUVolumeRayCastMapper_SetDepthImageScalarTypeToUnsignedShort_84(HandleRef pThis);

		/// <summary>
		/// Set/Get the scalar type of the depth texture in RenderToImage mode.
		/// By default, the type if VTK_FLOAT.
		/// \sa SetRenderToImage()
		/// </summary>
		// Token: 0x06002D64 RID: 11620 RVA: 0x00042AC9 File Offset: 0x00040CC9
		public void SetDepthImageScalarTypeToUnsignedShort()
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_SetDepthImageScalarTypeToUnsignedShort_84(base.GetCppThis());
		}

		// Token: 0x06002D65 RID: 11621
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUVolumeRayCastMapper_SetFinalColorLevel_85(HandleRef pThis, float _arg);

		/// <summary>
		/// Set/Get the window / level applied to the final color.
		/// This allows brightness / contrast adjustments on the
		/// final image.
		/// window is the width of the window.
		/// level is the center of the window.
		/// Initial window value is 1.0
		/// Initial level value is 0.5
		/// window cannot be null but can be negative, this way
		/// values will be reversed.
		/// |window| can be larger than 1.0
		/// level can be any real value.
		/// </summary>
		// Token: 0x06002D66 RID: 11622 RVA: 0x00042AD8 File Offset: 0x00040CD8
		public virtual void SetFinalColorLevel(float _arg)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_SetFinalColorLevel_85(base.GetCppThis(), _arg);
		}

		// Token: 0x06002D67 RID: 11623
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUVolumeRayCastMapper_SetFinalColorWindow_86(HandleRef pThis, float _arg);

		/// <summary>
		/// Set/Get the window / level applied to the final color.
		/// This allows brightness / contrast adjustments on the
		/// final image.
		/// window is the width of the window.
		/// level is the center of the window.
		/// Initial window value is 1.0
		/// Initial level value is 0.5
		/// window cannot be null but can be negative, this way
		/// values will be reversed.
		/// |window| can be larger than 1.0
		/// level can be any real value.
		/// </summary>
		// Token: 0x06002D68 RID: 11624 RVA: 0x00042AE8 File Offset: 0x00040CE8
		public virtual void SetFinalColorWindow(float _arg)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_SetFinalColorWindow_86(base.GetCppThis(), _arg);
		}

		// Token: 0x06002D69 RID: 11625
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUVolumeRayCastMapper_SetGlobalIlluminationReach_87(HandleRef pThis, float _arg);

		/// <summary>
		/// This parameter acts as a balance between localness
		/// and globalness of shadows.
		/// A value of 0.0 will be faster, but we'll only capture local shadows.
		/// A value of 1.0 will be slower, but we'll capture all shadows.
		/// The default value is 0.0.
		/// </summary>
		// Token: 0x06002D6A RID: 11626 RVA: 0x00042AF8 File Offset: 0x00040CF8
		public virtual void SetGlobalIlluminationReach(float _arg)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_SetGlobalIlluminationReach_87(base.GetCppThis(), _arg);
		}

		// Token: 0x06002D6B RID: 11627
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUVolumeRayCastMapper_SetGradientOpacityRangeType_88(HandleRef pThis, int _arg);

		/// <summary>
		/// Set whether to use the scalar range or the native transfer function range
		/// when looking up transfer functions for color and opacity values. When the
		/// range is set to TransferFunctionRange::SCALAR, the function is distributed
		/// over the entire scalar range. If it is set to
		/// TransferFunctionRange::NATIVE, the scalar values outside the native
		/// transfer function range will be truncated to native range. By
		/// default, the volume scalar range is used.
		///
		/// \note The native range of the transfer function is the range returned by
		/// vtkColorTransferFunction::GetRange() or vtkPiecewiseFunction::GetRange().
		///
		/// \note There is no special API provided for 2D transfer functions
		/// considering that they are set as a pre-generated vtkImageData on this
		/// class i.e. the range is already encoded.
		/// </summary>
		// Token: 0x06002D6C RID: 11628 RVA: 0x00042B08 File Offset: 0x00040D08
		public virtual void SetGradientOpacityRangeType(int _arg)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_SetGradientOpacityRangeType_88(base.GetCppThis(), _arg);
		}

		// Token: 0x06002D6D RID: 11629
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUVolumeRayCastMapper_SetImageSampleDistance_89(HandleRef pThis, float _arg);

		/// <summary>
		/// Sampling distance in the XY image dimensions. Default value of 1 meaning
		/// 1 ray cast per pixel. If set to 0.5, 4 rays will be cast per pixel. If
		/// set to 2.0, 1 ray will be cast for every 4 (2 by 2) pixels. This value
		/// will be adjusted to meet a desired frame rate when AutoAdjustSampleDistances
		/// is on.
		/// </summary>
		// Token: 0x06002D6E RID: 11630 RVA: 0x00042B18 File Offset: 0x00040D18
		public virtual void SetImageSampleDistance(float _arg)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_SetImageSampleDistance_89(base.GetCppThis(), _arg);
		}

		// Token: 0x06002D6F RID: 11631
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUVolumeRayCastMapper_SetInputConnection_90(HandleRef pThis, int port, HandleRef input);

		/// <summary>
		/// Add/Remove input connections. Active and removed ports are cached in
		/// Ports and RemovedPorts respectively.
		/// </summary>
		// Token: 0x06002D70 RID: 11632 RVA: 0x00042B28 File Offset: 0x00040D28
		public override void SetInputConnection(int port, vtkAlgorithmOutput input)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_SetInputConnection_90(base.GetCppThis(), port, (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x06002D71 RID: 11633
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUVolumeRayCastMapper_SetInputConnection_91(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Add/Remove input connections. Active and removed ports are cached in
		/// Ports and RemovedPorts respectively.
		/// </summary>
		// Token: 0x06002D72 RID: 11634 RVA: 0x00042B58 File Offset: 0x00040D58
		public override void SetInputConnection(vtkAlgorithmOutput input)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_SetInputConnection_91(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x06002D73 RID: 11635
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUVolumeRayCastMapper_SetLockSampleDistanceToInputSpacing_92(HandleRef pThis, int _arg);

		/// <summary>
		/// Compute the sample distance from the data spacing.  When the number of
		/// voxels is 8, the sample distance will be roughly 1/200 the average voxel
		/// size. The distance will grow proportionally to numVoxels^(1/3). Off by default.
		/// </summary>
		// Token: 0x06002D74 RID: 11636 RVA: 0x00042B87 File Offset: 0x00040D87
		public virtual void SetLockSampleDistanceToInputSpacing(int _arg)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_SetLockSampleDistanceToInputSpacing_92(base.GetCppThis(), _arg);
		}

		// Token: 0x06002D75 RID: 11637
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUVolumeRayCastMapper_SetMaskBlendFactor_93(HandleRef pThis, float _arg);

		/// <summary>
		/// Tells how much mask color transfer function is used compared to the
		/// standard color transfer function when the mask is true. This is relevant
		/// only for the label map mask.
		/// 0.0 means only standard color transfer function.
		/// 1.0 means only mask color transfer function.
		/// The default value is 1.0.
		/// </summary>
		// Token: 0x06002D76 RID: 11638 RVA: 0x00042B97 File Offset: 0x00040D97
		public virtual void SetMaskBlendFactor(float _arg)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_SetMaskBlendFactor_93(base.GetCppThis(), _arg);
		}

		// Token: 0x06002D77 RID: 11639
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUVolumeRayCastMapper_SetMaskInput_94(HandleRef pThis, HandleRef mask);

		/// <summary>
		/// Optionally, set a mask input. This mask may be a binary mask or a label
		/// map. This must be specified via SetMaskType.
		///
		/// If the mask is a binary mask, the volume rendering is confined to regions
		/// within the binary mask. The binary mask is assumed to have a datatype of
		/// UCHAR and values of 255 (inside) and 0 (outside).
		///
		/// The mask may also be a label map. The label map must have a datatype of
		/// UCHAR i.e. it can have upto 256 labels. The label 0 is reserved as a
		/// special label. In voxels with label value of 0, the default transfer
		/// functions supplied by vtkVolumeProperty are used.
		///
		/// For voxels with a label values greater than 0, the color transfer functions
		/// supplied using vtkVolumeProperty's label API are used.
		///
		/// For voxels with a label value greater than 0, the color transfer function
		/// is blended with the default color transfer function, with the blending
		/// weight determined by MaskBlendFactor.
		/// </summary>
		// Token: 0x06002D78 RID: 11640 RVA: 0x00042BA8 File Offset: 0x00040DA8
		public void SetMaskInput(vtkImageData mask)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_SetMaskInput_94(base.GetCppThis(), (mask == null) ? default(HandleRef) : mask.GetCppThis());
		}

		// Token: 0x06002D79 RID: 11641
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUVolumeRayCastMapper_SetMaskType_95(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the mask type, if mask is to be used. See documentation for
		/// SetMaskInput(). The default is a LabelMapMaskType.
		/// </summary>
		// Token: 0x06002D7A RID: 11642 RVA: 0x00042BD7 File Offset: 0x00040DD7
		public virtual void SetMaskType(int _arg)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_SetMaskType_95(base.GetCppThis(), _arg);
		}

		// Token: 0x06002D7B RID: 11643
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUVolumeRayCastMapper_SetMaskTypeToBinary_96(HandleRef pThis);

		/// <summary>
		/// Set the mask type, if mask is to be used. See documentation for
		/// SetMaskInput(). The default is a LabelMapMaskType.
		/// </summary>
		// Token: 0x06002D7C RID: 11644 RVA: 0x00042BE7 File Offset: 0x00040DE7
		public void SetMaskTypeToBinary()
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_SetMaskTypeToBinary_96(base.GetCppThis());
		}

		// Token: 0x06002D7D RID: 11645
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUVolumeRayCastMapper_SetMaskTypeToLabelMap_97(HandleRef pThis);

		/// <summary>
		/// Set the mask type, if mask is to be used. See documentation for
		/// SetMaskInput(). The default is a LabelMapMaskType.
		/// </summary>
		// Token: 0x06002D7E RID: 11646 RVA: 0x00042BF6 File Offset: 0x00040DF6
		public void SetMaskTypeToLabelMap()
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_SetMaskTypeToLabelMap_97(base.GetCppThis());
		}

		// Token: 0x06002D7F RID: 11647
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUVolumeRayCastMapper_SetMaxMemoryFraction_98(HandleRef pThis, float _arg);

		/// <summary>
		/// Maximum fraction of the MaxMemoryInBytes that should
		/// be used to hold the texture. Valid values are 0.1 to
		/// 1.0.
		/// </summary>
		// Token: 0x06002D80 RID: 11648 RVA: 0x00042C05 File Offset: 0x00040E05
		public virtual void SetMaxMemoryFraction(float _arg)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_SetMaxMemoryFraction_98(base.GetCppThis(), _arg);
		}

		// Token: 0x06002D81 RID: 11649
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUVolumeRayCastMapper_SetMaxMemoryInBytes_99(HandleRef pThis, long _arg);

		/// <summary>
		/// Maximum size of the 3D texture in GPU memory.
		/// Will default to the size computed from the graphics
		/// card. Can be adjusted by the user.
		/// </summary>
		// Token: 0x06002D82 RID: 11650 RVA: 0x00042C15 File Offset: 0x00040E15
		public virtual void SetMaxMemoryInBytes(long _arg)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_SetMaxMemoryInBytes_99(base.GetCppThis(), _arg);
		}

		// Token: 0x06002D83 RID: 11651
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUVolumeRayCastMapper_SetMaximumImageSampleDistance_100(HandleRef pThis, float _arg);

		/// <summary>
		/// This is the maximum image sample distance allow when the image
		/// sample distance is being automatically adjusted.
		/// </summary>
		// Token: 0x06002D84 RID: 11652 RVA: 0x00042C25 File Offset: 0x00040E25
		public virtual void SetMaximumImageSampleDistance(float _arg)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_SetMaximumImageSampleDistance_100(base.GetCppThis(), _arg);
		}

		// Token: 0x06002D85 RID: 11653
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUVolumeRayCastMapper_SetMinimumImageSampleDistance_101(HandleRef pThis, float _arg);

		/// <summary>
		/// This is the minimum image sample distance allow when the image
		/// sample distance is being automatically adjusted.
		/// </summary>
		// Token: 0x06002D86 RID: 11654 RVA: 0x00042C35 File Offset: 0x00040E35
		public virtual void SetMinimumImageSampleDistance(float _arg)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_SetMinimumImageSampleDistance_101(base.GetCppThis(), _arg);
		}

		// Token: 0x06002D87 RID: 11655
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUVolumeRayCastMapper_SetRenderToImage_102(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable or disable setting output of volume rendering to be
		/// color and depth textures. By default this is set to 0 (off).
		/// It should be noted that it is possible that underlying API specific
		/// mapper may not supoport RenderToImage mode.
		/// \warning
		/// \li This method ignores any other volumes / props in the scene.
		/// \li This method does not respect the general attributes of the
		/// scene i.e. background color, etc. It always produces a color
		/// image that has a transparent white background outside the
		/// bounds of the volume.
		///
		/// \sa GetDepthImage(), GetColorImage()
		/// </summary>
		// Token: 0x06002D88 RID: 11656 RVA: 0x00042C45 File Offset: 0x00040E45
		public virtual void SetRenderToImage(int _arg)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_SetRenderToImage_102(base.GetCppThis(), _arg);
		}

		// Token: 0x06002D89 RID: 11657
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUVolumeRayCastMapper_SetReportProgress_103(HandleRef pThis, byte _arg);

		/// <summary>
		/// Tells if the mapper will report intermediate progress.
		/// Initial value is true. As the progress works with a GL blocking
		/// call (glFinish()), this can be useful for huge dataset but can
		/// slow down rendering of small dataset. It should be set to true
		/// for big dataset or complex shading and streaming but to false for
		/// small datasets.
		/// </summary>
		// Token: 0x06002D8A RID: 11658 RVA: 0x00042C55 File Offset: 0x00040E55
		public virtual void SetReportProgress(bool _arg)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_SetReportProgress_103(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06002D8B RID: 11659
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUVolumeRayCastMapper_SetSampleDistance_104(HandleRef pThis, float _arg);

		/// <summary>
		/// Set/Get the distance between samples used for rendering
		/// when AutoAdjustSampleDistances is off, or when this mapper
		/// has more than 1 second allocated to it for rendering.
		/// Initial value is 1.0.
		/// </summary>
		// Token: 0x06002D8C RID: 11660 RVA: 0x00042C6D File Offset: 0x00040E6D
		public virtual void SetSampleDistance(float _arg)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_SetSampleDistance_104(base.GetCppThis(), _arg);
		}

		// Token: 0x06002D8D RID: 11661
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUVolumeRayCastMapper_SetScalarOpacityRangeType_105(HandleRef pThis, int _arg);

		/// <summary>
		/// Set whether to use the scalar range or the native transfer function range
		/// when looking up transfer functions for color and opacity values. When the
		/// range is set to TransferFunctionRange::SCALAR, the function is distributed
		/// over the entire scalar range. If it is set to
		/// TransferFunctionRange::NATIVE, the scalar values outside the native
		/// transfer function range will be truncated to native range. By
		/// default, the volume scalar range is used.
		///
		/// \note The native range of the transfer function is the range returned by
		/// vtkColorTransferFunction::GetRange() or vtkPiecewiseFunction::GetRange().
		///
		/// \note There is no special API provided for 2D transfer functions
		/// considering that they are set as a pre-generated vtkImageData on this
		/// class i.e. the range is already encoded.
		/// </summary>
		// Token: 0x06002D8E RID: 11662 RVA: 0x00042C7D File Offset: 0x00040E7D
		public virtual void SetScalarOpacityRangeType(int _arg)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_SetScalarOpacityRangeType_105(base.GetCppThis(), _arg);
		}

		// Token: 0x06002D8F RID: 11663
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUVolumeRayCastMapper_SetTransfer2DYAxisArray_106(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the transfer 2D Y axis array
		/// </summary>
		// Token: 0x06002D90 RID: 11664 RVA: 0x00042C8D File Offset: 0x00040E8D
		public virtual void SetTransfer2DYAxisArray(string _arg)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_SetTransfer2DYAxisArray_106(base.GetCppThis(), _arg);
		}

		// Token: 0x06002D91 RID: 11665
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUVolumeRayCastMapper_SetUseDepthPass_107(HandleRef pThis, int _arg);

		/// <summary>
		/// If UseDepthPass is on, the mapper will use two passes. In the first
		/// pass, an isocontour depth buffer will be utilized as starting point
		/// for ray-casting hence eliminating traversal on voxels that are
		/// not going to participate in final rendering. UseDepthPass requires
		/// reasonable contour values to be set which can be set by calling
		/// GetDepthPassContourValues() method and using vtkControurValues API.
		/// </summary>
		// Token: 0x06002D92 RID: 11666 RVA: 0x00042C9D File Offset: 0x00040E9D
		public virtual void SetUseDepthPass(int _arg)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_SetUseDepthPass_107(base.GetCppThis(), _arg);
		}

		// Token: 0x06002D93 RID: 11667
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUVolumeRayCastMapper_SetUseJittering_108(HandleRef pThis, int _arg);

		/// <summary>
		/// If UseJittering is on, each ray traversal direction will be
		/// perturbed slightly using a noise-texture to get rid of wood-grain
		/// effect.
		/// </summary>
		// Token: 0x06002D94 RID: 11668 RVA: 0x00042CAD File Offset: 0x00040EAD
		public virtual void SetUseJittering(int _arg)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_SetUseJittering_108(base.GetCppThis(), _arg);
		}

		// Token: 0x06002D95 RID: 11669
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUVolumeRayCastMapper_SetVolumetricScatteringBlending_109(HandleRef pThis, float _arg);

		/// <summary>
		/// This parameter controls the blending between surfacic approximation
		/// and volumetric multi-scattering. It is only considered when
		/// Shade is enabled.
		/// A value of 0.0 means that no scattered rays will be cast, no volumetric shadows
		/// A value of 1.0 means that the shader will smartly blend between the two models
		/// A value of 2.0 means that the shader only uses the volumetric scattering model.
		/// The blending is not uniform, and is done in the following way:
		/// a value in [0, 1] biases the shader to choose between the two models, and a value
		/// in [1, 2] forces the shader to use more the volumetric model.
		/// </summary>
		// Token: 0x06002D96 RID: 11670 RVA: 0x00042CBD File Offset: 0x00040EBD
		public virtual void SetVolumetricScatteringBlending(float _arg)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_SetVolumetricScatteringBlending_109(base.GetCppThis(), _arg);
		}

		// Token: 0x06002D97 RID: 11671
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUVolumeRayCastMapper_UseDepthPassOff_110(HandleRef pThis);

		/// <summary>
		/// If UseDepthPass is on, the mapper will use two passes. In the first
		/// pass, an isocontour depth buffer will be utilized as starting point
		/// for ray-casting hence eliminating traversal on voxels that are
		/// not going to participate in final rendering. UseDepthPass requires
		/// reasonable contour values to be set which can be set by calling
		/// GetDepthPassContourValues() method and using vtkControurValues API.
		/// </summary>
		// Token: 0x06002D98 RID: 11672 RVA: 0x00042CCD File Offset: 0x00040ECD
		public virtual void UseDepthPassOff()
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_UseDepthPassOff_110(base.GetCppThis());
		}

		// Token: 0x06002D99 RID: 11673
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUVolumeRayCastMapper_UseDepthPassOn_111(HandleRef pThis);

		/// <summary>
		/// If UseDepthPass is on, the mapper will use two passes. In the first
		/// pass, an isocontour depth buffer will be utilized as starting point
		/// for ray-casting hence eliminating traversal on voxels that are
		/// not going to participate in final rendering. UseDepthPass requires
		/// reasonable contour values to be set which can be set by calling
		/// GetDepthPassContourValues() method and using vtkControurValues API.
		/// </summary>
		// Token: 0x06002D9A RID: 11674 RVA: 0x00042CDC File Offset: 0x00040EDC
		public virtual void UseDepthPassOn()
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_UseDepthPassOn_111(base.GetCppThis());
		}

		// Token: 0x06002D9B RID: 11675
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUVolumeRayCastMapper_UseJitteringOff_112(HandleRef pThis);

		/// <summary>
		/// If UseJittering is on, each ray traversal direction will be
		/// perturbed slightly using a noise-texture to get rid of wood-grain
		/// effect.
		/// </summary>
		// Token: 0x06002D9C RID: 11676 RVA: 0x00042CEB File Offset: 0x00040EEB
		public virtual void UseJitteringOff()
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_UseJitteringOff_112(base.GetCppThis());
		}

		// Token: 0x06002D9D RID: 11677
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGPUVolumeRayCastMapper_UseJitteringOn_113(HandleRef pThis);

		/// <summary>
		/// If UseJittering is on, each ray traversal direction will be
		/// perturbed slightly using a noise-texture to get rid of wood-grain
		/// effect.
		/// </summary>
		// Token: 0x06002D9E RID: 11678 RVA: 0x00042CFA File Offset: 0x00040EFA
		public virtual void UseJitteringOn()
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_UseJitteringOn_113(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400059F RID: 1439
		public new const string MRFullTypeName = "Kitware.VTK.vtkGPUVolumeRayCastMapper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040005A0 RID: 1440
		public new static readonly string MRClassNameKey = "class vtkGPUVolumeRayCastMapper";

		/// <summary>
		/// Optionally, set a mask input. This mask may be a binary mask or a label
		/// map. This must be specified via SetMaskType.
		///
		/// If the mask is a binary mask, the volume rendering is confined to regions
		/// within the binary mask. The binary mask is assumed to have a datatype of
		/// UCHAR and values of 255 (inside) and 0 (outside).
		///
		/// The mask may also be a label map. The label map must have a datatype of
		/// UCHAR i.e. it can have upto 256 labels. The label 0 is reserved as a
		/// special label. In voxels with label value of 0, the default transfer
		/// functions supplied by vtkVolumeProperty are used.
		///
		/// For voxels with a label values greater than 0, the color transfer functions
		/// supplied using vtkVolumeProperty's label API are used.
		///
		/// For voxels with a label value greater than 0, the color transfer function
		/// is blended with the default color transfer function, with the blending
		/// weight determined by MaskBlendFactor.
		/// </summary>
		// Token: 0x020000D4 RID: 212
		public enum BinaryMaskType_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x040005A2 RID: 1442
			BinaryMaskType,
			/// <summary>enum member</summary>
			// Token: 0x040005A3 RID: 1443
			LabelMapMaskType
		}

		/// <summary>
		/// Return how much the dataset has to be reduced in each dimension to
		/// fit on the GPU. If the value is 1.0, there is no need to reduce the
		/// dataset.
		/// \pre the calling thread has a current OpenGL context.
		/// \pre mapper_supported: IsRenderSupported(renderer-&gt;GetRenderWindow(),0)
		/// The computation is based on hardware limits (3D texture indexable size)
		/// and MaxMemoryInBytes.
		/// \post valid_i_ratio: ratio[0]&gt;0 &amp;&amp; ratio[0]&lt;=1.0
		/// \post valid_j_ratio: ratio[1]&gt;0 &amp;&amp; ratio[1]&lt;=1.0
		/// \post valid_k_ratio: ratio[2]&gt;0 &amp;&amp; ratio[2]&lt;=1.0
		/// </summary>
		// Token: 0x020000D5 RID: 213
		public enum TFRangeType
		{
			/// <summary>enum member</summary>
			// Token: 0x040005A5 RID: 1445
			NATIVE = 1,
			/// <summary>enum member</summary>
			// Token: 0x040005A6 RID: 1446
			SCALAR = 0
		}
	}
}
