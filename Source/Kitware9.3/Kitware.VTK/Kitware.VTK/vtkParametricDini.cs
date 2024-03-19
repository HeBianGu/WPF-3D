using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkParametricDini
	/// </summary>
	/// <remarks>
	///    Generate Dini's surface.
	///
	/// vtkParametricDini generates Dini's surface.
	/// Dini's surface is a surface that possesses constant negative
	/// Gaussian curvature
	///
	/// For further information about this surface, please consult
	/// https://en.wikipedia.org/wiki/Dini%27s_surface
	///
	/// @par Thanks:
	/// Andrew Maclean andrew.amaclean@gmail.com for creating and contributing the
	/// class.
	///
	/// </remarks>
	// Token: 0x02000924 RID: 2340
	public class vtkParametricDini : vtkParametricFunction
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060183EE RID: 99310 RVA: 0x0021EA93 File Offset: 0x0021CC93
		static vtkParametricDini()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParametricDini.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParametricDini"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060183EF RID: 99311 RVA: 0x0021EABB File Offset: 0x0021CCBB
		public vtkParametricDini(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060183F0 RID: 99312
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricDini_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct Dini's surface with the following parameters:
		/// MinimumU = 0, MaximumU = 4*Pi,
		/// MinimumV = 0.001, MaximumV = 2,
		/// JoinU = 0, JoinV = 0,
		/// TwistU = 0, TwistV = 0,
		/// ClockwiseOrdering = 0,
		/// DerivativesAvailable = 1
		/// A = 1, B = 0.2
		/// </summary>
		// Token: 0x060183F1 RID: 99313 RVA: 0x0021EACC File Offset: 0x0021CCCC
		public new static vtkParametricDini New()
		{
			vtkParametricDini result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricDini.vtkParametricDini_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricDini)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct Dini's surface with the following parameters:
		/// MinimumU = 0, MaximumU = 4*Pi,
		/// MinimumV = 0.001, MaximumV = 2,
		/// JoinU = 0, JoinV = 0,
		/// TwistU = 0, TwistV = 0,
		/// ClockwiseOrdering = 0,
		/// DerivativesAvailable = 1
		/// A = 1, B = 0.2
		/// </summary>
		// Token: 0x060183F2 RID: 99314 RVA: 0x0021EB20 File Offset: 0x0021CD20
		public vtkParametricDini() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkParametricDini.vtkParametricDini_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060183F3 RID: 99315 RVA: 0x0021EB64 File Offset: 0x0021CD64
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060183F4 RID: 99316
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricDini_Evaluate_01(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		/// <summary>
		/// Dini's surface.
		///
		/// This function performs the mapping \f$f(u,v) \rightarrow (x,y,x)\f$, returning it
		/// as Pt. It also returns the partial derivatives Du and Dv.
		/// \f$Pt = (x, y, z), Du = (dx/du, dy/du, dz/du), Dv = (dx/dv, dy/dv, dz/dv)\f$ .
		/// Then the normal is \f$N = Du X Dv\f$ .
		/// </summary>
		// Token: 0x060183F5 RID: 99317 RVA: 0x0021EB6F File Offset: 0x0021CD6F
		public override void Evaluate(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			vtkParametricDini.vtkParametricDini_Evaluate_01(base.GetCppThis(), uvw, Pt, Duvw);
		}

		// Token: 0x060183F6 RID: 99318
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricDini_EvaluateScalar_02(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		/// <summary>
		/// Calculate a user defined scalar using one or all of uvw, Pt, Duvw.
		///
		/// uvw are the parameters with Pt being the cartesian point,
		/// Duvw are the derivatives of this point with respect to u, v and w.
		/// Pt, Duvw are obtained from Evaluate().
		///
		/// This function is only called if the ScalarMode has the value
		/// vtkParametricFunctionSource::SCALAR_FUNCTION_DEFINED
		///
		/// If the user does not need to calculate a scalar, then the
		/// instantiated function should return zero.
		/// </summary>
		// Token: 0x060183F7 RID: 99319 RVA: 0x0021EB84 File Offset: 0x0021CD84
		public override double EvaluateScalar(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			return vtkParametricDini.vtkParametricDini_EvaluateScalar_02(base.GetCppThis(), uvw, Pt, Duvw);
		}

		// Token: 0x060183F8 RID: 99320
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricDini_GetA_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the scale factor.
		/// See the definition in Parametric surfaces referred to above.
		/// Default is 1.
		/// </summary>
		// Token: 0x060183F9 RID: 99321 RVA: 0x0021EBA8 File Offset: 0x0021CDA8
		public virtual double GetA()
		{
			return vtkParametricDini.vtkParametricDini_GetA_03(base.GetCppThis());
		}

		// Token: 0x060183FA RID: 99322
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricDini_GetB_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the scale factor.
		/// See the definition in Parametric surfaces referred to above.
		/// Default is 0.2
		/// </summary>
		// Token: 0x060183FB RID: 99323 RVA: 0x0021EBC8 File Offset: 0x0021CDC8
		public virtual double GetB()
		{
			return vtkParametricDini.vtkParametricDini_GetB_04(base.GetCppThis());
		}

		// Token: 0x060183FC RID: 99324
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricDini_GetDimension_05(HandleRef pThis);

		/// <summary>
		/// Return the parametric dimension of the class.
		/// </summary>
		// Token: 0x060183FD RID: 99325 RVA: 0x0021EBE8 File Offset: 0x0021CDE8
		public override int GetDimension()
		{
			return vtkParametricDini.vtkParametricDini_GetDimension_05(base.GetCppThis());
		}

		// Token: 0x060183FE RID: 99326
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParametricDini_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060183FF RID: 99327 RVA: 0x0021EC08 File Offset: 0x0021CE08
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkParametricDini.vtkParametricDini_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x06018400 RID: 99328
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParametricDini_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018401 RID: 99329 RVA: 0x0021EC28 File Offset: 0x0021CE28
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkParametricDini.vtkParametricDini_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x06018402 RID: 99330
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricDini_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018403 RID: 99331 RVA: 0x0021EC44 File Offset: 0x0021CE44
		public override int IsA(string type)
		{
			return vtkParametricDini.vtkParametricDini_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x06018404 RID: 99332
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricDini_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018405 RID: 99333 RVA: 0x0021EC64 File Offset: 0x0021CE64
		public new static int IsTypeOf(string type)
		{
			return vtkParametricDini.vtkParametricDini_IsTypeOf_09(type);
		}

		// Token: 0x06018406 RID: 99334
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricDini_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018407 RID: 99335 RVA: 0x0021EC80 File Offset: 0x0021CE80
		public new vtkParametricDini NewInstance()
		{
			vtkParametricDini result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricDini.vtkParametricDini_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricDini)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06018408 RID: 99336
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricDini_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018409 RID: 99337 RVA: 0x0021ECDC File Offset: 0x0021CEDC
		public new static vtkParametricDini SafeDownCast(vtkObjectBase o)
		{
			vtkParametricDini vtkParametricDini = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricDini.vtkParametricDini_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParametricDini = (vtkParametricDini)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParametricDini.Register(null);
				}
			}
			return vtkParametricDini;
		}

		// Token: 0x0601840A RID: 99338
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricDini_SetA_13(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the scale factor.
		/// See the definition in Parametric surfaces referred to above.
		/// Default is 1.
		/// </summary>
		// Token: 0x0601840B RID: 99339 RVA: 0x0021ED5B File Offset: 0x0021CF5B
		public virtual void SetA(double _arg)
		{
			vtkParametricDini.vtkParametricDini_SetA_13(base.GetCppThis(), _arg);
		}

		// Token: 0x0601840C RID: 99340
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricDini_SetB_14(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the scale factor.
		/// See the definition in Parametric surfaces referred to above.
		/// Default is 0.2
		/// </summary>
		// Token: 0x0601840D RID: 99341 RVA: 0x0021ED6B File Offset: 0x0021CF6B
		public virtual void SetB(double _arg)
		{
			vtkParametricDini.vtkParametricDini_SetB_14(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AF2 RID: 6898
		public new const string MRFullTypeName = "Kitware.VTK.vtkParametricDini";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AF3 RID: 6899
		public new static readonly string MRClassNameKey = "class vtkParametricDini";
	}
}
