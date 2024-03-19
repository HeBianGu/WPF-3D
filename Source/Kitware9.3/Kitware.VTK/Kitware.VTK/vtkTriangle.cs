using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTriangle
	/// </summary>
	/// <remarks>
	///    a cell that represents a triangle
	///
	/// vtkTriangle is a concrete implementation of vtkCell to represent a triangle
	/// located in 3-space.
	/// </remarks>
	// Token: 0x02000ADB RID: 2779
	public class vtkTriangle : vtkCell
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D440 RID: 119872 RVA: 0x00294919 File Offset: 0x00292B19
		static vtkTriangle()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTriangle.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTriangle"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D441 RID: 119873 RVA: 0x00294941 File Offset: 0x00292B41
		public vtkTriangle(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601D442 RID: 119874
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTriangle_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D443 RID: 119875 RVA: 0x00294950 File Offset: 0x00292B50
		public new static vtkTriangle New()
		{
			vtkTriangle result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTriangle.vtkTriangle_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTriangle)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D444 RID: 119876 RVA: 0x002949A4 File Offset: 0x00292BA4
		public vtkTriangle() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTriangle.vtkTriangle_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D445 RID: 119877 RVA: 0x002949E8 File Offset: 0x00292BE8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D446 RID: 119878
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriangle_BarycentricCoords_01(IntPtr x, IntPtr x1, IntPtr x2, IntPtr x3, IntPtr bcoords);

		/// <summary>
		/// Given a 2D point x[2], determine the barycentric coordinates of the point.
		/// Barycentric coordinates are a natural coordinate system for simplices that
		/// express a position as a linear combination of the vertices. For a
		/// triangle, there are three barycentric coordinates (because there are
		/// three vertices), and the sum of the coordinates must equal 1. If a
		/// point x is inside a simplex, then all three coordinates will be strictly
		/// positive.  If two coordinates are zero (so the third =1), then the
		/// point x is on a vertex. If one coordinates are zero, the point x is on an
		/// edge. In this method, you must specify the vertex coordinates x1-&gt;x3.
		/// Returns 0 if triangle is degenerate.
		/// </summary>
		// Token: 0x0601D447 RID: 119879 RVA: 0x002949F4 File Offset: 0x00292BF4
		public static int BarycentricCoords(IntPtr x, IntPtr x1, IntPtr x2, IntPtr x3, IntPtr bcoords)
		{
			return vtkTriangle.vtkTriangle_BarycentricCoords_01(x, x1, x2, x3, bcoords);
		}

		// Token: 0x0601D448 RID: 119880
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriangle_CellBoundary_02(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D449 RID: 119881 RVA: 0x00294A14 File Offset: 0x00292C14
		public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
		{
			return vtkTriangle.vtkTriangle_CellBoundary_02(base.GetCppThis(), subId, pcoords, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601D44A RID: 119882
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTriangle_Circumcircle_03(IntPtr p1, IntPtr p2, IntPtr p3, IntPtr center);

		/// <summary>
		/// Compute the circumcenter (center[3]) and radius squared (method
		/// return value) of a triangle defined by the three points x1, x2,
		/// and x3. (Note that the coordinates are 2D. 3D points can be used
		/// but the z-component will be ignored.)
		/// </summary>
		// Token: 0x0601D44B RID: 119883 RVA: 0x00294A4C File Offset: 0x00292C4C
		public static double Circumcircle(IntPtr p1, IntPtr p2, IntPtr p3, IntPtr center)
		{
			return vtkTriangle.vtkTriangle_Circumcircle_03(p1, p2, p3, center);
		}

		// Token: 0x0601D44C RID: 119884
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTriangle_Clip_04(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

		/// <summary>
		/// Clip this triangle using scalar value provided. Like contouring, except
		/// that it cuts the triangle to produce other triangles.
		/// </summary>
		// Token: 0x0601D44D RID: 119885 RVA: 0x00294A6C File Offset: 0x00292C6C
		public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
		{
			vtkTriangle.vtkTriangle_Clip_04(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis(), insideOut);
		}

		// Token: 0x0601D44E RID: 119886
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTriangle_ComputeArea_05(HandleRef pThis);

		/// <summary>
		/// A convenience function to compute the area of a vtkTriangle.
		/// </summary>
		// Token: 0x0601D44F RID: 119887 RVA: 0x00294B28 File Offset: 0x00292D28
		public double ComputeArea()
		{
			return vtkTriangle.vtkTriangle_ComputeArea_05(base.GetCppThis());
		}

		// Token: 0x0601D450 RID: 119888
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTriangle_ComputeCentroid_06(HandleRef points, IntPtr pointIds, IntPtr centroid);

		/// <summary>
		/// Get the centroid of the triangle.
		/// pointIds can be nullptr if ids are {0, 1, 2}
		/// </summary>
		// Token: 0x0601D451 RID: 119889 RVA: 0x00294B48 File Offset: 0x00292D48
		public static bool ComputeCentroid(vtkPoints points, IntPtr pointIds, IntPtr centroid)
		{
			return vtkTriangle.vtkTriangle_ComputeCentroid_06((points == null) ? default(HandleRef) : points.GetCppThis(), pointIds, centroid) != 0;
		}

		// Token: 0x0601D452 RID: 119890
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTriangle_ComputeNormal_07(HandleRef p, int numPts, IntPtr pts, IntPtr n);

		/// <summary>
		/// Compute the triangle normal from a points list, and a list of point ids
		/// that index into the points list.
		/// </summary>
		// Token: 0x0601D453 RID: 119891 RVA: 0x00294B80 File Offset: 0x00292D80
		public static void ComputeNormal(vtkPoints p, int numPts, IntPtr pts, IntPtr n)
		{
			vtkTriangle.vtkTriangle_ComputeNormal_07((p == null) ? default(HandleRef) : p.GetCppThis(), numPts, pts, n);
		}

		// Token: 0x0601D454 RID: 119892
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTriangle_ComputeNormal_08(IntPtr v1, IntPtr v2, IntPtr v3, IntPtr n);

		/// <summary>
		/// Compute the triangle normal from three points.
		/// </summary>
		// Token: 0x0601D455 RID: 119893 RVA: 0x00294BAC File Offset: 0x00292DAC
		public static void ComputeNormal(IntPtr v1, IntPtr v2, IntPtr v3, IntPtr n)
		{
			vtkTriangle.vtkTriangle_ComputeNormal_08(v1, v2, v3, n);
		}

		// Token: 0x0601D456 RID: 119894
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTriangle_ComputeNormalDirection_09(IntPtr v1, IntPtr v2, IntPtr v3, IntPtr n);

		/// <summary>
		/// Compute the (unnormalized) triangle normal direction from three points.
		/// </summary>
		// Token: 0x0601D457 RID: 119895 RVA: 0x00294BB9 File Offset: 0x00292DB9
		public static void ComputeNormalDirection(IntPtr v1, IntPtr v2, IntPtr v3, IntPtr n)
		{
			vtkTriangle.vtkTriangle_ComputeNormalDirection_09(v1, v2, v3, n);
		}

		// Token: 0x0601D458 RID: 119896
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTriangle_ComputeQuadric_10(IntPtr x1, IntPtr x2, IntPtr x3, HandleRef quadric);

		/// <summary>
		/// Calculate the error quadric for this triangle.  Return the
		/// quadric as a 4x4 matrix or a vtkQuadric.  (from Peter
		/// Lindstrom's Siggraph 2000 paper, "Out-of-Core Simplification of
		/// Large Polygonal Models")
		/// </summary>
		// Token: 0x0601D459 RID: 119897 RVA: 0x00294BC8 File Offset: 0x00292DC8
		public static void ComputeQuadric(IntPtr x1, IntPtr x2, IntPtr x3, vtkQuadric quadric)
		{
			vtkTriangle.vtkTriangle_ComputeQuadric_10(x1, x2, x3, (quadric == null) ? default(HandleRef) : quadric.GetCppThis());
		}

		// Token: 0x0601D45A RID: 119898
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTriangle_Contour_11(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D45B RID: 119899 RVA: 0x00294BF4 File Offset: 0x00292DF4
		public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
		{
			vtkTriangle.vtkTriangle_Contour_11(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis());
		}

		// Token: 0x0601D45C RID: 119900
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTriangle_Derivatives_12(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D45D RID: 119901 RVA: 0x00294CDC File Offset: 0x00292EDC
		public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
		{
			vtkTriangle.vtkTriangle_Derivatives_12(base.GetCppThis(), subId, pcoords, values, dim, derivs);
		}

		// Token: 0x0601D45E RID: 119902
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTriangle_EvaluateLocation_13(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D45F RID: 119903 RVA: 0x00294CF2 File Offset: 0x00292EF2
		public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
		{
			vtkTriangle.vtkTriangle_EvaluateLocation_13(base.GetCppThis(), ref subId, pcoords, x, weights);
		}

		// Token: 0x0601D460 RID: 119904
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriangle_EvaluatePosition_14(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D461 RID: 119905 RVA: 0x00294D08 File Offset: 0x00292F08
		public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
		{
			return vtkTriangle.vtkTriangle_EvaluatePosition_14(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
		}

		// Token: 0x0601D462 RID: 119906
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriangle_GetCellDimension_15(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D463 RID: 119907 RVA: 0x00294D30 File Offset: 0x00292F30
		public override int GetCellDimension()
		{
			return vtkTriangle.vtkTriangle_GetCellDimension_15(base.GetCppThis());
		}

		// Token: 0x0601D464 RID: 119908
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriangle_GetCellType_16(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D465 RID: 119909 RVA: 0x00294D50 File Offset: 0x00292F50
		public override int GetCellType()
		{
			return vtkTriangle.vtkTriangle_GetCellType_16(base.GetCppThis());
		}

		// Token: 0x0601D466 RID: 119910
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTriangle_GetEdge_17(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the edge specified by edgeId (range 0 to 2) and return that edge's
		/// coordinates.
		/// </summary>
		// Token: 0x0601D467 RID: 119911 RVA: 0x00294D70 File Offset: 0x00292F70
		public override vtkCell GetEdge(int edgeId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTriangle.vtkTriangle_GetEdge_17(base.GetCppThis(), edgeId, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCell = (vtkCell)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCell.Register(null);
				}
			}
			return vtkCell;
		}

		// Token: 0x0601D468 RID: 119912
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTriangle_GetEdgeArray_18(HandleRef pThis, long edgeId);

		/// <summary>
		/// Return the ids of the vertices defining edge (`edgeId`).
		/// Ids are related to the cell, not to the dataset.
		///
		/// @note The return type changed. It used to be int*, it is now const vtkIdType*.
		/// This is so ids are unified between vtkCell and vtkPoints, and so vtkCell ids
		/// can be used as inputs in algorithms such as vtkPolygon::ComputeNormal.
		/// </summary>
		// Token: 0x0601D469 RID: 119913 RVA: 0x00294DE0 File Offset: 0x00292FE0
		public IntPtr GetEdgeArray(long edgeId)
		{
			return vtkTriangle.vtkTriangle_GetEdgeArray_18(base.GetCppThis(), edgeId);
		}

		// Token: 0x0601D46A RID: 119914
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTriangle_GetFace_19(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D46B RID: 119915 RVA: 0x00294E00 File Offset: 0x00293000
		public override vtkCell GetFace(int arg0)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTriangle.vtkTriangle_GetFace_19(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCell = (vtkCell)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCell.Register(null);
				}
			}
			return vtkCell;
		}

		// Token: 0x0601D46C RID: 119916
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriangle_GetNumberOfEdges_20(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D46D RID: 119917 RVA: 0x00294E70 File Offset: 0x00293070
		public override int GetNumberOfEdges()
		{
			return vtkTriangle.vtkTriangle_GetNumberOfEdges_20(base.GetCppThis());
		}

		// Token: 0x0601D46E RID: 119918
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriangle_GetNumberOfFaces_21(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D46F RID: 119919 RVA: 0x00294E90 File Offset: 0x00293090
		public override int GetNumberOfFaces()
		{
			return vtkTriangle.vtkTriangle_GetNumberOfFaces_21(base.GetCppThis());
		}

		// Token: 0x0601D470 RID: 119920
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTriangle_GetNumberOfGenerationsFromBase_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D471 RID: 119921 RVA: 0x00294EB0 File Offset: 0x002930B0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTriangle.vtkTriangle_GetNumberOfGenerationsFromBase_22(base.GetCppThis(), type);
		}

		// Token: 0x0601D472 RID: 119922
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTriangle_GetNumberOfGenerationsFromBaseType_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D473 RID: 119923 RVA: 0x00294ED0 File Offset: 0x002930D0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTriangle.vtkTriangle_GetNumberOfGenerationsFromBaseType_23(type);
		}

		// Token: 0x0601D474 RID: 119924
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriangle_GetParametricCenter_24(HandleRef pThis, IntPtr pcoords);

		/// <summary>
		/// Return the center of the triangle in parametric coordinates.
		/// </summary>
		// Token: 0x0601D475 RID: 119925 RVA: 0x00294EEC File Offset: 0x002930EC
		public override int GetParametricCenter(IntPtr pcoords)
		{
			return vtkTriangle.vtkTriangle_GetParametricCenter_24(base.GetCppThis(), pcoords);
		}

		// Token: 0x0601D476 RID: 119926
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTriangle_GetParametricCoords_25(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D477 RID: 119927 RVA: 0x00294F0C File Offset: 0x0029310C
		public override IntPtr GetParametricCoords()
		{
			return vtkTriangle.vtkTriangle_GetParametricCoords_25(base.GetCppThis());
		}

		// Token: 0x0601D478 RID: 119928
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTriangle_GetParametricDistance_26(HandleRef pThis, IntPtr pcoords);

		/// <summary>
		/// Return the distance of the parametric coordinate provided to the
		/// cell. If inside the cell, a distance of zero is returned.
		/// </summary>
		// Token: 0x0601D479 RID: 119929 RVA: 0x00294F2C File Offset: 0x0029312C
		public override double GetParametricDistance(IntPtr pcoords)
		{
			return vtkTriangle.vtkTriangle_GetParametricDistance_26(base.GetCppThis(), pcoords);
		}

		// Token: 0x0601D47A RID: 119930
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTriangle_InterpolateDerivs_27(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601D47B RID: 119931 RVA: 0x00294F4C File Offset: 0x0029314C
		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkTriangle.vtkTriangle_InterpolateDerivs_27(base.GetCppThis(), pcoords, derivs);
		}

		// Token: 0x0601D47C RID: 119932
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTriangle_InterpolateFunctions_28(HandleRef pThis, IntPtr pcoords, IntPtr sf);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601D47D RID: 119933 RVA: 0x00294F5D File Offset: 0x0029315D
		public override void InterpolateFunctions(IntPtr pcoords, IntPtr sf)
		{
			vtkTriangle.vtkTriangle_InterpolateFunctions_28(base.GetCppThis(), pcoords, sf);
		}

		// Token: 0x0601D47E RID: 119934
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTriangle_InterpolationDerivs_29(IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Clip this triangle using scalar value provided. Like contouring, except
		/// that it cuts the triangle to produce other triangles.
		/// </summary>
		// Token: 0x0601D47F RID: 119935 RVA: 0x00294F6E File Offset: 0x0029316E
		public static void InterpolationDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkTriangle.vtkTriangle_InterpolationDerivs_29(pcoords, derivs);
		}

		// Token: 0x0601D480 RID: 119936
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTriangle_InterpolationFunctions_30(IntPtr pcoords, IntPtr sf);

		/// <summary>
		/// Clip this triangle using scalar value provided. Like contouring, except
		/// that it cuts the triangle to produce other triangles.
		/// </summary>
		// Token: 0x0601D481 RID: 119937 RVA: 0x00294F79 File Offset: 0x00293179
		public static void InterpolationFunctions(IntPtr pcoords, IntPtr sf)
		{
			vtkTriangle.vtkTriangle_InterpolationFunctions_30(pcoords, sf);
		}

		// Token: 0x0601D482 RID: 119938
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriangle_IntersectWithLine_31(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		/// <summary>
		/// Given a line defined by two points p1 and p2, determine whether it intersects the triangle.
		/// The tolerance tol is used to verify whether the intersection is inside or outside of the
		/// triangle. If the line and triangle are coplanar and there is intersection, the intersecting
		/// point is chosen as the point closest to p1 that is inside the triangle.
		/// </summary>
		// Token: 0x0601D483 RID: 119939 RVA: 0x00294F84 File Offset: 0x00293184
		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkTriangle.vtkTriangle_IntersectWithLine_31(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		// Token: 0x0601D484 RID: 119940
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriangle_IsA_32(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D485 RID: 119941 RVA: 0x00294FB0 File Offset: 0x002931B0
		public override int IsA(string type)
		{
			return vtkTriangle.vtkTriangle_IsA_32(base.GetCppThis(), type);
		}

		// Token: 0x0601D486 RID: 119942
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriangle_IsTypeOf_33([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D487 RID: 119943 RVA: 0x00294FD0 File Offset: 0x002931D0
		public new static int IsTypeOf(string type)
		{
			return vtkTriangle.vtkTriangle_IsTypeOf_33(type);
		}

		// Token: 0x0601D488 RID: 119944
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTriangle_NewInstance_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D489 RID: 119945 RVA: 0x00294FEC File Offset: 0x002931EC
		public new vtkTriangle NewInstance()
		{
			vtkTriangle result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTriangle.vtkTriangle_NewInstance_35(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTriangle)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601D48A RID: 119946
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriangle_PointInTriangle_36(IntPtr x, IntPtr x1, IntPtr x2, IntPtr x3, double tol2);

		/// <summary>
		/// Compute the (unnormalized) triangle normal direction from three points.
		/// </summary>
		// Token: 0x0601D48B RID: 119947 RVA: 0x00295048 File Offset: 0x00293248
		public static int PointInTriangle(IntPtr x, IntPtr x1, IntPtr x2, IntPtr x3, double tol2)
		{
			return vtkTriangle.vtkTriangle_PointInTriangle_36(x, x1, x2, x3, tol2);
		}

		// Token: 0x0601D48C RID: 119948
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriangle_ProjectTo2D_37(IntPtr x1, IntPtr x2, IntPtr x3, IntPtr v1, IntPtr v2, IntPtr v3);

		/// <summary>
		/// Project triangle defined in 3D to 2D coordinates. Returns 0 if
		/// degenerate triangle; non-zero value otherwise. Input points are x1-&gt;x3;
		/// output 2D points are v1-&gt;v3.
		/// </summary>
		// Token: 0x0601D48D RID: 119949 RVA: 0x00295068 File Offset: 0x00293268
		public static int ProjectTo2D(IntPtr x1, IntPtr x2, IntPtr x3, IntPtr v1, IntPtr v2, IntPtr v3)
		{
			return vtkTriangle.vtkTriangle_ProjectTo2D_37(x1, x2, x3, v1, v2, v3);
		}

		// Token: 0x0601D48E RID: 119950
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTriangle_SafeDownCast_38(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D48F RID: 119951 RVA: 0x0029508C File Offset: 0x0029328C
		public new static vtkTriangle SafeDownCast(vtkObjectBase o)
		{
			vtkTriangle vtkTriangle = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTriangle.vtkTriangle_SafeDownCast_38((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTriangle = (vtkTriangle)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTriangle.Register(null);
				}
			}
			return vtkTriangle;
		}

		// Token: 0x0601D490 RID: 119952
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTriangle_TriangleArea_39(IntPtr p1, IntPtr p2, IntPtr p3);

		/// <summary>
		/// Compute the area of a triangle in 3D.
		/// See also vtkTriangle::ComputeArea()
		/// </summary>
		// Token: 0x0601D491 RID: 119953 RVA: 0x0029510C File Offset: 0x0029330C
		public static double TriangleArea(IntPtr p1, IntPtr p2, IntPtr p3)
		{
			return vtkTriangle.vtkTriangle_TriangleArea_39(p1, p2, p3);
		}

		// Token: 0x0601D492 RID: 119954
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTriangle_TriangleCenter_40(IntPtr p1, IntPtr p2, IntPtr p3, IntPtr center);

		/// <summary>
		/// Compute the center of the triangle.
		/// </summary>
		// Token: 0x0601D493 RID: 119955 RVA: 0x00295128 File Offset: 0x00293328
		public static void TriangleCenter(IntPtr p1, IntPtr p2, IntPtr p3, IntPtr center)
		{
			vtkTriangle.vtkTriangle_TriangleCenter_40(p1, p2, p3, center);
		}

		// Token: 0x0601D494 RID: 119956
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriangle_TrianglesIntersect_41(IntPtr p1, IntPtr q1, IntPtr r1, IntPtr p2, IntPtr q2, IntPtr r2);

		/// <summary>
		/// Compute the (unnormalized) triangle normal direction from three points.
		/// </summary>
		// Token: 0x0601D495 RID: 119957 RVA: 0x00295138 File Offset: 0x00293338
		public static int TrianglesIntersect(IntPtr p1, IntPtr q1, IntPtr r1, IntPtr p2, IntPtr q2, IntPtr r2)
		{
			return vtkTriangle.vtkTriangle_TrianglesIntersect_41(p1, q1, r1, p2, q2, r2);
		}

		// Token: 0x0601D496 RID: 119958
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriangle_TriangulateLocalIds_42(HandleRef pThis, int index, HandleRef ptIds);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D497 RID: 119959 RVA: 0x0029515C File Offset: 0x0029335C
		public override int TriangulateLocalIds(int index, vtkIdList ptIds)
		{
			return vtkTriangle.vtkTriangle_TriangulateLocalIds_42(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EDD RID: 7901
		public new const string MRFullTypeName = "Kitware.VTK.vtkTriangle";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EDE RID: 7902
		public new static readonly string MRClassNameKey = "class vtkTriangle";
	}
}
