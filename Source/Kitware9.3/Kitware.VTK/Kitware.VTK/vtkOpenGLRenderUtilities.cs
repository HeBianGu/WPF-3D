using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenGLRenderUtilities
	/// </summary>
	/// <remarks>
	///    OpenGL rendering utility functions
	///
	/// vtkOpenGLRenderUtilities provides functions to help render primitives.
	///
	/// See also the vtkOpenGLQuadHelper class which may be easier to use.
	///
	/// </remarks>
	// Token: 0x020005C6 RID: 1478
	public class vtkOpenGLRenderUtilities : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601028C RID: 66188 RVA: 0x0016817B File Offset: 0x0016637B
		static vtkOpenGLRenderUtilities()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLRenderUtilities.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLRenderUtilities"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601028D RID: 66189 RVA: 0x001681A3 File Offset: 0x001663A3
		public vtkOpenGLRenderUtilities(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601028E RID: 66190 RVA: 0x001681B1 File Offset: 0x001663B1
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601028F RID: 66191
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLRenderUtilities_DrawFullScreenQuad_01();

		/// <summary>
		/// Draw a full-screen quad:
		///
		/// * VertexShader and GeometryShader should be used as-is when building the
		/// ShaderProgram.
		/// * FragmentShaderTemplate supports the replacements @code //VTK::FSQ::Decl @endcode and
		/// @code //VTK::FSQ::Impl @endcode for declaring variables and the shader body,
		/// respectively.
		/// * The varying texCoord is available to the fragment shader for texture
		/// lookups into full-screen textures, ie. texture2D(textureName, texCoord).
		/// * PrepFullScreenVAO initializes a new VAO for drawing a quad.
		/// * DrawFullScreenQuad actually draws the quad.
		///
		/// Example usage:
		/// @code
		/// typedef vtkOpenGLRenderUtilities GLUtil;
		///
		/// // Prep fragment shader source:
		/// std::string fragShader = GLUtil::GetFullScreenQuadFragmentShaderTemplate();
		/// vtkShaderProgram::Substitute(fragShader, "//VTK::FSQ::Decl",
		/// "uniform sampler2D aTexture;");
		/// vtkShaderProgram::Substitute(fragShader, "//VTK::FSQ::Impl",
		/// "gl_FragData[0] = texture2D(aTexture, texCoord);");
		///
		/// // Create shader program:
		/// vtkShaderProgram *prog = shaderCache-&gt;ReadyShaderProgram(
		/// GLUtil::GetFullScreenQuadVertexShader().c_str(),
		/// fragShader.c_str(),
		/// GLUtil::GetFullScreenQuadGeometryShader().c_str());
		///
		/// // Initialize new VAO/vertex buffer. This is only done once:
		/// vtkNew&lt;vtkOpenGLVertexArrayObject&gt; vao;
		/// GLUtil::PrepFullScreenVAO(renWin, vao.Get(), prog);
		///
		/// // Setup shader program to sample vtkTextureObject aTexture:
		/// aTexture-&gt;Activate();
		/// prog-&gt;SetUniformi("aTexture", aTexture-&gt;GetTextureUnit());
		///
		/// // Render the full-screen quad:
		/// vao-&gt;Bind();
		/// GLUtil::DrawFullScreenQuad();
		/// vao-&gt;Release();
		/// aTexture-&gt;Deactivate();
		/// @endcode
		/// </summary>
		// Token: 0x06010290 RID: 66192 RVA: 0x001681BC File Offset: 0x001663BC
		public static void DrawFullScreenQuad()
		{
			vtkOpenGLRenderUtilities.vtkOpenGLRenderUtilities_DrawFullScreenQuad_01();
		}

		// Token: 0x06010291 RID: 66193
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkOpenGLRenderUtilities_GetFullScreenQuadFragmentShaderTemplate_02();

		/// <summary>
		/// Draw a full-screen quad:
		///
		/// * VertexShader and GeometryShader should be used as-is when building the
		/// ShaderProgram.
		/// * FragmentShaderTemplate supports the replacements @code //VTK::FSQ::Decl @endcode and
		/// @code //VTK::FSQ::Impl @endcode for declaring variables and the shader body,
		/// respectively.
		/// * The varying texCoord is available to the fragment shader for texture
		/// lookups into full-screen textures, ie. texture2D(textureName, texCoord).
		/// * PrepFullScreenVAO initializes a new VAO for drawing a quad.
		/// * DrawFullScreenQuad actually draws the quad.
		///
		/// Example usage:
		/// @code
		/// typedef vtkOpenGLRenderUtilities GLUtil;
		///
		/// // Prep fragment shader source:
		/// std::string fragShader = GLUtil::GetFullScreenQuadFragmentShaderTemplate();
		/// vtkShaderProgram::Substitute(fragShader, "//VTK::FSQ::Decl",
		/// "uniform sampler2D aTexture;");
		/// vtkShaderProgram::Substitute(fragShader, "//VTK::FSQ::Impl",
		/// "gl_FragData[0] = texture2D(aTexture, texCoord);");
		///
		/// // Create shader program:
		/// vtkShaderProgram *prog = shaderCache-&gt;ReadyShaderProgram(
		/// GLUtil::GetFullScreenQuadVertexShader().c_str(),
		/// fragShader.c_str(),
		/// GLUtil::GetFullScreenQuadGeometryShader().c_str());
		///
		/// // Initialize new VAO/vertex buffer. This is only done once:
		/// vtkNew&lt;vtkOpenGLVertexArrayObject&gt; vao;
		/// GLUtil::PrepFullScreenVAO(renWin, vao.Get(), prog);
		///
		/// // Setup shader program to sample vtkTextureObject aTexture:
		/// aTexture-&gt;Activate();
		/// prog-&gt;SetUniformi("aTexture", aTexture-&gt;GetTextureUnit());
		///
		/// // Render the full-screen quad:
		/// vao-&gt;Bind();
		/// GLUtil::DrawFullScreenQuad();
		/// vao-&gt;Release();
		/// aTexture-&gt;Deactivate();
		/// @endcode
		/// </summary>
		// Token: 0x06010292 RID: 66194 RVA: 0x001681C8 File Offset: 0x001663C8
		public static string GetFullScreenQuadFragmentShaderTemplate()
		{
			return vtkOpenGLRenderUtilities.vtkOpenGLRenderUtilities_GetFullScreenQuadFragmentShaderTemplate_02();
		}

		// Token: 0x06010293 RID: 66195
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkOpenGLRenderUtilities_GetFullScreenQuadGeometryShader_03();

		/// <summary>
		/// Draw a full-screen quad:
		///
		/// * VertexShader and GeometryShader should be used as-is when building the
		/// ShaderProgram.
		/// * FragmentShaderTemplate supports the replacements @code //VTK::FSQ::Decl @endcode and
		/// @code //VTK::FSQ::Impl @endcode for declaring variables and the shader body,
		/// respectively.
		/// * The varying texCoord is available to the fragment shader for texture
		/// lookups into full-screen textures, ie. texture2D(textureName, texCoord).
		/// * PrepFullScreenVAO initializes a new VAO for drawing a quad.
		/// * DrawFullScreenQuad actually draws the quad.
		///
		/// Example usage:
		/// @code
		/// typedef vtkOpenGLRenderUtilities GLUtil;
		///
		/// // Prep fragment shader source:
		/// std::string fragShader = GLUtil::GetFullScreenQuadFragmentShaderTemplate();
		/// vtkShaderProgram::Substitute(fragShader, "//VTK::FSQ::Decl",
		/// "uniform sampler2D aTexture;");
		/// vtkShaderProgram::Substitute(fragShader, "//VTK::FSQ::Impl",
		/// "gl_FragData[0] = texture2D(aTexture, texCoord);");
		///
		/// // Create shader program:
		/// vtkShaderProgram *prog = shaderCache-&gt;ReadyShaderProgram(
		/// GLUtil::GetFullScreenQuadVertexShader().c_str(),
		/// fragShader.c_str(),
		/// GLUtil::GetFullScreenQuadGeometryShader().c_str());
		///
		/// // Initialize new VAO/vertex buffer. This is only done once:
		/// vtkNew&lt;vtkOpenGLVertexArrayObject&gt; vao;
		/// GLUtil::PrepFullScreenVAO(renWin, vao.Get(), prog);
		///
		/// // Setup shader program to sample vtkTextureObject aTexture:
		/// aTexture-&gt;Activate();
		/// prog-&gt;SetUniformi("aTexture", aTexture-&gt;GetTextureUnit());
		///
		/// // Render the full-screen quad:
		/// vao-&gt;Bind();
		/// GLUtil::DrawFullScreenQuad();
		/// vao-&gt;Release();
		/// aTexture-&gt;Deactivate();
		/// @endcode
		/// </summary>
		// Token: 0x06010294 RID: 66196 RVA: 0x001681E4 File Offset: 0x001663E4
		public static string GetFullScreenQuadGeometryShader()
		{
			return vtkOpenGLRenderUtilities.vtkOpenGLRenderUtilities_GetFullScreenQuadGeometryShader_03();
		}

		// Token: 0x06010295 RID: 66197
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkOpenGLRenderUtilities_GetFullScreenQuadVertexShader_04();

		/// <summary>
		/// Draw a full-screen quad:
		///
		/// * VertexShader and GeometryShader should be used as-is when building the
		/// ShaderProgram.
		/// * FragmentShaderTemplate supports the replacements @code //VTK::FSQ::Decl @endcode and
		/// @code //VTK::FSQ::Impl @endcode for declaring variables and the shader body,
		/// respectively.
		/// * The varying texCoord is available to the fragment shader for texture
		/// lookups into full-screen textures, ie. texture2D(textureName, texCoord).
		/// * PrepFullScreenVAO initializes a new VAO for drawing a quad.
		/// * DrawFullScreenQuad actually draws the quad.
		///
		/// Example usage:
		/// @code
		/// typedef vtkOpenGLRenderUtilities GLUtil;
		///
		/// // Prep fragment shader source:
		/// std::string fragShader = GLUtil::GetFullScreenQuadFragmentShaderTemplate();
		/// vtkShaderProgram::Substitute(fragShader, "//VTK::FSQ::Decl",
		/// "uniform sampler2D aTexture;");
		/// vtkShaderProgram::Substitute(fragShader, "//VTK::FSQ::Impl",
		/// "gl_FragData[0] = texture2D(aTexture, texCoord);");
		///
		/// // Create shader program:
		/// vtkShaderProgram *prog = shaderCache-&gt;ReadyShaderProgram(
		/// GLUtil::GetFullScreenQuadVertexShader().c_str(),
		/// fragShader.c_str(),
		/// GLUtil::GetFullScreenQuadGeometryShader().c_str());
		///
		/// // Initialize new VAO/vertex buffer. This is only done once:
		/// vtkNew&lt;vtkOpenGLVertexArrayObject&gt; vao;
		/// GLUtil::PrepFullScreenVAO(renWin, vao.Get(), prog);
		///
		/// // Setup shader program to sample vtkTextureObject aTexture:
		/// aTexture-&gt;Activate();
		/// prog-&gt;SetUniformi("aTexture", aTexture-&gt;GetTextureUnit());
		///
		/// // Render the full-screen quad:
		/// vao-&gt;Bind();
		/// GLUtil::DrawFullScreenQuad();
		/// vao-&gt;Release();
		/// aTexture-&gt;Deactivate();
		/// @endcode
		/// </summary>
		// Token: 0x06010296 RID: 66198 RVA: 0x00168200 File Offset: 0x00166400
		public static string GetFullScreenQuadVertexShader()
		{
			return vtkOpenGLRenderUtilities.vtkOpenGLRenderUtilities_GetFullScreenQuadVertexShader_04();
		}

		// Token: 0x06010297 RID: 66199
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLRenderUtilities_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010298 RID: 66200 RVA: 0x0016821C File Offset: 0x0016641C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenGLRenderUtilities.vtkOpenGLRenderUtilities_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06010299 RID: 66201
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLRenderUtilities_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601029A RID: 66202 RVA: 0x0016823C File Offset: 0x0016643C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenGLRenderUtilities.vtkOpenGLRenderUtilities_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0601029B RID: 66203
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLRenderUtilities_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601029C RID: 66204 RVA: 0x00168258 File Offset: 0x00166458
		public override int IsA(string type)
		{
			return vtkOpenGLRenderUtilities.vtkOpenGLRenderUtilities_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601029D RID: 66205
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLRenderUtilities_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601029E RID: 66206 RVA: 0x00168278 File Offset: 0x00166478
		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLRenderUtilities.vtkOpenGLRenderUtilities_IsTypeOf_08(type);
		}

		// Token: 0x0601029F RID: 66207
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLRenderUtilities_MarkDebugEvent_09([MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Pass a debugging mark to the render engine to assist development via tools
		/// like apitrace. This calls glDebugMessageInsert to insert the event string
		/// into the OpenGL command stream.
		///
		/// Note that this method only works when glDebugMessageInsert is bound, which
		/// it may not be on certain platforms.
		/// </summary>
		// Token: 0x060102A0 RID: 66208 RVA: 0x00168292 File Offset: 0x00166492
		public static void MarkDebugEvent(string arg0)
		{
			vtkOpenGLRenderUtilities.vtkOpenGLRenderUtilities_MarkDebugEvent_09(arg0);
		}

		// Token: 0x060102A1 RID: 66209
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLRenderUtilities_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060102A2 RID: 66210 RVA: 0x0016829C File Offset: 0x0016649C
		public new vtkOpenGLRenderUtilities NewInstance()
		{
			vtkOpenGLRenderUtilities result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLRenderUtilities.vtkOpenGLRenderUtilities_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLRenderUtilities)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060102A3 RID: 66211
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLRenderUtilities_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060102A4 RID: 66212 RVA: 0x001682F8 File Offset: 0x001664F8
		public new static vtkOpenGLRenderUtilities SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLRenderUtilities vtkOpenGLRenderUtilities = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLRenderUtilities.vtkOpenGLRenderUtilities_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLRenderUtilities = (vtkOpenGLRenderUtilities)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLRenderUtilities.Register(null);
				}
			}
			return vtkOpenGLRenderUtilities;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012CE RID: 4814
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLRenderUtilities";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012CF RID: 4815
		public new static readonly string MRClassNameKey = "class vtkOpenGLRenderUtilities";
	}
}
