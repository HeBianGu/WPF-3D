using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMultiCorrelativeStatistics
	/// </summary>
	/// <remarks>
	///    A class for multivariate linear correlation
	///
	///
	/// Given a selection of sets of columns of interest, this class provides the
	/// following functionalities, depending on the operation in which it is executed:
	/// * Learn: calculates means, unbiased variance and covariance estimators of
	///   column pairs coefficient.
	///   More precisely, Learn calculates the averages and centered
	///   variance/covariance sums; if \p finalize is set to true (default),
	///   the final statistics are calculated.
	///   The output metadata on port OUTPUT_MODEL is a multiblock dataset containing at a minimum
	///   one vtkTable holding the raw sums in a sparse matrix style. If \a finalize is
	///   true, then one additional vtkTable will be present for each requested set of
	///   column correlations. These additional tables contain column averages, the
	///   upper triangular portion of the covariance matrix (in the upper right hand
	///   portion of the table) and the Cholesky decomposition of the covariance matrix
	///   (in the lower portion of the table beneath the covariance triangle).
	///   The leftmost column will be a vector of column averages.
	///   The last entry in the column averages vector is the number of samples.
	///   As an example, consider a request for a 3-column correlation with columns
	///   named ColA, ColB, and ColC.
	///   The resulting table will look like this:
	///   &lt;pre&gt;
	///      Column  |Mean     |ColA     |ColB     |ColC
	///      --------+---------+---------+---------+---------
	///      ColA    |avg(A)   |cov(A,A) |cov(A,B) |cov(A,C)
	///      ColB    |avg(B)   |chol(1,1)|cov(B,B) |cov(B,C)
	///      ColC    |avg(C)   |chol(2,1)|chol(2,2)|cov(C,C)
	///      Cholesky|length(A)|chol(3,1)|chol(3,2)|chol(3,3)
	///   &lt;/pre&gt;
	///   The mean point and the covariance matrix can be replaced by the median point and the
	///   MAD matrix (Median Absolute Deviation) thanks to the MedianAbsoluteDeviation boolean.
	///   In this mode, the resulting table will look like this:
	///   &lt;pre&gt;
	///      Column  |Mean     |ColA     |ColB     |ColC
	///      --------+---------+---------+---------+---------
	///      ColA    |med(A)   |MAD(A,A) |MAD(A,B) |MAD(A,C)
	///      ColB    |med(B)   |chol(1,1)|MAD(B,B) |MAD(B,C)
	///      ColC    |med(C)   |chol(2,1)|chol(2,2)|MAD(C,C)
	///      Cholesky|length(A)|chol(3,1)|chol(3,2)|chol(3,3)
	///   &lt;/pre&gt;
	///   The Median Absolute Deviation is known to be more robust than the covariance. It is
	///   used in the robust PCA computation for instance.
	/// * Assess: given a set of results matrices as specified above in input port INPUT_MODEL and
	///   tabular data on input port INPUT_DATA that contains column names matching those
	///   of the tables on input port INPUT_MODEL, the assess mode computes the relative
	///   deviation of each observation in port INPUT_DATA's table according to the linear
	///   correlations implied by each table in port INPUT_MODEL.
	///
	/// @par Thanks:
	/// Thanks to Philippe Pebay, Jackson Mayo, and David Thompson of
	/// Sandia National Laboratories for implementing this class.
	/// Updated by Philippe Pebay, Kitware SAS 2012
	/// Updated by Tristan Coulange and Joachim Pouderoux, Kitware SAS 2013
	/// </remarks>
	// Token: 0x0200074A RID: 1866
	public class vtkMultiCorrelativeStatistics : vtkStatisticsAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06013649 RID: 79433 RVA: 0x001B6FC9 File Offset: 0x001B51C9
		static vtkMultiCorrelativeStatistics()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMultiCorrelativeStatistics.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMultiCorrelativeStatistics"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601364A RID: 79434 RVA: 0x001B6FF1 File Offset: 0x001B51F1
		public vtkMultiCorrelativeStatistics(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601364B RID: 79435
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiCorrelativeStatistics_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601364C RID: 79436 RVA: 0x001B7000 File Offset: 0x001B5200
		public new static vtkMultiCorrelativeStatistics New()
		{
			vtkMultiCorrelativeStatistics result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiCorrelativeStatistics.vtkMultiCorrelativeStatistics_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMultiCorrelativeStatistics)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601364D RID: 79437 RVA: 0x001B7054 File Offset: 0x001B5254
		public vtkMultiCorrelativeStatistics() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMultiCorrelativeStatistics.vtkMultiCorrelativeStatistics_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601364E RID: 79438 RVA: 0x001B7098 File Offset: 0x001B5298
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601364F RID: 79439
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiCorrelativeStatistics_Aggregate_01(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		/// <summary>
		/// Given a collection of models, calculate aggregate model
		/// </summary>
		// Token: 0x06013650 RID: 79440 RVA: 0x001B70A4 File Offset: 0x001B52A4
		public override void Aggregate(vtkDataObjectCollection arg0, vtkMultiBlockDataSet arg1)
		{
			vtkMultiCorrelativeStatistics.vtkMultiCorrelativeStatistics_Aggregate_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x06013651 RID: 79441
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMultiCorrelativeStatistics_GetGhostsToSkip_02(HandleRef pThis);

		/// <summary>
		/// will be skipped. It is set to 0xff by default (every ghosts types are skipped).
		///
		/// @sa
		/// vtkDataSetAttributes
		/// vtkFieldData
		/// vtkPointData
		/// vtkCellData
		/// </summary>
		// Token: 0x06013652 RID: 79442 RVA: 0x001B70E8 File Offset: 0x001B52E8
		public virtual byte GetGhostsToSkip()
		{
			return vtkMultiCorrelativeStatistics.vtkMultiCorrelativeStatistics_GetGhostsToSkip_02(base.GetCppThis());
		}

		// Token: 0x06013653 RID: 79443
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMultiCorrelativeStatistics_GetMedianAbsoluteDeviation_03(HandleRef pThis);

		/// <summary>
		/// If set to true, the covariance matrix is replaced by
		/// the Median Absolute Deviation matrix.
		/// Default is false.
		/// </summary>
		// Token: 0x06013654 RID: 79444 RVA: 0x001B7108 File Offset: 0x001B5308
		public virtual bool GetMedianAbsoluteDeviation()
		{
			return vtkMultiCorrelativeStatistics.vtkMultiCorrelativeStatistics_GetMedianAbsoluteDeviation_03(base.GetCppThis()) != 0;
		}

		// Token: 0x06013655 RID: 79445
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMultiCorrelativeStatistics_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013656 RID: 79446 RVA: 0x001B7130 File Offset: 0x001B5330
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMultiCorrelativeStatistics.vtkMultiCorrelativeStatistics_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06013657 RID: 79447
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMultiCorrelativeStatistics_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013658 RID: 79448 RVA: 0x001B7150 File Offset: 0x001B5350
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMultiCorrelativeStatistics.vtkMultiCorrelativeStatistics_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06013659 RID: 79449
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiCorrelativeStatistics_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601365A RID: 79450 RVA: 0x001B716C File Offset: 0x001B536C
		public override int IsA(string type)
		{
			return vtkMultiCorrelativeStatistics.vtkMultiCorrelativeStatistics_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0601365B RID: 79451
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiCorrelativeStatistics_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601365C RID: 79452 RVA: 0x001B718C File Offset: 0x001B538C
		public new static int IsTypeOf(string type)
		{
			return vtkMultiCorrelativeStatistics.vtkMultiCorrelativeStatistics_IsTypeOf_07(type);
		}

		// Token: 0x0601365D RID: 79453
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiCorrelativeStatistics_MedianAbsoluteDeviationOff_08(HandleRef pThis);

		/// <summary>
		/// If set to true, the covariance matrix is replaced by
		/// the Median Absolute Deviation matrix.
		/// Default is false.
		/// </summary>
		// Token: 0x0601365E RID: 79454 RVA: 0x001B71A6 File Offset: 0x001B53A6
		public virtual void MedianAbsoluteDeviationOff()
		{
			vtkMultiCorrelativeStatistics.vtkMultiCorrelativeStatistics_MedianAbsoluteDeviationOff_08(base.GetCppThis());
		}

		// Token: 0x0601365F RID: 79455
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiCorrelativeStatistics_MedianAbsoluteDeviationOn_09(HandleRef pThis);

		/// <summary>
		/// If set to true, the covariance matrix is replaced by
		/// the Median Absolute Deviation matrix.
		/// Default is false.
		/// </summary>
		// Token: 0x06013660 RID: 79456 RVA: 0x001B71B5 File Offset: 0x001B53B5
		public virtual void MedianAbsoluteDeviationOn()
		{
			vtkMultiCorrelativeStatistics.vtkMultiCorrelativeStatistics_MedianAbsoluteDeviationOn_09(base.GetCppThis());
		}

		// Token: 0x06013661 RID: 79457
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiCorrelativeStatistics_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013662 RID: 79458 RVA: 0x001B71C4 File Offset: 0x001B53C4
		public new vtkMultiCorrelativeStatistics NewInstance()
		{
			vtkMultiCorrelativeStatistics result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiCorrelativeStatistics.vtkMultiCorrelativeStatistics_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMultiCorrelativeStatistics)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06013663 RID: 79459
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiCorrelativeStatistics_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013664 RID: 79460 RVA: 0x001B7220 File Offset: 0x001B5420
		public new static vtkMultiCorrelativeStatistics SafeDownCast(vtkObjectBase o)
		{
			vtkMultiCorrelativeStatistics vtkMultiCorrelativeStatistics = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiCorrelativeStatistics.vtkMultiCorrelativeStatistics_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiCorrelativeStatistics = (vtkMultiCorrelativeStatistics)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiCorrelativeStatistics.Register(null);
				}
			}
			return vtkMultiCorrelativeStatistics;
		}

		// Token: 0x06013665 RID: 79461
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiCorrelativeStatistics_SetGhostsToSkip_13(HandleRef pThis, byte _arg);

		/// <summary>
		/// will be skipped. It is set to 0xff by default (every ghosts types are skipped).
		///
		/// @sa
		/// vtkDataSetAttributes
		/// vtkFieldData
		/// vtkPointData
		/// vtkCellData
		/// </summary>
		// Token: 0x06013666 RID: 79462 RVA: 0x001B729F File Offset: 0x001B549F
		public virtual void SetGhostsToSkip(byte _arg)
		{
			vtkMultiCorrelativeStatistics.vtkMultiCorrelativeStatistics_SetGhostsToSkip_13(base.GetCppThis(), _arg);
		}

		// Token: 0x06013667 RID: 79463
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiCorrelativeStatistics_SetMedianAbsoluteDeviation_14(HandleRef pThis, byte _arg);

		/// <summary>
		/// If set to true, the covariance matrix is replaced by
		/// the Median Absolute Deviation matrix.
		/// Default is false.
		/// </summary>
		// Token: 0x06013668 RID: 79464 RVA: 0x001B72AF File Offset: 0x001B54AF
		public virtual void SetMedianAbsoluteDeviation(bool _arg)
		{
			vtkMultiCorrelativeStatistics.vtkMultiCorrelativeStatistics_SetMedianAbsoluteDeviation_14(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001664 RID: 5732
		public new const string MRFullTypeName = "Kitware.VTK.vtkMultiCorrelativeStatistics";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001665 RID: 5733
		public new static readonly string MRClassNameKey = "class vtkMultiCorrelativeStatistics";
	}
}
