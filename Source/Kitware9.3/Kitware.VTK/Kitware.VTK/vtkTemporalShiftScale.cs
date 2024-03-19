using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTemporalShiftScale
	/// </summary>
	/// <remarks>
	///    modify the time range/steps of temporal data
	///
	/// vtkTemporalShiftScale  modify the time range or time steps of
	/// the data without changing the data itself. The data is not resampled
	/// by this filter, only the information accompanying the data is modified.
	///
	/// @par Thanks:
	/// Ken Martin (Kitware) and John Bidiscombe of
	/// CSCS - Swiss National Supercomputing Centre
	/// for creating and contributing this class.
	/// For related material, please refer to :
	/// John Biddiscombe, Berk Geveci, Ken Martin, Kenneth Moreland, David Thompson,
	/// "Time Dependent Processing in a Parallel Pipeline Architecture",
	/// IEEE Visualization 2007.
	/// </remarks>
	// Token: 0x0200061B RID: 1563
	public class vtkTemporalShiftScale : vtkAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06010F86 RID: 69510 RVA: 0x0017A3ED File Offset: 0x001785ED
		static vtkTemporalShiftScale()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTemporalShiftScale.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTemporalShiftScale"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06010F87 RID: 69511 RVA: 0x0017A415 File Offset: 0x00178615
		public vtkTemporalShiftScale(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06010F88 RID: 69512
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTemporalShiftScale_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010F89 RID: 69513 RVA: 0x0017A424 File Offset: 0x00178624
		public new static vtkTemporalShiftScale New()
		{
			vtkTemporalShiftScale result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTemporalShiftScale.vtkTemporalShiftScale_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTemporalShiftScale)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010F8A RID: 69514 RVA: 0x0017A478 File Offset: 0x00178678
		public vtkTemporalShiftScale() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTemporalShiftScale.vtkTemporalShiftScale_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010F8B RID: 69515 RVA: 0x0017A4BC File Offset: 0x001786BC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06010F8C RID: 69516
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTemporalShiftScale_GetMaximumNumberOfPeriods_01(HandleRef pThis);

		/// <summary>
		/// if Periodic time is enabled, this controls how many time periods time is reported
		/// for. A filter cannot output an infinite number of time steps and therefore a finite
		/// number of periods is generated when reporting time.
		/// </summary>
		// Token: 0x06010F8D RID: 69517 RVA: 0x0017A4C8 File Offset: 0x001786C8
		public virtual double GetMaximumNumberOfPeriods()
		{
			return vtkTemporalShiftScale.vtkTemporalShiftScale_GetMaximumNumberOfPeriods_01(base.GetCppThis());
		}

		// Token: 0x06010F8E RID: 69518
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTemporalShiftScale_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010F8F RID: 69519 RVA: 0x0017A4E8 File Offset: 0x001786E8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTemporalShiftScale.vtkTemporalShiftScale_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06010F90 RID: 69520
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTemporalShiftScale_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010F91 RID: 69521 RVA: 0x0017A508 File Offset: 0x00178708
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTemporalShiftScale.vtkTemporalShiftScale_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06010F92 RID: 69522
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTemporalShiftScale_GetPeriodic_04(HandleRef pThis);

		/// <summary>
		/// If Periodic is true, requests for time will be wrapped around so that
		/// the source appears to be a periodic time source. If data exists for times
		/// {0,N-1}, setting periodic to true will cause time 0 to be produced when time
		/// N, 2N, 2N etc is requested. This effectively gives the source the ability to
		/// generate time data indefinitely in a loop.
		/// When combined with Shift/Scale, the time becomes periodic in the
		/// shifted and scaled time frame of reference.
		/// Note: Since the input time may not start at zero, the wrapping of time
		/// from the end of one period to the start of the next, will subtract the
		/// initial time - a source with T{5..6} repeated periodically will have output
		/// time {5..6..7..8} etc.
		/// </summary>
		// Token: 0x06010F93 RID: 69523 RVA: 0x0017A524 File Offset: 0x00178724
		public virtual int GetPeriodic()
		{
			return vtkTemporalShiftScale.vtkTemporalShiftScale_GetPeriodic_04(base.GetCppThis());
		}

		// Token: 0x06010F94 RID: 69524
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTemporalShiftScale_GetPeriodicEndCorrection_05(HandleRef pThis);

		/// <summary>
		/// if Periodic time is enabled, this flag determines if the last time step is the same
		/// as the first. If PeriodicEndCorrection is true, then it is assumed that the input
		/// data goes from 0-1 (or whatever scaled/shifted actual time) and time 1 is the
		/// same as time 0 so that steps will be 0,1,2,3...N,1,2,3...N,1,2,3 where step N
		/// is the same as 0 and step 0 is not repeated. When this flag is false
		/// the data is assumed to be literal and output is of the form 0,1,2,3...N,0,1,2,3...
		/// By default this flag is ON
		/// </summary>
		// Token: 0x06010F95 RID: 69525 RVA: 0x0017A544 File Offset: 0x00178744
		public virtual int GetPeriodicEndCorrection()
		{
			return vtkTemporalShiftScale.vtkTemporalShiftScale_GetPeriodicEndCorrection_05(base.GetCppThis());
		}

		// Token: 0x06010F96 RID: 69526
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTemporalShiftScale_GetPostShift_06(HandleRef pThis);

		/// <summary>
		/// Apply a translation to the time
		/// </summary>
		// Token: 0x06010F97 RID: 69527 RVA: 0x0017A564 File Offset: 0x00178764
		public virtual double GetPostShift()
		{
			return vtkTemporalShiftScale.vtkTemporalShiftScale_GetPostShift_06(base.GetCppThis());
		}

		// Token: 0x06010F98 RID: 69528
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTemporalShiftScale_GetPreShift_07(HandleRef pThis);

		/// <summary>
		/// Apply a translation to the data before scaling.
		/// To convert T{5,100} to T{0,1} use Preshift=-5, Scale=1/95, PostShift=0
		/// To convert T{5,105} to T{5,10} use Preshift=-5, Scale=5/100, PostShift=5
		/// </summary>
		// Token: 0x06010F99 RID: 69529 RVA: 0x0017A584 File Offset: 0x00178784
		public virtual double GetPreShift()
		{
			return vtkTemporalShiftScale.vtkTemporalShiftScale_GetPreShift_07(base.GetCppThis());
		}

		// Token: 0x06010F9A RID: 69530
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTemporalShiftScale_GetScale_08(HandleRef pThis);

		/// <summary>
		/// Apply a scale to the time.
		/// </summary>
		// Token: 0x06010F9B RID: 69531 RVA: 0x0017A5A4 File Offset: 0x001787A4
		public virtual double GetScale()
		{
			return vtkTemporalShiftScale.vtkTemporalShiftScale_GetScale_08(base.GetCppThis());
		}

		// Token: 0x06010F9C RID: 69532
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTemporalShiftScale_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010F9D RID: 69533 RVA: 0x0017A5C4 File Offset: 0x001787C4
		public override int IsA(string type)
		{
			return vtkTemporalShiftScale.vtkTemporalShiftScale_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x06010F9E RID: 69534
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTemporalShiftScale_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010F9F RID: 69535 RVA: 0x0017A5E4 File Offset: 0x001787E4
		public new static int IsTypeOf(string type)
		{
			return vtkTemporalShiftScale.vtkTemporalShiftScale_IsTypeOf_10(type);
		}

		// Token: 0x06010FA0 RID: 69536
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTemporalShiftScale_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010FA1 RID: 69537 RVA: 0x0017A600 File Offset: 0x00178800
		public new vtkTemporalShiftScale NewInstance()
		{
			vtkTemporalShiftScale result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTemporalShiftScale.vtkTemporalShiftScale_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTemporalShiftScale)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010FA2 RID: 69538
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalShiftScale_PeriodicEndCorrectionOff_13(HandleRef pThis);

		/// <summary>
		/// if Periodic time is enabled, this flag determines if the last time step is the same
		/// as the first. If PeriodicEndCorrection is true, then it is assumed that the input
		/// data goes from 0-1 (or whatever scaled/shifted actual time) and time 1 is the
		/// same as time 0 so that steps will be 0,1,2,3...N,1,2,3...N,1,2,3 where step N
		/// is the same as 0 and step 0 is not repeated. When this flag is false
		/// the data is assumed to be literal and output is of the form 0,1,2,3...N,0,1,2,3...
		/// By default this flag is ON
		/// </summary>
		// Token: 0x06010FA3 RID: 69539 RVA: 0x0017A65A File Offset: 0x0017885A
		public virtual void PeriodicEndCorrectionOff()
		{
			vtkTemporalShiftScale.vtkTemporalShiftScale_PeriodicEndCorrectionOff_13(base.GetCppThis());
		}

		// Token: 0x06010FA4 RID: 69540
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalShiftScale_PeriodicEndCorrectionOn_14(HandleRef pThis);

		/// <summary>
		/// if Periodic time is enabled, this flag determines if the last time step is the same
		/// as the first. If PeriodicEndCorrection is true, then it is assumed that the input
		/// data goes from 0-1 (or whatever scaled/shifted actual time) and time 1 is the
		/// same as time 0 so that steps will be 0,1,2,3...N,1,2,3...N,1,2,3 where step N
		/// is the same as 0 and step 0 is not repeated. When this flag is false
		/// the data is assumed to be literal and output is of the form 0,1,2,3...N,0,1,2,3...
		/// By default this flag is ON
		/// </summary>
		// Token: 0x06010FA5 RID: 69541 RVA: 0x0017A669 File Offset: 0x00178869
		public virtual void PeriodicEndCorrectionOn()
		{
			vtkTemporalShiftScale.vtkTemporalShiftScale_PeriodicEndCorrectionOn_14(base.GetCppThis());
		}

		// Token: 0x06010FA6 RID: 69542
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalShiftScale_PeriodicOff_15(HandleRef pThis);

		/// <summary>
		/// If Periodic is true, requests for time will be wrapped around so that
		/// the source appears to be a periodic time source. If data exists for times
		/// {0,N-1}, setting periodic to true will cause time 0 to be produced when time
		/// N, 2N, 2N etc is requested. This effectively gives the source the ability to
		/// generate time data indefinitely in a loop.
		/// When combined with Shift/Scale, the time becomes periodic in the
		/// shifted and scaled time frame of reference.
		/// Note: Since the input time may not start at zero, the wrapping of time
		/// from the end of one period to the start of the next, will subtract the
		/// initial time - a source with T{5..6} repeated periodically will have output
		/// time {5..6..7..8} etc.
		/// </summary>
		// Token: 0x06010FA7 RID: 69543 RVA: 0x0017A678 File Offset: 0x00178878
		public virtual void PeriodicOff()
		{
			vtkTemporalShiftScale.vtkTemporalShiftScale_PeriodicOff_15(base.GetCppThis());
		}

		// Token: 0x06010FA8 RID: 69544
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalShiftScale_PeriodicOn_16(HandleRef pThis);

		/// <summary>
		/// If Periodic is true, requests for time will be wrapped around so that
		/// the source appears to be a periodic time source. If data exists for times
		/// {0,N-1}, setting periodic to true will cause time 0 to be produced when time
		/// N, 2N, 2N etc is requested. This effectively gives the source the ability to
		/// generate time data indefinitely in a loop.
		/// When combined with Shift/Scale, the time becomes periodic in the
		/// shifted and scaled time frame of reference.
		/// Note: Since the input time may not start at zero, the wrapping of time
		/// from the end of one period to the start of the next, will subtract the
		/// initial time - a source with T{5..6} repeated periodically will have output
		/// time {5..6..7..8} etc.
		/// </summary>
		// Token: 0x06010FA9 RID: 69545 RVA: 0x0017A687 File Offset: 0x00178887
		public virtual void PeriodicOn()
		{
			vtkTemporalShiftScale.vtkTemporalShiftScale_PeriodicOn_16(base.GetCppThis());
		}

		// Token: 0x06010FAA RID: 69546
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTemporalShiftScale_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010FAB RID: 69547 RVA: 0x0017A698 File Offset: 0x00178898
		public new static vtkTemporalShiftScale SafeDownCast(vtkObjectBase o)
		{
			vtkTemporalShiftScale vtkTemporalShiftScale = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTemporalShiftScale.vtkTemporalShiftScale_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTemporalShiftScale = (vtkTemporalShiftScale)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTemporalShiftScale.Register(null);
				}
			}
			return vtkTemporalShiftScale;
		}

		// Token: 0x06010FAC RID: 69548
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalShiftScale_SetMaximumNumberOfPeriods_18(HandleRef pThis, double _arg);

		/// <summary>
		/// if Periodic time is enabled, this controls how many time periods time is reported
		/// for. A filter cannot output an infinite number of time steps and therefore a finite
		/// number of periods is generated when reporting time.
		/// </summary>
		// Token: 0x06010FAD RID: 69549 RVA: 0x0017A717 File Offset: 0x00178917
		public virtual void SetMaximumNumberOfPeriods(double _arg)
		{
			vtkTemporalShiftScale.vtkTemporalShiftScale_SetMaximumNumberOfPeriods_18(base.GetCppThis(), _arg);
		}

		// Token: 0x06010FAE RID: 69550
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalShiftScale_SetPeriodic_19(HandleRef pThis, int _arg);

		/// <summary>
		/// If Periodic is true, requests for time will be wrapped around so that
		/// the source appears to be a periodic time source. If data exists for times
		/// {0,N-1}, setting periodic to true will cause time 0 to be produced when time
		/// N, 2N, 2N etc is requested. This effectively gives the source the ability to
		/// generate time data indefinitely in a loop.
		/// When combined with Shift/Scale, the time becomes periodic in the
		/// shifted and scaled time frame of reference.
		/// Note: Since the input time may not start at zero, the wrapping of time
		/// from the end of one period to the start of the next, will subtract the
		/// initial time - a source with T{5..6} repeated periodically will have output
		/// time {5..6..7..8} etc.
		/// </summary>
		// Token: 0x06010FAF RID: 69551 RVA: 0x0017A727 File Offset: 0x00178927
		public virtual void SetPeriodic(int _arg)
		{
			vtkTemporalShiftScale.vtkTemporalShiftScale_SetPeriodic_19(base.GetCppThis(), _arg);
		}

		// Token: 0x06010FB0 RID: 69552
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalShiftScale_SetPeriodicEndCorrection_20(HandleRef pThis, int _arg);

		/// <summary>
		/// if Periodic time is enabled, this flag determines if the last time step is the same
		/// as the first. If PeriodicEndCorrection is true, then it is assumed that the input
		/// data goes from 0-1 (or whatever scaled/shifted actual time) and time 1 is the
		/// same as time 0 so that steps will be 0,1,2,3...N,1,2,3...N,1,2,3 where step N
		/// is the same as 0 and step 0 is not repeated. When this flag is false
		/// the data is assumed to be literal and output is of the form 0,1,2,3...N,0,1,2,3...
		/// By default this flag is ON
		/// </summary>
		// Token: 0x06010FB1 RID: 69553 RVA: 0x0017A737 File Offset: 0x00178937
		public virtual void SetPeriodicEndCorrection(int _arg)
		{
			vtkTemporalShiftScale.vtkTemporalShiftScale_SetPeriodicEndCorrection_20(base.GetCppThis(), _arg);
		}

		// Token: 0x06010FB2 RID: 69554
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalShiftScale_SetPostShift_21(HandleRef pThis, double _arg);

		/// <summary>
		/// Apply a translation to the time
		/// </summary>
		// Token: 0x06010FB3 RID: 69555 RVA: 0x0017A747 File Offset: 0x00178947
		public virtual void SetPostShift(double _arg)
		{
			vtkTemporalShiftScale.vtkTemporalShiftScale_SetPostShift_21(base.GetCppThis(), _arg);
		}

		// Token: 0x06010FB4 RID: 69556
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalShiftScale_SetPreShift_22(HandleRef pThis, double _arg);

		/// <summary>
		/// Apply a translation to the data before scaling.
		/// To convert T{5,100} to T{0,1} use Preshift=-5, Scale=1/95, PostShift=0
		/// To convert T{5,105} to T{5,10} use Preshift=-5, Scale=5/100, PostShift=5
		/// </summary>
		// Token: 0x06010FB5 RID: 69557 RVA: 0x0017A757 File Offset: 0x00178957
		public virtual void SetPreShift(double _arg)
		{
			vtkTemporalShiftScale.vtkTemporalShiftScale_SetPreShift_22(base.GetCppThis(), _arg);
		}

		// Token: 0x06010FB6 RID: 69558
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalShiftScale_SetScale_23(HandleRef pThis, double _arg);

		/// <summary>
		/// Apply a scale to the time.
		/// </summary>
		// Token: 0x06010FB7 RID: 69559 RVA: 0x0017A767 File Offset: 0x00178967
		public virtual void SetScale(double _arg)
		{
			vtkTemporalShiftScale.vtkTemporalShiftScale_SetScale_23(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001398 RID: 5016
		public new const string MRFullTypeName = "Kitware.VTK.vtkTemporalShiftScale";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001399 RID: 5017
		public new static readonly string MRClassNameKey = "class vtkTemporalShiftScale";
	}
}
