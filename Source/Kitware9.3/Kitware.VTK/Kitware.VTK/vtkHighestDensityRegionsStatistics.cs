using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkHighestDensityRegionsStatistics
	/// </summary>
	/// <remarks>
	///    Compute a random vector of
	/// density f from input observations points. f is computed using a smooth
	/// kernel method.
	///
	///
	/// Given a selection of pairs of columns of interest, this class provides the
	/// following functionalities, depending on the chosen execution options:
	/// * Learn: calculates density estimator f of a random vector using a smooth
	///   gaussian kernel. The output metadata on port OUTPUT_MODEL is a multiblock
	///   dataset containing at one vtkTable holding three columns which are for the
	///   first columns the input columns of interest and for the last columns the
	///   density estimators of each input pair of columns of interest.
	/// * Derive: calculate normalized (as a percentage) quantiles coming from
	///   Learn output. The second block of the multibloc dataset contains a
	///   vtkTable holding some pairs of columns which are for the second one the
	///   quantiles ordered from the stronger to the lower and for the first one
	///   the correspondand quantile index.
	/// * Assess: not implemented.
	/// * Test: not implemented.
	/// </remarks>
	// Token: 0x02000745 RID: 1861
	public class vtkHighestDensityRegionsStatistics : vtkStatisticsAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601359F RID: 79263 RVA: 0x001B5D8A File Offset: 0x001B3F8A
		static vtkHighestDensityRegionsStatistics()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHighestDensityRegionsStatistics.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHighestDensityRegionsStatistics"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060135A0 RID: 79264 RVA: 0x001B5DB2 File Offset: 0x001B3FB2
		public vtkHighestDensityRegionsStatistics(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060135A1 RID: 79265
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHighestDensityRegionsStatistics_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060135A2 RID: 79266 RVA: 0x001B5DC0 File Offset: 0x001B3FC0
		public new static vtkHighestDensityRegionsStatistics New()
		{
			vtkHighestDensityRegionsStatistics result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHighestDensityRegionsStatistics.vtkHighestDensityRegionsStatistics_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHighestDensityRegionsStatistics)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060135A3 RID: 79267 RVA: 0x001B5E14 File Offset: 0x001B4014
		public vtkHighestDensityRegionsStatistics() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkHighestDensityRegionsStatistics.vtkHighestDensityRegionsStatistics_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060135A4 RID: 79268 RVA: 0x001B5E58 File Offset: 0x001B4058
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060135A5 RID: 79269
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHighestDensityRegionsStatistics_Aggregate_01(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		/// <summary>
		/// Given a collection of models, calculate aggregate model
		/// </summary>
		// Token: 0x060135A6 RID: 79270 RVA: 0x001B5E64 File Offset: 0x001B4064
		public override void Aggregate(vtkDataObjectCollection arg0, vtkMultiBlockDataSet arg1)
		{
			vtkHighestDensityRegionsStatistics.vtkHighestDensityRegionsStatistics_Aggregate_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x060135A7 RID: 79271
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkHighestDensityRegionsStatistics_ComputeHDR_02(HandleRef pThis, HandleRef inObservations, HandleRef outDensity);

		/// <summary>
		/// Fill outDensity with density vector that is computed from
		/// inObservations values. This method uses a Gaussian kernel.
		/// For n observations and with X an observation point:
		/// f(X) = (1 / n) * Sum(KH(X -Xi)) for (i = 1 to n).
		/// Look ComputeSmoothGaussianKernel for KH kernel definition.
		/// </summary>
		// Token: 0x060135A8 RID: 79272 RVA: 0x001B5EA8 File Offset: 0x001B40A8
		public double ComputeHDR(vtkDataArray inObservations, vtkDataArray outDensity)
		{
			return vtkHighestDensityRegionsStatistics.vtkHighestDensityRegionsStatistics_ComputeHDR_02(base.GetCppThis(), (inObservations == null) ? default(HandleRef) : inObservations.GetCppThis(), (outDensity == null) ? default(HandleRef) : outDensity.GetCppThis());
		}

		// Token: 0x060135A9 RID: 79273
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkHighestDensityRegionsStatistics_ComputeHDR_03(HandleRef pThis, HandleRef inObs, HandleRef inPOI, HandleRef outDensity);

		/// <summary>
		/// Fill outDensity with density vector defined by inPOI and computed from
		/// the inObs values. This method uses a Gaussian kernel.
		/// For n observations and with X an observation point:
		/// f(X) = (1 / n) * Sum(KH(X -Xi)) for (i = 1 to n).
		/// Look ComputeSmoothGaussianKernel for KH kernel definition.
		/// </summary>
		// Token: 0x060135AA RID: 79274 RVA: 0x001B5EF4 File Offset: 0x001B40F4
		public double ComputeHDR(vtkDataArray inObs, vtkDataArray inPOI, vtkDataArray outDensity)
		{
			return vtkHighestDensityRegionsStatistics.vtkHighestDensityRegionsStatistics_ComputeHDR_03(base.GetCppThis(), (inObs == null) ? default(HandleRef) : inObs.GetCppThis(), (inPOI == null) ? default(HandleRef) : inPOI.GetCppThis(), (outDensity == null) ? default(HandleRef) : outDensity.GetCppThis());
		}

		// Token: 0x060135AB RID: 79275
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHighestDensityRegionsStatistics_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060135AC RID: 79276 RVA: 0x001B5F54 File Offset: 0x001B4154
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkHighestDensityRegionsStatistics.vtkHighestDensityRegionsStatistics_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x060135AD RID: 79277
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHighestDensityRegionsStatistics_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060135AE RID: 79278 RVA: 0x001B5F74 File Offset: 0x001B4174
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkHighestDensityRegionsStatistics.vtkHighestDensityRegionsStatistics_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x060135AF RID: 79279
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHighestDensityRegionsStatistics_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060135B0 RID: 79280 RVA: 0x001B5F90 File Offset: 0x001B4190
		public override int IsA(string type)
		{
			return vtkHighestDensityRegionsStatistics.vtkHighestDensityRegionsStatistics_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x060135B1 RID: 79281
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHighestDensityRegionsStatistics_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060135B2 RID: 79282 RVA: 0x001B5FB0 File Offset: 0x001B41B0
		public new static int IsTypeOf(string type)
		{
			return vtkHighestDensityRegionsStatistics.vtkHighestDensityRegionsStatistics_IsTypeOf_07(type);
		}

		// Token: 0x060135B3 RID: 79283
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHighestDensityRegionsStatistics_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060135B4 RID: 79284 RVA: 0x001B5FCC File Offset: 0x001B41CC
		public new vtkHighestDensityRegionsStatistics NewInstance()
		{
			vtkHighestDensityRegionsStatistics result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHighestDensityRegionsStatistics.vtkHighestDensityRegionsStatistics_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHighestDensityRegionsStatistics)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060135B5 RID: 79285
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHighestDensityRegionsStatistics_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060135B6 RID: 79286 RVA: 0x001B6028 File Offset: 0x001B4228
		public new static vtkHighestDensityRegionsStatistics SafeDownCast(vtkObjectBase o)
		{
			vtkHighestDensityRegionsStatistics vtkHighestDensityRegionsStatistics = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHighestDensityRegionsStatistics.vtkHighestDensityRegionsStatistics_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHighestDensityRegionsStatistics = (vtkHighestDensityRegionsStatistics)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHighestDensityRegionsStatistics.Register(null);
				}
			}
			return vtkHighestDensityRegionsStatistics;
		}

		// Token: 0x060135B7 RID: 79287
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHighestDensityRegionsStatistics_SetSigma_11(HandleRef pThis, double sigma);

		/// <summary>
		/// Set the width of the gaussian kernel.
		/// </summary>
		// Token: 0x060135B8 RID: 79288 RVA: 0x001B60A7 File Offset: 0x001B42A7
		public void SetSigma(double sigma)
		{
			vtkHighestDensityRegionsStatistics.vtkHighestDensityRegionsStatistics_SetSigma_11(base.GetCppThis(), sigma);
		}

		// Token: 0x060135B9 RID: 79289
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHighestDensityRegionsStatistics_SetSigmaMatrix_12(HandleRef pThis, double s11, double s12, double s21, double s22);

		/// <summary>
		/// Set the gaussian kernel matrix.
		/// </summary>
		// Token: 0x060135BA RID: 79290 RVA: 0x001B60B7 File Offset: 0x001B42B7
		public void SetSigmaMatrix(double s11, double s12, double s21, double s22)
		{
			vtkHighestDensityRegionsStatistics.vtkHighestDensityRegionsStatistics_SetSigmaMatrix_12(base.GetCppThis(), s11, s12, s21, s22);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400165A RID: 5722
		public new const string MRFullTypeName = "Kitware.VTK.vtkHighestDensityRegionsStatistics";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400165B RID: 5723
		public new static readonly string MRClassNameKey = "class vtkHighestDensityRegionsStatistics";
	}
}
