using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkChartXYZ
	/// </summary>
	/// <remarks>
	///    Factory class for drawing 3D XYZ charts.
	///
	///
	/// </remarks>
	// Token: 0x02000642 RID: 1602
	public class vtkChartXYZ : vtkContextItem
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011547 RID: 70983 RVA: 0x00182AAA File Offset: 0x00180CAA
		static vtkChartXYZ()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkChartXYZ.MRClassNameKey, Type.GetType("Kitware.VTK.vtkChartXYZ"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011548 RID: 70984 RVA: 0x00182AD2 File Offset: 0x00180CD2
		public vtkChartXYZ(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011549 RID: 70985
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartXYZ_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601154A RID: 70986 RVA: 0x00182AE0 File Offset: 0x00180CE0
		public new static vtkChartXYZ New()
		{
			vtkChartXYZ result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartXYZ.vtkChartXYZ_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkChartXYZ)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601154B RID: 70987 RVA: 0x00182B34 File Offset: 0x00180D34
		public vtkChartXYZ() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkChartXYZ.vtkChartXYZ_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601154C RID: 70988 RVA: 0x00182B78 File Offset: 0x00180D78
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601154D RID: 70989
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkChartXYZ_AddPlot_01(HandleRef pThis, HandleRef plot);

		/// <summary>
		/// Adds a plot to the chart.
		/// </summary>
		// Token: 0x0601154E RID: 70990 RVA: 0x00182B84 File Offset: 0x00180D84
		public virtual long AddPlot(vtkPlot3D plot)
		{
			return vtkChartXYZ.vtkChartXYZ_AddPlot_01(base.GetCppThis(), (plot == null) ? default(HandleRef) : plot.GetCppThis());
		}

		// Token: 0x0601154F RID: 70991
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXYZ_ClearPlots_02(HandleRef pThis);

		/// <summary>
		/// Remove all the plots from this chart.
		/// </summary>
		// Token: 0x06011550 RID: 70992 RVA: 0x00182BB8 File Offset: 0x00180DB8
		public void ClearPlots()
		{
			vtkChartXYZ.vtkChartXYZ_ClearPlots_02(base.GetCppThis());
		}

		// Token: 0x06011551 RID: 70993
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartXYZ_GetAxesTextProperty_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the text property for axes. Useful for changing font size, font family, font file.
		///
		/// For example to use a larger font which is capable of displaying unicode values change
		/// the property like this:
		///
		///   chart-&gt;GetAxesTextProperty()-&gt;SetFontFamily(VTK_FONT_FILE);
		///   chart-&gt;GetAxesTextProperty()-&gt;SetFontFile("fonts/DejaVuSans.ttf");
		///   chart-&gt;GetAxesTextProperty()-&gt;SetFontSize(32);
		///
		/// You'll need a unicode capable font in a suitable location.
		///
		/// Now to get the X axis to display Theta subscript (0) set the label like this using
		/// the hex unicode representation:
		///
		///   chart-&gt;SetXAxisLabel("\xcf\xb4\xe2\x82\x8d\xe2\x82\x80\xe2\x82\x8e");
		///
		/// @return
		/// </summary>
		// Token: 0x06011552 RID: 70994 RVA: 0x00182BC8 File Offset: 0x00180DC8
		public vtkTextProperty GetAxesTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartXYZ.vtkChartXYZ_GetAxesTextProperty_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06011553 RID: 70995
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartXYZ_GetAxis_04(HandleRef pThis, int axis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the x (0), y (1) or z (2) axis.
		/// </summary>
		// Token: 0x06011554 RID: 70996 RVA: 0x00182C38 File Offset: 0x00180E38
		public vtkAxis GetAxis(int axis)
		{
			vtkAxis vtkAxis = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartXYZ.vtkChartXYZ_GetAxis_04(base.GetCppThis(), axis, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06011555 RID: 70997
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartXYZ_GetAxisColor_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the color for the axes.
		/// </summary>
		// Token: 0x06011556 RID: 70998 RVA: 0x00182CA8 File Offset: 0x00180EA8
		public vtkColor4ub GetAxisColor()
		{
			vtkColor4ub result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartXYZ.vtkChartXYZ_GetAxisColor_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkColor4ub)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011557 RID: 70999
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkChartXYZ_GetClippingPlanesEnabled_06(HandleRef pThis);

		/// <summary>
		/// Check whether data outside the box will be hidden or not.
		/// </summary>
		// Token: 0x06011558 RID: 71000 RVA: 0x00182D04 File Offset: 0x00180F04
		public virtual bool GetClippingPlanesEnabled()
		{
			return vtkChartXYZ.vtkChartXYZ_GetClippingPlanesEnabled_06(base.GetCppThis()) != 0;
		}

		// Token: 0x06011559 RID: 71001
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkChartXYZ_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601155A RID: 71002 RVA: 0x00182D2C File Offset: 0x00180F2C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkChartXYZ.vtkChartXYZ_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0601155B RID: 71003
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkChartXYZ_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601155C RID: 71004 RVA: 0x00182D4C File Offset: 0x00180F4C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkChartXYZ.vtkChartXYZ_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x0601155D RID: 71005
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkChartXYZ_GetScaleBoxWithPlot_09(HandleRef pThis);

		/// <summary>
		/// Check whether scaling the plot will also scale the box.
		/// </summary>
		// Token: 0x0601155E RID: 71006 RVA: 0x00182D68 File Offset: 0x00180F68
		public virtual bool GetScaleBoxWithPlot()
		{
			return vtkChartXYZ.vtkChartXYZ_GetScaleBoxWithPlot_09(base.GetCppThis()) != 0;
		}

		// Token: 0x0601155F RID: 71007
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkChartXYZ_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011560 RID: 71008 RVA: 0x00182D90 File Offset: 0x00180F90
		public override int IsA(string type)
		{
			return vtkChartXYZ.vtkChartXYZ_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x06011561 RID: 71009
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkChartXYZ_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011562 RID: 71010 RVA: 0x00182DB0 File Offset: 0x00180FB0
		public new static int IsTypeOf(string type)
		{
			return vtkChartXYZ.vtkChartXYZ_IsTypeOf_11(type);
		}

		// Token: 0x06011563 RID: 71011
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartXYZ_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011564 RID: 71012 RVA: 0x00182DCC File Offset: 0x00180FCC
		public new vtkChartXYZ NewInstance()
		{
			vtkChartXYZ result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartXYZ.vtkChartXYZ_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkChartXYZ)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011565 RID: 71013
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkChartXYZ_Paint_14(HandleRef pThis, HandleRef painter);

		/// <summary>
		/// Paint event for the chart, called whenever the chart needs to be drawn.
		/// </summary>
		// Token: 0x06011566 RID: 71014 RVA: 0x00182E28 File Offset: 0x00181028
		public override bool Paint(vtkContext2D painter)
		{
			return vtkChartXYZ.vtkChartXYZ_Paint_14(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		// Token: 0x06011567 RID: 71015
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXYZ_RecalculateBounds_15(HandleRef pThis);

		/// <summary>
		/// Determine the XYZ bounds of the plots within this chart.
		/// This information is then used to set the range of the axes.
		/// </summary>
		// Token: 0x06011568 RID: 71016 RVA: 0x00182E63 File Offset: 0x00181063
		public void RecalculateBounds()
		{
			vtkChartXYZ.vtkChartXYZ_RecalculateBounds_15(base.GetCppThis());
		}

		// Token: 0x06011569 RID: 71017
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXYZ_RecalculateTransform_16(HandleRef pThis);

		/// <summary>
		/// Use this chart's Geometry to set the endpoints of its axes.
		/// This method also sets up a transformation that is used to
		/// properly render the data within the chart.
		/// </summary>
		// Token: 0x0601156A RID: 71018 RVA: 0x00182E72 File Offset: 0x00181072
		public void RecalculateTransform()
		{
			vtkChartXYZ.vtkChartXYZ_RecalculateTransform_16(base.GetCppThis());
		}

		// Token: 0x0601156B RID: 71019
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkChartXYZ_RemovePlot_17(HandleRef pThis, HandleRef plot);

		/// <summary>
		/// Removes a plot from the chart.
		/// </summary>
		// Token: 0x0601156C RID: 71020 RVA: 0x00182E84 File Offset: 0x00181084
		public virtual bool RemovePlot(vtkPlot3D plot)
		{
			return vtkChartXYZ.vtkChartXYZ_RemovePlot_17(base.GetCppThis(), (plot == null) ? default(HandleRef) : plot.GetCppThis()) != 0;
		}

		// Token: 0x0601156D RID: 71021
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartXYZ_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601156E RID: 71022 RVA: 0x00182EC0 File Offset: 0x001810C0
		public new static vtkChartXYZ SafeDownCast(vtkObjectBase o)
		{
			vtkChartXYZ vtkChartXYZ = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartXYZ.vtkChartXYZ_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkChartXYZ = (vtkChartXYZ)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkChartXYZ.Register(null);
				}
			}
			return vtkChartXYZ;
		}

		// Token: 0x0601156F RID: 71023
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXYZ_SetAngle_19(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the rotation angle for the chart (AutoRotate mode only).
		/// </summary>
		// Token: 0x06011570 RID: 71024 RVA: 0x00182F3F File Offset: 0x0018113F
		public virtual void SetAngle(double _arg)
		{
			vtkChartXYZ.vtkChartXYZ_SetAngle_19(base.GetCppThis(), _arg);
		}

		// Token: 0x06011571 RID: 71025
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXYZ_SetAnnotationLink_20(HandleRef pThis, HandleRef link);

		/// <summary>
		/// Set the vtkAnnotationLink for the chart.
		/// </summary>
		// Token: 0x06011572 RID: 71026 RVA: 0x00182F50 File Offset: 0x00181150
		public virtual void SetAnnotationLink(vtkAnnotationLink link)
		{
			vtkChartXYZ.vtkChartXYZ_SetAnnotationLink_20(base.GetCppThis(), (link == null) ? default(HandleRef) : link.GetCppThis());
		}

		// Token: 0x06011573 RID: 71027
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXYZ_SetAroundX_21(HandleRef pThis, byte isX);

		/// <summary>
		/// Set whether or not we're rotating about the X axis.
		/// </summary>
		// Token: 0x06011574 RID: 71028 RVA: 0x00182F7F File Offset: 0x0018117F
		public void SetAroundX(bool isX)
		{
			vtkChartXYZ.vtkChartXYZ_SetAroundX_21(base.GetCppThis(), isX ? (byte)1 : (byte)0);
		}

		// Token: 0x06011575 RID: 71029
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXYZ_SetAutoRotate_22(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set whether or not we're using this chart to rotate on a timer.
		/// Default value is false.
		/// </summary>
		// Token: 0x06011576 RID: 71030 RVA: 0x00182F97 File Offset: 0x00181197
		public virtual void SetAutoRotate(bool _arg)
		{
			vtkChartXYZ.vtkChartXYZ_SetAutoRotate_22(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06011577 RID: 71031
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXYZ_SetAxis_23(HandleRef pThis, int axisIndex, HandleRef axis);

		/// <summary>
		/// Set the x (0), y (1) or z (2) axis.
		/// </summary>
		// Token: 0x06011578 RID: 71032 RVA: 0x00182FB0 File Offset: 0x001811B0
		public virtual void SetAxis(int axisIndex, vtkAxis axis)
		{
			vtkChartXYZ.vtkChartXYZ_SetAxis_23(base.GetCppThis(), axisIndex, (axis == null) ? default(HandleRef) : axis.GetCppThis());
		}

		// Token: 0x06011579 RID: 71033
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXYZ_SetAxisColor_24(HandleRef pThis, HandleRef color);

		/// <summary>
		/// Set the color for the axes.
		/// </summary>
		// Token: 0x0601157A RID: 71034 RVA: 0x00182FE0 File Offset: 0x001811E0
		public void SetAxisColor(vtkColor4ub color)
		{
			vtkChartXYZ.vtkChartXYZ_SetAxisColor_24(base.GetCppThis(), (color == null) ? default(HandleRef) : color.GetCppThis());
		}

		// Token: 0x0601157B RID: 71035
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXYZ_SetClippingPlanesEnabled_25(HandleRef pThis, byte arg0);

		/// <summary>
		/// Hide data outside the box.
		/// </summary>
		// Token: 0x0601157C RID: 71036 RVA: 0x0018300F File Offset: 0x0018120F
		public void SetClippingPlanesEnabled(bool arg0)
		{
			vtkChartXYZ.vtkChartXYZ_SetClippingPlanesEnabled_25(base.GetCppThis(), arg0 ? (byte)1 : (byte)0);
		}

		// Token: 0x0601157D RID: 71037
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXYZ_SetDecorateAxes_26(HandleRef pThis, byte b);

		/// <summary>
		/// Set whether or not axes labels &amp; tick marks should be drawn.
		/// Default value is true.
		/// </summary>
		// Token: 0x0601157E RID: 71038 RVA: 0x00183027 File Offset: 0x00181227
		public void SetDecorateAxes(bool b)
		{
			vtkChartXYZ.vtkChartXYZ_SetDecorateAxes_26(base.GetCppThis(), b ? (byte)1 : (byte)0);
		}

		// Token: 0x0601157F RID: 71039
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXYZ_SetEnsureOuterEdgeAxisLabelling_27(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set to true to ensure that axis labels are always on the outer edges of the chart.
		/// Default is false, the legacy behaviour, for backwards compatibility, where axis
		/// labelling may occur on inner or back edges.
		/// </summary>
		// Token: 0x06011580 RID: 71040 RVA: 0x0018303F File Offset: 0x0018123F
		public virtual void SetEnsureOuterEdgeAxisLabelling(bool _arg)
		{
			vtkChartXYZ.vtkChartXYZ_SetEnsureOuterEdgeAxisLabelling_27(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06011581 RID: 71041
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXYZ_SetFitToScene_28(HandleRef pThis, byte b);

		/// <summary>
		/// Set whether or not the chart should automatically resize itself to fill
		/// the scene.  Default value is true.
		/// </summary>
		// Token: 0x06011582 RID: 71042 RVA: 0x00183057 File Offset: 0x00181257
		public void SetFitToScene(bool b)
		{
			vtkChartXYZ.vtkChartXYZ_SetFitToScene_28(base.GetCppThis(), b ? (byte)1 : (byte)0);
		}

		// Token: 0x06011583 RID: 71043
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXYZ_SetGeometry_29(HandleRef pThis, HandleRef bounds);

		/// <summary>
		/// Set the geometry in pixel coordinates (origin and width/height).
		/// This method also sets up the end points of the axes of the chart.
		/// For this reason, if you call SetAroundX(), you should call SetGeometry()
		/// afterwards.
		///
		/// This method will result in a plot with a fixed size. If you want it to scale
		/// with the scene then use SetMargins.
		/// </summary>
		// Token: 0x06011584 RID: 71044 RVA: 0x00183070 File Offset: 0x00181270
		public void SetGeometry(vtkRectf bounds)
		{
			vtkChartXYZ.vtkChartXYZ_SetGeometry_29(base.GetCppThis(), (bounds == null) ? default(HandleRef) : bounds.GetCppThis());
		}

		// Token: 0x06011585 RID: 71045
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXYZ_SetMargins_30(HandleRef pThis, vtkVector4i margins);

		/// <summary>
		/// Set the margins in pixels ordered top right bottom left
		/// The box will be drawn inside those margins, but the labels and textdecorations will still
		/// escape. Note that the width and height automatically adapt to those of the scene.
		///
		/// If you want a fixed size instead then use SetGeometry.
		/// </summary>
		// Token: 0x06011586 RID: 71046 RVA: 0x0018309F File Offset: 0x0018129F
		public void SetMargins(vtkVector4i margins)
		{
			vtkChartXYZ.vtkChartXYZ_SetMargins_30(base.GetCppThis(), margins);
		}

		// Token: 0x06011587 RID: 71047
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXYZ_SetScaleBoxWithPlot_31(HandleRef pThis, byte _arg);

		/// <summary>
		/// When rotating the mousewheel, scale not only the plot but also the box.
		/// </summary>
		// Token: 0x06011588 RID: 71048 RVA: 0x001830AF File Offset: 0x001812AF
		public virtual void SetScaleBoxWithPlot(bool _arg)
		{
			vtkChartXYZ.vtkChartXYZ_SetScaleBoxWithPlot_31(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06011589 RID: 71049
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXYZ_SetXAxisLabel_32(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set the X axis label
		/// </summary>
		// Token: 0x0601158A RID: 71050 RVA: 0x001830C7 File Offset: 0x001812C7
		public virtual void SetXAxisLabel(string _arg)
		{
			vtkChartXYZ.vtkChartXYZ_SetXAxisLabel_32(base.GetCppThis(), _arg);
		}

		// Token: 0x0601158B RID: 71051
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXYZ_SetYAxisLabel_33(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set the Y axis label
		/// </summary>
		// Token: 0x0601158C RID: 71052 RVA: 0x001830D7 File Offset: 0x001812D7
		public virtual void SetYAxisLabel(string _arg)
		{
			vtkChartXYZ.vtkChartXYZ_SetYAxisLabel_33(base.GetCppThis(), _arg);
		}

		// Token: 0x0601158D RID: 71053
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXYZ_SetZAxisLabel_34(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set the Z axis label
		/// </summary>
		// Token: 0x0601158E RID: 71054 RVA: 0x001830E7 File Offset: 0x001812E7
		public virtual void SetZAxisLabel(string _arg)
		{
			vtkChartXYZ.vtkChartXYZ_SetZAxisLabel_34(base.GetCppThis(), _arg);
		}

		// Token: 0x0601158F RID: 71055
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartXYZ_Update_35(HandleRef pThis);

		/// <summary>
		/// Perform any updates to the item that may be necessary before rendering.
		/// </summary>
		// Token: 0x06011590 RID: 71056 RVA: 0x001830F7 File Offset: 0x001812F7
		public override void Update()
		{
			vtkChartXYZ.vtkChartXYZ_Update_35(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400140D RID: 5133
		public new const string MRFullTypeName = "Kitware.VTK.vtkChartXYZ";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400140E RID: 5134
		public new static readonly string MRClassNameKey = "class vtkChartXYZ";
	}
}
