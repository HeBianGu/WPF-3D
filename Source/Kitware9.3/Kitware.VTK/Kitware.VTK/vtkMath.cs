using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMath
	/// </summary>
	/// <remarks>
	///    performs common math operations
	///
	/// vtkMath provides methods to perform common math operations. These
	/// include providing constants such as Pi; conversion from degrees to
	/// radians; vector operations such as dot and cross products and vector
	/// norm; matrix determinant for 2x2 and 3x3 matrices; univariate polynomial
	/// solvers; and for random number generation (for backward compatibility only).
	/// </remarks>
	/// <seealso>
	///
	/// vtkMinimalStandardRandomSequence, vtkBoxMuellerRandomSequence,
	/// vtkQuaternion
	/// </seealso>
	// Token: 0x02000B6D RID: 2925
	public class vtkMath : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E88C RID: 125068 RVA: 0x002B53B7 File Offset: 0x002B35B7
		static vtkMath()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMath.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMath"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E88D RID: 125069 RVA: 0x002B53DF File Offset: 0x002B35DF
		public vtkMath(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601E88E RID: 125070
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMath_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E88F RID: 125071 RVA: 0x002B53F0 File Offset: 0x002B35F0
		public new static vtkMath New()
		{
			vtkMath result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMath.vtkMath_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMath)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E890 RID: 125072 RVA: 0x002B5444 File Offset: 0x002B3644
		public vtkMath() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMath.vtkMath_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E891 RID: 125073 RVA: 0x002B5488 File Offset: 0x002B3688
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E892 RID: 125074
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMath_Add_01(IntPtr a, IntPtr b, IntPtr c);

		/// <summary>
		/// Addition of two 3-vectors (float version). Result is stored in c according to c = a + b.
		/// </summary>
		// Token: 0x0601E893 RID: 125075 RVA: 0x002B5493 File Offset: 0x002B3693
		public static void Add(IntPtr a, IntPtr b, IntPtr c)
		{
			vtkMath.vtkMath_Add_01(a, b, c);
		}

		// Token: 0x0601E894 RID: 125076
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMath_AngleBetweenVectors_02(IntPtr v1, IntPtr v2);

		/// <summary>
		/// Compute angle in radians between two vectors.
		/// </summary>
		// Token: 0x0601E895 RID: 125077 RVA: 0x002B54A0 File Offset: 0x002B36A0
		public static double AngleBetweenVectors(IntPtr v1, IntPtr v2)
		{
			return vtkMath.vtkMath_AngleBetweenVectors_02(v1, v2);
		}

		// Token: 0x0601E896 RID: 125078
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMath_AreBoundsInitialized_03(IntPtr bounds);

		/// <summary>
		/// Are the bounds initialized?
		/// </summary>
		// Token: 0x0601E897 RID: 125079 RVA: 0x002B54BC File Offset: 0x002B36BC
		public static int AreBoundsInitialized(IntPtr bounds)
		{
			return vtkMath.vtkMath_AreBoundsInitialized_03(bounds);
		}

		// Token: 0x0601E898 RID: 125080
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMath_Assign_04(IntPtr a, IntPtr b);

		/// <summary>
		/// Assign values to a 3-vector (double version). Result is stored in b according to b = a.
		/// </summary>
		// Token: 0x0601E899 RID: 125081 RVA: 0x002B54D6 File Offset: 0x002B36D6
		public static void Assign(IntPtr a, IntPtr b)
		{
			vtkMath.vtkMath_Assign_04(a, b);
		}

		// Token: 0x0601E89A RID: 125082
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMath_BeginCombination_05(int m, int n);

		/// <summary>
		/// Start iterating over "m choose n" objects.
		/// This function returns an array of n integers, each from 0 to m-1.
		/// These integers represent the n items chosen from the set [0,m[.
		///
		/// You are responsible for calling vtkMath::FreeCombination() once the iterator is no longer
		///             needed.
		///
		/// Warning: this gets large very quickly, especially when n nears m/2!
		/// (Hint: think of Pascal's triangle.)
		/// </summary>
		// Token: 0x0601E89B RID: 125083 RVA: 0x002B54E4 File Offset: 0x002B36E4
		public static IntPtr BeginCombination(int m, int n)
		{
			return vtkMath.vtkMath_BeginCombination_05(m, n);
		}

		// Token: 0x0601E89C RID: 125084
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMath_Binomial_06(int m, int n);

		/// <summary>
		/// The number of combinations of n objects from a pool of m objects (m&gt;n).
		/// This is commonly known as "m choose n" and sometimes denoted \f$_mC_n\f$
		/// or \f$\left(\begin{array}{c}m \\ n\end{array}\right)\f$.
		/// </summary>
		// Token: 0x0601E89D RID: 125085 RVA: 0x002B5500 File Offset: 0x002B3700
		public static long Binomial(int m, int n)
		{
			return vtkMath.vtkMath_Binomial_06(m, n);
		}

		// Token: 0x0601E89E RID: 125086
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMath_BoundsIsWithinOtherBounds_07(IntPtr bounds1, IntPtr bounds2, IntPtr delta);

		/// <summary>
		/// Return true if first 3D bounds is within the second 3D bounds
		/// Bounds is x-min, x-max, y-min, y-max, z-min, z-max
		/// Delta is the error margin along each axis (usually a small number)
		/// </summary>
		// Token: 0x0601E89F RID: 125087 RVA: 0x002B551C File Offset: 0x002B371C
		public static int BoundsIsWithinOtherBounds(IntPtr bounds1, IntPtr bounds2, IntPtr delta)
		{
			return vtkMath.vtkMath_BoundsIsWithinOtherBounds_07(bounds1, bounds2, delta);
		}

		// Token: 0x0601E8A0 RID: 125088
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMath_Ceil_08(double x);

		/// <summary>
		/// Rounds a double to the nearest integer not less than itself.
		/// This is faster than ceil() but provides undefined output on
		/// overflow.
		/// </summary>
		// Token: 0x0601E8A1 RID: 125089 RVA: 0x002B5538 File Offset: 0x002B3738
		public static int Ceil(double x)
		{
			return vtkMath.vtkMath_Ceil_08(x);
		}

		// Token: 0x0601E8A2 RID: 125090
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMath_CeilLog2_09(ulong x);

		/// <summary>
		/// Gives the exponent of the lowest power of two not less than x.
		/// Or in mathspeak, return the smallest "i" for which 2^i &gt;= x.
		/// If x is zero, then the return value will be zero.
		/// </summary>
		// Token: 0x0601E8A3 RID: 125091 RVA: 0x002B5554 File Offset: 0x002B3754
		public static int CeilLog2(ulong x)
		{
			return vtkMath.vtkMath_CeilLog2_09(x);
		}

		// Token: 0x0601E8A4 RID: 125092
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMath_ClampAndNormalizeValue_10(double value, IntPtr range);

		/// <summary>
		/// Clamp a value against a range and then normalize it between 0 and 1.
		/// If range[0]==range[1], the result is 0.
		/// \pre valid_range: range[0]&lt;=range[1]
		/// \post valid_result: result&gt;=0.0 &amp;&amp; result&lt;=1.0
		/// </summary>
		// Token: 0x0601E8A5 RID: 125093 RVA: 0x002B5570 File Offset: 0x002B3770
		public static double ClampAndNormalizeValue(double value, IntPtr range)
		{
			return vtkMath.vtkMath_ClampAndNormalizeValue_10(value, range);
		}

		// Token: 0x0601E8A6 RID: 125094
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMath_ClampValue_11(ref double value, ref double min, ref double max);

		/// <summary>
		/// Get the coordinates of a point along a line defined by p1 and p2, at a
		/// specified offset relative to p2.
		/// </summary>
		// Token: 0x0601E8A7 RID: 125095 RVA: 0x002B558C File Offset: 0x002B378C
		public static double ClampValue(ref double value, ref double min, ref double max)
		{
			return vtkMath.vtkMath_ClampValue_11(ref value, ref min, ref max);
		}

		// Token: 0x0601E8A8 RID: 125096
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMath_ClampValue_12(IntPtr value, IntPtr range);

		/// <summary>
		/// Clamp some values against a range
		/// The method without 'clamped_values' will perform in-place clamping.
		/// </summary>
		// Token: 0x0601E8A9 RID: 125097 RVA: 0x002B55A8 File Offset: 0x002B37A8
		public static void ClampValue(IntPtr value, IntPtr range)
		{
			vtkMath.vtkMath_ClampValue_12(value, range);
		}

		// Token: 0x0601E8AA RID: 125098
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMath_ClampValue_13(double value, IntPtr range, IntPtr clamped_value);

		/// <summary>
		/// Clamp some values against a range
		/// The method without 'clamped_values' will perform in-place clamping.
		/// </summary>
		// Token: 0x0601E8AB RID: 125099 RVA: 0x002B55B3 File Offset: 0x002B37B3
		public static void ClampValue(double value, IntPtr range, IntPtr clamped_value)
		{
			vtkMath.vtkMath_ClampValue_13(value, range, clamped_value);
		}

		// Token: 0x0601E8AC RID: 125100
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMath_ClampValues_14(IntPtr values, int nb_values, IntPtr range);

		/// <summary>
		/// Clamp some values against a range
		/// The method without 'clamped_values' will perform in-place clamping.
		/// </summary>
		// Token: 0x0601E8AD RID: 125101 RVA: 0x002B55BF File Offset: 0x002B37BF
		public static void ClampValues(IntPtr values, int nb_values, IntPtr range)
		{
			vtkMath.vtkMath_ClampValues_14(values, nb_values, range);
		}

		// Token: 0x0601E8AE RID: 125102
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMath_ClampValues_15(IntPtr values, int nb_values, IntPtr range, IntPtr clamped_values);

		/// <summary>
		/// Clamp some values against a range
		/// The method without 'clamped_values' will perform in-place clamping.
		/// </summary>
		// Token: 0x0601E8AF RID: 125103 RVA: 0x002B55CB File Offset: 0x002B37CB
		public static void ClampValues(IntPtr values, int nb_values, IntPtr range, IntPtr clamped_values)
		{
			vtkMath.vtkMath_ClampValues_15(values, nb_values, range, clamped_values);
		}

		// Token: 0x0601E8B0 RID: 125104
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMath_ComputeGCD_16(long m, long n);

		/// <summary>
		/// Compute the greatest common divisor (GCD) of two positive integers m and n. If the
		/// computed GCD==1, then the two integers are coprime to one another. This is a simple,
		/// recursive implementation.
		/// </summary>
		// Token: 0x0601E8B1 RID: 125105 RVA: 0x002B55D8 File Offset: 0x002B37D8
		public static long ComputeGCD(long m, long n)
		{
			return vtkMath.vtkMath_ComputeGCD_16(m, n);
		}

		// Token: 0x0601E8B2 RID: 125106
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMath_Cross_17(IntPtr a, IntPtr b, IntPtr c);

		/// <summary>
		/// Cross product of two 3-vectors. Result (a x b) is stored in c.
		/// (float version)
		/// </summary>
		// Token: 0x0601E8B3 RID: 125107 RVA: 0x002B55F3 File Offset: 0x002B37F3
		public static void Cross(IntPtr a, IntPtr b, IntPtr c)
		{
			vtkMath.vtkMath_Cross_17(a, b, c);
		}

		// Token: 0x0601E8B4 RID: 125108
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkMath_DegreesFromRadians_18(float radians);

		/// <summary>
		/// Convert radians into degrees
		/// </summary>
		// Token: 0x0601E8B5 RID: 125109 RVA: 0x002B5600 File Offset: 0x002B3800
		public static float DegreesFromRadians(float radians)
		{
			return vtkMath.vtkMath_DegreesFromRadians_18(radians);
		}

		// Token: 0x0601E8B6 RID: 125110
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMath_DegreesFromRadians_19(double radians);

		/// <summary>
		/// Convert radians into degrees
		/// </summary>
		// Token: 0x0601E8B7 RID: 125111 RVA: 0x002B561C File Offset: 0x002B381C
		public static double DegreesFromRadians(double radians)
		{
			return vtkMath.vtkMath_DegreesFromRadians_19(radians);
		}

		// Token: 0x0601E8B8 RID: 125112
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkMath_Determinant2x2_20(IntPtr c1, IntPtr c2);

		/// <summary>
		/// Compute determinant of 2x2 matrix. Two columns of matrix are input.
		/// </summary>
		// Token: 0x0601E8B9 RID: 125113 RVA: 0x002B5638 File Offset: 0x002B3838
		public static float Determinant2x2(IntPtr c1, IntPtr c2)
		{
			return vtkMath.vtkMath_Determinant2x2_20(c1, c2);
		}

		// Token: 0x0601E8BA RID: 125114
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMath_Determinant2x2_21(double a, double b, double c, double d);

		/// <summary>
		/// Calculate the determinant of a 2x2 matrix: | a b | | c d |
		/// </summary>
		// Token: 0x0601E8BB RID: 125115 RVA: 0x002B5654 File Offset: 0x002B3854
		public static double Determinant2x2(double a, double b, double c, double d)
		{
			return vtkMath.vtkMath_Determinant2x2_21(a, b, c, d);
		}

		// Token: 0x0601E8BC RID: 125116
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkMath_Determinant3x3_22(IntPtr c1, IntPtr c2, IntPtr c3);

		/// <summary>
		/// Compute determinant of 3x3 matrix. Three columns of matrix are input.
		/// </summary>
		// Token: 0x0601E8BD RID: 125117 RVA: 0x002B5674 File Offset: 0x002B3874
		public static float Determinant3x3(IntPtr c1, IntPtr c2, IntPtr c3)
		{
			return vtkMath.vtkMath_Determinant3x3_22(c1, c2, c3);
		}

		// Token: 0x0601E8BE RID: 125118
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMath_Determinant3x3_23(double a1, double a2, double a3, double b1, double b2, double b3, double c1, double c2, double c3);

		/// <summary>
		/// Calculate the determinant of a 3x3 matrix in the form:
		/// | a1,  b1,  c1 |
		/// | a2,  b2,  c2 |
		/// | a3,  b3,  c3 |
		/// </summary>
		// Token: 0x0601E8BF RID: 125119 RVA: 0x002B5690 File Offset: 0x002B3890
		public static double Determinant3x3(double a1, double a2, double a3, double b1, double b2, double b3, double c1, double c2, double c3)
		{
			return vtkMath.vtkMath_Determinant3x3_23(a1, a2, a3, b1, b2, b3, c1, c2, c3);
		}

		// Token: 0x0601E8C0 RID: 125120
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkMath_Distance2BetweenPoints_24(IntPtr p1, IntPtr p2);

		/// <summary>
		/// Compute distance squared between two points p1 and p2.
		/// (float version).
		/// </summary>
		// Token: 0x0601E8C1 RID: 125121 RVA: 0x002B56B8 File Offset: 0x002B38B8
		public static float Distance2BetweenPoints(IntPtr p1, IntPtr p2)
		{
			return vtkMath.vtkMath_Distance2BetweenPoints_24(p1, p2);
		}

		// Token: 0x0601E8C2 RID: 125122
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkMath_Dot_25(IntPtr a, IntPtr b);

		/// <summary>
		/// Dot product of two 3-vectors (float version).
		/// </summary>
		// Token: 0x0601E8C3 RID: 125123 RVA: 0x002B56D4 File Offset: 0x002B38D4
		public static float Dot(IntPtr a, IntPtr b)
		{
			return vtkMath.vtkMath_Dot_25(a, b);
		}

		// Token: 0x0601E8C4 RID: 125124
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkMath_Dot2D_26(IntPtr x, IntPtr y);

		/// <summary>
		/// Dot product of two 2-vectors. (float version).
		/// </summary>
		// Token: 0x0601E8C5 RID: 125125 RVA: 0x002B56F0 File Offset: 0x002B38F0
		public static float Dot2D(IntPtr x, IntPtr y)
		{
			return vtkMath.vtkMath_Dot2D_26(x, y);
		}

		// Token: 0x0601E8C6 RID: 125126
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMath_ExtentIsWithinOtherExtent_27(IntPtr extent1, IntPtr extent2);

		/// <summary>
		/// Return true if first 3D extent is within second 3D extent
		/// Extent is x-min, x-max, y-min, y-max, z-min, z-max
		/// </summary>
		// Token: 0x0601E8C7 RID: 125127 RVA: 0x002B570C File Offset: 0x002B390C
		public static int ExtentIsWithinOtherExtent(IntPtr extent1, IntPtr extent2)
		{
			return vtkMath.vtkMath_ExtentIsWithinOtherExtent_27(extent1, extent2);
		}

		// Token: 0x0601E8C8 RID: 125128
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMath_Factorial_28(int N);

		/// <summary>
		/// Compute N factorial, N! = N*(N-1) * (N-2)...*3*2*1.
		/// 0! is taken to be 1.
		/// </summary>
		// Token: 0x0601E8C9 RID: 125129 RVA: 0x002B5728 File Offset: 0x002B3928
		public static long Factorial(int N)
		{
			return vtkMath.vtkMath_Factorial_28(N);
		}

		// Token: 0x0601E8CA RID: 125130
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMath_Floor_29(double x);

		/// <summary>
		/// Rounds a double to the nearest integer not greater than itself.
		/// This is faster than floor() but provides undefined output on
		/// overflow.
		/// </summary>
		// Token: 0x0601E8CB RID: 125131 RVA: 0x002B5744 File Offset: 0x002B3944
		public static int Floor(double x)
		{
			return vtkMath.vtkMath_Floor_29(x);
		}

		// Token: 0x0601E8CC RID: 125132
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMath_FreeCombination_30(IntPtr combination);

		/// <summary>
		/// Free the "iterator" array created by vtkMath::BeginCombination.
		/// </summary>
		// Token: 0x0601E8CD RID: 125133 RVA: 0x002B575E File Offset: 0x002B395E
		public static void FreeCombination(IntPtr combination)
		{
			vtkMath.vtkMath_FreeCombination_30(combination);
		}

		// Token: 0x0601E8CE RID: 125134
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMath_Gaussian_31();

		/// <summary>
		/// Generate pseudo-random numbers distributed according to the standard
		/// normal distribution.
		///
		/// DON'T USE Random(), RandomSeed(), GetSeed(), Gaussian()
		/// THIS IS STATIC SO THIS IS PRONE TO ERRORS (SPECIALLY FOR REGRESSION TESTS)
		/// THIS IS HERE FOR BACKWARD COMPATIBILITY ONLY.
		/// Instead, for a sequence of random numbers with a uniform distribution
		/// create a vtkMinimalStandardRandomSequence object.
		/// For a sequence of random numbers with a gaussian/normal distribution
		/// create a vtkBoxMuellerRandomSequence object.
		/// </summary>
		// Token: 0x0601E8CF RID: 125135 RVA: 0x002B5768 File Offset: 0x002B3968
		public static double Gaussian()
		{
			return vtkMath.vtkMath_Gaussian_31();
		}

		// Token: 0x0601E8D0 RID: 125136
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMath_Gaussian_32(double mean, double std);

		/// <summary>
		/// Generate pseudo-random numbers distributed according to the Gaussian
		/// distribution with mean \a mean and standard deviation \a std.
		///
		/// DON'T USE Random(), RandomSeed(), GetSeed(), Gaussian()
		/// THIS IS STATIC SO THIS IS PRONE TO ERRORS (SPECIALLY FOR REGRESSION TESTS)
		/// THIS IS HERE FOR BACKWARD COMPATIBILITY ONLY.
		/// Instead, for a sequence of random numbers with a uniform distribution
		/// create a vtkMinimalStandardRandomSequence object.
		/// For a sequence of random numbers with a gaussian/normal distribution
		/// create a vtkBoxMuellerRandomSequence object.
		/// </summary>
		// Token: 0x0601E8D1 RID: 125137 RVA: 0x002B5784 File Offset: 0x002B3984
		public static double Gaussian(double mean, double std)
		{
			return vtkMath.vtkMath_Gaussian_32(mean, std);
		}

		// Token: 0x0601E8D2 RID: 125138
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMath_GaussianAmplitude_33(double variance, double distanceFromMean);

		/// <summary>
		/// Compute the amplitude of a Gaussian function with mean=0 and specified variance.
		/// That is, 1./(std::sqrt(2 Pi * variance)) * exp(-distanceFromMean^2/(2.*variance)).
		/// </summary>
		// Token: 0x0601E8D3 RID: 125139 RVA: 0x002B57A0 File Offset: 0x002B39A0
		public static double GaussianAmplitude(double variance, double distanceFromMean)
		{
			return vtkMath.vtkMath_GaussianAmplitude_33(variance, distanceFromMean);
		}

		// Token: 0x0601E8D4 RID: 125140
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMath_GaussianAmplitude_34(double mean, double variance, double position);

		/// <summary>
		/// Compute the amplitude of a Gaussian function with specified mean and variance.
		/// That is, 1./(std::sqrt(2 Pi * variance)) * exp(-(position - mean)^2/(2.*variance)).
		/// </summary>
		// Token: 0x0601E8D5 RID: 125141 RVA: 0x002B57BC File Offset: 0x002B39BC
		public static double GaussianAmplitude(double mean, double variance, double position)
		{
			return vtkMath.vtkMath_GaussianAmplitude_34(mean, variance, position);
		}

		// Token: 0x0601E8D6 RID: 125142
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMath_GaussianWeight_35(double variance, double distanceFromMean);

		/// <summary>
		/// Compute the amplitude of an unnormalized Gaussian function with mean=0 and specified variance.
		/// That is, exp(-distanceFromMean^2/(2.*variance)). When distanceFromMean = 0, this function
		/// returns 1.
		/// </summary>
		// Token: 0x0601E8D7 RID: 125143 RVA: 0x002B57D8 File Offset: 0x002B39D8
		public static double GaussianWeight(double variance, double distanceFromMean)
		{
			return vtkMath.vtkMath_GaussianWeight_35(variance, distanceFromMean);
		}

		// Token: 0x0601E8D8 RID: 125144
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMath_GaussianWeight_36(double mean, double variance, double position);

		/// <summary>
		/// Compute the amplitude of an unnormalized Gaussian function with specified mean and variance.
		/// That is, exp(-(position - mean)^2/(2.*variance)). When the distance from 'position' to 'mean'
		/// is 0, this function returns 1.
		/// </summary>
		// Token: 0x0601E8D9 RID: 125145 RVA: 0x002B57F4 File Offset: 0x002B39F4
		public static double GaussianWeight(double mean, double variance, double position)
		{
			return vtkMath.vtkMath_GaussianWeight_36(mean, variance, position);
		}

		// Token: 0x0601E8DA RID: 125146
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMath_GetAdjustedScalarRange_37(HandleRef array, int comp, IntPtr range);

		/// <summary>
		/// Get a vtkDataArray's scalar range for a given component.
		/// If the vtkDataArray's data type is unsigned char (VTK_UNSIGNED_CHAR)
		/// the range is adjusted to the whole data type range [0, 255.0].
		/// Same goes for unsigned short (VTK_UNSIGNED_SHORT) but the upper bound
		/// is also adjusted down to 4095.0 if was between ]255, 4095.0].
		/// Return 1 on success, 0 otherwise.
		/// </summary>
		// Token: 0x0601E8DB RID: 125147 RVA: 0x002B5810 File Offset: 0x002B3A10
		public static int GetAdjustedScalarRange(vtkDataArray array, int comp, IntPtr range)
		{
			return vtkMath.vtkMath_GetAdjustedScalarRange_37((array == null) ? default(HandleRef) : array.GetCppThis(), comp, range);
		}

		// Token: 0x0601E8DC RID: 125148
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMath_GetNumberOfGenerationsFromBase_38(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E8DD RID: 125149 RVA: 0x002B5840 File Offset: 0x002B3A40
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMath.vtkMath_GetNumberOfGenerationsFromBase_38(base.GetCppThis(), type);
		}

		// Token: 0x0601E8DE RID: 125150
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMath_GetNumberOfGenerationsFromBaseType_39([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E8DF RID: 125151 RVA: 0x002B5860 File Offset: 0x002B3A60
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMath.vtkMath_GetNumberOfGenerationsFromBaseType_39(type);
		}

		// Token: 0x0601E8E0 RID: 125152
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMath_GetPointAlongLine_40(IntPtr result, IntPtr p1, IntPtr p2, double offset);

		/// <summary>
		/// Get the coordinates of a point along a line defined by p1 and p2, at a
		/// specified offset relative to p2.
		/// </summary>
		// Token: 0x0601E8E1 RID: 125153 RVA: 0x002B587A File Offset: 0x002B3A7A
		public static void GetPointAlongLine(IntPtr result, IntPtr p1, IntPtr p2, double offset)
		{
			vtkMath.vtkMath_GetPointAlongLine_40(result, p1, p2, offset);
		}

		// Token: 0x0601E8E2 RID: 125154
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMath_GetScalarTypeFittingRange_41(double range_min, double range_max, double scale, double shift);

		/// <summary>
		/// Return the scalar type that is most likely to have enough precision
		/// to store a given range of data once it has been scaled and shifted
		/// (i.e. [range_min * scale + shift, range_max * scale + shift].
		/// If any one of the parameters is not an integer number (decimal part != 0),
		/// the search will default to float types only (float or double)
		/// Return -1 on error or no scalar type found.
		/// </summary>
		// Token: 0x0601E8E3 RID: 125155 RVA: 0x002B5888 File Offset: 0x002B3A88
		public static int GetScalarTypeFittingRange(double range_min, double range_max, double scale, double shift)
		{
			return vtkMath.vtkMath_GetScalarTypeFittingRange_41(range_min, range_max, scale, shift);
		}

		// Token: 0x0601E8E4 RID: 125156
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMath_GetSeed_42();

		/// <summary>
		/// Return the current seed used by the random number generator.
		///
		/// DON'T USE Random(), RandomSeed(), GetSeed(), Gaussian()
		/// THIS IS STATIC SO THIS IS PRONE TO ERRORS (SPECIALLY FOR REGRESSION TESTS)
		/// THIS IS HERE FOR BACKWARD COMPATIBILITY ONLY.
		/// Instead, for a sequence of random numbers with a uniform distribution
		/// create a vtkMinimalStandardRandomSequence object.
		/// For a sequence of random numbers with a gaussian/normal distribution
		/// create a vtkBoxMuellerRandomSequence object.
		/// </summary>
		// Token: 0x0601E8E5 RID: 125157 RVA: 0x002B58A8 File Offset: 0x002B3AA8
		public static int GetSeed()
		{
			return vtkMath.vtkMath_GetSeed_42();
		}

		// Token: 0x0601E8E6 RID: 125158
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMath_HSVToRGB_43(IntPtr hsv, IntPtr rgb);

		/// <summary>
		/// Convert color in HSV format (Hue, Saturation, Value) to RGB
		/// format (Red, Green, Blue). The input color is not modified.
		/// The input 'hsv' must be float values in the range [0, 1].
		/// The elements of each component of the output 'rgb' are in
		/// the range [0, 1].
		/// </summary>
		// Token: 0x0601E8E7 RID: 125159 RVA: 0x002B58C1 File Offset: 0x002B3AC1
		public static void HSVToRGB(IntPtr hsv, IntPtr rgb)
		{
			vtkMath.vtkMath_HSVToRGB_43(hsv, rgb);
		}

		// Token: 0x0601E8E8 RID: 125160
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMath_HSVToRGB_44(float h, float s, float v, IntPtr r, IntPtr g, IntPtr b);

		/// <summary>
		/// Convert color in HSV format (Hue, Saturation, Value) to RGB
		/// format (Red, Green, Blue). The input color is not modified.
		/// The input 'hsv' must be float values in the range [0, 1].
		/// The elements of each component of the output 'rgb' are in
		/// the range [0, 1].
		/// </summary>
		// Token: 0x0601E8E9 RID: 125161 RVA: 0x002B58CC File Offset: 0x002B3ACC
		public static void HSVToRGB(float h, float s, float v, IntPtr r, IntPtr g, IntPtr b)
		{
			vtkMath.vtkMath_HSVToRGB_44(h, s, v, r, g, b);
		}

		// Token: 0x0601E8EA RID: 125162
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMath_HSVToRGB_45(double h, double s, double v, IntPtr r, IntPtr g, IntPtr b);

		/// <summary>
		/// Convert color in HSV format (Hue, Saturation, Value) to RGB
		/// format (Red, Green, Blue). The input color is not modified.
		/// The input 'hsv' must be float values in the range [0, 1].
		/// The elements of each component of the output 'rgb' are in
		/// the range [0, 1].
		/// </summary>
		// Token: 0x0601E8EB RID: 125163 RVA: 0x002B58DD File Offset: 0x002B3ADD
		public static void HSVToRGB(double h, double s, double v, IntPtr r, IntPtr g, IntPtr b)
		{
			vtkMath.vtkMath_HSVToRGB_45(h, s, v, r, g, b);
		}

		// Token: 0x0601E8EC RID: 125164
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMath_Inf_46();

		/// <summary>
		/// Special IEEE-754 number used to represent positive infinity.
		/// </summary>
		// Token: 0x0601E8ED RID: 125165 RVA: 0x002B58F0 File Offset: 0x002B3AF0
		public static double Inf()
		{
			return vtkMath.vtkMath_Inf_46();
		}

		// Token: 0x0601E8EE RID: 125166
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMath_IsA_47(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E8EF RID: 125167 RVA: 0x002B590C File Offset: 0x002B3B0C
		public override int IsA(string type)
		{
			return vtkMath.vtkMath_IsA_47(base.GetCppThis(), type);
		}

		// Token: 0x0601E8F0 RID: 125168
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMath_IsFinite_48(double x);

		/// <summary>
		/// Test if a number has finite value i.e. it is normal, subnormal or zero, but not infinite or
		/// Nan.
		/// </summary>
		// Token: 0x0601E8F1 RID: 125169 RVA: 0x002B592C File Offset: 0x002B3B2C
		public static bool IsFinite(double x)
		{
			return vtkMath.vtkMath_IsFinite_48(x) != 0;
		}

		// Token: 0x0601E8F2 RID: 125170
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMath_IsInf_49(double x);

		/// <summary>
		/// Test if a number is equal to the special floating point value infinity.
		/// </summary>
		// Token: 0x0601E8F3 RID: 125171 RVA: 0x002B5950 File Offset: 0x002B3B50
		public static int IsInf(double x)
		{
			return vtkMath.vtkMath_IsInf_49(x);
		}

		// Token: 0x0601E8F4 RID: 125172
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMath_IsNan_50(double x);

		/// <summary>
		/// Test if a number is equal to the special floating point value Not-A-Number (Nan).
		/// </summary>
		// Token: 0x0601E8F5 RID: 125173 RVA: 0x002B596C File Offset: 0x002B3B6C
		public static int IsNan(double x)
		{
			return vtkMath.vtkMath_IsNan_50(x);
		}

		// Token: 0x0601E8F6 RID: 125174
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMath_IsPowerOfTwo_51(ulong x);

		/// <summary>
		/// Returns true if integer is a power of two.
		/// </summary>
		// Token: 0x0601E8F7 RID: 125175 RVA: 0x002B5988 File Offset: 0x002B3B88
		public static bool IsPowerOfTwo(ulong x)
		{
			return vtkMath.vtkMath_IsPowerOfTwo_51(x) != 0;
		}

		// Token: 0x0601E8F8 RID: 125176
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMath_IsTypeOf_52([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E8F9 RID: 125177 RVA: 0x002B59AC File Offset: 0x002B3BAC
		public new static int IsTypeOf(string type)
		{
			return vtkMath.vtkMath_IsTypeOf_52(type);
		}

		// Token: 0x0601E8FA RID: 125178
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMath_LabToRGB_53(IntPtr lab, IntPtr rgb);

		/// <summary>
		/// Convert color from the CIE-L*ab system to RGB.
		/// </summary>
		// Token: 0x0601E8FB RID: 125179 RVA: 0x002B59C6 File Offset: 0x002B3BC6
		public static void LabToRGB(IntPtr lab, IntPtr rgb)
		{
			vtkMath.vtkMath_LabToRGB_53(lab, rgb);
		}

		// Token: 0x0601E8FC RID: 125180
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMath_LabToRGB_54(double L, double a, double b, IntPtr red, IntPtr green, IntPtr blue);

		/// <summary>
		/// Convert color from the CIE-L*ab system to RGB.
		/// </summary>
		// Token: 0x0601E8FD RID: 125181 RVA: 0x002B59D1 File Offset: 0x002B3BD1
		public static void LabToRGB(double L, double a, double b, IntPtr red, IntPtr green, IntPtr blue)
		{
			vtkMath.vtkMath_LabToRGB_54(L, a, b, red, green, blue);
		}

		// Token: 0x0601E8FE RID: 125182
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMath_LabToXYZ_55(IntPtr lab, IntPtr xyz);

		/// <summary>
		/// Convert color from the CIE-L*ab system to CIE XYZ.
		/// </summary>
		// Token: 0x0601E8FF RID: 125183 RVA: 0x002B59E2 File Offset: 0x002B3BE2
		public static void LabToXYZ(IntPtr lab, IntPtr xyz)
		{
			vtkMath.vtkMath_LabToXYZ_55(lab, xyz);
		}

		// Token: 0x0601E900 RID: 125184
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMath_LabToXYZ_56(double L, double a, double b, IntPtr x, IntPtr y, IntPtr z);

		/// <summary>
		/// Convert color from the CIE-L*ab system to CIE XYZ.
		/// </summary>
		// Token: 0x0601E901 RID: 125185 RVA: 0x002B59ED File Offset: 0x002B3BED
		public static void LabToXYZ(double L, double a, double b, IntPtr x, IntPtr y, IntPtr z)
		{
			vtkMath.vtkMath_LabToXYZ_56(L, a, b, x, y, z);
		}

		// Token: 0x0601E902 RID: 125186
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMath_MultiplyQuaternion_57(IntPtr q1, IntPtr q2, IntPtr q);

		/// <summary>
		/// Multiply two quaternions. This is used to concatenate rotations.
		/// Quaternions are in the form [w, x, y, z].
		/// @sa Matrix3x3ToQuaternion() QuaternionToMatrix3x3()
		/// @sa vtkQuaternion
		/// </summary>
		// Token: 0x0601E903 RID: 125187 RVA: 0x002B59FE File Offset: 0x002B3BFE
		public static void MultiplyQuaternion(IntPtr q1, IntPtr q2, IntPtr q)
		{
			vtkMath.vtkMath_MultiplyQuaternion_57(q1, q2, q);
		}

		// Token: 0x0601E904 RID: 125188
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMath_MultiplyScalar_58(IntPtr a, float s);

		/// <summary>
		/// Multiplies a 3-vector by a scalar (float version).
		/// This modifies the input 3-vector.
		/// </summary>
		// Token: 0x0601E905 RID: 125189 RVA: 0x002B5A0A File Offset: 0x002B3C0A
		public static void MultiplyScalar(IntPtr a, float s)
		{
			vtkMath.vtkMath_MultiplyScalar_58(a, s);
		}

		// Token: 0x0601E906 RID: 125190
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMath_MultiplyScalar_59(IntPtr a, double s);

		/// <summary>
		/// Multiplies a 3-vector by a scalar (double version).
		/// This modifies the input 3-vector.
		/// </summary>
		// Token: 0x0601E907 RID: 125191 RVA: 0x002B5A15 File Offset: 0x002B3C15
		public static void MultiplyScalar(IntPtr a, double s)
		{
			vtkMath.vtkMath_MultiplyScalar_59(a, s);
		}

		// Token: 0x0601E908 RID: 125192
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMath_MultiplyScalar2D_60(IntPtr a, float s);

		/// <summary>
		/// Multiplies a 2-vector by a scalar (float version).
		/// This modifies the input 2-vector.
		/// </summary>
		// Token: 0x0601E909 RID: 125193 RVA: 0x002B5A20 File Offset: 0x002B3C20
		public static void MultiplyScalar2D(IntPtr a, float s)
		{
			vtkMath.vtkMath_MultiplyScalar2D_60(a, s);
		}

		// Token: 0x0601E90A RID: 125194
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMath_MultiplyScalar2D_61(IntPtr a, double s);

		/// <summary>
		/// Multiplies a 2-vector by a scalar (double version).
		/// This modifies the input 2-vector.
		/// </summary>
		// Token: 0x0601E90B RID: 125195 RVA: 0x002B5A2B File Offset: 0x002B3C2B
		public static void MultiplyScalar2D(IntPtr a, double s)
		{
			vtkMath.vtkMath_MultiplyScalar2D_61(a, s);
		}

		// Token: 0x0601E90C RID: 125196
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMath_Nan_62();

		/// <summary>
		/// Special IEEE-754 number used to represent Not-A-Number (Nan).
		/// </summary>
		// Token: 0x0601E90D RID: 125197 RVA: 0x002B5A38 File Offset: 0x002B3C38
		public static double Nan()
		{
			return vtkMath.vtkMath_Nan_62();
		}

		// Token: 0x0601E90E RID: 125198
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMath_NearestPowerOfTwo_63(int x);

		/// <summary>
		/// Compute the nearest power of two that is not less than x.
		/// The return value is 1 if x is less than or equal to zero,
		/// and is VTK_INT_MIN if result is too large to fit in an int.
		/// </summary>
		// Token: 0x0601E90F RID: 125199 RVA: 0x002B5A54 File Offset: 0x002B3C54
		public static int NearestPowerOfTwo(int x)
		{
			return vtkMath.vtkMath_NearestPowerOfTwo_63(x);
		}

		// Token: 0x0601E910 RID: 125200
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMath_NegInf_64();

		/// <summary>
		/// Special IEEE-754 number used to represent negative infinity.
		/// </summary>
		// Token: 0x0601E911 RID: 125201 RVA: 0x002B5A70 File Offset: 0x002B3C70
		public static double NegInf()
		{
			return vtkMath.vtkMath_NegInf_64();
		}

		// Token: 0x0601E912 RID: 125202
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMath_NewInstance_66(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E913 RID: 125203 RVA: 0x002B5A8C File Offset: 0x002B3C8C
		public new vtkMath NewInstance()
		{
			vtkMath result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMath.vtkMath_NewInstance_66(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMath)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E914 RID: 125204
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMath_NextCombination_67(int m, int n, IntPtr combination);

		/// <summary>
		/// Given \a m, \a n, and a valid \a combination of \a n integers in
		/// the range [0,m[, this function alters the integers into the next
		/// combination in a sequence of all combinations of \a n items from
		/// a pool of \a m.
		///
		/// If the \a combination is the last item in the sequence on input,
		/// then \a combination is unaltered and 0 is returned.
		/// Otherwise, 1 is returned and \a combination is updated.
		/// </summary>
		// Token: 0x0601E915 RID: 125205 RVA: 0x002B5AE8 File Offset: 0x002B3CE8
		public static int NextCombination(int m, int n, IntPtr combination)
		{
			return vtkMath.vtkMath_NextCombination_67(m, n, combination);
		}

		// Token: 0x0601E916 RID: 125206
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkMath_Norm_68(IntPtr x, int n);

		/// <summary>
		/// Compute the norm of n-vector. x is the vector, n is its length.
		/// </summary>
		// Token: 0x0601E917 RID: 125207 RVA: 0x002B5B04 File Offset: 0x002B3D04
		public static float Norm(IntPtr x, int n)
		{
			return vtkMath.vtkMath_Norm_68(x, n);
		}

		// Token: 0x0601E918 RID: 125208
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkMath_Norm_69(IntPtr v);

		/// <summary>
		/// Compute the norm of 3-vector (float version).
		/// </summary>
		// Token: 0x0601E919 RID: 125209 RVA: 0x002B5B20 File Offset: 0x002B3D20
		public static float Norm(IntPtr v)
		{
			return vtkMath.vtkMath_Norm_69(v);
		}

		// Token: 0x0601E91A RID: 125210
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkMath_Norm2D_70(IntPtr x);

		/// <summary>
		/// Compute the norm of a 2-vector.
		/// (float version).
		/// </summary>
		// Token: 0x0601E91B RID: 125211 RVA: 0x002B5B3C File Offset: 0x002B3D3C
		public static float Norm2D(IntPtr x)
		{
			return vtkMath.vtkMath_Norm2D_70(x);
		}

		// Token: 0x0601E91C RID: 125212
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkMath_Normalize_71(IntPtr v);

		/// <summary>
		/// Normalize (in place) a 3-vector. Returns norm of vector.
		/// (float version)
		/// </summary>
		// Token: 0x0601E91D RID: 125213 RVA: 0x002B5B58 File Offset: 0x002B3D58
		public static float Normalize(IntPtr v)
		{
			return vtkMath.vtkMath_Normalize_71(v);
		}

		// Token: 0x0601E91E RID: 125214
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkMath_Normalize2D_72(IntPtr v);

		/// <summary>
		/// Normalize (in place) a 2-vector. Returns norm of vector.
		/// (float version).
		/// </summary>
		// Token: 0x0601E91F RID: 125215 RVA: 0x002B5B74 File Offset: 0x002B3D74
		public static float Normalize2D(IntPtr v)
		{
			return vtkMath.vtkMath_Normalize2D_72(v);
		}

		// Token: 0x0601E920 RID: 125216
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMath_Perpendiculars_73(IntPtr v1, IntPtr v2, IntPtr v3, double theta);

		/// <summary>
		/// Given a unit vector v1, find two unit vectors v2 and v3 such that
		/// v1 cross v2 = v3 (i.e. the vectors are perpendicular to each other).
		/// There is an infinite number of such vectors, specify an angle theta
		/// to choose one set.  If you want only one perpendicular vector,
		/// specify nullptr for v3.
		/// </summary>
		// Token: 0x0601E921 RID: 125217 RVA: 0x002B5B8E File Offset: 0x002B3D8E
		public static void Perpendiculars(IntPtr v1, IntPtr v2, IntPtr v3, double theta)
		{
			vtkMath.vtkMath_Perpendiculars_73(v1, v2, v3, theta);
		}

		// Token: 0x0601E922 RID: 125218
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMath_Pi_74();

		/// <summary>
		/// A mathematical constant. This version is atan(1.0) * 4.0
		/// </summary>
		// Token: 0x0601E923 RID: 125219 RVA: 0x002B5B9C File Offset: 0x002B3D9C
		public static double Pi()
		{
			return vtkMath.vtkMath_Pi_74();
		}

		// Token: 0x0601E924 RID: 125220
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMath_PlaneIntersectsAABB_75(IntPtr bounds, IntPtr normal, IntPtr point);

		/// <summary>
		/// Implements Plane / Axis-Aligned Bounding-Box intersection as described in
		/// Graphics Gems IV, Ned Greene; pp. 75-76. Variable names are based on the
		/// description in the book. This function returns +1 if the box lies fully in
		/// the positive side of the plane (by convention, the side to which the plane's
		/// normal points to), -1 if the box fully lies in the negative side and 0 if
		/// the plane intersects the box.  -2 is returned if any of the arguments is
		/// invalid.
		/// </summary>
		// Token: 0x0601E925 RID: 125221 RVA: 0x002B5BB8 File Offset: 0x002B3DB8
		public static int PlaneIntersectsAABB(IntPtr bounds, IntPtr normal, IntPtr point)
		{
			return vtkMath.vtkMath_PlaneIntersectsAABB_75(bounds, normal, point);
		}

		// Token: 0x0601E926 RID: 125222
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMath_PointIsWithinBounds_76(IntPtr point, IntPtr bounds, IntPtr delta);

		/// <summary>
		/// Return true if point is within the given 3D bounds
		/// Bounds is x-min, x-max, y-min, y-max, z-min, z-max
		/// Delta is the error margin along each axis (usually a small number)
		/// </summary>
		// Token: 0x0601E927 RID: 125223 RVA: 0x002B5BD4 File Offset: 0x002B3DD4
		public static int PointIsWithinBounds(IntPtr point, IntPtr bounds, IntPtr delta)
		{
			return vtkMath.vtkMath_PointIsWithinBounds_76(point, bounds, delta);
		}

		// Token: 0x0601E928 RID: 125224
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMath_ProjectVector_77(IntPtr a, IntPtr b, IntPtr projection);

		/// <summary>
		/// Compute the projection of vector a on vector b and return it in projection[3].
		/// If b is a zero vector, the function returns false and 'projection' is invalid.
		/// Otherwise, it returns true.
		/// </summary>
		// Token: 0x0601E929 RID: 125225 RVA: 0x002B5BF0 File Offset: 0x002B3DF0
		public static bool ProjectVector(IntPtr a, IntPtr b, IntPtr projection)
		{
			return vtkMath.vtkMath_ProjectVector_77(a, b, projection) != 0;
		}

		// Token: 0x0601E92A RID: 125226
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMath_ProjectVector2D_78(IntPtr a, IntPtr b, IntPtr projection);

		/// <summary>
		/// Compute the projection of 2D vector a on 2D vector b and returns the result
		/// in projection[2].
		/// If b is a zero vector, the function returns false and 'projection' is invalid.
		/// Otherwise, it returns true.
		/// </summary>
		// Token: 0x0601E92B RID: 125227 RVA: 0x002B5C14 File Offset: 0x002B3E14
		public static bool ProjectVector2D(IntPtr a, IntPtr b, IntPtr projection)
		{
			return vtkMath.vtkMath_ProjectVector2D_78(a, b, projection) != 0;
		}

		// Token: 0x0601E92C RID: 125228
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMath_QuadraticRoot_79(double a, double b, double c, double min, double max, IntPtr u);

		/// <summary>
		/// find roots of ax^2+bx+c=0  in the interval min,max.
		/// place the roots in u[2] and return how many roots found
		/// </summary>
		// Token: 0x0601E92D RID: 125229 RVA: 0x002B5C38 File Offset: 0x002B3E38
		public static int QuadraticRoot(double a, double b, double c, double min, double max, IntPtr u)
		{
			return vtkMath.vtkMath_QuadraticRoot_79(a, b, c, min, max, u);
		}

		// Token: 0x0601E92E RID: 125230
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMath_RGBToHSV_80(IntPtr rgb, IntPtr hsv);

		/// <summary>
		/// Convert color in RGB format (Red, Green, Blue) to HSV format
		/// (Hue, Saturation, Value). The input color is not modified.
		/// The input RGB must be float values in the range [0, 1].
		/// The output ranges are hue [0, 1], saturation [0, 1], and
		/// value [0, 1].
		/// </summary>
		// Token: 0x0601E92F RID: 125231 RVA: 0x002B5C59 File Offset: 0x002B3E59
		public static void RGBToHSV(IntPtr rgb, IntPtr hsv)
		{
			vtkMath.vtkMath_RGBToHSV_80(rgb, hsv);
		}

		// Token: 0x0601E930 RID: 125232
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMath_RGBToHSV_81(float r, float g, float b, IntPtr h, IntPtr s, IntPtr v);

		/// <summary>
		/// Convert color in RGB format (Red, Green, Blue) to HSV format
		/// (Hue, Saturation, Value). The input color is not modified.
		/// The input RGB must be float values in the range [0, 1].
		/// The output ranges are hue [0, 1], saturation [0, 1], and
		/// value [0, 1].
		/// </summary>
		// Token: 0x0601E931 RID: 125233 RVA: 0x002B5C64 File Offset: 0x002B3E64
		public static void RGBToHSV(float r, float g, float b, IntPtr h, IntPtr s, IntPtr v)
		{
			vtkMath.vtkMath_RGBToHSV_81(r, g, b, h, s, v);
		}

		// Token: 0x0601E932 RID: 125234
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMath_RGBToHSV_82(double r, double g, double b, IntPtr h, IntPtr s, IntPtr v);

		/// <summary>
		/// Convert color in RGB format (Red, Green, Blue) to HSV format
		/// (Hue, Saturation, Value). The input color is not modified.
		/// The input RGB must be float values in the range [0, 1].
		/// The output ranges are hue [0, 1], saturation [0, 1], and
		/// value [0, 1].
		/// </summary>
		// Token: 0x0601E933 RID: 125235 RVA: 0x002B5C75 File Offset: 0x002B3E75
		public static void RGBToHSV(double r, double g, double b, IntPtr h, IntPtr s, IntPtr v)
		{
			vtkMath.vtkMath_RGBToHSV_82(r, g, b, h, s, v);
		}

		// Token: 0x0601E934 RID: 125236
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMath_RGBToLab_83(IntPtr rgb, IntPtr lab);

		/// <summary>
		/// Convert color from the RGB system to CIE-L*ab.
		/// The input RGB must be values in the range [0, 1].
		/// The output ranges of 'L' is [0, 100]. The output
		/// range of 'a' and 'b' are approximately [-110, 110].
		/// </summary>
		// Token: 0x0601E935 RID: 125237 RVA: 0x002B5C86 File Offset: 0x002B3E86
		public static void RGBToLab(IntPtr rgb, IntPtr lab)
		{
			vtkMath.vtkMath_RGBToLab_83(rgb, lab);
		}

		// Token: 0x0601E936 RID: 125238
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMath_RGBToLab_84(double red, double green, double blue, IntPtr L, IntPtr a, IntPtr b);

		/// <summary>
		/// Convert color from the RGB system to CIE-L*ab.
		/// The input RGB must be values in the range [0, 1].
		/// The output ranges of 'L' is [0, 100]. The output
		/// range of 'a' and 'b' are approximately [-110, 110].
		/// </summary>
		// Token: 0x0601E937 RID: 125239 RVA: 0x002B5C91 File Offset: 0x002B3E91
		public static void RGBToLab(double red, double green, double blue, IntPtr L, IntPtr a, IntPtr b)
		{
			vtkMath.vtkMath_RGBToLab_84(red, green, blue, L, a, b);
		}

		// Token: 0x0601E938 RID: 125240
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMath_RGBToXYZ_85(IntPtr rgb, IntPtr xyz);

		/// <summary>
		/// Convert color from the RGB system to CIE XYZ.
		/// </summary>
		// Token: 0x0601E939 RID: 125241 RVA: 0x002B5CA2 File Offset: 0x002B3EA2
		public static void RGBToXYZ(IntPtr rgb, IntPtr xyz)
		{
			vtkMath.vtkMath_RGBToXYZ_85(rgb, xyz);
		}

		// Token: 0x0601E93A RID: 125242
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMath_RGBToXYZ_86(double r, double g, double b, IntPtr x, IntPtr y, IntPtr z);

		/// <summary>
		/// Convert color from the RGB system to CIE XYZ.
		/// </summary>
		// Token: 0x0601E93B RID: 125243 RVA: 0x002B5CAD File Offset: 0x002B3EAD
		public static void RGBToXYZ(double r, double g, double b, IntPtr x, IntPtr y, IntPtr z)
		{
			vtkMath.vtkMath_RGBToXYZ_86(r, g, b, x, y, z);
		}

		// Token: 0x0601E93C RID: 125244
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkMath_RadiansFromDegrees_87(float degrees);

		/// <summary>
		/// Convert degrees into radians
		/// </summary>
		// Token: 0x0601E93D RID: 125245 RVA: 0x002B5CC0 File Offset: 0x002B3EC0
		public static float RadiansFromDegrees(float degrees)
		{
			return vtkMath.vtkMath_RadiansFromDegrees_87(degrees);
		}

		// Token: 0x0601E93E RID: 125246
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMath_RadiansFromDegrees_88(double degrees);

		/// <summary>
		/// Convert degrees into radians
		/// </summary>
		// Token: 0x0601E93F RID: 125247 RVA: 0x002B5CDC File Offset: 0x002B3EDC
		public static double RadiansFromDegrees(double degrees)
		{
			return vtkMath.vtkMath_RadiansFromDegrees_88(degrees);
		}

		// Token: 0x0601E940 RID: 125248
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMath_Random_89();

		/// <summary>
		/// Generate pseudo-random numbers distributed according to the uniform
		/// distribution between 0.0 and 1.0.
		/// This is used to provide portability across different systems.
		///
		/// DON'T USE Random(), RandomSeed(), GetSeed(), Gaussian()
		/// THIS IS STATIC SO THIS IS PRONE TO ERRORS (SPECIALLY FOR REGRESSION TESTS)
		/// THIS IS HERE FOR BACKWARD COMPATIBILITY ONLY.
		/// Instead, for a sequence of random numbers with a uniform distribution
		/// create a vtkMinimalStandardRandomSequence object.
		/// For a sequence of random numbers with a gaussian/normal distribution
		/// create a vtkBoxMuellerRandomSequence object.
		/// </summary>
		// Token: 0x0601E941 RID: 125249 RVA: 0x002B5CF8 File Offset: 0x002B3EF8
		public static double Random()
		{
			return vtkMath.vtkMath_Random_89();
		}

		// Token: 0x0601E942 RID: 125250
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMath_Random_90(double min, double max);

		/// <summary>
		/// Generate pseudo-random numbers distributed according to the uniform
		/// distribution between \a min and \a max.
		///
		/// DON'T USE Random(), RandomSeed(), GetSeed(), Gaussian()
		/// THIS IS STATIC SO THIS IS PRONE TO ERRORS (SPECIALLY FOR REGRESSION TESTS)
		/// THIS IS HERE FOR BACKWARD COMPATIBILITY ONLY.
		/// Instead, for a sequence of random numbers with a uniform distribution
		/// create a vtkMinimalStandardRandomSequence object.
		/// For a sequence of random numbers with a gaussian/normal distribution
		/// create a vtkBoxMuellerRandomSequence object.
		/// </summary>
		// Token: 0x0601E943 RID: 125251 RVA: 0x002B5D14 File Offset: 0x002B3F14
		public static double Random(double min, double max)
		{
			return vtkMath.vtkMath_Random_90(min, max);
		}

		// Token: 0x0601E944 RID: 125252
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMath_RandomSeed_91(int s);

		/// <summary>
		/// Initialize seed value. NOTE: Random() has the bad property that
		/// the first random number returned after RandomSeed() is called
		/// is proportional to the seed value! To help solve this, call
		/// RandomSeed() a few times inside seed. This doesn't ruin the
		/// repeatability of Random().
		///
		/// DON'T USE Random(), RandomSeed(), GetSeed(), Gaussian()
		/// THIS IS STATIC SO THIS IS PRONE TO ERRORS (SPECIALLY FOR REGRESSION TESTS)
		/// THIS IS HERE FOR BACKWARD COMPATIBILITY ONLY.
		/// Instead, for a sequence of random numbers with a uniform distribution
		/// create a vtkMinimalStandardRandomSequence object.
		/// For a sequence of random numbers with a gaussian/normal distribution
		/// create a vtkBoxMuellerRandomSequence object.
		/// </summary>
		// Token: 0x0601E945 RID: 125253 RVA: 0x002B5D2F File Offset: 0x002B3F2F
		public static void RandomSeed(int s)
		{
			vtkMath.vtkMath_RandomSeed_91(s);
		}

		// Token: 0x0601E946 RID: 125254
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMath_RotateVectorByNormalizedQuaternion_92(IntPtr v, IntPtr q, IntPtr r);

		/// <summary>
		/// rotate a vector by a normalized quaternion
		/// using // https://en.wikipedia.org/wiki/Rodrigues%27_rotation_formula
		/// </summary>
		// Token: 0x0601E947 RID: 125255 RVA: 0x002B5D39 File Offset: 0x002B3F39
		public static void RotateVectorByNormalizedQuaternion(IntPtr v, IntPtr q, IntPtr r)
		{
			vtkMath.vtkMath_RotateVectorByNormalizedQuaternion_92(v, q, r);
		}

		// Token: 0x0601E948 RID: 125256
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMath_RotateVectorByWXYZ_93(IntPtr v, IntPtr q, IntPtr r);

		/// <summary>
		/// rotate a vector by WXYZ
		/// using // https://en.wikipedia.org/wiki/Rodrigues%27_rotation_formula
		/// </summary>
		// Token: 0x0601E949 RID: 125257 RVA: 0x002B5D45 File Offset: 0x002B3F45
		public static void RotateVectorByWXYZ(IntPtr v, IntPtr q, IntPtr r)
		{
			vtkMath.vtkMath_RotateVectorByWXYZ_93(v, q, r);
		}

		// Token: 0x0601E94A RID: 125258
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMath_Round_94(float f);

		/// <summary>
		/// Rounds a float to the nearest integer.
		/// </summary>
		// Token: 0x0601E94B RID: 125259 RVA: 0x002B5D54 File Offset: 0x002B3F54
		public static int Round(float f)
		{
			return vtkMath.vtkMath_Round_94(f);
		}

		// Token: 0x0601E94C RID: 125260
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMath_Round_95(double f);

		/// <summary>
		/// Rounds a float to the nearest integer.
		/// </summary>
		// Token: 0x0601E94D RID: 125261 RVA: 0x002B5D70 File Offset: 0x002B3F70
		public static int Round(double f)
		{
			return vtkMath.vtkMath_Round_95(f);
		}

		// Token: 0x0601E94E RID: 125262
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMath_SafeDownCast_96(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E94F RID: 125263 RVA: 0x002B5D8C File Offset: 0x002B3F8C
		public new static vtkMath SafeDownCast(vtkObjectBase o)
		{
			vtkMath vtkMath = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMath.vtkMath_SafeDownCast_96((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMath = (vtkMath)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMath.Register(null);
				}
			}
			return vtkMath;
		}

		// Token: 0x0601E950 RID: 125264
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMath_SignedAngleBetweenVectors_97(IntPtr v1, IntPtr v2, IntPtr vn);

		/// <summary>
		/// Compute signed angle in radians between two vectors with regard to a third orthogonal vector
		/// </summary>
		// Token: 0x0601E951 RID: 125265 RVA: 0x002B5E0C File Offset: 0x002B400C
		public static double SignedAngleBetweenVectors(IntPtr v1, IntPtr v2, IntPtr vn)
		{
			return vtkMath.vtkMath_SignedAngleBetweenVectors_97(v1, v2, vn);
		}

		// Token: 0x0601E952 RID: 125266
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMath_Solve3PointCircle_98(IntPtr p1, IntPtr p2, IntPtr p3, IntPtr center);

		/// <summary>
		/// In Euclidean space, there is a unique circle passing through any given
		/// three non-collinear points P1, P2, and P3. Using Cartesian coordinates
		/// to represent these points as spatial vectors, it is possible to use the
		/// dot product and cross product to calculate the radius and center of the
		/// circle. See: http://en.wikipedia.org/wiki/Circumscribed_circle and more
		/// specifically the section Barycentric coordinates from cross- and
		/// dot-products
		/// </summary>
		// Token: 0x0601E953 RID: 125267 RVA: 0x002B5E28 File Offset: 0x002B4028
		public static double Solve3PointCircle(IntPtr p1, IntPtr p2, IntPtr p3, IntPtr center)
		{
			return vtkMath.vtkMath_Solve3PointCircle_98(p1, p2, p3, center);
		}

		// Token: 0x0601E954 RID: 125268
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMath_SolveLinearSystemGEPP2x2_99(double a00, double a01, double a10, double a11, double b0, double b1, ref double x0, ref double x1);

		/// <summary>
		/// Solve linear equation Ax = b using Gaussian Elimination with Partial Pivoting
		/// for a 2x2 system. If the matrix is found to be singular within a small numerical
		/// tolerance close to machine precision then 0 is returned.
		/// Note: Even if method succeeded the matrix A could be close to singular.
		///       The solution should be checked against relevant tolerance criteria.
		/// </summary>
		// Token: 0x0601E955 RID: 125269 RVA: 0x002B5E48 File Offset: 0x002B4048
		public static int SolveLinearSystemGEPP2x2(double a00, double a01, double a10, double a11, double b0, double b1, ref double x0, ref double x1)
		{
			return vtkMath.vtkMath_SolveLinearSystemGEPP2x2_99(a00, a01, a10, a11, b0, b1, ref x0, ref x1);
		}

		// Token: 0x0601E956 RID: 125270
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMath_Subtract_100(IntPtr a, IntPtr b, IntPtr c);

		/// <summary>
		/// Subtraction of two 3-vectors (float version). Result is stored in c according to c = a - b.
		/// </summary>
		// Token: 0x0601E957 RID: 125271 RVA: 0x002B5E6D File Offset: 0x002B406D
		public static void Subtract(IntPtr a, IntPtr b, IntPtr c)
		{
			vtkMath.vtkMath_Subtract_100(a, b, c);
		}

		// Token: 0x0601E958 RID: 125272
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMath_UninitializeBounds_101(IntPtr bounds);

		/// <summary>
		/// Set the bounds to an uninitialized state
		/// </summary>
		// Token: 0x0601E959 RID: 125273 RVA: 0x002B5E79 File Offset: 0x002B4079
		public static void UninitializeBounds(IntPtr bounds)
		{
			vtkMath.vtkMath_UninitializeBounds_101(bounds);
		}

		// Token: 0x0601E95A RID: 125274
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMath_XYZToLab_102(IntPtr xyz, IntPtr lab);

		/// <summary>
		/// Convert Color from the CIE XYZ system to CIE-L*ab.
		/// </summary>
		// Token: 0x0601E95B RID: 125275 RVA: 0x002B5E83 File Offset: 0x002B4083
		public static void XYZToLab(IntPtr xyz, IntPtr lab)
		{
			vtkMath.vtkMath_XYZToLab_102(xyz, lab);
		}

		// Token: 0x0601E95C RID: 125276
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMath_XYZToLab_103(double x, double y, double z, IntPtr L, IntPtr a, IntPtr b);

		/// <summary>
		/// Convert Color from the CIE XYZ system to CIE-L*ab.
		/// </summary>
		// Token: 0x0601E95D RID: 125277 RVA: 0x002B5E8E File Offset: 0x002B408E
		public static void XYZToLab(double x, double y, double z, IntPtr L, IntPtr a, IntPtr b)
		{
			vtkMath.vtkMath_XYZToLab_103(x, y, z, L, a, b);
		}

		// Token: 0x0601E95E RID: 125278
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMath_XYZToRGB_104(IntPtr xyz, IntPtr rgb);

		/// <summary>
		/// Convert color from the CIE XYZ system to RGB.
		/// </summary>
		// Token: 0x0601E95F RID: 125279 RVA: 0x002B5E9F File Offset: 0x002B409F
		public static void XYZToRGB(IntPtr xyz, IntPtr rgb)
		{
			vtkMath.vtkMath_XYZToRGB_104(xyz, rgb);
		}

		// Token: 0x0601E960 RID: 125280
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMath_XYZToRGB_105(double x, double y, double z, IntPtr r, IntPtr g, IntPtr b);

		/// <summary>
		/// Convert color from the CIE XYZ system to RGB.
		/// </summary>
		// Token: 0x0601E961 RID: 125281 RVA: 0x002B5EAA File Offset: 0x002B40AA
		public static void XYZToRGB(double x, double y, double z, IntPtr r, IntPtr g, IntPtr b)
		{
			vtkMath.vtkMath_XYZToRGB_105(x, y, z, r, g, b);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020B9 RID: 8377
		public new const string MRFullTypeName = "Kitware.VTK.vtkMath";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020BA RID: 8378
		public new static readonly string MRClassNameKey = "class vtkMath";

		/// <summary>
		/// Support the convolution operations.
		/// </summary>
		// Token: 0x02000B6E RID: 2926
		public enum ConvolutionMode
		{
			/// <summary>enum member</summary>
			// Token: 0x040020BC RID: 8380
			FULL,
			/// <summary>enum member</summary>
			// Token: 0x040020BD RID: 8381
			SAME,
			/// <summary>enum member</summary>
			// Token: 0x040020BE RID: 8382
			VALID
		}
	}
}
