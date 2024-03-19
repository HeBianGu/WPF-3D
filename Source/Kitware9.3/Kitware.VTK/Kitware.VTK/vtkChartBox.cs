using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkChartBox
	/// </summary>
	/// <remarks>
	///    Factory class for drawing box plot charts
	///
	///
	/// This defines the interface for a box plot chart.
	/// </remarks>
	// Token: 0x0200063B RID: 1595
	public class vtkChartBox : vtkChart
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601138B RID: 70539 RVA: 0x0017FE93 File Offset: 0x0017E093
		static vtkChartBox()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkChartBox.MRClassNameKey, Type.GetType("Kitware.VTK.vtkChartBox"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601138C RID: 70540 RVA: 0x0017FEBB File Offset: 0x0017E0BB
		public vtkChartBox(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601138D RID: 70541
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartBox_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates a box chart
		/// </summary>
		// Token: 0x0601138E RID: 70542 RVA: 0x0017FECC File Offset: 0x0017E0CC
		public new static vtkChartBox New()
		{
			vtkChartBox result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartBox.vtkChartBox_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkChartBox)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Creates a box chart
		/// </summary>
		// Token: 0x0601138F RID: 70543 RVA: 0x0017FF20 File Offset: 0x0017E120
		public vtkChartBox() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkChartBox.vtkChartBox_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011390 RID: 70544 RVA: 0x0017FF64 File Offset: 0x0017E164
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011391 RID: 70545
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkChartBox_GetColumnId_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Get the input table column id of a column by its name.
		/// </summary>
		// Token: 0x06011392 RID: 70546 RVA: 0x0017FF70 File Offset: 0x0017E170
		public long GetColumnId(string name)
		{
			return vtkChartBox.vtkChartBox_GetColumnId_01(base.GetCppThis(), name);
		}

		// Token: 0x06011393 RID: 70547
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkChartBox_GetColumnVisibility_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Get the visibility of the specified column.
		/// </summary>
		// Token: 0x06011394 RID: 70548 RVA: 0x0017FF90 File Offset: 0x0017E190
		public bool GetColumnVisibility(string name)
		{
			return vtkChartBox.vtkChartBox_GetColumnVisibility_02(base.GetCppThis(), name) != 0;
		}

		// Token: 0x06011395 RID: 70549
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkChartBox_GetColumnVisibility_03(HandleRef pThis, long column);

		/// <summary>
		/// Get the visibility of the specified column.
		/// </summary>
		// Token: 0x06011396 RID: 70550 RVA: 0x0017FFB8 File Offset: 0x0017E1B8
		public bool GetColumnVisibility(long column)
		{
			return vtkChartBox.vtkChartBox_GetColumnVisibility_03(base.GetCppThis(), column) != 0;
		}

		// Token: 0x06011397 RID: 70551
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkChartBox_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011398 RID: 70552 RVA: 0x0017FFE0 File Offset: 0x0017E1E0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkChartBox.vtkChartBox_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06011399 RID: 70553
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkChartBox_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601139A RID: 70554 RVA: 0x00180000 File Offset: 0x0017E200
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkChartBox.vtkChartBox_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601139B RID: 70555
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkChartBox_GetNumberOfPlots_06(HandleRef pThis);

		/// <summary>
		/// Get the number of plots the chart contains.
		/// </summary>
		// Token: 0x0601139C RID: 70556 RVA: 0x0018001C File Offset: 0x0017E21C
		public override long GetNumberOfPlots()
		{
			return vtkChartBox.vtkChartBox_GetNumberOfPlots_06(base.GetCppThis());
		}

		// Token: 0x0601139D RID: 70557
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkChartBox_GetNumberOfVisibleColumns_07(HandleRef pThis);

		/// <summary>
		/// Get the number of visible box plots in the current chart.
		/// </summary>
		// Token: 0x0601139E RID: 70558 RVA: 0x0018003C File Offset: 0x0017E23C
		public virtual long GetNumberOfVisibleColumns()
		{
			return vtkChartBox.vtkChartBox_GetNumberOfVisibleColumns_07(base.GetCppThis());
		}

		// Token: 0x0601139F RID: 70559
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartBox_GetPlot_08(HandleRef pThis, long index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the plot at the specified index, returns null if the index is invalid.
		/// </summary>
		// Token: 0x060113A0 RID: 70560 RVA: 0x0018005C File Offset: 0x0017E25C
		public override vtkPlot GetPlot(long index)
		{
			vtkPlot vtkPlot = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartBox.vtkChartBox_GetPlot_08(base.GetCppThis(), index, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlot = (vtkPlot)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlot.Register(null);
				}
			}
			return vtkPlot;
		}

		// Token: 0x060113A1 RID: 70561
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkChartBox_GetSelectedColumn_09(HandleRef pThis);

		/// <summary>
		/// Get a list of the columns, and the order in which they are displayed.
		/// </summary>
		// Token: 0x060113A2 RID: 70562 RVA: 0x001800CC File Offset: 0x0017E2CC
		public virtual int GetSelectedColumn()
		{
			return vtkChartBox.vtkChartBox_GetSelectedColumn_09(base.GetCppThis());
		}

		// Token: 0x060113A3 RID: 70563
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartBox_GetTooltip_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the vtkTooltipItem object that will be displayed by the chart.
		/// </summary>
		// Token: 0x060113A4 RID: 70564 RVA: 0x001800EC File Offset: 0x0017E2EC
		public virtual vtkTooltipItem GetTooltip()
		{
			vtkTooltipItem vtkTooltipItem = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartBox.vtkChartBox_GetTooltip_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTooltipItem = (vtkTooltipItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTooltipItem.Register(null);
				}
			}
			return vtkTooltipItem;
		}

		// Token: 0x060113A5 RID: 70565
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartBox_GetVisibleColumns_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get a list of the columns, and the order in which they are displayed.
		/// </summary>
		// Token: 0x060113A6 RID: 70566 RVA: 0x0018015C File Offset: 0x0017E35C
		public virtual vtkStringArray GetVisibleColumns()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartBox.vtkChartBox_GetVisibleColumns_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringArray = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringArray.Register(null);
				}
			}
			return vtkStringArray;
		}

		// Token: 0x060113A7 RID: 70567
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkChartBox_GetXPosition_12(HandleRef pThis, int index);

		/// <summary>
		/// Get the column X position by index in the visible set.
		/// </summary>
		// Token: 0x060113A8 RID: 70568 RVA: 0x001801CC File Offset: 0x0017E3CC
		public virtual float GetXPosition(int index)
		{
			return vtkChartBox.vtkChartBox_GetXPosition_12(base.GetCppThis(), index);
		}

		// Token: 0x060113A9 RID: 70569
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartBox_GetYAxis_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the chart Y axis
		/// </summary>
		// Token: 0x060113AA RID: 70570 RVA: 0x001801EC File Offset: 0x0017E3EC
		public virtual vtkAxis GetYAxis()
		{
			vtkAxis vtkAxis = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartBox.vtkChartBox_GetYAxis_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAxis = (vtkAxis)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAxis.Register(null);
				}
			}
			return vtkAxis;
		}

		// Token: 0x060113AB RID: 70571
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkChartBox_IsA_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060113AC RID: 70572 RVA: 0x0018025C File Offset: 0x0017E45C
		public override int IsA(string type)
		{
			return vtkChartBox.vtkChartBox_IsA_14(base.GetCppThis(), type);
		}

		// Token: 0x060113AD RID: 70573
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkChartBox_IsTypeOf_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060113AE RID: 70574 RVA: 0x0018027C File Offset: 0x0017E47C
		public new static int IsTypeOf(string type)
		{
			return vtkChartBox.vtkChartBox_IsTypeOf_15(type);
		}

		// Token: 0x060113AF RID: 70575
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartBox_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060113B0 RID: 70576 RVA: 0x00180298 File Offset: 0x0017E498
		public new vtkChartBox NewInstance()
		{
			vtkChartBox result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartBox.vtkChartBox_NewInstance_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkChartBox)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060113B1 RID: 70577
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkChartBox_Paint_18(HandleRef pThis, HandleRef painter);

		/// <summary>
		/// Paint event for the chart, called whenever the chart needs to be drawn
		/// </summary>
		// Token: 0x060113B2 RID: 70578 RVA: 0x001802F4 File Offset: 0x0017E4F4
		public override bool Paint(vtkContext2D painter)
		{
			return vtkChartBox.vtkChartBox_Paint_18(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		// Token: 0x060113B3 RID: 70579
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartBox_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060113B4 RID: 70580 RVA: 0x00180330 File Offset: 0x0017E530
		public new static vtkChartBox SafeDownCast(vtkObjectBase o)
		{
			vtkChartBox vtkChartBox = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartBox.vtkChartBox_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkChartBox = (vtkChartBox)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkChartBox.Register(null);
				}
			}
			return vtkChartBox;
		}

		// Token: 0x060113B5 RID: 70581
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartBox_SetColumnVisibility_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, byte visible);

		/// <summary>
		/// Set the visibility of the specified column.
		/// </summary>
		// Token: 0x060113B6 RID: 70582 RVA: 0x001803AF File Offset: 0x0017E5AF
		public void SetColumnVisibility(string name, bool visible)
		{
			vtkChartBox.vtkChartBox_SetColumnVisibility_20(base.GetCppThis(), name, visible ? (byte)1 : (byte)0);
		}

		// Token: 0x060113B7 RID: 70583
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartBox_SetColumnVisibility_21(HandleRef pThis, long column, byte visible);

		/// <summary>
		/// Set the visibility of the specified column.
		/// </summary>
		// Token: 0x060113B8 RID: 70584 RVA: 0x001803C8 File Offset: 0x0017E5C8
		public void SetColumnVisibility(long column, bool visible)
		{
			vtkChartBox.vtkChartBox_SetColumnVisibility_21(base.GetCppThis(), column, visible ? (byte)1 : (byte)0);
		}

		// Token: 0x060113B9 RID: 70585
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartBox_SetColumnVisibilityAll_22(HandleRef pThis, byte visible);

		/// <summary>
		/// Set the visibility of all columns (true will make them all visible, false
		/// will remove all visible columns).
		/// </summary>
		// Token: 0x060113BA RID: 70586 RVA: 0x001803E1 File Offset: 0x0017E5E1
		public void SetColumnVisibilityAll(bool visible)
		{
			vtkChartBox.vtkChartBox_SetColumnVisibilityAll_22(base.GetCppThis(), visible ? (byte)1 : (byte)0);
		}

		// Token: 0x060113BB RID: 70587
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartBox_SetGeometry_23(HandleRef pThis, int arg1, int arg2);

		/// <summary>
		/// Calls superclass implementation and sets GeometryValid to False, causing
		/// the chart's geometry to be updated on the next Paint call.
		/// </summary>
		// Token: 0x060113BC RID: 70588 RVA: 0x001803F9 File Offset: 0x0017E5F9
		public override void SetGeometry(int arg1, int arg2)
		{
			vtkChartBox.vtkChartBox_SetGeometry_23(base.GetCppThis(), arg1, arg2);
		}

		// Token: 0x060113BD RID: 70589
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartBox_SetLayoutStrategy_24(HandleRef pThis, int strategy);

		/// <summary>
		/// Calls superclass implementation and sets GeometryValid to False, causing
		/// the chart's geometry to be updated on the next Paint call.
		/// </summary>
		// Token: 0x060113BE RID: 70590 RVA: 0x0018040A File Offset: 0x0017E60A
		public override void SetLayoutStrategy(int strategy)
		{
			vtkChartBox.vtkChartBox_SetLayoutStrategy_24(base.GetCppThis(), strategy);
		}

		// Token: 0x060113BF RID: 70591
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartBox_SetPlot_25(HandleRef pThis, HandleRef plot);

		/// <summary>
		/// Set plot to use for the chart. Since this type of chart can
		/// only contain one plot, this will replace the previous plot.
		/// </summary>
		// Token: 0x060113C0 RID: 70592 RVA: 0x0018041C File Offset: 0x0017E61C
		public virtual void SetPlot(vtkPlotBox plot)
		{
			vtkChartBox.vtkChartBox_SetPlot_25(base.GetCppThis(), (plot == null) ? default(HandleRef) : plot.GetCppThis());
		}

		// Token: 0x060113C1 RID: 70593
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartBox_SetSelectedColumn_26(HandleRef pThis, int _arg);

		/// <summary>
		/// Get a list of the columns, and the order in which they are displayed.
		/// </summary>
		// Token: 0x060113C2 RID: 70594 RVA: 0x0018044B File Offset: 0x0017E64B
		public virtual void SetSelectedColumn(int _arg)
		{
			vtkChartBox.vtkChartBox_SetSelectedColumn_26(base.GetCppThis(), _arg);
		}

		// Token: 0x060113C3 RID: 70595
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartBox_SetSize_27(HandleRef pThis, HandleRef rect);

		/// <summary>
		/// Calls superclass implementation and sets GeometryValid to False, causing
		/// the chart's geometry to be updated on the next Paint call.
		/// </summary>
		// Token: 0x060113C4 RID: 70596 RVA: 0x0018045C File Offset: 0x0017E65C
		public override void SetSize(vtkRectf rect)
		{
			vtkChartBox.vtkChartBox_SetSize_27(base.GetCppThis(), (rect == null) ? default(HandleRef) : rect.GetCppThis());
		}

		// Token: 0x060113C5 RID: 70597
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartBox_SetTooltip_28(HandleRef pThis, HandleRef tooltip);

		/// <summary>
		/// Set the vtkTooltipItem object that will be displayed by the chart.
		/// </summary>
		// Token: 0x060113C6 RID: 70598 RVA: 0x0018048C File Offset: 0x0017E68C
		public virtual void SetTooltip(vtkTooltipItem tooltip)
		{
			vtkChartBox.vtkChartBox_SetTooltip_28(base.GetCppThis(), (tooltip == null) ? default(HandleRef) : tooltip.GetCppThis());
		}

		// Token: 0x060113C7 RID: 70599
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartBox_Update_29(HandleRef pThis);

		/// <summary>
		/// Perform any updates to the item that may be necessary before rendering.
		/// The scene should take care of calling this on all items before their
		/// Paint function is invoked.
		/// </summary>
		// Token: 0x060113C8 RID: 70600 RVA: 0x001804BB File Offset: 0x0017E6BB
		public override void Update()
		{
			vtkChartBox.vtkChartBox_Update_29(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040013FE RID: 5118
		public new const string MRFullTypeName = "Kitware.VTK.vtkChartBox";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040013FF RID: 5119
		public new static readonly string MRClassNameKey = "class vtkChartBox";
	}
}
