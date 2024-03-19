using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkParametricHenneberg
	/// </summary>
	/// <remarks>
	///    Generate Henneberg's minimal surface.
	///
	/// vtkParametricHenneberg generates Henneberg's minimal surface parametrically.
	/// Henneberg's minimal surface is discussed further at
	/// &lt;a href="http://mathworld.wolfram.com/HennebergsMinimalSurface.html"&gt;Math World&lt;/a&gt;.
	/// @par Thanks:
	/// Tim Meehan
	/// </remarks>
	// Token: 0x02000928 RID: 2344
	public class vtkParametricHenneberg : vtkParametricFunction
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06018466 RID: 99430 RVA: 0x0021F5D3 File Offset: 0x0021D7D3
		static vtkParametricHenneberg()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParametricHenneberg.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParametricHenneberg"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06018467 RID: 99431 RVA: 0x0021F5FB File Offset: 0x0021D7FB
		public vtkParametricHenneberg(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06018468 RID: 99432
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricHenneberg_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct Henneberg's minimal surface with the following parameters:
		/// (MinimumU, MaximumU) = (-1., 1.),
		/// (MinimumV, MaximumV) = (-pi/.2, pi/2.),
		/// JoinU = 0, JoinV = 0,
		/// TwistU = 0, TwistV = 0;
		/// ClockwiseOrdering = 0,
		/// DerivativesAvailable = 1,
		/// </summary>
		// Token: 0x06018469 RID: 99433 RVA: 0x0021F60C File Offset: 0x0021D80C
		public new static vtkParametricHenneberg New()
		{
			vtkParametricHenneberg result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricHenneberg.vtkParametricHenneberg_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricHenneberg)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct Henneberg's minimal surface with the following parameters:
		/// (MinimumU, MaximumU) = (-1., 1.),
		/// (MinimumV, MaximumV) = (-pi/.2, pi/2.),
		/// JoinU = 0, JoinV = 0,
		/// TwistU = 0, TwistV = 0;
		/// ClockwiseOrdering = 0,
		/// DerivativesAvailable = 1,
		/// </summary>
		// Token: 0x0601846A RID: 99434 RVA: 0x0021F660 File Offset: 0x0021D860
		public vtkParametricHenneberg() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkParametricHenneberg.vtkParametricHenneberg_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601846B RID: 99435 RVA: 0x0021F6A4 File Offset: 0x0021D8A4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601846C RID: 99436
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricHenneberg_Evaluate_01(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		/// <summary>
		/// Henneberg's minimal surface.
		///
		/// This function performs the mapping \f$f(u,v) \rightarrow (x,y,x)\f$, returning it
		/// as Pt. It also returns the partial derivatives Du and Dv.
		/// \f$Pt = (x, y, z), D_u\vec{f} = (dx/du, dy/du, dz/du), D_v\vec{f} = (dx/dv, dy/dv, dz/dv)\f$ .
		/// Then the normal is \f$N = D_u\vec{f} \times D_v\vec{f}\f$ .
		/// </summary>
		// Token: 0x0601846D RID: 99437 RVA: 0x0021F6AF File Offset: 0x0021D8AF
		public override void Evaluate(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			vtkParametricHenneberg.vtkParametricHenneberg_Evaluate_01(base.GetCppThis(), uvw, Pt, Duvw);
		}

		// Token: 0x0601846E RID: 99438
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricHenneberg_EvaluateScalar_02(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		/// <summary>
		/// Calculate a user defined scalar using one or all of uvw, Pt, Duvw.
		/// This method simply returns 0.
		/// </summary>
		// Token: 0x0601846F RID: 99439 RVA: 0x0021F6C4 File Offset: 0x0021D8C4
		public override double EvaluateScalar(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			return vtkParametricHenneberg.vtkParametricHenneberg_EvaluateScalar_02(base.GetCppThis(), uvw, Pt, Duvw);
		}

		// Token: 0x06018470 RID: 99440
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricHenneberg_GetDimension_03(HandleRef pThis);

		/// <summary>
		/// Return the parametric dimension of the class.
		/// </summary>
		// Token: 0x06018471 RID: 99441 RVA: 0x0021F6E8 File Offset: 0x0021D8E8
		public override int GetDimension()
		{
			return vtkParametricHenneberg.vtkParametricHenneberg_GetDimension_03(base.GetCppThis());
		}

		// Token: 0x06018472 RID: 99442
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParametricHenneberg_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018473 RID: 99443 RVA: 0x0021F708 File Offset: 0x0021D908
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkParametricHenneberg.vtkParametricHenneberg_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06018474 RID: 99444
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParametricHenneberg_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018475 RID: 99445 RVA: 0x0021F728 File Offset: 0x0021D928
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkParametricHenneberg.vtkParametricHenneberg_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06018476 RID: 99446
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricHenneberg_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018477 RID: 99447 RVA: 0x0021F744 File Offset: 0x0021D944
		public override int IsA(string type)
		{
			return vtkParametricHenneberg.vtkParametricHenneberg_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06018478 RID: 99448
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricHenneberg_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018479 RID: 99449 RVA: 0x0021F764 File Offset: 0x0021D964
		public new static int IsTypeOf(string type)
		{
			return vtkParametricHenneberg.vtkParametricHenneberg_IsTypeOf_07(type);
		}

		// Token: 0x0601847A RID: 99450
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricHenneberg_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601847B RID: 99451 RVA: 0x0021F780 File Offset: 0x0021D980
		public new vtkParametricHenneberg NewInstance()
		{
			vtkParametricHenneberg result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricHenneberg.vtkParametricHenneberg_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricHenneberg)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601847C RID: 99452
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricHenneberg_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601847D RID: 99453 RVA: 0x0021F7DC File Offset: 0x0021D9DC
		public new static vtkParametricHenneberg SafeDownCast(vtkObjectBase o)
		{
			vtkParametricHenneberg vtkParametricHenneberg = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricHenneberg.vtkParametricHenneberg_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParametricHenneberg = (vtkParametricHenneberg)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParametricHenneberg.Register(null);
				}
			}
			return vtkParametricHenneberg;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AFA RID: 6906
		public new const string MRFullTypeName = "Kitware.VTK.vtkParametricHenneberg";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AFB RID: 6907
		public new static readonly string MRClassNameKey = "class vtkParametricHenneberg";
	}
}
