using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkParametricCatalanMinimal
	/// </summary>
	/// <remarks>
	///    Generate Catalan's minimal surface.
	///
	/// vtkParametricCatalanMinimal generates Catalan's minimal surface
	/// parametrically. This minimal surface contains the cycloid as a geodesic.
	/// More information about it can be found at
	/// &lt;a href="https://en.wikipedia.org/wiki/Catalan%27s_minimal_surface"&gt;Wikipedia&lt;/a&gt;.
	/// @par Thanks:
	/// Tim Meehan
	/// </remarks>
	// Token: 0x02000921 RID: 2337
	public class vtkParametricCatalanMinimal : vtkParametricFunction
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06018396 RID: 99222 RVA: 0x0021E23B File Offset: 0x0021C43B
		static vtkParametricCatalanMinimal()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParametricCatalanMinimal.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParametricCatalanMinimal"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06018397 RID: 99223 RVA: 0x0021E263 File Offset: 0x0021C463
		public vtkParametricCatalanMinimal(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06018398 RID: 99224
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricCatalanMinimal_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct Catalan's minimal surface with the following parameters:
		/// (MinimumU, MaximumU) = (-4.*pi, 4.*pi),
		/// (MinimumV, MaximumV) = (-1.5, 1.5),
		/// JoinU = 0, JoinV = 0,
		/// TwistU = 0, TwistV = 0;
		/// ClockwiseOrdering = 0,
		/// DerivativesAvailable = 1,
		/// </summary>
		// Token: 0x06018399 RID: 99225 RVA: 0x0021E274 File Offset: 0x0021C474
		public new static vtkParametricCatalanMinimal New()
		{
			vtkParametricCatalanMinimal result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricCatalanMinimal.vtkParametricCatalanMinimal_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricCatalanMinimal)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct Catalan's minimal surface with the following parameters:
		/// (MinimumU, MaximumU) = (-4.*pi, 4.*pi),
		/// (MinimumV, MaximumV) = (-1.5, 1.5),
		/// JoinU = 0, JoinV = 0,
		/// TwistU = 0, TwistV = 0;
		/// ClockwiseOrdering = 0,
		/// DerivativesAvailable = 1,
		/// </summary>
		// Token: 0x0601839A RID: 99226 RVA: 0x0021E2C8 File Offset: 0x0021C4C8
		public vtkParametricCatalanMinimal() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkParametricCatalanMinimal.vtkParametricCatalanMinimal_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601839B RID: 99227 RVA: 0x0021E30C File Offset: 0x0021C50C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601839C RID: 99228
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricCatalanMinimal_Evaluate_01(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		/// <summary>
		/// Catalan's minimal surface.
		///
		/// This function performs the mapping \f$f(u,v) \rightarrow (x,y,x)\f$, returning it
		/// as Pt. It also returns the partial derivatives Du and Dv.
		/// \f$Pt = (x, y, z), D_u\vec{f} = (dx/du, dy/du, dz/du), D_v\vec{f} = (dx/dv, dy/dv, dz/dv)\f$ .
		/// Then the normal is \f$N = D_u\vec{f} \times D_v\vec{f}\f$ .
		/// </summary>
		// Token: 0x0601839D RID: 99229 RVA: 0x0021E317 File Offset: 0x0021C517
		public override void Evaluate(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			vtkParametricCatalanMinimal.vtkParametricCatalanMinimal_Evaluate_01(base.GetCppThis(), uvw, Pt, Duvw);
		}

		// Token: 0x0601839E RID: 99230
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricCatalanMinimal_EvaluateScalar_02(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		/// <summary>
		/// Calculate a user defined scalar using one or all of uvw, Pt, Duvw.
		/// This method simply returns 0.
		/// </summary>
		// Token: 0x0601839F RID: 99231 RVA: 0x0021E32C File Offset: 0x0021C52C
		public override double EvaluateScalar(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			return vtkParametricCatalanMinimal.vtkParametricCatalanMinimal_EvaluateScalar_02(base.GetCppThis(), uvw, Pt, Duvw);
		}

		// Token: 0x060183A0 RID: 99232
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricCatalanMinimal_GetDimension_03(HandleRef pThis);

		/// <summary>
		/// Return the parametric dimension of the class.
		/// </summary>
		// Token: 0x060183A1 RID: 99233 RVA: 0x0021E350 File Offset: 0x0021C550
		public override int GetDimension()
		{
			return vtkParametricCatalanMinimal.vtkParametricCatalanMinimal_GetDimension_03(base.GetCppThis());
		}

		// Token: 0x060183A2 RID: 99234
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParametricCatalanMinimal_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060183A3 RID: 99235 RVA: 0x0021E370 File Offset: 0x0021C570
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkParametricCatalanMinimal.vtkParametricCatalanMinimal_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x060183A4 RID: 99236
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParametricCatalanMinimal_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060183A5 RID: 99237 RVA: 0x0021E390 File Offset: 0x0021C590
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkParametricCatalanMinimal.vtkParametricCatalanMinimal_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x060183A6 RID: 99238
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricCatalanMinimal_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060183A7 RID: 99239 RVA: 0x0021E3AC File Offset: 0x0021C5AC
		public override int IsA(string type)
		{
			return vtkParametricCatalanMinimal.vtkParametricCatalanMinimal_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x060183A8 RID: 99240
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricCatalanMinimal_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060183A9 RID: 99241 RVA: 0x0021E3CC File Offset: 0x0021C5CC
		public new static int IsTypeOf(string type)
		{
			return vtkParametricCatalanMinimal.vtkParametricCatalanMinimal_IsTypeOf_07(type);
		}

		// Token: 0x060183AA RID: 99242
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricCatalanMinimal_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060183AB RID: 99243 RVA: 0x0021E3E8 File Offset: 0x0021C5E8
		public new vtkParametricCatalanMinimal NewInstance()
		{
			vtkParametricCatalanMinimal result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricCatalanMinimal.vtkParametricCatalanMinimal_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricCatalanMinimal)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060183AC RID: 99244
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricCatalanMinimal_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060183AD RID: 99245 RVA: 0x0021E444 File Offset: 0x0021C644
		public new static vtkParametricCatalanMinimal SafeDownCast(vtkObjectBase o)
		{
			vtkParametricCatalanMinimal vtkParametricCatalanMinimal = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricCatalanMinimal.vtkParametricCatalanMinimal_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParametricCatalanMinimal = (vtkParametricCatalanMinimal)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParametricCatalanMinimal.Register(null);
				}
			}
			return vtkParametricCatalanMinimal;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AEC RID: 6892
		public new const string MRFullTypeName = "Kitware.VTK.vtkParametricCatalanMinimal";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AED RID: 6893
		public new static readonly string MRClassNameKey = "class vtkParametricCatalanMinimal";
	}
}
