using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCellGridRangeQuery
	/// </summary>
	/// <remarks>
	///    Compute the range of a component of some vtkCellAttribute.
	///
	/// If \a FiniteRange is true, then the range will omit any NaN or ±Inf
	/// values present in the data. Otherwise (the default), the range may
	/// contain these exceptional values.
	///
	/// If \a Component is
	/// + -2 (the default), the range of L₂-norms is computed.
	/// + -1, the range of L₁-norms is computed.
	/// + out of bounds, then an invalid range will be returned ([1, 0]).
	///
	/// Note that this query is intended to be run by vtkCellGrid::GetRange()
	/// since the cell-grid holds a cache of ranges. You may run it outside
	/// of this method, but that may cause unnecessary re-computation of ranges.
	/// </remarks>
	// Token: 0x02000A22 RID: 2594
	public class vtkCellGridRangeQuery : vtkCellGridQuery
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601B0A4 RID: 110756 RVA: 0x0025BCD6 File Offset: 0x00259ED6
		static vtkCellGridRangeQuery()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellGridRangeQuery.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellGridRangeQuery"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601B0A5 RID: 110757 RVA: 0x0025BCFE File Offset: 0x00259EFE
		public vtkCellGridRangeQuery(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601B0A6 RID: 110758
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridRangeQuery_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B0A7 RID: 110759 RVA: 0x0025BD0C File Offset: 0x00259F0C
		public new static vtkCellGridRangeQuery New()
		{
			vtkCellGridRangeQuery result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridRangeQuery.vtkCellGridRangeQuery_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellGridRangeQuery)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B0A8 RID: 110760 RVA: 0x0025BD60 File Offset: 0x00259F60
		public vtkCellGridRangeQuery() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCellGridRangeQuery.vtkCellGridRangeQuery_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601B0A9 RID: 110761 RVA: 0x0025BDA4 File Offset: 0x00259FA4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601B0AA RID: 110762
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridRangeQuery_Finalize_01(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B0AB RID: 110763 RVA: 0x0025BDAF File Offset: 0x00259FAF
		public override void FinalizeWrapper()
		{
			vtkCellGridRangeQuery.vtkCellGridRangeQuery_Finalize_01(base.GetCppThis());
		}

		// Token: 0x0601B0AC RID: 110764
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridRangeQuery_GetCellAttribute_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B0AD RID: 110765 RVA: 0x0025BDC0 File Offset: 0x00259FC0
		public virtual vtkCellAttribute GetCellAttribute()
		{
			vtkCellAttribute vtkCellAttribute = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridRangeQuery.vtkCellGridRangeQuery_GetCellAttribute_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellAttribute = (vtkCellAttribute)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellAttribute.Register(null);
				}
			}
			return vtkCellAttribute;
		}

		// Token: 0x0601B0AE RID: 110766
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridRangeQuery_GetCellGrid_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B0AF RID: 110767 RVA: 0x0025BE30 File Offset: 0x0025A030
		public virtual vtkCellGrid GetCellGrid()
		{
			vtkCellGrid vtkCellGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridRangeQuery.vtkCellGridRangeQuery_GetCellGrid_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellGrid = (vtkCellGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellGrid.Register(null);
				}
			}
			return vtkCellGrid;
		}

		// Token: 0x0601B0B0 RID: 110768
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellGridRangeQuery_GetComponent_04(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B0B1 RID: 110769 RVA: 0x0025BEA0 File Offset: 0x0025A0A0
		public virtual int GetComponent()
		{
			return vtkCellGridRangeQuery.vtkCellGridRangeQuery_GetComponent_04(base.GetCppThis());
		}

		// Token: 0x0601B0B2 RID: 110770
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellGridRangeQuery_GetFiniteRange_05(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B0B3 RID: 110771 RVA: 0x0025BEC0 File Offset: 0x0025A0C0
		public virtual int GetFiniteRange()
		{
			return vtkCellGridRangeQuery.vtkCellGridRangeQuery_GetFiniteRange_05(base.GetCppThis());
		}

		// Token: 0x0601B0B4 RID: 110772
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellGridRangeQuery_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B0B5 RID: 110773 RVA: 0x0025BEE0 File Offset: 0x0025A0E0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCellGridRangeQuery.vtkCellGridRangeQuery_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0601B0B6 RID: 110774
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellGridRangeQuery_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B0B7 RID: 110775 RVA: 0x0025BF00 File Offset: 0x0025A100
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCellGridRangeQuery.vtkCellGridRangeQuery_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0601B0B8 RID: 110776
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridRangeQuery_GetRange_08(HandleRef pThis, IntPtr range);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B0B9 RID: 110777 RVA: 0x0025BF1A File Offset: 0x0025A11A
		public void GetRange(IntPtr range)
		{
			vtkCellGridRangeQuery.vtkCellGridRangeQuery_GetRange_08(base.GetCppThis(), range);
		}

		// Token: 0x0601B0BA RID: 110778
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridRangeQuery_Initialize_09(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B0BB RID: 110779 RVA: 0x0025BF2A File Offset: 0x0025A12A
		public override void Initialize()
		{
			vtkCellGridRangeQuery.vtkCellGridRangeQuery_Initialize_09(base.GetCppThis());
		}

		// Token: 0x0601B0BC RID: 110780
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellGridRangeQuery_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B0BD RID: 110781 RVA: 0x0025BF3C File Offset: 0x0025A13C
		public override int IsA(string type)
		{
			return vtkCellGridRangeQuery.vtkCellGridRangeQuery_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x0601B0BE RID: 110782
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellGridRangeQuery_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B0BF RID: 110783 RVA: 0x0025BF5C File Offset: 0x0025A15C
		public new static int IsTypeOf(string type)
		{
			return vtkCellGridRangeQuery.vtkCellGridRangeQuery_IsTypeOf_11(type);
		}

		// Token: 0x0601B0C0 RID: 110784
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridRangeQuery_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B0C1 RID: 110785 RVA: 0x0025BF78 File Offset: 0x0025A178
		public new vtkCellGridRangeQuery NewInstance()
		{
			vtkCellGridRangeQuery result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridRangeQuery.vtkCellGridRangeQuery_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellGridRangeQuery)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601B0C2 RID: 110786
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridRangeQuery_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B0C3 RID: 110787 RVA: 0x0025BFD4 File Offset: 0x0025A1D4
		public new static vtkCellGridRangeQuery SafeDownCast(vtkObjectBase o)
		{
			vtkCellGridRangeQuery vtkCellGridRangeQuery = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridRangeQuery.vtkCellGridRangeQuery_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellGridRangeQuery = (vtkCellGridRangeQuery)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellGridRangeQuery.Register(null);
				}
			}
			return vtkCellGridRangeQuery;
		}

		// Token: 0x0601B0C4 RID: 110788
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridRangeQuery_SetCellAttribute_15(HandleRef pThis, HandleRef _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B0C5 RID: 110789 RVA: 0x0025C054 File Offset: 0x0025A254
		public virtual void SetCellAttribute(vtkCellAttribute _arg)
		{
			vtkCellGridRangeQuery.vtkCellGridRangeQuery_SetCellAttribute_15(base.GetCppThis(), (_arg == null) ? default(HandleRef) : _arg.GetCppThis());
		}

		// Token: 0x0601B0C6 RID: 110790
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridRangeQuery_SetCellGrid_16(HandleRef pThis, HandleRef grid);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B0C7 RID: 110791 RVA: 0x0025C084 File Offset: 0x0025A284
		public virtual void SetCellGrid(vtkCellGrid grid)
		{
			vtkCellGridRangeQuery.vtkCellGridRangeQuery_SetCellGrid_16(base.GetCppThis(), (grid == null) ? default(HandleRef) : grid.GetCppThis());
		}

		// Token: 0x0601B0C8 RID: 110792
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridRangeQuery_SetComponent_17(HandleRef pThis, int _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B0C9 RID: 110793 RVA: 0x0025C0B3 File Offset: 0x0025A2B3
		public virtual void SetComponent(int _arg)
		{
			vtkCellGridRangeQuery.vtkCellGridRangeQuery_SetComponent_17(base.GetCppThis(), _arg);
		}

		// Token: 0x0601B0CA RID: 110794
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridRangeQuery_SetFiniteRange_18(HandleRef pThis, int _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B0CB RID: 110795 RVA: 0x0025C0C3 File Offset: 0x0025A2C3
		public virtual void SetFiniteRange(int _arg)
		{
			vtkCellGridRangeQuery.vtkCellGridRangeQuery_SetFiniteRange_18(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D36 RID: 7478
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellGridRangeQuery";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D37 RID: 7479
		public new static readonly string MRClassNameKey = "class vtkCellGridRangeQuery";
	}
}
