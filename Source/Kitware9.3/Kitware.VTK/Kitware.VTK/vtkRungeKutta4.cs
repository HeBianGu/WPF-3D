using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRungeKutta4
	/// </summary>
	/// <remarks>
	///    Integrate an initial value problem using 4th
	/// order Runge-Kutta method.
	///
	///
	/// This is a concrete sub-class of vtkInitialValueProblemSolver.
	/// It uses a 4th order Runge-Kutta method to obtain the values of
	/// a set of functions at the next time step.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkInitialValueProblemSolver vtkRungeKutta45 vtkRungeKutta2 vtkFunctionSet
	/// </seealso>
	// Token: 0x02000B22 RID: 2850
	public class vtkRungeKutta4 : vtkInitialValueProblemSolver
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601DE42 RID: 122434 RVA: 0x002A3337 File Offset: 0x002A1537
		static vtkRungeKutta4()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRungeKutta4.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRungeKutta4"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601DE43 RID: 122435 RVA: 0x002A335F File Offset: 0x002A155F
		public vtkRungeKutta4(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601DE44 RID: 122436
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRungeKutta4_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct a vtkRungeKutta4 with no initial FunctionSet.
		/// </summary>
		// Token: 0x0601DE45 RID: 122437 RVA: 0x002A3370 File Offset: 0x002A1570
		public new static vtkRungeKutta4 New()
		{
			vtkRungeKutta4 result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRungeKutta4.vtkRungeKutta4_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRungeKutta4)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct a vtkRungeKutta4 with no initial FunctionSet.
		/// </summary>
		// Token: 0x0601DE46 RID: 122438 RVA: 0x002A33C4 File Offset: 0x002A15C4
		public vtkRungeKutta4() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRungeKutta4.vtkRungeKutta4_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601DE47 RID: 122439 RVA: 0x002A3408 File Offset: 0x002A1608
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601DE48 RID: 122440
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRungeKutta4_ComputeNextStep_01(HandleRef pThis, IntPtr xprev, IntPtr xnext, double t, ref double delT, double maxError, ref double error, IntPtr userData);

		/// <summary>
		/// Given initial values, xprev , initial time, t and a requested time
		/// interval, delT calculate values of x at t+delT (xnext).
		/// delTActual is always equal to delT.
		/// Since this class can not provide an estimate for the error error
		/// is set to 0.
		/// maxStep, minStep and maxError are unused.
		/// This method returns an error code representing the nature of
		/// the failure:
		/// OutOfDomain = 1,
		/// NotInitialized = 2,
		/// UnexpectedValue = 3
		/// </summary>
		// Token: 0x0601DE49 RID: 122441 RVA: 0x002A3414 File Offset: 0x002A1614
		public override int ComputeNextStep(IntPtr xprev, IntPtr xnext, double t, ref double delT, double maxError, ref double error, IntPtr userData)
		{
			return vtkRungeKutta4.vtkRungeKutta4_ComputeNextStep_01(base.GetCppThis(), xprev, xnext, t, ref delT, maxError, ref error, userData);
		}

		// Token: 0x0601DE4A RID: 122442
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRungeKutta4_ComputeNextStep_02(HandleRef pThis, IntPtr xprev, IntPtr dxprev, IntPtr xnext, double t, ref double delT, double maxError, ref double error, IntPtr userData);

		/// <summary>
		/// Given initial values, xprev , initial time, t and a requested time
		/// interval, delT calculate values of x at t+delT (xnext).
		/// delTActual is always equal to delT.
		/// Since this class can not provide an estimate for the error error
		/// is set to 0.
		/// maxStep, minStep and maxError are unused.
		/// This method returns an error code representing the nature of
		/// the failure:
		/// OutOfDomain = 1,
		/// NotInitialized = 2,
		/// UnexpectedValue = 3
		/// </summary>
		// Token: 0x0601DE4B RID: 122443 RVA: 0x002A3440 File Offset: 0x002A1640
		public override int ComputeNextStep(IntPtr xprev, IntPtr dxprev, IntPtr xnext, double t, ref double delT, double maxError, ref double error, IntPtr userData)
		{
			return vtkRungeKutta4.vtkRungeKutta4_ComputeNextStep_02(base.GetCppThis(), xprev, dxprev, xnext, t, ref delT, maxError, ref error, userData);
		}

		// Token: 0x0601DE4C RID: 122444
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRungeKutta4_ComputeNextStep_03(HandleRef pThis, IntPtr xprev, IntPtr xnext, double t, ref double delT, ref double delTActual, double minStep, double maxStep, double maxError, ref double error, IntPtr userData);

		/// <summary>
		/// Given initial values, xprev , initial time, t and a requested time
		/// interval, delT calculate values of x at t+delT (xnext).
		/// delTActual is always equal to delT.
		/// Since this class can not provide an estimate for the error error
		/// is set to 0.
		/// maxStep, minStep and maxError are unused.
		/// This method returns an error code representing the nature of
		/// the failure:
		/// OutOfDomain = 1,
		/// NotInitialized = 2,
		/// UnexpectedValue = 3
		/// </summary>
		// Token: 0x0601DE4D RID: 122445 RVA: 0x002A346C File Offset: 0x002A166C
		public override int ComputeNextStep(IntPtr xprev, IntPtr xnext, double t, ref double delT, ref double delTActual, double minStep, double maxStep, double maxError, ref double error, IntPtr userData)
		{
			return vtkRungeKutta4.vtkRungeKutta4_ComputeNextStep_03(base.GetCppThis(), xprev, xnext, t, ref delT, ref delTActual, minStep, maxStep, maxError, ref error, userData);
		}

		// Token: 0x0601DE4E RID: 122446
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRungeKutta4_ComputeNextStep_04(HandleRef pThis, IntPtr xprev, IntPtr dxprev, IntPtr xnext, double t, ref double delT, ref double delTActual, double minStep, double maxStep, double maxError, ref double error, IntPtr userData);

		/// <summary>
		/// Given initial values, xprev , initial time, t and a requested time
		/// interval, delT calculate values of x at t+delT (xnext).
		/// delTActual is always equal to delT.
		/// Since this class can not provide an estimate for the error error
		/// is set to 0.
		/// maxStep, minStep and maxError are unused.
		/// This method returns an error code representing the nature of
		/// the failure:
		/// OutOfDomain = 1,
		/// NotInitialized = 2,
		/// UnexpectedValue = 3
		/// </summary>
		// Token: 0x0601DE4F RID: 122447 RVA: 0x002A349C File Offset: 0x002A169C
		public override int ComputeNextStep(IntPtr xprev, IntPtr dxprev, IntPtr xnext, double t, ref double delT, ref double delTActual, double minStep, double maxStep, double maxError, ref double error, IntPtr userData)
		{
			return vtkRungeKutta4.vtkRungeKutta4_ComputeNextStep_04(base.GetCppThis(), xprev, dxprev, xnext, t, ref delT, ref delTActual, minStep, maxStep, maxError, ref error, userData);
		}

		// Token: 0x0601DE50 RID: 122448
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRungeKutta4_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DE51 RID: 122449 RVA: 0x002A34D0 File Offset: 0x002A16D0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRungeKutta4.vtkRungeKutta4_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0601DE52 RID: 122450
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRungeKutta4_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DE53 RID: 122451 RVA: 0x002A34F0 File Offset: 0x002A16F0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRungeKutta4.vtkRungeKutta4_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0601DE54 RID: 122452
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRungeKutta4_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DE55 RID: 122453 RVA: 0x002A350C File Offset: 0x002A170C
		public override int IsA(string type)
		{
			return vtkRungeKutta4.vtkRungeKutta4_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601DE56 RID: 122454
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRungeKutta4_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DE57 RID: 122455 RVA: 0x002A352C File Offset: 0x002A172C
		public new static int IsTypeOf(string type)
		{
			return vtkRungeKutta4.vtkRungeKutta4_IsTypeOf_08(type);
		}

		// Token: 0x0601DE58 RID: 122456
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRungeKutta4_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DE59 RID: 122457 RVA: 0x002A3548 File Offset: 0x002A1748
		public new vtkRungeKutta4 NewInstance()
		{
			vtkRungeKutta4 result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRungeKutta4.vtkRungeKutta4_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRungeKutta4)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601DE5A RID: 122458
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRungeKutta4_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DE5B RID: 122459 RVA: 0x002A35A4 File Offset: 0x002A17A4
		public new static vtkRungeKutta4 SafeDownCast(vtkObjectBase o)
		{
			vtkRungeKutta4 vtkRungeKutta = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRungeKutta4.vtkRungeKutta4_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRungeKutta = (vtkRungeKutta4)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
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
		// Token: 0x04001F88 RID: 8072
		public new const string MRFullTypeName = "Kitware.VTK.vtkRungeKutta4";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F89 RID: 8073
		public new static readonly string MRClassNameKey = "class vtkRungeKutta4";
	}
}
