using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtk3DLinearGridCrinkleExtractor
	/// </summary>
	/// <remarks>
	///    fast extraction of cells intersected by a plane
	///
	/// vtk3DLinearGridCrinkleExtractor is a specialized filter that, given a
	/// specified implicit function, extracts unstructured grid cells that
	/// intersect the implicit function. (Since the surface of these cells roughly
	/// follows the implicit function but is "bumpy", it is referred to as a
	/// "crinkle" surface.) This filter operates on vtkUnstructuredGrids consisting
	/// of 3D linear cells: tetrahedra, hexahedra, voxels, pyramids, and/or
	/// wedges. (The cells are linear in the sense that each cell edge is a
	/// straight line.)  The filter is designed for high-speed, specialized
	/// operation. All other cell types are skipped and produce no output.
	///
	/// To use this filter you must specify an input unstructured grid or
	/// vtkCompositeDataSet (containing unstructured grids) and an implicit
	/// function to cut with.
	///
	/// The RemoveUnusedPoints data member controls whether the filter remaps the
	/// input points to the output. Since the algorithm simply extracts a subset
	/// of the original data (points and cells), it is possible simply to pass the
	/// input points to the output, which is much faster (factor of ~2X) then
	/// mapping the input points to the output. Of course, not removing the unused
	/// points means extra points in the output dataset, but because the input
	/// points are shallow copied to the output, no additional memory is consumed.
	///
	/// @warning
	/// When the input is of type vtkCompositeDataSet the filter will process the
	/// unstructured grid(s) contained in the composite data set. As a result the
	/// output of this filter is then a vtkMultiBlockDataSet containing multiple
	/// vtkUnstructuredGrids. When a vtkUnstructuredGrid is provided as input the
	/// output is a single vtkUnstructuredGrid.
	///
	/// @warning
	/// Input cells that are not of 3D linear type (tetrahedron, hexahedron,
	/// wedge, pyramid, and voxel) are simply skipped and not processed.
	///
	/// @warning
	/// The filter is templated on types of input and output points, and input
	/// scalar type. To reduce object file bloat, only real points (float,double) are
	/// processed.
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// @warning
	/// The vtkExtractGeometry filter is similar to this filter when
	/// ExtractOnlyBoundaryCells is enabled.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtk3DLinearGrid vtk3DLinearGridPlaneCutter vtkExtractGeometry
	/// </seealso>
	// Token: 0x02000934 RID: 2356
	public class vtk3DLinearGridCrinkleExtractor : vtkDataObjectAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06018636 RID: 99894 RVA: 0x00221E1B File Offset: 0x0022001B
		static vtk3DLinearGridCrinkleExtractor()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtk3DLinearGridCrinkleExtractor.MRClassNameKey, Type.GetType("Kitware.VTK.vtk3DLinearGridCrinkleExtractor"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06018637 RID: 99895 RVA: 0x00221E43 File Offset: 0x00220043
		public vtk3DLinearGridCrinkleExtractor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06018638 RID: 99896
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtk3DLinearGridCrinkleExtractor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for construction, type info, and printing.
		/// </summary>
		// Token: 0x06018639 RID: 99897 RVA: 0x00221E54 File Offset: 0x00220054
		public new static vtk3DLinearGridCrinkleExtractor New()
		{
			vtk3DLinearGridCrinkleExtractor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtk3DLinearGridCrinkleExtractor.vtk3DLinearGridCrinkleExtractor_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtk3DLinearGridCrinkleExtractor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for construction, type info, and printing.
		/// </summary>
		// Token: 0x0601863A RID: 99898 RVA: 0x00221EA8 File Offset: 0x002200A8
		public vtk3DLinearGridCrinkleExtractor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtk3DLinearGridCrinkleExtractor.vtk3DLinearGridCrinkleExtractor_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601863B RID: 99899 RVA: 0x00221EEC File Offset: 0x002200EC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601863C RID: 99900
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtk3DLinearGridCrinkleExtractor_CanFullyProcessDataObject_01(HandleRef arg0);

		/// <summary>
		/// Returns true if the data object passed in is fully supported by this
		/// filter, i.e., all cell types are linear. For composite datasets, this
		/// means all dataset leaves have only linear cell types that can be processed
		/// by this filter.
		/// </summary>
		// Token: 0x0601863D RID: 99901 RVA: 0x00221EF8 File Offset: 0x002200F8
		public static bool CanFullyProcessDataObject(vtkDataObject arg0)
		{
			return vtk3DLinearGridCrinkleExtractor.vtk3DLinearGridCrinkleExtractor_CanFullyProcessDataObject_01((arg0 == null) ? default(HandleRef) : arg0.GetCppThis()) != 0;
		}

		// Token: 0x0601863E RID: 99902
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtk3DLinearGridCrinkleExtractor_CopyCellDataOff_02(HandleRef pThis);

		/// <summary>
		/// Indicate whether to copy input cell data/attributes onto the output
		/// cells. By default this option is off.
		/// </summary>
		// Token: 0x0601863F RID: 99903 RVA: 0x00221F2D File Offset: 0x0022012D
		public virtual void CopyCellDataOff()
		{
			vtk3DLinearGridCrinkleExtractor.vtk3DLinearGridCrinkleExtractor_CopyCellDataOff_02(base.GetCppThis());
		}

		// Token: 0x06018640 RID: 99904
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtk3DLinearGridCrinkleExtractor_CopyCellDataOn_03(HandleRef pThis);

		/// <summary>
		/// Indicate whether to copy input cell data/attributes onto the output
		/// cells. By default this option is off.
		/// </summary>
		// Token: 0x06018641 RID: 99905 RVA: 0x00221F3C File Offset: 0x0022013C
		public virtual void CopyCellDataOn()
		{
			vtk3DLinearGridCrinkleExtractor.vtk3DLinearGridCrinkleExtractor_CopyCellDataOn_03(base.GetCppThis());
		}

		// Token: 0x06018642 RID: 99906
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtk3DLinearGridCrinkleExtractor_CopyPointDataOff_04(HandleRef pThis);

		/// <summary>
		/// Indicate whether to copy input point data/attributes onto the output
		/// points. By default this option is on.
		/// </summary>
		// Token: 0x06018643 RID: 99907 RVA: 0x00221F4B File Offset: 0x0022014B
		public virtual void CopyPointDataOff()
		{
			vtk3DLinearGridCrinkleExtractor.vtk3DLinearGridCrinkleExtractor_CopyPointDataOff_04(base.GetCppThis());
		}

		// Token: 0x06018644 RID: 99908
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtk3DLinearGridCrinkleExtractor_CopyPointDataOn_05(HandleRef pThis);

		/// <summary>
		/// Indicate whether to copy input point data/attributes onto the output
		/// points. By default this option is on.
		/// </summary>
		// Token: 0x06018645 RID: 99909 RVA: 0x00221F5A File Offset: 0x0022015A
		public virtual void CopyPointDataOn()
		{
			vtk3DLinearGridCrinkleExtractor.vtk3DLinearGridCrinkleExtractor_CopyPointDataOn_05(base.GetCppThis());
		}

		// Token: 0x06018646 RID: 99910
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtk3DLinearGridCrinkleExtractor_GetCopyCellData_06(HandleRef pThis);

		/// <summary>
		/// Indicate whether to copy input cell data/attributes onto the output
		/// cells. By default this option is off.
		/// </summary>
		// Token: 0x06018647 RID: 99911 RVA: 0x00221F6C File Offset: 0x0022016C
		public virtual bool GetCopyCellData()
		{
			return vtk3DLinearGridCrinkleExtractor.vtk3DLinearGridCrinkleExtractor_GetCopyCellData_06(base.GetCppThis()) != 0;
		}

		// Token: 0x06018648 RID: 99912
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtk3DLinearGridCrinkleExtractor_GetCopyPointData_07(HandleRef pThis);

		/// <summary>
		/// Indicate whether to copy input point data/attributes onto the output
		/// points. By default this option is on.
		/// </summary>
		// Token: 0x06018649 RID: 99913 RVA: 0x00221F94 File Offset: 0x00220194
		public virtual bool GetCopyPointData()
		{
			return vtk3DLinearGridCrinkleExtractor.vtk3DLinearGridCrinkleExtractor_GetCopyPointData_07(base.GetCppThis()) != 0;
		}

		// Token: 0x0601864A RID: 99914
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtk3DLinearGridCrinkleExtractor_GetImplicitFunction_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the implicit function which is used to select the output cell
		/// faces. Note that the implicit function invocation must be thread
		/// safe. Also, there is a fast path for vtkPlane implicit functions.
		/// </summary>
		// Token: 0x0601864B RID: 99915 RVA: 0x00221FBC File Offset: 0x002201BC
		public virtual vtkImplicitFunction GetImplicitFunction()
		{
			vtkImplicitFunction vtkImplicitFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtk3DLinearGridCrinkleExtractor.vtk3DLinearGridCrinkleExtractor_GetImplicitFunction_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitFunction = (vtkImplicitFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitFunction.Register(null);
				}
			}
			return vtkImplicitFunction;
		}

		// Token: 0x0601864C RID: 99916
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtk3DLinearGridCrinkleExtractor_GetMTime_09(HandleRef pThis);

		/// <summary>
		/// Overloaded GetMTime() because of delegation to the helper
		/// vtkImplicitFunction.
		/// </summary>
		// Token: 0x0601864D RID: 99917 RVA: 0x0022202C File Offset: 0x0022022C
		public override ulong GetMTime()
		{
			return vtk3DLinearGridCrinkleExtractor.vtk3DLinearGridCrinkleExtractor_GetMTime_09(base.GetCppThis());
		}

		// Token: 0x0601864E RID: 99918
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtk3DLinearGridCrinkleExtractor_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for construction, type info, and printing.
		/// </summary>
		// Token: 0x0601864F RID: 99919 RVA: 0x0022204C File Offset: 0x0022024C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtk3DLinearGridCrinkleExtractor.vtk3DLinearGridCrinkleExtractor_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x06018650 RID: 99920
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtk3DLinearGridCrinkleExtractor_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for construction, type info, and printing.
		/// </summary>
		// Token: 0x06018651 RID: 99921 RVA: 0x0022206C File Offset: 0x0022026C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtk3DLinearGridCrinkleExtractor.vtk3DLinearGridCrinkleExtractor_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x06018652 RID: 99922
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtk3DLinearGridCrinkleExtractor_GetNumberOfThreadsUsed_12(HandleRef pThis);

		/// <summary>
		///  Return the number of threads actually used during execution. This is
		///  valid only after algorithm execution.
		/// </summary>
		// Token: 0x06018653 RID: 99923 RVA: 0x00222088 File Offset: 0x00220288
		public int GetNumberOfThreadsUsed()
		{
			return vtk3DLinearGridCrinkleExtractor.vtk3DLinearGridCrinkleExtractor_GetNumberOfThreadsUsed_12(base.GetCppThis());
		}

		// Token: 0x06018654 RID: 99924
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtk3DLinearGridCrinkleExtractor_GetOutputPointsPrecision_13(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output points. See the
		/// documentation for the vtkAlgorithm::Precision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06018655 RID: 99925 RVA: 0x002220A8 File Offset: 0x002202A8
		public int GetOutputPointsPrecision()
		{
			return vtk3DLinearGridCrinkleExtractor.vtk3DLinearGridCrinkleExtractor_GetOutputPointsPrecision_13(base.GetCppThis());
		}

		// Token: 0x06018656 RID: 99926
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtk3DLinearGridCrinkleExtractor_GetRemoveUnusedPoints_14(HandleRef pThis);

		/// <summary>
		/// Indicate whether to eliminate unused output points. When this flag is
		/// disabled, the input points and associated point data are simply shallow
		/// copied to the output (which improves performance).  When enabled, any
		/// points that are not used by the output cells are not sent to the output,
		/// nor is associated point data copied. By default this option is disabled.
		/// Removing unused points does have a significant performance impact.
		/// </summary>
		// Token: 0x06018657 RID: 99927 RVA: 0x002220C8 File Offset: 0x002202C8
		public virtual bool GetRemoveUnusedPoints()
		{
			return vtk3DLinearGridCrinkleExtractor.vtk3DLinearGridCrinkleExtractor_GetRemoveUnusedPoints_14(base.GetCppThis()) != 0;
		}

		// Token: 0x06018658 RID: 99928
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtk3DLinearGridCrinkleExtractor_GetSequentialProcessing_15(HandleRef pThis);

		/// <summary>
		/// Force sequential processing (i.e. single thread) of the crinkle cut
		/// process. By default, sequential processing is off. Note this flag only
		/// applies if the class has been compiled with VTK_SMP_IMPLEMENTATION_TYPE
		/// set to something other than Sequential. (If set to Sequential, then the
		/// filter always runs in serial mode.) This flag is typically used for
		/// benchmarking purposes.
		/// </summary>
		// Token: 0x06018659 RID: 99929 RVA: 0x002220F0 File Offset: 0x002202F0
		public virtual bool GetSequentialProcessing()
		{
			return vtk3DLinearGridCrinkleExtractor.vtk3DLinearGridCrinkleExtractor_GetSequentialProcessing_15(base.GetCppThis()) != 0;
		}

		// Token: 0x0601865A RID: 99930
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtk3DLinearGridCrinkleExtractor_IsA_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for construction, type info, and printing.
		/// </summary>
		// Token: 0x0601865B RID: 99931 RVA: 0x00222118 File Offset: 0x00220318
		public override int IsA(string type)
		{
			return vtk3DLinearGridCrinkleExtractor.vtk3DLinearGridCrinkleExtractor_IsA_16(base.GetCppThis(), type);
		}

		// Token: 0x0601865C RID: 99932
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtk3DLinearGridCrinkleExtractor_IsTypeOf_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for construction, type info, and printing.
		/// </summary>
		// Token: 0x0601865D RID: 99933 RVA: 0x00222138 File Offset: 0x00220338
		public new static int IsTypeOf(string type)
		{
			return vtk3DLinearGridCrinkleExtractor.vtk3DLinearGridCrinkleExtractor_IsTypeOf_17(type);
		}

		// Token: 0x0601865E RID: 99934
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtk3DLinearGridCrinkleExtractor_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for construction, type info, and printing.
		/// </summary>
		// Token: 0x0601865F RID: 99935 RVA: 0x00222154 File Offset: 0x00220354
		public new vtk3DLinearGridCrinkleExtractor NewInstance()
		{
			vtk3DLinearGridCrinkleExtractor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtk3DLinearGridCrinkleExtractor.vtk3DLinearGridCrinkleExtractor_NewInstance_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtk3DLinearGridCrinkleExtractor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06018660 RID: 99936
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtk3DLinearGridCrinkleExtractor_RemoveUnusedPointsOff_20(HandleRef pThis);

		/// <summary>
		/// Indicate whether to eliminate unused output points. When this flag is
		/// disabled, the input points and associated point data are simply shallow
		/// copied to the output (which improves performance).  When enabled, any
		/// points that are not used by the output cells are not sent to the output,
		/// nor is associated point data copied. By default this option is disabled.
		/// Removing unused points does have a significant performance impact.
		/// </summary>
		// Token: 0x06018661 RID: 99937 RVA: 0x002221AE File Offset: 0x002203AE
		public virtual void RemoveUnusedPointsOff()
		{
			vtk3DLinearGridCrinkleExtractor.vtk3DLinearGridCrinkleExtractor_RemoveUnusedPointsOff_20(base.GetCppThis());
		}

		// Token: 0x06018662 RID: 99938
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtk3DLinearGridCrinkleExtractor_RemoveUnusedPointsOn_21(HandleRef pThis);

		/// <summary>
		/// Indicate whether to eliminate unused output points. When this flag is
		/// disabled, the input points and associated point data are simply shallow
		/// copied to the output (which improves performance).  When enabled, any
		/// points that are not used by the output cells are not sent to the output,
		/// nor is associated point data copied. By default this option is disabled.
		/// Removing unused points does have a significant performance impact.
		/// </summary>
		// Token: 0x06018663 RID: 99939 RVA: 0x002221BD File Offset: 0x002203BD
		public virtual void RemoveUnusedPointsOn()
		{
			vtk3DLinearGridCrinkleExtractor.vtk3DLinearGridCrinkleExtractor_RemoveUnusedPointsOn_21(base.GetCppThis());
		}

		// Token: 0x06018664 RID: 99940
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtk3DLinearGridCrinkleExtractor_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for construction, type info, and printing.
		/// </summary>
		// Token: 0x06018665 RID: 99941 RVA: 0x002221CC File Offset: 0x002203CC
		public new static vtk3DLinearGridCrinkleExtractor SafeDownCast(vtkObjectBase o)
		{
			vtk3DLinearGridCrinkleExtractor vtk3DLinearGridCrinkleExtractor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtk3DLinearGridCrinkleExtractor.vtk3DLinearGridCrinkleExtractor_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtk3DLinearGridCrinkleExtractor = (vtk3DLinearGridCrinkleExtractor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtk3DLinearGridCrinkleExtractor.Register(null);
				}
			}
			return vtk3DLinearGridCrinkleExtractor;
		}

		// Token: 0x06018666 RID: 99942
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtk3DLinearGridCrinkleExtractor_SequentialProcessingOff_23(HandleRef pThis);

		/// <summary>
		/// Force sequential processing (i.e. single thread) of the crinkle cut
		/// process. By default, sequential processing is off. Note this flag only
		/// applies if the class has been compiled with VTK_SMP_IMPLEMENTATION_TYPE
		/// set to something other than Sequential. (If set to Sequential, then the
		/// filter always runs in serial mode.) This flag is typically used for
		/// benchmarking purposes.
		/// </summary>
		// Token: 0x06018667 RID: 99943 RVA: 0x0022224B File Offset: 0x0022044B
		public virtual void SequentialProcessingOff()
		{
			vtk3DLinearGridCrinkleExtractor.vtk3DLinearGridCrinkleExtractor_SequentialProcessingOff_23(base.GetCppThis());
		}

		// Token: 0x06018668 RID: 99944
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtk3DLinearGridCrinkleExtractor_SequentialProcessingOn_24(HandleRef pThis);

		/// <summary>
		/// Force sequential processing (i.e. single thread) of the crinkle cut
		/// process. By default, sequential processing is off. Note this flag only
		/// applies if the class has been compiled with VTK_SMP_IMPLEMENTATION_TYPE
		/// set to something other than Sequential. (If set to Sequential, then the
		/// filter always runs in serial mode.) This flag is typically used for
		/// benchmarking purposes.
		/// </summary>
		// Token: 0x06018669 RID: 99945 RVA: 0x0022225A File Offset: 0x0022045A
		public virtual void SequentialProcessingOn()
		{
			vtk3DLinearGridCrinkleExtractor.vtk3DLinearGridCrinkleExtractor_SequentialProcessingOn_24(base.GetCppThis());
		}

		// Token: 0x0601866A RID: 99946
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtk3DLinearGridCrinkleExtractor_SetCopyCellData_25(HandleRef pThis, byte _arg);

		/// <summary>
		/// Indicate whether to copy input cell data/attributes onto the output
		/// cells. By default this option is off.
		/// </summary>
		// Token: 0x0601866B RID: 99947 RVA: 0x00222269 File Offset: 0x00220469
		public virtual void SetCopyCellData(bool _arg)
		{
			vtk3DLinearGridCrinkleExtractor.vtk3DLinearGridCrinkleExtractor_SetCopyCellData_25(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0601866C RID: 99948
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtk3DLinearGridCrinkleExtractor_SetCopyPointData_26(HandleRef pThis, byte _arg);

		/// <summary>
		/// Indicate whether to copy input point data/attributes onto the output
		/// points. By default this option is on.
		/// </summary>
		// Token: 0x0601866D RID: 99949 RVA: 0x00222281 File Offset: 0x00220481
		public virtual void SetCopyPointData(bool _arg)
		{
			vtk3DLinearGridCrinkleExtractor.vtk3DLinearGridCrinkleExtractor_SetCopyPointData_26(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0601866E RID: 99950
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtk3DLinearGridCrinkleExtractor_SetImplicitFunction_27(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the implicit function which is used to select the output cell
		/// faces. Note that the implicit function invocation must be thread
		/// safe. Also, there is a fast path for vtkPlane implicit functions.
		/// </summary>
		// Token: 0x0601866F RID: 99951 RVA: 0x0022229C File Offset: 0x0022049C
		public virtual void SetImplicitFunction(vtkImplicitFunction arg0)
		{
			vtk3DLinearGridCrinkleExtractor.vtk3DLinearGridCrinkleExtractor_SetImplicitFunction_27(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06018670 RID: 99952
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtk3DLinearGridCrinkleExtractor_SetOutputPointsPrecision_28(HandleRef pThis, int precision);

		/// <summary>
		/// Set/get the desired precision for the output points. See the
		/// documentation for the vtkAlgorithm::Precision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06018671 RID: 99953 RVA: 0x002222CB File Offset: 0x002204CB
		public void SetOutputPointsPrecision(int precision)
		{
			vtk3DLinearGridCrinkleExtractor.vtk3DLinearGridCrinkleExtractor_SetOutputPointsPrecision_28(base.GetCppThis(), precision);
		}

		// Token: 0x06018672 RID: 99954
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtk3DLinearGridCrinkleExtractor_SetRemoveUnusedPoints_29(HandleRef pThis, byte _arg);

		/// <summary>
		/// Indicate whether to eliminate unused output points. When this flag is
		/// disabled, the input points and associated point data are simply shallow
		/// copied to the output (which improves performance).  When enabled, any
		/// points that are not used by the output cells are not sent to the output,
		/// nor is associated point data copied. By default this option is disabled.
		/// Removing unused points does have a significant performance impact.
		/// </summary>
		// Token: 0x06018673 RID: 99955 RVA: 0x002222DB File Offset: 0x002204DB
		public virtual void SetRemoveUnusedPoints(bool _arg)
		{
			vtk3DLinearGridCrinkleExtractor.vtk3DLinearGridCrinkleExtractor_SetRemoveUnusedPoints_29(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06018674 RID: 99956
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtk3DLinearGridCrinkleExtractor_SetSequentialProcessing_30(HandleRef pThis, byte _arg);

		/// <summary>
		/// Force sequential processing (i.e. single thread) of the crinkle cut
		/// process. By default, sequential processing is off. Note this flag only
		/// applies if the class has been compiled with VTK_SMP_IMPLEMENTATION_TYPE
		/// set to something other than Sequential. (If set to Sequential, then the
		/// filter always runs in serial mode.) This flag is typically used for
		/// benchmarking purposes.
		/// </summary>
		// Token: 0x06018675 RID: 99957 RVA: 0x002222F3 File Offset: 0x002204F3
		public virtual void SetSequentialProcessing(bool _arg)
		{
			vtk3DLinearGridCrinkleExtractor.vtk3DLinearGridCrinkleExtractor_SetSequentialProcessing_30(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B12 RID: 6930
		public new const string MRFullTypeName = "Kitware.VTK.vtk3DLinearGridCrinkleExtractor";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B13 RID: 6931
		public new static readonly string MRClassNameKey = "class vtk3DLinearGridCrinkleExtractor";
	}
}
