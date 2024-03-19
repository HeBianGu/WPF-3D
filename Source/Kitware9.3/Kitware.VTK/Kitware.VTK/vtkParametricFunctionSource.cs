using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkParametricFunctionSource
	/// </summary>
	/// <remarks>
	///    tessellate parametric functions
	///
	/// This class tessellates parametric functions. The user must specify how
	/// many points in the parametric coordinate directions are required (i.e.,
	/// the resolution), and the mode to use to generate scalars.
	///
	/// @par Thanks:
	/// Andrew Maclean andrew.amaclean@gmail.com for creating and contributing
	/// the class.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkParametricFunction
	///
	///
	/// Implementation of parametrics for 1D lines:
	/// vtkParametricSpline
	///
	///
	/// Subclasses of vtkParametricFunction implementing non-orentable surfaces:
	/// vtkParametricBoy vtkParametricCrossCap vtkParametricFigure8Klein
	/// vtkParametricKlein vtkParametricMobius vtkParametricRoman
	///
	///
	/// Subclasses of vtkParametricFunction implementing orientable surfaces:
	/// vtkParametricConicSpiral vtkParametricDini vtkParametricEllipsoid
	/// vtkParametricEnneper vtkParametricRandomHills vtkParametricSuperEllipsoid
	/// vtkParametricSuperToroid vtkParametricTorus
	///
	/// </seealso>
	// Token: 0x02000831 RID: 2097
	public class vtkParametricFunctionSource : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06015B0A RID: 88842 RVA: 0x001E9EBF File Offset: 0x001E80BF
		static vtkParametricFunctionSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParametricFunctionSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParametricFunctionSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06015B0B RID: 88843 RVA: 0x001E9EE7 File Offset: 0x001E80E7
		public vtkParametricFunctionSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06015B0C RID: 88844
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricFunctionSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create a new instance with (50,50,50) points in the (u-v-w) directions.
		/// </summary>
		// Token: 0x06015B0D RID: 88845 RVA: 0x001E9EF8 File Offset: 0x001E80F8
		public new static vtkParametricFunctionSource New()
		{
			vtkParametricFunctionSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricFunctionSource.vtkParametricFunctionSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricFunctionSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Create a new instance with (50,50,50) points in the (u-v-w) directions.
		/// </summary>
		// Token: 0x06015B0E RID: 88846 RVA: 0x001E9F4C File Offset: 0x001E814C
		public vtkParametricFunctionSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkParametricFunctionSource.vtkParametricFunctionSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06015B0F RID: 88847 RVA: 0x001E9F90 File Offset: 0x001E8190
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06015B10 RID: 88848
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunctionSource_GenerateNormalsOff_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the generation of normals. This is on by
		/// default.
		/// Note that this is only applicable to parametric surfaces
		/// whose parametric dimension is 2.
		/// </summary>
		// Token: 0x06015B11 RID: 88849 RVA: 0x001E9F9B File Offset: 0x001E819B
		public virtual void GenerateNormalsOff()
		{
			vtkParametricFunctionSource.vtkParametricFunctionSource_GenerateNormalsOff_01(base.GetCppThis());
		}

		// Token: 0x06015B12 RID: 88850
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunctionSource_GenerateNormalsOn_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the generation of normals. This is on by
		/// default.
		/// Note that this is only applicable to parametric surfaces
		/// whose parametric dimension is 2.
		/// </summary>
		// Token: 0x06015B13 RID: 88851 RVA: 0x001E9FAA File Offset: 0x001E81AA
		public virtual void GenerateNormalsOn()
		{
			vtkParametricFunctionSource.vtkParametricFunctionSource_GenerateNormalsOn_02(base.GetCppThis());
		}

		// Token: 0x06015B14 RID: 88852
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunctionSource_GenerateTextureCoordinatesOff_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the generation of texture coordinates. This is off by
		/// default.
		/// Note that this is only applicable to parametric surfaces
		/// whose parametric dimension is 2.
		/// Note that texturing may fail in some cases.
		/// </summary>
		// Token: 0x06015B15 RID: 88853 RVA: 0x001E9FB9 File Offset: 0x001E81B9
		public virtual void GenerateTextureCoordinatesOff()
		{
			vtkParametricFunctionSource.vtkParametricFunctionSource_GenerateTextureCoordinatesOff_03(base.GetCppThis());
		}

		// Token: 0x06015B16 RID: 88854
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunctionSource_GenerateTextureCoordinatesOn_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the generation of texture coordinates. This is off by
		/// default.
		/// Note that this is only applicable to parametric surfaces
		/// whose parametric dimension is 2.
		/// Note that texturing may fail in some cases.
		/// </summary>
		// Token: 0x06015B17 RID: 88855 RVA: 0x001E9FC8 File Offset: 0x001E81C8
		public virtual void GenerateTextureCoordinatesOn()
		{
			vtkParametricFunctionSource.vtkParametricFunctionSource_GenerateTextureCoordinatesOn_04(base.GetCppThis());
		}

		// Token: 0x06015B18 RID: 88856
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricFunctionSource_GetGenerateNormals_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the generation of normals. This is on by
		/// default.
		/// Note that this is only applicable to parametric surfaces
		/// whose parametric dimension is 2.
		/// </summary>
		// Token: 0x06015B19 RID: 88857 RVA: 0x001E9FD8 File Offset: 0x001E81D8
		public virtual int GetGenerateNormals()
		{
			return vtkParametricFunctionSource.vtkParametricFunctionSource_GetGenerateNormals_05(base.GetCppThis());
		}

		// Token: 0x06015B1A RID: 88858
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricFunctionSource_GetGenerateNormalsMaxValue_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the generation of normals. This is on by
		/// default.
		/// Note that this is only applicable to parametric surfaces
		/// whose parametric dimension is 2.
		/// </summary>
		// Token: 0x06015B1B RID: 88859 RVA: 0x001E9FF8 File Offset: 0x001E81F8
		public virtual int GetGenerateNormalsMaxValue()
		{
			return vtkParametricFunctionSource.vtkParametricFunctionSource_GetGenerateNormalsMaxValue_06(base.GetCppThis());
		}

		// Token: 0x06015B1C RID: 88860
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricFunctionSource_GetGenerateNormalsMinValue_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the generation of normals. This is on by
		/// default.
		/// Note that this is only applicable to parametric surfaces
		/// whose parametric dimension is 2.
		/// </summary>
		// Token: 0x06015B1D RID: 88861 RVA: 0x001EA018 File Offset: 0x001E8218
		public virtual int GetGenerateNormalsMinValue()
		{
			return vtkParametricFunctionSource.vtkParametricFunctionSource_GetGenerateNormalsMinValue_07(base.GetCppThis());
		}

		// Token: 0x06015B1E RID: 88862
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricFunctionSource_GetGenerateTextureCoordinates_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the generation of texture coordinates. This is off by
		/// default.
		/// Note that this is only applicable to parametric surfaces
		/// whose parametric dimension is 2.
		/// Note that texturing may fail in some cases.
		/// </summary>
		// Token: 0x06015B1F RID: 88863 RVA: 0x001EA038 File Offset: 0x001E8238
		public virtual int GetGenerateTextureCoordinates()
		{
			return vtkParametricFunctionSource.vtkParametricFunctionSource_GetGenerateTextureCoordinates_08(base.GetCppThis());
		}

		// Token: 0x06015B20 RID: 88864
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricFunctionSource_GetGenerateTextureCoordinatesMaxValue_09(HandleRef pThis);

		/// <summary>
		/// Set/Get the generation of texture coordinates. This is off by
		/// default.
		/// Note that this is only applicable to parametric surfaces
		/// whose parametric dimension is 2.
		/// Note that texturing may fail in some cases.
		/// </summary>
		// Token: 0x06015B21 RID: 88865 RVA: 0x001EA058 File Offset: 0x001E8258
		public virtual int GetGenerateTextureCoordinatesMaxValue()
		{
			return vtkParametricFunctionSource.vtkParametricFunctionSource_GetGenerateTextureCoordinatesMaxValue_09(base.GetCppThis());
		}

		// Token: 0x06015B22 RID: 88866
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricFunctionSource_GetGenerateTextureCoordinatesMinValue_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the generation of texture coordinates. This is off by
		/// default.
		/// Note that this is only applicable to parametric surfaces
		/// whose parametric dimension is 2.
		/// Note that texturing may fail in some cases.
		/// </summary>
		// Token: 0x06015B23 RID: 88867 RVA: 0x001EA078 File Offset: 0x001E8278
		public virtual int GetGenerateTextureCoordinatesMinValue()
		{
			return vtkParametricFunctionSource.vtkParametricFunctionSource_GetGenerateTextureCoordinatesMinValue_10(base.GetCppThis());
		}

		// Token: 0x06015B24 RID: 88868
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkParametricFunctionSource_GetMTime_11(HandleRef pThis);

		/// <summary>
		/// Return the MTime also considering the parametric function.
		/// </summary>
		// Token: 0x06015B25 RID: 88869 RVA: 0x001EA098 File Offset: 0x001E8298
		public override ulong GetMTime()
		{
			return vtkParametricFunctionSource.vtkParametricFunctionSource_GetMTime_11(base.GetCppThis());
		}

		// Token: 0x06015B26 RID: 88870
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParametricFunctionSource_GetNumberOfGenerationsFromBase_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015B27 RID: 88871 RVA: 0x001EA0B8 File Offset: 0x001E82B8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkParametricFunctionSource.vtkParametricFunctionSource_GetNumberOfGenerationsFromBase_12(base.GetCppThis(), type);
		}

		// Token: 0x06015B28 RID: 88872
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParametricFunctionSource_GetNumberOfGenerationsFromBaseType_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015B29 RID: 88873 RVA: 0x001EA0D8 File Offset: 0x001E82D8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkParametricFunctionSource.vtkParametricFunctionSource_GetNumberOfGenerationsFromBaseType_13(type);
		}

		// Token: 0x06015B2A RID: 88874
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricFunctionSource_GetOutputPointsPrecision_14(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// See the documentation for the vtkAlgorithm::Precision enum for an
		/// explanation of the available precision settings.
		/// </summary>
		// Token: 0x06015B2B RID: 88875 RVA: 0x001EA0F4 File Offset: 0x001E82F4
		public virtual int GetOutputPointsPrecision()
		{
			return vtkParametricFunctionSource.vtkParametricFunctionSource_GetOutputPointsPrecision_14(base.GetCppThis());
		}

		// Token: 0x06015B2C RID: 88876
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricFunctionSource_GetParametricFunction_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the parametric function to use to generate the tessellation.
		/// </summary>
		// Token: 0x06015B2D RID: 88877 RVA: 0x001EA114 File Offset: 0x001E8314
		public virtual vtkParametricFunction GetParametricFunction()
		{
			vtkParametricFunction vtkParametricFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricFunctionSource.vtkParametricFunctionSource_GetParametricFunction_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParametricFunction = (vtkParametricFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParametricFunction.Register(null);
				}
			}
			return vtkParametricFunction;
		}

		// Token: 0x06015B2E RID: 88878
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricFunctionSource_GetScalarMode_16(HandleRef pThis);

		/// <summary>
		/// Get/Set the mode used for the scalar data.
		/// See SCALAR_MODE for a description of the types of scalars generated.
		/// </summary>
		// Token: 0x06015B2F RID: 88879 RVA: 0x001EA184 File Offset: 0x001E8384
		public virtual int GetScalarMode()
		{
			return vtkParametricFunctionSource.vtkParametricFunctionSource_GetScalarMode_16(base.GetCppThis());
		}

		// Token: 0x06015B30 RID: 88880
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricFunctionSource_GetScalarModeMaxValue_17(HandleRef pThis);

		/// <summary>
		/// Get/Set the mode used for the scalar data.
		/// See SCALAR_MODE for a description of the types of scalars generated.
		/// </summary>
		// Token: 0x06015B31 RID: 88881 RVA: 0x001EA1A4 File Offset: 0x001E83A4
		public virtual int GetScalarModeMaxValue()
		{
			return vtkParametricFunctionSource.vtkParametricFunctionSource_GetScalarModeMaxValue_17(base.GetCppThis());
		}

		// Token: 0x06015B32 RID: 88882
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricFunctionSource_GetScalarModeMinValue_18(HandleRef pThis);

		/// <summary>
		/// Get/Set the mode used for the scalar data.
		/// See SCALAR_MODE for a description of the types of scalars generated.
		/// </summary>
		// Token: 0x06015B33 RID: 88883 RVA: 0x001EA1C4 File Offset: 0x001E83C4
		public virtual int GetScalarModeMinValue()
		{
			return vtkParametricFunctionSource.vtkParametricFunctionSource_GetScalarModeMinValue_18(base.GetCppThis());
		}

		// Token: 0x06015B34 RID: 88884
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricFunctionSource_GetUResolution_19(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of subdivisions / tessellations in the u parametric
		/// direction. Note that the number of tessellant points in the u
		/// direction is the UResolution + 1.
		/// </summary>
		// Token: 0x06015B35 RID: 88885 RVA: 0x001EA1E4 File Offset: 0x001E83E4
		public virtual int GetUResolution()
		{
			return vtkParametricFunctionSource.vtkParametricFunctionSource_GetUResolution_19(base.GetCppThis());
		}

		// Token: 0x06015B36 RID: 88886
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricFunctionSource_GetUResolutionMaxValue_20(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of subdivisions / tessellations in the u parametric
		/// direction. Note that the number of tessellant points in the u
		/// direction is the UResolution + 1.
		/// </summary>
		// Token: 0x06015B37 RID: 88887 RVA: 0x001EA204 File Offset: 0x001E8404
		public virtual int GetUResolutionMaxValue()
		{
			return vtkParametricFunctionSource.vtkParametricFunctionSource_GetUResolutionMaxValue_20(base.GetCppThis());
		}

		// Token: 0x06015B38 RID: 88888
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricFunctionSource_GetUResolutionMinValue_21(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of subdivisions / tessellations in the u parametric
		/// direction. Note that the number of tessellant points in the u
		/// direction is the UResolution + 1.
		/// </summary>
		// Token: 0x06015B39 RID: 88889 RVA: 0x001EA224 File Offset: 0x001E8424
		public virtual int GetUResolutionMinValue()
		{
			return vtkParametricFunctionSource.vtkParametricFunctionSource_GetUResolutionMinValue_21(base.GetCppThis());
		}

		// Token: 0x06015B3A RID: 88890
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricFunctionSource_GetVResolution_22(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of subdivisions / tessellations in the v parametric
		/// direction. Note that the number of tessellant points in the v
		/// direction is the VResolution + 1.
		/// </summary>
		// Token: 0x06015B3B RID: 88891 RVA: 0x001EA244 File Offset: 0x001E8444
		public virtual int GetVResolution()
		{
			return vtkParametricFunctionSource.vtkParametricFunctionSource_GetVResolution_22(base.GetCppThis());
		}

		// Token: 0x06015B3C RID: 88892
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricFunctionSource_GetVResolutionMaxValue_23(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of subdivisions / tessellations in the v parametric
		/// direction. Note that the number of tessellant points in the v
		/// direction is the VResolution + 1.
		/// </summary>
		// Token: 0x06015B3D RID: 88893 RVA: 0x001EA264 File Offset: 0x001E8464
		public virtual int GetVResolutionMaxValue()
		{
			return vtkParametricFunctionSource.vtkParametricFunctionSource_GetVResolutionMaxValue_23(base.GetCppThis());
		}

		// Token: 0x06015B3E RID: 88894
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricFunctionSource_GetVResolutionMinValue_24(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of subdivisions / tessellations in the v parametric
		/// direction. Note that the number of tessellant points in the v
		/// direction is the VResolution + 1.
		/// </summary>
		// Token: 0x06015B3F RID: 88895 RVA: 0x001EA284 File Offset: 0x001E8484
		public virtual int GetVResolutionMinValue()
		{
			return vtkParametricFunctionSource.vtkParametricFunctionSource_GetVResolutionMinValue_24(base.GetCppThis());
		}

		// Token: 0x06015B40 RID: 88896
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricFunctionSource_GetWResolution_25(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of subdivisions / tessellations in the w parametric
		/// direction. Note that the number of tessellant points in the w
		/// direction is the WResolution + 1.
		/// </summary>
		// Token: 0x06015B41 RID: 88897 RVA: 0x001EA2A4 File Offset: 0x001E84A4
		public virtual int GetWResolution()
		{
			return vtkParametricFunctionSource.vtkParametricFunctionSource_GetWResolution_25(base.GetCppThis());
		}

		// Token: 0x06015B42 RID: 88898
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricFunctionSource_GetWResolutionMaxValue_26(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of subdivisions / tessellations in the w parametric
		/// direction. Note that the number of tessellant points in the w
		/// direction is the WResolution + 1.
		/// </summary>
		// Token: 0x06015B43 RID: 88899 RVA: 0x001EA2C4 File Offset: 0x001E84C4
		public virtual int GetWResolutionMaxValue()
		{
			return vtkParametricFunctionSource.vtkParametricFunctionSource_GetWResolutionMaxValue_26(base.GetCppThis());
		}

		// Token: 0x06015B44 RID: 88900
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricFunctionSource_GetWResolutionMinValue_27(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of subdivisions / tessellations in the w parametric
		/// direction. Note that the number of tessellant points in the w
		/// direction is the WResolution + 1.
		/// </summary>
		// Token: 0x06015B45 RID: 88901 RVA: 0x001EA2E4 File Offset: 0x001E84E4
		public virtual int GetWResolutionMinValue()
		{
			return vtkParametricFunctionSource.vtkParametricFunctionSource_GetWResolutionMinValue_27(base.GetCppThis());
		}

		// Token: 0x06015B46 RID: 88902
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricFunctionSource_IsA_28(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015B47 RID: 88903 RVA: 0x001EA304 File Offset: 0x001E8504
		public override int IsA(string type)
		{
			return vtkParametricFunctionSource.vtkParametricFunctionSource_IsA_28(base.GetCppThis(), type);
		}

		// Token: 0x06015B48 RID: 88904
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricFunctionSource_IsTypeOf_29([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015B49 RID: 88905 RVA: 0x001EA324 File Offset: 0x001E8524
		public new static int IsTypeOf(string type)
		{
			return vtkParametricFunctionSource.vtkParametricFunctionSource_IsTypeOf_29(type);
		}

		// Token: 0x06015B4A RID: 88906
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricFunctionSource_NewInstance_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015B4B RID: 88907 RVA: 0x001EA340 File Offset: 0x001E8540
		public new vtkParametricFunctionSource NewInstance()
		{
			vtkParametricFunctionSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricFunctionSource.vtkParametricFunctionSource_NewInstance_31(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricFunctionSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06015B4C RID: 88908
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricFunctionSource_SafeDownCast_32(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015B4D RID: 88909 RVA: 0x001EA39C File Offset: 0x001E859C
		public new static vtkParametricFunctionSource SafeDownCast(vtkObjectBase o)
		{
			vtkParametricFunctionSource vtkParametricFunctionSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricFunctionSource.vtkParametricFunctionSource_SafeDownCast_32((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParametricFunctionSource = (vtkParametricFunctionSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParametricFunctionSource.Register(null);
				}
			}
			return vtkParametricFunctionSource;
		}

		// Token: 0x06015B4E RID: 88910
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunctionSource_SetGenerateNormals_33(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the generation of normals. This is on by
		/// default.
		/// Note that this is only applicable to parametric surfaces
		/// whose parametric dimension is 2.
		/// </summary>
		// Token: 0x06015B4F RID: 88911 RVA: 0x001EA41B File Offset: 0x001E861B
		public virtual void SetGenerateNormals(int _arg)
		{
			vtkParametricFunctionSource.vtkParametricFunctionSource_SetGenerateNormals_33(base.GetCppThis(), _arg);
		}

		// Token: 0x06015B50 RID: 88912
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunctionSource_SetGenerateTextureCoordinates_34(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the generation of texture coordinates. This is off by
		/// default.
		/// Note that this is only applicable to parametric surfaces
		/// whose parametric dimension is 2.
		/// Note that texturing may fail in some cases.
		/// </summary>
		// Token: 0x06015B51 RID: 88913 RVA: 0x001EA42B File Offset: 0x001E862B
		public virtual void SetGenerateTextureCoordinates(int _arg)
		{
			vtkParametricFunctionSource.vtkParametricFunctionSource_SetGenerateTextureCoordinates_34(base.GetCppThis(), _arg);
		}

		// Token: 0x06015B52 RID: 88914
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunctionSource_SetOutputPointsPrecision_35(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// See the documentation for the vtkAlgorithm::Precision enum for an
		/// explanation of the available precision settings.
		/// </summary>
		// Token: 0x06015B53 RID: 88915 RVA: 0x001EA43B File Offset: 0x001E863B
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkParametricFunctionSource.vtkParametricFunctionSource_SetOutputPointsPrecision_35(base.GetCppThis(), _arg);
		}

		// Token: 0x06015B54 RID: 88916
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunctionSource_SetParametricFunction_36(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the parametric function to use to generate the tessellation.
		/// </summary>
		// Token: 0x06015B55 RID: 88917 RVA: 0x001EA44C File Offset: 0x001E864C
		public virtual void SetParametricFunction(vtkParametricFunction arg0)
		{
			vtkParametricFunctionSource.vtkParametricFunctionSource_SetParametricFunction_36(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06015B56 RID: 88918
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunctionSource_SetScalarMode_37(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the mode used for the scalar data.
		/// See SCALAR_MODE for a description of the types of scalars generated.
		/// </summary>
		// Token: 0x06015B57 RID: 88919 RVA: 0x001EA47B File Offset: 0x001E867B
		public virtual void SetScalarMode(int _arg)
		{
			vtkParametricFunctionSource.vtkParametricFunctionSource_SetScalarMode_37(base.GetCppThis(), _arg);
		}

		// Token: 0x06015B58 RID: 88920
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunctionSource_SetScalarModeToDistance_38(HandleRef pThis);

		/// <summary>
		/// Get/Set the mode used for the scalar data.
		/// See SCALAR_MODE for a description of the types of scalars generated.
		/// </summary>
		// Token: 0x06015B59 RID: 88921 RVA: 0x001EA48B File Offset: 0x001E868B
		public void SetScalarModeToDistance()
		{
			vtkParametricFunctionSource.vtkParametricFunctionSource_SetScalarModeToDistance_38(base.GetCppThis());
		}

		// Token: 0x06015B5A RID: 88922
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunctionSource_SetScalarModeToFunctionDefined_39(HandleRef pThis);

		/// <summary>
		/// Get/Set the mode used for the scalar data.
		/// See SCALAR_MODE for a description of the types of scalars generated.
		/// </summary>
		// Token: 0x06015B5B RID: 88923 RVA: 0x001EA49A File Offset: 0x001E869A
		public void SetScalarModeToFunctionDefined()
		{
			vtkParametricFunctionSource.vtkParametricFunctionSource_SetScalarModeToFunctionDefined_39(base.GetCppThis());
		}

		// Token: 0x06015B5C RID: 88924
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunctionSource_SetScalarModeToModulus_40(HandleRef pThis);

		/// <summary>
		/// Get/Set the mode used for the scalar data.
		/// See SCALAR_MODE for a description of the types of scalars generated.
		/// </summary>
		// Token: 0x06015B5D RID: 88925 RVA: 0x001EA4A9 File Offset: 0x001E86A9
		public void SetScalarModeToModulus()
		{
			vtkParametricFunctionSource.vtkParametricFunctionSource_SetScalarModeToModulus_40(base.GetCppThis());
		}

		// Token: 0x06015B5E RID: 88926
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunctionSource_SetScalarModeToNone_41(HandleRef pThis);

		/// <summary>
		/// Get/Set the mode used for the scalar data.
		/// See SCALAR_MODE for a description of the types of scalars generated.
		/// </summary>
		// Token: 0x06015B5F RID: 88927 RVA: 0x001EA4B8 File Offset: 0x001E86B8
		public void SetScalarModeToNone()
		{
			vtkParametricFunctionSource.vtkParametricFunctionSource_SetScalarModeToNone_41(base.GetCppThis());
		}

		// Token: 0x06015B60 RID: 88928
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunctionSource_SetScalarModeToPhase_42(HandleRef pThis);

		/// <summary>
		/// Get/Set the mode used for the scalar data.
		/// See SCALAR_MODE for a description of the types of scalars generated.
		/// </summary>
		// Token: 0x06015B61 RID: 88929 RVA: 0x001EA4C7 File Offset: 0x001E86C7
		public void SetScalarModeToPhase()
		{
			vtkParametricFunctionSource.vtkParametricFunctionSource_SetScalarModeToPhase_42(base.GetCppThis());
		}

		// Token: 0x06015B62 RID: 88930
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunctionSource_SetScalarModeToQuadrant_43(HandleRef pThis);

		/// <summary>
		/// Get/Set the mode used for the scalar data.
		/// See SCALAR_MODE for a description of the types of scalars generated.
		/// </summary>
		// Token: 0x06015B63 RID: 88931 RVA: 0x001EA4D6 File Offset: 0x001E86D6
		public void SetScalarModeToQuadrant()
		{
			vtkParametricFunctionSource.vtkParametricFunctionSource_SetScalarModeToQuadrant_43(base.GetCppThis());
		}

		// Token: 0x06015B64 RID: 88932
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunctionSource_SetScalarModeToU_44(HandleRef pThis);

		/// <summary>
		/// Get/Set the mode used for the scalar data.
		/// See SCALAR_MODE for a description of the types of scalars generated.
		/// </summary>
		// Token: 0x06015B65 RID: 88933 RVA: 0x001EA4E5 File Offset: 0x001E86E5
		public void SetScalarModeToU()
		{
			vtkParametricFunctionSource.vtkParametricFunctionSource_SetScalarModeToU_44(base.GetCppThis());
		}

		// Token: 0x06015B66 RID: 88934
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunctionSource_SetScalarModeToU0_45(HandleRef pThis);

		/// <summary>
		/// Get/Set the mode used for the scalar data.
		/// See SCALAR_MODE for a description of the types of scalars generated.
		/// </summary>
		// Token: 0x06015B67 RID: 88935 RVA: 0x001EA4F4 File Offset: 0x001E86F4
		public void SetScalarModeToU0()
		{
			vtkParametricFunctionSource.vtkParametricFunctionSource_SetScalarModeToU0_45(base.GetCppThis());
		}

		// Token: 0x06015B68 RID: 88936
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunctionSource_SetScalarModeToU0V0_46(HandleRef pThis);

		/// <summary>
		/// Get/Set the mode used for the scalar data.
		/// See SCALAR_MODE for a description of the types of scalars generated.
		/// </summary>
		// Token: 0x06015B69 RID: 88937 RVA: 0x001EA503 File Offset: 0x001E8703
		public void SetScalarModeToU0V0()
		{
			vtkParametricFunctionSource.vtkParametricFunctionSource_SetScalarModeToU0V0_46(base.GetCppThis());
		}

		// Token: 0x06015B6A RID: 88938
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunctionSource_SetScalarModeToV_47(HandleRef pThis);

		/// <summary>
		/// Get/Set the mode used for the scalar data.
		/// See SCALAR_MODE for a description of the types of scalars generated.
		/// </summary>
		// Token: 0x06015B6B RID: 88939 RVA: 0x001EA512 File Offset: 0x001E8712
		public void SetScalarModeToV()
		{
			vtkParametricFunctionSource.vtkParametricFunctionSource_SetScalarModeToV_47(base.GetCppThis());
		}

		// Token: 0x06015B6C RID: 88940
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunctionSource_SetScalarModeToV0_48(HandleRef pThis);

		/// <summary>
		/// Get/Set the mode used for the scalar data.
		/// See SCALAR_MODE for a description of the types of scalars generated.
		/// </summary>
		// Token: 0x06015B6D RID: 88941 RVA: 0x001EA521 File Offset: 0x001E8721
		public void SetScalarModeToV0()
		{
			vtkParametricFunctionSource.vtkParametricFunctionSource_SetScalarModeToV0_48(base.GetCppThis());
		}

		// Token: 0x06015B6E RID: 88942
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunctionSource_SetScalarModeToX_49(HandleRef pThis);

		/// <summary>
		/// Get/Set the mode used for the scalar data.
		/// See SCALAR_MODE for a description of the types of scalars generated.
		/// </summary>
		// Token: 0x06015B6F RID: 88943 RVA: 0x001EA530 File Offset: 0x001E8730
		public void SetScalarModeToX()
		{
			vtkParametricFunctionSource.vtkParametricFunctionSource_SetScalarModeToX_49(base.GetCppThis());
		}

		// Token: 0x06015B70 RID: 88944
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunctionSource_SetScalarModeToY_50(HandleRef pThis);

		/// <summary>
		/// Get/Set the mode used for the scalar data.
		/// See SCALAR_MODE for a description of the types of scalars generated.
		/// </summary>
		// Token: 0x06015B71 RID: 88945 RVA: 0x001EA53F File Offset: 0x001E873F
		public void SetScalarModeToY()
		{
			vtkParametricFunctionSource.vtkParametricFunctionSource_SetScalarModeToY_50(base.GetCppThis());
		}

		// Token: 0x06015B72 RID: 88946
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunctionSource_SetScalarModeToZ_51(HandleRef pThis);

		/// <summary>
		/// Get/Set the mode used for the scalar data.
		/// See SCALAR_MODE for a description of the types of scalars generated.
		/// </summary>
		// Token: 0x06015B73 RID: 88947 RVA: 0x001EA54E File Offset: 0x001E874E
		public void SetScalarModeToZ()
		{
			vtkParametricFunctionSource.vtkParametricFunctionSource_SetScalarModeToZ_51(base.GetCppThis());
		}

		// Token: 0x06015B74 RID: 88948
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunctionSource_SetUResolution_52(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the number of subdivisions / tessellations in the u parametric
		/// direction. Note that the number of tessellant points in the u
		/// direction is the UResolution + 1.
		/// </summary>
		// Token: 0x06015B75 RID: 88949 RVA: 0x001EA55D File Offset: 0x001E875D
		public virtual void SetUResolution(int _arg)
		{
			vtkParametricFunctionSource.vtkParametricFunctionSource_SetUResolution_52(base.GetCppThis(), _arg);
		}

		// Token: 0x06015B76 RID: 88950
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunctionSource_SetVResolution_53(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the number of subdivisions / tessellations in the v parametric
		/// direction. Note that the number of tessellant points in the v
		/// direction is the VResolution + 1.
		/// </summary>
		// Token: 0x06015B77 RID: 88951 RVA: 0x001EA56D File Offset: 0x001E876D
		public virtual void SetVResolution(int _arg)
		{
			vtkParametricFunctionSource.vtkParametricFunctionSource_SetVResolution_53(base.GetCppThis(), _arg);
		}

		// Token: 0x06015B78 RID: 88952
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunctionSource_SetWResolution_54(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the number of subdivisions / tessellations in the w parametric
		/// direction. Note that the number of tessellant points in the w
		/// direction is the WResolution + 1.
		/// </summary>
		// Token: 0x06015B79 RID: 88953 RVA: 0x001EA57D File Offset: 0x001E877D
		public virtual void SetWResolution(int _arg)
		{
			vtkParametricFunctionSource.vtkParametricFunctionSource_SetWResolution_54(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018AC RID: 6316
		public new const string MRFullTypeName = "Kitware.VTK.vtkParametricFunctionSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018AD RID: 6317
		public new static readonly string MRClassNameKey = "class vtkParametricFunctionSource";

		/// <summary>
		/// Enumerate the supported scalar generation modes.&lt;br&gt;
		/// SCALAR_NONE - Scalars are not generated (default).&lt;br&gt;
		/// SCALAR_U - The scalar is set to the u-value.&lt;br&gt;
		/// SCALAR_V - The scalar is set to the v-value.&lt;br&gt;
		/// SCALAR_U0 - The scalar is set to 1 if
		/// u = (u_max - u_min)/2 = u_avg, 0 otherwise.&lt;br&gt;
		/// SCALAR_V0 - The scalar is set to 1 if
		/// v = (v_max - v_min)/2 = v_avg, 0 otherwise.&lt;br&gt;
		/// SCALAR_U0V0 - The scalar is
		/// set to 1 if u == u_avg, 2 if v == v_avg,
		/// 3 if u = u_avg &amp;&amp; v = v_avg, 0 otherwise.&lt;br&gt;
		/// SCALAR_MODULUS - The scalar is set to (sqrt(u*u+v*v)),
		/// this is measured relative to (u_avg,v_avg).&lt;br&gt;
		/// SCALAR_PHASE - The scalar is set to (atan2(v,u))
		/// (in degrees, 0 to 360),
		/// this is measured relative to (u_avg,v_avg).&lt;br&gt;
		/// SCALAR_QUADRANT - The scalar is set to 1, 2, 3 or 4.
		/// depending upon the quadrant of the point (u,v).&lt;br&gt;
		/// SCALAR_X - The scalar is set to the x-value.&lt;br&gt;
		/// SCALAR_Y - The scalar is set to the y-value.&lt;br&gt;
		/// SCALAR_Z - The scalar is set to the z-value.&lt;br&gt;
		/// SCALAR_DISTANCE - The scalar is set to (sqrt(x*x+y*y+z*z)).
		/// I.e. distance from the origin.&lt;br&gt;
		/// SCALAR_USER_DEFINED - The scalar is set to the value
		/// returned from EvaluateScalar().&lt;br&gt;
		/// </summary>
		// Token: 0x02000832 RID: 2098
		public enum SCALAR_MODE
		{
			/// <summary>enum member</summary>
			// Token: 0x040018AF RID: 6319
			SCALAR_DISTANCE = 12,
			/// <summary>enum member</summary>
			// Token: 0x040018B0 RID: 6320
			SCALAR_FUNCTION_DEFINED,
			/// <summary>enum member</summary>
			// Token: 0x040018B1 RID: 6321
			SCALAR_MODULUS = 6,
			/// <summary>enum member</summary>
			// Token: 0x040018B2 RID: 6322
			SCALAR_NONE = 0,
			/// <summary>enum member</summary>
			// Token: 0x040018B3 RID: 6323
			SCALAR_PHASE = 7,
			/// <summary>enum member</summary>
			// Token: 0x040018B4 RID: 6324
			SCALAR_QUADRANT,
			/// <summary>enum member</summary>
			// Token: 0x040018B5 RID: 6325
			SCALAR_U = 1,
			/// <summary>enum member</summary>
			// Token: 0x040018B6 RID: 6326
			SCALAR_U0 = 3,
			/// <summary>enum member</summary>
			// Token: 0x040018B7 RID: 6327
			SCALAR_U0V0 = 5,
			/// <summary>enum member</summary>
			// Token: 0x040018B8 RID: 6328
			SCALAR_V = 2,
			/// <summary>enum member</summary>
			// Token: 0x040018B9 RID: 6329
			SCALAR_V0 = 4,
			/// <summary>enum member</summary>
			// Token: 0x040018BA RID: 6330
			SCALAR_X = 9,
			/// <summary>enum member</summary>
			// Token: 0x040018BB RID: 6331
			SCALAR_Y,
			/// <summary>enum member</summary>
			// Token: 0x040018BC RID: 6332
			SCALAR_Z
		}
	}
}
