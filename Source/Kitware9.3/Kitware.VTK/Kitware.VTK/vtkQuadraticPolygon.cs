using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkQuadraticPolygon
	/// </summary>
	/// <remarks>
	///    a cell that represents a parabolic n-sided polygon
	///
	/// vtkQuadraticPolygon is a concrete implementation of vtkNonLinearCell to
	/// represent a 2D n-sided (2*n nodes) parabolic polygon. The polygon cannot
	/// have any internal holes, and cannot self-intersect. The cell includes a
	/// mid-edge node for each of the n edges of the cell. The ordering of the
	/// 2*n points defining the cell are point ids (0..n-1 and n..2*n-1) where ids
	/// 0..n-1 define the corner vertices of the polygon; ids n..2*n-1 define the
	/// midedge nodes. Define the polygon with points ordered in the counter-
	/// clockwise direction; do not repeat the last point.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkQuadraticEdge vtkQuadraticTriangle vtkQuadraticTetra
	/// vtkQuadraticHexahedron vtkQuadraticWedge vtkQuadraticPyramid
	/// </seealso>
	// Token: 0x02000AAF RID: 2735
	public class vtkQuadraticPolygon : vtkNonLinearCell
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601CC02 RID: 117762 RVA: 0x00287349 File Offset: 0x00285549
		static vtkQuadraticPolygon()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkQuadraticPolygon.MRClassNameKey, Type.GetType("Kitware.VTK.vtkQuadraticPolygon"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601CC03 RID: 117763 RVA: 0x00287371 File Offset: 0x00285571
		public vtkQuadraticPolygon(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601CC04 RID: 117764
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticPolygon_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CC05 RID: 117765 RVA: 0x00287380 File Offset: 0x00285580
		public new static vtkQuadraticPolygon New()
		{
			vtkQuadraticPolygon result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadraticPolygon.vtkQuadraticPolygon_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuadraticPolygon)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CC06 RID: 117766 RVA: 0x002873D4 File Offset: 0x002855D4
		public vtkQuadraticPolygon() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkQuadraticPolygon.vtkQuadraticPolygon_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601CC07 RID: 117767 RVA: 0x00287418 File Offset: 0x00285618
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601CC08 RID: 117768
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticPolygon_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

		/// <summary>
		/// These methods are based on the vtkPolygon ones :
		/// the vtkQuadraticPolygon (with n edges and 2*n points)
		/// is transform into a vtkPolygon (with 2*n edges and 2*n points)
		/// and the vtkPolygon methods are called.
		/// </summary>
		// Token: 0x0601CC09 RID: 117769 RVA: 0x00287424 File Offset: 0x00285624
		public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
		{
			return vtkQuadraticPolygon.vtkQuadraticPolygon_CellBoundary_01(base.GetCppThis(), subId, pcoords, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601CC0A RID: 117770
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticPolygon_Clip_02(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

		/// <summary>
		/// These methods are based on the vtkPolygon ones :
		/// the vtkQuadraticPolygon (with n edges and 2*n points)
		/// is transform into a vtkPolygon (with 2*n edges and 2*n points)
		/// and the vtkPolygon methods are called.
		/// </summary>
		// Token: 0x0601CC0B RID: 117771 RVA: 0x0028745C File Offset: 0x0028565C
		public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
		{
			vtkQuadraticPolygon.vtkQuadraticPolygon_Clip_02(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis(), insideOut);
		}

		// Token: 0x0601CC0C RID: 117772
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticPolygon_ComputeCentroid_03(HandleRef ids, HandleRef pts, IntPtr centroid);

		/// <summary>
		/// These methods are based on the vtkPolygon ones :
		/// the vtkQuadraticPolygon (with n edges and 2*n points)
		/// is transform into a vtkPolygon (with 2*n edges and 2*n points)
		/// and the vtkPolygon methods are called.
		/// </summary>
		// Token: 0x0601CC0D RID: 117773 RVA: 0x00287518 File Offset: 0x00285718
		public static void ComputeCentroid(vtkIdTypeArray ids, vtkPoints pts, IntPtr centroid)
		{
			vtkQuadraticPolygon.vtkQuadraticPolygon_ComputeCentroid_03((ids == null) ? default(HandleRef) : ids.GetCppThis(), (pts == null) ? default(HandleRef) : pts.GetCppThis(), centroid);
		}

		// Token: 0x0601CC0E RID: 117774
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticPolygon_Contour_04(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

		/// <summary>
		/// These methods are based on the vtkPolygon ones :
		/// the vtkQuadraticPolygon (with n edges and 2*n points)
		/// is transform into a vtkPolygon (with 2*n edges and 2*n points)
		/// and the vtkPolygon methods are called.
		/// </summary>
		// Token: 0x0601CC0F RID: 117775 RVA: 0x00287558 File Offset: 0x00285758
		public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
		{
			vtkQuadraticPolygon.vtkQuadraticPolygon_Contour_04(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis());
		}

		// Token: 0x0601CC10 RID: 117776
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticPolygon_Derivatives_05(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

		/// <summary>
		/// These methods are based on the vtkPolygon ones :
		/// the vtkQuadraticPolygon (with n edges and 2*n points)
		/// is transform into a vtkPolygon (with 2*n edges and 2*n points)
		/// and the vtkPolygon methods are called.
		/// </summary>
		// Token: 0x0601CC11 RID: 117777 RVA: 0x00287640 File Offset: 0x00285840
		public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
		{
			vtkQuadraticPolygon.vtkQuadraticPolygon_Derivatives_05(base.GetCppThis(), subId, pcoords, values, dim, derivs);
		}

		// Token: 0x0601CC12 RID: 117778
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkQuadraticPolygon_DistanceToPolygon_06(IntPtr x, int numPts, IntPtr pts, IntPtr bounds, IntPtr closest);

		/// <summary>
		/// These methods are based on the vtkPolygon ones :
		/// the vtkQuadraticPolygon (with n edges and 2*n points)
		/// is transform into a vtkPolygon (with 2*n edges and 2*n points)
		/// and the vtkPolygon methods are called.
		/// </summary>
		// Token: 0x0601CC13 RID: 117779 RVA: 0x00287658 File Offset: 0x00285858
		public static double DistanceToPolygon(IntPtr x, int numPts, IntPtr pts, IntPtr bounds, IntPtr closest)
		{
			return vtkQuadraticPolygon.vtkQuadraticPolygon_DistanceToPolygon_06(x, numPts, pts, bounds, closest);
		}

		// Token: 0x0601CC14 RID: 117780
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticPolygon_EvaluateLocation_07(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

		/// <summary>
		/// These methods are based on the vtkPolygon ones :
		/// the vtkQuadraticPolygon (with n edges and 2*n points)
		/// is transform into a vtkPolygon (with 2*n edges and 2*n points)
		/// and the vtkPolygon methods are called.
		/// </summary>
		// Token: 0x0601CC15 RID: 117781 RVA: 0x00287677 File Offset: 0x00285877
		public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
		{
			vtkQuadraticPolygon.vtkQuadraticPolygon_EvaluateLocation_07(base.GetCppThis(), ref subId, pcoords, x, weights);
		}

		// Token: 0x0601CC16 RID: 117782
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticPolygon_EvaluatePosition_08(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

		/// <summary>
		/// These methods are based on the vtkPolygon ones :
		/// the vtkQuadraticPolygon (with n edges and 2*n points)
		/// is transform into a vtkPolygon (with 2*n edges and 2*n points)
		/// and the vtkPolygon methods are called.
		/// </summary>
		// Token: 0x0601CC17 RID: 117783 RVA: 0x0028768C File Offset: 0x0028588C
		public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
		{
			return vtkQuadraticPolygon.vtkQuadraticPolygon_EvaluatePosition_08(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
		}

		// Token: 0x0601CC18 RID: 117784
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticPolygon_GetCellDimension_09(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CC19 RID: 117785 RVA: 0x002876B4 File Offset: 0x002858B4
		public override int GetCellDimension()
		{
			return vtkQuadraticPolygon.vtkQuadraticPolygon_GetCellDimension_09(base.GetCppThis());
		}

		// Token: 0x0601CC1A RID: 117786
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticPolygon_GetCellType_10(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CC1B RID: 117787 RVA: 0x002876D4 File Offset: 0x002858D4
		public override int GetCellType()
		{
			return vtkQuadraticPolygon.vtkQuadraticPolygon_GetCellType_10(base.GetCppThis());
		}

		// Token: 0x0601CC1C RID: 117788
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticPolygon_GetEdge_11(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CC1D RID: 117789 RVA: 0x002876F4 File Offset: 0x002858F4
		public override vtkCell GetEdge(int arg0)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadraticPolygon.vtkQuadraticPolygon_GetEdge_11(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601CC1E RID: 117790
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticPolygon_GetFace_12(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CC1F RID: 117791 RVA: 0x00287764 File Offset: 0x00285964
		public override vtkCell GetFace(int arg0)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadraticPolygon.vtkQuadraticPolygon_GetFace_12(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601CC20 RID: 117792
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticPolygon_GetNumberOfEdges_13(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CC21 RID: 117793 RVA: 0x002877D4 File Offset: 0x002859D4
		public override int GetNumberOfEdges()
		{
			return vtkQuadraticPolygon.vtkQuadraticPolygon_GetNumberOfEdges_13(base.GetCppThis());
		}

		// Token: 0x0601CC22 RID: 117794
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticPolygon_GetNumberOfFaces_14(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CC23 RID: 117795 RVA: 0x002877F4 File Offset: 0x002859F4
		public override int GetNumberOfFaces()
		{
			return vtkQuadraticPolygon.vtkQuadraticPolygon_GetNumberOfFaces_14(base.GetCppThis());
		}

		// Token: 0x0601CC24 RID: 117796
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkQuadraticPolygon_GetNumberOfGenerationsFromBase_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CC25 RID: 117797 RVA: 0x00287814 File Offset: 0x00285A14
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkQuadraticPolygon.vtkQuadraticPolygon_GetNumberOfGenerationsFromBase_15(base.GetCppThis(), type);
		}

		// Token: 0x0601CC26 RID: 117798
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkQuadraticPolygon_GetNumberOfGenerationsFromBaseType_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CC27 RID: 117799 RVA: 0x00287834 File Offset: 0x00285A34
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkQuadraticPolygon.vtkQuadraticPolygon_GetNumberOfGenerationsFromBaseType_16(type);
		}

		// Token: 0x0601CC28 RID: 117800
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkQuadraticPolygon_GetUseMVCInterpolation_17(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag indicating whether to use Mean Value Coordinate for the
		/// interpolation. If true, InterpolateFunctions() uses the Mean Value
		/// Coordinate to compute weights. Otherwise, the conventional 1/r^2 method
		/// is used. The UseMVCInterpolation parameter is set to true by default.
		/// </summary>
		// Token: 0x0601CC29 RID: 117801 RVA: 0x00287850 File Offset: 0x00285A50
		public virtual bool GetUseMVCInterpolation()
		{
			return vtkQuadraticPolygon.vtkQuadraticPolygon_GetUseMVCInterpolation_17(base.GetCppThis()) != 0;
		}

		// Token: 0x0601CC2A RID: 117802
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticPolygon_InterpolateFunctions_18(HandleRef pThis, IntPtr x, IntPtr weights);

		/// <summary>
		/// These methods are based on the vtkPolygon ones :
		/// the vtkQuadraticPolygon (with n edges and 2*n points)
		/// is transform into a vtkPolygon (with 2*n edges and 2*n points)
		/// and the vtkPolygon methods are called.
		/// </summary>
		// Token: 0x0601CC2B RID: 117803 RVA: 0x00287876 File Offset: 0x00285A76
		public override void InterpolateFunctions(IntPtr x, IntPtr weights)
		{
			vtkQuadraticPolygon.vtkQuadraticPolygon_InterpolateFunctions_18(base.GetCppThis(), x, weights);
		}

		// Token: 0x0601CC2C RID: 117804
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticPolygon_IntersectConvex2DCells_19(HandleRef cell1, HandleRef cell2, double tol, IntPtr p0, IntPtr p1);

		/// <summary>
		/// These methods are based on the vtkPolygon ones :
		/// the vtkQuadraticPolygon (with n edges and 2*n points)
		/// is transform into a vtkPolygon (with 2*n edges and 2*n points)
		/// and the vtkPolygon methods are called.
		/// </summary>
		// Token: 0x0601CC2D RID: 117805 RVA: 0x00287888 File Offset: 0x00285A88
		public static int IntersectConvex2DCells(vtkCell cell1, vtkCell cell2, double tol, IntPtr p0, IntPtr p1)
		{
			return vtkQuadraticPolygon.vtkQuadraticPolygon_IntersectConvex2DCells_19((cell1 == null) ? default(HandleRef) : cell1.GetCppThis(), (cell2 == null) ? default(HandleRef) : cell2.GetCppThis(), tol, p0, p1);
		}

		// Token: 0x0601CC2E RID: 117806
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticPolygon_IntersectPolygonWithPolygon_20(int npts, IntPtr pts, IntPtr bounds, int npts2, IntPtr pts2, IntPtr bounds2, double tol, IntPtr x);

		/// <summary>
		/// These methods are based on the vtkPolygon ones :
		/// the vtkQuadraticPolygon (with n edges and 2*n points)
		/// is transform into a vtkPolygon (with 2*n edges and 2*n points)
		/// and the vtkPolygon methods are called.
		/// </summary>
		// Token: 0x0601CC2F RID: 117807 RVA: 0x002878D0 File Offset: 0x00285AD0
		public static int IntersectPolygonWithPolygon(int npts, IntPtr pts, IntPtr bounds, int npts2, IntPtr pts2, IntPtr bounds2, double tol, IntPtr x)
		{
			return vtkQuadraticPolygon.vtkQuadraticPolygon_IntersectPolygonWithPolygon_20(npts, pts, bounds, npts2, pts2, bounds2, tol, x);
		}

		// Token: 0x0601CC30 RID: 117808
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticPolygon_IntersectWithLine_21(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		/// <summary>
		/// These methods are based on the vtkPolygon ones :
		/// the vtkQuadraticPolygon (with n edges and 2*n points)
		/// is transform into a vtkPolygon (with 2*n edges and 2*n points)
		/// and the vtkPolygon methods are called.
		/// </summary>
		// Token: 0x0601CC31 RID: 117809 RVA: 0x002878F8 File Offset: 0x00285AF8
		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkQuadraticPolygon.vtkQuadraticPolygon_IntersectWithLine_21(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		// Token: 0x0601CC32 RID: 117810
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticPolygon_IsA_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CC33 RID: 117811 RVA: 0x00287924 File Offset: 0x00285B24
		public override int IsA(string type)
		{
			return vtkQuadraticPolygon.vtkQuadraticPolygon_IsA_22(base.GetCppThis(), type);
		}

		// Token: 0x0601CC34 RID: 117812
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticPolygon_IsPrimaryCell_23(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CC35 RID: 117813 RVA: 0x00287944 File Offset: 0x00285B44
		public override int IsPrimaryCell()
		{
			return vtkQuadraticPolygon.vtkQuadraticPolygon_IsPrimaryCell_23(base.GetCppThis());
		}

		// Token: 0x0601CC36 RID: 117814
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticPolygon_IsTypeOf_24([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CC37 RID: 117815 RVA: 0x00287964 File Offset: 0x00285B64
		public new static int IsTypeOf(string type)
		{
			return vtkQuadraticPolygon.vtkQuadraticPolygon_IsTypeOf_24(type);
		}

		// Token: 0x0601CC38 RID: 117816
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticPolygon_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CC39 RID: 117817 RVA: 0x00287980 File Offset: 0x00285B80
		public new vtkQuadraticPolygon NewInstance()
		{
			vtkQuadraticPolygon result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadraticPolygon.vtkQuadraticPolygon_NewInstance_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuadraticPolygon)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601CC3A RID: 117818
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticPolygon_NonDegenerateTriangulate_27(HandleRef pThis, HandleRef outTris);

		/// <summary>
		/// These methods are based on the vtkPolygon ones :
		/// the vtkQuadraticPolygon (with n edges and 2*n points)
		/// is transform into a vtkPolygon (with 2*n edges and 2*n points)
		/// and the vtkPolygon methods are called.
		/// </summary>
		// Token: 0x0601CC3B RID: 117819 RVA: 0x002879DC File Offset: 0x00285BDC
		public int NonDegenerateTriangulate(vtkIdList outTris)
		{
			return vtkQuadraticPolygon.vtkQuadraticPolygon_NonDegenerateTriangulate_27(base.GetCppThis(), (outTris == null) ? default(HandleRef) : outTris.GetCppThis());
		}

		// Token: 0x0601CC3C RID: 117820
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticPolygon_ParameterizePolygon_28(HandleRef pThis, IntPtr p0, IntPtr p10, ref double l10, IntPtr p20, ref double l20, IntPtr n);

		/// <summary>
		/// These methods are based on the vtkPolygon ones :
		/// the vtkQuadraticPolygon (with n edges and 2*n points)
		/// is transform into a vtkPolygon (with 2*n edges and 2*n points)
		/// and the vtkPolygon methods are called.
		/// </summary>
		// Token: 0x0601CC3D RID: 117821 RVA: 0x00287A10 File Offset: 0x00285C10
		public int ParameterizePolygon(IntPtr p0, IntPtr p10, ref double l10, IntPtr p20, ref double l20, IntPtr n)
		{
			return vtkQuadraticPolygon.vtkQuadraticPolygon_ParameterizePolygon_28(base.GetCppThis(), p0, p10, ref l10, p20, ref l20, n);
		}

		// Token: 0x0601CC3E RID: 117822
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticPolygon_PointInPolygon_29(IntPtr x, int numPts, IntPtr pts, IntPtr bounds, IntPtr n);

		/// <summary>
		/// These methods are based on the vtkPolygon ones :
		/// the vtkQuadraticPolygon (with n edges and 2*n points)
		/// is transform into a vtkPolygon (with 2*n edges and 2*n points)
		/// and the vtkPolygon methods are called.
		/// </summary>
		// Token: 0x0601CC3F RID: 117823 RVA: 0x00287A38 File Offset: 0x00285C38
		public static int PointInPolygon(IntPtr x, int numPts, IntPtr pts, IntPtr bounds, IntPtr n)
		{
			return vtkQuadraticPolygon.vtkQuadraticPolygon_PointInPolygon_29(x, numPts, pts, bounds, n);
		}

		// Token: 0x0601CC40 RID: 117824
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticPolygon_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CC41 RID: 117825 RVA: 0x00287A58 File Offset: 0x00285C58
		public new static vtkQuadraticPolygon SafeDownCast(vtkObjectBase o)
		{
			vtkQuadraticPolygon vtkQuadraticPolygon = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadraticPolygon.vtkQuadraticPolygon_SafeDownCast_30((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkQuadraticPolygon = (vtkQuadraticPolygon)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkQuadraticPolygon.Register(null);
				}
			}
			return vtkQuadraticPolygon;
		}

		// Token: 0x0601CC42 RID: 117826
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticPolygon_SetUseMVCInterpolation_31(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get the flag indicating whether to use Mean Value Coordinate for the
		/// interpolation. If true, InterpolateFunctions() uses the Mean Value
		/// Coordinate to compute weights. Otherwise, the conventional 1/r^2 method
		/// is used. The UseMVCInterpolation parameter is set to true by default.
		/// </summary>
		// Token: 0x0601CC43 RID: 117827 RVA: 0x00287AD7 File Offset: 0x00285CD7
		public virtual void SetUseMVCInterpolation(bool _arg)
		{
			vtkQuadraticPolygon.vtkQuadraticPolygon_SetUseMVCInterpolation_31(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0601CC44 RID: 117828
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticPolygon_Triangulate_32(HandleRef pThis, int index, HandleRef ptIds, HandleRef pts);

		/// <summary>
		/// These methods are based on the vtkPolygon ones :
		/// the vtkQuadraticPolygon (with n edges and 2*n points)
		/// is transform into a vtkPolygon (with 2*n edges and 2*n points)
		/// and the vtkPolygon methods are called.
		/// </summary>
		// Token: 0x0601CC45 RID: 117829 RVA: 0x00287AF0 File Offset: 0x00285CF0
		public override int Triangulate(int index, vtkIdList ptIds, vtkPoints pts)
		{
			return vtkQuadraticPolygon.vtkQuadraticPolygon_Triangulate_32(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis(), (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601CC46 RID: 117830
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticPolygon_TriangulateLocalIds_33(HandleRef pThis, int index, HandleRef ptIds);

		/// <summary>
		/// These methods are based on the vtkPolygon ones :
		/// the vtkQuadraticPolygon (with n edges and 2*n points)
		/// is transform into a vtkPolygon (with 2*n edges and 2*n points)
		/// and the vtkPolygon methods are called.
		/// </summary>
		// Token: 0x0601CC47 RID: 117831 RVA: 0x00287B3C File Offset: 0x00285D3C
		public override int TriangulateLocalIds(int index, vtkIdList ptIds)
		{
			return vtkQuadraticPolygon.vtkQuadraticPolygon_TriangulateLocalIds_33(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E67 RID: 7783
		public new const string MRFullTypeName = "Kitware.VTK.vtkQuadraticPolygon";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E68 RID: 7784
		public new static readonly string MRClassNameKey = "class vtkQuadraticPolygon";
	}
}
