using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPlotParallelCoordinates
	/// </summary>
	/// <remarks>
	///    Class for drawing a parallel coordinate
	/// plot given columns from a vtkTable.
	///
	///
	///
	/// </remarks>
	// Token: 0x02000667 RID: 1639
	public class vtkPlotParallelCoordinates : vtkPlot
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011AD7 RID: 72407 RVA: 0x0018B613 File Offset: 0x00189813
		static vtkPlotParallelCoordinates()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPlotParallelCoordinates.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlotParallelCoordinates"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011AD8 RID: 72408 RVA: 0x0018B63B File Offset: 0x0018983B
		public vtkPlotParallelCoordinates(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011AD9 RID: 72409
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotParallelCoordinates_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates a parallel coordinates chart
		/// </summary>
		// Token: 0x06011ADA RID: 72410 RVA: 0x0018B64C File Offset: 0x0018984C
		public new static vtkPlotParallelCoordinates New()
		{
			vtkPlotParallelCoordinates result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotParallelCoordinates.vtkPlotParallelCoordinates_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlotParallelCoordinates)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Creates a parallel coordinates chart
		/// </summary>
		// Token: 0x06011ADB RID: 72411 RVA: 0x0018B6A0 File Offset: 0x001898A0
		public vtkPlotParallelCoordinates() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPlotParallelCoordinates.vtkPlotParallelCoordinates_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011ADC RID: 72412 RVA: 0x0018B6E4 File Offset: 0x001898E4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011ADD RID: 72413
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotParallelCoordinates_CreateDefaultLookupTable_01(HandleRef pThis);

		/// <summary>
		/// Create default lookup table. Generally used to create one when none
		/// is available with the scalar data.
		/// </summary>
		// Token: 0x06011ADE RID: 72414 RVA: 0x0018B6EF File Offset: 0x001898EF
		public virtual void CreateDefaultLookupTable()
		{
			vtkPlotParallelCoordinates.vtkPlotParallelCoordinates_CreateDefaultLookupTable_01(base.GetCppThis());
		}

		// Token: 0x06011ADF RID: 72415
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotParallelCoordinates_GetBounds_02(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Get the bounds for this mapper as (Xmin,Xmax,Ymin,Ymax,Zmin,Zmax).
		/// </summary>
		// Token: 0x06011AE0 RID: 72416 RVA: 0x0018B6FE File Offset: 0x001898FE
		public override void GetBounds(IntPtr bounds)
		{
			vtkPlotParallelCoordinates.vtkPlotParallelCoordinates_GetBounds_02(base.GetCppThis(), bounds);
		}

		// Token: 0x06011AE1 RID: 72417
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkPlotParallelCoordinates_GetColorArrayName_03(HandleRef pThis);

		/// <summary>
		/// Get the array name to color by.
		/// </summary>
		// Token: 0x06011AE2 RID: 72418 RVA: 0x0018B710 File Offset: 0x00189910
		public string GetColorArrayName()
		{
			return vtkPlotParallelCoordinates.vtkPlotParallelCoordinates_GetColorArrayName_03(base.GetCppThis());
		}

		// Token: 0x06011AE3 RID: 72419
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlotParallelCoordinates_GetColorMode_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the color mode for the plot.
		///
		/// The options are:
		/// VTK_COLOR_MODE_DEFAULT
		/// VTK_COLOR_MODE_MAP_SCALARS
		/// VTK_COLOR_MODE_DIRECT_SCALARS
		///
		/// Default is VTK_COLOR_MODE_MAP_SCALARS.
		/// </summary>
		// Token: 0x06011AE4 RID: 72420 RVA: 0x0018B730 File Offset: 0x00189930
		public virtual int GetColorMode()
		{
			return vtkPlotParallelCoordinates.vtkPlotParallelCoordinates_GetColorMode_04(base.GetCppThis());
		}

		// Token: 0x06011AE5 RID: 72421
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotParallelCoordinates_GetLookupTable_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify a lookup table for the mapper to use.
		/// </summary>
		// Token: 0x06011AE6 RID: 72422 RVA: 0x0018B750 File Offset: 0x00189950
		public vtkScalarsToColors GetLookupTable()
		{
			vtkScalarsToColors vtkScalarsToColors = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotParallelCoordinates.vtkPlotParallelCoordinates_GetLookupTable_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06011AE7 RID: 72423
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlotParallelCoordinates_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011AE8 RID: 72424 RVA: 0x0018B7C0 File Offset: 0x001899C0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPlotParallelCoordinates.vtkPlotParallelCoordinates_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x06011AE9 RID: 72425
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlotParallelCoordinates_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011AEA RID: 72426 RVA: 0x0018B7E0 File Offset: 0x001899E0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPlotParallelCoordinates.vtkPlotParallelCoordinates_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x06011AEB RID: 72427
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlotParallelCoordinates_GetScalarVisibility_08(HandleRef pThis);

		/// <summary>
		/// Turn on/off flag to control whether scalar data is used to color objects.
		/// </summary>
		// Token: 0x06011AEC RID: 72428 RVA: 0x0018B7FC File Offset: 0x001899FC
		public virtual int GetScalarVisibility()
		{
			return vtkPlotParallelCoordinates.vtkPlotParallelCoordinates_GetScalarVisibility_08(base.GetCppThis());
		}

		// Token: 0x06011AED RID: 72429
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlotParallelCoordinates_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011AEE RID: 72430 RVA: 0x0018B81C File Offset: 0x00189A1C
		public override int IsA(string type)
		{
			return vtkPlotParallelCoordinates.vtkPlotParallelCoordinates_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x06011AEF RID: 72431
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlotParallelCoordinates_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011AF0 RID: 72432 RVA: 0x0018B83C File Offset: 0x00189A3C
		public new static int IsTypeOf(string type)
		{
			return vtkPlotParallelCoordinates.vtkPlotParallelCoordinates_IsTypeOf_10(type);
		}

		// Token: 0x06011AF1 RID: 72433
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotParallelCoordinates_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011AF2 RID: 72434 RVA: 0x0018B858 File Offset: 0x00189A58
		public new vtkPlotParallelCoordinates NewInstance()
		{
			vtkPlotParallelCoordinates result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotParallelCoordinates.vtkPlotParallelCoordinates_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlotParallelCoordinates)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011AF3 RID: 72435
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlotParallelCoordinates_Paint_13(HandleRef pThis, HandleRef painter);

		/// <summary>
		/// Paint event for the XY plot, called whenever the chart needs to be drawn
		/// </summary>
		// Token: 0x06011AF4 RID: 72436 RVA: 0x0018B8B4 File Offset: 0x00189AB4
		public override bool Paint(vtkContext2D painter)
		{
			return vtkPlotParallelCoordinates.vtkPlotParallelCoordinates_Paint_13(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		// Token: 0x06011AF5 RID: 72437
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlotParallelCoordinates_PaintLegend_14(HandleRef pThis, HandleRef painter, HandleRef rect, int legendIndex);

		/// <summary>
		/// Paint legend event for the XY plot, called whenever the legend needs the
		/// plot items symbol/mark/line drawn. A rect is supplied with the lower left
		/// corner of the rect (elements 0 and 1) and with width x height (elements 2
		/// and 3). The plot can choose how to fill the space supplied.
		/// </summary>
		// Token: 0x06011AF6 RID: 72438 RVA: 0x0018B8F0 File Offset: 0x00189AF0
		public override bool PaintLegend(vtkContext2D painter, vtkRectf rect, int legendIndex)
		{
			return vtkPlotParallelCoordinates.vtkPlotParallelCoordinates_PaintLegend_14(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis(), (rect == null) ? default(HandleRef) : rect.GetCppThis(), legendIndex) != 0;
		}

		// Token: 0x06011AF7 RID: 72439
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlotParallelCoordinates_ResetSelectionRange_15(HandleRef pThis);

		/// <summary>
		/// Reset the selection criteria for the chart.
		/// </summary>
		// Token: 0x06011AF8 RID: 72440 RVA: 0x0018B944 File Offset: 0x00189B44
		public bool ResetSelectionRange()
		{
			return vtkPlotParallelCoordinates.vtkPlotParallelCoordinates_ResetSelectionRange_15(base.GetCppThis()) != 0;
		}

		// Token: 0x06011AF9 RID: 72441
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotParallelCoordinates_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011AFA RID: 72442 RVA: 0x0018B96C File Offset: 0x00189B6C
		public new static vtkPlotParallelCoordinates SafeDownCast(vtkObjectBase o)
		{
			vtkPlotParallelCoordinates vtkPlotParallelCoordinates = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotParallelCoordinates.vtkPlotParallelCoordinates_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlotParallelCoordinates = (vtkPlotParallelCoordinates)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlotParallelCoordinates.Register(null);
				}
			}
			return vtkPlotParallelCoordinates;
		}

		// Token: 0x06011AFB RID: 72443
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotParallelCoordinates_ScalarVisibilityOff_17(HandleRef pThis);

		/// <summary>
		/// Turn on/off flag to control whether scalar data is used to color objects.
		/// </summary>
		// Token: 0x06011AFC RID: 72444 RVA: 0x0018B9EB File Offset: 0x00189BEB
		public virtual void ScalarVisibilityOff()
		{
			vtkPlotParallelCoordinates.vtkPlotParallelCoordinates_ScalarVisibilityOff_17(base.GetCppThis());
		}

		// Token: 0x06011AFD RID: 72445
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotParallelCoordinates_ScalarVisibilityOn_18(HandleRef pThis);

		/// <summary>
		/// Turn on/off flag to control whether scalar data is used to color objects.
		/// </summary>
		// Token: 0x06011AFE RID: 72446 RVA: 0x0018B9FA File Offset: 0x00189BFA
		public virtual void ScalarVisibilityOn()
		{
			vtkPlotParallelCoordinates.vtkPlotParallelCoordinates_ScalarVisibilityOn_18(base.GetCppThis());
		}

		// Token: 0x06011AFF RID: 72447
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotParallelCoordinates_SelectColorArray_19(HandleRef pThis, long arrayNum);

		/// <summary>
		/// When ScalarMode is set to UsePointFieldData or UseCellFieldData,
		/// you can specify which array to use for coloring using these methods.
		/// The lookup table will decide how to convert vectors to colors.
		/// </summary>
		// Token: 0x06011B00 RID: 72448 RVA: 0x0018BA09 File Offset: 0x00189C09
		public void SelectColorArray(long arrayNum)
		{
			vtkPlotParallelCoordinates.vtkPlotParallelCoordinates_SelectColorArray_19(base.GetCppThis(), arrayNum);
		}

		// Token: 0x06011B01 RID: 72449
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotParallelCoordinates_SelectColorArray_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName);

		/// <summary>
		/// When ScalarMode is set to UsePointFieldData or UseCellFieldData,
		/// you can specify which array to use for coloring using these methods.
		/// The lookup table will decide how to convert vectors to colors.
		/// </summary>
		// Token: 0x06011B02 RID: 72450 RVA: 0x0018BA19 File Offset: 0x00189C19
		public void SelectColorArray(string arrayName)
		{
			vtkPlotParallelCoordinates.vtkPlotParallelCoordinates_SelectColorArray_20(base.GetCppThis(), arrayName);
		}

		// Token: 0x06011B03 RID: 72451
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotParallelCoordinates_SetColorMode_21(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the color mode for the plot.
		///
		/// The options are:
		/// VTK_COLOR_MODE_DEFAULT
		/// VTK_COLOR_MODE_MAP_SCALARS
		/// VTK_COLOR_MODE_DIRECT_SCALARS
		///
		/// Default is VTK_COLOR_MODE_MAP_SCALARS.
		/// </summary>
		// Token: 0x06011B04 RID: 72452 RVA: 0x0018BA29 File Offset: 0x00189C29
		public virtual void SetColorMode(int _arg)
		{
			vtkPlotParallelCoordinates.vtkPlotParallelCoordinates_SetColorMode_21(base.GetCppThis(), _arg);
		}

		// Token: 0x06011B05 RID: 72453
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotParallelCoordinates_SetColorModeToDefault_22(HandleRef pThis);

		/// <summary>
		/// Set/Get the color mode for the plot.
		///
		/// The options are:
		/// VTK_COLOR_MODE_DEFAULT
		/// VTK_COLOR_MODE_MAP_SCALARS
		/// VTK_COLOR_MODE_DIRECT_SCALARS
		///
		/// Default is VTK_COLOR_MODE_MAP_SCALARS.
		/// </summary>
		// Token: 0x06011B06 RID: 72454 RVA: 0x0018BA39 File Offset: 0x00189C39
		public void SetColorModeToDefault()
		{
			vtkPlotParallelCoordinates.vtkPlotParallelCoordinates_SetColorModeToDefault_22(base.GetCppThis());
		}

		// Token: 0x06011B07 RID: 72455
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotParallelCoordinates_SetColorModeToDirectScalars_23(HandleRef pThis);

		/// <summary>
		/// Set/Get the color mode for the plot.
		///
		/// The options are:
		/// VTK_COLOR_MODE_DEFAULT
		/// VTK_COLOR_MODE_MAP_SCALARS
		/// VTK_COLOR_MODE_DIRECT_SCALARS
		///
		/// Default is VTK_COLOR_MODE_MAP_SCALARS.
		/// </summary>
		// Token: 0x06011B08 RID: 72456 RVA: 0x0018BA48 File Offset: 0x00189C48
		public void SetColorModeToDirectScalars()
		{
			vtkPlotParallelCoordinates.vtkPlotParallelCoordinates_SetColorModeToDirectScalars_23(base.GetCppThis());
		}

		// Token: 0x06011B09 RID: 72457
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotParallelCoordinates_SetColorModeToMapScalars_24(HandleRef pThis);

		/// <summary>
		/// Set/Get the color mode for the plot.
		///
		/// The options are:
		/// VTK_COLOR_MODE_DEFAULT
		/// VTK_COLOR_MODE_MAP_SCALARS
		/// VTK_COLOR_MODE_DIRECT_SCALARS
		///
		/// Default is VTK_COLOR_MODE_MAP_SCALARS.
		/// </summary>
		// Token: 0x06011B0A RID: 72458 RVA: 0x0018BA57 File Offset: 0x00189C57
		public void SetColorModeToMapScalars()
		{
			vtkPlotParallelCoordinates.vtkPlotParallelCoordinates_SetColorModeToMapScalars_24(base.GetCppThis());
		}

		// Token: 0x06011B0B RID: 72459
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotParallelCoordinates_SetInputData_25(HandleRef pThis, HandleRef table);

		/// <summary>
		/// This is a convenience function to set the input table.
		/// </summary>
		// Token: 0x06011B0C RID: 72460 RVA: 0x0018BA68 File Offset: 0x00189C68
		public override void SetInputData(vtkTable table)
		{
			vtkPlotParallelCoordinates.vtkPlotParallelCoordinates_SetInputData_25(base.GetCppThis(), (table == null) ? default(HandleRef) : table.GetCppThis());
		}

		// Token: 0x06011B0D RID: 72461
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotParallelCoordinates_SetInputData_26(HandleRef pThis, HandleRef table, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg1, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg2);

		/// <summary>
		/// This is a convenience function to set the input table.
		/// </summary>
		// Token: 0x06011B0E RID: 72462 RVA: 0x0018BA98 File Offset: 0x00189C98
		public override void SetInputData(vtkTable table, string arg1, string arg2)
		{
			vtkPlotParallelCoordinates.vtkPlotParallelCoordinates_SetInputData_26(base.GetCppThis(), (table == null) ? default(HandleRef) : table.GetCppThis(), arg1, arg2);
		}

		// Token: 0x06011B0F RID: 72463
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotParallelCoordinates_SetLookupTable_27(HandleRef pThis, HandleRef lut);

		/// <summary>
		/// Specify a lookup table for the mapper to use.
		/// </summary>
		// Token: 0x06011B10 RID: 72464 RVA: 0x0018BACC File Offset: 0x00189CCC
		public void SetLookupTable(vtkScalarsToColors lut)
		{
			vtkPlotParallelCoordinates.vtkPlotParallelCoordinates_SetLookupTable_27(base.GetCppThis(), (lut == null) ? default(HandleRef) : lut.GetCppThis());
		}

		// Token: 0x06011B11 RID: 72465
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotParallelCoordinates_SetScalarVisibility_28(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off flag to control whether scalar data is used to color objects.
		/// </summary>
		// Token: 0x06011B12 RID: 72466 RVA: 0x0018BAFB File Offset: 0x00189CFB
		public virtual void SetScalarVisibility(int _arg)
		{
			vtkPlotParallelCoordinates.vtkPlotParallelCoordinates_SetScalarVisibility_28(base.GetCppThis(), _arg);
		}

		// Token: 0x06011B13 RID: 72467
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlotParallelCoordinates_SetSelectionRange_29(HandleRef pThis, int axis, float low, float high);

		/// <summary>
		/// Set the selection criteria on the given axis in normalized space (0.0 - 1.0) for a specific
		/// range.
		/// </summary>
		// Token: 0x06011B14 RID: 72468 RVA: 0x0018BB0C File Offset: 0x00189D0C
		public bool SetSelectionRange(int axis, float low, float high)
		{
			return vtkPlotParallelCoordinates.vtkPlotParallelCoordinates_SetSelectionRange_29(base.GetCppThis(), axis, low, high) != 0;
		}

		// Token: 0x06011B15 RID: 72469
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlotParallelCoordinates_UpdateCache_30(HandleRef pThis);

		/// <summary>
		/// Update the internal cache. Returns true if cache was successfully updated. Default does
		/// nothing.
		/// This method is called by Update() when either the plot's data has changed or
		/// CacheRequiresUpdate() returns true. It is not necessary to call this method explicitly.
		/// </summary>
		// Token: 0x06011B16 RID: 72470 RVA: 0x0018BB38 File Offset: 0x00189D38
		public override bool UpdateCache()
		{
			return vtkPlotParallelCoordinates.vtkPlotParallelCoordinates_UpdateCache_30(base.GetCppThis()) != 0;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001467 RID: 5223
		public new const string MRFullTypeName = "Kitware.VTK.vtkPlotParallelCoordinates";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001468 RID: 5224
		public new static readonly string MRClassNameKey = "class vtkPlotParallelCoordinates";
	}
}
