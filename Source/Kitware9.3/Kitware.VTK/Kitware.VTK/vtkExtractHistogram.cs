using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExtractHistogram
	/// </summary>
	/// <remarks>
	///    Extract histogram data (binned values) from any
	/// dataset
	///
	/// vtkExtractHistogram accepts any vtkDataSet as input and produces a
	/// vtkTable containing histogram data as output.  The output vtkTable
	/// will contains a vtkDoubleArray named "bin_extents" which contains
	/// the boundaries between each histogram bin, and a vtkUnsignedLongArray
	/// named "bin_values" which will contain the value for each bin.
	/// </remarks>
	// Token: 0x02000744 RID: 1860
	public class vtkExtractHistogram : vtkTableAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06013539 RID: 79161 RVA: 0x001B56C7 File Offset: 0x001B38C7
		static vtkExtractHistogram()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractHistogram.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractHistogram"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601353A RID: 79162 RVA: 0x001B56EF File Offset: 0x001B38EF
		public vtkExtractHistogram(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601353B RID: 79163
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractHistogram_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601353C RID: 79164 RVA: 0x001B5700 File Offset: 0x001B3900
		public new static vtkExtractHistogram New()
		{
			vtkExtractHistogram result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractHistogram.vtkExtractHistogram_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractHistogram)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601353D RID: 79165 RVA: 0x001B5754 File Offset: 0x001B3954
		public vtkExtractHistogram() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExtractHistogram.vtkExtractHistogram_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601353E RID: 79166 RVA: 0x001B5798 File Offset: 0x001B3998
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601353F RID: 79167
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram_AccumulationOff_01(HandleRef pThis);

		/// <summary>
		/// If this option is set to true then the output table will contain an additional column with
		/// accumulated bin values.
		/// Default is false.
		/// </summary>
		// Token: 0x06013540 RID: 79168 RVA: 0x001B57A3 File Offset: 0x001B39A3
		public virtual void AccumulationOff()
		{
			vtkExtractHistogram.vtkExtractHistogram_AccumulationOff_01(base.GetCppThis());
		}

		// Token: 0x06013541 RID: 79169
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram_AccumulationOn_02(HandleRef pThis);

		/// <summary>
		/// If this option is set to true then the output table will contain an additional column with
		/// accumulated bin values.
		/// Default is false.
		/// </summary>
		// Token: 0x06013542 RID: 79170 RVA: 0x001B57B2 File Offset: 0x001B39B2
		public virtual void AccumulationOn()
		{
			vtkExtractHistogram.vtkExtractHistogram_AccumulationOn_02(base.GetCppThis());
		}

		// Token: 0x06013543 RID: 79171
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram_CalculateAveragesOff_03(HandleRef pThis);

		/// <summary>
		/// This option controls whether the algorithm calculates averages
		/// of variables other than the primary variable that fall into each
		/// bin.
		/// Default is false.
		/// </summary>
		// Token: 0x06013544 RID: 79172 RVA: 0x001B57C1 File Offset: 0x001B39C1
		public virtual void CalculateAveragesOff()
		{
			vtkExtractHistogram.vtkExtractHistogram_CalculateAveragesOff_03(base.GetCppThis());
		}

		// Token: 0x06013545 RID: 79173
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram_CalculateAveragesOn_04(HandleRef pThis);

		/// <summary>
		/// This option controls whether the algorithm calculates averages
		/// of variables other than the primary variable that fall into each
		/// bin.
		/// Default is false.
		/// </summary>
		// Token: 0x06013546 RID: 79174 RVA: 0x001B57D0 File Offset: 0x001B39D0
		public virtual void CalculateAveragesOn()
		{
			vtkExtractHistogram.vtkExtractHistogram_CalculateAveragesOn_04(base.GetCppThis());
		}

		// Token: 0x06013547 RID: 79175
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram_CenterBinsAroundMinAndMaxOff_05(HandleRef pThis);

		/// <summary>
		/// Get/Set if first and last bins must be centered around the min and max
		/// data. This is only used when UseCustomBinRanges is set to false.
		/// Default is false.
		/// </summary>
		// Token: 0x06013548 RID: 79176 RVA: 0x001B57DF File Offset: 0x001B39DF
		public virtual void CenterBinsAroundMinAndMaxOff()
		{
			vtkExtractHistogram.vtkExtractHistogram_CenterBinsAroundMinAndMaxOff_05(base.GetCppThis());
		}

		// Token: 0x06013549 RID: 79177
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram_CenterBinsAroundMinAndMaxOn_06(HandleRef pThis);

		/// <summary>
		/// Get/Set if first and last bins must be centered around the min and max
		/// data. This is only used when UseCustomBinRanges is set to false.
		/// Default is false.
		/// </summary>
		// Token: 0x0601354A RID: 79178 RVA: 0x001B57EE File Offset: 0x001B39EE
		public virtual void CenterBinsAroundMinAndMaxOn()
		{
			vtkExtractHistogram.vtkExtractHistogram_CenterBinsAroundMinAndMaxOn_06(base.GetCppThis());
		}

		// Token: 0x0601354B RID: 79179
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExtractHistogram_GetAccumulation_07(HandleRef pThis);

		/// <summary>
		/// If this option is set to true then the output table will contain an additional column with
		/// accumulated bin values.
		/// Default is false.
		/// </summary>
		// Token: 0x0601354C RID: 79180 RVA: 0x001B5800 File Offset: 0x001B3A00
		public virtual bool GetAccumulation()
		{
			return vtkExtractHistogram.vtkExtractHistogram_GetAccumulation_07(base.GetCppThis()) != 0;
		}

		// Token: 0x0601354D RID: 79181
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractHistogram_GetBinAccumulationArrayName_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the name of the optional bin accumulation array.
		/// Default is "bin_accumulation".
		/// </summary>
		// Token: 0x0601354E RID: 79182 RVA: 0x001B5828 File Offset: 0x001B3A28
		public virtual string GetBinAccumulationArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkExtractHistogram.vtkExtractHistogram_GetBinAccumulationArrayName_08(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601354F RID: 79183
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractHistogram_GetBinCount_09(HandleRef pThis);

		/// <summary>
		/// Controls the number of bins N in the output histogram data.
		/// Default is 10.
		/// </summary>
		// Token: 0x06013550 RID: 79184 RVA: 0x001B5864 File Offset: 0x001B3A64
		public virtual int GetBinCount()
		{
			return vtkExtractHistogram.vtkExtractHistogram_GetBinCount_09(base.GetCppThis());
		}

		// Token: 0x06013551 RID: 79185
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractHistogram_GetBinCountMaxValue_10(HandleRef pThis);

		/// <summary>
		/// Controls the number of bins N in the output histogram data.
		/// Default is 10.
		/// </summary>
		// Token: 0x06013552 RID: 79186 RVA: 0x001B5884 File Offset: 0x001B3A84
		public virtual int GetBinCountMaxValue()
		{
			return vtkExtractHistogram.vtkExtractHistogram_GetBinCountMaxValue_10(base.GetCppThis());
		}

		// Token: 0x06013553 RID: 79187
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractHistogram_GetBinCountMinValue_11(HandleRef pThis);

		/// <summary>
		/// Controls the number of bins N in the output histogram data.
		/// Default is 10.
		/// </summary>
		// Token: 0x06013554 RID: 79188 RVA: 0x001B58A4 File Offset: 0x001B3AA4
		public virtual int GetBinCountMinValue()
		{
			return vtkExtractHistogram.vtkExtractHistogram_GetBinCountMinValue_11(base.GetCppThis());
		}

		// Token: 0x06013555 RID: 79189
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractHistogram_GetBinExtentsArrayName_12(HandleRef pThis);

		/// <summary>
		/// Set/Get the name of the bin extents array.
		/// Default is "bin_extents".
		/// </summary>
		// Token: 0x06013556 RID: 79190 RVA: 0x001B58C4 File Offset: 0x001B3AC4
		public virtual string GetBinExtentsArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkExtractHistogram.vtkExtractHistogram_GetBinExtentsArrayName_12(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013557 RID: 79191
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractHistogram_GetBinRange_13(HandleRef pThis);

		/// <summary>
		/// Get the bin range which was used to create the bin extents.
		/// </summary>
		// Token: 0x06013558 RID: 79192 RVA: 0x001B5900 File Offset: 0x001B3B00
		public virtual double[] GetBinRange()
		{
			IntPtr intPtr = vtkExtractHistogram.vtkExtractHistogram_GetBinRange_13(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06013559 RID: 79193
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram_GetBinRange_14(HandleRef pThis, ref double _arg1, ref double _arg2);

		/// <summary>
		/// Get the bin range which was used to create the bin extents.
		/// </summary>
		// Token: 0x0601355A RID: 79194 RVA: 0x001B5948 File Offset: 0x001B3B48
		public virtual void GetBinRange(ref double _arg1, ref double _arg2)
		{
			vtkExtractHistogram.vtkExtractHistogram_GetBinRange_14(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x0601355B RID: 79195
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram_GetBinRange_15(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get the bin range which was used to create the bin extents.
		/// </summary>
		// Token: 0x0601355C RID: 79196 RVA: 0x001B5959 File Offset: 0x001B3B59
		public virtual void GetBinRange(IntPtr _arg)
		{
			vtkExtractHistogram.vtkExtractHistogram_GetBinRange_15(base.GetCppThis(), _arg);
		}

		// Token: 0x0601355D RID: 79197
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractHistogram_GetBinValuesArrayName_16(HandleRef pThis);

		/// <summary>
		/// Set/Get the name of the bin values array.
		/// Default is "bin_values".
		/// </summary>
		// Token: 0x0601355E RID: 79198 RVA: 0x001B596C File Offset: 0x001B3B6C
		public virtual string GetBinValuesArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkExtractHistogram.vtkExtractHistogram_GetBinValuesArrayName_16(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601355F RID: 79199
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExtractHistogram_GetCalculateAverages_17(HandleRef pThis);

		/// <summary>
		/// This option controls whether the algorithm calculates averages
		/// of variables other than the primary variable that fall into each
		/// bin.
		/// Default is false.
		/// </summary>
		// Token: 0x06013560 RID: 79200 RVA: 0x001B59A8 File Offset: 0x001B3BA8
		public virtual bool GetCalculateAverages()
		{
			return vtkExtractHistogram.vtkExtractHistogram_GetCalculateAverages_17(base.GetCppThis()) != 0;
		}

		// Token: 0x06013561 RID: 79201
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExtractHistogram_GetCenterBinsAroundMinAndMax_18(HandleRef pThis);

		/// <summary>
		/// Get/Set if first and last bins must be centered around the min and max
		/// data. This is only used when UseCustomBinRanges is set to false.
		/// Default is false.
		/// </summary>
		// Token: 0x06013562 RID: 79202 RVA: 0x001B59D0 File Offset: 0x001B3BD0
		public virtual bool GetCenterBinsAroundMinAndMax()
		{
			return vtkExtractHistogram.vtkExtractHistogram_GetCenterBinsAroundMinAndMax_18(base.GetCppThis()) != 0;
		}

		// Token: 0x06013563 RID: 79203
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractHistogram_GetComponent_19(HandleRef pThis);

		/// <summary>
		/// Controls which input data component should be binned, for input arrays
		/// with more-than-one component.  Setting this to the number of components
		/// will compute the histogram of the magnitude (L2 norm) of the tuple.
		/// Default is 0.
		/// </summary>
		// Token: 0x06013564 RID: 79204 RVA: 0x001B59F8 File Offset: 0x001B3BF8
		public virtual int GetComponent()
		{
			return vtkExtractHistogram.vtkExtractHistogram_GetComponent_19(base.GetCppThis());
		}

		// Token: 0x06013565 RID: 79205
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractHistogram_GetComponentMaxValue_20(HandleRef pThis);

		/// <summary>
		/// Controls which input data component should be binned, for input arrays
		/// with more-than-one component.  Setting this to the number of components
		/// will compute the histogram of the magnitude (L2 norm) of the tuple.
		/// Default is 0.
		/// </summary>
		// Token: 0x06013566 RID: 79206 RVA: 0x001B5A18 File Offset: 0x001B3C18
		public virtual int GetComponentMaxValue()
		{
			return vtkExtractHistogram.vtkExtractHistogram_GetComponentMaxValue_20(base.GetCppThis());
		}

		// Token: 0x06013567 RID: 79207
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractHistogram_GetComponentMinValue_21(HandleRef pThis);

		/// <summary>
		/// Controls which input data component should be binned, for input arrays
		/// with more-than-one component.  Setting this to the number of components
		/// will compute the histogram of the magnitude (L2 norm) of the tuple.
		/// Default is 0.
		/// </summary>
		// Token: 0x06013568 RID: 79208 RVA: 0x001B5A38 File Offset: 0x001B3C38
		public virtual int GetComponentMinValue()
		{
			return vtkExtractHistogram.vtkExtractHistogram_GetComponentMinValue_21(base.GetCppThis());
		}

		// Token: 0x06013569 RID: 79209
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractHistogram_GetCustomBinRanges_22(HandleRef pThis);

		/// <summary>
		/// Get/Set custom bin range to use. These are used only when
		/// UseCustomBinRanges is set to true.
		/// Default is [0, 100].
		/// </summary>
		// Token: 0x0601356A RID: 79210 RVA: 0x001B5A58 File Offset: 0x001B3C58
		public virtual double[] GetCustomBinRanges()
		{
			IntPtr intPtr = vtkExtractHistogram.vtkExtractHistogram_GetCustomBinRanges_22(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601356B RID: 79211
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram_GetCustomBinRanges_23(HandleRef pThis, ref double _arg1, ref double _arg2);

		/// <summary>
		/// Get/Set custom bin range to use. These are used only when
		/// UseCustomBinRanges is set to true.
		/// Default is [0, 100].
		/// </summary>
		// Token: 0x0601356C RID: 79212 RVA: 0x001B5AA0 File Offset: 0x001B3CA0
		public virtual void GetCustomBinRanges(ref double _arg1, ref double _arg2)
		{
			vtkExtractHistogram.vtkExtractHistogram_GetCustomBinRanges_23(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x0601356D RID: 79213
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram_GetCustomBinRanges_24(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set custom bin range to use. These are used only when
		/// UseCustomBinRanges is set to true.
		/// Default is [0, 100].
		/// </summary>
		// Token: 0x0601356E RID: 79214 RVA: 0x001B5AB1 File Offset: 0x001B3CB1
		public virtual void GetCustomBinRanges(IntPtr _arg)
		{
			vtkExtractHistogram.vtkExtractHistogram_GetCustomBinRanges_24(base.GetCppThis(), _arg);
		}

		// Token: 0x0601356F RID: 79215
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExtractHistogram_GetNormalize_25(HandleRef pThis);

		/// <summary>
		/// If this option is set then the bin values will be normalized so that the sum of the bin values
		/// adds up to 1.0.
		/// Default is false.
		/// </summary>
		// Token: 0x06013570 RID: 79216 RVA: 0x001B5AC4 File Offset: 0x001B3CC4
		public virtual bool GetNormalize()
		{
			return vtkExtractHistogram.vtkExtractHistogram_GetNormalize_25(base.GetCppThis()) != 0;
		}

		// Token: 0x06013571 RID: 79217
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractHistogram_GetNumberOfGenerationsFromBase_26(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013572 RID: 79218 RVA: 0x001B5AEC File Offset: 0x001B3CEC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExtractHistogram.vtkExtractHistogram_GetNumberOfGenerationsFromBase_26(base.GetCppThis(), type);
		}

		// Token: 0x06013573 RID: 79219
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractHistogram_GetNumberOfGenerationsFromBaseType_27([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013574 RID: 79220 RVA: 0x001B5B0C File Offset: 0x001B3D0C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExtractHistogram.vtkExtractHistogram_GetNumberOfGenerationsFromBaseType_27(type);
		}

		// Token: 0x06013575 RID: 79221
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExtractHistogram_GetUseCustomBinRanges_28(HandleRef pThis);

		/// <summary>
		/// When set to true, CustomBinRanges will  be used instead of using the full
		/// range for the selected array.
		/// Default is false.
		/// </summary>
		// Token: 0x06013576 RID: 79222 RVA: 0x001B5B28 File Offset: 0x001B3D28
		public virtual bool GetUseCustomBinRanges()
		{
			return vtkExtractHistogram.vtkExtractHistogram_GetUseCustomBinRanges_28(base.GetCppThis()) != 0;
		}

		// Token: 0x06013577 RID: 79223
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractHistogram_IsA_29(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013578 RID: 79224 RVA: 0x001B5B50 File Offset: 0x001B3D50
		public override int IsA(string type)
		{
			return vtkExtractHistogram.vtkExtractHistogram_IsA_29(base.GetCppThis(), type);
		}

		// Token: 0x06013579 RID: 79225
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractHistogram_IsTypeOf_30([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601357A RID: 79226 RVA: 0x001B5B70 File Offset: 0x001B3D70
		public new static int IsTypeOf(string type)
		{
			return vtkExtractHistogram.vtkExtractHistogram_IsTypeOf_30(type);
		}

		// Token: 0x0601357B RID: 79227
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractHistogram_NewInstance_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601357C RID: 79228 RVA: 0x001B5B8C File Offset: 0x001B3D8C
		public new vtkExtractHistogram NewInstance()
		{
			vtkExtractHistogram result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractHistogram.vtkExtractHistogram_NewInstance_32(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractHistogram)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601357D RID: 79229
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram_NormalizeOff_33(HandleRef pThis);

		/// <summary>
		/// If this option is set then the bin values will be normalized so that the sum of the bin values
		/// adds up to 1.0.
		/// Default is false.
		/// </summary>
		// Token: 0x0601357E RID: 79230 RVA: 0x001B5BE6 File Offset: 0x001B3DE6
		public virtual void NormalizeOff()
		{
			vtkExtractHistogram.vtkExtractHistogram_NormalizeOff_33(base.GetCppThis());
		}

		// Token: 0x0601357F RID: 79231
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram_NormalizeOn_34(HandleRef pThis);

		/// <summary>
		/// If this option is set then the bin values will be normalized so that the sum of the bin values
		/// adds up to 1.0.
		/// Default is false.
		/// </summary>
		// Token: 0x06013580 RID: 79232 RVA: 0x001B5BF5 File Offset: 0x001B3DF5
		public virtual void NormalizeOn()
		{
			vtkExtractHistogram.vtkExtractHistogram_NormalizeOn_34(base.GetCppThis());
		}

		// Token: 0x06013581 RID: 79233
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractHistogram_SafeDownCast_35(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013582 RID: 79234 RVA: 0x001B5C04 File Offset: 0x001B3E04
		public new static vtkExtractHistogram SafeDownCast(vtkObjectBase o)
		{
			vtkExtractHistogram vtkExtractHistogram = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractHistogram.vtkExtractHistogram_SafeDownCast_35((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractHistogram = (vtkExtractHistogram)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractHistogram.Register(null);
				}
			}
			return vtkExtractHistogram;
		}

		// Token: 0x06013583 RID: 79235
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram_SetAccumulation_36(HandleRef pThis, byte _arg);

		/// <summary>
		/// If this option is set to true then the output table will contain an additional column with
		/// accumulated bin values.
		/// Default is false.
		/// </summary>
		// Token: 0x06013584 RID: 79236 RVA: 0x001B5C83 File Offset: 0x001B3E83
		public virtual void SetAccumulation(bool _arg)
		{
			vtkExtractHistogram.vtkExtractHistogram_SetAccumulation_36(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06013585 RID: 79237
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram_SetBinAccumulationArrayName_37(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the name of the optional bin accumulation array.
		/// Default is "bin_accumulation".
		/// </summary>
		// Token: 0x06013586 RID: 79238 RVA: 0x001B5C9B File Offset: 0x001B3E9B
		public virtual void SetBinAccumulationArrayName(string _arg)
		{
			vtkExtractHistogram.vtkExtractHistogram_SetBinAccumulationArrayName_37(base.GetCppThis(), _arg);
		}

		// Token: 0x06013587 RID: 79239
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram_SetBinCount_38(HandleRef pThis, int _arg);

		/// <summary>
		/// Controls the number of bins N in the output histogram data.
		/// Default is 10.
		/// </summary>
		// Token: 0x06013588 RID: 79240 RVA: 0x001B5CAB File Offset: 0x001B3EAB
		public virtual void SetBinCount(int _arg)
		{
			vtkExtractHistogram.vtkExtractHistogram_SetBinCount_38(base.GetCppThis(), _arg);
		}

		// Token: 0x06013589 RID: 79241
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram_SetBinExtentsArrayName_39(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the name of the bin extents array.
		/// Default is "bin_extents".
		/// </summary>
		// Token: 0x0601358A RID: 79242 RVA: 0x001B5CBB File Offset: 0x001B3EBB
		public virtual void SetBinExtentsArrayName(string _arg)
		{
			vtkExtractHistogram.vtkExtractHistogram_SetBinExtentsArrayName_39(base.GetCppThis(), _arg);
		}

		// Token: 0x0601358B RID: 79243
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram_SetBinValuesArrayName_40(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the name of the bin values array.
		/// Default is "bin_values".
		/// </summary>
		// Token: 0x0601358C RID: 79244 RVA: 0x001B5CCB File Offset: 0x001B3ECB
		public virtual void SetBinValuesArrayName(string _arg)
		{
			vtkExtractHistogram.vtkExtractHistogram_SetBinValuesArrayName_40(base.GetCppThis(), _arg);
		}

		// Token: 0x0601358D RID: 79245
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram_SetCalculateAverages_41(HandleRef pThis, byte _arg);

		/// <summary>
		/// This option controls whether the algorithm calculates averages
		/// of variables other than the primary variable that fall into each
		/// bin.
		/// Default is false.
		/// </summary>
		// Token: 0x0601358E RID: 79246 RVA: 0x001B5CDB File Offset: 0x001B3EDB
		public virtual void SetCalculateAverages(bool _arg)
		{
			vtkExtractHistogram.vtkExtractHistogram_SetCalculateAverages_41(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0601358F RID: 79247
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram_SetCenterBinsAroundMinAndMax_42(HandleRef pThis, byte _arg);

		/// <summary>
		/// Get/Set if first and last bins must be centered around the min and max
		/// data. This is only used when UseCustomBinRanges is set to false.
		/// Default is false.
		/// </summary>
		// Token: 0x06013590 RID: 79248 RVA: 0x001B5CF3 File Offset: 0x001B3EF3
		public virtual void SetCenterBinsAroundMinAndMax(bool _arg)
		{
			vtkExtractHistogram.vtkExtractHistogram_SetCenterBinsAroundMinAndMax_42(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06013591 RID: 79249
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram_SetComponent_43(HandleRef pThis, int _arg);

		/// <summary>
		/// Controls which input data component should be binned, for input arrays
		/// with more-than-one component.  Setting this to the number of components
		/// will compute the histogram of the magnitude (L2 norm) of the tuple.
		/// Default is 0.
		/// </summary>
		// Token: 0x06013592 RID: 79250 RVA: 0x001B5D0B File Offset: 0x001B3F0B
		public virtual void SetComponent(int _arg)
		{
			vtkExtractHistogram.vtkExtractHistogram_SetComponent_43(base.GetCppThis(), _arg);
		}

		// Token: 0x06013593 RID: 79251
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram_SetCustomBinRanges_44(HandleRef pThis, double _arg1, double _arg2);

		/// <summary>
		/// Get/Set custom bin range to use. These are used only when
		/// UseCustomBinRanges is set to true.
		/// Default is [0, 100].
		/// </summary>
		// Token: 0x06013594 RID: 79252 RVA: 0x001B5D1B File Offset: 0x001B3F1B
		public virtual void SetCustomBinRanges(double _arg1, double _arg2)
		{
			vtkExtractHistogram.vtkExtractHistogram_SetCustomBinRanges_44(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x06013595 RID: 79253
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram_SetCustomBinRanges_45(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set custom bin range to use. These are used only when
		/// UseCustomBinRanges is set to true.
		/// Default is [0, 100].
		/// </summary>
		// Token: 0x06013596 RID: 79254 RVA: 0x001B5D2C File Offset: 0x001B3F2C
		public void SetCustomBinRanges(IntPtr _arg)
		{
			vtkExtractHistogram.vtkExtractHistogram_SetCustomBinRanges_45(base.GetCppThis(), _arg);
		}

		// Token: 0x06013597 RID: 79255
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram_SetNormalize_46(HandleRef pThis, byte _arg);

		/// <summary>
		/// If this option is set then the bin values will be normalized so that the sum of the bin values
		/// adds up to 1.0.
		/// Default is false.
		/// </summary>
		// Token: 0x06013598 RID: 79256 RVA: 0x001B5D3C File Offset: 0x001B3F3C
		public virtual void SetNormalize(bool _arg)
		{
			vtkExtractHistogram.vtkExtractHistogram_SetNormalize_46(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06013599 RID: 79257
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram_SetUseCustomBinRanges_47(HandleRef pThis, byte _arg);

		/// <summary>
		/// When set to true, CustomBinRanges will  be used instead of using the full
		/// range for the selected array.
		/// Default is false.
		/// </summary>
		// Token: 0x0601359A RID: 79258 RVA: 0x001B5D54 File Offset: 0x001B3F54
		public virtual void SetUseCustomBinRanges(bool _arg)
		{
			vtkExtractHistogram.vtkExtractHistogram_SetUseCustomBinRanges_47(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0601359B RID: 79259
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram_UseCustomBinRangesOff_48(HandleRef pThis);

		/// <summary>
		/// When set to true, CustomBinRanges will  be used instead of using the full
		/// range for the selected array.
		/// Default is false.
		/// </summary>
		// Token: 0x0601359C RID: 79260 RVA: 0x001B5D6C File Offset: 0x001B3F6C
		public virtual void UseCustomBinRangesOff()
		{
			vtkExtractHistogram.vtkExtractHistogram_UseCustomBinRangesOff_48(base.GetCppThis());
		}

		// Token: 0x0601359D RID: 79261
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram_UseCustomBinRangesOn_49(HandleRef pThis);

		/// <summary>
		/// When set to true, CustomBinRanges will  be used instead of using the full
		/// range for the selected array.
		/// Default is false.
		/// </summary>
		// Token: 0x0601359E RID: 79262 RVA: 0x001B5D7B File Offset: 0x001B3F7B
		public virtual void UseCustomBinRangesOn()
		{
			vtkExtractHistogram.vtkExtractHistogram_UseCustomBinRangesOn_49(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001658 RID: 5720
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractHistogram";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001659 RID: 5721
		public new static readonly string MRClassNameKey = "class vtkExtractHistogram";
	}
}
