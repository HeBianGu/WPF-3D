using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTexture
	/// </summary>
	/// <remarks>
	///    handles properties associated with a texture map
	///
	/// vtkTexture is an image algorithm that handles loading and binding of
	/// texture maps. It obtains its data from an input image data dataset type.
	/// Thus you can create visualization pipelines to read, process, and
	/// construct textures. Note that textures will only work if texture
	/// coordinates are also defined, and if the rendering system supports
	/// texture.
	///
	/// Instances of vtkTexture are associated with actors via the actor's
	/// SetTexture() method. Actors can share texture maps (this is encouraged
	/// to save memory resources.)
	///
	/// @warning
	/// Currently only 2D texture maps are supported, even though the data pipeline
	/// supports 1,2, and 3D texture coordinates.
	///
	/// @warning
	/// Some renderers such as old OpenGL require that the texture map dimensions
	/// are a power of two in each direction. If a non-power of two texture map is
	/// used, it is automatically resampled to a power of two in one or more
	/// directions, at the cost of an expensive computation. If the OpenGL
	/// implementation is recent enough (OpenGL&gt;=2.0 or
	/// extension GL_ARB_texture_non_power_of_two exists) there is no such
	/// restriction and no extra computational cost.
	/// </remarks>
	/// <seealso>
	///
	/// vtkActor vtkRenderer vtkOpenGLTexture
	/// </seealso>
	// Token: 0x0200058B RID: 1419
	public class vtkTexture : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600FA71 RID: 64113 RVA: 0x0015C683 File Offset: 0x0015A883
		static vtkTexture()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTexture.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTexture"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600FA72 RID: 64114 RVA: 0x0015C6AB File Offset: 0x0015A8AB
		public vtkTexture(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600FA73 RID: 64115
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTexture_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FA74 RID: 64116 RVA: 0x0015C6BC File Offset: 0x0015A8BC
		public new static vtkTexture New()
		{
			vtkTexture result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTexture.vtkTexture_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTexture)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FA75 RID: 64117 RVA: 0x0015C710 File Offset: 0x0015A910
		public vtkTexture() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTexture.vtkTexture_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600FA76 RID: 64118 RVA: 0x0015C754 File Offset: 0x0015A954
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600FA77 RID: 64119
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexture_CubeMapOff_01(HandleRef pThis);

		/// <summary>
		/// Is this texture a cube map, if so it needs 6 inputs
		/// one for each side of the cube. You must set this before
		/// connecting the inputs. The inputs must all have the same
		/// size, data type, and depth
		/// </summary>
		// Token: 0x0600FA78 RID: 64120 RVA: 0x0015C75F File Offset: 0x0015A95F
		public virtual void CubeMapOff()
		{
			vtkTexture.vtkTexture_CubeMapOff_01(base.GetCppThis());
		}

		// Token: 0x0600FA79 RID: 64121
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexture_CubeMapOn_02(HandleRef pThis);

		/// <summary>
		/// Is this texture a cube map, if so it needs 6 inputs
		/// one for each side of the cube. You must set this before
		/// connecting the inputs. The inputs must all have the same
		/// size, data type, and depth
		/// </summary>
		// Token: 0x0600FA7A RID: 64122 RVA: 0x0015C76E File Offset: 0x0015A96E
		public virtual void CubeMapOn()
		{
			vtkTexture.vtkTexture_CubeMapOn_02(base.GetCppThis());
		}

		// Token: 0x0600FA7B RID: 64123
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexture_EdgeClampOff_03(HandleRef pThis);

		/// <summary>
		/// Convenience functions to maintain backwards compatibility.
		/// For new code, use the SetWrap API.
		/// </summary>
		// Token: 0x0600FA7C RID: 64124 RVA: 0x0015C77D File Offset: 0x0015A97D
		public virtual void EdgeClampOff()
		{
			vtkTexture.vtkTexture_EdgeClampOff_03(base.GetCppThis());
		}

		// Token: 0x0600FA7D RID: 64125
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexture_EdgeClampOn_04(HandleRef pThis);

		/// <summary>
		/// Convenience functions to maintain backwards compatibility.
		/// For new code, use the SetWrap API.
		/// </summary>
		// Token: 0x0600FA7E RID: 64126 RVA: 0x0015C78C File Offset: 0x0015A98C
		public virtual void EdgeClampOn()
		{
			vtkTexture.vtkTexture_EdgeClampOn_04(base.GetCppThis());
		}

		// Token: 0x0600FA7F RID: 64127
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTexture_GetBlendingMode_05(HandleRef pThis);

		/// <summary>
		/// Used to specify how the texture will blend its RGB and Alpha values
		/// with other textures and the fragment the texture is rendered upon.
		/// </summary>
		// Token: 0x0600FA80 RID: 64128 RVA: 0x0015C79C File Offset: 0x0015A99C
		public virtual int GetBlendingMode()
		{
			return vtkTexture.vtkTexture_GetBlendingMode_05(base.GetCppThis());
		}

		// Token: 0x0600FA81 RID: 64129
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTexture_GetBorderColor_06(HandleRef pThis);

		/// <summary>
		/// Border Color (RGBA). The values can be any valid float value,
		/// if the gpu supports it. Initial value is (0.0f, 0.0f, 0.0f, 0.0f),
		/// as in the OpenGL spec.
		///
		/// \note
		/// This property is ignored for OpenGL ES &lt;= 3.2
		/// </summary>
		// Token: 0x0600FA82 RID: 64130 RVA: 0x0015C7BC File Offset: 0x0015A9BC
		public virtual float[] GetBorderColor()
		{
			IntPtr intPtr = vtkTexture.vtkTexture_GetBorderColor_06(base.GetCppThis());
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600FA83 RID: 64131
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexture_GetBorderColor_07(HandleRef pThis, ref float _arg1, ref float _arg2, ref float _arg3, ref float _arg4);

		/// <summary>
		/// Border Color (RGBA). The values can be any valid float value,
		/// if the gpu supports it. Initial value is (0.0f, 0.0f, 0.0f, 0.0f),
		/// as in the OpenGL spec.
		///
		/// \note
		/// This property is ignored for OpenGL ES &lt;= 3.2
		/// </summary>
		// Token: 0x0600FA84 RID: 64132 RVA: 0x0015C804 File Offset: 0x0015AA04
		public virtual void GetBorderColor(ref float _arg1, ref float _arg2, ref float _arg3, ref float _arg4)
		{
			vtkTexture.vtkTexture_GetBorderColor_07(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		// Token: 0x0600FA85 RID: 64133
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexture_GetBorderColor_08(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Border Color (RGBA). The values can be any valid float value,
		/// if the gpu supports it. Initial value is (0.0f, 0.0f, 0.0f, 0.0f),
		/// as in the OpenGL spec.
		///
		/// \note
		/// This property is ignored for OpenGL ES &lt;= 3.2
		/// </summary>
		// Token: 0x0600FA86 RID: 64134 RVA: 0x0015C818 File Offset: 0x0015AA18
		public virtual void GetBorderColor(IntPtr _arg)
		{
			vtkTexture.vtkTexture_GetBorderColor_08(base.GetCppThis(), _arg);
		}

		// Token: 0x0600FA87 RID: 64135
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTexture_GetColorMode_09(HandleRef pThis);

		/// <summary>
		/// Default: ColorModeToDefault. unsigned char scalars are treated
		/// as colors, and NOT mapped through the lookup table (set with SetLookupTable),
		/// while other kinds of scalars are. ColorModeToDirectScalar extends
		/// ColorModeToDefault such that all integer types are treated as
		/// colors with values in the range 0-255 and floating types are
		/// treated as colors with values in the range 0.0-1.0. Setting
		/// ColorModeToMapScalars means that all scalar data will be mapped
		/// through the lookup table.
		/// </summary>
		// Token: 0x0600FA88 RID: 64136 RVA: 0x0015C828 File Offset: 0x0015AA28
		public virtual int GetColorMode()
		{
			return vtkTexture.vtkTexture_GetColorMode_09(base.GetCppThis());
		}

		// Token: 0x0600FA89 RID: 64137
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTexture_GetCubeMap_10(HandleRef pThis);

		/// <summary>
		/// Is this texture a cube map, if so it needs 6 inputs
		/// one for each side of the cube. You must set this before
		/// connecting the inputs. The inputs must all have the same
		/// size, data type, and depth
		/// </summary>
		// Token: 0x0600FA8A RID: 64138 RVA: 0x0015C848 File Offset: 0x0015AA48
		public virtual bool GetCubeMap()
		{
			return vtkTexture.vtkTexture_GetCubeMap_10(base.GetCppThis()) != 0;
		}

		// Token: 0x0600FA8B RID: 64139
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTexture_GetEdgeClamp_11(HandleRef pThis);

		/// <summary>
		/// Convenience functions to maintain backwards compatibility.
		/// For new code, use the SetWrap API.
		/// </summary>
		// Token: 0x0600FA8C RID: 64140 RVA: 0x0015C870 File Offset: 0x0015AA70
		public virtual int GetEdgeClamp()
		{
			return vtkTexture.vtkTexture_GetEdgeClamp_11(base.GetCppThis());
		}

		// Token: 0x0600FA8D RID: 64141
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTexture_GetInput_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input as a vtkImageData object.  This method is for
		/// backwards compatibility.
		/// </summary>
		// Token: 0x0600FA8E RID: 64142 RVA: 0x0015C890 File Offset: 0x0015AA90
		public new vtkImageData GetInput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTexture.vtkTexture_GetInput_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		// Token: 0x0600FA8F RID: 64143
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTexture_GetInterpolate_13(HandleRef pThis);

		/// <summary>
		/// Turn on/off linear interpolation of the texture map when rendering.
		/// </summary>
		// Token: 0x0600FA90 RID: 64144 RVA: 0x0015C900 File Offset: 0x0015AB00
		public virtual int GetInterpolate()
		{
			return vtkTexture.vtkTexture_GetInterpolate_13(base.GetCppThis());
		}

		// Token: 0x0600FA91 RID: 64145
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTexture_GetLookupTable_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the lookup table to convert scalars if necessary
		/// </summary>
		// Token: 0x0600FA92 RID: 64146 RVA: 0x0015C920 File Offset: 0x0015AB20
		public virtual vtkScalarsToColors GetLookupTable()
		{
			vtkScalarsToColors vtkScalarsToColors = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTexture.vtkTexture_GetLookupTable_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScalarsToColors = (vtkScalarsToColors)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScalarsToColors.Register(null);
				}
			}
			return vtkScalarsToColors;
		}

		// Token: 0x0600FA93 RID: 64147
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTexture_GetMappedScalars_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get Mapped Scalars
		/// </summary>
		// Token: 0x0600FA94 RID: 64148 RVA: 0x0015C990 File Offset: 0x0015AB90
		public virtual vtkUnsignedCharArray GetMappedScalars()
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTexture.vtkTexture_GetMappedScalars_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedCharArray = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedCharArray.Register(null);
				}
			}
			return vtkUnsignedCharArray;
		}

		// Token: 0x0600FA95 RID: 64149
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkTexture_GetMaximumAnisotropicFiltering_16(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum anisotropic filtering to use. 1.0 means use no
		/// anisotropic filtering. The default value is 4.0 and a high value would
		/// be 16. This setting is only applied when mipmaps are used. This might
		/// not be supported on all machines.
		/// </summary>
		// Token: 0x0600FA96 RID: 64150 RVA: 0x0015CA00 File Offset: 0x0015AC00
		public virtual float GetMaximumAnisotropicFiltering()
		{
			return vtkTexture.vtkTexture_GetMaximumAnisotropicFiltering_16(base.GetCppThis());
		}

		// Token: 0x0600FA97 RID: 64151
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTexture_GetMipmap_17(HandleRef pThis);

		/// <summary>
		/// Turn on/off use of mipmaps when rendering.
		/// </summary>
		// Token: 0x0600FA98 RID: 64152 RVA: 0x0015CA20 File Offset: 0x0015AC20
		public virtual bool GetMipmap()
		{
			return vtkTexture.vtkTexture_GetMipmap_17(base.GetCppThis()) != 0;
		}

		// Token: 0x0600FA99 RID: 64153
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTexture_GetNumberOfGenerationsFromBase_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FA9A RID: 64154 RVA: 0x0015CA48 File Offset: 0x0015AC48
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTexture.vtkTexture_GetNumberOfGenerationsFromBase_18(base.GetCppThis(), type);
		}

		// Token: 0x0600FA9B RID: 64155
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTexture_GetNumberOfGenerationsFromBaseType_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FA9C RID: 64156 RVA: 0x0015CA68 File Offset: 0x0015AC68
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTexture.vtkTexture_GetNumberOfGenerationsFromBaseType_19(type);
		}

		// Token: 0x0600FA9D RID: 64157
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTexture_GetPremultipliedAlpha_20(HandleRef pThis);

		/// <summary>
		/// Whether the texture colors are premultiplied by alpha.
		/// Initial value is false.
		/// </summary>
		// Token: 0x0600FA9E RID: 64158 RVA: 0x0015CA84 File Offset: 0x0015AC84
		public virtual bool GetPremultipliedAlpha()
		{
			return vtkTexture.vtkTexture_GetPremultipliedAlpha_20(base.GetCppThis()) != 0;
		}

		// Token: 0x0600FA9F RID: 64159
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTexture_GetQuality_21(HandleRef pThis);

		/// <summary>
		/// Force texture quality to 16-bit or 32-bit.
		/// This might not be supported on all machines.
		/// </summary>
		// Token: 0x0600FAA0 RID: 64160 RVA: 0x0015CAAC File Offset: 0x0015ACAC
		public virtual int GetQuality()
		{
			return vtkTexture.vtkTexture_GetQuality_21(base.GetCppThis());
		}

		// Token: 0x0600FAA1 RID: 64161
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTexture_GetRepeat_22(HandleRef pThis);

		/// <summary>
		/// Convenience functions to maintain backwards compatibility.
		/// For new code, use the SetWrap API.
		/// </summary>
		// Token: 0x0600FAA2 RID: 64162 RVA: 0x0015CACC File Offset: 0x0015ACCC
		public virtual int GetRepeat()
		{
			return vtkTexture.vtkTexture_GetRepeat_22(base.GetCppThis());
		}

		// Token: 0x0600FAA3 RID: 64163
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTexture_GetRestrictPowerOf2ImageSmaller_23(HandleRef pThis);

		/// <summary>
		/// When the texture is forced to be a power of 2, the default behavior is
		/// for the "new" image's dimensions to be greater than or equal to with
		/// respects to the original.  Setting RestrictPowerOf2ImageSmaller to be
		/// 1 (or ON) with force the new image's dimensions to be less than or equal
		/// to with respects to the original.
		/// </summary>
		// Token: 0x0600FAA4 RID: 64164 RVA: 0x0015CAEC File Offset: 0x0015ACEC
		public virtual int GetRestrictPowerOf2ImageSmaller()
		{
			return vtkTexture.vtkTexture_GetRestrictPowerOf2ImageSmaller_23(base.GetCppThis());
		}

		// Token: 0x0600FAA5 RID: 64165
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTexture_GetTextureUnit_24(HandleRef pThis);

		/// <summary>
		/// Return the texture unit used for this texture
		/// </summary>
		// Token: 0x0600FAA6 RID: 64166 RVA: 0x0015CB0C File Offset: 0x0015AD0C
		public virtual int GetTextureUnit()
		{
			return vtkTexture.vtkTexture_GetTextureUnit_24(base.GetCppThis());
		}

		// Token: 0x0600FAA7 RID: 64167
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTexture_GetTransform_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set a transform on the texture which allows one to scale,
		/// rotate and translate the texture.
		/// </summary>
		// Token: 0x0600FAA8 RID: 64168 RVA: 0x0015CB2C File Offset: 0x0015AD2C
		public virtual vtkTransform GetTransform()
		{
			vtkTransform vtkTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTexture.vtkTexture_GetTransform_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600FAA9 RID: 64169
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTexture_GetUseSRGBColorSpace_26(HandleRef pThis);

		/// <summary>
		/// Is this texture using the sRGB color space. If you are using a
		/// sRGB framebuffer or window then you probably also want to be
		/// using sRGB color textures for proper handling of gamma and
		/// associated color mixing.
		/// </summary>
		// Token: 0x0600FAAA RID: 64170 RVA: 0x0015CB9C File Offset: 0x0015AD9C
		public virtual bool GetUseSRGBColorSpace()
		{
			return vtkTexture.vtkTexture_GetUseSRGBColorSpace_26(base.GetCppThis()) != 0;
		}

		// Token: 0x0600FAAB RID: 64171
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTexture_GetWrap_27(HandleRef pThis);

		/// <summary>
		/// Wrap mode for the texture coordinates
		/// Valid values are:
		/// - ClampToEdge
		/// - Repeat
		/// - MirroredRepeat
		/// - ClampToBorder
		/// Initial value is Repeat (as in OpenGL spec)
		///
		/// \note
		/// ClampToBorder is not supported with OpenGL ES &lt;= 3.2.
		/// Wrap will default to ClampToEdge if it is set to ClampToBorder in this case.
		/// </summary>
		// Token: 0x0600FAAC RID: 64172 RVA: 0x0015CBC4 File Offset: 0x0015ADC4
		public virtual int GetWrap()
		{
			return vtkTexture.vtkTexture_GetWrap_27(base.GetCppThis());
		}

		// Token: 0x0600FAAD RID: 64173
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTexture_GetWrapMaxValue_28(HandleRef pThis);

		/// <summary>
		/// Wrap mode for the texture coordinates
		/// Valid values are:
		/// - ClampToEdge
		/// - Repeat
		/// - MirroredRepeat
		/// - ClampToBorder
		/// Initial value is Repeat (as in OpenGL spec)
		///
		/// \note
		/// ClampToBorder is not supported with OpenGL ES &lt;= 3.2.
		/// Wrap will default to ClampToEdge if it is set to ClampToBorder in this case.
		/// </summary>
		// Token: 0x0600FAAE RID: 64174 RVA: 0x0015CBE4 File Offset: 0x0015ADE4
		public virtual int GetWrapMaxValue()
		{
			return vtkTexture.vtkTexture_GetWrapMaxValue_28(base.GetCppThis());
		}

		// Token: 0x0600FAAF RID: 64175
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTexture_GetWrapMinValue_29(HandleRef pThis);

		/// <summary>
		/// Wrap mode for the texture coordinates
		/// Valid values are:
		/// - ClampToEdge
		/// - Repeat
		/// - MirroredRepeat
		/// - ClampToBorder
		/// Initial value is Repeat (as in OpenGL spec)
		///
		/// \note
		/// ClampToBorder is not supported with OpenGL ES &lt;= 3.2.
		/// Wrap will default to ClampToEdge if it is set to ClampToBorder in this case.
		/// </summary>
		// Token: 0x0600FAB0 RID: 64176 RVA: 0x0015CC04 File Offset: 0x0015AE04
		public virtual int GetWrapMinValue()
		{
			return vtkTexture.vtkTexture_GetWrapMinValue_29(base.GetCppThis());
		}

		// Token: 0x0600FAB1 RID: 64177
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexture_InterpolateOff_30(HandleRef pThis);

		/// <summary>
		/// Turn on/off linear interpolation of the texture map when rendering.
		/// </summary>
		// Token: 0x0600FAB2 RID: 64178 RVA: 0x0015CC23 File Offset: 0x0015AE23
		public virtual void InterpolateOff()
		{
			vtkTexture.vtkTexture_InterpolateOff_30(base.GetCppThis());
		}

		// Token: 0x0600FAB3 RID: 64179
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexture_InterpolateOn_31(HandleRef pThis);

		/// <summary>
		/// Turn on/off linear interpolation of the texture map when rendering.
		/// </summary>
		// Token: 0x0600FAB4 RID: 64180 RVA: 0x0015CC32 File Offset: 0x0015AE32
		public virtual void InterpolateOn()
		{
			vtkTexture.vtkTexture_InterpolateOn_31(base.GetCppThis());
		}

		// Token: 0x0600FAB5 RID: 64181
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTexture_IsA_32(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FAB6 RID: 64182 RVA: 0x0015CC44 File Offset: 0x0015AE44
		public override int IsA(string type)
		{
			return vtkTexture.vtkTexture_IsA_32(base.GetCppThis(), type);
		}

		// Token: 0x0600FAB7 RID: 64183
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTexture_IsTranslucent_33(HandleRef pThis);

		/// <summary>
		/// Is this Texture Translucent?
		/// returns false (0) if the texture is either fully opaque or has
		/// only fully transparent pixels and fully opaque pixels and the
		/// Interpolate flag is turn off.
		/// </summary>
		// Token: 0x0600FAB8 RID: 64184 RVA: 0x0015CC64 File Offset: 0x0015AE64
		public virtual int IsTranslucent()
		{
			return vtkTexture.vtkTexture_IsTranslucent_33(base.GetCppThis());
		}

		// Token: 0x0600FAB9 RID: 64185
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTexture_IsTypeOf_34([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FABA RID: 64186 RVA: 0x0015CC84 File Offset: 0x0015AE84
		public new static int IsTypeOf(string type)
		{
			return vtkTexture.vtkTexture_IsTypeOf_34(type);
		}

		// Token: 0x0600FABB RID: 64187
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexture_Load_35(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Abstract interface to renderer. Each concrete subclass of
		/// vtkTexture will load its data into graphics system in response
		/// to this method invocation.
		/// </summary>
		// Token: 0x0600FABC RID: 64188 RVA: 0x0015CCA0 File Offset: 0x0015AEA0
		public virtual void Load(vtkRenderer arg0)
		{
			vtkTexture.vtkTexture_Load_35(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600FABD RID: 64189
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTexture_MapScalarsToColors_36(HandleRef pThis, HandleRef scalars);

		/// <summary>
		/// Map scalar values into color scalars.
		/// </summary>
		// Token: 0x0600FABE RID: 64190 RVA: 0x0015CCD0 File Offset: 0x0015AED0
		public IntPtr MapScalarsToColors(vtkDataArray scalars)
		{
			return vtkTexture.vtkTexture_MapScalarsToColors_36(base.GetCppThis(), (scalars == null) ? default(HandleRef) : scalars.GetCppThis());
		}

		// Token: 0x0600FABF RID: 64191
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexture_MipmapOff_37(HandleRef pThis);

		/// <summary>
		/// Turn on/off use of mipmaps when rendering.
		/// </summary>
		// Token: 0x0600FAC0 RID: 64192 RVA: 0x0015CD04 File Offset: 0x0015AF04
		public virtual void MipmapOff()
		{
			vtkTexture.vtkTexture_MipmapOff_37(base.GetCppThis());
		}

		// Token: 0x0600FAC1 RID: 64193
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexture_MipmapOn_38(HandleRef pThis);

		/// <summary>
		/// Turn on/off use of mipmaps when rendering.
		/// </summary>
		// Token: 0x0600FAC2 RID: 64194 RVA: 0x0015CD13 File Offset: 0x0015AF13
		public virtual void MipmapOn()
		{
			vtkTexture.vtkTexture_MipmapOn_38(base.GetCppThis());
		}

		// Token: 0x0600FAC3 RID: 64195
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTexture_NewInstance_40(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FAC4 RID: 64196 RVA: 0x0015CD24 File Offset: 0x0015AF24
		public new vtkTexture NewInstance()
		{
			vtkTexture result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTexture.vtkTexture_NewInstance_40(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTexture)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600FAC5 RID: 64197
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexture_PostRender_41(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Cleans up after the texture rendering to restore the state of the
		/// graphics context.
		/// </summary>
		// Token: 0x0600FAC6 RID: 64198 RVA: 0x0015CD80 File Offset: 0x0015AF80
		public virtual void PostRender(vtkRenderer arg0)
		{
			vtkTexture.vtkTexture_PostRender_41(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600FAC7 RID: 64199
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexture_PremultipliedAlphaOff_42(HandleRef pThis);

		/// <summary>
		/// Whether the texture colors are premultiplied by alpha.
		/// Initial value is false.
		/// </summary>
		// Token: 0x0600FAC8 RID: 64200 RVA: 0x0015CDAF File Offset: 0x0015AFAF
		public virtual void PremultipliedAlphaOff()
		{
			vtkTexture.vtkTexture_PremultipliedAlphaOff_42(base.GetCppThis());
		}

		// Token: 0x0600FAC9 RID: 64201
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexture_PremultipliedAlphaOn_43(HandleRef pThis);

		/// <summary>
		/// Whether the texture colors are premultiplied by alpha.
		/// Initial value is false.
		/// </summary>
		// Token: 0x0600FACA RID: 64202 RVA: 0x0015CDBE File Offset: 0x0015AFBE
		public virtual void PremultipliedAlphaOn()
		{
			vtkTexture.vtkTexture_PremultipliedAlphaOn_43(base.GetCppThis());
		}

		// Token: 0x0600FACB RID: 64203
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexture_ReleaseGraphicsResources_44(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Release any graphics resources that are being consumed by this texture.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x0600FACC RID: 64204 RVA: 0x0015CDD0 File Offset: 0x0015AFD0
		public virtual void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkTexture.vtkTexture_ReleaseGraphicsResources_44(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600FACD RID: 64205
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexture_Render_45(HandleRef pThis, HandleRef ren);

		/// <summary>
		/// Renders a texture map. It first checks the object's modified time
		/// to make sure the texture maps Input is valid, then it invokes the
		/// Load() method.
		/// </summary>
		// Token: 0x0600FACE RID: 64206 RVA: 0x0015CE00 File Offset: 0x0015B000
		public virtual void Render(vtkRenderer ren)
		{
			vtkTexture.vtkTexture_Render_45(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		// Token: 0x0600FACF RID: 64207
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexture_RepeatOff_46(HandleRef pThis);

		/// <summary>
		/// Convenience functions to maintain backwards compatibility.
		/// For new code, use the SetWrap API.
		/// </summary>
		// Token: 0x0600FAD0 RID: 64208 RVA: 0x0015CE2F File Offset: 0x0015B02F
		public virtual void RepeatOff()
		{
			vtkTexture.vtkTexture_RepeatOff_46(base.GetCppThis());
		}

		// Token: 0x0600FAD1 RID: 64209
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexture_RepeatOn_47(HandleRef pThis);

		/// <summary>
		/// Convenience functions to maintain backwards compatibility.
		/// For new code, use the SetWrap API.
		/// </summary>
		// Token: 0x0600FAD2 RID: 64210 RVA: 0x0015CE3E File Offset: 0x0015B03E
		public virtual void RepeatOn()
		{
			vtkTexture.vtkTexture_RepeatOn_47(base.GetCppThis());
		}

		// Token: 0x0600FAD3 RID: 64211
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexture_RestrictPowerOf2ImageSmallerOff_48(HandleRef pThis);

		/// <summary>
		/// When the texture is forced to be a power of 2, the default behavior is
		/// for the "new" image's dimensions to be greater than or equal to with
		/// respects to the original.  Setting RestrictPowerOf2ImageSmaller to be
		/// 1 (or ON) with force the new image's dimensions to be less than or equal
		/// to with respects to the original.
		/// </summary>
		// Token: 0x0600FAD4 RID: 64212 RVA: 0x0015CE4D File Offset: 0x0015B04D
		public virtual void RestrictPowerOf2ImageSmallerOff()
		{
			vtkTexture.vtkTexture_RestrictPowerOf2ImageSmallerOff_48(base.GetCppThis());
		}

		// Token: 0x0600FAD5 RID: 64213
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexture_RestrictPowerOf2ImageSmallerOn_49(HandleRef pThis);

		/// <summary>
		/// When the texture is forced to be a power of 2, the default behavior is
		/// for the "new" image's dimensions to be greater than or equal to with
		/// respects to the original.  Setting RestrictPowerOf2ImageSmaller to be
		/// 1 (or ON) with force the new image's dimensions to be less than or equal
		/// to with respects to the original.
		/// </summary>
		// Token: 0x0600FAD6 RID: 64214 RVA: 0x0015CE5C File Offset: 0x0015B05C
		public virtual void RestrictPowerOf2ImageSmallerOn()
		{
			vtkTexture.vtkTexture_RestrictPowerOf2ImageSmallerOn_49(base.GetCppThis());
		}

		// Token: 0x0600FAD7 RID: 64215
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTexture_SafeDownCast_50(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FAD8 RID: 64216 RVA: 0x0015CE6C File Offset: 0x0015B06C
		public new static vtkTexture SafeDownCast(vtkObjectBase o)
		{
			vtkTexture vtkTexture = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTexture.vtkTexture_SafeDownCast_50((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTexture = (vtkTexture)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTexture.Register(null);
				}
			}
			return vtkTexture;
		}

		// Token: 0x0600FAD9 RID: 64217
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexture_SetBlendingMode_51(HandleRef pThis, int _arg);

		/// <summary>
		/// Used to specify how the texture will blend its RGB and Alpha values
		/// with other textures and the fragment the texture is rendered upon.
		/// </summary>
		// Token: 0x0600FADA RID: 64218 RVA: 0x0015CEEB File Offset: 0x0015B0EB
		public virtual void SetBlendingMode(int _arg)
		{
			vtkTexture.vtkTexture_SetBlendingMode_51(base.GetCppThis(), _arg);
		}

		// Token: 0x0600FADB RID: 64219
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexture_SetBorderColor_52(HandleRef pThis, float _arg1, float _arg2, float _arg3, float _arg4);

		/// <summary>
		/// Border Color (RGBA). The values can be any valid float value,
		/// if the gpu supports it. Initial value is (0.0f, 0.0f, 0.0f, 0.0f),
		/// as in the OpenGL spec.
		///
		/// \note
		/// This property is ignored for OpenGL ES &lt;= 3.2
		/// </summary>
		// Token: 0x0600FADC RID: 64220 RVA: 0x0015CEFB File Offset: 0x0015B0FB
		public virtual void SetBorderColor(float _arg1, float _arg2, float _arg3, float _arg4)
		{
			vtkTexture.vtkTexture_SetBorderColor_52(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		// Token: 0x0600FADD RID: 64221
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexture_SetBorderColor_53(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Border Color (RGBA). The values can be any valid float value,
		/// if the gpu supports it. Initial value is (0.0f, 0.0f, 0.0f, 0.0f),
		/// as in the OpenGL spec.
		///
		/// \note
		/// This property is ignored for OpenGL ES &lt;= 3.2
		/// </summary>
		// Token: 0x0600FADE RID: 64222 RVA: 0x0015CF0F File Offset: 0x0015B10F
		public virtual void SetBorderColor(IntPtr _arg)
		{
			vtkTexture.vtkTexture_SetBorderColor_53(base.GetCppThis(), _arg);
		}

		// Token: 0x0600FADF RID: 64223
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexture_SetColorMode_54(HandleRef pThis, int _arg);

		/// <summary>
		/// Default: ColorModeToDefault. unsigned char scalars are treated
		/// as colors, and NOT mapped through the lookup table (set with SetLookupTable),
		/// while other kinds of scalars are. ColorModeToDirectScalar extends
		/// ColorModeToDefault such that all integer types are treated as
		/// colors with values in the range 0-255 and floating types are
		/// treated as colors with values in the range 0.0-1.0. Setting
		/// ColorModeToMapScalars means that all scalar data will be mapped
		/// through the lookup table.
		/// </summary>
		// Token: 0x0600FAE0 RID: 64224 RVA: 0x0015CF1F File Offset: 0x0015B11F
		public virtual void SetColorMode(int _arg)
		{
			vtkTexture.vtkTexture_SetColorMode_54(base.GetCppThis(), _arg);
		}

		// Token: 0x0600FAE1 RID: 64225
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexture_SetColorModeToDefault_55(HandleRef pThis);

		/// <summary>
		/// Default: ColorModeToDefault. unsigned char scalars are treated
		/// as colors, and NOT mapped through the lookup table (set with SetLookupTable),
		/// while other kinds of scalars are. ColorModeToDirectScalar extends
		/// ColorModeToDefault such that all integer types are treated as
		/// colors with values in the range 0-255 and floating types are
		/// treated as colors with values in the range 0.0-1.0. Setting
		/// ColorModeToMapScalars means that all scalar data will be mapped
		/// through the lookup table.
		/// </summary>
		// Token: 0x0600FAE2 RID: 64226 RVA: 0x0015CF2F File Offset: 0x0015B12F
		public void SetColorModeToDefault()
		{
			vtkTexture.vtkTexture_SetColorModeToDefault_55(base.GetCppThis());
		}

		// Token: 0x0600FAE3 RID: 64227
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexture_SetColorModeToDirectScalars_56(HandleRef pThis);

		/// <summary>
		/// Default: ColorModeToDefault. unsigned char scalars are treated
		/// as colors, and NOT mapped through the lookup table (set with SetLookupTable),
		/// while other kinds of scalars are. ColorModeToDirectScalar extends
		/// ColorModeToDefault such that all integer types are treated as
		/// colors with values in the range 0-255 and floating types are
		/// treated as colors with values in the range 0.0-1.0. Setting
		/// ColorModeToMapScalars means that all scalar data will be mapped
		/// through the lookup table.
		/// </summary>
		// Token: 0x0600FAE4 RID: 64228 RVA: 0x0015CF3E File Offset: 0x0015B13E
		public void SetColorModeToDirectScalars()
		{
			vtkTexture.vtkTexture_SetColorModeToDirectScalars_56(base.GetCppThis());
		}

		// Token: 0x0600FAE5 RID: 64229
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexture_SetColorModeToMapScalars_57(HandleRef pThis);

		/// <summary>
		/// Default: ColorModeToDefault. unsigned char scalars are treated
		/// as colors, and NOT mapped through the lookup table (set with SetLookupTable),
		/// while other kinds of scalars are. ColorModeToDirectScalar extends
		/// ColorModeToDefault such that all integer types are treated as
		/// colors with values in the range 0-255 and floating types are
		/// treated as colors with values in the range 0.0-1.0. Setting
		/// ColorModeToMapScalars means that all scalar data will be mapped
		/// through the lookup table.
		/// </summary>
		// Token: 0x0600FAE6 RID: 64230 RVA: 0x0015CF4D File Offset: 0x0015B14D
		public void SetColorModeToMapScalars()
		{
			vtkTexture.vtkTexture_SetColorModeToMapScalars_57(base.GetCppThis());
		}

		// Token: 0x0600FAE7 RID: 64231
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexture_SetCubeMap_58(HandleRef pThis, byte val);

		/// <summary>
		/// Is this texture a cube map, if so it needs 6 inputs
		/// one for each side of the cube. You must set this before
		/// connecting the inputs. The inputs must all have the same
		/// size, data type, and depth
		/// </summary>
		// Token: 0x0600FAE8 RID: 64232 RVA: 0x0015CF5C File Offset: 0x0015B15C
		public void SetCubeMap(bool val)
		{
			vtkTexture.vtkTexture_SetCubeMap_58(base.GetCppThis(), val ? (byte)1 : (byte)0);
		}

		// Token: 0x0600FAE9 RID: 64233
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexture_SetEdgeClamp_59(HandleRef pThis, int arg0);

		/// <summary>
		/// Convenience functions to maintain backwards compatibility.
		/// For new code, use the SetWrap API.
		/// </summary>
		// Token: 0x0600FAEA RID: 64234 RVA: 0x0015CF74 File Offset: 0x0015B174
		public virtual void SetEdgeClamp(int arg0)
		{
			vtkTexture.vtkTexture_SetEdgeClamp_59(base.GetCppThis(), arg0);
		}

		// Token: 0x0600FAEB RID: 64235
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexture_SetInterpolate_60(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off linear interpolation of the texture map when rendering.
		/// </summary>
		// Token: 0x0600FAEC RID: 64236 RVA: 0x0015CF84 File Offset: 0x0015B184
		public virtual void SetInterpolate(int _arg)
		{
			vtkTexture.vtkTexture_SetInterpolate_60(base.GetCppThis(), _arg);
		}

		// Token: 0x0600FAED RID: 64237
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexture_SetLookupTable_61(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the lookup table to convert scalars if necessary
		/// </summary>
		// Token: 0x0600FAEE RID: 64238 RVA: 0x0015CF94 File Offset: 0x0015B194
		public void SetLookupTable(vtkScalarsToColors arg0)
		{
			vtkTexture.vtkTexture_SetLookupTable_61(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600FAEF RID: 64239
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexture_SetMaximumAnisotropicFiltering_62(HandleRef pThis, float _arg);

		/// <summary>
		/// Set/Get the maximum anisotropic filtering to use. 1.0 means use no
		/// anisotropic filtering. The default value is 4.0 and a high value would
		/// be 16. This setting is only applied when mipmaps are used. This might
		/// not be supported on all machines.
		/// </summary>
		// Token: 0x0600FAF0 RID: 64240 RVA: 0x0015CFC3 File Offset: 0x0015B1C3
		public virtual void SetMaximumAnisotropicFiltering(float _arg)
		{
			vtkTexture.vtkTexture_SetMaximumAnisotropicFiltering_62(base.GetCppThis(), _arg);
		}

		// Token: 0x0600FAF1 RID: 64241
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexture_SetMipmap_63(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on/off use of mipmaps when rendering.
		/// </summary>
		// Token: 0x0600FAF2 RID: 64242 RVA: 0x0015CFD3 File Offset: 0x0015B1D3
		public virtual void SetMipmap(bool _arg)
		{
			vtkTexture.vtkTexture_SetMipmap_63(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600FAF3 RID: 64243
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexture_SetPremultipliedAlpha_64(HandleRef pThis, byte _arg);

		/// <summary>
		/// Whether the texture colors are premultiplied by alpha.
		/// Initial value is false.
		/// </summary>
		// Token: 0x0600FAF4 RID: 64244 RVA: 0x0015CFEB File Offset: 0x0015B1EB
		public virtual void SetPremultipliedAlpha(bool _arg)
		{
			vtkTexture.vtkTexture_SetPremultipliedAlpha_64(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600FAF5 RID: 64245
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexture_SetQuality_65(HandleRef pThis, int _arg);

		/// <summary>
		/// Force texture quality to 16-bit or 32-bit.
		/// This might not be supported on all machines.
		/// </summary>
		// Token: 0x0600FAF6 RID: 64246 RVA: 0x0015D003 File Offset: 0x0015B203
		public virtual void SetQuality(int _arg)
		{
			vtkTexture.vtkTexture_SetQuality_65(base.GetCppThis(), _arg);
		}

		// Token: 0x0600FAF7 RID: 64247
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexture_SetQualityTo16Bit_66(HandleRef pThis);

		/// <summary>
		/// Force texture quality to 16-bit or 32-bit.
		/// This might not be supported on all machines.
		/// </summary>
		// Token: 0x0600FAF8 RID: 64248 RVA: 0x0015D013 File Offset: 0x0015B213
		public void SetQualityTo16Bit()
		{
			vtkTexture.vtkTexture_SetQualityTo16Bit_66(base.GetCppThis());
		}

		// Token: 0x0600FAF9 RID: 64249
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexture_SetQualityTo32Bit_67(HandleRef pThis);

		/// <summary>
		/// Force texture quality to 16-bit or 32-bit.
		/// This might not be supported on all machines.
		/// </summary>
		// Token: 0x0600FAFA RID: 64250 RVA: 0x0015D022 File Offset: 0x0015B222
		public void SetQualityTo32Bit()
		{
			vtkTexture.vtkTexture_SetQualityTo32Bit_67(base.GetCppThis());
		}

		// Token: 0x0600FAFB RID: 64251
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexture_SetQualityToDefault_68(HandleRef pThis);

		/// <summary>
		/// Force texture quality to 16-bit or 32-bit.
		/// This might not be supported on all machines.
		/// </summary>
		// Token: 0x0600FAFC RID: 64252 RVA: 0x0015D031 File Offset: 0x0015B231
		public void SetQualityToDefault()
		{
			vtkTexture.vtkTexture_SetQualityToDefault_68(base.GetCppThis());
		}

		// Token: 0x0600FAFD RID: 64253
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexture_SetRepeat_69(HandleRef pThis, int r);

		/// <summary>
		/// Convenience functions to maintain backwards compatibility.
		/// For new code, use the SetWrap API.
		/// </summary>
		// Token: 0x0600FAFE RID: 64254 RVA: 0x0015D040 File Offset: 0x0015B240
		public virtual void SetRepeat(int r)
		{
			vtkTexture.vtkTexture_SetRepeat_69(base.GetCppThis(), r);
		}

		// Token: 0x0600FAFF RID: 64255
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexture_SetRestrictPowerOf2ImageSmaller_70(HandleRef pThis, int _arg);

		/// <summary>
		/// When the texture is forced to be a power of 2, the default behavior is
		/// for the "new" image's dimensions to be greater than or equal to with
		/// respects to the original.  Setting RestrictPowerOf2ImageSmaller to be
		/// 1 (or ON) with force the new image's dimensions to be less than or equal
		/// to with respects to the original.
		/// </summary>
		// Token: 0x0600FB00 RID: 64256 RVA: 0x0015D050 File Offset: 0x0015B250
		public virtual void SetRestrictPowerOf2ImageSmaller(int _arg)
		{
			vtkTexture.vtkTexture_SetRestrictPowerOf2ImageSmaller_70(base.GetCppThis(), _arg);
		}

		// Token: 0x0600FB01 RID: 64257
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexture_SetTransform_71(HandleRef pThis, HandleRef transform);

		/// <summary>
		/// Set a transform on the texture which allows one to scale,
		/// rotate and translate the texture.
		/// </summary>
		// Token: 0x0600FB02 RID: 64258 RVA: 0x0015D060 File Offset: 0x0015B260
		public void SetTransform(vtkTransform transform)
		{
			vtkTexture.vtkTexture_SetTransform_71(base.GetCppThis(), (transform == null) ? default(HandleRef) : transform.GetCppThis());
		}

		// Token: 0x0600FB03 RID: 64259
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexture_SetUseSRGBColorSpace_72(HandleRef pThis, byte _arg);

		/// <summary>
		/// Is this texture using the sRGB color space. If you are using a
		/// sRGB framebuffer or window then you probably also want to be
		/// using sRGB color textures for proper handling of gamma and
		/// associated color mixing.
		/// </summary>
		// Token: 0x0600FB04 RID: 64260 RVA: 0x0015D08F File Offset: 0x0015B28F
		public virtual void SetUseSRGBColorSpace(bool _arg)
		{
			vtkTexture.vtkTexture_SetUseSRGBColorSpace_72(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600FB05 RID: 64261
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexture_SetWrap_73(HandleRef pThis, int _arg);

		/// <summary>
		/// Wrap mode for the texture coordinates
		/// Valid values are:
		/// - ClampToEdge
		/// - Repeat
		/// - MirroredRepeat
		/// - ClampToBorder
		/// Initial value is Repeat (as in OpenGL spec)
		///
		/// \note
		/// ClampToBorder is not supported with OpenGL ES &lt;= 3.2.
		/// Wrap will default to ClampToEdge if it is set to ClampToBorder in this case.
		/// </summary>
		// Token: 0x0600FB06 RID: 64262 RVA: 0x0015D0A7 File Offset: 0x0015B2A7
		public virtual void SetWrap(int _arg)
		{
			vtkTexture.vtkTexture_SetWrap_73(base.GetCppThis(), _arg);
		}

		// Token: 0x0600FB07 RID: 64263
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexture_UseSRGBColorSpaceOff_74(HandleRef pThis);

		/// <summary>
		/// Is this texture using the sRGB color space. If you are using a
		/// sRGB framebuffer or window then you probably also want to be
		/// using sRGB color textures for proper handling of gamma and
		/// associated color mixing.
		/// </summary>
		// Token: 0x0600FB08 RID: 64264 RVA: 0x0015D0B7 File Offset: 0x0015B2B7
		public virtual void UseSRGBColorSpaceOff()
		{
			vtkTexture.vtkTexture_UseSRGBColorSpaceOff_74(base.GetCppThis());
		}

		// Token: 0x0600FB09 RID: 64265
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexture_UseSRGBColorSpaceOn_75(HandleRef pThis);

		/// <summary>
		/// Is this texture using the sRGB color space. If you are using a
		/// sRGB framebuffer or window then you probably also want to be
		/// using sRGB color textures for proper handling of gamma and
		/// associated color mixing.
		/// </summary>
		// Token: 0x0600FB0A RID: 64266 RVA: 0x0015D0C6 File Offset: 0x0015B2C6
		public virtual void UseSRGBColorSpaceOn()
		{
			vtkTexture.vtkTexture_UseSRGBColorSpaceOn_75(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001234 RID: 4660
		public new const string MRFullTypeName = "Kitware.VTK.vtkTexture";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001235 RID: 4661
		public new static readonly string MRClassNameKey = "class vtkTexture";

		/// <summary>
		/// Border Color (RGBA). The values can be any valid float value,
		/// if the gpu supports it. Initial value is (0.0f, 0.0f, 0.0f, 0.0f),
		/// as in the OpenGL spec.
		///
		/// \note
		/// This property is ignored for OpenGL ES &lt;= 3.2
		/// </summary>
		// Token: 0x0200058C RID: 1420
		public enum ClampToBorder_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04001237 RID: 4663
			ClampToBorder = 3,
			/// <summary>enum member</summary>
			// Token: 0x04001238 RID: 4664
			ClampToEdge = 0,
			/// <summary>enum member</summary>
			// Token: 0x04001239 RID: 4665
			MirroredRepeat = 2,
			/// <summary>enum member</summary>
			// Token: 0x0400123A RID: 4666
			NumberOfWrapModes = 4,
			/// <summary>enum member</summary>
			// Token: 0x0400123B RID: 4667
			Repeat = 1
		}

		/// <summary>
		/// Used to specify how the texture will blend its RGB and Alpha values
		/// with other textures and the fragment the texture is rendered upon.
		/// </summary>
		// Token: 0x0200058D RID: 1421
		public enum VTKTextureBlendingMode
		{
			/// <summary>enum member</summary>
			// Token: 0x0400123D RID: 4669
			VTK_TEXTURE_BLENDING_MODE_ADD = 3,
			/// <summary>enum member</summary>
			// Token: 0x0400123E RID: 4670
			VTK_TEXTURE_BLENDING_MODE_ADD_SIGNED,
			/// <summary>enum member</summary>
			// Token: 0x0400123F RID: 4671
			VTK_TEXTURE_BLENDING_MODE_INTERPOLATE,
			/// <summary>enum member</summary>
			// Token: 0x04001240 RID: 4672
			VTK_TEXTURE_BLENDING_MODE_MODULATE = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001241 RID: 4673
			VTK_TEXTURE_BLENDING_MODE_NONE = 0,
			/// <summary>enum member</summary>
			// Token: 0x04001242 RID: 4674
			VTK_TEXTURE_BLENDING_MODE_REPLACE,
			/// <summary>enum member</summary>
			// Token: 0x04001243 RID: 4675
			VTK_TEXTURE_BLENDING_MODE_SUBTRACT = 6
		}
	}
}
