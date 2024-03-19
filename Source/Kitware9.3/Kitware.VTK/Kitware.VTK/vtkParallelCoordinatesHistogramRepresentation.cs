using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkParallelCoordinatesHistogramRepresentation
	/// </summary>
	/// <remarks>
	///    Data representation
	///  that takes generic multivariate data and produces a parallel coordinates plot.
	///  This plot optionally can draw a histogram-based plot summary.
	///
	///
	///  A parallel coordinates plot represents each variable in a multivariate
	///  data set as a separate axis.  Individual samples of that data set are
	///  represented as a polyline that pass through each variable axis at
	///  positions that correspond to data values.  This class can generate
	///  parallel coordinates plots identical to its superclass
	///  (vtkParallelCoordinatesRepresentation) and has the same interaction
	///  styles.
	///
	///  In addition to the standard parallel coordinates plot, this class also
	///  can draw a histogram summary of the parallel coordinates plot.
	///  Rather than draw every row in an input data set, first it computes
	///  a 2D histogram for all neighboring variable axes, then it draws
	///  bar (thickness corresponds to bin size) for each bin the histogram
	///  with opacity weighted by the number of rows contained in the bin.
	///  The result is essentially a density map.
	///
	///  Because this emphasizes dense regions over sparse outliers, this class
	///  also uses a vtkComputeHistogram2DOutliers instance to identify outlier
	///  table rows and draws those as standard parallel coordinates lines.
	///
	/// </remarks>
	/// <seealso>
	///
	///  vtkParallelCoordinatesView vtkParallelCoordinatesRepresentation
	///  vtkExtractHistogram2D vtkComputeHistogram2DOutliers
	///
	/// @par Thanks:
	///  Developed by David Feng at Sandia National Laboratories
	/// </seealso>
	// Token: 0x0200007C RID: 124
	public class vtkParallelCoordinatesHistogramRepresentation : vtkParallelCoordinatesRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06001732 RID: 5938 RVA: 0x000268E7 File Offset: 0x00024AE7
		static vtkParallelCoordinatesHistogramRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParallelCoordinatesHistogramRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParallelCoordinatesHistogramRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06001733 RID: 5939 RVA: 0x0002690F File Offset: 0x00024B0F
		public vtkParallelCoordinatesHistogramRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06001734 RID: 5940
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelCoordinatesHistogramRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001735 RID: 5941 RVA: 0x00026920 File Offset: 0x00024B20
		public new static vtkParallelCoordinatesHistogramRepresentation New()
		{
			vtkParallelCoordinatesHistogramRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParallelCoordinatesHistogramRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001736 RID: 5942 RVA: 0x00026974 File Offset: 0x00024B74
		public vtkParallelCoordinatesHistogramRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06001737 RID: 5943 RVA: 0x000269B8 File Offset: 0x00024BB8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06001738 RID: 5944
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesHistogramRepresentation_ApplyViewTheme_01(HandleRef pThis, HandleRef theme);

		/// <summary>
		/// Apply the theme to this view.
		/// </summary>
		// Token: 0x06001739 RID: 5945 RVA: 0x000269C4 File Offset: 0x00024BC4
		public override void ApplyViewTheme(vtkViewTheme theme)
		{
			vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_ApplyViewTheme_01(base.GetCppThis(), (theme == null) ? default(HandleRef) : theme.GetCppThis());
		}

		// Token: 0x0600173A RID: 5946
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelCoordinatesHistogramRepresentation_GetHistogramLookupTableRange_02(HandleRef pThis);

		/// <summary>
		/// Control over the range of the lookup table used to draw the histogram quads.
		/// </summary>
		// Token: 0x0600173B RID: 5947 RVA: 0x000269F4 File Offset: 0x00024BF4
		public virtual double[] GetHistogramLookupTableRange()
		{
			IntPtr intPtr = vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_GetHistogramLookupTableRange_02(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600173C RID: 5948
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesHistogramRepresentation_GetHistogramLookupTableRange_03(HandleRef pThis, ref double _arg1, ref double _arg2);

		/// <summary>
		/// Control over the range of the lookup table used to draw the histogram quads.
		/// </summary>
		// Token: 0x0600173D RID: 5949 RVA: 0x00026A3C File Offset: 0x00024C3C
		public virtual void GetHistogramLookupTableRange(ref double _arg1, ref double _arg2)
		{
			vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_GetHistogramLookupTableRange_03(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x0600173E RID: 5950
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesHistogramRepresentation_GetHistogramLookupTableRange_04(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Control over the range of the lookup table used to draw the histogram quads.
		/// </summary>
		// Token: 0x0600173F RID: 5951 RVA: 0x00026A4D File Offset: 0x00024C4D
		public virtual void GetHistogramLookupTableRange(IntPtr _arg)
		{
			vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_GetHistogramLookupTableRange_04(base.GetCppThis(), _arg);
		}

		// Token: 0x06001740 RID: 5952
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParallelCoordinatesHistogramRepresentation_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001741 RID: 5953 RVA: 0x00026A60 File Offset: 0x00024C60
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06001742 RID: 5954
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParallelCoordinatesHistogramRepresentation_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001743 RID: 5955 RVA: 0x00026A80 File Offset: 0x00024C80
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06001744 RID: 5956
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelCoordinatesHistogramRepresentation_GetNumberOfHistogramBins_07(HandleRef pThis);

		/// <summary>
		/// The number of histogram bins on either side of each pair of axes.
		/// </summary>
		// Token: 0x06001745 RID: 5957 RVA: 0x00026A9C File Offset: 0x00024C9C
		public virtual int[] GetNumberOfHistogramBins()
		{
			IntPtr intPtr = vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_GetNumberOfHistogramBins_07(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06001746 RID: 5958
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesHistogramRepresentation_GetNumberOfHistogramBins_08(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// The number of histogram bins on either side of each pair of axes.
		/// </summary>
		// Token: 0x06001747 RID: 5959 RVA: 0x00026AE4 File Offset: 0x00024CE4
		public virtual void GetNumberOfHistogramBins(ref int _arg1, ref int _arg2)
		{
			vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_GetNumberOfHistogramBins_08(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06001748 RID: 5960
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesHistogramRepresentation_GetNumberOfHistogramBins_09(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// The number of histogram bins on either side of each pair of axes.
		/// </summary>
		// Token: 0x06001749 RID: 5961 RVA: 0x00026AF5 File Offset: 0x00024CF5
		public virtual void GetNumberOfHistogramBins(IntPtr _arg)
		{
			vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_GetNumberOfHistogramBins_09(base.GetCppThis(), _arg);
		}

		// Token: 0x0600174A RID: 5962
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelCoordinatesHistogramRepresentation_GetPreferredNumberOfOutliers_10(HandleRef pThis);

		/// <summary>
		/// Target maximum number of outliers to be drawn, although not guaranteed.
		/// </summary>
		// Token: 0x0600174B RID: 5963 RVA: 0x00026B08 File Offset: 0x00024D08
		public virtual int GetPreferredNumberOfOutliers()
		{
			return vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_GetPreferredNumberOfOutliers_10(base.GetCppThis());
		}

		// Token: 0x0600174C RID: 5964
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelCoordinatesHistogramRepresentation_GetShowOutliers_11(HandleRef pThis);

		/// <summary>
		/// Whether to compute and show outlier lines
		/// </summary>
		// Token: 0x0600174D RID: 5965 RVA: 0x00026B28 File Offset: 0x00024D28
		public virtual int GetShowOutliers()
		{
			return vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_GetShowOutliers_11(base.GetCppThis());
		}

		// Token: 0x0600174E RID: 5966
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelCoordinatesHistogramRepresentation_GetUseHistograms_12(HandleRef pThis);

		/// <summary>
		/// Whether to use the histogram rendering mode or the superclass's line rendering mode
		/// </summary>
		// Token: 0x0600174F RID: 5967 RVA: 0x00026B48 File Offset: 0x00024D48
		public virtual int GetUseHistograms()
		{
			return vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_GetUseHistograms_12(base.GetCppThis());
		}

		// Token: 0x06001750 RID: 5968
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelCoordinatesHistogramRepresentation_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001751 RID: 5969 RVA: 0x00026B68 File Offset: 0x00024D68
		public override int IsA(string type)
		{
			return vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_IsA_13(base.GetCppThis(), type);
		}

		// Token: 0x06001752 RID: 5970
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelCoordinatesHistogramRepresentation_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001753 RID: 5971 RVA: 0x00026B88 File Offset: 0x00024D88
		public new static int IsTypeOf(string type)
		{
			return vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_IsTypeOf_14(type);
		}

		// Token: 0x06001754 RID: 5972
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelCoordinatesHistogramRepresentation_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001755 RID: 5973 RVA: 0x00026BA4 File Offset: 0x00024DA4
		public new vtkParallelCoordinatesHistogramRepresentation NewInstance()
		{
			vtkParallelCoordinatesHistogramRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParallelCoordinatesHistogramRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06001756 RID: 5974
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelCoordinatesHistogramRepresentation_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001757 RID: 5975 RVA: 0x00026C00 File Offset: 0x00024E00
		public new static vtkParallelCoordinatesHistogramRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkParallelCoordinatesHistogramRepresentation vtkParallelCoordinatesHistogramRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParallelCoordinatesHistogramRepresentation = (vtkParallelCoordinatesHistogramRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParallelCoordinatesHistogramRepresentation.Register(null);
				}
			}
			return vtkParallelCoordinatesHistogramRepresentation;
		}

		// Token: 0x06001758 RID: 5976
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesHistogramRepresentation_SetHistogramLookupTableRange_18(HandleRef pThis, double _arg1, double _arg2);

		/// <summary>
		/// Control over the range of the lookup table used to draw the histogram quads.
		/// </summary>
		// Token: 0x06001759 RID: 5977 RVA: 0x00026C7F File Offset: 0x00024E7F
		public virtual void SetHistogramLookupTableRange(double _arg1, double _arg2)
		{
			vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_SetHistogramLookupTableRange_18(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600175A RID: 5978
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesHistogramRepresentation_SetHistogramLookupTableRange_19(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Control over the range of the lookup table used to draw the histogram quads.
		/// </summary>
		// Token: 0x0600175B RID: 5979 RVA: 0x00026C90 File Offset: 0x00024E90
		public void SetHistogramLookupTableRange(IntPtr _arg)
		{
			vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_SetHistogramLookupTableRange_19(base.GetCppThis(), _arg);
		}

		// Token: 0x0600175C RID: 5980
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesHistogramRepresentation_SetNumberOfHistogramBins_20(HandleRef pThis, int arg0, int arg1);

		/// <summary>
		/// The number of histogram bins on either side of each pair of axes.
		/// </summary>
		// Token: 0x0600175D RID: 5981 RVA: 0x00026CA0 File Offset: 0x00024EA0
		public void SetNumberOfHistogramBins(int arg0, int arg1)
		{
			vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_SetNumberOfHistogramBins_20(base.GetCppThis(), arg0, arg1);
		}

		// Token: 0x0600175E RID: 5982
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesHistogramRepresentation_SetNumberOfHistogramBins_21(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// The number of histogram bins on either side of each pair of axes.
		/// </summary>
		// Token: 0x0600175F RID: 5983 RVA: 0x00026CB1 File Offset: 0x00024EB1
		public void SetNumberOfHistogramBins(IntPtr arg0)
		{
			vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_SetNumberOfHistogramBins_21(base.GetCppThis(), arg0);
		}

		// Token: 0x06001760 RID: 5984
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesHistogramRepresentation_SetPreferredNumberOfOutliers_22(HandleRef pThis, int arg0);

		/// <summary>
		/// Target maximum number of outliers to be drawn, although not guaranteed.
		/// </summary>
		// Token: 0x06001761 RID: 5985 RVA: 0x00026CC1 File Offset: 0x00024EC1
		public void SetPreferredNumberOfOutliers(int arg0)
		{
			vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_SetPreferredNumberOfOutliers_22(base.GetCppThis(), arg0);
		}

		// Token: 0x06001762 RID: 5986
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelCoordinatesHistogramRepresentation_SetRangeAtPosition_23(HandleRef pThis, int position, IntPtr range);

		/// <summary>
		/// Calls the superclass method, and assures that only the two histograms
		/// affect by this call get recomputed.
		/// </summary>
		// Token: 0x06001763 RID: 5987 RVA: 0x00026CD4 File Offset: 0x00024ED4
		public override int SetRangeAtPosition(int position, IntPtr range)
		{
			return vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_SetRangeAtPosition_23(base.GetCppThis(), position, range);
		}

		// Token: 0x06001764 RID: 5988
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesHistogramRepresentation_SetShowOutliers_24(HandleRef pThis, int arg0);

		/// <summary>
		/// Whether to compute and show outlier lines
		/// </summary>
		// Token: 0x06001765 RID: 5989 RVA: 0x00026CF5 File Offset: 0x00024EF5
		public virtual void SetShowOutliers(int arg0)
		{
			vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_SetShowOutliers_24(base.GetCppThis(), arg0);
		}

		// Token: 0x06001766 RID: 5990
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesHistogramRepresentation_SetUseHistograms_25(HandleRef pThis, int arg0);

		/// <summary>
		/// Whether to use the histogram rendering mode or the superclass's line rendering mode
		/// </summary>
		// Token: 0x06001767 RID: 5991 RVA: 0x00026D05 File Offset: 0x00024F05
		public virtual void SetUseHistograms(int arg0)
		{
			vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_SetUseHistograms_25(base.GetCppThis(), arg0);
		}

		// Token: 0x06001768 RID: 5992
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesHistogramRepresentation_ShowOutliersOff_26(HandleRef pThis);

		/// <summary>
		/// Whether to compute and show outlier lines
		/// </summary>
		// Token: 0x06001769 RID: 5993 RVA: 0x00026D15 File Offset: 0x00024F15
		public virtual void ShowOutliersOff()
		{
			vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_ShowOutliersOff_26(base.GetCppThis());
		}

		// Token: 0x0600176A RID: 5994
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesHistogramRepresentation_ShowOutliersOn_27(HandleRef pThis);

		/// <summary>
		/// Whether to compute and show outlier lines
		/// </summary>
		// Token: 0x0600176B RID: 5995 RVA: 0x00026D24 File Offset: 0x00024F24
		public virtual void ShowOutliersOn()
		{
			vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_ShowOutliersOn_27(base.GetCppThis());
		}

		// Token: 0x0600176C RID: 5996
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelCoordinatesHistogramRepresentation_SwapAxisPositions_28(HandleRef pThis, int position1, int position2);

		/// <summary>
		/// Calls superclass swap, and assures that only histograms affected by the
		/// swap get recomputed.
		/// </summary>
		// Token: 0x0600176D RID: 5997 RVA: 0x00026D34 File Offset: 0x00024F34
		public override int SwapAxisPositions(int position1, int position2)
		{
			return vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_SwapAxisPositions_28(base.GetCppThis(), position1, position2);
		}

		// Token: 0x0600176E RID: 5998
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesHistogramRepresentation_UseHistogramsOff_29(HandleRef pThis);

		/// <summary>
		/// Whether to use the histogram rendering mode or the superclass's line rendering mode
		/// </summary>
		// Token: 0x0600176F RID: 5999 RVA: 0x00026D55 File Offset: 0x00024F55
		public virtual void UseHistogramsOff()
		{
			vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_UseHistogramsOff_29(base.GetCppThis());
		}

		// Token: 0x06001770 RID: 6000
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesHistogramRepresentation_UseHistogramsOn_30(HandleRef pThis);

		/// <summary>
		/// Whether to use the histogram rendering mode or the superclass's line rendering mode
		/// </summary>
		// Token: 0x06001771 RID: 6001 RVA: 0x00026D64 File Offset: 0x00024F64
		public virtual void UseHistogramsOn()
		{
			vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_UseHistogramsOn_30(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400048C RID: 1164
		public new const string MRFullTypeName = "Kitware.VTK.vtkParallelCoordinatesHistogramRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400048D RID: 1165
		public new static readonly string MRClassNameKey = "class vtkParallelCoordinatesHistogramRepresentation";
	}
}
