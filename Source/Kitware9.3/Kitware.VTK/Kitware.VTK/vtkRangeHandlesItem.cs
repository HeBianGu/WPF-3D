using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRangeHandlesItem
	/// </summary>
	/// <remarks>
	///    item to show and control the range of a vtkColorTransferFunction
	///
	/// vtkRangeHandlesItem provides range handles painting and management
	/// for a provided vtkColorTransferFunction.
	/// This specialization of vtkPlotRangeHandlesItem works in coordination with
	/// the color transfer function to drive the behavior of handles.
	/// Handles can only be dragged within the color transfer function range and
	/// are forced to be placed vertically with a fixed height of 1.
	///
	/// A typical use case for this class is to observe EndInteractionEvent to
	/// update the color transfer function range using the handles range.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkControlPointsItem
	/// vtkScalarsToColorsItem
	/// vtkColorTransferFunctionItem
	/// </seealso>
	// Token: 0x0200066B RID: 1643
	public class vtkRangeHandlesItem : vtkPlotRangeHandlesItem
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011B8F RID: 72591 RVA: 0x0018C84D File Offset: 0x0018AA4D
		static vtkRangeHandlesItem()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRangeHandlesItem.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRangeHandlesItem"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011B90 RID: 72592 RVA: 0x0018C875 File Offset: 0x0018AA75
		public vtkRangeHandlesItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011B91 RID: 72593
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRangeHandlesItem_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011B92 RID: 72594 RVA: 0x0018C884 File Offset: 0x0018AA84
		public new static vtkRangeHandlesItem New()
		{
			vtkRangeHandlesItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRangeHandlesItem.vtkRangeHandlesItem_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRangeHandlesItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011B93 RID: 72595 RVA: 0x0018C8D8 File Offset: 0x0018AAD8
		public vtkRangeHandlesItem() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRangeHandlesItem.vtkRangeHandlesItem_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011B94 RID: 72596 RVA: 0x0018C91C File Offset: 0x0018AB1C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011B95 RID: 72597
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRangeHandlesItem_ComputeHandlesDrawRange_01(HandleRef pThis);

		/// <summary>
		/// Compute the handles draw range by using the handle width and the transfer
		/// function.
		/// </summary>
		// Token: 0x06011B96 RID: 72598 RVA: 0x0018C927 File Offset: 0x0018AB27
		public override void ComputeHandlesDrawRange()
		{
			vtkRangeHandlesItem.vtkRangeHandlesItem_ComputeHandlesDrawRange_01(base.GetCppThis());
		}

		// Token: 0x06011B97 RID: 72599
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRangeHandlesItem_GetBounds_02(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Overridden to get the bounds from the color transfer function range.
		/// </summary>
		// Token: 0x06011B98 RID: 72600 RVA: 0x0018C936 File Offset: 0x0018AB36
		public override void GetBounds(IntPtr bounds)
		{
			vtkRangeHandlesItem.vtkRangeHandlesItem_GetBounds_02(base.GetCppThis(), bounds);
		}

		// Token: 0x06011B99 RID: 72601
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRangeHandlesItem_GetColorTransferFunction_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/set the color transfer function to interact with.
		/// </summary>
		// Token: 0x06011B9A RID: 72602 RVA: 0x0018C948 File Offset: 0x0018AB48
		public virtual vtkColorTransferFunction GetColorTransferFunction()
		{
			vtkColorTransferFunction vtkColorTransferFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRangeHandlesItem.vtkRangeHandlesItem_GetColorTransferFunction_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06011B9B RID: 72603
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRangeHandlesItem_GetHandlesRange_04(HandleRef pThis, IntPtr range);

		/// <summary>
		/// Overridden to return the range of the color transfer function.
		/// Use this method by observing EndInteractionEvent
		/// </summary>
		// Token: 0x06011B9C RID: 72604 RVA: 0x0018C9B7 File Offset: 0x0018ABB7
		public override void GetHandlesRange(IntPtr range)
		{
			vtkRangeHandlesItem.vtkRangeHandlesItem_GetHandlesRange_04(base.GetCppThis(), range);
		}

		// Token: 0x06011B9D RID: 72605
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRangeHandlesItem_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011B9E RID: 72606 RVA: 0x0018C9C8 File Offset: 0x0018ABC8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRangeHandlesItem.vtkRangeHandlesItem_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06011B9F RID: 72607
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRangeHandlesItem_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011BA0 RID: 72608 RVA: 0x0018C9E8 File Offset: 0x0018ABE8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRangeHandlesItem.vtkRangeHandlesItem_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06011BA1 RID: 72609
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRangeHandlesItem_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011BA2 RID: 72610 RVA: 0x0018CA04 File Offset: 0x0018AC04
		public override int IsA(string type)
		{
			return vtkRangeHandlesItem.vtkRangeHandlesItem_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06011BA3 RID: 72611
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRangeHandlesItem_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011BA4 RID: 72612 RVA: 0x0018CA24 File Offset: 0x0018AC24
		public new static int IsTypeOf(string type)
		{
			return vtkRangeHandlesItem.vtkRangeHandlesItem_IsTypeOf_08(type);
		}

		// Token: 0x06011BA5 RID: 72613
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRangeHandlesItem_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011BA6 RID: 72614 RVA: 0x0018CA40 File Offset: 0x0018AC40
		public new vtkRangeHandlesItem NewInstance()
		{
			vtkRangeHandlesItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRangeHandlesItem.vtkRangeHandlesItem_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRangeHandlesItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011BA7 RID: 72615
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRangeHandlesItem_Paint_11(HandleRef pThis, HandleRef painter);

		/// <summary>
		/// Overridden to check that a color transfer function has been set before
		/// painting.
		/// </summary>
		// Token: 0x06011BA8 RID: 72616 RVA: 0x0018CA9C File Offset: 0x0018AC9C
		public override bool Paint(vtkContext2D painter)
		{
			return vtkRangeHandlesItem.vtkRangeHandlesItem_Paint_11(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		// Token: 0x06011BA9 RID: 72617
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRangeHandlesItem_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011BAA RID: 72618 RVA: 0x0018CAD8 File Offset: 0x0018ACD8
		public new static vtkRangeHandlesItem SafeDownCast(vtkObjectBase o)
		{
			vtkRangeHandlesItem vtkRangeHandlesItem = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRangeHandlesItem.vtkRangeHandlesItem_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRangeHandlesItem = (vtkRangeHandlesItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRangeHandlesItem.Register(null);
				}
			}
			return vtkRangeHandlesItem;
		}

		// Token: 0x06011BAB RID: 72619
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRangeHandlesItem_SetColorTransferFunction_13(HandleRef pThis, HandleRef ctf);

		/// <summary>
		/// Get/set the color transfer function to interact with.
		/// </summary>
		// Token: 0x06011BAC RID: 72620 RVA: 0x0018CB58 File Offset: 0x0018AD58
		public void SetColorTransferFunction(vtkColorTransferFunction ctf)
		{
			vtkRangeHandlesItem.vtkRangeHandlesItem_SetColorTransferFunction_13(base.GetCppThis(), (ctf == null) ? default(HandleRef) : ctf.GetCppThis());
		}

		// Token: 0x06011BAD RID: 72621
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRangeHandlesItem_SetHandleOrientation_14(HandleRef pThis, int arg0);

		/// <summary>
		/// Overridden to force using desynchronized vertical handles.
		/// Desynchronized handles means that handles are always moved independently,
		/// as opposed to synchronized handles where the left handle drives the
		/// modification of the whole range. See superclass for more information.
		/// </summary>
		// Token: 0x06011BAE RID: 72622 RVA: 0x0018CB87 File Offset: 0x0018AD87
		public override void SetHandleOrientation(int arg0)
		{
			vtkRangeHandlesItem.vtkRangeHandlesItem_SetHandleOrientation_14(base.GetCppThis(), arg0);
		}

		// Token: 0x06011BAF RID: 72623
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRangeHandlesItem_SetSynchronizeRangeHandles_15(HandleRef pThis, int arg0);

		/// <summary>
		/// Overridden to force using desynchronized vertical handles.
		/// Desynchronized handles means that handles are always moved independently,
		/// as opposed to synchronized handles where the left handle drives the
		/// modification of the whole range. See superclass for more information.
		/// </summary>
		// Token: 0x06011BB0 RID: 72624 RVA: 0x0018CB97 File Offset: 0x0018AD97
		public override void SetSynchronizeRangeHandles(int arg0)
		{
			vtkRangeHandlesItem.vtkRangeHandlesItem_SetSynchronizeRangeHandles_15(base.GetCppThis(), arg0);
		}

		// Token: 0x06011BB1 RID: 72625
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRangeHandlesItem_SynchronizeRangeHandlesOn_16(HandleRef pThis);

		/// <summary>
		/// Overridden to force using desynchronized vertical handles.
		/// Desynchronized handles means that handles are always moved independently,
		/// as opposed to synchronized handles where the left handle drives the
		/// modification of the whole range. See superclass for more information.
		/// </summary>
		// Token: 0x06011BB2 RID: 72626 RVA: 0x0018CBA7 File Offset: 0x0018ADA7
		public override void SynchronizeRangeHandlesOn()
		{
			vtkRangeHandlesItem.vtkRangeHandlesItem_SynchronizeRangeHandlesOn_16(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400146F RID: 5231
		public new const string MRFullTypeName = "Kitware.VTK.vtkRangeHandlesItem";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001470 RID: 5232
		public new static readonly string MRClassNameKey = "class vtkRangeHandlesItem";
	}
}
