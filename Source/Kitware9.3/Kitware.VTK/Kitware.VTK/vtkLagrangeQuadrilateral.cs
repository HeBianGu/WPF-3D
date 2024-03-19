using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x02000A7A RID: 2682
	public class vtkLagrangeQuadrilateral : vtkHigherOrderQuadrilateral
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601C1AE RID: 115118 RVA: 0x002765D5 File Offset: 0x002747D5
		static vtkLagrangeQuadrilateral()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLagrangeQuadrilateral.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLagrangeQuadrilateral"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601C1AF RID: 115119 RVA: 0x002765FD File Offset: 0x002747FD
		public vtkLagrangeQuadrilateral(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601C1B0 RID: 115120
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangeQuadrilateral_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601C1B1 RID: 115121 RVA: 0x0027660C File Offset: 0x0027480C
		public new static vtkLagrangeQuadrilateral New()
		{
			vtkLagrangeQuadrilateral result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangeQuadrilateral.vtkLagrangeQuadrilateral_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLagrangeQuadrilateral)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601C1B2 RID: 115122 RVA: 0x00276660 File Offset: 0x00274860
		public vtkLagrangeQuadrilateral() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLagrangeQuadrilateral.vtkLagrangeQuadrilateral_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601C1B3 RID: 115123 RVA: 0x002766A4 File Offset: 0x002748A4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601C1B4 RID: 115124
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLagrangeQuadrilateral_GetCellType_01(HandleRef pThis);

		// Token: 0x0601C1B5 RID: 115125 RVA: 0x002766B0 File Offset: 0x002748B0
		public override int GetCellType()
		{
			return vtkLagrangeQuadrilateral.vtkLagrangeQuadrilateral_GetCellType_01(base.GetCppThis());
		}

		// Token: 0x0601C1B6 RID: 115126
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangeQuadrilateral_GetEdge_02(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601C1B7 RID: 115127 RVA: 0x002766D0 File Offset: 0x002748D0
		public override vtkCell GetEdge(int edgeId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangeQuadrilateral.vtkLagrangeQuadrilateral_GetEdge_02(base.GetCppThis(), edgeId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601C1B8 RID: 115128
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangeQuadrilateral_GetEdgeCell_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601C1B9 RID: 115129 RVA: 0x00276740 File Offset: 0x00274940
		public override vtkHigherOrderCurve GetEdgeCell()
		{
			vtkHigherOrderCurve vtkHigherOrderCurve = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangeQuadrilateral.vtkLagrangeQuadrilateral_GetEdgeCell_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601C1BA RID: 115130
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLagrangeQuadrilateral_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601C1BB RID: 115131 RVA: 0x002767B0 File Offset: 0x002749B0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLagrangeQuadrilateral.vtkLagrangeQuadrilateral_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601C1BC RID: 115132
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLagrangeQuadrilateral_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601C1BD RID: 115133 RVA: 0x002767D0 File Offset: 0x002749D0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLagrangeQuadrilateral.vtkLagrangeQuadrilateral_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601C1BE RID: 115134
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangeQuadrilateral_InterpolateDerivs_06(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		// Token: 0x0601C1BF RID: 115135 RVA: 0x002767EA File Offset: 0x002749EA
		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkLagrangeQuadrilateral.vtkLagrangeQuadrilateral_InterpolateDerivs_06(base.GetCppThis(), pcoords, derivs);
		}

		// Token: 0x0601C1C0 RID: 115136
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangeQuadrilateral_InterpolateFunctions_07(HandleRef pThis, IntPtr pcoords, IntPtr weights);

		// Token: 0x0601C1C1 RID: 115137 RVA: 0x002767FB File Offset: 0x002749FB
		public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkLagrangeQuadrilateral.vtkLagrangeQuadrilateral_InterpolateFunctions_07(base.GetCppThis(), pcoords, weights);
		}

		// Token: 0x0601C1C2 RID: 115138
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLagrangeQuadrilateral_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601C1C3 RID: 115139 RVA: 0x0027680C File Offset: 0x00274A0C
		public override int IsA(string type)
		{
			return vtkLagrangeQuadrilateral.vtkLagrangeQuadrilateral_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0601C1C4 RID: 115140
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLagrangeQuadrilateral_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601C1C5 RID: 115141 RVA: 0x0027682C File Offset: 0x00274A2C
		public new static int IsTypeOf(string type)
		{
			return vtkLagrangeQuadrilateral.vtkLagrangeQuadrilateral_IsTypeOf_09(type);
		}

		// Token: 0x0601C1C6 RID: 115142
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangeQuadrilateral_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601C1C7 RID: 115143 RVA: 0x00276848 File Offset: 0x00274A48
		public new vtkLagrangeQuadrilateral NewInstance()
		{
			vtkLagrangeQuadrilateral result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangeQuadrilateral.vtkLagrangeQuadrilateral_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLagrangeQuadrilateral)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601C1C8 RID: 115144
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangeQuadrilateral_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601C1C9 RID: 115145 RVA: 0x002768A4 File Offset: 0x00274AA4
		public new static vtkLagrangeQuadrilateral SafeDownCast(vtkObjectBase o)
		{
			vtkLagrangeQuadrilateral vtkLagrangeQuadrilateral = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangeQuadrilateral.vtkLagrangeQuadrilateral_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLagrangeQuadrilateral = (vtkLagrangeQuadrilateral)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLagrangeQuadrilateral.Register(null);
				}
			}
			return vtkLagrangeQuadrilateral;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DEB RID: 7659
		public new const string MRFullTypeName = "Kitware.VTK.vtkLagrangeQuadrilateral";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DEC RID: 7660
		public new static readonly string MRClassNameKey = "class vtkLagrangeQuadrilateral";
	}
}
