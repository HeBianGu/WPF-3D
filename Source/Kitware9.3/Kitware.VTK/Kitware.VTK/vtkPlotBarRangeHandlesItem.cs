using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPlotBarRangeHandlesItem
	/// </summary>
	/// <remarks>
	///    show and control the range of a vtkAxis used with a vtkPlotBar
	///
	/// This class is a vtkPlotRangeHandlesItem specialization working in
	/// coordination with a vtkPlotBar. It ensures that handles are sticking to the
	/// plot bars when being dragged.
	/// Vertical and horizontal bars are both supported but the handles orientation
	/// must match the vtkPlotBar orientation.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPlotRangeHandlesItem
	/// </seealso>
	// Token: 0x0200065F RID: 1631
	public class vtkPlotBarRangeHandlesItem : vtkPlotRangeHandlesItem
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060119D7 RID: 72151 RVA: 0x0018989F File Offset: 0x00187A9F
		static vtkPlotBarRangeHandlesItem()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPlotBarRangeHandlesItem.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlotBarRangeHandlesItem"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060119D8 RID: 72152 RVA: 0x001898C7 File Offset: 0x00187AC7
		public vtkPlotBarRangeHandlesItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060119D9 RID: 72153
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotBarRangeHandlesItem_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060119DA RID: 72154 RVA: 0x001898D8 File Offset: 0x00187AD8
		public new static vtkPlotBarRangeHandlesItem New()
		{
			vtkPlotBarRangeHandlesItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotBarRangeHandlesItem.vtkPlotBarRangeHandlesItem_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlotBarRangeHandlesItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060119DB RID: 72155 RVA: 0x0018992C File Offset: 0x00187B2C
		public vtkPlotBarRangeHandlesItem() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPlotBarRangeHandlesItem.vtkPlotBarRangeHandlesItem_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060119DC RID: 72156 RVA: 0x00189970 File Offset: 0x00187B70
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060119DD RID: 72157
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotBarRangeHandlesItem_GetBounds_01(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Recover the bounds of the item
		/// </summary>
		// Token: 0x060119DE RID: 72158 RVA: 0x0018997B File Offset: 0x00187B7B
		public override void GetBounds(IntPtr bounds)
		{
			vtkPlotBarRangeHandlesItem.vtkPlotBarRangeHandlesItem_GetBounds_01(base.GetCppThis(), bounds);
		}

		// Token: 0x060119DF RID: 72159
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlotBarRangeHandlesItem_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060119E0 RID: 72160 RVA: 0x0018998C File Offset: 0x00187B8C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPlotBarRangeHandlesItem.vtkPlotBarRangeHandlesItem_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060119E1 RID: 72161
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlotBarRangeHandlesItem_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060119E2 RID: 72162 RVA: 0x001899AC File Offset: 0x00187BAC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPlotBarRangeHandlesItem.vtkPlotBarRangeHandlesItem_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x060119E3 RID: 72163
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotBarRangeHandlesItem_GetPlotBar_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the plot bar object to work with.
		/// </summary>
		// Token: 0x060119E4 RID: 72164 RVA: 0x001899C8 File Offset: 0x00187BC8
		public virtual vtkPlotBar GetPlotBar()
		{
			vtkPlotBar vtkPlotBar = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotBarRangeHandlesItem.vtkPlotBarRangeHandlesItem_GetPlotBar_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlotBar = (vtkPlotBar)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlotBar.Register(null);
				}
			}
			return vtkPlotBar;
		}

		// Token: 0x060119E5 RID: 72165
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlotBarRangeHandlesItem_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060119E6 RID: 72166 RVA: 0x00189A38 File Offset: 0x00187C38
		public override int IsA(string type)
		{
			return vtkPlotBarRangeHandlesItem.vtkPlotBarRangeHandlesItem_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x060119E7 RID: 72167
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlotBarRangeHandlesItem_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060119E8 RID: 72168 RVA: 0x00189A58 File Offset: 0x00187C58
		public new static int IsTypeOf(string type)
		{
			return vtkPlotBarRangeHandlesItem.vtkPlotBarRangeHandlesItem_IsTypeOf_06(type);
		}

		// Token: 0x060119E9 RID: 72169
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotBarRangeHandlesItem_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060119EA RID: 72170 RVA: 0x00189A74 File Offset: 0x00187C74
		public new vtkPlotBarRangeHandlesItem NewInstance()
		{
			vtkPlotBarRangeHandlesItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotBarRangeHandlesItem.vtkPlotBarRangeHandlesItem_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlotBarRangeHandlesItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060119EB RID: 72171
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotBarRangeHandlesItem_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060119EC RID: 72172 RVA: 0x00189AD0 File Offset: 0x00187CD0
		public new static vtkPlotBarRangeHandlesItem SafeDownCast(vtkObjectBase o)
		{
			vtkPlotBarRangeHandlesItem vtkPlotBarRangeHandlesItem = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotBarRangeHandlesItem.vtkPlotBarRangeHandlesItem_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlotBarRangeHandlesItem = (vtkPlotBarRangeHandlesItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlotBarRangeHandlesItem.Register(null);
				}
			}
			return vtkPlotBarRangeHandlesItem;
		}

		// Token: 0x060119ED RID: 72173
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotBarRangeHandlesItem_SetPlotBar_10(HandleRef pThis, HandleRef _arg);

		/// <summary>
		/// Get/Set the plot bar object to work with.
		/// </summary>
		// Token: 0x060119EE RID: 72174 RVA: 0x00189B50 File Offset: 0x00187D50
		public virtual void SetPlotBar(vtkPlotBar _arg)
		{
			vtkPlotBarRangeHandlesItem.vtkPlotBarRangeHandlesItem_SetPlotBar_10(base.GetCppThis(), (_arg == null) ? default(HandleRef) : _arg.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001457 RID: 5207
		public new const string MRFullTypeName = "Kitware.VTK.vtkPlotBarRangeHandlesItem";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001458 RID: 5208
		public new static readonly string MRClassNameKey = "class vtkPlotBarRangeHandlesItem";
	}
}
