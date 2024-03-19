using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkEllipticalButtonSource
	/// </summary>
	/// <remarks>
	///    create a ellipsoidal-shaped button
	///
	/// vtkEllipticalButtonSource creates a ellipsoidal shaped button with
	/// texture coordinates suitable for application of a texture map. This
	/// provides a way to make nice looking 3D buttons. The buttons are
	/// represented as vtkPolyData that includes texture coordinates and
	/// normals. The button lies in the x-y plane.
	///
	/// To use this class you must define the major and minor axes lengths of an
	/// ellipsoid (expressed as width (x), height (y) and depth (z)). The button
	/// has a rectangular mesh region in the center with texture coordinates that
	/// range smoothly from (0,1). (This flat region is called the texture
	/// region.) The outer, curved portion of the button (called the shoulder) has
	/// texture coordinates set to a user specified value (by default (0,0).
	/// (This results in coloring the button curve the same color as the (s,t)
	/// location of the texture map.) The resolution in the radial direction, the
	/// texture region, and the shoulder region must also be set. The button can
	/// be moved by specifying an origin.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkButtonSource vtkRectangularButtonSource
	/// </seealso>
	// Token: 0x02000829 RID: 2089
	public class vtkEllipticalButtonSource : vtkButtonSource
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06015938 RID: 88376 RVA: 0x001E7C89 File Offset: 0x001E5E89
		static vtkEllipticalButtonSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEllipticalButtonSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEllipticalButtonSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06015939 RID: 88377 RVA: 0x001E7CB1 File Offset: 0x001E5EB1
		public vtkEllipticalButtonSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601593A RID: 88378
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEllipticalButtonSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct a circular button with depth 10% of its height.
		/// </summary>
		// Token: 0x0601593B RID: 88379 RVA: 0x001E7CC0 File Offset: 0x001E5EC0
		public new static vtkEllipticalButtonSource New()
		{
			vtkEllipticalButtonSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEllipticalButtonSource.vtkEllipticalButtonSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEllipticalButtonSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct a circular button with depth 10% of its height.
		/// </summary>
		// Token: 0x0601593C RID: 88380 RVA: 0x001E7D14 File Offset: 0x001E5F14
		public vtkEllipticalButtonSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkEllipticalButtonSource.vtkEllipticalButtonSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601593D RID: 88381 RVA: 0x001E7D58 File Offset: 0x001E5F58
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601593E RID: 88382
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEllipticalButtonSource_GetCircumferentialResolution_01(HandleRef pThis);

		/// <summary>
		/// Specify the resolution of the button in the circumferential direction.
		/// </summary>
		// Token: 0x0601593F RID: 88383 RVA: 0x001E7D64 File Offset: 0x001E5F64
		public virtual int GetCircumferentialResolution()
		{
			return vtkEllipticalButtonSource.vtkEllipticalButtonSource_GetCircumferentialResolution_01(base.GetCppThis());
		}

		// Token: 0x06015940 RID: 88384
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEllipticalButtonSource_GetCircumferentialResolutionMaxValue_02(HandleRef pThis);

		/// <summary>
		/// Specify the resolution of the button in the circumferential direction.
		/// </summary>
		// Token: 0x06015941 RID: 88385 RVA: 0x001E7D84 File Offset: 0x001E5F84
		public virtual int GetCircumferentialResolutionMaxValue()
		{
			return vtkEllipticalButtonSource.vtkEllipticalButtonSource_GetCircumferentialResolutionMaxValue_02(base.GetCppThis());
		}

		// Token: 0x06015942 RID: 88386
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEllipticalButtonSource_GetCircumferentialResolutionMinValue_03(HandleRef pThis);

		/// <summary>
		/// Specify the resolution of the button in the circumferential direction.
		/// </summary>
		// Token: 0x06015943 RID: 88387 RVA: 0x001E7DA4 File Offset: 0x001E5FA4
		public virtual int GetCircumferentialResolutionMinValue()
		{
			return vtkEllipticalButtonSource.vtkEllipticalButtonSource_GetCircumferentialResolutionMinValue_03(base.GetCppThis());
		}

		// Token: 0x06015944 RID: 88388
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkEllipticalButtonSource_GetDepth_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the depth of the button (the z-eliipsoid axis length).
		/// </summary>
		// Token: 0x06015945 RID: 88389 RVA: 0x001E7DC4 File Offset: 0x001E5FC4
		public virtual double GetDepth()
		{
			return vtkEllipticalButtonSource.vtkEllipticalButtonSource_GetDepth_04(base.GetCppThis());
		}

		// Token: 0x06015946 RID: 88390
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkEllipticalButtonSource_GetDepthMaxValue_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the depth of the button (the z-eliipsoid axis length).
		/// </summary>
		// Token: 0x06015947 RID: 88391 RVA: 0x001E7DE4 File Offset: 0x001E5FE4
		public virtual double GetDepthMaxValue()
		{
			return vtkEllipticalButtonSource.vtkEllipticalButtonSource_GetDepthMaxValue_05(base.GetCppThis());
		}

		// Token: 0x06015948 RID: 88392
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkEllipticalButtonSource_GetDepthMinValue_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the depth of the button (the z-eliipsoid axis length).
		/// </summary>
		// Token: 0x06015949 RID: 88393 RVA: 0x001E7E04 File Offset: 0x001E6004
		public virtual double GetDepthMinValue()
		{
			return vtkEllipticalButtonSource.vtkEllipticalButtonSource_GetDepthMinValue_06(base.GetCppThis());
		}

		// Token: 0x0601594A RID: 88394
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkEllipticalButtonSource_GetHeight_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the height of the button (the y-ellipsoid axis length * 2).
		/// </summary>
		// Token: 0x0601594B RID: 88395 RVA: 0x001E7E24 File Offset: 0x001E6024
		public virtual double GetHeight()
		{
			return vtkEllipticalButtonSource.vtkEllipticalButtonSource_GetHeight_07(base.GetCppThis());
		}

		// Token: 0x0601594C RID: 88396
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkEllipticalButtonSource_GetHeightMaxValue_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the height of the button (the y-ellipsoid axis length * 2).
		/// </summary>
		// Token: 0x0601594D RID: 88397 RVA: 0x001E7E44 File Offset: 0x001E6044
		public virtual double GetHeightMaxValue()
		{
			return vtkEllipticalButtonSource.vtkEllipticalButtonSource_GetHeightMaxValue_08(base.GetCppThis());
		}

		// Token: 0x0601594E RID: 88398
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkEllipticalButtonSource_GetHeightMinValue_09(HandleRef pThis);

		/// <summary>
		/// Set/Get the height of the button (the y-ellipsoid axis length * 2).
		/// </summary>
		// Token: 0x0601594F RID: 88399 RVA: 0x001E7E64 File Offset: 0x001E6064
		public virtual double GetHeightMinValue()
		{
			return vtkEllipticalButtonSource.vtkEllipticalButtonSource_GetHeightMinValue_09(base.GetCppThis());
		}

		// Token: 0x06015950 RID: 88400
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEllipticalButtonSource_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015951 RID: 88401 RVA: 0x001E7E84 File Offset: 0x001E6084
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkEllipticalButtonSource.vtkEllipticalButtonSource_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x06015952 RID: 88402
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEllipticalButtonSource_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015953 RID: 88403 RVA: 0x001E7EA4 File Offset: 0x001E60A4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkEllipticalButtonSource.vtkEllipticalButtonSource_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x06015954 RID: 88404
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEllipticalButtonSource_GetOutputPointsPrecision_12(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
		/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
		/// </summary>
		// Token: 0x06015955 RID: 88405 RVA: 0x001E7EC0 File Offset: 0x001E60C0
		public virtual int GetOutputPointsPrecision()
		{
			return vtkEllipticalButtonSource.vtkEllipticalButtonSource_GetOutputPointsPrecision_12(base.GetCppThis());
		}

		// Token: 0x06015956 RID: 88406
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkEllipticalButtonSource_GetRadialRatio_13(HandleRef pThis);

		/// <summary>
		/// Set/Get the radial ratio. This is the measure of the radius of the
		/// outer ellipsoid to the inner ellipsoid of the button. The outer
		/// ellipsoid is the boundary of the button defined by the height and
		/// width. The inner ellipsoid circumscribes the texture region. Larger
		/// RadialRatio's cause the button to be more rounded (and the texture
		/// region to be smaller); smaller ratios produce sharply curved shoulders
		/// with a larger texture region.
		/// </summary>
		// Token: 0x06015957 RID: 88407 RVA: 0x001E7EE0 File Offset: 0x001E60E0
		public virtual double GetRadialRatio()
		{
			return vtkEllipticalButtonSource.vtkEllipticalButtonSource_GetRadialRatio_13(base.GetCppThis());
		}

		// Token: 0x06015958 RID: 88408
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkEllipticalButtonSource_GetRadialRatioMaxValue_14(HandleRef pThis);

		/// <summary>
		/// Set/Get the radial ratio. This is the measure of the radius of the
		/// outer ellipsoid to the inner ellipsoid of the button. The outer
		/// ellipsoid is the boundary of the button defined by the height and
		/// width. The inner ellipsoid circumscribes the texture region. Larger
		/// RadialRatio's cause the button to be more rounded (and the texture
		/// region to be smaller); smaller ratios produce sharply curved shoulders
		/// with a larger texture region.
		/// </summary>
		// Token: 0x06015959 RID: 88409 RVA: 0x001E7F00 File Offset: 0x001E6100
		public virtual double GetRadialRatioMaxValue()
		{
			return vtkEllipticalButtonSource.vtkEllipticalButtonSource_GetRadialRatioMaxValue_14(base.GetCppThis());
		}

		// Token: 0x0601595A RID: 88410
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkEllipticalButtonSource_GetRadialRatioMinValue_15(HandleRef pThis);

		/// <summary>
		/// Set/Get the radial ratio. This is the measure of the radius of the
		/// outer ellipsoid to the inner ellipsoid of the button. The outer
		/// ellipsoid is the boundary of the button defined by the height and
		/// width. The inner ellipsoid circumscribes the texture region. Larger
		/// RadialRatio's cause the button to be more rounded (and the texture
		/// region to be smaller); smaller ratios produce sharply curved shoulders
		/// with a larger texture region.
		/// </summary>
		// Token: 0x0601595B RID: 88411 RVA: 0x001E7F20 File Offset: 0x001E6120
		public virtual double GetRadialRatioMinValue()
		{
			return vtkEllipticalButtonSource.vtkEllipticalButtonSource_GetRadialRatioMinValue_15(base.GetCppThis());
		}

		// Token: 0x0601595C RID: 88412
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEllipticalButtonSource_GetShoulderResolution_16(HandleRef pThis);

		/// <summary>
		/// Specify the resolution of the texture in the radial direction in the
		/// shoulder region.
		/// </summary>
		// Token: 0x0601595D RID: 88413 RVA: 0x001E7F40 File Offset: 0x001E6140
		public virtual int GetShoulderResolution()
		{
			return vtkEllipticalButtonSource.vtkEllipticalButtonSource_GetShoulderResolution_16(base.GetCppThis());
		}

		// Token: 0x0601595E RID: 88414
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEllipticalButtonSource_GetShoulderResolutionMaxValue_17(HandleRef pThis);

		/// <summary>
		/// Specify the resolution of the texture in the radial direction in the
		/// shoulder region.
		/// </summary>
		// Token: 0x0601595F RID: 88415 RVA: 0x001E7F60 File Offset: 0x001E6160
		public virtual int GetShoulderResolutionMaxValue()
		{
			return vtkEllipticalButtonSource.vtkEllipticalButtonSource_GetShoulderResolutionMaxValue_17(base.GetCppThis());
		}

		// Token: 0x06015960 RID: 88416
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEllipticalButtonSource_GetShoulderResolutionMinValue_18(HandleRef pThis);

		/// <summary>
		/// Specify the resolution of the texture in the radial direction in the
		/// shoulder region.
		/// </summary>
		// Token: 0x06015961 RID: 88417 RVA: 0x001E7F80 File Offset: 0x001E6180
		public virtual int GetShoulderResolutionMinValue()
		{
			return vtkEllipticalButtonSource.vtkEllipticalButtonSource_GetShoulderResolutionMinValue_18(base.GetCppThis());
		}

		// Token: 0x06015962 RID: 88418
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEllipticalButtonSource_GetTextureResolution_19(HandleRef pThis);

		/// <summary>
		/// Specify the resolution of the texture in the radial direction in the
		/// texture region.
		/// </summary>
		// Token: 0x06015963 RID: 88419 RVA: 0x001E7FA0 File Offset: 0x001E61A0
		public virtual int GetTextureResolution()
		{
			return vtkEllipticalButtonSource.vtkEllipticalButtonSource_GetTextureResolution_19(base.GetCppThis());
		}

		// Token: 0x06015964 RID: 88420
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEllipticalButtonSource_GetTextureResolutionMaxValue_20(HandleRef pThis);

		/// <summary>
		/// Specify the resolution of the texture in the radial direction in the
		/// texture region.
		/// </summary>
		// Token: 0x06015965 RID: 88421 RVA: 0x001E7FC0 File Offset: 0x001E61C0
		public virtual int GetTextureResolutionMaxValue()
		{
			return vtkEllipticalButtonSource.vtkEllipticalButtonSource_GetTextureResolutionMaxValue_20(base.GetCppThis());
		}

		// Token: 0x06015966 RID: 88422
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEllipticalButtonSource_GetTextureResolutionMinValue_21(HandleRef pThis);

		/// <summary>
		/// Specify the resolution of the texture in the radial direction in the
		/// texture region.
		/// </summary>
		// Token: 0x06015967 RID: 88423 RVA: 0x001E7FE0 File Offset: 0x001E61E0
		public virtual int GetTextureResolutionMinValue()
		{
			return vtkEllipticalButtonSource.vtkEllipticalButtonSource_GetTextureResolutionMinValue_21(base.GetCppThis());
		}

		// Token: 0x06015968 RID: 88424
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkEllipticalButtonSource_GetWidth_22(HandleRef pThis);

		/// <summary>
		/// Set/Get the width of the button (the x-ellipsoid axis length * 2).
		/// </summary>
		// Token: 0x06015969 RID: 88425 RVA: 0x001E8000 File Offset: 0x001E6200
		public virtual double GetWidth()
		{
			return vtkEllipticalButtonSource.vtkEllipticalButtonSource_GetWidth_22(base.GetCppThis());
		}

		// Token: 0x0601596A RID: 88426
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkEllipticalButtonSource_GetWidthMaxValue_23(HandleRef pThis);

		/// <summary>
		/// Set/Get the width of the button (the x-ellipsoid axis length * 2).
		/// </summary>
		// Token: 0x0601596B RID: 88427 RVA: 0x001E8020 File Offset: 0x001E6220
		public virtual double GetWidthMaxValue()
		{
			return vtkEllipticalButtonSource.vtkEllipticalButtonSource_GetWidthMaxValue_23(base.GetCppThis());
		}

		// Token: 0x0601596C RID: 88428
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkEllipticalButtonSource_GetWidthMinValue_24(HandleRef pThis);

		/// <summary>
		/// Set/Get the width of the button (the x-ellipsoid axis length * 2).
		/// </summary>
		// Token: 0x0601596D RID: 88429 RVA: 0x001E8040 File Offset: 0x001E6240
		public virtual double GetWidthMinValue()
		{
			return vtkEllipticalButtonSource.vtkEllipticalButtonSource_GetWidthMinValue_24(base.GetCppThis());
		}

		// Token: 0x0601596E RID: 88430
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEllipticalButtonSource_IsA_25(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601596F RID: 88431 RVA: 0x001E8060 File Offset: 0x001E6260
		public override int IsA(string type)
		{
			return vtkEllipticalButtonSource.vtkEllipticalButtonSource_IsA_25(base.GetCppThis(), type);
		}

		// Token: 0x06015970 RID: 88432
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEllipticalButtonSource_IsTypeOf_26([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015971 RID: 88433 RVA: 0x001E8080 File Offset: 0x001E6280
		public new static int IsTypeOf(string type)
		{
			return vtkEllipticalButtonSource.vtkEllipticalButtonSource_IsTypeOf_26(type);
		}

		// Token: 0x06015972 RID: 88434
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEllipticalButtonSource_NewInstance_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015973 RID: 88435 RVA: 0x001E809C File Offset: 0x001E629C
		public new vtkEllipticalButtonSource NewInstance()
		{
			vtkEllipticalButtonSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEllipticalButtonSource.vtkEllipticalButtonSource_NewInstance_28(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEllipticalButtonSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06015974 RID: 88436
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEllipticalButtonSource_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015975 RID: 88437 RVA: 0x001E80F8 File Offset: 0x001E62F8
		public new static vtkEllipticalButtonSource SafeDownCast(vtkObjectBase o)
		{
			vtkEllipticalButtonSource vtkEllipticalButtonSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEllipticalButtonSource.vtkEllipticalButtonSource_SafeDownCast_29((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEllipticalButtonSource = (vtkEllipticalButtonSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEllipticalButtonSource.Register(null);
				}
			}
			return vtkEllipticalButtonSource;
		}

		// Token: 0x06015976 RID: 88438
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEllipticalButtonSource_SetCircumferentialResolution_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the resolution of the button in the circumferential direction.
		/// </summary>
		// Token: 0x06015977 RID: 88439 RVA: 0x001E8177 File Offset: 0x001E6377
		public virtual void SetCircumferentialResolution(int _arg)
		{
			vtkEllipticalButtonSource.vtkEllipticalButtonSource_SetCircumferentialResolution_30(base.GetCppThis(), _arg);
		}

		// Token: 0x06015978 RID: 88440
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEllipticalButtonSource_SetDepth_31(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the depth of the button (the z-eliipsoid axis length).
		/// </summary>
		// Token: 0x06015979 RID: 88441 RVA: 0x001E8187 File Offset: 0x001E6387
		public virtual void SetDepth(double _arg)
		{
			vtkEllipticalButtonSource.vtkEllipticalButtonSource_SetDepth_31(base.GetCppThis(), _arg);
		}

		// Token: 0x0601597A RID: 88442
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEllipticalButtonSource_SetHeight_32(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the height of the button (the y-ellipsoid axis length * 2).
		/// </summary>
		// Token: 0x0601597B RID: 88443 RVA: 0x001E8197 File Offset: 0x001E6397
		public virtual void SetHeight(double _arg)
		{
			vtkEllipticalButtonSource.vtkEllipticalButtonSource_SetHeight_32(base.GetCppThis(), _arg);
		}

		// Token: 0x0601597C RID: 88444
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEllipticalButtonSource_SetOutputPointsPrecision_33(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
		/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
		/// </summary>
		// Token: 0x0601597D RID: 88445 RVA: 0x001E81A7 File Offset: 0x001E63A7
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkEllipticalButtonSource.vtkEllipticalButtonSource_SetOutputPointsPrecision_33(base.GetCppThis(), _arg);
		}

		// Token: 0x0601597E RID: 88446
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEllipticalButtonSource_SetRadialRatio_34(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the radial ratio. This is the measure of the radius of the
		/// outer ellipsoid to the inner ellipsoid of the button. The outer
		/// ellipsoid is the boundary of the button defined by the height and
		/// width. The inner ellipsoid circumscribes the texture region. Larger
		/// RadialRatio's cause the button to be more rounded (and the texture
		/// region to be smaller); smaller ratios produce sharply curved shoulders
		/// with a larger texture region.
		/// </summary>
		// Token: 0x0601597F RID: 88447 RVA: 0x001E81B7 File Offset: 0x001E63B7
		public virtual void SetRadialRatio(double _arg)
		{
			vtkEllipticalButtonSource.vtkEllipticalButtonSource_SetRadialRatio_34(base.GetCppThis(), _arg);
		}

		// Token: 0x06015980 RID: 88448
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEllipticalButtonSource_SetShoulderResolution_35(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the resolution of the texture in the radial direction in the
		/// shoulder region.
		/// </summary>
		// Token: 0x06015981 RID: 88449 RVA: 0x001E81C7 File Offset: 0x001E63C7
		public virtual void SetShoulderResolution(int _arg)
		{
			vtkEllipticalButtonSource.vtkEllipticalButtonSource_SetShoulderResolution_35(base.GetCppThis(), _arg);
		}

		// Token: 0x06015982 RID: 88450
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEllipticalButtonSource_SetTextureResolution_36(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the resolution of the texture in the radial direction in the
		/// texture region.
		/// </summary>
		// Token: 0x06015983 RID: 88451 RVA: 0x001E81D7 File Offset: 0x001E63D7
		public virtual void SetTextureResolution(int _arg)
		{
			vtkEllipticalButtonSource.vtkEllipticalButtonSource_SetTextureResolution_36(base.GetCppThis(), _arg);
		}

		// Token: 0x06015984 RID: 88452
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEllipticalButtonSource_SetWidth_37(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the width of the button (the x-ellipsoid axis length * 2).
		/// </summary>
		// Token: 0x06015985 RID: 88453 RVA: 0x001E81E7 File Offset: 0x001E63E7
		public virtual void SetWidth(double _arg)
		{
			vtkEllipticalButtonSource.vtkEllipticalButtonSource_SetWidth_37(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400189C RID: 6300
		public new const string MRFullTypeName = "Kitware.VTK.vtkEllipticalButtonSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400189D RID: 6301
		public new static readonly string MRClassNameKey = "class vtkEllipticalButtonSource";
	}
}
