using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPlotStacked
	/// </summary>
	/// <remarks>
	///    Class for drawing an stacked polygon plot
	/// given an X, Ybase, Yextent  in a vtkTable.
	///
	///
	///
	/// </remarks>
	// Token: 0x02000669 RID: 1641
	public class vtkPlotStacked : vtkPlot
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011B3F RID: 72511 RVA: 0x0018BFD2 File Offset: 0x0018A1D2
		static vtkPlotStacked()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPlotStacked.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlotStacked"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011B40 RID: 72512 RVA: 0x0018BFFA File Offset: 0x0018A1FA
		public vtkPlotStacked(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011B41 RID: 72513
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotStacked_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates a Stacked Plot Object
		/// </summary>
		// Token: 0x06011B42 RID: 72514 RVA: 0x0018C008 File Offset: 0x0018A208
		public new static vtkPlotStacked New()
		{
			vtkPlotStacked result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotStacked.vtkPlotStacked_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlotStacked)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Creates a Stacked Plot Object
		/// </summary>
		// Token: 0x06011B43 RID: 72515 RVA: 0x0018C05C File Offset: 0x0018A25C
		public vtkPlotStacked() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPlotStacked.vtkPlotStacked_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011B44 RID: 72516 RVA: 0x0018C0A0 File Offset: 0x0018A2A0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011B45 RID: 72517
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotStacked_GetBounds_01(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Get the bounds for this mapper as (Xmin,Xmax,Ymin,Ymax).
		/// </summary>
		// Token: 0x06011B46 RID: 72518 RVA: 0x0018C0AB File Offset: 0x0018A2AB
		public override void GetBounds(IntPtr bounds)
		{
			vtkPlotStacked.vtkPlotStacked_GetBounds_01(base.GetCppThis(), bounds);
		}

		// Token: 0x06011B47 RID: 72519
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotStacked_GetColorF_02(HandleRef pThis, IntPtr rgb);

		/// <summary>
		/// Get the plot color as floating rgb values (comprised between 0.0 and 1.0)
		/// </summary>
		// Token: 0x06011B48 RID: 72520 RVA: 0x0018C0BB File Offset: 0x0018A2BB
		public override void GetColorF(IntPtr rgb)
		{
			vtkPlotStacked.vtkPlotStacked_GetColorF_02(base.GetCppThis(), rgb);
		}

		// Token: 0x06011B49 RID: 72521
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotStacked_GetColorSeries_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the color series used if when this is a stacked bar plot.
		/// </summary>
		// Token: 0x06011B4A RID: 72522 RVA: 0x0018C0CC File Offset: 0x0018A2CC
		public vtkColorSeries GetColorSeries()
		{
			vtkColorSeries vtkColorSeries = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotStacked.vtkPlotStacked_GetColorSeries_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06011B4B RID: 72523
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotStacked_GetLabels_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the plot labels.
		/// </summary>
		// Token: 0x06011B4C RID: 72524 RVA: 0x0018C13C File Offset: 0x0018A33C
		public override vtkStringArray GetLabels()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotStacked.vtkPlotStacked_GetLabels_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06011B4D RID: 72525
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlotStacked_GetNearestPoint_05(HandleRef pThis, HandleRef point, HandleRef tolerance, HandleRef location, IntPtr segmentId);

		/// <summary>
		/// Function to query a plot for the nearest point to the specified coordinate.
		/// Returns the index of the data series with which the point is associated or
		/// -1.
		/// </summary>
		// Token: 0x06011B4E RID: 72526 RVA: 0x0018C1AC File Offset: 0x0018A3AC
		public override long GetNearestPoint(vtkVector2f point, vtkVector2f tolerance, vtkVector2f location, IntPtr segmentId)
		{
			return vtkPlotStacked.vtkPlotStacked_GetNearestPoint_05(base.GetCppThis(), (point == null) ? default(HandleRef) : point.GetCppThis(), (tolerance == null) ? default(HandleRef) : tolerance.GetCppThis(), (location == null) ? default(HandleRef) : location.GetCppThis(), segmentId);
		}

		// Token: 0x06011B4F RID: 72527
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlotStacked_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011B50 RID: 72528 RVA: 0x0018C20C File Offset: 0x0018A40C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPlotStacked.vtkPlotStacked_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x06011B51 RID: 72529
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlotStacked_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011B52 RID: 72530 RVA: 0x0018C22C File Offset: 0x0018A42C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPlotStacked.vtkPlotStacked_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x06011B53 RID: 72531
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotStacked_GetUnscaledInputBounds_08(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Get the unscaled input bounds for this mapper as (Xmin,Xmax,Ymin,Ymax).
		/// See vtkPlot for more information.
		/// </summary>
		// Token: 0x06011B54 RID: 72532 RVA: 0x0018C246 File Offset: 0x0018A446
		public override void GetUnscaledInputBounds(IntPtr bounds)
		{
			vtkPlotStacked.vtkPlotStacked_GetUnscaledInputBounds_08(base.GetCppThis(), bounds);
		}

		// Token: 0x06011B55 RID: 72533
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlotStacked_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011B56 RID: 72534 RVA: 0x0018C258 File Offset: 0x0018A458
		public override int IsA(string type)
		{
			return vtkPlotStacked.vtkPlotStacked_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x06011B57 RID: 72535
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlotStacked_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011B58 RID: 72536 RVA: 0x0018C278 File Offset: 0x0018A478
		public new static int IsTypeOf(string type)
		{
			return vtkPlotStacked.vtkPlotStacked_IsTypeOf_10(type);
		}

		// Token: 0x06011B59 RID: 72537
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotStacked_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011B5A RID: 72538 RVA: 0x0018C294 File Offset: 0x0018A494
		public new vtkPlotStacked NewInstance()
		{
			vtkPlotStacked result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotStacked.vtkPlotStacked_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlotStacked)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011B5B RID: 72539
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlotStacked_Paint_13(HandleRef pThis, HandleRef painter);

		/// <summary>
		/// Paint event for the Stacked plot, called whenever the chart needs to be drawn
		/// </summary>
		// Token: 0x06011B5C RID: 72540 RVA: 0x0018C2F0 File Offset: 0x0018A4F0
		public override bool Paint(vtkContext2D painter)
		{
			return vtkPlotStacked.vtkPlotStacked_Paint_13(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		// Token: 0x06011B5D RID: 72541
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlotStacked_PaintLegend_14(HandleRef pThis, HandleRef painter, HandleRef rect, int legendIndex);

		/// <summary>
		/// Paint legend event for the Stacked plot, called whenever the legend needs the
		/// plot items symbol/mark/line drawn. A rect is supplied with the lower left
		/// corner of the rect (elements 0 and 1) and with width x height (elements 2
		/// and 3). The plot can choose how to fill the space supplied.
		/// </summary>
		// Token: 0x06011B5E RID: 72542 RVA: 0x0018C32C File Offset: 0x0018A52C
		public override bool PaintLegend(vtkContext2D painter, vtkRectf rect, int legendIndex)
		{
			return vtkPlotStacked.vtkPlotStacked_PaintLegend_14(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis(), (rect == null) ? default(HandleRef) : rect.GetCppThis(), legendIndex) != 0;
		}

		// Token: 0x06011B5F RID: 72543
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotStacked_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011B60 RID: 72544 RVA: 0x0018C380 File Offset: 0x0018A580
		public new static vtkPlotStacked SafeDownCast(vtkObjectBase o)
		{
			vtkPlotStacked vtkPlotStacked = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotStacked.vtkPlotStacked_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlotStacked = (vtkPlotStacked)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlotStacked.Register(null);
				}
			}
			return vtkPlotStacked;
		}

		// Token: 0x06011B61 RID: 72545
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlotStacked_SelectPoints_16(HandleRef pThis, HandleRef min, HandleRef max);

		/// <summary>
		/// Select all points in the specified rectangle.
		/// </summary>
		// Token: 0x06011B62 RID: 72546 RVA: 0x0018C400 File Offset: 0x0018A600
		public override bool SelectPoints(vtkVector2f min, vtkVector2f max)
		{
			return vtkPlotStacked.vtkPlotStacked_SelectPoints_16(base.GetCppThis(), (min == null) ? default(HandleRef) : min.GetCppThis(), (max == null) ? default(HandleRef) : max.GetCppThis()) != 0;
		}

		// Token: 0x06011B63 RID: 72547
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotStacked_SetColor_17(HandleRef pThis, byte r, byte g, byte b, byte a);

		/// <summary>
		/// Set the plot color with integer values (comprised between 0 and 255)
		/// </summary>
		// Token: 0x06011B64 RID: 72548 RVA: 0x0018C450 File Offset: 0x0018A650
		public override void SetColor(byte r, byte g, byte b, byte a)
		{
			vtkPlotStacked.vtkPlotStacked_SetColor_17(base.GetCppThis(), r, g, b, a);
		}

		// Token: 0x06011B65 RID: 72549
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotStacked_SetColorF_18(HandleRef pThis, double r, double g, double b, double a);

		/// <summary>
		/// Set the plot color with floating values (comprised between 0.0 and 1.0)
		/// </summary>
		// Token: 0x06011B66 RID: 72550 RVA: 0x0018C464 File Offset: 0x0018A664
		public override void SetColorF(double r, double g, double b, double a)
		{
			vtkPlotStacked.vtkPlotStacked_SetColorF_18(base.GetCppThis(), r, g, b, a);
		}

		// Token: 0x06011B67 RID: 72551
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotStacked_SetColorF_19(HandleRef pThis, double r, double g, double b);

		/// <summary>
		/// Set the plot color with floating values (comprised between 0.0 and 1.0)
		/// </summary>
		// Token: 0x06011B68 RID: 72552 RVA: 0x0018C478 File Offset: 0x0018A678
		public override void SetColorF(double r, double g, double b)
		{
			vtkPlotStacked.vtkPlotStacked_SetColorF_19(base.GetCppThis(), r, g, b);
		}

		// Token: 0x06011B69 RID: 72553
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotStacked_SetColorSeries_20(HandleRef pThis, HandleRef colorSeries);

		/// <summary>
		/// Set the color series to use if this becomes a stacked bar plot.
		/// </summary>
		// Token: 0x06011B6A RID: 72554 RVA: 0x0018C48C File Offset: 0x0018A68C
		public void SetColorSeries(vtkColorSeries colorSeries)
		{
			vtkPlotStacked.vtkPlotStacked_SetColorSeries_20(base.GetCppThis(), (colorSeries == null) ? default(HandleRef) : colorSeries.GetCppThis());
		}

		// Token: 0x06011B6B RID: 72555
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotStacked_SetInputArray_21(HandleRef pThis, int index, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// When used to set additional arrays, stacked bars are created.
		/// </summary>
		// Token: 0x06011B6C RID: 72556 RVA: 0x0018C4BB File Offset: 0x0018A6BB
		public override void SetInputArray(int index, string name)
		{
			vtkPlotStacked.vtkPlotStacked_SetInputArray_21(base.GetCppThis(), index, name);
		}

		// Token: 0x06011B6D RID: 72557
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlotStacked_UpdateCache_22(HandleRef pThis);

		/// <summary>
		/// Update the internal cache. Returns true if cache was successfully updated. Default does
		/// nothing.
		/// This method is called by Update() when either the plot's data has changed or
		/// CacheRequiresUpdate() returns true. It is not necessary to call this method explicitly.
		/// </summary>
		// Token: 0x06011B6E RID: 72558 RVA: 0x0018C4CC File Offset: 0x0018A6CC
		public override bool UpdateCache()
		{
			return vtkPlotStacked.vtkPlotStacked_UpdateCache_22(base.GetCppThis()) != 0;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400146B RID: 5227
		public new const string MRFullTypeName = "Kitware.VTK.vtkPlotStacked";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400146C RID: 5228
		public new static readonly string MRClassNameKey = "class vtkPlotStacked";
	}
}
