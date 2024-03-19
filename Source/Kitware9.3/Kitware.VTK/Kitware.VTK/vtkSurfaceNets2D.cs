using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSurfaceNets2D
	/// </summary>
	/// <remarks>
	///    generate smoothed constours from segmented 2D image data (i.e., "label maps")
	///
	/// vtkSurfaceNets2D creates boundary/isocontour lines from a label map (e.g.,
	/// a segmented image) using a threaded, 2D version of the multiple
	/// regions/labels surface nets algorithm. The input is a 2D image where each
	/// pixel is labeled (integer labels are preferred to real values), and the
	/// output data is polygonal data separating labeled regions via line
	/// segments. (Note that on output each region [corresponding to a different
	/// segmented object] will share points/edges on a common boundary, i.e., two
	/// objects next to each other will share the boundary that separates them.)
	///
	/// While this filter is similar to a contouring operation, classic contouring
	/// methods assume a continuous scalar field. In comparison, label maps are
	/// not continuous in scalar function value, meaning that usual data
	/// interpolation (e.g., along edges) is not possible. Instead, when the edge
	/// endpoint pixels are labeled in differing regions, the edge is split and
	/// transected by a line segment that connects the center points of the squares
	/// on either side of the edge. Later, using a energy minimization smoothing
	/// process, these split edges will be adjusted to produce a smoother
	/// result. (Constraints on smoothing displacements may be specified to
	/// prevent excessive shrinkage and/or object distortion.)
	///
	/// The smoothing process is controlled by setting a convergence measure, the
	/// number of smoothing iterations, the step size, and the allowed
	/// (constraint) distance that points may move.  These can be adjusted to
	/// provide the desired result. This class provides a method to access an
	/// internal instance of vtkConstrainedSmoothingFilter, through which these
	/// smoothing parameters may be specified, and which actually performs the
	/// smoothing operation. (Note: it is possible to skip the smoothing process
	/// altogether by disabling smoothing (e.g., invoking SmoothingOff()) or
	/// setting the number of smoothing iterations to zero. This can
	/// be useful when using a different smoothing filter like
	/// vtkWindowedSincPolyDataFilter; or if an unsmoothed, aliased output is
	/// desired. The reason the smoothing is built in to this filter is to remain
	/// faithful to the published literature describing the surface nets
	/// algorithm.)
	///
	/// The SurfaceNets algorithm was first proposed by Sarah Frisken.  Two
	/// important papers include the description of surface nets for binary
	/// objects (i.e., extracting just one segmented object from a volume) and
	/// multi-label (multiple object extraction).
	///
	/// S. Frisken (Gibson), “Constrained Elastic SurfaceNets: Generating Smooth
	/// Surfaces from Binary Segmented Data”, Proc. MICCAI, 1998, pp. 888-898.
	///
	/// S. Frisken, “SurfaceNets for Multi-Label Segmentations with Preservation
	/// of Sharp Boundaries”, J. Computer Graphics Techniques, 2022.
	///
	/// Note that one nice feature of this filter is that algorithm execution
	/// occurs only once no matter the number of object labels / contour
	/// values. In many contouring-like algorithms, each separate contour value
	/// requires an additional algorithm execution with a new contour value. So in
	/// this filter large numbers of contour values do not significantly affect
	/// overall speed. The user can specify which objects (i.e., labels) are to be
	/// output to the filter. (Unspecified labels are treated as background and
	/// not output.)
	///
	/// The filter can optionally output a two-component, cell data array
	/// indicating the labels/regions on either side of the line segments
	/// composing the output vtkPolyData. This can be used for advanced operations
	/// like extracting shared/contacting boundaries between two objects. The name
	/// of this cell data array is "BoundaryLabels".
	///
	/// Implementation note: For performance reasons, this filter is internally
	/// implemented quite differently than described in the literature.  The main
	/// difference is that concepts from the Flying Edges parallel isocontouring
	/// algorithm are used. Namely, parallel, edge-by-edge processing is used to
	/// define cell cases, generate smoothing stencils, and produce points and
	/// output lines. The smoothing process is also threaded using a
	/// double-buffering approach.
	///
	/// @warning
	/// This filter is specialized to 2D images.
	///
	/// @warning
	/// Subtle differences in the output may result when the number of objects /
	/// labels changes. This is because the smoothing operation operates on all of
	/// the boundaries simultaneously. If the boundaries change due to a
	/// difference in the number of regions / labels, then the smoothing operation
	/// can produce different results.
	///
	/// @warning
	/// The filters vtkDiscreteMarchingCubes, vtkDiscreteFlyingEdges2D,
	/// vtkDiscreteFlyingEdges3D, and vtkDiscreteFlyingEdgesClipper2D also
	/// perform isocontour extraction. However these filters produce output
	/// that may not share common boundary cells, and may produce "gaps"
	/// between segmented regions. For example, vtkDiscreteMarchingCubes will
	/// share points between adjacent regions, but not triangle cells (which
	/// will be coincident). Also, no center point is inserted into voxels,
	/// meaning that intermittent gaps may form between regions.
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// @warning
	/// See also vtkPackLabels which is a utility class for renumbering the labels
	/// found in the input segmentation mask to contiguous forms of smaller type.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkSurfaceNets3D vtkDiscreteFlyingEdges2D vtkDiscreteFlyingEdgesClipper2D
	/// vtkConstrainedSmoothingFilter vtkFlyingEdges2D vtkFlyingEdges3D
	/// vtkWindowedSincPolyDataFilter vtkPackLabels
	/// </seealso>
	// Token: 0x020009AA RID: 2474
	public class vtkSurfaceNets2D : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06019D31 RID: 105777 RVA: 0x0023DDA3 File Offset: 0x0023BFA3
		static vtkSurfaceNets2D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSurfaceNets2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSurfaceNets2D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06019D32 RID: 105778 RVA: 0x0023DDCB File Offset: 0x0023BFCB
		public vtkSurfaceNets2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06019D33 RID: 105779
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSurfaceNets2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, printing, and type information.
		/// </summary>
		// Token: 0x06019D34 RID: 105780 RVA: 0x0023DDDC File Offset: 0x0023BFDC
		public new static vtkSurfaceNets2D New()
		{
			vtkSurfaceNets2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSurfaceNets2D.vtkSurfaceNets2D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSurfaceNets2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, printing, and type information.
		/// </summary>
		// Token: 0x06019D35 RID: 105781 RVA: 0x0023DE30 File Offset: 0x0023C030
		public vtkSurfaceNets2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSurfaceNets2D.vtkSurfaceNets2D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06019D36 RID: 105782 RVA: 0x0023DE74 File Offset: 0x0023C074
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06019D37 RID: 105783
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets2D_ComputeScalarsOff_01(HandleRef pThis);

		/// <summary>
		/// Enable/disable an option to generate cell scalars in the output. The
		/// cell scalars are a two-tuple that indicates which labels (i.e.,
		/// segmented regions) are on either side of each (line) cell (l0,l1) with
		/// l0&lt;l1.  If an object is one-sided (meaning the background is on one side
		/// of the line) then l1=(OutsideLabel). The name of the output cell scalars is
		/// "BoundaryLabels". By default this flag is on.
		/// </summary>
		// Token: 0x06019D38 RID: 105784 RVA: 0x0023DE7F File Offset: 0x0023C07F
		public virtual void ComputeScalarsOff()
		{
			vtkSurfaceNets2D.vtkSurfaceNets2D_ComputeScalarsOff_01(base.GetCppThis());
		}

		// Token: 0x06019D39 RID: 105785
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets2D_ComputeScalarsOn_02(HandleRef pThis);

		/// <summary>
		/// Enable/disable an option to generate cell scalars in the output. The
		/// cell scalars are a two-tuple that indicates which labels (i.e.,
		/// segmented regions) are on either side of each (line) cell (l0,l1) with
		/// l0&lt;l1.  If an object is one-sided (meaning the background is on one side
		/// of the line) then l1=(OutsideLabel). The name of the output cell scalars is
		/// "BoundaryLabels". By default this flag is on.
		/// </summary>
		// Token: 0x06019D3A RID: 105786 RVA: 0x0023DE8E File Offset: 0x0023C08E
		public virtual void ComputeScalarsOn()
		{
			vtkSurfaceNets2D.vtkSurfaceNets2D_ComputeScalarsOn_02(base.GetCppThis());
		}

		// Token: 0x06019D3B RID: 105787
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets2D_DataCachingOff_03(HandleRef pThis);

		/// <summary>
		/// Enable caching of intermediate data. A common workflow using this filter
		/// requires extracting object boundaries, and then repeatedly rerunning the
		/// smoothing process with different parameters. To improve performance by
		/// avoiding repeated extraction of the boundary, the filter can cache
		/// intermediate data prior to the smoothing process. In this way, the
		/// boundary is only extracted once, and as long as only the internal
		/// constrained smoothing filter is modified, then boundary extraction will
		/// not be reexecuted. By default this is enabled.
		/// </summary>
		// Token: 0x06019D3C RID: 105788 RVA: 0x0023DE9D File Offset: 0x0023C09D
		public virtual void DataCachingOff()
		{
			vtkSurfaceNets2D.vtkSurfaceNets2D_DataCachingOff_03(base.GetCppThis());
		}

		// Token: 0x06019D3D RID: 105789
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets2D_DataCachingOn_04(HandleRef pThis);

		/// <summary>
		/// Enable caching of intermediate data. A common workflow using this filter
		/// requires extracting object boundaries, and then repeatedly rerunning the
		/// smoothing process with different parameters. To improve performance by
		/// avoiding repeated extraction of the boundary, the filter can cache
		/// intermediate data prior to the smoothing process. In this way, the
		/// boundary is only extracted once, and as long as only the internal
		/// constrained smoothing filter is modified, then boundary extraction will
		/// not be reexecuted. By default this is enabled.
		/// </summary>
		// Token: 0x06019D3E RID: 105790 RVA: 0x0023DEAC File Offset: 0x0023C0AC
		public virtual void DataCachingOn()
		{
			vtkSurfaceNets2D.vtkSurfaceNets2D_DataCachingOn_04(base.GetCppThis());
		}

		// Token: 0x06019D3F RID: 105791
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets2D_GenerateLabels_05(HandleRef pThis, int numLabels, IntPtr range);

		/// <summary>
		/// Generate numLabels equally spaced labels between the specified
		/// range. The labels will include the min/max range values.
		/// </summary>
		// Token: 0x06019D40 RID: 105792 RVA: 0x0023DEBB File Offset: 0x0023C0BB
		public void GenerateLabels(int numLabels, IntPtr range)
		{
			vtkSurfaceNets2D.vtkSurfaceNets2D_GenerateLabels_05(base.GetCppThis(), numLabels, range);
		}

		// Token: 0x06019D41 RID: 105793
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets2D_GenerateLabels_06(HandleRef pThis, int numLabels, double rangeStart, double rangeEnd);

		/// <summary>
		/// Generate numLabels equally spaced labels between the specified
		/// range. The labels will include the min/max range values.
		/// </summary>
		// Token: 0x06019D42 RID: 105794 RVA: 0x0023DECC File Offset: 0x0023C0CC
		public void GenerateLabels(int numLabels, double rangeStart, double rangeEnd)
		{
			vtkSurfaceNets2D.vtkSurfaceNets2D_GenerateLabels_06(base.GetCppThis(), numLabels, rangeStart, rangeEnd);
		}

		// Token: 0x06019D43 RID: 105795
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets2D_GenerateValues_07(HandleRef pThis, int numContours, IntPtr range);

		/// <summary>
		/// Generate numLabels equally spaced labels between the specified
		/// range. The labels will include the min/max range values.
		/// </summary>
		// Token: 0x06019D44 RID: 105796 RVA: 0x0023DEDE File Offset: 0x0023C0DE
		public void GenerateValues(int numContours, IntPtr range)
		{
			vtkSurfaceNets2D.vtkSurfaceNets2D_GenerateValues_07(base.GetCppThis(), numContours, range);
		}

		// Token: 0x06019D45 RID: 105797
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets2D_GenerateValues_08(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

		/// <summary>
		/// Generate numLabels equally spaced labels between the specified
		/// range. The labels will include the min/max range values.
		/// </summary>
		// Token: 0x06019D46 RID: 105798 RVA: 0x0023DEEF File Offset: 0x0023C0EF
		public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
		{
			vtkSurfaceNets2D.vtkSurfaceNets2D_GenerateValues_08(base.GetCppThis(), numContours, rangeStart, rangeEnd);
		}

		// Token: 0x06019D47 RID: 105799
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSurfaceNets2D_GetArrayComponent_09(HandleRef pThis);

		/// <summary>
		/// Set/get which component of a input multi-component scalar array to
		/// contour with; defaults to component 0.
		/// </summary>
		// Token: 0x06019D48 RID: 105800 RVA: 0x0023DF04 File Offset: 0x0023C104
		public virtual int GetArrayComponent()
		{
			return vtkSurfaceNets2D.vtkSurfaceNets2D_GetArrayComponent_09(base.GetCppThis());
		}

		// Token: 0x06019D49 RID: 105801
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSurfaceNets2D_GetBackgroundLabel_10(HandleRef pThis);

		/// <summary>
		/// If computing cell scalars, specify the label to use when referencing a
		/// labeled region outside any of the specified regions (i.e., when
		/// referencing the background region). By default this value is zero. Be
		/// very careful of the value being used here, it should not overlap an
		/// extracted label value, and because it is the same type as the input
		/// image scalars, make sure the value can be properly represented (i.e., if
		/// the input scalars are an unsigned type, then BackgroundLabel should not
		/// be negative).
		/// </summary>
		// Token: 0x06019D4A RID: 105802 RVA: 0x0023DF24 File Offset: 0x0023C124
		public virtual double GetBackgroundLabel()
		{
			return vtkSurfaceNets2D.vtkSurfaceNets2D_GetBackgroundLabel_10(base.GetCppThis());
		}

		// Token: 0x06019D4B RID: 105803
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSurfaceNets2D_GetComputeScalars_11(HandleRef pThis);

		/// <summary>
		/// Enable/disable an option to generate cell scalars in the output. The
		/// cell scalars are a two-tuple that indicates which labels (i.e.,
		/// segmented regions) are on either side of each (line) cell (l0,l1) with
		/// l0&lt;l1.  If an object is one-sided (meaning the background is on one side
		/// of the line) then l1=(OutsideLabel). The name of the output cell scalars is
		/// "BoundaryLabels". By default this flag is on.
		/// </summary>
		// Token: 0x06019D4C RID: 105804 RVA: 0x0023DF44 File Offset: 0x0023C144
		public virtual bool GetComputeScalars()
		{
			return vtkSurfaceNets2D.vtkSurfaceNets2D_GetComputeScalars_11(base.GetCppThis()) != 0;
		}

		// Token: 0x06019D4D RID: 105805
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSurfaceNets2D_GetDataCaching_12(HandleRef pThis);

		/// <summary>
		/// Enable caching of intermediate data. A common workflow using this filter
		/// requires extracting object boundaries, and then repeatedly rerunning the
		/// smoothing process with different parameters. To improve performance by
		/// avoiding repeated extraction of the boundary, the filter can cache
		/// intermediate data prior to the smoothing process. In this way, the
		/// boundary is only extracted once, and as long as only the internal
		/// constrained smoothing filter is modified, then boundary extraction will
		/// not be reexecuted. By default this is enabled.
		/// </summary>
		// Token: 0x06019D4E RID: 105806 RVA: 0x0023DF6C File Offset: 0x0023C16C
		public virtual bool GetDataCaching()
		{
			return vtkSurfaceNets2D.vtkSurfaceNets2D_GetDataCaching_12(base.GetCppThis()) != 0;
		}

		// Token: 0x06019D4F RID: 105807
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSurfaceNets2D_GetLabel_13(HandleRef pThis, int i);

		/// <summary>
		/// Get the ith label value.
		/// </summary>
		// Token: 0x06019D50 RID: 105808 RVA: 0x0023DF94 File Offset: 0x0023C194
		public double GetLabel(int i)
		{
			return vtkSurfaceNets2D.vtkSurfaceNets2D_GetLabel_13(base.GetCppThis(), i);
		}

		// Token: 0x06019D51 RID: 105809
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSurfaceNets2D_GetLabels_14(HandleRef pThis);

		/// <summary>
		/// Get a pointer to an array of labels. There will be
		/// GetNumberOfLabels() values in the list.
		/// </summary>
		// Token: 0x06019D52 RID: 105810 RVA: 0x0023DFB4 File Offset: 0x0023C1B4
		public IntPtr GetLabels()
		{
			return vtkSurfaceNets2D.vtkSurfaceNets2D_GetLabels_14(base.GetCppThis());
		}

		// Token: 0x06019D53 RID: 105811
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets2D_GetLabels_15(HandleRef pThis, IntPtr contourValues);

		/// <summary>
		/// Fill a supplied list with label values. There will be
		/// GetNumberOfLabels() values in the list. Make sure you allocate enough
		/// memory to hold the list.
		/// </summary>
		// Token: 0x06019D54 RID: 105812 RVA: 0x0023DFD3 File Offset: 0x0023C1D3
		public void GetLabels(IntPtr contourValues)
		{
			vtkSurfaceNets2D.vtkSurfaceNets2D_GetLabels_15(base.GetCppThis(), contourValues);
		}

		// Token: 0x06019D55 RID: 105813
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkSurfaceNets2D_GetMTime_16(HandleRef pThis);

		/// <summary>
		/// The modified time is also a function of the label values and
		/// the smoothing filter.
		/// </summary>
		// Token: 0x06019D56 RID: 105814 RVA: 0x0023DFE4 File Offset: 0x0023C1E4
		public override ulong GetMTime()
		{
			return vtkSurfaceNets2D.vtkSurfaceNets2D_GetMTime_16(base.GetCppThis());
		}

		// Token: 0x06019D57 RID: 105815
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSurfaceNets2D_GetNumberOfContours_17(HandleRef pThis);

		/// <summary>
		/// Get the number of labels in the list of label values.
		/// </summary>
		// Token: 0x06019D58 RID: 105816 RVA: 0x0023E004 File Offset: 0x0023C204
		public long GetNumberOfContours()
		{
			return vtkSurfaceNets2D.vtkSurfaceNets2D_GetNumberOfContours_17(base.GetCppThis());
		}

		// Token: 0x06019D59 RID: 105817
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSurfaceNets2D_GetNumberOfGenerationsFromBase_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, printing, and type information.
		/// </summary>
		// Token: 0x06019D5A RID: 105818 RVA: 0x0023E024 File Offset: 0x0023C224
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSurfaceNets2D.vtkSurfaceNets2D_GetNumberOfGenerationsFromBase_18(base.GetCppThis(), type);
		}

		// Token: 0x06019D5B RID: 105819
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSurfaceNets2D_GetNumberOfGenerationsFromBaseType_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, printing, and type information.
		/// </summary>
		// Token: 0x06019D5C RID: 105820 RVA: 0x0023E044 File Offset: 0x0023C244
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSurfaceNets2D.vtkSurfaceNets2D_GetNumberOfGenerationsFromBaseType_19(type);
		}

		// Token: 0x06019D5D RID: 105821
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSurfaceNets2D_GetNumberOfLabels_20(HandleRef pThis);

		/// <summary>
		/// Get the number of labels in the list of label values.
		/// </summary>
		// Token: 0x06019D5E RID: 105822 RVA: 0x0023E060 File Offset: 0x0023C260
		public long GetNumberOfLabels()
		{
			return vtkSurfaceNets2D.vtkSurfaceNets2D_GetNumberOfLabels_20(base.GetCppThis());
		}

		// Token: 0x06019D5F RID: 105823
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSurfaceNets2D_GetSmoother_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the instance of vtkConstrainedSmoothingFilter used to smooth the
		/// extracted surface net. To control smoothing, access this instance and
		/// specify its parameters such as number of smoothing iterations and
		/// constraint distance. If you wish to disable smoothing, set
		/// SmoothingOff().
		/// </summary>
		// Token: 0x06019D60 RID: 105824 RVA: 0x0023E080 File Offset: 0x0023C280
		public virtual vtkConstrainedSmoothingFilter GetSmoother()
		{
			vtkConstrainedSmoothingFilter vtkConstrainedSmoothingFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSurfaceNets2D.vtkSurfaceNets2D_GetSmoother_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkConstrainedSmoothingFilter = (vtkConstrainedSmoothingFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkConstrainedSmoothingFilter.Register(null);
				}
			}
			return vtkConstrainedSmoothingFilter;
		}

		// Token: 0x06019D61 RID: 105825
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSurfaceNets2D_GetSmoothing_22(HandleRef pThis);

		/// <summary>
		/// Indicate whether smoothing should be enabled. By default, after the
		/// isoline is extracted, smoothing occurs using the built-in smoother.
		/// To disable smoothing, invoke SmoothingOff().
		/// </summary>
		// Token: 0x06019D62 RID: 105826 RVA: 0x0023E0F0 File Offset: 0x0023C2F0
		public virtual bool GetSmoothing()
		{
			return vtkSurfaceNets2D.vtkSurfaceNets2D_GetSmoothing_22(base.GetCppThis()) != 0;
		}

		// Token: 0x06019D63 RID: 105827
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSurfaceNets2D_GetValue_23(HandleRef pThis, int i);

		/// <summary>
		/// Get the ith label value.
		/// </summary>
		// Token: 0x06019D64 RID: 105828 RVA: 0x0023E118 File Offset: 0x0023C318
		public double GetValue(int i)
		{
			return vtkSurfaceNets2D.vtkSurfaceNets2D_GetValue_23(base.GetCppThis(), i);
		}

		// Token: 0x06019D65 RID: 105829
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSurfaceNets2D_GetValues_24(HandleRef pThis);

		/// <summary>
		/// Get a pointer to an array of labels. There will be
		/// GetNumberOfLabels() values in the list.
		/// </summary>
		// Token: 0x06019D66 RID: 105830 RVA: 0x0023E138 File Offset: 0x0023C338
		public IntPtr GetValues()
		{
			return vtkSurfaceNets2D.vtkSurfaceNets2D_GetValues_24(base.GetCppThis());
		}

		// Token: 0x06019D67 RID: 105831
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets2D_GetValues_25(HandleRef pThis, IntPtr contourValues);

		/// <summary>
		/// Fill a supplied list with label values. There will be
		/// GetNumberOfLabels() values in the list. Make sure you allocate enough
		/// memory to hold the list.
		/// </summary>
		// Token: 0x06019D68 RID: 105832 RVA: 0x0023E157 File Offset: 0x0023C357
		public void GetValues(IntPtr contourValues)
		{
			vtkSurfaceNets2D.vtkSurfaceNets2D_GetValues_25(base.GetCppThis(), contourValues);
		}

		// Token: 0x06019D69 RID: 105833
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSurfaceNets2D_IsA_26(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, printing, and type information.
		/// </summary>
		// Token: 0x06019D6A RID: 105834 RVA: 0x0023E168 File Offset: 0x0023C368
		public override int IsA(string type)
		{
			return vtkSurfaceNets2D.vtkSurfaceNets2D_IsA_26(base.GetCppThis(), type);
		}

		// Token: 0x06019D6B RID: 105835
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSurfaceNets2D_IsTypeOf_27([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, printing, and type information.
		/// </summary>
		// Token: 0x06019D6C RID: 105836 RVA: 0x0023E188 File Offset: 0x0023C388
		public new static int IsTypeOf(string type)
		{
			return vtkSurfaceNets2D.vtkSurfaceNets2D_IsTypeOf_27(type);
		}

		// Token: 0x06019D6D RID: 105837
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSurfaceNets2D_NewInstance_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, printing, and type information.
		/// </summary>
		// Token: 0x06019D6E RID: 105838 RVA: 0x0023E1A4 File Offset: 0x0023C3A4
		public new vtkSurfaceNets2D NewInstance()
		{
			vtkSurfaceNets2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSurfaceNets2D.vtkSurfaceNets2D_NewInstance_29(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSurfaceNets2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06019D6F RID: 105839
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSurfaceNets2D_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, printing, and type information.
		/// </summary>
		// Token: 0x06019D70 RID: 105840 RVA: 0x0023E200 File Offset: 0x0023C400
		public new static vtkSurfaceNets2D SafeDownCast(vtkObjectBase o)
		{
			vtkSurfaceNets2D vtkSurfaceNets2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSurfaceNets2D.vtkSurfaceNets2D_SafeDownCast_30((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSurfaceNets2D = (vtkSurfaceNets2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSurfaceNets2D.Register(null);
				}
			}
			return vtkSurfaceNets2D;
		}

		// Token: 0x06019D71 RID: 105841
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets2D_SetArrayComponent_31(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get which component of a input multi-component scalar array to
		/// contour with; defaults to component 0.
		/// </summary>
		// Token: 0x06019D72 RID: 105842 RVA: 0x0023E27F File Offset: 0x0023C47F
		public virtual void SetArrayComponent(int _arg)
		{
			vtkSurfaceNets2D.vtkSurfaceNets2D_SetArrayComponent_31(base.GetCppThis(), _arg);
		}

		// Token: 0x06019D73 RID: 105843
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets2D_SetBackgroundLabel_32(HandleRef pThis, double _arg);

		/// <summary>
		/// If computing cell scalars, specify the label to use when referencing a
		/// labeled region outside any of the specified regions (i.e., when
		/// referencing the background region). By default this value is zero. Be
		/// very careful of the value being used here, it should not overlap an
		/// extracted label value, and because it is the same type as the input
		/// image scalars, make sure the value can be properly represented (i.e., if
		/// the input scalars are an unsigned type, then BackgroundLabel should not
		/// be negative).
		/// </summary>
		// Token: 0x06019D74 RID: 105844 RVA: 0x0023E28F File Offset: 0x0023C48F
		public virtual void SetBackgroundLabel(double _arg)
		{
			vtkSurfaceNets2D.vtkSurfaceNets2D_SetBackgroundLabel_32(base.GetCppThis(), _arg);
		}

		// Token: 0x06019D75 RID: 105845
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets2D_SetComputeScalars_33(HandleRef pThis, byte _arg);

		/// <summary>
		/// Enable/disable an option to generate cell scalars in the output. The
		/// cell scalars are a two-tuple that indicates which labels (i.e.,
		/// segmented regions) are on either side of each (line) cell (l0,l1) with
		/// l0&lt;l1.  If an object is one-sided (meaning the background is on one side
		/// of the line) then l1=(OutsideLabel). The name of the output cell scalars is
		/// "BoundaryLabels". By default this flag is on.
		/// </summary>
		// Token: 0x06019D76 RID: 105846 RVA: 0x0023E29F File Offset: 0x0023C49F
		public virtual void SetComputeScalars(bool _arg)
		{
			vtkSurfaceNets2D.vtkSurfaceNets2D_SetComputeScalars_33(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06019D77 RID: 105847
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets2D_SetDataCaching_34(HandleRef pThis, byte _arg);

		/// <summary>
		/// Enable caching of intermediate data. A common workflow using this filter
		/// requires extracting object boundaries, and then repeatedly rerunning the
		/// smoothing process with different parameters. To improve performance by
		/// avoiding repeated extraction of the boundary, the filter can cache
		/// intermediate data prior to the smoothing process. In this way, the
		/// boundary is only extracted once, and as long as only the internal
		/// constrained smoothing filter is modified, then boundary extraction will
		/// not be reexecuted. By default this is enabled.
		/// </summary>
		// Token: 0x06019D78 RID: 105848 RVA: 0x0023E2B7 File Offset: 0x0023C4B7
		public virtual void SetDataCaching(bool _arg)
		{
			vtkSurfaceNets2D.vtkSurfaceNets2D_SetDataCaching_34(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06019D79 RID: 105849
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets2D_SetLabel_35(HandleRef pThis, int i, double value);

		/// <summary>
		/// Set a particular label value at label number i. The index i ranges
		/// between 0 &lt;= i &lt;NumberOfLabels. (Note: while labels values are expressed
		/// as doubles, the underlying scalar data may be a different type. During
		/// execution the label values are cast to the type of the scalar data.)
		/// Note the use of "Value" and "Label" when specifying regions to
		/// extract. The use of "Value" is continuous with other VTK
		/// continuous-scalar field isocontouring algorithms; however the term
		/// "Label" is more consistent with label maps.
		/// </summary>
		// Token: 0x06019D7A RID: 105850 RVA: 0x0023E2CF File Offset: 0x0023C4CF
		public void SetLabel(int i, double value)
		{
			vtkSurfaceNets2D.vtkSurfaceNets2D_SetLabel_35(base.GetCppThis(), i, value);
		}

		// Token: 0x06019D7B RID: 105851
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets2D_SetNumberOfContours_36(HandleRef pThis, int number);

		/// <summary>
		/// Set the number of labels to place into the list. You only really need to
		/// use this method to reduce list size. The method SetValue() will
		/// automatically increase list size as needed. Note that for consistency
		/// with other isocountoring-related algorithms, some methods use
		/// "Labels" and "Contours" interchangeably.
		/// </summary>
		// Token: 0x06019D7C RID: 105852 RVA: 0x0023E2E0 File Offset: 0x0023C4E0
		public void SetNumberOfContours(int number)
		{
			vtkSurfaceNets2D.vtkSurfaceNets2D_SetNumberOfContours_36(base.GetCppThis(), number);
		}

		// Token: 0x06019D7D RID: 105853
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets2D_SetNumberOfLabels_37(HandleRef pThis, int number);

		/// <summary>
		/// Set the number of labels to place into the list. You only really need to
		/// use this method to reduce list size. The method SetValue() will
		/// automatically increase list size as needed. Note that for consistency
		/// with other isocountoring-related algorithms, some methods use
		/// "Labels" and "Contours" interchangeably.
		/// </summary>
		// Token: 0x06019D7E RID: 105854 RVA: 0x0023E2F0 File Offset: 0x0023C4F0
		public void SetNumberOfLabels(int number)
		{
			vtkSurfaceNets2D.vtkSurfaceNets2D_SetNumberOfLabels_37(base.GetCppThis(), number);
		}

		// Token: 0x06019D7F RID: 105855
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets2D_SetSmoothing_38(HandleRef pThis, byte _arg);

		/// <summary>
		/// Indicate whether smoothing should be enabled. By default, after the
		/// isoline is extracted, smoothing occurs using the built-in smoother.
		/// To disable smoothing, invoke SmoothingOff().
		/// </summary>
		// Token: 0x06019D80 RID: 105856 RVA: 0x0023E300 File Offset: 0x0023C500
		public virtual void SetSmoothing(bool _arg)
		{
			vtkSurfaceNets2D.vtkSurfaceNets2D_SetSmoothing_38(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06019D81 RID: 105857
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets2D_SetValue_39(HandleRef pThis, int i, double value);

		/// <summary>
		/// Set a particular label value at label number i. The index i ranges
		/// between 0 &lt;= i &lt;NumberOfLabels. (Note: while labels values are expressed
		/// as doubles, the underlying scalar data may be a different type. During
		/// execution the label values are cast to the type of the scalar data.)
		/// Note the use of "Value" and "Label" when specifying regions to
		/// extract. The use of "Value" is continuous with other VTK
		/// continuous-scalar field isocontouring algorithms; however the term
		/// "Label" is more consistent with label maps.
		/// </summary>
		// Token: 0x06019D82 RID: 105858 RVA: 0x0023E318 File Offset: 0x0023C518
		public void SetValue(int i, double value)
		{
			vtkSurfaceNets2D.vtkSurfaceNets2D_SetValue_39(base.GetCppThis(), i, value);
		}

		// Token: 0x06019D83 RID: 105859
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets2D_SmoothingOff_40(HandleRef pThis);

		/// <summary>
		/// Indicate whether smoothing should be enabled. By default, after the
		/// isoline is extracted, smoothing occurs using the built-in smoother.
		/// To disable smoothing, invoke SmoothingOff().
		/// </summary>
		// Token: 0x06019D84 RID: 105860 RVA: 0x0023E329 File Offset: 0x0023C529
		public virtual void SmoothingOff()
		{
			vtkSurfaceNets2D.vtkSurfaceNets2D_SmoothingOff_40(base.GetCppThis());
		}

		// Token: 0x06019D85 RID: 105861
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets2D_SmoothingOn_41(HandleRef pThis);

		/// <summary>
		/// Indicate whether smoothing should be enabled. By default, after the
		/// isoline is extracted, smoothing occurs using the built-in smoother.
		/// To disable smoothing, invoke SmoothingOff().
		/// </summary>
		// Token: 0x06019D86 RID: 105862 RVA: 0x0023E338 File Offset: 0x0023C538
		public virtual void SmoothingOn()
		{
			vtkSurfaceNets2D.vtkSurfaceNets2D_SmoothingOn_41(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C11 RID: 7185
		public new const string MRFullTypeName = "Kitware.VTK.vtkSurfaceNets2D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C12 RID: 7186
		public new static readonly string MRClassNameKey = "class vtkSurfaceNets2D";
	}
}
