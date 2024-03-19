using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPlotArea
	/// </summary>
	/// <remarks>
	///    draws an area plot.
	///
	/// vtkPlotArea is used to render an area plot. An area plot (sometimes called a
	/// range plot) renders a filled region between the selected ymin and ymax
	/// arrays.
	/// To specify the x array and ymin/ymax arrays, use the SetInputArray method
	/// with array index as 0, 1, or 2, respectively.
	/// </remarks>
	// Token: 0x02000656 RID: 1622
	public class vtkPlotArea : vtkPlot
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601188B RID: 71819 RVA: 0x00187BF3 File Offset: 0x00185DF3
		static vtkPlotArea()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPlotArea.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlotArea"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601188C RID: 71820 RVA: 0x00187C1B File Offset: 0x00185E1B
		public vtkPlotArea(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601188D RID: 71821
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotArea_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601188E RID: 71822 RVA: 0x00187C2C File Offset: 0x00185E2C
		public new static vtkPlotArea New()
		{
			vtkPlotArea result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotArea.vtkPlotArea_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlotArea)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601188F RID: 71823 RVA: 0x00187C80 File Offset: 0x00185E80
		public vtkPlotArea() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPlotArea.vtkPlotArea_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011890 RID: 71824 RVA: 0x00187CC4 File Offset: 0x00185EC4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011891 RID: 71825
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotArea_GetBounds_01(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Get the bounds for this plot as (Xmin, Xmax, Ymin, Ymax).
		/// </summary>
		// Token: 0x06011892 RID: 71826 RVA: 0x00187CCF File Offset: 0x00185ECF
		public override void GetBounds(IntPtr bounds)
		{
			vtkPlotArea.vtkPlotArea_GetBounds_01(base.GetCppThis(), bounds);
		}

		// Token: 0x06011893 RID: 71827
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlotArea_GetNearestPoint_02(HandleRef pThis, HandleRef point, HandleRef tolerance, HandleRef location, IntPtr segmentId);

		/// <summary>
		/// Function to query a plot for the nearest point to the specified coordinate.
		/// Returns the index of the data series with which the point is associated, or
		/// -1 if no point was found.
		/// </summary>
		// Token: 0x06011894 RID: 71828 RVA: 0x00187CE0 File Offset: 0x00185EE0
		public override long GetNearestPoint(vtkVector2f point, vtkVector2f tolerance, vtkVector2f location, IntPtr segmentId)
		{
			return vtkPlotArea.vtkPlotArea_GetNearestPoint_02(base.GetCppThis(), (point == null) ? default(HandleRef) : point.GetCppThis(), (tolerance == null) ? default(HandleRef) : tolerance.GetCppThis(), (location == null) ? default(HandleRef) : location.GetCppThis(), segmentId);
		}

		// Token: 0x06011895 RID: 71829
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlotArea_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011896 RID: 71830 RVA: 0x00187D40 File Offset: 0x00185F40
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPlotArea.vtkPlotArea_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06011897 RID: 71831
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlotArea_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011898 RID: 71832 RVA: 0x00187D60 File Offset: 0x00185F60
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPlotArea.vtkPlotArea_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06011899 RID: 71833
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkPlotArea_GetTooltipLabel_05(HandleRef pThis, HandleRef plotPos, long seriesIndex, long segmentIndex);

		/// <summary>
		/// Generate and return the tooltip label string for this plot
		/// The segmentIndex parameter is ignored, except for vtkPlotBar
		/// </summary>
		// Token: 0x0601189A RID: 71834 RVA: 0x00187D7C File Offset: 0x00185F7C
		public override string GetTooltipLabel(vtkVector2d plotPos, long seriesIndex, long segmentIndex)
		{
			return vtkPlotArea.vtkPlotArea_GetTooltipLabel_05(base.GetCppThis(), (plotPos == null) ? default(HandleRef) : plotPos.GetCppThis(), seriesIndex, segmentIndex);
		}

		// Token: 0x0601189B RID: 71835
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkPlotArea_GetValidPointMaskName_06(HandleRef pThis);

		/// <summary>
		/// Get/set the valid point mask array name.
		/// </summary>
		// Token: 0x0601189C RID: 71836 RVA: 0x00187DB4 File Offset: 0x00185FB4
		public virtual string GetValidPointMaskName()
		{
			return vtkPlotArea.vtkPlotArea_GetValidPointMaskName_06(base.GetCppThis());
		}

		// Token: 0x0601189D RID: 71837
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlotArea_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601189E RID: 71838 RVA: 0x00187DD4 File Offset: 0x00185FD4
		public override int IsA(string type)
		{
			return vtkPlotArea.vtkPlotArea_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601189F RID: 71839
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlotArea_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060118A0 RID: 71840 RVA: 0x00187DF4 File Offset: 0x00185FF4
		public new static int IsTypeOf(string type)
		{
			return vtkPlotArea.vtkPlotArea_IsTypeOf_08(type);
		}

		// Token: 0x060118A1 RID: 71841
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotArea_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060118A2 RID: 71842 RVA: 0x00187E10 File Offset: 0x00186010
		public new vtkPlotArea NewInstance()
		{
			vtkPlotArea result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotArea.vtkPlotArea_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlotArea)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060118A3 RID: 71843
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlotArea_Paint_11(HandleRef pThis, HandleRef painter);

		/// <summary>
		/// Paint event for the XY plot, called whenever the chart needs to be drawn
		/// </summary>
		// Token: 0x060118A4 RID: 71844 RVA: 0x00187E6C File Offset: 0x0018606C
		public override bool Paint(vtkContext2D painter)
		{
			return vtkPlotArea.vtkPlotArea_Paint_11(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		// Token: 0x060118A5 RID: 71845
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlotArea_PaintLegend_12(HandleRef pThis, HandleRef painter, HandleRef rect, int legendIndex);

		/// <summary>
		/// Paint legend event for the plot, called whenever the legend needs the
		/// plot items symbol/mark/line drawn. A rect is supplied with the lower left
		/// corner of the rect (elements 0 and 1) and with width x height (elements 2
		/// and 3). The plot can choose how to fill the space supplied. The index is used
		/// by Plots that return more than one label.
		/// </summary>
		// Token: 0x060118A6 RID: 71846 RVA: 0x00187EA8 File Offset: 0x001860A8
		public override bool PaintLegend(vtkContext2D painter, vtkRectf rect, int legendIndex)
		{
			return vtkPlotArea.vtkPlotArea_PaintLegend_12(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis(), (rect == null) ? default(HandleRef) : rect.GetCppThis(), legendIndex) != 0;
		}

		// Token: 0x060118A7 RID: 71847
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotArea_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060118A8 RID: 71848 RVA: 0x00187EFC File Offset: 0x001860FC
		public new static vtkPlotArea SafeDownCast(vtkObjectBase o)
		{
			vtkPlotArea vtkPlotArea = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotArea.vtkPlotArea_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlotArea = (vtkPlotArea)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlotArea.Register(null);
				}
			}
			return vtkPlotArea;
		}

		// Token: 0x060118A9 RID: 71849
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotArea_SetColor_14(HandleRef pThis, byte r, byte g, byte b, byte a);

		/// <summary>
		/// Set the plot color with integer values (comprised between 0 and 255)
		/// </summary>
		// Token: 0x060118AA RID: 71850 RVA: 0x00187F7B File Offset: 0x0018617B
		public override void SetColor(byte r, byte g, byte b, byte a)
		{
			vtkPlotArea.vtkPlotArea_SetColor_14(base.GetCppThis(), r, g, b, a);
		}

		// Token: 0x060118AB RID: 71851
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotArea_SetColorF_15(HandleRef pThis, double r, double g, double b, double a);

		/// <summary>
		/// Set the plot color with floating values (comprised between 0.0 and 1.0)
		/// </summary>
		// Token: 0x060118AC RID: 71852 RVA: 0x00187F8F File Offset: 0x0018618F
		public override void SetColorF(double r, double g, double b, double a)
		{
			vtkPlotArea.vtkPlotArea_SetColorF_15(base.GetCppThis(), r, g, b, a);
		}

		// Token: 0x060118AD RID: 71853
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotArea_SetColorF_16(HandleRef pThis, double r, double g, double b);

		/// <summary>
		/// Set the plot color with floating values (comprised between 0.0 and 1.0)
		/// </summary>
		// Token: 0x060118AE RID: 71854 RVA: 0x00187FA3 File Offset: 0x001861A3
		public override void SetColorF(double r, double g, double b)
		{
			vtkPlotArea.vtkPlotArea_SetColorF_16(base.GetCppThis(), r, g, b);
		}

		// Token: 0x060118AF RID: 71855
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotArea_SetValidPointMaskName_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Get/set the valid point mask array name.
		/// </summary>
		// Token: 0x060118B0 RID: 71856 RVA: 0x00187FB5 File Offset: 0x001861B5
		public virtual void SetValidPointMaskName(string _arg)
		{
			vtkPlotArea.vtkPlotArea_SetValidPointMaskName_17(base.GetCppThis(), _arg);
		}

		// Token: 0x060118B1 RID: 71857
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlotArea_UpdateCache_18(HandleRef pThis);

		/// <summary>
		/// Update the internal cache. Returns true if cache was successfully updated. Default does
		/// nothing.
		/// This method is called by Update() when either the plot's data has changed or
		/// CacheRequiresUpdate() returns true. It is not necessary to call this method explicitly.
		/// </summary>
		// Token: 0x060118B2 RID: 71858 RVA: 0x00187FC8 File Offset: 0x001861C8
		public override bool UpdateCache()
		{
			return vtkPlotArea.vtkPlotArea_UpdateCache_18(base.GetCppThis()) != 0;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400143C RID: 5180
		public new const string MRFullTypeName = "Kitware.VTK.vtkPlotArea";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400143D RID: 5181
		public new static readonly string MRClassNameKey = "class vtkPlotArea";
	}
}
