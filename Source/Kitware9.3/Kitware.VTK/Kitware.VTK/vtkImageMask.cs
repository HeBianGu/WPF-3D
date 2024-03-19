using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageMask
	/// </summary>
	/// <remarks>
	///    Combines a mask and an image.
	///
	/// vtkImageMask combines a mask with an image.  Non zero mask
	/// implies the output pixel will be the same as the image.
	/// If a mask pixel is zero,  then the output pixel
	/// is set to "MaskedValue".  The filter also has the option to pass
	/// the mask through a boolean not operation before processing the image.
	/// This reverses the passed and replaced pixels.
	/// The two inputs should have the same "WholeExtent".
	/// The mask input should be unsigned char, and the image scalar type
	/// is the same as the output scalar type.
	/// </remarks>
	// Token: 0x0200085B RID: 2139
	public class vtkImageMask : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060162F6 RID: 90870 RVA: 0x001F3AB9 File Offset: 0x001F1CB9
		static vtkImageMask()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageMask.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageMask"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060162F7 RID: 90871 RVA: 0x001F3AE1 File Offset: 0x001F1CE1
		public vtkImageMask(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060162F8 RID: 90872
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMask_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060162F9 RID: 90873 RVA: 0x001F3AF0 File Offset: 0x001F1CF0
		public new static vtkImageMask New()
		{
			vtkImageMask result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageMask.vtkImageMask_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMask)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060162FA RID: 90874 RVA: 0x001F3B44 File Offset: 0x001F1D44
		public vtkImageMask() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageMask.vtkImageMask_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060162FB RID: 90875 RVA: 0x001F3B88 File Offset: 0x001F1D88
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060162FC RID: 90876
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageMask_GetMaskAlpha_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the alpha blending value for the mask
		/// The input image is assumed to be at alpha = 1.0
		/// and the mask image uses this alpha to blend using
		/// an over operator.
		/// </summary>
		// Token: 0x060162FD RID: 90877 RVA: 0x001F3B94 File Offset: 0x001F1D94
		public virtual double GetMaskAlpha()
		{
			return vtkImageMask.vtkImageMask_GetMaskAlpha_01(base.GetCppThis());
		}

		// Token: 0x060162FE RID: 90878
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageMask_GetMaskAlphaMaxValue_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the alpha blending value for the mask
		/// The input image is assumed to be at alpha = 1.0
		/// and the mask image uses this alpha to blend using
		/// an over operator.
		/// </summary>
		// Token: 0x060162FF RID: 90879 RVA: 0x001F3BB4 File Offset: 0x001F1DB4
		public virtual double GetMaskAlphaMaxValue()
		{
			return vtkImageMask.vtkImageMask_GetMaskAlphaMaxValue_02(base.GetCppThis());
		}

		// Token: 0x06016300 RID: 90880
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageMask_GetMaskAlphaMinValue_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the alpha blending value for the mask
		/// The input image is assumed to be at alpha = 1.0
		/// and the mask image uses this alpha to blend using
		/// an over operator.
		/// </summary>
		// Token: 0x06016301 RID: 90881 RVA: 0x001F3BD4 File Offset: 0x001F1DD4
		public virtual double GetMaskAlphaMinValue()
		{
			return vtkImageMask.vtkImageMask_GetMaskAlphaMinValue_03(base.GetCppThis());
		}

		// Token: 0x06016302 RID: 90882
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMask_GetMaskedOutputValue_04(HandleRef pThis);

		/// <summary>
		/// SetGet the value of the output pixel replaced by mask.
		/// </summary>
		// Token: 0x06016303 RID: 90883 RVA: 0x001F3BF4 File Offset: 0x001F1DF4
		public IntPtr GetMaskedOutputValue()
		{
			return vtkImageMask.vtkImageMask_GetMaskedOutputValue_04(base.GetCppThis());
		}

		// Token: 0x06016304 RID: 90884
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMask_GetMaskedOutputValueLength_05(HandleRef pThis);

		/// <summary>
		/// SetGet the value of the output pixel replaced by mask.
		/// </summary>
		// Token: 0x06016305 RID: 90885 RVA: 0x001F3C14 File Offset: 0x001F1E14
		public int GetMaskedOutputValueLength()
		{
			return vtkImageMask.vtkImageMask_GetMaskedOutputValueLength_05(base.GetCppThis());
		}

		// Token: 0x06016306 RID: 90886
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMask_GetNotMask_06(HandleRef pThis);

		/// <summary>
		/// When Not Mask is on, the mask is passed through a boolean not
		/// before it is used to mask the image.  The effect is to pass the
		/// pixels where the input mask is zero, and replace the pixels
		/// where the input value is non zero.
		/// </summary>
		// Token: 0x06016307 RID: 90887 RVA: 0x001F3C34 File Offset: 0x001F1E34
		public virtual int GetNotMask()
		{
			return vtkImageMask.vtkImageMask_GetNotMask_06(base.GetCppThis());
		}

		// Token: 0x06016308 RID: 90888
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageMask_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016309 RID: 90889 RVA: 0x001F3C54 File Offset: 0x001F1E54
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageMask.vtkImageMask_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0601630A RID: 90890
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageMask_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601630B RID: 90891 RVA: 0x001F3C74 File Offset: 0x001F1E74
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageMask.vtkImageMask_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x0601630C RID: 90892
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMask_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601630D RID: 90893 RVA: 0x001F3C90 File Offset: 0x001F1E90
		public override int IsA(string type)
		{
			return vtkImageMask.vtkImageMask_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x0601630E RID: 90894
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMask_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601630F RID: 90895 RVA: 0x001F3CB0 File Offset: 0x001F1EB0
		public new static int IsTypeOf(string type)
		{
			return vtkImageMask.vtkImageMask_IsTypeOf_10(type);
		}

		// Token: 0x06016310 RID: 90896
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMask_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016311 RID: 90897 RVA: 0x001F3CCC File Offset: 0x001F1ECC
		public new vtkImageMask NewInstance()
		{
			vtkImageMask result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageMask.vtkImageMask_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMask)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016312 RID: 90898
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMask_NotMaskOff_13(HandleRef pThis);

		/// <summary>
		/// When Not Mask is on, the mask is passed through a boolean not
		/// before it is used to mask the image.  The effect is to pass the
		/// pixels where the input mask is zero, and replace the pixels
		/// where the input value is non zero.
		/// </summary>
		// Token: 0x06016313 RID: 90899 RVA: 0x001F3D26 File Offset: 0x001F1F26
		public virtual void NotMaskOff()
		{
			vtkImageMask.vtkImageMask_NotMaskOff_13(base.GetCppThis());
		}

		// Token: 0x06016314 RID: 90900
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMask_NotMaskOn_14(HandleRef pThis);

		/// <summary>
		/// When Not Mask is on, the mask is passed through a boolean not
		/// before it is used to mask the image.  The effect is to pass the
		/// pixels where the input mask is zero, and replace the pixels
		/// where the input value is non zero.
		/// </summary>
		// Token: 0x06016315 RID: 90901 RVA: 0x001F3D35 File Offset: 0x001F1F35
		public virtual void NotMaskOn()
		{
			vtkImageMask.vtkImageMask_NotMaskOn_14(base.GetCppThis());
		}

		// Token: 0x06016316 RID: 90902
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMask_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016317 RID: 90903 RVA: 0x001F3D44 File Offset: 0x001F1F44
		public new static vtkImageMask SafeDownCast(vtkObjectBase o)
		{
			vtkImageMask vtkImageMask = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageMask.vtkImageMask_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageMask = (vtkImageMask)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageMask.Register(null);
				}
			}
			return vtkImageMask;
		}

		// Token: 0x06016318 RID: 90904
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMask_SetImageInputData_16(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the input to be masked.
		/// </summary>
		// Token: 0x06016319 RID: 90905 RVA: 0x001F3DC4 File Offset: 0x001F1FC4
		public void SetImageInputData(vtkImageData arg0)
		{
			vtkImageMask.vtkImageMask_SetImageInputData_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601631A RID: 90906
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMask_SetInput1Data_17(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the two inputs to this filter
		/// </summary>
		// Token: 0x0601631B RID: 90907 RVA: 0x001F3DF4 File Offset: 0x001F1FF4
		public virtual void SetInput1Data(vtkDataObject arg0)
		{
			vtkImageMask.vtkImageMask_SetInput1Data_17(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601631C RID: 90908
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMask_SetInput2Data_18(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the two inputs to this filter
		/// </summary>
		// Token: 0x0601631D RID: 90909 RVA: 0x001F3E24 File Offset: 0x001F2024
		public virtual void SetInput2Data(vtkDataObject arg0)
		{
			vtkImageMask.vtkImageMask_SetInput2Data_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601631E RID: 90910
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMask_SetMaskAlpha_19(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the alpha blending value for the mask
		/// The input image is assumed to be at alpha = 1.0
		/// and the mask image uses this alpha to blend using
		/// an over operator.
		/// </summary>
		// Token: 0x0601631F RID: 90911 RVA: 0x001F3E53 File Offset: 0x001F2053
		public virtual void SetMaskAlpha(double _arg)
		{
			vtkImageMask.vtkImageMask_SetMaskAlpha_19(base.GetCppThis(), _arg);
		}

		// Token: 0x06016320 RID: 90912
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMask_SetMaskInputData_20(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the mask to be used.
		/// </summary>
		// Token: 0x06016321 RID: 90913 RVA: 0x001F3E64 File Offset: 0x001F2064
		public void SetMaskInputData(vtkImageData arg0)
		{
			vtkImageMask.vtkImageMask_SetMaskInputData_20(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06016322 RID: 90914
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMask_SetMaskedOutputValue_21(HandleRef pThis, int num, IntPtr v);

		/// <summary>
		/// SetGet the value of the output pixel replaced by mask.
		/// </summary>
		// Token: 0x06016323 RID: 90915 RVA: 0x001F3E93 File Offset: 0x001F2093
		public void SetMaskedOutputValue(int num, IntPtr v)
		{
			vtkImageMask.vtkImageMask_SetMaskedOutputValue_21(base.GetCppThis(), num, v);
		}

		// Token: 0x06016324 RID: 90916
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMask_SetMaskedOutputValue_22(HandleRef pThis, double v);

		/// <summary>
		/// SetGet the value of the output pixel replaced by mask.
		/// </summary>
		// Token: 0x06016325 RID: 90917 RVA: 0x001F3EA4 File Offset: 0x001F20A4
		public void SetMaskedOutputValue(double v)
		{
			vtkImageMask.vtkImageMask_SetMaskedOutputValue_22(base.GetCppThis(), v);
		}

		// Token: 0x06016326 RID: 90918
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMask_SetMaskedOutputValue_23(HandleRef pThis, double v1, double v2);

		/// <summary>
		/// SetGet the value of the output pixel replaced by mask.
		/// </summary>
		// Token: 0x06016327 RID: 90919 RVA: 0x001F3EB4 File Offset: 0x001F20B4
		public void SetMaskedOutputValue(double v1, double v2)
		{
			vtkImageMask.vtkImageMask_SetMaskedOutputValue_23(base.GetCppThis(), v1, v2);
		}

		// Token: 0x06016328 RID: 90920
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMask_SetMaskedOutputValue_24(HandleRef pThis, double v1, double v2, double v3);

		/// <summary>
		/// SetGet the value of the output pixel replaced by mask.
		/// </summary>
		// Token: 0x06016329 RID: 90921 RVA: 0x001F3EC5 File Offset: 0x001F20C5
		public void SetMaskedOutputValue(double v1, double v2, double v3)
		{
			vtkImageMask.vtkImageMask_SetMaskedOutputValue_24(base.GetCppThis(), v1, v2, v3);
		}

		// Token: 0x0601632A RID: 90922
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMask_SetNotMask_25(HandleRef pThis, int _arg);

		/// <summary>
		/// When Not Mask is on, the mask is passed through a boolean not
		/// before it is used to mask the image.  The effect is to pass the
		/// pixels where the input mask is zero, and replace the pixels
		/// where the input value is non zero.
		/// </summary>
		// Token: 0x0601632B RID: 90923 RVA: 0x001F3ED7 File Offset: 0x001F20D7
		public virtual void SetNotMask(int _arg)
		{
			vtkImageMask.vtkImageMask_SetNotMask_25(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400190A RID: 6410
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageMask";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400190B RID: 6411
		public new static readonly string MRClassNameKey = "class vtkImageMask";
	}
}
