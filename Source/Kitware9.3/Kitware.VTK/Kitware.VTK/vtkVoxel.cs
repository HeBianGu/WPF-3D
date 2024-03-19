using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVoxel
	/// </summary>
	/// <remarks>
	///    a cell that represents a 3D orthogonal parallelepiped
	///
	/// vtkVoxel is a concrete implementation of vtkCell to represent a 3D
	/// orthogonal parallelepiped. Unlike vtkHexahedron, vtkVoxel has interior
	/// angles of 90 degrees, and sides are parallel to coordinate axes. This
	/// results in large increases in computational performance.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkConvexPointSet vtkHexahedron vtkPyramid vtkTetra vtkWedge
	/// </seealso>
	// Token: 0x02000AE2 RID: 2786
	public class vtkVoxel : vtkCell3D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D618 RID: 120344 RVA: 0x00297CAB File Offset: 0x00295EAB
		static vtkVoxel()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVoxel.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVoxel"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D619 RID: 120345 RVA: 0x00297CD3 File Offset: 0x00295ED3
		public vtkVoxel(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601D61A RID: 120346
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVoxel_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D61B RID: 120347 RVA: 0x00297CE4 File Offset: 0x00295EE4
		public new static vtkVoxel New()
		{
			vtkVoxel result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVoxel.vtkVoxel_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVoxel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D61C RID: 120348 RVA: 0x00297D38 File Offset: 0x00295F38
		public vtkVoxel() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkVoxel.vtkVoxel_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D61D RID: 120349 RVA: 0x00297D7C File Offset: 0x00295F7C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D61E RID: 120350
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVoxel_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D61F RID: 120351 RVA: 0x00297D88 File Offset: 0x00295F88
		public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
		{
			return vtkVoxel.vtkVoxel_CellBoundary_01(base.GetCppThis(), subId, pcoords, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601D620 RID: 120352
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkVoxel_ComputeBoundingSphere_02(HandleRef pThis, IntPtr center);

		/// <summary>
		/// Computes exact bounding sphere of this voxel.
		/// </summary>
		// Token: 0x0601D621 RID: 120353 RVA: 0x00297DC0 File Offset: 0x00295FC0
		public override double ComputeBoundingSphere(IntPtr center)
		{
			return vtkVoxel.vtkVoxel_ComputeBoundingSphere_02(base.GetCppThis(), center);
		}

		// Token: 0x0601D622 RID: 120354
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkVoxel_ComputeCentroid_03(HandleRef points, IntPtr pointIds, IntPtr centroid);

		/// <summary>
		/// Static method version of GetCentroid.
		/// </summary>
		// Token: 0x0601D623 RID: 120355 RVA: 0x00297DE0 File Offset: 0x00295FE0
		public static bool ComputeCentroid(vtkPoints points, IntPtr pointIds, IntPtr centroid)
		{
			return vtkVoxel.vtkVoxel_ComputeCentroid_03((points == null) ? default(HandleRef) : points.GetCppThis(), pointIds, centroid) != 0;
		}

		// Token: 0x0601D624 RID: 120356
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoxel_Contour_04(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D625 RID: 120357 RVA: 0x00297E18 File Offset: 0x00296018
		public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
		{
			vtkVoxel.vtkVoxel_Contour_04(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis());
		}

		// Token: 0x0601D626 RID: 120358
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoxel_Derivatives_05(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D627 RID: 120359 RVA: 0x00297F00 File Offset: 0x00296100
		public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
		{
			vtkVoxel.vtkVoxel_Derivatives_05(base.GetCppThis(), subId, pcoords, values, dim, derivs);
		}

		// Token: 0x0601D628 RID: 120360
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoxel_EvaluateLocation_06(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D629 RID: 120361 RVA: 0x00297F16 File Offset: 0x00296116
		public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
		{
			vtkVoxel.vtkVoxel_EvaluateLocation_06(base.GetCppThis(), ref subId, pcoords, x, weights);
		}

		// Token: 0x0601D62A RID: 120362
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVoxel_EvaluatePosition_07(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D62B RID: 120363 RVA: 0x00297F2C File Offset: 0x0029612C
		public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
		{
			return vtkVoxel.vtkVoxel_EvaluatePosition_07(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
		}

		// Token: 0x0601D62C RID: 120364
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVoxel_GetCellDimension_08(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D62D RID: 120365 RVA: 0x00297F54 File Offset: 0x00296154
		public override int GetCellDimension()
		{
			return vtkVoxel.vtkVoxel_GetCellDimension_08(base.GetCppThis());
		}

		// Token: 0x0601D62E RID: 120366
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVoxel_GetCellType_09(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D62F RID: 120367 RVA: 0x00297F74 File Offset: 0x00296174
		public override int GetCellType()
		{
			return vtkVoxel.vtkVoxel_GetCellType_09(base.GetCppThis());
		}

		// Token: 0x0601D630 RID: 120368
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkVoxel_GetCentroid_10(HandleRef pThis, IntPtr centroid);

		/// <summary>
		/// See vtkCell3D API for description of these methods.
		/// @warning Face points of vtkVoxel are not sorted properly.
		/// {pts[0], pts[1], pts[3], pts[2]} forms consecutive points of one face.
		/// </summary>
		// Token: 0x0601D631 RID: 120369 RVA: 0x00297F94 File Offset: 0x00296194
		public override bool GetCentroid(IntPtr centroid)
		{
			return vtkVoxel.vtkVoxel_GetCentroid_10(base.GetCppThis(), centroid) != 0;
		}

		// Token: 0x0601D632 RID: 120370
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVoxel_GetEdge_11(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D633 RID: 120371 RVA: 0x00297FBC File Offset: 0x002961BC
		public override vtkCell GetEdge(int edgeId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVoxel.vtkVoxel_GetEdge_11(base.GetCppThis(), edgeId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601D634 RID: 120372
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVoxel_GetEdgeArray_12(long edgeId);

		/// <summary>
		/// Return the ids of the vertices defining edge/face (`edgeId`/`faceId').
		/// Ids are related to the cell, not to the dataset.
		///
		/// @note The return type changed. It used to be int*, it is now const vtkIdType*.
		/// This is so ids are unified between vtkCell and vtkPoints, and so vtkCell ids
		/// can be used as inputs in algorithms such as vtkPolygon::ComputeNormal.
		/// </summary>
		// Token: 0x0601D635 RID: 120373 RVA: 0x0029802C File Offset: 0x0029622C
		public static IntPtr GetEdgeArray(long edgeId)
		{
			return vtkVoxel.vtkVoxel_GetEdgeArray_12(edgeId);
		}

		// Token: 0x0601D636 RID: 120374
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVoxel_GetEdgeToAdjacentFacesArray_13(long edgeId);

		/// <summary>
		/// Static method version of GetEdgeToAdjacentFaces.
		/// </summary>
		// Token: 0x0601D637 RID: 120375 RVA: 0x00298048 File Offset: 0x00296248
		public static IntPtr GetEdgeToAdjacentFacesArray(long edgeId)
		{
			return vtkVoxel.vtkVoxel_GetEdgeToAdjacentFacesArray_13(edgeId);
		}

		// Token: 0x0601D638 RID: 120376
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVoxel_GetFace_14(HandleRef pThis, int faceId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D639 RID: 120377 RVA: 0x00298064 File Offset: 0x00296264
		public override vtkCell GetFace(int faceId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVoxel.vtkVoxel_GetFace_14(base.GetCppThis(), faceId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601D63A RID: 120378
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVoxel_GetFaceArray_15(long faceId);

		/// <summary>
		/// Return the ids of the vertices defining edge/face (`edgeId`/`faceId').
		/// Ids are related to the cell, not to the dataset.
		///
		/// @note The return type changed. It used to be int*, it is now const vtkIdType*.
		/// This is so ids are unified between vtkCell and vtkPoints, and so vtkCell ids
		/// can be used as inputs in algorithms such as vtkPolygon::ComputeNormal.
		/// </summary>
		// Token: 0x0601D63B RID: 120379 RVA: 0x002980D4 File Offset: 0x002962D4
		public static IntPtr GetFaceArray(long faceId)
		{
			return vtkVoxel.vtkVoxel_GetFaceArray_15(faceId);
		}

		// Token: 0x0601D63C RID: 120380
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVoxel_GetFaceToAdjacentFacesArray_16(long faceId);

		/// <summary>
		/// Static method version of GetFaceToAdjacentFaces.
		/// </summary>
		// Token: 0x0601D63D RID: 120381 RVA: 0x002980F0 File Offset: 0x002962F0
		public static IntPtr GetFaceToAdjacentFacesArray(long faceId)
		{
			return vtkVoxel.vtkVoxel_GetFaceToAdjacentFacesArray_16(faceId);
		}

		// Token: 0x0601D63E RID: 120382
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVoxel_GetNumberOfEdges_17(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D63F RID: 120383 RVA: 0x0029810C File Offset: 0x0029630C
		public override int GetNumberOfEdges()
		{
			return vtkVoxel.vtkVoxel_GetNumberOfEdges_17(base.GetCppThis());
		}

		// Token: 0x0601D640 RID: 120384
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVoxel_GetNumberOfFaces_18(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D641 RID: 120385 RVA: 0x0029812C File Offset: 0x0029632C
		public override int GetNumberOfFaces()
		{
			return vtkVoxel.vtkVoxel_GetNumberOfFaces_18(base.GetCppThis());
		}

		// Token: 0x0601D642 RID: 120386
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVoxel_GetNumberOfGenerationsFromBase_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D643 RID: 120387 RVA: 0x0029814C File Offset: 0x0029634C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVoxel.vtkVoxel_GetNumberOfGenerationsFromBase_19(base.GetCppThis(), type);
		}

		// Token: 0x0601D644 RID: 120388
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVoxel_GetNumberOfGenerationsFromBaseType_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D645 RID: 120389 RVA: 0x0029816C File Offset: 0x0029636C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVoxel.vtkVoxel_GetNumberOfGenerationsFromBaseType_20(type);
		}

		// Token: 0x0601D646 RID: 120390
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVoxel_GetParametricCoords_21(HandleRef pThis);

		/// <summary>
		/// See vtkCell3D API for description of these methods.
		/// @warning Face points of vtkVoxel are not sorted properly.
		/// {pts[0], pts[1], pts[3], pts[2]} forms consecutive points of one face.
		/// </summary>
		// Token: 0x0601D647 RID: 120391 RVA: 0x00298188 File Offset: 0x00296388
		public override IntPtr GetParametricCoords()
		{
			return vtkVoxel.vtkVoxel_GetParametricCoords_21(base.GetCppThis());
		}

		// Token: 0x0601D648 RID: 120392
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVoxel_GetPointToIncidentEdgesArray_22(long pointId);

		/// <summary>
		/// Static method version of GetPointToIncidentEdgesArray.
		/// </summary>
		// Token: 0x0601D649 RID: 120393 RVA: 0x002981A8 File Offset: 0x002963A8
		public static IntPtr GetPointToIncidentEdgesArray(long pointId)
		{
			return vtkVoxel.vtkVoxel_GetPointToIncidentEdgesArray_22(pointId);
		}

		// Token: 0x0601D64A RID: 120394
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVoxel_GetPointToIncidentFacesArray_23(long pointId);

		/// <summary>
		/// Static method version of GetPointToIncidentFacesArray.
		/// </summary>
		// Token: 0x0601D64B RID: 120395 RVA: 0x002981C4 File Offset: 0x002963C4
		public static IntPtr GetPointToIncidentFacesArray(long pointId)
		{
			return vtkVoxel.vtkVoxel_GetPointToIncidentFacesArray_23(pointId);
		}

		// Token: 0x0601D64C RID: 120396
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVoxel_GetPointToOneRingPointsArray_24(long pointId);

		/// <summary>
		/// Static method version of GetPointToOneRingPoints.
		/// </summary>
		// Token: 0x0601D64D RID: 120397 RVA: 0x002981E0 File Offset: 0x002963E0
		public static IntPtr GetPointToOneRingPointsArray(long pointId)
		{
			return vtkVoxel.vtkVoxel_GetPointToOneRingPointsArray_24(pointId);
		}

		// Token: 0x0601D64E RID: 120398
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVoxel_GetTriangleCases_25(int caseId);

		/// <summary>
		/// Return the case table for table-based isocontouring (aka marching cubes
		/// style implementations). A linear 3D cell with N vertices will have 2**N
		/// cases. The returned case array lists three edges in order to produce one
		/// output triangle which may be repeated to generate multiple triangles. The
		/// list of cases terminates with a -1 entry.
		/// </summary>
		// Token: 0x0601D64F RID: 120399 RVA: 0x002981FC File Offset: 0x002963FC
		public static IntPtr GetTriangleCases(int caseId)
		{
			return vtkVoxel.vtkVoxel_GetTriangleCases_25(caseId);
		}

		// Token: 0x0601D650 RID: 120400
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVoxel_Inflate_26(HandleRef pThis, double dist);

		/// <summary>
		/// Inflates voxel by moving every faces by dist. Since normals are not
		/// ambiguous for degenerate voxels, degenerate voxels are inflated correctly.
		/// For example, inflating a voxel collapsed to a single point will produce a
		/// voxel of width 2 * dist.
		///
		/// \return 1
		/// </summary>
		// Token: 0x0601D651 RID: 120401 RVA: 0x00298218 File Offset: 0x00296418
		public override int Inflate(double dist)
		{
			return vtkVoxel.vtkVoxel_Inflate_26(base.GetCppThis(), dist);
		}

		// Token: 0x0601D652 RID: 120402
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoxel_InterpolateDerivs_27(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601D653 RID: 120403 RVA: 0x00298238 File Offset: 0x00296438
		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkVoxel.vtkVoxel_InterpolateDerivs_27(base.GetCppThis(), pcoords, derivs);
		}

		// Token: 0x0601D654 RID: 120404
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoxel_InterpolateFunctions_28(HandleRef pThis, IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601D655 RID: 120405 RVA: 0x00298249 File Offset: 0x00296449
		public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkVoxel.vtkVoxel_InterpolateFunctions_28(base.GetCppThis(), pcoords, weights);
		}

		// Token: 0x0601D656 RID: 120406
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoxel_InterpolationDerivs_29(IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Inflates voxel by moving every faces by dist. Since normals are not
		/// ambiguous for degenerate voxels, degenerate voxels are inflated correctly.
		/// For example, inflating a voxel collapsed to a single point will produce a
		/// voxel of width 2 * dist.
		///
		/// \return 1
		/// </summary>
		// Token: 0x0601D657 RID: 120407 RVA: 0x0029825A File Offset: 0x0029645A
		public static void InterpolationDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkVoxel.vtkVoxel_InterpolationDerivs_29(pcoords, derivs);
		}

		// Token: 0x0601D658 RID: 120408
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoxel_InterpolationFunctions_30(IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Compute the interpolation functions.
		/// This static method is for convenience. Use the member function
		/// if you already have an instance of a voxel.
		/// </summary>
		// Token: 0x0601D659 RID: 120409 RVA: 0x00298265 File Offset: 0x00296465
		public static void InterpolationFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkVoxel.vtkVoxel_InterpolationFunctions_30(pcoords, weights);
		}

		// Token: 0x0601D65A RID: 120410
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVoxel_IntersectWithLine_31(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D65B RID: 120411 RVA: 0x00298270 File Offset: 0x00296470
		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkVoxel.vtkVoxel_IntersectWithLine_31(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		// Token: 0x0601D65C RID: 120412
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVoxel_IsA_32(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D65D RID: 120413 RVA: 0x0029829C File Offset: 0x0029649C
		public override int IsA(string type)
		{
			return vtkVoxel.vtkVoxel_IsA_32(base.GetCppThis(), type);
		}

		// Token: 0x0601D65E RID: 120414
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkVoxel_IsInsideOut_33(HandleRef pThis);

		/// <summary>
		/// See vtkCell3D API for description of these methods.
		/// @warning Face points of vtkVoxel are not sorted properly.
		/// {pts[0], pts[1], pts[3], pts[2]} forms consecutive points of one face.
		/// </summary>
		// Token: 0x0601D65F RID: 120415 RVA: 0x002982BC File Offset: 0x002964BC
		public override bool IsInsideOut()
		{
			return vtkVoxel.vtkVoxel_IsInsideOut_33(base.GetCppThis()) != 0;
		}

		// Token: 0x0601D660 RID: 120416
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVoxel_IsTypeOf_34([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D661 RID: 120417 RVA: 0x002982E4 File Offset: 0x002964E4
		public new static int IsTypeOf(string type)
		{
			return vtkVoxel.vtkVoxel_IsTypeOf_34(type);
		}

		// Token: 0x0601D662 RID: 120418
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVoxel_NewInstance_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D663 RID: 120419 RVA: 0x00298300 File Offset: 0x00296500
		public new vtkVoxel NewInstance()
		{
			vtkVoxel result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVoxel.vtkVoxel_NewInstance_36(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVoxel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601D664 RID: 120420
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVoxel_SafeDownCast_37(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D665 RID: 120421 RVA: 0x0029835C File Offset: 0x0029655C
		public new static vtkVoxel SafeDownCast(vtkObjectBase o)
		{
			vtkVoxel vtkVoxel = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVoxel.vtkVoxel_SafeDownCast_37((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVoxel = (vtkVoxel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVoxel.Register(null);
				}
			}
			return vtkVoxel;
		}

		// Token: 0x0601D666 RID: 120422
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVoxel_TriangulateLocalIds_38(HandleRef pThis, int index, HandleRef ptIds);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D667 RID: 120423 RVA: 0x002983DC File Offset: 0x002965DC
		public override int TriangulateLocalIds(int index, vtkIdList ptIds)
		{
			return vtkVoxel.vtkVoxel_TriangulateLocalIds_38(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EEB RID: 7915
		public new const string MRFullTypeName = "Kitware.VTK.vtkVoxel";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EEC RID: 7916
		public new static readonly string MRClassNameKey = "class vtkVoxel";
	}
}
