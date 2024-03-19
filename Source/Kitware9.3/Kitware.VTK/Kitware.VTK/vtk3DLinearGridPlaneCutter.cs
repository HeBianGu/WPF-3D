using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtk3DLinearGridPlaneCutter
	/// </summary>
	/// <remarks>
	///    fast plane cutting of vtkUnstructuredGrid containing 3D linear cells
	///
	/// vtk3DLinearGridPlaneCutter is a specialized filter that cuts an input
	/// vtkUnstructuredGrid consisting of 3D linear cells: tetrahedra, hexahedra,
	/// voxels, pyramids, and/or wedges. (The cells are linear in the sense that
	/// each cell edge is a straight line.)  The filter is designed for
	/// high-speed, specialized operation. All other cell types are skipped and
	/// produce no output.
	///
	/// To use this filter you must specify an input unstructured grid or
	/// vtkCompositeDataSet (containing unstructured grids) and a plane to cut with.
	///
	/// The filter performance varies depending on optional output
	/// information. Basically if point merging is required (when PointMerging is
	/// set) a sorting process is required to eliminate duplicate output points in
	/// the cut surface. Otherwise when point merging is not required, a fast path
	/// process produces independent triangles representing the cut surface.
	///
	/// This algorithm is fast because it is threaded, and may perform operations
	/// (in a preprocessing step) to accelerate the plane cutting.
	///
	/// Because this filter may build an initial data structure during a
	/// preprocessing step, the first execution of the filter may take longer than
	/// subsequent operations. Typically the first execution is still faster than
	/// vtkCutter (especially with threading enabled), but for certain types of
	/// data this may not be true. However if you are using the filter to cut a
	/// dataset multiple times (as in an exploratory or interactive workflow) this
	/// filter works well.
	///
	/// @warning
	/// When the input is of type vtkCompositeDataSet the filter will process the
	/// unstructured grid(s) contained in the composite data set. As a result the
	/// output of this filter is then a vtkMultiBlockDataSet containing multiple
	/// vtkPolyData. When a vtkUnstructuredGrid is provided as input the
	/// output is a single vtkPolyData.
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
	/// </remarks>
	/// <seealso>
	///
	/// vtkCutter vtkFlyingEdgesPlaneCutter vtkPlaneCutter vtkPlane
	/// vtkContour3DLinearGrid
	/// </seealso>
	// Token: 0x02000935 RID: 2357
	public class vtk3DLinearGridPlaneCutter : vtkDataObjectAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06018676 RID: 99958 RVA: 0x0022230B File Offset: 0x0022050B
		static vtk3DLinearGridPlaneCutter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtk3DLinearGridPlaneCutter.MRClassNameKey, Type.GetType("Kitware.VTK.vtk3DLinearGridPlaneCutter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06018677 RID: 99959 RVA: 0x00222333 File Offset: 0x00220533
		public vtk3DLinearGridPlaneCutter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06018678 RID: 99960
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtk3DLinearGridPlaneCutter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for construction, type info, and printing.
		/// </summary>
		// Token: 0x06018679 RID: 99961 RVA: 0x00222344 File Offset: 0x00220544
		public new static vtk3DLinearGridPlaneCutter New()
		{
			vtk3DLinearGridPlaneCutter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtk3DLinearGridPlaneCutter.vtk3DLinearGridPlaneCutter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtk3DLinearGridPlaneCutter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for construction, type info, and printing.
		/// </summary>
		// Token: 0x0601867A RID: 99962 RVA: 0x00222398 File Offset: 0x00220598
		public vtk3DLinearGridPlaneCutter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtk3DLinearGridPlaneCutter.vtk3DLinearGridPlaneCutter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601867B RID: 99963 RVA: 0x002223DC File Offset: 0x002205DC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601867C RID: 99964
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtk3DLinearGridPlaneCutter_CanFullyProcessDataObject_01(HandleRef arg0);

		/// <summary>
		/// Returns true if the data object passed in is fully supported by this
		/// filter, i.e., all cell types are linear. For composite datasets, this
		/// means all dataset leaves have only linear cell types that can be processed
		/// by this filter.
		/// </summary>
		// Token: 0x0601867D RID: 99965 RVA: 0x002223E8 File Offset: 0x002205E8
		public static bool CanFullyProcessDataObject(vtkDataObject arg0)
		{
			return vtk3DLinearGridPlaneCutter.vtk3DLinearGridPlaneCutter_CanFullyProcessDataObject_01((arg0 == null) ? default(HandleRef) : arg0.GetCppThis()) != 0;
		}

		// Token: 0x0601867E RID: 99966
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtk3DLinearGridPlaneCutter_ComputeNormalsOff_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. The normal generated is simply the
		/// cut plane normal. The normal, if generated, is defined by cell data
		/// associated with the output polygons. By default computing of normals is
		/// off.
		/// </summary>
		// Token: 0x0601867F RID: 99967 RVA: 0x0022241D File Offset: 0x0022061D
		public virtual void ComputeNormalsOff()
		{
			vtk3DLinearGridPlaneCutter.vtk3DLinearGridPlaneCutter_ComputeNormalsOff_02(base.GetCppThis());
		}

		// Token: 0x06018680 RID: 99968
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtk3DLinearGridPlaneCutter_ComputeNormalsOn_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. The normal generated is simply the
		/// cut plane normal. The normal, if generated, is defined by cell data
		/// associated with the output polygons. By default computing of normals is
		/// off.
		/// </summary>
		// Token: 0x06018681 RID: 99969 RVA: 0x0022242C File Offset: 0x0022062C
		public virtual void ComputeNormalsOn()
		{
			vtk3DLinearGridPlaneCutter.vtk3DLinearGridPlaneCutter_ComputeNormalsOn_03(base.GetCppThis());
		}

		// Token: 0x06018682 RID: 99970
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtk3DLinearGridPlaneCutter_GetComputeNormals_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. The normal generated is simply the
		/// cut plane normal. The normal, if generated, is defined by cell data
		/// associated with the output polygons. By default computing of normals is
		/// off.
		/// </summary>
		// Token: 0x06018683 RID: 99971 RVA: 0x0022243C File Offset: 0x0022063C
		public virtual bool GetComputeNormals()
		{
			return vtk3DLinearGridPlaneCutter.vtk3DLinearGridPlaneCutter_GetComputeNormals_04(base.GetCppThis()) != 0;
		}

		// Token: 0x06018684 RID: 99972
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtk3DLinearGridPlaneCutter_GetInterpolateAttributes_05(HandleRef pThis);

		/// <summary>
		/// Indicate whether to interpolate input attributes onto the cut
		/// plane. By default this option is on.
		/// </summary>
		// Token: 0x06018685 RID: 99973 RVA: 0x00222464 File Offset: 0x00220664
		public virtual bool GetInterpolateAttributes()
		{
			return vtk3DLinearGridPlaneCutter.vtk3DLinearGridPlaneCutter_GetInterpolateAttributes_05(base.GetCppThis()) != 0;
		}

		// Token: 0x06018686 RID: 99974
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtk3DLinearGridPlaneCutter_GetLargeIds_06(HandleRef pThis);

		/// <summary>
		/// Inform the user as to whether large ids were used during filter
		/// execution. This flag only has meaning after the filter has executed.
		/// Large ids are used when the id of the larges cell or point is greater
		/// than signed 32-bit precision. (Smaller ids reduce memory usage and speed
		/// computation. Note that LargeIds are only available on 64-bit
		/// architectures.)
		/// </summary>
		// Token: 0x06018687 RID: 99975 RVA: 0x0022248C File Offset: 0x0022068C
		public bool GetLargeIds()
		{
			return vtk3DLinearGridPlaneCutter.vtk3DLinearGridPlaneCutter_GetLargeIds_06(base.GetCppThis()) != 0;
		}

		// Token: 0x06018688 RID: 99976
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtk3DLinearGridPlaneCutter_GetMTime_07(HandleRef pThis);

		/// <summary>
		/// Overloaded GetMTime() because of delegation to the helper
		/// vtkPlane.
		/// </summary>
		// Token: 0x06018689 RID: 99977 RVA: 0x002224B4 File Offset: 0x002206B4
		public override ulong GetMTime()
		{
			return vtk3DLinearGridPlaneCutter.vtk3DLinearGridPlaneCutter_GetMTime_07(base.GetCppThis());
		}

		// Token: 0x0601868A RID: 99978
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtk3DLinearGridPlaneCutter_GetMergePoints_08(HandleRef pThis);

		/// <summary>
		/// Indicate whether to merge coincident points. Merging can take extra time
		/// and produces fewer output points, creating a "watertight" output
		/// surface. On the other hand, merging reduced output data size and may be
		/// just as fast especially for smaller data. By default this is off.
		/// </summary>
		// Token: 0x0601868B RID: 99979 RVA: 0x002224D4 File Offset: 0x002206D4
		public virtual bool GetMergePoints()
		{
			return vtk3DLinearGridPlaneCutter.vtk3DLinearGridPlaneCutter_GetMergePoints_08(base.GetCppThis()) != 0;
		}

		// Token: 0x0601868C RID: 99980
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtk3DLinearGridPlaneCutter_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for construction, type info, and printing.
		/// </summary>
		// Token: 0x0601868D RID: 99981 RVA: 0x002224FC File Offset: 0x002206FC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtk3DLinearGridPlaneCutter.vtk3DLinearGridPlaneCutter_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x0601868E RID: 99982
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtk3DLinearGridPlaneCutter_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for construction, type info, and printing.
		/// </summary>
		// Token: 0x0601868F RID: 99983 RVA: 0x0022251C File Offset: 0x0022071C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtk3DLinearGridPlaneCutter.vtk3DLinearGridPlaneCutter_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x06018690 RID: 99984
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtk3DLinearGridPlaneCutter_GetNumberOfThreadsUsed_11(HandleRef pThis);

		/// <summary>
		///  Return the number of threads actually used during execution. This is
		///  valid only after algorithm execution.
		/// </summary>
		// Token: 0x06018691 RID: 99985 RVA: 0x00222538 File Offset: 0x00220738
		public int GetNumberOfThreadsUsed()
		{
			return vtk3DLinearGridPlaneCutter.vtk3DLinearGridPlaneCutter_GetNumberOfThreadsUsed_11(base.GetCppThis());
		}

		// Token: 0x06018692 RID: 99986
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtk3DLinearGridPlaneCutter_GetOutputPointsPrecision_12(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output points. See the
		/// documentation for the vtkAlgorithm::Precision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06018693 RID: 99987 RVA: 0x00222558 File Offset: 0x00220758
		public int GetOutputPointsPrecision()
		{
			return vtk3DLinearGridPlaneCutter.vtk3DLinearGridPlaneCutter_GetOutputPointsPrecision_12(base.GetCppThis());
		}

		// Token: 0x06018694 RID: 99988
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtk3DLinearGridPlaneCutter_GetPlane_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the plane (an implicit function) to perform the cutting. The
		/// definition of the plane (its origin and normal) is controlled via this
		/// instance of vtkPlane.
		/// </summary>
		// Token: 0x06018695 RID: 99989 RVA: 0x00222578 File Offset: 0x00220778
		public virtual vtkPlane GetPlane()
		{
			vtkPlane vtkPlane = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtk3DLinearGridPlaneCutter.vtk3DLinearGridPlaneCutter_GetPlane_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlane = (vtkPlane)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlane.Register(null);
				}
			}
			return vtkPlane;
		}

		// Token: 0x06018696 RID: 99990
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtk3DLinearGridPlaneCutter_GetSequentialProcessing_14(HandleRef pThis);

		/// <summary>
		/// Force sequential processing (i.e. single thread) of the contouring
		/// process. By default, sequential processing is off. Note this flag only
		/// applies if the class has been compiled with VTK_SMP_IMPLEMENTATION_TYPE
		/// set to something other than Sequential. (If set to Sequential, then the
		/// filter always runs in serial mode.) This flag is typically used for
		/// benchmarking purposes.
		/// </summary>
		// Token: 0x06018697 RID: 99991 RVA: 0x002225E8 File Offset: 0x002207E8
		public virtual bool GetSequentialProcessing()
		{
			return vtk3DLinearGridPlaneCutter.vtk3DLinearGridPlaneCutter_GetSequentialProcessing_14(base.GetCppThis()) != 0;
		}

		// Token: 0x06018698 RID: 99992
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtk3DLinearGridPlaneCutter_InterpolateAttributesOff_15(HandleRef pThis);

		/// <summary>
		/// Indicate whether to interpolate input attributes onto the cut
		/// plane. By default this option is on.
		/// </summary>
		// Token: 0x06018699 RID: 99993 RVA: 0x0022260E File Offset: 0x0022080E
		public virtual void InterpolateAttributesOff()
		{
			vtk3DLinearGridPlaneCutter.vtk3DLinearGridPlaneCutter_InterpolateAttributesOff_15(base.GetCppThis());
		}

		// Token: 0x0601869A RID: 99994
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtk3DLinearGridPlaneCutter_InterpolateAttributesOn_16(HandleRef pThis);

		/// <summary>
		/// Indicate whether to interpolate input attributes onto the cut
		/// plane. By default this option is on.
		/// </summary>
		// Token: 0x0601869B RID: 99995 RVA: 0x0022261D File Offset: 0x0022081D
		public virtual void InterpolateAttributesOn()
		{
			vtk3DLinearGridPlaneCutter.vtk3DLinearGridPlaneCutter_InterpolateAttributesOn_16(base.GetCppThis());
		}

		// Token: 0x0601869C RID: 99996
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtk3DLinearGridPlaneCutter_IsA_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for construction, type info, and printing.
		/// </summary>
		// Token: 0x0601869D RID: 99997 RVA: 0x0022262C File Offset: 0x0022082C
		public override int IsA(string type)
		{
			return vtk3DLinearGridPlaneCutter.vtk3DLinearGridPlaneCutter_IsA_17(base.GetCppThis(), type);
		}

		// Token: 0x0601869E RID: 99998
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtk3DLinearGridPlaneCutter_IsTypeOf_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for construction, type info, and printing.
		/// </summary>
		// Token: 0x0601869F RID: 99999 RVA: 0x0022264C File Offset: 0x0022084C
		public new static int IsTypeOf(string type)
		{
			return vtk3DLinearGridPlaneCutter.vtk3DLinearGridPlaneCutter_IsTypeOf_18(type);
		}

		// Token: 0x060186A0 RID: 100000
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtk3DLinearGridPlaneCutter_MergePointsOff_19(HandleRef pThis);

		/// <summary>
		/// Indicate whether to merge coincident points. Merging can take extra time
		/// and produces fewer output points, creating a "watertight" output
		/// surface. On the other hand, merging reduced output data size and may be
		/// just as fast especially for smaller data. By default this is off.
		/// </summary>
		// Token: 0x060186A1 RID: 100001 RVA: 0x00222666 File Offset: 0x00220866
		public virtual void MergePointsOff()
		{
			vtk3DLinearGridPlaneCutter.vtk3DLinearGridPlaneCutter_MergePointsOff_19(base.GetCppThis());
		}

		// Token: 0x060186A2 RID: 100002
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtk3DLinearGridPlaneCutter_MergePointsOn_20(HandleRef pThis);

		/// <summary>
		/// Indicate whether to merge coincident points. Merging can take extra time
		/// and produces fewer output points, creating a "watertight" output
		/// surface. On the other hand, merging reduced output data size and may be
		/// just as fast especially for smaller data. By default this is off.
		/// </summary>
		// Token: 0x060186A3 RID: 100003 RVA: 0x00222675 File Offset: 0x00220875
		public virtual void MergePointsOn()
		{
			vtk3DLinearGridPlaneCutter.vtk3DLinearGridPlaneCutter_MergePointsOn_20(base.GetCppThis());
		}

		// Token: 0x060186A4 RID: 100004
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtk3DLinearGridPlaneCutter_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for construction, type info, and printing.
		/// </summary>
		// Token: 0x060186A5 RID: 100005 RVA: 0x00222684 File Offset: 0x00220884
		public new vtk3DLinearGridPlaneCutter NewInstance()
		{
			vtk3DLinearGridPlaneCutter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtk3DLinearGridPlaneCutter.vtk3DLinearGridPlaneCutter_NewInstance_22(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtk3DLinearGridPlaneCutter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060186A6 RID: 100006
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtk3DLinearGridPlaneCutter_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for construction, type info, and printing.
		/// </summary>
		// Token: 0x060186A7 RID: 100007 RVA: 0x002226E0 File Offset: 0x002208E0
		public new static vtk3DLinearGridPlaneCutter SafeDownCast(vtkObjectBase o)
		{
			vtk3DLinearGridPlaneCutter vtk3DLinearGridPlaneCutter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtk3DLinearGridPlaneCutter.vtk3DLinearGridPlaneCutter_SafeDownCast_23((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtk3DLinearGridPlaneCutter = (vtk3DLinearGridPlaneCutter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtk3DLinearGridPlaneCutter.Register(null);
				}
			}
			return vtk3DLinearGridPlaneCutter;
		}

		// Token: 0x060186A8 RID: 100008
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtk3DLinearGridPlaneCutter_SequentialProcessingOff_24(HandleRef pThis);

		/// <summary>
		/// Force sequential processing (i.e. single thread) of the contouring
		/// process. By default, sequential processing is off. Note this flag only
		/// applies if the class has been compiled with VTK_SMP_IMPLEMENTATION_TYPE
		/// set to something other than Sequential. (If set to Sequential, then the
		/// filter always runs in serial mode.) This flag is typically used for
		/// benchmarking purposes.
		/// </summary>
		// Token: 0x060186A9 RID: 100009 RVA: 0x0022275F File Offset: 0x0022095F
		public virtual void SequentialProcessingOff()
		{
			vtk3DLinearGridPlaneCutter.vtk3DLinearGridPlaneCutter_SequentialProcessingOff_24(base.GetCppThis());
		}

		// Token: 0x060186AA RID: 100010
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtk3DLinearGridPlaneCutter_SequentialProcessingOn_25(HandleRef pThis);

		/// <summary>
		/// Force sequential processing (i.e. single thread) of the contouring
		/// process. By default, sequential processing is off. Note this flag only
		/// applies if the class has been compiled with VTK_SMP_IMPLEMENTATION_TYPE
		/// set to something other than Sequential. (If set to Sequential, then the
		/// filter always runs in serial mode.) This flag is typically used for
		/// benchmarking purposes.
		/// </summary>
		// Token: 0x060186AB RID: 100011 RVA: 0x0022276E File Offset: 0x0022096E
		public virtual void SequentialProcessingOn()
		{
			vtk3DLinearGridPlaneCutter.vtk3DLinearGridPlaneCutter_SequentialProcessingOn_25(base.GetCppThis());
		}

		// Token: 0x060186AC RID: 100012
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtk3DLinearGridPlaneCutter_SetComputeNormals_26(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get the computation of normals. The normal generated is simply the
		/// cut plane normal. The normal, if generated, is defined by cell data
		/// associated with the output polygons. By default computing of normals is
		/// off.
		/// </summary>
		// Token: 0x060186AD RID: 100013 RVA: 0x0022277D File Offset: 0x0022097D
		public virtual void SetComputeNormals(bool _arg)
		{
			vtk3DLinearGridPlaneCutter.vtk3DLinearGridPlaneCutter_SetComputeNormals_26(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060186AE RID: 100014
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtk3DLinearGridPlaneCutter_SetInterpolateAttributes_27(HandleRef pThis, byte _arg);

		/// <summary>
		/// Indicate whether to interpolate input attributes onto the cut
		/// plane. By default this option is on.
		/// </summary>
		// Token: 0x060186AF RID: 100015 RVA: 0x00222795 File Offset: 0x00220995
		public virtual void SetInterpolateAttributes(bool _arg)
		{
			vtk3DLinearGridPlaneCutter.vtk3DLinearGridPlaneCutter_SetInterpolateAttributes_27(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060186B0 RID: 100016
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtk3DLinearGridPlaneCutter_SetMergePoints_28(HandleRef pThis, byte _arg);

		/// <summary>
		/// Indicate whether to merge coincident points. Merging can take extra time
		/// and produces fewer output points, creating a "watertight" output
		/// surface. On the other hand, merging reduced output data size and may be
		/// just as fast especially for smaller data. By default this is off.
		/// </summary>
		// Token: 0x060186B1 RID: 100017 RVA: 0x002227AD File Offset: 0x002209AD
		public virtual void SetMergePoints(bool _arg)
		{
			vtk3DLinearGridPlaneCutter.vtk3DLinearGridPlaneCutter_SetMergePoints_28(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060186B2 RID: 100018
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtk3DLinearGridPlaneCutter_SetOutputPointsPrecision_29(HandleRef pThis, int precision);

		/// <summary>
		/// Set/get the desired precision for the output points. See the
		/// documentation for the vtkAlgorithm::Precision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x060186B3 RID: 100019 RVA: 0x002227C5 File Offset: 0x002209C5
		public void SetOutputPointsPrecision(int precision)
		{
			vtk3DLinearGridPlaneCutter.vtk3DLinearGridPlaneCutter_SetOutputPointsPrecision_29(base.GetCppThis(), precision);
		}

		// Token: 0x060186B4 RID: 100020
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtk3DLinearGridPlaneCutter_SetPlane_30(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the plane (an implicit function) to perform the cutting. The
		/// definition of the plane (its origin and normal) is controlled via this
		/// instance of vtkPlane.
		/// </summary>
		// Token: 0x060186B5 RID: 100021 RVA: 0x002227D8 File Offset: 0x002209D8
		public virtual void SetPlane(vtkPlane arg0)
		{
			vtk3DLinearGridPlaneCutter.vtk3DLinearGridPlaneCutter_SetPlane_30(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060186B6 RID: 100022
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtk3DLinearGridPlaneCutter_SetSequentialProcessing_31(HandleRef pThis, byte _arg);

		/// <summary>
		/// Force sequential processing (i.e. single thread) of the contouring
		/// process. By default, sequential processing is off. Note this flag only
		/// applies if the class has been compiled with VTK_SMP_IMPLEMENTATION_TYPE
		/// set to something other than Sequential. (If set to Sequential, then the
		/// filter always runs in serial mode.) This flag is typically used for
		/// benchmarking purposes.
		/// </summary>
		// Token: 0x060186B7 RID: 100023 RVA: 0x00222807 File Offset: 0x00220A07
		public virtual void SetSequentialProcessing(bool _arg)
		{
			vtk3DLinearGridPlaneCutter.vtk3DLinearGridPlaneCutter_SetSequentialProcessing_31(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B14 RID: 6932
		public new const string MRFullTypeName = "Kitware.VTK.vtk3DLinearGridPlaneCutter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B15 RID: 6933
		public new static readonly string MRClassNameKey = "class vtk3DLinearGridPlaneCutter";
	}
}
