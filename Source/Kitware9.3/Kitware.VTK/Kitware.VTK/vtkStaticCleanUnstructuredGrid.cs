using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkStaticCleanUnstructuredGrid
	/// </summary>
	/// <remarks>
	///    merge duplicate points, removed unused points, in an vtkUnstructuredGrid
	///
	/// vtkStaticCleanUnstructuredGrid is a filter that takes a
	/// vtkUnstructuredGrid as input and produces a vtkUnstructuredGrid on output,
	/// merging coincident points (as defined by a merging tolerance) and
	/// optionally removing unused points. The filter does not modify the topology
	/// of the input dataset, nor change the types of cells. It may however,
	/// renumber the cell connectivity ids.
	///
	/// For better performance, this filter employs threading using
	/// vtkStaticPointLocator and its associated threaded methods. When the
	/// merging tolerances==0.0, execution speeds are much faster as compared to
	/// non-zero tolerances. When the merging tolerance &gt; 0.0, there are issues
	/// of processing order which can be controlled through the locator
	/// (returned via GetLocator()). This behavior can be controlled by the
	/// SetTraversalOrder() method - by default threading occurs via BIN_ORDER
	/// (see vtkStaticPointLocator for more information).
	///
	/// @warning
	/// Merging points can alter cell geometry and produce degenerate cells. The
	/// tolerance should be chosen carefully to avoid these problems. For example,
	/// in an extreme case with a relatively large tolerance, all points of a
	/// vtkHexahedron could be merged to a single point, in which case the
	/// resulting hexahedron would be defined by eight repeats of the same point.
	///
	/// @warning
	/// If RemoveUnusedPoints is enabled, then any point not used by any of the
	/// unstructured grid cells is eliminated (and not passed to the
	/// output). Enabling this feature does impact performance.
	///
	/// @warning
	/// If ProduceMergeMap is enabled, then an output data array is produced,
	/// associated with the output field data, that maps each input point to an
	/// output point (or to -1 if an input point is unused in the output).
	///
	/// @warning
	/// Merging points affects point coordinates and data attributes. By default,
	/// if points are merged, the point position and attribute data of only one
	/// point (i.e., the point that all other points are merged to) is
	/// retained. If AveragePointData is enabled, then the resulting point position
	/// and attribute data values are determined by averaging the position and
	/// attribute values of all the points that are merged together. This option
	/// may have a significant performance impact if enabled.
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkCleanPolyData vtkStaticCleanPolyData vtkStaticPointLocator
	/// </seealso>
	// Token: 0x020009A0 RID: 2464
	public class vtkStaticCleanUnstructuredGrid : vtkUnstructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06019C13 RID: 105491 RVA: 0x0023C899 File Offset: 0x0023AA99
		static vtkStaticCleanUnstructuredGrid()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStaticCleanUnstructuredGrid.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStaticCleanUnstructuredGrid"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06019C14 RID: 105492 RVA: 0x0023C8C1 File Offset: 0x0023AAC1
		public vtkStaticCleanUnstructuredGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06019C15 RID: 105493
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStaticCleanUnstructuredGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing the state of the object.
		/// </summary>
		// Token: 0x06019C16 RID: 105494 RVA: 0x0023C8D0 File Offset: 0x0023AAD0
		public new static vtkStaticCleanUnstructuredGrid New()
		{
			vtkStaticCleanUnstructuredGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStaticCleanUnstructuredGrid.vtkStaticCleanUnstructuredGrid_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStaticCleanUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing the state of the object.
		/// </summary>
		// Token: 0x06019C17 RID: 105495 RVA: 0x0023C924 File Offset: 0x0023AB24
		public vtkStaticCleanUnstructuredGrid() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkStaticCleanUnstructuredGrid.vtkStaticCleanUnstructuredGrid_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06019C18 RID: 105496 RVA: 0x0023C968 File Offset: 0x0023AB68
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06019C19 RID: 105497
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCleanUnstructuredGrid_AveragePointDataOff_01(HandleRef pThis);

		/// <summary>
		/// Indicate whether point coordinates and point data of merged points are
		/// averaged. By default, the point coordinates and attribute data are not
		/// averaged, and the point coordinate and data of the single, remaining
		/// merged point is retained. Otherwise, the data coordinates and attribute
		/// values of all merged points are averaged. By default this feature is
		/// disabled.
		/// </summary>
		// Token: 0x06019C1A RID: 105498 RVA: 0x0023C973 File Offset: 0x0023AB73
		public virtual void AveragePointDataOff()
		{
			vtkStaticCleanUnstructuredGrid.vtkStaticCleanUnstructuredGrid_AveragePointDataOff_01(base.GetCppThis());
		}

		// Token: 0x06019C1B RID: 105499
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCleanUnstructuredGrid_AveragePointDataOn_02(HandleRef pThis);

		/// <summary>
		/// Indicate whether point coordinates and point data of merged points are
		/// averaged. By default, the point coordinates and attribute data are not
		/// averaged, and the point coordinate and data of the single, remaining
		/// merged point is retained. Otherwise, the data coordinates and attribute
		/// values of all merged points are averaged. By default this feature is
		/// disabled.
		/// </summary>
		// Token: 0x06019C1C RID: 105500 RVA: 0x0023C982 File Offset: 0x0023AB82
		public virtual void AveragePointDataOn()
		{
			vtkStaticCleanUnstructuredGrid.vtkStaticCleanUnstructuredGrid_AveragePointDataOn_02(base.GetCppThis());
		}

		// Token: 0x06019C1D RID: 105501
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkStaticCleanUnstructuredGrid_GetAbsoluteTolerance_03(HandleRef pThis);

		/// <summary>
		/// Specify the absolute point merging tolerance. The default value is
		/// 0. This tolerance is used then ToleranceIsAbsolute is true.
		/// </summary>
		// Token: 0x06019C1E RID: 105502 RVA: 0x0023C994 File Offset: 0x0023AB94
		public virtual double GetAbsoluteTolerance()
		{
			return vtkStaticCleanUnstructuredGrid.vtkStaticCleanUnstructuredGrid_GetAbsoluteTolerance_03(base.GetCppThis());
		}

		// Token: 0x06019C1F RID: 105503
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkStaticCleanUnstructuredGrid_GetAbsoluteToleranceMaxValue_04(HandleRef pThis);

		/// <summary>
		/// Specify the absolute point merging tolerance. The default value is
		/// 0. This tolerance is used then ToleranceIsAbsolute is true.
		/// </summary>
		// Token: 0x06019C20 RID: 105504 RVA: 0x0023C9B4 File Offset: 0x0023ABB4
		public virtual double GetAbsoluteToleranceMaxValue()
		{
			return vtkStaticCleanUnstructuredGrid.vtkStaticCleanUnstructuredGrid_GetAbsoluteToleranceMaxValue_04(base.GetCppThis());
		}

		// Token: 0x06019C21 RID: 105505
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkStaticCleanUnstructuredGrid_GetAbsoluteToleranceMinValue_05(HandleRef pThis);

		/// <summary>
		/// Specify the absolute point merging tolerance. The default value is
		/// 0. This tolerance is used then ToleranceIsAbsolute is true.
		/// </summary>
		// Token: 0x06019C22 RID: 105506 RVA: 0x0023C9D4 File Offset: 0x0023ABD4
		public virtual double GetAbsoluteToleranceMinValue()
		{
			return vtkStaticCleanUnstructuredGrid.vtkStaticCleanUnstructuredGrid_GetAbsoluteToleranceMinValue_05(base.GetCppThis());
		}

		// Token: 0x06019C23 RID: 105507
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStaticCleanUnstructuredGrid_GetAveragePointData_06(HandleRef pThis);

		/// <summary>
		/// Indicate whether point coordinates and point data of merged points are
		/// averaged. By default, the point coordinates and attribute data are not
		/// averaged, and the point coordinate and data of the single, remaining
		/// merged point is retained. Otherwise, the data coordinates and attribute
		/// values of all merged points are averaged. By default this feature is
		/// disabled.
		/// </summary>
		// Token: 0x06019C24 RID: 105508 RVA: 0x0023C9F4 File Offset: 0x0023ABF4
		public virtual bool GetAveragePointData()
		{
			return vtkStaticCleanUnstructuredGrid.vtkStaticCleanUnstructuredGrid_GetAveragePointData_06(base.GetCppThis()) != 0;
		}

		// Token: 0x06019C25 RID: 105509
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStaticCleanUnstructuredGrid_GetLocator_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve the internal locator to manually configure it, for example
		/// specifying the number of points per bucket, or controlling the traversal
		/// order. This method is generally used for debugging or testing purposes.
		/// </summary>
		// Token: 0x06019C26 RID: 105510 RVA: 0x0023CA1C File Offset: 0x0023AC1C
		public virtual vtkStaticPointLocator GetLocator()
		{
			vtkStaticPointLocator vtkStaticPointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStaticCleanUnstructuredGrid.vtkStaticCleanUnstructuredGrid_GetLocator_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStaticPointLocator = (vtkStaticPointLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStaticPointLocator.Register(null);
				}
			}
			return vtkStaticPointLocator;
		}

		// Token: 0x06019C27 RID: 105511
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkStaticCleanUnstructuredGrid_GetMTime_08(HandleRef pThis);

		/// <summary>
		/// Get the MTime of this object also considering the locator.
		/// </summary>
		// Token: 0x06019C28 RID: 105512 RVA: 0x0023CA8C File Offset: 0x0023AC8C
		public override ulong GetMTime()
		{
			return vtkStaticCleanUnstructuredGrid.vtkStaticCleanUnstructuredGrid_GetMTime_08(base.GetCppThis());
		}

		// Token: 0x06019C29 RID: 105513
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStaticCleanUnstructuredGrid_GetMergingArray_09(HandleRef pThis);

		/// <summary>
		/// Specify the name of a point data array associated with the point merging
		/// process. If a data array is specified, and exists in the input point
		/// data, then point merging will switch into a mode where merged points
		/// must be both geometrically coincident and have matching point data
		/// (i.e., an exact match of position and data - tolerances have no
		/// effect). Note that the number of tuples in the merging data array must
		/// be equal to the number of points in the input. By default, no data array
		/// is associated with the input points (i.e., the name of the data array is
		/// empty).
		/// </summary>
		// Token: 0x06019C2A RID: 105514 RVA: 0x0023CAAC File Offset: 0x0023ACAC
		public virtual string GetMergingArray()
		{
			string s = Marshal.PtrToStringAnsi(vtkStaticCleanUnstructuredGrid.vtkStaticCleanUnstructuredGrid_GetMergingArray_09(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06019C2B RID: 105515
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStaticCleanUnstructuredGrid_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing the state of the object.
		/// </summary>
		// Token: 0x06019C2C RID: 105516 RVA: 0x0023CAE8 File Offset: 0x0023ACE8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkStaticCleanUnstructuredGrid.vtkStaticCleanUnstructuredGrid_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x06019C2D RID: 105517
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStaticCleanUnstructuredGrid_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing the state of the object.
		/// </summary>
		// Token: 0x06019C2E RID: 105518 RVA: 0x0023CB08 File Offset: 0x0023AD08
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkStaticCleanUnstructuredGrid.vtkStaticCleanUnstructuredGrid_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x06019C2F RID: 105519
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStaticCleanUnstructuredGrid_GetOutputPointsPrecision_12(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output point type. See the
		/// documentation for the vtkAlgorithm::DesiredOutputPrecision enum for an
		/// explanation of the available precision settings.
		/// </summary>
		// Token: 0x06019C30 RID: 105520 RVA: 0x0023CB24 File Offset: 0x0023AD24
		public virtual int GetOutputPointsPrecision()
		{
			return vtkStaticCleanUnstructuredGrid.vtkStaticCleanUnstructuredGrid_GetOutputPointsPrecision_12(base.GetCppThis());
		}

		// Token: 0x06019C31 RID: 105521
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStaticCleanUnstructuredGrid_GetPieceInvariant_13(HandleRef pThis);

		/// <summary>
		/// Retrieve the internal locator to manually configure it, for example
		/// specifying the number of points per bucket, or controlling the traversal
		/// order. This method is generally used for debugging or testing purposes.
		/// </summary>
		// Token: 0x06019C32 RID: 105522 RVA: 0x0023CB44 File Offset: 0x0023AD44
		public virtual bool GetPieceInvariant()
		{
			return vtkStaticCleanUnstructuredGrid.vtkStaticCleanUnstructuredGrid_GetPieceInvariant_13(base.GetCppThis()) != 0;
		}

		// Token: 0x06019C33 RID: 105523
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStaticCleanUnstructuredGrid_GetProduceMergeMap_14(HandleRef pThis);

		/// <summary>
		/// Indicate whether a merge map should be produced on output. The merge
		/// map, if requested, maps each input point to its output point id, or
		/// provides a value of -1 if the input point is not used in the output.
		/// The merge map is associated with the filter's output field data and
		/// is named "PointMergeMap". By default, ProduceMergeMap is disabled.
		/// </summary>
		// Token: 0x06019C34 RID: 105524 RVA: 0x0023CB6C File Offset: 0x0023AD6C
		public virtual bool GetProduceMergeMap()
		{
			return vtkStaticCleanUnstructuredGrid.vtkStaticCleanUnstructuredGrid_GetProduceMergeMap_14(base.GetCppThis()) != 0;
		}

		// Token: 0x06019C35 RID: 105525
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStaticCleanUnstructuredGrid_GetRemoveUnusedPoints_15(HandleRef pThis);

		/// <summary>
		/// Indicate whether points unused by any cell are removed from the output.
		/// By default this point removal is on. Note that when this is off, the
		/// filter can successfully process datasets with no cells (and just
		/// points). If on in this case, and there are no cells, than the output
		/// will be empty.
		/// </summary>
		// Token: 0x06019C36 RID: 105526 RVA: 0x0023CB94 File Offset: 0x0023AD94
		public virtual bool GetRemoveUnusedPoints()
		{
			return vtkStaticCleanUnstructuredGrid.vtkStaticCleanUnstructuredGrid_GetRemoveUnusedPoints_15(base.GetCppThis()) != 0;
		}

		// Token: 0x06019C37 RID: 105527
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkStaticCleanUnstructuredGrid_GetTolerance_16(HandleRef pThis);

		/// <summary>
		/// Specify the point merging tolerance in terms of the fraction of the
		/// input dataset's bounding box length.  The default is 0. This tolerance
		/// is used then ToleranceIsAbsolute is false.
		/// </summary>
		// Token: 0x06019C38 RID: 105528 RVA: 0x0023CBBC File Offset: 0x0023ADBC
		public virtual double GetTolerance()
		{
			return vtkStaticCleanUnstructuredGrid.vtkStaticCleanUnstructuredGrid_GetTolerance_16(base.GetCppThis());
		}

		// Token: 0x06019C39 RID: 105529
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStaticCleanUnstructuredGrid_GetToleranceIsAbsolute_17(HandleRef pThis);

		/// <summary>
		/// Specify how the point merging tolerance is defined. By default
		/// ToleranceIsAbsolute is false and the tolerance is a fraction of the
		/// input's bounding box diagonal. If true, AbsoluteTolerance is the
		/// tolerance used when performing point merging.
		/// </summary>
		// Token: 0x06019C3A RID: 105530 RVA: 0x0023CBDC File Offset: 0x0023ADDC
		public virtual bool GetToleranceIsAbsolute()
		{
			return vtkStaticCleanUnstructuredGrid.vtkStaticCleanUnstructuredGrid_GetToleranceIsAbsolute_17(base.GetCppThis()) != 0;
		}

		// Token: 0x06019C3B RID: 105531
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkStaticCleanUnstructuredGrid_GetToleranceMaxValue_18(HandleRef pThis);

		/// <summary>
		/// Specify the point merging tolerance in terms of the fraction of the
		/// input dataset's bounding box length.  The default is 0. This tolerance
		/// is used then ToleranceIsAbsolute is false.
		/// </summary>
		// Token: 0x06019C3C RID: 105532 RVA: 0x0023CC04 File Offset: 0x0023AE04
		public virtual double GetToleranceMaxValue()
		{
			return vtkStaticCleanUnstructuredGrid.vtkStaticCleanUnstructuredGrid_GetToleranceMaxValue_18(base.GetCppThis());
		}

		// Token: 0x06019C3D RID: 105533
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkStaticCleanUnstructuredGrid_GetToleranceMinValue_19(HandleRef pThis);

		/// <summary>
		/// Specify the point merging tolerance in terms of the fraction of the
		/// input dataset's bounding box length.  The default is 0. This tolerance
		/// is used then ToleranceIsAbsolute is false.
		/// </summary>
		// Token: 0x06019C3E RID: 105534 RVA: 0x0023CC24 File Offset: 0x0023AE24
		public virtual double GetToleranceMinValue()
		{
			return vtkStaticCleanUnstructuredGrid.vtkStaticCleanUnstructuredGrid_GetToleranceMinValue_19(base.GetCppThis());
		}

		// Token: 0x06019C3F RID: 105535
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStaticCleanUnstructuredGrid_IsA_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing the state of the object.
		/// </summary>
		// Token: 0x06019C40 RID: 105536 RVA: 0x0023CC44 File Offset: 0x0023AE44
		public override int IsA(string type)
		{
			return vtkStaticCleanUnstructuredGrid.vtkStaticCleanUnstructuredGrid_IsA_20(base.GetCppThis(), type);
		}

		// Token: 0x06019C41 RID: 105537
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStaticCleanUnstructuredGrid_IsTypeOf_21([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing the state of the object.
		/// </summary>
		// Token: 0x06019C42 RID: 105538 RVA: 0x0023CC64 File Offset: 0x0023AE64
		public new static int IsTypeOf(string type)
		{
			return vtkStaticCleanUnstructuredGrid.vtkStaticCleanUnstructuredGrid_IsTypeOf_21(type);
		}

		// Token: 0x06019C43 RID: 105539
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStaticCleanUnstructuredGrid_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing the state of the object.
		/// </summary>
		// Token: 0x06019C44 RID: 105540 RVA: 0x0023CC80 File Offset: 0x0023AE80
		public new vtkStaticCleanUnstructuredGrid NewInstance()
		{
			vtkStaticCleanUnstructuredGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStaticCleanUnstructuredGrid.vtkStaticCleanUnstructuredGrid_NewInstance_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStaticCleanUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06019C45 RID: 105541
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCleanUnstructuredGrid_PieceInvariantOff_24(HandleRef pThis);

		/// <summary>
		/// Retrieve the internal locator to manually configure it, for example
		/// specifying the number of points per bucket, or controlling the traversal
		/// order. This method is generally used for debugging or testing purposes.
		/// </summary>
		// Token: 0x06019C46 RID: 105542 RVA: 0x0023CCDA File Offset: 0x0023AEDA
		public virtual void PieceInvariantOff()
		{
			vtkStaticCleanUnstructuredGrid.vtkStaticCleanUnstructuredGrid_PieceInvariantOff_24(base.GetCppThis());
		}

		// Token: 0x06019C47 RID: 105543
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCleanUnstructuredGrid_PieceInvariantOn_25(HandleRef pThis);

		/// <summary>
		/// Retrieve the internal locator to manually configure it, for example
		/// specifying the number of points per bucket, or controlling the traversal
		/// order. This method is generally used for debugging or testing purposes.
		/// </summary>
		// Token: 0x06019C48 RID: 105544 RVA: 0x0023CCE9 File Offset: 0x0023AEE9
		public virtual void PieceInvariantOn()
		{
			vtkStaticCleanUnstructuredGrid.vtkStaticCleanUnstructuredGrid_PieceInvariantOn_25(base.GetCppThis());
		}

		// Token: 0x06019C49 RID: 105545
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCleanUnstructuredGrid_ProduceMergeMapOff_26(HandleRef pThis);

		/// <summary>
		/// Indicate whether a merge map should be produced on output. The merge
		/// map, if requested, maps each input point to its output point id, or
		/// provides a value of -1 if the input point is not used in the output.
		/// The merge map is associated with the filter's output field data and
		/// is named "PointMergeMap". By default, ProduceMergeMap is disabled.
		/// </summary>
		// Token: 0x06019C4A RID: 105546 RVA: 0x0023CCF8 File Offset: 0x0023AEF8
		public virtual void ProduceMergeMapOff()
		{
			vtkStaticCleanUnstructuredGrid.vtkStaticCleanUnstructuredGrid_ProduceMergeMapOff_26(base.GetCppThis());
		}

		// Token: 0x06019C4B RID: 105547
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCleanUnstructuredGrid_ProduceMergeMapOn_27(HandleRef pThis);

		/// <summary>
		/// Indicate whether a merge map should be produced on output. The merge
		/// map, if requested, maps each input point to its output point id, or
		/// provides a value of -1 if the input point is not used in the output.
		/// The merge map is associated with the filter's output field data and
		/// is named "PointMergeMap". By default, ProduceMergeMap is disabled.
		/// </summary>
		// Token: 0x06019C4C RID: 105548 RVA: 0x0023CD07 File Offset: 0x0023AF07
		public virtual void ProduceMergeMapOn()
		{
			vtkStaticCleanUnstructuredGrid.vtkStaticCleanUnstructuredGrid_ProduceMergeMapOn_27(base.GetCppThis());
		}

		// Token: 0x06019C4D RID: 105549
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCleanUnstructuredGrid_RemoveUnusedPointsOff_28(HandleRef pThis);

		/// <summary>
		/// Indicate whether points unused by any cell are removed from the output.
		/// By default this point removal is on. Note that when this is off, the
		/// filter can successfully process datasets with no cells (and just
		/// points). If on in this case, and there are no cells, than the output
		/// will be empty.
		/// </summary>
		// Token: 0x06019C4E RID: 105550 RVA: 0x0023CD16 File Offset: 0x0023AF16
		public virtual void RemoveUnusedPointsOff()
		{
			vtkStaticCleanUnstructuredGrid.vtkStaticCleanUnstructuredGrid_RemoveUnusedPointsOff_28(base.GetCppThis());
		}

		// Token: 0x06019C4F RID: 105551
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCleanUnstructuredGrid_RemoveUnusedPointsOn_29(HandleRef pThis);

		/// <summary>
		/// Indicate whether points unused by any cell are removed from the output.
		/// By default this point removal is on. Note that when this is off, the
		/// filter can successfully process datasets with no cells (and just
		/// points). If on in this case, and there are no cells, than the output
		/// will be empty.
		/// </summary>
		// Token: 0x06019C50 RID: 105552 RVA: 0x0023CD25 File Offset: 0x0023AF25
		public virtual void RemoveUnusedPointsOn()
		{
			vtkStaticCleanUnstructuredGrid.vtkStaticCleanUnstructuredGrid_RemoveUnusedPointsOn_29(base.GetCppThis());
		}

		// Token: 0x06019C51 RID: 105553
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStaticCleanUnstructuredGrid_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing the state of the object.
		/// </summary>
		// Token: 0x06019C52 RID: 105554 RVA: 0x0023CD34 File Offset: 0x0023AF34
		public new static vtkStaticCleanUnstructuredGrid SafeDownCast(vtkObjectBase o)
		{
			vtkStaticCleanUnstructuredGrid vtkStaticCleanUnstructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStaticCleanUnstructuredGrid.vtkStaticCleanUnstructuredGrid_SafeDownCast_30((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStaticCleanUnstructuredGrid = (vtkStaticCleanUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStaticCleanUnstructuredGrid.Register(null);
				}
			}
			return vtkStaticCleanUnstructuredGrid;
		}

		// Token: 0x06019C53 RID: 105555
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCleanUnstructuredGrid_SetAbsoluteTolerance_31(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the absolute point merging tolerance. The default value is
		/// 0. This tolerance is used then ToleranceIsAbsolute is true.
		/// </summary>
		// Token: 0x06019C54 RID: 105556 RVA: 0x0023CDB3 File Offset: 0x0023AFB3
		public virtual void SetAbsoluteTolerance(double _arg)
		{
			vtkStaticCleanUnstructuredGrid.vtkStaticCleanUnstructuredGrid_SetAbsoluteTolerance_31(base.GetCppThis(), _arg);
		}

		// Token: 0x06019C55 RID: 105557
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCleanUnstructuredGrid_SetAveragePointData_32(HandleRef pThis, byte _arg);

		/// <summary>
		/// Indicate whether point coordinates and point data of merged points are
		/// averaged. By default, the point coordinates and attribute data are not
		/// averaged, and the point coordinate and data of the single, remaining
		/// merged point is retained. Otherwise, the data coordinates and attribute
		/// values of all merged points are averaged. By default this feature is
		/// disabled.
		/// </summary>
		// Token: 0x06019C56 RID: 105558 RVA: 0x0023CDC3 File Offset: 0x0023AFC3
		public virtual void SetAveragePointData(bool _arg)
		{
			vtkStaticCleanUnstructuredGrid.vtkStaticCleanUnstructuredGrid_SetAveragePointData_32(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06019C57 RID: 105559
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCleanUnstructuredGrid_SetMergingArray_33(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify the name of a point data array associated with the point merging
		/// process. If a data array is specified, and exists in the input point
		/// data, then point merging will switch into a mode where merged points
		/// must be both geometrically coincident and have matching point data
		/// (i.e., an exact match of position and data - tolerances have no
		/// effect). Note that the number of tuples in the merging data array must
		/// be equal to the number of points in the input. By default, no data array
		/// is associated with the input points (i.e., the name of the data array is
		/// empty).
		/// </summary>
		// Token: 0x06019C58 RID: 105560 RVA: 0x0023CDDB File Offset: 0x0023AFDB
		public virtual void SetMergingArray(string _arg)
		{
			vtkStaticCleanUnstructuredGrid.vtkStaticCleanUnstructuredGrid_SetMergingArray_33(base.GetCppThis(), _arg);
		}

		// Token: 0x06019C59 RID: 105561
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCleanUnstructuredGrid_SetOutputPointsPrecision_34(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output point type. See the
		/// documentation for the vtkAlgorithm::DesiredOutputPrecision enum for an
		/// explanation of the available precision settings.
		/// </summary>
		// Token: 0x06019C5A RID: 105562 RVA: 0x0023CDEB File Offset: 0x0023AFEB
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkStaticCleanUnstructuredGrid.vtkStaticCleanUnstructuredGrid_SetOutputPointsPrecision_34(base.GetCppThis(), _arg);
		}

		// Token: 0x06019C5B RID: 105563
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCleanUnstructuredGrid_SetPieceInvariant_35(HandleRef pThis, byte _arg);

		/// <summary>
		/// Retrieve the internal locator to manually configure it, for example
		/// specifying the number of points per bucket, or controlling the traversal
		/// order. This method is generally used for debugging or testing purposes.
		/// </summary>
		// Token: 0x06019C5C RID: 105564 RVA: 0x0023CDFB File Offset: 0x0023AFFB
		public virtual void SetPieceInvariant(bool _arg)
		{
			vtkStaticCleanUnstructuredGrid.vtkStaticCleanUnstructuredGrid_SetPieceInvariant_35(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06019C5D RID: 105565
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCleanUnstructuredGrid_SetProduceMergeMap_36(HandleRef pThis, byte _arg);

		/// <summary>
		/// Indicate whether a merge map should be produced on output. The merge
		/// map, if requested, maps each input point to its output point id, or
		/// provides a value of -1 if the input point is not used in the output.
		/// The merge map is associated with the filter's output field data and
		/// is named "PointMergeMap". By default, ProduceMergeMap is disabled.
		/// </summary>
		// Token: 0x06019C5E RID: 105566 RVA: 0x0023CE13 File Offset: 0x0023B013
		public virtual void SetProduceMergeMap(bool _arg)
		{
			vtkStaticCleanUnstructuredGrid.vtkStaticCleanUnstructuredGrid_SetProduceMergeMap_36(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06019C5F RID: 105567
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCleanUnstructuredGrid_SetRemoveUnusedPoints_37(HandleRef pThis, byte _arg);

		/// <summary>
		/// Indicate whether points unused by any cell are removed from the output.
		/// By default this point removal is on. Note that when this is off, the
		/// filter can successfully process datasets with no cells (and just
		/// points). If on in this case, and there are no cells, than the output
		/// will be empty.
		/// </summary>
		// Token: 0x06019C60 RID: 105568 RVA: 0x0023CE2B File Offset: 0x0023B02B
		public virtual void SetRemoveUnusedPoints(bool _arg)
		{
			vtkStaticCleanUnstructuredGrid.vtkStaticCleanUnstructuredGrid_SetRemoveUnusedPoints_37(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06019C61 RID: 105569
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCleanUnstructuredGrid_SetTolerance_38(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the point merging tolerance in terms of the fraction of the
		/// input dataset's bounding box length.  The default is 0. This tolerance
		/// is used then ToleranceIsAbsolute is false.
		/// </summary>
		// Token: 0x06019C62 RID: 105570 RVA: 0x0023CE43 File Offset: 0x0023B043
		public virtual void SetTolerance(double _arg)
		{
			vtkStaticCleanUnstructuredGrid.vtkStaticCleanUnstructuredGrid_SetTolerance_38(base.GetCppThis(), _arg);
		}

		// Token: 0x06019C63 RID: 105571
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCleanUnstructuredGrid_SetToleranceIsAbsolute_39(HandleRef pThis, byte _arg);

		/// <summary>
		/// Specify how the point merging tolerance is defined. By default
		/// ToleranceIsAbsolute is false and the tolerance is a fraction of the
		/// input's bounding box diagonal. If true, AbsoluteTolerance is the
		/// tolerance used when performing point merging.
		/// </summary>
		// Token: 0x06019C64 RID: 105572 RVA: 0x0023CE53 File Offset: 0x0023B053
		public virtual void SetToleranceIsAbsolute(bool _arg)
		{
			vtkStaticCleanUnstructuredGrid.vtkStaticCleanUnstructuredGrid_SetToleranceIsAbsolute_39(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06019C65 RID: 105573
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCleanUnstructuredGrid_ToleranceIsAbsoluteOff_40(HandleRef pThis);

		/// <summary>
		/// Specify how the point merging tolerance is defined. By default
		/// ToleranceIsAbsolute is false and the tolerance is a fraction of the
		/// input's bounding box diagonal. If true, AbsoluteTolerance is the
		/// tolerance used when performing point merging.
		/// </summary>
		// Token: 0x06019C66 RID: 105574 RVA: 0x0023CE6B File Offset: 0x0023B06B
		public virtual void ToleranceIsAbsoluteOff()
		{
			vtkStaticCleanUnstructuredGrid.vtkStaticCleanUnstructuredGrid_ToleranceIsAbsoluteOff_40(base.GetCppThis());
		}

		// Token: 0x06019C67 RID: 105575
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCleanUnstructuredGrid_ToleranceIsAbsoluteOn_41(HandleRef pThis);

		/// <summary>
		/// Specify how the point merging tolerance is defined. By default
		/// ToleranceIsAbsolute is false and the tolerance is a fraction of the
		/// input's bounding box diagonal. If true, AbsoluteTolerance is the
		/// tolerance used when performing point merging.
		/// </summary>
		// Token: 0x06019C68 RID: 105576 RVA: 0x0023CE7A File Offset: 0x0023B07A
		public virtual void ToleranceIsAbsoluteOn()
		{
			vtkStaticCleanUnstructuredGrid.vtkStaticCleanUnstructuredGrid_ToleranceIsAbsoluteOn_41(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C05 RID: 7173
		public new const string MRFullTypeName = "Kitware.VTK.vtkStaticCleanUnstructuredGrid";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C06 RID: 7174
		public new static readonly string MRClassNameKey = "class vtkStaticCleanUnstructuredGrid";
	}
}
