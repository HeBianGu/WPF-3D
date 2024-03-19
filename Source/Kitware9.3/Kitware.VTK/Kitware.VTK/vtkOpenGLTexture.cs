using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenGLTexture
	/// </summary>
	/// <remarks>
	///    OpenGL texture map
	///
	/// vtkOpenGLTexture is a concrete implementation of the abstract class
	/// vtkTexture. vtkOpenGLTexture interfaces to the OpenGL rendering library.
	/// </remarks>
	// Token: 0x0200058E RID: 1422
	public class vtkOpenGLTexture : vtkTexture
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600FB0B RID: 64267 RVA: 0x0015D0D5 File Offset: 0x0015B2D5
		static vtkOpenGLTexture()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLTexture.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLTexture"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600FB0C RID: 64268 RVA: 0x0015D0FD File Offset: 0x0015B2FD
		public vtkOpenGLTexture(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600FB0D RID: 64269
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLTexture_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FB0E RID: 64270 RVA: 0x0015D10C File Offset: 0x0015B30C
		public new static vtkOpenGLTexture New()
		{
			vtkOpenGLTexture result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLTexture.vtkOpenGLTexture_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLTexture)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FB0F RID: 64271 RVA: 0x0015D160 File Offset: 0x0015B360
		public vtkOpenGLTexture() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenGLTexture.vtkOpenGLTexture_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600FB10 RID: 64272 RVA: 0x0015D1A4 File Offset: 0x0015B3A4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600FB11 RID: 64273
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLTexture_CopyTexImage_01(HandleRef pThis, int x, int y, int width, int height);

		/// <summary>
		/// copy the renderers read buffer into this texture
		/// </summary>
		// Token: 0x0600FB12 RID: 64274 RVA: 0x0015D1AF File Offset: 0x0015B3AF
		public void CopyTexImage(int x, int y, int width, int height)
		{
			vtkOpenGLTexture.vtkOpenGLTexture_CopyTexImage_01(base.GetCppThis(), x, y, width, height);
		}

		// Token: 0x0600FB13 RID: 64275
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLTexture_GetIsDepthTexture_02(HandleRef pThis);

		/// <summary>
		/// Provide for specifying a format for the texture
		/// </summary>
		// Token: 0x0600FB14 RID: 64276 RVA: 0x0015D1C4 File Offset: 0x0015B3C4
		public virtual int GetIsDepthTexture()
		{
			return vtkOpenGLTexture.vtkOpenGLTexture_GetIsDepthTexture_02(base.GetCppThis());
		}

		// Token: 0x0600FB15 RID: 64277
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLTexture_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FB16 RID: 64278 RVA: 0x0015D1E4 File Offset: 0x0015B3E4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenGLTexture.vtkOpenGLTexture_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0600FB17 RID: 64279
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLTexture_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FB18 RID: 64280 RVA: 0x0015D204 File Offset: 0x0015B404
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenGLTexture.vtkOpenGLTexture_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0600FB19 RID: 64281
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLTexture_GetTextureType_05(HandleRef pThis);

		/// <summary>
		/// What type of texture map GL_TEXTURE_2D versus GL_TEXTURE_RECTANGLE
		/// </summary>
		// Token: 0x0600FB1A RID: 64282 RVA: 0x0015D220 File Offset: 0x0015B420
		public virtual int GetTextureType()
		{
			return vtkOpenGLTexture.vtkOpenGLTexture_GetTextureType_05(base.GetCppThis());
		}

		// Token: 0x0600FB1B RID: 64283
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLTexture_GetTextureUnit_06(HandleRef pThis);

		/// <summary>
		/// Return the texture unit used for this texture
		/// </summary>
		// Token: 0x0600FB1C RID: 64284 RVA: 0x0015D240 File Offset: 0x0015B440
		public override int GetTextureUnit()
		{
			return vtkOpenGLTexture.vtkOpenGLTexture_GetTextureUnit_06(base.GetCppThis());
		}

		// Token: 0x0600FB1D RID: 64285
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLTexture_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FB1E RID: 64286 RVA: 0x0015D260 File Offset: 0x0015B460
		public override int IsA(string type)
		{
			return vtkOpenGLTexture.vtkOpenGLTexture_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0600FB1F RID: 64287
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLTexture_IsTranslucent_08(HandleRef pThis);

		/// <summary>
		/// Is this Texture Translucent?
		/// returns false (0) if the texture is either fully opaque or has
		/// only fully transparent pixels and fully opaque pixels and the
		/// Interpolate flag is turn off.
		/// </summary>
		// Token: 0x0600FB20 RID: 64288 RVA: 0x0015D280 File Offset: 0x0015B480
		public override int IsTranslucent()
		{
			return vtkOpenGLTexture.vtkOpenGLTexture_IsTranslucent_08(base.GetCppThis());
		}

		// Token: 0x0600FB21 RID: 64289
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLTexture_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FB22 RID: 64290 RVA: 0x0015D2A0 File Offset: 0x0015B4A0
		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLTexture.vtkOpenGLTexture_IsTypeOf_09(type);
		}

		// Token: 0x0600FB23 RID: 64291
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLTexture_Load_10(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Implement base class method.
		/// </summary>
		// Token: 0x0600FB24 RID: 64292 RVA: 0x0015D2BC File Offset: 0x0015B4BC
		public override void Load(vtkRenderer arg0)
		{
			vtkOpenGLTexture.vtkOpenGLTexture_Load_10(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600FB25 RID: 64293
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLTexture_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FB26 RID: 64294 RVA: 0x0015D2EC File Offset: 0x0015B4EC
		public new vtkOpenGLTexture NewInstance()
		{
			vtkOpenGLTexture result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLTexture.vtkOpenGLTexture_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLTexture)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600FB27 RID: 64295
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLTexture_PostRender_13(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Implement base class method.
		/// </summary>
		// Token: 0x0600FB28 RID: 64296 RVA: 0x0015D348 File Offset: 0x0015B548
		public override void PostRender(vtkRenderer arg0)
		{
			vtkOpenGLTexture.vtkOpenGLTexture_PostRender_13(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600FB29 RID: 64297
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLTexture_ReleaseGraphicsResources_14(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Release any graphics resources that are being consumed by this texture.
		/// The parameter window could be used to determine which graphic
		/// resources to release. Using the same texture object in multiple
		/// render windows is NOT currently supported.
		/// </summary>
		// Token: 0x0600FB2A RID: 64298 RVA: 0x0015D378 File Offset: 0x0015B578
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkOpenGLTexture.vtkOpenGLTexture_ReleaseGraphicsResources_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600FB2B RID: 64299
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLTexture_Render_15(HandleRef pThis, HandleRef ren);

		/// <summary>
		/// Renders a texture map. It first checks the object's modified time
		/// to make sure the texture maps Input is valid, then it invokes the
		/// Load() method.
		/// </summary>
		// Token: 0x0600FB2C RID: 64300 RVA: 0x0015D3A8 File Offset: 0x0015B5A8
		public override void Render(vtkRenderer ren)
		{
			vtkOpenGLTexture.vtkOpenGLTexture_Render_15(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		// Token: 0x0600FB2D RID: 64301
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLTexture_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FB2E RID: 64302 RVA: 0x0015D3D8 File Offset: 0x0015B5D8
		public new static vtkOpenGLTexture SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLTexture vtkOpenGLTexture = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLTexture.vtkOpenGLTexture_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLTexture = (vtkOpenGLTexture)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLTexture.Register(null);
				}
			}
			return vtkOpenGLTexture;
		}

		// Token: 0x0600FB2F RID: 64303
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLTexture_SetIsDepthTexture_17(HandleRef pThis, int _arg);

		/// <summary>
		/// Provide for specifying a format for the texture
		/// </summary>
		// Token: 0x0600FB30 RID: 64304 RVA: 0x0015D457 File Offset: 0x0015B657
		public virtual void SetIsDepthTexture(int _arg)
		{
			vtkOpenGLTexture.vtkOpenGLTexture_SetIsDepthTexture_17(base.GetCppThis(), _arg);
		}

		// Token: 0x0600FB31 RID: 64305
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLTexture_SetTextureType_18(HandleRef pThis, int _arg);

		/// <summary>
		/// What type of texture map GL_TEXTURE_2D versus GL_TEXTURE_RECTANGLE
		/// </summary>
		// Token: 0x0600FB32 RID: 64306 RVA: 0x0015D467 File Offset: 0x0015B667
		public virtual void SetTextureType(int _arg)
		{
			vtkOpenGLTexture.vtkOpenGLTexture_SetTextureType_18(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001244 RID: 4676
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLTexture";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001245 RID: 4677
		public new static readonly string MRClassNameKey = "class vtkOpenGLTexture";
	}
}
