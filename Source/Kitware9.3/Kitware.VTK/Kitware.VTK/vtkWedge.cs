using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkWedge
	/// </summary>
	/// <remarks>
	///    a 3D cell that represents a linear wedge
	///
	/// vtkWedge is a concrete implementation of vtkCell to represent a linear 3D
	/// wedge. A wedge consists of two triangular and three quadrilateral faces
	/// and is defined by the six points (0-5). vtkWedge uses the standard
	/// isoparametric shape functions for a linear wedge. The wedge is defined
	/// by the six points (0-5) where (0,1,2) is the base of the wedge which,
	/// using the right hand rule, forms a triangle whose normal points outward
	/// (away from the triangular face (3,4,5)).
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkConvexPointSet vtkHexahedron vtkPyramid vtkTetra vtkVoxel
	/// </seealso>
	// Token: 0x02000AE3 RID: 2787
	public class vtkWedge : vtkCell3D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D668 RID: 120424 RVA: 0x00298411 File Offset: 0x00296611
		static vtkWedge()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkWedge.MRClassNameKey, Type.GetType("Kitware.VTK.vtkWedge"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D669 RID: 120425 RVA: 0x00298439 File Offset: 0x00296639
		public vtkWedge(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601D66A RID: 120426
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWedge_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D66B RID: 120427 RVA: 0x00298448 File Offset: 0x00296648
		public new static vtkWedge New()
		{
			vtkWedge result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWedge.vtkWedge_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWedge)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D66C RID: 120428 RVA: 0x0029849C File Offset: 0x0029669C
		public vtkWedge() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkWedge.vtkWedge_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D66D RID: 120429 RVA: 0x002984E0 File Offset: 0x002966E0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D66E RID: 120430
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWedge_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D66F RID: 120431 RVA: 0x002984EC File Offset: 0x002966EC
		public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
		{
			return vtkWedge.vtkWedge_CellBoundary_01(base.GetCppThis(), subId, pcoords, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601D670 RID: 120432
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkWedge_ComputeCentroid_02(HandleRef points, IntPtr pointIds, IntPtr centroid);

		/// <summary>
		/// Static method version of GetCentroid.
		/// </summary>
		// Token: 0x0601D671 RID: 120433 RVA: 0x00298524 File Offset: 0x00296724
		public static bool ComputeCentroid(vtkPoints points, IntPtr pointIds, IntPtr centroid)
		{
			return vtkWedge.vtkWedge_ComputeCentroid_02((points == null) ? default(HandleRef) : points.GetCppThis(), pointIds, centroid) != 0;
		}

		// Token: 0x0601D672 RID: 120434
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWedge_Contour_03(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D673 RID: 120435 RVA: 0x0029855C File Offset: 0x0029675C
		public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
		{
			vtkWedge.vtkWedge_Contour_03(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis());
		}

		// Token: 0x0601D674 RID: 120436
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWedge_Derivatives_04(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D675 RID: 120437 RVA: 0x00298644 File Offset: 0x00296844
		public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
		{
			vtkWedge.vtkWedge_Derivatives_04(base.GetCppThis(), subId, pcoords, values, dim, derivs);
		}

		// Token: 0x0601D676 RID: 120438
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWedge_EvaluateLocation_05(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D677 RID: 120439 RVA: 0x0029865A File Offset: 0x0029685A
		public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
		{
			vtkWedge.vtkWedge_EvaluateLocation_05(base.GetCppThis(), ref subId, pcoords, x, weights);
		}

		// Token: 0x0601D678 RID: 120440
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWedge_EvaluatePosition_06(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D679 RID: 120441 RVA: 0x00298670 File Offset: 0x00296870
		public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
		{
			return vtkWedge.vtkWedge_EvaluatePosition_06(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
		}

		// Token: 0x0601D67A RID: 120442
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWedge_GetCellDimension_07(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D67B RID: 120443 RVA: 0x00298698 File Offset: 0x00296898
		public override int GetCellDimension()
		{
			return vtkWedge.vtkWedge_GetCellDimension_07(base.GetCppThis());
		}

		// Token: 0x0601D67C RID: 120444
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWedge_GetCellType_08(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D67D RID: 120445 RVA: 0x002986B8 File Offset: 0x002968B8
		public override int GetCellType()
		{
			return vtkWedge.vtkWedge_GetCellType_08(base.GetCppThis());
		}

		// Token: 0x0601D67E RID: 120446
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkWedge_GetCentroid_09(HandleRef pThis, IntPtr centroid);

		/// <summary>
		/// See vtkCell3D API for description of these methods.
		/// </summary>
		// Token: 0x0601D67F RID: 120447 RVA: 0x002986D8 File Offset: 0x002968D8
		public override bool GetCentroid(IntPtr centroid)
		{
			return vtkWedge.vtkWedge_GetCentroid_09(base.GetCppThis(), centroid) != 0;
		}

		// Token: 0x0601D680 RID: 120448
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWedge_GetEdge_10(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D681 RID: 120449 RVA: 0x00298700 File Offset: 0x00296900
		public override vtkCell GetEdge(int edgeId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWedge.vtkWedge_GetEdge_10(base.GetCppThis(), edgeId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601D682 RID: 120450
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWedge_GetEdgeArray_11(long edgeId);

		/// <summary>
		/// Return the ids of the vertices defining edge/face (`edgeId`/`faceId').
		/// Ids are related to the cell, not to the dataset.
		///
		/// @note The return type changed. It used to be int*, it is now const vtkIdType*.
		/// This is so ids are unified between vtkCell and vtkPoints, and so vtkCell ids
		/// can be used as inputs in algorithms such as vtkPolygon::ComputeNormal.
		/// </summary>
		// Token: 0x0601D683 RID: 120451 RVA: 0x00298770 File Offset: 0x00296970
		public static IntPtr GetEdgeArray(long edgeId)
		{
			return vtkWedge.vtkWedge_GetEdgeArray_11(edgeId);
		}

		// Token: 0x0601D684 RID: 120452
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWedge_GetEdgeToAdjacentFacesArray_12(long edgeId);

		/// <summary>
		/// Static method version of GetEdgeToAdjacentFaces.
		/// </summary>
		// Token: 0x0601D685 RID: 120453 RVA: 0x0029878C File Offset: 0x0029698C
		public static IntPtr GetEdgeToAdjacentFacesArray(long edgeId)
		{
			return vtkWedge.vtkWedge_GetEdgeToAdjacentFacesArray_12(edgeId);
		}

		// Token: 0x0601D686 RID: 120454
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWedge_GetFace_13(HandleRef pThis, int faceId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D687 RID: 120455 RVA: 0x002987A8 File Offset: 0x002969A8
		public override vtkCell GetFace(int faceId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWedge.vtkWedge_GetFace_13(base.GetCppThis(), faceId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601D688 RID: 120456
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWedge_GetFaceArray_14(long faceId);

		/// <summary>
		/// Return the ids of the vertices defining edge/face (`edgeId`/`faceId').
		/// Ids are related to the cell, not to the dataset.
		///
		/// @note The return type changed. It used to be int*, it is now const vtkIdType*.
		/// This is so ids are unified between vtkCell and vtkPoints, and so vtkCell ids
		/// can be used as inputs in algorithms such as vtkPolygon::ComputeNormal.
		/// </summary>
		// Token: 0x0601D689 RID: 120457 RVA: 0x00298818 File Offset: 0x00296A18
		public static IntPtr GetFaceArray(long faceId)
		{
			return vtkWedge.vtkWedge_GetFaceArray_14(faceId);
		}

		// Token: 0x0601D68A RID: 120458
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWedge_GetFaceToAdjacentFacesArray_15(long faceId);

		/// <summary>
		/// Static method version of GetFaceToAdjacentFaces.
		/// </summary>
		// Token: 0x0601D68B RID: 120459 RVA: 0x00298834 File Offset: 0x00296A34
		public static IntPtr GetFaceToAdjacentFacesArray(long faceId)
		{
			return vtkWedge.vtkWedge_GetFaceToAdjacentFacesArray_15(faceId);
		}

		// Token: 0x0601D68C RID: 120460
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWedge_GetNumberOfEdges_16(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D68D RID: 120461 RVA: 0x00298850 File Offset: 0x00296A50
		public override int GetNumberOfEdges()
		{
			return vtkWedge.vtkWedge_GetNumberOfEdges_16(base.GetCppThis());
		}

		// Token: 0x0601D68E RID: 120462
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWedge_GetNumberOfFaces_17(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D68F RID: 120463 RVA: 0x00298870 File Offset: 0x00296A70
		public override int GetNumberOfFaces()
		{
			return vtkWedge.vtkWedge_GetNumberOfFaces_17(base.GetCppThis());
		}

		// Token: 0x0601D690 RID: 120464
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWedge_GetNumberOfGenerationsFromBase_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D691 RID: 120465 RVA: 0x00298890 File Offset: 0x00296A90
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkWedge.vtkWedge_GetNumberOfGenerationsFromBase_18(base.GetCppThis(), type);
		}

		// Token: 0x0601D692 RID: 120466
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWedge_GetNumberOfGenerationsFromBaseType_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D693 RID: 120467 RVA: 0x002988B0 File Offset: 0x00296AB0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkWedge.vtkWedge_GetNumberOfGenerationsFromBaseType_19(type);
		}

		// Token: 0x0601D694 RID: 120468
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWedge_GetParametricCenter_20(HandleRef pThis, IntPtr pcoords);

		/// <summary>
		/// Return the center of the wedge in parametric coordinates.
		/// </summary>
		// Token: 0x0601D695 RID: 120469 RVA: 0x002988CC File Offset: 0x00296ACC
		public override int GetParametricCenter(IntPtr pcoords)
		{
			return vtkWedge.vtkWedge_GetParametricCenter_20(base.GetCppThis(), pcoords);
		}

		// Token: 0x0601D696 RID: 120470
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWedge_GetParametricCoords_21(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D697 RID: 120471 RVA: 0x002988EC File Offset: 0x00296AEC
		public override IntPtr GetParametricCoords()
		{
			return vtkWedge.vtkWedge_GetParametricCoords_21(base.GetCppThis());
		}

		// Token: 0x0601D698 RID: 120472
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWedge_GetPointToIncidentEdgesArray_22(long pointId);

		/// <summary>
		/// Static method version of GetPointToIncidentEdgesArray.
		/// </summary>
		// Token: 0x0601D699 RID: 120473 RVA: 0x0029890C File Offset: 0x00296B0C
		public static IntPtr GetPointToIncidentEdgesArray(long pointId)
		{
			return vtkWedge.vtkWedge_GetPointToIncidentEdgesArray_22(pointId);
		}

		// Token: 0x0601D69A RID: 120474
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWedge_GetPointToIncidentFacesArray_23(long pointId);

		/// <summary>
		/// Static method version of GetPointToIncidentFacesArray.
		/// </summary>
		// Token: 0x0601D69B RID: 120475 RVA: 0x00298928 File Offset: 0x00296B28
		public static IntPtr GetPointToIncidentFacesArray(long pointId)
		{
			return vtkWedge.vtkWedge_GetPointToIncidentFacesArray_23(pointId);
		}

		// Token: 0x0601D69C RID: 120476
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWedge_GetPointToOneRingPointsArray_24(long pointId);

		/// <summary>
		/// Static method version of GetPointToOneRingPoints.
		/// </summary>
		// Token: 0x0601D69D RID: 120477 RVA: 0x00298944 File Offset: 0x00296B44
		public static IntPtr GetPointToOneRingPointsArray(long pointId)
		{
			return vtkWedge.vtkWedge_GetPointToOneRingPointsArray_24(pointId);
		}

		// Token: 0x0601D69E RID: 120478
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWedge_GetTriangleCases_25(int caseId);

		/// <summary>
		/// Return the case table for table-based isocontouring (aka marching cubes
		/// style implementations). A linear 3D cell with N vertices will have 2**N
		/// cases. The returned case array lists three edges in order to produce one
		/// output triangle which may be repeated to generate multiple triangles. The
		/// list of cases terminates with a -1 entry.
		/// </summary>
		// Token: 0x0601D69F RID: 120479 RVA: 0x00298960 File Offset: 0x00296B60
		public static IntPtr GetTriangleCases(int caseId)
		{
			return vtkWedge.vtkWedge_GetTriangleCases_25(caseId);
		}

		// Token: 0x0601D6A0 RID: 120480
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWedge_InterpolateDerivs_26(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601D6A1 RID: 120481 RVA: 0x0029897A File Offset: 0x00296B7A
		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkWedge.vtkWedge_InterpolateDerivs_26(base.GetCppThis(), pcoords, derivs);
		}

		// Token: 0x0601D6A2 RID: 120482
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWedge_InterpolateFunctions_27(HandleRef pThis, IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601D6A3 RID: 120483 RVA: 0x0029898B File Offset: 0x00296B8B
		public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkWedge.vtkWedge_InterpolateFunctions_27(base.GetCppThis(), pcoords, weights);
		}

		// Token: 0x0601D6A4 RID: 120484
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWedge_InterpolationDerivs_28(IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Return the center of the wedge in parametric coordinates.
		/// </summary>
		// Token: 0x0601D6A5 RID: 120485 RVA: 0x0029899C File Offset: 0x00296B9C
		public static void InterpolationDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkWedge.vtkWedge_InterpolationDerivs_28(pcoords, derivs);
		}

		// Token: 0x0601D6A6 RID: 120486
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWedge_InterpolationFunctions_29(IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Return the center of the wedge in parametric coordinates.
		/// </summary>
		// Token: 0x0601D6A7 RID: 120487 RVA: 0x002989A7 File Offset: 0x00296BA7
		public static void InterpolationFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkWedge.vtkWedge_InterpolationFunctions_29(pcoords, weights);
		}

		// Token: 0x0601D6A8 RID: 120488
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWedge_IntersectWithLine_30(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D6A9 RID: 120489 RVA: 0x002989B4 File Offset: 0x00296BB4
		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkWedge.vtkWedge_IntersectWithLine_30(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		// Token: 0x0601D6AA RID: 120490
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWedge_IsA_31(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D6AB RID: 120491 RVA: 0x002989E0 File Offset: 0x00296BE0
		public override int IsA(string type)
		{
			return vtkWedge.vtkWedge_IsA_31(base.GetCppThis(), type);
		}

		// Token: 0x0601D6AC RID: 120492
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkWedge_IsInsideOut_32(HandleRef pThis);

		/// <summary>
		/// See vtkCell3D API for description of these methods.
		/// </summary>
		// Token: 0x0601D6AD RID: 120493 RVA: 0x00298A00 File Offset: 0x00296C00
		public override bool IsInsideOut()
		{
			return vtkWedge.vtkWedge_IsInsideOut_32(base.GetCppThis()) != 0;
		}

		// Token: 0x0601D6AE RID: 120494
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWedge_IsTypeOf_33([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D6AF RID: 120495 RVA: 0x00298A28 File Offset: 0x00296C28
		public new static int IsTypeOf(string type)
		{
			return vtkWedge.vtkWedge_IsTypeOf_33(type);
		}

		// Token: 0x0601D6B0 RID: 120496
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWedge_NewInstance_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D6B1 RID: 120497 RVA: 0x00298A44 File Offset: 0x00296C44
		public new vtkWedge NewInstance()
		{
			vtkWedge result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWedge.vtkWedge_NewInstance_35(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWedge)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601D6B2 RID: 120498
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWedge_SafeDownCast_36(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D6B3 RID: 120499 RVA: 0x00298AA0 File Offset: 0x00296CA0
		public new static vtkWedge SafeDownCast(vtkObjectBase o)
		{
			vtkWedge vtkWedge = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWedge.vtkWedge_SafeDownCast_36((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWedge = (vtkWedge)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWedge.Register(null);
				}
			}
			return vtkWedge;
		}

		// Token: 0x0601D6B4 RID: 120500
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWedge_TriangulateLocalIds_37(HandleRef pThis, int index, HandleRef ptIds);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D6B5 RID: 120501 RVA: 0x00298B20 File Offset: 0x00296D20
		public override int TriangulateLocalIds(int index, vtkIdList ptIds)
		{
			return vtkWedge.vtkWedge_TriangulateLocalIds_37(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EED RID: 7917
		public new const string MRFullTypeName = "Kitware.VTK.vtkWedge";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EEE RID: 7918
		public new static readonly string MRClassNameKey = "class vtkWedge";
	}
}
