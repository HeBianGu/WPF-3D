using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkParametricSuperEllipsoid
	/// </summary>
	/// <remarks>
	///    Generate a superellipsoid.
	///
	/// vtkParametricSuperEllipsoid generates a superellipsoid.  A superellipsoid
	/// is a versatile primitive that is controlled by two parameters n1 and
	/// n2. As special cases it can represent a sphere, square box, and closed
	/// cylindrical can.
	///
	/// For further information about this surface, please consult the
	/// technical description "Parametric surfaces" in http://www.vtk.org/publications
	/// in the "VTK Technical Documents" section in the VTk.org web pages.
	///
	/// Also see: http://paulbourke.net/geometry/superellipse/
	///
	/// @warning
	/// Care needs to be taken specifying the bounds correctly. You may need to
	/// carefully adjust MinimumU, MinimumV, MaximumU, MaximumV.
	///
	/// @par Thanks:
	/// Andrew Maclean andrew.amaclean@gmail.com for creating and contributing the
	/// class.
	///
	/// </remarks>
	// Token: 0x02000931 RID: 2353
	public class vtkParametricSuperEllipsoid : vtkParametricFunction
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060185B6 RID: 99766 RVA: 0x002213E3 File Offset: 0x0021F5E3
		static vtkParametricSuperEllipsoid()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParametricSuperEllipsoid.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParametricSuperEllipsoid"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060185B7 RID: 99767 RVA: 0x0022140B File Offset: 0x0021F60B
		public vtkParametricSuperEllipsoid(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060185B8 RID: 99768
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricSuperEllipsoid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct a superellipsoid with the following parameters:
		/// MinimumU = -Pi, MaximumU = Pi,
		/// MinimumV = -Pi/2, MaximumV = Pi/2,
		/// JoinU = 0, JoinV = 0,
		/// TwistU = 0, TwistV = 0,
		/// ClockwiseOrdering = 0,
		/// DerivativesAvailable = 0,
		/// N1 = 1, N2 = 1, XRadius = 1, YRadius = 1,
		/// ZRadius = 1, a sphere in this case.
		/// </summary>
		// Token: 0x060185B9 RID: 99769 RVA: 0x0022141C File Offset: 0x0021F61C
		public new static vtkParametricSuperEllipsoid New()
		{
			vtkParametricSuperEllipsoid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricSuperEllipsoid.vtkParametricSuperEllipsoid_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricSuperEllipsoid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct a superellipsoid with the following parameters:
		/// MinimumU = -Pi, MaximumU = Pi,
		/// MinimumV = -Pi/2, MaximumV = Pi/2,
		/// JoinU = 0, JoinV = 0,
		/// TwistU = 0, TwistV = 0,
		/// ClockwiseOrdering = 0,
		/// DerivativesAvailable = 0,
		/// N1 = 1, N2 = 1, XRadius = 1, YRadius = 1,
		/// ZRadius = 1, a sphere in this case.
		/// </summary>
		// Token: 0x060185BA RID: 99770 RVA: 0x00221470 File Offset: 0x0021F670
		public vtkParametricSuperEllipsoid() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkParametricSuperEllipsoid.vtkParametricSuperEllipsoid_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060185BB RID: 99771 RVA: 0x002214B4 File Offset: 0x0021F6B4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060185BC RID: 99772
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricSuperEllipsoid_Evaluate_01(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		/// <summary>
		/// A superellipsoid.
		///
		/// This function performs the mapping \f$f(u,v) \rightarrow (x,y,x)\f$, returning it
		/// as Pt. It also returns the partial derivatives Du and Dv.
		/// \f$Pt = (x, y, z), Du = (dx/du, dy/du, dz/du), Dv = (dx/dv, dy/dv, dz/dv)\f$ .
		/// Then the normal is \f$N = Du X Dv\f$ .
		/// </summary>
		// Token: 0x060185BD RID: 99773 RVA: 0x002214BF File Offset: 0x0021F6BF
		public override void Evaluate(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			vtkParametricSuperEllipsoid.vtkParametricSuperEllipsoid_Evaluate_01(base.GetCppThis(), uvw, Pt, Duvw);
		}

		// Token: 0x060185BE RID: 99774
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricSuperEllipsoid_EvaluateScalar_02(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

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
		// Token: 0x060185BF RID: 99775 RVA: 0x002214D4 File Offset: 0x0021F6D4
		public override double EvaluateScalar(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			return vtkParametricSuperEllipsoid.vtkParametricSuperEllipsoid_EvaluateScalar_02(base.GetCppThis(), uvw, Pt, Duvw);
		}

		// Token: 0x060185C0 RID: 99776
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricSuperEllipsoid_GetDimension_03(HandleRef pThis);

		/// <summary>
		/// Return the parametric dimension of the class.
		/// </summary>
		// Token: 0x060185C1 RID: 99777 RVA: 0x002214F8 File Offset: 0x0021F6F8
		public override int GetDimension()
		{
			return vtkParametricSuperEllipsoid.vtkParametricSuperEllipsoid_GetDimension_03(base.GetCppThis());
		}

		// Token: 0x060185C2 RID: 99778
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricSuperEllipsoid_GetN1_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the "squareness" parameter in the z axis.  Default is 1.
		/// </summary>
		// Token: 0x060185C3 RID: 99779 RVA: 0x00221518 File Offset: 0x0021F718
		public virtual double GetN1()
		{
			return vtkParametricSuperEllipsoid.vtkParametricSuperEllipsoid_GetN1_04(base.GetCppThis());
		}

		// Token: 0x060185C4 RID: 99780
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricSuperEllipsoid_GetN2_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the "squareness" parameter in the x-y plane. Default is 1.
		/// </summary>
		// Token: 0x060185C5 RID: 99781 RVA: 0x00221538 File Offset: 0x0021F738
		public virtual double GetN2()
		{
			return vtkParametricSuperEllipsoid.vtkParametricSuperEllipsoid_GetN2_05(base.GetCppThis());
		}

		// Token: 0x060185C6 RID: 99782
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParametricSuperEllipsoid_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060185C7 RID: 99783 RVA: 0x00221558 File Offset: 0x0021F758
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkParametricSuperEllipsoid.vtkParametricSuperEllipsoid_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x060185C8 RID: 99784
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParametricSuperEllipsoid_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060185C9 RID: 99785 RVA: 0x00221578 File Offset: 0x0021F778
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkParametricSuperEllipsoid.vtkParametricSuperEllipsoid_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x060185CA RID: 99786
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricSuperEllipsoid_GetXRadius_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the scaling factor for the x-axis. Default is 1.
		/// </summary>
		// Token: 0x060185CB RID: 99787 RVA: 0x00221594 File Offset: 0x0021F794
		public virtual double GetXRadius()
		{
			return vtkParametricSuperEllipsoid.vtkParametricSuperEllipsoid_GetXRadius_08(base.GetCppThis());
		}

		// Token: 0x060185CC RID: 99788
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricSuperEllipsoid_GetYRadius_09(HandleRef pThis);

		/// <summary>
		/// Set/Get the scaling factor for the y-axis. Default is 1.
		/// </summary>
		// Token: 0x060185CD RID: 99789 RVA: 0x002215B4 File Offset: 0x0021F7B4
		public virtual double GetYRadius()
		{
			return vtkParametricSuperEllipsoid.vtkParametricSuperEllipsoid_GetYRadius_09(base.GetCppThis());
		}

		// Token: 0x060185CE RID: 99790
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricSuperEllipsoid_GetZRadius_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the scaling factor for the z-axis. Default is 1.
		/// </summary>
		// Token: 0x060185CF RID: 99791 RVA: 0x002215D4 File Offset: 0x0021F7D4
		public virtual double GetZRadius()
		{
			return vtkParametricSuperEllipsoid.vtkParametricSuperEllipsoid_GetZRadius_10(base.GetCppThis());
		}

		// Token: 0x060185D0 RID: 99792
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricSuperEllipsoid_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060185D1 RID: 99793 RVA: 0x002215F4 File Offset: 0x0021F7F4
		public override int IsA(string type)
		{
			return vtkParametricSuperEllipsoid.vtkParametricSuperEllipsoid_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x060185D2 RID: 99794
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricSuperEllipsoid_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060185D3 RID: 99795 RVA: 0x00221614 File Offset: 0x0021F814
		public new static int IsTypeOf(string type)
		{
			return vtkParametricSuperEllipsoid.vtkParametricSuperEllipsoid_IsTypeOf_12(type);
		}

		// Token: 0x060185D4 RID: 99796
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricSuperEllipsoid_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060185D5 RID: 99797 RVA: 0x00221630 File Offset: 0x0021F830
		public new vtkParametricSuperEllipsoid NewInstance()
		{
			vtkParametricSuperEllipsoid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricSuperEllipsoid.vtkParametricSuperEllipsoid_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricSuperEllipsoid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060185D6 RID: 99798
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricSuperEllipsoid_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060185D7 RID: 99799 RVA: 0x0022168C File Offset: 0x0021F88C
		public new static vtkParametricSuperEllipsoid SafeDownCast(vtkObjectBase o)
		{
			vtkParametricSuperEllipsoid vtkParametricSuperEllipsoid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricSuperEllipsoid.vtkParametricSuperEllipsoid_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParametricSuperEllipsoid = (vtkParametricSuperEllipsoid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParametricSuperEllipsoid.Register(null);
				}
			}
			return vtkParametricSuperEllipsoid;
		}

		// Token: 0x060185D8 RID: 99800
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricSuperEllipsoid_SetN1_16(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the "squareness" parameter in the z axis.  Default is 1.
		/// </summary>
		// Token: 0x060185D9 RID: 99801 RVA: 0x0022170B File Offset: 0x0021F90B
		public virtual void SetN1(double _arg)
		{
			vtkParametricSuperEllipsoid.vtkParametricSuperEllipsoid_SetN1_16(base.GetCppThis(), _arg);
		}

		// Token: 0x060185DA RID: 99802
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricSuperEllipsoid_SetN2_17(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the "squareness" parameter in the x-y plane. Default is 1.
		/// </summary>
		// Token: 0x060185DB RID: 99803 RVA: 0x0022171B File Offset: 0x0021F91B
		public virtual void SetN2(double _arg)
		{
			vtkParametricSuperEllipsoid.vtkParametricSuperEllipsoid_SetN2_17(base.GetCppThis(), _arg);
		}

		// Token: 0x060185DC RID: 99804
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricSuperEllipsoid_SetXRadius_18(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the scaling factor for the x-axis. Default is 1.
		/// </summary>
		// Token: 0x060185DD RID: 99805 RVA: 0x0022172B File Offset: 0x0021F92B
		public virtual void SetXRadius(double _arg)
		{
			vtkParametricSuperEllipsoid.vtkParametricSuperEllipsoid_SetXRadius_18(base.GetCppThis(), _arg);
		}

		// Token: 0x060185DE RID: 99806
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricSuperEllipsoid_SetYRadius_19(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the scaling factor for the y-axis. Default is 1.
		/// </summary>
		// Token: 0x060185DF RID: 99807 RVA: 0x0022173B File Offset: 0x0021F93B
		public virtual void SetYRadius(double _arg)
		{
			vtkParametricSuperEllipsoid.vtkParametricSuperEllipsoid_SetYRadius_19(base.GetCppThis(), _arg);
		}

		// Token: 0x060185E0 RID: 99808
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricSuperEllipsoid_SetZRadius_20(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the scaling factor for the z-axis. Default is 1.
		/// </summary>
		// Token: 0x060185E1 RID: 99809 RVA: 0x0022174B File Offset: 0x0021F94B
		public virtual void SetZRadius(double _arg)
		{
			vtkParametricSuperEllipsoid.vtkParametricSuperEllipsoid_SetZRadius_20(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B0C RID: 6924
		public new const string MRFullTypeName = "Kitware.VTK.vtkParametricSuperEllipsoid";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B0D RID: 6925
		public new static readonly string MRClassNameKey = "class vtkParametricSuperEllipsoid";
	}
}
