using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVertex
	/// </summary>
	/// <remarks>
	///    a cell that represents a 3D point
	///
	/// vtkVertex is a concrete implementation of vtkCell to represent a 3D point.
	/// </remarks>
	// Token: 0x02000AE0 RID: 2784
	public class vtkVertex : vtkCell
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D5C2 RID: 120258 RVA: 0x002972DB File Offset: 0x002954DB
		static vtkVertex()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVertex.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVertex"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D5C3 RID: 120259 RVA: 0x00297303 File Offset: 0x00295503
		public vtkVertex(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601D5C4 RID: 120260
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVertex_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D5C5 RID: 120261 RVA: 0x00297314 File Offset: 0x00295514
		public new static vtkVertex New()
		{
			vtkVertex result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVertex.vtkVertex_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVertex)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D5C6 RID: 120262 RVA: 0x00297368 File Offset: 0x00295568
		public vtkVertex() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkVertex.vtkVertex_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D5C7 RID: 120263 RVA: 0x002973AC File Offset: 0x002955AC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D5C8 RID: 120264
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVertex_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

		/// <summary>
		/// Given parametric coordinates of a point, return the closest cell
		/// boundary, and whether the point is inside or outside of the cell. The
		/// cell boundary is defined by a list of points (pts) that specify a vertex
		/// (1D cell).  If the return value of the method is != 0, then the point is
		/// inside the cell.
		/// </summary>
		// Token: 0x0601D5C9 RID: 120265 RVA: 0x002973B8 File Offset: 0x002955B8
		public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
		{
			return vtkVertex.vtkVertex_CellBoundary_01(base.GetCppThis(), subId, pcoords, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601D5CA RID: 120266
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVertex_Clip_02(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef pts, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D5CB RID: 120267 RVA: 0x002973F0 File Offset: 0x002955F0
		public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray pts, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
		{
			vtkVertex.vtkVertex_Clip_02(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (pts == null) ? default(HandleRef) : pts.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis(), insideOut);
		}

		// Token: 0x0601D5CC RID: 120268
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVertex_Contour_03(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts1, HandleRef lines, HandleRef verts2, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

		/// <summary>
		/// Generate contouring primitives. The scalar list cellScalars are
		/// scalar values at each cell point. The point locator is essentially a
		/// points list that merges points as they are inserted (i.e., prevents
		/// duplicates).
		/// </summary>
		// Token: 0x0601D5CD RID: 120269 RVA: 0x002974AC File Offset: 0x002956AC
		public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts1, vtkCellArray lines, vtkCellArray verts2, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
		{
			vtkVertex.vtkVertex_Contour_03(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts1 == null) ? default(HandleRef) : verts1.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (verts2 == null) ? default(HandleRef) : verts2.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis());
		}

		// Token: 0x0601D5CE RID: 120270
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVertex_Derivatives_04(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

		/// <summary>
		/// Get the derivative of the vertex. Returns (0.0, 0.0, 0.0) for all
		/// dimensions.
		/// </summary>
		// Token: 0x0601D5CF RID: 120271 RVA: 0x00297594 File Offset: 0x00295794
		public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
		{
			vtkVertex.vtkVertex_Derivatives_04(base.GetCppThis(), subId, pcoords, values, dim, derivs);
		}

		// Token: 0x0601D5D0 RID: 120272
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVertex_EvaluateLocation_05(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D5D1 RID: 120273 RVA: 0x002975AA File Offset: 0x002957AA
		public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
		{
			vtkVertex.vtkVertex_EvaluateLocation_05(base.GetCppThis(), ref subId, pcoords, x, weights);
		}

		// Token: 0x0601D5D2 RID: 120274
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVertex_EvaluatePosition_06(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D5D3 RID: 120275 RVA: 0x002975C0 File Offset: 0x002957C0
		public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
		{
			return vtkVertex.vtkVertex_EvaluatePosition_06(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
		}

		// Token: 0x0601D5D4 RID: 120276
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVertex_GetCellDimension_07(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D5D5 RID: 120277 RVA: 0x002975E8 File Offset: 0x002957E8
		public override int GetCellDimension()
		{
			return vtkVertex.vtkVertex_GetCellDimension_07(base.GetCppThis());
		}

		// Token: 0x0601D5D6 RID: 120278
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVertex_GetCellType_08(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D5D7 RID: 120279 RVA: 0x00297608 File Offset: 0x00295808
		public override int GetCellType()
		{
			return vtkVertex.vtkVertex_GetCellType_08(base.GetCppThis());
		}

		// Token: 0x0601D5D8 RID: 120280
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVertex_GetEdge_09(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D5D9 RID: 120281 RVA: 0x00297628 File Offset: 0x00295828
		public override vtkCell GetEdge(int arg0)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVertex.vtkVertex_GetEdge_09(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601D5DA RID: 120282
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVertex_GetFace_10(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D5DB RID: 120283 RVA: 0x00297698 File Offset: 0x00295898
		public override vtkCell GetFace(int arg0)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVertex.vtkVertex_GetFace_10(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601D5DC RID: 120284
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVertex_GetNumberOfEdges_11(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D5DD RID: 120285 RVA: 0x00297708 File Offset: 0x00295908
		public override int GetNumberOfEdges()
		{
			return vtkVertex.vtkVertex_GetNumberOfEdges_11(base.GetCppThis());
		}

		// Token: 0x0601D5DE RID: 120286
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVertex_GetNumberOfFaces_12(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D5DF RID: 120287 RVA: 0x00297728 File Offset: 0x00295928
		public override int GetNumberOfFaces()
		{
			return vtkVertex.vtkVertex_GetNumberOfFaces_12(base.GetCppThis());
		}

		// Token: 0x0601D5E0 RID: 120288
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVertex_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D5E1 RID: 120289 RVA: 0x00297748 File Offset: 0x00295948
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVertex.vtkVertex_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x0601D5E2 RID: 120290
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVertex_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D5E3 RID: 120291 RVA: 0x00297768 File Offset: 0x00295968
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVertex.vtkVertex_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x0601D5E4 RID: 120292
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVertex_GetParametricCenter_15(HandleRef pThis, IntPtr pcoords);

		/// <summary>
		/// Return the center of the triangle in parametric coordinates.
		/// </summary>
		// Token: 0x0601D5E5 RID: 120293 RVA: 0x00297784 File Offset: 0x00295984
		public override int GetParametricCenter(IntPtr pcoords)
		{
			return vtkVertex.vtkVertex_GetParametricCenter_15(base.GetCppThis(), pcoords);
		}

		// Token: 0x0601D5E6 RID: 120294
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVertex_GetParametricCoords_16(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D5E7 RID: 120295 RVA: 0x002977A4 File Offset: 0x002959A4
		public override IntPtr GetParametricCoords()
		{
			return vtkVertex.vtkVertex_GetParametricCoords_16(base.GetCppThis());
		}

		// Token: 0x0601D5E8 RID: 120296
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVertex_Inflate_17(HandleRef pThis, double arg0);

		/// <summary>
		/// This method does nothing.
		///
		/// \return 1 if inflation was successful, 0 if no inflation was performed
		/// </summary>
		// Token: 0x0601D5E9 RID: 120297 RVA: 0x002977C4 File Offset: 0x002959C4
		public override int Inflate(double arg0)
		{
			return vtkVertex.vtkVertex_Inflate_17(base.GetCppThis(), arg0);
		}

		// Token: 0x0601D5EA RID: 120298
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVertex_InterpolateDerivs_18(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601D5EB RID: 120299 RVA: 0x002977E4 File Offset: 0x002959E4
		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkVertex.vtkVertex_InterpolateDerivs_18(base.GetCppThis(), pcoords, derivs);
		}

		// Token: 0x0601D5EC RID: 120300
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVertex_InterpolateFunctions_19(HandleRef pThis, IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601D5ED RID: 120301 RVA: 0x002977F5 File Offset: 0x002959F5
		public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkVertex.vtkVertex_InterpolateFunctions_19(base.GetCppThis(), pcoords, weights);
		}

		// Token: 0x0601D5EE RID: 120302
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVertex_InterpolationDerivs_20(IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Get the derivative of the vertex. Returns (0.0, 0.0, 0.0) for all
		/// dimensions.
		/// </summary>
		// Token: 0x0601D5EF RID: 120303 RVA: 0x00297806 File Offset: 0x00295A06
		public static void InterpolationDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkVertex.vtkVertex_InterpolationDerivs_20(pcoords, derivs);
		}

		// Token: 0x0601D5F0 RID: 120304
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVertex_InterpolationFunctions_21(IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Get the derivative of the vertex. Returns (0.0, 0.0, 0.0) for all
		/// dimensions.
		/// </summary>
		// Token: 0x0601D5F1 RID: 120305 RVA: 0x00297811 File Offset: 0x00295A11
		public static void InterpolationFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkVertex.vtkVertex_InterpolationFunctions_21(pcoords, weights);
		}

		// Token: 0x0601D5F2 RID: 120306
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVertex_IntersectWithLine_22(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		/// <summary>
		/// Intersect with a ray. Return parametric coordinates (both line and cell)
		/// and global intersection coordinates, given ray definition and tolerance.
		/// The method returns non-zero value if intersection occurs.
		/// </summary>
		// Token: 0x0601D5F3 RID: 120307 RVA: 0x0029781C File Offset: 0x00295A1C
		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkVertex.vtkVertex_IntersectWithLine_22(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		// Token: 0x0601D5F4 RID: 120308
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVertex_IsA_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D5F5 RID: 120309 RVA: 0x00297848 File Offset: 0x00295A48
		public override int IsA(string type)
		{
			return vtkVertex.vtkVertex_IsA_23(base.GetCppThis(), type);
		}

		// Token: 0x0601D5F6 RID: 120310
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVertex_IsTypeOf_24([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D5F7 RID: 120311 RVA: 0x00297868 File Offset: 0x00295A68
		public new static int IsTypeOf(string type)
		{
			return vtkVertex.vtkVertex_IsTypeOf_24(type);
		}

		// Token: 0x0601D5F8 RID: 120312
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVertex_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D5F9 RID: 120313 RVA: 0x00297884 File Offset: 0x00295A84
		public new vtkVertex NewInstance()
		{
			vtkVertex result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVertex.vtkVertex_NewInstance_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVertex)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601D5FA RID: 120314
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVertex_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D5FB RID: 120315 RVA: 0x002978E0 File Offset: 0x00295AE0
		public new static vtkVertex SafeDownCast(vtkObjectBase o)
		{
			vtkVertex vtkVertex = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVertex.vtkVertex_SafeDownCast_27((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVertex = (vtkVertex)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVertex.Register(null);
				}
			}
			return vtkVertex;
		}

		// Token: 0x0601D5FC RID: 120316
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVertex_TriangulateLocalIds_28(HandleRef pThis, int index, HandleRef ptIds);

		/// <summary>
		/// Triangulate the vertex. This method fills pts and ptIds with information
		/// from the only point in the vertex.
		/// </summary>
		// Token: 0x0601D5FD RID: 120317 RVA: 0x00297960 File Offset: 0x00295B60
		public override int TriangulateLocalIds(int index, vtkIdList ptIds)
		{
			return vtkVertex.vtkVertex_TriangulateLocalIds_28(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EE7 RID: 7911
		public new const string MRFullTypeName = "Kitware.VTK.vtkVertex";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EE8 RID: 7912
		public new static readonly string MRClassNameKey = "class vtkVertex";
	}
}
