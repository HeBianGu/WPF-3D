using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkParametricKuen
	/// </summary>
	/// <remarks>
	///    Generate Kuens' surface.
	///
	/// vtkParametricKuen generates Kuens' surface. This surface has a constant
	/// negative gaussian curvature. For more information about this surface, see
	/// Dr. O'Niell's page at the
	/// &lt;a href="http://www.math.ucla.edu/~bon/kuen.html"&gt;UCLA Mathematics Department&lt;/a&gt;.
	/// @par Thanks:
	/// Tim Meehan
	/// </remarks>
	// Token: 0x0200092A RID: 2346
	public class vtkParametricKuen : vtkParametricFunction
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06018496 RID: 99478 RVA: 0x0021FAE3 File Offset: 0x0021DCE3
		static vtkParametricKuen()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParametricKuen.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParametricKuen"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06018497 RID: 99479 RVA: 0x0021FB0B File Offset: 0x0021DD0B
		public vtkParametricKuen(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06018498 RID: 99480
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricKuen_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct Kuen's surface with the following parameters:
		/// (MinimumU, MaximumU) = (-4.5, 4.5),
		/// (MinimumV, MaximumV) = (DeltaV0, pi),
		/// JoinU = 0, JoinV = 0,
		/// TwistU = 0, TwistV = 0;
		/// ClockwiseOrdering = 0,
		/// DerivativesAvailable = 1,
		/// </summary>
		// Token: 0x06018499 RID: 99481 RVA: 0x0021FB1C File Offset: 0x0021DD1C
		public new static vtkParametricKuen New()
		{
			vtkParametricKuen result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricKuen.vtkParametricKuen_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricKuen)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct Kuen's surface with the following parameters:
		/// (MinimumU, MaximumU) = (-4.5, 4.5),
		/// (MinimumV, MaximumV) = (DeltaV0, pi),
		/// JoinU = 0, JoinV = 0,
		/// TwistU = 0, TwistV = 0;
		/// ClockwiseOrdering = 0,
		/// DerivativesAvailable = 1,
		/// </summary>
		// Token: 0x0601849A RID: 99482 RVA: 0x0021FB70 File Offset: 0x0021DD70
		public vtkParametricKuen() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkParametricKuen.vtkParametricKuen_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601849B RID: 99483 RVA: 0x0021FBB4 File Offset: 0x0021DDB4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601849C RID: 99484
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricKuen_Evaluate_01(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		/// <summary>
		/// Kuen's surface.
		///
		/// This function performs the mapping \f$f(u,v) \rightarrow (x,y,x)\f$, returning it
		/// as Pt. It also returns the partial derivatives Du and Dv.
		/// \f$Pt = (x, y, z), D_u\vec{f} = (dx/du, dy/du, dz/du), D_v\vec{f} = (dx/dv, dy/dv, dz/dv)\f$ .
		/// Then the normal is \f$N = D_u\vec{f} \times D_v\vec{f}\f$ .
		/// </summary>
		// Token: 0x0601849D RID: 99485 RVA: 0x0021FBBF File Offset: 0x0021DDBF
		public override void Evaluate(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			vtkParametricKuen.vtkParametricKuen_Evaluate_01(base.GetCppThis(), uvw, Pt, Duvw);
		}

		// Token: 0x0601849E RID: 99486
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricKuen_EvaluateScalar_02(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		/// <summary>
		/// Calculate a user defined scalar using one or all of uvw, Pt, Duvw.
		/// This method simply returns 0.
		/// </summary>
		// Token: 0x0601849F RID: 99487 RVA: 0x0021FBD4 File Offset: 0x0021DDD4
		public override double EvaluateScalar(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			return vtkParametricKuen.vtkParametricKuen_EvaluateScalar_02(base.GetCppThis(), uvw, Pt, Duvw);
		}

		// Token: 0x060184A0 RID: 99488
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricKuen_GetDeltaV0_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the value to use when V == 0.
		/// Default is 0.05, giving the best appearance with the default settings.
		/// Setting it to a value less than 0.05 extrapolates the surface
		/// towards a pole in the -z direction.
		/// Setting it to 0 retains the pole whose z-value is -inf.
		/// </summary>
		// Token: 0x060184A1 RID: 99489 RVA: 0x0021FBF8 File Offset: 0x0021DDF8
		public virtual double GetDeltaV0()
		{
			return vtkParametricKuen.vtkParametricKuen_GetDeltaV0_03(base.GetCppThis());
		}

		// Token: 0x060184A2 RID: 99490
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricKuen_GetDimension_04(HandleRef pThis);

		/// <summary>
		/// Return the parametric dimension of the class.
		/// </summary>
		// Token: 0x060184A3 RID: 99491 RVA: 0x0021FC18 File Offset: 0x0021DE18
		public override int GetDimension()
		{
			return vtkParametricKuen.vtkParametricKuen_GetDimension_04(base.GetCppThis());
		}

		// Token: 0x060184A4 RID: 99492
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParametricKuen_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060184A5 RID: 99493 RVA: 0x0021FC38 File Offset: 0x0021DE38
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkParametricKuen.vtkParametricKuen_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x060184A6 RID: 99494
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParametricKuen_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060184A7 RID: 99495 RVA: 0x0021FC58 File Offset: 0x0021DE58
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkParametricKuen.vtkParametricKuen_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x060184A8 RID: 99496
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricKuen_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060184A9 RID: 99497 RVA: 0x0021FC74 File Offset: 0x0021DE74
		public override int IsA(string type)
		{
			return vtkParametricKuen.vtkParametricKuen_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x060184AA RID: 99498
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricKuen_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060184AB RID: 99499 RVA: 0x0021FC94 File Offset: 0x0021DE94
		public new static int IsTypeOf(string type)
		{
			return vtkParametricKuen.vtkParametricKuen_IsTypeOf_08(type);
		}

		// Token: 0x060184AC RID: 99500
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricKuen_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060184AD RID: 99501 RVA: 0x0021FCB0 File Offset: 0x0021DEB0
		public new vtkParametricKuen NewInstance()
		{
			vtkParametricKuen result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricKuen.vtkParametricKuen_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricKuen)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060184AE RID: 99502
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricKuen_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060184AF RID: 99503 RVA: 0x0021FD0C File Offset: 0x0021DF0C
		public new static vtkParametricKuen SafeDownCast(vtkObjectBase o)
		{
			vtkParametricKuen vtkParametricKuen = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricKuen.vtkParametricKuen_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParametricKuen = (vtkParametricKuen)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParametricKuen.Register(null);
				}
			}
			return vtkParametricKuen;
		}

		// Token: 0x060184B0 RID: 99504
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricKuen_SetDeltaV0_12(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the value to use when V == 0.
		/// Default is 0.05, giving the best appearance with the default settings.
		/// Setting it to a value less than 0.05 extrapolates the surface
		/// towards a pole in the -z direction.
		/// Setting it to 0 retains the pole whose z-value is -inf.
		/// </summary>
		// Token: 0x060184B1 RID: 99505 RVA: 0x0021FD8B File Offset: 0x0021DF8B
		public virtual void SetDeltaV0(double _arg)
		{
			vtkParametricKuen.vtkParametricKuen_SetDeltaV0_12(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AFE RID: 6910
		public new const string MRFullTypeName = "Kitware.VTK.vtkParametricKuen";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AFF RID: 6911
		public new static readonly string MRClassNameKey = "class vtkParametricKuen";
	}
}
