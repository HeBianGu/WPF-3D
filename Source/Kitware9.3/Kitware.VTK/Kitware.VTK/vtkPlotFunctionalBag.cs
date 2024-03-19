using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPlotFunctionalBag
	/// </summary>
	/// <remarks>
	///    Class for drawing an XY line plot or bag
	/// given two columns from a vtkTable.
	///
	///
	/// Depending on the number of components, this class will draw either
	/// a line plot (for 1 component column) or, for two components columns,
	/// a filled polygonal band (the bag) going from the first to the second
	/// component on the Y-axis along the X-axis. The filter
	/// vtkExtractFunctionalBagPlot is intended to create such "bag" columns.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkExtractFunctionalBagPlot
	/// </seealso>
	// Token: 0x02000661 RID: 1633
	public class vtkPlotFunctionalBag : vtkPlot
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011A1D RID: 72221 RVA: 0x0018A0FA File Offset: 0x001882FA
		static vtkPlotFunctionalBag()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPlotFunctionalBag.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlotFunctionalBag"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011A1E RID: 72222 RVA: 0x0018A122 File Offset: 0x00188322
		public vtkPlotFunctionalBag(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011A1F RID: 72223
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotFunctionalBag_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates a functional bag plot object.
		/// </summary>
		// Token: 0x06011A20 RID: 72224 RVA: 0x0018A130 File Offset: 0x00188330
		public new static vtkPlotFunctionalBag New()
		{
			vtkPlotFunctionalBag result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotFunctionalBag.vtkPlotFunctionalBag_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlotFunctionalBag)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Creates a functional bag plot object.
		/// </summary>
		// Token: 0x06011A21 RID: 72225 RVA: 0x0018A184 File Offset: 0x00188384
		public vtkPlotFunctionalBag() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPlotFunctionalBag.vtkPlotFunctionalBag_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011A22 RID: 72226 RVA: 0x0018A1C8 File Offset: 0x001883C8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011A23 RID: 72227
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotFunctionalBag_CreateDefaultLookupTable_01(HandleRef pThis);

		/// <summary>
		/// Create default lookup table. Generally used to create one when none
		/// is available with the scalar data.
		/// </summary>
		// Token: 0x06011A24 RID: 72228 RVA: 0x0018A1D3 File Offset: 0x001883D3
		public virtual void CreateDefaultLookupTable()
		{
			vtkPlotFunctionalBag.vtkPlotFunctionalBag_CreateDefaultLookupTable_01(base.GetCppThis());
		}

		// Token: 0x06011A25 RID: 72229
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotFunctionalBag_GetBounds_02(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Get the bounds for this plot as (Xmin, Xmax, Ymin, Ymax).
		/// </summary>
		// Token: 0x06011A26 RID: 72230 RVA: 0x0018A1E2 File Offset: 0x001883E2
		public override void GetBounds(IntPtr bounds)
		{
			vtkPlotFunctionalBag.vtkPlotFunctionalBag_GetBounds_02(base.GetCppThis(), bounds);
		}

		// Token: 0x06011A27 RID: 72231
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotFunctionalBag_GetLookupTable_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify a lookup table for the mapper to use.
		/// </summary>
		// Token: 0x06011A28 RID: 72232 RVA: 0x0018A1F4 File Offset: 0x001883F4
		public vtkScalarsToColors GetLookupTable()
		{
			vtkScalarsToColors vtkScalarsToColors = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotFunctionalBag.vtkPlotFunctionalBag_GetLookupTable_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06011A29 RID: 72233
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlotFunctionalBag_GetNearestPoint_04(HandleRef pThis, HandleRef point, HandleRef tolerance, HandleRef location, IntPtr segmentId);

		/// <summary>
		/// Function to query a plot for the nearest point to the specified coordinate.
		/// Returns the index of the data series with which the point is associated or
		/// -1.
		/// </summary>
		// Token: 0x06011A2A RID: 72234 RVA: 0x0018A264 File Offset: 0x00188464
		public override long GetNearestPoint(vtkVector2f point, vtkVector2f tolerance, vtkVector2f location, IntPtr segmentId)
		{
			return vtkPlotFunctionalBag.vtkPlotFunctionalBag_GetNearestPoint_04(base.GetCppThis(), (point == null) ? default(HandleRef) : point.GetCppThis(), (tolerance == null) ? default(HandleRef) : tolerance.GetCppThis(), (location == null) ? default(HandleRef) : location.GetCppThis(), segmentId);
		}

		// Token: 0x06011A2B RID: 72235
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlotFunctionalBag_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011A2C RID: 72236 RVA: 0x0018A2C4 File Offset: 0x001884C4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPlotFunctionalBag.vtkPlotFunctionalBag_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06011A2D RID: 72237
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlotFunctionalBag_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011A2E RID: 72238 RVA: 0x0018A2E4 File Offset: 0x001884E4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPlotFunctionalBag.vtkPlotFunctionalBag_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06011A2F RID: 72239
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotFunctionalBag_GetUnscaledInputBounds_07(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Get the non-log-scaled bounds on chart inputs for this plot as
		/// (Xmin, Xmax, Ymin, Ymax).
		/// </summary>
		// Token: 0x06011A30 RID: 72240 RVA: 0x0018A2FE File Offset: 0x001884FE
		public override void GetUnscaledInputBounds(IntPtr bounds)
		{
			vtkPlotFunctionalBag.vtkPlotFunctionalBag_GetUnscaledInputBounds_07(base.GetCppThis(), bounds);
		}

		// Token: 0x06011A31 RID: 72241
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlotFunctionalBag_GetVisible_08(HandleRef pThis);

		/// <summary>
		/// Reimplemented to enforce visibility when selected.
		/// </summary>
		// Token: 0x06011A32 RID: 72242 RVA: 0x0018A310 File Offset: 0x00188510
		public override bool GetVisible()
		{
			return vtkPlotFunctionalBag.vtkPlotFunctionalBag_GetVisible_08(base.GetCppThis()) != 0;
		}

		// Token: 0x06011A33 RID: 72243
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlotFunctionalBag_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011A34 RID: 72244 RVA: 0x0018A338 File Offset: 0x00188538
		public override int IsA(string type)
		{
			return vtkPlotFunctionalBag.vtkPlotFunctionalBag_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x06011A35 RID: 72245
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlotFunctionalBag_IsBag_10(HandleRef pThis);

		/// <summary>
		/// Returns true if the plot is a functional bag, false if it is a simple
		/// line.
		/// </summary>
		// Token: 0x06011A36 RID: 72246 RVA: 0x0018A358 File Offset: 0x00188558
		public virtual bool IsBag()
		{
			return vtkPlotFunctionalBag.vtkPlotFunctionalBag_IsBag_10(base.GetCppThis()) != 0;
		}

		// Token: 0x06011A37 RID: 72247
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlotFunctionalBag_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011A38 RID: 72248 RVA: 0x0018A380 File Offset: 0x00188580
		public new static int IsTypeOf(string type)
		{
			return vtkPlotFunctionalBag.vtkPlotFunctionalBag_IsTypeOf_11(type);
		}

		// Token: 0x06011A39 RID: 72249
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotFunctionalBag_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011A3A RID: 72250 RVA: 0x0018A39C File Offset: 0x0018859C
		public new vtkPlotFunctionalBag NewInstance()
		{
			vtkPlotFunctionalBag result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotFunctionalBag.vtkPlotFunctionalBag_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlotFunctionalBag)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011A3B RID: 72251
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlotFunctionalBag_Paint_14(HandleRef pThis, HandleRef painter);

		/// <summary>
		/// Paint event for the plot, called whenever the chart needs to be drawn.
		/// </summary>
		// Token: 0x06011A3C RID: 72252 RVA: 0x0018A3F8 File Offset: 0x001885F8
		public override bool Paint(vtkContext2D painter)
		{
			return vtkPlotFunctionalBag.vtkPlotFunctionalBag_Paint_14(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		// Token: 0x06011A3D RID: 72253
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlotFunctionalBag_PaintLegend_15(HandleRef pThis, HandleRef painter, HandleRef rect, int legendIndex);

		/// <summary>
		/// Paint legend event for the plot, called whenever the legend needs the
		/// plot items symbol/mark/line drawn. A rect is supplied with the lower left
		/// corner of the rect (elements 0 and 1) and with width x height (elements 2
		/// and 3). The plot can choose how to fill the space supplied.
		/// </summary>
		// Token: 0x06011A3E RID: 72254 RVA: 0x0018A434 File Offset: 0x00188634
		public override bool PaintLegend(vtkContext2D painter, vtkRectf rect, int legendIndex)
		{
			return vtkPlotFunctionalBag.vtkPlotFunctionalBag_PaintLegend_15(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis(), (rect == null) ? default(HandleRef) : rect.GetCppThis(), legendIndex) != 0;
		}

		// Token: 0x06011A3F RID: 72255
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotFunctionalBag_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011A40 RID: 72256 RVA: 0x0018A488 File Offset: 0x00188688
		public new static vtkPlotFunctionalBag SafeDownCast(vtkObjectBase o)
		{
			vtkPlotFunctionalBag vtkPlotFunctionalBag = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotFunctionalBag.vtkPlotFunctionalBag_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlotFunctionalBag = (vtkPlotFunctionalBag)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlotFunctionalBag.Register(null);
				}
			}
			return vtkPlotFunctionalBag;
		}

		// Token: 0x06011A41 RID: 72257
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlotFunctionalBag_SelectPoints_17(HandleRef pThis, HandleRef min, HandleRef max);

		/// <summary>
		/// Select all points in the specified rectangle.
		/// </summary>
		// Token: 0x06011A42 RID: 72258 RVA: 0x0018A508 File Offset: 0x00188708
		public override bool SelectPoints(vtkVector2f min, vtkVector2f max)
		{
			return vtkPlotFunctionalBag.vtkPlotFunctionalBag_SelectPoints_17(base.GetCppThis(), (min == null) ? default(HandleRef) : min.GetCppThis(), (max == null) ? default(HandleRef) : max.GetCppThis()) != 0;
		}

		// Token: 0x06011A43 RID: 72259
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotFunctionalBag_SetLookupTable_18(HandleRef pThis, HandleRef lut);

		/// <summary>
		/// Specify a lookup table for the mapper to use.
		/// </summary>
		// Token: 0x06011A44 RID: 72260 RVA: 0x0018A558 File Offset: 0x00188758
		public void SetLookupTable(vtkScalarsToColors lut)
		{
			vtkPlotFunctionalBag.vtkPlotFunctionalBag_SetLookupTable_18(base.GetCppThis(), (lut == null) ? default(HandleRef) : lut.GetCppThis());
		}

		// Token: 0x06011A45 RID: 72261
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlotFunctionalBag_UpdateCache_19(HandleRef pThis);

		/// <summary>
		/// Update the internal cache. Returns true if cache was successfully updated. Default does
		/// nothing.
		/// This method is called by Update() when either the plot's data has changed or
		/// CacheRequiresUpdate() returns true. It is not necessary to call this method explicitly.
		/// </summary>
		// Token: 0x06011A46 RID: 72262 RVA: 0x0018A588 File Offset: 0x00188788
		public override bool UpdateCache()
		{
			return vtkPlotFunctionalBag.vtkPlotFunctionalBag_UpdateCache_19(base.GetCppThis()) != 0;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400145B RID: 5211
		public new const string MRFullTypeName = "Kitware.VTK.vtkPlotFunctionalBag";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400145C RID: 5212
		public new static readonly string MRClassNameKey = "class vtkPlotFunctionalBag";
	}
}
