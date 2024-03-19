using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPCAStatistics
	/// </summary>
	/// <remarks>
	///    A class for multivariate principal component analysis
	///
	///
	/// This class derives from the multi-correlative statistics algorithm and
	/// uses the covariance matrix and Cholesky decomposition computed by it.
	/// However, when it finalizes the statistics in learn operation, the PCA class
	/// computes the SVD of the covariance matrix in order to obtain its eigenvectors.
	///
	/// In the assess operation, the input data are
	/// - projected into the basis defined by the eigenvectors,
	/// - the energy associated with each datum is computed,
	/// - or some combination thereof.
	/// Additionally, the user may specify some threshold energy or
	/// eigenvector entry below which the basis is truncated. This allows
	/// projection into a lower-dimensional state while minimizing (in a
	/// least squares sense) the projection error.
	///
	/// In the test operation, a Jarque-Bera-Srivastava test of n-d normality is performed.
	///
	/// The Robust PCA can be computed by using the median instead of the mean,
	/// and the MAD matrix (Median Absolute Deviation) instead of the covariance matrix.
	/// This can be done by activating the MedianAbsoluteDeviation boolean (declared in
	/// the superclass).
	///
	/// @par Thanks:
	/// Thanks to David Thompson, Philippe Pebay and Jackson Mayo from
	/// Sandia National Laboratories for implementing this class.
	/// Updated by Philippe Pebay, Kitware SAS 2012
	/// Updated by Tristan Coulange and Joachim Pouderoux, Kitware SAS 2013
	/// </remarks>
	// Token: 0x0200074D RID: 1869
	public class vtkPCAStatistics : vtkMultiCorrelativeStatistics
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06013695 RID: 79509 RVA: 0x001B7689 File Offset: 0x001B5889
		static vtkPCAStatistics()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPCAStatistics.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPCAStatistics"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06013696 RID: 79510 RVA: 0x001B76B1 File Offset: 0x001B58B1
		public vtkPCAStatistics(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06013697 RID: 79511
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPCAStatistics_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013698 RID: 79512 RVA: 0x001B76C0 File Offset: 0x001B58C0
		public new static vtkPCAStatistics New()
		{
			vtkPCAStatistics result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPCAStatistics.vtkPCAStatistics_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPCAStatistics)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013699 RID: 79513 RVA: 0x001B7714 File Offset: 0x001B5914
		public vtkPCAStatistics() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPCAStatistics.vtkPCAStatistics_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601369A RID: 79514 RVA: 0x001B7758 File Offset: 0x001B5958
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601369B RID: 79515
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPCAStatistics_GetBasisScheme_01(HandleRef pThis);

		/// <summary>
		/// This variable controls the dimensionality of output tuples in Assess operation.
		/// Consider the case where you have requested a PCA on D columns.
		///
		/// When set to vtkPCAStatistics::FULL_BASIS, the entire set of basis vectors
		/// is used to derive new coordinates for each tuple being assessed.
		/// In this mode, you are guaranteed to have output tuples of the same dimension
		/// as the input tuples. (That dimension is D, so there will be D additional
		/// columns added to the table for the request.)
		///
		/// When set to vtkPCAStatistics::FIXED_BASIS_SIZE, only the first N basis vectors
		/// are used to derive new coordinates for each tuple being assessed.
		/// In this mode, you are guaranteed to have output tuples of dimension min(N,D).
		/// You must set N prior to assessing data using the SetFixedBasisSize() method.
		/// When N &lt; D, this turns the PCA into a projection (instead of change of basis).
		///
		/// When set to vtkPCAStatistics::FIXED_BASIS_ENERGY, the number of basis vectors
		/// used to derive new coordinates for each tuple will be the minimum number
		/// of columns N that satisfy
		/// \f[
		/// \frac{\sum_{i=1}^{N} \lambda_i}{\sum_{i=1}^{D} \lambda_i} &lt; T
		/// \f]
		/// You must set T prior to assessing data using the SetFixedBasisEnergy() method.
		/// When T &lt; 1, this turns the PCA into a projection (instead of change of basis).
		///
		/// By default BasisScheme is set to vtkPCAStatistics::FULL_BASIS.
		/// </summary>
		// Token: 0x0601369C RID: 79516 RVA: 0x001B7764 File Offset: 0x001B5964
		public virtual int GetBasisScheme()
		{
			return vtkPCAStatistics.vtkPCAStatistics_GetBasisScheme_01(base.GetCppThis());
		}

		// Token: 0x0601369D RID: 79517
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPCAStatistics_GetBasisSchemeName_02(HandleRef pThis, int schemeIndex);

		/// <summary>
		/// This variable controls the dimensionality of output tuples in Assess operation.
		/// Consider the case where you have requested a PCA on D columns.
		///
		/// When set to vtkPCAStatistics::FULL_BASIS, the entire set of basis vectors
		/// is used to derive new coordinates for each tuple being assessed.
		/// In this mode, you are guaranteed to have output tuples of the same dimension
		/// as the input tuples. (That dimension is D, so there will be D additional
		/// columns added to the table for the request.)
		///
		/// When set to vtkPCAStatistics::FIXED_BASIS_SIZE, only the first N basis vectors
		/// are used to derive new coordinates for each tuple being assessed.
		/// In this mode, you are guaranteed to have output tuples of dimension min(N,D).
		/// You must set N prior to assessing data using the SetFixedBasisSize() method.
		/// When N &lt; D, this turns the PCA into a projection (instead of change of basis).
		///
		/// When set to vtkPCAStatistics::FIXED_BASIS_ENERGY, the number of basis vectors
		/// used to derive new coordinates for each tuple will be the minimum number
		/// of columns N that satisfy
		/// \f[
		/// \frac{\sum_{i=1}^{N} \lambda_i}{\sum_{i=1}^{D} \lambda_i} &lt; T
		/// \f]
		/// You must set T prior to assessing data using the SetFixedBasisEnergy() method.
		/// When T &lt; 1, this turns the PCA into a projection (instead of change of basis).
		///
		/// By default BasisScheme is set to vtkPCAStatistics::FULL_BASIS.
		/// </summary>
		// Token: 0x0601369E RID: 79518 RVA: 0x001B7784 File Offset: 0x001B5984
		public virtual string GetBasisSchemeName(int schemeIndex)
		{
			string s = Marshal.PtrToStringAnsi(vtkPCAStatistics.vtkPCAStatistics_GetBasisSchemeName_02(base.GetCppThis(), schemeIndex));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601369F RID: 79519
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPCAStatistics_GetEigenvalue_03(HandleRef pThis, int request, int i);

		/// <summary>
		/// Get the eigenvalues. The eigenvalues are ordered according from largest to smallest.
		/// This function:
		/// void GetEigenvalues(int request, int i, vtkDoubleArray*);
		/// does all of the work. The other functions simply call this function with the appropriate
		/// parameters. These functions are not valid unless Update() has been called and the Derive
		/// option is turned on.
		/// </summary>
		// Token: 0x060136A0 RID: 79520 RVA: 0x001B77C0 File Offset: 0x001B59C0
		public double GetEigenvalue(int request, int i)
		{
			return vtkPCAStatistics.vtkPCAStatistics_GetEigenvalue_03(base.GetCppThis(), request, i);
		}

		// Token: 0x060136A1 RID: 79521
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPCAStatistics_GetEigenvalue_04(HandleRef pThis, int i);

		/// <summary>
		/// Get the eigenvalues. The eigenvalues are ordered according from largest to smallest.
		/// This function:
		/// void GetEigenvalues(int request, int i, vtkDoubleArray*);
		/// does all of the work. The other functions simply call this function with the appropriate
		/// parameters. These functions are not valid unless Update() has been called and the Derive
		/// option is turned on.
		/// </summary>
		// Token: 0x060136A2 RID: 79522 RVA: 0x001B77E4 File Offset: 0x001B59E4
		public double GetEigenvalue(int i)
		{
			return vtkPCAStatistics.vtkPCAStatistics_GetEigenvalue_04(base.GetCppThis(), i);
		}

		// Token: 0x060136A3 RID: 79523
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPCAStatistics_GetEigenvalues_05(HandleRef pThis, int request, HandleRef arg1);

		/// <summary>
		/// Get the eigenvalues. The eigenvalues are ordered according from largest to smallest.
		/// This function:
		/// void GetEigenvalues(int request, int i, vtkDoubleArray*);
		/// does all of the work. The other functions simply call this function with the appropriate
		/// parameters. These functions are not valid unless Update() has been called and the Derive
		/// option is turned on.
		/// </summary>
		// Token: 0x060136A4 RID: 79524 RVA: 0x001B7804 File Offset: 0x001B5A04
		public void GetEigenvalues(int request, vtkDoubleArray arg1)
		{
			vtkPCAStatistics.vtkPCAStatistics_GetEigenvalues_05(base.GetCppThis(), request, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x060136A5 RID: 79525
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPCAStatistics_GetEigenvalues_06(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get the eigenvalues. The eigenvalues are ordered according from largest to smallest.
		/// This function:
		/// void GetEigenvalues(int request, int i, vtkDoubleArray*);
		/// does all of the work. The other functions simply call this function with the appropriate
		/// parameters. These functions are not valid unless Update() has been called and the Derive
		/// option is turned on.
		/// </summary>
		// Token: 0x060136A6 RID: 79526 RVA: 0x001B7834 File Offset: 0x001B5A34
		public void GetEigenvalues(vtkDoubleArray arg0)
		{
			vtkPCAStatistics.vtkPCAStatistics_GetEigenvalues_06(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060136A7 RID: 79527
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPCAStatistics_GetEigenvector_07(HandleRef pThis, int i, HandleRef eigenvector);

		/// <summary>
		/// Get the eigenvectors. The eigenvectors are ordered according to the magnitude of their
		/// associated eigenvalues, sorted from largest to smallest. That is, eigenvector 0 corresponds
		/// to the largest eigenvalue.
		/// This function:
		/// void GetEigenvectors(int request, vtkDoubleArray* eigenvectors)
		/// does all of the work. The other functions are convenience functions that call this function
		/// with default arguments. These functions are not valid unless Update() has been called and the
		/// Derive option is turned on.
		/// </summary>
		// Token: 0x060136A8 RID: 79528 RVA: 0x001B7864 File Offset: 0x001B5A64
		public void GetEigenvector(int i, vtkDoubleArray eigenvector)
		{
			vtkPCAStatistics.vtkPCAStatistics_GetEigenvector_07(base.GetCppThis(), i, (eigenvector == null) ? default(HandleRef) : eigenvector.GetCppThis());
		}

		// Token: 0x060136A9 RID: 79529
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPCAStatistics_GetEigenvector_08(HandleRef pThis, int request, int i, HandleRef eigenvector);

		/// <summary>
		/// Get the eigenvectors. The eigenvectors are ordered according to the magnitude of their
		/// associated eigenvalues, sorted from largest to smallest. That is, eigenvector 0 corresponds
		/// to the largest eigenvalue.
		/// This function:
		/// void GetEigenvectors(int request, vtkDoubleArray* eigenvectors)
		/// does all of the work. The other functions are convenience functions that call this function
		/// with default arguments. These functions are not valid unless Update() has been called and the
		/// Derive option is turned on.
		/// </summary>
		// Token: 0x060136AA RID: 79530 RVA: 0x001B7894 File Offset: 0x001B5A94
		public void GetEigenvector(int request, int i, vtkDoubleArray eigenvector)
		{
			vtkPCAStatistics.vtkPCAStatistics_GetEigenvector_08(base.GetCppThis(), request, i, (eigenvector == null) ? default(HandleRef) : eigenvector.GetCppThis());
		}

		// Token: 0x060136AB RID: 79531
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPCAStatistics_GetEigenvectors_09(HandleRef pThis, int request, HandleRef eigenvectors);

		/// <summary>
		/// Get the eigenvectors. The eigenvectors are ordered according to the magnitude of their
		/// associated eigenvalues, sorted from largest to smallest. That is, eigenvector 0 corresponds
		/// to the largest eigenvalue.
		/// This function:
		/// void GetEigenvectors(int request, vtkDoubleArray* eigenvectors)
		/// does all of the work. The other functions are convenience functions that call this function
		/// with default arguments. These functions are not valid unless Update() has been called and the
		/// Derive option is turned on.
		/// </summary>
		// Token: 0x060136AC RID: 79532 RVA: 0x001B78C8 File Offset: 0x001B5AC8
		public void GetEigenvectors(int request, vtkDoubleArray eigenvectors)
		{
			vtkPCAStatistics.vtkPCAStatistics_GetEigenvectors_09(base.GetCppThis(), request, (eigenvectors == null) ? default(HandleRef) : eigenvectors.GetCppThis());
		}

		// Token: 0x060136AD RID: 79533
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPCAStatistics_GetEigenvectors_10(HandleRef pThis, HandleRef eigenvectors);

		/// <summary>
		/// Get the eigenvectors. The eigenvectors are ordered according to the magnitude of their
		/// associated eigenvalues, sorted from largest to smallest. That is, eigenvector 0 corresponds
		/// to the largest eigenvalue.
		/// This function:
		/// void GetEigenvectors(int request, vtkDoubleArray* eigenvectors)
		/// does all of the work. The other functions are convenience functions that call this function
		/// with default arguments. These functions are not valid unless Update() has been called and the
		/// Derive option is turned on.
		/// </summary>
		// Token: 0x060136AE RID: 79534 RVA: 0x001B78F8 File Offset: 0x001B5AF8
		public void GetEigenvectors(vtkDoubleArray eigenvectors)
		{
			vtkPCAStatistics.vtkPCAStatistics_GetEigenvectors_10(base.GetCppThis(), (eigenvectors == null) ? default(HandleRef) : eigenvectors.GetCppThis());
		}

		// Token: 0x060136AF RID: 79535
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPCAStatistics_GetFixedBasisEnergy_11(HandleRef pThis);

		/// <summary>
		/// The minimum energy the new basis should use, as a fraction. See SetBasisScheme() for more
		/// information. When FixedBasisEnergy &gt;= 1 (the default), the fixed basis energy scheme is
		/// equivalent to the full basis scheme.
		/// </summary>
		// Token: 0x060136B0 RID: 79536 RVA: 0x001B7928 File Offset: 0x001B5B28
		public virtual double GetFixedBasisEnergy()
		{
			return vtkPCAStatistics.vtkPCAStatistics_GetFixedBasisEnergy_11(base.GetCppThis());
		}

		// Token: 0x060136B1 RID: 79537
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPCAStatistics_GetFixedBasisEnergyMaxValue_12(HandleRef pThis);

		/// <summary>
		/// The minimum energy the new basis should use, as a fraction. See SetBasisScheme() for more
		/// information. When FixedBasisEnergy &gt;= 1 (the default), the fixed basis energy scheme is
		/// equivalent to the full basis scheme.
		/// </summary>
		// Token: 0x060136B2 RID: 79538 RVA: 0x001B7948 File Offset: 0x001B5B48
		public virtual double GetFixedBasisEnergyMaxValue()
		{
			return vtkPCAStatistics.vtkPCAStatistics_GetFixedBasisEnergyMaxValue_12(base.GetCppThis());
		}

		// Token: 0x060136B3 RID: 79539
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPCAStatistics_GetFixedBasisEnergyMinValue_13(HandleRef pThis);

		/// <summary>
		/// The minimum energy the new basis should use, as a fraction. See SetBasisScheme() for more
		/// information. When FixedBasisEnergy &gt;= 1 (the default), the fixed basis energy scheme is
		/// equivalent to the full basis scheme.
		/// </summary>
		// Token: 0x060136B4 RID: 79540 RVA: 0x001B7968 File Offset: 0x001B5B68
		public virtual double GetFixedBasisEnergyMinValue()
		{
			return vtkPCAStatistics.vtkPCAStatistics_GetFixedBasisEnergyMinValue_13(base.GetCppThis());
		}

		// Token: 0x060136B5 RID: 79541
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPCAStatistics_GetFixedBasisSize_14(HandleRef pThis);

		/// <summary>
		/// The number of basis vectors to use. See SetBasisScheme() for more information.
		/// When FixedBasisSize &lt;= 0 (the default), the fixed basis size scheme is equivalent to the full
		/// basis scheme.
		/// </summary>
		// Token: 0x060136B6 RID: 79542 RVA: 0x001B7988 File Offset: 0x001B5B88
		public virtual int GetFixedBasisSize()
		{
			return vtkPCAStatistics.vtkPCAStatistics_GetFixedBasisSize_14(base.GetCppThis());
		}

		// Token: 0x060136B7 RID: 79543
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPCAStatistics_GetNormalizationScheme_15(HandleRef pThis);

		/// <summary>
		/// This determines how (or if) the covariance matrix \a cov is normalized before PCA.
		///
		/// When set to NONE, no normalization is performed. This is the default.
		///
		/// When set to TRIANGLE_SPECIFIED, each entry cov(i,j) is divided by V(i,j).
		/// The list V of normalization factors must be set using the SetNormalization method
		/// before the filter is executed.
		///
		/// When set to DIAGONAL_SPECIFIED, each entry cov(i,j) is divided by sqrt(V(i)*V(j)).
		/// The list V of normalization factors must be set using the SetNormalization method
		/// before the filter is executed.
		///
		/// When set to DIAGONAL_VARIANCE, each entry cov(i,j) is divided by sqrt(cov(i,i)*cov(j,j)).
		/// &lt;b&gt;Warning&lt;/b&gt;: Although this is accepted practice in some fields,
		/// some people think you should not turn this option on unless there
		/// is a good physically-based reason for doing so. Much better instead
		/// to determine how component magnitudes should be compared using
		/// physical reasoning and use DIAGONAL_SPECIFIED, TRIANGLE_SPECIFIED, or
		/// perform some pre-processing to shift and scale input data columns
		/// appropriately than to expect magical results from a shady normalization hack.
		/// </summary>
		// Token: 0x060136B8 RID: 79544 RVA: 0x001B79A8 File Offset: 0x001B5BA8
		public virtual int GetNormalizationScheme()
		{
			return vtkPCAStatistics.vtkPCAStatistics_GetNormalizationScheme_15(base.GetCppThis());
		}

		// Token: 0x060136B9 RID: 79545
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPCAStatistics_GetNormalizationSchemeName_16(HandleRef pThis, int scheme);

		/// <summary>
		/// This determines how (or if) the covariance matrix \a cov is normalized before PCA.
		///
		/// When set to NONE, no normalization is performed. This is the default.
		///
		/// When set to TRIANGLE_SPECIFIED, each entry cov(i,j) is divided by V(i,j).
		/// The list V of normalization factors must be set using the SetNormalization method
		/// before the filter is executed.
		///
		/// When set to DIAGONAL_SPECIFIED, each entry cov(i,j) is divided by sqrt(V(i)*V(j)).
		/// The list V of normalization factors must be set using the SetNormalization method
		/// before the filter is executed.
		///
		/// When set to DIAGONAL_VARIANCE, each entry cov(i,j) is divided by sqrt(cov(i,i)*cov(j,j)).
		/// &lt;b&gt;Warning&lt;/b&gt;: Although this is accepted practice in some fields,
		/// some people think you should not turn this option on unless there
		/// is a good physically-based reason for doing so. Much better instead
		/// to determine how component magnitudes should be compared using
		/// physical reasoning and use DIAGONAL_SPECIFIED, TRIANGLE_SPECIFIED, or
		/// perform some pre-processing to shift and scale input data columns
		/// appropriately than to expect magical results from a shady normalization hack.
		/// </summary>
		// Token: 0x060136BA RID: 79546 RVA: 0x001B79C8 File Offset: 0x001B5BC8
		public virtual string GetNormalizationSchemeName(int scheme)
		{
			string s = Marshal.PtrToStringAnsi(vtkPCAStatistics.vtkPCAStatistics_GetNormalizationSchemeName_16(base.GetCppThis(), scheme));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060136BB RID: 79547
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPCAStatistics_GetNumberOfGenerationsFromBase_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060136BC RID: 79548 RVA: 0x001B7A04 File Offset: 0x001B5C04
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPCAStatistics.vtkPCAStatistics_GetNumberOfGenerationsFromBase_17(base.GetCppThis(), type);
		}

		// Token: 0x060136BD RID: 79549
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPCAStatistics_GetNumberOfGenerationsFromBaseType_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060136BE RID: 79550 RVA: 0x001B7A24 File Offset: 0x001B5C24
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPCAStatistics.vtkPCAStatistics_GetNumberOfGenerationsFromBaseType_18(type);
		}

		// Token: 0x060136BF RID: 79551
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPCAStatistics_GetSpecifiedNormalization_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// These methods allow you to set/get values used to normalize the covariance matrix before PCA.
		/// The normalization values apply to all requests, so you do not specify a single
		/// vector but a 3-column table.
		///
		/// The first two columns contain the names of columns from input 0 and the third column contains
		/// the value to normalize the corresponding entry in the covariance matrix.
		/// The table must always have 3 columns even when the NormalizationScheme is DIAGONAL_SPECIFIED.
		/// When only diagonal entries are to be used, only table rows where the first two columns are
		/// identical to one another will be employed.
		/// If there are multiple rows specifying different values for the same pair of columns,
		/// the entry nearest the bottom of the table takes precedence.
		///
		/// These functions are actually convenience methods that set/get the third input of the filter.
		/// Because the table is the third input, you may use other filters to produce a table of
		/// normalizations and have the pipeline take care of updates.
		///
		/// Any missing entries will be set to 1.0 and a warning issued.
		/// An error will occur if the third input to the filter is not set and the
		/// NormalizationScheme is DIAGONAL_SPECIFIED or TRIANGLE_SPECIFIED.
		///
		/// NOTE: SetSpecifiedNormalization( table ) is equivalent to SetInputData(3, table)
		/// and therefore does not make a pipeline connection.
		/// </summary>
		// Token: 0x060136C0 RID: 79552 RVA: 0x001B7A40 File Offset: 0x001B5C40
		public virtual vtkTable GetSpecifiedNormalization()
		{
			vtkTable vtkTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPCAStatistics.vtkPCAStatistics_GetSpecifiedNormalization_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTable = (vtkTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTable.Register(null);
				}
			}
			return vtkTable;
		}

		// Token: 0x060136C1 RID: 79553
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPCAStatistics_IsA_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060136C2 RID: 79554 RVA: 0x001B7AB0 File Offset: 0x001B5CB0
		public override int IsA(string type)
		{
			return vtkPCAStatistics.vtkPCAStatistics_IsA_20(base.GetCppThis(), type);
		}

		// Token: 0x060136C3 RID: 79555
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPCAStatistics_IsTypeOf_21([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060136C4 RID: 79556 RVA: 0x001B7AD0 File Offset: 0x001B5CD0
		public new static int IsTypeOf(string type)
		{
			return vtkPCAStatistics.vtkPCAStatistics_IsTypeOf_21(type);
		}

		// Token: 0x060136C5 RID: 79557
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPCAStatistics_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060136C6 RID: 79558 RVA: 0x001B7AEC File Offset: 0x001B5CEC
		public new vtkPCAStatistics NewInstance()
		{
			vtkPCAStatistics result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPCAStatistics.vtkPCAStatistics_NewInstance_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPCAStatistics)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060136C7 RID: 79559
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPCAStatistics_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060136C8 RID: 79560 RVA: 0x001B7B48 File Offset: 0x001B5D48
		public new static vtkPCAStatistics SafeDownCast(vtkObjectBase o)
		{
			vtkPCAStatistics vtkPCAStatistics = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPCAStatistics.vtkPCAStatistics_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPCAStatistics = (vtkPCAStatistics)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPCAStatistics.Register(null);
				}
			}
			return vtkPCAStatistics;
		}

		// Token: 0x060136C9 RID: 79561
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPCAStatistics_SetBasisScheme_25(HandleRef pThis, int _arg);

		/// <summary>
		/// This variable controls the dimensionality of output tuples in Assess operation.
		/// Consider the case where you have requested a PCA on D columns.
		///
		/// When set to vtkPCAStatistics::FULL_BASIS, the entire set of basis vectors
		/// is used to derive new coordinates for each tuple being assessed.
		/// In this mode, you are guaranteed to have output tuples of the same dimension
		/// as the input tuples. (That dimension is D, so there will be D additional
		/// columns added to the table for the request.)
		///
		/// When set to vtkPCAStatistics::FIXED_BASIS_SIZE, only the first N basis vectors
		/// are used to derive new coordinates for each tuple being assessed.
		/// In this mode, you are guaranteed to have output tuples of dimension min(N,D).
		/// You must set N prior to assessing data using the SetFixedBasisSize() method.
		/// When N &lt; D, this turns the PCA into a projection (instead of change of basis).
		///
		/// When set to vtkPCAStatistics::FIXED_BASIS_ENERGY, the number of basis vectors
		/// used to derive new coordinates for each tuple will be the minimum number
		/// of columns N that satisfy
		/// \f[
		/// \frac{\sum_{i=1}^{N} \lambda_i}{\sum_{i=1}^{D} \lambda_i} &lt; T
		/// \f]
		/// You must set T prior to assessing data using the SetFixedBasisEnergy() method.
		/// When T &lt; 1, this turns the PCA into a projection (instead of change of basis).
		///
		/// By default BasisScheme is set to vtkPCAStatistics::FULL_BASIS.
		/// </summary>
		// Token: 0x060136CA RID: 79562 RVA: 0x001B7BC7 File Offset: 0x001B5DC7
		public virtual void SetBasisScheme(int _arg)
		{
			vtkPCAStatistics.vtkPCAStatistics_SetBasisScheme_25(base.GetCppThis(), _arg);
		}

		// Token: 0x060136CB RID: 79563
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPCAStatistics_SetBasisSchemeByName_26(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string schemeName);

		/// <summary>
		/// This variable controls the dimensionality of output tuples in Assess operation.
		/// Consider the case where you have requested a PCA on D columns.
		///
		/// When set to vtkPCAStatistics::FULL_BASIS, the entire set of basis vectors
		/// is used to derive new coordinates for each tuple being assessed.
		/// In this mode, you are guaranteed to have output tuples of the same dimension
		/// as the input tuples. (That dimension is D, so there will be D additional
		/// columns added to the table for the request.)
		///
		/// When set to vtkPCAStatistics::FIXED_BASIS_SIZE, only the first N basis vectors
		/// are used to derive new coordinates for each tuple being assessed.
		/// In this mode, you are guaranteed to have output tuples of dimension min(N,D).
		/// You must set N prior to assessing data using the SetFixedBasisSize() method.
		/// When N &lt; D, this turns the PCA into a projection (instead of change of basis).
		///
		/// When set to vtkPCAStatistics::FIXED_BASIS_ENERGY, the number of basis vectors
		/// used to derive new coordinates for each tuple will be the minimum number
		/// of columns N that satisfy
		/// \f[
		/// \frac{\sum_{i=1}^{N} \lambda_i}{\sum_{i=1}^{D} \lambda_i} &lt; T
		/// \f]
		/// You must set T prior to assessing data using the SetFixedBasisEnergy() method.
		/// When T &lt; 1, this turns the PCA into a projection (instead of change of basis).
		///
		/// By default BasisScheme is set to vtkPCAStatistics::FULL_BASIS.
		/// </summary>
		// Token: 0x060136CC RID: 79564 RVA: 0x001B7BD7 File Offset: 0x001B5DD7
		public virtual void SetBasisSchemeByName(string schemeName)
		{
			vtkPCAStatistics.vtkPCAStatistics_SetBasisSchemeByName_26(base.GetCppThis(), schemeName);
		}

		// Token: 0x060136CD RID: 79565
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPCAStatistics_SetFixedBasisEnergy_27(HandleRef pThis, double _arg);

		/// <summary>
		/// The minimum energy the new basis should use, as a fraction. See SetBasisScheme() for more
		/// information. When FixedBasisEnergy &gt;= 1 (the default), the fixed basis energy scheme is
		/// equivalent to the full basis scheme.
		/// </summary>
		// Token: 0x060136CE RID: 79566 RVA: 0x001B7BE7 File Offset: 0x001B5DE7
		public virtual void SetFixedBasisEnergy(double _arg)
		{
			vtkPCAStatistics.vtkPCAStatistics_SetFixedBasisEnergy_27(base.GetCppThis(), _arg);
		}

		// Token: 0x060136CF RID: 79567
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPCAStatistics_SetFixedBasisSize_28(HandleRef pThis, int _arg);

		/// <summary>
		/// The number of basis vectors to use. See SetBasisScheme() for more information.
		/// When FixedBasisSize &lt;= 0 (the default), the fixed basis size scheme is equivalent to the full
		/// basis scheme.
		/// </summary>
		// Token: 0x060136D0 RID: 79568 RVA: 0x001B7BF7 File Offset: 0x001B5DF7
		public virtual void SetFixedBasisSize(int _arg)
		{
			vtkPCAStatistics.vtkPCAStatistics_SetFixedBasisSize_28(base.GetCppThis(), _arg);
		}

		// Token: 0x060136D1 RID: 79569
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPCAStatistics_SetNormalizationScheme_29(HandleRef pThis, int _arg);

		/// <summary>
		/// This determines how (or if) the covariance matrix \a cov is normalized before PCA.
		///
		/// When set to NONE, no normalization is performed. This is the default.
		///
		/// When set to TRIANGLE_SPECIFIED, each entry cov(i,j) is divided by V(i,j).
		/// The list V of normalization factors must be set using the SetNormalization method
		/// before the filter is executed.
		///
		/// When set to DIAGONAL_SPECIFIED, each entry cov(i,j) is divided by sqrt(V(i)*V(j)).
		/// The list V of normalization factors must be set using the SetNormalization method
		/// before the filter is executed.
		///
		/// When set to DIAGONAL_VARIANCE, each entry cov(i,j) is divided by sqrt(cov(i,i)*cov(j,j)).
		/// &lt;b&gt;Warning&lt;/b&gt;: Although this is accepted practice in some fields,
		/// some people think you should not turn this option on unless there
		/// is a good physically-based reason for doing so. Much better instead
		/// to determine how component magnitudes should be compared using
		/// physical reasoning and use DIAGONAL_SPECIFIED, TRIANGLE_SPECIFIED, or
		/// perform some pre-processing to shift and scale input data columns
		/// appropriately than to expect magical results from a shady normalization hack.
		/// </summary>
		// Token: 0x060136D2 RID: 79570 RVA: 0x001B7C07 File Offset: 0x001B5E07
		public virtual void SetNormalizationScheme(int _arg)
		{
			vtkPCAStatistics.vtkPCAStatistics_SetNormalizationScheme_29(base.GetCppThis(), _arg);
		}

		// Token: 0x060136D3 RID: 79571
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPCAStatistics_SetNormalizationSchemeByName_30(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string schemeName);

		/// <summary>
		/// This determines how (or if) the covariance matrix \a cov is normalized before PCA.
		///
		/// When set to NONE, no normalization is performed. This is the default.
		///
		/// When set to TRIANGLE_SPECIFIED, each entry cov(i,j) is divided by V(i,j).
		/// The list V of normalization factors must be set using the SetNormalization method
		/// before the filter is executed.
		///
		/// When set to DIAGONAL_SPECIFIED, each entry cov(i,j) is divided by sqrt(V(i)*V(j)).
		/// The list V of normalization factors must be set using the SetNormalization method
		/// before the filter is executed.
		///
		/// When set to DIAGONAL_VARIANCE, each entry cov(i,j) is divided by sqrt(cov(i,i)*cov(j,j)).
		/// &lt;b&gt;Warning&lt;/b&gt;: Although this is accepted practice in some fields,
		/// some people think you should not turn this option on unless there
		/// is a good physically-based reason for doing so. Much better instead
		/// to determine how component magnitudes should be compared using
		/// physical reasoning and use DIAGONAL_SPECIFIED, TRIANGLE_SPECIFIED, or
		/// perform some pre-processing to shift and scale input data columns
		/// appropriately than to expect magical results from a shady normalization hack.
		/// </summary>
		// Token: 0x060136D4 RID: 79572 RVA: 0x001B7C17 File Offset: 0x001B5E17
		public virtual void SetNormalizationSchemeByName(string schemeName)
		{
			vtkPCAStatistics.vtkPCAStatistics_SetNormalizationSchemeByName_30(base.GetCppThis(), schemeName);
		}

		// Token: 0x060136D5 RID: 79573
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPCAStatistics_SetParameter_31(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string parameter, int index, HandleRef value);

		/// <summary>
		/// A convenience method (in particular for access from other applications) to
		/// set parameter values.
		/// Return true if setting of requested parameter name was executed, false otherwise.
		/// </summary>
		// Token: 0x060136D6 RID: 79574 RVA: 0x001B7C28 File Offset: 0x001B5E28
		public override bool SetParameter(string parameter, int index, vtkVariant value)
		{
			return vtkPCAStatistics.vtkPCAStatistics_SetParameter_31(base.GetCppThis(), parameter, index, (value == null) ? default(HandleRef) : value.GetCppThis()) != 0;
		}

		// Token: 0x060136D7 RID: 79575
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPCAStatistics_SetSpecifiedNormalization_32(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// These methods allow you to set/get values used to normalize the covariance matrix before PCA.
		/// The normalization values apply to all requests, so you do not specify a single
		/// vector but a 3-column table.
		///
		/// The first two columns contain the names of columns from input 0 and the third column contains
		/// the value to normalize the corresponding entry in the covariance matrix.
		/// The table must always have 3 columns even when the NormalizationScheme is DIAGONAL_SPECIFIED.
		/// When only diagonal entries are to be used, only table rows where the first two columns are
		/// identical to one another will be employed.
		/// If there are multiple rows specifying different values for the same pair of columns,
		/// the entry nearest the bottom of the table takes precedence.
		///
		/// These functions are actually convenience methods that set/get the third input of the filter.
		/// Because the table is the third input, you may use other filters to produce a table of
		/// normalizations and have the pipeline take care of updates.
		///
		/// Any missing entries will be set to 1.0 and a warning issued.
		/// An error will occur if the third input to the filter is not set and the
		/// NormalizationScheme is DIAGONAL_SPECIFIED or TRIANGLE_SPECIFIED.
		///
		/// NOTE: SetSpecifiedNormalization( table ) is equivalent to SetInputData(3, table)
		/// and therefore does not make a pipeline connection.
		/// </summary>
		// Token: 0x060136D8 RID: 79576 RVA: 0x001B7C68 File Offset: 0x001B5E68
		public virtual void SetSpecifiedNormalization(vtkTable arg0)
		{
			vtkPCAStatistics.vtkPCAStatistics_SetSpecifiedNormalization_32(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400166C RID: 5740
		public new const string MRFullTypeName = "Kitware.VTK.vtkPCAStatistics";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400166D RID: 5741
		public new static readonly string MRClassNameKey = "class vtkPCAStatistics";

		/// <summary>
		/// Methods by which the covariance matrix may be normalized.
		/// </summary>
		// Token: 0x0200074E RID: 1870
		public enum NormalizationType
		{
			/// <summary>enum member</summary>
			// Token: 0x0400166F RID: 5743
			DIAGONAL_SPECIFIED = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001670 RID: 5744
			DIAGONAL_VARIANCE,
			/// <summary>enum member</summary>
			// Token: 0x04001671 RID: 5745
			NONE = 0,
			/// <summary>enum member</summary>
			// Token: 0x04001672 RID: 5746
			NUM_NORMALIZATION_SCHEMES = 4,
			/// <summary>enum member</summary>
			// Token: 0x04001673 RID: 5747
			TRIANGLE_SPECIFIED = 1
		}

		/// <summary>
		/// These are the enumeration values that SetBasisScheme() accepts and GetBasisScheme returns.
		/// </summary>
		// Token: 0x0200074F RID: 1871
		public enum ProjectionType
		{
			/// <summary>enum member</summary>
			// Token: 0x04001675 RID: 5749
			FIXED_BASIS_ENERGY = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001676 RID: 5750
			FIXED_BASIS_SIZE = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001677 RID: 5751
			FULL_BASIS = 0,
			/// <summary>enum member</summary>
			// Token: 0x04001678 RID: 5752
			NUM_BASIS_SCHEMES = 3
		}
	}
}
