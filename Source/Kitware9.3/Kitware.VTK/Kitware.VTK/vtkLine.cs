using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLine
	/// </summary>
	/// <remarks>
	///    cell represents a 1D line
	///
	/// vtkLine is a concrete implementation of vtkCell to represent a 1D line.
	/// </remarks>
	// Token: 0x02000A7E RID: 2686
	public class vtkLine : vtkCell
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601C22A RID: 115242 RVA: 0x002775B3 File Offset: 0x002757B3
		static vtkLine()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLine.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLine"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601C22B RID: 115243 RVA: 0x002775DB File Offset: 0x002757DB
		public vtkLine(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601C22C RID: 115244
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLine_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C22D RID: 115245 RVA: 0x002775EC File Offset: 0x002757EC
		public new static vtkLine New()
		{
			vtkLine result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLine.vtkLine_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLine)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C22E RID: 115246 RVA: 0x00277640 File Offset: 0x00275840
		public vtkLine() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLine.vtkLine_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601C22F RID: 115247 RVA: 0x00277684 File Offset: 0x00275884
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601C230 RID: 115248
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLine_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C231 RID: 115249 RVA: 0x00277690 File Offset: 0x00275890
		public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
		{
			return vtkLine.vtkLine_CellBoundary_01(base.GetCppThis(), subId, pcoords, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601C232 RID: 115250
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLine_Clip_02(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef lines, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

		/// <summary>
		/// Clip this line using scalar value provided. Like contouring, except
		/// that it cuts the line to produce other lines.
		/// </summary>
		// Token: 0x0601C233 RID: 115251 RVA: 0x002776C8 File Offset: 0x002758C8
		public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray lines, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
		{
			vtkLine.vtkLine_Clip_02(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis(), insideOut);
		}

		// Token: 0x0601C234 RID: 115252
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLine_Contour_03(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C235 RID: 115253 RVA: 0x00277784 File Offset: 0x00275984
		public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
		{
			vtkLine.vtkLine_Contour_03(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis());
		}

		// Token: 0x0601C236 RID: 115254
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLine_Derivatives_04(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C237 RID: 115255 RVA: 0x0027786C File Offset: 0x00275A6C
		public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
		{
			vtkLine.vtkLine_Derivatives_04(base.GetCppThis(), subId, pcoords, values, dim, derivs);
		}

		// Token: 0x0601C238 RID: 115256
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLine_DistanceBetweenLineSegments_05(IntPtr l0, IntPtr l1, IntPtr m0, IntPtr m1, IntPtr closestPt1, IntPtr closestPt2, ref double t1, ref double t2);

		/// <summary>
		/// Computes the shortest distance squared between two finite line segments
		/// defined by their end points (l0,l1) and (m0,m1).
		/// Upon return, the closest points on the two line segments will be stored
		/// in closestPt1 and closestPt2. Their parametric coords (0 &lt;= t0, t1 &lt;= 1)
		/// will be stored in t0 and t1. The return value is the shortest distance
		/// squared between the two line-segments.
		/// </summary>
		// Token: 0x0601C239 RID: 115257 RVA: 0x00277884 File Offset: 0x00275A84
		public static double DistanceBetweenLineSegments(IntPtr l0, IntPtr l1, IntPtr m0, IntPtr m1, IntPtr closestPt1, IntPtr closestPt2, ref double t1, ref double t2)
		{
			return vtkLine.vtkLine_DistanceBetweenLineSegments_05(l0, l1, m0, m1, closestPt1, closestPt2, ref t1, ref t2);
		}

		// Token: 0x0601C23A RID: 115258
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLine_DistanceBetweenLines_06(IntPtr l0, IntPtr l1, IntPtr m0, IntPtr m1, IntPtr closestPt1, IntPtr closestPt2, ref double t1, ref double t2);

		/// <summary>
		/// Computes the shortest distance squared between two infinite lines, each
		/// defined by a pair of points (l0,l1) and (m0,m1).
		/// Upon return, the closest points on the two line segments will be stored
		/// in closestPt1 and closestPt2. Their parametric coords
		/// (-inf &lt;= t0, t1 &lt;= inf) will be stored in t0 and t1. The return value is
		/// the shortest distance squared between the two line-segments.
		/// </summary>
		// Token: 0x0601C23B RID: 115259 RVA: 0x002778AC File Offset: 0x00275AAC
		public static double DistanceBetweenLines(IntPtr l0, IntPtr l1, IntPtr m0, IntPtr m1, IntPtr closestPt1, IntPtr closestPt2, ref double t1, ref double t2)
		{
			return vtkLine.vtkLine_DistanceBetweenLines_06(l0, l1, m0, m1, closestPt1, closestPt2, ref t1, ref t2);
		}

		// Token: 0x0601C23C RID: 115260
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLine_DistanceToLine_07(IntPtr x, IntPtr p1, IntPtr p2, ref double t, IntPtr closestPoint);

		/// <summary>
		/// Compute the distance of a point x to a finite line (p1,p2). The method
		/// computes the parametric coordinate t and the point location on the
		/// line. Note that t is unconstrained (i.e., it may lie outside the range
		/// [0,1]) but the closest point will lie within the finite line [p1,p2], if
		/// it is defined. Also, the method returns the distance squared between x and
		/// the line (p1,p2).
		/// </summary>
		// Token: 0x0601C23D RID: 115261 RVA: 0x002778D4 File Offset: 0x00275AD4
		public static double DistanceToLine(IntPtr x, IntPtr p1, IntPtr p2, ref double t, IntPtr closestPoint)
		{
			return vtkLine.vtkLine_DistanceToLine_07(x, p1, p2, ref t, closestPoint);
		}

		// Token: 0x0601C23E RID: 115262
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLine_DistanceToLine_08(IntPtr x, IntPtr p1, IntPtr p2);

		/// <summary>
		/// Determine the distance of the current vertex to the edge defined by
		/// the vertices provided.  Returns distance squared. Note: line is assumed
		/// infinite in extent.
		/// </summary>
		// Token: 0x0601C23F RID: 115263 RVA: 0x002778F4 File Offset: 0x00275AF4
		public static double DistanceToLine(IntPtr x, IntPtr p1, IntPtr p2)
		{
			return vtkLine.vtkLine_DistanceToLine_08(x, p1, p2);
		}

		// Token: 0x0601C240 RID: 115264
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLine_EvaluateLocation_09(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C241 RID: 115265 RVA: 0x00277910 File Offset: 0x00275B10
		public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
		{
			vtkLine.vtkLine_EvaluateLocation_09(base.GetCppThis(), ref subId, pcoords, x, weights);
		}

		// Token: 0x0601C242 RID: 115266
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLine_EvaluatePosition_10(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C243 RID: 115267 RVA: 0x00277924 File Offset: 0x00275B24
		public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
		{
			return vtkLine.vtkLine_EvaluatePosition_10(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
		}

		// Token: 0x0601C244 RID: 115268
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLine_GetCellDimension_11(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C245 RID: 115269 RVA: 0x0027794C File Offset: 0x00275B4C
		public override int GetCellDimension()
		{
			return vtkLine.vtkLine_GetCellDimension_11(base.GetCppThis());
		}

		// Token: 0x0601C246 RID: 115270
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLine_GetCellType_12(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C247 RID: 115271 RVA: 0x0027796C File Offset: 0x00275B6C
		public override int GetCellType()
		{
			return vtkLine.vtkLine_GetCellType_12(base.GetCppThis());
		}

		// Token: 0x0601C248 RID: 115272
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLine_GetEdge_13(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C249 RID: 115273 RVA: 0x0027798C File Offset: 0x00275B8C
		public override vtkCell GetEdge(int arg0)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLine.vtkLine_GetEdge_13(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601C24A RID: 115274
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLine_GetFace_14(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C24B RID: 115275 RVA: 0x002779FC File Offset: 0x00275BFC
		public override vtkCell GetFace(int arg0)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLine.vtkLine_GetFace_14(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601C24C RID: 115276
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLine_GetNumberOfEdges_15(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C24D RID: 115277 RVA: 0x00277A6C File Offset: 0x00275C6C
		public override int GetNumberOfEdges()
		{
			return vtkLine.vtkLine_GetNumberOfEdges_15(base.GetCppThis());
		}

		// Token: 0x0601C24E RID: 115278
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLine_GetNumberOfFaces_16(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C24F RID: 115279 RVA: 0x00277A8C File Offset: 0x00275C8C
		public override int GetNumberOfFaces()
		{
			return vtkLine.vtkLine_GetNumberOfFaces_16(base.GetCppThis());
		}

		// Token: 0x0601C250 RID: 115280
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLine_GetNumberOfGenerationsFromBase_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C251 RID: 115281 RVA: 0x00277AAC File Offset: 0x00275CAC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLine.vtkLine_GetNumberOfGenerationsFromBase_17(base.GetCppThis(), type);
		}

		// Token: 0x0601C252 RID: 115282
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLine_GetNumberOfGenerationsFromBaseType_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C253 RID: 115283 RVA: 0x00277ACC File Offset: 0x00275CCC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLine.vtkLine_GetNumberOfGenerationsFromBaseType_18(type);
		}

		// Token: 0x0601C254 RID: 115284
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLine_GetParametricCenter_19(HandleRef pThis, IntPtr pcoords);

		/// <summary>
		/// Return the center of the triangle in parametric coordinates.
		/// </summary>
		// Token: 0x0601C255 RID: 115285 RVA: 0x00277AE8 File Offset: 0x00275CE8
		public override int GetParametricCenter(IntPtr pcoords)
		{
			return vtkLine.vtkLine_GetParametricCenter_19(base.GetCppThis(), pcoords);
		}

		// Token: 0x0601C256 RID: 115286
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLine_GetParametricCoords_20(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C257 RID: 115287 RVA: 0x00277B08 File Offset: 0x00275D08
		public override IntPtr GetParametricCoords()
		{
			return vtkLine.vtkLine_GetParametricCoords_20(base.GetCppThis());
		}

		// Token: 0x0601C258 RID: 115288
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLine_Inflate_21(HandleRef pThis, double dist);

		/// <summary>
		/// Inflates this line by extending both end by dist. A degenerate line remains
		/// untouched.
		///
		/// \return 1 if inflation was successful, 0 if no inflation was performed
		/// </summary>
		// Token: 0x0601C259 RID: 115289 RVA: 0x00277B28 File Offset: 0x00275D28
		public override int Inflate(double dist)
		{
			return vtkLine.vtkLine_Inflate_21(base.GetCppThis(), dist);
		}

		// Token: 0x0601C25A RID: 115290
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLine_InterpolateDerivs_22(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601C25B RID: 115291 RVA: 0x00277B48 File Offset: 0x00275D48
		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkLine.vtkLine_InterpolateDerivs_22(base.GetCppThis(), pcoords, derivs);
		}

		// Token: 0x0601C25C RID: 115292
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLine_InterpolateFunctions_23(HandleRef pThis, IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601C25D RID: 115293 RVA: 0x00277B59 File Offset: 0x00275D59
		public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkLine.vtkLine_InterpolateFunctions_23(base.GetCppThis(), pcoords, weights);
		}

		// Token: 0x0601C25E RID: 115294
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLine_InterpolationDerivs_24(IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Computes the shortest distance squared between two finite line segments
		/// defined by their end points (l0,l1) and (m0,m1).
		/// Upon return, the closest points on the two line segments will be stored
		/// in closestPt1 and closestPt2. Their parametric coords (0 &lt;= t0, t1 &lt;= 1)
		/// will be stored in t0 and t1. The return value is the shortest distance
		/// squared between the two line-segments.
		/// </summary>
		// Token: 0x0601C25F RID: 115295 RVA: 0x00277B6A File Offset: 0x00275D6A
		public static void InterpolationDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkLine.vtkLine_InterpolationDerivs_24(pcoords, derivs);
		}

		// Token: 0x0601C260 RID: 115296
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLine_InterpolationFunctions_25(IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Computes the shortest distance squared between two finite line segments
		/// defined by their end points (l0,l1) and (m0,m1).
		/// Upon return, the closest points on the two line segments will be stored
		/// in closestPt1 and closestPt2. Their parametric coords (0 &lt;= t0, t1 &lt;= 1)
		/// will be stored in t0 and t1. The return value is the shortest distance
		/// squared between the two line-segments.
		/// </summary>
		// Token: 0x0601C261 RID: 115297 RVA: 0x00277B75 File Offset: 0x00275D75
		public static void InterpolationFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkLine.vtkLine_InterpolationFunctions_25(pcoords, weights);
		}

		// Token: 0x0601C262 RID: 115298
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLine_IntersectWithLine_26(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		/// <summary>
		/// Line-line intersection. Intersection has to occur within [0,1] parametric
		/// coordinates and with specified tolerance.
		/// </summary>
		// Token: 0x0601C263 RID: 115299 RVA: 0x00277B80 File Offset: 0x00275D80
		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkLine.vtkLine_IntersectWithLine_26(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		// Token: 0x0601C264 RID: 115300
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLine_Intersection_27(IntPtr p1, IntPtr p2, IntPtr x1, IntPtr x2, ref double u, ref double v, double tolerance, int toleranceType);

		/// <summary>
		/// Performs intersection of the projection of two finite 3D lines onto a 2D
		/// plane. An intersection is found if the projection of the two lines onto
		/// the plane perpendicular to the cross product of the two lines intersect.
		/// The parameters (u,v) are the parametric coordinates of the lines at the
		/// position of closest approach.
		///
		/// The results are of type vtkLine::IntersectionType. An intersection occurs
		/// if (u,v) are in the interval [0,1] and the intersection point falls within
		/// the tolerance specified. Different types of tolerancing can be used by
		/// specifying a tolerance type with the enum provided (vtkLine::ToleranceType).
		/// The tolerance types may be: Relative) relative to the projection line lengths
		/// (this is default); or Absolute) the distance between the points at (u,v) on
		/// the two lines must be less than or equal to the tolerance specified.
		///
		/// </summary>
		// Token: 0x0601C265 RID: 115301 RVA: 0x00277BAC File Offset: 0x00275DAC
		public static int Intersection(IntPtr p1, IntPtr p2, IntPtr x1, IntPtr x2, ref double u, ref double v, double tolerance, int toleranceType)
		{
			return vtkLine.vtkLine_Intersection_27(p1, p2, x1, x2, ref u, ref v, tolerance, toleranceType);
		}

		// Token: 0x0601C266 RID: 115302
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLine_IsA_28(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C267 RID: 115303 RVA: 0x00277BD4 File Offset: 0x00275DD4
		public override int IsA(string type)
		{
			return vtkLine.vtkLine_IsA_28(base.GetCppThis(), type);
		}

		// Token: 0x0601C268 RID: 115304
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLine_IsTypeOf_29([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C269 RID: 115305 RVA: 0x00277BF4 File Offset: 0x00275DF4
		public new static int IsTypeOf(string type)
		{
			return vtkLine.vtkLine_IsTypeOf_29(type);
		}

		// Token: 0x0601C26A RID: 115306
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLine_NewInstance_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C26B RID: 115307 RVA: 0x00277C10 File Offset: 0x00275E10
		public new vtkLine NewInstance()
		{
			vtkLine result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLine.vtkLine_NewInstance_31(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLine)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601C26C RID: 115308
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLine_SafeDownCast_32(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C26D RID: 115309 RVA: 0x00277C6C File Offset: 0x00275E6C
		public new static vtkLine SafeDownCast(vtkObjectBase o)
		{
			vtkLine vtkLine = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLine.vtkLine_SafeDownCast_32((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLine = (vtkLine)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLine.Register(null);
				}
			}
			return vtkLine;
		}

		// Token: 0x0601C26E RID: 115310
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLine_TriangulateLocalIds_33(HandleRef pThis, int index, HandleRef ptIds);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C26F RID: 115311 RVA: 0x00277CEC File Offset: 0x00275EEC
		public override int TriangulateLocalIds(int index, vtkIdList ptIds)
		{
			return vtkLine.vtkLine_TriangulateLocalIds_33(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DF3 RID: 7667
		public new const string MRFullTypeName = "Kitware.VTK.vtkLine";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DF4 RID: 7668
		public new static readonly string MRClassNameKey = "class vtkLine";

		/// <summary>
		/// Line-line intersection. Intersection has to occur within [0,1] parametric
		/// coordinates and with specified tolerance.
		/// </summary>
		// Token: 0x02000A7F RID: 2687
		public enum IntersectionType
		{
			/// <summary>enum member</summary>
			// Token: 0x04001DF6 RID: 7670
			Intersect = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001DF7 RID: 7671
			NoIntersect = 0,
			/// <summary>enum member</summary>
			// Token: 0x04001DF8 RID: 7672
			OnLine = 3
		}

		/// <summary>
		/// Line-line intersection. Intersection has to occur within [0,1] parametric
		/// coordinates and with specified tolerance.
		/// </summary>
		// Token: 0x02000A80 RID: 2688
		public enum ToleranceType
		{
			/// <summary>enum member</summary>
			// Token: 0x04001DFA RID: 7674
			Absolute = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001DFB RID: 7675
			AbsoluteFuzzy = 3,
			/// <summary>enum member</summary>
			// Token: 0x04001DFC RID: 7676
			Relative = 0,
			/// <summary>enum member</summary>
			// Token: 0x04001DFD RID: 7677
			RelativeFuzzy = 2
		}
	}
}
