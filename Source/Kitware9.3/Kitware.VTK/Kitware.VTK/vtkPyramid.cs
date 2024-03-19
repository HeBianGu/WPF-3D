using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPyramid
	/// </summary>
	/// <remarks>
	///    a 3D cell that represents a linear pyramid
	///
	/// vtkPyramid is a concrete implementation of vtkCell to represent a 3D
	/// pyramid. A pyramid consists of a rectangular base with four triangular
	/// faces. vtkPyramid uses the standard isoparametric shape functions for
	/// a linear pyramid. The pyramid is defined by the five points (0-4) where
	/// (0,1,2,3) is the base of the pyramid which, using the right hand rule,
	/// forms a quadrilaterial whose normal points in the direction of the
	/// pyramid apex at vertex #4. The parametric location of vertex #4 is [0, 0, 1].
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkConvexPointSet vtkHexahedron vtkTetra vtkVoxel vtkWedge
	/// </seealso>
	// Token: 0x02000AA9 RID: 2729
	public class vtkPyramid : vtkCell3D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601CA88 RID: 117384 RVA: 0x00284A82 File Offset: 0x00282C82
		static vtkPyramid()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPyramid.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPyramid"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601CA89 RID: 117385 RVA: 0x00284AAA File Offset: 0x00282CAA
		public vtkPyramid(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601CA8A RID: 117386
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPyramid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CA8B RID: 117387 RVA: 0x00284AB8 File Offset: 0x00282CB8
		public new static vtkPyramid New()
		{
			vtkPyramid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPyramid.vtkPyramid_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPyramid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CA8C RID: 117388 RVA: 0x00284B0C File Offset: 0x00282D0C
		public vtkPyramid() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPyramid.vtkPyramid_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601CA8D RID: 117389 RVA: 0x00284B50 File Offset: 0x00282D50
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601CA8E RID: 117390
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPyramid_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601CA8F RID: 117391 RVA: 0x00284B5C File Offset: 0x00282D5C
		public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
		{
			return vtkPyramid.vtkPyramid_CellBoundary_01(base.GetCppThis(), subId, pcoords, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601CA90 RID: 117392
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPyramid_ComputeCentroid_02(HandleRef points, IntPtr pointIds, IntPtr centroid);

		/// <summary>
		/// Static method version of GetCentroid.
		/// </summary>
		// Token: 0x0601CA91 RID: 117393 RVA: 0x00284B94 File Offset: 0x00282D94
		public static bool ComputeCentroid(vtkPoints points, IntPtr pointIds, IntPtr centroid)
		{
			return vtkPyramid.vtkPyramid_ComputeCentroid_02((points == null) ? default(HandleRef) : points.GetCppThis(), pointIds, centroid) != 0;
		}

		// Token: 0x0601CA92 RID: 117394
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPyramid_Contour_03(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601CA93 RID: 117395 RVA: 0x00284BCC File Offset: 0x00282DCC
		public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
		{
			vtkPyramid.vtkPyramid_Contour_03(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis());
		}

		// Token: 0x0601CA94 RID: 117396
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPyramid_Derivatives_04(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601CA95 RID: 117397 RVA: 0x00284CB4 File Offset: 0x00282EB4
		public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
		{
			vtkPyramid.vtkPyramid_Derivatives_04(base.GetCppThis(), subId, pcoords, values, dim, derivs);
		}

		// Token: 0x0601CA96 RID: 117398
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPyramid_EvaluateLocation_05(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601CA97 RID: 117399 RVA: 0x00284CCA File Offset: 0x00282ECA
		public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
		{
			vtkPyramid.vtkPyramid_EvaluateLocation_05(base.GetCppThis(), ref subId, pcoords, x, weights);
		}

		// Token: 0x0601CA98 RID: 117400
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPyramid_EvaluatePosition_06(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601CA99 RID: 117401 RVA: 0x00284CE0 File Offset: 0x00282EE0
		public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
		{
			return vtkPyramid.vtkPyramid_EvaluatePosition_06(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
		}

		// Token: 0x0601CA9A RID: 117402
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPyramid_GetCellDimension_07(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601CA9B RID: 117403 RVA: 0x00284D08 File Offset: 0x00282F08
		public override int GetCellDimension()
		{
			return vtkPyramid.vtkPyramid_GetCellDimension_07(base.GetCppThis());
		}

		// Token: 0x0601CA9C RID: 117404
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPyramid_GetCellType_08(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601CA9D RID: 117405 RVA: 0x00284D28 File Offset: 0x00282F28
		public override int GetCellType()
		{
			return vtkPyramid.vtkPyramid_GetCellType_08(base.GetCppThis());
		}

		// Token: 0x0601CA9E RID: 117406
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPyramid_GetCentroid_09(HandleRef pThis, IntPtr centroid);

		/// <summary>
		/// See vtkCell3D API for description of these methods.
		/// </summary>
		// Token: 0x0601CA9F RID: 117407 RVA: 0x00284D48 File Offset: 0x00282F48
		public override bool GetCentroid(IntPtr centroid)
		{
			return vtkPyramid.vtkPyramid_GetCentroid_09(base.GetCppThis(), centroid) != 0;
		}

		// Token: 0x0601CAA0 RID: 117408
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPyramid_GetEdge_10(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601CAA1 RID: 117409 RVA: 0x00284D70 File Offset: 0x00282F70
		public override vtkCell GetEdge(int edgeId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPyramid.vtkPyramid_GetEdge_10(base.GetCppThis(), edgeId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601CAA2 RID: 117410
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPyramid_GetEdgeArray_11(long edgeId);

		/// <summary>
		/// Return the ids of the vertices defining edge/face (`edgeId`/`faceId').
		/// Ids are related to the cell, not to the dataset.
		///
		/// @note The return type changed. It used to be int*, it is now const vtkIdType*.
		/// This is so ids are unified between vtkCell and vtkPoints, and so vtkCell ids
		/// can be used as inputs in algorithms such as vtkPolygon::ComputeNormal.
		/// </summary>
		// Token: 0x0601CAA3 RID: 117411 RVA: 0x00284DE0 File Offset: 0x00282FE0
		public static IntPtr GetEdgeArray(long edgeId)
		{
			return vtkPyramid.vtkPyramid_GetEdgeArray_11(edgeId);
		}

		// Token: 0x0601CAA4 RID: 117412
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPyramid_GetEdgeToAdjacentFacesArray_12(long edgeId);

		/// <summary>
		/// Static method version of GetEdgeToAdjacentFaces.
		/// </summary>
		// Token: 0x0601CAA5 RID: 117413 RVA: 0x00284DFC File Offset: 0x00282FFC
		public static IntPtr GetEdgeToAdjacentFacesArray(long edgeId)
		{
			return vtkPyramid.vtkPyramid_GetEdgeToAdjacentFacesArray_12(edgeId);
		}

		// Token: 0x0601CAA6 RID: 117414
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPyramid_GetFace_13(HandleRef pThis, int faceId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601CAA7 RID: 117415 RVA: 0x00284E18 File Offset: 0x00283018
		public override vtkCell GetFace(int faceId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPyramid.vtkPyramid_GetFace_13(base.GetCppThis(), faceId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601CAA8 RID: 117416
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPyramid_GetFaceArray_14(long faceId);

		/// <summary>
		/// Return the ids of the vertices defining edge/face (`edgeId`/`faceId').
		/// Ids are related to the cell, not to the dataset.
		///
		/// @note The return type changed. It used to be int*, it is now const vtkIdType*.
		/// This is so ids are unified between vtkCell and vtkPoints, and so vtkCell ids
		/// can be used as inputs in algorithms such as vtkPolygon::ComputeNormal.
		/// </summary>
		// Token: 0x0601CAA9 RID: 117417 RVA: 0x00284E88 File Offset: 0x00283088
		public static IntPtr GetFaceArray(long faceId)
		{
			return vtkPyramid.vtkPyramid_GetFaceArray_14(faceId);
		}

		// Token: 0x0601CAAA RID: 117418
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPyramid_GetFaceToAdjacentFacesArray_15(long faceId);

		/// <summary>
		/// Static method version of GetFaceToAdjacentFaces.
		/// </summary>
		// Token: 0x0601CAAB RID: 117419 RVA: 0x00284EA4 File Offset: 0x002830A4
		public static IntPtr GetFaceToAdjacentFacesArray(long faceId)
		{
			return vtkPyramid.vtkPyramid_GetFaceToAdjacentFacesArray_15(faceId);
		}

		// Token: 0x0601CAAC RID: 117420
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPyramid_GetNumberOfEdges_16(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601CAAD RID: 117421 RVA: 0x00284EC0 File Offset: 0x002830C0
		public override int GetNumberOfEdges()
		{
			return vtkPyramid.vtkPyramid_GetNumberOfEdges_16(base.GetCppThis());
		}

		// Token: 0x0601CAAE RID: 117422
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPyramid_GetNumberOfFaces_17(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601CAAF RID: 117423 RVA: 0x00284EE0 File Offset: 0x002830E0
		public override int GetNumberOfFaces()
		{
			return vtkPyramid.vtkPyramid_GetNumberOfFaces_17(base.GetCppThis());
		}

		// Token: 0x0601CAB0 RID: 117424
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPyramid_GetNumberOfGenerationsFromBase_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CAB1 RID: 117425 RVA: 0x00284F00 File Offset: 0x00283100
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPyramid.vtkPyramid_GetNumberOfGenerationsFromBase_18(base.GetCppThis(), type);
		}

		// Token: 0x0601CAB2 RID: 117426
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPyramid_GetNumberOfGenerationsFromBaseType_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CAB3 RID: 117427 RVA: 0x00284F20 File Offset: 0x00283120
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPyramid.vtkPyramid_GetNumberOfGenerationsFromBaseType_19(type);
		}

		// Token: 0x0601CAB4 RID: 117428
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPyramid_GetParametricCenter_20(HandleRef pThis, IntPtr pcoords);

		/// <summary>
		/// Return the center of the pyramid in parametric coordinates.
		/// </summary>
		// Token: 0x0601CAB5 RID: 117429 RVA: 0x00284F3C File Offset: 0x0028313C
		public override int GetParametricCenter(IntPtr pcoords)
		{
			return vtkPyramid.vtkPyramid_GetParametricCenter_20(base.GetCppThis(), pcoords);
		}

		// Token: 0x0601CAB6 RID: 117430
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPyramid_GetParametricCoords_21(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601CAB7 RID: 117431 RVA: 0x00284F5C File Offset: 0x0028315C
		public override IntPtr GetParametricCoords()
		{
			return vtkPyramid.vtkPyramid_GetParametricCoords_21(base.GetCppThis());
		}

		// Token: 0x0601CAB8 RID: 117432
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPyramid_GetPointToIncidentEdgesArray_22(long pointId);

		/// <summary>
		/// Static method version of GetPointToIncidentEdgesArray.
		/// </summary>
		// Token: 0x0601CAB9 RID: 117433 RVA: 0x00284F7C File Offset: 0x0028317C
		public static IntPtr GetPointToIncidentEdgesArray(long pointId)
		{
			return vtkPyramid.vtkPyramid_GetPointToIncidentEdgesArray_22(pointId);
		}

		// Token: 0x0601CABA RID: 117434
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPyramid_GetPointToIncidentFacesArray_23(long pointId);

		/// <summary>
		/// Static method version of GetPointToIncidentFacesArray.
		/// </summary>
		// Token: 0x0601CABB RID: 117435 RVA: 0x00284F98 File Offset: 0x00283198
		public static IntPtr GetPointToIncidentFacesArray(long pointId)
		{
			return vtkPyramid.vtkPyramid_GetPointToIncidentFacesArray_23(pointId);
		}

		// Token: 0x0601CABC RID: 117436
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPyramid_GetPointToOneRingPointsArray_24(long pointId);

		/// <summary>
		/// Static method version of GetPointToOneRingPoints.
		/// </summary>
		// Token: 0x0601CABD RID: 117437 RVA: 0x00284FB4 File Offset: 0x002831B4
		public static IntPtr GetPointToOneRingPointsArray(long pointId)
		{
			return vtkPyramid.vtkPyramid_GetPointToOneRingPointsArray_24(pointId);
		}

		// Token: 0x0601CABE RID: 117438
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPyramid_GetTriangleCases_25(int caseId);

		/// <summary>
		/// Return the case table for table-based isocontouring (aka marching cubes
		/// style implementations). A linear 3D cell with N vertices will have 2**N
		/// cases. The returned case array lists three edges in order to produce one
		/// output triangle which may be repeated to generate multiple triangles. The
		/// list of cases terminates with a -1 entry.
		/// </summary>
		// Token: 0x0601CABF RID: 117439 RVA: 0x00284FD0 File Offset: 0x002831D0
		public static IntPtr GetTriangleCases(int caseId)
		{
			return vtkPyramid.vtkPyramid_GetTriangleCases_25(caseId);
		}

		// Token: 0x0601CAC0 RID: 117440
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPyramid_InterpolateDerivs_26(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601CAC1 RID: 117441 RVA: 0x00284FEA File Offset: 0x002831EA
		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkPyramid.vtkPyramid_InterpolateDerivs_26(base.GetCppThis(), pcoords, derivs);
		}

		// Token: 0x0601CAC2 RID: 117442
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPyramid_InterpolateFunctions_27(HandleRef pThis, IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601CAC3 RID: 117443 RVA: 0x00284FFB File Offset: 0x002831FB
		public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkPyramid.vtkPyramid_InterpolateFunctions_27(base.GetCppThis(), pcoords, weights);
		}

		// Token: 0x0601CAC4 RID: 117444
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPyramid_InterpolationDerivs_28(IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Return the center of the pyramid in parametric coordinates.
		/// </summary>
		// Token: 0x0601CAC5 RID: 117445 RVA: 0x0028500C File Offset: 0x0028320C
		public static void InterpolationDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkPyramid.vtkPyramid_InterpolationDerivs_28(pcoords, derivs);
		}

		// Token: 0x0601CAC6 RID: 117446
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPyramid_InterpolationFunctions_29(IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Return the center of the pyramid in parametric coordinates.
		/// </summary>
		// Token: 0x0601CAC7 RID: 117447 RVA: 0x00285017 File Offset: 0x00283217
		public static void InterpolationFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkPyramid.vtkPyramid_InterpolationFunctions_29(pcoords, weights);
		}

		// Token: 0x0601CAC8 RID: 117448
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPyramid_IntersectWithLine_30(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601CAC9 RID: 117449 RVA: 0x00285024 File Offset: 0x00283224
		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkPyramid.vtkPyramid_IntersectWithLine_30(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		// Token: 0x0601CACA RID: 117450
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPyramid_IsA_31(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CACB RID: 117451 RVA: 0x00285050 File Offset: 0x00283250
		public override int IsA(string type)
		{
			return vtkPyramid.vtkPyramid_IsA_31(base.GetCppThis(), type);
		}

		// Token: 0x0601CACC RID: 117452
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPyramid_IsInsideOut_32(HandleRef pThis);

		/// <summary>
		/// See vtkCell3D API for description of these methods.
		/// </summary>
		// Token: 0x0601CACD RID: 117453 RVA: 0x00285070 File Offset: 0x00283270
		public override bool IsInsideOut()
		{
			return vtkPyramid.vtkPyramid_IsInsideOut_32(base.GetCppThis()) != 0;
		}

		// Token: 0x0601CACE RID: 117454
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPyramid_IsTypeOf_33([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CACF RID: 117455 RVA: 0x00285098 File Offset: 0x00283298
		public new static int IsTypeOf(string type)
		{
			return vtkPyramid.vtkPyramid_IsTypeOf_33(type);
		}

		// Token: 0x0601CAD0 RID: 117456
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPyramid_NewInstance_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CAD1 RID: 117457 RVA: 0x002850B4 File Offset: 0x002832B4
		public new vtkPyramid NewInstance()
		{
			vtkPyramid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPyramid.vtkPyramid_NewInstance_35(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPyramid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601CAD2 RID: 117458
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPyramid_SafeDownCast_36(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CAD3 RID: 117459 RVA: 0x00285110 File Offset: 0x00283310
		public new static vtkPyramid SafeDownCast(vtkObjectBase o)
		{
			vtkPyramid vtkPyramid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPyramid.vtkPyramid_SafeDownCast_36((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPyramid = (vtkPyramid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPyramid.Register(null);
				}
			}
			return vtkPyramid;
		}

		// Token: 0x0601CAD4 RID: 117460
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPyramid_TriangulateLocalIds_37(HandleRef pThis, int index, HandleRef ptIds);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601CAD5 RID: 117461 RVA: 0x00285190 File Offset: 0x00283390
		public override int TriangulateLocalIds(int index, vtkIdList ptIds)
		{
			return vtkPyramid.vtkPyramid_TriangulateLocalIds_37(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E5B RID: 7771
		public new const string MRFullTypeName = "Kitware.VTK.vtkPyramid";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E5C RID: 7772
		public new static readonly string MRClassNameKey = "class vtkPyramid";
	}
}
