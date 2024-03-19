using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkHigherOrderWedge
	/// </summary>
	/// <remarks>
	///    A 3D cell that represents an arbitrary order HigherOrder wedge
	///
	/// vtkHigherOrderWedge is a concrete implementation of vtkCell to represent a
	/// 3D wedge using HigherOrder shape functions of user specified order.
	/// A wedge consists of two triangular and three quadrilateral faces.
	/// The first six points of the wedge (0-5) are the "corner" points
	/// where the first three points are the base of the wedge. This wedge
	/// point ordering is opposite the vtkWedge ordering though in that
	/// the base of the wedge defined by the first three points (0,1,2) form
	/// a triangle whose normal points inward (toward the triangular face (3,4,5)).
	/// While this is opposite the vtkWedge convention it is consistent with
	/// every other cell type in VTK. The first 2 parametric coordinates of the
	/// HigherOrder wedge or for the triangular base and vary between 0 and 1. The
	/// third parametric coordinate is between the two triangular faces and goes
	/// from 0 to 1 as well.
	/// </remarks>
	// Token: 0x02000A0B RID: 2571
	public abstract class vtkHigherOrderWedge : vtkNonLinearCell
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601AB8C RID: 109452 RVA: 0x002531E8 File Offset: 0x002513E8
		static vtkHigherOrderWedge()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHigherOrderWedge.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHigherOrderWedge"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601AB8D RID: 109453 RVA: 0x00253210 File Offset: 0x00251410
		public vtkHigherOrderWedge(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601AB8E RID: 109454 RVA: 0x0025321E File Offset: 0x0025141E
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601AB8F RID: 109455
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderWedge_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB90 RID: 109456 RVA: 0x0025322C File Offset: 0x0025142C
		public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
		{
			return vtkHigherOrderWedge.vtkHigherOrderWedge_CellBoundary_01(base.GetCppThis(), subId, pcoords, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601AB91 RID: 109457
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderWedge_Clip_02(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB92 RID: 109458 RVA: 0x00253264 File Offset: 0x00251464
		public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
		{
			vtkHigherOrderWedge.vtkHigherOrderWedge_Clip_02(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis(), insideOut);
		}

		// Token: 0x0601AB93 RID: 109459
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderWedge_Contour_03(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB94 RID: 109460 RVA: 0x00253320 File Offset: 0x00251520
		public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
		{
			vtkHigherOrderWedge.vtkHigherOrderWedge_Contour_03(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis());
		}

		// Token: 0x0601AB95 RID: 109461
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderWedge_Derivatives_04(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB96 RID: 109462 RVA: 0x00253408 File Offset: 0x00251608
		public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
		{
			vtkHigherOrderWedge.vtkHigherOrderWedge_Derivatives_04(base.GetCppThis(), subId, pcoords, values, dim, derivs);
		}

		// Token: 0x0601AB97 RID: 109463
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderWedge_EvaluateLocation_05(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB98 RID: 109464 RVA: 0x0025341E File Offset: 0x0025161E
		public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
		{
			vtkHigherOrderWedge.vtkHigherOrderWedge_EvaluateLocation_05(base.GetCppThis(), ref subId, pcoords, x, weights);
		}

		// Token: 0x0601AB99 RID: 109465
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderWedge_EvaluatePosition_06(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB9A RID: 109466 RVA: 0x00253434 File Offset: 0x00251634
		public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
		{
			return vtkHigherOrderWedge.vtkHigherOrderWedge_EvaluatePosition_06(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
		}

		// Token: 0x0601AB9B RID: 109467
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderWedge_GetBoundaryQuad_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB9C RID: 109468 RVA: 0x0025345C File Offset: 0x0025165C
		public virtual vtkHigherOrderQuadrilateral GetBoundaryQuad()
		{
			vtkHigherOrderQuadrilateral vtkHigherOrderQuadrilateral = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHigherOrderWedge.vtkHigherOrderWedge_GetBoundaryQuad_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHigherOrderQuadrilateral = (vtkHigherOrderQuadrilateral)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHigherOrderQuadrilateral.Register(null);
				}
			}
			return vtkHigherOrderQuadrilateral;
		}

		// Token: 0x0601AB9D RID: 109469
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderWedge_GetBoundaryTri_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB9E RID: 109470 RVA: 0x002534CC File Offset: 0x002516CC
		public virtual vtkHigherOrderTriangle GetBoundaryTri()
		{
			vtkHigherOrderTriangle vtkHigherOrderTriangle = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHigherOrderWedge.vtkHigherOrderWedge_GetBoundaryTri_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHigherOrderTriangle = (vtkHigherOrderTriangle)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHigherOrderTriangle.Register(null);
				}
			}
			return vtkHigherOrderTriangle;
		}

		// Token: 0x0601AB9F RID: 109471
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderWedge_GetCellDimension_09(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ABA0 RID: 109472 RVA: 0x0025353C File Offset: 0x0025173C
		public override int GetCellDimension()
		{
			return vtkHigherOrderWedge.vtkHigherOrderWedge_GetCellDimension_09(base.GetCppThis());
		}

		// Token: 0x0601ABA1 RID: 109473
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderWedge_GetCellType_10(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ABA2 RID: 109474 RVA: 0x0025355C File Offset: 0x0025175C
		public override int GetCellType()
		{
			return vtkHigherOrderWedge.vtkHigherOrderWedge_GetCellType_10(base.GetCppThis());
		}

		// Token: 0x0601ABA3 RID: 109475
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderWedge_GetEdge_11(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ABA4 RID: 109476 RVA: 0x0025357C File Offset: 0x0025177C
		public override vtkCell GetEdge(int edgeId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHigherOrderWedge.vtkHigherOrderWedge_GetEdge_11(base.GetCppThis(), edgeId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601ABA5 RID: 109477
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderWedge_GetEdgeCell_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ABA6 RID: 109478 RVA: 0x002535EC File Offset: 0x002517EC
		public virtual vtkHigherOrderCurve GetEdgeCell()
		{
			vtkHigherOrderCurve vtkHigherOrderCurve = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHigherOrderWedge.vtkHigherOrderWedge_GetEdgeCell_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHigherOrderCurve = (vtkHigherOrderCurve)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHigherOrderCurve.Register(null);
				}
			}
			return vtkHigherOrderCurve;
		}

		// Token: 0x0601ABA7 RID: 109479
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderWedge_GetFace_13(HandleRef pThis, int faceId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ABA8 RID: 109480 RVA: 0x0025365C File Offset: 0x0025185C
		public override vtkCell GetFace(int faceId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHigherOrderWedge.vtkHigherOrderWedge_GetFace_13(base.GetCppThis(), faceId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601ABA9 RID: 109481
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderWedge_GetInterpolation_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ABAA RID: 109482 RVA: 0x002536CC File Offset: 0x002518CC
		public virtual vtkHigherOrderInterpolation GetInterpolation()
		{
			vtkHigherOrderInterpolation vtkHigherOrderInterpolation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHigherOrderWedge.vtkHigherOrderWedge_GetInterpolation_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHigherOrderInterpolation = (vtkHigherOrderInterpolation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHigherOrderInterpolation.Register(null);
				}
			}
			return vtkHigherOrderInterpolation;
		}

		// Token: 0x0601ABAB RID: 109483
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderWedge_GetNumberOfApproximatingWedges_15(IntPtr order);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ABAC RID: 109484 RVA: 0x0025373C File Offset: 0x0025193C
		public static int GetNumberOfApproximatingWedges(IntPtr order)
		{
			return vtkHigherOrderWedge.vtkHigherOrderWedge_GetNumberOfApproximatingWedges_15(order);
		}

		// Token: 0x0601ABAD RID: 109485
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderWedge_GetNumberOfApproximatingWedges_16(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ABAE RID: 109486 RVA: 0x00253758 File Offset: 0x00251958
		public int GetNumberOfApproximatingWedges()
		{
			return vtkHigherOrderWedge.vtkHigherOrderWedge_GetNumberOfApproximatingWedges_16(base.GetCppThis());
		}

		// Token: 0x0601ABAF RID: 109487
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderWedge_GetNumberOfEdges_17(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ABB0 RID: 109488 RVA: 0x00253778 File Offset: 0x00251978
		public override int GetNumberOfEdges()
		{
			return vtkHigherOrderWedge.vtkHigherOrderWedge_GetNumberOfEdges_17(base.GetCppThis());
		}

		// Token: 0x0601ABB1 RID: 109489
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderWedge_GetNumberOfFaces_18(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ABB2 RID: 109490 RVA: 0x00253798 File Offset: 0x00251998
		public override int GetNumberOfFaces()
		{
			return vtkHigherOrderWedge.vtkHigherOrderWedge_GetNumberOfFaces_18(base.GetCppThis());
		}

		// Token: 0x0601ABB3 RID: 109491
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHigherOrderWedge_GetNumberOfGenerationsFromBase_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ABB4 RID: 109492 RVA: 0x002537B8 File Offset: 0x002519B8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkHigherOrderWedge.vtkHigherOrderWedge_GetNumberOfGenerationsFromBase_19(base.GetCppThis(), type);
		}

		// Token: 0x0601ABB5 RID: 109493
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHigherOrderWedge_GetNumberOfGenerationsFromBaseType_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ABB6 RID: 109494 RVA: 0x002537D8 File Offset: 0x002519D8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkHigherOrderWedge.vtkHigherOrderWedge_GetNumberOfGenerationsFromBaseType_20(type);
		}

		// Token: 0x0601ABB7 RID: 109495
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderWedge_GetOrder_21(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ABB8 RID: 109496 RVA: 0x002537F4 File Offset: 0x002519F4
		public virtual IntPtr GetOrder()
		{
			return vtkHigherOrderWedge.vtkHigherOrderWedge_GetOrder_21(base.GetCppThis());
		}

		// Token: 0x0601ABB9 RID: 109497
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderWedge_GetOrder_22(HandleRef pThis, int i);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ABBA RID: 109498 RVA: 0x00253814 File Offset: 0x00251A14
		public virtual int GetOrder(int i)
		{
			return vtkHigherOrderWedge.vtkHigherOrderWedge_GetOrder_22(base.GetCppThis(), i);
		}

		// Token: 0x0601ABBB RID: 109499
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderWedge_GetParametricCenter_23(HandleRef pThis, IntPtr center);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ABBC RID: 109500 RVA: 0x00253834 File Offset: 0x00251A34
		public override int GetParametricCenter(IntPtr center)
		{
			return vtkHigherOrderWedge.vtkHigherOrderWedge_GetParametricCenter_23(base.GetCppThis(), center);
		}

		// Token: 0x0601ABBD RID: 109501
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderWedge_GetParametricCoords_24(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ABBE RID: 109502 RVA: 0x00253854 File Offset: 0x00251A54
		public override IntPtr GetParametricCoords()
		{
			return vtkHigherOrderWedge.vtkHigherOrderWedge_GetParametricCoords_24(base.GetCppThis());
		}

		// Token: 0x0601ABBF RID: 109503
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkHigherOrderWedge_GetParametricDistance_25(HandleRef pThis, IntPtr pcoords);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ABC0 RID: 109504 RVA: 0x00253874 File Offset: 0x00251A74
		public override double GetParametricDistance(IntPtr pcoords)
		{
			return vtkHigherOrderWedge.vtkHigherOrderWedge_GetParametricDistance_25(base.GetCppThis(), pcoords);
		}

		// Token: 0x0601ABC1 RID: 109505
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderWedge_Initialize_26(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ABC2 RID: 109506 RVA: 0x00253894 File Offset: 0x00251A94
		public override void Initialize()
		{
			vtkHigherOrderWedge.vtkHigherOrderWedge_Initialize_26(base.GetCppThis());
		}

		// Token: 0x0601ABC3 RID: 109507
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderWedge_InterpolateDerivs_27(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ABC4 RID: 109508 RVA: 0x002538A3 File Offset: 0x00251AA3
		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkHigherOrderWedge.vtkHigherOrderWedge_InterpolateDerivs_27(base.GetCppThis(), pcoords, derivs);
		}

		// Token: 0x0601ABC5 RID: 109509
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderWedge_InterpolateFunctions_28(HandleRef pThis, IntPtr pcoords, IntPtr weights);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ABC6 RID: 109510 RVA: 0x002538B4 File Offset: 0x00251AB4
		public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkHigherOrderWedge.vtkHigherOrderWedge_InterpolateFunctions_28(base.GetCppThis(), pcoords, weights);
		}

		// Token: 0x0601ABC7 RID: 109511
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderWedge_IntersectWithLine_29(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ABC8 RID: 109512 RVA: 0x002538C8 File Offset: 0x00251AC8
		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkHigherOrderWedge.vtkHigherOrderWedge_IntersectWithLine_29(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		// Token: 0x0601ABC9 RID: 109513
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderWedge_IsA_30(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ABCA RID: 109514 RVA: 0x002538F4 File Offset: 0x00251AF4
		public override int IsA(string type)
		{
			return vtkHigherOrderWedge.vtkHigherOrderWedge_IsA_30(base.GetCppThis(), type);
		}

		// Token: 0x0601ABCB RID: 109515
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderWedge_IsTypeOf_31([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ABCC RID: 109516 RVA: 0x00253914 File Offset: 0x00251B14
		public new static int IsTypeOf(string type)
		{
			return vtkHigherOrderWedge.vtkHigherOrderWedge_IsTypeOf_31(type);
		}

		// Token: 0x0601ABCD RID: 109517
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderWedge_NewInstance_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ABCE RID: 109518 RVA: 0x00253930 File Offset: 0x00251B30
		public new vtkHigherOrderWedge NewInstance()
		{
			vtkHigherOrderWedge result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHigherOrderWedge.vtkHigherOrderWedge_NewInstance_32(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHigherOrderWedge)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601ABCF RID: 109519
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHigherOrderWedge_PointCountSupportsUniformOrder_33(long pointsPerCell);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ABD0 RID: 109520 RVA: 0x0025398C File Offset: 0x00251B8C
		public static bool PointCountSupportsUniformOrder(long pointsPerCell)
		{
			return vtkHigherOrderWedge.vtkHigherOrderWedge_PointCountSupportsUniformOrder_33(pointsPerCell) != 0;
		}

		// Token: 0x0601ABD1 RID: 109521
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderWedge_PointIndexFromIJK_34(int i, int j, int k, IntPtr order);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ABD2 RID: 109522 RVA: 0x002539B0 File Offset: 0x00251BB0
		public static int PointIndexFromIJK(int i, int j, int k, IntPtr order)
		{
			return vtkHigherOrderWedge.vtkHigherOrderWedge_PointIndexFromIJK_34(i, j, k, order);
		}

		// Token: 0x0601ABD3 RID: 109523
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderWedge_PointIndexFromIJK_35(HandleRef pThis, int i, int j, int k);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ABD4 RID: 109524 RVA: 0x002539D0 File Offset: 0x00251BD0
		public int PointIndexFromIJK(int i, int j, int k)
		{
			return vtkHigherOrderWedge.vtkHigherOrderWedge_PointIndexFromIJK_35(base.GetCppThis(), i, j, k);
		}

		// Token: 0x0601ABD5 RID: 109525
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderWedge_RequiresInitialization_36(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ABD6 RID: 109526 RVA: 0x002539F4 File Offset: 0x00251BF4
		public override int RequiresInitialization()
		{
			return vtkHigherOrderWedge.vtkHigherOrderWedge_RequiresInitialization_36(base.GetCppThis());
		}

		// Token: 0x0601ABD7 RID: 109527
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderWedge_SafeDownCast_37(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ABD8 RID: 109528 RVA: 0x00253A14 File Offset: 0x00251C14
		public new static vtkHigherOrderWedge SafeDownCast(vtkObjectBase o)
		{
			vtkHigherOrderWedge vtkHigherOrderWedge = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHigherOrderWedge.vtkHigherOrderWedge_SafeDownCast_37((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHigherOrderWedge = (vtkHigherOrderWedge)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHigherOrderWedge.Register(null);
				}
			}
			return vtkHigherOrderWedge;
		}

		// Token: 0x0601ABD9 RID: 109529
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderWedge_SetOrder_38(HandleRef pThis, int s, int t, int u, long numPts);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ABDA RID: 109530 RVA: 0x00253A93 File Offset: 0x00251C93
		public virtual void SetOrder(int s, int t, int u, long numPts)
		{
			vtkHigherOrderWedge.vtkHigherOrderWedge_SetOrder_38(base.GetCppThis(), s, t, u, numPts);
		}

		// Token: 0x0601ABDB RID: 109531
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderWedge_SetOrderFromCellData_39(HandleRef pThis, HandleRef cell_data, long numPts, long cell_id);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ABDC RID: 109532 RVA: 0x00253AA8 File Offset: 0x00251CA8
		public virtual void SetOrderFromCellData(vtkCellData cell_data, long numPts, long cell_id)
		{
			vtkHigherOrderWedge.vtkHigherOrderWedge_SetOrderFromCellData_39(base.GetCppThis(), (cell_data == null) ? default(HandleRef) : cell_data.GetCppThis(), numPts, cell_id);
		}

		// Token: 0x0601ABDD RID: 109533
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderWedge_SetOrderFromCellData_40(HandleRef cell_data, long numPts, long cell_id, IntPtr order);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ABDE RID: 109534 RVA: 0x00253ADC File Offset: 0x00251CDC
		public static void SetOrderFromCellData(vtkCellData cell_data, long numPts, long cell_id, IntPtr order)
		{
			vtkHigherOrderWedge.vtkHigherOrderWedge_SetOrderFromCellData_40((cell_data == null) ? default(HandleRef) : cell_data.GetCppThis(), numPts, cell_id, order);
		}

		// Token: 0x0601ABDF RID: 109535
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderWedge_SetParametricCoords_41(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ABE0 RID: 109536 RVA: 0x00253B08 File Offset: 0x00251D08
		public void SetParametricCoords()
		{
			vtkHigherOrderWedge.vtkHigherOrderWedge_SetParametricCoords_41(base.GetCppThis());
		}

		// Token: 0x0601ABE1 RID: 109537
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderWedge_SetUniformOrderFromNumPoints_42(HandleRef pThis, long numPts);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ABE2 RID: 109538 RVA: 0x00253B17 File Offset: 0x00251D17
		public virtual void SetUniformOrderFromNumPoints(long numPts)
		{
			vtkHigherOrderWedge.vtkHigherOrderWedge_SetUniformOrderFromNumPoints_42(base.GetCppThis(), numPts);
		}

		// Token: 0x0601ABE3 RID: 109539
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHigherOrderWedge_SubCellCoordinatesFromId_43(HandleRef pThis, vtkVector3i ijk, int subId);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ABE4 RID: 109540 RVA: 0x00253B28 File Offset: 0x00251D28
		public bool SubCellCoordinatesFromId(vtkVector3i ijk, int subId)
		{
			return vtkHigherOrderWedge.vtkHigherOrderWedge_SubCellCoordinatesFromId_43(base.GetCppThis(), ijk, subId) != 0;
		}

		// Token: 0x0601ABE5 RID: 109541
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHigherOrderWedge_SubCellCoordinatesFromId_44(HandleRef pThis, ref int i, ref int j, ref int k, int subId);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ABE6 RID: 109542 RVA: 0x00253B50 File Offset: 0x00251D50
		public bool SubCellCoordinatesFromId(ref int i, ref int j, ref int k, int subId)
		{
			return vtkHigherOrderWedge.vtkHigherOrderWedge_SubCellCoordinatesFromId_44(base.GetCppThis(), ref i, ref j, ref k, subId) != 0;
		}

		// Token: 0x0601ABE7 RID: 109543
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHigherOrderWedge_TransformApproxToCellParams_45(HandleRef pThis, int subCell, IntPtr pcoords);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ABE8 RID: 109544 RVA: 0x00253B7C File Offset: 0x00251D7C
		public bool TransformApproxToCellParams(int subCell, IntPtr pcoords)
		{
			return vtkHigherOrderWedge.vtkHigherOrderWedge_TransformApproxToCellParams_45(base.GetCppThis(), subCell, pcoords) != 0;
		}

		// Token: 0x0601ABE9 RID: 109545
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHigherOrderWedge_TransformFaceToCellParams_46(HandleRef pThis, int bdyFace, IntPtr pcoords);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ABEA RID: 109546 RVA: 0x00253BA4 File Offset: 0x00251DA4
		public bool TransformFaceToCellParams(int bdyFace, IntPtr pcoords)
		{
			return vtkHigherOrderWedge.vtkHigherOrderWedge_TransformFaceToCellParams_46(base.GetCppThis(), bdyFace, pcoords) != 0;
		}

		// Token: 0x0601ABEB RID: 109547
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderWedge_TriangulateLocalIds_47(HandleRef pThis, int index, HandleRef ptIds);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ABEC RID: 109548 RVA: 0x00253BCC File Offset: 0x00251DCC
		public override int TriangulateLocalIds(int index, vtkIdList ptIds)
		{
			return vtkHigherOrderWedge.vtkHigherOrderWedge_TriangulateLocalIds_47(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CEE RID: 7406
		public new const string MRFullTypeName = "Kitware.VTK.vtkHigherOrderWedge";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CEF RID: 7407
		public new static readonly string MRClassNameKey = "class vtkHigherOrderWedge";
	}
}
