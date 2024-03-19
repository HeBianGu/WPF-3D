using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTriangleStrip
	/// </summary>
	/// <remarks>
	///    a cell that represents a triangle strip
	///
	/// vtkTriangleStrip is a concrete implementation of vtkCell to represent a 2D
	/// triangle strip. A triangle strip is a compact representation of triangles
	/// connected edge to edge in strip fashion. The connectivity of a triangle
	/// strip is three points defining an initial triangle, then for each
	/// additional triangle, a single point that, combined with the previous two
	/// points, defines the next triangle.
	/// </remarks>
	// Token: 0x02000ADC RID: 2780
	public class vtkTriangleStrip : vtkCell
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D498 RID: 119960 RVA: 0x00295191 File Offset: 0x00293391
		static vtkTriangleStrip()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTriangleStrip.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTriangleStrip"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D499 RID: 119961 RVA: 0x002951B9 File Offset: 0x002933B9
		public vtkTriangleStrip(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601D49A RID: 119962
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTriangleStrip_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D49B RID: 119963 RVA: 0x002951C8 File Offset: 0x002933C8
		public new static vtkTriangleStrip New()
		{
			vtkTriangleStrip result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTriangleStrip.vtkTriangleStrip_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTriangleStrip)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D49C RID: 119964 RVA: 0x0029521C File Offset: 0x0029341C
		public vtkTriangleStrip() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTriangleStrip.vtkTriangleStrip_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D49D RID: 119965 RVA: 0x00295260 File Offset: 0x00293460
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D49E RID: 119966
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriangleStrip_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D49F RID: 119967 RVA: 0x0029526C File Offset: 0x0029346C
		public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
		{
			return vtkTriangleStrip.vtkTriangleStrip_CellBoundary_01(base.GetCppThis(), subId, pcoords, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601D4A0 RID: 119968
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTriangleStrip_Clip_02(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D4A1 RID: 119969 RVA: 0x002952A4 File Offset: 0x002934A4
		public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
		{
			vtkTriangleStrip.vtkTriangleStrip_Clip_02(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis(), insideOut);
		}

		// Token: 0x0601D4A2 RID: 119970
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTriangleStrip_Contour_03(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D4A3 RID: 119971 RVA: 0x00295360 File Offset: 0x00293560
		public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
		{
			vtkTriangleStrip.vtkTriangleStrip_Contour_03(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis());
		}

		// Token: 0x0601D4A4 RID: 119972
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTriangleStrip_DecomposeStrip_04(int npts, IntPtr pts, HandleRef tris);

		/// <summary>
		/// Given a triangle strip, decompose it into a list of (triangle)
		/// polygons. The polygons are appended to the end of the list of triangles.
		/// </summary>
		// Token: 0x0601D4A5 RID: 119973 RVA: 0x00295448 File Offset: 0x00293648
		public static void DecomposeStrip(int npts, IntPtr pts, vtkCellArray tris)
		{
			vtkTriangleStrip.vtkTriangleStrip_DecomposeStrip_04(npts, pts, (tris == null) ? default(HandleRef) : tris.GetCppThis());
		}

		// Token: 0x0601D4A6 RID: 119974
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTriangleStrip_Derivatives_05(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D4A7 RID: 119975 RVA: 0x00295473 File Offset: 0x00293673
		public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
		{
			vtkTriangleStrip.vtkTriangleStrip_Derivatives_05(base.GetCppThis(), subId, pcoords, values, dim, derivs);
		}

		// Token: 0x0601D4A8 RID: 119976
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTriangleStrip_EvaluateLocation_06(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D4A9 RID: 119977 RVA: 0x00295489 File Offset: 0x00293689
		public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
		{
			vtkTriangleStrip.vtkTriangleStrip_EvaluateLocation_06(base.GetCppThis(), ref subId, pcoords, x, weights);
		}

		// Token: 0x0601D4AA RID: 119978
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriangleStrip_EvaluatePosition_07(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D4AB RID: 119979 RVA: 0x002954A0 File Offset: 0x002936A0
		public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
		{
			return vtkTriangleStrip.vtkTriangleStrip_EvaluatePosition_07(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
		}

		// Token: 0x0601D4AC RID: 119980
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriangleStrip_GetCellDimension_08(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D4AD RID: 119981 RVA: 0x002954C8 File Offset: 0x002936C8
		public override int GetCellDimension()
		{
			return vtkTriangleStrip.vtkTriangleStrip_GetCellDimension_08(base.GetCppThis());
		}

		// Token: 0x0601D4AE RID: 119982
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriangleStrip_GetCellType_09(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D4AF RID: 119983 RVA: 0x002954E8 File Offset: 0x002936E8
		public override int GetCellType()
		{
			return vtkTriangleStrip.vtkTriangleStrip_GetCellType_09(base.GetCppThis());
		}

		// Token: 0x0601D4B0 RID: 119984
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTriangleStrip_GetEdge_10(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D4B1 RID: 119985 RVA: 0x00295508 File Offset: 0x00293708
		public override vtkCell GetEdge(int edgeId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTriangleStrip.vtkTriangleStrip_GetEdge_10(base.GetCppThis(), edgeId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601D4B2 RID: 119986
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTriangleStrip_GetFace_11(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D4B3 RID: 119987 RVA: 0x00295578 File Offset: 0x00293778
		public override vtkCell GetFace(int arg0)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTriangleStrip.vtkTriangleStrip_GetFace_11(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601D4B4 RID: 119988
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriangleStrip_GetNumberOfEdges_12(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D4B5 RID: 119989 RVA: 0x002955E8 File Offset: 0x002937E8
		public override int GetNumberOfEdges()
		{
			return vtkTriangleStrip.vtkTriangleStrip_GetNumberOfEdges_12(base.GetCppThis());
		}

		// Token: 0x0601D4B6 RID: 119990
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriangleStrip_GetNumberOfFaces_13(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D4B7 RID: 119991 RVA: 0x00295608 File Offset: 0x00293808
		public override int GetNumberOfFaces()
		{
			return vtkTriangleStrip.vtkTriangleStrip_GetNumberOfFaces_13(base.GetCppThis());
		}

		// Token: 0x0601D4B8 RID: 119992
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTriangleStrip_GetNumberOfGenerationsFromBase_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D4B9 RID: 119993 RVA: 0x00295628 File Offset: 0x00293828
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTriangleStrip.vtkTriangleStrip_GetNumberOfGenerationsFromBase_14(base.GetCppThis(), type);
		}

		// Token: 0x0601D4BA RID: 119994
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTriangleStrip_GetNumberOfGenerationsFromBaseType_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D4BB RID: 119995 RVA: 0x00295648 File Offset: 0x00293848
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTriangleStrip.vtkTriangleStrip_GetNumberOfGenerationsFromBaseType_15(type);
		}

		// Token: 0x0601D4BC RID: 119996
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriangleStrip_GetParametricCenter_16(HandleRef pThis, IntPtr pcoords);

		/// <summary>
		/// Return the center of the point cloud in parametric coordinates.
		/// </summary>
		// Token: 0x0601D4BD RID: 119997 RVA: 0x00295664 File Offset: 0x00293864
		public override int GetParametricCenter(IntPtr pcoords)
		{
			return vtkTriangleStrip.vtkTriangleStrip_GetParametricCenter_16(base.GetCppThis(), pcoords);
		}

		// Token: 0x0601D4BE RID: 119998
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriangleStrip_IntersectWithLine_17(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D4BF RID: 119999 RVA: 0x00295684 File Offset: 0x00293884
		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkTriangleStrip.vtkTriangleStrip_IntersectWithLine_17(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		// Token: 0x0601D4C0 RID: 120000
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriangleStrip_IsA_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D4C1 RID: 120001 RVA: 0x002956B0 File Offset: 0x002938B0
		public override int IsA(string type)
		{
			return vtkTriangleStrip.vtkTriangleStrip_IsA_18(base.GetCppThis(), type);
		}

		// Token: 0x0601D4C2 RID: 120002
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriangleStrip_IsPrimaryCell_19(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D4C3 RID: 120003 RVA: 0x002956D0 File Offset: 0x002938D0
		public override int IsPrimaryCell()
		{
			return vtkTriangleStrip.vtkTriangleStrip_IsPrimaryCell_19(base.GetCppThis());
		}

		// Token: 0x0601D4C4 RID: 120004
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriangleStrip_IsTypeOf_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D4C5 RID: 120005 RVA: 0x002956F0 File Offset: 0x002938F0
		public new static int IsTypeOf(string type)
		{
			return vtkTriangleStrip.vtkTriangleStrip_IsTypeOf_20(type);
		}

		// Token: 0x0601D4C6 RID: 120006
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTriangleStrip_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D4C7 RID: 120007 RVA: 0x0029570C File Offset: 0x0029390C
		public new vtkTriangleStrip NewInstance()
		{
			vtkTriangleStrip result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTriangleStrip.vtkTriangleStrip_NewInstance_22(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTriangleStrip)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601D4C8 RID: 120008
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTriangleStrip_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D4C9 RID: 120009 RVA: 0x00295768 File Offset: 0x00293968
		public new static vtkTriangleStrip SafeDownCast(vtkObjectBase o)
		{
			vtkTriangleStrip vtkTriangleStrip = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTriangleStrip.vtkTriangleStrip_SafeDownCast_23((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTriangleStrip = (vtkTriangleStrip)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTriangleStrip.Register(null);
				}
			}
			return vtkTriangleStrip;
		}

		// Token: 0x0601D4CA RID: 120010
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriangleStrip_TriangulateLocalIds_24(HandleRef pThis, int index, HandleRef ptIds);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601D4CB RID: 120011 RVA: 0x002957E8 File Offset: 0x002939E8
		public override int TriangulateLocalIds(int index, vtkIdList ptIds)
		{
			return vtkTriangleStrip.vtkTriangleStrip_TriangulateLocalIds_24(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EDF RID: 7903
		public new const string MRFullTypeName = "Kitware.VTK.vtkTriangleStrip";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EE0 RID: 7904
		public new static readonly string MRClassNameKey = "class vtkTriangleStrip";
	}
}
