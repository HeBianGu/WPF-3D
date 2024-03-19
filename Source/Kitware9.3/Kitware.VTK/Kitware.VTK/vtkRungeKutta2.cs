using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRungeKutta2
	/// </summary>
	/// <remarks>
	///    Integrate an initial value problem using 2nd
	/// order Runge-Kutta method.
	///
	///
	/// This is a concrete sub-class of vtkInitialValueProblemSolver.
	/// It uses a 2nd order Runge-Kutta method to obtain the values of
	/// a set of functions at the next time step.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkInitialValueProblemSolver vtkRungeKutta4 vtkRungeKutta45 vtkFunctionSet
	/// </seealso>
	// Token: 0x02000B21 RID: 2849
	public class vtkRungeKutta2 : vtkInitialValueProblemSolver
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601DE28 RID: 122408 RVA: 0x002A304D File Offset: 0x002A124D
		static vtkRungeKutta2()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRungeKutta2.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRungeKutta2"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601DE29 RID: 122409 RVA: 0x002A3075 File Offset: 0x002A1275
		public vtkRungeKutta2(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601DE2A RID: 122410
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRungeKutta2_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct a vtkRungeKutta2 with no initial FunctionSet.
		/// </summary>
		// Token: 0x0601DE2B RID: 122411 RVA: 0x002A3084 File Offset: 0x002A1284
		public new static vtkRungeKutta2 New()
		{
			vtkRungeKutta2 result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRungeKutta2.vtkRungeKutta2_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRungeKutta2)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct a vtkRungeKutta2 with no initial FunctionSet.
		/// </summary>
		// Token: 0x0601DE2C RID: 122412 RVA: 0x002A30D8 File Offset: 0x002A12D8
		public vtkRungeKutta2() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRungeKutta2.vtkRungeKutta2_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601DE2D RID: 122413 RVA: 0x002A311C File Offset: 0x002A131C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601DE2E RID: 122414
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRungeKutta2_ComputeNextStep_01(HandleRef pThis, IntPtr xprev, IntPtr xnext, double t, ref double delT, double maxError, ref double error, IntPtr userData);

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
		// Token: 0x0601DE2F RID: 122415 RVA: 0x002A3128 File Offset: 0x002A1328
		public override int ComputeNextStep(IntPtr xprev, IntPtr xnext, double t, ref double delT, double maxError, ref double error, IntPtr userData)
		{
			return vtkRungeKutta2.vtkRungeKutta2_ComputeNextStep_01(base.GetCppThis(), xprev, xnext, t, ref delT, maxError, ref error, userData);
		}

		// Token: 0x0601DE30 RID: 122416
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRungeKutta2_ComputeNextStep_02(HandleRef pThis, IntPtr xprev, IntPtr dxprev, IntPtr xnext, double t, ref double delT, double maxError, ref double error, IntPtr userData);

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
		// Token: 0x0601DE31 RID: 122417 RVA: 0x002A3154 File Offset: 0x002A1354
		public override int ComputeNextStep(IntPtr xprev, IntPtr dxprev, IntPtr xnext, double t, ref double delT, double maxError, ref double error, IntPtr userData)
		{
			return vtkRungeKutta2.vtkRungeKutta2_ComputeNextStep_02(base.GetCppThis(), xprev, dxprev, xnext, t, ref delT, maxError, ref error, userData);
		}

		// Token: 0x0601DE32 RID: 122418
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRungeKutta2_ComputeNextStep_03(HandleRef pThis, IntPtr xprev, IntPtr xnext, double t, ref double delT, ref double delTActual, double minStep, double maxStep, double maxError, ref double error, IntPtr userData);

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
		// Token: 0x0601DE33 RID: 122419 RVA: 0x002A3180 File Offset: 0x002A1380
		public override int ComputeNextStep(IntPtr xprev, IntPtr xnext, double t, ref double delT, ref double delTActual, double minStep, double maxStep, double maxError, ref double error, IntPtr userData)
		{
			return vtkRungeKutta2.vtkRungeKutta2_ComputeNextStep_03(base.GetCppThis(), xprev, xnext, t, ref delT, ref delTActual, minStep, maxStep, maxError, ref error, userData);
		}

		// Token: 0x0601DE34 RID: 122420
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRungeKutta2_ComputeNextStep_04(HandleRef pThis, IntPtr xprev, IntPtr dxprev, IntPtr xnext, double t, ref double delT, ref double delTActual, double minStep, double maxStep, double maxError, ref double error, IntPtr userData);

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
		// Token: 0x0601DE35 RID: 122421 RVA: 0x002A31B0 File Offset: 0x002A13B0
		public override int ComputeNextStep(IntPtr xprev, IntPtr dxprev, IntPtr xnext, double t, ref double delT, ref double delTActual, double minStep, double maxStep, double maxError, ref double error, IntPtr userData)
		{
			return vtkRungeKutta2.vtkRungeKutta2_ComputeNextStep_04(base.GetCppThis(), xprev, dxprev, xnext, t, ref delT, ref delTActual, minStep, maxStep, maxError, ref error, userData);
		}

		// Token: 0x0601DE36 RID: 122422
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRungeKutta2_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DE37 RID: 122423 RVA: 0x002A31E4 File Offset: 0x002A13E4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRungeKutta2.vtkRungeKutta2_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0601DE38 RID: 122424
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRungeKutta2_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DE39 RID: 122425 RVA: 0x002A3204 File Offset: 0x002A1404
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRungeKutta2.vtkRungeKutta2_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0601DE3A RID: 122426
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRungeKutta2_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DE3B RID: 122427 RVA: 0x002A3220 File Offset: 0x002A1420
		public override int IsA(string type)
		{
			return vtkRungeKutta2.vtkRungeKutta2_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601DE3C RID: 122428
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRungeKutta2_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DE3D RID: 122429 RVA: 0x002A3240 File Offset: 0x002A1440
		public new static int IsTypeOf(string type)
		{
			return vtkRungeKutta2.vtkRungeKutta2_IsTypeOf_08(type);
		}

		// Token: 0x0601DE3E RID: 122430
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRungeKutta2_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DE3F RID: 122431 RVA: 0x002A325C File Offset: 0x002A145C
		public new vtkRungeKutta2 NewInstance()
		{
			vtkRungeKutta2 result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRungeKutta2.vtkRungeKutta2_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRungeKutta2)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601DE40 RID: 122432
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRungeKutta2_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DE41 RID: 122433 RVA: 0x002A32B8 File Offset: 0x002A14B8
		public new static vtkRungeKutta2 SafeDownCast(vtkObjectBase o)
		{
			vtkRungeKutta2 vtkRungeKutta = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRungeKutta2.vtkRungeKutta2_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRungeKutta = (vtkRungeKutta2)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
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
		// Token: 0x04001F86 RID: 8070
		public new const string MRFullTypeName = "Kitware.VTK.vtkRungeKutta2";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F87 RID: 8071
		public new static readonly string MRClassNameKey = "class vtkRungeKutta2";
	}
}
