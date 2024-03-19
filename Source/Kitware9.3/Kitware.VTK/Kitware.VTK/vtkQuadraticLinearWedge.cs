using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkQuadraticLinearWedge
	/// </summary>
	/// <remarks>
	///    cell represents a, 12-node isoparametric wedge
	///
	/// vtkQuadraticLinearWedge is a concrete implementation of vtkNonLinearCell to
	/// represent a three-dimensional, 12-node isoparametric linear quadratic
	/// wedge. The interpolation is the standard finite element, quadratic
	/// isoparametric shape function in xy - layer and the linear functions in z - direction.
	/// The cell includes mid-edge node in the triangle edges. The
	/// ordering of the 12 points defining the cell is point ids (0-5,6-12)
	/// where point ids 0-5 are the six corner vertices of the wedge; followed by
	/// six midedge nodes (6-12). Note that these midedge nodes correspond lie
	/// on the edges defined by (0,1), (1,2), (2,0), (3,4), (4,5), (5,3).
	/// The Edges (0,3), (1,4), (2,5) don't have midedge nodes.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkQuadraticEdge vtkQuadraticTriangle vtkQuadraticTetra
	/// vtkQuadraticHexahedron vtkQuadraticQuad vtkQuadraticPyramid
	///
	/// @par Thanks:
	/// Thanks to Soeren Gebbert who developed this class and
	/// integrated it into VTK 5.0.
	/// </seealso>
	// Token: 0x02000AAE RID: 2734
	public class vtkQuadraticLinearWedge : vtkNonLinearCell
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601CBC4 RID: 117700 RVA: 0x00286C79 File Offset: 0x00284E79
		static vtkQuadraticLinearWedge()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkQuadraticLinearWedge.MRClassNameKey, Type.GetType("Kitware.VTK.vtkQuadraticLinearWedge"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601CBC5 RID: 117701 RVA: 0x00286CA1 File Offset: 0x00284EA1
		public vtkQuadraticLinearWedge(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601CBC6 RID: 117702
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticLinearWedge_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CBC7 RID: 117703 RVA: 0x00286CB0 File Offset: 0x00284EB0
		public new static vtkQuadraticLinearWedge New()
		{
			vtkQuadraticLinearWedge result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadraticLinearWedge.vtkQuadraticLinearWedge_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuadraticLinearWedge)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CBC8 RID: 117704 RVA: 0x00286D04 File Offset: 0x00284F04
		public vtkQuadraticLinearWedge() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkQuadraticLinearWedge.vtkQuadraticLinearWedge_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601CBC9 RID: 117705 RVA: 0x00286D48 File Offset: 0x00284F48
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601CBCA RID: 117706
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticLinearWedge_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CBCB RID: 117707 RVA: 0x00286D54 File Offset: 0x00284F54
		public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
		{
			return vtkQuadraticLinearWedge.vtkQuadraticLinearWedge_CellBoundary_01(base.GetCppThis(), subId, pcoords, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601CBCC RID: 117708
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticLinearWedge_Clip_02(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef tetras, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

		/// <summary>
		/// Clip this quadratic linear wedge using scalar value provided. Like
		/// contouring, except that it cuts the hex to produce linear
		/// tetrahedron.
		/// </summary>
		// Token: 0x0601CBCD RID: 117709 RVA: 0x00286D8C File Offset: 0x00284F8C
		public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray tetras, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
		{
			vtkQuadraticLinearWedge.vtkQuadraticLinearWedge_Clip_02(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (tetras == null) ? default(HandleRef) : tetras.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis(), insideOut);
		}

		// Token: 0x0601CBCE RID: 117710
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticLinearWedge_Contour_03(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

		/// <summary>
		/// The quadratic linear wedge is split into 4 linear wedges,
		/// each of them is contoured by a provided scalar value
		/// </summary>
		// Token: 0x0601CBCF RID: 117711 RVA: 0x00286E48 File Offset: 0x00285048
		public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
		{
			vtkQuadraticLinearWedge.vtkQuadraticLinearWedge_Contour_03(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis());
		}

		// Token: 0x0601CBD0 RID: 117712
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticLinearWedge_Derivatives_04(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

		/// <summary>
		/// The quadratic linear wedge is split into 4 linear wedges,
		/// each of them is contoured by a provided scalar value
		/// </summary>
		// Token: 0x0601CBD1 RID: 117713 RVA: 0x00286F30 File Offset: 0x00285130
		public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
		{
			vtkQuadraticLinearWedge.vtkQuadraticLinearWedge_Derivatives_04(base.GetCppThis(), subId, pcoords, values, dim, derivs);
		}

		// Token: 0x0601CBD2 RID: 117714
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticLinearWedge_EvaluateLocation_05(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

		/// <summary>
		/// The quadratic linear wedge is split into 4 linear wedges,
		/// each of them is contoured by a provided scalar value
		/// </summary>
		// Token: 0x0601CBD3 RID: 117715 RVA: 0x00286F46 File Offset: 0x00285146
		public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
		{
			vtkQuadraticLinearWedge.vtkQuadraticLinearWedge_EvaluateLocation_05(base.GetCppThis(), ref subId, pcoords, x, weights);
		}

		// Token: 0x0601CBD4 RID: 117716
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticLinearWedge_EvaluatePosition_06(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

		/// <summary>
		/// The quadratic linear wedge is split into 4 linear wedges,
		/// each of them is contoured by a provided scalar value
		/// </summary>
		// Token: 0x0601CBD5 RID: 117717 RVA: 0x00286F5C File Offset: 0x0028515C
		public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
		{
			return vtkQuadraticLinearWedge.vtkQuadraticLinearWedge_EvaluatePosition_06(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
		}

		// Token: 0x0601CBD6 RID: 117718
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticLinearWedge_GetCellDimension_07(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CBD7 RID: 117719 RVA: 0x00286F84 File Offset: 0x00285184
		public override int GetCellDimension()
		{
			return vtkQuadraticLinearWedge.vtkQuadraticLinearWedge_GetCellDimension_07(base.GetCppThis());
		}

		// Token: 0x0601CBD8 RID: 117720
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticLinearWedge_GetCellType_08(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CBD9 RID: 117721 RVA: 0x00286FA4 File Offset: 0x002851A4
		public override int GetCellType()
		{
			return vtkQuadraticLinearWedge.vtkQuadraticLinearWedge_GetCellType_08(base.GetCppThis());
		}

		// Token: 0x0601CBDA RID: 117722
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticLinearWedge_GetEdge_09(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CBDB RID: 117723 RVA: 0x00286FC4 File Offset: 0x002851C4
		public override vtkCell GetEdge(int edgeId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadraticLinearWedge.vtkQuadraticLinearWedge_GetEdge_09(base.GetCppThis(), edgeId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601CBDC RID: 117724
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticLinearWedge_GetEdgeArray_10(long edgeId);

		/// <summary>
		/// Return the ids of the vertices defining edge/face (`edgeId`/`faceId').
		/// Ids are related to the cell, not to the dataset.
		///
		/// @note The return type changed. It used to be int*, it is now const vtkIdType*.
		/// This is so ids are unified between vtkCell and vtkPoints.
		/// </summary>
		// Token: 0x0601CBDD RID: 117725 RVA: 0x00287034 File Offset: 0x00285234
		public static IntPtr GetEdgeArray(long edgeId)
		{
			return vtkQuadraticLinearWedge.vtkQuadraticLinearWedge_GetEdgeArray_10(edgeId);
		}

		// Token: 0x0601CBDE RID: 117726
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticLinearWedge_GetFace_11(HandleRef pThis, int faceId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CBDF RID: 117727 RVA: 0x00287050 File Offset: 0x00285250
		public override vtkCell GetFace(int faceId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadraticLinearWedge.vtkQuadraticLinearWedge_GetFace_11(base.GetCppThis(), faceId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601CBE0 RID: 117728
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticLinearWedge_GetFaceArray_12(long faceId);

		/// <summary>
		/// Return the ids of the vertices defining edge/face (`edgeId`/`faceId').
		/// Ids are related to the cell, not to the dataset.
		///
		/// @note The return type changed. It used to be int*, it is now const vtkIdType*.
		/// This is so ids are unified between vtkCell and vtkPoints.
		/// </summary>
		// Token: 0x0601CBE1 RID: 117729 RVA: 0x002870C0 File Offset: 0x002852C0
		public static IntPtr GetFaceArray(long faceId)
		{
			return vtkQuadraticLinearWedge.vtkQuadraticLinearWedge_GetFaceArray_12(faceId);
		}

		// Token: 0x0601CBE2 RID: 117730
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticLinearWedge_GetNumberOfEdges_13(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CBE3 RID: 117731 RVA: 0x002870DC File Offset: 0x002852DC
		public override int GetNumberOfEdges()
		{
			return vtkQuadraticLinearWedge.vtkQuadraticLinearWedge_GetNumberOfEdges_13(base.GetCppThis());
		}

		// Token: 0x0601CBE4 RID: 117732
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticLinearWedge_GetNumberOfFaces_14(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CBE5 RID: 117733 RVA: 0x002870FC File Offset: 0x002852FC
		public override int GetNumberOfFaces()
		{
			return vtkQuadraticLinearWedge.vtkQuadraticLinearWedge_GetNumberOfFaces_14(base.GetCppThis());
		}

		// Token: 0x0601CBE6 RID: 117734
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkQuadraticLinearWedge_GetNumberOfGenerationsFromBase_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CBE7 RID: 117735 RVA: 0x0028711C File Offset: 0x0028531C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkQuadraticLinearWedge.vtkQuadraticLinearWedge_GetNumberOfGenerationsFromBase_15(base.GetCppThis(), type);
		}

		// Token: 0x0601CBE8 RID: 117736
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkQuadraticLinearWedge_GetNumberOfGenerationsFromBaseType_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CBE9 RID: 117737 RVA: 0x0028713C File Offset: 0x0028533C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkQuadraticLinearWedge.vtkQuadraticLinearWedge_GetNumberOfGenerationsFromBaseType_16(type);
		}

		// Token: 0x0601CBEA RID: 117738
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticLinearWedge_GetParametricCenter_17(HandleRef pThis, IntPtr pcoords);

		/// <summary>
		/// Return the center of the quadratic linear wedge in parametric coordinates.
		/// </summary>
		// Token: 0x0601CBEB RID: 117739 RVA: 0x00287158 File Offset: 0x00285358
		public override int GetParametricCenter(IntPtr pcoords)
		{
			return vtkQuadraticLinearWedge.vtkQuadraticLinearWedge_GetParametricCenter_17(base.GetCppThis(), pcoords);
		}

		// Token: 0x0601CBEC RID: 117740
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticLinearWedge_GetParametricCoords_18(HandleRef pThis);

		/// <summary>
		/// The quadratic linear wedge is split into 4 linear wedges,
		/// each of them is contoured by a provided scalar value
		/// </summary>
		// Token: 0x0601CBED RID: 117741 RVA: 0x00287178 File Offset: 0x00285378
		public override IntPtr GetParametricCoords()
		{
			return vtkQuadraticLinearWedge.vtkQuadraticLinearWedge_GetParametricCoords_18(base.GetCppThis());
		}

		// Token: 0x0601CBEE RID: 117742
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticLinearWedge_InterpolateDerivs_19(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601CBEF RID: 117743 RVA: 0x00287197 File Offset: 0x00285397
		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkQuadraticLinearWedge.vtkQuadraticLinearWedge_InterpolateDerivs_19(base.GetCppThis(), pcoords, derivs);
		}

		// Token: 0x0601CBF0 RID: 117744
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticLinearWedge_InterpolateFunctions_20(HandleRef pThis, IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601CBF1 RID: 117745 RVA: 0x002871A8 File Offset: 0x002853A8
		public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkQuadraticLinearWedge.vtkQuadraticLinearWedge_InterpolateFunctions_20(base.GetCppThis(), pcoords, weights);
		}

		// Token: 0x0601CBF2 RID: 117746
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticLinearWedge_InterpolationDerivs_21(IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Return the center of the quadratic linear wedge in parametric coordinates.
		/// </summary>
		// Token: 0x0601CBF3 RID: 117747 RVA: 0x002871B9 File Offset: 0x002853B9
		public static void InterpolationDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkQuadraticLinearWedge.vtkQuadraticLinearWedge_InterpolationDerivs_21(pcoords, derivs);
		}

		// Token: 0x0601CBF4 RID: 117748
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticLinearWedge_InterpolationFunctions_22(IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Return the center of the quadratic linear wedge in parametric coordinates.
		/// </summary>
		// Token: 0x0601CBF5 RID: 117749 RVA: 0x002871C4 File Offset: 0x002853C4
		public static void InterpolationFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkQuadraticLinearWedge.vtkQuadraticLinearWedge_InterpolationFunctions_22(pcoords, weights);
		}

		// Token: 0x0601CBF6 RID: 117750
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticLinearWedge_IntersectWithLine_23(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		/// <summary>
		/// Line-edge intersection. Intersection has to occur within [0,1] parametric
		/// coordinates and with specified tolerance.
		/// </summary>
		// Token: 0x0601CBF7 RID: 117751 RVA: 0x002871D0 File Offset: 0x002853D0
		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkQuadraticLinearWedge.vtkQuadraticLinearWedge_IntersectWithLine_23(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		// Token: 0x0601CBF8 RID: 117752
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticLinearWedge_IsA_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CBF9 RID: 117753 RVA: 0x002871FC File Offset: 0x002853FC
		public override int IsA(string type)
		{
			return vtkQuadraticLinearWedge.vtkQuadraticLinearWedge_IsA_24(base.GetCppThis(), type);
		}

		// Token: 0x0601CBFA RID: 117754
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticLinearWedge_IsTypeOf_25([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CBFB RID: 117755 RVA: 0x0028721C File Offset: 0x0028541C
		public new static int IsTypeOf(string type)
		{
			return vtkQuadraticLinearWedge.vtkQuadraticLinearWedge_IsTypeOf_25(type);
		}

		// Token: 0x0601CBFC RID: 117756
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticLinearWedge_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CBFD RID: 117757 RVA: 0x00287238 File Offset: 0x00285438
		public new vtkQuadraticLinearWedge NewInstance()
		{
			vtkQuadraticLinearWedge result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadraticLinearWedge.vtkQuadraticLinearWedge_NewInstance_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuadraticLinearWedge)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601CBFE RID: 117758
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticLinearWedge_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CBFF RID: 117759 RVA: 0x00287294 File Offset: 0x00285494
		public new static vtkQuadraticLinearWedge SafeDownCast(vtkObjectBase o)
		{
			vtkQuadraticLinearWedge vtkQuadraticLinearWedge = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadraticLinearWedge.vtkQuadraticLinearWedge_SafeDownCast_28((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkQuadraticLinearWedge = (vtkQuadraticLinearWedge)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkQuadraticLinearWedge.Register(null);
				}
			}
			return vtkQuadraticLinearWedge;
		}

		// Token: 0x0601CC00 RID: 117760
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticLinearWedge_TriangulateLocalIds_29(HandleRef pThis, int index, HandleRef ptIds);

		/// <summary>
		/// The quadratic linear wedge is split into 4 linear wedges,
		/// each of them is contoured by a provided scalar value
		/// </summary>
		// Token: 0x0601CC01 RID: 117761 RVA: 0x00287314 File Offset: 0x00285514
		public override int TriangulateLocalIds(int index, vtkIdList ptIds)
		{
			return vtkQuadraticLinearWedge.vtkQuadraticLinearWedge_TriangulateLocalIds_29(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E65 RID: 7781
		public new const string MRFullTypeName = "Kitware.VTK.vtkQuadraticLinearWedge";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E66 RID: 7782
		public new static readonly string MRClassNameKey = "class vtkQuadraticLinearWedge";
	}
}
