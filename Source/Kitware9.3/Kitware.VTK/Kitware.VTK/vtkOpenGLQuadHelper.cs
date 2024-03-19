using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenGLQuadHelper
	/// </summary>
	/// <remarks>
	///    Class to make rendering a full screen quad easier
	///
	/// vtkOpenGLQuadHelper is designed to be used by classes in VTK that
	/// need to render a quad to the screen with a shader program. This happens
	/// often with render passes or other advanced rendering techniques.
	///
	/// Note that when releasing graphics resources instances of this
	/// class should be destroyed. A common use pattern is to conditionally
	/// create the instance where used and delete it in ReleaseGraphicsResources
	/// and the destructor.
	///
	/// It is possible to flip the Y direction of the quad texture coordinate by
	/// turning on the flipY option in the constructor. This can be useful when
	/// rendering in an external context having a different convention than OpenGL
	/// e.g. OpenGL-D3D shared textures. Off by default if unspecified.
	///
	/// Example usage:
	/// @code
	/// if (!this-&gt;QuadHelper)
	/// {
	///   this-&gt;QuadHelper = vtkOpenGLQualHelper(renWin, vs, fs, gs);
	/// }
	/// renWin-&gt;GetShaderCache()-&gt;ReadyShaderProgram(this-&gt;QuadHelper-&gt;Program);
	/// aTexture-&gt;Activate();
	/// this-&gt;QuadHelper-&gt;Program-&gt;SetUniformi("aTexture", aTexture-&gt;GetTextureUnit());
	/// this-&gt;QuadHelper-&gt;Render();
	/// aTexture-&gt;Deactivate();
	/// @endcode
	///
	/// </remarks>
	/// <seealso>
	///  vtkOpenGLRenderUtilities
	/// </seealso>
	// Token: 0x020005C3 RID: 1475
	public class vtkOpenGLQuadHelper : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06010237 RID: 66103 RVA: 0x00167A9F File Offset: 0x00165C9F
		static vtkOpenGLQuadHelper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLQuadHelper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLQuadHelper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06010238 RID: 66104 RVA: 0x00167AC7 File Offset: 0x00165CC7
		public vtkOpenGLQuadHelper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010239 RID: 66105 RVA: 0x00167AD5 File Offset: 0x00165CD5
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601023A RID: 66106
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLQuadHelper_ReleaseGraphicsResources_01(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Release graphics resources. In general, there's no need to call this
		/// explicitly, since vtkOpenGLQuadHelper will invoke it appropriately when
		/// needed.
		/// </summary>
		// Token: 0x0601023B RID: 66107 RVA: 0x00167AE0 File Offset: 0x00165CE0
		public void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkOpenGLQuadHelper.vtkOpenGLQuadHelper_ReleaseGraphicsResources_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601023C RID: 66108
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLQuadHelper_Render_02(HandleRef pThis);

		/// <summary>
		/// Create a quadhelper with the provided shaders.
		/// If the vertex is nullptr then the default is used.
		/// Turning on the flipY option reverts the y component of the quad texture coordinates in
		/// order to flip the rendered texture.
		/// Note that this class should be destroyed upon ReleaseGraphicsResources.
		/// </summary>
		// Token: 0x0601023D RID: 66109 RVA: 0x00167B0F File Offset: 0x00165D0F
		public void Render()
		{
			vtkOpenGLQuadHelper.vtkOpenGLQuadHelper_Render_02(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012C8 RID: 4808
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLQuadHelper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012C9 RID: 4809
		public new static readonly string MRClassNameKey = "class vtkOpenGLQuadHelper";
	}
}
