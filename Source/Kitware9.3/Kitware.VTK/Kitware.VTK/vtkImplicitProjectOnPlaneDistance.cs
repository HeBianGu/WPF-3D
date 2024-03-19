using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImplicitProjectOnPlaneDistance
	///
	/// This class receive a plannar polygon as input. Given a point, it can
	/// evaluate the L0 or L2 norm between the projection of this point on the plan
	/// of the polygon and the polygon itself.
	///
	/// An interesting use of this class is to enable the L0 norm and evaluate the
	/// "projected distance" between every vertex of a mesh and the given plannar polygon.
	/// As a result, all the vertices that project onto the polygon will correspond to the
	/// value 0 and other ones will receive the value 1.
	/// From there, we can use a clip to keep only the part of the mesh "below" the polygon.
	///
	/// TLDR: This filter allows to clip using the extrusion of any plannar polygon.
	/// </summary>
	// Token: 0x02000976 RID: 2422
	public class vtkImplicitProjectOnPlaneDistance : vtkImplicitFunction
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601941B RID: 103451 RVA: 0x00232F9B File Offset: 0x0023119B
		static vtkImplicitProjectOnPlaneDistance()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImplicitProjectOnPlaneDistance.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImplicitProjectOnPlaneDistance"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601941C RID: 103452 RVA: 0x00232FC3 File Offset: 0x002311C3
		public vtkImplicitProjectOnPlaneDistance(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601941D RID: 103453
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitProjectOnPlaneDistance_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601941E RID: 103454 RVA: 0x00232FD4 File Offset: 0x002311D4
		public new static vtkImplicitProjectOnPlaneDistance New()
		{
			vtkImplicitProjectOnPlaneDistance result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitProjectOnPlaneDistance.vtkImplicitProjectOnPlaneDistance_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitProjectOnPlaneDistance)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601941F RID: 103455 RVA: 0x00233028 File Offset: 0x00231228
		public vtkImplicitProjectOnPlaneDistance() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImplicitProjectOnPlaneDistance.vtkImplicitProjectOnPlaneDistance_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06019420 RID: 103456 RVA: 0x0023306C File Offset: 0x0023126C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06019421 RID: 103457
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImplicitProjectOnPlaneDistance_EvaluateFunction_01(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Project x onto the plane defined by the Input polydata and evaluate the
		/// distance to the geometry defined by the Input polydata.
		/// </summary>
		// Token: 0x06019422 RID: 103458 RVA: 0x00233078 File Offset: 0x00231278
		public override double EvaluateFunction(IntPtr x)
		{
			return vtkImplicitProjectOnPlaneDistance.vtkImplicitProjectOnPlaneDistance_EvaluateFunction_01(base.GetCppThis(), x);
		}

		// Token: 0x06019423 RID: 103459
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitProjectOnPlaneDistance_EvaluateGradient_02(HandleRef pThis, IntPtr x, IntPtr g);

		/// <summary>
		/// Evaluate function gradient of nearest triangle to point x[3].
		/// WARNING: not implemented as it is of no use in this context.
		/// </summary>
		// Token: 0x06019424 RID: 103460 RVA: 0x00233098 File Offset: 0x00231298
		public override void EvaluateGradient(IntPtr x, IntPtr g)
		{
			vtkImplicitProjectOnPlaneDistance.vtkImplicitProjectOnPlaneDistance_EvaluateGradient_02(base.GetCppThis(), x, g);
		}

		// Token: 0x06019425 RID: 103461
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitProjectOnPlaneDistance_GetLocator_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get the Locator used by to compute the distance.
		/// A vtkStaticCellLocator is provided by default if
		/// none is given by the user.
		/// </summary>
		// Token: 0x06019426 RID: 103462 RVA: 0x002330AC File Offset: 0x002312AC
		public virtual vtkAbstractCellLocator GetLocator()
		{
			vtkAbstractCellLocator vtkAbstractCellLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitProjectOnPlaneDistance.vtkImplicitProjectOnPlaneDistance_GetLocator_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractCellLocator = (vtkAbstractCellLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractCellLocator.Register(null);
				}
			}
			return vtkAbstractCellLocator;
		}

		// Token: 0x06019427 RID: 103463
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkImplicitProjectOnPlaneDistance_GetMTime_04(HandleRef pThis);

		/// <summary>
		/// Return the MTime also considering the Input dependency.
		/// </summary>
		// Token: 0x06019428 RID: 103464 RVA: 0x0023311C File Offset: 0x0023131C
		public override ulong GetMTime()
		{
			return vtkImplicitProjectOnPlaneDistance.vtkImplicitProjectOnPlaneDistance_GetMTime_04(base.GetCppThis());
		}

		// Token: 0x06019429 RID: 103465
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkImplicitProjectOnPlaneDistance.NormType vtkImplicitProjectOnPlaneDistance_GetNorm_05(HandleRef pThis);

		/// <summary>
		/// Set the norm to use:
		/// L0: 0 when the projection is inside the input polygon, 1 otherwise
		/// L2: Euclidean distance between the projection and the polygon (default)
		/// </summary>
		// Token: 0x0601942A RID: 103466 RVA: 0x0023313C File Offset: 0x0023133C
		public vtkImplicitProjectOnPlaneDistance.NormType GetNorm()
		{
			return vtkImplicitProjectOnPlaneDistance.vtkImplicitProjectOnPlaneDistance_GetNorm_05(base.GetCppThis());
		}

		// Token: 0x0601942B RID: 103467
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImplicitProjectOnPlaneDistance_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601942C RID: 103468 RVA: 0x0023315C File Offset: 0x0023135C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImplicitProjectOnPlaneDistance.vtkImplicitProjectOnPlaneDistance_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0601942D RID: 103469
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImplicitProjectOnPlaneDistance_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601942E RID: 103470 RVA: 0x0023317C File Offset: 0x0023137C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImplicitProjectOnPlaneDistance.vtkImplicitProjectOnPlaneDistance_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0601942F RID: 103471
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImplicitProjectOnPlaneDistance_GetTolerance_08(HandleRef pThis);

		/// <summary>
		/// Set/get the tolerance used for the locator.
		/// Default is 0.01.
		/// </summary>
		// Token: 0x06019430 RID: 103472 RVA: 0x00233198 File Offset: 0x00231398
		public virtual double GetTolerance()
		{
			return vtkImplicitProjectOnPlaneDistance.vtkImplicitProjectOnPlaneDistance_GetTolerance_08(base.GetCppThis());
		}

		// Token: 0x06019431 RID: 103473
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitProjectOnPlaneDistance_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019432 RID: 103474 RVA: 0x002331B8 File Offset: 0x002313B8
		public override int IsA(string type)
		{
			return vtkImplicitProjectOnPlaneDistance.vtkImplicitProjectOnPlaneDistance_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x06019433 RID: 103475
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitProjectOnPlaneDistance_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019434 RID: 103476 RVA: 0x002331D8 File Offset: 0x002313D8
		public new static int IsTypeOf(string type)
		{
			return vtkImplicitProjectOnPlaneDistance.vtkImplicitProjectOnPlaneDistance_IsTypeOf_10(type);
		}

		// Token: 0x06019435 RID: 103477
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitProjectOnPlaneDistance_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019436 RID: 103478 RVA: 0x002331F4 File Offset: 0x002313F4
		public new vtkImplicitProjectOnPlaneDistance NewInstance()
		{
			vtkImplicitProjectOnPlaneDistance result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitProjectOnPlaneDistance.vtkImplicitProjectOnPlaneDistance_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitProjectOnPlaneDistance)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06019437 RID: 103479
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitProjectOnPlaneDistance_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019438 RID: 103480 RVA: 0x00233250 File Offset: 0x00231450
		public new static vtkImplicitProjectOnPlaneDistance SafeDownCast(vtkObjectBase o)
		{
			vtkImplicitProjectOnPlaneDistance vtkImplicitProjectOnPlaneDistance = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitProjectOnPlaneDistance.vtkImplicitProjectOnPlaneDistance_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitProjectOnPlaneDistance = (vtkImplicitProjectOnPlaneDistance)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitProjectOnPlaneDistance.Register(null);
				}
			}
			return vtkImplicitProjectOnPlaneDistance;
		}

		// Token: 0x06019439 RID: 103481
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitProjectOnPlaneDistance_SetInput_14(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Set the input vtkPolyData used for the implicit function
		/// evaluation. This polydata needs to be planar.
		/// </summary>
		// Token: 0x0601943A RID: 103482 RVA: 0x002332D0 File Offset: 0x002314D0
		public void SetInput(vtkPolyData input)
		{
			vtkImplicitProjectOnPlaneDistance.vtkImplicitProjectOnPlaneDistance_SetInput_14(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x0601943B RID: 103483
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitProjectOnPlaneDistance_SetLocator_15(HandleRef pThis, HandleRef _arg);

		/// <summary>
		/// Set/get the Locator used by to compute the distance.
		/// A vtkStaticCellLocator is provided by default if
		/// none is given by the user.
		/// </summary>
		// Token: 0x0601943C RID: 103484 RVA: 0x00233300 File Offset: 0x00231500
		public virtual void SetLocator(vtkAbstractCellLocator _arg)
		{
			vtkImplicitProjectOnPlaneDistance.vtkImplicitProjectOnPlaneDistance_SetLocator_15(base.GetCppThis(), (_arg == null) ? default(HandleRef) : _arg.GetCppThis());
		}

		// Token: 0x0601943D RID: 103485
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitProjectOnPlaneDistance_SetNorm_16(HandleRef pThis, vtkImplicitProjectOnPlaneDistance.NormType n);

		/// <summary>
		/// Set the norm to use:
		/// L0: 0 when the projection is inside the input polygon, 1 otherwise
		/// L2: Euclidean distance between the projection and the polygon (default)
		/// </summary>
		// Token: 0x0601943E RID: 103486 RVA: 0x0023332F File Offset: 0x0023152F
		public void SetNorm(vtkImplicitProjectOnPlaneDistance.NormType n)
		{
			vtkImplicitProjectOnPlaneDistance.vtkImplicitProjectOnPlaneDistance_SetNorm_16(base.GetCppThis(), n);
		}

		// Token: 0x0601943F RID: 103487
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitProjectOnPlaneDistance_SetNorm_17(HandleRef pThis, int n);

		/// <summary>
		/// Set the norm to use:
		/// L0: 0 when the projection is inside the input polygon, 1 otherwise
		/// L2: Euclidean distance between the projection and the polygon (default)
		/// </summary>
		// Token: 0x06019440 RID: 103488 RVA: 0x0023333F File Offset: 0x0023153F
		public void SetNorm(int n)
		{
			vtkImplicitProjectOnPlaneDistance.vtkImplicitProjectOnPlaneDistance_SetNorm_17(base.GetCppThis(), n);
		}

		// Token: 0x06019441 RID: 103489
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitProjectOnPlaneDistance_SetTolerance_18(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/get the tolerance used for the locator.
		/// Default is 0.01.
		/// </summary>
		// Token: 0x06019442 RID: 103490 RVA: 0x0023334F File Offset: 0x0023154F
		public virtual void SetTolerance(double _arg)
		{
			vtkImplicitProjectOnPlaneDistance.vtkImplicitProjectOnPlaneDistance_SetTolerance_18(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BA5 RID: 7077
		public new const string MRFullTypeName = "Kitware.VTK.vtkImplicitProjectOnPlaneDistance";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BA6 RID: 7078
		public new static readonly string MRClassNameKey = "class vtkImplicitProjectOnPlaneDistance";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x02000977 RID: 2423
		public enum NormType
		{
			/// <summary>enum member</summary>
			// Token: 0x04001BA8 RID: 7080
			L0,
			/// <summary>enum member</summary>
			// Token: 0x04001BA9 RID: 7081
			L2 = 2
		}
	}
}
