using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPlotRangeHandlesItem
	/// </summary>
	/// <remarks>
	///    item to show and control a range on vtkAxis
	///
	/// vtkPlotRangeHandlesItem provides range handles painting and management
	/// for a provided extent.
	/// Handles can be moved by clicking on them.
	/// The range is shown when hovering or moving the handles.
	/// It emits a StartInteractionEvent when starting to interact with a handle,
	/// an InteractionEvent when interacting with a handle and an EndInteractionEvent
	/// when releasing a handle.
	/// It emits a LeftMouseButtonDoubleClickEvent when double clicked.
	/// Options can be used to change the appearance or behavior of handles:
	/// - SynchronizeHandlesRange: When enabled, moving the minimum handle triggers
	/// the modification of the whole range, resulting in the maximum handle being
	/// moved too. Disabled by default.
	/// - Orientation: Choose between horizontal (Y axis) or vertical (X axis)
	/// handles. Default is vertical.
	/// - ExtentToAxis: When enabled, the height of handles span the range of the
	/// opposite axis. If disabled, the height of handles is defined by the provided
	/// extent. Enabled by default.
	/// </remarks>
	// Token: 0x0200065C RID: 1628
	public class vtkPlotRangeHandlesItem : vtkPlot
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011989 RID: 72073 RVA: 0x00189362 File Offset: 0x00187562
		static vtkPlotRangeHandlesItem()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPlotRangeHandlesItem.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlotRangeHandlesItem"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601198A RID: 72074 RVA: 0x0018938A File Offset: 0x0018758A
		public vtkPlotRangeHandlesItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601198B RID: 72075
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotRangeHandlesItem_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601198C RID: 72076 RVA: 0x00189398 File Offset: 0x00187598
		public new static vtkPlotRangeHandlesItem New()
		{
			vtkPlotRangeHandlesItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotRangeHandlesItem.vtkPlotRangeHandlesItem_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlotRangeHandlesItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601198D RID: 72077 RVA: 0x001893EC File Offset: 0x001875EC
		public vtkPlotRangeHandlesItem() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPlotRangeHandlesItem.vtkPlotRangeHandlesItem_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601198E RID: 72078 RVA: 0x00189430 File Offset: 0x00187630
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601198F RID: 72079
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotRangeHandlesItem_ComputeHandlesDrawRange_01(HandleRef pThis);

		/// <summary>
		/// Compute the handles draw range by using the handle width and the transfer function
		/// </summary>
		// Token: 0x06011990 RID: 72080 RVA: 0x0018943B File Offset: 0x0018763B
		public virtual void ComputeHandlesDrawRange()
		{
			vtkPlotRangeHandlesItem.vtkPlotRangeHandlesItem_ComputeHandlesDrawRange_01(base.GetCppThis());
		}

		// Token: 0x06011991 RID: 72081
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotRangeHandlesItem_ExtentToAxisRangeOff_02(HandleRef pThis);

		/// <summary>
		/// Set/Get whether handles span the range of the axis. Default is On.
		/// </summary>
		// Token: 0x06011992 RID: 72082 RVA: 0x0018944A File Offset: 0x0018764A
		public virtual void ExtentToAxisRangeOff()
		{
			vtkPlotRangeHandlesItem.vtkPlotRangeHandlesItem_ExtentToAxisRangeOff_02(base.GetCppThis());
		}

		// Token: 0x06011993 RID: 72083
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotRangeHandlesItem_ExtentToAxisRangeOn_03(HandleRef pThis);

		/// <summary>
		/// Set/Get whether handles span the range of the axis. Default is On.
		/// </summary>
		// Token: 0x06011994 RID: 72084 RVA: 0x00189459 File Offset: 0x00187659
		public virtual void ExtentToAxisRangeOn()
		{
			vtkPlotRangeHandlesItem.vtkPlotRangeHandlesItem_ExtentToAxisRangeOn_03(base.GetCppThis());
		}

		// Token: 0x06011995 RID: 72085
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotRangeHandlesItem_GetBounds_04(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Recover the bounds of the item
		/// </summary>
		// Token: 0x06011996 RID: 72086 RVA: 0x00189468 File Offset: 0x00187668
		public override void GetBounds(IntPtr bounds)
		{
			vtkPlotRangeHandlesItem.vtkPlotRangeHandlesItem_GetBounds_04(base.GetCppThis(), bounds);
		}

		// Token: 0x06011997 RID: 72087
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotRangeHandlesItem_GetExtent_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the extent of the handles in data space (axis unscaled range).
		/// The first two parameters define the left and right handles positions on
		/// the axis. The last two parameters define the length of handles along the
		/// opposite axis. Default values are set to (0, 1, 0, 1).
		/// When using ExtentToAxisRangeOn(), the last two parameters don't have any
		/// effect and handles span the axis range.
		/// </summary>
		// Token: 0x06011998 RID: 72088 RVA: 0x00189478 File Offset: 0x00187678
		public virtual double[] GetExtent()
		{
			IntPtr intPtr = vtkPlotRangeHandlesItem.vtkPlotRangeHandlesItem_GetExtent_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06011999 RID: 72089
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotRangeHandlesItem_GetExtent_06(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

		/// <summary>
		/// Set/Get the extent of the handles in data space (axis unscaled range).
		/// The first two parameters define the left and right handles positions on
		/// the axis. The last two parameters define the length of handles along the
		/// opposite axis. Default values are set to (0, 1, 0, 1).
		/// When using ExtentToAxisRangeOn(), the last two parameters don't have any
		/// effect and handles span the axis range.
		/// </summary>
		// Token: 0x0601199A RID: 72090 RVA: 0x001894C0 File Offset: 0x001876C0
		public virtual void GetExtent(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
		{
			vtkPlotRangeHandlesItem.vtkPlotRangeHandlesItem_GetExtent_06(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		// Token: 0x0601199B RID: 72091
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotRangeHandlesItem_GetExtent_07(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the extent of the handles in data space (axis unscaled range).
		/// The first two parameters define the left and right handles positions on
		/// the axis. The last two parameters define the length of handles along the
		/// opposite axis. Default values are set to (0, 1, 0, 1).
		/// When using ExtentToAxisRangeOn(), the last two parameters don't have any
		/// effect and handles span the axis range.
		/// </summary>
		// Token: 0x0601199C RID: 72092 RVA: 0x001894D4 File Offset: 0x001876D4
		public virtual void GetExtent(IntPtr _arg)
		{
			vtkPlotRangeHandlesItem.vtkPlotRangeHandlesItem_GetExtent_07(base.GetCppThis(), _arg);
		}

		// Token: 0x0601199D RID: 72093
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlotRangeHandlesItem_GetExtentToAxisRange_08(HandleRef pThis);

		/// <summary>
		/// Set/Get whether handles span the range of the axis. Default is On.
		/// </summary>
		// Token: 0x0601199E RID: 72094 RVA: 0x001894E4 File Offset: 0x001876E4
		public virtual int GetExtentToAxisRange()
		{
			return vtkPlotRangeHandlesItem.vtkPlotRangeHandlesItem_GetExtentToAxisRange_08(base.GetCppThis());
		}

		// Token: 0x0601199F RID: 72095
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlotRangeHandlesItem_GetHandleOrientation_09(HandleRef pThis);

		/// <summary>
		/// Set/Get the handles orientation in the plot.
		/// </summary>
		// Token: 0x060119A0 RID: 72096 RVA: 0x00189504 File Offset: 0x00187704
		public virtual int GetHandleOrientation()
		{
			return vtkPlotRangeHandlesItem.vtkPlotRangeHandlesItem_GetHandleOrientation_09(base.GetCppThis());
		}

		// Token: 0x060119A1 RID: 72097
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlotRangeHandlesItem_GetHandleOrientationMaxValue_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the handles orientation in the plot.
		/// </summary>
		// Token: 0x060119A2 RID: 72098 RVA: 0x00189524 File Offset: 0x00187724
		public virtual int GetHandleOrientationMaxValue()
		{
			return vtkPlotRangeHandlesItem.vtkPlotRangeHandlesItem_GetHandleOrientationMaxValue_10(base.GetCppThis());
		}

		// Token: 0x060119A3 RID: 72099
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlotRangeHandlesItem_GetHandleOrientationMinValue_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the handles orientation in the plot.
		/// </summary>
		// Token: 0x060119A4 RID: 72100 RVA: 0x00189544 File Offset: 0x00187744
		public virtual int GetHandleOrientationMinValue()
		{
			return vtkPlotRangeHandlesItem.vtkPlotRangeHandlesItem_GetHandleOrientationMinValue_11(base.GetCppThis());
		}

		// Token: 0x060119A5 RID: 72101
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkPlotRangeHandlesItem_GetHandleWidth_12(HandleRef pThis);

		/// <summary>
		/// Set/Get the handles width in pixels.
		/// Default is 2.
		/// </summary>
		// Token: 0x060119A6 RID: 72102 RVA: 0x00189564 File Offset: 0x00187764
		public virtual float GetHandleWidth()
		{
			return vtkPlotRangeHandlesItem.vtkPlotRangeHandlesItem_GetHandleWidth_12(base.GetCppThis());
		}

		// Token: 0x060119A7 RID: 72103
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotRangeHandlesItem_GetHandlesRange_13(HandleRef pThis, IntPtr range);

		/// <summary>
		/// Recover the range currently set by the handles
		/// Use this method by observing EndInteractionEvent
		/// </summary>
		// Token: 0x060119A8 RID: 72104 RVA: 0x00189583 File Offset: 0x00187783
		public virtual void GetHandlesRange(IntPtr range)
		{
			vtkPlotRangeHandlesItem.vtkPlotRangeHandlesItem_GetHandlesRange_13(base.GetCppThis(), range);
		}

		// Token: 0x060119A9 RID: 72105
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotRangeHandlesItem_GetHighlightBrush_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the brush used to paint handles being hovered
		/// </summary>
		// Token: 0x060119AA RID: 72106 RVA: 0x00189594 File Offset: 0x00187794
		public virtual vtkBrush GetHighlightBrush()
		{
			vtkBrush vtkBrush = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotRangeHandlesItem.vtkPlotRangeHandlesItem_GetHighlightBrush_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBrush = (vtkBrush)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBrush.Register(null);
				}
			}
			return vtkBrush;
		}

		// Token: 0x060119AB RID: 72107
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlotRangeHandlesItem_GetLockTooltipToMouse_15(HandleRef pThis);

		/// <summary>
		/// If On, the range tooltip is always rendered using mouse position,
		/// otherwise it is placed at the center of the x axis Default is On.
		/// </summary>
		// Token: 0x060119AC RID: 72108 RVA: 0x00189604 File Offset: 0x00187804
		public virtual int GetLockTooltipToMouse()
		{
			return vtkPlotRangeHandlesItem.vtkPlotRangeHandlesItem_GetLockTooltipToMouse_15(base.GetCppThis());
		}

		// Token: 0x060119AD RID: 72109
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlotRangeHandlesItem_GetNumberOfGenerationsFromBase_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060119AE RID: 72110 RVA: 0x00189624 File Offset: 0x00187824
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPlotRangeHandlesItem.vtkPlotRangeHandlesItem_GetNumberOfGenerationsFromBase_16(base.GetCppThis(), type);
		}

		// Token: 0x060119AF RID: 72111
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlotRangeHandlesItem_GetNumberOfGenerationsFromBaseType_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060119B0 RID: 72112 RVA: 0x00189644 File Offset: 0x00187844
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPlotRangeHandlesItem.vtkPlotRangeHandlesItem_GetNumberOfGenerationsFromBaseType_17(type);
		}

		// Token: 0x060119B1 RID: 72113
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlotRangeHandlesItem_GetSynchronizeRangeHandles_18(HandleRef pThis);

		/// <summary>
		/// Set/Get whether handles move together when one of them is update. Default is Off.
		/// </summary>
		// Token: 0x060119B2 RID: 72114 RVA: 0x00189660 File Offset: 0x00187860
		public virtual int GetSynchronizeRangeHandles()
		{
			return vtkPlotRangeHandlesItem.vtkPlotRangeHandlesItem_GetSynchronizeRangeHandles_18(base.GetCppThis());
		}

		// Token: 0x060119B3 RID: 72115
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlotRangeHandlesItem_IsA_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060119B4 RID: 72116 RVA: 0x00189680 File Offset: 0x00187880
		public override int IsA(string type)
		{
			return vtkPlotRangeHandlesItem.vtkPlotRangeHandlesItem_IsA_19(base.GetCppThis(), type);
		}

		// Token: 0x060119B5 RID: 72117
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlotRangeHandlesItem_IsTypeOf_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060119B6 RID: 72118 RVA: 0x001896A0 File Offset: 0x001878A0
		public new static int IsTypeOf(string type)
		{
			return vtkPlotRangeHandlesItem.vtkPlotRangeHandlesItem_IsTypeOf_20(type);
		}

		// Token: 0x060119B7 RID: 72119
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotRangeHandlesItem_LockTooltipToMouseOff_21(HandleRef pThis);

		/// <summary>
		/// If On, the range tooltip is always rendered using mouse position,
		/// otherwise it is placed at the center of the x axis Default is On.
		/// </summary>
		// Token: 0x060119B8 RID: 72120 RVA: 0x001896BA File Offset: 0x001878BA
		public virtual void LockTooltipToMouseOff()
		{
			vtkPlotRangeHandlesItem.vtkPlotRangeHandlesItem_LockTooltipToMouseOff_21(base.GetCppThis());
		}

		// Token: 0x060119B9 RID: 72121
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotRangeHandlesItem_LockTooltipToMouseOn_22(HandleRef pThis);

		/// <summary>
		/// If On, the range tooltip is always rendered using mouse position,
		/// otherwise it is placed at the center of the x axis Default is On.
		/// </summary>
		// Token: 0x060119BA RID: 72122 RVA: 0x001896C9 File Offset: 0x001878C9
		public virtual void LockTooltipToMouseOn()
		{
			vtkPlotRangeHandlesItem.vtkPlotRangeHandlesItem_LockTooltipToMouseOn_22(base.GetCppThis());
		}

		// Token: 0x060119BB RID: 72123
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotRangeHandlesItem_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060119BC RID: 72124 RVA: 0x001896D8 File Offset: 0x001878D8
		public new vtkPlotRangeHandlesItem NewInstance()
		{
			vtkPlotRangeHandlesItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotRangeHandlesItem.vtkPlotRangeHandlesItem_NewInstance_24(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlotRangeHandlesItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060119BD RID: 72125
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlotRangeHandlesItem_Paint_25(HandleRef pThis, HandleRef painter);

		/// <summary>
		/// Paint both handles and the range if
		/// a handle is active or hovered
		/// </summary>
		// Token: 0x060119BE RID: 72126 RVA: 0x00189734 File Offset: 0x00187934
		public override bool Paint(vtkContext2D painter)
		{
			return vtkPlotRangeHandlesItem.vtkPlotRangeHandlesItem_Paint_25(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		// Token: 0x060119BF RID: 72127
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotRangeHandlesItem_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060119C0 RID: 72128 RVA: 0x00189770 File Offset: 0x00187970
		public new static vtkPlotRangeHandlesItem SafeDownCast(vtkObjectBase o)
		{
			vtkPlotRangeHandlesItem vtkPlotRangeHandlesItem = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotRangeHandlesItem.vtkPlotRangeHandlesItem_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlotRangeHandlesItem = (vtkPlotRangeHandlesItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlotRangeHandlesItem.Register(null);
				}
			}
			return vtkPlotRangeHandlesItem;
		}

		// Token: 0x060119C1 RID: 72129
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotRangeHandlesItem_SetExtent_27(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

		/// <summary>
		/// Set/Get the extent of the handles in data space (axis unscaled range).
		/// The first two parameters define the left and right handles positions on
		/// the axis. The last two parameters define the length of handles along the
		/// opposite axis. Default values are set to (0, 1, 0, 1).
		/// When using ExtentToAxisRangeOn(), the last two parameters don't have any
		/// effect and handles span the axis range.
		/// </summary>
		// Token: 0x060119C2 RID: 72130 RVA: 0x001897EF File Offset: 0x001879EF
		public virtual void SetExtent(double _arg1, double _arg2, double _arg3, double _arg4)
		{
			vtkPlotRangeHandlesItem.vtkPlotRangeHandlesItem_SetExtent_27(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		// Token: 0x060119C3 RID: 72131
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotRangeHandlesItem_SetExtent_28(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the extent of the handles in data space (axis unscaled range).
		/// The first two parameters define the left and right handles positions on
		/// the axis. The last two parameters define the length of handles along the
		/// opposite axis. Default values are set to (0, 1, 0, 1).
		/// When using ExtentToAxisRangeOn(), the last two parameters don't have any
		/// effect and handles span the axis range.
		/// </summary>
		// Token: 0x060119C4 RID: 72132 RVA: 0x00189803 File Offset: 0x00187A03
		public virtual void SetExtent(IntPtr _arg)
		{
			vtkPlotRangeHandlesItem.vtkPlotRangeHandlesItem_SetExtent_28(base.GetCppThis(), _arg);
		}

		// Token: 0x060119C5 RID: 72133
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotRangeHandlesItem_SetExtentToAxisRange_29(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get whether handles span the range of the axis. Default is On.
		/// </summary>
		// Token: 0x060119C6 RID: 72134 RVA: 0x00189813 File Offset: 0x00187A13
		public virtual void SetExtentToAxisRange(int _arg)
		{
			vtkPlotRangeHandlesItem.vtkPlotRangeHandlesItem_SetExtentToAxisRange_29(base.GetCppThis(), _arg);
		}

		// Token: 0x060119C7 RID: 72135
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotRangeHandlesItem_SetHandleOrientation_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the handles orientation in the plot.
		/// </summary>
		// Token: 0x060119C8 RID: 72136 RVA: 0x00189823 File Offset: 0x00187A23
		public virtual void SetHandleOrientation(int _arg)
		{
			vtkPlotRangeHandlesItem.vtkPlotRangeHandlesItem_SetHandleOrientation_30(base.GetCppThis(), _arg);
		}

		// Token: 0x060119C9 RID: 72137
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotRangeHandlesItem_SetHandleOrientationToHorizontal_31(HandleRef pThis);

		/// <summary>
		/// Set/Get the handles orientation in the plot.
		/// </summary>
		// Token: 0x060119CA RID: 72138 RVA: 0x00189833 File Offset: 0x00187A33
		public void SetHandleOrientationToHorizontal()
		{
			vtkPlotRangeHandlesItem.vtkPlotRangeHandlesItem_SetHandleOrientationToHorizontal_31(base.GetCppThis());
		}

		// Token: 0x060119CB RID: 72139
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotRangeHandlesItem_SetHandleOrientationToVertical_32(HandleRef pThis);

		/// <summary>
		/// Set/Get the handles orientation in the plot.
		/// </summary>
		// Token: 0x060119CC RID: 72140 RVA: 0x00189842 File Offset: 0x00187A42
		public void SetHandleOrientationToVertical()
		{
			vtkPlotRangeHandlesItem.vtkPlotRangeHandlesItem_SetHandleOrientationToVertical_32(base.GetCppThis());
		}

		// Token: 0x060119CD RID: 72141
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotRangeHandlesItem_SetHandleWidth_33(HandleRef pThis, float _arg);

		/// <summary>
		/// Set/Get the handles width in pixels.
		/// Default is 2.
		/// </summary>
		// Token: 0x060119CE RID: 72142 RVA: 0x00189851 File Offset: 0x00187A51
		public virtual void SetHandleWidth(float _arg)
		{
			vtkPlotRangeHandlesItem.vtkPlotRangeHandlesItem_SetHandleWidth_33(base.GetCppThis(), _arg);
		}

		// Token: 0x060119CF RID: 72143
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotRangeHandlesItem_SetLockTooltipToMouse_34(HandleRef pThis, int _arg);

		/// <summary>
		/// If On, the range tooltip is always rendered using mouse position,
		/// otherwise it is placed at the center of the x axis Default is On.
		/// </summary>
		// Token: 0x060119D0 RID: 72144 RVA: 0x00189861 File Offset: 0x00187A61
		public virtual void SetLockTooltipToMouse(int _arg)
		{
			vtkPlotRangeHandlesItem.vtkPlotRangeHandlesItem_SetLockTooltipToMouse_34(base.GetCppThis(), _arg);
		}

		// Token: 0x060119D1 RID: 72145
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotRangeHandlesItem_SetSynchronizeRangeHandles_35(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get whether handles move together when one of them is update. Default is Off.
		/// </summary>
		// Token: 0x060119D2 RID: 72146 RVA: 0x00189871 File Offset: 0x00187A71
		public virtual void SetSynchronizeRangeHandles(int _arg)
		{
			vtkPlotRangeHandlesItem.vtkPlotRangeHandlesItem_SetSynchronizeRangeHandles_35(base.GetCppThis(), _arg);
		}

		// Token: 0x060119D3 RID: 72147
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotRangeHandlesItem_SynchronizeRangeHandlesOff_36(HandleRef pThis);

		/// <summary>
		/// Set/Get whether handles move together when one of them is update. Default is Off.
		/// </summary>
		// Token: 0x060119D4 RID: 72148 RVA: 0x00189881 File Offset: 0x00187A81
		public virtual void SynchronizeRangeHandlesOff()
		{
			vtkPlotRangeHandlesItem.vtkPlotRangeHandlesItem_SynchronizeRangeHandlesOff_36(base.GetCppThis());
		}

		// Token: 0x060119D5 RID: 72149
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotRangeHandlesItem_SynchronizeRangeHandlesOn_37(HandleRef pThis);

		/// <summary>
		/// Set/Get whether handles move together when one of them is update. Default is Off.
		/// </summary>
		// Token: 0x060119D6 RID: 72150 RVA: 0x00189890 File Offset: 0x00187A90
		public virtual void SynchronizeRangeHandlesOn()
		{
			vtkPlotRangeHandlesItem.vtkPlotRangeHandlesItem_SynchronizeRangeHandlesOn_37(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400144E RID: 5198
		public new const string MRFullTypeName = "Kitware.VTK.vtkPlotRangeHandlesItem";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400144F RID: 5199
		public new static readonly string MRClassNameKey = "class vtkPlotRangeHandlesItem";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0200065D RID: 1629
		public enum Handle
		{
			/// <summary>enum member</summary>
			// Token: 0x04001451 RID: 5201
			LEFT_HANDLE,
			/// <summary>enum member</summary>
			// Token: 0x04001452 RID: 5202
			NO_HANDLE = -1,
			/// <summary>enum member</summary>
			// Token: 0x04001453 RID: 5203
			RIGHT_HANDLE = 1
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0200065E RID: 1630
		public enum Orientation
		{
			/// <summary>enum member</summary>
			// Token: 0x04001455 RID: 5205
			HORIZONTAL = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001456 RID: 5206
			VERTICAL = 0
		}
	}
}
