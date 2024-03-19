using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkHexahedron
	/// </summary>
	/// <remarks>
	///    a cell that represents a linear 3D hexahedron
	///
	/// vtkHexahedron is a concrete implementation of vtkCell to represent a
	/// linear, 3D rectangular hexahedron (e.g., "brick" topology). vtkHexahedron
	/// uses the standard isoparametric shape functions for a linear
	/// hexahedron. The hexahedron is defined by the eight points (0-7) where
	/// (0,1,2,3) is the base of the hexahedron which, using the right hand rule,
	/// forms a quadrilaterial whose normal points in the direction of the
	/// opposite face (4,5,6,7).
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkConvexPointSet vtkPyramid vtkTetra vtkVoxel vtkWedge
	/// </seealso>
	// Token: 0x02000A57 RID: 2647
	public class vtkHexahedron : vtkCell3D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601BA48 RID: 113224 RVA: 0x0026B0B5 File Offset: 0x002692B5
		static vtkHexahedron()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHexahedron.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHexahedron"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601BA49 RID: 113225 RVA: 0x0026B0DD File Offset: 0x002692DD
		public vtkHexahedron(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601BA4A RID: 113226
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHexahedron_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BA4B RID: 113227 RVA: 0x0026B0EC File Offset: 0x002692EC
		public new static vtkHexahedron New()
		{
			vtkHexahedron result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHexahedron.vtkHexahedron_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHexahedron)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BA4C RID: 113228 RVA: 0x0026B140 File Offset: 0x00269340
		public vtkHexahedron() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkHexahedron.vtkHexahedron_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601BA4D RID: 113229 RVA: 0x0026B184 File Offset: 0x00269384
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601BA4E RID: 113230
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHexahedron_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601BA4F RID: 113231 RVA: 0x0026B190 File Offset: 0x00269390
		public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
		{
			return vtkHexahedron.vtkHexahedron_CellBoundary_01(base.GetCppThis(), subId, pcoords, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601BA50 RID: 113232
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHexahedron_ComputeCentroid_02(HandleRef points, IntPtr pointIds, IntPtr centroid);

		/// <summary>
		/// Static method version of GetCentroid.
		/// </summary>
		// Token: 0x0601BA51 RID: 113233 RVA: 0x0026B1C8 File Offset: 0x002693C8
		public static bool ComputeCentroid(vtkPoints points, IntPtr pointIds, IntPtr centroid)
		{
			return vtkHexahedron.vtkHexahedron_ComputeCentroid_02((points == null) ? default(HandleRef) : points.GetCppThis(), pointIds, centroid) != 0;
		}

		// Token: 0x0601BA52 RID: 113234
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHexahedron_Contour_03(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601BA53 RID: 113235 RVA: 0x0026B200 File Offset: 0x00269400
		public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
		{
			vtkHexahedron.vtkHexahedron_Contour_03(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis());
		}

		// Token: 0x0601BA54 RID: 113236
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHexahedron_Derivatives_04(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601BA55 RID: 113237 RVA: 0x0026B2E8 File Offset: 0x002694E8
		public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
		{
			vtkHexahedron.vtkHexahedron_Derivatives_04(base.GetCppThis(), subId, pcoords, values, dim, derivs);
		}

		// Token: 0x0601BA56 RID: 113238
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHexahedron_EvaluateLocation_05(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601BA57 RID: 113239 RVA: 0x0026B2FE File Offset: 0x002694FE
		public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
		{
			vtkHexahedron.vtkHexahedron_EvaluateLocation_05(base.GetCppThis(), ref subId, pcoords, x, weights);
		}

		// Token: 0x0601BA58 RID: 113240
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHexahedron_EvaluatePosition_06(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601BA59 RID: 113241 RVA: 0x0026B314 File Offset: 0x00269514
		public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
		{
			return vtkHexahedron.vtkHexahedron_EvaluatePosition_06(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
		}

		// Token: 0x0601BA5A RID: 113242
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHexahedron_GetCellType_07(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601BA5B RID: 113243 RVA: 0x0026B33C File Offset: 0x0026953C
		public override int GetCellType()
		{
			return vtkHexahedron.vtkHexahedron_GetCellType_07(base.GetCppThis());
		}

		// Token: 0x0601BA5C RID: 113244
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHexahedron_GetCentroid_08(HandleRef pThis, IntPtr centroid);

		/// <summary>
		/// See vtkCell3D API for description of these methods.
		/// </summary>
		// Token: 0x0601BA5D RID: 113245 RVA: 0x0026B35C File Offset: 0x0026955C
		public override bool GetCentroid(IntPtr centroid)
		{
			return vtkHexahedron.vtkHexahedron_GetCentroid_08(base.GetCppThis(), centroid) != 0;
		}

		// Token: 0x0601BA5E RID: 113246
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHexahedron_GetEdge_09(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601BA5F RID: 113247 RVA: 0x0026B384 File Offset: 0x00269584
		public override vtkCell GetEdge(int edgeId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHexahedron.vtkHexahedron_GetEdge_09(base.GetCppThis(), edgeId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601BA60 RID: 113248
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHexahedron_GetEdgeArray_10(long edgeId);

		/// <summary>
		/// Return the ids of the vertices defining edge/face (`edgeId`/`faceId').
		/// Ids are related to the cell, not to the dataset.
		///
		/// @note The return type changed. It used to be int*, it is now const vtkIdType*.
		/// This is so ids are unified between vtkCell and vtkPoints, and so vtkCell ids
		/// can be used as inputs in algorithms such as vtkPolygon::ComputeNormal.
		/// </summary>
		// Token: 0x0601BA61 RID: 113249 RVA: 0x0026B3F4 File Offset: 0x002695F4
		public static IntPtr GetEdgeArray(long edgeId)
		{
			return vtkHexahedron.vtkHexahedron_GetEdgeArray_10(edgeId);
		}

		// Token: 0x0601BA62 RID: 113250
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHexahedron_GetEdgeToAdjacentFacesArray_11(long edgeId);

		/// <summary>
		/// Static method version of GetEdgeToAdjacentFaces.
		/// </summary>
		// Token: 0x0601BA63 RID: 113251 RVA: 0x0026B410 File Offset: 0x00269610
		public static IntPtr GetEdgeToAdjacentFacesArray(long edgeId)
		{
			return vtkHexahedron.vtkHexahedron_GetEdgeToAdjacentFacesArray_11(edgeId);
		}

		// Token: 0x0601BA64 RID: 113252
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHexahedron_GetFace_12(HandleRef pThis, int faceId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601BA65 RID: 113253 RVA: 0x0026B42C File Offset: 0x0026962C
		public override vtkCell GetFace(int faceId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHexahedron.vtkHexahedron_GetFace_12(base.GetCppThis(), faceId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601BA66 RID: 113254
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHexahedron_GetFaceArray_13(long faceId);

		/// <summary>
		/// Return the ids of the vertices defining edge/face (`edgeId`/`faceId').
		/// Ids are related to the cell, not to the dataset.
		///
		/// @note The return type changed. It used to be int*, it is now const vtkIdType*.
		/// This is so ids are unified between vtkCell and vtkPoints, and so vtkCell ids
		/// can be used as inputs in algorithms such as vtkPolygon::ComputeNormal.
		/// </summary>
		// Token: 0x0601BA67 RID: 113255 RVA: 0x0026B49C File Offset: 0x0026969C
		public static IntPtr GetFaceArray(long faceId)
		{
			return vtkHexahedron.vtkHexahedron_GetFaceArray_13(faceId);
		}

		// Token: 0x0601BA68 RID: 113256
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHexahedron_GetFaceToAdjacentFacesArray_14(long faceId);

		/// <summary>
		/// Static method version of GetFaceToAdjacentFaces.
		/// </summary>
		// Token: 0x0601BA69 RID: 113257 RVA: 0x0026B4B8 File Offset: 0x002696B8
		public static IntPtr GetFaceToAdjacentFacesArray(long faceId)
		{
			return vtkHexahedron.vtkHexahedron_GetFaceToAdjacentFacesArray_14(faceId);
		}

		// Token: 0x0601BA6A RID: 113258
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHexahedron_GetNumberOfEdges_15(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601BA6B RID: 113259 RVA: 0x0026B4D4 File Offset: 0x002696D4
		public override int GetNumberOfEdges()
		{
			return vtkHexahedron.vtkHexahedron_GetNumberOfEdges_15(base.GetCppThis());
		}

		// Token: 0x0601BA6C RID: 113260
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHexahedron_GetNumberOfFaces_16(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601BA6D RID: 113261 RVA: 0x0026B4F4 File Offset: 0x002696F4
		public override int GetNumberOfFaces()
		{
			return vtkHexahedron.vtkHexahedron_GetNumberOfFaces_16(base.GetCppThis());
		}

		// Token: 0x0601BA6E RID: 113262
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHexahedron_GetNumberOfGenerationsFromBase_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BA6F RID: 113263 RVA: 0x0026B514 File Offset: 0x00269714
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkHexahedron.vtkHexahedron_GetNumberOfGenerationsFromBase_17(base.GetCppThis(), type);
		}

		// Token: 0x0601BA70 RID: 113264
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHexahedron_GetNumberOfGenerationsFromBaseType_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BA71 RID: 113265 RVA: 0x0026B534 File Offset: 0x00269734
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkHexahedron.vtkHexahedron_GetNumberOfGenerationsFromBaseType_18(type);
		}

		// Token: 0x0601BA72 RID: 113266
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHexahedron_GetParametricCoords_19(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601BA73 RID: 113267 RVA: 0x0026B550 File Offset: 0x00269750
		public override IntPtr GetParametricCoords()
		{
			return vtkHexahedron.vtkHexahedron_GetParametricCoords_19(base.GetCppThis());
		}

		// Token: 0x0601BA74 RID: 113268
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHexahedron_GetPointToIncidentEdgesArray_20(long pointId);

		/// <summary>
		/// Static method version of GetPointToIncidentEdgesArray.
		/// </summary>
		// Token: 0x0601BA75 RID: 113269 RVA: 0x0026B570 File Offset: 0x00269770
		public static IntPtr GetPointToIncidentEdgesArray(long pointId)
		{
			return vtkHexahedron.vtkHexahedron_GetPointToIncidentEdgesArray_20(pointId);
		}

		// Token: 0x0601BA76 RID: 113270
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHexahedron_GetPointToIncidentFacesArray_21(long pointId);

		/// <summary>
		/// Static method version of GetPointToIncidentFacesArray.
		/// </summary>
		// Token: 0x0601BA77 RID: 113271 RVA: 0x0026B58C File Offset: 0x0026978C
		public static IntPtr GetPointToIncidentFacesArray(long pointId)
		{
			return vtkHexahedron.vtkHexahedron_GetPointToIncidentFacesArray_21(pointId);
		}

		// Token: 0x0601BA78 RID: 113272
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHexahedron_GetPointToOneRingPointsArray_22(long pointId);

		/// <summary>
		/// Static method version of GetPointToOneRingPoints.
		/// </summary>
		// Token: 0x0601BA79 RID: 113273 RVA: 0x0026B5A8 File Offset: 0x002697A8
		public static IntPtr GetPointToOneRingPointsArray(long pointId)
		{
			return vtkHexahedron.vtkHexahedron_GetPointToOneRingPointsArray_22(pointId);
		}

		// Token: 0x0601BA7A RID: 113274
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHexahedron_GetTriangleCases_23(int caseId);

		/// <summary>
		/// Return the case table for table-based isocontouring (aka marching cubes
		/// style implementations). A linear 3D cell with N vertices will have 2**N
		/// cases. The returned case array lists three edges in order to produce one
		/// output triangle which may be repeated to generate multiple triangles. The
		/// list of cases terminates with a -1 entry.
		/// </summary>
		// Token: 0x0601BA7B RID: 113275 RVA: 0x0026B5C4 File Offset: 0x002697C4
		public static IntPtr GetTriangleCases(int caseId)
		{
			return vtkHexahedron.vtkHexahedron_GetTriangleCases_23(caseId);
		}

		// Token: 0x0601BA7C RID: 113276
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHexahedron_InterpolateDerivs_24(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601BA7D RID: 113277 RVA: 0x0026B5DE File Offset: 0x002697DE
		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkHexahedron.vtkHexahedron_InterpolateDerivs_24(base.GetCppThis(), pcoords, derivs);
		}

		// Token: 0x0601BA7E RID: 113278
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHexahedron_InterpolateFunctions_25(HandleRef pThis, IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601BA7F RID: 113279 RVA: 0x0026B5EF File Offset: 0x002697EF
		public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkHexahedron.vtkHexahedron_InterpolateFunctions_25(base.GetCppThis(), pcoords, weights);
		}

		// Token: 0x0601BA80 RID: 113280
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHexahedron_InterpolationDerivs_26(IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Return the case table for table-based isocontouring (aka marching cubes
		/// style implementations). A linear 3D cell with N vertices will have 2**N
		/// cases. The returned case array lists three edges in order to produce one
		/// output triangle which may be repeated to generate multiple triangles. The
		/// list of cases terminates with a -1 entry.
		/// </summary>
		// Token: 0x0601BA81 RID: 113281 RVA: 0x0026B600 File Offset: 0x00269800
		public static void InterpolationDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkHexahedron.vtkHexahedron_InterpolationDerivs_26(pcoords, derivs);
		}

		// Token: 0x0601BA82 RID: 113282
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHexahedron_InterpolationFunctions_27(IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Return the case table for table-based isocontouring (aka marching cubes
		/// style implementations). A linear 3D cell with N vertices will have 2**N
		/// cases. The returned case array lists three edges in order to produce one
		/// output triangle which may be repeated to generate multiple triangles. The
		/// list of cases terminates with a -1 entry.
		/// </summary>
		// Token: 0x0601BA83 RID: 113283 RVA: 0x0026B60B File Offset: 0x0026980B
		public static void InterpolationFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkHexahedron.vtkHexahedron_InterpolationFunctions_27(pcoords, weights);
		}

		// Token: 0x0601BA84 RID: 113284
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHexahedron_IntersectWithLine_28(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601BA85 RID: 113285 RVA: 0x0026B618 File Offset: 0x00269818
		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkHexahedron.vtkHexahedron_IntersectWithLine_28(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		// Token: 0x0601BA86 RID: 113286
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHexahedron_IsA_29(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BA87 RID: 113287 RVA: 0x0026B644 File Offset: 0x00269844
		public override int IsA(string type)
		{
			return vtkHexahedron.vtkHexahedron_IsA_29(base.GetCppThis(), type);
		}

		// Token: 0x0601BA88 RID: 113288
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHexahedron_IsTypeOf_30([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BA89 RID: 113289 RVA: 0x0026B664 File Offset: 0x00269864
		public new static int IsTypeOf(string type)
		{
			return vtkHexahedron.vtkHexahedron_IsTypeOf_30(type);
		}

		// Token: 0x0601BA8A RID: 113290
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHexahedron_NewInstance_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BA8B RID: 113291 RVA: 0x0026B680 File Offset: 0x00269880
		public new vtkHexahedron NewInstance()
		{
			vtkHexahedron result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHexahedron.vtkHexahedron_NewInstance_32(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHexahedron)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601BA8C RID: 113292
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHexahedron_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BA8D RID: 113293 RVA: 0x0026B6DC File Offset: 0x002698DC
		public new static vtkHexahedron SafeDownCast(vtkObjectBase o)
		{
			vtkHexahedron vtkHexahedron = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHexahedron.vtkHexahedron_SafeDownCast_33((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHexahedron = (vtkHexahedron)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHexahedron.Register(null);
				}
			}
			return vtkHexahedron;
		}

		// Token: 0x0601BA8E RID: 113294
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHexahedron_TriangulateLocalIds_34(HandleRef pThis, int index, HandleRef ptIds);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601BA8F RID: 113295 RVA: 0x0026B75C File Offset: 0x0026995C
		public override int TriangulateLocalIds(int index, vtkIdList ptIds)
		{
			return vtkHexahedron.vtkHexahedron_TriangulateLocalIds_34(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DA2 RID: 7586
		public new const string MRFullTypeName = "Kitware.VTK.vtkHexahedron";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DA3 RID: 7587
		public new static readonly string MRClassNameKey = "class vtkHexahedron";
	}
}
