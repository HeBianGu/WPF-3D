using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageHistogramStatistics
	/// </summary>
	/// <remarks>
	///    Compute statistics for an image
	///
	/// vtkImageHistogramStatistics computes statistics such as mean, median, and
	/// standard deviation.  These statistics are computed from the histogram
	/// of the image, rather than from the image itself, because this is more
	/// efficient than computing the statistics while traversing the pixels.
	/// If the input image is of type float or double, then the precision of
	/// the Mean, Median, and StandardDeviation will depend on the number of
	/// histogram bins.  By default, 65536 bins are used for float data, giving
	/// at least 16 bits of precision.
	/// @par Thanks:
	/// Thanks to David Gobbi at the Seaman Family MR Centre and Dept. of Clinical
	/// Neurosciences, Foothills Medical Centre, Calgary, for providing this class.
	/// </remarks>
	// Token: 0x02000242 RID: 578
	public class vtkImageHistogramStatistics : vtkImageHistogram
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006BA3 RID: 27555 RVA: 0x0009B5D3 File Offset: 0x000997D3
		static vtkImageHistogramStatistics()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageHistogramStatistics.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageHistogramStatistics"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006BA4 RID: 27556 RVA: 0x0009B5FB File Offset: 0x000997FB
		public vtkImageHistogramStatistics(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006BA5 RID: 27557
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageHistogramStatistics_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006BA6 RID: 27558 RVA: 0x0009B60C File Offset: 0x0009980C
		public new static vtkImageHistogramStatistics New()
		{
			vtkImageHistogramStatistics result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageHistogramStatistics.vtkImageHistogramStatistics_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageHistogramStatistics)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006BA7 RID: 27559 RVA: 0x0009B660 File Offset: 0x00099860
		public vtkImageHistogramStatistics() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageHistogramStatistics.vtkImageHistogramStatistics_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006BA8 RID: 27560 RVA: 0x0009B6A4 File Offset: 0x000998A4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006BA9 RID: 27561
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageHistogramStatistics_GetAutoRange_01(HandleRef pThis);

		/// <summary>
		/// Get an automatically computed view range for the image, for use
		/// with the lookup table or image property that is used when viewing
		/// the image.  The use of this range will avoid situations where an
		/// image looks too dark because a few pixels happen to be much brighter
		/// than the rest.
		/// </summary>
		// Token: 0x06006BAA RID: 27562 RVA: 0x0009B6B0 File Offset: 0x000998B0
		public virtual double[] GetAutoRange()
		{
			IntPtr intPtr = vtkImageHistogramStatistics.vtkImageHistogramStatistics_GetAutoRange_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06006BAB RID: 27563
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageHistogramStatistics_GetAutoRange_02(HandleRef pThis, ref double _arg1, ref double _arg2);

		/// <summary>
		/// Get an automatically computed view range for the image, for use
		/// with the lookup table or image property that is used when viewing
		/// the image.  The use of this range will avoid situations where an
		/// image looks too dark because a few pixels happen to be much brighter
		/// than the rest.
		/// </summary>
		// Token: 0x06006BAC RID: 27564 RVA: 0x0009B6F8 File Offset: 0x000998F8
		public virtual void GetAutoRange(ref double _arg1, ref double _arg2)
		{
			vtkImageHistogramStatistics.vtkImageHistogramStatistics_GetAutoRange_02(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06006BAD RID: 27565
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageHistogramStatistics_GetAutoRange_03(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get an automatically computed view range for the image, for use
		/// with the lookup table or image property that is used when viewing
		/// the image.  The use of this range will avoid situations where an
		/// image looks too dark because a few pixels happen to be much brighter
		/// than the rest.
		/// </summary>
		// Token: 0x06006BAE RID: 27566 RVA: 0x0009B709 File Offset: 0x00099909
		public virtual void GetAutoRange(IntPtr _arg)
		{
			vtkImageHistogramStatistics.vtkImageHistogramStatistics_GetAutoRange_03(base.GetCppThis(), _arg);
		}

		// Token: 0x06006BAF RID: 27567
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageHistogramStatistics_GetAutoRangeExpansionFactors_04(HandleRef pThis);

		/// <summary>
		/// Set lower and upper expansion factors to apply to the auto range
		/// that was computed from the AutoRangePercentiles.  Any outliers that
		/// are within this expanded range will be included, even if they are
		/// beyond the percentile.  This allows inclusion of values that are
		/// just slightly outside of the percentile, while rejecting values
		/// that are far beyond the percentile.  The default is to expand the
		/// range by a factor of 0.1 at each end.  The range will never be
		/// expanded beyond the Minimum or Maximum pixel values.
		/// </summary>
		// Token: 0x06006BB0 RID: 27568 RVA: 0x0009B71C File Offset: 0x0009991C
		public virtual double[] GetAutoRangeExpansionFactors()
		{
			IntPtr intPtr = vtkImageHistogramStatistics.vtkImageHistogramStatistics_GetAutoRangeExpansionFactors_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06006BB1 RID: 27569
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageHistogramStatistics_GetAutoRangeExpansionFactors_05(HandleRef pThis, ref double _arg1, ref double _arg2);

		/// <summary>
		/// Set lower and upper expansion factors to apply to the auto range
		/// that was computed from the AutoRangePercentiles.  Any outliers that
		/// are within this expanded range will be included, even if they are
		/// beyond the percentile.  This allows inclusion of values that are
		/// just slightly outside of the percentile, while rejecting values
		/// that are far beyond the percentile.  The default is to expand the
		/// range by a factor of 0.1 at each end.  The range will never be
		/// expanded beyond the Minimum or Maximum pixel values.
		/// </summary>
		// Token: 0x06006BB2 RID: 27570 RVA: 0x0009B764 File Offset: 0x00099964
		public virtual void GetAutoRangeExpansionFactors(ref double _arg1, ref double _arg2)
		{
			vtkImageHistogramStatistics.vtkImageHistogramStatistics_GetAutoRangeExpansionFactors_05(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06006BB3 RID: 27571
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageHistogramStatistics_GetAutoRangeExpansionFactors_06(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set lower and upper expansion factors to apply to the auto range
		/// that was computed from the AutoRangePercentiles.  Any outliers that
		/// are within this expanded range will be included, even if they are
		/// beyond the percentile.  This allows inclusion of values that are
		/// just slightly outside of the percentile, while rejecting values
		/// that are far beyond the percentile.  The default is to expand the
		/// range by a factor of 0.1 at each end.  The range will never be
		/// expanded beyond the Minimum or Maximum pixel values.
		/// </summary>
		// Token: 0x06006BB4 RID: 27572 RVA: 0x0009B775 File Offset: 0x00099975
		public virtual void GetAutoRangeExpansionFactors(IntPtr _arg)
		{
			vtkImageHistogramStatistics.vtkImageHistogramStatistics_GetAutoRangeExpansionFactors_06(base.GetCppThis(), _arg);
		}

		// Token: 0x06006BB5 RID: 27573
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageHistogramStatistics_GetAutoRangePercentiles_07(HandleRef pThis);

		/// <summary>
		/// Set the percentiles to use for automatic view range computation.
		/// This allows one to compute a range that does not include outliers
		/// that are significantly darker or significantly brighter than the
		/// rest of the pixels in the image.  The default is to use the first
		/// percentile and the 99th percentile.
		/// </summary>
		// Token: 0x06006BB6 RID: 27574 RVA: 0x0009B788 File Offset: 0x00099988
		public virtual double[] GetAutoRangePercentiles()
		{
			IntPtr intPtr = vtkImageHistogramStatistics.vtkImageHistogramStatistics_GetAutoRangePercentiles_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06006BB7 RID: 27575
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageHistogramStatistics_GetAutoRangePercentiles_08(HandleRef pThis, ref double _arg1, ref double _arg2);

		/// <summary>
		/// Set the percentiles to use for automatic view range computation.
		/// This allows one to compute a range that does not include outliers
		/// that are significantly darker or significantly brighter than the
		/// rest of the pixels in the image.  The default is to use the first
		/// percentile and the 99th percentile.
		/// </summary>
		// Token: 0x06006BB8 RID: 27576 RVA: 0x0009B7D0 File Offset: 0x000999D0
		public virtual void GetAutoRangePercentiles(ref double _arg1, ref double _arg2)
		{
			vtkImageHistogramStatistics.vtkImageHistogramStatistics_GetAutoRangePercentiles_08(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06006BB9 RID: 27577
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageHistogramStatistics_GetAutoRangePercentiles_09(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the percentiles to use for automatic view range computation.
		/// This allows one to compute a range that does not include outliers
		/// that are significantly darker or significantly brighter than the
		/// rest of the pixels in the image.  The default is to use the first
		/// percentile and the 99th percentile.
		/// </summary>
		// Token: 0x06006BBA RID: 27578 RVA: 0x0009B7E1 File Offset: 0x000999E1
		public virtual void GetAutoRangePercentiles(IntPtr _arg)
		{
			vtkImageHistogramStatistics.vtkImageHistogramStatistics_GetAutoRangePercentiles_09(base.GetCppThis(), _arg);
		}

		// Token: 0x06006BBB RID: 27579
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageHistogramStatistics_GetMaximum_10(HandleRef pThis);

		/// <summary>
		/// Get the maximum value present in the image.  This value is computed
		/// when Update() is called.
		/// </summary>
		// Token: 0x06006BBC RID: 27580 RVA: 0x0009B7F4 File Offset: 0x000999F4
		public double GetMaximum()
		{
			return vtkImageHistogramStatistics.vtkImageHistogramStatistics_GetMaximum_10(base.GetCppThis());
		}

		// Token: 0x06006BBD RID: 27581
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageHistogramStatistics_GetMean_11(HandleRef pThis);

		/// <summary>
		/// Get the mean value of the image.  This value is computed when Update()
		/// is called.
		/// </summary>
		// Token: 0x06006BBE RID: 27582 RVA: 0x0009B814 File Offset: 0x00099A14
		public double GetMean()
		{
			return vtkImageHistogramStatistics.vtkImageHistogramStatistics_GetMean_11(base.GetCppThis());
		}

		// Token: 0x06006BBF RID: 27583
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageHistogramStatistics_GetMedian_12(HandleRef pThis);

		/// <summary>
		/// Get the median value.  This is computed when Update() is called.
		/// </summary>
		// Token: 0x06006BC0 RID: 27584 RVA: 0x0009B834 File Offset: 0x00099A34
		public double GetMedian()
		{
			return vtkImageHistogramStatistics.vtkImageHistogramStatistics_GetMedian_12(base.GetCppThis());
		}

		// Token: 0x06006BC1 RID: 27585
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageHistogramStatistics_GetMinimum_13(HandleRef pThis);

		/// <summary>
		/// Get the minimum value present in the image.  This value is computed
		/// when Update() is called.
		/// </summary>
		// Token: 0x06006BC2 RID: 27586 RVA: 0x0009B854 File Offset: 0x00099A54
		public double GetMinimum()
		{
			return vtkImageHistogramStatistics.vtkImageHistogramStatistics_GetMinimum_13(base.GetCppThis());
		}

		// Token: 0x06006BC3 RID: 27587
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageHistogramStatistics_GetNumberOfGenerationsFromBase_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006BC4 RID: 27588 RVA: 0x0009B874 File Offset: 0x00099A74
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageHistogramStatistics.vtkImageHistogramStatistics_GetNumberOfGenerationsFromBase_14(base.GetCppThis(), type);
		}

		// Token: 0x06006BC5 RID: 27589
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageHistogramStatistics_GetNumberOfGenerationsFromBaseType_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006BC6 RID: 27590 RVA: 0x0009B894 File Offset: 0x00099A94
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageHistogramStatistics.vtkImageHistogramStatistics_GetNumberOfGenerationsFromBaseType_15(type);
		}

		// Token: 0x06006BC7 RID: 27591
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageHistogramStatistics_GetStandardDeviation_16(HandleRef pThis);

		/// <summary>
		/// Get the standard deviation of the values in the image.  This is
		/// computed when Update() is called.
		/// </summary>
		// Token: 0x06006BC8 RID: 27592 RVA: 0x0009B8B0 File Offset: 0x00099AB0
		public double GetStandardDeviation()
		{
			return vtkImageHistogramStatistics.vtkImageHistogramStatistics_GetStandardDeviation_16(base.GetCppThis());
		}

		// Token: 0x06006BC9 RID: 27593
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageHistogramStatistics_IsA_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006BCA RID: 27594 RVA: 0x0009B8D0 File Offset: 0x00099AD0
		public override int IsA(string type)
		{
			return vtkImageHistogramStatistics.vtkImageHistogramStatistics_IsA_17(base.GetCppThis(), type);
		}

		// Token: 0x06006BCB RID: 27595
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageHistogramStatistics_IsTypeOf_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006BCC RID: 27596 RVA: 0x0009B8F0 File Offset: 0x00099AF0
		public new static int IsTypeOf(string type)
		{
			return vtkImageHistogramStatistics.vtkImageHistogramStatistics_IsTypeOf_18(type);
		}

		// Token: 0x06006BCD RID: 27597
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageHistogramStatistics_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006BCE RID: 27598 RVA: 0x0009B90C File Offset: 0x00099B0C
		public new vtkImageHistogramStatistics NewInstance()
		{
			vtkImageHistogramStatistics result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageHistogramStatistics.vtkImageHistogramStatistics_NewInstance_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageHistogramStatistics)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006BCF RID: 27599
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageHistogramStatistics_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006BD0 RID: 27600 RVA: 0x0009B968 File Offset: 0x00099B68
		public new static vtkImageHistogramStatistics SafeDownCast(vtkObjectBase o)
		{
			vtkImageHistogramStatistics vtkImageHistogramStatistics = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageHistogramStatistics.vtkImageHistogramStatistics_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageHistogramStatistics = (vtkImageHistogramStatistics)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageHistogramStatistics.Register(null);
				}
			}
			return vtkImageHistogramStatistics;
		}

		// Token: 0x06006BD1 RID: 27601
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageHistogramStatistics_SetAutoRangeExpansionFactors_22(HandleRef pThis, double _arg1, double _arg2);

		/// <summary>
		/// Set lower and upper expansion factors to apply to the auto range
		/// that was computed from the AutoRangePercentiles.  Any outliers that
		/// are within this expanded range will be included, even if they are
		/// beyond the percentile.  This allows inclusion of values that are
		/// just slightly outside of the percentile, while rejecting values
		/// that are far beyond the percentile.  The default is to expand the
		/// range by a factor of 0.1 at each end.  The range will never be
		/// expanded beyond the Minimum or Maximum pixel values.
		/// </summary>
		// Token: 0x06006BD2 RID: 27602 RVA: 0x0009B9E7 File Offset: 0x00099BE7
		public virtual void SetAutoRangeExpansionFactors(double _arg1, double _arg2)
		{
			vtkImageHistogramStatistics.vtkImageHistogramStatistics_SetAutoRangeExpansionFactors_22(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x06006BD3 RID: 27603
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageHistogramStatistics_SetAutoRangeExpansionFactors_23(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set lower and upper expansion factors to apply to the auto range
		/// that was computed from the AutoRangePercentiles.  Any outliers that
		/// are within this expanded range will be included, even if they are
		/// beyond the percentile.  This allows inclusion of values that are
		/// just slightly outside of the percentile, while rejecting values
		/// that are far beyond the percentile.  The default is to expand the
		/// range by a factor of 0.1 at each end.  The range will never be
		/// expanded beyond the Minimum or Maximum pixel values.
		/// </summary>
		// Token: 0x06006BD4 RID: 27604 RVA: 0x0009B9F8 File Offset: 0x00099BF8
		public void SetAutoRangeExpansionFactors(IntPtr _arg)
		{
			vtkImageHistogramStatistics.vtkImageHistogramStatistics_SetAutoRangeExpansionFactors_23(base.GetCppThis(), _arg);
		}

		// Token: 0x06006BD5 RID: 27605
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageHistogramStatistics_SetAutoRangePercentiles_24(HandleRef pThis, double _arg1, double _arg2);

		/// <summary>
		/// Set the percentiles to use for automatic view range computation.
		/// This allows one to compute a range that does not include outliers
		/// that are significantly darker or significantly brighter than the
		/// rest of the pixels in the image.  The default is to use the first
		/// percentile and the 99th percentile.
		/// </summary>
		// Token: 0x06006BD6 RID: 27606 RVA: 0x0009BA08 File Offset: 0x00099C08
		public virtual void SetAutoRangePercentiles(double _arg1, double _arg2)
		{
			vtkImageHistogramStatistics.vtkImageHistogramStatistics_SetAutoRangePercentiles_24(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x06006BD7 RID: 27607
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageHistogramStatistics_SetAutoRangePercentiles_25(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the percentiles to use for automatic view range computation.
		/// This allows one to compute a range that does not include outliers
		/// that are significantly darker or significantly brighter than the
		/// rest of the pixels in the image.  The default is to use the first
		/// percentile and the 99th percentile.
		/// </summary>
		// Token: 0x06006BD8 RID: 27608 RVA: 0x0009BA19 File Offset: 0x00099C19
		public void SetAutoRangePercentiles(IntPtr _arg)
		{
			vtkImageHistogramStatistics.vtkImageHistogramStatistics_SetAutoRangePercentiles_25(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000975 RID: 2421
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageHistogramStatistics";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000976 RID: 2422
		public new static readonly string MRClassNameKey = "class vtkImageHistogramStatistics";
	}
}
