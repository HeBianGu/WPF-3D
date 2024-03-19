using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAbstractInterpolatedVelocityField
	/// </summary>
	/// <remarks>
	///    An abstract class for
	///  obtaining the interpolated velocity values at a point
	///
	///
	///  vtkAbstractInterpolatedVelocityField acts as a continuous velocity field
	///  by performing cell interpolation on the underlying vtkDataSet (or in the
	///  case of vtkCompositeInterpolatedVelocityField,
	///  vtkCompositeDataSets). This is an abstract sub-class of vtkFunctionSet,
	///  NumberOfIndependentVariables = 4 (x,y,z,t) and NumberOfFunctions = 3
	///  (u,v,w). With a brute-force scheme, every time an evaluation is
	///  performed, the target cell containing point (x,y,z) needs to be found by
	///  calling FindCell(); however vtkAbstractInterpolatedVelocityField uses
	///  locators to accelerate this operation via an instance of
	///  vtkFindCellStrategy. Even with the use of locators, the cost of the find
	///  cell operation can be large, hence this class performs local caching to
	///  reduce the number of invocations of FindCell(). As a result, this class
	///  is not thread safe as it contains local state (such as the cache
	///  information). Writing a threaded operations requires separate instances of
	///  vtkAbstractInterpolatedVelocityField for each thread.
	///
	///  For vtkCompositeInterpolatedVelocityField with CLOSEST_POINT strategy,
	///  level #0 begins with intra-cell caching.
	///  Specifically if the previous cell is valid and the next point is still in
	///  it ( i.e., vtkCell::EvaluatePosition() returns 1, coupled with newly created
	///  parametric coordinates &amp; weights ), the function values can be interpolated
	///  and only vtkCell::EvaluatePosition() is invoked. If this fails, then level #1
	///  follows by inter-cell search for the target cell that contains the next point.
	///  By an inter-cell search, the previous cell provides an important clue or serves
	///  as an immediate neighbor to aid in locating the target cell via vtkPointSet::
	///  FindCell(). If this still fails, a global cell location / search is invoked via
	///  vtkFindCellStrategy. Finally, if this operation fails, the streamline is
	///  considered terminated.
	///
	///  Note the particular find cell strategy employed can affect the behavior
	///  of this class. If the strategy involved using a point locator (e.g.,
	///  vtkStaticPointLocator or vtkPointLocator via vtkClosestPointStrategy or
	///  vtkClosestNPointsStrategy) the performance of the class improves to the
	///  detriment of robustness. Using a cell locator (e.g., vtkStaticCellLocator
	///  or vtkCellLocator via vtkCellLocatorStrategy) improves robustness at some
	///  cost to performance. Originally, these different behaviors (i.e., using
	///  different locators) was codified into different subclasses of
	///  vtkAbstractInterpolatedVelocityField.
	///
	///  Note that topologically structured classes such as vtkImageData and
	///  vtkRectilinearGrid are able to provide fast robust cell location. Hence
	///  the specified find cell strategy is only applicable to subclasses of
	///  vtkPointSet (such as vtkUnstructuredGrid).
	///
	///
	/// @warning
	///  vtkAbstractInterpolatedVelocityField is not thread safe. A new instance
	///  should be created by each thread.
	///
	/// </remarks>
	/// <seealso>
	///
	///  vtkCompositeInterpolatedVelocityField vtkAMRInterpolatedVelocityField
	///  vtkGenericInterpolatedVelocityField vtkCachingInterpolatedVelocityField
	///  vtkTemporalInterpolatedVelocityField vtkFunctionSet vtkStreamTracer
	///  vtkFindCellStrategy
	/// </seealso>
	// Token: 0x020004A6 RID: 1190
	public abstract class vtkAbstractInterpolatedVelocityField : vtkFunctionSet
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600DB09 RID: 56073 RVA: 0x0012FD3B File Offset: 0x0012DF3B
		static vtkAbstractInterpolatedVelocityField()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAbstractInterpolatedVelocityField.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAbstractInterpolatedVelocityField"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600DB0A RID: 56074 RVA: 0x0012FD63 File Offset: 0x0012DF63
		public vtkAbstractInterpolatedVelocityField(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600DB0B RID: 56075 RVA: 0x0012FD71 File Offset: 0x0012DF71
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600DB0C RID: 56076
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractInterpolatedVelocityField_ClearLastCellId_01(HandleRef pThis);

		/// <summary>
		/// Set the last cell id to -1 to incur a global cell search for the next point.
		/// </summary>
		// Token: 0x0600DB0D RID: 56077 RVA: 0x0012FD7C File Offset: 0x0012DF7C
		public void ClearLastCellId()
		{
			vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_ClearLastCellId_01(base.GetCppThis());
		}

		// Token: 0x0600DB0E RID: 56078
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractInterpolatedVelocityField_CopyParameters_02(HandleRef pThis, HandleRef from);

		/// <summary>
		/// Copy essential parameters between instances of this class. This
		/// generally is used to copy from instance prototype to another, or to copy
		/// interpolators between thread instances.  Sub-classes can contribute to
		/// the parameter copying process via chaining.
		/// </summary>
		// Token: 0x0600DB0F RID: 56079 RVA: 0x0012FD8C File Offset: 0x0012DF8C
		public virtual void CopyParameters(vtkAbstractInterpolatedVelocityField from)
		{
			vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_CopyParameters_02(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis());
		}

		// Token: 0x0600DB10 RID: 56080
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractInterpolatedVelocityField_FunctionValues_03(HandleRef pThis, IntPtr x, IntPtr f);

		/// <summary>
		/// Evaluate the velocity field f at point (x, y, z).
		/// </summary>
		// Token: 0x0600DB11 RID: 56081 RVA: 0x0012FDBC File Offset: 0x0012DFBC
		public override int FunctionValues(IntPtr x, IntPtr f)
		{
			return vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_FunctionValues_03(base.GetCppThis(), x, f);
		}

		// Token: 0x0600DB12 RID: 56082
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractInterpolatedVelocityField_GetCacheHit_04(HandleRef pThis);

		/// <summary>
		/// Get the caching statistics. CacheHit refers to the number of level #0 cache
		/// hits while CacheMiss is the number of level #0 cache misses.
		/// </summary>
		// Token: 0x0600DB13 RID: 56083 RVA: 0x0012FDE0 File Offset: 0x0012DFE0
		public virtual int GetCacheHit()
		{
			return vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_GetCacheHit_04(base.GetCppThis());
		}

		// Token: 0x0600DB14 RID: 56084
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractInterpolatedVelocityField_GetCacheMiss_05(HandleRef pThis);

		/// <summary>
		/// Get the caching statistics. CacheHit refers to the number of level #0 cache
		/// hits while CacheMiss is the number of level #0 cache misses.
		/// </summary>
		// Token: 0x0600DB15 RID: 56085 RVA: 0x0012FE00 File Offset: 0x0012E000
		public virtual int GetCacheMiss()
		{
			return vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_GetCacheMiss_05(base.GetCppThis());
		}

		// Token: 0x0600DB16 RID: 56086
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAbstractInterpolatedVelocityField_GetCaching_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the caching flag. If this flag is turned ON, there are two levels
		/// of caching for when the strategy is CLOSEST_POINT and one level of caching
		/// when the strategy is CELL_LOCATOR. Otherwise a global cell location is always
		/// invoked for evaluating the function values at any point.
		/// </summary>
		// Token: 0x0600DB17 RID: 56087 RVA: 0x0012FE20 File Offset: 0x0012E020
		public virtual bool GetCaching()
		{
			return vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_GetCaching_06(base.GetCppThis()) != 0;
		}

		// Token: 0x0600DB18 RID: 56088
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractInterpolatedVelocityField_GetFindCellStrategy_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set / get the strategy used to perform the FindCell() operation. This
		/// strategy is used when operating on vtkPointSet subclasses. Note if the
		/// input is a composite dataset then the strategy will be used to clone
		/// one strategy per leaf dataset.
		/// </summary>
		// Token: 0x0600DB19 RID: 56089 RVA: 0x0012FE48 File Offset: 0x0012E048
		public virtual vtkFindCellStrategy GetFindCellStrategy()
		{
			vtkFindCellStrategy vtkFindCellStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_GetFindCellStrategy_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFindCellStrategy = (vtkFindCellStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFindCellStrategy.Register(null);
				}
			}
			return vtkFindCellStrategy;
		}

		// Token: 0x0600DB1A RID: 56090
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAbstractInterpolatedVelocityField_GetForceSurfaceTangentVector_08(HandleRef pThis);

		/// <summary>
		/// If set to true, the first three point of the cell will be used to compute a normal to the cell,
		/// this normal will then be removed from the vorticity so the resulting vector in tangent to the
		/// cell.
		/// </summary>
		// Token: 0x0600DB1B RID: 56091 RVA: 0x0012FEB8 File Offset: 0x0012E0B8
		public virtual bool GetForceSurfaceTangentVector()
		{
			return vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_GetForceSurfaceTangentVector_08(base.GetCppThis()) != 0;
		}

		// Token: 0x0600DB1C RID: 56092
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractInterpolatedVelocityField_GetInitializationState_09(HandleRef pThis);

		/// <summary>
		/// The Initialize() method is used to build and cache supporting structures
		/// (such as locators) which are used when operating on the interpolated
		/// velocity field. This method is needed mainly to deal with thread safety
		/// issues; i.e., these supporting structures must be built at the right
		/// time to avoid race conditions. Currently this method is used by
		/// vtkStreamTracer (and related classes) which process composite datasets
		/// (in the future other dataset types may be supported). Also, a
		/// initialization strategy can be specified which controls how the
		/// initialization process functions (this is a API placeholder for the
		/// future). Note that some subclasses may override the initialize
		/// method (via SelfInitialize()) because they have special methods of
		/// setting up the interpolated velocity field.
		/// </summary>
		// Token: 0x0600DB1D RID: 56093 RVA: 0x0012FEE0 File Offset: 0x0012E0E0
		public virtual int GetInitializationState()
		{
			return vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_GetInitializationState_09(base.GetCppThis());
		}

		// Token: 0x0600DB1E RID: 56094
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractInterpolatedVelocityField_GetLastCellId_10(HandleRef pThis);

		/// <summary>
		/// Get/Set the id of the cell cached from last evaluation.
		/// </summary>
		// Token: 0x0600DB1F RID: 56095 RVA: 0x0012FF00 File Offset: 0x0012E100
		public virtual long GetLastCellId()
		{
			return vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_GetLastCellId_10(base.GetCppThis());
		}

		// Token: 0x0600DB20 RID: 56096
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractInterpolatedVelocityField_GetLastDataSet_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the caching statistics. CacheHit refers to the number of level #0 cache
		/// hits while CacheMiss is the number of level #0 cache misses.
		/// </summary>
		// Token: 0x0600DB21 RID: 56097 RVA: 0x0012FF20 File Offset: 0x0012E120
		public virtual vtkDataSet GetLastDataSet()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_GetLastDataSet_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		// Token: 0x0600DB22 RID: 56098
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractInterpolatedVelocityField_GetLastLocalCoordinates_12(HandleRef pThis, IntPtr pcoords);

		/// <summary>
		/// Get the interpolation weights cached from last evaluation. Return 1 if the
		/// cached cell is valid and 0 otherwise.
		/// </summary>
		// Token: 0x0600DB23 RID: 56099 RVA: 0x0012FF90 File Offset: 0x0012E190
		public int GetLastLocalCoordinates(IntPtr pcoords)
		{
			return vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_GetLastLocalCoordinates_12(base.GetCppThis(), pcoords);
		}

		// Token: 0x0600DB24 RID: 56100
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractInterpolatedVelocityField_GetLastWeights_13(HandleRef pThis, IntPtr w);

		/// <summary>
		/// Get the interpolation weights cached from last evaluation. Return 1 if the
		/// cached cell is valid and 0 otherwise.
		/// </summary>
		// Token: 0x0600DB25 RID: 56101 RVA: 0x0012FFB0 File Offset: 0x0012E1B0
		public int GetLastWeights(IntPtr w)
		{
			return vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_GetLastWeights_13(base.GetCppThis(), w);
		}

		// Token: 0x0600DB26 RID: 56102
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAbstractInterpolatedVelocityField_GetNormalizeVector_14(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag indicating vector post-normalization (following vector
		/// interpolation). Vector post-normalization is required to avoid the
		/// 'curve-overshooting' problem (caused by high velocity magnitude) that
		/// occurs when Cell-Length is used as the step size unit (particularly the
		/// Minimum step size unit). Furthermore, it is required by RK45 to achieve,
		/// as expected, high numerical accuracy (or high smoothness of flow lines)
		/// through adaptive step sizing. Note this operation is performed (when
		/// NormalizeVector TRUE) right after vector interpolation such that the
		/// differing amount of contribution of each node (of a cell) to the
		/// resulting direction of the interpolated vector, due to the possibly
		/// significantly-differing velocity magnitude values at the nodes (which is
		/// the case with large cells), can be reflected as is. Also note that this
		/// flag needs to be turned to FALSE after vtkInitialValueProblemSolver::
		/// ComputeNextStep() as subsequent operations, e.g., vorticity computation,
		/// may need non-normalized vectors.
		/// </summary>
		// Token: 0x0600DB27 RID: 56103 RVA: 0x0012FFD0 File Offset: 0x0012E1D0
		public virtual bool GetNormalizeVector()
		{
			return vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_GetNormalizeVector_14(base.GetCppThis()) != 0;
		}

		// Token: 0x0600DB28 RID: 56104
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractInterpolatedVelocityField_GetNumberOfGenerationsFromBase_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for obtaining type information and printing the object state.
		/// </summary>
		// Token: 0x0600DB29 RID: 56105 RVA: 0x0012FFF8 File Offset: 0x0012E1F8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_GetNumberOfGenerationsFromBase_15(base.GetCppThis(), type);
		}

		// Token: 0x0600DB2A RID: 56106
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractInterpolatedVelocityField_GetNumberOfGenerationsFromBaseType_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for obtaining type information and printing the object state.
		/// </summary>
		// Token: 0x0600DB2B RID: 56107 RVA: 0x00130018 File Offset: 0x0012E218
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_GetNumberOfGenerationsFromBaseType_16(type);
		}

		// Token: 0x0600DB2C RID: 56108
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAbstractInterpolatedVelocityField_GetSurfaceDataset_17(HandleRef pThis);

		/// <summary>
		/// If set to true, cell within tolerance factor will always be found, except for edges.
		/// </summary>
		// Token: 0x0600DB2D RID: 56109 RVA: 0x00130034 File Offset: 0x0012E234
		public virtual bool GetSurfaceDataset()
		{
			return vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_GetSurfaceDataset_17(base.GetCppThis()) != 0;
		}

		// Token: 0x0600DB2E RID: 56110
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractInterpolatedVelocityField_GetVectorsSelection_18(HandleRef pThis);

		/// <summary>
		/// Get/Set the name of a specified vector array. By default it is nullptr, with
		/// the active vector array for use.
		/// </summary>
		// Token: 0x0600DB2F RID: 56111 RVA: 0x0013005C File Offset: 0x0012E25C
		public virtual string GetVectorsSelection()
		{
			string s = Marshal.PtrToStringAnsi(vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_GetVectorsSelection_18(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600DB30 RID: 56112
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractInterpolatedVelocityField_GetVectorsType_19(HandleRef pThis);

		/// <summary>
		/// Get/Set the name of a specified vector array. By default it is nullptr, with
		/// the active vector array for use.
		/// </summary>
		// Token: 0x0600DB31 RID: 56113 RVA: 0x00130098 File Offset: 0x0012E298
		public virtual int GetVectorsType()
		{
			return vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_GetVectorsType_19(base.GetCppThis());
		}

		// Token: 0x0600DB32 RID: 56114
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractInterpolatedVelocityField_Initialize_20(HandleRef pThis, HandleRef compDS, int initStrategy);

		/// <summary>
		/// The Initialize() method is used to build and cache supporting structures
		/// (such as locators) which are used when operating on the interpolated
		/// velocity field. This method is needed mainly to deal with thread safety
		/// issues; i.e., these supporting structures must be built at the right
		/// time to avoid race conditions. Currently this method is used by
		/// vtkStreamTracer (and related classes) which process composite datasets
		/// (in the future other dataset types may be supported). Also, a
		/// initialization strategy can be specified which controls how the
		/// initialization process functions (this is a API placeholder for the
		/// future). Note that some subclasses may override the initialize
		/// method (via SelfInitialize()) because they have special methods of
		/// setting up the interpolated velocity field.
		/// </summary>
		// Token: 0x0600DB33 RID: 56115 RVA: 0x001300B8 File Offset: 0x0012E2B8
		public virtual void Initialize(vtkCompositeDataSet compDS, int initStrategy)
		{
			vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_Initialize_20(base.GetCppThis(), (compDS == null) ? default(HandleRef) : compDS.GetCppThis(), initStrategy);
		}

		// Token: 0x0600DB34 RID: 56116
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractInterpolatedVelocityField_IsA_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for obtaining type information and printing the object state.
		/// </summary>
		// Token: 0x0600DB35 RID: 56117 RVA: 0x001300E8 File Offset: 0x0012E2E8
		public override int IsA(string type)
		{
			return vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_IsA_21(base.GetCppThis(), type);
		}

		// Token: 0x0600DB36 RID: 56118
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractInterpolatedVelocityField_IsTypeOf_22([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for obtaining type information and printing the object state.
		/// </summary>
		// Token: 0x0600DB37 RID: 56119 RVA: 0x00130108 File Offset: 0x0012E308
		public new static int IsTypeOf(string type)
		{
			return vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_IsTypeOf_22(type);
		}

		// Token: 0x0600DB38 RID: 56120
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractInterpolatedVelocityField_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for obtaining type information and printing the object state.
		/// </summary>
		// Token: 0x0600DB39 RID: 56121 RVA: 0x00130124 File Offset: 0x0012E324
		public new vtkAbstractInterpolatedVelocityField NewInstance()
		{
			vtkAbstractInterpolatedVelocityField result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_NewInstance_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600DB3A RID: 56122
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractInterpolatedVelocityField_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for obtaining type information and printing the object state.
		/// </summary>
		// Token: 0x0600DB3B RID: 56123 RVA: 0x00130180 File Offset: 0x0012E380
		public new static vtkAbstractInterpolatedVelocityField SafeDownCast(vtkObjectBase o)
		{
			vtkAbstractInterpolatedVelocityField vtkAbstractInterpolatedVelocityField = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractInterpolatedVelocityField = (vtkAbstractInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractInterpolatedVelocityField.Register(null);
				}
			}
			return vtkAbstractInterpolatedVelocityField;
		}

		// Token: 0x0600DB3C RID: 56124
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractInterpolatedVelocityField_SelectVectors_25(HandleRef pThis, int fieldAssociation, [MarshalAs(UnmanagedType.LPUTF8Str)] string fieldName);

		/// <summary>
		/// the association type (see vtkDataObject::FieldAssociations)
		/// and the name of the velocity data field
		/// </summary>
		// Token: 0x0600DB3D RID: 56125 RVA: 0x001301FF File Offset: 0x0012E3FF
		public void SelectVectors(int fieldAssociation, string fieldName)
		{
			vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_SelectVectors_25(base.GetCppThis(), fieldAssociation, fieldName);
		}

		// Token: 0x0600DB3E RID: 56126
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractInterpolatedVelocityField_SetCaching_26(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get the caching flag. If this flag is turned ON, there are two levels
		/// of caching for when the strategy is CLOSEST_POINT and one level of caching
		/// when the strategy is CELL_LOCATOR. Otherwise a global cell location is always
		/// invoked for evaluating the function values at any point.
		/// </summary>
		// Token: 0x0600DB3F RID: 56127 RVA: 0x00130210 File Offset: 0x0012E410
		public virtual void SetCaching(bool _arg)
		{
			vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_SetCaching_26(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600DB40 RID: 56128
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractInterpolatedVelocityField_SetFindCellStrategy_27(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set / get the strategy used to perform the FindCell() operation. This
		/// strategy is used when operating on vtkPointSet subclasses. Note if the
		/// input is a composite dataset then the strategy will be used to clone
		/// one strategy per leaf dataset.
		/// </summary>
		// Token: 0x0600DB41 RID: 56129 RVA: 0x00130228 File Offset: 0x0012E428
		public virtual void SetFindCellStrategy(vtkFindCellStrategy arg0)
		{
			vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_SetFindCellStrategy_27(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600DB42 RID: 56130
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractInterpolatedVelocityField_SetForceSurfaceTangentVector_28(HandleRef pThis, byte _arg);

		/// <summary>
		/// If set to true, the first three point of the cell will be used to compute a normal to the cell,
		/// this normal will then be removed from the vorticity so the resulting vector in tangent to the
		/// cell.
		/// </summary>
		// Token: 0x0600DB43 RID: 56131 RVA: 0x00130257 File Offset: 0x0012E457
		public virtual void SetForceSurfaceTangentVector(bool _arg)
		{
			vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_SetForceSurfaceTangentVector_28(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600DB44 RID: 56132
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractInterpolatedVelocityField_SetLastCellId_29(HandleRef pThis, long c);

		/// <summary>
		/// Get/Set the id of the cell cached from last evaluation.
		/// </summary>
		// Token: 0x0600DB45 RID: 56133 RVA: 0x0013026F File Offset: 0x0012E46F
		public virtual void SetLastCellId(long c)
		{
			vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_SetLastCellId_29(base.GetCppThis(), c);
		}

		// Token: 0x0600DB46 RID: 56134
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractInterpolatedVelocityField_SetLastCellId_30(HandleRef pThis, long c, int dataindex);

		/// <summary>
		/// Set the id of the most recently visited cell of a dataset.
		/// </summary>
		// Token: 0x0600DB47 RID: 56135 RVA: 0x0013027F File Offset: 0x0012E47F
		public virtual void SetLastCellId(long c, int dataindex)
		{
			vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_SetLastCellId_30(base.GetCppThis(), c, dataindex);
		}

		// Token: 0x0600DB48 RID: 56136
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractInterpolatedVelocityField_SetNormalizeVector_31(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get the flag indicating vector post-normalization (following vector
		/// interpolation). Vector post-normalization is required to avoid the
		/// 'curve-overshooting' problem (caused by high velocity magnitude) that
		/// occurs when Cell-Length is used as the step size unit (particularly the
		/// Minimum step size unit). Furthermore, it is required by RK45 to achieve,
		/// as expected, high numerical accuracy (or high smoothness of flow lines)
		/// through adaptive step sizing. Note this operation is performed (when
		/// NormalizeVector TRUE) right after vector interpolation such that the
		/// differing amount of contribution of each node (of a cell) to the
		/// resulting direction of the interpolated vector, due to the possibly
		/// significantly-differing velocity magnitude values at the nodes (which is
		/// the case with large cells), can be reflected as is. Also note that this
		/// flag needs to be turned to FALSE after vtkInitialValueProblemSolver::
		/// ComputeNextStep() as subsequent operations, e.g., vorticity computation,
		/// may need non-normalized vectors.
		/// </summary>
		// Token: 0x0600DB49 RID: 56137 RVA: 0x00130290 File Offset: 0x0012E490
		public virtual void SetNormalizeVector(bool _arg)
		{
			vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_SetNormalizeVector_31(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600DB4A RID: 56138
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractInterpolatedVelocityField_SetSurfaceDataset_32(HandleRef pThis, byte _arg);

		/// <summary>
		/// If set to true, cell within tolerance factor will always be found, except for edges.
		/// </summary>
		// Token: 0x0600DB4B RID: 56139 RVA: 0x001302A8 File Offset: 0x0012E4A8
		public virtual void SetSurfaceDataset(bool _arg)
		{
			vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_SetSurfaceDataset_32(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001001 RID: 4097
		public new const string MRFullTypeName = "Kitware.VTK.vtkAbstractInterpolatedVelocityField";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001002 RID: 4098
		public new static readonly string MRClassNameKey = "class vtkAbstractInterpolatedVelocityField";

		/// <summary>
		/// Standard methods for obtaining type information and printing the object state.
		/// </summary>
		// Token: 0x020004A7 RID: 1191
		public enum VelocityFieldInitializationState
		{
			/// <summary>enum member</summary>
			// Token: 0x04001004 RID: 4100
			INITIALIZE_ALL_DATASETS = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001005 RID: 4101
			NOT_INITIALIZED = 0,
			/// <summary>enum member</summary>
			// Token: 0x04001006 RID: 4102
			SELF_INITIALIZE = 2
		}
	}
}
