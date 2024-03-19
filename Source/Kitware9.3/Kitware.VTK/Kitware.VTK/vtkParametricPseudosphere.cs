using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkParametricPseudosphere
	/// </summary>
	/// <remarks>
	///    Generate a pseudosphere.
	///
	/// vtkParametricPseudosphere generates a parametric pseudosphere. The
	/// pseudosphere is generated as a surface of revolution of the tractrix about
	/// it's asymptote, and is a surface of constant negative Gaussian curvature.
	/// You can find out more about this interesting surface at
	/// &lt;a href="http://mathworld.wolfram.com/Pseudosphere.html"&gt;Math World&lt;/a&gt;.
	/// @par Thanks:
	/// Tim Meehan
	/// </remarks>
	// Token: 0x0200092D RID: 2349
	public class vtkParametricPseudosphere : vtkParametricFunction
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060184EA RID: 99562 RVA: 0x0022030B File Offset: 0x0021E50B
		static vtkParametricPseudosphere()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParametricPseudosphere.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParametricPseudosphere"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060184EB RID: 99563 RVA: 0x00220333 File Offset: 0x0021E533
		public vtkParametricPseudosphere(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060184EC RID: 99564
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricPseudosphere_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct a pseudosphere surface with the following parameters:
		/// (MinimumU, MaximumU) = (-5., 5.),
		/// (MinimumV, MaximumV) = (-pi, pi),
		/// JoinU = 0, JoinV = 1,
		/// TwistU = 0, TwistV = 0;
		/// ClockwiseOrdering = 0,
		/// DerivativesAvailable = 1,
		/// </summary>
		// Token: 0x060184ED RID: 99565 RVA: 0x00220344 File Offset: 0x0021E544
		public new static vtkParametricPseudosphere New()
		{
			vtkParametricPseudosphere result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricPseudosphere.vtkParametricPseudosphere_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricPseudosphere)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct a pseudosphere surface with the following parameters:
		/// (MinimumU, MaximumU) = (-5., 5.),
		/// (MinimumV, MaximumV) = (-pi, pi),
		/// JoinU = 0, JoinV = 1,
		/// TwistU = 0, TwistV = 0;
		/// ClockwiseOrdering = 0,
		/// DerivativesAvailable = 1,
		/// </summary>
		// Token: 0x060184EE RID: 99566 RVA: 0x00220398 File Offset: 0x0021E598
		public vtkParametricPseudosphere() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkParametricPseudosphere.vtkParametricPseudosphere_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060184EF RID: 99567 RVA: 0x002203DC File Offset: 0x0021E5DC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060184F0 RID: 99568
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricPseudosphere_Evaluate_01(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		/// <summary>
		/// Pseudosphere surface.
		///
		/// This function performs the mapping \f$f(u,v) \rightarrow (x,y,x)\f$, returning it
		/// as Pt. It also returns the partial derivatives Du and Dv.
		/// \f$Pt = (x, y, z), D_u\vec{f} = (dx/du, dy/du, dz/du), D_v\vec{f} = (dx/dv, dy/dv, dz/dv)\f$ .
		/// Then the normal is \f$N = D_u\vec{f} \times D_v\vec{f}\f$ .
		/// </summary>
		// Token: 0x060184F1 RID: 99569 RVA: 0x002203E7 File Offset: 0x0021E5E7
		public override void Evaluate(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			vtkParametricPseudosphere.vtkParametricPseudosphere_Evaluate_01(base.GetCppThis(), uvw, Pt, Duvw);
		}

		// Token: 0x060184F2 RID: 99570
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricPseudosphere_EvaluateScalar_02(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		/// <summary>
		/// Calculate a user defined scalar using one or all of uvw, Pt, Duvw.
		/// This method simply returns 0.
		/// </summary>
		// Token: 0x060184F3 RID: 99571 RVA: 0x002203FC File Offset: 0x0021E5FC
		public override double EvaluateScalar(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			return vtkParametricPseudosphere.vtkParametricPseudosphere_EvaluateScalar_02(base.GetCppThis(), uvw, Pt, Duvw);
		}

		// Token: 0x060184F4 RID: 99572
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricPseudosphere_GetDimension_03(HandleRef pThis);

		/// <summary>
		/// Return the parametric dimension of the class.
		/// </summary>
		// Token: 0x060184F5 RID: 99573 RVA: 0x00220420 File Offset: 0x0021E620
		public override int GetDimension()
		{
			return vtkParametricPseudosphere.vtkParametricPseudosphere_GetDimension_03(base.GetCppThis());
		}

		// Token: 0x060184F6 RID: 99574
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParametricPseudosphere_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060184F7 RID: 99575 RVA: 0x00220440 File Offset: 0x0021E640
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkParametricPseudosphere.vtkParametricPseudosphere_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x060184F8 RID: 99576
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParametricPseudosphere_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060184F9 RID: 99577 RVA: 0x00220460 File Offset: 0x0021E660
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkParametricPseudosphere.vtkParametricPseudosphere_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x060184FA RID: 99578
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricPseudosphere_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060184FB RID: 99579 RVA: 0x0022047C File Offset: 0x0021E67C
		public override int IsA(string type)
		{
			return vtkParametricPseudosphere.vtkParametricPseudosphere_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x060184FC RID: 99580
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricPseudosphere_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060184FD RID: 99581 RVA: 0x0022049C File Offset: 0x0021E69C
		public new static int IsTypeOf(string type)
		{
			return vtkParametricPseudosphere.vtkParametricPseudosphere_IsTypeOf_07(type);
		}

		// Token: 0x060184FE RID: 99582
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricPseudosphere_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060184FF RID: 99583 RVA: 0x002204B8 File Offset: 0x0021E6B8
		public new vtkParametricPseudosphere NewInstance()
		{
			vtkParametricPseudosphere result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricPseudosphere.vtkParametricPseudosphere_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricPseudosphere)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06018500 RID: 99584
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricPseudosphere_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018501 RID: 99585 RVA: 0x00220514 File Offset: 0x0021E714
		public new static vtkParametricPseudosphere SafeDownCast(vtkObjectBase o)
		{
			vtkParametricPseudosphere vtkParametricPseudosphere = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricPseudosphere.vtkParametricPseudosphere_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParametricPseudosphere = (vtkParametricPseudosphere)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParametricPseudosphere.Register(null);
				}
			}
			return vtkParametricPseudosphere;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B04 RID: 6916
		public new const string MRFullTypeName = "Kitware.VTK.vtkParametricPseudosphere";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B05 RID: 6917
		public new static readonly string MRClassNameKey = "class vtkParametricPseudosphere";
	}
}
