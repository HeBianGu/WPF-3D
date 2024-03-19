using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCleanUnstructuredGrid
	/// </summary>
	/// <remarks>
	///    merge duplicate points
	///
	///
	/// vtkCleanUnstructuredGrid is a filter that takes unstructured grid data as
	/// input and generates unstructured grid data as output. vtkCleanUnstructuredGrid can
	/// merge duplicate points (with coincident coordinates) using the vtkMergePoints object
	/// to merge points.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkCleanPolyData
	/// </seealso>
	// Token: 0x0200087E RID: 2174
	public class vtkCleanUnstructuredGrid : vtkUnstructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060168FE RID: 92414 RVA: 0x001FBF5F File Offset: 0x001FA15F
		static vtkCleanUnstructuredGrid()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCleanUnstructuredGrid.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCleanUnstructuredGrid"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060168FF RID: 92415 RVA: 0x001FBF87 File Offset: 0x001FA187
		public vtkCleanUnstructuredGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016900 RID: 92416
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCleanUnstructuredGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016901 RID: 92417 RVA: 0x001FBF98 File Offset: 0x001FA198
		public new static vtkCleanUnstructuredGrid New()
		{
			vtkCleanUnstructuredGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCleanUnstructuredGrid.vtkCleanUnstructuredGrid_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCleanUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016902 RID: 92418 RVA: 0x001FBFEC File Offset: 0x001FA1EC
		public vtkCleanUnstructuredGrid() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCleanUnstructuredGrid.vtkCleanUnstructuredGrid_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016903 RID: 92419 RVA: 0x001FC030 File Offset: 0x001FA230
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016904 RID: 92420
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCleanUnstructuredGrid_CreateDefaultLocator_01(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Create default locator. Used to create one when none is specified.
		/// </summary>
		// Token: 0x06016905 RID: 92421 RVA: 0x001FC03C File Offset: 0x001FA23C
		public void CreateDefaultLocator(vtkDataSet input)
		{
			vtkCleanUnstructuredGrid.vtkCleanUnstructuredGrid_CreateDefaultLocator_01(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x06016906 RID: 92422
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCleanUnstructuredGrid_GetAbsoluteTolerance_02(HandleRef pThis);

		/// <summary>
		/// Specify tolerance in absolute terms. Default is 1.0.
		/// </summary>
		// Token: 0x06016907 RID: 92423 RVA: 0x001FC06C File Offset: 0x001FA26C
		public virtual double GetAbsoluteTolerance()
		{
			return vtkCleanUnstructuredGrid.vtkCleanUnstructuredGrid_GetAbsoluteTolerance_02(base.GetCppThis());
		}

		// Token: 0x06016908 RID: 92424
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCleanUnstructuredGrid_GetAbsoluteToleranceMaxValue_03(HandleRef pThis);

		/// <summary>
		/// Specify tolerance in absolute terms. Default is 1.0.
		/// </summary>
		// Token: 0x06016909 RID: 92425 RVA: 0x001FC08C File Offset: 0x001FA28C
		public virtual double GetAbsoluteToleranceMaxValue()
		{
			return vtkCleanUnstructuredGrid.vtkCleanUnstructuredGrid_GetAbsoluteToleranceMaxValue_03(base.GetCppThis());
		}

		// Token: 0x0601690A RID: 92426
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCleanUnstructuredGrid_GetAbsoluteToleranceMinValue_04(HandleRef pThis);

		/// <summary>
		/// Specify tolerance in absolute terms. Default is 1.0.
		/// </summary>
		// Token: 0x0601690B RID: 92427 RVA: 0x001FC0AC File Offset: 0x001FA2AC
		public virtual double GetAbsoluteToleranceMinValue()
		{
			return vtkCleanUnstructuredGrid.vtkCleanUnstructuredGrid_GetAbsoluteToleranceMinValue_04(base.GetCppThis());
		}

		// Token: 0x0601690C RID: 92428
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCleanUnstructuredGrid_GetLocator_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get a spatial locator for speeding the search process. By
		/// default an instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x0601690D RID: 92429 RVA: 0x001FC0CC File Offset: 0x001FA2CC
		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCleanUnstructuredGrid.vtkCleanUnstructuredGrid_GetLocator_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIncrementalPointLocator = (vtkIncrementalPointLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIncrementalPointLocator.Register(null);
				}
			}
			return vtkIncrementalPointLocator;
		}

		// Token: 0x0601690E RID: 92430
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCleanUnstructuredGrid_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601690F RID: 92431 RVA: 0x001FC13C File Offset: 0x001FA33C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCleanUnstructuredGrid.vtkCleanUnstructuredGrid_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x06016910 RID: 92432
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCleanUnstructuredGrid_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016911 RID: 92433 RVA: 0x001FC15C File Offset: 0x001FA35C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCleanUnstructuredGrid.vtkCleanUnstructuredGrid_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x06016912 RID: 92434
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCleanUnstructuredGrid_GetOutputPointsPrecision_08(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06016913 RID: 92435 RVA: 0x001FC178 File Offset: 0x001FA378
		public virtual int GetOutputPointsPrecision()
		{
			return vtkCleanUnstructuredGrid.vtkCleanUnstructuredGrid_GetOutputPointsPrecision_08(base.GetCppThis());
		}

		// Token: 0x06016914 RID: 92436
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCleanUnstructuredGrid_GetPointDataWeighingStrategy_09(HandleRef pThis);

		/// <summary>
		/// Set/Get the strategy used to weigh point data on merging points
		///
		/// Possibilities:
		/// - FIRST_POINT (int(0), default): the point with the lowest index imposes its data on to the
		/// merged point
		/// - AVERAGING (int(1)): a number average is performed on all the duplicate points
		/// - SPATIAL_DENSITY (int(2)): an average by attached cell volume (i.e. for every cell the point
		/// is connected to sum cell_volume/number_cell_points) is performed on the point data
		/// </summary>
		// Token: 0x06016915 RID: 92437 RVA: 0x001FC198 File Offset: 0x001FA398
		public virtual int GetPointDataWeighingStrategy()
		{
			return vtkCleanUnstructuredGrid.vtkCleanUnstructuredGrid_GetPointDataWeighingStrategy_09(base.GetCppThis());
		}

		// Token: 0x06016916 RID: 92438
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCleanUnstructuredGrid_GetPointDataWeighingStrategyMaxValue_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the strategy used to weigh point data on merging points
		///
		/// Possibilities:
		/// - FIRST_POINT (int(0), default): the point with the lowest index imposes its data on to the
		/// merged point
		/// - AVERAGING (int(1)): a number average is performed on all the duplicate points
		/// - SPATIAL_DENSITY (int(2)): an average by attached cell volume (i.e. for every cell the point
		/// is connected to sum cell_volume/number_cell_points) is performed on the point data
		/// </summary>
		// Token: 0x06016917 RID: 92439 RVA: 0x001FC1B8 File Offset: 0x001FA3B8
		public virtual int GetPointDataWeighingStrategyMaxValue()
		{
			return vtkCleanUnstructuredGrid.vtkCleanUnstructuredGrid_GetPointDataWeighingStrategyMaxValue_10(base.GetCppThis());
		}

		// Token: 0x06016918 RID: 92440
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCleanUnstructuredGrid_GetPointDataWeighingStrategyMinValue_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the strategy used to weigh point data on merging points
		///
		/// Possibilities:
		/// - FIRST_POINT (int(0), default): the point with the lowest index imposes its data on to the
		/// merged point
		/// - AVERAGING (int(1)): a number average is performed on all the duplicate points
		/// - SPATIAL_DENSITY (int(2)): an average by attached cell volume (i.e. for every cell the point
		/// is connected to sum cell_volume/number_cell_points) is performed on the point data
		/// </summary>
		// Token: 0x06016919 RID: 92441 RVA: 0x001FC1D8 File Offset: 0x001FA3D8
		public virtual int GetPointDataWeighingStrategyMinValue()
		{
			return vtkCleanUnstructuredGrid.vtkCleanUnstructuredGrid_GetPointDataWeighingStrategyMinValue_11(base.GetCppThis());
		}

		// Token: 0x0601691A RID: 92442
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCleanUnstructuredGrid_GetRemovePointsWithoutCells_12(HandleRef pThis);

		/// <summary>
		/// Set/Get whether to remove points that do not
		/// have any cells associated with it.
		/// Default is false
		/// </summary>
		// Token: 0x0601691B RID: 92443 RVA: 0x001FC1F8 File Offset: 0x001FA3F8
		public virtual bool GetRemovePointsWithoutCells()
		{
			return vtkCleanUnstructuredGrid.vtkCleanUnstructuredGrid_GetRemovePointsWithoutCells_12(base.GetCppThis()) != 0;
		}

		// Token: 0x0601691C RID: 92444
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCleanUnstructuredGrid_GetTolerance_13(HandleRef pThis);

		/// <summary>
		/// Specify tolerance in terms of fraction of bounding box length.
		/// Default is 0.0.
		/// </summary>
		// Token: 0x0601691D RID: 92445 RVA: 0x001FC220 File Offset: 0x001FA420
		public virtual double GetTolerance()
		{
			return vtkCleanUnstructuredGrid.vtkCleanUnstructuredGrid_GetTolerance_13(base.GetCppThis());
		}

		// Token: 0x0601691E RID: 92446
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCleanUnstructuredGrid_GetToleranceIsAbsolute_14(HandleRef pThis);

		/// <summary>
		/// By default ToleranceIsAbsolute is false and Tolerance is
		/// a fraction of Bounding box diagonal, if true, AbsoluteTolerance is
		/// used when adding points to locator (merging)
		/// </summary>
		// Token: 0x0601691F RID: 92447 RVA: 0x001FC240 File Offset: 0x001FA440
		public virtual bool GetToleranceIsAbsolute()
		{
			return vtkCleanUnstructuredGrid.vtkCleanUnstructuredGrid_GetToleranceIsAbsolute_14(base.GetCppThis()) != 0;
		}

		// Token: 0x06016920 RID: 92448
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCleanUnstructuredGrid_GetToleranceMaxValue_15(HandleRef pThis);

		/// <summary>
		/// Specify tolerance in terms of fraction of bounding box length.
		/// Default is 0.0.
		/// </summary>
		// Token: 0x06016921 RID: 92449 RVA: 0x001FC268 File Offset: 0x001FA468
		public virtual double GetToleranceMaxValue()
		{
			return vtkCleanUnstructuredGrid.vtkCleanUnstructuredGrid_GetToleranceMaxValue_15(base.GetCppThis());
		}

		// Token: 0x06016922 RID: 92450
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCleanUnstructuredGrid_GetToleranceMinValue_16(HandleRef pThis);

		/// <summary>
		/// Specify tolerance in terms of fraction of bounding box length.
		/// Default is 0.0.
		/// </summary>
		// Token: 0x06016923 RID: 92451 RVA: 0x001FC288 File Offset: 0x001FA488
		public virtual double GetToleranceMinValue()
		{
			return vtkCleanUnstructuredGrid.vtkCleanUnstructuredGrid_GetToleranceMinValue_16(base.GetCppThis());
		}

		// Token: 0x06016924 RID: 92452
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCleanUnstructuredGrid_IsA_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016925 RID: 92453 RVA: 0x001FC2A8 File Offset: 0x001FA4A8
		public override int IsA(string type)
		{
			return vtkCleanUnstructuredGrid.vtkCleanUnstructuredGrid_IsA_17(base.GetCppThis(), type);
		}

		// Token: 0x06016926 RID: 92454
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCleanUnstructuredGrid_IsTypeOf_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016927 RID: 92455 RVA: 0x001FC2C8 File Offset: 0x001FA4C8
		public new static int IsTypeOf(string type)
		{
			return vtkCleanUnstructuredGrid.vtkCleanUnstructuredGrid_IsTypeOf_18(type);
		}

		// Token: 0x06016928 RID: 92456
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCleanUnstructuredGrid_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016929 RID: 92457 RVA: 0x001FC2E4 File Offset: 0x001FA4E4
		public new vtkCleanUnstructuredGrid NewInstance()
		{
			vtkCleanUnstructuredGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCleanUnstructuredGrid.vtkCleanUnstructuredGrid_NewInstance_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCleanUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601692A RID: 92458
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCleanUnstructuredGrid_ReleaseLocator_21(HandleRef pThis);

		/// <summary>
		/// Release locator
		/// </summary>
		// Token: 0x0601692B RID: 92459 RVA: 0x001FC33E File Offset: 0x001FA53E
		public void ReleaseLocator()
		{
			vtkCleanUnstructuredGrid.vtkCleanUnstructuredGrid_ReleaseLocator_21(base.GetCppThis());
		}

		// Token: 0x0601692C RID: 92460
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCleanUnstructuredGrid_RemovePointsWithoutCellsOff_22(HandleRef pThis);

		/// <summary>
		/// Set/Get whether to remove points that do not
		/// have any cells associated with it.
		/// Default is false
		/// </summary>
		// Token: 0x0601692D RID: 92461 RVA: 0x001FC34D File Offset: 0x001FA54D
		public virtual void RemovePointsWithoutCellsOff()
		{
			vtkCleanUnstructuredGrid.vtkCleanUnstructuredGrid_RemovePointsWithoutCellsOff_22(base.GetCppThis());
		}

		// Token: 0x0601692E RID: 92462
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCleanUnstructuredGrid_RemovePointsWithoutCellsOn_23(HandleRef pThis);

		/// <summary>
		/// Set/Get whether to remove points that do not
		/// have any cells associated with it.
		/// Default is false
		/// </summary>
		// Token: 0x0601692F RID: 92463 RVA: 0x001FC35C File Offset: 0x001FA55C
		public virtual void RemovePointsWithoutCellsOn()
		{
			vtkCleanUnstructuredGrid.vtkCleanUnstructuredGrid_RemovePointsWithoutCellsOn_23(base.GetCppThis());
		}

		// Token: 0x06016930 RID: 92464
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCleanUnstructuredGrid_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016931 RID: 92465 RVA: 0x001FC36C File Offset: 0x001FA56C
		public new static vtkCleanUnstructuredGrid SafeDownCast(vtkObjectBase o)
		{
			vtkCleanUnstructuredGrid vtkCleanUnstructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCleanUnstructuredGrid.vtkCleanUnstructuredGrid_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCleanUnstructuredGrid = (vtkCleanUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCleanUnstructuredGrid.Register(null);
				}
			}
			return vtkCleanUnstructuredGrid;
		}

		// Token: 0x06016932 RID: 92466
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCleanUnstructuredGrid_SetAbsoluteTolerance_25(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify tolerance in absolute terms. Default is 1.0.
		/// </summary>
		// Token: 0x06016933 RID: 92467 RVA: 0x001FC3EB File Offset: 0x001FA5EB
		public virtual void SetAbsoluteTolerance(double _arg)
		{
			vtkCleanUnstructuredGrid.vtkCleanUnstructuredGrid_SetAbsoluteTolerance_25(base.GetCppThis(), _arg);
		}

		// Token: 0x06016934 RID: 92468
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCleanUnstructuredGrid_SetLocator_26(HandleRef pThis, HandleRef locator);

		/// <summary>
		/// Set/Get a spatial locator for speeding the search process. By
		/// default an instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x06016935 RID: 92469 RVA: 0x001FC3FC File Offset: 0x001FA5FC
		public virtual void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkCleanUnstructuredGrid.vtkCleanUnstructuredGrid_SetLocator_26(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		// Token: 0x06016936 RID: 92470
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCleanUnstructuredGrid_SetOutputPointsPrecision_27(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06016937 RID: 92471 RVA: 0x001FC42B File Offset: 0x001FA62B
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkCleanUnstructuredGrid.vtkCleanUnstructuredGrid_SetOutputPointsPrecision_27(base.GetCppThis(), _arg);
		}

		// Token: 0x06016938 RID: 92472
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCleanUnstructuredGrid_SetPointDataWeighingStrategy_28(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the strategy used to weigh point data on merging points
		///
		/// Possibilities:
		/// - FIRST_POINT (int(0), default): the point with the lowest index imposes its data on to the
		/// merged point
		/// - AVERAGING (int(1)): a number average is performed on all the duplicate points
		/// - SPATIAL_DENSITY (int(2)): an average by attached cell volume (i.e. for every cell the point
		/// is connected to sum cell_volume/number_cell_points) is performed on the point data
		/// </summary>
		// Token: 0x06016939 RID: 92473 RVA: 0x001FC43B File Offset: 0x001FA63B
		public virtual void SetPointDataWeighingStrategy(int _arg)
		{
			vtkCleanUnstructuredGrid.vtkCleanUnstructuredGrid_SetPointDataWeighingStrategy_28(base.GetCppThis(), _arg);
		}

		// Token: 0x0601693A RID: 92474
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCleanUnstructuredGrid_SetRemovePointsWithoutCells_29(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get whether to remove points that do not
		/// have any cells associated with it.
		/// Default is false
		/// </summary>
		// Token: 0x0601693B RID: 92475 RVA: 0x001FC44B File Offset: 0x001FA64B
		public virtual void SetRemovePointsWithoutCells(bool _arg)
		{
			vtkCleanUnstructuredGrid.vtkCleanUnstructuredGrid_SetRemovePointsWithoutCells_29(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0601693C RID: 92476
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCleanUnstructuredGrid_SetTolerance_30(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify tolerance in terms of fraction of bounding box length.
		/// Default is 0.0.
		/// </summary>
		// Token: 0x0601693D RID: 92477 RVA: 0x001FC463 File Offset: 0x001FA663
		public virtual void SetTolerance(double _arg)
		{
			vtkCleanUnstructuredGrid.vtkCleanUnstructuredGrid_SetTolerance_30(base.GetCppThis(), _arg);
		}

		// Token: 0x0601693E RID: 92478
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCleanUnstructuredGrid_SetToleranceIsAbsolute_31(HandleRef pThis, byte _arg);

		/// <summary>
		/// By default ToleranceIsAbsolute is false and Tolerance is
		/// a fraction of Bounding box diagonal, if true, AbsoluteTolerance is
		/// used when adding points to locator (merging)
		/// </summary>
		// Token: 0x0601693F RID: 92479 RVA: 0x001FC473 File Offset: 0x001FA673
		public virtual void SetToleranceIsAbsolute(bool _arg)
		{
			vtkCleanUnstructuredGrid.vtkCleanUnstructuredGrid_SetToleranceIsAbsolute_31(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06016940 RID: 92480
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCleanUnstructuredGrid_ToleranceIsAbsoluteOff_32(HandleRef pThis);

		/// <summary>
		/// By default ToleranceIsAbsolute is false and Tolerance is
		/// a fraction of Bounding box diagonal, if true, AbsoluteTolerance is
		/// used when adding points to locator (merging)
		/// </summary>
		// Token: 0x06016941 RID: 92481 RVA: 0x001FC48B File Offset: 0x001FA68B
		public virtual void ToleranceIsAbsoluteOff()
		{
			vtkCleanUnstructuredGrid.vtkCleanUnstructuredGrid_ToleranceIsAbsoluteOff_32(base.GetCppThis());
		}

		// Token: 0x06016942 RID: 92482
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCleanUnstructuredGrid_ToleranceIsAbsoluteOn_33(HandleRef pThis);

		/// <summary>
		/// By default ToleranceIsAbsolute is false and Tolerance is
		/// a fraction of Bounding box diagonal, if true, AbsoluteTolerance is
		/// used when adding points to locator (merging)
		/// </summary>
		// Token: 0x06016943 RID: 92483 RVA: 0x001FC49A File Offset: 0x001FA69A
		public virtual void ToleranceIsAbsoluteOn()
		{
			vtkCleanUnstructuredGrid.vtkCleanUnstructuredGrid_ToleranceIsAbsoluteOn_33(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400195A RID: 6490
		public new const string MRFullTypeName = "Kitware.VTK.vtkCleanUnstructuredGrid";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400195B RID: 6491
		public new static readonly string MRClassNameKey = "class vtkCleanUnstructuredGrid";

		/// <summary>
		/// Set/Get the strategy used to weigh point data on merging points
		///
		/// Possibilities:
		/// - FIRST_POINT (int(0), default): the point with the lowest index imposes its data on to the
		/// merged point
		/// - AVERAGING (int(1)): a number average is performed on all the duplicate points
		/// - SPATIAL_DENSITY (int(2)): an average by attached cell volume (i.e. for every cell the point
		/// is connected to sum cell_volume/number_cell_points) is performed on the point data
		/// </summary>
		// Token: 0x0200087F RID: 2175
		public enum DataWeighingType
		{
			/// <summary>enum member</summary>
			// Token: 0x0400195D RID: 6493
			AVERAGING = 1,
			/// <summary>enum member</summary>
			// Token: 0x0400195E RID: 6494
			FIRST_POINT = 0,
			/// <summary>enum member</summary>
			// Token: 0x0400195F RID: 6495
			NUMBER_OF_WEIGHING_TYPES = 3,
			/// <summary>enum member</summary>
			// Token: 0x04001960 RID: 6496
			SPATIAL_DENSITY = 2
		}
	}
}
