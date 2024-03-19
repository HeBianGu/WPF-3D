using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkUniforms
	/// </summary>
	/// <remarks>
	///    helper class to set custom uniform variables in GPU shaders.
	///
	/// This class implements a generic mechanism to declare and set the value of custom uniform
	/// variables to be used in GPU shader programs used by mappers. It allows users who specify
	/// custom shader code for mappers to change the value of the variable they define without
	/// triggering a costly rebuild of the shader. This class is used mostly as an interface and
	/// the implementation is found in graphics api specific derived classes (e.g.: vtkOpenGLUniforms).
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkOpenGLUniforms vtkShaderProperty
	///
	/// @par Thanks:
	/// Developed by Simon Drouin (sdrouin2@bwh.harvard.edu) at Brigham and Women's Hospital.
	/// </seealso>
	// Token: 0x020005D6 RID: 1494
	public abstract class vtkUniforms : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060104D3 RID: 66771 RVA: 0x0016B823 File Offset: 0x00169A23
		static vtkUniforms()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUniforms.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUniforms"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060104D4 RID: 66772 RVA: 0x0016B84B File Offset: 0x00169A4B
		public vtkUniforms(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060104D5 RID: 66773
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUniforms_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060104D6 RID: 66774 RVA: 0x0016B85C File Offset: 0x00169A5C
		public new static vtkUniforms New()
		{
			vtkUniforms result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUniforms.vtkUniforms_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUniforms)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060104D7 RID: 66775 RVA: 0x0016B8B0 File Offset: 0x00169AB0
		public vtkUniforms() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkUniforms.vtkUniforms_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060104D8 RID: 66776 RVA: 0x0016B8F4 File Offset: 0x00169AF4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060104D9 RID: 66777
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUniforms_GetNthUniformName_01(HandleRef pThis, long uniformIndex);

		/// <summary>
		/// Get number of all uniforms stored in this clas
		/// </summary>
		// Token: 0x060104DA RID: 66778 RVA: 0x0016B900 File Offset: 0x00169B00
		public virtual string GetNthUniformName(long uniformIndex)
		{
			string s = Marshal.PtrToStringAnsi(vtkUniforms.vtkUniforms_GetNthUniformName_01(base.GetCppThis(), uniformIndex));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060104DB RID: 66779
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUniforms_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060104DC RID: 66780 RVA: 0x0016B93C File Offset: 0x00169B3C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkUniforms.vtkUniforms_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060104DD RID: 66781
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUniforms_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060104DE RID: 66782 RVA: 0x0016B95C File Offset: 0x00169B5C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkUniforms.vtkUniforms_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x060104DF RID: 66783
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUniforms_GetNumberOfUniforms_04(HandleRef pThis);

		/// <summary>
		/// Get number of all uniforms stored in this class 
		/// </summary>
		// Token: 0x060104E0 RID: 66784 RVA: 0x0016B978 File Offset: 0x00169B78
		public virtual int GetNumberOfUniforms()
		{
			return vtkUniforms.vtkUniforms_GetNumberOfUniforms_04(base.GetCppThis());
		}

		// Token: 0x060104E1 RID: 66785
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkUniforms_GetUniform2f_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, IntPtr v);

		/// <summary>
		/// Get the @p name uniform value. Returns true on success. 
		/// </summary>
		// Token: 0x060104E2 RID: 66786 RVA: 0x0016B998 File Offset: 0x00169B98
		public virtual bool GetUniform2f(string name, IntPtr v)
		{
			return vtkUniforms.vtkUniforms_GetUniform2f_05(base.GetCppThis(), name, v) != 0;
		}

		// Token: 0x060104E3 RID: 66787
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkUniforms_GetUniform2i_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, IntPtr v);

		/// <summary>
		/// Get the @p name uniform value. Returns true on success. 
		/// </summary>
		// Token: 0x060104E4 RID: 66788 RVA: 0x0016B9C0 File Offset: 0x00169BC0
		public virtual bool GetUniform2i(string name, IntPtr v)
		{
			return vtkUniforms.vtkUniforms_GetUniform2i_06(base.GetCppThis(), name, v) != 0;
		}

		// Token: 0x060104E5 RID: 66789
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkUniforms_GetUniform3f_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, IntPtr v);

		/// <summary>
		/// Get the @p name uniform value. Returns true on success. 
		/// </summary>
		// Token: 0x060104E6 RID: 66790 RVA: 0x0016B9E8 File Offset: 0x00169BE8
		public virtual bool GetUniform3f(string name, IntPtr v)
		{
			return vtkUniforms.vtkUniforms_GetUniform3f_07(base.GetCppThis(), name, v) != 0;
		}

		// Token: 0x060104E7 RID: 66791
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkUniforms_GetUniform3uc_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, IntPtr v);

		/// <summary>
		///  The following are convenience functions and do not reflect
		///  the way the data is stored and sent to OpenGL. Data is
		/// </summary>
		// Token: 0x060104E8 RID: 66792 RVA: 0x0016BA10 File Offset: 0x00169C10
		public virtual bool GetUniform3uc(string name, IntPtr v)
		{
			return vtkUniforms.vtkUniforms_GetUniform3uc_08(base.GetCppThis(), name, v) != 0;
		}

		// Token: 0x060104E9 RID: 66793
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkUniforms_GetUniform4f_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, IntPtr v);

		/// <summary>
		/// Get the @p name uniform value. Returns true on success. 
		/// </summary>
		// Token: 0x060104EA RID: 66794 RVA: 0x0016BA38 File Offset: 0x00169C38
		public virtual bool GetUniform4f(string name, IntPtr v)
		{
			return vtkUniforms.vtkUniforms_GetUniform4f_09(base.GetCppThis(), name, v) != 0;
		}

		// Token: 0x060104EB RID: 66795
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkUniforms_GetUniform4uc_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, IntPtr v);

		/// <summary>
		///  The following are convenience functions and do not reflect
		///  the way the data is stored and sent to OpenGL. Data is
		/// </summary>
		// Token: 0x060104EC RID: 66796 RVA: 0x0016BA60 File Offset: 0x00169C60
		public virtual bool GetUniform4uc(string name, IntPtr v)
		{
			return vtkUniforms.vtkUniforms_GetUniform4uc_10(base.GetCppThis(), name, v) != 0;
		}

		// Token: 0x060104ED RID: 66797
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkUniforms_GetUniformListMTime_11(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060104EE RID: 66798 RVA: 0x0016BA88 File Offset: 0x00169C88
		public virtual ulong GetUniformListMTime()
		{
			return vtkUniforms.vtkUniforms_GetUniformListMTime_11(base.GetCppThis());
		}

		// Token: 0x060104EF RID: 66799
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkUniforms_GetUniformMatrix_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, HandleRef v);

		/// <summary>
		///  The following are convenience functions and do not reflect
		///  the way the data is stored and sent to OpenGL. Data is
		/// </summary>
		// Token: 0x060104F0 RID: 66800 RVA: 0x0016BAA8 File Offset: 0x00169CA8
		public virtual bool GetUniformMatrix(string name, vtkMatrix3x3 v)
		{
			return vtkUniforms.vtkUniforms_GetUniformMatrix_12(base.GetCppThis(), name, (v == null) ? default(HandleRef) : v.GetCppThis()) != 0;
		}

		// Token: 0x060104F1 RID: 66801
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkUniforms_GetUniformMatrix_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, HandleRef v);

		/// <summary>
		///  The following are convenience functions and do not reflect
		///  the way the data is stored and sent to OpenGL. Data is
		/// </summary>
		// Token: 0x060104F2 RID: 66802 RVA: 0x0016BAE4 File Offset: 0x00169CE4
		public virtual bool GetUniformMatrix(string name, vtkMatrix4x4 v)
		{
			return vtkUniforms.vtkUniforms_GetUniformMatrix_13(base.GetCppThis(), name, (v == null) ? default(HandleRef) : v.GetCppThis()) != 0;
		}

		// Token: 0x060104F3 RID: 66803
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkUniforms_GetUniformMatrix3x3_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, IntPtr v);

		/// <summary>
		/// Get the @p name uniform value. Returns true on success. 
		/// </summary>
		// Token: 0x060104F4 RID: 66804 RVA: 0x0016BB20 File Offset: 0x00169D20
		public virtual bool GetUniformMatrix3x3(string name, IntPtr v)
		{
			return vtkUniforms.vtkUniforms_GetUniformMatrix3x3_14(base.GetCppThis(), name, v) != 0;
		}

		// Token: 0x060104F5 RID: 66805
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkUniforms_GetUniformMatrix4x4_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, IntPtr v);

		/// <summary>
		/// Get the @p name uniform value. Returns true on success. 
		/// </summary>
		// Token: 0x060104F6 RID: 66806 RVA: 0x0016BB48 File Offset: 0x00169D48
		public virtual bool GetUniformMatrix4x4(string name, IntPtr v)
		{
			return vtkUniforms.vtkUniforms_GetUniformMatrix4x4_15(base.GetCppThis(), name, v) != 0;
		}

		// Token: 0x060104F7 RID: 66807
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUniforms_GetUniformNumberOfComponents_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		///  for example, a uniform with tuples of matrix type and 9 components
		/// </summary>
		// Token: 0x060104F8 RID: 66808 RVA: 0x0016BB70 File Offset: 0x00169D70
		public virtual int GetUniformNumberOfComponents(string name)
		{
			return vtkUniforms.vtkUniforms_GetUniformNumberOfComponents_16(base.GetCppThis(), name);
		}

		// Token: 0x060104F9 RID: 66809
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUniforms_GetUniformNumberOfTuples_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		///  For example, for 3 components uniforms of type vector, this is the number
		/// </summary>
		// Token: 0x060104FA RID: 66810 RVA: 0x0016BB90 File Offset: 0x00169D90
		public virtual int GetUniformNumberOfTuples(string name)
		{
			return vtkUniforms.vtkUniforms_GetUniformNumberOfTuples_17(base.GetCppThis(), name);
		}

		// Token: 0x060104FB RID: 66811
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUniforms_GetUniformScalarType_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Get type of scalars stored in uniform @p name 
		/// </summary>
		// Token: 0x060104FC RID: 66812 RVA: 0x0016BBB0 File Offset: 0x00169DB0
		public virtual int GetUniformScalarType(string name)
		{
			return vtkUniforms.vtkUniforms_GetUniformScalarType_18(base.GetCppThis(), name);
		}

		// Token: 0x060104FD RID: 66813
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkUniforms.TupleType vtkUniforms_GetUniformTupleType_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Get the tuple type stored in uniform @p name. This can be a scala
		/// </summary>
		// Token: 0x060104FE RID: 66814 RVA: 0x0016BBD0 File Offset: 0x00169DD0
		public virtual vtkUniforms.TupleType GetUniformTupleType(string name)
		{
			return vtkUniforms.vtkUniforms_GetUniformTupleType_19(base.GetCppThis(), name);
		}

		// Token: 0x060104FF RID: 66815
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkUniforms_GetUniformf_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, ref float v);

		/// <summary>
		/// Get the @p name uniform value. Returns true on success. 
		/// </summary>
		// Token: 0x06010500 RID: 66816 RVA: 0x0016BBF0 File Offset: 0x00169DF0
		public virtual bool GetUniformf(string name, ref float v)
		{
			return vtkUniforms.vtkUniforms_GetUniformf_20(base.GetCppThis(), name, ref v) != 0;
		}

		// Token: 0x06010501 RID: 66817
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkUniforms_GetUniformi_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, ref int v);

		/// <summary>
		/// Get the @p name uniform value. Returns true on success. 
		/// </summary>
		// Token: 0x06010502 RID: 66818 RVA: 0x0016BC18 File Offset: 0x00169E18
		public virtual bool GetUniformi(string name, ref int v)
		{
			return vtkUniforms.vtkUniforms_GetUniformi_21(base.GetCppThis(), name, ref v) != 0;
		}

		// Token: 0x06010503 RID: 66819
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUniforms_IsA_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010504 RID: 66820 RVA: 0x0016BC40 File Offset: 0x00169E40
		public override int IsA(string type)
		{
			return vtkUniforms.vtkUniforms_IsA_22(base.GetCppThis(), type);
		}

		// Token: 0x06010505 RID: 66821
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUniforms_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010506 RID: 66822 RVA: 0x0016BC60 File Offset: 0x00169E60
		public new static int IsTypeOf(string type)
		{
			return vtkUniforms.vtkUniforms_IsTypeOf_23(type);
		}

		// Token: 0x06010507 RID: 66823
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUniforms_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010508 RID: 66824 RVA: 0x0016BC7C File Offset: 0x00169E7C
		public new vtkUniforms NewInstance()
		{
			vtkUniforms result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUniforms.vtkUniforms_NewInstance_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUniforms)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010509 RID: 66825
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUniforms_RemoveAllUniforms_26(HandleRef pThis);

		/// <summary>
		/// Remove all uniform variables 
		/// </summary>
		// Token: 0x0601050A RID: 66826 RVA: 0x0016BCD6 File Offset: 0x00169ED6
		public virtual void RemoveAllUniforms()
		{
			vtkUniforms.vtkUniforms_RemoveAllUniforms_26(base.GetCppThis());
		}

		// Token: 0x0601050B RID: 66827
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUniforms_RemoveUniform_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Remove uniform variable named @p name 
		/// </summary>
		// Token: 0x0601050C RID: 66828 RVA: 0x0016BCE5 File Offset: 0x00169EE5
		public virtual void RemoveUniform(string name)
		{
			vtkUniforms.vtkUniforms_RemoveUniform_27(base.GetCppThis(), name);
		}

		// Token: 0x0601050D RID: 66829
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUniforms_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601050E RID: 66830 RVA: 0x0016BCF8 File Offset: 0x00169EF8
		public new static vtkUniforms SafeDownCast(vtkObjectBase o)
		{
			vtkUniforms vtkUniforms = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUniforms.vtkUniforms_SafeDownCast_28((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUniforms = (vtkUniforms)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUniforms.Register(null);
				}
			}
			return vtkUniforms;
		}

		// Token: 0x0601050F RID: 66831
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkUniforms_ScalarTypeToString_29(int scalarType);

		/// <summary>
		/// Convert between scalar types an string 
		/// </summary>
		// Token: 0x06010510 RID: 66832 RVA: 0x0016BD78 File Offset: 0x00169F78
		public static string ScalarTypeToString(int scalarType)
		{
			return vtkUniforms.vtkUniforms_ScalarTypeToString_29(scalarType);
		}

		// Token: 0x06010511 RID: 66833
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUniforms_SetUniform1fv_30(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int count, IntPtr f);

		/// <summary>
		/// Set the @p name uniform array to @p f with @p count elements 
		/// </summary>
		// Token: 0x06010512 RID: 66834 RVA: 0x0016BD92 File Offset: 0x00169F92
		public virtual void SetUniform1fv(string name, int count, IntPtr f)
		{
			vtkUniforms.vtkUniforms_SetUniform1fv_30(base.GetCppThis(), name, count, f);
		}

		// Token: 0x06010513 RID: 66835
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUniforms_SetUniform1iv_31(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int count, IntPtr f);

		/// <summary>
		/// Set the @p name uniform array to @p f with @p count elements 
		/// </summary>
		// Token: 0x06010514 RID: 66836 RVA: 0x0016BDA4 File Offset: 0x00169FA4
		public virtual void SetUniform1iv(string name, int count, IntPtr f)
		{
			vtkUniforms.vtkUniforms_SetUniform1iv_31(base.GetCppThis(), name, count, f);
		}

		// Token: 0x06010515 RID: 66837
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUniforms_SetUniform2f_32(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, IntPtr v);

		/// <summary>
		/// Set the @p name uniform value to @p v. 
		/// </summary>
		// Token: 0x06010516 RID: 66838 RVA: 0x0016BDB6 File Offset: 0x00169FB6
		public virtual void SetUniform2f(string name, IntPtr v)
		{
			vtkUniforms.vtkUniforms_SetUniform2f_32(base.GetCppThis(), name, v);
		}

		// Token: 0x06010517 RID: 66839
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUniforms_SetUniform2i_33(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, IntPtr v);

		/// <summary>
		/// Set the @p name uniform value to @p v. 
		/// </summary>
		// Token: 0x06010518 RID: 66840 RVA: 0x0016BDC7 File Offset: 0x00169FC7
		public virtual void SetUniform2i(string name, IntPtr v)
		{
			vtkUniforms.vtkUniforms_SetUniform2i_33(base.GetCppThis(), name, v);
		}

		// Token: 0x06010519 RID: 66841
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUniforms_SetUniform3f_34(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, IntPtr v);

		/// <summary>
		/// Set the @p name uniform value to @p v. 
		/// </summary>
		// Token: 0x0601051A RID: 66842 RVA: 0x0016BDD8 File Offset: 0x00169FD8
		public virtual void SetUniform3f(string name, IntPtr v)
		{
			vtkUniforms.vtkUniforms_SetUniform3f_34(base.GetCppThis(), name, v);
		}

		// Token: 0x0601051B RID: 66843
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUniforms_SetUniform3uc_35(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, IntPtr v);

		/// <summary>
		///  The following are convenience functions and do not reflect
		///  the way the data is stored and sent to OpenGL. Data is
		/// </summary>
		// Token: 0x0601051C RID: 66844 RVA: 0x0016BDE9 File Offset: 0x00169FE9
		public virtual void SetUniform3uc(string name, IntPtr v)
		{
			vtkUniforms.vtkUniforms_SetUniform3uc_35(base.GetCppThis(), name, v);
		}

		// Token: 0x0601051D RID: 66845
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUniforms_SetUniform4f_36(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, IntPtr v);

		/// <summary>
		/// Set the @p name uniform value to @p v. 
		/// </summary>
		// Token: 0x0601051E RID: 66846 RVA: 0x0016BDFA File Offset: 0x00169FFA
		public virtual void SetUniform4f(string name, IntPtr v)
		{
			vtkUniforms.vtkUniforms_SetUniform4f_36(base.GetCppThis(), name, v);
		}

		// Token: 0x0601051F RID: 66847
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUniforms_SetUniform4uc_37(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, IntPtr v);

		/// <summary>
		///  The following are convenience functions and do not reflect
		///  the way the data is stored and sent to OpenGL. Data is
		/// </summary>
		// Token: 0x06010520 RID: 66848 RVA: 0x0016BE0B File Offset: 0x0016A00B
		public virtual void SetUniform4uc(string name, IntPtr v)
		{
			vtkUniforms.vtkUniforms_SetUniform4uc_37(base.GetCppThis(), name, v);
		}

		// Token: 0x06010521 RID: 66849
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUniforms_SetUniformMatrix_38(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, HandleRef v);

		/// <summary>
		///  The following are convenience functions and do not reflect
		///  the way the data is stored and sent to OpenGL. Data is
		/// </summary>
		// Token: 0x06010522 RID: 66850 RVA: 0x0016BE1C File Offset: 0x0016A01C
		public virtual void SetUniformMatrix(string name, vtkMatrix3x3 v)
		{
			vtkUniforms.vtkUniforms_SetUniformMatrix_38(base.GetCppThis(), name, (v == null) ? default(HandleRef) : v.GetCppThis());
		}

		// Token: 0x06010523 RID: 66851
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUniforms_SetUniformMatrix_39(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, HandleRef v);

		/// <summary>
		///  The following are convenience functions and do not reflect
		///  the way the data is stored and sent to OpenGL. Data is
		/// </summary>
		// Token: 0x06010524 RID: 66852 RVA: 0x0016BE4C File Offset: 0x0016A04C
		public virtual void SetUniformMatrix(string name, vtkMatrix4x4 v)
		{
			vtkUniforms.vtkUniforms_SetUniformMatrix_39(base.GetCppThis(), name, (v == null) ? default(HandleRef) : v.GetCppThis());
		}

		// Token: 0x06010525 RID: 66853
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUniforms_SetUniformMatrix3x3_40(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, IntPtr v);

		/// <summary>
		/// Set the @p name uniform value to @p v. 
		/// </summary>
		// Token: 0x06010526 RID: 66854 RVA: 0x0016BE7C File Offset: 0x0016A07C
		public virtual void SetUniformMatrix3x3(string name, IntPtr v)
		{
			vtkUniforms.vtkUniforms_SetUniformMatrix3x3_40(base.GetCppThis(), name, v);
		}

		// Token: 0x06010527 RID: 66855
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUniforms_SetUniformMatrix4x4_41(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, IntPtr v);

		/// <summary>
		/// Set the @p name uniform value to @p v. 
		/// </summary>
		// Token: 0x06010528 RID: 66856 RVA: 0x0016BE8D File Offset: 0x0016A08D
		public virtual void SetUniformMatrix4x4(string name, IntPtr v)
		{
			vtkUniforms.vtkUniforms_SetUniformMatrix4x4_41(base.GetCppThis(), name, v);
		}

		// Token: 0x06010529 RID: 66857
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUniforms_SetUniformMatrix4x4v_42(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int count, IntPtr v);

		/// <summary>
		/// Set the @p name uniform array to @p f with @p count elements 
		/// </summary>
		// Token: 0x0601052A RID: 66858 RVA: 0x0016BE9E File Offset: 0x0016A09E
		public virtual void SetUniformMatrix4x4v(string name, int count, IntPtr v)
		{
			vtkUniforms.vtkUniforms_SetUniformMatrix4x4v_42(base.GetCppThis(), name, count, v);
		}

		// Token: 0x0601052B RID: 66859
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUniforms_SetUniformf_43(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, float v);

		/// <summary>
		/// Set the @p name uniform value to @p v. 
		/// </summary>
		// Token: 0x0601052C RID: 66860 RVA: 0x0016BEB0 File Offset: 0x0016A0B0
		public virtual void SetUniformf(string name, float v)
		{
			vtkUniforms.vtkUniforms_SetUniformf_43(base.GetCppThis(), name, v);
		}

		// Token: 0x0601052D RID: 66861
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUniforms_SetUniformi_44(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int v);

		/// <summary>
		/// Set the @p name uniform value to @p v. 
		/// </summary>
		// Token: 0x0601052E RID: 66862 RVA: 0x0016BEC1 File Offset: 0x0016A0C1
		public virtual void SetUniformi(string name, int v)
		{
			vtkUniforms.vtkUniforms_SetUniformi_44(base.GetCppThis(), name, v);
		}

		// Token: 0x0601052F RID: 66863
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUniforms_StringToScalarType_45([MarshalAs(UnmanagedType.LPUTF8Str)] string s);

		/// <summary>
		/// Convert between scalar types an string 
		/// </summary>
		// Token: 0x06010530 RID: 66864 RVA: 0x0016BED4 File Offset: 0x0016A0D4
		public static int StringToScalarType(string s)
		{
			return vtkUniforms.vtkUniforms_StringToScalarType_45(s);
		}

		// Token: 0x06010531 RID: 66865
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkUniforms.TupleType vtkUniforms_StringToTupleType_46([MarshalAs(UnmanagedType.LPUTF8Str)] string s);

		/// <summary>
		/// Convert between TupleType and string 
		/// </summary>
		// Token: 0x06010532 RID: 66866 RVA: 0x0016BEF0 File Offset: 0x0016A0F0
		public static vtkUniforms.TupleType StringToTupleType(string s)
		{
			return vtkUniforms.vtkUniforms_StringToTupleType_46(s);
		}

		// Token: 0x06010533 RID: 66867
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkUniforms_TupleTypeToString_47(vtkUniforms.TupleType tt);

		/// <summary>
		/// Convert between TupleType and string 
		/// </summary>
		// Token: 0x06010534 RID: 66868 RVA: 0x0016BF0C File Offset: 0x0016A10C
		public static string TupleTypeToString(vtkUniforms.TupleType tt)
		{
			return vtkUniforms.vtkUniforms_TupleTypeToString_47(tt);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012F3 RID: 4851
		public new const string MRFullTypeName = "Kitware.VTK.vtkUniforms";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012F4 RID: 4852
		public new static readonly string MRClassNameKey = "class vtkUniforms";

		/// <summary>
		/// Types of tuples that can be stored : scalar, vector, matrix
		/// </summary>
		// Token: 0x020005D7 RID: 1495
		public enum TupleType
		{
			/// <summary>enum member</summary>
			// Token: 0x040012F6 RID: 4854
			NumberOfTupleTypes = 4,
			/// <summary>enum member</summary>
			// Token: 0x040012F7 RID: 4855
			TupleTypeInvalid = 0,
			/// <summary>enum member</summary>
			// Token: 0x040012F8 RID: 4856
			TupleTypeMatrix = 3,
			/// <summary>enum member</summary>
			// Token: 0x040012F9 RID: 4857
			TupleTypeScalar = 1,
			/// <summary>enum member</summary>
			// Token: 0x040012FA RID: 4858
			TupleTypeVector
		}
	}
}
