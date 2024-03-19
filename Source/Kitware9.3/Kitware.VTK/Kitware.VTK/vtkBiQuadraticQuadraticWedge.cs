using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBiQuadraticQuadraticWedge
	/// </summary>
	/// <remarks>
	///    cell represents a parabolic, 18-node isoparametric wedge
	///
	/// vtkBiQuadraticQuadraticWedge is a concrete implementation of vtkNonLinearCell to
	/// represent a three-dimensional, 18-node isoparametric biquadratic
	/// wedge. The interpolation is the standard finite element,
	/// biquadratic-quadratic isoparametric shape function plus the linear functions.
	/// The cell includes a mid-edge node. The
	/// ordering of the 18 points defining the cell is point ids (0-5,6-15, 16-18)
	/// where point ids 0-5 are the six corner vertices of the wedge; followed by
	/// nine midedge nodes (6-15) and 3 center-face nodes. Note that these midedge
	/// nodes correspond lie
	/// on the edges defined by (0,1), (1,2), (2,0), (3,4), (4,5), (5,3), (0,3),
	/// (1,4), (2,5), and the center-face nodes are laying in quads 16-(0,1,4,3),
	/// 17-(1,2,5,4) and (2,0,3,5).
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
	// Token: 0x02000A0F RID: 2575
	public class vtkBiQuadraticQuadraticWedge : vtkNonLinearCell
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601AC87 RID: 109703 RVA: 0x00254EE9 File Offset: 0x002530E9
		static vtkBiQuadraticQuadraticWedge()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBiQuadraticQuadraticWedge.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBiQuadraticQuadraticWedge"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601AC88 RID: 109704 RVA: 0x00254F11 File Offset: 0x00253111
		public vtkBiQuadraticQuadraticWedge(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601AC89 RID: 109705
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiQuadraticQuadraticWedge_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AC8A RID: 109706 RVA: 0x00254F20 File Offset: 0x00253120
		public new static vtkBiQuadraticQuadraticWedge New()
		{
			vtkBiQuadraticQuadraticWedge result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBiQuadraticQuadraticWedge)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AC8B RID: 109707 RVA: 0x00254F74 File Offset: 0x00253174
		public vtkBiQuadraticQuadraticWedge() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601AC8C RID: 109708 RVA: 0x00254FB8 File Offset: 0x002531B8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601AC8D RID: 109709
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiQuadraticQuadraticWedge_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601AC8E RID: 109710 RVA: 0x00254FC4 File Offset: 0x002531C4
		public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
		{
			return vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_CellBoundary_01(base.GetCppThis(), subId, pcoords, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601AC8F RID: 109711
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiQuadraticQuadraticWedge_Clip_02(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef tetras, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

		/// <summary>
		/// Clip this quadratic Wedge using scalar value provided. Like
		/// contouring, except that it cuts the hex to produce linear
		/// tetrahedron.
		/// </summary>
		// Token: 0x0601AC90 RID: 109712 RVA: 0x00254FFC File Offset: 0x002531FC
		public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray tetras, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
		{
			vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_Clip_02(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (tetras == null) ? default(HandleRef) : tetras.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis(), insideOut);
		}

		// Token: 0x0601AC91 RID: 109713
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiQuadraticQuadraticWedge_Contour_03(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601AC92 RID: 109714 RVA: 0x002550B8 File Offset: 0x002532B8
		public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
		{
			vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_Contour_03(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis());
		}

		// Token: 0x0601AC93 RID: 109715
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiQuadraticQuadraticWedge_Derivatives_04(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601AC94 RID: 109716 RVA: 0x002551A0 File Offset: 0x002533A0
		public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
		{
			vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_Derivatives_04(base.GetCppThis(), subId, pcoords, values, dim, derivs);
		}

		// Token: 0x0601AC95 RID: 109717
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiQuadraticQuadraticWedge_EvaluateLocation_05(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601AC96 RID: 109718 RVA: 0x002551B6 File Offset: 0x002533B6
		public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
		{
			vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_EvaluateLocation_05(base.GetCppThis(), ref subId, pcoords, x, weights);
		}

		// Token: 0x0601AC97 RID: 109719
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiQuadraticQuadraticWedge_EvaluatePosition_06(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601AC98 RID: 109720 RVA: 0x002551CC File Offset: 0x002533CC
		public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
		{
			return vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_EvaluatePosition_06(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
		}

		// Token: 0x0601AC99 RID: 109721
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiQuadraticQuadraticWedge_GetCellDimension_07(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601AC9A RID: 109722 RVA: 0x002551F4 File Offset: 0x002533F4
		public override int GetCellDimension()
		{
			return vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_GetCellDimension_07(base.GetCppThis());
		}

		// Token: 0x0601AC9B RID: 109723
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiQuadraticQuadraticWedge_GetCellType_08(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601AC9C RID: 109724 RVA: 0x00255214 File Offset: 0x00253414
		public override int GetCellType()
		{
			return vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_GetCellType_08(base.GetCppThis());
		}

		// Token: 0x0601AC9D RID: 109725
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiQuadraticQuadraticWedge_GetEdge_09(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601AC9E RID: 109726 RVA: 0x00255234 File Offset: 0x00253434
		public override vtkCell GetEdge(int edgeId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_GetEdge_09(base.GetCppThis(), edgeId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601AC9F RID: 109727
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiQuadraticQuadraticWedge_GetEdgeArray_10(long edgeId);

		/// <summary>
		/// Return the ids of the vertices defining edge/face (`edgeId`/`faceId').
		/// Ids are related to the cell, not to the dataset.
		///
		/// @note The return type changed. It used to be int*, it is now const vtkIdType*.
		/// This is so ids are unified between vtkCell and vtkPoints.
		/// </summary>
		// Token: 0x0601ACA0 RID: 109728 RVA: 0x002552A4 File Offset: 0x002534A4
		public static IntPtr GetEdgeArray(long edgeId)
		{
			return vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_GetEdgeArray_10(edgeId);
		}

		// Token: 0x0601ACA1 RID: 109729
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiQuadraticQuadraticWedge_GetFace_11(HandleRef pThis, int faceId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601ACA2 RID: 109730 RVA: 0x002552C0 File Offset: 0x002534C0
		public override vtkCell GetFace(int faceId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_GetFace_11(base.GetCppThis(), faceId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601ACA3 RID: 109731
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiQuadraticQuadraticWedge_GetFaceArray_12(long faceId);

		/// <summary>
		/// Return the ids of the vertices defining edge/face (`edgeId`/`faceId').
		/// Ids are related to the cell, not to the dataset.
		///
		/// @note The return type changed. It used to be int*, it is now const vtkIdType*.
		/// This is so ids are unified between vtkCell and vtkPoints.
		/// </summary>
		// Token: 0x0601ACA4 RID: 109732 RVA: 0x00255330 File Offset: 0x00253530
		public static IntPtr GetFaceArray(long faceId)
		{
			return vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_GetFaceArray_12(faceId);
		}

		// Token: 0x0601ACA5 RID: 109733
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiQuadraticQuadraticWedge_GetNumberOfEdges_13(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601ACA6 RID: 109734 RVA: 0x0025534C File Offset: 0x0025354C
		public override int GetNumberOfEdges()
		{
			return vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_GetNumberOfEdges_13(base.GetCppThis());
		}

		// Token: 0x0601ACA7 RID: 109735
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiQuadraticQuadraticWedge_GetNumberOfFaces_14(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601ACA8 RID: 109736 RVA: 0x0025536C File Offset: 0x0025356C
		public override int GetNumberOfFaces()
		{
			return vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_GetNumberOfFaces_14(base.GetCppThis());
		}

		// Token: 0x0601ACA9 RID: 109737
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBiQuadraticQuadraticWedge_GetNumberOfGenerationsFromBase_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ACAA RID: 109738 RVA: 0x0025538C File Offset: 0x0025358C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_GetNumberOfGenerationsFromBase_15(base.GetCppThis(), type);
		}

		// Token: 0x0601ACAB RID: 109739
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBiQuadraticQuadraticWedge_GetNumberOfGenerationsFromBaseType_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ACAC RID: 109740 RVA: 0x002553AC File Offset: 0x002535AC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_GetNumberOfGenerationsFromBaseType_16(type);
		}

		// Token: 0x0601ACAD RID: 109741
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiQuadraticQuadraticWedge_GetParametricCenter_17(HandleRef pThis, IntPtr pcoords);

		/// <summary>
		/// Return the center of the quadratic wedge in parametric coordinates.
		/// </summary>
		// Token: 0x0601ACAE RID: 109742 RVA: 0x002553C8 File Offset: 0x002535C8
		public override int GetParametricCenter(IntPtr pcoords)
		{
			return vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_GetParametricCenter_17(base.GetCppThis(), pcoords);
		}

		// Token: 0x0601ACAF RID: 109743
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiQuadraticQuadraticWedge_GetParametricCoords_18(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601ACB0 RID: 109744 RVA: 0x002553E8 File Offset: 0x002535E8
		public override IntPtr GetParametricCoords()
		{
			return vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_GetParametricCoords_18(base.GetCppThis());
		}

		// Token: 0x0601ACB1 RID: 109745
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiQuadraticQuadraticWedge_InterpolateDerivs_19(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601ACB2 RID: 109746 RVA: 0x00255407 File Offset: 0x00253607
		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_InterpolateDerivs_19(base.GetCppThis(), pcoords, derivs);
		}

		// Token: 0x0601ACB3 RID: 109747
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiQuadraticQuadraticWedge_InterpolateFunctions_20(HandleRef pThis, IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601ACB4 RID: 109748 RVA: 0x00255418 File Offset: 0x00253618
		public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_InterpolateFunctions_20(base.GetCppThis(), pcoords, weights);
		}

		// Token: 0x0601ACB5 RID: 109749
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiQuadraticQuadraticWedge_InterpolationDerivs_21(IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Return the center of the quadratic wedge in parametric coordinates.
		/// </summary>
		// Token: 0x0601ACB6 RID: 109750 RVA: 0x00255429 File Offset: 0x00253629
		public static void InterpolationDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_InterpolationDerivs_21(pcoords, derivs);
		}

		// Token: 0x0601ACB7 RID: 109751
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiQuadraticQuadraticWedge_InterpolationFunctions_22(IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Return the center of the quadratic wedge in parametric coordinates.
		/// </summary>
		// Token: 0x0601ACB8 RID: 109752 RVA: 0x00255434 File Offset: 0x00253634
		public static void InterpolationFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_InterpolationFunctions_22(pcoords, weights);
		}

		// Token: 0x0601ACB9 RID: 109753
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiQuadraticQuadraticWedge_IntersectWithLine_23(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		/// <summary>
		/// Line-edge intersection. Intersection has to occur within [0,1] parametric
		/// coordinates and with specified tolerance.
		/// </summary>
		// Token: 0x0601ACBA RID: 109754 RVA: 0x00255440 File Offset: 0x00253640
		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_IntersectWithLine_23(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		// Token: 0x0601ACBB RID: 109755
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiQuadraticQuadraticWedge_IsA_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ACBC RID: 109756 RVA: 0x0025546C File Offset: 0x0025366C
		public override int IsA(string type)
		{
			return vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_IsA_24(base.GetCppThis(), type);
		}

		// Token: 0x0601ACBD RID: 109757
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiQuadraticQuadraticWedge_IsTypeOf_25([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ACBE RID: 109758 RVA: 0x0025548C File Offset: 0x0025368C
		public new static int IsTypeOf(string type)
		{
			return vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_IsTypeOf_25(type);
		}

		// Token: 0x0601ACBF RID: 109759
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiQuadraticQuadraticWedge_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ACC0 RID: 109760 RVA: 0x002554A8 File Offset: 0x002536A8
		public new vtkBiQuadraticQuadraticWedge NewInstance()
		{
			vtkBiQuadraticQuadraticWedge result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_NewInstance_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBiQuadraticQuadraticWedge)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601ACC1 RID: 109761
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiQuadraticQuadraticWedge_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ACC2 RID: 109762 RVA: 0x00255504 File Offset: 0x00253704
		public new static vtkBiQuadraticQuadraticWedge SafeDownCast(vtkObjectBase o)
		{
			vtkBiQuadraticQuadraticWedge vtkBiQuadraticQuadraticWedge = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_SafeDownCast_28((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBiQuadraticQuadraticWedge = (vtkBiQuadraticQuadraticWedge)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBiQuadraticQuadraticWedge.Register(null);
				}
			}
			return vtkBiQuadraticQuadraticWedge;
		}

		// Token: 0x0601ACC3 RID: 109763
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiQuadraticQuadraticWedge_TriangulateLocalIds_29(HandleRef pThis, int index, HandleRef ptIds);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601ACC4 RID: 109764 RVA: 0x00255584 File Offset: 0x00253784
		public override int TriangulateLocalIds(int index, vtkIdList ptIds)
		{
			return vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_TriangulateLocalIds_29(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CF6 RID: 7414
		public new const string MRFullTypeName = "Kitware.VTK.vtkBiQuadraticQuadraticWedge";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CF7 RID: 7415
		public new static readonly string MRClassNameKey = "class vtkBiQuadraticQuadraticWedge";
	}
}
