using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkChart
	/// </summary>
	/// <remarks>
	///    Factory class for drawing 2D charts
	///
	///
	/// This defines the interface for a chart.
	/// </remarks>
	// Token: 0x02000635 RID: 1589
	public abstract class vtkChart : vtkContextItem
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011304 RID: 70404 RVA: 0x0017F383 File Offset: 0x0017D583
		static vtkChart()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkChart.MRClassNameKey, Type.GetType("Kitware.VTK.vtkChart"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011305 RID: 70405 RVA: 0x0017F3AB File Offset: 0x0017D5AB
		public vtkChart(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011306 RID: 70406 RVA: 0x0017F3B9 File Offset: 0x0017D5B9
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011307 RID: 70407
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChart_AddPlot_01(HandleRef pThis, int type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Add a plot to the chart, defaults to using the name of the y column
		/// </summary>
		// Token: 0x06011308 RID: 70408 RVA: 0x0017F3C4 File Offset: 0x0017D5C4
		public virtual vtkPlot AddPlot(int type)
		{
			vtkPlot vtkPlot = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChart.vtkChart_AddPlot_01(base.GetCppThis(), type, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06011309 RID: 70409
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkChart_AddPlot_02(HandleRef pThis, HandleRef plot);

		/// <summary>
		/// Add a plot to the chart. Return the index of the plot, -1 if it failed.
		/// </summary>
		// Token: 0x0601130A RID: 70410 RVA: 0x0017F434 File Offset: 0x0017D634
		public virtual long AddPlot(vtkPlot plot)
		{
			return vtkChart.vtkChart_AddPlot_02(base.GetCppThis(), (plot == null) ? default(HandleRef) : plot.GetCppThis());
		}

		// Token: 0x0601130B RID: 70411
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChart_ClearPlots_03(HandleRef pThis);

		/// <summary>
		/// Remove all plots from the chart.
		/// </summary>
		// Token: 0x0601130C RID: 70412 RVA: 0x0017F468 File Offset: 0x0017D668
		public virtual void ClearPlots()
		{
			vtkChart.vtkChart_ClearPlots_03(base.GetCppThis());
		}

		// Token: 0x0601130D RID: 70413
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkChart_GetActionToButton_04(HandleRef pThis, int action);

		/// <summary>
		/// Get the mouse button associated with the supplied action. The mouse button
		/// enum is from vtkContextMouseEvent, and the action enum is from vtkChart.
		/// </summary>
		// Token: 0x0601130E RID: 70414 RVA: 0x0017F478 File Offset: 0x0017D678
		public virtual int GetActionToButton(int action)
		{
			return vtkChart.vtkChart_GetActionToButton_04(base.GetCppThis(), action);
		}

		// Token: 0x0601130F RID: 70415
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChart_GetAnnotationLink_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the vtkAnnotationLink for the chart.
		/// </summary>
		// Token: 0x06011310 RID: 70416 RVA: 0x0017F498 File Offset: 0x0017D698
		public virtual vtkAnnotationLink GetAnnotationLink()
		{
			vtkAnnotationLink vtkAnnotationLink = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChart.vtkChart_GetAnnotationLink_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAnnotationLink = (vtkAnnotationLink)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAnnotationLink.Register(null);
				}
			}
			return vtkAnnotationLink;
		}

		// Token: 0x06011311 RID: 70417
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkChart_GetAutoSize_06(HandleRef pThis);

		/// <summary>
		/// Set/get whether the chart should automatically resize to fill the current
		/// render window. Default is true.
		/// </summary>
		// Token: 0x06011312 RID: 70418 RVA: 0x0017F508 File Offset: 0x0017D708
		public virtual bool GetAutoSize()
		{
			return vtkChart.vtkChart_GetAutoSize_06(base.GetCppThis()) != 0;
		}

		// Token: 0x06011313 RID: 70419
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChart_GetAxis_07(HandleRef pThis, int axisIndex, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the axis specified by axisIndex. 0 is x, 1 is y. This should probably
		/// be improved either using a string or enum to select the axis.
		/// </summary>
		// Token: 0x06011314 RID: 70420 RVA: 0x0017F530 File Offset: 0x0017D730
		public virtual vtkAxis GetAxis(int axisIndex)
		{
			vtkAxis vtkAxis = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChart.vtkChart_GetAxis_07(base.GetCppThis(), axisIndex, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06011315 RID: 70421
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChart_GetBackgroundBrush_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the brush to use for the background color.
		/// </summary>
		// Token: 0x06011316 RID: 70422 RVA: 0x0017F5A0 File Offset: 0x0017D7A0
		public vtkBrush GetBackgroundBrush()
		{
			vtkBrush vtkBrush = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChart.vtkChart_GetBackgroundBrush_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06011317 RID: 70423
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkChart_GetClickActionToButton_09(HandleRef pThis, int action);

		/// <summary>
		/// Get the mouse button associated with the supplied click action. The mouse
		/// button enum is from vtkContextMouseEvent, and the action enum is from
		/// vtkChart.
		/// </summary>
		// Token: 0x06011318 RID: 70424 RVA: 0x0017F610 File Offset: 0x0017D810
		public virtual int GetClickActionToButton(int action)
		{
			return vtkChart.vtkChart_GetClickActionToButton_09(base.GetCppThis(), action);
		}

		// Token: 0x06011319 RID: 70425
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChart_GetGeometry_10(HandleRef pThis);

		/// <summary>
		/// Set/get the width and the height of the chart.
		/// </summary>
		// Token: 0x0601131A RID: 70426 RVA: 0x0017F630 File Offset: 0x0017D830
		public virtual int[] GetGeometry()
		{
			IntPtr intPtr = vtkChart.vtkChart_GetGeometry_10(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601131B RID: 70427
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChart_GetGeometry_11(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Set/get the width and the height of the chart.
		/// </summary>
		// Token: 0x0601131C RID: 70428 RVA: 0x0017F678 File Offset: 0x0017D878
		public virtual void GetGeometry(ref int _arg1, ref int _arg2)
		{
			vtkChart.vtkChart_GetGeometry_11(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x0601131D RID: 70429
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChart_GetGeometry_12(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/get the width and the height of the chart.
		/// </summary>
		// Token: 0x0601131E RID: 70430 RVA: 0x0017F689 File Offset: 0x0017D889
		public virtual void GetGeometry(IntPtr _arg)
		{
			vtkChart.vtkChart_GetGeometry_12(base.GetCppThis(), _arg);
		}

		// Token: 0x0601131F RID: 70431
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkChart_GetLayoutStrategy_13(HandleRef pThis);

		/// <summary>
		/// Set/get the layout strategy that should be used by the chart. As we don't
		/// support enums this can take any value in the integer range, but the only
		/// valid enums are FILL_SCENE, FILL_RECT and AXES_TO_RECT.
		/// </summary>
		// Token: 0x06011320 RID: 70432 RVA: 0x0017F69C File Offset: 0x0017D89C
		public virtual int GetLayoutStrategy()
		{
			return vtkChart.vtkChart_GetLayoutStrategy_13(base.GetCppThis());
		}

		// Token: 0x06011321 RID: 70433
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChart_GetLegend_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the legend for the chart, if available. Can return null if there is no
		/// legend.
		/// </summary>
		// Token: 0x06011322 RID: 70434 RVA: 0x0017F6BC File Offset: 0x0017D8BC
		public virtual vtkChartLegend GetLegend()
		{
			vtkChartLegend vtkChartLegend = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChart.vtkChart_GetLegend_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06011323 RID: 70435
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkChart_GetNumberOfAxes_15(HandleRef pThis);

		/// <summary>
		/// Get the number of axes in the current chart.
		/// </summary>
		// Token: 0x06011324 RID: 70436 RVA: 0x0017F72C File Offset: 0x0017D92C
		public virtual long GetNumberOfAxes()
		{
			return vtkChart.vtkChart_GetNumberOfAxes_15(base.GetCppThis());
		}

		// Token: 0x06011325 RID: 70437
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkChart_GetNumberOfGenerationsFromBase_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011326 RID: 70438 RVA: 0x0017F74C File Offset: 0x0017D94C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkChart.vtkChart_GetNumberOfGenerationsFromBase_16(base.GetCppThis(), type);
		}

		// Token: 0x06011327 RID: 70439
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkChart_GetNumberOfGenerationsFromBaseType_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011328 RID: 70440 RVA: 0x0017F76C File Offset: 0x0017D96C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkChart.vtkChart_GetNumberOfGenerationsFromBaseType_17(type);
		}

		// Token: 0x06011329 RID: 70441
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkChart_GetNumberOfPlots_18(HandleRef pThis);

		/// <summary>
		/// Get the number of plots the chart contains.
		/// </summary>
		// Token: 0x0601132A RID: 70442 RVA: 0x0017F788 File Offset: 0x0017D988
		public virtual long GetNumberOfPlots()
		{
			return vtkChart.vtkChart_GetNumberOfPlots_18(base.GetCppThis());
		}

		// Token: 0x0601132B RID: 70443
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChart_GetPlot_19(HandleRef pThis, long index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the plot at the specified index, returns null if the index is invalid.
		/// </summary>
		// Token: 0x0601132C RID: 70444 RVA: 0x0017F7A8 File Offset: 0x0017D9A8
		public virtual vtkPlot GetPlot(long index)
		{
			vtkPlot vtkPlot = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChart.vtkChart_GetPlot_19(base.GetCppThis(), index, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601132D RID: 70445
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChart_GetPoint1_20(HandleRef pThis);

		/// <summary>
		/// Set/get the first point in the chart (the bottom left).
		/// </summary>
		// Token: 0x0601132E RID: 70446 RVA: 0x0017F818 File Offset: 0x0017DA18
		public virtual int[] GetPoint1()
		{
			IntPtr intPtr = vtkChart.vtkChart_GetPoint1_20(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601132F RID: 70447
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChart_GetPoint1_21(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Set/get the first point in the chart (the bottom left).
		/// </summary>
		// Token: 0x06011330 RID: 70448 RVA: 0x0017F860 File Offset: 0x0017DA60
		public virtual void GetPoint1(ref int _arg1, ref int _arg2)
		{
			vtkChart.vtkChart_GetPoint1_21(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06011331 RID: 70449
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChart_GetPoint1_22(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/get the first point in the chart (the bottom left).
		/// </summary>
		// Token: 0x06011332 RID: 70450 RVA: 0x0017F871 File Offset: 0x0017DA71
		public virtual void GetPoint1(IntPtr _arg)
		{
			vtkChart.vtkChart_GetPoint1_22(base.GetCppThis(), _arg);
		}

		// Token: 0x06011333 RID: 70451
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChart_GetPoint2_23(HandleRef pThis);

		/// <summary>
		/// Set/get the second point in the chart (the top right).
		/// </summary>
		// Token: 0x06011334 RID: 70452 RVA: 0x0017F884 File Offset: 0x0017DA84
		public virtual int[] GetPoint2()
		{
			IntPtr intPtr = vtkChart.vtkChart_GetPoint2_23(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06011335 RID: 70453
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChart_GetPoint2_24(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Set/get the second point in the chart (the top right).
		/// </summary>
		// Token: 0x06011336 RID: 70454 RVA: 0x0017F8CC File Offset: 0x0017DACC
		public virtual void GetPoint2(ref int _arg1, ref int _arg2)
		{
			vtkChart.vtkChart_GetPoint2_24(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06011337 RID: 70455
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChart_GetPoint2_25(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/get the second point in the chart (the top right).
		/// </summary>
		// Token: 0x06011338 RID: 70456 RVA: 0x0017F8DD File Offset: 0x0017DADD
		public virtual void GetPoint2(IntPtr _arg)
		{
			vtkChart.vtkChart_GetPoint2_25(base.GetCppThis(), _arg);
		}

		// Token: 0x06011339 RID: 70457
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkChart_GetRenderEmpty_26(HandleRef pThis);

		/// <summary>
		/// Set/get whether the chart should still render its axes and decorations
		/// even if the chart has no visible plots. Default is false (do not render
		/// an empty plot).
		///
		/// Note that if you wish to render axes for an empty plot you should also
		/// set AutoSize to false, as that will hide all axes for an empty plot.
		/// </summary>
		// Token: 0x0601133A RID: 70458 RVA: 0x0017F8F0 File Offset: 0x0017DAF0
		public virtual bool GetRenderEmpty()
		{
			return vtkChart.vtkChart_GetRenderEmpty_26(base.GetCppThis()) != 0;
		}

		// Token: 0x0601133B RID: 70459
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkChart_GetSelectionMethod_27(HandleRef pThis);

		/// <summary>
		/// Set the selection method, which controls how selections are handled by the
		/// chart. The default is SELECTION_ROWS which selects all points in all plots
		/// in a chart that have values in the rows selected. SELECTION_PLOTS allows
		/// for finer-grained selections specific to each plot, and so to each XY
		/// column pair. SELECTION_COLUMNS selects all points of plots that
		/// correspond to selected columns.
		/// </summary>
		// Token: 0x0601133C RID: 70460 RVA: 0x0017F918 File Offset: 0x0017DB18
		public virtual int GetSelectionMethod()
		{
			return vtkChart.vtkChart_GetSelectionMethod_27(base.GetCppThis());
		}

		// Token: 0x0601133D RID: 70461
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkChart_GetSelectionMode_28(HandleRef pThis);

		/// <summary>
		/// Set/get the Selection Mode that will be used by the chart while doing
		/// selection. The only valid enums are vtkContextScene::SelectionModifier.
		/// </summary>
		// Token: 0x0601133E RID: 70462 RVA: 0x0017F938 File Offset: 0x0017DB38
		public virtual int GetSelectionMode()
		{
			return vtkChart.vtkChart_GetSelectionMode_28(base.GetCppThis());
		}

		// Token: 0x0601133F RID: 70463
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkChart_GetSelectionModeMaxValue_29(HandleRef pThis);

		/// <summary>
		/// Set/get the Selection Mode that will be used by the chart while doing
		/// selection. The only valid enums are vtkContextScene::SelectionModifier.
		/// </summary>
		// Token: 0x06011340 RID: 70464 RVA: 0x0017F958 File Offset: 0x0017DB58
		public virtual int GetSelectionModeMaxValue()
		{
			return vtkChart.vtkChart_GetSelectionModeMaxValue_29(base.GetCppThis());
		}

		// Token: 0x06011341 RID: 70465
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkChart_GetSelectionModeMinValue_30(HandleRef pThis);

		/// <summary>
		/// Set/get the Selection Mode that will be used by the chart while doing
		/// selection. The only valid enums are vtkContextScene::SelectionModifier.
		/// </summary>
		// Token: 0x06011342 RID: 70466 RVA: 0x0017F978 File Offset: 0x0017DB78
		public virtual int GetSelectionModeMinValue()
		{
			return vtkChart.vtkChart_GetSelectionModeMinValue_30(base.GetCppThis());
		}

		// Token: 0x06011343 RID: 70467
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkChart_GetShowLegend_31(HandleRef pThis);

		/// <summary>
		/// Set/get whether the chart should draw a legend.
		/// </summary>
		// Token: 0x06011344 RID: 70468 RVA: 0x0017F998 File Offset: 0x0017DB98
		public virtual bool GetShowLegend()
		{
			return vtkChart.vtkChart_GetShowLegend_31(base.GetCppThis()) != 0;
		}

		// Token: 0x06011345 RID: 70469
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChart_GetSize_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the current size of the chart.
		/// </summary>
		// Token: 0x06011346 RID: 70470 RVA: 0x0017F9C0 File Offset: 0x0017DBC0
		public vtkRectf GetSize()
		{
			vtkRectf result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChart.vtkChart_GetSize_32(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRectf)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011347 RID: 70471
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkChart_GetTitle_33(HandleRef pThis);

		/// <summary>
		/// Get/set the title text of the chart.
		/// </summary>
		// Token: 0x06011348 RID: 70472 RVA: 0x0017FA1C File Offset: 0x0017DC1C
		public virtual string GetTitle()
		{
			return vtkChart.vtkChart_GetTitle_33(base.GetCppThis());
		}

		// Token: 0x06011349 RID: 70473
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChart_GetTitleProperties_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the vtkTextProperty that governs how the chart title is displayed.
		/// </summary>
		// Token: 0x0601134A RID: 70474 RVA: 0x0017FA3C File Offset: 0x0017DC3C
		public virtual vtkTextProperty GetTitleProperties()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChart.vtkChart_GetTitleProperties_34(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		// Token: 0x0601134B RID: 70475
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkChart_IsA_35(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601134C RID: 70476 RVA: 0x0017FAAC File Offset: 0x0017DCAC
		public override int IsA(string type)
		{
			return vtkChart.vtkChart_IsA_35(base.GetCppThis(), type);
		}

		// Token: 0x0601134D RID: 70477
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkChart_IsTypeOf_36([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601134E RID: 70478 RVA: 0x0017FACC File Offset: 0x0017DCCC
		public new static int IsTypeOf(string type)
		{
			return vtkChart.vtkChart_IsTypeOf_36(type);
		}

		// Token: 0x0601134F RID: 70479
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChart_NewInstance_37(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011350 RID: 70480 RVA: 0x0017FAE8 File Offset: 0x0017DCE8
		public new vtkChart NewInstance()
		{
			vtkChart result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChart.vtkChart_NewInstance_37(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkChart)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011351 RID: 70481
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkChart_Paint_38(HandleRef pThis, HandleRef painter);

		/// <summary>
		/// Paint event for the chart, called whenever the chart needs to be drawn
		/// </summary>
		// Token: 0x06011352 RID: 70482 RVA: 0x0017FB44 File Offset: 0x0017DD44
		public override bool Paint(vtkContext2D painter)
		{
			return vtkChart.vtkChart_Paint_38(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		// Token: 0x06011353 RID: 70483
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChart_RecalculateBounds_39(HandleRef pThis);

		/// <summary>
		/// Request that the chart recalculates the range of its axes. Especially
		/// useful in applications after the parameters of plots have been modified.
		/// </summary>
		// Token: 0x06011354 RID: 70484 RVA: 0x0017FB7F File Offset: 0x0017DD7F
		public virtual void RecalculateBounds()
		{
			vtkChart.vtkChart_RecalculateBounds_39(base.GetCppThis());
		}

		// Token: 0x06011355 RID: 70485
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkChart_RemovePlot_40(HandleRef pThis, long index);

		/// <summary>
		/// Remove the plot at the specified index, returns true if successful,
		/// false if the index was invalid.
		/// </summary>
		// Token: 0x06011356 RID: 70486 RVA: 0x0017FB90 File Offset: 0x0017DD90
		public virtual bool RemovePlot(long index)
		{
			return vtkChart.vtkChart_RemovePlot_40(base.GetCppThis(), index) != 0;
		}

		// Token: 0x06011357 RID: 70487
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkChart_RemovePlotInstance_41(HandleRef pThis, HandleRef plot);

		/// <summary>
		/// Remove the given plot.  Returns true if successful, false if the plot
		/// was not contained in this chart.  Note, the base implementation of
		/// this method performs a linear search to locate the plot.
		/// </summary>
		// Token: 0x06011358 RID: 70488 RVA: 0x0017FBB8 File Offset: 0x0017DDB8
		public virtual bool RemovePlotInstance(vtkPlot plot)
		{
			return vtkChart.vtkChart_RemovePlotInstance_41(base.GetCppThis(), (plot == null) ? default(HandleRef) : plot.GetCppThis()) != 0;
		}

		// Token: 0x06011359 RID: 70489
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChart_SafeDownCast_42(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601135A RID: 70490 RVA: 0x0017FBF4 File Offset: 0x0017DDF4
		public new static vtkChart SafeDownCast(vtkObjectBase o)
		{
			vtkChart vtkChart = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChart.vtkChart_SafeDownCast_42((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkChart = (vtkChart)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkChart.Register(null);
				}
			}
			return vtkChart;
		}

		// Token: 0x0601135B RID: 70491
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChart_SetActionToButton_43(HandleRef pThis, int action, int button);

		/// <summary>
		/// Assign action types to mouse buttons. Available action types are PAN, ZOOM
		/// and SELECT in the chart enum, the default assigns the LEFT_BUTTON to
		/// PAN, MIDDLE_BUTTON to ZOOM and RIGHT_BUTTON to SELECT. Valid mouse enums
		/// are in the vtkContextMouseEvent class.
		///
		/// Note that only one mouse button can be assigned to each action, an action
		/// will have -1 (invalid button) assigned if it had the same button as the one
		/// assigned to a different action.
		/// </summary>
		// Token: 0x0601135C RID: 70492 RVA: 0x0017FC73 File Offset: 0x0017DE73
		public virtual void SetActionToButton(int action, int button)
		{
			vtkChart.vtkChart_SetActionToButton_43(base.GetCppThis(), action, button);
		}

		// Token: 0x0601135D RID: 70493
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChart_SetAnnotationLink_44(HandleRef pThis, HandleRef link);

		/// <summary>
		/// Set the vtkAnnotationLink for the chart.
		/// </summary>
		// Token: 0x0601135E RID: 70494 RVA: 0x0017FC84 File Offset: 0x0017DE84
		public virtual void SetAnnotationLink(vtkAnnotationLink link)
		{
			vtkChart.vtkChart_SetAnnotationLink_44(base.GetCppThis(), (link == null) ? default(HandleRef) : link.GetCppThis());
		}

		// Token: 0x0601135F RID: 70495
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChart_SetAutoSize_45(HandleRef pThis, byte isAutoSized);

		/// <summary>
		/// Set/get whether the chart should automatically resize to fill the current
		/// render window. Default is true.
		/// </summary>
		// Token: 0x06011360 RID: 70496 RVA: 0x0017FCB3 File Offset: 0x0017DEB3
		public virtual void SetAutoSize(bool isAutoSized)
		{
			vtkChart.vtkChart_SetAutoSize_45(base.GetCppThis(), isAutoSized ? (byte)1 : (byte)0);
		}

		// Token: 0x06011361 RID: 70497
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChart_SetAxis_46(HandleRef pThis, int axisIndex, HandleRef arg1);

		/// <summary>
		/// Set the axis specified by axisIndex. 0 is x, 1 is y. This should probably
		/// be improved either using a string or enum to select the axis.
		/// </summary>
		// Token: 0x06011362 RID: 70498 RVA: 0x0017FCCC File Offset: 0x0017DECC
		public virtual void SetAxis(int axisIndex, vtkAxis arg1)
		{
			vtkChart.vtkChart_SetAxis_46(base.GetCppThis(), axisIndex, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x06011363 RID: 70499
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChart_SetBackgroundBrush_47(HandleRef pThis, HandleRef brush);

		/// <summary>
		/// Set/Get the brush to use for the background color.
		/// </summary>
		// Token: 0x06011364 RID: 70500 RVA: 0x0017FCFC File Offset: 0x0017DEFC
		public void SetBackgroundBrush(vtkBrush brush)
		{
			vtkChart.vtkChart_SetBackgroundBrush_47(base.GetCppThis(), (brush == null) ? default(HandleRef) : brush.GetCppThis());
		}

		// Token: 0x06011365 RID: 70501
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChart_SetBorders_48(HandleRef pThis, int left, int bottom, int right, int top);

		/// <summary>
		/// Set/get the borders of the chart (space in pixels around the chart).
		/// </summary>
		// Token: 0x06011366 RID: 70502 RVA: 0x0017FD2B File Offset: 0x0017DF2B
		public void SetBorders(int left, int bottom, int right, int top)
		{
			vtkChart.vtkChart_SetBorders_48(base.GetCppThis(), left, bottom, right, top);
		}

		// Token: 0x06011367 RID: 70503
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChart_SetBottomBorder_49(HandleRef pThis, int border);

		/// <summary>
		/// Set/get the borders of the chart (space in pixels around the chart).
		/// </summary>
		// Token: 0x06011368 RID: 70504 RVA: 0x0017FD3F File Offset: 0x0017DF3F
		public void SetBottomBorder(int border)
		{
			vtkChart.vtkChart_SetBottomBorder_49(base.GetCppThis(), border);
		}

		// Token: 0x06011369 RID: 70505
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChart_SetClickActionToButton_50(HandleRef pThis, int action, int button);

		/// <summary>
		/// Assign action types to single mouse clicks. Available action types are
		/// SELECT and NOTIFY in the chart enum. The default assigns the LEFT_BUTTON
		/// to NOTIFY, and the RIGHT_BUTTON to SELECT.
		/// </summary>
		// Token: 0x0601136A RID: 70506 RVA: 0x0017FD4F File Offset: 0x0017DF4F
		public virtual void SetClickActionToButton(int action, int button)
		{
			vtkChart.vtkChart_SetClickActionToButton_50(base.GetCppThis(), action, button);
		}

		// Token: 0x0601136B RID: 70507
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChart_SetGeometry_51(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Set/get the width and the height of the chart.
		/// </summary>
		// Token: 0x0601136C RID: 70508 RVA: 0x0017FD60 File Offset: 0x0017DF60
		public virtual void SetGeometry(int _arg1, int _arg2)
		{
			vtkChart.vtkChart_SetGeometry_51(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0601136D RID: 70509
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChart_SetGeometry_52(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/get the width and the height of the chart.
		/// </summary>
		// Token: 0x0601136E RID: 70510 RVA: 0x0017FD71 File Offset: 0x0017DF71
		public void SetGeometry(IntPtr _arg)
		{
			vtkChart.vtkChart_SetGeometry_52(base.GetCppThis(), _arg);
		}

		// Token: 0x0601136F RID: 70511
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChart_SetLayoutStrategy_53(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the layout strategy that should be used by the chart. As we don't
		/// support enums this can take any value in the integer range, but the only
		/// valid enums are FILL_SCENE, FILL_RECT and AXES_TO_RECT.
		/// </summary>
		// Token: 0x06011370 RID: 70512 RVA: 0x0017FD81 File Offset: 0x0017DF81
		public virtual void SetLayoutStrategy(int _arg)
		{
			vtkChart.vtkChart_SetLayoutStrategy_53(base.GetCppThis(), _arg);
		}

		// Token: 0x06011371 RID: 70513
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChart_SetLeftBorder_54(HandleRef pThis, int border);

		/// <summary>
		/// Set/get the borders of the chart (space in pixels around the chart).
		/// </summary>
		// Token: 0x06011372 RID: 70514 RVA: 0x0017FD91 File Offset: 0x0017DF91
		public void SetLeftBorder(int border)
		{
			vtkChart.vtkChart_SetLeftBorder_54(base.GetCppThis(), border);
		}

		// Token: 0x06011373 RID: 70515
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChart_SetPoint1_55(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Set/get the first point in the chart (the bottom left).
		/// </summary>
		// Token: 0x06011374 RID: 70516 RVA: 0x0017FDA1 File Offset: 0x0017DFA1
		public virtual void SetPoint1(int _arg1, int _arg2)
		{
			vtkChart.vtkChart_SetPoint1_55(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x06011375 RID: 70517
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChart_SetPoint1_56(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/get the first point in the chart (the bottom left).
		/// </summary>
		// Token: 0x06011376 RID: 70518 RVA: 0x0017FDB2 File Offset: 0x0017DFB2
		public void SetPoint1(IntPtr _arg)
		{
			vtkChart.vtkChart_SetPoint1_56(base.GetCppThis(), _arg);
		}

		// Token: 0x06011377 RID: 70519
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChart_SetPoint2_57(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Set/get the second point in the chart (the top right).
		/// </summary>
		// Token: 0x06011378 RID: 70520 RVA: 0x0017FDC2 File Offset: 0x0017DFC2
		public virtual void SetPoint2(int _arg1, int _arg2)
		{
			vtkChart.vtkChart_SetPoint2_57(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x06011379 RID: 70521
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChart_SetPoint2_58(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/get the second point in the chart (the top right).
		/// </summary>
		// Token: 0x0601137A RID: 70522 RVA: 0x0017FDD3 File Offset: 0x0017DFD3
		public void SetPoint2(IntPtr _arg)
		{
			vtkChart.vtkChart_SetPoint2_58(base.GetCppThis(), _arg);
		}

		// Token: 0x0601137B RID: 70523
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChart_SetRenderEmpty_59(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/get whether the chart should still render its axes and decorations
		/// even if the chart has no visible plots. Default is false (do not render
		/// an empty plot).
		///
		/// Note that if you wish to render axes for an empty plot you should also
		/// set AutoSize to false, as that will hide all axes for an empty plot.
		/// </summary>
		// Token: 0x0601137C RID: 70524 RVA: 0x0017FDE3 File Offset: 0x0017DFE3
		public virtual void SetRenderEmpty(bool _arg)
		{
			vtkChart.vtkChart_SetRenderEmpty_59(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0601137D RID: 70525
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChart_SetRightBorder_60(HandleRef pThis, int border);

		/// <summary>
		/// Set/get the borders of the chart (space in pixels around the chart).
		/// </summary>
		// Token: 0x0601137E RID: 70526 RVA: 0x0017FDFB File Offset: 0x0017DFFB
		public void SetRightBorder(int border)
		{
			vtkChart.vtkChart_SetRightBorder_60(base.GetCppThis(), border);
		}

		// Token: 0x0601137F RID: 70527
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChart_SetSelectionMethod_61(HandleRef pThis, int method);

		/// <summary>
		/// Set the selection method, which controls how selections are handled by the
		/// chart. The default is SELECTION_ROWS which selects all points in all plots
		/// in a chart that have values in the rows selected. SELECTION_PLOTS allows
		/// for finer-grained selections specific to each plot, and so to each XY
		/// column pair. SELECTION_COLUMNS selects all points of plots that
		/// correspond to selected columns.
		/// </summary>
		// Token: 0x06011380 RID: 70528 RVA: 0x0017FE0B File Offset: 0x0017E00B
		public virtual void SetSelectionMethod(int method)
		{
			vtkChart.vtkChart_SetSelectionMethod_61(base.GetCppThis(), method);
		}

		// Token: 0x06011381 RID: 70529
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChart_SetSelectionMode_62(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the Selection Mode that will be used by the chart while doing
		/// selection. The only valid enums are vtkContextScene::SelectionModifier.
		/// </summary>
		// Token: 0x06011382 RID: 70530 RVA: 0x0017FE1B File Offset: 0x0017E01B
		public virtual void SetSelectionMode(int _arg)
		{
			vtkChart.vtkChart_SetSelectionMode_62(base.GetCppThis(), _arg);
		}

		// Token: 0x06011383 RID: 70531
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChart_SetShowLegend_63(HandleRef pThis, byte visible);

		/// <summary>
		/// Set/get whether the chart should draw a legend.
		/// </summary>
		// Token: 0x06011384 RID: 70532 RVA: 0x0017FE2B File Offset: 0x0017E02B
		public virtual void SetShowLegend(bool visible)
		{
			vtkChart.vtkChart_SetShowLegend_63(base.GetCppThis(), visible ? (byte)1 : (byte)0);
		}

		// Token: 0x06011385 RID: 70533
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChart_SetSize_64(HandleRef pThis, HandleRef rect);

		/// <summary>
		/// Set the size of the chart. The rect argument specifies the bottom corner,
		/// width and height of the chart. The borders will be laid out within the
		/// specified rectangle.
		/// </summary>
		// Token: 0x06011386 RID: 70534 RVA: 0x0017FE44 File Offset: 0x0017E044
		public virtual void SetSize(vtkRectf rect)
		{
			vtkChart.vtkChart_SetSize_64(base.GetCppThis(), (rect == null) ? default(HandleRef) : rect.GetCppThis());
		}

		// Token: 0x06011387 RID: 70535
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChart_SetTitle_65(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string title);

		/// <summary>
		/// Get/set the title text of the chart.
		/// </summary>
		// Token: 0x06011388 RID: 70536 RVA: 0x0017FE73 File Offset: 0x0017E073
		public virtual void SetTitle(string title)
		{
			vtkChart.vtkChart_SetTitle_65(base.GetCppThis(), title);
		}

		// Token: 0x06011389 RID: 70537
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChart_SetTopBorder_66(HandleRef pThis, int border);

		/// <summary>
		/// Set/get the borders of the chart (space in pixels around the chart).
		/// </summary>
		// Token: 0x0601138A RID: 70538 RVA: 0x0017FE83 File Offset: 0x0017E083
		public void SetTopBorder(int border)
		{
			vtkChart.vtkChart_SetTopBorder_66(base.GetCppThis(), border);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040013E0 RID: 5088
		public new const string MRFullTypeName = "Kitware.VTK.vtkChart";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040013E1 RID: 5089
		public new static readonly string MRClassNameKey = "class vtkChart";

		/// <summary>
		/// Enum of the available chart types
		/// </summary>
		// Token: 0x02000636 RID: 1590
		public enum AREA_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x040013E3 RID: 5091
			AREA = 6,
			/// <summary>enum member</summary>
			// Token: 0x040013E4 RID: 5092
			BAG = 4,
			/// <summary>enum member</summary>
			// Token: 0x040013E5 RID: 5093
			BAR = 2,
			/// <summary>enum member</summary>
			// Token: 0x040013E6 RID: 5094
			FUNCTIONALBAG = 5,
			/// <summary>enum member</summary>
			// Token: 0x040013E7 RID: 5095
			LINE = 0,
			/// <summary>enum member</summary>
			// Token: 0x040013E8 RID: 5096
			POINTS,
			/// <summary>enum member</summary>
			// Token: 0x040013E9 RID: 5097
			STACKED = 3
		}

		/// <summary>
		/// Enum of valid chart action types.
		///
		/// PAN - moves the axis range
		/// ZOOM - zooms to a selected rectangle
		/// ZOOM_AXIS - zooms the x and y axis range
		/// SELECT_RECTANGLE - selects points within a rectangle
		/// SELECT_POLYGON - selects points within a polygon
		/// SELECT - alias for SELECT_RECTANGLE
		/// CLICKANDDRAG - move one point selected by a click
		/// NOTIFY - Post vtkCommand::InteractionEvent on selection of a point
		/// ACTION_TYPES_COUNT - total action types count (needed in ParaView,
		/// see `pqChartSelectionReaction.h`)
		/// </summary>
		// Token: 0x02000637 RID: 1591
		public enum ACTION_TYPES_COUNT_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x040013EB RID: 5099
			ACTION_TYPES_COUNT = 7,
			/// <summary>enum member</summary>
			// Token: 0x040013EC RID: 5100
			CLICK_AND_DRAG = 5,
			/// <summary>enum member</summary>
			// Token: 0x040013ED RID: 5101
			NOTIFY,
			/// <summary>enum member</summary>
			// Token: 0x040013EE RID: 5102
			PAN = 0,
			/// <summary>enum member</summary>
			// Token: 0x040013EF RID: 5103
			SELECT = 3,
			/// <summary>enum member</summary>
			// Token: 0x040013F0 RID: 5104
			SELECT_POLYGON,
			/// <summary>enum member</summary>
			// Token: 0x040013F1 RID: 5105
			SELECT_RECTANGLE = 3,
			/// <summary>enum member</summary>
			// Token: 0x040013F2 RID: 5106
			ZOOM = 1,
			/// <summary>enum member</summary>
			// Token: 0x040013F3 RID: 5107
			ZOOM_AXIS
		}

		/// <summary>
		/// Enumeration of the possible selection methods in a chart. SELECTION_ROWS
		/// is the default and simply selects the row in a table in all plots showing
		/// that table. SELECTION_PLOTS will make a selection in each plot, and that
		/// selection remains specific to the plot object. SELECTION_COLUMNS selects
		/// the plots that use as input the selected columns of a table.
		/// </summary>
		// Token: 0x02000638 RID: 1592
		public enum SELECTION_COLUMNS_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x040013F5 RID: 5109
			SELECTION_COLUMNS = 2,
			/// <summary>enum member</summary>
			// Token: 0x040013F6 RID: 5110
			SELECTION_PLOTS = 1,
			/// <summary>enum member</summary>
			// Token: 0x040013F7 RID: 5111
			SELECTION_ROWS = 0
		}

		/// <summary>
		/// Enum of the available layout strategies for the charts.
		/// </summary>
		// Token: 0x02000639 RID: 1593
		public enum AXES_TO_RECT_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x040013F9 RID: 5113
			AXES_TO_RECT = 2,
			/// <summary>enum member</summary>
			// Token: 0x040013FA RID: 5114
			FILL_RECT = 1,
			/// <summary>enum member</summary>
			// Token: 0x040013FB RID: 5115
			FILL_SCENE = 0
		}

		/// <summary>
		/// Enum of event type that are triggered by the charts
		/// </summary>
		// Token: 0x0200063A RID: 1594
		public enum EventIds
		{
			/// <summary>enum member</summary>
			// Token: 0x040013FD RID: 5117
			UpdateRange = 1002
		}
	}
}
