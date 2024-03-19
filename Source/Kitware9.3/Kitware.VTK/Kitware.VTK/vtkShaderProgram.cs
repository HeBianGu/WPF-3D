using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkShaderProgram
	/// </summary>
	/// <remarks>
	///    a glsl shader program
	///
	/// This class contains the vertex, fragment, geometry shaders that combine to make a shader program
	/// </remarks>
	// Token: 0x020005EA RID: 1514
	public class vtkShaderProgram : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06010799 RID: 67481 RVA: 0x0016FBAF File Offset: 0x0016DDAF
		static vtkShaderProgram()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkShaderProgram.MRClassNameKey, Type.GetType("Kitware.VTK.vtkShaderProgram"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601079A RID: 67482 RVA: 0x0016FBD7 File Offset: 0x0016DDD7
		public vtkShaderProgram(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601079B RID: 67483
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkShaderProgram_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601079C RID: 67484 RVA: 0x0016FBE8 File Offset: 0x0016DDE8
		public new static vtkShaderProgram New()
		{
			vtkShaderProgram result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkShaderProgram.vtkShaderProgram_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkShaderProgram)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601079D RID: 67485 RVA: 0x0016FC3C File Offset: 0x0016DE3C
		public vtkShaderProgram() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkShaderProgram.vtkShaderProgram_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601079E RID: 67486 RVA: 0x0016FC80 File Offset: 0x0016DE80
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601079F RID: 67487
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkShaderProgram_CompiledOff_01(HandleRef pThis);

		/// <summary>
		/// Set/Get flag for if this program is compiled
		/// </summary>
		// Token: 0x060107A0 RID: 67488 RVA: 0x0016FC8B File Offset: 0x0016DE8B
		public virtual void CompiledOff()
		{
			vtkShaderProgram.vtkShaderProgram_CompiledOff_01(base.GetCppThis());
		}

		// Token: 0x060107A1 RID: 67489
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkShaderProgram_CompiledOn_02(HandleRef pThis);

		/// <summary>
		/// Set/Get flag for if this program is compiled
		/// </summary>
		// Token: 0x060107A2 RID: 67490 RVA: 0x0016FC9A File Offset: 0x0016DE9A
		public virtual void CompiledOn()
		{
			vtkShaderProgram.vtkShaderProgram_CompiledOn_02(base.GetCppThis());
		}

		// Token: 0x060107A3 RID: 67491
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkShaderProgram_DisableAttributeArray_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Disable the named attribute array. Return false if the attribute array is
		/// not contained in the linked shader program.
		/// </summary>
		// Token: 0x060107A4 RID: 67492 RVA: 0x0016FCAC File Offset: 0x0016DEAC
		public bool DisableAttributeArray(string name)
		{
			return vtkShaderProgram.vtkShaderProgram_DisableAttributeArray_03(base.GetCppThis(), name) != 0;
		}

		// Token: 0x060107A5 RID: 67493
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkShaderProgram_EnableAttributeArray_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Enable the named attribute array. Return false if the attribute array is
		/// not contained in the linked shader program.
		/// </summary>
		// Token: 0x060107A6 RID: 67494 RVA: 0x0016FCD4 File Offset: 0x0016DED4
		public bool EnableAttributeArray(string name)
		{
			return vtkShaderProgram.vtkShaderProgram_EnableAttributeArray_04(base.GetCppThis(), name) != 0;
		}

		// Token: 0x060107A7 RID: 67495
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkShaderProgram_FindAttributeArray_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Set/Get times that can be used to track when a set of
		/// uniforms was last updated. This can be used to reduce
		/// redundant SetUniformCalls
		/// </summary>
		// Token: 0x060107A8 RID: 67496 RVA: 0x0016FCFC File Offset: 0x0016DEFC
		public int FindAttributeArray(string name)
		{
			return vtkShaderProgram.vtkShaderProgram_FindAttributeArray_05(base.GetCppThis(), name);
		}

		// Token: 0x060107A9 RID: 67497
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkShaderProgram_FindUniform_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Set/Get times that can be used to track when a set of
		/// uniforms was last updated. This can be used to reduce
		/// redundant SetUniformCalls
		/// </summary>
		// Token: 0x060107AA RID: 67498 RVA: 0x0016FD1C File Offset: 0x0016DF1C
		public int FindUniform(string name)
		{
			return vtkShaderProgram.vtkShaderProgram_FindUniform_06(base.GetCppThis(), name);
		}

		// Token: 0x060107AB RID: 67499
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkShaderProgram_GetCompiled_07(HandleRef pThis);

		/// <summary>
		/// Set/Get flag for if this program is compiled
		/// </summary>
		// Token: 0x060107AC RID: 67500 RVA: 0x0016FD3C File Offset: 0x0016DF3C
		public virtual bool GetCompiled()
		{
			return vtkShaderProgram.vtkShaderProgram_GetCompiled_07(base.GetCppThis()) != 0;
		}

		// Token: 0x060107AD RID: 67501
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkShaderProgram_GetError_08(HandleRef pThis);

		/// <summary>
		/// Get the error message (empty if none) for the shader program. 
		/// </summary>
		// Token: 0x060107AE RID: 67502 RVA: 0x0016FD64 File Offset: 0x0016DF64
		public string GetError()
		{
			return vtkShaderProgram.vtkShaderProgram_GetError_08(base.GetCppThis());
		}

		// Token: 0x060107AF RID: 67503
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkShaderProgram_GetFileNamePrefixForDebugging_09(HandleRef pThis);

		/// <summary>
		/// When developing shaders, it's often convenient to tweak the shader and
		/// re-render incrementally. This provides a mechanism to do the same. To debug
		/// any shader program, set `FileNamePrefixForDebugging` to a file path e.g.
		/// `/tmp/myshaders`. Subsequently, when `Bind()` is called on the shader
		/// program, it will check for files named `&lt;FileNamePrefixForDebugging&gt;VS.glsl`,
		/// `&lt;FileNamePrefixForDebugging&gt;GS.glsl` and `&lt;FileNamePrefixForDebugging&gt;FS.glsl` for
		/// vertex shader, geometry shader and fragment shader codes respectively. If
		/// a file doesn't exist, then it dumps out the current code to that file.
		/// If the file exists, then the shader is recompiled to use the contents of that file.
		/// Thus, after the files have been dumped in the first render, you can open the files
		/// in a text editor and update as needed. On following render, the modified
		/// contexts from the file will be used.
		///
		/// This is only intended for debugging during development and should not be
		/// used in production.
		/// </summary>
		// Token: 0x060107B0 RID: 67504 RVA: 0x0016FD84 File Offset: 0x0016DF84
		public virtual string GetFileNamePrefixForDebugging()
		{
			string s = Marshal.PtrToStringAnsi(vtkShaderProgram.vtkShaderProgram_GetFileNamePrefixForDebugging_09(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060107B1 RID: 67505
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkShaderProgram_GetFragmentShader_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the fragment shader for this program
		/// </summary>
		// Token: 0x060107B2 RID: 67506 RVA: 0x0016FDC0 File Offset: 0x0016DFC0
		public virtual vtkShader GetFragmentShader()
		{
			vtkShader vtkShader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkShaderProgram.vtkShaderProgram_GetFragmentShader_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkShader = (vtkShader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkShader.Register(null);
				}
			}
			return vtkShader;
		}

		// Token: 0x060107B3 RID: 67507
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkShaderProgram_GetGeometryShader_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the geometry shader for this program
		/// </summary>
		// Token: 0x060107B4 RID: 67508 RVA: 0x0016FE30 File Offset: 0x0016E030
		public virtual vtkShader GetGeometryShader()
		{
			vtkShader vtkShader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkShaderProgram.vtkShaderProgram_GetGeometryShader_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkShader = (vtkShader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkShader.Register(null);
				}
			}
			return vtkShader;
		}

		// Token: 0x060107B5 RID: 67509
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkShaderProgram_GetHandle_12(HandleRef pThis);

		/// <summary>
		/// Get the handle of the shader program. 
		/// </summary>
		// Token: 0x060107B6 RID: 67510 RVA: 0x0016FEA0 File Offset: 0x0016E0A0
		public int GetHandle()
		{
			return vtkShaderProgram.vtkShaderProgram_GetHandle_12(base.GetCppThis());
		}

		// Token: 0x060107B7 RID: 67511
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkShaderProgram_GetMD5Hash_13(HandleRef pThis);

		/// <summary>
		/// Set/Get the md5 hash of this program
		/// </summary>
		// Token: 0x060107B8 RID: 67512 RVA: 0x0016FEC0 File Offset: 0x0016E0C0
		public string GetMD5Hash()
		{
			return vtkShaderProgram.vtkShaderProgram_GetMD5Hash_13(base.GetCppThis());
		}

		// Token: 0x060107B9 RID: 67513
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkShaderProgram_GetNumberOfGenerationsFromBase_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060107BA RID: 67514 RVA: 0x0016FEE0 File Offset: 0x0016E0E0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkShaderProgram.vtkShaderProgram_GetNumberOfGenerationsFromBase_14(base.GetCppThis(), type);
		}

		// Token: 0x060107BB RID: 67515
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkShaderProgram_GetNumberOfGenerationsFromBaseType_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060107BC RID: 67516 RVA: 0x0016FF00 File Offset: 0x0016E100
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkShaderProgram.vtkShaderProgram_GetNumberOfGenerationsFromBaseType_15(type);
		}

		// Token: 0x060107BD RID: 67517
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkShaderProgram_GetUniformGroupUpdateTime_16(HandleRef pThis, int arg0);

		/// <summary>
		/// Set/Get times that can be used to track when a set of
		/// uniforms was last updated. This can be used to reduce
		/// redundant SetUniformCalls
		/// </summary>
		// Token: 0x060107BE RID: 67518 RVA: 0x0016FF1C File Offset: 0x0016E11C
		public ulong GetUniformGroupUpdateTime(int arg0)
		{
			return vtkShaderProgram.vtkShaderProgram_GetUniformGroupUpdateTime_16(base.GetCppThis(), arg0);
		}

		// Token: 0x060107BF RID: 67519
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkShaderProgram_GetVertexShader_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the vertex shader for this program
		/// </summary>
		// Token: 0x060107C0 RID: 67520 RVA: 0x0016FF3C File Offset: 0x0016E13C
		public virtual vtkShader GetVertexShader()
		{
			vtkShader vtkShader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkShaderProgram.vtkShaderProgram_GetVertexShader_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkShader = (vtkShader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkShader.Register(null);
				}
			}
			return vtkShader;
		}

		// Token: 0x060107C1 RID: 67521
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkShaderProgram_IsA_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060107C2 RID: 67522 RVA: 0x0016FFAC File Offset: 0x0016E1AC
		public override int IsA(string type)
		{
			return vtkShaderProgram.vtkShaderProgram_IsA_18(base.GetCppThis(), type);
		}

		// Token: 0x060107C3 RID: 67523
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkShaderProgram_IsAttributeUsed_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Return true if the compiled and linked shader has an attribute matching @a
		/// name.
		/// </summary>
		// Token: 0x060107C4 RID: 67524 RVA: 0x0016FFCC File Offset: 0x0016E1CC
		public bool IsAttributeUsed(string name)
		{
			return vtkShaderProgram.vtkShaderProgram_IsAttributeUsed_19(base.GetCppThis(), name) != 0;
		}

		// Token: 0x060107C5 RID: 67525
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkShaderProgram_IsTypeOf_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060107C6 RID: 67526 RVA: 0x0016FFF4 File Offset: 0x0016E1F4
		public new static int IsTypeOf(string type)
		{
			return vtkShaderProgram.vtkShaderProgram_IsTypeOf_20(type);
		}

		// Token: 0x060107C7 RID: 67527
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkShaderProgram_IsUniformUsed_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// methods to inquire as to what uniforms/attributes are used by
		/// this shader.  This can save some compute time if the uniforms
		/// or attributes are expensive to compute
		/// </summary>
		// Token: 0x060107C8 RID: 67528 RVA: 0x00170010 File Offset: 0x0016E210
		public bool IsUniformUsed(string arg0)
		{
			return vtkShaderProgram.vtkShaderProgram_IsUniformUsed_21(base.GetCppThis(), arg0) != 0;
		}

		// Token: 0x060107C9 RID: 67529
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkShaderProgram_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060107CA RID: 67530 RVA: 0x00170038 File Offset: 0x0016E238
		public new vtkShaderProgram NewInstance()
		{
			vtkShaderProgram result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkShaderProgram.vtkShaderProgram_NewInstance_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkShaderProgram)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060107CB RID: 67531
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkShaderProgram_ReleaseGraphicsResources_24(HandleRef pThis, HandleRef win);

		/// <summary>
		/// release any graphics resources this class is using.
		/// </summary>
		// Token: 0x060107CC RID: 67532 RVA: 0x00170094 File Offset: 0x0016E294
		public void ReleaseGraphicsResources(vtkWindow win)
		{
			vtkShaderProgram.vtkShaderProgram_ReleaseGraphicsResources_24(base.GetCppThis(), (win == null) ? default(HandleRef) : win.GetCppThis());
		}

		// Token: 0x060107CD RID: 67533
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkShaderProgram_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060107CE RID: 67534 RVA: 0x001700C4 File Offset: 0x0016E2C4
		public new static vtkShaderProgram SafeDownCast(vtkObjectBase o)
		{
			vtkShaderProgram vtkShaderProgram = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkShaderProgram.vtkShaderProgram_SafeDownCast_25((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkShaderProgram = (vtkShaderProgram)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkShaderProgram.Register(null);
				}
			}
			return vtkShaderProgram;
		}

		// Token: 0x060107CF RID: 67535
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkShaderProgram_SetCompiled_26(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get flag for if this program is compiled
		/// </summary>
		// Token: 0x060107D0 RID: 67536 RVA: 0x00170143 File Offset: 0x0016E343
		public virtual void SetCompiled(bool _arg)
		{
			vtkShaderProgram.vtkShaderProgram_SetCompiled_26(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060107D1 RID: 67537
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkShaderProgram_SetFileNamePrefixForDebugging_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// When developing shaders, it's often convenient to tweak the shader and
		/// re-render incrementally. This provides a mechanism to do the same. To debug
		/// any shader program, set `FileNamePrefixForDebugging` to a file path e.g.
		/// `/tmp/myshaders`. Subsequently, when `Bind()` is called on the shader
		/// program, it will check for files named `&lt;FileNamePrefixForDebugging&gt;VS.glsl`,
		/// `&lt;FileNamePrefixForDebugging&gt;GS.glsl` and `&lt;FileNamePrefixForDebugging&gt;FS.glsl` for
		/// vertex shader, geometry shader and fragment shader codes respectively. If
		/// a file doesn't exist, then it dumps out the current code to that file.
		/// If the file exists, then the shader is recompiled to use the contents of that file.
		/// Thus, after the files have been dumped in the first render, you can open the files
		/// in a text editor and update as needed. On following render, the modified
		/// contexts from the file will be used.
		///
		/// This is only intended for debugging during development and should not be
		/// used in production.
		/// </summary>
		// Token: 0x060107D2 RID: 67538 RVA: 0x0017015B File Offset: 0x0016E35B
		public virtual void SetFileNamePrefixForDebugging(string _arg)
		{
			vtkShaderProgram.vtkShaderProgram_SetFileNamePrefixForDebugging_27(base.GetCppThis(), _arg);
		}

		// Token: 0x060107D3 RID: 67539
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkShaderProgram_SetFragmentShader_28(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get the fragment shader for this program
		/// </summary>
		// Token: 0x060107D4 RID: 67540 RVA: 0x0017016C File Offset: 0x0016E36C
		public void SetFragmentShader(vtkShader arg0)
		{
			vtkShaderProgram.vtkShaderProgram_SetFragmentShader_28(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060107D5 RID: 67541
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkShaderProgram_SetGeometryShader_29(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get the geometry shader for this program
		/// </summary>
		// Token: 0x060107D6 RID: 67542 RVA: 0x0017019C File Offset: 0x0016E39C
		public void SetGeometryShader(vtkShader arg0)
		{
			vtkShaderProgram.vtkShaderProgram_SetGeometryShader_29(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060107D7 RID: 67543
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkShaderProgram_SetMD5Hash_30(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string hash);

		/// <summary>
		/// Set/Get the md5 hash of this program
		/// </summary>
		// Token: 0x060107D8 RID: 67544 RVA: 0x001701CB File Offset: 0x0016E3CB
		public void SetMD5Hash(string hash)
		{
			vtkShaderProgram.vtkShaderProgram_SetMD5Hash_30(base.GetCppThis(), hash);
		}

		// Token: 0x060107D9 RID: 67545
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkShaderProgram_SetNumberOfOutputs_31(HandleRef pThis, uint _arg);

		/// <summary>
		/// Set the @p name uniform array to @p f with @p count elements 
		/// </summary>
		// Token: 0x060107DA RID: 67546 RVA: 0x001701DB File Offset: 0x0016E3DB
		public virtual void SetNumberOfOutputs(uint _arg)
		{
			vtkShaderProgram.vtkShaderProgram_SetNumberOfOutputs_31(base.GetCppThis(), _arg);
		}

		// Token: 0x060107DB RID: 67547
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkShaderProgram_SetUniform1fv_32(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int count, IntPtr f);

		/// <summary>
		/// Set the @p name uniform array to @p f with @p count elements 
		/// </summary>
		// Token: 0x060107DC RID: 67548 RVA: 0x001701EC File Offset: 0x0016E3EC
		public bool SetUniform1fv(string name, int count, IntPtr f)
		{
			return vtkShaderProgram.vtkShaderProgram_SetUniform1fv_32(base.GetCppThis(), name, count, f) != 0;
		}

		// Token: 0x060107DD RID: 67549
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkShaderProgram_SetUniform1iv_33(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int count, IntPtr f);

		/// <summary>
		/// Set the @p name uniform array to @p f with @p count elements 
		/// </summary>
		// Token: 0x060107DE RID: 67550 RVA: 0x00170218 File Offset: 0x0016E418
		public bool SetUniform1iv(string name, int count, IntPtr f)
		{
			return vtkShaderProgram.vtkShaderProgram_SetUniform1iv_33(base.GetCppThis(), name, count, f) != 0;
		}

		// Token: 0x060107DF RID: 67551
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkShaderProgram_SetUniform2f_34(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, IntPtr v);

		/// <summary>
		/// Set the @p name uniform value to int @p v. 
		/// </summary>
		// Token: 0x060107E0 RID: 67552 RVA: 0x00170244 File Offset: 0x0016E444
		public bool SetUniform2f(string name, IntPtr v)
		{
			return vtkShaderProgram.vtkShaderProgram_SetUniform2f_34(base.GetCppThis(), name, v) != 0;
		}

		// Token: 0x060107E1 RID: 67553
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkShaderProgram_SetUniform2fv_35(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int count, IntPtr f);

		/// <summary>
		/// Set the @p name uniform array to @p f with @p count elements 
		/// </summary>
		// Token: 0x060107E2 RID: 67554 RVA: 0x0017026C File Offset: 0x0016E46C
		public bool SetUniform2fv(string name, int count, IntPtr f)
		{
			return vtkShaderProgram.vtkShaderProgram_SetUniform2fv_35(base.GetCppThis(), name, count, f) != 0;
		}

		// Token: 0x060107E3 RID: 67555
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkShaderProgram_SetUniform2i_36(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, IntPtr v);

		/// <summary>
		/// Set the @p name uniform value to int @p v. 
		/// </summary>
		// Token: 0x060107E4 RID: 67556 RVA: 0x00170298 File Offset: 0x0016E498
		public bool SetUniform2i(string name, IntPtr v)
		{
			return vtkShaderProgram.vtkShaderProgram_SetUniform2i_36(base.GetCppThis(), name, v) != 0;
		}

		// Token: 0x060107E5 RID: 67557
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkShaderProgram_SetUniform3f_37(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, IntPtr v);

		/// <summary>
		/// Set the @p name uniform value to int @p v. 
		/// </summary>
		// Token: 0x060107E6 RID: 67558 RVA: 0x001702C0 File Offset: 0x0016E4C0
		public bool SetUniform3f(string name, IntPtr v)
		{
			return vtkShaderProgram.vtkShaderProgram_SetUniform3f_37(base.GetCppThis(), name, v) != 0;
		}

		// Token: 0x060107E7 RID: 67559
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkShaderProgram_SetUniform3fv_38(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int count, IntPtr f);

		/// <summary>
		/// Set the @p name uniform array to @p f with @p count elements 
		/// </summary>
		// Token: 0x060107E8 RID: 67560 RVA: 0x001702E8 File Offset: 0x0016E4E8
		public bool SetUniform3fv(string name, int count, IntPtr f)
		{
			return vtkShaderProgram.vtkShaderProgram_SetUniform3fv_38(base.GetCppThis(), name, count, f) != 0;
		}

		// Token: 0x060107E9 RID: 67561
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkShaderProgram_SetUniform3uc_39(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, IntPtr v);

		/// <summary>
		/// Set the @p name uniform value to int @p v. 
		/// </summary>
		// Token: 0x060107EA RID: 67562 RVA: 0x00170314 File Offset: 0x0016E514
		public bool SetUniform3uc(string name, IntPtr v)
		{
			return vtkShaderProgram.vtkShaderProgram_SetUniform3uc_39(base.GetCppThis(), name, v) != 0;
		}

		// Token: 0x060107EB RID: 67563
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkShaderProgram_SetUniform4f_40(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, IntPtr v);

		/// <summary>
		/// Set the @p name uniform value to int @p v. 
		/// </summary>
		// Token: 0x060107EC RID: 67564 RVA: 0x0017033C File Offset: 0x0016E53C
		public bool SetUniform4f(string name, IntPtr v)
		{
			return vtkShaderProgram.vtkShaderProgram_SetUniform4f_40(base.GetCppThis(), name, v) != 0;
		}

		// Token: 0x060107ED RID: 67565
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkShaderProgram_SetUniform4fv_41(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int count, IntPtr f);

		/// <summary>
		/// Set the @p name uniform array to @p f with @p count elements 
		/// </summary>
		// Token: 0x060107EE RID: 67566 RVA: 0x00170364 File Offset: 0x0016E564
		public bool SetUniform4fv(string name, int count, IntPtr f)
		{
			return vtkShaderProgram.vtkShaderProgram_SetUniform4fv_41(base.GetCppThis(), name, count, f) != 0;
		}

		// Token: 0x060107EF RID: 67567
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkShaderProgram_SetUniform4uc_42(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, IntPtr v);

		/// <summary>
		/// Set the @p name uniform value to int @p v. 
		/// </summary>
		// Token: 0x060107F0 RID: 67568 RVA: 0x00170390 File Offset: 0x0016E590
		public bool SetUniform4uc(string name, IntPtr v)
		{
			return vtkShaderProgram.vtkShaderProgram_SetUniform4uc_42(base.GetCppThis(), name, v) != 0;
		}

		// Token: 0x060107F1 RID: 67569
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkShaderProgram_SetUniformGroupUpdateTime_43(HandleRef pThis, int arg0, ulong tm);

		/// <summary>
		/// Set/Get times that can be used to track when a set of
		/// uniforms was last updated. This can be used to reduce
		/// redundant SetUniformCalls
		/// </summary>
		// Token: 0x060107F2 RID: 67570 RVA: 0x001703B8 File Offset: 0x0016E5B8
		public void SetUniformGroupUpdateTime(int arg0, ulong tm)
		{
			vtkShaderProgram.vtkShaderProgram_SetUniformGroupUpdateTime_43(base.GetCppThis(), arg0, tm);
		}

		// Token: 0x060107F3 RID: 67571
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkShaderProgram_SetUniformMatrix_44(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, HandleRef v);

		/// <summary>
		/// Set the @p name uniform value to int @p v. 
		/// </summary>
		// Token: 0x060107F4 RID: 67572 RVA: 0x001703CC File Offset: 0x0016E5CC
		public bool SetUniformMatrix(string name, vtkMatrix3x3 v)
		{
			return vtkShaderProgram.vtkShaderProgram_SetUniformMatrix_44(base.GetCppThis(), name, (v == null) ? default(HandleRef) : v.GetCppThis()) != 0;
		}

		// Token: 0x060107F5 RID: 67573
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkShaderProgram_SetUniformMatrix_45(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, HandleRef v);

		/// <summary>
		/// Set the @p name uniform value to int @p v. 
		/// </summary>
		// Token: 0x060107F6 RID: 67574 RVA: 0x00170408 File Offset: 0x0016E608
		public bool SetUniformMatrix(string name, vtkMatrix4x4 v)
		{
			return vtkShaderProgram.vtkShaderProgram_SetUniformMatrix_45(base.GetCppThis(), name, (v == null) ? default(HandleRef) : v.GetCppThis()) != 0;
		}

		// Token: 0x060107F7 RID: 67575
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkShaderProgram_SetUniformMatrix3x3_46(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, IntPtr v);

		/// <summary>
		/// Set the @p name uniform value to int @p v. 
		/// </summary>
		// Token: 0x060107F8 RID: 67576 RVA: 0x00170444 File Offset: 0x0016E644
		public bool SetUniformMatrix3x3(string name, IntPtr v)
		{
			return vtkShaderProgram.vtkShaderProgram_SetUniformMatrix3x3_46(base.GetCppThis(), name, v) != 0;
		}

		// Token: 0x060107F9 RID: 67577
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkShaderProgram_SetUniformMatrix4x4_47(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, IntPtr v);

		/// <summary>
		/// Set the @p name uniform value to int @p v. 
		/// </summary>
		// Token: 0x060107FA RID: 67578 RVA: 0x0017046C File Offset: 0x0016E66C
		public bool SetUniformMatrix4x4(string name, IntPtr v)
		{
			return vtkShaderProgram.vtkShaderProgram_SetUniformMatrix4x4_47(base.GetCppThis(), name, v) != 0;
		}

		// Token: 0x060107FB RID: 67579
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkShaderProgram_SetUniformMatrix4x4v_48(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int count, IntPtr v);

		/// <summary>
		/// Set the @p name uniform array to @p f with @p count elements 
		/// </summary>
		// Token: 0x060107FC RID: 67580 RVA: 0x00170494 File Offset: 0x0016E694
		public bool SetUniformMatrix4x4v(string name, int count, IntPtr v)
		{
			return vtkShaderProgram.vtkShaderProgram_SetUniformMatrix4x4v_48(base.GetCppThis(), name, count, v) != 0;
		}

		// Token: 0x060107FD RID: 67581
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkShaderProgram_SetUniformf_49(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, float v);

		/// <summary>
		/// Set the @p name uniform value to int @p v. 
		/// </summary>
		// Token: 0x060107FE RID: 67582 RVA: 0x001704C0 File Offset: 0x0016E6C0
		public bool SetUniformf(string name, float v)
		{
			return vtkShaderProgram.vtkShaderProgram_SetUniformf_49(base.GetCppThis(), name, v) != 0;
		}

		// Token: 0x060107FF RID: 67583
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkShaderProgram_SetUniformi_50(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int v);

		/// <summary>
		/// Set the @p name uniform value to int @p v. 
		/// </summary>
		// Token: 0x06010800 RID: 67584 RVA: 0x001704E8 File Offset: 0x0016E6E8
		public bool SetUniformi(string name, int v)
		{
			return vtkShaderProgram.vtkShaderProgram_SetUniformi_50(base.GetCppThis(), name, v) != 0;
		}

		// Token: 0x06010801 RID: 67585
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkShaderProgram_SetVertexShader_51(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get the vertex shader for this program
		/// </summary>
		// Token: 0x06010802 RID: 67586 RVA: 0x00170510 File Offset: 0x0016E710
		public void SetVertexShader(vtkShader arg0)
		{
			vtkShaderProgram.vtkShaderProgram_SetVertexShader_51(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06010803 RID: 67587
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkShaderProgram_Substitute_52([MarshalAs(UnmanagedType.LPUTF8Str)] string source, [MarshalAs(UnmanagedType.LPUTF8Str)] string search, [MarshalAs(UnmanagedType.LPUTF8Str)] string replace, byte all);

		/// <summary>
		/// perform in place string substitutions, indicate if a substitution was done
		/// this is useful for building up shader strings which typically involve
		/// lots of string substitutions.
		///
		/// \param[in] source  The source code to perform substitutions on
		/// \param[in] search  The string to search for
		/// \param[in] replace The string replacement
		/// \param[in] all     Whether to replace all matches or just the first one
		/// \return    A boolean indicating whether the replacement was successful
		/// </summary>
		// Token: 0x06010804 RID: 67588 RVA: 0x00170540 File Offset: 0x0016E740
		public static bool Substitute(string source, string search, string replace, bool all)
		{
			return vtkShaderProgram.vtkShaderProgram_Substitute_52(source, search, replace, all ? (byte)1 : (byte)0) != 0;
		}

		// Token: 0x06010805 RID: 67589
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkShaderProgram_Substitute_53(HandleRef shader, [MarshalAs(UnmanagedType.LPUTF8Str)] string search, [MarshalAs(UnmanagedType.LPUTF8Str)] string replace, byte all);

		/// <summary>
		/// Perform in-place string substitutions on the shader source string and
		/// indicate if one or all substitutions were done. This is useful for building
		/// up shader strings which typically involve a lot of string substitutions.
		///
		/// \param[in] shader  The source shader object to perform substitutions on
		/// \param[in] search  The string to search for
		/// \param[in] replace The string replacement
		/// \param[in] all     Whether to replace all matches or just the first one
		/// \return    A boolean indicating whether the replacement was successful
		/// </summary>
		// Token: 0x06010806 RID: 67590 RVA: 0x0017056C File Offset: 0x0016E76C
		public static bool Substitute(vtkShader shader, string search, string replace, bool all)
		{
			return vtkShaderProgram.vtkShaderProgram_Substitute_53((shader == null) ? default(HandleRef) : shader.GetCppThis(), search, replace, all ? (byte)1 : (byte)0) != 0;
		}

		// Token: 0x06010807 RID: 67591
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkShaderProgram_UseAttributeArray_54(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int offset, ulong stride, int elementType, int elementTupleSize, vtkShaderProgram.NormalizeOption normalize);

		/// <summary>
		/// Use the named attribute array with the bound BufferObject.
		/// @param name of the attribute (as seen in the shader program).
		/// @param offset into the bound BufferObject.
		/// @param stride The stride of the element access (i.e. the size of each
		/// element in the currently bound BufferObject). 0 may be used to indicate
		/// tightly packed data.
		/// @param elementType Tag identifying the memory representation of the
		/// element.
		/// @param elementTupleSize The number of elements per vertex (e.g. a 3D
		/// position attribute would be 3).
		/// @param normalize Indicates the range used by the attribute data.
		/// See NormalizeOption for more information.
		/// @return false if the attribute array does not exist.
		/// </summary>
		// Token: 0x06010808 RID: 67592 RVA: 0x001705AC File Offset: 0x0016E7AC
		public bool UseAttributeArray(string name, int offset, ulong stride, int elementType, int elementTupleSize, vtkShaderProgram.NormalizeOption normalize)
		{
			return vtkShaderProgram.vtkShaderProgram_UseAttributeArray_54(base.GetCppThis(), name, offset, stride, elementType, elementTupleSize, normalize) != 0;
		}

		// Token: 0x06010809 RID: 67593
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkShaderProgram_isBound_55(HandleRef pThis);

		/// <summary>
		/// Check if the program is currently bound, or not.
		/// @return True if the program is bound, false otherwise.
		/// </summary>
		// Token: 0x0601080A RID: 67594 RVA: 0x001705DC File Offset: 0x0016E7DC
		public bool isBound()
		{
			return vtkShaderProgram.vtkShaderProgram_isBound_55(base.GetCppThis()) != 0;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001323 RID: 4899
		public new const string MRFullTypeName = "Kitware.VTK.vtkShaderProgram";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001324 RID: 4900
		public new static readonly string MRClassNameKey = "class vtkShaderProgram";

		/// <summary>
		/// Options for attribute normalization. 
		/// </summary>
		// Token: 0x020005EB RID: 1515
		public enum NormalizeOption
		{
			/// <summary>enum member</summary>
			// Token: 0x04001326 RID: 4902
			NoNormalize = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001327 RID: 4903
			Normalize = 0
		}

		/// <summary>
		/// Set/Get times that can be used to track when a set of
		/// uniforms was last updated. This can be used to reduce
		/// redundant SetUniformCalls
		/// </summary>
		// Token: 0x020005EC RID: 1516
		public enum UniformGroups
		{
			/// <summary>enum member</summary>
			// Token: 0x04001329 RID: 4905
			CameraGroup,
			/// <summary>enum member</summary>
			// Token: 0x0400132A RID: 4906
			LightingGroup,
			/// <summary>enum member</summary>
			// Token: 0x0400132B RID: 4907
			UserGroup
		}
	}
}
