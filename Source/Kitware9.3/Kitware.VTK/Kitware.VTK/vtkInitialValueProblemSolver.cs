using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInitialValueProblemSolver
	/// </summary>
	/// <remarks>
	///    Integrate a set of ordinary
	/// differential equations (initial value problem) in time.
	///
	///
	/// Given a vtkFunctionSet which returns dF_i(x_j, t)/dt given x_j and
	/// t, vtkInitialValueProblemSolver computes the value of F_i at t+deltat.
	///
	/// @warning
	/// vtkInitialValueProblemSolver and it's subclasses are not thread-safe.
	/// You should create a new integrator for each thread.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRungeKutta2 vtkRungeKutta4
	/// </seealso>
	// Token: 0x02000B19 RID: 2841
	public class vtkInitialValueProblemSolver : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601DD01 RID: 122113 RVA: 0x002A18EB File Offset: 0x0029FAEB
		static vtkInitialValueProblemSolver()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInitialValueProblemSolver.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInitialValueProblemSolver"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601DD02 RID: 122114 RVA: 0x002A1913 File Offset: 0x0029FB13
		public vtkInitialValueProblemSolver(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601DD03 RID: 122115 RVA: 0x002A1921 File Offset: 0x0029FB21
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601DD04 RID: 122116
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInitialValueProblemSolver_ComputeNextStep_01(HandleRef pThis, IntPtr xprev, IntPtr xnext, double t, ref double delT, double maxError, ref double error);

		/// <summary>
		/// Given initial values, xprev , initial time, t and a requested time
		/// interval, delT calculate values of x at t+delTActual (xnext).
		/// For certain concrete sub-classes delTActual != delT. This occurs
		/// when the solver supports adaptive stepsize control. If this
		/// is the case, the solver tries to change to stepsize such that
		/// the (estimated) error of the integration is less than maxError.
		/// The solver will not set the stepsize smaller than minStep or
		/// larger than maxStep.
		/// Also note that delT is an in/out argument. Adaptive solvers
		/// will modify delT to reflect the best (estimated) size for the next
		/// integration step.
		/// An estimated value for the error is returned (by reference) in error.
		/// Note that only some concrete sub-classes support this. Otherwise,
		/// the error is set to 0.
		/// This method returns an error code representing the nature of
		/// the failure:
		/// OutOfDomain = 1,
		/// NotInitialized = 2,
		/// UnexpectedValue = 3
		/// </summary>
		// Token: 0x0601DD05 RID: 122117 RVA: 0x002A192C File Offset: 0x0029FB2C
		public virtual int ComputeNextStep(IntPtr xprev, IntPtr xnext, double t, ref double delT, double maxError, ref double error)
		{
			return vtkInitialValueProblemSolver.vtkInitialValueProblemSolver_ComputeNextStep_01(base.GetCppThis(), xprev, xnext, t, ref delT, maxError, ref error);
		}

		// Token: 0x0601DD06 RID: 122118
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInitialValueProblemSolver_ComputeNextStep_02(HandleRef pThis, IntPtr xprev, IntPtr xnext, double t, ref double delT, double maxError, ref double error, IntPtr userData);

		/// <summary>
		/// Given initial values, xprev , initial time, t and a requested time
		/// interval, delT calculate values of x at t+delTActual (xnext).
		/// For certain concrete sub-classes delTActual != delT. This occurs
		/// when the solver supports adaptive stepsize control. If this
		/// is the case, the solver tries to change to stepsize such that
		/// the (estimated) error of the integration is less than maxError.
		/// The solver will not set the stepsize smaller than minStep or
		/// larger than maxStep.
		/// Also note that delT is an in/out argument. Adaptive solvers
		/// will modify delT to reflect the best (estimated) size for the next
		/// integration step.
		/// An estimated value for the error is returned (by reference) in error.
		/// Note that only some concrete sub-classes support this. Otherwise,
		/// the error is set to 0.
		/// This method returns an error code representing the nature of
		/// the failure:
		/// OutOfDomain = 1,
		/// NotInitialized = 2,
		/// UnexpectedValue = 3
		/// </summary>
		// Token: 0x0601DD07 RID: 122119 RVA: 0x002A1954 File Offset: 0x0029FB54
		public virtual int ComputeNextStep(IntPtr xprev, IntPtr xnext, double t, ref double delT, double maxError, ref double error, IntPtr userData)
		{
			return vtkInitialValueProblemSolver.vtkInitialValueProblemSolver_ComputeNextStep_02(base.GetCppThis(), xprev, xnext, t, ref delT, maxError, ref error, userData);
		}

		// Token: 0x0601DD08 RID: 122120
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInitialValueProblemSolver_ComputeNextStep_03(HandleRef pThis, IntPtr xprev, IntPtr dxprev, IntPtr xnext, double t, ref double delT, double maxError, ref double error);

		/// <summary>
		/// Given initial values, xprev , initial time, t and a requested time
		/// interval, delT calculate values of x at t+delTActual (xnext).
		/// For certain concrete sub-classes delTActual != delT. This occurs
		/// when the solver supports adaptive stepsize control. If this
		/// is the case, the solver tries to change to stepsize such that
		/// the (estimated) error of the integration is less than maxError.
		/// The solver will not set the stepsize smaller than minStep or
		/// larger than maxStep.
		/// Also note that delT is an in/out argument. Adaptive solvers
		/// will modify delT to reflect the best (estimated) size for the next
		/// integration step.
		/// An estimated value for the error is returned (by reference) in error.
		/// Note that only some concrete sub-classes support this. Otherwise,
		/// the error is set to 0.
		/// This method returns an error code representing the nature of
		/// the failure:
		/// OutOfDomain = 1,
		/// NotInitialized = 2,
		/// UnexpectedValue = 3
		/// </summary>
		// Token: 0x0601DD09 RID: 122121 RVA: 0x002A1980 File Offset: 0x0029FB80
		public virtual int ComputeNextStep(IntPtr xprev, IntPtr dxprev, IntPtr xnext, double t, ref double delT, double maxError, ref double error)
		{
			return vtkInitialValueProblemSolver.vtkInitialValueProblemSolver_ComputeNextStep_03(base.GetCppThis(), xprev, dxprev, xnext, t, ref delT, maxError, ref error);
		}

		// Token: 0x0601DD0A RID: 122122
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInitialValueProblemSolver_ComputeNextStep_04(HandleRef pThis, IntPtr xprev, IntPtr dxprev, IntPtr xnext, double t, ref double delT, double maxError, ref double error, IntPtr userData);

		/// <summary>
		/// Given initial values, xprev , initial time, t and a requested time
		/// interval, delT calculate values of x at t+delTActual (xnext).
		/// For certain concrete sub-classes delTActual != delT. This occurs
		/// when the solver supports adaptive stepsize control. If this
		/// is the case, the solver tries to change to stepsize such that
		/// the (estimated) error of the integration is less than maxError.
		/// The solver will not set the stepsize smaller than minStep or
		/// larger than maxStep.
		/// Also note that delT is an in/out argument. Adaptive solvers
		/// will modify delT to reflect the best (estimated) size for the next
		/// integration step.
		/// An estimated value for the error is returned (by reference) in error.
		/// Note that only some concrete sub-classes support this. Otherwise,
		/// the error is set to 0.
		/// This method returns an error code representing the nature of
		/// the failure:
		/// OutOfDomain = 1,
		/// NotInitialized = 2,
		/// UnexpectedValue = 3
		/// </summary>
		// Token: 0x0601DD0B RID: 122123 RVA: 0x002A19AC File Offset: 0x0029FBAC
		public virtual int ComputeNextStep(IntPtr xprev, IntPtr dxprev, IntPtr xnext, double t, ref double delT, double maxError, ref double error, IntPtr userData)
		{
			return vtkInitialValueProblemSolver.vtkInitialValueProblemSolver_ComputeNextStep_04(base.GetCppThis(), xprev, dxprev, xnext, t, ref delT, maxError, ref error, userData);
		}

		// Token: 0x0601DD0C RID: 122124
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInitialValueProblemSolver_ComputeNextStep_05(HandleRef pThis, IntPtr xprev, IntPtr xnext, double t, ref double delT, ref double delTActual, double minStep, double maxStep, double maxError, ref double error);

		/// <summary>
		/// Given initial values, xprev , initial time, t and a requested time
		/// interval, delT calculate values of x at t+delTActual (xnext).
		/// For certain concrete sub-classes delTActual != delT. This occurs
		/// when the solver supports adaptive stepsize control. If this
		/// is the case, the solver tries to change to stepsize such that
		/// the (estimated) error of the integration is less than maxError.
		/// The solver will not set the stepsize smaller than minStep or
		/// larger than maxStep.
		/// Also note that delT is an in/out argument. Adaptive solvers
		/// will modify delT to reflect the best (estimated) size for the next
		/// integration step.
		/// An estimated value for the error is returned (by reference) in error.
		/// Note that only some concrete sub-classes support this. Otherwise,
		/// the error is set to 0.
		/// This method returns an error code representing the nature of
		/// the failure:
		/// OutOfDomain = 1,
		/// NotInitialized = 2,
		/// UnexpectedValue = 3
		/// </summary>
		// Token: 0x0601DD0D RID: 122125 RVA: 0x002A19D8 File Offset: 0x0029FBD8
		public virtual int ComputeNextStep(IntPtr xprev, IntPtr xnext, double t, ref double delT, ref double delTActual, double minStep, double maxStep, double maxError, ref double error)
		{
			return vtkInitialValueProblemSolver.vtkInitialValueProblemSolver_ComputeNextStep_05(base.GetCppThis(), xprev, xnext, t, ref delT, ref delTActual, minStep, maxStep, maxError, ref error);
		}

		// Token: 0x0601DD0E RID: 122126
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInitialValueProblemSolver_ComputeNextStep_06(HandleRef pThis, IntPtr xprev, IntPtr xnext, double t, ref double delT, ref double delTActual, double minStep, double maxStep, double maxError, ref double error, IntPtr userData);

		/// <summary>
		/// Given initial values, xprev , initial time, t and a requested time
		/// interval, delT calculate values of x at t+delTActual (xnext).
		/// For certain concrete sub-classes delTActual != delT. This occurs
		/// when the solver supports adaptive stepsize control. If this
		/// is the case, the solver tries to change to stepsize such that
		/// the (estimated) error of the integration is less than maxError.
		/// The solver will not set the stepsize smaller than minStep or
		/// larger than maxStep.
		/// Also note that delT is an in/out argument. Adaptive solvers
		/// will modify delT to reflect the best (estimated) size for the next
		/// integration step.
		/// An estimated value for the error is returned (by reference) in error.
		/// Note that only some concrete sub-classes support this. Otherwise,
		/// the error is set to 0.
		/// This method returns an error code representing the nature of
		/// the failure:
		/// OutOfDomain = 1,
		/// NotInitialized = 2,
		/// UnexpectedValue = 3
		/// </summary>
		// Token: 0x0601DD0F RID: 122127 RVA: 0x002A1A08 File Offset: 0x0029FC08
		public virtual int ComputeNextStep(IntPtr xprev, IntPtr xnext, double t, ref double delT, ref double delTActual, double minStep, double maxStep, double maxError, ref double error, IntPtr userData)
		{
			return vtkInitialValueProblemSolver.vtkInitialValueProblemSolver_ComputeNextStep_06(base.GetCppThis(), xprev, xnext, t, ref delT, ref delTActual, minStep, maxStep, maxError, ref error, userData);
		}

		// Token: 0x0601DD10 RID: 122128
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInitialValueProblemSolver_ComputeNextStep_07(HandleRef pThis, IntPtr xprev, IntPtr dxprev, IntPtr xnext, double t, ref double delT, ref double delTActual, double minStep, double maxStep, double maxError, ref double error);

		/// <summary>
		/// Given initial values, xprev , initial time, t and a requested time
		/// interval, delT calculate values of x at t+delTActual (xnext).
		/// For certain concrete sub-classes delTActual != delT. This occurs
		/// when the solver supports adaptive stepsize control. If this
		/// is the case, the solver tries to change to stepsize such that
		/// the (estimated) error of the integration is less than maxError.
		/// The solver will not set the stepsize smaller than minStep or
		/// larger than maxStep.
		/// Also note that delT is an in/out argument. Adaptive solvers
		/// will modify delT to reflect the best (estimated) size for the next
		/// integration step.
		/// An estimated value for the error is returned (by reference) in error.
		/// Note that only some concrete sub-classes support this. Otherwise,
		/// the error is set to 0.
		/// This method returns an error code representing the nature of
		/// the failure:
		/// OutOfDomain = 1,
		/// NotInitialized = 2,
		/// UnexpectedValue = 3
		/// </summary>
		// Token: 0x0601DD11 RID: 122129 RVA: 0x002A1A38 File Offset: 0x0029FC38
		public virtual int ComputeNextStep(IntPtr xprev, IntPtr dxprev, IntPtr xnext, double t, ref double delT, ref double delTActual, double minStep, double maxStep, double maxError, ref double error)
		{
			return vtkInitialValueProblemSolver.vtkInitialValueProblemSolver_ComputeNextStep_07(base.GetCppThis(), xprev, dxprev, xnext, t, ref delT, ref delTActual, minStep, maxStep, maxError, ref error);
		}

		// Token: 0x0601DD12 RID: 122130
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInitialValueProblemSolver_ComputeNextStep_08(HandleRef pThis, IntPtr arg0, IntPtr arg1, IntPtr arg2, double arg3, ref double arg4, ref double arg5, double arg6, double arg7, double arg8, ref double arg9, IntPtr arg10);

		/// <summary>
		/// Given initial values, xprev , initial time, t and a requested time
		/// interval, delT calculate values of x at t+delTActual (xnext).
		/// For certain concrete sub-classes delTActual != delT. This occurs
		/// when the solver supports adaptive stepsize control. If this
		/// is the case, the solver tries to change to stepsize such that
		/// the (estimated) error of the integration is less than maxError.
		/// The solver will not set the stepsize smaller than minStep or
		/// larger than maxStep.
		/// Also note that delT is an in/out argument. Adaptive solvers
		/// will modify delT to reflect the best (estimated) size for the next
		/// integration step.
		/// An estimated value for the error is returned (by reference) in error.
		/// Note that only some concrete sub-classes support this. Otherwise,
		/// the error is set to 0.
		/// This method returns an error code representing the nature of
		/// the failure:
		/// OutOfDomain = 1,
		/// NotInitialized = 2,
		/// UnexpectedValue = 3
		/// </summary>
		// Token: 0x0601DD13 RID: 122131 RVA: 0x002A1A68 File Offset: 0x0029FC68
		public virtual int ComputeNextStep(IntPtr arg0, IntPtr arg1, IntPtr arg2, double arg3, ref double arg4, ref double arg5, double arg6, double arg7, double arg8, ref double arg9, IntPtr arg10)
		{
			return vtkInitialValueProblemSolver.vtkInitialValueProblemSolver_ComputeNextStep_08(base.GetCppThis(), arg0, arg1, arg2, arg3, ref arg4, ref arg5, arg6, arg7, arg8, ref arg9, arg10);
		}

		// Token: 0x0601DD14 RID: 122132
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInitialValueProblemSolver_GetFunctionSet_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set / get the dataset used for the implicit function evaluation.
		/// </summary>
		// Token: 0x0601DD15 RID: 122133 RVA: 0x002A1A9C File Offset: 0x0029FC9C
		public virtual vtkFunctionSet GetFunctionSet()
		{
			vtkFunctionSet vtkFunctionSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInitialValueProblemSolver.vtkInitialValueProblemSolver_GetFunctionSet_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFunctionSet = (vtkFunctionSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFunctionSet.Register(null);
				}
			}
			return vtkFunctionSet;
		}

		// Token: 0x0601DD16 RID: 122134
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInitialValueProblemSolver_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DD17 RID: 122135 RVA: 0x002A1B0C File Offset: 0x0029FD0C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInitialValueProblemSolver.vtkInitialValueProblemSolver_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x0601DD18 RID: 122136
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInitialValueProblemSolver_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DD19 RID: 122137 RVA: 0x002A1B2C File Offset: 0x0029FD2C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInitialValueProblemSolver.vtkInitialValueProblemSolver_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x0601DD1A RID: 122138
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInitialValueProblemSolver_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DD1B RID: 122139 RVA: 0x002A1B48 File Offset: 0x0029FD48
		public override int IsA(string type)
		{
			return vtkInitialValueProblemSolver.vtkInitialValueProblemSolver_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x0601DD1C RID: 122140
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInitialValueProblemSolver_IsAdaptive_13(HandleRef pThis);

		/// <summary>
		/// Returns 1 if the solver uses adaptive stepsize control,
		/// 0 otherwise
		/// </summary>
		// Token: 0x0601DD1D RID: 122141 RVA: 0x002A1B68 File Offset: 0x0029FD68
		public virtual int IsAdaptive()
		{
			return vtkInitialValueProblemSolver.vtkInitialValueProblemSolver_IsAdaptive_13(base.GetCppThis());
		}

		// Token: 0x0601DD1E RID: 122142
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInitialValueProblemSolver_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DD1F RID: 122143 RVA: 0x002A1B88 File Offset: 0x0029FD88
		public new static int IsTypeOf(string type)
		{
			return vtkInitialValueProblemSolver.vtkInitialValueProblemSolver_IsTypeOf_14(type);
		}

		// Token: 0x0601DD20 RID: 122144
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInitialValueProblemSolver_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DD21 RID: 122145 RVA: 0x002A1BA4 File Offset: 0x0029FDA4
		public new vtkInitialValueProblemSolver NewInstance()
		{
			vtkInitialValueProblemSolver result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInitialValueProblemSolver.vtkInitialValueProblemSolver_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInitialValueProblemSolver)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601DD22 RID: 122146
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInitialValueProblemSolver_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DD23 RID: 122147 RVA: 0x002A1C00 File Offset: 0x0029FE00
		public new static vtkInitialValueProblemSolver SafeDownCast(vtkObjectBase o)
		{
			vtkInitialValueProblemSolver vtkInitialValueProblemSolver = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInitialValueProblemSolver.vtkInitialValueProblemSolver_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInitialValueProblemSolver = (vtkInitialValueProblemSolver)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInitialValueProblemSolver.Register(null);
				}
			}
			return vtkInitialValueProblemSolver;
		}

		// Token: 0x0601DD24 RID: 122148
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInitialValueProblemSolver_SetFunctionSet_17(HandleRef pThis, HandleRef fset);

		/// <summary>
		/// Set / get the dataset used for the implicit function evaluation.
		/// </summary>
		// Token: 0x0601DD25 RID: 122149 RVA: 0x002A1C80 File Offset: 0x0029FE80
		public virtual void SetFunctionSet(vtkFunctionSet fset)
		{
			vtkInitialValueProblemSolver.vtkInitialValueProblemSolver_SetFunctionSet_17(base.GetCppThis(), (fset == null) ? default(HandleRef) : fset.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F71 RID: 8049
		public new const string MRFullTypeName = "Kitware.VTK.vtkInitialValueProblemSolver";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F72 RID: 8050
		public new static readonly string MRClassNameKey = "class vtkInitialValueProblemSolver";

		/// <summary>
		/// Returns 1 if the solver uses adaptive stepsize control,
		/// 0 otherwise
		/// </summary>
		// Token: 0x02000B1A RID: 2842
		public enum ErrorCodes
		{
			/// <summary>enum member</summary>
			// Token: 0x04001F74 RID: 8052
			NOT_INITIALIZED = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001F75 RID: 8053
			OUT_OF_DOMAIN = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001F76 RID: 8054
			UNEXPECTED_VALUE = 3
		}
	}
}
