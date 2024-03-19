using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSurfaceNets3D
	/// </summary>
	/// <remarks>
	///    generate smoothed isocontours from segmented 3D image data (i.e., "label maps")
	///
	/// vtkSurfaceNets3D creates boundary/isocontour surfaces from a label map
	/// (e.g., a segmented image) using a threaded, 3D version of the multiple
	/// objects/labels Surface Nets algorithm. The input is a 3D image (i.e.,
	/// volume) where each voxel is labeled (integer labels are preferred to real
	/// values), and the output data is a polygonal mesh separating labeled
	/// regions / objects.  (Note that on output each region [corresponding to a
	/// different segmented object] will share points/edges on a common boundary,
	/// i.e., two neighboring objects will share the boundary that separates them.)
	/// This threaded implementation uses concepts from Flying Edges to achieve
	/// high performance and scalability.
	///
	/// The filter implements a contouring operation over a non-continuous scalar
	/// field. In comparison, classic contouring methods (like Flying Edges or
	/// Marching Cubes) presume a continuous scalar field. In comparison, this
	/// method processes non-continuous label maps, which corresponds to discrete
	/// regions in an input 3D image (i.e., volume). With a non-continuous scalar
	/// function, the usual data interpolation across a continuous function (e.g.,
	/// interpolation along cell edges) is not possible. Instead, when the edge
	/// endpoint voxels are labeled in differing regions, the edge is split and
	/// transected by a quad polygon that connects the center points of the voxels
	/// on either side of the edge. Later, using a energy minimization smoothing
	/// process, the resulting polygonal mesh is adjusted to produce a smoother
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
	/// altogether by disabling smoothing [e.g., invoking SmoothingOff()] or
	/// setting the number of smoothing iterations to zero. This can be useful
	/// when using a different smoothing filter like
	/// vtkWindowedSincPolyDataFilter; or if an unsmoothed, aliased output is
	/// desired. The reason the smoothing is built in to this filter is to remain
	/// faithful to the original published literature describing the Surface Nets
	/// algorithm, and for performance reasons since smoothing stencils can be
	/// generated on the fly.)
	///
	/// The Surface Nets algorithm was first proposed by Sarah Frisken.  Two
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
	/// Besides output geometry defining the surface net, the filter outputs a
	/// two-component, cell data array indicating the labels/regions on either
	/// side of the polygons composing the output vtkPolyData. (This can be used
	/// for advanced operations like extracting shared/contacting boundaries
	/// between two objects. The name of this cell data array is
	/// "BoundaryLabels".)
	///
	/// Note also that the content of the filter's output can be controlled by
	/// specifying the OutputStyle.  This produces different output which
	/// may better serve a particular workflow. For example, it is possible
	/// to produce just exterior boundary faces, or extract selected objects/
	/// labeled regions from the surface net.
	///
	/// Implementation note: For performance reasons, this filter is internally
	/// implemented quite differently than described in the literature.  The main
	/// difference is that concepts from the Flying Edges parallel isocontouring
	/// algorithm are used. Namely, parallel, edge-by-edge processing is used to
	/// define cell cases, generate smoothing stencils, and produce points and
	/// output polygons. Plus the constrained smoothing process is also threaded
	/// using a double-buffering approach. For more information on Flying Edges
	/// see the paper:
	///
	/// "Flying Edges: A High-Performance Scalable Isocontouring Algorithm" by
	/// Schroeder, Maynard, Geveci. Proc. of LDAV 2015. Chicago, IL.
	///
	/// or visit VTK's FE implementation vtkFlyingEdges3D.
	///
	/// @warning
	/// This filter is specialized to 3D images.
	///
	/// @warning
	/// The output of this filter is a polygonal mesh. By default when smoothing
	/// is disabled, the output is quad polygons. However, once smoothing is
	/// enabled, the quads are typically decomposed into triangles since the quads
	/// are typically no longer planar. A filter option is available to force the
	/// type of output polygonal mesh (quads, or triangles).
	///
	/// @warning
	/// Subtle differences in the output may result when the number of objects /
	/// labels extracted changes. This is because the smoothing operation operates
	/// on all of the boundaries simultaneously. If the boundaries change due to a
	/// difference in the number of extracted regions / labels, then the smoothing
	/// operation can produce slightly different results.
	///
	/// @warning
	/// The filters vtkDiscreteMarchingCubes and vtkDiscreteFlyingEdges3D
	/// also perform contouring of label maps. However these filters produce
	/// output that may not share coincident points and/or cells, or may produce
	/// "gaps" between segmented regions. For example, vtkDiscreteMarchingCubes
	/// will share points between adjacent regions, but not triangle cells (which
	/// will be coincident). Also, no center point is inserted into voxels,
	/// meaning that intermittent gaps may form between regions. This Surface Nets
	/// implementation fully shares the boundary (points and cells) between
	/// adjacent objects; and no gaps between objects are formed (if the objects
	/// are neighbors to one another).
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.  Note
	/// that for "small" volumes, serial execution may be faster due to the cost
	/// of managing threads. To force serial execution set VTK_IMPLEMENTATION_TYPE
	/// to "Sequential".
	///
	/// @warning
	/// See also vtkPackLabels which is a utility class for renumbering the labels
	/// found in the input segmentation mask to contiguous forms of smaller type.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkSurfaceNets2D vtkDiscreteMarchingCubes vtkDiscreteFlyingEdges3D
	/// vtkConstrainedSmoothingFilter vtkFlyingEdges3D vtkWindowedSincPolyDataFilter
	/// vtkPackLabels
	/// </seealso>
	// Token: 0x020009AB RID: 2475
	public class vtkSurfaceNets3D : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06019D87 RID: 105863 RVA: 0x0023E347 File Offset: 0x0023C547
		static vtkSurfaceNets3D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSurfaceNets3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSurfaceNets3D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06019D88 RID: 105864 RVA: 0x0023E36F File Offset: 0x0023C56F
		public vtkSurfaceNets3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06019D89 RID: 105865
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSurfaceNets3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, printing, and obtaining type
		/// information.
		/// </summary>
		// Token: 0x06019D8A RID: 105866 RVA: 0x0023E380 File Offset: 0x0023C580
		public new static vtkSurfaceNets3D New()
		{
			vtkSurfaceNets3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSurfaceNets3D.vtkSurfaceNets3D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSurfaceNets3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, printing, and obtaining type
		/// information.
		/// </summary>
		// Token: 0x06019D8B RID: 105867 RVA: 0x0023E3D4 File Offset: 0x0023C5D4
		public vtkSurfaceNets3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSurfaceNets3D.vtkSurfaceNets3D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06019D8C RID: 105868 RVA: 0x0023E418 File Offset: 0x0023C618
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06019D8D RID: 105869
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets3D_AddSelectedLabel_01(HandleRef pThis, double label);

		/// <summary>
		/// When the OutputStyle is set to OUTPUT_STYLE_SELECTED, these methods are
		/// used to specify the labeled regions to output.
		/// </summary>
		// Token: 0x06019D8E RID: 105870 RVA: 0x0023E423 File Offset: 0x0023C623
		public void AddSelectedLabel(double label)
		{
			vtkSurfaceNets3D.vtkSurfaceNets3D_AddSelectedLabel_01(base.GetCppThis(), label);
		}

		// Token: 0x06019D8F RID: 105871
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets3D_AutomaticSmoothingConstraintsOff_02(HandleRef pThis);

		/// <summary>
		/// Specify whether to set the smoothing constraints automatically. If
		/// automatic is on, the constraint distance and constraint box will
		/// calculated and set (based on the input size of the volume voxel). Note
		/// that the ConstraintScale is used to adjust the size of the constraint
		/// distance or box when set automatically. (Typically the constraint
		/// distance defines a circumscribing sphere around a voxel, and the
		/// constraint box is a box with voxel spacing.)  If constraints are not set
		/// automatically, then the constraint distance and/or constraint box should
		/// be set manually.) By default, automatic smoothing constraints are
		/// enabled.
		/// </summary>
		// Token: 0x06019D90 RID: 105872 RVA: 0x0023E433 File Offset: 0x0023C633
		public virtual void AutomaticSmoothingConstraintsOff()
		{
			vtkSurfaceNets3D.vtkSurfaceNets3D_AutomaticSmoothingConstraintsOff_02(base.GetCppThis());
		}

		// Token: 0x06019D91 RID: 105873
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets3D_AutomaticSmoothingConstraintsOn_03(HandleRef pThis);

		/// <summary>
		/// Specify whether to set the smoothing constraints automatically. If
		/// automatic is on, the constraint distance and constraint box will
		/// calculated and set (based on the input size of the volume voxel). Note
		/// that the ConstraintScale is used to adjust the size of the constraint
		/// distance or box when set automatically. (Typically the constraint
		/// distance defines a circumscribing sphere around a voxel, and the
		/// constraint box is a box with voxel spacing.)  If constraints are not set
		/// automatically, then the constraint distance and/or constraint box should
		/// be set manually.) By default, automatic smoothing constraints are
		/// enabled.
		/// </summary>
		// Token: 0x06019D92 RID: 105874 RVA: 0x0023E442 File Offset: 0x0023C642
		public virtual void AutomaticSmoothingConstraintsOn()
		{
			vtkSurfaceNets3D.vtkSurfaceNets3D_AutomaticSmoothingConstraintsOn_03(base.GetCppThis());
		}

		// Token: 0x06019D93 RID: 105875
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets3D_DataCachingOff_04(HandleRef pThis);

		/// <summary>
		/// Enable caching of intermediate data. A common workflow using this filter
		/// requires extracting object boundaries (i.e., the isocontour), and then
		/// repeatedly rerunning the smoothing process with different parameters. To
		/// improve performance by avoiding repeated extraction of the boundary, the
		/// filter can cache intermediate data prior to the smoothing process. In
		/// this way, the boundary is only extracted once, and as long as only the
		/// internal constrained smoothing filter is modified, then boundary
		/// extraction will not be reexecuted. By default this is enabled.
		/// </summary>
		// Token: 0x06019D94 RID: 105876 RVA: 0x0023E451 File Offset: 0x0023C651
		public virtual void DataCachingOff()
		{
			vtkSurfaceNets3D.vtkSurfaceNets3D_DataCachingOff_04(base.GetCppThis());
		}

		// Token: 0x06019D95 RID: 105877
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets3D_DataCachingOn_05(HandleRef pThis);

		/// <summary>
		/// Enable caching of intermediate data. A common workflow using this filter
		/// requires extracting object boundaries (i.e., the isocontour), and then
		/// repeatedly rerunning the smoothing process with different parameters. To
		/// improve performance by avoiding repeated extraction of the boundary, the
		/// filter can cache intermediate data prior to the smoothing process. In
		/// this way, the boundary is only extracted once, and as long as only the
		/// internal constrained smoothing filter is modified, then boundary
		/// extraction will not be reexecuted. By default this is enabled.
		/// </summary>
		// Token: 0x06019D96 RID: 105878 RVA: 0x0023E460 File Offset: 0x0023C660
		public virtual void DataCachingOn()
		{
			vtkSurfaceNets3D.vtkSurfaceNets3D_DataCachingOn_05(base.GetCppThis());
		}

		// Token: 0x06019D97 RID: 105879
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets3D_DeleteSelectedLabel_06(HandleRef pThis, double label);

		/// <summary>
		/// When the OutputStyle is set to OUTPUT_STYLE_SELECTED, these methods are
		/// used to specify the labeled regions to output.
		/// </summary>
		// Token: 0x06019D98 RID: 105880 RVA: 0x0023E46F File Offset: 0x0023C66F
		public void DeleteSelectedLabel(double label)
		{
			vtkSurfaceNets3D.vtkSurfaceNets3D_DeleteSelectedLabel_06(base.GetCppThis(), label);
		}

		// Token: 0x06019D99 RID: 105881
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets3D_GenerateLabels_07(HandleRef pThis, int numLabels, IntPtr range);

		/// <summary>
		/// Generate numLabels equally spaced labels between the specified
		/// range. The labels will include the min/max range values.
		/// </summary>
		// Token: 0x06019D9A RID: 105882 RVA: 0x0023E47F File Offset: 0x0023C67F
		public void GenerateLabels(int numLabels, IntPtr range)
		{
			vtkSurfaceNets3D.vtkSurfaceNets3D_GenerateLabels_07(base.GetCppThis(), numLabels, range);
		}

		// Token: 0x06019D9B RID: 105883
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets3D_GenerateLabels_08(HandleRef pThis, int numLabels, double rangeStart, double rangeEnd);

		/// <summary>
		/// Generate numLabels equally spaced labels between the specified
		/// range. The labels will include the min/max range values.
		/// </summary>
		// Token: 0x06019D9C RID: 105884 RVA: 0x0023E490 File Offset: 0x0023C690
		public void GenerateLabels(int numLabels, double rangeStart, double rangeEnd)
		{
			vtkSurfaceNets3D.vtkSurfaceNets3D_GenerateLabels_08(base.GetCppThis(), numLabels, rangeStart, rangeEnd);
		}

		// Token: 0x06019D9D RID: 105885
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets3D_GenerateValues_09(HandleRef pThis, int numContours, IntPtr range);

		/// <summary>
		/// Generate numLabels equally spaced labels between the specified
		/// range. The labels will include the min/max range values.
		/// </summary>
		// Token: 0x06019D9E RID: 105886 RVA: 0x0023E4A2 File Offset: 0x0023C6A2
		public void GenerateValues(int numContours, IntPtr range)
		{
			vtkSurfaceNets3D.vtkSurfaceNets3D_GenerateValues_09(base.GetCppThis(), numContours, range);
		}

		// Token: 0x06019D9F RID: 105887
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets3D_GenerateValues_10(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

		/// <summary>
		/// Generate numLabels equally spaced labels between the specified
		/// range. The labels will include the min/max range values.
		/// </summary>
		// Token: 0x06019DA0 RID: 105888 RVA: 0x0023E4B3 File Offset: 0x0023C6B3
		public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
		{
			vtkSurfaceNets3D.vtkSurfaceNets3D_GenerateValues_10(base.GetCppThis(), numContours, rangeStart, rangeEnd);
		}

		// Token: 0x06019DA1 RID: 105889
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSurfaceNets3D_GetArrayComponent_11(HandleRef pThis);

		/// <summary>
		/// Set/get which component of a input multi-component scalar array to
		/// contour with; defaults to component 0.
		/// </summary>
		// Token: 0x06019DA2 RID: 105890 RVA: 0x0023E4C8 File Offset: 0x0023C6C8
		public virtual int GetArrayComponent()
		{
			return vtkSurfaceNets3D.vtkSurfaceNets3D_GetArrayComponent_11(base.GetCppThis());
		}

		// Token: 0x06019DA3 RID: 105891
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSurfaceNets3D_GetAutomaticSmoothingConstraints_12(HandleRef pThis);

		/// <summary>
		/// Specify whether to set the smoothing constraints automatically. If
		/// automatic is on, the constraint distance and constraint box will
		/// calculated and set (based on the input size of the volume voxel). Note
		/// that the ConstraintScale is used to adjust the size of the constraint
		/// distance or box when set automatically. (Typically the constraint
		/// distance defines a circumscribing sphere around a voxel, and the
		/// constraint box is a box with voxel spacing.)  If constraints are not set
		/// automatically, then the constraint distance and/or constraint box should
		/// be set manually.) By default, automatic smoothing constraints are
		/// enabled.
		/// </summary>
		// Token: 0x06019DA4 RID: 105892 RVA: 0x0023E4E8 File Offset: 0x0023C6E8
		public virtual bool GetAutomaticSmoothingConstraints()
		{
			return vtkSurfaceNets3D.vtkSurfaceNets3D_GetAutomaticSmoothingConstraints_12(base.GetCppThis()) != 0;
		}

		// Token: 0x06019DA5 RID: 105893
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSurfaceNets3D_GetBackgroundLabel_13(HandleRef pThis);

		/// <summary>
		/// This value specifies the label value to use when referencing the
		/// background region outside of any of the specified regions. (This value is
		/// used when producing cell scalars.) By default this value is zero. Be
		/// very careful of the value being used here, it should not overlap an
		/// extracted label value, and because it is the same type as the input
		/// image scalars, make sure the value can be properly represented (e.g., if
		/// the input scalars are an unsigned type, then BackgroundLabel should not
		/// be negative).
		/// </summary>
		// Token: 0x06019DA6 RID: 105894 RVA: 0x0023E510 File Offset: 0x0023C710
		public virtual double GetBackgroundLabel()
		{
			return vtkSurfaceNets3D.vtkSurfaceNets3D_GetBackgroundLabel_13(base.GetCppThis());
		}

		// Token: 0x06019DA7 RID: 105895
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSurfaceNets3D_GetConstraintBox_14(HandleRef pThis);

		/// <summary>
		/// Convenience methods that delegate to the internal smoothing filter
		/// follow below. See the documentation for vtkConstrainedSmoothingAlgorithm
		/// for more information.
		/// </summary>
		// Token: 0x06019DA8 RID: 105896 RVA: 0x0023E530 File Offset: 0x0023C730
		public IntPtr GetConstraintBox()
		{
			return vtkSurfaceNets3D.vtkSurfaceNets3D_GetConstraintBox_14(base.GetCppThis());
		}

		// Token: 0x06019DA9 RID: 105897
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets3D_GetConstraintBox_15(HandleRef pThis, IntPtr s);

		/// <summary>
		/// Convenience methods that delegate to the internal smoothing filter
		/// follow below. See the documentation for vtkConstrainedSmoothingAlgorithm
		/// for more information.
		/// </summary>
		// Token: 0x06019DAA RID: 105898 RVA: 0x0023E54F File Offset: 0x0023C74F
		public void GetConstraintBox(IntPtr s)
		{
			vtkSurfaceNets3D.vtkSurfaceNets3D_GetConstraintBox_15(base.GetCppThis(), s);
		}

		// Token: 0x06019DAB RID: 105899
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSurfaceNets3D_GetConstraintDistance_16(HandleRef pThis);

		/// <summary>
		/// Convenience methods that delegate to the internal smoothing filter
		/// follow below. See the documentation for vtkConstrainedSmoothingAlgorithm
		/// for more information.
		/// </summary>
		// Token: 0x06019DAC RID: 105900 RVA: 0x0023E560 File Offset: 0x0023C760
		public double GetConstraintDistance()
		{
			return vtkSurfaceNets3D.vtkSurfaceNets3D_GetConstraintDistance_16(base.GetCppThis());
		}

		// Token: 0x06019DAD RID: 105901
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSurfaceNets3D_GetConstraintScale_17(HandleRef pThis);

		/// <summary>
		/// Specify whether to set the smoothing constraints automatically. If
		/// automatic is on, the constraint distance and constraint box will
		/// calculated and set (based on the input size of the volume voxel). Note
		/// that the ConstraintScale is used to adjust the size of the constraint
		/// distance or box when set automatically. (Typically the constraint
		/// distance defines a circumscribing sphere around a voxel, and the
		/// constraint box is a box with voxel spacing.)  If constraints are not set
		/// automatically, then the constraint distance and/or constraint box should
		/// be set manually.) By default, automatic smoothing constraints are
		/// enabled.
		/// </summary>
		// Token: 0x06019DAE RID: 105902 RVA: 0x0023E580 File Offset: 0x0023C780
		public virtual double GetConstraintScale()
		{
			return vtkSurfaceNets3D.vtkSurfaceNets3D_GetConstraintScale_17(base.GetCppThis());
		}

		// Token: 0x06019DAF RID: 105903
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSurfaceNets3D_GetConstraintScaleMaxValue_18(HandleRef pThis);

		/// <summary>
		/// Specify whether to set the smoothing constraints automatically. If
		/// automatic is on, the constraint distance and constraint box will
		/// calculated and set (based on the input size of the volume voxel). Note
		/// that the ConstraintScale is used to adjust the size of the constraint
		/// distance or box when set automatically. (Typically the constraint
		/// distance defines a circumscribing sphere around a voxel, and the
		/// constraint box is a box with voxel spacing.)  If constraints are not set
		/// automatically, then the constraint distance and/or constraint box should
		/// be set manually.) By default, automatic smoothing constraints are
		/// enabled.
		/// </summary>
		// Token: 0x06019DB0 RID: 105904 RVA: 0x0023E5A0 File Offset: 0x0023C7A0
		public virtual double GetConstraintScaleMaxValue()
		{
			return vtkSurfaceNets3D.vtkSurfaceNets3D_GetConstraintScaleMaxValue_18(base.GetCppThis());
		}

		// Token: 0x06019DB1 RID: 105905
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSurfaceNets3D_GetConstraintScaleMinValue_19(HandleRef pThis);

		/// <summary>
		/// Specify whether to set the smoothing constraints automatically. If
		/// automatic is on, the constraint distance and constraint box will
		/// calculated and set (based on the input size of the volume voxel). Note
		/// that the ConstraintScale is used to adjust the size of the constraint
		/// distance or box when set automatically. (Typically the constraint
		/// distance defines a circumscribing sphere around a voxel, and the
		/// constraint box is a box with voxel spacing.)  If constraints are not set
		/// automatically, then the constraint distance and/or constraint box should
		/// be set manually.) By default, automatic smoothing constraints are
		/// enabled.
		/// </summary>
		// Token: 0x06019DB2 RID: 105906 RVA: 0x0023E5C0 File Offset: 0x0023C7C0
		public virtual double GetConstraintScaleMinValue()
		{
			return vtkSurfaceNets3D.vtkSurfaceNets3D_GetConstraintScaleMinValue_19(base.GetCppThis());
		}

		// Token: 0x06019DB3 RID: 105907
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSurfaceNets3D_GetConstraintStrategy_20(HandleRef pThis);

		/// <summary>
		/// Convenience methods that delegate to the internal smoothing filter
		/// follow below. See the documentation for vtkConstrainedSmoothingAlgorithm
		/// for more information.
		/// </summary>
		// Token: 0x06019DB4 RID: 105908 RVA: 0x0023E5E0 File Offset: 0x0023C7E0
		public int GetConstraintStrategy()
		{
			return vtkSurfaceNets3D.vtkSurfaceNets3D_GetConstraintStrategy_20(base.GetCppThis());
		}

		// Token: 0x06019DB5 RID: 105909
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSurfaceNets3D_GetDataCaching_21(HandleRef pThis);

		/// <summary>
		/// Enable caching of intermediate data. A common workflow using this filter
		/// requires extracting object boundaries (i.e., the isocontour), and then
		/// repeatedly rerunning the smoothing process with different parameters. To
		/// improve performance by avoiding repeated extraction of the boundary, the
		/// filter can cache intermediate data prior to the smoothing process. In
		/// this way, the boundary is only extracted once, and as long as only the
		/// internal constrained smoothing filter is modified, then boundary
		/// extraction will not be reexecuted. By default this is enabled.
		/// </summary>
		// Token: 0x06019DB6 RID: 105910 RVA: 0x0023E600 File Offset: 0x0023C800
		public virtual bool GetDataCaching()
		{
			return vtkSurfaceNets3D.vtkSurfaceNets3D_GetDataCaching_21(base.GetCppThis()) != 0;
		}

		// Token: 0x06019DB7 RID: 105911
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSurfaceNets3D_GetLabel_22(HandleRef pThis, int i);

		/// <summary>
		/// Get the ith label value.
		/// </summary>
		// Token: 0x06019DB8 RID: 105912 RVA: 0x0023E628 File Offset: 0x0023C828
		public double GetLabel(int i)
		{
			return vtkSurfaceNets3D.vtkSurfaceNets3D_GetLabel_22(base.GetCppThis(), i);
		}

		// Token: 0x06019DB9 RID: 105913
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSurfaceNets3D_GetLabels_23(HandleRef pThis);

		/// <summary>
		/// Get a pointer to an array of labels. There will be
		/// GetNumberOfLabels() values in the list.
		/// </summary>
		// Token: 0x06019DBA RID: 105914 RVA: 0x0023E648 File Offset: 0x0023C848
		public IntPtr GetLabels()
		{
			return vtkSurfaceNets3D.vtkSurfaceNets3D_GetLabels_23(base.GetCppThis());
		}

		// Token: 0x06019DBB RID: 105915
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets3D_GetLabels_24(HandleRef pThis, IntPtr contourValues);

		/// <summary>
		/// Fill a supplied list with label values. There will be
		/// GetNumberOfLabels() values in the list. Make sure you allocate enough
		/// memory to hold the list.
		/// </summary>
		// Token: 0x06019DBC RID: 105916 RVA: 0x0023E667 File Offset: 0x0023C867
		public void GetLabels(IntPtr contourValues)
		{
			vtkSurfaceNets3D.vtkSurfaceNets3D_GetLabels_24(base.GetCppThis(), contourValues);
		}

		// Token: 0x06019DBD RID: 105917
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkSurfaceNets3D_GetMTime_25(HandleRef pThis);

		/// <summary>
		/// The modified time is also a function of the label values and
		/// the smoothing filter.
		/// </summary>
		// Token: 0x06019DBE RID: 105918 RVA: 0x0023E678 File Offset: 0x0023C878
		public override ulong GetMTime()
		{
			return vtkSurfaceNets3D.vtkSurfaceNets3D_GetMTime_25(base.GetCppThis());
		}

		// Token: 0x06019DBF RID: 105919
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSurfaceNets3D_GetNumberOfContours_26(HandleRef pThis);

		/// <summary>
		/// Get the number of labels in the list of label values.
		/// </summary>
		// Token: 0x06019DC0 RID: 105920 RVA: 0x0023E698 File Offset: 0x0023C898
		public long GetNumberOfContours()
		{
			return vtkSurfaceNets3D.vtkSurfaceNets3D_GetNumberOfContours_26(base.GetCppThis());
		}

		// Token: 0x06019DC1 RID: 105921
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSurfaceNets3D_GetNumberOfGenerationsFromBase_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, printing, and obtaining type
		/// information.
		/// </summary>
		// Token: 0x06019DC2 RID: 105922 RVA: 0x0023E6B8 File Offset: 0x0023C8B8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSurfaceNets3D.vtkSurfaceNets3D_GetNumberOfGenerationsFromBase_27(base.GetCppThis(), type);
		}

		// Token: 0x06019DC3 RID: 105923
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSurfaceNets3D_GetNumberOfGenerationsFromBaseType_28([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, printing, and obtaining type
		/// information.
		/// </summary>
		// Token: 0x06019DC4 RID: 105924 RVA: 0x0023E6D8 File Offset: 0x0023C8D8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSurfaceNets3D.vtkSurfaceNets3D_GetNumberOfGenerationsFromBaseType_28(type);
		}

		// Token: 0x06019DC5 RID: 105925
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSurfaceNets3D_GetNumberOfIterations_29(HandleRef pThis);

		/// <summary>
		/// Convenience methods that delegate to the internal smoothing filter
		/// follow below. See the documentation for vtkConstrainedSmoothingAlgorithm
		/// for more information.
		/// </summary>
		// Token: 0x06019DC6 RID: 105926 RVA: 0x0023E6F4 File Offset: 0x0023C8F4
		public int GetNumberOfIterations()
		{
			return vtkSurfaceNets3D.vtkSurfaceNets3D_GetNumberOfIterations_29(base.GetCppThis());
		}

		// Token: 0x06019DC7 RID: 105927
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSurfaceNets3D_GetNumberOfLabels_30(HandleRef pThis);

		/// <summary>
		/// Get the number of labels in the list of label values.
		/// </summary>
		// Token: 0x06019DC8 RID: 105928 RVA: 0x0023E714 File Offset: 0x0023C914
		public long GetNumberOfLabels()
		{
			return vtkSurfaceNets3D.vtkSurfaceNets3D_GetNumberOfLabels_30(base.GetCppThis());
		}

		// Token: 0x06019DC9 RID: 105929
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSurfaceNets3D_GetNumberOfSelectedLabels_31(HandleRef pThis);

		/// <summary>
		/// When the OutputStyle is set to OUTPUT_STYLE_SELECTED, these methods are
		/// used to specify the labeled regions to output.
		/// </summary>
		// Token: 0x06019DCA RID: 105930 RVA: 0x0023E734 File Offset: 0x0023C934
		public long GetNumberOfSelectedLabels()
		{
			return vtkSurfaceNets3D.vtkSurfaceNets3D_GetNumberOfSelectedLabels_31(base.GetCppThis());
		}

		// Token: 0x06019DCB RID: 105931
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSurfaceNets3D_GetOptimizedSmoothingStencils_32(HandleRef pThis);

		/// <summary>
		/// Indicate whether to use optimized smoothing stencils. Optimized stencils
		/// (which are on by default) are designed to better smooth sharp edges across the
		/// surface net. In some cases it may be desired to disable the use of optimized
		/// smoothing stencils.
		/// </summary>
		// Token: 0x06019DCC RID: 105932 RVA: 0x0023E754 File Offset: 0x0023C954
		public virtual bool GetOptimizedSmoothingStencils()
		{
			return vtkSurfaceNets3D.vtkSurfaceNets3D_GetOptimizedSmoothingStencils_32(base.GetCppThis()) != 0;
		}

		// Token: 0x06019DCD RID: 105933
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSurfaceNets3D_GetOutputMeshType_33(HandleRef pThis);

		/// <summary>
		/// Control the type of output mesh. By default, if smoothing is off, the
		/// output mesh is a polygonal mesh consisting of quadrilaterals
		/// (quads). However, if smoothing is enabled, then the output mesh type is
		/// a polygonal mesh consisting of triangles. It is possible to force the
		/// output mesh type to be of a certain type (triangles, or quads)
		/// regardless whether smoothing is enabled or not. Note that if an output
		/// mesh is forced to be quads, and smoothing is enabled, the resulting
		/// quads may not be planar.
		/// </summary>
		// Token: 0x06019DCE RID: 105934 RVA: 0x0023E77C File Offset: 0x0023C97C
		public virtual int GetOutputMeshType()
		{
			return vtkSurfaceNets3D.vtkSurfaceNets3D_GetOutputMeshType_33(base.GetCppThis());
		}

		// Token: 0x06019DCF RID: 105935
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSurfaceNets3D_GetOutputMeshTypeMaxValue_34(HandleRef pThis);

		/// <summary>
		/// Control the type of output mesh. By default, if smoothing is off, the
		/// output mesh is a polygonal mesh consisting of quadrilaterals
		/// (quads). However, if smoothing is enabled, then the output mesh type is
		/// a polygonal mesh consisting of triangles. It is possible to force the
		/// output mesh type to be of a certain type (triangles, or quads)
		/// regardless whether smoothing is enabled or not. Note that if an output
		/// mesh is forced to be quads, and smoothing is enabled, the resulting
		/// quads may not be planar.
		/// </summary>
		// Token: 0x06019DD0 RID: 105936 RVA: 0x0023E79C File Offset: 0x0023C99C
		public virtual int GetOutputMeshTypeMaxValue()
		{
			return vtkSurfaceNets3D.vtkSurfaceNets3D_GetOutputMeshTypeMaxValue_34(base.GetCppThis());
		}

		// Token: 0x06019DD1 RID: 105937
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSurfaceNets3D_GetOutputMeshTypeMinValue_35(HandleRef pThis);

		/// <summary>
		/// Control the type of output mesh. By default, if smoothing is off, the
		/// output mesh is a polygonal mesh consisting of quadrilaterals
		/// (quads). However, if smoothing is enabled, then the output mesh type is
		/// a polygonal mesh consisting of triangles. It is possible to force the
		/// output mesh type to be of a certain type (triangles, or quads)
		/// regardless whether smoothing is enabled or not. Note that if an output
		/// mesh is forced to be quads, and smoothing is enabled, the resulting
		/// quads may not be planar.
		/// </summary>
		// Token: 0x06019DD2 RID: 105938 RVA: 0x0023E7BC File Offset: 0x0023C9BC
		public virtual int GetOutputMeshTypeMinValue()
		{
			return vtkSurfaceNets3D.vtkSurfaceNets3D_GetOutputMeshTypeMinValue_35(base.GetCppThis());
		}

		// Token: 0x06019DD3 RID: 105939
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSurfaceNets3D_GetOutputStyle_36(HandleRef pThis);

		/// <summary>
		/// Specify the form (i.e., the style) of the output. Different styles are
		/// meant to support different workflows. OUTPUT_STYLE_DEFAULT provides the
		/// basic information defining the output surface net. OUTPUT_STYLE_BOUNDARY
		/// produces much smaller output since the interior polygon faces are not
		/// produced.  Finally, OUTPUT_STYLE_SELECTED enables the user to extract a
		/// subset of the labeled regions. This is useful because the smoothing
		/// operation will occur across all the specified input regions, meaning
		/// that the selected regions do not change shape due to changes in the
		/// specified input regions. You must specify the selected regions (i.e.,
		/// labels) to output.
		/// </summary>
		// Token: 0x06019DD4 RID: 105940 RVA: 0x0023E7DC File Offset: 0x0023C9DC
		public virtual int GetOutputStyle()
		{
			return vtkSurfaceNets3D.vtkSurfaceNets3D_GetOutputStyle_36(base.GetCppThis());
		}

		// Token: 0x06019DD5 RID: 105941
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSurfaceNets3D_GetOutputStyleMaxValue_37(HandleRef pThis);

		/// <summary>
		/// Specify the form (i.e., the style) of the output. Different styles are
		/// meant to support different workflows. OUTPUT_STYLE_DEFAULT provides the
		/// basic information defining the output surface net. OUTPUT_STYLE_BOUNDARY
		/// produces much smaller output since the interior polygon faces are not
		/// produced.  Finally, OUTPUT_STYLE_SELECTED enables the user to extract a
		/// subset of the labeled regions. This is useful because the smoothing
		/// operation will occur across all the specified input regions, meaning
		/// that the selected regions do not change shape due to changes in the
		/// specified input regions. You must specify the selected regions (i.e.,
		/// labels) to output.
		/// </summary>
		// Token: 0x06019DD6 RID: 105942 RVA: 0x0023E7FC File Offset: 0x0023C9FC
		public virtual int GetOutputStyleMaxValue()
		{
			return vtkSurfaceNets3D.vtkSurfaceNets3D_GetOutputStyleMaxValue_37(base.GetCppThis());
		}

		// Token: 0x06019DD7 RID: 105943
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSurfaceNets3D_GetOutputStyleMinValue_38(HandleRef pThis);

		/// <summary>
		/// Specify the form (i.e., the style) of the output. Different styles are
		/// meant to support different workflows. OUTPUT_STYLE_DEFAULT provides the
		/// basic information defining the output surface net. OUTPUT_STYLE_BOUNDARY
		/// produces much smaller output since the interior polygon faces are not
		/// produced.  Finally, OUTPUT_STYLE_SELECTED enables the user to extract a
		/// subset of the labeled regions. This is useful because the smoothing
		/// operation will occur across all the specified input regions, meaning
		/// that the selected regions do not change shape due to changes in the
		/// specified input regions. You must specify the selected regions (i.e.,
		/// labels) to output.
		/// </summary>
		// Token: 0x06019DD8 RID: 105944 RVA: 0x0023E81C File Offset: 0x0023CA1C
		public virtual int GetOutputStyleMinValue()
		{
			return vtkSurfaceNets3D.vtkSurfaceNets3D_GetOutputStyleMinValue_38(base.GetCppThis());
		}

		// Token: 0x06019DD9 RID: 105945
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSurfaceNets3D_GetRelaxationFactor_39(HandleRef pThis);

		/// <summary>
		/// Convenience methods that delegate to the internal smoothing filter
		/// follow below. See the documentation for vtkConstrainedSmoothingAlgorithm
		/// for more information.
		/// </summary>
		// Token: 0x06019DDA RID: 105946 RVA: 0x0023E83C File Offset: 0x0023CA3C
		public double GetRelaxationFactor()
		{
			return vtkSurfaceNets3D.vtkSurfaceNets3D_GetRelaxationFactor_39(base.GetCppThis());
		}

		// Token: 0x06019DDB RID: 105947
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSurfaceNets3D_GetSelectedLabel_40(HandleRef pThis, long ithLabel);

		/// <summary>
		/// When the OutputStyle is set to OUTPUT_STYLE_SELECTED, these methods are
		/// used to specify the labeled regions to output.
		/// </summary>
		// Token: 0x06019DDC RID: 105948 RVA: 0x0023E85C File Offset: 0x0023CA5C
		public double GetSelectedLabel(long ithLabel)
		{
			return vtkSurfaceNets3D.vtkSurfaceNets3D_GetSelectedLabel_40(base.GetCppThis(), ithLabel);
		}

		// Token: 0x06019DDD RID: 105949
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSurfaceNets3D_GetSmoother_41(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the instance of vtkConstrainedSmoothingFilter used to smooth the
		/// extracted surface net. To control smoothing, access this instance and
		/// specify its parameters such as number of smoothing iterations and
		/// constraint distance. If you wish to disable smoothing, set
		/// SmoothingOff().
		/// </summary>
		// Token: 0x06019DDE RID: 105950 RVA: 0x0023E87C File Offset: 0x0023CA7C
		public virtual vtkConstrainedSmoothingFilter GetSmoother()
		{
			vtkConstrainedSmoothingFilter vtkConstrainedSmoothingFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSurfaceNets3D.vtkSurfaceNets3D_GetSmoother_41(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06019DDF RID: 105951
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSurfaceNets3D_GetSmoothing_42(HandleRef pThis);

		/// <summary>
		/// Indicate whether smoothing should be enabled. By default, after the
		/// surface net is extracted, smoothing occurs using the built-in smoother.
		/// To disable smoothing, invoke SmoothingOff().
		/// </summary>
		// Token: 0x06019DE0 RID: 105952 RVA: 0x0023E8EC File Offset: 0x0023CAEC
		public virtual bool GetSmoothing()
		{
			return vtkSurfaceNets3D.vtkSurfaceNets3D_GetSmoothing_42(base.GetCppThis()) != 0;
		}

		// Token: 0x06019DE1 RID: 105953
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSurfaceNets3D_GetTriangulationStrategy_43(HandleRef pThis);

		/// <summary>
		/// Specify the strategy to triangulate the quads (not applicable if the
		/// output mesh type is set to MESH_TYPE_QUADS). If TRIANGULATE_GREEDY is
		/// specified, then quads are triangulated in no particular order. If
		/// TRIANGULATED_MIN_EDGE is specified, then trianglate the quad using a
		/// minimum-edge-length diagonal. If TRIANGULATED_MIN_AREA is specified,
		/// then trianglate the quad to produce a minimum surface area. By default,
		/// TRIANGULATE_MIN_EDGE is used. (Slight performance affects may occur,
		/// with TRIANGULATION_GREEDY generally the fastest.)
		/// </summary>
		// Token: 0x06019DE2 RID: 105954 RVA: 0x0023E914 File Offset: 0x0023CB14
		public virtual int GetTriangulationStrategy()
		{
			return vtkSurfaceNets3D.vtkSurfaceNets3D_GetTriangulationStrategy_43(base.GetCppThis());
		}

		// Token: 0x06019DE3 RID: 105955
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSurfaceNets3D_GetTriangulationStrategyMaxValue_44(HandleRef pThis);

		/// <summary>
		/// Specify the strategy to triangulate the quads (not applicable if the
		/// output mesh type is set to MESH_TYPE_QUADS). If TRIANGULATE_GREEDY is
		/// specified, then quads are triangulated in no particular order. If
		/// TRIANGULATED_MIN_EDGE is specified, then trianglate the quad using a
		/// minimum-edge-length diagonal. If TRIANGULATED_MIN_AREA is specified,
		/// then trianglate the quad to produce a minimum surface area. By default,
		/// TRIANGULATE_MIN_EDGE is used. (Slight performance affects may occur,
		/// with TRIANGULATION_GREEDY generally the fastest.)
		/// </summary>
		// Token: 0x06019DE4 RID: 105956 RVA: 0x0023E934 File Offset: 0x0023CB34
		public virtual int GetTriangulationStrategyMaxValue()
		{
			return vtkSurfaceNets3D.vtkSurfaceNets3D_GetTriangulationStrategyMaxValue_44(base.GetCppThis());
		}

		// Token: 0x06019DE5 RID: 105957
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSurfaceNets3D_GetTriangulationStrategyMinValue_45(HandleRef pThis);

		/// <summary>
		/// Specify the strategy to triangulate the quads (not applicable if the
		/// output mesh type is set to MESH_TYPE_QUADS). If TRIANGULATE_GREEDY is
		/// specified, then quads are triangulated in no particular order. If
		/// TRIANGULATED_MIN_EDGE is specified, then trianglate the quad using a
		/// minimum-edge-length diagonal. If TRIANGULATED_MIN_AREA is specified,
		/// then trianglate the quad to produce a minimum surface area. By default,
		/// TRIANGULATE_MIN_EDGE is used. (Slight performance affects may occur,
		/// with TRIANGULATION_GREEDY generally the fastest.)
		/// </summary>
		// Token: 0x06019DE6 RID: 105958 RVA: 0x0023E954 File Offset: 0x0023CB54
		public virtual int GetTriangulationStrategyMinValue()
		{
			return vtkSurfaceNets3D.vtkSurfaceNets3D_GetTriangulationStrategyMinValue_45(base.GetCppThis());
		}

		// Token: 0x06019DE7 RID: 105959
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSurfaceNets3D_GetValue_46(HandleRef pThis, int i);

		/// <summary>
		/// Get the ith label value.
		/// </summary>
		// Token: 0x06019DE8 RID: 105960 RVA: 0x0023E974 File Offset: 0x0023CB74
		public double GetValue(int i)
		{
			return vtkSurfaceNets3D.vtkSurfaceNets3D_GetValue_46(base.GetCppThis(), i);
		}

		// Token: 0x06019DE9 RID: 105961
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSurfaceNets3D_GetValues_47(HandleRef pThis);

		/// <summary>
		/// Get a pointer to an array of labels. There will be
		/// GetNumberOfLabels() values in the list.
		/// </summary>
		// Token: 0x06019DEA RID: 105962 RVA: 0x0023E994 File Offset: 0x0023CB94
		public IntPtr GetValues()
		{
			return vtkSurfaceNets3D.vtkSurfaceNets3D_GetValues_47(base.GetCppThis());
		}

		// Token: 0x06019DEB RID: 105963
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets3D_GetValues_48(HandleRef pThis, IntPtr contourValues);

		/// <summary>
		/// Fill a supplied list with label values. There will be
		/// GetNumberOfLabels() values in the list. Make sure you allocate enough
		/// memory to hold the list.
		/// </summary>
		// Token: 0x06019DEC RID: 105964 RVA: 0x0023E9B3 File Offset: 0x0023CBB3
		public void GetValues(IntPtr contourValues)
		{
			vtkSurfaceNets3D.vtkSurfaceNets3D_GetValues_48(base.GetCppThis(), contourValues);
		}

		// Token: 0x06019DED RID: 105965
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets3D_InitializeSelectedLabelsList_49(HandleRef pThis);

		/// <summary>
		/// When the OutputStyle is set to OUTPUT_STYLE_SELECTED, these methods are
		/// used to specify the labeled regions to output.
		/// </summary>
		// Token: 0x06019DEE RID: 105966 RVA: 0x0023E9C3 File Offset: 0x0023CBC3
		public void InitializeSelectedLabelsList()
		{
			vtkSurfaceNets3D.vtkSurfaceNets3D_InitializeSelectedLabelsList_49(base.GetCppThis());
		}

		// Token: 0x06019DEF RID: 105967
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSurfaceNets3D_IsA_50(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, printing, and obtaining type
		/// information.
		/// </summary>
		// Token: 0x06019DF0 RID: 105968 RVA: 0x0023E9D4 File Offset: 0x0023CBD4
		public override int IsA(string type)
		{
			return vtkSurfaceNets3D.vtkSurfaceNets3D_IsA_50(base.GetCppThis(), type);
		}

		// Token: 0x06019DF1 RID: 105969
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSurfaceNets3D_IsTypeOf_51([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, printing, and obtaining type
		/// information.
		/// </summary>
		// Token: 0x06019DF2 RID: 105970 RVA: 0x0023E9F4 File Offset: 0x0023CBF4
		public new static int IsTypeOf(string type)
		{
			return vtkSurfaceNets3D.vtkSurfaceNets3D_IsTypeOf_51(type);
		}

		// Token: 0x06019DF3 RID: 105971
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSurfaceNets3D_NewInstance_53(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, printing, and obtaining type
		/// information.
		/// </summary>
		// Token: 0x06019DF4 RID: 105972 RVA: 0x0023EA10 File Offset: 0x0023CC10
		public new vtkSurfaceNets3D NewInstance()
		{
			vtkSurfaceNets3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSurfaceNets3D.vtkSurfaceNets3D_NewInstance_53(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSurfaceNets3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06019DF5 RID: 105973
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets3D_OptimizedSmoothingStencilsOff_54(HandleRef pThis);

		/// <summary>
		/// Indicate whether to use optimized smoothing stencils. Optimized stencils
		/// (which are on by default) are designed to better smooth sharp edges across the
		/// surface net. In some cases it may be desired to disable the use of optimized
		/// smoothing stencils.
		/// </summary>
		// Token: 0x06019DF6 RID: 105974 RVA: 0x0023EA6A File Offset: 0x0023CC6A
		public virtual void OptimizedSmoothingStencilsOff()
		{
			vtkSurfaceNets3D.vtkSurfaceNets3D_OptimizedSmoothingStencilsOff_54(base.GetCppThis());
		}

		// Token: 0x06019DF7 RID: 105975
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets3D_OptimizedSmoothingStencilsOn_55(HandleRef pThis);

		/// <summary>
		/// Indicate whether to use optimized smoothing stencils. Optimized stencils
		/// (which are on by default) are designed to better smooth sharp edges across the
		/// surface net. In some cases it may be desired to disable the use of optimized
		/// smoothing stencils.
		/// </summary>
		// Token: 0x06019DF8 RID: 105976 RVA: 0x0023EA79 File Offset: 0x0023CC79
		public virtual void OptimizedSmoothingStencilsOn()
		{
			vtkSurfaceNets3D.vtkSurfaceNets3D_OptimizedSmoothingStencilsOn_55(base.GetCppThis());
		}

		// Token: 0x06019DF9 RID: 105977
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSurfaceNets3D_SafeDownCast_56(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, printing, and obtaining type
		/// information.
		/// </summary>
		// Token: 0x06019DFA RID: 105978 RVA: 0x0023EA88 File Offset: 0x0023CC88
		public new static vtkSurfaceNets3D SafeDownCast(vtkObjectBase o)
		{
			vtkSurfaceNets3D vtkSurfaceNets3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSurfaceNets3D.vtkSurfaceNets3D_SafeDownCast_56((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSurfaceNets3D = (vtkSurfaceNets3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSurfaceNets3D.Register(null);
				}
			}
			return vtkSurfaceNets3D;
		}

		// Token: 0x06019DFB RID: 105979
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets3D_SetArrayComponent_57(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get which component of a input multi-component scalar array to
		/// contour with; defaults to component 0.
		/// </summary>
		// Token: 0x06019DFC RID: 105980 RVA: 0x0023EB07 File Offset: 0x0023CD07
		public virtual void SetArrayComponent(int _arg)
		{
			vtkSurfaceNets3D.vtkSurfaceNets3D_SetArrayComponent_57(base.GetCppThis(), _arg);
		}

		// Token: 0x06019DFD RID: 105981
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets3D_SetAutomaticSmoothingConstraints_58(HandleRef pThis, byte _arg);

		/// <summary>
		/// Specify whether to set the smoothing constraints automatically. If
		/// automatic is on, the constraint distance and constraint box will
		/// calculated and set (based on the input size of the volume voxel). Note
		/// that the ConstraintScale is used to adjust the size of the constraint
		/// distance or box when set automatically. (Typically the constraint
		/// distance defines a circumscribing sphere around a voxel, and the
		/// constraint box is a box with voxel spacing.)  If constraints are not set
		/// automatically, then the constraint distance and/or constraint box should
		/// be set manually.) By default, automatic smoothing constraints are
		/// enabled.
		/// </summary>
		// Token: 0x06019DFE RID: 105982 RVA: 0x0023EB17 File Offset: 0x0023CD17
		public virtual void SetAutomaticSmoothingConstraints(bool _arg)
		{
			vtkSurfaceNets3D.vtkSurfaceNets3D_SetAutomaticSmoothingConstraints_58(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06019DFF RID: 105983
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets3D_SetBackgroundLabel_59(HandleRef pThis, double _arg);

		/// <summary>
		/// This value specifies the label value to use when referencing the
		/// background region outside of any of the specified regions. (This value is
		/// used when producing cell scalars.) By default this value is zero. Be
		/// very careful of the value being used here, it should not overlap an
		/// extracted label value, and because it is the same type as the input
		/// image scalars, make sure the value can be properly represented (e.g., if
		/// the input scalars are an unsigned type, then BackgroundLabel should not
		/// be negative).
		/// </summary>
		// Token: 0x06019E00 RID: 105984 RVA: 0x0023EB2F File Offset: 0x0023CD2F
		public virtual void SetBackgroundLabel(double _arg)
		{
			vtkSurfaceNets3D.vtkSurfaceNets3D_SetBackgroundLabel_59(base.GetCppThis(), _arg);
		}

		// Token: 0x06019E01 RID: 105985
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets3D_SetConstraintBox_60(HandleRef pThis, double sx, double sy, double sz);

		/// <summary>
		/// Convenience methods that delegate to the internal smoothing filter
		/// follow below. See the documentation for vtkConstrainedSmoothingAlgorithm
		/// for more information.
		/// </summary>
		// Token: 0x06019E02 RID: 105986 RVA: 0x0023EB3F File Offset: 0x0023CD3F
		public void SetConstraintBox(double sx, double sy, double sz)
		{
			vtkSurfaceNets3D.vtkSurfaceNets3D_SetConstraintBox_60(base.GetCppThis(), sx, sy, sz);
		}

		// Token: 0x06019E03 RID: 105987
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets3D_SetConstraintBox_61(HandleRef pThis, IntPtr s);

		/// <summary>
		/// Convenience methods that delegate to the internal smoothing filter
		/// follow below. See the documentation for vtkConstrainedSmoothingAlgorithm
		/// for more information.
		/// </summary>
		// Token: 0x06019E04 RID: 105988 RVA: 0x0023EB51 File Offset: 0x0023CD51
		public void SetConstraintBox(IntPtr s)
		{
			vtkSurfaceNets3D.vtkSurfaceNets3D_SetConstraintBox_61(base.GetCppThis(), s);
		}

		// Token: 0x06019E05 RID: 105989
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets3D_SetConstraintDistance_62(HandleRef pThis, double d);

		/// <summary>
		/// Convenience methods that delegate to the internal smoothing filter
		/// follow below. See the documentation for vtkConstrainedSmoothingAlgorithm
		/// for more information.
		/// </summary>
		// Token: 0x06019E06 RID: 105990 RVA: 0x0023EB61 File Offset: 0x0023CD61
		public void SetConstraintDistance(double d)
		{
			vtkSurfaceNets3D.vtkSurfaceNets3D_SetConstraintDistance_62(base.GetCppThis(), d);
		}

		// Token: 0x06019E07 RID: 105991
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets3D_SetConstraintScale_63(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify whether to set the smoothing constraints automatically. If
		/// automatic is on, the constraint distance and constraint box will
		/// calculated and set (based on the input size of the volume voxel). Note
		/// that the ConstraintScale is used to adjust the size of the constraint
		/// distance or box when set automatically. (Typically the constraint
		/// distance defines a circumscribing sphere around a voxel, and the
		/// constraint box is a box with voxel spacing.)  If constraints are not set
		/// automatically, then the constraint distance and/or constraint box should
		/// be set manually.) By default, automatic smoothing constraints are
		/// enabled.
		/// </summary>
		// Token: 0x06019E08 RID: 105992 RVA: 0x0023EB71 File Offset: 0x0023CD71
		public virtual void SetConstraintScale(double _arg)
		{
			vtkSurfaceNets3D.vtkSurfaceNets3D_SetConstraintScale_63(base.GetCppThis(), _arg);
		}

		// Token: 0x06019E09 RID: 105993
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets3D_SetConstraintStrategyToConstraintBox_64(HandleRef pThis);

		/// <summary>
		/// Convenience methods that delegate to the internal smoothing filter
		/// follow below. See the documentation for vtkConstrainedSmoothingAlgorithm
		/// for more information.
		/// </summary>
		// Token: 0x06019E0A RID: 105994 RVA: 0x0023EB81 File Offset: 0x0023CD81
		public void SetConstraintStrategyToConstraintBox()
		{
			vtkSurfaceNets3D.vtkSurfaceNets3D_SetConstraintStrategyToConstraintBox_64(base.GetCppThis());
		}

		// Token: 0x06019E0B RID: 105995
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets3D_SetConstraintStrategyToConstraintDistance_65(HandleRef pThis);

		/// <summary>
		/// Convenience methods that delegate to the internal smoothing filter
		/// follow below. See the documentation for vtkConstrainedSmoothingAlgorithm
		/// for more information.
		/// </summary>
		// Token: 0x06019E0C RID: 105996 RVA: 0x0023EB90 File Offset: 0x0023CD90
		public void SetConstraintStrategyToConstraintDistance()
		{
			vtkSurfaceNets3D.vtkSurfaceNets3D_SetConstraintStrategyToConstraintDistance_65(base.GetCppThis());
		}

		// Token: 0x06019E0D RID: 105997
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets3D_SetDataCaching_66(HandleRef pThis, byte _arg);

		/// <summary>
		/// Enable caching of intermediate data. A common workflow using this filter
		/// requires extracting object boundaries (i.e., the isocontour), and then
		/// repeatedly rerunning the smoothing process with different parameters. To
		/// improve performance by avoiding repeated extraction of the boundary, the
		/// filter can cache intermediate data prior to the smoothing process. In
		/// this way, the boundary is only extracted once, and as long as only the
		/// internal constrained smoothing filter is modified, then boundary
		/// extraction will not be reexecuted. By default this is enabled.
		/// </summary>
		// Token: 0x06019E0E RID: 105998 RVA: 0x0023EB9F File Offset: 0x0023CD9F
		public virtual void SetDataCaching(bool _arg)
		{
			vtkSurfaceNets3D.vtkSurfaceNets3D_SetDataCaching_66(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06019E0F RID: 105999
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets3D_SetLabel_67(HandleRef pThis, int i, double value);

		/// <summary>
		/// Set a particular label value at label number i. The index i ranges
		/// between (0 &lt;= i &lt; NumberOfLabels). (Note: while labels values are
		/// expressed as doubles, the underlying scalar data may be a different
		/// type. During execution the label values are cast to the type of the
		/// scalar data.)  Note the use of "Value" and "Label" when specifying
		/// regions to extract. The use of "Value" is consistent with other VTK
		/// continuous-scalar field isocontouring algorithms; however the term
		/// "Label" is more consistent with label maps.  Warning: make sure that the
		/// value of the background label (see definition below) is different than
		/// any of the specified labels, otherwise the generated cell scalars may be
		/// incorrect.
		/// </summary>
		// Token: 0x06019E10 RID: 106000 RVA: 0x0023EBB7 File Offset: 0x0023CDB7
		public void SetLabel(int i, double value)
		{
			vtkSurfaceNets3D.vtkSurfaceNets3D_SetLabel_67(base.GetCppThis(), i, value);
		}

		// Token: 0x06019E11 RID: 106001
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets3D_SetNumberOfContours_68(HandleRef pThis, int number);

		/// <summary>
		/// Set the number of labels to place into the list. You only really need to
		/// use this method to reduce list size. The method SetValue() will
		/// automatically increase list size as needed. Note that for consistency
		/// with other isocountoring-related algorithms, some methods use
		/// "Labels" and "Contours" interchangeably.
		/// </summary>
		// Token: 0x06019E12 RID: 106002 RVA: 0x0023EBC8 File Offset: 0x0023CDC8
		public void SetNumberOfContours(int number)
		{
			vtkSurfaceNets3D.vtkSurfaceNets3D_SetNumberOfContours_68(base.GetCppThis(), number);
		}

		// Token: 0x06019E13 RID: 106003
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets3D_SetNumberOfIterations_69(HandleRef pThis, int n);

		/// <summary>
		/// Convenience methods that delegate to the internal smoothing filter
		/// follow below. See the documentation for vtkConstrainedSmoothingAlgorithm
		/// for more information.
		/// </summary>
		// Token: 0x06019E14 RID: 106004 RVA: 0x0023EBD8 File Offset: 0x0023CDD8
		public void SetNumberOfIterations(int n)
		{
			vtkSurfaceNets3D.vtkSurfaceNets3D_SetNumberOfIterations_69(base.GetCppThis(), n);
		}

		// Token: 0x06019E15 RID: 106005
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets3D_SetNumberOfLabels_70(HandleRef pThis, int number);

		/// <summary>
		/// Set the number of labels to place into the list. You only really need to
		/// use this method to reduce list size. The method SetValue() will
		/// automatically increase list size as needed. Note that for consistency
		/// with other isocountoring-related algorithms, some methods use
		/// "Labels" and "Contours" interchangeably.
		/// </summary>
		// Token: 0x06019E16 RID: 106006 RVA: 0x0023EBE8 File Offset: 0x0023CDE8
		public void SetNumberOfLabels(int number)
		{
			vtkSurfaceNets3D.vtkSurfaceNets3D_SetNumberOfLabels_70(base.GetCppThis(), number);
		}

		// Token: 0x06019E17 RID: 106007
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets3D_SetOptimizedSmoothingStencils_71(HandleRef pThis, byte _arg);

		/// <summary>
		/// Indicate whether to use optimized smoothing stencils. Optimized stencils
		/// (which are on by default) are designed to better smooth sharp edges across the
		/// surface net. In some cases it may be desired to disable the use of optimized
		/// smoothing stencils.
		/// </summary>
		// Token: 0x06019E18 RID: 106008 RVA: 0x0023EBF8 File Offset: 0x0023CDF8
		public virtual void SetOptimizedSmoothingStencils(bool _arg)
		{
			vtkSurfaceNets3D.vtkSurfaceNets3D_SetOptimizedSmoothingStencils_71(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06019E19 RID: 106009
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets3D_SetOutputMeshType_72(HandleRef pThis, int _arg);

		/// <summary>
		/// Control the type of output mesh. By default, if smoothing is off, the
		/// output mesh is a polygonal mesh consisting of quadrilaterals
		/// (quads). However, if smoothing is enabled, then the output mesh type is
		/// a polygonal mesh consisting of triangles. It is possible to force the
		/// output mesh type to be of a certain type (triangles, or quads)
		/// regardless whether smoothing is enabled or not. Note that if an output
		/// mesh is forced to be quads, and smoothing is enabled, the resulting
		/// quads may not be planar.
		/// </summary>
		// Token: 0x06019E1A RID: 106010 RVA: 0x0023EC10 File Offset: 0x0023CE10
		public virtual void SetOutputMeshType(int _arg)
		{
			vtkSurfaceNets3D.vtkSurfaceNets3D_SetOutputMeshType_72(base.GetCppThis(), _arg);
		}

		// Token: 0x06019E1B RID: 106011
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets3D_SetOutputMeshTypeToDefault_73(HandleRef pThis);

		/// <summary>
		/// Control the type of output mesh. By default, if smoothing is off, the
		/// output mesh is a polygonal mesh consisting of quadrilaterals
		/// (quads). However, if smoothing is enabled, then the output mesh type is
		/// a polygonal mesh consisting of triangles. It is possible to force the
		/// output mesh type to be of a certain type (triangles, or quads)
		/// regardless whether smoothing is enabled or not. Note that if an output
		/// mesh is forced to be quads, and smoothing is enabled, the resulting
		/// quads may not be planar.
		/// </summary>
		// Token: 0x06019E1C RID: 106012 RVA: 0x0023EC20 File Offset: 0x0023CE20
		public void SetOutputMeshTypeToDefault()
		{
			vtkSurfaceNets3D.vtkSurfaceNets3D_SetOutputMeshTypeToDefault_73(base.GetCppThis());
		}

		// Token: 0x06019E1D RID: 106013
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets3D_SetOutputMeshTypeToQuads_74(HandleRef pThis);

		/// <summary>
		/// Control the type of output mesh. By default, if smoothing is off, the
		/// output mesh is a polygonal mesh consisting of quadrilaterals
		/// (quads). However, if smoothing is enabled, then the output mesh type is
		/// a polygonal mesh consisting of triangles. It is possible to force the
		/// output mesh type to be of a certain type (triangles, or quads)
		/// regardless whether smoothing is enabled or not. Note that if an output
		/// mesh is forced to be quads, and smoothing is enabled, the resulting
		/// quads may not be planar.
		/// </summary>
		// Token: 0x06019E1E RID: 106014 RVA: 0x0023EC2F File Offset: 0x0023CE2F
		public void SetOutputMeshTypeToQuads()
		{
			vtkSurfaceNets3D.vtkSurfaceNets3D_SetOutputMeshTypeToQuads_74(base.GetCppThis());
		}

		// Token: 0x06019E1F RID: 106015
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets3D_SetOutputMeshTypeToTriangles_75(HandleRef pThis);

		/// <summary>
		/// Control the type of output mesh. By default, if smoothing is off, the
		/// output mesh is a polygonal mesh consisting of quadrilaterals
		/// (quads). However, if smoothing is enabled, then the output mesh type is
		/// a polygonal mesh consisting of triangles. It is possible to force the
		/// output mesh type to be of a certain type (triangles, or quads)
		/// regardless whether smoothing is enabled or not. Note that if an output
		/// mesh is forced to be quads, and smoothing is enabled, the resulting
		/// quads may not be planar.
		/// </summary>
		// Token: 0x06019E20 RID: 106016 RVA: 0x0023EC3E File Offset: 0x0023CE3E
		public void SetOutputMeshTypeToTriangles()
		{
			vtkSurfaceNets3D.vtkSurfaceNets3D_SetOutputMeshTypeToTriangles_75(base.GetCppThis());
		}

		// Token: 0x06019E21 RID: 106017
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets3D_SetOutputStyle_76(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the form (i.e., the style) of the output. Different styles are
		/// meant to support different workflows. OUTPUT_STYLE_DEFAULT provides the
		/// basic information defining the output surface net. OUTPUT_STYLE_BOUNDARY
		/// produces much smaller output since the interior polygon faces are not
		/// produced.  Finally, OUTPUT_STYLE_SELECTED enables the user to extract a
		/// subset of the labeled regions. This is useful because the smoothing
		/// operation will occur across all the specified input regions, meaning
		/// that the selected regions do not change shape due to changes in the
		/// specified input regions. You must specify the selected regions (i.e.,
		/// labels) to output.
		/// </summary>
		// Token: 0x06019E22 RID: 106018 RVA: 0x0023EC4D File Offset: 0x0023CE4D
		public virtual void SetOutputStyle(int _arg)
		{
			vtkSurfaceNets3D.vtkSurfaceNets3D_SetOutputStyle_76(base.GetCppThis(), _arg);
		}

		// Token: 0x06019E23 RID: 106019
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets3D_SetOutputStyleToBoundary_77(HandleRef pThis);

		/// <summary>
		/// Specify the form (i.e., the style) of the output. Different styles are
		/// meant to support different workflows. OUTPUT_STYLE_DEFAULT provides the
		/// basic information defining the output surface net. OUTPUT_STYLE_BOUNDARY
		/// produces much smaller output since the interior polygon faces are not
		/// produced.  Finally, OUTPUT_STYLE_SELECTED enables the user to extract a
		/// subset of the labeled regions. This is useful because the smoothing
		/// operation will occur across all the specified input regions, meaning
		/// that the selected regions do not change shape due to changes in the
		/// specified input regions. You must specify the selected regions (i.e.,
		/// labels) to output.
		/// </summary>
		// Token: 0x06019E24 RID: 106020 RVA: 0x0023EC5D File Offset: 0x0023CE5D
		public void SetOutputStyleToBoundary()
		{
			vtkSurfaceNets3D.vtkSurfaceNets3D_SetOutputStyleToBoundary_77(base.GetCppThis());
		}

		// Token: 0x06019E25 RID: 106021
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets3D_SetOutputStyleToDefault_78(HandleRef pThis);

		/// <summary>
		/// Specify the form (i.e., the style) of the output. Different styles are
		/// meant to support different workflows. OUTPUT_STYLE_DEFAULT provides the
		/// basic information defining the output surface net. OUTPUT_STYLE_BOUNDARY
		/// produces much smaller output since the interior polygon faces are not
		/// produced.  Finally, OUTPUT_STYLE_SELECTED enables the user to extract a
		/// subset of the labeled regions. This is useful because the smoothing
		/// operation will occur across all the specified input regions, meaning
		/// that the selected regions do not change shape due to changes in the
		/// specified input regions. You must specify the selected regions (i.e.,
		/// labels) to output.
		/// </summary>
		// Token: 0x06019E26 RID: 106022 RVA: 0x0023EC6C File Offset: 0x0023CE6C
		public void SetOutputStyleToDefault()
		{
			vtkSurfaceNets3D.vtkSurfaceNets3D_SetOutputStyleToDefault_78(base.GetCppThis());
		}

		// Token: 0x06019E27 RID: 106023
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets3D_SetOutputStyleToSelected_79(HandleRef pThis);

		/// <summary>
		/// Specify the form (i.e., the style) of the output. Different styles are
		/// meant to support different workflows. OUTPUT_STYLE_DEFAULT provides the
		/// basic information defining the output surface net. OUTPUT_STYLE_BOUNDARY
		/// produces much smaller output since the interior polygon faces are not
		/// produced.  Finally, OUTPUT_STYLE_SELECTED enables the user to extract a
		/// subset of the labeled regions. This is useful because the smoothing
		/// operation will occur across all the specified input regions, meaning
		/// that the selected regions do not change shape due to changes in the
		/// specified input regions. You must specify the selected regions (i.e.,
		/// labels) to output.
		/// </summary>
		// Token: 0x06019E28 RID: 106024 RVA: 0x0023EC7B File Offset: 0x0023CE7B
		public void SetOutputStyleToSelected()
		{
			vtkSurfaceNets3D.vtkSurfaceNets3D_SetOutputStyleToSelected_79(base.GetCppThis());
		}

		// Token: 0x06019E29 RID: 106025
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets3D_SetRelaxationFactor_80(HandleRef pThis, double f);

		/// <summary>
		/// Convenience methods that delegate to the internal smoothing filter
		/// follow below. See the documentation for vtkConstrainedSmoothingAlgorithm
		/// for more information.
		/// </summary>
		// Token: 0x06019E2A RID: 106026 RVA: 0x0023EC8A File Offset: 0x0023CE8A
		public void SetRelaxationFactor(double f)
		{
			vtkSurfaceNets3D.vtkSurfaceNets3D_SetRelaxationFactor_80(base.GetCppThis(), f);
		}

		// Token: 0x06019E2B RID: 106027
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets3D_SetSmoothing_81(HandleRef pThis, byte _arg);

		/// <summary>
		/// Indicate whether smoothing should be enabled. By default, after the
		/// surface net is extracted, smoothing occurs using the built-in smoother.
		/// To disable smoothing, invoke SmoothingOff().
		/// </summary>
		// Token: 0x06019E2C RID: 106028 RVA: 0x0023EC9A File Offset: 0x0023CE9A
		public virtual void SetSmoothing(bool _arg)
		{
			vtkSurfaceNets3D.vtkSurfaceNets3D_SetSmoothing_81(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06019E2D RID: 106029
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets3D_SetTriangulationStrategy_82(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the strategy to triangulate the quads (not applicable if the
		/// output mesh type is set to MESH_TYPE_QUADS). If TRIANGULATE_GREEDY is
		/// specified, then quads are triangulated in no particular order. If
		/// TRIANGULATED_MIN_EDGE is specified, then trianglate the quad using a
		/// minimum-edge-length diagonal. If TRIANGULATED_MIN_AREA is specified,
		/// then trianglate the quad to produce a minimum surface area. By default,
		/// TRIANGULATE_MIN_EDGE is used. (Slight performance affects may occur,
		/// with TRIANGULATION_GREEDY generally the fastest.)
		/// </summary>
		// Token: 0x06019E2E RID: 106030 RVA: 0x0023ECB2 File Offset: 0x0023CEB2
		public virtual void SetTriangulationStrategy(int _arg)
		{
			vtkSurfaceNets3D.vtkSurfaceNets3D_SetTriangulationStrategy_82(base.GetCppThis(), _arg);
		}

		// Token: 0x06019E2F RID: 106031
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets3D_SetTriangulationStrategyToGreedy_83(HandleRef pThis);

		/// <summary>
		/// Specify the strategy to triangulate the quads (not applicable if the
		/// output mesh type is set to MESH_TYPE_QUADS). If TRIANGULATE_GREEDY is
		/// specified, then quads are triangulated in no particular order. If
		/// TRIANGULATED_MIN_EDGE is specified, then trianglate the quad using a
		/// minimum-edge-length diagonal. If TRIANGULATED_MIN_AREA is specified,
		/// then trianglate the quad to produce a minimum surface area. By default,
		/// TRIANGULATE_MIN_EDGE is used. (Slight performance affects may occur,
		/// with TRIANGULATION_GREEDY generally the fastest.)
		/// </summary>
		// Token: 0x06019E30 RID: 106032 RVA: 0x0023ECC2 File Offset: 0x0023CEC2
		public void SetTriangulationStrategyToGreedy()
		{
			vtkSurfaceNets3D.vtkSurfaceNets3D_SetTriangulationStrategyToGreedy_83(base.GetCppThis());
		}

		// Token: 0x06019E31 RID: 106033
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets3D_SetTriangulationStrategyToMinArea_84(HandleRef pThis);

		/// <summary>
		/// Specify the strategy to triangulate the quads (not applicable if the
		/// output mesh type is set to MESH_TYPE_QUADS). If TRIANGULATE_GREEDY is
		/// specified, then quads are triangulated in no particular order. If
		/// TRIANGULATED_MIN_EDGE is specified, then trianglate the quad using a
		/// minimum-edge-length diagonal. If TRIANGULATED_MIN_AREA is specified,
		/// then trianglate the quad to produce a minimum surface area. By default,
		/// TRIANGULATE_MIN_EDGE is used. (Slight performance affects may occur,
		/// with TRIANGULATION_GREEDY generally the fastest.)
		/// </summary>
		// Token: 0x06019E32 RID: 106034 RVA: 0x0023ECD1 File Offset: 0x0023CED1
		public void SetTriangulationStrategyToMinArea()
		{
			vtkSurfaceNets3D.vtkSurfaceNets3D_SetTriangulationStrategyToMinArea_84(base.GetCppThis());
		}

		// Token: 0x06019E33 RID: 106035
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets3D_SetTriangulationStrategyToMinEdge_85(HandleRef pThis);

		/// <summary>
		/// Specify the strategy to triangulate the quads (not applicable if the
		/// output mesh type is set to MESH_TYPE_QUADS). If TRIANGULATE_GREEDY is
		/// specified, then quads are triangulated in no particular order. If
		/// TRIANGULATED_MIN_EDGE is specified, then trianglate the quad using a
		/// minimum-edge-length diagonal. If TRIANGULATED_MIN_AREA is specified,
		/// then trianglate the quad to produce a minimum surface area. By default,
		/// TRIANGULATE_MIN_EDGE is used. (Slight performance affects may occur,
		/// with TRIANGULATION_GREEDY generally the fastest.)
		/// </summary>
		// Token: 0x06019E34 RID: 106036 RVA: 0x0023ECE0 File Offset: 0x0023CEE0
		public void SetTriangulationStrategyToMinEdge()
		{
			vtkSurfaceNets3D.vtkSurfaceNets3D_SetTriangulationStrategyToMinEdge_85(base.GetCppThis());
		}

		// Token: 0x06019E35 RID: 106037
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets3D_SetValue_86(HandleRef pThis, int i, double value);

		/// <summary>
		/// Set a particular label value at label number i. The index i ranges
		/// between (0 &lt;= i &lt; NumberOfLabels). (Note: while labels values are
		/// expressed as doubles, the underlying scalar data may be a different
		/// type. During execution the label values are cast to the type of the
		/// scalar data.)  Note the use of "Value" and "Label" when specifying
		/// regions to extract. The use of "Value" is consistent with other VTK
		/// continuous-scalar field isocontouring algorithms; however the term
		/// "Label" is more consistent with label maps.  Warning: make sure that the
		/// value of the background label (see definition below) is different than
		/// any of the specified labels, otherwise the generated cell scalars may be
		/// incorrect.
		/// </summary>
		// Token: 0x06019E36 RID: 106038 RVA: 0x0023ECEF File Offset: 0x0023CEEF
		public void SetValue(int i, double value)
		{
			vtkSurfaceNets3D.vtkSurfaceNets3D_SetValue_86(base.GetCppThis(), i, value);
		}

		// Token: 0x06019E37 RID: 106039
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets3D_SmoothingOff_87(HandleRef pThis);

		/// <summary>
		/// Indicate whether smoothing should be enabled. By default, after the
		/// surface net is extracted, smoothing occurs using the built-in smoother.
		/// To disable smoothing, invoke SmoothingOff().
		/// </summary>
		// Token: 0x06019E38 RID: 106040 RVA: 0x0023ED00 File Offset: 0x0023CF00
		public virtual void SmoothingOff()
		{
			vtkSurfaceNets3D.vtkSurfaceNets3D_SmoothingOff_87(base.GetCppThis());
		}

		// Token: 0x06019E39 RID: 106041
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceNets3D_SmoothingOn_88(HandleRef pThis);

		/// <summary>
		/// Indicate whether smoothing should be enabled. By default, after the
		/// surface net is extracted, smoothing occurs using the built-in smoother.
		/// To disable smoothing, invoke SmoothingOff().
		/// </summary>
		// Token: 0x06019E3A RID: 106042 RVA: 0x0023ED0F File Offset: 0x0023CF0F
		public virtual void SmoothingOn()
		{
			vtkSurfaceNets3D.vtkSurfaceNets3D_SmoothingOn_88(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C13 RID: 7187
		public new const string MRFullTypeName = "Kitware.VTK.vtkSurfaceNets3D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C14 RID: 7188
		public new static readonly string MRClassNameKey = "class vtkSurfaceNets3D";

		/// <summary>
		/// This enum is used to control the type of the output polygonal mesh.
		/// </summary>
		// Token: 0x020009AC RID: 2476
		public enum MeshType
		{
			/// <summary>enum member</summary>
			// Token: 0x04001C16 RID: 7190
			MESH_TYPE_DEFAULT,
			/// <summary>enum member</summary>
			// Token: 0x04001C17 RID: 7191
			MESH_TYPE_QUADS = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001C18 RID: 7192
			MESH_TYPE_TRIANGLES = 1
		}

		/// <summary>
		/// This enum is used to control the production of the filter output.
		/// Different output styles are used to transform the data so they can be
		/// used in different workflows, providing tradeoffs between speed, memory,
		/// and auxiliary information. By default (OUTPUT_STYLE_DEFAULT) the filter
		/// produces a mesh with shared points (i.e., points are not duplicated),
		/// and all mesh polygons, both interior and exterior, are
		/// produced. OUTPUT_STYLE_BOUNDARY is similar to OUTPUT_STYLE_DEFAULT
		/// except that only mesh polygons that are on the boundary are produced
		/// (i.e., only polygons that border the background region) - thus no
		/// interior polygons are produced. OUTPUT_STYLE_SELECTED is used to extract
		/// faces bounding selected regions.
		///
		/// </summary>
		// Token: 0x020009AD RID: 2477
		public enum OutputType
		{
			/// <summary>enum member</summary>
			// Token: 0x04001C1A RID: 7194
			OUTPUT_STYLE_BOUNDARY = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001C1B RID: 7195
			OUTPUT_STYLE_DEFAULT = 0,
			/// <summary>enum member</summary>
			// Token: 0x04001C1C RID: 7196
			OUTPUT_STYLE_SELECTED = 2
		}

		/// <summary>
		/// This enum is used to control how quadrilaterals are triangulated.
		/// </summary>
		// Token: 0x020009AE RID: 2478
		public enum TriangulationType
		{
			/// <summary>enum member</summary>
			// Token: 0x04001C1E RID: 7198
			TRIANGULATION_GREEDY,
			/// <summary>enum member</summary>
			// Token: 0x04001C1F RID: 7199
			TRIANGULATION_MIN_AREA = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001C20 RID: 7200
			TRIANGULATION_MIN_EDGE = 1
		}
	}
}
