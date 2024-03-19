using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLagrangeWedge
	/// </summary>
	/// <remarks>
	///    A 3D cell that represents an arbitrary order Lagrange wedge
	///
	/// vtkLagrangeWedge is a concrete implementation of vtkCell to represent a
	/// 3D wedge using Lagrange shape functions of user specified order.
	/// A wedge consists of two triangular and three quadrilateral faces.
	/// The first six points of the wedge (0-5) are the "corner" points
	/// where the first three points are the base of the wedge. This wedge
	/// point ordering is opposite the vtkWedge ordering though in that
	/// the base of the wedge defined by the first three points (0,1,2) form
	/// a triangle whose normal points inward (toward the triangular face (3,4,5)).
	/// While this is opposite the vtkWedge convention it is consistent with
	/// every other cell type in VTK. The first 2 parametric coordinates of the
	/// Lagrange wedge or for the triangular base and vary between 0 and 1. The
	/// third parametric coordinate is between the two triangular faces and goes
	/// from 0 to 1 as well.
	/// </remarks>
	// Token: 0x02000A7D RID: 2685
	public class vtkLagrangeWedge : vtkHigherOrderWedge
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601C206 RID: 115206 RVA: 0x002770A3 File Offset: 0x002752A3
		static vtkLagrangeWedge()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLagrangeWedge.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLagrangeWedge"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601C207 RID: 115207 RVA: 0x002770CB File Offset: 0x002752CB
		public vtkLagrangeWedge(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601C208 RID: 115208
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangeWedge_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C209 RID: 115209 RVA: 0x002770DC File Offset: 0x002752DC
		public new static vtkLagrangeWedge New()
		{
			vtkLagrangeWedge result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangeWedge.vtkLagrangeWedge_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLagrangeWedge)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C20A RID: 115210 RVA: 0x00277130 File Offset: 0x00275330
		public vtkLagrangeWedge() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLagrangeWedge.vtkLagrangeWedge_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601C20B RID: 115211 RVA: 0x00277174 File Offset: 0x00275374
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601C20C RID: 115212
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangeWedge_GetBoundaryQuad_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C20D RID: 115213 RVA: 0x00277180 File Offset: 0x00275380
		public override vtkHigherOrderQuadrilateral GetBoundaryQuad()
		{
			vtkHigherOrderQuadrilateral vtkHigherOrderQuadrilateral = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangeWedge.vtkLagrangeWedge_GetBoundaryQuad_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHigherOrderQuadrilateral = (vtkHigherOrderQuadrilateral)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHigherOrderQuadrilateral.Register(null);
				}
			}
			return vtkHigherOrderQuadrilateral;
		}

		// Token: 0x0601C20E RID: 115214
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangeWedge_GetBoundaryTri_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C20F RID: 115215 RVA: 0x002771F0 File Offset: 0x002753F0
		public override vtkHigherOrderTriangle GetBoundaryTri()
		{
			vtkHigherOrderTriangle vtkHigherOrderTriangle = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangeWedge.vtkLagrangeWedge_GetBoundaryTri_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601C210 RID: 115216
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLagrangeWedge_GetCellType_03(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C211 RID: 115217 RVA: 0x00277260 File Offset: 0x00275460
		public override int GetCellType()
		{
			return vtkLagrangeWedge.vtkLagrangeWedge_GetCellType_03(base.GetCppThis());
		}

		// Token: 0x0601C212 RID: 115218
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangeWedge_GetEdge_04(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C213 RID: 115219 RVA: 0x00277280 File Offset: 0x00275480
		public override vtkCell GetEdge(int edgeId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangeWedge.vtkLagrangeWedge_GetEdge_04(base.GetCppThis(), edgeId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601C214 RID: 115220
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangeWedge_GetEdgeCell_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C215 RID: 115221 RVA: 0x002772F0 File Offset: 0x002754F0
		public override vtkHigherOrderCurve GetEdgeCell()
		{
			vtkHigherOrderCurve vtkHigherOrderCurve = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangeWedge.vtkLagrangeWedge_GetEdgeCell_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601C216 RID: 115222
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangeWedge_GetFace_06(HandleRef pThis, int faceId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C217 RID: 115223 RVA: 0x00277360 File Offset: 0x00275560
		public override vtkCell GetFace(int faceId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangeWedge.vtkLagrangeWedge_GetFace_06(base.GetCppThis(), faceId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601C218 RID: 115224
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangeWedge_GetInterpolation_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C219 RID: 115225 RVA: 0x002773D0 File Offset: 0x002755D0
		public override vtkHigherOrderInterpolation GetInterpolation()
		{
			vtkHigherOrderInterpolation vtkHigherOrderInterpolation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangeWedge.vtkLagrangeWedge_GetInterpolation_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHigherOrderInterpolation = (vtkHigherOrderInterpolation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHigherOrderInterpolation.Register(null);
				}
			}
			return vtkHigherOrderInterpolation;
		}

		// Token: 0x0601C21A RID: 115226
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLagrangeWedge_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C21B RID: 115227 RVA: 0x00277440 File Offset: 0x00275640
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLagrangeWedge.vtkLagrangeWedge_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x0601C21C RID: 115228
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLagrangeWedge_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C21D RID: 115229 RVA: 0x00277460 File Offset: 0x00275660
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLagrangeWedge.vtkLagrangeWedge_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x0601C21E RID: 115230
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangeWedge_InterpolateDerivs_10(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C21F RID: 115231 RVA: 0x0027747A File Offset: 0x0027567A
		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkLagrangeWedge.vtkLagrangeWedge_InterpolateDerivs_10(base.GetCppThis(), pcoords, derivs);
		}

		// Token: 0x0601C220 RID: 115232
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangeWedge_InterpolateFunctions_11(HandleRef pThis, IntPtr pcoords, IntPtr weights);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C221 RID: 115233 RVA: 0x0027748B File Offset: 0x0027568B
		public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkLagrangeWedge.vtkLagrangeWedge_InterpolateFunctions_11(base.GetCppThis(), pcoords, weights);
		}

		// Token: 0x0601C222 RID: 115234
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLagrangeWedge_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C223 RID: 115235 RVA: 0x0027749C File Offset: 0x0027569C
		public override int IsA(string type)
		{
			return vtkLagrangeWedge.vtkLagrangeWedge_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x0601C224 RID: 115236
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLagrangeWedge_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C225 RID: 115237 RVA: 0x002774BC File Offset: 0x002756BC
		public new static int IsTypeOf(string type)
		{
			return vtkLagrangeWedge.vtkLagrangeWedge_IsTypeOf_13(type);
		}

		// Token: 0x0601C226 RID: 115238
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangeWedge_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C227 RID: 115239 RVA: 0x002774D8 File Offset: 0x002756D8
		public new vtkLagrangeWedge NewInstance()
		{
			vtkLagrangeWedge result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangeWedge.vtkLagrangeWedge_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLagrangeWedge)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601C228 RID: 115240
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangeWedge_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C229 RID: 115241 RVA: 0x00277534 File Offset: 0x00275734
		public new static vtkLagrangeWedge SafeDownCast(vtkObjectBase o)
		{
			vtkLagrangeWedge vtkLagrangeWedge = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangeWedge.vtkLagrangeWedge_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLagrangeWedge = (vtkLagrangeWedge)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLagrangeWedge.Register(null);
				}
			}
			return vtkLagrangeWedge;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DF1 RID: 7665
		public new const string MRFullTypeName = "Kitware.VTK.vtkLagrangeWedge";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DF2 RID: 7666
		public new static readonly string MRClassNameKey = "class vtkLagrangeWedge";
	}
}
