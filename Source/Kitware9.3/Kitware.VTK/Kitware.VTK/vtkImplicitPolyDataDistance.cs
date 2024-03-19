using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImplicitPolyDataDistance
	/// </summary>
	/// <remarks>
	///    Implicit function that computes the distance from a point x to the nearest point p on an
	/// input vtkPolyData.
	///
	/// Implicit function that computes the distance from a point x to the
	/// nearest point p on an input vtkPolyData. The sign of the function
	/// is set to the sign of the dot product between the angle-weighted
	/// pseudonormal at the nearest surface point and the vector x - p.
	/// Points interior to the geometry have a negative distance, points on
	/// the exterior have a positive distance, and points on the input
	/// vtkPolyData have a distance of zero. The gradient of the function
	/// is the angle-weighted pseudonormal at the nearest point.
	///
	/// Baerentzen, J. A. and Aanaes, H. (2005). Signed distance
	/// computation using the angle weighted pseudonormal. IEEE
	/// Transactions on Visualization and Computer Graphics, 11:243-253.
	///
	/// This code was contributed in the VTK Journal paper:
	/// "Boolean Operations on Surfaces in VTK Without External Libraries"
	/// by Cory Quammen, Chris Weigle C., Russ Taylor
	/// http://hdl.handle.net/10380/3262
	/// http://www.midasjournal.org/browse/publication/797
	/// </remarks>
	// Token: 0x02000975 RID: 2421
	public class vtkImplicitPolyDataDistance : vtkImplicitFunction
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060193E3 RID: 103395 RVA: 0x00232B4B File Offset: 0x00230D4B
		static vtkImplicitPolyDataDistance()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImplicitPolyDataDistance.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImplicitPolyDataDistance"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060193E4 RID: 103396 RVA: 0x00232B73 File Offset: 0x00230D73
		public vtkImplicitPolyDataDistance(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060193E5 RID: 103397
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitPolyDataDistance_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060193E6 RID: 103398 RVA: 0x00232B84 File Offset: 0x00230D84
		public new static vtkImplicitPolyDataDistance New()
		{
			vtkImplicitPolyDataDistance result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitPolyDataDistance.vtkImplicitPolyDataDistance_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitPolyDataDistance)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060193E7 RID: 103399 RVA: 0x00232BD8 File Offset: 0x00230DD8
		public vtkImplicitPolyDataDistance() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImplicitPolyDataDistance.vtkImplicitPolyDataDistance_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060193E8 RID: 103400 RVA: 0x00232C1C File Offset: 0x00230E1C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060193E9 RID: 103401
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImplicitPolyDataDistance_EvaluateFunction_01(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Evaluate plane equation of nearest triangle to point x[3].
		/// </summary>
		// Token: 0x060193EA RID: 103402 RVA: 0x00232C28 File Offset: 0x00230E28
		public override double EvaluateFunction(IntPtr x)
		{
			return vtkImplicitPolyDataDistance.vtkImplicitPolyDataDistance_EvaluateFunction_01(base.GetCppThis(), x);
		}

		// Token: 0x060193EB RID: 103403
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImplicitPolyDataDistance_EvaluateFunctionAndGetClosestPoint_02(HandleRef pThis, IntPtr x, IntPtr closestPoint);

		/// <summary>
		/// Evaluate plane equation of nearest triangle to point x[3] and provides closest point on an
		/// input vtkPolyData.
		/// </summary>
		// Token: 0x060193EC RID: 103404 RVA: 0x00232C48 File Offset: 0x00230E48
		public double EvaluateFunctionAndGetClosestPoint(IntPtr x, IntPtr closestPoint)
		{
			return vtkImplicitPolyDataDistance.vtkImplicitPolyDataDistance_EvaluateFunctionAndGetClosestPoint_02(base.GetCppThis(), x, closestPoint);
		}

		// Token: 0x060193ED RID: 103405
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPolyDataDistance_EvaluateGradient_03(HandleRef pThis, IntPtr x, IntPtr g);

		/// <summary>
		/// Evaluate function gradient of nearest triangle to point x[3].
		/// </summary>
		// Token: 0x060193EE RID: 103406 RVA: 0x00232C69 File Offset: 0x00230E69
		public override void EvaluateGradient(IntPtr x, IntPtr g)
		{
			vtkImplicitPolyDataDistance.vtkImplicitPolyDataDistance_EvaluateGradient_03(base.GetCppThis(), x, g);
		}

		// Token: 0x060193EF RID: 103407
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkImplicitPolyDataDistance_GetMTime_04(HandleRef pThis);

		/// <summary>
		/// Return the MTime also considering the Input dependency.
		/// </summary>
		// Token: 0x060193F0 RID: 103408 RVA: 0x00232C7C File Offset: 0x00230E7C
		public override ulong GetMTime()
		{
			return vtkImplicitPolyDataDistance.vtkImplicitPolyDataDistance_GetMTime_04(base.GetCppThis());
		}

		// Token: 0x060193F1 RID: 103409
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitPolyDataDistance_GetNoClosestPoint_05(HandleRef pThis);

		/// <summary>
		/// Set/get the closest point to use if no input vtkPolyData
		/// specified.
		/// </summary>
		// Token: 0x060193F2 RID: 103410 RVA: 0x00232C9C File Offset: 0x00230E9C
		public virtual double[] GetNoClosestPoint()
		{
			IntPtr intPtr = vtkImplicitPolyDataDistance.vtkImplicitPolyDataDistance_GetNoClosestPoint_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060193F3 RID: 103411
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPolyDataDistance_GetNoClosestPoint_06(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/get the closest point to use if no input vtkPolyData
		/// specified.
		/// </summary>
		// Token: 0x060193F4 RID: 103412 RVA: 0x00232CE4 File Offset: 0x00230EE4
		public virtual void GetNoClosestPoint(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImplicitPolyDataDistance.vtkImplicitPolyDataDistance_GetNoClosestPoint_06(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060193F5 RID: 103413
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPolyDataDistance_GetNoClosestPoint_07(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/get the closest point to use if no input vtkPolyData
		/// specified.
		/// </summary>
		// Token: 0x060193F6 RID: 103414 RVA: 0x00232CF6 File Offset: 0x00230EF6
		public virtual void GetNoClosestPoint(IntPtr _arg)
		{
			vtkImplicitPolyDataDistance.vtkImplicitPolyDataDistance_GetNoClosestPoint_07(base.GetCppThis(), _arg);
		}

		// Token: 0x060193F7 RID: 103415
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitPolyDataDistance_GetNoGradient_08(HandleRef pThis);

		/// <summary>
		/// Set/get the function gradient to use if no input vtkPolyData
		/// specified.
		/// </summary>
		// Token: 0x060193F8 RID: 103416 RVA: 0x00232D08 File Offset: 0x00230F08
		public virtual double[] GetNoGradient()
		{
			IntPtr intPtr = vtkImplicitPolyDataDistance.vtkImplicitPolyDataDistance_GetNoGradient_08(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060193F9 RID: 103417
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPolyDataDistance_GetNoGradient_09(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/get the function gradient to use if no input vtkPolyData
		/// specified.
		/// </summary>
		// Token: 0x060193FA RID: 103418 RVA: 0x00232D50 File Offset: 0x00230F50
		public virtual void GetNoGradient(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImplicitPolyDataDistance.vtkImplicitPolyDataDistance_GetNoGradient_09(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060193FB RID: 103419
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPolyDataDistance_GetNoGradient_10(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/get the function gradient to use if no input vtkPolyData
		/// specified.
		/// </summary>
		// Token: 0x060193FC RID: 103420 RVA: 0x00232D62 File Offset: 0x00230F62
		public virtual void GetNoGradient(IntPtr _arg)
		{
			vtkImplicitPolyDataDistance.vtkImplicitPolyDataDistance_GetNoGradient_10(base.GetCppThis(), _arg);
		}

		// Token: 0x060193FD RID: 103421
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImplicitPolyDataDistance_GetNoValue_11(HandleRef pThis);

		/// <summary>
		/// Set/get the function value to use if no input vtkPolyData
		/// specified.
		/// </summary>
		// Token: 0x060193FE RID: 103422 RVA: 0x00232D74 File Offset: 0x00230F74
		public virtual double GetNoValue()
		{
			return vtkImplicitPolyDataDistance.vtkImplicitPolyDataDistance_GetNoValue_11(base.GetCppThis());
		}

		// Token: 0x060193FF RID: 103423
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImplicitPolyDataDistance_GetNumberOfGenerationsFromBase_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019400 RID: 103424 RVA: 0x00232D94 File Offset: 0x00230F94
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImplicitPolyDataDistance.vtkImplicitPolyDataDistance_GetNumberOfGenerationsFromBase_12(base.GetCppThis(), type);
		}

		// Token: 0x06019401 RID: 103425
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImplicitPolyDataDistance_GetNumberOfGenerationsFromBaseType_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019402 RID: 103426 RVA: 0x00232DB4 File Offset: 0x00230FB4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImplicitPolyDataDistance.vtkImplicitPolyDataDistance_GetNumberOfGenerationsFromBaseType_13(type);
		}

		// Token: 0x06019403 RID: 103427
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImplicitPolyDataDistance_GetTolerance_14(HandleRef pThis);

		/// <summary>
		/// Set/get the tolerance used for the locator.
		/// </summary>
		// Token: 0x06019404 RID: 103428 RVA: 0x00232DD0 File Offset: 0x00230FD0
		public virtual double GetTolerance()
		{
			return vtkImplicitPolyDataDistance.vtkImplicitPolyDataDistance_GetTolerance_14(base.GetCppThis());
		}

		// Token: 0x06019405 RID: 103429
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitPolyDataDistance_IsA_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019406 RID: 103430 RVA: 0x00232DF0 File Offset: 0x00230FF0
		public override int IsA(string type)
		{
			return vtkImplicitPolyDataDistance.vtkImplicitPolyDataDistance_IsA_15(base.GetCppThis(), type);
		}

		// Token: 0x06019407 RID: 103431
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitPolyDataDistance_IsTypeOf_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019408 RID: 103432 RVA: 0x00232E10 File Offset: 0x00231010
		public new static int IsTypeOf(string type)
		{
			return vtkImplicitPolyDataDistance.vtkImplicitPolyDataDistance_IsTypeOf_16(type);
		}

		// Token: 0x06019409 RID: 103433
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitPolyDataDistance_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601940A RID: 103434 RVA: 0x00232E2C File Offset: 0x0023102C
		public new vtkImplicitPolyDataDistance NewInstance()
		{
			vtkImplicitPolyDataDistance result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitPolyDataDistance.vtkImplicitPolyDataDistance_NewInstance_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitPolyDataDistance)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601940B RID: 103435
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitPolyDataDistance_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601940C RID: 103436 RVA: 0x00232E88 File Offset: 0x00231088
		public new static vtkImplicitPolyDataDistance SafeDownCast(vtkObjectBase o)
		{
			vtkImplicitPolyDataDistance vtkImplicitPolyDataDistance = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitPolyDataDistance.vtkImplicitPolyDataDistance_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitPolyDataDistance = (vtkImplicitPolyDataDistance)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitPolyDataDistance.Register(null);
				}
			}
			return vtkImplicitPolyDataDistance;
		}

		// Token: 0x0601940D RID: 103437
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPolyDataDistance_SetInput_20(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Set the input vtkPolyData used for the implicit function
		/// evaluation.  Passes input through an internal instance of
		/// vtkTriangleFilter to remove vertices and lines, leaving only
		/// triangular polygons for evaluation as implicit planes.
		/// </summary>
		// Token: 0x0601940E RID: 103438 RVA: 0x00232F08 File Offset: 0x00231108
		public void SetInput(vtkPolyData input)
		{
			vtkImplicitPolyDataDistance.vtkImplicitPolyDataDistance_SetInput_20(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x0601940F RID: 103439
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPolyDataDistance_SetNoClosestPoint_21(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/get the closest point to use if no input vtkPolyData
		/// specified.
		/// </summary>
		// Token: 0x06019410 RID: 103440 RVA: 0x00232F37 File Offset: 0x00231137
		public virtual void SetNoClosestPoint(double _arg1, double _arg2, double _arg3)
		{
			vtkImplicitPolyDataDistance.vtkImplicitPolyDataDistance_SetNoClosestPoint_21(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06019411 RID: 103441
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPolyDataDistance_SetNoClosestPoint_22(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/get the closest point to use if no input vtkPolyData
		/// specified.
		/// </summary>
		// Token: 0x06019412 RID: 103442 RVA: 0x00232F49 File Offset: 0x00231149
		public virtual void SetNoClosestPoint(IntPtr _arg)
		{
			vtkImplicitPolyDataDistance.vtkImplicitPolyDataDistance_SetNoClosestPoint_22(base.GetCppThis(), _arg);
		}

		// Token: 0x06019413 RID: 103443
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPolyDataDistance_SetNoGradient_23(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/get the function gradient to use if no input vtkPolyData
		/// specified.
		/// </summary>
		// Token: 0x06019414 RID: 103444 RVA: 0x00232F59 File Offset: 0x00231159
		public virtual void SetNoGradient(double _arg1, double _arg2, double _arg3)
		{
			vtkImplicitPolyDataDistance.vtkImplicitPolyDataDistance_SetNoGradient_23(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06019415 RID: 103445
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPolyDataDistance_SetNoGradient_24(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/get the function gradient to use if no input vtkPolyData
		/// specified.
		/// </summary>
		// Token: 0x06019416 RID: 103446 RVA: 0x00232F6B File Offset: 0x0023116B
		public virtual void SetNoGradient(IntPtr _arg)
		{
			vtkImplicitPolyDataDistance.vtkImplicitPolyDataDistance_SetNoGradient_24(base.GetCppThis(), _arg);
		}

		// Token: 0x06019417 RID: 103447
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPolyDataDistance_SetNoValue_25(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/get the function value to use if no input vtkPolyData
		/// specified.
		/// </summary>
		// Token: 0x06019418 RID: 103448 RVA: 0x00232F7B File Offset: 0x0023117B
		public virtual void SetNoValue(double _arg)
		{
			vtkImplicitPolyDataDistance.vtkImplicitPolyDataDistance_SetNoValue_25(base.GetCppThis(), _arg);
		}

		// Token: 0x06019419 RID: 103449
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitPolyDataDistance_SetTolerance_26(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/get the tolerance used for the locator.
		/// </summary>
		// Token: 0x0601941A RID: 103450 RVA: 0x00232F8B File Offset: 0x0023118B
		public virtual void SetTolerance(double _arg)
		{
			vtkImplicitPolyDataDistance.vtkImplicitPolyDataDistance_SetTolerance_26(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BA3 RID: 7075
		public new const string MRFullTypeName = "Kitware.VTK.vtkImplicitPolyDataDistance";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BA4 RID: 7076
		public new static readonly string MRClassNameKey = "class vtkImplicitPolyDataDistance";
	}
}
