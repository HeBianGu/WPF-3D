using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageShrink3D
	/// </summary>
	/// <remarks>
	///    Subsamples an image.
	///
	/// vtkImageShrink3D shrinks an image by sub sampling on a
	/// uniform grid (integer multiples).
	/// </remarks>
	// Token: 0x02000866 RID: 2150
	public class vtkImageShrink3D : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016498 RID: 91288 RVA: 0x001F5C99 File Offset: 0x001F3E99
		static vtkImageShrink3D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageShrink3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageShrink3D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016499 RID: 91289 RVA: 0x001F5CC1 File Offset: 0x001F3EC1
		public vtkImageShrink3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601649A RID: 91290
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageShrink3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601649B RID: 91291 RVA: 0x001F5CD0 File Offset: 0x001F3ED0
		public new static vtkImageShrink3D New()
		{
			vtkImageShrink3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageShrink3D.vtkImageShrink3D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageShrink3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601649C RID: 91292 RVA: 0x001F5D24 File Offset: 0x001F3F24
		public vtkImageShrink3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageShrink3D.vtkImageShrink3D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601649D RID: 91293 RVA: 0x001F5D68 File Offset: 0x001F3F68
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601649E RID: 91294
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageShrink3D_AveragingOff_01(HandleRef pThis);

		/// <summary>
		/// Choose Mean, Minimum, Maximum, Median or sub sampling.
		/// The neighborhood operations are not centered on the sampled pixel.
		/// This may cause a half pixel shift in your output image.
		/// You can changed "Shift" to get around this.
		/// vtkImageGaussianSmooth or vtkImageMean with strides.
		/// </summary>
		// Token: 0x0601649F RID: 91295 RVA: 0x001F5D73 File Offset: 0x001F3F73
		public virtual void AveragingOff()
		{
			vtkImageShrink3D.vtkImageShrink3D_AveragingOff_01(base.GetCppThis());
		}

		// Token: 0x060164A0 RID: 91296
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageShrink3D_AveragingOn_02(HandleRef pThis);

		/// <summary>
		/// Choose Mean, Minimum, Maximum, Median or sub sampling.
		/// The neighborhood operations are not centered on the sampled pixel.
		/// This may cause a half pixel shift in your output image.
		/// You can changed "Shift" to get around this.
		/// vtkImageGaussianSmooth or vtkImageMean with strides.
		/// </summary>
		// Token: 0x060164A1 RID: 91297 RVA: 0x001F5D82 File Offset: 0x001F3F82
		public virtual void AveragingOn()
		{
			vtkImageShrink3D.vtkImageShrink3D_AveragingOn_02(base.GetCppThis());
		}

		// Token: 0x060164A2 RID: 91298
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageShrink3D_GetAveraging_03(HandleRef pThis);

		/// <summary>
		/// Choose Mean, Minimum, Maximum, Median or sub sampling.
		/// The neighborhood operations are not centered on the sampled pixel.
		/// This may cause a half pixel shift in your output image.
		/// You can changed "Shift" to get around this.
		/// vtkImageGaussianSmooth or vtkImageMean with strides.
		/// </summary>
		// Token: 0x060164A3 RID: 91299 RVA: 0x001F5D94 File Offset: 0x001F3F94
		public int GetAveraging()
		{
			return vtkImageShrink3D.vtkImageShrink3D_GetAveraging_03(base.GetCppThis());
		}

		// Token: 0x060164A4 RID: 91300
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageShrink3D_GetMaximum_04(HandleRef pThis);

		/// <summary>
		/// Choose Mean, Minimum, Maximum, Median or sub sampling.
		/// The neighborhood operations are not centered on the sampled pixel.
		/// This may cause a half pixel shift in your output image.
		/// You can changed "Shift" to get around this.
		/// vtkImageGaussianSmooth or vtkImageMean with strides.
		/// </summary>
		// Token: 0x060164A5 RID: 91301 RVA: 0x001F5DB4 File Offset: 0x001F3FB4
		public virtual int GetMaximum()
		{
			return vtkImageShrink3D.vtkImageShrink3D_GetMaximum_04(base.GetCppThis());
		}

		// Token: 0x060164A6 RID: 91302
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageShrink3D_GetMean_05(HandleRef pThis);

		/// <summary>
		/// Choose Mean, Minimum, Maximum, Median or sub sampling.
		/// The neighborhood operations are not centered on the sampled pixel.
		/// This may cause a half pixel shift in your output image.
		/// You can changed "Shift" to get around this.
		/// vtkImageGaussianSmooth or vtkImageMean with strides.
		/// </summary>
		// Token: 0x060164A7 RID: 91303 RVA: 0x001F5DD4 File Offset: 0x001F3FD4
		public virtual int GetMean()
		{
			return vtkImageShrink3D.vtkImageShrink3D_GetMean_05(base.GetCppThis());
		}

		// Token: 0x060164A8 RID: 91304
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageShrink3D_GetMedian_06(HandleRef pThis);

		/// <summary>
		/// Choose Mean, Minimum, Maximum, Median or sub sampling.
		/// The neighborhood operations are not centered on the sampled pixel.
		/// This may cause a half pixel shift in your output image.
		/// You can changed "Shift" to get around this.
		/// vtkImageGaussianSmooth or vtkImageMean with strides.
		/// </summary>
		// Token: 0x060164A9 RID: 91305 RVA: 0x001F5DF4 File Offset: 0x001F3FF4
		public virtual int GetMedian()
		{
			return vtkImageShrink3D.vtkImageShrink3D_GetMedian_06(base.GetCppThis());
		}

		// Token: 0x060164AA RID: 91306
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageShrink3D_GetMinimum_07(HandleRef pThis);

		/// <summary>
		/// Choose Mean, Minimum, Maximum, Median or sub sampling.
		/// The neighborhood operations are not centered on the sampled pixel.
		/// This may cause a half pixel shift in your output image.
		/// You can changed "Shift" to get around this.
		/// vtkImageGaussianSmooth or vtkImageMean with strides.
		/// </summary>
		// Token: 0x060164AB RID: 91307 RVA: 0x001F5E14 File Offset: 0x001F4014
		public virtual int GetMinimum()
		{
			return vtkImageShrink3D.vtkImageShrink3D_GetMinimum_07(base.GetCppThis());
		}

		// Token: 0x060164AC RID: 91308
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageShrink3D_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060164AD RID: 91309 RVA: 0x001F5E34 File Offset: 0x001F4034
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageShrink3D.vtkImageShrink3D_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x060164AE RID: 91310
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageShrink3D_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060164AF RID: 91311 RVA: 0x001F5E54 File Offset: 0x001F4054
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageShrink3D.vtkImageShrink3D_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x060164B0 RID: 91312
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageShrink3D_GetShift_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the pixel to use as origin.
		/// </summary>
		// Token: 0x060164B1 RID: 91313 RVA: 0x001F5E70 File Offset: 0x001F4070
		public virtual int[] GetShift()
		{
			IntPtr intPtr = vtkImageShrink3D.vtkImageShrink3D_GetShift_10(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060164B2 RID: 91314
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageShrink3D_GetShift_11(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

		/// <summary>
		/// Set/Get the pixel to use as origin.
		/// </summary>
		// Token: 0x060164B3 RID: 91315 RVA: 0x001F5EB8 File Offset: 0x001F40B8
		public virtual void GetShift(ref int _arg1, ref int _arg2, ref int _arg3)
		{
			vtkImageShrink3D.vtkImageShrink3D_GetShift_11(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060164B4 RID: 91316
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageShrink3D_GetShift_12(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the pixel to use as origin.
		/// </summary>
		// Token: 0x060164B5 RID: 91317 RVA: 0x001F5ECA File Offset: 0x001F40CA
		public virtual void GetShift(IntPtr _arg)
		{
			vtkImageShrink3D.vtkImageShrink3D_GetShift_12(base.GetCppThis(), _arg);
		}

		// Token: 0x060164B6 RID: 91318
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageShrink3D_GetShrinkFactors_13(HandleRef pThis);

		/// <summary>
		/// Set/Get the shrink factors
		/// </summary>
		// Token: 0x060164B7 RID: 91319 RVA: 0x001F5EDC File Offset: 0x001F40DC
		public virtual int[] GetShrinkFactors()
		{
			IntPtr intPtr = vtkImageShrink3D.vtkImageShrink3D_GetShrinkFactors_13(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060164B8 RID: 91320
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageShrink3D_GetShrinkFactors_14(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

		/// <summary>
		/// Set/Get the shrink factors
		/// </summary>
		// Token: 0x060164B9 RID: 91321 RVA: 0x001F5F24 File Offset: 0x001F4124
		public virtual void GetShrinkFactors(ref int _arg1, ref int _arg2, ref int _arg3)
		{
			vtkImageShrink3D.vtkImageShrink3D_GetShrinkFactors_14(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060164BA RID: 91322
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageShrink3D_GetShrinkFactors_15(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the shrink factors
		/// </summary>
		// Token: 0x060164BB RID: 91323 RVA: 0x001F5F36 File Offset: 0x001F4136
		public virtual void GetShrinkFactors(IntPtr _arg)
		{
			vtkImageShrink3D.vtkImageShrink3D_GetShrinkFactors_15(base.GetCppThis(), _arg);
		}

		// Token: 0x060164BC RID: 91324
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageShrink3D_IsA_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060164BD RID: 91325 RVA: 0x001F5F48 File Offset: 0x001F4148
		public override int IsA(string type)
		{
			return vtkImageShrink3D.vtkImageShrink3D_IsA_16(base.GetCppThis(), type);
		}

		// Token: 0x060164BE RID: 91326
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageShrink3D_IsTypeOf_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060164BF RID: 91327 RVA: 0x001F5F68 File Offset: 0x001F4168
		public new static int IsTypeOf(string type)
		{
			return vtkImageShrink3D.vtkImageShrink3D_IsTypeOf_17(type);
		}

		// Token: 0x060164C0 RID: 91328
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageShrink3D_MaximumOff_18(HandleRef pThis);

		/// <summary>
		/// Choose Mean, Minimum, Maximum, Median or sub sampling.
		/// The neighborhood operations are not centered on the sampled pixel.
		/// This may cause a half pixel shift in your output image.
		/// You can changed "Shift" to get around this.
		/// vtkImageGaussianSmooth or vtkImageMean with strides.
		/// </summary>
		// Token: 0x060164C1 RID: 91329 RVA: 0x001F5F82 File Offset: 0x001F4182
		public virtual void MaximumOff()
		{
			vtkImageShrink3D.vtkImageShrink3D_MaximumOff_18(base.GetCppThis());
		}

		// Token: 0x060164C2 RID: 91330
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageShrink3D_MaximumOn_19(HandleRef pThis);

		/// <summary>
		/// Choose Mean, Minimum, Maximum, Median or sub sampling.
		/// The neighborhood operations are not centered on the sampled pixel.
		/// This may cause a half pixel shift in your output image.
		/// You can changed "Shift" to get around this.
		/// vtkImageGaussianSmooth or vtkImageMean with strides.
		/// </summary>
		// Token: 0x060164C3 RID: 91331 RVA: 0x001F5F91 File Offset: 0x001F4191
		public virtual void MaximumOn()
		{
			vtkImageShrink3D.vtkImageShrink3D_MaximumOn_19(base.GetCppThis());
		}

		// Token: 0x060164C4 RID: 91332
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageShrink3D_MeanOff_20(HandleRef pThis);

		/// <summary>
		/// Choose Mean, Minimum, Maximum, Median or sub sampling.
		/// The neighborhood operations are not centered on the sampled pixel.
		/// This may cause a half pixel shift in your output image.
		/// You can changed "Shift" to get around this.
		/// vtkImageGaussianSmooth or vtkImageMean with strides.
		/// </summary>
		// Token: 0x060164C5 RID: 91333 RVA: 0x001F5FA0 File Offset: 0x001F41A0
		public virtual void MeanOff()
		{
			vtkImageShrink3D.vtkImageShrink3D_MeanOff_20(base.GetCppThis());
		}

		// Token: 0x060164C6 RID: 91334
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageShrink3D_MeanOn_21(HandleRef pThis);

		/// <summary>
		/// Choose Mean, Minimum, Maximum, Median or sub sampling.
		/// The neighborhood operations are not centered on the sampled pixel.
		/// This may cause a half pixel shift in your output image.
		/// You can changed "Shift" to get around this.
		/// vtkImageGaussianSmooth or vtkImageMean with strides.
		/// </summary>
		// Token: 0x060164C7 RID: 91335 RVA: 0x001F5FAF File Offset: 0x001F41AF
		public virtual void MeanOn()
		{
			vtkImageShrink3D.vtkImageShrink3D_MeanOn_21(base.GetCppThis());
		}

		// Token: 0x060164C8 RID: 91336
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageShrink3D_MedianOff_22(HandleRef pThis);

		/// <summary>
		/// Choose Mean, Minimum, Maximum, Median or sub sampling.
		/// The neighborhood operations are not centered on the sampled pixel.
		/// This may cause a half pixel shift in your output image.
		/// You can changed "Shift" to get around this.
		/// vtkImageGaussianSmooth or vtkImageMean with strides.
		/// </summary>
		// Token: 0x060164C9 RID: 91337 RVA: 0x001F5FBE File Offset: 0x001F41BE
		public virtual void MedianOff()
		{
			vtkImageShrink3D.vtkImageShrink3D_MedianOff_22(base.GetCppThis());
		}

		// Token: 0x060164CA RID: 91338
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageShrink3D_MedianOn_23(HandleRef pThis);

		/// <summary>
		/// Choose Mean, Minimum, Maximum, Median or sub sampling.
		/// The neighborhood operations are not centered on the sampled pixel.
		/// This may cause a half pixel shift in your output image.
		/// You can changed "Shift" to get around this.
		/// vtkImageGaussianSmooth or vtkImageMean with strides.
		/// </summary>
		// Token: 0x060164CB RID: 91339 RVA: 0x001F5FCD File Offset: 0x001F41CD
		public virtual void MedianOn()
		{
			vtkImageShrink3D.vtkImageShrink3D_MedianOn_23(base.GetCppThis());
		}

		// Token: 0x060164CC RID: 91340
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageShrink3D_MinimumOff_24(HandleRef pThis);

		/// <summary>
		/// Choose Mean, Minimum, Maximum, Median or sub sampling.
		/// The neighborhood operations are not centered on the sampled pixel.
		/// This may cause a half pixel shift in your output image.
		/// You can changed "Shift" to get around this.
		/// vtkImageGaussianSmooth or vtkImageMean with strides.
		/// </summary>
		// Token: 0x060164CD RID: 91341 RVA: 0x001F5FDC File Offset: 0x001F41DC
		public virtual void MinimumOff()
		{
			vtkImageShrink3D.vtkImageShrink3D_MinimumOff_24(base.GetCppThis());
		}

		// Token: 0x060164CE RID: 91342
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageShrink3D_MinimumOn_25(HandleRef pThis);

		/// <summary>
		/// Choose Mean, Minimum, Maximum, Median or sub sampling.
		/// The neighborhood operations are not centered on the sampled pixel.
		/// This may cause a half pixel shift in your output image.
		/// You can changed "Shift" to get around this.
		/// vtkImageGaussianSmooth or vtkImageMean with strides.
		/// </summary>
		// Token: 0x060164CF RID: 91343 RVA: 0x001F5FEB File Offset: 0x001F41EB
		public virtual void MinimumOn()
		{
			vtkImageShrink3D.vtkImageShrink3D_MinimumOn_25(base.GetCppThis());
		}

		// Token: 0x060164D0 RID: 91344
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageShrink3D_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060164D1 RID: 91345 RVA: 0x001F5FFC File Offset: 0x001F41FC
		public new vtkImageShrink3D NewInstance()
		{
			vtkImageShrink3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageShrink3D.vtkImageShrink3D_NewInstance_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageShrink3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060164D2 RID: 91346
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageShrink3D_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060164D3 RID: 91347 RVA: 0x001F6058 File Offset: 0x001F4258
		public new static vtkImageShrink3D SafeDownCast(vtkObjectBase o)
		{
			vtkImageShrink3D vtkImageShrink3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageShrink3D.vtkImageShrink3D_SafeDownCast_28((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageShrink3D = (vtkImageShrink3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageShrink3D.Register(null);
				}
			}
			return vtkImageShrink3D;
		}

		// Token: 0x060164D4 RID: 91348
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageShrink3D_SetAveraging_29(HandleRef pThis, int arg0);

		/// <summary>
		/// Choose Mean, Minimum, Maximum, Median or sub sampling.
		/// The neighborhood operations are not centered on the sampled pixel.
		/// This may cause a half pixel shift in your output image.
		/// You can changed "Shift" to get around this.
		/// vtkImageGaussianSmooth or vtkImageMean with strides.
		/// </summary>
		// Token: 0x060164D5 RID: 91349 RVA: 0x001F60D7 File Offset: 0x001F42D7
		public void SetAveraging(int arg0)
		{
			vtkImageShrink3D.vtkImageShrink3D_SetAveraging_29(base.GetCppThis(), arg0);
		}

		// Token: 0x060164D6 RID: 91350
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageShrink3D_SetMaximum_30(HandleRef pThis, int arg0);

		/// <summary>
		/// Choose Mean, Minimum, Maximum, Median or sub sampling.
		/// The neighborhood operations are not centered on the sampled pixel.
		/// This may cause a half pixel shift in your output image.
		/// You can changed "Shift" to get around this.
		/// vtkImageGaussianSmooth or vtkImageMean with strides.
		/// </summary>
		// Token: 0x060164D7 RID: 91351 RVA: 0x001F60E7 File Offset: 0x001F42E7
		public void SetMaximum(int arg0)
		{
			vtkImageShrink3D.vtkImageShrink3D_SetMaximum_30(base.GetCppThis(), arg0);
		}

		// Token: 0x060164D8 RID: 91352
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageShrink3D_SetMean_31(HandleRef pThis, int arg0);

		/// <summary>
		/// Choose Mean, Minimum, Maximum, Median or sub sampling.
		/// The neighborhood operations are not centered on the sampled pixel.
		/// This may cause a half pixel shift in your output image.
		/// You can changed "Shift" to get around this.
		/// vtkImageGaussianSmooth or vtkImageMean with strides.
		/// </summary>
		// Token: 0x060164D9 RID: 91353 RVA: 0x001F60F7 File Offset: 0x001F42F7
		public void SetMean(int arg0)
		{
			vtkImageShrink3D.vtkImageShrink3D_SetMean_31(base.GetCppThis(), arg0);
		}

		// Token: 0x060164DA RID: 91354
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageShrink3D_SetMedian_32(HandleRef pThis, int arg0);

		/// <summary>
		/// Choose Mean, Minimum, Maximum, Median or sub sampling.
		/// The neighborhood operations are not centered on the sampled pixel.
		/// This may cause a half pixel shift in your output image.
		/// You can changed "Shift" to get around this.
		/// vtkImageGaussianSmooth or vtkImageMean with strides.
		/// </summary>
		// Token: 0x060164DB RID: 91355 RVA: 0x001F6107 File Offset: 0x001F4307
		public void SetMedian(int arg0)
		{
			vtkImageShrink3D.vtkImageShrink3D_SetMedian_32(base.GetCppThis(), arg0);
		}

		// Token: 0x060164DC RID: 91356
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageShrink3D_SetMinimum_33(HandleRef pThis, int arg0);

		/// <summary>
		/// Choose Mean, Minimum, Maximum, Median or sub sampling.
		/// The neighborhood operations are not centered on the sampled pixel.
		/// This may cause a half pixel shift in your output image.
		/// You can changed "Shift" to get around this.
		/// vtkImageGaussianSmooth or vtkImageMean with strides.
		/// </summary>
		// Token: 0x060164DD RID: 91357 RVA: 0x001F6117 File Offset: 0x001F4317
		public void SetMinimum(int arg0)
		{
			vtkImageShrink3D.vtkImageShrink3D_SetMinimum_33(base.GetCppThis(), arg0);
		}

		// Token: 0x060164DE RID: 91358
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageShrink3D_SetShift_34(HandleRef pThis, int _arg1, int _arg2, int _arg3);

		/// <summary>
		/// Set/Get the pixel to use as origin.
		/// </summary>
		// Token: 0x060164DF RID: 91359 RVA: 0x001F6127 File Offset: 0x001F4327
		public virtual void SetShift(int _arg1, int _arg2, int _arg3)
		{
			vtkImageShrink3D.vtkImageShrink3D_SetShift_34(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x060164E0 RID: 91360
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageShrink3D_SetShift_35(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the pixel to use as origin.
		/// </summary>
		// Token: 0x060164E1 RID: 91361 RVA: 0x001F6139 File Offset: 0x001F4339
		public virtual void SetShift(IntPtr _arg)
		{
			vtkImageShrink3D.vtkImageShrink3D_SetShift_35(base.GetCppThis(), _arg);
		}

		// Token: 0x060164E2 RID: 91362
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageShrink3D_SetShrinkFactors_36(HandleRef pThis, int _arg1, int _arg2, int _arg3);

		/// <summary>
		/// Set/Get the shrink factors
		/// </summary>
		// Token: 0x060164E3 RID: 91363 RVA: 0x001F6149 File Offset: 0x001F4349
		public virtual void SetShrinkFactors(int _arg1, int _arg2, int _arg3)
		{
			vtkImageShrink3D.vtkImageShrink3D_SetShrinkFactors_36(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x060164E4 RID: 91364
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageShrink3D_SetShrinkFactors_37(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the shrink factors
		/// </summary>
		// Token: 0x060164E5 RID: 91365 RVA: 0x001F615B File Offset: 0x001F435B
		public virtual void SetShrinkFactors(IntPtr _arg)
		{
			vtkImageShrink3D.vtkImageShrink3D_SetShrinkFactors_37(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001922 RID: 6434
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageShrink3D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001923 RID: 6435
		public new static readonly string MRClassNameKey = "class vtkImageShrink3D";
	}
}
