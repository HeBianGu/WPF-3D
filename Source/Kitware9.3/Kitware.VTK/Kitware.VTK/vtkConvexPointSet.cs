using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkConvexPointSet
	/// </summary>
	/// <remarks>
	///    a 3D cell defined by a set of convex points
	///
	/// vtkConvexPointSet is a concrete implementation that represents a 3D cell
	/// defined by a convex set of points. An example of such a cell is an octant
	/// (from an octree). vtkConvexPointSet uses the ordered triangulations
	/// approach (vtkOrderedTriangulator) to create triangulations guaranteed to
	/// be compatible across shared faces. This allows a general approach to
	/// processing complex, convex cell types.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkHexahedron vtkPyramid vtkTetra vtkVoxel vtkWedge
	/// </seealso>
	// Token: 0x02000A32 RID: 2610
	public class vtkConvexPointSet : vtkCell3D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601B2EA RID: 111338 RVA: 0x0025F84F File Offset: 0x0025DA4F
		static vtkConvexPointSet()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkConvexPointSet.MRClassNameKey, Type.GetType("Kitware.VTK.vtkConvexPointSet"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601B2EB RID: 111339 RVA: 0x0025F877 File Offset: 0x0025DA77
		public vtkConvexPointSet(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601B2EC RID: 111340
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConvexPointSet_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B2ED RID: 111341 RVA: 0x0025F888 File Offset: 0x0025DA88
		public new static vtkConvexPointSet New()
		{
			vtkConvexPointSet result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConvexPointSet.vtkConvexPointSet_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkConvexPointSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B2EE RID: 111342 RVA: 0x0025F8DC File Offset: 0x0025DADC
		public vtkConvexPointSet() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkConvexPointSet.vtkConvexPointSet_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601B2EF RID: 111343 RVA: 0x0025F920 File Offset: 0x0025DB20
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601B2F0 RID: 111344
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConvexPointSet_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

		/// <summary>
		/// Returns the set of points forming a face of the triangulation of these
		/// points that are on the boundary of the cell that are closest
		/// parametrically to the point specified.
		/// </summary>
		// Token: 0x0601B2F1 RID: 111345 RVA: 0x0025F92C File Offset: 0x0025DB2C
		public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
		{
			return vtkConvexPointSet.vtkConvexPointSet_CellBoundary_01(base.GetCppThis(), subId, pcoords, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601B2F2 RID: 111346
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConvexPointSet_Clip_02(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef connectivity, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

		/// <summary>
		/// Satisfy the vtkCell API. This method contours by triangulating the
		/// cell and then adding clip-edge intersection points into the
		/// triangulation; extracting the clipped region.
		/// </summary>
		// Token: 0x0601B2F3 RID: 111347 RVA: 0x0025F964 File Offset: 0x0025DB64
		public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray connectivity, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
		{
			vtkConvexPointSet.vtkConvexPointSet_Clip_02(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (connectivity == null) ? default(HandleRef) : connectivity.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis(), insideOut);
		}

		// Token: 0x0601B2F4 RID: 111348
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConvexPointSet_Contour_03(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

		/// <summary>
		/// Satisfy the vtkCell API. This method contours by triangulating the
		/// cell and then contouring the resulting tetrahedra.
		/// </summary>
		// Token: 0x0601B2F5 RID: 111349 RVA: 0x0025FA20 File Offset: 0x0025DC20
		public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
		{
			vtkConvexPointSet.vtkConvexPointSet_Contour_03(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis());
		}

		// Token: 0x0601B2F6 RID: 111350
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConvexPointSet_Derivatives_04(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

		/// <summary>
		/// Computes derivatives by triangulating and from subId and pcoords,
		/// evaluating derivatives on the resulting tetrahedron.
		/// </summary>
		// Token: 0x0601B2F7 RID: 111351 RVA: 0x0025FB08 File Offset: 0x0025DD08
		public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
		{
			vtkConvexPointSet.vtkConvexPointSet_Derivatives_04(base.GetCppThis(), subId, pcoords, values, dim, derivs);
		}

		// Token: 0x0601B2F8 RID: 111352
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConvexPointSet_EvaluateLocation_05(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

		/// <summary>
		/// The inverse of EvaluatePosition.
		/// </summary>
		// Token: 0x0601B2F9 RID: 111353 RVA: 0x0025FB1E File Offset: 0x0025DD1E
		public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
		{
			vtkConvexPointSet.vtkConvexPointSet_EvaluateLocation_05(base.GetCppThis(), ref subId, pcoords, x, weights);
		}

		// Token: 0x0601B2FA RID: 111354
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConvexPointSet_EvaluatePosition_06(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

		/// <summary>
		/// Satisfy the vtkCell API. This method determines the subId, pcoords,
		/// and weights by triangulating the convex point set, and then
		/// determining which tetrahedron the point lies in.
		/// </summary>
		// Token: 0x0601B2FB RID: 111355 RVA: 0x0025FB34 File Offset: 0x0025DD34
		public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
		{
			return vtkConvexPointSet.vtkConvexPointSet_EvaluatePosition_06(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
		}

		// Token: 0x0601B2FC RID: 111356
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConvexPointSet_GetCellType_07(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B2FD RID: 111357 RVA: 0x0025FB5C File Offset: 0x0025DD5C
		public override int GetCellType()
		{
			return vtkConvexPointSet.vtkConvexPointSet_GetCellType_07(base.GetCppThis());
		}

		// Token: 0x0601B2FE RID: 111358
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkConvexPointSet_GetCentroid_08(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// See vtkCell3D API for description of these methods.
		/// @warning These method are unimplemented in vtkConvexPointSet
		/// </summary>
		// Token: 0x0601B2FF RID: 111359 RVA: 0x0025FB7C File Offset: 0x0025DD7C
		public override bool GetCentroid(IntPtr arg0)
		{
			return vtkConvexPointSet.vtkConvexPointSet_GetCentroid_08(base.GetCppThis(), arg0) != 0;
		}

		// Token: 0x0601B300 RID: 111360
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConvexPointSet_GetEdge_09(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// A convex point set has no explicit cell edge or faces; however
		/// implicitly (after triangulation) it does. Currently the method
		/// GetNumberOfEdges() always returns 0 while the GetNumberOfFaces() returns
		/// the number of boundary triangles of the triangulation of the convex
		/// point set. The method GetNumberOfFaces() triggers a triangulation of the
		/// convex point set; repeated calls to GetFace() then return the boundary
		/// faces. (Note: GetNumberOfEdges() currently returns 0 because it is a
		/// rarely used method and hard to implement. It can be changed in the future.
		/// </summary>
		// Token: 0x0601B301 RID: 111361 RVA: 0x0025FBA4 File Offset: 0x0025DDA4
		public override vtkCell GetEdge(int arg0)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConvexPointSet.vtkConvexPointSet_GetEdge_09(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601B302 RID: 111362
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConvexPointSet_GetFace_10(HandleRef pThis, int faceId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// A convex point set has no explicit cell edge or faces; however
		/// implicitly (after triangulation) it does. Currently the method
		/// GetNumberOfEdges() always returns 0 while the GetNumberOfFaces() returns
		/// the number of boundary triangles of the triangulation of the convex
		/// point set. The method GetNumberOfFaces() triggers a triangulation of the
		/// convex point set; repeated calls to GetFace() then return the boundary
		/// faces. (Note: GetNumberOfEdges() currently returns 0 because it is a
		/// rarely used method and hard to implement. It can be changed in the future.
		/// </summary>
		// Token: 0x0601B303 RID: 111363 RVA: 0x0025FC14 File Offset: 0x0025DE14
		public override vtkCell GetFace(int faceId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConvexPointSet.vtkConvexPointSet_GetFace_10(base.GetCppThis(), faceId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601B304 RID: 111364
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConvexPointSet_GetNumberOfEdges_11(HandleRef pThis);

		/// <summary>
		/// A convex point set has no explicit cell edge or faces; however
		/// implicitly (after triangulation) it does. Currently the method
		/// GetNumberOfEdges() always returns 0 while the GetNumberOfFaces() returns
		/// the number of boundary triangles of the triangulation of the convex
		/// point set. The method GetNumberOfFaces() triggers a triangulation of the
		/// convex point set; repeated calls to GetFace() then return the boundary
		/// faces. (Note: GetNumberOfEdges() currently returns 0 because it is a
		/// rarely used method and hard to implement. It can be changed in the future.
		/// </summary>
		// Token: 0x0601B305 RID: 111365 RVA: 0x0025FC84 File Offset: 0x0025DE84
		public override int GetNumberOfEdges()
		{
			return vtkConvexPointSet.vtkConvexPointSet_GetNumberOfEdges_11(base.GetCppThis());
		}

		// Token: 0x0601B306 RID: 111366
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConvexPointSet_GetNumberOfFaces_12(HandleRef pThis);

		/// <summary>
		/// A convex point set has no explicit cell edge or faces; however
		/// implicitly (after triangulation) it does. Currently the method
		/// GetNumberOfEdges() always returns 0 while the GetNumberOfFaces() returns
		/// the number of boundary triangles of the triangulation of the convex
		/// point set. The method GetNumberOfFaces() triggers a triangulation of the
		/// convex point set; repeated calls to GetFace() then return the boundary
		/// faces. (Note: GetNumberOfEdges() currently returns 0 because it is a
		/// rarely used method and hard to implement. It can be changed in the future.
		/// </summary>
		// Token: 0x0601B307 RID: 111367 RVA: 0x0025FCA4 File Offset: 0x0025DEA4
		public override int GetNumberOfFaces()
		{
			return vtkConvexPointSet.vtkConvexPointSet_GetNumberOfFaces_12(base.GetCppThis());
		}

		// Token: 0x0601B308 RID: 111368
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkConvexPointSet_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B309 RID: 111369 RVA: 0x0025FCC4 File Offset: 0x0025DEC4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkConvexPointSet.vtkConvexPointSet_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x0601B30A RID: 111370
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkConvexPointSet_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B30B RID: 111371 RVA: 0x0025FCE4 File Offset: 0x0025DEE4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkConvexPointSet.vtkConvexPointSet_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x0601B30C RID: 111372
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConvexPointSet_GetParametricCenter_15(HandleRef pThis, IntPtr pcoords);

		/// <summary>
		/// Return the center of the cell in parametric coordinates.
		/// </summary>
		// Token: 0x0601B30D RID: 111373 RVA: 0x0025FD00 File Offset: 0x0025DF00
		public override int GetParametricCenter(IntPtr pcoords)
		{
			return vtkConvexPointSet.vtkConvexPointSet_GetParametricCenter_15(base.GetCppThis(), pcoords);
		}

		// Token: 0x0601B30E RID: 111374
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConvexPointSet_GetParametricCoords_16(HandleRef pThis);

		/// <summary>
		/// See vtkCell3D API for description of this method.
		/// </summary>
		// Token: 0x0601B30F RID: 111375 RVA: 0x0025FD20 File Offset: 0x0025DF20
		public override IntPtr GetParametricCoords()
		{
			return vtkConvexPointSet.vtkConvexPointSet_GetParametricCoords_16(base.GetCppThis());
		}

		// Token: 0x0601B310 RID: 111376
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConvexPointSet_HasFixedTopology_17(HandleRef pThis);

		/// <summary>
		/// See vtkCell3D API for description of this method.
		/// </summary>
		// Token: 0x0601B311 RID: 111377 RVA: 0x0025FD40 File Offset: 0x0025DF40
		public virtual int HasFixedTopology()
		{
			return vtkConvexPointSet.vtkConvexPointSet_HasFixedTopology_17(base.GetCppThis());
		}

		// Token: 0x0601B312 RID: 111378
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConvexPointSet_Initialize_18(HandleRef pThis);

		/// <summary>
		/// This cell requires that it be initialized prior to access.
		/// </summary>
		// Token: 0x0601B313 RID: 111379 RVA: 0x0025FD5F File Offset: 0x0025DF5F
		public override void Initialize()
		{
			vtkConvexPointSet.vtkConvexPointSet_Initialize_18(base.GetCppThis());
		}

		// Token: 0x0601B314 RID: 111380
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConvexPointSet_InterpolateDerivs_19(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601B315 RID: 111381 RVA: 0x0025FD6E File Offset: 0x0025DF6E
		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkConvexPointSet.vtkConvexPointSet_InterpolateDerivs_19(base.GetCppThis(), pcoords, derivs);
		}

		// Token: 0x0601B316 RID: 111382
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConvexPointSet_InterpolateFunctions_20(HandleRef pThis, IntPtr pcoords, IntPtr sf);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601B317 RID: 111383 RVA: 0x0025FD7F File Offset: 0x0025DF7F
		public override void InterpolateFunctions(IntPtr pcoords, IntPtr sf)
		{
			vtkConvexPointSet.vtkConvexPointSet_InterpolateFunctions_20(base.GetCppThis(), pcoords, sf);
		}

		// Token: 0x0601B318 RID: 111384
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConvexPointSet_IntersectWithLine_21(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		/// <summary>
		/// Triangulates the cells and then intersects them to determine the
		/// intersection point.
		/// </summary>
		// Token: 0x0601B319 RID: 111385 RVA: 0x0025FD90 File Offset: 0x0025DF90
		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkConvexPointSet.vtkConvexPointSet_IntersectWithLine_21(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		// Token: 0x0601B31A RID: 111386
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConvexPointSet_IsA_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B31B RID: 111387 RVA: 0x0025FDBC File Offset: 0x0025DFBC
		public override int IsA(string type)
		{
			return vtkConvexPointSet.vtkConvexPointSet_IsA_22(base.GetCppThis(), type);
		}

		// Token: 0x0601B31C RID: 111388
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConvexPointSet_IsPrimaryCell_23(HandleRef pThis);

		/// <summary>
		/// A convex point set is triangulated prior to any operations on it so
		/// it is not a primary cell, it is a composite cell.
		/// </summary>
		// Token: 0x0601B31D RID: 111389 RVA: 0x0025FDDC File Offset: 0x0025DFDC
		public override int IsPrimaryCell()
		{
			return vtkConvexPointSet.vtkConvexPointSet_IsPrimaryCell_23(base.GetCppThis());
		}

		// Token: 0x0601B31E RID: 111390
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConvexPointSet_IsTypeOf_24([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B31F RID: 111391 RVA: 0x0025FDFC File Offset: 0x0025DFFC
		public new static int IsTypeOf(string type)
		{
			return vtkConvexPointSet.vtkConvexPointSet_IsTypeOf_24(type);
		}

		// Token: 0x0601B320 RID: 111392
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConvexPointSet_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B321 RID: 111393 RVA: 0x0025FE18 File Offset: 0x0025E018
		public new vtkConvexPointSet NewInstance()
		{
			vtkConvexPointSet result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConvexPointSet.vtkConvexPointSet_NewInstance_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkConvexPointSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601B322 RID: 111394
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConvexPointSet_RequiresInitialization_27(HandleRef pThis);

		/// <summary>
		/// This cell requires that it be initialized prior to access.
		/// </summary>
		// Token: 0x0601B323 RID: 111395 RVA: 0x0025FE74 File Offset: 0x0025E074
		public override int RequiresInitialization()
		{
			return vtkConvexPointSet.vtkConvexPointSet_RequiresInitialization_27(base.GetCppThis());
		}

		// Token: 0x0601B324 RID: 111396
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConvexPointSet_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B325 RID: 111397 RVA: 0x0025FE94 File Offset: 0x0025E094
		public new static vtkConvexPointSet SafeDownCast(vtkObjectBase o)
		{
			vtkConvexPointSet vtkConvexPointSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConvexPointSet.vtkConvexPointSet_SafeDownCast_28((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkConvexPointSet = (vtkConvexPointSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkConvexPointSet.Register(null);
				}
			}
			return vtkConvexPointSet;
		}

		// Token: 0x0601B326 RID: 111398
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConvexPointSet_TriangulateLocalIds_29(HandleRef pThis, int index, HandleRef ptIds);

		/// <summary>
		/// Triangulate using methods of vtkOrderedTriangulator.
		/// </summary>
		// Token: 0x0601B327 RID: 111399 RVA: 0x0025FF14 File Offset: 0x0025E114
		public override int TriangulateLocalIds(int index, vtkIdList ptIds)
		{
			return vtkConvexPointSet.vtkConvexPointSet_TriangulateLocalIds_29(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D57 RID: 7511
		public new const string MRFullTypeName = "Kitware.VTK.vtkConvexPointSet";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D58 RID: 7512
		public new static readonly string MRClassNameKey = "class vtkConvexPointSet";
	}
}
