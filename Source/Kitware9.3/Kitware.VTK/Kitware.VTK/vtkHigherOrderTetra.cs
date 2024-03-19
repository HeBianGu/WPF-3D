using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkHigherOrderTetra
	/// </summary>
	/// <remarks>
	///    A 3D cell that represents an arbitrary order HigherOrder tetrahedron
	///
	/// vtkHigherOrderTetra is a concrete implementation of vtkCell to represent a
	/// 3D tetrahedron using HigherOrder shape functions of user specified order.
	///
	/// The number of points in a HigherOrder cell determines the order over which they
	/// are iterated relative to the parametric coordinate system of the cell. The
	/// first points that are reported are vertices. They appear in the same order in
	/// which they would appear in linear cells. Mid-edge points are reported next.
	/// They are reported in sequence. For two- and three-dimensional (3D) cells, the
	/// following set of points to be reported are face points. Finally, 3D cells
	/// report points interior to their volume.
	/// </remarks>
	// Token: 0x02000A07 RID: 2567
	public abstract class vtkHigherOrderTetra : vtkNonLinearCell
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601AAAA RID: 109226 RVA: 0x00251974 File Offset: 0x0024FB74
		static vtkHigherOrderTetra()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHigherOrderTetra.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHigherOrderTetra"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601AAAB RID: 109227 RVA: 0x0025199C File Offset: 0x0024FB9C
		public vtkHigherOrderTetra(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601AAAC RID: 109228 RVA: 0x002519AA File Offset: 0x0024FBAA
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601AAAD RID: 109229
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderTetra_BarycentricIndex_01(long index, IntPtr bindex, long order);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AAAE RID: 109230 RVA: 0x002519B5 File Offset: 0x0024FBB5
		public static void BarycentricIndex(long index, IntPtr bindex, long order)
		{
			vtkHigherOrderTetra.vtkHigherOrderTetra_BarycentricIndex_01(index, bindex, order);
		}

		// Token: 0x0601AAAF RID: 109231
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderTetra_CellBoundary_02(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AAB0 RID: 109232 RVA: 0x002519C4 File Offset: 0x0024FBC4
		public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
		{
			return vtkHigherOrderTetra.vtkHigherOrderTetra_CellBoundary_02(base.GetCppThis(), subId, pcoords, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601AAB1 RID: 109233
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderTetra_Clip_03(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AAB2 RID: 109234 RVA: 0x002519FC File Offset: 0x0024FBFC
		public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
		{
			vtkHigherOrderTetra.vtkHigherOrderTetra_Clip_03(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis(), insideOut);
		}

		// Token: 0x0601AAB3 RID: 109235
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHigherOrderTetra_ComputeOrder_04(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AAB4 RID: 109236 RVA: 0x00251AB8 File Offset: 0x0024FCB8
		public long ComputeOrder()
		{
			return vtkHigherOrderTetra.vtkHigherOrderTetra_ComputeOrder_04(base.GetCppThis());
		}

		// Token: 0x0601AAB5 RID: 109237
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHigherOrderTetra_ComputeOrder_05(long nPoints);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AAB6 RID: 109238 RVA: 0x00251AD8 File Offset: 0x0024FCD8
		public static long ComputeOrder(long nPoints)
		{
			return vtkHigherOrderTetra.vtkHigherOrderTetra_ComputeOrder_05(nPoints);
		}

		// Token: 0x0601AAB7 RID: 109239
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderTetra_Contour_06(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AAB8 RID: 109240 RVA: 0x00251AF4 File Offset: 0x0024FCF4
		public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
		{
			vtkHigherOrderTetra.vtkHigherOrderTetra_Contour_06(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis());
		}

		// Token: 0x0601AAB9 RID: 109241
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderTetra_Derivatives_07(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AABA RID: 109242 RVA: 0x00251BDC File Offset: 0x0024FDDC
		public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
		{
			vtkHigherOrderTetra.vtkHigherOrderTetra_Derivatives_07(base.GetCppThis(), subId, pcoords, values, dim, derivs);
		}

		// Token: 0x0601AABB RID: 109243
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderTetra_EvaluateLocation_08(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AABC RID: 109244 RVA: 0x00251BF2 File Offset: 0x0024FDF2
		public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
		{
			vtkHigherOrderTetra.vtkHigherOrderTetra_EvaluateLocation_08(base.GetCppThis(), ref subId, pcoords, x, weights);
		}

		// Token: 0x0601AABD RID: 109245
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderTetra_EvaluatePosition_09(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AABE RID: 109246 RVA: 0x00251C08 File Offset: 0x0024FE08
		public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
		{
			return vtkHigherOrderTetra.vtkHigherOrderTetra_EvaluatePosition_09(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
		}

		// Token: 0x0601AABF RID: 109247
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderTetra_GetCellDimension_10(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AAC0 RID: 109248 RVA: 0x00251C30 File Offset: 0x0024FE30
		public override int GetCellDimension()
		{
			return vtkHigherOrderTetra.vtkHigherOrderTetra_GetCellDimension_10(base.GetCppThis());
		}

		// Token: 0x0601AAC1 RID: 109249
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderTetra_GetCellType_11(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AAC2 RID: 109250 RVA: 0x00251C50 File Offset: 0x0024FE50
		public override int GetCellType()
		{
			return vtkHigherOrderTetra.vtkHigherOrderTetra_GetCellType_11(base.GetCppThis());
		}

		// Token: 0x0601AAC3 RID: 109251
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderTetra_GetEdge_12(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AAC4 RID: 109252 RVA: 0x00251C70 File Offset: 0x0024FE70
		public override vtkCell GetEdge(int edgeId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHigherOrderTetra.vtkHigherOrderTetra_GetEdge_12(base.GetCppThis(), edgeId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601AAC5 RID: 109253
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderTetra_GetEdgeCell_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AAC6 RID: 109254 RVA: 0x00251CE0 File Offset: 0x0024FEE0
		public virtual vtkHigherOrderCurve GetEdgeCell()
		{
			vtkHigherOrderCurve vtkHigherOrderCurve = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHigherOrderTetra.vtkHigherOrderTetra_GetEdgeCell_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601AAC7 RID: 109255
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderTetra_GetFace_14(HandleRef pThis, int faceId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AAC8 RID: 109256 RVA: 0x00251D50 File Offset: 0x0024FF50
		public override vtkCell GetFace(int faceId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHigherOrderTetra.vtkHigherOrderTetra_GetFace_14(base.GetCppThis(), faceId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601AAC9 RID: 109257
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderTetra_GetFaceCell_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AACA RID: 109258 RVA: 0x00251DC0 File Offset: 0x0024FFC0
		public virtual vtkHigherOrderTriangle GetFaceCell()
		{
			vtkHigherOrderTriangle vtkHigherOrderTriangle = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHigherOrderTetra.vtkHigherOrderTetra_GetFaceCell_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHigherOrderTriangle = (vtkHigherOrderTriangle)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHigherOrderTriangle.Register(null);
				}
			}
			return vtkHigherOrderTriangle;
		}

		// Token: 0x0601AACB RID: 109259
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderTetra_GetNumberOfEdges_16(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AACC RID: 109260 RVA: 0x00251E30 File Offset: 0x00250030
		public override int GetNumberOfEdges()
		{
			return vtkHigherOrderTetra.vtkHigherOrderTetra_GetNumberOfEdges_16(base.GetCppThis());
		}

		// Token: 0x0601AACD RID: 109261
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderTetra_GetNumberOfFaces_17(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AACE RID: 109262 RVA: 0x00251E50 File Offset: 0x00250050
		public override int GetNumberOfFaces()
		{
			return vtkHigherOrderTetra.vtkHigherOrderTetra_GetNumberOfFaces_17(base.GetCppThis());
		}

		// Token: 0x0601AACF RID: 109263
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHigherOrderTetra_GetNumberOfGenerationsFromBase_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AAD0 RID: 109264 RVA: 0x00251E70 File Offset: 0x00250070
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkHigherOrderTetra.vtkHigherOrderTetra_GetNumberOfGenerationsFromBase_18(base.GetCppThis(), type);
		}

		// Token: 0x0601AAD1 RID: 109265
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHigherOrderTetra_GetNumberOfGenerationsFromBaseType_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AAD2 RID: 109266 RVA: 0x00251E90 File Offset: 0x00250090
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkHigherOrderTetra.vtkHigherOrderTetra_GetNumberOfGenerationsFromBaseType_19(type);
		}

		// Token: 0x0601AAD3 RID: 109267
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHigherOrderTetra_GetOrder_20(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AAD4 RID: 109268 RVA: 0x00251EAC File Offset: 0x002500AC
		public long GetOrder()
		{
			return vtkHigherOrderTetra.vtkHigherOrderTetra_GetOrder_20(base.GetCppThis());
		}

		// Token: 0x0601AAD5 RID: 109269
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderTetra_GetParametricCenter_21(HandleRef pThis, IntPtr pcoords);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AAD6 RID: 109270 RVA: 0x00251ECC File Offset: 0x002500CC
		public override int GetParametricCenter(IntPtr pcoords)
		{
			return vtkHigherOrderTetra.vtkHigherOrderTetra_GetParametricCenter_21(base.GetCppThis(), pcoords);
		}

		// Token: 0x0601AAD7 RID: 109271
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderTetra_GetParametricCoords_22(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AAD8 RID: 109272 RVA: 0x00251EEC File Offset: 0x002500EC
		public override IntPtr GetParametricCoords()
		{
			return vtkHigherOrderTetra.vtkHigherOrderTetra_GetParametricCoords_22(base.GetCppThis());
		}

		// Token: 0x0601AAD9 RID: 109273
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkHigherOrderTetra_GetParametricDistance_23(HandleRef pThis, IntPtr pcoords);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AADA RID: 109274 RVA: 0x00251F0C File Offset: 0x0025010C
		public override double GetParametricDistance(IntPtr pcoords)
		{
			return vtkHigherOrderTetra.vtkHigherOrderTetra_GetParametricDistance_23(base.GetCppThis(), pcoords);
		}

		// Token: 0x0601AADB RID: 109275
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHigherOrderTetra_Index_24(IntPtr bindex, long order);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AADC RID: 109276 RVA: 0x00251F2C File Offset: 0x0025012C
		public static long Index(IntPtr bindex, long order)
		{
			return vtkHigherOrderTetra.vtkHigherOrderTetra_Index_24(bindex, order);
		}

		// Token: 0x0601AADD RID: 109277
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderTetra_Initialize_25(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AADE RID: 109278 RVA: 0x00251F47 File Offset: 0x00250147
		public override void Initialize()
		{
			vtkHigherOrderTetra.vtkHigherOrderTetra_Initialize_25(base.GetCppThis());
		}

		// Token: 0x0601AADF RID: 109279
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderTetra_InterpolateDerivs_26(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AAE0 RID: 109280 RVA: 0x00251F56 File Offset: 0x00250156
		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkHigherOrderTetra.vtkHigherOrderTetra_InterpolateDerivs_26(base.GetCppThis(), pcoords, derivs);
		}

		// Token: 0x0601AAE1 RID: 109281
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderTetra_InterpolateFunctions_27(HandleRef pThis, IntPtr pcoords, IntPtr weights);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AAE2 RID: 109282 RVA: 0x00251F67 File Offset: 0x00250167
		public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkHigherOrderTetra.vtkHigherOrderTetra_InterpolateFunctions_27(base.GetCppThis(), pcoords, weights);
		}

		// Token: 0x0601AAE3 RID: 109283
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderTetra_IntersectWithLine_28(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AAE4 RID: 109284 RVA: 0x00251F78 File Offset: 0x00250178
		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkHigherOrderTetra.vtkHigherOrderTetra_IntersectWithLine_28(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		// Token: 0x0601AAE5 RID: 109285
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderTetra_IsA_29(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AAE6 RID: 109286 RVA: 0x00251FA4 File Offset: 0x002501A4
		public override int IsA(string type)
		{
			return vtkHigherOrderTetra.vtkHigherOrderTetra_IsA_29(base.GetCppThis(), type);
		}

		// Token: 0x0601AAE7 RID: 109287
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderTetra_IsTypeOf_30([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AAE8 RID: 109288 RVA: 0x00251FC4 File Offset: 0x002501C4
		public new static int IsTypeOf(string type)
		{
			return vtkHigherOrderTetra.vtkHigherOrderTetra_IsTypeOf_30(type);
		}

		// Token: 0x0601AAE9 RID: 109289
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderTetra_NewInstance_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AAEA RID: 109290 RVA: 0x00251FE0 File Offset: 0x002501E0
		public new vtkHigherOrderTetra NewInstance()
		{
			vtkHigherOrderTetra result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHigherOrderTetra.vtkHigherOrderTetra_NewInstance_31(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHigherOrderTetra)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601AAEB RID: 109291
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHigherOrderTetra_PointCountSupportsUniformOrder_32(long pointsPerCell);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AAEC RID: 109292 RVA: 0x0025203C File Offset: 0x0025023C
		public static bool PointCountSupportsUniformOrder(long pointsPerCell)
		{
			return vtkHigherOrderTetra.vtkHigherOrderTetra_PointCountSupportsUniformOrder_32(pointsPerCell) != 0;
		}

		// Token: 0x0601AAED RID: 109293
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderTetra_RequiresInitialization_33(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AAEE RID: 109294 RVA: 0x00252060 File Offset: 0x00250260
		public override int RequiresInitialization()
		{
			return vtkHigherOrderTetra.vtkHigherOrderTetra_RequiresInitialization_33(base.GetCppThis());
		}

		// Token: 0x0601AAEF RID: 109295
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderTetra_SafeDownCast_34(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AAF0 RID: 109296 RVA: 0x00252080 File Offset: 0x00250280
		public new static vtkHigherOrderTetra SafeDownCast(vtkObjectBase o)
		{
			vtkHigherOrderTetra vtkHigherOrderTetra = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHigherOrderTetra.vtkHigherOrderTetra_SafeDownCast_34((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHigherOrderTetra = (vtkHigherOrderTetra)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHigherOrderTetra.Register(null);
				}
			}
			return vtkHigherOrderTetra;
		}

		// Token: 0x0601AAF1 RID: 109297
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderTetra_SetParametricCoords_35(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AAF2 RID: 109298 RVA: 0x002520FF File Offset: 0x002502FF
		public void SetParametricCoords()
		{
			vtkHigherOrderTetra.vtkHigherOrderTetra_SetParametricCoords_35(base.GetCppThis());
		}

		// Token: 0x0601AAF3 RID: 109299
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderTetra_ToBarycentricIndex_36(HandleRef pThis, long index, IntPtr bindex);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AAF4 RID: 109300 RVA: 0x0025210E File Offset: 0x0025030E
		public void ToBarycentricIndex(long index, IntPtr bindex)
		{
			vtkHigherOrderTetra.vtkHigherOrderTetra_ToBarycentricIndex_36(base.GetCppThis(), index, bindex);
		}

		// Token: 0x0601AAF5 RID: 109301
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHigherOrderTetra_ToIndex_37(HandleRef pThis, IntPtr bindex);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AAF6 RID: 109302 RVA: 0x00252120 File Offset: 0x00250320
		public long ToIndex(IntPtr bindex)
		{
			return vtkHigherOrderTetra.vtkHigherOrderTetra_ToIndex_37(base.GetCppThis(), bindex);
		}

		// Token: 0x0601AAF7 RID: 109303
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderTetra_TriangulateLocalIds_38(HandleRef pThis, int index, HandleRef ptIds);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AAF8 RID: 109304 RVA: 0x00252140 File Offset: 0x00250340
		public override int TriangulateLocalIds(int index, vtkIdList ptIds)
		{
			return vtkHigherOrderTetra.vtkHigherOrderTetra_TriangulateLocalIds_38(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CE6 RID: 7398
		public new const string MRFullTypeName = "Kitware.VTK.vtkHigherOrderTetra";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CE7 RID: 7399
		public new static readonly string MRClassNameKey = "class vtkHigherOrderTetra";
	}
}
