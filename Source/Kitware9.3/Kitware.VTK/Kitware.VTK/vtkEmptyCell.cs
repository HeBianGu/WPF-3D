using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkEmptyCell
	/// </summary>
	/// <remarks>
	///    an empty cell used as a place-holder during processing
	///
	/// vtkEmptyCell is a concrete implementation of vtkCell. It is used
	/// during processing to represented a deleted element.
	/// </remarks>
	// Token: 0x02000A46 RID: 2630
	public class vtkEmptyCell : vtkCell
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601B646 RID: 112198 RVA: 0x002651FB File Offset: 0x002633FB
		static vtkEmptyCell()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEmptyCell.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEmptyCell"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601B647 RID: 112199 RVA: 0x00265223 File Offset: 0x00263423
		public vtkEmptyCell(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601B648 RID: 112200
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEmptyCell_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B649 RID: 112201 RVA: 0x00265234 File Offset: 0x00263434
		public new static vtkEmptyCell New()
		{
			vtkEmptyCell result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEmptyCell.vtkEmptyCell_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEmptyCell)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B64A RID: 112202 RVA: 0x00265288 File Offset: 0x00263488
		public vtkEmptyCell() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkEmptyCell.vtkEmptyCell_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601B64B RID: 112203 RVA: 0x002652CC File Offset: 0x002634CC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601B64C RID: 112204
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEmptyCell_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B64D RID: 112205 RVA: 0x002652D8 File Offset: 0x002634D8
		public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
		{
			return vtkEmptyCell.vtkEmptyCell_CellBoundary_01(base.GetCppThis(), subId, pcoords, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601B64E RID: 112206
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEmptyCell_Clip_02(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef pts, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B64F RID: 112207 RVA: 0x00265310 File Offset: 0x00263510
		public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray pts, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
		{
			vtkEmptyCell.vtkEmptyCell_Clip_02(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (pts == null) ? default(HandleRef) : pts.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis(), insideOut);
		}

		// Token: 0x0601B650 RID: 112208
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEmptyCell_Contour_03(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts1, HandleRef lines, HandleRef verts2, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B651 RID: 112209 RVA: 0x002653CC File Offset: 0x002635CC
		public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts1, vtkCellArray lines, vtkCellArray verts2, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
		{
			vtkEmptyCell.vtkEmptyCell_Contour_03(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts1 == null) ? default(HandleRef) : verts1.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (verts2 == null) ? default(HandleRef) : verts2.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis());
		}

		// Token: 0x0601B652 RID: 112210
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEmptyCell_Derivatives_04(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B653 RID: 112211 RVA: 0x002654B4 File Offset: 0x002636B4
		public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
		{
			vtkEmptyCell.vtkEmptyCell_Derivatives_04(base.GetCppThis(), subId, pcoords, values, dim, derivs);
		}

		// Token: 0x0601B654 RID: 112212
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEmptyCell_EvaluateLocation_05(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B655 RID: 112213 RVA: 0x002654CA File Offset: 0x002636CA
		public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
		{
			vtkEmptyCell.vtkEmptyCell_EvaluateLocation_05(base.GetCppThis(), ref subId, pcoords, x, weights);
		}

		// Token: 0x0601B656 RID: 112214
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEmptyCell_EvaluatePosition_06(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B657 RID: 112215 RVA: 0x002654E0 File Offset: 0x002636E0
		public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
		{
			return vtkEmptyCell.vtkEmptyCell_EvaluatePosition_06(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
		}

		// Token: 0x0601B658 RID: 112216
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEmptyCell_GetCellDimension_07(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B659 RID: 112217 RVA: 0x00265508 File Offset: 0x00263708
		public override int GetCellDimension()
		{
			return vtkEmptyCell.vtkEmptyCell_GetCellDimension_07(base.GetCppThis());
		}

		// Token: 0x0601B65A RID: 112218
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEmptyCell_GetCellType_08(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B65B RID: 112219 RVA: 0x00265528 File Offset: 0x00263728
		public override int GetCellType()
		{
			return vtkEmptyCell.vtkEmptyCell_GetCellType_08(base.GetCppThis());
		}

		// Token: 0x0601B65C RID: 112220
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEmptyCell_GetEdge_09(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B65D RID: 112221 RVA: 0x00265548 File Offset: 0x00263748
		public override vtkCell GetEdge(int arg0)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEmptyCell.vtkEmptyCell_GetEdge_09(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601B65E RID: 112222
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEmptyCell_GetFace_10(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B65F RID: 112223 RVA: 0x002655B8 File Offset: 0x002637B8
		public override vtkCell GetFace(int arg0)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEmptyCell.vtkEmptyCell_GetFace_10(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601B660 RID: 112224
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEmptyCell_GetNumberOfEdges_11(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B661 RID: 112225 RVA: 0x00265628 File Offset: 0x00263828
		public override int GetNumberOfEdges()
		{
			return vtkEmptyCell.vtkEmptyCell_GetNumberOfEdges_11(base.GetCppThis());
		}

		// Token: 0x0601B662 RID: 112226
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEmptyCell_GetNumberOfFaces_12(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B663 RID: 112227 RVA: 0x00265648 File Offset: 0x00263848
		public override int GetNumberOfFaces()
		{
			return vtkEmptyCell.vtkEmptyCell_GetNumberOfFaces_12(base.GetCppThis());
		}

		// Token: 0x0601B664 RID: 112228
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEmptyCell_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B665 RID: 112229 RVA: 0x00265668 File Offset: 0x00263868
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkEmptyCell.vtkEmptyCell_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x0601B666 RID: 112230
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEmptyCell_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B667 RID: 112231 RVA: 0x00265688 File Offset: 0x00263888
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkEmptyCell.vtkEmptyCell_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x0601B668 RID: 112232
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEmptyCell_IntersectWithLine_15(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B669 RID: 112233 RVA: 0x002656A4 File Offset: 0x002638A4
		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkEmptyCell.vtkEmptyCell_IntersectWithLine_15(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		// Token: 0x0601B66A RID: 112234
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEmptyCell_IsA_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B66B RID: 112235 RVA: 0x002656D0 File Offset: 0x002638D0
		public override int IsA(string type)
		{
			return vtkEmptyCell.vtkEmptyCell_IsA_16(base.GetCppThis(), type);
		}

		// Token: 0x0601B66C RID: 112236
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEmptyCell_IsTypeOf_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B66D RID: 112237 RVA: 0x002656F0 File Offset: 0x002638F0
		public new static int IsTypeOf(string type)
		{
			return vtkEmptyCell.vtkEmptyCell_IsTypeOf_17(type);
		}

		// Token: 0x0601B66E RID: 112238
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEmptyCell_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B66F RID: 112239 RVA: 0x0026570C File Offset: 0x0026390C
		public new vtkEmptyCell NewInstance()
		{
			vtkEmptyCell result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEmptyCell.vtkEmptyCell_NewInstance_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEmptyCell)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601B670 RID: 112240
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEmptyCell_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B671 RID: 112241 RVA: 0x00265768 File Offset: 0x00263968
		public new static vtkEmptyCell SafeDownCast(vtkObjectBase o)
		{
			vtkEmptyCell vtkEmptyCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEmptyCell.vtkEmptyCell_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEmptyCell = (vtkEmptyCell)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEmptyCell.Register(null);
				}
			}
			return vtkEmptyCell;
		}

		// Token: 0x0601B672 RID: 112242
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEmptyCell_TriangulateLocalIds_21(HandleRef pThis, int index, HandleRef ptIds);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B673 RID: 112243 RVA: 0x002657E8 File Offset: 0x002639E8
		public override int TriangulateLocalIds(int index, vtkIdList ptIds)
		{
			return vtkEmptyCell.vtkEmptyCell_TriangulateLocalIds_21(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D80 RID: 7552
		public new const string MRFullTypeName = "Kitware.VTK.vtkEmptyCell";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D81 RID: 7553
		public new static readonly string MRClassNameKey = "class vtkEmptyCell";
	}
}
