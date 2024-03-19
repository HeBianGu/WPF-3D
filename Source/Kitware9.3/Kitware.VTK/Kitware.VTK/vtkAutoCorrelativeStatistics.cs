using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAutoCorrelativeStatistics
	/// </summary>
	/// <remarks>
	///    A class for univariate auto-correlative statistics
	///
	///
	/// Given a selection of columns of interest in an input data table, this
	/// class provides the following functionalities, depending on the chosen
	/// execution options:
	/// * Learn: calculate sample mean and M2 aggregates for each variable w.r.t. itself
	///   (cf. P. Pebay, Formulas for robust, one-pass parallel computation of covariances
	///   and Arbitrary-Order Statistical Moments, Sandia Report SAND2008-6212, Sep 2008,
	///   http://infoserve.sandia.gov/sand_doc/2008/086212.pdf for details)
	///   for each specified time lag.
	/// * Derive: calculate unbiased autocovariance matrix estimators and its determinant,
	///   linear regressions, and Pearson correlation coefficient, for each specified
	///   time lag.
	/// * Assess: given an input data set, two means and a 2x2 covariance matrix,
	///   mark each datum with corresponding relative deviation (2-dimensional Mahlanobis
	///   distance).
	///
	///
	/// @par Thanks:
	/// This class was written by Philippe Pebay, Kitware SAS 2012
	/// </remarks>
	// Token: 0x0200073A RID: 1850
	public class vtkAutoCorrelativeStatistics : vtkStatisticsAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601343D RID: 78909 RVA: 0x001B3FBB File Offset: 0x001B21BB
		static vtkAutoCorrelativeStatistics()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAutoCorrelativeStatistics.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAutoCorrelativeStatistics"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601343E RID: 78910 RVA: 0x001B3FE3 File Offset: 0x001B21E3
		public vtkAutoCorrelativeStatistics(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601343F RID: 78911
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAutoCorrelativeStatistics_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013440 RID: 78912 RVA: 0x001B3FF4 File Offset: 0x001B21F4
		public new static vtkAutoCorrelativeStatistics New()
		{
			vtkAutoCorrelativeStatistics result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAutoCorrelativeStatistics.vtkAutoCorrelativeStatistics_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAutoCorrelativeStatistics)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013441 RID: 78913 RVA: 0x001B4048 File Offset: 0x001B2248
		public vtkAutoCorrelativeStatistics() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAutoCorrelativeStatistics.vtkAutoCorrelativeStatistics_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06013442 RID: 78914 RVA: 0x001B408C File Offset: 0x001B228C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06013443 RID: 78915
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAutoCorrelativeStatistics_Aggregate_01(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		/// <summary>
		/// Given a collection of models, calculate aggregate model
		/// </summary>
		// Token: 0x06013444 RID: 78916 RVA: 0x001B4098 File Offset: 0x001B2298
		public override void Aggregate(vtkDataObjectCollection arg0, vtkMultiBlockDataSet arg1)
		{
			vtkAutoCorrelativeStatistics.vtkAutoCorrelativeStatistics_Aggregate_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x06013445 RID: 78917
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAutoCorrelativeStatistics_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013446 RID: 78918 RVA: 0x001B40DC File Offset: 0x001B22DC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAutoCorrelativeStatistics.vtkAutoCorrelativeStatistics_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06013447 RID: 78919
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAutoCorrelativeStatistics_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013448 RID: 78920 RVA: 0x001B40FC File Offset: 0x001B22FC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAutoCorrelativeStatistics.vtkAutoCorrelativeStatistics_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06013449 RID: 78921
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAutoCorrelativeStatistics_GetSliceCardinality_04(HandleRef pThis);

		/// <summary>
		/// Set/get the cardinality of the data set at given time, i.e., of
		/// any given time slice. It cannot be negative.
		/// The input data set is assumed to have a cardinality which
		/// is a multiple of this value.
		/// The default is 0, meaning that the user must specify a value
		/// that is consistent with the input data set.
		/// </summary>
		// Token: 0x0601344A RID: 78922 RVA: 0x001B4118 File Offset: 0x001B2318
		public virtual long GetSliceCardinality()
		{
			return vtkAutoCorrelativeStatistics.vtkAutoCorrelativeStatistics_GetSliceCardinality_04(base.GetCppThis());
		}

		// Token: 0x0601344B RID: 78923
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAutoCorrelativeStatistics_GetSliceCardinalityMaxValue_05(HandleRef pThis);

		/// <summary>
		/// Set/get the cardinality of the data set at given time, i.e., of
		/// any given time slice. It cannot be negative.
		/// The input data set is assumed to have a cardinality which
		/// is a multiple of this value.
		/// The default is 0, meaning that the user must specify a value
		/// that is consistent with the input data set.
		/// </summary>
		// Token: 0x0601344C RID: 78924 RVA: 0x001B4138 File Offset: 0x001B2338
		public virtual long GetSliceCardinalityMaxValue()
		{
			return vtkAutoCorrelativeStatistics.vtkAutoCorrelativeStatistics_GetSliceCardinalityMaxValue_05(base.GetCppThis());
		}

		// Token: 0x0601344D RID: 78925
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAutoCorrelativeStatistics_GetSliceCardinalityMinValue_06(HandleRef pThis);

		/// <summary>
		/// Set/get the cardinality of the data set at given time, i.e., of
		/// any given time slice. It cannot be negative.
		/// The input data set is assumed to have a cardinality which
		/// is a multiple of this value.
		/// The default is 0, meaning that the user must specify a value
		/// that is consistent with the input data set.
		/// </summary>
		// Token: 0x0601344E RID: 78926 RVA: 0x001B4158 File Offset: 0x001B2358
		public virtual long GetSliceCardinalityMinValue()
		{
			return vtkAutoCorrelativeStatistics.vtkAutoCorrelativeStatistics_GetSliceCardinalityMinValue_06(base.GetCppThis());
		}

		// Token: 0x0601344F RID: 78927
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAutoCorrelativeStatistics_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013450 RID: 78928 RVA: 0x001B4178 File Offset: 0x001B2378
		public override int IsA(string type)
		{
			return vtkAutoCorrelativeStatistics.vtkAutoCorrelativeStatistics_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06013451 RID: 78929
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAutoCorrelativeStatistics_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013452 RID: 78930 RVA: 0x001B4198 File Offset: 0x001B2398
		public new static int IsTypeOf(string type)
		{
			return vtkAutoCorrelativeStatistics.vtkAutoCorrelativeStatistics_IsTypeOf_08(type);
		}

		// Token: 0x06013453 RID: 78931
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAutoCorrelativeStatistics_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013454 RID: 78932 RVA: 0x001B41B4 File Offset: 0x001B23B4
		public new vtkAutoCorrelativeStatistics NewInstance()
		{
			vtkAutoCorrelativeStatistics result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAutoCorrelativeStatistics.vtkAutoCorrelativeStatistics_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAutoCorrelativeStatistics)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06013455 RID: 78933
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAutoCorrelativeStatistics_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013456 RID: 78934 RVA: 0x001B4210 File Offset: 0x001B2410
		public new static vtkAutoCorrelativeStatistics SafeDownCast(vtkObjectBase o)
		{
			vtkAutoCorrelativeStatistics vtkAutoCorrelativeStatistics = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAutoCorrelativeStatistics.vtkAutoCorrelativeStatistics_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAutoCorrelativeStatistics = (vtkAutoCorrelativeStatistics)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAutoCorrelativeStatistics.Register(null);
				}
			}
			return vtkAutoCorrelativeStatistics;
		}

		// Token: 0x06013457 RID: 78935
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAutoCorrelativeStatistics_SetSliceCardinality_12(HandleRef pThis, long _arg);

		/// <summary>
		/// Set/get the cardinality of the data set at given time, i.e., of
		/// any given time slice. It cannot be negative.
		/// The input data set is assumed to have a cardinality which
		/// is a multiple of this value.
		/// The default is 0, meaning that the user must specify a value
		/// that is consistent with the input data set.
		/// </summary>
		// Token: 0x06013458 RID: 78936 RVA: 0x001B428F File Offset: 0x001B248F
		public virtual void SetSliceCardinality(long _arg)
		{
			vtkAutoCorrelativeStatistics.vtkAutoCorrelativeStatistics_SetSliceCardinality_12(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001640 RID: 5696
		public new const string MRFullTypeName = "Kitware.VTK.vtkAutoCorrelativeStatistics";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001641 RID: 5697
		public new static readonly string MRClassNameKey = "class vtkAutoCorrelativeStatistics";
	}
}
