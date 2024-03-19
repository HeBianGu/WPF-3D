using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkParametricFunction
	/// </summary>
	/// <remarks>
	///    abstract interface for parametric functions
	///
	/// vtkParametricFunction is an abstract interface for functions
	/// defined by parametric mapping i.e. f(u,v,w)-&gt;(x,y,z) where
	/// u_min &lt;= u &lt; u_max, v_min &lt;= v &lt; v_max, w_min &lt;= w &lt; w_max. (For
	/// notational convenience, we will write f(u)-&gt;x and assume that
	/// u means (u,v,w) and x means (x,y,z).)
	///
	/// The interface contains the pure virtual function, Evaluate(), that
	/// generates a point and the derivatives at that point which are then used to
	/// construct the surface. A second pure virtual function, EvaluateScalar(),
	/// can be used to generate a scalar for the surface. Finally, the
	/// GetDimension() virtual function is used to differentiate 1D, 2D, and 3D
	/// parametric functions. Since this abstract class defines a pure virtual
	/// API, its subclasses must implement the pure virtual functions
	/// GetDimension(), Evaluate() and EvaluateScalar().
	///
	/// This class has also methods for defining a range of parametric values (u,v,w).
	///
	/// @par Thanks:
	/// Andrew Maclean andrew.amaclean@gmail.com for creating and contributing the
	/// class.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkParametricFunctionSource - tessellates a parametric function
	///
	///
	/// Implementations of derived classes implementing non-orentable surfaces:
	/// vtkParametricBoy vtkParametricCrossCap vtkParametricFigure8Klein
	/// vtkParametricKlein vtkParametricMobius vtkParametricRoman
	///
	///
	/// Implementations of derived classes implementing orientable surfaces:
	/// vtkParametricConicSpiral vtkParametricDini vtkParametricEllipsoid
	/// vtkParametricEnneper vtkParametricRandomHills vtkParametricSuperEllipsoid
	/// vtkParametricSuperToroid vtkParametricTorus
	///
	/// </seealso>
	// Token: 0x0200091D RID: 2333
	public abstract class vtkParametricFunction : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060182B1 RID: 98993 RVA: 0x0021D26B File Offset: 0x0021B46B
		static vtkParametricFunction()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParametricFunction.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParametricFunction"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060182B2 RID: 98994 RVA: 0x0021D293 File Offset: 0x0021B493
		public vtkParametricFunction(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060182B3 RID: 98995 RVA: 0x0021D2A1 File Offset: 0x0021B4A1
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060182B4 RID: 98996
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunction_ClockwiseOrderingOff_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which determines the ordering of the
		/// vertices forming the triangle strips. The ordering of the
		/// points being inserted into the triangle strip is important
		/// because it determines the direction of the normals for the
		/// lighting. If set, the ordering is clockwise, otherwise the
		/// ordering is anti-clockwise. Default is true (i.e. clockwise
		/// ordering).
		/// </summary>
		// Token: 0x060182B5 RID: 98997 RVA: 0x0021D2AC File Offset: 0x0021B4AC
		public virtual void ClockwiseOrderingOff()
		{
			vtkParametricFunction.vtkParametricFunction_ClockwiseOrderingOff_01(base.GetCppThis());
		}

		// Token: 0x060182B6 RID: 98998
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunction_ClockwiseOrderingOn_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which determines the ordering of the
		/// vertices forming the triangle strips. The ordering of the
		/// points being inserted into the triangle strip is important
		/// because it determines the direction of the normals for the
		/// lighting. If set, the ordering is clockwise, otherwise the
		/// ordering is anti-clockwise. Default is true (i.e. clockwise
		/// ordering).
		/// </summary>
		// Token: 0x060182B7 RID: 98999 RVA: 0x0021D2BB File Offset: 0x0021B4BB
		public virtual void ClockwiseOrderingOn()
		{
			vtkParametricFunction.vtkParametricFunction_ClockwiseOrderingOn_02(base.GetCppThis());
		}

		// Token: 0x060182B8 RID: 99000
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunction_DerivativesAvailableOff_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which determines whether derivatives are available
		/// from the parametric function (i.e., whether the Evaluate() method
		/// returns valid derivatives).
		/// </summary>
		// Token: 0x060182B9 RID: 99001 RVA: 0x0021D2CA File Offset: 0x0021B4CA
		public virtual void DerivativesAvailableOff()
		{
			vtkParametricFunction.vtkParametricFunction_DerivativesAvailableOff_03(base.GetCppThis());
		}

		// Token: 0x060182BA RID: 99002
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunction_DerivativesAvailableOn_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which determines whether derivatives are available
		/// from the parametric function (i.e., whether the Evaluate() method
		/// returns valid derivatives).
		/// </summary>
		// Token: 0x060182BB RID: 99003 RVA: 0x0021D2D9 File Offset: 0x0021B4D9
		public virtual void DerivativesAvailableOn()
		{
			vtkParametricFunction.vtkParametricFunction_DerivativesAvailableOn_04(base.GetCppThis());
		}

		// Token: 0x060182BC RID: 99004
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunction_Evaluate_05(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		/// <summary>
		/// Performs the mapping \$f(uvw)-&gt;(Pt,Duvw)\$f.
		/// This is a pure virtual function that must be instantiated in
		/// a derived class.
		///
		/// uvw are the parameters, with u corresponding to uvw[0],
		/// v to uvw[1] and w to uvw[2] respectively. Pt is the returned Cartesian point,
		/// Duvw are the derivatives of this point with respect to u, v and w.
		/// Note that the first three values in Duvw are Du, the next three are Dv,
		/// and the final three are Dw. Du Dv Dw are the partial derivatives of the
		/// function at the point Pt with respect to u, v and w respectively.
		/// </summary>
		// Token: 0x060182BD RID: 99005 RVA: 0x0021D2E8 File Offset: 0x0021B4E8
		public virtual void Evaluate(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			vtkParametricFunction.vtkParametricFunction_Evaluate_05(base.GetCppThis(), uvw, Pt, Duvw);
		}

		// Token: 0x060182BE RID: 99006
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricFunction_EvaluateScalar_06(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		/// <summary>
		/// Calculate a user defined scalar using one or all of uvw, Pt, Duvw.
		/// This is a pure virtual function that must be instantiated in
		/// a derived class.
		///
		/// uvw are the parameters with Pt being the cartesian point,
		/// Duvw are the derivatives of this point with respect to u, v, and w.
		/// Pt, Duvw are obtained from Evaluate().
		/// </summary>
		// Token: 0x060182BF RID: 99007 RVA: 0x0021D2FC File Offset: 0x0021B4FC
		public virtual double EvaluateScalar(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			return vtkParametricFunction.vtkParametricFunction_EvaluateScalar_06(base.GetCppThis(), uvw, Pt, Duvw);
		}

		// Token: 0x060182C0 RID: 99008
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricFunction_GetClockwiseOrdering_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which determines the ordering of the
		/// vertices forming the triangle strips. The ordering of the
		/// points being inserted into the triangle strip is important
		/// because it determines the direction of the normals for the
		/// lighting. If set, the ordering is clockwise, otherwise the
		/// ordering is anti-clockwise. Default is true (i.e. clockwise
		/// ordering).
		/// </summary>
		// Token: 0x060182C1 RID: 99009 RVA: 0x0021D320 File Offset: 0x0021B520
		public virtual int GetClockwiseOrdering()
		{
			return vtkParametricFunction.vtkParametricFunction_GetClockwiseOrdering_07(base.GetCppThis());
		}

		// Token: 0x060182C2 RID: 99010
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricFunction_GetClockwiseOrderingMaxValue_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which determines the ordering of the
		/// vertices forming the triangle strips. The ordering of the
		/// points being inserted into the triangle strip is important
		/// because it determines the direction of the normals for the
		/// lighting. If set, the ordering is clockwise, otherwise the
		/// ordering is anti-clockwise. Default is true (i.e. clockwise
		/// ordering).
		/// </summary>
		// Token: 0x060182C3 RID: 99011 RVA: 0x0021D340 File Offset: 0x0021B540
		public virtual int GetClockwiseOrderingMaxValue()
		{
			return vtkParametricFunction.vtkParametricFunction_GetClockwiseOrderingMaxValue_08(base.GetCppThis());
		}

		// Token: 0x060182C4 RID: 99012
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricFunction_GetClockwiseOrderingMinValue_09(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which determines the ordering of the
		/// vertices forming the triangle strips. The ordering of the
		/// points being inserted into the triangle strip is important
		/// because it determines the direction of the normals for the
		/// lighting. If set, the ordering is clockwise, otherwise the
		/// ordering is anti-clockwise. Default is true (i.e. clockwise
		/// ordering).
		/// </summary>
		// Token: 0x060182C5 RID: 99013 RVA: 0x0021D360 File Offset: 0x0021B560
		public virtual int GetClockwiseOrderingMinValue()
		{
			return vtkParametricFunction.vtkParametricFunction_GetClockwiseOrderingMinValue_09(base.GetCppThis());
		}

		// Token: 0x060182C6 RID: 99014
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricFunction_GetDerivativesAvailable_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which determines whether derivatives are available
		/// from the parametric function (i.e., whether the Evaluate() method
		/// returns valid derivatives).
		/// </summary>
		// Token: 0x060182C7 RID: 99015 RVA: 0x0021D380 File Offset: 0x0021B580
		public virtual int GetDerivativesAvailable()
		{
			return vtkParametricFunction.vtkParametricFunction_GetDerivativesAvailable_10(base.GetCppThis());
		}

		// Token: 0x060182C8 RID: 99016
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricFunction_GetDerivativesAvailableMaxValue_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which determines whether derivatives are available
		/// from the parametric function (i.e., whether the Evaluate() method
		/// returns valid derivatives).
		/// </summary>
		// Token: 0x060182C9 RID: 99017 RVA: 0x0021D3A0 File Offset: 0x0021B5A0
		public virtual int GetDerivativesAvailableMaxValue()
		{
			return vtkParametricFunction.vtkParametricFunction_GetDerivativesAvailableMaxValue_11(base.GetCppThis());
		}

		// Token: 0x060182CA RID: 99018
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricFunction_GetDerivativesAvailableMinValue_12(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which determines whether derivatives are available
		/// from the parametric function (i.e., whether the Evaluate() method
		/// returns valid derivatives).
		/// </summary>
		// Token: 0x060182CB RID: 99019 RVA: 0x0021D3C0 File Offset: 0x0021B5C0
		public virtual int GetDerivativesAvailableMinValue()
		{
			return vtkParametricFunction.vtkParametricFunction_GetDerivativesAvailableMinValue_12(base.GetCppThis());
		}

		// Token: 0x060182CC RID: 99020
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricFunction_GetDimension_13(HandleRef pThis);

		/// <summary>
		/// Return the dimension of parametric space. Depending on the dimension,
		/// then the (u,v,w) parameters and associated information (e.g., derivates)
		/// have meaning. For example, if the dimension of the function is one, then
		/// u[0] and Duvw[0...2] have meaning.
		/// This is a pure virtual function that must be instantiated in
		/// a derived class.
		/// </summary>
		// Token: 0x060182CD RID: 99021 RVA: 0x0021D3E0 File Offset: 0x0021B5E0
		public virtual int GetDimension()
		{
			return vtkParametricFunction.vtkParametricFunction_GetDimension_13(base.GetCppThis());
		}

		// Token: 0x060182CE RID: 99022
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricFunction_GetJoinU_14(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which joins the first triangle strip to the last one.
		/// </summary>
		// Token: 0x060182CF RID: 99023 RVA: 0x0021D400 File Offset: 0x0021B600
		public virtual int GetJoinU()
		{
			return vtkParametricFunction.vtkParametricFunction_GetJoinU_14(base.GetCppThis());
		}

		// Token: 0x060182D0 RID: 99024
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricFunction_GetJoinUMaxValue_15(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which joins the first triangle strip to the last one.
		/// </summary>
		// Token: 0x060182D1 RID: 99025 RVA: 0x0021D420 File Offset: 0x0021B620
		public virtual int GetJoinUMaxValue()
		{
			return vtkParametricFunction.vtkParametricFunction_GetJoinUMaxValue_15(base.GetCppThis());
		}

		// Token: 0x060182D2 RID: 99026
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricFunction_GetJoinUMinValue_16(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which joins the first triangle strip to the last one.
		/// </summary>
		// Token: 0x060182D3 RID: 99027 RVA: 0x0021D440 File Offset: 0x0021B640
		public virtual int GetJoinUMinValue()
		{
			return vtkParametricFunction.vtkParametricFunction_GetJoinUMinValue_16(base.GetCppThis());
		}

		// Token: 0x060182D4 RID: 99028
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricFunction_GetJoinV_17(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which joins the ends of the triangle strips.
		/// </summary>
		// Token: 0x060182D5 RID: 99029 RVA: 0x0021D460 File Offset: 0x0021B660
		public virtual int GetJoinV()
		{
			return vtkParametricFunction.vtkParametricFunction_GetJoinV_17(base.GetCppThis());
		}

		// Token: 0x060182D6 RID: 99030
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricFunction_GetJoinVMaxValue_18(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which joins the ends of the triangle strips.
		/// </summary>
		// Token: 0x060182D7 RID: 99031 RVA: 0x0021D480 File Offset: 0x0021B680
		public virtual int GetJoinVMaxValue()
		{
			return vtkParametricFunction.vtkParametricFunction_GetJoinVMaxValue_18(base.GetCppThis());
		}

		// Token: 0x060182D8 RID: 99032
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricFunction_GetJoinVMinValue_19(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which joins the ends of the triangle strips.
		/// </summary>
		// Token: 0x060182D9 RID: 99033 RVA: 0x0021D4A0 File Offset: 0x0021B6A0
		public virtual int GetJoinVMinValue()
		{
			return vtkParametricFunction.vtkParametricFunction_GetJoinVMinValue_19(base.GetCppThis());
		}

		// Token: 0x060182DA RID: 99034
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricFunction_GetJoinW_20(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which joins the ends of the triangle strips.
		/// </summary>
		// Token: 0x060182DB RID: 99035 RVA: 0x0021D4C0 File Offset: 0x0021B6C0
		public virtual int GetJoinW()
		{
			return vtkParametricFunction.vtkParametricFunction_GetJoinW_20(base.GetCppThis());
		}

		// Token: 0x060182DC RID: 99036
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricFunction_GetJoinWMaxValue_21(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which joins the ends of the triangle strips.
		/// </summary>
		// Token: 0x060182DD RID: 99037 RVA: 0x0021D4E0 File Offset: 0x0021B6E0
		public virtual int GetJoinWMaxValue()
		{
			return vtkParametricFunction.vtkParametricFunction_GetJoinWMaxValue_21(base.GetCppThis());
		}

		// Token: 0x060182DE RID: 99038
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricFunction_GetJoinWMinValue_22(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which joins the ends of the triangle strips.
		/// </summary>
		// Token: 0x060182DF RID: 99039 RVA: 0x0021D500 File Offset: 0x0021B700
		public virtual int GetJoinWMinValue()
		{
			return vtkParametricFunction.vtkParametricFunction_GetJoinWMinValue_22(base.GetCppThis());
		}

		// Token: 0x060182E0 RID: 99040
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricFunction_GetMaximumU_23(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum u-value.
		/// </summary>
		// Token: 0x060182E1 RID: 99041 RVA: 0x0021D520 File Offset: 0x0021B720
		public virtual double GetMaximumU()
		{
			return vtkParametricFunction.vtkParametricFunction_GetMaximumU_23(base.GetCppThis());
		}

		// Token: 0x060182E2 RID: 99042
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricFunction_GetMaximumV_24(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum v-value.
		/// </summary>
		// Token: 0x060182E3 RID: 99043 RVA: 0x0021D540 File Offset: 0x0021B740
		public virtual double GetMaximumV()
		{
			return vtkParametricFunction.vtkParametricFunction_GetMaximumV_24(base.GetCppThis());
		}

		// Token: 0x060182E4 RID: 99044
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricFunction_GetMaximumW_25(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum w-value.
		/// </summary>
		// Token: 0x060182E5 RID: 99045 RVA: 0x0021D560 File Offset: 0x0021B760
		public virtual double GetMaximumW()
		{
			return vtkParametricFunction.vtkParametricFunction_GetMaximumW_25(base.GetCppThis());
		}

		// Token: 0x060182E6 RID: 99046
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricFunction_GetMinimumU_26(HandleRef pThis);

		/// <summary>
		/// Set/Get the minimum u-value.
		/// </summary>
		// Token: 0x060182E7 RID: 99047 RVA: 0x0021D580 File Offset: 0x0021B780
		public virtual double GetMinimumU()
		{
			return vtkParametricFunction.vtkParametricFunction_GetMinimumU_26(base.GetCppThis());
		}

		// Token: 0x060182E8 RID: 99048
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricFunction_GetMinimumV_27(HandleRef pThis);

		/// <summary>
		/// Set/Get the minimum v-value.
		/// </summary>
		// Token: 0x060182E9 RID: 99049 RVA: 0x0021D5A0 File Offset: 0x0021B7A0
		public virtual double GetMinimumV()
		{
			return vtkParametricFunction.vtkParametricFunction_GetMinimumV_27(base.GetCppThis());
		}

		// Token: 0x060182EA RID: 99050
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricFunction_GetMinimumW_28(HandleRef pThis);

		/// <summary>
		/// Set/Get the minimum w-value.
		/// </summary>
		// Token: 0x060182EB RID: 99051 RVA: 0x0021D5C0 File Offset: 0x0021B7C0
		public virtual double GetMinimumW()
		{
			return vtkParametricFunction.vtkParametricFunction_GetMinimumW_28(base.GetCppThis());
		}

		// Token: 0x060182EC RID: 99052
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParametricFunction_GetNumberOfGenerationsFromBase_29(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060182ED RID: 99053 RVA: 0x0021D5E0 File Offset: 0x0021B7E0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkParametricFunction.vtkParametricFunction_GetNumberOfGenerationsFromBase_29(base.GetCppThis(), type);
		}

		// Token: 0x060182EE RID: 99054
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParametricFunction_GetNumberOfGenerationsFromBaseType_30([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060182EF RID: 99055 RVA: 0x0021D600 File Offset: 0x0021B800
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkParametricFunction.vtkParametricFunction_GetNumberOfGenerationsFromBaseType_30(type);
		}

		// Token: 0x060182F0 RID: 99056
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricFunction_GetTwistU_31(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which joins the first triangle strip to
		/// the last one with a twist.
		/// JoinU must also be set if this is set.
		/// Used when building some non-orientable surfaces.
		/// </summary>
		// Token: 0x060182F1 RID: 99057 RVA: 0x0021D61C File Offset: 0x0021B81C
		public virtual int GetTwistU()
		{
			return vtkParametricFunction.vtkParametricFunction_GetTwistU_31(base.GetCppThis());
		}

		// Token: 0x060182F2 RID: 99058
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricFunction_GetTwistUMaxValue_32(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which joins the first triangle strip to
		/// the last one with a twist.
		/// JoinU must also be set if this is set.
		/// Used when building some non-orientable surfaces.
		/// </summary>
		// Token: 0x060182F3 RID: 99059 RVA: 0x0021D63C File Offset: 0x0021B83C
		public virtual int GetTwistUMaxValue()
		{
			return vtkParametricFunction.vtkParametricFunction_GetTwistUMaxValue_32(base.GetCppThis());
		}

		// Token: 0x060182F4 RID: 99060
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricFunction_GetTwistUMinValue_33(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which joins the first triangle strip to
		/// the last one with a twist.
		/// JoinU must also be set if this is set.
		/// Used when building some non-orientable surfaces.
		/// </summary>
		// Token: 0x060182F5 RID: 99061 RVA: 0x0021D65C File Offset: 0x0021B85C
		public virtual int GetTwistUMinValue()
		{
			return vtkParametricFunction.vtkParametricFunction_GetTwistUMinValue_33(base.GetCppThis());
		}

		// Token: 0x060182F6 RID: 99062
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricFunction_GetTwistV_34(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which joins the ends of the
		/// triangle strips with a twist.
		/// JoinV must also be set if this is set.
		/// Used when building some non-orientable surfaces.
		/// </summary>
		// Token: 0x060182F7 RID: 99063 RVA: 0x0021D67C File Offset: 0x0021B87C
		public virtual int GetTwistV()
		{
			return vtkParametricFunction.vtkParametricFunction_GetTwistV_34(base.GetCppThis());
		}

		// Token: 0x060182F8 RID: 99064
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricFunction_GetTwistVMaxValue_35(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which joins the ends of the
		/// triangle strips with a twist.
		/// JoinV must also be set if this is set.
		/// Used when building some non-orientable surfaces.
		/// </summary>
		// Token: 0x060182F9 RID: 99065 RVA: 0x0021D69C File Offset: 0x0021B89C
		public virtual int GetTwistVMaxValue()
		{
			return vtkParametricFunction.vtkParametricFunction_GetTwistVMaxValue_35(base.GetCppThis());
		}

		// Token: 0x060182FA RID: 99066
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricFunction_GetTwistVMinValue_36(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which joins the ends of the
		/// triangle strips with a twist.
		/// JoinV must also be set if this is set.
		/// Used when building some non-orientable surfaces.
		/// </summary>
		// Token: 0x060182FB RID: 99067 RVA: 0x0021D6BC File Offset: 0x0021B8BC
		public virtual int GetTwistVMinValue()
		{
			return vtkParametricFunction.vtkParametricFunction_GetTwistVMinValue_36(base.GetCppThis());
		}

		// Token: 0x060182FC RID: 99068
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricFunction_GetTwistW_37(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which joins the ends of the
		/// triangle strips with a twist.
		/// JoinW must also be set if this is set.
		/// Used when building some non-orientable surfaces.
		/// </summary>
		// Token: 0x060182FD RID: 99069 RVA: 0x0021D6DC File Offset: 0x0021B8DC
		public virtual int GetTwistW()
		{
			return vtkParametricFunction.vtkParametricFunction_GetTwistW_37(base.GetCppThis());
		}

		// Token: 0x060182FE RID: 99070
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricFunction_GetTwistWMaxValue_38(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which joins the ends of the
		/// triangle strips with a twist.
		/// JoinW must also be set if this is set.
		/// Used when building some non-orientable surfaces.
		/// </summary>
		// Token: 0x060182FF RID: 99071 RVA: 0x0021D6FC File Offset: 0x0021B8FC
		public virtual int GetTwistWMaxValue()
		{
			return vtkParametricFunction.vtkParametricFunction_GetTwistWMaxValue_38(base.GetCppThis());
		}

		// Token: 0x06018300 RID: 99072
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricFunction_GetTwistWMinValue_39(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which joins the ends of the
		/// triangle strips with a twist.
		/// JoinW must also be set if this is set.
		/// Used when building some non-orientable surfaces.
		/// </summary>
		// Token: 0x06018301 RID: 99073 RVA: 0x0021D71C File Offset: 0x0021B91C
		public virtual int GetTwistWMinValue()
		{
			return vtkParametricFunction.vtkParametricFunction_GetTwistWMinValue_39(base.GetCppThis());
		}

		// Token: 0x06018302 RID: 99074
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricFunction_IsA_40(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018303 RID: 99075 RVA: 0x0021D73C File Offset: 0x0021B93C
		public override int IsA(string type)
		{
			return vtkParametricFunction.vtkParametricFunction_IsA_40(base.GetCppThis(), type);
		}

		// Token: 0x06018304 RID: 99076
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricFunction_IsTypeOf_41([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018305 RID: 99077 RVA: 0x0021D75C File Offset: 0x0021B95C
		public new static int IsTypeOf(string type)
		{
			return vtkParametricFunction.vtkParametricFunction_IsTypeOf_41(type);
		}

		// Token: 0x06018306 RID: 99078
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunction_JoinUOff_42(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which joins the first triangle strip to the last one.
		/// </summary>
		// Token: 0x06018307 RID: 99079 RVA: 0x0021D776 File Offset: 0x0021B976
		public virtual void JoinUOff()
		{
			vtkParametricFunction.vtkParametricFunction_JoinUOff_42(base.GetCppThis());
		}

		// Token: 0x06018308 RID: 99080
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunction_JoinUOn_43(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which joins the first triangle strip to the last one.
		/// </summary>
		// Token: 0x06018309 RID: 99081 RVA: 0x0021D785 File Offset: 0x0021B985
		public virtual void JoinUOn()
		{
			vtkParametricFunction.vtkParametricFunction_JoinUOn_43(base.GetCppThis());
		}

		// Token: 0x0601830A RID: 99082
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunction_JoinVOff_44(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which joins the ends of the triangle strips.
		/// </summary>
		// Token: 0x0601830B RID: 99083 RVA: 0x0021D794 File Offset: 0x0021B994
		public virtual void JoinVOff()
		{
			vtkParametricFunction.vtkParametricFunction_JoinVOff_44(base.GetCppThis());
		}

		// Token: 0x0601830C RID: 99084
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunction_JoinVOn_45(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which joins the ends of the triangle strips.
		/// </summary>
		// Token: 0x0601830D RID: 99085 RVA: 0x0021D7A3 File Offset: 0x0021B9A3
		public virtual void JoinVOn()
		{
			vtkParametricFunction.vtkParametricFunction_JoinVOn_45(base.GetCppThis());
		}

		// Token: 0x0601830E RID: 99086
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunction_JoinWOff_46(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which joins the ends of the triangle strips.
		/// </summary>
		// Token: 0x0601830F RID: 99087 RVA: 0x0021D7B2 File Offset: 0x0021B9B2
		public virtual void JoinWOff()
		{
			vtkParametricFunction.vtkParametricFunction_JoinWOff_46(base.GetCppThis());
		}

		// Token: 0x06018310 RID: 99088
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunction_JoinWOn_47(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which joins the ends of the triangle strips.
		/// </summary>
		// Token: 0x06018311 RID: 99089 RVA: 0x0021D7C1 File Offset: 0x0021B9C1
		public virtual void JoinWOn()
		{
			vtkParametricFunction.vtkParametricFunction_JoinWOn_47(base.GetCppThis());
		}

		// Token: 0x06018312 RID: 99090
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricFunction_NewInstance_48(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018313 RID: 99091 RVA: 0x0021D7D0 File Offset: 0x0021B9D0
		public new vtkParametricFunction NewInstance()
		{
			vtkParametricFunction result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricFunction.vtkParametricFunction_NewInstance_48(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06018314 RID: 99092
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricFunction_SafeDownCast_49(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018315 RID: 99093 RVA: 0x0021D82C File Offset: 0x0021BA2C
		public new static vtkParametricFunction SafeDownCast(vtkObjectBase o)
		{
			vtkParametricFunction vtkParametricFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricFunction.vtkParametricFunction_SafeDownCast_49((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParametricFunction = (vtkParametricFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParametricFunction.Register(null);
				}
			}
			return vtkParametricFunction;
		}

		// Token: 0x06018316 RID: 99094
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunction_SetClockwiseOrdering_50(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the flag which determines the ordering of the
		/// vertices forming the triangle strips. The ordering of the
		/// points being inserted into the triangle strip is important
		/// because it determines the direction of the normals for the
		/// lighting. If set, the ordering is clockwise, otherwise the
		/// ordering is anti-clockwise. Default is true (i.e. clockwise
		/// ordering).
		/// </summary>
		// Token: 0x06018317 RID: 99095 RVA: 0x0021D8AB File Offset: 0x0021BAAB
		public virtual void SetClockwiseOrdering(int _arg)
		{
			vtkParametricFunction.vtkParametricFunction_SetClockwiseOrdering_50(base.GetCppThis(), _arg);
		}

		// Token: 0x06018318 RID: 99096
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunction_SetDerivativesAvailable_51(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the flag which determines whether derivatives are available
		/// from the parametric function (i.e., whether the Evaluate() method
		/// returns valid derivatives).
		/// </summary>
		// Token: 0x06018319 RID: 99097 RVA: 0x0021D8BB File Offset: 0x0021BABB
		public virtual void SetDerivativesAvailable(int _arg)
		{
			vtkParametricFunction.vtkParametricFunction_SetDerivativesAvailable_51(base.GetCppThis(), _arg);
		}

		// Token: 0x0601831A RID: 99098
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunction_SetJoinU_52(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the flag which joins the first triangle strip to the last one.
		/// </summary>
		// Token: 0x0601831B RID: 99099 RVA: 0x0021D8CB File Offset: 0x0021BACB
		public virtual void SetJoinU(int _arg)
		{
			vtkParametricFunction.vtkParametricFunction_SetJoinU_52(base.GetCppThis(), _arg);
		}

		// Token: 0x0601831C RID: 99100
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunction_SetJoinV_53(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the flag which joins the ends of the triangle strips.
		/// </summary>
		// Token: 0x0601831D RID: 99101 RVA: 0x0021D8DB File Offset: 0x0021BADB
		public virtual void SetJoinV(int _arg)
		{
			vtkParametricFunction.vtkParametricFunction_SetJoinV_53(base.GetCppThis(), _arg);
		}

		// Token: 0x0601831E RID: 99102
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunction_SetJoinW_54(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the flag which joins the ends of the triangle strips.
		/// </summary>
		// Token: 0x0601831F RID: 99103 RVA: 0x0021D8EB File Offset: 0x0021BAEB
		public virtual void SetJoinW(int _arg)
		{
			vtkParametricFunction.vtkParametricFunction_SetJoinW_54(base.GetCppThis(), _arg);
		}

		// Token: 0x06018320 RID: 99104
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunction_SetMaximumU_55(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the maximum u-value.
		/// </summary>
		// Token: 0x06018321 RID: 99105 RVA: 0x0021D8FB File Offset: 0x0021BAFB
		public virtual void SetMaximumU(double _arg)
		{
			vtkParametricFunction.vtkParametricFunction_SetMaximumU_55(base.GetCppThis(), _arg);
		}

		// Token: 0x06018322 RID: 99106
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunction_SetMaximumV_56(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the maximum v-value.
		/// </summary>
		// Token: 0x06018323 RID: 99107 RVA: 0x0021D90B File Offset: 0x0021BB0B
		public virtual void SetMaximumV(double _arg)
		{
			vtkParametricFunction.vtkParametricFunction_SetMaximumV_56(base.GetCppThis(), _arg);
		}

		// Token: 0x06018324 RID: 99108
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunction_SetMaximumW_57(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the maximum w-value.
		/// </summary>
		// Token: 0x06018325 RID: 99109 RVA: 0x0021D91B File Offset: 0x0021BB1B
		public virtual void SetMaximumW(double _arg)
		{
			vtkParametricFunction.vtkParametricFunction_SetMaximumW_57(base.GetCppThis(), _arg);
		}

		// Token: 0x06018326 RID: 99110
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunction_SetMinimumU_58(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the minimum u-value.
		/// </summary>
		// Token: 0x06018327 RID: 99111 RVA: 0x0021D92B File Offset: 0x0021BB2B
		public virtual void SetMinimumU(double _arg)
		{
			vtkParametricFunction.vtkParametricFunction_SetMinimumU_58(base.GetCppThis(), _arg);
		}

		// Token: 0x06018328 RID: 99112
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunction_SetMinimumV_59(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the minimum v-value.
		/// </summary>
		// Token: 0x06018329 RID: 99113 RVA: 0x0021D93B File Offset: 0x0021BB3B
		public virtual void SetMinimumV(double _arg)
		{
			vtkParametricFunction.vtkParametricFunction_SetMinimumV_59(base.GetCppThis(), _arg);
		}

		// Token: 0x0601832A RID: 99114
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunction_SetMinimumW_60(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the minimum w-value.
		/// </summary>
		// Token: 0x0601832B RID: 99115 RVA: 0x0021D94B File Offset: 0x0021BB4B
		public virtual void SetMinimumW(double _arg)
		{
			vtkParametricFunction.vtkParametricFunction_SetMinimumW_60(base.GetCppThis(), _arg);
		}

		// Token: 0x0601832C RID: 99116
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunction_SetTwistU_61(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the flag which joins the first triangle strip to
		/// the last one with a twist.
		/// JoinU must also be set if this is set.
		/// Used when building some non-orientable surfaces.
		/// </summary>
		// Token: 0x0601832D RID: 99117 RVA: 0x0021D95B File Offset: 0x0021BB5B
		public virtual void SetTwistU(int _arg)
		{
			vtkParametricFunction.vtkParametricFunction_SetTwistU_61(base.GetCppThis(), _arg);
		}

		// Token: 0x0601832E RID: 99118
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunction_SetTwistV_62(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the flag which joins the ends of the
		/// triangle strips with a twist.
		/// JoinV must also be set if this is set.
		/// Used when building some non-orientable surfaces.
		/// </summary>
		// Token: 0x0601832F RID: 99119 RVA: 0x0021D96B File Offset: 0x0021BB6B
		public virtual void SetTwistV(int _arg)
		{
			vtkParametricFunction.vtkParametricFunction_SetTwistV_62(base.GetCppThis(), _arg);
		}

		// Token: 0x06018330 RID: 99120
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunction_SetTwistW_63(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the flag which joins the ends of the
		/// triangle strips with a twist.
		/// JoinW must also be set if this is set.
		/// Used when building some non-orientable surfaces.
		/// </summary>
		// Token: 0x06018331 RID: 99121 RVA: 0x0021D97B File Offset: 0x0021BB7B
		public virtual void SetTwistW(int _arg)
		{
			vtkParametricFunction.vtkParametricFunction_SetTwistW_63(base.GetCppThis(), _arg);
		}

		// Token: 0x06018332 RID: 99122
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunction_TwistUOff_64(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which joins the first triangle strip to
		/// the last one with a twist.
		/// JoinU must also be set if this is set.
		/// Used when building some non-orientable surfaces.
		/// </summary>
		// Token: 0x06018333 RID: 99123 RVA: 0x0021D98B File Offset: 0x0021BB8B
		public virtual void TwistUOff()
		{
			vtkParametricFunction.vtkParametricFunction_TwistUOff_64(base.GetCppThis());
		}

		// Token: 0x06018334 RID: 99124
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunction_TwistUOn_65(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which joins the first triangle strip to
		/// the last one with a twist.
		/// JoinU must also be set if this is set.
		/// Used when building some non-orientable surfaces.
		/// </summary>
		// Token: 0x06018335 RID: 99125 RVA: 0x0021D99A File Offset: 0x0021BB9A
		public virtual void TwistUOn()
		{
			vtkParametricFunction.vtkParametricFunction_TwistUOn_65(base.GetCppThis());
		}

		// Token: 0x06018336 RID: 99126
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunction_TwistVOff_66(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which joins the ends of the
		/// triangle strips with a twist.
		/// JoinV must also be set if this is set.
		/// Used when building some non-orientable surfaces.
		/// </summary>
		// Token: 0x06018337 RID: 99127 RVA: 0x0021D9A9 File Offset: 0x0021BBA9
		public virtual void TwistVOff()
		{
			vtkParametricFunction.vtkParametricFunction_TwistVOff_66(base.GetCppThis());
		}

		// Token: 0x06018338 RID: 99128
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunction_TwistVOn_67(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which joins the ends of the
		/// triangle strips with a twist.
		/// JoinV must also be set if this is set.
		/// Used when building some non-orientable surfaces.
		/// </summary>
		// Token: 0x06018339 RID: 99129 RVA: 0x0021D9B8 File Offset: 0x0021BBB8
		public virtual void TwistVOn()
		{
			vtkParametricFunction.vtkParametricFunction_TwistVOn_67(base.GetCppThis());
		}

		// Token: 0x0601833A RID: 99130
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunction_TwistWOff_68(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which joins the ends of the
		/// triangle strips with a twist.
		/// JoinW must also be set if this is set.
		/// Used when building some non-orientable surfaces.
		/// </summary>
		// Token: 0x0601833B RID: 99131 RVA: 0x0021D9C7 File Offset: 0x0021BBC7
		public virtual void TwistWOff()
		{
			vtkParametricFunction.vtkParametricFunction_TwistWOff_68(base.GetCppThis());
		}

		// Token: 0x0601833C RID: 99132
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricFunction_TwistWOn_69(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which joins the ends of the
		/// triangle strips with a twist.
		/// JoinW must also be set if this is set.
		/// Used when building some non-orientable surfaces.
		/// </summary>
		// Token: 0x0601833D RID: 99133 RVA: 0x0021D9D6 File Offset: 0x0021BBD6
		public virtual void TwistWOn()
		{
			vtkParametricFunction.vtkParametricFunction_TwistWOn_69(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AE4 RID: 6884
		public new const string MRFullTypeName = "Kitware.VTK.vtkParametricFunction";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AE5 RID: 6885
		public new static readonly string MRClassNameKey = "class vtkParametricFunction";
	}
}
