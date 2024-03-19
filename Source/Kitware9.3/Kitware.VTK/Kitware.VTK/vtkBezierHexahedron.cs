using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBezierHexahedron
	/// </summary>
	/// <remarks>
	///    A 3D cell that represents an arbitrary order Bezier hex
	///
	/// vtkBezierHexahedron is a concrete implementation of vtkCell to represent a
	/// 3D hexahedron using Bezier shape functions of user specified order.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkHexahedron
	/// </seealso>
	// Token: 0x02000A02 RID: 2562
	public class vtkBezierHexahedron : vtkHigherOrderHexahedron
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A9A6 RID: 108966 RVA: 0x0024FE3D File Offset: 0x0024E03D
		static vtkBezierHexahedron()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBezierHexahedron.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBezierHexahedron"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A9A7 RID: 108967 RVA: 0x0024FE65 File Offset: 0x0024E065
		public vtkBezierHexahedron(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601A9A8 RID: 108968
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBezierHexahedron_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A9A9 RID: 108969 RVA: 0x0024FE74 File Offset: 0x0024E074
		public new static vtkBezierHexahedron New()
		{
			vtkBezierHexahedron result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBezierHexahedron.vtkBezierHexahedron_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBezierHexahedron)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A9AA RID: 108970 RVA: 0x0024FEC8 File Offset: 0x0024E0C8
		public vtkBezierHexahedron() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBezierHexahedron.vtkBezierHexahedron_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A9AB RID: 108971 RVA: 0x0024FF0C File Offset: 0x0024E10C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A9AC RID: 108972
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBezierHexahedron_GetCellType_01(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A9AD RID: 108973 RVA: 0x0024FF18 File Offset: 0x0024E118
		public override int GetCellType()
		{
			return vtkBezierHexahedron.vtkBezierHexahedron_GetCellType_01(base.GetCppThis());
		}

		// Token: 0x0601A9AE RID: 108974
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBezierHexahedron_GetEdge_02(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A9AF RID: 108975 RVA: 0x0024FF38 File Offset: 0x0024E138
		public override vtkCell GetEdge(int edgeId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBezierHexahedron.vtkBezierHexahedron_GetEdge_02(base.GetCppThis(), edgeId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601A9B0 RID: 108976
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBezierHexahedron_GetEdgeCell_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A9B1 RID: 108977 RVA: 0x0024FFA8 File Offset: 0x0024E1A8
		public override vtkHigherOrderCurve GetEdgeCell()
		{
			vtkHigherOrderCurve vtkHigherOrderCurve = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBezierHexahedron.vtkBezierHexahedron_GetEdgeCell_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601A9B2 RID: 108978
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBezierHexahedron_GetFace_04(HandleRef pThis, int faceId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A9B3 RID: 108979 RVA: 0x00250018 File Offset: 0x0024E218
		public override vtkCell GetFace(int faceId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBezierHexahedron.vtkBezierHexahedron_GetFace_04(base.GetCppThis(), faceId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601A9B4 RID: 108980
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBezierHexahedron_GetFaceCell_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A9B5 RID: 108981 RVA: 0x00250088 File Offset: 0x0024E288
		public override vtkHigherOrderQuadrilateral GetFaceCell()
		{
			vtkHigherOrderQuadrilateral vtkHigherOrderQuadrilateral = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBezierHexahedron.vtkBezierHexahedron_GetFaceCell_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601A9B6 RID: 108982
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBezierHexahedron_GetInterpolation_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A9B7 RID: 108983 RVA: 0x002500F8 File Offset: 0x0024E2F8
		public override vtkHigherOrderInterpolation GetInterpolation()
		{
			vtkHigherOrderInterpolation vtkHigherOrderInterpolation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBezierHexahedron.vtkBezierHexahedron_GetInterpolation_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601A9B8 RID: 108984
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBezierHexahedron_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A9B9 RID: 108985 RVA: 0x00250168 File Offset: 0x0024E368
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBezierHexahedron.vtkBezierHexahedron_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0601A9BA RID: 108986
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBezierHexahedron_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A9BB RID: 108987 RVA: 0x00250188 File Offset: 0x0024E388
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBezierHexahedron.vtkBezierHexahedron_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x0601A9BC RID: 108988
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBezierHexahedron_GetRationalWeights_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A9BD RID: 108989 RVA: 0x002501A4 File Offset: 0x0024E3A4
		public vtkDoubleArray GetRationalWeights()
		{
			vtkDoubleArray vtkDoubleArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBezierHexahedron.vtkBezierHexahedron_GetRationalWeights_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601A9BE RID: 108990
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBezierHexahedron_InterpolateDerivs_10(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A9BF RID: 108991 RVA: 0x00250213 File Offset: 0x0024E413
		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkBezierHexahedron.vtkBezierHexahedron_InterpolateDerivs_10(base.GetCppThis(), pcoords, derivs);
		}

		// Token: 0x0601A9C0 RID: 108992
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBezierHexahedron_InterpolateFunctions_11(HandleRef pThis, IntPtr pcoords, IntPtr weights);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A9C1 RID: 108993 RVA: 0x00250224 File Offset: 0x0024E424
		public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkBezierHexahedron.vtkBezierHexahedron_InterpolateFunctions_11(base.GetCppThis(), pcoords, weights);
		}

		// Token: 0x0601A9C2 RID: 108994
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBezierHexahedron_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A9C3 RID: 108995 RVA: 0x00250238 File Offset: 0x0024E438
		public override int IsA(string type)
		{
			return vtkBezierHexahedron.vtkBezierHexahedron_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x0601A9C4 RID: 108996
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBezierHexahedron_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A9C5 RID: 108997 RVA: 0x00250258 File Offset: 0x0024E458
		public new static int IsTypeOf(string type)
		{
			return vtkBezierHexahedron.vtkBezierHexahedron_IsTypeOf_13(type);
		}

		// Token: 0x0601A9C6 RID: 108998
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBezierHexahedron_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A9C7 RID: 108999 RVA: 0x00250274 File Offset: 0x0024E474
		public new vtkBezierHexahedron NewInstance()
		{
			vtkBezierHexahedron result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBezierHexahedron.vtkBezierHexahedron_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBezierHexahedron)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A9C8 RID: 109000
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBezierHexahedron_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A9C9 RID: 109001 RVA: 0x002502D0 File Offset: 0x0024E4D0
		public new static vtkBezierHexahedron SafeDownCast(vtkObjectBase o)
		{
			vtkBezierHexahedron vtkBezierHexahedron = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBezierHexahedron.vtkBezierHexahedron_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBezierHexahedron = (vtkBezierHexahedron)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBezierHexahedron.Register(null);
				}
			}
			return vtkBezierHexahedron;
		}

		// Token: 0x0601A9CA RID: 109002
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBezierHexahedron_SetRationalWeightsFromPointData_17(HandleRef pThis, HandleRef point_data, long numPts);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A9CB RID: 109003 RVA: 0x00250350 File Offset: 0x0024E550
		public void SetRationalWeightsFromPointData(vtkPointData point_data, long numPts)
		{
			vtkBezierHexahedron.vtkBezierHexahedron_SetRationalWeightsFromPointData_17(base.GetCppThis(), (point_data == null) ? default(HandleRef) : point_data.GetCppThis(), numPts);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CDC RID: 7388
		public new const string MRFullTypeName = "Kitware.VTK.vtkBezierHexahedron";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CDD RID: 7389
		public new static readonly string MRClassNameKey = "class vtkBezierHexahedron";
	}
}
