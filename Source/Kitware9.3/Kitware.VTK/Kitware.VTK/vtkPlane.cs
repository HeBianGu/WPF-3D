using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPlane
	/// </summary>
	/// <remarks>
	///    perform various plane computations
	///
	/// vtkPlane provides methods for various plane computations. These include
	/// projecting points onto a plane, evaluating the plane equation, and
	/// returning plane normal. vtkPlane is a concrete implementation of the
	/// abstract class vtkImplicitFunction.
	/// </remarks>
	// Token: 0x02000A97 RID: 2711
	public class vtkPlane : vtkImplicitFunction
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601C705 RID: 116485 RVA: 0x0027F0A8 File Offset: 0x0027D2A8
		static vtkPlane()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPlane.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlane"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601C706 RID: 116486 RVA: 0x0027F0D0 File Offset: 0x0027D2D0
		public vtkPlane(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601C707 RID: 116487
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlane_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct plane passing through origin and normal to z-axis.
		/// </summary>
		// Token: 0x0601C708 RID: 116488 RVA: 0x0027F0E0 File Offset: 0x0027D2E0
		public new static vtkPlane New()
		{
			vtkPlane result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlane.vtkPlane_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlane)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct plane passing through origin and normal to z-axis.
		/// </summary>
		// Token: 0x0601C709 RID: 116489 RVA: 0x0027F134 File Offset: 0x0027D334
		public vtkPlane() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPlane.vtkPlane_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601C70A RID: 116490 RVA: 0x0027F178 File Offset: 0x0027D378
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601C70B RID: 116491
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlane_ComputeBestFittingPlane_01(HandleRef pts, IntPtr origin, IntPtr normal);

		/// <summary>
		/// Given a set of points calculate the best-fitting origin and normal for the plane.
		/// The origin will be the centroid of the points. The normal is determined
		/// by using the covariance matrix of the points relative to the centroid.
		/// Returns true if successful. If not successful the origin will still contain
		/// the centroid and the normal will point into z-direction.
		/// </summary>
		// Token: 0x0601C70C RID: 116492 RVA: 0x0027F184 File Offset: 0x0027D384
		public static bool ComputeBestFittingPlane(vtkPoints pts, IntPtr origin, IntPtr normal)
		{
			return vtkPlane.vtkPlane_ComputeBestFittingPlane_01((pts == null) ? default(HandleRef) : pts.GetCppThis(), origin, normal) != 0;
		}

		// Token: 0x0601C70D RID: 116493
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPlane_DistanceToPlane_02(IntPtr x, IntPtr n, IntPtr p0);

		/// <summary>
		/// Return the distance of a point x to a plane defined by n(x-p0) = 0. The
		/// normal n[3] must be magnitude=1.
		/// </summary>
		// Token: 0x0601C70E RID: 116494 RVA: 0x0027F1BC File Offset: 0x0027D3BC
		public static double DistanceToPlane(IntPtr x, IntPtr n, IntPtr p0)
		{
			return vtkPlane.vtkPlane_DistanceToPlane_02(x, n, p0);
		}

		// Token: 0x0601C70F RID: 116495
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPlane_DistanceToPlane_03(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Return the distance of a point x to a plane defined by n(x-p0) = 0. The
		/// normal n[3] must be magnitude=1.
		/// </summary>
		// Token: 0x0601C710 RID: 116496 RVA: 0x0027F1D8 File Offset: 0x0027D3D8
		public double DistanceToPlane(IntPtr x)
		{
			return vtkPlane.vtkPlane_DistanceToPlane_03(base.GetCppThis(), x);
		}

		// Token: 0x0601C711 RID: 116497
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPlane_Evaluate_04(IntPtr normal, IntPtr origin, IntPtr x);

		/// <summary>
		/// Quick evaluation of plane equation n(x-origin)=0.
		/// </summary>
		// Token: 0x0601C712 RID: 116498 RVA: 0x0027F1F8 File Offset: 0x0027D3F8
		public static double Evaluate(IntPtr normal, IntPtr origin, IntPtr x)
		{
			return vtkPlane.vtkPlane_Evaluate_04(normal, origin, x);
		}

		// Token: 0x0601C713 RID: 116499
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlane_EvaluateFunction_05(HandleRef pThis, HandleRef input, HandleRef output);

		/// <summary>
		/// Evaluate plane equation for point x[3].
		/// </summary>
		// Token: 0x0601C714 RID: 116500 RVA: 0x0027F214 File Offset: 0x0027D414
		public override void EvaluateFunction(vtkDataArray input, vtkDataArray output)
		{
			vtkPlane.vtkPlane_EvaluateFunction_05(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		// Token: 0x0601C715 RID: 116501
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPlane_EvaluateFunction_06(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Evaluate plane equation for point x[3].
		/// </summary>
		// Token: 0x0601C716 RID: 116502 RVA: 0x0027F258 File Offset: 0x0027D458
		public override double EvaluateFunction(IntPtr x)
		{
			return vtkPlane.vtkPlane_EvaluateFunction_06(base.GetCppThis(), x);
		}

		// Token: 0x0601C717 RID: 116503
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlane_EvaluateGradient_07(HandleRef pThis, IntPtr x, IntPtr g);

		/// <summary>
		/// Evaluate function gradient at point x[3].
		/// </summary>
		// Token: 0x0601C718 RID: 116504 RVA: 0x0027F278 File Offset: 0x0027D478
		public override void EvaluateGradient(IntPtr x, IntPtr g)
		{
			vtkPlane.vtkPlane_EvaluateGradient_07(base.GetCppThis(), x, g);
		}

		// Token: 0x0601C719 RID: 116505
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlane_GeneralizedProjectPoint_08(IntPtr x, IntPtr origin, IntPtr normal, IntPtr xproj);

		/// <summary>
		/// Project a point x onto plane defined by origin and normal. The
		/// projected point is returned in xproj. NOTE : normal does NOT have to
		/// have magnitude 1.
		/// </summary>
		// Token: 0x0601C71A RID: 116506 RVA: 0x0027F289 File Offset: 0x0027D489
		public static void GeneralizedProjectPoint(IntPtr x, IntPtr origin, IntPtr normal, IntPtr xproj)
		{
			vtkPlane.vtkPlane_GeneralizedProjectPoint_08(x, origin, normal, xproj);
		}

		// Token: 0x0601C71B RID: 116507
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlane_GeneralizedProjectPoint_09(HandleRef pThis, IntPtr x, IntPtr xproj);

		/// <summary>
		/// Project a point x onto plane defined by origin and normal. The
		/// projected point is returned in xproj. NOTE : normal does NOT have to
		/// have magnitude 1.
		/// </summary>
		// Token: 0x0601C71C RID: 116508 RVA: 0x0027F296 File Offset: 0x0027D496
		public void GeneralizedProjectPoint(IntPtr x, IntPtr xproj)
		{
			vtkPlane.vtkPlane_GeneralizedProjectPoint_09(base.GetCppThis(), x, xproj);
		}

		// Token: 0x0601C71D RID: 116509
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlane_GetNormal_10(HandleRef pThis);

		/// <summary>
		/// Set/get plane normal. Plane is defined by point and normal.
		/// </summary>
		// Token: 0x0601C71E RID: 116510 RVA: 0x0027F2A8 File Offset: 0x0027D4A8
		public virtual double[] GetNormal()
		{
			IntPtr intPtr = vtkPlane.vtkPlane_GetNormal_10(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601C71F RID: 116511
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlane_GetNormal_11(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/get plane normal. Plane is defined by point and normal.
		/// </summary>
		// Token: 0x0601C720 RID: 116512 RVA: 0x0027F2F0 File Offset: 0x0027D4F0
		public virtual void GetNormal(IntPtr data)
		{
			vtkPlane.vtkPlane_GetNormal_11(base.GetCppThis(), data);
		}

		// Token: 0x0601C721 RID: 116513
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlane_GetNumberOfGenerationsFromBase_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct plane passing through origin and normal to z-axis.
		/// </summary>
		// Token: 0x0601C722 RID: 116514 RVA: 0x0027F300 File Offset: 0x0027D500
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPlane.vtkPlane_GetNumberOfGenerationsFromBase_12(base.GetCppThis(), type);
		}

		// Token: 0x0601C723 RID: 116515
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlane_GetNumberOfGenerationsFromBaseType_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct plane passing through origin and normal to z-axis.
		/// </summary>
		// Token: 0x0601C724 RID: 116516 RVA: 0x0027F320 File Offset: 0x0027D520
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPlane.vtkPlane_GetNumberOfGenerationsFromBaseType_13(type);
		}

		// Token: 0x0601C725 RID: 116517
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlane_GetOrigin_14(HandleRef pThis);

		/// <summary>
		/// Set/get point through which plane passes. Plane is defined by point
		/// and normal.
		/// </summary>
		// Token: 0x0601C726 RID: 116518 RVA: 0x0027F33C File Offset: 0x0027D53C
		public virtual double[] GetOrigin()
		{
			IntPtr intPtr = vtkPlane.vtkPlane_GetOrigin_14(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601C727 RID: 116519
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlane_GetOrigin_15(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/get point through which plane passes. Plane is defined by point
		/// and normal.
		/// </summary>
		// Token: 0x0601C728 RID: 116520 RVA: 0x0027F384 File Offset: 0x0027D584
		public virtual void GetOrigin(IntPtr data)
		{
			vtkPlane.vtkPlane_GetOrigin_15(base.GetCppThis(), data);
		}

		// Token: 0x0601C729 RID: 116521
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlane_IntersectWithFinitePlane_16(IntPtr n, IntPtr o, IntPtr pOrigin, IntPtr px, IntPtr py, IntPtr x0, IntPtr x1);

		/// <summary>
		/// Given two planes, one infinite and one finite, defined by the normal n
		/// and point o (infinite plane), and the second finite plane1 defined by
		/// the three points (pOrigin,px,py), compute a line of intersection (if
		/// any). The line of intersection is defined by the return values
		/// (x0,x1). If there is no intersection, then zero is returned; otherwise
		/// non-zero. There are two variants of this method. The static function
		/// operates on the supplied function parameters; the non-static operates on
		/// this instance of vtkPlane (and its associated origin and normal).
		/// </summary>
		// Token: 0x0601C72A RID: 116522 RVA: 0x0027F394 File Offset: 0x0027D594
		public static int IntersectWithFinitePlane(IntPtr n, IntPtr o, IntPtr pOrigin, IntPtr px, IntPtr py, IntPtr x0, IntPtr x1)
		{
			return vtkPlane.vtkPlane_IntersectWithFinitePlane_16(n, o, pOrigin, px, py, x0, x1);
		}

		// Token: 0x0601C72B RID: 116523
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlane_IntersectWithFinitePlane_17(HandleRef pThis, IntPtr pOrigin, IntPtr px, IntPtr py, IntPtr x0, IntPtr x1);

		/// <summary>
		/// Given two planes, one infinite and one finite, defined by the normal n
		/// and point o (infinite plane), and the second finite plane1 defined by
		/// the three points (pOrigin,px,py), compute a line of intersection (if
		/// any). The line of intersection is defined by the return values
		/// (x0,x1). If there is no intersection, then zero is returned; otherwise
		/// non-zero. There are two variants of this method. The static function
		/// operates on the supplied function parameters; the non-static operates on
		/// this instance of vtkPlane (and its associated origin and normal).
		/// </summary>
		// Token: 0x0601C72C RID: 116524 RVA: 0x0027F3B8 File Offset: 0x0027D5B8
		public int IntersectWithFinitePlane(IntPtr pOrigin, IntPtr px, IntPtr py, IntPtr x0, IntPtr x1)
		{
			return vtkPlane.vtkPlane_IntersectWithFinitePlane_17(base.GetCppThis(), pOrigin, px, py, x0, x1);
		}

		// Token: 0x0601C72D RID: 116525
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlane_IntersectWithLine_18(IntPtr p1, IntPtr p2, IntPtr n, IntPtr p0, ref double t, IntPtr x);

		/// <summary>
		/// Given a line defined by the two points p1,p2; and a plane defined by the
		/// normal n and point p0, compute an intersection. The parametric
		/// coordinate along the line is returned in t, and the coordinates of
		/// intersection are returned in x. A zero is returned if the plane and line
		/// do not intersect between (0&lt;=t&lt;=1). If the plane and line are parallel,
		/// zero is returned and t is set to VTK_LARGE_DOUBLE.
		/// </summary>
		// Token: 0x0601C72E RID: 116526 RVA: 0x0027F3E0 File Offset: 0x0027D5E0
		public static int IntersectWithLine(IntPtr p1, IntPtr p2, IntPtr n, IntPtr p0, ref double t, IntPtr x)
		{
			return vtkPlane.vtkPlane_IntersectWithLine_18(p1, p2, n, p0, ref t, x);
		}

		// Token: 0x0601C72F RID: 116527
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlane_IntersectWithLine_19(HandleRef pThis, IntPtr p1, IntPtr p2, ref double t, IntPtr x);

		/// <summary>
		/// Given a line defined by the two points p1,p2; and a plane defined by the
		/// normal n and point p0, compute an intersection. The parametric
		/// coordinate along the line is returned in t, and the coordinates of
		/// intersection are returned in x. A zero is returned if the plane and line
		/// do not intersect between (0&lt;=t&lt;=1). If the plane and line are parallel,
		/// zero is returned and t is set to VTK_LARGE_DOUBLE.
		/// </summary>
		// Token: 0x0601C730 RID: 116528 RVA: 0x0027F404 File Offset: 0x0027D604
		public int IntersectWithLine(IntPtr p1, IntPtr p2, ref double t, IntPtr x)
		{
			return vtkPlane.vtkPlane_IntersectWithLine_19(base.GetCppThis(), p1, p2, ref t, x);
		}

		// Token: 0x0601C731 RID: 116529
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlane_IsA_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct plane passing through origin and normal to z-axis.
		/// </summary>
		// Token: 0x0601C732 RID: 116530 RVA: 0x0027F428 File Offset: 0x0027D628
		public override int IsA(string type)
		{
			return vtkPlane.vtkPlane_IsA_20(base.GetCppThis(), type);
		}

		// Token: 0x0601C733 RID: 116531
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlane_IsTypeOf_21([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct plane passing through origin and normal to z-axis.
		/// </summary>
		// Token: 0x0601C734 RID: 116532 RVA: 0x0027F448 File Offset: 0x0027D648
		public new static int IsTypeOf(string type)
		{
			return vtkPlane.vtkPlane_IsTypeOf_21(type);
		}

		// Token: 0x0601C735 RID: 116533
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlane_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct plane passing through origin and normal to z-axis.
		/// </summary>
		// Token: 0x0601C736 RID: 116534 RVA: 0x0027F464 File Offset: 0x0027D664
		public new vtkPlane NewInstance()
		{
			vtkPlane result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlane.vtkPlane_NewInstance_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlane)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601C737 RID: 116535
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlane_ProjectPoint_24(IntPtr x, IntPtr origin, IntPtr normal, IntPtr xproj);

		/// <summary>
		/// Project a point x onto plane defined by origin and normal. The
		/// projected point is returned in xproj. NOTE : normal assumed to
		/// have magnitude 1.
		/// </summary>
		// Token: 0x0601C738 RID: 116536 RVA: 0x0027F4BE File Offset: 0x0027D6BE
		public static void ProjectPoint(IntPtr x, IntPtr origin, IntPtr normal, IntPtr xproj)
		{
			vtkPlane.vtkPlane_ProjectPoint_24(x, origin, normal, xproj);
		}

		// Token: 0x0601C739 RID: 116537
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlane_ProjectPoint_25(HandleRef pThis, IntPtr x, IntPtr xproj);

		/// <summary>
		/// Project a point x onto plane defined by origin and normal. The
		/// projected point is returned in xproj. NOTE : normal assumed to
		/// have magnitude 1.
		/// </summary>
		// Token: 0x0601C73A RID: 116538 RVA: 0x0027F4CB File Offset: 0x0027D6CB
		public void ProjectPoint(IntPtr x, IntPtr xproj)
		{
			vtkPlane.vtkPlane_ProjectPoint_25(base.GetCppThis(), x, xproj);
		}

		// Token: 0x0601C73B RID: 116539
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlane_ProjectVector_26(IntPtr v, IntPtr origin, IntPtr normal, IntPtr vproj);

		/// <summary>
		/// Project a vector v onto plane defined by origin and normal. The
		/// projected vector is returned in vproj.
		/// </summary>
		// Token: 0x0601C73C RID: 116540 RVA: 0x0027F4DC File Offset: 0x0027D6DC
		public static void ProjectVector(IntPtr v, IntPtr origin, IntPtr normal, IntPtr vproj)
		{
			vtkPlane.vtkPlane_ProjectVector_26(v, origin, normal, vproj);
		}

		// Token: 0x0601C73D RID: 116541
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlane_ProjectVector_27(HandleRef pThis, IntPtr v, IntPtr vproj);

		/// <summary>
		/// Project a vector v onto plane defined by origin and normal. The
		/// projected vector is returned in vproj.
		/// </summary>
		// Token: 0x0601C73E RID: 116542 RVA: 0x0027F4E9 File Offset: 0x0027D6E9
		public void ProjectVector(IntPtr v, IntPtr vproj)
		{
			vtkPlane.vtkPlane_ProjectVector_27(base.GetCppThis(), v, vproj);
		}

		// Token: 0x0601C73F RID: 116543
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlane_Push_28(HandleRef pThis, double distance);

		/// <summary>
		/// Translate the plane in the direction of the normal by the
		/// distance specified.  Negative values move the plane in the
		/// opposite direction.
		/// </summary>
		// Token: 0x0601C740 RID: 116544 RVA: 0x0027F4FA File Offset: 0x0027D6FA
		public void Push(double distance)
		{
			vtkPlane.vtkPlane_Push_28(base.GetCppThis(), distance);
		}

		// Token: 0x0601C741 RID: 116545
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlane_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct plane passing through origin and normal to z-axis.
		/// </summary>
		// Token: 0x0601C742 RID: 116546 RVA: 0x0027F50C File Offset: 0x0027D70C
		public new static vtkPlane SafeDownCast(vtkObjectBase o)
		{
			vtkPlane vtkPlane = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlane.vtkPlane_SafeDownCast_29((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlane = (vtkPlane)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlane.Register(null);
				}
			}
			return vtkPlane;
		}

		// Token: 0x0601C743 RID: 116547
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlane_SetNormal_30(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/get plane normal. Plane is defined by point and normal.
		/// </summary>
		// Token: 0x0601C744 RID: 116548 RVA: 0x0027F58B File Offset: 0x0027D78B
		public virtual void SetNormal(double _arg1, double _arg2, double _arg3)
		{
			vtkPlane.vtkPlane_SetNormal_30(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0601C745 RID: 116549
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlane_SetNormal_31(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/get plane normal. Plane is defined by point and normal.
		/// </summary>
		// Token: 0x0601C746 RID: 116550 RVA: 0x0027F59D File Offset: 0x0027D79D
		public virtual void SetNormal(IntPtr _arg)
		{
			vtkPlane.vtkPlane_SetNormal_31(base.GetCppThis(), _arg);
		}

		// Token: 0x0601C747 RID: 116551
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlane_SetOrigin_32(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/get point through which plane passes. Plane is defined by point
		/// and normal.
		/// </summary>
		// Token: 0x0601C748 RID: 116552 RVA: 0x0027F5AD File Offset: 0x0027D7AD
		public virtual void SetOrigin(double _arg1, double _arg2, double _arg3)
		{
			vtkPlane.vtkPlane_SetOrigin_32(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0601C749 RID: 116553
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlane_SetOrigin_33(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/get point through which plane passes. Plane is defined by point
		/// and normal.
		/// </summary>
		// Token: 0x0601C74A RID: 116554 RVA: 0x0027F5BF File Offset: 0x0027D7BF
		public virtual void SetOrigin(IntPtr _arg)
		{
			vtkPlane.vtkPlane_SetOrigin_33(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E2F RID: 7727
		public new const string MRFullTypeName = "Kitware.VTK.vtkPlane";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E30 RID: 7728
		public new static readonly string MRClassNameKey = "class vtkPlane";
	}
}
