using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPolyVertex
	/// </summary>
	/// <remarks>
	///    cell represents a set of 0D vertices
	///
	/// vtkPolyVertex is a concrete implementation of vtkCell to represent a
	/// set of 3D vertices.
	/// </remarks>
	// Token: 0x02000AA4 RID: 2724
	public class vtkPolyVertex : vtkCell
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601C99B RID: 117147 RVA: 0x00283023 File Offset: 0x00281223
		static vtkPolyVertex()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolyVertex.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyVertex"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601C99C RID: 117148 RVA: 0x0028304B File Offset: 0x0028124B
		public vtkPolyVertex(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601C99D RID: 117149
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyVertex_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C99E RID: 117150 RVA: 0x0028305C File Offset: 0x0028125C
		public new static vtkPolyVertex New()
		{
			vtkPolyVertex result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyVertex.vtkPolyVertex_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyVertex)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C99F RID: 117151 RVA: 0x002830B0 File Offset: 0x002812B0
		public vtkPolyVertex() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPolyVertex.vtkPolyVertex_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601C9A0 RID: 117152 RVA: 0x002830F4 File Offset: 0x002812F4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601C9A1 RID: 117153
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyVertex_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C9A2 RID: 117154 RVA: 0x00283100 File Offset: 0x00281300
		public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
		{
			return vtkPolyVertex.vtkPolyVertex_CellBoundary_01(base.GetCppThis(), subId, pcoords, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601C9A3 RID: 117155
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyVertex_Clip_02(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C9A4 RID: 117156 RVA: 0x00283138 File Offset: 0x00281338
		public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
		{
			vtkPolyVertex.vtkPolyVertex_Clip_02(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis(), insideOut);
		}

		// Token: 0x0601C9A5 RID: 117157
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyVertex_Contour_03(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C9A6 RID: 117158 RVA: 0x002831F4 File Offset: 0x002813F4
		public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
		{
			vtkPolyVertex.vtkPolyVertex_Contour_03(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis());
		}

		// Token: 0x0601C9A7 RID: 117159
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyVertex_Derivatives_04(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C9A8 RID: 117160 RVA: 0x002832DC File Offset: 0x002814DC
		public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
		{
			vtkPolyVertex.vtkPolyVertex_Derivatives_04(base.GetCppThis(), subId, pcoords, values, dim, derivs);
		}

		// Token: 0x0601C9A9 RID: 117161
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyVertex_EvaluateLocation_05(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C9AA RID: 117162 RVA: 0x002832F2 File Offset: 0x002814F2
		public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
		{
			vtkPolyVertex.vtkPolyVertex_EvaluateLocation_05(base.GetCppThis(), ref subId, pcoords, x, weights);
		}

		// Token: 0x0601C9AB RID: 117163
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyVertex_EvaluatePosition_06(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C9AC RID: 117164 RVA: 0x00283308 File Offset: 0x00281508
		public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
		{
			return vtkPolyVertex.vtkPolyVertex_EvaluatePosition_06(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
		}

		// Token: 0x0601C9AD RID: 117165
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyVertex_GetCellDimension_07(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C9AE RID: 117166 RVA: 0x00283330 File Offset: 0x00281530
		public override int GetCellDimension()
		{
			return vtkPolyVertex.vtkPolyVertex_GetCellDimension_07(base.GetCppThis());
		}

		// Token: 0x0601C9AF RID: 117167
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyVertex_GetCellType_08(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C9B0 RID: 117168 RVA: 0x00283350 File Offset: 0x00281550
		public override int GetCellType()
		{
			return vtkPolyVertex.vtkPolyVertex_GetCellType_08(base.GetCppThis());
		}

		// Token: 0x0601C9B1 RID: 117169
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyVertex_GetEdge_09(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C9B2 RID: 117170 RVA: 0x00283370 File Offset: 0x00281570
		public override vtkCell GetEdge(int arg0)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyVertex.vtkPolyVertex_GetEdge_09(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601C9B3 RID: 117171
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyVertex_GetFace_10(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C9B4 RID: 117172 RVA: 0x002833E0 File Offset: 0x002815E0
		public override vtkCell GetFace(int arg0)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyVertex.vtkPolyVertex_GetFace_10(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601C9B5 RID: 117173
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyVertex_GetNumberOfEdges_11(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C9B6 RID: 117174 RVA: 0x00283450 File Offset: 0x00281650
		public override int GetNumberOfEdges()
		{
			return vtkPolyVertex.vtkPolyVertex_GetNumberOfEdges_11(base.GetCppThis());
		}

		// Token: 0x0601C9B7 RID: 117175
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyVertex_GetNumberOfFaces_12(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C9B8 RID: 117176 RVA: 0x00283470 File Offset: 0x00281670
		public override int GetNumberOfFaces()
		{
			return vtkPolyVertex.vtkPolyVertex_GetNumberOfFaces_12(base.GetCppThis());
		}

		// Token: 0x0601C9B9 RID: 117177
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyVertex_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C9BA RID: 117178 RVA: 0x00283490 File Offset: 0x00281690
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPolyVertex.vtkPolyVertex_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x0601C9BB RID: 117179
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyVertex_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C9BC RID: 117180 RVA: 0x002834B0 File Offset: 0x002816B0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPolyVertex.vtkPolyVertex_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x0601C9BD RID: 117181
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyVertex_GetParametricCenter_15(HandleRef pThis, IntPtr pcoords);

		/// <summary>
		/// Return the center of the point cloud in parametric coordinates.
		/// </summary>
		// Token: 0x0601C9BE RID: 117182 RVA: 0x002834CC File Offset: 0x002816CC
		public override int GetParametricCenter(IntPtr pcoords)
		{
			return vtkPolyVertex.vtkPolyVertex_GetParametricCenter_15(base.GetCppThis(), pcoords);
		}

		// Token: 0x0601C9BF RID: 117183
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyVertex_IntersectWithLine_16(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C9C0 RID: 117184 RVA: 0x002834EC File Offset: 0x002816EC
		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkPolyVertex.vtkPolyVertex_IntersectWithLine_16(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		// Token: 0x0601C9C1 RID: 117185
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyVertex_IsA_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C9C2 RID: 117186 RVA: 0x00283518 File Offset: 0x00281718
		public override int IsA(string type)
		{
			return vtkPolyVertex.vtkPolyVertex_IsA_17(base.GetCppThis(), type);
		}

		// Token: 0x0601C9C3 RID: 117187
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyVertex_IsPrimaryCell_18(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C9C4 RID: 117188 RVA: 0x00283538 File Offset: 0x00281738
		public override int IsPrimaryCell()
		{
			return vtkPolyVertex.vtkPolyVertex_IsPrimaryCell_18(base.GetCppThis());
		}

		// Token: 0x0601C9C5 RID: 117189
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyVertex_IsTypeOf_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C9C6 RID: 117190 RVA: 0x00283558 File Offset: 0x00281758
		public new static int IsTypeOf(string type)
		{
			return vtkPolyVertex.vtkPolyVertex_IsTypeOf_19(type);
		}

		// Token: 0x0601C9C7 RID: 117191
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyVertex_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C9C8 RID: 117192 RVA: 0x00283574 File Offset: 0x00281774
		public new vtkPolyVertex NewInstance()
		{
			vtkPolyVertex result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyVertex.vtkPolyVertex_NewInstance_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyVertex)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601C9C9 RID: 117193
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyVertex_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C9CA RID: 117194 RVA: 0x002835D0 File Offset: 0x002817D0
		public new static vtkPolyVertex SafeDownCast(vtkObjectBase o)
		{
			vtkPolyVertex vtkPolyVertex = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyVertex.vtkPolyVertex_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyVertex = (vtkPolyVertex)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyVertex.Register(null);
				}
			}
			return vtkPolyVertex;
		}

		// Token: 0x0601C9CB RID: 117195
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyVertex_TriangulateLocalIds_23(HandleRef pThis, int index, HandleRef ptIds);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C9CC RID: 117196 RVA: 0x00283650 File Offset: 0x00281850
		public override int TriangulateLocalIds(int index, vtkIdList ptIds)
		{
			return vtkPolyVertex.vtkPolyVertex_TriangulateLocalIds_23(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E4F RID: 7759
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolyVertex";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E50 RID: 7760
		public new static readonly string MRClassNameKey = "class vtkPolyVertex";
	}
}
