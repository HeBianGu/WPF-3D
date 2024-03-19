using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkParametricBour
	/// </summary>
	/// <remarks>
	///    Generate Bour's minimal surface.
	///
	/// vtkParametricBour generates Bour's minimal surface parametrically. More
	/// information can be found at
	/// &lt;a href="http://en.wikipedia.org/wiki/Bour%27s_minimal_surface"&gt;Wikipedia&lt;/a&gt;.
	/// @par Thanks:
	/// Tim Meehan
	/// </remarks>
	// Token: 0x0200091F RID: 2335
	public class vtkParametricBour : vtkParametricFunction
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06018362 RID: 99170 RVA: 0x0021DCFB File Offset: 0x0021BEFB
		static vtkParametricBour()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParametricBour.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParametricBour"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06018363 RID: 99171 RVA: 0x0021DD23 File Offset: 0x0021BF23
		public vtkParametricBour(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06018364 RID: 99172
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricBour_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct Bour's minimal surface with the following parameters:
		/// (MinimumU, MaximumU) = (0., 1.),
		/// (MinimumV, MaximumV) = (0., 4.*pi),
		/// JoinU = 0, JoinV = 0,
		/// TwistU = 0, TwistV = 0;
		/// ClockwiseOrdering = 0,
		/// DerivativesAvailable = 1,
		/// </summary>
		// Token: 0x06018365 RID: 99173 RVA: 0x0021DD34 File Offset: 0x0021BF34
		public new static vtkParametricBour New()
		{
			vtkParametricBour result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricBour.vtkParametricBour_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricBour)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct Bour's minimal surface with the following parameters:
		/// (MinimumU, MaximumU) = (0., 1.),
		/// (MinimumV, MaximumV) = (0., 4.*pi),
		/// JoinU = 0, JoinV = 0,
		/// TwistU = 0, TwistV = 0;
		/// ClockwiseOrdering = 0,
		/// DerivativesAvailable = 1,
		/// </summary>
		// Token: 0x06018366 RID: 99174 RVA: 0x0021DD88 File Offset: 0x0021BF88
		public vtkParametricBour() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkParametricBour.vtkParametricBour_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06018367 RID: 99175 RVA: 0x0021DDCC File Offset: 0x0021BFCC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06018368 RID: 99176
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricBour_Evaluate_01(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		/// <summary>
		/// Bour's minimal surface.
		///
		/// This function performs the mapping \f$f(u,v) \rightarrow (x,y,x)\f$, returning it
		/// as Pt. It also returns the partial derivatives Du and Dv.
		/// \f$Pt = (x, y, z), D_u\vec{f} = (dx/du, dy/du, dz/du), D_v\vec{f} = (dx/dv, dy/dv, dz/dv)\f$ .
		/// Then the normal is \f$N = D_u\vec{f} \times D_v\vec{f}\f$ .
		/// </summary>
		// Token: 0x06018369 RID: 99177 RVA: 0x0021DDD7 File Offset: 0x0021BFD7
		public override void Evaluate(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			vtkParametricBour.vtkParametricBour_Evaluate_01(base.GetCppThis(), uvw, Pt, Duvw);
		}

		// Token: 0x0601836A RID: 99178
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricBour_EvaluateScalar_02(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		/// <summary>
		/// Calculate a user defined scalar using one or all of uvw, Pt, Duvw.
		/// This method simply returns 0.
		/// </summary>
		// Token: 0x0601836B RID: 99179 RVA: 0x0021DDEC File Offset: 0x0021BFEC
		public override double EvaluateScalar(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			return vtkParametricBour.vtkParametricBour_EvaluateScalar_02(base.GetCppThis(), uvw, Pt, Duvw);
		}

		// Token: 0x0601836C RID: 99180
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricBour_GetDimension_03(HandleRef pThis);

		/// <summary>
		/// Return the parametric dimension of the class.
		/// </summary>
		// Token: 0x0601836D RID: 99181 RVA: 0x0021DE10 File Offset: 0x0021C010
		public override int GetDimension()
		{
			return vtkParametricBour.vtkParametricBour_GetDimension_03(base.GetCppThis());
		}

		// Token: 0x0601836E RID: 99182
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParametricBour_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601836F RID: 99183 RVA: 0x0021DE30 File Offset: 0x0021C030
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkParametricBour.vtkParametricBour_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06018370 RID: 99184
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParametricBour_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018371 RID: 99185 RVA: 0x0021DE50 File Offset: 0x0021C050
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkParametricBour.vtkParametricBour_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06018372 RID: 99186
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricBour_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018373 RID: 99187 RVA: 0x0021DE6C File Offset: 0x0021C06C
		public override int IsA(string type)
		{
			return vtkParametricBour.vtkParametricBour_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06018374 RID: 99188
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricBour_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018375 RID: 99189 RVA: 0x0021DE8C File Offset: 0x0021C08C
		public new static int IsTypeOf(string type)
		{
			return vtkParametricBour.vtkParametricBour_IsTypeOf_07(type);
		}

		// Token: 0x06018376 RID: 99190
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricBour_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018377 RID: 99191 RVA: 0x0021DEA8 File Offset: 0x0021C0A8
		public new vtkParametricBour NewInstance()
		{
			vtkParametricBour result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricBour.vtkParametricBour_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricBour)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06018378 RID: 99192
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricBour_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018379 RID: 99193 RVA: 0x0021DF04 File Offset: 0x0021C104
		public new static vtkParametricBour SafeDownCast(vtkObjectBase o)
		{
			vtkParametricBour vtkParametricBour = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricBour.vtkParametricBour_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParametricBour = (vtkParametricBour)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParametricBour.Register(null);
				}
			}
			return vtkParametricBour;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AE8 RID: 6888
		public new const string MRFullTypeName = "Kitware.VTK.vtkParametricBour";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AE9 RID: 6889
		public new static readonly string MRClassNameKey = "class vtkParametricBour";
	}
}
