using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPolyLine
	/// </summary>
	/// <remarks>
	///    cell represents a set of 1D lines
	///
	/// vtkPolyLine is a concrete implementation of vtkCell to represent a set
	/// of 1D lines.
	/// </remarks>
	// Token: 0x02000AA2 RID: 2722
	public class vtkPolyLine : vtkCell
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601C949 RID: 117065 RVA: 0x002825E3 File Offset: 0x002807E3
		static vtkPolyLine()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolyLine.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyLine"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601C94A RID: 117066 RVA: 0x0028260B File Offset: 0x0028080B
		public vtkPolyLine(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601C94B RID: 117067
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyLine_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C94C RID: 117068 RVA: 0x0028261C File Offset: 0x0028081C
		public new static vtkPolyLine New()
		{
			vtkPolyLine result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyLine.vtkPolyLine_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyLine)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C94D RID: 117069 RVA: 0x00282670 File Offset: 0x00280870
		public vtkPolyLine() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPolyLine.vtkPolyLine_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601C94E RID: 117070 RVA: 0x002826B4 File Offset: 0x002808B4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601C94F RID: 117071
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyLine_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C950 RID: 117072 RVA: 0x002826C0 File Offset: 0x002808C0
		public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
		{
			return vtkPolyLine.vtkPolyLine_CellBoundary_01(base.GetCppThis(), subId, pcoords, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601C951 RID: 117073
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyLine_Clip_02(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef lines, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C952 RID: 117074 RVA: 0x002826F8 File Offset: 0x002808F8
		public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray lines, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
		{
			vtkPolyLine.vtkPolyLine_Clip_02(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis(), insideOut);
		}

		// Token: 0x0601C953 RID: 117075
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyLine_Contour_03(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C954 RID: 117076 RVA: 0x002827B4 File Offset: 0x002809B4
		public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
		{
			vtkPolyLine.vtkPolyLine_Contour_03(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis());
		}

		// Token: 0x0601C955 RID: 117077
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyLine_Derivatives_04(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C956 RID: 117078 RVA: 0x0028289C File Offset: 0x00280A9C
		public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
		{
			vtkPolyLine.vtkPolyLine_Derivatives_04(base.GetCppThis(), subId, pcoords, values, dim, derivs);
		}

		// Token: 0x0601C957 RID: 117079
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyLine_EvaluateLocation_05(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C958 RID: 117080 RVA: 0x002828B2 File Offset: 0x00280AB2
		public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
		{
			vtkPolyLine.vtkPolyLine_EvaluateLocation_05(base.GetCppThis(), ref subId, pcoords, x, weights);
		}

		// Token: 0x0601C959 RID: 117081
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyLine_EvaluatePosition_06(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C95A RID: 117082 RVA: 0x002828C8 File Offset: 0x00280AC8
		public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
		{
			return vtkPolyLine.vtkPolyLine_EvaluatePosition_06(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
		}

		// Token: 0x0601C95B RID: 117083
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyLine_GenerateSlidingNormals_07(HandleRef pts, HandleRef lines, HandleRef normals);

		/// <summary>
		/// Given points and lines, compute normals to the lines. These are not true
		/// normals, they are "orientation" normals used by classes like
		/// vtkTubeFilter that control the rotation around the line. The normals try
		/// to stay pointing in the same direction as much as possible (i.e.,
		/// minimal rotation) w.r.t the firstNormal (which is computed if
		/// firstnormal=nullptr). Always returns 1 (success). Note that it is
		/// possible to thread this computation by setting "threading=true". However
		/// make sure that none of the points are used more than one time if
		/// threading is enabled, otherwise a data race will be produced.
		/// </summary>
		// Token: 0x0601C95C RID: 117084 RVA: 0x002828F0 File Offset: 0x00280AF0
		public static int GenerateSlidingNormals(vtkPoints pts, vtkCellArray lines, vtkDataArray normals)
		{
			return vtkPolyLine.vtkPolyLine_GenerateSlidingNormals_07((pts == null) ? default(HandleRef) : pts.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (normals == null) ? default(HandleRef) : normals.GetCppThis());
		}

		// Token: 0x0601C95D RID: 117085
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyLine_GenerateSlidingNormals_08(HandleRef pts, HandleRef lines, HandleRef normals, IntPtr firstNormal, byte threading);

		/// <summary>
		/// Given points and lines, compute normals to the lines. These are not true
		/// normals, they are "orientation" normals used by classes like
		/// vtkTubeFilter that control the rotation around the line. The normals try
		/// to stay pointing in the same direction as much as possible (i.e.,
		/// minimal rotation) w.r.t the firstNormal (which is computed if
		/// firstnormal=nullptr). Always returns 1 (success). Note that it is
		/// possible to thread this computation by setting "threading=true". However
		/// make sure that none of the points are used more than one time if
		/// threading is enabled, otherwise a data race will be produced.
		/// </summary>
		// Token: 0x0601C95E RID: 117086 RVA: 0x00282948 File Offset: 0x00280B48
		public static int GenerateSlidingNormals(vtkPoints pts, vtkCellArray lines, vtkDataArray normals, IntPtr firstNormal, bool threading)
		{
			return vtkPolyLine.vtkPolyLine_GenerateSlidingNormals_08((pts == null) ? default(HandleRef) : pts.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (normals == null) ? default(HandleRef) : normals.GetCppThis(), firstNormal, threading ? (byte)1 : (byte)0);
		}

		// Token: 0x0601C95F RID: 117087
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyLine_GetCellDimension_09(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C960 RID: 117088 RVA: 0x002829AC File Offset: 0x00280BAC
		public override int GetCellDimension()
		{
			return vtkPolyLine.vtkPolyLine_GetCellDimension_09(base.GetCppThis());
		}

		// Token: 0x0601C961 RID: 117089
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyLine_GetCellType_10(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C962 RID: 117090 RVA: 0x002829CC File Offset: 0x00280BCC
		public override int GetCellType()
		{
			return vtkPolyLine.vtkPolyLine_GetCellType_10(base.GetCppThis());
		}

		// Token: 0x0601C963 RID: 117091
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyLine_GetEdge_11(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C964 RID: 117092 RVA: 0x002829EC File Offset: 0x00280BEC
		public override vtkCell GetEdge(int arg0)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyLine.vtkPolyLine_GetEdge_11(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601C965 RID: 117093
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyLine_GetFace_12(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C966 RID: 117094 RVA: 0x00282A5C File Offset: 0x00280C5C
		public override vtkCell GetFace(int arg0)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyLine.vtkPolyLine_GetFace_12(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601C967 RID: 117095
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyLine_GetNumberOfEdges_13(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C968 RID: 117096 RVA: 0x00282ACC File Offset: 0x00280CCC
		public override int GetNumberOfEdges()
		{
			return vtkPolyLine.vtkPolyLine_GetNumberOfEdges_13(base.GetCppThis());
		}

		// Token: 0x0601C969 RID: 117097
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyLine_GetNumberOfFaces_14(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C96A RID: 117098 RVA: 0x00282AEC File Offset: 0x00280CEC
		public override int GetNumberOfFaces()
		{
			return vtkPolyLine.vtkPolyLine_GetNumberOfFaces_14(base.GetCppThis());
		}

		// Token: 0x0601C96B RID: 117099
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyLine_GetNumberOfGenerationsFromBase_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C96C RID: 117100 RVA: 0x00282B0C File Offset: 0x00280D0C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPolyLine.vtkPolyLine_GetNumberOfGenerationsFromBase_15(base.GetCppThis(), type);
		}

		// Token: 0x0601C96D RID: 117101
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyLine_GetNumberOfGenerationsFromBaseType_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C96E RID: 117102 RVA: 0x00282B2C File Offset: 0x00280D2C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPolyLine.vtkPolyLine_GetNumberOfGenerationsFromBaseType_16(type);
		}

		// Token: 0x0601C96F RID: 117103
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyLine_GetParametricCenter_17(HandleRef pThis, IntPtr pcoords);

		/// <summary>
		/// Return the center of the point cloud in parametric coordinates.
		/// </summary>
		// Token: 0x0601C970 RID: 117104 RVA: 0x00282B48 File Offset: 0x00280D48
		public override int GetParametricCenter(IntPtr pcoords)
		{
			return vtkPolyLine.vtkPolyLine_GetParametricCenter_17(base.GetCppThis(), pcoords);
		}

		// Token: 0x0601C971 RID: 117105
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyLine_IntersectWithLine_18(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C972 RID: 117106 RVA: 0x00282B68 File Offset: 0x00280D68
		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkPolyLine.vtkPolyLine_IntersectWithLine_18(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		// Token: 0x0601C973 RID: 117107
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyLine_IsA_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C974 RID: 117108 RVA: 0x00282B94 File Offset: 0x00280D94
		public override int IsA(string type)
		{
			return vtkPolyLine.vtkPolyLine_IsA_19(base.GetCppThis(), type);
		}

		// Token: 0x0601C975 RID: 117109
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyLine_IsPrimaryCell_20(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C976 RID: 117110 RVA: 0x00282BB4 File Offset: 0x00280DB4
		public override int IsPrimaryCell()
		{
			return vtkPolyLine.vtkPolyLine_IsPrimaryCell_20(base.GetCppThis());
		}

		// Token: 0x0601C977 RID: 117111
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyLine_IsTypeOf_21([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C978 RID: 117112 RVA: 0x00282BD4 File Offset: 0x00280DD4
		public new static int IsTypeOf(string type)
		{
			return vtkPolyLine.vtkPolyLine_IsTypeOf_21(type);
		}

		// Token: 0x0601C979 RID: 117113
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyLine_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C97A RID: 117114 RVA: 0x00282BF0 File Offset: 0x00280DF0
		public new vtkPolyLine NewInstance()
		{
			vtkPolyLine result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyLine.vtkPolyLine_NewInstance_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyLine)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601C97B RID: 117115
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyLine_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C97C RID: 117116 RVA: 0x00282C4C File Offset: 0x00280E4C
		public new static vtkPolyLine SafeDownCast(vtkObjectBase o)
		{
			vtkPolyLine vtkPolyLine = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyLine.vtkPolyLine_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyLine = (vtkPolyLine)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyLine.Register(null);
				}
			}
			return vtkPolyLine;
		}

		// Token: 0x0601C97D RID: 117117
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyLine_TriangulateLocalIds_25(HandleRef pThis, int index, HandleRef ptIds);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C97E RID: 117118 RVA: 0x00282CCC File Offset: 0x00280ECC
		public override int TriangulateLocalIds(int index, vtkIdList ptIds)
		{
			return vtkPolyLine.vtkPolyLine_TriangulateLocalIds_25(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E4B RID: 7755
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolyLine";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E4C RID: 7756
		public new static readonly string MRClassNameKey = "class vtkPolyLine";
	}
}
