using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageAccumulate
	/// </summary>
	/// <remarks>
	///    Generalized histograms up to 3 dimensions.
	///
	/// vtkImageAccumulate - This filter divides component space into
	/// discrete bins.  It then counts the number of pixels associated
	/// with each bin.
	/// The dimensionality of the output depends on how many components the
	/// input pixels have. An input images with N components per pixels will
	/// result in an N-dimensional histogram, where N can be 1, 2, or 3.
	/// The input can be any type, but the output is always int.
	/// Some statistics are computed on the pixel values at the same time.
	/// The SetStencil and ReverseStencil functions allow the statistics to be
	/// computed on an arbitrary portion of the input data.
	/// See the documentation for vtkImageStencilData for more information.
	///
	/// This filter also supports ignoring pixels with value equal to 0. Using this
	/// option with vtkImageMask may result in results being slightly off since 0
	/// could be a valid value from your input.
	///
	/// </remarks>
	// Token: 0x0200023F RID: 575
	public class vtkImageAccumulate : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006AE5 RID: 27365 RVA: 0x0009A7FA File Offset: 0x000989FA
		static vtkImageAccumulate()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageAccumulate.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageAccumulate"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006AE6 RID: 27366 RVA: 0x0009A822 File Offset: 0x00098A22
		public vtkImageAccumulate(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006AE7 RID: 27367
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageAccumulate_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006AE8 RID: 27368 RVA: 0x0009A830 File Offset: 0x00098A30
		public new static vtkImageAccumulate New()
		{
			vtkImageAccumulate result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageAccumulate.vtkImageAccumulate_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageAccumulate)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006AE9 RID: 27369 RVA: 0x0009A884 File Offset: 0x00098A84
		public vtkImageAccumulate() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageAccumulate.vtkImageAccumulate_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006AEA RID: 27370 RVA: 0x0009A8C8 File Offset: 0x00098AC8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006AEB RID: 27371
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAccumulate_GetComponentExtent_01(HandleRef pThis, IntPtr extent);

		/// <summary>
		/// Set/Get - The component extent sets the number/extent of the bins.
		/// For a 1D histogram with 10 bins spanning the values 1000 to 2000,
		/// this extent should be set to 0, 9, 0, 0, 0, 0.
		/// The extent specifies inclusive min/max values.
		/// This implies that the top extent should be set to the number of bins - 1.
		/// Initial value is (0,255,0,0,0,0)
		/// </summary>
		// Token: 0x06006AEC RID: 27372 RVA: 0x0009A8D3 File Offset: 0x00098AD3
		public void GetComponentExtent(IntPtr extent)
		{
			vtkImageAccumulate.vtkImageAccumulate_GetComponentExtent_01(base.GetCppThis(), extent);
		}

		// Token: 0x06006AED RID: 27373
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageAccumulate_GetComponentExtent_02(HandleRef pThis);

		/// <summary>
		/// Set/Get - The component extent sets the number/extent of the bins.
		/// For a 1D histogram with 10 bins spanning the values 1000 to 2000,
		/// this extent should be set to 0, 9, 0, 0, 0, 0.
		/// The extent specifies inclusive min/max values.
		/// This implies that the top extent should be set to the number of bins - 1.
		/// Initial value is (0,255,0,0,0,0)
		/// </summary>
		// Token: 0x06006AEE RID: 27374 RVA: 0x0009A8E4 File Offset: 0x00098AE4
		public int[] GetComponentExtent()
		{
			IntPtr intPtr = vtkImageAccumulate.vtkImageAccumulate_GetComponentExtent_02(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06006AEF RID: 27375
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageAccumulate_GetComponentOrigin_03(HandleRef pThis);

		/// <summary>
		/// Set/Get - The component origin is the location of bin (0, 0, 0).
		/// Note that if the Component extent does not include the value (0,0,0),
		/// then this origin bin will not actually be in the output.
		/// The origin of the output ends up being the same as the component origin.
		/// For a 1D histogram with 10 bins spanning the values 1000 to 2000,
		/// this origin should be set to 1000, 0, 0.
		/// Initial value is (0.0,0.0,0.0).
		/// </summary>
		// Token: 0x06006AF0 RID: 27376 RVA: 0x0009A92C File Offset: 0x00098B2C
		public virtual double[] GetComponentOrigin()
		{
			IntPtr intPtr = vtkImageAccumulate.vtkImageAccumulate_GetComponentOrigin_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06006AF1 RID: 27377
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAccumulate_GetComponentOrigin_04(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get - The component origin is the location of bin (0, 0, 0).
		/// Note that if the Component extent does not include the value (0,0,0),
		/// then this origin bin will not actually be in the output.
		/// The origin of the output ends up being the same as the component origin.
		/// For a 1D histogram with 10 bins spanning the values 1000 to 2000,
		/// this origin should be set to 1000, 0, 0.
		/// Initial value is (0.0,0.0,0.0).
		/// </summary>
		// Token: 0x06006AF2 RID: 27378 RVA: 0x0009A974 File Offset: 0x00098B74
		public virtual void GetComponentOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageAccumulate.vtkImageAccumulate_GetComponentOrigin_04(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06006AF3 RID: 27379
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAccumulate_GetComponentOrigin_05(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get - The component origin is the location of bin (0, 0, 0).
		/// Note that if the Component extent does not include the value (0,0,0),
		/// then this origin bin will not actually be in the output.
		/// The origin of the output ends up being the same as the component origin.
		/// For a 1D histogram with 10 bins spanning the values 1000 to 2000,
		/// this origin should be set to 1000, 0, 0.
		/// Initial value is (0.0,0.0,0.0).
		/// </summary>
		// Token: 0x06006AF4 RID: 27380 RVA: 0x0009A986 File Offset: 0x00098B86
		public virtual void GetComponentOrigin(IntPtr _arg)
		{
			vtkImageAccumulate.vtkImageAccumulate_GetComponentOrigin_05(base.GetCppThis(), _arg);
		}

		// Token: 0x06006AF5 RID: 27381
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageAccumulate_GetComponentSpacing_06(HandleRef pThis);

		/// <summary>
		/// Set/Get - The component spacing is the dimension of each bin.
		/// This ends up being the spacing of the output "image".
		/// If the number of input scalar components are less than three,
		/// then some of these spacing values are ignored.
		/// For a 1D histogram with 10 bins spanning the values 1000 to 2000,
		/// this spacing should be set to 100, 0, 0.
		/// Initial value is (1.0,1.0,1.0).
		/// </summary>
		// Token: 0x06006AF6 RID: 27382 RVA: 0x0009A998 File Offset: 0x00098B98
		public virtual double[] GetComponentSpacing()
		{
			IntPtr intPtr = vtkImageAccumulate.vtkImageAccumulate_GetComponentSpacing_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06006AF7 RID: 27383
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAccumulate_GetComponentSpacing_07(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get - The component spacing is the dimension of each bin.
		/// This ends up being the spacing of the output "image".
		/// If the number of input scalar components are less than three,
		/// then some of these spacing values are ignored.
		/// For a 1D histogram with 10 bins spanning the values 1000 to 2000,
		/// this spacing should be set to 100, 0, 0.
		/// Initial value is (1.0,1.0,1.0).
		/// </summary>
		// Token: 0x06006AF8 RID: 27384 RVA: 0x0009A9E0 File Offset: 0x00098BE0
		public virtual void GetComponentSpacing(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageAccumulate.vtkImageAccumulate_GetComponentSpacing_07(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06006AF9 RID: 27385
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAccumulate_GetComponentSpacing_08(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get - The component spacing is the dimension of each bin.
		/// This ends up being the spacing of the output "image".
		/// If the number of input scalar components are less than three,
		/// then some of these spacing values are ignored.
		/// For a 1D histogram with 10 bins spanning the values 1000 to 2000,
		/// this spacing should be set to 100, 0, 0.
		/// Initial value is (1.0,1.0,1.0).
		/// </summary>
		// Token: 0x06006AFA RID: 27386 RVA: 0x0009A9F2 File Offset: 0x00098BF2
		public virtual void GetComponentSpacing(IntPtr _arg)
		{
			vtkImageAccumulate.vtkImageAccumulate_GetComponentSpacing_08(base.GetCppThis(), _arg);
		}

		// Token: 0x06006AFB RID: 27387
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageAccumulate_GetIgnoreZero_09(HandleRef pThis);

		/// <summary>
		/// Should the data with value 0 be ignored? Initial value is false.
		/// </summary>
		// Token: 0x06006AFC RID: 27388 RVA: 0x0009AA04 File Offset: 0x00098C04
		public virtual int GetIgnoreZero()
		{
			return vtkImageAccumulate.vtkImageAccumulate_GetIgnoreZero_09(base.GetCppThis());
		}

		// Token: 0x06006AFD RID: 27389
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageAccumulate_GetIgnoreZeroMaxValue_10(HandleRef pThis);

		/// <summary>
		/// Should the data with value 0 be ignored? Initial value is false.
		/// </summary>
		// Token: 0x06006AFE RID: 27390 RVA: 0x0009AA24 File Offset: 0x00098C24
		public virtual int GetIgnoreZeroMaxValue()
		{
			return vtkImageAccumulate.vtkImageAccumulate_GetIgnoreZeroMaxValue_10(base.GetCppThis());
		}

		// Token: 0x06006AFF RID: 27391
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageAccumulate_GetIgnoreZeroMinValue_11(HandleRef pThis);

		/// <summary>
		/// Should the data with value 0 be ignored? Initial value is false.
		/// </summary>
		// Token: 0x06006B00 RID: 27392 RVA: 0x0009AA44 File Offset: 0x00098C44
		public virtual int GetIgnoreZeroMinValue()
		{
			return vtkImageAccumulate.vtkImageAccumulate_GetIgnoreZeroMinValue_11(base.GetCppThis());
		}

		// Token: 0x06006B01 RID: 27393
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageAccumulate_GetMax_12(HandleRef pThis);

		/// <summary>
		/// Get the statistics information for the data.
		/// The values only make sense after the execution of the filter.
		/// Initial values are 0.
		/// </summary>
		// Token: 0x06006B02 RID: 27394 RVA: 0x0009AA64 File Offset: 0x00098C64
		public virtual double[] GetMax()
		{
			IntPtr intPtr = vtkImageAccumulate.vtkImageAccumulate_GetMax_12(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06006B03 RID: 27395
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAccumulate_GetMax_13(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Get the statistics information for the data.
		/// The values only make sense after the execution of the filter.
		/// Initial values are 0.
		/// </summary>
		// Token: 0x06006B04 RID: 27396 RVA: 0x0009AAAC File Offset: 0x00098CAC
		public virtual void GetMax(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageAccumulate.vtkImageAccumulate_GetMax_13(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06006B05 RID: 27397
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAccumulate_GetMax_14(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get the statistics information for the data.
		/// The values only make sense after the execution of the filter.
		/// Initial values are 0.
		/// </summary>
		// Token: 0x06006B06 RID: 27398 RVA: 0x0009AABE File Offset: 0x00098CBE
		public virtual void GetMax(IntPtr _arg)
		{
			vtkImageAccumulate.vtkImageAccumulate_GetMax_14(base.GetCppThis(), _arg);
		}

		// Token: 0x06006B07 RID: 27399
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageAccumulate_GetMean_15(HandleRef pThis);

		/// <summary>
		/// Get the statistics information for the data.
		/// The values only make sense after the execution of the filter.
		/// Initial values are 0.
		/// </summary>
		// Token: 0x06006B08 RID: 27400 RVA: 0x0009AAD0 File Offset: 0x00098CD0
		public virtual double[] GetMean()
		{
			IntPtr intPtr = vtkImageAccumulate.vtkImageAccumulate_GetMean_15(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06006B09 RID: 27401
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAccumulate_GetMean_16(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Get the statistics information for the data.
		/// The values only make sense after the execution of the filter.
		/// Initial values are 0.
		/// </summary>
		// Token: 0x06006B0A RID: 27402 RVA: 0x0009AB18 File Offset: 0x00098D18
		public virtual void GetMean(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageAccumulate.vtkImageAccumulate_GetMean_16(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06006B0B RID: 27403
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAccumulate_GetMean_17(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get the statistics information for the data.
		/// The values only make sense after the execution of the filter.
		/// Initial values are 0.
		/// </summary>
		// Token: 0x06006B0C RID: 27404 RVA: 0x0009AB2A File Offset: 0x00098D2A
		public virtual void GetMean(IntPtr _arg)
		{
			vtkImageAccumulate.vtkImageAccumulate_GetMean_17(base.GetCppThis(), _arg);
		}

		// Token: 0x06006B0D RID: 27405
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageAccumulate_GetMin_18(HandleRef pThis);

		/// <summary>
		/// Get the statistics information for the data.
		/// The values only make sense after the execution of the filter.
		/// Initial values are 0.
		/// </summary>
		// Token: 0x06006B0E RID: 27406 RVA: 0x0009AB3C File Offset: 0x00098D3C
		public virtual double[] GetMin()
		{
			IntPtr intPtr = vtkImageAccumulate.vtkImageAccumulate_GetMin_18(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06006B0F RID: 27407
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAccumulate_GetMin_19(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Get the statistics information for the data.
		/// The values only make sense after the execution of the filter.
		/// Initial values are 0.
		/// </summary>
		// Token: 0x06006B10 RID: 27408 RVA: 0x0009AB84 File Offset: 0x00098D84
		public virtual void GetMin(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageAccumulate.vtkImageAccumulate_GetMin_19(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06006B11 RID: 27409
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAccumulate_GetMin_20(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get the statistics information for the data.
		/// The values only make sense after the execution of the filter.
		/// Initial values are 0.
		/// </summary>
		// Token: 0x06006B12 RID: 27410 RVA: 0x0009AB96 File Offset: 0x00098D96
		public virtual void GetMin(IntPtr _arg)
		{
			vtkImageAccumulate.vtkImageAccumulate_GetMin_20(base.GetCppThis(), _arg);
		}

		// Token: 0x06006B13 RID: 27411
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageAccumulate_GetNumberOfGenerationsFromBase_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006B14 RID: 27412 RVA: 0x0009ABA8 File Offset: 0x00098DA8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageAccumulate.vtkImageAccumulate_GetNumberOfGenerationsFromBase_21(base.GetCppThis(), type);
		}

		// Token: 0x06006B15 RID: 27413
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageAccumulate_GetNumberOfGenerationsFromBaseType_22([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006B16 RID: 27414 RVA: 0x0009ABC8 File Offset: 0x00098DC8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageAccumulate.vtkImageAccumulate_GetNumberOfGenerationsFromBaseType_22(type);
		}

		// Token: 0x06006B17 RID: 27415
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageAccumulate_GetReverseStencil_23(HandleRef pThis);

		/// <summary>
		/// Reverse the stencil. Initial value is false.
		/// </summary>
		// Token: 0x06006B18 RID: 27416 RVA: 0x0009ABE4 File Offset: 0x00098DE4
		public virtual int GetReverseStencil()
		{
			return vtkImageAccumulate.vtkImageAccumulate_GetReverseStencil_23(base.GetCppThis());
		}

		// Token: 0x06006B19 RID: 27417
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageAccumulate_GetReverseStencilMaxValue_24(HandleRef pThis);

		/// <summary>
		/// Reverse the stencil. Initial value is false.
		/// </summary>
		// Token: 0x06006B1A RID: 27418 RVA: 0x0009AC04 File Offset: 0x00098E04
		public virtual int GetReverseStencilMaxValue()
		{
			return vtkImageAccumulate.vtkImageAccumulate_GetReverseStencilMaxValue_24(base.GetCppThis());
		}

		// Token: 0x06006B1B RID: 27419
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageAccumulate_GetReverseStencilMinValue_25(HandleRef pThis);

		/// <summary>
		/// Reverse the stencil. Initial value is false.
		/// </summary>
		// Token: 0x06006B1C RID: 27420 RVA: 0x0009AC24 File Offset: 0x00098E24
		public virtual int GetReverseStencilMinValue()
		{
			return vtkImageAccumulate.vtkImageAccumulate_GetReverseStencilMinValue_25(base.GetCppThis());
		}

		// Token: 0x06006B1D RID: 27421
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageAccumulate_GetStandardDeviation_26(HandleRef pThis);

		/// <summary>
		/// Get the statistics information for the data.
		/// The values only make sense after the execution of the filter.
		/// Initial values are 0.
		/// </summary>
		// Token: 0x06006B1E RID: 27422 RVA: 0x0009AC44 File Offset: 0x00098E44
		public virtual double[] GetStandardDeviation()
		{
			IntPtr intPtr = vtkImageAccumulate.vtkImageAccumulate_GetStandardDeviation_26(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06006B1F RID: 27423
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAccumulate_GetStandardDeviation_27(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Get the statistics information for the data.
		/// The values only make sense after the execution of the filter.
		/// Initial values are 0.
		/// </summary>
		// Token: 0x06006B20 RID: 27424 RVA: 0x0009AC8C File Offset: 0x00098E8C
		public virtual void GetStandardDeviation(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageAccumulate.vtkImageAccumulate_GetStandardDeviation_27(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06006B21 RID: 27425
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAccumulate_GetStandardDeviation_28(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get the statistics information for the data.
		/// The values only make sense after the execution of the filter.
		/// Initial values are 0.
		/// </summary>
		// Token: 0x06006B22 RID: 27426 RVA: 0x0009AC9E File Offset: 0x00098E9E
		public virtual void GetStandardDeviation(IntPtr _arg)
		{
			vtkImageAccumulate.vtkImageAccumulate_GetStandardDeviation_28(base.GetCppThis(), _arg);
		}

		// Token: 0x06006B23 RID: 27427
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageAccumulate_GetStencil_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Use a stencil to specify which voxels to accumulate.
		/// Backcompatible methods.
		/// It set and get the stencil on input port 1.
		/// Initial value is nullptr.
		/// </summary>
		// Token: 0x06006B24 RID: 27428 RVA: 0x0009ACB0 File Offset: 0x00098EB0
		public vtkImageStencilData GetStencil()
		{
			vtkImageStencilData vtkImageStencilData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageAccumulate.vtkImageAccumulate_GetStencil_29(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06006B25 RID: 27429
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageAccumulate_GetVoxelCount_30(HandleRef pThis);

		/// <summary>
		/// Get the statistics information for the data.
		/// The values only make sense after the execution of the filter.
		/// Initial values are 0.
		/// </summary>
		// Token: 0x06006B26 RID: 27430 RVA: 0x0009AD20 File Offset: 0x00098F20
		public virtual long GetVoxelCount()
		{
			return vtkImageAccumulate.vtkImageAccumulate_GetVoxelCount_30(base.GetCppThis());
		}

		// Token: 0x06006B27 RID: 27431
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAccumulate_IgnoreZeroOff_31(HandleRef pThis);

		/// <summary>
		/// Should the data with value 0 be ignored? Initial value is false.
		/// </summary>
		// Token: 0x06006B28 RID: 27432 RVA: 0x0009AD3F File Offset: 0x00098F3F
		public virtual void IgnoreZeroOff()
		{
			vtkImageAccumulate.vtkImageAccumulate_IgnoreZeroOff_31(base.GetCppThis());
		}

		// Token: 0x06006B29 RID: 27433
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAccumulate_IgnoreZeroOn_32(HandleRef pThis);

		/// <summary>
		/// Should the data with value 0 be ignored? Initial value is false.
		/// </summary>
		// Token: 0x06006B2A RID: 27434 RVA: 0x0009AD4E File Offset: 0x00098F4E
		public virtual void IgnoreZeroOn()
		{
			vtkImageAccumulate.vtkImageAccumulate_IgnoreZeroOn_32(base.GetCppThis());
		}

		// Token: 0x06006B2B RID: 27435
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageAccumulate_IsA_33(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006B2C RID: 27436 RVA: 0x0009AD60 File Offset: 0x00098F60
		public override int IsA(string type)
		{
			return vtkImageAccumulate.vtkImageAccumulate_IsA_33(base.GetCppThis(), type);
		}

		// Token: 0x06006B2D RID: 27437
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageAccumulate_IsTypeOf_34([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006B2E RID: 27438 RVA: 0x0009AD80 File Offset: 0x00098F80
		public new static int IsTypeOf(string type)
		{
			return vtkImageAccumulate.vtkImageAccumulate_IsTypeOf_34(type);
		}

		// Token: 0x06006B2F RID: 27439
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageAccumulate_NewInstance_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006B30 RID: 27440 RVA: 0x0009AD9C File Offset: 0x00098F9C
		public new vtkImageAccumulate NewInstance()
		{
			vtkImageAccumulate result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageAccumulate.vtkImageAccumulate_NewInstance_36(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageAccumulate)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006B31 RID: 27441
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAccumulate_ReverseStencilOff_37(HandleRef pThis);

		/// <summary>
		/// Reverse the stencil. Initial value is false.
		/// </summary>
		// Token: 0x06006B32 RID: 27442 RVA: 0x0009ADF6 File Offset: 0x00098FF6
		public virtual void ReverseStencilOff()
		{
			vtkImageAccumulate.vtkImageAccumulate_ReverseStencilOff_37(base.GetCppThis());
		}

		// Token: 0x06006B33 RID: 27443
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAccumulate_ReverseStencilOn_38(HandleRef pThis);

		/// <summary>
		/// Reverse the stencil. Initial value is false.
		/// </summary>
		// Token: 0x06006B34 RID: 27444 RVA: 0x0009AE05 File Offset: 0x00099005
		public virtual void ReverseStencilOn()
		{
			vtkImageAccumulate.vtkImageAccumulate_ReverseStencilOn_38(base.GetCppThis());
		}

		// Token: 0x06006B35 RID: 27445
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageAccumulate_SafeDownCast_39(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006B36 RID: 27446 RVA: 0x0009AE14 File Offset: 0x00099014
		public new static vtkImageAccumulate SafeDownCast(vtkObjectBase o)
		{
			vtkImageAccumulate vtkImageAccumulate = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageAccumulate.vtkImageAccumulate_SafeDownCast_39((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageAccumulate = (vtkImageAccumulate)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageAccumulate.Register(null);
				}
			}
			return vtkImageAccumulate;
		}

		// Token: 0x06006B37 RID: 27447
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAccumulate_SetComponentExtent_40(HandleRef pThis, IntPtr extent);

		/// <summary>
		/// Set/Get - The component extent sets the number/extent of the bins.
		/// For a 1D histogram with 10 bins spanning the values 1000 to 2000,
		/// this extent should be set to 0, 9, 0, 0, 0, 0.
		/// The extent specifies inclusive min/max values.
		/// This implies that the top extent should be set to the number of bins - 1.
		/// Initial value is (0,255,0,0,0,0)
		/// </summary>
		// Token: 0x06006B38 RID: 27448 RVA: 0x0009AE93 File Offset: 0x00099093
		public void SetComponentExtent(IntPtr extent)
		{
			vtkImageAccumulate.vtkImageAccumulate_SetComponentExtent_40(base.GetCppThis(), extent);
		}

		// Token: 0x06006B39 RID: 27449
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAccumulate_SetComponentExtent_41(HandleRef pThis, int minX, int maxX, int minY, int maxY, int minZ, int maxZ);

		/// <summary>
		/// Set/Get - The component extent sets the number/extent of the bins.
		/// For a 1D histogram with 10 bins spanning the values 1000 to 2000,
		/// this extent should be set to 0, 9, 0, 0, 0, 0.
		/// The extent specifies inclusive min/max values.
		/// This implies that the top extent should be set to the number of bins - 1.
		/// Initial value is (0,255,0,0,0,0)
		/// </summary>
		// Token: 0x06006B3A RID: 27450 RVA: 0x0009AEA3 File Offset: 0x000990A3
		public void SetComponentExtent(int minX, int maxX, int minY, int maxY, int minZ, int maxZ)
		{
			vtkImageAccumulate.vtkImageAccumulate_SetComponentExtent_41(base.GetCppThis(), minX, maxX, minY, maxY, minZ, maxZ);
		}

		// Token: 0x06006B3B RID: 27451
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAccumulate_SetComponentOrigin_42(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get - The component origin is the location of bin (0, 0, 0).
		/// Note that if the Component extent does not include the value (0,0,0),
		/// then this origin bin will not actually be in the output.
		/// The origin of the output ends up being the same as the component origin.
		/// For a 1D histogram with 10 bins spanning the values 1000 to 2000,
		/// this origin should be set to 1000, 0, 0.
		/// Initial value is (0.0,0.0,0.0).
		/// </summary>
		// Token: 0x06006B3C RID: 27452 RVA: 0x0009AEBB File Offset: 0x000990BB
		public virtual void SetComponentOrigin(double _arg1, double _arg2, double _arg3)
		{
			vtkImageAccumulate.vtkImageAccumulate_SetComponentOrigin_42(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06006B3D RID: 27453
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAccumulate_SetComponentOrigin_43(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get - The component origin is the location of bin (0, 0, 0).
		/// Note that if the Component extent does not include the value (0,0,0),
		/// then this origin bin will not actually be in the output.
		/// The origin of the output ends up being the same as the component origin.
		/// For a 1D histogram with 10 bins spanning the values 1000 to 2000,
		/// this origin should be set to 1000, 0, 0.
		/// Initial value is (0.0,0.0,0.0).
		/// </summary>
		// Token: 0x06006B3E RID: 27454 RVA: 0x0009AECD File Offset: 0x000990CD
		public virtual void SetComponentOrigin(IntPtr _arg)
		{
			vtkImageAccumulate.vtkImageAccumulate_SetComponentOrigin_43(base.GetCppThis(), _arg);
		}

		// Token: 0x06006B3F RID: 27455
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAccumulate_SetComponentSpacing_44(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get - The component spacing is the dimension of each bin.
		/// This ends up being the spacing of the output "image".
		/// If the number of input scalar components are less than three,
		/// then some of these spacing values are ignored.
		/// For a 1D histogram with 10 bins spanning the values 1000 to 2000,
		/// this spacing should be set to 100, 0, 0.
		/// Initial value is (1.0,1.0,1.0).
		/// </summary>
		// Token: 0x06006B40 RID: 27456 RVA: 0x0009AEDD File Offset: 0x000990DD
		public virtual void SetComponentSpacing(double _arg1, double _arg2, double _arg3)
		{
			vtkImageAccumulate.vtkImageAccumulate_SetComponentSpacing_44(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06006B41 RID: 27457
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAccumulate_SetComponentSpacing_45(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get - The component spacing is the dimension of each bin.
		/// This ends up being the spacing of the output "image".
		/// If the number of input scalar components are less than three,
		/// then some of these spacing values are ignored.
		/// For a 1D histogram with 10 bins spanning the values 1000 to 2000,
		/// this spacing should be set to 100, 0, 0.
		/// Initial value is (1.0,1.0,1.0).
		/// </summary>
		// Token: 0x06006B42 RID: 27458 RVA: 0x0009AEEF File Offset: 0x000990EF
		public virtual void SetComponentSpacing(IntPtr _arg)
		{
			vtkImageAccumulate.vtkImageAccumulate_SetComponentSpacing_45(base.GetCppThis(), _arg);
		}

		// Token: 0x06006B43 RID: 27459
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAccumulate_SetIgnoreZero_46(HandleRef pThis, int _arg);

		/// <summary>
		/// Should the data with value 0 be ignored? Initial value is false.
		/// </summary>
		// Token: 0x06006B44 RID: 27460 RVA: 0x0009AEFF File Offset: 0x000990FF
		public virtual void SetIgnoreZero(int _arg)
		{
			vtkImageAccumulate.vtkImageAccumulate_SetIgnoreZero_46(base.GetCppThis(), _arg);
		}

		// Token: 0x06006B45 RID: 27461
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAccumulate_SetReverseStencil_47(HandleRef pThis, int _arg);

		/// <summary>
		/// Reverse the stencil. Initial value is false.
		/// </summary>
		// Token: 0x06006B46 RID: 27462 RVA: 0x0009AF0F File Offset: 0x0009910F
		public virtual void SetReverseStencil(int _arg)
		{
			vtkImageAccumulate.vtkImageAccumulate_SetReverseStencil_47(base.GetCppThis(), _arg);
		}

		// Token: 0x06006B47 RID: 27463
		[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAccumulate_SetStencilData_48(HandleRef pThis, HandleRef stencil);

		/// <summary>
		/// Use a stencil to specify which voxels to accumulate.
		/// Backcompatible methods.
		/// It set and get the stencil on input port 1.
		/// Initial value is nullptr.
		/// </summary>
		// Token: 0x06006B48 RID: 27464 RVA: 0x0009AF20 File Offset: 0x00099120
		public void SetStencilData(vtkImageStencilData stencil)
		{
			vtkImageAccumulate.vtkImageAccumulate_SetStencilData_48(base.GetCppThis(), (stencil == null) ? default(HandleRef) : stencil.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400096D RID: 2413
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageAccumulate";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400096E RID: 2414
		public new static readonly string MRClassNameKey = "class vtkImageAccumulate";
	}
}
