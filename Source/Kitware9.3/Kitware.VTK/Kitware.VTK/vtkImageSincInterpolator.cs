using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageSincInterpolator
	/// </summary>
	/// <remarks>
	///    perform sinc interpolation on images
	///
	/// vtkImageSincInterpolator provides various windowed sinc interpolation
	/// methods for image data.  The default is a five-lobed Lanczos interpolant,
	/// with a kernel size of 6.  The interpolator can also bandlimit the image,
	/// which can be used for antialiasing.  The interpolation kernels are
	/// evaluated via a lookup table for efficiency.
	/// @par Thanks:
	/// Thanks to David Gobbi at the Seaman Family MR Centre and Dept. of Clinical
	/// Neurosciences, Foothills Medical Centre, Calgary, for providing this class.
	/// </remarks>
	/// <seealso>
	///
	/// vtkImageReslice
	/// </seealso>
	// Token: 0x02000867 RID: 2151
	public class vtkImageSincInterpolator : vtkAbstractImageInterpolator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060164E6 RID: 91366 RVA: 0x001F616B File Offset: 0x001F436B
		static vtkImageSincInterpolator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageSincInterpolator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageSincInterpolator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060164E7 RID: 91367 RVA: 0x001F6193 File Offset: 0x001F4393
		public vtkImageSincInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060164E8 RID: 91368
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSincInterpolator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060164E9 RID: 91369 RVA: 0x001F61A4 File Offset: 0x001F43A4
		public new static vtkImageSincInterpolator New()
		{
			vtkImageSincInterpolator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageSincInterpolator.vtkImageSincInterpolator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageSincInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060164EA RID: 91370 RVA: 0x001F61F8 File Offset: 0x001F43F8
		public vtkImageSincInterpolator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageSincInterpolator.vtkImageSincInterpolator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060164EB RID: 91371 RVA: 0x001F623C File Offset: 0x001F443C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060164EC RID: 91372
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSincInterpolator_AntialiasingOff_01(HandleRef pThis);

		/// <summary>
		/// Turn on antialiasing.  If antialiasing is on, then the BlurFactors
		/// will be computed automatically from the output sampling rate such that
		/// that the image will be bandlimited to the Nyquist frequency.  This
		/// is only applicable when the interpolator is being used by a resampling
		/// filter like vtkImageReslice.  Such a filter will indicate the output
		/// sampling by calling the interpolator's ComputeSupportSize() method,
		/// which will compute the blur factors at the same time that it computes
		/// the support size.
		/// </summary>
		// Token: 0x060164ED RID: 91373 RVA: 0x001F6247 File Offset: 0x001F4447
		public void AntialiasingOff()
		{
			vtkImageSincInterpolator.vtkImageSincInterpolator_AntialiasingOff_01(base.GetCppThis());
		}

		// Token: 0x060164EE RID: 91374
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSincInterpolator_AntialiasingOn_02(HandleRef pThis);

		/// <summary>
		/// Turn on antialiasing.  If antialiasing is on, then the BlurFactors
		/// will be computed automatically from the output sampling rate such that
		/// that the image will be bandlimited to the Nyquist frequency.  This
		/// is only applicable when the interpolator is being used by a resampling
		/// filter like vtkImageReslice.  Such a filter will indicate the output
		/// sampling by calling the interpolator's ComputeSupportSize() method,
		/// which will compute the blur factors at the same time that it computes
		/// the support size.
		/// </summary>
		// Token: 0x060164EF RID: 91375 RVA: 0x001F6256 File Offset: 0x001F4456
		public void AntialiasingOn()
		{
			vtkImageSincInterpolator.vtkImageSincInterpolator_AntialiasingOn_02(base.GetCppThis());
		}

		// Token: 0x060164F0 RID: 91376
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSincInterpolator_ComputeSupportSize_03(HandleRef pThis, IntPtr matrix, IntPtr support);

		/// <summary>
		/// Get the support size for use in computing update extents.  If the data
		/// will be sampled on a regular grid, then pass a matrix describing the
		/// structured coordinate transformation between the output and the input.
		/// Otherwise, pass nullptr as the matrix to retrieve the full kernel size.
		/// </summary>
		// Token: 0x060164F1 RID: 91377 RVA: 0x001F6265 File Offset: 0x001F4465
		public override void ComputeSupportSize(IntPtr matrix, IntPtr support)
		{
			vtkImageSincInterpolator.vtkImageSincInterpolator_ComputeSupportSize_03(base.GetCppThis(), matrix, support);
		}

		// Token: 0x060164F2 RID: 91378
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSincInterpolator_GetAntialiasing_04(HandleRef pThis);

		/// <summary>
		/// Turn on antialiasing.  If antialiasing is on, then the BlurFactors
		/// will be computed automatically from the output sampling rate such that
		/// that the image will be bandlimited to the Nyquist frequency.  This
		/// is only applicable when the interpolator is being used by a resampling
		/// filter like vtkImageReslice.  Such a filter will indicate the output
		/// sampling by calling the interpolator's ComputeSupportSize() method,
		/// which will compute the blur factors at the same time that it computes
		/// the support size.
		/// </summary>
		// Token: 0x060164F3 RID: 91379 RVA: 0x001F6278 File Offset: 0x001F4478
		public int GetAntialiasing()
		{
			return vtkImageSincInterpolator.vtkImageSincInterpolator_GetAntialiasing_04(base.GetCppThis());
		}

		// Token: 0x060164F4 RID: 91380
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSincInterpolator_GetBlurFactors_05(HandleRef pThis, IntPtr f);

		/// <summary>
		/// Blur the image by widening the windowed sinc kernel by the specified
		/// factors for the x, y, and z directions.  This reduces the bandwidth
		/// by these same factors.  If you turn Antialiasing on, then the blur
		/// factors will be computed automatically from the output sampling rate.
		/// Blurring increases the computation time because the kernel size
		/// increases by the blur factor.
		/// </summary>
		// Token: 0x060164F5 RID: 91381 RVA: 0x001F6297 File Offset: 0x001F4497
		public void GetBlurFactors(IntPtr f)
		{
			vtkImageSincInterpolator.vtkImageSincInterpolator_GetBlurFactors_05(base.GetCppThis(), f);
		}

		// Token: 0x060164F6 RID: 91382
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSincInterpolator_GetBlurFactors_06(HandleRef pThis);

		/// <summary>
		/// Blur the image by widening the windowed sinc kernel by the specified
		/// factors for the x, y, and z directions.  This reduces the bandwidth
		/// by these same factors.  If you turn Antialiasing on, then the blur
		/// factors will be computed automatically from the output sampling rate.
		/// Blurring increases the computation time because the kernel size
		/// increases by the blur factor.
		/// </summary>
		// Token: 0x060164F7 RID: 91383 RVA: 0x001F62A8 File Offset: 0x001F44A8
		public double[] GetBlurFactors()
		{
			IntPtr intPtr = vtkImageSincInterpolator.vtkImageSincInterpolator_GetBlurFactors_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060164F8 RID: 91384
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageSincInterpolator_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060164F9 RID: 91385 RVA: 0x001F62F0 File Offset: 0x001F44F0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageSincInterpolator.vtkImageSincInterpolator_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x060164FA RID: 91386
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageSincInterpolator_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060164FB RID: 91387 RVA: 0x001F6310 File Offset: 0x001F4510
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageSincInterpolator.vtkImageSincInterpolator_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x060164FC RID: 91388
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSincInterpolator_GetRenormalization_09(HandleRef pThis);

		/// <summary>
		/// Turn off renormalization.  Most of the sinc windows provide kernels
		/// for which the weights do not sum to one, and for which the sum depends
		/// on the offset.  This results in small ripple artifacts in the output.
		/// By default, the vtkImageSincInterpolator will renormalize these kernels.
		/// This method allows the renormalization to be turned off.
		/// </summary>
		// Token: 0x060164FD RID: 91389 RVA: 0x001F632C File Offset: 0x001F452C
		public int GetRenormalization()
		{
			return vtkImageSincInterpolator.vtkImageSincInterpolator_GetRenormalization_09(base.GetCppThis());
		}

		// Token: 0x060164FE RID: 91390
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSincInterpolator_GetUseWindowParameter_10(HandleRef pThis);

		/// <summary>
		/// Turn this on in order to use SetWindowParameter.  If it is off,
		/// then the default parameter will be used for the window.
		/// </summary>
		// Token: 0x060164FF RID: 91391 RVA: 0x001F634C File Offset: 0x001F454C
		public int GetUseWindowParameter()
		{
			return vtkImageSincInterpolator.vtkImageSincInterpolator_GetUseWindowParameter_10(base.GetCppThis());
		}

		// Token: 0x06016500 RID: 91392
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSincInterpolator_GetWindowFunction_11(HandleRef pThis);

		/// <summary>
		/// The window function to use.  The default is Lanczos, which is very
		/// popular and performs well with a kernel width of 6.  The Cosine
		/// window is included for historical reasons.  All other windows are
		/// described in AH Nuttall, "Some windows with very good sidelobe
		/// behavior," IEEE Transactions on Acoustics, Speech, and Signal
		/// Processing 29:84-91, 1981.
		/// </summary>
		// Token: 0x06016501 RID: 91393 RVA: 0x001F636C File Offset: 0x001F456C
		public int GetWindowFunction()
		{
			return vtkImageSincInterpolator.vtkImageSincInterpolator_GetWindowFunction_11(base.GetCppThis());
		}

		// Token: 0x06016502 RID: 91394
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSincInterpolator_GetWindowFunctionAsString_12(HandleRef pThis);

		/// <summary>
		/// The window function to use.  The default is Lanczos, which is very
		/// popular and performs well with a kernel width of 6.  The Cosine
		/// window is included for historical reasons.  All other windows are
		/// described in AH Nuttall, "Some windows with very good sidelobe
		/// behavior," IEEE Transactions on Acoustics, Speech, and Signal
		/// Processing 29:84-91, 1981.
		/// </summary>
		// Token: 0x06016503 RID: 91395 RVA: 0x001F638C File Offset: 0x001F458C
		public virtual string GetWindowFunctionAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkImageSincInterpolator.vtkImageSincInterpolator_GetWindowFunctionAsString_12(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06016504 RID: 91396
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSincInterpolator_GetWindowHalfWidth_13(HandleRef pThis);

		/// <summary>
		/// Set the window half-width, this must be an integer between 1 and 16,
		/// with a default value of 3.  The kernel size will be twice this value
		/// if no blur factors are applied. The total number of sinc lobes will
		/// be one less than twice the half-width, so if the half-width is 3 then
		/// the kernel size will be 6 and there will be 5 sinc lobes.
		/// </summary>
		// Token: 0x06016505 RID: 91397 RVA: 0x001F63C8 File Offset: 0x001F45C8
		public int GetWindowHalfWidth()
		{
			return vtkImageSincInterpolator.vtkImageSincInterpolator_GetWindowHalfWidth_13(base.GetCppThis());
		}

		// Token: 0x06016506 RID: 91398
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageSincInterpolator_GetWindowParameter_14(HandleRef pThis);

		/// <summary>
		/// Set the alpha parameter for the Kaiser window function.
		/// This parameter will be ignored unless UseWindowParameter is On.
		/// If UseWindowParameter is Off, then alpha is set to be the same as n
		/// where n is the window half-width.  Using an alpha less than n
		/// increases the sharpness and ringing, while using an alpha greater
		/// than n increases the blurring.
		/// </summary>
		// Token: 0x06016507 RID: 91399 RVA: 0x001F63E8 File Offset: 0x001F45E8
		public double GetWindowParameter()
		{
			return vtkImageSincInterpolator.vtkImageSincInterpolator_GetWindowParameter_14(base.GetCppThis());
		}

		// Token: 0x06016508 RID: 91400
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSincInterpolator_IsA_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016509 RID: 91401 RVA: 0x001F6408 File Offset: 0x001F4608
		public override int IsA(string type)
		{
			return vtkImageSincInterpolator.vtkImageSincInterpolator_IsA_15(base.GetCppThis(), type);
		}

		// Token: 0x0601650A RID: 91402
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkImageSincInterpolator_IsSeparable_16(HandleRef pThis);

		/// <summary>
		/// Returns true if the interpolator supports weight precomputation.
		/// This will always return true for this interpolator.
		/// </summary>
		// Token: 0x0601650B RID: 91403 RVA: 0x001F6428 File Offset: 0x001F4628
		public override bool IsSeparable()
		{
			return vtkImageSincInterpolator.vtkImageSincInterpolator_IsSeparable_16(base.GetCppThis()) != 0;
		}

		// Token: 0x0601650C RID: 91404
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSincInterpolator_IsTypeOf_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601650D RID: 91405 RVA: 0x001F6450 File Offset: 0x001F4650
		public new static int IsTypeOf(string type)
		{
			return vtkImageSincInterpolator.vtkImageSincInterpolator_IsTypeOf_17(type);
		}

		// Token: 0x0601650E RID: 91406
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSincInterpolator_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601650F RID: 91407 RVA: 0x001F646C File Offset: 0x001F466C
		public new vtkImageSincInterpolator NewInstance()
		{
			vtkImageSincInterpolator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageSincInterpolator.vtkImageSincInterpolator_NewInstance_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageSincInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016510 RID: 91408
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSincInterpolator_RenormalizationOff_20(HandleRef pThis);

		/// <summary>
		/// Turn off renormalization.  Most of the sinc windows provide kernels
		/// for which the weights do not sum to one, and for which the sum depends
		/// on the offset.  This results in small ripple artifacts in the output.
		/// By default, the vtkImageSincInterpolator will renormalize these kernels.
		/// This method allows the renormalization to be turned off.
		/// </summary>
		// Token: 0x06016511 RID: 91409 RVA: 0x001F64C6 File Offset: 0x001F46C6
		public void RenormalizationOff()
		{
			vtkImageSincInterpolator.vtkImageSincInterpolator_RenormalizationOff_20(base.GetCppThis());
		}

		// Token: 0x06016512 RID: 91410
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSincInterpolator_RenormalizationOn_21(HandleRef pThis);

		/// <summary>
		/// Turn off renormalization.  Most of the sinc windows provide kernels
		/// for which the weights do not sum to one, and for which the sum depends
		/// on the offset.  This results in small ripple artifacts in the output.
		/// By default, the vtkImageSincInterpolator will renormalize these kernels.
		/// This method allows the renormalization to be turned off.
		/// </summary>
		// Token: 0x06016513 RID: 91411 RVA: 0x001F64D5 File Offset: 0x001F46D5
		public void RenormalizationOn()
		{
			vtkImageSincInterpolator.vtkImageSincInterpolator_RenormalizationOn_21(base.GetCppThis());
		}

		// Token: 0x06016514 RID: 91412
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSincInterpolator_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016515 RID: 91413 RVA: 0x001F64E4 File Offset: 0x001F46E4
		public new static vtkImageSincInterpolator SafeDownCast(vtkObjectBase o)
		{
			vtkImageSincInterpolator vtkImageSincInterpolator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageSincInterpolator.vtkImageSincInterpolator_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageSincInterpolator = (vtkImageSincInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageSincInterpolator.Register(null);
				}
			}
			return vtkImageSincInterpolator;
		}

		// Token: 0x06016516 RID: 91414
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSincInterpolator_SetAntialiasing_23(HandleRef pThis, int antialiasing);

		/// <summary>
		/// Turn on antialiasing.  If antialiasing is on, then the BlurFactors
		/// will be computed automatically from the output sampling rate such that
		/// that the image will be bandlimited to the Nyquist frequency.  This
		/// is only applicable when the interpolator is being used by a resampling
		/// filter like vtkImageReslice.  Such a filter will indicate the output
		/// sampling by calling the interpolator's ComputeSupportSize() method,
		/// which will compute the blur factors at the same time that it computes
		/// the support size.
		/// </summary>
		// Token: 0x06016517 RID: 91415 RVA: 0x001F6563 File Offset: 0x001F4763
		public void SetAntialiasing(int antialiasing)
		{
			vtkImageSincInterpolator.vtkImageSincInterpolator_SetAntialiasing_23(base.GetCppThis(), antialiasing);
		}

		// Token: 0x06016518 RID: 91416
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSincInterpolator_SetBlurFactors_24(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Blur the image by widening the windowed sinc kernel by the specified
		/// factors for the x, y, and z directions.  This reduces the bandwidth
		/// by these same factors.  If you turn Antialiasing on, then the blur
		/// factors will be computed automatically from the output sampling rate.
		/// Blurring increases the computation time because the kernel size
		/// increases by the blur factor.
		/// </summary>
		// Token: 0x06016519 RID: 91417 RVA: 0x001F6573 File Offset: 0x001F4773
		public void SetBlurFactors(double x, double y, double z)
		{
			vtkImageSincInterpolator.vtkImageSincInterpolator_SetBlurFactors_24(base.GetCppThis(), x, y, z);
		}

		// Token: 0x0601651A RID: 91418
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSincInterpolator_SetBlurFactors_25(HandleRef pThis, IntPtr f);

		/// <summary>
		/// Blur the image by widening the windowed sinc kernel by the specified
		/// factors for the x, y, and z directions.  This reduces the bandwidth
		/// by these same factors.  If you turn Antialiasing on, then the blur
		/// factors will be computed automatically from the output sampling rate.
		/// Blurring increases the computation time because the kernel size
		/// increases by the blur factor.
		/// </summary>
		// Token: 0x0601651B RID: 91419 RVA: 0x001F6585 File Offset: 0x001F4785
		public void SetBlurFactors(IntPtr f)
		{
			vtkImageSincInterpolator.vtkImageSincInterpolator_SetBlurFactors_25(base.GetCppThis(), f);
		}

		// Token: 0x0601651C RID: 91420
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSincInterpolator_SetRenormalization_26(HandleRef pThis, int renormalization);

		/// <summary>
		/// Turn off renormalization.  Most of the sinc windows provide kernels
		/// for which the weights do not sum to one, and for which the sum depends
		/// on the offset.  This results in small ripple artifacts in the output.
		/// By default, the vtkImageSincInterpolator will renormalize these kernels.
		/// This method allows the renormalization to be turned off.
		/// </summary>
		// Token: 0x0601651D RID: 91421 RVA: 0x001F6595 File Offset: 0x001F4795
		public void SetRenormalization(int renormalization)
		{
			vtkImageSincInterpolator.vtkImageSincInterpolator_SetRenormalization_26(base.GetCppThis(), renormalization);
		}

		// Token: 0x0601651E RID: 91422
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSincInterpolator_SetUseWindowParameter_27(HandleRef pThis, int val);

		/// <summary>
		/// Turn this on in order to use SetWindowParameter.  If it is off,
		/// then the default parameter will be used for the window.
		/// </summary>
		// Token: 0x0601651F RID: 91423 RVA: 0x001F65A5 File Offset: 0x001F47A5
		public void SetUseWindowParameter(int val)
		{
			vtkImageSincInterpolator.vtkImageSincInterpolator_SetUseWindowParameter_27(base.GetCppThis(), val);
		}

		// Token: 0x06016520 RID: 91424
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSincInterpolator_SetWindowFunction_28(HandleRef pThis, int mode);

		/// <summary>
		/// The window function to use.  The default is Lanczos, which is very
		/// popular and performs well with a kernel width of 6.  The Cosine
		/// window is included for historical reasons.  All other windows are
		/// described in AH Nuttall, "Some windows with very good sidelobe
		/// behavior," IEEE Transactions on Acoustics, Speech, and Signal
		/// Processing 29:84-91, 1981.
		/// </summary>
		// Token: 0x06016521 RID: 91425 RVA: 0x001F65B5 File Offset: 0x001F47B5
		public virtual void SetWindowFunction(int mode)
		{
			vtkImageSincInterpolator.vtkImageSincInterpolator_SetWindowFunction_28(base.GetCppThis(), mode);
		}

		// Token: 0x06016522 RID: 91426
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSincInterpolator_SetWindowFunctionToBlackman_29(HandleRef pThis);

		/// <summary>
		/// The window function to use.  The default is Lanczos, which is very
		/// popular and performs well with a kernel width of 6.  The Cosine
		/// window is included for historical reasons.  All other windows are
		/// described in AH Nuttall, "Some windows with very good sidelobe
		/// behavior," IEEE Transactions on Acoustics, Speech, and Signal
		/// Processing 29:84-91, 1981.
		/// </summary>
		// Token: 0x06016523 RID: 91427 RVA: 0x001F65C5 File Offset: 0x001F47C5
		public void SetWindowFunctionToBlackman()
		{
			vtkImageSincInterpolator.vtkImageSincInterpolator_SetWindowFunctionToBlackman_29(base.GetCppThis());
		}

		// Token: 0x06016524 RID: 91428
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSincInterpolator_SetWindowFunctionToBlackmanHarris3_30(HandleRef pThis);

		/// <summary>
		/// The window function to use.  The default is Lanczos, which is very
		/// popular and performs well with a kernel width of 6.  The Cosine
		/// window is included for historical reasons.  All other windows are
		/// described in AH Nuttall, "Some windows with very good sidelobe
		/// behavior," IEEE Transactions on Acoustics, Speech, and Signal
		/// Processing 29:84-91, 1981.
		/// </summary>
		// Token: 0x06016525 RID: 91429 RVA: 0x001F65D4 File Offset: 0x001F47D4
		public void SetWindowFunctionToBlackmanHarris3()
		{
			vtkImageSincInterpolator.vtkImageSincInterpolator_SetWindowFunctionToBlackmanHarris3_30(base.GetCppThis());
		}

		// Token: 0x06016526 RID: 91430
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSincInterpolator_SetWindowFunctionToBlackmanHarris4_31(HandleRef pThis);

		/// <summary>
		/// The window function to use.  The default is Lanczos, which is very
		/// popular and performs well with a kernel width of 6.  The Cosine
		/// window is included for historical reasons.  All other windows are
		/// described in AH Nuttall, "Some windows with very good sidelobe
		/// behavior," IEEE Transactions on Acoustics, Speech, and Signal
		/// Processing 29:84-91, 1981.
		/// </summary>
		// Token: 0x06016527 RID: 91431 RVA: 0x001F65E3 File Offset: 0x001F47E3
		public void SetWindowFunctionToBlackmanHarris4()
		{
			vtkImageSincInterpolator.vtkImageSincInterpolator_SetWindowFunctionToBlackmanHarris4_31(base.GetCppThis());
		}

		// Token: 0x06016528 RID: 91432
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSincInterpolator_SetWindowFunctionToBlackmanNuttall3_32(HandleRef pThis);

		/// <summary>
		/// The window function to use.  The default is Lanczos, which is very
		/// popular and performs well with a kernel width of 6.  The Cosine
		/// window is included for historical reasons.  All other windows are
		/// described in AH Nuttall, "Some windows with very good sidelobe
		/// behavior," IEEE Transactions on Acoustics, Speech, and Signal
		/// Processing 29:84-91, 1981.
		/// </summary>
		// Token: 0x06016529 RID: 91433 RVA: 0x001F65F2 File Offset: 0x001F47F2
		public void SetWindowFunctionToBlackmanNuttall3()
		{
			vtkImageSincInterpolator.vtkImageSincInterpolator_SetWindowFunctionToBlackmanNuttall3_32(base.GetCppThis());
		}

		// Token: 0x0601652A RID: 91434
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSincInterpolator_SetWindowFunctionToBlackmanNuttall4_33(HandleRef pThis);

		/// <summary>
		/// The window function to use.  The default is Lanczos, which is very
		/// popular and performs well with a kernel width of 6.  The Cosine
		/// window is included for historical reasons.  All other windows are
		/// described in AH Nuttall, "Some windows with very good sidelobe
		/// behavior," IEEE Transactions on Acoustics, Speech, and Signal
		/// Processing 29:84-91, 1981.
		/// </summary>
		// Token: 0x0601652B RID: 91435 RVA: 0x001F6601 File Offset: 0x001F4801
		public void SetWindowFunctionToBlackmanNuttall4()
		{
			vtkImageSincInterpolator.vtkImageSincInterpolator_SetWindowFunctionToBlackmanNuttall4_33(base.GetCppThis());
		}

		// Token: 0x0601652C RID: 91436
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSincInterpolator_SetWindowFunctionToCosine_34(HandleRef pThis);

		/// <summary>
		/// The window function to use.  The default is Lanczos, which is very
		/// popular and performs well with a kernel width of 6.  The Cosine
		/// window is included for historical reasons.  All other windows are
		/// described in AH Nuttall, "Some windows with very good sidelobe
		/// behavior," IEEE Transactions on Acoustics, Speech, and Signal
		/// Processing 29:84-91, 1981.
		/// </summary>
		// Token: 0x0601652D RID: 91437 RVA: 0x001F6610 File Offset: 0x001F4810
		public void SetWindowFunctionToCosine()
		{
			vtkImageSincInterpolator.vtkImageSincInterpolator_SetWindowFunctionToCosine_34(base.GetCppThis());
		}

		// Token: 0x0601652E RID: 91438
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSincInterpolator_SetWindowFunctionToHamming_35(HandleRef pThis);

		/// <summary>
		/// The window function to use.  The default is Lanczos, which is very
		/// popular and performs well with a kernel width of 6.  The Cosine
		/// window is included for historical reasons.  All other windows are
		/// described in AH Nuttall, "Some windows with very good sidelobe
		/// behavior," IEEE Transactions on Acoustics, Speech, and Signal
		/// Processing 29:84-91, 1981.
		/// </summary>
		// Token: 0x0601652F RID: 91439 RVA: 0x001F661F File Offset: 0x001F481F
		public void SetWindowFunctionToHamming()
		{
			vtkImageSincInterpolator.vtkImageSincInterpolator_SetWindowFunctionToHamming_35(base.GetCppThis());
		}

		// Token: 0x06016530 RID: 91440
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSincInterpolator_SetWindowFunctionToHann_36(HandleRef pThis);

		/// <summary>
		/// The window function to use.  The default is Lanczos, which is very
		/// popular and performs well with a kernel width of 6.  The Cosine
		/// window is included for historical reasons.  All other windows are
		/// described in AH Nuttall, "Some windows with very good sidelobe
		/// behavior," IEEE Transactions on Acoustics, Speech, and Signal
		/// Processing 29:84-91, 1981.
		/// </summary>
		// Token: 0x06016531 RID: 91441 RVA: 0x001F662E File Offset: 0x001F482E
		public void SetWindowFunctionToHann()
		{
			vtkImageSincInterpolator.vtkImageSincInterpolator_SetWindowFunctionToHann_36(base.GetCppThis());
		}

		// Token: 0x06016532 RID: 91442
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSincInterpolator_SetWindowFunctionToKaiser_37(HandleRef pThis);

		/// <summary>
		/// The window function to use.  The default is Lanczos, which is very
		/// popular and performs well with a kernel width of 6.  The Cosine
		/// window is included for historical reasons.  All other windows are
		/// described in AH Nuttall, "Some windows with very good sidelobe
		/// behavior," IEEE Transactions on Acoustics, Speech, and Signal
		/// Processing 29:84-91, 1981.
		/// </summary>
		// Token: 0x06016533 RID: 91443 RVA: 0x001F663D File Offset: 0x001F483D
		public void SetWindowFunctionToKaiser()
		{
			vtkImageSincInterpolator.vtkImageSincInterpolator_SetWindowFunctionToKaiser_37(base.GetCppThis());
		}

		// Token: 0x06016534 RID: 91444
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSincInterpolator_SetWindowFunctionToLanczos_38(HandleRef pThis);

		/// <summary>
		/// The window function to use.  The default is Lanczos, which is very
		/// popular and performs well with a kernel width of 6.  The Cosine
		/// window is included for historical reasons.  All other windows are
		/// described in AH Nuttall, "Some windows with very good sidelobe
		/// behavior," IEEE Transactions on Acoustics, Speech, and Signal
		/// Processing 29:84-91, 1981.
		/// </summary>
		// Token: 0x06016535 RID: 91445 RVA: 0x001F664C File Offset: 0x001F484C
		public void SetWindowFunctionToLanczos()
		{
			vtkImageSincInterpolator.vtkImageSincInterpolator_SetWindowFunctionToLanczos_38(base.GetCppThis());
		}

		// Token: 0x06016536 RID: 91446
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSincInterpolator_SetWindowFunctionToNuttall_39(HandleRef pThis);

		/// <summary>
		/// The window function to use.  The default is Lanczos, which is very
		/// popular and performs well with a kernel width of 6.  The Cosine
		/// window is included for historical reasons.  All other windows are
		/// described in AH Nuttall, "Some windows with very good sidelobe
		/// behavior," IEEE Transactions on Acoustics, Speech, and Signal
		/// Processing 29:84-91, 1981.
		/// </summary>
		// Token: 0x06016537 RID: 91447 RVA: 0x001F665B File Offset: 0x001F485B
		public void SetWindowFunctionToNuttall()
		{
			vtkImageSincInterpolator.vtkImageSincInterpolator_SetWindowFunctionToNuttall_39(base.GetCppThis());
		}

		// Token: 0x06016538 RID: 91448
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSincInterpolator_SetWindowHalfWidth_40(HandleRef pThis, int n);

		/// <summary>
		/// Set the window half-width, this must be an integer between 1 and 16,
		/// with a default value of 3.  The kernel size will be twice this value
		/// if no blur factors are applied. The total number of sinc lobes will
		/// be one less than twice the half-width, so if the half-width is 3 then
		/// the kernel size will be 6 and there will be 5 sinc lobes.
		/// </summary>
		// Token: 0x06016539 RID: 91449 RVA: 0x001F666A File Offset: 0x001F486A
		public void SetWindowHalfWidth(int n)
		{
			vtkImageSincInterpolator.vtkImageSincInterpolator_SetWindowHalfWidth_40(base.GetCppThis(), n);
		}

		// Token: 0x0601653A RID: 91450
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSincInterpolator_SetWindowParameter_41(HandleRef pThis, double param);

		/// <summary>
		/// Set the alpha parameter for the Kaiser window function.
		/// This parameter will be ignored unless UseWindowParameter is On.
		/// If UseWindowParameter is Off, then alpha is set to be the same as n
		/// where n is the window half-width.  Using an alpha less than n
		/// increases the sharpness and ringing, while using an alpha greater
		/// than n increases the blurring.
		/// </summary>
		// Token: 0x0601653B RID: 91451 RVA: 0x001F667A File Offset: 0x001F487A
		public void SetWindowParameter(double param)
		{
			vtkImageSincInterpolator.vtkImageSincInterpolator_SetWindowParameter_41(base.GetCppThis(), param);
		}

		// Token: 0x0601653C RID: 91452
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSincInterpolator_UseWindowParameterOff_42(HandleRef pThis);

		/// <summary>
		/// Turn this on in order to use SetWindowParameter.  If it is off,
		/// then the default parameter will be used for the window.
		/// </summary>
		// Token: 0x0601653D RID: 91453 RVA: 0x001F668A File Offset: 0x001F488A
		public void UseWindowParameterOff()
		{
			vtkImageSincInterpolator.vtkImageSincInterpolator_UseWindowParameterOff_42(base.GetCppThis());
		}

		// Token: 0x0601653E RID: 91454
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSincInterpolator_UseWindowParameterOn_43(HandleRef pThis);

		/// <summary>
		/// Turn this on in order to use SetWindowParameter.  If it is off,
		/// then the default parameter will be used for the window.
		/// </summary>
		// Token: 0x0601653F RID: 91455 RVA: 0x001F6699 File Offset: 0x001F4899
		public void UseWindowParameterOn()
		{
			vtkImageSincInterpolator.vtkImageSincInterpolator_UseWindowParameterOn_43(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001924 RID: 6436
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageSincInterpolator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001925 RID: 6437
		public new static readonly string MRClassNameKey = "class vtkImageSincInterpolator";
	}
}
