using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkParametricSuperToroid
	/// </summary>
	/// <remarks>
	///    Generate a supertoroid.
	///
	/// vtkParametricSuperToroid generates a supertoroid.  Essentially a
	/// supertoroid is a torus with the sine and cosine terms raised to a power.
	/// A supertoroid is a versatile primitive that is controlled by four
	/// parameters r0, r1, n1 and n2. r0, r1 determine the type of torus whilst
	/// the value of n1 determines the shape of the torus ring and n2 determines
	/// the shape of the cross section of the ring. It is the different values of
	/// these powers which give rise to a family of 3D shapes that are all
	/// basically toroidal in shape.
	///
	/// For further information about this surface, please consult the
	/// technical description "Parametric surfaces" in http://www.vtk.org/publications
	/// in the "VTK Technical Documents" section in the VTk.org web pages.
	///
	/// Also see: http://paulbourke.net/geometry/torus/#super.
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
	// Token: 0x02000932 RID: 2354
	public class vtkParametricSuperToroid : vtkParametricFunction
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060185E2 RID: 99810 RVA: 0x0022175B File Offset: 0x0021F95B
		static vtkParametricSuperToroid()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParametricSuperToroid.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParametricSuperToroid"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060185E3 RID: 99811 RVA: 0x00221783 File Offset: 0x0021F983
		public vtkParametricSuperToroid(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060185E4 RID: 99812
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricSuperToroid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct a supertoroid with the following parameters:
		/// MinimumU = 0, MaximumU = 2*Pi,
		/// MinimumV = 0, MaximumV = 2*Pi,
		/// JoinU = 0, JoinV = 0,
		/// TwistU = 0, TwistV = 0,
		/// ClockwiseOrdering = 1,
		/// DerivativesAvailable = 0,
		/// RingRadius = 1, CrossSectionRadius = 0.5,
		/// N1 = 1, N2 = 1, XRadius = 1,
		/// YRadius = 1, ZRadius = 1, a torus in this case.
		/// </summary>
		// Token: 0x060185E5 RID: 99813 RVA: 0x00221794 File Offset: 0x0021F994
		public new static vtkParametricSuperToroid New()
		{
			vtkParametricSuperToroid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricSuperToroid.vtkParametricSuperToroid_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricSuperToroid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct a supertoroid with the following parameters:
		/// MinimumU = 0, MaximumU = 2*Pi,
		/// MinimumV = 0, MaximumV = 2*Pi,
		/// JoinU = 0, JoinV = 0,
		/// TwistU = 0, TwistV = 0,
		/// ClockwiseOrdering = 1,
		/// DerivativesAvailable = 0,
		/// RingRadius = 1, CrossSectionRadius = 0.5,
		/// N1 = 1, N2 = 1, XRadius = 1,
		/// YRadius = 1, ZRadius = 1, a torus in this case.
		/// </summary>
		// Token: 0x060185E6 RID: 99814 RVA: 0x002217E8 File Offset: 0x0021F9E8
		public vtkParametricSuperToroid() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkParametricSuperToroid.vtkParametricSuperToroid_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060185E7 RID: 99815 RVA: 0x0022182C File Offset: 0x0021FA2C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060185E8 RID: 99816
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricSuperToroid_Evaluate_01(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		/// <summary>
		/// A supertoroid.
		///
		/// This function performs the mapping \f$f(u,v) \rightarrow (x,y,x)\f$, returning it
		/// as Pt. It also returns the partial derivatives Du and Dv.
		/// \f$Pt = (x, y, z), Du = (dx/du, dy/du, dz/du), Dv = (dx/dv, dy/dv, dz/dv)\f$ .
		/// Then the normal is \f$N = Du X Dv\f$ .
		/// </summary>
		// Token: 0x060185E9 RID: 99817 RVA: 0x00221837 File Offset: 0x0021FA37
		public override void Evaluate(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			vtkParametricSuperToroid.vtkParametricSuperToroid_Evaluate_01(base.GetCppThis(), uvw, Pt, Duvw);
		}

		// Token: 0x060185EA RID: 99818
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricSuperToroid_EvaluateScalar_02(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

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
		// Token: 0x060185EB RID: 99819 RVA: 0x0022184C File Offset: 0x0021FA4C
		public override double EvaluateScalar(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			return vtkParametricSuperToroid.vtkParametricSuperToroid_EvaluateScalar_02(base.GetCppThis(), uvw, Pt, Duvw);
		}

		// Token: 0x060185EC RID: 99820
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricSuperToroid_GetCrossSectionRadius_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the radius of the cross section of ring of the supertoroid.
		/// Default = 0.5.
		/// </summary>
		// Token: 0x060185ED RID: 99821 RVA: 0x00221870 File Offset: 0x0021FA70
		public virtual double GetCrossSectionRadius()
		{
			return vtkParametricSuperToroid.vtkParametricSuperToroid_GetCrossSectionRadius_03(base.GetCppThis());
		}

		// Token: 0x060185EE RID: 99822
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricSuperToroid_GetDimension_04(HandleRef pThis);

		/// <summary>
		/// Return the parametric dimension of the class.
		/// </summary>
		// Token: 0x060185EF RID: 99823 RVA: 0x00221890 File Offset: 0x0021FA90
		public override int GetDimension()
		{
			return vtkParametricSuperToroid.vtkParametricSuperToroid_GetDimension_04(base.GetCppThis());
		}

		// Token: 0x060185F0 RID: 99824
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricSuperToroid_GetN1_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the shape of the torus ring.  Default is 1.
		/// </summary>
		// Token: 0x060185F1 RID: 99825 RVA: 0x002218B0 File Offset: 0x0021FAB0
		public virtual double GetN1()
		{
			return vtkParametricSuperToroid.vtkParametricSuperToroid_GetN1_05(base.GetCppThis());
		}

		// Token: 0x060185F2 RID: 99826
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricSuperToroid_GetN2_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the shape of the cross section of the ring. Default is 1.
		/// </summary>
		// Token: 0x060185F3 RID: 99827 RVA: 0x002218D0 File Offset: 0x0021FAD0
		public virtual double GetN2()
		{
			return vtkParametricSuperToroid.vtkParametricSuperToroid_GetN2_06(base.GetCppThis());
		}

		// Token: 0x060185F4 RID: 99828
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParametricSuperToroid_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060185F5 RID: 99829 RVA: 0x002218F0 File Offset: 0x0021FAF0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkParametricSuperToroid.vtkParametricSuperToroid_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x060185F6 RID: 99830
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParametricSuperToroid_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060185F7 RID: 99831 RVA: 0x00221910 File Offset: 0x0021FB10
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkParametricSuperToroid.vtkParametricSuperToroid_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x060185F8 RID: 99832
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricSuperToroid_GetRingRadius_09(HandleRef pThis);

		/// <summary>
		/// Set/Get the radius from the center to the middle of the ring of the
		/// supertoroid. Default is 1.
		/// </summary>
		// Token: 0x060185F9 RID: 99833 RVA: 0x0022192C File Offset: 0x0021FB2C
		public virtual double GetRingRadius()
		{
			return vtkParametricSuperToroid.vtkParametricSuperToroid_GetRingRadius_09(base.GetCppThis());
		}

		// Token: 0x060185FA RID: 99834
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricSuperToroid_GetXRadius_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the scaling factor for the x-axis. Default is 1.
		/// </summary>
		// Token: 0x060185FB RID: 99835 RVA: 0x0022194C File Offset: 0x0021FB4C
		public virtual double GetXRadius()
		{
			return vtkParametricSuperToroid.vtkParametricSuperToroid_GetXRadius_10(base.GetCppThis());
		}

		// Token: 0x060185FC RID: 99836
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricSuperToroid_GetYRadius_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the scaling factor for the y-axis. Default is 1.
		/// </summary>
		// Token: 0x060185FD RID: 99837 RVA: 0x0022196C File Offset: 0x0021FB6C
		public virtual double GetYRadius()
		{
			return vtkParametricSuperToroid.vtkParametricSuperToroid_GetYRadius_11(base.GetCppThis());
		}

		// Token: 0x060185FE RID: 99838
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricSuperToroid_GetZRadius_12(HandleRef pThis);

		/// <summary>
		/// Set/Get the scaling factor for the z-axis. Default is 1.
		/// </summary>
		// Token: 0x060185FF RID: 99839 RVA: 0x0022198C File Offset: 0x0021FB8C
		public virtual double GetZRadius()
		{
			return vtkParametricSuperToroid.vtkParametricSuperToroid_GetZRadius_12(base.GetCppThis());
		}

		// Token: 0x06018600 RID: 99840
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricSuperToroid_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018601 RID: 99841 RVA: 0x002219AC File Offset: 0x0021FBAC
		public override int IsA(string type)
		{
			return vtkParametricSuperToroid.vtkParametricSuperToroid_IsA_13(base.GetCppThis(), type);
		}

		// Token: 0x06018602 RID: 99842
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricSuperToroid_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018603 RID: 99843 RVA: 0x002219CC File Offset: 0x0021FBCC
		public new static int IsTypeOf(string type)
		{
			return vtkParametricSuperToroid.vtkParametricSuperToroid_IsTypeOf_14(type);
		}

		// Token: 0x06018604 RID: 99844
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricSuperToroid_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018605 RID: 99845 RVA: 0x002219E8 File Offset: 0x0021FBE8
		public new vtkParametricSuperToroid NewInstance()
		{
			vtkParametricSuperToroid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricSuperToroid.vtkParametricSuperToroid_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricSuperToroid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06018606 RID: 99846
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricSuperToroid_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018607 RID: 99847 RVA: 0x00221A44 File Offset: 0x0021FC44
		public new static vtkParametricSuperToroid SafeDownCast(vtkObjectBase o)
		{
			vtkParametricSuperToroid vtkParametricSuperToroid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricSuperToroid.vtkParametricSuperToroid_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParametricSuperToroid = (vtkParametricSuperToroid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParametricSuperToroid.Register(null);
				}
			}
			return vtkParametricSuperToroid;
		}

		// Token: 0x06018608 RID: 99848
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricSuperToroid_SetCrossSectionRadius_18(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the radius of the cross section of ring of the supertoroid.
		/// Default = 0.5.
		/// </summary>
		// Token: 0x06018609 RID: 99849 RVA: 0x00221AC3 File Offset: 0x0021FCC3
		public virtual void SetCrossSectionRadius(double _arg)
		{
			vtkParametricSuperToroid.vtkParametricSuperToroid_SetCrossSectionRadius_18(base.GetCppThis(), _arg);
		}

		// Token: 0x0601860A RID: 99850
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricSuperToroid_SetN1_19(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the shape of the torus ring.  Default is 1.
		/// </summary>
		// Token: 0x0601860B RID: 99851 RVA: 0x00221AD3 File Offset: 0x0021FCD3
		public virtual void SetN1(double _arg)
		{
			vtkParametricSuperToroid.vtkParametricSuperToroid_SetN1_19(base.GetCppThis(), _arg);
		}

		// Token: 0x0601860C RID: 99852
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricSuperToroid_SetN2_20(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the shape of the cross section of the ring. Default is 1.
		/// </summary>
		// Token: 0x0601860D RID: 99853 RVA: 0x00221AE3 File Offset: 0x0021FCE3
		public virtual void SetN2(double _arg)
		{
			vtkParametricSuperToroid.vtkParametricSuperToroid_SetN2_20(base.GetCppThis(), _arg);
		}

		// Token: 0x0601860E RID: 99854
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricSuperToroid_SetRingRadius_21(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the radius from the center to the middle of the ring of the
		/// supertoroid. Default is 1.
		/// </summary>
		// Token: 0x0601860F RID: 99855 RVA: 0x00221AF3 File Offset: 0x0021FCF3
		public virtual void SetRingRadius(double _arg)
		{
			vtkParametricSuperToroid.vtkParametricSuperToroid_SetRingRadius_21(base.GetCppThis(), _arg);
		}

		// Token: 0x06018610 RID: 99856
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricSuperToroid_SetXRadius_22(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the scaling factor for the x-axis. Default is 1.
		/// </summary>
		// Token: 0x06018611 RID: 99857 RVA: 0x00221B03 File Offset: 0x0021FD03
		public virtual void SetXRadius(double _arg)
		{
			vtkParametricSuperToroid.vtkParametricSuperToroid_SetXRadius_22(base.GetCppThis(), _arg);
		}

		// Token: 0x06018612 RID: 99858
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricSuperToroid_SetYRadius_23(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the scaling factor for the y-axis. Default is 1.
		/// </summary>
		// Token: 0x06018613 RID: 99859 RVA: 0x00221B13 File Offset: 0x0021FD13
		public virtual void SetYRadius(double _arg)
		{
			vtkParametricSuperToroid.vtkParametricSuperToroid_SetYRadius_23(base.GetCppThis(), _arg);
		}

		// Token: 0x06018614 RID: 99860
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricSuperToroid_SetZRadius_24(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the scaling factor for the z-axis. Default is 1.
		/// </summary>
		// Token: 0x06018615 RID: 99861 RVA: 0x00221B23 File Offset: 0x0021FD23
		public virtual void SetZRadius(double _arg)
		{
			vtkParametricSuperToroid.vtkParametricSuperToroid_SetZRadius_24(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B0E RID: 6926
		public new const string MRFullTypeName = "Kitware.VTK.vtkParametricSuperToroid";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B0F RID: 6927
		public new static readonly string MRClassNameKey = "class vtkParametricSuperToroid";
	}
}
