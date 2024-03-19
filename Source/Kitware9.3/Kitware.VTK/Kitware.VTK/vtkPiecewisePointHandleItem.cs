using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPiecewisePointHandleItem
	/// </summary>
	/// <remarks>
	///    a vtkContextItem that draws handles
	///       around a point of a piecewise function
	///
	///
	/// This is a vtkContextItem that can be placed into a vtkContextScene. It draws
	/// handles around a given point of a piecewise function so that the curve can
	/// be adjusted using these handles.
	/// </remarks>
	// Token: 0x02000654 RID: 1620
	public class vtkPiecewisePointHandleItem : vtkContextItem
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601183A RID: 71738 RVA: 0x001872C7 File Offset: 0x001854C7
		static vtkPiecewisePointHandleItem()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPiecewisePointHandleItem.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPiecewisePointHandleItem"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601183B RID: 71739 RVA: 0x001872EF File Offset: 0x001854EF
		public vtkPiecewisePointHandleItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601183C RID: 71740
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPiecewisePointHandleItem_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601183D RID: 71741 RVA: 0x00187300 File Offset: 0x00185500
		public new static vtkPiecewisePointHandleItem New()
		{
			vtkPiecewisePointHandleItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPiecewisePointHandleItem.vtkPiecewisePointHandleItem_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPiecewisePointHandleItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601183E RID: 71742 RVA: 0x00187354 File Offset: 0x00185554
		public vtkPiecewisePointHandleItem() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPiecewisePointHandleItem.vtkPiecewisePointHandleItem_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601183F RID: 71743 RVA: 0x00187398 File Offset: 0x00185598
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011840 RID: 71744
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPiecewisePointHandleItem_CallRedraw_01(HandleRef sender, uint arg1, IntPtr receiver, IntPtr arg3);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011841 RID: 71745 RVA: 0x001873A4 File Offset: 0x001855A4
		public static void CallRedraw(vtkObject sender, uint arg1, IntPtr receiver, IntPtr arg3)
		{
			vtkPiecewisePointHandleItem.vtkPiecewisePointHandleItem_CallRedraw_01((sender == null) ? default(HandleRef) : sender.GetCppThis(), arg1, receiver, arg3);
		}

		// Token: 0x06011842 RID: 71746
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPiecewisePointHandleItem_GetCurrentPointIndex_02(HandleRef pThis);

		/// <summary>
		/// The current point id in the piecewise function being handled.
		/// </summary>
		// Token: 0x06011843 RID: 71747 RVA: 0x001873D0 File Offset: 0x001855D0
		public virtual long GetCurrentPointIndex()
		{
			return vtkPiecewisePointHandleItem.vtkPiecewisePointHandleItem_GetCurrentPointIndex_02(base.GetCppThis());
		}

		// Token: 0x06011844 RID: 71748
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPiecewisePointHandleItem_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011845 RID: 71749 RVA: 0x001873F0 File Offset: 0x001855F0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPiecewisePointHandleItem.vtkPiecewisePointHandleItem_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06011846 RID: 71750
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPiecewisePointHandleItem_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011847 RID: 71751 RVA: 0x00187410 File Offset: 0x00185610
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPiecewisePointHandleItem.vtkPiecewisePointHandleItem_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06011848 RID: 71752
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPiecewisePointHandleItem_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011849 RID: 71753 RVA: 0x0018742C File Offset: 0x0018562C
		public override int IsA(string type)
		{
			return vtkPiecewisePointHandleItem.vtkPiecewisePointHandleItem_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0601184A RID: 71754
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPiecewisePointHandleItem_IsOverHandle_06(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Returns the index of the handle if pos is over any of the handles,
		/// otherwise return -1;
		/// </summary>
		// Token: 0x0601184B RID: 71755 RVA: 0x0018744C File Offset: 0x0018564C
		public int IsOverHandle(IntPtr pos)
		{
			return vtkPiecewisePointHandleItem.vtkPiecewisePointHandleItem_IsOverHandle_06(base.GetCppThis(), pos);
		}

		// Token: 0x0601184C RID: 71756
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPiecewisePointHandleItem_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601184D RID: 71757 RVA: 0x0018746C File Offset: 0x0018566C
		public new static int IsTypeOf(string type)
		{
			return vtkPiecewisePointHandleItem.vtkPiecewisePointHandleItem_IsTypeOf_07(type);
		}

		// Token: 0x0601184E RID: 71758
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPiecewisePointHandleItem_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601184F RID: 71759 RVA: 0x00187488 File Offset: 0x00185688
		public new vtkPiecewisePointHandleItem NewInstance()
		{
			vtkPiecewisePointHandleItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPiecewisePointHandleItem.vtkPiecewisePointHandleItem_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPiecewisePointHandleItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011850 RID: 71760
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPiecewisePointHandleItem_Paint_10(HandleRef pThis, HandleRef painter);

		/// <summary>
		/// Paint event for the item.
		/// </summary>
		// Token: 0x06011851 RID: 71761 RVA: 0x001874E4 File Offset: 0x001856E4
		public override bool Paint(vtkContext2D painter)
		{
			return vtkPiecewisePointHandleItem.vtkPiecewisePointHandleItem_Paint_10(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		// Token: 0x06011852 RID: 71762
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPiecewisePointHandleItem_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011853 RID: 71763 RVA: 0x00187520 File Offset: 0x00185720
		public new static vtkPiecewisePointHandleItem SafeDownCast(vtkObjectBase o)
		{
			vtkPiecewisePointHandleItem vtkPiecewisePointHandleItem = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPiecewisePointHandleItem.vtkPiecewisePointHandleItem_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPiecewisePointHandleItem = (vtkPiecewisePointHandleItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPiecewisePointHandleItem.Register(null);
				}
			}
			return vtkPiecewisePointHandleItem;
		}

		// Token: 0x06011854 RID: 71764
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPiecewisePointHandleItem_SetCurrentPointIndex_12(HandleRef pThis, long _arg);

		/// <summary>
		/// The current point id in the piecewise function being handled.
		/// </summary>
		// Token: 0x06011855 RID: 71765 RVA: 0x0018759F File Offset: 0x0018579F
		public virtual void SetCurrentPointIndex(long _arg)
		{
			vtkPiecewisePointHandleItem.vtkPiecewisePointHandleItem_SetCurrentPointIndex_12(base.GetCppThis(), _arg);
		}

		// Token: 0x06011856 RID: 71766
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPiecewisePointHandleItem_SetParent_13(HandleRef pThis, HandleRef parent);

		/// <summary>
		/// Set the parent item, which should be a vtkControlPointItem
		/// </summary>
		// Token: 0x06011857 RID: 71767 RVA: 0x001875B0 File Offset: 0x001857B0
		public override void SetParent(vtkAbstractContextItem parent)
		{
			vtkPiecewisePointHandleItem.vtkPiecewisePointHandleItem_SetParent_13(base.GetCppThis(), (parent == null) ? default(HandleRef) : parent.GetCppThis());
		}

		// Token: 0x06011858 RID: 71768
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPiecewisePointHandleItem_SetPiecewiseFunction_14(HandleRef pThis, HandleRef piecewiseFunc);

		/// <summary>
		/// Set the PieceWiseFunction the handles will manipulate
		/// </summary>
		// Token: 0x06011859 RID: 71769 RVA: 0x001875E0 File Offset: 0x001857E0
		public virtual void SetPiecewiseFunction(vtkPiecewiseFunction piecewiseFunc)
		{
			vtkPiecewisePointHandleItem.vtkPiecewisePointHandleItem_SetPiecewiseFunction_14(base.GetCppThis(), (piecewiseFunc == null) ? default(HandleRef) : piecewiseFunc.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001438 RID: 5176
		public new const string MRFullTypeName = "Kitware.VTK.vtkPiecewisePointHandleItem";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001439 RID: 5177
		public new static readonly string MRClassNameKey = "class vtkPiecewisePointHandleItem";
	}
}
