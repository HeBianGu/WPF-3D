using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGLSLModPixelDebugger
	/// </summary>
	/// <remarks>
	///    Allow live pixel debugging by overwriting gl_FragData[0] output.
	///
	/// This modification significantly simplifies the lives of VTK OpenGL developers, enabling them to
	/// debug and adjust GLSL code in real-time while the application is running.
	///
	/// This eliminates the need to recompile VTK for minor shader code adjustments. Developers can
	/// conveniently keep the JSON and associated GLSL files open in a code editor, making changes while
	/// a unit test or VTK application is actively running. Ultimately, you can just move your mouse in
	/// the render window to witness your modifications taking effect!
	///
	/// Shader substitutions will need to be defined in a json file. An example is provided in
	/// Rendering/CellGrid/LiveGLSLDebugSample/sample.json file. If you've built VTK from source,
	/// you may live edit that json file and glsl files under the LiveGLSLDebugSample directory.
	/// Here is what it looks like:
	/// {
	///   "Substitutions": [
	///     {
	///       "Target": "//VTK::Light::Impl",
	///       "ShaderType": "Fragment",
	///       "FileName": "normal-debug.glsl",
	///       "ReplaceAllOccurrences": false,
	///       "FileNameIsAbsolute": false,
	///       "Enabled": false
	///     },
	///     {
	///       "Target": "//VTK::Light::Impl",
	///       "ShaderType": "Fragment",
	///       "FileName": "parametric-debug.glsl",
	///       "ReplaceAllOccurrences": false,
	///       "FileNameIsAbsolute": false,
	///       "Enabled": false
	///     }
	///   ]
	/// }
	/// In the sample, both substitutions are disabled. Please enable either to view it.
	/// Here is detailed information about the keys:
	///
	/// \li \c Substitutions: This is a list of maps that contain information about a substitution.
	///
	/// \li \c Target: This must be a string of type "//VTK::Feature::[Dec,Impl]".
	/// These are found in the shader templates.
	///
	/// \li \c ShaderType: This must be either "Fragment" or "Vertex" or "Geometry".
	///
	/// \li \c FileName: Path to a file which has glsl code which will be pasted in place of the 'Target'
	/// string.
	///
	/// \li \c ReplaceAllOccurrences: Whether to replace all occurrences of 'Target' string with the
	/// contents from the 'FileName' file.
	///
	/// \li \c FileNameIsAbsolute: Whether 'FileName' is an absolute path or relative to the json file.
	///
	/// \li \c Enabled: When enabled is true, the mod will perform the substitution, otherwise, the
	/// substitution is not applied.
	/// </remarks>
	// Token: 0x02000596 RID: 1430
	public class vtkGLSLModPixelDebugger : vtkGLSLModifierBase
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600FBD8 RID: 64472 RVA: 0x0015E8E7 File Offset: 0x0015CAE7
		static vtkGLSLModPixelDebugger()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGLSLModPixelDebugger.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGLSLModPixelDebugger"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600FBD9 RID: 64473 RVA: 0x0015E90F File Offset: 0x0015CB0F
		public vtkGLSLModPixelDebugger(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600FBDA RID: 64474
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGLSLModPixelDebugger_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FBDB RID: 64475 RVA: 0x0015E920 File Offset: 0x0015CB20
		public new static vtkGLSLModPixelDebugger New()
		{
			vtkGLSLModPixelDebugger result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGLSLModPixelDebugger.vtkGLSLModPixelDebugger_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGLSLModPixelDebugger)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FBDC RID: 64476 RVA: 0x0015E974 File Offset: 0x0015CB74
		public vtkGLSLModPixelDebugger() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGLSLModPixelDebugger.vtkGLSLModPixelDebugger_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600FBDD RID: 64477 RVA: 0x0015E9B8 File Offset: 0x0015CBB8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600FBDE RID: 64478
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGLSLModPixelDebugger_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FBDF RID: 64479 RVA: 0x0015E9C4 File Offset: 0x0015CBC4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGLSLModPixelDebugger.vtkGLSLModPixelDebugger_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600FBE0 RID: 64480
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGLSLModPixelDebugger_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FBE1 RID: 64481 RVA: 0x0015E9E4 File Offset: 0x0015CBE4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGLSLModPixelDebugger.vtkGLSLModPixelDebugger_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600FBE2 RID: 64482
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGLSLModPixelDebugger_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FBE3 RID: 64483 RVA: 0x0015EA00 File Offset: 0x0015CC00
		public override int IsA(string type)
		{
			return vtkGLSLModPixelDebugger.vtkGLSLModPixelDebugger_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600FBE4 RID: 64484
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGLSLModPixelDebugger_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FBE5 RID: 64485 RVA: 0x0015EA20 File Offset: 0x0015CC20
		public new static int IsTypeOf(string type)
		{
			return vtkGLSLModPixelDebugger.vtkGLSLModPixelDebugger_IsTypeOf_04(type);
		}

		// Token: 0x0600FBE6 RID: 64486
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGLSLModPixelDebugger_IsUpToDate_05(HandleRef pThis, HandleRef arg0, HandleRef arg1, HandleRef arg2);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FBE7 RID: 64487 RVA: 0x0015EA3C File Offset: 0x0015CC3C
		public override bool IsUpToDate(vtkOpenGLRenderer arg0, vtkAbstractMapper arg1, vtkActor arg2)
		{
			return vtkGLSLModPixelDebugger.vtkGLSLModPixelDebugger_IsUpToDate_05(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis(), (arg2 == null) ? default(HandleRef) : arg2.GetCppThis()) != 0;
		}

		// Token: 0x0600FBE8 RID: 64488
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGLSLModPixelDebugger_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FBE9 RID: 64489 RVA: 0x0015EAA4 File Offset: 0x0015CCA4
		public new vtkGLSLModPixelDebugger NewInstance()
		{
			vtkGLSLModPixelDebugger result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGLSLModPixelDebugger.vtkGLSLModPixelDebugger_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGLSLModPixelDebugger)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600FBEA RID: 64490
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGLSLModPixelDebugger_ReplaceShaderValues_08(HandleRef pThis, HandleRef renderer, [MarshalAs(UnmanagedType.LPUTF8Str)] string vertexShader, [MarshalAs(UnmanagedType.LPUTF8Str)] string geometryShader, [MarshalAs(UnmanagedType.LPUTF8Str)] string fragmentShader, HandleRef mapper, HandleRef actor);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FBEB RID: 64491 RVA: 0x0015EB00 File Offset: 0x0015CD00
		public override bool ReplaceShaderValues(vtkOpenGLRenderer renderer, string vertexShader, string geometryShader, string fragmentShader, vtkAbstractMapper mapper, vtkActor actor)
		{
			return vtkGLSLModPixelDebugger.vtkGLSLModPixelDebugger_ReplaceShaderValues_08(base.GetCppThis(), (renderer == null) ? default(HandleRef) : renderer.GetCppThis(), vertexShader, geometryShader, fragmentShader, (mapper == null) ? default(HandleRef) : mapper.GetCppThis(), (actor == null) ? default(HandleRef) : actor.GetCppThis()) != 0;
		}

		// Token: 0x0600FBEC RID: 64492
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGLSLModPixelDebugger_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FBED RID: 64493 RVA: 0x0015EB70 File Offset: 0x0015CD70
		public new static vtkGLSLModPixelDebugger SafeDownCast(vtkObjectBase o)
		{
			vtkGLSLModPixelDebugger vtkGLSLModPixelDebugger = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGLSLModPixelDebugger.vtkGLSLModPixelDebugger_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGLSLModPixelDebugger = (vtkGLSLModPixelDebugger)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGLSLModPixelDebugger.Register(null);
				}
			}
			return vtkGLSLModPixelDebugger;
		}

		// Token: 0x0600FBEE RID: 64494
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLSLModPixelDebugger_SetSubstitutionJSONFileName_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string filename);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FBEF RID: 64495 RVA: 0x0015EBEF File Offset: 0x0015CDEF
		public void SetSubstitutionJSONFileName(string filename)
		{
			vtkGLSLModPixelDebugger.vtkGLSLModPixelDebugger_SetSubstitutionJSONFileName_10(base.GetCppThis(), filename);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001254 RID: 4692
		public new const string MRFullTypeName = "Kitware.VTK.vtkGLSLModPixelDebugger";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001255 RID: 4693
		public new static readonly string MRClassNameKey = "class vtkGLSLModPixelDebugger";
	}
}
