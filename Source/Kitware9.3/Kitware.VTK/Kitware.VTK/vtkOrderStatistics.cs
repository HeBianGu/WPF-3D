using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOrderStatistics
	/// </summary>
	/// <remarks>
	///    A class for univariate order statistics
	///
	///
	/// Given a selection of columns of interest in an input data table, this
	/// class provides the following functionalities, depending on the
	/// execution mode it is executed in:
	/// * Learn: calculate histogram.
	/// * Derive: calculate PDFs and arbitrary quantiles. Provide specific names when 5-point
	///   statistics (minimum, 1st quartile, median, third quartile, maximum) requested.
	/// * Assess: given an input data set and a set of q-quantiles, label each datum
	///   either with the quantile interval to which it belongs, or 0 if it is smaller
	///   than smaller quantile, or q if it is larger than largest quantile.
	/// * Test: calculate Kolmogorov-Smirnov goodness-of-fit statistic between CDF based on
	///   model quantiles, and empirical CDF
	///
	/// @par Thanks:
	/// Thanks to Philippe Pebay and David Thompson from Sandia National Laboratories
	/// for implementing this class.
	/// Updated by Philippe Pebay, Kitware SAS 2012
	/// </remarks>
	// Token: 0x0200074B RID: 1867
	public class vtkOrderStatistics : vtkStatisticsAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06013669 RID: 79465 RVA: 0x001B72C7 File Offset: 0x001B54C7
		static vtkOrderStatistics()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOrderStatistics.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOrderStatistics"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601366A RID: 79466 RVA: 0x001B72EF File Offset: 0x001B54EF
		public vtkOrderStatistics(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601366B RID: 79467
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrderStatistics_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601366C RID: 79468 RVA: 0x001B7300 File Offset: 0x001B5500
		public new static vtkOrderStatistics New()
		{
			vtkOrderStatistics result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOrderStatistics.vtkOrderStatistics_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOrderStatistics)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601366D RID: 79469 RVA: 0x001B7354 File Offset: 0x001B5554
		public vtkOrderStatistics() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOrderStatistics.vtkOrderStatistics_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601366E RID: 79470 RVA: 0x001B7398 File Offset: 0x001B5598
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601366F RID: 79471
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrderStatistics_Aggregate_01(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		/// <summary>
		/// Given a collection of models, calculate aggregate model
		/// NB: not implemented
		/// </summary>
		// Token: 0x06013670 RID: 79472 RVA: 0x001B73A4 File Offset: 0x001B55A4
		public override void Aggregate(vtkDataObjectCollection arg0, vtkMultiBlockDataSet arg1)
		{
			vtkOrderStatistics.vtkOrderStatistics_Aggregate_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x06013671 RID: 79473
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOrderStatistics_GetGhostsToSkip_02(HandleRef pThis);

		/// <summary>
		/// If there is a ghost array in the input, then ghosts matching `GhostsToSkip` mask
		/// will be skipped. It is set to 0xff by default (every ghosts types are skipped).
		///
		/// @sa
		/// vtkDataSetAttributes
		/// vtkFieldData
		/// vtkPointData
		/// vtkCellData
		/// </summary>
		// Token: 0x06013672 RID: 79474 RVA: 0x001B73E8 File Offset: 0x001B55E8
		public virtual byte GetGhostsToSkip()
		{
			return vtkOrderStatistics.vtkOrderStatistics_GetGhostsToSkip_02(base.GetCppThis());
		}

		// Token: 0x06013673 RID: 79475
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOrderStatistics_GetMaximumHistogramSize_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum histogram size.
		/// This maximum size is enforced only when Quantize is TRUE.
		/// </summary>
		// Token: 0x06013674 RID: 79476 RVA: 0x001B7408 File Offset: 0x001B5608
		public virtual long GetMaximumHistogramSize()
		{
			return vtkOrderStatistics.vtkOrderStatistics_GetMaximumHistogramSize_03(base.GetCppThis());
		}

		// Token: 0x06013675 RID: 79477
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOrderStatistics_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013676 RID: 79478 RVA: 0x001B7428 File Offset: 0x001B5628
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOrderStatistics.vtkOrderStatistics_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06013677 RID: 79479
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOrderStatistics_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013678 RID: 79480 RVA: 0x001B7448 File Offset: 0x001B5648
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOrderStatistics.vtkOrderStatistics_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06013679 RID: 79481
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOrderStatistics_GetNumberOfIntervals_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of quantiles (with uniform spacing).
		/// </summary>
		// Token: 0x0601367A RID: 79482 RVA: 0x001B7464 File Offset: 0x001B5664
		public virtual long GetNumberOfIntervals()
		{
			return vtkOrderStatistics.vtkOrderStatistics_GetNumberOfIntervals_06(base.GetCppThis());
		}

		// Token: 0x0601367B RID: 79483
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOrderStatistics_GetQuantileDefinition_07(HandleRef pThis);

		/// <summary>
		/// Get the quantile definition.
		/// </summary>
		// Token: 0x0601367C RID: 79484 RVA: 0x001B7484 File Offset: 0x001B5684
		public long GetQuantileDefinition()
		{
			return vtkOrderStatistics.vtkOrderStatistics_GetQuantileDefinition_07(base.GetCppThis());
		}

		// Token: 0x0601367D RID: 79485
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOrderStatistics_GetQuantize_08(HandleRef pThis);

		/// <summary>
		/// Set/Get whether quantization will be allowed to enforce maximum histogram size.
		/// </summary>
		// Token: 0x0601367E RID: 79486 RVA: 0x001B74A4 File Offset: 0x001B56A4
		public virtual bool GetQuantize()
		{
			return vtkOrderStatistics.vtkOrderStatistics_GetQuantize_08(base.GetCppThis()) != 0;
		}

		// Token: 0x0601367F RID: 79487
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOrderStatistics_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013680 RID: 79488 RVA: 0x001B74CC File Offset: 0x001B56CC
		public override int IsA(string type)
		{
			return vtkOrderStatistics.vtkOrderStatistics_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x06013681 RID: 79489
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOrderStatistics_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013682 RID: 79490 RVA: 0x001B74EC File Offset: 0x001B56EC
		public new static int IsTypeOf(string type)
		{
			return vtkOrderStatistics.vtkOrderStatistics_IsTypeOf_10(type);
		}

		// Token: 0x06013683 RID: 79491
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrderStatistics_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013684 RID: 79492 RVA: 0x001B7508 File Offset: 0x001B5708
		public new vtkOrderStatistics NewInstance()
		{
			vtkOrderStatistics result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOrderStatistics.vtkOrderStatistics_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOrderStatistics)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06013685 RID: 79493
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrderStatistics_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013686 RID: 79494 RVA: 0x001B7564 File Offset: 0x001B5764
		public new static vtkOrderStatistics SafeDownCast(vtkObjectBase o)
		{
			vtkOrderStatistics vtkOrderStatistics = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOrderStatistics.vtkOrderStatistics_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOrderStatistics = (vtkOrderStatistics)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOrderStatistics.Register(null);
				}
			}
			return vtkOrderStatistics;
		}

		// Token: 0x06013687 RID: 79495
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrderStatistics_SetGhostsToSkip_14(HandleRef pThis, byte _arg);

		/// <summary>
		/// If there is a ghost array in the input, then ghosts matching `GhostsToSkip` mask
		/// will be skipped. It is set to 0xff by default (every ghosts types are skipped).
		///
		/// @sa
		/// vtkDataSetAttributes
		/// vtkFieldData
		/// vtkPointData
		/// vtkCellData
		/// </summary>
		// Token: 0x06013688 RID: 79496 RVA: 0x001B75E3 File Offset: 0x001B57E3
		public virtual void SetGhostsToSkip(byte _arg)
		{
			vtkOrderStatistics.vtkOrderStatistics_SetGhostsToSkip_14(base.GetCppThis(), _arg);
		}

		// Token: 0x06013689 RID: 79497
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrderStatistics_SetMaximumHistogramSize_15(HandleRef pThis, long _arg);

		/// <summary>
		/// Set/Get the maximum histogram size.
		/// This maximum size is enforced only when Quantize is TRUE.
		/// </summary>
		// Token: 0x0601368A RID: 79498 RVA: 0x001B75F3 File Offset: 0x001B57F3
		public virtual void SetMaximumHistogramSize(long _arg)
		{
			vtkOrderStatistics.vtkOrderStatistics_SetMaximumHistogramSize_15(base.GetCppThis(), _arg);
		}

		// Token: 0x0601368B RID: 79499
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrderStatistics_SetNumberOfIntervals_16(HandleRef pThis, long _arg);

		/// <summary>
		/// Set/Get the number of quantiles (with uniform spacing).
		/// </summary>
		// Token: 0x0601368C RID: 79500 RVA: 0x001B7603 File Offset: 0x001B5803
		public virtual void SetNumberOfIntervals(long _arg)
		{
			vtkOrderStatistics.vtkOrderStatistics_SetNumberOfIntervals_16(base.GetCppThis(), _arg);
		}

		// Token: 0x0601368D RID: 79501
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOrderStatistics_SetParameter_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string parameter, int index, HandleRef value);

		/// <summary>
		/// A convenience method (in particular for access from other applications) to
		/// set parameter values.
		/// Return true if setting of requested parameter name was executed, false otherwise.
		/// </summary>
		// Token: 0x0601368E RID: 79502 RVA: 0x001B7614 File Offset: 0x001B5814
		public override bool SetParameter(string parameter, int index, vtkVariant value)
		{
			return vtkOrderStatistics.vtkOrderStatistics_SetParameter_17(base.GetCppThis(), parameter, index, (value == null) ? default(HandleRef) : value.GetCppThis()) != 0;
		}

		// Token: 0x0601368F RID: 79503
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrderStatistics_SetQuantileDefinition_18(HandleRef pThis, vtkOrderStatistics.QuantileDefinitionType _arg);

		/// <summary>
		/// Set the quantile definition.
		/// </summary>
		// Token: 0x06013690 RID: 79504 RVA: 0x001B7651 File Offset: 0x001B5851
		public virtual void SetQuantileDefinition(vtkOrderStatistics.QuantileDefinitionType _arg)
		{
			vtkOrderStatistics.vtkOrderStatistics_SetQuantileDefinition_18(base.GetCppThis(), _arg);
		}

		// Token: 0x06013691 RID: 79505
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrderStatistics_SetQuantileDefinition_19(HandleRef pThis, int arg0);

		/// <summary>
		/// Set the quantile definition.
		/// </summary>
		// Token: 0x06013692 RID: 79506 RVA: 0x001B7661 File Offset: 0x001B5861
		public void SetQuantileDefinition(int arg0)
		{
			vtkOrderStatistics.vtkOrderStatistics_SetQuantileDefinition_19(base.GetCppThis(), arg0);
		}

		// Token: 0x06013693 RID: 79507
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrderStatistics_SetQuantize_20(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get whether quantization will be allowed to enforce maximum histogram size.
		/// </summary>
		// Token: 0x06013694 RID: 79508 RVA: 0x001B7671 File Offset: 0x001B5871
		public virtual void SetQuantize(bool _arg)
		{
			vtkOrderStatistics.vtkOrderStatistics_SetQuantize_20(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001666 RID: 5734
		public new const string MRFullTypeName = "Kitware.VTK.vtkOrderStatistics";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001667 RID: 5735
		public new static readonly string MRClassNameKey = "class vtkOrderStatistics";

		/// <summary>
		/// The type of quantile definition.
		/// </summary>
		// Token: 0x0200074C RID: 1868
		public enum QuantileDefinitionType
		{
			/// <summary>enum member</summary>
			// Token: 0x04001669 RID: 5737
			InverseCDF,
			/// <summary>enum member</summary>
			// Token: 0x0400166A RID: 5738
			InverseCDFAveragedSteps,
			/// <summary>enum member</summary>
			// Token: 0x0400166B RID: 5739
			NearestObservation
		}
	}
}
