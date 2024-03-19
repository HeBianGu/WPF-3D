using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkUnstructuredGridVolumeRayCastMapper
	/// </summary>
	/// <remarks>
	///    A software mapper for unstructured volumes
	///
	/// This is a software ray caster for rendering volumes in vtkUnstructuredGrid.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkVolumeMapper
	/// </seealso>
	// Token: 0x020003AA RID: 938
	public class vtkUnstructuredGridVolumeRayCastMapper : vtkUnstructuredGridVolumeMapper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600AA3E RID: 43582 RVA: 0x000F208C File Offset: 0x000F028C
		static vtkUnstructuredGridVolumeRayCastMapper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUnstructuredGridVolumeRayCastMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGridVolumeRayCastMapper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600AA3F RID: 43583 RVA: 0x000F20B4 File Offset: 0x000F02B4
		public vtkUnstructuredGridVolumeRayCastMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600AA40 RID: 43584
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridVolumeRayCastMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AA41 RID: 43585 RVA: 0x000F20C4 File Offset: 0x000F02C4
		public new static vtkUnstructuredGridVolumeRayCastMapper New()
		{
			vtkUnstructuredGridVolumeRayCastMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridVolumeRayCastMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AA42 RID: 43586 RVA: 0x000F2118 File Offset: 0x000F0318
		public vtkUnstructuredGridVolumeRayCastMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600AA43 RID: 43587 RVA: 0x000F215C File Offset: 0x000F035C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600AA44 RID: 43588
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridVolumeRayCastMapper_AutoAdjustSampleDistancesOff_01(HandleRef pThis);

		/// <summary>
		/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
		/// will be varied to achieve the allocated render time of this
		/// prop (controlled by the desired update rate and any culling in
		/// use).
		/// </summary>
		// Token: 0x0600AA45 RID: 43589 RVA: 0x000F2167 File Offset: 0x000F0367
		public virtual void AutoAdjustSampleDistancesOff()
		{
			vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_AutoAdjustSampleDistancesOff_01(base.GetCppThis());
		}

		// Token: 0x0600AA46 RID: 43590
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridVolumeRayCastMapper_AutoAdjustSampleDistancesOn_02(HandleRef pThis);

		/// <summary>
		/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
		/// will be varied to achieve the allocated render time of this
		/// prop (controlled by the desired update rate and any culling in
		/// use).
		/// </summary>
		// Token: 0x0600AA47 RID: 43591 RVA: 0x000F2176 File Offset: 0x000F0376
		public virtual void AutoAdjustSampleDistancesOn()
		{
			vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_AutoAdjustSampleDistancesOn_02(base.GetCppThis());
		}

		// Token: 0x0600AA48 RID: 43592
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridVolumeRayCastMapper_CastRays_03(HandleRef pThis, int threadID, int threadCount);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Release any graphics resources that are being consumed by this mapper.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x0600AA49 RID: 43593 RVA: 0x000F2185 File Offset: 0x000F0385
		public void CastRays(int threadID, int threadCount)
		{
			vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_CastRays_03(base.GetCppThis(), threadID, threadCount);
		}

		// Token: 0x0600AA4A RID: 43594
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridVolumeRayCastMapper_GetAutoAdjustSampleDistances_04(HandleRef pThis);

		/// <summary>
		/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
		/// will be varied to achieve the allocated render time of this
		/// prop (controlled by the desired update rate and any culling in
		/// use).
		/// </summary>
		// Token: 0x0600AA4B RID: 43595 RVA: 0x000F2198 File Offset: 0x000F0398
		public virtual int GetAutoAdjustSampleDistances()
		{
			return vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_GetAutoAdjustSampleDistances_04(base.GetCppThis());
		}

		// Token: 0x0600AA4C RID: 43596
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridVolumeRayCastMapper_GetAutoAdjustSampleDistancesMaxValue_05(HandleRef pThis);

		/// <summary>
		/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
		/// will be varied to achieve the allocated render time of this
		/// prop (controlled by the desired update rate and any culling in
		/// use).
		/// </summary>
		// Token: 0x0600AA4D RID: 43597 RVA: 0x000F21B8 File Offset: 0x000F03B8
		public virtual int GetAutoAdjustSampleDistancesMaxValue()
		{
			return vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_GetAutoAdjustSampleDistancesMaxValue_05(base.GetCppThis());
		}

		// Token: 0x0600AA4E RID: 43598
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridVolumeRayCastMapper_GetAutoAdjustSampleDistancesMinValue_06(HandleRef pThis);

		/// <summary>
		/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
		/// will be varied to achieve the allocated render time of this
		/// prop (controlled by the desired update rate and any culling in
		/// use).
		/// </summary>
		// Token: 0x0600AA4F RID: 43599 RVA: 0x000F21D8 File Offset: 0x000F03D8
		public virtual int GetAutoAdjustSampleDistancesMinValue()
		{
			return vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_GetAutoAdjustSampleDistancesMinValue_06(base.GetCppThis());
		}

		// Token: 0x0600AA50 RID: 43600
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridVolumeRayCastMapper_GetImageInUseSize_07(HandleRef pThis);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Release any graphics resources that are being consumed by this mapper.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x0600AA51 RID: 43601 RVA: 0x000F21F8 File Offset: 0x000F03F8
		public virtual int[] GetImageInUseSize()
		{
			IntPtr intPtr = vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_GetImageInUseSize_07(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600AA52 RID: 43602
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridVolumeRayCastMapper_GetImageInUseSize_08(HandleRef pThis, IntPtr data);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Release any graphics resources that are being consumed by this mapper.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x0600AA53 RID: 43603 RVA: 0x000F2240 File Offset: 0x000F0440
		public virtual void GetImageInUseSize(IntPtr data)
		{
			vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_GetImageInUseSize_08(base.GetCppThis(), data);
		}

		// Token: 0x0600AA54 RID: 43604
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridVolumeRayCastMapper_GetImageOrigin_09(HandleRef pThis);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Release any graphics resources that are being consumed by this mapper.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x0600AA55 RID: 43605 RVA: 0x000F2250 File Offset: 0x000F0450
		public virtual int[] GetImageOrigin()
		{
			IntPtr intPtr = vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_GetImageOrigin_09(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600AA56 RID: 43606
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridVolumeRayCastMapper_GetImageOrigin_10(HandleRef pThis, IntPtr data);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Release any graphics resources that are being consumed by this mapper.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x0600AA57 RID: 43607 RVA: 0x000F2298 File Offset: 0x000F0498
		public virtual void GetImageOrigin(IntPtr data)
		{
			vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_GetImageOrigin_10(base.GetCppThis(), data);
		}

		// Token: 0x0600AA58 RID: 43608
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkUnstructuredGridVolumeRayCastMapper_GetImageSampleDistance_11(HandleRef pThis);

		/// <summary>
		/// Sampling distance in the XY image dimensions. Default value of 1 meaning
		/// 1 ray cast per pixel. If set to 0.5, 4 rays will be cast per pixel. If
		/// set to 2.0, 1 ray will be cast for every 4 (2 by 2) pixels.
		/// </summary>
		// Token: 0x0600AA59 RID: 43609 RVA: 0x000F22A8 File Offset: 0x000F04A8
		public virtual float GetImageSampleDistance()
		{
			return vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_GetImageSampleDistance_11(base.GetCppThis());
		}

		// Token: 0x0600AA5A RID: 43610
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkUnstructuredGridVolumeRayCastMapper_GetImageSampleDistanceMaxValue_12(HandleRef pThis);

		/// <summary>
		/// Sampling distance in the XY image dimensions. Default value of 1 meaning
		/// 1 ray cast per pixel. If set to 0.5, 4 rays will be cast per pixel. If
		/// set to 2.0, 1 ray will be cast for every 4 (2 by 2) pixels.
		/// </summary>
		// Token: 0x0600AA5B RID: 43611 RVA: 0x000F22C8 File Offset: 0x000F04C8
		public virtual float GetImageSampleDistanceMaxValue()
		{
			return vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_GetImageSampleDistanceMaxValue_12(base.GetCppThis());
		}

		// Token: 0x0600AA5C RID: 43612
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkUnstructuredGridVolumeRayCastMapper_GetImageSampleDistanceMinValue_13(HandleRef pThis);

		/// <summary>
		/// Sampling distance in the XY image dimensions. Default value of 1 meaning
		/// 1 ray cast per pixel. If set to 0.5, 4 rays will be cast per pixel. If
		/// set to 2.0, 1 ray will be cast for every 4 (2 by 2) pixels.
		/// </summary>
		// Token: 0x0600AA5D RID: 43613 RVA: 0x000F22E8 File Offset: 0x000F04E8
		public virtual float GetImageSampleDistanceMinValue()
		{
			return vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_GetImageSampleDistanceMinValue_13(base.GetCppThis());
		}

		// Token: 0x0600AA5E RID: 43614
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridVolumeRayCastMapper_GetImageViewportSize_14(HandleRef pThis);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Release any graphics resources that are being consumed by this mapper.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x0600AA5F RID: 43615 RVA: 0x000F2308 File Offset: 0x000F0508
		public virtual int[] GetImageViewportSize()
		{
			IntPtr intPtr = vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_GetImageViewportSize_14(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600AA60 RID: 43616
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridVolumeRayCastMapper_GetImageViewportSize_15(HandleRef pThis, IntPtr data);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Release any graphics resources that are being consumed by this mapper.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x0600AA61 RID: 43617 RVA: 0x000F2350 File Offset: 0x000F0550
		public virtual void GetImageViewportSize(IntPtr data)
		{
			vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_GetImageViewportSize_15(base.GetCppThis(), data);
		}

		// Token: 0x0600AA62 RID: 43618
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridVolumeRayCastMapper_GetIntermixIntersectingGeometry_16(HandleRef pThis);

		/// <summary>
		/// If IntermixIntersectingGeometry is turned on, the zbuffer will be
		/// captured and used to limit the traversal of the rays.
		/// </summary>
		// Token: 0x0600AA63 RID: 43619 RVA: 0x000F2360 File Offset: 0x000F0560
		public virtual int GetIntermixIntersectingGeometry()
		{
			return vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_GetIntermixIntersectingGeometry_16(base.GetCppThis());
		}

		// Token: 0x0600AA64 RID: 43620
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridVolumeRayCastMapper_GetIntermixIntersectingGeometryMaxValue_17(HandleRef pThis);

		/// <summary>
		/// If IntermixIntersectingGeometry is turned on, the zbuffer will be
		/// captured and used to limit the traversal of the rays.
		/// </summary>
		// Token: 0x0600AA65 RID: 43621 RVA: 0x000F2380 File Offset: 0x000F0580
		public virtual int GetIntermixIntersectingGeometryMaxValue()
		{
			return vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_GetIntermixIntersectingGeometryMaxValue_17(base.GetCppThis());
		}

		// Token: 0x0600AA66 RID: 43622
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridVolumeRayCastMapper_GetIntermixIntersectingGeometryMinValue_18(HandleRef pThis);

		/// <summary>
		/// If IntermixIntersectingGeometry is turned on, the zbuffer will be
		/// captured and used to limit the traversal of the rays.
		/// </summary>
		// Token: 0x0600AA67 RID: 43623 RVA: 0x000F23A0 File Offset: 0x000F05A0
		public virtual int GetIntermixIntersectingGeometryMinValue()
		{
			return vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_GetIntermixIntersectingGeometryMinValue_18(base.GetCppThis());
		}

		// Token: 0x0600AA68 RID: 43624
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkUnstructuredGridVolumeRayCastMapper_GetMaximumImageSampleDistance_19(HandleRef pThis);

		/// <summary>
		/// This is the maximum image sample distance allow when the image
		/// sample distance is being automatically adjusted
		/// </summary>
		// Token: 0x0600AA69 RID: 43625 RVA: 0x000F23C0 File Offset: 0x000F05C0
		public virtual float GetMaximumImageSampleDistance()
		{
			return vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_GetMaximumImageSampleDistance_19(base.GetCppThis());
		}

		// Token: 0x0600AA6A RID: 43626
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkUnstructuredGridVolumeRayCastMapper_GetMaximumImageSampleDistanceMaxValue_20(HandleRef pThis);

		/// <summary>
		/// This is the maximum image sample distance allow when the image
		/// sample distance is being automatically adjusted
		/// </summary>
		// Token: 0x0600AA6B RID: 43627 RVA: 0x000F23E0 File Offset: 0x000F05E0
		public virtual float GetMaximumImageSampleDistanceMaxValue()
		{
			return vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_GetMaximumImageSampleDistanceMaxValue_20(base.GetCppThis());
		}

		// Token: 0x0600AA6C RID: 43628
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkUnstructuredGridVolumeRayCastMapper_GetMaximumImageSampleDistanceMinValue_21(HandleRef pThis);

		/// <summary>
		/// This is the maximum image sample distance allow when the image
		/// sample distance is being automatically adjusted
		/// </summary>
		// Token: 0x0600AA6D RID: 43629 RVA: 0x000F2400 File Offset: 0x000F0600
		public virtual float GetMaximumImageSampleDistanceMinValue()
		{
			return vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_GetMaximumImageSampleDistanceMinValue_21(base.GetCppThis());
		}

		// Token: 0x0600AA6E RID: 43630
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkUnstructuredGridVolumeRayCastMapper_GetMinimumImageSampleDistance_22(HandleRef pThis);

		/// <summary>
		/// This is the minimum image sample distance allow when the image
		/// sample distance is being automatically adjusted
		/// </summary>
		// Token: 0x0600AA6F RID: 43631 RVA: 0x000F2420 File Offset: 0x000F0620
		public virtual float GetMinimumImageSampleDistance()
		{
			return vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_GetMinimumImageSampleDistance_22(base.GetCppThis());
		}

		// Token: 0x0600AA70 RID: 43632
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkUnstructuredGridVolumeRayCastMapper_GetMinimumImageSampleDistanceMaxValue_23(HandleRef pThis);

		/// <summary>
		/// This is the minimum image sample distance allow when the image
		/// sample distance is being automatically adjusted
		/// </summary>
		// Token: 0x0600AA71 RID: 43633 RVA: 0x000F2440 File Offset: 0x000F0640
		public virtual float GetMinimumImageSampleDistanceMaxValue()
		{
			return vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_GetMinimumImageSampleDistanceMaxValue_23(base.GetCppThis());
		}

		// Token: 0x0600AA72 RID: 43634
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkUnstructuredGridVolumeRayCastMapper_GetMinimumImageSampleDistanceMinValue_24(HandleRef pThis);

		/// <summary>
		/// This is the minimum image sample distance allow when the image
		/// sample distance is being automatically adjusted
		/// </summary>
		// Token: 0x0600AA73 RID: 43635 RVA: 0x000F2460 File Offset: 0x000F0660
		public virtual float GetMinimumImageSampleDistanceMinValue()
		{
			return vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_GetMinimumImageSampleDistanceMinValue_24(base.GetCppThis());
		}

		// Token: 0x0600AA74 RID: 43636
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridVolumeRayCastMapper_GetNumberOfGenerationsFromBase_25(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AA75 RID: 43637 RVA: 0x000F2480 File Offset: 0x000F0680
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_GetNumberOfGenerationsFromBase_25(base.GetCppThis(), type);
		}

		// Token: 0x0600AA76 RID: 43638
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridVolumeRayCastMapper_GetNumberOfGenerationsFromBaseType_26([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AA77 RID: 43639 RVA: 0x000F24A0 File Offset: 0x000F06A0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_GetNumberOfGenerationsFromBaseType_26(type);
		}

		// Token: 0x0600AA78 RID: 43640
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridVolumeRayCastMapper_GetNumberOfThreads_27(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of threads to use. This by default is equal to
		/// the number of available processors detected.
		/// </summary>
		// Token: 0x0600AA79 RID: 43641 RVA: 0x000F24BC File Offset: 0x000F06BC
		public virtual int GetNumberOfThreads()
		{
			return vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_GetNumberOfThreads_27(base.GetCppThis());
		}

		// Token: 0x0600AA7A RID: 43642
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridVolumeRayCastMapper_GetRayCastFunction_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the helper class for casting rays.
		/// </summary>
		// Token: 0x0600AA7B RID: 43643 RVA: 0x000F24DC File Offset: 0x000F06DC
		public virtual vtkUnstructuredGridVolumeRayCastFunction GetRayCastFunction()
		{
			vtkUnstructuredGridVolumeRayCastFunction vtkUnstructuredGridVolumeRayCastFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_GetRayCastFunction_28(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGridVolumeRayCastFunction = (vtkUnstructuredGridVolumeRayCastFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGridVolumeRayCastFunction.Register(null);
				}
			}
			return vtkUnstructuredGridVolumeRayCastFunction;
		}

		// Token: 0x0600AA7C RID: 43644
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridVolumeRayCastMapper_GetRayIntegrator_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the helper class for integrating rays.  If set to NULL, a
		/// default integrator will be assigned.
		/// </summary>
		// Token: 0x0600AA7D RID: 43645 RVA: 0x000F254C File Offset: 0x000F074C
		public virtual vtkUnstructuredGridVolumeRayIntegrator GetRayIntegrator()
		{
			vtkUnstructuredGridVolumeRayIntegrator vtkUnstructuredGridVolumeRayIntegrator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_GetRayIntegrator_29(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGridVolumeRayIntegrator = (vtkUnstructuredGridVolumeRayIntegrator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGridVolumeRayIntegrator.Register(null);
				}
			}
			return vtkUnstructuredGridVolumeRayIntegrator;
		}

		// Token: 0x0600AA7E RID: 43646
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridVolumeRayCastMapper_IntermixIntersectingGeometryOff_30(HandleRef pThis);

		/// <summary>
		/// If IntermixIntersectingGeometry is turned on, the zbuffer will be
		/// captured and used to limit the traversal of the rays.
		/// </summary>
		// Token: 0x0600AA7F RID: 43647 RVA: 0x000F25BB File Offset: 0x000F07BB
		public virtual void IntermixIntersectingGeometryOff()
		{
			vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_IntermixIntersectingGeometryOff_30(base.GetCppThis());
		}

		// Token: 0x0600AA80 RID: 43648
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridVolumeRayCastMapper_IntermixIntersectingGeometryOn_31(HandleRef pThis);

		/// <summary>
		/// If IntermixIntersectingGeometry is turned on, the zbuffer will be
		/// captured and used to limit the traversal of the rays.
		/// </summary>
		// Token: 0x0600AA81 RID: 43649 RVA: 0x000F25CA File Offset: 0x000F07CA
		public virtual void IntermixIntersectingGeometryOn()
		{
			vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_IntermixIntersectingGeometryOn_31(base.GetCppThis());
		}

		// Token: 0x0600AA82 RID: 43650
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridVolumeRayCastMapper_IsA_32(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AA83 RID: 43651 RVA: 0x000F25DC File Offset: 0x000F07DC
		public override int IsA(string type)
		{
			return vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_IsA_32(base.GetCppThis(), type);
		}

		// Token: 0x0600AA84 RID: 43652
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridVolumeRayCastMapper_IsTypeOf_33([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AA85 RID: 43653 RVA: 0x000F25FC File Offset: 0x000F07FC
		public new static int IsTypeOf(string type)
		{
			return vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_IsTypeOf_33(type);
		}

		// Token: 0x0600AA86 RID: 43654
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridVolumeRayCastMapper_NewInstance_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AA87 RID: 43655 RVA: 0x000F2618 File Offset: 0x000F0818
		public new vtkUnstructuredGridVolumeRayCastMapper NewInstance()
		{
			vtkUnstructuredGridVolumeRayCastMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_NewInstance_35(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridVolumeRayCastMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600AA88 RID: 43656
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridVolumeRayCastMapper_ReleaseGraphicsResources_36(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Release any graphics resources that are being consumed by this mapper.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x0600AA89 RID: 43657 RVA: 0x000F2674 File Offset: 0x000F0874
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_ReleaseGraphicsResources_36(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600AA8A RID: 43658
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridVolumeRayCastMapper_Render_37(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Initialize rendering for this volume.
		/// </summary>
		// Token: 0x0600AA8B RID: 43659 RVA: 0x000F26A4 File Offset: 0x000F08A4
		public override void Render(vtkRenderer arg0, vtkVolume arg1)
		{
			vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_Render_37(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x0600AA8C RID: 43660
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridVolumeRayCastMapper_SafeDownCast_38(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AA8D RID: 43661 RVA: 0x000F26E8 File Offset: 0x000F08E8
		public new static vtkUnstructuredGridVolumeRayCastMapper SafeDownCast(vtkObjectBase o)
		{
			vtkUnstructuredGridVolumeRayCastMapper vtkUnstructuredGridVolumeRayCastMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_SafeDownCast_38((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGridVolumeRayCastMapper = (vtkUnstructuredGridVolumeRayCastMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGridVolumeRayCastMapper.Register(null);
				}
			}
			return vtkUnstructuredGridVolumeRayCastMapper;
		}

		// Token: 0x0600AA8E RID: 43662
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridVolumeRayCastMapper_SetAutoAdjustSampleDistances_39(HandleRef pThis, int _arg);

		/// <summary>
		/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
		/// will be varied to achieve the allocated render time of this
		/// prop (controlled by the desired update rate and any culling in
		/// use).
		/// </summary>
		// Token: 0x0600AA8F RID: 43663 RVA: 0x000F2767 File Offset: 0x000F0967
		public virtual void SetAutoAdjustSampleDistances(int _arg)
		{
			vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_SetAutoAdjustSampleDistances_39(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AA90 RID: 43664
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridVolumeRayCastMapper_SetImageSampleDistance_40(HandleRef pThis, float _arg);

		/// <summary>
		/// Sampling distance in the XY image dimensions. Default value of 1 meaning
		/// 1 ray cast per pixel. If set to 0.5, 4 rays will be cast per pixel. If
		/// set to 2.0, 1 ray will be cast for every 4 (2 by 2) pixels.
		/// </summary>
		// Token: 0x0600AA91 RID: 43665 RVA: 0x000F2777 File Offset: 0x000F0977
		public virtual void SetImageSampleDistance(float _arg)
		{
			vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_SetImageSampleDistance_40(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AA92 RID: 43666
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridVolumeRayCastMapper_SetIntermixIntersectingGeometry_41(HandleRef pThis, int _arg);

		/// <summary>
		/// If IntermixIntersectingGeometry is turned on, the zbuffer will be
		/// captured and used to limit the traversal of the rays.
		/// </summary>
		// Token: 0x0600AA93 RID: 43667 RVA: 0x000F2787 File Offset: 0x000F0987
		public virtual void SetIntermixIntersectingGeometry(int _arg)
		{
			vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_SetIntermixIntersectingGeometry_41(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AA94 RID: 43668
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridVolumeRayCastMapper_SetMaximumImageSampleDistance_42(HandleRef pThis, float _arg);

		/// <summary>
		/// This is the maximum image sample distance allow when the image
		/// sample distance is being automatically adjusted
		/// </summary>
		// Token: 0x0600AA95 RID: 43669 RVA: 0x000F2797 File Offset: 0x000F0997
		public virtual void SetMaximumImageSampleDistance(float _arg)
		{
			vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_SetMaximumImageSampleDistance_42(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AA96 RID: 43670
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridVolumeRayCastMapper_SetMinimumImageSampleDistance_43(HandleRef pThis, float _arg);

		/// <summary>
		/// This is the minimum image sample distance allow when the image
		/// sample distance is being automatically adjusted
		/// </summary>
		// Token: 0x0600AA97 RID: 43671 RVA: 0x000F27A7 File Offset: 0x000F09A7
		public virtual void SetMinimumImageSampleDistance(float _arg)
		{
			vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_SetMinimumImageSampleDistance_43(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AA98 RID: 43672
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridVolumeRayCastMapper_SetNumberOfThreads_44(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the number of threads to use. This by default is equal to
		/// the number of available processors detected.
		/// </summary>
		// Token: 0x0600AA99 RID: 43673 RVA: 0x000F27B7 File Offset: 0x000F09B7
		public virtual void SetNumberOfThreads(int _arg)
		{
			vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_SetNumberOfThreads_44(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AA9A RID: 43674
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridVolumeRayCastMapper_SetRayCastFunction_45(HandleRef pThis, HandleRef f);

		/// <summary>
		/// Set/Get the helper class for casting rays.
		/// </summary>
		// Token: 0x0600AA9B RID: 43675 RVA: 0x000F27C8 File Offset: 0x000F09C8
		public virtual void SetRayCastFunction(vtkUnstructuredGridVolumeRayCastFunction f)
		{
			vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_SetRayCastFunction_45(base.GetCppThis(), (f == null) ? default(HandleRef) : f.GetCppThis());
		}

		// Token: 0x0600AA9C RID: 43676
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridVolumeRayCastMapper_SetRayIntegrator_46(HandleRef pThis, HandleRef ri);

		/// <summary>
		/// Set/Get the helper class for integrating rays.  If set to NULL, a
		/// default integrator will be assigned.
		/// </summary>
		// Token: 0x0600AA9D RID: 43677 RVA: 0x000F27F8 File Offset: 0x000F09F8
		public virtual void SetRayIntegrator(vtkUnstructuredGridVolumeRayIntegrator ri)
		{
			vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_SetRayIntegrator_46(base.GetCppThis(), (ri == null) ? default(HandleRef) : ri.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D89 RID: 3465
		public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGridVolumeRayCastMapper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D8A RID: 3466
		public new static readonly string MRClassNameKey = "class vtkUnstructuredGridVolumeRayCastMapper";
	}
}
