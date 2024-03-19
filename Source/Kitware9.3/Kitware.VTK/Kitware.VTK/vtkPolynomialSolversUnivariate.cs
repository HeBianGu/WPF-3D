using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPolynomialSolversUnivariate
	/// </summary>
	/// <remarks>
	///    polynomial solvers
	///
	/// vtkPolynomialSolversUnivariate provides solvers for
	/// univariate polynomial equations with real coefficients.
	/// The Tartaglia-Cardan and Ferrari solvers work on polynomials of fixed
	/// degree 3 and 4, respectively.
	/// The Lin-Bairstow and Sturm solvers work on polynomials of arbitrary
	/// degree. The Sturm solver is the most robust solver but only reports
	/// roots within an interval and does not report multiplicities.
	/// The Lin-Bairstow solver reports multiplicities.
	///
	/// For difficult polynomials, you may wish to use FilterRoots to
	/// eliminate some of the roots reported by the Sturm solver.
	/// FilterRoots evaluates the derivatives near each root to
	/// eliminate cases where a local minimum or maximum is close
	/// to zero.
	///
	/// @par Thanks:
	/// Thanks to Philippe Pebay, Korben Rusek, David Thompson, and Maurice Rojas
	/// for implementing these solvers.
	/// </remarks>
	// Token: 0x02000B1D RID: 2845
	public class vtkPolynomialSolversUnivariate : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601DDC0 RID: 122304 RVA: 0x002A282D File Offset: 0x002A0A2D
		static vtkPolynomialSolversUnivariate()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolynomialSolversUnivariate.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolynomialSolversUnivariate"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601DDC1 RID: 122305 RVA: 0x002A2855 File Offset: 0x002A0A55
		public vtkPolynomialSolversUnivariate(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601DDC2 RID: 122306
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolynomialSolversUnivariate_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DDC3 RID: 122307 RVA: 0x002A2864 File Offset: 0x002A0A64
		public new static vtkPolynomialSolversUnivariate New()
		{
			vtkPolynomialSolversUnivariate result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolynomialSolversUnivariate.vtkPolynomialSolversUnivariate_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolynomialSolversUnivariate)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DDC4 RID: 122308 RVA: 0x002A28B8 File Offset: 0x002A0AB8
		public vtkPolynomialSolversUnivariate() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPolynomialSolversUnivariate.vtkPolynomialSolversUnivariate_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601DDC5 RID: 122309 RVA: 0x002A28FC File Offset: 0x002A0AFC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601DDC6 RID: 122310
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolynomialSolversUnivariate_FerrariSolve_01(IntPtr c, IntPtr r, IntPtr m, double tol);

		/// <summary>
		/// Algebraically extracts REAL roots of the quartic polynomial with
		/// REAL coefficients X^4 + c[0] X^3 + c[1] X^2 + c[2] X + c[3]
		/// and stores them (when they exist) and their respective multiplicities
		/// in the \a r and \a m arrays, based on Ferrari's method.
		/// Some numerical noise can be filtered by the use of a tolerance \a tol
		/// instead of equality with 0 (one can use, e.g., VTK_DBL_EPSILON).
		/// Returns the number of roots.
		/// Warning: it is the user's responsibility to pass a non-negative \a tol.
		/// </summary>
		// Token: 0x0601DDC7 RID: 122311 RVA: 0x002A2908 File Offset: 0x002A0B08
		public static int FerrariSolve(IntPtr c, IntPtr r, IntPtr m, double tol)
		{
			return vtkPolynomialSolversUnivariate.vtkPolynomialSolversUnivariate_FerrariSolve_01(c, r, m, tol);
		}

		// Token: 0x0601DDC8 RID: 122312
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolynomialSolversUnivariate_FilterRoots_02(IntPtr P, int d, IntPtr upperBnds, int rootcount, double diameter);

		/// <summary>
		/// This uses the derivative sequence to filter possible roots of a polynomial.
		/// First it sorts the roots and removes any duplicates.
		/// If the number of sign changes of the derivative sequence at a root at
		/// upperBnds[i] == that at upperBnds[i]  - diameter then the i^th value is
		/// removed from upperBnds. It returns the new number of roots.
		/// </summary>
		// Token: 0x0601DDC9 RID: 122313 RVA: 0x002A2928 File Offset: 0x002A0B28
		public static int FilterRoots(IntPtr P, int d, IntPtr upperBnds, int rootcount, double diameter)
		{
			return vtkPolynomialSolversUnivariate.vtkPolynomialSolversUnivariate_FilterRoots_02(P, d, upperBnds, rootcount, diameter);
		}

		// Token: 0x0601DDCA RID: 122314
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolynomialSolversUnivariate_GetDivisionTolerance_03();

		/// <summary>
		/// Set/get the tolerance used when performing polynomial Euclidean division
		/// to find polynomial roots. This tolerance is used to decide whether the
		/// coefficient(s) of a polynomial remainder are close enough to
		/// zero to be neglected.
		/// </summary>
		// Token: 0x0601DDCB RID: 122315 RVA: 0x002A2948 File Offset: 0x002A0B48
		public static double GetDivisionTolerance()
		{
			return vtkPolynomialSolversUnivariate.vtkPolynomialSolversUnivariate_GetDivisionTolerance_03();
		}

		// Token: 0x0601DDCC RID: 122316
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolynomialSolversUnivariate_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DDCD RID: 122317 RVA: 0x002A2964 File Offset: 0x002A0B64
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPolynomialSolversUnivariate.vtkPolynomialSolversUnivariate_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601DDCE RID: 122318
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolynomialSolversUnivariate_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DDCF RID: 122319 RVA: 0x002A2984 File Offset: 0x002A0B84
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPolynomialSolversUnivariate.vtkPolynomialSolversUnivariate_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601DDD0 RID: 122320
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolynomialSolversUnivariate_HabichtBisectionSolve_06(IntPtr P, int d, IntPtr a, IntPtr upperBnds, double tol);

		/// <summary>
		/// Finds all REAL roots (within tolerance \a tol) of the \a d -th degree polynomial
		/// \f[
		/// P[0] X^d + ... + P[d-1] X + P[d]
		/// \f]
		/// in ]\a a[0] ; \a a[1]] using the Habicht sequence (polynomial
		/// coefficients are REAL) and returns the count \a nr. All roots are bracketed
		/// in the \a nr first ]\a upperBnds[i] - \a tol ; \a upperBnds[i]] intervals.
		/// Returns -1 if anything went wrong (such as: polynomial does not have
		/// degree \a d, the interval provided by the other is absurd, etc.).
		///
		/// \a intervalType specifies the search interval as follows:
		/// 0 = 00 = ]a,b[
		/// 1 = 10 = [a,b[
		/// 2 = 01 = ]a,b]
		/// 3 = 11 = [a,b]
		/// This defaults to 0.
		///
		/// The last non-zero item in the Habicht sequence is the gcd of P and P'. The
		/// parameter divideGCD specifies whether the program should attempt to divide
		/// by the gcd and run again. It works better with polynomials known to have
		/// high multiplicities. When divideGCD != 0 then it attempts to divide by the
		/// GCD, if applicable. This defaults to 0.
		///
		/// Compared to the Sturm solver the Habicht solver is slower,
		/// although both are O(d^2). The Habicht solver has the added benefit
		/// that it has a built in mechanism to keep the leading coefficients of the
		/// result from polynomial division bounded above and below in absolute value.
		/// This will tend to keep the coefficients of the polynomials in the sequence
		/// from zeroing out prematurely or becoming infinite.
		///
		/// Constructing the Habicht sequence is O(d^2) in both time and space.
		///
		/// Warning: it is the user's responsibility to make sure the \a upperBnds
		/// array is large enough to contain the maximal number of expected roots.
		/// Note that \a nr is smaller or equal to the actual number of roots in
		/// ]\a a[0] ; \a a[1]] since roots within \a tol are lumped in the same bracket.
		/// array is large enough to contain the maximal number of expected upper bounds.
		/// </summary>
		// Token: 0x0601DDD1 RID: 122321 RVA: 0x002A29A0 File Offset: 0x002A0BA0
		public static int HabichtBisectionSolve(IntPtr P, int d, IntPtr a, IntPtr upperBnds, double tol)
		{
			return vtkPolynomialSolversUnivariate.vtkPolynomialSolversUnivariate_HabichtBisectionSolve_06(P, d, a, upperBnds, tol);
		}

		// Token: 0x0601DDD2 RID: 122322
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolynomialSolversUnivariate_HabichtBisectionSolve_07(IntPtr P, int d, IntPtr a, IntPtr upperBnds, double tol, int intervalType);

		/// <summary>
		/// Finds all REAL roots (within tolerance \a tol) of the \a d -th degree polynomial
		/// \f[
		/// P[0] X^d + ... + P[d-1] X + P[d]
		/// \f]
		/// in ]\a a[0] ; \a a[1]] using the Habicht sequence (polynomial
		/// coefficients are REAL) and returns the count \a nr. All roots are bracketed
		/// in the \a nr first ]\a upperBnds[i] - \a tol ; \a upperBnds[i]] intervals.
		/// Returns -1 if anything went wrong (such as: polynomial does not have
		/// degree \a d, the interval provided by the other is absurd, etc.).
		///
		/// \a intervalType specifies the search interval as follows:
		/// 0 = 00 = ]a,b[
		/// 1 = 10 = [a,b[
		/// 2 = 01 = ]a,b]
		/// 3 = 11 = [a,b]
		/// This defaults to 0.
		///
		/// The last non-zero item in the Habicht sequence is the gcd of P and P'. The
		/// parameter divideGCD specifies whether the program should attempt to divide
		/// by the gcd and run again. It works better with polynomials known to have
		/// high multiplicities. When divideGCD != 0 then it attempts to divide by the
		/// GCD, if applicable. This defaults to 0.
		///
		/// Compared to the Sturm solver the Habicht solver is slower,
		/// although both are O(d^2). The Habicht solver has the added benefit
		/// that it has a built in mechanism to keep the leading coefficients of the
		/// result from polynomial division bounded above and below in absolute value.
		/// This will tend to keep the coefficients of the polynomials in the sequence
		/// from zeroing out prematurely or becoming infinite.
		///
		/// Constructing the Habicht sequence is O(d^2) in both time and space.
		///
		/// Warning: it is the user's responsibility to make sure the \a upperBnds
		/// array is large enough to contain the maximal number of expected roots.
		/// Note that \a nr is smaller or equal to the actual number of roots in
		/// ]\a a[0] ; \a a[1]] since roots within \a tol are lumped in the same bracket.
		/// array is large enough to contain the maximal number of expected upper bounds.
		/// </summary>
		// Token: 0x0601DDD3 RID: 122323 RVA: 0x002A29C0 File Offset: 0x002A0BC0
		public static int HabichtBisectionSolve(IntPtr P, int d, IntPtr a, IntPtr upperBnds, double tol, int intervalType)
		{
			return vtkPolynomialSolversUnivariate.vtkPolynomialSolversUnivariate_HabichtBisectionSolve_07(P, d, a, upperBnds, tol, intervalType);
		}

		// Token: 0x0601DDD4 RID: 122324
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolynomialSolversUnivariate_HabichtBisectionSolve_08(IntPtr P, int d, IntPtr a, IntPtr upperBnds, double tol, int intervalType, byte divideGCD);

		/// <summary>
		/// Finds all REAL roots (within tolerance \a tol) of the \a d -th degree polynomial
		/// \f[
		/// P[0] X^d + ... + P[d-1] X + P[d]
		/// \f]
		/// in ]\a a[0] ; \a a[1]] using the Habicht sequence (polynomial
		/// coefficients are REAL) and returns the count \a nr. All roots are bracketed
		/// in the \a nr first ]\a upperBnds[i] - \a tol ; \a upperBnds[i]] intervals.
		/// Returns -1 if anything went wrong (such as: polynomial does not have
		/// degree \a d, the interval provided by the other is absurd, etc.).
		///
		/// \a intervalType specifies the search interval as follows:
		/// 0 = 00 = ]a,b[
		/// 1 = 10 = [a,b[
		/// 2 = 01 = ]a,b]
		/// 3 = 11 = [a,b]
		/// This defaults to 0.
		///
		/// The last non-zero item in the Habicht sequence is the gcd of P and P'. The
		/// parameter divideGCD specifies whether the program should attempt to divide
		/// by the gcd and run again. It works better with polynomials known to have
		/// high multiplicities. When divideGCD != 0 then it attempts to divide by the
		/// GCD, if applicable. This defaults to 0.
		///
		/// Compared to the Sturm solver the Habicht solver is slower,
		/// although both are O(d^2). The Habicht solver has the added benefit
		/// that it has a built in mechanism to keep the leading coefficients of the
		/// result from polynomial division bounded above and below in absolute value.
		/// This will tend to keep the coefficients of the polynomials in the sequence
		/// from zeroing out prematurely or becoming infinite.
		///
		/// Constructing the Habicht sequence is O(d^2) in both time and space.
		///
		/// Warning: it is the user's responsibility to make sure the \a upperBnds
		/// array is large enough to contain the maximal number of expected roots.
		/// Note that \a nr is smaller or equal to the actual number of roots in
		/// ]\a a[0] ; \a a[1]] since roots within \a tol are lumped in the same bracket.
		/// array is large enough to contain the maximal number of expected upper bounds.
		/// </summary>
		// Token: 0x0601DDD5 RID: 122325 RVA: 0x002A29E4 File Offset: 0x002A0BE4
		public static int HabichtBisectionSolve(IntPtr P, int d, IntPtr a, IntPtr upperBnds, double tol, int intervalType, bool divideGCD)
		{
			return vtkPolynomialSolversUnivariate.vtkPolynomialSolversUnivariate_HabichtBisectionSolve_08(P, d, a, upperBnds, tol, intervalType, divideGCD ? (byte)1 : (byte)0);
		}

		// Token: 0x0601DDD6 RID: 122326
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolynomialSolversUnivariate_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DDD7 RID: 122327 RVA: 0x002A2A10 File Offset: 0x002A0C10
		public override int IsA(string type)
		{
			return vtkPolynomialSolversUnivariate.vtkPolynomialSolversUnivariate_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x0601DDD8 RID: 122328
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolynomialSolversUnivariate_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DDD9 RID: 122329 RVA: 0x002A2A30 File Offset: 0x002A0C30
		public new static int IsTypeOf(string type)
		{
			return vtkPolynomialSolversUnivariate.vtkPolynomialSolversUnivariate_IsTypeOf_10(type);
		}

		// Token: 0x0601DDDA RID: 122330
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolynomialSolversUnivariate_LinBairstowSolve_11(IntPtr c, int d, IntPtr r, ref double tolerance);

		/// <summary>
		/// Seeks all REAL roots of the \a d -th degree polynomial
		/// c[0] X^d + ... + c[d-1] X + c[d] = 0
		/// equation Lin-Bairstow's method ( polynomial coefficients are REAL ) and
		/// stores the \a nr roots found ( multiple roots are multiply stored ) in \a r.
		/// \a tolerance is the user-defined solver tolerance; this variable may be
		/// relaxed by the iterative solver if needed.
		/// Returns \a nr.
		/// Warning: it is the user's responsibility to make sure the \a r
		/// array is large enough to contain the maximal number of expected roots.
		/// </summary>
		// Token: 0x0601DDDB RID: 122331 RVA: 0x002A2A4C File Offset: 0x002A0C4C
		public static int LinBairstowSolve(IntPtr c, int d, IntPtr r, ref double tolerance)
		{
			return vtkPolynomialSolversUnivariate.vtkPolynomialSolversUnivariate_LinBairstowSolve_11(c, d, r, ref tolerance);
		}

		// Token: 0x0601DDDC RID: 122332
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolynomialSolversUnivariate_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DDDD RID: 122333 RVA: 0x002A2A6C File Offset: 0x002A0C6C
		public new vtkPolynomialSolversUnivariate NewInstance()
		{
			vtkPolynomialSolversUnivariate result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolynomialSolversUnivariate.vtkPolynomialSolversUnivariate_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolynomialSolversUnivariate)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601DDDE RID: 122334
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolynomialSolversUnivariate_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DDDF RID: 122335 RVA: 0x002A2AC8 File Offset: 0x002A0CC8
		public new static vtkPolynomialSolversUnivariate SafeDownCast(vtkObjectBase o)
		{
			vtkPolynomialSolversUnivariate vtkPolynomialSolversUnivariate = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolynomialSolversUnivariate.vtkPolynomialSolversUnivariate_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolynomialSolversUnivariate = (vtkPolynomialSolversUnivariate)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolynomialSolversUnivariate.Register(null);
				}
			}
			return vtkPolynomialSolversUnivariate;
		}

		// Token: 0x0601DDE0 RID: 122336
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolynomialSolversUnivariate_SetDivisionTolerance_15(double tol);

		/// <summary>
		/// Set/get the tolerance used when performing polynomial Euclidean division
		/// to find polynomial roots. This tolerance is used to decide whether the
		/// coefficient(s) of a polynomial remainder are close enough to
		/// zero to be neglected.
		/// </summary>
		// Token: 0x0601DDE1 RID: 122337 RVA: 0x002A2B47 File Offset: 0x002A0D47
		public static void SetDivisionTolerance(double tol)
		{
			vtkPolynomialSolversUnivariate.vtkPolynomialSolversUnivariate_SetDivisionTolerance_15(tol);
		}

		// Token: 0x0601DDE2 RID: 122338
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolynomialSolversUnivariate_SolveCubic_16(double c0, double c1, double c2, double c3);

		/// <summary>
		/// Solves a cubic equation c0*t^3 + c1*t^2 + c2*t + c3 = 0 when c0, c1, c2,
		/// and c3 are REAL.  Solution is motivated by Numerical Recipes In C 2nd
		/// Ed.  Return array contains number of (real) roots (counting multiple
		/// roots as one) followed by roots themselves. The value in roots[4] is a
		/// integer giving further information about the roots (see return codes for
		/// int SolveCubic() ).
		/// </summary>
		// Token: 0x0601DDE3 RID: 122339 RVA: 0x002A2B54 File Offset: 0x002A0D54
		public static IntPtr SolveCubic(double c0, double c1, double c2, double c3)
		{
			return vtkPolynomialSolversUnivariate.vtkPolynomialSolversUnivariate_SolveCubic_16(c0, c1, c2, c3);
		}

		// Token: 0x0601DDE4 RID: 122340
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolynomialSolversUnivariate_SolveCubic_17(double c0, double c1, double c2, double c3, IntPtr r1, IntPtr r2, IntPtr r3, IntPtr num_roots);

		/// <summary>
		/// Solves a cubic equation when c0, c1, c2, And c3 Are REAL.  Solution
		/// is motivated by Numerical Recipes In C 2nd Ed.  Roots and number of
		/// real roots are stored in user provided variables r1, r2, r3, and
		/// num_roots. Note that the function can return the following integer
		/// values describing the roots: (0)-no solution; (-1)-infinite number
		/// of solutions; (1)-one distinct real root of multiplicity 3 (stored
		/// in r1); (2)-two distinct real roots, one of multiplicity 2 (stored
		/// in r1 &amp; r2); (3)-three distinct real roots; (-2)-quadratic equation
		/// with complex conjugate solution (real part of root returned in r1,
		/// imaginary in r2); (-3)-one real root and a complex conjugate pair
		/// (real root in r1 and real part of pair in r2 and imaginary in r3).
		/// </summary>
		// Token: 0x0601DDE5 RID: 122341 RVA: 0x002A2B74 File Offset: 0x002A0D74
		public static int SolveCubic(double c0, double c1, double c2, double c3, IntPtr r1, IntPtr r2, IntPtr r3, IntPtr num_roots)
		{
			return vtkPolynomialSolversUnivariate.vtkPolynomialSolversUnivariate_SolveCubic_17(c0, c1, c2, c3, r1, r2, r3, num_roots);
		}

		// Token: 0x0601DDE6 RID: 122342
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolynomialSolversUnivariate_SolveLinear_18(double c0, double c1);

		/// <summary>
		/// Solves a linear equation c0*t  + c1 = 0 when c0 and c1 are REAL.
		/// Solution is motivated by Numerical Recipes In C 2nd Ed.
		/// Return array contains number of roots followed by roots themselves.
		/// </summary>
		// Token: 0x0601DDE7 RID: 122343 RVA: 0x002A2B9C File Offset: 0x002A0D9C
		public static IntPtr SolveLinear(double c0, double c1)
		{
			return vtkPolynomialSolversUnivariate.vtkPolynomialSolversUnivariate_SolveLinear_18(c0, c1);
		}

		// Token: 0x0601DDE8 RID: 122344
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolynomialSolversUnivariate_SolveLinear_19(double c0, double c1, IntPtr r1, IntPtr num_roots);

		/// <summary>
		/// Solves a linear equation c0*t + c1 = 0 when c0 and c1 are REAL.
		/// Solution is motivated by Numerical Recipes In C 2nd Ed.
		/// Root and number of (real) roots are stored in user provided variables
		/// r1 and num_roots.
		/// </summary>
		// Token: 0x0601DDE9 RID: 122345 RVA: 0x002A2BB8 File Offset: 0x002A0DB8
		public static int SolveLinear(double c0, double c1, IntPtr r1, IntPtr num_roots)
		{
			return vtkPolynomialSolversUnivariate.vtkPolynomialSolversUnivariate_SolveLinear_19(c0, c1, r1, num_roots);
		}

		// Token: 0x0601DDEA RID: 122346
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolynomialSolversUnivariate_SolveQuadratic_20(double c0, double c1, double c2);

		/// <summary>
		/// Solves a quadratic equation c0*t^2 + c1*t + c2 = 0 when c0, c1, and c2
		/// are REAL.  Solution is motivated by Numerical Recipes In C 2nd Ed.
		/// Return array contains number of (real) roots (counting multiple roots as
		/// one) followed by roots themselves. Note that roots[3] contains a return
		/// code further describing solution - see documentation for SolveCubic()
		/// for meaning of return codes.
		/// </summary>
		// Token: 0x0601DDEB RID: 122347 RVA: 0x002A2BD8 File Offset: 0x002A0DD8
		public static IntPtr SolveQuadratic(double c0, double c1, double c2)
		{
			return vtkPolynomialSolversUnivariate.vtkPolynomialSolversUnivariate_SolveQuadratic_20(c0, c1, c2);
		}

		// Token: 0x0601DDEC RID: 122348
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolynomialSolversUnivariate_SolveQuadratic_21(double c0, double c1, double c2, IntPtr r1, IntPtr r2, IntPtr num_roots);

		/// <summary>
		/// Solves a quadratic equation c0*t^2  + c1*t  + c2 = 0 when
		/// c0, c1, and c2 are REAL.
		/// Solution is motivated by Numerical Recipes In C 2nd Ed.
		/// Roots and number of roots are stored in user provided variables
		/// r1, r2, num_roots
		/// </summary>
		// Token: 0x0601DDED RID: 122349 RVA: 0x002A2BF4 File Offset: 0x002A0DF4
		public static int SolveQuadratic(double c0, double c1, double c2, IntPtr r1, IntPtr r2, IntPtr num_roots)
		{
			return vtkPolynomialSolversUnivariate.vtkPolynomialSolversUnivariate_SolveQuadratic_21(c0, c1, c2, r1, r2, num_roots);
		}

		// Token: 0x0601DDEE RID: 122350
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolynomialSolversUnivariate_SolveQuadratic_22(IntPtr c, IntPtr r, IntPtr m);

		/// <summary>
		/// Algebraically extracts REAL roots of the quadratic polynomial with
		/// REAL coefficients c[0] X^2 + c[1] X + c[2]
		/// and stores them (when they exist) and their respective multiplicities
		/// in the \a r and \a m arrays.
		/// Returns either the number of roots, or -1 if ininite number of roots.
		/// </summary>
		// Token: 0x0601DDEF RID: 122351 RVA: 0x002A2C18 File Offset: 0x002A0E18
		public static int SolveQuadratic(IntPtr c, IntPtr r, IntPtr m)
		{
			return vtkPolynomialSolversUnivariate.vtkPolynomialSolversUnivariate_SolveQuadratic_22(c, r, m);
		}

		// Token: 0x0601DDF0 RID: 122352
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolynomialSolversUnivariate_SturmBisectionSolve_23(IntPtr P, int d, IntPtr a, IntPtr upperBnds, double tol);

		/// <summary>
		/// Finds all REAL roots (within tolerance \a tol) of the \a d -th degree polynomial
		/// P[0] X^d + ... + P[d-1] X + P[d]
		/// in ]\a a[0] ; \a a[1]] using Sturm's theorem ( polynomial
		/// coefficients are REAL ) and returns the count \a nr. All roots are bracketed
		/// in the \a nr first ]\a upperBnds[i] - \a tol ; \a upperBnds[i]] intervals.
		/// Returns -1 if anything went wrong (such as: polynomial does not have
		/// degree \a d, the interval provided by the other is absurd, etc.).
		///
		/// intervalType specifies the search interval as follows:
		/// 0 = 00 = ]a,b[
		/// 1 = 10 = [a,b[
		/// 2 = 01 = ]a,b]
		/// 3 = 11 = [a,b]
		/// This defaults to 0.
		///
		/// The last non-zero item in the Sturm sequence is the gcd of P and P'. The
		/// parameter divideGCD specifies whether the program should attempt to divide
		/// by the gcd and run again. It works better with polynomials known to have
		/// high multiplicities. When divideGCD != 0 then it attempts to divide by the
		/// GCD, if applicable. This defaults to 0.
		///
		/// Constructing the Sturm sequence is O(d^2) in both time and space.
		///
		/// Warning: it is the user's responsibility to make sure the \a upperBnds
		/// array is large enough to contain the maximal number of expected roots.
		/// Note that \a nr is smaller or equal to the actual number of roots in
		/// ]\a a[0] ; \a a[1]] since roots within \a tol are lumped in the same bracket.
		/// array is large enough to contain the maximal number of expected upper bounds.
		/// </summary>
		// Token: 0x0601DDF1 RID: 122353 RVA: 0x002A2C34 File Offset: 0x002A0E34
		public static int SturmBisectionSolve(IntPtr P, int d, IntPtr a, IntPtr upperBnds, double tol)
		{
			return vtkPolynomialSolversUnivariate.vtkPolynomialSolversUnivariate_SturmBisectionSolve_23(P, d, a, upperBnds, tol);
		}

		// Token: 0x0601DDF2 RID: 122354
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolynomialSolversUnivariate_SturmBisectionSolve_24(IntPtr P, int d, IntPtr a, IntPtr upperBnds, double tol, int intervalType);

		/// <summary>
		/// Finds all REAL roots (within tolerance \a tol) of the \a d -th degree polynomial
		/// P[0] X^d + ... + P[d-1] X + P[d]
		/// in ]\a a[0] ; \a a[1]] using Sturm's theorem ( polynomial
		/// coefficients are REAL ) and returns the count \a nr. All roots are bracketed
		/// in the \a nr first ]\a upperBnds[i] - \a tol ; \a upperBnds[i]] intervals.
		/// Returns -1 if anything went wrong (such as: polynomial does not have
		/// degree \a d, the interval provided by the other is absurd, etc.).
		///
		/// intervalType specifies the search interval as follows:
		/// 0 = 00 = ]a,b[
		/// 1 = 10 = [a,b[
		/// 2 = 01 = ]a,b]
		/// 3 = 11 = [a,b]
		/// This defaults to 0.
		///
		/// The last non-zero item in the Sturm sequence is the gcd of P and P'. The
		/// parameter divideGCD specifies whether the program should attempt to divide
		/// by the gcd and run again. It works better with polynomials known to have
		/// high multiplicities. When divideGCD != 0 then it attempts to divide by the
		/// GCD, if applicable. This defaults to 0.
		///
		/// Constructing the Sturm sequence is O(d^2) in both time and space.
		///
		/// Warning: it is the user's responsibility to make sure the \a upperBnds
		/// array is large enough to contain the maximal number of expected roots.
		/// Note that \a nr is smaller or equal to the actual number of roots in
		/// ]\a a[0] ; \a a[1]] since roots within \a tol are lumped in the same bracket.
		/// array is large enough to contain the maximal number of expected upper bounds.
		/// </summary>
		// Token: 0x0601DDF3 RID: 122355 RVA: 0x002A2C54 File Offset: 0x002A0E54
		public static int SturmBisectionSolve(IntPtr P, int d, IntPtr a, IntPtr upperBnds, double tol, int intervalType)
		{
			return vtkPolynomialSolversUnivariate.vtkPolynomialSolversUnivariate_SturmBisectionSolve_24(P, d, a, upperBnds, tol, intervalType);
		}

		// Token: 0x0601DDF4 RID: 122356
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolynomialSolversUnivariate_SturmBisectionSolve_25(IntPtr P, int d, IntPtr a, IntPtr upperBnds, double tol, int intervalType, byte divideGCD);

		/// <summary>
		/// Finds all REAL roots (within tolerance \a tol) of the \a d -th degree polynomial
		/// P[0] X^d + ... + P[d-1] X + P[d]
		/// in ]\a a[0] ; \a a[1]] using Sturm's theorem ( polynomial
		/// coefficients are REAL ) and returns the count \a nr. All roots are bracketed
		/// in the \a nr first ]\a upperBnds[i] - \a tol ; \a upperBnds[i]] intervals.
		/// Returns -1 if anything went wrong (such as: polynomial does not have
		/// degree \a d, the interval provided by the other is absurd, etc.).
		///
		/// intervalType specifies the search interval as follows:
		/// 0 = 00 = ]a,b[
		/// 1 = 10 = [a,b[
		/// 2 = 01 = ]a,b]
		/// 3 = 11 = [a,b]
		/// This defaults to 0.
		///
		/// The last non-zero item in the Sturm sequence is the gcd of P and P'. The
		/// parameter divideGCD specifies whether the program should attempt to divide
		/// by the gcd and run again. It works better with polynomials known to have
		/// high multiplicities. When divideGCD != 0 then it attempts to divide by the
		/// GCD, if applicable. This defaults to 0.
		///
		/// Constructing the Sturm sequence is O(d^2) in both time and space.
		///
		/// Warning: it is the user's responsibility to make sure the \a upperBnds
		/// array is large enough to contain the maximal number of expected roots.
		/// Note that \a nr is smaller or equal to the actual number of roots in
		/// ]\a a[0] ; \a a[1]] since roots within \a tol are lumped in the same bracket.
		/// array is large enough to contain the maximal number of expected upper bounds.
		/// </summary>
		// Token: 0x0601DDF5 RID: 122357 RVA: 0x002A2C78 File Offset: 0x002A0E78
		public static int SturmBisectionSolve(IntPtr P, int d, IntPtr a, IntPtr upperBnds, double tol, int intervalType, bool divideGCD)
		{
			return vtkPolynomialSolversUnivariate.vtkPolynomialSolversUnivariate_SturmBisectionSolve_25(P, d, a, upperBnds, tol, intervalType, divideGCD ? (byte)1 : (byte)0);
		}

		// Token: 0x0601DDF6 RID: 122358
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolynomialSolversUnivariate_TartagliaCardanSolve_26(IntPtr c, IntPtr r, IntPtr m, double tol);

		/// <summary>
		/// Algebraically extracts REAL roots of the cubic polynomial with
		/// REAL coefficients X^3 + c[0] X^2 + c[1] X + c[2]
		/// and stores them (when they exist) and their respective multiplicities
		/// in the \a r and \a m arrays.
		/// Some numerical noise can be filtered by the use of a tolerance \a tol
		/// instead of equality with 0 (one can use, e.g., VTK_DBL_EPSILON).
		/// The main differences with SolveCubic are that (1) the polynomial must have
		/// unit leading coefficient, (2) complex roots are discarded upfront,
		/// (3) non-simple roots are stored only once, along with their respective
		/// multiplicities, and (4) some numerical noise is filtered by the use of
		/// relative tolerance instead of equality with 0.
		/// Returns the number of roots.
		/// &lt;i&gt; In memoriam &lt;/i&gt; Niccolo Tartaglia (1500 - 1559), unfairly forgotten.
		/// </summary>
		// Token: 0x0601DDF7 RID: 122359 RVA: 0x002A2CA4 File Offset: 0x002A0EA4
		public static int TartagliaCardanSolve(IntPtr c, IntPtr r, IntPtr m, double tol)
		{
			return vtkPolynomialSolversUnivariate.vtkPolynomialSolversUnivariate_TartagliaCardanSolve_26(c, r, m, tol);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F7B RID: 8059
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolynomialSolversUnivariate";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F7C RID: 8060
		public new static readonly string MRClassNameKey = "class vtkPolynomialSolversUnivariate";
	}
}
