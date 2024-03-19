using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkStatisticalOutlierRemoval
	/// </summary>
	/// <remarks>
	///    remove sparse outlier points
	///
	///
	/// The vtkStatisticalOutlierRemoval filter removes sparse outlier points
	/// through statistical analysis. The average (mean) distance between points
	/// in the point cloud is computed (taking a local sample size around each
	/// point); followed by computation of the global standard deviation of
	/// distances between points. This global, statistical information is compared
	/// against the mean separation distance for each point; those points whose
	/// average separation is greater than the user-specified variation in
	/// a multiple of standard deviation are removed.
	///
	/// Note that while any vtkPointSet type can be provided as input, the output is
	/// represented by an explicit representation of points via a
	/// vtkPolyData. This output polydata will populate its instance of vtkPoints,
	/// but no cells will be defined (i.e., no vtkVertex or vtkPolyVertex are
	/// contained in the output). Also, after filter execution, the user can
	/// request a vtkIdType* map which indicates how the input points were mapped
	/// to the output. A value of map[i] (where i is the ith input point) less
	/// than 0 means that the ith input point was removed. (See also the
	/// superclass documentation for accessing the removed points through the
	/// filter's second output.)
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPointCloudFilter vtkRadiusOutlierRemoval vtkExtractPoints
	/// vtkThresholdPoints
	/// </seealso>
	// Token: 0x02000464 RID: 1124
	public class vtkStatisticalOutlierRemoval : vtkPointCloudFilter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D0BC RID: 53436 RVA: 0x00122526 File Offset: 0x00120726
		static vtkStatisticalOutlierRemoval()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStatisticalOutlierRemoval.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStatisticalOutlierRemoval"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D0BD RID: 53437 RVA: 0x0012254E File Offset: 0x0012074E
		public vtkStatisticalOutlierRemoval(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600D0BE RID: 53438
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStatisticalOutlierRemoval_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600D0BF RID: 53439 RVA: 0x0012255C File Offset: 0x0012075C
		public new static vtkStatisticalOutlierRemoval New()
		{
			vtkStatisticalOutlierRemoval result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStatisticalOutlierRemoval.vtkStatisticalOutlierRemoval_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStatisticalOutlierRemoval)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600D0C0 RID: 53440 RVA: 0x001225B0 File Offset: 0x001207B0
		public vtkStatisticalOutlierRemoval() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkStatisticalOutlierRemoval.vtkStatisticalOutlierRemoval_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D0C1 RID: 53441 RVA: 0x001225F4 File Offset: 0x001207F4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D0C2 RID: 53442
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkStatisticalOutlierRemoval_GetComputedMean_01(HandleRef pThis);

		/// <summary>
		/// After execution, return the value of the computed mean. Before execution
		/// the value returned is invalid.
		/// </summary>
		// Token: 0x0600D0C3 RID: 53443 RVA: 0x00122600 File Offset: 0x00120800
		public virtual double GetComputedMean()
		{
			return vtkStatisticalOutlierRemoval.vtkStatisticalOutlierRemoval_GetComputedMean_01(base.GetCppThis());
		}

		// Token: 0x0600D0C4 RID: 53444
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkStatisticalOutlierRemoval_GetComputedMeanMaxValue_02(HandleRef pThis);

		/// <summary>
		/// After execution, return the value of the computed mean. Before execution
		/// the value returned is invalid.
		/// </summary>
		// Token: 0x0600D0C5 RID: 53445 RVA: 0x00122620 File Offset: 0x00120820
		public virtual double GetComputedMeanMaxValue()
		{
			return vtkStatisticalOutlierRemoval.vtkStatisticalOutlierRemoval_GetComputedMeanMaxValue_02(base.GetCppThis());
		}

		// Token: 0x0600D0C6 RID: 53446
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkStatisticalOutlierRemoval_GetComputedMeanMinValue_03(HandleRef pThis);

		/// <summary>
		/// After execution, return the value of the computed mean. Before execution
		/// the value returned is invalid.
		/// </summary>
		// Token: 0x0600D0C7 RID: 53447 RVA: 0x00122640 File Offset: 0x00120840
		public virtual double GetComputedMeanMinValue()
		{
			return vtkStatisticalOutlierRemoval.vtkStatisticalOutlierRemoval_GetComputedMeanMinValue_03(base.GetCppThis());
		}

		// Token: 0x0600D0C8 RID: 53448
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkStatisticalOutlierRemoval_GetComputedStandardDeviation_04(HandleRef pThis);

		/// <summary>
		/// After execution, return the value of the computed sigma (standard
		/// deviation). Before execution the value returned is invalid.
		/// </summary>
		// Token: 0x0600D0C9 RID: 53449 RVA: 0x00122660 File Offset: 0x00120860
		public virtual double GetComputedStandardDeviation()
		{
			return vtkStatisticalOutlierRemoval.vtkStatisticalOutlierRemoval_GetComputedStandardDeviation_04(base.GetCppThis());
		}

		// Token: 0x0600D0CA RID: 53450
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkStatisticalOutlierRemoval_GetComputedStandardDeviationMaxValue_05(HandleRef pThis);

		/// <summary>
		/// After execution, return the value of the computed sigma (standard
		/// deviation). Before execution the value returned is invalid.
		/// </summary>
		// Token: 0x0600D0CB RID: 53451 RVA: 0x00122680 File Offset: 0x00120880
		public virtual double GetComputedStandardDeviationMaxValue()
		{
			return vtkStatisticalOutlierRemoval.vtkStatisticalOutlierRemoval_GetComputedStandardDeviationMaxValue_05(base.GetCppThis());
		}

		// Token: 0x0600D0CC RID: 53452
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkStatisticalOutlierRemoval_GetComputedStandardDeviationMinValue_06(HandleRef pThis);

		/// <summary>
		/// After execution, return the value of the computed sigma (standard
		/// deviation). Before execution the value returned is invalid.
		/// </summary>
		// Token: 0x0600D0CD RID: 53453 RVA: 0x001226A0 File Offset: 0x001208A0
		public virtual double GetComputedStandardDeviationMinValue()
		{
			return vtkStatisticalOutlierRemoval.vtkStatisticalOutlierRemoval_GetComputedStandardDeviationMinValue_06(base.GetCppThis());
		}

		// Token: 0x0600D0CE RID: 53454
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStatisticalOutlierRemoval_GetLocator_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify a point locator. By default a vtkStaticPointLocator is
		/// used. The locator performs efficient searches to locate points
		/// surroinding a sample point.
		/// </summary>
		// Token: 0x0600D0CF RID: 53455 RVA: 0x001226C0 File Offset: 0x001208C0
		public virtual vtkAbstractPointLocator GetLocator()
		{
			vtkAbstractPointLocator vtkAbstractPointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStatisticalOutlierRemoval.vtkStatisticalOutlierRemoval_GetLocator_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractPointLocator = (vtkAbstractPointLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractPointLocator.Register(null);
				}
			}
			return vtkAbstractPointLocator;
		}

		// Token: 0x0600D0D0 RID: 53456
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStatisticalOutlierRemoval_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600D0D1 RID: 53457 RVA: 0x00122730 File Offset: 0x00120930
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkStatisticalOutlierRemoval.vtkStatisticalOutlierRemoval_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x0600D0D2 RID: 53458
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStatisticalOutlierRemoval_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600D0D3 RID: 53459 RVA: 0x00122750 File Offset: 0x00120950
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkStatisticalOutlierRemoval.vtkStatisticalOutlierRemoval_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x0600D0D4 RID: 53460
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStatisticalOutlierRemoval_GetSampleSize_10(HandleRef pThis);

		/// <summary>
		/// For each point sampled, specify the number of the closest, surrounding
		/// points used to compute statistics. By default 25 points are used. Smaller
		/// numbers may speed performance.
		/// </summary>
		// Token: 0x0600D0D5 RID: 53461 RVA: 0x0012276C File Offset: 0x0012096C
		public virtual int GetSampleSize()
		{
			return vtkStatisticalOutlierRemoval.vtkStatisticalOutlierRemoval_GetSampleSize_10(base.GetCppThis());
		}

		// Token: 0x0600D0D6 RID: 53462
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStatisticalOutlierRemoval_GetSampleSizeMaxValue_11(HandleRef pThis);

		/// <summary>
		/// For each point sampled, specify the number of the closest, surrounding
		/// points used to compute statistics. By default 25 points are used. Smaller
		/// numbers may speed performance.
		/// </summary>
		// Token: 0x0600D0D7 RID: 53463 RVA: 0x0012278C File Offset: 0x0012098C
		public virtual int GetSampleSizeMaxValue()
		{
			return vtkStatisticalOutlierRemoval.vtkStatisticalOutlierRemoval_GetSampleSizeMaxValue_11(base.GetCppThis());
		}

		// Token: 0x0600D0D8 RID: 53464
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStatisticalOutlierRemoval_GetSampleSizeMinValue_12(HandleRef pThis);

		/// <summary>
		/// For each point sampled, specify the number of the closest, surrounding
		/// points used to compute statistics. By default 25 points are used. Smaller
		/// numbers may speed performance.
		/// </summary>
		// Token: 0x0600D0D9 RID: 53465 RVA: 0x001227AC File Offset: 0x001209AC
		public virtual int GetSampleSizeMinValue()
		{
			return vtkStatisticalOutlierRemoval.vtkStatisticalOutlierRemoval_GetSampleSizeMinValue_12(base.GetCppThis());
		}

		// Token: 0x0600D0DA RID: 53466
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkStatisticalOutlierRemoval_GetStandardDeviationFactor_13(HandleRef pThis);

		/// <summary>
		/// The filter uses this specified standard deviation factor to extract
		/// points. By default, points within 1.0 standard deviations (i.e., a
		/// StandardDeviationFactor=1.0) of the mean distance to neighboring
		/// points are retained.
		/// </summary>
		// Token: 0x0600D0DB RID: 53467 RVA: 0x001227CC File Offset: 0x001209CC
		public virtual double GetStandardDeviationFactor()
		{
			return vtkStatisticalOutlierRemoval.vtkStatisticalOutlierRemoval_GetStandardDeviationFactor_13(base.GetCppThis());
		}

		// Token: 0x0600D0DC RID: 53468
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkStatisticalOutlierRemoval_GetStandardDeviationFactorMaxValue_14(HandleRef pThis);

		/// <summary>
		/// The filter uses this specified standard deviation factor to extract
		/// points. By default, points within 1.0 standard deviations (i.e., a
		/// StandardDeviationFactor=1.0) of the mean distance to neighboring
		/// points are retained.
		/// </summary>
		// Token: 0x0600D0DD RID: 53469 RVA: 0x001227EC File Offset: 0x001209EC
		public virtual double GetStandardDeviationFactorMaxValue()
		{
			return vtkStatisticalOutlierRemoval.vtkStatisticalOutlierRemoval_GetStandardDeviationFactorMaxValue_14(base.GetCppThis());
		}

		// Token: 0x0600D0DE RID: 53470
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkStatisticalOutlierRemoval_GetStandardDeviationFactorMinValue_15(HandleRef pThis);

		/// <summary>
		/// The filter uses this specified standard deviation factor to extract
		/// points. By default, points within 1.0 standard deviations (i.e., a
		/// StandardDeviationFactor=1.0) of the mean distance to neighboring
		/// points are retained.
		/// </summary>
		// Token: 0x0600D0DF RID: 53471 RVA: 0x0012280C File Offset: 0x00120A0C
		public virtual double GetStandardDeviationFactorMinValue()
		{
			return vtkStatisticalOutlierRemoval.vtkStatisticalOutlierRemoval_GetStandardDeviationFactorMinValue_15(base.GetCppThis());
		}

		// Token: 0x0600D0E0 RID: 53472
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStatisticalOutlierRemoval_IsA_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600D0E1 RID: 53473 RVA: 0x0012282C File Offset: 0x00120A2C
		public override int IsA(string type)
		{
			return vtkStatisticalOutlierRemoval.vtkStatisticalOutlierRemoval_IsA_16(base.GetCppThis(), type);
		}

		// Token: 0x0600D0E2 RID: 53474
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStatisticalOutlierRemoval_IsTypeOf_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600D0E3 RID: 53475 RVA: 0x0012284C File Offset: 0x00120A4C
		public new static int IsTypeOf(string type)
		{
			return vtkStatisticalOutlierRemoval.vtkStatisticalOutlierRemoval_IsTypeOf_17(type);
		}

		// Token: 0x0600D0E4 RID: 53476
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStatisticalOutlierRemoval_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600D0E5 RID: 53477 RVA: 0x00122868 File Offset: 0x00120A68
		public new vtkStatisticalOutlierRemoval NewInstance()
		{
			vtkStatisticalOutlierRemoval result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStatisticalOutlierRemoval.vtkStatisticalOutlierRemoval_NewInstance_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStatisticalOutlierRemoval)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D0E6 RID: 53478
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStatisticalOutlierRemoval_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600D0E7 RID: 53479 RVA: 0x001228C4 File Offset: 0x00120AC4
		public new static vtkStatisticalOutlierRemoval SafeDownCast(vtkObjectBase o)
		{
			vtkStatisticalOutlierRemoval vtkStatisticalOutlierRemoval = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStatisticalOutlierRemoval.vtkStatisticalOutlierRemoval_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStatisticalOutlierRemoval = (vtkStatisticalOutlierRemoval)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStatisticalOutlierRemoval.Register(null);
				}
			}
			return vtkStatisticalOutlierRemoval;
		}

		// Token: 0x0600D0E8 RID: 53480
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStatisticalOutlierRemoval_SetComputedMean_21(HandleRef pThis, double _arg);

		/// <summary>
		/// After execution, return the value of the computed mean. Before execution
		/// the value returned is invalid.
		/// </summary>
		// Token: 0x0600D0E9 RID: 53481 RVA: 0x00122943 File Offset: 0x00120B43
		public virtual void SetComputedMean(double _arg)
		{
			vtkStatisticalOutlierRemoval.vtkStatisticalOutlierRemoval_SetComputedMean_21(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D0EA RID: 53482
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStatisticalOutlierRemoval_SetComputedStandardDeviation_22(HandleRef pThis, double _arg);

		/// <summary>
		/// After execution, return the value of the computed sigma (standard
		/// deviation). Before execution the value returned is invalid.
		/// </summary>
		// Token: 0x0600D0EB RID: 53483 RVA: 0x00122953 File Offset: 0x00120B53
		public virtual void SetComputedStandardDeviation(double _arg)
		{
			vtkStatisticalOutlierRemoval.vtkStatisticalOutlierRemoval_SetComputedStandardDeviation_22(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D0EC RID: 53484
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStatisticalOutlierRemoval_SetLocator_23(HandleRef pThis, HandleRef locator);

		/// <summary>
		/// Specify a point locator. By default a vtkStaticPointLocator is
		/// used. The locator performs efficient searches to locate points
		/// surroinding a sample point.
		/// </summary>
		// Token: 0x0600D0ED RID: 53485 RVA: 0x00122964 File Offset: 0x00120B64
		public void SetLocator(vtkAbstractPointLocator locator)
		{
			vtkStatisticalOutlierRemoval.vtkStatisticalOutlierRemoval_SetLocator_23(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		// Token: 0x0600D0EE RID: 53486
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStatisticalOutlierRemoval_SetSampleSize_24(HandleRef pThis, int _arg);

		/// <summary>
		/// For each point sampled, specify the number of the closest, surrounding
		/// points used to compute statistics. By default 25 points are used. Smaller
		/// numbers may speed performance.
		/// </summary>
		// Token: 0x0600D0EF RID: 53487 RVA: 0x00122993 File Offset: 0x00120B93
		public virtual void SetSampleSize(int _arg)
		{
			vtkStatisticalOutlierRemoval.vtkStatisticalOutlierRemoval_SetSampleSize_24(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D0F0 RID: 53488
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStatisticalOutlierRemoval_SetStandardDeviationFactor_25(HandleRef pThis, double _arg);

		/// <summary>
		/// The filter uses this specified standard deviation factor to extract
		/// points. By default, points within 1.0 standard deviations (i.e., a
		/// StandardDeviationFactor=1.0) of the mean distance to neighboring
		/// points are retained.
		/// </summary>
		// Token: 0x0600D0F1 RID: 53489 RVA: 0x001229A3 File Offset: 0x00120BA3
		public virtual void SetStandardDeviationFactor(double _arg)
		{
			vtkStatisticalOutlierRemoval.vtkStatisticalOutlierRemoval_SetStandardDeviationFactor_25(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F67 RID: 3943
		public new const string MRFullTypeName = "Kitware.VTK.vtkStatisticalOutlierRemoval";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F68 RID: 3944
		public new static readonly string MRClassNameKey = "class vtkStatisticalOutlierRemoval";
	}
}
