using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x02000A05 RID: 2565
	public abstract class vtkHigherOrderQuadrilateral : vtkNonLinearCell
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601AA35 RID: 109109 RVA: 0x00250D25 File Offset: 0x0024EF25
		static vtkHigherOrderQuadrilateral()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHigherOrderQuadrilateral.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHigherOrderQuadrilateral"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601AA36 RID: 109110 RVA: 0x00250D4D File Offset: 0x0024EF4D
		public vtkHigherOrderQuadrilateral(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601AA37 RID: 109111 RVA: 0x00250D5B File Offset: 0x0024EF5B
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601AA38 RID: 109112
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderQuadrilateral_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

		// Token: 0x0601AA39 RID: 109113 RVA: 0x00250D68 File Offset: 0x0024EF68
		public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
		{
			return vtkHigherOrderQuadrilateral.vtkHigherOrderQuadrilateral_CellBoundary_01(base.GetCppThis(), subId, pcoords, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601AA3A RID: 109114
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderQuadrilateral_Clip_02(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

		// Token: 0x0601AA3B RID: 109115 RVA: 0x00250DA0 File Offset: 0x0024EFA0
		public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
		{
			vtkHigherOrderQuadrilateral.vtkHigherOrderQuadrilateral_Clip_02(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis(), insideOut);
		}

		// Token: 0x0601AA3C RID: 109116
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderQuadrilateral_Contour_03(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

		// Token: 0x0601AA3D RID: 109117 RVA: 0x00250E5C File Offset: 0x0024F05C
		public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
		{
			vtkHigherOrderQuadrilateral.vtkHigherOrderQuadrilateral_Contour_03(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis());
		}

		// Token: 0x0601AA3E RID: 109118
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderQuadrilateral_Derivatives_04(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

		// Token: 0x0601AA3F RID: 109119 RVA: 0x00250F44 File Offset: 0x0024F144
		public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
		{
			vtkHigherOrderQuadrilateral.vtkHigherOrderQuadrilateral_Derivatives_04(base.GetCppThis(), subId, pcoords, values, dim, derivs);
		}

		// Token: 0x0601AA40 RID: 109120
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderQuadrilateral_EvaluateLocation_05(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

		// Token: 0x0601AA41 RID: 109121 RVA: 0x00250F5A File Offset: 0x0024F15A
		public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
		{
			vtkHigherOrderQuadrilateral.vtkHigherOrderQuadrilateral_EvaluateLocation_05(base.GetCppThis(), ref subId, pcoords, x, weights);
		}

		// Token: 0x0601AA42 RID: 109122
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderQuadrilateral_EvaluatePosition_06(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

		// Token: 0x0601AA43 RID: 109123 RVA: 0x00250F70 File Offset: 0x0024F170
		public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
		{
			return vtkHigherOrderQuadrilateral.vtkHigherOrderQuadrilateral_EvaluatePosition_06(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
		}

		// Token: 0x0601AA44 RID: 109124
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderQuadrilateral_GetCellDimension_07(HandleRef pThis);

		// Token: 0x0601AA45 RID: 109125 RVA: 0x00250F98 File Offset: 0x0024F198
		public override int GetCellDimension()
		{
			return vtkHigherOrderQuadrilateral.vtkHigherOrderQuadrilateral_GetCellDimension_07(base.GetCppThis());
		}

		// Token: 0x0601AA46 RID: 109126
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderQuadrilateral_GetCellType_08(HandleRef pThis);

		// Token: 0x0601AA47 RID: 109127 RVA: 0x00250FB8 File Offset: 0x0024F1B8
		public override int GetCellType()
		{
			return vtkHigherOrderQuadrilateral.vtkHigherOrderQuadrilateral_GetCellType_08(base.GetCppThis());
		}

		// Token: 0x0601AA48 RID: 109128
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderQuadrilateral_GetEdge_09(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601AA49 RID: 109129 RVA: 0x00250FD8 File Offset: 0x0024F1D8
		public override vtkCell GetEdge(int edgeId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHigherOrderQuadrilateral.vtkHigherOrderQuadrilateral_GetEdge_09(base.GetCppThis(), edgeId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601AA4A RID: 109130
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderQuadrilateral_GetEdgeCell_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601AA4B RID: 109131 RVA: 0x00251048 File Offset: 0x0024F248
		public virtual vtkHigherOrderCurve GetEdgeCell()
		{
			vtkHigherOrderCurve vtkHigherOrderCurve = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHigherOrderQuadrilateral.vtkHigherOrderQuadrilateral_GetEdgeCell_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHigherOrderCurve = (vtkHigherOrderCurve)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHigherOrderCurve.Register(null);
				}
			}
			return vtkHigherOrderCurve;
		}

		// Token: 0x0601AA4C RID: 109132
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderQuadrilateral_GetFace_11(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601AA4D RID: 109133 RVA: 0x002510B8 File Offset: 0x0024F2B8
		public override vtkCell GetFace(int arg0)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHigherOrderQuadrilateral.vtkHigherOrderQuadrilateral_GetFace_11(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601AA4E RID: 109134
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderQuadrilateral_GetNumberOfEdges_12(HandleRef pThis);

		// Token: 0x0601AA4F RID: 109135 RVA: 0x00251128 File Offset: 0x0024F328
		public override int GetNumberOfEdges()
		{
			return vtkHigherOrderQuadrilateral.vtkHigherOrderQuadrilateral_GetNumberOfEdges_12(base.GetCppThis());
		}

		// Token: 0x0601AA50 RID: 109136
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderQuadrilateral_GetNumberOfFaces_13(HandleRef pThis);

		// Token: 0x0601AA51 RID: 109137 RVA: 0x00251148 File Offset: 0x0024F348
		public override int GetNumberOfFaces()
		{
			return vtkHigherOrderQuadrilateral.vtkHigherOrderQuadrilateral_GetNumberOfFaces_13(base.GetCppThis());
		}

		// Token: 0x0601AA52 RID: 109138
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHigherOrderQuadrilateral_GetNumberOfGenerationsFromBase_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601AA53 RID: 109139 RVA: 0x00251168 File Offset: 0x0024F368
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkHigherOrderQuadrilateral.vtkHigherOrderQuadrilateral_GetNumberOfGenerationsFromBase_14(base.GetCppThis(), type);
		}

		// Token: 0x0601AA54 RID: 109140
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHigherOrderQuadrilateral_GetNumberOfGenerationsFromBaseType_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601AA55 RID: 109141 RVA: 0x00251188 File Offset: 0x0024F388
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkHigherOrderQuadrilateral.vtkHigherOrderQuadrilateral_GetNumberOfGenerationsFromBaseType_15(type);
		}

		// Token: 0x0601AA56 RID: 109142
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderQuadrilateral_GetOrder_16(HandleRef pThis);

		// Token: 0x0601AA57 RID: 109143 RVA: 0x002511A4 File Offset: 0x0024F3A4
		public virtual IntPtr GetOrder()
		{
			return vtkHigherOrderQuadrilateral.vtkHigherOrderQuadrilateral_GetOrder_16(base.GetCppThis());
		}

		// Token: 0x0601AA58 RID: 109144
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderQuadrilateral_GetOrder_17(HandleRef pThis, int i);

		// Token: 0x0601AA59 RID: 109145 RVA: 0x002511C4 File Offset: 0x0024F3C4
		public virtual int GetOrder(int i)
		{
			return vtkHigherOrderQuadrilateral.vtkHigherOrderQuadrilateral_GetOrder_17(base.GetCppThis(), i);
		}

		// Token: 0x0601AA5A RID: 109146
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderQuadrilateral_GetParametricCenter_18(HandleRef pThis, IntPtr center);

		// Token: 0x0601AA5B RID: 109147 RVA: 0x002511E4 File Offset: 0x0024F3E4
		public override int GetParametricCenter(IntPtr center)
		{
			return vtkHigherOrderQuadrilateral.vtkHigherOrderQuadrilateral_GetParametricCenter_18(base.GetCppThis(), center);
		}

		// Token: 0x0601AA5C RID: 109148
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderQuadrilateral_GetParametricCoords_19(HandleRef pThis);

		// Token: 0x0601AA5D RID: 109149 RVA: 0x00251204 File Offset: 0x0024F404
		public override IntPtr GetParametricCoords()
		{
			return vtkHigherOrderQuadrilateral.vtkHigherOrderQuadrilateral_GetParametricCoords_19(base.GetCppThis());
		}

		// Token: 0x0601AA5E RID: 109150
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkHigherOrderQuadrilateral_GetParametricDistance_20(HandleRef pThis, IntPtr pcoords);

		// Token: 0x0601AA5F RID: 109151 RVA: 0x00251224 File Offset: 0x0024F424
		public override double GetParametricDistance(IntPtr pcoords)
		{
			return vtkHigherOrderQuadrilateral.vtkHigherOrderQuadrilateral_GetParametricDistance_20(base.GetCppThis(), pcoords);
		}

		// Token: 0x0601AA60 RID: 109152
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderQuadrilateral_Initialize_21(HandleRef pThis);

		// Token: 0x0601AA61 RID: 109153 RVA: 0x00251244 File Offset: 0x0024F444
		public override void Initialize()
		{
			vtkHigherOrderQuadrilateral.vtkHigherOrderQuadrilateral_Initialize_21(base.GetCppThis());
		}

		// Token: 0x0601AA62 RID: 109154
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderQuadrilateral_InterpolateDerivs_22(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		// Token: 0x0601AA63 RID: 109155 RVA: 0x00251253 File Offset: 0x0024F453
		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkHigherOrderQuadrilateral.vtkHigherOrderQuadrilateral_InterpolateDerivs_22(base.GetCppThis(), pcoords, derivs);
		}

		// Token: 0x0601AA64 RID: 109156
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderQuadrilateral_InterpolateFunctions_23(HandleRef pThis, IntPtr pcoords, IntPtr weights);

		// Token: 0x0601AA65 RID: 109157 RVA: 0x00251264 File Offset: 0x0024F464
		public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkHigherOrderQuadrilateral.vtkHigherOrderQuadrilateral_InterpolateFunctions_23(base.GetCppThis(), pcoords, weights);
		}

		// Token: 0x0601AA66 RID: 109158
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderQuadrilateral_IntersectWithLine_24(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		// Token: 0x0601AA67 RID: 109159 RVA: 0x00251278 File Offset: 0x0024F478
		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkHigherOrderQuadrilateral.vtkHigherOrderQuadrilateral_IntersectWithLine_24(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		// Token: 0x0601AA68 RID: 109160
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderQuadrilateral_IsA_25(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601AA69 RID: 109161 RVA: 0x002512A4 File Offset: 0x0024F4A4
		public override int IsA(string type)
		{
			return vtkHigherOrderQuadrilateral.vtkHigherOrderQuadrilateral_IsA_25(base.GetCppThis(), type);
		}

		// Token: 0x0601AA6A RID: 109162
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderQuadrilateral_IsTypeOf_26([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601AA6B RID: 109163 RVA: 0x002512C4 File Offset: 0x0024F4C4
		public new static int IsTypeOf(string type)
		{
			return vtkHigherOrderQuadrilateral.vtkHigherOrderQuadrilateral_IsTypeOf_26(type);
		}

		// Token: 0x0601AA6C RID: 109164
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderQuadrilateral_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601AA6D RID: 109165 RVA: 0x002512E0 File Offset: 0x0024F4E0
		public new vtkHigherOrderQuadrilateral NewInstance()
		{
			vtkHigherOrderQuadrilateral result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHigherOrderQuadrilateral.vtkHigherOrderQuadrilateral_NewInstance_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHigherOrderQuadrilateral)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601AA6E RID: 109166
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHigherOrderQuadrilateral_PointCountSupportsUniformOrder_28(long pointsPerCell);

		// Token: 0x0601AA6F RID: 109167 RVA: 0x0025133C File Offset: 0x0024F53C
		public static bool PointCountSupportsUniformOrder(long pointsPerCell)
		{
			return vtkHigherOrderQuadrilateral.vtkHigherOrderQuadrilateral_PointCountSupportsUniformOrder_28(pointsPerCell) != 0;
		}

		// Token: 0x0601AA70 RID: 109168
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderQuadrilateral_PointIndexFromIJK_29(HandleRef pThis, int i, int j, int k);

		// Token: 0x0601AA71 RID: 109169 RVA: 0x00251360 File Offset: 0x0024F560
		public int PointIndexFromIJK(int i, int j, int k)
		{
			return vtkHigherOrderQuadrilateral.vtkHigherOrderQuadrilateral_PointIndexFromIJK_29(base.GetCppThis(), i, j, k);
		}

		// Token: 0x0601AA72 RID: 109170
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderQuadrilateral_PointIndexFromIJK_30(int i, int j, IntPtr order);

		// Token: 0x0601AA73 RID: 109171 RVA: 0x00251384 File Offset: 0x0024F584
		public static int PointIndexFromIJK(int i, int j, IntPtr order)
		{
			return vtkHigherOrderQuadrilateral.vtkHigherOrderQuadrilateral_PointIndexFromIJK_30(i, j, order);
		}

		// Token: 0x0601AA74 RID: 109172
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderQuadrilateral_RequiresInitialization_31(HandleRef pThis);

		// Token: 0x0601AA75 RID: 109173 RVA: 0x002513A0 File Offset: 0x0024F5A0
		public override int RequiresInitialization()
		{
			return vtkHigherOrderQuadrilateral.vtkHigherOrderQuadrilateral_RequiresInitialization_31(base.GetCppThis());
		}

		// Token: 0x0601AA76 RID: 109174
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderQuadrilateral_SafeDownCast_32(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601AA77 RID: 109175 RVA: 0x002513C0 File Offset: 0x0024F5C0
		public new static vtkHigherOrderQuadrilateral SafeDownCast(vtkObjectBase o)
		{
			vtkHigherOrderQuadrilateral vtkHigherOrderQuadrilateral = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHigherOrderQuadrilateral.vtkHigherOrderQuadrilateral_SafeDownCast_32((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHigherOrderQuadrilateral = (vtkHigherOrderQuadrilateral)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHigherOrderQuadrilateral.Register(null);
				}
			}
			return vtkHigherOrderQuadrilateral;
		}

		// Token: 0x0601AA78 RID: 109176
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderQuadrilateral_SetOrder_33(HandleRef pThis, int s, int t);

		// Token: 0x0601AA79 RID: 109177 RVA: 0x0025143F File Offset: 0x0024F63F
		public virtual void SetOrder(int s, int t)
		{
			vtkHigherOrderQuadrilateral.vtkHigherOrderQuadrilateral_SetOrder_33(base.GetCppThis(), s, t);
		}

		// Token: 0x0601AA7A RID: 109178
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderQuadrilateral_SetOrderFromCellData_34(HandleRef pThis, HandleRef cell_data, long numPts, long cell_id);

		// Token: 0x0601AA7B RID: 109179 RVA: 0x00251450 File Offset: 0x0024F650
		public virtual void SetOrderFromCellData(vtkCellData cell_data, long numPts, long cell_id)
		{
			vtkHigherOrderQuadrilateral.vtkHigherOrderQuadrilateral_SetOrderFromCellData_34(base.GetCppThis(), (cell_data == null) ? default(HandleRef) : cell_data.GetCppThis(), numPts, cell_id);
		}

		// Token: 0x0601AA7C RID: 109180
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderQuadrilateral_SetOrderFromCellData_35(HandleRef cell_data, long numPts, long cell_id, IntPtr order);

		// Token: 0x0601AA7D RID: 109181 RVA: 0x00251484 File Offset: 0x0024F684
		public static void SetOrderFromCellData(vtkCellData cell_data, long numPts, long cell_id, IntPtr order)
		{
			vtkHigherOrderQuadrilateral.vtkHigherOrderQuadrilateral_SetOrderFromCellData_35((cell_data == null) ? default(HandleRef) : cell_data.GetCppThis(), numPts, cell_id, order);
		}

		// Token: 0x0601AA7E RID: 109182
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderQuadrilateral_SetParametricCoords_36(HandleRef pThis);

		// Token: 0x0601AA7F RID: 109183 RVA: 0x002514B0 File Offset: 0x0024F6B0
		public void SetParametricCoords()
		{
			vtkHigherOrderQuadrilateral.vtkHigherOrderQuadrilateral_SetParametricCoords_36(base.GetCppThis());
		}

		// Token: 0x0601AA80 RID: 109184
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderQuadrilateral_SetUniformOrderFromNumPoints_37(HandleRef pThis, long numPts);

		// Token: 0x0601AA81 RID: 109185 RVA: 0x002514BF File Offset: 0x0024F6BF
		public virtual void SetUniformOrderFromNumPoints(long numPts)
		{
			vtkHigherOrderQuadrilateral.vtkHigherOrderQuadrilateral_SetUniformOrderFromNumPoints_37(base.GetCppThis(), numPts);
		}

		// Token: 0x0601AA82 RID: 109186
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHigherOrderQuadrilateral_SubCellCoordinatesFromId_38(HandleRef pThis, vtkVector3i ijk, int subId);

		// Token: 0x0601AA83 RID: 109187 RVA: 0x002514D0 File Offset: 0x0024F6D0
		public bool SubCellCoordinatesFromId(vtkVector3i ijk, int subId)
		{
			return vtkHigherOrderQuadrilateral.vtkHigherOrderQuadrilateral_SubCellCoordinatesFromId_38(base.GetCppThis(), ijk, subId) != 0;
		}

		// Token: 0x0601AA84 RID: 109188
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHigherOrderQuadrilateral_SubCellCoordinatesFromId_39(HandleRef pThis, ref int i, ref int j, ref int k, int subId);

		// Token: 0x0601AA85 RID: 109189 RVA: 0x002514F8 File Offset: 0x0024F6F8
		public bool SubCellCoordinatesFromId(ref int i, ref int j, ref int k, int subId)
		{
			return vtkHigherOrderQuadrilateral.vtkHigherOrderQuadrilateral_SubCellCoordinatesFromId_39(base.GetCppThis(), ref i, ref j, ref k, subId) != 0;
		}

		// Token: 0x0601AA86 RID: 109190
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHigherOrderQuadrilateral_TransformApproxToCellParams_40(HandleRef pThis, int subCell, IntPtr pcoords);

		// Token: 0x0601AA87 RID: 109191 RVA: 0x00251524 File Offset: 0x0024F724
		public bool TransformApproxToCellParams(int subCell, IntPtr pcoords)
		{
			return vtkHigherOrderQuadrilateral.vtkHigherOrderQuadrilateral_TransformApproxToCellParams_40(base.GetCppThis(), subCell, pcoords) != 0;
		}

		// Token: 0x0601AA88 RID: 109192
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderQuadrilateral_TriangulateLocalIds_41(HandleRef pThis, int index, HandleRef ptId);

		// Token: 0x0601AA89 RID: 109193 RVA: 0x0025154C File Offset: 0x0024F74C
		public override int TriangulateLocalIds(int index, vtkIdList ptId)
		{
			return vtkHigherOrderQuadrilateral.vtkHigherOrderQuadrilateral_TriangulateLocalIds_41(base.GetCppThis(), index, (ptId == null) ? default(HandleRef) : ptId.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CE2 RID: 7394
		public new const string MRFullTypeName = "Kitware.VTK.vtkHigherOrderQuadrilateral";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CE3 RID: 7395
		public new static readonly string MRClassNameKey = "class vtkHigherOrderQuadrilateral";
	}
}
