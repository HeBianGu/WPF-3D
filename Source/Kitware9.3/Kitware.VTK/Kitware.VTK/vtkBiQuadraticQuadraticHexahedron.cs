using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBiQuadraticQuadraticHexahedron
	/// </summary>
	/// <remarks>
	///    cell represents a biquadratic,
	/// 24-node isoparametric hexahedron
	///
	/// vtkBiQuadraticQuadraticHexahedron is a concrete implementation of vtkNonLinearCell to
	/// represent a three-dimensional, 24-node isoparametric biquadratic
	/// hexahedron. The interpolation is the standard finite element,
	/// biquadratic-quadratic
	/// isoparametric shape function. The cell includes mid-edge and center-face nodes. The
	/// ordering of the 24 points defining the cell is point ids (0-7,8-19, 20-23)
	/// where point ids 0-7 are the eight corner vertices of the cube; followed by
	/// twelve midedge nodes (8-19), nodes 20-23 are the center-face nodes. Note that
	/// these midedge nodes correspond lie
	/// on the edges defined by (0,1), (1,2), (2,3), (3,0), (4,5), (5,6), (6,7),
	/// (7,4), (0,4), (1,5), (2,6), (3,7). The center face nodes laying in quad
	/// 22-(0,1,5,4), 21-(1,2,6,5), 23-(2,3,7,6) and 22-(3,0,4,7)
	///
	/// \verbatim
	///
	/// top
	///  7--14--6
	///  |      |
	/// 15      13
	///  |      |
	///  4--12--5
	///
	///  middle
	/// 19--23--18
	///  |      |
	/// 20      21
	///  |      |
	/// 16--22--17
	///
	/// bottom
	///  3--10--2
	///  |      |
	/// 11      9
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
	///
	/// @par Thanks:
	/// Thanks to Soeren Gebbert  who developed this class and
	/// integrated it into VTK 5.0.
	/// </seealso>
	// Token: 0x02000A0E RID: 2574
	public class vtkBiQuadraticQuadraticHexahedron : vtkNonLinearCell
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601AC4B RID: 109643 RVA: 0x00254839 File Offset: 0x00252A39
		static vtkBiQuadraticQuadraticHexahedron()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBiQuadraticQuadraticHexahedron.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBiQuadraticQuadraticHexahedron"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601AC4C RID: 109644 RVA: 0x00254861 File Offset: 0x00252A61
		public vtkBiQuadraticQuadraticHexahedron(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601AC4D RID: 109645
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiQuadraticQuadraticHexahedron_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AC4E RID: 109646 RVA: 0x00254870 File Offset: 0x00252A70
		public new static vtkBiQuadraticQuadraticHexahedron New()
		{
			vtkBiQuadraticQuadraticHexahedron result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBiQuadraticQuadraticHexahedron.vtkBiQuadraticQuadraticHexahedron_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBiQuadraticQuadraticHexahedron)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AC4F RID: 109647 RVA: 0x002548C4 File Offset: 0x00252AC4
		public vtkBiQuadraticQuadraticHexahedron() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBiQuadraticQuadraticHexahedron.vtkBiQuadraticQuadraticHexahedron_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601AC50 RID: 109648 RVA: 0x00254908 File Offset: 0x00252B08
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601AC51 RID: 109649
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiQuadraticQuadraticHexahedron_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601AC52 RID: 109650 RVA: 0x00254914 File Offset: 0x00252B14
		public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
		{
			return vtkBiQuadraticQuadraticHexahedron.vtkBiQuadraticQuadraticHexahedron_CellBoundary_01(base.GetCppThis(), subId, pcoords, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601AC53 RID: 109651
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiQuadraticQuadraticHexahedron_Clip_02(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef tetras, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

		/// <summary>
		/// Clip this biquadratic hexahedron using scalar value provided. Like
		/// contouring, except that it cuts the hex to produce linear
		/// tetrahedron.
		/// </summary>
		// Token: 0x0601AC54 RID: 109652 RVA: 0x0025494C File Offset: 0x00252B4C
		public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray tetras, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
		{
			vtkBiQuadraticQuadraticHexahedron.vtkBiQuadraticQuadraticHexahedron_Clip_02(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (tetras == null) ? default(HandleRef) : tetras.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis(), insideOut);
		}

		// Token: 0x0601AC55 RID: 109653
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiQuadraticQuadraticHexahedron_Contour_03(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601AC56 RID: 109654 RVA: 0x00254A08 File Offset: 0x00252C08
		public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
		{
			vtkBiQuadraticQuadraticHexahedron.vtkBiQuadraticQuadraticHexahedron_Contour_03(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis());
		}

		// Token: 0x0601AC57 RID: 109655
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiQuadraticQuadraticHexahedron_Derivatives_04(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601AC58 RID: 109656 RVA: 0x00254AF0 File Offset: 0x00252CF0
		public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
		{
			vtkBiQuadraticQuadraticHexahedron.vtkBiQuadraticQuadraticHexahedron_Derivatives_04(base.GetCppThis(), subId, pcoords, values, dim, derivs);
		}

		// Token: 0x0601AC59 RID: 109657
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiQuadraticQuadraticHexahedron_EvaluateLocation_05(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601AC5A RID: 109658 RVA: 0x00254B06 File Offset: 0x00252D06
		public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
		{
			vtkBiQuadraticQuadraticHexahedron.vtkBiQuadraticQuadraticHexahedron_EvaluateLocation_05(base.GetCppThis(), ref subId, pcoords, x, weights);
		}

		// Token: 0x0601AC5B RID: 109659
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiQuadraticQuadraticHexahedron_EvaluatePosition_06(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601AC5C RID: 109660 RVA: 0x00254B1C File Offset: 0x00252D1C
		public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
		{
			return vtkBiQuadraticQuadraticHexahedron.vtkBiQuadraticQuadraticHexahedron_EvaluatePosition_06(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
		}

		// Token: 0x0601AC5D RID: 109661
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiQuadraticQuadraticHexahedron_GetCellDimension_07(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601AC5E RID: 109662 RVA: 0x00254B44 File Offset: 0x00252D44
		public override int GetCellDimension()
		{
			return vtkBiQuadraticQuadraticHexahedron.vtkBiQuadraticQuadraticHexahedron_GetCellDimension_07(base.GetCppThis());
		}

		// Token: 0x0601AC5F RID: 109663
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiQuadraticQuadraticHexahedron_GetCellType_08(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601AC60 RID: 109664 RVA: 0x00254B64 File Offset: 0x00252D64
		public override int GetCellType()
		{
			return vtkBiQuadraticQuadraticHexahedron.vtkBiQuadraticQuadraticHexahedron_GetCellType_08(base.GetCppThis());
		}

		// Token: 0x0601AC61 RID: 109665
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiQuadraticQuadraticHexahedron_GetEdge_09(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601AC62 RID: 109666 RVA: 0x00254B84 File Offset: 0x00252D84
		public override vtkCell GetEdge(int arg0)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBiQuadraticQuadraticHexahedron.vtkBiQuadraticQuadraticHexahedron_GetEdge_09(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601AC63 RID: 109667
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiQuadraticQuadraticHexahedron_GetEdgeArray_10(long edgeId);

		/// <summary>
		/// Return the ids of the vertices defining edge/face (`edgeId`/`faceId').
		/// Ids are related to the cell, not to the dataset.
		///
		/// @note The return type changed. It used to be int*, it is now const vtkIdType*.
		/// This is so ids are unified between vtkCell and vtkPoints.
		/// </summary>
		// Token: 0x0601AC64 RID: 109668 RVA: 0x00254BF4 File Offset: 0x00252DF4
		public static IntPtr GetEdgeArray(long edgeId)
		{
			return vtkBiQuadraticQuadraticHexahedron.vtkBiQuadraticQuadraticHexahedron_GetEdgeArray_10(edgeId);
		}

		// Token: 0x0601AC65 RID: 109669
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiQuadraticQuadraticHexahedron_GetFace_11(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601AC66 RID: 109670 RVA: 0x00254C10 File Offset: 0x00252E10
		public override vtkCell GetFace(int arg0)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBiQuadraticQuadraticHexahedron.vtkBiQuadraticQuadraticHexahedron_GetFace_11(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601AC67 RID: 109671
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiQuadraticQuadraticHexahedron_GetFaceArray_12(long faceId);

		/// <summary>
		/// Return the ids of the vertices defining edge/face (`edgeId`/`faceId').
		/// Ids are related to the cell, not to the dataset.
		///
		/// @note The return type changed. It used to be int*, it is now const vtkIdType*.
		/// This is so ids are unified between vtkCell and vtkPoints.
		/// </summary>
		// Token: 0x0601AC68 RID: 109672 RVA: 0x00254C80 File Offset: 0x00252E80
		public static IntPtr GetFaceArray(long faceId)
		{
			return vtkBiQuadraticQuadraticHexahedron.vtkBiQuadraticQuadraticHexahedron_GetFaceArray_12(faceId);
		}

		// Token: 0x0601AC69 RID: 109673
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiQuadraticQuadraticHexahedron_GetNumberOfEdges_13(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601AC6A RID: 109674 RVA: 0x00254C9C File Offset: 0x00252E9C
		public override int GetNumberOfEdges()
		{
			return vtkBiQuadraticQuadraticHexahedron.vtkBiQuadraticQuadraticHexahedron_GetNumberOfEdges_13(base.GetCppThis());
		}

		// Token: 0x0601AC6B RID: 109675
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiQuadraticQuadraticHexahedron_GetNumberOfFaces_14(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601AC6C RID: 109676 RVA: 0x00254CBC File Offset: 0x00252EBC
		public override int GetNumberOfFaces()
		{
			return vtkBiQuadraticQuadraticHexahedron.vtkBiQuadraticQuadraticHexahedron_GetNumberOfFaces_14(base.GetCppThis());
		}

		// Token: 0x0601AC6D RID: 109677
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBiQuadraticQuadraticHexahedron_GetNumberOfGenerationsFromBase_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AC6E RID: 109678 RVA: 0x00254CDC File Offset: 0x00252EDC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBiQuadraticQuadraticHexahedron.vtkBiQuadraticQuadraticHexahedron_GetNumberOfGenerationsFromBase_15(base.GetCppThis(), type);
		}

		// Token: 0x0601AC6F RID: 109679
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBiQuadraticQuadraticHexahedron_GetNumberOfGenerationsFromBaseType_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AC70 RID: 109680 RVA: 0x00254CFC File Offset: 0x00252EFC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBiQuadraticQuadraticHexahedron.vtkBiQuadraticQuadraticHexahedron_GetNumberOfGenerationsFromBaseType_16(type);
		}

		// Token: 0x0601AC71 RID: 109681
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiQuadraticQuadraticHexahedron_GetParametricCoords_17(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601AC72 RID: 109682 RVA: 0x00254D18 File Offset: 0x00252F18
		public override IntPtr GetParametricCoords()
		{
			return vtkBiQuadraticQuadraticHexahedron.vtkBiQuadraticQuadraticHexahedron_GetParametricCoords_17(base.GetCppThis());
		}

		// Token: 0x0601AC73 RID: 109683
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiQuadraticQuadraticHexahedron_InterpolateDerivs_18(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601AC74 RID: 109684 RVA: 0x00254D37 File Offset: 0x00252F37
		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkBiQuadraticQuadraticHexahedron.vtkBiQuadraticQuadraticHexahedron_InterpolateDerivs_18(base.GetCppThis(), pcoords, derivs);
		}

		// Token: 0x0601AC75 RID: 109685
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiQuadraticQuadraticHexahedron_InterpolateFunctions_19(HandleRef pThis, IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601AC76 RID: 109686 RVA: 0x00254D48 File Offset: 0x00252F48
		public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkBiQuadraticQuadraticHexahedron.vtkBiQuadraticQuadraticHexahedron_InterpolateFunctions_19(base.GetCppThis(), pcoords, weights);
		}

		// Token: 0x0601AC77 RID: 109687
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiQuadraticQuadraticHexahedron_InterpolationDerivs_20(IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Line-edge intersection. Intersection has to occur within [0,1] parametric
		/// coordinates and with specified tolerance.
		/// </summary>
		// Token: 0x0601AC78 RID: 109688 RVA: 0x00254D59 File Offset: 0x00252F59
		public static void InterpolationDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkBiQuadraticQuadraticHexahedron.vtkBiQuadraticQuadraticHexahedron_InterpolationDerivs_20(pcoords, derivs);
		}

		// Token: 0x0601AC79 RID: 109689
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiQuadraticQuadraticHexahedron_InterpolationFunctions_21(IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Line-edge intersection. Intersection has to occur within [0,1] parametric
		/// coordinates and with specified tolerance.
		/// </summary>
		// Token: 0x0601AC7A RID: 109690 RVA: 0x00254D64 File Offset: 0x00252F64
		public static void InterpolationFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkBiQuadraticQuadraticHexahedron.vtkBiQuadraticQuadraticHexahedron_InterpolationFunctions_21(pcoords, weights);
		}

		// Token: 0x0601AC7B RID: 109691
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiQuadraticQuadraticHexahedron_IntersectWithLine_22(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		/// <summary>
		/// Line-edge intersection. Intersection has to occur within [0,1] parametric
		/// coordinates and with specified tolerance.
		/// </summary>
		// Token: 0x0601AC7C RID: 109692 RVA: 0x00254D70 File Offset: 0x00252F70
		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkBiQuadraticQuadraticHexahedron.vtkBiQuadraticQuadraticHexahedron_IntersectWithLine_22(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		// Token: 0x0601AC7D RID: 109693
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiQuadraticQuadraticHexahedron_IsA_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AC7E RID: 109694 RVA: 0x00254D9C File Offset: 0x00252F9C
		public override int IsA(string type)
		{
			return vtkBiQuadraticQuadraticHexahedron.vtkBiQuadraticQuadraticHexahedron_IsA_23(base.GetCppThis(), type);
		}

		// Token: 0x0601AC7F RID: 109695
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiQuadraticQuadraticHexahedron_IsTypeOf_24([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AC80 RID: 109696 RVA: 0x00254DBC File Offset: 0x00252FBC
		public new static int IsTypeOf(string type)
		{
			return vtkBiQuadraticQuadraticHexahedron.vtkBiQuadraticQuadraticHexahedron_IsTypeOf_24(type);
		}

		// Token: 0x0601AC81 RID: 109697
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiQuadraticQuadraticHexahedron_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AC82 RID: 109698 RVA: 0x00254DD8 File Offset: 0x00252FD8
		public new vtkBiQuadraticQuadraticHexahedron NewInstance()
		{
			vtkBiQuadraticQuadraticHexahedron result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBiQuadraticQuadraticHexahedron.vtkBiQuadraticQuadraticHexahedron_NewInstance_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBiQuadraticQuadraticHexahedron)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601AC83 RID: 109699
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiQuadraticQuadraticHexahedron_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AC84 RID: 109700 RVA: 0x00254E34 File Offset: 0x00253034
		public new static vtkBiQuadraticQuadraticHexahedron SafeDownCast(vtkObjectBase o)
		{
			vtkBiQuadraticQuadraticHexahedron vtkBiQuadraticQuadraticHexahedron = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBiQuadraticQuadraticHexahedron.vtkBiQuadraticQuadraticHexahedron_SafeDownCast_27((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBiQuadraticQuadraticHexahedron = (vtkBiQuadraticQuadraticHexahedron)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBiQuadraticQuadraticHexahedron.Register(null);
				}
			}
			return vtkBiQuadraticQuadraticHexahedron;
		}

		// Token: 0x0601AC85 RID: 109701
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiQuadraticQuadraticHexahedron_TriangulateLocalIds_28(HandleRef pThis, int index, HandleRef ptIds);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601AC86 RID: 109702 RVA: 0x00254EB4 File Offset: 0x002530B4
		public override int TriangulateLocalIds(int index, vtkIdList ptIds)
		{
			return vtkBiQuadraticQuadraticHexahedron.vtkBiQuadraticQuadraticHexahedron_TriangulateLocalIds_28(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CF4 RID: 7412
		public new const string MRFullTypeName = "Kitware.VTK.vtkBiQuadraticQuadraticHexahedron";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CF5 RID: 7413
		public new static readonly string MRClassNameKey = "class vtkBiQuadraticQuadraticHexahedron";
	}
}
