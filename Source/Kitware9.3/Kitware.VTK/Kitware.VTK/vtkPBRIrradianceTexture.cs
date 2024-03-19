using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPBRIrradianceTexture
	/// </summary>
	/// <remarks>
	///    precompute irradiance texture used in physically based rendering
	///
	/// Irradiance texture is a cubemap which average light of a hemisphere of the input texture.
	/// The input texture can be a cubemap or an equirectangular projection.
	/// It is used in Image Base Lighting to compute the diffuse part.
	/// </remarks>
	// Token: 0x020005DD RID: 1501
	public class vtkPBRIrradianceTexture : vtkOpenGLTexture
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060105FF RID: 67071 RVA: 0x0016D20B File Offset: 0x0016B40B
		static vtkPBRIrradianceTexture()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPBRIrradianceTexture.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPBRIrradianceTexture"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06010600 RID: 67072 RVA: 0x0016D233 File Offset: 0x0016B433
		public vtkPBRIrradianceTexture(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06010601 RID: 67073
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPBRIrradianceTexture_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010602 RID: 67074 RVA: 0x0016D244 File Offset: 0x0016B444
		public new static vtkPBRIrradianceTexture New()
		{
			vtkPBRIrradianceTexture result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPBRIrradianceTexture.vtkPBRIrradianceTexture_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPBRIrradianceTexture)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010603 RID: 67075 RVA: 0x0016D298 File Offset: 0x0016B498
		public vtkPBRIrradianceTexture() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPBRIrradianceTexture.vtkPBRIrradianceTexture_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010604 RID: 67076 RVA: 0x0016D2DC File Offset: 0x0016B4DC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06010605 RID: 67077
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPBRIrradianceTexture_ConvertToLinearOff_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the conversion to linear color space.
		/// If the input texture is in sRGB color space and the conversion is not done by OpenGL
		/// directly with the texture format, the conversion can be done in the shader with this flag.
		/// </summary>
		// Token: 0x06010606 RID: 67078 RVA: 0x0016D2E7 File Offset: 0x0016B4E7
		public virtual void ConvertToLinearOff()
		{
			vtkPBRIrradianceTexture.vtkPBRIrradianceTexture_ConvertToLinearOff_01(base.GetCppThis());
		}

		// Token: 0x06010607 RID: 67079
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPBRIrradianceTexture_ConvertToLinearOn_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the conversion to linear color space.
		/// If the input texture is in sRGB color space and the conversion is not done by OpenGL
		/// directly with the texture format, the conversion can be done in the shader with this flag.
		/// </summary>
		// Token: 0x06010608 RID: 67080 RVA: 0x0016D2F6 File Offset: 0x0016B4F6
		public virtual void ConvertToLinearOn()
		{
			vtkPBRIrradianceTexture.vtkPBRIrradianceTexture_ConvertToLinearOn_02(base.GetCppThis());
		}

		// Token: 0x06010609 RID: 67081
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPBRIrradianceTexture_GetConvertToLinear_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the conversion to linear color space.
		/// If the input texture is in sRGB color space and the conversion is not done by OpenGL
		/// directly with the texture format, the conversion can be done in the shader with this flag.
		/// </summary>
		// Token: 0x0601060A RID: 67082 RVA: 0x0016D308 File Offset: 0x0016B508
		public virtual bool GetConvertToLinear()
		{
			return vtkPBRIrradianceTexture.vtkPBRIrradianceTexture_GetConvertToLinear_03(base.GetCppThis()) != 0;
		}

		// Token: 0x0601060B RID: 67083
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPBRIrradianceTexture_GetInputTexture_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the input texture.
		/// </summary>
		// Token: 0x0601060C RID: 67084 RVA: 0x0016D330 File Offset: 0x0016B530
		public virtual vtkOpenGLTexture GetInputTexture()
		{
			vtkOpenGLTexture vtkOpenGLTexture = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPBRIrradianceTexture.vtkPBRIrradianceTexture_GetInputTexture_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601060D RID: 67085
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkPBRIrradianceTexture_GetIrradianceSize_05(HandleRef pThis);

		/// <summary>
		/// Set/Get size of texture.
		/// Default is 256.
		/// </summary>
		// Token: 0x0601060E RID: 67086 RVA: 0x0016D3A0 File Offset: 0x0016B5A0
		public virtual uint GetIrradianceSize()
		{
			return vtkPBRIrradianceTexture.vtkPBRIrradianceTexture_GetIrradianceSize_05(base.GetCppThis());
		}

		// Token: 0x0601060F RID: 67087
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkPBRIrradianceTexture_GetIrradianceStep_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the size of steps in radians used to sample hemisphere.
		/// Default is (pi/64).
		/// In some OpenGL drivers (OSMesa, old OSX), the default value might be too low leading to
		/// artifacts.
		/// </summary>
		// Token: 0x06010610 RID: 67088 RVA: 0x0016D3C0 File Offset: 0x0016B5C0
		public virtual float GetIrradianceStep()
		{
			return vtkPBRIrradianceTexture.vtkPBRIrradianceTexture_GetIrradianceStep_06(base.GetCppThis());
		}

		// Token: 0x06010611 RID: 67089
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPBRIrradianceTexture_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010612 RID: 67090 RVA: 0x0016D3E0 File Offset: 0x0016B5E0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPBRIrradianceTexture.vtkPBRIrradianceTexture_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x06010613 RID: 67091
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPBRIrradianceTexture_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010614 RID: 67092 RVA: 0x0016D400 File Offset: 0x0016B600
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPBRIrradianceTexture.vtkPBRIrradianceTexture_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x06010615 RID: 67093
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPBRIrradianceTexture_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010616 RID: 67094 RVA: 0x0016D41C File Offset: 0x0016B61C
		public override int IsA(string type)
		{
			return vtkPBRIrradianceTexture.vtkPBRIrradianceTexture_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x06010617 RID: 67095
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPBRIrradianceTexture_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010618 RID: 67096 RVA: 0x0016D43C File Offset: 0x0016B63C
		public new static int IsTypeOf(string type)
		{
			return vtkPBRIrradianceTexture.vtkPBRIrradianceTexture_IsTypeOf_10(type);
		}

		// Token: 0x06010619 RID: 67097
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPBRIrradianceTexture_Load_11(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Implement base class method.
		/// </summary>
		// Token: 0x0601061A RID: 67098 RVA: 0x0016D458 File Offset: 0x0016B658
		public override void Load(vtkRenderer arg0)
		{
			vtkPBRIrradianceTexture.vtkPBRIrradianceTexture_Load_11(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601061B RID: 67099
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPBRIrradianceTexture_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601061C RID: 67100 RVA: 0x0016D488 File Offset: 0x0016B688
		public new vtkPBRIrradianceTexture NewInstance()
		{
			vtkPBRIrradianceTexture result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPBRIrradianceTexture.vtkPBRIrradianceTexture_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPBRIrradianceTexture)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601061D RID: 67101
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPBRIrradianceTexture_ReleaseGraphicsResources_14(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Release any graphics resources that are being consumed by this texture.
		/// The parameter window could be used to determine which graphic
		/// resources to release. Using the same texture object in multiple
		/// render windows is NOT currently supported.
		/// </summary>
		// Token: 0x0601061E RID: 67102 RVA: 0x0016D4E4 File Offset: 0x0016B6E4
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkPBRIrradianceTexture.vtkPBRIrradianceTexture_ReleaseGraphicsResources_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601061F RID: 67103
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPBRIrradianceTexture_Render_15(HandleRef pThis, HandleRef ren);

		/// <summary>
		/// Implement base class method.
		/// </summary>
		// Token: 0x06010620 RID: 67104 RVA: 0x0016D514 File Offset: 0x0016B714
		public override void Render(vtkRenderer ren)
		{
			vtkPBRIrradianceTexture.vtkPBRIrradianceTexture_Render_15(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		// Token: 0x06010621 RID: 67105
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPBRIrradianceTexture_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010622 RID: 67106 RVA: 0x0016D544 File Offset: 0x0016B744
		public new static vtkPBRIrradianceTexture SafeDownCast(vtkObjectBase o)
		{
			vtkPBRIrradianceTexture vtkPBRIrradianceTexture = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPBRIrradianceTexture.vtkPBRIrradianceTexture_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPBRIrradianceTexture = (vtkPBRIrradianceTexture)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPBRIrradianceTexture.Register(null);
				}
			}
			return vtkPBRIrradianceTexture;
		}

		// Token: 0x06010623 RID: 67107
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPBRIrradianceTexture_SetConvertToLinear_17(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get the conversion to linear color space.
		/// If the input texture is in sRGB color space and the conversion is not done by OpenGL
		/// directly with the texture format, the conversion can be done in the shader with this flag.
		/// </summary>
		// Token: 0x06010624 RID: 67108 RVA: 0x0016D5C3 File Offset: 0x0016B7C3
		public virtual void SetConvertToLinear(bool _arg)
		{
			vtkPBRIrradianceTexture.vtkPBRIrradianceTexture_SetConvertToLinear_17(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06010625 RID: 67109
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPBRIrradianceTexture_SetInputTexture_18(HandleRef pThis, HandleRef texture);

		/// <summary>
		/// Get/Set the input texture.
		/// </summary>
		// Token: 0x06010626 RID: 67110 RVA: 0x0016D5DC File Offset: 0x0016B7DC
		public void SetInputTexture(vtkOpenGLTexture texture)
		{
			vtkPBRIrradianceTexture.vtkPBRIrradianceTexture_SetInputTexture_18(base.GetCppThis(), (texture == null) ? default(HandleRef) : texture.GetCppThis());
		}

		// Token: 0x06010627 RID: 67111
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPBRIrradianceTexture_SetIrradianceSize_19(HandleRef pThis, uint _arg);

		/// <summary>
		/// Set/Get size of texture.
		/// Default is 256.
		/// </summary>
		// Token: 0x06010628 RID: 67112 RVA: 0x0016D60B File Offset: 0x0016B80B
		public virtual void SetIrradianceSize(uint _arg)
		{
			vtkPBRIrradianceTexture.vtkPBRIrradianceTexture_SetIrradianceSize_19(base.GetCppThis(), _arg);
		}

		// Token: 0x06010629 RID: 67113
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPBRIrradianceTexture_SetIrradianceStep_20(HandleRef pThis, float _arg);

		/// <summary>
		/// Set/Get the size of steps in radians used to sample hemisphere.
		/// Default is (pi/64).
		/// In some OpenGL drivers (OSMesa, old OSX), the default value might be too low leading to
		/// artifacts.
		/// </summary>
		// Token: 0x0601062A RID: 67114 RVA: 0x0016D61B File Offset: 0x0016B81B
		public virtual void SetIrradianceStep(float _arg)
		{
			vtkPBRIrradianceTexture.vtkPBRIrradianceTexture_SetIrradianceStep_20(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001305 RID: 4869
		public new const string MRFullTypeName = "Kitware.VTK.vtkPBRIrradianceTexture";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001306 RID: 4870
		public new static readonly string MRClassNameKey = "class vtkPBRIrradianceTexture";
	}
}
