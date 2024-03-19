using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenGLShaderProperty
	/// </summary>
	/// <remarks>
	///    represent GPU shader properties
	///
	/// vtkOpenGLShaderProperty is used to hold user-defined modifications of a
	/// GPU shader program used in a mapper.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkShaderProperty vtkUniforms vtkOpenGLUniform
	///
	/// @par Thanks:
	/// Developed by Simon Drouin (sdrouin2@bwh.harvard.edu) at Brigham and Women's Hospital.
	///
	/// </seealso>
	// Token: 0x020005C8 RID: 1480
	public class vtkOpenGLShaderProperty : vtkShaderProperty
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060102ED RID: 66285 RVA: 0x001689EB File Offset: 0x00166BEB
		static vtkOpenGLShaderProperty()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLShaderProperty.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLShaderProperty"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060102EE RID: 66286 RVA: 0x00168A13 File Offset: 0x00166C13
		public vtkOpenGLShaderProperty(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060102EF RID: 66287
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLShaderProperty_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with no shader replacements
		/// </summary>
		// Token: 0x060102F0 RID: 66288 RVA: 0x00168A24 File Offset: 0x00166C24
		public new static vtkOpenGLShaderProperty New()
		{
			vtkOpenGLShaderProperty result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLShaderProperty.vtkOpenGLShaderProperty_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLShaderProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object with no shader replacements
		/// </summary>
		// Token: 0x060102F1 RID: 66289 RVA: 0x00168A78 File Offset: 0x00166C78
		public vtkOpenGLShaderProperty() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenGLShaderProperty.vtkOpenGLShaderProperty_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060102F2 RID: 66290 RVA: 0x00168ABC File Offset: 0x00166CBC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060102F3 RID: 66291
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLShaderProperty_AddFragmentShaderReplacement_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string originalValue, byte replaceFirst, [MarshalAs(UnmanagedType.LPUTF8Str)] string replacementValue, byte replaceAll);

		/// <summary>
		/// Assign one property to another.
		/// </summary>
		// Token: 0x060102F4 RID: 66292 RVA: 0x00168AC7 File Offset: 0x00166CC7
		public override void AddFragmentShaderReplacement(string originalValue, bool replaceFirst, string replacementValue, bool replaceAll)
		{
			vtkOpenGLShaderProperty.vtkOpenGLShaderProperty_AddFragmentShaderReplacement_01(base.GetCppThis(), originalValue, replaceFirst ? (byte)1 : (byte)0, replacementValue, replaceAll ? (byte)1 : (byte)0);
		}

		// Token: 0x060102F5 RID: 66293
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLShaderProperty_AddGeometryShaderReplacement_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string originalValue, byte replaceFirst, [MarshalAs(UnmanagedType.LPUTF8Str)] string replacementValue, byte replaceAll);

		/// <summary>
		/// Assign one property to another.
		/// </summary>
		// Token: 0x060102F6 RID: 66294 RVA: 0x00168AEB File Offset: 0x00166CEB
		public override void AddGeometryShaderReplacement(string originalValue, bool replaceFirst, string replacementValue, bool replaceAll)
		{
			vtkOpenGLShaderProperty.vtkOpenGLShaderProperty_AddGeometryShaderReplacement_02(base.GetCppThis(), originalValue, replaceFirst ? (byte)1 : (byte)0, replacementValue, replaceAll ? (byte)1 : (byte)0);
		}

		// Token: 0x060102F7 RID: 66295
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLShaderProperty_AddShaderReplacement_03(HandleRef pThis, vtkShader.Type shaderType, [MarshalAs(UnmanagedType.LPUTF8Str)] string originalValue, byte replaceFirst, [MarshalAs(UnmanagedType.LPUTF8Str)] string replacementValue, byte replaceAll);

		/// <summary>
		/// This function enables you to apply your own substitutions
		/// to the shader creation process. The shader code in this class
		/// is created by applying a bunch of string replacements to a
		/// shader template. Using this function you can apply your
		/// own string replacements to add features you desire.
		/// </summary>
		// Token: 0x060102F8 RID: 66296 RVA: 0x00168B0F File Offset: 0x00166D0F
		public void AddShaderReplacement(vtkShader.Type shaderType, string originalValue, bool replaceFirst, string replacementValue, bool replaceAll)
		{
			vtkOpenGLShaderProperty.vtkOpenGLShaderProperty_AddShaderReplacement_03(base.GetCppThis(), shaderType, originalValue, replaceFirst ? (byte)1 : (byte)0, replacementValue, replaceAll ? (byte)1 : (byte)0);
		}

		// Token: 0x060102F9 RID: 66297
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLShaderProperty_AddVertexShaderReplacement_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string originalValue, byte replaceFirst, [MarshalAs(UnmanagedType.LPUTF8Str)] string replacementValue, byte replaceAll);

		/// <summary>
		/// Assign one property to another.
		/// </summary>
		// Token: 0x060102FA RID: 66298 RVA: 0x00168B35 File Offset: 0x00166D35
		public override void AddVertexShaderReplacement(string originalValue, bool replaceFirst, string replacementValue, bool replaceAll)
		{
			vtkOpenGLShaderProperty.vtkOpenGLShaderProperty_AddVertexShaderReplacement_04(base.GetCppThis(), originalValue, replaceFirst ? (byte)1 : (byte)0, replacementValue, replaceAll ? (byte)1 : (byte)0);
		}

		// Token: 0x060102FB RID: 66299
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLShaderProperty_ClearAllFragmentShaderReplacements_05(HandleRef pThis);

		/// <summary>
		/// Assign one property to another.
		/// </summary>
		// Token: 0x060102FC RID: 66300 RVA: 0x00168B59 File Offset: 0x00166D59
		public override void ClearAllFragmentShaderReplacements()
		{
			vtkOpenGLShaderProperty.vtkOpenGLShaderProperty_ClearAllFragmentShaderReplacements_05(base.GetCppThis());
		}

		// Token: 0x060102FD RID: 66301
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLShaderProperty_ClearAllGeometryShaderReplacements_06(HandleRef pThis);

		/// <summary>
		/// Assign one property to another.
		/// </summary>
		// Token: 0x060102FE RID: 66302 RVA: 0x00168B68 File Offset: 0x00166D68
		public override void ClearAllGeometryShaderReplacements()
		{
			vtkOpenGLShaderProperty.vtkOpenGLShaderProperty_ClearAllGeometryShaderReplacements_06(base.GetCppThis());
		}

		// Token: 0x060102FF RID: 66303
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLShaderProperty_ClearAllShaderReplacements_07(HandleRef pThis);

		/// <summary>
		/// Assign one property to another.
		/// </summary>
		// Token: 0x06010300 RID: 66304 RVA: 0x00168B77 File Offset: 0x00166D77
		public override void ClearAllShaderReplacements()
		{
			vtkOpenGLShaderProperty.vtkOpenGLShaderProperty_ClearAllShaderReplacements_07(base.GetCppThis());
		}

		// Token: 0x06010301 RID: 66305
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLShaderProperty_ClearAllShaderReplacements_08(HandleRef pThis, vtkShader.Type shaderType);

		/// <summary>
		/// This function enables you to apply your own substitutions
		/// to the shader creation process. The shader code in this class
		/// is created by applying a bunch of string replacements to a
		/// shader template. Using this function you can apply your
		/// own string replacements to add features you desire.
		/// </summary>
		// Token: 0x06010302 RID: 66306 RVA: 0x00168B86 File Offset: 0x00166D86
		public void ClearAllShaderReplacements(vtkShader.Type shaderType)
		{
			vtkOpenGLShaderProperty.vtkOpenGLShaderProperty_ClearAllShaderReplacements_08(base.GetCppThis(), shaderType);
		}

		// Token: 0x06010303 RID: 66307
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLShaderProperty_ClearAllVertexShaderReplacements_09(HandleRef pThis);

		/// <summary>
		/// Assign one property to another.
		/// </summary>
		// Token: 0x06010304 RID: 66308 RVA: 0x00168B96 File Offset: 0x00166D96
		public override void ClearAllVertexShaderReplacements()
		{
			vtkOpenGLShaderProperty.vtkOpenGLShaderProperty_ClearAllVertexShaderReplacements_09(base.GetCppThis());
		}

		// Token: 0x06010305 RID: 66309
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLShaderProperty_ClearFragmentShaderReplacement_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string originalValue, byte replaceFirst);

		/// <summary>
		/// Assign one property to another.
		/// </summary>
		// Token: 0x06010306 RID: 66310 RVA: 0x00168BA5 File Offset: 0x00166DA5
		public override void ClearFragmentShaderReplacement(string originalValue, bool replaceFirst)
		{
			vtkOpenGLShaderProperty.vtkOpenGLShaderProperty_ClearFragmentShaderReplacement_10(base.GetCppThis(), originalValue, replaceFirst ? (byte)1 : (byte)0);
		}

		// Token: 0x06010307 RID: 66311
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLShaderProperty_ClearGeometryShaderReplacement_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string originalValue, byte replaceFirst);

		/// <summary>
		/// Assign one property to another.
		/// </summary>
		// Token: 0x06010308 RID: 66312 RVA: 0x00168BBE File Offset: 0x00166DBE
		public override void ClearGeometryShaderReplacement(string originalValue, bool replaceFirst)
		{
			vtkOpenGLShaderProperty.vtkOpenGLShaderProperty_ClearGeometryShaderReplacement_11(base.GetCppThis(), originalValue, replaceFirst ? (byte)1 : (byte)0);
		}

		// Token: 0x06010309 RID: 66313
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLShaderProperty_ClearShaderReplacement_12(HandleRef pThis, vtkShader.Type shaderType, [MarshalAs(UnmanagedType.LPUTF8Str)] string originalValue, byte replaceFirst);

		/// <summary>
		/// This function enables you to apply your own substitutions
		/// to the shader creation process. The shader code in this class
		/// is created by applying a bunch of string replacements to a
		/// shader template. Using this function you can apply your
		/// own string replacements to add features you desire.
		/// </summary>
		// Token: 0x0601030A RID: 66314 RVA: 0x00168BD7 File Offset: 0x00166DD7
		public void ClearShaderReplacement(vtkShader.Type shaderType, string originalValue, bool replaceFirst)
		{
			vtkOpenGLShaderProperty.vtkOpenGLShaderProperty_ClearShaderReplacement_12(base.GetCppThis(), shaderType, originalValue, replaceFirst ? (byte)1 : (byte)0);
		}

		// Token: 0x0601030B RID: 66315
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLShaderProperty_ClearVertexShaderReplacement_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string originalValue, byte replaceFirst);

		/// <summary>
		/// Assign one property to another.
		/// </summary>
		// Token: 0x0601030C RID: 66316 RVA: 0x00168BF1 File Offset: 0x00166DF1
		public override void ClearVertexShaderReplacement(string originalValue, bool replaceFirst)
		{
			vtkOpenGLShaderProperty.vtkOpenGLShaderProperty_ClearVertexShaderReplacement_13(base.GetCppThis(), originalValue, replaceFirst ? (byte)1 : (byte)0);
		}

		// Token: 0x0601030D RID: 66317
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLShaderProperty_DeepCopy_14(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Assign one property to another.
		/// </summary>
		// Token: 0x0601030E RID: 66318 RVA: 0x00168C0C File Offset: 0x00166E0C
		public void DeepCopy(vtkOpenGLShaderProperty p)
		{
			vtkOpenGLShaderProperty.vtkOpenGLShaderProperty_DeepCopy_14(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x0601030F RID: 66319
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLShaderProperty_GetNthShaderReplacement_15(HandleRef pThis, long index, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, ref byte replaceFirst, [MarshalAs(UnmanagedType.LPUTF8Str)] string replacementValue, ref byte replaceAll);

		/// <summary>
		/// Assign one property to another.
		/// </summary>
		// Token: 0x06010310 RID: 66320 RVA: 0x00168C3B File Offset: 0x00166E3B
		public override void GetNthShaderReplacement(long index, string name, ref byte replaceFirst, string replacementValue, ref byte replaceAll)
		{
			vtkOpenGLShaderProperty.vtkOpenGLShaderProperty_GetNthShaderReplacement_15(base.GetCppThis(), index, name, ref replaceFirst, replacementValue, ref replaceAll);
		}

		// Token: 0x06010311 RID: 66321
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkOpenGLShaderProperty_GetNthShaderReplacementTypeAsString_16(HandleRef pThis, long index);

		/// <summary>
		/// Assign one property to another.
		/// </summary>
		// Token: 0x06010312 RID: 66322 RVA: 0x00168C54 File Offset: 0x00166E54
		public override string GetNthShaderReplacementTypeAsString(long index)
		{
			return vtkOpenGLShaderProperty.vtkOpenGLShaderProperty_GetNthShaderReplacementTypeAsString_16(base.GetCppThis(), index);
		}

		// Token: 0x06010313 RID: 66323
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLShaderProperty_GetNumberOfGenerationsFromBase_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010314 RID: 66324 RVA: 0x00168C74 File Offset: 0x00166E74
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenGLShaderProperty.vtkOpenGLShaderProperty_GetNumberOfGenerationsFromBase_17(base.GetCppThis(), type);
		}

		// Token: 0x06010315 RID: 66325
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLShaderProperty_GetNumberOfGenerationsFromBaseType_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010316 RID: 66326 RVA: 0x00168C94 File Offset: 0x00166E94
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenGLShaderProperty.vtkOpenGLShaderProperty_GetNumberOfGenerationsFromBaseType_18(type);
		}

		// Token: 0x06010317 RID: 66327
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLShaderProperty_GetNumberOfShaderReplacements_19(HandleRef pThis);

		/// <summary>
		/// Assign one property to another.
		/// </summary>
		// Token: 0x06010318 RID: 66328 RVA: 0x00168CB0 File Offset: 0x00166EB0
		public override int GetNumberOfShaderReplacements()
		{
			return vtkOpenGLShaderProperty.vtkOpenGLShaderProperty_GetNumberOfShaderReplacements_19(base.GetCppThis());
		}

		// Token: 0x06010319 RID: 66329
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLShaderProperty_IsA_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601031A RID: 66330 RVA: 0x00168CD0 File Offset: 0x00166ED0
		public override int IsA(string type)
		{
			return vtkOpenGLShaderProperty.vtkOpenGLShaderProperty_IsA_20(base.GetCppThis(), type);
		}

		// Token: 0x0601031B RID: 66331
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLShaderProperty_IsTypeOf_21([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601031C RID: 66332 RVA: 0x00168CF0 File Offset: 0x00166EF0
		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLShaderProperty.vtkOpenGLShaderProperty_IsTypeOf_21(type);
		}

		// Token: 0x0601031D RID: 66333
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLShaderProperty_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601031E RID: 66334 RVA: 0x00168D0C File Offset: 0x00166F0C
		public new vtkOpenGLShaderProperty NewInstance()
		{
			vtkOpenGLShaderProperty result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLShaderProperty.vtkOpenGLShaderProperty_NewInstance_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLShaderProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601031F RID: 66335
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLShaderProperty_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010320 RID: 66336 RVA: 0x00168D68 File Offset: 0x00166F68
		public new static vtkOpenGLShaderProperty SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLShaderProperty vtkOpenGLShaderProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLShaderProperty.vtkOpenGLShaderProperty_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLShaderProperty = (vtkOpenGLShaderProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLShaderProperty.Register(null);
				}
			}
			return vtkOpenGLShaderProperty;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012D2 RID: 4818
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLShaderProperty";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012D3 RID: 4819
		public new static readonly string MRClassNameKey = "class vtkOpenGLShaderProperty";
	}
}
