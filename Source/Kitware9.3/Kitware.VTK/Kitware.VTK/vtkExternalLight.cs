using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExternalLight
	/// </summary>
	/// <remarks>
	///    a virtual light object for tweaking existing lights
	/// in an external 3D rendering context
	///
	///
	/// vtkExternalLight is a virtual light object for tweaking existing lights in
	/// an external 3D rendering context. It provides a mechanism to adjust and
	/// control parameters of existing lights in an external OpenGL context.
	///
	/// It provides methods to locate and point the light,
	/// and set its brightness and color. In addition to the
	/// basic infinite distance point light source attributes, you can also specify
	/// the light attenuation values and cone angle. These attributes are only used
	/// if the light is a positional light.
	///
	/// By default, vtkExternalLight overrides specific light parameters as set by
	/// the user. Setting the #ReplaceMode to ALL_PARAMS, will set all
	/// the light parameter values to the ones set in vtkExternalLight.
	///
	/// @warning
	/// Use the vtkExternalLight object to tweak parameters of lights created in the
	/// external context. This class does NOT create new lights in the scene.
	///
	/// @par Example:
	/// Usage example for vtkExternalLight in conjunction with
	/// vtkExternalOpenGLRenderer and \ref ExternalVTKWidget
	/// <code>{.cpp}
	///    vtkNew&lt;vtkExternalLight&gt; exLight;
	///    exLight-&gt;SetLightIndex(GL_LIGHT0); // GL_LIGHT0 identifies the external light
	///    exLight-&gt;SetDiffuseColor(1.0, 0.0, 0.0); // Changing diffuse color
	///    vtkNew&lt;ExternalVTKWidget&gt; exWidget;
	///    vtkExternalOpenGLRenderer* ren =
	/// vtkExternalOpenGLRenderer::SafeDownCast(exWidget-&gt;AddRenderer());
	///    ren-&gt;AddExternalLight(exLight.GetPointer());
	/// </code>
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkExternalOpenGLRenderer \ref ExternalVTKWidget
	/// </seealso>
	// Token: 0x02000118 RID: 280
	public class vtkExternalLight : vtkLight
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003971 RID: 14705 RVA: 0x00053D03 File Offset: 0x00051F03
		static vtkExternalLight()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExternalLight.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExternalLight"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003972 RID: 14706 RVA: 0x00053D2B File Offset: 0x00051F2B
		public vtkExternalLight(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06003973 RID: 14707
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExternalLight_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create an external light object with the focal point at the origin and its
		/// position set to (0,0,1). The light is a Headlight, its color is white
		/// (black ambient, white diffuse, white specular),
		/// intensity=1, the light is turned on, positional lighting is off,
		/// ConeAngle=30, AttenuationValues=(1,0,0), Exponent=1 and the
		/// TransformMatrix is NULL. The light index is GL_LIGHT0, which means the
		/// existing light with index GL_LIGHT0 will be affected by this light.
		/// </summary>
		// Token: 0x06003974 RID: 14708 RVA: 0x00053D3C File Offset: 0x00051F3C
		public new static vtkExternalLight New()
		{
			vtkExternalLight result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExternalLight.vtkExternalLight_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExternalLight)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Create an external light object with the focal point at the origin and its
		/// position set to (0,0,1). The light is a Headlight, its color is white
		/// (black ambient, white diffuse, white specular),
		/// intensity=1, the light is turned on, positional lighting is off,
		/// ConeAngle=30, AttenuationValues=(1,0,0), Exponent=1 and the
		/// TransformMatrix is NULL. The light index is GL_LIGHT0, which means the
		/// existing light with index GL_LIGHT0 will be affected by this light.
		/// </summary>
		// Token: 0x06003975 RID: 14709 RVA: 0x00053D90 File Offset: 0x00051F90
		public vtkExternalLight() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExternalLight.vtkExternalLight_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003976 RID: 14710 RVA: 0x00053DD4 File Offset: 0x00051FD4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003977 RID: 14711
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExternalLight_GetAmbientColorSet_01(HandleRef pThis);

		/// <summary>
		/// Check whether value set by user
		/// </summary>
		// Token: 0x06003978 RID: 14712 RVA: 0x00053DE0 File Offset: 0x00051FE0
		public virtual bool GetAmbientColorSet()
		{
			return vtkExternalLight.vtkExternalLight_GetAmbientColorSet_01(base.GetCppThis()) != 0;
		}

		// Token: 0x06003979 RID: 14713
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExternalLight_GetAttenuationValuesSet_02(HandleRef pThis);

		/// <summary>
		/// Check whether value set by user
		/// </summary>
		// Token: 0x0600397A RID: 14714 RVA: 0x00053E08 File Offset: 0x00052008
		public virtual bool GetAttenuationValuesSet()
		{
			return vtkExternalLight.vtkExternalLight_GetAttenuationValuesSet_02(base.GetCppThis()) != 0;
		}

		// Token: 0x0600397B RID: 14715
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExternalLight_GetConeAngleSet_03(HandleRef pThis);

		/// <summary>
		/// Check whether value set by user
		/// </summary>
		// Token: 0x0600397C RID: 14716 RVA: 0x00053E30 File Offset: 0x00052030
		public virtual bool GetConeAngleSet()
		{
			return vtkExternalLight.vtkExternalLight_GetConeAngleSet_03(base.GetCppThis()) != 0;
		}

		// Token: 0x0600397D RID: 14717
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExternalLight_GetDiffuseColorSet_04(HandleRef pThis);

		/// <summary>
		/// Check whether value set by user
		/// </summary>
		// Token: 0x0600397E RID: 14718 RVA: 0x00053E58 File Offset: 0x00052058
		public virtual bool GetDiffuseColorSet()
		{
			return vtkExternalLight.vtkExternalLight_GetDiffuseColorSet_04(base.GetCppThis()) != 0;
		}

		// Token: 0x0600397F RID: 14719
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExternalLight_GetExponentSet_05(HandleRef pThis);

		/// <summary>
		/// Check whether value set by user
		/// </summary>
		// Token: 0x06003980 RID: 14720 RVA: 0x00053E80 File Offset: 0x00052080
		public virtual bool GetExponentSet()
		{
			return vtkExternalLight.vtkExternalLight_GetExponentSet_05(base.GetCppThis()) != 0;
		}

		// Token: 0x06003981 RID: 14721
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExternalLight_GetFocalPointSet_06(HandleRef pThis);

		/// <summary>
		/// Check whether value set by user
		/// </summary>
		// Token: 0x06003982 RID: 14722 RVA: 0x00053EA8 File Offset: 0x000520A8
		public virtual bool GetFocalPointSet()
		{
			return vtkExternalLight.vtkExternalLight_GetFocalPointSet_06(base.GetCppThis()) != 0;
		}

		// Token: 0x06003983 RID: 14723
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExternalLight_GetIntensitySet_07(HandleRef pThis);

		/// <summary>
		/// Check whether value set by user
		/// </summary>
		// Token: 0x06003984 RID: 14724 RVA: 0x00053ED0 File Offset: 0x000520D0
		public virtual bool GetIntensitySet()
		{
			return vtkExternalLight.vtkExternalLight_GetIntensitySet_07(base.GetCppThis()) != 0;
		}

		// Token: 0x06003985 RID: 14725
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExternalLight_GetLightIndex_08(HandleRef pThis);

		/// <summary>
		/// Set/Get light index
		/// This should be the OpenGL light identifier. (e.g.: GL_LIGHT0)
		/// (Default: GL_LIGHT0)
		/// </summary>
		// Token: 0x06003986 RID: 14726 RVA: 0x00053EF8 File Offset: 0x000520F8
		public virtual int GetLightIndex()
		{
			return vtkExternalLight.vtkExternalLight_GetLightIndex_08(base.GetCppThis());
		}

		// Token: 0x06003987 RID: 14727
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExternalLight_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003988 RID: 14728 RVA: 0x00053F18 File Offset: 0x00052118
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExternalLight.vtkExternalLight_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x06003989 RID: 14729
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExternalLight_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600398A RID: 14730 RVA: 0x00053F38 File Offset: 0x00052138
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExternalLight.vtkExternalLight_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x0600398B RID: 14731
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExternalLight_GetPositionSet_11(HandleRef pThis);

		/// <summary>
		/// Check whether value set by user
		/// </summary>
		// Token: 0x0600398C RID: 14732 RVA: 0x00053F54 File Offset: 0x00052154
		public virtual bool GetPositionSet()
		{
			return vtkExternalLight.vtkExternalLight_GetPositionSet_11(base.GetCppThis()) != 0;
		}

		// Token: 0x0600398D RID: 14733
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExternalLight_GetPositionalSet_12(HandleRef pThis);

		/// <summary>
		/// Check whether value set by user
		/// </summary>
		// Token: 0x0600398E RID: 14734 RVA: 0x00053F7C File Offset: 0x0005217C
		public virtual bool GetPositionalSet()
		{
			return vtkExternalLight.vtkExternalLight_GetPositionalSet_12(base.GetCppThis()) != 0;
		}

		// Token: 0x0600398F RID: 14735
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExternalLight_GetReplaceMode_13(HandleRef pThis);

		/// <summary>
		/// Set/Get replace mode
		/// This determines how this ExternalLight will be used to tweak parameters on
		/// an existing light in the rendering context.
		/// (Default: INDIVIDUAL_PARAMS)
		///
		/// \li \c vtkExternalLight::INDIVIDUAL_PARAMS : Replace parameters
		/// specifically set by the user by calling the parameter
		/// Set method. (e.g. SetDiffuseColor())
		///
		/// \li \c vtkExternalLight::ALL_PARAMS : Replace all
		/// parameters of the light with the parameters in vtkExternalLight object.
		/// </summary>
		// Token: 0x06003990 RID: 14736 RVA: 0x00053FA4 File Offset: 0x000521A4
		public virtual int GetReplaceMode()
		{
			return vtkExternalLight.vtkExternalLight_GetReplaceMode_13(base.GetCppThis());
		}

		// Token: 0x06003991 RID: 14737
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExternalLight_GetSpecularColorSet_14(HandleRef pThis);

		/// <summary>
		/// Check whether value set by user
		/// </summary>
		// Token: 0x06003992 RID: 14738 RVA: 0x00053FC4 File Offset: 0x000521C4
		public virtual bool GetSpecularColorSet()
		{
			return vtkExternalLight.vtkExternalLight_GetSpecularColorSet_14(base.GetCppThis()) != 0;
		}

		// Token: 0x06003993 RID: 14739
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExternalLight_IsA_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003994 RID: 14740 RVA: 0x00053FEC File Offset: 0x000521EC
		public override int IsA(string type)
		{
			return vtkExternalLight.vtkExternalLight_IsA_15(base.GetCppThis(), type);
		}

		// Token: 0x06003995 RID: 14741
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExternalLight_IsTypeOf_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003996 RID: 14742 RVA: 0x0005400C File Offset: 0x0005220C
		public new static int IsTypeOf(string type)
		{
			return vtkExternalLight.vtkExternalLight_IsTypeOf_16(type);
		}

		// Token: 0x06003997 RID: 14743
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExternalLight_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003998 RID: 14744 RVA: 0x00054028 File Offset: 0x00052228
		public new vtkExternalLight NewInstance()
		{
			vtkExternalLight result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExternalLight.vtkExternalLight_NewInstance_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExternalLight)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003999 RID: 14745
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExternalLight_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600399A RID: 14746 RVA: 0x00054084 File Offset: 0x00052284
		public new static vtkExternalLight SafeDownCast(vtkObjectBase o)
		{
			vtkExternalLight vtkExternalLight = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExternalLight.vtkExternalLight_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExternalLight = (vtkExternalLight)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExternalLight.Register(null);
				}
			}
			return vtkExternalLight;
		}

		// Token: 0x0600399B RID: 14747
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExternalLight_SetAmbientColor_20(HandleRef pThis, double arg0, double arg1, double arg2);

		/// <summary>
		/// Override Set method to keep a record of changed value
		/// </summary>
		// Token: 0x0600399C RID: 14748 RVA: 0x00054103 File Offset: 0x00052303
		public override void SetAmbientColor(double arg0, double arg1, double arg2)
		{
			vtkExternalLight.vtkExternalLight_SetAmbientColor_20(base.GetCppThis(), arg0, arg1, arg2);
		}

		// Token: 0x0600399D RID: 14749
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExternalLight_SetAttenuationValues_21(HandleRef pThis, double arg0, double arg1, double arg2);

		/// <summary>
		/// Override Set method to keep a record of changed value
		/// </summary>
		// Token: 0x0600399E RID: 14750 RVA: 0x00054115 File Offset: 0x00052315
		public override void SetAttenuationValues(double arg0, double arg1, double arg2)
		{
			vtkExternalLight.vtkExternalLight_SetAttenuationValues_21(base.GetCppThis(), arg0, arg1, arg2);
		}

		// Token: 0x0600399F RID: 14751
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExternalLight_SetConeAngle_22(HandleRef pThis, double arg0);

		/// <summary>
		/// Override Set method to keep a record of changed value
		/// </summary>
		// Token: 0x060039A0 RID: 14752 RVA: 0x00054127 File Offset: 0x00052327
		public override void SetConeAngle(double arg0)
		{
			vtkExternalLight.vtkExternalLight_SetConeAngle_22(base.GetCppThis(), arg0);
		}

		// Token: 0x060039A1 RID: 14753
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExternalLight_SetDiffuseColor_23(HandleRef pThis, double arg0, double arg1, double arg2);

		/// <summary>
		/// Override Set method to keep a record of changed value
		/// </summary>
		// Token: 0x060039A2 RID: 14754 RVA: 0x00054137 File Offset: 0x00052337
		public override void SetDiffuseColor(double arg0, double arg1, double arg2)
		{
			vtkExternalLight.vtkExternalLight_SetDiffuseColor_23(base.GetCppThis(), arg0, arg1, arg2);
		}

		// Token: 0x060039A3 RID: 14755
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExternalLight_SetExponent_24(HandleRef pThis, double arg0);

		/// <summary>
		/// Override Set method to keep a record of changed value
		/// </summary>
		// Token: 0x060039A4 RID: 14756 RVA: 0x00054149 File Offset: 0x00052349
		public override void SetExponent(double arg0)
		{
			vtkExternalLight.vtkExternalLight_SetExponent_24(base.GetCppThis(), arg0);
		}

		// Token: 0x060039A5 RID: 14757
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExternalLight_SetFocalPoint_25(HandleRef pThis, double arg0, double arg1, double arg2);

		/// <summary>
		/// Override Set method to keep a record of changed value
		/// </summary>
		// Token: 0x060039A6 RID: 14758 RVA: 0x00054159 File Offset: 0x00052359
		public override void SetFocalPoint(double arg0, double arg1, double arg2)
		{
			vtkExternalLight.vtkExternalLight_SetFocalPoint_25(base.GetCppThis(), arg0, arg1, arg2);
		}

		// Token: 0x060039A7 RID: 14759
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExternalLight_SetIntensity_26(HandleRef pThis, double arg0);

		/// <summary>
		/// Override Set method to keep a record of changed value
		/// </summary>
		// Token: 0x060039A8 RID: 14760 RVA: 0x0005416B File Offset: 0x0005236B
		public override void SetIntensity(double arg0)
		{
			vtkExternalLight.vtkExternalLight_SetIntensity_26(base.GetCppThis(), arg0);
		}

		// Token: 0x060039A9 RID: 14761
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExternalLight_SetLightIndex_27(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get light index
		/// This should be the OpenGL light identifier. (e.g.: GL_LIGHT0)
		/// (Default: GL_LIGHT0)
		/// </summary>
		// Token: 0x060039AA RID: 14762 RVA: 0x0005417B File Offset: 0x0005237B
		public virtual void SetLightIndex(int _arg)
		{
			vtkExternalLight.vtkExternalLight_SetLightIndex_27(base.GetCppThis(), _arg);
		}

		// Token: 0x060039AB RID: 14763
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExternalLight_SetPosition_28(HandleRef pThis, double arg0, double arg1, double arg2);

		/// <summary>
		/// Override Set method to keep a record of changed value
		/// </summary>
		// Token: 0x060039AC RID: 14764 RVA: 0x0005418B File Offset: 0x0005238B
		public override void SetPosition(double arg0, double arg1, double arg2)
		{
			vtkExternalLight.vtkExternalLight_SetPosition_28(base.GetCppThis(), arg0, arg1, arg2);
		}

		// Token: 0x060039AD RID: 14765
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExternalLight_SetPositional_29(HandleRef pThis, int arg0);

		/// <summary>
		/// Override Set method to keep a record of changed value
		/// </summary>
		// Token: 0x060039AE RID: 14766 RVA: 0x0005419D File Offset: 0x0005239D
		public override void SetPositional(int arg0)
		{
			vtkExternalLight.vtkExternalLight_SetPositional_29(base.GetCppThis(), arg0);
		}

		// Token: 0x060039AF RID: 14767
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExternalLight_SetReplaceMode_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get replace mode
		/// This determines how this ExternalLight will be used to tweak parameters on
		/// an existing light in the rendering context.
		/// (Default: INDIVIDUAL_PARAMS)
		///
		/// \li \c vtkExternalLight::INDIVIDUAL_PARAMS : Replace parameters
		/// specifically set by the user by calling the parameter
		/// Set method. (e.g. SetDiffuseColor())
		///
		/// \li \c vtkExternalLight::ALL_PARAMS : Replace all
		/// parameters of the light with the parameters in vtkExternalLight object.
		/// </summary>
		// Token: 0x060039B0 RID: 14768 RVA: 0x000541AD File Offset: 0x000523AD
		public virtual void SetReplaceMode(int _arg)
		{
			vtkExternalLight.vtkExternalLight_SetReplaceMode_30(base.GetCppThis(), _arg);
		}

		// Token: 0x060039B1 RID: 14769
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExternalLight_SetSpecularColor_31(HandleRef pThis, double arg0, double arg1, double arg2);

		/// <summary>
		/// Override Set method to keep a record of changed value
		/// </summary>
		// Token: 0x060039B2 RID: 14770 RVA: 0x000541BD File Offset: 0x000523BD
		public override void SetSpecularColor(double arg0, double arg1, double arg2)
		{
			vtkExternalLight.vtkExternalLight_SetSpecularColor_31(base.GetCppThis(), arg0, arg1, arg2);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000668 RID: 1640
		public new const string MRFullTypeName = "Kitware.VTK.vtkExternalLight";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000669 RID: 1641
		public new static readonly string MRClassNameKey = "class vtkExternalLight";

		/// <summary>
		/// Create an external light object with the focal point at the origin and its
		/// position set to (0,0,1). The light is a Headlight, its color is white
		/// (black ambient, white diffuse, white specular),
		/// intensity=1, the light is turned on, positional lighting is off,
		/// ConeAngle=30, AttenuationValues=(1,0,0), Exponent=1 and the
		/// TransformMatrix is NULL. The light index is GL_LIGHT0, which means the
		/// existing light with index GL_LIGHT0 will be affected by this light.
		/// </summary>
		// Token: 0x02000119 RID: 281
		public enum ReplaceModes
		{
			/// <summary>enum member</summary>
			// Token: 0x0400066B RID: 1643
			ALL_PARAMS = 1,
			/// <summary>enum member</summary>
			// Token: 0x0400066C RID: 1644
			INDIVIDUAL_PARAMS = 0
		}
	}
}
