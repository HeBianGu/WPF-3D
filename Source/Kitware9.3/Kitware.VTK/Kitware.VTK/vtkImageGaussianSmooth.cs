using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageGaussianSmooth
	/// </summary>
	/// <remarks>
	///    Performs a gaussian convolution.
	///
	/// vtkImageGaussianSmooth implements a convolution of the input image
	/// with a gaussian. Supports from one to three dimensional convolutions.
	/// </remarks>
	// Token: 0x02000485 RID: 1157
	public class vtkImageGaussianSmooth : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D4D1 RID: 54481 RVA: 0x001281D7 File Offset: 0x001263D7
		static vtkImageGaussianSmooth()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageGaussianSmooth.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageGaussianSmooth"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D4D2 RID: 54482 RVA: 0x001281FF File Offset: 0x001263FF
		public vtkImageGaussianSmooth(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600D4D3 RID: 54483
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageGaussianSmooth_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates an instance of vtkImageGaussianSmooth with the following
		/// defaults: Dimensionality 3, StandardDeviations( 2, 2, 2),
		/// Radius Factors ( 1.5, 1.5, 1.5)
		/// </summary>
		// Token: 0x0600D4D4 RID: 54484 RVA: 0x00128210 File Offset: 0x00126410
		public new static vtkImageGaussianSmooth New()
		{
			vtkImageGaussianSmooth result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageGaussianSmooth.vtkImageGaussianSmooth_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageGaussianSmooth)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Creates an instance of vtkImageGaussianSmooth with the following
		/// defaults: Dimensionality 3, StandardDeviations( 2, 2, 2),
		/// Radius Factors ( 1.5, 1.5, 1.5)
		/// </summary>
		// Token: 0x0600D4D5 RID: 54485 RVA: 0x00128264 File Offset: 0x00126464
		public vtkImageGaussianSmooth() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageGaussianSmooth.vtkImageGaussianSmooth_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D4D6 RID: 54486 RVA: 0x001282A8 File Offset: 0x001264A8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D4D7 RID: 54487
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageGaussianSmooth_GetDimensionality_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the dimensionality of this filter. This determines whether
		/// a one, two, or three dimensional gaussian is performed.
		/// </summary>
		// Token: 0x0600D4D8 RID: 54488 RVA: 0x001282B4 File Offset: 0x001264B4
		public virtual int GetDimensionality()
		{
			return vtkImageGaussianSmooth.vtkImageGaussianSmooth_GetDimensionality_01(base.GetCppThis());
		}

		// Token: 0x0600D4D9 RID: 54489
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageGaussianSmooth_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D4DA RID: 54490 RVA: 0x001282D4 File Offset: 0x001264D4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageGaussianSmooth.vtkImageGaussianSmooth_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600D4DB RID: 54491
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageGaussianSmooth_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D4DC RID: 54492 RVA: 0x001282F4 File Offset: 0x001264F4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageGaussianSmooth.vtkImageGaussianSmooth_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600D4DD RID: 54493
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageGaussianSmooth_GetRadiusFactors_04(HandleRef pThis);

		/// <summary>
		/// Sets/Gets the Radius Factors of the gaussian (no unit).
		/// The radius factors determine how far out the gaussian kernel will
		/// go before being clamped to zero.
		/// </summary>
		// Token: 0x0600D4DE RID: 54494 RVA: 0x00128310 File Offset: 0x00126510
		public virtual double[] GetRadiusFactors()
		{
			IntPtr intPtr = vtkImageGaussianSmooth.vtkImageGaussianSmooth_GetRadiusFactors_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600D4DF RID: 54495
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGaussianSmooth_GetRadiusFactors_05(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Sets/Gets the Radius Factors of the gaussian (no unit).
		/// The radius factors determine how far out the gaussian kernel will
		/// go before being clamped to zero.
		/// </summary>
		// Token: 0x0600D4E0 RID: 54496 RVA: 0x00128358 File Offset: 0x00126558
		public virtual void GetRadiusFactors(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageGaussianSmooth.vtkImageGaussianSmooth_GetRadiusFactors_05(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600D4E1 RID: 54497
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGaussianSmooth_GetRadiusFactors_06(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Sets/Gets the Radius Factors of the gaussian (no unit).
		/// The radius factors determine how far out the gaussian kernel will
		/// go before being clamped to zero.
		/// </summary>
		// Token: 0x0600D4E2 RID: 54498 RVA: 0x0012836A File Offset: 0x0012656A
		public virtual void GetRadiusFactors(IntPtr _arg)
		{
			vtkImageGaussianSmooth.vtkImageGaussianSmooth_GetRadiusFactors_06(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D4E3 RID: 54499
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageGaussianSmooth_GetStandardDeviations_07(HandleRef pThis);

		/// <summary>
		/// Sets/Gets the Standard deviation of the gaussian in pixel units.
		/// </summary>
		// Token: 0x0600D4E4 RID: 54500 RVA: 0x0012837C File Offset: 0x0012657C
		public virtual double[] GetStandardDeviations()
		{
			IntPtr intPtr = vtkImageGaussianSmooth.vtkImageGaussianSmooth_GetStandardDeviations_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600D4E5 RID: 54501
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGaussianSmooth_GetStandardDeviations_08(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Sets/Gets the Standard deviation of the gaussian in pixel units.
		/// </summary>
		// Token: 0x0600D4E6 RID: 54502 RVA: 0x001283C4 File Offset: 0x001265C4
		public virtual void GetStandardDeviations(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageGaussianSmooth.vtkImageGaussianSmooth_GetStandardDeviations_08(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600D4E7 RID: 54503
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGaussianSmooth_GetStandardDeviations_09(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Sets/Gets the Standard deviation of the gaussian in pixel units.
		/// </summary>
		// Token: 0x0600D4E8 RID: 54504 RVA: 0x001283D6 File Offset: 0x001265D6
		public virtual void GetStandardDeviations(IntPtr _arg)
		{
			vtkImageGaussianSmooth.vtkImageGaussianSmooth_GetStandardDeviations_09(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D4E9 RID: 54505
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageGaussianSmooth_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D4EA RID: 54506 RVA: 0x001283E8 File Offset: 0x001265E8
		public override int IsA(string type)
		{
			return vtkImageGaussianSmooth.vtkImageGaussianSmooth_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x0600D4EB RID: 54507
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageGaussianSmooth_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D4EC RID: 54508 RVA: 0x00128408 File Offset: 0x00126608
		public new static int IsTypeOf(string type)
		{
			return vtkImageGaussianSmooth.vtkImageGaussianSmooth_IsTypeOf_11(type);
		}

		// Token: 0x0600D4ED RID: 54509
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageGaussianSmooth_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D4EE RID: 54510 RVA: 0x00128424 File Offset: 0x00126624
		public new vtkImageGaussianSmooth NewInstance()
		{
			vtkImageGaussianSmooth result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageGaussianSmooth.vtkImageGaussianSmooth_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageGaussianSmooth)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D4EF RID: 54511
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageGaussianSmooth_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D4F0 RID: 54512 RVA: 0x00128480 File Offset: 0x00126680
		public new static vtkImageGaussianSmooth SafeDownCast(vtkObjectBase o)
		{
			vtkImageGaussianSmooth vtkImageGaussianSmooth = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageGaussianSmooth.vtkImageGaussianSmooth_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageGaussianSmooth = (vtkImageGaussianSmooth)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageGaussianSmooth.Register(null);
				}
			}
			return vtkImageGaussianSmooth;
		}

		// Token: 0x0600D4F1 RID: 54513
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGaussianSmooth_SetDimensionality_15(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the dimensionality of this filter. This determines whether
		/// a one, two, or three dimensional gaussian is performed.
		/// </summary>
		// Token: 0x0600D4F2 RID: 54514 RVA: 0x001284FF File Offset: 0x001266FF
		public virtual void SetDimensionality(int _arg)
		{
			vtkImageGaussianSmooth.vtkImageGaussianSmooth_SetDimensionality_15(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D4F3 RID: 54515
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGaussianSmooth_SetRadiusFactor_16(HandleRef pThis, double f);

		/// <summary>
		/// Sets/Gets the Radius Factors of the gaussian (no unit).
		/// The radius factors determine how far out the gaussian kernel will
		/// go before being clamped to zero.
		/// </summary>
		// Token: 0x0600D4F4 RID: 54516 RVA: 0x0012850F File Offset: 0x0012670F
		public void SetRadiusFactor(double f)
		{
			vtkImageGaussianSmooth.vtkImageGaussianSmooth_SetRadiusFactor_16(base.GetCppThis(), f);
		}

		// Token: 0x0600D4F5 RID: 54517
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGaussianSmooth_SetRadiusFactors_17(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Sets/Gets the Radius Factors of the gaussian (no unit).
		/// The radius factors determine how far out the gaussian kernel will
		/// go before being clamped to zero.
		/// </summary>
		// Token: 0x0600D4F6 RID: 54518 RVA: 0x0012851F File Offset: 0x0012671F
		public virtual void SetRadiusFactors(double _arg1, double _arg2, double _arg3)
		{
			vtkImageGaussianSmooth.vtkImageGaussianSmooth_SetRadiusFactors_17(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600D4F7 RID: 54519
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGaussianSmooth_SetRadiusFactors_18(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Sets/Gets the Radius Factors of the gaussian (no unit).
		/// The radius factors determine how far out the gaussian kernel will
		/// go before being clamped to zero.
		/// </summary>
		// Token: 0x0600D4F8 RID: 54520 RVA: 0x00128531 File Offset: 0x00126731
		public virtual void SetRadiusFactors(IntPtr _arg)
		{
			vtkImageGaussianSmooth.vtkImageGaussianSmooth_SetRadiusFactors_18(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D4F9 RID: 54521
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGaussianSmooth_SetRadiusFactors_19(HandleRef pThis, double f, double f2);

		/// <summary>
		/// Sets/Gets the Radius Factors of the gaussian (no unit).
		/// The radius factors determine how far out the gaussian kernel will
		/// go before being clamped to zero.
		/// </summary>
		// Token: 0x0600D4FA RID: 54522 RVA: 0x00128541 File Offset: 0x00126741
		public void SetRadiusFactors(double f, double f2)
		{
			vtkImageGaussianSmooth.vtkImageGaussianSmooth_SetRadiusFactors_19(base.GetCppThis(), f, f2);
		}

		// Token: 0x0600D4FB RID: 54523
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGaussianSmooth_SetStandardDeviation_20(HandleRef pThis, double std);

		/// <summary>
		/// Sets/Gets the Standard deviation of the gaussian in pixel units.
		/// </summary>
		// Token: 0x0600D4FC RID: 54524 RVA: 0x00128552 File Offset: 0x00126752
		public void SetStandardDeviation(double std)
		{
			vtkImageGaussianSmooth.vtkImageGaussianSmooth_SetStandardDeviation_20(base.GetCppThis(), std);
		}

		// Token: 0x0600D4FD RID: 54525
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGaussianSmooth_SetStandardDeviation_21(HandleRef pThis, double a, double b);

		/// <summary>
		/// Sets/Gets the Standard deviation of the gaussian in pixel units.
		/// These methods are provided for compatibility with old scripts
		/// </summary>
		// Token: 0x0600D4FE RID: 54526 RVA: 0x00128562 File Offset: 0x00126762
		public void SetStandardDeviation(double a, double b)
		{
			vtkImageGaussianSmooth.vtkImageGaussianSmooth_SetStandardDeviation_21(base.GetCppThis(), a, b);
		}

		// Token: 0x0600D4FF RID: 54527
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGaussianSmooth_SetStandardDeviation_22(HandleRef pThis, double a, double b, double c);

		/// <summary>
		/// Sets/Gets the Standard deviation of the gaussian in pixel units.
		/// These methods are provided for compatibility with old scripts
		/// </summary>
		// Token: 0x0600D500 RID: 54528 RVA: 0x00128573 File Offset: 0x00126773
		public void SetStandardDeviation(double a, double b, double c)
		{
			vtkImageGaussianSmooth.vtkImageGaussianSmooth_SetStandardDeviation_22(base.GetCppThis(), a, b, c);
		}

		// Token: 0x0600D501 RID: 54529
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGaussianSmooth_SetStandardDeviations_23(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Sets/Gets the Standard deviation of the gaussian in pixel units.
		/// </summary>
		// Token: 0x0600D502 RID: 54530 RVA: 0x00128585 File Offset: 0x00126785
		public virtual void SetStandardDeviations(double _arg1, double _arg2, double _arg3)
		{
			vtkImageGaussianSmooth.vtkImageGaussianSmooth_SetStandardDeviations_23(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600D503 RID: 54531
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGaussianSmooth_SetStandardDeviations_24(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Sets/Gets the Standard deviation of the gaussian in pixel units.
		/// </summary>
		// Token: 0x0600D504 RID: 54532 RVA: 0x00128597 File Offset: 0x00126797
		public virtual void SetStandardDeviations(IntPtr _arg)
		{
			vtkImageGaussianSmooth.vtkImageGaussianSmooth_SetStandardDeviations_24(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D505 RID: 54533
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGaussianSmooth_SetStandardDeviations_25(HandleRef pThis, double a, double b);

		/// <summary>
		/// Sets/Gets the Standard deviation of the gaussian in pixel units.
		/// </summary>
		// Token: 0x0600D506 RID: 54534 RVA: 0x001285A7 File Offset: 0x001267A7
		public void SetStandardDeviations(double a, double b)
		{
			vtkImageGaussianSmooth.vtkImageGaussianSmooth_SetStandardDeviations_25(base.GetCppThis(), a, b);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FB2 RID: 4018
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageGaussianSmooth";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FB3 RID: 4019
		public new static readonly string MRClassNameKey = "class vtkImageGaussianSmooth";
	}
}
