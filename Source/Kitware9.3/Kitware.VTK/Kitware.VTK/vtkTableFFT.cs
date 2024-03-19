using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTableFFT
	/// </summary>
	/// <remarks>
	///    FFT for table columns
	///
	/// vtkTableFFT performs the Fast Fourier Transform on the columns of a table.
	/// It can perform the FFT per block : this performs something close to the
	/// Welch method but it uses raw FFTs instead of periodograms. This allows to
	/// reduce the impact of noise as well as speeding up the filter when the input
	/// signal is too big.
	///
	/// It is also possible to apply a window on the input signal. If performing
	/// the FFT per block then the window will be applied to each block instead.
	///
	/// The filter will look for a "Time" array (case insensitive) to determine the
	/// sampling frequency. "Time" array is considered to have the same frequency
	/// all along. If no "Time" array is found then the filter use the default frequency
	/// value.
	///
	/// This filter will not apply the FFT on any arrays which names begin with 'vtk'.
	///
	/// This filter will consider arrays with 2 components as arrays of complex numbers,
	/// the first column representing the real part and the second the imaginary part.
	/// </remarks>
	// Token: 0x020008EB RID: 2283
	public class vtkTableFFT : vtkTableAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601790B RID: 96523 RVA: 0x0021101D File Offset: 0x0020F21D
		static vtkTableFFT()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTableFFT.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTableFFT"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601790C RID: 96524 RVA: 0x00211045 File Offset: 0x0020F245
		public vtkTableFFT(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601790D RID: 96525
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableFFT_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601790E RID: 96526 RVA: 0x00211054 File Offset: 0x0020F254
		public new static vtkTableFFT New()
		{
			vtkTableFFT result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTableFFT.vtkTableFFT_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTableFFT)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601790F RID: 96527 RVA: 0x002110A8 File Offset: 0x0020F2A8
		public vtkTableFFT() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTableFFT.vtkTableFFT_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06017910 RID: 96528 RVA: 0x002110EC File Offset: 0x0020F2EC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06017911 RID: 96529
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableFFT_AverageFftOff_01(HandleRef pThis);

		/// <summary>
		/// Specify if filter should use the Welch / periodogram method. If true the
		/// input should be split in multiple segment to compute an average fft across
		/// all segments / blocks.
		///
		/// Note that in this case, complex data and array with name started with "vtk"
		/// will be ignored.
		///
		/// @see vtkTableFFT::SetBlockSize(int)
		/// @see vtkTableFFT::SetBlockOverlap(int)
		///
		/// Default is false
		/// </summary>
		// Token: 0x06017912 RID: 96530 RVA: 0x002110F7 File Offset: 0x0020F2F7
		public virtual void AverageFftOff()
		{
			vtkTableFFT.vtkTableFFT_AverageFftOff_01(base.GetCppThis());
		}

		// Token: 0x06017913 RID: 96531
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableFFT_AverageFftOn_02(HandleRef pThis);

		/// <summary>
		/// Specify if filter should use the Welch / periodogram method. If true the
		/// input should be split in multiple segment to compute an average fft across
		/// all segments / blocks.
		///
		/// Note that in this case, complex data and array with name started with "vtk"
		/// will be ignored.
		///
		/// @see vtkTableFFT::SetBlockSize(int)
		/// @see vtkTableFFT::SetBlockOverlap(int)
		///
		/// Default is false
		/// </summary>
		// Token: 0x06017914 RID: 96532 RVA: 0x00211106 File Offset: 0x0020F306
		public virtual void AverageFftOn()
		{
			vtkTableFFT.vtkTableFFT_AverageFftOn_02(base.GetCppThis());
		}

		// Token: 0x06017915 RID: 96533
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableFFT_CreateFrequencyColumnOff_03(HandleRef pThis);

		/// <summary>
		/// Specify if the filter should create a frequency column based on a column
		/// named "time" (not case sensitive). An evenly-spaced time array is expected.
		///
		/// @see vtkTableFFT::SetDefaultSampleRate(double)
		///
		/// Default is false
		/// </summary>
		// Token: 0x06017916 RID: 96534 RVA: 0x00211115 File Offset: 0x0020F315
		public virtual void CreateFrequencyColumnOff()
		{
			vtkTableFFT.vtkTableFFT_CreateFrequencyColumnOff_03(base.GetCppThis());
		}

		// Token: 0x06017917 RID: 96535
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableFFT_CreateFrequencyColumnOn_04(HandleRef pThis);

		/// <summary>
		/// Specify if the filter should create a frequency column based on a column
		/// named "time" (not case sensitive). An evenly-spaced time array is expected.
		///
		/// @see vtkTableFFT::SetDefaultSampleRate(double)
		///
		/// Default is false
		/// </summary>
		// Token: 0x06017918 RID: 96536 RVA: 0x00211124 File Offset: 0x0020F324
		public virtual void CreateFrequencyColumnOn()
		{
			vtkTableFFT.vtkTableFFT_CreateFrequencyColumnOn_04(base.GetCppThis());
		}

		// Token: 0x06017919 RID: 96537
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableFFT_DetrendOff_05(HandleRef pThis);

		/// <summary>
		/// Remove trend on each segment before applying the FFT. This is a constant
		/// detrend where the mean of the signal is subtracted to the signal.
		/// Only used if AverageFft is true.
		///
		/// @see vtkTableFFT::SetAverageFft(bool)
		///
		/// Default is false.
		/// </summary>
		// Token: 0x0601791A RID: 96538 RVA: 0x00211133 File Offset: 0x0020F333
		public virtual void DetrendOff()
		{
			vtkTableFFT.vtkTableFFT_DetrendOff_05(base.GetCppThis());
		}

		// Token: 0x0601791B RID: 96539
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableFFT_DetrendOn_06(HandleRef pThis);

		/// <summary>
		/// Remove trend on each segment before applying the FFT. This is a constant
		/// detrend where the mean of the signal is subtracted to the signal.
		/// Only used if AverageFft is true.
		///
		/// @see vtkTableFFT::SetAverageFft(bool)
		///
		/// Default is false.
		/// </summary>
		// Token: 0x0601791C RID: 96540 RVA: 0x00211142 File Offset: 0x0020F342
		public virtual void DetrendOn()
		{
			vtkTableFFT.vtkTableFFT_DetrendOn_06(base.GetCppThis());
		}

		// Token: 0x0601791D RID: 96541
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTableFFT_GetAverageFft_07(HandleRef pThis);

		/// <summary>
		/// Specify if filter should use the Welch / periodogram method. If true the
		/// input should be split in multiple segment to compute an average fft across
		/// all segments / blocks.
		///
		/// Note that in this case, complex data and array with name started with "vtk"
		/// will be ignored.
		///
		/// @see vtkTableFFT::SetBlockSize(int)
		/// @see vtkTableFFT::SetBlockOverlap(int)
		///
		/// Default is false
		/// </summary>
		// Token: 0x0601791E RID: 96542 RVA: 0x00211154 File Offset: 0x0020F354
		public virtual bool GetAverageFft()
		{
			return vtkTableFFT.vtkTableFFT_GetAverageFft_07(base.GetCppThis()) != 0;
		}

		// Token: 0x0601791F RID: 96543
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableFFT_GetBlockOverlap_08(HandleRef pThis);

		/// <summary>
		/// Specify the number of samples which will overlap between each block / segment.
		/// If value is not in a valid range (ie &lt; 0 or &gt;= BlockSize) then the
		/// value BlockSize / 2 will be used. Only used if AverageFft is true.
		///
		/// @see vtkTableFFT::SetAverageFft(bool)
		/// @see vtkTableFFT::SetBlockSize(int)
		///
		/// Default is -1
		/// </summary>
		// Token: 0x06017920 RID: 96544 RVA: 0x0021117C File Offset: 0x0020F37C
		public virtual int GetBlockOverlap()
		{
			return vtkTableFFT.vtkTableFFT_GetBlockOverlap_08(base.GetCppThis());
		}

		// Token: 0x06017921 RID: 96545
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableFFT_GetBlockSize_09(HandleRef pThis);

		/// <summary>
		/// Specify the number of samples to use for each block / segment in the Welch
		/// method. Only used if AverageFft is true
		///
		/// @see vtkTableFFT::SetAverageFft(bool)
		///
		/// Default is 1024
		/// </summary>
		// Token: 0x06017922 RID: 96546 RVA: 0x0021119C File Offset: 0x0020F39C
		public virtual int GetBlockSize()
		{
			return vtkTableFFT.vtkTableFFT_GetBlockSize_09(base.GetCppThis());
		}

		// Token: 0x06017923 RID: 96547
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTableFFT_GetCreateFrequencyColumn_10(HandleRef pThis);

		/// <summary>
		/// Specify if the filter should create a frequency column based on a column
		/// named "time" (not case sensitive). An evenly-spaced time array is expected.
		///
		/// @see vtkTableFFT::SetDefaultSampleRate(double)
		///
		/// Default is false
		/// </summary>
		// Token: 0x06017924 RID: 96548 RVA: 0x002111BC File Offset: 0x0020F3BC
		public virtual bool GetCreateFrequencyColumn()
		{
			return vtkTableFFT.vtkTableFFT_GetCreateFrequencyColumn_10(base.GetCppThis()) != 0;
		}

		// Token: 0x06017925 RID: 96549
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTableFFT_GetDefaultSampleRate_11(HandleRef pThis);

		/// <summary>
		/// If the "Time" column is not found then this value will be used.
		/// Expressed in Hz.
		///
		/// Default is 10'000 (Hz)
		/// </summary>
		// Token: 0x06017926 RID: 96550 RVA: 0x002111E4 File Offset: 0x0020F3E4
		public virtual double GetDefaultSampleRate()
		{
			return vtkTableFFT.vtkTableFFT_GetDefaultSampleRate_11(base.GetCppThis());
		}

		// Token: 0x06017927 RID: 96551
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTableFFT_GetDetrend_12(HandleRef pThis);

		/// <summary>
		/// Remove trend on each segment before applying the FFT. This is a constant
		/// detrend where the mean of the signal is subtracted to the signal.
		/// Only used if AverageFft is true.
		///
		/// @see vtkTableFFT::SetAverageFft(bool)
		///
		/// Default is false.
		/// </summary>
		// Token: 0x06017928 RID: 96552 RVA: 0x00211204 File Offset: 0x0020F404
		public virtual bool GetDetrend()
		{
			return vtkTableFFT.vtkTableFFT_GetDetrend_12(base.GetCppThis()) != 0;
		}

		// Token: 0x06017929 RID: 96553
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTableFFT_GetNormalize_13(HandleRef pThis);

		/// <summary>
		/// Specify if the output should be normalized so that Parseval's theorem is
		/// respected. If enabled output will be scaled according to the number of samples
		/// and the window energy. Else the raw FFT will be returned as is. Only used if
		/// AverageFft is false.
		///
		/// @see vtkTableFFT::SetAverageFft(bool)
		///
		/// Default is false
		/// </summary>
		// Token: 0x0601792A RID: 96554 RVA: 0x0021122C File Offset: 0x0020F42C
		public virtual bool GetNormalize()
		{
			return vtkTableFFT.vtkTableFFT_GetNormalize_13(base.GetCppThis()) != 0;
		}

		// Token: 0x0601792B RID: 96555
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTableFFT_GetNumberOfGenerationsFromBase_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601792C RID: 96556 RVA: 0x00211254 File Offset: 0x0020F454
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTableFFT.vtkTableFFT_GetNumberOfGenerationsFromBase_14(base.GetCppThis(), type);
		}

		// Token: 0x0601792D RID: 96557
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTableFFT_GetNumberOfGenerationsFromBaseType_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601792E RID: 96558 RVA: 0x00211274 File Offset: 0x0020F474
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTableFFT.vtkTableFFT_GetNumberOfGenerationsFromBaseType_15(type);
		}

		// Token: 0x0601792F RID: 96559
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTableFFT_GetReturnOnesided_16(HandleRef pThis);

		/// <summary>
		/// Specify if the filter should use the optimized discrete fourier transform for
		/// real values and return a onesided spectrum : this will cause output columns to
		/// have from n to ((n / 2) + 1) values.
		/// If ReturnOnesided is true but the input contains columns with 2 components
		/// (aka complex data) or started with `vtk`, these columns will be ignored.
		///
		/// Default is false
		/// </summary>
		// Token: 0x06017930 RID: 96560 RVA: 0x00211290 File Offset: 0x0020F490
		public virtual bool GetReturnOnesided()
		{
			return vtkTableFFT.vtkTableFFT_GetReturnOnesided_16(base.GetCppThis()) != 0;
		}

		// Token: 0x06017931 RID: 96561
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableFFT_GetScalingMethod_17(HandleRef pThis);

		/// <summary>
		/// Set what scaling should be used when applying the Welch method. It uses vtkFFT::Scaling
		/// enum as values.
		///
		/// @see vtkFFT::Scaling
		///
		/// Default is vtkFFT::Scaling::Density (aka 0)
		/// </summary>
		// Token: 0x06017932 RID: 96562 RVA: 0x002112B8 File Offset: 0x0020F4B8
		public virtual int GetScalingMethod()
		{
			return vtkTableFFT.vtkTableFFT_GetScalingMethod_17(base.GetCppThis());
		}

		// Token: 0x06017933 RID: 96563
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableFFT_GetScalingMethodMaxValue_18(HandleRef pThis);

		/// <summary>
		/// Set what scaling should be used when applying the Welch method. It uses vtkFFT::Scaling
		/// enum as values.
		///
		/// @see vtkFFT::Scaling
		///
		/// Default is vtkFFT::Scaling::Density (aka 0)
		/// </summary>
		// Token: 0x06017934 RID: 96564 RVA: 0x002112D8 File Offset: 0x0020F4D8
		public virtual int GetScalingMethodMaxValue()
		{
			return vtkTableFFT.vtkTableFFT_GetScalingMethodMaxValue_18(base.GetCppThis());
		}

		// Token: 0x06017935 RID: 96565
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableFFT_GetScalingMethodMinValue_19(HandleRef pThis);

		/// <summary>
		/// Set what scaling should be used when applying the Welch method. It uses vtkFFT::Scaling
		/// enum as values.
		///
		/// @see vtkFFT::Scaling
		///
		/// Default is vtkFFT::Scaling::Density (aka 0)
		/// </summary>
		// Token: 0x06017936 RID: 96566 RVA: 0x002112F8 File Offset: 0x0020F4F8
		public virtual int GetScalingMethodMinValue()
		{
			return vtkTableFFT.vtkTableFFT_GetScalingMethodMinValue_19(base.GetCppThis());
		}

		// Token: 0x06017937 RID: 96567
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableFFT_GetWindowingFunction_20(HandleRef pThis);

		/// <summary>
		/// Specify the windowing function to apply on the input.
		/// If @c AverageFft is true the windowing function will be
		/// applied per block and not on the whole input.
		///
		/// Default is RECTANGULAR (does nothing)
		/// </summary>
		// Token: 0x06017938 RID: 96568 RVA: 0x00211318 File Offset: 0x0020F518
		public virtual int GetWindowingFunction()
		{
			return vtkTableFFT.vtkTableFFT_GetWindowingFunction_20(base.GetCppThis());
		}

		// Token: 0x06017939 RID: 96569
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableFFT_IsA_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601793A RID: 96570 RVA: 0x00211338 File Offset: 0x0020F538
		public override int IsA(string type)
		{
			return vtkTableFFT.vtkTableFFT_IsA_21(base.GetCppThis(), type);
		}

		// Token: 0x0601793B RID: 96571
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableFFT_IsTypeOf_22([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601793C RID: 96572 RVA: 0x00211358 File Offset: 0x0020F558
		public new static int IsTypeOf(string type)
		{
			return vtkTableFFT.vtkTableFFT_IsTypeOf_22(type);
		}

		// Token: 0x0601793D RID: 96573
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableFFT_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601793E RID: 96574 RVA: 0x00211374 File Offset: 0x0020F574
		public new vtkTableFFT NewInstance()
		{
			vtkTableFFT result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTableFFT.vtkTableFFT_NewInstance_24(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTableFFT)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601793F RID: 96575
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableFFT_NormalizeOff_25(HandleRef pThis);

		/// <summary>
		/// Specify if the output should be normalized so that Parseval's theorem is
		/// respected. If enabled output will be scaled according to the number of samples
		/// and the window energy. Else the raw FFT will be returned as is. Only used if
		/// AverageFft is false.
		///
		/// @see vtkTableFFT::SetAverageFft(bool)
		///
		/// Default is false
		/// </summary>
		// Token: 0x06017940 RID: 96576 RVA: 0x002113CE File Offset: 0x0020F5CE
		public virtual void NormalizeOff()
		{
			vtkTableFFT.vtkTableFFT_NormalizeOff_25(base.GetCppThis());
		}

		// Token: 0x06017941 RID: 96577
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableFFT_NormalizeOn_26(HandleRef pThis);

		/// <summary>
		/// Specify if the output should be normalized so that Parseval's theorem is
		/// respected. If enabled output will be scaled according to the number of samples
		/// and the window energy. Else the raw FFT will be returned as is. Only used if
		/// AverageFft is false.
		///
		/// @see vtkTableFFT::SetAverageFft(bool)
		///
		/// Default is false
		/// </summary>
		// Token: 0x06017942 RID: 96578 RVA: 0x002113DD File Offset: 0x0020F5DD
		public virtual void NormalizeOn()
		{
			vtkTableFFT.vtkTableFFT_NormalizeOn_26(base.GetCppThis());
		}

		// Token: 0x06017943 RID: 96579
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableFFT_ReturnOnesidedOff_27(HandleRef pThis);

		/// <summary>
		/// Specify if the filter should use the optimized discrete fourier transform for
		/// real values and return a onesided spectrum : this will cause output columns to
		/// have from n to ((n / 2) + 1) values.
		/// If ReturnOnesided is true but the input contains columns with 2 components
		/// (aka complex data) or started with `vtk`, these columns will be ignored.
		///
		/// Default is false
		/// </summary>
		// Token: 0x06017944 RID: 96580 RVA: 0x002113EC File Offset: 0x0020F5EC
		public virtual void ReturnOnesidedOff()
		{
			vtkTableFFT.vtkTableFFT_ReturnOnesidedOff_27(base.GetCppThis());
		}

		// Token: 0x06017945 RID: 96581
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableFFT_ReturnOnesidedOn_28(HandleRef pThis);

		/// <summary>
		/// Specify if the filter should use the optimized discrete fourier transform for
		/// real values and return a onesided spectrum : this will cause output columns to
		/// have from n to ((n / 2) + 1) values.
		/// If ReturnOnesided is true but the input contains columns with 2 components
		/// (aka complex data) or started with `vtk`, these columns will be ignored.
		///
		/// Default is false
		/// </summary>
		// Token: 0x06017946 RID: 96582 RVA: 0x002113FB File Offset: 0x0020F5FB
		public virtual void ReturnOnesidedOn()
		{
			vtkTableFFT.vtkTableFFT_ReturnOnesidedOn_28(base.GetCppThis());
		}

		// Token: 0x06017947 RID: 96583
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableFFT_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017948 RID: 96584 RVA: 0x0021140C File Offset: 0x0020F60C
		public new static vtkTableFFT SafeDownCast(vtkObjectBase o)
		{
			vtkTableFFT vtkTableFFT = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTableFFT.vtkTableFFT_SafeDownCast_29((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTableFFT = (vtkTableFFT)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTableFFT.Register(null);
				}
			}
			return vtkTableFFT;
		}

		// Token: 0x06017949 RID: 96585
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableFFT_SetAverageFft_30(HandleRef pThis, byte arg0);

		/// <summary>
		/// Specify if filter should use the Welch / periodogram method. If true the
		/// input should be split in multiple segment to compute an average fft across
		/// all segments / blocks.
		///
		/// Note that in this case, complex data and array with name started with "vtk"
		/// will be ignored.
		///
		/// @see vtkTableFFT::SetBlockSize(int)
		/// @see vtkTableFFT::SetBlockOverlap(int)
		///
		/// Default is false
		/// </summary>
		// Token: 0x0601794A RID: 96586 RVA: 0x0021148B File Offset: 0x0020F68B
		public virtual void SetAverageFft(bool arg0)
		{
			vtkTableFFT.vtkTableFFT_SetAverageFft_30(base.GetCppThis(), arg0 ? (byte)1 : (byte)0);
		}

		// Token: 0x0601794B RID: 96587
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableFFT_SetBlockOverlap_31(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the number of samples which will overlap between each block / segment.
		/// If value is not in a valid range (ie &lt; 0 or &gt;= BlockSize) then the
		/// value BlockSize / 2 will be used. Only used if AverageFft is true.
		///
		/// @see vtkTableFFT::SetAverageFft(bool)
		/// @see vtkTableFFT::SetBlockSize(int)
		///
		/// Default is -1
		/// </summary>
		// Token: 0x0601794C RID: 96588 RVA: 0x002114A3 File Offset: 0x0020F6A3
		public virtual void SetBlockOverlap(int _arg)
		{
			vtkTableFFT.vtkTableFFT_SetBlockOverlap_31(base.GetCppThis(), _arg);
		}

		// Token: 0x0601794D RID: 96589
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableFFT_SetBlockSize_32(HandleRef pThis, int arg0);

		/// <summary>
		/// Specify the number of samples to use for each block / segment in the Welch
		/// method. Only used if AverageFft is true
		///
		/// @see vtkTableFFT::SetAverageFft(bool)
		///
		/// Default is 1024
		/// </summary>
		// Token: 0x0601794E RID: 96590 RVA: 0x002114B3 File Offset: 0x0020F6B3
		public virtual void SetBlockSize(int arg0)
		{
			vtkTableFFT.vtkTableFFT_SetBlockSize_32(base.GetCppThis(), arg0);
		}

		// Token: 0x0601794F RID: 96591
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableFFT_SetCreateFrequencyColumn_33(HandleRef pThis, byte _arg);

		/// <summary>
		/// Specify if the filter should create a frequency column based on a column
		/// named "time" (not case sensitive). An evenly-spaced time array is expected.
		///
		/// @see vtkTableFFT::SetDefaultSampleRate(double)
		///
		/// Default is false
		/// </summary>
		// Token: 0x06017950 RID: 96592 RVA: 0x002114C3 File Offset: 0x0020F6C3
		public virtual void SetCreateFrequencyColumn(bool _arg)
		{
			vtkTableFFT.vtkTableFFT_SetCreateFrequencyColumn_33(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06017951 RID: 96593
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableFFT_SetDefaultSampleRate_34(HandleRef pThis, double _arg);

		/// <summary>
		/// If the "Time" column is not found then this value will be used.
		/// Expressed in Hz.
		///
		/// Default is 10'000 (Hz)
		/// </summary>
		// Token: 0x06017952 RID: 96594 RVA: 0x002114DB File Offset: 0x0020F6DB
		public virtual void SetDefaultSampleRate(double _arg)
		{
			vtkTableFFT.vtkTableFFT_SetDefaultSampleRate_34(base.GetCppThis(), _arg);
		}

		// Token: 0x06017953 RID: 96595
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableFFT_SetDetrend_35(HandleRef pThis, byte _arg);

		/// <summary>
		/// Remove trend on each segment before applying the FFT. This is a constant
		/// detrend where the mean of the signal is subtracted to the signal.
		/// Only used if AverageFft is true.
		///
		/// @see vtkTableFFT::SetAverageFft(bool)
		///
		/// Default is false.
		/// </summary>
		// Token: 0x06017954 RID: 96596 RVA: 0x002114EB File Offset: 0x0020F6EB
		public virtual void SetDetrend(bool _arg)
		{
			vtkTableFFT.vtkTableFFT_SetDetrend_35(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06017955 RID: 96597
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableFFT_SetNormalize_36(HandleRef pThis, byte _arg);

		/// <summary>
		/// Specify if the output should be normalized so that Parseval's theorem is
		/// respected. If enabled output will be scaled according to the number of samples
		/// and the window energy. Else the raw FFT will be returned as is. Only used if
		/// AverageFft is false.
		///
		/// @see vtkTableFFT::SetAverageFft(bool)
		///
		/// Default is false
		/// </summary>
		// Token: 0x06017956 RID: 96598 RVA: 0x00211503 File Offset: 0x0020F703
		public virtual void SetNormalize(bool _arg)
		{
			vtkTableFFT.vtkTableFFT_SetNormalize_36(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06017957 RID: 96599
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableFFT_SetReturnOnesided_37(HandleRef pThis, byte _arg);

		/// <summary>
		/// Specify if the filter should use the optimized discrete fourier transform for
		/// real values and return a onesided spectrum : this will cause output columns to
		/// have from n to ((n / 2) + 1) values.
		/// If ReturnOnesided is true but the input contains columns with 2 components
		/// (aka complex data) or started with `vtk`, these columns will be ignored.
		///
		/// Default is false
		/// </summary>
		// Token: 0x06017958 RID: 96600 RVA: 0x0021151B File Offset: 0x0020F71B
		public virtual void SetReturnOnesided(bool _arg)
		{
			vtkTableFFT.vtkTableFFT_SetReturnOnesided_37(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06017959 RID: 96601
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableFFT_SetScalingMethod_38(HandleRef pThis, int _arg);

		/// <summary>
		/// Set what scaling should be used when applying the Welch method. It uses vtkFFT::Scaling
		/// enum as values.
		///
		/// @see vtkFFT::Scaling
		///
		/// Default is vtkFFT::Scaling::Density (aka 0)
		/// </summary>
		// Token: 0x0601795A RID: 96602 RVA: 0x00211533 File Offset: 0x0020F733
		public virtual void SetScalingMethod(int _arg)
		{
			vtkTableFFT.vtkTableFFT_SetScalingMethod_38(base.GetCppThis(), _arg);
		}

		// Token: 0x0601795B RID: 96603
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableFFT_SetWindowingFunction_39(HandleRef pThis, int arg0);

		/// <summary>
		/// Specify the windowing function to apply on the input.
		/// If @c AverageFft is true the windowing function will be
		/// applied per block and not on the whole input.
		///
		/// Default is RECTANGULAR (does nothing)
		/// </summary>
		// Token: 0x0601795C RID: 96604 RVA: 0x00211543 File Offset: 0x0020F743
		public virtual void SetWindowingFunction(int arg0)
		{
			vtkTableFFT.vtkTableFFT_SetWindowingFunction_39(base.GetCppThis(), arg0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A50 RID: 6736
		public new const string MRFullTypeName = "Kitware.VTK.vtkTableFFT";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A51 RID: 6737
		public new static readonly string MRClassNameKey = "class vtkTableFFT";

		/// <summary>
		/// Enum allowing to choose the windowing function to apply on the input signal.
		/// </summary>
		// Token: 0x020008EC RID: 2284
		public enum BARTLETT_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04001A53 RID: 6739
			BARTLETT = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001A54 RID: 6740
			BLACKMAN = 3,
			/// <summary>enum member</summary>
			// Token: 0x04001A55 RID: 6741
			HANNING = 0,
			/// <summary>enum member</summary>
			// Token: 0x04001A56 RID: 6742
			MAX_WINDOWING_FUNCTION = 5,
			/// <summary>enum member</summary>
			// Token: 0x04001A57 RID: 6743
			RECTANGULAR = 4,
			/// <summary>enum member</summary>
			// Token: 0x04001A58 RID: 6744
			SINE = 2
		}
	}
}
