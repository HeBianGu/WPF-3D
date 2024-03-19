using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkContour3DLinearGrid
	/// </summary>
	/// <remarks>
	///    fast generation of isosurface from 3D linear cells
	///
	/// vtkContour3DLinearGrid is a specialized filter that generates isocontours
	/// from an input vtkUnstructuredGrid consisting of 3D linear cells:
	/// tetrahedra, hexahedra, voxels, pyramids, and/or wedges. (The cells are
	/// linear in the sense that each cell edge is a straight line.) The filter is
	/// designed for high-speed, specialized operation. All other cell types are
	/// skipped and produce no output. (Note: the filter will also process
	/// input vtkCompositeDataSets containing vtkUnstructuredGrids.)
	///
	/// To use this filter you must specify an input unstructured grid or
	/// vtkCompositeDataSet, and one or more contour values.  You can either use
	/// the method SetValue() to specify each contour value, or use
	/// GenerateValues() to generate a series of evenly spaced contours.
	///
	/// The filter performance varies depending on optional output
	/// information. Basically if point merging is required (when PointMerging,
	/// InterpolateAttributes, and/or ComputeNormals is enabled), a sorting
	/// process is required to eliminate duplicate output points in the
	/// isosurface. Otherwise when point merging is not required, a fast path
	/// process produces independent triangles representing the isosurface. In
	/// many situations the results of the fast path are quite good and do not
	/// require additional processing.
	///
	/// Note that another performance option exists, using a vtkScalarTree, which
	/// is an object that accelerates isosurface extraction, at the initial cost
	/// of building the scalar tree. (This feature is useful for exploratory
	/// isosurface extraction when the isovalue is frequently changed.) In some
	/// cases this can improve performance, however this algorithm is so highly
	/// tuned that random memory jumps (due to random access of cells provided by
	/// the scalar tree) can actually negatively impact performance, especially if
	/// the input dataset type consists of homogeneous cell types.
	///
	/// @warning
	/// When the input is of type vtkCompositeDataSet the filter will process the
	/// unstructured grid(s) contained in the composite data set. As a result the
	/// output of this filter is then a composite data set (same as input) containing
	/// multiple vtkPolyData. When a vtkUnstructuredGrid is provided as input the
	/// output is a single vtkPolyData.
	///
	/// @warning
	/// The fast path simply produces output points and triangles (the fast path
	/// executes when MergePoints if off; InterpolateAttributes is off; and
	/// ComputeNormals is off). Since the fast path does not merge points, it
	/// produces many more output points, typically on the order of 5-6x more than
	/// when MergePoints is enabled. Adding in the other options point merging,
	/// field interpolation, and normal generation results in additional
	/// performance impacts. By default the fast path is enabled.
	///
	/// @warning
	/// When a vtkCompositeDataSet is provided as input, and UseScalarTree is
	/// enabled and a ScalarTree specified, then the specified scalar tree is
	/// cloned to create new ones for each dataset in the composite
	/// dataset. Otherwise (i.e., when vtkUnstructuredGrid input) the specified
	/// scalar tree is directly used (no cloning required).
	///
	/// @warning
	/// Internal to this filter, a caching iterator is used to traverse the cells
	/// that compose the vtkUnstructuredGrid. Maximum performance is obtained if
	/// the cells are all of one type (i.e., input grid of homogeneous cell
	/// types); repeated switching from different types may have detrimental
	/// effects on performance.
	///
	/// @warning
	/// For unstructured data, gradients are not computed. Normals are computed if
	/// requested; they are "pseudo-normals" in that the normals of output
	/// triangles that use a common point are averaged at the point. Alternatively
	/// use vtkPolyDataNormals to compute the surface normals.
	///
	/// @warning
	/// The output of this filter is subtly different than the more general filter
	/// vtkContourGrid. vtkContourGrid eliminates small, degenerate triangles with
	/// concident points which are consequently not sent to the output. In
	/// practice this makes little impact on visual appearance but may have
	/// repercussions if the output is used for modelling and/or analysis.
	///
	/// @warning
	/// Input cells that are not of 3D linear type (tetrahedron, hexahedron,
	/// wedge, pyramid, and voxel) are simply skipped and not processed.
	///
	/// @warning
	/// The filter is templated on types of input and output points, and input
	/// scalar type. To reduce object file bloat, only real points (float,double) are
	/// processed, and a limited subset of scalar types.
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkContourGrid vtkContourFilter vtkFlyingEdges3D vtkMarchingCubes
	/// vtkPolyDataNormals vtkStaticEdgeLocatorTemplate.h vtkScalarTree
	/// vtkSpanSpace
	/// </seealso>
	// Token: 0x02000950 RID: 2384
	public class vtkContour3DLinearGrid : vtkDataObjectAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06018B8C RID: 101260 RVA: 0x002285CF File Offset: 0x002267CF
		static vtkContour3DLinearGrid()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkContour3DLinearGrid.MRClassNameKey, Type.GetType("Kitware.VTK.vtkContour3DLinearGrid"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06018B8D RID: 101261 RVA: 0x002285F7 File Offset: 0x002267F7
		public vtkContour3DLinearGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06018B8E RID: 101262
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContour3DLinearGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for construction, type info, and printing.
		/// </summary>
		// Token: 0x06018B8F RID: 101263 RVA: 0x00228608 File Offset: 0x00226808
		public new static vtkContour3DLinearGrid New()
		{
			vtkContour3DLinearGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContour3DLinearGrid.vtkContour3DLinearGrid_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContour3DLinearGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for construction, type info, and printing.
		/// </summary>
		// Token: 0x06018B90 RID: 101264 RVA: 0x0022865C File Offset: 0x0022685C
		public vtkContour3DLinearGrid() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkContour3DLinearGrid.vtkContour3DLinearGrid_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06018B91 RID: 101265 RVA: 0x002286A0 File Offset: 0x002268A0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06018B92 RID: 101266
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkContour3DLinearGrid_CanFullyProcessDataObject_01(HandleRef arg0, [MarshalAs(UnmanagedType.LPUTF8Str)] string scalarArrayName);

		/// <summary>
		/// Returns true if the data object passed in is fully supported by this
		/// filter, i.e., all cell types are linear. For composite datasets, this
		/// means all dataset leaves have only linear cell types that can be processed
		/// by this filter. The second array is the name of the array to process.
		/// </summary>
		// Token: 0x06018B93 RID: 101267 RVA: 0x002286AC File Offset: 0x002268AC
		public static bool CanFullyProcessDataObject(vtkDataObject arg0, string scalarArrayName)
		{
			return vtkContour3DLinearGrid.vtkContour3DLinearGrid_CanFullyProcessDataObject_01((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), scalarArrayName) != 0;
		}

		// Token: 0x06018B94 RID: 101268
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContour3DLinearGrid_ComputeNormalsOff_02(HandleRef pThis);

		/// <summary>
		/// Indicate whether to compute output point normals. An averaging method is
		/// used to average shared triangle normals. By default this if off. This is
		/// a relatively expensive option so use judiciously.
		/// </summary>
		// Token: 0x06018B95 RID: 101269 RVA: 0x002286E2 File Offset: 0x002268E2
		public virtual void ComputeNormalsOff()
		{
			vtkContour3DLinearGrid.vtkContour3DLinearGrid_ComputeNormalsOff_02(base.GetCppThis());
		}

		// Token: 0x06018B96 RID: 101270
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContour3DLinearGrid_ComputeNormalsOn_03(HandleRef pThis);

		/// <summary>
		/// Indicate whether to compute output point normals. An averaging method is
		/// used to average shared triangle normals. By default this if off. This is
		/// a relatively expensive option so use judiciously.
		/// </summary>
		// Token: 0x06018B97 RID: 101271 RVA: 0x002286F1 File Offset: 0x002268F1
		public virtual void ComputeNormalsOn()
		{
			vtkContour3DLinearGrid.vtkContour3DLinearGrid_ComputeNormalsOn_03(base.GetCppThis());
		}

		// Token: 0x06018B98 RID: 101272
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContour3DLinearGrid_ComputeScalarsOff_04(HandleRef pThis);

		/// <summary>
		/// Set/Get flag to compute scalars. When enabled, and when the
		///             InterpolateAttributes option is on, vtkContour3DLinearGrid will add an
		///             array corresponding to the array used to compute the contour and
		///             populate it with values.
		/// </summary>
		// Token: 0x06018B99 RID: 101273 RVA: 0x00228700 File Offset: 0x00226900
		public virtual void ComputeScalarsOff()
		{
			vtkContour3DLinearGrid.vtkContour3DLinearGrid_ComputeScalarsOff_04(base.GetCppThis());
		}

		// Token: 0x06018B9A RID: 101274
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContour3DLinearGrid_ComputeScalarsOn_05(HandleRef pThis);

		/// <summary>
		/// Set/Get flag to compute scalars. When enabled, and when the
		///             InterpolateAttributes option is on, vtkContour3DLinearGrid will add an
		///             array corresponding to the array used to compute the contour and
		///             populate it with values.
		/// </summary>
		// Token: 0x06018B9B RID: 101275 RVA: 0x0022870F File Offset: 0x0022690F
		public virtual void ComputeScalarsOn()
		{
			vtkContour3DLinearGrid.vtkContour3DLinearGrid_ComputeScalarsOn_05(base.GetCppThis());
		}

		// Token: 0x06018B9C RID: 101276
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContour3DLinearGrid_GenerateValues_06(HandleRef pThis, int numContours, IntPtr range);

		/// <summary>
		/// Methods to set / get contour values.
		/// </summary>
		// Token: 0x06018B9D RID: 101277 RVA: 0x0022871E File Offset: 0x0022691E
		public void GenerateValues(int numContours, IntPtr range)
		{
			vtkContour3DLinearGrid.vtkContour3DLinearGrid_GenerateValues_06(base.GetCppThis(), numContours, range);
		}

		// Token: 0x06018B9E RID: 101278
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContour3DLinearGrid_GenerateValues_07(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

		/// <summary>
		/// Methods to set / get contour values.
		/// </summary>
		// Token: 0x06018B9F RID: 101279 RVA: 0x0022872F File Offset: 0x0022692F
		public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
		{
			vtkContour3DLinearGrid.vtkContour3DLinearGrid_GenerateValues_07(base.GetCppThis(), numContours, rangeStart, rangeEnd);
		}

		// Token: 0x06018BA0 RID: 101280
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContour3DLinearGrid_GetComputeNormals_08(HandleRef pThis);

		/// <summary>
		/// Indicate whether to compute output point normals. An averaging method is
		/// used to average shared triangle normals. By default this if off. This is
		/// a relatively expensive option so use judiciously.
		/// </summary>
		// Token: 0x06018BA1 RID: 101281 RVA: 0x00228744 File Offset: 0x00226944
		public virtual int GetComputeNormals()
		{
			return vtkContour3DLinearGrid.vtkContour3DLinearGrid_GetComputeNormals_08(base.GetCppThis());
		}

		// Token: 0x06018BA2 RID: 101282
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContour3DLinearGrid_GetComputeScalars_09(HandleRef pThis);

		/// <summary>
		/// Set/Get flag to compute scalars. When enabled, and when the
		///             InterpolateAttributes option is on, vtkContour3DLinearGrid will add an
		///             array corresponding to the array used to compute the contour and
		///             populate it with values.
		/// </summary>
		// Token: 0x06018BA3 RID: 101283 RVA: 0x00228764 File Offset: 0x00226964
		public virtual int GetComputeScalars()
		{
			return vtkContour3DLinearGrid.vtkContour3DLinearGrid_GetComputeScalars_09(base.GetCppThis());
		}

		// Token: 0x06018BA4 RID: 101284
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContour3DLinearGrid_GetInterpolateAttributes_10(HandleRef pThis);

		/// <summary>
		/// Indicate whether to interpolate input attributes onto the isosurface. By
		/// default this option is off.
		/// </summary>
		// Token: 0x06018BA5 RID: 101285 RVA: 0x00228784 File Offset: 0x00226984
		public virtual int GetInterpolateAttributes()
		{
			return vtkContour3DLinearGrid.vtkContour3DLinearGrid_GetInterpolateAttributes_10(base.GetCppThis());
		}

		// Token: 0x06018BA6 RID: 101286
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkContour3DLinearGrid_GetLargeIds_11(HandleRef pThis);

		/// <summary>
		/// Inform the user as to whether large ids were used during filter
		/// execution. This flag only has meaning after the filter has executed.
		/// Large ids are used when the id of the larges cell or point is greater
		/// than signed 32-bit precision. (Smaller ids reduce memory usage and speed
		/// computation. Note that LargeIds are only available on 64-bit
		/// architectures.)
		/// </summary>
		// Token: 0x06018BA7 RID: 101287 RVA: 0x002287A4 File Offset: 0x002269A4
		public bool GetLargeIds()
		{
			return vtkContour3DLinearGrid.vtkContour3DLinearGrid_GetLargeIds_11(base.GetCppThis()) != 0;
		}

		// Token: 0x06018BA8 RID: 101288
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkContour3DLinearGrid_GetMTime_12(HandleRef pThis);

		/// <summary>
		/// Overloaded GetMTime() because of delegation to the internal
		/// vtkContourValues class.
		/// </summary>
		// Token: 0x06018BA9 RID: 101289 RVA: 0x002287CC File Offset: 0x002269CC
		public override ulong GetMTime()
		{
			return vtkContour3DLinearGrid.vtkContour3DLinearGrid_GetMTime_12(base.GetCppThis());
		}

		// Token: 0x06018BAA RID: 101290
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContour3DLinearGrid_GetMergePoints_13(HandleRef pThis);

		/// <summary>
		/// Indicate whether to merge coincident points. This takes extra time and
		/// produces fewer output points, creating a "watertight" contour
		/// surface. By default this is off.
		/// </summary>
		// Token: 0x06018BAB RID: 101291 RVA: 0x002287EC File Offset: 0x002269EC
		public virtual int GetMergePoints()
		{
			return vtkContour3DLinearGrid.vtkContour3DLinearGrid_GetMergePoints_13(base.GetCppThis());
		}

		// Token: 0x06018BAC RID: 101292
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkContour3DLinearGrid_GetNumberOfContours_14(HandleRef pThis);

		/// <summary>
		/// Methods to set / get contour values.
		/// </summary>
		// Token: 0x06018BAD RID: 101293 RVA: 0x0022880C File Offset: 0x00226A0C
		public long GetNumberOfContours()
		{
			return vtkContour3DLinearGrid.vtkContour3DLinearGrid_GetNumberOfContours_14(base.GetCppThis());
		}

		// Token: 0x06018BAE RID: 101294
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkContour3DLinearGrid_GetNumberOfGenerationsFromBase_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for construction, type info, and printing.
		/// </summary>
		// Token: 0x06018BAF RID: 101295 RVA: 0x0022882C File Offset: 0x00226A2C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkContour3DLinearGrid.vtkContour3DLinearGrid_GetNumberOfGenerationsFromBase_15(base.GetCppThis(), type);
		}

		// Token: 0x06018BB0 RID: 101296
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkContour3DLinearGrid_GetNumberOfGenerationsFromBaseType_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for construction, type info, and printing.
		/// </summary>
		// Token: 0x06018BB1 RID: 101297 RVA: 0x0022884C File Offset: 0x00226A4C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkContour3DLinearGrid.vtkContour3DLinearGrid_GetNumberOfGenerationsFromBaseType_16(type);
		}

		// Token: 0x06018BB2 RID: 101298
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContour3DLinearGrid_GetNumberOfThreadsUsed_17(HandleRef pThis);

		/// <summary>
		///  Return the number of threads actually used during execution. This is
		///  valid only after algorithm execution.
		/// </summary>
		// Token: 0x06018BB3 RID: 101299 RVA: 0x00228868 File Offset: 0x00226A68
		public int GetNumberOfThreadsUsed()
		{
			return vtkContour3DLinearGrid.vtkContour3DLinearGrid_GetNumberOfThreadsUsed_17(base.GetCppThis());
		}

		// Token: 0x06018BB4 RID: 101300
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContour3DLinearGrid_GetOutputPointsPrecision_18(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::Precision enum for an explanation of the available
		/// precision settings.
		/// </summary>
		// Token: 0x06018BB5 RID: 101301 RVA: 0x00228888 File Offset: 0x00226A88
		public virtual int GetOutputPointsPrecision()
		{
			return vtkContour3DLinearGrid.vtkContour3DLinearGrid_GetOutputPointsPrecision_18(base.GetCppThis());
		}

		// Token: 0x06018BB6 RID: 101302
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContour3DLinearGrid_GetScalarTree_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the scalar tree to use. By default a vtkSpanSpace scalar tree is
		/// used.
		/// </summary>
		// Token: 0x06018BB7 RID: 101303 RVA: 0x002288A8 File Offset: 0x00226AA8
		public virtual vtkScalarTree GetScalarTree()
		{
			vtkScalarTree vtkScalarTree = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContour3DLinearGrid.vtkContour3DLinearGrid_GetScalarTree_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScalarTree = (vtkScalarTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScalarTree.Register(null);
				}
			}
			return vtkScalarTree;
		}

		// Token: 0x06018BB8 RID: 101304
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContour3DLinearGrid_GetSequentialProcessing_20(HandleRef pThis);

		/// <summary>
		/// Force sequential processing (i.e. single thread) of the contouring
		/// process. By default, sequential processing is off. Note this flag only
		/// applies if the class has been compiled with VTK_SMP_IMPLEMENTATION_TYPE
		/// set to something other than Sequential. (If set to Sequential, then the
		/// filter always runs in serial mode.) This flag is typically used for
		/// benchmarking purposes.
		/// </summary>
		// Token: 0x06018BB9 RID: 101305 RVA: 0x00228918 File Offset: 0x00226B18
		public virtual int GetSequentialProcessing()
		{
			return vtkContour3DLinearGrid.vtkContour3DLinearGrid_GetSequentialProcessing_20(base.GetCppThis());
		}

		// Token: 0x06018BBA RID: 101306
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContour3DLinearGrid_GetUseScalarTree_21(HandleRef pThis);

		/// <summary>
		/// Enable the use of a scalar tree to accelerate contour extraction. By
		/// default this is off. If enabled, and a scalar tree is not specified, then
		/// a vtkSpanSpace instance will be constructed and used.
		/// </summary>
		// Token: 0x06018BBB RID: 101307 RVA: 0x00228938 File Offset: 0x00226B38
		public virtual int GetUseScalarTree()
		{
			return vtkContour3DLinearGrid.vtkContour3DLinearGrid_GetUseScalarTree_21(base.GetCppThis());
		}

		// Token: 0x06018BBC RID: 101308
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkContour3DLinearGrid_GetValue_22(HandleRef pThis, int i);

		/// <summary>
		/// Methods to set / get contour values.
		/// </summary>
		// Token: 0x06018BBD RID: 101309 RVA: 0x00228958 File Offset: 0x00226B58
		public double GetValue(int i)
		{
			return vtkContour3DLinearGrid.vtkContour3DLinearGrid_GetValue_22(base.GetCppThis(), i);
		}

		// Token: 0x06018BBE RID: 101310
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContour3DLinearGrid_GetValues_23(HandleRef pThis);

		/// <summary>
		/// Methods to set / get contour values.
		/// </summary>
		// Token: 0x06018BBF RID: 101311 RVA: 0x00228978 File Offset: 0x00226B78
		public IntPtr GetValues()
		{
			return vtkContour3DLinearGrid.vtkContour3DLinearGrid_GetValues_23(base.GetCppThis());
		}

		// Token: 0x06018BC0 RID: 101312
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContour3DLinearGrid_GetValues_24(HandleRef pThis, IntPtr contourValues);

		/// <summary>
		/// Methods to set / get contour values.
		/// </summary>
		// Token: 0x06018BC1 RID: 101313 RVA: 0x00228997 File Offset: 0x00226B97
		public void GetValues(IntPtr contourValues)
		{
			vtkContour3DLinearGrid.vtkContour3DLinearGrid_GetValues_24(base.GetCppThis(), contourValues);
		}

		// Token: 0x06018BC2 RID: 101314
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContour3DLinearGrid_InterpolateAttributesOff_25(HandleRef pThis);

		/// <summary>
		/// Indicate whether to interpolate input attributes onto the isosurface. By
		/// default this option is off.
		/// </summary>
		// Token: 0x06018BC3 RID: 101315 RVA: 0x002289A7 File Offset: 0x00226BA7
		public virtual void InterpolateAttributesOff()
		{
			vtkContour3DLinearGrid.vtkContour3DLinearGrid_InterpolateAttributesOff_25(base.GetCppThis());
		}

		// Token: 0x06018BC4 RID: 101316
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContour3DLinearGrid_InterpolateAttributesOn_26(HandleRef pThis);

		/// <summary>
		/// Indicate whether to interpolate input attributes onto the isosurface. By
		/// default this option is off.
		/// </summary>
		// Token: 0x06018BC5 RID: 101317 RVA: 0x002289B6 File Offset: 0x00226BB6
		public virtual void InterpolateAttributesOn()
		{
			vtkContour3DLinearGrid.vtkContour3DLinearGrid_InterpolateAttributesOn_26(base.GetCppThis());
		}

		// Token: 0x06018BC6 RID: 101318
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContour3DLinearGrid_IsA_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for construction, type info, and printing.
		/// </summary>
		// Token: 0x06018BC7 RID: 101319 RVA: 0x002289C8 File Offset: 0x00226BC8
		public override int IsA(string type)
		{
			return vtkContour3DLinearGrid.vtkContour3DLinearGrid_IsA_27(base.GetCppThis(), type);
		}

		// Token: 0x06018BC8 RID: 101320
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContour3DLinearGrid_IsTypeOf_28([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for construction, type info, and printing.
		/// </summary>
		// Token: 0x06018BC9 RID: 101321 RVA: 0x002289E8 File Offset: 0x00226BE8
		public new static int IsTypeOf(string type)
		{
			return vtkContour3DLinearGrid.vtkContour3DLinearGrid_IsTypeOf_28(type);
		}

		// Token: 0x06018BCA RID: 101322
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContour3DLinearGrid_MergePointsOff_29(HandleRef pThis);

		/// <summary>
		/// Indicate whether to merge coincident points. This takes extra time and
		/// produces fewer output points, creating a "watertight" contour
		/// surface. By default this is off.
		/// </summary>
		// Token: 0x06018BCB RID: 101323 RVA: 0x00228A02 File Offset: 0x00226C02
		public virtual void MergePointsOff()
		{
			vtkContour3DLinearGrid.vtkContour3DLinearGrid_MergePointsOff_29(base.GetCppThis());
		}

		// Token: 0x06018BCC RID: 101324
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContour3DLinearGrid_MergePointsOn_30(HandleRef pThis);

		/// <summary>
		/// Indicate whether to merge coincident points. This takes extra time and
		/// produces fewer output points, creating a "watertight" contour
		/// surface. By default this is off.
		/// </summary>
		// Token: 0x06018BCD RID: 101325 RVA: 0x00228A11 File Offset: 0x00226C11
		public virtual void MergePointsOn()
		{
			vtkContour3DLinearGrid.vtkContour3DLinearGrid_MergePointsOn_30(base.GetCppThis());
		}

		// Token: 0x06018BCE RID: 101326
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContour3DLinearGrid_NewInstance_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for construction, type info, and printing.
		/// </summary>
		// Token: 0x06018BCF RID: 101327 RVA: 0x00228A20 File Offset: 0x00226C20
		public new vtkContour3DLinearGrid NewInstance()
		{
			vtkContour3DLinearGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContour3DLinearGrid.vtkContour3DLinearGrid_NewInstance_32(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContour3DLinearGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06018BD0 RID: 101328
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContour3DLinearGrid_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for construction, type info, and printing.
		/// </summary>
		// Token: 0x06018BD1 RID: 101329 RVA: 0x00228A7C File Offset: 0x00226C7C
		public new static vtkContour3DLinearGrid SafeDownCast(vtkObjectBase o)
		{
			vtkContour3DLinearGrid vtkContour3DLinearGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContour3DLinearGrid.vtkContour3DLinearGrid_SafeDownCast_33((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkContour3DLinearGrid = (vtkContour3DLinearGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkContour3DLinearGrid.Register(null);
				}
			}
			return vtkContour3DLinearGrid;
		}

		// Token: 0x06018BD2 RID: 101330
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContour3DLinearGrid_SequentialProcessingOff_34(HandleRef pThis);

		/// <summary>
		/// Force sequential processing (i.e. single thread) of the contouring
		/// process. By default, sequential processing is off. Note this flag only
		/// applies if the class has been compiled with VTK_SMP_IMPLEMENTATION_TYPE
		/// set to something other than Sequential. (If set to Sequential, then the
		/// filter always runs in serial mode.) This flag is typically used for
		/// benchmarking purposes.
		/// </summary>
		// Token: 0x06018BD3 RID: 101331 RVA: 0x00228AFB File Offset: 0x00226CFB
		public virtual void SequentialProcessingOff()
		{
			vtkContour3DLinearGrid.vtkContour3DLinearGrid_SequentialProcessingOff_34(base.GetCppThis());
		}

		// Token: 0x06018BD4 RID: 101332
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContour3DLinearGrid_SequentialProcessingOn_35(HandleRef pThis);

		/// <summary>
		/// Force sequential processing (i.e. single thread) of the contouring
		/// process. By default, sequential processing is off. Note this flag only
		/// applies if the class has been compiled with VTK_SMP_IMPLEMENTATION_TYPE
		/// set to something other than Sequential. (If set to Sequential, then the
		/// filter always runs in serial mode.) This flag is typically used for
		/// benchmarking purposes.
		/// </summary>
		// Token: 0x06018BD5 RID: 101333 RVA: 0x00228B0A File Offset: 0x00226D0A
		public virtual void SequentialProcessingOn()
		{
			vtkContour3DLinearGrid.vtkContour3DLinearGrid_SequentialProcessingOn_35(base.GetCppThis());
		}

		// Token: 0x06018BD6 RID: 101334
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContour3DLinearGrid_SetComputeNormals_36(HandleRef pThis, int _arg);

		/// <summary>
		/// Indicate whether to compute output point normals. An averaging method is
		/// used to average shared triangle normals. By default this if off. This is
		/// a relatively expensive option so use judiciously.
		/// </summary>
		// Token: 0x06018BD7 RID: 101335 RVA: 0x00228B19 File Offset: 0x00226D19
		public virtual void SetComputeNormals(int _arg)
		{
			vtkContour3DLinearGrid.vtkContour3DLinearGrid_SetComputeNormals_36(base.GetCppThis(), _arg);
		}

		// Token: 0x06018BD8 RID: 101336
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContour3DLinearGrid_SetComputeScalars_37(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get flag to compute scalars. When enabled, and when the
		///             InterpolateAttributes option is on, vtkContour3DLinearGrid will add an
		///             array corresponding to the array used to compute the contour and
		///             populate it with values.
		/// </summary>
		// Token: 0x06018BD9 RID: 101337 RVA: 0x00228B29 File Offset: 0x00226D29
		public virtual void SetComputeScalars(int _arg)
		{
			vtkContour3DLinearGrid.vtkContour3DLinearGrid_SetComputeScalars_37(base.GetCppThis(), _arg);
		}

		// Token: 0x06018BDA RID: 101338
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContour3DLinearGrid_SetInterpolateAttributes_38(HandleRef pThis, int _arg);

		/// <summary>
		/// Indicate whether to interpolate input attributes onto the isosurface. By
		/// default this option is off.
		/// </summary>
		// Token: 0x06018BDB RID: 101339 RVA: 0x00228B39 File Offset: 0x00226D39
		public virtual void SetInterpolateAttributes(int _arg)
		{
			vtkContour3DLinearGrid.vtkContour3DLinearGrid_SetInterpolateAttributes_38(base.GetCppThis(), _arg);
		}

		// Token: 0x06018BDC RID: 101340
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContour3DLinearGrid_SetMergePoints_39(HandleRef pThis, int _arg);

		/// <summary>
		/// Indicate whether to merge coincident points. This takes extra time and
		/// produces fewer output points, creating a "watertight" contour
		/// surface. By default this is off.
		/// </summary>
		// Token: 0x06018BDD RID: 101341 RVA: 0x00228B49 File Offset: 0x00226D49
		public virtual void SetMergePoints(int _arg)
		{
			vtkContour3DLinearGrid.vtkContour3DLinearGrid_SetMergePoints_39(base.GetCppThis(), _arg);
		}

		// Token: 0x06018BDE RID: 101342
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContour3DLinearGrid_SetNumberOfContours_40(HandleRef pThis, int number);

		/// <summary>
		/// Methods to set / get contour values.
		/// </summary>
		// Token: 0x06018BDF RID: 101343 RVA: 0x00228B59 File Offset: 0x00226D59
		public void SetNumberOfContours(int number)
		{
			vtkContour3DLinearGrid.vtkContour3DLinearGrid_SetNumberOfContours_40(base.GetCppThis(), number);
		}

		// Token: 0x06018BE0 RID: 101344
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContour3DLinearGrid_SetOutputPointsPrecision_41(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::Precision enum for an explanation of the available
		/// precision settings.
		/// </summary>
		// Token: 0x06018BE1 RID: 101345 RVA: 0x00228B69 File Offset: 0x00226D69
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkContour3DLinearGrid.vtkContour3DLinearGrid_SetOutputPointsPrecision_41(base.GetCppThis(), _arg);
		}

		// Token: 0x06018BE2 RID: 101346
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContour3DLinearGrid_SetScalarTree_42(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the scalar tree to use. By default a vtkSpanSpace scalar tree is
		/// used.
		/// </summary>
		// Token: 0x06018BE3 RID: 101347 RVA: 0x00228B7C File Offset: 0x00226D7C
		public virtual void SetScalarTree(vtkScalarTree arg0)
		{
			vtkContour3DLinearGrid.vtkContour3DLinearGrid_SetScalarTree_42(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06018BE4 RID: 101348
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContour3DLinearGrid_SetSequentialProcessing_43(HandleRef pThis, int _arg);

		/// <summary>
		/// Force sequential processing (i.e. single thread) of the contouring
		/// process. By default, sequential processing is off. Note this flag only
		/// applies if the class has been compiled with VTK_SMP_IMPLEMENTATION_TYPE
		/// set to something other than Sequential. (If set to Sequential, then the
		/// filter always runs in serial mode.) This flag is typically used for
		/// benchmarking purposes.
		/// </summary>
		// Token: 0x06018BE5 RID: 101349 RVA: 0x00228BAB File Offset: 0x00226DAB
		public virtual void SetSequentialProcessing(int _arg)
		{
			vtkContour3DLinearGrid.vtkContour3DLinearGrid_SetSequentialProcessing_43(base.GetCppThis(), _arg);
		}

		// Token: 0x06018BE6 RID: 101350
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContour3DLinearGrid_SetUseScalarTree_44(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable the use of a scalar tree to accelerate contour extraction. By
		/// default this is off. If enabled, and a scalar tree is not specified, then
		/// a vtkSpanSpace instance will be constructed and used.
		/// </summary>
		// Token: 0x06018BE7 RID: 101351 RVA: 0x00228BBB File Offset: 0x00226DBB
		public virtual void SetUseScalarTree(int _arg)
		{
			vtkContour3DLinearGrid.vtkContour3DLinearGrid_SetUseScalarTree_44(base.GetCppThis(), _arg);
		}

		// Token: 0x06018BE8 RID: 101352
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContour3DLinearGrid_SetValue_45(HandleRef pThis, int i, double value);

		/// <summary>
		/// Methods to set / get contour values.
		/// </summary>
		// Token: 0x06018BE9 RID: 101353 RVA: 0x00228BCB File Offset: 0x00226DCB
		public void SetValue(int i, double value)
		{
			vtkContour3DLinearGrid.vtkContour3DLinearGrid_SetValue_45(base.GetCppThis(), i, value);
		}

		// Token: 0x06018BEA RID: 101354
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContour3DLinearGrid_UseScalarTreeOff_46(HandleRef pThis);

		/// <summary>
		/// Enable the use of a scalar tree to accelerate contour extraction. By
		/// default this is off. If enabled, and a scalar tree is not specified, then
		/// a vtkSpanSpace instance will be constructed and used.
		/// </summary>
		// Token: 0x06018BEB RID: 101355 RVA: 0x00228BDC File Offset: 0x00226DDC
		public virtual void UseScalarTreeOff()
		{
			vtkContour3DLinearGrid.vtkContour3DLinearGrid_UseScalarTreeOff_46(base.GetCppThis());
		}

		// Token: 0x06018BEC RID: 101356
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContour3DLinearGrid_UseScalarTreeOn_47(HandleRef pThis);

		/// <summary>
		/// Enable the use of a scalar tree to accelerate contour extraction. By
		/// default this is off. If enabled, and a scalar tree is not specified, then
		/// a vtkSpanSpace instance will be constructed and used.
		/// </summary>
		// Token: 0x06018BED RID: 101357 RVA: 0x00228BEB File Offset: 0x00226DEB
		public virtual void UseScalarTreeOn()
		{
			vtkContour3DLinearGrid.vtkContour3DLinearGrid_UseScalarTreeOn_47(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B59 RID: 7001
		public new const string MRFullTypeName = "Kitware.VTK.vtkContour3DLinearGrid";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B5A RID: 7002
		public new static readonly string MRClassNameKey = "class vtkContour3DLinearGrid";
	}
}
