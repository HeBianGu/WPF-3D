using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x02000A06 RID: 2566
	public class vtkBezierQuadrilateral : vtkHigherOrderQuadrilateral
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601AA8A RID: 109194 RVA: 0x00251581 File Offset: 0x0024F781
		static vtkBezierQuadrilateral()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBezierQuadrilateral.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBezierQuadrilateral"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601AA8B RID: 109195 RVA: 0x002515A9 File Offset: 0x0024F7A9
		public vtkBezierQuadrilateral(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601AA8C RID: 109196
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBezierQuadrilateral_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601AA8D RID: 109197 RVA: 0x002515B8 File Offset: 0x0024F7B8
		public new static vtkBezierQuadrilateral New()
		{
			vtkBezierQuadrilateral result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBezierQuadrilateral.vtkBezierQuadrilateral_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBezierQuadrilateral)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601AA8E RID: 109198 RVA: 0x0025160C File Offset: 0x0024F80C
		public vtkBezierQuadrilateral() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBezierQuadrilateral.vtkBezierQuadrilateral_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601AA8F RID: 109199 RVA: 0x00251650 File Offset: 0x0024F850
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601AA90 RID: 109200
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBezierQuadrilateral_GetCellType_01(HandleRef pThis);

		// Token: 0x0601AA91 RID: 109201 RVA: 0x0025165C File Offset: 0x0024F85C
		public override int GetCellType()
		{
			return vtkBezierQuadrilateral.vtkBezierQuadrilateral_GetCellType_01(base.GetCppThis());
		}

		// Token: 0x0601AA92 RID: 109202
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBezierQuadrilateral_GetEdge_02(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601AA93 RID: 109203 RVA: 0x0025167C File Offset: 0x0024F87C
		public override vtkCell GetEdge(int edgeId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBezierQuadrilateral.vtkBezierQuadrilateral_GetEdge_02(base.GetCppThis(), edgeId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601AA94 RID: 109204
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBezierQuadrilateral_GetEdgeCell_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601AA95 RID: 109205 RVA: 0x002516EC File Offset: 0x0024F8EC
		public override vtkHigherOrderCurve GetEdgeCell()
		{
			vtkHigherOrderCurve vtkHigherOrderCurve = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBezierQuadrilateral.vtkBezierQuadrilateral_GetEdgeCell_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601AA96 RID: 109206
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBezierQuadrilateral_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601AA97 RID: 109207 RVA: 0x0025175C File Offset: 0x0024F95C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBezierQuadrilateral.vtkBezierQuadrilateral_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601AA98 RID: 109208
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBezierQuadrilateral_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601AA99 RID: 109209 RVA: 0x0025177C File Offset: 0x0024F97C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBezierQuadrilateral.vtkBezierQuadrilateral_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601AA9A RID: 109210
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBezierQuadrilateral_GetRationalWeights_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601AA9B RID: 109211 RVA: 0x00251798 File Offset: 0x0024F998
		public vtkDoubleArray GetRationalWeights()
		{
			vtkDoubleArray vtkDoubleArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBezierQuadrilateral.vtkBezierQuadrilateral_GetRationalWeights_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601AA9C RID: 109212
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBezierQuadrilateral_InterpolateDerivs_07(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		// Token: 0x0601AA9D RID: 109213 RVA: 0x00251807 File Offset: 0x0024FA07
		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkBezierQuadrilateral.vtkBezierQuadrilateral_InterpolateDerivs_07(base.GetCppThis(), pcoords, derivs);
		}

		// Token: 0x0601AA9E RID: 109214
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBezierQuadrilateral_InterpolateFunctions_08(HandleRef pThis, IntPtr pcoords, IntPtr weights);

		// Token: 0x0601AA9F RID: 109215 RVA: 0x00251818 File Offset: 0x0024FA18
		public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkBezierQuadrilateral.vtkBezierQuadrilateral_InterpolateFunctions_08(base.GetCppThis(), pcoords, weights);
		}

		// Token: 0x0601AAA0 RID: 109216
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBezierQuadrilateral_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601AAA1 RID: 109217 RVA: 0x0025182C File Offset: 0x0024FA2C
		public override int IsA(string type)
		{
			return vtkBezierQuadrilateral.vtkBezierQuadrilateral_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x0601AAA2 RID: 109218
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBezierQuadrilateral_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601AAA3 RID: 109219 RVA: 0x0025184C File Offset: 0x0024FA4C
		public new static int IsTypeOf(string type)
		{
			return vtkBezierQuadrilateral.vtkBezierQuadrilateral_IsTypeOf_10(type);
		}

		// Token: 0x0601AAA4 RID: 109220
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBezierQuadrilateral_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601AAA5 RID: 109221 RVA: 0x00251868 File Offset: 0x0024FA68
		public new vtkBezierQuadrilateral NewInstance()
		{
			vtkBezierQuadrilateral result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBezierQuadrilateral.vtkBezierQuadrilateral_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBezierQuadrilateral)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601AAA6 RID: 109222
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBezierQuadrilateral_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601AAA7 RID: 109223 RVA: 0x002518C4 File Offset: 0x0024FAC4
		public new static vtkBezierQuadrilateral SafeDownCast(vtkObjectBase o)
		{
			vtkBezierQuadrilateral vtkBezierQuadrilateral = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBezierQuadrilateral.vtkBezierQuadrilateral_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBezierQuadrilateral = (vtkBezierQuadrilateral)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBezierQuadrilateral.Register(null);
				}
			}
			return vtkBezierQuadrilateral;
		}

		// Token: 0x0601AAA8 RID: 109224
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBezierQuadrilateral_SetRationalWeightsFromPointData_14(HandleRef pThis, HandleRef point_data, long numPts);

		// Token: 0x0601AAA9 RID: 109225 RVA: 0x00251944 File Offset: 0x0024FB44
		public void SetRationalWeightsFromPointData(vtkPointData point_data, long numPts)
		{
			vtkBezierQuadrilateral.vtkBezierQuadrilateral_SetRationalWeightsFromPointData_14(base.GetCppThis(), (point_data == null) ? default(HandleRef) : point_data.GetCppThis(), numPts);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CE4 RID: 7396
		public new const string MRFullTypeName = "Kitware.VTK.vtkBezierQuadrilateral";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CE5 RID: 7397
		public new static readonly string MRClassNameKey = "class vtkBezierQuadrilateral";
	}
}
