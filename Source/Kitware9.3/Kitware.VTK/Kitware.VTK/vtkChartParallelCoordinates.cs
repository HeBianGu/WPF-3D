using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkChartParallelCoordinates
	/// </summary>
	/// <remarks>
	///    Factory class for drawing 2D charts
	///
	///
	/// This defines the interface for a parallel coordinates chart.
	/// </remarks>
	// Token: 0x02000640 RID: 1600
	public class vtkChartParallelCoordinates : vtkChart
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060114EF RID: 70895 RVA: 0x001820A0 File Offset: 0x001802A0
		static vtkChartParallelCoordinates()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkChartParallelCoordinates.MRClassNameKey, Type.GetType("Kitware.VTK.vtkChartParallelCoordinates"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060114F0 RID: 70896 RVA: 0x001820C8 File Offset: 0x001802C8
		public vtkChartParallelCoordinates(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060114F1 RID: 70897
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartParallelCoordinates_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates a parallel coordinates chart
		/// </summary>
		// Token: 0x060114F2 RID: 70898 RVA: 0x001820D8 File Offset: 0x001802D8
		public new static vtkChartParallelCoordinates New()
		{
			vtkChartParallelCoordinates result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartParallelCoordinates.vtkChartParallelCoordinates_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkChartParallelCoordinates)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Creates a parallel coordinates chart
		/// </summary>
		// Token: 0x060114F3 RID: 70899 RVA: 0x0018212C File Offset: 0x0018032C
		public vtkChartParallelCoordinates() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkChartParallelCoordinates.vtkChartParallelCoordinates_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060114F4 RID: 70900 RVA: 0x00182170 File Offset: 0x00180370
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060114F5 RID: 70901
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartParallelCoordinates_GetAxis_01(HandleRef pThis, int axisIndex, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the axis specified by axisIndex.
		/// </summary>
		// Token: 0x060114F6 RID: 70902 RVA: 0x0018217C File Offset: 0x0018037C
		public override vtkAxis GetAxis(int axisIndex)
		{
			vtkAxis vtkAxis = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartParallelCoordinates.vtkChartParallelCoordinates_GetAxis_01(base.GetCppThis(), axisIndex, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060114F7 RID: 70903
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkChartParallelCoordinates_GetColumnVisibility_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Get the visibility of the specified column.
		/// </summary>
		// Token: 0x060114F8 RID: 70904 RVA: 0x001821EC File Offset: 0x001803EC
		public bool GetColumnVisibility(string name)
		{
			return vtkChartParallelCoordinates.vtkChartParallelCoordinates_GetColumnVisibility_02(base.GetCppThis(), name) != 0;
		}

		// Token: 0x060114F9 RID: 70905
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartParallelCoordinates_GetLegend_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the legend for the chart, if available. Can return nullptr if there is no
		/// legend.
		/// </summary>
		// Token: 0x060114FA RID: 70906 RVA: 0x00182214 File Offset: 0x00180414
		public override vtkChartLegend GetLegend()
		{
			vtkChartLegend vtkChartLegend = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartParallelCoordinates.vtkChartParallelCoordinates_GetLegend_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060114FB RID: 70907
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkChartParallelCoordinates_GetNumberOfAxes_04(HandleRef pThis);

		/// <summary>
		/// Get the number of axes in the current chart.
		/// </summary>
		// Token: 0x060114FC RID: 70908 RVA: 0x00182284 File Offset: 0x00180484
		public override long GetNumberOfAxes()
		{
			return vtkChartParallelCoordinates.vtkChartParallelCoordinates_GetNumberOfAxes_04(base.GetCppThis());
		}

		// Token: 0x060114FD RID: 70909
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkChartParallelCoordinates_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060114FE RID: 70910 RVA: 0x001822A4 File Offset: 0x001804A4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkChartParallelCoordinates.vtkChartParallelCoordinates_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x060114FF RID: 70911
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkChartParallelCoordinates_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011500 RID: 70912 RVA: 0x001822C4 File Offset: 0x001804C4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkChartParallelCoordinates.vtkChartParallelCoordinates_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06011501 RID: 70913
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkChartParallelCoordinates_GetNumberOfPlots_07(HandleRef pThis);

		/// <summary>
		/// Get the number of plots the chart contains.
		/// </summary>
		// Token: 0x06011502 RID: 70914 RVA: 0x001822E0 File Offset: 0x001804E0
		public override long GetNumberOfPlots()
		{
			return vtkChartParallelCoordinates.vtkChartParallelCoordinates_GetNumberOfPlots_07(base.GetCppThis());
		}

		// Token: 0x06011503 RID: 70915
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartParallelCoordinates_GetPlot_08(HandleRef pThis, long index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the plot at the specified index, returns null if the index is invalid.
		/// </summary>
		// Token: 0x06011504 RID: 70916 RVA: 0x00182300 File Offset: 0x00180500
		public override vtkPlot GetPlot(long index)
		{
			vtkPlot vtkPlot = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartParallelCoordinates.vtkChartParallelCoordinates_GetPlot_08(base.GetCppThis(), index, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06011505 RID: 70917
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartParallelCoordinates_GetVisibleColumns_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get a list of the columns, and the order in which they are displayed.
		/// </summary>
		// Token: 0x06011506 RID: 70918 RVA: 0x00182370 File Offset: 0x00180570
		public virtual vtkStringArray GetVisibleColumns()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartParallelCoordinates.vtkChartParallelCoordinates_GetVisibleColumns_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06011507 RID: 70919
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkChartParallelCoordinates_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011508 RID: 70920 RVA: 0x001823E0 File Offset: 0x001805E0
		public override int IsA(string type)
		{
			return vtkChartParallelCoordinates.vtkChartParallelCoordinates_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x06011509 RID: 70921
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkChartParallelCoordinates_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601150A RID: 70922 RVA: 0x00182400 File Offset: 0x00180600
		public new static int IsTypeOf(string type)
		{
			return vtkChartParallelCoordinates.vtkChartParallelCoordinates_IsTypeOf_11(type);
		}

		// Token: 0x0601150B RID: 70923
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartParallelCoordinates_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601150C RID: 70924 RVA: 0x0018241C File Offset: 0x0018061C
		public new vtkChartParallelCoordinates NewInstance()
		{
			vtkChartParallelCoordinates result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartParallelCoordinates.vtkChartParallelCoordinates_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkChartParallelCoordinates)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601150D RID: 70925
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkChartParallelCoordinates_Paint_14(HandleRef pThis, HandleRef painter);

		/// <summary>
		/// Paint event for the chart, called whenever the chart needs to be drawn
		/// </summary>
		// Token: 0x0601150E RID: 70926 RVA: 0x00182478 File Offset: 0x00180678
		public override bool Paint(vtkContext2D painter)
		{
			return vtkChartParallelCoordinates.vtkChartParallelCoordinates_Paint_14(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		// Token: 0x0601150F RID: 70927
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkChartParallelCoordinates_PaintRect_15(HandleRef pThis, HandleRef painter, int axis, float min, float max);

		/// <summary>
		/// Draw a rect on a specific axis
		/// </summary>
		// Token: 0x06011510 RID: 70928 RVA: 0x001824B4 File Offset: 0x001806B4
		public bool PaintRect(vtkContext2D painter, int axis, float min, float max)
		{
			return vtkChartParallelCoordinates.vtkChartParallelCoordinates_PaintRect_15(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis(), axis, min, max) != 0;
		}

		// Token: 0x06011511 RID: 70929
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartParallelCoordinates_RecalculateBounds_16(HandleRef pThis);

		/// <summary>
		/// Request that the chart recalculates the range of its axes. Especially
		/// useful in applications after the parameters of plots have been modified.
		/// </summary>
		// Token: 0x06011512 RID: 70930 RVA: 0x001824F3 File Offset: 0x001806F3
		public override void RecalculateBounds()
		{
			vtkChartParallelCoordinates.vtkChartParallelCoordinates_RecalculateBounds_16(base.GetCppThis());
		}

		// Token: 0x06011513 RID: 70931
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartParallelCoordinates_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011514 RID: 70932 RVA: 0x00182504 File Offset: 0x00180704
		public new static vtkChartParallelCoordinates SafeDownCast(vtkObjectBase o)
		{
			vtkChartParallelCoordinates vtkChartParallelCoordinates = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartParallelCoordinates.vtkChartParallelCoordinates_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkChartParallelCoordinates = (vtkChartParallelCoordinates)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkChartParallelCoordinates.Register(null);
				}
			}
			return vtkChartParallelCoordinates;
		}

		// Token: 0x06011515 RID: 70933
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartParallelCoordinates_SetColumnVisibility_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, byte visible);

		/// <summary>
		/// Set the visibility of the specified column.
		/// </summary>
		// Token: 0x06011516 RID: 70934 RVA: 0x00182583 File Offset: 0x00180783
		public void SetColumnVisibility(string name, bool visible)
		{
			vtkChartParallelCoordinates.vtkChartParallelCoordinates_SetColumnVisibility_18(base.GetCppThis(), name, visible ? (byte)1 : (byte)0);
		}

		// Token: 0x06011517 RID: 70935
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartParallelCoordinates_SetColumnVisibilityAll_19(HandleRef pThis, byte visible);

		/// <summary>
		/// Set the visibility of all columns (true will make them all visible, false
		/// will remove all visible columns).
		/// </summary>
		// Token: 0x06011518 RID: 70936 RVA: 0x0018259C File Offset: 0x0018079C
		public void SetColumnVisibilityAll(bool visible)
		{
			vtkChartParallelCoordinates.vtkChartParallelCoordinates_SetColumnVisibilityAll_19(base.GetCppThis(), visible ? (byte)1 : (byte)0);
		}

		// Token: 0x06011519 RID: 70937
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartParallelCoordinates_SetPlot_20(HandleRef pThis, HandleRef plot);

		/// <summary>
		/// Set plot to use for the chart. Since this type of chart can
		/// only contain one plot, this will replace the previous plot.
		/// </summary>
		// Token: 0x0601151A RID: 70938 RVA: 0x001825B4 File Offset: 0x001807B4
		public virtual void SetPlot(vtkPlotParallelCoordinates plot)
		{
			vtkChartParallelCoordinates.vtkChartParallelCoordinates_SetPlot_20(base.GetCppThis(), (plot == null) ? default(HandleRef) : plot.GetCppThis());
		}

		// Token: 0x0601151B RID: 70939
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartParallelCoordinates_SetShowLegend_21(HandleRef pThis, byte visible);

		/// <summary>
		/// Set whether the chart should draw a legend.
		/// </summary>
		// Token: 0x0601151C RID: 70940 RVA: 0x001825E3 File Offset: 0x001807E3
		public override void SetShowLegend(bool visible)
		{
			vtkChartParallelCoordinates.vtkChartParallelCoordinates_SetShowLegend_21(base.GetCppThis(), visible ? (byte)1 : (byte)0);
		}

		// Token: 0x0601151D RID: 70941
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartParallelCoordinates_SetVisibleColumns_22(HandleRef pThis, HandleRef visColumns);

		/// <summary>
		/// Set the list of visible columns, and the order in which they will be displayed.
		/// </summary>
		// Token: 0x0601151E RID: 70942 RVA: 0x001825FC File Offset: 0x001807FC
		public virtual void SetVisibleColumns(vtkStringArray visColumns)
		{
			vtkChartParallelCoordinates.vtkChartParallelCoordinates_SetVisibleColumns_22(base.GetCppThis(), (visColumns == null) ? default(HandleRef) : visColumns.GetCppThis());
		}

		// Token: 0x0601151F RID: 70943
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartParallelCoordinates_Update_23(HandleRef pThis);

		/// <summary>
		/// Perform any updates to the item that may be necessary before rendering.
		/// The scene should take care of calling this on all items before their
		/// Paint function is invoked.
		/// </summary>
		// Token: 0x06011520 RID: 70944 RVA: 0x0018262B File Offset: 0x0018082B
		public override void Update()
		{
			vtkChartParallelCoordinates.vtkChartParallelCoordinates_Update_23(base.GetCppThis());
		}

		// Token: 0x06011521 RID: 70945
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartParallelCoordinates_UpdateCurrentAxisSelection_24(HandleRef pThis, int axisId);

		/// <summary>
		/// Update the selection of an axis based on the current selectionMode we
		/// have previously set.
		/// </summary>
		// Token: 0x06011522 RID: 70946 RVA: 0x0018263A File Offset: 0x0018083A
		public void UpdateCurrentAxisSelection(int axisId)
		{
			vtkChartParallelCoordinates.vtkChartParallelCoordinates_UpdateCurrentAxisSelection_24(base.GetCppThis(), axisId);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001409 RID: 5129
		public new const string MRFullTypeName = "Kitware.VTK.vtkChartParallelCoordinates";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400140A RID: 5130
		public new static readonly string MRClassNameKey = "class vtkChartParallelCoordinates";
	}
}
