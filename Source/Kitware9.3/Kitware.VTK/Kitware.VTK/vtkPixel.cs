using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPixel
	/// </summary>
	/// <remarks>
	///    a cell that represents an orthogonal quadrilateral
	///
	/// vtkPixel is a concrete implementation of vtkCell to represent a 2D
	/// orthogonal quadrilateral. Unlike vtkQuad, the corners are at right angles,
	/// and aligned along x-y-z coordinate axes leading to large increases in
	/// computational efficiency.
	/// </remarks>
	// Token: 0x02000A95 RID: 2709
	public class vtkPixel : vtkCell
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601C676 RID: 116342 RVA: 0x0027E616 File Offset: 0x0027C816
		static vtkPixel()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPixel.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPixel"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601C677 RID: 116343 RVA: 0x0027E63E File Offset: 0x0027C83E
		public vtkPixel(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601C678 RID: 116344
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPixel_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C679 RID: 116345 RVA: 0x0027E64C File Offset: 0x0027C84C
		public new static vtkPixel New()
		{
			vtkPixel result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPixel.vtkPixel_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPixel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C67A RID: 116346 RVA: 0x0027E6A0 File Offset: 0x0027C8A0
		public vtkPixel() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPixel.vtkPixel_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601C67B RID: 116347 RVA: 0x0027E6E4 File Offset: 0x0027C8E4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601C67C RID: 116348
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPixel_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C67D RID: 116349 RVA: 0x0027E6F0 File Offset: 0x0027C8F0
		public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
		{
			return vtkPixel.vtkPixel_CellBoundary_01(base.GetCppThis(), subId, pcoords, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601C67E RID: 116350
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPixel_Clip_02(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C67F RID: 116351 RVA: 0x0027E728 File Offset: 0x0027C928
		public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
		{
			vtkPixel.vtkPixel_Clip_02(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis(), insideOut);
		}

		// Token: 0x0601C680 RID: 116352
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPixel_ComputeBoundingSphere_03(HandleRef pThis, IntPtr center);

		/// <summary>
		/// Computes exact bounding sphere of this pixel.
		/// </summary>
		// Token: 0x0601C681 RID: 116353 RVA: 0x0027E7E4 File Offset: 0x0027C9E4
		public override double ComputeBoundingSphere(IntPtr center)
		{
			return vtkPixel.vtkPixel_ComputeBoundingSphere_03(base.GetCppThis(), center);
		}

		// Token: 0x0601C682 RID: 116354
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPixel_ComputeNormal_04(HandleRef pThis, IntPtr n);

		/// <summary>
		/// vtkPixel's normal cannot be computed using vtkPolygon::ComputeNormal because
		/// its points are not sorted such that circulating on them forms the pixel.
		/// This is a convenient method so one can compute normals on a pixel.
		/// </summary>
		// Token: 0x0601C683 RID: 116355 RVA: 0x0027E804 File Offset: 0x0027CA04
		public int ComputeNormal(IntPtr n)
		{
			return vtkPixel.vtkPixel_ComputeNormal_04(base.GetCppThis(), n);
		}

		// Token: 0x0601C684 RID: 116356
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPixel_Contour_05(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C685 RID: 116357 RVA: 0x0027E824 File Offset: 0x0027CA24
		public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
		{
			vtkPixel.vtkPixel_Contour_05(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis());
		}

		// Token: 0x0601C686 RID: 116358
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPixel_Derivatives_06(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

		/// <summary>
		/// Return the center of the triangle in parametric coordinates.
		/// </summary>
		// Token: 0x0601C687 RID: 116359 RVA: 0x0027E90C File Offset: 0x0027CB0C
		public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
		{
			vtkPixel.vtkPixel_Derivatives_06(base.GetCppThis(), subId, pcoords, values, dim, derivs);
		}

		// Token: 0x0601C688 RID: 116360
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPixel_EvaluateLocation_07(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C689 RID: 116361 RVA: 0x0027E922 File Offset: 0x0027CB22
		public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
		{
			vtkPixel.vtkPixel_EvaluateLocation_07(base.GetCppThis(), ref subId, pcoords, x, weights);
		}

		// Token: 0x0601C68A RID: 116362
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPixel_EvaluatePosition_08(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C68B RID: 116363 RVA: 0x0027E938 File Offset: 0x0027CB38
		public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
		{
			return vtkPixel.vtkPixel_EvaluatePosition_08(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
		}

		// Token: 0x0601C68C RID: 116364
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPixel_GetCellDimension_09(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C68D RID: 116365 RVA: 0x0027E960 File Offset: 0x0027CB60
		public override int GetCellDimension()
		{
			return vtkPixel.vtkPixel_GetCellDimension_09(base.GetCppThis());
		}

		// Token: 0x0601C68E RID: 116366
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPixel_GetCellType_10(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C68F RID: 116367 RVA: 0x0027E980 File Offset: 0x0027CB80
		public override int GetCellType()
		{
			return vtkPixel.vtkPixel_GetCellType_10(base.GetCppThis());
		}

		// Token: 0x0601C690 RID: 116368
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPixel_GetEdge_11(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C691 RID: 116369 RVA: 0x0027E9A0 File Offset: 0x0027CBA0
		public override vtkCell GetEdge(int edgeId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPixel.vtkPixel_GetEdge_11(base.GetCppThis(), edgeId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601C692 RID: 116370
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPixel_GetFace_12(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C693 RID: 116371 RVA: 0x0027EA10 File Offset: 0x0027CC10
		public override vtkCell GetFace(int arg0)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPixel.vtkPixel_GetFace_12(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601C694 RID: 116372
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPixel_GetNumberOfEdges_13(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C695 RID: 116373 RVA: 0x0027EA80 File Offset: 0x0027CC80
		public override int GetNumberOfEdges()
		{
			return vtkPixel.vtkPixel_GetNumberOfEdges_13(base.GetCppThis());
		}

		// Token: 0x0601C696 RID: 116374
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPixel_GetNumberOfFaces_14(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C697 RID: 116375 RVA: 0x0027EAA0 File Offset: 0x0027CCA0
		public override int GetNumberOfFaces()
		{
			return vtkPixel.vtkPixel_GetNumberOfFaces_14(base.GetCppThis());
		}

		// Token: 0x0601C698 RID: 116376
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPixel_GetNumberOfGenerationsFromBase_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C699 RID: 116377 RVA: 0x0027EAC0 File Offset: 0x0027CCC0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPixel.vtkPixel_GetNumberOfGenerationsFromBase_15(base.GetCppThis(), type);
		}

		// Token: 0x0601C69A RID: 116378
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPixel_GetNumberOfGenerationsFromBaseType_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C69B RID: 116379 RVA: 0x0027EAE0 File Offset: 0x0027CCE0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPixel.vtkPixel_GetNumberOfGenerationsFromBaseType_16(type);
		}

		// Token: 0x0601C69C RID: 116380
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPixel_GetParametricCenter_17(HandleRef pThis, IntPtr pcoords);

		/// <summary>
		/// Return the center of the triangle in parametric coordinates.
		/// </summary>
		// Token: 0x0601C69D RID: 116381 RVA: 0x0027EAFC File Offset: 0x0027CCFC
		public override int GetParametricCenter(IntPtr pcoords)
		{
			return vtkPixel.vtkPixel_GetParametricCenter_17(base.GetCppThis(), pcoords);
		}

		// Token: 0x0601C69E RID: 116382
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPixel_GetParametricCoords_18(HandleRef pThis);

		/// <summary>
		/// Return the center of the triangle in parametric coordinates.
		/// </summary>
		// Token: 0x0601C69F RID: 116383 RVA: 0x0027EB1C File Offset: 0x0027CD1C
		public override IntPtr GetParametricCoords()
		{
			return vtkPixel.vtkPixel_GetParametricCoords_18(base.GetCppThis());
		}

		// Token: 0x0601C6A0 RID: 116384
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPixel_Inflate_19(HandleRef pThis, double dist);

		/// <summary>
		/// Inflates this pixel by a distance of dist by moving the edges of the pixel
		/// by that distance. Since a pixel lies in 3D, the degenerate case where the
		/// pixel is homogeneous to a line are discarted because of normal direction
		/// ambiguity. Hence, if you shrink a 2D pixel so it loses thickness in one
		/// dimension. inflating it back to its previous form is impossible.
		///
		/// A degenerate pixel of dimension 1 is inflated the same way a segment would be
		/// inflated. A degenerate pixel of dimension 0 is untouched.
		///
		/// \return 1
		/// </summary>
		// Token: 0x0601C6A1 RID: 116385 RVA: 0x0027EB3C File Offset: 0x0027CD3C
		public override int Inflate(double dist)
		{
			return vtkPixel.vtkPixel_Inflate_19(base.GetCppThis(), dist);
		}

		// Token: 0x0601C6A2 RID: 116386
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPixel_InterpolateDerivs_20(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601C6A3 RID: 116387 RVA: 0x0027EB5C File Offset: 0x0027CD5C
		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkPixel.vtkPixel_InterpolateDerivs_20(base.GetCppThis(), pcoords, derivs);
		}

		// Token: 0x0601C6A4 RID: 116388
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPixel_InterpolateFunctions_21(HandleRef pThis, IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601C6A5 RID: 116389 RVA: 0x0027EB6D File Offset: 0x0027CD6D
		public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkPixel.vtkPixel_InterpolateFunctions_21(base.GetCppThis(), pcoords, weights);
		}

		// Token: 0x0601C6A6 RID: 116390
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPixel_InterpolationDerivs_22(IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Return the center of the triangle in parametric coordinates.
		/// </summary>
		// Token: 0x0601C6A7 RID: 116391 RVA: 0x0027EB7E File Offset: 0x0027CD7E
		public static void InterpolationDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkPixel.vtkPixel_InterpolationDerivs_22(pcoords, derivs);
		}

		// Token: 0x0601C6A8 RID: 116392
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPixel_InterpolationFunctions_23(IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Return the center of the triangle in parametric coordinates.
		/// </summary>
		// Token: 0x0601C6A9 RID: 116393 RVA: 0x0027EB89 File Offset: 0x0027CD89
		public static void InterpolationFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkPixel.vtkPixel_InterpolationFunctions_23(pcoords, weights);
		}

		// Token: 0x0601C6AA RID: 116394
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPixel_IntersectWithLine_24(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		/// <summary>
		/// Return the center of the triangle in parametric coordinates.
		/// </summary>
		// Token: 0x0601C6AB RID: 116395 RVA: 0x0027EB94 File Offset: 0x0027CD94
		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkPixel.vtkPixel_IntersectWithLine_24(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		// Token: 0x0601C6AC RID: 116396
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPixel_IsA_25(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C6AD RID: 116397 RVA: 0x0027EBC0 File Offset: 0x0027CDC0
		public override int IsA(string type)
		{
			return vtkPixel.vtkPixel_IsA_25(base.GetCppThis(), type);
		}

		// Token: 0x0601C6AE RID: 116398
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPixel_IsTypeOf_26([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C6AF RID: 116399 RVA: 0x0027EBE0 File Offset: 0x0027CDE0
		public new static int IsTypeOf(string type)
		{
			return vtkPixel.vtkPixel_IsTypeOf_26(type);
		}

		// Token: 0x0601C6B0 RID: 116400
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPixel_NewInstance_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C6B1 RID: 116401 RVA: 0x0027EBFC File Offset: 0x0027CDFC
		public new vtkPixel NewInstance()
		{
			vtkPixel result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPixel.vtkPixel_NewInstance_28(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPixel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601C6B2 RID: 116402
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPixel_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C6B3 RID: 116403 RVA: 0x0027EC58 File Offset: 0x0027CE58
		public new static vtkPixel SafeDownCast(vtkObjectBase o)
		{
			vtkPixel vtkPixel = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPixel.vtkPixel_SafeDownCast_29((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPixel = (vtkPixel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPixel.Register(null);
				}
			}
			return vtkPixel;
		}

		// Token: 0x0601C6B4 RID: 116404
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPixel_TriangulateLocalIds_30(HandleRef pThis, int index, HandleRef ptIds);

		/// <summary>
		/// Return the center of the triangle in parametric coordinates.
		/// </summary>
		// Token: 0x0601C6B5 RID: 116405 RVA: 0x0027ECD8 File Offset: 0x0027CED8
		public override int TriangulateLocalIds(int index, vtkIdList ptIds)
		{
			return vtkPixel.vtkPixel_TriangulateLocalIds_30(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E2B RID: 7723
		public new const string MRFullTypeName = "Kitware.VTK.vtkPixel";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E2C RID: 7724
		public new static readonly string MRClassNameKey = "class vtkPixel";
	}
}
