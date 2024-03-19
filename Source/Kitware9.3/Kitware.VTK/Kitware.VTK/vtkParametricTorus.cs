using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkParametricTorus
	/// </summary>
	/// <remarks>
	///    Generate a torus.
	///
	/// vtkParametricTorus generates a torus.
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
	// Token: 0x02000933 RID: 2355
	public class vtkParametricTorus : vtkParametricFunction
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06018616 RID: 99862 RVA: 0x00221B33 File Offset: 0x0021FD33
		static vtkParametricTorus()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParametricTorus.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParametricTorus"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06018617 RID: 99863 RVA: 0x00221B5B File Offset: 0x0021FD5B
		public vtkParametricTorus(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06018618 RID: 99864
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricTorus_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct a torus with the following parameters:
		/// MinimumU = 0, MaximumU = 2*Pi,
		/// MinimumV = 0, MaximumV = 2*Pi,
		/// JoinU = 1, JoinV = 1,
		/// TwistU = 0, TwistV = 0,
		/// ClockwiseOrdering = 1,
		/// DerivativesAvailable = 0,
		/// RingRadius = 1, CrossSectionRadius = 0.5.
		/// </summary>
		// Token: 0x06018619 RID: 99865 RVA: 0x00221B6C File Offset: 0x0021FD6C
		public new static vtkParametricTorus New()
		{
			vtkParametricTorus result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricTorus.vtkParametricTorus_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricTorus)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct a torus with the following parameters:
		/// MinimumU = 0, MaximumU = 2*Pi,
		/// MinimumV = 0, MaximumV = 2*Pi,
		/// JoinU = 1, JoinV = 1,
		/// TwistU = 0, TwistV = 0,
		/// ClockwiseOrdering = 1,
		/// DerivativesAvailable = 0,
		/// RingRadius = 1, CrossSectionRadius = 0.5.
		/// </summary>
		// Token: 0x0601861A RID: 99866 RVA: 0x00221BC0 File Offset: 0x0021FDC0
		public vtkParametricTorus() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkParametricTorus.vtkParametricTorus_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601861B RID: 99867 RVA: 0x00221C04 File Offset: 0x0021FE04
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601861C RID: 99868
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricTorus_Evaluate_01(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		/// <summary>
		/// A torus.
		///
		/// This function performs the mapping \f$f(u,v) \rightarrow (x,y,x)\f$, returning it
		/// as Pt. It also returns the partial derivatives Du and Dv.
		/// \f$Pt = (x, y, z), Du = (dx/du, dy/du, dz/du), Dv = (dx/dv, dy/dv, dz/dv)\f$.
		/// Then the normal is \f$N = Du X Dv\f$.
		/// </summary>
		// Token: 0x0601861D RID: 99869 RVA: 0x00221C0F File Offset: 0x0021FE0F
		public override void Evaluate(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			vtkParametricTorus.vtkParametricTorus_Evaluate_01(base.GetCppThis(), uvw, Pt, Duvw);
		}

		// Token: 0x0601861E RID: 99870
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricTorus_EvaluateScalar_02(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		/// <summary>
		/// Calculate a user defined scalar using one or all of uvw, Pt, Duvw.
		///
		/// uvw are the parameters with Pt being the Cartesian point,
		/// Duvw are the derivatives of this point with respect to u, v and w.
		/// Pt, Duvw are obtained from Evaluate().
		///
		/// This function is only called if the ScalarMode has the value
		/// vtkParametricFunctionSource::SCALAR_FUNCTION_DEFINED
		///
		/// If the user does not need to calculate a scalar, then the
		/// instantiated function should return zero.
		/// </summary>
		// Token: 0x0601861F RID: 99871 RVA: 0x00221C24 File Offset: 0x0021FE24
		public override double EvaluateScalar(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			return vtkParametricTorus.vtkParametricTorus_EvaluateScalar_02(base.GetCppThis(), uvw, Pt, Duvw);
		}

		// Token: 0x06018620 RID: 99872
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricTorus_GetCrossSectionRadius_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the radius of the cross section of ring of the torus. Default is 0.5.
		/// </summary>
		// Token: 0x06018621 RID: 99873 RVA: 0x00221C48 File Offset: 0x0021FE48
		public virtual double GetCrossSectionRadius()
		{
			return vtkParametricTorus.vtkParametricTorus_GetCrossSectionRadius_03(base.GetCppThis());
		}

		// Token: 0x06018622 RID: 99874
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricTorus_GetDimension_04(HandleRef pThis);

		/// <summary>
		/// Return the parametric dimension of the class.
		/// </summary>
		// Token: 0x06018623 RID: 99875 RVA: 0x00221C68 File Offset: 0x0021FE68
		public override int GetDimension()
		{
			return vtkParametricTorus.vtkParametricTorus_GetDimension_04(base.GetCppThis());
		}

		// Token: 0x06018624 RID: 99876
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParametricTorus_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018625 RID: 99877 RVA: 0x00221C88 File Offset: 0x0021FE88
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkParametricTorus.vtkParametricTorus_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06018626 RID: 99878
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParametricTorus_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018627 RID: 99879 RVA: 0x00221CA8 File Offset: 0x0021FEA8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkParametricTorus.vtkParametricTorus_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06018628 RID: 99880
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricTorus_GetRingRadius_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the radius from the center to the middle of the ring of the
		/// torus. Default is 1.0.
		/// </summary>
		// Token: 0x06018629 RID: 99881 RVA: 0x00221CC4 File Offset: 0x0021FEC4
		public virtual double GetRingRadius()
		{
			return vtkParametricTorus.vtkParametricTorus_GetRingRadius_07(base.GetCppThis());
		}

		// Token: 0x0601862A RID: 99882
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricTorus_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601862B RID: 99883 RVA: 0x00221CE4 File Offset: 0x0021FEE4
		public override int IsA(string type)
		{
			return vtkParametricTorus.vtkParametricTorus_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0601862C RID: 99884
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricTorus_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601862D RID: 99885 RVA: 0x00221D04 File Offset: 0x0021FF04
		public new static int IsTypeOf(string type)
		{
			return vtkParametricTorus.vtkParametricTorus_IsTypeOf_09(type);
		}

		// Token: 0x0601862E RID: 99886
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricTorus_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601862F RID: 99887 RVA: 0x00221D20 File Offset: 0x0021FF20
		public new vtkParametricTorus NewInstance()
		{
			vtkParametricTorus result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricTorus.vtkParametricTorus_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricTorus)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06018630 RID: 99888
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricTorus_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018631 RID: 99889 RVA: 0x00221D7C File Offset: 0x0021FF7C
		public new static vtkParametricTorus SafeDownCast(vtkObjectBase o)
		{
			vtkParametricTorus vtkParametricTorus = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricTorus.vtkParametricTorus_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParametricTorus = (vtkParametricTorus)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParametricTorus.Register(null);
				}
			}
			return vtkParametricTorus;
		}

		// Token: 0x06018632 RID: 99890
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricTorus_SetCrossSectionRadius_13(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the radius of the cross section of ring of the torus. Default is 0.5.
		/// </summary>
		// Token: 0x06018633 RID: 99891 RVA: 0x00221DFB File Offset: 0x0021FFFB
		public virtual void SetCrossSectionRadius(double _arg)
		{
			vtkParametricTorus.vtkParametricTorus_SetCrossSectionRadius_13(base.GetCppThis(), _arg);
		}

		// Token: 0x06018634 RID: 99892
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricTorus_SetRingRadius_14(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the radius from the center to the middle of the ring of the
		/// torus. Default is 1.0.
		/// </summary>
		// Token: 0x06018635 RID: 99893 RVA: 0x00221E0B File Offset: 0x0022000B
		public virtual void SetRingRadius(double _arg)
		{
			vtkParametricTorus.vtkParametricTorus_SetRingRadius_14(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B10 RID: 6928
		public new const string MRFullTypeName = "Kitware.VTK.vtkParametricTorus";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B11 RID: 6929
		public new static readonly string MRClassNameKey = "class vtkParametricTorus";
	}
}
