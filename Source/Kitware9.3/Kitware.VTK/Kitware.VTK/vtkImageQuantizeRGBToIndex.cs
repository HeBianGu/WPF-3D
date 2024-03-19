using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageQuantizeRGBToIndex
	/// </summary>
	/// <remarks>
	///    generalized histograms up to 4 dimensions
	///
	/// vtkImageQuantizeRGBToIndex takes a 3 component RGB image as
	/// input and produces a one component index image as output, along with
	/// a lookup table that contains the color definitions for the index values.
	/// This filter works on the entire input extent - it does not perform
	/// streaming, and it does not supported threaded execution (because it has
	/// to process the entire image).
	///
	/// To use this filter, you typically set the number of colors
	/// (between 2 and 65536), execute it, and then retrieve the lookup table.
	/// The colors can then be using the lookup table and the image index.
	///
	/// This filter can run faster, by initially sampling the colors at a
	/// coarser level. This can be specified by the SamplingRate parameter.
	///
	/// The "index-image" viewed as a greyscale image, is usually quite
	/// arbitrary, accentuating contrast where none can be perceived in
	/// the original color image.
	/// To make the index image more meaningful (e.g. for image segmentation
	/// operating on scalar images), we sort the mean colors by luminance
	/// and re-map the indices accordingly. This option does not introduce any
	/// computational complexity and has no impact on actual colors in the
	/// lookup table (only their order).
	/// </remarks>
	// Token: 0x020003F3 RID: 1011
	public class vtkImageQuantizeRGBToIndex : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C149 RID: 49481 RVA: 0x0010D41F File Offset: 0x0010B61F
		static vtkImageQuantizeRGBToIndex()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageQuantizeRGBToIndex.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageQuantizeRGBToIndex"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C14A RID: 49482 RVA: 0x0010D447 File Offset: 0x0010B647
		public vtkImageQuantizeRGBToIndex(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C14B RID: 49483
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageQuantizeRGBToIndex_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C14C RID: 49484 RVA: 0x0010D458 File Offset: 0x0010B658
		public new static vtkImageQuantizeRGBToIndex New()
		{
			vtkImageQuantizeRGBToIndex result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageQuantizeRGBToIndex.vtkImageQuantizeRGBToIndex_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageQuantizeRGBToIndex)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C14D RID: 49485 RVA: 0x0010D4AC File Offset: 0x0010B6AC
		public vtkImageQuantizeRGBToIndex() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageQuantizeRGBToIndex.vtkImageQuantizeRGBToIndex_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C14E RID: 49486 RVA: 0x0010D4F0 File Offset: 0x0010B6F0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C14F RID: 49487
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageQuantizeRGBToIndex_GetBuildTreeExecuteTime_01(HandleRef pThis);

		/// <summary>
		/// Get the resulting lookup table that contains the color definitions
		/// corresponding to the index values in the output image.
		/// </summary>
		// Token: 0x0600C150 RID: 49488 RVA: 0x0010D4FC File Offset: 0x0010B6FC
		public virtual double GetBuildTreeExecuteTime()
		{
			return vtkImageQuantizeRGBToIndex.vtkImageQuantizeRGBToIndex_GetBuildTreeExecuteTime_01(base.GetCppThis());
		}

		// Token: 0x0600C151 RID: 49489
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageQuantizeRGBToIndex_GetInitializeExecuteTime_02(HandleRef pThis);

		/// <summary>
		/// Get the resulting lookup table that contains the color definitions
		/// corresponding to the index values in the output image.
		/// </summary>
		// Token: 0x0600C152 RID: 49490 RVA: 0x0010D51C File Offset: 0x0010B71C
		public virtual double GetInitializeExecuteTime()
		{
			return vtkImageQuantizeRGBToIndex.vtkImageQuantizeRGBToIndex_GetInitializeExecuteTime_02(base.GetCppThis());
		}

		// Token: 0x0600C153 RID: 49491
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageQuantizeRGBToIndex_GetInputType_03(HandleRef pThis);

		/// <summary>
		/// For internal use only - get the type of the image
		/// </summary>
		// Token: 0x0600C154 RID: 49492 RVA: 0x0010D53C File Offset: 0x0010B73C
		public virtual int GetInputType()
		{
			return vtkImageQuantizeRGBToIndex.vtkImageQuantizeRGBToIndex_GetInputType_03(base.GetCppThis());
		}

		// Token: 0x0600C155 RID: 49493
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageQuantizeRGBToIndex_GetLookupIndexExecuteTime_04(HandleRef pThis);

		/// <summary>
		/// Get the resulting lookup table that contains the color definitions
		/// corresponding to the index values in the output image.
		/// </summary>
		// Token: 0x0600C156 RID: 49494 RVA: 0x0010D55C File Offset: 0x0010B75C
		public virtual double GetLookupIndexExecuteTime()
		{
			return vtkImageQuantizeRGBToIndex.vtkImageQuantizeRGBToIndex_GetLookupIndexExecuteTime_04(base.GetCppThis());
		}

		// Token: 0x0600C157 RID: 49495
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageQuantizeRGBToIndex_GetLookupTable_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the resulting lookup table that contains the color definitions
		/// corresponding to the index values in the output image.
		/// </summary>
		// Token: 0x0600C158 RID: 49496 RVA: 0x0010D57C File Offset: 0x0010B77C
		public virtual vtkLookupTable GetLookupTable()
		{
			vtkLookupTable vtkLookupTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageQuantizeRGBToIndex.vtkImageQuantizeRGBToIndex_GetLookupTable_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLookupTable = (vtkLookupTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLookupTable.Register(null);
				}
			}
			return vtkLookupTable;
		}

		// Token: 0x0600C159 RID: 49497
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageQuantizeRGBToIndex_GetNumberOfColors_06(HandleRef pThis);

		/// <summary>
		/// Set / Get the number of color index values to produce - must be
		/// a number between 2 and 65536.
		/// </summary>
		// Token: 0x0600C15A RID: 49498 RVA: 0x0010D5EC File Offset: 0x0010B7EC
		public virtual int GetNumberOfColors()
		{
			return vtkImageQuantizeRGBToIndex.vtkImageQuantizeRGBToIndex_GetNumberOfColors_06(base.GetCppThis());
		}

		// Token: 0x0600C15B RID: 49499
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageQuantizeRGBToIndex_GetNumberOfColorsMaxValue_07(HandleRef pThis);

		/// <summary>
		/// Set / Get the number of color index values to produce - must be
		/// a number between 2 and 65536.
		/// </summary>
		// Token: 0x0600C15C RID: 49500 RVA: 0x0010D60C File Offset: 0x0010B80C
		public virtual int GetNumberOfColorsMaxValue()
		{
			return vtkImageQuantizeRGBToIndex.vtkImageQuantizeRGBToIndex_GetNumberOfColorsMaxValue_07(base.GetCppThis());
		}

		// Token: 0x0600C15D RID: 49501
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageQuantizeRGBToIndex_GetNumberOfColorsMinValue_08(HandleRef pThis);

		/// <summary>
		/// Set / Get the number of color index values to produce - must be
		/// a number between 2 and 65536.
		/// </summary>
		// Token: 0x0600C15E RID: 49502 RVA: 0x0010D62C File Offset: 0x0010B82C
		public virtual int GetNumberOfColorsMinValue()
		{
			return vtkImageQuantizeRGBToIndex.vtkImageQuantizeRGBToIndex_GetNumberOfColorsMinValue_08(base.GetCppThis());
		}

		// Token: 0x0600C15F RID: 49503
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageQuantizeRGBToIndex_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C160 RID: 49504 RVA: 0x0010D64C File Offset: 0x0010B84C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageQuantizeRGBToIndex.vtkImageQuantizeRGBToIndex_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x0600C161 RID: 49505
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageQuantizeRGBToIndex_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C162 RID: 49506 RVA: 0x0010D66C File Offset: 0x0010B86C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageQuantizeRGBToIndex.vtkImageQuantizeRGBToIndex_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x0600C163 RID: 49507
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageQuantizeRGBToIndex_GetSamplingRate_11(HandleRef pThis);

		/// <summary>
		/// Set / Get the number of color index values to produce - must be
		/// a number between 2 and 65536.
		/// </summary>
		// Token: 0x0600C164 RID: 49508 RVA: 0x0010D688 File Offset: 0x0010B888
		public virtual int[] GetSamplingRate()
		{
			IntPtr intPtr = vtkImageQuantizeRGBToIndex.vtkImageQuantizeRGBToIndex_GetSamplingRate_11(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600C165 RID: 49509
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageQuantizeRGBToIndex_GetSamplingRate_12(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

		/// <summary>
		/// Set / Get the number of color index values to produce - must be
		/// a number between 2 and 65536.
		/// </summary>
		// Token: 0x0600C166 RID: 49510 RVA: 0x0010D6D0 File Offset: 0x0010B8D0
		public virtual void GetSamplingRate(ref int _arg1, ref int _arg2, ref int _arg3)
		{
			vtkImageQuantizeRGBToIndex.vtkImageQuantizeRGBToIndex_GetSamplingRate_12(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600C167 RID: 49511
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageQuantizeRGBToIndex_GetSamplingRate_13(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set / Get the number of color index values to produce - must be
		/// a number between 2 and 65536.
		/// </summary>
		// Token: 0x0600C168 RID: 49512 RVA: 0x0010D6E2 File Offset: 0x0010B8E2
		public virtual void GetSamplingRate(IntPtr _arg)
		{
			vtkImageQuantizeRGBToIndex.vtkImageQuantizeRGBToIndex_GetSamplingRate_13(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C169 RID: 49513
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkImageQuantizeRGBToIndex_GetSortIndexByLuminance_14(HandleRef pThis);

		/// <summary>
		/// Set / Get the number of color index values to produce - must be
		/// a number between 2 and 65536.
		/// </summary>
		// Token: 0x0600C16A RID: 49514 RVA: 0x0010D6F4 File Offset: 0x0010B8F4
		public virtual bool GetSortIndexByLuminance()
		{
			return vtkImageQuantizeRGBToIndex.vtkImageQuantizeRGBToIndex_GetSortIndexByLuminance_14(base.GetCppThis()) != 0;
		}

		// Token: 0x0600C16B RID: 49515
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageQuantizeRGBToIndex_IsA_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C16C RID: 49516 RVA: 0x0010D71C File Offset: 0x0010B91C
		public override int IsA(string type)
		{
			return vtkImageQuantizeRGBToIndex.vtkImageQuantizeRGBToIndex_IsA_15(base.GetCppThis(), type);
		}

		// Token: 0x0600C16D RID: 49517
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageQuantizeRGBToIndex_IsTypeOf_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C16E RID: 49518 RVA: 0x0010D73C File Offset: 0x0010B93C
		public new static int IsTypeOf(string type)
		{
			return vtkImageQuantizeRGBToIndex.vtkImageQuantizeRGBToIndex_IsTypeOf_16(type);
		}

		// Token: 0x0600C16F RID: 49519
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageQuantizeRGBToIndex_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C170 RID: 49520 RVA: 0x0010D758 File Offset: 0x0010B958
		public new vtkImageQuantizeRGBToIndex NewInstance()
		{
			vtkImageQuantizeRGBToIndex result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageQuantizeRGBToIndex.vtkImageQuantizeRGBToIndex_NewInstance_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageQuantizeRGBToIndex)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C171 RID: 49521
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageQuantizeRGBToIndex_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C172 RID: 49522 RVA: 0x0010D7B4 File Offset: 0x0010B9B4
		public new static vtkImageQuantizeRGBToIndex SafeDownCast(vtkObjectBase o)
		{
			vtkImageQuantizeRGBToIndex vtkImageQuantizeRGBToIndex = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageQuantizeRGBToIndex.vtkImageQuantizeRGBToIndex_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageQuantizeRGBToIndex = (vtkImageQuantizeRGBToIndex)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageQuantizeRGBToIndex.Register(null);
				}
			}
			return vtkImageQuantizeRGBToIndex;
		}

		// Token: 0x0600C173 RID: 49523
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageQuantizeRGBToIndex_SetBuildTreeExecuteTime_20(HandleRef pThis, double _arg);

		/// <summary>
		/// For internal use only - set the times for execution
		/// </summary>
		// Token: 0x0600C174 RID: 49524 RVA: 0x0010D833 File Offset: 0x0010BA33
		public virtual void SetBuildTreeExecuteTime(double _arg)
		{
			vtkImageQuantizeRGBToIndex.vtkImageQuantizeRGBToIndex_SetBuildTreeExecuteTime_20(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C175 RID: 49525
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageQuantizeRGBToIndex_SetInitializeExecuteTime_21(HandleRef pThis, double _arg);

		/// <summary>
		/// For internal use only - set the times for execution
		/// </summary>
		// Token: 0x0600C176 RID: 49526 RVA: 0x0010D843 File Offset: 0x0010BA43
		public virtual void SetInitializeExecuteTime(double _arg)
		{
			vtkImageQuantizeRGBToIndex.vtkImageQuantizeRGBToIndex_SetInitializeExecuteTime_21(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C177 RID: 49527
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageQuantizeRGBToIndex_SetLookupIndexExecuteTime_22(HandleRef pThis, double _arg);

		/// <summary>
		/// For internal use only - set the times for execution
		/// </summary>
		// Token: 0x0600C178 RID: 49528 RVA: 0x0010D853 File Offset: 0x0010BA53
		public virtual void SetLookupIndexExecuteTime(double _arg)
		{
			vtkImageQuantizeRGBToIndex.vtkImageQuantizeRGBToIndex_SetLookupIndexExecuteTime_22(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C179 RID: 49529
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageQuantizeRGBToIndex_SetNumberOfColors_23(HandleRef pThis, int _arg);

		/// <summary>
		/// Set / Get the number of color index values to produce - must be
		/// a number between 2 and 65536.
		/// </summary>
		// Token: 0x0600C17A RID: 49530 RVA: 0x0010D863 File Offset: 0x0010BA63
		public virtual void SetNumberOfColors(int _arg)
		{
			vtkImageQuantizeRGBToIndex.vtkImageQuantizeRGBToIndex_SetNumberOfColors_23(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C17B RID: 49531
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageQuantizeRGBToIndex_SetSamplingRate_24(HandleRef pThis, int _arg1, int _arg2, int _arg3);

		/// <summary>
		/// Set / Get the number of color index values to produce - must be
		/// a number between 2 and 65536.
		/// </summary>
		// Token: 0x0600C17C RID: 49532 RVA: 0x0010D873 File Offset: 0x0010BA73
		public virtual void SetSamplingRate(int _arg1, int _arg2, int _arg3)
		{
			vtkImageQuantizeRGBToIndex.vtkImageQuantizeRGBToIndex_SetSamplingRate_24(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600C17D RID: 49533
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageQuantizeRGBToIndex_SetSamplingRate_25(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set / Get the number of color index values to produce - must be
		/// a number between 2 and 65536.
		/// </summary>
		// Token: 0x0600C17E RID: 49534 RVA: 0x0010D885 File Offset: 0x0010BA85
		public virtual void SetSamplingRate(IntPtr _arg)
		{
			vtkImageQuantizeRGBToIndex.vtkImageQuantizeRGBToIndex_SetSamplingRate_25(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C17F RID: 49535
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageQuantizeRGBToIndex_SetSortIndexByLuminance_26(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set / Get the number of color index values to produce - must be
		/// a number between 2 and 65536.
		/// </summary>
		// Token: 0x0600C180 RID: 49536 RVA: 0x0010D895 File Offset: 0x0010BA95
		public virtual void SetSortIndexByLuminance(bool _arg)
		{
			vtkImageQuantizeRGBToIndex.vtkImageQuantizeRGBToIndex_SetSortIndexByLuminance_26(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600C181 RID: 49537
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageQuantizeRGBToIndex_SortIndexByLuminanceOff_27(HandleRef pThis);

		/// <summary>
		/// Set / Get the number of color index values to produce - must be
		/// a number between 2 and 65536.
		/// </summary>
		// Token: 0x0600C182 RID: 49538 RVA: 0x0010D8AD File Offset: 0x0010BAAD
		public virtual void SortIndexByLuminanceOff()
		{
			vtkImageQuantizeRGBToIndex.vtkImageQuantizeRGBToIndex_SortIndexByLuminanceOff_27(base.GetCppThis());
		}

		// Token: 0x0600C183 RID: 49539
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageQuantizeRGBToIndex_SortIndexByLuminanceOn_28(HandleRef pThis);

		/// <summary>
		/// Set / Get the number of color index values to produce - must be
		/// a number between 2 and 65536.
		/// </summary>
		// Token: 0x0600C184 RID: 49540 RVA: 0x0010D8BC File Offset: 0x0010BABC
		public virtual void SortIndexByLuminanceOn()
		{
			vtkImageQuantizeRGBToIndex.vtkImageQuantizeRGBToIndex_SortIndexByLuminanceOn_28(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E53 RID: 3667
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageQuantizeRGBToIndex";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E54 RID: 3668
		public new static readonly string MRClassNameKey = "class vtkImageQuantizeRGBToIndex";
	}
}
