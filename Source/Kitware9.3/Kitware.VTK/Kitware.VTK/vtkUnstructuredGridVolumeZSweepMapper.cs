using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkUnstructuredGridVolumeZSweepMapper
	/// </summary>
	/// <remarks>
	///    Unstructured grid volume mapper based the ZSweep Algorithm
	///
	///
	/// This is a volume mapper for unstructured grid implemented with the ZSweep
	/// algorithm. This is a software projective method.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkVolumetMapper
	///
	/// @par Background:
	/// The algorithm is described in the following paper:
	/// Ricardo Farias, Joseph S. B. Mitchell and Claudio T. Silva.
	/// ZSWEEP: An Efficient and Exact Projection Algorithm for Unstructured Volume
	/// Rendering. In 2000 Volume Visualization Symposium, pages 91--99.
	/// October 2000.
	/// http://www.cse.ogi.edu/~csilva/papers/volvis2000.pdf
	/// </seealso>
	// Token: 0x020003AB RID: 939
	public class vtkUnstructuredGridVolumeZSweepMapper : vtkUnstructuredGridVolumeMapper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600AA9E RID: 43678 RVA: 0x000F2827 File Offset: 0x000F0A27
		static vtkUnstructuredGridVolumeZSweepMapper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUnstructuredGridVolumeZSweepMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGridVolumeZSweepMapper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600AA9F RID: 43679 RVA: 0x000F284F File Offset: 0x000F0A4F
		public vtkUnstructuredGridVolumeZSweepMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600AAA0 RID: 43680
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridVolumeZSweepMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set MaxPixelListSize to 32.
		/// </summary>
		// Token: 0x0600AAA1 RID: 43681 RVA: 0x000F2860 File Offset: 0x000F0A60
		public new static vtkUnstructuredGridVolumeZSweepMapper New()
		{
			vtkUnstructuredGridVolumeZSweepMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridVolumeZSweepMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Set MaxPixelListSize to 32.
		/// </summary>
		// Token: 0x0600AAA2 RID: 43682 RVA: 0x000F28B4 File Offset: 0x000F0AB4
		public vtkUnstructuredGridVolumeZSweepMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600AAA3 RID: 43683 RVA: 0x000F28F8 File Offset: 0x000F0AF8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600AAA4 RID: 43684
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridVolumeZSweepMapper_AutoAdjustSampleDistancesOff_01(HandleRef pThis);

		/// <summary>
		/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
		/// will be varied to achieve the allocated render time of this
		/// prop (controlled by the desired update rate and any culling in
		/// use).
		/// </summary>
		// Token: 0x0600AAA5 RID: 43685 RVA: 0x000F2903 File Offset: 0x000F0B03
		public virtual void AutoAdjustSampleDistancesOff()
		{
			vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_AutoAdjustSampleDistancesOff_01(base.GetCppThis());
		}

		// Token: 0x0600AAA6 RID: 43686
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridVolumeZSweepMapper_AutoAdjustSampleDistancesOn_02(HandleRef pThis);

		/// <summary>
		/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
		/// will be varied to achieve the allocated render time of this
		/// prop (controlled by the desired update rate and any culling in
		/// use).
		/// </summary>
		// Token: 0x0600AAA7 RID: 43687 RVA: 0x000F2912 File Offset: 0x000F0B12
		public virtual void AutoAdjustSampleDistancesOn()
		{
			vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_AutoAdjustSampleDistancesOn_02(base.GetCppThis());
		}

		// Token: 0x0600AAA8 RID: 43688
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridVolumeZSweepMapper_GetAutoAdjustSampleDistances_03(HandleRef pThis);

		/// <summary>
		/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
		/// will be varied to achieve the allocated render time of this
		/// prop (controlled by the desired update rate and any culling in
		/// use).
		/// </summary>
		// Token: 0x0600AAA9 RID: 43689 RVA: 0x000F2924 File Offset: 0x000F0B24
		public virtual int GetAutoAdjustSampleDistances()
		{
			return vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_GetAutoAdjustSampleDistances_03(base.GetCppThis());
		}

		// Token: 0x0600AAAA RID: 43690
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridVolumeZSweepMapper_GetAutoAdjustSampleDistancesMaxValue_04(HandleRef pThis);

		/// <summary>
		/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
		/// will be varied to achieve the allocated render time of this
		/// prop (controlled by the desired update rate and any culling in
		/// use).
		/// </summary>
		// Token: 0x0600AAAB RID: 43691 RVA: 0x000F2944 File Offset: 0x000F0B44
		public virtual int GetAutoAdjustSampleDistancesMaxValue()
		{
			return vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_GetAutoAdjustSampleDistancesMaxValue_04(base.GetCppThis());
		}

		// Token: 0x0600AAAC RID: 43692
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridVolumeZSweepMapper_GetAutoAdjustSampleDistancesMinValue_05(HandleRef pThis);

		/// <summary>
		/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
		/// will be varied to achieve the allocated render time of this
		/// prop (controlled by the desired update rate and any culling in
		/// use).
		/// </summary>
		// Token: 0x0600AAAD RID: 43693 RVA: 0x000F2964 File Offset: 0x000F0B64
		public virtual int GetAutoAdjustSampleDistancesMinValue()
		{
			return vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_GetAutoAdjustSampleDistancesMinValue_05(base.GetCppThis());
		}

		// Token: 0x0600AAAE RID: 43694
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridVolumeZSweepMapper_GetImageInUseSize_06(HandleRef pThis);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
		/// Render the volume
		/// </summary>
		// Token: 0x0600AAAF RID: 43695 RVA: 0x000F2984 File Offset: 0x000F0B84
		public virtual int[] GetImageInUseSize()
		{
			IntPtr intPtr = vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_GetImageInUseSize_06(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600AAB0 RID: 43696
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridVolumeZSweepMapper_GetImageInUseSize_07(HandleRef pThis, IntPtr data);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
		/// Render the volume
		/// </summary>
		// Token: 0x0600AAB1 RID: 43697 RVA: 0x000F29CC File Offset: 0x000F0BCC
		public virtual void GetImageInUseSize(IntPtr data)
		{
			vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_GetImageInUseSize_07(base.GetCppThis(), data);
		}

		// Token: 0x0600AAB2 RID: 43698
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridVolumeZSweepMapper_GetImageOrigin_08(HandleRef pThis);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
		/// Render the volume
		/// </summary>
		// Token: 0x0600AAB3 RID: 43699 RVA: 0x000F29DC File Offset: 0x000F0BDC
		public virtual int[] GetImageOrigin()
		{
			IntPtr intPtr = vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_GetImageOrigin_08(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600AAB4 RID: 43700
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridVolumeZSweepMapper_GetImageOrigin_09(HandleRef pThis, IntPtr data);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
		/// Render the volume
		/// </summary>
		// Token: 0x0600AAB5 RID: 43701 RVA: 0x000F2A24 File Offset: 0x000F0C24
		public virtual void GetImageOrigin(IntPtr data)
		{
			vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_GetImageOrigin_09(base.GetCppThis(), data);
		}

		// Token: 0x0600AAB6 RID: 43702
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkUnstructuredGridVolumeZSweepMapper_GetImageSampleDistance_10(HandleRef pThis);

		/// <summary>
		/// Sampling distance in the XY image dimensions. Default value of 1 meaning
		/// 1 ray cast per pixel. If set to 0.5, 4 rays will be cast per pixel. If
		/// set to 2.0, 1 ray will be cast for every 4 (2 by 2) pixels.
		/// </summary>
		// Token: 0x0600AAB7 RID: 43703 RVA: 0x000F2A34 File Offset: 0x000F0C34
		public virtual float GetImageSampleDistance()
		{
			return vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_GetImageSampleDistance_10(base.GetCppThis());
		}

		// Token: 0x0600AAB8 RID: 43704
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkUnstructuredGridVolumeZSweepMapper_GetImageSampleDistanceMaxValue_11(HandleRef pThis);

		/// <summary>
		/// Sampling distance in the XY image dimensions. Default value of 1 meaning
		/// 1 ray cast per pixel. If set to 0.5, 4 rays will be cast per pixel. If
		/// set to 2.0, 1 ray will be cast for every 4 (2 by 2) pixels.
		/// </summary>
		// Token: 0x0600AAB9 RID: 43705 RVA: 0x000F2A54 File Offset: 0x000F0C54
		public virtual float GetImageSampleDistanceMaxValue()
		{
			return vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_GetImageSampleDistanceMaxValue_11(base.GetCppThis());
		}

		// Token: 0x0600AABA RID: 43706
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkUnstructuredGridVolumeZSweepMapper_GetImageSampleDistanceMinValue_12(HandleRef pThis);

		/// <summary>
		/// Sampling distance in the XY image dimensions. Default value of 1 meaning
		/// 1 ray cast per pixel. If set to 0.5, 4 rays will be cast per pixel. If
		/// set to 2.0, 1 ray will be cast for every 4 (2 by 2) pixels.
		/// </summary>
		// Token: 0x0600AABB RID: 43707 RVA: 0x000F2A74 File Offset: 0x000F0C74
		public virtual float GetImageSampleDistanceMinValue()
		{
			return vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_GetImageSampleDistanceMinValue_12(base.GetCppThis());
		}

		// Token: 0x0600AABC RID: 43708
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridVolumeZSweepMapper_GetImageViewportSize_13(HandleRef pThis);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
		/// Render the volume
		/// </summary>
		// Token: 0x0600AABD RID: 43709 RVA: 0x000F2A94 File Offset: 0x000F0C94
		public virtual int[] GetImageViewportSize()
		{
			IntPtr intPtr = vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_GetImageViewportSize_13(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600AABE RID: 43710
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridVolumeZSweepMapper_GetImageViewportSize_14(HandleRef pThis, IntPtr data);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
		/// Render the volume
		/// </summary>
		// Token: 0x0600AABF RID: 43711 RVA: 0x000F2ADC File Offset: 0x000F0CDC
		public virtual void GetImageViewportSize(IntPtr data)
		{
			vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_GetImageViewportSize_14(base.GetCppThis(), data);
		}

		// Token: 0x0600AAC0 RID: 43712
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridVolumeZSweepMapper_GetIntermixIntersectingGeometry_15(HandleRef pThis);

		/// <summary>
		/// If IntermixIntersectingGeometry is turned on, the zbuffer will be
		/// captured and used to limit the traversal of the rays.
		/// </summary>
		// Token: 0x0600AAC1 RID: 43713 RVA: 0x000F2AEC File Offset: 0x000F0CEC
		public virtual int GetIntermixIntersectingGeometry()
		{
			return vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_GetIntermixIntersectingGeometry_15(base.GetCppThis());
		}

		// Token: 0x0600AAC2 RID: 43714
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridVolumeZSweepMapper_GetIntermixIntersectingGeometryMaxValue_16(HandleRef pThis);

		/// <summary>
		/// If IntermixIntersectingGeometry is turned on, the zbuffer will be
		/// captured and used to limit the traversal of the rays.
		/// </summary>
		// Token: 0x0600AAC3 RID: 43715 RVA: 0x000F2B0C File Offset: 0x000F0D0C
		public virtual int GetIntermixIntersectingGeometryMaxValue()
		{
			return vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_GetIntermixIntersectingGeometryMaxValue_16(base.GetCppThis());
		}

		// Token: 0x0600AAC4 RID: 43716
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridVolumeZSweepMapper_GetIntermixIntersectingGeometryMinValue_17(HandleRef pThis);

		/// <summary>
		/// If IntermixIntersectingGeometry is turned on, the zbuffer will be
		/// captured and used to limit the traversal of the rays.
		/// </summary>
		// Token: 0x0600AAC5 RID: 43717 RVA: 0x000F2B2C File Offset: 0x000F0D2C
		public virtual int GetIntermixIntersectingGeometryMinValue()
		{
			return vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_GetIntermixIntersectingGeometryMinValue_17(base.GetCppThis());
		}

		// Token: 0x0600AAC6 RID: 43718
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridVolumeZSweepMapper_GetMaxPixelListSize_18(HandleRef pThis);

		/// <summary>
		/// Maximum size allowed for a pixel list. Default is 32.
		/// During the rendering, if a list of pixel is full, incremental compositing
		/// is performed. Even if it is a user setting, it is an advanced parameter.
		/// You have to understand how the algorithm works to change this value.
		/// </summary>
		// Token: 0x0600AAC7 RID: 43719 RVA: 0x000F2B4C File Offset: 0x000F0D4C
		public int GetMaxPixelListSize()
		{
			return vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_GetMaxPixelListSize_18(base.GetCppThis());
		}

		// Token: 0x0600AAC8 RID: 43720
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkUnstructuredGridVolumeZSweepMapper_GetMaximumImageSampleDistance_19(HandleRef pThis);

		/// <summary>
		/// This is the maximum image sample distance allow when the image
		/// sample distance is being automatically adjusted
		/// </summary>
		// Token: 0x0600AAC9 RID: 43721 RVA: 0x000F2B6C File Offset: 0x000F0D6C
		public virtual float GetMaximumImageSampleDistance()
		{
			return vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_GetMaximumImageSampleDistance_19(base.GetCppThis());
		}

		// Token: 0x0600AACA RID: 43722
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkUnstructuredGridVolumeZSweepMapper_GetMaximumImageSampleDistanceMaxValue_20(HandleRef pThis);

		/// <summary>
		/// This is the maximum image sample distance allow when the image
		/// sample distance is being automatically adjusted
		/// </summary>
		// Token: 0x0600AACB RID: 43723 RVA: 0x000F2B8C File Offset: 0x000F0D8C
		public virtual float GetMaximumImageSampleDistanceMaxValue()
		{
			return vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_GetMaximumImageSampleDistanceMaxValue_20(base.GetCppThis());
		}

		// Token: 0x0600AACC RID: 43724
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkUnstructuredGridVolumeZSweepMapper_GetMaximumImageSampleDistanceMinValue_21(HandleRef pThis);

		/// <summary>
		/// This is the maximum image sample distance allow when the image
		/// sample distance is being automatically adjusted
		/// </summary>
		// Token: 0x0600AACD RID: 43725 RVA: 0x000F2BAC File Offset: 0x000F0DAC
		public virtual float GetMaximumImageSampleDistanceMinValue()
		{
			return vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_GetMaximumImageSampleDistanceMinValue_21(base.GetCppThis());
		}

		// Token: 0x0600AACE RID: 43726
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkUnstructuredGridVolumeZSweepMapper_GetMinimumImageSampleDistance_22(HandleRef pThis);

		/// <summary>
		/// This is the minimum image sample distance allow when the image
		/// sample distance is being automatically adjusted
		/// </summary>
		// Token: 0x0600AACF RID: 43727 RVA: 0x000F2BCC File Offset: 0x000F0DCC
		public virtual float GetMinimumImageSampleDistance()
		{
			return vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_GetMinimumImageSampleDistance_22(base.GetCppThis());
		}

		// Token: 0x0600AAD0 RID: 43728
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkUnstructuredGridVolumeZSweepMapper_GetMinimumImageSampleDistanceMaxValue_23(HandleRef pThis);

		/// <summary>
		/// This is the minimum image sample distance allow when the image
		/// sample distance is being automatically adjusted
		/// </summary>
		// Token: 0x0600AAD1 RID: 43729 RVA: 0x000F2BEC File Offset: 0x000F0DEC
		public virtual float GetMinimumImageSampleDistanceMaxValue()
		{
			return vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_GetMinimumImageSampleDistanceMaxValue_23(base.GetCppThis());
		}

		// Token: 0x0600AAD2 RID: 43730
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkUnstructuredGridVolumeZSweepMapper_GetMinimumImageSampleDistanceMinValue_24(HandleRef pThis);

		/// <summary>
		/// This is the minimum image sample distance allow when the image
		/// sample distance is being automatically adjusted
		/// </summary>
		// Token: 0x0600AAD3 RID: 43731 RVA: 0x000F2C0C File Offset: 0x000F0E0C
		public virtual float GetMinimumImageSampleDistanceMinValue()
		{
			return vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_GetMinimumImageSampleDistanceMinValue_24(base.GetCppThis());
		}

		// Token: 0x0600AAD4 RID: 43732
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridVolumeZSweepMapper_GetNumberOfGenerationsFromBase_25(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AAD5 RID: 43733 RVA: 0x000F2C2C File Offset: 0x000F0E2C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_GetNumberOfGenerationsFromBase_25(base.GetCppThis(), type);
		}

		// Token: 0x0600AAD6 RID: 43734
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridVolumeZSweepMapper_GetNumberOfGenerationsFromBaseType_26([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AAD7 RID: 43735 RVA: 0x000F2C4C File Offset: 0x000F0E4C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_GetNumberOfGenerationsFromBaseType_26(type);
		}

		// Token: 0x0600AAD8 RID: 43736
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridVolumeZSweepMapper_GetRayIntegrator_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the helper class for integrating rays.  If set to NULL, a
		/// default integrator will be assigned.
		/// </summary>
		// Token: 0x0600AAD9 RID: 43737 RVA: 0x000F2C68 File Offset: 0x000F0E68
		public virtual vtkUnstructuredGridVolumeRayIntegrator GetRayIntegrator()
		{
			vtkUnstructuredGridVolumeRayIntegrator vtkUnstructuredGridVolumeRayIntegrator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_GetRayIntegrator_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600AADA RID: 43738
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridVolumeZSweepMapper_IntermixIntersectingGeometryOff_28(HandleRef pThis);

		/// <summary>
		/// If IntermixIntersectingGeometry is turned on, the zbuffer will be
		/// captured and used to limit the traversal of the rays.
		/// </summary>
		// Token: 0x0600AADB RID: 43739 RVA: 0x000F2CD7 File Offset: 0x000F0ED7
		public virtual void IntermixIntersectingGeometryOff()
		{
			vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_IntermixIntersectingGeometryOff_28(base.GetCppThis());
		}

		// Token: 0x0600AADC RID: 43740
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridVolumeZSweepMapper_IntermixIntersectingGeometryOn_29(HandleRef pThis);

		/// <summary>
		/// If IntermixIntersectingGeometry is turned on, the zbuffer will be
		/// captured and used to limit the traversal of the rays.
		/// </summary>
		// Token: 0x0600AADD RID: 43741 RVA: 0x000F2CE6 File Offset: 0x000F0EE6
		public virtual void IntermixIntersectingGeometryOn()
		{
			vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_IntermixIntersectingGeometryOn_29(base.GetCppThis());
		}

		// Token: 0x0600AADE RID: 43742
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridVolumeZSweepMapper_IsA_30(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AADF RID: 43743 RVA: 0x000F2CF8 File Offset: 0x000F0EF8
		public override int IsA(string type)
		{
			return vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_IsA_30(base.GetCppThis(), type);
		}

		// Token: 0x0600AAE0 RID: 43744
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridVolumeZSweepMapper_IsTypeOf_31([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AAE1 RID: 43745 RVA: 0x000F2D18 File Offset: 0x000F0F18
		public new static int IsTypeOf(string type)
		{
			return vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_IsTypeOf_31(type);
		}

		// Token: 0x0600AAE2 RID: 43746
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridVolumeZSweepMapper_NewInstance_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AAE3 RID: 43747 RVA: 0x000F2D34 File Offset: 0x000F0F34
		public new vtkUnstructuredGridVolumeZSweepMapper NewInstance()
		{
			vtkUnstructuredGridVolumeZSweepMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_NewInstance_33(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridVolumeZSweepMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600AAE4 RID: 43748
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridVolumeZSweepMapper_Render_34(HandleRef pThis, HandleRef ren, HandleRef vol);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
		/// Render the volume
		/// </summary>
		// Token: 0x0600AAE5 RID: 43749 RVA: 0x000F2D90 File Offset: 0x000F0F90
		public override void Render(vtkRenderer ren, vtkVolume vol)
		{
			vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_Render_34(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis());
		}

		// Token: 0x0600AAE6 RID: 43750
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridVolumeZSweepMapper_SafeDownCast_35(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AAE7 RID: 43751 RVA: 0x000F2DD4 File Offset: 0x000F0FD4
		public new static vtkUnstructuredGridVolumeZSweepMapper SafeDownCast(vtkObjectBase o)
		{
			vtkUnstructuredGridVolumeZSweepMapper vtkUnstructuredGridVolumeZSweepMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_SafeDownCast_35((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGridVolumeZSweepMapper = (vtkUnstructuredGridVolumeZSweepMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGridVolumeZSweepMapper.Register(null);
				}
			}
			return vtkUnstructuredGridVolumeZSweepMapper;
		}

		// Token: 0x0600AAE8 RID: 43752
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridVolumeZSweepMapper_SetAutoAdjustSampleDistances_36(HandleRef pThis, int _arg);

		/// <summary>
		/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
		/// will be varied to achieve the allocated render time of this
		/// prop (controlled by the desired update rate and any culling in
		/// use).
		/// </summary>
		// Token: 0x0600AAE9 RID: 43753 RVA: 0x000F2E53 File Offset: 0x000F1053
		public virtual void SetAutoAdjustSampleDistances(int _arg)
		{
			vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_SetAutoAdjustSampleDistances_36(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AAEA RID: 43754
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridVolumeZSweepMapper_SetImageSampleDistance_37(HandleRef pThis, float _arg);

		/// <summary>
		/// Sampling distance in the XY image dimensions. Default value of 1 meaning
		/// 1 ray cast per pixel. If set to 0.5, 4 rays will be cast per pixel. If
		/// set to 2.0, 1 ray will be cast for every 4 (2 by 2) pixels.
		/// </summary>
		// Token: 0x0600AAEB RID: 43755 RVA: 0x000F2E63 File Offset: 0x000F1063
		public virtual void SetImageSampleDistance(float _arg)
		{
			vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_SetImageSampleDistance_37(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AAEC RID: 43756
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridVolumeZSweepMapper_SetIntermixIntersectingGeometry_38(HandleRef pThis, int _arg);

		/// <summary>
		/// If IntermixIntersectingGeometry is turned on, the zbuffer will be
		/// captured and used to limit the traversal of the rays.
		/// </summary>
		// Token: 0x0600AAED RID: 43757 RVA: 0x000F2E73 File Offset: 0x000F1073
		public virtual void SetIntermixIntersectingGeometry(int _arg)
		{
			vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_SetIntermixIntersectingGeometry_38(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AAEE RID: 43758
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridVolumeZSweepMapper_SetMaxPixelListSize_39(HandleRef pThis, int size);

		/// <summary>
		/// Change the maximum size allowed for a pixel list. It is an advanced
		/// parameter.
		/// \pre positive_size: size&gt;1
		/// </summary>
		// Token: 0x0600AAEF RID: 43759 RVA: 0x000F2E83 File Offset: 0x000F1083
		public void SetMaxPixelListSize(int size)
		{
			vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_SetMaxPixelListSize_39(base.GetCppThis(), size);
		}

		// Token: 0x0600AAF0 RID: 43760
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridVolumeZSweepMapper_SetMaximumImageSampleDistance_40(HandleRef pThis, float _arg);

		/// <summary>
		/// This is the maximum image sample distance allow when the image
		/// sample distance is being automatically adjusted
		/// </summary>
		// Token: 0x0600AAF1 RID: 43761 RVA: 0x000F2E93 File Offset: 0x000F1093
		public virtual void SetMaximumImageSampleDistance(float _arg)
		{
			vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_SetMaximumImageSampleDistance_40(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AAF2 RID: 43762
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridVolumeZSweepMapper_SetMinimumImageSampleDistance_41(HandleRef pThis, float _arg);

		/// <summary>
		/// This is the minimum image sample distance allow when the image
		/// sample distance is being automatically adjusted
		/// </summary>
		// Token: 0x0600AAF3 RID: 43763 RVA: 0x000F2EA3 File Offset: 0x000F10A3
		public virtual void SetMinimumImageSampleDistance(float _arg)
		{
			vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_SetMinimumImageSampleDistance_41(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AAF4 RID: 43764
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridVolumeZSweepMapper_SetRayIntegrator_42(HandleRef pThis, HandleRef ri);

		/// <summary>
		/// Set/Get the helper class for integrating rays.  If set to NULL, a
		/// default integrator will be assigned.
		/// </summary>
		// Token: 0x0600AAF5 RID: 43765 RVA: 0x000F2EB4 File Offset: 0x000F10B4
		public virtual void SetRayIntegrator(vtkUnstructuredGridVolumeRayIntegrator ri)
		{
			vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_SetRayIntegrator_42(base.GetCppThis(), (ri == null) ? default(HandleRef) : ri.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D8B RID: 3467
		public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGridVolumeZSweepMapper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D8C RID: 3468
		public new static readonly string MRClassNameKey = "class vtkUnstructuredGridVolumeZSweepMapper";
	}
}
