using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPlotBox
	/// </summary>
	/// <remarks>
	///    Class for drawing box plots.
	///
	///
	/// Plots to draw box plots given columns from a vtkTable that may contain
	/// 5 lines with quartiles and median.
	/// </remarks>
	// Token: 0x02000660 RID: 1632
	public class vtkPlotBox : vtkPlot
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060119EF RID: 72175 RVA: 0x00189B7F File Offset: 0x00187D7F
		static vtkPlotBox()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPlotBox.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlotBox"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060119F0 RID: 72176 RVA: 0x00189BA7 File Offset: 0x00187DA7
		public vtkPlotBox(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060119F1 RID: 72177
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotBox_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates a box plot.
		/// </summary>
		// Token: 0x060119F2 RID: 72178 RVA: 0x00189BB8 File Offset: 0x00187DB8
		public new static vtkPlotBox New()
		{
			vtkPlotBox result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotBox.vtkPlotBox_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlotBox)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Creates a box plot.
		/// </summary>
		// Token: 0x060119F3 RID: 72179 RVA: 0x00189C0C File Offset: 0x00187E0C
		public vtkPlotBox() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPlotBox.vtkPlotBox_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060119F4 RID: 72180 RVA: 0x00189C50 File Offset: 0x00187E50
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060119F5 RID: 72181
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotBox_CreateDefaultLookupTable_01(HandleRef pThis);

		/// <summary>
		/// Create default lookup table. Generally used to create one when none
		/// is available with the scalar data.
		/// </summary>
		// Token: 0x060119F6 RID: 72182 RVA: 0x00189C5B File Offset: 0x00187E5B
		public virtual void CreateDefaultLookupTable()
		{
			vtkPlotBox.vtkPlotBox_CreateDefaultLookupTable_01(base.GetCppThis());
		}

		// Token: 0x060119F7 RID: 72183
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkPlotBox_GetBoxWidth_02(HandleRef pThis);

		/// <summary>
		/// Get/Set the width of boxes.
		/// </summary>
		// Token: 0x060119F8 RID: 72184 RVA: 0x00189C6C File Offset: 0x00187E6C
		public virtual float GetBoxWidth()
		{
			return vtkPlotBox.vtkPlotBox_GetBoxWidth_02(base.GetCppThis());
		}

		// Token: 0x060119F9 RID: 72185
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotBox_GetLabels_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the plot labels. If this array has a length greater than 1 the index
		/// refers to the stacked objects in the plot.
		/// </summary>
		// Token: 0x060119FA RID: 72186 RVA: 0x00189C8C File Offset: 0x00187E8C
		public override vtkStringArray GetLabels()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotBox.vtkPlotBox_GetLabels_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060119FB RID: 72187
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotBox_GetLookupTable_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify a lookup table for the mapper to use.
		/// </summary>
		// Token: 0x060119FC RID: 72188 RVA: 0x00189CFC File Offset: 0x00187EFC
		public vtkScalarsToColors GetLookupTable()
		{
			vtkScalarsToColors vtkScalarsToColors = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotBox.vtkPlotBox_GetLookupTable_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060119FD RID: 72189
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlotBox_GetNearestPoint_05(HandleRef pThis, HandleRef point, HandleRef tolerance, HandleRef location, IntPtr segmentId);

		/// <summary>
		/// Function to query a plot for the nearest point to the specified coordinate.
		/// Returns the index of the data series with which the point is associated
		/// or -1.
		/// </summary>
		// Token: 0x060119FE RID: 72190 RVA: 0x00189D6C File Offset: 0x00187F6C
		public override long GetNearestPoint(vtkVector2f point, vtkVector2f tolerance, vtkVector2f location, IntPtr segmentId)
		{
			return vtkPlotBox.vtkPlotBox_GetNearestPoint_05(base.GetCppThis(), (point == null) ? default(HandleRef) : point.GetCppThis(), (tolerance == null) ? default(HandleRef) : tolerance.GetCppThis(), (location == null) ? default(HandleRef) : location.GetCppThis(), segmentId);
		}

		// Token: 0x060119FF RID: 72191
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlotBox_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011A00 RID: 72192 RVA: 0x00189DCC File Offset: 0x00187FCC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPlotBox.vtkPlotBox_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x06011A01 RID: 72193
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlotBox_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011A02 RID: 72194 RVA: 0x00189DEC File Offset: 0x00187FEC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPlotBox.vtkPlotBox_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x06011A03 RID: 72195
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotBox_GetTitleProperties_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the vtkTextProperty that governs how the plot title is displayed.
		/// </summary>
		// Token: 0x06011A04 RID: 72196 RVA: 0x00189E08 File Offset: 0x00188008
		public virtual vtkTextProperty GetTitleProperties()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotBox.vtkPlotBox_GetTitleProperties_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06011A05 RID: 72197
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlotBox_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011A06 RID: 72198 RVA: 0x00189E78 File Offset: 0x00188078
		public override int IsA(string type)
		{
			return vtkPlotBox.vtkPlotBox_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x06011A07 RID: 72199
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlotBox_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011A08 RID: 72200 RVA: 0x00189E98 File Offset: 0x00188098
		public new static int IsTypeOf(string type)
		{
			return vtkPlotBox.vtkPlotBox_IsTypeOf_10(type);
		}

		// Token: 0x06011A09 RID: 72201
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotBox_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011A0A RID: 72202 RVA: 0x00189EB4 File Offset: 0x001880B4
		public new vtkPlotBox NewInstance()
		{
			vtkPlotBox result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotBox.vtkPlotBox_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlotBox)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011A0B RID: 72203
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlotBox_Paint_13(HandleRef pThis, HandleRef painter);

		/// <summary>
		/// Paint event for the plot, called whenever the chart needs to be drawn
		/// </summary>
		// Token: 0x06011A0C RID: 72204 RVA: 0x00189F10 File Offset: 0x00188110
		public override bool Paint(vtkContext2D painter)
		{
			return vtkPlotBox.vtkPlotBox_Paint_13(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		// Token: 0x06011A0D RID: 72205
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlotBox_PaintLegend_14(HandleRef pThis, HandleRef painter, HandleRef rect, int legendIndex);

		/// <summary>
		/// Paint legend event for the plot, called whenever the legend needs the
		/// plot items symbol/mark/line drawn. A rect is supplied with the lower left
		/// corner of the rect (elements 0 and 1) and with width x height (elements 2
		/// and 3). The plot can choose how to fill the space supplied.
		/// </summary>
		// Token: 0x06011A0E RID: 72206 RVA: 0x00189F4C File Offset: 0x0018814C
		public override bool PaintLegend(vtkContext2D painter, vtkRectf rect, int legendIndex)
		{
			return vtkPlotBox.vtkPlotBox_PaintLegend_14(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis(), (rect == null) ? default(HandleRef) : rect.GetCppThis(), legendIndex) != 0;
		}

		// Token: 0x06011A0F RID: 72207
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotBox_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011A10 RID: 72208 RVA: 0x00189FA0 File Offset: 0x001881A0
		public new static vtkPlotBox SafeDownCast(vtkObjectBase o)
		{
			vtkPlotBox vtkPlotBox = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotBox.vtkPlotBox_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlotBox = (vtkPlotBox)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlotBox.Register(null);
				}
			}
			return vtkPlotBox;
		}

		// Token: 0x06011A11 RID: 72209
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotBox_SetBoxWidth_16(HandleRef pThis, float _arg);

		/// <summary>
		/// Get/Set the width of boxes.
		/// </summary>
		// Token: 0x06011A12 RID: 72210 RVA: 0x0018A01F File Offset: 0x0018821F
		public virtual void SetBoxWidth(float _arg)
		{
			vtkPlotBox.vtkPlotBox_SetBoxWidth_16(base.GetCppThis(), _arg);
		}

		// Token: 0x06011A13 RID: 72211
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotBox_SetColumnColor_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string colName, IntPtr rgb);

		/// <summary>
		/// Helper function to set the color of a given column.
		/// </summary>
		// Token: 0x06011A14 RID: 72212 RVA: 0x0018A02F File Offset: 0x0018822F
		public void SetColumnColor(string colName, IntPtr rgb)
		{
			vtkPlotBox.vtkPlotBox_SetColumnColor_17(base.GetCppThis(), colName, rgb);
		}

		// Token: 0x06011A15 RID: 72213
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotBox_SetInputData_18(HandleRef pThis, HandleRef table);

		/// <summary>
		/// This is a convenience function to set the input table.
		/// </summary>
		// Token: 0x06011A16 RID: 72214 RVA: 0x0018A040 File Offset: 0x00188240
		public override void SetInputData(vtkTable table)
		{
			vtkPlotBox.vtkPlotBox_SetInputData_18(base.GetCppThis(), (table == null) ? default(HandleRef) : table.GetCppThis());
		}

		// Token: 0x06011A17 RID: 72215
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotBox_SetInputData_19(HandleRef pThis, HandleRef table, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg1, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg2);

		/// <summary>
		/// This is a convenience function to set the input table.
		/// </summary>
		// Token: 0x06011A18 RID: 72216 RVA: 0x0018A070 File Offset: 0x00188270
		public override void SetInputData(vtkTable table, string arg1, string arg2)
		{
			vtkPlotBox.vtkPlotBox_SetInputData_19(base.GetCppThis(), (table == null) ? default(HandleRef) : table.GetCppThis(), arg1, arg2);
		}

		// Token: 0x06011A19 RID: 72217
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotBox_SetLookupTable_20(HandleRef pThis, HandleRef lut);

		/// <summary>
		/// Specify a lookup table for the mapper to use.
		/// </summary>
		// Token: 0x06011A1A RID: 72218 RVA: 0x0018A0A4 File Offset: 0x001882A4
		public void SetLookupTable(vtkScalarsToColors lut)
		{
			vtkPlotBox.vtkPlotBox_SetLookupTable_20(base.GetCppThis(), (lut == null) ? default(HandleRef) : lut.GetCppThis());
		}

		// Token: 0x06011A1B RID: 72219
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlotBox_UpdateCache_21(HandleRef pThis);

		/// <summary>
		/// Update the internal cache. Returns true if cache was successfully updated. Default does
		/// nothing.
		/// This method is called by Update() when either the plot's data has changed or
		/// CacheRequiresUpdate() returns true. It is not necessary to call this method explicitly.
		/// </summary>
		// Token: 0x06011A1C RID: 72220 RVA: 0x0018A0D4 File Offset: 0x001882D4
		public override bool UpdateCache()
		{
			return vtkPlotBox.vtkPlotBox_UpdateCache_21(base.GetCppThis()) != 0;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001459 RID: 5209
		public new const string MRFullTypeName = "Kitware.VTK.vtkPlotBox";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400145A RID: 5210
		public new static readonly string MRClassNameKey = "class vtkPlotBox";
	}
}
