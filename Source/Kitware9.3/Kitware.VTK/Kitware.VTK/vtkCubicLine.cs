using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCubicLine
	/// </summary>
	/// <remarks>
	///    cell represents a cubic , isoparametric 1D line
	///
	/// vtkCubicLine is a concrete implementation of vtkNonLinearCell to represent a 1D Cubic line.
	/// The Cubic Line is the 4 nodes isoparametric parabolic line . The
	/// interpolation is the standard finite element, cubic isoparametric
	/// shape function. The cell includes two mid-edge nodes. The ordering of the
	/// four points defining the cell is point ids (0,1,2,3) where id #2 and #3 are the
	/// mid-edge nodes. Please note that the parametric coordinates lie between -1 and 1
	/// in accordance with most standard documentations.
	/// @par Thanks:
	/// \verbatim
	/// This file has been developed by Oxalya - www.oxalya.com
	/// \endverbatim
	/// </remarks>
	// Token: 0x02000A34 RID: 2612
	public class vtkCubicLine : vtkNonLinearCell
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601B366 RID: 111462 RVA: 0x002603E3 File Offset: 0x0025E5E3
		static vtkCubicLine()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCubicLine.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCubicLine"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601B367 RID: 111463 RVA: 0x0026040B File Offset: 0x0025E60B
		public vtkCubicLine(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601B368 RID: 111464
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubicLine_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B369 RID: 111465 RVA: 0x0026041C File Offset: 0x0025E61C
		public new static vtkCubicLine New()
		{
			vtkCubicLine result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCubicLine.vtkCubicLine_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCubicLine)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B36A RID: 111466 RVA: 0x00260470 File Offset: 0x0025E670
		public vtkCubicLine() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCubicLine.vtkCubicLine_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601B36B RID: 111467 RVA: 0x002604B4 File Offset: 0x0025E6B4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601B36C RID: 111468
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubicLine_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B36D RID: 111469 RVA: 0x002604C0 File Offset: 0x0025E6C0
		public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
		{
			return vtkCubicLine.vtkCubicLine_CellBoundary_01(base.GetCppThis(), subId, pcoords, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601B36E RID: 111470
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubicLine_Clip_02(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef lines, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

		/// <summary>
		/// Clip this line using scalar value provided. Like contouring, except
		/// that it cuts the line to produce other lines.
		/// </summary>
		// Token: 0x0601B36F RID: 111471 RVA: 0x002604F8 File Offset: 0x0025E6F8
		public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray lines, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
		{
			vtkCubicLine.vtkCubicLine_Clip_02(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis(), insideOut);
		}

		// Token: 0x0601B370 RID: 111472
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubicLine_Contour_03(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B371 RID: 111473 RVA: 0x002605B4 File Offset: 0x0025E7B4
		public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
		{
			vtkCubicLine.vtkCubicLine_Contour_03(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis());
		}

		// Token: 0x0601B372 RID: 111474
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubicLine_Derivatives_04(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B373 RID: 111475 RVA: 0x0026069C File Offset: 0x0025E89C
		public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
		{
			vtkCubicLine.vtkCubicLine_Derivatives_04(base.GetCppThis(), subId, pcoords, values, dim, derivs);
		}

		// Token: 0x0601B374 RID: 111476
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubicLine_EvaluateLocation_05(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B375 RID: 111477 RVA: 0x002606B2 File Offset: 0x0025E8B2
		public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
		{
			vtkCubicLine.vtkCubicLine_EvaluateLocation_05(base.GetCppThis(), ref subId, pcoords, x, weights);
		}

		// Token: 0x0601B376 RID: 111478
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubicLine_EvaluatePosition_06(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B377 RID: 111479 RVA: 0x002606C8 File Offset: 0x0025E8C8
		public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
		{
			return vtkCubicLine.vtkCubicLine_EvaluatePosition_06(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
		}

		// Token: 0x0601B378 RID: 111480
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubicLine_GetCellDimension_07(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B379 RID: 111481 RVA: 0x002606F0 File Offset: 0x0025E8F0
		public override int GetCellDimension()
		{
			return vtkCubicLine.vtkCubicLine_GetCellDimension_07(base.GetCppThis());
		}

		// Token: 0x0601B37A RID: 111482
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubicLine_GetCellType_08(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B37B RID: 111483 RVA: 0x00260710 File Offset: 0x0025E910
		public override int GetCellType()
		{
			return vtkCubicLine.vtkCubicLine_GetCellType_08(base.GetCppThis());
		}

		// Token: 0x0601B37C RID: 111484
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubicLine_GetEdge_09(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B37D RID: 111485 RVA: 0x00260730 File Offset: 0x0025E930
		public override vtkCell GetEdge(int arg0)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCubicLine.vtkCubicLine_GetEdge_09(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601B37E RID: 111486
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubicLine_GetFace_10(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B37F RID: 111487 RVA: 0x002607A0 File Offset: 0x0025E9A0
		public override vtkCell GetFace(int arg0)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCubicLine.vtkCubicLine_GetFace_10(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601B380 RID: 111488
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubicLine_GetNumberOfEdges_11(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B381 RID: 111489 RVA: 0x00260810 File Offset: 0x0025EA10
		public override int GetNumberOfEdges()
		{
			return vtkCubicLine.vtkCubicLine_GetNumberOfEdges_11(base.GetCppThis());
		}

		// Token: 0x0601B382 RID: 111490
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubicLine_GetNumberOfFaces_12(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B383 RID: 111491 RVA: 0x00260830 File Offset: 0x0025EA30
		public override int GetNumberOfFaces()
		{
			return vtkCubicLine.vtkCubicLine_GetNumberOfFaces_12(base.GetCppThis());
		}

		// Token: 0x0601B384 RID: 111492
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCubicLine_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B385 RID: 111493 RVA: 0x00260850 File Offset: 0x0025EA50
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCubicLine.vtkCubicLine_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x0601B386 RID: 111494
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCubicLine_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B387 RID: 111495 RVA: 0x00260870 File Offset: 0x0025EA70
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCubicLine.vtkCubicLine_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x0601B388 RID: 111496
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubicLine_GetParametricCenter_15(HandleRef pThis, IntPtr pcoords);

		/// <summary>
		/// Return the center of the triangle in parametric coordinates.
		/// </summary>
		// Token: 0x0601B389 RID: 111497 RVA: 0x0026088C File Offset: 0x0025EA8C
		public override int GetParametricCenter(IntPtr pcoords)
		{
			return vtkCubicLine.vtkCubicLine_GetParametricCenter_15(base.GetCppThis(), pcoords);
		}

		// Token: 0x0601B38A RID: 111498
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubicLine_GetParametricCoords_16(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B38B RID: 111499 RVA: 0x002608AC File Offset: 0x0025EAAC
		public override IntPtr GetParametricCoords()
		{
			return vtkCubicLine.vtkCubicLine_GetParametricCoords_16(base.GetCppThis());
		}

		// Token: 0x0601B38C RID: 111500
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCubicLine_GetParametricDistance_17(HandleRef pThis, IntPtr pcoords);

		/// <summary>
		/// Return the distance of the parametric coordinate provided to the
		/// cell. If inside the cell, a distance of zero is returned.
		/// </summary>
		// Token: 0x0601B38D RID: 111501 RVA: 0x002608CC File Offset: 0x0025EACC
		public override double GetParametricDistance(IntPtr pcoords)
		{
			return vtkCubicLine.vtkCubicLine_GetParametricDistance_17(base.GetCppThis(), pcoords);
		}

		// Token: 0x0601B38E RID: 111502
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubicLine_InterpolateDerivs_18(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601B38F RID: 111503 RVA: 0x002608EC File Offset: 0x0025EAEC
		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkCubicLine.vtkCubicLine_InterpolateDerivs_18(base.GetCppThis(), pcoords, derivs);
		}

		// Token: 0x0601B390 RID: 111504
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubicLine_InterpolateFunctions_19(HandleRef pThis, IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601B391 RID: 111505 RVA: 0x002608FD File Offset: 0x0025EAFD
		public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkCubicLine.vtkCubicLine_InterpolateFunctions_19(base.GetCppThis(), pcoords, weights);
		}

		// Token: 0x0601B392 RID: 111506
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubicLine_InterpolationDerivs_20(IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Line-line intersection. Intersection has to occur within [0,1] parametric
		/// coordinates and with specified tolerance.
		/// </summary>
		// Token: 0x0601B393 RID: 111507 RVA: 0x0026090E File Offset: 0x0025EB0E
		public static void InterpolationDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkCubicLine.vtkCubicLine_InterpolationDerivs_20(pcoords, derivs);
		}

		// Token: 0x0601B394 RID: 111508
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubicLine_InterpolationFunctions_21(IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Line-line intersection. Intersection has to occur within [0,1] parametric
		/// coordinates and with specified tolerance.
		/// </summary>
		// Token: 0x0601B395 RID: 111509 RVA: 0x00260919 File Offset: 0x0025EB19
		public static void InterpolationFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkCubicLine.vtkCubicLine_InterpolationFunctions_21(pcoords, weights);
		}

		// Token: 0x0601B396 RID: 111510
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubicLine_IntersectWithLine_22(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		/// <summary>
		/// Line-line intersection. Intersection has to occur within [0,1] parametric
		/// coordinates and with specified tolerance.
		/// </summary>
		// Token: 0x0601B397 RID: 111511 RVA: 0x00260924 File Offset: 0x0025EB24
		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkCubicLine.vtkCubicLine_IntersectWithLine_22(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		// Token: 0x0601B398 RID: 111512
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubicLine_IsA_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B399 RID: 111513 RVA: 0x00260950 File Offset: 0x0025EB50
		public override int IsA(string type)
		{
			return vtkCubicLine.vtkCubicLine_IsA_23(base.GetCppThis(), type);
		}

		// Token: 0x0601B39A RID: 111514
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubicLine_IsTypeOf_24([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B39B RID: 111515 RVA: 0x00260970 File Offset: 0x0025EB70
		public new static int IsTypeOf(string type)
		{
			return vtkCubicLine.vtkCubicLine_IsTypeOf_24(type);
		}

		// Token: 0x0601B39C RID: 111516
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubicLine_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B39D RID: 111517 RVA: 0x0026098C File Offset: 0x0025EB8C
		public new vtkCubicLine NewInstance()
		{
			vtkCubicLine result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCubicLine.vtkCubicLine_NewInstance_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCubicLine)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601B39E RID: 111518
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubicLine_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B39F RID: 111519 RVA: 0x002609E8 File Offset: 0x0025EBE8
		public new static vtkCubicLine SafeDownCast(vtkObjectBase o)
		{
			vtkCubicLine vtkCubicLine = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCubicLine.vtkCubicLine_SafeDownCast_27((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCubicLine = (vtkCubicLine)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCubicLine.Register(null);
				}
			}
			return vtkCubicLine;
		}

		// Token: 0x0601B3A0 RID: 111520
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubicLine_TriangulateLocalIds_28(HandleRef pThis, int index, HandleRef ptIds);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601B3A1 RID: 111521 RVA: 0x00260A68 File Offset: 0x0025EC68
		public override int TriangulateLocalIds(int index, vtkIdList ptIds)
		{
			return vtkCubicLine.vtkCubicLine_TriangulateLocalIds_28(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D5B RID: 7515
		public new const string MRFullTypeName = "Kitware.VTK.vtkCubicLine";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D5C RID: 7516
		public new static readonly string MRClassNameKey = "class vtkCubicLine";
	}
}
