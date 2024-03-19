using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkScatterPlotMatrix
	/// </summary>
	/// <remarks>
	///    container for a matrix of charts.
	///
	///
	/// This class contains a matrix of charts. These charts will be of type
	/// vtkChartXY by default, but this can be overridden. The class will manage
	/// their layout and object lifetime.
	/// </remarks>
	// Token: 0x0200066C RID: 1644
	public class vtkScatterPlotMatrix : vtkChartMatrix
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011BB3 RID: 72627 RVA: 0x0018CBB6 File Offset: 0x0018ADB6
		static vtkScatterPlotMatrix()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkScatterPlotMatrix.MRClassNameKey, Type.GetType("Kitware.VTK.vtkScatterPlotMatrix"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011BB4 RID: 72628 RVA: 0x0018CBDE File Offset: 0x0018ADDE
		public vtkScatterPlotMatrix(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011BB5 RID: 72629
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScatterPlotMatrix_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates a new object.
		/// </summary>
		// Token: 0x06011BB6 RID: 72630 RVA: 0x0018CBEC File Offset: 0x0018ADEC
		public new static vtkScatterPlotMatrix New()
		{
			vtkScatterPlotMatrix result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScatterPlotMatrix.vtkScatterPlotMatrix_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkScatterPlotMatrix)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Creates a new object.
		/// </summary>
		// Token: 0x06011BB7 RID: 72631 RVA: 0x0018CC40 File Offset: 0x0018AE40
		public vtkScatterPlotMatrix() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkScatterPlotMatrix.vtkScatterPlotMatrix_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011BB8 RID: 72632 RVA: 0x0018CC84 File Offset: 0x0018AE84
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011BB9 RID: 72633
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkScatterPlotMatrix_AddAnimationPath_01(HandleRef pThis, HandleRef move);

		/// <summary>
		/// Add a move to the animation path. Note that a move can only change i or j,
		/// not both. If the proposed move does not satisfy those criteria it will
		/// be rejected and the animation path will not be extended.
		/// </summary>
		// Token: 0x06011BBA RID: 72634 RVA: 0x0018CC90 File Offset: 0x0018AE90
		public bool AddAnimationPath(vtkVector2i move)
		{
			return vtkScatterPlotMatrix.vtkScatterPlotMatrix_AddAnimationPath_01(base.GetCppThis(), (move == null) ? default(HandleRef) : move.GetCppThis()) != 0;
		}

		// Token: 0x06011BBB RID: 72635
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScatterPlotMatrix_AdvanceAnimation_02(HandleRef pThis);

		/// <summary>
		/// Advance the animation in response to the timer events. This is public to
		/// allow the animation to be manually advanced when timers are not a
		/// </summary>
		// Token: 0x06011BBC RID: 72636 RVA: 0x0018CCCB File Offset: 0x0018AECB
		public virtual void AdvanceAnimation()
		{
			vtkScatterPlotMatrix.vtkScatterPlotMatrix_AdvanceAnimation_02(base.GetCppThis());
		}

		// Token: 0x06011BBD RID: 72637
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkScatterPlotMatrix_BeginAnimationPath_03(HandleRef pThis, HandleRef interactor);

		/// <summary>
		/// Trigger the animation of the scatter plot matrix to begin.
		/// </summary>
		// Token: 0x06011BBE RID: 72638 RVA: 0x0018CCDC File Offset: 0x0018AEDC
		public bool BeginAnimationPath(vtkRenderWindowInteractor interactor)
		{
			return vtkScatterPlotMatrix.vtkScatterPlotMatrix_BeginAnimationPath_03(base.GetCppThis(), (interactor == null) ? default(HandleRef) : interactor.GetCppThis()) != 0;
		}

		// Token: 0x06011BBF RID: 72639
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScatterPlotMatrix_ClearAnimationPath_04(HandleRef pThis);

		/// <summary>
		/// Clear the animation path.
		/// </summary>
		// Token: 0x06011BC0 RID: 72640 RVA: 0x0018CD17 File Offset: 0x0018AF17
		public void ClearAnimationPath()
		{
			vtkScatterPlotMatrix.vtkScatterPlotMatrix_ClearAnimationPath_04(base.GetCppThis());
		}

		// Token: 0x06011BC1 RID: 72641
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScatterPlotMatrix_GetActivePlot_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the position of the active plot.
		/// </summary>
		// Token: 0x06011BC2 RID: 72642 RVA: 0x0018CD28 File Offset: 0x0018AF28
		public virtual vtkVector2i GetActivePlot()
		{
			vtkVector2i result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScatterPlotMatrix.vtkScatterPlotMatrix_GetActivePlot_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVector2i)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011BC3 RID: 72643
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScatterPlotMatrix_GetAnimationPathElement_06(HandleRef pThis, long i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the element specified from the animation path.
		/// </summary>
		// Token: 0x06011BC4 RID: 72644 RVA: 0x0018CD84 File Offset: 0x0018AF84
		public vtkVector2i GetAnimationPathElement(long i)
		{
			vtkVector2i result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScatterPlotMatrix.vtkScatterPlotMatrix_GetAnimationPathElement_06(base.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVector2i)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011BC5 RID: 72645
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScatterPlotMatrix_GetAnnotationLink_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the AnnotationLink for the scatter plot matrix, this gives you access
		/// to the currently selected points in the scatter plot matrix.
		/// </summary>
		// Token: 0x06011BC6 RID: 72646 RVA: 0x0018CDE0 File Offset: 0x0018AFE0
		public vtkAnnotationLink GetAnnotationLink()
		{
			vtkAnnotationLink vtkAnnotationLink = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScatterPlotMatrix.vtkScatterPlotMatrix_GetAnnotationLink_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAnnotationLink = (vtkAnnotationLink)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAnnotationLink.Register(null);
				}
			}
			return vtkAnnotationLink;
		}

		// Token: 0x06011BC7 RID: 72647
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScatterPlotMatrix_GetAxisColor_08(HandleRef pThis, int plotType, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Sets the color for the axes given a plot type, which refers to
		/// vtkScatterPlotMatrix::{SCATTERPLOT, HISTOGRAM, ACTIVEPLOT}.
		/// </summary>
		// Token: 0x06011BC8 RID: 72648 RVA: 0x0018CE50 File Offset: 0x0018B050
		public vtkColor4ub GetAxisColor(int plotType)
		{
			vtkColor4ub result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScatterPlotMatrix.vtkScatterPlotMatrix_GetAxisColor_08(base.GetCppThis(), plotType, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkColor4ub)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011BC9 RID: 72649
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScatterPlotMatrix_GetAxisLabelNotation_09(HandleRef pThis, int plotType);

		/// <summary>
		/// Sets the axis label notation for the axes given a plot type, which refers to
		/// vtkScatterPlotMatrix::{SCATTERPLOT, HISTOGRAM, ACTIVEPLOT}.
		/// </summary>
		// Token: 0x06011BCA RID: 72650 RVA: 0x0018CEAC File Offset: 0x0018B0AC
		public int GetAxisLabelNotation(int plotType)
		{
			return vtkScatterPlotMatrix.vtkScatterPlotMatrix_GetAxisLabelNotation_09(base.GetCppThis(), plotType);
		}

		// Token: 0x06011BCB RID: 72651
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScatterPlotMatrix_GetAxisLabelPrecision_10(HandleRef pThis, int plotType);

		/// <summary>
		/// Sets the axis label precision for the axes given a plot type, which refers to
		/// vtkScatterPlotMatrix::{SCATTERPLOT, HISTOGRAM, ACTIVEPLOT}.
		/// </summary>
		// Token: 0x06011BCC RID: 72652 RVA: 0x0018CECC File Offset: 0x0018B0CC
		public int GetAxisLabelPrecision(int plotType)
		{
			return vtkScatterPlotMatrix.vtkScatterPlotMatrix_GetAxisLabelPrecision_10(base.GetCppThis(), plotType);
		}

		// Token: 0x06011BCD RID: 72653
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScatterPlotMatrix_GetAxisLabelProperties_11(HandleRef pThis, int plotType, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get the text property for the axis labels of the given plot type,
		/// possible types are vtkScatterPlotMatrix::{SCATTERPLOT, HISTOGRAM, ACTIVEPLOT}.
		/// </summary>
		// Token: 0x06011BCE RID: 72654 RVA: 0x0018CEEC File Offset: 0x0018B0EC
		public vtkTextProperty GetAxisLabelProperties(int plotType)
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScatterPlotMatrix.vtkScatterPlotMatrix_GetAxisLabelProperties_11(base.GetCppThis(), plotType, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06011BCF RID: 72655
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkScatterPlotMatrix_GetAxisLabelVisibility_12(HandleRef pThis, int plotType);

		/// <summary>
		/// Sets whether or not the labels for the axes are visible, given a plot type,
		/// which refers to
		/// vtkScatterPlotMatrix::{SCATTERPLOT, HISTOGRAM, ACTIVEPLOT}.
		/// </summary>
		// Token: 0x06011BD0 RID: 72656 RVA: 0x0018CF5C File Offset: 0x0018B15C
		public bool GetAxisLabelVisibility(int plotType)
		{
			return vtkScatterPlotMatrix.vtkScatterPlotMatrix_GetAxisLabelVisibility_12(base.GetCppThis(), plotType) != 0;
		}

		// Token: 0x06011BD1 RID: 72657
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScatterPlotMatrix_GetBackgroundColor_13(HandleRef pThis, int plotType, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Sets the background color for the chart given a plot type, which refers to
		/// vtkScatterPlotMatrix::{SCATTERPLOT, HISTOGRAM, ACTIVEPLOT}.
		/// </summary>
		// Token: 0x06011BD2 RID: 72658 RVA: 0x0018CF84 File Offset: 0x0018B184
		public vtkColor4ub GetBackgroundColor(int plotType)
		{
			vtkColor4ub result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScatterPlotMatrix.vtkScatterPlotMatrix_GetBackgroundColor_13(base.GetCppThis(), plotType, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkColor4ub)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011BD3 RID: 72659
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkScatterPlotMatrix_GetColumnName_14(HandleRef pThis, int column);

		/// <summary>
		/// Get the column name for the supplied index.
		/// </summary>
		// Token: 0x06011BD4 RID: 72660 RVA: 0x0018CFE0 File Offset: 0x0018B1E0
		public string GetColumnName(int column)
		{
			return vtkScatterPlotMatrix.vtkScatterPlotMatrix_GetColumnName_14(base.GetCppThis(), column);
		}

		// Token: 0x06011BD5 RID: 72661
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkScatterPlotMatrix_GetColumnVisibility_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Get the visibility of the specified column.
		/// </summary>
		// Token: 0x06011BD6 RID: 72662 RVA: 0x0018D000 File Offset: 0x0018B200
		public bool GetColumnVisibility(string name)
		{
			return vtkScatterPlotMatrix.vtkScatterPlotMatrix_GetColumnVisibility_15(base.GetCppThis(), name) != 0;
		}

		// Token: 0x06011BD7 RID: 72663
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScatterPlotMatrix_GetGridColor_16(HandleRef pThis, int plotType, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Sets the color for the axes given a plot type, which refers to
		/// vtkScatterPlotMatrix::{SCATTERPLOT, HISTOGRAM, ACTIVEPLOT}.
		/// </summary>
		// Token: 0x06011BD8 RID: 72664 RVA: 0x0018D028 File Offset: 0x0018B228
		public vtkColor4ub GetGridColor(int plotType)
		{
			vtkColor4ub result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScatterPlotMatrix.vtkScatterPlotMatrix_GetGridColor_16(base.GetCppThis(), plotType, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkColor4ub)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011BD9 RID: 72665
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkScatterPlotMatrix_GetGridVisibility_17(HandleRef pThis, int plotType);

		/// <summary>
		/// Sets whether or not the grid for the given axis is visible given a plot
		/// type, which refers to
		/// vtkScatterPlotMatrix::{SCATTERPLOT, HISTOGRAM, ACTIVEPLOT}.
		/// </summary>
		// Token: 0x06011BDA RID: 72666 RVA: 0x0018D084 File Offset: 0x0018B284
		public bool GetGridVisibility(int plotType)
		{
			return vtkScatterPlotMatrix.vtkScatterPlotMatrix_GetGridVisibility_17(base.GetCppThis(), plotType) != 0;
		}

		// Token: 0x06011BDB RID: 72667
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScatterPlotMatrix_GetIndexedLabels_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the indexed labels array.
		/// </summary>
		// Token: 0x06011BDC RID: 72668 RVA: 0x0018D0AC File Offset: 0x0018B2AC
		public vtkStringArray GetIndexedLabels()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScatterPlotMatrix.vtkScatterPlotMatrix_GetIndexedLabels_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06011BDD RID: 72669
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScatterPlotMatrix_GetMainChart_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the main plot (the one in the top-right of the matrix.
		/// </summary>
		// Token: 0x06011BDE RID: 72670 RVA: 0x0018D11C File Offset: 0x0018B31C
		public virtual vtkChart GetMainChart()
		{
			vtkChart vtkChart = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScatterPlotMatrix.vtkScatterPlotMatrix_GetMainChart_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06011BDF RID: 72671
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkScatterPlotMatrix_GetNumberOfAnimationPathElements_20(HandleRef pThis);

		/// <summary>
		/// Get the number of elements (transitions) in the animation path.
		/// </summary>
		// Token: 0x06011BE0 RID: 72672 RVA: 0x0018D18C File Offset: 0x0018B38C
		public long GetNumberOfAnimationPathElements()
		{
			return vtkScatterPlotMatrix.vtkScatterPlotMatrix_GetNumberOfAnimationPathElements_20(base.GetCppThis());
		}

		// Token: 0x06011BE1 RID: 72673
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScatterPlotMatrix_GetNumberOfBins_21(HandleRef pThis);

		/// <summary>
		/// Get the number of bins the histograms along the central diagonal scatter
		/// plot matrix. The default value is 10.
		/// </summary>
		// Token: 0x06011BE2 RID: 72674 RVA: 0x0018D1AC File Offset: 0x0018B3AC
		public virtual int GetNumberOfBins()
		{
			return vtkScatterPlotMatrix.vtkScatterPlotMatrix_GetNumberOfBins_21(base.GetCppThis());
		}

		// Token: 0x06011BE3 RID: 72675
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScatterPlotMatrix_GetNumberOfFrames_22(HandleRef pThis);

		/// <summary>
		/// Get the number of animation frames in each transition. Default is 25,
		/// and 0 means to animations between axes.
		/// </summary>
		// Token: 0x06011BE4 RID: 72676 RVA: 0x0018D1CC File Offset: 0x0018B3CC
		public int GetNumberOfFrames()
		{
			return vtkScatterPlotMatrix.vtkScatterPlotMatrix_GetNumberOfFrames_22(base.GetCppThis());
		}

		// Token: 0x06011BE5 RID: 72677
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkScatterPlotMatrix_GetNumberOfGenerationsFromBase_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011BE6 RID: 72678 RVA: 0x0018D1EC File Offset: 0x0018B3EC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkScatterPlotMatrix.vtkScatterPlotMatrix_GetNumberOfGenerationsFromBase_23(base.GetCppThis(), type);
		}

		// Token: 0x06011BE7 RID: 72679
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkScatterPlotMatrix_GetNumberOfGenerationsFromBaseType_24([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011BE8 RID: 72680 RVA: 0x0018D20C File Offset: 0x0018B40C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkScatterPlotMatrix.vtkScatterPlotMatrix_GetNumberOfGenerationsFromBaseType_24(type);
		}

		// Token: 0x06011BE9 RID: 72681
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScatterPlotMatrix_GetPlotType_25(HandleRef pThis, HandleRef pos);

		/// <summary>
		/// Returns the type of the plot at the given position. The return
		/// value is one of: SCATTERPLOT, HISTOGRAM, ACTIVEPLOT, or NOPLOT.
		/// </summary>
		// Token: 0x06011BEA RID: 72682 RVA: 0x0018D228 File Offset: 0x0018B428
		public int GetPlotType(vtkVector2i pos)
		{
			return vtkScatterPlotMatrix.vtkScatterPlotMatrix_GetPlotType_25(base.GetCppThis(), (pos == null) ? default(HandleRef) : pos.GetCppThis());
		}

		// Token: 0x06011BEB RID: 72683
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScatterPlotMatrix_GetPlotType_26(HandleRef pThis, int row, int column);

		/// <summary>
		/// Returns the type of the plot at the given position. The return
		/// value is one of: SCATTERPLOT, HISTOGRAM, ACTIVEPLOT, or NOPLOT.
		/// </summary>
		// Token: 0x06011BEC RID: 72684 RVA: 0x0018D25C File Offset: 0x0018B45C
		public int GetPlotType(int row, int column)
		{
			return vtkScatterPlotMatrix.vtkScatterPlotMatrix_GetPlotType_26(base.GetCppThis(), row, column);
		}

		// Token: 0x06011BED RID: 72685
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkScatterPlotMatrix_GetRowName_27(HandleRef pThis, int row);

		/// <summary>
		/// Get the column name for the supplied index.
		/// </summary>
		// Token: 0x06011BEE RID: 72686 RVA: 0x0018D280 File Offset: 0x0018B480
		public string GetRowName(int row)
		{
			return vtkScatterPlotMatrix.vtkScatterPlotMatrix_GetRowName_27(base.GetCppThis(), row);
		}

		// Token: 0x06011BEF RID: 72687
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScatterPlotMatrix_GetScatterPlotSelectedActiveColor_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the scatter plot selected active chart background color.
		/// </summary>
		// Token: 0x06011BF0 RID: 72688 RVA: 0x0018D2A0 File Offset: 0x0018B4A0
		public vtkColor4ub GetScatterPlotSelectedActiveColor()
		{
			vtkColor4ub result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScatterPlotMatrix.vtkScatterPlotMatrix_GetScatterPlotSelectedActiveColor_28(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkColor4ub)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011BF1 RID: 72689
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScatterPlotMatrix_GetScatterPlotSelectedRowColumnColor_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the scatter plot selected row/column charts' background color.
		/// </summary>
		// Token: 0x06011BF2 RID: 72690 RVA: 0x0018D2FC File Offset: 0x0018B4FC
		public vtkColor4ub GetScatterPlotSelectedRowColumnColor()
		{
			vtkColor4ub result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScatterPlotMatrix.vtkScatterPlotMatrix_GetScatterPlotSelectedRowColumnColor_29(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkColor4ub)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011BF3 RID: 72691
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScatterPlotMatrix_GetSelectionMode_30(HandleRef pThis);

		/// <summary>
		/// Set/get the Selection Mode that will be used by the chart while doing
		/// selection. The only valid enums are vtkContextScene::SELECTION_NONE,
		/// SELECTION_DEFAULT, SELECTION_ADDITION, SELECTION_SUBTRACTION, SELECTION_TOGGLE
		/// </summary>
		// Token: 0x06011BF4 RID: 72692 RVA: 0x0018D358 File Offset: 0x0018B558
		public virtual int GetSelectionMode()
		{
			return vtkScatterPlotMatrix.vtkScatterPlotMatrix_GetSelectionMode_30(base.GetCppThis());
		}

		// Token: 0x06011BF5 RID: 72693
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkScatterPlotMatrix_GetTitle_31(HandleRef pThis);

		/// <summary>
		/// Set/get the scatter plot title.
		/// </summary>
		// Token: 0x06011BF6 RID: 72694 RVA: 0x0018D378 File Offset: 0x0018B578
		public string GetTitle()
		{
			return vtkScatterPlotMatrix.vtkScatterPlotMatrix_GetTitle_31(base.GetCppThis());
		}

		// Token: 0x06011BF7 RID: 72695
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScatterPlotMatrix_GetTitleProperties_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get the text properties for the chart title, i.e. color, font, size.
		/// </summary>
		// Token: 0x06011BF8 RID: 72696 RVA: 0x0018D398 File Offset: 0x0018B598
		public vtkTextProperty GetTitleProperties()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScatterPlotMatrix.vtkScatterPlotMatrix_GetTitleProperties_32(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06011BF9 RID: 72697
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScatterPlotMatrix_GetTooltip_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the vtkTooltipItem object that will be displayed by the active chart.
		/// </summary>
		// Token: 0x06011BFA RID: 72698 RVA: 0x0018D408 File Offset: 0x0018B608
		public vtkTooltipItem GetTooltip()
		{
			vtkTooltipItem vtkTooltipItem = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScatterPlotMatrix.vtkScatterPlotMatrix_GetTooltip_33(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTooltipItem = (vtkTooltipItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTooltipItem.Register(null);
				}
			}
			return vtkTooltipItem;
		}

		// Token: 0x06011BFB RID: 72699
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScatterPlotMatrix_GetTooltipNotation_34(HandleRef pThis, int plotType);

		/// <summary>
		/// Set chart's tooltip notation and precision, given a plot type, which refers to
		/// vtkScatterPlotMatrix::{SCATTERPLOT, HISTOGRAM, ACTIVEPLOT}.
		/// </summary>
		// Token: 0x06011BFC RID: 72700 RVA: 0x0018D478 File Offset: 0x0018B678
		public int GetTooltipNotation(int plotType)
		{
			return vtkScatterPlotMatrix.vtkScatterPlotMatrix_GetTooltipNotation_34(base.GetCppThis(), plotType);
		}

		// Token: 0x06011BFD RID: 72701
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScatterPlotMatrix_GetTooltipPrecision_35(HandleRef pThis, int plotType);

		/// <summary>
		/// Set chart's tooltip notation and precision, given a plot type, which refers to
		/// vtkScatterPlotMatrix::{SCATTERPLOT, HISTOGRAM, ACTIVEPLOT}.
		/// </summary>
		// Token: 0x06011BFE RID: 72702 RVA: 0x0018D498 File Offset: 0x0018B698
		public int GetTooltipPrecision(int plotType)
		{
			return vtkScatterPlotMatrix.vtkScatterPlotMatrix_GetTooltipPrecision_35(base.GetCppThis(), plotType);
		}

		// Token: 0x06011BFF RID: 72703
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScatterPlotMatrix_GetVisibleColumns_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get a list of the columns, and the order in which they are displayed.
		/// </summary>
		// Token: 0x06011C00 RID: 72704 RVA: 0x0018D4B8 File Offset: 0x0018B6B8
		public virtual vtkStringArray GetVisibleColumns()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScatterPlotMatrix.vtkScatterPlotMatrix_GetVisibleColumns_36(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06011C01 RID: 72705
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScatterPlotMatrix_InsertVisibleColumn_37(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int index);

		/// <summary>
		/// Insert the specified column at the index position of
		/// the visible columns.
		/// </summary>
		// Token: 0x06011C02 RID: 72706 RVA: 0x0018D527 File Offset: 0x0018B727
		public void InsertVisibleColumn(string name, int index)
		{
			vtkScatterPlotMatrix.vtkScatterPlotMatrix_InsertVisibleColumn_37(base.GetCppThis(), name, index);
		}

		// Token: 0x06011C03 RID: 72707
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScatterPlotMatrix_IsA_38(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011C04 RID: 72708 RVA: 0x0018D538 File Offset: 0x0018B738
		public override int IsA(string type)
		{
			return vtkScatterPlotMatrix.vtkScatterPlotMatrix_IsA_38(base.GetCppThis(), type);
		}

		// Token: 0x06011C05 RID: 72709
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScatterPlotMatrix_IsTypeOf_39([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011C06 RID: 72710 RVA: 0x0018D558 File Offset: 0x0018B758
		public new static int IsTypeOf(string type)
		{
			return vtkScatterPlotMatrix.vtkScatterPlotMatrix_IsTypeOf_39(type);
		}

		// Token: 0x06011C07 RID: 72711
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScatterPlotMatrix_NewInstance_41(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011C08 RID: 72712 RVA: 0x0018D574 File Offset: 0x0018B774
		public new vtkScatterPlotMatrix NewInstance()
		{
			vtkScatterPlotMatrix result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScatterPlotMatrix.vtkScatterPlotMatrix_NewInstance_41(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkScatterPlotMatrix)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011C09 RID: 72713
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkScatterPlotMatrix_Paint_42(HandleRef pThis, HandleRef painter);

		/// <summary>
		/// Paint event for the chart matrix.
		/// </summary>
		// Token: 0x06011C0A RID: 72714 RVA: 0x0018D5D0 File Offset: 0x0018B7D0
		public override bool Paint(vtkContext2D painter)
		{
			return vtkScatterPlotMatrix.vtkScatterPlotMatrix_Paint_42(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		// Token: 0x06011C0B RID: 72715
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScatterPlotMatrix_SafeDownCast_43(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011C0C RID: 72716 RVA: 0x0018D60C File Offset: 0x0018B80C
		public new static vtkScatterPlotMatrix SafeDownCast(vtkObjectBase o)
		{
			vtkScatterPlotMatrix vtkScatterPlotMatrix = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScatterPlotMatrix.vtkScatterPlotMatrix_SafeDownCast_43((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScatterPlotMatrix = (vtkScatterPlotMatrix)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScatterPlotMatrix.Register(null);
				}
			}
			return vtkScatterPlotMatrix;
		}

		// Token: 0x06011C0D RID: 72717
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkScatterPlotMatrix_SetActivePlot_44(HandleRef pThis, HandleRef position);

		/// <summary>
		/// Set the active plot, the one that will be displayed in the top-right.
		/// This defaults to (0, n-2), the plot below the first histogram on the left.
		/// \return false is the position specified is not valid.
		/// </summary>
		// Token: 0x06011C0E RID: 72718 RVA: 0x0018D68C File Offset: 0x0018B88C
		public virtual bool SetActivePlot(vtkVector2i position)
		{
			return vtkScatterPlotMatrix.vtkScatterPlotMatrix_SetActivePlot_44(base.GetCppThis(), (position == null) ? default(HandleRef) : position.GetCppThis()) != 0;
		}

		// Token: 0x06011C0F RID: 72719
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScatterPlotMatrix_SetAxisColor_45(HandleRef pThis, int plotType, HandleRef color);

		/// <summary>
		/// Sets the color for the axes given a plot type, which refers to
		/// vtkScatterPlotMatrix::{SCATTERPLOT, HISTOGRAM, ACTIVEPLOT}.
		/// </summary>
		// Token: 0x06011C10 RID: 72720 RVA: 0x0018D6C8 File Offset: 0x0018B8C8
		public void SetAxisColor(int plotType, vtkColor4ub color)
		{
			vtkScatterPlotMatrix.vtkScatterPlotMatrix_SetAxisColor_45(base.GetCppThis(), plotType, (color == null) ? default(HandleRef) : color.GetCppThis());
		}

		// Token: 0x06011C11 RID: 72721
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScatterPlotMatrix_SetAxisLabelNotation_46(HandleRef pThis, int plotType, int notation);

		/// <summary>
		/// Sets the axis label notation for the axes given a plot type, which refers to
		/// vtkScatterPlotMatrix::{SCATTERPLOT, HISTOGRAM, ACTIVEPLOT}.
		/// </summary>
		// Token: 0x06011C12 RID: 72722 RVA: 0x0018D6F8 File Offset: 0x0018B8F8
		public void SetAxisLabelNotation(int plotType, int notation)
		{
			vtkScatterPlotMatrix.vtkScatterPlotMatrix_SetAxisLabelNotation_46(base.GetCppThis(), plotType, notation);
		}

		// Token: 0x06011C13 RID: 72723
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScatterPlotMatrix_SetAxisLabelPrecision_47(HandleRef pThis, int plotType, int precision);

		/// <summary>
		/// Sets the axis label precision for the axes given a plot type, which refers to
		/// vtkScatterPlotMatrix::{SCATTERPLOT, HISTOGRAM, ACTIVEPLOT}.
		/// </summary>
		// Token: 0x06011C14 RID: 72724 RVA: 0x0018D709 File Offset: 0x0018B909
		public void SetAxisLabelPrecision(int plotType, int precision)
		{
			vtkScatterPlotMatrix.vtkScatterPlotMatrix_SetAxisLabelPrecision_47(base.GetCppThis(), plotType, precision);
		}

		// Token: 0x06011C15 RID: 72725
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScatterPlotMatrix_SetAxisLabelProperties_48(HandleRef pThis, int plotType, HandleRef prop);

		/// <summary>
		/// Set/get the text property for the axis labels of the given plot type,
		/// possible types are vtkScatterPlotMatrix::{SCATTERPLOT, HISTOGRAM, ACTIVEPLOT}.
		/// </summary>
		// Token: 0x06011C16 RID: 72726 RVA: 0x0018D71C File Offset: 0x0018B91C
		public void SetAxisLabelProperties(int plotType, vtkTextProperty prop)
		{
			vtkScatterPlotMatrix.vtkScatterPlotMatrix_SetAxisLabelProperties_48(base.GetCppThis(), plotType, (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		// Token: 0x06011C17 RID: 72727
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScatterPlotMatrix_SetAxisLabelVisibility_49(HandleRef pThis, int plotType, byte visible);

		/// <summary>
		/// Sets whether or not the labels for the axes are visible, given a plot type,
		/// which refers to
		/// vtkScatterPlotMatrix::{SCATTERPLOT, HISTOGRAM, ACTIVEPLOT}.
		/// </summary>
		// Token: 0x06011C18 RID: 72728 RVA: 0x0018D74C File Offset: 0x0018B94C
		public void SetAxisLabelVisibility(int plotType, bool visible)
		{
			vtkScatterPlotMatrix.vtkScatterPlotMatrix_SetAxisLabelVisibility_49(base.GetCppThis(), plotType, visible ? (byte)1 : (byte)0);
		}

		// Token: 0x06011C19 RID: 72729
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScatterPlotMatrix_SetBackgroundColor_50(HandleRef pThis, int plotType, HandleRef color);

		/// <summary>
		/// Sets the background color for the chart given a plot type, which refers to
		/// vtkScatterPlotMatrix::{SCATTERPLOT, HISTOGRAM, ACTIVEPLOT}.
		/// </summary>
		// Token: 0x06011C1A RID: 72730 RVA: 0x0018D768 File Offset: 0x0018B968
		public void SetBackgroundColor(int plotType, vtkColor4ub color)
		{
			vtkScatterPlotMatrix.vtkScatterPlotMatrix_SetBackgroundColor_50(base.GetCppThis(), plotType, (color == null) ? default(HandleRef) : color.GetCppThis());
		}

		// Token: 0x06011C1B RID: 72731
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScatterPlotMatrix_SetColumnVisibility_51(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, byte visible);

		/// <summary>
		/// Set the visibility of the specified column.
		/// </summary>
		// Token: 0x06011C1C RID: 72732 RVA: 0x0018D798 File Offset: 0x0018B998
		public void SetColumnVisibility(string name, bool visible)
		{
			vtkScatterPlotMatrix.vtkScatterPlotMatrix_SetColumnVisibility_51(base.GetCppThis(), name, visible ? (byte)1 : (byte)0);
		}

		// Token: 0x06011C1D RID: 72733
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScatterPlotMatrix_SetColumnVisibilityAll_52(HandleRef pThis, byte visible);

		/// <summary>
		/// Set the visibility of all columns (true will make them all visible, false
		/// will remove all visible columns).
		/// </summary>
		// Token: 0x06011C1E RID: 72734 RVA: 0x0018D7B1 File Offset: 0x0018B9B1
		public void SetColumnVisibilityAll(bool visible)
		{
			vtkScatterPlotMatrix.vtkScatterPlotMatrix_SetColumnVisibilityAll_52(base.GetCppThis(), visible ? (byte)1 : (byte)0);
		}

		// Token: 0x06011C1F RID: 72735
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScatterPlotMatrix_SetGridColor_53(HandleRef pThis, int plotType, HandleRef color);

		/// <summary>
		/// Sets the color for the axes given a plot type, which refers to
		/// vtkScatterPlotMatrix::{SCATTERPLOT, HISTOGRAM, ACTIVEPLOT}.
		/// </summary>
		// Token: 0x06011C20 RID: 72736 RVA: 0x0018D7CC File Offset: 0x0018B9CC
		public void SetGridColor(int plotType, vtkColor4ub color)
		{
			vtkScatterPlotMatrix.vtkScatterPlotMatrix_SetGridColor_53(base.GetCppThis(), plotType, (color == null) ? default(HandleRef) : color.GetCppThis());
		}

		// Token: 0x06011C21 RID: 72737
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScatterPlotMatrix_SetGridVisibility_54(HandleRef pThis, int plotType, byte visible);

		/// <summary>
		/// Sets whether or not the grid for the given axis is visible given a plot
		/// type, which refers to
		/// vtkScatterPlotMatrix::{SCATTERPLOT, HISTOGRAM, ACTIVEPLOT}.
		/// </summary>
		// Token: 0x06011C22 RID: 72738 RVA: 0x0018D7FC File Offset: 0x0018B9FC
		public void SetGridVisibility(int plotType, bool visible)
		{
			vtkScatterPlotMatrix.vtkScatterPlotMatrix_SetGridVisibility_54(base.GetCppThis(), plotType, visible ? (byte)1 : (byte)0);
		}

		// Token: 0x06011C23 RID: 72739
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScatterPlotMatrix_SetIndexedLabels_55(HandleRef pThis, HandleRef labels);

		/// <summary>
		/// Set indexed labels array.
		/// </summary>
		// Token: 0x06011C24 RID: 72740 RVA: 0x0018D818 File Offset: 0x0018BA18
		public void SetIndexedLabels(vtkStringArray labels)
		{
			vtkScatterPlotMatrix.vtkScatterPlotMatrix_SetIndexedLabels_55(base.GetCppThis(), (labels == null) ? default(HandleRef) : labels.GetCppThis());
		}

		// Token: 0x06011C25 RID: 72741
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScatterPlotMatrix_SetInput_56(HandleRef pThis, HandleRef table);

		/// <summary>
		/// Set the input table for the scatter plot matrix. This will cause all
		/// columns to be plotted against each other - a square scatter plot matrix.
		/// </summary>
		// Token: 0x06011C26 RID: 72742 RVA: 0x0018D848 File Offset: 0x0018BA48
		public virtual void SetInput(vtkTable table)
		{
			vtkScatterPlotMatrix.vtkScatterPlotMatrix_SetInput_56(base.GetCppThis(), (table == null) ? default(HandleRef) : table.GetCppThis());
		}

		// Token: 0x06011C27 RID: 72743
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScatterPlotMatrix_SetNumberOfBins_57(HandleRef pThis, int numberOfBins);

		/// <summary>
		/// Set the number of bins in the histograms along the central diagonal of the
		/// scatter plot matrix.
		/// </summary>
		// Token: 0x06011C28 RID: 72744 RVA: 0x0018D877 File Offset: 0x0018BA77
		public virtual void SetNumberOfBins(int numberOfBins)
		{
			vtkScatterPlotMatrix.vtkScatterPlotMatrix_SetNumberOfBins_57(base.GetCppThis(), numberOfBins);
		}

		// Token: 0x06011C29 RID: 72745
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScatterPlotMatrix_SetNumberOfFrames_58(HandleRef pThis, int frames);

		/// <summary>
		/// Set the number of animation frames in each transition. Default is 25,
		/// and 0 means to animations between axes.
		/// </summary>
		// Token: 0x06011C2A RID: 72746 RVA: 0x0018D887 File Offset: 0x0018BA87
		public void SetNumberOfFrames(int frames)
		{
			vtkScatterPlotMatrix.vtkScatterPlotMatrix_SetNumberOfFrames_58(base.GetCppThis(), frames);
		}

		// Token: 0x06011C2B RID: 72747
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScatterPlotMatrix_SetPlotColor_59(HandleRef pThis, int plotType, HandleRef color);

		/// <summary>
		/// Set the color for the specified plotType.
		/// </summary>
		// Token: 0x06011C2C RID: 72748 RVA: 0x0018D898 File Offset: 0x0018BA98
		public void SetPlotColor(int plotType, vtkColor4ub color)
		{
			vtkScatterPlotMatrix.vtkScatterPlotMatrix_SetPlotColor_59(base.GetCppThis(), plotType, (color == null) ? default(HandleRef) : color.GetCppThis());
		}

		// Token: 0x06011C2D RID: 72749
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScatterPlotMatrix_SetPlotMarkerSize_60(HandleRef pThis, int plotType, float size);

		/// <summary>
		/// Sets the marker size for the specified plotType.
		/// </summary>
		// Token: 0x06011C2E RID: 72750 RVA: 0x0018D8C8 File Offset: 0x0018BAC8
		public void SetPlotMarkerSize(int plotType, float size)
		{
			vtkScatterPlotMatrix.vtkScatterPlotMatrix_SetPlotMarkerSize_60(base.GetCppThis(), plotType, size);
		}

		// Token: 0x06011C2F RID: 72751
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScatterPlotMatrix_SetPlotMarkerStyle_61(HandleRef pThis, int plotType, int style);

		/// <summary>
		/// Sets the marker style for the specified plotType.
		/// </summary>
		// Token: 0x06011C30 RID: 72752 RVA: 0x0018D8D9 File Offset: 0x0018BAD9
		public void SetPlotMarkerStyle(int plotType, int style)
		{
			vtkScatterPlotMatrix.vtkScatterPlotMatrix_SetPlotMarkerStyle_61(base.GetCppThis(), plotType, style);
		}

		// Token: 0x06011C31 RID: 72753
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScatterPlotMatrix_SetScatterPlotSelectedActiveColor_62(HandleRef pThis, HandleRef color);

		/// <summary>
		/// Set the scatter plot selected active chart background color.
		/// </summary>
		// Token: 0x06011C32 RID: 72754 RVA: 0x0018D8EC File Offset: 0x0018BAEC
		public void SetScatterPlotSelectedActiveColor(vtkColor4ub color)
		{
			vtkScatterPlotMatrix.vtkScatterPlotMatrix_SetScatterPlotSelectedActiveColor_62(base.GetCppThis(), (color == null) ? default(HandleRef) : color.GetCppThis());
		}

		// Token: 0x06011C33 RID: 72755
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScatterPlotMatrix_SetScatterPlotSelectedRowColumnColor_63(HandleRef pThis, HandleRef color);

		/// <summary>
		/// Set the scatter plot selected row/column charts' background color.
		/// </summary>
		// Token: 0x06011C34 RID: 72756 RVA: 0x0018D91C File Offset: 0x0018BB1C
		public void SetScatterPlotSelectedRowColumnColor(vtkColor4ub color)
		{
			vtkScatterPlotMatrix.vtkScatterPlotMatrix_SetScatterPlotSelectedRowColumnColor_63(base.GetCppThis(), (color == null) ? default(HandleRef) : color.GetCppThis());
		}

		// Token: 0x06011C35 RID: 72757
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScatterPlotMatrix_SetScene_64(HandleRef pThis, HandleRef scene);

		/// <summary>
		/// Paint event for the chart matrix.
		/// </summary>
		// Token: 0x06011C36 RID: 72758 RVA: 0x0018D94C File Offset: 0x0018BB4C
		public override void SetScene(vtkContextScene scene)
		{
			vtkScatterPlotMatrix.vtkScatterPlotMatrix_SetScene_64(base.GetCppThis(), (scene == null) ? default(HandleRef) : scene.GetCppThis());
		}

		// Token: 0x06011C37 RID: 72759
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScatterPlotMatrix_SetSelectionMode_65(HandleRef pThis, int arg0);

		/// <summary>
		/// Set/get the Selection Mode that will be used by the chart while doing
		/// selection. The only valid enums are vtkContextScene::SELECTION_NONE,
		/// SELECTION_DEFAULT, SELECTION_ADDITION, SELECTION_SUBTRACTION, SELECTION_TOGGLE
		/// </summary>
		// Token: 0x06011C38 RID: 72760 RVA: 0x0018D97B File Offset: 0x0018BB7B
		public virtual void SetSelectionMode(int arg0)
		{
			vtkScatterPlotMatrix.vtkScatterPlotMatrix_SetSelectionMode_65(base.GetCppThis(), arg0);
		}

		// Token: 0x06011C39 RID: 72761
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScatterPlotMatrix_SetSize_66(HandleRef pThis, HandleRef size);

		/// <summary>
		/// Reset ActivePlotSet flag and call superclass method
		/// </summary>
		// Token: 0x06011C3A RID: 72762 RVA: 0x0018D98C File Offset: 0x0018BB8C
		public override void SetSize(vtkVector2i size)
		{
			vtkScatterPlotMatrix.vtkScatterPlotMatrix_SetSize_66(base.GetCppThis(), (size == null) ? default(HandleRef) : size.GetCppThis());
		}

		// Token: 0x06011C3B RID: 72763
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScatterPlotMatrix_SetTitle_67(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string title);

		/// <summary>
		/// Set/get the scatter plot title.
		/// </summary>
		// Token: 0x06011C3C RID: 72764 RVA: 0x0018D9BB File Offset: 0x0018BBBB
		public void SetTitle(string title)
		{
			vtkScatterPlotMatrix.vtkScatterPlotMatrix_SetTitle_67(base.GetCppThis(), title);
		}

		// Token: 0x06011C3D RID: 72765
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScatterPlotMatrix_SetTitleProperties_68(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Set/get the text properties for the chart title, i.e. color, font, size.
		/// </summary>
		// Token: 0x06011C3E RID: 72766 RVA: 0x0018D9CC File Offset: 0x0018BBCC
		public void SetTitleProperties(vtkTextProperty prop)
		{
			vtkScatterPlotMatrix.vtkScatterPlotMatrix_SetTitleProperties_68(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		// Token: 0x06011C3F RID: 72767
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScatterPlotMatrix_SetTooltip_69(HandleRef pThis, HandleRef tooltip);

		/// <summary>
		/// Set the vtkTooltipItem object that will be displayed by the active chart.
		/// </summary>
		// Token: 0x06011C40 RID: 72768 RVA: 0x0018D9FC File Offset: 0x0018BBFC
		public void SetTooltip(vtkTooltipItem tooltip)
		{
			vtkScatterPlotMatrix.vtkScatterPlotMatrix_SetTooltip_69(base.GetCppThis(), (tooltip == null) ? default(HandleRef) : tooltip.GetCppThis());
		}

		// Token: 0x06011C41 RID: 72769
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScatterPlotMatrix_SetTooltipNotation_70(HandleRef pThis, int plotType, int notation);

		/// <summary>
		/// Set chart's tooltip notation and precision, given a plot type, which refers to
		/// vtkScatterPlotMatrix::{SCATTERPLOT, HISTOGRAM, ACTIVEPLOT}.
		/// </summary>
		// Token: 0x06011C42 RID: 72770 RVA: 0x0018DA2B File Offset: 0x0018BC2B
		public void SetTooltipNotation(int plotType, int notation)
		{
			vtkScatterPlotMatrix.vtkScatterPlotMatrix_SetTooltipNotation_70(base.GetCppThis(), plotType, notation);
		}

		// Token: 0x06011C43 RID: 72771
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScatterPlotMatrix_SetTooltipPrecision_71(HandleRef pThis, int plotType, int precision);

		/// <summary>
		/// Set chart's tooltip notation and precision, given a plot type, which refers to
		/// vtkScatterPlotMatrix::{SCATTERPLOT, HISTOGRAM, ACTIVEPLOT}.
		/// </summary>
		// Token: 0x06011C44 RID: 72772 RVA: 0x0018DA3C File Offset: 0x0018BC3C
		public void SetTooltipPrecision(int plotType, int precision)
		{
			vtkScatterPlotMatrix.vtkScatterPlotMatrix_SetTooltipPrecision_71(base.GetCppThis(), plotType, precision);
		}

		// Token: 0x06011C45 RID: 72773
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScatterPlotMatrix_SetVisibleColumns_72(HandleRef pThis, HandleRef visColumns);

		/// <summary>
		/// Set the list of visible columns, and the order in which they will be displayed.
		/// </summary>
		// Token: 0x06011C46 RID: 72774 RVA: 0x0018DA50 File Offset: 0x0018BC50
		public virtual void SetVisibleColumns(vtkStringArray visColumns)
		{
			vtkScatterPlotMatrix.vtkScatterPlotMatrix_SetVisibleColumns_72(base.GetCppThis(), (visColumns == null) ? default(HandleRef) : visColumns.GetCppThis());
		}

		// Token: 0x06011C47 RID: 72775
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScatterPlotMatrix_Update_73(HandleRef pThis);

		/// <summary>
		/// Perform any updates to the item that may be necessary before rendering.
		/// </summary>
		// Token: 0x06011C48 RID: 72776 RVA: 0x0018DA7F File Offset: 0x0018BC7F
		public override void Update()
		{
			vtkScatterPlotMatrix.vtkScatterPlotMatrix_Update_73(base.GetCppThis());
		}

		// Token: 0x06011C49 RID: 72777
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScatterPlotMatrix_UpdateChartSettings_74(HandleRef pThis, int plotType);

		/// <summary>
		/// Update charts based on settings given the plot type
		/// </summary>
		// Token: 0x06011C4A RID: 72778 RVA: 0x0018DA8E File Offset: 0x0018BC8E
		public void UpdateChartSettings(int plotType)
		{
			vtkScatterPlotMatrix.vtkScatterPlotMatrix_UpdateChartSettings_74(base.GetCppThis(), plotType);
		}

		// Token: 0x06011C4B RID: 72779
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScatterPlotMatrix_UpdateSettings_75(HandleRef pThis);

		/// <summary>
		/// Convenient method to update all the chart settings
		/// </summary>
		// Token: 0x06011C4C RID: 72780 RVA: 0x0018DA9E File Offset: 0x0018BC9E
		public void UpdateSettings()
		{
			vtkScatterPlotMatrix.vtkScatterPlotMatrix_UpdateSettings_75(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001471 RID: 5233
		public new const string MRFullTypeName = "Kitware.VTK.vtkScatterPlotMatrix";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001472 RID: 5234
		public new static readonly string MRClassNameKey = "class vtkScatterPlotMatrix";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0200066D RID: 1645
		public enum ACTIVEPLOT_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04001474 RID: 5236
			ACTIVEPLOT = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001475 RID: 5237
			HISTOGRAM = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001476 RID: 5238
			NOPLOT = 3,
			/// <summary>enum member</summary>
			// Token: 0x04001477 RID: 5239
			SCATTERPLOT = 0
		}
	}
}
