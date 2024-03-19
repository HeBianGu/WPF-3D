using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTemporalInterpolator
	/// </summary>
	/// <remarks>
	///    interpolate datasets between time steps to produce a new dataset
	///
	/// vtkTemporalInterpolator interpolates between two time steps to
	/// produce new data for an arbitrary T.
	/// vtkTemporalInterpolator has three modes of operation.
	/// The default mode is to produce a continuous range of time
	/// values as output, which enables a filter downstream to request
	/// any value of T within the range.
	/// The second mode of operation is enabled by setting
	/// DiscreteTimeStepInterval to a non zero value. When this mode is
	/// activated, the filter will report a finite number of Time steps
	/// separated by deltaT between the original range of values.
	/// This mode is useful when a dataset of N time steps has one (or more)
	/// missing datasets for certain T values and you simply wish to smooth
	/// over the missing steps but otherwise use the original data.
	/// The third mode of operation is enabled by setting
	/// ResampleFactor to a non zero positive integer value.
	/// When this mode is activated, the filter will report a finite number
	/// of Time steps which contain the original steps, plus N new values between
	/// each original step 1/ResampleFactor time units apart.
	/// Note that if the input time steps are irregular, then using ResampleFactor
	/// will produce an irregular sequence of regular steps between
	/// each of the original irregular steps (clear enough, yes?).
	///
	/// @todo
	/// Higher order interpolation schemes will require changes to the API
	/// as most calls assume only two timesteps are used.
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
	// Token: 0x020004F2 RID: 1266
	public class vtkTemporalInterpolator : vtkMultiTimeStepAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E45B RID: 58459 RVA: 0x0013E067 File Offset: 0x0013C267
		static vtkTemporalInterpolator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTemporalInterpolator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTemporalInterpolator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E45C RID: 58460 RVA: 0x0013E08F File Offset: 0x0013C28F
		public vtkTemporalInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E45D RID: 58461
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTemporalInterpolator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E45E RID: 58462 RVA: 0x0013E0A0 File Offset: 0x0013C2A0
		public new static vtkTemporalInterpolator New()
		{
			vtkTemporalInterpolator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTemporalInterpolator.vtkTemporalInterpolator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTemporalInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E45F RID: 58463 RVA: 0x0013E0F4 File Offset: 0x0013C2F4
		public vtkTemporalInterpolator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTemporalInterpolator.vtkTemporalInterpolator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E460 RID: 58464 RVA: 0x0013E138 File Offset: 0x0013C338
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E461 RID: 58465
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTemporalInterpolator_GetCacheData_01(HandleRef pThis);

		/// <summary>
		/// Controls whether input data is cached to avoid updating input
		/// when multiple interpolations are asked between 2 time steps.
		/// </summary>
		// Token: 0x0600E462 RID: 58466 RVA: 0x0013E144 File Offset: 0x0013C344
		public virtual bool GetCacheData()
		{
			return vtkTemporalInterpolator.vtkTemporalInterpolator_GetCacheData_01(base.GetCppThis()) != 0;
		}

		// Token: 0x0600E463 RID: 58467
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTemporalInterpolator_GetDiscreteTimeStepInterval_02(HandleRef pThis);

		/// <summary>
		/// If you require a discrete number of outputs steps, to be
		/// generated from an input source - for example, you required
		/// N steps separated by T, then set DiscreteTimeStepInterval to T
		/// and you will get TIME_RANGE/DiscreteTimeStepInterval steps
		/// This is a useful option to use if you have a dataset with one
		/// missing time step and wish to 'fill-in' the missing data
		/// with an interpolated value from the steps either side
		/// </summary>
		// Token: 0x0600E464 RID: 58468 RVA: 0x0013E16C File Offset: 0x0013C36C
		public virtual double GetDiscreteTimeStepInterval()
		{
			return vtkTemporalInterpolator.vtkTemporalInterpolator_GetDiscreteTimeStepInterval_02(base.GetCppThis());
		}

		// Token: 0x0600E465 RID: 58469
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTemporalInterpolator_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E466 RID: 58470 RVA: 0x0013E18C File Offset: 0x0013C38C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTemporalInterpolator.vtkTemporalInterpolator_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0600E467 RID: 58471
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTemporalInterpolator_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E468 RID: 58472 RVA: 0x0013E1AC File Offset: 0x0013C3AC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTemporalInterpolator.vtkTemporalInterpolator_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0600E469 RID: 58473
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTemporalInterpolator_GetResampleFactor_05(HandleRef pThis);

		/// <summary>
		/// When ResampleFactor is a non zero positive integer, each pair
		/// of input time steps will be interpolated between with the number
		/// of steps specified. For example an input of 1,2,3,4,5 and a resample factor
		/// of 10, will produce steps 0f 1.0, 1.1, 1.2.....1.9, 2.0 etc
		/// NB. Irregular input steps will produce irregular output steps.
		/// Resample factor wuill only be used if DiscreteTimeStepInterval is zero
		/// otherwise the DiscreteTimeStepInterval takes precedence
		/// </summary>
		// Token: 0x0600E46A RID: 58474 RVA: 0x0013E1C8 File Offset: 0x0013C3C8
		public virtual int GetResampleFactor()
		{
			return vtkTemporalInterpolator.vtkTemporalInterpolator_GetResampleFactor_05(base.GetCppThis());
		}

		// Token: 0x0600E46B RID: 58475
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTemporalInterpolator_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E46C RID: 58476 RVA: 0x0013E1E8 File Offset: 0x0013C3E8
		public override int IsA(string type)
		{
			return vtkTemporalInterpolator.vtkTemporalInterpolator_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0600E46D RID: 58477
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTemporalInterpolator_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E46E RID: 58478 RVA: 0x0013E208 File Offset: 0x0013C408
		public new static int IsTypeOf(string type)
		{
			return vtkTemporalInterpolator.vtkTemporalInterpolator_IsTypeOf_07(type);
		}

		// Token: 0x0600E46F RID: 58479
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTemporalInterpolator_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E470 RID: 58480 RVA: 0x0013E224 File Offset: 0x0013C424
		public new vtkTemporalInterpolator NewInstance()
		{
			vtkTemporalInterpolator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTemporalInterpolator.vtkTemporalInterpolator_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTemporalInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E471 RID: 58481
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTemporalInterpolator_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E472 RID: 58482 RVA: 0x0013E280 File Offset: 0x0013C480
		public new static vtkTemporalInterpolator SafeDownCast(vtkObjectBase o)
		{
			vtkTemporalInterpolator vtkTemporalInterpolator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTemporalInterpolator.vtkTemporalInterpolator_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTemporalInterpolator = (vtkTemporalInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTemporalInterpolator.Register(null);
				}
			}
			return vtkTemporalInterpolator;
		}

		// Token: 0x0600E473 RID: 58483
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalInterpolator_SetCacheData_11(HandleRef pThis, byte _arg);

		/// <summary>
		/// Controls whether input data is cached to avoid updating input
		/// when multiple interpolations are asked between 2 time steps.
		/// </summary>
		// Token: 0x0600E474 RID: 58484 RVA: 0x0013E2FF File Offset: 0x0013C4FF
		public virtual void SetCacheData(bool _arg)
		{
			vtkTemporalInterpolator.vtkTemporalInterpolator_SetCacheData_11(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600E475 RID: 58485
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalInterpolator_SetDiscreteTimeStepInterval_12(HandleRef pThis, double _arg);

		/// <summary>
		/// If you require a discrete number of outputs steps, to be
		/// generated from an input source - for example, you required
		/// N steps separated by T, then set DiscreteTimeStepInterval to T
		/// and you will get TIME_RANGE/DiscreteTimeStepInterval steps
		/// This is a useful option to use if you have a dataset with one
		/// missing time step and wish to 'fill-in' the missing data
		/// with an interpolated value from the steps either side
		/// </summary>
		// Token: 0x0600E476 RID: 58486 RVA: 0x0013E317 File Offset: 0x0013C517
		public virtual void SetDiscreteTimeStepInterval(double _arg)
		{
			vtkTemporalInterpolator.vtkTemporalInterpolator_SetDiscreteTimeStepInterval_12(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E477 RID: 58487
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalInterpolator_SetResampleFactor_13(HandleRef pThis, int _arg);

		/// <summary>
		/// When ResampleFactor is a non zero positive integer, each pair
		/// of input time steps will be interpolated between with the number
		/// of steps specified. For example an input of 1,2,3,4,5 and a resample factor
		/// of 10, will produce steps 0f 1.0, 1.1, 1.2.....1.9, 2.0 etc
		/// NB. Irregular input steps will produce irregular output steps.
		/// Resample factor wuill only be used if DiscreteTimeStepInterval is zero
		/// otherwise the DiscreteTimeStepInterval takes precedence
		/// </summary>
		// Token: 0x0600E478 RID: 58488 RVA: 0x0013E327 File Offset: 0x0013C527
		public virtual void SetResampleFactor(int _arg)
		{
			vtkTemporalInterpolator.vtkTemporalInterpolator_SetResampleFactor_13(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010C9 RID: 4297
		public new const string MRFullTypeName = "Kitware.VTK.vtkTemporalInterpolator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010CA RID: 4298
		public new static readonly string MRClassNameKey = "class vtkTemporalInterpolator";
	}
}
