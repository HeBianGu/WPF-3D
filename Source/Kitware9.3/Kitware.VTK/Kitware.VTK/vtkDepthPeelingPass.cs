using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDepthPeelingPass
	/// </summary>
	/// <remarks>
	///    Implement Depth Peeling for use within a framebuffer pass
	///
	/// Note that this implementation is used as a fallback for drivers that
	/// don't support floating point textures. Most renderings will use the subclass
	/// vtkDualDepthPeelingPass instead.
	///
	/// Render the translucent polygonal geometry of a scene without sorting
	/// polygons in the view direction.
	///
	/// This pass expects an initialized depth buffer and color buffer.
	/// Initialized buffers means they have been cleared with farthest z-value and
	/// background color/gradient/transparent color.
	/// An opaque pass may have been performed right after the initialization.
	///
	/// The depth peeling algorithm works by rendering the translucent polygonal
	/// geometry multiple times (once for each peel). The actually rendering of
	/// the translucent polygonal geometry is performed by its delegate
	/// TranslucentPass. This delegate is therefore used multiple times.
	///
	/// Its delegate is usually set to a vtkTranslucentPass.
	///
	/// This implementation makes use of textures and is suitable for ES3
	/// For ES3 it must be embedded within a pass that makes use of framebuffers
	/// so that the required OpaqueZTexture and OpaqueRGBATexture can be
	/// passed from the outer framebuffer pass. For OpenGL ES3 be aware the
	/// occlusion ratio test is not supported. The maximum number of peels
	/// is used instead so set it to a reasonable value. For many scenes
	/// a value of 4 or 5 will work well.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRenderPass, vtkTranslucentPass, vtkFramebufferPass
	/// </seealso>
	// Token: 0x02000586 RID: 1414
	public class vtkDepthPeelingPass : vtkOpenGLRenderPass
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600F9F6 RID: 63990 RVA: 0x0015B89B File Offset: 0x00159A9B
		static vtkDepthPeelingPass()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDepthPeelingPass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDepthPeelingPass"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600F9F7 RID: 63991 RVA: 0x0015B8C3 File Offset: 0x00159AC3
		public vtkDepthPeelingPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600F9F8 RID: 63992
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDepthPeelingPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F9F9 RID: 63993 RVA: 0x0015B8D4 File Offset: 0x00159AD4
		public new static vtkDepthPeelingPass New()
		{
			vtkDepthPeelingPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDepthPeelingPass.vtkDepthPeelingPass_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDepthPeelingPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F9FA RID: 63994 RVA: 0x0015B928 File Offset: 0x00159B28
		public vtkDepthPeelingPass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDepthPeelingPass.vtkDepthPeelingPass_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600F9FB RID: 63995 RVA: 0x0015B96C File Offset: 0x00159B6C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600F9FC RID: 63996
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDepthPeelingPass_GetMaximumNumberOfPeels_01(HandleRef pThis);

		/// <summary>
		/// In case of depth peeling, define the maximum number of peeling layers.
		/// Initial value is 4. A special value of 0 means no maximum limit.
		/// It has to be a positive value.
		/// </summary>
		// Token: 0x0600F9FD RID: 63997 RVA: 0x0015B978 File Offset: 0x00159B78
		public virtual int GetMaximumNumberOfPeels()
		{
			return vtkDepthPeelingPass.vtkDepthPeelingPass_GetMaximumNumberOfPeels_01(base.GetCppThis());
		}

		// Token: 0x0600F9FE RID: 63998
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDepthPeelingPass_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F9FF RID: 63999 RVA: 0x0015B998 File Offset: 0x00159B98
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDepthPeelingPass.vtkDepthPeelingPass_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600FA00 RID: 64000
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDepthPeelingPass_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FA01 RID: 64001 RVA: 0x0015B9B8 File Offset: 0x00159BB8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDepthPeelingPass.vtkDepthPeelingPass_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600FA02 RID: 64002
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDepthPeelingPass_GetOcclusionRatio_04(HandleRef pThis);

		/// <summary>
		/// In case of use of depth peeling technique for rendering translucent
		/// material, define the threshold under which the algorithm stops to
		/// iterate over peel layers. This is the ratio of the number of pixels
		/// that have been touched by the last layer over the total number of pixels
		/// of the viewport area.
		/// Initial value is 0.0, meaning rendering have to be exact. Greater values
		/// may speed-up the rendering with small impact on the quality.
		/// </summary>
		// Token: 0x0600FA03 RID: 64003 RVA: 0x0015B9D4 File Offset: 0x00159BD4
		public virtual double GetOcclusionRatio()
		{
			return vtkDepthPeelingPass.vtkDepthPeelingPass_GetOcclusionRatio_04(base.GetCppThis());
		}

		// Token: 0x0600FA04 RID: 64004
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDepthPeelingPass_GetOcclusionRatioMaxValue_05(HandleRef pThis);

		/// <summary>
		/// In case of use of depth peeling technique for rendering translucent
		/// material, define the threshold under which the algorithm stops to
		/// iterate over peel layers. This is the ratio of the number of pixels
		/// that have been touched by the last layer over the total number of pixels
		/// of the viewport area.
		/// Initial value is 0.0, meaning rendering have to be exact. Greater values
		/// may speed-up the rendering with small impact on the quality.
		/// </summary>
		// Token: 0x0600FA05 RID: 64005 RVA: 0x0015B9F4 File Offset: 0x00159BF4
		public virtual double GetOcclusionRatioMaxValue()
		{
			return vtkDepthPeelingPass.vtkDepthPeelingPass_GetOcclusionRatioMaxValue_05(base.GetCppThis());
		}

		// Token: 0x0600FA06 RID: 64006
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDepthPeelingPass_GetOcclusionRatioMinValue_06(HandleRef pThis);

		/// <summary>
		/// In case of use of depth peeling technique for rendering translucent
		/// material, define the threshold under which the algorithm stops to
		/// iterate over peel layers. This is the ratio of the number of pixels
		/// that have been touched by the last layer over the total number of pixels
		/// of the viewport area.
		/// Initial value is 0.0, meaning rendering have to be exact. Greater values
		/// may speed-up the rendering with small impact on the quality.
		/// </summary>
		// Token: 0x0600FA07 RID: 64007 RVA: 0x0015BA14 File Offset: 0x00159C14
		public virtual double GetOcclusionRatioMinValue()
		{
			return vtkDepthPeelingPass.vtkDepthPeelingPass_GetOcclusionRatioMinValue_06(base.GetCppThis());
		}

		// Token: 0x0600FA08 RID: 64008
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDepthPeelingPass_GetTranslucentPass_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Delegate for rendering the translucent polygonal geometry.
		/// If it is NULL, nothing will be rendered and a warning will be emitted.
		/// It is usually set to a vtkTranslucentPass.
		/// Initial value is a NULL pointer.
		/// </summary>
		// Token: 0x0600FA09 RID: 64009 RVA: 0x0015BA34 File Offset: 0x00159C34
		public virtual vtkRenderPass GetTranslucentPass()
		{
			vtkRenderPass vtkRenderPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDepthPeelingPass.vtkDepthPeelingPass_GetTranslucentPass_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderPass = (vtkRenderPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderPass.Register(null);
				}
			}
			return vtkRenderPass;
		}

		// Token: 0x0600FA0A RID: 64010
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDepthPeelingPass_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FA0B RID: 64011 RVA: 0x0015BAA4 File Offset: 0x00159CA4
		public override int IsA(string type)
		{
			return vtkDepthPeelingPass.vtkDepthPeelingPass_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0600FA0C RID: 64012
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDepthPeelingPass_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FA0D RID: 64013 RVA: 0x0015BAC4 File Offset: 0x00159CC4
		public new static int IsTypeOf(string type)
		{
			return vtkDepthPeelingPass.vtkDepthPeelingPass_IsTypeOf_09(type);
		}

		// Token: 0x0600FA0E RID: 64014
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDepthPeelingPass_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FA0F RID: 64015 RVA: 0x0015BAE0 File Offset: 0x00159CE0
		public new vtkDepthPeelingPass NewInstance()
		{
			vtkDepthPeelingPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDepthPeelingPass.vtkDepthPeelingPass_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDepthPeelingPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600FA10 RID: 64016
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDepthPeelingPass_PostReplaceShaderValues_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string vertexShader, [MarshalAs(UnmanagedType.LPUTF8Str)] string geometryShader, [MarshalAs(UnmanagedType.LPUTF8Str)] string fragmentShader, HandleRef mapper, HandleRef prop);

		/// <summary>
		/// In case of depth peeling, define the maximum number of peeling layers.
		/// Initial value is 4. A special value of 0 means no maximum limit.
		/// It has to be a positive value.
		/// </summary>
		// Token: 0x0600FA11 RID: 64017 RVA: 0x0015BB3C File Offset: 0x00159D3C
		public override bool PostReplaceShaderValues(string vertexShader, string geometryShader, string fragmentShader, vtkAbstractMapper mapper, vtkProp prop)
		{
			return vtkDepthPeelingPass.vtkDepthPeelingPass_PostReplaceShaderValues_12(base.GetCppThis(), vertexShader, geometryShader, fragmentShader, (mapper == null) ? default(HandleRef) : mapper.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis()) != 0;
		}

		// Token: 0x0600FA12 RID: 64018
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDepthPeelingPass_ReleaseGraphicsResources_13(HandleRef pThis, HandleRef w);

		/// <summary>
		/// Release graphics resources and ask components to release their own
		/// resources.
		/// \pre w_exists: w!=0
		/// </summary>
		// Token: 0x0600FA13 RID: 64019 RVA: 0x0015BB94 File Offset: 0x00159D94
		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkDepthPeelingPass.vtkDepthPeelingPass_ReleaseGraphicsResources_13(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		// Token: 0x0600FA14 RID: 64020
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDepthPeelingPass_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FA15 RID: 64021 RVA: 0x0015BBC4 File Offset: 0x00159DC4
		public new static vtkDepthPeelingPass SafeDownCast(vtkObjectBase o)
		{
			vtkDepthPeelingPass vtkDepthPeelingPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDepthPeelingPass.vtkDepthPeelingPass_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDepthPeelingPass = (vtkDepthPeelingPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDepthPeelingPass.Register(null);
				}
			}
			return vtkDepthPeelingPass;
		}

		// Token: 0x0600FA16 RID: 64022
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDepthPeelingPass_SetDepthFormat_15(HandleRef pThis, int _arg);

		/// <summary>
		///  Set the format to use for the depth texture
		/// e.g. vtkTextureObject::Float32
		/// </summary>
		// Token: 0x0600FA17 RID: 64023 RVA: 0x0015BC43 File Offset: 0x00159E43
		public virtual void SetDepthFormat(int _arg)
		{
			vtkDepthPeelingPass.vtkDepthPeelingPass_SetDepthFormat_15(base.GetCppThis(), _arg);
		}

		// Token: 0x0600FA18 RID: 64024
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDepthPeelingPass_SetMaximumNumberOfPeels_16(HandleRef pThis, int _arg);

		/// <summary>
		/// In case of depth peeling, define the maximum number of peeling layers.
		/// Initial value is 4. A special value of 0 means no maximum limit.
		/// It has to be a positive value.
		/// </summary>
		// Token: 0x0600FA19 RID: 64025 RVA: 0x0015BC53 File Offset: 0x00159E53
		public virtual void SetMaximumNumberOfPeels(int _arg)
		{
			vtkDepthPeelingPass.vtkDepthPeelingPass_SetMaximumNumberOfPeels_16(base.GetCppThis(), _arg);
		}

		// Token: 0x0600FA1A RID: 64026
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDepthPeelingPass_SetOcclusionRatio_17(HandleRef pThis, double _arg);

		/// <summary>
		/// In case of use of depth peeling technique for rendering translucent
		/// material, define the threshold under which the algorithm stops to
		/// iterate over peel layers. This is the ratio of the number of pixels
		/// that have been touched by the last layer over the total number of pixels
		/// of the viewport area.
		/// Initial value is 0.0, meaning rendering have to be exact. Greater values
		/// may speed-up the rendering with small impact on the quality.
		/// </summary>
		// Token: 0x0600FA1B RID: 64027 RVA: 0x0015BC63 File Offset: 0x00159E63
		public virtual void SetOcclusionRatio(double _arg)
		{
			vtkDepthPeelingPass.vtkDepthPeelingPass_SetOcclusionRatio_17(base.GetCppThis(), _arg);
		}

		// Token: 0x0600FA1C RID: 64028
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDepthPeelingPass_SetTranslucentPass_18(HandleRef pThis, HandleRef translucentPass);

		/// <summary>
		/// Delegate for rendering the translucent polygonal geometry.
		/// If it is NULL, nothing will be rendered and a warning will be emitted.
		/// It is usually set to a vtkTranslucentPass.
		/// Initial value is a NULL pointer.
		/// </summary>
		// Token: 0x0600FA1D RID: 64029 RVA: 0x0015BC74 File Offset: 0x00159E74
		public virtual void SetTranslucentPass(vtkRenderPass translucentPass)
		{
			vtkDepthPeelingPass.vtkDepthPeelingPass_SetTranslucentPass_18(base.GetCppThis(), (translucentPass == null) ? default(HandleRef) : translucentPass.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001225 RID: 4645
		public new const string MRFullTypeName = "Kitware.VTK.vtkDepthPeelingPass";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001226 RID: 4646
		public new static readonly string MRClassNameKey = "class vtkDepthPeelingPass";
	}
}
