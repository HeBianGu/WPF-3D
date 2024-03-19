using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenGLRenderer
	/// </summary>
	/// <remarks>
	///    OpenGL renderer
	///
	/// vtkOpenGLRenderer is a concrete implementation of the abstract class
	/// vtkRenderer. vtkOpenGLRenderer interfaces to the OpenGL graphics library.
	/// </remarks>
	// Token: 0x020000AD RID: 173
	public class vtkOpenGLRenderer : vtkRenderer
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06002681 RID: 9857 RVA: 0x00038D64 File Offset: 0x00036F64
		static vtkOpenGLRenderer()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLRenderer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLRenderer"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06002682 RID: 9858 RVA: 0x00038D8C File Offset: 0x00036F8C
		public vtkOpenGLRenderer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06002683 RID: 9859
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLRenderer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002684 RID: 9860 RVA: 0x00038D9C File Offset: 0x00036F9C
		public new static vtkOpenGLRenderer New()
		{
			vtkOpenGLRenderer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLRenderer.vtkOpenGLRenderer_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLRenderer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002685 RID: 9861 RVA: 0x00038DF0 File Offset: 0x00036FF0
		public vtkOpenGLRenderer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenGLRenderer.vtkOpenGLRenderer_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06002686 RID: 9862 RVA: 0x00038E34 File Offset: 0x00037034
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06002687 RID: 9863
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLRenderer_Clear_01(HandleRef pThis);

		/// <summary>
		/// Render translucent polygonal geometry. Default implementation just call
		/// UpdateTranslucentPolygonalGeometry().
		/// Subclasses of vtkRenderer that can deal with depth peeling must
		/// override this method.
		/// </summary>
		// Token: 0x06002688 RID: 9864 RVA: 0x00038E3F File Offset: 0x0003703F
		public override void Clear()
		{
			vtkOpenGLRenderer.vtkOpenGLRenderer_Clear_01(base.GetCppThis());
		}

		// Token: 0x06002689 RID: 9865
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLRenderer_DeviceRender_02(HandleRef pThis);

		/// <summary>
		/// Concrete open gl render method.
		/// </summary>
		// Token: 0x0600268A RID: 9866 RVA: 0x00038E4E File Offset: 0x0003704E
		public override void DeviceRender()
		{
			vtkOpenGLRenderer.vtkOpenGLRenderer_DeviceRender_02(base.GetCppThis());
		}

		// Token: 0x0600268B RID: 9867
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLRenderer_DeviceRenderOpaqueGeometry_03(HandleRef pThis, HandleRef fbo);

		/// <summary>
		/// Overridden to support hidden line removal.
		/// </summary>
		// Token: 0x0600268C RID: 9868 RVA: 0x00038E60 File Offset: 0x00037060
		public override void DeviceRenderOpaqueGeometry(vtkFrameBufferObjectBase fbo)
		{
			vtkOpenGLRenderer.vtkOpenGLRenderer_DeviceRenderOpaqueGeometry_03(base.GetCppThis(), (fbo == null) ? default(HandleRef) : fbo.GetCppThis());
		}

		// Token: 0x0600268D RID: 9869
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLRenderer_DeviceRenderTranslucentPolygonalGeometry_04(HandleRef pThis, HandleRef fbo);

		/// <summary>
		/// Render translucent polygonal geometry. Default implementation just call
		/// UpdateTranslucentPolygonalGeometry().
		/// Subclasses of vtkRenderer that can deal with depth peeling must
		/// override this method.
		/// </summary>
		// Token: 0x0600268E RID: 9870 RVA: 0x00038E90 File Offset: 0x00037090
		public override void DeviceRenderTranslucentPolygonalGeometry(vtkFrameBufferObjectBase fbo)
		{
			vtkOpenGLRenderer.vtkOpenGLRenderer_DeviceRenderTranslucentPolygonalGeometry_04(base.GetCppThis(), (fbo == null) ? default(HandleRef) : fbo.GetCppThis());
		}

		// Token: 0x0600268F RID: 9871
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLRenderer_GetDepthPeelingHigherLayer_05(HandleRef pThis);

		/// <summary>
		/// Is rendering at translucent geometry stage using depth peeling and
		/// rendering a layer other than the first one? (Boolean value)
		/// If so, the uniform variables UseTexture and Texture can be set.
		/// (Used by vtkOpenGLProperty or vtkOpenGLTexture)
		/// </summary>
		// Token: 0x06002690 RID: 9872 RVA: 0x00038EC0 File Offset: 0x000370C0
		public int GetDepthPeelingHigherLayer()
		{
			return vtkOpenGLRenderer.vtkOpenGLRenderer_GetDepthPeelingHigherLayer_05(base.GetCppThis());
		}

		// Token: 0x06002691 RID: 9873
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLRenderer_GetEnvMapIrradiance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get environment textures used for image based lighting.
		/// </summary>
		// Token: 0x06002692 RID: 9874 RVA: 0x00038EE0 File Offset: 0x000370E0
		public vtkPBRIrradianceTexture GetEnvMapIrradiance()
		{
			vtkPBRIrradianceTexture vtkPBRIrradianceTexture = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLRenderer.vtkOpenGLRenderer_GetEnvMapIrradiance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06002693 RID: 9875
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLRenderer_GetEnvMapLookupTable_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get environment textures used for image based lighting.
		/// </summary>
		// Token: 0x06002694 RID: 9876 RVA: 0x00038F50 File Offset: 0x00037150
		public vtkPBRLUTTexture GetEnvMapLookupTable()
		{
			vtkPBRLUTTexture vtkPBRLUTTexture = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLRenderer.vtkOpenGLRenderer_GetEnvMapLookupTable_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPBRLUTTexture = (vtkPBRLUTTexture)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPBRLUTTexture.Register(null);
				}
			}
			return vtkPBRLUTTexture;
		}

		// Token: 0x06002695 RID: 9877
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLRenderer_GetEnvMapPrefiltered_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get environment textures used for image based lighting.
		/// </summary>
		// Token: 0x06002696 RID: 9878 RVA: 0x00038FC0 File Offset: 0x000371C0
		public vtkPBRPrefilterTexture GetEnvMapPrefiltered()
		{
			vtkPBRPrefilterTexture vtkPBRPrefilterTexture = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLRenderer.vtkOpenGLRenderer_GetEnvMapPrefiltered_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06002697 RID: 9879
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLRenderer_GetLightingComplexity_09(HandleRef pThis);

		/// <summary>
		/// Dual depth peeling may be disabled for certain runtime configurations.
		/// This method returns true if vtkDualDepthPeelingPass will be used in place
		/// of vtkDepthPeelingPass.
		/// </summary>
		// Token: 0x06002698 RID: 9880 RVA: 0x00039030 File Offset: 0x00037230
		public virtual int GetLightingComplexity()
		{
			return vtkOpenGLRenderer.vtkOpenGLRenderer_GetLightingComplexity_09(base.GetCppThis());
		}

		// Token: 0x06002699 RID: 9881
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLRenderer_GetLightingCount_10(HandleRef pThis);

		/// <summary>
		/// Dual depth peeling may be disabled for certain runtime configurations.
		/// This method returns true if vtkDualDepthPeelingPass will be used in place
		/// of vtkDepthPeelingPass.
		/// </summary>
		// Token: 0x0600269A RID: 9882 RVA: 0x00039050 File Offset: 0x00037250
		public virtual int GetLightingCount()
		{
			return vtkOpenGLRenderer.vtkOpenGLRenderer_GetLightingCount_10(base.GetCppThis());
		}

		// Token: 0x0600269B RID: 9883
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLRenderer_GetLightingUniforms_11(HandleRef pThis);

		/// <summary>
		/// Dual depth peeling may be disabled for certain runtime configurations.
		/// This method returns true if vtkDualDepthPeelingPass will be used in place
		/// of vtkDepthPeelingPass.
		/// </summary>
		// Token: 0x0600269C RID: 9884 RVA: 0x00039070 File Offset: 0x00037270
		public string GetLightingUniforms()
		{
			string s = Marshal.PtrToStringAnsi(vtkOpenGLRenderer.vtkOpenGLRenderer_GetLightingUniforms_11(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600269D RID: 9885
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLRenderer_GetNumberOfGenerationsFromBase_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600269E RID: 9886 RVA: 0x000390AC File Offset: 0x000372AC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenGLRenderer.vtkOpenGLRenderer_GetNumberOfGenerationsFromBase_12(base.GetCppThis(), type);
		}

		// Token: 0x0600269F RID: 9887
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLRenderer_GetNumberOfGenerationsFromBaseType_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060026A0 RID: 9888 RVA: 0x000390CC File Offset: 0x000372CC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenGLRenderer.vtkOpenGLRenderer_GetNumberOfGenerationsFromBaseType_13(type);
		}

		// Token: 0x060026A1 RID: 9889
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLRenderer_GetSphericalHarmonics_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get spherical harmonics coefficients used for irradiance
		/// </summary>
		// Token: 0x060026A2 RID: 9890 RVA: 0x000390E8 File Offset: 0x000372E8
		public vtkFloatArray GetSphericalHarmonics()
		{
			vtkFloatArray vtkFloatArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLRenderer.vtkOpenGLRenderer_GetSphericalHarmonics_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFloatArray = (vtkFloatArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFloatArray.Register(null);
				}
			}
			return vtkFloatArray;
		}

		// Token: 0x060026A3 RID: 9891
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenGLRenderer_GetUseSphericalHarmonics_15(HandleRef pThis);

		/// <summary>
		/// Use spherical harmonics instead of irradiance texture
		/// </summary>
		// Token: 0x060026A4 RID: 9892 RVA: 0x00039158 File Offset: 0x00037358
		public virtual bool GetUseSphericalHarmonics()
		{
			return vtkOpenGLRenderer.vtkOpenGLRenderer_GetUseSphericalHarmonics_15(base.GetCppThis()) != 0;
		}

		// Token: 0x060026A5 RID: 9893
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLRenderer_GetUserLightTransform_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the user light transform applied after the camera transform.
		/// Can be null to disable it.
		/// </summary>
		// Token: 0x060026A6 RID: 9894 RVA: 0x00039180 File Offset: 0x00037380
		public vtkTransform GetUserLightTransform()
		{
			vtkTransform vtkTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLRenderer.vtkOpenGLRenderer_GetUserLightTransform_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransform = (vtkTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransform.Register(null);
				}
			}
			return vtkTransform;
		}

		// Token: 0x060026A7 RID: 9895
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenGLRenderer_HaveAppleQueryAllocationBug_17();

		/// <summary>
		/// Indicate if this system is subject to the apple/NVIDIA bug that causes
		/// crashes in the driver when too many query objects are allocated.
		/// </summary>
		// Token: 0x060026A8 RID: 9896 RVA: 0x000391F0 File Offset: 0x000373F0
		public static bool HaveAppleQueryAllocationBug()
		{
			return vtkOpenGLRenderer.vtkOpenGLRenderer_HaveAppleQueryAllocationBug_17() != 0;
		}

		// Token: 0x060026A9 RID: 9897
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLRenderer_IsA_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060026AA RID: 9898 RVA: 0x00039210 File Offset: 0x00037410
		public override int IsA(string type)
		{
			return vtkOpenGLRenderer.vtkOpenGLRenderer_IsA_18(base.GetCppThis(), type);
		}

		// Token: 0x060026AB RID: 9899
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenGLRenderer_IsDualDepthPeelingSupported_19(HandleRef pThis);

		/// <summary>
		/// Dual depth peeling may be disabled for certain runtime configurations.
		/// This method returns true if vtkDualDepthPeelingPass will be used in place
		/// of vtkDepthPeelingPass.
		/// </summary>
		// Token: 0x060026AC RID: 9900 RVA: 0x00039230 File Offset: 0x00037430
		public bool IsDualDepthPeelingSupported()
		{
			return vtkOpenGLRenderer.vtkOpenGLRenderer_IsDualDepthPeelingSupported_19(base.GetCppThis()) != 0;
		}

		// Token: 0x060026AD RID: 9901
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLRenderer_IsTypeOf_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060026AE RID: 9902 RVA: 0x00039258 File Offset: 0x00037458
		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLRenderer.vtkOpenGLRenderer_IsTypeOf_20(type);
		}

		// Token: 0x060026AF RID: 9903
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLRenderer_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060026B0 RID: 9904 RVA: 0x00039274 File Offset: 0x00037474
		public new vtkOpenGLRenderer NewInstance()
		{
			vtkOpenGLRenderer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLRenderer.vtkOpenGLRenderer_NewInstance_22(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLRenderer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060026B1 RID: 9905
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLRenderer_ReleaseGraphicsResources_23(HandleRef pThis, HandleRef w);

		/// <summary>
		/// Set/Get the environment texture used for image based lighting.
		/// This texture is supposed to represent the scene background.
		/// If it is not a cubemap, the texture is supposed to represent an equirectangular projection.
		/// If used with raytracing backends, the texture must be an equirectangular projection and must be
		/// constructed with a valid vtkImageData.
		/// Warning, this texture must be expressed in linear color space.
		/// If the texture is in sRGB color space, set the color flag on the texture or
		/// set the argument isSRGB to true.
		/// Note that this texture can be omitted if LUT, SpecularColorMap and SphericalHarmonics
		/// are used and provided
		///
		/// @sa vtkTexture::UseSRGBColorSpaceOn
		/// </summary>
		// Token: 0x060026B2 RID: 9906 RVA: 0x000392D0 File Offset: 0x000374D0
		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkOpenGLRenderer.vtkOpenGLRenderer_ReleaseGraphicsResources_23(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		// Token: 0x060026B3 RID: 9907
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLRenderer_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060026B4 RID: 9908 RVA: 0x00039300 File Offset: 0x00037500
		public new static vtkOpenGLRenderer SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLRenderer vtkOpenGLRenderer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLRenderer.vtkOpenGLRenderer_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLRenderer = (vtkOpenGLRenderer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLRenderer.Register(null);
				}
			}
			return vtkOpenGLRenderer;
		}

		// Token: 0x060026B5 RID: 9909
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLRenderer_SetEnvironmentTexture_25(HandleRef pThis, HandleRef texture, byte isSRGB);

		/// <summary>
		/// Set/Get the environment texture used for image based lighting.
		/// This texture is supposed to represent the scene background.
		/// If it is not a cubemap, the texture is supposed to represent an equirectangular projection.
		/// If used with raytracing backends, the texture must be an equirectangular projection and must be
		/// constructed with a valid vtkImageData.
		/// Warning, this texture must be expressed in linear color space.
		/// If the texture is in sRGB color space, set the color flag on the texture or
		/// set the argument isSRGB to true.
		/// Note that this texture can be omitted if LUT, SpecularColorMap and SphericalHarmonics
		/// are used and provided
		///
		/// @sa vtkTexture::UseSRGBColorSpaceOn
		/// </summary>
		// Token: 0x060026B6 RID: 9910 RVA: 0x00039380 File Offset: 0x00037580
		public override void SetEnvironmentTexture(vtkTexture texture, bool isSRGB)
		{
			vtkOpenGLRenderer.vtkOpenGLRenderer_SetEnvironmentTexture_25(base.GetCppThis(), (texture == null) ? default(HandleRef) : texture.GetCppThis(), isSRGB ? (byte)1 : (byte)0);
		}

		// Token: 0x060026B7 RID: 9911
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLRenderer_SetUseSphericalHarmonics_26(HandleRef pThis, byte _arg);

		/// <summary>
		/// Use spherical harmonics instead of irradiance texture
		/// </summary>
		// Token: 0x060026B8 RID: 9912 RVA: 0x000393B8 File Offset: 0x000375B8
		public virtual void SetUseSphericalHarmonics(bool _arg)
		{
			vtkOpenGLRenderer.vtkOpenGLRenderer_SetUseSphericalHarmonics_26(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060026B9 RID: 9913
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLRenderer_SetUserLightTransform_27(HandleRef pThis, HandleRef transform);

		/// <summary>
		/// Set the user light transform applied after the camera transform.
		/// Can be null to disable it.
		/// </summary>
		// Token: 0x060026BA RID: 9914 RVA: 0x000393D0 File Offset: 0x000375D0
		public void SetUserLightTransform(vtkTransform transform)
		{
			vtkOpenGLRenderer.vtkOpenGLRenderer_SetUserLightTransform_27(base.GetCppThis(), (transform == null) ? default(HandleRef) : transform.GetCppThis());
		}

		// Token: 0x060026BB RID: 9915
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLRenderer_UpdateLightingUniforms_28(HandleRef pThis, HandleRef prog);

		/// <summary>
		/// Dual depth peeling may be disabled for certain runtime configurations.
		/// This method returns true if vtkDualDepthPeelingPass will be used in place
		/// of vtkDepthPeelingPass.
		/// </summary>
		// Token: 0x060026BC RID: 9916 RVA: 0x00039400 File Offset: 0x00037600
		public void UpdateLightingUniforms(vtkShaderProgram prog)
		{
			vtkOpenGLRenderer.vtkOpenGLRenderer_UpdateLightingUniforms_28(base.GetCppThis(), (prog == null) ? default(HandleRef) : prog.GetCppThis());
		}

		// Token: 0x060026BD RID: 9917
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLRenderer_UpdateLights_29(HandleRef pThis);

		/// <summary>
		/// Ask lights to load themselves into graphics pipeline.
		/// </summary>
		// Token: 0x060026BE RID: 9918 RVA: 0x00039430 File Offset: 0x00037630
		public virtual int UpdateLights()
		{
			return vtkOpenGLRenderer.vtkOpenGLRenderer_UpdateLights_29(base.GetCppThis());
		}

		// Token: 0x060026BF RID: 9919
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLRenderer_UseSphericalHarmonicsOff_30(HandleRef pThis);

		/// <summary>
		/// Use spherical harmonics instead of irradiance texture
		/// </summary>
		// Token: 0x060026C0 RID: 9920 RVA: 0x0003944F File Offset: 0x0003764F
		public virtual void UseSphericalHarmonicsOff()
		{
			vtkOpenGLRenderer.vtkOpenGLRenderer_UseSphericalHarmonicsOff_30(base.GetCppThis());
		}

		// Token: 0x060026C1 RID: 9921
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLRenderer_UseSphericalHarmonicsOn_31(HandleRef pThis);

		/// <summary>
		/// Use spherical harmonics instead of irradiance texture
		/// </summary>
		// Token: 0x060026C2 RID: 9922 RVA: 0x0003945E File Offset: 0x0003765E
		public virtual void UseSphericalHarmonicsOn()
		{
			vtkOpenGLRenderer.vtkOpenGLRenderer_UseSphericalHarmonicsOn_31(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000540 RID: 1344
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLRenderer";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000541 RID: 1345
		public new static readonly string MRClassNameKey = "class vtkOpenGLRenderer";

		/// <summary>
		/// Dual depth peeling may be disabled for certain runtime configurations.
		/// This method returns true if vtkDualDepthPeelingPass will be used in place
		/// of vtkDepthPeelingPass.
		/// </summary>
		// Token: 0x020000AE RID: 174
		public enum LightingComplexityEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000543 RID: 1347
			Directional = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000544 RID: 1348
			Headlight = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000545 RID: 1349
			NoLighting = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000546 RID: 1350
			Positional = 3
		}
	}
}
