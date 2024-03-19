using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkParallelCoordinatesRepresentation
	/// </summary>
	/// <remarks>
	///    Data representation that
	///  takes generic multivariate data and produces a parallel coordinates plot.
	///
	///
	///  A parallel coordinates plot represents each variable in a multivariate
	///  data set as a separate axis.  Individual samples of that data set are
	///  represented as a polyline that pass through each variable axis at
	///  positions that correspond to data values.  vtkParallelCoordinatesRepresentation
	///  generates this plot when added to a vtkParallelCoordinatesView, which handles
	///  interaction and highlighting.  Sample polylines can alternatively
	///  be represented as s-curves by enabling the UseCurves flag.
	///
	///  There are three selection modes: lasso, angle, and function. Lasso selection
	///  picks sample lines that pass through a polyline.  Angle selection picks sample
	///  lines that have similar slope to a line segment.  Function selection picks
	///  sample lines that are near a linear function defined on two variables.  This
	///  function specified by passing two (x,y) variable value pairs.
	///
	///  All primitives are plotted in normalized view coordinates [0,1].
	///
	/// </remarks>
	/// <seealso>
	///
	///  vtkParallelCoordinatesView vtkParallelCoordinatesHistogramRepresentation
	///  vtkSCurveSpline
	///
	/// @par Thanks:
	///  Developed by David Feng at Sandia National Laboratories
	/// </seealso>
	// Token: 0x0200007A RID: 122
	public class vtkParallelCoordinatesRepresentation : vtkRenderedRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060016B8 RID: 5816 RVA: 0x000260DB File Offset: 0x000242DB
		static vtkParallelCoordinatesRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParallelCoordinatesRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParallelCoordinatesRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060016B9 RID: 5817 RVA: 0x00026103 File Offset: 0x00024303
		public vtkParallelCoordinatesRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060016BA RID: 5818
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelCoordinatesRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060016BB RID: 5819 RVA: 0x00026114 File Offset: 0x00024314
		public new static vtkParallelCoordinatesRepresentation New()
		{
			vtkParallelCoordinatesRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParallelCoordinatesRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060016BC RID: 5820 RVA: 0x00026168 File Offset: 0x00024368
		public vtkParallelCoordinatesRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060016BD RID: 5821 RVA: 0x000261AC File Offset: 0x000243AC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060016BE RID: 5822
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesRepresentation_AngleSelect_01(HandleRef pThis, int brushClass, int brushOperator, IntPtr p1, IntPtr p2);

		/// <summary>
		/// Do a selection of the lines.  See the main description for how to use these functions.
		/// RangeSelect is currently stubbed out.
		/// </summary>
		// Token: 0x060016BF RID: 5823 RVA: 0x000261B7 File Offset: 0x000243B7
		public virtual void AngleSelect(int brushClass, int brushOperator, IntPtr p1, IntPtr p2)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_AngleSelect_01(base.GetCppThis(), brushClass, brushOperator, p1, p2);
		}

		// Token: 0x060016C0 RID: 5824
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesRepresentation_ApplyViewTheme_02(HandleRef pThis, HandleRef theme);

		/// <summary>
		/// Apply the theme to this view.  CellColor is used for line coloring
		/// and titles.  EdgeLabelColor is used for axis color. CellOpacity is
		/// used for line opacity.
		/// </summary>
		// Token: 0x060016C1 RID: 5825 RVA: 0x000261CC File Offset: 0x000243CC
		public override void ApplyViewTheme(vtkViewTheme theme)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_ApplyViewTheme_02(base.GetCppThis(), (theme == null) ? default(HandleRef) : theme.GetCppThis());
		}

		// Token: 0x060016C2 RID: 5826
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesRepresentation_FunctionSelect_03(HandleRef pThis, int brushClass, int brushOperator, IntPtr p1, IntPtr p2, IntPtr q1, IntPtr q2);

		/// <summary>
		/// Do a selection of the lines.  See the main description for how to use these functions.
		/// RangeSelect is currently stubbed out.
		/// </summary>
		// Token: 0x060016C3 RID: 5827 RVA: 0x000261FB File Offset: 0x000243FB
		public virtual void FunctionSelect(int brushClass, int brushOperator, IntPtr p1, IntPtr p2, IntPtr q1, IntPtr q2)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_FunctionSelect_03(base.GetCppThis(), brushClass, brushOperator, p1, p2, q1, q2);
		}

		// Token: 0x060016C4 RID: 5828
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParallelCoordinatesRepresentation_GetAngleBrushThreshold_04(HandleRef pThis);

		/// <summary>
		/// Maximum angle difference (in degrees) of selection using angle/function brushes
		/// </summary>
		// Token: 0x060016C5 RID: 5829 RVA: 0x00026214 File Offset: 0x00024414
		public virtual double GetAngleBrushThreshold()
		{
			return vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_GetAngleBrushThreshold_04(base.GetCppThis());
		}

		// Token: 0x060016C6 RID: 5830
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelCoordinatesRepresentation_GetAxisColor_05(HandleRef pThis);

		/// <summary>
		/// Access plot properties
		/// </summary>
		// Token: 0x060016C7 RID: 5831 RVA: 0x00026234 File Offset: 0x00024434
		public virtual double[] GetAxisColor()
		{
			IntPtr intPtr = vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_GetAxisColor_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060016C8 RID: 5832
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesRepresentation_GetAxisColor_06(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Access plot properties
		/// </summary>
		// Token: 0x060016C9 RID: 5833 RVA: 0x0002627C File Offset: 0x0002447C
		public virtual void GetAxisColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_GetAxisColor_06(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060016CA RID: 5834
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesRepresentation_GetAxisColor_07(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Access plot properties
		/// </summary>
		// Token: 0x060016CB RID: 5835 RVA: 0x0002628E File Offset: 0x0002448E
		public virtual void GetAxisColor(IntPtr _arg)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_GetAxisColor_07(base.GetCppThis(), _arg);
		}

		// Token: 0x060016CC RID: 5836
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelCoordinatesRepresentation_GetAxisLabelColor_08(HandleRef pThis);

		/// <summary>
		/// Access plot properties
		/// </summary>
		// Token: 0x060016CD RID: 5837 RVA: 0x000262A0 File Offset: 0x000244A0
		public virtual double[] GetAxisLabelColor()
		{
			IntPtr intPtr = vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_GetAxisLabelColor_08(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060016CE RID: 5838
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesRepresentation_GetAxisLabelColor_09(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Access plot properties
		/// </summary>
		// Token: 0x060016CF RID: 5839 RVA: 0x000262E8 File Offset: 0x000244E8
		public virtual void GetAxisLabelColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_GetAxisLabelColor_09(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060016D0 RID: 5840
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesRepresentation_GetAxisLabelColor_10(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Access plot properties
		/// </summary>
		// Token: 0x060016D1 RID: 5841 RVA: 0x000262FA File Offset: 0x000244FA
		public virtual void GetAxisLabelColor(IntPtr _arg)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_GetAxisLabelColor_10(base.GetCppThis(), _arg);
		}

		// Token: 0x060016D2 RID: 5842
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelCoordinatesRepresentation_GetCurveResolution_11(HandleRef pThis);

		/// <summary>
		/// Resolution of the curves displayed, enabled by setting UseCurves
		/// </summary>
		// Token: 0x060016D3 RID: 5843 RVA: 0x0002630C File Offset: 0x0002450C
		public virtual int GetCurveResolution()
		{
			return vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_GetCurveResolution_11(base.GetCppThis());
		}

		// Token: 0x060016D4 RID: 5844
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParallelCoordinatesRepresentation_GetFontSize_12(HandleRef pThis);

		/// <summary>
		/// Access plot properties
		/// </summary>
		// Token: 0x060016D5 RID: 5845 RVA: 0x0002632C File Offset: 0x0002452C
		public virtual double GetFontSize()
		{
			return vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_GetFontSize_12(base.GetCppThis());
		}

		// Token: 0x060016D6 RID: 5846
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParallelCoordinatesRepresentation_GetFunctionBrushThreshold_13(HandleRef pThis);

		/// <summary>
		/// Maximum angle difference (in degrees) of selection using angle/function brushes
		/// </summary>
		// Token: 0x060016D7 RID: 5847 RVA: 0x0002634C File Offset: 0x0002454C
		public virtual double GetFunctionBrushThreshold()
		{
			return vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_GetFunctionBrushThreshold_13(base.GetCppThis());
		}

		// Token: 0x060016D8 RID: 5848
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkParallelCoordinatesRepresentation_GetHoverString_14(HandleRef pThis, HandleRef view, int x, int y);

		/// <summary>
		/// Returns the hover text at an x,y location.
		/// </summary>
		// Token: 0x060016D9 RID: 5849 RVA: 0x0002636C File Offset: 0x0002456C
		public virtual string GetHoverString(vtkView view, int x, int y)
		{
			return vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_GetHoverString_14(base.GetCppThis(), (view == null) ? default(HandleRef) : view.GetCppThis(), x, y);
		}

		// Token: 0x060016DA RID: 5850
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelCoordinatesRepresentation_GetLineColor_15(HandleRef pThis);

		/// <summary>
		/// Access plot properties
		/// </summary>
		// Token: 0x060016DB RID: 5851 RVA: 0x000263A4 File Offset: 0x000245A4
		public virtual double[] GetLineColor()
		{
			IntPtr intPtr = vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_GetLineColor_15(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060016DC RID: 5852
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesRepresentation_GetLineColor_16(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Access plot properties
		/// </summary>
		// Token: 0x060016DD RID: 5853 RVA: 0x000263EC File Offset: 0x000245EC
		public virtual void GetLineColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_GetLineColor_16(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060016DE RID: 5854
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesRepresentation_GetLineColor_17(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Access plot properties
		/// </summary>
		// Token: 0x060016DF RID: 5855 RVA: 0x000263FE File Offset: 0x000245FE
		public virtual void GetLineColor(IntPtr _arg)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_GetLineColor_17(base.GetCppThis(), _arg);
		}

		// Token: 0x060016E0 RID: 5856
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParallelCoordinatesRepresentation_GetLineOpacity_18(HandleRef pThis);

		/// <summary>
		/// Access plot properties
		/// </summary>
		// Token: 0x060016E1 RID: 5857 RVA: 0x00026410 File Offset: 0x00024610
		public virtual double GetLineOpacity()
		{
			return vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_GetLineOpacity_18(base.GetCppThis());
		}

		// Token: 0x060016E2 RID: 5858
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelCoordinatesRepresentation_GetNumberOfAxes_19(HandleRef pThis);

		/// <summary>
		/// Get the number of axes in the plot
		/// </summary>
		// Token: 0x060016E3 RID: 5859 RVA: 0x00026430 File Offset: 0x00024630
		public virtual int GetNumberOfAxes()
		{
			return vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_GetNumberOfAxes_19(base.GetCppThis());
		}

		// Token: 0x060016E4 RID: 5860
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelCoordinatesRepresentation_GetNumberOfAxisLabels_20(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of labels to display on each axis
		/// </summary>
		// Token: 0x060016E5 RID: 5861 RVA: 0x00026450 File Offset: 0x00024650
		public virtual int GetNumberOfAxisLabels()
		{
			return vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_GetNumberOfAxisLabels_20(base.GetCppThis());
		}

		// Token: 0x060016E6 RID: 5862
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParallelCoordinatesRepresentation_GetNumberOfGenerationsFromBase_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060016E7 RID: 5863 RVA: 0x00026470 File Offset: 0x00024670
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_GetNumberOfGenerationsFromBase_21(base.GetCppThis(), type);
		}

		// Token: 0x060016E8 RID: 5864
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParallelCoordinatesRepresentation_GetNumberOfGenerationsFromBaseType_22([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060016E9 RID: 5865 RVA: 0x00026490 File Offset: 0x00024690
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_GetNumberOfGenerationsFromBaseType_22(type);
		}

		// Token: 0x060016EA RID: 5866
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelCoordinatesRepresentation_GetNumberOfSamples_23(HandleRef pThis);

		/// <summary>
		/// Get the number of samples in the plot
		/// </summary>
		// Token: 0x060016EB RID: 5867 RVA: 0x000264AC File Offset: 0x000246AC
		public virtual int GetNumberOfSamples()
		{
			return vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_GetNumberOfSamples_23(base.GetCppThis());
		}

		// Token: 0x060016EC RID: 5868
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelCoordinatesRepresentation_GetPositionAndSize_24(HandleRef pThis, IntPtr position, IntPtr size);

		/// <summary>
		/// Change the position of the plot
		/// </summary>
		// Token: 0x060016ED RID: 5869 RVA: 0x000264CC File Offset: 0x000246CC
		public int GetPositionAndSize(IntPtr position, IntPtr size)
		{
			return vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_GetPositionAndSize_24(base.GetCppThis(), position, size);
		}

		// Token: 0x060016EE RID: 5870
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelCoordinatesRepresentation_GetPositionNearXCoordinate_25(HandleRef pThis, double xcoord);

		/// <summary>
		/// Move an axis to a particular screen position.  Using these
		/// methods requires an Update() before they will work properly.
		/// </summary>
		// Token: 0x060016EF RID: 5871 RVA: 0x000264F0 File Offset: 0x000246F0
		public int GetPositionNearXCoordinate(double xcoord)
		{
			return vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_GetPositionNearXCoordinate_25(base.GetCppThis(), xcoord);
		}

		// Token: 0x060016F0 RID: 5872
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelCoordinatesRepresentation_GetRangeAtPosition_26(HandleRef pThis, int position, IntPtr range);

		/// <summary>
		/// Set/get the value range of the axis at a particular screen position
		/// </summary>
		// Token: 0x060016F1 RID: 5873 RVA: 0x00026510 File Offset: 0x00024710
		public int GetRangeAtPosition(int position, IntPtr range)
		{
			return vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_GetRangeAtPosition_26(base.GetCppThis(), position, range);
		}

		// Token: 0x060016F2 RID: 5874
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelCoordinatesRepresentation_GetUseCurves_27(HandleRef pThis);

		/// <summary>
		/// Whether or not to display using curves
		/// </summary>
		// Token: 0x060016F3 RID: 5875 RVA: 0x00026534 File Offset: 0x00024734
		public virtual int GetUseCurves()
		{
			return vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_GetUseCurves_27(base.GetCppThis());
		}

		// Token: 0x060016F4 RID: 5876
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParallelCoordinatesRepresentation_GetXCoordinateOfPosition_28(HandleRef pThis, int axis);

		/// <summary>
		/// Move an axis to a particular screen position.  Using these
		/// methods requires an Update() before they will work properly.
		/// </summary>
		// Token: 0x060016F5 RID: 5877 RVA: 0x00026554 File Offset: 0x00024754
		public double GetXCoordinateOfPosition(int axis)
		{
			return vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_GetXCoordinateOfPosition_28(base.GetCppThis(), axis);
		}

		// Token: 0x060016F6 RID: 5878
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesRepresentation_GetXCoordinatesOfPositions_29(HandleRef pThis, IntPtr coords);

		/// <summary>
		/// Move an axis to a particular screen position.  Using these
		/// methods requires an Update() before they will work properly.
		/// </summary>
		// Token: 0x060016F7 RID: 5879 RVA: 0x00026574 File Offset: 0x00024774
		public void GetXCoordinatesOfPositions(IntPtr coords)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_GetXCoordinatesOfPositions_29(base.GetCppThis(), coords);
		}

		// Token: 0x060016F8 RID: 5880
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelCoordinatesRepresentation_IsA_30(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060016F9 RID: 5881 RVA: 0x00026584 File Offset: 0x00024784
		public override int IsA(string type)
		{
			return vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_IsA_30(base.GetCppThis(), type);
		}

		// Token: 0x060016FA RID: 5882
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelCoordinatesRepresentation_IsTypeOf_31([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060016FB RID: 5883 RVA: 0x000265A4 File Offset: 0x000247A4
		public new static int IsTypeOf(string type)
		{
			return vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_IsTypeOf_31(type);
		}

		// Token: 0x060016FC RID: 5884
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesRepresentation_LassoSelect_32(HandleRef pThis, int brushClass, int brushOperator, HandleRef brushPoints);

		/// <summary>
		/// Do a selection of the lines.  See the main description for how to use these functions.
		/// RangeSelect is currently stubbed out.
		/// </summary>
		// Token: 0x060016FD RID: 5885 RVA: 0x000265C0 File Offset: 0x000247C0
		public virtual void LassoSelect(int brushClass, int brushOperator, vtkPoints brushPoints)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_LassoSelect_32(base.GetCppThis(), brushClass, brushOperator, (brushPoints == null) ? default(HandleRef) : brushPoints.GetCppThis());
		}

		// Token: 0x060016FE RID: 5886
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelCoordinatesRepresentation_NewInstance_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060016FF RID: 5887 RVA: 0x000265F4 File Offset: 0x000247F4
		public new vtkParallelCoordinatesRepresentation NewInstance()
		{
			vtkParallelCoordinatesRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_NewInstance_34(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParallelCoordinatesRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06001700 RID: 5888
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesRepresentation_RangeSelect_35(HandleRef pThis, int brushClass, int brushOperator, IntPtr p1, IntPtr p2);

		/// <summary>
		/// Do a selection of the lines.  See the main description for how to use these functions.
		/// RangeSelect is currently stubbed out.
		/// </summary>
		// Token: 0x06001701 RID: 5889 RVA: 0x0002664E File Offset: 0x0002484E
		public virtual void RangeSelect(int brushClass, int brushOperator, IntPtr p1, IntPtr p2)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_RangeSelect_35(base.GetCppThis(), brushClass, brushOperator, p1, p2);
		}

		// Token: 0x06001702 RID: 5890
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesRepresentation_ResetAxes_36(HandleRef pThis);

		/// <summary>
		/// Reset the axes to their default positions and orders
		/// </summary>
		// Token: 0x06001703 RID: 5891 RVA: 0x00026662 File Offset: 0x00024862
		public void ResetAxes()
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_ResetAxes_36(base.GetCppThis());
		}

		// Token: 0x06001704 RID: 5892
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelCoordinatesRepresentation_SafeDownCast_37(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001705 RID: 5893 RVA: 0x00026674 File Offset: 0x00024874
		public new static vtkParallelCoordinatesRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkParallelCoordinatesRepresentation vtkParallelCoordinatesRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_SafeDownCast_37((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParallelCoordinatesRepresentation = (vtkParallelCoordinatesRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParallelCoordinatesRepresentation.Register(null);
				}
			}
			return vtkParallelCoordinatesRepresentation;
		}

		// Token: 0x06001706 RID: 5894
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesRepresentation_SetAngleBrushThreshold_38(HandleRef pThis, double _arg);

		/// <summary>
		/// Maximum angle difference (in degrees) of selection using angle/function brushes
		/// </summary>
		// Token: 0x06001707 RID: 5895 RVA: 0x000266F3 File Offset: 0x000248F3
		public virtual void SetAngleBrushThreshold(double _arg)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_SetAngleBrushThreshold_38(base.GetCppThis(), _arg);
		}

		// Token: 0x06001708 RID: 5896
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesRepresentation_SetAxisColor_39(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Access plot properties
		/// </summary>
		// Token: 0x06001709 RID: 5897 RVA: 0x00026703 File Offset: 0x00024903
		public virtual void SetAxisColor(double _arg1, double _arg2, double _arg3)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_SetAxisColor_39(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600170A RID: 5898
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesRepresentation_SetAxisColor_40(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Access plot properties
		/// </summary>
		// Token: 0x0600170B RID: 5899 RVA: 0x00026715 File Offset: 0x00024915
		public virtual void SetAxisColor(IntPtr _arg)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_SetAxisColor_40(base.GetCppThis(), _arg);
		}

		// Token: 0x0600170C RID: 5900
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesRepresentation_SetAxisLabelColor_41(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Access plot properties
		/// </summary>
		// Token: 0x0600170D RID: 5901 RVA: 0x00026725 File Offset: 0x00024925
		public virtual void SetAxisLabelColor(double _arg1, double _arg2, double _arg3)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_SetAxisLabelColor_41(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600170E RID: 5902
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesRepresentation_SetAxisLabelColor_42(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Access plot properties
		/// </summary>
		// Token: 0x0600170F RID: 5903 RVA: 0x00026737 File Offset: 0x00024937
		public virtual void SetAxisLabelColor(IntPtr _arg)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_SetAxisLabelColor_42(base.GetCppThis(), _arg);
		}

		// Token: 0x06001710 RID: 5904
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesRepresentation_SetAxisTitles_43(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the axis titles
		/// </summary>
		// Token: 0x06001711 RID: 5905 RVA: 0x00026748 File Offset: 0x00024948
		public void SetAxisTitles(vtkStringArray arg0)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_SetAxisTitles_43(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06001712 RID: 5906
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesRepresentation_SetAxisTitles_44(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the axis titles
		/// </summary>
		// Token: 0x06001713 RID: 5907 RVA: 0x00026778 File Offset: 0x00024978
		public void SetAxisTitles(vtkAlgorithmOutput arg0)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_SetAxisTitles_44(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06001714 RID: 5908
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesRepresentation_SetCurveResolution_45(HandleRef pThis, int _arg);

		/// <summary>
		/// Resolution of the curves displayed, enabled by setting UseCurves
		/// </summary>
		// Token: 0x06001715 RID: 5909 RVA: 0x000267A7 File Offset: 0x000249A7
		public virtual void SetCurveResolution(int _arg)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_SetCurveResolution_45(base.GetCppThis(), _arg);
		}

		// Token: 0x06001716 RID: 5910
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesRepresentation_SetFontSize_46(HandleRef pThis, double _arg);

		/// <summary>
		/// Access plot properties
		/// </summary>
		// Token: 0x06001717 RID: 5911 RVA: 0x000267B7 File Offset: 0x000249B7
		public virtual void SetFontSize(double _arg)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_SetFontSize_46(base.GetCppThis(), _arg);
		}

		// Token: 0x06001718 RID: 5912
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesRepresentation_SetFunctionBrushThreshold_47(HandleRef pThis, double _arg);

		/// <summary>
		/// Maximum angle difference (in degrees) of selection using angle/function brushes
		/// </summary>
		// Token: 0x06001719 RID: 5913 RVA: 0x000267C7 File Offset: 0x000249C7
		public virtual void SetFunctionBrushThreshold(double _arg)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_SetFunctionBrushThreshold_47(base.GetCppThis(), _arg);
		}

		// Token: 0x0600171A RID: 5914
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesRepresentation_SetLineColor_48(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Access plot properties
		/// </summary>
		// Token: 0x0600171B RID: 5915 RVA: 0x000267D7 File Offset: 0x000249D7
		public virtual void SetLineColor(double _arg1, double _arg2, double _arg3)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_SetLineColor_48(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600171C RID: 5916
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesRepresentation_SetLineColor_49(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Access plot properties
		/// </summary>
		// Token: 0x0600171D RID: 5917 RVA: 0x000267E9 File Offset: 0x000249E9
		public virtual void SetLineColor(IntPtr _arg)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_SetLineColor_49(base.GetCppThis(), _arg);
		}

		// Token: 0x0600171E RID: 5918
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesRepresentation_SetLineOpacity_50(HandleRef pThis, double _arg);

		/// <summary>
		/// Access plot properties
		/// </summary>
		// Token: 0x0600171F RID: 5919 RVA: 0x000267F9 File Offset: 0x000249F9
		public virtual void SetLineOpacity(double _arg)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_SetLineOpacity_50(base.GetCppThis(), _arg);
		}

		// Token: 0x06001720 RID: 5920
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesRepresentation_SetNumberOfAxisLabels_51(HandleRef pThis, int num);

		/// <summary>
		/// Set/Get the number of labels to display on each axis
		/// </summary>
		// Token: 0x06001721 RID: 5921 RVA: 0x00026809 File Offset: 0x00024A09
		public void SetNumberOfAxisLabels(int num)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_SetNumberOfAxisLabels_51(base.GetCppThis(), num);
		}

		// Token: 0x06001722 RID: 5922
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesRepresentation_SetPlotTitle_52(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Set the title for the entire plot
		/// </summary>
		// Token: 0x06001723 RID: 5923 RVA: 0x00026819 File Offset: 0x00024A19
		public void SetPlotTitle(string arg0)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_SetPlotTitle_52(base.GetCppThis(), arg0);
		}

		// Token: 0x06001724 RID: 5924
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelCoordinatesRepresentation_SetPositionAndSize_53(HandleRef pThis, IntPtr position, IntPtr size);

		/// <summary>
		/// Change the position of the plot
		/// </summary>
		// Token: 0x06001725 RID: 5925 RVA: 0x0002682C File Offset: 0x00024A2C
		public int SetPositionAndSize(IntPtr position, IntPtr size)
		{
			return vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_SetPositionAndSize_53(base.GetCppThis(), position, size);
		}

		// Token: 0x06001726 RID: 5926
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelCoordinatesRepresentation_SetRangeAtPosition_54(HandleRef pThis, int position, IntPtr range);

		/// <summary>
		/// Set/get the value range of the axis at a particular screen position
		/// </summary>
		// Token: 0x06001727 RID: 5927 RVA: 0x00026850 File Offset: 0x00024A50
		public virtual int SetRangeAtPosition(int position, IntPtr range)
		{
			return vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_SetRangeAtPosition_54(base.GetCppThis(), position, range);
		}

		// Token: 0x06001728 RID: 5928
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesRepresentation_SetUseCurves_55(HandleRef pThis, int _arg);

		/// <summary>
		/// Whether or not to display using curves
		/// </summary>
		// Token: 0x06001729 RID: 5929 RVA: 0x00026871 File Offset: 0x00024A71
		public virtual void SetUseCurves(int _arg)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_SetUseCurves_55(base.GetCppThis(), _arg);
		}

		// Token: 0x0600172A RID: 5930
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelCoordinatesRepresentation_SetXCoordinateOfPosition_56(HandleRef pThis, int position, double xcoord);

		/// <summary>
		/// Move an axis to a particular screen position.  Using these
		/// methods requires an Update() before they will work properly.
		/// </summary>
		// Token: 0x0600172B RID: 5931 RVA: 0x00026884 File Offset: 0x00024A84
		public int SetXCoordinateOfPosition(int position, double xcoord)
		{
			return vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_SetXCoordinateOfPosition_56(base.GetCppThis(), position, xcoord);
		}

		// Token: 0x0600172C RID: 5932
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelCoordinatesRepresentation_SwapAxisPositions_57(HandleRef pThis, int position1, int position2);

		/// <summary>
		/// Move an axis to a particular screen position.  Using these
		/// methods requires an Update() before they will work properly.
		/// </summary>
		// Token: 0x0600172D RID: 5933 RVA: 0x000268A8 File Offset: 0x00024AA8
		public virtual int SwapAxisPositions(int position1, int position2)
		{
			return vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_SwapAxisPositions_57(base.GetCppThis(), position1, position2);
		}

		// Token: 0x0600172E RID: 5934
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesRepresentation_UseCurvesOff_58(HandleRef pThis);

		/// <summary>
		/// Whether or not to display using curves
		/// </summary>
		// Token: 0x0600172F RID: 5935 RVA: 0x000268C9 File Offset: 0x00024AC9
		public virtual void UseCurvesOff()
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_UseCurvesOff_58(base.GetCppThis());
		}

		// Token: 0x06001730 RID: 5936
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesRepresentation_UseCurvesOn_59(HandleRef pThis);

		/// <summary>
		/// Whether or not to display using curves
		/// </summary>
		// Token: 0x06001731 RID: 5937 RVA: 0x000268D8 File Offset: 0x00024AD8
		public virtual void UseCurvesOn()
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_UseCurvesOn_59(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000486 RID: 1158
		public new const string MRFullTypeName = "Kitware.VTK.vtkParallelCoordinatesRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000487 RID: 1159
		public new static readonly string MRClassNameKey = "class vtkParallelCoordinatesRepresentation";

		/// <summary>
		/// Do a selection of the lines.  See the main description for how to use these functions.
		/// RangeSelect is currently stubbed out.
		/// </summary>
		// Token: 0x0200007B RID: 123
		public enum InputPorts
		{
			/// <summary>enum member</summary>
			// Token: 0x04000489 RID: 1161
			INPUT_DATA,
			/// <summary>enum member</summary>
			// Token: 0x0400048A RID: 1162
			INPUT_TITLES,
			/// <summary>enum member</summary>
			// Token: 0x0400048B RID: 1163
			NUM_INPUT_PORTS
		}
	}
}
