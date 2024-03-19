using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkParametricCrossCap
	/// </summary>
	/// <remarks>
	///    Generate a cross-cap.
	///
	/// vtkParametricCrossCap generates a cross-cap which is a
	/// non-orientable self-intersecting single-sided surface.
	/// This is one possible image of a projective plane in three-space.
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
	// Token: 0x02000923 RID: 2339
	public class vtkParametricCrossCap : vtkParametricFunction
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060183D6 RID: 99286 RVA: 0x0021E80B File Offset: 0x0021CA0B
		static vtkParametricCrossCap()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParametricCrossCap.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParametricCrossCap"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060183D7 RID: 99287 RVA: 0x0021E833 File Offset: 0x0021CA33
		public vtkParametricCrossCap(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060183D8 RID: 99288
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricCrossCap_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct a cross-cap with the following parameters:
		/// MinimumU = 0, MaximumU = Pi,
		/// MinimumV = 0, MaximumV = Pi,
		/// JoinU = 1, JoinV = 1,
		/// TwistU = 1, TwistV = 1;
		/// ClockwiseOrdering = 0,
		/// DerivativesAvailable = 1
		/// </summary>
		// Token: 0x060183D9 RID: 99289 RVA: 0x0021E844 File Offset: 0x0021CA44
		public new static vtkParametricCrossCap New()
		{
			vtkParametricCrossCap result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricCrossCap.vtkParametricCrossCap_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricCrossCap)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct a cross-cap with the following parameters:
		/// MinimumU = 0, MaximumU = Pi,
		/// MinimumV = 0, MaximumV = Pi,
		/// JoinU = 1, JoinV = 1,
		/// TwistU = 1, TwistV = 1;
		/// ClockwiseOrdering = 0,
		/// DerivativesAvailable = 1
		/// </summary>
		// Token: 0x060183DA RID: 99290 RVA: 0x0021E898 File Offset: 0x0021CA98
		public vtkParametricCrossCap() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkParametricCrossCap.vtkParametricCrossCap_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060183DB RID: 99291 RVA: 0x0021E8DC File Offset: 0x0021CADC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060183DC RID: 99292
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricCrossCap_Evaluate_01(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		/// <summary>
		/// A cross-cap.
		///
		/// This function performs the mapping \f$f(u,v) \rightarrow (x,y,x)\f$, returning it
		/// as Pt. It also returns the partial derivatives Du and Dv.
		/// \f$Pt = (x, y, z), Du = (dx/du, dy/du, dz/du), Dv = (dx/dv, dy/dv, dz/dv)\f$ .
		/// Then the normal is \f$N = Du X Dv\f$ .
		/// </summary>
		// Token: 0x060183DD RID: 99293 RVA: 0x0021E8E7 File Offset: 0x0021CAE7
		public override void Evaluate(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			vtkParametricCrossCap.vtkParametricCrossCap_Evaluate_01(base.GetCppThis(), uvw, Pt, Duvw);
		}

		// Token: 0x060183DE RID: 99294
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricCrossCap_EvaluateScalar_02(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

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
		// Token: 0x060183DF RID: 99295 RVA: 0x0021E8FC File Offset: 0x0021CAFC
		public override double EvaluateScalar(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			return vtkParametricCrossCap.vtkParametricCrossCap_EvaluateScalar_02(base.GetCppThis(), uvw, Pt, Duvw);
		}

		// Token: 0x060183E0 RID: 99296
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricCrossCap_GetDimension_03(HandleRef pThis);

		/// <summary>
		/// Return the parametric dimension of the class.
		/// </summary>
		// Token: 0x060183E1 RID: 99297 RVA: 0x0021E920 File Offset: 0x0021CB20
		public override int GetDimension()
		{
			return vtkParametricCrossCap.vtkParametricCrossCap_GetDimension_03(base.GetCppThis());
		}

		// Token: 0x060183E2 RID: 99298
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParametricCrossCap_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060183E3 RID: 99299 RVA: 0x0021E940 File Offset: 0x0021CB40
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkParametricCrossCap.vtkParametricCrossCap_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x060183E4 RID: 99300
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParametricCrossCap_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060183E5 RID: 99301 RVA: 0x0021E960 File Offset: 0x0021CB60
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkParametricCrossCap.vtkParametricCrossCap_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x060183E6 RID: 99302
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricCrossCap_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060183E7 RID: 99303 RVA: 0x0021E97C File Offset: 0x0021CB7C
		public override int IsA(string type)
		{
			return vtkParametricCrossCap.vtkParametricCrossCap_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x060183E8 RID: 99304
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricCrossCap_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060183E9 RID: 99305 RVA: 0x0021E99C File Offset: 0x0021CB9C
		public new static int IsTypeOf(string type)
		{
			return vtkParametricCrossCap.vtkParametricCrossCap_IsTypeOf_07(type);
		}

		// Token: 0x060183EA RID: 99306
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricCrossCap_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060183EB RID: 99307 RVA: 0x0021E9B8 File Offset: 0x0021CBB8
		public new vtkParametricCrossCap NewInstance()
		{
			vtkParametricCrossCap result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricCrossCap.vtkParametricCrossCap_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricCrossCap)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060183EC RID: 99308
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricCrossCap_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060183ED RID: 99309 RVA: 0x0021EA14 File Offset: 0x0021CC14
		public new static vtkParametricCrossCap SafeDownCast(vtkObjectBase o)
		{
			vtkParametricCrossCap vtkParametricCrossCap = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricCrossCap.vtkParametricCrossCap_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParametricCrossCap = (vtkParametricCrossCap)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParametricCrossCap.Register(null);
				}
			}
			return vtkParametricCrossCap;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AF0 RID: 6896
		public new const string MRFullTypeName = "Kitware.VTK.vtkParametricCrossCap";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AF1 RID: 6897
		public new static readonly string MRClassNameKey = "class vtkParametricCrossCap";
	}
}
