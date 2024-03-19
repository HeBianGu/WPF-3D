using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkChartXY
	/// </summary>
	/// <remarks>
	///    Factory class for drawing XY charts
	///
	///
	/// This class implements an XY chart.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkBarChartActor
	/// </seealso>
	// Token: 0x0200063C RID: 1596
	public class vtkChartXY : vtkChart
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060113C9 RID: 70601 RVA: 0x001804CA File Offset: 0x0017E6CA
		static vtkChartXY()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkChartXY.MRClassNameKey, Type.GetType("Kitware.VTK.vtkChartXY"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060113CA RID: 70602 RVA: 0x001804F2 File Offset: 0x0017E6F2
		public vtkChartXY(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060113CB RID: 70603
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartXY_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates a 2D Chart object.
		/// </summary>
		// Token: 0x060113CC RID: 70604 RVA: 0x00180500 File Offset: 0x0017E700
		public new static vtkChartXY New()
		{
			vtkChartXY result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartXY.vtkChartXY_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkChartXY)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Creates a 2D Chart object.
		/// </summary>
		// Token: 0x060113CD RID: 70605 RVA: 0x00180554 File Offset: 0x0017E754
		public vtkChartXY() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkChartXY.vtkChartXY_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060113CE RID: 70606 RVA: 0x00180598 File Offset: 0x0017E798
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060113CF RID: 70607
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartXY_AddPlot_01(HandleRef pThis, int type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Add a plot to the chart, defaults to using the name of the y column
		/// </summary>
		// Token: 0x060113D0 RID: 70608 RVA: 0x001805A4 File Offset: 0x0017E7A4
		public override vtkPlot AddPlot(int type)
		{
			vtkPlot vtkPlot = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartXY.vtkChartXY_AddPlot_01(base.GetCppThis(), type, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060113D1 RID: 70609
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartXY_AddPlot_02(HandleRef pThis, int type, uint blockIndex, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Adds a plot to the chart holding data specific to a block in a vtkMultiBlockDataSet.
		/// </summary>
		// Token: 0x060113D2 RID: 70610 RVA: 0x00180614 File Offset: 0x0017E814
		public virtual vtkPlot AddPlot(int type, uint blockIndex)
		{
			vtkPlot vtkPlot = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartXY.vtkChartXY_AddPlot_02(base.GetCppThis(), type, blockIndex, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060113D3 RID: 70611
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkChartXY_AddPlot_03(HandleRef pThis, HandleRef plot);

		/// <summary>
		/// Adds a plot to the chart
		/// </summary>
		// Token: 0x060113D4 RID: 70612 RVA: 0x00180688 File Offset: 0x0017E888
		public override long AddPlot(vtkPlot plot)
		{
			return vtkChartXY.vtkChartXY_AddPlot_03(base.GetCppThis(), (plot == null) ? default(HandleRef) : plot.GetCppThis());
		}

		// Token: 0x060113D5 RID: 70613
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkChartXY_AddPlot_04(HandleRef pThis, HandleRef plot, uint blockIndex);

		/// <summary>
		/// Adds a plot to the chart holding data specific to a block in a vtkMultiBlockDataSet.
		/// </summary>
		// Token: 0x060113D6 RID: 70614 RVA: 0x001806BC File Offset: 0x0017E8BC
		public virtual long AddPlot(vtkPlot plot, uint blockIndex)
		{
			return vtkChartXY.vtkChartXY_AddPlot_04(base.GetCppThis(), (plot == null) ? default(HandleRef) : plot.GetCppThis(), blockIndex);
		}

		// Token: 0x060113D7 RID: 70615
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXY_AddSelection_05(HandleRef selection, HandleRef oldSelection);

		/// <summary>
		/// Add the supplied selection from the oldSelection.
		/// </summary>
		// Token: 0x060113D8 RID: 70616 RVA: 0x001806F4 File Offset: 0x0017E8F4
		public static void AddSelection(vtkIdTypeArray selection, vtkIdTypeArray oldSelection)
		{
			vtkChartXY.vtkChartXY_AddSelection_05((selection == null) ? default(HandleRef) : selection.GetCppThis(), (oldSelection == null) ? default(HandleRef) : oldSelection.GetCppThis());
		}

		// Token: 0x060113D9 RID: 70617
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXY_AdjustLowerBoundForLogPlotOff_06(HandleRef pThis);

		/// <summary>
		/// Adjust the minimum of a logarithmic axis to be greater than 0, regardless
		/// of the minimum data value.
		/// False by default.
		/// </summary>
		// Token: 0x060113DA RID: 70618 RVA: 0x00180732 File Offset: 0x0017E932
		public virtual void AdjustLowerBoundForLogPlotOff()
		{
			vtkChartXY.vtkChartXY_AdjustLowerBoundForLogPlotOff_06(base.GetCppThis());
		}

		// Token: 0x060113DB RID: 70619
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXY_AdjustLowerBoundForLogPlotOn_07(HandleRef pThis);

		/// <summary>
		/// Adjust the minimum of a logarithmic axis to be greater than 0, regardless
		/// of the minimum data value.
		/// False by default.
		/// </summary>
		// Token: 0x060113DC RID: 70620 RVA: 0x00180741 File Offset: 0x0017E941
		public virtual void AdjustLowerBoundForLogPlotOn()
		{
			vtkChartXY.vtkChartXY_AdjustLowerBoundForLogPlotOn_07(base.GetCppThis());
		}

		// Token: 0x060113DD RID: 70621
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXY_AutoAxesOff_08(HandleRef pThis);

		/// <summary>
		/// If true then the axes will be turned on and off depending upon whether
		/// any plots are in that corner. Defaults to true.
		/// </summary>
		// Token: 0x060113DE RID: 70622 RVA: 0x00180750 File Offset: 0x0017E950
		public virtual void AutoAxesOff()
		{
			vtkChartXY.vtkChartXY_AutoAxesOff_08(base.GetCppThis());
		}

		// Token: 0x060113DF RID: 70623
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXY_AutoAxesOn_09(HandleRef pThis);

		/// <summary>
		/// If true then the axes will be turned on and off depending upon whether
		/// any plots are in that corner. Defaults to true.
		/// </summary>
		// Token: 0x060113E0 RID: 70624 RVA: 0x0018075F File Offset: 0x0017E95F
		public virtual void AutoAxesOn()
		{
			vtkChartXY.vtkChartXY_AutoAxesOn_09(base.GetCppThis());
		}

		// Token: 0x060113E1 RID: 70625
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXY_BuildSelection_10(HandleRef link, int selectionMode, HandleRef plotSelection, HandleRef oldSelection, HandleRef plot);

		/// <summary>
		/// Build a selection based on the supplied selectionMode using the new
		/// plotSelection and combining it with the oldSelection. If link is not nullptr
		/// then the resulting selection will be set on the link.
		/// This is used in the plot or the column based selection.
		/// </summary>
		// Token: 0x060113E2 RID: 70626 RVA: 0x00180770 File Offset: 0x0017E970
		public static void BuildSelection(vtkAnnotationLink link, int selectionMode, vtkIdTypeArray plotSelection, vtkIdTypeArray oldSelection, vtkPlot plot)
		{
			vtkChartXY.vtkChartXY_BuildSelection_10((link == null) ? default(HandleRef) : link.GetCppThis(), selectionMode, (plotSelection == null) ? default(HandleRef) : plotSelection.GetCppThis(), (oldSelection == null) ? default(HandleRef) : oldSelection.GetCppThis(), (plot == null) ? default(HandleRef) : plot.GetCppThis());
		}

		// Token: 0x060113E3 RID: 70627
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXY_ClearPlots_11(HandleRef pThis);

		/// <summary>
		/// Remove all plots from the chart.
		/// </summary>
		// Token: 0x060113E4 RID: 70628 RVA: 0x001807DB File Offset: 0x0017E9DB
		public override void ClearPlots()
		{
			vtkChartXY.vtkChartXY_ClearPlots_11(base.GetCppThis());
		}

		// Token: 0x060113E5 RID: 70629
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXY_DragPointAlongXOff_12(HandleRef pThis);

		/// <summary>
		/// Set if the point can be dragged along X
		/// by the ClickAndDrag Action
		/// True by default.
		/// </summary>
		// Token: 0x060113E6 RID: 70630 RVA: 0x001807EA File Offset: 0x0017E9EA
		public virtual void DragPointAlongXOff()
		{
			vtkChartXY.vtkChartXY_DragPointAlongXOff_12(base.GetCppThis());
		}

		// Token: 0x060113E7 RID: 70631
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXY_DragPointAlongXOn_13(HandleRef pThis);

		/// <summary>
		/// Set if the point can be dragged along X
		/// by the ClickAndDrag Action
		/// True by default.
		/// </summary>
		// Token: 0x060113E8 RID: 70632 RVA: 0x001807F9 File Offset: 0x0017E9F9
		public virtual void DragPointAlongXOn()
		{
			vtkChartXY.vtkChartXY_DragPointAlongXOn_13(base.GetCppThis());
		}

		// Token: 0x060113E9 RID: 70633
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXY_DragPointAlongYOff_14(HandleRef pThis);

		/// <summary>
		/// Set if the point can be dragged along Y
		/// by the ClickAndDrag Action
		/// True by default.
		/// </summary>
		// Token: 0x060113EA RID: 70634 RVA: 0x00180808 File Offset: 0x0017EA08
		public virtual void DragPointAlongYOff()
		{
			vtkChartXY.vtkChartXY_DragPointAlongYOff_14(base.GetCppThis());
		}

		// Token: 0x060113EB RID: 70635
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXY_DragPointAlongYOn_15(HandleRef pThis);

		/// <summary>
		/// Set if the point can be dragged along Y
		/// by the ClickAndDrag Action
		/// True by default.
		/// </summary>
		// Token: 0x060113EC RID: 70636 RVA: 0x00180817 File Offset: 0x0017EA17
		public virtual void DragPointAlongYOn()
		{
			vtkChartXY.vtkChartXY_DragPointAlongYOn_15(base.GetCppThis());
		}

		// Token: 0x060113ED RID: 70637
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXY_DrawAxesAtOriginOff_16(HandleRef pThis);

		/// <summary>
		/// If true then the axes will be drawn at the origin (scientific style).
		/// </summary>
		// Token: 0x060113EE RID: 70638 RVA: 0x00180826 File Offset: 0x0017EA26
		public virtual void DrawAxesAtOriginOff()
		{
			vtkChartXY.vtkChartXY_DrawAxesAtOriginOff_16(base.GetCppThis());
		}

		// Token: 0x060113EF RID: 70639
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXY_DrawAxesAtOriginOn_17(HandleRef pThis);

		/// <summary>
		/// If true then the axes will be drawn at the origin (scientific style).
		/// </summary>
		// Token: 0x060113F0 RID: 70640 RVA: 0x00180835 File Offset: 0x0017EA35
		public virtual void DrawAxesAtOriginOn()
		{
			vtkChartXY.vtkChartXY_DrawAxesAtOriginOn_17(base.GetCppThis());
		}

		// Token: 0x060113F1 RID: 70641
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXY_ForceAxesToBoundsOff_18(HandleRef pThis);

		/// <summary>
		/// Force the axes to have their Minimum and Maximum properties inside the
		/// plot boundaries. It constrains pan and zoom interaction.
		/// False by default.
		/// </summary>
		// Token: 0x060113F2 RID: 70642 RVA: 0x00180844 File Offset: 0x0017EA44
		public virtual void ForceAxesToBoundsOff()
		{
			vtkChartXY.vtkChartXY_ForceAxesToBoundsOff_18(base.GetCppThis());
		}

		// Token: 0x060113F3 RID: 70643
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXY_ForceAxesToBoundsOn_19(HandleRef pThis);

		/// <summary>
		/// Force the axes to have their Minimum and Maximum properties inside the
		/// plot boundaries. It constrains pan and zoom interaction.
		/// False by default.
		/// </summary>
		// Token: 0x060113F4 RID: 70644 RVA: 0x00180853 File Offset: 0x0017EA53
		public virtual void ForceAxesToBoundsOn()
		{
			vtkChartXY.vtkChartXY_ForceAxesToBoundsOn_19(base.GetCppThis());
		}

		// Token: 0x060113F5 RID: 70645
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkChartXY_GetAdjustLowerBoundForLogPlot_20(HandleRef pThis);

		/// <summary>
		/// Adjust the minimum of a logarithmic axis to be greater than 0, regardless
		/// of the minimum data value.
		/// False by default.
		/// </summary>
		// Token: 0x060113F6 RID: 70646 RVA: 0x00180864 File Offset: 0x0017EA64
		public virtual bool GetAdjustLowerBoundForLogPlot()
		{
			return vtkChartXY.vtkChartXY_GetAdjustLowerBoundForLogPlot_20(base.GetCppThis()) != 0;
		}

		// Token: 0x060113F7 RID: 70647
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkChartXY_GetAutoAxes_21(HandleRef pThis);

		/// <summary>
		/// If true then the axes will be turned on and off depending upon whether
		/// any plots are in that corner. Defaults to true.
		/// </summary>
		// Token: 0x060113F8 RID: 70648 RVA: 0x0018088C File Offset: 0x0017EA8C
		public virtual bool GetAutoAxes()
		{
			return vtkChartXY.vtkChartXY_GetAutoAxes_21(base.GetCppThis()) != 0;
		}

		// Token: 0x060113F9 RID: 70649
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartXY_GetAxis_22(HandleRef pThis, int axisIndex, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the axis specified by axisIndex. This is specified with the vtkAxis
		/// position enum, valid values are vtkAxis::LEFT, vtkAxis::BOTTOM,
		/// vtkAxis::RIGHT and vtkAxis::TOP.
		/// </summary>
		// Token: 0x060113FA RID: 70650 RVA: 0x001808B4 File Offset: 0x0017EAB4
		public override vtkAxis GetAxis(int axisIndex)
		{
			vtkAxis vtkAxis = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartXY.vtkChartXY_GetAxis_22(base.GetCppThis(), axisIndex, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060113FB RID: 70651
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkChartXY_GetAxisZoom_23(HandleRef pThis, int index);

		/// <summary>
		/// Set the behavior of the mouse wheel for individual axes. ZoomWithMouseWheel
		/// must be enabled to allow zooming; individual axes can be set to ignore zoom.
		/// The default value for all axes is true.
		/// </summary>
		// Token: 0x060113FC RID: 70652 RVA: 0x00180924 File Offset: 0x0017EB24
		public bool GetAxisZoom(int index)
		{
			return vtkChartXY.vtkChartXY_GetAxisZoom_23(base.GetCppThis(), index) != 0;
		}

		// Token: 0x060113FD RID: 70653
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkChartXY_GetBarWidthFraction_24(HandleRef pThis);

		/// <summary>
		/// Set the width fraction for any bar charts drawn in this chart. It is
		/// assumed that all bar plots will use the same array for the X axis, and that
		/// this array is regularly spaced. The delta between the first two x values is
		/// used to calculated the width of the bars, and subdivided between each bar.
		/// The default value is 0.8, 1.0 would lead to bars that touch.
		/// </summary>
		// Token: 0x060113FE RID: 70654 RVA: 0x0018094C File Offset: 0x0017EB4C
		public virtual float GetBarWidthFraction()
		{
			return vtkChartXY.vtkChartXY_GetBarWidthFraction_24(base.GetCppThis());
		}

		// Token: 0x060113FF RID: 70655
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkChartXY_GetDragPointAlongX_25(HandleRef pThis);

		/// <summary>
		/// Set if the point can be dragged along X
		/// by the ClickAndDrag Action
		/// True by default.
		/// </summary>
		// Token: 0x06011400 RID: 70656 RVA: 0x0018096C File Offset: 0x0017EB6C
		public virtual bool GetDragPointAlongX()
		{
			return vtkChartXY.vtkChartXY_GetDragPointAlongX_25(base.GetCppThis()) != 0;
		}

		// Token: 0x06011401 RID: 70657
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkChartXY_GetDragPointAlongY_26(HandleRef pThis);

		/// <summary>
		/// Set if the point can be dragged along Y
		/// by the ClickAndDrag Action
		/// True by default.
		/// </summary>
		// Token: 0x06011402 RID: 70658 RVA: 0x00180994 File Offset: 0x0017EB94
		public virtual bool GetDragPointAlongY()
		{
			return vtkChartXY.vtkChartXY_GetDragPointAlongY_26(base.GetCppThis()) != 0;
		}

		// Token: 0x06011403 RID: 70659
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkChartXY_GetDrawAxesAtOrigin_27(HandleRef pThis);

		/// <summary>
		/// If true then the axes will be drawn at the origin (scientific style).
		/// </summary>
		// Token: 0x06011404 RID: 70660 RVA: 0x001809BC File Offset: 0x0017EBBC
		public virtual bool GetDrawAxesAtOrigin()
		{
			return vtkChartXY.vtkChartXY_GetDrawAxesAtOrigin_27(base.GetCppThis()) != 0;
		}

		// Token: 0x06011405 RID: 70661
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkChartXY_GetForceAxesToBounds_28(HandleRef pThis);

		/// <summary>
		/// Force the axes to have their Minimum and Maximum properties inside the
		/// plot boundaries. It constrains pan and zoom interaction.
		/// False by default.
		/// </summary>
		// Token: 0x06011406 RID: 70662 RVA: 0x001809E4 File Offset: 0x0017EBE4
		public virtual bool GetForceAxesToBounds()
		{
			return vtkChartXY.vtkChartXY_GetForceAxesToBounds_28(base.GetCppThis()) != 0;
		}

		// Token: 0x06011407 RID: 70663
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkChartXY_GetHiddenAxisBorder_29(HandleRef pThis);

		/// <summary>
		/// Border size of the axes that are hidden (vtkAxis::GetVisible())
		/// </summary>
		// Token: 0x06011408 RID: 70664 RVA: 0x00180A0C File Offset: 0x0017EC0C
		public virtual int GetHiddenAxisBorder()
		{
			return vtkChartXY.vtkChartXY_GetHiddenAxisBorder_29(base.GetCppThis());
		}

		// Token: 0x06011409 RID: 70665
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkChartXY_GetIgnoreNanInBounds_30(HandleRef pThis);

		/// <summary>
		/// Ignore NaN in RecalculateBounds().
		/// Prevents the final bounds to contain NaN if one of the plots contains NaN
		/// in its bounds.
		/// False by default.
		/// </summary>
		// Token: 0x0601140A RID: 70666 RVA: 0x00180A2C File Offset: 0x0017EC2C
		public virtual bool GetIgnoreNanInBounds()
		{
			return vtkChartXY.vtkChartXY_GetIgnoreNanInBounds_30(base.GetCppThis()) != 0;
		}

		// Token: 0x0601140B RID: 70667
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartXY_GetLegend_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the vtkChartLegend object that will be displayed by the chart.
		/// </summary>
		// Token: 0x0601140C RID: 70668 RVA: 0x00180A54 File Offset: 0x0017EC54
		public override vtkChartLegend GetLegend()
		{
			vtkChartLegend vtkChartLegend = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartXY.vtkChartXY_GetLegend_31(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkChartLegend = (vtkChartLegend)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkChartLegend.Register(null);
				}
			}
			return vtkChartLegend;
		}

		// Token: 0x0601140D RID: 70669
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkChartXY_GetNumberOfAxes_32(HandleRef pThis);

		/// <summary>
		/// Get the number of axes in the current chart.
		/// </summary>
		// Token: 0x0601140E RID: 70670 RVA: 0x00180AC4 File Offset: 0x0017ECC4
		public override long GetNumberOfAxes()
		{
			return vtkChartXY.vtkChartXY_GetNumberOfAxes_32(base.GetCppThis());
		}

		// Token: 0x0601140F RID: 70671
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkChartXY_GetNumberOfGenerationsFromBase_33(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011410 RID: 70672 RVA: 0x00180AE4 File Offset: 0x0017ECE4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkChartXY.vtkChartXY_GetNumberOfGenerationsFromBase_33(base.GetCppThis(), type);
		}

		// Token: 0x06011411 RID: 70673
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkChartXY_GetNumberOfGenerationsFromBaseType_34([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011412 RID: 70674 RVA: 0x00180B04 File Offset: 0x0017ED04
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkChartXY.vtkChartXY_GetNumberOfGenerationsFromBaseType_34(type);
		}

		// Token: 0x06011413 RID: 70675
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkChartXY_GetNumberOfPlots_35(HandleRef pThis);

		/// <summary>
		/// Get the number of plots the chart contains.
		/// </summary>
		// Token: 0x06011414 RID: 70676 RVA: 0x00180B20 File Offset: 0x0017ED20
		public override long GetNumberOfPlots()
		{
			return vtkChartXY.vtkChartXY_GetNumberOfPlots_35(base.GetCppThis());
		}

		// Token: 0x06011415 RID: 70677
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartXY_GetPlot_36(HandleRef pThis, long index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the plot at the specified index, returns null if the index is invalid.
		/// </summary>
		// Token: 0x06011416 RID: 70678 RVA: 0x00180B40 File Offset: 0x0017ED40
		public override vtkPlot GetPlot(long index)
		{
			vtkPlot vtkPlot = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartXY.vtkChartXY_GetPlot_36(base.GetCppThis(), index, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06011417 RID: 70679
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkChartXY_GetPlotCorner_37(HandleRef pThis, HandleRef plot);

		/// <summary>
		/// Figure out which quadrant the plot is in.
		/// </summary>
		// Token: 0x06011418 RID: 70680 RVA: 0x00180BB0 File Offset: 0x0017EDB0
		public int GetPlotCorner(vtkPlot plot)
		{
			return vtkChartXY.vtkChartXY_GetPlotCorner_37(base.GetCppThis(), (plot == null) ? default(HandleRef) : plot.GetCppThis());
		}

		// Token: 0x06011419 RID: 70681
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkChartXY_GetPlotIndex_38(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get the index of the specified plot, returns -1 if the plot does not
		/// belong to the chart.
		/// </summary>
		// Token: 0x0601141A RID: 70682 RVA: 0x00180BE4 File Offset: 0x0017EDE4
		public virtual long GetPlotIndex(vtkPlot arg0)
		{
			return vtkChartXY.vtkChartXY_GetPlotIndex_38(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601141B RID: 70683
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartXY_GetTooltip_39(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the vtkTooltipItem object that will be displayed by the chart.
		/// </summary>
		// Token: 0x0601141C RID: 70684 RVA: 0x00180C18 File Offset: 0x0017EE18
		public virtual vtkTooltipItem GetTooltip()
		{
			vtkTooltipItem vtkTooltipItem = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartXY.vtkChartXY_GetTooltip_39(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601141D RID: 70685
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkChartXY_GetZoomWithMouseWheel_40(HandleRef pThis);

		/// <summary>
		/// Set the behavior of the mouse wheel.  If true, the mouse wheel zooms in/out
		/// on the chart.  Otherwise, unless MouseWheelEvent is overridden by a subclass
		/// the mouse wheel does nothing.
		/// The default value is true.
		/// </summary>
		// Token: 0x0601141E RID: 70686 RVA: 0x00180C88 File Offset: 0x0017EE88
		public virtual bool GetZoomWithMouseWheel()
		{
			return vtkChartXY.vtkChartXY_GetZoomWithMouseWheel_40(base.GetCppThis()) != 0;
		}

		// Token: 0x0601141F RID: 70687
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXY_IgnoreNanInBoundsOff_41(HandleRef pThis);

		/// <summary>
		/// Ignore NaN in RecalculateBounds().
		/// Prevents the final bounds to contain NaN if one of the plots contains NaN
		/// in its bounds.
		/// False by default.
		/// </summary>
		// Token: 0x06011420 RID: 70688 RVA: 0x00180CAE File Offset: 0x0017EEAE
		public virtual void IgnoreNanInBoundsOff()
		{
			vtkChartXY.vtkChartXY_IgnoreNanInBoundsOff_41(base.GetCppThis());
		}

		// Token: 0x06011421 RID: 70689
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXY_IgnoreNanInBoundsOn_42(HandleRef pThis);

		/// <summary>
		/// Ignore NaN in RecalculateBounds().
		/// Prevents the final bounds to contain NaN if one of the plots contains NaN
		/// in its bounds.
		/// False by default.
		/// </summary>
		// Token: 0x06011422 RID: 70690 RVA: 0x00180CBD File Offset: 0x0017EEBD
		public virtual void IgnoreNanInBoundsOn()
		{
			vtkChartXY.vtkChartXY_IgnoreNanInBoundsOn_42(base.GetCppThis());
		}

		// Token: 0x06011423 RID: 70691
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkChartXY_IsA_43(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011424 RID: 70692 RVA: 0x00180CCC File Offset: 0x0017EECC
		public override int IsA(string type)
		{
			return vtkChartXY.vtkChartXY_IsA_43(base.GetCppThis(), type);
		}

		// Token: 0x06011425 RID: 70693
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkChartXY_IsTypeOf_44([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011426 RID: 70694 RVA: 0x00180CEC File Offset: 0x0017EEEC
		public new static int IsTypeOf(string type)
		{
			return vtkChartXY.vtkChartXY_IsTypeOf_44(type);
		}

		// Token: 0x06011427 RID: 70695
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkChartXY_LowerPlot_45(HandleRef pThis, HandleRef plot);

		/// <summary>
		/// Lowers the \a plot to the bottom of the plot's stack.
		/// \return The new index of the plot
		/// \sa StackPlotUnder(), RaisePlot(), StackPlotAbove()
		/// </summary>
		// Token: 0x06011428 RID: 70696 RVA: 0x00180D08 File Offset: 0x0017EF08
		public long LowerPlot(vtkPlot plot)
		{
			return vtkChartXY.vtkChartXY_LowerPlot_45(base.GetCppThis(), (plot == null) ? default(HandleRef) : plot.GetCppThis());
		}

		// Token: 0x06011429 RID: 70697
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXY_MakeSelection_46(HandleRef link, HandleRef selectionIds, HandleRef plot);

		/// <summary>
		/// Populate the annotation link with the supplied selectionIds array, and set
		/// the appropriate node properties for a plot based chart selection.
		/// </summary>
		// Token: 0x0601142A RID: 70698 RVA: 0x00180D3C File Offset: 0x0017EF3C
		public static void MakeSelection(vtkAnnotationLink link, vtkIdTypeArray selectionIds, vtkPlot plot)
		{
			vtkChartXY.vtkChartXY_MakeSelection_46((link == null) ? default(HandleRef) : link.GetCppThis(), (selectionIds == null) ? default(HandleRef) : selectionIds.GetCppThis(), (plot == null) ? default(HandleRef) : plot.GetCppThis());
		}

		// Token: 0x0601142B RID: 70699
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXY_MinusSelection_47(HandleRef selection, HandleRef oldSelection);

		/// <summary>
		/// Subtract the supplied selection from the oldSelection.
		/// </summary>
		// Token: 0x0601142C RID: 70700 RVA: 0x00180D90 File Offset: 0x0017EF90
		public static void MinusSelection(vtkIdTypeArray selection, vtkIdTypeArray oldSelection)
		{
			vtkChartXY.vtkChartXY_MinusSelection_47((selection == null) ? default(HandleRef) : selection.GetCppThis(), (oldSelection == null) ? default(HandleRef) : oldSelection.GetCppThis());
		}

		// Token: 0x0601142D RID: 70701
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartXY_NewInstance_49(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601142E RID: 70702 RVA: 0x00180DD0 File Offset: 0x0017EFD0
		public new vtkChartXY NewInstance()
		{
			vtkChartXY result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartXY.vtkChartXY_NewInstance_49(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkChartXY)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601142F RID: 70703
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkChartXY_Paint_50(HandleRef pThis, HandleRef painter);

		/// <summary>
		/// Paint event for the chart, called whenever the chart needs to be drawn
		/// </summary>
		// Token: 0x06011430 RID: 70704 RVA: 0x00180E2C File Offset: 0x0017F02C
		public override bool Paint(vtkContext2D painter)
		{
			return vtkChartXY.vtkChartXY_Paint_50(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		// Token: 0x06011431 RID: 70705
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkChartXY_RaisePlot_51(HandleRef pThis, HandleRef plot);

		/// <summary>
		/// Raises the \a plot to the top of the plot's stack.
		/// \return The new index of the plot
		/// \sa StackPlotAbove(), LowerPlot(), StackPlotUnder()
		/// </summary>
		// Token: 0x06011432 RID: 70706 RVA: 0x00180E68 File Offset: 0x0017F068
		public long RaisePlot(vtkPlot plot)
		{
			return vtkChartXY.vtkChartXY_RaisePlot_51(base.GetCppThis(), (plot == null) ? default(HandleRef) : plot.GetCppThis());
		}

		// Token: 0x06011433 RID: 70707
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXY_RecalculateBounds_52(HandleRef pThis);

		/// <summary>
		/// Request that the chart recalculates the range of its axes. Especially
		/// useful in applications after the parameters of plots have been modified.
		/// </summary>
		// Token: 0x06011434 RID: 70708 RVA: 0x00180E9C File Offset: 0x0017F09C
		public override void RecalculateBounds()
		{
			vtkChartXY.vtkChartXY_RecalculateBounds_52(base.GetCppThis());
		}

		// Token: 0x06011435 RID: 70709
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkChartXY_RemovePlot_53(HandleRef pThis, long index);

		/// <summary>
		/// Remove the plot at the specified index, returns true if successful,
		/// false if the index was invalid.
		/// </summary>
		// Token: 0x06011436 RID: 70710 RVA: 0x00180EAC File Offset: 0x0017F0AC
		public override bool RemovePlot(long index)
		{
			return vtkChartXY.vtkChartXY_RemovePlot_53(base.GetCppThis(), index) != 0;
		}

		// Token: 0x06011437 RID: 70711
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXY_RemovePlotSelections_54(HandleRef pThis);

		/// <summary>
		/// Remove all the selection from Plots
		/// </summary>
		// Token: 0x06011438 RID: 70712 RVA: 0x00180ED3 File Offset: 0x0017F0D3
		public void RemovePlotSelections()
		{
			vtkChartXY.vtkChartXY_RemovePlotSelections_54(base.GetCppThis());
		}

		// Token: 0x06011439 RID: 70713
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartXY_SafeDownCast_55(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601143A RID: 70714 RVA: 0x00180EE4 File Offset: 0x0017F0E4
		public new static vtkChartXY SafeDownCast(vtkObjectBase o)
		{
			vtkChartXY vtkChartXY = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartXY.vtkChartXY_SafeDownCast_55((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkChartXY = (vtkChartXY)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkChartXY.Register(null);
				}
			}
			return vtkChartXY;
		}

		// Token: 0x0601143B RID: 70715
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXY_SetAdjustLowerBoundForLogPlot_56(HandleRef pThis, byte _arg);

		/// <summary>
		/// Adjust the minimum of a logarithmic axis to be greater than 0, regardless
		/// of the minimum data value.
		/// False by default.
		/// </summary>
		// Token: 0x0601143C RID: 70716 RVA: 0x00180F63 File Offset: 0x0017F163
		public virtual void SetAdjustLowerBoundForLogPlot(bool _arg)
		{
			vtkChartXY.vtkChartXY_SetAdjustLowerBoundForLogPlot_56(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0601143D RID: 70717
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXY_SetAutoAxes_57(HandleRef pThis, byte _arg);

		/// <summary>
		/// If true then the axes will be turned on and off depending upon whether
		/// any plots are in that corner. Defaults to true.
		/// </summary>
		// Token: 0x0601143E RID: 70718 RVA: 0x00180F7B File Offset: 0x0017F17B
		public virtual void SetAutoAxes(bool _arg)
		{
			vtkChartXY.vtkChartXY_SetAutoAxes_57(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0601143F RID: 70719
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXY_SetAxis_58(HandleRef pThis, int axisIndex, HandleRef arg1);

		/// <summary>
		/// Set the axis specified by axisIndex. This is specified with the vtkAxis
		/// position enum, valid values are vtkAxis::LEFT, vtkAxis::BOTTOM,
		/// vtkAxis::RIGHT and vtkAxis::TOP.
		/// </summary>
		// Token: 0x06011440 RID: 70720 RVA: 0x00180F94 File Offset: 0x0017F194
		public override void SetAxis(int axisIndex, vtkAxis arg1)
		{
			vtkChartXY.vtkChartXY_SetAxis_58(base.GetCppThis(), axisIndex, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x06011441 RID: 70721
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXY_SetAxisZoom_59(HandleRef pThis, int index, byte v);

		/// <summary>
		/// Set the behavior of the mouse wheel for individual axes. ZoomWithMouseWheel
		/// must be enabled to allow zooming; individual axes can be set to ignore zoom.
		/// The default value for all axes is true.
		/// </summary>
		// Token: 0x06011442 RID: 70722 RVA: 0x00180FC4 File Offset: 0x0017F1C4
		public void SetAxisZoom(int index, bool v)
		{
			vtkChartXY.vtkChartXY_SetAxisZoom_59(base.GetCppThis(), index, v ? (byte)1 : (byte)0);
		}

		// Token: 0x06011443 RID: 70723
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXY_SetBarWidthFraction_60(HandleRef pThis, float _arg);

		/// <summary>
		/// Set the width fraction for any bar charts drawn in this chart. It is
		/// assumed that all bar plots will use the same array for the X axis, and that
		/// this array is regularly spaced. The delta between the first two x values is
		/// used to calculated the width of the bars, and subdivided between each bar.
		/// The default value is 0.8, 1.0 would lead to bars that touch.
		/// </summary>
		// Token: 0x06011444 RID: 70724 RVA: 0x00180FDD File Offset: 0x0017F1DD
		public virtual void SetBarWidthFraction(float _arg)
		{
			vtkChartXY.vtkChartXY_SetBarWidthFraction_60(base.GetCppThis(), _arg);
		}

		// Token: 0x06011445 RID: 70725
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXY_SetDragPointAlongX_61(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set if the point can be dragged along X
		/// by the ClickAndDrag Action
		/// True by default.
		/// </summary>
		// Token: 0x06011446 RID: 70726 RVA: 0x00180FED File Offset: 0x0017F1ED
		public virtual void SetDragPointAlongX(bool _arg)
		{
			vtkChartXY.vtkChartXY_SetDragPointAlongX_61(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06011447 RID: 70727
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXY_SetDragPointAlongY_62(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set if the point can be dragged along Y
		/// by the ClickAndDrag Action
		/// True by default.
		/// </summary>
		// Token: 0x06011448 RID: 70728 RVA: 0x00181005 File Offset: 0x0017F205
		public virtual void SetDragPointAlongY(bool _arg)
		{
			vtkChartXY.vtkChartXY_SetDragPointAlongY_62(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06011449 RID: 70729
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXY_SetDrawAxesAtOrigin_63(HandleRef pThis, byte _arg);

		/// <summary>
		/// If true then the axes will be drawn at the origin (scientific style).
		/// </summary>
		// Token: 0x0601144A RID: 70730 RVA: 0x0018101D File Offset: 0x0017F21D
		public virtual void SetDrawAxesAtOrigin(bool _arg)
		{
			vtkChartXY.vtkChartXY_SetDrawAxesAtOrigin_63(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0601144B RID: 70731
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXY_SetForceAxesToBounds_64(HandleRef pThis, byte _arg);

		/// <summary>
		/// Force the axes to have their Minimum and Maximum properties inside the
		/// plot boundaries. It constrains pan and zoom interaction.
		/// False by default.
		/// </summary>
		// Token: 0x0601144C RID: 70732 RVA: 0x00181035 File Offset: 0x0017F235
		public virtual void SetForceAxesToBounds(bool _arg)
		{
			vtkChartXY.vtkChartXY_SetForceAxesToBounds_64(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0601144D RID: 70733
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXY_SetHiddenAxisBorder_65(HandleRef pThis, int _arg);

		/// <summary>
		/// Border size of the axes that are hidden (vtkAxis::GetVisible())
		/// </summary>
		// Token: 0x0601144E RID: 70734 RVA: 0x0018104D File Offset: 0x0017F24D
		public virtual void SetHiddenAxisBorder(int _arg)
		{
			vtkChartXY.vtkChartXY_SetHiddenAxisBorder_65(base.GetCppThis(), _arg);
		}

		// Token: 0x0601144F RID: 70735
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXY_SetIgnoreNanInBounds_66(HandleRef pThis, byte _arg);

		/// <summary>
		/// Ignore NaN in RecalculateBounds().
		/// Prevents the final bounds to contain NaN if one of the plots contains NaN
		/// in its bounds.
		/// False by default.
		/// </summary>
		// Token: 0x06011450 RID: 70736 RVA: 0x0018105D File Offset: 0x0017F25D
		public virtual void SetIgnoreNanInBounds(bool _arg)
		{
			vtkChartXY.vtkChartXY_SetIgnoreNanInBounds_66(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06011451 RID: 70737
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXY_SetPlotCorner_67(HandleRef pThis, HandleRef plot, int corner);

		/// <summary>
		/// Figure out which quadrant the plot is in.
		/// </summary>
		// Token: 0x06011452 RID: 70738 RVA: 0x00181078 File Offset: 0x0017F278
		public void SetPlotCorner(vtkPlot plot, int corner)
		{
			vtkChartXY.vtkChartXY_SetPlotCorner_67(base.GetCppThis(), (plot == null) ? default(HandleRef) : plot.GetCppThis(), corner);
		}

		// Token: 0x06011453 RID: 70739
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXY_SetSelectionMethod_68(HandleRef pThis, int method);

		/// <summary>
		/// Set the selection method, which controls how selections are handled by the
		/// chart. The default is SELECTION_ROWS which selects all points in all plots
		/// in a chart that have values in the rows selected. SELECTION_PLOTS allows
		/// for finer-grained selections specific to each plot, and so to each XY
		/// column pair.
		/// </summary>
		// Token: 0x06011454 RID: 70740 RVA: 0x001810A8 File Offset: 0x0017F2A8
		public override void SetSelectionMethod(int method)
		{
			vtkChartXY.vtkChartXY_SetSelectionMethod_68(base.GetCppThis(), method);
		}

		// Token: 0x06011455 RID: 70741
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXY_SetShowLegend_69(HandleRef pThis, byte visible);

		/// <summary>
		/// Set whether the chart should draw a legend.
		/// </summary>
		// Token: 0x06011456 RID: 70742 RVA: 0x001810B8 File Offset: 0x0017F2B8
		public override void SetShowLegend(bool visible)
		{
			vtkChartXY.vtkChartXY_SetShowLegend_69(base.GetCppThis(), visible ? (byte)1 : (byte)0);
		}

		// Token: 0x06011457 RID: 70743
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXY_SetTooltip_70(HandleRef pThis, HandleRef tooltip);

		/// <summary>
		/// Set the vtkTooltipItem object that will be displayed by the chart.
		/// </summary>
		// Token: 0x06011458 RID: 70744 RVA: 0x001810D0 File Offset: 0x0017F2D0
		public virtual void SetTooltip(vtkTooltipItem tooltip)
		{
			vtkChartXY.vtkChartXY_SetTooltip_70(base.GetCppThis(), (tooltip == null) ? default(HandleRef) : tooltip.GetCppThis());
		}

		// Token: 0x06011459 RID: 70745
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXY_SetZoomWithMouseWheel_71(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set the behavior of the mouse wheel.  If true, the mouse wheel zooms in/out
		/// on the chart.  Otherwise, unless MouseWheelEvent is overridden by a subclass
		/// the mouse wheel does nothing.
		/// The default value is true.
		/// </summary>
		// Token: 0x0601145A RID: 70746 RVA: 0x001810FF File Offset: 0x0017F2FF
		public virtual void SetZoomWithMouseWheel(bool _arg)
		{
			vtkChartXY.vtkChartXY_SetZoomWithMouseWheel_71(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0601145B RID: 70747
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkChartXY_StackPlotAbove_72(HandleRef pThis, HandleRef plot, HandleRef under);

		/// <summary>
		/// Raises the \a plot above the \a under plot. If \a under is null,
		/// the plot is raised to the top of the plot's stack.
		/// \return The new index of the plot
		/// \sa RaisePlot(), LowerPlot(), StackPlotUnder()
		/// </summary>
		// Token: 0x0601145C RID: 70748 RVA: 0x00181118 File Offset: 0x0017F318
		public virtual long StackPlotAbove(vtkPlot plot, vtkPlot under)
		{
			return vtkChartXY.vtkChartXY_StackPlotAbove_72(base.GetCppThis(), (plot == null) ? default(HandleRef) : plot.GetCppThis(), (under == null) ? default(HandleRef) : under.GetCppThis());
		}

		// Token: 0x0601145D RID: 70749
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkChartXY_StackPlotUnder_73(HandleRef pThis, HandleRef plot, HandleRef above);

		/// <summary>
		/// Lowers the \a plot under the \a above plot. If \a above is null,
		/// the plot is lowered to the bottom of the plot's stack
		/// \return The new index of the plot
		/// \sa StackPlotUnder(), RaisePlot(), StackPlotAbove()
		/// </summary>
		// Token: 0x0601145E RID: 70750 RVA: 0x00181164 File Offset: 0x0017F364
		public virtual long StackPlotUnder(vtkPlot plot, vtkPlot above)
		{
			return vtkChartXY.vtkChartXY_StackPlotUnder_73(base.GetCppThis(), (plot == null) ? default(HandleRef) : plot.GetCppThis(), (above == null) ? default(HandleRef) : above.GetCppThis());
		}

		// Token: 0x0601145F RID: 70751
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXY_ToggleSelection_74(HandleRef selection, HandleRef oldSelection);

		/// <summary>
		/// Toggle the supplied selection from the oldSelection.
		/// </summary>
		// Token: 0x06011460 RID: 70752 RVA: 0x001811B0 File Offset: 0x0017F3B0
		public static void ToggleSelection(vtkIdTypeArray selection, vtkIdTypeArray oldSelection)
		{
			vtkChartXY.vtkChartXY_ToggleSelection_74((selection == null) ? default(HandleRef) : selection.GetCppThis(), (oldSelection == null) ? default(HandleRef) : oldSelection.GetCppThis());
		}

		// Token: 0x06011461 RID: 70753
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXY_Update_75(HandleRef pThis);

		/// <summary>
		/// Perform any updates to the item that may be necessary before rendering.
		/// The scene should take care of calling this on all items before their
		/// Paint function is invoked.
		/// </summary>
		// Token: 0x06011462 RID: 70754 RVA: 0x001811EE File Offset: 0x0017F3EE
		public override void Update()
		{
			vtkChartXY.vtkChartXY_Update_75(base.GetCppThis());
		}

		// Token: 0x06011463 RID: 70755
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXY_ZoomWithMouseWheelOff_76(HandleRef pThis);

		/// <summary>
		/// Set the behavior of the mouse wheel.  If true, the mouse wheel zooms in/out
		/// on the chart.  Otherwise, unless MouseWheelEvent is overridden by a subclass
		/// the mouse wheel does nothing.
		/// The default value is true.
		/// </summary>
		// Token: 0x06011464 RID: 70756 RVA: 0x001811FD File Offset: 0x0017F3FD
		public virtual void ZoomWithMouseWheelOff()
		{
			vtkChartXY.vtkChartXY_ZoomWithMouseWheelOff_76(base.GetCppThis());
		}

		// Token: 0x06011465 RID: 70757
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXY_ZoomWithMouseWheelOn_77(HandleRef pThis);

		/// <summary>
		/// Set the behavior of the mouse wheel.  If true, the mouse wheel zooms in/out
		/// on the chart.  Otherwise, unless MouseWheelEvent is overridden by a subclass
		/// the mouse wheel does nothing.
		/// The default value is true.
		/// </summary>
		// Token: 0x06011466 RID: 70758 RVA: 0x0018120C File Offset: 0x0017F40C
		public virtual void ZoomWithMouseWheelOn()
		{
			vtkChartXY.vtkChartXY_ZoomWithMouseWheelOn_77(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001400 RID: 5120
		public new const string MRFullTypeName = "Kitware.VTK.vtkChartXY";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001401 RID: 5121
		public new static readonly string MRClassNameKey = "class vtkChartXY";
	}
}
