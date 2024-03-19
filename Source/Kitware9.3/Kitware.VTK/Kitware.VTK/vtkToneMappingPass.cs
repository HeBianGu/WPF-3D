using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkToneMappingPass
	/// </summary>
	/// <remarks>
	///    Implement a post-processing Tone Mapping.
	///
	/// Tone mapping is the process of mapping HDR colors to [0;1] range.
	/// This render pass supports four different modes:
	/// - Clamp: clamps the color to [0;1] range
	/// - Reinhard: maps the color using formula: x/(x+1)
	/// - Exponential: maps the colors using a coefficient and the formula: 1-exp(-a*x)
	/// - GenericFilmic: maps the color using five parameters that allow to shape the
	///                  tonemapping curve : Contrast adjust the toe (left part) of the curve;
	///                  Shoulder adjusts the right part; MidIn and MidOut adjusts the middle gray
	///                  level in percent of the curve for input and output (ie. the halfway point
	///                  between white and black); and HdrMax is the maximum HDR input that is not
	///                  clipped. A boolean UseACES allows to use the Academy Color Encoding System.
	///
	/// Advanced tone mapping like GenericFilmic, Reinhard or Exponential can be useful when several
	/// lights are added to the renderer.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRenderPass
	/// </seealso>
	// Token: 0x020005F1 RID: 1521
	public class vtkToneMappingPass : vtkImageProcessingPass
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06010889 RID: 67721 RVA: 0x0017146F File Offset: 0x0016F66F
		static vtkToneMappingPass()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkToneMappingPass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkToneMappingPass"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601088A RID: 67722 RVA: 0x00171497 File Offset: 0x0016F697
		public vtkToneMappingPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601088B RID: 67723
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkToneMappingPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601088C RID: 67724 RVA: 0x001714A8 File Offset: 0x0016F6A8
		public new static vtkToneMappingPass New()
		{
			vtkToneMappingPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkToneMappingPass.vtkToneMappingPass_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkToneMappingPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601088D RID: 67725 RVA: 0x001714FC File Offset: 0x0016F6FC
		public vtkToneMappingPass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkToneMappingPass.vtkToneMappingPass_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601088E RID: 67726 RVA: 0x00171540 File Offset: 0x0016F740
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601088F RID: 67727
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkToneMappingPass_GetContrast_01(HandleRef pThis);

		/// <summary>
		/// Contrast adjust the toe of the curve. Typically in [1-2].
		/// Default is 1.6773
		/// </summary>
		// Token: 0x06010890 RID: 67728 RVA: 0x0017154C File Offset: 0x0016F74C
		public virtual float GetContrast()
		{
			return vtkToneMappingPass.vtkToneMappingPass_GetContrast_01(base.GetCppThis());
		}

		// Token: 0x06010891 RID: 67729
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkToneMappingPass_GetContrastMaxValue_02(HandleRef pThis);

		/// <summary>
		/// Contrast adjust the toe of the curve. Typically in [1-2].
		/// Default is 1.6773
		/// </summary>
		// Token: 0x06010892 RID: 67730 RVA: 0x0017156C File Offset: 0x0016F76C
		public virtual float GetContrastMaxValue()
		{
			return vtkToneMappingPass.vtkToneMappingPass_GetContrastMaxValue_02(base.GetCppThis());
		}

		// Token: 0x06010893 RID: 67731
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkToneMappingPass_GetContrastMinValue_03(HandleRef pThis);

		/// <summary>
		/// Contrast adjust the toe of the curve. Typically in [1-2].
		/// Default is 1.6773
		/// </summary>
		// Token: 0x06010894 RID: 67732 RVA: 0x0017158C File Offset: 0x0016F78C
		public virtual float GetContrastMinValue()
		{
			return vtkToneMappingPass.vtkToneMappingPass_GetContrastMinValue_03(base.GetCppThis());
		}

		// Token: 0x06010895 RID: 67733
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkToneMappingPass_GetExposure_04(HandleRef pThis);

		/// <summary>
		/// Get/Set Exposure coefficient used for exponential and Generic Filmic tone mapping.
		/// Default is 1.0
		/// </summary>
		// Token: 0x06010896 RID: 67734 RVA: 0x001715AC File Offset: 0x0016F7AC
		public virtual float GetExposure()
		{
			return vtkToneMappingPass.vtkToneMappingPass_GetExposure_04(base.GetCppThis());
		}

		// Token: 0x06010897 RID: 67735
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkToneMappingPass_GetHdrMax_05(HandleRef pThis);

		/// <summary>
		/// Maximum HDR input that is not clipped.
		/// Default is 11.0785
		/// </summary>
		// Token: 0x06010898 RID: 67736 RVA: 0x001715CC File Offset: 0x0016F7CC
		public virtual float GetHdrMax()
		{
			return vtkToneMappingPass.vtkToneMappingPass_GetHdrMax_05(base.GetCppThis());
		}

		// Token: 0x06010899 RID: 67737
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkToneMappingPass_GetHdrMaxMaxValue_06(HandleRef pThis);

		/// <summary>
		/// Maximum HDR input that is not clipped.
		/// Default is 11.0785
		/// </summary>
		// Token: 0x0601089A RID: 67738 RVA: 0x001715EC File Offset: 0x0016F7EC
		public virtual float GetHdrMaxMaxValue()
		{
			return vtkToneMappingPass.vtkToneMappingPass_GetHdrMaxMaxValue_06(base.GetCppThis());
		}

		// Token: 0x0601089B RID: 67739
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkToneMappingPass_GetHdrMaxMinValue_07(HandleRef pThis);

		/// <summary>
		/// Maximum HDR input that is not clipped.
		/// Default is 11.0785
		/// </summary>
		// Token: 0x0601089C RID: 67740 RVA: 0x0017160C File Offset: 0x0016F80C
		public virtual float GetHdrMaxMinValue()
		{
			return vtkToneMappingPass.vtkToneMappingPass_GetHdrMaxMinValue_07(base.GetCppThis());
		}

		// Token: 0x0601089D RID: 67741
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkToneMappingPass_GetMidIn_08(HandleRef pThis);

		/// <summary>
		/// Mid level anchor input.
		/// Default is 0.18 (in percent gray)
		/// </summary>
		// Token: 0x0601089E RID: 67742 RVA: 0x0017162C File Offset: 0x0016F82C
		public virtual float GetMidIn()
		{
			return vtkToneMappingPass.vtkToneMappingPass_GetMidIn_08(base.GetCppThis());
		}

		// Token: 0x0601089F RID: 67743
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkToneMappingPass_GetMidInMaxValue_09(HandleRef pThis);

		/// <summary>
		/// Mid level anchor input.
		/// Default is 0.18 (in percent gray)
		/// </summary>
		// Token: 0x060108A0 RID: 67744 RVA: 0x0017164C File Offset: 0x0016F84C
		public virtual float GetMidInMaxValue()
		{
			return vtkToneMappingPass.vtkToneMappingPass_GetMidInMaxValue_09(base.GetCppThis());
		}

		// Token: 0x060108A1 RID: 67745
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkToneMappingPass_GetMidInMinValue_10(HandleRef pThis);

		/// <summary>
		/// Mid level anchor input.
		/// Default is 0.18 (in percent gray)
		/// </summary>
		// Token: 0x060108A2 RID: 67746 RVA: 0x0017166C File Offset: 0x0016F86C
		public virtual float GetMidInMinValue()
		{
			return vtkToneMappingPass.vtkToneMappingPass_GetMidInMinValue_10(base.GetCppThis());
		}

		// Token: 0x060108A3 RID: 67747
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkToneMappingPass_GetMidOut_11(HandleRef pThis);

		/// <summary>
		/// Mid level anchor output.
		/// Default is 0.18 (in percent gray)
		/// </summary>
		// Token: 0x060108A4 RID: 67748 RVA: 0x0017168C File Offset: 0x0016F88C
		public virtual float GetMidOut()
		{
			return vtkToneMappingPass.vtkToneMappingPass_GetMidOut_11(base.GetCppThis());
		}

		// Token: 0x060108A5 RID: 67749
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkToneMappingPass_GetMidOutMaxValue_12(HandleRef pThis);

		/// <summary>
		/// Mid level anchor output.
		/// Default is 0.18 (in percent gray)
		/// </summary>
		// Token: 0x060108A6 RID: 67750 RVA: 0x001716AC File Offset: 0x0016F8AC
		public virtual float GetMidOutMaxValue()
		{
			return vtkToneMappingPass.vtkToneMappingPass_GetMidOutMaxValue_12(base.GetCppThis());
		}

		// Token: 0x060108A7 RID: 67751
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkToneMappingPass_GetMidOutMinValue_13(HandleRef pThis);

		/// <summary>
		/// Mid level anchor output.
		/// Default is 0.18 (in percent gray)
		/// </summary>
		// Token: 0x060108A8 RID: 67752 RVA: 0x001716CC File Offset: 0x0016F8CC
		public virtual float GetMidOutMinValue()
		{
			return vtkToneMappingPass.vtkToneMappingPass_GetMidOutMinValue_13(base.GetCppThis());
		}

		// Token: 0x060108A9 RID: 67753
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkToneMappingPass_GetNumberOfGenerationsFromBase_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060108AA RID: 67754 RVA: 0x001716EC File Offset: 0x0016F8EC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkToneMappingPass.vtkToneMappingPass_GetNumberOfGenerationsFromBase_14(base.GetCppThis(), type);
		}

		// Token: 0x060108AB RID: 67755
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkToneMappingPass_GetNumberOfGenerationsFromBaseType_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060108AC RID: 67756 RVA: 0x0017170C File Offset: 0x0016F90C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkToneMappingPass.vtkToneMappingPass_GetNumberOfGenerationsFromBaseType_15(type);
		}

		// Token: 0x060108AD RID: 67757
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkToneMappingPass_GetShoulder_16(HandleRef pThis);

		/// <summary>
		/// Shoulder limit the output in the shoulder region of the curve.
		/// Typically in [0.9-1].
		/// Default is 0.9714
		/// </summary>
		// Token: 0x060108AE RID: 67758 RVA: 0x00171728 File Offset: 0x0016F928
		public virtual float GetShoulder()
		{
			return vtkToneMappingPass.vtkToneMappingPass_GetShoulder_16(base.GetCppThis());
		}

		// Token: 0x060108AF RID: 67759
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkToneMappingPass_GetShoulderMaxValue_17(HandleRef pThis);

		/// <summary>
		/// Shoulder limit the output in the shoulder region of the curve.
		/// Typically in [0.9-1].
		/// Default is 0.9714
		/// </summary>
		// Token: 0x060108B0 RID: 67760 RVA: 0x00171748 File Offset: 0x0016F948
		public virtual float GetShoulderMaxValue()
		{
			return vtkToneMappingPass.vtkToneMappingPass_GetShoulderMaxValue_17(base.GetCppThis());
		}

		// Token: 0x060108B1 RID: 67761
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkToneMappingPass_GetShoulderMinValue_18(HandleRef pThis);

		/// <summary>
		/// Shoulder limit the output in the shoulder region of the curve.
		/// Typically in [0.9-1].
		/// Default is 0.9714
		/// </summary>
		// Token: 0x060108B2 RID: 67762 RVA: 0x00171768 File Offset: 0x0016F968
		public virtual float GetShoulderMinValue()
		{
			return vtkToneMappingPass.vtkToneMappingPass_GetShoulderMinValue_18(base.GetCppThis());
		}

		// Token: 0x060108B3 RID: 67763
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkToneMappingPass_GetToneMappingType_19(HandleRef pThis);

		/// <summary>
		/// Get/Set the tone mapping type.
		/// Default is GenericFilmic
		/// </summary>
		// Token: 0x060108B4 RID: 67764 RVA: 0x00171788 File Offset: 0x0016F988
		public virtual int GetToneMappingType()
		{
			return vtkToneMappingPass.vtkToneMappingPass_GetToneMappingType_19(base.GetCppThis());
		}

		// Token: 0x060108B5 RID: 67765
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkToneMappingPass_GetToneMappingTypeMaxValue_20(HandleRef pThis);

		/// <summary>
		/// Get/Set the tone mapping type.
		/// Default is GenericFilmic
		/// </summary>
		// Token: 0x060108B6 RID: 67766 RVA: 0x001717A8 File Offset: 0x0016F9A8
		public virtual int GetToneMappingTypeMaxValue()
		{
			return vtkToneMappingPass.vtkToneMappingPass_GetToneMappingTypeMaxValue_20(base.GetCppThis());
		}

		// Token: 0x060108B7 RID: 67767
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkToneMappingPass_GetToneMappingTypeMinValue_21(HandleRef pThis);

		/// <summary>
		/// Get/Set the tone mapping type.
		/// Default is GenericFilmic
		/// </summary>
		// Token: 0x060108B8 RID: 67768 RVA: 0x001717C8 File Offset: 0x0016F9C8
		public virtual int GetToneMappingTypeMinValue()
		{
			return vtkToneMappingPass.vtkToneMappingPass_GetToneMappingTypeMinValue_21(base.GetCppThis());
		}

		// Token: 0x060108B9 RID: 67769
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkToneMappingPass_GetUseACES_22(HandleRef pThis);

		/// <summary>
		/// Apply or not the Academy Color Encoding System (ACES).
		/// Default is true
		/// </summary>
		// Token: 0x060108BA RID: 67770 RVA: 0x001717E8 File Offset: 0x0016F9E8
		public virtual bool GetUseACES()
		{
			return vtkToneMappingPass.vtkToneMappingPass_GetUseACES_22(base.GetCppThis()) != 0;
		}

		// Token: 0x060108BB RID: 67771
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkToneMappingPass_IsA_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060108BC RID: 67772 RVA: 0x00171810 File Offset: 0x0016FA10
		public override int IsA(string type)
		{
			return vtkToneMappingPass.vtkToneMappingPass_IsA_23(base.GetCppThis(), type);
		}

		// Token: 0x060108BD RID: 67773
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkToneMappingPass_IsTypeOf_24([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060108BE RID: 67774 RVA: 0x00171830 File Offset: 0x0016FA30
		public new static int IsTypeOf(string type)
		{
			return vtkToneMappingPass.vtkToneMappingPass_IsTypeOf_24(type);
		}

		// Token: 0x060108BF RID: 67775
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkToneMappingPass_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060108C0 RID: 67776 RVA: 0x0017184C File Offset: 0x0016FA4C
		public new vtkToneMappingPass NewInstance()
		{
			vtkToneMappingPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkToneMappingPass.vtkToneMappingPass_NewInstance_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkToneMappingPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060108C1 RID: 67777
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkToneMappingPass_ReleaseGraphicsResources_27(HandleRef pThis, HandleRef w);

		/// <summary>
		/// Release graphics resources and ask components to release their own resources.
		/// </summary>
		// Token: 0x060108C2 RID: 67778 RVA: 0x001718A8 File Offset: 0x0016FAA8
		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkToneMappingPass.vtkToneMappingPass_ReleaseGraphicsResources_27(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		// Token: 0x060108C3 RID: 67779
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkToneMappingPass_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060108C4 RID: 67780 RVA: 0x001718D8 File Offset: 0x0016FAD8
		public new static vtkToneMappingPass SafeDownCast(vtkObjectBase o)
		{
			vtkToneMappingPass vtkToneMappingPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkToneMappingPass.vtkToneMappingPass_SafeDownCast_28((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkToneMappingPass = (vtkToneMappingPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkToneMappingPass.Register(null);
				}
			}
			return vtkToneMappingPass;
		}

		// Token: 0x060108C5 RID: 67781
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkToneMappingPass_SetContrast_29(HandleRef pThis, float _arg);

		/// <summary>
		/// Contrast adjust the toe of the curve. Typically in [1-2].
		/// Default is 1.6773
		/// </summary>
		// Token: 0x060108C6 RID: 67782 RVA: 0x00171957 File Offset: 0x0016FB57
		public virtual void SetContrast(float _arg)
		{
			vtkToneMappingPass.vtkToneMappingPass_SetContrast_29(base.GetCppThis(), _arg);
		}

		// Token: 0x060108C7 RID: 67783
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkToneMappingPass_SetExposure_30(HandleRef pThis, float _arg);

		/// <summary>
		/// Get/Set Exposure coefficient used for exponential and Generic Filmic tone mapping.
		/// Default is 1.0
		/// </summary>
		// Token: 0x060108C8 RID: 67784 RVA: 0x00171967 File Offset: 0x0016FB67
		public virtual void SetExposure(float _arg)
		{
			vtkToneMappingPass.vtkToneMappingPass_SetExposure_30(base.GetCppThis(), _arg);
		}

		// Token: 0x060108C9 RID: 67785
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkToneMappingPass_SetGenericFilmicDefaultPresets_31(HandleRef pThis);

		/// <summary>
		/// Set function to set uncharted 2 presets, and default presets
		/// </summary>
		// Token: 0x060108CA RID: 67786 RVA: 0x00171977 File Offset: 0x0016FB77
		public void SetGenericFilmicDefaultPresets()
		{
			vtkToneMappingPass.vtkToneMappingPass_SetGenericFilmicDefaultPresets_31(base.GetCppThis());
		}

		// Token: 0x060108CB RID: 67787
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkToneMappingPass_SetGenericFilmicUncharted2Presets_32(HandleRef pThis);

		/// <summary>
		/// Set function to set uncharted 2 presets, and default presets
		/// </summary>
		// Token: 0x060108CC RID: 67788 RVA: 0x00171986 File Offset: 0x0016FB86
		public void SetGenericFilmicUncharted2Presets()
		{
			vtkToneMappingPass.vtkToneMappingPass_SetGenericFilmicUncharted2Presets_32(base.GetCppThis());
		}

		// Token: 0x060108CD RID: 67789
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkToneMappingPass_SetHdrMax_33(HandleRef pThis, float _arg);

		/// <summary>
		/// Maximum HDR input that is not clipped.
		/// Default is 11.0785
		/// </summary>
		// Token: 0x060108CE RID: 67790 RVA: 0x00171995 File Offset: 0x0016FB95
		public virtual void SetHdrMax(float _arg)
		{
			vtkToneMappingPass.vtkToneMappingPass_SetHdrMax_33(base.GetCppThis(), _arg);
		}

		// Token: 0x060108CF RID: 67791
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkToneMappingPass_SetMidIn_34(HandleRef pThis, float _arg);

		/// <summary>
		/// Mid level anchor input.
		/// Default is 0.18 (in percent gray)
		/// </summary>
		// Token: 0x060108D0 RID: 67792 RVA: 0x001719A5 File Offset: 0x0016FBA5
		public virtual void SetMidIn(float _arg)
		{
			vtkToneMappingPass.vtkToneMappingPass_SetMidIn_34(base.GetCppThis(), _arg);
		}

		// Token: 0x060108D1 RID: 67793
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkToneMappingPass_SetMidOut_35(HandleRef pThis, float _arg);

		/// <summary>
		/// Mid level anchor output.
		/// Default is 0.18 (in percent gray)
		/// </summary>
		// Token: 0x060108D2 RID: 67794 RVA: 0x001719B5 File Offset: 0x0016FBB5
		public virtual void SetMidOut(float _arg)
		{
			vtkToneMappingPass.vtkToneMappingPass_SetMidOut_35(base.GetCppThis(), _arg);
		}

		// Token: 0x060108D3 RID: 67795
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkToneMappingPass_SetShoulder_36(HandleRef pThis, float _arg);

		/// <summary>
		/// Shoulder limit the output in the shoulder region of the curve.
		/// Typically in [0.9-1].
		/// Default is 0.9714
		/// </summary>
		// Token: 0x060108D4 RID: 67796 RVA: 0x001719C5 File Offset: 0x0016FBC5
		public virtual void SetShoulder(float _arg)
		{
			vtkToneMappingPass.vtkToneMappingPass_SetShoulder_36(base.GetCppThis(), _arg);
		}

		// Token: 0x060108D5 RID: 67797
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkToneMappingPass_SetToneMappingType_37(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the tone mapping type.
		/// Default is GenericFilmic
		/// </summary>
		// Token: 0x060108D6 RID: 67798 RVA: 0x001719D5 File Offset: 0x0016FBD5
		public virtual void SetToneMappingType(int _arg)
		{
			vtkToneMappingPass.vtkToneMappingPass_SetToneMappingType_37(base.GetCppThis(), _arg);
		}

		// Token: 0x060108D7 RID: 67799
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkToneMappingPass_SetUseACES_38(HandleRef pThis, byte _arg);

		/// <summary>
		/// Apply or not the Academy Color Encoding System (ACES).
		/// Default is true
		/// </summary>
		// Token: 0x060108D8 RID: 67800 RVA: 0x001719E5 File Offset: 0x0016FBE5
		public virtual void SetUseACES(bool _arg)
		{
			vtkToneMappingPass.vtkToneMappingPass_SetUseACES_38(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001334 RID: 4916
		public new const string MRFullTypeName = "Kitware.VTK.vtkToneMappingPass";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001335 RID: 4917
		public new static readonly string MRClassNameKey = "class vtkToneMappingPass";

		/// <summary>
		/// Enumeration of tone mapping algorithms
		/// </summary>
		// Token: 0x020005F2 RID: 1522
		public enum Clamp_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04001337 RID: 4919
			Clamp,
			/// <summary>enum member</summary>
			// Token: 0x04001338 RID: 4920
			Exponential = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001339 RID: 4921
			GenericFilmic,
			/// <summary>enum member</summary>
			// Token: 0x0400133A RID: 4922
			Reinhard = 1
		}
	}
}
