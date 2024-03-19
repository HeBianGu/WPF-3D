using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRectangularButtonSource
	/// </summary>
	/// <remarks>
	///    create a rectangular button
	///
	/// vtkRectangularButtonSource creates a rectangular shaped button with
	/// texture coordinates suitable for application of a texture map. This
	/// provides a way to make nice looking 3D buttons. The buttons are
	/// represented as vtkPolyData that includes texture coordinates and
	/// normals. The button lies in the x-y plane.
	///
	/// To use this class you must define its width, height and length. These
	/// measurements are all taken with respect to the shoulder of the button.
	/// The shoulder is defined as follows. Imagine a box sitting on the floor.
	/// The distance from the floor to the top of the box is the depth; the other
	/// directions are the length (x-direction) and height (y-direction). In
	/// this particular widget the box can have a smaller bottom than top. The
	/// ratio in size between bottom and top is called the box ratio (by
	/// default=1.0). The ratio of the texture region to the shoulder region
	/// is the texture ratio. And finally the texture region may be out of plane
	/// compared to the shoulder. The texture height ratio controls this.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkButtonSource vtkEllipticalButtonSource
	///
	/// @warning
	/// The button is defined in the x-y plane. Use vtkTransformPolyDataFilter
	/// or vtkGlyph3D to orient the button in a different direction.
	/// </seealso>
	// Token: 0x0200083F RID: 2111
	public class vtkRectangularButtonSource : vtkButtonSource
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06015D14 RID: 89364 RVA: 0x001ECA20 File Offset: 0x001EAC20
		static vtkRectangularButtonSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRectangularButtonSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRectangularButtonSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06015D15 RID: 89365 RVA: 0x001ECA48 File Offset: 0x001EAC48
		public vtkRectangularButtonSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06015D16 RID: 89366
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectangularButtonSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct a circular button with depth 10% of its height.
		/// </summary>
		// Token: 0x06015D17 RID: 89367 RVA: 0x001ECA58 File Offset: 0x001EAC58
		public new static vtkRectangularButtonSource New()
		{
			vtkRectangularButtonSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectangularButtonSource.vtkRectangularButtonSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRectangularButtonSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct a circular button with depth 10% of its height.
		/// </summary>
		// Token: 0x06015D18 RID: 89368 RVA: 0x001ECAAC File Offset: 0x001EACAC
		public vtkRectangularButtonSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRectangularButtonSource.vtkRectangularButtonSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06015D19 RID: 89369 RVA: 0x001ECAF0 File Offset: 0x001EACF0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06015D1A RID: 89370
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRectangularButtonSource_GetBoxRatio_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the ratio of the bottom of the button with the
		/// shoulder region. Numbers greater than one produce buttons
		/// with a wider bottom than shoulder; ratios less than one
		/// produce buttons that have a wider shoulder than bottom.
		/// </summary>
		// Token: 0x06015D1B RID: 89371 RVA: 0x001ECAFC File Offset: 0x001EACFC
		public virtual double GetBoxRatio()
		{
			return vtkRectangularButtonSource.vtkRectangularButtonSource_GetBoxRatio_01(base.GetCppThis());
		}

		// Token: 0x06015D1C RID: 89372
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRectangularButtonSource_GetBoxRatioMaxValue_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the ratio of the bottom of the button with the
		/// shoulder region. Numbers greater than one produce buttons
		/// with a wider bottom than shoulder; ratios less than one
		/// produce buttons that have a wider shoulder than bottom.
		/// </summary>
		// Token: 0x06015D1D RID: 89373 RVA: 0x001ECB1C File Offset: 0x001EAD1C
		public virtual double GetBoxRatioMaxValue()
		{
			return vtkRectangularButtonSource.vtkRectangularButtonSource_GetBoxRatioMaxValue_02(base.GetCppThis());
		}

		// Token: 0x06015D1E RID: 89374
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRectangularButtonSource_GetBoxRatioMinValue_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the ratio of the bottom of the button with the
		/// shoulder region. Numbers greater than one produce buttons
		/// with a wider bottom than shoulder; ratios less than one
		/// produce buttons that have a wider shoulder than bottom.
		/// </summary>
		// Token: 0x06015D1F RID: 89375 RVA: 0x001ECB3C File Offset: 0x001EAD3C
		public virtual double GetBoxRatioMinValue()
		{
			return vtkRectangularButtonSource.vtkRectangularButtonSource_GetBoxRatioMinValue_03(base.GetCppThis());
		}

		// Token: 0x06015D20 RID: 89376
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRectangularButtonSource_GetDepth_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the depth of the button (the z-eliipsoid axis length).
		/// </summary>
		// Token: 0x06015D21 RID: 89377 RVA: 0x001ECB5C File Offset: 0x001EAD5C
		public virtual double GetDepth()
		{
			return vtkRectangularButtonSource.vtkRectangularButtonSource_GetDepth_04(base.GetCppThis());
		}

		// Token: 0x06015D22 RID: 89378
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRectangularButtonSource_GetDepthMaxValue_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the depth of the button (the z-eliipsoid axis length).
		/// </summary>
		// Token: 0x06015D23 RID: 89379 RVA: 0x001ECB7C File Offset: 0x001EAD7C
		public virtual double GetDepthMaxValue()
		{
			return vtkRectangularButtonSource.vtkRectangularButtonSource_GetDepthMaxValue_05(base.GetCppThis());
		}

		// Token: 0x06015D24 RID: 89380
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRectangularButtonSource_GetDepthMinValue_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the depth of the button (the z-eliipsoid axis length).
		/// </summary>
		// Token: 0x06015D25 RID: 89381 RVA: 0x001ECB9C File Offset: 0x001EAD9C
		public virtual double GetDepthMinValue()
		{
			return vtkRectangularButtonSource.vtkRectangularButtonSource_GetDepthMinValue_06(base.GetCppThis());
		}

		// Token: 0x06015D26 RID: 89382
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRectangularButtonSource_GetHeight_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the height of the button.
		/// </summary>
		// Token: 0x06015D27 RID: 89383 RVA: 0x001ECBBC File Offset: 0x001EADBC
		public virtual double GetHeight()
		{
			return vtkRectangularButtonSource.vtkRectangularButtonSource_GetHeight_07(base.GetCppThis());
		}

		// Token: 0x06015D28 RID: 89384
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRectangularButtonSource_GetHeightMaxValue_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the height of the button.
		/// </summary>
		// Token: 0x06015D29 RID: 89385 RVA: 0x001ECBDC File Offset: 0x001EADDC
		public virtual double GetHeightMaxValue()
		{
			return vtkRectangularButtonSource.vtkRectangularButtonSource_GetHeightMaxValue_08(base.GetCppThis());
		}

		// Token: 0x06015D2A RID: 89386
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRectangularButtonSource_GetHeightMinValue_09(HandleRef pThis);

		/// <summary>
		/// Set/Get the height of the button.
		/// </summary>
		// Token: 0x06015D2B RID: 89387 RVA: 0x001ECBFC File Offset: 0x001EADFC
		public virtual double GetHeightMinValue()
		{
			return vtkRectangularButtonSource.vtkRectangularButtonSource_GetHeightMinValue_09(base.GetCppThis());
		}

		// Token: 0x06015D2C RID: 89388
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRectangularButtonSource_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015D2D RID: 89389 RVA: 0x001ECC1C File Offset: 0x001EAE1C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRectangularButtonSource.vtkRectangularButtonSource_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x06015D2E RID: 89390
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRectangularButtonSource_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015D2F RID: 89391 RVA: 0x001ECC3C File Offset: 0x001EAE3C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRectangularButtonSource.vtkRectangularButtonSource_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x06015D30 RID: 89392
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectangularButtonSource_GetOutputPointsPrecision_12(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
		/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
		/// </summary>
		// Token: 0x06015D31 RID: 89393 RVA: 0x001ECC58 File Offset: 0x001EAE58
		public virtual int GetOutputPointsPrecision()
		{
			return vtkRectangularButtonSource.vtkRectangularButtonSource_GetOutputPointsPrecision_12(base.GetCppThis());
		}

		// Token: 0x06015D32 RID: 89394
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRectangularButtonSource_GetTextureHeightRatio_13(HandleRef pThis);

		/// <summary>
		/// Set/Get the ratio of the height of the texture region
		/// to the shoulder height. Values greater than 1.0 yield
		/// convex buttons with the texture region raised above the
		/// shoulder. Values less than 1.0 yield concave buttons with
		/// the texture region below the shoulder.
		/// </summary>
		// Token: 0x06015D33 RID: 89395 RVA: 0x001ECC78 File Offset: 0x001EAE78
		public virtual double GetTextureHeightRatio()
		{
			return vtkRectangularButtonSource.vtkRectangularButtonSource_GetTextureHeightRatio_13(base.GetCppThis());
		}

		// Token: 0x06015D34 RID: 89396
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRectangularButtonSource_GetTextureHeightRatioMaxValue_14(HandleRef pThis);

		/// <summary>
		/// Set/Get the ratio of the height of the texture region
		/// to the shoulder height. Values greater than 1.0 yield
		/// convex buttons with the texture region raised above the
		/// shoulder. Values less than 1.0 yield concave buttons with
		/// the texture region below the shoulder.
		/// </summary>
		// Token: 0x06015D35 RID: 89397 RVA: 0x001ECC98 File Offset: 0x001EAE98
		public virtual double GetTextureHeightRatioMaxValue()
		{
			return vtkRectangularButtonSource.vtkRectangularButtonSource_GetTextureHeightRatioMaxValue_14(base.GetCppThis());
		}

		// Token: 0x06015D36 RID: 89398
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRectangularButtonSource_GetTextureHeightRatioMinValue_15(HandleRef pThis);

		/// <summary>
		/// Set/Get the ratio of the height of the texture region
		/// to the shoulder height. Values greater than 1.0 yield
		/// convex buttons with the texture region raised above the
		/// shoulder. Values less than 1.0 yield concave buttons with
		/// the texture region below the shoulder.
		/// </summary>
		// Token: 0x06015D37 RID: 89399 RVA: 0x001ECCB8 File Offset: 0x001EAEB8
		public virtual double GetTextureHeightRatioMinValue()
		{
			return vtkRectangularButtonSource.vtkRectangularButtonSource_GetTextureHeightRatioMinValue_15(base.GetCppThis());
		}

		// Token: 0x06015D38 RID: 89400
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRectangularButtonSource_GetTextureRatio_16(HandleRef pThis);

		/// <summary>
		/// Set/Get the ratio of the texture region to the
		/// shoulder region. This number must be 0&lt;=tr&lt;=1.
		/// If the texture style is to fit the image, then satisfying
		/// the texture ratio may only be possible in one of the
		/// two directions (length or width) depending on the
		/// dimensions of the texture.
		/// </summary>
		// Token: 0x06015D39 RID: 89401 RVA: 0x001ECCD8 File Offset: 0x001EAED8
		public virtual double GetTextureRatio()
		{
			return vtkRectangularButtonSource.vtkRectangularButtonSource_GetTextureRatio_16(base.GetCppThis());
		}

		// Token: 0x06015D3A RID: 89402
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRectangularButtonSource_GetTextureRatioMaxValue_17(HandleRef pThis);

		/// <summary>
		/// Set/Get the ratio of the texture region to the
		/// shoulder region. This number must be 0&lt;=tr&lt;=1.
		/// If the texture style is to fit the image, then satisfying
		/// the texture ratio may only be possible in one of the
		/// two directions (length or width) depending on the
		/// dimensions of the texture.
		/// </summary>
		// Token: 0x06015D3B RID: 89403 RVA: 0x001ECCF8 File Offset: 0x001EAEF8
		public virtual double GetTextureRatioMaxValue()
		{
			return vtkRectangularButtonSource.vtkRectangularButtonSource_GetTextureRatioMaxValue_17(base.GetCppThis());
		}

		// Token: 0x06015D3C RID: 89404
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRectangularButtonSource_GetTextureRatioMinValue_18(HandleRef pThis);

		/// <summary>
		/// Set/Get the ratio of the texture region to the
		/// shoulder region. This number must be 0&lt;=tr&lt;=1.
		/// If the texture style is to fit the image, then satisfying
		/// the texture ratio may only be possible in one of the
		/// two directions (length or width) depending on the
		/// dimensions of the texture.
		/// </summary>
		// Token: 0x06015D3D RID: 89405 RVA: 0x001ECD18 File Offset: 0x001EAF18
		public virtual double GetTextureRatioMinValue()
		{
			return vtkRectangularButtonSource.vtkRectangularButtonSource_GetTextureRatioMinValue_18(base.GetCppThis());
		}

		// Token: 0x06015D3E RID: 89406
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRectangularButtonSource_GetWidth_19(HandleRef pThis);

		/// <summary>
		/// Set/Get the width of the button.
		/// </summary>
		// Token: 0x06015D3F RID: 89407 RVA: 0x001ECD38 File Offset: 0x001EAF38
		public virtual double GetWidth()
		{
			return vtkRectangularButtonSource.vtkRectangularButtonSource_GetWidth_19(base.GetCppThis());
		}

		// Token: 0x06015D40 RID: 89408
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRectangularButtonSource_GetWidthMaxValue_20(HandleRef pThis);

		/// <summary>
		/// Set/Get the width of the button.
		/// </summary>
		// Token: 0x06015D41 RID: 89409 RVA: 0x001ECD58 File Offset: 0x001EAF58
		public virtual double GetWidthMaxValue()
		{
			return vtkRectangularButtonSource.vtkRectangularButtonSource_GetWidthMaxValue_20(base.GetCppThis());
		}

		// Token: 0x06015D42 RID: 89410
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRectangularButtonSource_GetWidthMinValue_21(HandleRef pThis);

		/// <summary>
		/// Set/Get the width of the button.
		/// </summary>
		// Token: 0x06015D43 RID: 89411 RVA: 0x001ECD78 File Offset: 0x001EAF78
		public virtual double GetWidthMinValue()
		{
			return vtkRectangularButtonSource.vtkRectangularButtonSource_GetWidthMinValue_21(base.GetCppThis());
		}

		// Token: 0x06015D44 RID: 89412
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectangularButtonSource_IsA_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015D45 RID: 89413 RVA: 0x001ECD98 File Offset: 0x001EAF98
		public override int IsA(string type)
		{
			return vtkRectangularButtonSource.vtkRectangularButtonSource_IsA_22(base.GetCppThis(), type);
		}

		// Token: 0x06015D46 RID: 89414
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectangularButtonSource_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015D47 RID: 89415 RVA: 0x001ECDB8 File Offset: 0x001EAFB8
		public new static int IsTypeOf(string type)
		{
			return vtkRectangularButtonSource.vtkRectangularButtonSource_IsTypeOf_23(type);
		}

		// Token: 0x06015D48 RID: 89416
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectangularButtonSource_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015D49 RID: 89417 RVA: 0x001ECDD4 File Offset: 0x001EAFD4
		public new vtkRectangularButtonSource NewInstance()
		{
			vtkRectangularButtonSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectangularButtonSource.vtkRectangularButtonSource_NewInstance_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRectangularButtonSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06015D4A RID: 89418
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectangularButtonSource_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015D4B RID: 89419 RVA: 0x001ECE30 File Offset: 0x001EB030
		public new static vtkRectangularButtonSource SafeDownCast(vtkObjectBase o)
		{
			vtkRectangularButtonSource vtkRectangularButtonSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectangularButtonSource.vtkRectangularButtonSource_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRectangularButtonSource = (vtkRectangularButtonSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRectangularButtonSource.Register(null);
				}
			}
			return vtkRectangularButtonSource;
		}

		// Token: 0x06015D4C RID: 89420
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectangularButtonSource_SetBoxRatio_27(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the ratio of the bottom of the button with the
		/// shoulder region. Numbers greater than one produce buttons
		/// with a wider bottom than shoulder; ratios less than one
		/// produce buttons that have a wider shoulder than bottom.
		/// </summary>
		// Token: 0x06015D4D RID: 89421 RVA: 0x001ECEAF File Offset: 0x001EB0AF
		public virtual void SetBoxRatio(double _arg)
		{
			vtkRectangularButtonSource.vtkRectangularButtonSource_SetBoxRatio_27(base.GetCppThis(), _arg);
		}

		// Token: 0x06015D4E RID: 89422
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectangularButtonSource_SetDepth_28(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the depth of the button (the z-eliipsoid axis length).
		/// </summary>
		// Token: 0x06015D4F RID: 89423 RVA: 0x001ECEBF File Offset: 0x001EB0BF
		public virtual void SetDepth(double _arg)
		{
			vtkRectangularButtonSource.vtkRectangularButtonSource_SetDepth_28(base.GetCppThis(), _arg);
		}

		// Token: 0x06015D50 RID: 89424
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectangularButtonSource_SetHeight_29(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the height of the button.
		/// </summary>
		// Token: 0x06015D51 RID: 89425 RVA: 0x001ECECF File Offset: 0x001EB0CF
		public virtual void SetHeight(double _arg)
		{
			vtkRectangularButtonSource.vtkRectangularButtonSource_SetHeight_29(base.GetCppThis(), _arg);
		}

		// Token: 0x06015D52 RID: 89426
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectangularButtonSource_SetOutputPointsPrecision_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
		/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
		/// </summary>
		// Token: 0x06015D53 RID: 89427 RVA: 0x001ECEDF File Offset: 0x001EB0DF
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkRectangularButtonSource.vtkRectangularButtonSource_SetOutputPointsPrecision_30(base.GetCppThis(), _arg);
		}

		// Token: 0x06015D54 RID: 89428
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectangularButtonSource_SetTextureHeightRatio_31(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the ratio of the height of the texture region
		/// to the shoulder height. Values greater than 1.0 yield
		/// convex buttons with the texture region raised above the
		/// shoulder. Values less than 1.0 yield concave buttons with
		/// the texture region below the shoulder.
		/// </summary>
		// Token: 0x06015D55 RID: 89429 RVA: 0x001ECEEF File Offset: 0x001EB0EF
		public virtual void SetTextureHeightRatio(double _arg)
		{
			vtkRectangularButtonSource.vtkRectangularButtonSource_SetTextureHeightRatio_31(base.GetCppThis(), _arg);
		}

		// Token: 0x06015D56 RID: 89430
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectangularButtonSource_SetTextureRatio_32(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the ratio of the texture region to the
		/// shoulder region. This number must be 0&lt;=tr&lt;=1.
		/// If the texture style is to fit the image, then satisfying
		/// the texture ratio may only be possible in one of the
		/// two directions (length or width) depending on the
		/// dimensions of the texture.
		/// </summary>
		// Token: 0x06015D57 RID: 89431 RVA: 0x001ECEFF File Offset: 0x001EB0FF
		public virtual void SetTextureRatio(double _arg)
		{
			vtkRectangularButtonSource.vtkRectangularButtonSource_SetTextureRatio_32(base.GetCppThis(), _arg);
		}

		// Token: 0x06015D58 RID: 89432
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectangularButtonSource_SetWidth_33(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the width of the button.
		/// </summary>
		// Token: 0x06015D59 RID: 89433 RVA: 0x001ECF0F File Offset: 0x001EB10F
		public virtual void SetWidth(double _arg)
		{
			vtkRectangularButtonSource.vtkRectangularButtonSource_SetWidth_33(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018D1 RID: 6353
		public new const string MRFullTypeName = "Kitware.VTK.vtkRectangularButtonSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018D2 RID: 6354
		public new static readonly string MRClassNameKey = "class vtkRectangularButtonSource";
	}
}
