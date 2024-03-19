using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTetra
	/// </summary>
	/// <remarks>
	///    a 3D cell that represents a tetrahedron
	///
	/// vtkTetra is a concrete implementation of vtkCell to represent a 3D
	/// tetrahedron. vtkTetra uses the standard isoparametric shape functions
	/// for a linear tetrahedron. The tetrahedron is defined by the four points
	/// (0-3); where (0,1,2) is the base of the tetrahedron which, using the
	/// right hand rule, forms a triangle whose normal points in the direction
	/// of the fourth point.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkConvexPointSet vtkHexahedron vtkPyramid vtkVoxel vtkWedge
	/// </seealso>
	// Token: 0x02000AD3 RID: 2771
	public class vtkTetra : vtkCell3D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D2FD RID: 119549 RVA: 0x0029271E File Offset: 0x0029091E
		static vtkTetra()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTetra.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTetra"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D2FE RID: 119550 RVA: 0x00292746 File Offset: 0x00290946
		public vtkTetra(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601D2FF RID: 119551
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTetra_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D300 RID: 119552 RVA: 0x00292754 File Offset: 0x00290954
		public new static vtkTetra New()
		{
			vtkTetra result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTetra.vtkTetra_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTetra)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D301 RID: 119553 RVA: 0x002927A8 File Offset: 0x002909A8
		public vtkTetra() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTetra.vtkTetra_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D302 RID: 119554 RVA: 0x002927EC File Offset: 0x002909EC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D303 RID: 119555
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTetra_BarycentricCoords_01(IntPtr x, IntPtr x1, IntPtr x2, IntPtr x3, IntPtr x4, IntPtr bcoords);

		/// <summary>
		/// Given a 3D point x[3], determine the barycentric coordinates of the point.
		/// Barycentric coordinates are a natural coordinate system for simplices that
		/// express a position as a linear combination of the vertices. For a
		/// tetrahedron, there are four barycentric coordinates (because there are
		/// four vertices), and the sum of the coordinates must equal 1. If a
		/// point x is inside a simplex, then all four coordinates will be strictly
		/// positive.  If three coordinates are zero (so the fourth =1), then the
		/// point x is on a vertex. If two coordinates are zero, the point x is on an
		/// edge (and so on). In this method, you must specify the vertex coordinates
		/// x1-&gt;x4. Returns 0 if tetrahedron is degenerate.
		/// </summary>
		// Token: 0x0601D304 RID: 119556 RVA: 0x002927F8 File Offset: 0x002909F8
		public static int BarycentricCoords(IntPtr x, IntPtr x1, IntPtr x2, IntPtr x3, IntPtr x4, IntPtr bcoords)
		{
			return vtkTetra.vtkTetra_BarycentricCoords_01(x, x1, x2, x3, x4, bcoords);
		}

		// Token: 0x0601D305 RID: 119557
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTetra_CellBoundary_02(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

		/// <summary>
		/// Returns the set of points that are on the boundary of the tetrahedron that
		/// are closest parametrically to the point specified. This may include faces,
		/// edges, or vertices.
		/// </summary>
		// Token: 0x0601D306 RID: 119558 RVA: 0x0029281C File Offset: 0x00290A1C
		public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
		{
			return vtkTetra.vtkTetra_CellBoundary_02(base.GetCppThis(), subId, pcoords, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601D307 RID: 119559
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTetra_Circumsphere_03(IntPtr x1, IntPtr x2, IntPtr x3, IntPtr x4, IntPtr center);

		/// <summary>
		/// Compute the circumcenter (center[3]) and radius squared (method
		/// return value) of a tetrahedron defined by the four points x1, x2,
		/// x3, and x4.
		/// </summary>
		// Token: 0x0601D308 RID: 119560 RVA: 0x00292854 File Offset: 0x00290A54
		public static double Circumsphere(IntPtr x1, IntPtr x2, IntPtr x3, IntPtr x4, IntPtr center)
		{
			return vtkTetra.vtkTetra_Circumsphere_03(x1, x2, x3, x4, center);
		}

		// Token: 0x0601D309 RID: 119561
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTetra_Clip_04(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef connectivity, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D30A RID: 119562 RVA: 0x00292874 File Offset: 0x00290A74
		public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray connectivity, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
		{
			vtkTetra.vtkTetra_Clip_04(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (connectivity == null) ? default(HandleRef) : connectivity.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis(), insideOut);
		}

		// Token: 0x0601D30B RID: 119563
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTetra_ComputeCentroid_05(HandleRef points, IntPtr pointIds, IntPtr centroid);

		/// <summary>
		/// Static method version of GetCentroid.
		/// </summary>
		// Token: 0x0601D30C RID: 119564 RVA: 0x00292930 File Offset: 0x00290B30
		public static bool ComputeCentroid(vtkPoints points, IntPtr pointIds, IntPtr centroid)
		{
			return vtkTetra.vtkTetra_ComputeCentroid_05((points == null) ? default(HandleRef) : points.GetCppThis(), pointIds, centroid) != 0;
		}

		// Token: 0x0601D30D RID: 119565
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTetra_ComputeVolume_06(IntPtr p1, IntPtr p2, IntPtr p3, IntPtr p4);

		/// <summary>
		/// Compute the volume of a tetrahedron defined by the four points
		/// p1, p2, p3, and p4.
		/// </summary>
		// Token: 0x0601D30E RID: 119566 RVA: 0x00292968 File Offset: 0x00290B68
		public static double ComputeVolume(IntPtr p1, IntPtr p2, IntPtr p3, IntPtr p4)
		{
			return vtkTetra.vtkTetra_ComputeVolume_06(p1, p2, p3, p4);
		}

		// Token: 0x0601D30F RID: 119567
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTetra_Contour_07(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D310 RID: 119568 RVA: 0x00292988 File Offset: 0x00290B88
		public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
		{
			vtkTetra.vtkTetra_Contour_07(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis());
		}

		// Token: 0x0601D311 RID: 119569
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTetra_Derivatives_08(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D312 RID: 119570 RVA: 0x00292A70 File Offset: 0x00290C70
		public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
		{
			vtkTetra.vtkTetra_Derivatives_08(base.GetCppThis(), subId, pcoords, values, dim, derivs);
		}

		// Token: 0x0601D313 RID: 119571
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTetra_EvaluateLocation_09(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D314 RID: 119572 RVA: 0x00292A86 File Offset: 0x00290C86
		public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
		{
			vtkTetra.vtkTetra_EvaluateLocation_09(base.GetCppThis(), ref subId, pcoords, x, weights);
		}

		// Token: 0x0601D315 RID: 119573
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTetra_EvaluatePosition_10(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D316 RID: 119574 RVA: 0x00292A9C File Offset: 0x00290C9C
		public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
		{
			return vtkTetra.vtkTetra_EvaluatePosition_10(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
		}

		// Token: 0x0601D317 RID: 119575
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTetra_GetCellType_11(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D318 RID: 119576 RVA: 0x00292AC4 File Offset: 0x00290CC4
		public override int GetCellType()
		{
			return vtkTetra.vtkTetra_GetCellType_11(base.GetCppThis());
		}

		// Token: 0x0601D319 RID: 119577
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTetra_GetCentroid_12(HandleRef pThis, IntPtr centroid);

		/// <summary>
		/// See vtkCell3D API for description of these methods.
		/// </summary>
		// Token: 0x0601D31A RID: 119578 RVA: 0x00292AE4 File Offset: 0x00290CE4
		public override bool GetCentroid(IntPtr centroid)
		{
			return vtkTetra.vtkTetra_GetCentroid_12(base.GetCppThis(), centroid) != 0;
		}

		// Token: 0x0601D31B RID: 119579
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTetra_GetEdge_13(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D31C RID: 119580 RVA: 0x00292B0C File Offset: 0x00290D0C
		public override vtkCell GetEdge(int edgeId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTetra.vtkTetra_GetEdge_13(base.GetCppThis(), edgeId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601D31D RID: 119581
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTetra_GetEdgeArray_14(long edgeId);

		/// <summary>
		/// Return the ids of the vertices defining edge/face (`edgeId`/`faceId').
		/// Ids are related to the cell, not to the dataset.
		///
		/// @note The return type changed. It used to be int*, it is now const vtkIdType*.
		/// This is so ids are unified between vtkCell and vtkPoints, and so vtkCell ids
		/// can be used as inputs in algorithms such as vtkPolygon::ComputeNormal.
		/// </summary>
		// Token: 0x0601D31E RID: 119582 RVA: 0x00292B7C File Offset: 0x00290D7C
		public static IntPtr GetEdgeArray(long edgeId)
		{
			return vtkTetra.vtkTetra_GetEdgeArray_14(edgeId);
		}

		// Token: 0x0601D31F RID: 119583
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTetra_GetEdgeToAdjacentFacesArray_15(long edgeId);

		/// <summary>
		/// Static method version of GetEdgeToAdjacentFaces.
		/// </summary>
		// Token: 0x0601D320 RID: 119584 RVA: 0x00292B98 File Offset: 0x00290D98
		public static IntPtr GetEdgeToAdjacentFacesArray(long edgeId)
		{
			return vtkTetra.vtkTetra_GetEdgeToAdjacentFacesArray_15(edgeId);
		}

		// Token: 0x0601D321 RID: 119585
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTetra_GetFace_16(HandleRef pThis, int faceId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D322 RID: 119586 RVA: 0x00292BB4 File Offset: 0x00290DB4
		public override vtkCell GetFace(int faceId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTetra.vtkTetra_GetFace_16(base.GetCppThis(), faceId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601D323 RID: 119587
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTetra_GetFaceArray_17(long faceId);

		/// <summary>
		/// Return the ids of the vertices defining edge/face (`edgeId`/`faceId').
		/// Ids are related to the cell, not to the dataset.
		///
		/// @note The return type changed. It used to be int*, it is now const vtkIdType*.
		/// This is so ids are unified between vtkCell and vtkPoints, and so vtkCell ids
		/// can be used as inputs in algorithms such as vtkPolygon::ComputeNormal.
		/// </summary>
		// Token: 0x0601D324 RID: 119588 RVA: 0x00292C24 File Offset: 0x00290E24
		public static IntPtr GetFaceArray(long faceId)
		{
			return vtkTetra.vtkTetra_GetFaceArray_17(faceId);
		}

		// Token: 0x0601D325 RID: 119589
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTetra_GetFaceToAdjacentFacesArray_18(long faceId);

		/// <summary>
		/// Static method version of GetFaceToAdjacentFaces.
		/// </summary>
		// Token: 0x0601D326 RID: 119590 RVA: 0x00292C40 File Offset: 0x00290E40
		public static IntPtr GetFaceToAdjacentFacesArray(long faceId)
		{
			return vtkTetra.vtkTetra_GetFaceToAdjacentFacesArray_18(faceId);
		}

		// Token: 0x0601D327 RID: 119591
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTetra_GetNumberOfEdges_19(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D328 RID: 119592 RVA: 0x00292C5C File Offset: 0x00290E5C
		public override int GetNumberOfEdges()
		{
			return vtkTetra.vtkTetra_GetNumberOfEdges_19(base.GetCppThis());
		}

		// Token: 0x0601D329 RID: 119593
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTetra_GetNumberOfFaces_20(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D32A RID: 119594 RVA: 0x00292C7C File Offset: 0x00290E7C
		public override int GetNumberOfFaces()
		{
			return vtkTetra.vtkTetra_GetNumberOfFaces_20(base.GetCppThis());
		}

		// Token: 0x0601D32B RID: 119595
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTetra_GetNumberOfGenerationsFromBase_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D32C RID: 119596 RVA: 0x00292C9C File Offset: 0x00290E9C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTetra.vtkTetra_GetNumberOfGenerationsFromBase_21(base.GetCppThis(), type);
		}

		// Token: 0x0601D32D RID: 119597
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTetra_GetNumberOfGenerationsFromBaseType_22([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D32E RID: 119598 RVA: 0x00292CBC File Offset: 0x00290EBC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTetra.vtkTetra_GetNumberOfGenerationsFromBaseType_22(type);
		}

		// Token: 0x0601D32F RID: 119599
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTetra_GetParametricCenter_23(HandleRef pThis, IntPtr pcoords);

		/// <summary>
		/// Return the center of the tetrahedron in parametric coordinates.
		/// </summary>
		// Token: 0x0601D330 RID: 119600 RVA: 0x00292CD8 File Offset: 0x00290ED8
		public override int GetParametricCenter(IntPtr pcoords)
		{
			return vtkTetra.vtkTetra_GetParametricCenter_23(base.GetCppThis(), pcoords);
		}

		// Token: 0x0601D331 RID: 119601
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTetra_GetParametricCoords_24(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D332 RID: 119602 RVA: 0x00292CF8 File Offset: 0x00290EF8
		public override IntPtr GetParametricCoords()
		{
			return vtkTetra.vtkTetra_GetParametricCoords_24(base.GetCppThis());
		}

		// Token: 0x0601D333 RID: 119603
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTetra_GetParametricDistance_25(HandleRef pThis, IntPtr pcoords);

		/// <summary>
		/// Return the distance of the parametric coordinate provided to the
		/// cell. If inside the cell, a distance of zero is returned.
		/// </summary>
		// Token: 0x0601D334 RID: 119604 RVA: 0x00292D18 File Offset: 0x00290F18
		public override double GetParametricDistance(IntPtr pcoords)
		{
			return vtkTetra.vtkTetra_GetParametricDistance_25(base.GetCppThis(), pcoords);
		}

		// Token: 0x0601D335 RID: 119605
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTetra_GetPointToIncidentEdgesArray_26(long pointId);

		/// <summary>
		/// Static method version of GetPointToIncidentEdgesArray.
		/// </summary>
		// Token: 0x0601D336 RID: 119606 RVA: 0x00292D38 File Offset: 0x00290F38
		public static IntPtr GetPointToIncidentEdgesArray(long pointId)
		{
			return vtkTetra.vtkTetra_GetPointToIncidentEdgesArray_26(pointId);
		}

		// Token: 0x0601D337 RID: 119607
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTetra_GetPointToIncidentFacesArray_27(long pointId);

		/// <summary>
		/// Static method version of GetPointToIncidentFacesArray.
		/// </summary>
		// Token: 0x0601D338 RID: 119608 RVA: 0x00292D54 File Offset: 0x00290F54
		public static IntPtr GetPointToIncidentFacesArray(long pointId)
		{
			return vtkTetra.vtkTetra_GetPointToIncidentFacesArray_27(pointId);
		}

		// Token: 0x0601D339 RID: 119609
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTetra_GetPointToOneRingPointsArray_28(long pointId);

		/// <summary>
		/// Static method version of GetPointToOneRingPoints.
		/// </summary>
		// Token: 0x0601D33A RID: 119610 RVA: 0x00292D70 File Offset: 0x00290F70
		public static IntPtr GetPointToOneRingPointsArray(long pointId)
		{
			return vtkTetra.vtkTetra_GetPointToOneRingPointsArray_28(pointId);
		}

		// Token: 0x0601D33B RID: 119611
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTetra_GetTriangleCases_29(int caseId);

		/// <summary>
		/// Return the case table for table-based isocontouring (aka marching cubes
		/// style implementations). A linear 3D cell with N vertices will have 2**N
		/// cases. The returned case array lists three edges in order to produce one
		/// output triangle which may be repeated to generate multiple triangles. The
		/// list of cases terminates with a -1 entry.
		/// </summary>
		// Token: 0x0601D33C RID: 119612 RVA: 0x00292D8C File Offset: 0x00290F8C
		public static IntPtr GetTriangleCases(int caseId)
		{
			return vtkTetra.vtkTetra_GetTriangleCases_29(caseId);
		}

		// Token: 0x0601D33D RID: 119613
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTetra_Insphere_30(IntPtr p1, IntPtr p2, IntPtr p3, IntPtr p4, IntPtr center);

		/// <summary>
		/// Compute the center (center[3]) and radius (method return value) of
		/// a sphere that just fits inside the faces of a tetrahedron defined
		/// by the four points x1, x2, x3, and x4.
		/// </summary>
		// Token: 0x0601D33E RID: 119614 RVA: 0x00292DA8 File Offset: 0x00290FA8
		public static double Insphere(IntPtr p1, IntPtr p2, IntPtr p3, IntPtr p4, IntPtr center)
		{
			return vtkTetra.vtkTetra_Insphere_30(p1, p2, p3, p4, center);
		}

		// Token: 0x0601D33F RID: 119615
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTetra_InterpolateDerivs_31(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601D340 RID: 119616 RVA: 0x00292DC7 File Offset: 0x00290FC7
		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkTetra.vtkTetra_InterpolateDerivs_31(base.GetCppThis(), pcoords, derivs);
		}

		// Token: 0x0601D341 RID: 119617
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTetra_InterpolateFunctions_32(HandleRef pThis, IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601D342 RID: 119618 RVA: 0x00292DD8 File Offset: 0x00290FD8
		public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkTetra.vtkTetra_InterpolateFunctions_32(base.GetCppThis(), pcoords, weights);
		}

		// Token: 0x0601D343 RID: 119619
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTetra_InterpolationDerivs_33(IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Given parametric coordinates compute inverse Jacobian transformation
		/// matrix. Returns 9 elements of 3x3 inverse Jacobian plus interpolation
		/// function derivatives. Returns 0 if no inverse exists.
		/// </summary>
		// Token: 0x0601D344 RID: 119620 RVA: 0x00292DE9 File Offset: 0x00290FE9
		public static void InterpolationDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkTetra.vtkTetra_InterpolationDerivs_33(pcoords, derivs);
		}

		// Token: 0x0601D345 RID: 119621
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTetra_InterpolationFunctions_34(IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Given parametric coordinates compute inverse Jacobian transformation
		/// matrix. Returns 9 elements of 3x3 inverse Jacobian plus interpolation
		/// function derivatives. Returns 0 if no inverse exists.
		/// </summary>
		// Token: 0x0601D346 RID: 119622 RVA: 0x00292DF4 File Offset: 0x00290FF4
		public static void InterpolationFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkTetra.vtkTetra_InterpolationFunctions_34(pcoords, weights);
		}

		// Token: 0x0601D347 RID: 119623
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTetra_IntersectWithLine_35(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D348 RID: 119624 RVA: 0x00292E00 File Offset: 0x00291000
		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkTetra.vtkTetra_IntersectWithLine_35(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		// Token: 0x0601D349 RID: 119625
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTetra_IsA_36(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D34A RID: 119626 RVA: 0x00292E2C File Offset: 0x0029102C
		public override int IsA(string type)
		{
			return vtkTetra.vtkTetra_IsA_36(base.GetCppThis(), type);
		}

		// Token: 0x0601D34B RID: 119627
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTetra_IsInsideOut_37(HandleRef pThis);

		/// <summary>
		/// See vtkCell3D API for description of these methods.
		/// </summary>
		// Token: 0x0601D34C RID: 119628 RVA: 0x00292E4C File Offset: 0x0029104C
		public override bool IsInsideOut()
		{
			return vtkTetra.vtkTetra_IsInsideOut_37(base.GetCppThis()) != 0;
		}

		// Token: 0x0601D34D RID: 119629
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTetra_IsTypeOf_38([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D34E RID: 119630 RVA: 0x00292E74 File Offset: 0x00291074
		public new static int IsTypeOf(string type)
		{
			return vtkTetra.vtkTetra_IsTypeOf_38(type);
		}

		// Token: 0x0601D34F RID: 119631
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTetra_NewInstance_40(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D350 RID: 119632 RVA: 0x00292E90 File Offset: 0x00291090
		public new vtkTetra NewInstance()
		{
			vtkTetra result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTetra.vtkTetra_NewInstance_40(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTetra)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601D351 RID: 119633
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTetra_SafeDownCast_41(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D352 RID: 119634 RVA: 0x00292EEC File Offset: 0x002910EC
		public new static vtkTetra SafeDownCast(vtkObjectBase o)
		{
			vtkTetra vtkTetra = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTetra.vtkTetra_SafeDownCast_41((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTetra = (vtkTetra)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTetra.Register(null);
				}
			}
			return vtkTetra;
		}

		// Token: 0x0601D353 RID: 119635
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTetra_TetraCenter_42(IntPtr p1, IntPtr p2, IntPtr p3, IntPtr p4, IntPtr center);

		/// <summary>
		/// Compute the center of the tetrahedron,
		/// </summary>
		// Token: 0x0601D354 RID: 119636 RVA: 0x00292F6B File Offset: 0x0029116B
		public static void TetraCenter(IntPtr p1, IntPtr p2, IntPtr p3, IntPtr p4, IntPtr center)
		{
			vtkTetra.vtkTetra_TetraCenter_42(p1, p2, p3, p4, center);
		}

		// Token: 0x0601D355 RID: 119637
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTetra_TriangulateLocalIds_43(HandleRef pThis, int index, HandleRef ptIds);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D356 RID: 119638 RVA: 0x00292F7C File Offset: 0x0029117C
		public override int TriangulateLocalIds(int index, vtkIdList ptIds)
		{
			return vtkTetra.vtkTetra_TriangulateLocalIds_43(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001ECC RID: 7884
		public new const string MRFullTypeName = "Kitware.VTK.vtkTetra";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001ECD RID: 7885
		public new static readonly string MRClassNameKey = "class vtkTetra";
	}
}
