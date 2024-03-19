using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRIBProperty
	/// </summary>
	/// <remarks>
	///    RIP Property
	///
	/// vtkRIBProperty is a subclass of vtkProperty that allows the user to
	/// specify named shaders for use with RenderMan. Both surface
	/// and displacement shaders can be specified. Parameters
	/// for the shaders can be declared and set.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRIBExporter vtkRIBLight
	/// </seealso>
	// Token: 0x020001F2 RID: 498
	public class vtkRIBProperty : vtkProperty
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600600C RID: 24588 RVA: 0x0008A5E4 File Offset: 0x000887E4
		static vtkRIBProperty()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRIBProperty.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRIBProperty"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600600D RID: 24589 RVA: 0x0008A60C File Offset: 0x0008880C
		public vtkRIBProperty(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600600E RID: 24590
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRIBProperty_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600600F RID: 24591 RVA: 0x0008A61C File Offset: 0x0008881C
		public new static vtkRIBProperty New()
		{
			vtkRIBProperty result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRIBProperty.vtkRIBProperty_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRIBProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006010 RID: 24592 RVA: 0x0008A670 File Offset: 0x00088870
		public vtkRIBProperty() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRIBProperty.vtkRIBProperty_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006011 RID: 24593 RVA: 0x0008A6B4 File Offset: 0x000888B4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006012 RID: 24594
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRIBProperty_AddDisplacementShaderParameter_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string parameter, [MarshalAs(UnmanagedType.LPUTF8Str)] string value);

		/// <summary>
		/// Specify parameter values for displacement shader parameters
		/// </summary>
		// Token: 0x06006013 RID: 24595 RVA: 0x0008A6BF File Offset: 0x000888BF
		public void AddDisplacementShaderParameter(string parameter, string value)
		{
			vtkRIBProperty.vtkRIBProperty_AddDisplacementShaderParameter_01(base.GetCppThis(), parameter, value);
		}

		// Token: 0x06006014 RID: 24596
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRIBProperty_AddParameter_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string parameter, [MarshalAs(UnmanagedType.LPUTF8Str)] string value);

		/// <summary>
		/// Specify parameter values for variables.
		/// DEPRECATED: use (Set/Add)SurfaceShaderParameter instead.
		/// </summary>
		// Token: 0x06006015 RID: 24597 RVA: 0x0008A6D0 File Offset: 0x000888D0
		public void AddParameter(string parameter, string value)
		{
			vtkRIBProperty.vtkRIBProperty_AddParameter_02(base.GetCppThis(), parameter, value);
		}

		// Token: 0x06006016 RID: 24598
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRIBProperty_AddSurfaceShaderParameter_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string parameter, [MarshalAs(UnmanagedType.LPUTF8Str)] string value);

		/// <summary>
		/// Specify parameter values for surface shader parameters
		/// </summary>
		// Token: 0x06006017 RID: 24599 RVA: 0x0008A6E1 File Offset: 0x000888E1
		public void AddSurfaceShaderParameter(string parameter, string value)
		{
			vtkRIBProperty.vtkRIBProperty_AddSurfaceShaderParameter_03(base.GetCppThis(), parameter, value);
		}

		// Token: 0x06006018 RID: 24600
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRIBProperty_AddVariable_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string variable, [MarshalAs(UnmanagedType.LPUTF8Str)] string declaration);

		/// <summary>
		/// Specify declarations for variables.
		/// </summary>
		// Token: 0x06006019 RID: 24601 RVA: 0x0008A6F2 File Offset: 0x000888F2
		public void AddVariable(string variable, string declaration)
		{
			vtkRIBProperty.vtkRIBProperty_AddVariable_04(base.GetCppThis(), variable, declaration);
		}

		// Token: 0x0600601A RID: 24602
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRIBProperty_GetDeclarations_05(HandleRef pThis);

		/// <summary>
		/// Get variable declarations
		/// </summary>
		// Token: 0x0600601B RID: 24603 RVA: 0x0008A704 File Offset: 0x00088904
		public string GetDeclarations()
		{
			string s = Marshal.PtrToStringAnsi(vtkRIBProperty.vtkRIBProperty_GetDeclarations_05(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600601C RID: 24604
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRIBProperty_GetDisplacementShader_06(HandleRef pThis);

		/// <summary>
		/// Specify the name of a displacement shader.
		/// </summary>
		// Token: 0x0600601D RID: 24605 RVA: 0x0008A740 File Offset: 0x00088940
		public virtual string GetDisplacementShader()
		{
			string s = Marshal.PtrToStringAnsi(vtkRIBProperty.vtkRIBProperty_GetDisplacementShader_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600601E RID: 24606
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRIBProperty_GetDisplacementShaderParameters_07(HandleRef pThis);

		/// <summary>
		/// Get parameters.
		/// </summary>
		// Token: 0x0600601F RID: 24607 RVA: 0x0008A77C File Offset: 0x0008897C
		public string GetDisplacementShaderParameters()
		{
			string s = Marshal.PtrToStringAnsi(vtkRIBProperty.vtkRIBProperty_GetDisplacementShaderParameters_07(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06006020 RID: 24608
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRIBProperty_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006021 RID: 24609 RVA: 0x0008A7B8 File Offset: 0x000889B8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRIBProperty.vtkRIBProperty_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x06006022 RID: 24610
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRIBProperty_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006023 RID: 24611 RVA: 0x0008A7D8 File Offset: 0x000889D8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRIBProperty.vtkRIBProperty_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x06006024 RID: 24612
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRIBProperty_GetParameters_10(HandleRef pThis);

		/// <summary>
		/// Get parameters.
		/// </summary>
		// Token: 0x06006025 RID: 24613 RVA: 0x0008A7F4 File Offset: 0x000889F4
		public string GetParameters()
		{
			string s = Marshal.PtrToStringAnsi(vtkRIBProperty.vtkRIBProperty_GetParameters_10(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06006026 RID: 24614
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRIBProperty_GetSurfaceShader_11(HandleRef pThis);

		/// <summary>
		/// Specify the name of a surface shader.
		/// </summary>
		// Token: 0x06006027 RID: 24615 RVA: 0x0008A830 File Offset: 0x00088A30
		public virtual string GetSurfaceShader()
		{
			string s = Marshal.PtrToStringAnsi(vtkRIBProperty.vtkRIBProperty_GetSurfaceShader_11(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06006028 RID: 24616
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRIBProperty_GetSurfaceShaderParameters_12(HandleRef pThis);

		/// <summary>
		/// Get parameters.
		/// </summary>
		// Token: 0x06006029 RID: 24617 RVA: 0x0008A86C File Offset: 0x00088A6C
		public string GetSurfaceShaderParameters()
		{
			string s = Marshal.PtrToStringAnsi(vtkRIBProperty.vtkRIBProperty_GetSurfaceShaderParameters_12(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600602A RID: 24618
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRIBProperty_GetSurfaceShaderUsesDefaultParameters_13(HandleRef pThis);

		/// <summary>
		/// If true (default) the surface shader uses the usual shader parameters:
		/// Ka - Ambient amount
		/// Kd - Diffuse amount
		/// Ks - Specular amount
		/// Roughness
		/// SpecularColor
		/// Additional surface shader parameters can be added with the
		/// Set/AddSurfaceShaderParameter methods.
		/// If false, all surface shader parameters must be specified
		/// </summary>
		// Token: 0x0600602B RID: 24619 RVA: 0x0008A8A8 File Offset: 0x00088AA8
		public virtual bool GetSurfaceShaderUsesDefaultParameters()
		{
			return vtkRIBProperty.vtkRIBProperty_GetSurfaceShaderUsesDefaultParameters_13(base.GetCppThis()) != 0;
		}

		// Token: 0x0600602C RID: 24620
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRIBProperty_IsA_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600602D RID: 24621 RVA: 0x0008A8D0 File Offset: 0x00088AD0
		public override int IsA(string type)
		{
			return vtkRIBProperty.vtkRIBProperty_IsA_14(base.GetCppThis(), type);
		}

		// Token: 0x0600602E RID: 24622
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRIBProperty_IsTypeOf_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600602F RID: 24623 RVA: 0x0008A8F0 File Offset: 0x00088AF0
		public new static int IsTypeOf(string type)
		{
			return vtkRIBProperty.vtkRIBProperty_IsTypeOf_15(type);
		}

		// Token: 0x06006030 RID: 24624
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRIBProperty_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006031 RID: 24625 RVA: 0x0008A90C File Offset: 0x00088B0C
		public new vtkRIBProperty NewInstance()
		{
			vtkRIBProperty result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRIBProperty.vtkRIBProperty_NewInstance_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRIBProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006032 RID: 24626
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRIBProperty_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006033 RID: 24627 RVA: 0x0008A968 File Offset: 0x00088B68
		public new static vtkRIBProperty SafeDownCast(vtkObjectBase o)
		{
			vtkRIBProperty vtkRIBProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRIBProperty.vtkRIBProperty_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRIBProperty = (vtkRIBProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRIBProperty.Register(null);
				}
			}
			return vtkRIBProperty;
		}

		// Token: 0x06006034 RID: 24628
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRIBProperty_SetDisplacementShader_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify the name of a displacement shader.
		/// </summary>
		// Token: 0x06006035 RID: 24629 RVA: 0x0008A9E7 File Offset: 0x00088BE7
		public virtual void SetDisplacementShader(string _arg)
		{
			vtkRIBProperty.vtkRIBProperty_SetDisplacementShader_19(base.GetCppThis(), _arg);
		}

		// Token: 0x06006036 RID: 24630
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRIBProperty_SetDisplacementShaderParameter_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string parameter, [MarshalAs(UnmanagedType.LPUTF8Str)] string value);

		/// <summary>
		/// Specify parameter values for displacement shader parameters
		/// </summary>
		// Token: 0x06006037 RID: 24631 RVA: 0x0008A9F7 File Offset: 0x00088BF7
		public void SetDisplacementShaderParameter(string parameter, string value)
		{
			vtkRIBProperty.vtkRIBProperty_SetDisplacementShaderParameter_20(base.GetCppThis(), parameter, value);
		}

		// Token: 0x06006038 RID: 24632
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRIBProperty_SetParameter_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string parameter, [MarshalAs(UnmanagedType.LPUTF8Str)] string value);

		/// <summary>
		/// Specify parameter values for variables.
		/// DEPRECATED: use (Set/Add)SurfaceShaderParameter instead.
		/// </summary>
		// Token: 0x06006039 RID: 24633 RVA: 0x0008AA08 File Offset: 0x00088C08
		public void SetParameter(string parameter, string value)
		{
			vtkRIBProperty.vtkRIBProperty_SetParameter_21(base.GetCppThis(), parameter, value);
		}

		// Token: 0x0600603A RID: 24634
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRIBProperty_SetSurfaceShader_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify the name of a surface shader.
		/// </summary>
		// Token: 0x0600603B RID: 24635 RVA: 0x0008AA19 File Offset: 0x00088C19
		public virtual void SetSurfaceShader(string _arg)
		{
			vtkRIBProperty.vtkRIBProperty_SetSurfaceShader_22(base.GetCppThis(), _arg);
		}

		// Token: 0x0600603C RID: 24636
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRIBProperty_SetSurfaceShaderParameter_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string parameter, [MarshalAs(UnmanagedType.LPUTF8Str)] string value);

		/// <summary>
		/// Specify parameter values for surface shader parameters
		/// </summary>
		// Token: 0x0600603D RID: 24637 RVA: 0x0008AA29 File Offset: 0x00088C29
		public void SetSurfaceShaderParameter(string parameter, string value)
		{
			vtkRIBProperty.vtkRIBProperty_SetSurfaceShaderParameter_23(base.GetCppThis(), parameter, value);
		}

		// Token: 0x0600603E RID: 24638
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRIBProperty_SetSurfaceShaderUsesDefaultParameters_24(HandleRef pThis, byte _arg);

		/// <summary>
		/// If true (default) the surface shader uses the usual shader parameters:
		/// Ka - Ambient amount
		/// Kd - Diffuse amount
		/// Ks - Specular amount
		/// Roughness
		/// SpecularColor
		/// Additional surface shader parameters can be added with the
		/// Set/AddSurfaceShaderParameter methods.
		/// If false, all surface shader parameters must be specified
		/// </summary>
		// Token: 0x0600603F RID: 24639 RVA: 0x0008AA3A File Offset: 0x00088C3A
		public virtual void SetSurfaceShaderUsesDefaultParameters(bool _arg)
		{
			vtkRIBProperty.vtkRIBProperty_SetSurfaceShaderUsesDefaultParameters_24(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06006040 RID: 24640
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRIBProperty_SetVariable_25(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string variable, [MarshalAs(UnmanagedType.LPUTF8Str)] string declaration);

		/// <summary>
		/// Specify declarations for variables.
		/// </summary>
		// Token: 0x06006041 RID: 24641 RVA: 0x0008AA52 File Offset: 0x00088C52
		public void SetVariable(string variable, string declaration)
		{
			vtkRIBProperty.vtkRIBProperty_SetVariable_25(base.GetCppThis(), variable, declaration);
		}

		// Token: 0x06006042 RID: 24642
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRIBProperty_SurfaceShaderUsesDefaultParametersOff_26(HandleRef pThis);

		/// <summary>
		/// If true (default) the surface shader uses the usual shader parameters:
		/// Ka - Ambient amount
		/// Kd - Diffuse amount
		/// Ks - Specular amount
		/// Roughness
		/// SpecularColor
		/// Additional surface shader parameters can be added with the
		/// Set/AddSurfaceShaderParameter methods.
		/// If false, all surface shader parameters must be specified
		/// </summary>
		// Token: 0x06006043 RID: 24643 RVA: 0x0008AA63 File Offset: 0x00088C63
		public virtual void SurfaceShaderUsesDefaultParametersOff()
		{
			vtkRIBProperty.vtkRIBProperty_SurfaceShaderUsesDefaultParametersOff_26(base.GetCppThis());
		}

		// Token: 0x06006044 RID: 24644
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRIBProperty_SurfaceShaderUsesDefaultParametersOn_27(HandleRef pThis);

		/// <summary>
		/// If true (default) the surface shader uses the usual shader parameters:
		/// Ka - Ambient amount
		/// Kd - Diffuse amount
		/// Ks - Specular amount
		/// Roughness
		/// SpecularColor
		/// Additional surface shader parameters can be added with the
		/// Set/AddSurfaceShaderParameter methods.
		/// If false, all surface shader parameters must be specified
		/// </summary>
		// Token: 0x06006045 RID: 24645 RVA: 0x0008AA72 File Offset: 0x00088C72
		public virtual void SurfaceShaderUsesDefaultParametersOn()
		{
			vtkRIBProperty.vtkRIBProperty_SurfaceShaderUsesDefaultParametersOn_27(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008AE RID: 2222
		public new const string MRFullTypeName = "Kitware.VTK.vtkRIBProperty";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008AF RID: 2223
		public new static readonly string MRClassNameKey = "class vtkRIBProperty";
	}
}
