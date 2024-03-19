using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkQuadraticLinearQuad
	/// </summary>
	/// <remarks>
	///    cell represents a quadratic-linear, 6-node isoparametric quad
	///
	/// vtkQuadraticQuad is a concrete implementation of vtkNonLinearCell to
	/// represent a two-dimensional, 6-node isoparametric quadratic-linear quadrilateral
	/// element. The interpolation is the standard finite element, quadratic-linear
	/// isoparametric shape function. The cell includes a mid-edge node for two
	/// of the four edges. The ordering of the six points defining
	/// the cell are point ids (0-3,4-5) where ids 0-3 define the four corner
	/// vertices of the quad; ids 4-7 define the midedge nodes (0,1) and (2,3) .
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkQuadraticEdge vtkQuadraticTriangle vtkQuadraticTetra vtkQuadraticQuad
	/// vtkQuadraticHexahedron vtkQuadraticWedge vtkQuadraticPyramid
	///
	/// @par Thanks:
	/// Thanks to Soeren Gebbert  who developed this class and
	/// integrated it into VTK 5.0.
	/// </seealso>
	// Token: 0x02000AAD RID: 2733
	public class vtkQuadraticLinearQuad : vtkNonLinearCell
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601CB88 RID: 117640 RVA: 0x002865C5 File Offset: 0x002847C5
		static vtkQuadraticLinearQuad()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkQuadraticLinearQuad.MRClassNameKey, Type.GetType("Kitware.VTK.vtkQuadraticLinearQuad"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601CB89 RID: 117641 RVA: 0x002865ED File Offset: 0x002847ED
		public vtkQuadraticLinearQuad(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601CB8A RID: 117642
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticLinearQuad_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CB8B RID: 117643 RVA: 0x002865FC File Offset: 0x002847FC
		public new static vtkQuadraticLinearQuad New()
		{
			vtkQuadraticLinearQuad result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadraticLinearQuad.vtkQuadraticLinearQuad_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuadraticLinearQuad)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CB8C RID: 117644 RVA: 0x00286650 File Offset: 0x00284850
		public vtkQuadraticLinearQuad() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkQuadraticLinearQuad.vtkQuadraticLinearQuad_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601CB8D RID: 117645 RVA: 0x00286694 File Offset: 0x00284894
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601CB8E RID: 117646
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticLinearQuad_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CB8F RID: 117647 RVA: 0x002866A0 File Offset: 0x002848A0
		public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
		{
			return vtkQuadraticLinearQuad.vtkQuadraticLinearQuad_CellBoundary_01(base.GetCppThis(), subId, pcoords, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601CB90 RID: 117648
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticLinearQuad_Clip_02(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

		/// <summary>
		/// Clip this quadratic linear quad using scalar value provided. Like
		/// contouring, except that it cuts the quad to produce linear triangles.
		/// </summary>
		// Token: 0x0601CB91 RID: 117649 RVA: 0x002866D8 File Offset: 0x002848D8
		public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
		{
			vtkQuadraticLinearQuad.vtkQuadraticLinearQuad_Clip_02(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis(), insideOut);
		}

		// Token: 0x0601CB92 RID: 117650
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticLinearQuad_Contour_03(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CB93 RID: 117651 RVA: 0x00286794 File Offset: 0x00284994
		public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
		{
			vtkQuadraticLinearQuad.vtkQuadraticLinearQuad_Contour_03(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis());
		}

		// Token: 0x0601CB94 RID: 117652
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticLinearQuad_Derivatives_04(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CB95 RID: 117653 RVA: 0x0028687C File Offset: 0x00284A7C
		public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
		{
			vtkQuadraticLinearQuad.vtkQuadraticLinearQuad_Derivatives_04(base.GetCppThis(), subId, pcoords, values, dim, derivs);
		}

		// Token: 0x0601CB96 RID: 117654
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticLinearQuad_EvaluateLocation_05(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CB97 RID: 117655 RVA: 0x00286892 File Offset: 0x00284A92
		public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
		{
			vtkQuadraticLinearQuad.vtkQuadraticLinearQuad_EvaluateLocation_05(base.GetCppThis(), ref subId, pcoords, x, weights);
		}

		// Token: 0x0601CB98 RID: 117656
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticLinearQuad_EvaluatePosition_06(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CB99 RID: 117657 RVA: 0x002868A8 File Offset: 0x00284AA8
		public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
		{
			return vtkQuadraticLinearQuad.vtkQuadraticLinearQuad_EvaluatePosition_06(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
		}

		// Token: 0x0601CB9A RID: 117658
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticLinearQuad_GetCellDimension_07(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CB9B RID: 117659 RVA: 0x002868D0 File Offset: 0x00284AD0
		public override int GetCellDimension()
		{
			return vtkQuadraticLinearQuad.vtkQuadraticLinearQuad_GetCellDimension_07(base.GetCppThis());
		}

		// Token: 0x0601CB9C RID: 117660
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticLinearQuad_GetCellType_08(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CB9D RID: 117661 RVA: 0x002868F0 File Offset: 0x00284AF0
		public override int GetCellType()
		{
			return vtkQuadraticLinearQuad.vtkQuadraticLinearQuad_GetCellType_08(base.GetCppThis());
		}

		// Token: 0x0601CB9E RID: 117662
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticLinearQuad_GetEdge_09(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CB9F RID: 117663 RVA: 0x00286910 File Offset: 0x00284B10
		public override vtkCell GetEdge(int arg0)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadraticLinearQuad.vtkQuadraticLinearQuad_GetEdge_09(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601CBA0 RID: 117664
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticLinearQuad_GetEdgeArray_10(long edgeId);

		/// <summary>
		/// Return the ids of the vertices defining edge (`edgeId`).
		/// Ids are related to the cell, not to the dataset.
		///
		/// @note The return type changed. It used to be int*, it is now const vtkIdType*.
		/// This is so ids are unified between vtkCell and vtkPoints.
		///
		/// @note The return type changed. It used to be int*, it is now const vtkIdType*.
		/// This is so ids are unified between vtkCell and vtkPoints.
		/// </summary>
		// Token: 0x0601CBA1 RID: 117665 RVA: 0x00286980 File Offset: 0x00284B80
		public static IntPtr GetEdgeArray(long edgeId)
		{
			return vtkQuadraticLinearQuad.vtkQuadraticLinearQuad_GetEdgeArray_10(edgeId);
		}

		// Token: 0x0601CBA2 RID: 117666
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticLinearQuad_GetFace_11(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CBA3 RID: 117667 RVA: 0x0028699C File Offset: 0x00284B9C
		public override vtkCell GetFace(int arg0)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadraticLinearQuad.vtkQuadraticLinearQuad_GetFace_11(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601CBA4 RID: 117668
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticLinearQuad_GetNumberOfEdges_12(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CBA5 RID: 117669 RVA: 0x00286A0C File Offset: 0x00284C0C
		public override int GetNumberOfEdges()
		{
			return vtkQuadraticLinearQuad.vtkQuadraticLinearQuad_GetNumberOfEdges_12(base.GetCppThis());
		}

		// Token: 0x0601CBA6 RID: 117670
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticLinearQuad_GetNumberOfFaces_13(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CBA7 RID: 117671 RVA: 0x00286A2C File Offset: 0x00284C2C
		public override int GetNumberOfFaces()
		{
			return vtkQuadraticLinearQuad.vtkQuadraticLinearQuad_GetNumberOfFaces_13(base.GetCppThis());
		}

		// Token: 0x0601CBA8 RID: 117672
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkQuadraticLinearQuad_GetNumberOfGenerationsFromBase_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CBA9 RID: 117673 RVA: 0x00286A4C File Offset: 0x00284C4C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkQuadraticLinearQuad.vtkQuadraticLinearQuad_GetNumberOfGenerationsFromBase_14(base.GetCppThis(), type);
		}

		// Token: 0x0601CBAA RID: 117674
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkQuadraticLinearQuad_GetNumberOfGenerationsFromBaseType_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CBAB RID: 117675 RVA: 0x00286A6C File Offset: 0x00284C6C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkQuadraticLinearQuad.vtkQuadraticLinearQuad_GetNumberOfGenerationsFromBaseType_15(type);
		}

		// Token: 0x0601CBAC RID: 117676
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticLinearQuad_GetParametricCenter_16(HandleRef pThis, IntPtr pcoords);

		/// <summary>
		/// Return the center of the pyramid in parametric coordinates.
		/// </summary>
		// Token: 0x0601CBAD RID: 117677 RVA: 0x00286A88 File Offset: 0x00284C88
		public override int GetParametricCenter(IntPtr pcoords)
		{
			return vtkQuadraticLinearQuad.vtkQuadraticLinearQuad_GetParametricCenter_16(base.GetCppThis(), pcoords);
		}

		// Token: 0x0601CBAE RID: 117678
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticLinearQuad_GetParametricCoords_17(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CBAF RID: 117679 RVA: 0x00286AA8 File Offset: 0x00284CA8
		public override IntPtr GetParametricCoords()
		{
			return vtkQuadraticLinearQuad.vtkQuadraticLinearQuad_GetParametricCoords_17(base.GetCppThis());
		}

		// Token: 0x0601CBB0 RID: 117680
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticLinearQuad_InterpolateDerivs_18(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601CBB1 RID: 117681 RVA: 0x00286AC7 File Offset: 0x00284CC7
		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkQuadraticLinearQuad.vtkQuadraticLinearQuad_InterpolateDerivs_18(base.GetCppThis(), pcoords, derivs);
		}

		// Token: 0x0601CBB2 RID: 117682
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticLinearQuad_InterpolateFunctions_19(HandleRef pThis, IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601CBB3 RID: 117683 RVA: 0x00286AD8 File Offset: 0x00284CD8
		public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkQuadraticLinearQuad.vtkQuadraticLinearQuad_InterpolateFunctions_19(base.GetCppThis(), pcoords, weights);
		}

		// Token: 0x0601CBB4 RID: 117684
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticLinearQuad_InterpolationDerivs_20(IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Return the center of the pyramid in parametric coordinates.
		/// </summary>
		// Token: 0x0601CBB5 RID: 117685 RVA: 0x00286AE9 File Offset: 0x00284CE9
		public static void InterpolationDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkQuadraticLinearQuad.vtkQuadraticLinearQuad_InterpolationDerivs_20(pcoords, derivs);
		}

		// Token: 0x0601CBB6 RID: 117686
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticLinearQuad_InterpolationFunctions_21(IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Return the center of the pyramid in parametric coordinates.
		/// </summary>
		// Token: 0x0601CBB7 RID: 117687 RVA: 0x00286AF4 File Offset: 0x00284CF4
		public static void InterpolationFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkQuadraticLinearQuad.vtkQuadraticLinearQuad_InterpolationFunctions_21(pcoords, weights);
		}

		// Token: 0x0601CBB8 RID: 117688
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticLinearQuad_IntersectWithLine_22(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		/// <summary>
		/// Line-edge intersection. Intersection has to occur within [0,1] parametric
		/// coordinates and with specified tolerance.
		/// </summary>
		// Token: 0x0601CBB9 RID: 117689 RVA: 0x00286B00 File Offset: 0x00284D00
		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkQuadraticLinearQuad.vtkQuadraticLinearQuad_IntersectWithLine_22(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		// Token: 0x0601CBBA RID: 117690
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticLinearQuad_IsA_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CBBB RID: 117691 RVA: 0x00286B2C File Offset: 0x00284D2C
		public override int IsA(string type)
		{
			return vtkQuadraticLinearQuad.vtkQuadraticLinearQuad_IsA_23(base.GetCppThis(), type);
		}

		// Token: 0x0601CBBC RID: 117692
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticLinearQuad_IsTypeOf_24([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CBBD RID: 117693 RVA: 0x00286B4C File Offset: 0x00284D4C
		public new static int IsTypeOf(string type)
		{
			return vtkQuadraticLinearQuad.vtkQuadraticLinearQuad_IsTypeOf_24(type);
		}

		// Token: 0x0601CBBE RID: 117694
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticLinearQuad_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CBBF RID: 117695 RVA: 0x00286B68 File Offset: 0x00284D68
		public new vtkQuadraticLinearQuad NewInstance()
		{
			vtkQuadraticLinearQuad result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadraticLinearQuad.vtkQuadraticLinearQuad_NewInstance_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuadraticLinearQuad)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601CBC0 RID: 117696
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticLinearQuad_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CBC1 RID: 117697 RVA: 0x00286BC4 File Offset: 0x00284DC4
		public new static vtkQuadraticLinearQuad SafeDownCast(vtkObjectBase o)
		{
			vtkQuadraticLinearQuad vtkQuadraticLinearQuad = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadraticLinearQuad.vtkQuadraticLinearQuad_SafeDownCast_27((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkQuadraticLinearQuad = (vtkQuadraticLinearQuad)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkQuadraticLinearQuad.Register(null);
				}
			}
			return vtkQuadraticLinearQuad;
		}

		// Token: 0x0601CBC2 RID: 117698
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticLinearQuad_TriangulateLocalIds_28(HandleRef pThis, int index, HandleRef ptIds);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CBC3 RID: 117699 RVA: 0x00286C44 File Offset: 0x00284E44
		public override int TriangulateLocalIds(int index, vtkIdList ptIds)
		{
			return vtkQuadraticLinearQuad.vtkQuadraticLinearQuad_TriangulateLocalIds_28(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E63 RID: 7779
		public new const string MRFullTypeName = "Kitware.VTK.vtkQuadraticLinearQuad";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E64 RID: 7780
		public new static readonly string MRClassNameKey = "class vtkQuadraticLinearQuad";
	}
}
