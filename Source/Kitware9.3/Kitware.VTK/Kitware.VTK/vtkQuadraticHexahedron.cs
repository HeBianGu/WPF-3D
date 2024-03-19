using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkQuadraticHexahedron
	/// </summary>
	/// <remarks>
	///    cell represents a parabolic, 20-node isoparametric hexahedron
	///
	/// vtkQuadraticHexahedron is a concrete implementation of vtkNonLinearCell to
	/// represent a three-dimensional, 20-node isoparametric parabolic
	/// hexahedron. The interpolation is the standard finite element, quadratic
	/// isoparametric shape function. The cell includes a mid-edge node. The
	/// ordering of the twenty points defining the cell is point ids (0-7,8-19)
	/// where point ids 0-7 are the eight corner vertices of the cube; followed by
	/// twelve midedge nodes (8-19). Note that these midedge nodes correspond lie
	/// on the edges defined by (0,1), (1,2), (2,3), (3,0), (4,5), (5,6), (6,7),
	/// (7,4), (0,4), (1,5), (2,6), (3,7).
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkQuadraticEdge vtkQuadraticTriangle vtkQuadraticTetra
	/// vtkQuadraticQuad vtkQuadraticPyramid vtkQuadraticWedge
	/// </seealso>
	// Token: 0x02000AAC RID: 2732
	public class vtkQuadraticHexahedron : vtkNonLinearCell
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601CB4C RID: 117580 RVA: 0x00285F15 File Offset: 0x00284115
		static vtkQuadraticHexahedron()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkQuadraticHexahedron.MRClassNameKey, Type.GetType("Kitware.VTK.vtkQuadraticHexahedron"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601CB4D RID: 117581 RVA: 0x00285F3D File Offset: 0x0028413D
		public vtkQuadraticHexahedron(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601CB4E RID: 117582
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticHexahedron_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CB4F RID: 117583 RVA: 0x00285F4C File Offset: 0x0028414C
		public new static vtkQuadraticHexahedron New()
		{
			vtkQuadraticHexahedron result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadraticHexahedron.vtkQuadraticHexahedron_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuadraticHexahedron)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CB50 RID: 117584 RVA: 0x00285FA0 File Offset: 0x002841A0
		public vtkQuadraticHexahedron() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkQuadraticHexahedron.vtkQuadraticHexahedron_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601CB51 RID: 117585 RVA: 0x00285FE4 File Offset: 0x002841E4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601CB52 RID: 117586
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticHexahedron_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CB53 RID: 117587 RVA: 0x00285FF0 File Offset: 0x002841F0
		public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
		{
			return vtkQuadraticHexahedron.vtkQuadraticHexahedron_CellBoundary_01(base.GetCppThis(), subId, pcoords, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601CB54 RID: 117588
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticHexahedron_Clip_02(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef tetras, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

		/// <summary>
		/// Clip this quadratic hexahedron using scalar value provided. Like
		/// contouring, except that it cuts the hex to produce linear
		/// tetrahedron.
		/// </summary>
		// Token: 0x0601CB55 RID: 117589 RVA: 0x00286028 File Offset: 0x00284228
		public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray tetras, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
		{
			vtkQuadraticHexahedron.vtkQuadraticHexahedron_Clip_02(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (tetras == null) ? default(HandleRef) : tetras.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis(), insideOut);
		}

		// Token: 0x0601CB56 RID: 117590
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticHexahedron_Contour_03(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CB57 RID: 117591 RVA: 0x002860E4 File Offset: 0x002842E4
		public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
		{
			vtkQuadraticHexahedron.vtkQuadraticHexahedron_Contour_03(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis());
		}

		// Token: 0x0601CB58 RID: 117592
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticHexahedron_Derivatives_04(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CB59 RID: 117593 RVA: 0x002861CC File Offset: 0x002843CC
		public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
		{
			vtkQuadraticHexahedron.vtkQuadraticHexahedron_Derivatives_04(base.GetCppThis(), subId, pcoords, values, dim, derivs);
		}

		// Token: 0x0601CB5A RID: 117594
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticHexahedron_EvaluateLocation_05(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CB5B RID: 117595 RVA: 0x002861E2 File Offset: 0x002843E2
		public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
		{
			vtkQuadraticHexahedron.vtkQuadraticHexahedron_EvaluateLocation_05(base.GetCppThis(), ref subId, pcoords, x, weights);
		}

		// Token: 0x0601CB5C RID: 117596
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticHexahedron_EvaluatePosition_06(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CB5D RID: 117597 RVA: 0x002861F8 File Offset: 0x002843F8
		public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
		{
			return vtkQuadraticHexahedron.vtkQuadraticHexahedron_EvaluatePosition_06(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
		}

		// Token: 0x0601CB5E RID: 117598
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticHexahedron_GetCellDimension_07(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CB5F RID: 117599 RVA: 0x00286220 File Offset: 0x00284420
		public override int GetCellDimension()
		{
			return vtkQuadraticHexahedron.vtkQuadraticHexahedron_GetCellDimension_07(base.GetCppThis());
		}

		// Token: 0x0601CB60 RID: 117600
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticHexahedron_GetCellType_08(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CB61 RID: 117601 RVA: 0x00286240 File Offset: 0x00284440
		public override int GetCellType()
		{
			return vtkQuadraticHexahedron.vtkQuadraticHexahedron_GetCellType_08(base.GetCppThis());
		}

		// Token: 0x0601CB62 RID: 117602
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticHexahedron_GetEdge_09(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CB63 RID: 117603 RVA: 0x00286260 File Offset: 0x00284460
		public override vtkCell GetEdge(int arg0)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadraticHexahedron.vtkQuadraticHexahedron_GetEdge_09(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601CB64 RID: 117604
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticHexahedron_GetEdgeArray_10(long edgeId);

		/// <summary>
		/// Return the ids of the vertices defining edge/face (`edgeId`/`faceId').
		/// Ids are related to the cell, not to the dataset.
		///
		/// @note The return type changed. It used to be int*, it is now const vtkIdType*.
		/// This is so ids are unified between vtkCell and vtkPoints.
		/// </summary>
		// Token: 0x0601CB65 RID: 117605 RVA: 0x002862D0 File Offset: 0x002844D0
		public static IntPtr GetEdgeArray(long edgeId)
		{
			return vtkQuadraticHexahedron.vtkQuadraticHexahedron_GetEdgeArray_10(edgeId);
		}

		// Token: 0x0601CB66 RID: 117606
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticHexahedron_GetFace_11(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CB67 RID: 117607 RVA: 0x002862EC File Offset: 0x002844EC
		public override vtkCell GetFace(int arg0)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadraticHexahedron.vtkQuadraticHexahedron_GetFace_11(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601CB68 RID: 117608
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticHexahedron_GetFaceArray_12(long faceId);

		/// <summary>
		/// Return the ids of the vertices defining edge/face (`edgeId`/`faceId').
		/// Ids are related to the cell, not to the dataset.
		///
		/// @note The return type changed. It used to be int*, it is now const vtkIdType*.
		/// This is so ids are unified between vtkCell and vtkPoints.
		/// </summary>
		// Token: 0x0601CB69 RID: 117609 RVA: 0x0028635C File Offset: 0x0028455C
		public static IntPtr GetFaceArray(long faceId)
		{
			return vtkQuadraticHexahedron.vtkQuadraticHexahedron_GetFaceArray_12(faceId);
		}

		// Token: 0x0601CB6A RID: 117610
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticHexahedron_GetNumberOfEdges_13(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CB6B RID: 117611 RVA: 0x00286378 File Offset: 0x00284578
		public override int GetNumberOfEdges()
		{
			return vtkQuadraticHexahedron.vtkQuadraticHexahedron_GetNumberOfEdges_13(base.GetCppThis());
		}

		// Token: 0x0601CB6C RID: 117612
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticHexahedron_GetNumberOfFaces_14(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CB6D RID: 117613 RVA: 0x00286398 File Offset: 0x00284598
		public override int GetNumberOfFaces()
		{
			return vtkQuadraticHexahedron.vtkQuadraticHexahedron_GetNumberOfFaces_14(base.GetCppThis());
		}

		// Token: 0x0601CB6E RID: 117614
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkQuadraticHexahedron_GetNumberOfGenerationsFromBase_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CB6F RID: 117615 RVA: 0x002863B8 File Offset: 0x002845B8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkQuadraticHexahedron.vtkQuadraticHexahedron_GetNumberOfGenerationsFromBase_15(base.GetCppThis(), type);
		}

		// Token: 0x0601CB70 RID: 117616
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkQuadraticHexahedron_GetNumberOfGenerationsFromBaseType_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CB71 RID: 117617 RVA: 0x002863D8 File Offset: 0x002845D8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkQuadraticHexahedron.vtkQuadraticHexahedron_GetNumberOfGenerationsFromBaseType_16(type);
		}

		// Token: 0x0601CB72 RID: 117618
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticHexahedron_GetParametricCoords_17(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CB73 RID: 117619 RVA: 0x002863F4 File Offset: 0x002845F4
		public override IntPtr GetParametricCoords()
		{
			return vtkQuadraticHexahedron.vtkQuadraticHexahedron_GetParametricCoords_17(base.GetCppThis());
		}

		// Token: 0x0601CB74 RID: 117620
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticHexahedron_InterpolateDerivs_18(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601CB75 RID: 117621 RVA: 0x00286413 File Offset: 0x00284613
		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkQuadraticHexahedron.vtkQuadraticHexahedron_InterpolateDerivs_18(base.GetCppThis(), pcoords, derivs);
		}

		// Token: 0x0601CB76 RID: 117622
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticHexahedron_InterpolateFunctions_19(HandleRef pThis, IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601CB77 RID: 117623 RVA: 0x00286424 File Offset: 0x00284624
		public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkQuadraticHexahedron.vtkQuadraticHexahedron_InterpolateFunctions_19(base.GetCppThis(), pcoords, weights);
		}

		// Token: 0x0601CB78 RID: 117624
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticHexahedron_InterpolationDerivs_20(IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Line-edge intersection. Intersection has to occur within [0,1] parametric
		/// coordinates and with specified tolerance.
		/// </summary>
		// Token: 0x0601CB79 RID: 117625 RVA: 0x00286435 File Offset: 0x00284635
		public static void InterpolationDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkQuadraticHexahedron.vtkQuadraticHexahedron_InterpolationDerivs_20(pcoords, derivs);
		}

		// Token: 0x0601CB7A RID: 117626
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticHexahedron_InterpolationFunctions_21(IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Line-edge intersection. Intersection has to occur within [0,1] parametric
		/// coordinates and with specified tolerance.
		/// </summary>
		// Token: 0x0601CB7B RID: 117627 RVA: 0x00286440 File Offset: 0x00284640
		public static void InterpolationFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkQuadraticHexahedron.vtkQuadraticHexahedron_InterpolationFunctions_21(pcoords, weights);
		}

		// Token: 0x0601CB7C RID: 117628
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticHexahedron_IntersectWithLine_22(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		/// <summary>
		/// Line-edge intersection. Intersection has to occur within [0,1] parametric
		/// coordinates and with specified tolerance.
		/// </summary>
		// Token: 0x0601CB7D RID: 117629 RVA: 0x0028644C File Offset: 0x0028464C
		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkQuadraticHexahedron.vtkQuadraticHexahedron_IntersectWithLine_22(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		// Token: 0x0601CB7E RID: 117630
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticHexahedron_IsA_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CB7F RID: 117631 RVA: 0x00286478 File Offset: 0x00284678
		public override int IsA(string type)
		{
			return vtkQuadraticHexahedron.vtkQuadraticHexahedron_IsA_23(base.GetCppThis(), type);
		}

		// Token: 0x0601CB80 RID: 117632
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticHexahedron_IsTypeOf_24([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CB81 RID: 117633 RVA: 0x00286498 File Offset: 0x00284698
		public new static int IsTypeOf(string type)
		{
			return vtkQuadraticHexahedron.vtkQuadraticHexahedron_IsTypeOf_24(type);
		}

		// Token: 0x0601CB82 RID: 117634
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticHexahedron_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CB83 RID: 117635 RVA: 0x002864B4 File Offset: 0x002846B4
		public new vtkQuadraticHexahedron NewInstance()
		{
			vtkQuadraticHexahedron result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadraticHexahedron.vtkQuadraticHexahedron_NewInstance_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuadraticHexahedron)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601CB84 RID: 117636
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticHexahedron_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CB85 RID: 117637 RVA: 0x00286510 File Offset: 0x00284710
		public new static vtkQuadraticHexahedron SafeDownCast(vtkObjectBase o)
		{
			vtkQuadraticHexahedron vtkQuadraticHexahedron = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadraticHexahedron.vtkQuadraticHexahedron_SafeDownCast_27((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkQuadraticHexahedron = (vtkQuadraticHexahedron)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkQuadraticHexahedron.Register(null);
				}
			}
			return vtkQuadraticHexahedron;
		}

		// Token: 0x0601CB86 RID: 117638
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticHexahedron_TriangulateLocalIds_28(HandleRef pThis, int index, HandleRef ptIds);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CB87 RID: 117639 RVA: 0x00286590 File Offset: 0x00284790
		public override int TriangulateLocalIds(int index, vtkIdList ptIds)
		{
			return vtkQuadraticHexahedron.vtkQuadraticHexahedron_TriangulateLocalIds_28(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E61 RID: 7777
		public new const string MRFullTypeName = "Kitware.VTK.vtkQuadraticHexahedron";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E62 RID: 7778
		public new static readonly string MRClassNameKey = "class vtkQuadraticHexahedron";
	}
}
