using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkQuadraticQuad
	/// </summary>
	/// <remarks>
	///    cell represents a parabolic, 8-node isoparametric quad
	///
	/// vtkQuadraticQuad is a concrete implementation of vtkNonLinearCell to
	/// represent a two-dimensional, 8-node isoparametric parabolic quadrilateral
	/// element. The interpolation is the standard finite element, quadratic
	/// isoparametric shape function. The cell includes a mid-edge node for each
	/// of the four edges of the cell. The ordering of the eight points defining
	/// the cell are point ids (0-3,4-7) where ids 0-3 define the four corner
	/// vertices of the quad; ids 4-7 define the midedge nodes (0,1), (1,2),
	/// (2,3), (3,0).
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkQuadraticEdge vtkQuadraticTriangle vtkQuadraticTetra
	/// vtkQuadraticHexahedron vtkQuadraticWedge vtkQuadraticPyramid
	/// </seealso>
	// Token: 0x02000AB1 RID: 2737
	public class vtkQuadraticQuad : vtkNonLinearCell
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601CC86 RID: 117894 RVA: 0x00288241 File Offset: 0x00286441
		static vtkQuadraticQuad()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkQuadraticQuad.MRClassNameKey, Type.GetType("Kitware.VTK.vtkQuadraticQuad"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601CC87 RID: 117895 RVA: 0x00288269 File Offset: 0x00286469
		public vtkQuadraticQuad(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601CC88 RID: 117896
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticQuad_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CC89 RID: 117897 RVA: 0x00288278 File Offset: 0x00286478
		public new static vtkQuadraticQuad New()
		{
			vtkQuadraticQuad result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadraticQuad.vtkQuadraticQuad_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuadraticQuad)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CC8A RID: 117898 RVA: 0x002882CC File Offset: 0x002864CC
		public vtkQuadraticQuad() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkQuadraticQuad.vtkQuadraticQuad_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601CC8B RID: 117899 RVA: 0x00288310 File Offset: 0x00286510
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601CC8C RID: 117900
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticQuad_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CC8D RID: 117901 RVA: 0x0028831C File Offset: 0x0028651C
		public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
		{
			return vtkQuadraticQuad.vtkQuadraticQuad_CellBoundary_01(base.GetCppThis(), subId, pcoords, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601CC8E RID: 117902
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticQuad_Clip_02(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

		/// <summary>
		/// Clip this quadratic quad using scalar value provided. Like contouring,
		/// except that it cuts the quad to produce linear triangles.
		/// </summary>
		// Token: 0x0601CC8F RID: 117903 RVA: 0x00288354 File Offset: 0x00286554
		public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
		{
			vtkQuadraticQuad.vtkQuadraticQuad_Clip_02(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis(), insideOut);
		}

		// Token: 0x0601CC90 RID: 117904
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticQuad_Contour_03(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CC91 RID: 117905 RVA: 0x00288410 File Offset: 0x00286610
		public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
		{
			vtkQuadraticQuad.vtkQuadraticQuad_Contour_03(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis());
		}

		// Token: 0x0601CC92 RID: 117906
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticQuad_Derivatives_04(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CC93 RID: 117907 RVA: 0x002884F8 File Offset: 0x002866F8
		public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
		{
			vtkQuadraticQuad.vtkQuadraticQuad_Derivatives_04(base.GetCppThis(), subId, pcoords, values, dim, derivs);
		}

		// Token: 0x0601CC94 RID: 117908
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticQuad_EvaluateLocation_05(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CC95 RID: 117909 RVA: 0x0028850E File Offset: 0x0028670E
		public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
		{
			vtkQuadraticQuad.vtkQuadraticQuad_EvaluateLocation_05(base.GetCppThis(), ref subId, pcoords, x, weights);
		}

		// Token: 0x0601CC96 RID: 117910
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticQuad_EvaluatePosition_06(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CC97 RID: 117911 RVA: 0x00288524 File Offset: 0x00286724
		public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
		{
			return vtkQuadraticQuad.vtkQuadraticQuad_EvaluatePosition_06(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
		}

		// Token: 0x0601CC98 RID: 117912
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticQuad_GetCellDimension_07(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CC99 RID: 117913 RVA: 0x0028854C File Offset: 0x0028674C
		public override int GetCellDimension()
		{
			return vtkQuadraticQuad.vtkQuadraticQuad_GetCellDimension_07(base.GetCppThis());
		}

		// Token: 0x0601CC9A RID: 117914
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticQuad_GetCellType_08(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CC9B RID: 117915 RVA: 0x0028856C File Offset: 0x0028676C
		public override int GetCellType()
		{
			return vtkQuadraticQuad.vtkQuadraticQuad_GetCellType_08(base.GetCppThis());
		}

		// Token: 0x0601CC9C RID: 117916
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticQuad_GetEdge_09(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CC9D RID: 117917 RVA: 0x0028858C File Offset: 0x0028678C
		public override vtkCell GetEdge(int arg0)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadraticQuad.vtkQuadraticQuad_GetEdge_09(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601CC9E RID: 117918
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticQuad_GetFace_10(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CC9F RID: 117919 RVA: 0x002885FC File Offset: 0x002867FC
		public override vtkCell GetFace(int arg0)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadraticQuad.vtkQuadraticQuad_GetFace_10(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601CCA0 RID: 117920
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticQuad_GetNumberOfEdges_11(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CCA1 RID: 117921 RVA: 0x0028866C File Offset: 0x0028686C
		public override int GetNumberOfEdges()
		{
			return vtkQuadraticQuad.vtkQuadraticQuad_GetNumberOfEdges_11(base.GetCppThis());
		}

		// Token: 0x0601CCA2 RID: 117922
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticQuad_GetNumberOfFaces_12(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CCA3 RID: 117923 RVA: 0x0028868C File Offset: 0x0028688C
		public override int GetNumberOfFaces()
		{
			return vtkQuadraticQuad.vtkQuadraticQuad_GetNumberOfFaces_12(base.GetCppThis());
		}

		// Token: 0x0601CCA4 RID: 117924
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkQuadraticQuad_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CCA5 RID: 117925 RVA: 0x002886AC File Offset: 0x002868AC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkQuadraticQuad.vtkQuadraticQuad_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x0601CCA6 RID: 117926
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkQuadraticQuad_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CCA7 RID: 117927 RVA: 0x002886CC File Offset: 0x002868CC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkQuadraticQuad.vtkQuadraticQuad_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x0601CCA8 RID: 117928
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticQuad_GetParametricCenter_15(HandleRef pThis, IntPtr pcoords);

		/// <summary>
		/// Return the center of the pyramid in parametric coordinates.
		/// </summary>
		// Token: 0x0601CCA9 RID: 117929 RVA: 0x002886E8 File Offset: 0x002868E8
		public override int GetParametricCenter(IntPtr pcoords)
		{
			return vtkQuadraticQuad.vtkQuadraticQuad_GetParametricCenter_15(base.GetCppThis(), pcoords);
		}

		// Token: 0x0601CCAA RID: 117930
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticQuad_GetParametricCoords_16(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CCAB RID: 117931 RVA: 0x00288708 File Offset: 0x00286908
		public override IntPtr GetParametricCoords()
		{
			return vtkQuadraticQuad.vtkQuadraticQuad_GetParametricCoords_16(base.GetCppThis());
		}

		// Token: 0x0601CCAC RID: 117932
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticQuad_InterpolateDerivs_17(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601CCAD RID: 117933 RVA: 0x00288727 File Offset: 0x00286927
		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkQuadraticQuad.vtkQuadraticQuad_InterpolateDerivs_17(base.GetCppThis(), pcoords, derivs);
		}

		// Token: 0x0601CCAE RID: 117934
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticQuad_InterpolateFunctions_18(HandleRef pThis, IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601CCAF RID: 117935 RVA: 0x00288738 File Offset: 0x00286938
		public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkQuadraticQuad.vtkQuadraticQuad_InterpolateFunctions_18(base.GetCppThis(), pcoords, weights);
		}

		// Token: 0x0601CCB0 RID: 117936
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticQuad_InterpolationDerivs_19(IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Return the center of the pyramid in parametric coordinates.
		/// </summary>
		// Token: 0x0601CCB1 RID: 117937 RVA: 0x00288749 File Offset: 0x00286949
		public static void InterpolationDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkQuadraticQuad.vtkQuadraticQuad_InterpolationDerivs_19(pcoords, derivs);
		}

		// Token: 0x0601CCB2 RID: 117938
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadraticQuad_InterpolationFunctions_20(IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Return the center of the pyramid in parametric coordinates.
		/// </summary>
		// Token: 0x0601CCB3 RID: 117939 RVA: 0x00288754 File Offset: 0x00286954
		public static void InterpolationFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkQuadraticQuad.vtkQuadraticQuad_InterpolationFunctions_20(pcoords, weights);
		}

		// Token: 0x0601CCB4 RID: 117940
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticQuad_IntersectWithLine_21(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		/// <summary>
		/// Line-edge intersection. Intersection has to occur within [0,1] parametric
		/// coordinates and with specified tolerance.
		/// </summary>
		// Token: 0x0601CCB5 RID: 117941 RVA: 0x00288760 File Offset: 0x00286960
		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkQuadraticQuad.vtkQuadraticQuad_IntersectWithLine_21(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		// Token: 0x0601CCB6 RID: 117942
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticQuad_IsA_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CCB7 RID: 117943 RVA: 0x0028878C File Offset: 0x0028698C
		public override int IsA(string type)
		{
			return vtkQuadraticQuad.vtkQuadraticQuad_IsA_22(base.GetCppThis(), type);
		}

		// Token: 0x0601CCB8 RID: 117944
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticQuad_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CCB9 RID: 117945 RVA: 0x002887AC File Offset: 0x002869AC
		public new static int IsTypeOf(string type)
		{
			return vtkQuadraticQuad.vtkQuadraticQuad_IsTypeOf_23(type);
		}

		// Token: 0x0601CCBA RID: 117946
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticQuad_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CCBB RID: 117947 RVA: 0x002887C8 File Offset: 0x002869C8
		public new vtkQuadraticQuad NewInstance()
		{
			vtkQuadraticQuad result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadraticQuad.vtkQuadraticQuad_NewInstance_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuadraticQuad)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601CCBC RID: 117948
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraticQuad_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CCBD RID: 117949 RVA: 0x00288824 File Offset: 0x00286A24
		public new static vtkQuadraticQuad SafeDownCast(vtkObjectBase o)
		{
			vtkQuadraticQuad vtkQuadraticQuad = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadraticQuad.vtkQuadraticQuad_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkQuadraticQuad = (vtkQuadraticQuad)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkQuadraticQuad.Register(null);
				}
			}
			return vtkQuadraticQuad;
		}

		// Token: 0x0601CCBE RID: 117950
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraticQuad_TriangulateLocalIds_27(HandleRef pThis, int index, HandleRef ptIds);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601CCBF RID: 117951 RVA: 0x002888A4 File Offset: 0x00286AA4
		public override int TriangulateLocalIds(int index, vtkIdList ptIds)
		{
			return vtkQuadraticQuad.vtkQuadraticQuad_TriangulateLocalIds_27(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E6B RID: 7787
		public new const string MRFullTypeName = "Kitware.VTK.vtkQuadraticQuad";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E6C RID: 7788
		public new static readonly string MRClassNameKey = "class vtkQuadraticQuad";
	}
}
