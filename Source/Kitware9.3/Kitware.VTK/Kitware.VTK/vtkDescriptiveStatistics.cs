using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDescriptiveStatistics
	/// </summary>
	/// <remarks>
	///    A class for univariate descriptive statistics
	///
	///
	/// Given a selection of columns of interest in an input data table, this
	/// class provides the following functionalities, depending on the chosen
	/// execution options:
	/// * Learn: calculate extremal values, sample mean, and M2, M3, and M4 aggregates
	///   (cf. P. Pebay, Formulas for robust, one-pass parallel computation of covariances
	///   and Arbitrary-Order Statistical Moments, Sandia Report SAND2008-6212, Sep 2008,
	///   http://infoserve.sandia.gov/sand_doc/2008/086212.pdf for details)
	/// * Derive: calculate unbiased variance estimator, standard deviation estimator,
	///   two skewness estimators, and two kurtosis excess estimators.
	/// * Assess: given an input data set, a reference value and a non-negative deviation,
	///   mark each datum with corresponding relative deviation (1-dimensional Mahlanobis
	///   distance). If the deviation is zero, then mark each datum which are equal to the
	///   reference value with 0, and all others with 1. By default, the reference value
	///   and the deviation are, respectively, the mean and the standard deviation of the
	///   input model.
	/// * Test: calculate Jarque-Bera statistic and, if VTK to R interface is available,
	///   retrieve corresponding p-value for normality testing.
	///
	/// Among the derived statistics, the variance, the standard deviation, the skewness
	/// and the kurtosis can be estimated in two ways: using the sample version of those
	/// statistics, or the population version. Specify whether a sample estimate or population
	/// estimate is done by setting `SampleEstimate`. By default, `SampleEstimate == true`, hence
	/// the sample version of the statistics is estimated,
	/// which produces unbiased estimators (except for the sample standard deviation).
	/// The sample estimate should be used for input that represent a subset of the whole
	/// population of study. On the other hand, when `SampleEstimate == false`, the population
	/// version of the statistics is estimated. If the input doesn't contain all the samples
	/// from the population of study, then a bias is induced (the variance is slightly bigger than it
	/// should be). One can read about Bessel's correction to understand better where this comes from.
	/// That being said, on very large data, the difference between the 2 estimation formulas
	/// becomes very low, so in those instances,
	/// either state of `SampleEstimate` should yield very similar results
	/// (see explicit formulas below).
	///
	/// \verbatim
	///
	/// The formulas used are as follows, writing \f( \bar{X} \f) the mean of \f( X \f) and \f( N \f)
	/// the number of samples:
	/// - Sample estimate:
	///   \f[
	///    Var{X} = s^2 = \frac{\sum_{k=1}^N \left(x_k - \bar{x}\right)^2 }{N - 1}
	///   \f]
	///   \f[
	///    Skew{X} = \frac{n}{(n - 1)(n - 2)}
	///    \frac{\sum_{k=1}^N \left(x_k - \bar{x}\right)^3 }{s^3}
	///   \f]
	///   \f[
	///    Kurt{X} = \frac{n(n + 1)}{(n - 1)(n - 2)(n - 3)}
	///    \frac{\sum_{k=1}^N \left(x_k - \bar{x}\right)^3 }{s^4}
	///    - 3 \frac{(n - 1)^2}{(n - 2)(n - 3)}
	///   \f]
	/// - Population estimate:
	///   \f[
	///    Var{X} = \sigma^2 = \frac{\sum_{k=1}^N \left(x_k - \bar{x}\right)^2 }{N}
	///   \f]
	///   \f[
	///    Skew{X} = \frac{1}{N}\frac{\sum_{k=1}^N \left(x_k - \bar{x}\right)^3 }{\sigma^3}
	///   \f]
	///   \f[
	///    Kurt{X} = \frac{1}{N}\frac{\sum_{k=1}^N \left(x_k - \bar{x}\right)^3 }{\sigma^4} - 3
	///   \f]
	///
	/// \f(\sigma\f) is the population standard deviation, and \f(s\f) is the sample standard deviation.
	/// Note that the kurtosis is corrected so the kurtosis of a gaussian distribution should yield 0.
	///
	/// In the instance where \f(\sigma = 0\f) or \f(s = 0\f), the skewness and kurtosis are undefined.
	/// Thus they output a `NaN`. Similarly, if there are no samples, then all derived statistics
	/// yield a `NaN`.
	///
	/// \endverbatim
	///
	/// @par Thanks:
	/// Thanks to Philippe Pebay and David Thompson from Sandia National Laboratories
	/// for implementing this class.
	/// Updated by Philippe Pebay, Kitware SAS 2012
	/// </remarks>
	// Token: 0x02000742 RID: 1858
	public class vtkDescriptiveStatistics : vtkStatisticsAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060134F9 RID: 79097 RVA: 0x001B5117 File Offset: 0x001B3317
		static vtkDescriptiveStatistics()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDescriptiveStatistics.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDescriptiveStatistics"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060134FA RID: 79098 RVA: 0x001B513F File Offset: 0x001B333F
		public vtkDescriptiveStatistics(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060134FB RID: 79099
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDescriptiveStatistics_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060134FC RID: 79100 RVA: 0x001B5150 File Offset: 0x001B3350
		public new static vtkDescriptiveStatistics New()
		{
			vtkDescriptiveStatistics result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDescriptiveStatistics.vtkDescriptiveStatistics_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDescriptiveStatistics)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060134FD RID: 79101 RVA: 0x001B51A4 File Offset: 0x001B33A4
		public vtkDescriptiveStatistics() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDescriptiveStatistics.vtkDescriptiveStatistics_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060134FE RID: 79102 RVA: 0x001B51E8 File Offset: 0x001B33E8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060134FF RID: 79103
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDescriptiveStatistics_Aggregate_01(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		/// <summary>
		/// Given a collection of models, calculate aggregate model
		/// </summary>
		// Token: 0x06013500 RID: 79104 RVA: 0x001B51F4 File Offset: 0x001B33F4
		public override void Aggregate(vtkDataObjectCollection arg0, vtkMultiBlockDataSet arg1)
		{
			vtkDescriptiveStatistics.vtkDescriptiveStatistics_Aggregate_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x06013501 RID: 79105
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDescriptiveStatistics_GetGhostsToSkip_02(HandleRef pThis);

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
		// Token: 0x06013502 RID: 79106 RVA: 0x001B5238 File Offset: 0x001B3438
		public virtual byte GetGhostsToSkip()
		{
			return vtkDescriptiveStatistics.vtkDescriptiveStatistics_GetGhostsToSkip_02(base.GetCppThis());
		}

		// Token: 0x06013503 RID: 79107
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDescriptiveStatistics_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013504 RID: 79108 RVA: 0x001B5258 File Offset: 0x001B3458
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDescriptiveStatistics.vtkDescriptiveStatistics_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06013505 RID: 79109
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDescriptiveStatistics_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013506 RID: 79110 RVA: 0x001B5278 File Offset: 0x001B3478
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDescriptiveStatistics.vtkDescriptiveStatistics_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06013507 RID: 79111
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDescriptiveStatistics_GetSampleEstimate_05(HandleRef pThis);

		/// <summary>
		/// Getter / Setter on `SampleEstimate`. When turned on, descriptive statistics
		/// computed by this filter assume that the input data only holds a sample of the whole
		/// population of study. In effect, the sample variance, the sample standard deviation,
		/// the sample skewness and the sample kurtosis are estimated. When turned off, the population
		/// variance, the population standard deviation, the population skewness and the population
		/// kurtosis are estimated instead.
		///
		/// In short, if the input data is a full description of the population being studied,
		/// `SampleEstimate` should be turned off. If the input data is a sample of the population being
		/// studied, then `SampleEstimate` should be turned on. By default, `SampleEstimate` is turned
		/// on, as it is the most likely case.
		///
		/// Please see class description for a full description of the formulas.
		///
		/// @note For large data, the difference between the population estimate and the sample
		/// estimate becomes thin, so this parameter becomes of less worry.
		/// </summary>
		// Token: 0x06013508 RID: 79112 RVA: 0x001B5294 File Offset: 0x001B3494
		public virtual bool GetSampleEstimate()
		{
			return vtkDescriptiveStatistics.vtkDescriptiveStatistics_GetSampleEstimate_05(base.GetCppThis()) != 0;
		}

		// Token: 0x06013509 RID: 79113
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDescriptiveStatistics_GetSignedDeviations_06(HandleRef pThis);

		/// <summary>
		/// Set/get whether the deviations returned should be signed, or should
		/// only have their magnitude reported.
		/// The default is that signed deviations will be computed.
		/// </summary>
		// Token: 0x0601350A RID: 79114 RVA: 0x001B52BC File Offset: 0x001B34BC
		public virtual int GetSignedDeviations()
		{
			return vtkDescriptiveStatistics.vtkDescriptiveStatistics_GetSignedDeviations_06(base.GetCppThis());
		}

		// Token: 0x0601350B RID: 79115
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDescriptiveStatistics_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601350C RID: 79116 RVA: 0x001B52DC File Offset: 0x001B34DC
		public override int IsA(string type)
		{
			return vtkDescriptiveStatistics.vtkDescriptiveStatistics_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601350D RID: 79117
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDescriptiveStatistics_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601350E RID: 79118 RVA: 0x001B52FC File Offset: 0x001B34FC
		public new static int IsTypeOf(string type)
		{
			return vtkDescriptiveStatistics.vtkDescriptiveStatistics_IsTypeOf_08(type);
		}

		// Token: 0x0601350F RID: 79119
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDescriptiveStatistics_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013510 RID: 79120 RVA: 0x001B5318 File Offset: 0x001B3518
		public new vtkDescriptiveStatistics NewInstance()
		{
			vtkDescriptiveStatistics result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDescriptiveStatistics.vtkDescriptiveStatistics_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDescriptiveStatistics)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06013511 RID: 79121
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDescriptiveStatistics_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013512 RID: 79122 RVA: 0x001B5374 File Offset: 0x001B3574
		public new static vtkDescriptiveStatistics SafeDownCast(vtkObjectBase o)
		{
			vtkDescriptiveStatistics vtkDescriptiveStatistics = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDescriptiveStatistics.vtkDescriptiveStatistics_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDescriptiveStatistics = (vtkDescriptiveStatistics)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDescriptiveStatistics.Register(null);
				}
			}
			return vtkDescriptiveStatistics;
		}

		// Token: 0x06013513 RID: 79123
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDescriptiveStatistics_SampleEstimateOff_12(HandleRef pThis);

		/// <summary>
		/// Getter / Setter on `SampleEstimate`. When turned on, descriptive statistics
		/// computed by this filter assume that the input data only holds a sample of the whole
		/// population of study. In effect, the sample variance, the sample standard deviation,
		/// the sample skewness and the sample kurtosis are estimated. When turned off, the population
		/// variance, the population standard deviation, the population skewness and the population
		/// kurtosis are estimated instead.
		///
		/// In short, if the input data is a full description of the population being studied,
		/// `SampleEstimate` should be turned off. If the input data is a sample of the population being
		/// studied, then `SampleEstimate` should be turned on. By default, `SampleEstimate` is turned
		/// on, as it is the most likely case.
		///
		/// Please see class description for a full description of the formulas.
		///
		/// @note For large data, the difference between the population estimate and the sample
		/// estimate becomes thin, so this parameter becomes of less worry.
		/// </summary>
		// Token: 0x06013514 RID: 79124 RVA: 0x001B53F3 File Offset: 0x001B35F3
		public virtual void SampleEstimateOff()
		{
			vtkDescriptiveStatistics.vtkDescriptiveStatistics_SampleEstimateOff_12(base.GetCppThis());
		}

		// Token: 0x06013515 RID: 79125
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDescriptiveStatistics_SampleEstimateOn_13(HandleRef pThis);

		/// <summary>
		/// Getter / Setter on `SampleEstimate`. When turned on, descriptive statistics
		/// computed by this filter assume that the input data only holds a sample of the whole
		/// population of study. In effect, the sample variance, the sample standard deviation,
		/// the sample skewness and the sample kurtosis are estimated. When turned off, the population
		/// variance, the population standard deviation, the population skewness and the population
		/// kurtosis are estimated instead.
		///
		/// In short, if the input data is a full description of the population being studied,
		/// `SampleEstimate` should be turned off. If the input data is a sample of the population being
		/// studied, then `SampleEstimate` should be turned on. By default, `SampleEstimate` is turned
		/// on, as it is the most likely case.
		///
		/// Please see class description for a full description of the formulas.
		///
		/// @note For large data, the difference between the population estimate and the sample
		/// estimate becomes thin, so this parameter becomes of less worry.
		/// </summary>
		// Token: 0x06013516 RID: 79126 RVA: 0x001B5402 File Offset: 0x001B3602
		public virtual void SampleEstimateOn()
		{
			vtkDescriptiveStatistics.vtkDescriptiveStatistics_SampleEstimateOn_13(base.GetCppThis());
		}

		// Token: 0x06013517 RID: 79127
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDescriptiveStatistics_SetGhostsToSkip_14(HandleRef pThis, byte _arg);

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
		// Token: 0x06013518 RID: 79128 RVA: 0x001B5411 File Offset: 0x001B3611
		public virtual void SetGhostsToSkip(byte _arg)
		{
			vtkDescriptiveStatistics.vtkDescriptiveStatistics_SetGhostsToSkip_14(base.GetCppThis(), _arg);
		}

		// Token: 0x06013519 RID: 79129
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDescriptiveStatistics_SetSampleEstimate_15(HandleRef pThis, byte _arg);

		/// <summary>
		/// Getter / Setter on `SampleEstimate`. When turned on, descriptive statistics
		/// computed by this filter assume that the input data only holds a sample of the whole
		/// population of study. In effect, the sample variance, the sample standard deviation,
		/// the sample skewness and the sample kurtosis are estimated. When turned off, the population
		/// variance, the population standard deviation, the population skewness and the population
		/// kurtosis are estimated instead.
		///
		/// In short, if the input data is a full description of the population being studied,
		/// `SampleEstimate` should be turned off. If the input data is a sample of the population being
		/// studied, then `SampleEstimate` should be turned on. By default, `SampleEstimate` is turned
		/// on, as it is the most likely case.
		///
		/// Please see class description for a full description of the formulas.
		///
		/// @note For large data, the difference between the population estimate and the sample
		/// estimate becomes thin, so this parameter becomes of less worry.
		/// </summary>
		// Token: 0x0601351A RID: 79130 RVA: 0x001B5421 File Offset: 0x001B3621
		public virtual void SetSampleEstimate(bool _arg)
		{
			vtkDescriptiveStatistics.vtkDescriptiveStatistics_SetSampleEstimate_15(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0601351B RID: 79131
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDescriptiveStatistics_SetSignedDeviations_16(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get whether the deviations returned should be signed, or should
		/// only have their magnitude reported.
		/// The default is that signed deviations will be computed.
		/// </summary>
		// Token: 0x0601351C RID: 79132 RVA: 0x001B5439 File Offset: 0x001B3639
		public virtual void SetSignedDeviations(int _arg)
		{
			vtkDescriptiveStatistics.vtkDescriptiveStatistics_SetSignedDeviations_16(base.GetCppThis(), _arg);
		}

		// Token: 0x0601351D RID: 79133
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDescriptiveStatistics_SignedDeviationsOff_17(HandleRef pThis);

		/// <summary>
		/// Set/get whether the deviations returned should be signed, or should
		/// only have their magnitude reported.
		/// The default is that signed deviations will be computed.
		/// </summary>
		// Token: 0x0601351E RID: 79134 RVA: 0x001B5449 File Offset: 0x001B3649
		public virtual void SignedDeviationsOff()
		{
			vtkDescriptiveStatistics.vtkDescriptiveStatistics_SignedDeviationsOff_17(base.GetCppThis());
		}

		// Token: 0x0601351F RID: 79135
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDescriptiveStatistics_SignedDeviationsOn_18(HandleRef pThis);

		/// <summary>
		/// Set/get whether the deviations returned should be signed, or should
		/// only have their magnitude reported.
		/// The default is that signed deviations will be computed.
		/// </summary>
		// Token: 0x06013520 RID: 79136 RVA: 0x001B5458 File Offset: 0x001B3658
		public virtual void SignedDeviationsOn()
		{
			vtkDescriptiveStatistics.vtkDescriptiveStatistics_SignedDeviationsOn_18(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001654 RID: 5716
		public new const string MRFullTypeName = "Kitware.VTK.vtkDescriptiveStatistics";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001655 RID: 5717
		public new static readonly string MRClassNameKey = "class vtkDescriptiveStatistics";
	}
}
