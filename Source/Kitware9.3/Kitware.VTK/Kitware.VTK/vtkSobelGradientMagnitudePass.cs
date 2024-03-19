using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSobelGradientMagnitudePass
	/// </summary>
	/// <remarks>
	///    Implement a post-processing edge
	/// detection with a Sobel gradient magnitude render pass.
	///
	/// Detect the edges of the image rendered by its delegate. Edge-detection
	/// uses a Sobel high-pass filter (3x3 kernel).
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
	/// To compute the gradient magnitude, the x and y components of the gradient
	/// (Gx and Gy) have to be computed first. Each computation of Gx and Gy uses
	/// a separable filter.
	/// The first pass takes the image from the delegate as the single input
	/// texture.
	/// The first pass has two outputs, one for the first part of Gx, Gx1, result of
	/// a convolution with (-1 0 1), one for the first part of Gy, Gy1, result of a
	/// convolution with (1 2 1).
	/// The second pass has two inputs, Gx1 and Gy1. Kernel (1 2 1)^T is applied
	/// to Gx1 and kernel (-1 0 1)^T is applied to Gx2. It gives the values for
	/// Gx and Gy. Those values are then used to compute the magnitude of the
	/// gradient which is stored in the render target.
	/// The gradient computation happens per component (R,G,B). A is arbitrarily set
	/// to 1 (full opacity).
	///
	/// @par Implementation:
	/// \image html vtkSobelGradientMagnitudePassFigure.png
	/// \image latex vtkSobelGradientMagnitudePassFigure.eps
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRenderPass
	/// </seealso>
	// Token: 0x020005F0 RID: 1520
	public class vtkSobelGradientMagnitudePass : vtkImageProcessingPass
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06010875 RID: 67701 RVA: 0x0017120F File Offset: 0x0016F40F
		static vtkSobelGradientMagnitudePass()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSobelGradientMagnitudePass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSobelGradientMagnitudePass"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06010876 RID: 67702 RVA: 0x00171237 File Offset: 0x0016F437
		public vtkSobelGradientMagnitudePass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06010877 RID: 67703
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSobelGradientMagnitudePass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010878 RID: 67704 RVA: 0x00171248 File Offset: 0x0016F448
		public new static vtkSobelGradientMagnitudePass New()
		{
			vtkSobelGradientMagnitudePass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSobelGradientMagnitudePass.vtkSobelGradientMagnitudePass_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSobelGradientMagnitudePass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010879 RID: 67705 RVA: 0x0017129C File Offset: 0x0016F49C
		public vtkSobelGradientMagnitudePass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSobelGradientMagnitudePass.vtkSobelGradientMagnitudePass_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601087A RID: 67706 RVA: 0x001712E0 File Offset: 0x0016F4E0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601087B RID: 67707
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSobelGradientMagnitudePass_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601087C RID: 67708 RVA: 0x001712EC File Offset: 0x0016F4EC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSobelGradientMagnitudePass.vtkSobelGradientMagnitudePass_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601087D RID: 67709
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSobelGradientMagnitudePass_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601087E RID: 67710 RVA: 0x0017130C File Offset: 0x0016F50C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSobelGradientMagnitudePass.vtkSobelGradientMagnitudePass_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601087F RID: 67711
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSobelGradientMagnitudePass_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010880 RID: 67712 RVA: 0x00171328 File Offset: 0x0016F528
		public override int IsA(string type)
		{
			return vtkSobelGradientMagnitudePass.vtkSobelGradientMagnitudePass_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06010881 RID: 67713
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSobelGradientMagnitudePass_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010882 RID: 67714 RVA: 0x00171348 File Offset: 0x0016F548
		public new static int IsTypeOf(string type)
		{
			return vtkSobelGradientMagnitudePass.vtkSobelGradientMagnitudePass_IsTypeOf_04(type);
		}

		// Token: 0x06010883 RID: 67715
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSobelGradientMagnitudePass_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010884 RID: 67716 RVA: 0x00171364 File Offset: 0x0016F564
		public new vtkSobelGradientMagnitudePass NewInstance()
		{
			vtkSobelGradientMagnitudePass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSobelGradientMagnitudePass.vtkSobelGradientMagnitudePass_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSobelGradientMagnitudePass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010885 RID: 67717
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSobelGradientMagnitudePass_ReleaseGraphicsResources_07(HandleRef pThis, HandleRef w);

		/// <summary>
		/// Release graphics resources and ask components to release their own
		/// resources.
		/// \pre w_exists: w!=0
		/// </summary>
		// Token: 0x06010886 RID: 67718 RVA: 0x001713C0 File Offset: 0x0016F5C0
		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkSobelGradientMagnitudePass.vtkSobelGradientMagnitudePass_ReleaseGraphicsResources_07(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		// Token: 0x06010887 RID: 67719
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSobelGradientMagnitudePass_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010888 RID: 67720 RVA: 0x001713F0 File Offset: 0x0016F5F0
		public new static vtkSobelGradientMagnitudePass SafeDownCast(vtkObjectBase o)
		{
			vtkSobelGradientMagnitudePass vtkSobelGradientMagnitudePass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSobelGradientMagnitudePass.vtkSobelGradientMagnitudePass_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSobelGradientMagnitudePass = (vtkSobelGradientMagnitudePass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSobelGradientMagnitudePass.Register(null);
				}
			}
			return vtkSobelGradientMagnitudePass;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001332 RID: 4914
		public new const string MRFullTypeName = "Kitware.VTK.vtkSobelGradientMagnitudePass";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001333 RID: 4915
		public new static readonly string MRClassNameKey = "class vtkSobelGradientMagnitudePass";
	}
}
