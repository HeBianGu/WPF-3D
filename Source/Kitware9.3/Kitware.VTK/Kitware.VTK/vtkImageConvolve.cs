using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageConvolve
	/// </summary>
	/// <remarks>
	///    Convolution of an image with a kernel.
	///
	/// vtkImageConvolve convolves the image with a 3D NxNxN kernel or a
	/// 2D NxN kernel.  The output image is cropped to the same size as
	/// the input.
	/// </remarks>
	// Token: 0x02000481 RID: 1153
	public class vtkImageConvolve : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D433 RID: 54323 RVA: 0x00127513 File Offset: 0x00125713
		static vtkImageConvolve()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageConvolve.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageConvolve"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D434 RID: 54324 RVA: 0x0012753B File Offset: 0x0012573B
		public vtkImageConvolve(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600D435 RID: 54325
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageConvolve_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct an instance of vtkImageConvolve filter.
		/// </summary>
		// Token: 0x0600D436 RID: 54326 RVA: 0x0012754C File Offset: 0x0012574C
		public new static vtkImageConvolve New()
		{
			vtkImageConvolve result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageConvolve.vtkImageConvolve_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageConvolve)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct an instance of vtkImageConvolve filter.
		/// </summary>
		// Token: 0x0600D437 RID: 54327 RVA: 0x001275A0 File Offset: 0x001257A0
		public vtkImageConvolve() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageConvolve.vtkImageConvolve_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D438 RID: 54328 RVA: 0x001275E4 File Offset: 0x001257E4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D439 RID: 54329
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageConvolve_GetKernel3x3_01(HandleRef pThis);

		/// <summary>
		/// Return an array that contains the kernel.
		/// </summary>
		// Token: 0x0600D43A RID: 54330 RVA: 0x001275F0 File Offset: 0x001257F0
		public IntPtr GetKernel3x3()
		{
			return vtkImageConvolve.vtkImageConvolve_GetKernel3x3_01(base.GetCppThis());
		}

		// Token: 0x0600D43B RID: 54331
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageConvolve_GetKernel3x3_02(HandleRef pThis, IntPtr kernel);

		/// <summary>
		/// Return an array that contains the kernel.
		/// </summary>
		// Token: 0x0600D43C RID: 54332 RVA: 0x0012760F File Offset: 0x0012580F
		public void GetKernel3x3(IntPtr kernel)
		{
			vtkImageConvolve.vtkImageConvolve_GetKernel3x3_02(base.GetCppThis(), kernel);
		}

		// Token: 0x0600D43D RID: 54333
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageConvolve_GetKernel3x3x3_03(HandleRef pThis);

		/// <summary>
		/// Return an array that contains the kernel
		/// </summary>
		// Token: 0x0600D43E RID: 54334 RVA: 0x00127620 File Offset: 0x00125820
		public IntPtr GetKernel3x3x3()
		{
			return vtkImageConvolve.vtkImageConvolve_GetKernel3x3x3_03(base.GetCppThis());
		}

		// Token: 0x0600D43F RID: 54335
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageConvolve_GetKernel3x3x3_04(HandleRef pThis, IntPtr kernel);

		/// <summary>
		/// Return an array that contains the kernel
		/// </summary>
		// Token: 0x0600D440 RID: 54336 RVA: 0x0012763F File Offset: 0x0012583F
		public void GetKernel3x3x3(IntPtr kernel)
		{
			vtkImageConvolve.vtkImageConvolve_GetKernel3x3x3_04(base.GetCppThis(), kernel);
		}

		// Token: 0x0600D441 RID: 54337
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageConvolve_GetKernel5x5_05(HandleRef pThis);

		/// <summary>
		/// Return an array that contains the kernel.
		/// </summary>
		// Token: 0x0600D442 RID: 54338 RVA: 0x00127650 File Offset: 0x00125850
		public IntPtr GetKernel5x5()
		{
			return vtkImageConvolve.vtkImageConvolve_GetKernel5x5_05(base.GetCppThis());
		}

		// Token: 0x0600D443 RID: 54339
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageConvolve_GetKernel5x5_06(HandleRef pThis, IntPtr kernel);

		/// <summary>
		/// Return an array that contains the kernel.
		/// </summary>
		// Token: 0x0600D444 RID: 54340 RVA: 0x0012766F File Offset: 0x0012586F
		public void GetKernel5x5(IntPtr kernel)
		{
			vtkImageConvolve.vtkImageConvolve_GetKernel5x5_06(base.GetCppThis(), kernel);
		}

		// Token: 0x0600D445 RID: 54341
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageConvolve_GetKernel5x5x5_07(HandleRef pThis);

		/// <summary>
		/// Return an array that contains the kernel
		/// </summary>
		// Token: 0x0600D446 RID: 54342 RVA: 0x00127680 File Offset: 0x00125880
		public IntPtr GetKernel5x5x5()
		{
			return vtkImageConvolve.vtkImageConvolve_GetKernel5x5x5_07(base.GetCppThis());
		}

		// Token: 0x0600D447 RID: 54343
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageConvolve_GetKernel5x5x5_08(HandleRef pThis, IntPtr kernel);

		/// <summary>
		/// Return an array that contains the kernel
		/// </summary>
		// Token: 0x0600D448 RID: 54344 RVA: 0x0012769F File Offset: 0x0012589F
		public void GetKernel5x5x5(IntPtr kernel)
		{
			vtkImageConvolve.vtkImageConvolve_GetKernel5x5x5_08(base.GetCppThis(), kernel);
		}

		// Token: 0x0600D449 RID: 54345
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageConvolve_GetKernel7x7_09(HandleRef pThis);

		/// <summary>
		/// Return an array that contains the kernel.
		/// </summary>
		// Token: 0x0600D44A RID: 54346 RVA: 0x001276B0 File Offset: 0x001258B0
		public IntPtr GetKernel7x7()
		{
			return vtkImageConvolve.vtkImageConvolve_GetKernel7x7_09(base.GetCppThis());
		}

		// Token: 0x0600D44B RID: 54347
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageConvolve_GetKernel7x7_10(HandleRef pThis, IntPtr kernel);

		/// <summary>
		/// Return an array that contains the kernel.
		/// </summary>
		// Token: 0x0600D44C RID: 54348 RVA: 0x001276CF File Offset: 0x001258CF
		public void GetKernel7x7(IntPtr kernel)
		{
			vtkImageConvolve.vtkImageConvolve_GetKernel7x7_10(base.GetCppThis(), kernel);
		}

		// Token: 0x0600D44D RID: 54349
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageConvolve_GetKernel7x7x7_11(HandleRef pThis);

		/// <summary>
		/// Return an array that contains the kernel
		/// </summary>
		// Token: 0x0600D44E RID: 54350 RVA: 0x001276E0 File Offset: 0x001258E0
		public IntPtr GetKernel7x7x7()
		{
			return vtkImageConvolve.vtkImageConvolve_GetKernel7x7x7_11(base.GetCppThis());
		}

		// Token: 0x0600D44F RID: 54351
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageConvolve_GetKernel7x7x7_12(HandleRef pThis, IntPtr kernel);

		/// <summary>
		/// Return an array that contains the kernel
		/// </summary>
		// Token: 0x0600D450 RID: 54352 RVA: 0x001276FF File Offset: 0x001258FF
		public void GetKernel7x7x7(IntPtr kernel)
		{
			vtkImageConvolve.vtkImageConvolve_GetKernel7x7x7_12(base.GetCppThis(), kernel);
		}

		// Token: 0x0600D451 RID: 54353
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageConvolve_GetKernelSize_13(HandleRef pThis);

		/// <summary>
		/// Get the kernel size
		/// </summary>
		// Token: 0x0600D452 RID: 54354 RVA: 0x00127710 File Offset: 0x00125910
		public virtual int[] GetKernelSize()
		{
			IntPtr intPtr = vtkImageConvolve.vtkImageConvolve_GetKernelSize_13(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600D453 RID: 54355
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageConvolve_GetKernelSize_14(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

		/// <summary>
		/// Get the kernel size
		/// </summary>
		// Token: 0x0600D454 RID: 54356 RVA: 0x00127758 File Offset: 0x00125958
		public virtual void GetKernelSize(ref int _arg1, ref int _arg2, ref int _arg3)
		{
			vtkImageConvolve.vtkImageConvolve_GetKernelSize_14(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600D455 RID: 54357
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageConvolve_GetKernelSize_15(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get the kernel size
		/// </summary>
		// Token: 0x0600D456 RID: 54358 RVA: 0x0012776A File Offset: 0x0012596A
		public virtual void GetKernelSize(IntPtr _arg)
		{
			vtkImageConvolve.vtkImageConvolve_GetKernelSize_15(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D457 RID: 54359
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageConvolve_GetNumberOfGenerationsFromBase_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct an instance of vtkImageConvolve filter.
		/// </summary>
		// Token: 0x0600D458 RID: 54360 RVA: 0x0012777C File Offset: 0x0012597C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageConvolve.vtkImageConvolve_GetNumberOfGenerationsFromBase_16(base.GetCppThis(), type);
		}

		// Token: 0x0600D459 RID: 54361
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageConvolve_GetNumberOfGenerationsFromBaseType_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct an instance of vtkImageConvolve filter.
		/// </summary>
		// Token: 0x0600D45A RID: 54362 RVA: 0x0012779C File Offset: 0x0012599C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageConvolve.vtkImageConvolve_GetNumberOfGenerationsFromBaseType_17(type);
		}

		// Token: 0x0600D45B RID: 54363
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageConvolve_IsA_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct an instance of vtkImageConvolve filter.
		/// </summary>
		// Token: 0x0600D45C RID: 54364 RVA: 0x001277B8 File Offset: 0x001259B8
		public override int IsA(string type)
		{
			return vtkImageConvolve.vtkImageConvolve_IsA_18(base.GetCppThis(), type);
		}

		// Token: 0x0600D45D RID: 54365
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageConvolve_IsTypeOf_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct an instance of vtkImageConvolve filter.
		/// </summary>
		// Token: 0x0600D45E RID: 54366 RVA: 0x001277D8 File Offset: 0x001259D8
		public new static int IsTypeOf(string type)
		{
			return vtkImageConvolve.vtkImageConvolve_IsTypeOf_19(type);
		}

		// Token: 0x0600D45F RID: 54367
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageConvolve_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct an instance of vtkImageConvolve filter.
		/// </summary>
		// Token: 0x0600D460 RID: 54368 RVA: 0x001277F4 File Offset: 0x001259F4
		public new vtkImageConvolve NewInstance()
		{
			vtkImageConvolve result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageConvolve.vtkImageConvolve_NewInstance_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageConvolve)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D461 RID: 54369
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageConvolve_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct an instance of vtkImageConvolve filter.
		/// </summary>
		// Token: 0x0600D462 RID: 54370 RVA: 0x00127850 File Offset: 0x00125A50
		public new static vtkImageConvolve SafeDownCast(vtkObjectBase o)
		{
			vtkImageConvolve vtkImageConvolve = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageConvolve.vtkImageConvolve_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageConvolve = (vtkImageConvolve)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageConvolve.Register(null);
				}
			}
			return vtkImageConvolve;
		}

		// Token: 0x0600D463 RID: 54371
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageConvolve_SetKernel3x3_23(HandleRef pThis, IntPtr kernel);

		/// <summary>
		/// Set the kernel to be a given 3x3 or 5x5 or 7x7 kernel.
		/// </summary>
		// Token: 0x0600D464 RID: 54372 RVA: 0x001278CF File Offset: 0x00125ACF
		public void SetKernel3x3(IntPtr kernel)
		{
			vtkImageConvolve.vtkImageConvolve_SetKernel3x3_23(base.GetCppThis(), kernel);
		}

		// Token: 0x0600D465 RID: 54373
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageConvolve_SetKernel3x3x3_24(HandleRef pThis, IntPtr kernel);

		/// <summary>
		/// Set the kernel to be a 3x3x3 or 5x5x5 or 7x7x7 kernel.
		/// </summary>
		// Token: 0x0600D466 RID: 54374 RVA: 0x001278DF File Offset: 0x00125ADF
		public void SetKernel3x3x3(IntPtr kernel)
		{
			vtkImageConvolve.vtkImageConvolve_SetKernel3x3x3_24(base.GetCppThis(), kernel);
		}

		// Token: 0x0600D467 RID: 54375
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageConvolve_SetKernel5x5_25(HandleRef pThis, IntPtr kernel);

		/// <summary>
		/// Set the kernel to be a given 3x3 or 5x5 or 7x7 kernel.
		/// </summary>
		// Token: 0x0600D468 RID: 54376 RVA: 0x001278EF File Offset: 0x00125AEF
		public void SetKernel5x5(IntPtr kernel)
		{
			vtkImageConvolve.vtkImageConvolve_SetKernel5x5_25(base.GetCppThis(), kernel);
		}

		// Token: 0x0600D469 RID: 54377
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageConvolve_SetKernel5x5x5_26(HandleRef pThis, IntPtr kernel);

		/// <summary>
		/// Set the kernel to be a 3x3x3 or 5x5x5 or 7x7x7 kernel.
		/// </summary>
		// Token: 0x0600D46A RID: 54378 RVA: 0x001278FF File Offset: 0x00125AFF
		public void SetKernel5x5x5(IntPtr kernel)
		{
			vtkImageConvolve.vtkImageConvolve_SetKernel5x5x5_26(base.GetCppThis(), kernel);
		}

		// Token: 0x0600D46B RID: 54379
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageConvolve_SetKernel7x7_27(HandleRef pThis, IntPtr kernel);

		/// <summary>
		/// Set the kernel to be a given 3x3 or 5x5 or 7x7 kernel.
		/// </summary>
		// Token: 0x0600D46C RID: 54380 RVA: 0x0012790F File Offset: 0x00125B0F
		public void SetKernel7x7(IntPtr kernel)
		{
			vtkImageConvolve.vtkImageConvolve_SetKernel7x7_27(base.GetCppThis(), kernel);
		}

		// Token: 0x0600D46D RID: 54381
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageConvolve_SetKernel7x7x7_28(HandleRef pThis, IntPtr kernel);

		/// <summary>
		/// Set the kernel to be a 3x3x3 or 5x5x5 or 7x7x7 kernel.
		/// </summary>
		// Token: 0x0600D46E RID: 54382 RVA: 0x0012791F File Offset: 0x00125B1F
		public void SetKernel7x7x7(IntPtr kernel)
		{
			vtkImageConvolve.vtkImageConvolve_SetKernel7x7x7_28(base.GetCppThis(), kernel);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FAA RID: 4010
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageConvolve";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FAB RID: 4011
		public new static readonly string MRClassNameKey = "class vtkImageConvolve";
	}
}
