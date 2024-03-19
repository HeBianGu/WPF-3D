using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkShader
	/// </summary>
	/// <remarks>
	///    encapsulate a glsl shader
	///
	/// vtkShader represents a shader, vertex, fragment, geometry etc
	/// </remarks>
	// Token: 0x020005E8 RID: 1512
	public class vtkShader : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06010777 RID: 67447 RVA: 0x0016F8A7 File Offset: 0x0016DAA7
		static vtkShader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkShader.MRClassNameKey, System.Type.GetType("Kitware.VTK.vtkShader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06010778 RID: 67448 RVA: 0x0016F8CF File Offset: 0x0016DACF
		public vtkShader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06010779 RID: 67449
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkShader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601077A RID: 67450 RVA: 0x0016F8E0 File Offset: 0x0016DAE0
		public new static vtkShader New()
		{
			vtkShader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkShader.vtkShader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkShader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601077B RID: 67451 RVA: 0x0016F934 File Offset: 0x0016DB34
		public vtkShader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkShader.vtkShader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601077C RID: 67452 RVA: 0x0016F978 File Offset: 0x0016DB78
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601077D RID: 67453
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkShader_Cleanup_01(HandleRef pThis);

		/// <summary>
		/// @note This should only be done once the ShaderProgram is done with the
		/// Shader.
		/// </summary>
		// Token: 0x0601077E RID: 67454 RVA: 0x0016F983 File Offset: 0x0016DB83
		public void Cleanup()
		{
			vtkShader.vtkShader_Cleanup_01(base.GetCppThis());
		}

		// Token: 0x0601077F RID: 67455
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkShader_Compile_02(HandleRef pThis);

		/// <summary>
		/// @note A valid context must to current in order to compile the shader.
		/// </summary>
		// Token: 0x06010780 RID: 67456 RVA: 0x0016F994 File Offset: 0x0016DB94
		public bool Compile()
		{
			return vtkShader.vtkShader_Compile_02(base.GetCppThis()) != 0;
		}

		// Token: 0x06010781 RID: 67457
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkShader_GetError_03(HandleRef pThis);

		/// <summary>
		/// Get the error message (empty if none) for the shader. 
		/// </summary>
		// Token: 0x06010782 RID: 67458 RVA: 0x0016F9BC File Offset: 0x0016DBBC
		public string GetError()
		{
			return vtkShader.vtkShader_GetError_03(base.GetCppThis());
		}

		// Token: 0x06010783 RID: 67459
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkShader_GetHandle_04(HandleRef pThis);

		/// <summary>
		/// Get the handle of the shader. 
		/// </summary>
		// Token: 0x06010784 RID: 67460 RVA: 0x0016F9DC File Offset: 0x0016DBDC
		public int GetHandle()
		{
			return vtkShader.vtkShader_GetHandle_04(base.GetCppThis());
		}

		// Token: 0x06010785 RID: 67461
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkShader_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010786 RID: 67462 RVA: 0x0016F9FC File Offset: 0x0016DBFC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkShader.vtkShader_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06010787 RID: 67463
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkShader_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010788 RID: 67464 RVA: 0x0016FA1C File Offset: 0x0016DC1C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkShader.vtkShader_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06010789 RID: 67465
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkShader_GetSource_07(HandleRef pThis);

		/// <summary>
		/// Get the source for the shader. 
		/// </summary>
		// Token: 0x0601078A RID: 67466 RVA: 0x0016FA38 File Offset: 0x0016DC38
		public string GetSource()
		{
			return vtkShader.vtkShader_GetSource_07(base.GetCppThis());
		}

		// Token: 0x0601078B RID: 67467
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkShader.Type vtkShader_GetType_08(HandleRef pThis);

		/// <summary>
		/// Get the shader type, typically Vertex or Fragment. 
		/// </summary>
		// Token: 0x0601078C RID: 67468 RVA: 0x0016FA58 File Offset: 0x0016DC58
		public vtkShader.Type GetTypeWrapper()
		{
			return vtkShader.vtkShader_GetType_08(base.GetCppThis());
		}

		// Token: 0x0601078D RID: 67469
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkShader_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601078E RID: 67470 RVA: 0x0016FA78 File Offset: 0x0016DC78
		public override int IsA(string type)
		{
			return vtkShader.vtkShader_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x0601078F RID: 67471
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkShader_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010790 RID: 67472 RVA: 0x0016FA98 File Offset: 0x0016DC98
		public new static int IsTypeOf(string type)
		{
			return vtkShader.vtkShader_IsTypeOf_10(type);
		}

		// Token: 0x06010791 RID: 67473
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkShader_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010792 RID: 67474 RVA: 0x0016FAB4 File Offset: 0x0016DCB4
		public new vtkShader NewInstance()
		{
			vtkShader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkShader.vtkShader_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkShader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010793 RID: 67475
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkShader_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010794 RID: 67476 RVA: 0x0016FB10 File Offset: 0x0016DD10
		public new static vtkShader SafeDownCast(vtkObjectBase o)
		{
			vtkShader vtkShader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkShader.vtkShader_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06010795 RID: 67477
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkShader_SetSource_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string source);

		/// <summary>
		/// Set the shader source to the supplied string. 
		/// </summary>
		// Token: 0x06010796 RID: 67478 RVA: 0x0016FB8F File Offset: 0x0016DD8F
		public void SetSource(string source)
		{
			vtkShader.vtkShader_SetSource_14(base.GetCppThis(), source);
		}

		// Token: 0x06010797 RID: 67479
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkShader_SetType_15(HandleRef pThis, vtkShader.Type type);

		/// <summary>
		/// Set the shader type. 
		/// </summary>
		// Token: 0x06010798 RID: 67480 RVA: 0x0016FB9F File Offset: 0x0016DD9F
		public void SetType(vtkShader.Type type)
		{
			vtkShader.vtkShader_SetType_15(base.GetCppThis(), type);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400131C RID: 4892
		public new const string MRFullTypeName = "Kitware.VTK.vtkShader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400131D RID: 4893
		public new static readonly string MRClassNameKey = "class vtkShader";

		/// <summary>
		/// Available shader types. 
		/// </summary>
		// Token: 0x020005E9 RID: 1513
		public enum Type
		{
			/// <summary>enum member</summary>
			// Token: 0x0400131F RID: 4895
			Fragment = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001320 RID: 4896
			Geometry,
			/// <summary>enum member</summary>
			// Token: 0x04001321 RID: 4897
			Unknown,
			/// <summary>enum member</summary>
			// Token: 0x04001322 RID: 4898
			Vertex = 0
		}
	}
}
