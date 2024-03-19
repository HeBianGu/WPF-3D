using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkQuadraticWedge
	/// </summary>
	/// <remarks>
	///    cell represents a parabolic, 15-node isoparametric wedge
	///
	/// vtkQuadraticWedge is a concrete implementation of vtkNonLinearCell to
	/// represent a three-dimensional, 15-node isoparametric parabolic
	/// wedge. The interpolation is the standard finite element, quadratic
	/// isoparametric shape function. The cell includes a mid-edge node. The
	/// ordering of the fifteen points defining the cell is point ids (0-5,6-14)
	/// where point ids 0-5 are the six corner vertices of the wedge, defined
	/// analogously to the six points in vtkWedge (points (0,1,2) form the base of
	/// the wedge which, using the right hand rule, forms a triangle whose normal
	/// points away from the triangular face (3,4,5)); followed by nine midedge
	/// nodes (6-14). Note that these midedge nodes correspond lie on the edges
	/// defined by (0,1), (1,2), (2,0), (3,4), (4,5), (5,3), (0,3), (1,4), (2,5).
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkQuadraticEdge vtkQuadraticTriangle vtkQuadraticTetra
	/// vtkQuadraticHexahedron vtkQuadraticQuad vtkQuadraticPyramid
	/// </seealso>
	// Token: 0x02000AB4 RID: 2740
	public class vtkQuadraticWedge : vtkNonLinearCell
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601CD3E RID: 118078 RVA: 0x00289749 File Offset: 0x00287949
		static vtkQuadraticWedge()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkQuadraticWedge.MRClassNameKey, Type.GetType("Kitware.VTK.vtkQuadraticWedge"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601CD3F RID: 118079 RVA: 0x00289771 File Offset: 0x00287971
		public vtkQuadraticWedge(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601CD40 RID: 118080
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticWedge_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CD41 RID: 118081 RVA: 0x00289780 File Offset: 0x00287980
		public new static vtkQuadraticWedge New()
		{
			vtkQuadraticWedge result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadraticWedge.vtkQuadraticWedge_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuadraticWedge)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CD42 RID: 118082 RVA: 0x002897D4 File Offset: 0x002879D4
		public vtkQuadraticWedge() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkQuadraticWedge.vtkQuadraticWedge_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601CD43 RID: 118083 RVA: 0x00289818 File Offset: 0x00287A18
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601CD44 RID: 118084
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticWedge_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CD45 RID: 118085 RVA: 0x00289824 File Offset: 0x00287A24
		public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
		{
			return vtkQuadraticWedge.vtkQuadraticWedge_CellBoundary_01(base.GetCppThis(), subId, pcoords, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601CD46 RID: 118086
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticWedge_Clip_02(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef tetras, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

		/// <summary>
		/// Clip this quadratic hexahedron using scalar value provided. Like
		/// contouring, except that it cuts the hex to produce linear
		/// tetrahedron.
		/// </summary>
		// Token: 0x0601CD47 RID: 118087 RVA: 0x0028985C File Offset: 0x00287A5C
		public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray tetras, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
		{
			vtkQuadraticWedge.vtkQuadraticWedge_Clip_02(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (tetras == null) ? default(HandleRef) : tetras.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis(), insideOut);
		}

		// Token: 0x0601CD48 RID: 118088
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticWedge_Contour_03(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CD49 RID: 118089 RVA: 0x00289918 File Offset: 0x00287B18
		public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
		{
			vtkQuadraticWedge.vtkQuadraticWedge_Contour_03(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis());
		}

		// Token: 0x0601CD4A RID: 118090
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticWedge_Derivatives_04(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CD4B RID: 118091 RVA: 0x00289A00 File Offset: 0x00287C00
		public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
		{
			vtkQuadraticWedge.vtkQuadraticWedge_Derivatives_04(base.GetCppThis(), subId, pcoords, values, dim, derivs);
		}

		// Token: 0x0601CD4C RID: 118092
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticWedge_EvaluateLocation_05(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CD4D RID: 118093 RVA: 0x00289A16 File Offset: 0x00287C16
		public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
		{
			vtkQuadraticWedge.vtkQuadraticWedge_EvaluateLocation_05(base.GetCppThis(), ref subId, pcoords, x, weights);
		}

		// Token: 0x0601CD4E RID: 118094
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticWedge_EvaluatePosition_06(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CD4F RID: 118095 RVA: 0x00289A2C File Offset: 0x00287C2C
		public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
		{
			return vtkQuadraticWedge.vtkQuadraticWedge_EvaluatePosition_06(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
		}

		// Token: 0x0601CD50 RID: 118096
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticWedge_GetCellDimension_07(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CD51 RID: 118097 RVA: 0x00289A54 File Offset: 0x00287C54
		public override int GetCellDimension()
		{
			return vtkQuadraticWedge.vtkQuadraticWedge_GetCellDimension_07(base.GetCppThis());
		}

		// Token: 0x0601CD52 RID: 118098
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticWedge_GetCellType_08(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CD53 RID: 118099 RVA: 0x00289A74 File Offset: 0x00287C74
		public override int GetCellType()
		{
			return vtkQuadraticWedge.vtkQuadraticWedge_GetCellType_08(base.GetCppThis());
		}

		// Token: 0x0601CD54 RID: 118100
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticWedge_GetEdge_09(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CD55 RID: 118101 RVA: 0x00289A94 File Offset: 0x00287C94
		public override vtkCell GetEdge(int edgeId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadraticWedge.vtkQuadraticWedge_GetEdge_09(base.GetCppThis(), edgeId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601CD56 RID: 118102
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticWedge_GetEdgeArray_10(long edgeId);

		/// <summary>
		/// Return the ids of the vertices defining edge/face (`edgeId`/`faceId').
		/// Ids are related to the cell, not to the dataset.
		///
		/// @note The return type changed. It used to be int*, it is now const vtkIdType*.
		/// This is so ids are unified between vtkCell and vtkPoints.
		/// </summary>
		// Token: 0x0601CD57 RID: 118103 RVA: 0x00289B04 File Offset: 0x00287D04
		public static IntPtr GetEdgeArray(long edgeId)
		{
			return vtkQuadraticWedge.vtkQuadraticWedge_GetEdgeArray_10(edgeId);
		}

		// Token: 0x0601CD58 RID: 118104
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticWedge_GetFace_11(HandleRef pThis, int faceId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CD59 RID: 118105 RVA: 0x00289B20 File Offset: 0x00287D20
		public override vtkCell GetFace(int faceId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadraticWedge.vtkQuadraticWedge_GetFace_11(base.GetCppThis(), faceId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601CD5A RID: 118106
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticWedge_GetFaceArray_12(long faceId);

		/// <summary>
		/// Return the ids of the vertices defining edge/face (`edgeId`/`faceId').
		/// Ids are related to the cell, not to the dataset.
		///
		/// @note The return type changed. It used to be int*, it is now const vtkIdType*.
		/// This is so ids are unified between vtkCell and vtkPoints.
		/// </summary>
		// Token: 0x0601CD5B RID: 118107 RVA: 0x00289B90 File Offset: 0x00287D90
		public static IntPtr GetFaceArray(long faceId)
		{
			return vtkQuadraticWedge.vtkQuadraticWedge_GetFaceArray_12(faceId);
		}

		// Token: 0x0601CD5C RID: 118108
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticWedge_GetNumberOfEdges_13(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CD5D RID: 118109 RVA: 0x00289BAC File Offset: 0x00287DAC
		public override int GetNumberOfEdges()
		{
			return vtkQuadraticWedge.vtkQuadraticWedge_GetNumberOfEdges_13(base.GetCppThis());
		}

		// Token: 0x0601CD5E RID: 118110
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticWedge_GetNumberOfFaces_14(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CD5F RID: 118111 RVA: 0x00289BCC File Offset: 0x00287DCC
		public override int GetNumberOfFaces()
		{
			return vtkQuadraticWedge.vtkQuadraticWedge_GetNumberOfFaces_14(base.GetCppThis());
		}

		// Token: 0x0601CD60 RID: 118112
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkQuadraticWedge_GetNumberOfGenerationsFromBase_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CD61 RID: 118113 RVA: 0x00289BEC File Offset: 0x00287DEC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkQuadraticWedge.vtkQuadraticWedge_GetNumberOfGenerationsFromBase_15(base.GetCppThis(), type);
		}

		// Token: 0x0601CD62 RID: 118114
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkQuadraticWedge_GetNumberOfGenerationsFromBaseType_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CD63 RID: 118115 RVA: 0x00289C0C File Offset: 0x00287E0C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkQuadraticWedge.vtkQuadraticWedge_GetNumberOfGenerationsFromBaseType_16(type);
		}

		// Token: 0x0601CD64 RID: 118116
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticWedge_GetParametricCenter_17(HandleRef pThis, IntPtr pcoords);

		/// <summary>
		/// Return the center of the quadratic wedge in parametric coordinates.
		/// </summary>
		// Token: 0x0601CD65 RID: 118117 RVA: 0x00289C28 File Offset: 0x00287E28
		public override int GetParametricCenter(IntPtr pcoords)
		{
			return vtkQuadraticWedge.vtkQuadraticWedge_GetParametricCenter_17(base.GetCppThis(), pcoords);
		}

		// Token: 0x0601CD66 RID: 118118
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticWedge_GetParametricCoords_18(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CD67 RID: 118119 RVA: 0x00289C48 File Offset: 0x00287E48
		public override IntPtr GetParametricCoords()
		{
			return vtkQuadraticWedge.vtkQuadraticWedge_GetParametricCoords_18(base.GetCppThis());
		}

		// Token: 0x0601CD68 RID: 118120
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticWedge_InterpolateDerivs_19(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601CD69 RID: 118121 RVA: 0x00289C67 File Offset: 0x00287E67
		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkQuadraticWedge.vtkQuadraticWedge_InterpolateDerivs_19(base.GetCppThis(), pcoords, derivs);
		}

		// Token: 0x0601CD6A RID: 118122
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticWedge_InterpolateFunctions_20(HandleRef pThis, IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601CD6B RID: 118123 RVA: 0x00289C78 File Offset: 0x00287E78
		public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkQuadraticWedge.vtkQuadraticWedge_InterpolateFunctions_20(base.GetCppThis(), pcoords, weights);
		}

		// Token: 0x0601CD6C RID: 118124
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticWedge_InterpolationDerivs_21(IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Return the center of the quadratic wedge in parametric coordinates.
		/// </summary>
		// Token: 0x0601CD6D RID: 118125 RVA: 0x00289C89 File Offset: 0x00287E89
		public static void InterpolationDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkQuadraticWedge.vtkQuadraticWedge_InterpolationDerivs_21(pcoords, derivs);
		}

		// Token: 0x0601CD6E RID: 118126
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticWedge_InterpolationFunctions_22(IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Return the center of the quadratic wedge in parametric coordinates.
		/// </summary>
		// Token: 0x0601CD6F RID: 118127 RVA: 0x00289C94 File Offset: 0x00287E94
		public static void InterpolationFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkQuadraticWedge.vtkQuadraticWedge_InterpolationFunctions_22(pcoords, weights);
		}

		// Token: 0x0601CD70 RID: 118128
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticWedge_IntersectWithLine_23(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		/// <summary>
		/// Line-edge intersection. Intersection has to occur within [0,1] parametric
		/// coordinates and with specified tolerance.
		/// </summary>
		// Token: 0x0601CD71 RID: 118129 RVA: 0x00289CA0 File Offset: 0x00287EA0
		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkQuadraticWedge.vtkQuadraticWedge_IntersectWithLine_23(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		// Token: 0x0601CD72 RID: 118130
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticWedge_IsA_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CD73 RID: 118131 RVA: 0x00289CCC File Offset: 0x00287ECC
		public override int IsA(string type)
		{
			return vtkQuadraticWedge.vtkQuadraticWedge_IsA_24(base.GetCppThis(), type);
		}

		// Token: 0x0601CD74 RID: 118132
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticWedge_IsTypeOf_25([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CD75 RID: 118133 RVA: 0x00289CEC File Offset: 0x00287EEC
		public new static int IsTypeOf(string type)
		{
			return vtkQuadraticWedge.vtkQuadraticWedge_IsTypeOf_25(type);
		}

		// Token: 0x0601CD76 RID: 118134
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticWedge_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CD77 RID: 118135 RVA: 0x00289D08 File Offset: 0x00287F08
		public new vtkQuadraticWedge NewInstance()
		{
			vtkQuadraticWedge result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadraticWedge.vtkQuadraticWedge_NewInstance_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuadraticWedge)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601CD78 RID: 118136
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticWedge_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CD79 RID: 118137 RVA: 0x00289D64 File Offset: 0x00287F64
		public new static vtkQuadraticWedge SafeDownCast(vtkObjectBase o)
		{
			vtkQuadraticWedge vtkQuadraticWedge = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadraticWedge.vtkQuadraticWedge_SafeDownCast_28((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkQuadraticWedge = (vtkQuadraticWedge)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkQuadraticWedge.Register(null);
				}
			}
			return vtkQuadraticWedge;
		}

		// Token: 0x0601CD7A RID: 118138
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticWedge_TriangulateLocalIds_29(HandleRef pThis, int index, HandleRef ptIds);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CD7B RID: 118139 RVA: 0x00289DE4 File Offset: 0x00287FE4
		public override int TriangulateLocalIds(int index, vtkIdList ptIds)
		{
			return vtkQuadraticWedge.vtkQuadraticWedge_TriangulateLocalIds_29(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E71 RID: 7793
		public new const string MRFullTypeName = "Kitware.VTK.vtkQuadraticWedge";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E72 RID: 7794
		public new static readonly string MRClassNameKey = "class vtkQuadraticWedge";
	}
}
