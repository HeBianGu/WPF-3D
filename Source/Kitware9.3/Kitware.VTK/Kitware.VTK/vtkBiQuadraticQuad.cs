using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBiQuadraticQuad
	/// </summary>
	/// <remarks>
	///    cell represents a parabolic, 9-node
	/// isoparametric quad
	///
	/// vtkQuadraticQuad is a concrete implementation of vtkNonLinearCell to
	/// represent a two-dimensional, 9-node isoparametric parabolic quadrilateral
	/// element with a Centerpoint. The interpolation is the standard finite
	/// element, quadratic isoparametric shape function. The cell includes a
	/// mid-edge node for each of the four edges of the cell and a center node at
	/// the surface. The ordering of the eight points defining the cell are point
	/// ids (0-3,4-8) where ids 0-3 define the four corner vertices of the quad;
	/// ids 4-7 define the midedge nodes (0,1), (1,2), (2,3), (3,0) and 8 define
	/// the face center node.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkQuadraticEdge vtkQuadraticTriangle vtkQuadraticTetra
	/// vtkQuadraticHexahedron vtkQuadraticWedge vtkQuadraticPyramid
	/// vtkQuadraticQuad
	///
	/// @par Thanks:
	/// Thanks to Soeren Gebbert who developed this class and
	/// integrated it into VTK 5.0.
	/// </seealso>
	// Token: 0x02000A0D RID: 2573
	public class vtkBiQuadraticQuad : vtkNonLinearCell
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601AC15 RID: 109589 RVA: 0x002541B4 File Offset: 0x002523B4
		static vtkBiQuadraticQuad()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBiQuadraticQuad.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBiQuadraticQuad"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601AC16 RID: 109590 RVA: 0x002541DC File Offset: 0x002523DC
		public vtkBiQuadraticQuad(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601AC17 RID: 109591
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiQuadraticQuad_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AC18 RID: 109592 RVA: 0x002541EC File Offset: 0x002523EC
		public new static vtkBiQuadraticQuad New()
		{
			vtkBiQuadraticQuad result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBiQuadraticQuad.vtkBiQuadraticQuad_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBiQuadraticQuad)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AC19 RID: 109593 RVA: 0x00254240 File Offset: 0x00252440
		public vtkBiQuadraticQuad() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBiQuadraticQuad.vtkBiQuadraticQuad_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601AC1A RID: 109594 RVA: 0x00254284 File Offset: 0x00252484
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601AC1B RID: 109595
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiQuadraticQuad_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601AC1C RID: 109596 RVA: 0x00254290 File Offset: 0x00252490
		public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
		{
			return vtkBiQuadraticQuad.vtkBiQuadraticQuad_CellBoundary_01(base.GetCppThis(), subId, pcoords, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601AC1D RID: 109597
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiQuadraticQuad_Clip_02(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

		/// <summary>
		/// Clip this biquadratic quad using scalar value provided. Like contouring,
		/// except that it cuts the twi quads to produce linear triangles.
		/// </summary>
		// Token: 0x0601AC1E RID: 109598 RVA: 0x002542C8 File Offset: 0x002524C8
		public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
		{
			vtkBiQuadraticQuad.vtkBiQuadraticQuad_Clip_02(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis(), insideOut);
		}

		// Token: 0x0601AC1F RID: 109599
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiQuadraticQuad_Contour_03(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601AC20 RID: 109600 RVA: 0x00254384 File Offset: 0x00252584
		public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
		{
			vtkBiQuadraticQuad.vtkBiQuadraticQuad_Contour_03(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis());
		}

		// Token: 0x0601AC21 RID: 109601
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiQuadraticQuad_Derivatives_04(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601AC22 RID: 109602 RVA: 0x0025446C File Offset: 0x0025266C
		public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
		{
			vtkBiQuadraticQuad.vtkBiQuadraticQuad_Derivatives_04(base.GetCppThis(), subId, pcoords, values, dim, derivs);
		}

		// Token: 0x0601AC23 RID: 109603
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiQuadraticQuad_EvaluateLocation_05(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601AC24 RID: 109604 RVA: 0x00254482 File Offset: 0x00252682
		public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
		{
			vtkBiQuadraticQuad.vtkBiQuadraticQuad_EvaluateLocation_05(base.GetCppThis(), ref subId, pcoords, x, weights);
		}

		// Token: 0x0601AC25 RID: 109605
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiQuadraticQuad_EvaluatePosition_06(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601AC26 RID: 109606 RVA: 0x00254498 File Offset: 0x00252698
		public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
		{
			return vtkBiQuadraticQuad.vtkBiQuadraticQuad_EvaluatePosition_06(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
		}

		// Token: 0x0601AC27 RID: 109607
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiQuadraticQuad_GetCellDimension_07(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601AC28 RID: 109608 RVA: 0x002544C0 File Offset: 0x002526C0
		public override int GetCellDimension()
		{
			return vtkBiQuadraticQuad.vtkBiQuadraticQuad_GetCellDimension_07(base.GetCppThis());
		}

		// Token: 0x0601AC29 RID: 109609
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiQuadraticQuad_GetCellType_08(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601AC2A RID: 109610 RVA: 0x002544E0 File Offset: 0x002526E0
		public override int GetCellType()
		{
			return vtkBiQuadraticQuad.vtkBiQuadraticQuad_GetCellType_08(base.GetCppThis());
		}

		// Token: 0x0601AC2B RID: 109611
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiQuadraticQuad_GetEdge_09(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601AC2C RID: 109612 RVA: 0x00254500 File Offset: 0x00252700
		public override vtkCell GetEdge(int arg0)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBiQuadraticQuad.vtkBiQuadraticQuad_GetEdge_09(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601AC2D RID: 109613
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiQuadraticQuad_GetFace_10(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601AC2E RID: 109614 RVA: 0x00254570 File Offset: 0x00252770
		public override vtkCell GetFace(int arg0)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBiQuadraticQuad.vtkBiQuadraticQuad_GetFace_10(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601AC2F RID: 109615
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiQuadraticQuad_GetNumberOfEdges_11(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601AC30 RID: 109616 RVA: 0x002545E0 File Offset: 0x002527E0
		public override int GetNumberOfEdges()
		{
			return vtkBiQuadraticQuad.vtkBiQuadraticQuad_GetNumberOfEdges_11(base.GetCppThis());
		}

		// Token: 0x0601AC31 RID: 109617
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiQuadraticQuad_GetNumberOfFaces_12(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601AC32 RID: 109618 RVA: 0x00254600 File Offset: 0x00252800
		public override int GetNumberOfFaces()
		{
			return vtkBiQuadraticQuad.vtkBiQuadraticQuad_GetNumberOfFaces_12(base.GetCppThis());
		}

		// Token: 0x0601AC33 RID: 109619
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBiQuadraticQuad_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AC34 RID: 109620 RVA: 0x00254620 File Offset: 0x00252820
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBiQuadraticQuad.vtkBiQuadraticQuad_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x0601AC35 RID: 109621
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBiQuadraticQuad_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AC36 RID: 109622 RVA: 0x00254640 File Offset: 0x00252840
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBiQuadraticQuad.vtkBiQuadraticQuad_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x0601AC37 RID: 109623
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiQuadraticQuad_GetParametricCenter_15(HandleRef pThis, IntPtr pcoords);

		/// <summary>
		/// Return the center of the pyramid in parametric coordinates.
		/// </summary>
		// Token: 0x0601AC38 RID: 109624 RVA: 0x0025465C File Offset: 0x0025285C
		public override int GetParametricCenter(IntPtr pcoords)
		{
			return vtkBiQuadraticQuad.vtkBiQuadraticQuad_GetParametricCenter_15(base.GetCppThis(), pcoords);
		}

		// Token: 0x0601AC39 RID: 109625
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiQuadraticQuad_GetParametricCoords_16(HandleRef pThis);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601AC3A RID: 109626 RVA: 0x0025467C File Offset: 0x0025287C
		public override IntPtr GetParametricCoords()
		{
			return vtkBiQuadraticQuad.vtkBiQuadraticQuad_GetParametricCoords_16(base.GetCppThis());
		}

		// Token: 0x0601AC3B RID: 109627
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiQuadraticQuad_InterpolateDerivs_17(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Return the center of the pyramid in parametric coordinates.
		/// </summary>
		// Token: 0x0601AC3C RID: 109628 RVA: 0x0025469B File Offset: 0x0025289B
		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkBiQuadraticQuad.vtkBiQuadraticQuad_InterpolateDerivs_17(base.GetCppThis(), pcoords, derivs);
		}

		// Token: 0x0601AC3D RID: 109629
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiQuadraticQuad_InterpolateFunctions_18(HandleRef pThis, IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Return the center of the pyramid in parametric coordinates.
		/// </summary>
		// Token: 0x0601AC3E RID: 109630 RVA: 0x002546AC File Offset: 0x002528AC
		public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkBiQuadraticQuad.vtkBiQuadraticQuad_InterpolateFunctions_18(base.GetCppThis(), pcoords, weights);
		}

		// Token: 0x0601AC3F RID: 109631
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiQuadraticQuad_IntersectWithLine_19(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		/// <summary>
		/// Line-edge intersection. Intersection has to occur within [0,1] parametric
		/// coordinates and with specified tolerance.
		/// </summary>
		// Token: 0x0601AC40 RID: 109632 RVA: 0x002546C0 File Offset: 0x002528C0
		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkBiQuadraticQuad.vtkBiQuadraticQuad_IntersectWithLine_19(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		// Token: 0x0601AC41 RID: 109633
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiQuadraticQuad_IsA_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AC42 RID: 109634 RVA: 0x002546EC File Offset: 0x002528EC
		public override int IsA(string type)
		{
			return vtkBiQuadraticQuad.vtkBiQuadraticQuad_IsA_20(base.GetCppThis(), type);
		}

		// Token: 0x0601AC43 RID: 109635
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiQuadraticQuad_IsTypeOf_21([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AC44 RID: 109636 RVA: 0x0025470C File Offset: 0x0025290C
		public new static int IsTypeOf(string type)
		{
			return vtkBiQuadraticQuad.vtkBiQuadraticQuad_IsTypeOf_21(type);
		}

		// Token: 0x0601AC45 RID: 109637
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiQuadraticQuad_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AC46 RID: 109638 RVA: 0x00254728 File Offset: 0x00252928
		public new vtkBiQuadraticQuad NewInstance()
		{
			vtkBiQuadraticQuad result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBiQuadraticQuad.vtkBiQuadraticQuad_NewInstance_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBiQuadraticQuad)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601AC47 RID: 109639
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiQuadraticQuad_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AC48 RID: 109640 RVA: 0x00254784 File Offset: 0x00252984
		public new static vtkBiQuadraticQuad SafeDownCast(vtkObjectBase o)
		{
			vtkBiQuadraticQuad vtkBiQuadraticQuad = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBiQuadraticQuad.vtkBiQuadraticQuad_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBiQuadraticQuad = (vtkBiQuadraticQuad)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBiQuadraticQuad.Register(null);
				}
			}
			return vtkBiQuadraticQuad;
		}

		// Token: 0x0601AC49 RID: 109641
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiQuadraticQuad_TriangulateLocalIds_25(HandleRef pThis, int index, HandleRef ptIds);

		/// <summary>
		/// Implement the vtkCell API. See the vtkCell API for descriptions
		/// of these methods.
		/// </summary>
		// Token: 0x0601AC4A RID: 109642 RVA: 0x00254804 File Offset: 0x00252A04
		public override int TriangulateLocalIds(int index, vtkIdList ptIds)
		{
			return vtkBiQuadraticQuad.vtkBiQuadraticQuad_TriangulateLocalIds_25(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CF2 RID: 7410
		public new const string MRFullTypeName = "Kitware.VTK.vtkBiQuadraticQuad";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CF3 RID: 7411
		public new static readonly string MRClassNameKey = "class vtkBiQuadraticQuad";
	}
}
