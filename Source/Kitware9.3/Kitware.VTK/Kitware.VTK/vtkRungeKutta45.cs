using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRungeKutta45
	/// </summary>
	/// <remarks>
	///    Integrate an initial value problem using 5th
	/// order Runge-Kutta method with adaptive stepsize control.
	///
	///
	/// This is a concrete sub-class of vtkInitialValueProblemSolver.
	/// It uses a 5th order Runge-Kutta method with stepsize control to obtain
	/// the values of a set of functions at the next time step. The stepsize
	/// is adjusted by calculating an estimated error using an embedded 4th
	/// order Runge-Kutta formula:
	/// Press, W. H. et al., 1992, Numerical Recipes in Fortran, Second
	/// Edition, Cambridge University Press
	/// Cash, J.R. and Karp, A.H. 1990, ACM Transactions on Mathematical
	/// Software, vol 16, pp 201-222
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkInitialValueProblemSolver vtkRungeKutta4 vtkRungeKutta2 vtkFunctionSet
	/// </seealso>
	// Token: 0x02000B23 RID: 2851
	public class vtkRungeKutta45 : vtkInitialValueProblemSolver
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601DE5C RID: 122460 RVA: 0x002A3623 File Offset: 0x002A1823
		static vtkRungeKutta45()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRungeKutta45.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRungeKutta45"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601DE5D RID: 122461 RVA: 0x002A364B File Offset: 0x002A184B
		public vtkRungeKutta45(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601DE5E RID: 122462
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRungeKutta45_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct a vtkRungeKutta45 with no initial FunctionSet.
		/// </summary>
		// Token: 0x0601DE5F RID: 122463 RVA: 0x002A365C File Offset: 0x002A185C
		public new static vtkRungeKutta45 New()
		{
			vtkRungeKutta45 result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRungeKutta45.vtkRungeKutta45_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRungeKutta45)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct a vtkRungeKutta45 with no initial FunctionSet.
		/// </summary>
		// Token: 0x0601DE60 RID: 122464 RVA: 0x002A36B0 File Offset: 0x002A18B0
		public vtkRungeKutta45() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRungeKutta45.vtkRungeKutta45_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601DE61 RID: 122465 RVA: 0x002A36F4 File Offset: 0x002A18F4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601DE62 RID: 122466
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRungeKutta45_ComputeNextStep_01(HandleRef pThis, IntPtr xprev, IntPtr xnext, double t, ref double delT, double maxError, ref double error, IntPtr userData);

		/// <summary>
		/// Given initial values, xprev , initial time, t and a requested time
		/// interval, delT calculate values of x at t+delTActual (xnext).
		/// Possibly delTActual != delT. This may occur
		/// because this solver supports adaptive stepsize control. It tries
		/// to change to stepsize such that
		/// the (estimated) error of the integration is less than maxError.
		/// The solver will not set the stepsize smaller than minStep or
		/// larger than maxStep (note that maxStep and minStep should both
		/// be positive, whereas delT can be negative).
		/// Also note that delT is an in/out argument. vtkRungeKutta45
		/// will modify delT to reflect the best (estimated) size for the next
		/// integration step.
		/// An estimated value for the error is returned (by reference) in error.
		/// This is the norm of the error vector if there are more than
		/// one function to be integrated.
		/// This method returns an error code representing the nature of
		/// the failure:
		/// OutOfDomain = 1,
		/// NotInitialized = 2,
		/// UnexpectedValue = 3
		/// </summary>
		// Token: 0x0601DE63 RID: 122467 RVA: 0x002A3700 File Offset: 0x002A1900
		public override int ComputeNextStep(IntPtr xprev, IntPtr xnext, double t, ref double delT, double maxError, ref double error, IntPtr userData)
		{
			return vtkRungeKutta45.vtkRungeKutta45_ComputeNextStep_01(base.GetCppThis(), xprev, xnext, t, ref delT, maxError, ref error, userData);
		}

		// Token: 0x0601DE64 RID: 122468
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRungeKutta45_ComputeNextStep_02(HandleRef pThis, IntPtr xprev, IntPtr dxprev, IntPtr xnext, double t, ref double delT, double maxError, ref double error, IntPtr userData);

		/// <summary>
		/// Given initial values, xprev , initial time, t and a requested time
		/// interval, delT calculate values of x at t+delTActual (xnext).
		/// Possibly delTActual != delT. This may occur
		/// because this solver supports adaptive stepsize control. It tries
		/// to change to stepsize such that
		/// the (estimated) error of the integration is less than maxError.
		/// The solver will not set the stepsize smaller than minStep or
		/// larger than maxStep (note that maxStep and minStep should both
		/// be positive, whereas delT can be negative).
		/// Also note that delT is an in/out argument. vtkRungeKutta45
		/// will modify delT to reflect the best (estimated) size for the next
		/// integration step.
		/// An estimated value for the error is returned (by reference) in error.
		/// This is the norm of the error vector if there are more than
		/// one function to be integrated.
		/// This method returns an error code representing the nature of
		/// the failure:
		/// OutOfDomain = 1,
		/// NotInitialized = 2,
		/// UnexpectedValue = 3
		/// </summary>
		// Token: 0x0601DE65 RID: 122469 RVA: 0x002A372C File Offset: 0x002A192C
		public override int ComputeNextStep(IntPtr xprev, IntPtr dxprev, IntPtr xnext, double t, ref double delT, double maxError, ref double error, IntPtr userData)
		{
			return vtkRungeKutta45.vtkRungeKutta45_ComputeNextStep_02(base.GetCppThis(), xprev, dxprev, xnext, t, ref delT, maxError, ref error, userData);
		}

		// Token: 0x0601DE66 RID: 122470
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRungeKutta45_ComputeNextStep_03(HandleRef pThis, IntPtr xprev, IntPtr xnext, double t, ref double delT, ref double delTActual, double minStep, double maxStep, double maxError, ref double error, IntPtr userData);

		/// <summary>
		/// Given initial values, xprev , initial time, t and a requested time
		/// interval, delT calculate values of x at t+delTActual (xnext).
		/// Possibly delTActual != delT. This may occur
		/// because this solver supports adaptive stepsize control. It tries
		/// to change to stepsize such that
		/// the (estimated) error of the integration is less than maxError.
		/// The solver will not set the stepsize smaller than minStep or
		/// larger than maxStep (note that maxStep and minStep should both
		/// be positive, whereas delT can be negative).
		/// Also note that delT is an in/out argument. vtkRungeKutta45
		/// will modify delT to reflect the best (estimated) size for the next
		/// integration step.
		/// An estimated value for the error is returned (by reference) in error.
		/// This is the norm of the error vector if there are more than
		/// one function to be integrated.
		/// This method returns an error code representing the nature of
		/// the failure:
		/// OutOfDomain = 1,
		/// NotInitialized = 2,
		/// UnexpectedValue = 3
		/// </summary>
		// Token: 0x0601DE67 RID: 122471 RVA: 0x002A3758 File Offset: 0x002A1958
		public override int ComputeNextStep(IntPtr xprev, IntPtr xnext, double t, ref double delT, ref double delTActual, double minStep, double maxStep, double maxError, ref double error, IntPtr userData)
		{
			return vtkRungeKutta45.vtkRungeKutta45_ComputeNextStep_03(base.GetCppThis(), xprev, xnext, t, ref delT, ref delTActual, minStep, maxStep, maxError, ref error, userData);
		}

		// Token: 0x0601DE68 RID: 122472
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRungeKutta45_ComputeNextStep_04(HandleRef pThis, IntPtr xprev, IntPtr dxprev, IntPtr xnext, double t, ref double delT, ref double delTActual, double minStep, double maxStep, double maxError, ref double estErr, IntPtr userData);

		/// <summary>
		/// Given initial values, xprev , initial time, t and a requested time
		/// interval, delT calculate values of x at t+delTActual (xnext).
		/// Possibly delTActual != delT. This may occur
		/// because this solver supports adaptive stepsize control. It tries
		/// to change to stepsize such that
		/// the (estimated) error of the integration is less than maxError.
		/// The solver will not set the stepsize smaller than minStep or
		/// larger than maxStep (note that maxStep and minStep should both
		/// be positive, whereas delT can be negative).
		/// Also note that delT is an in/out argument. vtkRungeKutta45
		/// will modify delT to reflect the best (estimated) size for the next
		/// integration step.
		/// An estimated value for the error is returned (by reference) in error.
		/// This is the norm of the error vector if there are more than
		/// one function to be integrated.
		/// This method returns an error code representing the nature of
		/// the failure:
		/// OutOfDomain = 1,
		/// NotInitialized = 2,
		/// UnexpectedValue = 3
		/// </summary>
		// Token: 0x0601DE69 RID: 122473 RVA: 0x002A3788 File Offset: 0x002A1988
		public override int ComputeNextStep(IntPtr xprev, IntPtr dxprev, IntPtr xnext, double t, ref double delT, ref double delTActual, double minStep, double maxStep, double maxError, ref double estErr, IntPtr userData)
		{
			return vtkRungeKutta45.vtkRungeKutta45_ComputeNextStep_04(base.GetCppThis(), xprev, dxprev, xnext, t, ref delT, ref delTActual, minStep, maxStep, maxError, ref estErr, userData);
		}

		// Token: 0x0601DE6A RID: 122474
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRungeKutta45_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DE6B RID: 122475 RVA: 0x002A37BC File Offset: 0x002A19BC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRungeKutta45.vtkRungeKutta45_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0601DE6C RID: 122476
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRungeKutta45_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DE6D RID: 122477 RVA: 0x002A37DC File Offset: 0x002A19DC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRungeKutta45.vtkRungeKutta45_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0601DE6E RID: 122478
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRungeKutta45_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DE6F RID: 122479 RVA: 0x002A37F8 File Offset: 0x002A19F8
		public override int IsA(string type)
		{
			return vtkRungeKutta45.vtkRungeKutta45_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601DE70 RID: 122480
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRungeKutta45_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DE71 RID: 122481 RVA: 0x002A3818 File Offset: 0x002A1A18
		public new static int IsTypeOf(string type)
		{
			return vtkRungeKutta45.vtkRungeKutta45_IsTypeOf_08(type);
		}

		// Token: 0x0601DE72 RID: 122482
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRungeKutta45_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DE73 RID: 122483 RVA: 0x002A3834 File Offset: 0x002A1A34
		public new vtkRungeKutta45 NewInstance()
		{
			vtkRungeKutta45 result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRungeKutta45.vtkRungeKutta45_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRungeKutta45)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601DE74 RID: 122484
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRungeKutta45_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DE75 RID: 122485 RVA: 0x002A3890 File Offset: 0x002A1A90
		public new static vtkRungeKutta45 SafeDownCast(vtkObjectBase o)
		{
			vtkRungeKutta45 vtkRungeKutta = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRungeKutta45.vtkRungeKutta45_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRungeKutta = (vtkRungeKutta45)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRungeKutta.Register(null);
				}
			}
			return vtkRungeKutta;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F8A RID: 8074
		public new const string MRFullTypeName = "Kitware.VTK.vtkRungeKutta45";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F8B RID: 8075
		public new static readonly string MRClassNameKey = "class vtkRungeKutta45";
	}
}
