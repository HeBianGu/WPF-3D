using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkQuadraticPyramid
	/// </summary>
	/// <remarks>
	///    cell represents a parabolic, 13-node isoparametric pyramid
	///
	/// vtkQuadraticPyramid is a concrete implementation of vtkNonLinearCell to
	/// represent a three-dimensional, 13-node isoparametric parabolic
	/// pyramid. The interpolation is the standard finite element, quadratic
	/// isoparametric shape function. The cell includes a mid-edge node. The
	/// ordering of the thirteen points defining the cell is point ids (0-4,5-12)
	/// where point ids 0-4 are the five corner vertices of the pyramid; followed
	/// by eight midedge nodes (5-12). Note that these midedge nodes lie
	/// on the edges defined by (0,1), (1,2), (2,3), (3,0), (0,4), (1,4), (2,4),
	/// (3,4), respectively. The parametric location of vertex #4 is [0, 0, 1].
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkQuadraticEdge vtkQuadraticTriangle vtkQuadraticTetra
	/// vtkQuadraticHexahedron vtkQuadraticQuad vtkQuadraticWedge
	///
	/// @par Thanks:
	/// The shape functions and derivatives could be implemented thanks to
	/// the report Pyramid Solid Elements Linear and Quadratic Iso-P Models
	/// From Center For Aerospace Structures
	/// </seealso>
	// Token: 0x02000AB0 RID: 2736
	public class vtkQuadraticPyramid : vtkNonLinearCell
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601CC48 RID: 117832 RVA: 0x00287B71 File Offset: 0x00285D71
		static vtkQuadraticPyramid()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkQuadraticPyramid.MRClassNameKey, Type.GetType("Kitware.VTK.vtkQuadraticPyramid"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601CC49 RID: 117833 RVA: 0x00287B99 File Offset: 0x00285D99
		public vtkQuadraticPyramid(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601CC4A RID: 117834
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticPyramid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CC4B RID: 117835 RVA: 0x00287BA8 File Offset: 0x00285DA8
		public new static vtkQuadraticPyramid New()
		{
			vtkQuadraticPyramid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadraticPyramid.vtkQuadraticPyramid_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuadraticPyramid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CC4C RID: 117836 RVA: 0x00287BFC File Offset: 0x00285DFC
		public vtkQuadraticPyramid() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkQuadraticPyramid.vtkQuadraticPyramid_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601CC4D RID: 117837 RVA: 0x00287C40 File Offset: 0x00285E40
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601CC4E RID: 117838
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticPyramid_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CC4F RID: 117839 RVA: 0x00287C4C File Offset: 0x00285E4C
		public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
		{
			return vtkQuadraticPyramid.vtkQuadraticPyramid_CellBoundary_01(base.GetCppThis(), subId, pcoords, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601CC50 RID: 117840
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticPyramid_Clip_02(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef tets, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

		/// <summary>
		/// Clip this quadratic triangle using scalar value provided. Like
		/// contouring, except that it cuts the triangle to produce linear
		/// triangles.
		/// </summary>
		// Token: 0x0601CC51 RID: 117841 RVA: 0x00287C84 File Offset: 0x00285E84
		public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray tets, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
		{
			vtkQuadraticPyramid.vtkQuadraticPyramid_Clip_02(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (tets == null) ? default(HandleRef) : tets.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis(), insideOut);
		}

		// Token: 0x0601CC52 RID: 117842
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticPyramid_Contour_03(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CC53 RID: 117843 RVA: 0x00287D40 File Offset: 0x00285F40
		public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
		{
			vtkQuadraticPyramid.vtkQuadraticPyramid_Contour_03(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis());
		}

		// Token: 0x0601CC54 RID: 117844
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticPyramid_Derivatives_04(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CC55 RID: 117845 RVA: 0x00287E28 File Offset: 0x00286028
		public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
		{
			vtkQuadraticPyramid.vtkQuadraticPyramid_Derivatives_04(base.GetCppThis(), subId, pcoords, values, dim, derivs);
		}

		// Token: 0x0601CC56 RID: 117846
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticPyramid_EvaluateLocation_05(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CC57 RID: 117847 RVA: 0x00287E3E File Offset: 0x0028603E
		public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
		{
			vtkQuadraticPyramid.vtkQuadraticPyramid_EvaluateLocation_05(base.GetCppThis(), ref subId, pcoords, x, weights);
		}

		// Token: 0x0601CC58 RID: 117848
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticPyramid_EvaluatePosition_06(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CC59 RID: 117849 RVA: 0x00287E54 File Offset: 0x00286054
		public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
		{
			return vtkQuadraticPyramid.vtkQuadraticPyramid_EvaluatePosition_06(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
		}

		// Token: 0x0601CC5A RID: 117850
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticPyramid_GetCellDimension_07(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CC5B RID: 117851 RVA: 0x00287E7C File Offset: 0x0028607C
		public override int GetCellDimension()
		{
			return vtkQuadraticPyramid.vtkQuadraticPyramid_GetCellDimension_07(base.GetCppThis());
		}

		// Token: 0x0601CC5C RID: 117852
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticPyramid_GetCellType_08(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CC5D RID: 117853 RVA: 0x00287E9C File Offset: 0x0028609C
		public override int GetCellType()
		{
			return vtkQuadraticPyramid.vtkQuadraticPyramid_GetCellType_08(base.GetCppThis());
		}

		// Token: 0x0601CC5E RID: 117854
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticPyramid_GetEdge_09(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CC5F RID: 117855 RVA: 0x00287EBC File Offset: 0x002860BC
		public override vtkCell GetEdge(int edgeId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadraticPyramid.vtkQuadraticPyramid_GetEdge_09(base.GetCppThis(), edgeId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601CC60 RID: 117856
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticPyramid_GetEdgeArray_10(long edgeId);

		/// <summary>
		/// Return the ids of the vertices defining edge/face (`edgeId`/`faceId').
		/// Ids are related to the cell, not to the dataset.
		///
		/// @note The return type changed. It used to be int*, it is now const vtkIdType*.
		/// This is so ids are unified between vtkCell and vtkPoints.
		/// </summary>
		// Token: 0x0601CC61 RID: 117857 RVA: 0x00287F2C File Offset: 0x0028612C
		public static IntPtr GetEdgeArray(long edgeId)
		{
			return vtkQuadraticPyramid.vtkQuadraticPyramid_GetEdgeArray_10(edgeId);
		}

		// Token: 0x0601CC62 RID: 117858
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticPyramid_GetFace_11(HandleRef pThis, int faceId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CC63 RID: 117859 RVA: 0x00287F48 File Offset: 0x00286148
		public override vtkCell GetFace(int faceId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadraticPyramid.vtkQuadraticPyramid_GetFace_11(base.GetCppThis(), faceId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601CC64 RID: 117860
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticPyramid_GetFaceArray_12(long faceId);

		/// <summary>
		/// Return the ids of the vertices defining edge/face (`edgeId`/`faceId').
		/// Ids are related to the cell, not to the dataset.
		///
		/// @note The return type changed. It used to be int*, it is now const vtkIdType*.
		/// This is so ids are unified between vtkCell and vtkPoints.
		/// </summary>
		// Token: 0x0601CC65 RID: 117861 RVA: 0x00287FB8 File Offset: 0x002861B8
		public static IntPtr GetFaceArray(long faceId)
		{
			return vtkQuadraticPyramid.vtkQuadraticPyramid_GetFaceArray_12(faceId);
		}

		// Token: 0x0601CC66 RID: 117862
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticPyramid_GetNumberOfEdges_13(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CC67 RID: 117863 RVA: 0x00287FD4 File Offset: 0x002861D4
		public override int GetNumberOfEdges()
		{
			return vtkQuadraticPyramid.vtkQuadraticPyramid_GetNumberOfEdges_13(base.GetCppThis());
		}

		// Token: 0x0601CC68 RID: 117864
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticPyramid_GetNumberOfFaces_14(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CC69 RID: 117865 RVA: 0x00287FF4 File Offset: 0x002861F4
		public override int GetNumberOfFaces()
		{
			return vtkQuadraticPyramid.vtkQuadraticPyramid_GetNumberOfFaces_14(base.GetCppThis());
		}

		// Token: 0x0601CC6A RID: 117866
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkQuadraticPyramid_GetNumberOfGenerationsFromBase_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CC6B RID: 117867 RVA: 0x00288014 File Offset: 0x00286214
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkQuadraticPyramid.vtkQuadraticPyramid_GetNumberOfGenerationsFromBase_15(base.GetCppThis(), type);
		}

		// Token: 0x0601CC6C RID: 117868
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkQuadraticPyramid_GetNumberOfGenerationsFromBaseType_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CC6D RID: 117869 RVA: 0x00288034 File Offset: 0x00286234
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkQuadraticPyramid.vtkQuadraticPyramid_GetNumberOfGenerationsFromBaseType_16(type);
		}

		// Token: 0x0601CC6E RID: 117870
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticPyramid_GetParametricCenter_17(HandleRef pThis, IntPtr pcoords);

		/// <summary>
		/// Return the center of the quadratic pyramid in parametric coordinates.
		/// </summary>
		// Token: 0x0601CC6F RID: 117871 RVA: 0x00288050 File Offset: 0x00286250
		public override int GetParametricCenter(IntPtr pcoords)
		{
			return vtkQuadraticPyramid.vtkQuadraticPyramid_GetParametricCenter_17(base.GetCppThis(), pcoords);
		}

		// Token: 0x0601CC70 RID: 117872
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticPyramid_GetParametricCoords_18(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CC71 RID: 117873 RVA: 0x00288070 File Offset: 0x00286270
		public override IntPtr GetParametricCoords()
		{
			return vtkQuadraticPyramid.vtkQuadraticPyramid_GetParametricCoords_18(base.GetCppThis());
		}

		// Token: 0x0601CC72 RID: 117874
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticPyramid_InterpolateDerivs_19(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601CC73 RID: 117875 RVA: 0x0028808F File Offset: 0x0028628F
		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkQuadraticPyramid.vtkQuadraticPyramid_InterpolateDerivs_19(base.GetCppThis(), pcoords, derivs);
		}

		// Token: 0x0601CC74 RID: 117876
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticPyramid_InterpolateFunctions_20(HandleRef pThis, IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601CC75 RID: 117877 RVA: 0x002880A0 File Offset: 0x002862A0
		public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkQuadraticPyramid.vtkQuadraticPyramid_InterpolateFunctions_20(base.GetCppThis(), pcoords, weights);
		}

		// Token: 0x0601CC76 RID: 117878
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticPyramid_InterpolationDerivs_21(IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Return the center of the quadratic pyramid in parametric coordinates.
		/// </summary>
		// Token: 0x0601CC77 RID: 117879 RVA: 0x002880B1 File Offset: 0x002862B1
		public static void InterpolationDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkQuadraticPyramid.vtkQuadraticPyramid_InterpolationDerivs_21(pcoords, derivs);
		}

		// Token: 0x0601CC78 RID: 117880
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticPyramid_InterpolationFunctions_22(IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Return the center of the quadratic pyramid in parametric coordinates.
		/// </summary>
		// Token: 0x0601CC79 RID: 117881 RVA: 0x002880BC File Offset: 0x002862BC
		public static void InterpolationFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkQuadraticPyramid.vtkQuadraticPyramid_InterpolationFunctions_22(pcoords, weights);
		}

		// Token: 0x0601CC7A RID: 117882
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticPyramid_IntersectWithLine_23(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		/// <summary>
		/// Line-edge intersection. Intersection has to occur within [0,1] parametric
		/// coordinates and with specified tolerance.
		/// </summary>
		// Token: 0x0601CC7B RID: 117883 RVA: 0x002880C8 File Offset: 0x002862C8
		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkQuadraticPyramid.vtkQuadraticPyramid_IntersectWithLine_23(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		// Token: 0x0601CC7C RID: 117884
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticPyramid_IsA_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CC7D RID: 117885 RVA: 0x002880F4 File Offset: 0x002862F4
		public override int IsA(string type)
		{
			return vtkQuadraticPyramid.vtkQuadraticPyramid_IsA_24(base.GetCppThis(), type);
		}

		// Token: 0x0601CC7E RID: 117886
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticPyramid_IsTypeOf_25([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CC7F RID: 117887 RVA: 0x00288114 File Offset: 0x00286314
		public new static int IsTypeOf(string type)
		{
			return vtkQuadraticPyramid.vtkQuadraticPyramid_IsTypeOf_25(type);
		}

		// Token: 0x0601CC80 RID: 117888
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticPyramid_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CC81 RID: 117889 RVA: 0x00288130 File Offset: 0x00286330
		public new vtkQuadraticPyramid NewInstance()
		{
			vtkQuadraticPyramid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadraticPyramid.vtkQuadraticPyramid_NewInstance_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuadraticPyramid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601CC82 RID: 117890
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticPyramid_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CC83 RID: 117891 RVA: 0x0028818C File Offset: 0x0028638C
		public new static vtkQuadraticPyramid SafeDownCast(vtkObjectBase o)
		{
			vtkQuadraticPyramid vtkQuadraticPyramid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadraticPyramid.vtkQuadraticPyramid_SafeDownCast_28((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkQuadraticPyramid = (vtkQuadraticPyramid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkQuadraticPyramid.Register(null);
				}
			}
			return vtkQuadraticPyramid;
		}

		// Token: 0x0601CC84 RID: 117892
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticPyramid_TriangulateLocalIds_29(HandleRef pThis, int index, HandleRef ptIds);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CC85 RID: 117893 RVA: 0x0028820C File Offset: 0x0028640C
		public override int TriangulateLocalIds(int index, vtkIdList ptIds)
		{
			return vtkQuadraticPyramid.vtkQuadraticPyramid_TriangulateLocalIds_29(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E69 RID: 7785
		public new const string MRFullTypeName = "Kitware.VTK.vtkQuadraticPyramid";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E6A RID: 7786
		public new static readonly string MRClassNameKey = "class vtkQuadraticPyramid";
	}
}
