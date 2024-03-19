using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSSAOPass
	/// </summary>
	/// <remarks>
	///    Implement a screen-space ambient occlusion pass.
	///
	/// SSAO darkens some pixels to improve depth perception simulating ambient occlusion
	/// in screen space.
	/// For each fragment, random samples inside a hemisphere at the fragment position oriented with
	/// the normal are tested against other fragments to compute an average occlusion.
	/// The number of samples and the radius of the hemisphere are configurables.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRenderPass
	/// </seealso>
	// Token: 0x020005E6 RID: 1510
	public class vtkSSAOPass : vtkImageProcessingPass
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601072F RID: 67375 RVA: 0x0016F167 File Offset: 0x0016D367
		static vtkSSAOPass()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSSAOPass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSSAOPass"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06010730 RID: 67376 RVA: 0x0016F18F File Offset: 0x0016D38F
		public vtkSSAOPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06010731 RID: 67377
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSSAOPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010732 RID: 67378 RVA: 0x0016F1A0 File Offset: 0x0016D3A0
		public new static vtkSSAOPass New()
		{
			vtkSSAOPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSSAOPass.vtkSSAOPass_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSSAOPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010733 RID: 67379 RVA: 0x0016F1F4 File Offset: 0x0016D3F4
		public vtkSSAOPass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSSAOPass.vtkSSAOPass_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010734 RID: 67380 RVA: 0x0016F238 File Offset: 0x0016D438
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06010735 RID: 67381
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSSAOPass_BlurOff_01(HandleRef pThis);

		/// <summary>
		/// Get/Set blurring of the ambient occlusion.
		/// Blurring can help to improve the result if samples number is low.
		/// Default is false
		/// </summary>
		// Token: 0x06010736 RID: 67382 RVA: 0x0016F243 File Offset: 0x0016D443
		public virtual void BlurOff()
		{
			vtkSSAOPass.vtkSSAOPass_BlurOff_01(base.GetCppThis());
		}

		// Token: 0x06010737 RID: 67383
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSSAOPass_BlurOn_02(HandleRef pThis);

		/// <summary>
		/// Get/Set blurring of the ambient occlusion.
		/// Blurring can help to improve the result if samples number is low.
		/// Default is false
		/// </summary>
		// Token: 0x06010738 RID: 67384 RVA: 0x0016F252 File Offset: 0x0016D452
		public virtual void BlurOn()
		{
			vtkSSAOPass.vtkSSAOPass_BlurOn_02(base.GetCppThis());
		}

		// Token: 0x06010739 RID: 67385
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSSAOPass_GetBias_03(HandleRef pThis);

		/// <summary>
		/// Get/Set the bias when comparing samples.
		/// Default is 0.01
		/// </summary>
		// Token: 0x0601073A RID: 67386 RVA: 0x0016F264 File Offset: 0x0016D464
		public virtual double GetBias()
		{
			return vtkSSAOPass.vtkSSAOPass_GetBias_03(base.GetCppThis());
		}

		// Token: 0x0601073B RID: 67387
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSSAOPass_GetBlur_04(HandleRef pThis);

		/// <summary>
		/// Get/Set blurring of the ambient occlusion.
		/// Blurring can help to improve the result if samples number is low.
		/// Default is false
		/// </summary>
		// Token: 0x0601073C RID: 67388 RVA: 0x0016F284 File Offset: 0x0016D484
		public virtual bool GetBlur()
		{
			return vtkSSAOPass.vtkSSAOPass_GetBlur_04(base.GetCppThis()) != 0;
		}

		// Token: 0x0601073D RID: 67389
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkSSAOPass_GetKernelSize_05(HandleRef pThis);

		/// <summary>
		/// Get/Set the number of samples.
		/// Default is 32
		/// </summary>
		// Token: 0x0601073E RID: 67390 RVA: 0x0016F2AC File Offset: 0x0016D4AC
		public virtual uint GetKernelSize()
		{
			return vtkSSAOPass.vtkSSAOPass_GetKernelSize_05(base.GetCppThis());
		}

		// Token: 0x0601073F RID: 67391
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkSSAOPass_GetKernelSizeMaxValue_06(HandleRef pThis);

		/// <summary>
		/// Get/Set the number of samples.
		/// Default is 32
		/// </summary>
		// Token: 0x06010740 RID: 67392 RVA: 0x0016F2CC File Offset: 0x0016D4CC
		public virtual uint GetKernelSizeMaxValue()
		{
			return vtkSSAOPass.vtkSSAOPass_GetKernelSizeMaxValue_06(base.GetCppThis());
		}

		// Token: 0x06010741 RID: 67393
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkSSAOPass_GetKernelSizeMinValue_07(HandleRef pThis);

		/// <summary>
		/// Get/Set the number of samples.
		/// Default is 32
		/// </summary>
		// Token: 0x06010742 RID: 67394 RVA: 0x0016F2EC File Offset: 0x0016D4EC
		public virtual uint GetKernelSizeMinValue()
		{
			return vtkSSAOPass.vtkSSAOPass_GetKernelSizeMinValue_07(base.GetCppThis());
		}

		// Token: 0x06010743 RID: 67395
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSSAOPass_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010744 RID: 67396 RVA: 0x0016F30C File Offset: 0x0016D50C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSSAOPass.vtkSSAOPass_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x06010745 RID: 67397
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSSAOPass_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010746 RID: 67398 RVA: 0x0016F32C File Offset: 0x0016D52C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSSAOPass.vtkSSAOPass_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x06010747 RID: 67399
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSSAOPass_GetRadius_10(HandleRef pThis);

		/// <summary>
		/// Get/Set the SSAO hemisphere radius.
		/// Default is 0.5
		/// </summary>
		// Token: 0x06010748 RID: 67400 RVA: 0x0016F348 File Offset: 0x0016D548
		public virtual double GetRadius()
		{
			return vtkSSAOPass.vtkSSAOPass_GetRadius_10(base.GetCppThis());
		}

		// Token: 0x06010749 RID: 67401
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSSAOPass_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601074A RID: 67402 RVA: 0x0016F368 File Offset: 0x0016D568
		public override int IsA(string type)
		{
			return vtkSSAOPass.vtkSSAOPass_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x0601074B RID: 67403
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSSAOPass_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601074C RID: 67404 RVA: 0x0016F388 File Offset: 0x0016D588
		public new static int IsTypeOf(string type)
		{
			return vtkSSAOPass.vtkSSAOPass_IsTypeOf_12(type);
		}

		// Token: 0x0601074D RID: 67405
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSSAOPass_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601074E RID: 67406 RVA: 0x0016F3A4 File Offset: 0x0016D5A4
		public new vtkSSAOPass NewInstance()
		{
			vtkSSAOPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSSAOPass.vtkSSAOPass_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSSAOPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601074F RID: 67407
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSSAOPass_PostReplaceShaderValues_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string vertexShader, [MarshalAs(UnmanagedType.LPUTF8Str)] string geometryShader, [MarshalAs(UnmanagedType.LPUTF8Str)] string fragmentShader, HandleRef mapper, HandleRef prop);

		/// <summary>
		/// Post replace shader values
		/// </summary>
		// Token: 0x06010750 RID: 67408 RVA: 0x0016F400 File Offset: 0x0016D600
		public override bool PostReplaceShaderValues(string vertexShader, string geometryShader, string fragmentShader, vtkAbstractMapper mapper, vtkProp prop)
		{
			return vtkSSAOPass.vtkSSAOPass_PostReplaceShaderValues_15(base.GetCppThis(), vertexShader, geometryShader, fragmentShader, (mapper == null) ? default(HandleRef) : mapper.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis()) != 0;
		}

		// Token: 0x06010751 RID: 67409
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSSAOPass_PreReplaceShaderValues_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string vertexShader, [MarshalAs(UnmanagedType.LPUTF8Str)] string geometryShader, [MarshalAs(UnmanagedType.LPUTF8Str)] string fragmentShader, HandleRef mapper, HandleRef prop);

		/// <summary>
		/// Pre replace shader values
		/// </summary>
		// Token: 0x06010752 RID: 67410 RVA: 0x0016F458 File Offset: 0x0016D658
		public override bool PreReplaceShaderValues(string vertexShader, string geometryShader, string fragmentShader, vtkAbstractMapper mapper, vtkProp prop)
		{
			return vtkSSAOPass.vtkSSAOPass_PreReplaceShaderValues_16(base.GetCppThis(), vertexShader, geometryShader, fragmentShader, (mapper == null) ? default(HandleRef) : mapper.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis()) != 0;
		}

		// Token: 0x06010753 RID: 67411
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSSAOPass_ReleaseGraphicsResources_17(HandleRef pThis, HandleRef w);

		/// <summary>
		/// Release graphics resources and ask components to release their own resources.
		/// </summary>
		// Token: 0x06010754 RID: 67412 RVA: 0x0016F4B0 File Offset: 0x0016D6B0
		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkSSAOPass.vtkSSAOPass_ReleaseGraphicsResources_17(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		// Token: 0x06010755 RID: 67413
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSSAOPass_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010756 RID: 67414 RVA: 0x0016F4E0 File Offset: 0x0016D6E0
		public new static vtkSSAOPass SafeDownCast(vtkObjectBase o)
		{
			vtkSSAOPass vtkSSAOPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSSAOPass.vtkSSAOPass_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSSAOPass = (vtkSSAOPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSSAOPass.Register(null);
				}
			}
			return vtkSSAOPass;
		}

		// Token: 0x06010757 RID: 67415
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSSAOPass_SetBias_19(HandleRef pThis, double _arg);

		/// <summary>
		/// Get/Set the bias when comparing samples.
		/// Default is 0.01
		/// </summary>
		// Token: 0x06010758 RID: 67416 RVA: 0x0016F55F File Offset: 0x0016D75F
		public virtual void SetBias(double _arg)
		{
			vtkSSAOPass.vtkSSAOPass_SetBias_19(base.GetCppThis(), _arg);
		}

		// Token: 0x06010759 RID: 67417
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSSAOPass_SetBlur_20(HandleRef pThis, byte _arg);

		/// <summary>
		/// Get/Set blurring of the ambient occlusion.
		/// Blurring can help to improve the result if samples number is low.
		/// Default is false
		/// </summary>
		// Token: 0x0601075A RID: 67418 RVA: 0x0016F56F File Offset: 0x0016D76F
		public virtual void SetBlur(bool _arg)
		{
			vtkSSAOPass.vtkSSAOPass_SetBlur_20(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0601075B RID: 67419
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSSAOPass_SetKernelSize_21(HandleRef pThis, uint _arg);

		/// <summary>
		/// Get/Set the number of samples.
		/// Default is 32
		/// </summary>
		// Token: 0x0601075C RID: 67420 RVA: 0x0016F587 File Offset: 0x0016D787
		public virtual void SetKernelSize(uint _arg)
		{
			vtkSSAOPass.vtkSSAOPass_SetKernelSize_21(base.GetCppThis(), _arg);
		}

		// Token: 0x0601075D RID: 67421
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSSAOPass_SetRadius_22(HandleRef pThis, double _arg);

		/// <summary>
		/// Get/Set the SSAO hemisphere radius.
		/// Default is 0.5
		/// </summary>
		// Token: 0x0601075E RID: 67422 RVA: 0x0016F597 File Offset: 0x0016D797
		public virtual void SetRadius(double _arg)
		{
			vtkSSAOPass.vtkSSAOPass_SetRadius_22(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001318 RID: 4888
		public new const string MRFullTypeName = "Kitware.VTK.vtkSSAOPass";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001319 RID: 4889
		public new static readonly string MRClassNameKey = "class vtkSSAOPass";
	}
}
