using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPlotBar
	/// </summary>
	/// <remarks>
	///    Class for drawing an XY plot given two columns from a
	/// vtkTable.
	///
	///
	///
	/// </remarks>
	// Token: 0x0200065A RID: 1626
	public class vtkPlotBar : vtkPlot
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011925 RID: 71973 RVA: 0x00188B56 File Offset: 0x00186D56
		static vtkPlotBar()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPlotBar.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlotBar"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011926 RID: 71974 RVA: 0x00188B7E File Offset: 0x00186D7E
		public vtkPlotBar(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011927 RID: 71975
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotBar_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates a 2D Chart object.
		/// </summary>
		// Token: 0x06011928 RID: 71976 RVA: 0x00188B8C File Offset: 0x00186D8C
		public new static vtkPlotBar New()
		{
			vtkPlotBar result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotBar.vtkPlotBar_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlotBar)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Creates a 2D Chart object.
		/// </summary>
		// Token: 0x06011929 RID: 71977 RVA: 0x00188BE0 File Offset: 0x00186DE0
		public vtkPlotBar() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPlotBar.vtkPlotBar_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601192A RID: 71978 RVA: 0x00188C24 File Offset: 0x00186E24
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601192B RID: 71979
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotBar_CreateDefaultLookupTable_01(HandleRef pThis);

		/// <summary>
		/// Create default lookup table. Generally used to create one when none
		/// is available with the scalar data.
		/// </summary>
		// Token: 0x0601192C RID: 71980 RVA: 0x00188C2F File Offset: 0x00186E2F
		public virtual void CreateDefaultLookupTable()
		{
			vtkPlotBar.vtkPlotBar_CreateDefaultLookupTable_01(base.GetCppThis());
		}

		// Token: 0x0601192D RID: 71981
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotBar_EnableOpacityMappingOff_02(HandleRef pThis);

		/// <summary>
		/// Enable/disable mapping of the opacity values. Default is set to true.
		/// </summary>
		// Token: 0x0601192E RID: 71982 RVA: 0x00188C3E File Offset: 0x00186E3E
		public virtual void EnableOpacityMappingOff()
		{
			vtkPlotBar.vtkPlotBar_EnableOpacityMappingOff_02(base.GetCppThis());
		}

		// Token: 0x0601192F RID: 71983
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotBar_EnableOpacityMappingOn_03(HandleRef pThis);

		/// <summary>
		/// Enable/disable mapping of the opacity values. Default is set to true.
		/// </summary>
		// Token: 0x06011930 RID: 71984 RVA: 0x00188C4D File Offset: 0x00186E4D
		public virtual void EnableOpacityMappingOn()
		{
			vtkPlotBar.vtkPlotBar_EnableOpacityMappingOn_03(base.GetCppThis());
		}

		// Token: 0x06011931 RID: 71985
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlotBar_GetBarsCount_04(HandleRef pThis);

		/// <summary>
		/// Get amount of plotted bars.
		/// </summary>
		// Token: 0x06011932 RID: 71986 RVA: 0x00188C5C File Offset: 0x00186E5C
		public int GetBarsCount()
		{
			return vtkPlotBar.vtkPlotBar_GetBarsCount_04(base.GetCppThis());
		}

		// Token: 0x06011933 RID: 71987
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotBar_GetBounds_05(HandleRef pThis, IntPtr bounds, byte unscaled);

		/// <summary>
		/// A helper used by both GetUnscaledBounds and GetBounds(double[4]).
		/// </summary>
		// Token: 0x06011934 RID: 71988 RVA: 0x00188C7B File Offset: 0x00186E7B
		public virtual void GetBounds(IntPtr bounds, bool unscaled)
		{
			vtkPlotBar.vtkPlotBar_GetBounds_05(base.GetCppThis(), bounds, unscaled ? (byte)1 : (byte)0);
		}

		// Token: 0x06011935 RID: 71989
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotBar_GetBounds_06(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Get the bounds for this mapper as (Xmin,Xmax,Ymin,Ymax).
		/// </summary>
		// Token: 0x06011936 RID: 71990 RVA: 0x00188C94 File Offset: 0x00186E94
		public override void GetBounds(IntPtr bounds)
		{
			vtkPlotBar.vtkPlotBar_GetBounds_06(base.GetCppThis(), bounds);
		}

		// Token: 0x06011937 RID: 71991
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkPlotBar_GetColorArrayName_07(HandleRef pThis);

		/// <summary>
		/// Get the array name to color by.
		/// </summary>
		// Token: 0x06011938 RID: 71992 RVA: 0x00188CA4 File Offset: 0x00186EA4
		public string GetColorArrayName()
		{
			return vtkPlotBar.vtkPlotBar_GetColorArrayName_07(base.GetCppThis());
		}

		// Token: 0x06011939 RID: 71993
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotBar_GetColorF_08(HandleRef pThis, IntPtr rgb);

		/// <summary>
		/// Get the plot color as floating rgb values (comprised between 0.0 and 1.0)
		/// </summary>
		// Token: 0x0601193A RID: 71994 RVA: 0x00188CC3 File Offset: 0x00186EC3
		public override void GetColorF(IntPtr rgb)
		{
			vtkPlotBar.vtkPlotBar_GetColorF_08(base.GetCppThis(), rgb);
		}

		// Token: 0x0601193B RID: 71995
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotBar_GetColorSeries_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the color series used if when this is a stacked bar plot.
		/// </summary>
		// Token: 0x0601193C RID: 71996 RVA: 0x00188CD4 File Offset: 0x00186ED4
		public vtkColorSeries GetColorSeries()
		{
			vtkColorSeries vtkColorSeries = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotBar.vtkPlotBar_GetColorSeries_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkColorSeries = (vtkColorSeries)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkColorSeries.Register(null);
				}
			}
			return vtkColorSeries;
		}

		// Token: 0x0601193D RID: 71997
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotBar_GetDataBounds_10(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Get the data bounds for this mapper as (Xmin,Xmax).
		/// </summary>
		// Token: 0x0601193E RID: 71998 RVA: 0x00188D43 File Offset: 0x00186F43
		public void GetDataBounds(IntPtr bounds)
		{
			vtkPlotBar.vtkPlotBar_GetDataBounds_10(base.GetCppThis(), bounds);
		}

		// Token: 0x0601193F RID: 71999
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlotBar_GetEnableOpacityMapping_11(HandleRef pThis);

		/// <summary>
		/// Enable/disable mapping of the opacity values. Default is set to true.
		/// </summary>
		// Token: 0x06011940 RID: 72000 RVA: 0x00188D54 File Offset: 0x00186F54
		public virtual bool GetEnableOpacityMapping()
		{
			return vtkPlotBar.vtkPlotBar_GetEnableOpacityMapping_11(base.GetCppThis()) != 0;
		}

		// Token: 0x06011941 RID: 72001
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkPlotBar_GetGroupName_12(HandleRef pThis);

		/// <summary>
		/// Get the group name of the bar char - can be displayed on the X axis.
		/// </summary>
		// Token: 0x06011942 RID: 72002 RVA: 0x00188D7C File Offset: 0x00186F7C
		public virtual string GetGroupName()
		{
			return vtkPlotBar.vtkPlotBar_GetGroupName_12(base.GetCppThis());
		}

		// Token: 0x06011943 RID: 72003
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotBar_GetLabels_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the plot labels.
		/// </summary>
		// Token: 0x06011944 RID: 72004 RVA: 0x00188D9C File Offset: 0x00186F9C
		public override vtkStringArray GetLabels()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotBar.vtkPlotBar_GetLabels_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06011945 RID: 72005
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotBar_GetLookupTable_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify a lookup table for the mapper to use.
		/// </summary>
		// Token: 0x06011946 RID: 72006 RVA: 0x00188E0C File Offset: 0x0018700C
		public virtual vtkScalarsToColors GetLookupTable()
		{
			vtkScalarsToColors vtkScalarsToColors = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotBar.vtkPlotBar_GetLookupTable_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScalarsToColors = (vtkScalarsToColors)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScalarsToColors.Register(null);
				}
			}
			return vtkScalarsToColors;
		}

		// Token: 0x06011947 RID: 72007
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlotBar_GetNearestPoint_15(HandleRef pThis, HandleRef point, HandleRef arg1, HandleRef location, IntPtr segmentIndex);

		/// <summary>
		/// Function to query a plot for the nearest point to the specified coordinate.
		/// Returns the index of the data series with which the point is associated or
		/// -1.
		/// If a vtkIdType* is passed, its referent will be set to index of the bar
		/// segment with which a point is associated, or -1.
		/// </summary>
		// Token: 0x06011948 RID: 72008 RVA: 0x00188E7C File Offset: 0x0018707C
		public override long GetNearestPoint(vtkVector2f point, vtkVector2f arg1, vtkVector2f location, IntPtr segmentIndex)
		{
			return vtkPlotBar.vtkPlotBar_GetNearestPoint_15(base.GetCppThis(), (point == null) ? default(HandleRef) : point.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis(), (location == null) ? default(HandleRef) : location.GetCppThis(), segmentIndex);
		}

		// Token: 0x06011949 RID: 72009
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlotBar_GetNumberOfGenerationsFromBase_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601194A RID: 72010 RVA: 0x00188EDC File Offset: 0x001870DC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPlotBar.vtkPlotBar_GetNumberOfGenerationsFromBase_16(base.GetCppThis(), type);
		}

		// Token: 0x0601194B RID: 72011
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlotBar_GetNumberOfGenerationsFromBaseType_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601194C RID: 72012 RVA: 0x00188EFC File Offset: 0x001870FC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPlotBar.vtkPlotBar_GetNumberOfGenerationsFromBaseType_17(type);
		}

		// Token: 0x0601194D RID: 72013
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkPlotBar_GetOffset_18(HandleRef pThis);

		/// <summary>
		/// Set/get the horizontal offset of the bars.
		/// Positive values move the bars leftward.
		/// For HORIZONTAL orientation, offsets bars vertically,
		/// with a positive value moving bars downward.
		/// </summary>
		// Token: 0x0601194E RID: 72014 RVA: 0x00188F18 File Offset: 0x00187118
		public virtual float GetOffset()
		{
			return vtkPlotBar.vtkPlotBar_GetOffset_18(base.GetCppThis());
		}

		// Token: 0x0601194F RID: 72015
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlotBar_GetOrientation_19(HandleRef pThis);

		/// <summary>
		/// Set/get the orientation of the bars.
		/// Valid orientations are VERTICAL (default) and HORIZONTAL.
		/// </summary>
		// Token: 0x06011950 RID: 72016 RVA: 0x00188F38 File Offset: 0x00187138
		public virtual int GetOrientation()
		{
			return vtkPlotBar.vtkPlotBar_GetOrientation_19(base.GetCppThis());
		}

		// Token: 0x06011951 RID: 72017
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlotBar_GetScalarVisibility_20(HandleRef pThis);

		/// <summary>
		/// Turn on/off flag to control whether scalar data is used to color objects.
		/// </summary>
		// Token: 0x06011952 RID: 72018 RVA: 0x00188F58 File Offset: 0x00187158
		public virtual bool GetScalarVisibility()
		{
			return vtkPlotBar.vtkPlotBar_GetScalarVisibility_20(base.GetCppThis()) != 0;
		}

		// Token: 0x06011953 RID: 72019
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkPlotBar_GetTooltipLabel_21(HandleRef pThis, HandleRef plotPos, long seriesIndex, long segmentIndex);

		/// <summary>
		/// Generate and return the tooltip label string for this plot
		/// The segmentIndex is implemented here.
		/// </summary>
		// Token: 0x06011954 RID: 72020 RVA: 0x00188F80 File Offset: 0x00187180
		public override string GetTooltipLabel(vtkVector2d plotPos, long seriesIndex, long segmentIndex)
		{
			return vtkPlotBar.vtkPlotBar_GetTooltipLabel_21(base.GetCppThis(), (plotPos == null) ? default(HandleRef) : plotPos.GetCppThis(), seriesIndex, segmentIndex);
		}

		// Token: 0x06011955 RID: 72021
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotBar_GetUnscaledInputBounds_22(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Get un-log-scaled bounds for this mapper as (Xmin,Xmax,Ymin,Ymax).
		/// </summary>
		// Token: 0x06011956 RID: 72022 RVA: 0x00188FB6 File Offset: 0x001871B6
		public override void GetUnscaledInputBounds(IntPtr bounds)
		{
			vtkPlotBar.vtkPlotBar_GetUnscaledInputBounds_22(base.GetCppThis(), bounds);
		}

		// Token: 0x06011957 RID: 72023
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkPlotBar_GetWidth_23(HandleRef pThis);

		/// <summary>
		/// Get the width of the line.
		/// </summary>
		// Token: 0x06011958 RID: 72024 RVA: 0x00188FC8 File Offset: 0x001871C8
		public override float GetWidth()
		{
			return vtkPlotBar.vtkPlotBar_GetWidth_23(base.GetCppThis());
		}

		// Token: 0x06011959 RID: 72025
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlotBar_IsA_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601195A RID: 72026 RVA: 0x00188FE8 File Offset: 0x001871E8
		public override int IsA(string type)
		{
			return vtkPlotBar.vtkPlotBar_IsA_24(base.GetCppThis(), type);
		}

		// Token: 0x0601195B RID: 72027
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlotBar_IsTypeOf_25([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601195C RID: 72028 RVA: 0x00189008 File Offset: 0x00187208
		public new static int IsTypeOf(string type)
		{
			return vtkPlotBar.vtkPlotBar_IsTypeOf_25(type);
		}

		// Token: 0x0601195D RID: 72029
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotBar_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601195E RID: 72030 RVA: 0x00189024 File Offset: 0x00187224
		public new vtkPlotBar NewInstance()
		{
			vtkPlotBar result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotBar.vtkPlotBar_NewInstance_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlotBar)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601195F RID: 72031
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlotBar_Paint_28(HandleRef pThis, HandleRef painter);

		/// <summary>
		/// Paint event for the XY plot, called whenever the chart needs to be drawn
		/// </summary>
		// Token: 0x06011960 RID: 72032 RVA: 0x00189080 File Offset: 0x00187280
		public override bool Paint(vtkContext2D painter)
		{
			return vtkPlotBar.vtkPlotBar_Paint_28(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		// Token: 0x06011961 RID: 72033
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlotBar_PaintLegend_29(HandleRef pThis, HandleRef painter, HandleRef rect, int legendIndex);

		/// <summary>
		/// Paint legend event for the XY plot, called whenever the legend needs the
		/// plot items symbol/mark/line drawn. A rect is supplied with the lower left
		/// corner of the rect (elements 0 and 1) and with width x height (elements 2
		/// and 3). The plot can choose how to fill the space supplied.
		/// </summary>
		// Token: 0x06011962 RID: 72034 RVA: 0x001890BC File Offset: 0x001872BC
		public override bool PaintLegend(vtkContext2D painter, vtkRectf rect, int legendIndex)
		{
			return vtkPlotBar.vtkPlotBar_PaintLegend_29(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis(), (rect == null) ? default(HandleRef) : rect.GetCppThis(), legendIndex) != 0;
		}

		// Token: 0x06011963 RID: 72035
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotBar_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011964 RID: 72036 RVA: 0x00189110 File Offset: 0x00187310
		public new static vtkPlotBar SafeDownCast(vtkObjectBase o)
		{
			vtkPlotBar vtkPlotBar = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotBar.vtkPlotBar_SafeDownCast_30((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06011965 RID: 72037
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotBar_ScalarVisibilityOff_31(HandleRef pThis);

		/// <summary>
		/// Turn on/off flag to control whether scalar data is used to color objects.
		/// </summary>
		// Token: 0x06011966 RID: 72038 RVA: 0x0018918F File Offset: 0x0018738F
		public virtual void ScalarVisibilityOff()
		{
			vtkPlotBar.vtkPlotBar_ScalarVisibilityOff_31(base.GetCppThis());
		}

		// Token: 0x06011967 RID: 72039
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotBar_ScalarVisibilityOn_32(HandleRef pThis);

		/// <summary>
		/// Turn on/off flag to control whether scalar data is used to color objects.
		/// </summary>
		// Token: 0x06011968 RID: 72040 RVA: 0x0018919E File Offset: 0x0018739E
		public virtual void ScalarVisibilityOn()
		{
			vtkPlotBar.vtkPlotBar_ScalarVisibilityOn_32(base.GetCppThis());
		}

		// Token: 0x06011969 RID: 72041
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotBar_SelectColorArray_33(HandleRef pThis, long arrayNum);

		/// <summary>
		/// When ScalarMode is set to UsePointFieldData or UseCellFieldData,
		/// you can specify which array to use for coloring using these methods.
		/// The lookup table will decide how to convert vectors to colors.
		/// </summary>
		// Token: 0x0601196A RID: 72042 RVA: 0x001891AD File Offset: 0x001873AD
		public void SelectColorArray(long arrayNum)
		{
			vtkPlotBar.vtkPlotBar_SelectColorArray_33(base.GetCppThis(), arrayNum);
		}

		// Token: 0x0601196B RID: 72043
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotBar_SelectColorArray_34(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName);

		/// <summary>
		/// When ScalarMode is set to UsePointFieldData or UseCellFieldData,
		/// you can specify which array to use for coloring using these methods.
		/// The lookup table will decide how to convert vectors to colors.
		/// </summary>
		// Token: 0x0601196C RID: 72044 RVA: 0x001891BD File Offset: 0x001873BD
		public void SelectColorArray(string arrayName)
		{
			vtkPlotBar.vtkPlotBar_SelectColorArray_34(base.GetCppThis(), arrayName);
		}

		// Token: 0x0601196D RID: 72045
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlotBar_SelectPoints_35(HandleRef pThis, HandleRef min, HandleRef max);

		/// <summary>
		/// Select all points in the specified rectangle.
		/// </summary>
		// Token: 0x0601196E RID: 72046 RVA: 0x001891D0 File Offset: 0x001873D0
		public override bool SelectPoints(vtkVector2f min, vtkVector2f max)
		{
			return vtkPlotBar.vtkPlotBar_SelectPoints_35(base.GetCppThis(), (min == null) ? default(HandleRef) : min.GetCppThis(), (max == null) ? default(HandleRef) : max.GetCppThis()) != 0;
		}

		// Token: 0x0601196F RID: 72047
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotBar_SetColor_36(HandleRef pThis, byte r, byte g, byte b, byte a);

		/// <summary>
		/// Set the plot color with integer values (comprised between 0 and 255)
		/// </summary>
		// Token: 0x06011970 RID: 72048 RVA: 0x00189220 File Offset: 0x00187420
		public override void SetColor(byte r, byte g, byte b, byte a)
		{
			vtkPlotBar.vtkPlotBar_SetColor_36(base.GetCppThis(), r, g, b, a);
		}

		// Token: 0x06011971 RID: 72049
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotBar_SetColorF_37(HandleRef pThis, double r, double g, double b, double a);

		/// <summary>
		/// Set the plot color with floating values (comprised between 0.0 and 1.0)
		/// </summary>
		// Token: 0x06011972 RID: 72050 RVA: 0x00189234 File Offset: 0x00187434
		public override void SetColorF(double r, double g, double b, double a)
		{
			vtkPlotBar.vtkPlotBar_SetColorF_37(base.GetCppThis(), r, g, b, a);
		}

		// Token: 0x06011973 RID: 72051
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotBar_SetColorF_38(HandleRef pThis, double r, double g, double b);

		/// <summary>
		/// Set the plot color with floating values (comprised between 0.0 and 1.0)
		/// </summary>
		// Token: 0x06011974 RID: 72052 RVA: 0x00189248 File Offset: 0x00187448
		public override void SetColorF(double r, double g, double b)
		{
			vtkPlotBar.vtkPlotBar_SetColorF_38(base.GetCppThis(), r, g, b);
		}

		// Token: 0x06011975 RID: 72053
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotBar_SetColorSeries_39(HandleRef pThis, HandleRef colorSeries);

		/// <summary>
		/// Set the color series to use if this becomes a stacked bar plot.
		/// </summary>
		// Token: 0x06011976 RID: 72054 RVA: 0x0018925C File Offset: 0x0018745C
		public void SetColorSeries(vtkColorSeries colorSeries)
		{
			vtkPlotBar.vtkPlotBar_SetColorSeries_39(base.GetCppThis(), (colorSeries == null) ? default(HandleRef) : colorSeries.GetCppThis());
		}

		// Token: 0x06011977 RID: 72055
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotBar_SetEnableOpacityMapping_40(HandleRef pThis, byte _arg);

		/// <summary>
		/// Enable/disable mapping of the opacity values. Default is set to true.
		/// </summary>
		// Token: 0x06011978 RID: 72056 RVA: 0x0018928B File Offset: 0x0018748B
		public virtual void SetEnableOpacityMapping(bool _arg)
		{
			vtkPlotBar.vtkPlotBar_SetEnableOpacityMapping_40(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06011979 RID: 72057
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotBar_SetGroupName_41(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Set the group name of the bar chart - can be displayed on the X axis.
		/// </summary>
		// Token: 0x0601197A RID: 72058 RVA: 0x001892A3 File Offset: 0x001874A3
		public virtual void SetGroupName(string name)
		{
			vtkPlotBar.vtkPlotBar_SetGroupName_41(base.GetCppThis(), name);
		}

		// Token: 0x0601197B RID: 72059
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotBar_SetInputArray_42(HandleRef pThis, int index, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// When used to set additional arrays, stacked bars are created.
		/// </summary>
		// Token: 0x0601197C RID: 72060 RVA: 0x001892B3 File Offset: 0x001874B3
		public override void SetInputArray(int index, string name)
		{
			vtkPlotBar.vtkPlotBar_SetInputArray_42(base.GetCppThis(), index, name);
		}

		// Token: 0x0601197D RID: 72061
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotBar_SetLookupTable_43(HandleRef pThis, HandleRef lut);

		/// <summary>
		/// Specify a lookup table for the mapper to use.
		/// </summary>
		// Token: 0x0601197E RID: 72062 RVA: 0x001892C4 File Offset: 0x001874C4
		public virtual void SetLookupTable(vtkScalarsToColors lut)
		{
			vtkPlotBar.vtkPlotBar_SetLookupTable_43(base.GetCppThis(), (lut == null) ? default(HandleRef) : lut.GetCppThis());
		}

		// Token: 0x0601197F RID: 72063
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotBar_SetOffset_44(HandleRef pThis, float _arg);

		/// <summary>
		/// Set/get the horizontal offset of the bars.
		/// Positive values move the bars leftward.
		/// For HORIZONTAL orientation, offsets bars vertically,
		/// with a positive value moving bars downward.
		/// </summary>
		// Token: 0x06011980 RID: 72064 RVA: 0x001892F3 File Offset: 0x001874F3
		public virtual void SetOffset(float _arg)
		{
			vtkPlotBar.vtkPlotBar_SetOffset_44(base.GetCppThis(), _arg);
		}

		// Token: 0x06011981 RID: 72065
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotBar_SetOrientation_45(HandleRef pThis, int orientation);

		/// <summary>
		/// Set/get the orientation of the bars.
		/// Valid orientations are VERTICAL (default) and HORIZONTAL.
		/// </summary>
		// Token: 0x06011982 RID: 72066 RVA: 0x00189303 File Offset: 0x00187503
		public virtual void SetOrientation(int orientation)
		{
			vtkPlotBar.vtkPlotBar_SetOrientation_45(base.GetCppThis(), orientation);
		}

		// Token: 0x06011983 RID: 72067
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotBar_SetScalarVisibility_46(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on/off flag to control whether scalar data is used to color objects.
		/// </summary>
		// Token: 0x06011984 RID: 72068 RVA: 0x00189313 File Offset: 0x00187513
		public virtual void SetScalarVisibility(bool _arg)
		{
			vtkPlotBar.vtkPlotBar_SetScalarVisibility_46(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06011985 RID: 72069
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotBar_SetWidth_47(HandleRef pThis, float _arg);

		/// <summary>
		/// Set the width of the line.
		/// </summary>
		// Token: 0x06011986 RID: 72070 RVA: 0x0018932B File Offset: 0x0018752B
		public override void SetWidth(float _arg)
		{
			vtkPlotBar.vtkPlotBar_SetWidth_47(base.GetCppThis(), _arg);
		}

		// Token: 0x06011987 RID: 72071
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlotBar_UpdateCache_48(HandleRef pThis);

		/// <summary>
		/// Update the internal cache. Returns true if cache was successfully updated. Default does
		/// nothing.
		/// This method is called by Update() when either the plot's data has changed or
		/// CacheRequiresUpdate() returns true. It is not necessary to call this method explicitly.
		/// </summary>
		// Token: 0x06011988 RID: 72072 RVA: 0x0018933C File Offset: 0x0018753C
		public override bool UpdateCache()
		{
			return vtkPlotBar.vtkPlotBar_UpdateCache_48(base.GetCppThis()) != 0;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001449 RID: 5193
		public new const string MRFullTypeName = "Kitware.VTK.vtkPlotBar";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400144A RID: 5194
		public new static readonly string MRClassNameKey = "class vtkPlotBar";

		/// <summary>
		/// Enum of bar chart oritentation types
		/// </summary>
		// Token: 0x0200065B RID: 1627
		public enum HORIZONTAL_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x0400144C RID: 5196
			HORIZONTAL = 1,
			/// <summary>enum member</summary>
			// Token: 0x0400144D RID: 5197
			VERTICAL = 0
		}
	}
}
