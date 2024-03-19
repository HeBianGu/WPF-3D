using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenGLFluidMapper
	/// </summary>
	/// <remarks>
	///    Render fluid from position data (and color, if available)
	///
	/// An OpenGL mapper that display fluid volume using a screen space
	/// fluid rendering technique. Thanks to Nghia Truong for the algorithm
	/// and initial implementation.
	/// </remarks>
	// Token: 0x020005A5 RID: 1445
	public class vtkOpenGLFluidMapper : vtkAbstractVolumeMapper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600FD5D RID: 64861 RVA: 0x0016108F File Offset: 0x0015F28F
		static vtkOpenGLFluidMapper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLFluidMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLFluidMapper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600FD5E RID: 64862 RVA: 0x001610B7 File Offset: 0x0015F2B7
		public vtkOpenGLFluidMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600FD5F RID: 64863
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLFluidMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FD60 RID: 64864 RVA: 0x001610C8 File Offset: 0x0015F2C8
		public new static vtkOpenGLFluidMapper New()
		{
			vtkOpenGLFluidMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLFluidMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FD61 RID: 64865 RVA: 0x0016111C File Offset: 0x0015F31C
		public vtkOpenGLFluidMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600FD62 RID: 64866 RVA: 0x00161160 File Offset: 0x0015F360
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600FD63 RID: 64867
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkOpenGLFluidMapper_GetAdditionalReflection_01(HandleRef pThis);

		/// <summary>
		/// Get/Set the fluid surface additional reflection scale This value is in
		/// [0, 1], which 0 means using the reflection color computed from fresnel
		/// equation, and 1 means using reflection color as [1, 1, 1] Default value
		/// is 0
		/// </summary>
		// Token: 0x0600FD64 RID: 64868 RVA: 0x0016116C File Offset: 0x0015F36C
		public virtual float GetAdditionalReflection()
		{
			return vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_GetAdditionalReflection_01(base.GetCppThis());
		}

		// Token: 0x0600FD65 RID: 64869
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLFluidMapper_GetAttenuationColor_02(HandleRef pThis);

		/// <summary>
		/// Get/Set the fluid attenuation color
		/// (color that will be absorpted exponentially when going through the fluid
		/// volume)
		/// </summary>
		// Token: 0x0600FD66 RID: 64870 RVA: 0x0016118C File Offset: 0x0015F38C
		public virtual float[] GetAttenuationColor()
		{
			IntPtr intPtr = vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_GetAttenuationColor_02(base.GetCppThis());
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600FD67 RID: 64871
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFluidMapper_GetAttenuationColor_03(HandleRef pThis, ref float _arg1, ref float _arg2, ref float _arg3);

		/// <summary>
		/// Get/Set the fluid attenuation color
		/// (color that will be absorpted exponentially when going through the fluid
		/// volume)
		/// </summary>
		// Token: 0x0600FD68 RID: 64872 RVA: 0x001611D4 File Offset: 0x0015F3D4
		public virtual void GetAttenuationColor(ref float _arg1, ref float _arg2, ref float _arg3)
		{
			vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_GetAttenuationColor_03(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600FD69 RID: 64873
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFluidMapper_GetAttenuationColor_04(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the fluid attenuation color
		/// (color that will be absorpted exponentially when going through the fluid
		/// volume)
		/// </summary>
		// Token: 0x0600FD6A RID: 64874 RVA: 0x001611E6 File Offset: 0x0015F3E6
		public virtual void GetAttenuationColor(IntPtr _arg)
		{
			vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_GetAttenuationColor_04(base.GetCppThis(), _arg);
		}

		// Token: 0x0600FD6B RID: 64875
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkOpenGLFluidMapper_GetAttenuationScale_05(HandleRef pThis);

		/// <summary>
		/// Get/Set the fluid volume attenuation scale, which will be multiplied
		/// with attenuation color Default value is 1.0, and can be set to any
		/// non-negative number The larger attenuation scale, the darker fluid
		/// color
		/// </summary>
		// Token: 0x0600FD6C RID: 64876 RVA: 0x001611F8 File Offset: 0x0015F3F8
		public virtual float GetAttenuationScale()
		{
			return vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_GetAttenuationScale_05(base.GetCppThis());
		}

		// Token: 0x0600FD6D RID: 64877
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkOpenGLFluidMapper.FluidDisplayMode vtkOpenGLFluidMapper_GetDisplayMode_06(HandleRef pThis);

		/// <summary>
		/// Get/Set the display mode
		/// </summary>
		// Token: 0x0600FD6E RID: 64878 RVA: 0x00161218 File Offset: 0x0015F418
		public virtual vtkOpenGLFluidMapper.FluidDisplayMode GetDisplayMode()
		{
			return vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_GetDisplayMode_06(base.GetCppThis());
		}

		// Token: 0x0600FD6F RID: 64879
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLFluidMapper_GetInput_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the input data to map.
		/// </summary>
		// Token: 0x0600FD70 RID: 64880 RVA: 0x00161238 File Offset: 0x0015F438
		public vtkPolyData GetInput()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_GetInput_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x0600FD71 RID: 64881
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLFluidMapper_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FD72 RID: 64882 RVA: 0x001612A8 File Offset: 0x0015F4A8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x0600FD73 RID: 64883
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLFluidMapper_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FD74 RID: 64884 RVA: 0x001612C8 File Offset: 0x0015F4C8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x0600FD75 RID: 64885
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLFluidMapper_GetOpaqueColor_10(HandleRef pThis);

		/// <summary>
		/// Get/Set the fluid surface color if rendered in opaque surface mode
		/// without particle color
		/// </summary>
		// Token: 0x0600FD76 RID: 64886 RVA: 0x001612E4 File Offset: 0x0015F4E4
		public virtual float[] GetOpaqueColor()
		{
			IntPtr intPtr = vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_GetOpaqueColor_10(base.GetCppThis());
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600FD77 RID: 64887
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFluidMapper_GetOpaqueColor_11(HandleRef pThis, ref float _arg1, ref float _arg2, ref float _arg3);

		/// <summary>
		/// Get/Set the fluid surface color if rendered in opaque surface mode
		/// without particle color
		/// </summary>
		// Token: 0x0600FD78 RID: 64888 RVA: 0x0016132C File Offset: 0x0015F52C
		public virtual void GetOpaqueColor(ref float _arg1, ref float _arg2, ref float _arg3)
		{
			vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_GetOpaqueColor_11(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600FD79 RID: 64889
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFluidMapper_GetOpaqueColor_12(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the fluid surface color if rendered in opaque surface mode
		/// without particle color
		/// </summary>
		// Token: 0x0600FD7A RID: 64890 RVA: 0x0016133E File Offset: 0x0015F53E
		public virtual void GetOpaqueColor(IntPtr _arg)
		{
			vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_GetOpaqueColor_12(base.GetCppThis(), _arg);
		}

		// Token: 0x0600FD7B RID: 64891
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkOpenGLFluidMapper_GetParticleColorPower_13(HandleRef pThis);

		/// <summary>
		/// Get/Set the power value for particle color if input data has particle
		/// color Default value is 0.1, and can be set to any non-negative number The
		/// particle color is then recomputed as newColor = pow(oldColor, power) *
		/// scale
		/// </summary>
		// Token: 0x0600FD7C RID: 64892 RVA: 0x00161350 File Offset: 0x0015F550
		public virtual float GetParticleColorPower()
		{
			return vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_GetParticleColorPower_13(base.GetCppThis());
		}

		// Token: 0x0600FD7D RID: 64893
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkOpenGLFluidMapper_GetParticleColorScale_14(HandleRef pThis);

		/// <summary>
		/// Get/Set the scale value for particle color if input data has particle
		/// color Default value is 1.0, and can be set to any non-negative number The
		/// particle color is then recomputed as newColor = pow(oldColor, power) *
		/// scale
		/// </summary>
		// Token: 0x0600FD7E RID: 64894 RVA: 0x00161370 File Offset: 0x0015F570
		public virtual float GetParticleColorScale()
		{
			return vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_GetParticleColorScale_14(base.GetCppThis());
		}

		// Token: 0x0600FD7F RID: 64895
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkOpenGLFluidMapper_GetParticleRadius_15(HandleRef pThis);

		/// <summary>
		/// Set/Get the particle radius, must be explicitly set by user
		/// To fuse the gaps between particles and obtain a smooth surface,
		/// this parameter need to be slightly larger than the actual particle radius,
		/// (particle radius is the half distance between two consecutive particles in
		/// regular pattern sampling)
		/// </summary>
		// Token: 0x0600FD80 RID: 64896 RVA: 0x00161390 File Offset: 0x0015F590
		public virtual float GetParticleRadius()
		{
			return vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_GetParticleRadius_15(base.GetCppThis());
		}

		// Token: 0x0600FD81 RID: 64897
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkOpenGLFluidMapper_GetRefractionScale_16(HandleRef pThis);

		/// <summary>
		/// Get/Set the scale value for refraction This is needed for tweak
		/// refraction of volumes with different size scales For example, fluid
		/// volume having diameter of 100.0 will refract light much more than
		/// volume with diameter 1.0 This value is in [0, 1], default value is 1.0
		/// </summary>
		// Token: 0x0600FD82 RID: 64898 RVA: 0x001613B0 File Offset: 0x0015F5B0
		public virtual float GetRefractionScale()
		{
			return vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_GetRefractionScale_16(base.GetCppThis());
		}

		// Token: 0x0600FD83 RID: 64899
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkOpenGLFluidMapper_GetRefractiveIndex_17(HandleRef pThis);

		/// <summary>
		/// Get/Set the fluid refraction index. The default value is 1.33 (water)
		/// </summary>
		// Token: 0x0600FD84 RID: 64900 RVA: 0x001613D0 File Offset: 0x0015F5D0
		public virtual float GetRefractiveIndex()
		{
			return vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_GetRefractiveIndex_17(base.GetCppThis());
		}

		// Token: 0x0600FD85 RID: 64901
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenGLFluidMapper_GetScalarVisibility_18(HandleRef pThis);

		/// <summary>
		/// Turn on/off flag to control whether scalar data is used to color objects.
		/// </summary>
		// Token: 0x0600FD86 RID: 64902 RVA: 0x001613F0 File Offset: 0x0015F5F0
		public virtual bool GetScalarVisibility()
		{
			return vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_GetScalarVisibility_18(base.GetCppThis()) != 0;
		}

		// Token: 0x0600FD87 RID: 64903
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkOpenGLFluidMapper_GetSurfaceFilterIterations_19(HandleRef pThis);

		/// <summary>
		/// Get/Set the number of filter iterations to filter the depth surface
		/// This is an optional parameter, default value is 3
		/// Usually set this to around 3-5
		/// Too many filter iterations will over-smooth the surface
		/// </summary>
		// Token: 0x0600FD88 RID: 64904 RVA: 0x00161418 File Offset: 0x0015F618
		public virtual uint GetSurfaceFilterIterations()
		{
			return vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_GetSurfaceFilterIterations_19(base.GetCppThis());
		}

		// Token: 0x0600FD89 RID: 64905
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkOpenGLFluidMapper.FluidSurfaceFilterMethod vtkOpenGLFluidMapper_GetSurfaceFilterMethod_20(HandleRef pThis);

		/// <summary>
		/// Get/Set the filter method for filtering fluid surface
		/// </summary>
		// Token: 0x0600FD8A RID: 64906 RVA: 0x00161438 File Offset: 0x0015F638
		public virtual vtkOpenGLFluidMapper.FluidSurfaceFilterMethod GetSurfaceFilterMethod()
		{
			return vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_GetSurfaceFilterMethod_20(base.GetCppThis());
		}

		// Token: 0x0600FD8B RID: 64907
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkOpenGLFluidMapper_GetSurfaceFilterRadius_21(HandleRef pThis);

		/// <summary>
		/// Get/Set the filter radius for smoothing the depth surface
		/// This is an optional parameter, default value is 5
		/// This is not exactly the radius in pixels,
		/// instead it is just a parameter used for computing the actual filter
		/// radius in the screen space filtering
		/// </summary>
		// Token: 0x0600FD8C RID: 64908 RVA: 0x00161458 File Offset: 0x0015F658
		public virtual uint GetSurfaceFilterRadius()
		{
			return vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_GetSurfaceFilterRadius_21(base.GetCppThis());
		}

		// Token: 0x0600FD8D RID: 64909
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkOpenGLFluidMapper_GetThicknessAndVolumeColorFilterIterations_22(HandleRef pThis);

		/// <summary>
		/// Get/Set the number of filter iterations to filter the volume thickness
		/// and particle color This is an optional parameter, default value is 3
		/// </summary>
		// Token: 0x0600FD8E RID: 64910 RVA: 0x00161478 File Offset: 0x0015F678
		public virtual uint GetThicknessAndVolumeColorFilterIterations()
		{
			return vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_GetThicknessAndVolumeColorFilterIterations_22(base.GetCppThis());
		}

		// Token: 0x0600FD8F RID: 64911
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkOpenGLFluidMapper_GetThicknessAndVolumeColorFilterRadius_23(HandleRef pThis);

		/// <summary>
		/// Get/Set the filter radius to filter the volume thickness and particle
		/// color This is an optional parameter, default value is 10 (pixels)
		/// </summary>
		// Token: 0x0600FD90 RID: 64912 RVA: 0x00161498 File Offset: 0x0015F698
		public virtual float GetThicknessAndVolumeColorFilterRadius()
		{
			return vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_GetThicknessAndVolumeColorFilterRadius_23(base.GetCppThis());
		}

		// Token: 0x0600FD91 RID: 64913
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLFluidMapper_IsA_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FD92 RID: 64914 RVA: 0x001614B8 File Offset: 0x0015F6B8
		public override int IsA(string type)
		{
			return vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_IsA_24(base.GetCppThis(), type);
		}

		// Token: 0x0600FD93 RID: 64915
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLFluidMapper_IsTypeOf_25([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FD94 RID: 64916 RVA: 0x001614D8 File Offset: 0x0015F6D8
		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_IsTypeOf_25(type);
		}

		// Token: 0x0600FD95 RID: 64917
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLFluidMapper_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FD96 RID: 64918 RVA: 0x001614F4 File Offset: 0x0015F6F4
		public new vtkOpenGLFluidMapper NewInstance()
		{
			vtkOpenGLFluidMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_NewInstance_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLFluidMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600FD97 RID: 64919
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFluidMapper_ReleaseGraphicsResources_28(HandleRef pThis, HandleRef w);

		/// <summary>
		/// Release graphics resources and ask components to release their own
		/// resources.
		/// \pre w_exists: w!=0
		/// </summary>
		// Token: 0x0600FD98 RID: 64920 RVA: 0x00161550 File Offset: 0x0015F750
		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_ReleaseGraphicsResources_28(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		// Token: 0x0600FD99 RID: 64921
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFluidMapper_Render_29(HandleRef pThis, HandleRef ren, HandleRef vol);

		/// <summary>
		/// This calls RenderPiece
		/// </summary>
		// Token: 0x0600FD9A RID: 64922 RVA: 0x00161580 File Offset: 0x0015F780
		public override void Render(vtkRenderer ren, vtkVolume vol)
		{
			vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_Render_29(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis());
		}

		// Token: 0x0600FD9B RID: 64923
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLFluidMapper_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FD9C RID: 64924 RVA: 0x001615C4 File Offset: 0x0015F7C4
		public new static vtkOpenGLFluidMapper SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLFluidMapper vtkOpenGLFluidMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_SafeDownCast_30((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLFluidMapper = (vtkOpenGLFluidMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLFluidMapper.Register(null);
				}
			}
			return vtkOpenGLFluidMapper;
		}

		// Token: 0x0600FD9D RID: 64925
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFluidMapper_ScalarVisibilityOff_31(HandleRef pThis);

		/// <summary>
		/// Turn on/off flag to control whether scalar data is used to color objects.
		/// </summary>
		// Token: 0x0600FD9E RID: 64926 RVA: 0x00161643 File Offset: 0x0015F843
		public virtual void ScalarVisibilityOff()
		{
			vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_ScalarVisibilityOff_31(base.GetCppThis());
		}

		// Token: 0x0600FD9F RID: 64927
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFluidMapper_ScalarVisibilityOn_32(HandleRef pThis);

		/// <summary>
		/// Turn on/off flag to control whether scalar data is used to color objects.
		/// </summary>
		// Token: 0x0600FDA0 RID: 64928 RVA: 0x00161652 File Offset: 0x0015F852
		public virtual void ScalarVisibilityOn()
		{
			vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_ScalarVisibilityOn_32(base.GetCppThis());
		}

		// Token: 0x0600FDA1 RID: 64929
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFluidMapper_SetAdditionalReflection_33(HandleRef pThis, float _arg);

		/// <summary>
		/// Get/Set the fluid surface additional reflection scale This value is in
		/// [0, 1], which 0 means using the reflection color computed from fresnel
		/// equation, and 1 means using reflection color as [1, 1, 1] Default value
		/// is 0
		/// </summary>
		// Token: 0x0600FDA2 RID: 64930 RVA: 0x00161661 File Offset: 0x0015F861
		public virtual void SetAdditionalReflection(float _arg)
		{
			vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_SetAdditionalReflection_33(base.GetCppThis(), _arg);
		}

		// Token: 0x0600FDA3 RID: 64931
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFluidMapper_SetAttenuationColor_34(HandleRef pThis, float _arg1, float _arg2, float _arg3);

		/// <summary>
		/// Get/Set the fluid attenuation color
		/// (color that will be absorpted exponentially when going through the fluid
		/// volume)
		/// </summary>
		// Token: 0x0600FDA4 RID: 64932 RVA: 0x00161671 File Offset: 0x0015F871
		public virtual void SetAttenuationColor(float _arg1, float _arg2, float _arg3)
		{
			vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_SetAttenuationColor_34(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600FDA5 RID: 64933
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFluidMapper_SetAttenuationColor_35(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the fluid attenuation color
		/// (color that will be absorpted exponentially when going through the fluid
		/// volume)
		/// </summary>
		// Token: 0x0600FDA6 RID: 64934 RVA: 0x00161683 File Offset: 0x0015F883
		public virtual void SetAttenuationColor(IntPtr _arg)
		{
			vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_SetAttenuationColor_35(base.GetCppThis(), _arg);
		}

		// Token: 0x0600FDA7 RID: 64935
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFluidMapper_SetAttenuationScale_36(HandleRef pThis, float _arg);

		/// <summary>
		/// Get/Set the fluid volume attenuation scale, which will be multiplied
		/// with attenuation color Default value is 1.0, and can be set to any
		/// non-negative number The larger attenuation scale, the darker fluid
		/// color
		/// </summary>
		// Token: 0x0600FDA8 RID: 64936 RVA: 0x00161693 File Offset: 0x0015F893
		public virtual void SetAttenuationScale(float _arg)
		{
			vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_SetAttenuationScale_36(base.GetCppThis(), _arg);
		}

		// Token: 0x0600FDA9 RID: 64937
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFluidMapper_SetBilateralGaussianFilterParameter_37(HandleRef pThis, float sigmaDepth);

		/// <summary>
		/// Optional parameters, exclusively for bilateral gaussian filter
		/// The parameter is for controlling smoothing between surface depth values
		/// </summary>
		// Token: 0x0600FDAA RID: 64938 RVA: 0x001616A3 File Offset: 0x0015F8A3
		public void SetBilateralGaussianFilterParameter(float sigmaDepth)
		{
			vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_SetBilateralGaussianFilterParameter_37(base.GetCppThis(), sigmaDepth);
		}

		// Token: 0x0600FDAB RID: 64939
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFluidMapper_SetDisplayMode_38(HandleRef pThis, vtkOpenGLFluidMapper.FluidDisplayMode _arg);

		/// <summary>
		/// Get/Set the display mode
		/// </summary>
		// Token: 0x0600FDAC RID: 64940 RVA: 0x001616B3 File Offset: 0x0015F8B3
		public virtual void SetDisplayMode(vtkOpenGLFluidMapper.FluidDisplayMode _arg)
		{
			vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_SetDisplayMode_38(base.GetCppThis(), _arg);
		}

		// Token: 0x0600FDAD RID: 64941
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFluidMapper_SetInputData_39(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the input data to map.
		/// </summary>
		// Token: 0x0600FDAE RID: 64942 RVA: 0x001616C4 File Offset: 0x0015F8C4
		public void SetInputData(vtkPolyData arg0)
		{
			vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_SetInputData_39(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600FDAF RID: 64943
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFluidMapper_SetNarrowRangeFilterParameters_40(HandleRef pThis, float lambda, float mu);

		/// <summary>
		/// Optional parameters, exclusively for narrow range filter
		/// The first parameter is to control smoothing between surface depth values
		/// The second parameter is to control curvature of the surface edges
		/// </summary>
		// Token: 0x0600FDB0 RID: 64944 RVA: 0x001616F3 File Offset: 0x0015F8F3
		public void SetNarrowRangeFilterParameters(float lambda, float mu)
		{
			vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_SetNarrowRangeFilterParameters_40(base.GetCppThis(), lambda, mu);
		}

		// Token: 0x0600FDB1 RID: 64945
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFluidMapper_SetOpaqueColor_41(HandleRef pThis, float _arg1, float _arg2, float _arg3);

		/// <summary>
		/// Get/Set the fluid surface color if rendered in opaque surface mode
		/// without particle color
		/// </summary>
		// Token: 0x0600FDB2 RID: 64946 RVA: 0x00161704 File Offset: 0x0015F904
		public virtual void SetOpaqueColor(float _arg1, float _arg2, float _arg3)
		{
			vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_SetOpaqueColor_41(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600FDB3 RID: 64947
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFluidMapper_SetOpaqueColor_42(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the fluid surface color if rendered in opaque surface mode
		/// without particle color
		/// </summary>
		// Token: 0x0600FDB4 RID: 64948 RVA: 0x00161716 File Offset: 0x0015F916
		public virtual void SetOpaqueColor(IntPtr _arg)
		{
			vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_SetOpaqueColor_42(base.GetCppThis(), _arg);
		}

		// Token: 0x0600FDB5 RID: 64949
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFluidMapper_SetParticleColorPower_43(HandleRef pThis, float _arg);

		/// <summary>
		/// Get/Set the power value for particle color if input data has particle
		/// color Default value is 0.1, and can be set to any non-negative number The
		/// particle color is then recomputed as newColor = pow(oldColor, power) *
		/// scale
		/// </summary>
		// Token: 0x0600FDB6 RID: 64950 RVA: 0x00161726 File Offset: 0x0015F926
		public virtual void SetParticleColorPower(float _arg)
		{
			vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_SetParticleColorPower_43(base.GetCppThis(), _arg);
		}

		// Token: 0x0600FDB7 RID: 64951
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFluidMapper_SetParticleColorScale_44(HandleRef pThis, float _arg);

		/// <summary>
		/// Get/Set the scale value for particle color if input data has particle
		/// color Default value is 1.0, and can be set to any non-negative number The
		/// particle color is then recomputed as newColor = pow(oldColor, power) *
		/// scale
		/// </summary>
		// Token: 0x0600FDB8 RID: 64952 RVA: 0x00161736 File Offset: 0x0015F936
		public virtual void SetParticleColorScale(float _arg)
		{
			vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_SetParticleColorScale_44(base.GetCppThis(), _arg);
		}

		// Token: 0x0600FDB9 RID: 64953
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFluidMapper_SetParticleRadius_45(HandleRef pThis, float _arg);

		/// <summary>
		/// Set/Get the particle radius, must be explicitly set by user
		/// To fuse the gaps between particles and obtain a smooth surface,
		/// this parameter need to be slightly larger than the actual particle radius,
		/// (particle radius is the half distance between two consecutive particles in
		/// regular pattern sampling)
		/// </summary>
		// Token: 0x0600FDBA RID: 64954 RVA: 0x00161746 File Offset: 0x0015F946
		public virtual void SetParticleRadius(float _arg)
		{
			vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_SetParticleRadius_45(base.GetCppThis(), _arg);
		}

		// Token: 0x0600FDBB RID: 64955
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFluidMapper_SetRefractionScale_46(HandleRef pThis, float _arg);

		/// <summary>
		/// Get/Set the scale value for refraction This is needed for tweak
		/// refraction of volumes with different size scales For example, fluid
		/// volume having diameter of 100.0 will refract light much more than
		/// volume with diameter 1.0 This value is in [0, 1], default value is 1.0
		/// </summary>
		// Token: 0x0600FDBC RID: 64956 RVA: 0x00161756 File Offset: 0x0015F956
		public virtual void SetRefractionScale(float _arg)
		{
			vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_SetRefractionScale_46(base.GetCppThis(), _arg);
		}

		// Token: 0x0600FDBD RID: 64957
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFluidMapper_SetRefractiveIndex_47(HandleRef pThis, float _arg);

		/// <summary>
		/// Get/Set the fluid refraction index. The default value is 1.33 (water)
		/// </summary>
		// Token: 0x0600FDBE RID: 64958 RVA: 0x00161766 File Offset: 0x0015F966
		public virtual void SetRefractiveIndex(float _arg)
		{
			vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_SetRefractiveIndex_47(base.GetCppThis(), _arg);
		}

		// Token: 0x0600FDBF RID: 64959
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFluidMapper_SetScalarVisibility_48(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on/off flag to control whether scalar data is used to color objects.
		/// </summary>
		// Token: 0x0600FDC0 RID: 64960 RVA: 0x00161776 File Offset: 0x0015F976
		public virtual void SetScalarVisibility(bool _arg)
		{
			vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_SetScalarVisibility_48(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600FDC1 RID: 64961
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFluidMapper_SetSurfaceFilterIterations_49(HandleRef pThis, uint _arg);

		/// <summary>
		/// Get/Set the number of filter iterations to filter the depth surface
		/// This is an optional parameter, default value is 3
		/// Usually set this to around 3-5
		/// Too many filter iterations will over-smooth the surface
		/// </summary>
		// Token: 0x0600FDC2 RID: 64962 RVA: 0x0016178E File Offset: 0x0015F98E
		public virtual void SetSurfaceFilterIterations(uint _arg)
		{
			vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_SetSurfaceFilterIterations_49(base.GetCppThis(), _arg);
		}

		// Token: 0x0600FDC3 RID: 64963
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFluidMapper_SetSurfaceFilterMethod_50(HandleRef pThis, vtkOpenGLFluidMapper.FluidSurfaceFilterMethod _arg);

		/// <summary>
		/// Get/Set the filter method for filtering fluid surface
		/// </summary>
		// Token: 0x0600FDC4 RID: 64964 RVA: 0x0016179E File Offset: 0x0015F99E
		public virtual void SetSurfaceFilterMethod(vtkOpenGLFluidMapper.FluidSurfaceFilterMethod _arg)
		{
			vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_SetSurfaceFilterMethod_50(base.GetCppThis(), _arg);
		}

		// Token: 0x0600FDC5 RID: 64965
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFluidMapper_SetSurfaceFilterRadius_51(HandleRef pThis, uint _arg);

		/// <summary>
		/// Get/Set the filter radius for smoothing the depth surface
		/// This is an optional parameter, default value is 5
		/// This is not exactly the radius in pixels,
		/// instead it is just a parameter used for computing the actual filter
		/// radius in the screen space filtering
		/// </summary>
		// Token: 0x0600FDC6 RID: 64966 RVA: 0x001617AE File Offset: 0x0015F9AE
		public virtual void SetSurfaceFilterRadius(uint _arg)
		{
			vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_SetSurfaceFilterRadius_51(base.GetCppThis(), _arg);
		}

		// Token: 0x0600FDC7 RID: 64967
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFluidMapper_SetThicknessAndVolumeColorFilterIterations_52(HandleRef pThis, uint _arg);

		/// <summary>
		/// Get/Set the number of filter iterations to filter the volume thickness
		/// and particle color This is an optional parameter, default value is 3
		/// </summary>
		// Token: 0x0600FDC8 RID: 64968 RVA: 0x001617BE File Offset: 0x0015F9BE
		public virtual void SetThicknessAndVolumeColorFilterIterations(uint _arg)
		{
			vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_SetThicknessAndVolumeColorFilterIterations_52(base.GetCppThis(), _arg);
		}

		// Token: 0x0600FDC9 RID: 64969
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFluidMapper_SetThicknessAndVolumeColorFilterRadius_53(HandleRef pThis, float _arg);

		/// <summary>
		/// Get/Set the filter radius to filter the volume thickness and particle
		/// color This is an optional parameter, default value is 10 (pixels)
		/// </summary>
		// Token: 0x0600FDCA RID: 64970 RVA: 0x001617CE File Offset: 0x0015F9CE
		public virtual void SetThicknessAndVolumeColorFilterRadius(float _arg)
		{
			vtkOpenGLFluidMapper.vtkOpenGLFluidMapper_SetThicknessAndVolumeColorFilterRadius_53(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001275 RID: 4725
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLFluidMapper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001276 RID: 4726
		public new static readonly string MRClassNameKey = "class vtkOpenGLFluidMapper";

		/// <summary>
		/// Display mode for the fluid, default value is TransparentFluidVolume
		/// </summary>
		// Token: 0x020005A6 RID: 1446
		public enum FluidDisplayMode
		{
			/// <summary>enum member</summary>
			// Token: 0x04001278 RID: 4728
			FilteredOpaqueSurface = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001279 RID: 4729
			FilteredSurfaceNormal = 3,
			/// <summary>enum member</summary>
			// Token: 0x0400127A RID: 4730
			NumDisplayModes = 5,
			/// <summary>enum member</summary>
			// Token: 0x0400127B RID: 4731
			TransparentFluidVolume = 4,
			/// <summary>enum member</summary>
			// Token: 0x0400127C RID: 4732
			UnfilteredOpaqueSurface = 0,
			/// <summary>enum member</summary>
			// Token: 0x0400127D RID: 4733
			UnfilteredSurfaceNormal = 2
		}

		/// <summary>
		/// Filter method to filter the depth buffer
		/// </summary>
		// Token: 0x020005A7 RID: 1447
		public enum FluidSurfaceFilterMethod
		{
			/// <summary>enum member</summary>
			// Token: 0x0400127F RID: 4735
			BilateralGaussian,
			/// <summary>enum member</summary>
			// Token: 0x04001280 RID: 4736
			NarrowRange,
			/// <summary>enum member</summary>
			// Token: 0x04001281 RID: 4737
			NumFilterMethods
		}
	}
}
