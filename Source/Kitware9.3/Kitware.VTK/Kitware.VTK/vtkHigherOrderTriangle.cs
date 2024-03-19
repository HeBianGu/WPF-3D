using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkHigherOrderTriangle
	/// </summary>
	/// <remarks>
	///    A 2D cell that represents an arbitrary order HigherOrder triangle
	///
	/// vtkHigherOrderTriangle is a concrete implementation of vtkCell to represent a
	/// 2D triangle using HigherOrder shape functions of user specified order.
	///
	/// The number of points in a HigherOrder cell determines the order over which they
	/// are iterated relative to the parametric coordinate system of the cell. The
	/// first points that are reported are vertices. They appear in the same order in
	/// which they would appear in linear cells. Mid-edge points are reported next.
	/// They are reported in sequence. For two- and three-dimensional (3D) cells, the
	/// following set of points to be reported are face points. Finally, 3D cells
	/// report points interior to their volume.
	/// </remarks>
	// Token: 0x02000A09 RID: 2569
	public abstract class vtkHigherOrderTriangle : vtkNonLinearCell
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601AB1D RID: 109341 RVA: 0x00252648 File Offset: 0x00250848
		static vtkHigherOrderTriangle()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHigherOrderTriangle.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHigherOrderTriangle"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601AB1E RID: 109342 RVA: 0x00252670 File Offset: 0x00250870
		public vtkHigherOrderTriangle(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601AB1F RID: 109343 RVA: 0x0025267E File Offset: 0x0025087E
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601AB20 RID: 109344
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderTriangle_BarycentricIndex_01(long index, IntPtr bindex, long order);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB21 RID: 109345 RVA: 0x00252689 File Offset: 0x00250889
		public static void BarycentricIndex(long index, IntPtr bindex, long order)
		{
			vtkHigherOrderTriangle.vtkHigherOrderTriangle_BarycentricIndex_01(index, bindex, order);
		}

		// Token: 0x0601AB22 RID: 109346
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderTriangle_CellBoundary_02(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB23 RID: 109347 RVA: 0x00252698 File Offset: 0x00250898
		public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
		{
			return vtkHigherOrderTriangle.vtkHigherOrderTriangle_CellBoundary_02(base.GetCppThis(), subId, pcoords, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601AB24 RID: 109348
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderTriangle_Clip_03(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB25 RID: 109349 RVA: 0x002526D0 File Offset: 0x002508D0
		public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
		{
			vtkHigherOrderTriangle.vtkHigherOrderTriangle_Clip_03(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis(), insideOut);
		}

		// Token: 0x0601AB26 RID: 109350
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHigherOrderTriangle_ComputeOrder_04(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB27 RID: 109351 RVA: 0x0025278C File Offset: 0x0025098C
		public long ComputeOrder()
		{
			return vtkHigherOrderTriangle.vtkHigherOrderTriangle_ComputeOrder_04(base.GetCppThis());
		}

		// Token: 0x0601AB28 RID: 109352
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderTriangle_Contour_05(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB29 RID: 109353 RVA: 0x002527AC File Offset: 0x002509AC
		public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
		{
			vtkHigherOrderTriangle.vtkHigherOrderTriangle_Contour_05(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis());
		}

		// Token: 0x0601AB2A RID: 109354
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderTriangle_Derivatives_06(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB2B RID: 109355 RVA: 0x00252894 File Offset: 0x00250A94
		public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
		{
			vtkHigherOrderTriangle.vtkHigherOrderTriangle_Derivatives_06(base.GetCppThis(), subId, pcoords, values, dim, derivs);
		}

		// Token: 0x0601AB2C RID: 109356
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkHigherOrderTriangle_Deta_07(long n, long chi, double sigma);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB2D RID: 109357 RVA: 0x002528AC File Offset: 0x00250AAC
		public static double Deta(long n, long chi, double sigma)
		{
			return vtkHigherOrderTriangle.vtkHigherOrderTriangle_Deta_07(n, chi, sigma);
		}

		// Token: 0x0601AB2E RID: 109358
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkHigherOrderTriangle_Eta_08(long n, long chi, double sigma);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB2F RID: 109359 RVA: 0x002528C8 File Offset: 0x00250AC8
		public static double Eta(long n, long chi, double sigma)
		{
			return vtkHigherOrderTriangle.vtkHigherOrderTriangle_Eta_08(n, chi, sigma);
		}

		// Token: 0x0601AB30 RID: 109360
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderTriangle_EvaluateLocation_09(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB31 RID: 109361 RVA: 0x002528E4 File Offset: 0x00250AE4
		public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
		{
			vtkHigherOrderTriangle.vtkHigherOrderTriangle_EvaluateLocation_09(base.GetCppThis(), ref subId, pcoords, x, weights);
		}

		// Token: 0x0601AB32 RID: 109362
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderTriangle_EvaluatePosition_10(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB33 RID: 109363 RVA: 0x002528F8 File Offset: 0x00250AF8
		public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
		{
			return vtkHigherOrderTriangle.vtkHigherOrderTriangle_EvaluatePosition_10(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
		}

		// Token: 0x0601AB34 RID: 109364
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderTriangle_GetCellDimension_11(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB35 RID: 109365 RVA: 0x00252920 File Offset: 0x00250B20
		public override int GetCellDimension()
		{
			return vtkHigherOrderTriangle.vtkHigherOrderTriangle_GetCellDimension_11(base.GetCppThis());
		}

		// Token: 0x0601AB36 RID: 109366
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderTriangle_GetCellType_12(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB37 RID: 109367 RVA: 0x00252940 File Offset: 0x00250B40
		public override int GetCellType()
		{
			return vtkHigherOrderTriangle.vtkHigherOrderTriangle_GetCellType_12(base.GetCppThis());
		}

		// Token: 0x0601AB38 RID: 109368
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderTriangle_GetEdge_13(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB39 RID: 109369 RVA: 0x00252960 File Offset: 0x00250B60
		public override vtkCell GetEdge(int edgeId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHigherOrderTriangle.vtkHigherOrderTriangle_GetEdge_13(base.GetCppThis(), edgeId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601AB3A RID: 109370
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderTriangle_GetEdgeCell_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB3B RID: 109371 RVA: 0x002529D0 File Offset: 0x00250BD0
		public virtual vtkHigherOrderCurve GetEdgeCell()
		{
			vtkHigherOrderCurve vtkHigherOrderCurve = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHigherOrderTriangle.vtkHigherOrderTriangle_GetEdgeCell_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601AB3C RID: 109372
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderTriangle_GetFace_15(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB3D RID: 109373 RVA: 0x00252A40 File Offset: 0x00250C40
		public override vtkCell GetFace(int arg0)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHigherOrderTriangle.vtkHigherOrderTriangle_GetFace_15(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601AB3E RID: 109374
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderTriangle_GetNumberOfEdges_16(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB3F RID: 109375 RVA: 0x00252AB0 File Offset: 0x00250CB0
		public override int GetNumberOfEdges()
		{
			return vtkHigherOrderTriangle.vtkHigherOrderTriangle_GetNumberOfEdges_16(base.GetCppThis());
		}

		// Token: 0x0601AB40 RID: 109376
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderTriangle_GetNumberOfFaces_17(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB41 RID: 109377 RVA: 0x00252AD0 File Offset: 0x00250CD0
		public override int GetNumberOfFaces()
		{
			return vtkHigherOrderTriangle.vtkHigherOrderTriangle_GetNumberOfFaces_17(base.GetCppThis());
		}

		// Token: 0x0601AB42 RID: 109378
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHigherOrderTriangle_GetNumberOfGenerationsFromBase_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB43 RID: 109379 RVA: 0x00252AF0 File Offset: 0x00250CF0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkHigherOrderTriangle.vtkHigherOrderTriangle_GetNumberOfGenerationsFromBase_18(base.GetCppThis(), type);
		}

		// Token: 0x0601AB44 RID: 109380
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHigherOrderTriangle_GetNumberOfGenerationsFromBaseType_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB45 RID: 109381 RVA: 0x00252B10 File Offset: 0x00250D10
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkHigherOrderTriangle.vtkHigherOrderTriangle_GetNumberOfGenerationsFromBaseType_19(type);
		}

		// Token: 0x0601AB46 RID: 109382
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHigherOrderTriangle_GetOrder_20(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB47 RID: 109383 RVA: 0x00252B2C File Offset: 0x00250D2C
		public long GetOrder()
		{
			return vtkHigherOrderTriangle.vtkHigherOrderTriangle_GetOrder_20(base.GetCppThis());
		}

		// Token: 0x0601AB48 RID: 109384
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderTriangle_GetParametricCenter_21(HandleRef pThis, IntPtr pcoords);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB49 RID: 109385 RVA: 0x00252B4C File Offset: 0x00250D4C
		public override int GetParametricCenter(IntPtr pcoords)
		{
			return vtkHigherOrderTriangle.vtkHigherOrderTriangle_GetParametricCenter_21(base.GetCppThis(), pcoords);
		}

		// Token: 0x0601AB4A RID: 109386
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderTriangle_GetParametricCoords_22(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB4B RID: 109387 RVA: 0x00252B6C File Offset: 0x00250D6C
		public override IntPtr GetParametricCoords()
		{
			return vtkHigherOrderTriangle.vtkHigherOrderTriangle_GetParametricCoords_22(base.GetCppThis());
		}

		// Token: 0x0601AB4C RID: 109388
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkHigherOrderTriangle_GetParametricDistance_23(HandleRef pThis, IntPtr pcoords);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB4D RID: 109389 RVA: 0x00252B8C File Offset: 0x00250D8C
		public override double GetParametricDistance(IntPtr pcoords)
		{
			return vtkHigherOrderTriangle.vtkHigherOrderTriangle_GetParametricDistance_23(base.GetCppThis(), pcoords);
		}

		// Token: 0x0601AB4E RID: 109390
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHigherOrderTriangle_Index_24(IntPtr bindex, long order);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB4F RID: 109391 RVA: 0x00252BAC File Offset: 0x00250DAC
		public static long Index(IntPtr bindex, long order)
		{
			return vtkHigherOrderTriangle.vtkHigherOrderTriangle_Index_24(bindex, order);
		}

		// Token: 0x0601AB50 RID: 109392
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderTriangle_Initialize_25(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB51 RID: 109393 RVA: 0x00252BC7 File Offset: 0x00250DC7
		public override void Initialize()
		{
			vtkHigherOrderTriangle.vtkHigherOrderTriangle_Initialize_25(base.GetCppThis());
		}

		// Token: 0x0601AB52 RID: 109394
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderTriangle_InterpolateDerivs_26(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB53 RID: 109395 RVA: 0x00252BD6 File Offset: 0x00250DD6
		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkHigherOrderTriangle.vtkHigherOrderTriangle_InterpolateDerivs_26(base.GetCppThis(), pcoords, derivs);
		}

		// Token: 0x0601AB54 RID: 109396
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderTriangle_InterpolateFunctions_27(HandleRef pThis, IntPtr pcoords, IntPtr weights);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB55 RID: 109397 RVA: 0x00252BE7 File Offset: 0x00250DE7
		public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkHigherOrderTriangle.vtkHigherOrderTriangle_InterpolateFunctions_27(base.GetCppThis(), pcoords, weights);
		}

		// Token: 0x0601AB56 RID: 109398
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderTriangle_IntersectWithLine_28(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB57 RID: 109399 RVA: 0x00252BF8 File Offset: 0x00250DF8
		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkHigherOrderTriangle.vtkHigherOrderTriangle_IntersectWithLine_28(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		// Token: 0x0601AB58 RID: 109400
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderTriangle_IsA_29(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB59 RID: 109401 RVA: 0x00252C24 File Offset: 0x00250E24
		public override int IsA(string type)
		{
			return vtkHigherOrderTriangle.vtkHigherOrderTriangle_IsA_29(base.GetCppThis(), type);
		}

		// Token: 0x0601AB5A RID: 109402
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderTriangle_IsTypeOf_30([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB5B RID: 109403 RVA: 0x00252C44 File Offset: 0x00250E44
		public new static int IsTypeOf(string type)
		{
			return vtkHigherOrderTriangle.vtkHigherOrderTriangle_IsTypeOf_30(type);
		}

		// Token: 0x0601AB5C RID: 109404
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderTriangle_NewInstance_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB5D RID: 109405 RVA: 0x00252C60 File Offset: 0x00250E60
		public new vtkHigherOrderTriangle NewInstance()
		{
			vtkHigherOrderTriangle result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHigherOrderTriangle.vtkHigherOrderTriangle_NewInstance_31(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHigherOrderTriangle)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601AB5E RID: 109406
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHigherOrderTriangle_PointCountSupportsUniformOrder_32(long pointsPerTri);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB5F RID: 109407 RVA: 0x00252CBC File Offset: 0x00250EBC
		public static bool PointCountSupportsUniformOrder(long pointsPerTri)
		{
			return vtkHigherOrderTriangle.vtkHigherOrderTriangle_PointCountSupportsUniformOrder_32(pointsPerTri) != 0;
		}

		// Token: 0x0601AB60 RID: 109408
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderTriangle_RequiresInitialization_33(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB61 RID: 109409 RVA: 0x00252CE0 File Offset: 0x00250EE0
		public override int RequiresInitialization()
		{
			return vtkHigherOrderTriangle.vtkHigherOrderTriangle_RequiresInitialization_33(base.GetCppThis());
		}

		// Token: 0x0601AB62 RID: 109410
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderTriangle_SafeDownCast_34(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB63 RID: 109411 RVA: 0x00252D00 File Offset: 0x00250F00
		public new static vtkHigherOrderTriangle SafeDownCast(vtkObjectBase o)
		{
			vtkHigherOrderTriangle vtkHigherOrderTriangle = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHigherOrderTriangle.vtkHigherOrderTriangle_SafeDownCast_34((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601AB64 RID: 109412
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderTriangle_SetParametricCoords_35(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB65 RID: 109413 RVA: 0x00252D7F File Offset: 0x00250F7F
		public void SetParametricCoords()
		{
			vtkHigherOrderTriangle.vtkHigherOrderTriangle_SetParametricCoords_35(base.GetCppThis());
		}

		// Token: 0x0601AB66 RID: 109414
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderTriangle_ToBarycentricIndex_36(HandleRef pThis, long index, IntPtr bindex);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB67 RID: 109415 RVA: 0x00252D8E File Offset: 0x00250F8E
		public void ToBarycentricIndex(long index, IntPtr bindex)
		{
			vtkHigherOrderTriangle.vtkHigherOrderTriangle_ToBarycentricIndex_36(base.GetCppThis(), index, bindex);
		}

		// Token: 0x0601AB68 RID: 109416
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHigherOrderTriangle_ToIndex_37(HandleRef pThis, IntPtr bindex);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB69 RID: 109417 RVA: 0x00252DA0 File Offset: 0x00250FA0
		public long ToIndex(IntPtr bindex)
		{
			return vtkHigherOrderTriangle.vtkHigherOrderTriangle_ToIndex_37(base.GetCppThis(), bindex);
		}

		// Token: 0x0601AB6A RID: 109418
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderTriangle_TriangulateLocalIds_38(HandleRef pThis, int index, HandleRef ptIds);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB6B RID: 109419 RVA: 0x00252DC0 File Offset: 0x00250FC0
		public override int TriangulateLocalIds(int index, vtkIdList ptIds)
		{
			return vtkHigherOrderTriangle.vtkHigherOrderTriangle_TriangulateLocalIds_38(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CEA RID: 7402
		public new const string MRFullTypeName = "Kitware.VTK.vtkHigherOrderTriangle";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CEB RID: 7403
		public new static readonly string MRClassNameKey = "class vtkHigherOrderTriangle";
	}
}
