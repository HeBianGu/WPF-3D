using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTriQuadraticPyramid
	/// </summary>
	/// <remarks>
	///    cell represents a parabolic, 19-node isoparametric pyramid
	///
	/// vtkTriQuadraticPyramid is a concrete implementation of vtkNonLinearCell to
	/// represent a second order three-dimensional isoparametric 19-node pyramid.
	/// The interpolation is the standard finite element, tri-quadratic
	/// isoparametric shape function. The cell includes 5 corner nodes, 8 mid-edge nodes,
	/// 5 mid-face nodes, and 1 volumetric centroid node. The ordering of the nineteen points
	/// defining the cell is point ids (0-4, 5-12, 13-17, 18), where point ids 0-4 are the five
	/// corner vertices of the pyramid; followed by 8 mid-edge nodes (5-12); followed by
	/// 5 mid-face nodes (13-17), and the last node (19) is the volumetric centroid node.
	/// Note that these mid-edge nodes lie on the edges defined by (0, 1), (1, 2), (2, 3),
	/// (3, 0), (0, 4), (1, 4), (2, 4), (3, 4), respectively. The mid-face nodes lie on the
	/// faces defined by (first corner nodes id's, then mid-edge node id's):
	/// quadrilateral face: (0, 3, 2, 1, 8, 7, 6, 5), triangle face 1: (0, 1, 4, 5, 10, 9),
	/// triangle face 2: (1, 2, 4, 6, 11, 10), triangle face 3: (2, 3, 4, 7, 12, 11),
	/// triangle face 5: (3, 0, 4, 8, 9, 12). The last point lies in the center of the cell
	/// (0, 1, 2, 3, 4). The parametric location of vertex #4 is [0.5, 0.5, 1].
	///
	/// @note It should be noted that the parametric coordinates that describe this cell
	/// are not distorted like in vtkPyramid and vtkQuadraticPyramid, which are a collapsed
	/// hexahedron. They are the actual uniform isoparametric coordinates, which are described
	/// in Browning's dissertation (see thanks section), but they are converted to [0, 1] space,
	/// and the nodes are rotated so that node-0 has x = 0, y = 0, while maintaining the CCW order.
	///
	/// \verbatim
	/// Description of 19-node pyramid from bottom to top (based on the z-axis).
	///
	/// base quadrilateral including mid-edge nodes and mid-face node:
	///  3-- 7--2
	///  |      |
	///  8  13  6
	///  |      |
	///  0-- 5--1
	///
	/// volumetric centroid node:
	///
	///
	///     18
	///
	///
	/// mid-face nodes of triangular faces:
	///
	///     16
	///    /  \
	///  17    15
	///    \  /
	///     14
	///
	/// mid-edge nodes of triangular faces:
	///
	///   12--11
	///    |  |
	///    9--10
	///
	/// top corner(apex):
	///
	///
	///     4
	///
	///
	/// \endverbatim
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkQuadraticEdge vtkBiQuadraticTriangle vtkQuadraticTetra
	/// vtkQuadraticHexahedron vtkBiQuadraticQuad vtkQuadraticWedge
	///
	/// @par Thanks:
	/// The shape functions and derivatives could be implemented thanks to
	/// the doctoral dissertation: R.S. Browning. A Second-Order 19-Node Pyramid
	/// Finite Element Suitable for Lumped Mass Explicit Dynamic methods in
	/// Nonlinear Solid Mechanics, University of Alabama at Birmingham.
	/// </seealso>
	// Token: 0x02000ADA RID: 2778
	public class vtkTriQuadraticPyramid : vtkNonLinearCell
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D400 RID: 119808 RVA: 0x00294229 File Offset: 0x00292429
		static vtkTriQuadraticPyramid()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTriQuadraticPyramid.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTriQuadraticPyramid"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D401 RID: 119809 RVA: 0x00294251 File Offset: 0x00292451
		public vtkTriQuadraticPyramid(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601D402 RID: 119810
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTriQuadraticPyramid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D403 RID: 119811 RVA: 0x00294260 File Offset: 0x00292460
		public new static vtkTriQuadraticPyramid New()
		{
			vtkTriQuadraticPyramid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTriQuadraticPyramid.vtkTriQuadraticPyramid_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTriQuadraticPyramid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D404 RID: 119812 RVA: 0x002942B4 File Offset: 0x002924B4
		public vtkTriQuadraticPyramid() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTriQuadraticPyramid.vtkTriQuadraticPyramid_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D405 RID: 119813 RVA: 0x002942F8 File Offset: 0x002924F8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D406 RID: 119814
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriQuadraticPyramid_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601D407 RID: 119815 RVA: 0x00294304 File Offset: 0x00292504
		public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
		{
			return vtkTriQuadraticPyramid.vtkTriQuadraticPyramid_CellBoundary_01(base.GetCppThis(), subId, pcoords, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601D408 RID: 119816
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTriQuadraticPyramid_Clip_02(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef tets, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

		/// <summary>
		/// Clip this quadratic triangle using scalar value provided. Like
		/// contouring, except that it cuts the triangle to produce linear
		/// triangles.
		/// </summary>
		// Token: 0x0601D409 RID: 119817 RVA: 0x0029433C File Offset: 0x0029253C
		public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray tets, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
		{
			vtkTriQuadraticPyramid.vtkTriQuadraticPyramid_Clip_02(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (tets == null) ? default(HandleRef) : tets.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis(), insideOut);
		}

		// Token: 0x0601D40A RID: 119818
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTriQuadraticPyramid_Contour_03(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601D40B RID: 119819 RVA: 0x002943F8 File Offset: 0x002925F8
		public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
		{
			vtkTriQuadraticPyramid.vtkTriQuadraticPyramid_Contour_03(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis());
		}

		// Token: 0x0601D40C RID: 119820
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTriQuadraticPyramid_Derivatives_04(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

		/// <summary>
		/// Line-edge intersection. Intersection has to occur within [0,1] parametric
		/// coordinates and with specified tolerance.
		/// </summary>
		// Token: 0x0601D40D RID: 119821 RVA: 0x002944E0 File Offset: 0x002926E0
		public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
		{
			vtkTriQuadraticPyramid.vtkTriQuadraticPyramid_Derivatives_04(base.GetCppThis(), subId, pcoords, values, dim, derivs);
		}

		// Token: 0x0601D40E RID: 119822
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTriQuadraticPyramid_EvaluateLocation_05(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601D40F RID: 119823 RVA: 0x002944F6 File Offset: 0x002926F6
		public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
		{
			vtkTriQuadraticPyramid.vtkTriQuadraticPyramid_EvaluateLocation_05(base.GetCppThis(), ref subId, pcoords, x, weights);
		}

		// Token: 0x0601D410 RID: 119824
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriQuadraticPyramid_EvaluatePosition_06(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601D411 RID: 119825 RVA: 0x0029450C File Offset: 0x0029270C
		public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
		{
			return vtkTriQuadraticPyramid.vtkTriQuadraticPyramid_EvaluatePosition_06(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
		}

		// Token: 0x0601D412 RID: 119826
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriQuadraticPyramid_GetCellDimension_07(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601D413 RID: 119827 RVA: 0x00294534 File Offset: 0x00292734
		public override int GetCellDimension()
		{
			return vtkTriQuadraticPyramid.vtkTriQuadraticPyramid_GetCellDimension_07(base.GetCppThis());
		}

		// Token: 0x0601D414 RID: 119828
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriQuadraticPyramid_GetCellType_08(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601D415 RID: 119829 RVA: 0x00294554 File Offset: 0x00292754
		public override int GetCellType()
		{
			return vtkTriQuadraticPyramid.vtkTriQuadraticPyramid_GetCellType_08(base.GetCppThis());
		}

		// Token: 0x0601D416 RID: 119830
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTriQuadraticPyramid_GetEdge_09(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601D417 RID: 119831 RVA: 0x00294574 File Offset: 0x00292774
		public override vtkCell GetEdge(int edgeId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTriQuadraticPyramid.vtkTriQuadraticPyramid_GetEdge_09(base.GetCppThis(), edgeId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601D418 RID: 119832
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTriQuadraticPyramid_GetEdgeArray_10(long edgeId);

		/// <summary>
		/// Return the ids of the vertices defining edge/face (`edgeId`/`faceId').
		/// Ids are related to the cell, not to the dataset.
		///
		/// @note The return type changed. It used to be int*, it is now const vtkIdType*.
		/// This is so ids are unified between vtkCell and vtkPoints.
		/// </summary>
		// Token: 0x0601D419 RID: 119833 RVA: 0x002945E4 File Offset: 0x002927E4
		public static IntPtr GetEdgeArray(long edgeId)
		{
			return vtkTriQuadraticPyramid.vtkTriQuadraticPyramid_GetEdgeArray_10(edgeId);
		}

		// Token: 0x0601D41A RID: 119834
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTriQuadraticPyramid_GetFace_11(HandleRef pThis, int faceId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601D41B RID: 119835 RVA: 0x00294600 File Offset: 0x00292800
		public override vtkCell GetFace(int faceId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTriQuadraticPyramid.vtkTriQuadraticPyramid_GetFace_11(base.GetCppThis(), faceId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601D41C RID: 119836
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTriQuadraticPyramid_GetFaceArray_12(long faceId);

		/// <summary>
		/// Return the ids of the vertices defining edge/face (`edgeId`/`faceId').
		/// Ids are related to the cell, not to the dataset.
		///
		/// @note The return type changed. It used to be int*, it is now const vtkIdType*.
		/// This is so ids are unified between vtkCell and vtkPoints.
		/// </summary>
		// Token: 0x0601D41D RID: 119837 RVA: 0x00294670 File Offset: 0x00292870
		public static IntPtr GetFaceArray(long faceId)
		{
			return vtkTriQuadraticPyramid.vtkTriQuadraticPyramid_GetFaceArray_12(faceId);
		}

		// Token: 0x0601D41E RID: 119838
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriQuadraticPyramid_GetNumberOfEdges_13(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601D41F RID: 119839 RVA: 0x0029468C File Offset: 0x0029288C
		public override int GetNumberOfEdges()
		{
			return vtkTriQuadraticPyramid.vtkTriQuadraticPyramid_GetNumberOfEdges_13(base.GetCppThis());
		}

		// Token: 0x0601D420 RID: 119840
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriQuadraticPyramid_GetNumberOfFaces_14(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601D421 RID: 119841 RVA: 0x002946AC File Offset: 0x002928AC
		public override int GetNumberOfFaces()
		{
			return vtkTriQuadraticPyramid.vtkTriQuadraticPyramid_GetNumberOfFaces_14(base.GetCppThis());
		}

		// Token: 0x0601D422 RID: 119842
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTriQuadraticPyramid_GetNumberOfGenerationsFromBase_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D423 RID: 119843 RVA: 0x002946CC File Offset: 0x002928CC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTriQuadraticPyramid.vtkTriQuadraticPyramid_GetNumberOfGenerationsFromBase_15(base.GetCppThis(), type);
		}

		// Token: 0x0601D424 RID: 119844
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTriQuadraticPyramid_GetNumberOfGenerationsFromBaseType_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D425 RID: 119845 RVA: 0x002946EC File Offset: 0x002928EC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTriQuadraticPyramid.vtkTriQuadraticPyramid_GetNumberOfGenerationsFromBaseType_16(type);
		}

		// Token: 0x0601D426 RID: 119846
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriQuadraticPyramid_GetParametricCenter_17(HandleRef pThis, IntPtr pcoords);

		/// <summary>
		/// Return the center of the tri-quadratic pyramid in parametric coordinates.
		/// </summary>
		// Token: 0x0601D427 RID: 119847 RVA: 0x00294708 File Offset: 0x00292908
		public override int GetParametricCenter(IntPtr pcoords)
		{
			return vtkTriQuadraticPyramid.vtkTriQuadraticPyramid_GetParametricCenter_17(base.GetCppThis(), pcoords);
		}

		// Token: 0x0601D428 RID: 119848
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTriQuadraticPyramid_GetParametricCoords_18(HandleRef pThis);

		/// <summary>
		/// Line-edge intersection. Intersection has to occur within [0,1] parametric
		/// coordinates and with specified tolerance.
		/// </summary>
		// Token: 0x0601D429 RID: 119849 RVA: 0x00294728 File Offset: 0x00292928
		public override IntPtr GetParametricCoords()
		{
			return vtkTriQuadraticPyramid.vtkTriQuadraticPyramid_GetParametricCoords_18(base.GetCppThis());
		}

		// Token: 0x0601D42A RID: 119850
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTriQuadraticPyramid_GetParametricDistance_19(HandleRef pThis, IntPtr pcoords);

		/// <summary>
		/// Return the distance of the parametric coordinate provided to the
		/// cell. If inside the cell, a distance of zero is returned.
		/// </summary>
		// Token: 0x0601D42B RID: 119851 RVA: 0x00294748 File Offset: 0x00292948
		public override double GetParametricDistance(IntPtr pcoords)
		{
			return vtkTriQuadraticPyramid.vtkTriQuadraticPyramid_GetParametricDistance_19(base.GetCppThis(), pcoords);
		}

		// Token: 0x0601D42C RID: 119852
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTriQuadraticPyramid_InterpolateDerivs_20(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601D42D RID: 119853 RVA: 0x00294768 File Offset: 0x00292968
		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkTriQuadraticPyramid.vtkTriQuadraticPyramid_InterpolateDerivs_20(base.GetCppThis(), pcoords, derivs);
		}

		// Token: 0x0601D42E RID: 119854
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTriQuadraticPyramid_InterpolateFunctions_21(HandleRef pThis, IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601D42F RID: 119855 RVA: 0x00294779 File Offset: 0x00292979
		public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkTriQuadraticPyramid.vtkTriQuadraticPyramid_InterpolateFunctions_21(base.GetCppThis(), pcoords, weights);
		}

		// Token: 0x0601D430 RID: 119856
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTriQuadraticPyramid_InterpolationDerivs_22(IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Return the distance of the parametric coordinate provided to the
		/// cell. If inside the cell, a distance of zero is returned.
		/// </summary>
		// Token: 0x0601D431 RID: 119857 RVA: 0x0029478A File Offset: 0x0029298A
		public static void InterpolationDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkTriQuadraticPyramid.vtkTriQuadraticPyramid_InterpolationDerivs_22(pcoords, derivs);
		}

		// Token: 0x0601D432 RID: 119858
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTriQuadraticPyramid_InterpolationFunctions_23(IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Return the distance of the parametric coordinate provided to the
		/// cell. If inside the cell, a distance of zero is returned.
		/// </summary>
		// Token: 0x0601D433 RID: 119859 RVA: 0x00294795 File Offset: 0x00292995
		public static void InterpolationFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkTriQuadraticPyramid.vtkTriQuadraticPyramid_InterpolationFunctions_23(pcoords, weights);
		}

		// Token: 0x0601D434 RID: 119860
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriQuadraticPyramid_IntersectWithLine_24(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		/// <summary>
		/// Line-edge intersection. Intersection has to occur within [0,1] parametric
		/// coordinates and with specified tolerance.
		/// </summary>
		// Token: 0x0601D435 RID: 119861 RVA: 0x002947A0 File Offset: 0x002929A0
		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkTriQuadraticPyramid.vtkTriQuadraticPyramid_IntersectWithLine_24(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		// Token: 0x0601D436 RID: 119862
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriQuadraticPyramid_IsA_25(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D437 RID: 119863 RVA: 0x002947CC File Offset: 0x002929CC
		public override int IsA(string type)
		{
			return vtkTriQuadraticPyramid.vtkTriQuadraticPyramid_IsA_25(base.GetCppThis(), type);
		}

		// Token: 0x0601D438 RID: 119864
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriQuadraticPyramid_IsTypeOf_26([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D439 RID: 119865 RVA: 0x002947EC File Offset: 0x002929EC
		public new static int IsTypeOf(string type)
		{
			return vtkTriQuadraticPyramid.vtkTriQuadraticPyramid_IsTypeOf_26(type);
		}

		// Token: 0x0601D43A RID: 119866
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTriQuadraticPyramid_NewInstance_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D43B RID: 119867 RVA: 0x00294808 File Offset: 0x00292A08
		public new vtkTriQuadraticPyramid NewInstance()
		{
			vtkTriQuadraticPyramid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTriQuadraticPyramid.vtkTriQuadraticPyramid_NewInstance_28(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTriQuadraticPyramid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601D43C RID: 119868
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTriQuadraticPyramid_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D43D RID: 119869 RVA: 0x00294864 File Offset: 0x00292A64
		public new static vtkTriQuadraticPyramid SafeDownCast(vtkObjectBase o)
		{
			vtkTriQuadraticPyramid vtkTriQuadraticPyramid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTriQuadraticPyramid.vtkTriQuadraticPyramid_SafeDownCast_29((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTriQuadraticPyramid = (vtkTriQuadraticPyramid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTriQuadraticPyramid.Register(null);
				}
			}
			return vtkTriQuadraticPyramid;
		}

		// Token: 0x0601D43E RID: 119870
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriQuadraticPyramid_TriangulateLocalIds_30(HandleRef pThis, int index, HandleRef ptIds);

		/// <summary>
		/// Line-edge intersection. Intersection has to occur within [0,1] parametric
		/// coordinates and with specified tolerance.
		/// </summary>
		// Token: 0x0601D43F RID: 119871 RVA: 0x002948E4 File Offset: 0x00292AE4
		public override int TriangulateLocalIds(int index, vtkIdList ptIds)
		{
			return vtkTriQuadraticPyramid.vtkTriQuadraticPyramid_TriangulateLocalIds_30(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EDB RID: 7899
		public new const string MRFullTypeName = "Kitware.VTK.vtkTriQuadraticPyramid";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EDC RID: 7900
		public new static readonly string MRClassNameKey = "class vtkTriQuadraticPyramid";
	}
}
