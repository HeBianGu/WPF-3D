using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSmartVolumeMapper
	/// </summary>
	/// <remarks>
	///    Adaptive volume mapper
	///
	/// vtkSmartVolumeMapper is a volume mapper that will delegate to a specific
	/// volume mapper based on rendering parameters and available hardware. Use the
	/// SetRequestedRenderMode() method to control the behavior of the selection.
	/// The following options are available:
	///
	/// @par vtkSmartVolumeMapper::DefaultRenderMode:
	///          Allow the vtkSmartVolumeMapper to select the best mapper based on
	///          rendering parameters and hardware support. If GPU ray casting is
	///          supported, the vtkGPUVolumeRayCastMapper mapper will be used for
	///          all rendering. If not, then the vtkFixedPointVolumeRayCastMapper
	///          will be used exclusively. This is the default requested render
	///          mode, and is generally the best option. When you use this option,
	///          your volume will always be rendered, but the method used to render
	///          it may vary based on parameters and platform.
	///
	/// @par vtkSmartVolumeMapper::RayCastRenderMode:
	///          Use the vtkFixedPointVolumeRayCastMapper for both interactive and
	///          still rendering. When you use this option your volume will always
	///          be rendered with the vtkFixedPointVolumeRayCastMapper.
	///
	/// @par vtkSmartVolumeMapper::GPURenderMode:
	///          Use the vtkGPUVolumeRayCastMapper, if supported, for both
	///          interactive and still rendering. If the GPU ray caster is not
	///          supported (due to hardware limitations or rendering parameters)
	///          then no image will be rendered. Use this option only if you have
	///          already checked for supported based on the current hardware,
	///          number of scalar components, and rendering parameters in the
	///          vtkVolumeProperty.
	///
	/// @par vtkSmartVolumeMapper::GPURenderMode:
	///  You can adjust the contrast and brightness in the rendered image using the
	///  FinalColorWindow and FinalColorLevel ivars. By default the
	///  FinalColorWindow is set to 1.0, and the FinalColorLevel is set to 0.5,
	///  which applies no correction to the computed image. To apply the window /
	///  level operation to the computer image color, first a Scale and Bias
	///  value are computed:
	///  &lt;pre&gt;
	///  scale = 1.0 / this-&gt;FinalColorWindow
	///  bias  = 0.5 - this-&gt;FinalColorLevel / this-&gt;FinalColorWindow
	///  &lt;/pre&gt;
	///  To compute a new color (R', G', B', A') from an existing color (R,G,B,A)
	///  for a pixel, the following equation is used:
	///  &lt;pre&gt;
	///  R' = R*scale + bias*A
	///  G' = G*scale + bias*A
	///  B' = B*scale + bias*A
	///  A' = A
	///  &lt;/pre&gt;
	/// Note that bias is multiplied by the alpha component before adding because
	/// the red, green, and blue component of the color are already pre-multiplied
	/// by alpha. Also note that the window / level operation leaves the alpha
	/// component unchanged - it only adjusts the RGB values.
	/// </remarks>
	// Token: 0x020000DC RID: 220
	public class vtkSmartVolumeMapper : vtkVolumeMapper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06002E39 RID: 11833 RVA: 0x00043DF7 File Offset: 0x00041FF7
		static vtkSmartVolumeMapper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSmartVolumeMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSmartVolumeMapper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06002E3A RID: 11834 RVA: 0x00043E1F File Offset: 0x0004201F
		public vtkSmartVolumeMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06002E3B RID: 11835
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSmartVolumeMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002E3C RID: 11836 RVA: 0x00043E30 File Offset: 0x00042030
		public new static vtkSmartVolumeMapper New()
		{
			vtkSmartVolumeMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSmartVolumeMapper.vtkSmartVolumeMapper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSmartVolumeMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002E3D RID: 11837 RVA: 0x00043E84 File Offset: 0x00042084
		public vtkSmartVolumeMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSmartVolumeMapper.vtkSmartVolumeMapper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06002E3E RID: 11838 RVA: 0x00043EC8 File Offset: 0x000420C8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06002E3F RID: 11839
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSmartVolumeMapper_AutoAdjustSampleDistancesOff_01(HandleRef pThis);

		/// <summary>
		/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
		/// will be varied to achieve the allocated render time of this
		/// prop (controlled by the desired update rate and any culling in
		/// use).
		/// Note that, this flag is ignored when InteractiveAdjustSampleDistances is
		/// enabled. To explicitly set and use this flag, one must disable
		/// InteractiveAdjustSampleDistances.
		/// </summary>
		// Token: 0x06002E40 RID: 11840 RVA: 0x00043ED3 File Offset: 0x000420D3
		public virtual void AutoAdjustSampleDistancesOff()
		{
			vtkSmartVolumeMapper.vtkSmartVolumeMapper_AutoAdjustSampleDistancesOff_01(base.GetCppThis());
		}

		// Token: 0x06002E41 RID: 11841
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSmartVolumeMapper_AutoAdjustSampleDistancesOn_02(HandleRef pThis);

		/// <summary>
		/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
		/// will be varied to achieve the allocated render time of this
		/// prop (controlled by the desired update rate and any culling in
		/// use).
		/// Note that, this flag is ignored when InteractiveAdjustSampleDistances is
		/// enabled. To explicitly set and use this flag, one must disable
		/// InteractiveAdjustSampleDistances.
		/// </summary>
		// Token: 0x06002E42 RID: 11842 RVA: 0x00043EE2 File Offset: 0x000420E2
		public virtual void AutoAdjustSampleDistancesOn()
		{
			vtkSmartVolumeMapper.vtkSmartVolumeMapper_AutoAdjustSampleDistancesOn_02(base.GetCppThis());
		}

		// Token: 0x06002E43 RID: 11843
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSmartVolumeMapper_CreateCanonicalView_03(HandleRef pThis, HandleRef ren, HandleRef volume, HandleRef volume2, HandleRef image, int blend_mode, IntPtr viewDirection, IntPtr viewUp);

		/// <summary>
		/// This method can be used to render a representative view of the input data
		/// into the supplied image given the supplied blending mode, view direction,
		/// and view up vector.
		/// </summary>
		// Token: 0x06002E44 RID: 11844 RVA: 0x00043EF4 File Offset: 0x000420F4
		public void CreateCanonicalView(vtkRenderer ren, vtkVolume volume, vtkVolume volume2, vtkImageData image, int blend_mode, IntPtr viewDirection, IntPtr viewUp)
		{
			vtkSmartVolumeMapper.vtkSmartVolumeMapper_CreateCanonicalView_03(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (volume == null) ? default(HandleRef) : volume.GetCppThis(), (volume2 == null) ? default(HandleRef) : volume2.GetCppThis(), (image == null) ? default(HandleRef) : image.GetCppThis(), blend_mode, viewDirection, viewUp);
		}

		// Token: 0x06002E45 RID: 11845
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSmartVolumeMapper_GetAutoAdjustSampleDistances_04(HandleRef pThis);

		/// <summary>
		/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
		/// will be varied to achieve the allocated render time of this
		/// prop (controlled by the desired update rate and any culling in
		/// use).
		/// Note that, this flag is ignored when InteractiveAdjustSampleDistances is
		/// enabled. To explicitly set and use this flag, one must disable
		/// InteractiveAdjustSampleDistances.
		/// </summary>
		// Token: 0x06002E46 RID: 11846 RVA: 0x00043F6C File Offset: 0x0004216C
		public virtual int GetAutoAdjustSampleDistances()
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_GetAutoAdjustSampleDistances_04(base.GetCppThis());
		}

		// Token: 0x06002E47 RID: 11847
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSmartVolumeMapper_GetAutoAdjustSampleDistancesMaxValue_05(HandleRef pThis);

		/// <summary>
		/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
		/// will be varied to achieve the allocated render time of this
		/// prop (controlled by the desired update rate and any culling in
		/// use).
		/// Note that, this flag is ignored when InteractiveAdjustSampleDistances is
		/// enabled. To explicitly set and use this flag, one must disable
		/// InteractiveAdjustSampleDistances.
		/// </summary>
		// Token: 0x06002E48 RID: 11848 RVA: 0x00043F8C File Offset: 0x0004218C
		public virtual int GetAutoAdjustSampleDistancesMaxValue()
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_GetAutoAdjustSampleDistancesMaxValue_05(base.GetCppThis());
		}

		// Token: 0x06002E49 RID: 11849
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSmartVolumeMapper_GetAutoAdjustSampleDistancesMinValue_06(HandleRef pThis);

		/// <summary>
		/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
		/// will be varied to achieve the allocated render time of this
		/// prop (controlled by the desired update rate and any culling in
		/// use).
		/// Note that, this flag is ignored when InteractiveAdjustSampleDistances is
		/// enabled. To explicitly set and use this flag, one must disable
		/// InteractiveAdjustSampleDistances.
		/// </summary>
		// Token: 0x06002E4A RID: 11850 RVA: 0x00043FAC File Offset: 0x000421AC
		public virtual int GetAutoAdjustSampleDistancesMinValue()
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_GetAutoAdjustSampleDistancesMinValue_06(base.GetCppThis());
		}

		// Token: 0x06002E4B RID: 11851
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkSmartVolumeMapper_GetFinalColorLevel_07(HandleRef pThis);

		/// <summary>
		/// Get the final color level.
		/// </summary>
		// Token: 0x06002E4C RID: 11852 RVA: 0x00043FCC File Offset: 0x000421CC
		public virtual float GetFinalColorLevel()
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_GetFinalColorLevel_07(base.GetCppThis());
		}

		// Token: 0x06002E4D RID: 11853
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkSmartVolumeMapper_GetFinalColorWindow_08(HandleRef pThis);

		/// <summary>
		/// Get the final color window. Initial value is 1.0.
		/// </summary>
		// Token: 0x06002E4E RID: 11854 RVA: 0x00043FEC File Offset: 0x000421EC
		public virtual float GetFinalColorWindow()
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_GetFinalColorWindow_08(base.GetCppThis());
		}

		// Token: 0x06002E4F RID: 11855
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkSmartVolumeMapper_GetGlobalIlluminationReach_09(HandleRef pThis);

		/// <summary>
		/// @copydoc vtkGPUVolumeRayCastMapper::SetGlobalIlluminationReach(float)
		///
		/// This parameter is only used when the underlying mapper
		/// is a vtkGPUVolumeRayCastMapper.
		/// </summary>
		// Token: 0x06002E50 RID: 11856 RVA: 0x0004400C File Offset: 0x0004220C
		public virtual float GetGlobalIlluminationReach()
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_GetGlobalIlluminationReach_09(base.GetCppThis());
		}

		// Token: 0x06002E51 RID: 11857
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkSmartVolumeMapper_GetGlobalIlluminationReachMaxValue_10(HandleRef pThis);

		/// <summary>
		/// @copydoc vtkGPUVolumeRayCastMapper::SetGlobalIlluminationReach(float)
		///
		/// This parameter is only used when the underlying mapper
		/// is a vtkGPUVolumeRayCastMapper.
		/// </summary>
		// Token: 0x06002E52 RID: 11858 RVA: 0x0004402C File Offset: 0x0004222C
		public virtual float GetGlobalIlluminationReachMaxValue()
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_GetGlobalIlluminationReachMaxValue_10(base.GetCppThis());
		}

		// Token: 0x06002E53 RID: 11859
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkSmartVolumeMapper_GetGlobalIlluminationReachMinValue_11(HandleRef pThis);

		/// <summary>
		/// @copydoc vtkGPUVolumeRayCastMapper::SetGlobalIlluminationReach(float)
		///
		/// This parameter is only used when the underlying mapper
		/// is a vtkGPUVolumeRayCastMapper.
		/// </summary>
		// Token: 0x06002E54 RID: 11860 RVA: 0x0004404C File Offset: 0x0004224C
		public virtual float GetGlobalIlluminationReachMinValue()
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_GetGlobalIlluminationReachMinValue_11(base.GetCppThis());
		}

		// Token: 0x06002E55 RID: 11861
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSmartVolumeMapper_GetInteractiveAdjustSampleDistances_12(HandleRef pThis);

		/// <summary>
		/// If the InteractiveAdjustSampleDistances flag is enabled,
		/// vtkSmartVolumeMapper interactively sets and resets the
		/// AutoAdjustSampleDistances flag on the internal volume mapper. This flag
		/// along with InteractiveUpdateRate is useful to adjust volume mapper sample
		/// distance based on whether the render is interactive or still.
		/// By default, InteractiveAdjustSampleDistances is enabled.
		/// </summary>
		// Token: 0x06002E56 RID: 11862 RVA: 0x0004406C File Offset: 0x0004226C
		public virtual int GetInteractiveAdjustSampleDistances()
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_GetInteractiveAdjustSampleDistances_12(base.GetCppThis());
		}

		// Token: 0x06002E57 RID: 11863
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSmartVolumeMapper_GetInteractiveAdjustSampleDistancesMaxValue_13(HandleRef pThis);

		/// <summary>
		/// If the InteractiveAdjustSampleDistances flag is enabled,
		/// vtkSmartVolumeMapper interactively sets and resets the
		/// AutoAdjustSampleDistances flag on the internal volume mapper. This flag
		/// along with InteractiveUpdateRate is useful to adjust volume mapper sample
		/// distance based on whether the render is interactive or still.
		/// By default, InteractiveAdjustSampleDistances is enabled.
		/// </summary>
		// Token: 0x06002E58 RID: 11864 RVA: 0x0004408C File Offset: 0x0004228C
		public virtual int GetInteractiveAdjustSampleDistancesMaxValue()
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_GetInteractiveAdjustSampleDistancesMaxValue_13(base.GetCppThis());
		}

		// Token: 0x06002E59 RID: 11865
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSmartVolumeMapper_GetInteractiveAdjustSampleDistancesMinValue_14(HandleRef pThis);

		/// <summary>
		/// If the InteractiveAdjustSampleDistances flag is enabled,
		/// vtkSmartVolumeMapper interactively sets and resets the
		/// AutoAdjustSampleDistances flag on the internal volume mapper. This flag
		/// along with InteractiveUpdateRate is useful to adjust volume mapper sample
		/// distance based on whether the render is interactive or still.
		/// By default, InteractiveAdjustSampleDistances is enabled.
		/// </summary>
		// Token: 0x06002E5A RID: 11866 RVA: 0x000440AC File Offset: 0x000422AC
		public virtual int GetInteractiveAdjustSampleDistancesMinValue()
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_GetInteractiveAdjustSampleDistancesMinValue_14(base.GetCppThis());
		}

		// Token: 0x06002E5B RID: 11867
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSmartVolumeMapper_GetInteractiveUpdateRate_15(HandleRef pThis);

		/// <summary>
		/// Get the update rate at or above which this is considered an
		/// interactive render.
		/// Initial value is 1.0.
		/// </summary>
		// Token: 0x06002E5C RID: 11868 RVA: 0x000440CC File Offset: 0x000422CC
		public virtual double GetInteractiveUpdateRate()
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_GetInteractiveUpdateRate_15(base.GetCppThis());
		}

		// Token: 0x06002E5D RID: 11869
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSmartVolumeMapper_GetInteractiveUpdateRateMaxValue_16(HandleRef pThis);

		/// <summary>
		/// If the DesiredUpdateRate of the vtkRenderWindow that caused the Render
		/// falls at or above this rate, the render is considered interactive and
		/// the mapper may be adjusted (depending on the render mode).
		/// Initial value is 1.0.
		/// </summary>
		// Token: 0x06002E5E RID: 11870 RVA: 0x000440EC File Offset: 0x000422EC
		public virtual double GetInteractiveUpdateRateMaxValue()
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_GetInteractiveUpdateRateMaxValue_16(base.GetCppThis());
		}

		// Token: 0x06002E5F RID: 11871
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSmartVolumeMapper_GetInteractiveUpdateRateMinValue_17(HandleRef pThis);

		/// <summary>
		/// If the DesiredUpdateRate of the vtkRenderWindow that caused the Render
		/// falls at or above this rate, the render is considered interactive and
		/// the mapper may be adjusted (depending on the render mode).
		/// Initial value is 1.0.
		/// </summary>
		// Token: 0x06002E60 RID: 11872 RVA: 0x0004410C File Offset: 0x0004230C
		public virtual double GetInteractiveUpdateRateMinValue()
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_GetInteractiveUpdateRateMinValue_17(base.GetCppThis());
		}

		// Token: 0x06002E61 RID: 11873
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSmartVolumeMapper_GetInterpolationMode_18(HandleRef pThis);

		/// <summary>
		/// Set interpolation mode for downsampling (lowres GPU)
		/// (initial value: cubic).
		/// </summary>
		// Token: 0x06002E62 RID: 11874 RVA: 0x0004412C File Offset: 0x0004232C
		public virtual int GetInterpolationMode()
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_GetInterpolationMode_18(base.GetCppThis());
		}

		// Token: 0x06002E63 RID: 11875
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSmartVolumeMapper_GetInterpolationModeMaxValue_19(HandleRef pThis);

		/// <summary>
		/// Set interpolation mode for downsampling (lowres GPU)
		/// (initial value: cubic).
		/// </summary>
		// Token: 0x06002E64 RID: 11876 RVA: 0x0004414C File Offset: 0x0004234C
		public virtual int GetInterpolationModeMaxValue()
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_GetInterpolationModeMaxValue_19(base.GetCppThis());
		}

		// Token: 0x06002E65 RID: 11877
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSmartVolumeMapper_GetInterpolationModeMinValue_20(HandleRef pThis);

		/// <summary>
		/// Set interpolation mode for downsampling (lowres GPU)
		/// (initial value: cubic).
		/// </summary>
		// Token: 0x06002E66 RID: 11878 RVA: 0x0004416C File Offset: 0x0004236C
		public virtual int GetInterpolationModeMinValue()
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_GetInterpolationModeMinValue_20(base.GetCppThis());
		}

		// Token: 0x06002E67 RID: 11879
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSmartVolumeMapper_GetLastUsedRenderMode_21(HandleRef pThis);

		/// <summary>
		/// This will return the render mode used during the previous call to
		/// Render().
		/// </summary>
		// Token: 0x06002E68 RID: 11880 RVA: 0x0004418C File Offset: 0x0004238C
		public int GetLastUsedRenderMode()
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_GetLastUsedRenderMode_21(base.GetCppThis());
		}

		// Token: 0x06002E69 RID: 11881
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSmartVolumeMapper_GetLowResMode_22(HandleRef pThis);

		/// <summary>
		/// LowResDisable disables low res mode (default)
		/// LowResResample enable low res mode by automatically resampling the volume,
		/// this enable large volume to be displayed at higher frame rate at the cost of
		/// rendering quality
		/// Actual resample factor will be determined using MaxMemoryInBytes and MaxMemoryFraction
		/// </summary>
		// Token: 0x06002E6A RID: 11882 RVA: 0x000441AC File Offset: 0x000423AC
		public virtual int GetLowResMode()
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_GetLowResMode_22(base.GetCppThis());
		}

		// Token: 0x06002E6B RID: 11883
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkSmartVolumeMapper_GetMaxMemoryFraction_23(HandleRef pThis);

		/// <summary>
		/// Value passed to the GPU mapper. Ignored by other mappers.
		/// Maximum fraction of the MaxMemoryInBytes that should
		/// be used to hold the texture. Valid values are 0.1 to
		/// 1.0.
		/// </summary>
		// Token: 0x06002E6C RID: 11884 RVA: 0x000441CC File Offset: 0x000423CC
		public virtual float GetMaxMemoryFraction()
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_GetMaxMemoryFraction_23(base.GetCppThis());
		}

		// Token: 0x06002E6D RID: 11885
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkSmartVolumeMapper_GetMaxMemoryFractionMaxValue_24(HandleRef pThis);

		/// <summary>
		/// Value passed to the GPU mapper. Ignored by other mappers.
		/// Maximum fraction of the MaxMemoryInBytes that should
		/// be used to hold the texture. Valid values are 0.1 to
		/// 1.0.
		/// </summary>
		// Token: 0x06002E6E RID: 11886 RVA: 0x000441EC File Offset: 0x000423EC
		public virtual float GetMaxMemoryFractionMaxValue()
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_GetMaxMemoryFractionMaxValue_24(base.GetCppThis());
		}

		// Token: 0x06002E6F RID: 11887
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkSmartVolumeMapper_GetMaxMemoryFractionMinValue_25(HandleRef pThis);

		/// <summary>
		/// Value passed to the GPU mapper. Ignored by other mappers.
		/// Maximum fraction of the MaxMemoryInBytes that should
		/// be used to hold the texture. Valid values are 0.1 to
		/// 1.0.
		/// </summary>
		// Token: 0x06002E70 RID: 11888 RVA: 0x0004420C File Offset: 0x0004240C
		public virtual float GetMaxMemoryFractionMinValue()
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_GetMaxMemoryFractionMinValue_25(base.GetCppThis());
		}

		// Token: 0x06002E71 RID: 11889
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSmartVolumeMapper_GetMaxMemoryInBytes_26(HandleRef pThis);

		/// <summary>
		/// Value passed to the GPU mapper. Ignored by other mappers.
		/// Maximum size of the 3D texture in GPU memory.
		/// Will default to the size computed from the graphics
		/// card. Can be adjusted by the user.
		/// Useful if the automatic detection is defective or missing.
		/// </summary>
		// Token: 0x06002E72 RID: 11890 RVA: 0x0004422C File Offset: 0x0004242C
		public virtual long GetMaxMemoryInBytes()
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_GetMaxMemoryInBytes_26(base.GetCppThis());
		}

		// Token: 0x06002E73 RID: 11891
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSmartVolumeMapper_GetNumberOfGenerationsFromBase_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002E74 RID: 11892 RVA: 0x0004424C File Offset: 0x0004244C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_GetNumberOfGenerationsFromBase_27(base.GetCppThis(), type);
		}

		// Token: 0x06002E75 RID: 11893
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSmartVolumeMapper_GetNumberOfGenerationsFromBaseType_28([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002E76 RID: 11894 RVA: 0x0004426C File Offset: 0x0004246C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_GetNumberOfGenerationsFromBaseType_28(type);
		}

		// Token: 0x06002E77 RID: 11895
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSmartVolumeMapper_GetRequestedRenderMode_29(HandleRef pThis);

		/// <summary>
		/// Get the requested render mode.
		/// </summary>
		// Token: 0x06002E78 RID: 11896 RVA: 0x00044288 File Offset: 0x00042488
		public virtual int GetRequestedRenderMode()
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_GetRequestedRenderMode_29(base.GetCppThis());
		}

		// Token: 0x06002E79 RID: 11897
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkSmartVolumeMapper_GetSampleDistance_30(HandleRef pThis);

		/// <summary>
		/// Set/Get the distance between samples used for rendering
		/// when AutoAdjustSampleDistances is off, or when this mapper
		/// has more than 1 second allocated to it for rendering.
		/// If SampleDistance is negative, it will be computed based on the dataset
		/// spacing. Initial value is -1.0.
		/// </summary>
		// Token: 0x06002E7A RID: 11898 RVA: 0x000442A8 File Offset: 0x000424A8
		public virtual float GetSampleDistance()
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_GetSampleDistance_30(base.GetCppThis());
		}

		// Token: 0x06002E7B RID: 11899
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSmartVolumeMapper_GetTransfer2DYAxisArray_31(HandleRef pThis);

		/// <summary>
		/// Set/Get the transfer 2D Y axis array
		/// </summary>
		// Token: 0x06002E7C RID: 11900 RVA: 0x000442C8 File Offset: 0x000424C8
		public virtual string GetTransfer2DYAxisArray()
		{
			string s = Marshal.PtrToStringAnsi(vtkSmartVolumeMapper.vtkSmartVolumeMapper_GetTransfer2DYAxisArray_31(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06002E7D RID: 11901
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSmartVolumeMapper_GetUseJittering_32(HandleRef pThis);

		/// <summary>
		/// If UseJittering is on, each ray traversal direction will be
		/// perturbed slightly using a noise-texture to get rid of wood-grain
		/// effect. This is only used by the GPU mapper.
		/// </summary>
		// Token: 0x06002E7E RID: 11902 RVA: 0x00044304 File Offset: 0x00042504
		public virtual int GetUseJittering()
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_GetUseJittering_32(base.GetCppThis());
		}

		// Token: 0x06002E7F RID: 11903
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSmartVolumeMapper_GetUseJitteringMaxValue_33(HandleRef pThis);

		/// <summary>
		/// If UseJittering is on, each ray traversal direction will be
		/// perturbed slightly using a noise-texture to get rid of wood-grain
		/// effect. This is only used by the GPU mapper.
		/// </summary>
		// Token: 0x06002E80 RID: 11904 RVA: 0x00044324 File Offset: 0x00042524
		public virtual int GetUseJitteringMaxValue()
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_GetUseJitteringMaxValue_33(base.GetCppThis());
		}

		// Token: 0x06002E81 RID: 11905
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSmartVolumeMapper_GetUseJitteringMinValue_34(HandleRef pThis);

		/// <summary>
		/// If UseJittering is on, each ray traversal direction will be
		/// perturbed slightly using a noise-texture to get rid of wood-grain
		/// effect. This is only used by the GPU mapper.
		/// </summary>
		// Token: 0x06002E82 RID: 11906 RVA: 0x00044344 File Offset: 0x00042544
		public virtual int GetUseJitteringMinValue()
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_GetUseJitteringMinValue_34(base.GetCppThis());
		}

		// Token: 0x06002E83 RID: 11907
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSmartVolumeMapper_GetVectorComponent_35(HandleRef pThis);

		/// <summary>
		/// VectorMode is a special rendering mode for 3-component vectors which makes
		/// use of GPURayCastMapper's independent-component capabilities. In this mode,
		/// a single component in the vector can be selected for rendering. In addition,
		/// the mapper can compute a scalar field representing the magnitude of this vector
		/// using a vtkImageMagnitude object (MAGNITUDE mode).
		/// </summary>
		// Token: 0x06002E84 RID: 11908 RVA: 0x00044364 File Offset: 0x00042564
		public virtual int GetVectorComponent()
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_GetVectorComponent_35(base.GetCppThis());
		}

		// Token: 0x06002E85 RID: 11909
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSmartVolumeMapper_GetVectorComponentMaxValue_36(HandleRef pThis);

		/// <summary>
		/// VectorMode is a special rendering mode for 3-component vectors which makes
		/// use of GPURayCastMapper's independent-component capabilities. In this mode,
		/// a single component in the vector can be selected for rendering. In addition,
		/// the mapper can compute a scalar field representing the magnitude of this vector
		/// using a vtkImageMagnitude object (MAGNITUDE mode).
		/// </summary>
		// Token: 0x06002E86 RID: 11910 RVA: 0x00044384 File Offset: 0x00042584
		public virtual int GetVectorComponentMaxValue()
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_GetVectorComponentMaxValue_36(base.GetCppThis());
		}

		// Token: 0x06002E87 RID: 11911
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSmartVolumeMapper_GetVectorComponentMinValue_37(HandleRef pThis);

		/// <summary>
		/// VectorMode is a special rendering mode for 3-component vectors which makes
		/// use of GPURayCastMapper's independent-component capabilities. In this mode,
		/// a single component in the vector can be selected for rendering. In addition,
		/// the mapper can compute a scalar field representing the magnitude of this vector
		/// using a vtkImageMagnitude object (MAGNITUDE mode).
		/// </summary>
		// Token: 0x06002E88 RID: 11912 RVA: 0x000443A4 File Offset: 0x000425A4
		public virtual int GetVectorComponentMinValue()
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_GetVectorComponentMinValue_37(base.GetCppThis());
		}

		// Token: 0x06002E89 RID: 11913
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSmartVolumeMapper_GetVectorMode_38(HandleRef pThis);

		/// <summary>
		/// VectorMode is a special rendering mode for 3-component vectors which makes
		/// use of GPURayCastMapper's independent-component capabilities. In this mode,
		/// a single component in the vector can be selected for rendering. In addition,
		/// the mapper can compute a scalar field representing the magnitude of this vector
		/// using a vtkImageMagnitude object (MAGNITUDE mode).
		/// </summary>
		// Token: 0x06002E8A RID: 11914 RVA: 0x000443C4 File Offset: 0x000425C4
		public virtual int GetVectorMode()
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_GetVectorMode_38(base.GetCppThis());
		}

		// Token: 0x06002E8B RID: 11915
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkSmartVolumeMapper_GetVolumetricScatteringBlending_39(HandleRef pThis);

		/// <summary>
		/// @copydoc vtkGPUVolumeRayCastMapper::SetVolumetricScatteringBlending(float)
		///
		/// This parameter is only used when the underlying mapper
		/// is a vtkGPUVolumeRayCastMapper.
		/// </summary>
		// Token: 0x06002E8C RID: 11916 RVA: 0x000443E4 File Offset: 0x000425E4
		public virtual float GetVolumetricScatteringBlending()
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_GetVolumetricScatteringBlending_39(base.GetCppThis());
		}

		// Token: 0x06002E8D RID: 11917
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkSmartVolumeMapper_GetVolumetricScatteringBlendingMaxValue_40(HandleRef pThis);

		/// <summary>
		/// @copydoc vtkGPUVolumeRayCastMapper::SetVolumetricScatteringBlending(float)
		///
		/// This parameter is only used when the underlying mapper
		/// is a vtkGPUVolumeRayCastMapper.
		/// </summary>
		// Token: 0x06002E8E RID: 11918 RVA: 0x00044404 File Offset: 0x00042604
		public virtual float GetVolumetricScatteringBlendingMaxValue()
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_GetVolumetricScatteringBlendingMaxValue_40(base.GetCppThis());
		}

		// Token: 0x06002E8F RID: 11919
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkSmartVolumeMapper_GetVolumetricScatteringBlendingMinValue_41(HandleRef pThis);

		/// <summary>
		/// @copydoc vtkGPUVolumeRayCastMapper::SetVolumetricScatteringBlending(float)
		///
		/// This parameter is only used when the underlying mapper
		/// is a vtkGPUVolumeRayCastMapper.
		/// </summary>
		// Token: 0x06002E90 RID: 11920 RVA: 0x00044424 File Offset: 0x00042624
		public virtual float GetVolumetricScatteringBlendingMinValue()
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_GetVolumetricScatteringBlendingMinValue_41(base.GetCppThis());
		}

		// Token: 0x06002E91 RID: 11921
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSmartVolumeMapper_InteractiveAdjustSampleDistancesOff_42(HandleRef pThis);

		/// <summary>
		/// If the InteractiveAdjustSampleDistances flag is enabled,
		/// vtkSmartVolumeMapper interactively sets and resets the
		/// AutoAdjustSampleDistances flag on the internal volume mapper. This flag
		/// along with InteractiveUpdateRate is useful to adjust volume mapper sample
		/// distance based on whether the render is interactive or still.
		/// By default, InteractiveAdjustSampleDistances is enabled.
		/// </summary>
		// Token: 0x06002E92 RID: 11922 RVA: 0x00044443 File Offset: 0x00042643
		public virtual void InteractiveAdjustSampleDistancesOff()
		{
			vtkSmartVolumeMapper.vtkSmartVolumeMapper_InteractiveAdjustSampleDistancesOff_42(base.GetCppThis());
		}

		// Token: 0x06002E93 RID: 11923
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSmartVolumeMapper_InteractiveAdjustSampleDistancesOn_43(HandleRef pThis);

		/// <summary>
		/// If the InteractiveAdjustSampleDistances flag is enabled,
		/// vtkSmartVolumeMapper interactively sets and resets the
		/// AutoAdjustSampleDistances flag on the internal volume mapper. This flag
		/// along with InteractiveUpdateRate is useful to adjust volume mapper sample
		/// distance based on whether the render is interactive or still.
		/// By default, InteractiveAdjustSampleDistances is enabled.
		/// </summary>
		// Token: 0x06002E94 RID: 11924 RVA: 0x00044452 File Offset: 0x00042652
		public virtual void InteractiveAdjustSampleDistancesOn()
		{
			vtkSmartVolumeMapper.vtkSmartVolumeMapper_InteractiveAdjustSampleDistancesOn_43(base.GetCppThis());
		}

		// Token: 0x06002E95 RID: 11925
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSmartVolumeMapper_IsA_44(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002E96 RID: 11926 RVA: 0x00044464 File Offset: 0x00042664
		public override int IsA(string type)
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_IsA_44(base.GetCppThis(), type);
		}

		// Token: 0x06002E97 RID: 11927
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSmartVolumeMapper_IsTypeOf_45([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002E98 RID: 11928 RVA: 0x00044484 File Offset: 0x00042684
		public new static int IsTypeOf(string type)
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_IsTypeOf_45(type);
		}

		// Token: 0x06002E99 RID: 11929
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSmartVolumeMapper_NewInstance_47(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002E9A RID: 11930 RVA: 0x000444A0 File Offset: 0x000426A0
		public new vtkSmartVolumeMapper NewInstance()
		{
			vtkSmartVolumeMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSmartVolumeMapper.vtkSmartVolumeMapper_NewInstance_47(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSmartVolumeMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06002E9B RID: 11931
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSmartVolumeMapper_ReleaseGraphicsResources_48(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Release any graphics resources that are being consumed by this mapper.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x06002E9C RID: 11932 RVA: 0x000444FC File Offset: 0x000426FC
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkSmartVolumeMapper.vtkSmartVolumeMapper_ReleaseGraphicsResources_48(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002E9D RID: 11933
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSmartVolumeMapper_Render_49(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Initialize rendering for this volume.
		/// </summary>
		// Token: 0x06002E9E RID: 11934 RVA: 0x0004452C File Offset: 0x0004272C
		public override void Render(vtkRenderer arg0, vtkVolume arg1)
		{
			vtkSmartVolumeMapper.vtkSmartVolumeMapper_Render_49(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x06002E9F RID: 11935
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSmartVolumeMapper_SafeDownCast_50(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002EA0 RID: 11936 RVA: 0x00044570 File Offset: 0x00042770
		public new static vtkSmartVolumeMapper SafeDownCast(vtkObjectBase o)
		{
			vtkSmartVolumeMapper vtkSmartVolumeMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSmartVolumeMapper.vtkSmartVolumeMapper_SafeDownCast_50((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSmartVolumeMapper = (vtkSmartVolumeMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSmartVolumeMapper.Register(null);
				}
			}
			return vtkSmartVolumeMapper;
		}

		// Token: 0x06002EA1 RID: 11937
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSmartVolumeMapper_SetAutoAdjustSampleDistances_51(HandleRef pThis, int _arg);

		/// <summary>
		/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
		/// will be varied to achieve the allocated render time of this
		/// prop (controlled by the desired update rate and any culling in
		/// use).
		/// Note that, this flag is ignored when InteractiveAdjustSampleDistances is
		/// enabled. To explicitly set and use this flag, one must disable
		/// InteractiveAdjustSampleDistances.
		/// </summary>
		// Token: 0x06002EA2 RID: 11938 RVA: 0x000445EF File Offset: 0x000427EF
		public virtual void SetAutoAdjustSampleDistances(int _arg)
		{
			vtkSmartVolumeMapper.vtkSmartVolumeMapper_SetAutoAdjustSampleDistances_51(base.GetCppThis(), _arg);
		}

		// Token: 0x06002EA3 RID: 11939
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSmartVolumeMapper_SetFinalColorLevel_52(HandleRef pThis, float _arg);

		/// <summary>
		/// Set the final color level. The level controls the
		/// brightness of the image. The final color window will
		/// be centered at the final color level, and together
		/// represent a linear remapping of color values. The
		/// default value for the level is 0.5.
		/// </summary>
		// Token: 0x06002EA4 RID: 11940 RVA: 0x000445FF File Offset: 0x000427FF
		public virtual void SetFinalColorLevel(float _arg)
		{
			vtkSmartVolumeMapper.vtkSmartVolumeMapper_SetFinalColorLevel_52(base.GetCppThis(), _arg);
		}

		// Token: 0x06002EA5 RID: 11941
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSmartVolumeMapper_SetFinalColorWindow_53(HandleRef pThis, float _arg);

		/// <summary>
		/// Set the final color window. This controls the contrast of
		/// the image. The default value is 1.0. The Window can be
		/// negative (this causes a "negative" effect on the image)
		/// Although Window can be set to 0.0, any value less than
		/// 0.00001 and greater than or equal to 0.0 will be set to
		/// 0.00001, and any value greater than -0.00001 but less
		/// than or equal to 0.0 will be set to -0.00001.
		/// Initial value is 1.0.
		/// </summary>
		// Token: 0x06002EA6 RID: 11942 RVA: 0x0004460F File Offset: 0x0004280F
		public virtual void SetFinalColorWindow(float _arg)
		{
			vtkSmartVolumeMapper.vtkSmartVolumeMapper_SetFinalColorWindow_53(base.GetCppThis(), _arg);
		}

		// Token: 0x06002EA7 RID: 11943
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSmartVolumeMapper_SetGlobalIlluminationReach_54(HandleRef pThis, float _arg);

		/// <summary>
		/// @copydoc vtkGPUVolumeRayCastMapper::SetGlobalIlluminationReach(float)
		///
		/// This parameter is only used when the underlying mapper
		/// is a vtkGPUVolumeRayCastMapper.
		/// </summary>
		// Token: 0x06002EA8 RID: 11944 RVA: 0x0004461F File Offset: 0x0004281F
		public virtual void SetGlobalIlluminationReach(float _arg)
		{
			vtkSmartVolumeMapper.vtkSmartVolumeMapper_SetGlobalIlluminationReach_54(base.GetCppThis(), _arg);
		}

		// Token: 0x06002EA9 RID: 11945
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSmartVolumeMapper_SetInteractiveAdjustSampleDistances_55(HandleRef pThis, int _arg);

		/// <summary>
		/// If the InteractiveAdjustSampleDistances flag is enabled,
		/// vtkSmartVolumeMapper interactively sets and resets the
		/// AutoAdjustSampleDistances flag on the internal volume mapper. This flag
		/// along with InteractiveUpdateRate is useful to adjust volume mapper sample
		/// distance based on whether the render is interactive or still.
		/// By default, InteractiveAdjustSampleDistances is enabled.
		/// </summary>
		// Token: 0x06002EAA RID: 11946 RVA: 0x0004462F File Offset: 0x0004282F
		public virtual void SetInteractiveAdjustSampleDistances(int _arg)
		{
			vtkSmartVolumeMapper.vtkSmartVolumeMapper_SetInteractiveAdjustSampleDistances_55(base.GetCppThis(), _arg);
		}

		// Token: 0x06002EAB RID: 11947
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSmartVolumeMapper_SetInteractiveUpdateRate_56(HandleRef pThis, double _arg);

		/// <summary>
		/// If the DesiredUpdateRate of the vtkRenderWindow that caused the Render
		/// falls at or above this rate, the render is considered interactive and
		/// the mapper may be adjusted (depending on the render mode).
		/// Initial value is 1.0.
		/// </summary>
		// Token: 0x06002EAC RID: 11948 RVA: 0x0004463F File Offset: 0x0004283F
		public virtual void SetInteractiveUpdateRate(double _arg)
		{
			vtkSmartVolumeMapper.vtkSmartVolumeMapper_SetInteractiveUpdateRate_56(base.GetCppThis(), _arg);
		}

		// Token: 0x06002EAD RID: 11949
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSmartVolumeMapper_SetInterpolationMode_57(HandleRef pThis, int _arg);

		/// <summary>
		/// Set interpolation mode for downsampling (lowres GPU)
		/// (initial value: cubic).
		/// </summary>
		// Token: 0x06002EAE RID: 11950 RVA: 0x0004464F File Offset: 0x0004284F
		public virtual void SetInterpolationMode(int _arg)
		{
			vtkSmartVolumeMapper.vtkSmartVolumeMapper_SetInterpolationMode_57(base.GetCppThis(), _arg);
		}

		// Token: 0x06002EAF RID: 11951
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSmartVolumeMapper_SetInterpolationModeToCubic_58(HandleRef pThis);

		/// <summary>
		/// Set interpolation mode for downsampling (lowres GPU)
		/// (initial value: cubic).
		/// </summary>
		// Token: 0x06002EB0 RID: 11952 RVA: 0x0004465F File Offset: 0x0004285F
		public void SetInterpolationModeToCubic()
		{
			vtkSmartVolumeMapper.vtkSmartVolumeMapper_SetInterpolationModeToCubic_58(base.GetCppThis());
		}

		// Token: 0x06002EB1 RID: 11953
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSmartVolumeMapper_SetInterpolationModeToLinear_59(HandleRef pThis);

		/// <summary>
		/// Set interpolation mode for downsampling (lowres GPU)
		/// (initial value: cubic).
		/// </summary>
		// Token: 0x06002EB2 RID: 11954 RVA: 0x0004466E File Offset: 0x0004286E
		public void SetInterpolationModeToLinear()
		{
			vtkSmartVolumeMapper.vtkSmartVolumeMapper_SetInterpolationModeToLinear_59(base.GetCppThis());
		}

		// Token: 0x06002EB3 RID: 11955
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSmartVolumeMapper_SetInterpolationModeToNearestNeighbor_60(HandleRef pThis);

		/// <summary>
		/// Set interpolation mode for downsampling (lowres GPU)
		/// (initial value: cubic).
		/// </summary>
		// Token: 0x06002EB4 RID: 11956 RVA: 0x0004467D File Offset: 0x0004287D
		public void SetInterpolationModeToNearestNeighbor()
		{
			vtkSmartVolumeMapper.vtkSmartVolumeMapper_SetInterpolationModeToNearestNeighbor_60(base.GetCppThis());
		}

		// Token: 0x06002EB5 RID: 11957
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSmartVolumeMapper_SetLowResMode_61(HandleRef pThis, int _arg);

		/// <summary>
		/// LowResDisable disables low res mode (default)
		/// LowResResample enable low res mode by automatically resampling the volume,
		/// this enable large volume to be displayed at higher frame rate at the cost of
		/// rendering quality
		/// Actual resample factor will be determined using MaxMemoryInBytes and MaxMemoryFraction
		/// </summary>
		// Token: 0x06002EB6 RID: 11958 RVA: 0x0004468C File Offset: 0x0004288C
		public virtual void SetLowResMode(int _arg)
		{
			vtkSmartVolumeMapper.vtkSmartVolumeMapper_SetLowResMode_61(base.GetCppThis(), _arg);
		}

		// Token: 0x06002EB7 RID: 11959
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSmartVolumeMapper_SetMaxMemoryFraction_62(HandleRef pThis, float _arg);

		/// <summary>
		/// Value passed to the GPU mapper. Ignored by other mappers.
		/// Maximum fraction of the MaxMemoryInBytes that should
		/// be used to hold the texture. Valid values are 0.1 to
		/// 1.0.
		/// </summary>
		// Token: 0x06002EB8 RID: 11960 RVA: 0x0004469C File Offset: 0x0004289C
		public virtual void SetMaxMemoryFraction(float _arg)
		{
			vtkSmartVolumeMapper.vtkSmartVolumeMapper_SetMaxMemoryFraction_62(base.GetCppThis(), _arg);
		}

		// Token: 0x06002EB9 RID: 11961
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSmartVolumeMapper_SetMaxMemoryInBytes_63(HandleRef pThis, long _arg);

		/// <summary>
		/// Value passed to the GPU mapper. Ignored by other mappers.
		/// Maximum size of the 3D texture in GPU memory.
		/// Will default to the size computed from the graphics
		/// card. Can be adjusted by the user.
		/// Useful if the automatic detection is defective or missing.
		/// </summary>
		// Token: 0x06002EBA RID: 11962 RVA: 0x000446AC File Offset: 0x000428AC
		public virtual void SetMaxMemoryInBytes(long _arg)
		{
			vtkSmartVolumeMapper.vtkSmartVolumeMapper_SetMaxMemoryInBytes_63(base.GetCppThis(), _arg);
		}

		// Token: 0x06002EBB RID: 11963
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSmartVolumeMapper_SetRequestedRenderMode_64(HandleRef pThis, int mode);

		/// <summary>
		/// Set the requested render mode. The default is
		/// vtkSmartVolumeMapper::DefaultRenderMode.
		/// </summary>
		// Token: 0x06002EBC RID: 11964 RVA: 0x000446BC File Offset: 0x000428BC
		public void SetRequestedRenderMode(int mode)
		{
			vtkSmartVolumeMapper.vtkSmartVolumeMapper_SetRequestedRenderMode_64(base.GetCppThis(), mode);
		}

		// Token: 0x06002EBD RID: 11965
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSmartVolumeMapper_SetRequestedRenderModeToDefault_65(HandleRef pThis);

		/// <summary>
		/// Set the requested render mode to vtkSmartVolumeMapper::DefaultRenderMode.
		/// This is the best option for an application that must adapt to different
		/// data types, hardware, and rendering parameters.
		/// </summary>
		// Token: 0x06002EBE RID: 11966 RVA: 0x000446CC File Offset: 0x000428CC
		public void SetRequestedRenderModeToDefault()
		{
			vtkSmartVolumeMapper.vtkSmartVolumeMapper_SetRequestedRenderModeToDefault_65(base.GetCppThis());
		}

		// Token: 0x06002EBF RID: 11967
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSmartVolumeMapper_SetRequestedRenderModeToGPU_66(HandleRef pThis);

		/// <summary>
		/// Set the requested render mode to vtkSmartVolumeMapper::GPURenderMode.
		/// This option will use hardware accelerated rendering exclusively. This is a
		/// good option if you know there is hardware acceleration.
		/// </summary>
		// Token: 0x06002EC0 RID: 11968 RVA: 0x000446DB File Offset: 0x000428DB
		public void SetRequestedRenderModeToGPU()
		{
			vtkSmartVolumeMapper.vtkSmartVolumeMapper_SetRequestedRenderModeToGPU_66(base.GetCppThis());
		}

		// Token: 0x06002EC1 RID: 11969
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSmartVolumeMapper_SetRequestedRenderModeToOSPRay_67(HandleRef pThis);

		/// <summary>
		/// Set the requested render mode to vtkSmartVolumeMapper::OSPRayRenderMode.
		/// This option will use intel OSPRay to do software rendering exclusively.
		/// </summary>
		// Token: 0x06002EC2 RID: 11970 RVA: 0x000446EA File Offset: 0x000428EA
		public void SetRequestedRenderModeToOSPRay()
		{
			vtkSmartVolumeMapper.vtkSmartVolumeMapper_SetRequestedRenderModeToOSPRay_67(base.GetCppThis());
		}

		// Token: 0x06002EC3 RID: 11971
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSmartVolumeMapper_SetRequestedRenderModeToRayCast_68(HandleRef pThis);

		/// <summary>
		/// Set the requested render mode to vtkSmartVolumeMapper::RayCastRenderMode.
		/// This option will use software rendering exclusively. This is a good option
		/// if you know there is no hardware acceleration.
		/// </summary>
		// Token: 0x06002EC4 RID: 11972 RVA: 0x000446F9 File Offset: 0x000428F9
		public void SetRequestedRenderModeToRayCast()
		{
			vtkSmartVolumeMapper.vtkSmartVolumeMapper_SetRequestedRenderModeToRayCast_68(base.GetCppThis());
		}

		// Token: 0x06002EC5 RID: 11973
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSmartVolumeMapper_SetSampleDistance_69(HandleRef pThis, float _arg);

		/// <summary>
		/// Set/Get the distance between samples used for rendering
		/// when AutoAdjustSampleDistances is off, or when this mapper
		/// has more than 1 second allocated to it for rendering.
		/// If SampleDistance is negative, it will be computed based on the dataset
		/// spacing. Initial value is -1.0.
		/// </summary>
		// Token: 0x06002EC6 RID: 11974 RVA: 0x00044708 File Offset: 0x00042908
		public virtual void SetSampleDistance(float _arg)
		{
			vtkSmartVolumeMapper.vtkSmartVolumeMapper_SetSampleDistance_69(base.GetCppThis(), _arg);
		}

		// Token: 0x06002EC7 RID: 11975
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSmartVolumeMapper_SetTransfer2DYAxisArray_70(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the transfer 2D Y axis array
		/// </summary>
		// Token: 0x06002EC8 RID: 11976 RVA: 0x00044718 File Offset: 0x00042918
		public virtual void SetTransfer2DYAxisArray(string _arg)
		{
			vtkSmartVolumeMapper.vtkSmartVolumeMapper_SetTransfer2DYAxisArray_70(base.GetCppThis(), _arg);
		}

		// Token: 0x06002EC9 RID: 11977
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSmartVolumeMapper_SetUseJittering_71(HandleRef pThis, int _arg);

		/// <summary>
		/// If UseJittering is on, each ray traversal direction will be
		/// perturbed slightly using a noise-texture to get rid of wood-grain
		/// effect. This is only used by the GPU mapper.
		/// </summary>
		// Token: 0x06002ECA RID: 11978 RVA: 0x00044728 File Offset: 0x00042928
		public virtual void SetUseJittering(int _arg)
		{
			vtkSmartVolumeMapper.vtkSmartVolumeMapper_SetUseJittering_71(base.GetCppThis(), _arg);
		}

		// Token: 0x06002ECB RID: 11979
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSmartVolumeMapper_SetVectorComponent_72(HandleRef pThis, int _arg);

		/// <summary>
		/// VectorMode is a special rendering mode for 3-component vectors which makes
		/// use of GPURayCastMapper's independent-component capabilities. In this mode,
		/// a single component in the vector can be selected for rendering. In addition,
		/// the mapper can compute a scalar field representing the magnitude of this vector
		/// using a vtkImageMagnitude object (MAGNITUDE mode).
		/// </summary>
		// Token: 0x06002ECC RID: 11980 RVA: 0x00044738 File Offset: 0x00042938
		public virtual void SetVectorComponent(int _arg)
		{
			vtkSmartVolumeMapper.vtkSmartVolumeMapper_SetVectorComponent_72(base.GetCppThis(), _arg);
		}

		// Token: 0x06002ECD RID: 11981
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSmartVolumeMapper_SetVectorMode_73(HandleRef pThis, int mode);

		/// <summary>
		/// VectorMode is a special rendering mode for 3-component vectors which makes
		/// use of GPURayCastMapper's independent-component capabilities. In this mode,
		/// a single component in the vector can be selected for rendering. In addition,
		/// the mapper can compute a scalar field representing the magnitude of this vector
		/// using a vtkImageMagnitude object (MAGNITUDE mode).
		/// </summary>
		// Token: 0x06002ECE RID: 11982 RVA: 0x00044748 File Offset: 0x00042948
		public void SetVectorMode(int mode)
		{
			vtkSmartVolumeMapper.vtkSmartVolumeMapper_SetVectorMode_73(base.GetCppThis(), mode);
		}

		// Token: 0x06002ECF RID: 11983
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSmartVolumeMapper_SetVolumetricScatteringBlending_74(HandleRef pThis, float _arg);

		/// <summary>
		/// @copydoc vtkGPUVolumeRayCastMapper::SetVolumetricScatteringBlending(float)
		///
		/// This parameter is only used when the underlying mapper
		/// is a vtkGPUVolumeRayCastMapper.
		/// </summary>
		// Token: 0x06002ED0 RID: 11984 RVA: 0x00044758 File Offset: 0x00042958
		public virtual void SetVolumetricScatteringBlending(float _arg)
		{
			vtkSmartVolumeMapper.vtkSmartVolumeMapper_SetVolumetricScatteringBlending_74(base.GetCppThis(), _arg);
		}

		// Token: 0x06002ED1 RID: 11985
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSmartVolumeMapper_UseJitteringOff_75(HandleRef pThis);

		/// <summary>
		/// If UseJittering is on, each ray traversal direction will be
		/// perturbed slightly using a noise-texture to get rid of wood-grain
		/// effect. This is only used by the GPU mapper.
		/// </summary>
		// Token: 0x06002ED2 RID: 11986 RVA: 0x00044768 File Offset: 0x00042968
		public virtual void UseJitteringOff()
		{
			vtkSmartVolumeMapper.vtkSmartVolumeMapper_UseJitteringOff_75(base.GetCppThis());
		}

		// Token: 0x06002ED3 RID: 11987
		[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSmartVolumeMapper_UseJitteringOn_76(HandleRef pThis);

		/// <summary>
		/// If UseJittering is on, each ray traversal direction will be
		/// perturbed slightly using a noise-texture to get rid of wood-grain
		/// effect. This is only used by the GPU mapper.
		/// </summary>
		// Token: 0x06002ED4 RID: 11988 RVA: 0x00044777 File Offset: 0x00042977
		public virtual void UseJitteringOn()
		{
			vtkSmartVolumeMapper.vtkSmartVolumeMapper_UseJitteringOn_76(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040005B4 RID: 1460
		public new const string MRFullTypeName = "Kitware.VTK.vtkSmartVolumeMapper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040005B5 RID: 1461
		public new static readonly string MRClassNameKey = "class vtkSmartVolumeMapper";

		/// <summary>
		/// Get the final color level.
		/// </summary>
		// Token: 0x020000DD RID: 221
		public enum DefaultRenderMode_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x040005B7 RID: 1463
			DefaultRenderMode,
			/// <summary>enum member</summary>
			// Token: 0x040005B8 RID: 1464
			GPURenderMode = 2,
			/// <summary>enum member</summary>
			// Token: 0x040005B9 RID: 1465
			InvalidRenderMode = 5,
			/// <summary>enum member</summary>
			// Token: 0x040005BA RID: 1466
			OSPRayRenderMode = 3,
			/// <summary>enum member</summary>
			// Token: 0x040005BB RID: 1467
			RayCastRenderMode = 1,
			/// <summary>enum member</summary>
			// Token: 0x040005BC RID: 1468
			UndefinedRenderMode = 4
		}

		/// <summary>
		/// LowResDisable disables low res mode (default)
		/// LowResResample enable low res mode by automatically resampling the volume,
		/// this enable large volume to be displayed at higher frame rate at the cost of
		/// rendering quality
		/// Actual resample factor will be determined using MaxMemoryInBytes and MaxMemoryFraction
		/// </summary>
		// Token: 0x020000DE RID: 222
		public enum LowResModeType
		{
			/// <summary>enum member</summary>
			// Token: 0x040005BE RID: 1470
			LowResModeDisabled,
			/// <summary>enum member</summary>
			// Token: 0x040005BF RID: 1471
			LowResModeResample
		}

		/// <summary>
		/// VectorMode is a special rendering mode for 3-component vectors which makes
		/// use of GPURayCastMapper's independent-component capabilities. In this mode,
		/// a single component in the vector can be selected for rendering. In addition,
		/// the mapper can compute a scalar field representing the magnitude of this vector
		/// using a vtkImageMagnitude object (MAGNITUDE mode).
		/// </summary>
		// Token: 0x020000DF RID: 223
		public enum VectorModeType
		{
			/// <summary>enum member</summary>
			// Token: 0x040005C1 RID: 1473
			COMPONENT = 1,
			/// <summary>enum member</summary>
			// Token: 0x040005C2 RID: 1474
			DISABLED = -1,
			/// <summary>enum member</summary>
			// Token: 0x040005C3 RID: 1475
			MAGNITUDE
		}
	}
}
