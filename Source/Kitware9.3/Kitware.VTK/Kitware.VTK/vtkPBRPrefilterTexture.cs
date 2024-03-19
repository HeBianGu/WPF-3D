using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPBRPrefilterTexture
	/// </summary>
	/// <remarks>
	///    precompute prefilter texture used in physically based rendering
	///
	/// Prefilter texture is a cubemap result of integration of the input cubemap contribution in
	/// BRDF equation. The result depends on roughness coefficient so several levels of mipmap are
	/// used to store results of different roughness coefficients.
	/// It is used in Image Base Lighting to compute the specular part.
	/// </remarks>
	// Token: 0x020005DF RID: 1503
	public class vtkPBRPrefilterTexture : vtkOpenGLTexture
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06010649 RID: 67145 RVA: 0x0016D91B File Offset: 0x0016BB1B
		static vtkPBRPrefilterTexture()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPBRPrefilterTexture.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPBRPrefilterTexture"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601064A RID: 67146 RVA: 0x0016D943 File Offset: 0x0016BB43
		public vtkPBRPrefilterTexture(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601064B RID: 67147
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPBRPrefilterTexture_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601064C RID: 67148 RVA: 0x0016D954 File Offset: 0x0016BB54
		public new static vtkPBRPrefilterTexture New()
		{
			vtkPBRPrefilterTexture result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPBRPrefilterTexture.vtkPBRPrefilterTexture_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPBRPrefilterTexture)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601064D RID: 67149 RVA: 0x0016D9A8 File Offset: 0x0016BBA8
		public vtkPBRPrefilterTexture() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPBRPrefilterTexture.vtkPBRPrefilterTexture_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601064E RID: 67150 RVA: 0x0016D9EC File Offset: 0x0016BBEC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601064F RID: 67151
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPBRPrefilterTexture_ConvertToLinearOff_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the conversion to linear color space.
		/// If the input texture is in sRGB color space and the conversion is not done by OpenGL
		/// directly with the texture format, the conversion can be done in the shader with this flag.
		/// </summary>
		// Token: 0x06010650 RID: 67152 RVA: 0x0016D9F7 File Offset: 0x0016BBF7
		public virtual void ConvertToLinearOff()
		{
			vtkPBRPrefilterTexture.vtkPBRPrefilterTexture_ConvertToLinearOff_01(base.GetCppThis());
		}

		// Token: 0x06010651 RID: 67153
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPBRPrefilterTexture_ConvertToLinearOn_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the conversion to linear color space.
		/// If the input texture is in sRGB color space and the conversion is not done by OpenGL
		/// directly with the texture format, the conversion can be done in the shader with this flag.
		/// </summary>
		// Token: 0x06010652 RID: 67154 RVA: 0x0016DA06 File Offset: 0x0016BC06
		public virtual void ConvertToLinearOn()
		{
			vtkPBRPrefilterTexture.vtkPBRPrefilterTexture_ConvertToLinearOn_02(base.GetCppThis());
		}

		// Token: 0x06010653 RID: 67155
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPBRPrefilterTexture_GetConvertToLinear_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the conversion to linear color space.
		/// If the input texture is in sRGB color space and the conversion is not done by OpenGL
		/// directly with the texture format, the conversion can be done in the shader with this flag.
		/// </summary>
		// Token: 0x06010654 RID: 67156 RVA: 0x0016DA18 File Offset: 0x0016BC18
		public virtual bool GetConvertToLinear()
		{
			return vtkPBRPrefilterTexture.vtkPBRPrefilterTexture_GetConvertToLinear_03(base.GetCppThis()) != 0;
		}

		// Token: 0x06010655 RID: 67157
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPBRPrefilterTexture_GetHalfPrecision_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the precision of the texture.
		/// If HalfPrecision is enabled, each channel uses 16-bits values instead of 32-bits floating point
		/// values.
		/// Default is true.
		/// </summary>
		// Token: 0x06010656 RID: 67158 RVA: 0x0016DA40 File Offset: 0x0016BC40
		public virtual bool GetHalfPrecision()
		{
			return vtkPBRPrefilterTexture.vtkPBRPrefilterTexture_GetHalfPrecision_04(base.GetCppThis()) != 0;
		}

		// Token: 0x06010657 RID: 67159
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPBRPrefilterTexture_GetInputTexture_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the input texture.
		/// </summary>
		// Token: 0x06010658 RID: 67160 RVA: 0x0016DA68 File Offset: 0x0016BC68
		public virtual vtkOpenGLTexture GetInputTexture()
		{
			vtkOpenGLTexture vtkOpenGLTexture = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPBRPrefilterTexture.vtkPBRPrefilterTexture_GetInputTexture_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLTexture = (vtkOpenGLTexture)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLTexture.Register(null);
				}
			}
			return vtkOpenGLTexture;
		}

		// Token: 0x06010659 RID: 67161
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPBRPrefilterTexture_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601065A RID: 67162 RVA: 0x0016DAD8 File Offset: 0x0016BCD8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPBRPrefilterTexture.vtkPBRPrefilterTexture_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0601065B RID: 67163
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPBRPrefilterTexture_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601065C RID: 67164 RVA: 0x0016DAF8 File Offset: 0x0016BCF8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPBRPrefilterTexture.vtkPBRPrefilterTexture_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0601065D RID: 67165
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkPBRPrefilterTexture_GetPrefilterLevels_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of mip-map levels.
		/// Default is 5.
		/// </summary>
		// Token: 0x0601065E RID: 67166 RVA: 0x0016DB14 File Offset: 0x0016BD14
		public virtual uint GetPrefilterLevels()
		{
			return vtkPBRPrefilterTexture.vtkPBRPrefilterTexture_GetPrefilterLevels_08(base.GetCppThis());
		}

		// Token: 0x0601065F RID: 67167
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkPBRPrefilterTexture_GetPrefilterMaxSamples_09(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum number of samples.
		/// The number of samples for each roughness is between 1
		/// at roughness = 0 and PrefilterMaxSamples at roughness = 1
		/// Default is 512.
		/// </summary>
		// Token: 0x06010660 RID: 67168 RVA: 0x0016DB34 File Offset: 0x0016BD34
		public virtual uint GetPrefilterMaxSamples()
		{
			return vtkPBRPrefilterTexture.vtkPBRPrefilterTexture_GetPrefilterMaxSamples_09(base.GetCppThis());
		}

		// Token: 0x06010661 RID: 67169
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkPBRPrefilterTexture_GetPrefilterSize_10(HandleRef pThis);

		/// <summary>
		/// Get size of texture (input texture height).
		/// </summary>
		// Token: 0x06010662 RID: 67170 RVA: 0x0016DB54 File Offset: 0x0016BD54
		public virtual uint GetPrefilterSize()
		{
			return vtkPBRPrefilterTexture.vtkPBRPrefilterTexture_GetPrefilterSize_10(base.GetCppThis());
		}

		// Token: 0x06010663 RID: 67171
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPBRPrefilterTexture_HalfPrecisionOff_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the precision of the texture.
		/// If HalfPrecision is enabled, each channel uses 16-bits values instead of 32-bits floating point
		/// values.
		/// Default is true.
		/// </summary>
		// Token: 0x06010664 RID: 67172 RVA: 0x0016DB73 File Offset: 0x0016BD73
		public virtual void HalfPrecisionOff()
		{
			vtkPBRPrefilterTexture.vtkPBRPrefilterTexture_HalfPrecisionOff_11(base.GetCppThis());
		}

		// Token: 0x06010665 RID: 67173
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPBRPrefilterTexture_HalfPrecisionOn_12(HandleRef pThis);

		/// <summary>
		/// Set/Get the precision of the texture.
		/// If HalfPrecision is enabled, each channel uses 16-bits values instead of 32-bits floating point
		/// values.
		/// Default is true.
		/// </summary>
		// Token: 0x06010666 RID: 67174 RVA: 0x0016DB82 File Offset: 0x0016BD82
		public virtual void HalfPrecisionOn()
		{
			vtkPBRPrefilterTexture.vtkPBRPrefilterTexture_HalfPrecisionOn_12(base.GetCppThis());
		}

		// Token: 0x06010667 RID: 67175
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPBRPrefilterTexture_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010668 RID: 67176 RVA: 0x0016DB94 File Offset: 0x0016BD94
		public override int IsA(string type)
		{
			return vtkPBRPrefilterTexture.vtkPBRPrefilterTexture_IsA_13(base.GetCppThis(), type);
		}

		// Token: 0x06010669 RID: 67177
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPBRPrefilterTexture_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601066A RID: 67178 RVA: 0x0016DBB4 File Offset: 0x0016BDB4
		public new static int IsTypeOf(string type)
		{
			return vtkPBRPrefilterTexture.vtkPBRPrefilterTexture_IsTypeOf_14(type);
		}

		// Token: 0x0601066B RID: 67179
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPBRPrefilterTexture_Load_15(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Implement base class method.
		/// </summary>
		// Token: 0x0601066C RID: 67180 RVA: 0x0016DBD0 File Offset: 0x0016BDD0
		public override void Load(vtkRenderer arg0)
		{
			vtkPBRPrefilterTexture.vtkPBRPrefilterTexture_Load_15(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601066D RID: 67181
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPBRPrefilterTexture_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601066E RID: 67182 RVA: 0x0016DC00 File Offset: 0x0016BE00
		public new vtkPBRPrefilterTexture NewInstance()
		{
			vtkPBRPrefilterTexture result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPBRPrefilterTexture.vtkPBRPrefilterTexture_NewInstance_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPBRPrefilterTexture)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601066F RID: 67183
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPBRPrefilterTexture_ReleaseGraphicsResources_18(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Release any graphics resources that are being consumed by this texture.
		/// The parameter window could be used to determine which graphic
		/// resources to release. Using the same texture object in multiple
		/// render windows is NOT currently supported.
		/// </summary>
		// Token: 0x06010670 RID: 67184 RVA: 0x0016DC5C File Offset: 0x0016BE5C
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkPBRPrefilterTexture.vtkPBRPrefilterTexture_ReleaseGraphicsResources_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06010671 RID: 67185
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPBRPrefilterTexture_Render_19(HandleRef pThis, HandleRef ren);

		/// <summary>
		/// Implement base class method.
		/// </summary>
		// Token: 0x06010672 RID: 67186 RVA: 0x0016DC8C File Offset: 0x0016BE8C
		public override void Render(vtkRenderer ren)
		{
			vtkPBRPrefilterTexture.vtkPBRPrefilterTexture_Render_19(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		// Token: 0x06010673 RID: 67187
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPBRPrefilterTexture_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010674 RID: 67188 RVA: 0x0016DCBC File Offset: 0x0016BEBC
		public new static vtkPBRPrefilterTexture SafeDownCast(vtkObjectBase o)
		{
			vtkPBRPrefilterTexture vtkPBRPrefilterTexture = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPBRPrefilterTexture.vtkPBRPrefilterTexture_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPBRPrefilterTexture = (vtkPBRPrefilterTexture)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPBRPrefilterTexture.Register(null);
				}
			}
			return vtkPBRPrefilterTexture;
		}

		// Token: 0x06010675 RID: 67189
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPBRPrefilterTexture_SetConvertToLinear_21(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get the conversion to linear color space.
		/// If the input texture is in sRGB color space and the conversion is not done by OpenGL
		/// directly with the texture format, the conversion can be done in the shader with this flag.
		/// </summary>
		// Token: 0x06010676 RID: 67190 RVA: 0x0016DD3B File Offset: 0x0016BF3B
		public virtual void SetConvertToLinear(bool _arg)
		{
			vtkPBRPrefilterTexture.vtkPBRPrefilterTexture_SetConvertToLinear_21(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06010677 RID: 67191
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPBRPrefilterTexture_SetHalfPrecision_22(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get the precision of the texture.
		/// If HalfPrecision is enabled, each channel uses 16-bits values instead of 32-bits floating point
		/// values.
		/// Default is true.
		/// </summary>
		// Token: 0x06010678 RID: 67192 RVA: 0x0016DD53 File Offset: 0x0016BF53
		public virtual void SetHalfPrecision(bool _arg)
		{
			vtkPBRPrefilterTexture.vtkPBRPrefilterTexture_SetHalfPrecision_22(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06010679 RID: 67193
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPBRPrefilterTexture_SetInputTexture_23(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get/Set the input texture.
		/// </summary>
		// Token: 0x0601067A RID: 67194 RVA: 0x0016DD6C File Offset: 0x0016BF6C
		public void SetInputTexture(vtkOpenGLTexture arg0)
		{
			vtkPBRPrefilterTexture.vtkPBRPrefilterTexture_SetInputTexture_23(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601067B RID: 67195
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPBRPrefilterTexture_SetPrefilterLevels_24(HandleRef pThis, uint _arg);

		/// <summary>
		/// Set/Get the number of mip-map levels.
		/// Default is 5.
		/// </summary>
		// Token: 0x0601067C RID: 67196 RVA: 0x0016DD9B File Offset: 0x0016BF9B
		public virtual void SetPrefilterLevels(uint _arg)
		{
			vtkPBRPrefilterTexture.vtkPBRPrefilterTexture_SetPrefilterLevels_24(base.GetCppThis(), _arg);
		}

		// Token: 0x0601067D RID: 67197
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPBRPrefilterTexture_SetPrefilterMaxSamples_25(HandleRef pThis, uint _arg);

		/// <summary>
		/// Set/Get the maximum number of samples.
		/// The number of samples for each roughness is between 1
		/// at roughness = 0 and PrefilterMaxSamples at roughness = 1
		/// Default is 512.
		/// </summary>
		// Token: 0x0601067E RID: 67198 RVA: 0x0016DDAB File Offset: 0x0016BFAB
		public virtual void SetPrefilterMaxSamples(uint _arg)
		{
			vtkPBRPrefilterTexture.vtkPBRPrefilterTexture_SetPrefilterMaxSamples_25(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001309 RID: 4873
		public new const string MRFullTypeName = "Kitware.VTK.vtkPBRPrefilterTexture";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400130A RID: 4874
		public new static readonly string MRClassNameKey = "class vtkPBRPrefilterTexture";
	}
}
