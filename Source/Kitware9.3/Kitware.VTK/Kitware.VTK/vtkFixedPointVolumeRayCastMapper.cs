using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkFixedPointVolumeRayCastMapper
	/// </summary>
	/// <remarks>
	///    A fixed point mapper for volumes
	///
	/// This is a software ray caster for rendering volumes in vtkImageData.
	/// It works with all input data types and up to four components. It performs
	/// composite or MIP rendering, and can be intermixed with geometric data.
	/// Space leaping is used to speed up the rendering process. In addition,
	/// calculation are performed in 15 bit fixed point precision. This mapper
	/// is threaded, and will interleave scan lines across processors.
	///
	/// WARNING: This ray caster may not produce consistent results when
	/// the number of threads exceeds 1. The class warns if the number of
	/// threads &gt; 1. The differences may be subtle. Applications should decide
	/// if the trade-off in performance is worth the lack of consistency.
	///
	/// Other limitations of this ray caster include that:
	///   - it does not do isosurface ray casting
	///   - it does only interpolate before classify compositing
	///   - it does only maximum scalar value MIP
	///
	/// This mapper handles all data type from unsigned char through double.
	/// However, some of the internal calcultions are performed in float and
	/// therefore even the full float range may cause problems for this mapper
	/// (both in scalar data values and in spacing between samples).
	///
	/// Space leaping is performed by creating a sub-sampled volume. 4x4x4
	/// cells in the original volume are represented by a min, max, and
	/// combined gradient and flag value. The min max volume has three
	/// unsigned shorts per 4x4x4 group of cells from the original volume -
	/// one representing the minimum scalar index (the scalar value adjusted
	/// to fit in the 15 bit range), the maximum scalar index, and a
	/// third unsigned short which is both the maximum gradient opacity in
	/// the neighborhood (an unsigned char) and the flag that is filled
	/// in for the current lookup tables to indicate whether this region
	/// can be skipped.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkVolumeMapper
	/// </seealso>
	// Token: 0x0200039B RID: 923
	public class vtkFixedPointVolumeRayCastMapper : vtkVolumeMapper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600A78F RID: 42895 RVA: 0x000EDD1B File Offset: 0x000EBF1B
		static vtkFixedPointVolumeRayCastMapper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFixedPointVolumeRayCastMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFixedPointVolumeRayCastMapper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600A790 RID: 42896 RVA: 0x000EDD43 File Offset: 0x000EBF43
		public vtkFixedPointVolumeRayCastMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600A791 RID: 42897
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A792 RID: 42898 RVA: 0x000EDD54 File Offset: 0x000EBF54
		public new static vtkFixedPointVolumeRayCastMapper New()
		{
			vtkFixedPointVolumeRayCastMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFixedPointVolumeRayCastMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A793 RID: 42899 RVA: 0x000EDDA8 File Offset: 0x000EBFA8
		public vtkFixedPointVolumeRayCastMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600A794 RID: 42900 RVA: 0x000EDDEC File Offset: 0x000EBFEC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600A795 RID: 42901
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointVolumeRayCastMapper_AbortRender_01(HandleRef pThis);

		/// <summary>
		/// Set / Get the underlying image object. One will be automatically
		/// created - only need to set it when using from an AMR mapper which
		/// renders multiple times into the same image.
		/// </summary>
		// Token: 0x0600A796 RID: 42902 RVA: 0x000EDDF7 File Offset: 0x000EBFF7
		public void AbortRender()
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_AbortRender_01(base.GetCppThis());
		}

		// Token: 0x0600A797 RID: 42903
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointVolumeRayCastMapper_AutoAdjustSampleDistancesOff_02(HandleRef pThis);

		/// <summary>
		/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
		/// and the SampleDistance will be varied to achieve the allocated
		/// render time of this prop (controlled by the desired update rate
		/// and any culling in use). If this is an interactive render (more
		/// than 1 frame per second) the SampleDistance will be increased,
		/// otherwise it will not be altered (a binary decision, as opposed
		/// to the ImageSampleDistance which will vary continuously).
		/// </summary>
		// Token: 0x0600A798 RID: 42904 RVA: 0x000EDE06 File Offset: 0x000EC006
		public virtual void AutoAdjustSampleDistancesOff()
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_AutoAdjustSampleDistancesOff_02(base.GetCppThis());
		}

		// Token: 0x0600A799 RID: 42905
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointVolumeRayCastMapper_AutoAdjustSampleDistancesOn_03(HandleRef pThis);

		/// <summary>
		/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
		/// and the SampleDistance will be varied to achieve the allocated
		/// render time of this prop (controlled by the desired update rate
		/// and any culling in use). If this is an interactive render (more
		/// than 1 frame per second) the SampleDistance will be increased,
		/// otherwise it will not be altered (a binary decision, as opposed
		/// to the ImageSampleDistance which will vary continuously).
		/// </summary>
		// Token: 0x0600A79A RID: 42906 RVA: 0x000EDE15 File Offset: 0x000EC015
		public virtual void AutoAdjustSampleDistancesOn()
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_AutoAdjustSampleDistancesOn_03(base.GetCppThis());
		}

		// Token: 0x0600A79B RID: 42907
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFixedPointVolumeRayCastMapper_CheckIfCropped_04(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Initialize rendering for this volume.
		/// </summary>
		// Token: 0x0600A79C RID: 42908 RVA: 0x000EDE24 File Offset: 0x000EC024
		public int CheckIfCropped(IntPtr pos)
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_CheckIfCropped_04(base.GetCppThis(), pos);
		}

		// Token: 0x0600A79D RID: 42909
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFixedPointVolumeRayCastMapper_CheckMIPMinMaxVolumeFlag_05(HandleRef pThis, IntPtr pos, int c, ushort maxIdx, int flip);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Initialize rendering for this volume.
		/// </summary>
		// Token: 0x0600A79E RID: 42910 RVA: 0x000EDE44 File Offset: 0x000EC044
		public int CheckMIPMinMaxVolumeFlag(IntPtr pos, int c, ushort maxIdx, int flip)
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_CheckMIPMinMaxVolumeFlag_05(base.GetCppThis(), pos, c, maxIdx, flip);
		}

		// Token: 0x0600A79F RID: 42911
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFixedPointVolumeRayCastMapper_CheckMinMaxVolumeFlag_06(HandleRef pThis, IntPtr pos, int c);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Initialize rendering for this volume.
		/// </summary>
		// Token: 0x0600A7A0 RID: 42912 RVA: 0x000EDE68 File Offset: 0x000EC068
		public int CheckMinMaxVolumeFlag(IntPtr pos, int c)
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_CheckMinMaxVolumeFlag_06(base.GetCppThis(), pos, c);
		}

		// Token: 0x0600A7A1 RID: 42913
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointVolumeRayCastMapper_ComputeRayInfo_07(HandleRef pThis, int x, int y, IntPtr pos, IntPtr dir, IntPtr numSteps);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Initialize rendering for this volume.
		/// </summary>
		// Token: 0x0600A7A2 RID: 42914 RVA: 0x000EDE89 File Offset: 0x000EC089
		public void ComputeRayInfo(int x, int y, IntPtr pos, IntPtr dir, IntPtr numSteps)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_ComputeRayInfo_07(base.GetCppThis(), x, y, pos, dir, numSteps);
		}

		// Token: 0x0600A7A3 RID: 42915
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkFixedPointVolumeRayCastMapper_ComputeRequiredImageSampleDistance_08(HandleRef pThis, float desiredTime, HandleRef ren);

		/// <summary>
		/// What is the image sample distance required to achieve the desired time?
		/// A version of this method is provided that does not require the volume
		/// argument since if you are using an LODProp3D you may not know this information.
		/// If you use this version you must be certain that the ray cast mapper is
		/// only used for one volume (and not shared among multiple volumes)
		/// </summary>
		// Token: 0x0600A7A4 RID: 42916 RVA: 0x000EDEA0 File Offset: 0x000EC0A0
		public float ComputeRequiredImageSampleDistance(float desiredTime, vtkRenderer ren)
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_ComputeRequiredImageSampleDistance_08(base.GetCppThis(), desiredTime, (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		// Token: 0x0600A7A5 RID: 42917
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkFixedPointVolumeRayCastMapper_ComputeRequiredImageSampleDistance_09(HandleRef pThis, float desiredTime, HandleRef ren, HandleRef vol);

		/// <summary>
		/// What is the image sample distance required to achieve the desired time?
		/// A version of this method is provided that does not require the volume
		/// argument since if you are using an LODProp3D you may not know this information.
		/// If you use this version you must be certain that the ray cast mapper is
		/// only used for one volume (and not shared among multiple volumes)
		/// </summary>
		// Token: 0x0600A7A6 RID: 42918 RVA: 0x000EDED8 File Offset: 0x000EC0D8
		public float ComputeRequiredImageSampleDistance(float desiredTime, vtkRenderer ren, vtkVolume vol)
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_ComputeRequiredImageSampleDistance_09(base.GetCppThis(), desiredTime, (ren == null) ? default(HandleRef) : ren.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis());
		}

		// Token: 0x0600A7A7 RID: 42919
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointVolumeRayCastMapper_CreateCanonicalView_10(HandleRef pThis, HandleRef volume, HandleRef image, int blend_mode, IntPtr viewDirection, IntPtr viewUp);

		/// <summary>
		/// Set / Get the underlying image object. One will be automatically
		/// created - only need to set it when using from an AMR mapper which
		/// renders multiple times into the same image.
		/// </summary>
		// Token: 0x0600A7A8 RID: 42920 RVA: 0x000EDF24 File Offset: 0x000EC124
		public void CreateCanonicalView(vtkVolume volume, vtkImageData image, int blend_mode, IntPtr viewDirection, IntPtr viewUp)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_CreateCanonicalView_10(base.GetCppThis(), (volume == null) ? default(HandleRef) : volume.GetCppThis(), (image == null) ? default(HandleRef) : image.GetCppThis(), blend_mode, viewDirection, viewUp);
		}

		// Token: 0x0600A7A9 RID: 42921
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointVolumeRayCastMapper_DisplayRenderedImage_11(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		/// <summary>
		/// Set / Get the underlying image object. One will be automatically
		/// created - only need to set it when using from an AMR mapper which
		/// renders multiple times into the same image.
		/// </summary>
		// Token: 0x0600A7AA RID: 42922 RVA: 0x000EDF70 File Offset: 0x000EC170
		public void DisplayRenderedImage(vtkRenderer arg0, vtkVolume arg1)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_DisplayRenderedImage_11(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x0600A7AB RID: 42923
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointVolumeRayCastMapper_FixedPointIncrement_12(HandleRef pThis, IntPtr position, IntPtr increment);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Initialize rendering for this volume.
		/// </summary>
		// Token: 0x0600A7AC RID: 42924 RVA: 0x000EDFB4 File Offset: 0x000EC1B4
		public void FixedPointIncrement(IntPtr position, IntPtr increment)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_FixedPointIncrement_12(base.GetCppThis(), position, increment);
		}

		// Token: 0x0600A7AD RID: 42925
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFixedPointVolumeRayCastMapper_GetAutoAdjustSampleDistances_13(HandleRef pThis);

		/// <summary>
		/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
		/// and the SampleDistance will be varied to achieve the allocated
		/// render time of this prop (controlled by the desired update rate
		/// and any culling in use). If this is an interactive render (more
		/// than 1 frame per second) the SampleDistance will be increased,
		/// otherwise it will not be altered (a binary decision, as opposed
		/// to the ImageSampleDistance which will vary continuously).
		/// </summary>
		// Token: 0x0600A7AE RID: 42926 RVA: 0x000EDFC8 File Offset: 0x000EC1C8
		public virtual int GetAutoAdjustSampleDistances()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetAutoAdjustSampleDistances_13(base.GetCppThis());
		}

		// Token: 0x0600A7AF RID: 42927
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFixedPointVolumeRayCastMapper_GetAutoAdjustSampleDistancesMaxValue_14(HandleRef pThis);

		/// <summary>
		/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
		/// and the SampleDistance will be varied to achieve the allocated
		/// render time of this prop (controlled by the desired update rate
		/// and any culling in use). If this is an interactive render (more
		/// than 1 frame per second) the SampleDistance will be increased,
		/// otherwise it will not be altered (a binary decision, as opposed
		/// to the ImageSampleDistance which will vary continuously).
		/// </summary>
		// Token: 0x0600A7B0 RID: 42928 RVA: 0x000EDFE8 File Offset: 0x000EC1E8
		public virtual int GetAutoAdjustSampleDistancesMaxValue()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetAutoAdjustSampleDistancesMaxValue_14(base.GetCppThis());
		}

		// Token: 0x0600A7B1 RID: 42929
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFixedPointVolumeRayCastMapper_GetAutoAdjustSampleDistancesMinValue_15(HandleRef pThis);

		/// <summary>
		/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
		/// and the SampleDistance will be varied to achieve the allocated
		/// render time of this prop (controlled by the desired update rate
		/// and any culling in use). If this is an interactive render (more
		/// than 1 frame per second) the SampleDistance will be increased,
		/// otherwise it will not be altered (a binary decision, as opposed
		/// to the ImageSampleDistance which will vary continuously).
		/// </summary>
		// Token: 0x0600A7B2 RID: 42930 RVA: 0x000EE008 File Offset: 0x000EC208
		public virtual int GetAutoAdjustSampleDistancesMinValue()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetAutoAdjustSampleDistancesMinValue_15(base.GetCppThis());
		}

		// Token: 0x0600A7B3 RID: 42931
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetColorTable_16(HandleRef pThis, int c);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Initialize rendering for this volume.
		/// </summary>
		// Token: 0x0600A7B4 RID: 42932 RVA: 0x000EE028 File Offset: 0x000EC228
		public IntPtr GetColorTable(int c)
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetColorTable_16(base.GetCppThis(), c);
		}

		// Token: 0x0600A7B5 RID: 42933
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetCompositeGOHelper_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Initialize rendering for this volume.
		/// </summary>
		// Token: 0x0600A7B6 RID: 42934 RVA: 0x000EE048 File Offset: 0x000EC248
		public virtual vtkFixedPointVolumeRayCastCompositeGOHelper GetCompositeGOHelper()
		{
			vtkFixedPointVolumeRayCastCompositeGOHelper vtkFixedPointVolumeRayCastCompositeGOHelper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetCompositeGOHelper_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFixedPointVolumeRayCastCompositeGOHelper = (vtkFixedPointVolumeRayCastCompositeGOHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFixedPointVolumeRayCastCompositeGOHelper.Register(null);
				}
			}
			return vtkFixedPointVolumeRayCastCompositeGOHelper;
		}

		// Token: 0x0600A7B7 RID: 42935
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetCompositeGOShadeHelper_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Initialize rendering for this volume.
		/// </summary>
		// Token: 0x0600A7B8 RID: 42936 RVA: 0x000EE0B8 File Offset: 0x000EC2B8
		public virtual vtkFixedPointVolumeRayCastCompositeGOShadeHelper GetCompositeGOShadeHelper()
		{
			vtkFixedPointVolumeRayCastCompositeGOShadeHelper vtkFixedPointVolumeRayCastCompositeGOShadeHelper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetCompositeGOShadeHelper_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFixedPointVolumeRayCastCompositeGOShadeHelper = (vtkFixedPointVolumeRayCastCompositeGOShadeHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFixedPointVolumeRayCastCompositeGOShadeHelper.Register(null);
				}
			}
			return vtkFixedPointVolumeRayCastCompositeGOShadeHelper;
		}

		// Token: 0x0600A7B9 RID: 42937
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetCompositeHelper_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Initialize rendering for this volume.
		/// </summary>
		// Token: 0x0600A7BA RID: 42938 RVA: 0x000EE128 File Offset: 0x000EC328
		public virtual vtkFixedPointVolumeRayCastCompositeHelper GetCompositeHelper()
		{
			vtkFixedPointVolumeRayCastCompositeHelper vtkFixedPointVolumeRayCastCompositeHelper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetCompositeHelper_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFixedPointVolumeRayCastCompositeHelper = (vtkFixedPointVolumeRayCastCompositeHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFixedPointVolumeRayCastCompositeHelper.Register(null);
				}
			}
			return vtkFixedPointVolumeRayCastCompositeHelper;
		}

		// Token: 0x0600A7BB RID: 42939
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetCompositeShadeHelper_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Initialize rendering for this volume.
		/// </summary>
		// Token: 0x0600A7BC RID: 42940 RVA: 0x000EE198 File Offset: 0x000EC398
		public virtual vtkFixedPointVolumeRayCastCompositeShadeHelper GetCompositeShadeHelper()
		{
			vtkFixedPointVolumeRayCastCompositeShadeHelper vtkFixedPointVolumeRayCastCompositeShadeHelper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetCompositeShadeHelper_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFixedPointVolumeRayCastCompositeShadeHelper = (vtkFixedPointVolumeRayCastCompositeShadeHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFixedPointVolumeRayCastCompositeShadeHelper.Register(null);
				}
			}
			return vtkFixedPointVolumeRayCastCompositeShadeHelper;
		}

		// Token: 0x0600A7BD RID: 42941
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetCurrentScalars_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Initialize rendering for this volume.
		/// </summary>
		// Token: 0x0600A7BE RID: 42942 RVA: 0x000EE208 File Offset: 0x000EC408
		public virtual vtkDataArray GetCurrentScalars()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetCurrentScalars_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		// Token: 0x0600A7BF RID: 42943
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetDiffuseShadingTable_22(HandleRef pThis, int c);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Initialize rendering for this volume.
		/// </summary>
		// Token: 0x0600A7C0 RID: 42944 RVA: 0x000EE278 File Offset: 0x000EC478
		public IntPtr GetDiffuseShadingTable(int c)
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetDiffuseShadingTable_22(base.GetCppThis(), c);
		}

		// Token: 0x0600A7C1 RID: 42945
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkFixedPointVolumeRayCastMapper_GetEstimatedRenderTime_23(HandleRef pThis, HandleRef ren, HandleRef vol);

		/// <summary>
		/// Get an estimate of the rendering time for a given volume / renderer.
		/// Only valid if this mapper has been used to render that volume for
		/// that renderer previously. Estimate is good when the viewing parameters
		/// have not changed much since that last render.
		/// </summary>
		// Token: 0x0600A7C2 RID: 42946 RVA: 0x000EE298 File Offset: 0x000EC498
		public float GetEstimatedRenderTime(vtkRenderer ren, vtkVolume vol)
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetEstimatedRenderTime_23(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis());
		}

		// Token: 0x0600A7C3 RID: 42947
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkFixedPointVolumeRayCastMapper_GetEstimatedRenderTime_24(HandleRef pThis, HandleRef ren);

		/// <summary>
		/// Get an estimate of the rendering time for a given volume / renderer.
		/// Only valid if this mapper has been used to render that volume for
		/// that renderer previously. Estimate is good when the viewing parameters
		/// have not changed much since that last render.
		/// </summary>
		// Token: 0x0600A7C4 RID: 42948 RVA: 0x000EE2E4 File Offset: 0x000EC4E4
		public float GetEstimatedRenderTime(vtkRenderer ren)
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetEstimatedRenderTime_24(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		// Token: 0x0600A7C5 RID: 42949
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkFixedPointVolumeRayCastMapper_GetFinalColorLevel_25(HandleRef pThis);

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
		// Token: 0x0600A7C6 RID: 42950 RVA: 0x000EE318 File Offset: 0x000EC518
		public virtual float GetFinalColorLevel()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetFinalColorLevel_25(base.GetCppThis());
		}

		// Token: 0x0600A7C7 RID: 42951
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkFixedPointVolumeRayCastMapper_GetFinalColorWindow_26(HandleRef pThis);

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
		// Token: 0x0600A7C8 RID: 42952 RVA: 0x000EE338 File Offset: 0x000EC538
		public virtual float GetFinalColorWindow()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetFinalColorWindow_26(base.GetCppThis());
		}

		// Token: 0x0600A7C9 RID: 42953
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFixedPointVolumeRayCastMapper_GetFlipMIPComparison_27(HandleRef pThis);

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
		// Token: 0x0600A7CA RID: 42954 RVA: 0x000EE358 File Offset: 0x000EC558
		public virtual int GetFlipMIPComparison()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetFlipMIPComparison_27(base.GetCppThis());
		}

		// Token: 0x0600A7CB RID: 42955
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointVolumeRayCastMapper_GetFloatTripleFromPointer_28(HandleRef pThis, IntPtr v, IntPtr ptr);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Initialize rendering for this volume.
		/// </summary>
		// Token: 0x0600A7CC RID: 42956 RVA: 0x000EE377 File Offset: 0x000EC577
		public void GetFloatTripleFromPointer(IntPtr v, IntPtr ptr)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetFloatTripleFromPointer_28(base.GetCppThis(), v, ptr);
		}

		// Token: 0x0600A7CD RID: 42957
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFixedPointVolumeRayCastMapper_GetGradientOpacityRequired_29(HandleRef pThis);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Initialize rendering for this volume.
		/// </summary>
		// Token: 0x0600A7CE RID: 42958 RVA: 0x000EE388 File Offset: 0x000EC588
		public virtual int GetGradientOpacityRequired()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetGradientOpacityRequired_29(base.GetCppThis());
		}

		// Token: 0x0600A7CF RID: 42959
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetGradientOpacityTable_30(HandleRef pThis, int c);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Initialize rendering for this volume.
		/// </summary>
		// Token: 0x0600A7D0 RID: 42960 RVA: 0x000EE3A8 File Offset: 0x000EC5A8
		public IntPtr GetGradientOpacityTable(int c)
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetGradientOpacityTable_30(base.GetCppThis(), c);
		}

		// Token: 0x0600A7D1 RID: 42961
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkFixedPointVolumeRayCastMapper_GetImageSampleDistance_31(HandleRef pThis);

		/// <summary>
		/// Sampling distance in the XY image dimensions. Default value of 1 meaning
		/// 1 ray cast per pixel. If set to 0.5, 4 rays will be cast per pixel. If
		/// set to 2.0, 1 ray will be cast for every 4 (2 by 2) pixels. This value
		/// will be adjusted to meet a desired frame rate when AutoAdjustSampleDistances
		/// is on.
		/// </summary>
		// Token: 0x0600A7D2 RID: 42962 RVA: 0x000EE3C8 File Offset: 0x000EC5C8
		public virtual float GetImageSampleDistance()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetImageSampleDistance_31(base.GetCppThis());
		}

		// Token: 0x0600A7D3 RID: 42963
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkFixedPointVolumeRayCastMapper_GetImageSampleDistanceMaxValue_32(HandleRef pThis);

		/// <summary>
		/// Sampling distance in the XY image dimensions. Default value of 1 meaning
		/// 1 ray cast per pixel. If set to 0.5, 4 rays will be cast per pixel. If
		/// set to 2.0, 1 ray will be cast for every 4 (2 by 2) pixels. This value
		/// will be adjusted to meet a desired frame rate when AutoAdjustSampleDistances
		/// is on.
		/// </summary>
		// Token: 0x0600A7D4 RID: 42964 RVA: 0x000EE3E8 File Offset: 0x000EC5E8
		public virtual float GetImageSampleDistanceMaxValue()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetImageSampleDistanceMaxValue_32(base.GetCppThis());
		}

		// Token: 0x0600A7D5 RID: 42965
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkFixedPointVolumeRayCastMapper_GetImageSampleDistanceMinValue_33(HandleRef pThis);

		/// <summary>
		/// Sampling distance in the XY image dimensions. Default value of 1 meaning
		/// 1 ray cast per pixel. If set to 0.5, 4 rays will be cast per pixel. If
		/// set to 2.0, 1 ray will be cast for every 4 (2 by 2) pixels. This value
		/// will be adjusted to meet a desired frame rate when AutoAdjustSampleDistances
		/// is on.
		/// </summary>
		// Token: 0x0600A7D6 RID: 42966 RVA: 0x000EE408 File Offset: 0x000EC608
		public virtual float GetImageSampleDistanceMinValue()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetImageSampleDistanceMinValue_33(base.GetCppThis());
		}

		// Token: 0x0600A7D7 RID: 42967
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkFixedPointVolumeRayCastMapper_GetInteractiveSampleDistance_34(HandleRef pThis);

		/// <summary>
		/// Set/Get the distance between samples when interactive rendering is happening.
		/// In this case, interactive is defined as this volume mapper having less than 1
		/// second allocated for rendering. When AutoAdjustSampleDistance is On, and the
		/// allocated render time is less than 1 second, then this InteractiveSampleDistance
		/// will be used instead of the SampleDistance above.
		/// </summary>
		// Token: 0x0600A7D8 RID: 42968 RVA: 0x000EE428 File Offset: 0x000EC628
		public virtual float GetInteractiveSampleDistance()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetInteractiveSampleDistance_34(base.GetCppThis());
		}

		// Token: 0x0600A7D9 RID: 42969
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFixedPointVolumeRayCastMapper_GetIntermixIntersectingGeometry_35(HandleRef pThis);

		/// <summary>
		/// If IntermixIntersectingGeometry is turned on, the zbuffer will be
		/// captured and used to limit the traversal of the rays.
		/// </summary>
		// Token: 0x0600A7DA RID: 42970 RVA: 0x000EE448 File Offset: 0x000EC648
		public virtual int GetIntermixIntersectingGeometry()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetIntermixIntersectingGeometry_35(base.GetCppThis());
		}

		// Token: 0x0600A7DB RID: 42971
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFixedPointVolumeRayCastMapper_GetIntermixIntersectingGeometryMaxValue_36(HandleRef pThis);

		/// <summary>
		/// If IntermixIntersectingGeometry is turned on, the zbuffer will be
		/// captured and used to limit the traversal of the rays.
		/// </summary>
		// Token: 0x0600A7DC RID: 42972 RVA: 0x000EE468 File Offset: 0x000EC668
		public virtual int GetIntermixIntersectingGeometryMaxValue()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetIntermixIntersectingGeometryMaxValue_36(base.GetCppThis());
		}

		// Token: 0x0600A7DD RID: 42973
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFixedPointVolumeRayCastMapper_GetIntermixIntersectingGeometryMinValue_37(HandleRef pThis);

		/// <summary>
		/// If IntermixIntersectingGeometry is turned on, the zbuffer will be
		/// captured and used to limit the traversal of the rays.
		/// </summary>
		// Token: 0x0600A7DE RID: 42974 RVA: 0x000EE488 File Offset: 0x000EC688
		public virtual int GetIntermixIntersectingGeometryMinValue()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetIntermixIntersectingGeometryMinValue_37(base.GetCppThis());
		}

		// Token: 0x0600A7DF RID: 42975
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFixedPointVolumeRayCastMapper_GetLockSampleDistanceToInputSpacing_38(HandleRef pThis);

		/// <summary>
		/// Automatically compute the sample distance from the data spacing.  When
		/// the number of voxels is 8, the sample distance will be roughly 1/200
		/// the average voxel size. The distance will grow proportionally to
		/// numVoxels^(1/3) until it reaches 1/2 average voxel size when number of
		/// voxels is 1E6. Note that ScalarOpacityUnitDistance is still taken into
		/// account and if different than 1, will effect the sample distance.
		/// </summary>
		// Token: 0x0600A7E0 RID: 42976 RVA: 0x000EE4A8 File Offset: 0x000EC6A8
		public virtual int GetLockSampleDistanceToInputSpacing()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetLockSampleDistanceToInputSpacing_38(base.GetCppThis());
		}

		// Token: 0x0600A7E1 RID: 42977
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFixedPointVolumeRayCastMapper_GetLockSampleDistanceToInputSpacingMaxValue_39(HandleRef pThis);

		/// <summary>
		/// Automatically compute the sample distance from the data spacing.  When
		/// the number of voxels is 8, the sample distance will be roughly 1/200
		/// the average voxel size. The distance will grow proportionally to
		/// numVoxels^(1/3) until it reaches 1/2 average voxel size when number of
		/// voxels is 1E6. Note that ScalarOpacityUnitDistance is still taken into
		/// account and if different than 1, will effect the sample distance.
		/// </summary>
		// Token: 0x0600A7E2 RID: 42978 RVA: 0x000EE4C8 File Offset: 0x000EC6C8
		public virtual int GetLockSampleDistanceToInputSpacingMaxValue()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetLockSampleDistanceToInputSpacingMaxValue_39(base.GetCppThis());
		}

		// Token: 0x0600A7E3 RID: 42979
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFixedPointVolumeRayCastMapper_GetLockSampleDistanceToInputSpacingMinValue_40(HandleRef pThis);

		/// <summary>
		/// Automatically compute the sample distance from the data spacing.  When
		/// the number of voxels is 8, the sample distance will be roughly 1/200
		/// the average voxel size. The distance will grow proportionally to
		/// numVoxels^(1/3) until it reaches 1/2 average voxel size when number of
		/// voxels is 1E6. Note that ScalarOpacityUnitDistance is still taken into
		/// account and if different than 1, will effect the sample distance.
		/// </summary>
		// Token: 0x0600A7E4 RID: 42980 RVA: 0x000EE4E8 File Offset: 0x000EC6E8
		public virtual int GetLockSampleDistanceToInputSpacingMinValue()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetLockSampleDistanceToInputSpacingMinValue_40(base.GetCppThis());
		}

		// Token: 0x0600A7E5 RID: 42981
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetMIPHelper_41(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Initialize rendering for this volume.
		/// </summary>
		// Token: 0x0600A7E6 RID: 42982 RVA: 0x000EE508 File Offset: 0x000EC708
		public virtual vtkFixedPointVolumeRayCastMIPHelper GetMIPHelper()
		{
			vtkFixedPointVolumeRayCastMIPHelper vtkFixedPointVolumeRayCastMIPHelper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetMIPHelper_41(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFixedPointVolumeRayCastMIPHelper = (vtkFixedPointVolumeRayCastMIPHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFixedPointVolumeRayCastMIPHelper.Register(null);
				}
			}
			return vtkFixedPointVolumeRayCastMIPHelper;
		}

		// Token: 0x0600A7E7 RID: 42983
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkFixedPointVolumeRayCastMapper_GetMaximumImageSampleDistance_42(HandleRef pThis);

		/// <summary>
		/// This is the maximum image sample distance allow when the image
		/// sample distance is being automatically adjusted.
		/// </summary>
		// Token: 0x0600A7E8 RID: 42984 RVA: 0x000EE578 File Offset: 0x000EC778
		public virtual float GetMaximumImageSampleDistance()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetMaximumImageSampleDistance_42(base.GetCppThis());
		}

		// Token: 0x0600A7E9 RID: 42985
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkFixedPointVolumeRayCastMapper_GetMaximumImageSampleDistanceMaxValue_43(HandleRef pThis);

		/// <summary>
		/// This is the maximum image sample distance allow when the image
		/// sample distance is being automatically adjusted.
		/// </summary>
		// Token: 0x0600A7EA RID: 42986 RVA: 0x000EE598 File Offset: 0x000EC798
		public virtual float GetMaximumImageSampleDistanceMaxValue()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetMaximumImageSampleDistanceMaxValue_43(base.GetCppThis());
		}

		// Token: 0x0600A7EB RID: 42987
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkFixedPointVolumeRayCastMapper_GetMaximumImageSampleDistanceMinValue_44(HandleRef pThis);

		/// <summary>
		/// This is the maximum image sample distance allow when the image
		/// sample distance is being automatically adjusted.
		/// </summary>
		// Token: 0x0600A7EC RID: 42988 RVA: 0x000EE5B8 File Offset: 0x000EC7B8
		public virtual float GetMaximumImageSampleDistanceMinValue()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetMaximumImageSampleDistanceMinValue_44(base.GetCppThis());
		}

		// Token: 0x0600A7ED RID: 42989
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkFixedPointVolumeRayCastMapper_GetMinimumImageSampleDistance_45(HandleRef pThis);

		/// <summary>
		/// This is the minimum image sample distance allow when the image
		/// sample distance is being automatically adjusted.
		/// </summary>
		// Token: 0x0600A7EE RID: 42990 RVA: 0x000EE5D8 File Offset: 0x000EC7D8
		public virtual float GetMinimumImageSampleDistance()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetMinimumImageSampleDistance_45(base.GetCppThis());
		}

		// Token: 0x0600A7EF RID: 42991
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkFixedPointVolumeRayCastMapper_GetMinimumImageSampleDistanceMaxValue_46(HandleRef pThis);

		/// <summary>
		/// This is the minimum image sample distance allow when the image
		/// sample distance is being automatically adjusted.
		/// </summary>
		// Token: 0x0600A7F0 RID: 42992 RVA: 0x000EE5F8 File Offset: 0x000EC7F8
		public virtual float GetMinimumImageSampleDistanceMaxValue()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetMinimumImageSampleDistanceMaxValue_46(base.GetCppThis());
		}

		// Token: 0x0600A7F1 RID: 42993
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkFixedPointVolumeRayCastMapper_GetMinimumImageSampleDistanceMinValue_47(HandleRef pThis);

		/// <summary>
		/// This is the minimum image sample distance allow when the image
		/// sample distance is being automatically adjusted.
		/// </summary>
		// Token: 0x0600A7F2 RID: 42994 RVA: 0x000EE618 File Offset: 0x000EC818
		public virtual float GetMinimumImageSampleDistanceMinValue()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetMinimumImageSampleDistanceMinValue_47(base.GetCppThis());
		}

		// Token: 0x0600A7F3 RID: 42995
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFixedPointVolumeRayCastMapper_GetNumberOfGenerationsFromBase_48(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A7F4 RID: 42996 RVA: 0x000EE638 File Offset: 0x000EC838
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetNumberOfGenerationsFromBase_48(base.GetCppThis(), type);
		}

		// Token: 0x0600A7F5 RID: 42997
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFixedPointVolumeRayCastMapper_GetNumberOfGenerationsFromBaseType_49([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A7F6 RID: 42998 RVA: 0x000EE658 File Offset: 0x000EC858
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetNumberOfGenerationsFromBaseType_49(type);
		}

		// Token: 0x0600A7F7 RID: 42999
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFixedPointVolumeRayCastMapper_GetNumberOfThreads_50(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of threads to use. This by default is equal to
		/// the number of available processors detected.
		/// WARNING: If number of threads &gt; 1, results may not be consistent.
		/// </summary>
		// Token: 0x0600A7F8 RID: 43000 RVA: 0x000EE674 File Offset: 0x000EC874
		public int GetNumberOfThreads()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetNumberOfThreads_50(base.GetCppThis());
		}

		// Token: 0x0600A7F9 RID: 43001
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetPreviousScalars_51(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Initialize rendering for this volume.
		/// </summary>
		// Token: 0x0600A7FA RID: 43002 RVA: 0x000EE694 File Offset: 0x000EC894
		public virtual vtkDataArray GetPreviousScalars()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetPreviousScalars_51(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		// Token: 0x0600A7FB RID: 43003
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetRayCastImage_52(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set / Get the underlying image object. One will be automatically
		/// created - only need to set it when using from an AMR mapper which
		/// renders multiple times into the same image.
		/// </summary>
		// Token: 0x0600A7FC RID: 43004 RVA: 0x000EE704 File Offset: 0x000EC904
		public virtual vtkFixedPointRayCastImage GetRayCastImage()
		{
			vtkFixedPointRayCastImage vtkFixedPointRayCastImage = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetRayCastImage_52(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFixedPointRayCastImage = (vtkFixedPointRayCastImage)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFixedPointRayCastImage.Register(null);
				}
			}
			return vtkFixedPointRayCastImage;
		}

		// Token: 0x0600A7FD RID: 43005
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetRenderWindow_53(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Initialize rendering for this volume.
		/// </summary>
		// Token: 0x0600A7FE RID: 43006 RVA: 0x000EE774 File Offset: 0x000EC974
		public virtual vtkRenderWindow GetRenderWindow()
		{
			vtkRenderWindow vtkRenderWindow = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetRenderWindow_53(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderWindow = (vtkRenderWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderWindow.Register(null);
				}
			}
			return vtkRenderWindow;
		}

		// Token: 0x0600A7FF RID: 43007
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetRowBounds_54(HandleRef pThis);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Initialize rendering for this volume.
		/// </summary>
		// Token: 0x0600A800 RID: 43008 RVA: 0x000EE7E4 File Offset: 0x000EC9E4
		public IntPtr GetRowBounds()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetRowBounds_54(base.GetCppThis());
		}

		// Token: 0x0600A801 RID: 43009
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkFixedPointVolumeRayCastMapper_GetSampleDistance_55(HandleRef pThis);

		/// <summary>
		/// Set/Get the distance between samples used for rendering
		/// when AutoAdjustSampleDistances is off, or when this mapper
		/// has more than 1 second allocated to it for rendering.
		/// </summary>
		// Token: 0x0600A802 RID: 43010 RVA: 0x000EE804 File Offset: 0x000ECA04
		public virtual float GetSampleDistance()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetSampleDistance_55(base.GetCppThis());
		}

		// Token: 0x0600A803 RID: 43011
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetScalarOpacityTable_56(HandleRef pThis, int c);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Initialize rendering for this volume.
		/// </summary>
		// Token: 0x0600A804 RID: 43012 RVA: 0x000EE824 File Offset: 0x000ECA24
		public IntPtr GetScalarOpacityTable(int c)
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetScalarOpacityTable_56(base.GetCppThis(), c);
		}

		// Token: 0x0600A805 RID: 43013
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFixedPointVolumeRayCastMapper_GetShadingRequired_57(HandleRef pThis);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Initialize rendering for this volume.
		/// </summary>
		// Token: 0x0600A806 RID: 43014 RVA: 0x000EE844 File Offset: 0x000ECA44
		public virtual int GetShadingRequired()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetShadingRequired_57(base.GetCppThis());
		}

		// Token: 0x0600A807 RID: 43015
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetSpecularShadingTable_58(HandleRef pThis, int c);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Initialize rendering for this volume.
		/// </summary>
		// Token: 0x0600A808 RID: 43016 RVA: 0x000EE864 File Offset: 0x000ECA64
		public IntPtr GetSpecularShadingTable(int c)
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetSpecularShadingTable_58(base.GetCppThis(), c);
		}

		// Token: 0x0600A809 RID: 43017
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetTableScale_59(HandleRef pThis);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Initialize rendering for this volume.
		/// </summary>
		// Token: 0x0600A80A RID: 43018 RVA: 0x000EE884 File Offset: 0x000ECA84
		public virtual float[] GetTableScale()
		{
			IntPtr intPtr = vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetTableScale_59(base.GetCppThis());
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600A80B RID: 43019
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointVolumeRayCastMapper_GetTableScale_60(HandleRef pThis, IntPtr data);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Initialize rendering for this volume.
		/// </summary>
		// Token: 0x0600A80C RID: 43020 RVA: 0x000EE8CC File Offset: 0x000ECACC
		public virtual void GetTableScale(IntPtr data)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetTableScale_60(base.GetCppThis(), data);
		}

		// Token: 0x0600A80D RID: 43021
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetTableShift_61(HandleRef pThis);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Initialize rendering for this volume.
		/// </summary>
		// Token: 0x0600A80E RID: 43022 RVA: 0x000EE8DC File Offset: 0x000ECADC
		public virtual float[] GetTableShift()
		{
			IntPtr intPtr = vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetTableShift_61(base.GetCppThis());
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600A80F RID: 43023
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointVolumeRayCastMapper_GetTableShift_62(HandleRef pThis, IntPtr data);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Initialize rendering for this volume.
		/// </summary>
		// Token: 0x0600A810 RID: 43024 RVA: 0x000EE924 File Offset: 0x000ECB24
		public virtual void GetTableShift(IntPtr data)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetTableShift_62(base.GetCppThis(), data);
		}

		// Token: 0x0600A811 RID: 43025
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointVolumeRayCastMapper_GetUIntTripleFromPointer_63(HandleRef pThis, IntPtr v, IntPtr ptr);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Initialize rendering for this volume.
		/// </summary>
		// Token: 0x0600A812 RID: 43026 RVA: 0x000EE934 File Offset: 0x000ECB34
		public void GetUIntTripleFromPointer(IntPtr v, IntPtr ptr)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetUIntTripleFromPointer_63(base.GetCppThis(), v, ptr);
		}

		// Token: 0x0600A813 RID: 43027
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetVolume_64(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Initialize rendering for this volume.
		/// </summary>
		// Token: 0x0600A814 RID: 43028 RVA: 0x000EE948 File Offset: 0x000ECB48
		public vtkVolume GetVolume()
		{
			vtkVolume vtkVolume = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetVolume_64(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVolume = (vtkVolume)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVolume.Register(null);
				}
			}
			return vtkVolume;
		}

		// Token: 0x0600A815 RID: 43029
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointVolumeRayCastMapper_InitializeRayInfo_65(HandleRef pThis, HandleRef vol);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Initialize rendering for this volume.
		/// </summary>
		// Token: 0x0600A816 RID: 43030 RVA: 0x000EE9B8 File Offset: 0x000ECBB8
		public void InitializeRayInfo(vtkVolume vol)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_InitializeRayInfo_65(base.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis());
		}

		// Token: 0x0600A817 RID: 43031
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointVolumeRayCastMapper_IntermixIntersectingGeometryOff_66(HandleRef pThis);

		/// <summary>
		/// If IntermixIntersectingGeometry is turned on, the zbuffer will be
		/// captured and used to limit the traversal of the rays.
		/// </summary>
		// Token: 0x0600A818 RID: 43032 RVA: 0x000EE9E7 File Offset: 0x000ECBE7
		public virtual void IntermixIntersectingGeometryOff()
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_IntermixIntersectingGeometryOff_66(base.GetCppThis());
		}

		// Token: 0x0600A819 RID: 43033
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointVolumeRayCastMapper_IntermixIntersectingGeometryOn_67(HandleRef pThis);

		/// <summary>
		/// If IntermixIntersectingGeometry is turned on, the zbuffer will be
		/// captured and used to limit the traversal of the rays.
		/// </summary>
		// Token: 0x0600A81A RID: 43034 RVA: 0x000EE9F6 File Offset: 0x000ECBF6
		public virtual void IntermixIntersectingGeometryOn()
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_IntermixIntersectingGeometryOn_67(base.GetCppThis());
		}

		// Token: 0x0600A81B RID: 43035
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFixedPointVolumeRayCastMapper_IsA_68(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A81C RID: 43036 RVA: 0x000EEA08 File Offset: 0x000ECC08
		public override int IsA(string type)
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_IsA_68(base.GetCppThis(), type);
		}

		// Token: 0x0600A81D RID: 43037
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFixedPointVolumeRayCastMapper_IsTypeOf_69([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A81E RID: 43038 RVA: 0x000EEA28 File Offset: 0x000ECC28
		public new static int IsTypeOf(string type)
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_IsTypeOf_69(type);
		}

		// Token: 0x0600A81F RID: 43039
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointVolumeRayCastMapper_LockSampleDistanceToInputSpacingOff_70(HandleRef pThis);

		/// <summary>
		/// Automatically compute the sample distance from the data spacing.  When
		/// the number of voxels is 8, the sample distance will be roughly 1/200
		/// the average voxel size. The distance will grow proportionally to
		/// numVoxels^(1/3) until it reaches 1/2 average voxel size when number of
		/// voxels is 1E6. Note that ScalarOpacityUnitDistance is still taken into
		/// account and if different than 1, will effect the sample distance.
		/// </summary>
		// Token: 0x0600A820 RID: 43040 RVA: 0x000EEA42 File Offset: 0x000ECC42
		public virtual void LockSampleDistanceToInputSpacingOff()
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_LockSampleDistanceToInputSpacingOff_70(base.GetCppThis());
		}

		// Token: 0x0600A821 RID: 43041
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointVolumeRayCastMapper_LockSampleDistanceToInputSpacingOn_71(HandleRef pThis);

		/// <summary>
		/// Automatically compute the sample distance from the data spacing.  When
		/// the number of voxels is 8, the sample distance will be roughly 1/200
		/// the average voxel size. The distance will grow proportionally to
		/// numVoxels^(1/3) until it reaches 1/2 average voxel size when number of
		/// voxels is 1E6. Note that ScalarOpacityUnitDistance is still taken into
		/// account and if different than 1, will effect the sample distance.
		/// </summary>
		// Token: 0x0600A822 RID: 43042 RVA: 0x000EEA51 File Offset: 0x000ECC51
		public virtual void LockSampleDistanceToInputSpacingOn()
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_LockSampleDistanceToInputSpacingOn_71(base.GetCppThis());
		}

		// Token: 0x0600A823 RID: 43043
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointVolumeRayCastMapper_LookupColorUC_72(HandleRef pThis, IntPtr colorTable, IntPtr scalarOpacityTable, ushort index, IntPtr color);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Initialize rendering for this volume.
		/// </summary>
		// Token: 0x0600A824 RID: 43044 RVA: 0x000EEA60 File Offset: 0x000ECC60
		public void LookupColorUC(IntPtr colorTable, IntPtr scalarOpacityTable, ushort index, IntPtr color)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_LookupColorUC_72(base.GetCppThis(), colorTable, scalarOpacityTable, index, color);
		}

		// Token: 0x0600A825 RID: 43045
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointVolumeRayCastMapper_LookupDependentColorUC_73(HandleRef pThis, IntPtr colorTable, IntPtr scalarOpacityTable, IntPtr index, int components, IntPtr color);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Initialize rendering for this volume.
		/// </summary>
		// Token: 0x0600A826 RID: 43046 RVA: 0x000EEA74 File Offset: 0x000ECC74
		public void LookupDependentColorUC(IntPtr colorTable, IntPtr scalarOpacityTable, IntPtr index, int components, IntPtr color)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_LookupDependentColorUC_73(base.GetCppThis(), colorTable, scalarOpacityTable, index, components, color);
		}

		// Token: 0x0600A827 RID: 43047
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_NewInstance_75(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A828 RID: 43048 RVA: 0x000EEA8C File Offset: 0x000ECC8C
		public new vtkFixedPointVolumeRayCastMapper NewInstance()
		{
			vtkFixedPointVolumeRayCastMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_NewInstance_75(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFixedPointVolumeRayCastMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600A829 RID: 43049
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFixedPointVolumeRayCastMapper_PerImageInitialization_76(HandleRef pThis, HandleRef arg0, HandleRef arg1, int arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);

		/// <summary>
		/// Set / Get the underlying image object. One will be automatically
		/// created - only need to set it when using from an AMR mapper which
		/// renders multiple times into the same image.
		/// </summary>
		// Token: 0x0600A82A RID: 43050 RVA: 0x000EEAE8 File Offset: 0x000ECCE8
		public int PerImageInitialization(vtkRenderer arg0, vtkVolume arg1, int arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5)
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_PerImageInitialization_76(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis(), arg2, arg3, arg4, arg5);
		}

		// Token: 0x0600A82B RID: 43051
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointVolumeRayCastMapper_PerSubVolumeInitialization_77(HandleRef pThis, HandleRef arg0, HandleRef arg1, int arg2);

		/// <summary>
		/// Set / Get the underlying image object. One will be automatically
		/// created - only need to set it when using from an AMR mapper which
		/// renders multiple times into the same image.
		/// </summary>
		// Token: 0x0600A82C RID: 43052 RVA: 0x000EEB38 File Offset: 0x000ECD38
		public void PerSubVolumeInitialization(vtkRenderer arg0, vtkVolume arg1, int arg2)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_PerSubVolumeInitialization_77(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis(), arg2);
		}

		// Token: 0x0600A82D RID: 43053
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointVolumeRayCastMapper_PerVolumeInitialization_78(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		/// <summary>
		/// Set / Get the underlying image object. One will be automatically
		/// created - only need to set it when using from an AMR mapper which
		/// renders multiple times into the same image.
		/// </summary>
		// Token: 0x0600A82E RID: 43054 RVA: 0x000EEB80 File Offset: 0x000ECD80
		public void PerVolumeInitialization(vtkRenderer arg0, vtkVolume arg1)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_PerVolumeInitialization_78(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x0600A82F RID: 43055
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointVolumeRayCastMapper_ReleaseGraphicsResources_79(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Release any graphics resources that are being consumed by this mapper.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x0600A830 RID: 43056 RVA: 0x000EEBC4 File Offset: 0x000ECDC4
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_ReleaseGraphicsResources_79(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600A831 RID: 43057
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointVolumeRayCastMapper_Render_80(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Initialize rendering for this volume.
		/// </summary>
		// Token: 0x0600A832 RID: 43058 RVA: 0x000EEBF4 File Offset: 0x000ECDF4
		public override void Render(vtkRenderer arg0, vtkVolume arg1)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_Render_80(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x0600A833 RID: 43059
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointVolumeRayCastMapper_RenderSubVolume_81(HandleRef pThis);

		/// <summary>
		/// Set / Get the underlying image object. One will be automatically
		/// created - only need to set it when using from an AMR mapper which
		/// renders multiple times into the same image.
		/// </summary>
		// Token: 0x0600A834 RID: 43060 RVA: 0x000EEC38 File Offset: 0x000ECE38
		public void RenderSubVolume()
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_RenderSubVolume_81(base.GetCppThis());
		}

		// Token: 0x0600A835 RID: 43061
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_SafeDownCast_82(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A836 RID: 43062 RVA: 0x000EEC48 File Offset: 0x000ECE48
		public new static vtkFixedPointVolumeRayCastMapper SafeDownCast(vtkObjectBase o)
		{
			vtkFixedPointVolumeRayCastMapper vtkFixedPointVolumeRayCastMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_SafeDownCast_82((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFixedPointVolumeRayCastMapper = (vtkFixedPointVolumeRayCastMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFixedPointVolumeRayCastMapper.Register(null);
				}
			}
			return vtkFixedPointVolumeRayCastMapper;
		}

		// Token: 0x0600A837 RID: 43063
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointVolumeRayCastMapper_SetAutoAdjustSampleDistances_83(HandleRef pThis, int _arg);

		/// <summary>
		/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
		/// and the SampleDistance will be varied to achieve the allocated
		/// render time of this prop (controlled by the desired update rate
		/// and any culling in use). If this is an interactive render (more
		/// than 1 frame per second) the SampleDistance will be increased,
		/// otherwise it will not be altered (a binary decision, as opposed
		/// to the ImageSampleDistance which will vary continuously).
		/// </summary>
		// Token: 0x0600A838 RID: 43064 RVA: 0x000EECC7 File Offset: 0x000ECEC7
		public virtual void SetAutoAdjustSampleDistances(int _arg)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_SetAutoAdjustSampleDistances_83(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A839 RID: 43065
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointVolumeRayCastMapper_SetFinalColorLevel_84(HandleRef pThis, float _arg);

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
		// Token: 0x0600A83A RID: 43066 RVA: 0x000EECD7 File Offset: 0x000ECED7
		public virtual void SetFinalColorLevel(float _arg)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_SetFinalColorLevel_84(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A83B RID: 43067
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointVolumeRayCastMapper_SetFinalColorWindow_85(HandleRef pThis, float _arg);

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
		// Token: 0x0600A83C RID: 43068 RVA: 0x000EECE7 File Offset: 0x000ECEE7
		public virtual void SetFinalColorWindow(float _arg)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_SetFinalColorWindow_85(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A83D RID: 43069
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointVolumeRayCastMapper_SetImageSampleDistance_86(HandleRef pThis, float _arg);

		/// <summary>
		/// Sampling distance in the XY image dimensions. Default value of 1 meaning
		/// 1 ray cast per pixel. If set to 0.5, 4 rays will be cast per pixel. If
		/// set to 2.0, 1 ray will be cast for every 4 (2 by 2) pixels. This value
		/// will be adjusted to meet a desired frame rate when AutoAdjustSampleDistances
		/// is on.
		/// </summary>
		// Token: 0x0600A83E RID: 43070 RVA: 0x000EECF7 File Offset: 0x000ECEF7
		public virtual void SetImageSampleDistance(float _arg)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_SetImageSampleDistance_86(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A83F RID: 43071
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointVolumeRayCastMapper_SetInteractiveSampleDistance_87(HandleRef pThis, float _arg);

		/// <summary>
		/// Set/Get the distance between samples when interactive rendering is happening.
		/// In this case, interactive is defined as this volume mapper having less than 1
		/// second allocated for rendering. When AutoAdjustSampleDistance is On, and the
		/// allocated render time is less than 1 second, then this InteractiveSampleDistance
		/// will be used instead of the SampleDistance above.
		/// </summary>
		// Token: 0x0600A840 RID: 43072 RVA: 0x000EED07 File Offset: 0x000ECF07
		public virtual void SetInteractiveSampleDistance(float _arg)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_SetInteractiveSampleDistance_87(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A841 RID: 43073
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointVolumeRayCastMapper_SetIntermixIntersectingGeometry_88(HandleRef pThis, int _arg);

		/// <summary>
		/// If IntermixIntersectingGeometry is turned on, the zbuffer will be
		/// captured and used to limit the traversal of the rays.
		/// </summary>
		// Token: 0x0600A842 RID: 43074 RVA: 0x000EED17 File Offset: 0x000ECF17
		public virtual void SetIntermixIntersectingGeometry(int _arg)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_SetIntermixIntersectingGeometry_88(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A843 RID: 43075
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointVolumeRayCastMapper_SetLockSampleDistanceToInputSpacing_89(HandleRef pThis, int _arg);

		/// <summary>
		/// Automatically compute the sample distance from the data spacing.  When
		/// the number of voxels is 8, the sample distance will be roughly 1/200
		/// the average voxel size. The distance will grow proportionally to
		/// numVoxels^(1/3) until it reaches 1/2 average voxel size when number of
		/// voxels is 1E6. Note that ScalarOpacityUnitDistance is still taken into
		/// account and if different than 1, will effect the sample distance.
		/// </summary>
		// Token: 0x0600A844 RID: 43076 RVA: 0x000EED27 File Offset: 0x000ECF27
		public virtual void SetLockSampleDistanceToInputSpacing(int _arg)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_SetLockSampleDistanceToInputSpacing_89(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A845 RID: 43077
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointVolumeRayCastMapper_SetMaximumImageSampleDistance_90(HandleRef pThis, float _arg);

		/// <summary>
		/// This is the maximum image sample distance allow when the image
		/// sample distance is being automatically adjusted.
		/// </summary>
		// Token: 0x0600A846 RID: 43078 RVA: 0x000EED37 File Offset: 0x000ECF37
		public virtual void SetMaximumImageSampleDistance(float _arg)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_SetMaximumImageSampleDistance_90(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A847 RID: 43079
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointVolumeRayCastMapper_SetMinimumImageSampleDistance_91(HandleRef pThis, float _arg);

		/// <summary>
		/// This is the minimum image sample distance allow when the image
		/// sample distance is being automatically adjusted.
		/// </summary>
		// Token: 0x0600A848 RID: 43080 RVA: 0x000EED47 File Offset: 0x000ECF47
		public virtual void SetMinimumImageSampleDistance(float _arg)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_SetMinimumImageSampleDistance_91(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A849 RID: 43081
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointVolumeRayCastMapper_SetNumberOfThreads_92(HandleRef pThis, int num);

		/// <summary>
		/// Set/Get the number of threads to use. This by default is equal to
		/// the number of available processors detected.
		/// WARNING: If number of threads &gt; 1, results may not be consistent.
		/// </summary>
		// Token: 0x0600A84A RID: 43082 RVA: 0x000EED57 File Offset: 0x000ECF57
		public void SetNumberOfThreads(int num)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_SetNumberOfThreads_92(base.GetCppThis(), num);
		}

		// Token: 0x0600A84B RID: 43083
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointVolumeRayCastMapper_SetRayCastImage_93(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set / Get the underlying image object. One will be automatically
		/// created - only need to set it when using from an AMR mapper which
		/// renders multiple times into the same image.
		/// </summary>
		// Token: 0x0600A84C RID: 43084 RVA: 0x000EED68 File Offset: 0x000ECF68
		public void SetRayCastImage(vtkFixedPointRayCastImage arg0)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_SetRayCastImage_93(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600A84D RID: 43085
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointVolumeRayCastMapper_SetSampleDistance_94(HandleRef pThis, float _arg);

		/// <summary>
		/// Set/Get the distance between samples used for rendering
		/// when AutoAdjustSampleDistances is off, or when this mapper
		/// has more than 1 second allocated to it for rendering.
		/// </summary>
		// Token: 0x0600A84E RID: 43086 RVA: 0x000EED97 File Offset: 0x000ECF97
		public virtual void SetSampleDistance(float _arg)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_SetSampleDistance_94(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A84F RID: 43087
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointVolumeRayCastMapper_ShiftVectorDown_95(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Initialize rendering for this volume.
		/// </summary>
		// Token: 0x0600A850 RID: 43088 RVA: 0x000EEDA7 File Offset: 0x000ECFA7
		public void ShiftVectorDown(IntPtr arg0, IntPtr arg1)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_ShiftVectorDown_95(base.GetCppThis(), arg0, arg1);
		}

		// Token: 0x0600A851 RID: 43089
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFixedPointVolumeRayCastMapper_ShouldUseNearestNeighborInterpolation_96(HandleRef pThis, HandleRef vol);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Initialize rendering for this volume.
		/// </summary>
		// Token: 0x0600A852 RID: 43090 RVA: 0x000EEDB8 File Offset: 0x000ECFB8
		public int ShouldUseNearestNeighborInterpolation(vtkVolume vol)
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_ShouldUseNearestNeighborInterpolation_96(base.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis());
		}

		// Token: 0x0600A853 RID: 43091
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkFixedPointVolumeRayCastMapper_ToFixedPointDirection_97(HandleRef pThis, float dir);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Initialize rendering for this volume.
		/// </summary>
		// Token: 0x0600A854 RID: 43092 RVA: 0x000EEDEC File Offset: 0x000ECFEC
		public uint ToFixedPointDirection(float dir)
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_ToFixedPointDirection_97(base.GetCppThis(), dir);
		}

		// Token: 0x0600A855 RID: 43093
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointVolumeRayCastMapper_ToFixedPointDirection_98(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Initialize rendering for this volume.
		/// </summary>
		// Token: 0x0600A856 RID: 43094 RVA: 0x000EEE0C File Offset: 0x000ED00C
		public void ToFixedPointDirection(IntPtr arg0, IntPtr arg1)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_ToFixedPointDirection_98(base.GetCppThis(), arg0, arg1);
		}

		// Token: 0x0600A857 RID: 43095
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkFixedPointVolumeRayCastMapper_ToFixedPointPosition_99(HandleRef pThis, float val);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Initialize rendering for this volume.
		/// </summary>
		// Token: 0x0600A858 RID: 43096 RVA: 0x000EEE20 File Offset: 0x000ED020
		public uint ToFixedPointPosition(float val)
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_ToFixedPointPosition_99(base.GetCppThis(), val);
		}

		// Token: 0x0600A859 RID: 43097
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointVolumeRayCastMapper_ToFixedPointPosition_100(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Initialize rendering for this volume.
		/// </summary>
		// Token: 0x0600A85A RID: 43098 RVA: 0x000EEE40 File Offset: 0x000ED040
		public void ToFixedPointPosition(IntPtr arg0, IntPtr arg1)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_ToFixedPointPosition_100(base.GetCppThis(), arg0, arg1);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D6B RID: 3435
		public new const string MRFullTypeName = "Kitware.VTK.vtkFixedPointVolumeRayCastMapper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D6C RID: 3436
		public new static readonly string MRClassNameKey = "class vtkFixedPointVolumeRayCastMapper";
	}
}
