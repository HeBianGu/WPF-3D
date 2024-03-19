using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	/// Override the histogram plotbar configuration
	/// in order to set the color transfer function on it
	/// </summary>
	// Token: 0x0200064A RID: 1610
	public class vtkColorTransferFunctionItem : vtkScalarsToColorsItem
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011744 RID: 71492 RVA: 0x001857A3 File Offset: 0x001839A3
		static vtkColorTransferFunctionItem()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkColorTransferFunctionItem.MRClassNameKey, Type.GetType("Kitware.VTK.vtkColorTransferFunctionItem"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011745 RID: 71493 RVA: 0x001857CB File Offset: 0x001839CB
		public vtkColorTransferFunctionItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011746 RID: 71494
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkColorTransferFunctionItem_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06011747 RID: 71495 RVA: 0x001857DC File Offset: 0x001839DC
		public new static vtkColorTransferFunctionItem New()
		{
			vtkColorTransferFunctionItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkColorTransferFunctionItem.vtkColorTransferFunctionItem_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkColorTransferFunctionItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011748 RID: 71496 RVA: 0x00185830 File Offset: 0x00183A30
		public vtkColorTransferFunctionItem() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkColorTransferFunctionItem.vtkColorTransferFunctionItem_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011749 RID: 71497 RVA: 0x00185874 File Offset: 0x00183A74
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601174A RID: 71498
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkColorTransferFunctionItem_GetColorTransferFunction_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601174B RID: 71499 RVA: 0x00185880 File Offset: 0x00183A80
		public virtual vtkColorTransferFunction GetColorTransferFunction()
		{
			vtkColorTransferFunction vtkColorTransferFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkColorTransferFunctionItem.vtkColorTransferFunctionItem_GetColorTransferFunction_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkColorTransferFunction = (vtkColorTransferFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkColorTransferFunction.Register(null);
				}
			}
			return vtkColorTransferFunction;
		}

		// Token: 0x0601174C RID: 71500
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkColorTransferFunctionItem_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601174D RID: 71501 RVA: 0x001858F0 File Offset: 0x00183AF0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkColorTransferFunctionItem.vtkColorTransferFunctionItem_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601174E RID: 71502
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkColorTransferFunctionItem_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601174F RID: 71503 RVA: 0x00185910 File Offset: 0x00183B10
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkColorTransferFunctionItem.vtkColorTransferFunctionItem_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06011750 RID: 71504
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkColorTransferFunctionItem_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x06011751 RID: 71505 RVA: 0x0018592C File Offset: 0x00183B2C
		public override int IsA(string type)
		{
			return vtkColorTransferFunctionItem.vtkColorTransferFunctionItem_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06011752 RID: 71506
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkColorTransferFunctionItem_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x06011753 RID: 71507 RVA: 0x0018594C File Offset: 0x00183B4C
		public new static int IsTypeOf(string type)
		{
			return vtkColorTransferFunctionItem.vtkColorTransferFunctionItem_IsTypeOf_05(type);
		}

		// Token: 0x06011754 RID: 71508
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkColorTransferFunctionItem_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06011755 RID: 71509 RVA: 0x00185968 File Offset: 0x00183B68
		public new vtkColorTransferFunctionItem NewInstance()
		{
			vtkColorTransferFunctionItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkColorTransferFunctionItem.vtkColorTransferFunctionItem_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkColorTransferFunctionItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011756 RID: 71510
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkColorTransferFunctionItem_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06011757 RID: 71511 RVA: 0x001859C4 File Offset: 0x00183BC4
		public new static vtkColorTransferFunctionItem SafeDownCast(vtkObjectBase o)
		{
			vtkColorTransferFunctionItem vtkColorTransferFunctionItem = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkColorTransferFunctionItem.vtkColorTransferFunctionItem_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkColorTransferFunctionItem = (vtkColorTransferFunctionItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkColorTransferFunctionItem.Register(null);
				}
			}
			return vtkColorTransferFunctionItem;
		}

		// Token: 0x06011758 RID: 71512
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorTransferFunctionItem_SetColorTransferFunction_09(HandleRef pThis, HandleRef t);

		// Token: 0x06011759 RID: 71513 RVA: 0x00185A44 File Offset: 0x00183C44
		public void SetColorTransferFunction(vtkColorTransferFunction t)
		{
			vtkColorTransferFunctionItem.vtkColorTransferFunctionItem_SetColorTransferFunction_09(base.GetCppThis(), (t == null) ? default(HandleRef) : t.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400141F RID: 5151
		public new const string MRFullTypeName = "Kitware.VTK.vtkColorTransferFunctionItem";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001420 RID: 5152
		public new static readonly string MRClassNameKey = "class vtkColorTransferFunctionItem";
	}
}
