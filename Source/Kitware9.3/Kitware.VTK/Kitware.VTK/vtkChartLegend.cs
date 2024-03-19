using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkChartLegend
	/// </summary>
	/// <remarks>
	///    draw the chart legend
	///
	///
	/// The vtkChartLegend is drawn in screen coordinates. It is usually one of the
	/// last elements of a chart to be drawn. It renders the mark/line for each
	/// plot, and the plot labels.
	/// </remarks>
	// Token: 0x02000631 RID: 1585
	public class vtkChartLegend : vtkContextItem
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601128A RID: 70282 RVA: 0x0017E748 File Offset: 0x0017C948
		static vtkChartLegend()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkChartLegend.MRClassNameKey, Type.GetType("Kitware.VTK.vtkChartLegend"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601128B RID: 70283 RVA: 0x0017E770 File Offset: 0x0017C970
		public vtkChartLegend(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601128C RID: 70284
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartLegend_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates a 2D Chart object.
		/// </summary>
		// Token: 0x0601128D RID: 70285 RVA: 0x0017E780 File Offset: 0x0017C980
		public new static vtkChartLegend New()
		{
			vtkChartLegend result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartLegend.vtkChartLegend_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkChartLegend)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Creates a 2D Chart object.
		/// </summary>
		// Token: 0x0601128E RID: 70286 RVA: 0x0017E7D4 File Offset: 0x0017C9D4
		public vtkChartLegend() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkChartLegend.vtkChartLegend_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601128F RID: 70287 RVA: 0x0017E818 File Offset: 0x0017CA18
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011290 RID: 70288
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartLegend_CacheBoundsOff_01(HandleRef pThis);

		/// <summary>
		/// Toggle whether or not this legend should attempt to cache its position
		/// and size.  The default value is true.  If this value is set to false,
		/// the legend will recalculate its position and bounds every time it is
		/// drawn.  If users will be able to zoom in or out on your legend, you
		/// may want to set this to false.  Otherwise, the border around the legend
		/// may not resize appropriately.
		/// </summary>
		// Token: 0x06011291 RID: 70289 RVA: 0x0017E823 File Offset: 0x0017CA23
		public virtual void CacheBoundsOff()
		{
			vtkChartLegend.vtkChartLegend_CacheBoundsOff_01(base.GetCppThis());
		}

		// Token: 0x06011292 RID: 70290
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartLegend_CacheBoundsOn_02(HandleRef pThis);

		/// <summary>
		/// Toggle whether or not this legend should attempt to cache its position
		/// and size.  The default value is true.  If this value is set to false,
		/// the legend will recalculate its position and bounds every time it is
		/// drawn.  If users will be able to zoom in or out on your legend, you
		/// may want to set this to false.  Otherwise, the border around the legend
		/// may not resize appropriately.
		/// </summary>
		// Token: 0x06011293 RID: 70291 RVA: 0x0017E832 File Offset: 0x0017CA32
		public virtual void CacheBoundsOn()
		{
			vtkChartLegend.vtkChartLegend_CacheBoundsOn_02(base.GetCppThis());
		}

		// Token: 0x06011294 RID: 70292
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartLegend_GetBoundingRect_03(HandleRef pThis, HandleRef painter, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Request the space the legend requires to be drawn. This is returned as a
		/// vtkRect4f, with the corner being the offset from Point, and the width/
		/// height being the total width/height required by the axis. In order to
		/// ensure the numbers are correct, Update() should be called first.
		/// </summary>
		// Token: 0x06011295 RID: 70293 RVA: 0x0017E844 File Offset: 0x0017CA44
		public virtual vtkRectf GetBoundingRect(vtkContext2D painter)
		{
			vtkRectf result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartLegend.vtkChartLegend_GetBoundingRect_03(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRectf)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011296 RID: 70294
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartLegend_GetBrush_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the brush used to draw the legend background.
		/// </summary>
		// Token: 0x06011297 RID: 70295 RVA: 0x0017E8B4 File Offset: 0x0017CAB4
		public vtkBrush GetBrush()
		{
			vtkBrush vtkBrush = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartLegend.vtkChartLegend_GetBrush_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06011298 RID: 70296
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkChartLegend_GetCacheBounds_05(HandleRef pThis);

		/// <summary>
		/// Toggle whether or not this legend should attempt to cache its position
		/// and size.  The default value is true.  If this value is set to false,
		/// the legend will recalculate its position and bounds every time it is
		/// drawn.  If users will be able to zoom in or out on your legend, you
		/// may want to set this to false.  Otherwise, the border around the legend
		/// may not resize appropriately.
		/// </summary>
		// Token: 0x06011299 RID: 70297 RVA: 0x0017E924 File Offset: 0x0017CB24
		public virtual bool GetCacheBounds()
		{
			return vtkChartLegend.vtkChartLegend_GetCacheBounds_05(base.GetCppThis()) != 0;
		}

		// Token: 0x0601129A RID: 70298
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartLegend_GetChart_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the chart that the legend belongs to and will draw the legend for.
		/// </summary>
		// Token: 0x0601129B RID: 70299 RVA: 0x0017E94C File Offset: 0x0017CB4C
		public vtkChart GetChart()
		{
			vtkChart vtkChart = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartLegend.vtkChartLegend_GetChart_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601129C RID: 70300
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkChartLegend_GetDragEnabled_07(HandleRef pThis);

		/// <summary>
		/// Get/set if the legend can be dragged with the mouse button, or not.
		/// True results in left click and drag causing the legend to move around the
		/// scene. False disables response to mouse events.
		/// The default is true.
		/// </summary>
		// Token: 0x0601129D RID: 70301 RVA: 0x0017E9BC File Offset: 0x0017CBBC
		public virtual bool GetDragEnabled()
		{
			return vtkChartLegend.vtkChartLegend_GetDragEnabled_07(base.GetCppThis()) != 0;
		}

		// Token: 0x0601129E RID: 70302
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkChartLegend_GetHorizontalAlignment_08(HandleRef pThis);

		/// <summary>
		/// Get the horizontal alignment of the legend to the point specified.
		/// </summary>
		// Token: 0x0601129F RID: 70303 RVA: 0x0017E9E4 File Offset: 0x0017CBE4
		public virtual int GetHorizontalAlignment()
		{
			return vtkChartLegend.vtkChartLegend_GetHorizontalAlignment_08(base.GetCppThis());
		}

		// Token: 0x060112A0 RID: 70304
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkChartLegend_GetInline_09(HandleRef pThis);

		/// <summary>
		/// Get/set if the legend should be drawn inline (inside the chart), or not.
		/// True would generally request that the chart draws it inside the chart,
		/// false would adjust the chart axes and make space to draw the axes outside.
		/// </summary>
		// Token: 0x060112A1 RID: 70305 RVA: 0x0017EA04 File Offset: 0x0017CC04
		public virtual bool GetInline()
		{
			return vtkChartLegend.vtkChartLegend_GetInline_09(base.GetCppThis()) != 0;
		}

		// Token: 0x060112A2 RID: 70306
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartLegend_GetLabelProperties_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the vtkTextProperty for the legend's labels.
		/// </summary>
		// Token: 0x060112A3 RID: 70307 RVA: 0x0017EA2C File Offset: 0x0017CC2C
		public vtkTextProperty GetLabelProperties()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartLegend.vtkChartLegend_GetLabelProperties_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060112A4 RID: 70308
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkChartLegend_GetLabelSize_11(HandleRef pThis);

		/// <summary>
		/// Get the point size of the label text.
		/// </summary>
		// Token: 0x060112A5 RID: 70309 RVA: 0x0017EA9C File Offset: 0x0017CC9C
		public virtual int GetLabelSize()
		{
			return vtkChartLegend.vtkChartLegend_GetLabelSize_11(base.GetCppThis());
		}

		// Token: 0x060112A6 RID: 70310
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkChartLegend_GetNumberOfGenerationsFromBase_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060112A7 RID: 70311 RVA: 0x0017EABC File Offset: 0x0017CCBC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkChartLegend.vtkChartLegend_GetNumberOfGenerationsFromBase_12(base.GetCppThis(), type);
		}

		// Token: 0x060112A8 RID: 70312
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkChartLegend_GetNumberOfGenerationsFromBaseType_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060112A9 RID: 70313 RVA: 0x0017EADC File Offset: 0x0017CCDC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkChartLegend.vtkChartLegend_GetNumberOfGenerationsFromBaseType_13(type);
		}

		// Token: 0x060112AA RID: 70314
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkChartLegend_GetPadding_14(HandleRef pThis);

		/// <summary>
		/// Get the padding between legend marks.
		/// </summary>
		// Token: 0x060112AB RID: 70315 RVA: 0x0017EAF8 File Offset: 0x0017CCF8
		public virtual int GetPadding()
		{
			return vtkChartLegend.vtkChartLegend_GetPadding_14(base.GetCppThis());
		}

		// Token: 0x060112AC RID: 70316
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartLegend_GetPen_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the pen used to draw the legend outline.
		/// </summary>
		// Token: 0x060112AD RID: 70317 RVA: 0x0017EB18 File Offset: 0x0017CD18
		public vtkPen GetPen()
		{
			vtkPen vtkPen = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartLegend.vtkChartLegend_GetPen_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060112AE RID: 70318
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartLegend_GetPoint_16(HandleRef pThis);

		/// <summary>
		/// Get point the legend box is anchored to.
		/// </summary>
		// Token: 0x060112AF RID: 70319 RVA: 0x0017EB88 File Offset: 0x0017CD88
		public virtual float[] GetPoint()
		{
			IntPtr intPtr = vtkChartLegend.vtkChartLegend_GetPoint_16(base.GetCppThis());
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060112B0 RID: 70320
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartLegend_GetPoint_17(HandleRef pThis, ref float _arg1, ref float _arg2);

		/// <summary>
		/// Get point the legend box is anchored to.
		/// </summary>
		// Token: 0x060112B1 RID: 70321 RVA: 0x0017EBD0 File Offset: 0x0017CDD0
		public virtual void GetPoint(ref float _arg1, ref float _arg2)
		{
			vtkChartLegend.vtkChartLegend_GetPoint_17(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x060112B2 RID: 70322
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartLegend_GetPoint_18(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get point the legend box is anchored to.
		/// </summary>
		// Token: 0x060112B3 RID: 70323 RVA: 0x0017EBE1 File Offset: 0x0017CDE1
		public virtual void GetPoint(IntPtr _arg)
		{
			vtkChartLegend.vtkChartLegend_GetPoint_18(base.GetCppThis(), _arg);
		}

		// Token: 0x060112B4 RID: 70324
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartLegend_GetPointVector_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get point the legend box is anchored to.
		/// </summary>
		// Token: 0x060112B5 RID: 70325 RVA: 0x0017EBF4 File Offset: 0x0017CDF4
		public vtkVector2f GetPointVector()
		{
			vtkVector2f result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartLegend.vtkChartLegend_GetPointVector_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVector2f)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060112B6 RID: 70326
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkChartLegend_GetSymbolWidth_20(HandleRef pThis);

		/// <summary>
		/// Get the legend symbol width.
		/// </summary>
		// Token: 0x060112B7 RID: 70327 RVA: 0x0017EC50 File Offset: 0x0017CE50
		public virtual int GetSymbolWidth()
		{
			return vtkChartLegend.vtkChartLegend_GetSymbolWidth_20(base.GetCppThis());
		}

		// Token: 0x060112B8 RID: 70328
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkChartLegend_GetVerticalAlignment_21(HandleRef pThis);

		/// <summary>
		/// Get the vertical alignment of the legend to the point specified.
		/// </summary>
		// Token: 0x060112B9 RID: 70329 RVA: 0x0017EC70 File Offset: 0x0017CE70
		public virtual int GetVerticalAlignment()
		{
			return vtkChartLegend.vtkChartLegend_GetVerticalAlignment_21(base.GetCppThis());
		}

		// Token: 0x060112BA RID: 70330
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkChartLegend_IsA_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060112BB RID: 70331 RVA: 0x0017EC90 File Offset: 0x0017CE90
		public override int IsA(string type)
		{
			return vtkChartLegend.vtkChartLegend_IsA_22(base.GetCppThis(), type);
		}

		// Token: 0x060112BC RID: 70332
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkChartLegend_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060112BD RID: 70333 RVA: 0x0017ECB0 File Offset: 0x0017CEB0
		public new static int IsTypeOf(string type)
		{
			return vtkChartLegend.vtkChartLegend_IsTypeOf_23(type);
		}

		// Token: 0x060112BE RID: 70334
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartLegend_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060112BF RID: 70335 RVA: 0x0017ECCC File Offset: 0x0017CECC
		public new vtkChartLegend NewInstance()
		{
			vtkChartLegend result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartLegend.vtkChartLegend_NewInstance_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkChartLegend)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060112C0 RID: 70336
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkChartLegend_Paint_26(HandleRef pThis, HandleRef painter);

		/// <summary>
		/// Paint event for the axis, called whenever the axis needs to be drawn.
		/// </summary>
		// Token: 0x060112C1 RID: 70337 RVA: 0x0017ED28 File Offset: 0x0017CF28
		public override bool Paint(vtkContext2D painter)
		{
			return vtkChartLegend.vtkChartLegend_Paint_26(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		// Token: 0x060112C2 RID: 70338
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartLegend_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060112C3 RID: 70339 RVA: 0x0017ED64 File Offset: 0x0017CF64
		public new static vtkChartLegend SafeDownCast(vtkObjectBase o)
		{
			vtkChartLegend vtkChartLegend = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartLegend.vtkChartLegend_SafeDownCast_27((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060112C4 RID: 70340
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartLegend_SetCacheBounds_28(HandleRef pThis, byte _arg);

		/// <summary>
		/// Toggle whether or not this legend should attempt to cache its position
		/// and size.  The default value is true.  If this value is set to false,
		/// the legend will recalculate its position and bounds every time it is
		/// drawn.  If users will be able to zoom in or out on your legend, you
		/// may want to set this to false.  Otherwise, the border around the legend
		/// may not resize appropriately.
		/// </summary>
		// Token: 0x060112C5 RID: 70341 RVA: 0x0017EDE3 File Offset: 0x0017CFE3
		public virtual void SetCacheBounds(bool _arg)
		{
			vtkChartLegend.vtkChartLegend_SetCacheBounds_28(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060112C6 RID: 70342
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartLegend_SetChart_29(HandleRef pThis, HandleRef chart);

		/// <summary>
		/// Set the chart that the legend belongs to and will draw the legend for.
		/// </summary>
		// Token: 0x060112C7 RID: 70343 RVA: 0x0017EDFC File Offset: 0x0017CFFC
		public void SetChart(vtkChart chart)
		{
			vtkChartLegend.vtkChartLegend_SetChart_29(base.GetCppThis(), (chart == null) ? default(HandleRef) : chart.GetCppThis());
		}

		// Token: 0x060112C8 RID: 70344
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartLegend_SetDragEnabled_30(HandleRef pThis, byte _arg);

		/// <summary>
		/// Get/set if the legend can be dragged with the mouse button, or not.
		/// True results in left click and drag causing the legend to move around the
		/// scene. False disables response to mouse events.
		/// The default is true.
		/// </summary>
		// Token: 0x060112C9 RID: 70345 RVA: 0x0017EE2B File Offset: 0x0017D02B
		public virtual void SetDragEnabled(bool _arg)
		{
			vtkChartLegend.vtkChartLegend_SetDragEnabled_30(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060112CA RID: 70346
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartLegend_SetHorizontalAlignment_31(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the horizontal alignment of the legend to the point specified.
		/// Valid values are LEFT, CENTER and RIGHT.
		/// </summary>
		// Token: 0x060112CB RID: 70347 RVA: 0x0017EE43 File Offset: 0x0017D043
		public virtual void SetHorizontalAlignment(int _arg)
		{
			vtkChartLegend.vtkChartLegend_SetHorizontalAlignment_31(base.GetCppThis(), _arg);
		}

		// Token: 0x060112CC RID: 70348
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartLegend_SetInline_32(HandleRef pThis, byte _arg);

		/// <summary>
		/// Get/set if the legend should be drawn inline (inside the chart), or not.
		/// True would generally request that the chart draws it inside the chart,
		/// false would adjust the chart axes and make space to draw the axes outside.
		/// </summary>
		// Token: 0x060112CD RID: 70349 RVA: 0x0017EE53 File Offset: 0x0017D053
		public virtual void SetInline(bool _arg)
		{
			vtkChartLegend.vtkChartLegend_SetInline_32(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060112CE RID: 70350
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartLegend_SetLabelSize_33(HandleRef pThis, int size);

		/// <summary>
		/// Set the point size of the label text.
		/// </summary>
		// Token: 0x060112CF RID: 70351 RVA: 0x0017EE6B File Offset: 0x0017D06B
		public virtual void SetLabelSize(int size)
		{
			vtkChartLegend.vtkChartLegend_SetLabelSize_33(base.GetCppThis(), size);
		}

		// Token: 0x060112D0 RID: 70352
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartLegend_SetPadding_34(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the padding between legend marks, default is 5.
		/// </summary>
		// Token: 0x060112D1 RID: 70353 RVA: 0x0017EE7B File Offset: 0x0017D07B
		public virtual void SetPadding(int _arg)
		{
			vtkChartLegend.vtkChartLegend_SetPadding_34(base.GetCppThis(), _arg);
		}

		// Token: 0x060112D2 RID: 70354
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartLegend_SetPoint_35(HandleRef pThis, float _arg1, float _arg2);

		/// <summary>
		/// Set point the legend box is anchored to.
		/// </summary>
		// Token: 0x060112D3 RID: 70355 RVA: 0x0017EE8B File Offset: 0x0017D08B
		public virtual void SetPoint(float _arg1, float _arg2)
		{
			vtkChartLegend.vtkChartLegend_SetPoint_35(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x060112D4 RID: 70356
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartLegend_SetPoint_36(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set point the legend box is anchored to.
		/// </summary>
		// Token: 0x060112D5 RID: 70357 RVA: 0x0017EE9C File Offset: 0x0017D09C
		public void SetPoint(IntPtr _arg)
		{
			vtkChartLegend.vtkChartLegend_SetPoint_36(base.GetCppThis(), _arg);
		}

		// Token: 0x060112D6 RID: 70358
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartLegend_SetPoint_37(HandleRef pThis, HandleRef point);

		/// <summary>
		/// Set point the legend box is anchored to.
		/// </summary>
		// Token: 0x060112D7 RID: 70359 RVA: 0x0017EEAC File Offset: 0x0017D0AC
		public void SetPoint(vtkVector2f point)
		{
			vtkChartLegend.vtkChartLegend_SetPoint_37(base.GetCppThis(), (point == null) ? default(HandleRef) : point.GetCppThis());
		}

		// Token: 0x060112D8 RID: 70360
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartLegend_SetSymbolWidth_38(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the symbol width, default is 15.
		/// </summary>
		// Token: 0x060112D9 RID: 70361 RVA: 0x0017EEDB File Offset: 0x0017D0DB
		public virtual void SetSymbolWidth(int _arg)
		{
			vtkChartLegend.vtkChartLegend_SetSymbolWidth_38(base.GetCppThis(), _arg);
		}

		// Token: 0x060112DA RID: 70362
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartLegend_SetVerticalAlignment_39(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the vertical alignment of the legend to the point specified.
		/// Valid values are TOP, CENTER and BOTTOM.
		/// </summary>
		// Token: 0x060112DB RID: 70363 RVA: 0x0017EEEB File Offset: 0x0017D0EB
		public virtual void SetVerticalAlignment(int _arg)
		{
			vtkChartLegend.vtkChartLegend_SetVerticalAlignment_39(base.GetCppThis(), _arg);
		}

		// Token: 0x060112DC RID: 70364
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartLegend_Update_40(HandleRef pThis);

		/// <summary>
		/// Update the geometry of the axis. Takes care of setting up the tick mark
		/// locations etc. Should be called by the scene before rendering.
		/// </summary>
		// Token: 0x060112DD RID: 70365 RVA: 0x0017EEFB File Offset: 0x0017D0FB
		public override void Update()
		{
			vtkChartLegend.vtkChartLegend_Update_40(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040013D2 RID: 5074
		public new const string MRFullTypeName = "Kitware.VTK.vtkChartLegend";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040013D3 RID: 5075
		public new static readonly string MRClassNameKey = "class vtkChartLegend";

		/// <summary>
		/// Get point the legend box is anchored to.
		/// </summary>
		// Token: 0x02000632 RID: 1586
		public enum BOTTOM_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x040013D5 RID: 5077
			BOTTOM = 4,
			/// <summary>enum member</summary>
			// Token: 0x040013D6 RID: 5078
			CENTER = 1,
			/// <summary>enum member</summary>
			// Token: 0x040013D7 RID: 5079
			CUSTOM = 5,
			/// <summary>enum member</summary>
			// Token: 0x040013D8 RID: 5080
			LEFT = 0,
			/// <summary>enum member</summary>
			// Token: 0x040013D9 RID: 5081
			RIGHT = 2,
			/// <summary>enum member</summary>
			// Token: 0x040013DA RID: 5082
			TOP
		}
	}
}
