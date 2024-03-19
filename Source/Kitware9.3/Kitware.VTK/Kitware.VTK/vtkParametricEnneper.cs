using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkParametricEnneper
	/// </summary>
	/// <remarks>
	///    Generate Enneper's surface.
	///
	/// vtkParametricEnneper generates Enneper's surface.
	/// Enneper's surface is a self-intersecting minimal surface
	/// possessing constant negative Gaussian curvature
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
	// Token: 0x02000926 RID: 2342
	public class vtkParametricEnneper : vtkParametricFunction
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06018432 RID: 99378 RVA: 0x0021F093 File Offset: 0x0021D293
		static vtkParametricEnneper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParametricEnneper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParametricEnneper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06018433 RID: 99379 RVA: 0x0021F0BB File Offset: 0x0021D2BB
		public vtkParametricEnneper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06018434 RID: 99380
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricEnneper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct Enneper's surface with the following parameters:
		/// MinimumU = -2, MaximumU = 2,
		/// MinimumV = -2, MaximumV = 2,
		/// JoinU = 0, JoinV = 0,
		/// TwistU = 0, TwistV = 0,
		/// ClockwiseOrdering = 0,
		/// DerivativesAvailable = 1
		/// </summary>
		// Token: 0x06018435 RID: 99381 RVA: 0x0021F0CC File Offset: 0x0021D2CC
		public new static vtkParametricEnneper New()
		{
			vtkParametricEnneper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricEnneper.vtkParametricEnneper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricEnneper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct Enneper's surface with the following parameters:
		/// MinimumU = -2, MaximumU = 2,
		/// MinimumV = -2, MaximumV = 2,
		/// JoinU = 0, JoinV = 0,
		/// TwistU = 0, TwistV = 0,
		/// ClockwiseOrdering = 0,
		/// DerivativesAvailable = 1
		/// </summary>
		// Token: 0x06018436 RID: 99382 RVA: 0x0021F120 File Offset: 0x0021D320
		public vtkParametricEnneper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkParametricEnneper.vtkParametricEnneper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06018437 RID: 99383 RVA: 0x0021F164 File Offset: 0x0021D364
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06018438 RID: 99384
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricEnneper_Evaluate_01(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		/// <summary>
		/// Enneper's surface.
		///
		/// This function performs the mapping \f$f(u,v) \rightarrow (x,y,x)\f$, returning it
		/// as Pt. It also returns the partial derivatives Du and Dv.
		/// \f$Pt = (x, y, z), Du = (dx/du, dy/du, dz/du), Dv = (dx/dv, dy/dv, dz/dv)\f$ .
		/// Then the normal is \f$N = Du X Dv\f$ .
		/// </summary>
		// Token: 0x06018439 RID: 99385 RVA: 0x0021F16F File Offset: 0x0021D36F
		public override void Evaluate(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			vtkParametricEnneper.vtkParametricEnneper_Evaluate_01(base.GetCppThis(), uvw, Pt, Duvw);
		}

		// Token: 0x0601843A RID: 99386
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricEnneper_EvaluateScalar_02(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		/// <summary>
		/// Calculate a user defined scalar using one or all of uvw, Pt, Duvw.
		///
		/// uv are the parameters with Pt being the cartesian point,
		/// Duvw are the derivatives of this point with respect to u, v and w.
		/// Pt, Duvw are obtained from Evaluate().
		///
		/// This function is only called if the ScalarMode has the value
		/// vtkParametricFunctionSource::SCALAR_FUNCTION_DEFINED
		///
		/// If the user does not need to calculate a scalar, then the
		/// instantiated function should return zero.
		/// </summary>
		// Token: 0x0601843B RID: 99387 RVA: 0x0021F184 File Offset: 0x0021D384
		public override double EvaluateScalar(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			return vtkParametricEnneper.vtkParametricEnneper_EvaluateScalar_02(base.GetCppThis(), uvw, Pt, Duvw);
		}

		// Token: 0x0601843C RID: 99388
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricEnneper_GetDimension_03(HandleRef pThis);

		/// <summary>
		/// Return the parametric dimension of the class.
		/// </summary>
		// Token: 0x0601843D RID: 99389 RVA: 0x0021F1A8 File Offset: 0x0021D3A8
		public override int GetDimension()
		{
			return vtkParametricEnneper.vtkParametricEnneper_GetDimension_03(base.GetCppThis());
		}

		// Token: 0x0601843E RID: 99390
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParametricEnneper_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601843F RID: 99391 RVA: 0x0021F1C8 File Offset: 0x0021D3C8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkParametricEnneper.vtkParametricEnneper_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06018440 RID: 99392
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParametricEnneper_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018441 RID: 99393 RVA: 0x0021F1E8 File Offset: 0x0021D3E8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkParametricEnneper.vtkParametricEnneper_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06018442 RID: 99394
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricEnneper_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018443 RID: 99395 RVA: 0x0021F204 File Offset: 0x0021D404
		public override int IsA(string type)
		{
			return vtkParametricEnneper.vtkParametricEnneper_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06018444 RID: 99396
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricEnneper_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018445 RID: 99397 RVA: 0x0021F224 File Offset: 0x0021D424
		public new static int IsTypeOf(string type)
		{
			return vtkParametricEnneper.vtkParametricEnneper_IsTypeOf_07(type);
		}

		// Token: 0x06018446 RID: 99398
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricEnneper_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018447 RID: 99399 RVA: 0x0021F240 File Offset: 0x0021D440
		public new vtkParametricEnneper NewInstance()
		{
			vtkParametricEnneper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricEnneper.vtkParametricEnneper_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricEnneper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06018448 RID: 99400
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricEnneper_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018449 RID: 99401 RVA: 0x0021F29C File Offset: 0x0021D49C
		public new static vtkParametricEnneper SafeDownCast(vtkObjectBase o)
		{
			vtkParametricEnneper vtkParametricEnneper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricEnneper.vtkParametricEnneper_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParametricEnneper = (vtkParametricEnneper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParametricEnneper.Register(null);
				}
			}
			return vtkParametricEnneper;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AF6 RID: 6902
		public new const string MRFullTypeName = "Kitware.VTK.vtkParametricEnneper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AF7 RID: 6903
		public new static readonly string MRClassNameKey = "class vtkParametricEnneper";
	}
}
