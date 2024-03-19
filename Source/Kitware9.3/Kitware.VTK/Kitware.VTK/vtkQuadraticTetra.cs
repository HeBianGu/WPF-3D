using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkQuadraticTetra
	/// </summary>
	/// <remarks>
	///    cell represents a parabolic, 10-node isoparametric tetrahedron
	///
	/// vtkQuadraticTetra is a concrete implementation of vtkNonLinearCell to
	/// represent a three-dimensional, 10-node, isoparametric parabolic
	/// tetrahedron. The interpolation is the standard finite element, quadratic
	/// isoparametric shape function. The cell includes a mid-edge node on each of
	/// the size edges of the tetrahedron. The ordering of the ten points defining
	/// the cell is point ids (0-3,4-9) where ids 0-3 are the four tetra
	/// vertices; and point ids 4-9 are the midedge nodes between (0,1), (1,2),
	/// (2,0), (0,3), (1,3), and (2,3).
	///
	/// Note that this class uses an internal linear tessellation for some internal operations
	/// (e.g., clipping and contouring). This means that some artifacts may appear trying to
	/// represent a non-linear interpolation function with linear tets.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkQuadraticEdge vtkQuadraticTriangle vtkQuadraticWedge
	/// vtkQuadraticQuad vtkQuadraticHexahedron vtkQuadraticPyramid
	/// </seealso>
	// Token: 0x02000AB2 RID: 2738
	public class vtkQuadraticTetra : vtkNonLinearCell
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601CCC0 RID: 117952 RVA: 0x002888D9 File Offset: 0x00286AD9
		static vtkQuadraticTetra()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkQuadraticTetra.MRClassNameKey, Type.GetType("Kitware.VTK.vtkQuadraticTetra"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601CCC1 RID: 117953 RVA: 0x00288901 File Offset: 0x00286B01
		public vtkQuadraticTetra(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601CCC2 RID: 117954
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticTetra_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CCC3 RID: 117955 RVA: 0x00288910 File Offset: 0x00286B10
		public new static vtkQuadraticTetra New()
		{
			vtkQuadraticTetra result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadraticTetra.vtkQuadraticTetra_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuadraticTetra)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CCC4 RID: 117956 RVA: 0x00288964 File Offset: 0x00286B64
		public vtkQuadraticTetra() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkQuadraticTetra.vtkQuadraticTetra_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601CCC5 RID: 117957 RVA: 0x002889A8 File Offset: 0x00286BA8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601CCC6 RID: 117958
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticTetra_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CCC7 RID: 117959 RVA: 0x002889B4 File Offset: 0x00286BB4
		public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
		{
			return vtkQuadraticTetra.vtkQuadraticTetra_CellBoundary_01(base.GetCppThis(), subId, pcoords, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601CCC8 RID: 117960
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticTetra_Clip_02(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef tetras, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

		/// <summary>
		/// Clip this edge using scalar value provided. Like contouring, except
		/// that it cuts the tetra to produce new tetras.
		/// </summary>
		// Token: 0x0601CCC9 RID: 117961 RVA: 0x002889EC File Offset: 0x00286BEC
		public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray tetras, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
		{
			vtkQuadraticTetra.vtkQuadraticTetra_Clip_02(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (tetras == null) ? default(HandleRef) : tetras.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis(), insideOut);
		}

		// Token: 0x0601CCCA RID: 117962
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticTetra_Contour_03(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CCCB RID: 117963 RVA: 0x00288AA8 File Offset: 0x00286CA8
		public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
		{
			vtkQuadraticTetra.vtkQuadraticTetra_Contour_03(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis());
		}

		// Token: 0x0601CCCC RID: 117964
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticTetra_Derivatives_04(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CCCD RID: 117965 RVA: 0x00288B90 File Offset: 0x00286D90
		public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
		{
			vtkQuadraticTetra.vtkQuadraticTetra_Derivatives_04(base.GetCppThis(), subId, pcoords, values, dim, derivs);
		}

		// Token: 0x0601CCCE RID: 117966
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticTetra_EvaluateLocation_05(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CCCF RID: 117967 RVA: 0x00288BA6 File Offset: 0x00286DA6
		public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
		{
			vtkQuadraticTetra.vtkQuadraticTetra_EvaluateLocation_05(base.GetCppThis(), ref subId, pcoords, x, weights);
		}

		// Token: 0x0601CCD0 RID: 117968
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticTetra_EvaluatePosition_06(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CCD1 RID: 117969 RVA: 0x00288BBC File Offset: 0x00286DBC
		public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
		{
			return vtkQuadraticTetra.vtkQuadraticTetra_EvaluatePosition_06(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
		}

		// Token: 0x0601CCD2 RID: 117970
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticTetra_GetCellDimension_07(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CCD3 RID: 117971 RVA: 0x00288BE4 File Offset: 0x00286DE4
		public override int GetCellDimension()
		{
			return vtkQuadraticTetra.vtkQuadraticTetra_GetCellDimension_07(base.GetCppThis());
		}

		// Token: 0x0601CCD4 RID: 117972
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticTetra_GetCellType_08(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CCD5 RID: 117973 RVA: 0x00288C04 File Offset: 0x00286E04
		public override int GetCellType()
		{
			return vtkQuadraticTetra.vtkQuadraticTetra_GetCellType_08(base.GetCppThis());
		}

		// Token: 0x0601CCD6 RID: 117974
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticTetra_GetEdge_09(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CCD7 RID: 117975 RVA: 0x00288C24 File Offset: 0x00286E24
		public override vtkCell GetEdge(int arg0)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadraticTetra.vtkQuadraticTetra_GetEdge_09(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601CCD8 RID: 117976
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticTetra_GetEdgeArray_10(long edgeId);

		/// <summary>
		/// Return the ids of the vertices defining edge/face (`edgeId`/`faceId').
		/// Ids are related to the cell, not to the dataset.
		///
		/// @note The return type changed. It used to be int*, it is now const vtkIdType*.
		/// This is so ids are unified between vtkCell and vtkPoints.
		/// </summary>
		// Token: 0x0601CCD9 RID: 117977 RVA: 0x00288C94 File Offset: 0x00286E94
		public static IntPtr GetEdgeArray(long edgeId)
		{
			return vtkQuadraticTetra.vtkQuadraticTetra_GetEdgeArray_10(edgeId);
		}

		// Token: 0x0601CCDA RID: 117978
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticTetra_GetFace_11(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CCDB RID: 117979 RVA: 0x00288CB0 File Offset: 0x00286EB0
		public override vtkCell GetFace(int arg0)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadraticTetra.vtkQuadraticTetra_GetFace_11(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601CCDC RID: 117980
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticTetra_GetFaceArray_12(long faceId);

		/// <summary>
		/// Return the ids of the vertices defining edge/face (`edgeId`/`faceId').
		/// Ids are related to the cell, not to the dataset.
		///
		/// @note The return type changed. It used to be int*, it is now const vtkIdType*.
		/// This is so ids are unified between vtkCell and vtkPoints.
		/// </summary>
		// Token: 0x0601CCDD RID: 117981 RVA: 0x00288D20 File Offset: 0x00286F20
		public static IntPtr GetFaceArray(long faceId)
		{
			return vtkQuadraticTetra.vtkQuadraticTetra_GetFaceArray_12(faceId);
		}

		// Token: 0x0601CCDE RID: 117982
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticTetra_GetNumberOfEdges_13(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CCDF RID: 117983 RVA: 0x00288D3C File Offset: 0x00286F3C
		public override int GetNumberOfEdges()
		{
			return vtkQuadraticTetra.vtkQuadraticTetra_GetNumberOfEdges_13(base.GetCppThis());
		}

		// Token: 0x0601CCE0 RID: 117984
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticTetra_GetNumberOfFaces_14(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CCE1 RID: 117985 RVA: 0x00288D5C File Offset: 0x00286F5C
		public override int GetNumberOfFaces()
		{
			return vtkQuadraticTetra.vtkQuadraticTetra_GetNumberOfFaces_14(base.GetCppThis());
		}

		// Token: 0x0601CCE2 RID: 117986
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkQuadraticTetra_GetNumberOfGenerationsFromBase_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CCE3 RID: 117987 RVA: 0x00288D7C File Offset: 0x00286F7C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkQuadraticTetra.vtkQuadraticTetra_GetNumberOfGenerationsFromBase_15(base.GetCppThis(), type);
		}

		// Token: 0x0601CCE4 RID: 117988
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkQuadraticTetra_GetNumberOfGenerationsFromBaseType_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CCE5 RID: 117989 RVA: 0x00288D9C File Offset: 0x00286F9C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkQuadraticTetra.vtkQuadraticTetra_GetNumberOfGenerationsFromBaseType_16(type);
		}

		// Token: 0x0601CCE6 RID: 117990
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticTetra_GetParametricCenter_17(HandleRef pThis, IntPtr pcoords);

		/// <summary>
		/// Return the center of the quadratic tetra in parametric coordinates.
		/// </summary>
		// Token: 0x0601CCE7 RID: 117991 RVA: 0x00288DB8 File Offset: 0x00286FB8
		public override int GetParametricCenter(IntPtr pcoords)
		{
			return vtkQuadraticTetra.vtkQuadraticTetra_GetParametricCenter_17(base.GetCppThis(), pcoords);
		}

		// Token: 0x0601CCE8 RID: 117992
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticTetra_GetParametricCoords_18(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CCE9 RID: 117993 RVA: 0x00288DD8 File Offset: 0x00286FD8
		public override IntPtr GetParametricCoords()
		{
			return vtkQuadraticTetra.vtkQuadraticTetra_GetParametricCoords_18(base.GetCppThis());
		}

		// Token: 0x0601CCEA RID: 117994
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkQuadraticTetra_GetParametricDistance_19(HandleRef pThis, IntPtr pcoords);

		/// <summary>
		/// Return the distance of the parametric coordinate provided to the
		/// cell. If inside the cell, a distance of zero is returned.
		/// </summary>
		// Token: 0x0601CCEB RID: 117995 RVA: 0x00288DF8 File Offset: 0x00286FF8
		public override double GetParametricDistance(IntPtr pcoords)
		{
			return vtkQuadraticTetra.vtkQuadraticTetra_GetParametricDistance_19(base.GetCppThis(), pcoords);
		}

		// Token: 0x0601CCEC RID: 117996
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticTetra_InterpolateDerivs_20(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601CCED RID: 117997 RVA: 0x00288E18 File Offset: 0x00287018
		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkQuadraticTetra.vtkQuadraticTetra_InterpolateDerivs_20(base.GetCppThis(), pcoords, derivs);
		}

		// Token: 0x0601CCEE RID: 117998
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticTetra_InterpolateFunctions_21(HandleRef pThis, IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601CCEF RID: 117999 RVA: 0x00288E29 File Offset: 0x00287029
		public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkQuadraticTetra.vtkQuadraticTetra_InterpolateFunctions_21(base.GetCppThis(), pcoords, weights);
		}

		// Token: 0x0601CCF0 RID: 118000
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticTetra_InterpolationDerivs_22(IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Return the distance of the parametric coordinate provided to the
		/// cell. If inside the cell, a distance of zero is returned.
		/// </summary>
		// Token: 0x0601CCF1 RID: 118001 RVA: 0x00288E3A File Offset: 0x0028703A
		public static void InterpolationDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkQuadraticTetra.vtkQuadraticTetra_InterpolationDerivs_22(pcoords, derivs);
		}

		// Token: 0x0601CCF2 RID: 118002
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticTetra_InterpolationFunctions_23(IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Return the distance of the parametric coordinate provided to the
		/// cell. If inside the cell, a distance of zero is returned.
		/// </summary>
		// Token: 0x0601CCF3 RID: 118003 RVA: 0x00288E45 File Offset: 0x00287045
		public static void InterpolationFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkQuadraticTetra.vtkQuadraticTetra_InterpolationFunctions_23(pcoords, weights);
		}

		// Token: 0x0601CCF4 RID: 118004
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticTetra_IntersectWithLine_24(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		/// <summary>
		/// Line-edge intersection. Intersection has to occur within [0,1] parametric
		/// coordinates and with specified tolerance.
		/// </summary>
		// Token: 0x0601CCF5 RID: 118005 RVA: 0x00288E50 File Offset: 0x00287050
		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkQuadraticTetra.vtkQuadraticTetra_IntersectWithLine_24(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		// Token: 0x0601CCF6 RID: 118006
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticTetra_IsA_25(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CCF7 RID: 118007 RVA: 0x00288E7C File Offset: 0x0028707C
		public override int IsA(string type)
		{
			return vtkQuadraticTetra.vtkQuadraticTetra_IsA_25(base.GetCppThis(), type);
		}

		// Token: 0x0601CCF8 RID: 118008
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticTetra_IsTypeOf_26([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CCF9 RID: 118009 RVA: 0x00288E9C File Offset: 0x0028709C
		public new static int IsTypeOf(string type)
		{
			return vtkQuadraticTetra.vtkQuadraticTetra_IsTypeOf_26(type);
		}

		// Token: 0x0601CCFA RID: 118010
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticTetra_NewInstance_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CCFB RID: 118011 RVA: 0x00288EB8 File Offset: 0x002870B8
		public new vtkQuadraticTetra NewInstance()
		{
			vtkQuadraticTetra result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadraticTetra.vtkQuadraticTetra_NewInstance_28(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuadraticTetra)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601CCFC RID: 118012
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticTetra_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CCFD RID: 118013 RVA: 0x00288F14 File Offset: 0x00287114
		public new static vtkQuadraticTetra SafeDownCast(vtkObjectBase o)
		{
			vtkQuadraticTetra vtkQuadraticTetra = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadraticTetra.vtkQuadraticTetra_SafeDownCast_29((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkQuadraticTetra = (vtkQuadraticTetra)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkQuadraticTetra.Register(null);
				}
			}
			return vtkQuadraticTetra;
		}

		// Token: 0x0601CCFE RID: 118014
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkQuadraticTetra_StableClip_30(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef tetras, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

		/// <summary>
		/// Clip this edge using scalar value provided. Like contouring, except
		/// that it cuts the tetra to produce new tetras.
		///
		/// Returns true if newly inserted cell is a quadratic tetra, false otherwise.
		///
		/// @see vtkNonLinearCell::StableClip
		/// </summary>
		// Token: 0x0601CCFF RID: 118015 RVA: 0x00288F94 File Offset: 0x00287194
		public override bool StableClip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray tetras, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
		{
			return vtkQuadraticTetra.vtkQuadraticTetra_StableClip_30(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (tetras == null) ? default(HandleRef) : tetras.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis(), insideOut) != 0;
		}

		// Token: 0x0601CD00 RID: 118016
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticTetra_TriangulateLocalIds_31(HandleRef pThis, int index, HandleRef ptIds);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CD01 RID: 118017 RVA: 0x0028905C File Offset: 0x0028725C
		public override int TriangulateLocalIds(int index, vtkIdList ptIds)
		{
			return vtkQuadraticTetra.vtkQuadraticTetra_TriangulateLocalIds_31(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E6D RID: 7789
		public new const string MRFullTypeName = "Kitware.VTK.vtkQuadraticTetra";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E6E RID: 7790
		public new static readonly string MRClassNameKey = "class vtkQuadraticTetra";
	}
}
