using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPlaneCutter
	/// </summary>
	/// <remarks>
	///    cut any dataset with a plane and generate a
	/// polygonal cut surface
	///
	/// vtkPlaneCutter is a specialization of the vtkCutter algorithm to cut a
	/// dataset grid with a single plane. It is designed for performance and an
	/// exploratory, fast workflow. It produces output triangles/polygons that
	/// result from cutting the input dataset with the specified plane.
	///
	/// This algorithm is fast because it is threaded, it may delegate to a
	/// high-performance cutting algorithm, and/or it may build (in a
	/// preprocessing step) a spatial search structure that accelerates the plane
	/// cuts. The search structure, which is typically a sphere tree, is used to
	/// quickly cull candidate cells.
	///
	/// Because this filter may build an initial data structure during a
	/// preprocessing step, the first execution of the filter may take longer than
	/// subsequent operations. Typically the first execution is still faster than
	/// vtkCutter (especially with threading enabled), but for certain types of
	/// data this may not be true. However if you are using the filter to cut a
	/// dataset multiple times (as in an exploratory or interactive workflow) this
	/// filter typically works well.
	///
	/// @warning
	/// Polygons can NOT be generated when the input is vtkPolyData/vtkUnstructuredGridBase.
	///
	/// @warning
	/// This filter chooses the output type based on the input type.
	/// 1) if input is vtkDataSet, output is vtkPolyData.
	/// 2) if input is vtkPartitionedDataSet, output is vtkPartitionedDataSet.
	/// 3) if input is vtkPartitionedDataSetCollection, output is vtkPartitionedDataSetCollection.
	/// 4) if input is vtkUniformGridAMR, output is vtkMultiBlockDataSet.
	/// 5) if input is vtkMultiBlockDataSet, output is vtkMultiBlockDataSet.
	///
	/// @warning
	/// Delegations to other filters:
	/// 1) vtkImageData/vtkRectilinearGrid/vtkStructuredGrid delegates vtkStructuredDataPlaneCutter.
	/// 2) vtkPolyData with convex cells delegates to vtkPolyDataPlaneCutter.
	/// 3) vtkUnstructuredGrid with linear cells delegates to vtk3DLinearGridPlaneCutter.
	///
	/// @warning
	/// This filter can optionally produce output, using MergePoints=false, that has duplicate points.
	/// only for vtkUnstructuredGrid, and vtkPolyData that all of its input cells are NOT convex
	/// polygons. For all the other input types, the output has unique points.
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkFlyingEdgesPlaneCutter vtkStructuredDataPlaneCutter vtkPolyDataPlaneCutter
	/// vtk3DLinearGridPlaneCutter vtkCutter vtkPlane
	/// </seealso>
	// Token: 0x02000986 RID: 2438
	public class vtkPlaneCutter : vtkDataObjectAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060195F5 RID: 103925 RVA: 0x00235A98 File Offset: 0x00233C98
		static vtkPlaneCutter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPlaneCutter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlaneCutter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060195F6 RID: 103926 RVA: 0x00235AC0 File Offset: 0x00233CC0
		public vtkPlaneCutter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060195F7 RID: 103927
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlaneCutter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard construction and print methods.
		/// </summary>
		// Token: 0x060195F8 RID: 103928 RVA: 0x00235AD0 File Offset: 0x00233CD0
		public new static vtkPlaneCutter New()
		{
			vtkPlaneCutter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlaneCutter.vtkPlaneCutter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlaneCutter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard construction and print methods.
		/// </summary>
		// Token: 0x060195F9 RID: 103929 RVA: 0x00235B24 File Offset: 0x00233D24
		public vtkPlaneCutter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPlaneCutter.vtkPlaneCutter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060195FA RID: 103930 RVA: 0x00235B68 File Offset: 0x00233D68
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060195FB RID: 103931
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneCutter_BuildHierarchyOff_01(HandleRef pThis);

		/// <summary>
		/// Indicate whether to build tree hierarchy. Computing the tree
		/// hierarchy can take some time on the first computation but if
		/// the input does not change, the computation of all further
		/// slice will be faster. Default is on.
		/// </summary>
		// Token: 0x060195FC RID: 103932 RVA: 0x00235B73 File Offset: 0x00233D73
		public virtual void BuildHierarchyOff()
		{
			vtkPlaneCutter.vtkPlaneCutter_BuildHierarchyOff_01(base.GetCppThis());
		}

		// Token: 0x060195FD RID: 103933
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneCutter_BuildHierarchyOn_02(HandleRef pThis);

		/// <summary>
		/// Indicate whether to build tree hierarchy. Computing the tree
		/// hierarchy can take some time on the first computation but if
		/// the input does not change, the computation of all further
		/// slice will be faster. Default is on.
		/// </summary>
		// Token: 0x060195FE RID: 103934 RVA: 0x00235B82 File Offset: 0x00233D82
		public virtual void BuildHierarchyOn()
		{
			vtkPlaneCutter.vtkPlaneCutter_BuildHierarchyOn_02(base.GetCppThis());
		}

		// Token: 0x060195FF RID: 103935
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneCutter_BuildTreeOff_03(HandleRef pThis);

		/// <summary>
		/// Indicate whether to build the sphere tree. Computing the sphere
		/// will take some time on the first computation
		/// but if the input does not change, the computation of all further
		/// slice will be much faster. Default is on.
		/// </summary>
		// Token: 0x06019600 RID: 103936 RVA: 0x00235B91 File Offset: 0x00233D91
		public virtual void BuildTreeOff()
		{
			vtkPlaneCutter.vtkPlaneCutter_BuildTreeOff_03(base.GetCppThis());
		}

		// Token: 0x06019601 RID: 103937
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneCutter_BuildTreeOn_04(HandleRef pThis);

		/// <summary>
		/// Indicate whether to build the sphere tree. Computing the sphere
		/// will take some time on the first computation
		/// but if the input does not change, the computation of all further
		/// slice will be much faster. Default is on.
		/// </summary>
		// Token: 0x06019602 RID: 103938 RVA: 0x00235BA0 File Offset: 0x00233DA0
		public virtual void BuildTreeOn()
		{
			vtkPlaneCutter.vtkPlaneCutter_BuildTreeOn_04(base.GetCppThis());
		}

		// Token: 0x06019603 RID: 103939
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneCutter_ComputeNormalsOff_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. The normal generated is simply the
		/// cut plane normal. The normal, if generated, is defined by cell data
		/// associated with the output polygons. By default computing of normals is
		/// disabled.
		/// </summary>
		// Token: 0x06019604 RID: 103940 RVA: 0x00235BAF File Offset: 0x00233DAF
		public virtual void ComputeNormalsOff()
		{
			vtkPlaneCutter.vtkPlaneCutter_ComputeNormalsOff_05(base.GetCppThis());
		}

		// Token: 0x06019605 RID: 103941
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneCutter_ComputeNormalsOn_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. The normal generated is simply the
		/// cut plane normal. The normal, if generated, is defined by cell data
		/// associated with the output polygons. By default computing of normals is
		/// disabled.
		/// </summary>
		// Token: 0x06019606 RID: 103942 RVA: 0x00235BBE File Offset: 0x00233DBE
		public virtual void ComputeNormalsOn()
		{
			vtkPlaneCutter.vtkPlaneCutter_ComputeNormalsOn_06(base.GetCppThis());
		}

		// Token: 0x06019607 RID: 103943
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneCutter_GeneratePolygonsOff_07(HandleRef pThis);

		/// <summary>
		/// Indicate whether to generate polygons instead of triangles when cutting
		/// structured and rectilinear grid.
		/// No effect with other kinds of inputs, enabled by default.
		/// </summary>
		// Token: 0x06019608 RID: 103944 RVA: 0x00235BCD File Offset: 0x00233DCD
		public virtual void GeneratePolygonsOff()
		{
			vtkPlaneCutter.vtkPlaneCutter_GeneratePolygonsOff_07(base.GetCppThis());
		}

		// Token: 0x06019609 RID: 103945
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneCutter_GeneratePolygonsOn_08(HandleRef pThis);

		/// <summary>
		/// Indicate whether to generate polygons instead of triangles when cutting
		/// structured and rectilinear grid.
		/// No effect with other kinds of inputs, enabled by default.
		/// </summary>
		// Token: 0x0601960A RID: 103946 RVA: 0x00235BDC File Offset: 0x00233DDC
		public virtual void GeneratePolygonsOn()
		{
			vtkPlaneCutter.vtkPlaneCutter_GeneratePolygonsOn_08(base.GetCppThis());
		}

		// Token: 0x0601960B RID: 103947
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlaneCutter_GetBuildHierarchy_09(HandleRef pThis);

		/// <summary>
		/// Indicate whether to build tree hierarchy. Computing the tree
		/// hierarchy can take some time on the first computation but if
		/// the input does not change, the computation of all further
		/// slice will be faster. Default is on.
		/// </summary>
		// Token: 0x0601960C RID: 103948 RVA: 0x00235BEC File Offset: 0x00233DEC
		public virtual bool GetBuildHierarchy()
		{
			return vtkPlaneCutter.vtkPlaneCutter_GetBuildHierarchy_09(base.GetCppThis()) != 0;
		}

		// Token: 0x0601960D RID: 103949
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlaneCutter_GetBuildTree_10(HandleRef pThis);

		/// <summary>
		/// Indicate whether to build the sphere tree. Computing the sphere
		/// will take some time on the first computation
		/// but if the input does not change, the computation of all further
		/// slice will be much faster. Default is on.
		/// </summary>
		// Token: 0x0601960E RID: 103950 RVA: 0x00235C14 File Offset: 0x00233E14
		public virtual bool GetBuildTree()
		{
			return vtkPlaneCutter.vtkPlaneCutter_GetBuildTree_10(base.GetCppThis()) != 0;
		}

		// Token: 0x0601960F RID: 103951
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlaneCutter_GetComputeNormals_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. The normal generated is simply the
		/// cut plane normal. The normal, if generated, is defined by cell data
		/// associated with the output polygons. By default computing of normals is
		/// disabled.
		/// </summary>
		// Token: 0x06019610 RID: 103952 RVA: 0x00235C3C File Offset: 0x00233E3C
		public virtual bool GetComputeNormals()
		{
			return vtkPlaneCutter.vtkPlaneCutter_GetComputeNormals_11(base.GetCppThis()) != 0;
		}

		// Token: 0x06019611 RID: 103953
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlaneCutter_GetGeneratePolygons_12(HandleRef pThis);

		/// <summary>
		/// Indicate whether to generate polygons instead of triangles when cutting
		/// structured and rectilinear grid.
		/// No effect with other kinds of inputs, enabled by default.
		/// </summary>
		// Token: 0x06019612 RID: 103954 RVA: 0x00235C64 File Offset: 0x00233E64
		public virtual bool GetGeneratePolygons()
		{
			return vtkPlaneCutter.vtkPlaneCutter_GetGeneratePolygons_12(base.GetCppThis()) != 0;
		}

		// Token: 0x06019613 RID: 103955
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlaneCutter_GetInterpolateAttributes_13(HandleRef pThis);

		/// <summary>
		/// Indicate whether to interpolate attribute data. By default this is
		/// enabled. Note that both cell data and point data is interpolated and
		/// output, except for image data input where only point data are output.
		/// </summary>
		// Token: 0x06019614 RID: 103956 RVA: 0x00235C8C File Offset: 0x00233E8C
		public virtual bool GetInterpolateAttributes()
		{
			return vtkPlaneCutter.vtkPlaneCutter_GetInterpolateAttributes_13(base.GetCppThis()) != 0;
		}

		// Token: 0x06019615 RID: 103957
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkPlaneCutter_GetMTime_14(HandleRef pThis);

		/// <summary>
		/// The modified time depends on the delegated cut plane.
		/// </summary>
		// Token: 0x06019616 RID: 103958 RVA: 0x00235CB4 File Offset: 0x00233EB4
		public override ulong GetMTime()
		{
			return vtkPlaneCutter.vtkPlaneCutter_GetMTime_14(base.GetCppThis());
		}

		// Token: 0x06019617 RID: 103959
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlaneCutter_GetMergePoints_15(HandleRef pThis);

		/// <summary>
		/// Indicate whether to merge coincident points. Merging can take extra time
		/// and produces fewer output points, creating a "watertight" output
		/// surface. On the other hand, merging reduced output data size and may be
		/// just as fast. MergingPoints = off is meaningful only for vtkUnstructuredGrid,
		/// and vtkPolyData that all of its input cells are NOT convex polygons. For all the
		/// other input types, the output has unique points. Default is off.
		/// </summary>
		// Token: 0x06019618 RID: 103960 RVA: 0x00235CD4 File Offset: 0x00233ED4
		public virtual bool GetMergePoints()
		{
			return vtkPlaneCutter.vtkPlaneCutter_GetMergePoints_15(base.GetCppThis()) != 0;
		}

		// Token: 0x06019619 RID: 103961
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlaneCutter_GetNumberOfGenerationsFromBase_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard construction and print methods.
		/// </summary>
		// Token: 0x0601961A RID: 103962 RVA: 0x00235CFC File Offset: 0x00233EFC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPlaneCutter.vtkPlaneCutter_GetNumberOfGenerationsFromBase_16(base.GetCppThis(), type);
		}

		// Token: 0x0601961B RID: 103963
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlaneCutter_GetNumberOfGenerationsFromBaseType_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard construction and print methods.
		/// </summary>
		// Token: 0x0601961C RID: 103964 RVA: 0x00235D1C File Offset: 0x00233F1C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPlaneCutter.vtkPlaneCutter_GetNumberOfGenerationsFromBaseType_17(type);
		}

		// Token: 0x0601961D RID: 103965
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlaneCutter_GetOutputPointsPrecision_18(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x0601961E RID: 103966 RVA: 0x00235D38 File Offset: 0x00233F38
		public virtual int GetOutputPointsPrecision()
		{
			return vtkPlaneCutter.vtkPlaneCutter_GetOutputPointsPrecision_18(base.GetCppThis());
		}

		// Token: 0x0601961F RID: 103967
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlaneCutter_GetOutputPointsPrecisionMaxValue_19(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06019620 RID: 103968 RVA: 0x00235D58 File Offset: 0x00233F58
		public virtual int GetOutputPointsPrecisionMaxValue()
		{
			return vtkPlaneCutter.vtkPlaneCutter_GetOutputPointsPrecisionMaxValue_19(base.GetCppThis());
		}

		// Token: 0x06019621 RID: 103969
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlaneCutter_GetOutputPointsPrecisionMinValue_20(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06019622 RID: 103970 RVA: 0x00235D78 File Offset: 0x00233F78
		public virtual int GetOutputPointsPrecisionMinValue()
		{
			return vtkPlaneCutter.vtkPlaneCutter_GetOutputPointsPrecisionMinValue_20(base.GetCppThis());
		}

		// Token: 0x06019623 RID: 103971
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlaneCutter_GetPlane_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the plane (an implicit function) to perform the cutting. The
		/// definition of the plane (its origin and normal) is controlled via this
		/// instance of vtkPlane.
		/// </summary>
		// Token: 0x06019624 RID: 103972 RVA: 0x00235D98 File Offset: 0x00233F98
		public virtual vtkPlane GetPlane()
		{
			vtkPlane vtkPlane = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlaneCutter.vtkPlaneCutter_GetPlane_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06019625 RID: 103973
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneCutter_InterpolateAttributesOff_22(HandleRef pThis);

		/// <summary>
		/// Indicate whether to interpolate attribute data. By default this is
		/// enabled. Note that both cell data and point data is interpolated and
		/// output, except for image data input where only point data are output.
		/// </summary>
		// Token: 0x06019626 RID: 103974 RVA: 0x00235E07 File Offset: 0x00234007
		public virtual void InterpolateAttributesOff()
		{
			vtkPlaneCutter.vtkPlaneCutter_InterpolateAttributesOff_22(base.GetCppThis());
		}

		// Token: 0x06019627 RID: 103975
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneCutter_InterpolateAttributesOn_23(HandleRef pThis);

		/// <summary>
		/// Indicate whether to interpolate attribute data. By default this is
		/// enabled. Note that both cell data and point data is interpolated and
		/// output, except for image data input where only point data are output.
		/// </summary>
		// Token: 0x06019628 RID: 103976 RVA: 0x00235E16 File Offset: 0x00234016
		public virtual void InterpolateAttributesOn()
		{
			vtkPlaneCutter.vtkPlaneCutter_InterpolateAttributesOn_23(base.GetCppThis());
		}

		// Token: 0x06019629 RID: 103977
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlaneCutter_IsA_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard construction and print methods.
		/// </summary>
		// Token: 0x0601962A RID: 103978 RVA: 0x00235E28 File Offset: 0x00234028
		public override int IsA(string type)
		{
			return vtkPlaneCutter.vtkPlaneCutter_IsA_24(base.GetCppThis(), type);
		}

		// Token: 0x0601962B RID: 103979
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlaneCutter_IsTypeOf_25([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard construction and print methods.
		/// </summary>
		// Token: 0x0601962C RID: 103980 RVA: 0x00235E48 File Offset: 0x00234048
		public new static int IsTypeOf(string type)
		{
			return vtkPlaneCutter.vtkPlaneCutter_IsTypeOf_25(type);
		}

		// Token: 0x0601962D RID: 103981
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneCutter_MergePointsOff_26(HandleRef pThis);

		/// <summary>
		/// Indicate whether to merge coincident points. Merging can take extra time
		/// and produces fewer output points, creating a "watertight" output
		/// surface. On the other hand, merging reduced output data size and may be
		/// just as fast. MergingPoints = off is meaningful only for vtkUnstructuredGrid,
		/// and vtkPolyData that all of its input cells are NOT convex polygons. For all the
		/// other input types, the output has unique points. Default is off.
		/// </summary>
		// Token: 0x0601962E RID: 103982 RVA: 0x00235E62 File Offset: 0x00234062
		public virtual void MergePointsOff()
		{
			vtkPlaneCutter.vtkPlaneCutter_MergePointsOff_26(base.GetCppThis());
		}

		// Token: 0x0601962F RID: 103983
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneCutter_MergePointsOn_27(HandleRef pThis);

		/// <summary>
		/// Indicate whether to merge coincident points. Merging can take extra time
		/// and produces fewer output points, creating a "watertight" output
		/// surface. On the other hand, merging reduced output data size and may be
		/// just as fast. MergingPoints = off is meaningful only for vtkUnstructuredGrid,
		/// and vtkPolyData that all of its input cells are NOT convex polygons. For all the
		/// other input types, the output has unique points. Default is off.
		/// </summary>
		// Token: 0x06019630 RID: 103984 RVA: 0x00235E71 File Offset: 0x00234071
		public virtual void MergePointsOn()
		{
			vtkPlaneCutter.vtkPlaneCutter_MergePointsOn_27(base.GetCppThis());
		}

		// Token: 0x06019631 RID: 103985
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlaneCutter_NewInstance_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard construction and print methods.
		/// </summary>
		// Token: 0x06019632 RID: 103986 RVA: 0x00235E80 File Offset: 0x00234080
		public new vtkPlaneCutter NewInstance()
		{
			vtkPlaneCutter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlaneCutter.vtkPlaneCutter_NewInstance_29(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlaneCutter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06019633 RID: 103987
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlaneCutter_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard construction and print methods.
		/// </summary>
		// Token: 0x06019634 RID: 103988 RVA: 0x00235EDC File Offset: 0x002340DC
		public new static vtkPlaneCutter SafeDownCast(vtkObjectBase o)
		{
			vtkPlaneCutter vtkPlaneCutter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlaneCutter.vtkPlaneCutter_SafeDownCast_30((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlaneCutter = (vtkPlaneCutter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlaneCutter.Register(null);
				}
			}
			return vtkPlaneCutter;
		}

		// Token: 0x06019635 RID: 103989
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneCutter_SetBuildHierarchy_31(HandleRef pThis, byte _arg);

		/// <summary>
		/// Indicate whether to build tree hierarchy. Computing the tree
		/// hierarchy can take some time on the first computation but if
		/// the input does not change, the computation of all further
		/// slice will be faster. Default is on.
		/// </summary>
		// Token: 0x06019636 RID: 103990 RVA: 0x00235F5B File Offset: 0x0023415B
		public virtual void SetBuildHierarchy(bool _arg)
		{
			vtkPlaneCutter.vtkPlaneCutter_SetBuildHierarchy_31(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06019637 RID: 103991
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneCutter_SetBuildTree_32(HandleRef pThis, byte _arg);

		/// <summary>
		/// Indicate whether to build the sphere tree. Computing the sphere
		/// will take some time on the first computation
		/// but if the input does not change, the computation of all further
		/// slice will be much faster. Default is on.
		/// </summary>
		// Token: 0x06019638 RID: 103992 RVA: 0x00235F73 File Offset: 0x00234173
		public virtual void SetBuildTree(bool _arg)
		{
			vtkPlaneCutter.vtkPlaneCutter_SetBuildTree_32(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06019639 RID: 103993
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneCutter_SetComputeNormals_33(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get the computation of normals. The normal generated is simply the
		/// cut plane normal. The normal, if generated, is defined by cell data
		/// associated with the output polygons. By default computing of normals is
		/// disabled.
		/// </summary>
		// Token: 0x0601963A RID: 103994 RVA: 0x00235F8B File Offset: 0x0023418B
		public virtual void SetComputeNormals(bool _arg)
		{
			vtkPlaneCutter.vtkPlaneCutter_SetComputeNormals_33(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0601963B RID: 103995
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneCutter_SetGeneratePolygons_34(HandleRef pThis, byte _arg);

		/// <summary>
		/// Indicate whether to generate polygons instead of triangles when cutting
		/// structured and rectilinear grid.
		/// No effect with other kinds of inputs, enabled by default.
		/// </summary>
		// Token: 0x0601963C RID: 103996 RVA: 0x00235FA3 File Offset: 0x002341A3
		public virtual void SetGeneratePolygons(bool _arg)
		{
			vtkPlaneCutter.vtkPlaneCutter_SetGeneratePolygons_34(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0601963D RID: 103997
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneCutter_SetInterpolateAttributes_35(HandleRef pThis, byte _arg);

		/// <summary>
		/// Indicate whether to interpolate attribute data. By default this is
		/// enabled. Note that both cell data and point data is interpolated and
		/// output, except for image data input where only point data are output.
		/// </summary>
		// Token: 0x0601963E RID: 103998 RVA: 0x00235FBB File Offset: 0x002341BB
		public virtual void SetInterpolateAttributes(bool _arg)
		{
			vtkPlaneCutter.vtkPlaneCutter_SetInterpolateAttributes_35(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0601963F RID: 103999
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneCutter_SetMergePoints_36(HandleRef pThis, byte _arg);

		/// <summary>
		/// Indicate whether to merge coincident points. Merging can take extra time
		/// and produces fewer output points, creating a "watertight" output
		/// surface. On the other hand, merging reduced output data size and may be
		/// just as fast. MergingPoints = off is meaningful only for vtkUnstructuredGrid,
		/// and vtkPolyData that all of its input cells are NOT convex polygons. For all the
		/// other input types, the output has unique points. Default is off.
		/// </summary>
		// Token: 0x06019640 RID: 104000 RVA: 0x00235FD3 File Offset: 0x002341D3
		public virtual void SetMergePoints(bool _arg)
		{
			vtkPlaneCutter.vtkPlaneCutter_SetMergePoints_36(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06019641 RID: 104001
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneCutter_SetOutputPointsPrecision_37(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06019642 RID: 104002 RVA: 0x00235FEB File Offset: 0x002341EB
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkPlaneCutter.vtkPlaneCutter_SetOutputPointsPrecision_37(base.GetCppThis(), _arg);
		}

		// Token: 0x06019643 RID: 104003
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneCutter_SetPlane_38(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the plane (an implicit function) to perform the cutting. The
		/// definition of the plane (its origin and normal) is controlled via this
		/// instance of vtkPlane.
		/// </summary>
		// Token: 0x06019644 RID: 104004 RVA: 0x00235FFC File Offset: 0x002341FC
		public virtual void SetPlane(vtkPlane arg0)
		{
			vtkPlaneCutter.vtkPlaneCutter_SetPlane_38(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BCB RID: 7115
		public new const string MRFullTypeName = "Kitware.VTK.vtkPlaneCutter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BCC RID: 7116
		public new static readonly string MRClassNameKey = "class vtkPlaneCutter";
	}
}
