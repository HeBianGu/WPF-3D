using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkParametricBoy
	/// </summary>
	/// <remarks>
	///    Generate Boy's surface.
	///
	/// vtkParametricBoy generates Boy's surface.
	/// This is a Model of the projective plane without singularities.
	/// It was found by Werner Boy on assignment from David Hilbert.
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
	// Token: 0x02000920 RID: 2336
	public class vtkParametricBoy : vtkParametricFunction
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601837A RID: 99194 RVA: 0x0021DF83 File Offset: 0x0021C183
		static vtkParametricBoy()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParametricBoy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParametricBoy"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601837B RID: 99195 RVA: 0x0021DFAB File Offset: 0x0021C1AB
		public vtkParametricBoy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601837C RID: 99196
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricBoy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct Boy's surface with the following parameters:
		/// MinimumU = 0, MaximumU = Pi,
		/// MinimumV = 0, MaximumV = Pi,
		/// JoinU = 1, JoinV = 1,
		/// TwistU = 1, TwistV = 1;
		/// ClockwiseOrdering = 0,
		/// DerivativesAvailable = 1,
		/// ZScale = 0.125.
		/// </summary>
		// Token: 0x0601837D RID: 99197 RVA: 0x0021DFBC File Offset: 0x0021C1BC
		public new static vtkParametricBoy New()
		{
			vtkParametricBoy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricBoy.vtkParametricBoy_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricBoy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct Boy's surface with the following parameters:
		/// MinimumU = 0, MaximumU = Pi,
		/// MinimumV = 0, MaximumV = Pi,
		/// JoinU = 1, JoinV = 1,
		/// TwistU = 1, TwistV = 1;
		/// ClockwiseOrdering = 0,
		/// DerivativesAvailable = 1,
		/// ZScale = 0.125.
		/// </summary>
		// Token: 0x0601837E RID: 99198 RVA: 0x0021E010 File Offset: 0x0021C210
		public vtkParametricBoy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkParametricBoy.vtkParametricBoy_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601837F RID: 99199 RVA: 0x0021E054 File Offset: 0x0021C254
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06018380 RID: 99200
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricBoy_Evaluate_01(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		/// <summary>
		/// Boy's surface.
		///
		/// This function performs the mapping \f$f(u,v) \rightarrow (x,y,x)\f$, returning it
		/// as Pt. It also returns the partial derivatives Du and Dv.
		/// \f$Pt = (x, y, z), Du = (dx/du, dy/du, dz/du), Dv = (dx/dv, dy/dv, dz/dv)\f$ .
		/// Then the normal is \f$N = Du X Dv\f$ .
		/// </summary>
		// Token: 0x06018381 RID: 99201 RVA: 0x0021E05F File Offset: 0x0021C25F
		public override void Evaluate(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			vtkParametricBoy.vtkParametricBoy_Evaluate_01(base.GetCppThis(), uvw, Pt, Duvw);
		}

		// Token: 0x06018382 RID: 99202
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricBoy_EvaluateScalar_02(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

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
		// Token: 0x06018383 RID: 99203 RVA: 0x0021E074 File Offset: 0x0021C274
		public override double EvaluateScalar(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			return vtkParametricBoy.vtkParametricBoy_EvaluateScalar_02(base.GetCppThis(), uvw, Pt, Duvw);
		}

		// Token: 0x06018384 RID: 99204
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricBoy_GetDimension_03(HandleRef pThis);

		/// <summary>
		/// Return the parametric dimension of the class.
		/// </summary>
		// Token: 0x06018385 RID: 99205 RVA: 0x0021E098 File Offset: 0x0021C298
		public override int GetDimension()
		{
			return vtkParametricBoy.vtkParametricBoy_GetDimension_03(base.GetCppThis());
		}

		// Token: 0x06018386 RID: 99206
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParametricBoy_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018387 RID: 99207 RVA: 0x0021E0B8 File Offset: 0x0021C2B8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkParametricBoy.vtkParametricBoy_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06018388 RID: 99208
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParametricBoy_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018389 RID: 99209 RVA: 0x0021E0D8 File Offset: 0x0021C2D8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkParametricBoy.vtkParametricBoy_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601838A RID: 99210
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricBoy_GetZScale_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the scale factor for the z-coordinate.
		/// Default is 1/8, giving a nice shape.
		/// </summary>
		// Token: 0x0601838B RID: 99211 RVA: 0x0021E0F4 File Offset: 0x0021C2F4
		public virtual double GetZScale()
		{
			return vtkParametricBoy.vtkParametricBoy_GetZScale_06(base.GetCppThis());
		}

		// Token: 0x0601838C RID: 99212
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricBoy_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601838D RID: 99213 RVA: 0x0021E114 File Offset: 0x0021C314
		public override int IsA(string type)
		{
			return vtkParametricBoy.vtkParametricBoy_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601838E RID: 99214
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricBoy_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601838F RID: 99215 RVA: 0x0021E134 File Offset: 0x0021C334
		public new static int IsTypeOf(string type)
		{
			return vtkParametricBoy.vtkParametricBoy_IsTypeOf_08(type);
		}

		// Token: 0x06018390 RID: 99216
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricBoy_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018391 RID: 99217 RVA: 0x0021E150 File Offset: 0x0021C350
		public new vtkParametricBoy NewInstance()
		{
			vtkParametricBoy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricBoy.vtkParametricBoy_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricBoy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06018392 RID: 99218
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricBoy_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018393 RID: 99219 RVA: 0x0021E1AC File Offset: 0x0021C3AC
		public new static vtkParametricBoy SafeDownCast(vtkObjectBase o)
		{
			vtkParametricBoy vtkParametricBoy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricBoy.vtkParametricBoy_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParametricBoy = (vtkParametricBoy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParametricBoy.Register(null);
				}
			}
			return vtkParametricBoy;
		}

		// Token: 0x06018394 RID: 99220
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricBoy_SetZScale_12(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the scale factor for the z-coordinate.
		/// Default is 1/8, giving a nice shape.
		/// </summary>
		// Token: 0x06018395 RID: 99221 RVA: 0x0021E22B File Offset: 0x0021C42B
		public virtual void SetZScale(double _arg)
		{
			vtkParametricBoy.vtkParametricBoy_SetZScale_12(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AEA RID: 6890
		public new const string MRFullTypeName = "Kitware.VTK.vtkParametricBoy";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AEB RID: 6891
		public new static readonly string MRClassNameKey = "class vtkParametricBoy";
	}
}
