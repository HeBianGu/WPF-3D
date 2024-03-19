using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkProbeFilter
	/// </summary>
	/// <remarks>
	///    sample data values at specified point locations
	///
	/// vtkProbeFilter is a filter that computes point attributes (e.g., scalars,
	/// vectors, etc.) at specified point positions. The filter has two inputs:
	/// the Input and Source. The Input geometric structure is passed through the
	/// filter. The point attributes are computed at the Input point positions
	/// by interpolating into the source data. For example, we can compute data
	/// values on a plane (plane specified as Input) from a volume (Source).
	/// The cell data of the source data is copied to the output based on in
	/// which source cell each input point is. If an array of the same name exists
	/// both in source's point and cell data, only the one from the point data is
	/// probed.
	///
	/// This filter can be used to resample data, or convert one dataset form into
	/// another. For example, an unstructured grid (vtkUnstructuredGrid) can be
	/// probed with a volume (three-dimensional vtkImageData), and then volume
	/// rendering techniques can be used to visualize the results. Another example:
	/// a line or curve can be used to probe data to produce x-y plots along
	/// that line or curve.
	///
	/// @warning
	/// A critical algorithmic component of vtkProbeFilter is the manner in which
	/// it finds the cell containing a probe point. By default, the
	/// vtkDataSet::FindCell() method is used, which in turn uses a
	/// vtkPointLocator to perform an accelerated search. However, using a
	/// vtkPointLocator may fail to identify an enclosing cell in some cases. A
	/// more robust but slower approach is to use a vtkCellLocator to perform the
	/// the FindCell() operation (via specification of the
	/// CellLocatorPrototype). Finally, more advanced searches can be configured
	/// by specifying an instance of vtkFindCellStrategy. (Note: image data
	/// probing never uses a locator since finding a containing cell is a simple,
	/// fast operation. This specifying a vtkFindCellStrategy or cell locator
	/// prototype has no effect.)
	///
	/// @warning
	/// The vtkProbeFilter, once it finds the cell containing a query point, uses
	/// the cell's interpolation functions to perform the interpolate / compute
	/// the point attributes. Note that other interpolation processes with
	/// different kernels are available: vtkPointInterpolator and
	/// vtkSPHInterpolator. vtkPointInterpolator supports a variety of generalized
	/// kernels, while vtkSPHInterpolator supports a variety of SPH interpolation
	/// kernels.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkFindCellStrategy vtkPointLocator vtkCellLocator vtkStaticPointLocator
	/// vtkStaticCellLocator vtkPointInterpolator vtkSPHInterpolator
	/// </seealso>
	// Token: 0x02000526 RID: 1318
	public class vtkProbeFilter : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600EBAB RID: 60331 RVA: 0x0014898F File Offset: 0x00146B8F
		static vtkProbeFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkProbeFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkProbeFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600EBAC RID: 60332 RVA: 0x001489B7 File Offset: 0x00146BB7
		public vtkProbeFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600EBAD RID: 60333
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProbeFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EBAE RID: 60334 RVA: 0x001489C8 File Offset: 0x00146BC8
		public new static vtkProbeFilter New()
		{
			vtkProbeFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProbeFilter.vtkProbeFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProbeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EBAF RID: 60335 RVA: 0x00148A1C File Offset: 0x00146C1C
		public vtkProbeFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkProbeFilter.vtkProbeFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600EBB0 RID: 60336 RVA: 0x00148A60 File Offset: 0x00146C60
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600EBB1 RID: 60337
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProbeFilter_CategoricalDataOff_01(HandleRef pThis);

		/// <summary>
		/// Control whether the source point data is to be treated as categorical. If
		/// the data is categorical, then the resultant data will be determined by
		/// a nearest neighbor interpolation scheme.
		/// </summary>
		// Token: 0x0600EBB2 RID: 60338 RVA: 0x00148A6B File Offset: 0x00146C6B
		public virtual void CategoricalDataOff()
		{
			vtkProbeFilter.vtkProbeFilter_CategoricalDataOff_01(base.GetCppThis());
		}

		// Token: 0x0600EBB3 RID: 60339
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProbeFilter_CategoricalDataOn_02(HandleRef pThis);

		/// <summary>
		/// Control whether the source point data is to be treated as categorical. If
		/// the data is categorical, then the resultant data will be determined by
		/// a nearest neighbor interpolation scheme.
		/// </summary>
		// Token: 0x0600EBB4 RID: 60340 RVA: 0x00148A7A File Offset: 0x00146C7A
		public virtual void CategoricalDataOn()
		{
			vtkProbeFilter.vtkProbeFilter_CategoricalDataOn_02(base.GetCppThis());
		}

		// Token: 0x0600EBB5 RID: 60341
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProbeFilter_ComputeToleranceOff_03(HandleRef pThis);

		/// <summary>
		/// Set whether to use the Tolerance field or precompute the tolerance.
		/// When on, the tolerance will be computed and the field
		/// value is ignored. On by default.
		/// </summary>
		// Token: 0x0600EBB6 RID: 60342 RVA: 0x00148A89 File Offset: 0x00146C89
		public virtual void ComputeToleranceOff()
		{
			vtkProbeFilter.vtkProbeFilter_ComputeToleranceOff_03(base.GetCppThis());
		}

		// Token: 0x0600EBB7 RID: 60343
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProbeFilter_ComputeToleranceOn_04(HandleRef pThis);

		/// <summary>
		/// Set whether to use the Tolerance field or precompute the tolerance.
		/// When on, the tolerance will be computed and the field
		/// value is ignored. On by default.
		/// </summary>
		// Token: 0x0600EBB8 RID: 60344 RVA: 0x00148A98 File Offset: 0x00146C98
		public virtual void ComputeToleranceOn()
		{
			vtkProbeFilter.vtkProbeFilter_ComputeToleranceOn_04(base.GetCppThis());
		}

		// Token: 0x0600EBB9 RID: 60345
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProbeFilter_GetCategoricalData_05(HandleRef pThis);

		/// <summary>
		/// Control whether the source point data is to be treated as categorical. If
		/// the data is categorical, then the resultant data will be determined by
		/// a nearest neighbor interpolation scheme.
		/// </summary>
		// Token: 0x0600EBBA RID: 60346 RVA: 0x00148AA8 File Offset: 0x00146CA8
		public virtual int GetCategoricalData()
		{
			return vtkProbeFilter.vtkProbeFilter_GetCategoricalData_05(base.GetCppThis());
		}

		// Token: 0x0600EBBB RID: 60347
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProbeFilter_GetCellLocatorPrototype_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the prototype cell locator to perform the FindCell() operation.
		/// (A prototype is used as an object factory to instantiate an instance of
		/// the prototype to perform the FindCell() operation). If a prototype, and
		/// a vtkFindCellStrategy are not defined, the vtkDataSet::FindCell() is
		/// used. If a vtkFindCellStrategy is not defined, then the prototype is
		/// used.
		/// </summary>
		// Token: 0x0600EBBC RID: 60348 RVA: 0x00148AC8 File Offset: 0x00146CC8
		public virtual vtkAbstractCellLocator GetCellLocatorPrototype()
		{
			vtkAbstractCellLocator vtkAbstractCellLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProbeFilter.vtkProbeFilter_GetCellLocatorPrototype_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractCellLocator = (vtkAbstractCellLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractCellLocator.Register(null);
				}
			}
			return vtkAbstractCellLocator;
		}

		// Token: 0x0600EBBD RID: 60349
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkProbeFilter_GetComputeTolerance_07(HandleRef pThis);

		/// <summary>
		/// Set whether to use the Tolerance field or precompute the tolerance.
		/// When on, the tolerance will be computed and the field
		/// value is ignored. On by default.
		/// </summary>
		// Token: 0x0600EBBE RID: 60350 RVA: 0x00148B38 File Offset: 0x00146D38
		public virtual bool GetComputeTolerance()
		{
			return vtkProbeFilter.vtkProbeFilter_GetComputeTolerance_07(base.GetCppThis()) != 0;
		}

		// Token: 0x0600EBBF RID: 60351
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProbeFilter_GetFindCellStrategy_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set / get the strategy used to perform the FindCell() operation. When
		/// specified, the strategy is used in preference to a cell locator
		/// prototype. When neither a strategy or cell locator prototype is defined,
		/// then the vtkDataSet::FindCell() method is used.
		/// </summary>
		// Token: 0x0600EBC0 RID: 60352 RVA: 0x00148B60 File Offset: 0x00146D60
		public virtual vtkFindCellStrategy GetFindCellStrategy()
		{
			vtkFindCellStrategy vtkFindCellStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProbeFilter.vtkProbeFilter_GetFindCellStrategy_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600EBC1 RID: 60353
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProbeFilter_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EBC2 RID: 60354 RVA: 0x00148BD0 File Offset: 0x00146DD0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkProbeFilter.vtkProbeFilter_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x0600EBC3 RID: 60355
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProbeFilter_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EBC4 RID: 60356 RVA: 0x00148BF0 File Offset: 0x00146DF0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkProbeFilter.vtkProbeFilter_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x0600EBC5 RID: 60357
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProbeFilter_GetPassCellArrays_11(HandleRef pThis);

		/// <summary>
		/// Shallow copy the input cell data arrays to the output.
		/// Off by default.
		/// </summary>
		// Token: 0x0600EBC6 RID: 60358 RVA: 0x00148C0C File Offset: 0x00146E0C
		public virtual int GetPassCellArrays()
		{
			return vtkProbeFilter.vtkProbeFilter_GetPassCellArrays_11(base.GetCppThis());
		}

		// Token: 0x0600EBC7 RID: 60359
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProbeFilter_GetPassFieldArrays_12(HandleRef pThis);

		/// <summary>
		/// Set whether to pass the field-data arrays from the Input i.e. the input
		/// providing the geometry to the output. On by default.
		/// </summary>
		// Token: 0x0600EBC8 RID: 60360 RVA: 0x00148C2C File Offset: 0x00146E2C
		public virtual int GetPassFieldArrays()
		{
			return vtkProbeFilter.vtkProbeFilter_GetPassFieldArrays_12(base.GetCppThis());
		}

		// Token: 0x0600EBC9 RID: 60361
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProbeFilter_GetPassPointArrays_13(HandleRef pThis);

		/// <summary>
		/// Shallow copy the input point data arrays to the output
		/// Off by default.
		/// </summary>
		// Token: 0x0600EBCA RID: 60362 RVA: 0x00148C4C File Offset: 0x00146E4C
		public virtual int GetPassPointArrays()
		{
			return vtkProbeFilter.vtkProbeFilter_GetPassPointArrays_13(base.GetCppThis());
		}

		// Token: 0x0600EBCB RID: 60363
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkProbeFilter_GetSnapToCellWithClosestPoint_14(HandleRef pThis);

		/// <summary>
		/// Set/Get whether to snap to the cell with the closest point, if no cell has been found while
		/// FindCell is executed.
		///
		/// Default is off.
		///
		/// Note: This is useful only when the source is a vtkPointSet.
		/// </summary>
		// Token: 0x0600EBCC RID: 60364 RVA: 0x00148C6C File Offset: 0x00146E6C
		public virtual bool GetSnapToCellWithClosestPoint()
		{
			return vtkProbeFilter.vtkProbeFilter_GetSnapToCellWithClosestPoint_14(base.GetCppThis()) != 0;
		}

		// Token: 0x0600EBCD RID: 60365
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProbeFilter_GetSource_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the data set that will be probed at the input points.
		/// The Input gives the geometry (the points and cells) for the output,
		/// while the Source is probed (interpolated) to generate the scalars,
		/// vectors, etc. for the output points based on the point locations.
		/// </summary>
		// Token: 0x0600EBCE RID: 60366 RVA: 0x00148C94 File Offset: 0x00146E94
		public vtkDataObject GetSource()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProbeFilter.vtkProbeFilter_GetSource_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		// Token: 0x0600EBCF RID: 60367
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProbeFilter_GetSpatialMatch_16(HandleRef pThis);

		/// <summary>
		/// This flag is used only when a piece is requested to update.  By default
		/// the flag is off.  Because no spatial correspondence between input pieces
		/// and source pieces is known, all of the source has to be requested no
		/// matter what piece of the output is requested.  When there is a spatial
		/// correspondence, the user/application can set this flag.  This hint allows
		/// the breakup of the probe operation to be much more efficient.  When piece
		/// m of n is requested for update by the user, then only n of m needs to
		/// be requested of the source.
		/// </summary>
		// Token: 0x0600EBD0 RID: 60368 RVA: 0x00148D04 File Offset: 0x00146F04
		public virtual int GetSpatialMatch()
		{
			return vtkProbeFilter.vtkProbeFilter_GetSpatialMatch_16(base.GetCppThis());
		}

		// Token: 0x0600EBD1 RID: 60369
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProbeFilter_GetTolerance_17(HandleRef pThis);

		/// <summary>
		/// Set the tolerance used to compute whether a point in the
		/// source is in a cell of the input.  This value is only used
		/// if ComputeTolerance is off.
		/// </summary>
		// Token: 0x0600EBD2 RID: 60370 RVA: 0x00148D24 File Offset: 0x00146F24
		public virtual double GetTolerance()
		{
			return vtkProbeFilter.vtkProbeFilter_GetTolerance_17(base.GetCppThis());
		}

		// Token: 0x0600EBD3 RID: 60371
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProbeFilter_GetValidPointMaskArrayName_18(HandleRef pThis);

		/// <summary>
		/// Returns the name of the char array added to the output with values 1 for
		/// valid points and 0 for invalid points.
		/// Set to "vtkValidPointMask" by default.
		/// </summary>
		// Token: 0x0600EBD4 RID: 60372 RVA: 0x00148D44 File Offset: 0x00146F44
		public virtual string GetValidPointMaskArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkProbeFilter.vtkProbeFilter_GetValidPointMaskArrayName_18(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600EBD5 RID: 60373
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProbeFilter_GetValidPoints_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the list of point ids in the output that contain attribute data
		/// interpolated from the source.
		/// </summary>
		// Token: 0x0600EBD6 RID: 60374 RVA: 0x00148D80 File Offset: 0x00146F80
		public vtkIdTypeArray GetValidPoints()
		{
			vtkIdTypeArray vtkIdTypeArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProbeFilter.vtkProbeFilter_GetValidPoints_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600EBD7 RID: 60375
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProbeFilter_IsA_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EBD8 RID: 60376 RVA: 0x00148DF0 File Offset: 0x00146FF0
		public override int IsA(string type)
		{
			return vtkProbeFilter.vtkProbeFilter_IsA_20(base.GetCppThis(), type);
		}

		// Token: 0x0600EBD9 RID: 60377
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProbeFilter_IsTypeOf_21([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EBDA RID: 60378 RVA: 0x00148E10 File Offset: 0x00147010
		public new static int IsTypeOf(string type)
		{
			return vtkProbeFilter.vtkProbeFilter_IsTypeOf_21(type);
		}

		// Token: 0x0600EBDB RID: 60379
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProbeFilter_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EBDC RID: 60380 RVA: 0x00148E2C File Offset: 0x0014702C
		public new vtkProbeFilter NewInstance()
		{
			vtkProbeFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProbeFilter.vtkProbeFilter_NewInstance_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProbeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600EBDD RID: 60381
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProbeFilter_PassCellArraysOff_24(HandleRef pThis);

		/// <summary>
		/// Shallow copy the input cell data arrays to the output.
		/// Off by default.
		/// </summary>
		// Token: 0x0600EBDE RID: 60382 RVA: 0x00148E86 File Offset: 0x00147086
		public virtual void PassCellArraysOff()
		{
			vtkProbeFilter.vtkProbeFilter_PassCellArraysOff_24(base.GetCppThis());
		}

		// Token: 0x0600EBDF RID: 60383
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProbeFilter_PassCellArraysOn_25(HandleRef pThis);

		/// <summary>
		/// Shallow copy the input cell data arrays to the output.
		/// Off by default.
		/// </summary>
		// Token: 0x0600EBE0 RID: 60384 RVA: 0x00148E95 File Offset: 0x00147095
		public virtual void PassCellArraysOn()
		{
			vtkProbeFilter.vtkProbeFilter_PassCellArraysOn_25(base.GetCppThis());
		}

		// Token: 0x0600EBE1 RID: 60385
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProbeFilter_PassFieldArraysOff_26(HandleRef pThis);

		/// <summary>
		/// Set whether to pass the field-data arrays from the Input i.e. the input
		/// providing the geometry to the output. On by default.
		/// </summary>
		// Token: 0x0600EBE2 RID: 60386 RVA: 0x00148EA4 File Offset: 0x001470A4
		public virtual void PassFieldArraysOff()
		{
			vtkProbeFilter.vtkProbeFilter_PassFieldArraysOff_26(base.GetCppThis());
		}

		// Token: 0x0600EBE3 RID: 60387
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProbeFilter_PassFieldArraysOn_27(HandleRef pThis);

		/// <summary>
		/// Set whether to pass the field-data arrays from the Input i.e. the input
		/// providing the geometry to the output. On by default.
		/// </summary>
		// Token: 0x0600EBE4 RID: 60388 RVA: 0x00148EB3 File Offset: 0x001470B3
		public virtual void PassFieldArraysOn()
		{
			vtkProbeFilter.vtkProbeFilter_PassFieldArraysOn_27(base.GetCppThis());
		}

		// Token: 0x0600EBE5 RID: 60389
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProbeFilter_PassPointArraysOff_28(HandleRef pThis);

		/// <summary>
		/// Shallow copy the input point data arrays to the output
		/// Off by default.
		/// </summary>
		// Token: 0x0600EBE6 RID: 60390 RVA: 0x00148EC2 File Offset: 0x001470C2
		public virtual void PassPointArraysOff()
		{
			vtkProbeFilter.vtkProbeFilter_PassPointArraysOff_28(base.GetCppThis());
		}

		// Token: 0x0600EBE7 RID: 60391
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProbeFilter_PassPointArraysOn_29(HandleRef pThis);

		/// <summary>
		/// Shallow copy the input point data arrays to the output
		/// Off by default.
		/// </summary>
		// Token: 0x0600EBE8 RID: 60392 RVA: 0x00148ED1 File Offset: 0x001470D1
		public virtual void PassPointArraysOn()
		{
			vtkProbeFilter.vtkProbeFilter_PassPointArraysOn_29(base.GetCppThis());
		}

		// Token: 0x0600EBE9 RID: 60393
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProbeFilter_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EBEA RID: 60394 RVA: 0x00148EE0 File Offset: 0x001470E0
		public new static vtkProbeFilter SafeDownCast(vtkObjectBase o)
		{
			vtkProbeFilter vtkProbeFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProbeFilter.vtkProbeFilter_SafeDownCast_30((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProbeFilter = (vtkProbeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProbeFilter.Register(null);
				}
			}
			return vtkProbeFilter;
		}

		// Token: 0x0600EBEB RID: 60395
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProbeFilter_SetCategoricalData_31(HandleRef pThis, int _arg);

		/// <summary>
		/// Control whether the source point data is to be treated as categorical. If
		/// the data is categorical, then the resultant data will be determined by
		/// a nearest neighbor interpolation scheme.
		/// </summary>
		// Token: 0x0600EBEC RID: 60396 RVA: 0x00148F5F File Offset: 0x0014715F
		public virtual void SetCategoricalData(int _arg)
		{
			vtkProbeFilter.vtkProbeFilter_SetCategoricalData_31(base.GetCppThis(), _arg);
		}

		// Token: 0x0600EBED RID: 60397
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProbeFilter_SetCellLocatorPrototype_32(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the prototype cell locator to perform the FindCell() operation.
		/// (A prototype is used as an object factory to instantiate an instance of
		/// the prototype to perform the FindCell() operation). If a prototype, and
		/// a vtkFindCellStrategy are not defined, the vtkDataSet::FindCell() is
		/// used. If a vtkFindCellStrategy is not defined, then the prototype is
		/// used.
		/// </summary>
		// Token: 0x0600EBEE RID: 60398 RVA: 0x00148F70 File Offset: 0x00147170
		public virtual void SetCellLocatorPrototype(vtkAbstractCellLocator arg0)
		{
			vtkProbeFilter.vtkProbeFilter_SetCellLocatorPrototype_32(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600EBEF RID: 60399
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProbeFilter_SetComputeTolerance_33(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set whether to use the Tolerance field or precompute the tolerance.
		/// When on, the tolerance will be computed and the field
		/// value is ignored. On by default.
		/// </summary>
		// Token: 0x0600EBF0 RID: 60400 RVA: 0x00148F9F File Offset: 0x0014719F
		public virtual void SetComputeTolerance(bool _arg)
		{
			vtkProbeFilter.vtkProbeFilter_SetComputeTolerance_33(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600EBF1 RID: 60401
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProbeFilter_SetFindCellStrategy_34(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set / get the strategy used to perform the FindCell() operation. When
		/// specified, the strategy is used in preference to a cell locator
		/// prototype. When neither a strategy or cell locator prototype is defined,
		/// then the vtkDataSet::FindCell() method is used.
		/// </summary>
		// Token: 0x0600EBF2 RID: 60402 RVA: 0x00148FB8 File Offset: 0x001471B8
		public virtual void SetFindCellStrategy(vtkFindCellStrategy arg0)
		{
			vtkProbeFilter.vtkProbeFilter_SetFindCellStrategy_34(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600EBF3 RID: 60403
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProbeFilter_SetPassCellArrays_35(HandleRef pThis, int _arg);

		/// <summary>
		/// Shallow copy the input cell data arrays to the output.
		/// Off by default.
		/// </summary>
		// Token: 0x0600EBF4 RID: 60404 RVA: 0x00148FE7 File Offset: 0x001471E7
		public virtual void SetPassCellArrays(int _arg)
		{
			vtkProbeFilter.vtkProbeFilter_SetPassCellArrays_35(base.GetCppThis(), _arg);
		}

		// Token: 0x0600EBF5 RID: 60405
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProbeFilter_SetPassFieldArrays_36(HandleRef pThis, int _arg);

		/// <summary>
		/// Set whether to pass the field-data arrays from the Input i.e. the input
		/// providing the geometry to the output. On by default.
		/// </summary>
		// Token: 0x0600EBF6 RID: 60406 RVA: 0x00148FF7 File Offset: 0x001471F7
		public virtual void SetPassFieldArrays(int _arg)
		{
			vtkProbeFilter.vtkProbeFilter_SetPassFieldArrays_36(base.GetCppThis(), _arg);
		}

		// Token: 0x0600EBF7 RID: 60407
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProbeFilter_SetPassPointArrays_37(HandleRef pThis, int _arg);

		/// <summary>
		/// Shallow copy the input point data arrays to the output
		/// Off by default.
		/// </summary>
		// Token: 0x0600EBF8 RID: 60408 RVA: 0x00149007 File Offset: 0x00147207
		public virtual void SetPassPointArrays(int _arg)
		{
			vtkProbeFilter.vtkProbeFilter_SetPassPointArrays_37(base.GetCppThis(), _arg);
		}

		// Token: 0x0600EBF9 RID: 60409
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProbeFilter_SetSnapToCellWithClosestPoint_38(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get whether to snap to the cell with the closest point, if no cell has been found while
		/// FindCell is executed.
		///
		/// Default is off.
		///
		/// Note: This is useful only when the source is a vtkPointSet.
		/// </summary>
		// Token: 0x0600EBFA RID: 60410 RVA: 0x00149017 File Offset: 0x00147217
		public virtual void SetSnapToCellWithClosestPoint(bool _arg)
		{
			vtkProbeFilter.vtkProbeFilter_SetSnapToCellWithClosestPoint_38(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600EBFB RID: 60411
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProbeFilter_SetSourceConnection_39(HandleRef pThis, HandleRef algOutput);

		/// <summary>
		/// Specify the data set that will be probed at the input points.
		/// The Input gives the geometry (the points and cells) for the output,
		/// while the Source is probed (interpolated) to generate the scalars,
		/// vectors, etc. for the output points based on the point locations.
		/// </summary>
		// Token: 0x0600EBFC RID: 60412 RVA: 0x00149030 File Offset: 0x00147230
		public void SetSourceConnection(vtkAlgorithmOutput algOutput)
		{
			vtkProbeFilter.vtkProbeFilter_SetSourceConnection_39(base.GetCppThis(), (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}

		// Token: 0x0600EBFD RID: 60413
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProbeFilter_SetSourceData_40(HandleRef pThis, HandleRef source);

		/// <summary>
		/// Specify the data set that will be probed at the input points.
		/// The Input gives the geometry (the points and cells) for the output,
		/// while the Source is probed (interpolated) to generate the scalars,
		/// vectors, etc. for the output points based on the point locations.
		/// </summary>
		// Token: 0x0600EBFE RID: 60414 RVA: 0x00149060 File Offset: 0x00147260
		public void SetSourceData(vtkDataObject source)
		{
			vtkProbeFilter.vtkProbeFilter_SetSourceData_40(base.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x0600EBFF RID: 60415
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProbeFilter_SetSpatialMatch_41(HandleRef pThis, int _arg);

		/// <summary>
		/// This flag is used only when a piece is requested to update.  By default
		/// the flag is off.  Because no spatial correspondence between input pieces
		/// and source pieces is known, all of the source has to be requested no
		/// matter what piece of the output is requested.  When there is a spatial
		/// correspondence, the user/application can set this flag.  This hint allows
		/// the breakup of the probe operation to be much more efficient.  When piece
		/// m of n is requested for update by the user, then only n of m needs to
		/// be requested of the source.
		/// </summary>
		// Token: 0x0600EC00 RID: 60416 RVA: 0x0014908F File Offset: 0x0014728F
		public virtual void SetSpatialMatch(int _arg)
		{
			vtkProbeFilter.vtkProbeFilter_SetSpatialMatch_41(base.GetCppThis(), _arg);
		}

		// Token: 0x0600EC01 RID: 60417
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProbeFilter_SetTolerance_42(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the tolerance used to compute whether a point in the
		/// source is in a cell of the input.  This value is only used
		/// if ComputeTolerance is off.
		/// </summary>
		// Token: 0x0600EC02 RID: 60418 RVA: 0x0014909F File Offset: 0x0014729F
		public virtual void SetTolerance(double _arg)
		{
			vtkProbeFilter.vtkProbeFilter_SetTolerance_42(base.GetCppThis(), _arg);
		}

		// Token: 0x0600EC03 RID: 60419
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProbeFilter_SetValidPointMaskArrayName_43(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Returns the name of the char array added to the output with values 1 for
		/// valid points and 0 for invalid points.
		/// Set to "vtkValidPointMask" by default.
		/// </summary>
		// Token: 0x0600EC04 RID: 60420 RVA: 0x001490AF File Offset: 0x001472AF
		public virtual void SetValidPointMaskArrayName(string _arg)
		{
			vtkProbeFilter.vtkProbeFilter_SetValidPointMaskArrayName_43(base.GetCppThis(), _arg);
		}

		// Token: 0x0600EC05 RID: 60421
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProbeFilter_SnapToCellWithClosestPointOff_44(HandleRef pThis);

		/// <summary>
		/// Set/Get whether to snap to the cell with the closest point, if no cell has been found while
		/// FindCell is executed.
		///
		/// Default is off.
		///
		/// Note: This is useful only when the source is a vtkPointSet.
		/// </summary>
		// Token: 0x0600EC06 RID: 60422 RVA: 0x001490BF File Offset: 0x001472BF
		public virtual void SnapToCellWithClosestPointOff()
		{
			vtkProbeFilter.vtkProbeFilter_SnapToCellWithClosestPointOff_44(base.GetCppThis());
		}

		// Token: 0x0600EC07 RID: 60423
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProbeFilter_SnapToCellWithClosestPointOn_45(HandleRef pThis);

		/// <summary>
		/// Set/Get whether to snap to the cell with the closest point, if no cell has been found while
		/// FindCell is executed.
		///
		/// Default is off.
		///
		/// Note: This is useful only when the source is a vtkPointSet.
		/// </summary>
		// Token: 0x0600EC08 RID: 60424 RVA: 0x001490CE File Offset: 0x001472CE
		public virtual void SnapToCellWithClosestPointOn()
		{
			vtkProbeFilter.vtkProbeFilter_SnapToCellWithClosestPointOn_45(base.GetCppThis());
		}

		// Token: 0x0600EC09 RID: 60425
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProbeFilter_SpatialMatchOff_46(HandleRef pThis);

		/// <summary>
		/// This flag is used only when a piece is requested to update.  By default
		/// the flag is off.  Because no spatial correspondence between input pieces
		/// and source pieces is known, all of the source has to be requested no
		/// matter what piece of the output is requested.  When there is a spatial
		/// correspondence, the user/application can set this flag.  This hint allows
		/// the breakup of the probe operation to be much more efficient.  When piece
		/// m of n is requested for update by the user, then only n of m needs to
		/// be requested of the source.
		/// </summary>
		// Token: 0x0600EC0A RID: 60426 RVA: 0x001490DD File Offset: 0x001472DD
		public virtual void SpatialMatchOff()
		{
			vtkProbeFilter.vtkProbeFilter_SpatialMatchOff_46(base.GetCppThis());
		}

		// Token: 0x0600EC0B RID: 60427
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProbeFilter_SpatialMatchOn_47(HandleRef pThis);

		/// <summary>
		/// This flag is used only when a piece is requested to update.  By default
		/// the flag is off.  Because no spatial correspondence between input pieces
		/// and source pieces is known, all of the source has to be requested no
		/// matter what piece of the output is requested.  When there is a spatial
		/// correspondence, the user/application can set this flag.  This hint allows
		/// the breakup of the probe operation to be much more efficient.  When piece
		/// m of n is requested for update by the user, then only n of m needs to
		/// be requested of the source.
		/// </summary>
		// Token: 0x0600EC0C RID: 60428 RVA: 0x001490EC File Offset: 0x001472EC
		public virtual void SpatialMatchOn()
		{
			vtkProbeFilter.vtkProbeFilter_SpatialMatchOn_47(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400113B RID: 4411
		public new const string MRFullTypeName = "Kitware.VTK.vtkProbeFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400113C RID: 4412
		public new static readonly string MRClassNameKey = "class vtkProbeFilter";
	}
}
