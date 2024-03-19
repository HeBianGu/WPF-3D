using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBezierTriangle
	/// </summary>
	/// <remarks>
	///    A 2D cell that represents an arbitrary order Bezier triangle
	///
	/// vtkBezierTriangle is a concrete implementation of vtkCell to represent a
	/// 2D triangle using Bezier shape functions of user specified order.
	///
	/// The number of points in a Bezier cell determines the order over which they
	/// are iterated relative to the parametric coordinate system of the cell. The
	/// first points that are reported are vertices. They appear in the same order in
	/// which they would appear in linear cells. Mid-edge points are reported next.
	/// They are reported in sequence. For two- and three-dimensional (3D) cells, the
	/// following set of points to be reported are face points. Finally, 3D cells
	/// report points interior to their volume.
	/// </remarks>
	// Token: 0x02000A0A RID: 2570
	public class vtkBezierTriangle : vtkHigherOrderTriangle
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601AB6C RID: 109420 RVA: 0x00252DF5 File Offset: 0x00250FF5
		static vtkBezierTriangle()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBezierTriangle.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBezierTriangle"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601AB6D RID: 109421 RVA: 0x00252E1D File Offset: 0x0025101D
		public vtkBezierTriangle(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601AB6E RID: 109422
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBezierTriangle_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB6F RID: 109423 RVA: 0x00252E2C File Offset: 0x0025102C
		public new static vtkBezierTriangle New()
		{
			vtkBezierTriangle result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBezierTriangle.vtkBezierTriangle_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBezierTriangle)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB70 RID: 109424 RVA: 0x00252E80 File Offset: 0x00251080
		public vtkBezierTriangle() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBezierTriangle.vtkBezierTriangle_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601AB71 RID: 109425 RVA: 0x00252EC4 File Offset: 0x002510C4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601AB72 RID: 109426
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBezierTriangle_GetCellType_01(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB73 RID: 109427 RVA: 0x00252ED0 File Offset: 0x002510D0
		public override int GetCellType()
		{
			return vtkBezierTriangle.vtkBezierTriangle_GetCellType_01(base.GetCppThis());
		}

		// Token: 0x0601AB74 RID: 109428
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBezierTriangle_GetEdge_02(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB75 RID: 109429 RVA: 0x00252EF0 File Offset: 0x002510F0
		public override vtkCell GetEdge(int edgeId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBezierTriangle.vtkBezierTriangle_GetEdge_02(base.GetCppThis(), edgeId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601AB76 RID: 109430
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBezierTriangle_GetEdgeCell_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB77 RID: 109431 RVA: 0x00252F60 File Offset: 0x00251160
		public override vtkHigherOrderCurve GetEdgeCell()
		{
			vtkHigherOrderCurve vtkHigherOrderCurve = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBezierTriangle.vtkBezierTriangle_GetEdgeCell_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601AB78 RID: 109432
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBezierTriangle_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB79 RID: 109433 RVA: 0x00252FD0 File Offset: 0x002511D0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBezierTriangle.vtkBezierTriangle_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601AB7A RID: 109434
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBezierTriangle_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB7B RID: 109435 RVA: 0x00252FF0 File Offset: 0x002511F0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBezierTriangle.vtkBezierTriangle_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601AB7C RID: 109436
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBezierTriangle_GetRationalWeights_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB7D RID: 109437 RVA: 0x0025300C File Offset: 0x0025120C
		public vtkDoubleArray GetRationalWeights()
		{
			vtkDoubleArray vtkDoubleArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBezierTriangle.vtkBezierTriangle_GetRationalWeights_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601AB7E RID: 109438
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBezierTriangle_InterpolateDerivs_07(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB7F RID: 109439 RVA: 0x0025307B File Offset: 0x0025127B
		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkBezierTriangle.vtkBezierTriangle_InterpolateDerivs_07(base.GetCppThis(), pcoords, derivs);
		}

		// Token: 0x0601AB80 RID: 109440
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBezierTriangle_InterpolateFunctions_08(HandleRef pThis, IntPtr pcoords, IntPtr weights);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB81 RID: 109441 RVA: 0x0025308C File Offset: 0x0025128C
		public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkBezierTriangle.vtkBezierTriangle_InterpolateFunctions_08(base.GetCppThis(), pcoords, weights);
		}

		// Token: 0x0601AB82 RID: 109442
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBezierTriangle_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB83 RID: 109443 RVA: 0x002530A0 File Offset: 0x002512A0
		public override int IsA(string type)
		{
			return vtkBezierTriangle.vtkBezierTriangle_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x0601AB84 RID: 109444
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBezierTriangle_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB85 RID: 109445 RVA: 0x002530C0 File Offset: 0x002512C0
		public new static int IsTypeOf(string type)
		{
			return vtkBezierTriangle.vtkBezierTriangle_IsTypeOf_10(type);
		}

		// Token: 0x0601AB86 RID: 109446
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBezierTriangle_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB87 RID: 109447 RVA: 0x002530DC File Offset: 0x002512DC
		public new vtkBezierTriangle NewInstance()
		{
			vtkBezierTriangle result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBezierTriangle.vtkBezierTriangle_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBezierTriangle)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601AB88 RID: 109448
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBezierTriangle_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB89 RID: 109449 RVA: 0x00253138 File Offset: 0x00251338
		public new static vtkBezierTriangle SafeDownCast(vtkObjectBase o)
		{
			vtkBezierTriangle vtkBezierTriangle = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBezierTriangle.vtkBezierTriangle_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBezierTriangle = (vtkBezierTriangle)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBezierTriangle.Register(null);
				}
			}
			return vtkBezierTriangle;
		}

		// Token: 0x0601AB8A RID: 109450
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBezierTriangle_SetRationalWeightsFromPointData_14(HandleRef pThis, HandleRef point_data, long numPts);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AB8B RID: 109451 RVA: 0x002531B8 File Offset: 0x002513B8
		public void SetRationalWeightsFromPointData(vtkPointData point_data, long numPts)
		{
			vtkBezierTriangle.vtkBezierTriangle_SetRationalWeightsFromPointData_14(base.GetCppThis(), (point_data == null) ? default(HandleRef) : point_data.GetCppThis(), numPts);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CEC RID: 7404
		public new const string MRFullTypeName = "Kitware.VTK.vtkBezierTriangle";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CED RID: 7405
		public new static readonly string MRClassNameKey = "class vtkBezierTriangle";
	}
}
