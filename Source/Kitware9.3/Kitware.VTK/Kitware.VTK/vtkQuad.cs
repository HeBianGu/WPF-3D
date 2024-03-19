using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkQuad
	/// </summary>
	/// <remarks>
	///    a cell that represents a 2D quadrilateral
	///
	/// vtkQuad is a concrete implementation of vtkCell to represent a 2D
	/// quadrilateral. vtkQuad is defined by the four points (0,1,2,3) in
	/// counterclockwise order. vtkQuad uses the standard isoparametric
	/// interpolation functions for a linear quadrilateral.
	/// </remarks>
	// Token: 0x02000AAA RID: 2730
	public class vtkQuad : vtkCell
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601CAD6 RID: 117462 RVA: 0x002851C5 File Offset: 0x002833C5
		static vtkQuad()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkQuad.MRClassNameKey, Type.GetType("Kitware.VTK.vtkQuad"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601CAD7 RID: 117463 RVA: 0x002851ED File Offset: 0x002833ED
		public vtkQuad(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601CAD8 RID: 117464
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuad_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CAD9 RID: 117465 RVA: 0x002851FC File Offset: 0x002833FC
		public new static vtkQuad New()
		{
			vtkQuad result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuad.vtkQuad_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuad)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CADA RID: 117466 RVA: 0x00285250 File Offset: 0x00283450
		public vtkQuad() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkQuad.vtkQuad_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601CADB RID: 117467 RVA: 0x00285294 File Offset: 0x00283494
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601CADC RID: 117468
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuad_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601CADD RID: 117469 RVA: 0x002852A0 File Offset: 0x002834A0
		public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
		{
			return vtkQuad.vtkQuad_CellBoundary_01(base.GetCppThis(), subId, pcoords, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601CADE RID: 117470
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuad_Clip_02(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

		/// <summary>
		/// Clip this quad using scalar value provided. Like contouring, except
		/// that it cuts the quad to produce other quads and/or triangles.
		/// </summary>
		// Token: 0x0601CADF RID: 117471 RVA: 0x002852D8 File Offset: 0x002834D8
		public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
		{
			vtkQuad.vtkQuad_Clip_02(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis(), insideOut);
		}

		// Token: 0x0601CAE0 RID: 117472
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuad_Contour_03(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601CAE1 RID: 117473 RVA: 0x00285394 File Offset: 0x00283594
		public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
		{
			vtkQuad.vtkQuad_Contour_03(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis());
		}

		// Token: 0x0601CAE2 RID: 117474
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuad_Derivatives_04(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601CAE3 RID: 117475 RVA: 0x0028547C File Offset: 0x0028367C
		public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
		{
			vtkQuad.vtkQuad_Derivatives_04(base.GetCppThis(), subId, pcoords, values, dim, derivs);
		}

		// Token: 0x0601CAE4 RID: 117476
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuad_EvaluateLocation_05(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601CAE5 RID: 117477 RVA: 0x00285492 File Offset: 0x00283692
		public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
		{
			vtkQuad.vtkQuad_EvaluateLocation_05(base.GetCppThis(), ref subId, pcoords, x, weights);
		}

		// Token: 0x0601CAE6 RID: 117478
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuad_EvaluatePosition_06(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601CAE7 RID: 117479 RVA: 0x002854A8 File Offset: 0x002836A8
		public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
		{
			return vtkQuad.vtkQuad_EvaluatePosition_06(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
		}

		// Token: 0x0601CAE8 RID: 117480
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuad_GetCellDimension_07(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601CAE9 RID: 117481 RVA: 0x002854D0 File Offset: 0x002836D0
		public override int GetCellDimension()
		{
			return vtkQuad.vtkQuad_GetCellDimension_07(base.GetCppThis());
		}

		// Token: 0x0601CAEA RID: 117482
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuad_GetCellType_08(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601CAEB RID: 117483 RVA: 0x002854F0 File Offset: 0x002836F0
		public override int GetCellType()
		{
			return vtkQuad.vtkQuad_GetCellType_08(base.GetCppThis());
		}

		// Token: 0x0601CAEC RID: 117484
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuad_GetEdge_09(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601CAED RID: 117485 RVA: 0x00285510 File Offset: 0x00283710
		public override vtkCell GetEdge(int edgeId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuad.vtkQuad_GetEdge_09(base.GetCppThis(), edgeId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601CAEE RID: 117486
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuad_GetEdgeArray_10(HandleRef pThis, long edgeId);

		/// <summary>
		/// Return the ids of the vertices defining edge (`edgeId`).
		/// Ids are related to the cell, not to the dataset.
		///
		/// @note The return type changed. It used to be int*, it is now const vtkIdType*.
		/// This is so ids are unified between vtkCell and vtkPoints, and so vtkCell ids
		/// can be used as inputs in algorithms such as vtkPolygon::ComputeNormal.
		/// </summary>
		// Token: 0x0601CAEF RID: 117487 RVA: 0x00285580 File Offset: 0x00283780
		public IntPtr GetEdgeArray(long edgeId)
		{
			return vtkQuad.vtkQuad_GetEdgeArray_10(base.GetCppThis(), edgeId);
		}

		// Token: 0x0601CAF0 RID: 117488
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuad_GetFace_11(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601CAF1 RID: 117489 RVA: 0x002855A0 File Offset: 0x002837A0
		public override vtkCell GetFace(int arg0)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuad.vtkQuad_GetFace_11(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601CAF2 RID: 117490
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuad_GetNumberOfEdges_12(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601CAF3 RID: 117491 RVA: 0x00285610 File Offset: 0x00283810
		public override int GetNumberOfEdges()
		{
			return vtkQuad.vtkQuad_GetNumberOfEdges_12(base.GetCppThis());
		}

		// Token: 0x0601CAF4 RID: 117492
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuad_GetNumberOfFaces_13(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601CAF5 RID: 117493 RVA: 0x00285630 File Offset: 0x00283830
		public override int GetNumberOfFaces()
		{
			return vtkQuad.vtkQuad_GetNumberOfFaces_13(base.GetCppThis());
		}

		// Token: 0x0601CAF6 RID: 117494
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkQuad_GetNumberOfGenerationsFromBase_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CAF7 RID: 117495 RVA: 0x00285650 File Offset: 0x00283850
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkQuad.vtkQuad_GetNumberOfGenerationsFromBase_14(base.GetCppThis(), type);
		}

		// Token: 0x0601CAF8 RID: 117496
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkQuad_GetNumberOfGenerationsFromBaseType_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CAF9 RID: 117497 RVA: 0x00285670 File Offset: 0x00283870
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkQuad.vtkQuad_GetNumberOfGenerationsFromBaseType_15(type);
		}

		// Token: 0x0601CAFA RID: 117498
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuad_GetParametricCenter_16(HandleRef pThis, IntPtr pcoords);

		/// <summary>
		/// Return the center of the triangle in parametric coordinates.
		/// </summary>
		// Token: 0x0601CAFB RID: 117499 RVA: 0x0028568C File Offset: 0x0028388C
		public override int GetParametricCenter(IntPtr pcoords)
		{
			return vtkQuad.vtkQuad_GetParametricCenter_16(base.GetCppThis(), pcoords);
		}

		// Token: 0x0601CAFC RID: 117500
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuad_GetParametricCoords_17(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601CAFD RID: 117501 RVA: 0x002856AC File Offset: 0x002838AC
		public override IntPtr GetParametricCoords()
		{
			return vtkQuad.vtkQuad_GetParametricCoords_17(base.GetCppThis());
		}

		// Token: 0x0601CAFE RID: 117502
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuad_InterpolateDerivs_18(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601CAFF RID: 117503 RVA: 0x002856CB File Offset: 0x002838CB
		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkQuad.vtkQuad_InterpolateDerivs_18(base.GetCppThis(), pcoords, derivs);
		}

		// Token: 0x0601CB00 RID: 117504
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuad_InterpolateFunctions_19(HandleRef pThis, IntPtr pcoords, IntPtr sf);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601CB01 RID: 117505 RVA: 0x002856DC File Offset: 0x002838DC
		public override void InterpolateFunctions(IntPtr pcoords, IntPtr sf)
		{
			vtkQuad.vtkQuad_InterpolateFunctions_19(base.GetCppThis(), pcoords, sf);
		}

		// Token: 0x0601CB02 RID: 117506
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuad_InterpolationDerivs_20(IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Clip this quad using scalar value provided. Like contouring, except
		/// that it cuts the quad to produce other quads and/or triangles.
		/// </summary>
		// Token: 0x0601CB03 RID: 117507 RVA: 0x002856ED File Offset: 0x002838ED
		public static void InterpolationDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkQuad.vtkQuad_InterpolationDerivs_20(pcoords, derivs);
		}

		// Token: 0x0601CB04 RID: 117508
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuad_InterpolationFunctions_21(IntPtr pcoords, IntPtr sf);

		/// <summary>
		/// Clip this quad using scalar value provided. Like contouring, except
		/// that it cuts the quad to produce other quads and/or triangles.
		/// </summary>
		// Token: 0x0601CB05 RID: 117509 RVA: 0x002856F8 File Offset: 0x002838F8
		public static void InterpolationFunctions(IntPtr pcoords, IntPtr sf)
		{
			vtkQuad.vtkQuad_InterpolationFunctions_21(pcoords, sf);
		}

		// Token: 0x0601CB06 RID: 117510
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuad_IntersectWithLine_22(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601CB07 RID: 117511 RVA: 0x00285704 File Offset: 0x00283904
		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkQuad.vtkQuad_IntersectWithLine_22(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		// Token: 0x0601CB08 RID: 117512
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuad_IsA_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CB09 RID: 117513 RVA: 0x00285730 File Offset: 0x00283930
		public override int IsA(string type)
		{
			return vtkQuad.vtkQuad_IsA_23(base.GetCppThis(), type);
		}

		// Token: 0x0601CB0A RID: 117514
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuad_IsTypeOf_24([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CB0B RID: 117515 RVA: 0x00285750 File Offset: 0x00283950
		public new static int IsTypeOf(string type)
		{
			return vtkQuad.vtkQuad_IsTypeOf_24(type);
		}

		// Token: 0x0601CB0C RID: 117516
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuad_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CB0D RID: 117517 RVA: 0x0028576C File Offset: 0x0028396C
		public new vtkQuad NewInstance()
		{
			vtkQuad result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuad.vtkQuad_NewInstance_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuad)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601CB0E RID: 117518
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuad_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CB0F RID: 117519 RVA: 0x002857C8 File Offset: 0x002839C8
		public new static vtkQuad SafeDownCast(vtkObjectBase o)
		{
			vtkQuad vtkQuad = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuad.vtkQuad_SafeDownCast_27((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkQuad = (vtkQuad)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkQuad.Register(null);
				}
			}
			return vtkQuad;
		}

		// Token: 0x0601CB10 RID: 117520
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuad_TriangulateLocalIds_28(HandleRef pThis, int index, HandleRef ptIds);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601CB11 RID: 117521 RVA: 0x00285848 File Offset: 0x00283A48
		public override int TriangulateLocalIds(int index, vtkIdList ptIds)
		{
			return vtkQuad.vtkQuad_TriangulateLocalIds_28(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E5D RID: 7773
		public new const string MRFullTypeName = "Kitware.VTK.vtkQuad";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E5E RID: 7774
		public new static readonly string MRClassNameKey = "class vtkQuad";
	}
}
