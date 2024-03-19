using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x02000653 RID: 1619
	public class vtkPiecewiseFunctionItem : vtkScalarsToColorsItem
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011824 RID: 71716 RVA: 0x00186FF7 File Offset: 0x001851F7
		static vtkPiecewiseFunctionItem()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPiecewiseFunctionItem.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPiecewiseFunctionItem"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011825 RID: 71717 RVA: 0x0018701F File Offset: 0x0018521F
		public vtkPiecewiseFunctionItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011826 RID: 71718
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPiecewiseFunctionItem_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06011827 RID: 71719 RVA: 0x00187030 File Offset: 0x00185230
		public new static vtkPiecewiseFunctionItem New()
		{
			vtkPiecewiseFunctionItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPiecewiseFunctionItem.vtkPiecewiseFunctionItem_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPiecewiseFunctionItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011828 RID: 71720 RVA: 0x00187084 File Offset: 0x00185284
		public vtkPiecewiseFunctionItem() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPiecewiseFunctionItem.vtkPiecewiseFunctionItem_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011829 RID: 71721 RVA: 0x001870C8 File Offset: 0x001852C8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601182A RID: 71722
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPiecewiseFunctionItem_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601182B RID: 71723 RVA: 0x001870D4 File Offset: 0x001852D4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPiecewiseFunctionItem.vtkPiecewiseFunctionItem_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601182C RID: 71724
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPiecewiseFunctionItem_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601182D RID: 71725 RVA: 0x001870F4 File Offset: 0x001852F4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPiecewiseFunctionItem.vtkPiecewiseFunctionItem_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601182E RID: 71726
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPiecewiseFunctionItem_GetPiecewiseFunction_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601182F RID: 71727 RVA: 0x00187110 File Offset: 0x00185310
		public virtual vtkPiecewiseFunction GetPiecewiseFunction()
		{
			vtkPiecewiseFunction vtkPiecewiseFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPiecewiseFunctionItem.vtkPiecewiseFunctionItem_GetPiecewiseFunction_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPiecewiseFunction = (vtkPiecewiseFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPiecewiseFunction.Register(null);
				}
			}
			return vtkPiecewiseFunction;
		}

		// Token: 0x06011830 RID: 71728
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPiecewiseFunctionItem_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x06011831 RID: 71729 RVA: 0x00187180 File Offset: 0x00185380
		public override int IsA(string type)
		{
			return vtkPiecewiseFunctionItem.vtkPiecewiseFunctionItem_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06011832 RID: 71730
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPiecewiseFunctionItem_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x06011833 RID: 71731 RVA: 0x001871A0 File Offset: 0x001853A0
		public new static int IsTypeOf(string type)
		{
			return vtkPiecewiseFunctionItem.vtkPiecewiseFunctionItem_IsTypeOf_05(type);
		}

		// Token: 0x06011834 RID: 71732
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPiecewiseFunctionItem_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06011835 RID: 71733 RVA: 0x001871BC File Offset: 0x001853BC
		public new vtkPiecewiseFunctionItem NewInstance()
		{
			vtkPiecewiseFunctionItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPiecewiseFunctionItem.vtkPiecewiseFunctionItem_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPiecewiseFunctionItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011836 RID: 71734
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPiecewiseFunctionItem_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06011837 RID: 71735 RVA: 0x00187218 File Offset: 0x00185418
		public new static vtkPiecewiseFunctionItem SafeDownCast(vtkObjectBase o)
		{
			vtkPiecewiseFunctionItem vtkPiecewiseFunctionItem = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPiecewiseFunctionItem.vtkPiecewiseFunctionItem_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPiecewiseFunctionItem = (vtkPiecewiseFunctionItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPiecewiseFunctionItem.Register(null);
				}
			}
			return vtkPiecewiseFunctionItem;
		}

		// Token: 0x06011838 RID: 71736
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPiecewiseFunctionItem_SetPiecewiseFunction_09(HandleRef pThis, HandleRef t);

		// Token: 0x06011839 RID: 71737 RVA: 0x00187298 File Offset: 0x00185498
		public void SetPiecewiseFunction(vtkPiecewiseFunction t)
		{
			vtkPiecewiseFunctionItem.vtkPiecewiseFunctionItem_SetPiecewiseFunction_09(base.GetCppThis(), (t == null) ? default(HandleRef) : t.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001436 RID: 5174
		public new const string MRFullTypeName = "Kitware.VTK.vtkPiecewiseFunctionItem";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001437 RID: 5175
		public new static readonly string MRClassNameKey = "class vtkPiecewiseFunctionItem";
	}
}
