using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPlotPoints
	/// </summary>
	/// <remarks>
	///    Class for drawing an points given two columns from a
	/// vtkTable.
	///
	///
	/// This class draws points in a plot given two columns from a table. If you need
	/// a line as well you should use vtkPlotLine which derives from vtkPlotPoints
	/// and is capable of drawing both points and a line.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPlotLine
	/// </seealso>
	// Token: 0x02000657 RID: 1623
	public class vtkPlotPoints : vtkPlot
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060118B3 RID: 71859 RVA: 0x00187FEE File Offset: 0x001861EE
		static vtkPlotPoints()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPlotPoints.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlotPoints"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060118B4 RID: 71860 RVA: 0x00188016 File Offset: 0x00186216
		public vtkPlotPoints(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060118B5 RID: 71861
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotPoints_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates a 2D Chart object.
		/// </summary>
		// Token: 0x060118B6 RID: 71862 RVA: 0x00188024 File Offset: 0x00186224
		public new static vtkPlotPoints New()
		{
			vtkPlotPoints result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotPoints.vtkPlotPoints_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlotPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Creates a 2D Chart object.
		/// </summary>
		// Token: 0x060118B7 RID: 71863 RVA: 0x00188078 File Offset: 0x00186278
		public vtkPlotPoints() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPlotPoints.vtkPlotPoints_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060118B8 RID: 71864 RVA: 0x001880BC File Offset: 0x001862BC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060118B9 RID: 71865
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotPoints_CreateDefaultLookupTable_01(HandleRef pThis);

		/// <summary>
		/// Create default lookup table. Generally used to create one when none
		/// is available with the scalar data.
		/// </summary>
		// Token: 0x060118BA RID: 71866 RVA: 0x001880C7 File Offset: 0x001862C7
		public virtual void CreateDefaultLookupTable()
		{
			vtkPlotPoints.vtkPlotPoints_CreateDefaultLookupTable_01(base.GetCppThis());
		}

		// Token: 0x060118BB RID: 71867
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotPoints_GetBounds_02(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Get the bounds for this plot as (Xmin, Xmax, Ymin, Ymax).
		/// </summary>
		// Token: 0x060118BC RID: 71868 RVA: 0x001880D6 File Offset: 0x001862D6
		public override void GetBounds(IntPtr bounds)
		{
			vtkPlotPoints.vtkPlotPoints_GetBounds_02(base.GetCppThis(), bounds);
		}

		// Token: 0x060118BD RID: 71869
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkPlotPoints_GetColorArrayName_03(HandleRef pThis);

		/// <summary>
		/// Get the array name to color by.
		/// </summary>
		// Token: 0x060118BE RID: 71870 RVA: 0x001880E8 File Offset: 0x001862E8
		public string GetColorArrayName()
		{
			return vtkPlotPoints.vtkPlotPoints_GetColorArrayName_03(base.GetCppThis());
		}

		// Token: 0x060118BF RID: 71871
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotPoints_GetLookupTable_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify a lookup table for the mapper to use.
		/// </summary>
		// Token: 0x060118C0 RID: 71872 RVA: 0x00188108 File Offset: 0x00186308
		public vtkScalarsToColors GetLookupTable()
		{
			vtkScalarsToColors vtkScalarsToColors = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotPoints.vtkPlotPoints_GetLookupTable_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060118C1 RID: 71873
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkPlotPoints_GetMarkerSize_05(HandleRef pThis);

		/// <summary>
		/// Get/set the marker size that should be used. The default is negative, and
		/// in that case it is 2.3 times the pen width, if less than 8 will be used.
		/// </summary>
		// Token: 0x060118C2 RID: 71874 RVA: 0x00188178 File Offset: 0x00186378
		public virtual float GetMarkerSize()
		{
			return vtkPlotPoints.vtkPlotPoints_GetMarkerSize_05(base.GetCppThis());
		}

		// Token: 0x060118C3 RID: 71875
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlotPoints_GetMarkerStyle_06(HandleRef pThis);

		/// <summary>
		/// Get/set the marker style that should be used. The default is none, the enum
		/// in this class is used as a parameter.
		/// </summary>
		// Token: 0x060118C4 RID: 71876 RVA: 0x00188198 File Offset: 0x00186398
		public virtual int GetMarkerStyle()
		{
			return vtkPlotPoints.vtkPlotPoints_GetMarkerStyle_06(base.GetCppThis());
		}

		// Token: 0x060118C5 RID: 71877
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlotPoints_GetNearestPoint_07(HandleRef pThis, HandleRef point, HandleRef tolerance, HandleRef location, IntPtr segmentId);

		/// <summary>
		/// Function to query a plot for the nearest point to the specified coordinate.
		/// Returns the index of the data series with which the point is associated or
		/// -1.
		/// </summary>
		// Token: 0x060118C6 RID: 71878 RVA: 0x001881B8 File Offset: 0x001863B8
		public override long GetNearestPoint(vtkVector2f point, vtkVector2f tolerance, vtkVector2f location, IntPtr segmentId)
		{
			return vtkPlotPoints.vtkPlotPoints_GetNearestPoint_07(base.GetCppThis(), (point == null) ? default(HandleRef) : point.GetCppThis(), (tolerance == null) ? default(HandleRef) : tolerance.GetCppThis(), (location == null) ? default(HandleRef) : location.GetCppThis(), segmentId);
		}

		// Token: 0x060118C7 RID: 71879
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlotPoints_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060118C8 RID: 71880 RVA: 0x00188218 File Offset: 0x00186418
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPlotPoints.vtkPlotPoints_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x060118C9 RID: 71881
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlotPoints_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060118CA RID: 71882 RVA: 0x00188238 File Offset: 0x00186438
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPlotPoints.vtkPlotPoints_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x060118CB RID: 71883
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlotPoints_GetScalarVisibility_10(HandleRef pThis);

		/// <summary>
		/// Turn on/off flag to control whether scalar data is used to color objects.
		/// </summary>
		// Token: 0x060118CC RID: 71884 RVA: 0x00188254 File Offset: 0x00186454
		public virtual int GetScalarVisibility()
		{
			return vtkPlotPoints.vtkPlotPoints_GetScalarVisibility_10(base.GetCppThis());
		}

		// Token: 0x060118CD RID: 71885
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotPoints_GetUnscaledInputBounds_11(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Get the non-log-scaled bounds on chart inputs for this plot as (Xmin, Xmax, Ymin, Ymax).
		/// </summary>
		// Token: 0x060118CE RID: 71886 RVA: 0x00188273 File Offset: 0x00186473
		public override void GetUnscaledInputBounds(IntPtr bounds)
		{
			vtkPlotPoints.vtkPlotPoints_GetUnscaledInputBounds_11(base.GetCppThis(), bounds);
		}

		// Token: 0x060118CF RID: 71887
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkPlotPoints_GetValidPointMaskName_12(HandleRef pThis);

		/// <summary>
		/// Get/set the valid point mask array name.
		/// </summary>
		// Token: 0x060118D0 RID: 71888 RVA: 0x00188284 File Offset: 0x00186484
		public virtual string GetValidPointMaskName()
		{
			return vtkPlotPoints.vtkPlotPoints_GetValidPointMaskName_12(base.GetCppThis());
		}

		// Token: 0x060118D1 RID: 71889
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlotPoints_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060118D2 RID: 71890 RVA: 0x001882A4 File Offset: 0x001864A4
		public override int IsA(string type)
		{
			return vtkPlotPoints.vtkPlotPoints_IsA_13(base.GetCppThis(), type);
		}

		// Token: 0x060118D3 RID: 71891
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlotPoints_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060118D4 RID: 71892 RVA: 0x001882C4 File Offset: 0x001864C4
		public new static int IsTypeOf(string type)
		{
			return vtkPlotPoints.vtkPlotPoints_IsTypeOf_14(type);
		}

		// Token: 0x060118D5 RID: 71893
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotPoints_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060118D6 RID: 71894 RVA: 0x001882E0 File Offset: 0x001864E0
		public new vtkPlotPoints NewInstance()
		{
			vtkPlotPoints result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotPoints.vtkPlotPoints_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlotPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060118D7 RID: 71895
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlotPoints_Paint_17(HandleRef pThis, HandleRef painter);

		/// <summary>
		/// Paint event for the XY plot, called whenever the chart needs to be drawn
		/// </summary>
		// Token: 0x060118D8 RID: 71896 RVA: 0x0018833C File Offset: 0x0018653C
		public override bool Paint(vtkContext2D painter)
		{
			return vtkPlotPoints.vtkPlotPoints_Paint_17(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		// Token: 0x060118D9 RID: 71897
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlotPoints_PaintLegend_18(HandleRef pThis, HandleRef painter, HandleRef rect, int legendIndex);

		/// <summary>
		/// Paint legend event for the XY plot, called whenever the legend needs the
		/// plot items symbol/mark/line drawn. A rect is supplied with the lower left
		/// corner of the rect (elements 0 and 1) and with width x height (elements 2
		/// and 3). The plot can choose how to fill the space supplied.
		/// </summary>
		// Token: 0x060118DA RID: 71898 RVA: 0x00188378 File Offset: 0x00186578
		public override bool PaintLegend(vtkContext2D painter, vtkRectf rect, int legendIndex)
		{
			return vtkPlotPoints.vtkPlotPoints_PaintLegend_18(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis(), (rect == null) ? default(HandleRef) : rect.GetCppThis(), legendIndex) != 0;
		}

		// Token: 0x060118DB RID: 71899
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotPoints_ReleaseGraphicsCache_19(HandleRef pThis);

		/// <summary>
		/// Update the internal cache. Returns true if cache was successfully updated. Default does
		/// nothing.
		/// This method is called by Update() when either the plot's data has changed or
		/// CacheRequiresUpdate() returns true. It is not necessary to call this method explicitly.
		/// </summary>
		// Token: 0x060118DC RID: 71900 RVA: 0x001883C9 File Offset: 0x001865C9
		public virtual void ReleaseGraphicsCache()
		{
			vtkPlotPoints.vtkPlotPoints_ReleaseGraphicsCache_19(base.GetCppThis());
		}

		// Token: 0x060118DD RID: 71901
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotPoints_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060118DE RID: 71902 RVA: 0x001883D8 File Offset: 0x001865D8
		public new static vtkPlotPoints SafeDownCast(vtkObjectBase o)
		{
			vtkPlotPoints vtkPlotPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotPoints.vtkPlotPoints_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlotPoints = (vtkPlotPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlotPoints.Register(null);
				}
			}
			return vtkPlotPoints;
		}

		// Token: 0x060118DF RID: 71903
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotPoints_ScalarVisibilityOff_21(HandleRef pThis);

		/// <summary>
		/// Turn on/off flag to control whether scalar data is used to color objects.
		/// </summary>
		// Token: 0x060118E0 RID: 71904 RVA: 0x00188457 File Offset: 0x00186657
		public virtual void ScalarVisibilityOff()
		{
			vtkPlotPoints.vtkPlotPoints_ScalarVisibilityOff_21(base.GetCppThis());
		}

		// Token: 0x060118E1 RID: 71905
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotPoints_ScalarVisibilityOn_22(HandleRef pThis);

		/// <summary>
		/// Turn on/off flag to control whether scalar data is used to color objects.
		/// </summary>
		// Token: 0x060118E2 RID: 71906 RVA: 0x00188466 File Offset: 0x00186666
		public virtual void ScalarVisibilityOn()
		{
			vtkPlotPoints.vtkPlotPoints_ScalarVisibilityOn_22(base.GetCppThis());
		}

		// Token: 0x060118E3 RID: 71907
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotPoints_SelectColorArray_23(HandleRef pThis, long arrayNum);

		/// <summary>
		/// When ScalarMode is set to UsePointFieldData or UseCellFieldData,
		/// you can specify which array to use for coloring using these methods.
		/// The lookup table will decide how to convert vectors to colors.
		/// </summary>
		// Token: 0x060118E4 RID: 71908 RVA: 0x00188475 File Offset: 0x00186675
		public void SelectColorArray(long arrayNum)
		{
			vtkPlotPoints.vtkPlotPoints_SelectColorArray_23(base.GetCppThis(), arrayNum);
		}

		// Token: 0x060118E5 RID: 71909
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotPoints_SelectColorArray_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName);

		/// <summary>
		/// When ScalarMode is set to UsePointFieldData or UseCellFieldData,
		/// you can specify which array to use for coloring using these methods.
		/// The lookup table will decide how to convert vectors to colors.
		/// </summary>
		// Token: 0x060118E6 RID: 71910 RVA: 0x00188485 File Offset: 0x00186685
		public void SelectColorArray(string arrayName)
		{
			vtkPlotPoints.vtkPlotPoints_SelectColorArray_24(base.GetCppThis(), arrayName);
		}

		// Token: 0x060118E7 RID: 71911
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlotPoints_SelectPoints_25(HandleRef pThis, HandleRef min, HandleRef max);

		/// <summary>
		/// Select all points in the specified rectangle.
		/// </summary>
		// Token: 0x060118E8 RID: 71912 RVA: 0x00188498 File Offset: 0x00186698
		public override bool SelectPoints(vtkVector2f min, vtkVector2f max)
		{
			return vtkPlotPoints.vtkPlotPoints_SelectPoints_25(base.GetCppThis(), (min == null) ? default(HandleRef) : min.GetCppThis(), (max == null) ? default(HandleRef) : max.GetCppThis()) != 0;
		}

		// Token: 0x060118E9 RID: 71913
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotPoints_SetLookupTable_26(HandleRef pThis, HandleRef lut);

		/// <summary>
		/// Specify a lookup table for the mapper to use.
		/// </summary>
		// Token: 0x060118EA RID: 71914 RVA: 0x001884E8 File Offset: 0x001866E8
		public void SetLookupTable(vtkScalarsToColors lut)
		{
			vtkPlotPoints.vtkPlotPoints_SetLookupTable_26(base.GetCppThis(), (lut == null) ? default(HandleRef) : lut.GetCppThis());
		}

		// Token: 0x060118EB RID: 71915
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotPoints_SetMarkerSize_27(HandleRef pThis, float _arg);

		/// <summary>
		/// Get/set the marker size that should be used. The default is negative, and
		/// in that case it is 2.3 times the pen width, if less than 8 will be used.
		/// </summary>
		// Token: 0x060118EC RID: 71916 RVA: 0x00188517 File Offset: 0x00186717
		public virtual void SetMarkerSize(float _arg)
		{
			vtkPlotPoints.vtkPlotPoints_SetMarkerSize_27(base.GetCppThis(), _arg);
		}

		// Token: 0x060118ED RID: 71917
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotPoints_SetMarkerStyle_28(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/set the marker style that should be used. The default is none, the enum
		/// in this class is used as a parameter.
		/// </summary>
		// Token: 0x060118EE RID: 71918 RVA: 0x00188527 File Offset: 0x00186727
		public virtual void SetMarkerStyle(int _arg)
		{
			vtkPlotPoints.vtkPlotPoints_SetMarkerStyle_28(base.GetCppThis(), _arg);
		}

		// Token: 0x060118EF RID: 71919
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotPoints_SetScalarVisibility_29(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off flag to control whether scalar data is used to color objects.
		/// </summary>
		// Token: 0x060118F0 RID: 71920 RVA: 0x00188537 File Offset: 0x00186737
		public virtual void SetScalarVisibility(int _arg)
		{
			vtkPlotPoints.vtkPlotPoints_SetScalarVisibility_29(base.GetCppThis(), _arg);
		}

		// Token: 0x060118F1 RID: 71921
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotPoints_SetValidPointMaskName_30(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Get/set the valid point mask array name.
		/// </summary>
		// Token: 0x060118F2 RID: 71922 RVA: 0x00188547 File Offset: 0x00186747
		public virtual void SetValidPointMaskName(string _arg)
		{
			vtkPlotPoints.vtkPlotPoints_SetValidPointMaskName_30(base.GetCppThis(), _arg);
		}

		// Token: 0x060118F3 RID: 71923
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlotPoints_UpdateCache_31(HandleRef pThis);

		/// <summary>
		/// Update the internal cache. Returns true if cache was successfully updated. Default does
		/// nothing.
		/// This method is called by Update() when either the plot's data has changed or
		/// CacheRequiresUpdate() returns true. It is not necessary to call this method explicitly.
		/// </summary>
		// Token: 0x060118F4 RID: 71924 RVA: 0x00188558 File Offset: 0x00186758
		public override bool UpdateCache()
		{
			return vtkPlotPoints.vtkPlotPoints_UpdateCache_31(base.GetCppThis()) != 0;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400143E RID: 5182
		public new const string MRFullTypeName = "Kitware.VTK.vtkPlotPoints";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400143F RID: 5183
		public new static readonly string MRClassNameKey = "class vtkPlotPoints";

		/// <summary>
		/// Enum containing various marker styles that can be used in a plot.
		/// </summary>
		// Token: 0x02000658 RID: 1624
		public enum CIRCLE_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04001441 RID: 5185
			CIRCLE = 4,
			/// <summary>enum member</summary>
			// Token: 0x04001442 RID: 5186
			CROSS = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001443 RID: 5187
			DIAMOND = 5,
			/// <summary>enum member</summary>
			// Token: 0x04001444 RID: 5188
			NONE = 0,
			/// <summary>enum member</summary>
			// Token: 0x04001445 RID: 5189
			PLUS = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001446 RID: 5190
			SQUARE
		}
	}
}
