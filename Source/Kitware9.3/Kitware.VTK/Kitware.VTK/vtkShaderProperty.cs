using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkShaderProperty
	/// </summary>
	/// <remarks>
	///    represent GPU shader properties
	///
	/// vtkShaderProperty is used to hold user-defined modifications of a
	/// GPU shader program used in a mapper.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkVolume vtkOpenGLUniform
	///
	/// @par Thanks:
	/// Developed by Simon Drouin (sdrouin2@bwh.harvard.edu) at Brigham and Women's Hospital.
	///
	/// </seealso>
	// Token: 0x020005C7 RID: 1479
	public abstract class vtkShaderProperty : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060102A5 RID: 66213 RVA: 0x00168377 File Offset: 0x00166577
		static vtkShaderProperty()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkShaderProperty.MRClassNameKey, Type.GetType("Kitware.VTK.vtkShaderProperty"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060102A6 RID: 66214 RVA: 0x0016839F File Offset: 0x0016659F
		public vtkShaderProperty(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060102A7 RID: 66215
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkShaderProperty_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with no shader replacements
		/// </summary>
		// Token: 0x060102A8 RID: 66216 RVA: 0x001683B0 File Offset: 0x001665B0
		public new static vtkShaderProperty New()
		{
			vtkShaderProperty result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkShaderProperty.vtkShaderProperty_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkShaderProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object with no shader replacements
		/// </summary>
		// Token: 0x060102A9 RID: 66217 RVA: 0x00168404 File Offset: 0x00166604
		public vtkShaderProperty() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkShaderProperty.vtkShaderProperty_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060102AA RID: 66218 RVA: 0x00168448 File Offset: 0x00166648
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060102AB RID: 66219
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkShaderProperty_AddFragmentShaderReplacement_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string originalValue, byte replaceFirst, [MarshalAs(UnmanagedType.LPUTF8Str)] string replacementValue, byte replaceAll);

		/// <summary>
		/// This function enables you to apply your own substitutions
		/// to the shader creation process. The shader code in this class
		/// is created by applying a bunch of string replacements to a
		/// shader template. Using this function you can apply your
		/// own string replacements to add features you desire.
		/// </summary>
		// Token: 0x060102AC RID: 66220 RVA: 0x00168453 File Offset: 0x00166653
		public virtual void AddFragmentShaderReplacement(string originalValue, bool replaceFirst, string replacementValue, bool replaceAll)
		{
			vtkShaderProperty.vtkShaderProperty_AddFragmentShaderReplacement_01(base.GetCppThis(), originalValue, replaceFirst ? (byte)1 : (byte)0, replacementValue, replaceAll ? (byte)1 : (byte)0);
		}

		// Token: 0x060102AD RID: 66221
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkShaderProperty_AddGeometryShaderReplacement_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string originalValue, byte replaceFirst, [MarshalAs(UnmanagedType.LPUTF8Str)] string replacementValue, byte replaceAll);

		/// <summary>
		/// This function enables you to apply your own substitutions
		/// to the shader creation process. The shader code in this class
		/// is created by applying a bunch of string replacements to a
		/// shader template. Using this function you can apply your
		/// own string replacements to add features you desire.
		/// </summary>
		// Token: 0x060102AE RID: 66222 RVA: 0x00168477 File Offset: 0x00166677
		public virtual void AddGeometryShaderReplacement(string originalValue, bool replaceFirst, string replacementValue, bool replaceAll)
		{
			vtkShaderProperty.vtkShaderProperty_AddGeometryShaderReplacement_02(base.GetCppThis(), originalValue, replaceFirst ? (byte)1 : (byte)0, replacementValue, replaceAll ? (byte)1 : (byte)0);
		}

		// Token: 0x060102AF RID: 66223
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkShaderProperty_AddVertexShaderReplacement_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string originalValue, byte replaceFirst, [MarshalAs(UnmanagedType.LPUTF8Str)] string replacementValue, byte replaceAll);

		/// <summary>
		/// This function enables you to apply your own substitutions
		/// to the shader creation process. The shader code in this class
		/// is created by applying a bunch of string replacements to a
		/// shader template. Using this function you can apply your
		/// own string replacements to add features you desire.
		/// </summary>
		// Token: 0x060102B0 RID: 66224 RVA: 0x0016849B File Offset: 0x0016669B
		public virtual void AddVertexShaderReplacement(string originalValue, bool replaceFirst, string replacementValue, bool replaceAll)
		{
			vtkShaderProperty.vtkShaderProperty_AddVertexShaderReplacement_03(base.GetCppThis(), originalValue, replaceFirst ? (byte)1 : (byte)0, replacementValue, replaceAll ? (byte)1 : (byte)0);
		}

		// Token: 0x060102B1 RID: 66225
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkShaderProperty_ClearAllFragmentShaderReplacements_04(HandleRef pThis);

		/// <summary>
		/// This function enables you to apply your own substitutions
		/// to the shader creation process. The shader code in this class
		/// is created by applying a bunch of string replacements to a
		/// shader template. Using this function you can apply your
		/// own string replacements to add features you desire.
		/// </summary>
		// Token: 0x060102B2 RID: 66226 RVA: 0x001684BF File Offset: 0x001666BF
		public virtual void ClearAllFragmentShaderReplacements()
		{
			vtkShaderProperty.vtkShaderProperty_ClearAllFragmentShaderReplacements_04(base.GetCppThis());
		}

		// Token: 0x060102B3 RID: 66227
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkShaderProperty_ClearAllGeometryShaderReplacements_05(HandleRef pThis);

		/// <summary>
		/// This function enables you to apply your own substitutions
		/// to the shader creation process. The shader code in this class
		/// is created by applying a bunch of string replacements to a
		/// shader template. Using this function you can apply your
		/// own string replacements to add features you desire.
		/// </summary>
		// Token: 0x060102B4 RID: 66228 RVA: 0x001684CE File Offset: 0x001666CE
		public virtual void ClearAllGeometryShaderReplacements()
		{
			vtkShaderProperty.vtkShaderProperty_ClearAllGeometryShaderReplacements_05(base.GetCppThis());
		}

		// Token: 0x060102B5 RID: 66229
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkShaderProperty_ClearAllShaderReplacements_06(HandleRef pThis);

		/// <summary>
		/// This function enables you to apply your own substitutions
		/// to the shader creation process. The shader code in this class
		/// is created by applying a bunch of string replacements to a
		/// shader template. Using this function you can apply your
		/// own string replacements to add features you desire.
		/// </summary>
		// Token: 0x060102B6 RID: 66230 RVA: 0x001684DD File Offset: 0x001666DD
		public virtual void ClearAllShaderReplacements()
		{
			vtkShaderProperty.vtkShaderProperty_ClearAllShaderReplacements_06(base.GetCppThis());
		}

		// Token: 0x060102B7 RID: 66231
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkShaderProperty_ClearAllVertexShaderReplacements_07(HandleRef pThis);

		/// <summary>
		/// This function enables you to apply your own substitutions
		/// to the shader creation process. The shader code in this class
		/// is created by applying a bunch of string replacements to a
		/// shader template. Using this function you can apply your
		/// own string replacements to add features you desire.
		/// </summary>
		// Token: 0x060102B8 RID: 66232 RVA: 0x001684EC File Offset: 0x001666EC
		public virtual void ClearAllVertexShaderReplacements()
		{
			vtkShaderProperty.vtkShaderProperty_ClearAllVertexShaderReplacements_07(base.GetCppThis());
		}

		// Token: 0x060102B9 RID: 66233
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkShaderProperty_ClearFragmentShaderReplacement_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string originalValue, byte replaceFirst);

		/// <summary>
		/// This function enables you to apply your own substitutions
		/// to the shader creation process. The shader code in this class
		/// is created by applying a bunch of string replacements to a
		/// shader template. Using this function you can apply your
		/// own string replacements to add features you desire.
		/// </summary>
		// Token: 0x060102BA RID: 66234 RVA: 0x001684FB File Offset: 0x001666FB
		public virtual void ClearFragmentShaderReplacement(string originalValue, bool replaceFirst)
		{
			vtkShaderProperty.vtkShaderProperty_ClearFragmentShaderReplacement_08(base.GetCppThis(), originalValue, replaceFirst ? (byte)1 : (byte)0);
		}

		// Token: 0x060102BB RID: 66235
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkShaderProperty_ClearGeometryShaderReplacement_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string originalValue, byte replaceFirst);

		/// <summary>
		/// This function enables you to apply your own substitutions
		/// to the shader creation process. The shader code in this class
		/// is created by applying a bunch of string replacements to a
		/// shader template. Using this function you can apply your
		/// own string replacements to add features you desire.
		/// </summary>
		// Token: 0x060102BC RID: 66236 RVA: 0x00168514 File Offset: 0x00166714
		public virtual void ClearGeometryShaderReplacement(string originalValue, bool replaceFirst)
		{
			vtkShaderProperty.vtkShaderProperty_ClearGeometryShaderReplacement_09(base.GetCppThis(), originalValue, replaceFirst ? (byte)1 : (byte)0);
		}

		// Token: 0x060102BD RID: 66237
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkShaderProperty_ClearVertexShaderReplacement_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string originalValue, byte replaceFirst);

		/// <summary>
		/// This function enables you to apply your own substitutions
		/// to the shader creation process. The shader code in this class
		/// is created by applying a bunch of string replacements to a
		/// shader template. Using this function you can apply your
		/// own string replacements to add features you desire.
		/// </summary>
		// Token: 0x060102BE RID: 66238 RVA: 0x0016852D File Offset: 0x0016672D
		public virtual void ClearVertexShaderReplacement(string originalValue, bool replaceFirst)
		{
			vtkShaderProperty.vtkShaderProperty_ClearVertexShaderReplacement_10(base.GetCppThis(), originalValue, replaceFirst ? (byte)1 : (byte)0);
		}

		// Token: 0x060102BF RID: 66239
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkShaderProperty_DeepCopy_11(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Assign one property to another.
		/// </summary>
		// Token: 0x060102C0 RID: 66240 RVA: 0x00168548 File Offset: 0x00166748
		public void DeepCopy(vtkShaderProperty p)
		{
			vtkShaderProperty.vtkShaderProperty_DeepCopy_11(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x060102C1 RID: 66241
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkShaderProperty_GetFragmentCustomUniforms_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The Uniforms object allows to set custom uniform variables
		/// that are used in replacement shader code.
		/// </summary>
		// Token: 0x060102C2 RID: 66242 RVA: 0x00168578 File Offset: 0x00166778
		public virtual vtkUniforms GetFragmentCustomUniforms()
		{
			vtkUniforms vtkUniforms = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkShaderProperty.vtkShaderProperty_GetFragmentCustomUniforms_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060102C3 RID: 66243
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkShaderProperty_GetFragmentShaderCode_13(HandleRef pThis);

		/// <summary>
		/// Allow the program to set the shader codes used directly
		/// instead of using the built in templates. Be aware, if
		/// set, this template will be used for all cases,
		/// primitive types, picking etc.
		/// </summary>
		// Token: 0x060102C4 RID: 66244 RVA: 0x001685E8 File Offset: 0x001667E8
		public virtual string GetFragmentShaderCode()
		{
			string s = Marshal.PtrToStringAnsi(vtkShaderProperty.vtkShaderProperty_GetFragmentShaderCode_13(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060102C5 RID: 66245
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkShaderProperty_GetGeometryCustomUniforms_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The Uniforms object allows to set custom uniform variables
		/// that are used in replacement shader code.
		/// </summary>
		// Token: 0x060102C6 RID: 66246 RVA: 0x00168624 File Offset: 0x00166824
		public virtual vtkUniforms GetGeometryCustomUniforms()
		{
			vtkUniforms vtkUniforms = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkShaderProperty.vtkShaderProperty_GetGeometryCustomUniforms_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060102C7 RID: 66247
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkShaderProperty_GetGeometryShaderCode_15(HandleRef pThis);

		/// <summary>
		/// Allow the program to set the shader codes used directly
		/// instead of using the built in templates. Be aware, if
		/// set, this template will be used for all cases,
		/// primitive types, picking etc.
		/// </summary>
		// Token: 0x060102C8 RID: 66248 RVA: 0x00168694 File Offset: 0x00166894
		public virtual string GetGeometryShaderCode()
		{
			string s = Marshal.PtrToStringAnsi(vtkShaderProperty.vtkShaderProperty_GetGeometryShaderCode_15(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060102C9 RID: 66249
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkShaderProperty_GetNthShaderReplacement_16(HandleRef pThis, long index, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, ref byte replaceFirst, [MarshalAs(UnmanagedType.LPUTF8Str)] string replacementValue, ref byte replaceAll);

		/// <summary>
		/// This function enables you to apply your own substitutions
		/// to the shader creation process. The shader code in this class
		/// is created by applying a bunch of string replacements to a
		/// shader template. Using this function you can apply your
		/// own string replacements to add features you desire.
		/// </summary>
		// Token: 0x060102CA RID: 66250 RVA: 0x001686CE File Offset: 0x001668CE
		public virtual void GetNthShaderReplacement(long index, string name, ref byte replaceFirst, string replacementValue, ref byte replaceAll)
		{
			vtkShaderProperty.vtkShaderProperty_GetNthShaderReplacement_16(base.GetCppThis(), index, name, ref replaceFirst, replacementValue, ref replaceAll);
		}

		// Token: 0x060102CB RID: 66251
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkShaderProperty_GetNthShaderReplacementTypeAsString_17(HandleRef pThis, long index);

		/// <summary>
		/// This function enables you to apply your own substitutions
		/// to the shader creation process. The shader code in this class
		/// is created by applying a bunch of string replacements to a
		/// shader template. Using this function you can apply your
		/// own string replacements to add features you desire.
		/// </summary>
		// Token: 0x060102CC RID: 66252 RVA: 0x001686E4 File Offset: 0x001668E4
		public virtual string GetNthShaderReplacementTypeAsString(long index)
		{
			return vtkShaderProperty.vtkShaderProperty_GetNthShaderReplacementTypeAsString_17(base.GetCppThis(), index);
		}

		// Token: 0x060102CD RID: 66253
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkShaderProperty_GetNumberOfGenerationsFromBase_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060102CE RID: 66254 RVA: 0x00168704 File Offset: 0x00166904
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkShaderProperty.vtkShaderProperty_GetNumberOfGenerationsFromBase_18(base.GetCppThis(), type);
		}

		// Token: 0x060102CF RID: 66255
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkShaderProperty_GetNumberOfGenerationsFromBaseType_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060102D0 RID: 66256 RVA: 0x00168724 File Offset: 0x00166924
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkShaderProperty.vtkShaderProperty_GetNumberOfGenerationsFromBaseType_19(type);
		}

		// Token: 0x060102D1 RID: 66257
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkShaderProperty_GetNumberOfShaderReplacements_20(HandleRef pThis);

		/// <summary>
		/// This function enables you to apply your own substitutions
		/// to the shader creation process. The shader code in this class
		/// is created by applying a bunch of string replacements to a
		/// shader template. Using this function you can apply your
		/// own string replacements to add features you desire.
		/// </summary>
		// Token: 0x060102D2 RID: 66258 RVA: 0x00168740 File Offset: 0x00166940
		public virtual int GetNumberOfShaderReplacements()
		{
			return vtkShaderProperty.vtkShaderProperty_GetNumberOfShaderReplacements_20(base.GetCppThis());
		}

		// Token: 0x060102D3 RID: 66259
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkShaderProperty_GetShaderMTime_21(HandleRef pThis);

		/// <summary>
		/// @brief GetShaderMTime returns the last time a modification
		/// was made that affected the code of the shader (either code
		/// replacement was changed or one or more uniform variables were
		/// added or removed. This timestamp can be used by mappers to
		/// determine if the shader must be recompiled. Simply changing
		/// the value of an existing uniform variable doesn't affect this
		/// timestamp as it doesn't change the shader code.
		/// @return timestamp of the last modification
		/// </summary>
		// Token: 0x060102D4 RID: 66260 RVA: 0x00168760 File Offset: 0x00166960
		public ulong GetShaderMTime()
		{
			return vtkShaderProperty.vtkShaderProperty_GetShaderMTime_21(base.GetCppThis());
		}

		// Token: 0x060102D5 RID: 66261
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkShaderProperty_GetVertexCustomUniforms_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The Uniforms object allows to set custom uniform variables
		/// that are used in replacement shader code.
		/// </summary>
		// Token: 0x060102D6 RID: 66262 RVA: 0x00168780 File Offset: 0x00166980
		public virtual vtkUniforms GetVertexCustomUniforms()
		{
			vtkUniforms vtkUniforms = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkShaderProperty.vtkShaderProperty_GetVertexCustomUniforms_22(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060102D7 RID: 66263
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkShaderProperty_GetVertexShaderCode_23(HandleRef pThis);

		/// <summary>
		/// Allow the program to set the shader codes used directly
		/// instead of using the built in templates. Be aware, if
		/// set, this template will be used for all cases,
		/// primitive types, picking etc.
		/// </summary>
		// Token: 0x060102D8 RID: 66264 RVA: 0x001687F0 File Offset: 0x001669F0
		public virtual string GetVertexShaderCode()
		{
			string s = Marshal.PtrToStringAnsi(vtkShaderProperty.vtkShaderProperty_GetVertexShaderCode_23(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060102D9 RID: 66265
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkShaderProperty_HasFragmentShaderCode_24(HandleRef pThis);

		/// <summary>
		/// Allow the program to set the shader codes used directly
		/// instead of using the built in templates. Be aware, if
		/// set, this template will be used for all cases,
		/// primitive types, picking etc.
		/// </summary>
		// Token: 0x060102DA RID: 66266 RVA: 0x0016882C File Offset: 0x00166A2C
		public bool HasFragmentShaderCode()
		{
			return vtkShaderProperty.vtkShaderProperty_HasFragmentShaderCode_24(base.GetCppThis()) != 0;
		}

		// Token: 0x060102DB RID: 66267
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkShaderProperty_HasGeometryShaderCode_25(HandleRef pThis);

		/// <summary>
		/// Allow the program to set the shader codes used directly
		/// instead of using the built in templates. Be aware, if
		/// set, this template will be used for all cases,
		/// primitive types, picking etc.
		/// </summary>
		// Token: 0x060102DC RID: 66268 RVA: 0x00168854 File Offset: 0x00166A54
		public bool HasGeometryShaderCode()
		{
			return vtkShaderProperty.vtkShaderProperty_HasGeometryShaderCode_25(base.GetCppThis()) != 0;
		}

		// Token: 0x060102DD RID: 66269
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkShaderProperty_HasVertexShaderCode_26(HandleRef pThis);

		/// <summary>
		/// Allow the program to set the shader codes used directly
		/// instead of using the built in templates. Be aware, if
		/// set, this template will be used for all cases,
		/// primitive types, picking etc.
		/// </summary>
		// Token: 0x060102DE RID: 66270 RVA: 0x0016887C File Offset: 0x00166A7C
		public bool HasVertexShaderCode()
		{
			return vtkShaderProperty.vtkShaderProperty_HasVertexShaderCode_26(base.GetCppThis()) != 0;
		}

		// Token: 0x060102DF RID: 66271
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkShaderProperty_IsA_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060102E0 RID: 66272 RVA: 0x001688A4 File Offset: 0x00166AA4
		public override int IsA(string type)
		{
			return vtkShaderProperty.vtkShaderProperty_IsA_27(base.GetCppThis(), type);
		}

		// Token: 0x060102E1 RID: 66273
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkShaderProperty_IsTypeOf_28([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060102E2 RID: 66274 RVA: 0x001688C4 File Offset: 0x00166AC4
		public new static int IsTypeOf(string type)
		{
			return vtkShaderProperty.vtkShaderProperty_IsTypeOf_28(type);
		}

		// Token: 0x060102E3 RID: 66275
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkShaderProperty_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060102E4 RID: 66276 RVA: 0x001688E0 File Offset: 0x00166AE0
		public new vtkShaderProperty NewInstance()
		{
			vtkShaderProperty result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkShaderProperty.vtkShaderProperty_NewInstance_30(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkShaderProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060102E5 RID: 66277
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkShaderProperty_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060102E6 RID: 66278 RVA: 0x0016893C File Offset: 0x00166B3C
		public new static vtkShaderProperty SafeDownCast(vtkObjectBase o)
		{
			vtkShaderProperty vtkShaderProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkShaderProperty.vtkShaderProperty_SafeDownCast_31((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkShaderProperty = (vtkShaderProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkShaderProperty.Register(null);
				}
			}
			return vtkShaderProperty;
		}

		// Token: 0x060102E7 RID: 66279
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkShaderProperty_SetFragmentShaderCode_32(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Allow the program to set the shader codes used directly
		/// instead of using the built in templates. Be aware, if
		/// set, this template will be used for all cases,
		/// primitive types, picking etc.
		/// </summary>
		// Token: 0x060102E8 RID: 66280 RVA: 0x001689BB File Offset: 0x00166BBB
		public virtual void SetFragmentShaderCode(string _arg)
		{
			vtkShaderProperty.vtkShaderProperty_SetFragmentShaderCode_32(base.GetCppThis(), _arg);
		}

		// Token: 0x060102E9 RID: 66281
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkShaderProperty_SetGeometryShaderCode_33(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Allow the program to set the shader codes used directly
		/// instead of using the built in templates. Be aware, if
		/// set, this template will be used for all cases,
		/// primitive types, picking etc.
		/// </summary>
		// Token: 0x060102EA RID: 66282 RVA: 0x001689CB File Offset: 0x00166BCB
		public virtual void SetGeometryShaderCode(string _arg)
		{
			vtkShaderProperty.vtkShaderProperty_SetGeometryShaderCode_33(base.GetCppThis(), _arg);
		}

		// Token: 0x060102EB RID: 66283
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkShaderProperty_SetVertexShaderCode_34(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Allow the program to set the shader codes used directly
		/// instead of using the built in templates. Be aware, if
		/// set, this template will be used for all cases,
		/// primitive types, picking etc.
		/// </summary>
		// Token: 0x060102EC RID: 66284 RVA: 0x001689DB File Offset: 0x00166BDB
		public virtual void SetVertexShaderCode(string _arg)
		{
			vtkShaderProperty.vtkShaderProperty_SetVertexShaderCode_34(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012D0 RID: 4816
		public new const string MRFullTypeName = "Kitware.VTK.vtkShaderProperty";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012D1 RID: 4817
		public new static readonly string MRClassNameKey = "class vtkShaderProperty";
	}
}
