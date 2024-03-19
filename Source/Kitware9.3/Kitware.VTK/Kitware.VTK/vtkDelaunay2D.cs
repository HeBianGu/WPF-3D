using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDelaunay2D
	/// </summary>
	/// <remarks>
	///    create 2D Delaunay triangulation of input points
	///
	/// vtkDelaunay2D is a filter that constructs a 2D Delaunay triangulation from
	/// a list of input points. These points may be represented by any dataset of
	/// type vtkPointSet and subclasses. The output of the filter is a polygonal
	/// dataset. Usually the output is a triangle mesh, but if a non-zero alpha
	/// distance value is specified (called the "alpha" value), then only
	/// triangles, edges, and vertices laying within the alpha radius are
	/// output. In other words, non-zero alpha values may result in arbitrary
	/// combinations of triangles, lines, and vertices. (The notion of alpha value
	/// is derived from Edelsbrunner's work on "alpha shapes".) Also, it is
	/// possible to generate "constrained triangulations" using this filter.
	/// A constrained triangulation is one where edges and loops (i.e., polygons)
	/// can be defined and the triangulation will preserve them (read on for
	/// more information).
	///
	/// The 2D Delaunay triangulation is defined as the triangulation that
	/// satisfies the Delaunay criterion for n-dimensional simplexes (in this case
	/// n=2 and the simplexes are triangles). This criterion states that a
	/// circumsphere of each simplex in a triangulation contains only the n+1
	/// defining points of the simplex. (See "The Visualization Toolkit" text
	/// for more information.) In two dimensions, this translates into an optimal
	/// triangulation. That is, the maximum interior angle of any triangle is less
	/// than or equal to that of any possible triangulation.
	///
	/// Delaunay triangulations are used to build topological structures
	/// from unorganized (or unstructured) points. The input to this filter
	/// is a list of points specified in 3D, even though the triangulation
	/// is 2D. Thus the triangulation is constructed in the x-y plane, and
	/// the z coordinate is ignored (although carried through to the
	/// output). If you desire to triangulate in a different plane, you
	/// can use the vtkTransformFilter to transform the points into and
	/// out of the x-y plane or you can specify a transform to the Delaunay2D
	/// directly.  In the latter case, the input points are transformed, the
	/// transformed points are triangulated, and the output will use the
	/// triangulated topology for the original (non-transformed) points.  This
	/// avoids transforming the data back as would be required when using the
	/// vtkTransformFilter method.  Specifying a transform directly also allows
	/// any transform to be used: rigid, non-rigid, non-invertible, etc.
	///
	/// If an input transform is used, then alpha values are applied (for the
	/// most part) in the original data space.  The exception is when
	/// BoundingTriangulation is on.  In this case, alpha values are applied in
	/// the original data space unless a cell uses a bounding vertex.
	///
	/// The Delaunay triangulation can be numerically sensitive in some cases. To
	/// prevent problems, try to avoid injecting points that will result in
	/// triangles with bad aspect ratios (1000:1 or greater). In practice this
	/// means inserting points that are "widely dispersed", and enables smooth
	/// transition of triangle sizes throughout the mesh. (You may even want to
	/// add extra points to create a better point distribution.) If numerical
	/// problems are present, you will see a warning message to this effect at
	/// the end of the triangulation process. Note also that the
	/// RandomPointInsertion mode can be set which will insert the points in
	/// pseudo-random order.
	///
	/// To create constrained meshes, you must define an additional
	/// input. This input is an instance of vtkPolyData which contains
	/// lines, polylines, and/or polygons that define constrained edges and
	/// loops. Only the topology of (lines and polygons) from this second
	/// input are used.  The topology is assumed to reference points in the
	/// input point set (the one to be triangulated). In other words, the
	/// lines and polygons use point ids from the first input point
	/// set. Lines and polylines found in the input will be mesh edges in
	/// the output. Polygons define a loop with inside and outside
	/// regions. The inside of the polygon is determined by using the
	/// right-hand-rule, i.e., looking down the z-axis a polygon should be
	/// ordered counter-clockwise. Holes in a polygon should be ordered
	/// clockwise. If you choose to create a constrained triangulation, the
	/// final mesh may not satisfy the Delaunay criterion. (Noted: the
	/// lines/polygon edges must not intersect when projected onto the 2D
	/// plane.  It may not be possible to recover all edges due to not
	/// enough points in the triangulation, or poorly defined edges
	/// (coincident or excessively long).  The form of the lines or
	/// polygons is a list of point ids that correspond to the input point
	/// ids used to generate the triangulation.)
	///
	/// If an input transform is used, constraints are defined in the
	/// "transformed" space.  So when the right hand rule is used for a
	/// polygon constraint, that operation is applied using the transformed
	/// points.  Since the input transform can be any transformation (rigid
	/// or non-rigid), care must be taken in constructing constraints when
	/// an input transform is used.
	///
	/// @warning
	/// Points arranged on a regular lattice (termed degenerate cases) can be
	/// triangulated in more than one way (at least according to the Delaunay
	/// criterion). The choice of triangulation (as implemented by
	/// this algorithm) depends on the order of the input points. The first three
	/// points will form a triangle; other degenerate points will not break
	/// this triangle.
	///
	/// @warning
	/// Points that are coincident (or nearly so) may be discarded by the algorithm.
	/// This is because the Delaunay triangulation requires unique input points.
	/// You can control the definition of coincidence with the "Tolerance" instance
	/// variable.
	///
	/// @warning
	/// The output of the Delaunay triangulation is supposedly a convex hull. In
	/// certain cases this implementation may not generate the convex hull. This
	/// behavior can be controlled by the Offset instance variable. Offset is a
	/// multiplier used to control the size of the initial triangulation. The
	/// larger the offset value, the more likely you will generate a convex hull;
	/// but the more likely you are to see numerical problems.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkDelaunay3D vtkTransformFilter vtkGaussianSplatter
	/// </seealso>
	// Token: 0x0200095C RID: 2396
	public class vtkDelaunay2D : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06018E8C RID: 102028 RVA: 0x0022BE4D File Offset: 0x0022A04D
		static vtkDelaunay2D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDelaunay2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDelaunay2D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06018E8D RID: 102029 RVA: 0x0022BE75 File Offset: 0x0022A075
		public vtkDelaunay2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06018E8E RID: 102030
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDelaunay2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with Alpha = 0.0; Tolerance = 0.001; Offset = 1.25;
		/// BoundingTriangulation turned off.
		/// </summary>
		// Token: 0x06018E8F RID: 102031 RVA: 0x0022BE84 File Offset: 0x0022A084
		public new static vtkDelaunay2D New()
		{
			vtkDelaunay2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDelaunay2D.vtkDelaunay2D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDelaunay2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object with Alpha = 0.0; Tolerance = 0.001; Offset = 1.25;
		/// BoundingTriangulation turned off.
		/// </summary>
		// Token: 0x06018E90 RID: 102032 RVA: 0x0022BED8 File Offset: 0x0022A0D8
		public vtkDelaunay2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDelaunay2D.vtkDelaunay2D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06018E91 RID: 102033 RVA: 0x0022BF1C File Offset: 0x0022A11C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06018E92 RID: 102034
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelaunay2D_BoundingTriangulationOff_01(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether bounding triangulation points (and associated
		/// triangles) are included in the output. (These are introduced as an
		/// initial triangulation to begin the triangulation process. This feature
		/// is nice for debugging output.)
		/// </summary>
		// Token: 0x06018E93 RID: 102035 RVA: 0x0022BF27 File Offset: 0x0022A127
		public virtual void BoundingTriangulationOff()
		{
			vtkDelaunay2D.vtkDelaunay2D_BoundingTriangulationOff_01(base.GetCppThis());
		}

		// Token: 0x06018E94 RID: 102036
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelaunay2D_BoundingTriangulationOn_02(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether bounding triangulation points (and associated
		/// triangles) are included in the output. (These are introduced as an
		/// initial triangulation to begin the triangulation process. This feature
		/// is nice for debugging output.)
		/// </summary>
		// Token: 0x06018E95 RID: 102037 RVA: 0x0022BF36 File Offset: 0x0022A136
		public virtual void BoundingTriangulationOn()
		{
			vtkDelaunay2D.vtkDelaunay2D_BoundingTriangulationOn_02(base.GetCppThis());
		}

		// Token: 0x06018E96 RID: 102038
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDelaunay2D_ComputeBestFittingPlane_03(HandleRef input, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This method computes the best fit plane to a set of points represented
		/// by a vtkPointSet. The method constructs a transform and returns it on
		/// successful completion (null otherwise). The user is responsible for
		/// deleting the transform instance.
		/// </summary>
		// Token: 0x06018E97 RID: 102039 RVA: 0x0022BF48 File Offset: 0x0022A148
		public static vtkAbstractTransform ComputeBestFittingPlane(vtkPointSet input)
		{
			vtkAbstractTransform vtkAbstractTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDelaunay2D.vtkDelaunay2D_ComputeBestFittingPlane_03((input == null) ? default(HandleRef) : input.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractTransform = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractTransform.Register(null);
				}
			}
			return vtkAbstractTransform;
		}

		// Token: 0x06018E98 RID: 102040
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDelaunay2D_GetAlpha_04(HandleRef pThis);

		/// <summary>
		/// Specify alpha (or distance) value to control output of this filter.
		/// For a non-zero alpha value, only edges or triangles contained within
		/// a sphere centered at mesh vertices will be output. Otherwise, only
		/// triangles will be output.
		/// </summary>
		// Token: 0x06018E99 RID: 102041 RVA: 0x0022BFC8 File Offset: 0x0022A1C8
		public virtual double GetAlpha()
		{
			return vtkDelaunay2D.vtkDelaunay2D_GetAlpha_04(base.GetCppThis());
		}

		// Token: 0x06018E9A RID: 102042
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDelaunay2D_GetAlphaMaxValue_05(HandleRef pThis);

		/// <summary>
		/// Specify alpha (or distance) value to control output of this filter.
		/// For a non-zero alpha value, only edges or triangles contained within
		/// a sphere centered at mesh vertices will be output. Otherwise, only
		/// triangles will be output.
		/// </summary>
		// Token: 0x06018E9B RID: 102043 RVA: 0x0022BFE8 File Offset: 0x0022A1E8
		public virtual double GetAlphaMaxValue()
		{
			return vtkDelaunay2D.vtkDelaunay2D_GetAlphaMaxValue_05(base.GetCppThis());
		}

		// Token: 0x06018E9C RID: 102044
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDelaunay2D_GetAlphaMinValue_06(HandleRef pThis);

		/// <summary>
		/// Specify alpha (or distance) value to control output of this filter.
		/// For a non-zero alpha value, only edges or triangles contained within
		/// a sphere centered at mesh vertices will be output. Otherwise, only
		/// triangles will be output.
		/// </summary>
		// Token: 0x06018E9D RID: 102045 RVA: 0x0022C008 File Offset: 0x0022A208
		public virtual double GetAlphaMinValue()
		{
			return vtkDelaunay2D.vtkDelaunay2D_GetAlphaMinValue_06(base.GetCppThis());
		}

		// Token: 0x06018E9E RID: 102046
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDelaunay2D_GetBoundingTriangulation_07(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether bounding triangulation points (and associated
		/// triangles) are included in the output. (These are introduced as an
		/// initial triangulation to begin the triangulation process. This feature
		/// is nice for debugging output.)
		/// </summary>
		// Token: 0x06018E9F RID: 102047 RVA: 0x0022C028 File Offset: 0x0022A228
		public virtual int GetBoundingTriangulation()
		{
			return vtkDelaunay2D.vtkDelaunay2D_GetBoundingTriangulation_07(base.GetCppThis());
		}

		// Token: 0x06018EA0 RID: 102048
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDelaunay2D_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018EA1 RID: 102049 RVA: 0x0022C048 File Offset: 0x0022A248
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDelaunay2D.vtkDelaunay2D_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x06018EA2 RID: 102050
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDelaunay2D_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018EA3 RID: 102051 RVA: 0x0022C068 File Offset: 0x0022A268
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDelaunay2D.vtkDelaunay2D_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x06018EA4 RID: 102052
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDelaunay2D_GetOffset_10(HandleRef pThis);

		/// <summary>
		/// Specify a multiplier to control the size of the initial, bounding
		/// Delaunay triangulation.
		/// </summary>
		// Token: 0x06018EA5 RID: 102053 RVA: 0x0022C084 File Offset: 0x0022A284
		public virtual double GetOffset()
		{
			return vtkDelaunay2D.vtkDelaunay2D_GetOffset_10(base.GetCppThis());
		}

		// Token: 0x06018EA6 RID: 102054
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDelaunay2D_GetOffsetMaxValue_11(HandleRef pThis);

		/// <summary>
		/// Specify a multiplier to control the size of the initial, bounding
		/// Delaunay triangulation.
		/// </summary>
		// Token: 0x06018EA7 RID: 102055 RVA: 0x0022C0A4 File Offset: 0x0022A2A4
		public virtual double GetOffsetMaxValue()
		{
			return vtkDelaunay2D.vtkDelaunay2D_GetOffsetMaxValue_11(base.GetCppThis());
		}

		// Token: 0x06018EA8 RID: 102056
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDelaunay2D_GetOffsetMinValue_12(HandleRef pThis);

		/// <summary>
		/// Specify a multiplier to control the size of the initial, bounding
		/// Delaunay triangulation.
		/// </summary>
		// Token: 0x06018EA9 RID: 102057 RVA: 0x0022C0C4 File Offset: 0x0022A2C4
		public virtual double GetOffsetMinValue()
		{
			return vtkDelaunay2D.vtkDelaunay2D_GetOffsetMinValue_12(base.GetCppThis());
		}

		// Token: 0x06018EAA RID: 102058
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDelaunay2D_GetProjectionPlaneMode_13(HandleRef pThis);

		/// <summary>
		/// Define the method to project the input 3D points into a 2D plane for
		/// triangulation. When the VTK_DELAUNAY_XY_PLANE is set, the z-coordinate
		/// is simply ignored. When VTK_SET_TRANSFORM_PLANE is set, then a transform
		/// must be supplied and the points are transformed using it. Finally, if
		/// VTK_BEST_FITTING_PLANE is set, then the filter computes a best fitting
		/// plane and projects the points onto it.
		/// </summary>
		// Token: 0x06018EAB RID: 102059 RVA: 0x0022C0E4 File Offset: 0x0022A2E4
		public virtual int GetProjectionPlaneMode()
		{
			return vtkDelaunay2D.vtkDelaunay2D_GetProjectionPlaneMode_13(base.GetCppThis());
		}

		// Token: 0x06018EAC RID: 102060
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDelaunay2D_GetProjectionPlaneModeMaxValue_14(HandleRef pThis);

		/// <summary>
		/// Define the method to project the input 3D points into a 2D plane for
		/// triangulation. When the VTK_DELAUNAY_XY_PLANE is set, the z-coordinate
		/// is simply ignored. When VTK_SET_TRANSFORM_PLANE is set, then a transform
		/// must be supplied and the points are transformed using it. Finally, if
		/// VTK_BEST_FITTING_PLANE is set, then the filter computes a best fitting
		/// plane and projects the points onto it.
		/// </summary>
		// Token: 0x06018EAD RID: 102061 RVA: 0x0022C104 File Offset: 0x0022A304
		public virtual int GetProjectionPlaneModeMaxValue()
		{
			return vtkDelaunay2D.vtkDelaunay2D_GetProjectionPlaneModeMaxValue_14(base.GetCppThis());
		}

		// Token: 0x06018EAE RID: 102062
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDelaunay2D_GetProjectionPlaneModeMinValue_15(HandleRef pThis);

		/// <summary>
		/// Define the method to project the input 3D points into a 2D plane for
		/// triangulation. When the VTK_DELAUNAY_XY_PLANE is set, the z-coordinate
		/// is simply ignored. When VTK_SET_TRANSFORM_PLANE is set, then a transform
		/// must be supplied and the points are transformed using it. Finally, if
		/// VTK_BEST_FITTING_PLANE is set, then the filter computes a best fitting
		/// plane and projects the points onto it.
		/// </summary>
		// Token: 0x06018EAF RID: 102063 RVA: 0x0022C124 File Offset: 0x0022A324
		public virtual int GetProjectionPlaneModeMinValue()
		{
			return vtkDelaunay2D.vtkDelaunay2D_GetProjectionPlaneModeMinValue_15(base.GetCppThis());
		}

		// Token: 0x06018EB0 RID: 102064
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDelaunay2D_GetRandomPointInsertion_16(HandleRef pThis);

		/// <summary>
		/// Indicate whether to insert the points in given order, or pseudo-random
		/// order. Inserting in random order can improve performance and numerics
		/// in many circumstances.
		/// </summary>
		// Token: 0x06018EB1 RID: 102065 RVA: 0x0022C144 File Offset: 0x0022A344
		public virtual int GetRandomPointInsertion()
		{
			return vtkDelaunay2D.vtkDelaunay2D_GetRandomPointInsertion_16(base.GetCppThis());
		}

		// Token: 0x06018EB2 RID: 102066
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDelaunay2D_GetSource_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get a pointer to the source object.
		/// </summary>
		// Token: 0x06018EB3 RID: 102067 RVA: 0x0022C164 File Offset: 0x0022A364
		public vtkPolyData GetSource()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDelaunay2D.vtkDelaunay2D_GetSource_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x06018EB4 RID: 102068
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDelaunay2D_GetTolerance_18(HandleRef pThis);

		/// <summary>
		/// Specify a tolerance to control discarding of closely spaced points.
		/// This tolerance is specified as a fraction of the diagonal length of
		/// the bounding box of the points.
		/// </summary>
		// Token: 0x06018EB5 RID: 102069 RVA: 0x0022C1D4 File Offset: 0x0022A3D4
		public virtual double GetTolerance()
		{
			return vtkDelaunay2D.vtkDelaunay2D_GetTolerance_18(base.GetCppThis());
		}

		// Token: 0x06018EB6 RID: 102070
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDelaunay2D_GetToleranceMaxValue_19(HandleRef pThis);

		/// <summary>
		/// Specify a tolerance to control discarding of closely spaced points.
		/// This tolerance is specified as a fraction of the diagonal length of
		/// the bounding box of the points.
		/// </summary>
		// Token: 0x06018EB7 RID: 102071 RVA: 0x0022C1F4 File Offset: 0x0022A3F4
		public virtual double GetToleranceMaxValue()
		{
			return vtkDelaunay2D.vtkDelaunay2D_GetToleranceMaxValue_19(base.GetCppThis());
		}

		// Token: 0x06018EB8 RID: 102072
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDelaunay2D_GetToleranceMinValue_20(HandleRef pThis);

		/// <summary>
		/// Specify a tolerance to control discarding of closely spaced points.
		/// This tolerance is specified as a fraction of the diagonal length of
		/// the bounding box of the points.
		/// </summary>
		// Token: 0x06018EB9 RID: 102073 RVA: 0x0022C214 File Offset: 0x0022A414
		public virtual double GetToleranceMinValue()
		{
			return vtkDelaunay2D.vtkDelaunay2D_GetToleranceMinValue_20(base.GetCppThis());
		}

		// Token: 0x06018EBA RID: 102074
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDelaunay2D_GetTransform_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set / get the transform which is applied to points to generate a
		/// 2D problem.  This maps a 3D dataset into a 2D dataset where
		/// triangulation can be done on the XY plane.  The points are
		/// transformed and triangulated.  The topology of triangulated
		/// points is used as the output topology.  The output points are the
		/// original (untransformed) points.  The transform can be any
		/// subclass of vtkAbstractTransform (thus it does not need to be a
		/// linear or invertible transform).
		/// </summary>
		// Token: 0x06018EBB RID: 102075 RVA: 0x0022C234 File Offset: 0x0022A434
		public virtual vtkAbstractTransform GetTransform()
		{
			vtkAbstractTransform vtkAbstractTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDelaunay2D.vtkDelaunay2D_GetTransform_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractTransform = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractTransform.Register(null);
				}
			}
			return vtkAbstractTransform;
		}

		// Token: 0x06018EBC RID: 102076
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDelaunay2D_IsA_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018EBD RID: 102077 RVA: 0x0022C2A4 File Offset: 0x0022A4A4
		public override int IsA(string type)
		{
			return vtkDelaunay2D.vtkDelaunay2D_IsA_22(base.GetCppThis(), type);
		}

		// Token: 0x06018EBE RID: 102078
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDelaunay2D_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018EBF RID: 102079 RVA: 0x0022C2C4 File Offset: 0x0022A4C4
		public new static int IsTypeOf(string type)
		{
			return vtkDelaunay2D.vtkDelaunay2D_IsTypeOf_23(type);
		}

		// Token: 0x06018EC0 RID: 102080
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDelaunay2D_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018EC1 RID: 102081 RVA: 0x0022C2E0 File Offset: 0x0022A4E0
		public new vtkDelaunay2D NewInstance()
		{
			vtkDelaunay2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDelaunay2D.vtkDelaunay2D_NewInstance_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDelaunay2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06018EC2 RID: 102082
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelaunay2D_RandomPointInsertionOff_26(HandleRef pThis);

		/// <summary>
		/// Indicate whether to insert the points in given order, or pseudo-random
		/// order. Inserting in random order can improve performance and numerics
		/// in many circumstances.
		/// </summary>
		// Token: 0x06018EC3 RID: 102083 RVA: 0x0022C33A File Offset: 0x0022A53A
		public virtual void RandomPointInsertionOff()
		{
			vtkDelaunay2D.vtkDelaunay2D_RandomPointInsertionOff_26(base.GetCppThis());
		}

		// Token: 0x06018EC4 RID: 102084
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelaunay2D_RandomPointInsertionOn_27(HandleRef pThis);

		/// <summary>
		/// Indicate whether to insert the points in given order, or pseudo-random
		/// order. Inserting in random order can improve performance and numerics
		/// in many circumstances.
		/// </summary>
		// Token: 0x06018EC5 RID: 102085 RVA: 0x0022C349 File Offset: 0x0022A549
		public virtual void RandomPointInsertionOn()
		{
			vtkDelaunay2D.vtkDelaunay2D_RandomPointInsertionOn_27(base.GetCppThis());
		}

		// Token: 0x06018EC6 RID: 102086
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDelaunay2D_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018EC7 RID: 102087 RVA: 0x0022C358 File Offset: 0x0022A558
		public new static vtkDelaunay2D SafeDownCast(vtkObjectBase o)
		{
			vtkDelaunay2D vtkDelaunay2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDelaunay2D.vtkDelaunay2D_SafeDownCast_28((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDelaunay2D = (vtkDelaunay2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDelaunay2D.Register(null);
				}
			}
			return vtkDelaunay2D;
		}

		// Token: 0x06018EC8 RID: 102088
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelaunay2D_SetAlpha_29(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify alpha (or distance) value to control output of this filter.
		/// For a non-zero alpha value, only edges or triangles contained within
		/// a sphere centered at mesh vertices will be output. Otherwise, only
		/// triangles will be output.
		/// </summary>
		// Token: 0x06018EC9 RID: 102089 RVA: 0x0022C3D7 File Offset: 0x0022A5D7
		public virtual void SetAlpha(double _arg)
		{
			vtkDelaunay2D.vtkDelaunay2D_SetAlpha_29(base.GetCppThis(), _arg);
		}

		// Token: 0x06018ECA RID: 102090
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelaunay2D_SetBoundingTriangulation_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Boolean controls whether bounding triangulation points (and associated
		/// triangles) are included in the output. (These are introduced as an
		/// initial triangulation to begin the triangulation process. This feature
		/// is nice for debugging output.)
		/// </summary>
		// Token: 0x06018ECB RID: 102091 RVA: 0x0022C3E7 File Offset: 0x0022A5E7
		public virtual void SetBoundingTriangulation(int _arg)
		{
			vtkDelaunay2D.vtkDelaunay2D_SetBoundingTriangulation_30(base.GetCppThis(), _arg);
		}

		// Token: 0x06018ECC RID: 102092
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelaunay2D_SetOffset_31(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify a multiplier to control the size of the initial, bounding
		/// Delaunay triangulation.
		/// </summary>
		// Token: 0x06018ECD RID: 102093 RVA: 0x0022C3F7 File Offset: 0x0022A5F7
		public virtual void SetOffset(double _arg)
		{
			vtkDelaunay2D.vtkDelaunay2D_SetOffset_31(base.GetCppThis(), _arg);
		}

		// Token: 0x06018ECE RID: 102094
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelaunay2D_SetProjectionPlaneMode_32(HandleRef pThis, int _arg);

		/// <summary>
		/// Define the method to project the input 3D points into a 2D plane for
		/// triangulation. When the VTK_DELAUNAY_XY_PLANE is set, the z-coordinate
		/// is simply ignored. When VTK_SET_TRANSFORM_PLANE is set, then a transform
		/// must be supplied and the points are transformed using it. Finally, if
		/// VTK_BEST_FITTING_PLANE is set, then the filter computes a best fitting
		/// plane and projects the points onto it.
		/// </summary>
		// Token: 0x06018ECF RID: 102095 RVA: 0x0022C407 File Offset: 0x0022A607
		public virtual void SetProjectionPlaneMode(int _arg)
		{
			vtkDelaunay2D.vtkDelaunay2D_SetProjectionPlaneMode_32(base.GetCppThis(), _arg);
		}

		// Token: 0x06018ED0 RID: 102096
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelaunay2D_SetRandomPointInsertion_33(HandleRef pThis, int _arg);

		/// <summary>
		/// Indicate whether to insert the points in given order, or pseudo-random
		/// order. Inserting in random order can improve performance and numerics
		/// in many circumstances.
		/// </summary>
		// Token: 0x06018ED1 RID: 102097 RVA: 0x0022C417 File Offset: 0x0022A617
		public virtual void SetRandomPointInsertion(int _arg)
		{
			vtkDelaunay2D.vtkDelaunay2D_SetRandomPointInsertion_33(base.GetCppThis(), _arg);
		}

		// Token: 0x06018ED2 RID: 102098
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelaunay2D_SetSourceConnection_34(HandleRef pThis, HandleRef algOutput);

		/// <summary>
		/// Specify the source object used to specify constrained edges and loops.
		/// (This is optional.) If set, and lines/polygons are defined, a constrained
		/// triangulation is created. The lines/polygons are assumed to reference
		/// points in the input point set (i.e. point ids are identical in the
		/// input and source).
		/// New style. This method is equivalent to SetInputConnection(1, algOutput).
		/// </summary>
		// Token: 0x06018ED3 RID: 102099 RVA: 0x0022C428 File Offset: 0x0022A628
		public void SetSourceConnection(vtkAlgorithmOutput algOutput)
		{
			vtkDelaunay2D.vtkDelaunay2D_SetSourceConnection_34(base.GetCppThis(), (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}

		// Token: 0x06018ED4 RID: 102100
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelaunay2D_SetSourceData_35(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the source object used to specify constrained edges and loops.
		/// (This is optional.) If set, and lines/polygons are defined, a constrained
		/// triangulation is created. The lines/polygons are assumed to reference
		/// points in the input point set (i.e. point ids are identical in the
		/// input and source).
		/// Note that this method does not connect the pipeline. See SetSourceConnection
		/// for connecting the pipeline.
		/// </summary>
		// Token: 0x06018ED5 RID: 102101 RVA: 0x0022C458 File Offset: 0x0022A658
		public void SetSourceData(vtkPolyData arg0)
		{
			vtkDelaunay2D.vtkDelaunay2D_SetSourceData_35(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06018ED6 RID: 102102
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelaunay2D_SetTolerance_36(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify a tolerance to control discarding of closely spaced points.
		/// This tolerance is specified as a fraction of the diagonal length of
		/// the bounding box of the points.
		/// </summary>
		// Token: 0x06018ED7 RID: 102103 RVA: 0x0022C487 File Offset: 0x0022A687
		public virtual void SetTolerance(double _arg)
		{
			vtkDelaunay2D.vtkDelaunay2D_SetTolerance_36(base.GetCppThis(), _arg);
		}

		// Token: 0x06018ED8 RID: 102104
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelaunay2D_SetTransform_37(HandleRef pThis, HandleRef _arg);

		/// <summary>
		/// Set / get the transform which is applied to points to generate a
		/// 2D problem.  This maps a 3D dataset into a 2D dataset where
		/// triangulation can be done on the XY plane.  The points are
		/// transformed and triangulated.  The topology of triangulated
		/// points is used as the output topology.  The output points are the
		/// original (untransformed) points.  The transform can be any
		/// subclass of vtkAbstractTransform (thus it does not need to be a
		/// linear or invertible transform).
		/// </summary>
		// Token: 0x06018ED9 RID: 102105 RVA: 0x0022C498 File Offset: 0x0022A698
		public virtual void SetTransform(vtkAbstractTransform _arg)
		{
			vtkDelaunay2D.vtkDelaunay2D_SetTransform_37(base.GetCppThis(), (_arg == null) ? default(HandleRef) : _arg.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B71 RID: 7025
		public new const string MRFullTypeName = "Kitware.VTK.vtkDelaunay2D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B72 RID: 7026
		public new static readonly string MRClassNameKey = "class vtkDelaunay2D";
	}
}
