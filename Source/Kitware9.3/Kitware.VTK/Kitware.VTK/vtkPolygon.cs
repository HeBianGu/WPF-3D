using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPolygon
	/// </summary>
	/// <remarks>
	///    a cell that represents an n-sided polygon
	///
	/// vtkPolygon is a concrete implementation of vtkCell to represent a 2D
	/// n-sided polygon. The polygons cannot have any internal holes, and cannot
	/// self-intersect. Define the polygon with n-points ordered in the counter-
	/// clockwise direction; do not repeat the last point.
	/// </remarks>
	// Token: 0x02000AA5 RID: 2725
	public class vtkPolygon : vtkCell
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601C9CD RID: 117197 RVA: 0x00283685 File Offset: 0x00281885
		static vtkPolygon()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolygon.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolygon"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601C9CE RID: 117198 RVA: 0x002836AD File Offset: 0x002818AD
		public vtkPolygon(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601C9CF RID: 117199
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolygon_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C9D0 RID: 117200 RVA: 0x002836BC File Offset: 0x002818BC
		public new static vtkPolygon New()
		{
			vtkPolygon result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolygon.vtkPolygon_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolygon)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C9D1 RID: 117201 RVA: 0x00283710 File Offset: 0x00281910
		public vtkPolygon() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPolygon.vtkPolygon_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601C9D2 RID: 117202 RVA: 0x00283754 File Offset: 0x00281954
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601C9D3 RID: 117203
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolygon_BoundedTriangulate_01(HandleRef pThis, HandleRef outTris, double tol);

		/// <summary>
		/// Triangulate polygon and enforce that the ratio of the smallest triangle
		/// area to the polygon area is greater than a user-defined tolerance. The user
		/// must provide the vtkIdList outTris. On output, the outTris list contains
		/// the ids of the points defining the triangulation. The ids are ordered into
		/// groups of three: each three-group defines one triangle.
		/// </summary>
		// Token: 0x0601C9D4 RID: 117204 RVA: 0x00283760 File Offset: 0x00281960
		public int BoundedTriangulate(vtkIdList outTris, double tol)
		{
			return vtkPolygon.vtkPolygon_BoundedTriangulate_01(base.GetCppThis(), (outTris == null) ? default(HandleRef) : outTris.GetCppThis(), tol);
		}

		// Token: 0x0601C9D5 RID: 117205
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolygon_CellBoundary_02(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C9D6 RID: 117206 RVA: 0x00283798 File Offset: 0x00281998
		public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
		{
			return vtkPolygon.vtkPolygon_CellBoundary_02(base.GetCppThis(), subId, pcoords, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601C9D7 RID: 117207
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolygon_Clip_03(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef tris, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C9D8 RID: 117208 RVA: 0x002837D0 File Offset: 0x002819D0
		public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray tris, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
		{
			vtkPolygon.vtkPolygon_Clip_03(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (tris == null) ? default(HandleRef) : tris.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis(), insideOut);
		}

		// Token: 0x0601C9D9 RID: 117209
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolygon_ComputeArea_04(HandleRef pThis);

		/// <summary>
		/// Compute the area of a polygon. This is a convenience function
		/// which simply calls static double ComputeArea(vtkPoints *p,
		/// vtkIdType numPts, vtkIdType *pts, double normal[3]);
		/// with the appropriate parameters from the instantiated vtkPolygon.
		/// </summary>
		// Token: 0x0601C9DA RID: 117210 RVA: 0x0028388C File Offset: 0x00281A8C
		public double ComputeArea()
		{
			return vtkPolygon.vtkPolygon_ComputeArea_04(base.GetCppThis());
		}

		// Token: 0x0601C9DB RID: 117211
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolygon_ComputeArea_05(HandleRef p, long numPts, IntPtr pts, IntPtr normal);

		/// <summary>
		/// Compute the area of a polygon in 3D. The area is returned, as well as
		/// the normal (a side effect of using this method). If you desire to
		/// compute the area of a triangle, use vtkTriangleArea which is faster.
		/// If pts==nullptr, point indexing is supposed to be {0, 1, ..., numPts-1}.
		/// If you already have a vtkPolygon instantiated, a convenience function,
		/// ComputeArea() is provided.
		/// </summary>
		// Token: 0x0601C9DC RID: 117212 RVA: 0x002838AC File Offset: 0x00281AAC
		public static double ComputeArea(vtkPoints p, long numPts, IntPtr pts, IntPtr normal)
		{
			return vtkPolygon.vtkPolygon_ComputeArea_05((p == null) ? default(HandleRef) : p.GetCppThis(), numPts, pts, normal);
		}

		// Token: 0x0601C9DD RID: 117213
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolygon_ComputeCentroid_06(HandleRef p, int numPts, IntPtr pts, IntPtr centroid);

		/// <summary>
		/// Compute the centroid of a set of points. Returns false if the computation
		/// is invalid (this occurs when numPts=0 or when ids is empty).
		/// </summary>
		// Token: 0x0601C9DE RID: 117214 RVA: 0x002838E0 File Offset: 0x00281AE0
		public static bool ComputeCentroid(vtkPoints p, int numPts, IntPtr pts, IntPtr centroid)
		{
			return vtkPolygon.vtkPolygon_ComputeCentroid_06((p == null) ? default(HandleRef) : p.GetCppThis(), numPts, pts, centroid) != 0;
		}

		// Token: 0x0601C9DF RID: 117215
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolygon_ComputeCentroid_07(HandleRef ids, HandleRef pts, IntPtr centroid);

		/// <summary>
		/// Compute the centroid of a set of points. Returns false if the computation
		/// is invalid (this occurs when numPts=0 or when ids is empty).
		/// </summary>
		// Token: 0x0601C9E0 RID: 117216 RVA: 0x00283918 File Offset: 0x00281B18
		public static bool ComputeCentroid(vtkIdTypeArray ids, vtkPoints pts, IntPtr centroid)
		{
			return vtkPolygon.vtkPolygon_ComputeCentroid_07((ids == null) ? default(HandleRef) : ids.GetCppThis(), (pts == null) ? default(HandleRef) : pts.GetCppThis(), centroid) != 0;
		}

		// Token: 0x0601C9E1 RID: 117217
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolygon_ComputeNormal_08(HandleRef p, int numPts, IntPtr pts, IntPtr n);

		/// <summary>
		/// Computes the unit normal to the polygon. If pts=nullptr, point indexing is
		/// assumed to be {0, 1, ..., numPts-1}.
		/// </summary>
		// Token: 0x0601C9E2 RID: 117218 RVA: 0x00283964 File Offset: 0x00281B64
		public static void ComputeNormal(vtkPoints p, int numPts, IntPtr pts, IntPtr n)
		{
			vtkPolygon.vtkPolygon_ComputeNormal_08((p == null) ? default(HandleRef) : p.GetCppThis(), numPts, pts, n);
		}

		// Token: 0x0601C9E3 RID: 117219
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolygon_ComputeNormal_09(HandleRef p, IntPtr n);

		/// <summary>
		/// Computes the unit normal to the polygon. If pts=nullptr, point indexing is
		/// assumed to be {0, 1, ..., numPts-1}.
		/// </summary>
		// Token: 0x0601C9E4 RID: 117220 RVA: 0x00283990 File Offset: 0x00281B90
		public static void ComputeNormal(vtkPoints p, IntPtr n)
		{
			vtkPolygon.vtkPolygon_ComputeNormal_09((p == null) ? default(HandleRef) : p.GetCppThis(), n);
		}

		// Token: 0x0601C9E5 RID: 117221
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolygon_ComputeNormal_10(HandleRef ids, HandleRef pts, IntPtr n);

		/// <summary>
		/// Computes the unit normal to the polygon. If pts=nullptr, point indexing is
		/// assumed to be {0, 1, ..., numPts-1}.
		/// </summary>
		// Token: 0x0601C9E6 RID: 117222 RVA: 0x002839BC File Offset: 0x00281BBC
		public static void ComputeNormal(vtkIdTypeArray ids, vtkPoints pts, IntPtr n)
		{
			vtkPolygon.vtkPolygon_ComputeNormal_10((ids == null) ? default(HandleRef) : ids.GetCppThis(), (pts == null) ? default(HandleRef) : pts.GetCppThis(), n);
		}

		// Token: 0x0601C9E7 RID: 117223
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolygon_ComputeNormal_11(int numPts, IntPtr pts, IntPtr n);

		/// <summary>
		/// Compute the polygon normal from an array of points. This version assumes
		/// that the polygon is convex, and looks for the first valid normal.
		/// </summary>
		// Token: 0x0601C9E8 RID: 117224 RVA: 0x002839FB File Offset: 0x00281BFB
		public static void ComputeNormal(int numPts, IntPtr pts, IntPtr n)
		{
			vtkPolygon.vtkPolygon_ComputeNormal_11(numPts, pts, n);
		}

		// Token: 0x0601C9E9 RID: 117225
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolygon_Contour_12(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C9EA RID: 117226 RVA: 0x00283A08 File Offset: 0x00281C08
		public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
		{
			vtkPolygon.vtkPolygon_Contour_12(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis());
		}

		// Token: 0x0601C9EB RID: 117227
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolygon_Derivatives_13(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C9EC RID: 117228 RVA: 0x00283AF0 File Offset: 0x00281CF0
		public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
		{
			vtkPolygon.vtkPolygon_Derivatives_13(base.GetCppThis(), subId, pcoords, values, dim, derivs);
		}

		// Token: 0x0601C9ED RID: 117229
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolygon_DistanceToPolygon_14(IntPtr x, int numPts, IntPtr pts, IntPtr bounds, IntPtr closest);

		/// <summary>
		/// Compute the distance of a point to a polygon. The closest point on
		/// the polygon is also returned. The bounds should be provided to
		/// accelerate the computation.
		/// </summary>
		// Token: 0x0601C9EE RID: 117230 RVA: 0x00283B08 File Offset: 0x00281D08
		public static double DistanceToPolygon(IntPtr x, int numPts, IntPtr pts, IntPtr bounds, IntPtr closest)
		{
			return vtkPolygon.vtkPolygon_DistanceToPolygon_14(x, numPts, pts, bounds, closest);
		}

		// Token: 0x0601C9EF RID: 117231
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolygon_EarCutTriangulation_15(HandleRef pThis, int measure);

		/// <summary>
		/// A fast triangulation method. Uses recursive divide and
		/// conquer based on plane splitting to reduce loop into triangles.
		/// The cell (e.g., triangle) is presumed properly initialized (i.e.,
		/// Points and PointIds). Ears can be removed using different measures
		/// (the measures indicate convexity plus characterize the local
		/// geometry around each vertex).
		/// </summary>
		// Token: 0x0601C9F0 RID: 117232 RVA: 0x00283B28 File Offset: 0x00281D28
		public int EarCutTriangulation(int measure)
		{
			return vtkPolygon.vtkPolygon_EarCutTriangulation_15(base.GetCppThis(), measure);
		}

		// Token: 0x0601C9F1 RID: 117233
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolygon_EarCutTriangulation_16(HandleRef pThis, HandleRef outTris, int measure);

		/// <summary>
		/// A fast triangulation method. Uses recursive divide and
		/// conquer based on plane splitting to reduce loop into triangles.
		/// The cell (e.g., triangle) is presumed properly initialized (i.e.,
		/// Points and PointIds). Ears can be removed using different measures
		/// (the measures indicate convexity plus characterize the local
		/// geometry around each vertex).
		/// </summary>
		// Token: 0x0601C9F2 RID: 117234 RVA: 0x00283B48 File Offset: 0x00281D48
		public int EarCutTriangulation(vtkIdList outTris, int measure)
		{
			return vtkPolygon.vtkPolygon_EarCutTriangulation_16(base.GetCppThis(), (outTris == null) ? default(HandleRef) : outTris.GetCppThis(), measure);
		}

		// Token: 0x0601C9F3 RID: 117235
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolygon_EvaluateLocation_17(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C9F4 RID: 117236 RVA: 0x00283B7D File Offset: 0x00281D7D
		public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
		{
			vtkPolygon.vtkPolygon_EvaluateLocation_17(base.GetCppThis(), ref subId, pcoords, x, weights);
		}

		// Token: 0x0601C9F5 RID: 117237
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolygon_EvaluatePosition_18(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C9F6 RID: 117238 RVA: 0x00283B94 File Offset: 0x00281D94
		public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
		{
			return vtkPolygon.vtkPolygon_EvaluatePosition_18(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
		}

		// Token: 0x0601C9F7 RID: 117239
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolygon_GetCellDimension_19(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C9F8 RID: 117240 RVA: 0x00283BBC File Offset: 0x00281DBC
		public override int GetCellDimension()
		{
			return vtkPolygon.vtkPolygon_GetCellDimension_19(base.GetCppThis());
		}

		// Token: 0x0601C9F9 RID: 117241
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolygon_GetCellType_20(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C9FA RID: 117242 RVA: 0x00283BDC File Offset: 0x00281DDC
		public override int GetCellType()
		{
			return vtkPolygon.vtkPolygon_GetCellType_20(base.GetCppThis());
		}

		// Token: 0x0601C9FB RID: 117243
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolygon_GetEdge_21(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C9FC RID: 117244 RVA: 0x00283BFC File Offset: 0x00281DFC
		public override vtkCell GetEdge(int edgeId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolygon.vtkPolygon_GetEdge_21(base.GetCppThis(), edgeId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601C9FD RID: 117245
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolygon_GetFace_22(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C9FE RID: 117246 RVA: 0x00283C6C File Offset: 0x00281E6C
		public override vtkCell GetFace(int arg0)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolygon.vtkPolygon_GetFace_22(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601C9FF RID: 117247
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolygon_GetNumberOfEdges_23(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601CA00 RID: 117248 RVA: 0x00283CDC File Offset: 0x00281EDC
		public override int GetNumberOfEdges()
		{
			return vtkPolygon.vtkPolygon_GetNumberOfEdges_23(base.GetCppThis());
		}

		// Token: 0x0601CA01 RID: 117249
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolygon_GetNumberOfFaces_24(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601CA02 RID: 117250 RVA: 0x00283CFC File Offset: 0x00281EFC
		public override int GetNumberOfFaces()
		{
			return vtkPolygon.vtkPolygon_GetNumberOfFaces_24(base.GetCppThis());
		}

		// Token: 0x0601CA03 RID: 117251
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolygon_GetNumberOfGenerationsFromBase_25(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CA04 RID: 117252 RVA: 0x00283D1C File Offset: 0x00281F1C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPolygon.vtkPolygon_GetNumberOfGenerationsFromBase_25(base.GetCppThis(), type);
		}

		// Token: 0x0601CA05 RID: 117253
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolygon_GetNumberOfGenerationsFromBaseType_26([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CA06 RID: 117254 RVA: 0x00283D3C File Offset: 0x00281F3C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPolygon.vtkPolygon_GetNumberOfGenerationsFromBaseType_26(type);
		}

		// Token: 0x0601CA07 RID: 117255
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolygon_GetTolerance_27(HandleRef pThis);

		/// <summary>
		/// Specify an internal tolerance for operations requiring polygon
		/// triangulation.  (For example, clipping and contouring operations proceed
		/// by first triangulating the polygon, and then clipping/contouring the
		/// resulting triangles.)  This is a normalized tolerance value multiplied
		/// by the diagonal length of the polygon bounding box. Is it used to
		/// determine whether potential triangulation edges intersect one another.
		/// </summary>
		// Token: 0x0601CA08 RID: 117256 RVA: 0x00283D58 File Offset: 0x00281F58
		public virtual double GetTolerance()
		{
			return vtkPolygon.vtkPolygon_GetTolerance_27(base.GetCppThis());
		}

		// Token: 0x0601CA09 RID: 117257
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolygon_GetToleranceMaxValue_28(HandleRef pThis);

		/// <summary>
		/// Specify an internal tolerance for operations requiring polygon
		/// triangulation.  (For example, clipping and contouring operations proceed
		/// by first triangulating the polygon, and then clipping/contouring the
		/// resulting triangles.)  This is a normalized tolerance value multiplied
		/// by the diagonal length of the polygon bounding box. Is it used to
		/// determine whether potential triangulation edges intersect one another.
		/// </summary>
		// Token: 0x0601CA0A RID: 117258 RVA: 0x00283D78 File Offset: 0x00281F78
		public virtual double GetToleranceMaxValue()
		{
			return vtkPolygon.vtkPolygon_GetToleranceMaxValue_28(base.GetCppThis());
		}

		// Token: 0x0601CA0B RID: 117259
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolygon_GetToleranceMinValue_29(HandleRef pThis);

		/// <summary>
		/// Specify an internal tolerance for operations requiring polygon
		/// triangulation.  (For example, clipping and contouring operations proceed
		/// by first triangulating the polygon, and then clipping/contouring the
		/// resulting triangles.)  This is a normalized tolerance value multiplied
		/// by the diagonal length of the polygon bounding box. Is it used to
		/// determine whether potential triangulation edges intersect one another.
		/// </summary>
		// Token: 0x0601CA0C RID: 117260 RVA: 0x00283D98 File Offset: 0x00281F98
		public virtual double GetToleranceMinValue()
		{
			return vtkPolygon.vtkPolygon_GetToleranceMinValue_29(base.GetCppThis());
		}

		// Token: 0x0601CA0D RID: 117261
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolygon_GetUseMVCInterpolation_30(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag indicating whether to use Mean Value Coordinate for the
		/// interpolation. If true, InterpolateFunctions() uses the Mean Value
		/// Coordinate to compute weights. Otherwise, the conventional 1/r^2 method
		/// is used. The UseMVCInterpolation parameter is set to false by default.
		/// </summary>
		// Token: 0x0601CA0E RID: 117262 RVA: 0x00283DB8 File Offset: 0x00281FB8
		public virtual bool GetUseMVCInterpolation()
		{
			return vtkPolygon.vtkPolygon_GetUseMVCInterpolation_30(base.GetCppThis()) != 0;
		}

		// Token: 0x0601CA0F RID: 117263
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolygon_InterpolateFunctions_31(HandleRef pThis, IntPtr x, IntPtr sf);

		/// <summary>
		/// Compute the interpolation functions/derivatives.
		/// (aka shape functions/derivatives)
		/// Two interpolation algorithms are available: 1/r^2 and Mean Value
		/// Coordinate. The former is used by default. To use the second algorithm,
		/// set UseMVCInterpolation to be true.
		/// The function assumes the input point lies on the polygon plane without
		/// checking that.
		/// </summary>
		// Token: 0x0601CA10 RID: 117264 RVA: 0x00283DDE File Offset: 0x00281FDE
		public override void InterpolateFunctions(IntPtr x, IntPtr sf)
		{
			vtkPolygon.vtkPolygon_InterpolateFunctions_31(base.GetCppThis(), x, sf);
		}

		// Token: 0x0601CA11 RID: 117265
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolygon_IntersectConvex2DCells_32(HandleRef cell1, HandleRef cell2, double tol, IntPtr p0, IntPtr p1);

		/// <summary>
		/// Intersect two convex 2D polygons to produce a line segment as output.
		/// The return status of the methods indicated no intersection (returns 0);
		/// a single point of intersection (returns 1); or a line segment (i.e., two
		/// points of intersection, returns 2). The points of intersection are
		/// returned in the arrays p0 and p1.  If less than two points of
		/// intersection are generated then p1 and/or p0 may be
		/// indeterminiate. Finally, if the two convex polygons are parallel, then
		/// "0" is returned (i.e., no intersection) even if the triangles lie on one
		/// another.
		/// </summary>
		// Token: 0x0601CA12 RID: 117266 RVA: 0x00283DF0 File Offset: 0x00281FF0
		public static int IntersectConvex2DCells(vtkCell cell1, vtkCell cell2, double tol, IntPtr p0, IntPtr p1)
		{
			return vtkPolygon.vtkPolygon_IntersectConvex2DCells_32((cell1 == null) ? default(HandleRef) : cell1.GetCppThis(), (cell2 == null) ? default(HandleRef) : cell2.GetCppThis(), tol, p0, p1);
		}

		// Token: 0x0601CA13 RID: 117267
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolygon_IntersectPolygonWithPolygon_33(int npts, IntPtr pts, IntPtr bounds, int npts2, IntPtr pts2, IntPtr bounds2, double tol, IntPtr x);

		/// <summary>
		/// Method intersects two polygons. You must supply the number of points and
		/// point coordinates (npts, *pts) and the bounding box (bounds) of the two
		/// polygons. Also supply a tolerance squared for controlling
		/// error. The method returns 1 if there is an intersection, and 0 if
		/// not. A single point of intersection x[3] is also returned if there
		/// is an intersection.
		/// </summary>
		// Token: 0x0601CA14 RID: 117268 RVA: 0x00283E38 File Offset: 0x00282038
		public static int IntersectPolygonWithPolygon(int npts, IntPtr pts, IntPtr bounds, int npts2, IntPtr pts2, IntPtr bounds2, double tol, IntPtr x)
		{
			return vtkPolygon.vtkPolygon_IntersectPolygonWithPolygon_33(npts, pts, bounds, npts2, pts2, bounds2, tol, x);
		}

		// Token: 0x0601CA15 RID: 117269
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolygon_IntersectWithLine_34(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601CA16 RID: 117270 RVA: 0x00283E60 File Offset: 0x00282060
		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkPolygon.vtkPolygon_IntersectWithLine_34(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		// Token: 0x0601CA17 RID: 117271
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolygon_IsA_35(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CA18 RID: 117272 RVA: 0x00283E8C File Offset: 0x0028208C
		public override int IsA(string type)
		{
			return vtkPolygon.vtkPolygon_IsA_35(base.GetCppThis(), type);
		}

		// Token: 0x0601CA19 RID: 117273
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolygon_IsConvex_36(HandleRef pThis);

		/// <summary>
		/// Determine whether or not a polygon is convex. This is a convenience
		/// function that simply calls static bool IsConvex(int numPts,
		/// vtkIdType *pts, vtkPoints *p) with the appropriate parameters from the
		/// instantiated vtkPolygon.
		/// </summary>
		// Token: 0x0601CA1A RID: 117274 RVA: 0x00283EAC File Offset: 0x002820AC
		public bool IsConvex()
		{
			return vtkPolygon.vtkPolygon_IsConvex_36(base.GetCppThis()) != 0;
		}

		// Token: 0x0601CA1B RID: 117275
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolygon_IsConvex_37(HandleRef p, int numPts, IntPtr pts);

		/// <summary>
		/// Determine whether or not a polygon is convex. If pts=nullptr, point indexing
		/// is assumed to be {0, 1, ..., numPts-1}.
		/// </summary>
		// Token: 0x0601CA1C RID: 117276 RVA: 0x00283ED4 File Offset: 0x002820D4
		public static bool IsConvex(vtkPoints p, int numPts, IntPtr pts)
		{
			return vtkPolygon.vtkPolygon_IsConvex_37((p == null) ? default(HandleRef) : p.GetCppThis(), numPts, pts) != 0;
		}

		// Token: 0x0601CA1D RID: 117277
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolygon_IsConvex_38(HandleRef ids, HandleRef p);

		/// <summary>
		/// Determine whether or not a polygon is convex. If pts=nullptr, point indexing
		/// is assumed to be {0, 1, ..., numPts-1}.
		/// </summary>
		// Token: 0x0601CA1E RID: 117278 RVA: 0x00283F0C File Offset: 0x0028210C
		public static bool IsConvex(vtkIdTypeArray ids, vtkPoints p)
		{
			return vtkPolygon.vtkPolygon_IsConvex_38((ids == null) ? default(HandleRef) : ids.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis()) != 0;
		}

		// Token: 0x0601CA1F RID: 117279
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolygon_IsConvex_39(HandleRef p);

		/// <summary>
		/// Determine whether or not a polygon is convex. If pts=nullptr, point indexing
		/// is assumed to be {0, 1, ..., numPts-1}.
		/// </summary>
		// Token: 0x0601CA20 RID: 117280 RVA: 0x00283F58 File Offset: 0x00282158
		public static bool IsConvex(vtkPoints p)
		{
			return vtkPolygon.vtkPolygon_IsConvex_39((p == null) ? default(HandleRef) : p.GetCppThis()) != 0;
		}

		// Token: 0x0601CA21 RID: 117281
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolygon_IsPrimaryCell_40(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601CA22 RID: 117282 RVA: 0x00283F90 File Offset: 0x00282190
		public override int IsPrimaryCell()
		{
			return vtkPolygon.vtkPolygon_IsPrimaryCell_40(base.GetCppThis());
		}

		// Token: 0x0601CA23 RID: 117283
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolygon_IsTypeOf_41([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CA24 RID: 117284 RVA: 0x00283FB0 File Offset: 0x002821B0
		public new static int IsTypeOf(string type)
		{
			return vtkPolygon.vtkPolygon_IsTypeOf_41(type);
		}

		// Token: 0x0601CA25 RID: 117285
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolygon_NewInstance_43(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CA26 RID: 117286 RVA: 0x00283FCC File Offset: 0x002821CC
		public new vtkPolygon NewInstance()
		{
			vtkPolygon result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolygon.vtkPolygon_NewInstance_43(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolygon)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601CA27 RID: 117287
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolygon_NonDegenerateTriangulate_44(HandleRef pThis, HandleRef outTris);

		/// <summary>
		/// Same as Triangulate(vtkIdList *outTris)
		/// but with a first pass to split the polygon into non-degenerate polygons.
		/// </summary>
		// Token: 0x0601CA28 RID: 117288 RVA: 0x00284028 File Offset: 0x00282228
		public int NonDegenerateTriangulate(vtkIdList outTris)
		{
			return vtkPolygon.vtkPolygon_NonDegenerateTriangulate_44(base.GetCppThis(), (outTris == null) ? default(HandleRef) : outTris.GetCppThis());
		}

		// Token: 0x0601CA29 RID: 117289
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolygon_ParameterizePolygon_45(HandleRef pThis, IntPtr p0, IntPtr p10, ref double l10, IntPtr p20, ref double l20, IntPtr n);

		/// <summary>
		/// Create a local s-t coordinate system for a polygon. The point p0 is
		/// the origin of the local system, p10 is s-axis vector, and p20 is the
		/// t-axis vector. (These are expressed in the modeling coordinate system and
		/// are vectors of dimension [3].) The values l20 and l20 are the lengths of
		/// the vectors p10 and p20, and n is the polygon normal.
		/// </summary>
		// Token: 0x0601CA2A RID: 117290 RVA: 0x0028405C File Offset: 0x0028225C
		public int ParameterizePolygon(IntPtr p0, IntPtr p10, ref double l10, IntPtr p20, ref double l20, IntPtr n)
		{
			return vtkPolygon.vtkPolygon_ParameterizePolygon_45(base.GetCppThis(), p0, p10, ref l10, p20, ref l20, n);
		}

		// Token: 0x0601CA2B RID: 117291
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolygon_PointInPolygon_46(IntPtr x, int numPts, IntPtr pts, IntPtr bounds, IntPtr n);

		/// <summary>
		/// Determine whether a point is inside the specified polygon. The function
		/// computes the winding number to assess inclusion. It works for arbitrary
		/// polygon shapes (e.g., non-convex) oriented arbitrarily in 3D
		/// space. Returns 0 if the point is not in the polygon; 1 if it is.  Can
		/// also return -1 to indicate a degenerate polygon. Parameters passed into
		/// the method include the point in question x[3]; the polygon defined by
		/// (npts,pts); the bounds of the polygon bounds[6]; and the normal n[3] to
		/// the polygon. (The implementation was inspired by Dan Sunday's book
		/// Practical Geometry Algorithms.) This method is thread safe.
		/// </summary>
		// Token: 0x0601CA2C RID: 117292 RVA: 0x00284084 File Offset: 0x00282284
		public static int PointInPolygon(IntPtr x, int numPts, IntPtr pts, IntPtr bounds, IntPtr n)
		{
			return vtkPolygon.vtkPolygon_PointInPolygon_46(x, numPts, pts, bounds, n);
		}

		// Token: 0x0601CA2D RID: 117293
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolygon_SafeDownCast_47(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CA2E RID: 117294 RVA: 0x002840A4 File Offset: 0x002822A4
		public new static vtkPolygon SafeDownCast(vtkObjectBase o)
		{
			vtkPolygon vtkPolygon = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolygon.vtkPolygon_SafeDownCast_47((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolygon = (vtkPolygon)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolygon.Register(null);
				}
			}
			return vtkPolygon;
		}

		// Token: 0x0601CA2F RID: 117295
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolygon_SetTolerance_48(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify an internal tolerance for operations requiring polygon
		/// triangulation.  (For example, clipping and contouring operations proceed
		/// by first triangulating the polygon, and then clipping/contouring the
		/// resulting triangles.)  This is a normalized tolerance value multiplied
		/// by the diagonal length of the polygon bounding box. Is it used to
		/// determine whether potential triangulation edges intersect one another.
		/// </summary>
		// Token: 0x0601CA30 RID: 117296 RVA: 0x00284123 File Offset: 0x00282323
		public virtual void SetTolerance(double _arg)
		{
			vtkPolygon.vtkPolygon_SetTolerance_48(base.GetCppThis(), _arg);
		}

		// Token: 0x0601CA31 RID: 117297
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolygon_SetUseMVCInterpolation_49(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get the flag indicating whether to use Mean Value Coordinate for the
		/// interpolation. If true, InterpolateFunctions() uses the Mean Value
		/// Coordinate to compute weights. Otherwise, the conventional 1/r^2 method
		/// is used. The UseMVCInterpolation parameter is set to false by default.
		/// </summary>
		// Token: 0x0601CA32 RID: 117298 RVA: 0x00284133 File Offset: 0x00282333
		public virtual void SetUseMVCInterpolation(bool _arg)
		{
			vtkPolygon.vtkPolygon_SetUseMVCInterpolation_49(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0601CA33 RID: 117299
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolygon_Triangulate_50(HandleRef pThis, int index, HandleRef ptIds, HandleRef pts);

		/// <summary>
		/// Determine whether a point is inside the specified polygon. The function
		/// computes the winding number to assess inclusion. It works for arbitrary
		/// polygon shapes (e.g., non-convex) oriented arbitrarily in 3D
		/// space. Returns 0 if the point is not in the polygon; 1 if it is.  Can
		/// also return -1 to indicate a degenerate polygon. Parameters passed into
		/// the method include the point in question x[3]; the polygon defined by
		/// (npts,pts); the bounds of the polygon bounds[6]; and the normal n[3] to
		/// the polygon. (The implementation was inspired by Dan Sunday's book
		/// Practical Geometry Algorithms.) This method is thread safe.
		/// </summary>
		// Token: 0x0601CA34 RID: 117300 RVA: 0x0028414C File Offset: 0x0028234C
		public override int Triangulate(int index, vtkIdList ptIds, vtkPoints pts)
		{
			return vtkPolygon.vtkPolygon_Triangulate_50(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis(), (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601CA35 RID: 117301
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolygon_TriangulateLocalIds_51(HandleRef pThis, int index, HandleRef ptIds);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601CA36 RID: 117302 RVA: 0x00284198 File Offset: 0x00282398
		public override int TriangulateLocalIds(int index, vtkIdList ptIds)
		{
			return vtkPolygon.vtkPolygon_TriangulateLocalIds_51(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		// Token: 0x0601CA37 RID: 117303
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolygon_UnbiasedEarCutTriangulation_52(HandleRef pThis, int seed, int measure);

		/// <summary>
		/// A fast triangulation method. Uses recursive divide and
		/// conquer based on plane splitting to reduce loop into triangles.
		/// The cell (e.g., triangle) is presumed properly initialized (i.e.,
		/// Points and PointIds). Unlike EarCutTriangulation(), vertices are visited
		/// sequentially without preference to angle.
		/// </summary>
		// Token: 0x0601CA38 RID: 117304 RVA: 0x002841D0 File Offset: 0x002823D0
		public int UnbiasedEarCutTriangulation(int seed, int measure)
		{
			return vtkPolygon.vtkPolygon_UnbiasedEarCutTriangulation_52(base.GetCppThis(), seed, measure);
		}

		// Token: 0x0601CA39 RID: 117305
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolygon_UnbiasedEarCutTriangulation_53(HandleRef pThis, int seed, HandleRef outTris, int measure);

		/// <summary>
		/// A fast triangulation method. Uses recursive divide and
		/// conquer based on plane splitting to reduce loop into triangles.
		/// The cell (e.g., triangle) is presumed properly initialized (i.e.,
		/// Points and PointIds). Unlike EarCutTriangulation(), vertices are visited
		/// sequentially without preference to angle.
		/// </summary>
		// Token: 0x0601CA3A RID: 117306 RVA: 0x002841F4 File Offset: 0x002823F4
		public int UnbiasedEarCutTriangulation(int seed, vtkIdList outTris, int measure)
		{
			return vtkPolygon.vtkPolygon_UnbiasedEarCutTriangulation_53(base.GetCppThis(), seed, (outTris == null) ? default(HandleRef) : outTris.GetCppThis(), measure);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E51 RID: 7761
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolygon";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E52 RID: 7762
		public new static readonly string MRClassNameKey = "class vtkPolygon";

		/// <summary>
		/// Specify an internal tolerance for operations requiring polygon
		/// triangulation.  (For example, clipping and contouring operations proceed
		/// by first triangulating the polygon, and then clipping/contouring the
		/// resulting triangles.)  This is a normalized tolerance value multiplied
		/// by the diagonal length of the polygon bounding box. Is it used to
		/// determine whether potential triangulation edges intersect one another.
		/// </summary>
		// Token: 0x02000AA6 RID: 2726
		public enum EarCutMeasureTypes
		{
			/// <summary>enum member</summary>
			// Token: 0x04001E54 RID: 7764
			BEST_QUALITY = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001E55 RID: 7765
			DOT_PRODUCT = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001E56 RID: 7766
			PERIMETER2_TO_AREA_RATIO = 0
		}
	}
}
