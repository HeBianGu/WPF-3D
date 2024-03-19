using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTriQuadraticHexahedron
	/// </summary>
	/// <remarks>
	///    cell represents a parabolic, 27-node isoparametric hexahedron
	///
	/// vtkTriQuadraticHexahedron is a concrete implementation of vtkNonLinearCell to
	/// represent a three-dimensional, 27-node isoparametric triquadratic
	/// hexahedron. The interpolation is the standard finite element, triquadratic
	/// isoparametric shape function. The cell includes 8 edge nodes, 12 mid-edge nodes,
	/// 6 mid-face nodes and one mid-volume node. The ordering of the 27 points defining the
	/// cell is point ids (0-7,8-19, 20-25, 26)
	/// where point ids 0-7 are the eight corner vertices of the cube; followed by
	/// twelve midedge nodes (8-19); followed by 6 mid-face nodes (20-25) and the last node (26)
	/// is the mid-volume node. Note that these midedge nodes correspond lie
	/// on the edges defined by (0,1), (1,2), (2,3), (3,0), (4,5), (5,6), (6,7),
	/// (7,4), (0,4), (1,5), (2,6), (3,7). The mid-surface nodes lies on the faces
	/// defined by (first edge nodes id's, than mid-edge nodes id's):
	/// (0,1,5,4;8,17,12,16), (1,2,6,5;9,18,13,17), (2,3,7,6,10,19,14,18),
	/// (3,0,4,7;11,16,15,19), (0,1,2,3;8,9,10,11), (4,5,6,7;12,13,14,15).
	/// The last point lies in the center of the cell (0,1,2,3,4,5,6,7).
	///
	/// \verbatim
	///
	/// top
	///  7--14--6
	///  |      |
	/// 15  25  13
	///  |      |
	///  4--12--5
	///
	///  middle
	/// 19--23--18
	///  |      |
	/// 20  26  21
	///  |      |
	/// 16--22--17
	///
	/// bottom
	///  3--10--2
	///  |      |
	/// 11  24  9
	///  |      |
	///  0-- 8--1
	///
	/// \endverbatim
	///
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkQuadraticEdge vtkQuadraticTriangle vtkQuadraticTetra
	/// vtkQuadraticQuad vtkQuadraticPyramid vtkQuadraticWedge
	/// vtkBiQuadraticQuad
	///
	/// @par Thanks:
	/// Thanks to Soeren Gebbert who developed this class and
	/// integrated it into VTK 5.0.
	/// </seealso>
	// Token: 0x02000AD9 RID: 2777
	public class vtkTriQuadraticHexahedron : vtkNonLinearCell
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D3C4 RID: 119748 RVA: 0x00293B77 File Offset: 0x00291D77
		static vtkTriQuadraticHexahedron()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTriQuadraticHexahedron.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTriQuadraticHexahedron"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D3C5 RID: 119749 RVA: 0x00293B9F File Offset: 0x00291D9F
		public vtkTriQuadraticHexahedron(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601D3C6 RID: 119750
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTriQuadraticHexahedron_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D3C7 RID: 119751 RVA: 0x00293BB0 File Offset: 0x00291DB0
		public new static vtkTriQuadraticHexahedron New()
		{
			vtkTriQuadraticHexahedron result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTriQuadraticHexahedron)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D3C8 RID: 119752 RVA: 0x00293C04 File Offset: 0x00291E04
		public vtkTriQuadraticHexahedron() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D3C9 RID: 119753 RVA: 0x00293C48 File Offset: 0x00291E48
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D3CA RID: 119754
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriQuadraticHexahedron_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601D3CB RID: 119755 RVA: 0x00293C54 File Offset: 0x00291E54
		public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
		{
			return vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_CellBoundary_01(base.GetCppThis(), subId, pcoords, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601D3CC RID: 119756
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTriQuadraticHexahedron_Clip_02(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef tetras, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

		/// <summary>
		/// Clip this triquadratic hexahedron using scalar value provided. Like
		/// contouring, except that it cuts the hex to produce linear
		/// tetrahedron.
		/// </summary>
		// Token: 0x0601D3CD RID: 119757 RVA: 0x00293C8C File Offset: 0x00291E8C
		public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray tetras, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
		{
			vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_Clip_02(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (tetras == null) ? default(HandleRef) : tetras.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis(), insideOut);
		}

		// Token: 0x0601D3CE RID: 119758
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTriQuadraticHexahedron_Contour_03(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601D3CF RID: 119759 RVA: 0x00293D48 File Offset: 0x00291F48
		public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
		{
			vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_Contour_03(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis());
		}

		// Token: 0x0601D3D0 RID: 119760
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTriQuadraticHexahedron_Derivatives_04(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601D3D1 RID: 119761 RVA: 0x00293E30 File Offset: 0x00292030
		public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
		{
			vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_Derivatives_04(base.GetCppThis(), subId, pcoords, values, dim, derivs);
		}

		// Token: 0x0601D3D2 RID: 119762
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTriQuadraticHexahedron_EvaluateLocation_05(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601D3D3 RID: 119763 RVA: 0x00293E46 File Offset: 0x00292046
		public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
		{
			vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_EvaluateLocation_05(base.GetCppThis(), ref subId, pcoords, x, weights);
		}

		// Token: 0x0601D3D4 RID: 119764
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriQuadraticHexahedron_EvaluatePosition_06(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601D3D5 RID: 119765 RVA: 0x00293E5C File Offset: 0x0029205C
		public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
		{
			return vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_EvaluatePosition_06(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
		}

		// Token: 0x0601D3D6 RID: 119766
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriQuadraticHexahedron_GetCellDimension_07(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601D3D7 RID: 119767 RVA: 0x00293E84 File Offset: 0x00292084
		public override int GetCellDimension()
		{
			return vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_GetCellDimension_07(base.GetCppThis());
		}

		// Token: 0x0601D3D8 RID: 119768
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriQuadraticHexahedron_GetCellType_08(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601D3D9 RID: 119769 RVA: 0x00293EA4 File Offset: 0x002920A4
		public override int GetCellType()
		{
			return vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_GetCellType_08(base.GetCppThis());
		}

		// Token: 0x0601D3DA RID: 119770
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTriQuadraticHexahedron_GetEdge_09(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601D3DB RID: 119771 RVA: 0x00293EC4 File Offset: 0x002920C4
		public override vtkCell GetEdge(int arg0)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_GetEdge_09(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601D3DC RID: 119772
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTriQuadraticHexahedron_GetEdgeArray_10(long edgeId);

		/// <summary>
		/// Return the ids of the vertices defining edge/face (`edgeId`/`faceId').
		/// Ids are related to the cell, not to the dataset.
		///
		/// @note The return type changed. It used to be int*, it is now const vtkIdType*.
		/// This is so ids are unified between vtkCell and vtkPoints.
		/// </summary>
		// Token: 0x0601D3DD RID: 119773 RVA: 0x00293F34 File Offset: 0x00292134
		public static IntPtr GetEdgeArray(long edgeId)
		{
			return vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_GetEdgeArray_10(edgeId);
		}

		// Token: 0x0601D3DE RID: 119774
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTriQuadraticHexahedron_GetFace_11(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601D3DF RID: 119775 RVA: 0x00293F50 File Offset: 0x00292150
		public override vtkCell GetFace(int arg0)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_GetFace_11(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601D3E0 RID: 119776
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTriQuadraticHexahedron_GetFaceArray_12(long faceId);

		/// <summary>
		/// Return the ids of the vertices defining edge/face (`edgeId`/`faceId').
		/// Ids are related to the cell, not to the dataset.
		///
		/// @note The return type changed. It used to be int*, it is now const vtkIdType*.
		/// This is so ids are unified between vtkCell and vtkPoints.
		/// </summary>
		// Token: 0x0601D3E1 RID: 119777 RVA: 0x00293FC0 File Offset: 0x002921C0
		public static IntPtr GetFaceArray(long faceId)
		{
			return vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_GetFaceArray_12(faceId);
		}

		// Token: 0x0601D3E2 RID: 119778
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriQuadraticHexahedron_GetNumberOfEdges_13(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601D3E3 RID: 119779 RVA: 0x00293FDC File Offset: 0x002921DC
		public override int GetNumberOfEdges()
		{
			return vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_GetNumberOfEdges_13(base.GetCppThis());
		}

		// Token: 0x0601D3E4 RID: 119780
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriQuadraticHexahedron_GetNumberOfFaces_14(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601D3E5 RID: 119781 RVA: 0x00293FFC File Offset: 0x002921FC
		public override int GetNumberOfFaces()
		{
			return vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_GetNumberOfFaces_14(base.GetCppThis());
		}

		// Token: 0x0601D3E6 RID: 119782
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTriQuadraticHexahedron_GetNumberOfGenerationsFromBase_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D3E7 RID: 119783 RVA: 0x0029401C File Offset: 0x0029221C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_GetNumberOfGenerationsFromBase_15(base.GetCppThis(), type);
		}

		// Token: 0x0601D3E8 RID: 119784
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTriQuadraticHexahedron_GetNumberOfGenerationsFromBaseType_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D3E9 RID: 119785 RVA: 0x0029403C File Offset: 0x0029223C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_GetNumberOfGenerationsFromBaseType_16(type);
		}

		// Token: 0x0601D3EA RID: 119786
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTriQuadraticHexahedron_GetParametricCoords_17(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601D3EB RID: 119787 RVA: 0x00294058 File Offset: 0x00292258
		public override IntPtr GetParametricCoords()
		{
			return vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_GetParametricCoords_17(base.GetCppThis());
		}

		// Token: 0x0601D3EC RID: 119788
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTriQuadraticHexahedron_InterpolateDerivs_18(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601D3ED RID: 119789 RVA: 0x00294077 File Offset: 0x00292277
		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_InterpolateDerivs_18(base.GetCppThis(), pcoords, derivs);
		}

		// Token: 0x0601D3EE RID: 119790
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTriQuadraticHexahedron_InterpolateFunctions_19(HandleRef pThis, IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601D3EF RID: 119791 RVA: 0x00294088 File Offset: 0x00292288
		public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_InterpolateFunctions_19(base.GetCppThis(), pcoords, weights);
		}

		// Token: 0x0601D3F0 RID: 119792
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTriQuadraticHexahedron_InterpolationDerivs_20(IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Line-edge intersection. Intersection has to occur within [0,1] parametric
		/// coordinates and with specified tolerance.
		/// </summary>
		// Token: 0x0601D3F1 RID: 119793 RVA: 0x00294099 File Offset: 0x00292299
		public static void InterpolationDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_InterpolationDerivs_20(pcoords, derivs);
		}

		// Token: 0x0601D3F2 RID: 119794
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTriQuadraticHexahedron_InterpolationFunctions_21(IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Line-edge intersection. Intersection has to occur within [0,1] parametric
		/// coordinates and with specified tolerance.
		/// </summary>
		// Token: 0x0601D3F3 RID: 119795 RVA: 0x002940A4 File Offset: 0x002922A4
		public static void InterpolationFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_InterpolationFunctions_21(pcoords, weights);
		}

		// Token: 0x0601D3F4 RID: 119796
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriQuadraticHexahedron_IntersectWithLine_22(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		/// <summary>
		/// Line-edge intersection. Intersection has to occur within [0,1] parametric
		/// coordinates and with specified tolerance.
		/// </summary>
		// Token: 0x0601D3F5 RID: 119797 RVA: 0x002940B0 File Offset: 0x002922B0
		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_IntersectWithLine_22(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		// Token: 0x0601D3F6 RID: 119798
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriQuadraticHexahedron_IsA_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D3F7 RID: 119799 RVA: 0x002940DC File Offset: 0x002922DC
		public override int IsA(string type)
		{
			return vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_IsA_23(base.GetCppThis(), type);
		}

		// Token: 0x0601D3F8 RID: 119800
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriQuadraticHexahedron_IsTypeOf_24([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D3F9 RID: 119801 RVA: 0x002940FC File Offset: 0x002922FC
		public new static int IsTypeOf(string type)
		{
			return vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_IsTypeOf_24(type);
		}

		// Token: 0x0601D3FA RID: 119802
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTriQuadraticHexahedron_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D3FB RID: 119803 RVA: 0x00294118 File Offset: 0x00292318
		public new vtkTriQuadraticHexahedron NewInstance()
		{
			vtkTriQuadraticHexahedron result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_NewInstance_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTriQuadraticHexahedron)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601D3FC RID: 119804
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTriQuadraticHexahedron_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D3FD RID: 119805 RVA: 0x00294174 File Offset: 0x00292374
		public new static vtkTriQuadraticHexahedron SafeDownCast(vtkObjectBase o)
		{
			vtkTriQuadraticHexahedron vtkTriQuadraticHexahedron = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_SafeDownCast_27((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTriQuadraticHexahedron = (vtkTriQuadraticHexahedron)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTriQuadraticHexahedron.Register(null);
				}
			}
			return vtkTriQuadraticHexahedron;
		}

		// Token: 0x0601D3FE RID: 119806
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriQuadraticHexahedron_TriangulateLocalIds_28(HandleRef pThis, int index, HandleRef ptIds);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601D3FF RID: 119807 RVA: 0x002941F4 File Offset: 0x002923F4
		public override int TriangulateLocalIds(int index, vtkIdList ptIds)
		{
			return vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_TriangulateLocalIds_28(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001ED9 RID: 7897
		public new const string MRFullTypeName = "Kitware.VTK.vtkTriQuadraticHexahedron";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EDA RID: 7898
		public new static readonly string MRClassNameKey = "class vtkTriQuadraticHexahedron";
	}
}
