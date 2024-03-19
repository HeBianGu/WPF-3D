using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageToPolyDataFilter
	/// </summary>
	/// <remarks>
	///    generate linear primitives (vtkPolyData) from an image
	///
	/// vtkImageToPolyDataFilter converts raster data (i.e., an image) into
	/// polygonal data (i.e., quads or n-sided polygons), with each polygon
	/// assigned a constant color. This is useful for writers that generate vector
	/// formats (i.e., CGM or PostScript). To use this filter, you specify how to
	/// quantize the color (or whether to use an image with a lookup table), and
	/// what style the output should be. The output is always polygons, but the
	/// choice is n x m quads (where n and m define the input image dimensions)
	/// "Pixelize" option; arbitrary polygons "Polygonalize" option; or variable
	/// number of quads of constant color generated along scan lines "RunLength"
	/// option.
	///
	/// The algorithm quantizes color in order to create coherent regions that the
	/// polygons can represent with good compression. By default, the input image
	/// is quantized to 256 colors using a 3-3-2 bits for red-green-blue. However,
	/// you can also supply a single component image and a lookup table, with the
	/// single component assumed to be an index into the table.  (Note: a quantized
	/// image can be generated with the filter vtkImageQuantizeRGBToIndex.) The
	/// number of colors on output is equal to the number of colors in the input
	/// lookup table (or 256 if the built in linear ramp is used).
	///
	/// The output of the filter is polygons with a single color per polygon cell.
	/// If the output style is set to "Polygonalize", the polygons may have an
	/// large number of points (bounded by something like 2*(n+m)); and the
	/// polygon may not be convex which may cause rendering problems on some
	/// systems (use vtkTriangleFilter). Otherwise, each polygon will have four
	/// vertices. The output also contains scalar data defining RGB color in
	/// unsigned char form.
	///
	/// @warning
	/// The input linear lookup table must
	/// be of the form of 3-component unsigned char.
	///
	/// @warning
	/// This filter defines constant cell colors. If you have a plotting
	/// device that supports Gouraud shading (linear interpolation of color), then
	/// superior algorithms are available for generating polygons from images.
	///
	/// @warning
	/// Note that many plotting devices/formats support only a limited number of
	/// colors.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkCGMWriter vtkImageQuantizeRGBToIndex vtkTriangleFilter
	/// </seealso>
	// Token: 0x0200060E RID: 1550
	public class vtkImageToPolyDataFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06010D2A RID: 68906 RVA: 0x00177628 File Offset: 0x00175828
		static vtkImageToPolyDataFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageToPolyDataFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageToPolyDataFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06010D2B RID: 68907 RVA: 0x00177650 File Offset: 0x00175850
		public vtkImageToPolyDataFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06010D2C RID: 68908
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageToPolyDataFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate object with initial number of colors 256.
		/// </summary>
		// Token: 0x06010D2D RID: 68909 RVA: 0x00177660 File Offset: 0x00175860
		public new static vtkImageToPolyDataFilter New()
		{
			vtkImageToPolyDataFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageToPolyDataFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate object with initial number of colors 256.
		/// </summary>
		// Token: 0x06010D2E RID: 68910 RVA: 0x001776B4 File Offset: 0x001758B4
		public vtkImageToPolyDataFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010D2F RID: 68911 RVA: 0x001776F8 File Offset: 0x001758F8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06010D30 RID: 68912
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageToPolyDataFilter_DecimationOff_01(HandleRef pThis);

		/// <summary>
		/// Turn on/off whether the final polygons should be decimated.
		/// whether to smooth boundaries.
		/// </summary>
		// Token: 0x06010D31 RID: 68913 RVA: 0x00177703 File Offset: 0x00175903
		public virtual void DecimationOff()
		{
			vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_DecimationOff_01(base.GetCppThis());
		}

		// Token: 0x06010D32 RID: 68914
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageToPolyDataFilter_DecimationOn_02(HandleRef pThis);

		/// <summary>
		/// Turn on/off whether the final polygons should be decimated.
		/// whether to smooth boundaries.
		/// </summary>
		// Token: 0x06010D33 RID: 68915 RVA: 0x00177712 File Offset: 0x00175912
		public virtual void DecimationOn()
		{
			vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_DecimationOn_02(base.GetCppThis());
		}

		// Token: 0x06010D34 RID: 68916
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageToPolyDataFilter_GetColorMode_03(HandleRef pThis);

		/// <summary>
		/// Specify how to quantize color.
		/// </summary>
		// Token: 0x06010D35 RID: 68917 RVA: 0x00177724 File Offset: 0x00175924
		public virtual int GetColorMode()
		{
			return vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_GetColorMode_03(base.GetCppThis());
		}

		// Token: 0x06010D36 RID: 68918
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageToPolyDataFilter_GetColorModeMaxValue_04(HandleRef pThis);

		/// <summary>
		/// Specify how to quantize color.
		/// </summary>
		// Token: 0x06010D37 RID: 68919 RVA: 0x00177744 File Offset: 0x00175944
		public virtual int GetColorModeMaxValue()
		{
			return vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_GetColorModeMaxValue_04(base.GetCppThis());
		}

		// Token: 0x06010D38 RID: 68920
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageToPolyDataFilter_GetColorModeMinValue_05(HandleRef pThis);

		/// <summary>
		/// Specify how to quantize color.
		/// </summary>
		// Token: 0x06010D39 RID: 68921 RVA: 0x00177764 File Offset: 0x00175964
		public virtual int GetColorModeMinValue()
		{
			return vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_GetColorModeMinValue_05(base.GetCppThis());
		}

		// Token: 0x06010D3A RID: 68922
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageToPolyDataFilter_GetDecimation_06(HandleRef pThis);

		/// <summary>
		/// Turn on/off whether the final polygons should be decimated.
		/// whether to smooth boundaries.
		/// </summary>
		// Token: 0x06010D3B RID: 68923 RVA: 0x00177784 File Offset: 0x00175984
		public virtual int GetDecimation()
		{
			return vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_GetDecimation_06(base.GetCppThis());
		}

		// Token: 0x06010D3C RID: 68924
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageToPolyDataFilter_GetDecimationError_07(HandleRef pThis);

		/// <summary>
		/// Specify the error to use for decimation (if decimation is on).
		/// The error is an absolute number--the image spacing and
		/// dimensions are used to create points so the error should be
		/// consistent with the image size.
		/// </summary>
		// Token: 0x06010D3D RID: 68925 RVA: 0x001777A4 File Offset: 0x001759A4
		public virtual double GetDecimationError()
		{
			return vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_GetDecimationError_07(base.GetCppThis());
		}

		// Token: 0x06010D3E RID: 68926
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageToPolyDataFilter_GetDecimationErrorMaxValue_08(HandleRef pThis);

		/// <summary>
		/// Specify the error to use for decimation (if decimation is on).
		/// The error is an absolute number--the image spacing and
		/// dimensions are used to create points so the error should be
		/// consistent with the image size.
		/// </summary>
		// Token: 0x06010D3F RID: 68927 RVA: 0x001777C4 File Offset: 0x001759C4
		public virtual double GetDecimationErrorMaxValue()
		{
			return vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_GetDecimationErrorMaxValue_08(base.GetCppThis());
		}

		// Token: 0x06010D40 RID: 68928
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageToPolyDataFilter_GetDecimationErrorMinValue_09(HandleRef pThis);

		/// <summary>
		/// Specify the error to use for decimation (if decimation is on).
		/// The error is an absolute number--the image spacing and
		/// dimensions are used to create points so the error should be
		/// consistent with the image size.
		/// </summary>
		// Token: 0x06010D41 RID: 68929 RVA: 0x001777E4 File Offset: 0x001759E4
		public virtual double GetDecimationErrorMinValue()
		{
			return vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_GetDecimationErrorMinValue_09(base.GetCppThis());
		}

		// Token: 0x06010D42 RID: 68930
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageToPolyDataFilter_GetError_10(HandleRef pThis);

		/// <summary>
		/// Specify the error value between two colors where the colors are
		/// considered the same. Only use this if the color mode uses the
		/// default 256 table.
		/// </summary>
		// Token: 0x06010D43 RID: 68931 RVA: 0x00177804 File Offset: 0x00175A04
		public virtual int GetError()
		{
			return vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_GetError_10(base.GetCppThis());
		}

		// Token: 0x06010D44 RID: 68932
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageToPolyDataFilter_GetErrorMaxValue_11(HandleRef pThis);

		/// <summary>
		/// Specify the error value between two colors where the colors are
		/// considered the same. Only use this if the color mode uses the
		/// default 256 table.
		/// </summary>
		// Token: 0x06010D45 RID: 68933 RVA: 0x00177824 File Offset: 0x00175A24
		public virtual int GetErrorMaxValue()
		{
			return vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_GetErrorMaxValue_11(base.GetCppThis());
		}

		// Token: 0x06010D46 RID: 68934
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageToPolyDataFilter_GetErrorMinValue_12(HandleRef pThis);

		/// <summary>
		/// Specify the error value between two colors where the colors are
		/// considered the same. Only use this if the color mode uses the
		/// default 256 table.
		/// </summary>
		// Token: 0x06010D47 RID: 68935 RVA: 0x00177844 File Offset: 0x00175A44
		public virtual int GetErrorMinValue()
		{
			return vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_GetErrorMinValue_12(base.GetCppThis());
		}

		// Token: 0x06010D48 RID: 68936
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageToPolyDataFilter_GetLookupTable_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the vtkLookupTable to use. The lookup table is used when the
		/// color mode is set to LUT and a single component scalar is input.
		/// </summary>
		// Token: 0x06010D49 RID: 68937 RVA: 0x00177864 File Offset: 0x00175A64
		public virtual vtkScalarsToColors GetLookupTable()
		{
			vtkScalarsToColors vtkScalarsToColors = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_GetLookupTable_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06010D4A RID: 68938
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageToPolyDataFilter_GetNumberOfGenerationsFromBase_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010D4B RID: 68939 RVA: 0x001778D4 File Offset: 0x00175AD4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_GetNumberOfGenerationsFromBase_14(base.GetCppThis(), type);
		}

		// Token: 0x06010D4C RID: 68940
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageToPolyDataFilter_GetNumberOfGenerationsFromBaseType_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010D4D RID: 68941 RVA: 0x001778F4 File Offset: 0x00175AF4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_GetNumberOfGenerationsFromBaseType_15(type);
		}

		// Token: 0x06010D4E RID: 68942
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageToPolyDataFilter_GetNumberOfSmoothingIterations_16(HandleRef pThis);

		/// <summary>
		/// Specify the number of smoothing iterations to smooth polygons. (Only
		/// in effect if output style is Polygonalize and smoothing is on.)
		/// </summary>
		// Token: 0x06010D4F RID: 68943 RVA: 0x00177910 File Offset: 0x00175B10
		public virtual int GetNumberOfSmoothingIterations()
		{
			return vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_GetNumberOfSmoothingIterations_16(base.GetCppThis());
		}

		// Token: 0x06010D50 RID: 68944
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageToPolyDataFilter_GetNumberOfSmoothingIterationsMaxValue_17(HandleRef pThis);

		/// <summary>
		/// Specify the number of smoothing iterations to smooth polygons. (Only
		/// in effect if output style is Polygonalize and smoothing is on.)
		/// </summary>
		// Token: 0x06010D51 RID: 68945 RVA: 0x00177930 File Offset: 0x00175B30
		public virtual int GetNumberOfSmoothingIterationsMaxValue()
		{
			return vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_GetNumberOfSmoothingIterationsMaxValue_17(base.GetCppThis());
		}

		// Token: 0x06010D52 RID: 68946
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageToPolyDataFilter_GetNumberOfSmoothingIterationsMinValue_18(HandleRef pThis);

		/// <summary>
		/// Specify the number of smoothing iterations to smooth polygons. (Only
		/// in effect if output style is Polygonalize and smoothing is on.)
		/// </summary>
		// Token: 0x06010D53 RID: 68947 RVA: 0x00177950 File Offset: 0x00175B50
		public virtual int GetNumberOfSmoothingIterationsMinValue()
		{
			return vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_GetNumberOfSmoothingIterationsMinValue_18(base.GetCppThis());
		}

		// Token: 0x06010D54 RID: 68948
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageToPolyDataFilter_GetOutputStyle_19(HandleRef pThis);

		/// <summary>
		/// Specify how to create the output. Pixelize means converting the image
		/// to quad polygons with a constant color per quad. Polygonalize means
		/// merging colors together into polygonal regions, and then smoothing
		/// the regions (if smoothing is turned on). RunLength means creating
		/// quad polygons that may encompass several pixels on a scan line. The
		/// default behavior is Polygonalize.
		/// </summary>
		// Token: 0x06010D55 RID: 68949 RVA: 0x00177970 File Offset: 0x00175B70
		public virtual int GetOutputStyle()
		{
			return vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_GetOutputStyle_19(base.GetCppThis());
		}

		// Token: 0x06010D56 RID: 68950
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageToPolyDataFilter_GetOutputStyleMaxValue_20(HandleRef pThis);

		/// <summary>
		/// Specify how to create the output. Pixelize means converting the image
		/// to quad polygons with a constant color per quad. Polygonalize means
		/// merging colors together into polygonal regions, and then smoothing
		/// the regions (if smoothing is turned on). RunLength means creating
		/// quad polygons that may encompass several pixels on a scan line. The
		/// default behavior is Polygonalize.
		/// </summary>
		// Token: 0x06010D57 RID: 68951 RVA: 0x00177990 File Offset: 0x00175B90
		public virtual int GetOutputStyleMaxValue()
		{
			return vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_GetOutputStyleMaxValue_20(base.GetCppThis());
		}

		// Token: 0x06010D58 RID: 68952
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageToPolyDataFilter_GetOutputStyleMinValue_21(HandleRef pThis);

		/// <summary>
		/// Specify how to create the output. Pixelize means converting the image
		/// to quad polygons with a constant color per quad. Polygonalize means
		/// merging colors together into polygonal regions, and then smoothing
		/// the regions (if smoothing is turned on). RunLength means creating
		/// quad polygons that may encompass several pixels on a scan line. The
		/// default behavior is Polygonalize.
		/// </summary>
		// Token: 0x06010D59 RID: 68953 RVA: 0x001779B0 File Offset: 0x00175BB0
		public virtual int GetOutputStyleMinValue()
		{
			return vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_GetOutputStyleMinValue_21(base.GetCppThis());
		}

		// Token: 0x06010D5A RID: 68954
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageToPolyDataFilter_GetSmoothing_22(HandleRef pThis);

		/// <summary>
		/// If the output style is set to polygonalize, then you can control
		/// whether to smooth boundaries.
		/// </summary>
		// Token: 0x06010D5B RID: 68955 RVA: 0x001779D0 File Offset: 0x00175BD0
		public virtual int GetSmoothing()
		{
			return vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_GetSmoothing_22(base.GetCppThis());
		}

		// Token: 0x06010D5C RID: 68956
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageToPolyDataFilter_GetSubImageSize_23(HandleRef pThis);

		/// <summary>
		/// Specify the size (n by n pixels) of the largest region to
		/// polygonalize. When the OutputStyle is set to VTK_STYLE_POLYGONALIZE,
		/// large amounts of memory are used. In order to process large images,
		/// the image is broken into pieces that are at most Size pixels in
		/// width and height.
		/// </summary>
		// Token: 0x06010D5D RID: 68957 RVA: 0x001779F0 File Offset: 0x00175BF0
		public virtual int GetSubImageSize()
		{
			return vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_GetSubImageSize_23(base.GetCppThis());
		}

		// Token: 0x06010D5E RID: 68958
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageToPolyDataFilter_GetSubImageSizeMaxValue_24(HandleRef pThis);

		/// <summary>
		/// Specify the size (n by n pixels) of the largest region to
		/// polygonalize. When the OutputStyle is set to VTK_STYLE_POLYGONALIZE,
		/// large amounts of memory are used. In order to process large images,
		/// the image is broken into pieces that are at most Size pixels in
		/// width and height.
		/// </summary>
		// Token: 0x06010D5F RID: 68959 RVA: 0x00177A10 File Offset: 0x00175C10
		public virtual int GetSubImageSizeMaxValue()
		{
			return vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_GetSubImageSizeMaxValue_24(base.GetCppThis());
		}

		// Token: 0x06010D60 RID: 68960
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageToPolyDataFilter_GetSubImageSizeMinValue_25(HandleRef pThis);

		/// <summary>
		/// Specify the size (n by n pixels) of the largest region to
		/// polygonalize. When the OutputStyle is set to VTK_STYLE_POLYGONALIZE,
		/// large amounts of memory are used. In order to process large images,
		/// the image is broken into pieces that are at most Size pixels in
		/// width and height.
		/// </summary>
		// Token: 0x06010D61 RID: 68961 RVA: 0x00177A30 File Offset: 0x00175C30
		public virtual int GetSubImageSizeMinValue()
		{
			return vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_GetSubImageSizeMinValue_25(base.GetCppThis());
		}

		// Token: 0x06010D62 RID: 68962
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageToPolyDataFilter_IsA_26(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010D63 RID: 68963 RVA: 0x00177A50 File Offset: 0x00175C50
		public override int IsA(string type)
		{
			return vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_IsA_26(base.GetCppThis(), type);
		}

		// Token: 0x06010D64 RID: 68964
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageToPolyDataFilter_IsTypeOf_27([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010D65 RID: 68965 RVA: 0x00177A70 File Offset: 0x00175C70
		public new static int IsTypeOf(string type)
		{
			return vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_IsTypeOf_27(type);
		}

		// Token: 0x06010D66 RID: 68966
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageToPolyDataFilter_NewInstance_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010D67 RID: 68967 RVA: 0x00177A8C File Offset: 0x00175C8C
		public new vtkImageToPolyDataFilter NewInstance()
		{
			vtkImageToPolyDataFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_NewInstance_29(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageToPolyDataFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010D68 RID: 68968
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageToPolyDataFilter_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010D69 RID: 68969 RVA: 0x00177AE8 File Offset: 0x00175CE8
		public new static vtkImageToPolyDataFilter SafeDownCast(vtkObjectBase o)
		{
			vtkImageToPolyDataFilter vtkImageToPolyDataFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_SafeDownCast_30((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageToPolyDataFilter = (vtkImageToPolyDataFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageToPolyDataFilter.Register(null);
				}
			}
			return vtkImageToPolyDataFilter;
		}

		// Token: 0x06010D6A RID: 68970
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageToPolyDataFilter_SetColorMode_31(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify how to quantize color.
		/// </summary>
		// Token: 0x06010D6B RID: 68971 RVA: 0x00177B67 File Offset: 0x00175D67
		public virtual void SetColorMode(int _arg)
		{
			vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_SetColorMode_31(base.GetCppThis(), _arg);
		}

		// Token: 0x06010D6C RID: 68972
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageToPolyDataFilter_SetColorModeToLUT_32(HandleRef pThis);

		/// <summary>
		/// Specify how to quantize color.
		/// </summary>
		// Token: 0x06010D6D RID: 68973 RVA: 0x00177B77 File Offset: 0x00175D77
		public void SetColorModeToLUT()
		{
			vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_SetColorModeToLUT_32(base.GetCppThis());
		}

		// Token: 0x06010D6E RID: 68974
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageToPolyDataFilter_SetColorModeToLinear256_33(HandleRef pThis);

		/// <summary>
		/// Specify how to quantize color.
		/// </summary>
		// Token: 0x06010D6F RID: 68975 RVA: 0x00177B86 File Offset: 0x00175D86
		public void SetColorModeToLinear256()
		{
			vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_SetColorModeToLinear256_33(base.GetCppThis());
		}

		// Token: 0x06010D70 RID: 68976
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageToPolyDataFilter_SetDecimation_34(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off whether the final polygons should be decimated.
		/// whether to smooth boundaries.
		/// </summary>
		// Token: 0x06010D71 RID: 68977 RVA: 0x00177B95 File Offset: 0x00175D95
		public virtual void SetDecimation(int _arg)
		{
			vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_SetDecimation_34(base.GetCppThis(), _arg);
		}

		// Token: 0x06010D72 RID: 68978
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageToPolyDataFilter_SetDecimationError_35(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the error to use for decimation (if decimation is on).
		/// The error is an absolute number--the image spacing and
		/// dimensions are used to create points so the error should be
		/// consistent with the image size.
		/// </summary>
		// Token: 0x06010D73 RID: 68979 RVA: 0x00177BA5 File Offset: 0x00175DA5
		public virtual void SetDecimationError(double _arg)
		{
			vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_SetDecimationError_35(base.GetCppThis(), _arg);
		}

		// Token: 0x06010D74 RID: 68980
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageToPolyDataFilter_SetError_36(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the error value between two colors where the colors are
		/// considered the same. Only use this if the color mode uses the
		/// default 256 table.
		/// </summary>
		// Token: 0x06010D75 RID: 68981 RVA: 0x00177BB5 File Offset: 0x00175DB5
		public virtual void SetError(int _arg)
		{
			vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_SetError_36(base.GetCppThis(), _arg);
		}

		// Token: 0x06010D76 RID: 68982
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageToPolyDataFilter_SetLookupTable_37(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the vtkLookupTable to use. The lookup table is used when the
		/// color mode is set to LUT and a single component scalar is input.
		/// </summary>
		// Token: 0x06010D77 RID: 68983 RVA: 0x00177BC8 File Offset: 0x00175DC8
		public virtual void SetLookupTable(vtkScalarsToColors arg0)
		{
			vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_SetLookupTable_37(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06010D78 RID: 68984
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageToPolyDataFilter_SetNumberOfSmoothingIterations_38(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the number of smoothing iterations to smooth polygons. (Only
		/// in effect if output style is Polygonalize and smoothing is on.)
		/// </summary>
		// Token: 0x06010D79 RID: 68985 RVA: 0x00177BF7 File Offset: 0x00175DF7
		public virtual void SetNumberOfSmoothingIterations(int _arg)
		{
			vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_SetNumberOfSmoothingIterations_38(base.GetCppThis(), _arg);
		}

		// Token: 0x06010D7A RID: 68986
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageToPolyDataFilter_SetOutputStyle_39(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify how to create the output. Pixelize means converting the image
		/// to quad polygons with a constant color per quad. Polygonalize means
		/// merging colors together into polygonal regions, and then smoothing
		/// the regions (if smoothing is turned on). RunLength means creating
		/// quad polygons that may encompass several pixels on a scan line. The
		/// default behavior is Polygonalize.
		/// </summary>
		// Token: 0x06010D7B RID: 68987 RVA: 0x00177C07 File Offset: 0x00175E07
		public virtual void SetOutputStyle(int _arg)
		{
			vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_SetOutputStyle_39(base.GetCppThis(), _arg);
		}

		// Token: 0x06010D7C RID: 68988
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageToPolyDataFilter_SetOutputStyleToPixelize_40(HandleRef pThis);

		/// <summary>
		/// Specify how to create the output. Pixelize means converting the image
		/// to quad polygons with a constant color per quad. Polygonalize means
		/// merging colors together into polygonal regions, and then smoothing
		/// the regions (if smoothing is turned on). RunLength means creating
		/// quad polygons that may encompass several pixels on a scan line. The
		/// default behavior is Polygonalize.
		/// </summary>
		// Token: 0x06010D7D RID: 68989 RVA: 0x00177C17 File Offset: 0x00175E17
		public void SetOutputStyleToPixelize()
		{
			vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_SetOutputStyleToPixelize_40(base.GetCppThis());
		}

		// Token: 0x06010D7E RID: 68990
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageToPolyDataFilter_SetOutputStyleToPolygonalize_41(HandleRef pThis);

		/// <summary>
		/// Specify how to create the output. Pixelize means converting the image
		/// to quad polygons with a constant color per quad. Polygonalize means
		/// merging colors together into polygonal regions, and then smoothing
		/// the regions (if smoothing is turned on). RunLength means creating
		/// quad polygons that may encompass several pixels on a scan line. The
		/// default behavior is Polygonalize.
		/// </summary>
		// Token: 0x06010D7F RID: 68991 RVA: 0x00177C26 File Offset: 0x00175E26
		public void SetOutputStyleToPolygonalize()
		{
			vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_SetOutputStyleToPolygonalize_41(base.GetCppThis());
		}

		// Token: 0x06010D80 RID: 68992
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageToPolyDataFilter_SetOutputStyleToRunLength_42(HandleRef pThis);

		/// <summary>
		/// Specify how to create the output. Pixelize means converting the image
		/// to quad polygons with a constant color per quad. Polygonalize means
		/// merging colors together into polygonal regions, and then smoothing
		/// the regions (if smoothing is turned on). RunLength means creating
		/// quad polygons that may encompass several pixels on a scan line. The
		/// default behavior is Polygonalize.
		/// </summary>
		// Token: 0x06010D81 RID: 68993 RVA: 0x00177C35 File Offset: 0x00175E35
		public void SetOutputStyleToRunLength()
		{
			vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_SetOutputStyleToRunLength_42(base.GetCppThis());
		}

		// Token: 0x06010D82 RID: 68994
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageToPolyDataFilter_SetSmoothing_43(HandleRef pThis, int _arg);

		/// <summary>
		/// If the output style is set to polygonalize, then you can control
		/// whether to smooth boundaries.
		/// </summary>
		// Token: 0x06010D83 RID: 68995 RVA: 0x00177C44 File Offset: 0x00175E44
		public virtual void SetSmoothing(int _arg)
		{
			vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_SetSmoothing_43(base.GetCppThis(), _arg);
		}

		// Token: 0x06010D84 RID: 68996
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageToPolyDataFilter_SetSubImageSize_44(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the size (n by n pixels) of the largest region to
		/// polygonalize. When the OutputStyle is set to VTK_STYLE_POLYGONALIZE,
		/// large amounts of memory are used. In order to process large images,
		/// the image is broken into pieces that are at most Size pixels in
		/// width and height.
		/// </summary>
		// Token: 0x06010D85 RID: 68997 RVA: 0x00177C54 File Offset: 0x00175E54
		public virtual void SetSubImageSize(int _arg)
		{
			vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_SetSubImageSize_44(base.GetCppThis(), _arg);
		}

		// Token: 0x06010D86 RID: 68998
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageToPolyDataFilter_SmoothingOff_45(HandleRef pThis);

		/// <summary>
		/// If the output style is set to polygonalize, then you can control
		/// whether to smooth boundaries.
		/// </summary>
		// Token: 0x06010D87 RID: 68999 RVA: 0x00177C64 File Offset: 0x00175E64
		public virtual void SmoothingOff()
		{
			vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_SmoothingOff_45(base.GetCppThis());
		}

		// Token: 0x06010D88 RID: 69000
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageToPolyDataFilter_SmoothingOn_46(HandleRef pThis);

		/// <summary>
		/// If the output style is set to polygonalize, then you can control
		/// whether to smooth boundaries.
		/// </summary>
		// Token: 0x06010D89 RID: 69001 RVA: 0x00177C73 File Offset: 0x00175E73
		public virtual void SmoothingOn()
		{
			vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_SmoothingOn_46(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001376 RID: 4982
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageToPolyDataFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001377 RID: 4983
		public new static readonly string MRClassNameKey = "class vtkImageToPolyDataFilter";
	}
}
