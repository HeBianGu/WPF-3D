using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x0200064D RID: 1613
	public class vtkCompositeTransferFunctionItem : vtkColorTransferFunctionItem
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011784 RID: 71556 RVA: 0x00185E67 File Offset: 0x00184067
		static vtkCompositeTransferFunctionItem()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCompositeTransferFunctionItem.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCompositeTransferFunctionItem"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011785 RID: 71557 RVA: 0x00185E8F File Offset: 0x0018408F
		public vtkCompositeTransferFunctionItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011786 RID: 71558
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeTransferFunctionItem_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06011787 RID: 71559 RVA: 0x00185EA0 File Offset: 0x001840A0
		public new static vtkCompositeTransferFunctionItem New()
		{
			vtkCompositeTransferFunctionItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeTransferFunctionItem.vtkCompositeTransferFunctionItem_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositeTransferFunctionItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011788 RID: 71560 RVA: 0x00185EF4 File Offset: 0x001840F4
		public vtkCompositeTransferFunctionItem() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCompositeTransferFunctionItem.vtkCompositeTransferFunctionItem_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011789 RID: 71561 RVA: 0x00185F38 File Offset: 0x00184138
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601178A RID: 71562
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompositeTransferFunctionItem_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601178B RID: 71563 RVA: 0x00185F44 File Offset: 0x00184144
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCompositeTransferFunctionItem.vtkCompositeTransferFunctionItem_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601178C RID: 71564
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompositeTransferFunctionItem_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601178D RID: 71565 RVA: 0x00185F64 File Offset: 0x00184164
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCompositeTransferFunctionItem.vtkCompositeTransferFunctionItem_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601178E RID: 71566
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeTransferFunctionItem_GetOpacityFunction_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601178F RID: 71567 RVA: 0x00185F80 File Offset: 0x00184180
		public virtual vtkPiecewiseFunction GetOpacityFunction()
		{
			vtkPiecewiseFunction vtkPiecewiseFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeTransferFunctionItem.vtkCompositeTransferFunctionItem_GetOpacityFunction_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06011790 RID: 71568
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeTransferFunctionItem_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x06011791 RID: 71569 RVA: 0x00185FF0 File Offset: 0x001841F0
		public override int IsA(string type)
		{
			return vtkCompositeTransferFunctionItem.vtkCompositeTransferFunctionItem_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06011792 RID: 71570
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeTransferFunctionItem_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x06011793 RID: 71571 RVA: 0x00186010 File Offset: 0x00184210
		public new static int IsTypeOf(string type)
		{
			return vtkCompositeTransferFunctionItem.vtkCompositeTransferFunctionItem_IsTypeOf_05(type);
		}

		// Token: 0x06011794 RID: 71572
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeTransferFunctionItem_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06011795 RID: 71573 RVA: 0x0018602C File Offset: 0x0018422C
		public new vtkCompositeTransferFunctionItem NewInstance()
		{
			vtkCompositeTransferFunctionItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeTransferFunctionItem.vtkCompositeTransferFunctionItem_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositeTransferFunctionItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011796 RID: 71574
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeTransferFunctionItem_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06011797 RID: 71575 RVA: 0x00186088 File Offset: 0x00184288
		public new static vtkCompositeTransferFunctionItem SafeDownCast(vtkObjectBase o)
		{
			vtkCompositeTransferFunctionItem vtkCompositeTransferFunctionItem = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeTransferFunctionItem.vtkCompositeTransferFunctionItem_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositeTransferFunctionItem = (vtkCompositeTransferFunctionItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositeTransferFunctionItem.Register(null);
				}
			}
			return vtkCompositeTransferFunctionItem;
		}

		// Token: 0x06011798 RID: 71576
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeTransferFunctionItem_SetOpacityFunction_09(HandleRef pThis, HandleRef opacity);

		// Token: 0x06011799 RID: 71577 RVA: 0x00186108 File Offset: 0x00184308
		public void SetOpacityFunction(vtkPiecewiseFunction opacity)
		{
			vtkCompositeTransferFunctionItem.vtkCompositeTransferFunctionItem_SetOpacityFunction_09(base.GetCppThis(), (opacity == null) ? default(HandleRef) : opacity.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001427 RID: 5159
		public new const string MRFullTypeName = "Kitware.VTK.vtkCompositeTransferFunctionItem";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001428 RID: 5160
		public new static readonly string MRClassNameKey = "class vtkCompositeTransferFunctionItem";
	}
}
