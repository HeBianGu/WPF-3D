using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenGLUniforms
	/// </summary>
	/// <remarks>
	///    helper class to set custom uniform variables in GLSL shaders.
	///
	/// This class implements all SetUniform* functions supported by vtkShaderProgram but instead of
	/// directly calling the underlying OpenGL functions, it caches the name and value of the variable
	/// and provides a mechanism for client mappers to set all cached variables at once in a generic way.
	///
	/// The basic types of GLSL uniform variables supported by the class are the following: int, float,
	/// vec2i, vec3, vec4, mat3, mat4, int[], float[], vec2i[], vec3[], vec4[], mat4[]. All other
	/// types supported by Set* functions undergo the same type conversions implemented in
	/// vtkShaderProgram.
	///
	/// @par Thanks:
	/// Developed by Simon Drouin (sdrouin2@bwh.harvard.edu) at Brigham and Women's Hospital.
	/// </remarks>
	// Token: 0x020005D8 RID: 1496
	public class vtkOpenGLUniforms : vtkUniforms
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06010535 RID: 66869 RVA: 0x0016BF26 File Offset: 0x0016A126
		static vtkOpenGLUniforms()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLUniforms.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLUniforms"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06010536 RID: 66870 RVA: 0x0016BF4E File Offset: 0x0016A14E
		public vtkOpenGLUniforms(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06010537 RID: 66871
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLUniforms_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010538 RID: 66872 RVA: 0x0016BF5C File Offset: 0x0016A15C
		public new static vtkOpenGLUniforms New()
		{
			vtkOpenGLUniforms result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLUniforms.vtkOpenGLUniforms_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLUniforms)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010539 RID: 66873 RVA: 0x0016BFB0 File Offset: 0x0016A1B0
		public vtkOpenGLUniforms() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenGLUniforms.vtkOpenGLUniforms_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601053A RID: 66874 RVA: 0x0016BFF4 File Offset: 0x0016A1F4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601053B RID: 66875
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkOpenGLUniforms_GetDeclarations_01(HandleRef pThis);

		/// <summary>
		///             all stored uniform variables. This is typically called
		/// </summary>
		// Token: 0x0601053C RID: 66876 RVA: 0x0016C000 File Offset: 0x0016A200
		public string GetDeclarations()
		{
			return vtkOpenGLUniforms.vtkOpenGLUniforms_GetDeclarations_01(base.GetCppThis());
		}

		// Token: 0x0601053D RID: 66877
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLUniforms_GetNthUniformName_02(HandleRef pThis, long uniformIndex);

		/// <summary>
		/// Get number of all uniforms stored in this clas
		/// </summary>
		// Token: 0x0601053E RID: 66878 RVA: 0x0016C020 File Offset: 0x0016A220
		public override string GetNthUniformName(long uniformIndex)
		{
			string s = Marshal.PtrToStringAnsi(vtkOpenGLUniforms.vtkOpenGLUniforms_GetNthUniformName_02(base.GetCppThis(), uniformIndex));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601053F RID: 66879
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLUniforms_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010540 RID: 66880 RVA: 0x0016C05C File Offset: 0x0016A25C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenGLUniforms.vtkOpenGLUniforms_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06010541 RID: 66881
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLUniforms_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010542 RID: 66882 RVA: 0x0016C07C File Offset: 0x0016A27C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenGLUniforms.vtkOpenGLUniforms_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06010543 RID: 66883
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLUniforms_GetNumberOfUniforms_05(HandleRef pThis);

		/// <summary>
		/// Get number of all uniforms stored in this class 
		/// </summary>
		// Token: 0x06010544 RID: 66884 RVA: 0x0016C098 File Offset: 0x0016A298
		public override int GetNumberOfUniforms()
		{
			return vtkOpenGLUniforms.vtkOpenGLUniforms_GetNumberOfUniforms_05(base.GetCppThis());
		}

		// Token: 0x06010545 RID: 66885
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenGLUniforms_GetUniform2f_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, IntPtr v);

		/// <summary>
		/// Get the @p name uniform value. Returns true on success. 
		/// </summary>
		// Token: 0x06010546 RID: 66886 RVA: 0x0016C0B8 File Offset: 0x0016A2B8
		public override bool GetUniform2f(string name, IntPtr v)
		{
			return vtkOpenGLUniforms.vtkOpenGLUniforms_GetUniform2f_06(base.GetCppThis(), name, v) != 0;
		}

		// Token: 0x06010547 RID: 66887
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenGLUniforms_GetUniform2i_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, IntPtr v);

		/// <summary>
		/// Get the @p name uniform value. Returns true on success. 
		/// </summary>
		// Token: 0x06010548 RID: 66888 RVA: 0x0016C0E0 File Offset: 0x0016A2E0
		public override bool GetUniform2i(string name, IntPtr v)
		{
			return vtkOpenGLUniforms.vtkOpenGLUniforms_GetUniform2i_07(base.GetCppThis(), name, v) != 0;
		}

		// Token: 0x06010549 RID: 66889
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenGLUniforms_GetUniform3f_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, IntPtr v);

		/// <summary>
		/// Get the @p name uniform value. Returns true on success. 
		/// </summary>
		// Token: 0x0601054A RID: 66890 RVA: 0x0016C108 File Offset: 0x0016A308
		public override bool GetUniform3f(string name, IntPtr v)
		{
			return vtkOpenGLUniforms.vtkOpenGLUniforms_GetUniform3f_08(base.GetCppThis(), name, v) != 0;
		}

		// Token: 0x0601054B RID: 66891
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenGLUniforms_GetUniform3uc_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, IntPtr v);

		/// <summary>
		///  The following are convenience functions and do not reflect
		///  the way the data is stored and sent to OpenGL. Data is
		/// </summary>
		// Token: 0x0601054C RID: 66892 RVA: 0x0016C130 File Offset: 0x0016A330
		public override bool GetUniform3uc(string name, IntPtr v)
		{
			return vtkOpenGLUniforms.vtkOpenGLUniforms_GetUniform3uc_09(base.GetCppThis(), name, v) != 0;
		}

		// Token: 0x0601054D RID: 66893
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenGLUniforms_GetUniform4f_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, IntPtr v);

		/// <summary>
		/// Get the @p name uniform value. Returns true on success. 
		/// </summary>
		// Token: 0x0601054E RID: 66894 RVA: 0x0016C158 File Offset: 0x0016A358
		public override bool GetUniform4f(string name, IntPtr v)
		{
			return vtkOpenGLUniforms.vtkOpenGLUniforms_GetUniform4f_10(base.GetCppThis(), name, v) != 0;
		}

		// Token: 0x0601054F RID: 66895
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenGLUniforms_GetUniform4uc_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, IntPtr v);

		/// <summary>
		///  The following are convenience functions and do not reflect
		///  the way the data is stored and sent to OpenGL. Data is
		/// </summary>
		// Token: 0x06010550 RID: 66896 RVA: 0x0016C180 File Offset: 0x0016A380
		public override bool GetUniform4uc(string name, IntPtr v)
		{
			return vtkOpenGLUniforms.vtkOpenGLUniforms_GetUniform4uc_11(base.GetCppThis(), name, v) != 0;
		}

		// Token: 0x06010551 RID: 66897
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkOpenGLUniforms_GetUniformListMTime_12(HandleRef pThis);

		/// <summary>
		///  which is typically used to check whether the shader
		///  needs to be recompiled. The time stamp is not affected
		///  by the modification of the value of an existing variable
		/// </summary>
		// Token: 0x06010552 RID: 66898 RVA: 0x0016C1A8 File Offset: 0x0016A3A8
		public override ulong GetUniformListMTime()
		{
			return vtkOpenGLUniforms.vtkOpenGLUniforms_GetUniformListMTime_12(base.GetCppThis());
		}

		// Token: 0x06010553 RID: 66899
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenGLUniforms_GetUniformMatrix_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, HandleRef v);

		/// <summary>
		///  The following are convenience functions and do not reflect
		///  the way the data is stored and sent to OpenGL. Data is
		/// </summary>
		// Token: 0x06010554 RID: 66900 RVA: 0x0016C1C8 File Offset: 0x0016A3C8
		public override bool GetUniformMatrix(string name, vtkMatrix3x3 v)
		{
			return vtkOpenGLUniforms.vtkOpenGLUniforms_GetUniformMatrix_13(base.GetCppThis(), name, (v == null) ? default(HandleRef) : v.GetCppThis()) != 0;
		}

		// Token: 0x06010555 RID: 66901
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenGLUniforms_GetUniformMatrix_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, HandleRef v);

		/// <summary>
		///  The following are convenience functions and do not reflect
		///  the way the data is stored and sent to OpenGL. Data is
		/// </summary>
		// Token: 0x06010556 RID: 66902 RVA: 0x0016C204 File Offset: 0x0016A404
		public override bool GetUniformMatrix(string name, vtkMatrix4x4 v)
		{
			return vtkOpenGLUniforms.vtkOpenGLUniforms_GetUniformMatrix_14(base.GetCppThis(), name, (v == null) ? default(HandleRef) : v.GetCppThis()) != 0;
		}

		// Token: 0x06010557 RID: 66903
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenGLUniforms_GetUniformMatrix3x3_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, IntPtr v);

		/// <summary>
		/// Get the @p name uniform value. Returns true on success. 
		/// </summary>
		// Token: 0x06010558 RID: 66904 RVA: 0x0016C240 File Offset: 0x0016A440
		public override bool GetUniformMatrix3x3(string name, IntPtr v)
		{
			return vtkOpenGLUniforms.vtkOpenGLUniforms_GetUniformMatrix3x3_15(base.GetCppThis(), name, v) != 0;
		}

		// Token: 0x06010559 RID: 66905
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenGLUniforms_GetUniformMatrix4x4_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, IntPtr v);

		/// <summary>
		/// Get the @p name uniform value. Returns true on success. 
		/// </summary>
		// Token: 0x0601055A RID: 66906 RVA: 0x0016C268 File Offset: 0x0016A468
		public override bool GetUniformMatrix4x4(string name, IntPtr v)
		{
			return vtkOpenGLUniforms.vtkOpenGLUniforms_GetUniformMatrix4x4_16(base.GetCppThis(), name, v) != 0;
		}

		// Token: 0x0601055B RID: 66907
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLUniforms_GetUniformNumberOfComponents_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// for example, a uniform with tuples of matrix type and 9 components
		/// </summary>
		// Token: 0x0601055C RID: 66908 RVA: 0x0016C290 File Offset: 0x0016A490
		public override int GetUniformNumberOfComponents(string name)
		{
			return vtkOpenGLUniforms.vtkOpenGLUniforms_GetUniformNumberOfComponents_17(base.GetCppThis(), name);
		}

		// Token: 0x0601055D RID: 66909
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLUniforms_GetUniformNumberOfTuples_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Get length of a uniform @p name that contains a variable-size vecto
		/// </summary>
		// Token: 0x0601055E RID: 66910 RVA: 0x0016C2B0 File Offset: 0x0016A4B0
		public override int GetUniformNumberOfTuples(string name)
		{
			return vtkOpenGLUniforms.vtkOpenGLUniforms_GetUniformNumberOfTuples_18(base.GetCppThis(), name);
		}

		// Token: 0x0601055F RID: 66911
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLUniforms_GetUniformScalarType_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Get type of scalars stored in uniform @p name 
		/// </summary>
		// Token: 0x06010560 RID: 66912 RVA: 0x0016C2D0 File Offset: 0x0016A4D0
		public override int GetUniformScalarType(string name)
		{
			return vtkOpenGLUniforms.vtkOpenGLUniforms_GetUniformScalarType_19(base.GetCppThis(), name);
		}

		// Token: 0x06010561 RID: 66913
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkUniforms.TupleType vtkOpenGLUniforms_GetUniformTupleType_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Get the tuple type stored in uniform @p name. This can be a scala
		/// </summary>
		// Token: 0x06010562 RID: 66914 RVA: 0x0016C2F0 File Offset: 0x0016A4F0
		public override vtkUniforms.TupleType GetUniformTupleType(string name)
		{
			return vtkOpenGLUniforms.vtkOpenGLUniforms_GetUniformTupleType_20(base.GetCppThis(), name);
		}

		// Token: 0x06010563 RID: 66915
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenGLUniforms_GetUniformf_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, ref float v);

		/// <summary>
		/// Get the @p name uniform value. Returns true on success. 
		/// </summary>
		// Token: 0x06010564 RID: 66916 RVA: 0x0016C310 File Offset: 0x0016A510
		public override bool GetUniformf(string name, ref float v)
		{
			return vtkOpenGLUniforms.vtkOpenGLUniforms_GetUniformf_21(base.GetCppThis(), name, ref v) != 0;
		}

		// Token: 0x06010565 RID: 66917
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenGLUniforms_GetUniformi_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, ref int v);

		/// <summary>
		/// Get the @p name uniform value. Returns true on success. 
		/// </summary>
		// Token: 0x06010566 RID: 66918 RVA: 0x0016C338 File Offset: 0x0016A538
		public override bool GetUniformi(string name, ref int v)
		{
			return vtkOpenGLUniforms.vtkOpenGLUniforms_GetUniformi_22(base.GetCppThis(), name, ref v) != 0;
		}

		// Token: 0x06010567 RID: 66919
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLUniforms_IsA_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010568 RID: 66920 RVA: 0x0016C360 File Offset: 0x0016A560
		public override int IsA(string type)
		{
			return vtkOpenGLUniforms.vtkOpenGLUniforms_IsA_23(base.GetCppThis(), type);
		}

		// Token: 0x06010569 RID: 66921
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLUniforms_IsTypeOf_24([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601056A RID: 66922 RVA: 0x0016C380 File Offset: 0x0016A580
		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLUniforms.vtkOpenGLUniforms_IsTypeOf_24(type);
		}

		// Token: 0x0601056B RID: 66923
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLUniforms_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601056C RID: 66924 RVA: 0x0016C39C File Offset: 0x0016A59C
		public new vtkOpenGLUniforms NewInstance()
		{
			vtkOpenGLUniforms result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLUniforms.vtkOpenGLUniforms_NewInstance_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLUniforms)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601056D RID: 66925
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLUniforms_RemoveAllUniforms_27(HandleRef pThis);

		/// <summary>
		/// Remove all uniform variables 
		/// </summary>
		// Token: 0x0601056E RID: 66926 RVA: 0x0016C3F6 File Offset: 0x0016A5F6
		public override void RemoveAllUniforms()
		{
			vtkOpenGLUniforms.vtkOpenGLUniforms_RemoveAllUniforms_27(base.GetCppThis());
		}

		// Token: 0x0601056F RID: 66927
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLUniforms_RemoveUniform_28(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Remove uniform variable named @p name 
		/// </summary>
		// Token: 0x06010570 RID: 66928 RVA: 0x0016C405 File Offset: 0x0016A605
		public override void RemoveUniform(string name)
		{
			vtkOpenGLUniforms.vtkOpenGLUniforms_RemoveUniform_28(base.GetCppThis(), name);
		}

		// Token: 0x06010571 RID: 66929
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLUniforms_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010572 RID: 66930 RVA: 0x0016C418 File Offset: 0x0016A618
		public new static vtkOpenGLUniforms SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLUniforms vtkOpenGLUniforms = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLUniforms.vtkOpenGLUniforms_SafeDownCast_29((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLUniforms = (vtkOpenGLUniforms)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLUniforms.Register(null);
				}
			}
			return vtkOpenGLUniforms;
		}

		// Token: 0x06010573 RID: 66931
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLUniforms_SetUniform1fv_30(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int count, IntPtr f);

		/// <summary>
		/// Set the @p name uniform array to @p f with @p count elements 
		/// </summary>
		// Token: 0x06010574 RID: 66932 RVA: 0x0016C497 File Offset: 0x0016A697
		public override void SetUniform1fv(string name, int count, IntPtr f)
		{
			vtkOpenGLUniforms.vtkOpenGLUniforms_SetUniform1fv_30(base.GetCppThis(), name, count, f);
		}

		// Token: 0x06010575 RID: 66933
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLUniforms_SetUniform1iv_31(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int count, IntPtr f);

		/// <summary>
		/// Set the @p name uniform array to @p f with @p count elements 
		/// </summary>
		// Token: 0x06010576 RID: 66934 RVA: 0x0016C4A9 File Offset: 0x0016A6A9
		public override void SetUniform1iv(string name, int count, IntPtr f)
		{
			vtkOpenGLUniforms.vtkOpenGLUniforms_SetUniform1iv_31(base.GetCppThis(), name, count, f);
		}

		// Token: 0x06010577 RID: 66935
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLUniforms_SetUniform2f_32(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, IntPtr v);

		/// <summary>
		/// Set the @p name uniform value to @p v. 
		/// </summary>
		// Token: 0x06010578 RID: 66936 RVA: 0x0016C4BB File Offset: 0x0016A6BB
		public override void SetUniform2f(string name, IntPtr v)
		{
			vtkOpenGLUniforms.vtkOpenGLUniforms_SetUniform2f_32(base.GetCppThis(), name, v);
		}

		// Token: 0x06010579 RID: 66937
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLUniforms_SetUniform2i_33(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, IntPtr v);

		/// <summary>
		/// Set the @p name uniform value to @p v. 
		/// </summary>
		// Token: 0x0601057A RID: 66938 RVA: 0x0016C4CC File Offset: 0x0016A6CC
		public override void SetUniform2i(string name, IntPtr v)
		{
			vtkOpenGLUniforms.vtkOpenGLUniforms_SetUniform2i_33(base.GetCppThis(), name, v);
		}

		// Token: 0x0601057B RID: 66939
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLUniforms_SetUniform3f_34(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, IntPtr v);

		/// <summary>
		/// Set the @p name uniform value to @p v. 
		/// </summary>
		// Token: 0x0601057C RID: 66940 RVA: 0x0016C4DD File Offset: 0x0016A6DD
		public override void SetUniform3f(string name, IntPtr v)
		{
			vtkOpenGLUniforms.vtkOpenGLUniforms_SetUniform3f_34(base.GetCppThis(), name, v);
		}

		// Token: 0x0601057D RID: 66941
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLUniforms_SetUniform3uc_35(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, IntPtr v);

		/// <summary>
		///  The following are convenience functions and do not reflect
		///  the way the data is stored and sent to OpenGL. Data is
		/// </summary>
		// Token: 0x0601057E RID: 66942 RVA: 0x0016C4EE File Offset: 0x0016A6EE
		public override void SetUniform3uc(string name, IntPtr v)
		{
			vtkOpenGLUniforms.vtkOpenGLUniforms_SetUniform3uc_35(base.GetCppThis(), name, v);
		}

		// Token: 0x0601057F RID: 66943
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLUniforms_SetUniform4f_36(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, IntPtr v);

		/// <summary>
		/// Set the @p name uniform value to @p v. 
		/// </summary>
		// Token: 0x06010580 RID: 66944 RVA: 0x0016C4FF File Offset: 0x0016A6FF
		public override void SetUniform4f(string name, IntPtr v)
		{
			vtkOpenGLUniforms.vtkOpenGLUniforms_SetUniform4f_36(base.GetCppThis(), name, v);
		}

		// Token: 0x06010581 RID: 66945
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLUniforms_SetUniform4uc_37(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, IntPtr v);

		/// <summary>
		///  The following are convenience functions and do not reflect
		///  the way the data is stored and sent to OpenGL. Data is
		/// </summary>
		// Token: 0x06010582 RID: 66946 RVA: 0x0016C510 File Offset: 0x0016A710
		public override void SetUniform4uc(string name, IntPtr v)
		{
			vtkOpenGLUniforms.vtkOpenGLUniforms_SetUniform4uc_37(base.GetCppThis(), name, v);
		}

		// Token: 0x06010583 RID: 66947
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLUniforms_SetUniformMatrix_38(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, HandleRef v);

		/// <summary>
		///  The following are convenience functions and do not reflect
		///  the way the data is stored and sent to OpenGL. Data is
		/// </summary>
		// Token: 0x06010584 RID: 66948 RVA: 0x0016C524 File Offset: 0x0016A724
		public override void SetUniformMatrix(string name, vtkMatrix3x3 v)
		{
			vtkOpenGLUniforms.vtkOpenGLUniforms_SetUniformMatrix_38(base.GetCppThis(), name, (v == null) ? default(HandleRef) : v.GetCppThis());
		}

		// Token: 0x06010585 RID: 66949
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLUniforms_SetUniformMatrix_39(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, HandleRef v);

		/// <summary>
		///  The following are convenience functions and do not reflect
		///  the way the data is stored and sent to OpenGL. Data is
		/// </summary>
		// Token: 0x06010586 RID: 66950 RVA: 0x0016C554 File Offset: 0x0016A754
		public override void SetUniformMatrix(string name, vtkMatrix4x4 v)
		{
			vtkOpenGLUniforms.vtkOpenGLUniforms_SetUniformMatrix_39(base.GetCppThis(), name, (v == null) ? default(HandleRef) : v.GetCppThis());
		}

		// Token: 0x06010587 RID: 66951
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLUniforms_SetUniformMatrix3x3_40(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, IntPtr v);

		/// <summary>
		/// Set the @p name uniform value to @p v. 
		/// </summary>
		// Token: 0x06010588 RID: 66952 RVA: 0x0016C584 File Offset: 0x0016A784
		public override void SetUniformMatrix3x3(string name, IntPtr v)
		{
			vtkOpenGLUniforms.vtkOpenGLUniforms_SetUniformMatrix3x3_40(base.GetCppThis(), name, v);
		}

		// Token: 0x06010589 RID: 66953
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLUniforms_SetUniformMatrix4x4_41(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, IntPtr v);

		/// <summary>
		/// Set the @p name uniform value to @p v. 
		/// </summary>
		// Token: 0x0601058A RID: 66954 RVA: 0x0016C595 File Offset: 0x0016A795
		public override void SetUniformMatrix4x4(string name, IntPtr v)
		{
			vtkOpenGLUniforms.vtkOpenGLUniforms_SetUniformMatrix4x4_41(base.GetCppThis(), name, v);
		}

		// Token: 0x0601058B RID: 66955
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLUniforms_SetUniformMatrix4x4v_42(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int count, IntPtr v);

		/// <summary>
		/// Set the @p name uniform array to @p f with @p count elements 
		/// </summary>
		// Token: 0x0601058C RID: 66956 RVA: 0x0016C5A6 File Offset: 0x0016A7A6
		public override void SetUniformMatrix4x4v(string name, int count, IntPtr v)
		{
			vtkOpenGLUniforms.vtkOpenGLUniforms_SetUniformMatrix4x4v_42(base.GetCppThis(), name, count, v);
		}

		// Token: 0x0601058D RID: 66957
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLUniforms_SetUniformf_43(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, float v);

		/// <summary>
		/// Set the @p name uniform value to @p v. 
		/// </summary>
		// Token: 0x0601058E RID: 66958 RVA: 0x0016C5B8 File Offset: 0x0016A7B8
		public override void SetUniformf(string name, float v)
		{
			vtkOpenGLUniforms.vtkOpenGLUniforms_SetUniformf_43(base.GetCppThis(), name, v);
		}

		// Token: 0x0601058F RID: 66959
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLUniforms_SetUniformi_44(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int v);

		/// <summary>
		/// Set the @p name uniform value to @p v. 
		/// </summary>
		// Token: 0x06010590 RID: 66960 RVA: 0x0016C5C9 File Offset: 0x0016A7C9
		public override void SetUniformi(string name, int v)
		{
			vtkOpenGLUniforms.vtkOpenGLUniforms_SetUniformi_44(base.GetCppThis(), name, v);
		}

		// Token: 0x06010591 RID: 66961
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenGLUniforms_SetUniforms_45(HandleRef pThis, HandleRef p);

		/// <summary>
		///  in the shader program @p p. This is called
		/// </summary>
		// Token: 0x06010592 RID: 66962 RVA: 0x0016C5DC File Offset: 0x0016A7DC
		public bool SetUniforms(vtkShaderProgram p)
		{
			return vtkOpenGLUniforms.vtkOpenGLUniforms_SetUniforms_45(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis()) != 0;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012FB RID: 4859
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLUniforms";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012FC RID: 4860
		public new static readonly string MRClassNameKey = "class vtkOpenGLUniforms";
	}
}
