using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGenericCell
	/// </summary>
	/// <remarks>
	///    provides thread-safe access to cells
	///
	/// vtkGenericCell is a class that provides access to concrete types of cells.
	/// It's main purpose is to allow thread-safe access to cells, supporting
	/// the vtkDataSet::GetCell(vtkGenericCell *) method. vtkGenericCell acts
	/// like any type of cell, it just dereferences an internal representation.
	/// The SetCellType() methods use \#define constants; these are defined in
	/// the file vtkCellType.h.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkCell vtkDataSet
	/// </seealso>
	// Token: 0x02000A4C RID: 2636
	public class vtkGenericCell : vtkCell
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601B7FA RID: 112634 RVA: 0x00267CCF File Offset: 0x00265ECF
		static vtkGenericCell()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenericCell.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericCell"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601B7FB RID: 112635 RVA: 0x00267CF7 File Offset: 0x00265EF7
		public vtkGenericCell(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601B7FC RID: 112636
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericCell_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create handle to any type of cell; by default a vtkEmptyCell.
		/// </summary>
		// Token: 0x0601B7FD RID: 112637 RVA: 0x00267D08 File Offset: 0x00265F08
		public new static vtkGenericCell New()
		{
			vtkGenericCell result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericCell.vtkGenericCell_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericCell)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Create handle to any type of cell; by default a vtkEmptyCell.
		/// </summary>
		// Token: 0x0601B7FE RID: 112638 RVA: 0x00267D5C File Offset: 0x00265F5C
		public vtkGenericCell() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGenericCell.vtkGenericCell_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601B7FF RID: 112639 RVA: 0x00267DA0 File Offset: 0x00265FA0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601B800 RID: 112640
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericCell_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B801 RID: 112641 RVA: 0x00267DAC File Offset: 0x00265FAC
		public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
		{
			return vtkGenericCell.vtkGenericCell_CellBoundary_01(base.GetCppThis(), subId, pcoords, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601B802 RID: 112642
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_Clip_02(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef connectivity, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B803 RID: 112643 RVA: 0x00267DE4 File Offset: 0x00265FE4
		public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray connectivity, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
		{
			vtkGenericCell.vtkGenericCell_Clip_02(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (connectivity == null) ? default(HandleRef) : connectivity.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis(), insideOut);
		}

		// Token: 0x0601B804 RID: 112644
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_Contour_03(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B805 RID: 112645 RVA: 0x00267EA0 File Offset: 0x002660A0
		public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
		{
			vtkGenericCell.vtkGenericCell_Contour_03(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis());
		}

		// Token: 0x0601B806 RID: 112646
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_DeepCopy_04(HandleRef pThis, HandleRef c);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B807 RID: 112647 RVA: 0x00267F88 File Offset: 0x00266188
		public override void DeepCopy(vtkCell c)
		{
			vtkGenericCell.vtkGenericCell_DeepCopy_04(base.GetCppThis(), (c == null) ? default(HandleRef) : c.GetCppThis());
		}

		// Token: 0x0601B808 RID: 112648
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_Derivatives_05(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B809 RID: 112649 RVA: 0x00267FB7 File Offset: 0x002661B7
		public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
		{
			vtkGenericCell.vtkGenericCell_Derivatives_05(base.GetCppThis(), subId, pcoords, values, dim, derivs);
		}

		// Token: 0x0601B80A RID: 112650
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_EvaluateLocation_06(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B80B RID: 112651 RVA: 0x00267FCD File Offset: 0x002661CD
		public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
		{
			vtkGenericCell.vtkGenericCell_EvaluateLocation_06(base.GetCppThis(), ref subId, pcoords, x, weights);
		}

		// Token: 0x0601B80C RID: 112652
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericCell_EvaluatePosition_07(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B80D RID: 112653 RVA: 0x00267FE4 File Offset: 0x002661E4
		public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
		{
			return vtkGenericCell.vtkGenericCell_EvaluatePosition_07(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
		}

		// Token: 0x0601B80E RID: 112654
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericCell_GetCellDimension_08(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B80F RID: 112655 RVA: 0x0026800C File Offset: 0x0026620C
		public override int GetCellDimension()
		{
			return vtkGenericCell.vtkGenericCell_GetCellDimension_08(base.GetCppThis());
		}

		// Token: 0x0601B810 RID: 112656
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericCell_GetCellType_09(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B811 RID: 112657 RVA: 0x0026802C File Offset: 0x0026622C
		public override int GetCellType()
		{
			return vtkGenericCell.vtkGenericCell_GetCellType_09(base.GetCppThis());
		}

		// Token: 0x0601B812 RID: 112658
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericCell_GetEdge_10(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B813 RID: 112659 RVA: 0x0026804C File Offset: 0x0026624C
		public override vtkCell GetEdge(int edgeId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericCell.vtkGenericCell_GetEdge_10(base.GetCppThis(), edgeId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601B814 RID: 112660
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericCell_GetFace_11(HandleRef pThis, int faceId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B815 RID: 112661 RVA: 0x002680BC File Offset: 0x002662BC
		public override vtkCell GetFace(int faceId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericCell.vtkGenericCell_GetFace_11(base.GetCppThis(), faceId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601B816 RID: 112662
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericCell_GetFaces_12(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B817 RID: 112663 RVA: 0x0026812C File Offset: 0x0026632C
		public override IntPtr GetFaces()
		{
			return vtkGenericCell.vtkGenericCell_GetFaces_12(base.GetCppThis());
		}

		// Token: 0x0601B818 RID: 112664
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericCell_GetNumberOfEdges_13(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B819 RID: 112665 RVA: 0x0026814C File Offset: 0x0026634C
		public override int GetNumberOfEdges()
		{
			return vtkGenericCell.vtkGenericCell_GetNumberOfEdges_13(base.GetCppThis());
		}

		// Token: 0x0601B81A RID: 112666
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericCell_GetNumberOfFaces_14(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B81B RID: 112667 RVA: 0x0026816C File Offset: 0x0026636C
		public override int GetNumberOfFaces()
		{
			return vtkGenericCell.vtkGenericCell_GetNumberOfFaces_14(base.GetCppThis());
		}

		// Token: 0x0601B81C RID: 112668
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericCell_GetNumberOfGenerationsFromBase_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Create handle to any type of cell; by default a vtkEmptyCell.
		/// </summary>
		// Token: 0x0601B81D RID: 112669 RVA: 0x0026818C File Offset: 0x0026638C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGenericCell.vtkGenericCell_GetNumberOfGenerationsFromBase_15(base.GetCppThis(), type);
		}

		// Token: 0x0601B81E RID: 112670
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericCell_GetNumberOfGenerationsFromBaseType_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Create handle to any type of cell; by default a vtkEmptyCell.
		/// </summary>
		// Token: 0x0601B81F RID: 112671 RVA: 0x002681AC File Offset: 0x002663AC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGenericCell.vtkGenericCell_GetNumberOfGenerationsFromBaseType_16(type);
		}

		// Token: 0x0601B820 RID: 112672
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericCell_GetParametricCenter_17(HandleRef pThis, IntPtr pcoords);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B821 RID: 112673 RVA: 0x002681C8 File Offset: 0x002663C8
		public override int GetParametricCenter(IntPtr pcoords)
		{
			return vtkGenericCell.vtkGenericCell_GetParametricCenter_17(base.GetCppThis(), pcoords);
		}

		// Token: 0x0601B822 RID: 112674
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericCell_GetParametricCoords_18(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B823 RID: 112675 RVA: 0x002681E8 File Offset: 0x002663E8
		public override IntPtr GetParametricCoords()
		{
			return vtkGenericCell.vtkGenericCell_GetParametricCoords_18(base.GetCppThis());
		}

		// Token: 0x0601B824 RID: 112676
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericCell_GetRepresentativeCell_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate a new vtkCell based on it's cell type value
		/// </summary>
		// Token: 0x0601B825 RID: 112677 RVA: 0x00268208 File Offset: 0x00266408
		public vtkCell GetRepresentativeCell()
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericCell.vtkGenericCell_GetRepresentativeCell_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601B826 RID: 112678
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_Initialize_20(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B827 RID: 112679 RVA: 0x00268277 File Offset: 0x00266477
		public override void Initialize()
		{
			vtkGenericCell.vtkGenericCell_Initialize_20(base.GetCppThis());
		}

		// Token: 0x0601B828 RID: 112680
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericCell_InstantiateCell_21(int cellType, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate a new vtkCell based on it's cell type value
		/// </summary>
		// Token: 0x0601B829 RID: 112681 RVA: 0x00268288 File Offset: 0x00266488
		public static vtkCell InstantiateCell(int cellType)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericCell.vtkGenericCell_InstantiateCell_21(cellType, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601B82A RID: 112682
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_InterpolateDerivs_22(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601B82B RID: 112683 RVA: 0x002682F2 File Offset: 0x002664F2
		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkGenericCell.vtkGenericCell_InterpolateDerivs_22(base.GetCppThis(), pcoords, derivs);
		}

		// Token: 0x0601B82C RID: 112684
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_InterpolateFunctions_23(HandleRef pThis, IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601B82D RID: 112685 RVA: 0x00268303 File Offset: 0x00266503
		public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkGenericCell.vtkGenericCell_InterpolateFunctions_23(base.GetCppThis(), pcoords, weights);
		}

		// Token: 0x0601B82E RID: 112686
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericCell_IntersectWithLine_24(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B82F RID: 112687 RVA: 0x00268314 File Offset: 0x00266514
		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkGenericCell.vtkGenericCell_IntersectWithLine_24(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		// Token: 0x0601B830 RID: 112688
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericCell_IsA_25(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Create handle to any type of cell; by default a vtkEmptyCell.
		/// </summary>
		// Token: 0x0601B831 RID: 112689 RVA: 0x00268340 File Offset: 0x00266540
		public override int IsA(string type)
		{
			return vtkGenericCell.vtkGenericCell_IsA_25(base.GetCppThis(), type);
		}

		// Token: 0x0601B832 RID: 112690
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericCell_IsLinear_26(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B833 RID: 112691 RVA: 0x00268360 File Offset: 0x00266560
		public override int IsLinear()
		{
			return vtkGenericCell.vtkGenericCell_IsLinear_26(base.GetCppThis());
		}

		// Token: 0x0601B834 RID: 112692
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericCell_IsPrimaryCell_27(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B835 RID: 112693 RVA: 0x00268380 File Offset: 0x00266580
		public override int IsPrimaryCell()
		{
			return vtkGenericCell.vtkGenericCell_IsPrimaryCell_27(base.GetCppThis());
		}

		// Token: 0x0601B836 RID: 112694
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericCell_IsTypeOf_28([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Create handle to any type of cell; by default a vtkEmptyCell.
		/// </summary>
		// Token: 0x0601B837 RID: 112695 RVA: 0x002683A0 File Offset: 0x002665A0
		public new static int IsTypeOf(string type)
		{
			return vtkGenericCell.vtkGenericCell_IsTypeOf_28(type);
		}

		// Token: 0x0601B838 RID: 112696
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericCell_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create handle to any type of cell; by default a vtkEmptyCell.
		/// </summary>
		// Token: 0x0601B839 RID: 112697 RVA: 0x002683BC File Offset: 0x002665BC
		public new vtkGenericCell NewInstance()
		{
			vtkGenericCell result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericCell.vtkGenericCell_NewInstance_30(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericCell)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601B83A RID: 112698
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericCell_RequiresExplicitFaceRepresentation_31(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B83B RID: 112699 RVA: 0x00268418 File Offset: 0x00266618
		public override int RequiresExplicitFaceRepresentation()
		{
			return vtkGenericCell.vtkGenericCell_RequiresExplicitFaceRepresentation_31(base.GetCppThis());
		}

		// Token: 0x0601B83C RID: 112700
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericCell_RequiresInitialization_32(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B83D RID: 112701 RVA: 0x00268438 File Offset: 0x00266638
		public override int RequiresInitialization()
		{
			return vtkGenericCell.vtkGenericCell_RequiresInitialization_32(base.GetCppThis());
		}

		// Token: 0x0601B83E RID: 112702
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericCell_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create handle to any type of cell; by default a vtkEmptyCell.
		/// </summary>
		// Token: 0x0601B83F RID: 112703 RVA: 0x00268458 File Offset: 0x00266658
		public new static vtkGenericCell SafeDownCast(vtkObjectBase o)
		{
			vtkGenericCell vtkGenericCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericCell.vtkGenericCell_SafeDownCast_33((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericCell = (vtkGenericCell)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericCell.Register(null);
				}
			}
			return vtkGenericCell;
		}

		// Token: 0x0601B840 RID: 112704
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_SetCellType_34(HandleRef pThis, int cellType);

		/// <summary>
		/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
		/// method. It allows vtkGenericCell to act like any cell type by
		/// dereferencing an internal instance of a concrete cell type. When
		/// you set the cell type, you are resetting a pointer to an internal
		/// cell which is then used for computation.
		/// </summary>
		// Token: 0x0601B841 RID: 112705 RVA: 0x002684D7 File Offset: 0x002666D7
		public void SetCellType(int cellType)
		{
			vtkGenericCell.vtkGenericCell_SetCellType_34(base.GetCppThis(), cellType);
		}

		// Token: 0x0601B842 RID: 112706
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_SetCellTypeToBezierCurve_35(HandleRef pThis);

		/// <summary>
		/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
		/// method. It allows vtkGenericCell to act like any cell type by
		/// dereferencing an internal instance of a concrete cell type. When
		/// you set the cell type, you are resetting a pointer to an internal
		/// cell which is then used for computation.
		/// </summary>
		// Token: 0x0601B843 RID: 112707 RVA: 0x002684E7 File Offset: 0x002666E7
		public void SetCellTypeToBezierCurve()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToBezierCurve_35(base.GetCppThis());
		}

		// Token: 0x0601B844 RID: 112708
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_SetCellTypeToBezierHexahedron_36(HandleRef pThis);

		/// <summary>
		/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
		/// method. It allows vtkGenericCell to act like any cell type by
		/// dereferencing an internal instance of a concrete cell type. When
		/// you set the cell type, you are resetting a pointer to an internal
		/// cell which is then used for computation.
		/// </summary>
		// Token: 0x0601B845 RID: 112709 RVA: 0x002684F6 File Offset: 0x002666F6
		public void SetCellTypeToBezierHexahedron()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToBezierHexahedron_36(base.GetCppThis());
		}

		// Token: 0x0601B846 RID: 112710
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_SetCellTypeToBezierQuadrilateral_37(HandleRef pThis);

		/// <summary>
		/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
		/// method. It allows vtkGenericCell to act like any cell type by
		/// dereferencing an internal instance of a concrete cell type. When
		/// you set the cell type, you are resetting a pointer to an internal
		/// cell which is then used for computation.
		/// </summary>
		// Token: 0x0601B847 RID: 112711 RVA: 0x00268505 File Offset: 0x00266705
		public void SetCellTypeToBezierQuadrilateral()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToBezierQuadrilateral_37(base.GetCppThis());
		}

		// Token: 0x0601B848 RID: 112712
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_SetCellTypeToBezierTetra_38(HandleRef pThis);

		/// <summary>
		/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
		/// method. It allows vtkGenericCell to act like any cell type by
		/// dereferencing an internal instance of a concrete cell type. When
		/// you set the cell type, you are resetting a pointer to an internal
		/// cell which is then used for computation.
		/// </summary>
		// Token: 0x0601B849 RID: 112713 RVA: 0x00268514 File Offset: 0x00266714
		public void SetCellTypeToBezierTetra()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToBezierTetra_38(base.GetCppThis());
		}

		// Token: 0x0601B84A RID: 112714
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_SetCellTypeToBezierTriangle_39(HandleRef pThis);

		/// <summary>
		/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
		/// method. It allows vtkGenericCell to act like any cell type by
		/// dereferencing an internal instance of a concrete cell type. When
		/// you set the cell type, you are resetting a pointer to an internal
		/// cell which is then used for computation.
		/// </summary>
		// Token: 0x0601B84B RID: 112715 RVA: 0x00268523 File Offset: 0x00266723
		public void SetCellTypeToBezierTriangle()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToBezierTriangle_39(base.GetCppThis());
		}

		// Token: 0x0601B84C RID: 112716
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_SetCellTypeToBezierWedge_40(HandleRef pThis);

		/// <summary>
		/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
		/// method. It allows vtkGenericCell to act like any cell type by
		/// dereferencing an internal instance of a concrete cell type. When
		/// you set the cell type, you are resetting a pointer to an internal
		/// cell which is then used for computation.
		/// </summary>
		// Token: 0x0601B84D RID: 112717 RVA: 0x00268532 File Offset: 0x00266732
		public void SetCellTypeToBezierWedge()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToBezierWedge_40(base.GetCppThis());
		}

		// Token: 0x0601B84E RID: 112718
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_SetCellTypeToBiQuadraticQuad_41(HandleRef pThis);

		/// <summary>
		/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
		/// method. It allows vtkGenericCell to act like any cell type by
		/// dereferencing an internal instance of a concrete cell type. When
		/// you set the cell type, you are resetting a pointer to an internal
		/// cell which is then used for computation.
		/// </summary>
		// Token: 0x0601B84F RID: 112719 RVA: 0x00268541 File Offset: 0x00266741
		public void SetCellTypeToBiQuadraticQuad()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToBiQuadraticQuad_41(base.GetCppThis());
		}

		// Token: 0x0601B850 RID: 112720
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_SetCellTypeToBiQuadraticQuadraticHexahedron_42(HandleRef pThis);

		/// <summary>
		/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
		/// method. It allows vtkGenericCell to act like any cell type by
		/// dereferencing an internal instance of a concrete cell type. When
		/// you set the cell type, you are resetting a pointer to an internal
		/// cell which is then used for computation.
		/// </summary>
		// Token: 0x0601B851 RID: 112721 RVA: 0x00268550 File Offset: 0x00266750
		public void SetCellTypeToBiQuadraticQuadraticHexahedron()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToBiQuadraticQuadraticHexahedron_42(base.GetCppThis());
		}

		// Token: 0x0601B852 RID: 112722
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_SetCellTypeToBiQuadraticQuadraticWedge_43(HandleRef pThis);

		/// <summary>
		/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
		/// method. It allows vtkGenericCell to act like any cell type by
		/// dereferencing an internal instance of a concrete cell type. When
		/// you set the cell type, you are resetting a pointer to an internal
		/// cell which is then used for computation.
		/// </summary>
		// Token: 0x0601B853 RID: 112723 RVA: 0x0026855F File Offset: 0x0026675F
		public void SetCellTypeToBiQuadraticQuadraticWedge()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToBiQuadraticQuadraticWedge_43(base.GetCppThis());
		}

		// Token: 0x0601B854 RID: 112724
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_SetCellTypeToBiQuadraticTriangle_44(HandleRef pThis);

		/// <summary>
		/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
		/// method. It allows vtkGenericCell to act like any cell type by
		/// dereferencing an internal instance of a concrete cell type. When
		/// you set the cell type, you are resetting a pointer to an internal
		/// cell which is then used for computation.
		/// </summary>
		// Token: 0x0601B855 RID: 112725 RVA: 0x0026856E File Offset: 0x0026676E
		public void SetCellTypeToBiQuadraticTriangle()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToBiQuadraticTriangle_44(base.GetCppThis());
		}

		// Token: 0x0601B856 RID: 112726
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_SetCellTypeToConvexPointSet_45(HandleRef pThis);

		/// <summary>
		/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
		/// method. It allows vtkGenericCell to act like any cell type by
		/// dereferencing an internal instance of a concrete cell type. When
		/// you set the cell type, you are resetting a pointer to an internal
		/// cell which is then used for computation.
		/// </summary>
		// Token: 0x0601B857 RID: 112727 RVA: 0x0026857D File Offset: 0x0026677D
		public void SetCellTypeToConvexPointSet()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToConvexPointSet_45(base.GetCppThis());
		}

		// Token: 0x0601B858 RID: 112728
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_SetCellTypeToCubicLine_46(HandleRef pThis);

		/// <summary>
		/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
		/// method. It allows vtkGenericCell to act like any cell type by
		/// dereferencing an internal instance of a concrete cell type. When
		/// you set the cell type, you are resetting a pointer to an internal
		/// cell which is then used for computation.
		/// </summary>
		// Token: 0x0601B859 RID: 112729 RVA: 0x0026858C File Offset: 0x0026678C
		public void SetCellTypeToCubicLine()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToCubicLine_46(base.GetCppThis());
		}

		// Token: 0x0601B85A RID: 112730
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_SetCellTypeToEmptyCell_47(HandleRef pThis);

		/// <summary>
		/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
		/// method. It allows vtkGenericCell to act like any cell type by
		/// dereferencing an internal instance of a concrete cell type. When
		/// you set the cell type, you are resetting a pointer to an internal
		/// cell which is then used for computation.
		/// </summary>
		// Token: 0x0601B85B RID: 112731 RVA: 0x0026859B File Offset: 0x0026679B
		public void SetCellTypeToEmptyCell()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToEmptyCell_47(base.GetCppThis());
		}

		// Token: 0x0601B85C RID: 112732
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_SetCellTypeToHexagonalPrism_48(HandleRef pThis);

		/// <summary>
		/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
		/// method. It allows vtkGenericCell to act like any cell type by
		/// dereferencing an internal instance of a concrete cell type. When
		/// you set the cell type, you are resetting a pointer to an internal
		/// cell which is then used for computation.
		/// </summary>
		// Token: 0x0601B85D RID: 112733 RVA: 0x002685AA File Offset: 0x002667AA
		public void SetCellTypeToHexagonalPrism()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToHexagonalPrism_48(base.GetCppThis());
		}

		// Token: 0x0601B85E RID: 112734
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_SetCellTypeToHexahedron_49(HandleRef pThis);

		/// <summary>
		/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
		/// method. It allows vtkGenericCell to act like any cell type by
		/// dereferencing an internal instance of a concrete cell type. When
		/// you set the cell type, you are resetting a pointer to an internal
		/// cell which is then used for computation.
		/// </summary>
		// Token: 0x0601B85F RID: 112735 RVA: 0x002685B9 File Offset: 0x002667B9
		public void SetCellTypeToHexahedron()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToHexahedron_49(base.GetCppThis());
		}

		// Token: 0x0601B860 RID: 112736
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_SetCellTypeToLagrangeCurve_50(HandleRef pThis);

		/// <summary>
		/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
		/// method. It allows vtkGenericCell to act like any cell type by
		/// dereferencing an internal instance of a concrete cell type. When
		/// you set the cell type, you are resetting a pointer to an internal
		/// cell which is then used for computation.
		/// </summary>
		// Token: 0x0601B861 RID: 112737 RVA: 0x002685C8 File Offset: 0x002667C8
		public void SetCellTypeToLagrangeCurve()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToLagrangeCurve_50(base.GetCppThis());
		}

		// Token: 0x0601B862 RID: 112738
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_SetCellTypeToLagrangeHexahedron_51(HandleRef pThis);

		/// <summary>
		/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
		/// method. It allows vtkGenericCell to act like any cell type by
		/// dereferencing an internal instance of a concrete cell type. When
		/// you set the cell type, you are resetting a pointer to an internal
		/// cell which is then used for computation.
		/// </summary>
		// Token: 0x0601B863 RID: 112739 RVA: 0x002685D7 File Offset: 0x002667D7
		public void SetCellTypeToLagrangeHexahedron()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToLagrangeHexahedron_51(base.GetCppThis());
		}

		// Token: 0x0601B864 RID: 112740
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_SetCellTypeToLagrangeQuadrilateral_52(HandleRef pThis);

		/// <summary>
		/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
		/// method. It allows vtkGenericCell to act like any cell type by
		/// dereferencing an internal instance of a concrete cell type. When
		/// you set the cell type, you are resetting a pointer to an internal
		/// cell which is then used for computation.
		/// </summary>
		// Token: 0x0601B865 RID: 112741 RVA: 0x002685E6 File Offset: 0x002667E6
		public void SetCellTypeToLagrangeQuadrilateral()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToLagrangeQuadrilateral_52(base.GetCppThis());
		}

		// Token: 0x0601B866 RID: 112742
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_SetCellTypeToLagrangeTetra_53(HandleRef pThis);

		/// <summary>
		/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
		/// method. It allows vtkGenericCell to act like any cell type by
		/// dereferencing an internal instance of a concrete cell type. When
		/// you set the cell type, you are resetting a pointer to an internal
		/// cell which is then used for computation.
		/// </summary>
		// Token: 0x0601B867 RID: 112743 RVA: 0x002685F5 File Offset: 0x002667F5
		public void SetCellTypeToLagrangeTetra()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToLagrangeTetra_53(base.GetCppThis());
		}

		// Token: 0x0601B868 RID: 112744
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_SetCellTypeToLagrangeTriangle_54(HandleRef pThis);

		/// <summary>
		/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
		/// method. It allows vtkGenericCell to act like any cell type by
		/// dereferencing an internal instance of a concrete cell type. When
		/// you set the cell type, you are resetting a pointer to an internal
		/// cell which is then used for computation.
		/// </summary>
		// Token: 0x0601B869 RID: 112745 RVA: 0x00268604 File Offset: 0x00266804
		public void SetCellTypeToLagrangeTriangle()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToLagrangeTriangle_54(base.GetCppThis());
		}

		// Token: 0x0601B86A RID: 112746
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_SetCellTypeToLagrangeWedge_55(HandleRef pThis);

		/// <summary>
		/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
		/// method. It allows vtkGenericCell to act like any cell type by
		/// dereferencing an internal instance of a concrete cell type. When
		/// you set the cell type, you are resetting a pointer to an internal
		/// cell which is then used for computation.
		/// </summary>
		// Token: 0x0601B86B RID: 112747 RVA: 0x00268613 File Offset: 0x00266813
		public void SetCellTypeToLagrangeWedge()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToLagrangeWedge_55(base.GetCppThis());
		}

		// Token: 0x0601B86C RID: 112748
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_SetCellTypeToLine_56(HandleRef pThis);

		/// <summary>
		/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
		/// method. It allows vtkGenericCell to act like any cell type by
		/// dereferencing an internal instance of a concrete cell type. When
		/// you set the cell type, you are resetting a pointer to an internal
		/// cell which is then used for computation.
		/// </summary>
		// Token: 0x0601B86D RID: 112749 RVA: 0x00268622 File Offset: 0x00266822
		public void SetCellTypeToLine()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToLine_56(base.GetCppThis());
		}

		// Token: 0x0601B86E RID: 112750
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_SetCellTypeToPentagonalPrism_57(HandleRef pThis);

		/// <summary>
		/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
		/// method. It allows vtkGenericCell to act like any cell type by
		/// dereferencing an internal instance of a concrete cell type. When
		/// you set the cell type, you are resetting a pointer to an internal
		/// cell which is then used for computation.
		/// </summary>
		// Token: 0x0601B86F RID: 112751 RVA: 0x00268631 File Offset: 0x00266831
		public void SetCellTypeToPentagonalPrism()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToPentagonalPrism_57(base.GetCppThis());
		}

		// Token: 0x0601B870 RID: 112752
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_SetCellTypeToPixel_58(HandleRef pThis);

		/// <summary>
		/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
		/// method. It allows vtkGenericCell to act like any cell type by
		/// dereferencing an internal instance of a concrete cell type. When
		/// you set the cell type, you are resetting a pointer to an internal
		/// cell which is then used for computation.
		/// </summary>
		// Token: 0x0601B871 RID: 112753 RVA: 0x00268640 File Offset: 0x00266840
		public void SetCellTypeToPixel()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToPixel_58(base.GetCppThis());
		}

		// Token: 0x0601B872 RID: 112754
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_SetCellTypeToPolyLine_59(HandleRef pThis);

		/// <summary>
		/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
		/// method. It allows vtkGenericCell to act like any cell type by
		/// dereferencing an internal instance of a concrete cell type. When
		/// you set the cell type, you are resetting a pointer to an internal
		/// cell which is then used for computation.
		/// </summary>
		// Token: 0x0601B873 RID: 112755 RVA: 0x0026864F File Offset: 0x0026684F
		public void SetCellTypeToPolyLine()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToPolyLine_59(base.GetCppThis());
		}

		// Token: 0x0601B874 RID: 112756
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_SetCellTypeToPolyVertex_60(HandleRef pThis);

		/// <summary>
		/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
		/// method. It allows vtkGenericCell to act like any cell type by
		/// dereferencing an internal instance of a concrete cell type. When
		/// you set the cell type, you are resetting a pointer to an internal
		/// cell which is then used for computation.
		/// </summary>
		// Token: 0x0601B875 RID: 112757 RVA: 0x0026865E File Offset: 0x0026685E
		public void SetCellTypeToPolyVertex()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToPolyVertex_60(base.GetCppThis());
		}

		// Token: 0x0601B876 RID: 112758
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_SetCellTypeToPolygon_61(HandleRef pThis);

		/// <summary>
		/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
		/// method. It allows vtkGenericCell to act like any cell type by
		/// dereferencing an internal instance of a concrete cell type. When
		/// you set the cell type, you are resetting a pointer to an internal
		/// cell which is then used for computation.
		/// </summary>
		// Token: 0x0601B877 RID: 112759 RVA: 0x0026866D File Offset: 0x0026686D
		public void SetCellTypeToPolygon()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToPolygon_61(base.GetCppThis());
		}

		// Token: 0x0601B878 RID: 112760
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_SetCellTypeToPolyhedron_62(HandleRef pThis);

		/// <summary>
		/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
		/// method. It allows vtkGenericCell to act like any cell type by
		/// dereferencing an internal instance of a concrete cell type. When
		/// you set the cell type, you are resetting a pointer to an internal
		/// cell which is then used for computation.
		/// </summary>
		// Token: 0x0601B879 RID: 112761 RVA: 0x0026867C File Offset: 0x0026687C
		public void SetCellTypeToPolyhedron()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToPolyhedron_62(base.GetCppThis());
		}

		// Token: 0x0601B87A RID: 112762
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_SetCellTypeToPyramid_63(HandleRef pThis);

		/// <summary>
		/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
		/// method. It allows vtkGenericCell to act like any cell type by
		/// dereferencing an internal instance of a concrete cell type. When
		/// you set the cell type, you are resetting a pointer to an internal
		/// cell which is then used for computation.
		/// </summary>
		// Token: 0x0601B87B RID: 112763 RVA: 0x0026868B File Offset: 0x0026688B
		public void SetCellTypeToPyramid()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToPyramid_63(base.GetCppThis());
		}

		// Token: 0x0601B87C RID: 112764
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_SetCellTypeToQuad_64(HandleRef pThis);

		/// <summary>
		/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
		/// method. It allows vtkGenericCell to act like any cell type by
		/// dereferencing an internal instance of a concrete cell type. When
		/// you set the cell type, you are resetting a pointer to an internal
		/// cell which is then used for computation.
		/// </summary>
		// Token: 0x0601B87D RID: 112765 RVA: 0x0026869A File Offset: 0x0026689A
		public void SetCellTypeToQuad()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToQuad_64(base.GetCppThis());
		}

		// Token: 0x0601B87E RID: 112766
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_SetCellTypeToQuadraticEdge_65(HandleRef pThis);

		/// <summary>
		/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
		/// method. It allows vtkGenericCell to act like any cell type by
		/// dereferencing an internal instance of a concrete cell type. When
		/// you set the cell type, you are resetting a pointer to an internal
		/// cell which is then used for computation.
		/// </summary>
		// Token: 0x0601B87F RID: 112767 RVA: 0x002686A9 File Offset: 0x002668A9
		public void SetCellTypeToQuadraticEdge()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToQuadraticEdge_65(base.GetCppThis());
		}

		// Token: 0x0601B880 RID: 112768
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_SetCellTypeToQuadraticHexahedron_66(HandleRef pThis);

		/// <summary>
		/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
		/// method. It allows vtkGenericCell to act like any cell type by
		/// dereferencing an internal instance of a concrete cell type. When
		/// you set the cell type, you are resetting a pointer to an internal
		/// cell which is then used for computation.
		/// </summary>
		// Token: 0x0601B881 RID: 112769 RVA: 0x002686B8 File Offset: 0x002668B8
		public void SetCellTypeToQuadraticHexahedron()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToQuadraticHexahedron_66(base.GetCppThis());
		}

		// Token: 0x0601B882 RID: 112770
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_SetCellTypeToQuadraticLinearQuad_67(HandleRef pThis);

		/// <summary>
		/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
		/// method. It allows vtkGenericCell to act like any cell type by
		/// dereferencing an internal instance of a concrete cell type. When
		/// you set the cell type, you are resetting a pointer to an internal
		/// cell which is then used for computation.
		/// </summary>
		// Token: 0x0601B883 RID: 112771 RVA: 0x002686C7 File Offset: 0x002668C7
		public void SetCellTypeToQuadraticLinearQuad()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToQuadraticLinearQuad_67(base.GetCppThis());
		}

		// Token: 0x0601B884 RID: 112772
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_SetCellTypeToQuadraticLinearWedge_68(HandleRef pThis);

		/// <summary>
		/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
		/// method. It allows vtkGenericCell to act like any cell type by
		/// dereferencing an internal instance of a concrete cell type. When
		/// you set the cell type, you are resetting a pointer to an internal
		/// cell which is then used for computation.
		/// </summary>
		// Token: 0x0601B885 RID: 112773 RVA: 0x002686D6 File Offset: 0x002668D6
		public void SetCellTypeToQuadraticLinearWedge()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToQuadraticLinearWedge_68(base.GetCppThis());
		}

		// Token: 0x0601B886 RID: 112774
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_SetCellTypeToQuadraticPolygon_69(HandleRef pThis);

		/// <summary>
		/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
		/// method. It allows vtkGenericCell to act like any cell type by
		/// dereferencing an internal instance of a concrete cell type. When
		/// you set the cell type, you are resetting a pointer to an internal
		/// cell which is then used for computation.
		/// </summary>
		// Token: 0x0601B887 RID: 112775 RVA: 0x002686E5 File Offset: 0x002668E5
		public void SetCellTypeToQuadraticPolygon()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToQuadraticPolygon_69(base.GetCppThis());
		}

		// Token: 0x0601B888 RID: 112776
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_SetCellTypeToQuadraticPyramid_70(HandleRef pThis);

		/// <summary>
		/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
		/// method. It allows vtkGenericCell to act like any cell type by
		/// dereferencing an internal instance of a concrete cell type. When
		/// you set the cell type, you are resetting a pointer to an internal
		/// cell which is then used for computation.
		/// </summary>
		// Token: 0x0601B889 RID: 112777 RVA: 0x002686F4 File Offset: 0x002668F4
		public void SetCellTypeToQuadraticPyramid()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToQuadraticPyramid_70(base.GetCppThis());
		}

		// Token: 0x0601B88A RID: 112778
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_SetCellTypeToQuadraticQuad_71(HandleRef pThis);

		/// <summary>
		/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
		/// method. It allows vtkGenericCell to act like any cell type by
		/// dereferencing an internal instance of a concrete cell type. When
		/// you set the cell type, you are resetting a pointer to an internal
		/// cell which is then used for computation.
		/// </summary>
		// Token: 0x0601B88B RID: 112779 RVA: 0x00268703 File Offset: 0x00266903
		public void SetCellTypeToQuadraticQuad()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToQuadraticQuad_71(base.GetCppThis());
		}

		// Token: 0x0601B88C RID: 112780
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_SetCellTypeToQuadraticTetra_72(HandleRef pThis);

		/// <summary>
		/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
		/// method. It allows vtkGenericCell to act like any cell type by
		/// dereferencing an internal instance of a concrete cell type. When
		/// you set the cell type, you are resetting a pointer to an internal
		/// cell which is then used for computation.
		/// </summary>
		// Token: 0x0601B88D RID: 112781 RVA: 0x00268712 File Offset: 0x00266912
		public void SetCellTypeToQuadraticTetra()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToQuadraticTetra_72(base.GetCppThis());
		}

		// Token: 0x0601B88E RID: 112782
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_SetCellTypeToQuadraticTriangle_73(HandleRef pThis);

		/// <summary>
		/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
		/// method. It allows vtkGenericCell to act like any cell type by
		/// dereferencing an internal instance of a concrete cell type. When
		/// you set the cell type, you are resetting a pointer to an internal
		/// cell which is then used for computation.
		/// </summary>
		// Token: 0x0601B88F RID: 112783 RVA: 0x00268721 File Offset: 0x00266921
		public void SetCellTypeToQuadraticTriangle()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToQuadraticTriangle_73(base.GetCppThis());
		}

		// Token: 0x0601B890 RID: 112784
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_SetCellTypeToQuadraticWedge_74(HandleRef pThis);

		/// <summary>
		/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
		/// method. It allows vtkGenericCell to act like any cell type by
		/// dereferencing an internal instance of a concrete cell type. When
		/// you set the cell type, you are resetting a pointer to an internal
		/// cell which is then used for computation.
		/// </summary>
		// Token: 0x0601B891 RID: 112785 RVA: 0x00268730 File Offset: 0x00266930
		public void SetCellTypeToQuadraticWedge()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToQuadraticWedge_74(base.GetCppThis());
		}

		// Token: 0x0601B892 RID: 112786
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_SetCellTypeToTetra_75(HandleRef pThis);

		/// <summary>
		/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
		/// method. It allows vtkGenericCell to act like any cell type by
		/// dereferencing an internal instance of a concrete cell type. When
		/// you set the cell type, you are resetting a pointer to an internal
		/// cell which is then used for computation.
		/// </summary>
		// Token: 0x0601B893 RID: 112787 RVA: 0x0026873F File Offset: 0x0026693F
		public void SetCellTypeToTetra()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToTetra_75(base.GetCppThis());
		}

		// Token: 0x0601B894 RID: 112788
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_SetCellTypeToTriQuadraticHexahedron_76(HandleRef pThis);

		/// <summary>
		/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
		/// method. It allows vtkGenericCell to act like any cell type by
		/// dereferencing an internal instance of a concrete cell type. When
		/// you set the cell type, you are resetting a pointer to an internal
		/// cell which is then used for computation.
		/// </summary>
		// Token: 0x0601B895 RID: 112789 RVA: 0x0026874E File Offset: 0x0026694E
		public void SetCellTypeToTriQuadraticHexahedron()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToTriQuadraticHexahedron_76(base.GetCppThis());
		}

		// Token: 0x0601B896 RID: 112790
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_SetCellTypeToTriQuadraticPyramid_77(HandleRef pThis);

		/// <summary>
		/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
		/// method. It allows vtkGenericCell to act like any cell type by
		/// dereferencing an internal instance of a concrete cell type. When
		/// you set the cell type, you are resetting a pointer to an internal
		/// cell which is then used for computation.
		/// </summary>
		// Token: 0x0601B897 RID: 112791 RVA: 0x0026875D File Offset: 0x0026695D
		public void SetCellTypeToTriQuadraticPyramid()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToTriQuadraticPyramid_77(base.GetCppThis());
		}

		// Token: 0x0601B898 RID: 112792
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_SetCellTypeToTriangle_78(HandleRef pThis);

		/// <summary>
		/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
		/// method. It allows vtkGenericCell to act like any cell type by
		/// dereferencing an internal instance of a concrete cell type. When
		/// you set the cell type, you are resetting a pointer to an internal
		/// cell which is then used for computation.
		/// </summary>
		// Token: 0x0601B899 RID: 112793 RVA: 0x0026876C File Offset: 0x0026696C
		public void SetCellTypeToTriangle()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToTriangle_78(base.GetCppThis());
		}

		// Token: 0x0601B89A RID: 112794
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_SetCellTypeToTriangleStrip_79(HandleRef pThis);

		/// <summary>
		/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
		/// method. It allows vtkGenericCell to act like any cell type by
		/// dereferencing an internal instance of a concrete cell type. When
		/// you set the cell type, you are resetting a pointer to an internal
		/// cell which is then used for computation.
		/// </summary>
		// Token: 0x0601B89B RID: 112795 RVA: 0x0026877B File Offset: 0x0026697B
		public void SetCellTypeToTriangleStrip()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToTriangleStrip_79(base.GetCppThis());
		}

		// Token: 0x0601B89C RID: 112796
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_SetCellTypeToVertex_80(HandleRef pThis);

		/// <summary>
		/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
		/// method. It allows vtkGenericCell to act like any cell type by
		/// dereferencing an internal instance of a concrete cell type. When
		/// you set the cell type, you are resetting a pointer to an internal
		/// cell which is then used for computation.
		/// </summary>
		// Token: 0x0601B89D RID: 112797 RVA: 0x0026878A File Offset: 0x0026698A
		public void SetCellTypeToVertex()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToVertex_80(base.GetCppThis());
		}

		// Token: 0x0601B89E RID: 112798
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_SetCellTypeToVoxel_81(HandleRef pThis);

		/// <summary>
		/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
		/// method. It allows vtkGenericCell to act like any cell type by
		/// dereferencing an internal instance of a concrete cell type. When
		/// you set the cell type, you are resetting a pointer to an internal
		/// cell which is then used for computation.
		/// </summary>
		// Token: 0x0601B89F RID: 112799 RVA: 0x00268799 File Offset: 0x00266999
		public void SetCellTypeToVoxel()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToVoxel_81(base.GetCppThis());
		}

		// Token: 0x0601B8A0 RID: 112800
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_SetCellTypeToWedge_82(HandleRef pThis);

		/// <summary>
		/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
		/// method. It allows vtkGenericCell to act like any cell type by
		/// dereferencing an internal instance of a concrete cell type. When
		/// you set the cell type, you are resetting a pointer to an internal
		/// cell which is then used for computation.
		/// </summary>
		// Token: 0x0601B8A1 RID: 112801 RVA: 0x002687A8 File Offset: 0x002669A8
		public void SetCellTypeToWedge()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToWedge_82(base.GetCppThis());
		}

		// Token: 0x0601B8A2 RID: 112802
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_SetFaces_83(HandleRef pThis, IntPtr faces);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B8A3 RID: 112803 RVA: 0x002687B7 File Offset: 0x002669B7
		public override void SetFaces(IntPtr faces)
		{
			vtkGenericCell.vtkGenericCell_SetFaces_83(base.GetCppThis(), faces);
		}

		// Token: 0x0601B8A4 RID: 112804
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_SetPointIds_84(HandleRef pThis, HandleRef pointIds);

		/// <summary>
		/// Set the point ids to use for this cell. This updates the internal cell
		/// storage as well as the public member variable PointIds.
		/// </summary>
		// Token: 0x0601B8A5 RID: 112805 RVA: 0x002687C8 File Offset: 0x002669C8
		public void SetPointIds(vtkIdList pointIds)
		{
			vtkGenericCell.vtkGenericCell_SetPointIds_84(base.GetCppThis(), (pointIds == null) ? default(HandleRef) : pointIds.GetCppThis());
		}

		// Token: 0x0601B8A6 RID: 112806
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_SetPoints_85(HandleRef pThis, HandleRef points);

		/// <summary>
		/// Set the points object to use for this cell. This updates the internal cell
		/// storage as well as the public member variable Points.
		/// </summary>
		// Token: 0x0601B8A7 RID: 112807 RVA: 0x002687F8 File Offset: 0x002669F8
		public void SetPoints(vtkPoints points)
		{
			vtkGenericCell.vtkGenericCell_SetPoints_85(base.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis());
		}

		// Token: 0x0601B8A8 RID: 112808
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCell_ShallowCopy_86(HandleRef pThis, HandleRef c);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B8A9 RID: 112809 RVA: 0x00268828 File Offset: 0x00266A28
		public override void ShallowCopy(vtkCell c)
		{
			vtkGenericCell.vtkGenericCell_ShallowCopy_86(base.GetCppThis(), (c == null) ? default(HandleRef) : c.GetCppThis());
		}

		// Token: 0x0601B8AA RID: 112810
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericCell_Triangulate_87(HandleRef pThis, int index, HandleRef ptIds, HandleRef pts);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B8AB RID: 112811 RVA: 0x00268858 File Offset: 0x00266A58
		public override int Triangulate(int index, vtkIdList ptIds, vtkPoints pts)
		{
			return vtkGenericCell.vtkGenericCell_Triangulate_87(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis(), (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601B8AC RID: 112812
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericCell_TriangulateIds_88(HandleRef pThis, int index, HandleRef ptIds);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B8AD RID: 112813 RVA: 0x002688A4 File Offset: 0x00266AA4
		public override int TriangulateIds(int index, vtkIdList ptIds)
		{
			return vtkGenericCell.vtkGenericCell_TriangulateIds_88(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		// Token: 0x0601B8AE RID: 112814
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericCell_TriangulateLocalIds_89(HandleRef pThis, int index, HandleRef ptIds);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B8AF RID: 112815 RVA: 0x002688DC File Offset: 0x00266ADC
		public override int TriangulateLocalIds(int index, vtkIdList ptIds)
		{
			return vtkGenericCell.vtkGenericCell_TriangulateLocalIds_89(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D8C RID: 7564
		public new const string MRFullTypeName = "Kitware.VTK.vtkGenericCell";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D8D RID: 7565
		public new static readonly string MRClassNameKey = "class vtkGenericCell";
	}
}
