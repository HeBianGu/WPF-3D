using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageDifference
	/// </summary>
	/// <remarks>
	///    Compares images for regression tests.
	///
	/// vtkImageDifference takes two rgb unsigned char images and compares them.
	/// It allows the images to be slightly different.  If AllowShift is on,
	/// then each pixel can be shifted by two pixels. Threshold is the allowable
	/// error for each pixel.
	///
	/// This is a symmetric filter and the difference computed is symmetric.
	/// The resulting value is the maximum error of the two directions
	/// A-&gt;B and B-&gt;A
	/// </remarks>
	// Token: 0x02000857 RID: 2135
	public class vtkImageDifference : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016250 RID: 90704 RVA: 0x001F2D1B File Offset: 0x001F0F1B
		static vtkImageDifference()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageDifference.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageDifference"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016251 RID: 90705 RVA: 0x001F2D43 File Offset: 0x001F0F43
		public vtkImageDifference(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016252 RID: 90706
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageDifference_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016253 RID: 90707 RVA: 0x001F2D54 File Offset: 0x001F0F54
		public new static vtkImageDifference New()
		{
			vtkImageDifference result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageDifference.vtkImageDifference_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageDifference)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016254 RID: 90708 RVA: 0x001F2DA8 File Offset: 0x001F0FA8
		public vtkImageDifference() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageDifference.vtkImageDifference_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016255 RID: 90709 RVA: 0x001F2DEC File Offset: 0x001F0FEC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016256 RID: 90710
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageDifference_AllowShiftOff_01(HandleRef pThis);

		/// <summary>
		/// Specify whether the comparison will allow a shift of two
		/// pixels between the images.  If set, then the minimum difference
		/// between input images will be used to determine the difference.
		/// Otherwise, the difference is computed directly between pixels
		/// of identical row/column values.
		/// </summary>
		// Token: 0x06016257 RID: 90711 RVA: 0x001F2DF7 File Offset: 0x001F0FF7
		public virtual void AllowShiftOff()
		{
			vtkImageDifference.vtkImageDifference_AllowShiftOff_01(base.GetCppThis());
		}

		// Token: 0x06016258 RID: 90712
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageDifference_AllowShiftOn_02(HandleRef pThis);

		/// <summary>
		/// Specify whether the comparison will allow a shift of two
		/// pixels between the images.  If set, then the minimum difference
		/// between input images will be used to determine the difference.
		/// Otherwise, the difference is computed directly between pixels
		/// of identical row/column values.
		/// </summary>
		// Token: 0x06016259 RID: 90713 RVA: 0x001F2E06 File Offset: 0x001F1006
		public virtual void AllowShiftOn()
		{
			vtkImageDifference.vtkImageDifference_AllowShiftOn_02(base.GetCppThis());
		}

		// Token: 0x0601625A RID: 90714
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageDifference_AveragingOff_03(HandleRef pThis);

		/// <summary>
		/// Specify whether the comparison will include comparison of
		/// averaged 3x3 data between the images. For graphics renderings
		/// you normally would leave this on. For imaging operations it
		/// should be off.
		/// </summary>
		// Token: 0x0601625B RID: 90715 RVA: 0x001F2E15 File Offset: 0x001F1015
		public virtual void AveragingOff()
		{
			vtkImageDifference.vtkImageDifference_AveragingOff_03(base.GetCppThis());
		}

		// Token: 0x0601625C RID: 90716
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageDifference_AveragingOn_04(HandleRef pThis);

		/// <summary>
		/// Specify whether the comparison will include comparison of
		/// averaged 3x3 data between the images. For graphics renderings
		/// you normally would leave this on. For imaging operations it
		/// should be off.
		/// </summary>
		// Token: 0x0601625D RID: 90717 RVA: 0x001F2E24 File Offset: 0x001F1024
		public virtual void AveragingOn()
		{
			vtkImageDifference.vtkImageDifference_AveragingOn_04(base.GetCppThis());
		}

		// Token: 0x0601625E RID: 90718
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkImageDifference_GetAllowShift_05(HandleRef pThis);

		/// <summary>
		/// Specify whether the comparison will allow a shift of two
		/// pixels between the images.  If set, then the minimum difference
		/// between input images will be used to determine the difference.
		/// Otherwise, the difference is computed directly between pixels
		/// of identical row/column values.
		/// </summary>
		// Token: 0x0601625F RID: 90719 RVA: 0x001F2E34 File Offset: 0x001F1034
		public virtual bool GetAllowShift()
		{
			return vtkImageDifference.vtkImageDifference_GetAllowShift_05(base.GetCppThis()) != 0;
		}

		// Token: 0x06016260 RID: 90720
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageDifference_GetAverageThresholdFactor_06(HandleRef pThis);

		/// <summary>
		/// When doing Averaging, adjust the threshold for the average
		/// by this factor. Defaults to 0.5 requiring a better match
		/// </summary>
		// Token: 0x06016261 RID: 90721 RVA: 0x001F2E5C File Offset: 0x001F105C
		public virtual double GetAverageThresholdFactor()
		{
			return vtkImageDifference.vtkImageDifference_GetAverageThresholdFactor_06(base.GetCppThis());
		}

		// Token: 0x06016262 RID: 90722
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkImageDifference_GetAveraging_07(HandleRef pThis);

		/// <summary>
		/// Specify whether the comparison will include comparison of
		/// averaged 3x3 data between the images. For graphics renderings
		/// you normally would leave this on. For imaging operations it
		/// should be off.
		/// </summary>
		// Token: 0x06016263 RID: 90723 RVA: 0x001F2E7C File Offset: 0x001F107C
		public virtual bool GetAveraging()
		{
			return vtkImageDifference.vtkImageDifference_GetAveraging_07(base.GetCppThis()) != 0;
		}

		// Token: 0x06016264 RID: 90724
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageDifference_GetError_08(HandleRef pThis);

		/// <summary>
		/// Return the total error in comparing the two images.
		/// </summary>
		// Token: 0x06016265 RID: 90725 RVA: 0x001F2EA4 File Offset: 0x001F10A4
		public double GetError()
		{
			return vtkImageDifference.vtkImageDifference_GetError_08(base.GetCppThis());
		}

		// Token: 0x06016266 RID: 90726
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageDifference_GetError_09(HandleRef pThis, IntPtr e);

		/// <summary>
		/// Return the total error in comparing the two images.
		/// </summary>
		// Token: 0x06016267 RID: 90727 RVA: 0x001F2EC3 File Offset: 0x001F10C3
		public void GetError(IntPtr e)
		{
			vtkImageDifference.vtkImageDifference_GetError_09(base.GetCppThis(), e);
		}

		// Token: 0x06016268 RID: 90728
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageDifference_GetImage_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the Image to compare the input to.
		/// </summary>
		// Token: 0x06016269 RID: 90729 RVA: 0x001F2ED4 File Offset: 0x001F10D4
		public vtkImageData GetImage()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageDifference.vtkImageDifference_GetImage_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601626A RID: 90730
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageDifference_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601626B RID: 90731 RVA: 0x001F2F44 File Offset: 0x001F1144
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageDifference.vtkImageDifference_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x0601626C RID: 90732
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageDifference_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601626D RID: 90733 RVA: 0x001F2F64 File Offset: 0x001F1164
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageDifference.vtkImageDifference_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x0601626E RID: 90734
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageDifference_GetThreshold_13(HandleRef pThis);

		/// <summary>
		/// Specify a threshold tolerance for pixel differences.
		/// </summary>
		// Token: 0x0601626F RID: 90735 RVA: 0x001F2F80 File Offset: 0x001F1180
		public virtual int GetThreshold()
		{
			return vtkImageDifference.vtkImageDifference_GetThreshold_13(base.GetCppThis());
		}

		// Token: 0x06016270 RID: 90736
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageDifference_GetThresholdedError_14(HandleRef pThis);

		/// <summary>
		/// Return the total thresholded error in comparing the two images.
		/// The thresholded error is the error for a given pixel minus the
		/// threshold and clamped at a minimum of zero.
		/// </summary>
		// Token: 0x06016271 RID: 90737 RVA: 0x001F2FA0 File Offset: 0x001F11A0
		public double GetThresholdedError()
		{
			return vtkImageDifference.vtkImageDifference_GetThresholdedError_14(base.GetCppThis());
		}

		// Token: 0x06016272 RID: 90738
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageDifference_GetThresholdedError_15(HandleRef pThis, IntPtr e);

		/// <summary>
		/// Return the total thresholded error in comparing the two images.
		/// The thresholded error is the error for a given pixel minus the
		/// threshold and clamped at a minimum of zero.
		/// </summary>
		// Token: 0x06016273 RID: 90739 RVA: 0x001F2FBF File Offset: 0x001F11BF
		public void GetThresholdedError(IntPtr e)
		{
			vtkImageDifference.vtkImageDifference_GetThresholdedError_15(base.GetCppThis(), e);
		}

		// Token: 0x06016274 RID: 90740
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageDifference_IsA_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016275 RID: 90741 RVA: 0x001F2FD0 File Offset: 0x001F11D0
		public override int IsA(string type)
		{
			return vtkImageDifference.vtkImageDifference_IsA_16(base.GetCppThis(), type);
		}

		// Token: 0x06016276 RID: 90742
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageDifference_IsTypeOf_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016277 RID: 90743 RVA: 0x001F2FF0 File Offset: 0x001F11F0
		public new static int IsTypeOf(string type)
		{
			return vtkImageDifference.vtkImageDifference_IsTypeOf_17(type);
		}

		// Token: 0x06016278 RID: 90744
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageDifference_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016279 RID: 90745 RVA: 0x001F300C File Offset: 0x001F120C
		public new vtkImageDifference NewInstance()
		{
			vtkImageDifference result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageDifference.vtkImageDifference_NewInstance_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageDifference)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601627A RID: 90746
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageDifference_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601627B RID: 90747 RVA: 0x001F3068 File Offset: 0x001F1268
		public new static vtkImageDifference SafeDownCast(vtkObjectBase o)
		{
			vtkImageDifference vtkImageDifference = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageDifference.vtkImageDifference_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageDifference = (vtkImageDifference)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageDifference.Register(null);
				}
			}
			return vtkImageDifference;
		}

		// Token: 0x0601627C RID: 90748
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageDifference_SetAllowShift_21(HandleRef pThis, byte _arg);

		/// <summary>
		/// Specify whether the comparison will allow a shift of two
		/// pixels between the images.  If set, then the minimum difference
		/// between input images will be used to determine the difference.
		/// Otherwise, the difference is computed directly between pixels
		/// of identical row/column values.
		/// </summary>
		// Token: 0x0601627D RID: 90749 RVA: 0x001F30E7 File Offset: 0x001F12E7
		public virtual void SetAllowShift(bool _arg)
		{
			vtkImageDifference.vtkImageDifference_SetAllowShift_21(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0601627E RID: 90750
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageDifference_SetAverageThresholdFactor_22(HandleRef pThis, double _arg);

		/// <summary>
		/// When doing Averaging, adjust the threshold for the average
		/// by this factor. Defaults to 0.5 requiring a better match
		/// </summary>
		// Token: 0x0601627F RID: 90751 RVA: 0x001F30FF File Offset: 0x001F12FF
		public virtual void SetAverageThresholdFactor(double _arg)
		{
			vtkImageDifference.vtkImageDifference_SetAverageThresholdFactor_22(base.GetCppThis(), _arg);
		}

		// Token: 0x06016280 RID: 90752
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageDifference_SetAveraging_23(HandleRef pThis, byte _arg);

		/// <summary>
		/// Specify whether the comparison will include comparison of
		/// averaged 3x3 data between the images. For graphics renderings
		/// you normally would leave this on. For imaging operations it
		/// should be off.
		/// </summary>
		// Token: 0x06016281 RID: 90753 RVA: 0x001F310F File Offset: 0x001F130F
		public virtual void SetAveraging(bool _arg)
		{
			vtkImageDifference.vtkImageDifference_SetAveraging_23(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06016282 RID: 90754
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageDifference_SetImageConnection_24(HandleRef pThis, HandleRef output);

		/// <summary>
		/// Specify the Image to compare the input to.
		/// </summary>
		// Token: 0x06016283 RID: 90755 RVA: 0x001F3128 File Offset: 0x001F1328
		public void SetImageConnection(vtkAlgorithmOutput output)
		{
			vtkImageDifference.vtkImageDifference_SetImageConnection_24(base.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		// Token: 0x06016284 RID: 90756
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageDifference_SetImageData_25(HandleRef pThis, HandleRef image);

		/// <summary>
		/// Specify the Image to compare the input to.
		/// </summary>
		// Token: 0x06016285 RID: 90757 RVA: 0x001F3158 File Offset: 0x001F1358
		public void SetImageData(vtkDataObject image)
		{
			vtkImageDifference.vtkImageDifference_SetImageData_25(base.GetCppThis(), (image == null) ? default(HandleRef) : image.GetCppThis());
		}

		// Token: 0x06016286 RID: 90758
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageDifference_SetThreshold_26(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify a threshold tolerance for pixel differences.
		/// </summary>
		// Token: 0x06016287 RID: 90759 RVA: 0x001F3187 File Offset: 0x001F1387
		public virtual void SetThreshold(int _arg)
		{
			vtkImageDifference.vtkImageDifference_SetThreshold_26(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001902 RID: 6402
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageDifference";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001903 RID: 6403
		public new static readonly string MRClassNameKey = "class vtkImageDifference";
	}
}
