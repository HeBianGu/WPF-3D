using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkParametricFigure8Klein
	/// </summary>
	/// <remarks>
	///    Generate a figure-8 Klein bottle.
	///
	/// vtkParametricFigure8Klein generates a figure-8 Klein bottle.  A Klein bottle
	/// is a closed surface with no interior and only one surface.  It is
	/// unrealisable in 3 dimensions without intersecting surfaces.  It can be
	/// realised in 4 dimensions by considering the map \f$F:R^2 \rightarrow R^4\f$  given by:
	///
	/// - \f$f(u,v) = ((r*cos(v)+a)*cos(u),(r*cos(v)+a)*sin(u),r*sin(v)*cos(u/2),r*sin(v)*sin(u/2))\f$
	///
	/// This representation of the immersion in \f$R^3\f$ is formed by taking two Mobius
	/// strips and joining them along their boundaries, this is the so called
	/// "Figure-8 Klein Bottle"
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
	// Token: 0x02000927 RID: 2343
	public class vtkParametricFigure8Klein : vtkParametricFunction
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601844A RID: 99402 RVA: 0x0021F31B File Offset: 0x0021D51B
		static vtkParametricFigure8Klein()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParametricFigure8Klein.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParametricFigure8Klein"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601844B RID: 99403 RVA: 0x0021F343 File Offset: 0x0021D543
		public vtkParametricFigure8Klein(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601844C RID: 99404
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricFigure8Klein_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct a figure-8 Klein Bottle with the following parameters:
		/// MinimumU = -Pi, MaximumU = Pi,
		/// MinimumV = -Pi, MaximumV = Pi,
		/// JoinU = 1, JoinV = 1,
		/// TwistU = 0, TwistV = 0,
		/// ClockwiseOrdering = 0,
		/// DerivativesAvailable = 1,
		/// Radius = 1
		/// </summary>
		// Token: 0x0601844D RID: 99405 RVA: 0x0021F354 File Offset: 0x0021D554
		public new static vtkParametricFigure8Klein New()
		{
			vtkParametricFigure8Klein result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricFigure8Klein.vtkParametricFigure8Klein_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricFigure8Klein)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct a figure-8 Klein Bottle with the following parameters:
		/// MinimumU = -Pi, MaximumU = Pi,
		/// MinimumV = -Pi, MaximumV = Pi,
		/// JoinU = 1, JoinV = 1,
		/// TwistU = 0, TwistV = 0,
		/// ClockwiseOrdering = 0,
		/// DerivativesAvailable = 1,
		/// Radius = 1
		/// </summary>
		// Token: 0x0601844E RID: 99406 RVA: 0x0021F3A8 File Offset: 0x0021D5A8
		public vtkParametricFigure8Klein() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkParametricFigure8Klein.vtkParametricFigure8Klein_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601844F RID: 99407 RVA: 0x0021F3EC File Offset: 0x0021D5EC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06018450 RID: 99408
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFigure8Klein_Evaluate_01(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		/// <summary>
		/// A Figure-8 Klein bottle.
		///
		/// This function performs the mapping \f$f(u,v) \rightarrow (x,y,x)\f$, returning it
		/// as Pt. It also returns the partial derivatives Du and Dv.
		/// \f$Pt = (x, y, z), Du = (dx/du, dy/du, dz/du), Dv = (dx/dv, dy/dv, dz/dv)\f$ .
		/// Then the normal is \f$N = Du X Dv\f$ .
		/// </summary>
		// Token: 0x06018451 RID: 99409 RVA: 0x0021F3F7 File Offset: 0x0021D5F7
		public override void Evaluate(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			vtkParametricFigure8Klein.vtkParametricFigure8Klein_Evaluate_01(base.GetCppThis(), uvw, Pt, Duvw);
		}

		// Token: 0x06018452 RID: 99410
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricFigure8Klein_EvaluateScalar_02(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

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
		// Token: 0x06018453 RID: 99411 RVA: 0x0021F40C File Offset: 0x0021D60C
		public override double EvaluateScalar(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			return vtkParametricFigure8Klein.vtkParametricFigure8Klein_EvaluateScalar_02(base.GetCppThis(), uvw, Pt, Duvw);
		}

		// Token: 0x06018454 RID: 99412
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricFigure8Klein_GetDimension_03(HandleRef pThis);

		/// <summary>
		/// Return the parametric dimension of the class.
		/// </summary>
		// Token: 0x06018455 RID: 99413 RVA: 0x0021F430 File Offset: 0x0021D630
		public override int GetDimension()
		{
			return vtkParametricFigure8Klein.vtkParametricFigure8Klein_GetDimension_03(base.GetCppThis());
		}

		// Token: 0x06018456 RID: 99414
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParametricFigure8Klein_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018457 RID: 99415 RVA: 0x0021F450 File Offset: 0x0021D650
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkParametricFigure8Klein.vtkParametricFigure8Klein_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06018458 RID: 99416
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParametricFigure8Klein_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018459 RID: 99417 RVA: 0x0021F470 File Offset: 0x0021D670
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkParametricFigure8Klein.vtkParametricFigure8Klein_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601845A RID: 99418
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricFigure8Klein_GetRadius_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the radius of the bottle. Default is 1.
		/// </summary>
		// Token: 0x0601845B RID: 99419 RVA: 0x0021F48C File Offset: 0x0021D68C
		public virtual double GetRadius()
		{
			return vtkParametricFigure8Klein.vtkParametricFigure8Klein_GetRadius_06(base.GetCppThis());
		}

		// Token: 0x0601845C RID: 99420
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricFigure8Klein_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601845D RID: 99421 RVA: 0x0021F4AC File Offset: 0x0021D6AC
		public override int IsA(string type)
		{
			return vtkParametricFigure8Klein.vtkParametricFigure8Klein_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601845E RID: 99422
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricFigure8Klein_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601845F RID: 99423 RVA: 0x0021F4CC File Offset: 0x0021D6CC
		public new static int IsTypeOf(string type)
		{
			return vtkParametricFigure8Klein.vtkParametricFigure8Klein_IsTypeOf_08(type);
		}

		// Token: 0x06018460 RID: 99424
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricFigure8Klein_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018461 RID: 99425 RVA: 0x0021F4E8 File Offset: 0x0021D6E8
		public new vtkParametricFigure8Klein NewInstance()
		{
			vtkParametricFigure8Klein result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricFigure8Klein.vtkParametricFigure8Klein_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricFigure8Klein)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06018462 RID: 99426
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricFigure8Klein_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018463 RID: 99427 RVA: 0x0021F544 File Offset: 0x0021D744
		public new static vtkParametricFigure8Klein SafeDownCast(vtkObjectBase o)
		{
			vtkParametricFigure8Klein vtkParametricFigure8Klein = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricFigure8Klein.vtkParametricFigure8Klein_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParametricFigure8Klein = (vtkParametricFigure8Klein)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParametricFigure8Klein.Register(null);
				}
			}
			return vtkParametricFigure8Klein;
		}

		// Token: 0x06018464 RID: 99428
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFigure8Klein_SetRadius_12(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the radius of the bottle. Default is 1.
		/// </summary>
		// Token: 0x06018465 RID: 99429 RVA: 0x0021F5C3 File Offset: 0x0021D7C3
		public virtual void SetRadius(double _arg)
		{
			vtkParametricFigure8Klein.vtkParametricFigure8Klein_SetRadius_12(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AF8 RID: 6904
		public new const string MRFullTypeName = "Kitware.VTK.vtkParametricFigure8Klein";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AF9 RID: 6905
		public new static readonly string MRClassNameKey = "class vtkParametricFigure8Klein";
	}
}
