using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTemporalStatistics
	/// </summary>
	/// <remarks>
	///    Compute statistics of point or cell data as it changes over time
	///
	///
	///
	/// Given an input that changes over time, vtkTemporalStatistics looks at the
	/// data for each time step and computes some statistical information of how a
	/// point or cell variable changes over time.  For example, vtkTemporalStatistics
	/// can compute the average value of "pressure" over time of each point.
	///
	/// If the key `vtkStreamingDemandDrivenPipeline::NO_PRIOR_TEMPORAL_ACCESS()` is set, typically
	/// when running this filter in situ,
	/// then the filter runs the time steps one at a time. It requires causing the execution
	/// of the filter multiple times externally, by calling `UpdateTimeStep()` in a loop
	/// or using another filter that iterates over time downstream, for example.
	/// When the key is not set, the filter will execute itself by setting the key
	/// `vtkStreamingDemandDrivenPipeline::CONTINUE_EXECUTING()`.
	///
	/// This filter will produce an array called `"time_steps"` in the output's `FieldData`.
	/// It contains all the time steps ahta have been processed so far.
	///
	/// vtkTemporalStatistics ignores the temporal spacing.  Each timestep will be
	/// weighted the same regardless of how long of an interval it is to the next
	/// timestep.  Thus, the average statistic may be quite different from an
	/// integration of the variable if the time spacing varies.
	///
	/// @par Thanks:
	/// </remarks>
	/// <seealso>
	/// This class was originally written by Kenneth Moreland (kmorelndia.gov)
	/// from Sandia National Laboratories.
	///
	/// </seealso>
	// Token: 0x020008F0 RID: 2288
	public class vtkTemporalStatistics : vtkPassInputTypeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06017A2D RID: 96813 RVA: 0x002124DB File Offset: 0x002106DB
		static vtkTemporalStatistics()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTemporalStatistics.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTemporalStatistics"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06017A2E RID: 96814 RVA: 0x00212503 File Offset: 0x00210703
		public vtkTemporalStatistics(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06017A2F RID: 96815
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTemporalStatistics_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06017A30 RID: 96816 RVA: 0x00212514 File Offset: 0x00210714
		public new static vtkTemporalStatistics New()
		{
			vtkTemporalStatistics result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTemporalStatistics.vtkTemporalStatistics_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTemporalStatistics)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06017A31 RID: 96817 RVA: 0x00212568 File Offset: 0x00210768
		public vtkTemporalStatistics() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTemporalStatistics.vtkTemporalStatistics_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06017A32 RID: 96818 RVA: 0x002125AC File Offset: 0x002107AC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06017A33 RID: 96819
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalStatistics_ComputeAverageOff_01(HandleRef pThis);

		/// <summary>
		/// Turn on/off the computation of the average values over time.  On by
		/// default.  The resulting array names have "_average" appended to them.
		/// </summary>
		// Token: 0x06017A34 RID: 96820 RVA: 0x002125B7 File Offset: 0x002107B7
		public virtual void ComputeAverageOff()
		{
			vtkTemporalStatistics.vtkTemporalStatistics_ComputeAverageOff_01(base.GetCppThis());
		}

		// Token: 0x06017A35 RID: 96821
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalStatistics_ComputeAverageOn_02(HandleRef pThis);

		/// <summary>
		/// Turn on/off the computation of the average values over time.  On by
		/// default.  The resulting array names have "_average" appended to them.
		/// </summary>
		// Token: 0x06017A36 RID: 96822 RVA: 0x002125C6 File Offset: 0x002107C6
		public virtual void ComputeAverageOn()
		{
			vtkTemporalStatistics.vtkTemporalStatistics_ComputeAverageOn_02(base.GetCppThis());
		}

		// Token: 0x06017A37 RID: 96823
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalStatistics_ComputeMaximumOff_03(HandleRef pThis);

		/// <summary>
		/// Turn on/off the computation of the maximum values over time.  On by
		/// default.  The resulting array names have "_maximum" appended to them.
		/// </summary>
		// Token: 0x06017A38 RID: 96824 RVA: 0x002125D5 File Offset: 0x002107D5
		public virtual void ComputeMaximumOff()
		{
			vtkTemporalStatistics.vtkTemporalStatistics_ComputeMaximumOff_03(base.GetCppThis());
		}

		// Token: 0x06017A39 RID: 96825
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalStatistics_ComputeMaximumOn_04(HandleRef pThis);

		/// <summary>
		/// Turn on/off the computation of the maximum values over time.  On by
		/// default.  The resulting array names have "_maximum" appended to them.
		/// </summary>
		// Token: 0x06017A3A RID: 96826 RVA: 0x002125E4 File Offset: 0x002107E4
		public virtual void ComputeMaximumOn()
		{
			vtkTemporalStatistics.vtkTemporalStatistics_ComputeMaximumOn_04(base.GetCppThis());
		}

		// Token: 0x06017A3B RID: 96827
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalStatistics_ComputeMinimumOff_05(HandleRef pThis);

		/// <summary>
		/// Turn on/off the computation of the minimum values over time.  On by
		/// default.  The resulting array names have "_minimum" appended to them.
		/// </summary>
		// Token: 0x06017A3C RID: 96828 RVA: 0x002125F3 File Offset: 0x002107F3
		public virtual void ComputeMinimumOff()
		{
			vtkTemporalStatistics.vtkTemporalStatistics_ComputeMinimumOff_05(base.GetCppThis());
		}

		// Token: 0x06017A3D RID: 96829
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalStatistics_ComputeMinimumOn_06(HandleRef pThis);

		/// <summary>
		/// Turn on/off the computation of the minimum values over time.  On by
		/// default.  The resulting array names have "_minimum" appended to them.
		/// </summary>
		// Token: 0x06017A3E RID: 96830 RVA: 0x00212602 File Offset: 0x00210802
		public virtual void ComputeMinimumOn()
		{
			vtkTemporalStatistics.vtkTemporalStatistics_ComputeMinimumOn_06(base.GetCppThis());
		}

		// Token: 0x06017A3F RID: 96831
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalStatistics_ComputeStandardDeviationOff_07(HandleRef pThis);

		/// <summary>
		/// Turn on/off the computation of the standard deviation of the values over
		/// time.  On by default.  The resulting array names have "_stddev" appended to
		/// them.
		/// </summary>
		// Token: 0x06017A40 RID: 96832 RVA: 0x00212611 File Offset: 0x00210811
		public virtual void ComputeStandardDeviationOff()
		{
			vtkTemporalStatistics.vtkTemporalStatistics_ComputeStandardDeviationOff_07(base.GetCppThis());
		}

		// Token: 0x06017A41 RID: 96833
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalStatistics_ComputeStandardDeviationOn_08(HandleRef pThis);

		/// <summary>
		/// Turn on/off the computation of the standard deviation of the values over
		/// time.  On by default.  The resulting array names have "_stddev" appended to
		/// them.
		/// </summary>
		// Token: 0x06017A42 RID: 96834 RVA: 0x00212620 File Offset: 0x00210820
		public virtual void ComputeStandardDeviationOn()
		{
			vtkTemporalStatistics.vtkTemporalStatistics_ComputeStandardDeviationOn_08(base.GetCppThis());
		}

		// Token: 0x06017A43 RID: 96835
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTemporalStatistics_GetComputeAverage_09(HandleRef pThis);

		/// <summary>
		/// Turn on/off the computation of the average values over time.  On by
		/// default.  The resulting array names have "_average" appended to them.
		/// </summary>
		// Token: 0x06017A44 RID: 96836 RVA: 0x00212630 File Offset: 0x00210830
		public virtual int GetComputeAverage()
		{
			return vtkTemporalStatistics.vtkTemporalStatistics_GetComputeAverage_09(base.GetCppThis());
		}

		// Token: 0x06017A45 RID: 96837
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTemporalStatistics_GetComputeMaximum_10(HandleRef pThis);

		/// <summary>
		/// Turn on/off the computation of the maximum values over time.  On by
		/// default.  The resulting array names have "_maximum" appended to them.
		/// </summary>
		// Token: 0x06017A46 RID: 96838 RVA: 0x00212650 File Offset: 0x00210850
		public virtual int GetComputeMaximum()
		{
			return vtkTemporalStatistics.vtkTemporalStatistics_GetComputeMaximum_10(base.GetCppThis());
		}

		// Token: 0x06017A47 RID: 96839
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTemporalStatistics_GetComputeMinimum_11(HandleRef pThis);

		/// <summary>
		/// Turn on/off the computation of the minimum values over time.  On by
		/// default.  The resulting array names have "_minimum" appended to them.
		/// </summary>
		// Token: 0x06017A48 RID: 96840 RVA: 0x00212670 File Offset: 0x00210870
		public virtual int GetComputeMinimum()
		{
			return vtkTemporalStatistics.vtkTemporalStatistics_GetComputeMinimum_11(base.GetCppThis());
		}

		// Token: 0x06017A49 RID: 96841
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTemporalStatistics_GetComputeStandardDeviation_12(HandleRef pThis);

		/// <summary>
		/// Turn on/off the computation of the standard deviation of the values over
		/// time.  On by default.  The resulting array names have "_stddev" appended to
		/// them.
		/// </summary>
		// Token: 0x06017A4A RID: 96842 RVA: 0x00212690 File Offset: 0x00210890
		public virtual int GetComputeStandardDeviation()
		{
			return vtkTemporalStatistics.vtkTemporalStatistics_GetComputeStandardDeviation_12(base.GetCppThis());
		}

		// Token: 0x06017A4B RID: 96843
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTemporalStatistics_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06017A4C RID: 96844 RVA: 0x002126B0 File Offset: 0x002108B0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTemporalStatistics.vtkTemporalStatistics_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x06017A4D RID: 96845
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTemporalStatistics_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06017A4E RID: 96846 RVA: 0x002126D0 File Offset: 0x002108D0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTemporalStatistics.vtkTemporalStatistics_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x06017A4F RID: 96847
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTemporalStatistics_IsA_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06017A50 RID: 96848 RVA: 0x002126EC File Offset: 0x002108EC
		public override int IsA(string type)
		{
			return vtkTemporalStatistics.vtkTemporalStatistics_IsA_15(base.GetCppThis(), type);
		}

		// Token: 0x06017A51 RID: 96849
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTemporalStatistics_IsTypeOf_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06017A52 RID: 96850 RVA: 0x0021270C File Offset: 0x0021090C
		public new static int IsTypeOf(string type)
		{
			return vtkTemporalStatistics.vtkTemporalStatistics_IsTypeOf_16(type);
		}

		// Token: 0x06017A53 RID: 96851
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTemporalStatistics_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06017A54 RID: 96852 RVA: 0x00212728 File Offset: 0x00210928
		public new vtkTemporalStatistics NewInstance()
		{
			vtkTemporalStatistics result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTemporalStatistics.vtkTemporalStatistics_NewInstance_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTemporalStatistics)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06017A55 RID: 96853
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTemporalStatistics_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06017A56 RID: 96854 RVA: 0x00212784 File Offset: 0x00210984
		public new static vtkTemporalStatistics SafeDownCast(vtkObjectBase o)
		{
			vtkTemporalStatistics vtkTemporalStatistics = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTemporalStatistics.vtkTemporalStatistics_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTemporalStatistics = (vtkTemporalStatistics)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTemporalStatistics.Register(null);
				}
			}
			return vtkTemporalStatistics;
		}

		// Token: 0x06017A57 RID: 96855
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalStatistics_SetComputeAverage_20(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the computation of the average values over time.  On by
		/// default.  The resulting array names have "_average" appended to them.
		/// </summary>
		// Token: 0x06017A58 RID: 96856 RVA: 0x00212803 File Offset: 0x00210A03
		public virtual void SetComputeAverage(int _arg)
		{
			vtkTemporalStatistics.vtkTemporalStatistics_SetComputeAverage_20(base.GetCppThis(), _arg);
		}

		// Token: 0x06017A59 RID: 96857
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalStatistics_SetComputeMaximum_21(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the computation of the maximum values over time.  On by
		/// default.  The resulting array names have "_maximum" appended to them.
		/// </summary>
		// Token: 0x06017A5A RID: 96858 RVA: 0x00212813 File Offset: 0x00210A13
		public virtual void SetComputeMaximum(int _arg)
		{
			vtkTemporalStatistics.vtkTemporalStatistics_SetComputeMaximum_21(base.GetCppThis(), _arg);
		}

		// Token: 0x06017A5B RID: 96859
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalStatistics_SetComputeMinimum_22(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the computation of the minimum values over time.  On by
		/// default.  The resulting array names have "_minimum" appended to them.
		/// </summary>
		// Token: 0x06017A5C RID: 96860 RVA: 0x00212823 File Offset: 0x00210A23
		public virtual void SetComputeMinimum(int _arg)
		{
			vtkTemporalStatistics.vtkTemporalStatistics_SetComputeMinimum_22(base.GetCppThis(), _arg);
		}

		// Token: 0x06017A5D RID: 96861
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalStatistics_SetComputeStandardDeviation_23(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the computation of the standard deviation of the values over
		/// time.  On by default.  The resulting array names have "_stddev" appended to
		/// them.
		/// </summary>
		// Token: 0x06017A5E RID: 96862 RVA: 0x00212833 File Offset: 0x00210A33
		public virtual void SetComputeStandardDeviation(int _arg)
		{
			vtkTemporalStatistics.vtkTemporalStatistics_SetComputeStandardDeviation_23(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A5F RID: 6751
		public new const string MRFullTypeName = "Kitware.VTK.vtkTemporalStatistics";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A60 RID: 6752
		public new static readonly string MRClassNameKey = "class vtkTemporalStatistics";
	}
}
