using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOutlineGlowPass
	/// </summary>
	/// <remarks>
	///    Renders a glowing outline using a image processing pass
	///
	/// Create a glowing outline of the image rendered by the delegate.
	///
	/// This render pass was designed to highlight parts of a scene by applying the render pass to a
	/// layered renderer on top of the main scene. For optimal results, actors that form the outline
	/// should be brightly colored with lighting disabled. The outline will have the color of the actors.
	/// There is only one outline around all objects rendered by the delegate.
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
	/// The image is first rendered to a full size offscreen render target, then blurred twice on a half
	/// sized render target using Gaussian blur with an offset. The offset and the smaller render target
	/// increase the size of the outline without incurring the cost of a big Gaussian blur kernel. The
	/// implementation of the gaussian blur is similar to vtkGaussianBlurPass with the alterations
	/// described above.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRenderPass vtkGaussianBlurPass
	/// </seealso>
	// Token: 0x020005DB RID: 1499
	public class vtkOutlineGlowPass : vtkImageProcessingPass
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060105D5 RID: 67029 RVA: 0x0016CD4B File Offset: 0x0016AF4B
		static vtkOutlineGlowPass()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOutlineGlowPass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOutlineGlowPass"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060105D6 RID: 67030 RVA: 0x0016CD73 File Offset: 0x0016AF73
		public vtkOutlineGlowPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060105D7 RID: 67031
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOutlineGlowPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060105D8 RID: 67032 RVA: 0x0016CD84 File Offset: 0x0016AF84
		public new static vtkOutlineGlowPass New()
		{
			vtkOutlineGlowPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOutlineGlowPass.vtkOutlineGlowPass_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOutlineGlowPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060105D9 RID: 67033 RVA: 0x0016CDD8 File Offset: 0x0016AFD8
		public vtkOutlineGlowPass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOutlineGlowPass.vtkOutlineGlowPass_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060105DA RID: 67034 RVA: 0x0016CE1C File Offset: 0x0016B01C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060105DB RID: 67035
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOutlineGlowPass_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060105DC RID: 67036 RVA: 0x0016CE28 File Offset: 0x0016B028
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOutlineGlowPass.vtkOutlineGlowPass_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060105DD RID: 67037
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOutlineGlowPass_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060105DE RID: 67038 RVA: 0x0016CE48 File Offset: 0x0016B048
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOutlineGlowPass.vtkOutlineGlowPass_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060105DF RID: 67039
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkOutlineGlowPass_GetOutlineIntensity_03(HandleRef pThis);

		/// <summary>
		/// Get/Set the intensity of the outline.
		/// Default value is 3.0 which gives a bright outline with a fading edge
		/// </summary>
		// Token: 0x060105E0 RID: 67040 RVA: 0x0016CE64 File Offset: 0x0016B064
		public virtual float GetOutlineIntensity()
		{
			return vtkOutlineGlowPass.vtkOutlineGlowPass_GetOutlineIntensity_03(base.GetCppThis());
		}

		// Token: 0x060105E1 RID: 67041
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOutlineGlowPass_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060105E2 RID: 67042 RVA: 0x0016CE84 File Offset: 0x0016B084
		public override int IsA(string type)
		{
			return vtkOutlineGlowPass.vtkOutlineGlowPass_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x060105E3 RID: 67043
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOutlineGlowPass_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060105E4 RID: 67044 RVA: 0x0016CEA4 File Offset: 0x0016B0A4
		public new static int IsTypeOf(string type)
		{
			return vtkOutlineGlowPass.vtkOutlineGlowPass_IsTypeOf_05(type);
		}

		// Token: 0x060105E5 RID: 67045
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOutlineGlowPass_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060105E6 RID: 67046 RVA: 0x0016CEC0 File Offset: 0x0016B0C0
		public new vtkOutlineGlowPass NewInstance()
		{
			vtkOutlineGlowPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOutlineGlowPass.vtkOutlineGlowPass_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOutlineGlowPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060105E7 RID: 67047
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOutlineGlowPass_ReleaseGraphicsResources_08(HandleRef pThis, HandleRef w);

		/// <summary>
		/// Release graphics resources and ask components to release their own
		/// resources.
		/// \pre w_exists: w!=0
		/// </summary>
		// Token: 0x060105E8 RID: 67048 RVA: 0x0016CF1C File Offset: 0x0016B11C
		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkOutlineGlowPass.vtkOutlineGlowPass_ReleaseGraphicsResources_08(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		// Token: 0x060105E9 RID: 67049
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOutlineGlowPass_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060105EA RID: 67050 RVA: 0x0016CF4C File Offset: 0x0016B14C
		public new static vtkOutlineGlowPass SafeDownCast(vtkObjectBase o)
		{
			vtkOutlineGlowPass vtkOutlineGlowPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOutlineGlowPass.vtkOutlineGlowPass_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOutlineGlowPass = (vtkOutlineGlowPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOutlineGlowPass.Register(null);
				}
			}
			return vtkOutlineGlowPass;
		}

		// Token: 0x060105EB RID: 67051
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOutlineGlowPass_SetOutlineIntensity_10(HandleRef pThis, float _arg);

		/// <summary>
		/// Get/Set the intensity of the outline.
		/// Default value is 3.0 which gives a bright outline with a fading edge
		/// </summary>
		// Token: 0x060105EC RID: 67052 RVA: 0x0016CFCB File Offset: 0x0016B1CB
		public virtual void SetOutlineIntensity(float _arg)
		{
			vtkOutlineGlowPass.vtkOutlineGlowPass_SetOutlineIntensity_10(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001301 RID: 4865
		public new const string MRFullTypeName = "Kitware.VTK.vtkOutlineGlowPass";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001302 RID: 4866
		public new static readonly string MRClassNameKey = "class vtkOutlineGlowPass";
	}
}
