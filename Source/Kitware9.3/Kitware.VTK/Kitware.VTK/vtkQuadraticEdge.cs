using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkQuadraticEdge
	/// </summary>
	/// <remarks>
	///    cell represents a parabolic, isoparametric edge
	///
	/// vtkQuadraticEdge is a concrete implementation of vtkNonLinearCell to
	/// represent a one-dimensional, 3-nodes, isoparametric parabolic line. The
	/// interpolation is the standard finite element, quadratic isoparametric
	/// shape function. The cell includes a mid-edge node. The ordering of the
	/// three points defining the cell is point ids (0,1,2) where id #2 is the
	/// midedge node.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkQuadraticTriangle vtkQuadraticTetra vtkQuadraticWedge
	/// vtkQuadraticQuad vtkQuadraticHexahedron vtkQuadraticPyramid
	/// </seealso>
	// Token: 0x02000AAB RID: 2731
	public class vtkQuadraticEdge : vtkNonLinearCell
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601CB12 RID: 117522 RVA: 0x0028587D File Offset: 0x00283A7D
		static vtkQuadraticEdge()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkQuadraticEdge.MRClassNameKey, Type.GetType("Kitware.VTK.vtkQuadraticEdge"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601CB13 RID: 117523 RVA: 0x002858A5 File Offset: 0x00283AA5
		public vtkQuadraticEdge(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601CB14 RID: 117524
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticEdge_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CB15 RID: 117525 RVA: 0x002858B4 File Offset: 0x00283AB4
		public new static vtkQuadraticEdge New()
		{
			vtkQuadraticEdge result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadraticEdge.vtkQuadraticEdge_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuadraticEdge)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CB16 RID: 117526 RVA: 0x00285908 File Offset: 0x00283B08
		public vtkQuadraticEdge() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkQuadraticEdge.vtkQuadraticEdge_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601CB17 RID: 117527 RVA: 0x0028594C File Offset: 0x00283B4C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601CB18 RID: 117528
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticEdge_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CB19 RID: 117529 RVA: 0x00285958 File Offset: 0x00283B58
		public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
		{
			return vtkQuadraticEdge.vtkQuadraticEdge_CellBoundary_01(base.GetCppThis(), subId, pcoords, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601CB1A RID: 117530
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticEdge_Clip_02(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef lines, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

		/// <summary>
		/// Clip this edge using scalar value provided. Like contouring, except
		/// that it cuts the edge to produce linear line segments.
		/// </summary>
		// Token: 0x0601CB1B RID: 117531 RVA: 0x00285990 File Offset: 0x00283B90
		public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray lines, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
		{
			vtkQuadraticEdge.vtkQuadraticEdge_Clip_02(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis(), insideOut);
		}

		// Token: 0x0601CB1C RID: 117532
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticEdge_Contour_03(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CB1D RID: 117533 RVA: 0x00285A4C File Offset: 0x00283C4C
		public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
		{
			vtkQuadraticEdge.vtkQuadraticEdge_Contour_03(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis());
		}

		// Token: 0x0601CB1E RID: 117534
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticEdge_Derivatives_04(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CB1F RID: 117535 RVA: 0x00285B34 File Offset: 0x00283D34
		public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
		{
			vtkQuadraticEdge.vtkQuadraticEdge_Derivatives_04(base.GetCppThis(), subId, pcoords, values, dim, derivs);
		}

		// Token: 0x0601CB20 RID: 117536
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticEdge_EvaluateLocation_05(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CB21 RID: 117537 RVA: 0x00285B4A File Offset: 0x00283D4A
		public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
		{
			vtkQuadraticEdge.vtkQuadraticEdge_EvaluateLocation_05(base.GetCppThis(), ref subId, pcoords, x, weights);
		}

		// Token: 0x0601CB22 RID: 117538
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticEdge_EvaluatePosition_06(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CB23 RID: 117539 RVA: 0x00285B60 File Offset: 0x00283D60
		public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
		{
			return vtkQuadraticEdge.vtkQuadraticEdge_EvaluatePosition_06(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
		}

		// Token: 0x0601CB24 RID: 117540
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticEdge_GetCellDimension_07(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CB25 RID: 117541 RVA: 0x00285B88 File Offset: 0x00283D88
		public override int GetCellDimension()
		{
			return vtkQuadraticEdge.vtkQuadraticEdge_GetCellDimension_07(base.GetCppThis());
		}

		// Token: 0x0601CB26 RID: 117542
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticEdge_GetCellType_08(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CB27 RID: 117543 RVA: 0x00285BA8 File Offset: 0x00283DA8
		public override int GetCellType()
		{
			return vtkQuadraticEdge.vtkQuadraticEdge_GetCellType_08(base.GetCppThis());
		}

		// Token: 0x0601CB28 RID: 117544
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticEdge_GetEdge_09(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CB29 RID: 117545 RVA: 0x00285BC8 File Offset: 0x00283DC8
		public override vtkCell GetEdge(int arg0)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadraticEdge.vtkQuadraticEdge_GetEdge_09(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601CB2A RID: 117546
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticEdge_GetFace_10(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CB2B RID: 117547 RVA: 0x00285C38 File Offset: 0x00283E38
		public override vtkCell GetFace(int arg0)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadraticEdge.vtkQuadraticEdge_GetFace_10(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601CB2C RID: 117548
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticEdge_GetNumberOfEdges_11(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CB2D RID: 117549 RVA: 0x00285CA8 File Offset: 0x00283EA8
		public override int GetNumberOfEdges()
		{
			return vtkQuadraticEdge.vtkQuadraticEdge_GetNumberOfEdges_11(base.GetCppThis());
		}

		// Token: 0x0601CB2E RID: 117550
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticEdge_GetNumberOfFaces_12(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CB2F RID: 117551 RVA: 0x00285CC8 File Offset: 0x00283EC8
		public override int GetNumberOfFaces()
		{
			return vtkQuadraticEdge.vtkQuadraticEdge_GetNumberOfFaces_12(base.GetCppThis());
		}

		// Token: 0x0601CB30 RID: 117552
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkQuadraticEdge_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CB31 RID: 117553 RVA: 0x00285CE8 File Offset: 0x00283EE8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkQuadraticEdge.vtkQuadraticEdge_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x0601CB32 RID: 117554
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkQuadraticEdge_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CB33 RID: 117555 RVA: 0x00285D08 File Offset: 0x00283F08
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkQuadraticEdge.vtkQuadraticEdge_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x0601CB34 RID: 117556
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticEdge_GetParametricCenter_15(HandleRef pThis, IntPtr pcoords);

		/// <summary>
		/// Return the center of the quadratic tetra in parametric coordinates.
		/// </summary>
		// Token: 0x0601CB35 RID: 117557 RVA: 0x00285D24 File Offset: 0x00283F24
		public override int GetParametricCenter(IntPtr pcoords)
		{
			return vtkQuadraticEdge.vtkQuadraticEdge_GetParametricCenter_15(base.GetCppThis(), pcoords);
		}

		// Token: 0x0601CB36 RID: 117558
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticEdge_GetParametricCoords_16(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CB37 RID: 117559 RVA: 0x00285D44 File Offset: 0x00283F44
		public override IntPtr GetParametricCoords()
		{
			return vtkQuadraticEdge.vtkQuadraticEdge_GetParametricCoords_16(base.GetCppThis());
		}

		// Token: 0x0601CB38 RID: 117560
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticEdge_InterpolateDerivs_17(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601CB39 RID: 117561 RVA: 0x00285D63 File Offset: 0x00283F63
		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkQuadraticEdge.vtkQuadraticEdge_InterpolateDerivs_17(base.GetCppThis(), pcoords, derivs);
		}

		// Token: 0x0601CB3A RID: 117562
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticEdge_InterpolateFunctions_18(HandleRef pThis, IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601CB3B RID: 117563 RVA: 0x00285D74 File Offset: 0x00283F74
		public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkQuadraticEdge.vtkQuadraticEdge_InterpolateFunctions_18(base.GetCppThis(), pcoords, weights);
		}

		// Token: 0x0601CB3C RID: 117564
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticEdge_InterpolationDerivs_19(IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Return the center of the quadratic tetra in parametric coordinates.
		/// </summary>
		// Token: 0x0601CB3D RID: 117565 RVA: 0x00285D85 File Offset: 0x00283F85
		public static void InterpolationDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkQuadraticEdge.vtkQuadraticEdge_InterpolationDerivs_19(pcoords, derivs);
		}

		// Token: 0x0601CB3E RID: 117566
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticEdge_InterpolationFunctions_20(IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Return the center of the quadratic tetra in parametric coordinates.
		/// </summary>
		// Token: 0x0601CB3F RID: 117567 RVA: 0x00285D90 File Offset: 0x00283F90
		public static void InterpolationFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkQuadraticEdge.vtkQuadraticEdge_InterpolationFunctions_20(pcoords, weights);
		}

		// Token: 0x0601CB40 RID: 117568
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticEdge_IntersectWithLine_21(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		/// <summary>
		/// Line-edge intersection. Intersection has to occur within [0,1] parametric
		/// coordinates and with specified tolerance.
		/// </summary>
		// Token: 0x0601CB41 RID: 117569 RVA: 0x00285D9C File Offset: 0x00283F9C
		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkQuadraticEdge.vtkQuadraticEdge_IntersectWithLine_21(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		// Token: 0x0601CB42 RID: 117570
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticEdge_IsA_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CB43 RID: 117571 RVA: 0x00285DC8 File Offset: 0x00283FC8
		public override int IsA(string type)
		{
			return vtkQuadraticEdge.vtkQuadraticEdge_IsA_22(base.GetCppThis(), type);
		}

		// Token: 0x0601CB44 RID: 117572
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticEdge_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CB45 RID: 117573 RVA: 0x00285DE8 File Offset: 0x00283FE8
		public new static int IsTypeOf(string type)
		{
			return vtkQuadraticEdge.vtkQuadraticEdge_IsTypeOf_23(type);
		}

		// Token: 0x0601CB46 RID: 117574
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticEdge_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CB47 RID: 117575 RVA: 0x00285E04 File Offset: 0x00284004
		public new vtkQuadraticEdge NewInstance()
		{
			vtkQuadraticEdge result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadraticEdge.vtkQuadraticEdge_NewInstance_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuadraticEdge)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601CB48 RID: 117576
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticEdge_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CB49 RID: 117577 RVA: 0x00285E60 File Offset: 0x00284060
		public new static vtkQuadraticEdge SafeDownCast(vtkObjectBase o)
		{
			vtkQuadraticEdge vtkQuadraticEdge = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadraticEdge.vtkQuadraticEdge_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkQuadraticEdge = (vtkQuadraticEdge)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkQuadraticEdge.Register(null);
				}
			}
			return vtkQuadraticEdge;
		}

		// Token: 0x0601CB4A RID: 117578
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticEdge_TriangulateLocalIds_27(HandleRef pThis, int index, HandleRef ptIds);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CB4B RID: 117579 RVA: 0x00285EE0 File Offset: 0x002840E0
		public override int TriangulateLocalIds(int index, vtkIdList ptIds)
		{
			return vtkQuadraticEdge.vtkQuadraticEdge_TriangulateLocalIds_27(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E5F RID: 7775
		public new const string MRFullTypeName = "Kitware.VTK.vtkQuadraticEdge";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E60 RID: 7776
		public new static readonly string MRClassNameKey = "class vtkQuadraticEdge";
	}
}
