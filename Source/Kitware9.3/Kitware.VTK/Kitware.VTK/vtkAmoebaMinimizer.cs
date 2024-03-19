using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAmoebaMinimizer
	/// </summary>
	/// <remarks>
	///    nonlinear optimization with a simplex
	///
	/// vtkAmoebaMinimizer will modify a set of parameters in order to find
	/// the minimum of a specified function.  The method used is commonly
	/// known as the amoeba method, it constructs an n-dimensional simplex
	/// in parameter space (i.e. a tetrahedron if the number or parameters
	/// is 3) and moves the vertices around parameter space until a local
	/// minimum is found.  The amoeba method is robust, reasonably efficient,
	/// but is not guaranteed to find the global minimum if several local
	/// minima exist.
	/// </remarks>
	// Token: 0x02000B12 RID: 2834
	public class vtkAmoebaMinimizer : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601DC8F RID: 121999 RVA: 0x002A10AF File Offset: 0x0029F2AF
		static vtkAmoebaMinimizer()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAmoebaMinimizer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAmoebaMinimizer"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601DC90 RID: 122000 RVA: 0x002A10D7 File Offset: 0x0029F2D7
		public vtkAmoebaMinimizer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601DC91 RID: 122001
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAmoebaMinimizer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DC92 RID: 122002 RVA: 0x002A10E8 File Offset: 0x0029F2E8
		public new static vtkAmoebaMinimizer New()
		{
			vtkAmoebaMinimizer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAmoebaMinimizer.vtkAmoebaMinimizer_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAmoebaMinimizer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DC93 RID: 122003 RVA: 0x002A113C File Offset: 0x0029F33C
		public vtkAmoebaMinimizer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAmoebaMinimizer.vtkAmoebaMinimizer_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601DC94 RID: 122004 RVA: 0x002A1180 File Offset: 0x0029F380
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601DC95 RID: 122005
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAmoebaMinimizer_EvaluateFunction_01(HandleRef pThis);

		/// <summary>
		/// Evaluate the function.  This is usually called internally by the
		/// minimization code, but it is provided here as a public method.
		/// </summary>
		// Token: 0x0601DC96 RID: 122006 RVA: 0x002A118B File Offset: 0x0029F38B
		public void EvaluateFunction()
		{
			vtkAmoebaMinimizer.vtkAmoebaMinimizer_EvaluateFunction_01(base.GetCppThis());
		}

		// Token: 0x0601DC97 RID: 122007
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAmoebaMinimizer_GetContractionRatio_02(HandleRef pThis);

		/// <summary>
		/// Set the amoeba contraction ratio.  The default value of 0.5 gives
		/// fast convergence, but larger values such as 0.6 or 0.7 provide
		/// greater stability.
		/// </summary>
		// Token: 0x0601DC98 RID: 122008 RVA: 0x002A119C File Offset: 0x0029F39C
		public virtual double GetContractionRatio()
		{
			return vtkAmoebaMinimizer.vtkAmoebaMinimizer_GetContractionRatio_02(base.GetCppThis());
		}

		// Token: 0x0601DC99 RID: 122009
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAmoebaMinimizer_GetContractionRatioMaxValue_03(HandleRef pThis);

		/// <summary>
		/// Set the amoeba contraction ratio.  The default value of 0.5 gives
		/// fast convergence, but larger values such as 0.6 or 0.7 provide
		/// greater stability.
		/// </summary>
		// Token: 0x0601DC9A RID: 122010 RVA: 0x002A11BC File Offset: 0x0029F3BC
		public virtual double GetContractionRatioMaxValue()
		{
			return vtkAmoebaMinimizer.vtkAmoebaMinimizer_GetContractionRatioMaxValue_03(base.GetCppThis());
		}

		// Token: 0x0601DC9B RID: 122011
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAmoebaMinimizer_GetContractionRatioMinValue_04(HandleRef pThis);

		/// <summary>
		/// Set the amoeba contraction ratio.  The default value of 0.5 gives
		/// fast convergence, but larger values such as 0.6 or 0.7 provide
		/// greater stability.
		/// </summary>
		// Token: 0x0601DC9C RID: 122012 RVA: 0x002A11DC File Offset: 0x0029F3DC
		public virtual double GetContractionRatioMinValue()
		{
			return vtkAmoebaMinimizer.vtkAmoebaMinimizer_GetContractionRatioMinValue_04(base.GetCppThis());
		}

		// Token: 0x0601DC9D RID: 122013
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAmoebaMinimizer_GetExpansionRatio_05(HandleRef pThis);

		/// <summary>
		/// Set the amoeba expansion ratio.  The default value is 2.0, which
		/// provides rapid expansion.  Values between 1.1 and 2.0 are valid.
		/// </summary>
		// Token: 0x0601DC9E RID: 122014 RVA: 0x002A11FC File Offset: 0x0029F3FC
		public virtual double GetExpansionRatio()
		{
			return vtkAmoebaMinimizer.vtkAmoebaMinimizer_GetExpansionRatio_05(base.GetCppThis());
		}

		// Token: 0x0601DC9F RID: 122015
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAmoebaMinimizer_GetExpansionRatioMaxValue_06(HandleRef pThis);

		/// <summary>
		/// Set the amoeba expansion ratio.  The default value is 2.0, which
		/// provides rapid expansion.  Values between 1.1 and 2.0 are valid.
		/// </summary>
		// Token: 0x0601DCA0 RID: 122016 RVA: 0x002A121C File Offset: 0x0029F41C
		public virtual double GetExpansionRatioMaxValue()
		{
			return vtkAmoebaMinimizer.vtkAmoebaMinimizer_GetExpansionRatioMaxValue_06(base.GetCppThis());
		}

		// Token: 0x0601DCA1 RID: 122017
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAmoebaMinimizer_GetExpansionRatioMinValue_07(HandleRef pThis);

		/// <summary>
		/// Set the amoeba expansion ratio.  The default value is 2.0, which
		/// provides rapid expansion.  Values between 1.1 and 2.0 are valid.
		/// </summary>
		// Token: 0x0601DCA2 RID: 122018 RVA: 0x002A123C File Offset: 0x0029F43C
		public virtual double GetExpansionRatioMinValue()
		{
			return vtkAmoebaMinimizer.vtkAmoebaMinimizer_GetExpansionRatioMinValue_07(base.GetCppThis());
		}

		// Token: 0x0601DCA3 RID: 122019
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAmoebaMinimizer_GetFunctionEvaluations_08(HandleRef pThis);

		/// <summary>
		/// Return the number of times that the function has been evaluated.
		/// </summary>
		// Token: 0x0601DCA4 RID: 122020 RVA: 0x002A125C File Offset: 0x0029F45C
		public virtual int GetFunctionEvaluations()
		{
			return vtkAmoebaMinimizer.vtkAmoebaMinimizer_GetFunctionEvaluations_08(base.GetCppThis());
		}

		// Token: 0x0601DCA5 RID: 122021
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAmoebaMinimizer_GetFunctionValue_09(HandleRef pThis);

		/// <summary>
		/// Get the function value resulting from the minimization.
		/// </summary>
		// Token: 0x0601DCA6 RID: 122022 RVA: 0x002A127C File Offset: 0x0029F47C
		public double GetFunctionValue()
		{
			return vtkAmoebaMinimizer.vtkAmoebaMinimizer_GetFunctionValue_09(base.GetCppThis());
		}

		// Token: 0x0601DCA7 RID: 122023
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAmoebaMinimizer_GetIterations_10(HandleRef pThis);

		/// <summary>
		/// Return the number of iterations that have been performed.  This
		/// is not necessarily the same as the number of function evaluations.
		/// </summary>
		// Token: 0x0601DCA8 RID: 122024 RVA: 0x002A129C File Offset: 0x0029F49C
		public virtual int GetIterations()
		{
			return vtkAmoebaMinimizer.vtkAmoebaMinimizer_GetIterations_10(base.GetCppThis());
		}

		// Token: 0x0601DCA9 RID: 122025
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAmoebaMinimizer_GetMaxIterations_11(HandleRef pThis);

		/// <summary>
		/// Specify the maximum number of iterations to try before giving up.
		/// </summary>
		// Token: 0x0601DCAA RID: 122026 RVA: 0x002A12BC File Offset: 0x0029F4BC
		public virtual int GetMaxIterations()
		{
			return vtkAmoebaMinimizer.vtkAmoebaMinimizer_GetMaxIterations_11(base.GetCppThis());
		}

		// Token: 0x0601DCAB RID: 122027
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAmoebaMinimizer_GetNumberOfGenerationsFromBase_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DCAC RID: 122028 RVA: 0x002A12DC File Offset: 0x0029F4DC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAmoebaMinimizer.vtkAmoebaMinimizer_GetNumberOfGenerationsFromBase_12(base.GetCppThis(), type);
		}

		// Token: 0x0601DCAD RID: 122029
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAmoebaMinimizer_GetNumberOfGenerationsFromBaseType_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DCAE RID: 122030 RVA: 0x002A12FC File Offset: 0x0029F4FC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAmoebaMinimizer.vtkAmoebaMinimizer_GetNumberOfGenerationsFromBaseType_13(type);
		}

		// Token: 0x0601DCAF RID: 122031
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAmoebaMinimizer_GetNumberOfParameters_14(HandleRef pThis);

		/// <summary>
		/// Get the number of parameters that have been set.
		/// </summary>
		// Token: 0x0601DCB0 RID: 122032 RVA: 0x002A1318 File Offset: 0x0029F518
		public int GetNumberOfParameters()
		{
			return vtkAmoebaMinimizer.vtkAmoebaMinimizer_GetNumberOfParameters_14(base.GetCppThis());
		}

		// Token: 0x0601DCB1 RID: 122033
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAmoebaMinimizer_GetParameterName_15(HandleRef pThis, int i);

		/// <summary>
		/// For completeness, an unchecked method to get the name for particular
		/// parameter (the result will be nullptr if no name was set).
		/// </summary>
		// Token: 0x0601DCB2 RID: 122034 RVA: 0x002A1338 File Offset: 0x0029F538
		public string GetParameterName(int i)
		{
			string s = Marshal.PtrToStringAnsi(vtkAmoebaMinimizer.vtkAmoebaMinimizer_GetParameterName_15(base.GetCppThis(), i));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601DCB3 RID: 122035
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAmoebaMinimizer_GetParameterScale_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Set the scale to use when modifying a parameter, i.e. the
		/// initial amount by which the parameter will be modified
		/// during the search for the minimum.  It is preferable to
		/// identify scalars by name rather than by number.
		/// </summary>
		// Token: 0x0601DCB4 RID: 122036 RVA: 0x002A1374 File Offset: 0x0029F574
		public double GetParameterScale(string name)
		{
			return vtkAmoebaMinimizer.vtkAmoebaMinimizer_GetParameterScale_16(base.GetCppThis(), name);
		}

		// Token: 0x0601DCB5 RID: 122037
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAmoebaMinimizer_GetParameterScale_17(HandleRef pThis, int i);

		/// <summary>
		/// Set the scale to use when modifying a parameter, i.e. the
		/// initial amount by which the parameter will be modified
		/// during the search for the minimum.  It is preferable to
		/// identify scalars by name rather than by number.
		/// </summary>
		// Token: 0x0601DCB6 RID: 122038 RVA: 0x002A1394 File Offset: 0x0029F594
		public double GetParameterScale(int i)
		{
			return vtkAmoebaMinimizer.vtkAmoebaMinimizer_GetParameterScale_17(base.GetCppThis(), i);
		}

		// Token: 0x0601DCB7 RID: 122039
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAmoebaMinimizer_GetParameterTolerance_18(HandleRef pThis);

		/// <summary>
		/// Specify the parameter tolerance to aim for during the minimization.
		/// </summary>
		// Token: 0x0601DCB8 RID: 122040 RVA: 0x002A13B4 File Offset: 0x0029F5B4
		public virtual double GetParameterTolerance()
		{
			return vtkAmoebaMinimizer.vtkAmoebaMinimizer_GetParameterTolerance_18(base.GetCppThis());
		}

		// Token: 0x0601DCB9 RID: 122041
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAmoebaMinimizer_GetParameterValue_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Get the value of a parameter at the current stage of the minimization.
		/// Call this method within the function that you are minimizing in order
		/// to get the current parameter values.  It is preferable to specify
		/// parameters by name rather than by index.
		/// </summary>
		// Token: 0x0601DCBA RID: 122042 RVA: 0x002A13D4 File Offset: 0x0029F5D4
		public double GetParameterValue(string name)
		{
			return vtkAmoebaMinimizer.vtkAmoebaMinimizer_GetParameterValue_19(base.GetCppThis(), name);
		}

		// Token: 0x0601DCBB RID: 122043
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAmoebaMinimizer_GetParameterValue_20(HandleRef pThis, int i);

		/// <summary>
		/// Get the value of a parameter at the current stage of the minimization.
		/// Call this method within the function that you are minimizing in order
		/// to get the current parameter values.  It is preferable to specify
		/// parameters by name rather than by index.
		/// </summary>
		// Token: 0x0601DCBC RID: 122044 RVA: 0x002A13F4 File Offset: 0x0029F5F4
		public double GetParameterValue(int i)
		{
			return vtkAmoebaMinimizer.vtkAmoebaMinimizer_GetParameterValue_20(base.GetCppThis(), i);
		}

		// Token: 0x0601DCBD RID: 122045
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAmoebaMinimizer_GetTolerance_21(HandleRef pThis);

		/// <summary>
		/// Specify the value tolerance to aim for during the minimization.
		/// </summary>
		// Token: 0x0601DCBE RID: 122046 RVA: 0x002A1414 File Offset: 0x0029F614
		public virtual double GetTolerance()
		{
			return vtkAmoebaMinimizer.vtkAmoebaMinimizer_GetTolerance_21(base.GetCppThis());
		}

		// Token: 0x0601DCBF RID: 122047
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAmoebaMinimizer_Initialize_22(HandleRef pThis);

		/// <summary>
		/// Initialize the minimizer.  This will reset the number of parameters to
		/// zero so that the minimizer can be reused.
		/// </summary>
		// Token: 0x0601DCC0 RID: 122048 RVA: 0x002A1433 File Offset: 0x0029F633
		public void Initialize()
		{
			vtkAmoebaMinimizer.vtkAmoebaMinimizer_Initialize_22(base.GetCppThis());
		}

		// Token: 0x0601DCC1 RID: 122049
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAmoebaMinimizer_IsA_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DCC2 RID: 122050 RVA: 0x002A1444 File Offset: 0x0029F644
		public override int IsA(string type)
		{
			return vtkAmoebaMinimizer.vtkAmoebaMinimizer_IsA_23(base.GetCppThis(), type);
		}

		// Token: 0x0601DCC3 RID: 122051
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAmoebaMinimizer_IsTypeOf_24([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DCC4 RID: 122052 RVA: 0x002A1464 File Offset: 0x0029F664
		public new static int IsTypeOf(string type)
		{
			return vtkAmoebaMinimizer.vtkAmoebaMinimizer_IsTypeOf_24(type);
		}

		// Token: 0x0601DCC5 RID: 122053
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAmoebaMinimizer_Iterate_25(HandleRef pThis);

		/// <summary>
		/// Perform one iteration of minimization.  Returns zero if the tolerance
		/// stopping criterion has been met.
		/// </summary>
		// Token: 0x0601DCC6 RID: 122054 RVA: 0x002A1480 File Offset: 0x0029F680
		public virtual int Iterate()
		{
			return vtkAmoebaMinimizer.vtkAmoebaMinimizer_Iterate_25(base.GetCppThis());
		}

		// Token: 0x0601DCC7 RID: 122055
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAmoebaMinimizer_Minimize_26(HandleRef pThis);

		/// <summary>
		/// Iterate until the minimum is found to within the specified tolerance,
		/// or until the MaxIterations has been reached.
		/// </summary>
		// Token: 0x0601DCC8 RID: 122056 RVA: 0x002A149F File Offset: 0x0029F69F
		public virtual void Minimize()
		{
			vtkAmoebaMinimizer.vtkAmoebaMinimizer_Minimize_26(base.GetCppThis());
		}

		// Token: 0x0601DCC9 RID: 122057
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAmoebaMinimizer_NewInstance_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DCCA RID: 122058 RVA: 0x002A14B0 File Offset: 0x0029F6B0
		public new vtkAmoebaMinimizer NewInstance()
		{
			vtkAmoebaMinimizer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAmoebaMinimizer.vtkAmoebaMinimizer_NewInstance_28(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAmoebaMinimizer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601DCCB RID: 122059
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAmoebaMinimizer_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DCCC RID: 122060 RVA: 0x002A150C File Offset: 0x0029F70C
		public new static vtkAmoebaMinimizer SafeDownCast(vtkObjectBase o)
		{
			vtkAmoebaMinimizer vtkAmoebaMinimizer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAmoebaMinimizer.vtkAmoebaMinimizer_SafeDownCast_29((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAmoebaMinimizer = (vtkAmoebaMinimizer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAmoebaMinimizer.Register(null);
				}
			}
			return vtkAmoebaMinimizer;
		}

		// Token: 0x0601DCCD RID: 122061
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAmoebaMinimizer_SetContractionRatio_30(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the amoeba contraction ratio.  The default value of 0.5 gives
		/// fast convergence, but larger values such as 0.6 or 0.7 provide
		/// greater stability.
		/// </summary>
		// Token: 0x0601DCCE RID: 122062 RVA: 0x002A158B File Offset: 0x0029F78B
		public virtual void SetContractionRatio(double _arg)
		{
			vtkAmoebaMinimizer.vtkAmoebaMinimizer_SetContractionRatio_30(base.GetCppThis(), _arg);
		}

		// Token: 0x0601DCCF RID: 122063
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAmoebaMinimizer_SetExpansionRatio_31(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the amoeba expansion ratio.  The default value is 2.0, which
		/// provides rapid expansion.  Values between 1.1 and 2.0 are valid.
		/// </summary>
		// Token: 0x0601DCD0 RID: 122064 RVA: 0x002A159B File Offset: 0x0029F79B
		public virtual void SetExpansionRatio(double _arg)
		{
			vtkAmoebaMinimizer.vtkAmoebaMinimizer_SetExpansionRatio_31(base.GetCppThis(), _arg);
		}

		// Token: 0x0601DCD1 RID: 122065
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAmoebaMinimizer_SetFunctionValue_32(HandleRef pThis, double _arg);

		/// <summary>
		/// Get the function value resulting from the minimization.
		/// </summary>
		// Token: 0x0601DCD2 RID: 122066 RVA: 0x002A15AB File Offset: 0x0029F7AB
		public virtual void SetFunctionValue(double _arg)
		{
			vtkAmoebaMinimizer.vtkAmoebaMinimizer_SetFunctionValue_32(base.GetCppThis(), _arg);
		}

		// Token: 0x0601DCD3 RID: 122067
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAmoebaMinimizer_SetMaxIterations_33(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the maximum number of iterations to try before giving up.
		/// </summary>
		// Token: 0x0601DCD4 RID: 122068 RVA: 0x002A15BB File Offset: 0x0029F7BB
		public virtual void SetMaxIterations(int _arg)
		{
			vtkAmoebaMinimizer.vtkAmoebaMinimizer_SetMaxIterations_33(base.GetCppThis(), _arg);
		}

		// Token: 0x0601DCD5 RID: 122069
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAmoebaMinimizer_SetParameterScale_34(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, double scale);

		/// <summary>
		/// Set the scale to use when modifying a parameter, i.e. the
		/// initial amount by which the parameter will be modified
		/// during the search for the minimum.  It is preferable to
		/// identify scalars by name rather than by number.
		/// </summary>
		// Token: 0x0601DCD6 RID: 122070 RVA: 0x002A15CB File Offset: 0x0029F7CB
		public void SetParameterScale(string name, double scale)
		{
			vtkAmoebaMinimizer.vtkAmoebaMinimizer_SetParameterScale_34(base.GetCppThis(), name, scale);
		}

		// Token: 0x0601DCD7 RID: 122071
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAmoebaMinimizer_SetParameterScale_35(HandleRef pThis, int i, double scale);

		/// <summary>
		/// Set the scale to use when modifying a parameter, i.e. the
		/// initial amount by which the parameter will be modified
		/// during the search for the minimum.  It is preferable to
		/// identify scalars by name rather than by number.
		/// </summary>
		// Token: 0x0601DCD8 RID: 122072 RVA: 0x002A15DC File Offset: 0x0029F7DC
		public void SetParameterScale(int i, double scale)
		{
			vtkAmoebaMinimizer.vtkAmoebaMinimizer_SetParameterScale_35(base.GetCppThis(), i, scale);
		}

		// Token: 0x0601DCD9 RID: 122073
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAmoebaMinimizer_SetParameterTolerance_36(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the parameter tolerance to aim for during the minimization.
		/// </summary>
		// Token: 0x0601DCDA RID: 122074 RVA: 0x002A15ED File Offset: 0x0029F7ED
		public virtual void SetParameterTolerance(double _arg)
		{
			vtkAmoebaMinimizer.vtkAmoebaMinimizer_SetParameterTolerance_36(base.GetCppThis(), _arg);
		}

		// Token: 0x0601DCDB RID: 122075
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAmoebaMinimizer_SetParameterValue_37(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, double value);

		/// <summary>
		/// Set the initial value for the specified parameter.  Calling
		/// this function for any parameter will reset the Iterations
		/// and the FunctionEvaluations counts to zero.  You must also
		/// use SetParameterScale() to specify the step size by which the
		/// parameter will be modified during the minimization.  It is
		/// preferable to specify parameters by name, rather than by
		/// number.
		/// </summary>
		// Token: 0x0601DCDC RID: 122076 RVA: 0x002A15FD File Offset: 0x0029F7FD
		public void SetParameterValue(string name, double value)
		{
			vtkAmoebaMinimizer.vtkAmoebaMinimizer_SetParameterValue_37(base.GetCppThis(), name, value);
		}

		// Token: 0x0601DCDD RID: 122077
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAmoebaMinimizer_SetParameterValue_38(HandleRef pThis, int i, double value);

		/// <summary>
		/// Set the initial value for the specified parameter.  Calling
		/// this function for any parameter will reset the Iterations
		/// and the FunctionEvaluations counts to zero.  You must also
		/// use SetParameterScale() to specify the step size by which the
		/// parameter will be modified during the minimization.  It is
		/// preferable to specify parameters by name, rather than by
		/// number.
		/// </summary>
		// Token: 0x0601DCDE RID: 122078 RVA: 0x002A160E File Offset: 0x0029F80E
		public void SetParameterValue(int i, double value)
		{
			vtkAmoebaMinimizer.vtkAmoebaMinimizer_SetParameterValue_38(base.GetCppThis(), i, value);
		}

		// Token: 0x0601DCDF RID: 122079
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAmoebaMinimizer_SetTolerance_39(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the value tolerance to aim for during the minimization.
		/// </summary>
		// Token: 0x0601DCE0 RID: 122080 RVA: 0x002A161F File Offset: 0x0029F81F
		public virtual void SetTolerance(double _arg)
		{
			vtkAmoebaMinimizer.vtkAmoebaMinimizer_SetTolerance_39(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F55 RID: 8021
		public new const string MRFullTypeName = "Kitware.VTK.vtkAmoebaMinimizer";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F56 RID: 8022
		public new static readonly string MRClassNameKey = "class vtkAmoebaMinimizer";
	}
}
