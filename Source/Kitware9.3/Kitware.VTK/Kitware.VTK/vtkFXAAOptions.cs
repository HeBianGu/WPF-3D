using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkFXAAOptions
	/// </summary>
	/// <remarks>
	///    Configuration for FXAA implementations.
	///
	///
	/// This class encapsulates the settings for vtkOpenGLFXAAFilter.
	/// </remarks>
	// Token: 0x020007DC RID: 2012
	public class vtkFXAAOptions : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06014A8C RID: 84620 RVA: 0x001D3FD7 File Offset: 0x001D21D7
		static vtkFXAAOptions()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFXAAOptions.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFXAAOptions"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06014A8D RID: 84621 RVA: 0x001D3FFF File Offset: 0x001D21FF
		public vtkFXAAOptions(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06014A8E RID: 84622
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFXAAOptions_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Debugging options that affect the output color buffer. See
		/// vtkFXAAFilterFS.glsl for details.
		/// </summary>
		// Token: 0x06014A8F RID: 84623 RVA: 0x001D4010 File Offset: 0x001D2210
		public new static vtkFXAAOptions New()
		{
			vtkFXAAOptions result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFXAAOptions.vtkFXAAOptions_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFXAAOptions)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Debugging options that affect the output color buffer. See
		/// vtkFXAAFilterFS.glsl for details.
		/// </summary>
		// Token: 0x06014A90 RID: 84624 RVA: 0x001D4064 File Offset: 0x001D2264
		public vtkFXAAOptions() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkFXAAOptions.vtkFXAAOptions_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06014A91 RID: 84625 RVA: 0x001D40A8 File Offset: 0x001D22A8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06014A92 RID: 84626
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkFXAAOptions.DebugOption vtkFXAAOptions_GetDebugOptionValue_01(HandleRef pThis);

		/// <summary>
		/// Debugging options that affect the output color buffer. See
		/// vtkFXAAFilterFS.glsl for details. Only one may be active at a time.
		/// </summary>
		// Token: 0x06014A93 RID: 84627 RVA: 0x001D40B4 File Offset: 0x001D22B4
		public virtual vtkFXAAOptions.DebugOption GetDebugOptionValue()
		{
			return vtkFXAAOptions.vtkFXAAOptions_GetDebugOptionValue_01(base.GetCppThis());
		}

		// Token: 0x06014A94 RID: 84628
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFXAAOptions_GetEndpointSearchIterations_02(HandleRef pThis);

		/// <summary>
		/// Set the number of iterations for the endpoint search algorithm. Increasing
		/// this value will increase runtime, but also properly detect longer edges.
		/// The current implementation steps one pixel in both the positive and
		/// negative directions per iteration. The default value is 12, which will
		/// resolve endpoints of edges &lt; 25 pixels long (2 * 12 + 1).
		/// </summary>
		// Token: 0x06014A95 RID: 84629 RVA: 0x001D40D4 File Offset: 0x001D22D4
		public virtual int GetEndpointSearchIterations()
		{
			return vtkFXAAOptions.vtkFXAAOptions_GetEndpointSearchIterations_02(base.GetCppThis());
		}

		// Token: 0x06014A96 RID: 84630
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFXAAOptions_GetEndpointSearchIterationsMaxValue_03(HandleRef pThis);

		/// <summary>
		/// Set the number of iterations for the endpoint search algorithm. Increasing
		/// this value will increase runtime, but also properly detect longer edges.
		/// The current implementation steps one pixel in both the positive and
		/// negative directions per iteration. The default value is 12, which will
		/// resolve endpoints of edges &lt; 25 pixels long (2 * 12 + 1).
		/// </summary>
		// Token: 0x06014A97 RID: 84631 RVA: 0x001D40F4 File Offset: 0x001D22F4
		public virtual int GetEndpointSearchIterationsMaxValue()
		{
			return vtkFXAAOptions.vtkFXAAOptions_GetEndpointSearchIterationsMaxValue_03(base.GetCppThis());
		}

		// Token: 0x06014A98 RID: 84632
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFXAAOptions_GetEndpointSearchIterationsMinValue_04(HandleRef pThis);

		/// <summary>
		/// Set the number of iterations for the endpoint search algorithm. Increasing
		/// this value will increase runtime, but also properly detect longer edges.
		/// The current implementation steps one pixel in both the positive and
		/// negative directions per iteration. The default value is 12, which will
		/// resolve endpoints of edges &lt; 25 pixels long (2 * 12 + 1).
		/// </summary>
		// Token: 0x06014A99 RID: 84633 RVA: 0x001D4114 File Offset: 0x001D2314
		public virtual int GetEndpointSearchIterationsMinValue()
		{
			return vtkFXAAOptions.vtkFXAAOptions_GetEndpointSearchIterationsMinValue_04(base.GetCppThis());
		}

		// Token: 0x06014A9A RID: 84634
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkFXAAOptions_GetHardContrastThreshold_05(HandleRef pThis);

		/// <summary>
		/// Similar to RelativeContrastThreshold, but not scaled by the maximum
		/// luminosity.
		///
		/// If the contrast of the current pixel and it's 4 immediate NSWE neighbors is
		/// less than HardContrastThreshold, the pixel is not considered aliased and
		/// will not be affected by FXAA.
		///
		/// Suggested settings:
		/// - 1/32: Visible limit
		/// - 1/16: High quality (default)
		/// - 1/12: Upper limit (start of visible unfiltered edges)
		/// </summary>
		// Token: 0x06014A9B RID: 84635 RVA: 0x001D4134 File Offset: 0x001D2334
		public virtual float GetHardContrastThreshold()
		{
			return vtkFXAAOptions.vtkFXAAOptions_GetHardContrastThreshold_05(base.GetCppThis());
		}

		// Token: 0x06014A9C RID: 84636
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkFXAAOptions_GetHardContrastThresholdMaxValue_06(HandleRef pThis);

		/// <summary>
		/// Similar to RelativeContrastThreshold, but not scaled by the maximum
		/// luminosity.
		///
		/// If the contrast of the current pixel and it's 4 immediate NSWE neighbors is
		/// less than HardContrastThreshold, the pixel is not considered aliased and
		/// will not be affected by FXAA.
		///
		/// Suggested settings:
		/// - 1/32: Visible limit
		/// - 1/16: High quality (default)
		/// - 1/12: Upper limit (start of visible unfiltered edges)
		/// </summary>
		// Token: 0x06014A9D RID: 84637 RVA: 0x001D4154 File Offset: 0x001D2354
		public virtual float GetHardContrastThresholdMaxValue()
		{
			return vtkFXAAOptions.vtkFXAAOptions_GetHardContrastThresholdMaxValue_06(base.GetCppThis());
		}

		// Token: 0x06014A9E RID: 84638
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkFXAAOptions_GetHardContrastThresholdMinValue_07(HandleRef pThis);

		/// <summary>
		/// Similar to RelativeContrastThreshold, but not scaled by the maximum
		/// luminosity.
		///
		/// If the contrast of the current pixel and it's 4 immediate NSWE neighbors is
		/// less than HardContrastThreshold, the pixel is not considered aliased and
		/// will not be affected by FXAA.
		///
		/// Suggested settings:
		/// - 1/32: Visible limit
		/// - 1/16: High quality (default)
		/// - 1/12: Upper limit (start of visible unfiltered edges)
		/// </summary>
		// Token: 0x06014A9F RID: 84639 RVA: 0x001D4174 File Offset: 0x001D2374
		public virtual float GetHardContrastThresholdMinValue()
		{
			return vtkFXAAOptions.vtkFXAAOptions_GetHardContrastThresholdMinValue_07(base.GetCppThis());
		}

		// Token: 0x06014AA0 RID: 84640
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFXAAOptions_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Debugging options that affect the output color buffer. See
		/// vtkFXAAFilterFS.glsl for details.
		/// </summary>
		// Token: 0x06014AA1 RID: 84641 RVA: 0x001D4194 File Offset: 0x001D2394
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkFXAAOptions.vtkFXAAOptions_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x06014AA2 RID: 84642
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFXAAOptions_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Debugging options that affect the output color buffer. See
		/// vtkFXAAFilterFS.glsl for details.
		/// </summary>
		// Token: 0x06014AA3 RID: 84643 RVA: 0x001D41B4 File Offset: 0x001D23B4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkFXAAOptions.vtkFXAAOptions_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x06014AA4 RID: 84644
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkFXAAOptions_GetRelativeContrastThreshold_10(HandleRef pThis);

		/// <summary>
		/// Threshold for applying FXAA to a pixel, relative to the maximum luminosity
		/// of its 4 immediate neighbors.
		///
		/// The luminosity of the current pixel and it's NSWE neighbors is computed.
		/// The maximum luminosity and luminosity range (contrast) of all 5 pixels is
		/// found. If the contrast is less than RelativeContrastThreshold * maxLum,
		/// the pixel is not considered aliased and will not be affected by FXAA.
		///
		/// Suggested settings:
		/// - 1/3: Too little
		/// - 1/4: Low quality
		/// - 1/8: High quality (default)
		/// - 1/16: Overkill
		/// </summary>
		// Token: 0x06014AA5 RID: 84645 RVA: 0x001D41D0 File Offset: 0x001D23D0
		public virtual float GetRelativeContrastThreshold()
		{
			return vtkFXAAOptions.vtkFXAAOptions_GetRelativeContrastThreshold_10(base.GetCppThis());
		}

		// Token: 0x06014AA6 RID: 84646
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkFXAAOptions_GetRelativeContrastThresholdMaxValue_11(HandleRef pThis);

		/// <summary>
		/// Threshold for applying FXAA to a pixel, relative to the maximum luminosity
		/// of its 4 immediate neighbors.
		///
		/// The luminosity of the current pixel and it's NSWE neighbors is computed.
		/// The maximum luminosity and luminosity range (contrast) of all 5 pixels is
		/// found. If the contrast is less than RelativeContrastThreshold * maxLum,
		/// the pixel is not considered aliased and will not be affected by FXAA.
		///
		/// Suggested settings:
		/// - 1/3: Too little
		/// - 1/4: Low quality
		/// - 1/8: High quality (default)
		/// - 1/16: Overkill
		/// </summary>
		// Token: 0x06014AA7 RID: 84647 RVA: 0x001D41F0 File Offset: 0x001D23F0
		public virtual float GetRelativeContrastThresholdMaxValue()
		{
			return vtkFXAAOptions.vtkFXAAOptions_GetRelativeContrastThresholdMaxValue_11(base.GetCppThis());
		}

		// Token: 0x06014AA8 RID: 84648
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkFXAAOptions_GetRelativeContrastThresholdMinValue_12(HandleRef pThis);

		/// <summary>
		/// Threshold for applying FXAA to a pixel, relative to the maximum luminosity
		/// of its 4 immediate neighbors.
		///
		/// The luminosity of the current pixel and it's NSWE neighbors is computed.
		/// The maximum luminosity and luminosity range (contrast) of all 5 pixels is
		/// found. If the contrast is less than RelativeContrastThreshold * maxLum,
		/// the pixel is not considered aliased and will not be affected by FXAA.
		///
		/// Suggested settings:
		/// - 1/3: Too little
		/// - 1/4: Low quality
		/// - 1/8: High quality (default)
		/// - 1/16: Overkill
		/// </summary>
		// Token: 0x06014AA9 RID: 84649 RVA: 0x001D4210 File Offset: 0x001D2410
		public virtual float GetRelativeContrastThresholdMinValue()
		{
			return vtkFXAAOptions.vtkFXAAOptions_GetRelativeContrastThresholdMinValue_12(base.GetCppThis());
		}

		// Token: 0x06014AAA RID: 84650
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkFXAAOptions_GetSubpixelBlendLimit_13(HandleRef pThis);

		/// <summary>
		/// Subpixel aliasing is corrected by applying a lowpass filter to the current
		/// pixel. This is implemented by blending an average of the 3x3 neighborhood
		/// around the pixel into the final result. The amount of blending is
		/// determined by comparing the detected amount of subpixel aliasing to the
		/// total contrasting of the CNSWE pixels:
		///
		/// SubpixelBlending = abs(lumC - lumAveNSWE) / (lumMaxCNSWE - lumMinCNSWE)
		///
		/// This parameter sets an upper limit to the amount of subpixel blending to
		/// prevent the image from simply getting blurred.
		///
		/// Suggested settings:
		/// - 1/2: Low amount of blending.
		/// - 3/4: Medium amount of blending (default)
		/// - 7/8: High amount of blending.
		/// - 1: Maximum amount of blending.
		/// </summary>
		// Token: 0x06014AAB RID: 84651 RVA: 0x001D4230 File Offset: 0x001D2430
		public virtual float GetSubpixelBlendLimit()
		{
			return vtkFXAAOptions.vtkFXAAOptions_GetSubpixelBlendLimit_13(base.GetCppThis());
		}

		// Token: 0x06014AAC RID: 84652
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkFXAAOptions_GetSubpixelBlendLimitMaxValue_14(HandleRef pThis);

		/// <summary>
		/// Subpixel aliasing is corrected by applying a lowpass filter to the current
		/// pixel. This is implemented by blending an average of the 3x3 neighborhood
		/// around the pixel into the final result. The amount of blending is
		/// determined by comparing the detected amount of subpixel aliasing to the
		/// total contrasting of the CNSWE pixels:
		///
		/// SubpixelBlending = abs(lumC - lumAveNSWE) / (lumMaxCNSWE - lumMinCNSWE)
		///
		/// This parameter sets an upper limit to the amount of subpixel blending to
		/// prevent the image from simply getting blurred.
		///
		/// Suggested settings:
		/// - 1/2: Low amount of blending.
		/// - 3/4: Medium amount of blending (default)
		/// - 7/8: High amount of blending.
		/// - 1: Maximum amount of blending.
		/// </summary>
		// Token: 0x06014AAD RID: 84653 RVA: 0x001D4250 File Offset: 0x001D2450
		public virtual float GetSubpixelBlendLimitMaxValue()
		{
			return vtkFXAAOptions.vtkFXAAOptions_GetSubpixelBlendLimitMaxValue_14(base.GetCppThis());
		}

		// Token: 0x06014AAE RID: 84654
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkFXAAOptions_GetSubpixelBlendLimitMinValue_15(HandleRef pThis);

		/// <summary>
		/// Subpixel aliasing is corrected by applying a lowpass filter to the current
		/// pixel. This is implemented by blending an average of the 3x3 neighborhood
		/// around the pixel into the final result. The amount of blending is
		/// determined by comparing the detected amount of subpixel aliasing to the
		/// total contrasting of the CNSWE pixels:
		///
		/// SubpixelBlending = abs(lumC - lumAveNSWE) / (lumMaxCNSWE - lumMinCNSWE)
		///
		/// This parameter sets an upper limit to the amount of subpixel blending to
		/// prevent the image from simply getting blurred.
		///
		/// Suggested settings:
		/// - 1/2: Low amount of blending.
		/// - 3/4: Medium amount of blending (default)
		/// - 7/8: High amount of blending.
		/// - 1: Maximum amount of blending.
		/// </summary>
		// Token: 0x06014AAF RID: 84655 RVA: 0x001D4270 File Offset: 0x001D2470
		public virtual float GetSubpixelBlendLimitMinValue()
		{
			return vtkFXAAOptions.vtkFXAAOptions_GetSubpixelBlendLimitMinValue_15(base.GetCppThis());
		}

		// Token: 0x06014AB0 RID: 84656
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkFXAAOptions_GetSubpixelContrastThreshold_16(HandleRef pThis);

		/// <summary>
		/// Minimum amount of subpixel aliasing required for subpixel antialiasing to
		/// be applied.
		///
		/// Subpixel aliasing is corrected by applying a lowpass filter to the current
		/// pixel. This is implemented by blending an average of the 3x3 neighborhood
		/// around the pixel into the final result. The amount of blending is
		/// determined by comparing the detected amount of subpixel aliasing to the
		/// total contrasting of the CNSWE pixels:
		///
		/// SubpixelBlending = abs(lumC - lumAveNSWE) / (lumMaxCNSWE - lumMinCNSWE)
		///
		/// If SubpixelBlending is less than this threshold, no lowpass blending will
		/// occur.
		///
		/// Suggested settings:
		/// - 1/2: Low subpixel aliasing removal
		/// - 1/3: Medium subpixel aliasing removal
		/// - 1/4: Default subpixel aliasing removal
		/// - 1/8: High subpixel aliasing removal
		/// - 0: Complete subpixel aliasing removal
		/// </summary>
		// Token: 0x06014AB1 RID: 84657 RVA: 0x001D4290 File Offset: 0x001D2490
		public virtual float GetSubpixelContrastThreshold()
		{
			return vtkFXAAOptions.vtkFXAAOptions_GetSubpixelContrastThreshold_16(base.GetCppThis());
		}

		// Token: 0x06014AB2 RID: 84658
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkFXAAOptions_GetSubpixelContrastThresholdMaxValue_17(HandleRef pThis);

		/// <summary>
		/// Minimum amount of subpixel aliasing required for subpixel antialiasing to
		/// be applied.
		///
		/// Subpixel aliasing is corrected by applying a lowpass filter to the current
		/// pixel. This is implemented by blending an average of the 3x3 neighborhood
		/// around the pixel into the final result. The amount of blending is
		/// determined by comparing the detected amount of subpixel aliasing to the
		/// total contrasting of the CNSWE pixels:
		///
		/// SubpixelBlending = abs(lumC - lumAveNSWE) / (lumMaxCNSWE - lumMinCNSWE)
		///
		/// If SubpixelBlending is less than this threshold, no lowpass blending will
		/// occur.
		///
		/// Suggested settings:
		/// - 1/2: Low subpixel aliasing removal
		/// - 1/3: Medium subpixel aliasing removal
		/// - 1/4: Default subpixel aliasing removal
		/// - 1/8: High subpixel aliasing removal
		/// - 0: Complete subpixel aliasing removal
		/// </summary>
		// Token: 0x06014AB3 RID: 84659 RVA: 0x001D42B0 File Offset: 0x001D24B0
		public virtual float GetSubpixelContrastThresholdMaxValue()
		{
			return vtkFXAAOptions.vtkFXAAOptions_GetSubpixelContrastThresholdMaxValue_17(base.GetCppThis());
		}

		// Token: 0x06014AB4 RID: 84660
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkFXAAOptions_GetSubpixelContrastThresholdMinValue_18(HandleRef pThis);

		/// <summary>
		/// Minimum amount of subpixel aliasing required for subpixel antialiasing to
		/// be applied.
		///
		/// Subpixel aliasing is corrected by applying a lowpass filter to the current
		/// pixel. This is implemented by blending an average of the 3x3 neighborhood
		/// around the pixel into the final result. The amount of blending is
		/// determined by comparing the detected amount of subpixel aliasing to the
		/// total contrasting of the CNSWE pixels:
		///
		/// SubpixelBlending = abs(lumC - lumAveNSWE) / (lumMaxCNSWE - lumMinCNSWE)
		///
		/// If SubpixelBlending is less than this threshold, no lowpass blending will
		/// occur.
		///
		/// Suggested settings:
		/// - 1/2: Low subpixel aliasing removal
		/// - 1/3: Medium subpixel aliasing removal
		/// - 1/4: Default subpixel aliasing removal
		/// - 1/8: High subpixel aliasing removal
		/// - 0: Complete subpixel aliasing removal
		/// </summary>
		// Token: 0x06014AB5 RID: 84661 RVA: 0x001D42D0 File Offset: 0x001D24D0
		public virtual float GetSubpixelContrastThresholdMinValue()
		{
			return vtkFXAAOptions.vtkFXAAOptions_GetSubpixelContrastThresholdMinValue_18(base.GetCppThis());
		}

		// Token: 0x06014AB6 RID: 84662
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkFXAAOptions_GetUseHighQualityEndpoints_19(HandleRef pThis);

		/// <summary>
		/// Use an improved edge endpoint detection algorithm.
		///
		/// If true, a modified edge endpoint detection algorithm is used that requires
		/// more texture lookups, but will properly detect aliased single-pixel lines.
		///
		/// If false, the edge endpoint algorithm proposed by NVIDIA will by used. This
		/// algorithm is faster (fewer lookups), but will fail to detect endpoints of
		/// single pixel edge steps.
		///
		/// Default setting is true.
		/// </summary>
		// Token: 0x06014AB7 RID: 84663 RVA: 0x001D42F0 File Offset: 0x001D24F0
		public virtual bool GetUseHighQualityEndpoints()
		{
			return vtkFXAAOptions.vtkFXAAOptions_GetUseHighQualityEndpoints_19(base.GetCppThis()) != 0;
		}

		// Token: 0x06014AB8 RID: 84664
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFXAAOptions_IsA_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Debugging options that affect the output color buffer. See
		/// vtkFXAAFilterFS.glsl for details.
		/// </summary>
		// Token: 0x06014AB9 RID: 84665 RVA: 0x001D4318 File Offset: 0x001D2518
		public override int IsA(string type)
		{
			return vtkFXAAOptions.vtkFXAAOptions_IsA_20(base.GetCppThis(), type);
		}

		// Token: 0x06014ABA RID: 84666
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFXAAOptions_IsTypeOf_21([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Debugging options that affect the output color buffer. See
		/// vtkFXAAFilterFS.glsl for details.
		/// </summary>
		// Token: 0x06014ABB RID: 84667 RVA: 0x001D4338 File Offset: 0x001D2538
		public new static int IsTypeOf(string type)
		{
			return vtkFXAAOptions.vtkFXAAOptions_IsTypeOf_21(type);
		}

		// Token: 0x06014ABC RID: 84668
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFXAAOptions_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Debugging options that affect the output color buffer. See
		/// vtkFXAAFilterFS.glsl for details.
		/// </summary>
		// Token: 0x06014ABD RID: 84669 RVA: 0x001D4354 File Offset: 0x001D2554
		public new vtkFXAAOptions NewInstance()
		{
			vtkFXAAOptions result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFXAAOptions.vtkFXAAOptions_NewInstance_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFXAAOptions)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014ABE RID: 84670
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFXAAOptions_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Debugging options that affect the output color buffer. See
		/// vtkFXAAFilterFS.glsl for details.
		/// </summary>
		// Token: 0x06014ABF RID: 84671 RVA: 0x001D43B0 File Offset: 0x001D25B0
		public new static vtkFXAAOptions SafeDownCast(vtkObjectBase o)
		{
			vtkFXAAOptions vtkFXAAOptions = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFXAAOptions.vtkFXAAOptions_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFXAAOptions = (vtkFXAAOptions)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFXAAOptions.Register(null);
				}
			}
			return vtkFXAAOptions;
		}

		// Token: 0x06014AC0 RID: 84672
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFXAAOptions_SetDebugOptionValue_25(HandleRef pThis, vtkFXAAOptions.DebugOption _arg);

		/// <summary>
		/// Debugging options that affect the output color buffer. See
		/// vtkFXAAFilterFS.glsl for details. Only one may be active at a time.
		/// </summary>
		// Token: 0x06014AC1 RID: 84673 RVA: 0x001D442F File Offset: 0x001D262F
		public virtual void SetDebugOptionValue(vtkFXAAOptions.DebugOption _arg)
		{
			vtkFXAAOptions.vtkFXAAOptions_SetDebugOptionValue_25(base.GetCppThis(), _arg);
		}

		// Token: 0x06014AC2 RID: 84674
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFXAAOptions_SetEndpointSearchIterations_26(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the number of iterations for the endpoint search algorithm. Increasing
		/// this value will increase runtime, but also properly detect longer edges.
		/// The current implementation steps one pixel in both the positive and
		/// negative directions per iteration. The default value is 12, which will
		/// resolve endpoints of edges &lt; 25 pixels long (2 * 12 + 1).
		/// </summary>
		// Token: 0x06014AC3 RID: 84675 RVA: 0x001D443F File Offset: 0x001D263F
		public virtual void SetEndpointSearchIterations(int _arg)
		{
			vtkFXAAOptions.vtkFXAAOptions_SetEndpointSearchIterations_26(base.GetCppThis(), _arg);
		}

		// Token: 0x06014AC4 RID: 84676
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFXAAOptions_SetHardContrastThreshold_27(HandleRef pThis, float _arg);

		/// <summary>
		/// Similar to RelativeContrastThreshold, but not scaled by the maximum
		/// luminosity.
		///
		/// If the contrast of the current pixel and it's 4 immediate NSWE neighbors is
		/// less than HardContrastThreshold, the pixel is not considered aliased and
		/// will not be affected by FXAA.
		///
		/// Suggested settings:
		/// - 1/32: Visible limit
		/// - 1/16: High quality (default)
		/// - 1/12: Upper limit (start of visible unfiltered edges)
		/// </summary>
		// Token: 0x06014AC5 RID: 84677 RVA: 0x001D444F File Offset: 0x001D264F
		public virtual void SetHardContrastThreshold(float _arg)
		{
			vtkFXAAOptions.vtkFXAAOptions_SetHardContrastThreshold_27(base.GetCppThis(), _arg);
		}

		// Token: 0x06014AC6 RID: 84678
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFXAAOptions_SetRelativeContrastThreshold_28(HandleRef pThis, float _arg);

		/// <summary>
		/// Threshold for applying FXAA to a pixel, relative to the maximum luminosity
		/// of its 4 immediate neighbors.
		///
		/// The luminosity of the current pixel and it's NSWE neighbors is computed.
		/// The maximum luminosity and luminosity range (contrast) of all 5 pixels is
		/// found. If the contrast is less than RelativeContrastThreshold * maxLum,
		/// the pixel is not considered aliased and will not be affected by FXAA.
		///
		/// Suggested settings:
		/// - 1/3: Too little
		/// - 1/4: Low quality
		/// - 1/8: High quality (default)
		/// - 1/16: Overkill
		/// </summary>
		// Token: 0x06014AC7 RID: 84679 RVA: 0x001D445F File Offset: 0x001D265F
		public virtual void SetRelativeContrastThreshold(float _arg)
		{
			vtkFXAAOptions.vtkFXAAOptions_SetRelativeContrastThreshold_28(base.GetCppThis(), _arg);
		}

		// Token: 0x06014AC8 RID: 84680
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFXAAOptions_SetSubpixelBlendLimit_29(HandleRef pThis, float _arg);

		/// <summary>
		/// Subpixel aliasing is corrected by applying a lowpass filter to the current
		/// pixel. This is implemented by blending an average of the 3x3 neighborhood
		/// around the pixel into the final result. The amount of blending is
		/// determined by comparing the detected amount of subpixel aliasing to the
		/// total contrasting of the CNSWE pixels:
		///
		/// SubpixelBlending = abs(lumC - lumAveNSWE) / (lumMaxCNSWE - lumMinCNSWE)
		///
		/// This parameter sets an upper limit to the amount of subpixel blending to
		/// prevent the image from simply getting blurred.
		///
		/// Suggested settings:
		/// - 1/2: Low amount of blending.
		/// - 3/4: Medium amount of blending (default)
		/// - 7/8: High amount of blending.
		/// - 1: Maximum amount of blending.
		/// </summary>
		// Token: 0x06014AC9 RID: 84681 RVA: 0x001D446F File Offset: 0x001D266F
		public virtual void SetSubpixelBlendLimit(float _arg)
		{
			vtkFXAAOptions.vtkFXAAOptions_SetSubpixelBlendLimit_29(base.GetCppThis(), _arg);
		}

		// Token: 0x06014ACA RID: 84682
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFXAAOptions_SetSubpixelContrastThreshold_30(HandleRef pThis, float _arg);

		/// <summary>
		/// Minimum amount of subpixel aliasing required for subpixel antialiasing to
		/// be applied.
		///
		/// Subpixel aliasing is corrected by applying a lowpass filter to the current
		/// pixel. This is implemented by blending an average of the 3x3 neighborhood
		/// around the pixel into the final result. The amount of blending is
		/// determined by comparing the detected amount of subpixel aliasing to the
		/// total contrasting of the CNSWE pixels:
		///
		/// SubpixelBlending = abs(lumC - lumAveNSWE) / (lumMaxCNSWE - lumMinCNSWE)
		///
		/// If SubpixelBlending is less than this threshold, no lowpass blending will
		/// occur.
		///
		/// Suggested settings:
		/// - 1/2: Low subpixel aliasing removal
		/// - 1/3: Medium subpixel aliasing removal
		/// - 1/4: Default subpixel aliasing removal
		/// - 1/8: High subpixel aliasing removal
		/// - 0: Complete subpixel aliasing removal
		/// </summary>
		// Token: 0x06014ACB RID: 84683 RVA: 0x001D447F File Offset: 0x001D267F
		public virtual void SetSubpixelContrastThreshold(float _arg)
		{
			vtkFXAAOptions.vtkFXAAOptions_SetSubpixelContrastThreshold_30(base.GetCppThis(), _arg);
		}

		// Token: 0x06014ACC RID: 84684
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFXAAOptions_SetUseHighQualityEndpoints_31(HandleRef pThis, byte _arg);

		/// <summary>
		/// Use an improved edge endpoint detection algorithm.
		///
		/// If true, a modified edge endpoint detection algorithm is used that requires
		/// more texture lookups, but will properly detect aliased single-pixel lines.
		///
		/// If false, the edge endpoint algorithm proposed by NVIDIA will by used. This
		/// algorithm is faster (fewer lookups), but will fail to detect endpoints of
		/// single pixel edge steps.
		///
		/// Default setting is true.
		/// </summary>
		// Token: 0x06014ACD RID: 84685 RVA: 0x001D448F File Offset: 0x001D268F
		public virtual void SetUseHighQualityEndpoints(bool _arg)
		{
			vtkFXAAOptions.vtkFXAAOptions_SetUseHighQualityEndpoints_31(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06014ACE RID: 84686
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFXAAOptions_UseHighQualityEndpointsOff_32(HandleRef pThis);

		/// <summary>
		/// Use an improved edge endpoint detection algorithm.
		///
		/// If true, a modified edge endpoint detection algorithm is used that requires
		/// more texture lookups, but will properly detect aliased single-pixel lines.
		///
		/// If false, the edge endpoint algorithm proposed by NVIDIA will by used. This
		/// algorithm is faster (fewer lookups), but will fail to detect endpoints of
		/// single pixel edge steps.
		///
		/// Default setting is true.
		/// </summary>
		// Token: 0x06014ACF RID: 84687 RVA: 0x001D44A7 File Offset: 0x001D26A7
		public virtual void UseHighQualityEndpointsOff()
		{
			vtkFXAAOptions.vtkFXAAOptions_UseHighQualityEndpointsOff_32(base.GetCppThis());
		}

		// Token: 0x06014AD0 RID: 84688
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFXAAOptions_UseHighQualityEndpointsOn_33(HandleRef pThis);

		/// <summary>
		/// Use an improved edge endpoint detection algorithm.
		///
		/// If true, a modified edge endpoint detection algorithm is used that requires
		/// more texture lookups, but will properly detect aliased single-pixel lines.
		///
		/// If false, the edge endpoint algorithm proposed by NVIDIA will by used. This
		/// algorithm is faster (fewer lookups), but will fail to detect endpoints of
		/// single pixel edge steps.
		///
		/// Default setting is true.
		/// </summary>
		// Token: 0x06014AD1 RID: 84689 RVA: 0x001D44B6 File Offset: 0x001D26B6
		public virtual void UseHighQualityEndpointsOn()
		{
			vtkFXAAOptions.vtkFXAAOptions_UseHighQualityEndpointsOn_33(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017DE RID: 6110
		public new const string MRFullTypeName = "Kitware.VTK.vtkFXAAOptions";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017DF RID: 6111
		public new static readonly string MRClassNameKey = "class vtkFXAAOptions";

		/// <summary>
		/// Debugging options that affect the output color buffer. See
		/// vtkFXAAFilterFS.glsl for details.
		/// </summary>
		// Token: 0x020007DD RID: 2013
		public enum DebugOption
		{
			/// <summary>enum member</summary>
			// Token: 0x040017E1 RID: 6113
			FXAA_DEBUG_EDGE_DIRECTION = 2,
			/// <summary>enum member</summary>
			// Token: 0x040017E2 RID: 6114
			FXAA_DEBUG_EDGE_DISTANCE = 4,
			/// <summary>enum member</summary>
			// Token: 0x040017E3 RID: 6115
			FXAA_DEBUG_EDGE_NUM_STEPS = 3,
			/// <summary>enum member</summary>
			// Token: 0x040017E4 RID: 6116
			FXAA_DEBUG_EDGE_SAMPLE_OFFSET = 5,
			/// <summary>enum member</summary>
			// Token: 0x040017E5 RID: 6117
			FXAA_DEBUG_ONLY_EDGE_AA = 7,
			/// <summary>enum member</summary>
			// Token: 0x040017E6 RID: 6118
			FXAA_DEBUG_ONLY_SUBPIX_AA = 6,
			/// <summary>enum member</summary>
			// Token: 0x040017E7 RID: 6119
			FXAA_DEBUG_SUBPIXEL_ALIASING = 1,
			/// <summary>enum member</summary>
			// Token: 0x040017E8 RID: 6120
			FXAA_NO_DEBUG = 0
		}
	}
}
