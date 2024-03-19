using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkParametricConicSpiral
	/// </summary>
	/// <remarks>
	///    Generate conic spiral surfaces that resemble sea-shells.
	///
	/// vtkParametricConicSpiral generates conic spiral surfaces. These can resemble sea shells, or
	/// may look like a torus "eating" its own tail.
	///
	/// For further information about this surface, please consult the
	/// technical description "Parametric surfaces" in http://www.vtk.org/publications
	/// in the "VTK Technical Documents" section in the VTk.org web pages.
	///
	/// @par Thanks:
	/// Andrew Maclean andrew.amaclean@gmail.com for creating and contributing the
	/// class.
	///
	/// </remarks>
	// Token: 0x02000922 RID: 2338
	public class vtkParametricConicSpiral : vtkParametricFunction
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060183AE RID: 99246 RVA: 0x0021E4C3 File Offset: 0x0021C6C3
		static vtkParametricConicSpiral()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParametricConicSpiral.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParametricConicSpiral"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060183AF RID: 99247 RVA: 0x0021E4EB File Offset: 0x0021C6EB
		public vtkParametricConicSpiral(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060183B0 RID: 99248
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricConicSpiral_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct a conic spiral surface with the following parameters:
		/// MinimumU = 0, MaximumU = 2Pi,
		/// MinimumV = 0, MaximumV = 2Pi,
		/// JoinU = 0, JoinV = 0,
		/// TwistU = 0, TwistV = 0,
		/// ClockwiseOrdering = 0,
		/// DerivativesAvailable = 1,
		/// A = 0.2, B = 1.0, C = 0.1, N = 2.
		/// </summary>
		// Token: 0x060183B1 RID: 99249 RVA: 0x0021E4FC File Offset: 0x0021C6FC
		public new static vtkParametricConicSpiral New()
		{
			vtkParametricConicSpiral result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricConicSpiral.vtkParametricConicSpiral_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricConicSpiral)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct a conic spiral surface with the following parameters:
		/// MinimumU = 0, MaximumU = 2Pi,
		/// MinimumV = 0, MaximumV = 2Pi,
		/// JoinU = 0, JoinV = 0,
		/// TwistU = 0, TwistV = 0,
		/// ClockwiseOrdering = 0,
		/// DerivativesAvailable = 1,
		/// A = 0.2, B = 1.0, C = 0.1, N = 2.
		/// </summary>
		// Token: 0x060183B2 RID: 99250 RVA: 0x0021E550 File Offset: 0x0021C750
		public vtkParametricConicSpiral() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkParametricConicSpiral.vtkParametricConicSpiral_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060183B3 RID: 99251 RVA: 0x0021E594 File Offset: 0x0021C794
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060183B4 RID: 99252
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricConicSpiral_Evaluate_01(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		/// <summary>
		/// A conic spiral surface.
		///
		/// This function performs the mapping \f$f(u,v) \rightarrow (x,y,x)\f$, returning it
		/// as Pt. It also returns the partial derivatives Du and Dv.
		/// \f$Pt = (x, y, z), Du = (dx/du, dy/du, dz/du), Dv = (dx/dv, dy/dv, dz/dv)\f$ .
		/// Then the normal is \f$N = Du X Dv\f$ .
		/// </summary>
		// Token: 0x060183B5 RID: 99253 RVA: 0x0021E59F File Offset: 0x0021C79F
		public override void Evaluate(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			vtkParametricConicSpiral.vtkParametricConicSpiral_Evaluate_01(base.GetCppThis(), uvw, Pt, Duvw);
		}

		// Token: 0x060183B6 RID: 99254
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricConicSpiral_EvaluateScalar_02(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

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
		// Token: 0x060183B7 RID: 99255 RVA: 0x0021E5B4 File Offset: 0x0021C7B4
		public override double EvaluateScalar(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			return vtkParametricConicSpiral.vtkParametricConicSpiral_EvaluateScalar_02(base.GetCppThis(), uvw, Pt, Duvw);
		}

		// Token: 0x060183B8 RID: 99256
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricConicSpiral_GetA_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the scale factor.
		/// Default = 0.2
		/// </summary>
		// Token: 0x060183B9 RID: 99257 RVA: 0x0021E5D8 File Offset: 0x0021C7D8
		public virtual double GetA()
		{
			return vtkParametricConicSpiral.vtkParametricConicSpiral_GetA_03(base.GetCppThis());
		}

		// Token: 0x060183BA RID: 99258
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricConicSpiral_GetB_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the A function coefficient.
		/// See the definition in Parametric surfaces referred to above.
		/// Default is 1.
		/// </summary>
		// Token: 0x060183BB RID: 99259 RVA: 0x0021E5F8 File Offset: 0x0021C7F8
		public virtual double GetB()
		{
			return vtkParametricConicSpiral.vtkParametricConicSpiral_GetB_04(base.GetCppThis());
		}

		// Token: 0x060183BC RID: 99260
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricConicSpiral_GetC_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the B function coefficient.
		/// See the definition in Parametric surfaces referred to above.
		/// Default is 0.1.
		/// </summary>
		// Token: 0x060183BD RID: 99261 RVA: 0x0021E618 File Offset: 0x0021C818
		public virtual double GetC()
		{
			return vtkParametricConicSpiral.vtkParametricConicSpiral_GetC_05(base.GetCppThis());
		}

		// Token: 0x060183BE RID: 99262
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricConicSpiral_GetDimension_06(HandleRef pThis);

		/// <summary>
		/// Return the parametric dimension of the class.
		/// </summary>
		// Token: 0x060183BF RID: 99263 RVA: 0x0021E638 File Offset: 0x0021C838
		public override int GetDimension()
		{
			return vtkParametricConicSpiral.vtkParametricConicSpiral_GetDimension_06(base.GetCppThis());
		}

		// Token: 0x060183C0 RID: 99264
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricConicSpiral_GetN_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the C function coefficient.
		/// See the definition in Parametric surfaces referred to above.
		/// Default is 2.
		/// </summary>
		// Token: 0x060183C1 RID: 99265 RVA: 0x0021E658 File Offset: 0x0021C858
		public virtual double GetN()
		{
			return vtkParametricConicSpiral.vtkParametricConicSpiral_GetN_07(base.GetCppThis());
		}

		// Token: 0x060183C2 RID: 99266
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParametricConicSpiral_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060183C3 RID: 99267 RVA: 0x0021E678 File Offset: 0x0021C878
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkParametricConicSpiral.vtkParametricConicSpiral_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x060183C4 RID: 99268
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParametricConicSpiral_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060183C5 RID: 99269 RVA: 0x0021E698 File Offset: 0x0021C898
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkParametricConicSpiral.vtkParametricConicSpiral_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x060183C6 RID: 99270
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricConicSpiral_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060183C7 RID: 99271 RVA: 0x0021E6B4 File Offset: 0x0021C8B4
		public override int IsA(string type)
		{
			return vtkParametricConicSpiral.vtkParametricConicSpiral_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x060183C8 RID: 99272
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricConicSpiral_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060183C9 RID: 99273 RVA: 0x0021E6D4 File Offset: 0x0021C8D4
		public new static int IsTypeOf(string type)
		{
			return vtkParametricConicSpiral.vtkParametricConicSpiral_IsTypeOf_11(type);
		}

		// Token: 0x060183CA RID: 99274
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricConicSpiral_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060183CB RID: 99275 RVA: 0x0021E6F0 File Offset: 0x0021C8F0
		public new vtkParametricConicSpiral NewInstance()
		{
			vtkParametricConicSpiral result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricConicSpiral.vtkParametricConicSpiral_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricConicSpiral)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060183CC RID: 99276
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricConicSpiral_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060183CD RID: 99277 RVA: 0x0021E74C File Offset: 0x0021C94C
		public new static vtkParametricConicSpiral SafeDownCast(vtkObjectBase o)
		{
			vtkParametricConicSpiral vtkParametricConicSpiral = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricConicSpiral.vtkParametricConicSpiral_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParametricConicSpiral = (vtkParametricConicSpiral)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParametricConicSpiral.Register(null);
				}
			}
			return vtkParametricConicSpiral;
		}

		// Token: 0x060183CE RID: 99278
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricConicSpiral_SetA_15(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the scale factor.
		/// Default = 0.2
		/// </summary>
		// Token: 0x060183CF RID: 99279 RVA: 0x0021E7CB File Offset: 0x0021C9CB
		public virtual void SetA(double _arg)
		{
			vtkParametricConicSpiral.vtkParametricConicSpiral_SetA_15(base.GetCppThis(), _arg);
		}

		// Token: 0x060183D0 RID: 99280
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricConicSpiral_SetB_16(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the A function coefficient.
		/// See the definition in Parametric surfaces referred to above.
		/// Default is 1.
		/// </summary>
		// Token: 0x060183D1 RID: 99281 RVA: 0x0021E7DB File Offset: 0x0021C9DB
		public virtual void SetB(double _arg)
		{
			vtkParametricConicSpiral.vtkParametricConicSpiral_SetB_16(base.GetCppThis(), _arg);
		}

		// Token: 0x060183D2 RID: 99282
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricConicSpiral_SetC_17(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the B function coefficient.
		/// See the definition in Parametric surfaces referred to above.
		/// Default is 0.1.
		/// </summary>
		// Token: 0x060183D3 RID: 99283 RVA: 0x0021E7EB File Offset: 0x0021C9EB
		public virtual void SetC(double _arg)
		{
			vtkParametricConicSpiral.vtkParametricConicSpiral_SetC_17(base.GetCppThis(), _arg);
		}

		// Token: 0x060183D4 RID: 99284
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricConicSpiral_SetN_18(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the C function coefficient.
		/// See the definition in Parametric surfaces referred to above.
		/// Default is 2.
		/// </summary>
		// Token: 0x060183D5 RID: 99285 RVA: 0x0021E7FB File Offset: 0x0021C9FB
		public virtual void SetN(double _arg)
		{
			vtkParametricConicSpiral.vtkParametricConicSpiral_SetN_18(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AEE RID: 6894
		public new const string MRFullTypeName = "Kitware.VTK.vtkParametricConicSpiral";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AEF RID: 6895
		public new static readonly string MRClassNameKey = "class vtkParametricConicSpiral";
	}
}
