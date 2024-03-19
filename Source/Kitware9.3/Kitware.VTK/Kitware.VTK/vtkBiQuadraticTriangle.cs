using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBiQuadraticTriangle
	/// </summary>
	/// <remarks>
	///    cell represents a parabolic, isoparametric triangle
	///
	/// vtkBiQuadraticTriangle is a concrete implementation of vtkNonLinearCell to
	/// represent a two-dimensional, 7-node, isoparametric parabolic triangle. The
	/// interpolation is the standard finite element, bi-quadratic isoparametric
	/// shape function. The cell includes three mid-edge nodes besides the three
	/// triangle vertices and a center node. The ordering of the three points defining the cell is
	/// point ids (0-2,3-6) where id #3 is the midedge node between points
	/// (0,1); id #4 is the midedge node between points (1,2); and id #5 is the
	/// midedge node between points (2,0). id #6 is the center node of the cell.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkTriangle vtkQuadraticTriangle
	/// vtkBiQuadraticQuad vtkBiQuadraticQuadraticWedge vtkBiQuadraticQuadraticHexahedron
	/// @par Thanks:
	/// @verbatim
	/// This file has been developed by Oxalya - www.oxalya.com
	/// @endverbatim
	/// </seealso>
	// Token: 0x02000A10 RID: 2576
	public class vtkBiQuadraticTriangle : vtkNonLinearCell
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601ACC5 RID: 109765 RVA: 0x002555B9 File Offset: 0x002537B9
		static vtkBiQuadraticTriangle()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBiQuadraticTriangle.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBiQuadraticTriangle"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601ACC6 RID: 109766 RVA: 0x002555E1 File Offset: 0x002537E1
		public vtkBiQuadraticTriangle(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601ACC7 RID: 109767
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiQuadraticTriangle_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ACC8 RID: 109768 RVA: 0x002555F0 File Offset: 0x002537F0
		public new static vtkBiQuadraticTriangle New()
		{
			vtkBiQuadraticTriangle result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBiQuadraticTriangle)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ACC9 RID: 109769 RVA: 0x00255644 File Offset: 0x00253844
		public vtkBiQuadraticTriangle() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601ACCA RID: 109770 RVA: 0x00255688 File Offset: 0x00253888
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601ACCB RID: 109771
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiQuadraticTriangle_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601ACCC RID: 109772 RVA: 0x00255694 File Offset: 0x00253894
		public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
		{
			return vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_CellBoundary_01(base.GetCppThis(), subId, pcoords, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601ACCD RID: 109773
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiQuadraticTriangle_Clip_02(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

		/// <summary>
		/// Clip this quadratic triangle using scalar value provided. Like
		/// contouring, except that it cuts the triangle to produce linear
		/// triangles.
		/// </summary>
		// Token: 0x0601ACCE RID: 109774 RVA: 0x002556CC File Offset: 0x002538CC
		public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
		{
			vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_Clip_02(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis(), insideOut);
		}

		// Token: 0x0601ACCF RID: 109775
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiQuadraticTriangle_Contour_03(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601ACD0 RID: 109776 RVA: 0x00255788 File Offset: 0x00253988
		public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
		{
			vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_Contour_03(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis());
		}

		// Token: 0x0601ACD1 RID: 109777
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiQuadraticTriangle_Derivatives_04(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601ACD2 RID: 109778 RVA: 0x00255870 File Offset: 0x00253A70
		public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
		{
			vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_Derivatives_04(base.GetCppThis(), subId, pcoords, values, dim, derivs);
		}

		// Token: 0x0601ACD3 RID: 109779
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiQuadraticTriangle_EvaluateLocation_05(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601ACD4 RID: 109780 RVA: 0x00255886 File Offset: 0x00253A86
		public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
		{
			vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_EvaluateLocation_05(base.GetCppThis(), ref subId, pcoords, x, weights);
		}

		// Token: 0x0601ACD5 RID: 109781
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiQuadraticTriangle_EvaluatePosition_06(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601ACD6 RID: 109782 RVA: 0x0025589C File Offset: 0x00253A9C
		public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
		{
			return vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_EvaluatePosition_06(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
		}

		// Token: 0x0601ACD7 RID: 109783
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiQuadraticTriangle_GetCellDimension_07(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601ACD8 RID: 109784 RVA: 0x002558C4 File Offset: 0x00253AC4
		public override int GetCellDimension()
		{
			return vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_GetCellDimension_07(base.GetCppThis());
		}

		// Token: 0x0601ACD9 RID: 109785
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiQuadraticTriangle_GetCellType_08(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601ACDA RID: 109786 RVA: 0x002558E4 File Offset: 0x00253AE4
		public override int GetCellType()
		{
			return vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_GetCellType_08(base.GetCppThis());
		}

		// Token: 0x0601ACDB RID: 109787
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiQuadraticTriangle_GetEdge_09(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601ACDC RID: 109788 RVA: 0x00255904 File Offset: 0x00253B04
		public override vtkCell GetEdge(int edgeId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_GetEdge_09(base.GetCppThis(), edgeId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601ACDD RID: 109789
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiQuadraticTriangle_GetFace_10(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601ACDE RID: 109790 RVA: 0x00255974 File Offset: 0x00253B74
		public override vtkCell GetFace(int arg0)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_GetFace_10(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601ACDF RID: 109791
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiQuadraticTriangle_GetNumberOfEdges_11(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601ACE0 RID: 109792 RVA: 0x002559E4 File Offset: 0x00253BE4
		public override int GetNumberOfEdges()
		{
			return vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_GetNumberOfEdges_11(base.GetCppThis());
		}

		// Token: 0x0601ACE1 RID: 109793
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiQuadraticTriangle_GetNumberOfFaces_12(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601ACE2 RID: 109794 RVA: 0x00255A04 File Offset: 0x00253C04
		public override int GetNumberOfFaces()
		{
			return vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_GetNumberOfFaces_12(base.GetCppThis());
		}

		// Token: 0x0601ACE3 RID: 109795
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBiQuadraticTriangle_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ACE4 RID: 109796 RVA: 0x00255A24 File Offset: 0x00253C24
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x0601ACE5 RID: 109797
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBiQuadraticTriangle_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ACE6 RID: 109798 RVA: 0x00255A44 File Offset: 0x00253C44
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x0601ACE7 RID: 109799
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiQuadraticTriangle_GetParametricCenter_15(HandleRef pThis, IntPtr pcoords);

		/// <summary>
		/// Return the center of the quadratic triangle in parametric coordinates.
		/// </summary>
		// Token: 0x0601ACE8 RID: 109800 RVA: 0x00255A60 File Offset: 0x00253C60
		public override int GetParametricCenter(IntPtr pcoords)
		{
			return vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_GetParametricCenter_15(base.GetCppThis(), pcoords);
		}

		// Token: 0x0601ACE9 RID: 109801
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiQuadraticTriangle_GetParametricCoords_16(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601ACEA RID: 109802 RVA: 0x00255A80 File Offset: 0x00253C80
		public override IntPtr GetParametricCoords()
		{
			return vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_GetParametricCoords_16(base.GetCppThis());
		}

		// Token: 0x0601ACEB RID: 109803
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkBiQuadraticTriangle_GetParametricDistance_17(HandleRef pThis, IntPtr pcoords);

		/// <summary>
		/// Return the distance of the parametric coordinate provided to the
		/// cell. If inside the cell, a distance of zero is returned.
		/// </summary>
		// Token: 0x0601ACEC RID: 109804 RVA: 0x00255AA0 File Offset: 0x00253CA0
		public override double GetParametricDistance(IntPtr pcoords)
		{
			return vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_GetParametricDistance_17(base.GetCppThis(), pcoords);
		}

		// Token: 0x0601ACED RID: 109805
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiQuadraticTriangle_InterpolateDerivs_18(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601ACEE RID: 109806 RVA: 0x00255AC0 File Offset: 0x00253CC0
		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_InterpolateDerivs_18(base.GetCppThis(), pcoords, derivs);
		}

		// Token: 0x0601ACEF RID: 109807
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiQuadraticTriangle_InterpolateFunctions_19(HandleRef pThis, IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601ACF0 RID: 109808 RVA: 0x00255AD1 File Offset: 0x00253CD1
		public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_InterpolateFunctions_19(base.GetCppThis(), pcoords, weights);
		}

		// Token: 0x0601ACF1 RID: 109809
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiQuadraticTriangle_InterpolationDerivs_20(IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Return the distance of the parametric coordinate provided to the
		/// cell. If inside the cell, a distance of zero is returned.
		/// </summary>
		// Token: 0x0601ACF2 RID: 109810 RVA: 0x00255AE2 File Offset: 0x00253CE2
		public static void InterpolationDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_InterpolationDerivs_20(pcoords, derivs);
		}

		// Token: 0x0601ACF3 RID: 109811
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiQuadraticTriangle_InterpolationFunctions_21(IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Return the distance of the parametric coordinate provided to the
		/// cell. If inside the cell, a distance of zero is returned.
		/// </summary>
		// Token: 0x0601ACF4 RID: 109812 RVA: 0x00255AED File Offset: 0x00253CED
		public static void InterpolationFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_InterpolationFunctions_21(pcoords, weights);
		}

		// Token: 0x0601ACF5 RID: 109813
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiQuadraticTriangle_IntersectWithLine_22(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		/// <summary>
		/// Line-edge intersection. Intersection has to occur within [0,1] parametric
		/// coordinates and with specified tolerance.
		/// </summary>
		// Token: 0x0601ACF6 RID: 109814 RVA: 0x00255AF8 File Offset: 0x00253CF8
		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_IntersectWithLine_22(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		// Token: 0x0601ACF7 RID: 109815
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiQuadraticTriangle_IsA_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ACF8 RID: 109816 RVA: 0x00255B24 File Offset: 0x00253D24
		public override int IsA(string type)
		{
			return vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_IsA_23(base.GetCppThis(), type);
		}

		// Token: 0x0601ACF9 RID: 109817
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiQuadraticTriangle_IsTypeOf_24([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ACFA RID: 109818 RVA: 0x00255B44 File Offset: 0x00253D44
		public new static int IsTypeOf(string type)
		{
			return vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_IsTypeOf_24(type);
		}

		// Token: 0x0601ACFB RID: 109819
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiQuadraticTriangle_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ACFC RID: 109820 RVA: 0x00255B60 File Offset: 0x00253D60
		public new vtkBiQuadraticTriangle NewInstance()
		{
			vtkBiQuadraticTriangle result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_NewInstance_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBiQuadraticTriangle)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601ACFD RID: 109821
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiQuadraticTriangle_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ACFE RID: 109822 RVA: 0x00255BBC File Offset: 0x00253DBC
		public new static vtkBiQuadraticTriangle SafeDownCast(vtkObjectBase o)
		{
			vtkBiQuadraticTriangle vtkBiQuadraticTriangle = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_SafeDownCast_27((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBiQuadraticTriangle = (vtkBiQuadraticTriangle)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBiQuadraticTriangle.Register(null);
				}
			}
			return vtkBiQuadraticTriangle;
		}

		// Token: 0x0601ACFF RID: 109823
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiQuadraticTriangle_TriangulateLocalIds_28(HandleRef pThis, int index, HandleRef ptIds);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601AD00 RID: 109824 RVA: 0x00255C3C File Offset: 0x00253E3C
		public override int TriangulateLocalIds(int index, vtkIdList ptIds)
		{
			return vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_TriangulateLocalIds_28(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CF8 RID: 7416
		public new const string MRFullTypeName = "Kitware.VTK.vtkBiQuadraticTriangle";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CF9 RID: 7417
		public new static readonly string MRClassNameKey = "class vtkBiQuadraticTriangle";
	}
}
