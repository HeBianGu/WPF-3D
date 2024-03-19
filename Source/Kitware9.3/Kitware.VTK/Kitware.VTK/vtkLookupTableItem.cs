using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x02000651 RID: 1617
	public class vtkLookupTableItem : vtkScalarsToColorsItem
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060117F4 RID: 71668 RVA: 0x00186A17 File Offset: 0x00184C17
		static vtkLookupTableItem()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLookupTableItem.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLookupTableItem"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060117F5 RID: 71669 RVA: 0x00186A3F File Offset: 0x00184C3F
		public vtkLookupTableItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060117F6 RID: 71670
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLookupTableItem_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x060117F7 RID: 71671 RVA: 0x00186A50 File Offset: 0x00184C50
		public new static vtkLookupTableItem New()
		{
			vtkLookupTableItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLookupTableItem.vtkLookupTableItem_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLookupTableItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060117F8 RID: 71672 RVA: 0x00186AA4 File Offset: 0x00184CA4
		public vtkLookupTableItem() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLookupTableItem.vtkLookupTableItem_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060117F9 RID: 71673 RVA: 0x00186AE8 File Offset: 0x00184CE8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060117FA RID: 71674
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLookupTableItem_GetLookupTable_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x060117FB RID: 71675 RVA: 0x00186AF4 File Offset: 0x00184CF4
		public virtual vtkLookupTable GetLookupTable()
		{
			vtkLookupTable vtkLookupTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLookupTableItem.vtkLookupTableItem_GetLookupTable_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLookupTable = (vtkLookupTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLookupTable.Register(null);
				}
			}
			return vtkLookupTable;
		}

		// Token: 0x060117FC RID: 71676
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLookupTableItem_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x060117FD RID: 71677 RVA: 0x00186B64 File Offset: 0x00184D64
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLookupTableItem.vtkLookupTableItem_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060117FE RID: 71678
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLookupTableItem_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x060117FF RID: 71679 RVA: 0x00186B84 File Offset: 0x00184D84
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLookupTableItem.vtkLookupTableItem_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06011800 RID: 71680
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLookupTableItem_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x06011801 RID: 71681 RVA: 0x00186BA0 File Offset: 0x00184DA0
		public override int IsA(string type)
		{
			return vtkLookupTableItem.vtkLookupTableItem_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06011802 RID: 71682
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLookupTableItem_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x06011803 RID: 71683 RVA: 0x00186BC0 File Offset: 0x00184DC0
		public new static int IsTypeOf(string type)
		{
			return vtkLookupTableItem.vtkLookupTableItem_IsTypeOf_05(type);
		}

		// Token: 0x06011804 RID: 71684
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLookupTableItem_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06011805 RID: 71685 RVA: 0x00186BDC File Offset: 0x00184DDC
		public new vtkLookupTableItem NewInstance()
		{
			vtkLookupTableItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLookupTableItem.vtkLookupTableItem_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLookupTableItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011806 RID: 71686
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLookupTableItem_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06011807 RID: 71687 RVA: 0x00186C38 File Offset: 0x00184E38
		public new static vtkLookupTableItem SafeDownCast(vtkObjectBase o)
		{
			vtkLookupTableItem vtkLookupTableItem = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLookupTableItem.vtkLookupTableItem_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLookupTableItem = (vtkLookupTableItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLookupTableItem.Register(null);
				}
			}
			return vtkLookupTableItem;
		}

		// Token: 0x06011808 RID: 71688
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTableItem_SetLookupTable_09(HandleRef pThis, HandleRef t);

		// Token: 0x06011809 RID: 71689 RVA: 0x00186CB8 File Offset: 0x00184EB8
		public void SetLookupTable(vtkLookupTable t)
		{
			vtkLookupTableItem.vtkLookupTableItem_SetLookupTable_09(base.GetCppThis(), (t == null) ? default(HandleRef) : t.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001432 RID: 5170
		public new const string MRFullTypeName = "Kitware.VTK.vtkLookupTableItem";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001433 RID: 5171
		public new static readonly string MRClassNameKey = "class vtkLookupTableItem";
	}
}
