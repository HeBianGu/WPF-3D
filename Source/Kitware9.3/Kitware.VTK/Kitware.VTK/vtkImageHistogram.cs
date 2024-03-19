using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageHistogram
	/// </summary>
	/// <remarks>
	///    Compute the histogram for an image.
	///
	/// vtkImageHistogram generates a histogram from its input, and optionally
	/// produces a 2D black-and-white image of the histogram as its output.
	/// Unlike the class vtkImageAccumulate, a multi-component image does not
	/// result in a multi-dimensional histogram.  Instead, the resulting
	/// histogram will be the sum of the histograms of each of the individual
	/// components, unless SetActiveComponent is used to choose a single
	/// component.
	/// @par Thanks:
	/// Thanks to David Gobbi at the Seaman Family MR Centre and Dept. of Clinical
	/// Neurosciences, Foothills Medical Centre, Calgary, for providing this class.
	/// </remarks>
	// Token: 0x02000240 RID: 576
	public class vtkImageHistogram : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006B49 RID: 27465 RVA: 0x0009AF4F File Offset: 0x0009914F
		static vtkImageHistogram()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageHistogram.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageHistogram"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006B4A RID: 27466 RVA: 0x0009AF77 File Offset: 0x00099177
		public vtkImageHistogram(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006B4B RID: 27467
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageHistogram_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006B4C RID: 27468 RVA: 0x0009AF88 File Offset: 0x00099188
		public new static vtkImageHistogram New()
		{
			vtkImageHistogram result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageHistogram.vtkImageHistogram_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageHistogram)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006B4D RID: 27469 RVA: 0x0009AFDC File Offset: 0x000991DC
		public vtkImageHistogram() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageHistogram.vtkImageHistogram_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006B4E RID: 27470 RVA: 0x0009B020 File Offset: 0x00099220
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006B4F RID: 27471
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageHistogram_AutomaticBinningOff_01(HandleRef pThis);

		/// <summary>
		/// If this is On, then the histogram binning will be done automatically.
		/// For char and unsigned char data, there will be 256 bins with unit
		/// spacing.  For data of type short and larger, there will be between
		/// 256 and MaximumNumberOfBins, depending on the range of the data, and
		/// the BinOrigin will be set to zero if no negative values are present,
		/// or to the smallest negative value if negative values are present.
		/// For float data, the MaximumNumberOfBins will always be used.
		/// The BinOrigin and BinSpacing will be set so that they provide a mapping
		/// from bin index to scalar value.
		/// </summary>
		// Token: 0x06006B50 RID: 27472 RVA: 0x0009B02B File Offset: 0x0009922B
		public virtual void AutomaticBinningOff()
		{
			vtkImageHistogram.vtkImageHistogram_AutomaticBinningOff_01(base.GetCppThis());
		}

		// Token: 0x06006B51 RID: 27473
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageHistogram_AutomaticBinningOn_02(HandleRef pThis);

		/// <summary>
		/// If this is On, then the histogram binning will be done automatically.
		/// For char and unsigned char data, there will be 256 bins with unit
		/// spacing.  For data of type short and larger, there will be between
		/// 256 and MaximumNumberOfBins, depending on the range of the data, and
		/// the BinOrigin will be set to zero if no negative values are present,
		/// or to the smallest negative value if negative values are present.
		/// For float data, the MaximumNumberOfBins will always be used.
		/// The BinOrigin and BinSpacing will be set so that they provide a mapping
		/// from bin index to scalar value.
		/// </summary>
		// Token: 0x06006B52 RID: 27474 RVA: 0x0009B03A File Offset: 0x0009923A
		public virtual void AutomaticBinningOn()
		{
			vtkImageHistogram.vtkImageHistogram_AutomaticBinningOn_02(base.GetCppThis());
		}

		// Token: 0x06006B53 RID: 27475
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageHistogram_GenerateHistogramImageOff_03(HandleRef pThis);

		/// <summary>
		/// If this is On, then a histogram image will be produced as the output.
		/// Regardless of this setting, the histogram is always available as a
		/// vtkIdTypeArray from the GetHistogram method.
		/// </summary>
		// Token: 0x06006B54 RID: 27476 RVA: 0x0009B049 File Offset: 0x00099249
		public virtual void GenerateHistogramImageOff()
		{
			vtkImageHistogram.vtkImageHistogram_GenerateHistogramImageOff_03(base.GetCppThis());
		}

		// Token: 0x06006B55 RID: 27477
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageHistogram_GenerateHistogramImageOn_04(HandleRef pThis);

		/// <summary>
		/// If this is On, then a histogram image will be produced as the output.
		/// Regardless of this setting, the histogram is always available as a
		/// vtkIdTypeArray from the GetHistogram method.
		/// </summary>
		// Token: 0x06006B56 RID: 27478 RVA: 0x0009B058 File Offset: 0x00099258
		public virtual void GenerateHistogramImageOn()
		{
			vtkImageHistogram.vtkImageHistogram_GenerateHistogramImageOn_04(base.GetCppThis());
		}

		// Token: 0x06006B57 RID: 27479
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageHistogram_GetActiveComponent_05(HandleRef pThis);

		/// <summary>
		/// Set the component for which to generate a histogram.  The default
		/// value is -1, which produces a histogram that is the sum of the
		/// histograms of the individual components.
		/// </summary>
		// Token: 0x06006B58 RID: 27480 RVA: 0x0009B068 File Offset: 0x00099268
		public virtual int GetActiveComponent()
		{
			return vtkImageHistogram.vtkImageHistogram_GetActiveComponent_05(base.GetCppThis());
		}

		// Token: 0x06006B59 RID: 27481
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageHistogram_GetAutomaticBinning_06(HandleRef pThis);

		/// <summary>
		/// If this is On, then the histogram binning will be done automatically.
		/// For char and unsigned char data, there will be 256 bins with unit
		/// spacing.  For data of type short and larger, there will be between
		/// 256 and MaximumNumberOfBins, depending on the range of the data, and
		/// the BinOrigin will be set to zero if no negative values are present,
		/// or to the smallest negative value if negative values are present.
		/// For float data, the MaximumNumberOfBins will always be used.
		/// The BinOrigin and BinSpacing will be set so that they provide a mapping
		/// from bin index to scalar value.
		/// </summary>
		// Token: 0x06006B5A RID: 27482 RVA: 0x0009B088 File Offset: 0x00099288
		public virtual int GetAutomaticBinning()
		{
			return vtkImageHistogram.vtkImageHistogram_GetAutomaticBinning_06(base.GetCppThis());
		}

		// Token: 0x06006B5B RID: 27483
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageHistogram_GetBinOrigin_07(HandleRef pThis);

		/// <summary>
		/// The value for the center of the first bin (default 0).  This is
		/// automatically computed unless AutomaticBinning is Off.
		/// </summary>
		// Token: 0x06006B5C RID: 27484 RVA: 0x0009B0A8 File Offset: 0x000992A8
		public virtual double GetBinOrigin()
		{
			return vtkImageHistogram.vtkImageHistogram_GetBinOrigin_07(base.GetCppThis());
		}

		// Token: 0x06006B5D RID: 27485
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageHistogram_GetBinSpacing_08(HandleRef pThis);

		/// <summary>
		/// The bin spacing (default 1).  This is automatically computed unless
		/// AutomaticBinning is Off.
		/// </summary>
		// Token: 0x06006B5E RID: 27486 RVA: 0x0009B0C8 File Offset: 0x000992C8
		public virtual double GetBinSpacing()
		{
			return vtkImageHistogram.vtkImageHistogram_GetBinSpacing_08(base.GetCppThis());
		}

		// Token: 0x06006B5F RID: 27487
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageHistogram_GetGenerateHistogramImage_09(HandleRef pThis);

		/// <summary>
		/// If this is On, then a histogram image will be produced as the output.
		/// Regardless of this setting, the histogram is always available as a
		/// vtkIdTypeArray from the GetHistogram method.
		/// </summary>
		// Token: 0x06006B60 RID: 27488 RVA: 0x0009B0E8 File Offset: 0x000992E8
		public virtual int GetGenerateHistogramImage()
		{
			return vtkImageHistogram.vtkImageHistogram_GetGenerateHistogramImage_09(base.GetCppThis());
		}

		// Token: 0x06006B61 RID: 27489
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageHistogram_GetHistogram_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the histogram as a vtkIdTypeArray.  You must call Update()
		/// before calling this method.
		/// </summary>
		// Token: 0x06006B62 RID: 27490 RVA: 0x0009B108 File Offset: 0x00099308
		public vtkIdTypeArray GetHistogram()
		{
			vtkIdTypeArray vtkIdTypeArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageHistogram.vtkImageHistogram_GetHistogram_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdTypeArray = (vtkIdTypeArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdTypeArray.Register(null);
				}
			}
			return vtkIdTypeArray;
		}

		// Token: 0x06006B63 RID: 27491
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageHistogram_GetHistogramImageScale_11(HandleRef pThis);

		/// <summary>
		/// Set the scale to use for the histogram image.  The default is
		/// a linear scale, but sqrt and log provide better visualization.
		/// </summary>
		// Token: 0x06006B64 RID: 27492 RVA: 0x0009B178 File Offset: 0x00099378
		public virtual int GetHistogramImageScale()
		{
			return vtkImageHistogram.vtkImageHistogram_GetHistogramImageScale_11(base.GetCppThis());
		}

		// Token: 0x06006B65 RID: 27493
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageHistogram_GetHistogramImageScaleAsString_12(HandleRef pThis);

		/// <summary>
		/// Set the scale to use for the histogram image.  The default is
		/// a linear scale, but sqrt and log provide better visualization.
		/// </summary>
		// Token: 0x06006B66 RID: 27494 RVA: 0x0009B198 File Offset: 0x00099398
		public string GetHistogramImageScaleAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkImageHistogram.vtkImageHistogram_GetHistogramImageScaleAsString_12(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06006B67 RID: 27495
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageHistogram_GetHistogramImageScaleMaxValue_13(HandleRef pThis);

		/// <summary>
		/// Set the scale to use for the histogram image.  The default is
		/// a linear scale, but sqrt and log provide better visualization.
		/// </summary>
		// Token: 0x06006B68 RID: 27496 RVA: 0x0009B1D4 File Offset: 0x000993D4
		public virtual int GetHistogramImageScaleMaxValue()
		{
			return vtkImageHistogram.vtkImageHistogram_GetHistogramImageScaleMaxValue_13(base.GetCppThis());
		}

		// Token: 0x06006B69 RID: 27497
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageHistogram_GetHistogramImageScaleMinValue_14(HandleRef pThis);

		/// <summary>
		/// Set the scale to use for the histogram image.  The default is
		/// a linear scale, but sqrt and log provide better visualization.
		/// </summary>
		// Token: 0x06006B6A RID: 27498 RVA: 0x0009B1F4 File Offset: 0x000993F4
		public virtual int GetHistogramImageScaleMinValue()
		{
			return vtkImageHistogram.vtkImageHistogram_GetHistogramImageScaleMinValue_14(base.GetCppThis());
		}

		// Token: 0x06006B6B RID: 27499
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageHistogram_GetHistogramImageSize_15(HandleRef pThis);

		/// <summary>
		/// Set the size of the histogram image that is produced as output.
		/// The default is 256 by 256.
		/// </summary>
		// Token: 0x06006B6C RID: 27500 RVA: 0x0009B214 File Offset: 0x00099414
		public virtual int[] GetHistogramImageSize()
		{
			IntPtr intPtr = vtkImageHistogram.vtkImageHistogram_GetHistogramImageSize_15(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06006B6D RID: 27501
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageHistogram_GetHistogramImageSize_16(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Set the size of the histogram image that is produced as output.
		/// The default is 256 by 256.
		/// </summary>
		// Token: 0x06006B6E RID: 27502 RVA: 0x0009B25C File Offset: 0x0009945C
		public virtual void GetHistogramImageSize(ref int _arg1, ref int _arg2)
		{
			vtkImageHistogram.vtkImageHistogram_GetHistogramImageSize_16(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06006B6F RID: 27503
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageHistogram_GetHistogramImageSize_17(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the size of the histogram image that is produced as output.
		/// The default is 256 by 256.
		/// </summary>
		// Token: 0x06006B70 RID: 27504 RVA: 0x0009B26D File Offset: 0x0009946D
		public virtual void GetHistogramImageSize(IntPtr _arg)
		{
			vtkImageHistogram.vtkImageHistogram_GetHistogramImageSize_17(base.GetCppThis(), _arg);
		}

		// Token: 0x06006B71 RID: 27505
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageHistogram_GetMaximumNumberOfBins_18(HandleRef pThis);

		/// <summary>
		/// The maximum number of bins to use when AutomaticBinning is On.
		/// When AutomaticBinning is On, the size of the output histogram
		/// will be set to the full range of the input data values, unless
		/// the full range is greater than this value.  By default, the max
		/// value is 65536, which is large enough to capture the full range
		/// of 16-bit integers.
		/// </summary>
		// Token: 0x06006B72 RID: 27506 RVA: 0x0009B280 File Offset: 0x00099480
		public virtual int GetMaximumNumberOfBins()
		{
			return vtkImageHistogram.vtkImageHistogram_GetMaximumNumberOfBins_18(base.GetCppThis());
		}

		// Token: 0x06006B73 RID: 27507
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageHistogram_GetNumberOfBins_19(HandleRef pThis);

		/// <summary>
		/// The number of bins in histogram (default 256).  This is automatically
		/// computed unless AutomaticBinning is Off.
		/// </summary>
		// Token: 0x06006B74 RID: 27508 RVA: 0x0009B2A0 File Offset: 0x000994A0
		public virtual int GetNumberOfBins()
		{
			return vtkImageHistogram.vtkImageHistogram_GetNumberOfBins_19(base.GetCppThis());
		}

		// Token: 0x06006B75 RID: 27509
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageHistogram_GetNumberOfGenerationsFromBase_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006B76 RID: 27510 RVA: 0x0009B2C0 File Offset: 0x000994C0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageHistogram.vtkImageHistogram_GetNumberOfGenerationsFromBase_20(base.GetCppThis(), type);
		}

		// Token: 0x06006B77 RID: 27511
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageHistogram_GetNumberOfGenerationsFromBaseType_21([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006B78 RID: 27512 RVA: 0x0009B2E0 File Offset: 0x000994E0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageHistogram.vtkImageHistogram_GetNumberOfGenerationsFromBaseType_21(type);
		}

		// Token: 0x06006B79 RID: 27513
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageHistogram_GetStencil_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Use a stencil to compute the histogram for just a part of the image.
		/// </summary>
		// Token: 0x06006B7A RID: 27514 RVA: 0x0009B2FC File Offset: 0x000994FC
		public vtkImageStencilData GetStencil()
		{
			vtkImageStencilData vtkImageStencilData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageHistogram.vtkImageHistogram_GetStencil_22(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageStencilData = (vtkImageStencilData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageStencilData.Register(null);
				}
			}
			return vtkImageStencilData;
		}

		// Token: 0x06006B7B RID: 27515
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageHistogram_GetTotal_23(HandleRef pThis);

		/// <summary>
		/// Get the total count of the histogram.  This will be the number of
		/// voxels times the number of components.
		/// </summary>
		// Token: 0x06006B7C RID: 27516 RVA: 0x0009B36C File Offset: 0x0009956C
		public long GetTotal()
		{
			return vtkImageHistogram.vtkImageHistogram_GetTotal_23(base.GetCppThis());
		}

		// Token: 0x06006B7D RID: 27517
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageHistogram_IsA_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006B7E RID: 27518 RVA: 0x0009B38C File Offset: 0x0009958C
		public override int IsA(string type)
		{
			return vtkImageHistogram.vtkImageHistogram_IsA_24(base.GetCppThis(), type);
		}

		// Token: 0x06006B7F RID: 27519
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageHistogram_IsTypeOf_25([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006B80 RID: 27520 RVA: 0x0009B3AC File Offset: 0x000995AC
		public new static int IsTypeOf(string type)
		{
			return vtkImageHistogram.vtkImageHistogram_IsTypeOf_25(type);
		}

		// Token: 0x06006B81 RID: 27521
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageHistogram_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006B82 RID: 27522 RVA: 0x0009B3C8 File Offset: 0x000995C8
		public new vtkImageHistogram NewInstance()
		{
			vtkImageHistogram result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageHistogram.vtkImageHistogram_NewInstance_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageHistogram)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006B83 RID: 27523
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageHistogram_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006B84 RID: 27524 RVA: 0x0009B424 File Offset: 0x00099624
		public new static vtkImageHistogram SafeDownCast(vtkObjectBase o)
		{
			vtkImageHistogram vtkImageHistogram = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageHistogram.vtkImageHistogram_SafeDownCast_28((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageHistogram = (vtkImageHistogram)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageHistogram.Register(null);
				}
			}
			return vtkImageHistogram;
		}

		// Token: 0x06006B85 RID: 27525
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageHistogram_SetActiveComponent_29(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the component for which to generate a histogram.  The default
		/// value is -1, which produces a histogram that is the sum of the
		/// histograms of the individual components.
		/// </summary>
		// Token: 0x06006B86 RID: 27526 RVA: 0x0009B4A3 File Offset: 0x000996A3
		public virtual void SetActiveComponent(int _arg)
		{
			vtkImageHistogram.vtkImageHistogram_SetActiveComponent_29(base.GetCppThis(), _arg);
		}

		// Token: 0x06006B87 RID: 27527
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageHistogram_SetAutomaticBinning_30(HandleRef pThis, int _arg);

		/// <summary>
		/// If this is On, then the histogram binning will be done automatically.
		/// For char and unsigned char data, there will be 256 bins with unit
		/// spacing.  For data of type short and larger, there will be between
		/// 256 and MaximumNumberOfBins, depending on the range of the data, and
		/// the BinOrigin will be set to zero if no negative values are present,
		/// or to the smallest negative value if negative values are present.
		/// For float data, the MaximumNumberOfBins will always be used.
		/// The BinOrigin and BinSpacing will be set so that they provide a mapping
		/// from bin index to scalar value.
		/// </summary>
		// Token: 0x06006B88 RID: 27528 RVA: 0x0009B4B3 File Offset: 0x000996B3
		public virtual void SetAutomaticBinning(int _arg)
		{
			vtkImageHistogram.vtkImageHistogram_SetAutomaticBinning_30(base.GetCppThis(), _arg);
		}

		// Token: 0x06006B89 RID: 27529
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageHistogram_SetBinOrigin_31(HandleRef pThis, double _arg);

		/// <summary>
		/// The value for the center of the first bin (default 0).  This is
		/// automatically computed unless AutomaticBinning is Off.
		/// </summary>
		// Token: 0x06006B8A RID: 27530 RVA: 0x0009B4C3 File Offset: 0x000996C3
		public virtual void SetBinOrigin(double _arg)
		{
			vtkImageHistogram.vtkImageHistogram_SetBinOrigin_31(base.GetCppThis(), _arg);
		}

		// Token: 0x06006B8B RID: 27531
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageHistogram_SetBinSpacing_32(HandleRef pThis, double _arg);

		/// <summary>
		/// The bin spacing (default 1).  This is automatically computed unless
		/// AutomaticBinning is Off.
		/// </summary>
		// Token: 0x06006B8C RID: 27532 RVA: 0x0009B4D3 File Offset: 0x000996D3
		public virtual void SetBinSpacing(double _arg)
		{
			vtkImageHistogram.vtkImageHistogram_SetBinSpacing_32(base.GetCppThis(), _arg);
		}

		// Token: 0x06006B8D RID: 27533
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageHistogram_SetGenerateHistogramImage_33(HandleRef pThis, int _arg);

		/// <summary>
		/// If this is On, then a histogram image will be produced as the output.
		/// Regardless of this setting, the histogram is always available as a
		/// vtkIdTypeArray from the GetHistogram method.
		/// </summary>
		// Token: 0x06006B8E RID: 27534 RVA: 0x0009B4E3 File Offset: 0x000996E3
		public virtual void SetGenerateHistogramImage(int _arg)
		{
			vtkImageHistogram.vtkImageHistogram_SetGenerateHistogramImage_33(base.GetCppThis(), _arg);
		}

		// Token: 0x06006B8F RID: 27535
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageHistogram_SetHistogramImageScale_34(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the scale to use for the histogram image.  The default is
		/// a linear scale, but sqrt and log provide better visualization.
		/// </summary>
		// Token: 0x06006B90 RID: 27536 RVA: 0x0009B4F3 File Offset: 0x000996F3
		public virtual void SetHistogramImageScale(int _arg)
		{
			vtkImageHistogram.vtkImageHistogram_SetHistogramImageScale_34(base.GetCppThis(), _arg);
		}

		// Token: 0x06006B91 RID: 27537
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageHistogram_SetHistogramImageScaleToLinear_35(HandleRef pThis);

		/// <summary>
		/// Set the scale to use for the histogram image.  The default is
		/// a linear scale, but sqrt and log provide better visualization.
		/// </summary>
		// Token: 0x06006B92 RID: 27538 RVA: 0x0009B503 File Offset: 0x00099703
		public void SetHistogramImageScaleToLinear()
		{
			vtkImageHistogram.vtkImageHistogram_SetHistogramImageScaleToLinear_35(base.GetCppThis());
		}

		// Token: 0x06006B93 RID: 27539
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageHistogram_SetHistogramImageScaleToLog_36(HandleRef pThis);

		/// <summary>
		/// Set the scale to use for the histogram image.  The default is
		/// a linear scale, but sqrt and log provide better visualization.
		/// </summary>
		// Token: 0x06006B94 RID: 27540 RVA: 0x0009B512 File Offset: 0x00099712
		public void SetHistogramImageScaleToLog()
		{
			vtkImageHistogram.vtkImageHistogram_SetHistogramImageScaleToLog_36(base.GetCppThis());
		}

		// Token: 0x06006B95 RID: 27541
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageHistogram_SetHistogramImageScaleToSqrt_37(HandleRef pThis);

		/// <summary>
		/// Set the scale to use for the histogram image.  The default is
		/// a linear scale, but sqrt and log provide better visualization.
		/// </summary>
		// Token: 0x06006B96 RID: 27542 RVA: 0x0009B521 File Offset: 0x00099721
		public void SetHistogramImageScaleToSqrt()
		{
			vtkImageHistogram.vtkImageHistogram_SetHistogramImageScaleToSqrt_37(base.GetCppThis());
		}

		// Token: 0x06006B97 RID: 27543
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageHistogram_SetHistogramImageSize_38(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Set the size of the histogram image that is produced as output.
		/// The default is 256 by 256.
		/// </summary>
		// Token: 0x06006B98 RID: 27544 RVA: 0x0009B530 File Offset: 0x00099730
		public virtual void SetHistogramImageSize(int _arg1, int _arg2)
		{
			vtkImageHistogram.vtkImageHistogram_SetHistogramImageSize_38(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x06006B99 RID: 27545
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageHistogram_SetHistogramImageSize_39(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the size of the histogram image that is produced as output.
		/// The default is 256 by 256.
		/// </summary>
		// Token: 0x06006B9A RID: 27546 RVA: 0x0009B541 File Offset: 0x00099741
		public void SetHistogramImageSize(IntPtr _arg)
		{
			vtkImageHistogram.vtkImageHistogram_SetHistogramImageSize_39(base.GetCppThis(), _arg);
		}

		// Token: 0x06006B9B RID: 27547
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageHistogram_SetMaximumNumberOfBins_40(HandleRef pThis, int _arg);

		/// <summary>
		/// The maximum number of bins to use when AutomaticBinning is On.
		/// When AutomaticBinning is On, the size of the output histogram
		/// will be set to the full range of the input data values, unless
		/// the full range is greater than this value.  By default, the max
		/// value is 65536, which is large enough to capture the full range
		/// of 16-bit integers.
		/// </summary>
		// Token: 0x06006B9C RID: 27548 RVA: 0x0009B551 File Offset: 0x00099751
		public virtual void SetMaximumNumberOfBins(int _arg)
		{
			vtkImageHistogram.vtkImageHistogram_SetMaximumNumberOfBins_40(base.GetCppThis(), _arg);
		}

		// Token: 0x06006B9D RID: 27549
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageHistogram_SetNumberOfBins_41(HandleRef pThis, int _arg);

		/// <summary>
		/// The number of bins in histogram (default 256).  This is automatically
		/// computed unless AutomaticBinning is Off.
		/// </summary>
		// Token: 0x06006B9E RID: 27550 RVA: 0x0009B561 File Offset: 0x00099761
		public virtual void SetNumberOfBins(int _arg)
		{
			vtkImageHistogram.vtkImageHistogram_SetNumberOfBins_41(base.GetCppThis(), _arg);
		}

		// Token: 0x06006B9F RID: 27551
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageHistogram_SetStencilConnection_42(HandleRef pThis, HandleRef algOutput);

		/// <summary>
		/// Equivalent to SetInputConnection(1, algOutput).
		/// </summary>
		// Token: 0x06006BA0 RID: 27552 RVA: 0x0009B574 File Offset: 0x00099774
		public void SetStencilConnection(vtkAlgorithmOutput algOutput)
		{
			vtkImageHistogram.vtkImageHistogram_SetStencilConnection_42(base.GetCppThis(), (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}

		// Token: 0x06006BA1 RID: 27553
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageHistogram_SetStencilData_43(HandleRef pThis, HandleRef stencil);

		/// <summary>
		/// Use a stencil to compute the histogram for just a part of the image.
		/// </summary>
		// Token: 0x06006BA2 RID: 27554 RVA: 0x0009B5A4 File Offset: 0x000997A4
		public void SetStencilData(vtkImageStencilData stencil)
		{
			vtkImageHistogram.vtkImageHistogram_SetStencilData_43(base.GetCppThis(), (stencil == null) ? default(HandleRef) : stencil.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400096F RID: 2415
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageHistogram";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000970 RID: 2416
		public new static readonly string MRClassNameKey = "class vtkImageHistogram";

		/// <summary>
		/// Scale types for the histogram image.
		/// </summary>
		// Token: 0x02000241 RID: 577
		public enum Linear_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000972 RID: 2418
			Linear,
			/// <summary>enum member</summary>
			// Token: 0x04000973 RID: 2419
			Log,
			/// <summary>enum member</summary>
			// Token: 0x04000974 RID: 2420
			Sqrt
		}
	}
}
