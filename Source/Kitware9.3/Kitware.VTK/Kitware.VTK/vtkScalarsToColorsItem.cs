using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkScalarsToColorsItem
	/// </summary>
	/// <remarks>
	///    Abstract class for ScalarsToColors items.
	///
	/// vtkScalarsToColorsItem implements item bounds and painting for inherited
	/// classes that provide a texture (ComputeTexture()) and optionally a shape
	/// </remarks>
	/// <seealso>
	///
	/// vtkControlPointsItem
	/// vtkLookupTableItem
	/// vtkColorTransferFunctionItem
	/// vtkCompositeTransferFunctionItem
	/// vtkPiecewiseItemFunctionItem
	/// </seealso>
	// Token: 0x02000649 RID: 1609
	public abstract class vtkScalarsToColorsItem : vtkPlot
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011719 RID: 71449 RVA: 0x00185348 File Offset: 0x00183548
		static vtkScalarsToColorsItem()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkScalarsToColorsItem.MRClassNameKey, Type.GetType("Kitware.VTK.vtkScalarsToColorsItem"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601171A RID: 71450 RVA: 0x00185370 File Offset: 0x00183570
		public vtkScalarsToColorsItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601171B RID: 71451 RVA: 0x0018537E File Offset: 0x0018357E
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601171C RID: 71452
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarsToColorsItem_GetBounds_01(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Bounds of the item, use the UserBounds if valid otherwise compute
		/// the bounds of the item (based on the transfer function range).
		/// </summary>
		// Token: 0x0601171D RID: 71453 RVA: 0x00185389 File Offset: 0x00183589
		public override void GetBounds(IntPtr bounds)
		{
			vtkScalarsToColorsItem.vtkScalarsToColorsItem_GetBounds_01(base.GetCppThis(), bounds);
		}

		// Token: 0x0601171E RID: 71454
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScalarsToColorsItem_GetHistogramTable_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the vtkTable displayed as an histogram using a vtkPlotBar
		/// </summary>
		// Token: 0x0601171F RID: 71455 RVA: 0x0018539C File Offset: 0x0018359C
		public virtual vtkTable GetHistogramTable()
		{
			vtkTable vtkTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScalarsToColorsItem.vtkScalarsToColorsItem_GetHistogramTable_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06011720 RID: 71456
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkScalarsToColorsItem_GetMaskAboveCurve_03(HandleRef pThis);

		/// <summary>
		/// Don't fill in the part above the transfer function.
		/// If true texture is not visible above the shape provided by subclasses,
		/// otherwise the whole rectangle defined by the bounds is filled with the
		/// transfer function.
		/// Note: only 2D transfer functions (RGB tf + alpha tf ) support the feature.
		/// </summary>
		// Token: 0x06011721 RID: 71457 RVA: 0x0018540C File Offset: 0x0018360C
		public virtual bool GetMaskAboveCurve()
		{
			return vtkScalarsToColorsItem.vtkScalarsToColorsItem_GetMaskAboveCurve_03(base.GetCppThis()) != 0;
		}

		// Token: 0x06011722 RID: 71458
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkScalarsToColorsItem_GetNearestPoint_04(HandleRef pThis, HandleRef point, HandleRef arg1, HandleRef location, IntPtr segmentIndex);

		/// <summary>
		/// Function to query a plot for the nearest point to the specified coordinate.
		/// Returns the index of the data series with which the point is associated or
		/// -1.
		/// If a vtkIdType* is passed, its referent will be set to index of the bar
		/// segment with which a point is associated, or -1.
		/// </summary>
		// Token: 0x06011723 RID: 71459 RVA: 0x00185434 File Offset: 0x00183634
		public override long GetNearestPoint(vtkVector2f point, vtkVector2f arg1, vtkVector2f location, IntPtr segmentIndex)
		{
			return vtkScalarsToColorsItem.vtkScalarsToColorsItem_GetNearestPoint_04(base.GetCppThis(), (point == null) ? default(HandleRef) : point.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis(), (location == null) ? default(HandleRef) : location.GetCppThis(), segmentIndex);
		}

		// Token: 0x06011724 RID: 71460
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkScalarsToColorsItem_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011725 RID: 71461 RVA: 0x00185494 File Offset: 0x00183694
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkScalarsToColorsItem.vtkScalarsToColorsItem_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06011726 RID: 71462
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkScalarsToColorsItem_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011727 RID: 71463 RVA: 0x001854B4 File Offset: 0x001836B4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkScalarsToColorsItem.vtkScalarsToColorsItem_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06011728 RID: 71464
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScalarsToColorsItem_GetPolyLinePen_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get a pointer to the vtkPen object that controls the drawing of the edge
		/// of the shape if any.
		/// PolyLinePen type is vtkPen::NO_PEN by default.
		/// </summary>
		// Token: 0x06011729 RID: 71465 RVA: 0x001854D0 File Offset: 0x001836D0
		public virtual vtkPen GetPolyLinePen()
		{
			vtkPen vtkPen = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScalarsToColorsItem.vtkScalarsToColorsItem_GetPolyLinePen_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601172A RID: 71466
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkScalarsToColorsItem_GetTooltipLabel_08(HandleRef pThis, HandleRef plotPos, long seriesIndex, long segmentIndex);

		/// <summary>
		/// Generate and return the tooltip label string for this plot
		/// The segmentIndex is implemented here.
		/// </summary>
		// Token: 0x0601172B RID: 71467 RVA: 0x00185540 File Offset: 0x00183740
		public override string GetTooltipLabel(vtkVector2d plotPos, long seriesIndex, long segmentIndex)
		{
			return vtkScalarsToColorsItem.vtkScalarsToColorsItem_GetTooltipLabel_08(base.GetCppThis(), (plotPos == null) ? default(HandleRef) : plotPos.GetCppThis(), seriesIndex, segmentIndex);
		}

		// Token: 0x0601172C RID: 71468
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScalarsToColorsItem_GetUserBounds_09(HandleRef pThis);

		/// <summary>
		/// Set custom bounds, except if bounds are invalid, bounds will be
		/// automatically computed based on the range of the control points
		/// Invalid bounds by default.
		/// </summary>
		// Token: 0x0601172D RID: 71469 RVA: 0x00185578 File Offset: 0x00183778
		public virtual double[] GetUserBounds()
		{
			IntPtr intPtr = vtkScalarsToColorsItem.vtkScalarsToColorsItem_GetUserBounds_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601172E RID: 71470
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarsToColorsItem_GetUserBounds_10(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

		/// <summary>
		/// Set custom bounds, except if bounds are invalid, bounds will be
		/// automatically computed based on the range of the control points
		/// Invalid bounds by default.
		/// </summary>
		// Token: 0x0601172F RID: 71471 RVA: 0x001855C0 File Offset: 0x001837C0
		public virtual void GetUserBounds(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
		{
			vtkScalarsToColorsItem.vtkScalarsToColorsItem_GetUserBounds_10(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		// Token: 0x06011730 RID: 71472
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarsToColorsItem_GetUserBounds_11(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set custom bounds, except if bounds are invalid, bounds will be
		/// automatically computed based on the range of the control points
		/// Invalid bounds by default.
		/// </summary>
		// Token: 0x06011731 RID: 71473 RVA: 0x001855D4 File Offset: 0x001837D4
		public virtual void GetUserBounds(IntPtr _arg)
		{
			vtkScalarsToColorsItem.vtkScalarsToColorsItem_GetUserBounds_11(base.GetCppThis(), _arg);
		}

		// Token: 0x06011732 RID: 71474
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarsToColorsItem_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011733 RID: 71475 RVA: 0x001855E4 File Offset: 0x001837E4
		public override int IsA(string type)
		{
			return vtkScalarsToColorsItem.vtkScalarsToColorsItem_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x06011734 RID: 71476
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarsToColorsItem_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011735 RID: 71477 RVA: 0x00185604 File Offset: 0x00183804
		public new static int IsTypeOf(string type)
		{
			return vtkScalarsToColorsItem.vtkScalarsToColorsItem_IsTypeOf_13(type);
		}

		// Token: 0x06011736 RID: 71478
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScalarsToColorsItem_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011737 RID: 71479 RVA: 0x00185620 File Offset: 0x00183820
		public new vtkScalarsToColorsItem NewInstance()
		{
			vtkScalarsToColorsItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScalarsToColorsItem.vtkScalarsToColorsItem_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkScalarsToColorsItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011738 RID: 71480
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkScalarsToColorsItem_Paint_15(HandleRef pThis, HandleRef painter);

		/// <summary>
		/// Paint the texture into a rectangle defined by the bounds. If
		/// MaskAboveCurve is true and a shape has been provided by a subclass, it
		/// draws the texture into the shape
		/// </summary>
		// Token: 0x06011739 RID: 71481 RVA: 0x0018567C File Offset: 0x0018387C
		public override bool Paint(vtkContext2D painter)
		{
			return vtkScalarsToColorsItem.vtkScalarsToColorsItem_Paint_15(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		// Token: 0x0601173A RID: 71482
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScalarsToColorsItem_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601173B RID: 71483 RVA: 0x001856B8 File Offset: 0x001838B8
		public new static vtkScalarsToColorsItem SafeDownCast(vtkObjectBase o)
		{
			vtkScalarsToColorsItem vtkScalarsToColorsItem = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScalarsToColorsItem.vtkScalarsToColorsItem_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScalarsToColorsItem = (vtkScalarsToColorsItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScalarsToColorsItem.Register(null);
				}
			}
			return vtkScalarsToColorsItem;
		}

		// Token: 0x0601173C RID: 71484
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarsToColorsItem_SetHistogramTable_17(HandleRef pThis, HandleRef histogramTable);

		/// <summary>
		/// Set/Get the vtkTable displayed as an histogram using a vtkPlotBar
		/// </summary>
		// Token: 0x0601173D RID: 71485 RVA: 0x00185738 File Offset: 0x00183938
		public void SetHistogramTable(vtkTable histogramTable)
		{
			vtkScalarsToColorsItem.vtkScalarsToColorsItem_SetHistogramTable_17(base.GetCppThis(), (histogramTable == null) ? default(HandleRef) : histogramTable.GetCppThis());
		}

		// Token: 0x0601173E RID: 71486
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarsToColorsItem_SetMaskAboveCurve_18(HandleRef pThis, byte _arg);

		/// <summary>
		/// Don't fill in the part above the transfer function.
		/// If true texture is not visible above the shape provided by subclasses,
		/// otherwise the whole rectangle defined by the bounds is filled with the
		/// transfer function.
		/// Note: only 2D transfer functions (RGB tf + alpha tf ) support the feature.
		/// </summary>
		// Token: 0x0601173F RID: 71487 RVA: 0x00185767 File Offset: 0x00183967
		public virtual void SetMaskAboveCurve(bool _arg)
		{
			vtkScalarsToColorsItem.vtkScalarsToColorsItem_SetMaskAboveCurve_18(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06011740 RID: 71488
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarsToColorsItem_SetUserBounds_19(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

		/// <summary>
		/// Set custom bounds, except if bounds are invalid, bounds will be
		/// automatically computed based on the range of the control points
		/// Invalid bounds by default.
		/// </summary>
		// Token: 0x06011741 RID: 71489 RVA: 0x0018577F File Offset: 0x0018397F
		public virtual void SetUserBounds(double _arg1, double _arg2, double _arg3, double _arg4)
		{
			vtkScalarsToColorsItem.vtkScalarsToColorsItem_SetUserBounds_19(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		// Token: 0x06011742 RID: 71490
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarsToColorsItem_SetUserBounds_20(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set custom bounds, except if bounds are invalid, bounds will be
		/// automatically computed based on the range of the control points
		/// Invalid bounds by default.
		/// </summary>
		// Token: 0x06011743 RID: 71491 RVA: 0x00185793 File Offset: 0x00183993
		public virtual void SetUserBounds(IntPtr _arg)
		{
			vtkScalarsToColorsItem.vtkScalarsToColorsItem_SetUserBounds_20(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400141D RID: 5149
		public new const string MRFullTypeName = "Kitware.VTK.vtkScalarsToColorsItem";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400141E RID: 5150
		public new static readonly string MRClassNameKey = "class vtkScalarsToColorsItem";
	}
}
