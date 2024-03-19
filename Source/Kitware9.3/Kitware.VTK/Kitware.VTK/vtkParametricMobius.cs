using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkParametricMobius
	/// </summary>
	/// <remarks>
	///    Generate a Mobius strip.
	///
	/// vtkParametricMobius generates a Mobius strip.
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
	// Token: 0x0200092B RID: 2347
	public class vtkParametricMobius : vtkParametricFunction
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060184B2 RID: 99506 RVA: 0x0021FD9B File Offset: 0x0021DF9B
		static vtkParametricMobius()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParametricMobius.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParametricMobius"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060184B3 RID: 99507 RVA: 0x0021FDC3 File Offset: 0x0021DFC3
		public vtkParametricMobius(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060184B4 RID: 99508
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricMobius_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct a Mobius strip with the following parameters:
		/// MinimumU = 0, MaximumU = 2*Pi,
		/// MinimumV = -1, MaximumV = 1,
		/// JoinU = 1, JoinV = 0,
		/// TwistU = 0, TwistV = 0,
		/// ClockwiseOrdering = 0,
		/// DerivativesAvailable = 1,
		/// Radius = 1.
		/// </summary>
		// Token: 0x060184B5 RID: 99509 RVA: 0x0021FDD4 File Offset: 0x0021DFD4
		public new static vtkParametricMobius New()
		{
			vtkParametricMobius result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricMobius.vtkParametricMobius_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricMobius)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct a Mobius strip with the following parameters:
		/// MinimumU = 0, MaximumU = 2*Pi,
		/// MinimumV = -1, MaximumV = 1,
		/// JoinU = 1, JoinV = 0,
		/// TwistU = 0, TwistV = 0,
		/// ClockwiseOrdering = 0,
		/// DerivativesAvailable = 1,
		/// Radius = 1.
		/// </summary>
		// Token: 0x060184B6 RID: 99510 RVA: 0x0021FE28 File Offset: 0x0021E028
		public vtkParametricMobius() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkParametricMobius.vtkParametricMobius_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060184B7 RID: 99511 RVA: 0x0021FE6C File Offset: 0x0021E06C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060184B8 RID: 99512
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricMobius_Evaluate_01(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		/// <summary>
		/// The Mobius strip.
		///
		/// This function performs the mapping \f$f(u,v) \rightarrow (x,y,x)\f$, returning it
		/// as Pt. It also returns the partial derivatives Du and Dv.
		/// \f$Pt = (x, y, z), Du = (dx/du, dy/du, dz/du), Dv = (dx/dv, dy/dv, dz/dv)\f$ .
		/// Then the normal is \f$N = Du X Dv\f$ .
		/// </summary>
		// Token: 0x060184B9 RID: 99513 RVA: 0x0021FE77 File Offset: 0x0021E077
		public override void Evaluate(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			vtkParametricMobius.vtkParametricMobius_Evaluate_01(base.GetCppThis(), uvw, Pt, Duvw);
		}

		// Token: 0x060184BA RID: 99514
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricMobius_EvaluateScalar_02(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		/// <summary>
		/// Calculate a user defined scalar using one or all of uvw, Pt, Duvw.
		///
		/// uvw are the parameters with Pt being the cartesian point,
		/// Duvw are the derivatives of this point with respect to u, v and w.
		/// Pt, Du, Dv are obtained from Evaluate().
		///
		/// This function is only called if the ScalarMode has the value
		/// vtkParametricFunctionSource::SCALAR_FUNCTION_DEFINED
		///
		/// If the user does not need to calculate a scalar, then the
		/// instantiated function should return zero.
		/// </summary>
		// Token: 0x060184BB RID: 99515 RVA: 0x0021FE8C File Offset: 0x0021E08C
		public override double EvaluateScalar(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			return vtkParametricMobius.vtkParametricMobius_EvaluateScalar_02(base.GetCppThis(), uvw, Pt, Duvw);
		}

		// Token: 0x060184BC RID: 99516
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricMobius_GetDimension_03(HandleRef pThis);

		/// <summary>
		/// Return the parametric dimension of the class.
		/// </summary>
		// Token: 0x060184BD RID: 99517 RVA: 0x0021FEB0 File Offset: 0x0021E0B0
		public override int GetDimension()
		{
			return vtkParametricMobius.vtkParametricMobius_GetDimension_03(base.GetCppThis());
		}

		// Token: 0x060184BE RID: 99518
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParametricMobius_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060184BF RID: 99519 RVA: 0x0021FED0 File Offset: 0x0021E0D0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkParametricMobius.vtkParametricMobius_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x060184C0 RID: 99520
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParametricMobius_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060184C1 RID: 99521 RVA: 0x0021FEF0 File Offset: 0x0021E0F0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkParametricMobius.vtkParametricMobius_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x060184C2 RID: 99522
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricMobius_GetRadius_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the radius of the Mobius strip. Default is 1.
		/// </summary>
		// Token: 0x060184C3 RID: 99523 RVA: 0x0021FF0C File Offset: 0x0021E10C
		public virtual double GetRadius()
		{
			return vtkParametricMobius.vtkParametricMobius_GetRadius_06(base.GetCppThis());
		}

		// Token: 0x060184C4 RID: 99524
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricMobius_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060184C5 RID: 99525 RVA: 0x0021FF2C File Offset: 0x0021E12C
		public override int IsA(string type)
		{
			return vtkParametricMobius.vtkParametricMobius_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x060184C6 RID: 99526
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricMobius_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060184C7 RID: 99527 RVA: 0x0021FF4C File Offset: 0x0021E14C
		public new static int IsTypeOf(string type)
		{
			return vtkParametricMobius.vtkParametricMobius_IsTypeOf_08(type);
		}

		// Token: 0x060184C8 RID: 99528
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricMobius_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060184C9 RID: 99529 RVA: 0x0021FF68 File Offset: 0x0021E168
		public new vtkParametricMobius NewInstance()
		{
			vtkParametricMobius result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricMobius.vtkParametricMobius_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricMobius)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060184CA RID: 99530
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricMobius_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060184CB RID: 99531 RVA: 0x0021FFC4 File Offset: 0x0021E1C4
		public new static vtkParametricMobius SafeDownCast(vtkObjectBase o)
		{
			vtkParametricMobius vtkParametricMobius = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricMobius.vtkParametricMobius_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParametricMobius = (vtkParametricMobius)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParametricMobius.Register(null);
				}
			}
			return vtkParametricMobius;
		}

		// Token: 0x060184CC RID: 99532
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricMobius_SetRadius_12(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the radius of the Mobius strip. Default is 1.
		/// </summary>
		// Token: 0x060184CD RID: 99533 RVA: 0x00220043 File Offset: 0x0021E243
		public virtual void SetRadius(double _arg)
		{
			vtkParametricMobius.vtkParametricMobius_SetRadius_12(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B00 RID: 6912
		public new const string MRFullTypeName = "Kitware.VTK.vtkParametricMobius";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B01 RID: 6913
		public new static readonly string MRClassNameKey = "class vtkParametricMobius";
	}
}
