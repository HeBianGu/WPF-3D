using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBivariateLinearTableThreshold
	/// </summary>
	/// <remarks>
	///    performs line-based thresholding
	/// for vtkTable data.
	///
	///
	/// Class for filtering the rows of a two numeric columns of a vtkTable.  The
	/// columns are treated as the two variables of a line.  This filter will
	/// then iterate through the rows of the table determining if X,Y values pairs
	/// are above/below/between/near one or more lines.
	///
	/// The "between" mode checks to see if a row is contained within the convex
	/// hull of all of the specified lines.  The "near" mode checks if a row is
	/// within a distance threshold two one of the specified lines.  This class
	/// is used in conjunction with various plotting classes, so it is useful
	/// to rescale the X,Y axes to a particular range of values.  Distance
	/// comparisons can be performed in the scaled space by setting the CustomRanges
	/// ivar and enabling UseNormalizedDistance.
	/// </remarks>
	// Token: 0x0200073B RID: 1851
	public class vtkBivariateLinearTableThreshold : vtkTableAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06013459 RID: 78937 RVA: 0x001B429F File Offset: 0x001B249F
		static vtkBivariateLinearTableThreshold()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBivariateLinearTableThreshold.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBivariateLinearTableThreshold"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601345A RID: 78938 RVA: 0x001B42C7 File Offset: 0x001B24C7
		public vtkBivariateLinearTableThreshold(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601345B RID: 78939
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBivariateLinearTableThreshold_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601345C RID: 78940 RVA: 0x001B42D8 File Offset: 0x001B24D8
		public new static vtkBivariateLinearTableThreshold New()
		{
			vtkBivariateLinearTableThreshold result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBivariateLinearTableThreshold)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601345D RID: 78941 RVA: 0x001B432C File Offset: 0x001B252C
		public vtkBivariateLinearTableThreshold() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601345E RID: 78942 RVA: 0x001B4370 File Offset: 0x001B2570
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601345F RID: 78943
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBivariateLinearTableThreshold_AddColumnToThreshold_01(HandleRef pThis, long column, long component);

		/// <summary>
		/// Add a numeric column to the pair of columns to be thresholded.  Call twice.
		/// </summary>
		// Token: 0x06013460 RID: 78944 RVA: 0x001B437B File Offset: 0x001B257B
		public void AddColumnToThreshold(long column, long component)
		{
			vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_AddColumnToThreshold_01(base.GetCppThis(), column, component);
		}

		// Token: 0x06013461 RID: 78945
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBivariateLinearTableThreshold_AddLineEquation_02(HandleRef pThis, IntPtr p1, IntPtr p2);

		/// <summary>
		/// Add a line for thresholding from two x,y points.
		/// </summary>
		// Token: 0x06013462 RID: 78946 RVA: 0x001B438C File Offset: 0x001B258C
		public void AddLineEquation(IntPtr p1, IntPtr p2)
		{
			vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_AddLineEquation_02(base.GetCppThis(), p1, p2);
		}

		// Token: 0x06013463 RID: 78947
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBivariateLinearTableThreshold_AddLineEquation_03(HandleRef pThis, IntPtr p, double slope);

		/// <summary>
		/// Add a line for thresholding in point-slope form.
		/// </summary>
		// Token: 0x06013464 RID: 78948 RVA: 0x001B439D File Offset: 0x001B259D
		public void AddLineEquation(IntPtr p, double slope)
		{
			vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_AddLineEquation_03(base.GetCppThis(), p, slope);
		}

		// Token: 0x06013465 RID: 78949
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBivariateLinearTableThreshold_AddLineEquation_04(HandleRef pThis, double a, double b, double c);

		/// <summary>
		/// Add a line for thresholding in implicit form (ax + by + c = 0)
		/// </summary>
		// Token: 0x06013466 RID: 78950 RVA: 0x001B43AE File Offset: 0x001B25AE
		public void AddLineEquation(double a, double b, double c)
		{
			vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_AddLineEquation_04(base.GetCppThis(), a, b, c);
		}

		// Token: 0x06013467 RID: 78951
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBivariateLinearTableThreshold_ClearColumnsToThreshold_05(HandleRef pThis);

		/// <summary>
		/// Reset the columns to be thresholded.
		/// </summary>
		// Token: 0x06013468 RID: 78952 RVA: 0x001B43C0 File Offset: 0x001B25C0
		public void ClearColumnsToThreshold()
		{
			vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_ClearColumnsToThreshold_05(base.GetCppThis());
		}

		// Token: 0x06013469 RID: 78953
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBivariateLinearTableThreshold_ClearLineEquations_06(HandleRef pThis);

		/// <summary>
		/// Reset the list of line equations.
		/// </summary>
		// Token: 0x0601346A RID: 78954 RVA: 0x001B43CF File Offset: 0x001B25CF
		public void ClearLineEquations()
		{
			vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_ClearLineEquations_06(base.GetCppThis());
		}

		// Token: 0x0601346B RID: 78955
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBivariateLinearTableThreshold_ComputeImplicitLineFunction_07(IntPtr p1, IntPtr p2, IntPtr abc);

		/// <summary>
		/// Convert the two-point line formula to implicit form.
		/// </summary>
		// Token: 0x0601346C RID: 78956 RVA: 0x001B43DE File Offset: 0x001B25DE
		public static void ComputeImplicitLineFunction(IntPtr p1, IntPtr p2, IntPtr abc)
		{
			vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_ComputeImplicitLineFunction_07(p1, p2, abc);
		}

		// Token: 0x0601346D RID: 78957
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBivariateLinearTableThreshold_ComputeImplicitLineFunction_08(IntPtr p, double slope, IntPtr abc);

		/// <summary>
		/// Convert the point-slope line formula to implicit form.
		/// </summary>
		// Token: 0x0601346E RID: 78958 RVA: 0x001B43EA File Offset: 0x001B25EA
		public static void ComputeImplicitLineFunction(IntPtr p, double slope, IntPtr abc)
		{
			vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_ComputeImplicitLineFunction_08(p, slope, abc);
		}

		// Token: 0x0601346F RID: 78959
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBivariateLinearTableThreshold_GetColumnRanges_09(HandleRef pThis);

		/// <summary>
		/// Manually access the maximum/minimum x,y values.  This is used in
		/// conjunction with UseNormalizedDistance when determining if a row
		/// passes the threshold.
		/// </summary>
		// Token: 0x06013470 RID: 78960 RVA: 0x001B43F8 File Offset: 0x001B25F8
		public virtual double[] GetColumnRanges()
		{
			IntPtr intPtr = vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_GetColumnRanges_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06013471 RID: 78961
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBivariateLinearTableThreshold_GetColumnRanges_10(HandleRef pThis, ref double _arg1, ref double _arg2);

		/// <summary>
		/// Manually access the maximum/minimum x,y values.  This is used in
		/// conjunction with UseNormalizedDistance when determining if a row
		/// passes the threshold.
		/// </summary>
		// Token: 0x06013472 RID: 78962 RVA: 0x001B4440 File Offset: 0x001B2640
		public virtual void GetColumnRanges(ref double _arg1, ref double _arg2)
		{
			vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_GetColumnRanges_10(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06013473 RID: 78963
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBivariateLinearTableThreshold_GetColumnRanges_11(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Manually access the maximum/minimum x,y values.  This is used in
		/// conjunction with UseNormalizedDistance when determining if a row
		/// passes the threshold.
		/// </summary>
		// Token: 0x06013474 RID: 78964 RVA: 0x001B4451 File Offset: 0x001B2651
		public virtual void GetColumnRanges(IntPtr _arg)
		{
			vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_GetColumnRanges_11(base.GetCppThis(), _arg);
		}

		// Token: 0x06013475 RID: 78965
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBivariateLinearTableThreshold_GetColumnToThreshold_12(HandleRef pThis, long idx, ref long column, ref long component);

		/// <summary>
		/// Return the column number from the input table for the idx'th added column.
		/// </summary>
		// Token: 0x06013476 RID: 78966 RVA: 0x001B4461 File Offset: 0x001B2661
		public void GetColumnToThreshold(long idx, ref long column, ref long component)
		{
			vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_GetColumnToThreshold_12(base.GetCppThis(), idx, ref column, ref component);
		}

		// Token: 0x06013477 RID: 78967
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkBivariateLinearTableThreshold_GetDistanceThreshold_13(HandleRef pThis);

		/// <summary>
		/// The Cartesian distance within which a point will pass the near threshold.
		/// </summary>
		// Token: 0x06013478 RID: 78968 RVA: 0x001B4474 File Offset: 0x001B2674
		public virtual double GetDistanceThreshold()
		{
			return vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_GetDistanceThreshold_13(base.GetCppThis());
		}

		// Token: 0x06013479 RID: 78969
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBivariateLinearTableThreshold_GetInclusive_14(HandleRef pThis);

		/// <summary>
		/// Include the line in the threshold.  Essentially whether the threshold operation
		/// uses &gt; versus &gt;=.
		/// </summary>
		// Token: 0x0601347A RID: 78970 RVA: 0x001B4494 File Offset: 0x001B2694
		public virtual int GetInclusive()
		{
			return vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_GetInclusive_14(base.GetCppThis());
		}

		// Token: 0x0601347B RID: 78971
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBivariateLinearTableThreshold_GetLinearThresholdType_15(HandleRef pThis);

		/// <summary>
		/// Set the threshold type.  Above: find all rows that are above the specified
		/// lines.  Below: find all rows that are below the specified lines.  Near:
		/// find all rows that are near the specified lines.  Between: find all rows
		/// that are between the specified lines.
		/// </summary>
		// Token: 0x0601347C RID: 78972 RVA: 0x001B44B4 File Offset: 0x001B26B4
		public virtual int GetLinearThresholdType()
		{
			return vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_GetLinearThresholdType_15(base.GetCppThis());
		}

		// Token: 0x0601347D RID: 78973
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBivariateLinearTableThreshold_GetNumberOfColumnsToThreshold_16(HandleRef pThis);

		/// <summary>
		/// Return how many columns have been added.  Hopefully 2.
		/// </summary>
		// Token: 0x0601347E RID: 78974 RVA: 0x001B44D4 File Offset: 0x001B26D4
		public int GetNumberOfColumnsToThreshold()
		{
			return vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_GetNumberOfColumnsToThreshold_16(base.GetCppThis());
		}

		// Token: 0x0601347F RID: 78975
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBivariateLinearTableThreshold_GetNumberOfGenerationsFromBase_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013480 RID: 78976 RVA: 0x001B44F4 File Offset: 0x001B26F4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_GetNumberOfGenerationsFromBase_17(base.GetCppThis(), type);
		}

		// Token: 0x06013481 RID: 78977
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBivariateLinearTableThreshold_GetNumberOfGenerationsFromBaseType_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013482 RID: 78978 RVA: 0x001B4514 File Offset: 0x001B2714
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_GetNumberOfGenerationsFromBaseType_18(type);
		}

		// Token: 0x06013483 RID: 78979
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBivariateLinearTableThreshold_GetSelectedRowIds_19(HandleRef pThis, int selection, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output as a table of row ids.
		/// </summary>
		// Token: 0x06013484 RID: 78980 RVA: 0x001B4530 File Offset: 0x001B2730
		public vtkIdTypeArray GetSelectedRowIds(int selection)
		{
			vtkIdTypeArray vtkIdTypeArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_GetSelectedRowIds_19(base.GetCppThis(), selection, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdTypeArray = (vtkIdTypeArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdTypeArray.Register(null);
				}
			}
			return vtkIdTypeArray;
		}

		// Token: 0x06013485 RID: 78981
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBivariateLinearTableThreshold_GetUseNormalizedDistance_20(HandleRef pThis);

		/// <summary>
		/// Renormalize the space of the data such that the X and Y axes are
		/// "square" over the specified ColumnRanges.  This essentially scales
		/// the data space so that ColumnRanges[1]-ColumnRanges[0] = 1.0 and
		/// ColumnRanges[3]-ColumnRanges[2] = 1.0.  Used for scatter plot distance
		/// calculations.  Be sure to set DistanceThreshold accordingly, when used.
		/// </summary>
		// Token: 0x06013486 RID: 78982 RVA: 0x001B45A0 File Offset: 0x001B27A0
		public virtual int GetUseNormalizedDistance()
		{
			return vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_GetUseNormalizedDistance_20(base.GetCppThis());
		}

		// Token: 0x06013487 RID: 78983
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBivariateLinearTableThreshold_Initialize_21(HandleRef pThis);

		/// <summary>
		/// Reset the columns to threshold, column ranges, etc.
		/// </summary>
		// Token: 0x06013488 RID: 78984 RVA: 0x001B45BF File Offset: 0x001B27BF
		public void Initialize()
		{
			vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_Initialize_21(base.GetCppThis());
		}

		// Token: 0x06013489 RID: 78985
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBivariateLinearTableThreshold_IsA_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601348A RID: 78986 RVA: 0x001B45D0 File Offset: 0x001B27D0
		public override int IsA(string type)
		{
			return vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_IsA_22(base.GetCppThis(), type);
		}

		// Token: 0x0601348B RID: 78987
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBivariateLinearTableThreshold_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601348C RID: 78988 RVA: 0x001B45F0 File Offset: 0x001B27F0
		public new static int IsTypeOf(string type)
		{
			return vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_IsTypeOf_23(type);
		}

		// Token: 0x0601348D RID: 78989
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBivariateLinearTableThreshold_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601348E RID: 78990 RVA: 0x001B460C File Offset: 0x001B280C
		public new vtkBivariateLinearTableThreshold NewInstance()
		{
			vtkBivariateLinearTableThreshold result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_NewInstance_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBivariateLinearTableThreshold)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601348F RID: 78991
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBivariateLinearTableThreshold_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013490 RID: 78992 RVA: 0x001B4668 File Offset: 0x001B2868
		public new static vtkBivariateLinearTableThreshold SafeDownCast(vtkObjectBase o)
		{
			vtkBivariateLinearTableThreshold vtkBivariateLinearTableThreshold = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBivariateLinearTableThreshold = (vtkBivariateLinearTableThreshold)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBivariateLinearTableThreshold.Register(null);
				}
			}
			return vtkBivariateLinearTableThreshold;
		}

		// Token: 0x06013491 RID: 78993
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBivariateLinearTableThreshold_SetColumnRanges_27(HandleRef pThis, double _arg1, double _arg2);

		/// <summary>
		/// Manually access the maximum/minimum x,y values.  This is used in
		/// conjunction with UseNormalizedDistance when determining if a row
		/// passes the threshold.
		/// </summary>
		// Token: 0x06013492 RID: 78994 RVA: 0x001B46E7 File Offset: 0x001B28E7
		public virtual void SetColumnRanges(double _arg1, double _arg2)
		{
			vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_SetColumnRanges_27(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x06013493 RID: 78995
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBivariateLinearTableThreshold_SetColumnRanges_28(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Manually access the maximum/minimum x,y values.  This is used in
		/// conjunction with UseNormalizedDistance when determining if a row
		/// passes the threshold.
		/// </summary>
		// Token: 0x06013494 RID: 78996 RVA: 0x001B46F8 File Offset: 0x001B28F8
		public void SetColumnRanges(IntPtr _arg)
		{
			vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_SetColumnRanges_28(base.GetCppThis(), _arg);
		}

		// Token: 0x06013495 RID: 78997
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBivariateLinearTableThreshold_SetDistanceThreshold_29(HandleRef pThis, double _arg);

		/// <summary>
		/// The Cartesian distance within which a point will pass the near threshold.
		/// </summary>
		// Token: 0x06013496 RID: 78998 RVA: 0x001B4708 File Offset: 0x001B2908
		public virtual void SetDistanceThreshold(double _arg)
		{
			vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_SetDistanceThreshold_29(base.GetCppThis(), _arg);
		}

		// Token: 0x06013497 RID: 78999
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBivariateLinearTableThreshold_SetInclusive_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Include the line in the threshold.  Essentially whether the threshold operation
		/// uses &gt; versus &gt;=.
		/// </summary>
		// Token: 0x06013498 RID: 79000 RVA: 0x001B4718 File Offset: 0x001B2918
		public virtual void SetInclusive(int _arg)
		{
			vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_SetInclusive_30(base.GetCppThis(), _arg);
		}

		// Token: 0x06013499 RID: 79001
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBivariateLinearTableThreshold_SetLinearThresholdType_31(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the threshold type.  Above: find all rows that are above the specified
		/// lines.  Below: find all rows that are below the specified lines.  Near:
		/// find all rows that are near the specified lines.  Between: find all rows
		/// that are between the specified lines.
		/// </summary>
		// Token: 0x0601349A RID: 79002 RVA: 0x001B4728 File Offset: 0x001B2928
		public virtual void SetLinearThresholdType(int _arg)
		{
			vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_SetLinearThresholdType_31(base.GetCppThis(), _arg);
		}

		// Token: 0x0601349B RID: 79003
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBivariateLinearTableThreshold_SetLinearThresholdTypeToAbove_32(HandleRef pThis);

		/// <summary>
		/// Set the threshold type.  Above: find all rows that are above the specified
		/// lines.  Below: find all rows that are below the specified lines.  Near:
		/// find all rows that are near the specified lines.  Between: find all rows
		/// that are between the specified lines.
		/// </summary>
		// Token: 0x0601349C RID: 79004 RVA: 0x001B4738 File Offset: 0x001B2938
		public void SetLinearThresholdTypeToAbove()
		{
			vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_SetLinearThresholdTypeToAbove_32(base.GetCppThis());
		}

		// Token: 0x0601349D RID: 79005
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBivariateLinearTableThreshold_SetLinearThresholdTypeToBelow_33(HandleRef pThis);

		/// <summary>
		/// Set the threshold type.  Above: find all rows that are above the specified
		/// lines.  Below: find all rows that are below the specified lines.  Near:
		/// find all rows that are near the specified lines.  Between: find all rows
		/// that are between the specified lines.
		/// </summary>
		// Token: 0x0601349E RID: 79006 RVA: 0x001B4747 File Offset: 0x001B2947
		public void SetLinearThresholdTypeToBelow()
		{
			vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_SetLinearThresholdTypeToBelow_33(base.GetCppThis());
		}

		// Token: 0x0601349F RID: 79007
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBivariateLinearTableThreshold_SetLinearThresholdTypeToBetween_34(HandleRef pThis);

		/// <summary>
		/// Set the threshold type.  Above: find all rows that are above the specified
		/// lines.  Below: find all rows that are below the specified lines.  Near:
		/// find all rows that are near the specified lines.  Between: find all rows
		/// that are between the specified lines.
		/// </summary>
		// Token: 0x060134A0 RID: 79008 RVA: 0x001B4756 File Offset: 0x001B2956
		public void SetLinearThresholdTypeToBetween()
		{
			vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_SetLinearThresholdTypeToBetween_34(base.GetCppThis());
		}

		// Token: 0x060134A1 RID: 79009
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBivariateLinearTableThreshold_SetLinearThresholdTypeToNear_35(HandleRef pThis);

		/// <summary>
		/// Set the threshold type.  Above: find all rows that are above the specified
		/// lines.  Below: find all rows that are below the specified lines.  Near:
		/// find all rows that are near the specified lines.  Between: find all rows
		/// that are between the specified lines.
		/// </summary>
		// Token: 0x060134A2 RID: 79010 RVA: 0x001B4765 File Offset: 0x001B2965
		public void SetLinearThresholdTypeToNear()
		{
			vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_SetLinearThresholdTypeToNear_35(base.GetCppThis());
		}

		// Token: 0x060134A3 RID: 79011
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBivariateLinearTableThreshold_SetUseNormalizedDistance_36(HandleRef pThis, int _arg);

		/// <summary>
		/// Renormalize the space of the data such that the X and Y axes are
		/// "square" over the specified ColumnRanges.  This essentially scales
		/// the data space so that ColumnRanges[1]-ColumnRanges[0] = 1.0 and
		/// ColumnRanges[3]-ColumnRanges[2] = 1.0.  Used for scatter plot distance
		/// calculations.  Be sure to set DistanceThreshold accordingly, when used.
		/// </summary>
		// Token: 0x060134A4 RID: 79012 RVA: 0x001B4774 File Offset: 0x001B2974
		public virtual void SetUseNormalizedDistance(int _arg)
		{
			vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_SetUseNormalizedDistance_36(base.GetCppThis(), _arg);
		}

		// Token: 0x060134A5 RID: 79013
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBivariateLinearTableThreshold_UseNormalizedDistanceOff_37(HandleRef pThis);

		/// <summary>
		/// Renormalize the space of the data such that the X and Y axes are
		/// "square" over the specified ColumnRanges.  This essentially scales
		/// the data space so that ColumnRanges[1]-ColumnRanges[0] = 1.0 and
		/// ColumnRanges[3]-ColumnRanges[2] = 1.0.  Used for scatter plot distance
		/// calculations.  Be sure to set DistanceThreshold accordingly, when used.
		/// </summary>
		// Token: 0x060134A6 RID: 79014 RVA: 0x001B4784 File Offset: 0x001B2984
		public virtual void UseNormalizedDistanceOff()
		{
			vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_UseNormalizedDistanceOff_37(base.GetCppThis());
		}

		// Token: 0x060134A7 RID: 79015
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBivariateLinearTableThreshold_UseNormalizedDistanceOn_38(HandleRef pThis);

		/// <summary>
		/// Renormalize the space of the data such that the X and Y axes are
		/// "square" over the specified ColumnRanges.  This essentially scales
		/// the data space so that ColumnRanges[1]-ColumnRanges[0] = 1.0 and
		/// ColumnRanges[3]-ColumnRanges[2] = 1.0.  Used for scatter plot distance
		/// calculations.  Be sure to set DistanceThreshold accordingly, when used.
		/// </summary>
		// Token: 0x060134A8 RID: 79016 RVA: 0x001B4793 File Offset: 0x001B2993
		public virtual void UseNormalizedDistanceOn()
		{
			vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_UseNormalizedDistanceOn_38(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001642 RID: 5698
		public new const string MRFullTypeName = "Kitware.VTK.vtkBivariateLinearTableThreshold";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001643 RID: 5699
		public new static readonly string MRClassNameKey = "class vtkBivariateLinearTableThreshold";

		/// <summary>
		/// Get the output as a table of row ids.
		/// </summary>
		// Token: 0x0200073C RID: 1852
		public enum LinearThresholdType
		{
			/// <summary>enum member</summary>
			// Token: 0x04001645 RID: 5701
			BLT_ABOVE,
			/// <summary>enum member</summary>
			// Token: 0x04001646 RID: 5702
			BLT_BELOW,
			/// <summary>enum member</summary>
			// Token: 0x04001647 RID: 5703
			BLT_BETWEEN = 3,
			/// <summary>enum member</summary>
			// Token: 0x04001648 RID: 5704
			BLT_NEAR = 2
		}

		/// <summary>
		/// Get the output as a table of row ids.
		/// </summary>
		// Token: 0x0200073D RID: 1853
		public enum OutputPorts
		{
			/// <summary>enum member</summary>
			// Token: 0x0400164A RID: 5706
			OUTPUT_ROW_DATA = 1,
			/// <summary>enum member</summary>
			// Token: 0x0400164B RID: 5707
			OUTPUT_ROW_IDS = 0
		}
	}
}
