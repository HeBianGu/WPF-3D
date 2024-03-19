using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkParametricKlein
	/// </summary>
	/// <remarks>
	///    Generates a "classical" representation of a Klein bottle.
	///
	/// vtkParametricKlein generates a "classical" representation of a Klein
	/// bottle.  A Klein bottle is a closed surface with no interior and only one
	/// surface.  It is unrealisable in 3 dimensions without intersecting
	/// surfaces.  It can be
	/// realised in 4 dimensions by considering the map \f$F:R^2 \rightarrow R^4\f$  given by:
	///
	/// - \f$f(u,v) = ((r*cos(v)+a)*cos(u),(r*cos(v)+a)*sin(u),r*sin(v)*cos(u/2),r*sin(v)*sin(u/2))\f$
	///
	/// The classical representation of the immersion in \f$R^3\f$ is returned by this function.
	///
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
	// Token: 0x02000929 RID: 2345
	public class vtkParametricKlein : vtkParametricFunction
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601847E RID: 99454 RVA: 0x0021F85B File Offset: 0x0021DA5B
		static vtkParametricKlein()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParametricKlein.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParametricKlein"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601847F RID: 99455 RVA: 0x0021F883 File Offset: 0x0021DA83
		public vtkParametricKlein(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06018480 RID: 99456
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricKlein_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct a Klein Bottle with the following parameters:
		/// MinimumU = 0, MaximumU = 2*Pi,
		/// MinimumV = -Pi, MaximumV = Pi,
		/// JoinU = 0, JoinV = 1,
		/// TwistU = 0, TwistV = 0,
		/// ClockwiseOrdering = 0,
		/// DerivativesAvailable = 1,
		/// </summary>
		// Token: 0x06018481 RID: 99457 RVA: 0x0021F894 File Offset: 0x0021DA94
		public new static vtkParametricKlein New()
		{
			vtkParametricKlein result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricKlein.vtkParametricKlein_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricKlein)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct a Klein Bottle with the following parameters:
		/// MinimumU = 0, MaximumU = 2*Pi,
		/// MinimumV = -Pi, MaximumV = Pi,
		/// JoinU = 0, JoinV = 1,
		/// TwistU = 0, TwistV = 0,
		/// ClockwiseOrdering = 0,
		/// DerivativesAvailable = 1,
		/// </summary>
		// Token: 0x06018482 RID: 99458 RVA: 0x0021F8E8 File Offset: 0x0021DAE8
		public vtkParametricKlein() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkParametricKlein.vtkParametricKlein_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06018483 RID: 99459 RVA: 0x0021F92C File Offset: 0x0021DB2C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06018484 RID: 99460
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricKlein_Evaluate_01(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		/// <summary>
		/// A Klein bottle.
		///
		/// This function performs the mapping \f$f(u,v) \rightarrow (x,y,x)\f$, returning it
		/// as Pt. It also returns the partial derivatives Du and Dv.
		/// \f$Pt = (x, y, z), Du = (dx/du, dy/du, dz/du), Dv = (dx/dv, dy/dv, dz/dv)\f$ .
		/// Then the normal is \f$N = Du X Dv\f$ .
		/// </summary>
		// Token: 0x06018485 RID: 99461 RVA: 0x0021F937 File Offset: 0x0021DB37
		public override void Evaluate(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			vtkParametricKlein.vtkParametricKlein_Evaluate_01(base.GetCppThis(), uvw, Pt, Duvw);
		}

		// Token: 0x06018486 RID: 99462
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricKlein_EvaluateScalar_02(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

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
		// Token: 0x06018487 RID: 99463 RVA: 0x0021F94C File Offset: 0x0021DB4C
		public override double EvaluateScalar(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			return vtkParametricKlein.vtkParametricKlein_EvaluateScalar_02(base.GetCppThis(), uvw, Pt, Duvw);
		}

		// Token: 0x06018488 RID: 99464
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricKlein_GetDimension_03(HandleRef pThis);

		/// <summary>
		/// Return the parametric dimension of the class.
		/// </summary>
		// Token: 0x06018489 RID: 99465 RVA: 0x0021F970 File Offset: 0x0021DB70
		public override int GetDimension()
		{
			return vtkParametricKlein.vtkParametricKlein_GetDimension_03(base.GetCppThis());
		}

		// Token: 0x0601848A RID: 99466
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParametricKlein_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601848B RID: 99467 RVA: 0x0021F990 File Offset: 0x0021DB90
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkParametricKlein.vtkParametricKlein_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601848C RID: 99468
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParametricKlein_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601848D RID: 99469 RVA: 0x0021F9B0 File Offset: 0x0021DBB0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkParametricKlein.vtkParametricKlein_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601848E RID: 99470
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricKlein_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601848F RID: 99471 RVA: 0x0021F9CC File Offset: 0x0021DBCC
		public override int IsA(string type)
		{
			return vtkParametricKlein.vtkParametricKlein_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06018490 RID: 99472
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricKlein_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018491 RID: 99473 RVA: 0x0021F9EC File Offset: 0x0021DBEC
		public new static int IsTypeOf(string type)
		{
			return vtkParametricKlein.vtkParametricKlein_IsTypeOf_07(type);
		}

		// Token: 0x06018492 RID: 99474
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricKlein_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018493 RID: 99475 RVA: 0x0021FA08 File Offset: 0x0021DC08
		public new vtkParametricKlein NewInstance()
		{
			vtkParametricKlein result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricKlein.vtkParametricKlein_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricKlein)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06018494 RID: 99476
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricKlein_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018495 RID: 99477 RVA: 0x0021FA64 File Offset: 0x0021DC64
		public new static vtkParametricKlein SafeDownCast(vtkObjectBase o)
		{
			vtkParametricKlein vtkParametricKlein = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricKlein.vtkParametricKlein_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParametricKlein = (vtkParametricKlein)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParametricKlein.Register(null);
				}
			}
			return vtkParametricKlein;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AFC RID: 6908
		public new const string MRFullTypeName = "Kitware.VTK.vtkParametricKlein";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AFD RID: 6909
		public new static readonly string MRClassNameKey = "class vtkParametricKlein";
	}
}
