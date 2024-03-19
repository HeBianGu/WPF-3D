using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPlot
	/// </summary>
	/// <remarks>
	///    Abstract class for 2D plots.
	///
	///
	/// The base class for all plot types used in vtkChart derived charts.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPlotPoints vtkPlotLine vtkPlotBar vtkChart vtkChartXY
	/// </seealso>
	// Token: 0x02000645 RID: 1605
	public class vtkPlot : vtkContextItem
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060115C7 RID: 71111 RVA: 0x0018360A File Offset: 0x0018180A
		static vtkPlot()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPlot.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlot"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060115C8 RID: 71112 RVA: 0x00183632 File Offset: 0x00181832
		public vtkPlot(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060115C9 RID: 71113 RVA: 0x00183640 File Offset: 0x00181840
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060115CA RID: 71114
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlot_ClampPos_01(IntPtr pos, IntPtr bounds);

		/// <summary>
		/// Clamp the given 2D pos into the provided bounds
		/// Return true if the pos has been clamped, false otherwise.
		/// </summary>
		// Token: 0x060115CB RID: 71115 RVA: 0x0018364C File Offset: 0x0018184C
		public static bool ClampPos(IntPtr pos, IntPtr bounds)
		{
			return vtkPlot.vtkPlot_ClampPos_01(pos, bounds) != 0;
		}

		// Token: 0x060115CC RID: 71116
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlot_ClampPos_02(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Clamp the given 2D pos into the provided bounds
		/// Return true if the pos has been clamped, false otherwise.
		/// </summary>
		// Token: 0x060115CD RID: 71117 RVA: 0x00183670 File Offset: 0x00181870
		public virtual bool ClampPos(IntPtr pos)
		{
			return vtkPlot.vtkPlot_ClampPos_02(base.GetCppThis(), pos) != 0;
		}

		// Token: 0x060115CE RID: 71118
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlot_FilterSelectedPoints_03(HandleRef points, HandleRef selectedPoints, HandleRef selectedIds);

		/// <summary>
		/// Utility function that fills up `selectedPoints` with tuples from `points`. Indices
		/// from `selectedIds` are used to index into `points`.
		/// </summary>
		// Token: 0x060115CF RID: 71119 RVA: 0x00183698 File Offset: 0x00181898
		public static void FilterSelectedPoints(vtkDataArray points, vtkDataArray selectedPoints, vtkIdTypeArray selectedIds)
		{
			vtkPlot.vtkPlot_FilterSelectedPoints_03((points == null) ? default(HandleRef) : points.GetCppThis(), (selectedPoints == null) ? default(HandleRef) : selectedPoints.GetCppThis(), (selectedIds == null) ? default(HandleRef) : selectedIds.GetCppThis());
		}

		// Token: 0x060115D0 RID: 71120
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlot_GetBounds_04(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Get the bounds for this plot as (Xmin, Xmax, Ymin, Ymax).
		///
		/// See \a GetUnscaledInputBounds for more information.
		/// </summary>
		// Token: 0x060115D1 RID: 71121 RVA: 0x001836EB File Offset: 0x001818EB
		public virtual void GetBounds(IntPtr bounds)
		{
			vtkPlot.vtkPlot_GetBounds_04(base.GetCppThis(), bounds);
		}

		// Token: 0x060115D2 RID: 71122
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlot_GetBrush_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get the vtkBrush object that controls how this plot fills shapes.
		/// </summary>
		// Token: 0x060115D3 RID: 71123 RVA: 0x001836FC File Offset: 0x001818FC
		public vtkBrush GetBrush()
		{
			vtkBrush vtkBrush = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlot.vtkPlot_GetBrush_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060115D4 RID: 71124
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlot_GetColor_06(HandleRef pThis, IntPtr rgb);

		/// <summary>
		/// Get the plot color as integer rgb values (comprised between 0 and 255)
		/// </summary>
		// Token: 0x060115D5 RID: 71125 RVA: 0x0018376B File Offset: 0x0018196B
		public void GetColor(IntPtr rgb)
		{
			vtkPlot.vtkPlot_GetColor_06(base.GetCppThis(), rgb);
		}

		// Token: 0x060115D6 RID: 71126
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlot_GetColorF_07(HandleRef pThis, IntPtr rgb);

		/// <summary>
		/// Get the plot color as floating rgb values (comprised between 0.0 and 1.0)
		/// </summary>
		// Token: 0x060115D7 RID: 71127 RVA: 0x0018377B File Offset: 0x0018197B
		public virtual void GetColorF(IntPtr rgb)
		{
			vtkPlot.vtkPlot_GetColorF_07(base.GetCppThis(), rgb);
		}

		// Token: 0x060115D8 RID: 71128
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlot_GetData_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the data object that the plot will draw.
		/// </summary>
		// Token: 0x060115D9 RID: 71129 RVA: 0x0018378C File Offset: 0x0018198C
		public vtkContextMapper2D GetData()
		{
			vtkContextMapper2D vtkContextMapper2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlot.vtkPlot_GetData_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkContextMapper2D = (vtkContextMapper2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkContextMapper2D.Register(null);
				}
			}
			return vtkContextMapper2D;
		}

		// Token: 0x060115DA RID: 71130
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlot_GetIndexedLabels_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the indexed labels array.
		/// </summary>
		// Token: 0x060115DB RID: 71131 RVA: 0x001837FC File Offset: 0x001819FC
		public virtual vtkStringArray GetIndexedLabels()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlot.vtkPlot_GetIndexedLabels_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060115DC RID: 71132
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlot_GetInput_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input table used by the plot.
		/// </summary>
		// Token: 0x060115DD RID: 71133 RVA: 0x0018386C File Offset: 0x00181A6C
		public virtual vtkTable GetInput()
		{
			vtkTable vtkTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlot.vtkPlot_GetInput_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTable = (vtkTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTable.Register(null);
				}
			}
			return vtkTable;
		}

		// Token: 0x060115DE RID: 71134
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlot_GetInputConnection_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input connection used by the plot.
		/// </summary>
		// Token: 0x060115DF RID: 71135 RVA: 0x001838DC File Offset: 0x00181ADC
		public vtkAlgorithmOutput GetInputConnection()
		{
			vtkAlgorithmOutput vtkAlgorithmOutput = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlot.vtkPlot_GetInputConnection_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithmOutput = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithmOutput.Register(null);
				}
			}
			return vtkAlgorithmOutput;
		}

		// Token: 0x060115E0 RID: 71136
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkPlot_GetLabel_12(HandleRef pThis);

		/// <summary>
		/// Get the label of this plot.
		/// </summary>
		// Token: 0x060115E1 RID: 71137 RVA: 0x0018394C File Offset: 0x00181B4C
		public virtual string GetLabel()
		{
			return vtkPlot.vtkPlot_GetLabel_12(base.GetCppThis());
		}

		// Token: 0x060115E2 RID: 71138
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkPlot_GetLabel_13(HandleRef pThis, long index);

		/// <summary>
		/// Get the label at the specified index.
		/// </summary>
		// Token: 0x060115E3 RID: 71139 RVA: 0x0018396C File Offset: 0x00181B6C
		public string GetLabel(long index)
		{
			return vtkPlot.vtkPlot_GetLabel_13(base.GetCppThis(), index);
		}

		// Token: 0x060115E4 RID: 71140
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlot_GetLabels_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the plot labels. If this array has a length greater than 1 the index
		/// refers to the stacked objects in the plot. See vtkPlotBar for example.
		/// </summary>
		// Token: 0x060115E5 RID: 71141 RVA: 0x0018398C File Offset: 0x00181B8C
		public virtual vtkStringArray GetLabels()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlot.vtkPlot_GetLabels_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060115E6 RID: 71142
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlot_GetLegendVisibility_15(HandleRef pThis);

		/// <summary>
		/// Set whether the plot renders an entry in the legend. Default is true.
		/// vtkPlot::PaintLegend will get called to render the legend marker on when
		/// this is true.
		/// </summary>
		// Token: 0x060115E7 RID: 71143 RVA: 0x001839FC File Offset: 0x00181BFC
		public virtual bool GetLegendVisibility()
		{
			return vtkPlot.vtkPlot_GetLegendVisibility_15(base.GetCppThis()) != 0;
		}

		// Token: 0x060115E8 RID: 71144
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlot_GetNearestPoint_16(HandleRef pThis, HandleRef point, HandleRef tolerance, HandleRef location, IntPtr segmentId);

		/// <summary>
		/// Function to query a plot for the nearest point to the specified coordinate.
		/// Returns the index of the data series with which the point is associated, or
		/// -1 if no point was found.
		/// </summary>
		// Token: 0x060115E9 RID: 71145 RVA: 0x00183A24 File Offset: 0x00181C24
		public virtual long GetNearestPoint(vtkVector2f point, vtkVector2f tolerance, vtkVector2f location, IntPtr segmentId)
		{
			return vtkPlot.vtkPlot_GetNearestPoint_16(base.GetCppThis(), (point == null) ? default(HandleRef) : point.GetCppThis(), (tolerance == null) ? default(HandleRef) : tolerance.GetCppThis(), (location == null) ? default(HandleRef) : location.GetCppThis(), segmentId);
		}

		// Token: 0x060115EA RID: 71146
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlot_GetNumberOfGenerationsFromBase_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060115EB RID: 71147 RVA: 0x00183A84 File Offset: 0x00181C84
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPlot.vtkPlot_GetNumberOfGenerationsFromBase_17(base.GetCppThis(), type);
		}

		// Token: 0x060115EC RID: 71148
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlot_GetNumberOfGenerationsFromBaseType_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060115ED RID: 71149 RVA: 0x00183AA4 File Offset: 0x00181CA4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPlot.vtkPlot_GetNumberOfGenerationsFromBaseType_18(type);
		}

		// Token: 0x060115EE RID: 71150
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlot_GetNumberOfLabels_19(HandleRef pThis);

		/// <summary>
		/// Get the number of labels associated with this plot.
		/// </summary>
		// Token: 0x060115EF RID: 71151 RVA: 0x00183AC0 File Offset: 0x00181CC0
		public virtual int GetNumberOfLabels()
		{
			return vtkPlot.vtkPlot_GetNumberOfLabels_19(base.GetCppThis());
		}

		// Token: 0x060115F0 RID: 71152
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlot_GetPen_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get the vtkPen object that controls how this plot draws (out)lines.
		/// </summary>
		// Token: 0x060115F1 RID: 71153 RVA: 0x00183AE0 File Offset: 0x00181CE0
		public vtkPen GetPen()
		{
			vtkPen vtkPen = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlot.vtkPlot_GetPen_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPen = (vtkPen)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPen.Register(null);
				}
			}
			return vtkPen;
		}

		// Token: 0x060115F2 RID: 71154
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlot_GetProperty_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string property, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// A General setter/getter that should be overridden. It can silently drop
		/// options, case is important
		/// </summary>
		// Token: 0x060115F3 RID: 71155 RVA: 0x00183B50 File Offset: 0x00181D50
		public virtual vtkVariant GetProperty(string property)
		{
			vtkVariant result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlot.vtkPlot_GetProperty_21(base.GetCppThis(), property, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVariant)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060115F4 RID: 71156
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlot_GetSelectable_22(HandleRef pThis);

		/// <summary>
		/// Set whether the plot can be selected. True by default.
		/// If not, then SetSelection(), SelectPoints() or SelectPointsInPolygon()
		/// won't have any effect.
		/// \sa SetSelection(), SelectPoints(), SelectPointsInPolygon()
		/// </summary>
		// Token: 0x060115F5 RID: 71157 RVA: 0x00183BAC File Offset: 0x00181DAC
		public virtual bool GetSelectable()
		{
			return vtkPlot.vtkPlot_GetSelectable_22(base.GetCppThis()) != 0;
		}

		// Token: 0x060115F6 RID: 71158
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlot_GetSelection_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Sets the list of points that must be selected.
		/// If Selectable is false, then this method does nothing.
		/// \sa SetSelectable()
		/// </summary>
		// Token: 0x060115F7 RID: 71159 RVA: 0x00183BD4 File Offset: 0x00181DD4
		public virtual vtkIdTypeArray GetSelection()
		{
			vtkIdTypeArray vtkIdTypeArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlot.vtkPlot_GetSelection_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdTypeArray = (vtkIdTypeArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdTypeArray.Register(null);
				}
			}
			return vtkIdTypeArray;
		}

		// Token: 0x060115F8 RID: 71160
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlot_GetSelectionBrush_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get the vtkBrush object that controls how this plot fills selected
		/// shapes.
		/// </summary>
		// Token: 0x060115F9 RID: 71161 RVA: 0x00183C44 File Offset: 0x00181E44
		public vtkBrush GetSelectionBrush()
		{
			vtkBrush vtkBrush = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlot.vtkPlot_GetSelectionBrush_24(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060115FA RID: 71162
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlot_GetSelectionPen_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get the vtkBrush object that controls how this plot fills selected
		/// shapes.
		/// </summary>
		// Token: 0x060115FB RID: 71163 RVA: 0x00183CB4 File Offset: 0x00181EB4
		public vtkPen GetSelectionPen()
		{
			vtkPen vtkPen = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlot.vtkPlot_GetSelectionPen_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPen = (vtkPen)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPen.Register(null);
				}
			}
			return vtkPen;
		}

		// Token: 0x060115FC RID: 71164
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlot_GetShiftScale_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/set the origin shift and scaling factor used by the plot, this is
		/// normally 0.0 offset and 1.0 scaling, but can be used to render data outside
		/// of the single precision range. The chart that owns the plot should set this
		/// and ensure the appropriate matrix is used when rendering the plot.
		/// </summary>
		// Token: 0x060115FD RID: 71165 RVA: 0x00183D24 File Offset: 0x00181F24
		public vtkRectd GetShiftScale()
		{
			vtkRectd result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlot.vtkPlot_GetShiftScale_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRectd)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060115FE RID: 71166
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkPlot_GetTooltipLabel_27(HandleRef pThis, HandleRef plotPos, long seriesIndex, long segmentIndex);

		/// <summary>
		/// Generate and return the tooltip label string for this plot
		/// The segmentIndex parameter is ignored, except for vtkPlotBar
		/// </summary>
		// Token: 0x060115FF RID: 71167 RVA: 0x00183D80 File Offset: 0x00181F80
		public virtual string GetTooltipLabel(vtkVector2d plotPos, long seriesIndex, long segmentIndex)
		{
			return vtkPlot.vtkPlot_GetTooltipLabel_27(base.GetCppThis(), (plotPos == null) ? default(HandleRef) : plotPos.GetCppThis(), seriesIndex, segmentIndex);
		}

		// Token: 0x06011600 RID: 71168
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkPlot_GetTooltipLabelFormat_28(HandleRef pThis);

		/// <summary>
		/// Sets/gets a printf-style string to build custom tooltip labels from.
		/// An empty string generates the default tooltip labels.
		/// The following case-sensitive format tags (without quotes) are recognized:
		/// '%x' The X value of the plot element
		/// '%y' The Y value of the plot element
		/// '%i' The IndexedLabels entry for the plot element
		/// '%l' The value of the plot's GetLabel() function
		/// '%s' (vtkPlotBar only) The Labels entry for the bar segment
		/// Any other characters or unrecognized format tags are printed in the
		/// tooltip label verbatim.
		/// </summary>
		// Token: 0x06011601 RID: 71169 RVA: 0x00183DB8 File Offset: 0x00181FB8
		public virtual string GetTooltipLabelFormat()
		{
			return vtkPlot.vtkPlot_GetTooltipLabelFormat_28(base.GetCppThis());
		}

		// Token: 0x06011602 RID: 71170
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlot_GetTooltipNotation_29(HandleRef pThis);

		/// <summary>
		/// Sets/gets the tooltip notation style.
		/// </summary>
		// Token: 0x06011603 RID: 71171 RVA: 0x00183DD8 File Offset: 0x00181FD8
		public virtual int GetTooltipNotation()
		{
			return vtkPlot.vtkPlot_GetTooltipNotation_29(base.GetCppThis());
		}

		// Token: 0x06011604 RID: 71172
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlot_GetTooltipPrecision_30(HandleRef pThis);

		/// <summary>
		/// Sets/gets the tooltip precision.
		/// </summary>
		// Token: 0x06011605 RID: 71173 RVA: 0x00183DF8 File Offset: 0x00181FF8
		public virtual int GetTooltipPrecision()
		{
			return vtkPlot.vtkPlot_GetTooltipPrecision_30(base.GetCppThis());
		}

		// Token: 0x06011606 RID: 71174
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlot_GetUnscaledInputBounds_31(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Provide un-log-scaled bounds for the plot inputs.
		///
		/// This function is analogous to GetBounds() with 2 exceptions:
		/// 1. It will never return log-scaled bounds even when the
		/// x- and/or y-axes are log-scaled.
		/// 2. It will always return the bounds along the *input* axes
		/// rather than the output chart coordinates. Thus GetXAxis()
		/// returns the axis associated with the first 2 bounds entries
		/// and GetYAxis() returns the axis associated with the next 2
		/// bounds entries.
		///
		/// For example, vtkPlotBar's GetBounds() method
		/// will swap axis bounds when its orientation is vertical while
		/// its GetUnscaledInputBounds() will not swap axis bounds.
		///
		/// This method is provided so user interfaces can determine
		/// whether or not to allow log-scaling of a particular vtkAxis.
		///
		/// Subclasses of vtkPlot are responsible for implementing this
		/// function to transform input plot data.
		///
		/// The returned \a bounds are stored as (Xmin, Xmax, Ymin, Ymax).
		/// </summary>
		// Token: 0x06011607 RID: 71175 RVA: 0x00183E17 File Offset: 0x00182017
		public virtual void GetUnscaledInputBounds(IntPtr bounds)
		{
			vtkPlot.vtkPlot_GetUnscaledInputBounds_31(base.GetCppThis(), bounds);
		}

		// Token: 0x06011608 RID: 71176
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlot_GetUseIndexForXSeries_32(HandleRef pThis);

		/// <summary>
		/// Use the Y array index for the X value. If true any X column setting will be
		/// ignored, and the X values will simply be the index of the Y column.
		/// </summary>
		// Token: 0x06011609 RID: 71177 RVA: 0x00183E28 File Offset: 0x00182028
		public virtual bool GetUseIndexForXSeries()
		{
			return vtkPlot.vtkPlot_GetUseIndexForXSeries_32(base.GetCppThis()) != 0;
		}

		// Token: 0x0601160A RID: 71178
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkPlot_GetWidth_33(HandleRef pThis);

		/// <summary>
		/// Get the width of the line.
		/// </summary>
		// Token: 0x0601160B RID: 71179 RVA: 0x00183E50 File Offset: 0x00182050
		public virtual float GetWidth()
		{
			return vtkPlot.vtkPlot_GetWidth_33(base.GetCppThis());
		}

		// Token: 0x0601160C RID: 71180
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlot_GetXAxis_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/set the X axis associated with this plot.
		/// </summary>
		// Token: 0x0601160D RID: 71181 RVA: 0x00183E70 File Offset: 0x00182070
		public virtual vtkAxis GetXAxis()
		{
			vtkAxis vtkAxis = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlot.vtkPlot_GetXAxis_34(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601160E RID: 71182
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlot_GetYAxis_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/set the Y axis associated with this plot.
		/// </summary>
		// Token: 0x0601160F RID: 71183 RVA: 0x00183EE0 File Offset: 0x001820E0
		public virtual vtkAxis GetYAxis()
		{
			vtkAxis vtkAxis = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlot.vtkPlot_GetYAxis_35(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06011610 RID: 71184
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlot_IsA_36(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011611 RID: 71185 RVA: 0x00183F50 File Offset: 0x00182150
		public override int IsA(string type)
		{
			return vtkPlot.vtkPlot_IsA_36(base.GetCppThis(), type);
		}

		// Token: 0x06011612 RID: 71186
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlot_IsTypeOf_37([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011613 RID: 71187 RVA: 0x00183F70 File Offset: 0x00182170
		public new static int IsTypeOf(string type)
		{
			return vtkPlot.vtkPlot_IsTypeOf_37(type);
		}

		// Token: 0x06011614 RID: 71188
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlot_LegendVisibilityOff_38(HandleRef pThis);

		/// <summary>
		/// Set whether the plot renders an entry in the legend. Default is true.
		/// vtkPlot::PaintLegend will get called to render the legend marker on when
		/// this is true.
		/// </summary>
		// Token: 0x06011615 RID: 71189 RVA: 0x00183F8A File Offset: 0x0018218A
		public virtual void LegendVisibilityOff()
		{
			vtkPlot.vtkPlot_LegendVisibilityOff_38(base.GetCppThis());
		}

		// Token: 0x06011616 RID: 71190
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlot_LegendVisibilityOn_39(HandleRef pThis);

		/// <summary>
		/// Set whether the plot renders an entry in the legend. Default is true.
		/// vtkPlot::PaintLegend will get called to render the legend marker on when
		/// this is true.
		/// </summary>
		// Token: 0x06011617 RID: 71191 RVA: 0x00183F99 File Offset: 0x00182199
		public virtual void LegendVisibilityOn()
		{
			vtkPlot.vtkPlot_LegendVisibilityOn_39(base.GetCppThis());
		}

		// Token: 0x06011618 RID: 71192
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlot_NewInstance_40(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011619 RID: 71193 RVA: 0x00183FA8 File Offset: 0x001821A8
		public new vtkPlot NewInstance()
		{
			vtkPlot result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlot.vtkPlot_NewInstance_40(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlot)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601161A RID: 71194
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlot_PaintLegend_41(HandleRef pThis, HandleRef painter, HandleRef rect, int legendIndex);

		/// <summary>
		/// Paint legend event for the plot, called whenever the legend needs the
		/// plot items symbol/mark/line drawn. A rect is supplied with the lower left
		/// corner of the rect (elements 0 and 1) and with width x height (elements 2
		/// and 3). The plot can choose how to fill the space supplied. The index is used
		/// by Plots that return more than one label.
		/// </summary>
		// Token: 0x0601161B RID: 71195 RVA: 0x00184004 File Offset: 0x00182204
		public virtual bool PaintLegend(vtkContext2D painter, vtkRectf rect, int legendIndex)
		{
			return vtkPlot.vtkPlot_PaintLegend_41(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis(), (rect == null) ? default(HandleRef) : rect.GetCppThis(), legendIndex) != 0;
		}

		// Token: 0x0601161C RID: 71196
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlot_SafeDownCast_42(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601161D RID: 71197 RVA: 0x00184058 File Offset: 0x00182258
		public new static vtkPlot SafeDownCast(vtkObjectBase o)
		{
			vtkPlot vtkPlot = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlot.vtkPlot_SafeDownCast_42((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601161E RID: 71198
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlot_SelectPoints_43(HandleRef pThis, HandleRef min, HandleRef max);

		/// <summary>
		/// Select all points in the specified rectangle.
		/// </summary>
		// Token: 0x0601161F RID: 71199 RVA: 0x001840D8 File Offset: 0x001822D8
		public virtual bool SelectPoints(vtkVector2f min, vtkVector2f max)
		{
			return vtkPlot.vtkPlot_SelectPoints_43(base.GetCppThis(), (min == null) ? default(HandleRef) : min.GetCppThis(), (max == null) ? default(HandleRef) : max.GetCppThis()) != 0;
		}

		// Token: 0x06011620 RID: 71200
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlot_SelectableOff_44(HandleRef pThis);

		/// <summary>
		/// Set whether the plot can be selected. True by default.
		/// If not, then SetSelection(), SelectPoints() or SelectPointsInPolygon()
		/// won't have any effect.
		/// \sa SetSelection(), SelectPoints(), SelectPointsInPolygon()
		/// </summary>
		// Token: 0x06011621 RID: 71201 RVA: 0x00184128 File Offset: 0x00182328
		public virtual void SelectableOff()
		{
			vtkPlot.vtkPlot_SelectableOff_44(base.GetCppThis());
		}

		// Token: 0x06011622 RID: 71202
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlot_SelectableOn_45(HandleRef pThis);

		/// <summary>
		/// Set whether the plot can be selected. True by default.
		/// If not, then SetSelection(), SelectPoints() or SelectPointsInPolygon()
		/// won't have any effect.
		/// \sa SetSelection(), SelectPoints(), SelectPointsInPolygon()
		/// </summary>
		// Token: 0x06011623 RID: 71203 RVA: 0x00184137 File Offset: 0x00182337
		public virtual void SelectableOn()
		{
			vtkPlot.vtkPlot_SelectableOn_45(base.GetCppThis());
		}

		// Token: 0x06011624 RID: 71204
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlot_SetBrush_46(HandleRef pThis, HandleRef brush);

		/// <summary>
		/// Set/get the vtkBrush object that controls how this plot fills shapes.
		/// </summary>
		// Token: 0x06011625 RID: 71205 RVA: 0x00184148 File Offset: 0x00182348
		public void SetBrush(vtkBrush brush)
		{
			vtkPlot.vtkPlot_SetBrush_46(base.GetCppThis(), (brush == null) ? default(HandleRef) : brush.GetCppThis());
		}

		// Token: 0x06011626 RID: 71206
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlot_SetColor_47(HandleRef pThis, byte r, byte g, byte b, byte a);

		/// <summary>
		/// Set the plot color with integer values (comprised between 0 and 255)
		/// </summary>
		// Token: 0x06011627 RID: 71207 RVA: 0x00184177 File Offset: 0x00182377
		public virtual void SetColor(byte r, byte g, byte b, byte a)
		{
			vtkPlot.vtkPlot_SetColor_47(base.GetCppThis(), r, g, b, a);
		}

		// Token: 0x06011628 RID: 71208
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlot_SetColorF_48(HandleRef pThis, double r, double g, double b, double a);

		/// <summary>
		/// Set the plot color with floating values (comprised between 0.0 and 1.0)
		/// </summary>
		// Token: 0x06011629 RID: 71209 RVA: 0x0018418B File Offset: 0x0018238B
		public virtual void SetColorF(double r, double g, double b, double a)
		{
			vtkPlot.vtkPlot_SetColorF_48(base.GetCppThis(), r, g, b, a);
		}

		// Token: 0x0601162A RID: 71210
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlot_SetColorF_49(HandleRef pThis, double r, double g, double b);

		/// <summary>
		/// Set the plot color with floating values (comprised between 0.0 and 1.0)
		/// </summary>
		// Token: 0x0601162B RID: 71211 RVA: 0x0018419F File Offset: 0x0018239F
		public virtual void SetColorF(double r, double g, double b)
		{
			vtkPlot.vtkPlot_SetColorF_49(base.GetCppThis(), r, g, b);
		}

		// Token: 0x0601162C RID: 71212
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlot_SetIndexedLabels_50(HandleRef pThis, HandleRef labels);

		/// <summary>
		/// Set indexed labels for the plot. If set, this array can be used to provide
		/// custom labels for each point in a plot. This array should be the same
		/// length as the points array. Default is null (no indexed labels).
		/// </summary>
		// Token: 0x0601162D RID: 71213 RVA: 0x001841B4 File Offset: 0x001823B4
		public void SetIndexedLabels(vtkStringArray labels)
		{
			vtkPlot.vtkPlot_SetIndexedLabels_50(base.GetCppThis(), (labels == null) ? default(HandleRef) : labels.GetCppThis());
		}

		// Token: 0x0601162E RID: 71214
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlot_SetInputArray_51(HandleRef pThis, int index, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Convenience function to set the input arrays. For most plots index 0
		/// is the x axis, and index 1 is the y axis. The name is the name of the
		/// column in the vtkTable.
		/// </summary>
		// Token: 0x0601162F RID: 71215 RVA: 0x001841E3 File Offset: 0x001823E3
		public virtual void SetInputArray(int index, string name)
		{
			vtkPlot.vtkPlot_SetInputArray_51(base.GetCppThis(), index, name);
		}

		// Token: 0x06011630 RID: 71216
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlot_SetInputConnection_52(HandleRef pThis, HandleRef input);

		/// <summary>
		/// This is a convenience function to set the input connection for the plot.
		/// </summary>
		// Token: 0x06011631 RID: 71217 RVA: 0x001841F4 File Offset: 0x001823F4
		public virtual void SetInputConnection(vtkAlgorithmOutput input)
		{
			vtkPlot.vtkPlot_SetInputConnection_52(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x06011632 RID: 71218
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlot_SetInputData_53(HandleRef pThis, HandleRef table);

		/// <summary>
		/// This is a convenience function to set the input table and the x, y column
		/// for the plot.
		/// </summary>
		// Token: 0x06011633 RID: 71219 RVA: 0x00184224 File Offset: 0x00182424
		public virtual void SetInputData(vtkTable table)
		{
			vtkPlot.vtkPlot_SetInputData_53(base.GetCppThis(), (table == null) ? default(HandleRef) : table.GetCppThis());
		}

		// Token: 0x06011634 RID: 71220
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlot_SetInputData_54(HandleRef pThis, HandleRef table, [MarshalAs(UnmanagedType.LPUTF8Str)] string xColumn, [MarshalAs(UnmanagedType.LPUTF8Str)] string yColumn);

		/// <summary>
		/// This is a convenience function to set the input table and the x, y column
		/// for the plot.
		/// </summary>
		// Token: 0x06011635 RID: 71221 RVA: 0x00184254 File Offset: 0x00182454
		public virtual void SetInputData(vtkTable table, string xColumn, string yColumn)
		{
			vtkPlot.vtkPlot_SetInputData_54(base.GetCppThis(), (table == null) ? default(HandleRef) : table.GetCppThis(), xColumn, yColumn);
		}

		// Token: 0x06011636 RID: 71222
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlot_SetInputData_55(HandleRef pThis, HandleRef table, long xColumn, long yColumn);

		/// <summary>
		/// This is a convenience function to set the input table and the x, y column
		/// for the plot.
		/// </summary>
		// Token: 0x06011637 RID: 71223 RVA: 0x00184288 File Offset: 0x00182488
		public void SetInputData(vtkTable table, long xColumn, long yColumn)
		{
			vtkPlot.vtkPlot_SetInputData_55(base.GetCppThis(), (table == null) ? default(HandleRef) : table.GetCppThis(), xColumn, yColumn);
		}

		// Token: 0x06011638 RID: 71224
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlot_SetLabel_56(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string label);

		/// <summary>
		/// Set the label of this plot.
		/// </summary>
		// Token: 0x06011639 RID: 71225 RVA: 0x001842B9 File Offset: 0x001824B9
		public virtual void SetLabel(string label)
		{
			vtkPlot.vtkPlot_SetLabel_56(base.GetCppThis(), label);
		}

		// Token: 0x0601163A RID: 71226
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlot_SetLabels_57(HandleRef pThis, HandleRef labels);

		/// <summary>
		/// Set the plot labels, these are used for stacked chart variants, with the
		/// index referring to the stacking index.
		/// </summary>
		// Token: 0x0601163B RID: 71227 RVA: 0x001842CC File Offset: 0x001824CC
		public virtual void SetLabels(vtkStringArray labels)
		{
			vtkPlot.vtkPlot_SetLabels_57(base.GetCppThis(), (labels == null) ? default(HandleRef) : labels.GetCppThis());
		}

		// Token: 0x0601163C RID: 71228
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlot_SetLegendVisibility_58(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set whether the plot renders an entry in the legend. Default is true.
		/// vtkPlot::PaintLegend will get called to render the legend marker on when
		/// this is true.
		/// </summary>
		// Token: 0x0601163D RID: 71229 RVA: 0x001842FB File Offset: 0x001824FB
		public virtual void SetLegendVisibility(bool _arg)
		{
			vtkPlot.vtkPlot_SetLegendVisibility_58(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0601163E RID: 71230
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlot_SetPen_59(HandleRef pThis, HandleRef pen);

		/// <summary>
		/// Set/get the vtkPen object that controls how this plot draws (out)lines.
		/// </summary>
		// Token: 0x0601163F RID: 71231 RVA: 0x00184314 File Offset: 0x00182514
		public void SetPen(vtkPen pen)
		{
			vtkPlot.vtkPlot_SetPen_59(base.GetCppThis(), (pen == null) ? default(HandleRef) : pen.GetCppThis());
		}

		// Token: 0x06011640 RID: 71232
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlot_SetProperty_60(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string property, HandleRef var);

		/// <summary>
		/// A General setter/getter that should be overridden. It can silently drop
		/// options, case is important
		/// </summary>
		// Token: 0x06011641 RID: 71233 RVA: 0x00184344 File Offset: 0x00182544
		public virtual void SetProperty(string property, vtkVariant var)
		{
			vtkPlot.vtkPlot_SetProperty_60(base.GetCppThis(), property, (var == null) ? default(HandleRef) : var.GetCppThis());
		}

		// Token: 0x06011642 RID: 71234
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlot_SetSelectable_61(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set whether the plot can be selected. True by default.
		/// If not, then SetSelection(), SelectPoints() or SelectPointsInPolygon()
		/// won't have any effect.
		/// \sa SetSelection(), SelectPoints(), SelectPointsInPolygon()
		/// </summary>
		// Token: 0x06011643 RID: 71235 RVA: 0x00184374 File Offset: 0x00182574
		public virtual void SetSelectable(bool _arg)
		{
			vtkPlot.vtkPlot_SetSelectable_61(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06011644 RID: 71236
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlot_SetSelection_62(HandleRef pThis, HandleRef id);

		/// <summary>
		/// Sets the list of points that must be selected.
		/// If Selectable is false, then this method does nothing.
		/// \sa SetSelectable()
		/// </summary>
		// Token: 0x06011645 RID: 71237 RVA: 0x0018438C File Offset: 0x0018258C
		public virtual void SetSelection(vtkIdTypeArray id)
		{
			vtkPlot.vtkPlot_SetSelection_62(base.GetCppThis(), (id == null) ? default(HandleRef) : id.GetCppThis());
		}

		// Token: 0x06011646 RID: 71238
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlot_SetSelectionBrush_63(HandleRef pThis, HandleRef brush);

		/// <summary>
		/// Set/get the vtkBrush object that controls how this plot fills selected
		/// shapes.
		/// </summary>
		// Token: 0x06011647 RID: 71239 RVA: 0x001843BC File Offset: 0x001825BC
		public void SetSelectionBrush(vtkBrush brush)
		{
			vtkPlot.vtkPlot_SetSelectionBrush_63(base.GetCppThis(), (brush == null) ? default(HandleRef) : brush.GetCppThis());
		}

		// Token: 0x06011648 RID: 71240
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlot_SetSelectionPen_64(HandleRef pThis, HandleRef pen);

		/// <summary>
		/// Set/get the vtkBrush object that controls how this plot fills selected
		/// shapes.
		/// </summary>
		// Token: 0x06011649 RID: 71241 RVA: 0x001843EC File Offset: 0x001825EC
		public void SetSelectionPen(vtkPen pen)
		{
			vtkPlot.vtkPlot_SetSelectionPen_64(base.GetCppThis(), (pen == null) ? default(HandleRef) : pen.GetCppThis());
		}

		// Token: 0x0601164A RID: 71242
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlot_SetShiftScale_65(HandleRef pThis, HandleRef shiftScale);

		/// <summary>
		/// Get/set the origin shift and scaling factor used by the plot, this is
		/// normally 0.0 offset and 1.0 scaling, but can be used to render data outside
		/// of the single precision range. The chart that owns the plot should set this
		/// and ensure the appropriate matrix is used when rendering the plot.
		/// </summary>
		// Token: 0x0601164B RID: 71243 RVA: 0x0018441C File Offset: 0x0018261C
		public void SetShiftScale(vtkRectd shiftScale)
		{
			vtkPlot.vtkPlot_SetShiftScale_65(base.GetCppThis(), (shiftScale == null) ? default(HandleRef) : shiftScale.GetCppThis());
		}

		// Token: 0x0601164C RID: 71244
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlot_SetTooltipLabelFormat_66(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string label);

		/// <summary>
		/// Sets/gets a printf-style string to build custom tooltip labels from.
		/// An empty string generates the default tooltip labels.
		/// The following case-sensitive format tags (without quotes) are recognized:
		/// '%x' The X value of the plot element
		/// '%y' The Y value of the plot element
		/// '%i' The IndexedLabels entry for the plot element
		/// '%l' The value of the plot's GetLabel() function
		/// '%s' (vtkPlotBar only) The Labels entry for the bar segment
		/// Any other characters or unrecognized format tags are printed in the
		/// tooltip label verbatim.
		/// </summary>
		// Token: 0x0601164D RID: 71245 RVA: 0x0018444B File Offset: 0x0018264B
		public virtual void SetTooltipLabelFormat(string label)
		{
			vtkPlot.vtkPlot_SetTooltipLabelFormat_66(base.GetCppThis(), label);
		}

		// Token: 0x0601164E RID: 71246
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlot_SetTooltipNotation_67(HandleRef pThis, int notation);

		/// <summary>
		/// Sets/gets the tooltip notation style.
		/// </summary>
		// Token: 0x0601164F RID: 71247 RVA: 0x0018445B File Offset: 0x0018265B
		public virtual void SetTooltipNotation(int notation)
		{
			vtkPlot.vtkPlot_SetTooltipNotation_67(base.GetCppThis(), notation);
		}

		// Token: 0x06011650 RID: 71248
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlot_SetTooltipPrecision_68(HandleRef pThis, int precision);

		/// <summary>
		/// Sets/gets the tooltip precision.
		/// </summary>
		// Token: 0x06011651 RID: 71249 RVA: 0x0018446B File Offset: 0x0018266B
		public virtual void SetTooltipPrecision(int precision)
		{
			vtkPlot.vtkPlot_SetTooltipPrecision_68(base.GetCppThis(), precision);
		}

		// Token: 0x06011652 RID: 71250
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlot_SetUseIndexForXSeries_69(HandleRef pThis, byte _arg);

		/// <summary>
		/// Use the Y array index for the X value. If true any X column setting will be
		/// ignored, and the X values will simply be the index of the Y column.
		/// </summary>
		// Token: 0x06011653 RID: 71251 RVA: 0x0018447B File Offset: 0x0018267B
		public virtual void SetUseIndexForXSeries(bool _arg)
		{
			vtkPlot.vtkPlot_SetUseIndexForXSeries_69(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06011654 RID: 71252
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlot_SetWidth_70(HandleRef pThis, float width);

		/// <summary>
		/// Set the width of the line.
		/// </summary>
		// Token: 0x06011655 RID: 71253 RVA: 0x00184493 File Offset: 0x00182693
		public virtual void SetWidth(float width)
		{
			vtkPlot.vtkPlot_SetWidth_70(base.GetCppThis(), width);
		}

		// Token: 0x06011656 RID: 71254
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlot_SetXAxis_71(HandleRef pThis, HandleRef axis);

		/// <summary>
		/// Get/set the X axis associated with this plot.
		/// </summary>
		// Token: 0x06011657 RID: 71255 RVA: 0x001844A4 File Offset: 0x001826A4
		public virtual void SetXAxis(vtkAxis axis)
		{
			vtkPlot.vtkPlot_SetXAxis_71(base.GetCppThis(), (axis == null) ? default(HandleRef) : axis.GetCppThis());
		}

		// Token: 0x06011658 RID: 71256
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlot_SetYAxis_72(HandleRef pThis, HandleRef axis);

		/// <summary>
		/// Get/set the Y axis associated with this plot.
		/// </summary>
		// Token: 0x06011659 RID: 71257 RVA: 0x001844D4 File Offset: 0x001826D4
		public virtual void SetYAxis(vtkAxis axis)
		{
			vtkPlot.vtkPlot_SetYAxis_72(base.GetCppThis(), (axis == null) ? default(HandleRef) : axis.GetCppThis());
		}

		// Token: 0x0601165A RID: 71258
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlot_Update_73(HandleRef pThis);

		/// <summary>
		/// Perform any updates to the item that may be necessary before rendering.
		/// The scene should take care of calling this on all items before their
		/// Paint function is invoked.
		/// </summary>
		// Token: 0x0601165B RID: 71259 RVA: 0x00184503 File Offset: 0x00182703
		public override void Update()
		{
			vtkPlot.vtkPlot_Update_73(base.GetCppThis());
		}

		// Token: 0x0601165C RID: 71260
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlot_UpdateCache_74(HandleRef pThis);

		/// <summary>
		/// Update the internal cache. Returns true if cache was successfully updated. Default does
		/// nothing.
		/// This method is called by Update() when either the plot's data has changed or
		/// CacheRequiresUpdate() returns true. It is not necessary to call this method explicitly.
		/// </summary>
		// Token: 0x0601165D RID: 71261 RVA: 0x00184514 File Offset: 0x00182714
		public virtual bool UpdateCache()
		{
			return vtkPlot.vtkPlot_UpdateCache_74(base.GetCppThis()) != 0;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001414 RID: 5140
		public new const string MRFullTypeName = "Kitware.VTK.vtkPlot";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001415 RID: 5141
		public new static readonly string MRClassNameKey = "class vtkPlot";
	}
}
