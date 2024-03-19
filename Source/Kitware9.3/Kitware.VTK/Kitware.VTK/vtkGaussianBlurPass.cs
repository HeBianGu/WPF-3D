using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGaussianBlurPass
	/// </summary>
	/// <remarks>
	///    Implement a post-processing Gaussian blur
	/// render pass.
	///
	/// Blur the image rendered by its delegate. Blurring uses a Gaussian low-pass
	/// filter with a 5x5 kernel.
	///
	/// This pass expects an initialized depth buffer and color buffer.
	/// Initialized buffers means they have been cleared with farthest z-value and
	/// background color/gradient/transparent color.
	/// An opaque pass may have been performed right after the initialization.
	///
	/// The delegate is used once.
	///
	/// Its delegate is usually set to a vtkCameraPass or to a post-processing pass.
	///
	/// This pass requires a OpenGL context that supports texture objects (TO),
	/// framebuffer objects (FBO) and GLSL. If not, it will emit an error message
	/// and will render its delegate and return.
	///
	/// @par Implementation:
	/// As the filter is separable, it first blurs the image horizontally and then
	/// vertically. This reduces the number of texture sampling to 5 per pass.
	/// In addition, as texture sampling can already blend texel values in linear
	/// mode, by adjusting the texture coordinate accordingly, only 3 texture
	/// sampling are actually necessary.
	/// Reference: OpenGL Bloom Toturial by Philip Rideout, section
	/// Exploit Hardware Filtering  http://prideout.net/bloom/index.php#Sneaky
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRenderPass
	/// </seealso>
	// Token: 0x02000591 RID: 1425
	public class vtkGaussianBlurPass : vtkImageProcessingPass
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600FB6B RID: 64363 RVA: 0x0015DA87 File Offset: 0x0015BC87
		static vtkGaussianBlurPass()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGaussianBlurPass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGaussianBlurPass"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600FB6C RID: 64364 RVA: 0x0015DAAF File Offset: 0x0015BCAF
		public vtkGaussianBlurPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600FB6D RID: 64365
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGaussianBlurPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FB6E RID: 64366 RVA: 0x0015DAC0 File Offset: 0x0015BCC0
		public new static vtkGaussianBlurPass New()
		{
			vtkGaussianBlurPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGaussianBlurPass.vtkGaussianBlurPass_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGaussianBlurPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FB6F RID: 64367 RVA: 0x0015DB14 File Offset: 0x0015BD14
		public vtkGaussianBlurPass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGaussianBlurPass.vtkGaussianBlurPass_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600FB70 RID: 64368 RVA: 0x0015DB58 File Offset: 0x0015BD58
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600FB71 RID: 64369
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGaussianBlurPass_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FB72 RID: 64370 RVA: 0x0015DB64 File Offset: 0x0015BD64
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGaussianBlurPass.vtkGaussianBlurPass_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600FB73 RID: 64371
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGaussianBlurPass_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FB74 RID: 64372 RVA: 0x0015DB84 File Offset: 0x0015BD84
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGaussianBlurPass.vtkGaussianBlurPass_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600FB75 RID: 64373
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGaussianBlurPass_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FB76 RID: 64374 RVA: 0x0015DBA0 File Offset: 0x0015BDA0
		public override int IsA(string type)
		{
			return vtkGaussianBlurPass.vtkGaussianBlurPass_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600FB77 RID: 64375
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGaussianBlurPass_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FB78 RID: 64376 RVA: 0x0015DBC0 File Offset: 0x0015BDC0
		public new static int IsTypeOf(string type)
		{
			return vtkGaussianBlurPass.vtkGaussianBlurPass_IsTypeOf_04(type);
		}

		// Token: 0x0600FB79 RID: 64377
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGaussianBlurPass_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FB7A RID: 64378 RVA: 0x0015DBDC File Offset: 0x0015BDDC
		public new vtkGaussianBlurPass NewInstance()
		{
			vtkGaussianBlurPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGaussianBlurPass.vtkGaussianBlurPass_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGaussianBlurPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600FB7B RID: 64379
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGaussianBlurPass_ReleaseGraphicsResources_07(HandleRef pThis, HandleRef w);

		/// <summary>
		/// Release graphics resources and ask components to release their own
		/// resources.
		/// \pre w_exists: w!=0
		/// </summary>
		// Token: 0x0600FB7C RID: 64380 RVA: 0x0015DC38 File Offset: 0x0015BE38
		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkGaussianBlurPass.vtkGaussianBlurPass_ReleaseGraphicsResources_07(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		// Token: 0x0600FB7D RID: 64381
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGaussianBlurPass_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FB7E RID: 64382 RVA: 0x0015DC68 File Offset: 0x0015BE68
		public new static vtkGaussianBlurPass SafeDownCast(vtkObjectBase o)
		{
			vtkGaussianBlurPass vtkGaussianBlurPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGaussianBlurPass.vtkGaussianBlurPass_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGaussianBlurPass = (vtkGaussianBlurPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGaussianBlurPass.Register(null);
				}
			}
			return vtkGaussianBlurPass;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400124A RID: 4682
		public new const string MRFullTypeName = "Kitware.VTK.vtkGaussianBlurPass";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400124B RID: 4683
		public new static readonly string MRClassNameKey = "class vtkGaussianBlurPass";
	}
}
