using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVolumeMapper
	/// </summary>
	/// <remarks>
	///    Abstract class for a volume mapper
	///
	///
	/// vtkVolumeMapper is the abstract definition of a volume mapper for regular
	/// rectilinear data (vtkImageData). Several basic types of volume mappers
	/// are supported.
	/// </remarks>
	// Token: 0x020000D0 RID: 208
	public abstract class vtkVolumeMapper : vtkAbstractVolumeMapper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06002C10 RID: 11280 RVA: 0x00041243 File Offset: 0x0003F443
		static vtkVolumeMapper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVolumeMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVolumeMapper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06002C11 RID: 11281 RVA: 0x0004126B File Offset: 0x0003F46B
		public vtkVolumeMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06002C12 RID: 11282 RVA: 0x00041279 File Offset: 0x0003F479
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06002C13 RID: 11283
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeMapper_ComputeNormalFromOpacityOff_01(HandleRef pThis);

		/// <summary>
		/// If enabled, the volume(s) whose shading is enabled will use the gradient
		/// of opacity instead of the scalar gradient to estimate the surface's normal
		/// when applying the shading model. The opacity considered for the gradient
		/// is then the scalars converted to opacity by the transfer function(s).
		/// For now it is only supported in vtkGPUVolumeRayCastMapper.
		/// In vtkSmartVolumeMapper and in vtkMultiBlockVolumeMapper, this parameter
		/// is used when the GPU mapper is effectively used.
		/// Note that enabling it might affect performances, especially when
		/// using a 2D TF or a gradient opacity. It is disabled by default.
		/// </summary>
		// Token: 0x06002C14 RID: 11284 RVA: 0x00041284 File Offset: 0x0003F484
		public virtual void ComputeNormalFromOpacityOff()
		{
			vtkVolumeMapper.vtkVolumeMapper_ComputeNormalFromOpacityOff_01(base.GetCppThis());
		}

		// Token: 0x06002C15 RID: 11285
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeMapper_ComputeNormalFromOpacityOn_02(HandleRef pThis);

		/// <summary>
		/// If enabled, the volume(s) whose shading is enabled will use the gradient
		/// of opacity instead of the scalar gradient to estimate the surface's normal
		/// when applying the shading model. The opacity considered for the gradient
		/// is then the scalars converted to opacity by the transfer function(s).
		/// For now it is only supported in vtkGPUVolumeRayCastMapper.
		/// In vtkSmartVolumeMapper and in vtkMultiBlockVolumeMapper, this parameter
		/// is used when the GPU mapper is effectively used.
		/// Note that enabling it might affect performances, especially when
		/// using a 2D TF or a gradient opacity. It is disabled by default.
		/// </summary>
		// Token: 0x06002C16 RID: 11286 RVA: 0x00041293 File Offset: 0x0003F493
		public virtual void ComputeNormalFromOpacityOn()
		{
			vtkVolumeMapper.vtkVolumeMapper_ComputeNormalFromOpacityOn_02(base.GetCppThis());
		}

		// Token: 0x06002C17 RID: 11287
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeMapper_CroppingOff_03(HandleRef pThis);

		/// <summary>
		/// Turn On/Off orthogonal cropping. (Clipping planes are
		/// perpendicular to the coordinate axes.)
		/// </summary>
		// Token: 0x06002C18 RID: 11288 RVA: 0x000412A2 File Offset: 0x0003F4A2
		public virtual void CroppingOff()
		{
			vtkVolumeMapper.vtkVolumeMapper_CroppingOff_03(base.GetCppThis());
		}

		// Token: 0x06002C19 RID: 11289
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeMapper_CroppingOn_04(HandleRef pThis);

		/// <summary>
		/// Turn On/Off orthogonal cropping. (Clipping planes are
		/// perpendicular to the coordinate axes.)
		/// </summary>
		// Token: 0x06002C1A RID: 11290 RVA: 0x000412B1 File Offset: 0x0003F4B1
		public virtual void CroppingOn()
		{
			vtkVolumeMapper.vtkVolumeMapper_CroppingOn_04(base.GetCppThis());
		}

		// Token: 0x06002C1B RID: 11291
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeMapper_GetAverageIPScalarRange_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the scalar range to be considered for average intensity projection
		/// blend mode. Only scalar values between this range will be averaged during
		/// ray casting. This can be useful when volume rendering CT datasets where the
		/// areas occupied by air would deviate the final rendering. By default, the
		/// range is set to (VTK_FLOAT_MIN, VTK_FLOAT_MAX).
		/// \sa SetBlendModeToAverageIntensity()
		/// </summary>
		// Token: 0x06002C1C RID: 11292 RVA: 0x000412C0 File Offset: 0x0003F4C0
		public virtual double[] GetAverageIPScalarRange()
		{
			IntPtr intPtr = vtkVolumeMapper.vtkVolumeMapper_GetAverageIPScalarRange_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06002C1D RID: 11293
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeMapper_GetAverageIPScalarRange_06(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get the scalar range to be considered for average intensity projection
		/// blend mode. Only scalar values between this range will be averaged during
		/// ray casting. This can be useful when volume rendering CT datasets where the
		/// areas occupied by air would deviate the final rendering. By default, the
		/// range is set to (VTK_FLOAT_MIN, VTK_FLOAT_MAX).
		/// \sa SetBlendModeToAverageIntensity()
		/// </summary>
		// Token: 0x06002C1E RID: 11294 RVA: 0x00041308 File Offset: 0x0003F508
		public virtual void GetAverageIPScalarRange(IntPtr data)
		{
			vtkVolumeMapper.vtkVolumeMapper_GetAverageIPScalarRange_06(base.GetCppThis(), data);
		}

		// Token: 0x06002C1F RID: 11295
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeMapper_GetBlendMode_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the blend mode.
		/// The default mode is Composite where the scalar values are sampled through
		/// the volume and composited in a front-to-back scheme through alpha blending.
		/// The final color and opacity is determined using the color and opacity
		/// transfer functions.
		///
		/// Maximum and minimum intensity blend modes use the maximum and minimum
		/// scalar values, respectively, along the sampling ray. The final color and
		/// opacity is determined by passing the resultant value through the color and
		/// opacity transfer functions.
		///
		/// Additive blend mode accumulates scalar values by passing each value through
		/// the opacity transfer function and then adding up the product of the value
		/// and its opacity. In other words, the scalar values are scaled using the
		/// opacity transfer function and summed to derive the final color. Note that
		/// the resulting image is always grayscale i.e. aggregated values are not
		/// passed through the color transfer function. This is because the final
		/// value is a derived value and not a real data value along the sampling ray.
		///
		/// Average intensity blend mode works similar to the additive blend mode where
		/// the scalar values are multiplied by opacity calculated from the opacity
		/// transfer function and then added. The additional step here is to
		/// divide the sum by the number of samples taken through the volume.
		/// One can control the scalar range by setting the AverageIPScalarRange ivar
		/// to disregard scalar values, not in the range of interest, from the average
		/// computation.
		/// As is the case with the additive intensity projection, the final
		/// image will always be grayscale i.e. the aggregated values are not
		/// passed through the color transfer function. This is because the
		/// resultant value is a derived value and not a real data value along
		/// the sampling ray.
		///
		/// IsoSurface blend mode uses contour values defined by the user in order
		/// to display scalar values only when the ray crosses the contour. It supports
		/// opacity the same way composite blend mode does.
		///
		/// \note vtkVolumeMapper::AVERAGE_INTENSITY_BLEND and ISOSURFACE_BLEND are
		/// only supported by the vtkGPUVolumeRayCastMapper with the OpenGL2 backend.
		/// \sa SetAverageIPScalarRange()
		/// \sa GetIsosurfaceValues()
		/// </summary>
		// Token: 0x06002C20 RID: 11296 RVA: 0x00041318 File Offset: 0x0003F518
		public virtual int GetBlendMode()
		{
			return vtkVolumeMapper.vtkVolumeMapper_GetBlendMode_07(base.GetCppThis());
		}

		// Token: 0x06002C21 RID: 11297
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkVolumeMapper_GetComputeNormalFromOpacity_08(HandleRef pThis);

		/// <summary>
		/// If enabled, the volume(s) whose shading is enabled will use the gradient
		/// of opacity instead of the scalar gradient to estimate the surface's normal
		/// when applying the shading model. The opacity considered for the gradient
		/// is then the scalars converted to opacity by the transfer function(s).
		/// For now it is only supported in vtkGPUVolumeRayCastMapper.
		/// In vtkSmartVolumeMapper and in vtkMultiBlockVolumeMapper, this parameter
		/// is used when the GPU mapper is effectively used.
		/// Note that enabling it might affect performances, especially when
		/// using a 2D TF or a gradient opacity. It is disabled by default.
		/// </summary>
		// Token: 0x06002C22 RID: 11298 RVA: 0x00041338 File Offset: 0x0003F538
		public virtual bool GetComputeNormalFromOpacity()
		{
			return vtkVolumeMapper.vtkVolumeMapper_GetComputeNormalFromOpacity_08(base.GetCppThis()) != 0;
		}

		// Token: 0x06002C23 RID: 11299
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeMapper_GetCropping_09(HandleRef pThis);

		/// <summary>
		/// Turn On/Off orthogonal cropping. (Clipping planes are
		/// perpendicular to the coordinate axes.)
		/// </summary>
		// Token: 0x06002C24 RID: 11300 RVA: 0x00041360 File Offset: 0x0003F560
		public virtual int GetCropping()
		{
			return vtkVolumeMapper.vtkVolumeMapper_GetCropping_09(base.GetCppThis());
		}

		// Token: 0x06002C25 RID: 11301
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeMapper_GetCroppingMaxValue_10(HandleRef pThis);

		/// <summary>
		/// Turn On/Off orthogonal cropping. (Clipping planes are
		/// perpendicular to the coordinate axes.)
		/// </summary>
		// Token: 0x06002C26 RID: 11302 RVA: 0x00041380 File Offset: 0x0003F580
		public virtual int GetCroppingMaxValue()
		{
			return vtkVolumeMapper.vtkVolumeMapper_GetCroppingMaxValue_10(base.GetCppThis());
		}

		// Token: 0x06002C27 RID: 11303
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeMapper_GetCroppingMinValue_11(HandleRef pThis);

		/// <summary>
		/// Turn On/Off orthogonal cropping. (Clipping planes are
		/// perpendicular to the coordinate axes.)
		/// </summary>
		// Token: 0x06002C28 RID: 11304 RVA: 0x000413A0 File Offset: 0x0003F5A0
		public virtual int GetCroppingMinValue()
		{
			return vtkVolumeMapper.vtkVolumeMapper_GetCroppingMinValue_11(base.GetCppThis());
		}

		// Token: 0x06002C29 RID: 11305
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeMapper_GetCroppingRegionFlags_12(HandleRef pThis);

		/// <summary>
		/// Set the flags for the cropping regions. The clipping planes divide the
		/// volume into 27 regions - there is one bit for each region. The regions
		/// start from the one containing voxel (0,0,0), moving along the x axis
		/// fastest, the y axis next, and the z axis slowest. These are represented
		/// from the lowest bit to bit number 27 in the integer containing the
		/// flags. There are several convenience functions to set some common
		/// configurations - subvolume (the default), fence (between any of the
		/// clip plane pairs), inverted fence, cross (between any two of the
		/// clip plane pairs) and inverted cross.
		/// </summary>
		// Token: 0x06002C2A RID: 11306 RVA: 0x000413C0 File Offset: 0x0003F5C0
		public virtual int GetCroppingRegionFlags()
		{
			return vtkVolumeMapper.vtkVolumeMapper_GetCroppingRegionFlags_12(base.GetCppThis());
		}

		// Token: 0x06002C2B RID: 11307
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeMapper_GetCroppingRegionFlagsMaxValue_13(HandleRef pThis);

		/// <summary>
		/// Set the flags for the cropping regions. The clipping planes divide the
		/// volume into 27 regions - there is one bit for each region. The regions
		/// start from the one containing voxel (0,0,0), moving along the x axis
		/// fastest, the y axis next, and the z axis slowest. These are represented
		/// from the lowest bit to bit number 27 in the integer containing the
		/// flags. There are several convenience functions to set some common
		/// configurations - subvolume (the default), fence (between any of the
		/// clip plane pairs), inverted fence, cross (between any two of the
		/// clip plane pairs) and inverted cross.
		/// </summary>
		// Token: 0x06002C2C RID: 11308 RVA: 0x000413E0 File Offset: 0x0003F5E0
		public virtual int GetCroppingRegionFlagsMaxValue()
		{
			return vtkVolumeMapper.vtkVolumeMapper_GetCroppingRegionFlagsMaxValue_13(base.GetCppThis());
		}

		// Token: 0x06002C2D RID: 11309
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeMapper_GetCroppingRegionFlagsMinValue_14(HandleRef pThis);

		/// <summary>
		/// Set the flags for the cropping regions. The clipping planes divide the
		/// volume into 27 regions - there is one bit for each region. The regions
		/// start from the one containing voxel (0,0,0), moving along the x axis
		/// fastest, the y axis next, and the z axis slowest. These are represented
		/// from the lowest bit to bit number 27 in the integer containing the
		/// flags. There are several convenience functions to set some common
		/// configurations - subvolume (the default), fence (between any of the
		/// clip plane pairs), inverted fence, cross (between any two of the
		/// clip plane pairs) and inverted cross.
		/// </summary>
		// Token: 0x06002C2E RID: 11310 RVA: 0x00041400 File Offset: 0x0003F600
		public virtual int GetCroppingRegionFlagsMinValue()
		{
			return vtkVolumeMapper.vtkVolumeMapper_GetCroppingRegionFlagsMinValue_14(base.GetCppThis());
		}

		// Token: 0x06002C2F RID: 11311
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeMapper_GetCroppingRegionPlanes_15(HandleRef pThis);

		/// <summary>
		/// Set/Get the Cropping Region Planes ( xmin, xmax, ymin, ymax, zmin, zmax )
		/// These planes are defined in volume coordinates - spacing and origin are
		/// considered.
		/// </summary>
		// Token: 0x06002C30 RID: 11312 RVA: 0x00041420 File Offset: 0x0003F620
		public virtual double[] GetCroppingRegionPlanes()
		{
			IntPtr intPtr = vtkVolumeMapper.vtkVolumeMapper_GetCroppingRegionPlanes_15(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06002C31 RID: 11313
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeMapper_GetCroppingRegionPlanes_16(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get the Cropping Region Planes ( xmin, xmax, ymin, ymax, zmin, zmax )
		/// These planes are defined in volume coordinates - spacing and origin are
		/// considered.
		/// </summary>
		// Token: 0x06002C32 RID: 11314 RVA: 0x00041468 File Offset: 0x0003F668
		public virtual void GetCroppingRegionPlanes(IntPtr data)
		{
			vtkVolumeMapper.vtkVolumeMapper_GetCroppingRegionPlanes_16(base.GetCppThis(), data);
		}

		// Token: 0x06002C33 RID: 11315
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeMapper_GetInput_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the input data
		/// </summary>
		// Token: 0x06002C34 RID: 11316 RVA: 0x00041478 File Offset: 0x0003F678
		public virtual vtkDataSet GetInput()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeMapper.vtkVolumeMapper_GetInput_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06002C35 RID: 11317
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeMapper_GetInput_18(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the input data
		/// </summary>
		// Token: 0x06002C36 RID: 11318 RVA: 0x000414E8 File Offset: 0x0003F6E8
		public virtual vtkDataSet GetInput(int port)
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeMapper.vtkVolumeMapper_GetInput_18(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06002C37 RID: 11319
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVolumeMapper_GetNumberOfGenerationsFromBase_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002C38 RID: 11320 RVA: 0x00041558 File Offset: 0x0003F758
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVolumeMapper.vtkVolumeMapper_GetNumberOfGenerationsFromBase_19(base.GetCppThis(), type);
		}

		// Token: 0x06002C39 RID: 11321
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVolumeMapper_GetNumberOfGenerationsFromBaseType_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002C3A RID: 11322 RVA: 0x00041578 File Offset: 0x0003F778
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVolumeMapper.vtkVolumeMapper_GetNumberOfGenerationsFromBaseType_20(type);
		}

		// Token: 0x06002C3B RID: 11323
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeMapper_GetVoxelCroppingRegionPlanes_21(HandleRef pThis);

		/// <summary>
		/// Get the cropping region planes in voxels. Only valid during the
		/// rendering process
		/// </summary>
		// Token: 0x06002C3C RID: 11324 RVA: 0x00041594 File Offset: 0x0003F794
		public virtual double[] GetVoxelCroppingRegionPlanes()
		{
			IntPtr intPtr = vtkVolumeMapper.vtkVolumeMapper_GetVoxelCroppingRegionPlanes_21(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06002C3D RID: 11325
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeMapper_GetVoxelCroppingRegionPlanes_22(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Get the cropping region planes in voxels. Only valid during the
		/// rendering process
		/// </summary>
		// Token: 0x06002C3E RID: 11326 RVA: 0x000415DC File Offset: 0x0003F7DC
		public virtual void GetVoxelCroppingRegionPlanes(IntPtr data)
		{
			vtkVolumeMapper.vtkVolumeMapper_GetVoxelCroppingRegionPlanes_22(base.GetCppThis(), data);
		}

		// Token: 0x06002C3F RID: 11327
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeMapper_IsA_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002C40 RID: 11328 RVA: 0x000415EC File Offset: 0x0003F7EC
		public override int IsA(string type)
		{
			return vtkVolumeMapper.vtkVolumeMapper_IsA_23(base.GetCppThis(), type);
		}

		// Token: 0x06002C41 RID: 11329
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeMapper_IsTypeOf_24([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002C42 RID: 11330 RVA: 0x0004160C File Offset: 0x0003F80C
		public new static int IsTypeOf(string type)
		{
			return vtkVolumeMapper.vtkVolumeMapper_IsTypeOf_24(type);
		}

		// Token: 0x06002C43 RID: 11331
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeMapper_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002C44 RID: 11332 RVA: 0x00041628 File Offset: 0x0003F828
		public new vtkVolumeMapper NewInstance()
		{
			vtkVolumeMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeMapper.vtkVolumeMapper_NewInstance_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumeMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06002C45 RID: 11333
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeMapper_ReleaseGraphicsResources_26(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Release any graphics resources that are being consumed by this mapper.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x06002C46 RID: 11334 RVA: 0x00041684 File Offset: 0x0003F884
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkVolumeMapper.vtkVolumeMapper_ReleaseGraphicsResources_26(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002C47 RID: 11335
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeMapper_Render_27(HandleRef pThis, HandleRef ren, HandleRef vol);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
		/// Render the volume
		/// </summary>
		// Token: 0x06002C48 RID: 11336 RVA: 0x000416B4 File Offset: 0x0003F8B4
		public override void Render(vtkRenderer ren, vtkVolume vol)
		{
			vtkVolumeMapper.vtkVolumeMapper_Render_27(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis());
		}

		// Token: 0x06002C49 RID: 11337
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeMapper_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002C4A RID: 11338 RVA: 0x000416F8 File Offset: 0x0003F8F8
		public new static vtkVolumeMapper SafeDownCast(vtkObjectBase o)
		{
			vtkVolumeMapper vtkVolumeMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeMapper.vtkVolumeMapper_SafeDownCast_28((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVolumeMapper = (vtkVolumeMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVolumeMapper.Register(null);
				}
			}
			return vtkVolumeMapper;
		}

		// Token: 0x06002C4B RID: 11339
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeMapper_SetAverageIPScalarRange_29(HandleRef pThis, double _arg1, double _arg2);

		/// <summary>
		/// Set/Get the scalar range to be considered for average intensity projection
		/// blend mode. Only scalar values between this range will be averaged during
		/// ray casting. This can be useful when volume rendering CT datasets where the
		/// areas occupied by air would deviate the final rendering. By default, the
		/// range is set to (VTK_FLOAT_MIN, VTK_FLOAT_MAX).
		/// \sa SetBlendModeToAverageIntensity()
		/// </summary>
		// Token: 0x06002C4C RID: 11340 RVA: 0x00041777 File Offset: 0x0003F977
		public virtual void SetAverageIPScalarRange(double _arg1, double _arg2)
		{
			vtkVolumeMapper.vtkVolumeMapper_SetAverageIPScalarRange_29(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x06002C4D RID: 11341
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeMapper_SetAverageIPScalarRange_30(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the scalar range to be considered for average intensity projection
		/// blend mode. Only scalar values between this range will be averaged during
		/// ray casting. This can be useful when volume rendering CT datasets where the
		/// areas occupied by air would deviate the final rendering. By default, the
		/// range is set to (VTK_FLOAT_MIN, VTK_FLOAT_MAX).
		/// \sa SetBlendModeToAverageIntensity()
		/// </summary>
		// Token: 0x06002C4E RID: 11342 RVA: 0x00041788 File Offset: 0x0003F988
		public void SetAverageIPScalarRange(IntPtr _arg)
		{
			vtkVolumeMapper.vtkVolumeMapper_SetAverageIPScalarRange_30(base.GetCppThis(), _arg);
		}

		// Token: 0x06002C4F RID: 11343
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeMapper_SetBlendMode_31(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the blend mode.
		/// The default mode is Composite where the scalar values are sampled through
		/// the volume and composited in a front-to-back scheme through alpha blending.
		/// The final color and opacity is determined using the color and opacity
		/// transfer functions.
		///
		/// Maximum and minimum intensity blend modes use the maximum and minimum
		/// scalar values, respectively, along the sampling ray. The final color and
		/// opacity is determined by passing the resultant value through the color and
		/// opacity transfer functions.
		///
		/// Additive blend mode accumulates scalar values by passing each value through
		/// the opacity transfer function and then adding up the product of the value
		/// and its opacity. In other words, the scalar values are scaled using the
		/// opacity transfer function and summed to derive the final color. Note that
		/// the resulting image is always grayscale i.e. aggregated values are not
		/// passed through the color transfer function. This is because the final
		/// value is a derived value and not a real data value along the sampling ray.
		///
		/// Average intensity blend mode works similar to the additive blend mode where
		/// the scalar values are multiplied by opacity calculated from the opacity
		/// transfer function and then added. The additional step here is to
		/// divide the sum by the number of samples taken through the volume.
		/// One can control the scalar range by setting the AverageIPScalarRange ivar
		/// to disregard scalar values, not in the range of interest, from the average
		/// computation.
		/// As is the case with the additive intensity projection, the final
		/// image will always be grayscale i.e. the aggregated values are not
		/// passed through the color transfer function. This is because the
		/// resultant value is a derived value and not a real data value along
		/// the sampling ray.
		///
		/// IsoSurface blend mode uses contour values defined by the user in order
		/// to display scalar values only when the ray crosses the contour. It supports
		/// opacity the same way composite blend mode does.
		///
		/// \note vtkVolumeMapper::AVERAGE_INTENSITY_BLEND and ISOSURFACE_BLEND are
		/// only supported by the vtkGPUVolumeRayCastMapper with the OpenGL2 backend.
		/// \sa SetAverageIPScalarRange()
		/// \sa GetIsosurfaceValues()
		/// </summary>
		// Token: 0x06002C50 RID: 11344 RVA: 0x00041798 File Offset: 0x0003F998
		public virtual void SetBlendMode(int _arg)
		{
			vtkVolumeMapper.vtkVolumeMapper_SetBlendMode_31(base.GetCppThis(), _arg);
		}

		// Token: 0x06002C51 RID: 11345
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeMapper_SetBlendModeToAdditive_32(HandleRef pThis);

		/// <summary>
		/// Set/Get the blend mode.
		/// The default mode is Composite where the scalar values are sampled through
		/// the volume and composited in a front-to-back scheme through alpha blending.
		/// The final color and opacity is determined using the color and opacity
		/// transfer functions.
		///
		/// Maximum and minimum intensity blend modes use the maximum and minimum
		/// scalar values, respectively, along the sampling ray. The final color and
		/// opacity is determined by passing the resultant value through the color and
		/// opacity transfer functions.
		///
		/// Additive blend mode accumulates scalar values by passing each value through
		/// the opacity transfer function and then adding up the product of the value
		/// and its opacity. In other words, the scalar values are scaled using the
		/// opacity transfer function and summed to derive the final color. Note that
		/// the resulting image is always grayscale i.e. aggregated values are not
		/// passed through the color transfer function. This is because the final
		/// value is a derived value and not a real data value along the sampling ray.
		///
		/// Average intensity blend mode works similar to the additive blend mode where
		/// the scalar values are multiplied by opacity calculated from the opacity
		/// transfer function and then added. The additional step here is to
		/// divide the sum by the number of samples taken through the volume.
		/// One can control the scalar range by setting the AverageIPScalarRange ivar
		/// to disregard scalar values, not in the range of interest, from the average
		/// computation.
		/// As is the case with the additive intensity projection, the final
		/// image will always be grayscale i.e. the aggregated values are not
		/// passed through the color transfer function. This is because the
		/// resultant value is a derived value and not a real data value along
		/// the sampling ray.
		///
		/// IsoSurface blend mode uses contour values defined by the user in order
		/// to display scalar values only when the ray crosses the contour. It supports
		/// opacity the same way composite blend mode does.
		///
		/// \note vtkVolumeMapper::AVERAGE_INTENSITY_BLEND and ISOSURFACE_BLEND are
		/// only supported by the vtkGPUVolumeRayCastMapper with the OpenGL2 backend.
		/// \sa SetAverageIPScalarRange()
		/// \sa GetIsosurfaceValues()
		/// </summary>
		// Token: 0x06002C52 RID: 11346 RVA: 0x000417A8 File Offset: 0x0003F9A8
		public void SetBlendModeToAdditive()
		{
			vtkVolumeMapper.vtkVolumeMapper_SetBlendModeToAdditive_32(base.GetCppThis());
		}

		// Token: 0x06002C53 RID: 11347
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeMapper_SetBlendModeToAverageIntensity_33(HandleRef pThis);

		/// <summary>
		/// Set/Get the blend mode.
		/// The default mode is Composite where the scalar values are sampled through
		/// the volume and composited in a front-to-back scheme through alpha blending.
		/// The final color and opacity is determined using the color and opacity
		/// transfer functions.
		///
		/// Maximum and minimum intensity blend modes use the maximum and minimum
		/// scalar values, respectively, along the sampling ray. The final color and
		/// opacity is determined by passing the resultant value through the color and
		/// opacity transfer functions.
		///
		/// Additive blend mode accumulates scalar values by passing each value through
		/// the opacity transfer function and then adding up the product of the value
		/// and its opacity. In other words, the scalar values are scaled using the
		/// opacity transfer function and summed to derive the final color. Note that
		/// the resulting image is always grayscale i.e. aggregated values are not
		/// passed through the color transfer function. This is because the final
		/// value is a derived value and not a real data value along the sampling ray.
		///
		/// Average intensity blend mode works similar to the additive blend mode where
		/// the scalar values are multiplied by opacity calculated from the opacity
		/// transfer function and then added. The additional step here is to
		/// divide the sum by the number of samples taken through the volume.
		/// One can control the scalar range by setting the AverageIPScalarRange ivar
		/// to disregard scalar values, not in the range of interest, from the average
		/// computation.
		/// As is the case with the additive intensity projection, the final
		/// image will always be grayscale i.e. the aggregated values are not
		/// passed through the color transfer function. This is because the
		/// resultant value is a derived value and not a real data value along
		/// the sampling ray.
		///
		/// IsoSurface blend mode uses contour values defined by the user in order
		/// to display scalar values only when the ray crosses the contour. It supports
		/// opacity the same way composite blend mode does.
		///
		/// \note vtkVolumeMapper::AVERAGE_INTENSITY_BLEND and ISOSURFACE_BLEND are
		/// only supported by the vtkGPUVolumeRayCastMapper with the OpenGL2 backend.
		/// \sa SetAverageIPScalarRange()
		/// \sa GetIsosurfaceValues()
		/// </summary>
		// Token: 0x06002C54 RID: 11348 RVA: 0x000417B7 File Offset: 0x0003F9B7
		public void SetBlendModeToAverageIntensity()
		{
			vtkVolumeMapper.vtkVolumeMapper_SetBlendModeToAverageIntensity_33(base.GetCppThis());
		}

		// Token: 0x06002C55 RID: 11349
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeMapper_SetBlendModeToComposite_34(HandleRef pThis);

		/// <summary>
		/// Set/Get the blend mode.
		/// The default mode is Composite where the scalar values are sampled through
		/// the volume and composited in a front-to-back scheme through alpha blending.
		/// The final color and opacity is determined using the color and opacity
		/// transfer functions.
		///
		/// Maximum and minimum intensity blend modes use the maximum and minimum
		/// scalar values, respectively, along the sampling ray. The final color and
		/// opacity is determined by passing the resultant value through the color and
		/// opacity transfer functions.
		///
		/// Additive blend mode accumulates scalar values by passing each value through
		/// the opacity transfer function and then adding up the product of the value
		/// and its opacity. In other words, the scalar values are scaled using the
		/// opacity transfer function and summed to derive the final color. Note that
		/// the resulting image is always grayscale i.e. aggregated values are not
		/// passed through the color transfer function. This is because the final
		/// value is a derived value and not a real data value along the sampling ray.
		///
		/// Average intensity blend mode works similar to the additive blend mode where
		/// the scalar values are multiplied by opacity calculated from the opacity
		/// transfer function and then added. The additional step here is to
		/// divide the sum by the number of samples taken through the volume.
		/// One can control the scalar range by setting the AverageIPScalarRange ivar
		/// to disregard scalar values, not in the range of interest, from the average
		/// computation.
		/// As is the case with the additive intensity projection, the final
		/// image will always be grayscale i.e. the aggregated values are not
		/// passed through the color transfer function. This is because the
		/// resultant value is a derived value and not a real data value along
		/// the sampling ray.
		///
		/// IsoSurface blend mode uses contour values defined by the user in order
		/// to display scalar values only when the ray crosses the contour. It supports
		/// opacity the same way composite blend mode does.
		///
		/// \note vtkVolumeMapper::AVERAGE_INTENSITY_BLEND and ISOSURFACE_BLEND are
		/// only supported by the vtkGPUVolumeRayCastMapper with the OpenGL2 backend.
		/// \sa SetAverageIPScalarRange()
		/// \sa GetIsosurfaceValues()
		/// </summary>
		// Token: 0x06002C56 RID: 11350 RVA: 0x000417C6 File Offset: 0x0003F9C6
		public void SetBlendModeToComposite()
		{
			vtkVolumeMapper.vtkVolumeMapper_SetBlendModeToComposite_34(base.GetCppThis());
		}

		// Token: 0x06002C57 RID: 11351
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeMapper_SetBlendModeToIsoSurface_35(HandleRef pThis);

		/// <summary>
		/// Set/Get the blend mode.
		/// The default mode is Composite where the scalar values are sampled through
		/// the volume and composited in a front-to-back scheme through alpha blending.
		/// The final color and opacity is determined using the color and opacity
		/// transfer functions.
		///
		/// Maximum and minimum intensity blend modes use the maximum and minimum
		/// scalar values, respectively, along the sampling ray. The final color and
		/// opacity is determined by passing the resultant value through the color and
		/// opacity transfer functions.
		///
		/// Additive blend mode accumulates scalar values by passing each value through
		/// the opacity transfer function and then adding up the product of the value
		/// and its opacity. In other words, the scalar values are scaled using the
		/// opacity transfer function and summed to derive the final color. Note that
		/// the resulting image is always grayscale i.e. aggregated values are not
		/// passed through the color transfer function. This is because the final
		/// value is a derived value and not a real data value along the sampling ray.
		///
		/// Average intensity blend mode works similar to the additive blend mode where
		/// the scalar values are multiplied by opacity calculated from the opacity
		/// transfer function and then added. The additional step here is to
		/// divide the sum by the number of samples taken through the volume.
		/// One can control the scalar range by setting the AverageIPScalarRange ivar
		/// to disregard scalar values, not in the range of interest, from the average
		/// computation.
		/// As is the case with the additive intensity projection, the final
		/// image will always be grayscale i.e. the aggregated values are not
		/// passed through the color transfer function. This is because the
		/// resultant value is a derived value and not a real data value along
		/// the sampling ray.
		///
		/// IsoSurface blend mode uses contour values defined by the user in order
		/// to display scalar values only when the ray crosses the contour. It supports
		/// opacity the same way composite blend mode does.
		///
		/// \note vtkVolumeMapper::AVERAGE_INTENSITY_BLEND and ISOSURFACE_BLEND are
		/// only supported by the vtkGPUVolumeRayCastMapper with the OpenGL2 backend.
		/// \sa SetAverageIPScalarRange()
		/// \sa GetIsosurfaceValues()
		/// </summary>
		// Token: 0x06002C58 RID: 11352 RVA: 0x000417D5 File Offset: 0x0003F9D5
		public void SetBlendModeToIsoSurface()
		{
			vtkVolumeMapper.vtkVolumeMapper_SetBlendModeToIsoSurface_35(base.GetCppThis());
		}

		// Token: 0x06002C59 RID: 11353
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeMapper_SetBlendModeToMaximumIntensity_36(HandleRef pThis);

		/// <summary>
		/// Set/Get the blend mode.
		/// The default mode is Composite where the scalar values are sampled through
		/// the volume and composited in a front-to-back scheme through alpha blending.
		/// The final color and opacity is determined using the color and opacity
		/// transfer functions.
		///
		/// Maximum and minimum intensity blend modes use the maximum and minimum
		/// scalar values, respectively, along the sampling ray. The final color and
		/// opacity is determined by passing the resultant value through the color and
		/// opacity transfer functions.
		///
		/// Additive blend mode accumulates scalar values by passing each value through
		/// the opacity transfer function and then adding up the product of the value
		/// and its opacity. In other words, the scalar values are scaled using the
		/// opacity transfer function and summed to derive the final color. Note that
		/// the resulting image is always grayscale i.e. aggregated values are not
		/// passed through the color transfer function. This is because the final
		/// value is a derived value and not a real data value along the sampling ray.
		///
		/// Average intensity blend mode works similar to the additive blend mode where
		/// the scalar values are multiplied by opacity calculated from the opacity
		/// transfer function and then added. The additional step here is to
		/// divide the sum by the number of samples taken through the volume.
		/// One can control the scalar range by setting the AverageIPScalarRange ivar
		/// to disregard scalar values, not in the range of interest, from the average
		/// computation.
		/// As is the case with the additive intensity projection, the final
		/// image will always be grayscale i.e. the aggregated values are not
		/// passed through the color transfer function. This is because the
		/// resultant value is a derived value and not a real data value along
		/// the sampling ray.
		///
		/// IsoSurface blend mode uses contour values defined by the user in order
		/// to display scalar values only when the ray crosses the contour. It supports
		/// opacity the same way composite blend mode does.
		///
		/// \note vtkVolumeMapper::AVERAGE_INTENSITY_BLEND and ISOSURFACE_BLEND are
		/// only supported by the vtkGPUVolumeRayCastMapper with the OpenGL2 backend.
		/// \sa SetAverageIPScalarRange()
		/// \sa GetIsosurfaceValues()
		/// </summary>
		// Token: 0x06002C5A RID: 11354 RVA: 0x000417E4 File Offset: 0x0003F9E4
		public void SetBlendModeToMaximumIntensity()
		{
			vtkVolumeMapper.vtkVolumeMapper_SetBlendModeToMaximumIntensity_36(base.GetCppThis());
		}

		// Token: 0x06002C5B RID: 11355
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeMapper_SetBlendModeToMinimumIntensity_37(HandleRef pThis);

		/// <summary>
		/// Set/Get the blend mode.
		/// The default mode is Composite where the scalar values are sampled through
		/// the volume and composited in a front-to-back scheme through alpha blending.
		/// The final color and opacity is determined using the color and opacity
		/// transfer functions.
		///
		/// Maximum and minimum intensity blend modes use the maximum and minimum
		/// scalar values, respectively, along the sampling ray. The final color and
		/// opacity is determined by passing the resultant value through the color and
		/// opacity transfer functions.
		///
		/// Additive blend mode accumulates scalar values by passing each value through
		/// the opacity transfer function and then adding up the product of the value
		/// and its opacity. In other words, the scalar values are scaled using the
		/// opacity transfer function and summed to derive the final color. Note that
		/// the resulting image is always grayscale i.e. aggregated values are not
		/// passed through the color transfer function. This is because the final
		/// value is a derived value and not a real data value along the sampling ray.
		///
		/// Average intensity blend mode works similar to the additive blend mode where
		/// the scalar values are multiplied by opacity calculated from the opacity
		/// transfer function and then added. The additional step here is to
		/// divide the sum by the number of samples taken through the volume.
		/// One can control the scalar range by setting the AverageIPScalarRange ivar
		/// to disregard scalar values, not in the range of interest, from the average
		/// computation.
		/// As is the case with the additive intensity projection, the final
		/// image will always be grayscale i.e. the aggregated values are not
		/// passed through the color transfer function. This is because the
		/// resultant value is a derived value and not a real data value along
		/// the sampling ray.
		///
		/// IsoSurface blend mode uses contour values defined by the user in order
		/// to display scalar values only when the ray crosses the contour. It supports
		/// opacity the same way composite blend mode does.
		///
		/// \note vtkVolumeMapper::AVERAGE_INTENSITY_BLEND and ISOSURFACE_BLEND are
		/// only supported by the vtkGPUVolumeRayCastMapper with the OpenGL2 backend.
		/// \sa SetAverageIPScalarRange()
		/// \sa GetIsosurfaceValues()
		/// </summary>
		// Token: 0x06002C5C RID: 11356 RVA: 0x000417F3 File Offset: 0x0003F9F3
		public void SetBlendModeToMinimumIntensity()
		{
			vtkVolumeMapper.vtkVolumeMapper_SetBlendModeToMinimumIntensity_37(base.GetCppThis());
		}

		// Token: 0x06002C5D RID: 11357
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeMapper_SetBlendModeToSlice_38(HandleRef pThis);

		/// <summary>
		/// Set/Get the blend mode.
		/// The default mode is Composite where the scalar values are sampled through
		/// the volume and composited in a front-to-back scheme through alpha blending.
		/// The final color and opacity is determined using the color and opacity
		/// transfer functions.
		///
		/// Maximum and minimum intensity blend modes use the maximum and minimum
		/// scalar values, respectively, along the sampling ray. The final color and
		/// opacity is determined by passing the resultant value through the color and
		/// opacity transfer functions.
		///
		/// Additive blend mode accumulates scalar values by passing each value through
		/// the opacity transfer function and then adding up the product of the value
		/// and its opacity. In other words, the scalar values are scaled using the
		/// opacity transfer function and summed to derive the final color. Note that
		/// the resulting image is always grayscale i.e. aggregated values are not
		/// passed through the color transfer function. This is because the final
		/// value is a derived value and not a real data value along the sampling ray.
		///
		/// Average intensity blend mode works similar to the additive blend mode where
		/// the scalar values are multiplied by opacity calculated from the opacity
		/// transfer function and then added. The additional step here is to
		/// divide the sum by the number of samples taken through the volume.
		/// One can control the scalar range by setting the AverageIPScalarRange ivar
		/// to disregard scalar values, not in the range of interest, from the average
		/// computation.
		/// As is the case with the additive intensity projection, the final
		/// image will always be grayscale i.e. the aggregated values are not
		/// passed through the color transfer function. This is because the
		/// resultant value is a derived value and not a real data value along
		/// the sampling ray.
		///
		/// IsoSurface blend mode uses contour values defined by the user in order
		/// to display scalar values only when the ray crosses the contour. It supports
		/// opacity the same way composite blend mode does.
		///
		/// \note vtkVolumeMapper::AVERAGE_INTENSITY_BLEND and ISOSURFACE_BLEND are
		/// only supported by the vtkGPUVolumeRayCastMapper with the OpenGL2 backend.
		/// \sa SetAverageIPScalarRange()
		/// \sa GetIsosurfaceValues()
		/// </summary>
		// Token: 0x06002C5E RID: 11358 RVA: 0x00041802 File Offset: 0x0003FA02
		public void SetBlendModeToSlice()
		{
			vtkVolumeMapper.vtkVolumeMapper_SetBlendModeToSlice_38(base.GetCppThis());
		}

		// Token: 0x06002C5F RID: 11359
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeMapper_SetComputeNormalFromOpacity_39(HandleRef pThis, byte _arg);

		/// <summary>
		/// If enabled, the volume(s) whose shading is enabled will use the gradient
		/// of opacity instead of the scalar gradient to estimate the surface's normal
		/// when applying the shading model. The opacity considered for the gradient
		/// is then the scalars converted to opacity by the transfer function(s).
		/// For now it is only supported in vtkGPUVolumeRayCastMapper.
		/// In vtkSmartVolumeMapper and in vtkMultiBlockVolumeMapper, this parameter
		/// is used when the GPU mapper is effectively used.
		/// Note that enabling it might affect performances, especially when
		/// using a 2D TF or a gradient opacity. It is disabled by default.
		/// </summary>
		// Token: 0x06002C60 RID: 11360 RVA: 0x00041811 File Offset: 0x0003FA11
		public virtual void SetComputeNormalFromOpacity(bool _arg)
		{
			vtkVolumeMapper.vtkVolumeMapper_SetComputeNormalFromOpacity_39(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06002C61 RID: 11361
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeMapper_SetCropping_40(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn On/Off orthogonal cropping. (Clipping planes are
		/// perpendicular to the coordinate axes.)
		/// </summary>
		// Token: 0x06002C62 RID: 11362 RVA: 0x00041829 File Offset: 0x0003FA29
		public virtual void SetCropping(int _arg)
		{
			vtkVolumeMapper.vtkVolumeMapper_SetCropping_40(base.GetCppThis(), _arg);
		}

		// Token: 0x06002C63 RID: 11363
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeMapper_SetCroppingRegionFlags_41(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the flags for the cropping regions. The clipping planes divide the
		/// volume into 27 regions - there is one bit for each region. The regions
		/// start from the one containing voxel (0,0,0), moving along the x axis
		/// fastest, the y axis next, and the z axis slowest. These are represented
		/// from the lowest bit to bit number 27 in the integer containing the
		/// flags. There are several convenience functions to set some common
		/// configurations - subvolume (the default), fence (between any of the
		/// clip plane pairs), inverted fence, cross (between any two of the
		/// clip plane pairs) and inverted cross.
		/// </summary>
		// Token: 0x06002C64 RID: 11364 RVA: 0x00041839 File Offset: 0x0003FA39
		public virtual void SetCroppingRegionFlags(int _arg)
		{
			vtkVolumeMapper.vtkVolumeMapper_SetCroppingRegionFlags_41(base.GetCppThis(), _arg);
		}

		// Token: 0x06002C65 RID: 11365
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeMapper_SetCroppingRegionFlagsToCross_42(HandleRef pThis);

		/// <summary>
		/// Set the flags for the cropping regions. The clipping planes divide the
		/// volume into 27 regions - there is one bit for each region. The regions
		/// start from the one containing voxel (0,0,0), moving along the x axis
		/// fastest, the y axis next, and the z axis slowest. These are represented
		/// from the lowest bit to bit number 27 in the integer containing the
		/// flags. There are several convenience functions to set some common
		/// configurations - subvolume (the default), fence (between any of the
		/// clip plane pairs), inverted fence, cross (between any two of the
		/// clip plane pairs) and inverted cross.
		/// </summary>
		// Token: 0x06002C66 RID: 11366 RVA: 0x00041849 File Offset: 0x0003FA49
		public void SetCroppingRegionFlagsToCross()
		{
			vtkVolumeMapper.vtkVolumeMapper_SetCroppingRegionFlagsToCross_42(base.GetCppThis());
		}

		// Token: 0x06002C67 RID: 11367
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeMapper_SetCroppingRegionFlagsToFence_43(HandleRef pThis);

		/// <summary>
		/// Set the flags for the cropping regions. The clipping planes divide the
		/// volume into 27 regions - there is one bit for each region. The regions
		/// start from the one containing voxel (0,0,0), moving along the x axis
		/// fastest, the y axis next, and the z axis slowest. These are represented
		/// from the lowest bit to bit number 27 in the integer containing the
		/// flags. There are several convenience functions to set some common
		/// configurations - subvolume (the default), fence (between any of the
		/// clip plane pairs), inverted fence, cross (between any two of the
		/// clip plane pairs) and inverted cross.
		/// </summary>
		// Token: 0x06002C68 RID: 11368 RVA: 0x00041858 File Offset: 0x0003FA58
		public void SetCroppingRegionFlagsToFence()
		{
			vtkVolumeMapper.vtkVolumeMapper_SetCroppingRegionFlagsToFence_43(base.GetCppThis());
		}

		// Token: 0x06002C69 RID: 11369
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeMapper_SetCroppingRegionFlagsToInvertedCross_44(HandleRef pThis);

		/// <summary>
		/// Set the flags for the cropping regions. The clipping planes divide the
		/// volume into 27 regions - there is one bit for each region. The regions
		/// start from the one containing voxel (0,0,0), moving along the x axis
		/// fastest, the y axis next, and the z axis slowest. These are represented
		/// from the lowest bit to bit number 27 in the integer containing the
		/// flags. There are several convenience functions to set some common
		/// configurations - subvolume (the default), fence (between any of the
		/// clip plane pairs), inverted fence, cross (between any two of the
		/// clip plane pairs) and inverted cross.
		/// </summary>
		// Token: 0x06002C6A RID: 11370 RVA: 0x00041867 File Offset: 0x0003FA67
		public void SetCroppingRegionFlagsToInvertedCross()
		{
			vtkVolumeMapper.vtkVolumeMapper_SetCroppingRegionFlagsToInvertedCross_44(base.GetCppThis());
		}

		// Token: 0x06002C6B RID: 11371
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeMapper_SetCroppingRegionFlagsToInvertedFence_45(HandleRef pThis);

		/// <summary>
		/// Set the flags for the cropping regions. The clipping planes divide the
		/// volume into 27 regions - there is one bit for each region. The regions
		/// start from the one containing voxel (0,0,0), moving along the x axis
		/// fastest, the y axis next, and the z axis slowest. These are represented
		/// from the lowest bit to bit number 27 in the integer containing the
		/// flags. There are several convenience functions to set some common
		/// configurations - subvolume (the default), fence (between any of the
		/// clip plane pairs), inverted fence, cross (between any two of the
		/// clip plane pairs) and inverted cross.
		/// </summary>
		// Token: 0x06002C6C RID: 11372 RVA: 0x00041876 File Offset: 0x0003FA76
		public void SetCroppingRegionFlagsToInvertedFence()
		{
			vtkVolumeMapper.vtkVolumeMapper_SetCroppingRegionFlagsToInvertedFence_45(base.GetCppThis());
		}

		// Token: 0x06002C6D RID: 11373
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeMapper_SetCroppingRegionFlagsToSubVolume_46(HandleRef pThis);

		/// <summary>
		/// Set the flags for the cropping regions. The clipping planes divide the
		/// volume into 27 regions - there is one bit for each region. The regions
		/// start from the one containing voxel (0,0,0), moving along the x axis
		/// fastest, the y axis next, and the z axis slowest. These are represented
		/// from the lowest bit to bit number 27 in the integer containing the
		/// flags. There are several convenience functions to set some common
		/// configurations - subvolume (the default), fence (between any of the
		/// clip plane pairs), inverted fence, cross (between any two of the
		/// clip plane pairs) and inverted cross.
		/// </summary>
		// Token: 0x06002C6E RID: 11374 RVA: 0x00041885 File Offset: 0x0003FA85
		public void SetCroppingRegionFlagsToSubVolume()
		{
			vtkVolumeMapper.vtkVolumeMapper_SetCroppingRegionFlagsToSubVolume_46(base.GetCppThis());
		}

		// Token: 0x06002C6F RID: 11375
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeMapper_SetCroppingRegionPlanes_47(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		/// <summary>
		/// Set/Get the Cropping Region Planes ( xmin, xmax, ymin, ymax, zmin, zmax )
		/// These planes are defined in volume coordinates - spacing and origin are
		/// considered.
		/// </summary>
		// Token: 0x06002C70 RID: 11376 RVA: 0x00041894 File Offset: 0x0003FA94
		public virtual void SetCroppingRegionPlanes(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkVolumeMapper.vtkVolumeMapper_SetCroppingRegionPlanes_47(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x06002C71 RID: 11377
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeMapper_SetCroppingRegionPlanes_48(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the Cropping Region Planes ( xmin, xmax, ymin, ymax, zmin, zmax )
		/// These planes are defined in volume coordinates - spacing and origin are
		/// considered.
		/// </summary>
		// Token: 0x06002C72 RID: 11378 RVA: 0x000418AC File Offset: 0x0003FAAC
		public virtual void SetCroppingRegionPlanes(IntPtr _arg)
		{
			vtkVolumeMapper.vtkVolumeMapper_SetCroppingRegionPlanes_48(base.GetCppThis(), _arg);
		}

		// Token: 0x06002C73 RID: 11379
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeMapper_SetInputData_49(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the input data
		/// </summary>
		// Token: 0x06002C74 RID: 11380 RVA: 0x000418BC File Offset: 0x0003FABC
		public virtual void SetInputData(vtkImageData arg0)
		{
			vtkVolumeMapper.vtkVolumeMapper_SetInputData_49(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002C75 RID: 11381
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeMapper_SetInputData_50(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the input data
		/// </summary>
		// Token: 0x06002C76 RID: 11382 RVA: 0x000418EC File Offset: 0x0003FAEC
		public virtual void SetInputData(vtkDataSet arg0)
		{
			vtkVolumeMapper.vtkVolumeMapper_SetInputData_50(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002C77 RID: 11383
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeMapper_SetInputData_51(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the input data
		/// </summary>
		// Token: 0x06002C78 RID: 11384 RVA: 0x0004191C File Offset: 0x0003FB1C
		public virtual void SetInputData(vtkRectilinearGrid arg0)
		{
			vtkVolumeMapper.vtkVolumeMapper_SetInputData_51(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000593 RID: 1427
		public new const string MRFullTypeName = "Kitware.VTK.vtkVolumeMapper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000594 RID: 1428
		public new static readonly string MRClassNameKey = "class vtkVolumeMapper";

		/// <summary>
		/// Blend modes.
		/// The default mode is Composite where the scalar values are sampled through
		/// the volume and composited in a front-to-back scheme through alpha blending.
		/// The final color and opacity is determined using the color and opacity
		/// transfer functions.
		///
		/// Maximum and minimum intensity blend modes use the maximum and minimum
		/// scalar values, respectively,  along the sampling ray. The final color and
		/// opacity is determined by passing the resultant value through the color and
		/// opacity transfer functions.
		///
		/// Additive blend mode accumulates scalar values by passing each value through
		/// the opacity transfer function and then adding up the product of the value
		/// and its opacity. In other words, the scalar values are scaled using the
		/// opacity transfer function and summed to derive the final color. Note that
		/// the resulting image is always grayscale i.e. aggregated values are not
		/// passed through the color transfer function. This is because the final
		/// value is a derived value and not a real data value along the sampling ray.
		///
		/// Average intensity blend mode works similar to the additive blend mode where
		/// the scalar values are multiplied by opacity calculated from the opacity
		/// transfer function and then added. The additional step here is to
		/// divide the sum by the number of samples taken through the volume.
		/// One can control the scalar range by setting the AverageIPScalarRange ivar
		/// to disregard scalar values, not in the range of interest, from the average
		/// computation.
		/// As is the case with the additive intensity projection, the final
		/// image will always be grayscale i.e. the aggregated values are not
		/// passed through the color transfer function. This is because the
		/// resultant value is a derived value and not a real data value along
		/// the sampling ray.
		///
		/// IsoSurface blend mode uses contour values defined by the user in order
		/// to display scalar values only when the ray crosses the contour. It supports
		/// opacity the same way composite blend mode does.
		///
		/// \note vtkVolumeMapper::AVERAGE_INTENSITY_BLEND and ISOSURFACE_BLEND are
		/// only supported by the vtkGPUVolumeRayCastMapper with the OpenGL2 backend.
		/// \sa SetAverageIPScalarRange()
		/// \sa GetIsoSurfaceValues()
		/// </summary>
		// Token: 0x020000D1 RID: 209
		public enum BlendModes
		{
			/// <summary>enum member</summary>
			// Token: 0x04000596 RID: 1430
			ADDITIVE_BLEND = 4,
			/// <summary>enum member</summary>
			// Token: 0x04000597 RID: 1431
			AVERAGE_INTENSITY_BLEND = 3,
			/// <summary>enum member</summary>
			// Token: 0x04000598 RID: 1432
			COMPOSITE_BLEND = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000599 RID: 1433
			ISOSURFACE_BLEND = 5,
			/// <summary>enum member</summary>
			// Token: 0x0400059A RID: 1434
			MAXIMUM_INTENSITY_BLEND = 1,
			/// <summary>enum member</summary>
			// Token: 0x0400059B RID: 1435
			MINIMUM_INTENSITY_BLEND,
			/// <summary>enum member</summary>
			// Token: 0x0400059C RID: 1436
			SLICE_BLEND = 6
		}
	}
}
