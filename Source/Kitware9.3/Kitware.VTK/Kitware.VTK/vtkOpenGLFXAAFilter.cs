using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenGLFXAAFilter
	/// </summary>
	/// <remarks>
	///    Perform FXAA antialiasing on the current
	/// framebuffer.
	///
	///
	/// Call Execute() to run a FXAA antialiasing pass on the current OpenGL
	/// framebuffer. See method documentation for tunable parameters.
	///
	/// Based on the following implementation and description:
	///
	/// Whitepaper:
	/// http://developer.download.nvidia.com/assets/gamedev/files/sdk/11/FXAA_WhitePaper.pdf
	///
	/// Sample implementation:
	/// https://github.com/NVIDIAGameWorks/GraphicsSamples/blob/master/samples/es3-kepler/FXAA/FXAA3_11.h
	///
	/// TODO there are currently some "banding" artifacts on some edges, particularly
	/// single pixel lines. These seem to be caused by using a linear RGB input,
	/// rather than a gamma-correct sRGB input. Future work should combine this pass
	/// with a gamma correction pass to correct this. Bonus points for precomputing
	/// luminosity into the sRGB's alpha channel to save cycles in the FXAA shader!
	/// </remarks>
	// Token: 0x020005A3 RID: 1443
	public class vtkOpenGLFXAAFilter : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600FCFB RID: 64763 RVA: 0x00160863 File Offset: 0x0015EA63
		static vtkOpenGLFXAAFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLFXAAFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLFXAAFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600FCFC RID: 64764 RVA: 0x0016088B File Offset: 0x0015EA8B
		public vtkOpenGLFXAAFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600FCFD RID: 64765
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLFXAAFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FCFE RID: 64766 RVA: 0x0016089C File Offset: 0x0015EA9C
		public new static vtkOpenGLFXAAFilter New()
		{
			vtkOpenGLFXAAFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLFXAAFilter.vtkOpenGLFXAAFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLFXAAFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FCFF RID: 64767 RVA: 0x001608F0 File Offset: 0x0015EAF0
		public vtkOpenGLFXAAFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenGLFXAAFilter.vtkOpenGLFXAAFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600FD00 RID: 64768 RVA: 0x00160934 File Offset: 0x0015EB34
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600FD01 RID: 64769
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFXAAFilter_Execute_01(HandleRef pThis, HandleRef ren);

		/// <summary>
		/// Perform FXAA on the current render buffer in @a ren.
		/// </summary>
		// Token: 0x0600FD02 RID: 64770 RVA: 0x00160940 File Offset: 0x0015EB40
		public void Execute(vtkOpenGLRenderer ren)
		{
			vtkOpenGLFXAAFilter.vtkOpenGLFXAAFilter_Execute_01(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		// Token: 0x0600FD03 RID: 64771
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkFXAAOptions.DebugOption vtkOpenGLFXAAFilter_GetDebugOptionValue_02(HandleRef pThis);

		/// <summary>
		/// Parameter for tuning the FXAA implementation. See vtkFXAAOptions for
		/// details and suggested values.
		/// </summary>
		// Token: 0x0600FD04 RID: 64772 RVA: 0x00160970 File Offset: 0x0015EB70
		public virtual vtkFXAAOptions.DebugOption GetDebugOptionValue()
		{
			return vtkOpenGLFXAAFilter.vtkOpenGLFXAAFilter_GetDebugOptionValue_02(base.GetCppThis());
		}

		// Token: 0x0600FD05 RID: 64773
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLFXAAFilter_GetEndpointSearchIterations_03(HandleRef pThis);

		/// <summary>
		/// Parameter for tuning the FXAA implementation. See vtkFXAAOptions for
		/// details and suggested values.
		/// </summary>
		// Token: 0x0600FD06 RID: 64774 RVA: 0x00160990 File Offset: 0x0015EB90
		public virtual int GetEndpointSearchIterations()
		{
			return vtkOpenGLFXAAFilter.vtkOpenGLFXAAFilter_GetEndpointSearchIterations_03(base.GetCppThis());
		}

		// Token: 0x0600FD07 RID: 64775
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLFXAAFilter_GetEndpointSearchIterationsMaxValue_04(HandleRef pThis);

		/// <summary>
		/// Parameter for tuning the FXAA implementation. See vtkFXAAOptions for
		/// details and suggested values.
		/// </summary>
		// Token: 0x0600FD08 RID: 64776 RVA: 0x001609B0 File Offset: 0x0015EBB0
		public virtual int GetEndpointSearchIterationsMaxValue()
		{
			return vtkOpenGLFXAAFilter.vtkOpenGLFXAAFilter_GetEndpointSearchIterationsMaxValue_04(base.GetCppThis());
		}

		// Token: 0x0600FD09 RID: 64777
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLFXAAFilter_GetEndpointSearchIterationsMinValue_05(HandleRef pThis);

		/// <summary>
		/// Parameter for tuning the FXAA implementation. See vtkFXAAOptions for
		/// details and suggested values.
		/// </summary>
		// Token: 0x0600FD0A RID: 64778 RVA: 0x001609D0 File Offset: 0x0015EBD0
		public virtual int GetEndpointSearchIterationsMinValue()
		{
			return vtkOpenGLFXAAFilter.vtkOpenGLFXAAFilter_GetEndpointSearchIterationsMinValue_05(base.GetCppThis());
		}

		// Token: 0x0600FD0B RID: 64779
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkOpenGLFXAAFilter_GetHardContrastThreshold_06(HandleRef pThis);

		/// <summary>
		/// Parameter for tuning the FXAA implementation. See vtkFXAAOptions for
		/// details and suggested values.
		/// </summary>
		// Token: 0x0600FD0C RID: 64780 RVA: 0x001609F0 File Offset: 0x0015EBF0
		public virtual float GetHardContrastThreshold()
		{
			return vtkOpenGLFXAAFilter.vtkOpenGLFXAAFilter_GetHardContrastThreshold_06(base.GetCppThis());
		}

		// Token: 0x0600FD0D RID: 64781
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkOpenGLFXAAFilter_GetHardContrastThresholdMaxValue_07(HandleRef pThis);

		/// <summary>
		/// Parameter for tuning the FXAA implementation. See vtkFXAAOptions for
		/// details and suggested values.
		/// </summary>
		// Token: 0x0600FD0E RID: 64782 RVA: 0x00160A10 File Offset: 0x0015EC10
		public virtual float GetHardContrastThresholdMaxValue()
		{
			return vtkOpenGLFXAAFilter.vtkOpenGLFXAAFilter_GetHardContrastThresholdMaxValue_07(base.GetCppThis());
		}

		// Token: 0x0600FD0F RID: 64783
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkOpenGLFXAAFilter_GetHardContrastThresholdMinValue_08(HandleRef pThis);

		/// <summary>
		/// Parameter for tuning the FXAA implementation. See vtkFXAAOptions for
		/// details and suggested values.
		/// </summary>
		// Token: 0x0600FD10 RID: 64784 RVA: 0x00160A30 File Offset: 0x0015EC30
		public virtual float GetHardContrastThresholdMinValue()
		{
			return vtkOpenGLFXAAFilter.vtkOpenGLFXAAFilter_GetHardContrastThresholdMinValue_08(base.GetCppThis());
		}

		// Token: 0x0600FD11 RID: 64785
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLFXAAFilter_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FD12 RID: 64786 RVA: 0x00160A50 File Offset: 0x0015EC50
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenGLFXAAFilter.vtkOpenGLFXAAFilter_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x0600FD13 RID: 64787
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLFXAAFilter_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FD14 RID: 64788 RVA: 0x00160A70 File Offset: 0x0015EC70
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenGLFXAAFilter.vtkOpenGLFXAAFilter_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x0600FD15 RID: 64789
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkOpenGLFXAAFilter_GetRelativeContrastThreshold_11(HandleRef pThis);

		/// <summary>
		/// Parameter for tuning the FXAA implementation. See vtkFXAAOptions for
		/// details and suggested values.
		/// </summary>
		// Token: 0x0600FD16 RID: 64790 RVA: 0x00160A8C File Offset: 0x0015EC8C
		public virtual float GetRelativeContrastThreshold()
		{
			return vtkOpenGLFXAAFilter.vtkOpenGLFXAAFilter_GetRelativeContrastThreshold_11(base.GetCppThis());
		}

		// Token: 0x0600FD17 RID: 64791
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkOpenGLFXAAFilter_GetRelativeContrastThresholdMaxValue_12(HandleRef pThis);

		/// <summary>
		/// Parameter for tuning the FXAA implementation. See vtkFXAAOptions for
		/// details and suggested values.
		/// </summary>
		// Token: 0x0600FD18 RID: 64792 RVA: 0x00160AAC File Offset: 0x0015ECAC
		public virtual float GetRelativeContrastThresholdMaxValue()
		{
			return vtkOpenGLFXAAFilter.vtkOpenGLFXAAFilter_GetRelativeContrastThresholdMaxValue_12(base.GetCppThis());
		}

		// Token: 0x0600FD19 RID: 64793
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkOpenGLFXAAFilter_GetRelativeContrastThresholdMinValue_13(HandleRef pThis);

		/// <summary>
		/// Parameter for tuning the FXAA implementation. See vtkFXAAOptions for
		/// details and suggested values.
		/// </summary>
		// Token: 0x0600FD1A RID: 64794 RVA: 0x00160ACC File Offset: 0x0015ECCC
		public virtual float GetRelativeContrastThresholdMinValue()
		{
			return vtkOpenGLFXAAFilter.vtkOpenGLFXAAFilter_GetRelativeContrastThresholdMinValue_13(base.GetCppThis());
		}

		// Token: 0x0600FD1B RID: 64795
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkOpenGLFXAAFilter_GetSubpixelBlendLimit_14(HandleRef pThis);

		/// <summary>
		/// Parameter for tuning the FXAA implementation. See vtkFXAAOptions for
		/// details and suggested values.
		/// </summary>
		// Token: 0x0600FD1C RID: 64796 RVA: 0x00160AEC File Offset: 0x0015ECEC
		public virtual float GetSubpixelBlendLimit()
		{
			return vtkOpenGLFXAAFilter.vtkOpenGLFXAAFilter_GetSubpixelBlendLimit_14(base.GetCppThis());
		}

		// Token: 0x0600FD1D RID: 64797
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkOpenGLFXAAFilter_GetSubpixelBlendLimitMaxValue_15(HandleRef pThis);

		/// <summary>
		/// Parameter for tuning the FXAA implementation. See vtkFXAAOptions for
		/// details and suggested values.
		/// </summary>
		// Token: 0x0600FD1E RID: 64798 RVA: 0x00160B0C File Offset: 0x0015ED0C
		public virtual float GetSubpixelBlendLimitMaxValue()
		{
			return vtkOpenGLFXAAFilter.vtkOpenGLFXAAFilter_GetSubpixelBlendLimitMaxValue_15(base.GetCppThis());
		}

		// Token: 0x0600FD1F RID: 64799
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkOpenGLFXAAFilter_GetSubpixelBlendLimitMinValue_16(HandleRef pThis);

		/// <summary>
		/// Parameter for tuning the FXAA implementation. See vtkFXAAOptions for
		/// details and suggested values.
		/// </summary>
		// Token: 0x0600FD20 RID: 64800 RVA: 0x00160B2C File Offset: 0x0015ED2C
		public virtual float GetSubpixelBlendLimitMinValue()
		{
			return vtkOpenGLFXAAFilter.vtkOpenGLFXAAFilter_GetSubpixelBlendLimitMinValue_16(base.GetCppThis());
		}

		// Token: 0x0600FD21 RID: 64801
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkOpenGLFXAAFilter_GetSubpixelContrastThreshold_17(HandleRef pThis);

		/// <summary>
		/// Parameter for tuning the FXAA implementation. See vtkFXAAOptions for
		/// details and suggested values.
		/// </summary>
		// Token: 0x0600FD22 RID: 64802 RVA: 0x00160B4C File Offset: 0x0015ED4C
		public virtual float GetSubpixelContrastThreshold()
		{
			return vtkOpenGLFXAAFilter.vtkOpenGLFXAAFilter_GetSubpixelContrastThreshold_17(base.GetCppThis());
		}

		// Token: 0x0600FD23 RID: 64803
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkOpenGLFXAAFilter_GetSubpixelContrastThresholdMaxValue_18(HandleRef pThis);

		/// <summary>
		/// Parameter for tuning the FXAA implementation. See vtkFXAAOptions for
		/// details and suggested values.
		/// </summary>
		// Token: 0x0600FD24 RID: 64804 RVA: 0x00160B6C File Offset: 0x0015ED6C
		public virtual float GetSubpixelContrastThresholdMaxValue()
		{
			return vtkOpenGLFXAAFilter.vtkOpenGLFXAAFilter_GetSubpixelContrastThresholdMaxValue_18(base.GetCppThis());
		}

		// Token: 0x0600FD25 RID: 64805
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkOpenGLFXAAFilter_GetSubpixelContrastThresholdMinValue_19(HandleRef pThis);

		/// <summary>
		/// Parameter for tuning the FXAA implementation. See vtkFXAAOptions for
		/// details and suggested values.
		/// </summary>
		// Token: 0x0600FD26 RID: 64806 RVA: 0x00160B8C File Offset: 0x0015ED8C
		public virtual float GetSubpixelContrastThresholdMinValue()
		{
			return vtkOpenGLFXAAFilter.vtkOpenGLFXAAFilter_GetSubpixelContrastThresholdMinValue_19(base.GetCppThis());
		}

		// Token: 0x0600FD27 RID: 64807
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenGLFXAAFilter_GetUseHighQualityEndpoints_20(HandleRef pThis);

		/// <summary>
		/// Parameter for tuning the FXAA implementation. See vtkFXAAOptions for
		/// details and suggested values.
		/// </summary>
		// Token: 0x0600FD28 RID: 64808 RVA: 0x00160BAC File Offset: 0x0015EDAC
		public virtual bool GetUseHighQualityEndpoints()
		{
			return vtkOpenGLFXAAFilter.vtkOpenGLFXAAFilter_GetUseHighQualityEndpoints_20(base.GetCppThis()) != 0;
		}

		// Token: 0x0600FD29 RID: 64809
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLFXAAFilter_IsA_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FD2A RID: 64810 RVA: 0x00160BD4 File Offset: 0x0015EDD4
		public override int IsA(string type)
		{
			return vtkOpenGLFXAAFilter.vtkOpenGLFXAAFilter_IsA_21(base.GetCppThis(), type);
		}

		// Token: 0x0600FD2B RID: 64811
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLFXAAFilter_IsTypeOf_22([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FD2C RID: 64812 RVA: 0x00160BF4 File Offset: 0x0015EDF4
		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLFXAAFilter.vtkOpenGLFXAAFilter_IsTypeOf_22(type);
		}

		// Token: 0x0600FD2D RID: 64813
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLFXAAFilter_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FD2E RID: 64814 RVA: 0x00160C10 File Offset: 0x0015EE10
		public new vtkOpenGLFXAAFilter NewInstance()
		{
			vtkOpenGLFXAAFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLFXAAFilter.vtkOpenGLFXAAFilter_NewInstance_24(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLFXAAFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600FD2F RID: 64815
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFXAAFilter_ReleaseGraphicsResources_25(HandleRef pThis);

		/// <summary>
		/// Release all OpenGL state.
		/// </summary>
		// Token: 0x0600FD30 RID: 64816 RVA: 0x00160C6A File Offset: 0x0015EE6A
		public void ReleaseGraphicsResources()
		{
			vtkOpenGLFXAAFilter.vtkOpenGLFXAAFilter_ReleaseGraphicsResources_25(base.GetCppThis());
		}

		// Token: 0x0600FD31 RID: 64817
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLFXAAFilter_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FD32 RID: 64818 RVA: 0x00160C7C File Offset: 0x0015EE7C
		public new static vtkOpenGLFXAAFilter SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLFXAAFilter vtkOpenGLFXAAFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLFXAAFilter.vtkOpenGLFXAAFilter_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLFXAAFilter = (vtkOpenGLFXAAFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLFXAAFilter.Register(null);
				}
			}
			return vtkOpenGLFXAAFilter;
		}

		// Token: 0x0600FD33 RID: 64819
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFXAAFilter_SetDebugOptionValue_27(HandleRef pThis, vtkFXAAOptions.DebugOption opt);

		/// <summary>
		/// Parameter for tuning the FXAA implementation. See vtkFXAAOptions for
		/// details and suggested values.
		/// </summary>
		// Token: 0x0600FD34 RID: 64820 RVA: 0x00160CFB File Offset: 0x0015EEFB
		public virtual void SetDebugOptionValue(vtkFXAAOptions.DebugOption opt)
		{
			vtkOpenGLFXAAFilter.vtkOpenGLFXAAFilter_SetDebugOptionValue_27(base.GetCppThis(), opt);
		}

		// Token: 0x0600FD35 RID: 64821
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFXAAFilter_SetEndpointSearchIterations_28(HandleRef pThis, int _arg);

		/// <summary>
		/// Parameter for tuning the FXAA implementation. See vtkFXAAOptions for
		/// details and suggested values.
		/// </summary>
		// Token: 0x0600FD36 RID: 64822 RVA: 0x00160D0B File Offset: 0x0015EF0B
		public virtual void SetEndpointSearchIterations(int _arg)
		{
			vtkOpenGLFXAAFilter.vtkOpenGLFXAAFilter_SetEndpointSearchIterations_28(base.GetCppThis(), _arg);
		}

		// Token: 0x0600FD37 RID: 64823
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFXAAFilter_SetHardContrastThreshold_29(HandleRef pThis, float _arg);

		/// <summary>
		/// Parameter for tuning the FXAA implementation. See vtkFXAAOptions for
		/// details and suggested values.
		/// </summary>
		// Token: 0x0600FD38 RID: 64824 RVA: 0x00160D1B File Offset: 0x0015EF1B
		public virtual void SetHardContrastThreshold(float _arg)
		{
			vtkOpenGLFXAAFilter.vtkOpenGLFXAAFilter_SetHardContrastThreshold_29(base.GetCppThis(), _arg);
		}

		// Token: 0x0600FD39 RID: 64825
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFXAAFilter_SetRelativeContrastThreshold_30(HandleRef pThis, float _arg);

		/// <summary>
		/// Parameter for tuning the FXAA implementation. See vtkFXAAOptions for
		/// details and suggested values.
		/// </summary>
		// Token: 0x0600FD3A RID: 64826 RVA: 0x00160D2B File Offset: 0x0015EF2B
		public virtual void SetRelativeContrastThreshold(float _arg)
		{
			vtkOpenGLFXAAFilter.vtkOpenGLFXAAFilter_SetRelativeContrastThreshold_30(base.GetCppThis(), _arg);
		}

		// Token: 0x0600FD3B RID: 64827
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFXAAFilter_SetSubpixelBlendLimit_31(HandleRef pThis, float _arg);

		/// <summary>
		/// Parameter for tuning the FXAA implementation. See vtkFXAAOptions for
		/// details and suggested values.
		/// </summary>
		// Token: 0x0600FD3C RID: 64828 RVA: 0x00160D3B File Offset: 0x0015EF3B
		public virtual void SetSubpixelBlendLimit(float _arg)
		{
			vtkOpenGLFXAAFilter.vtkOpenGLFXAAFilter_SetSubpixelBlendLimit_31(base.GetCppThis(), _arg);
		}

		// Token: 0x0600FD3D RID: 64829
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFXAAFilter_SetSubpixelContrastThreshold_32(HandleRef pThis, float _arg);

		/// <summary>
		/// Parameter for tuning the FXAA implementation. See vtkFXAAOptions for
		/// details and suggested values.
		/// </summary>
		// Token: 0x0600FD3E RID: 64830 RVA: 0x00160D4B File Offset: 0x0015EF4B
		public virtual void SetSubpixelContrastThreshold(float _arg)
		{
			vtkOpenGLFXAAFilter.vtkOpenGLFXAAFilter_SetSubpixelContrastThreshold_32(base.GetCppThis(), _arg);
		}

		// Token: 0x0600FD3F RID: 64831
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFXAAFilter_SetUseHighQualityEndpoints_33(HandleRef pThis, byte val);

		/// <summary>
		/// Parameter for tuning the FXAA implementation. See vtkFXAAOptions for
		/// details and suggested values.
		/// </summary>
		// Token: 0x0600FD40 RID: 64832 RVA: 0x00160D5B File Offset: 0x0015EF5B
		public virtual void SetUseHighQualityEndpoints(bool val)
		{
			vtkOpenGLFXAAFilter.vtkOpenGLFXAAFilter_SetUseHighQualityEndpoints_33(base.GetCppThis(), val ? (byte)1 : (byte)0);
		}

		// Token: 0x0600FD41 RID: 64833
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFXAAFilter_UpdateConfiguration_34(HandleRef pThis, HandleRef opts);

		/// <summary>
		/// Copy the configuration values from @a opts into this filter. Note that
		/// this copies the configuration values from opts -- it does not save the
		/// @a opts pointer.
		/// </summary>
		// Token: 0x0600FD42 RID: 64834 RVA: 0x00160D74 File Offset: 0x0015EF74
		public void UpdateConfiguration(vtkFXAAOptions opts)
		{
			vtkOpenGLFXAAFilter.vtkOpenGLFXAAFilter_UpdateConfiguration_34(base.GetCppThis(), (opts == null) ? default(HandleRef) : opts.GetCppThis());
		}

		// Token: 0x0600FD43 RID: 64835
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFXAAFilter_UseHighQualityEndpointsOff_35(HandleRef pThis);

		/// <summary>
		/// Parameter for tuning the FXAA implementation. See vtkFXAAOptions for
		/// details and suggested values.
		/// </summary>
		// Token: 0x0600FD44 RID: 64836 RVA: 0x00160DA3 File Offset: 0x0015EFA3
		public virtual void UseHighQualityEndpointsOff()
		{
			vtkOpenGLFXAAFilter.vtkOpenGLFXAAFilter_UseHighQualityEndpointsOff_35(base.GetCppThis());
		}

		// Token: 0x0600FD45 RID: 64837
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFXAAFilter_UseHighQualityEndpointsOn_36(HandleRef pThis);

		/// <summary>
		/// Parameter for tuning the FXAA implementation. See vtkFXAAOptions for
		/// details and suggested values.
		/// </summary>
		// Token: 0x0600FD46 RID: 64838 RVA: 0x00160DB2 File Offset: 0x0015EFB2
		public virtual void UseHighQualityEndpointsOn()
		{
			vtkOpenGLFXAAFilter.vtkOpenGLFXAAFilter_UseHighQualityEndpointsOn_36(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001271 RID: 4721
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLFXAAFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001272 RID: 4722
		public new static readonly string MRClassNameKey = "class vtkOpenGLFXAAFilter";
	}
}
