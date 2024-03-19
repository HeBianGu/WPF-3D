using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBezierWedge
	/// </summary>
	/// <remarks>
	///    A 3D cell that represents an arbitrary order Bezier wedge
	///
	/// vtkBezierWedge is a concrete implementation of vtkCell to represent a
	/// 3D wedge using Bezier shape functions of user specified order.
	/// A wedge consists of two triangular and three quadrilateral faces.
	/// The first six points of the wedge (0-5) are the "corner" points
	/// where the first three points are the base of the wedge. This wedge
	/// point ordering is opposite the vtkWedge ordering though in that
	/// the base of the wedge defined by the first three points (0,1,2) form
	/// a triangle whose normal points inward (toward the triangular face (3,4,5)).
	/// While this is opposite the vtkWedge convention it is consistent with
	/// every other cell type in VTK. The first 2 parametric coordinates of the
	/// Bezier wedge or for the triangular base and vary between 0 and 1. The
	/// third parametric coordinate is between the two triangular faces and goes
	/// from 0 to 1 as well.
	/// </remarks>
	// Token: 0x02000A0C RID: 2572
	public class vtkBezierWedge : vtkHigherOrderWedge
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601ABED RID: 109549 RVA: 0x00253C01 File Offset: 0x00251E01
		static vtkBezierWedge()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBezierWedge.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBezierWedge"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601ABEE RID: 109550 RVA: 0x00253C29 File Offset: 0x00251E29
		public vtkBezierWedge(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601ABEF RID: 109551
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBezierWedge_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ABF0 RID: 109552 RVA: 0x00253C38 File Offset: 0x00251E38
		public new static vtkBezierWedge New()
		{
			vtkBezierWedge result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBezierWedge.vtkBezierWedge_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBezierWedge)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ABF1 RID: 109553 RVA: 0x00253C8C File Offset: 0x00251E8C
		public vtkBezierWedge() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBezierWedge.vtkBezierWedge_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601ABF2 RID: 109554 RVA: 0x00253CD0 File Offset: 0x00251ED0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601ABF3 RID: 109555
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBezierWedge_GetBoundaryQuad_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ABF4 RID: 109556 RVA: 0x00253CDC File Offset: 0x00251EDC
		public override vtkHigherOrderQuadrilateral GetBoundaryQuad()
		{
			vtkHigherOrderQuadrilateral vtkHigherOrderQuadrilateral = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBezierWedge.vtkBezierWedge_GetBoundaryQuad_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601ABF5 RID: 109557
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBezierWedge_GetBoundaryTri_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ABF6 RID: 109558 RVA: 0x00253D4C File Offset: 0x00251F4C
		public override vtkHigherOrderTriangle GetBoundaryTri()
		{
			vtkHigherOrderTriangle vtkHigherOrderTriangle = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBezierWedge.vtkBezierWedge_GetBoundaryTri_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601ABF7 RID: 109559
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBezierWedge_GetCellType_03(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ABF8 RID: 109560 RVA: 0x00253DBC File Offset: 0x00251FBC
		public override int GetCellType()
		{
			return vtkBezierWedge.vtkBezierWedge_GetCellType_03(base.GetCppThis());
		}

		// Token: 0x0601ABF9 RID: 109561
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBezierWedge_GetEdge_04(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ABFA RID: 109562 RVA: 0x00253DDC File Offset: 0x00251FDC
		public override vtkCell GetEdge(int edgeId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBezierWedge.vtkBezierWedge_GetEdge_04(base.GetCppThis(), edgeId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601ABFB RID: 109563
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBezierWedge_GetEdgeCell_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ABFC RID: 109564 RVA: 0x00253E4C File Offset: 0x0025204C
		public override vtkHigherOrderCurve GetEdgeCell()
		{
			vtkHigherOrderCurve vtkHigherOrderCurve = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBezierWedge.vtkBezierWedge_GetEdgeCell_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601ABFD RID: 109565
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBezierWedge_GetFace_06(HandleRef pThis, int faceId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ABFE RID: 109566 RVA: 0x00253EBC File Offset: 0x002520BC
		public override vtkCell GetFace(int faceId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBezierWedge.vtkBezierWedge_GetFace_06(base.GetCppThis(), faceId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601ABFF RID: 109567
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBezierWedge_GetInterpolation_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AC00 RID: 109568 RVA: 0x00253F2C File Offset: 0x0025212C
		public override vtkHigherOrderInterpolation GetInterpolation()
		{
			vtkHigherOrderInterpolation vtkHigherOrderInterpolation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBezierWedge.vtkBezierWedge_GetInterpolation_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601AC01 RID: 109569
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBezierWedge_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AC02 RID: 109570 RVA: 0x00253F9C File Offset: 0x0025219C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBezierWedge.vtkBezierWedge_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x0601AC03 RID: 109571
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBezierWedge_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AC04 RID: 109572 RVA: 0x00253FBC File Offset: 0x002521BC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBezierWedge.vtkBezierWedge_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x0601AC05 RID: 109573
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBezierWedge_GetRationalWeights_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AC06 RID: 109574 RVA: 0x00253FD8 File Offset: 0x002521D8
		public vtkDoubleArray GetRationalWeights()
		{
			vtkDoubleArray vtkDoubleArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBezierWedge.vtkBezierWedge_GetRationalWeights_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDoubleArray = (vtkDoubleArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDoubleArray.Register(null);
				}
			}
			return vtkDoubleArray;
		}

		// Token: 0x0601AC07 RID: 109575
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBezierWedge_InterpolateDerivs_11(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AC08 RID: 109576 RVA: 0x00254047 File Offset: 0x00252247
		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkBezierWedge.vtkBezierWedge_InterpolateDerivs_11(base.GetCppThis(), pcoords, derivs);
		}

		// Token: 0x0601AC09 RID: 109577
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBezierWedge_InterpolateFunctions_12(HandleRef pThis, IntPtr pcoords, IntPtr weights);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AC0A RID: 109578 RVA: 0x00254058 File Offset: 0x00252258
		public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkBezierWedge.vtkBezierWedge_InterpolateFunctions_12(base.GetCppThis(), pcoords, weights);
		}

		// Token: 0x0601AC0B RID: 109579
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBezierWedge_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AC0C RID: 109580 RVA: 0x0025406C File Offset: 0x0025226C
		public override int IsA(string type)
		{
			return vtkBezierWedge.vtkBezierWedge_IsA_13(base.GetCppThis(), type);
		}

		// Token: 0x0601AC0D RID: 109581
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBezierWedge_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AC0E RID: 109582 RVA: 0x0025408C File Offset: 0x0025228C
		public new static int IsTypeOf(string type)
		{
			return vtkBezierWedge.vtkBezierWedge_IsTypeOf_14(type);
		}

		// Token: 0x0601AC0F RID: 109583
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBezierWedge_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AC10 RID: 109584 RVA: 0x002540A8 File Offset: 0x002522A8
		public new vtkBezierWedge NewInstance()
		{
			vtkBezierWedge result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBezierWedge.vtkBezierWedge_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBezierWedge)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601AC11 RID: 109585
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBezierWedge_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AC12 RID: 109586 RVA: 0x00254104 File Offset: 0x00252304
		public new static vtkBezierWedge SafeDownCast(vtkObjectBase o)
		{
			vtkBezierWedge vtkBezierWedge = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBezierWedge.vtkBezierWedge_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBezierWedge = (vtkBezierWedge)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBezierWedge.Register(null);
				}
			}
			return vtkBezierWedge;
		}

		// Token: 0x0601AC13 RID: 109587
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBezierWedge_SetRationalWeightsFromPointData_18(HandleRef pThis, HandleRef point_data, long numPts);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AC14 RID: 109588 RVA: 0x00254184 File Offset: 0x00252384
		public void SetRationalWeightsFromPointData(vtkPointData point_data, long numPts)
		{
			vtkBezierWedge.vtkBezierWedge_SetRationalWeightsFromPointData_18(base.GetCppThis(), (point_data == null) ? default(HandleRef) : point_data.GetCppThis(), numPts);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CF0 RID: 7408
		public new const string MRFullTypeName = "Kitware.VTK.vtkBezierWedge";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CF1 RID: 7409
		public new static readonly string MRClassNameKey = "class vtkBezierWedge";
	}
}
