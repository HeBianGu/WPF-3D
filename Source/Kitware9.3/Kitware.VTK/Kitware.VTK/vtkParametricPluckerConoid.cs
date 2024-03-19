using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkParametricPluckerConoid
	/// </summary>
	/// <remarks>
	///    Generate Plucker's conoid surface.
	///
	/// vtkParametricPluckerConoid generates Plucker's conoid surface parametrically.
	/// Plucker's conoid is a ruled surface, named after Julius Plucker. It is
	/// possible to set the number of folds in this class via the parameter 'N'.
	///
	/// For more information, see the Wikipedia page on
	/// &lt;a href="https://en.wikipedia.org/wiki/Pl%c3%bccker%27s_conoid"&gt;Plucker's Conoid&lt;/a&gt;.
	/// @warning
	/// I haven't done any special checking on the number of folds parameter, N.
	/// @par Thanks:
	/// Tim Meehan
	/// </remarks>
	// Token: 0x0200092C RID: 2348
	public class vtkParametricPluckerConoid : vtkParametricFunction
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060184CE RID: 99534 RVA: 0x00220053 File Offset: 0x0021E253
		static vtkParametricPluckerConoid()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParametricPluckerConoid.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParametricPluckerConoid"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060184CF RID: 99535 RVA: 0x0022007B File Offset: 0x0021E27B
		public vtkParametricPluckerConoid(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060184D0 RID: 99536
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricPluckerConoid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct Plucker's conoid surface with the following parameters:
		/// (MinimumU, MaximumU) = (0., 3.),
		/// (MinimumV, MaximumV) = (0., 2*pi),
		/// JoinU = 0, JoinV = 0,
		/// TwistU = 0, TwistV = 0;
		/// ClockwiseOrdering = 0,
		/// DerivativesAvailable = 1,
		/// </summary>
		// Token: 0x060184D1 RID: 99537 RVA: 0x0022008C File Offset: 0x0021E28C
		public new static vtkParametricPluckerConoid New()
		{
			vtkParametricPluckerConoid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricPluckerConoid.vtkParametricPluckerConoid_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricPluckerConoid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct Plucker's conoid surface with the following parameters:
		/// (MinimumU, MaximumU) = (0., 3.),
		/// (MinimumV, MaximumV) = (0., 2*pi),
		/// JoinU = 0, JoinV = 0,
		/// TwistU = 0, TwistV = 0;
		/// ClockwiseOrdering = 0,
		/// DerivativesAvailable = 1,
		/// </summary>
		// Token: 0x060184D2 RID: 99538 RVA: 0x002200E0 File Offset: 0x0021E2E0
		public vtkParametricPluckerConoid() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkParametricPluckerConoid.vtkParametricPluckerConoid_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060184D3 RID: 99539 RVA: 0x00220124 File Offset: 0x0021E324
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060184D4 RID: 99540
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricPluckerConoid_Evaluate_01(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		/// <summary>
		/// Plucker's conoid surface.
		///
		/// This function performs the mapping \f$f(u,v) \rightarrow (x,y,x)\f$, returning it
		/// as Pt. It also returns the partial derivatives Du and Dv.
		/// \f$Pt = (x, y, z), D_u\vec{f} = (dx/du, dy/du, dz/du), D_v\vec{f} = (dx/dv, dy/dv, dz/dv)\f$ .
		/// Then the normal is \f$N = D_u\vec{f} \times D_v\vec{f}\f$ .
		/// </summary>
		// Token: 0x060184D5 RID: 99541 RVA: 0x0022012F File Offset: 0x0021E32F
		public override void Evaluate(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			vtkParametricPluckerConoid.vtkParametricPluckerConoid_Evaluate_01(base.GetCppThis(), uvw, Pt, Duvw);
		}

		// Token: 0x060184D6 RID: 99542
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricPluckerConoid_EvaluateScalar_02(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		/// <summary>
		/// Calculate a user defined scalar using one or all of uvw, Pt, Duvw.
		/// This method simply returns 0.
		/// </summary>
		// Token: 0x060184D7 RID: 99543 RVA: 0x00220144 File Offset: 0x0021E344
		public override double EvaluateScalar(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			return vtkParametricPluckerConoid.vtkParametricPluckerConoid_EvaluateScalar_02(base.GetCppThis(), uvw, Pt, Duvw);
		}

		// Token: 0x060184D8 RID: 99544
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricPluckerConoid_GetDimension_03(HandleRef pThis);

		/// <summary>
		/// Return the parametric dimension of the class.
		/// </summary>
		// Token: 0x060184D9 RID: 99545 RVA: 0x00220168 File Offset: 0x0021E368
		public override int GetDimension()
		{
			return vtkParametricPluckerConoid.vtkParametricPluckerConoid_GetDimension_03(base.GetCppThis());
		}

		// Token: 0x060184DA RID: 99546
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricPluckerConoid_GetN_04(HandleRef pThis);

		/// <summary>
		/// This is the number of folds in the conoid.
		/// </summary>
		// Token: 0x060184DB RID: 99547 RVA: 0x00220188 File Offset: 0x0021E388
		public virtual int GetN()
		{
			return vtkParametricPluckerConoid.vtkParametricPluckerConoid_GetN_04(base.GetCppThis());
		}

		// Token: 0x060184DC RID: 99548
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParametricPluckerConoid_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060184DD RID: 99549 RVA: 0x002201A8 File Offset: 0x0021E3A8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkParametricPluckerConoid.vtkParametricPluckerConoid_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x060184DE RID: 99550
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParametricPluckerConoid_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060184DF RID: 99551 RVA: 0x002201C8 File Offset: 0x0021E3C8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkParametricPluckerConoid.vtkParametricPluckerConoid_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x060184E0 RID: 99552
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricPluckerConoid_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060184E1 RID: 99553 RVA: 0x002201E4 File Offset: 0x0021E3E4
		public override int IsA(string type)
		{
			return vtkParametricPluckerConoid.vtkParametricPluckerConoid_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x060184E2 RID: 99554
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricPluckerConoid_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060184E3 RID: 99555 RVA: 0x00220204 File Offset: 0x0021E404
		public new static int IsTypeOf(string type)
		{
			return vtkParametricPluckerConoid.vtkParametricPluckerConoid_IsTypeOf_08(type);
		}

		// Token: 0x060184E4 RID: 99556
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricPluckerConoid_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060184E5 RID: 99557 RVA: 0x00220220 File Offset: 0x0021E420
		public new vtkParametricPluckerConoid NewInstance()
		{
			vtkParametricPluckerConoid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricPluckerConoid.vtkParametricPluckerConoid_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricPluckerConoid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060184E6 RID: 99558
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricPluckerConoid_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060184E7 RID: 99559 RVA: 0x0022027C File Offset: 0x0021E47C
		public new static vtkParametricPluckerConoid SafeDownCast(vtkObjectBase o)
		{
			vtkParametricPluckerConoid vtkParametricPluckerConoid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricPluckerConoid.vtkParametricPluckerConoid_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParametricPluckerConoid = (vtkParametricPluckerConoid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParametricPluckerConoid.Register(null);
				}
			}
			return vtkParametricPluckerConoid;
		}

		// Token: 0x060184E8 RID: 99560
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricPluckerConoid_SetN_12(HandleRef pThis, int _arg);

		/// <summary>
		/// This is the number of folds in the conoid.
		/// </summary>
		// Token: 0x060184E9 RID: 99561 RVA: 0x002202FB File Offset: 0x0021E4FB
		public virtual void SetN(int _arg)
		{
			vtkParametricPluckerConoid.vtkParametricPluckerConoid_SetN_12(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B02 RID: 6914
		public new const string MRFullTypeName = "Kitware.VTK.vtkParametricPluckerConoid";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B03 RID: 6915
		public new static readonly string MRClassNameKey = "class vtkParametricPluckerConoid";
	}
}
