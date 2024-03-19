using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkParametricBohemianDome
	/// </summary>
	/// <remarks>
	///    Generate a Bohemian dome.
	///
	/// vtkParametricBohemianDome generates a parametric Bohemian dome. The Bohemian
	/// dome is a quartic surface, and is described in much better detail at
	/// &lt;a href="https://www.math.hmc.edu/math142-01/mellon/curves_and_surfaces/surfaces/bohdom.html"&gt;HMC
	/// page&lt;/a&gt;.
	/// @warning
	/// I haven't set any restrictions on the A, B, or C values.
	/// @par Thanks:
	/// Tim Meehan
	/// </remarks>
	// Token: 0x0200091E RID: 2334
	public class vtkParametricBohemianDome : vtkParametricFunction
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601833E RID: 99134 RVA: 0x0021D9E5 File Offset: 0x0021BBE5
		static vtkParametricBohemianDome()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParametricBohemianDome.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParametricBohemianDome"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601833F RID: 99135 RVA: 0x0021DA0D File Offset: 0x0021BC0D
		public vtkParametricBohemianDome(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06018340 RID: 99136
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricBohemianDome_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct a Bohemian dome surface with the following parameters:
		/// </summary>
		// Token: 0x06018341 RID: 99137 RVA: 0x0021DA1C File Offset: 0x0021BC1C
		public new static vtkParametricBohemianDome New()
		{
			vtkParametricBohemianDome result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricBohemianDome.vtkParametricBohemianDome_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricBohemianDome)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct a Bohemian dome surface with the following parameters:
		/// </summary>
		// Token: 0x06018342 RID: 99138 RVA: 0x0021DA70 File Offset: 0x0021BC70
		public vtkParametricBohemianDome() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkParametricBohemianDome.vtkParametricBohemianDome_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06018343 RID: 99139 RVA: 0x0021DAB4 File Offset: 0x0021BCB4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06018344 RID: 99140
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricBohemianDome_Evaluate_01(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		/// <summary>
		/// BohemianDome surface.
		///
		/// This function performs the mapping \f$f(u,v) \rightarrow (x,y,x)\f$, returning it
		/// as Pt. It also returns the partial derivatives Du and Dv.
		/// \f$Pt = (x, y, z), D_u\vec{f} = (dx/du, dy/du, dz/du), D_v\vec{f} = (dx/dv, dy/dv, dz/dv)\f$ .
		/// Then the normal is \f$N = D_u\vec{f} \times D_v\vec{f}\f$ .
		/// </summary>
		// Token: 0x06018345 RID: 99141 RVA: 0x0021DABF File Offset: 0x0021BCBF
		public override void Evaluate(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			vtkParametricBohemianDome.vtkParametricBohemianDome_Evaluate_01(base.GetCppThis(), uvw, Pt, Duvw);
		}

		// Token: 0x06018346 RID: 99142
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricBohemianDome_EvaluateScalar_02(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		/// <summary>
		/// Calculate a user defined scalar using one or all of uvw, Pt, Duvw.
		/// This method simply returns 0.
		/// </summary>
		// Token: 0x06018347 RID: 99143 RVA: 0x0021DAD4 File Offset: 0x0021BCD4
		public override double EvaluateScalar(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			return vtkParametricBohemianDome.vtkParametricBohemianDome_EvaluateScalar_02(base.GetCppThis(), uvw, Pt, Duvw);
		}

		// Token: 0x06018348 RID: 99144
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricBohemianDome_GetA_03(HandleRef pThis);

		/// <summary>
		/// Construct a Bohemian dome surface with the following parameters:
		/// </summary>
		// Token: 0x06018349 RID: 99145 RVA: 0x0021DAF8 File Offset: 0x0021BCF8
		public virtual double GetA()
		{
			return vtkParametricBohemianDome.vtkParametricBohemianDome_GetA_03(base.GetCppThis());
		}

		// Token: 0x0601834A RID: 99146
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricBohemianDome_GetB_04(HandleRef pThis);

		/// <summary>
		/// Construct a Bohemian dome surface with the following parameters:
		/// </summary>
		// Token: 0x0601834B RID: 99147 RVA: 0x0021DB18 File Offset: 0x0021BD18
		public virtual double GetB()
		{
			return vtkParametricBohemianDome.vtkParametricBohemianDome_GetB_04(base.GetCppThis());
		}

		// Token: 0x0601834C RID: 99148
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricBohemianDome_GetC_05(HandleRef pThis);

		/// <summary>
		/// Construct a Bohemian dome surface with the following parameters:
		/// </summary>
		// Token: 0x0601834D RID: 99149 RVA: 0x0021DB38 File Offset: 0x0021BD38
		public virtual double GetC()
		{
			return vtkParametricBohemianDome.vtkParametricBohemianDome_GetC_05(base.GetCppThis());
		}

		// Token: 0x0601834E RID: 99150
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricBohemianDome_GetDimension_06(HandleRef pThis);

		/// <summary>
		/// Return the parametric dimension of the class.
		/// </summary>
		// Token: 0x0601834F RID: 99151 RVA: 0x0021DB58 File Offset: 0x0021BD58
		public override int GetDimension()
		{
			return vtkParametricBohemianDome.vtkParametricBohemianDome_GetDimension_06(base.GetCppThis());
		}

		// Token: 0x06018350 RID: 99152
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParametricBohemianDome_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018351 RID: 99153 RVA: 0x0021DB78 File Offset: 0x0021BD78
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkParametricBohemianDome.vtkParametricBohemianDome_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x06018352 RID: 99154
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParametricBohemianDome_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018353 RID: 99155 RVA: 0x0021DB98 File Offset: 0x0021BD98
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkParametricBohemianDome.vtkParametricBohemianDome_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x06018354 RID: 99156
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricBohemianDome_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018355 RID: 99157 RVA: 0x0021DBB4 File Offset: 0x0021BDB4
		public override int IsA(string type)
		{
			return vtkParametricBohemianDome.vtkParametricBohemianDome_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x06018356 RID: 99158
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricBohemianDome_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018357 RID: 99159 RVA: 0x0021DBD4 File Offset: 0x0021BDD4
		public new static int IsTypeOf(string type)
		{
			return vtkParametricBohemianDome.vtkParametricBohemianDome_IsTypeOf_10(type);
		}

		// Token: 0x06018358 RID: 99160
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricBohemianDome_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018359 RID: 99161 RVA: 0x0021DBF0 File Offset: 0x0021BDF0
		public new vtkParametricBohemianDome NewInstance()
		{
			vtkParametricBohemianDome result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricBohemianDome.vtkParametricBohemianDome_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricBohemianDome)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601835A RID: 99162
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricBohemianDome_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601835B RID: 99163 RVA: 0x0021DC4C File Offset: 0x0021BE4C
		public new static vtkParametricBohemianDome SafeDownCast(vtkObjectBase o)
		{
			vtkParametricBohemianDome vtkParametricBohemianDome = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricBohemianDome.vtkParametricBohemianDome_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParametricBohemianDome = (vtkParametricBohemianDome)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParametricBohemianDome.Register(null);
				}
			}
			return vtkParametricBohemianDome;
		}

		// Token: 0x0601835C RID: 99164
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricBohemianDome_SetA_14(HandleRef pThis, double _arg);

		/// <summary>
		/// Construct a Bohemian dome surface with the following parameters:
		/// </summary>
		// Token: 0x0601835D RID: 99165 RVA: 0x0021DCCB File Offset: 0x0021BECB
		public virtual void SetA(double _arg)
		{
			vtkParametricBohemianDome.vtkParametricBohemianDome_SetA_14(base.GetCppThis(), _arg);
		}

		// Token: 0x0601835E RID: 99166
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricBohemianDome_SetB_15(HandleRef pThis, double _arg);

		/// <summary>
		/// Construct a Bohemian dome surface with the following parameters:
		/// </summary>
		// Token: 0x0601835F RID: 99167 RVA: 0x0021DCDB File Offset: 0x0021BEDB
		public virtual void SetB(double _arg)
		{
			vtkParametricBohemianDome.vtkParametricBohemianDome_SetB_15(base.GetCppThis(), _arg);
		}

		// Token: 0x06018360 RID: 99168
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricBohemianDome_SetC_16(HandleRef pThis, double _arg);

		/// <summary>
		/// Construct a Bohemian dome surface with the following parameters:
		/// </summary>
		// Token: 0x06018361 RID: 99169 RVA: 0x0021DCEB File Offset: 0x0021BEEB
		public virtual void SetC(double _arg)
		{
			vtkParametricBohemianDome.vtkParametricBohemianDome_SetC_16(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AE6 RID: 6886
		public new const string MRFullTypeName = "Kitware.VTK.vtkParametricBohemianDome";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AE7 RID: 6887
		public new static readonly string MRClassNameKey = "class vtkParametricBohemianDome";
	}
}
