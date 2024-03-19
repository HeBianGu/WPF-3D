using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkParametricRoman
	/// </summary>
	/// <remarks>
	///    Generate Steiner's Roman Surface.
	///
	/// vtkParametricRoman generates Steiner's Roman Surface.
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
	// Token: 0x0200092F RID: 2351
	public class vtkParametricRoman : vtkParametricFunction
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06018546 RID: 99654 RVA: 0x00220A27 File Offset: 0x0021EC27
		static vtkParametricRoman()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParametricRoman.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParametricRoman"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06018547 RID: 99655 RVA: 0x00220A4F File Offset: 0x0021EC4F
		public vtkParametricRoman(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06018548 RID: 99656
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricRoman_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct Steiner's Roman Surface with the following parameters:
		/// MinimumU = 0, MaximumU = Pi,
		/// MinimumV = 0, MaximumV = Pi,
		/// JoinU = 1, JoinV = 1,
		/// TwistU = 1, TwistV = 0;
		/// ClockwiseOrdering = 0,
		/// DerivativesAvailable = 1,
		/// Radius = 1
		/// </summary>
		// Token: 0x06018549 RID: 99657 RVA: 0x00220A60 File Offset: 0x0021EC60
		public new static vtkParametricRoman New()
		{
			vtkParametricRoman result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricRoman.vtkParametricRoman_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricRoman)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct Steiner's Roman Surface with the following parameters:
		/// MinimumU = 0, MaximumU = Pi,
		/// MinimumV = 0, MaximumV = Pi,
		/// JoinU = 1, JoinV = 1,
		/// TwistU = 1, TwistV = 0;
		/// ClockwiseOrdering = 0,
		/// DerivativesAvailable = 1,
		/// Radius = 1
		/// </summary>
		// Token: 0x0601854A RID: 99658 RVA: 0x00220AB4 File Offset: 0x0021ECB4
		public vtkParametricRoman() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkParametricRoman.vtkParametricRoman_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601854B RID: 99659 RVA: 0x00220AF8 File Offset: 0x0021ECF8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601854C RID: 99660
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricRoman_Evaluate_01(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		/// <summary>
		/// Steiner's Roman Surface
		///
		/// This function performs the mapping \f$f(u,v) \rightarrow (x,y,x)\f$, returning it
		/// as Pt. It also returns the partial derivatives Du and Dv.
		/// \f$Pt = (x, y, z), Du = (dx/du, dy/du, dz/du), Dv = (dx/dv, dy/dv, dz/dv)\f$ .
		/// Then the normal is \f$N = Du X Dv\f$ .
		/// </summary>
		// Token: 0x0601854D RID: 99661 RVA: 0x00220B03 File Offset: 0x0021ED03
		public override void Evaluate(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			vtkParametricRoman.vtkParametricRoman_Evaluate_01(base.GetCppThis(), uvw, Pt, Duvw);
		}

		// Token: 0x0601854E RID: 99662
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricRoman_EvaluateScalar_02(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		/// <summary>
		/// Calculate a user defined scalar using one or all of uvw, Pt, Duvw.
		///
		/// uvw are the parameters with Pt being the Cartesian point,
		/// Duvw are the derivatives of this point with respect to u, v and w.
		/// Pt, Duvw are obtained from Evaluate().
		///
		/// This function is only called if the ScalarMode has the value
		/// vtkParametricFunctionSource::SCALAR_FUNCTION_DEFINED
		///
		/// If the user does not need to calculate a scalar, then the
		/// instantiated function should return zero.
		/// </summary>
		// Token: 0x0601854F RID: 99663 RVA: 0x00220B18 File Offset: 0x0021ED18
		public override double EvaluateScalar(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			return vtkParametricRoman.vtkParametricRoman_EvaluateScalar_02(base.GetCppThis(), uvw, Pt, Duvw);
		}

		// Token: 0x06018550 RID: 99664
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricRoman_GetDimension_03(HandleRef pThis);

		/// <summary>
		/// Return the parametric dimension of the class.
		/// </summary>
		// Token: 0x06018551 RID: 99665 RVA: 0x00220B3C File Offset: 0x0021ED3C
		public override int GetDimension()
		{
			return vtkParametricRoman.vtkParametricRoman_GetDimension_03(base.GetCppThis());
		}

		// Token: 0x06018552 RID: 99666
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParametricRoman_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018553 RID: 99667 RVA: 0x00220B5C File Offset: 0x0021ED5C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkParametricRoman.vtkParametricRoman_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06018554 RID: 99668
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParametricRoman_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018555 RID: 99669 RVA: 0x00220B7C File Offset: 0x0021ED7C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkParametricRoman.vtkParametricRoman_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06018556 RID: 99670
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricRoman_GetRadius_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the radius. Default is 1.
		/// </summary>
		// Token: 0x06018557 RID: 99671 RVA: 0x00220B98 File Offset: 0x0021ED98
		public virtual double GetRadius()
		{
			return vtkParametricRoman.vtkParametricRoman_GetRadius_06(base.GetCppThis());
		}

		// Token: 0x06018558 RID: 99672
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricRoman_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018559 RID: 99673 RVA: 0x00220BB8 File Offset: 0x0021EDB8
		public override int IsA(string type)
		{
			return vtkParametricRoman.vtkParametricRoman_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601855A RID: 99674
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricRoman_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601855B RID: 99675 RVA: 0x00220BD8 File Offset: 0x0021EDD8
		public new static int IsTypeOf(string type)
		{
			return vtkParametricRoman.vtkParametricRoman_IsTypeOf_08(type);
		}

		// Token: 0x0601855C RID: 99676
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricRoman_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601855D RID: 99677 RVA: 0x00220BF4 File Offset: 0x0021EDF4
		public new vtkParametricRoman NewInstance()
		{
			vtkParametricRoman result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricRoman.vtkParametricRoman_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricRoman)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601855E RID: 99678
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricRoman_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601855F RID: 99679 RVA: 0x00220C50 File Offset: 0x0021EE50
		public new static vtkParametricRoman SafeDownCast(vtkObjectBase o)
		{
			vtkParametricRoman vtkParametricRoman = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricRoman.vtkParametricRoman_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParametricRoman = (vtkParametricRoman)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParametricRoman.Register(null);
				}
			}
			return vtkParametricRoman;
		}

		// Token: 0x06018560 RID: 99680
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricRoman_SetRadius_12(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the radius. Default is 1.
		/// </summary>
		// Token: 0x06018561 RID: 99681 RVA: 0x00220CCF File Offset: 0x0021EECF
		public virtual void SetRadius(double _arg)
		{
			vtkParametricRoman.vtkParametricRoman_SetRadius_12(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B08 RID: 6920
		public new const string MRFullTypeName = "Kitware.VTK.vtkParametricRoman";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B09 RID: 6921
		public new static readonly string MRClassNameKey = "class vtkParametricRoman";
	}
}
