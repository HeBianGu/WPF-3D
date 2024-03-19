using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkParametricEllipsoid
	/// </summary>
	/// <remarks>
	///    Generate an ellipsoid.
	///
	/// vtkParametricEllipsoid generates an ellipsoid.
	/// If all the radii are the same, we have a sphere.
	/// An oblate spheroid occurs if RadiusX = RadiusY &gt; RadiusZ.
	/// Here the Z-axis forms the symmetry axis. To a first
	/// approximation, this is the shape of the earth.
	/// A prolate spheroid occurs if RadiusX = RadiusY &lt; RadiusZ.
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
	// Token: 0x02000925 RID: 2341
	public class vtkParametricEllipsoid : vtkParametricFunction
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601840E RID: 99342 RVA: 0x0021ED7B File Offset: 0x0021CF7B
		static vtkParametricEllipsoid()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParametricEllipsoid.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParametricEllipsoid"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601840F RID: 99343 RVA: 0x0021EDA3 File Offset: 0x0021CFA3
		public vtkParametricEllipsoid(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06018410 RID: 99344
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricEllipsoid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct an ellipsoid with the following parameters:
		/// MinimumU = 0, MaximumU = 2*Pi,
		/// MinimumV = 0, MaximumV = Pi,
		/// JoinU = 1, JoinV = 0,
		/// TwistU = 0, TwistV = 0,
		/// ClockwiseOrdering = 0,
		/// DerivativesAvailable = 1,
		/// XRadius = 1, YRadius = 1,
		/// ZRadius = 1, a sphere in this case.
		/// </summary>
		// Token: 0x06018411 RID: 99345 RVA: 0x0021EDB4 File Offset: 0x0021CFB4
		public new static vtkParametricEllipsoid New()
		{
			vtkParametricEllipsoid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricEllipsoid.vtkParametricEllipsoid_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricEllipsoid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct an ellipsoid with the following parameters:
		/// MinimumU = 0, MaximumU = 2*Pi,
		/// MinimumV = 0, MaximumV = Pi,
		/// JoinU = 1, JoinV = 0,
		/// TwistU = 0, TwistV = 0,
		/// ClockwiseOrdering = 0,
		/// DerivativesAvailable = 1,
		/// XRadius = 1, YRadius = 1,
		/// ZRadius = 1, a sphere in this case.
		/// </summary>
		// Token: 0x06018412 RID: 99346 RVA: 0x0021EE08 File Offset: 0x0021D008
		public vtkParametricEllipsoid() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkParametricEllipsoid.vtkParametricEllipsoid_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06018413 RID: 99347 RVA: 0x0021EE4C File Offset: 0x0021D04C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06018414 RID: 99348
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricEllipsoid_Evaluate_01(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		/// <summary>
		/// An ellipsoid.
		///
		/// This function performs the mapping \f$f(u,v) \rightarrow (x,y,x)\f$, returning it
		/// as Pt. It also returns the partial derivatives Du and Dv.
		/// \f$Pt = (x, y, z), Du = (dx/du, dy/du, dz/du), Dv = (dx/dv, dy/dv, dz/dv)\f$ .
		/// Then the normal is \f$N = Du X Dv\f$ .
		/// </summary>
		// Token: 0x06018415 RID: 99349 RVA: 0x0021EE57 File Offset: 0x0021D057
		public override void Evaluate(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			vtkParametricEllipsoid.vtkParametricEllipsoid_Evaluate_01(base.GetCppThis(), uvw, Pt, Duvw);
		}

		// Token: 0x06018416 RID: 99350
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricEllipsoid_EvaluateScalar_02(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

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
		// Token: 0x06018417 RID: 99351 RVA: 0x0021EE6C File Offset: 0x0021D06C
		public override double EvaluateScalar(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			return vtkParametricEllipsoid.vtkParametricEllipsoid_EvaluateScalar_02(base.GetCppThis(), uvw, Pt, Duvw);
		}

		// Token: 0x06018418 RID: 99352
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricEllipsoid_GetDimension_03(HandleRef pThis);

		/// <summary>
		/// Return the parametric dimension of the class.
		/// </summary>
		// Token: 0x06018419 RID: 99353 RVA: 0x0021EE90 File Offset: 0x0021D090
		public override int GetDimension()
		{
			return vtkParametricEllipsoid.vtkParametricEllipsoid_GetDimension_03(base.GetCppThis());
		}

		// Token: 0x0601841A RID: 99354
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParametricEllipsoid_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601841B RID: 99355 RVA: 0x0021EEB0 File Offset: 0x0021D0B0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkParametricEllipsoid.vtkParametricEllipsoid_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601841C RID: 99356
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParametricEllipsoid_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601841D RID: 99357 RVA: 0x0021EED0 File Offset: 0x0021D0D0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkParametricEllipsoid.vtkParametricEllipsoid_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601841E RID: 99358
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricEllipsoid_GetXRadius_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the scaling factor for the x-axis. Default is 1.
		/// </summary>
		// Token: 0x0601841F RID: 99359 RVA: 0x0021EEEC File Offset: 0x0021D0EC
		public virtual double GetXRadius()
		{
			return vtkParametricEllipsoid.vtkParametricEllipsoid_GetXRadius_06(base.GetCppThis());
		}

		// Token: 0x06018420 RID: 99360
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricEllipsoid_GetYRadius_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the scaling factor for the y-axis. Default is 1.
		/// </summary>
		// Token: 0x06018421 RID: 99361 RVA: 0x0021EF0C File Offset: 0x0021D10C
		public virtual double GetYRadius()
		{
			return vtkParametricEllipsoid.vtkParametricEllipsoid_GetYRadius_07(base.GetCppThis());
		}

		// Token: 0x06018422 RID: 99362
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParametricEllipsoid_GetZRadius_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the scaling factor for the z-axis. Default is 1.
		/// </summary>
		// Token: 0x06018423 RID: 99363 RVA: 0x0021EF2C File Offset: 0x0021D12C
		public virtual double GetZRadius()
		{
			return vtkParametricEllipsoid.vtkParametricEllipsoid_GetZRadius_08(base.GetCppThis());
		}

		// Token: 0x06018424 RID: 99364
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricEllipsoid_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018425 RID: 99365 RVA: 0x0021EF4C File Offset: 0x0021D14C
		public override int IsA(string type)
		{
			return vtkParametricEllipsoid.vtkParametricEllipsoid_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x06018426 RID: 99366
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParametricEllipsoid_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018427 RID: 99367 RVA: 0x0021EF6C File Offset: 0x0021D16C
		public new static int IsTypeOf(string type)
		{
			return vtkParametricEllipsoid.vtkParametricEllipsoid_IsTypeOf_10(type);
		}

		// Token: 0x06018428 RID: 99368
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricEllipsoid_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018429 RID: 99369 RVA: 0x0021EF88 File Offset: 0x0021D188
		public new vtkParametricEllipsoid NewInstance()
		{
			vtkParametricEllipsoid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricEllipsoid.vtkParametricEllipsoid_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricEllipsoid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601842A RID: 99370
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParametricEllipsoid_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601842B RID: 99371 RVA: 0x0021EFE4 File Offset: 0x0021D1E4
		public new static vtkParametricEllipsoid SafeDownCast(vtkObjectBase o)
		{
			vtkParametricEllipsoid vtkParametricEllipsoid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParametricEllipsoid.vtkParametricEllipsoid_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParametricEllipsoid = (vtkParametricEllipsoid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParametricEllipsoid.Register(null);
				}
			}
			return vtkParametricEllipsoid;
		}

		// Token: 0x0601842C RID: 99372
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricEllipsoid_SetXRadius_14(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the scaling factor for the x-axis. Default is 1.
		/// </summary>
		// Token: 0x0601842D RID: 99373 RVA: 0x0021F063 File Offset: 0x0021D263
		public virtual void SetXRadius(double _arg)
		{
			vtkParametricEllipsoid.vtkParametricEllipsoid_SetXRadius_14(base.GetCppThis(), _arg);
		}

		// Token: 0x0601842E RID: 99374
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricEllipsoid_SetYRadius_15(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the scaling factor for the y-axis. Default is 1.
		/// </summary>
		// Token: 0x0601842F RID: 99375 RVA: 0x0021F073 File Offset: 0x0021D273
		public virtual void SetYRadius(double _arg)
		{
			vtkParametricEllipsoid.vtkParametricEllipsoid_SetYRadius_15(base.GetCppThis(), _arg);
		}

		// Token: 0x06018430 RID: 99376
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParametricEllipsoid_SetZRadius_16(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the scaling factor for the z-axis. Default is 1.
		/// </summary>
		// Token: 0x06018431 RID: 99377 RVA: 0x0021F083 File Offset: 0x0021D283
		public virtual void SetZRadius(double _arg)
		{
			vtkParametricEllipsoid.vtkParametricEllipsoid_SetZRadius_16(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AF4 RID: 6900
		public new const string MRFullTypeName = "Kitware.VTK.vtkParametricEllipsoid";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AF5 RID: 6901
		public new static readonly string MRClassNameKey = "class vtkParametricEllipsoid";
	}
}
