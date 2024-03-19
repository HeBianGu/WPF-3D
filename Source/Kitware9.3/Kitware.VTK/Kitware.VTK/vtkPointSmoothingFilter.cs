using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPointSmoothingFilter
	/// </summary>
	/// <remarks>
	///    adjust point positions to form a pleasing, packed arrangement
	///
	///
	/// vtkPointSmoothingFilter modifies the coordinates of the input points of a
	/// vtkPointSet by adjusting their position to create a smooth distribution
	/// (and thereby form a pleasing packing of the points). Smoothing is
	/// performed by considering the effects of neighboring points on one
	/// another. Smoothing in its simplest form (geometric) is simply a variant of
	/// Laplacian smoothing where each point moves towards the average position of
	/// its neighboring points. Next, uniform smoothing uses a cubic cutoff
	/// function to produce repulsive forces between close points and attractive
	/// forces that are a little further away. Smoothing can be further controlled
	/// either by a scalar field, by a tensor field, or a frame field (the user
	/// can specify the nature of the smoothing operation). If controlled by a
	/// scalar field, then each input point is assumed to be surrounded by a
	/// isotropic sphere scaled by the scalar field; if controlled by a tensor
	/// field, then each input point is assumed to be surrounded by an
	/// anisotropic, oriented ellipsoid aligned to the the tensor eigenvectors and
	/// scaled by the determinate of the tensor. A frame field also assumes a
	/// surrounding, ellipsoidal shape except that the inversion of the ellipsoid
	/// tensor is already performed. Typical usage of this filter is to perform a
	/// smoothing (also referred to as packing) operation (i.e., first execute
	/// this filter) and then combine it with a glyph filter (e.g., vtkTensorGlyph
	/// or vtkGlyph3D) to visualize the packed points.
	///
	/// Smoothing depends on a local neighborhood of nearby points. In general,
	/// the larger the neighborhood size, the greater the reduction in high
	/// frequency information. (The memory and/or computational requirements of
	/// the algorithm may also significantly increase.) The PackingRadius (and
	/// PackingFactor) controls what points are considered close. The
	/// PackingRadius can be computed automatically, or specified by the user.
	/// (The product of PackingRadius*PackingFactor is referred to as the scaling
	/// factor alpha in the paper cited below. This provides a convenient way to
	/// combine automatic PackingRadius computation based on average between
	/// particle neighborhoods, and then adjust it with the PackingFactor.)
	///
	/// Any vtkPointSet type can be provided as input, and the output will contain
	/// the same number of new points each of which is adjusted to a new position.
	///
	/// Note that the algorithm requires the use of a spatial point locator. The
	/// point locator is used to build a local neighborhood of the points
	/// surrounding each point. It is also used to perform interpolation as the
	/// point positions are adjusted.
	///
	/// The algorithm incrementally adjusts the point positions through an
	/// iterative process. Basically points are moved due to the influence of
	/// neighboring points. Iterations continue until the specified number of
	/// iterations is reached, or convergence occurs. Convergence occurs when the
	/// maximum displacement of any point is less than the convergence value. As
	/// points move, both the local connectivity and data attributes associated
	/// with each point must be updated. Rather than performing these expensive
	/// operations after every iteration, a number of sub-iterations Si can be
	/// specified. If Si &gt; 1, then the neighborhood and attribute value updates
	/// occur only every Si'th iteration. Using sub-iterations can improve
	/// performance significantly.
	///
	/// @warning
	/// Geometric smoothing defines a one-sided attractive force between
	/// particles. Thus particles tend to clump together, and the entire set of
	/// points (with enough iterations and appropriate PackingRadius) can converge
	/// to a single position. This can be mitigated by turning on point
	/// constraints, which limit the movement of "boundary" points.
	///
	/// @warning
	/// This class has been loosely inspired by the paper by Kindlmann and Westin
	/// "Diffusion Tensor Visualization with Glyph Packing". However, several
	/// computational shortcuts, and generalizations have been used for performance
	/// and utility reasons.
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkTensorWidget vtkTensorGlyph vtkSmoothPolyDataFilter vtkGlyph3D
	/// </seealso>
	// Token: 0x02000454 RID: 1108
	public class vtkPointSmoothingFilter : vtkPointSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600CE2B RID: 52779 RVA: 0x0011EDFC File Offset: 0x0011CFFC
		static vtkPointSmoothingFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPointSmoothingFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointSmoothingFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600CE2C RID: 52780 RVA: 0x0011EE24 File Offset: 0x0011D024
		public vtkPointSmoothingFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600CE2D RID: 52781
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSmoothingFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CE2E RID: 52782 RVA: 0x0011EE34 File Offset: 0x0011D034
		public new static vtkPointSmoothingFilter New()
		{
			vtkPointSmoothingFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointSmoothingFilter.vtkPointSmoothingFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointSmoothingFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CE2F RID: 52783 RVA: 0x0011EE88 File Offset: 0x0011D088
		public vtkPointSmoothingFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPointSmoothingFilter.vtkPointSmoothingFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600CE30 RID: 52784 RVA: 0x0011EECC File Offset: 0x0011D0CC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600CE31 RID: 52785
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSmoothingFilter_ComputePackingRadiusOff_01(HandleRef pThis);

		/// <summary>
		/// Enable / disable the computation of a packing radius. By default,
		/// a packing radius is computed as one half of the average distance
		/// between neighboring points. (Point neighbors are defined by the
		/// neighborhood size.)
		/// </summary>
		// Token: 0x0600CE32 RID: 52786 RVA: 0x0011EED7 File Offset: 0x0011D0D7
		public virtual void ComputePackingRadiusOff()
		{
			vtkPointSmoothingFilter.vtkPointSmoothingFilter_ComputePackingRadiusOff_01(base.GetCppThis());
		}

		// Token: 0x0600CE33 RID: 52787
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSmoothingFilter_ComputePackingRadiusOn_02(HandleRef pThis);

		/// <summary>
		/// Enable / disable the computation of a packing radius. By default,
		/// a packing radius is computed as one half of the average distance
		/// between neighboring points. (Point neighbors are defined by the
		/// neighborhood size.)
		/// </summary>
		// Token: 0x0600CE34 RID: 52788 RVA: 0x0011EEE6 File Offset: 0x0011D0E6
		public virtual void ComputePackingRadiusOn()
		{
			vtkPointSmoothingFilter.vtkPointSmoothingFilter_ComputePackingRadiusOn_02(base.GetCppThis());
		}

		// Token: 0x0600CE35 RID: 52789
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSmoothingFilter_EnableConstraintsOff_03(HandleRef pThis);

		/// <summary>
		/// Enable or disable constraints on points. Point constraints are used to
		/// prevent points from moving, or to move only on a plane. This can prevent
		/// shrinking or growing point clouds. If enabled, a local topological
		/// analysis is performed to determine whether a point should be marked
		/// "Fixed" i.e., never moves; "Plane", the point only moves on a plane; or
		/// "Unconstrained", the point can move freely. If all points in the
		/// neighborhood surrounding a point are in the cone defined by FixedAngle,
		/// then the point is classified "Fixed." If all points in the neighborhood
		/// surrounding a point are in the cone defined by BoundaryAngle, then the
		/// point is classified "Plane." (The angles are expressed in degrees.)
		/// </summary>
		// Token: 0x0600CE36 RID: 52790 RVA: 0x0011EEF5 File Offset: 0x0011D0F5
		public virtual void EnableConstraintsOff()
		{
			vtkPointSmoothingFilter.vtkPointSmoothingFilter_EnableConstraintsOff_03(base.GetCppThis());
		}

		// Token: 0x0600CE37 RID: 52791
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSmoothingFilter_EnableConstraintsOn_04(HandleRef pThis);

		/// <summary>
		/// Enable or disable constraints on points. Point constraints are used to
		/// prevent points from moving, or to move only on a plane. This can prevent
		/// shrinking or growing point clouds. If enabled, a local topological
		/// analysis is performed to determine whether a point should be marked
		/// "Fixed" i.e., never moves; "Plane", the point only moves on a plane; or
		/// "Unconstrained", the point can move freely. If all points in the
		/// neighborhood surrounding a point are in the cone defined by FixedAngle,
		/// then the point is classified "Fixed." If all points in the neighborhood
		/// surrounding a point are in the cone defined by BoundaryAngle, then the
		/// point is classified "Plane." (The angles are expressed in degrees.)
		/// </summary>
		// Token: 0x0600CE38 RID: 52792 RVA: 0x0011EF04 File Offset: 0x0011D104
		public virtual void EnableConstraintsOn()
		{
			vtkPointSmoothingFilter.vtkPointSmoothingFilter_EnableConstraintsOn_04(base.GetCppThis());
		}

		// Token: 0x0600CE39 RID: 52793
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSmoothingFilter_GenerateConstraintNormalsOff_05(HandleRef pThis);

		/// <summary>
		/// If point constraints are enabled, an output vector indicating the
		/// average normal at each point can be generated.
		/// </summary>
		// Token: 0x0600CE3A RID: 52794 RVA: 0x0011EF13 File Offset: 0x0011D113
		public virtual void GenerateConstraintNormalsOff()
		{
			vtkPointSmoothingFilter.vtkPointSmoothingFilter_GenerateConstraintNormalsOff_05(base.GetCppThis());
		}

		// Token: 0x0600CE3B RID: 52795
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSmoothingFilter_GenerateConstraintNormalsOn_06(HandleRef pThis);

		/// <summary>
		/// If point constraints are enabled, an output vector indicating the
		/// average normal at each point can be generated.
		/// </summary>
		// Token: 0x0600CE3C RID: 52796 RVA: 0x0011EF22 File Offset: 0x0011D122
		public virtual void GenerateConstraintNormalsOn()
		{
			vtkPointSmoothingFilter.vtkPointSmoothingFilter_GenerateConstraintNormalsOn_06(base.GetCppThis());
		}

		// Token: 0x0600CE3D RID: 52797
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSmoothingFilter_GenerateConstraintScalarsOff_07(HandleRef pThis);

		/// <summary>
		/// If point constraints are enabled, an output scalar indicating the
		/// classification of points can be generated.
		/// </summary>
		// Token: 0x0600CE3E RID: 52798 RVA: 0x0011EF31 File Offset: 0x0011D131
		public virtual void GenerateConstraintScalarsOff()
		{
			vtkPointSmoothingFilter.vtkPointSmoothingFilter_GenerateConstraintScalarsOff_07(base.GetCppThis());
		}

		// Token: 0x0600CE3F RID: 52799
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSmoothingFilter_GenerateConstraintScalarsOn_08(HandleRef pThis);

		/// <summary>
		/// If point constraints are enabled, an output scalar indicating the
		/// classification of points can be generated.
		/// </summary>
		// Token: 0x0600CE40 RID: 52800 RVA: 0x0011EF40 File Offset: 0x0011D140
		public virtual void GenerateConstraintScalarsOn()
		{
			vtkPointSmoothingFilter.vtkPointSmoothingFilter_GenerateConstraintScalarsOn_08(base.GetCppThis());
		}

		// Token: 0x0600CE41 RID: 52801
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPointSmoothingFilter_GetAttractionFactor_09(HandleRef pThis);

		/// <summary>
		/// Control the relative distance of inter-particle attraction. A value of
		/// 1.0 means that the radius of the attraction region is the same as the
		/// radius of repulsion. By default, a value of 0.5 is used (e.g., in the
		/// region 0&lt;=r&lt;=R a repulsive force is generated, while in R&lt;r&lt;=R*1.5 an
		/// attractive force is generated).
		/// </summary>
		// Token: 0x0600CE42 RID: 52802 RVA: 0x0011EF50 File Offset: 0x0011D150
		public virtual double GetAttractionFactor()
		{
			return vtkPointSmoothingFilter.vtkPointSmoothingFilter_GetAttractionFactor_09(base.GetCppThis());
		}

		// Token: 0x0600CE43 RID: 52803
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPointSmoothingFilter_GetAttractionFactorMaxValue_10(HandleRef pThis);

		/// <summary>
		/// Control the relative distance of inter-particle attraction. A value of
		/// 1.0 means that the radius of the attraction region is the same as the
		/// radius of repulsion. By default, a value of 0.5 is used (e.g., in the
		/// region 0&lt;=r&lt;=R a repulsive force is generated, while in R&lt;r&lt;=R*1.5 an
		/// attractive force is generated).
		/// </summary>
		// Token: 0x0600CE44 RID: 52804 RVA: 0x0011EF70 File Offset: 0x0011D170
		public virtual double GetAttractionFactorMaxValue()
		{
			return vtkPointSmoothingFilter.vtkPointSmoothingFilter_GetAttractionFactorMaxValue_10(base.GetCppThis());
		}

		// Token: 0x0600CE45 RID: 52805
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPointSmoothingFilter_GetAttractionFactorMinValue_11(HandleRef pThis);

		/// <summary>
		/// Control the relative distance of inter-particle attraction. A value of
		/// 1.0 means that the radius of the attraction region is the same as the
		/// radius of repulsion. By default, a value of 0.5 is used (e.g., in the
		/// region 0&lt;=r&lt;=R a repulsive force is generated, while in R&lt;r&lt;=R*1.5 an
		/// attractive force is generated).
		/// </summary>
		// Token: 0x0600CE46 RID: 52806 RVA: 0x0011EF90 File Offset: 0x0011D190
		public virtual double GetAttractionFactorMinValue()
		{
			return vtkPointSmoothingFilter.vtkPointSmoothingFilter_GetAttractionFactorMinValue_11(base.GetCppThis());
		}

		// Token: 0x0600CE47 RID: 52807
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPointSmoothingFilter_GetBoundaryAngle_12(HandleRef pThis);

		/// <summary>
		/// Enable or disable constraints on points. Point constraints are used to
		/// prevent points from moving, or to move only on a plane. This can prevent
		/// shrinking or growing point clouds. If enabled, a local topological
		/// analysis is performed to determine whether a point should be marked
		/// "Fixed" i.e., never moves; "Plane", the point only moves on a plane; or
		/// "Unconstrained", the point can move freely. If all points in the
		/// neighborhood surrounding a point are in the cone defined by FixedAngle,
		/// then the point is classified "Fixed." If all points in the neighborhood
		/// surrounding a point are in the cone defined by BoundaryAngle, then the
		/// point is classified "Plane." (The angles are expressed in degrees.)
		/// </summary>
		// Token: 0x0600CE48 RID: 52808 RVA: 0x0011EFB0 File Offset: 0x0011D1B0
		public virtual double GetBoundaryAngle()
		{
			return vtkPointSmoothingFilter.vtkPointSmoothingFilter_GetBoundaryAngle_12(base.GetCppThis());
		}

		// Token: 0x0600CE49 RID: 52809
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPointSmoothingFilter_GetBoundaryAngleMaxValue_13(HandleRef pThis);

		/// <summary>
		/// Enable or disable constraints on points. Point constraints are used to
		/// prevent points from moving, or to move only on a plane. This can prevent
		/// shrinking or growing point clouds. If enabled, a local topological
		/// analysis is performed to determine whether a point should be marked
		/// "Fixed" i.e., never moves; "Plane", the point only moves on a plane; or
		/// "Unconstrained", the point can move freely. If all points in the
		/// neighborhood surrounding a point are in the cone defined by FixedAngle,
		/// then the point is classified "Fixed." If all points in the neighborhood
		/// surrounding a point are in the cone defined by BoundaryAngle, then the
		/// point is classified "Plane." (The angles are expressed in degrees.)
		/// </summary>
		// Token: 0x0600CE4A RID: 52810 RVA: 0x0011EFD0 File Offset: 0x0011D1D0
		public virtual double GetBoundaryAngleMaxValue()
		{
			return vtkPointSmoothingFilter.vtkPointSmoothingFilter_GetBoundaryAngleMaxValue_13(base.GetCppThis());
		}

		// Token: 0x0600CE4B RID: 52811
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPointSmoothingFilter_GetBoundaryAngleMinValue_14(HandleRef pThis);

		/// <summary>
		/// Enable or disable constraints on points. Point constraints are used to
		/// prevent points from moving, or to move only on a plane. This can prevent
		/// shrinking or growing point clouds. If enabled, a local topological
		/// analysis is performed to determine whether a point should be marked
		/// "Fixed" i.e., never moves; "Plane", the point only moves on a plane; or
		/// "Unconstrained", the point can move freely. If all points in the
		/// neighborhood surrounding a point are in the cone defined by FixedAngle,
		/// then the point is classified "Fixed." If all points in the neighborhood
		/// surrounding a point are in the cone defined by BoundaryAngle, then the
		/// point is classified "Plane." (The angles are expressed in degrees.)
		/// </summary>
		// Token: 0x0600CE4C RID: 52812 RVA: 0x0011EFF0 File Offset: 0x0011D1F0
		public virtual double GetBoundaryAngleMinValue()
		{
			return vtkPointSmoothingFilter.vtkPointSmoothingFilter_GetBoundaryAngleMinValue_14(base.GetCppThis());
		}

		// Token: 0x0600CE4D RID: 52813
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPointSmoothingFilter_GetComputePackingRadius_15(HandleRef pThis);

		/// <summary>
		/// Enable / disable the computation of a packing radius. By default,
		/// a packing radius is computed as one half of the average distance
		/// between neighboring points. (Point neighbors are defined by the
		/// neighborhood size.)
		/// </summary>
		// Token: 0x0600CE4E RID: 52814 RVA: 0x0011F010 File Offset: 0x0011D210
		public virtual bool GetComputePackingRadius()
		{
			return vtkPointSmoothingFilter.vtkPointSmoothingFilter_GetComputePackingRadius_15(base.GetCppThis()) != 0;
		}

		// Token: 0x0600CE4F RID: 52815
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPointSmoothingFilter_GetConvergence_16(HandleRef pThis);

		/// <summary>
		/// Specify a convergence criterion for the iteration
		/// process. Smaller numbers result in more smoothing iterations.
		/// </summary>
		// Token: 0x0600CE50 RID: 52816 RVA: 0x0011F038 File Offset: 0x0011D238
		public virtual double GetConvergence()
		{
			return vtkPointSmoothingFilter.vtkPointSmoothingFilter_GetConvergence_16(base.GetCppThis());
		}

		// Token: 0x0600CE51 RID: 52817
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPointSmoothingFilter_GetConvergenceMaxValue_17(HandleRef pThis);

		/// <summary>
		/// Specify a convergence criterion for the iteration
		/// process. Smaller numbers result in more smoothing iterations.
		/// </summary>
		// Token: 0x0600CE52 RID: 52818 RVA: 0x0011F058 File Offset: 0x0011D258
		public virtual double GetConvergenceMaxValue()
		{
			return vtkPointSmoothingFilter.vtkPointSmoothingFilter_GetConvergenceMaxValue_17(base.GetCppThis());
		}

		// Token: 0x0600CE53 RID: 52819
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPointSmoothingFilter_GetConvergenceMinValue_18(HandleRef pThis);

		/// <summary>
		/// Specify a convergence criterion for the iteration
		/// process. Smaller numbers result in more smoothing iterations.
		/// </summary>
		// Token: 0x0600CE54 RID: 52820 RVA: 0x0011F078 File Offset: 0x0011D278
		public virtual double GetConvergenceMinValue()
		{
			return vtkPointSmoothingFilter.vtkPointSmoothingFilter_GetConvergenceMinValue_18(base.GetCppThis());
		}

		// Token: 0x0600CE55 RID: 52821
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPointSmoothingFilter_GetEnableConstraints_19(HandleRef pThis);

		/// <summary>
		/// Enable or disable constraints on points. Point constraints are used to
		/// prevent points from moving, or to move only on a plane. This can prevent
		/// shrinking or growing point clouds. If enabled, a local topological
		/// analysis is performed to determine whether a point should be marked
		/// "Fixed" i.e., never moves; "Plane", the point only moves on a plane; or
		/// "Unconstrained", the point can move freely. If all points in the
		/// neighborhood surrounding a point are in the cone defined by FixedAngle,
		/// then the point is classified "Fixed." If all points in the neighborhood
		/// surrounding a point are in the cone defined by BoundaryAngle, then the
		/// point is classified "Plane." (The angles are expressed in degrees.)
		/// </summary>
		// Token: 0x0600CE56 RID: 52822 RVA: 0x0011F098 File Offset: 0x0011D298
		public virtual bool GetEnableConstraints()
		{
			return vtkPointSmoothingFilter.vtkPointSmoothingFilter_GetEnableConstraints_19(base.GetCppThis()) != 0;
		}

		// Token: 0x0600CE57 RID: 52823
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPointSmoothingFilter_GetFixedAngle_20(HandleRef pThis);

		/// <summary>
		/// Enable or disable constraints on points. Point constraints are used to
		/// prevent points from moving, or to move only on a plane. This can prevent
		/// shrinking or growing point clouds. If enabled, a local topological
		/// analysis is performed to determine whether a point should be marked
		/// "Fixed" i.e., never moves; "Plane", the point only moves on a plane; or
		/// "Unconstrained", the point can move freely. If all points in the
		/// neighborhood surrounding a point are in the cone defined by FixedAngle,
		/// then the point is classified "Fixed." If all points in the neighborhood
		/// surrounding a point are in the cone defined by BoundaryAngle, then the
		/// point is classified "Plane." (The angles are expressed in degrees.)
		/// </summary>
		// Token: 0x0600CE58 RID: 52824 RVA: 0x0011F0C0 File Offset: 0x0011D2C0
		public virtual double GetFixedAngle()
		{
			return vtkPointSmoothingFilter.vtkPointSmoothingFilter_GetFixedAngle_20(base.GetCppThis());
		}

		// Token: 0x0600CE59 RID: 52825
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPointSmoothingFilter_GetFixedAngleMaxValue_21(HandleRef pThis);

		/// <summary>
		/// Enable or disable constraints on points. Point constraints are used to
		/// prevent points from moving, or to move only on a plane. This can prevent
		/// shrinking or growing point clouds. If enabled, a local topological
		/// analysis is performed to determine whether a point should be marked
		/// "Fixed" i.e., never moves; "Plane", the point only moves on a plane; or
		/// "Unconstrained", the point can move freely. If all points in the
		/// neighborhood surrounding a point are in the cone defined by FixedAngle,
		/// then the point is classified "Fixed." If all points in the neighborhood
		/// surrounding a point are in the cone defined by BoundaryAngle, then the
		/// point is classified "Plane." (The angles are expressed in degrees.)
		/// </summary>
		// Token: 0x0600CE5A RID: 52826 RVA: 0x0011F0E0 File Offset: 0x0011D2E0
		public virtual double GetFixedAngleMaxValue()
		{
			return vtkPointSmoothingFilter.vtkPointSmoothingFilter_GetFixedAngleMaxValue_21(base.GetCppThis());
		}

		// Token: 0x0600CE5B RID: 52827
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPointSmoothingFilter_GetFixedAngleMinValue_22(HandleRef pThis);

		/// <summary>
		/// Enable or disable constraints on points. Point constraints are used to
		/// prevent points from moving, or to move only on a plane. This can prevent
		/// shrinking or growing point clouds. If enabled, a local topological
		/// analysis is performed to determine whether a point should be marked
		/// "Fixed" i.e., never moves; "Plane", the point only moves on a plane; or
		/// "Unconstrained", the point can move freely. If all points in the
		/// neighborhood surrounding a point are in the cone defined by FixedAngle,
		/// then the point is classified "Fixed." If all points in the neighborhood
		/// surrounding a point are in the cone defined by BoundaryAngle, then the
		/// point is classified "Plane." (The angles are expressed in degrees.)
		/// </summary>
		// Token: 0x0600CE5C RID: 52828 RVA: 0x0011F100 File Offset: 0x0011D300
		public virtual double GetFixedAngleMinValue()
		{
			return vtkPointSmoothingFilter.vtkPointSmoothingFilter_GetFixedAngleMinValue_22(base.GetCppThis());
		}

		// Token: 0x0600CE5D RID: 52829
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSmoothingFilter_GetFrameFieldArray_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the name of the frame field to use for smoothing. This
		/// information is only necessary if a frame field smoothing is enabled.
		/// </summary>
		// Token: 0x0600CE5E RID: 52830 RVA: 0x0011F120 File Offset: 0x0011D320
		public virtual vtkDataArray GetFrameFieldArray()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointSmoothingFilter.vtkPointSmoothingFilter_GetFrameFieldArray_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		// Token: 0x0600CE5F RID: 52831
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPointSmoothingFilter_GetGenerateConstraintNormals_24(HandleRef pThis);

		/// <summary>
		/// If point constraints are enabled, an output vector indicating the
		/// average normal at each point can be generated.
		/// </summary>
		// Token: 0x0600CE60 RID: 52832 RVA: 0x0011F190 File Offset: 0x0011D390
		public virtual bool GetGenerateConstraintNormals()
		{
			return vtkPointSmoothingFilter.vtkPointSmoothingFilter_GetGenerateConstraintNormals_24(base.GetCppThis()) != 0;
		}

		// Token: 0x0600CE61 RID: 52833
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPointSmoothingFilter_GetGenerateConstraintScalars_25(HandleRef pThis);

		/// <summary>
		/// If point constraints are enabled, an output scalar indicating the
		/// classification of points can be generated.
		/// </summary>
		// Token: 0x0600CE62 RID: 52834 RVA: 0x0011F1B8 File Offset: 0x0011D3B8
		public virtual bool GetGenerateConstraintScalars()
		{
			return vtkPointSmoothingFilter.vtkPointSmoothingFilter_GetGenerateConstraintScalars_25(base.GetCppThis()) != 0;
		}

		// Token: 0x0600CE63 RID: 52835
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSmoothingFilter_GetLocator_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify a point locator. By default a vtkStaticPointLocator is
		/// used. The locator performs efficient searches to locate points
		/// around a sample point.
		/// </summary>
		// Token: 0x0600CE64 RID: 52836 RVA: 0x0011F1E0 File Offset: 0x0011D3E0
		public virtual vtkAbstractPointLocator GetLocator()
		{
			vtkAbstractPointLocator vtkAbstractPointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointSmoothingFilter.vtkPointSmoothingFilter_GetLocator_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractPointLocator = (vtkAbstractPointLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractPointLocator.Register(null);
				}
			}
			return vtkAbstractPointLocator;
		}

		// Token: 0x0600CE65 RID: 52837
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPointSmoothingFilter_GetMaximumStepSize_27(HandleRef pThis);

		/// <summary>
		/// Specify the maximum smoothing step size for each smoothing iteration. This
		/// step size limits the the distance over which a point can move in each
		/// iteration.  As in all iterative methods, the stability of the process is
		/// sensitive to this parameter. In general, small step size and large
		/// numbers of iterations are more stable than a larger step size and a
		/// smaller numbers of iterations.
		/// </summary>
		// Token: 0x0600CE66 RID: 52838 RVA: 0x0011F250 File Offset: 0x0011D450
		public virtual double GetMaximumStepSize()
		{
			return vtkPointSmoothingFilter.vtkPointSmoothingFilter_GetMaximumStepSize_27(base.GetCppThis());
		}

		// Token: 0x0600CE67 RID: 52839
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPointSmoothingFilter_GetMaximumStepSizeMaxValue_28(HandleRef pThis);

		/// <summary>
		/// Specify the maximum smoothing step size for each smoothing iteration. This
		/// step size limits the the distance over which a point can move in each
		/// iteration.  As in all iterative methods, the stability of the process is
		/// sensitive to this parameter. In general, small step size and large
		/// numbers of iterations are more stable than a larger step size and a
		/// smaller numbers of iterations.
		/// </summary>
		// Token: 0x0600CE68 RID: 52840 RVA: 0x0011F270 File Offset: 0x0011D470
		public virtual double GetMaximumStepSizeMaxValue()
		{
			return vtkPointSmoothingFilter.vtkPointSmoothingFilter_GetMaximumStepSizeMaxValue_28(base.GetCppThis());
		}

		// Token: 0x0600CE69 RID: 52841
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPointSmoothingFilter_GetMaximumStepSizeMinValue_29(HandleRef pThis);

		/// <summary>
		/// Specify the maximum smoothing step size for each smoothing iteration. This
		/// step size limits the the distance over which a point can move in each
		/// iteration.  As in all iterative methods, the stability of the process is
		/// sensitive to this parameter. In general, small step size and large
		/// numbers of iterations are more stable than a larger step size and a
		/// smaller numbers of iterations.
		/// </summary>
		// Token: 0x0600CE6A RID: 52842 RVA: 0x0011F290 File Offset: 0x0011D490
		public virtual double GetMaximumStepSizeMinValue()
		{
			return vtkPointSmoothingFilter.vtkPointSmoothingFilter_GetMaximumStepSizeMinValue_29(base.GetCppThis());
		}

		// Token: 0x0600CE6B RID: 52843
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointSmoothingFilter_GetMotionConstraint_30(HandleRef pThis);

		/// <summary>
		/// Specify how to constrain the motion of points. By default, point motion is
		/// unconstrained. Points can also be constrained to a plane. If constrained to
		/// a plane, then an instance of vtkPlane must be specified.
		/// </summary>
		// Token: 0x0600CE6C RID: 52844 RVA: 0x0011F2B0 File Offset: 0x0011D4B0
		public virtual int GetMotionConstraint()
		{
			return vtkPointSmoothingFilter.vtkPointSmoothingFilter_GetMotionConstraint_30(base.GetCppThis());
		}

		// Token: 0x0600CE6D RID: 52845
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointSmoothingFilter_GetNeighborhoodSize_31(HandleRef pThis);

		/// <summary>
		/// Specify the neighborhood size. This controls the number of surrounding
		/// points that can affect a point to be smoothed.
		/// </summary>
		// Token: 0x0600CE6E RID: 52846 RVA: 0x0011F2D0 File Offset: 0x0011D4D0
		public virtual int GetNeighborhoodSize()
		{
			return vtkPointSmoothingFilter.vtkPointSmoothingFilter_GetNeighborhoodSize_31(base.GetCppThis());
		}

		// Token: 0x0600CE6F RID: 52847
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointSmoothingFilter_GetNeighborhoodSizeMaxValue_32(HandleRef pThis);

		/// <summary>
		/// Specify the neighborhood size. This controls the number of surrounding
		/// points that can affect a point to be smoothed.
		/// </summary>
		// Token: 0x0600CE70 RID: 52848 RVA: 0x0011F2F0 File Offset: 0x0011D4F0
		public virtual int GetNeighborhoodSizeMaxValue()
		{
			return vtkPointSmoothingFilter.vtkPointSmoothingFilter_GetNeighborhoodSizeMaxValue_32(base.GetCppThis());
		}

		// Token: 0x0600CE71 RID: 52849
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointSmoothingFilter_GetNeighborhoodSizeMinValue_33(HandleRef pThis);

		/// <summary>
		/// Specify the neighborhood size. This controls the number of surrounding
		/// points that can affect a point to be smoothed.
		/// </summary>
		// Token: 0x0600CE72 RID: 52850 RVA: 0x0011F310 File Offset: 0x0011D510
		public virtual int GetNeighborhoodSizeMinValue()
		{
			return vtkPointSmoothingFilter.vtkPointSmoothingFilter_GetNeighborhoodSizeMinValue_33(base.GetCppThis());
		}

		// Token: 0x0600CE73 RID: 52851
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointSmoothingFilter_GetNumberOfGenerationsFromBase_34(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CE74 RID: 52852 RVA: 0x0011F330 File Offset: 0x0011D530
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPointSmoothingFilter.vtkPointSmoothingFilter_GetNumberOfGenerationsFromBase_34(base.GetCppThis(), type);
		}

		// Token: 0x0600CE75 RID: 52853
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointSmoothingFilter_GetNumberOfGenerationsFromBaseType_35([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CE76 RID: 52854 RVA: 0x0011F350 File Offset: 0x0011D550
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPointSmoothingFilter.vtkPointSmoothingFilter_GetNumberOfGenerationsFromBaseType_35(type);
		}

		// Token: 0x0600CE77 RID: 52855
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointSmoothingFilter_GetNumberOfIterations_36(HandleRef pThis);

		/// <summary>
		/// Specify the number of smoothing iterations.
		/// </summary>
		// Token: 0x0600CE78 RID: 52856 RVA: 0x0011F36C File Offset: 0x0011D56C
		public virtual int GetNumberOfIterations()
		{
			return vtkPointSmoothingFilter.vtkPointSmoothingFilter_GetNumberOfIterations_36(base.GetCppThis());
		}

		// Token: 0x0600CE79 RID: 52857
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointSmoothingFilter_GetNumberOfIterationsMaxValue_37(HandleRef pThis);

		/// <summary>
		/// Specify the number of smoothing iterations.
		/// </summary>
		// Token: 0x0600CE7A RID: 52858 RVA: 0x0011F38C File Offset: 0x0011D58C
		public virtual int GetNumberOfIterationsMaxValue()
		{
			return vtkPointSmoothingFilter.vtkPointSmoothingFilter_GetNumberOfIterationsMaxValue_37(base.GetCppThis());
		}

		// Token: 0x0600CE7B RID: 52859
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointSmoothingFilter_GetNumberOfIterationsMinValue_38(HandleRef pThis);

		/// <summary>
		/// Specify the number of smoothing iterations.
		/// </summary>
		// Token: 0x0600CE7C RID: 52860 RVA: 0x0011F3AC File Offset: 0x0011D5AC
		public virtual int GetNumberOfIterationsMinValue()
		{
			return vtkPointSmoothingFilter.vtkPointSmoothingFilter_GetNumberOfIterationsMinValue_38(base.GetCppThis());
		}

		// Token: 0x0600CE7D RID: 52861
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointSmoothingFilter_GetNumberOfSubIterations_39(HandleRef pThis);

		/// <summary>
		/// Specify the number of smoothing subiterations. This specifies the
		/// frequency of connectivity and data attribute updates.
		/// </summary>
		// Token: 0x0600CE7E RID: 52862 RVA: 0x0011F3CC File Offset: 0x0011D5CC
		public virtual int GetNumberOfSubIterations()
		{
			return vtkPointSmoothingFilter.vtkPointSmoothingFilter_GetNumberOfSubIterations_39(base.GetCppThis());
		}

		// Token: 0x0600CE7F RID: 52863
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointSmoothingFilter_GetNumberOfSubIterationsMaxValue_40(HandleRef pThis);

		/// <summary>
		/// Specify the number of smoothing subiterations. This specifies the
		/// frequency of connectivity and data attribute updates.
		/// </summary>
		// Token: 0x0600CE80 RID: 52864 RVA: 0x0011F3EC File Offset: 0x0011D5EC
		public virtual int GetNumberOfSubIterationsMaxValue()
		{
			return vtkPointSmoothingFilter.vtkPointSmoothingFilter_GetNumberOfSubIterationsMaxValue_40(base.GetCppThis());
		}

		// Token: 0x0600CE81 RID: 52865
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointSmoothingFilter_GetNumberOfSubIterationsMinValue_41(HandleRef pThis);

		/// <summary>
		/// Specify the number of smoothing subiterations. This specifies the
		/// frequency of connectivity and data attribute updates.
		/// </summary>
		// Token: 0x0600CE82 RID: 52866 RVA: 0x0011F40C File Offset: 0x0011D60C
		public virtual int GetNumberOfSubIterationsMinValue()
		{
			return vtkPointSmoothingFilter.vtkPointSmoothingFilter_GetNumberOfSubIterationsMinValue_41(base.GetCppThis());
		}

		// Token: 0x0600CE83 RID: 52867
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPointSmoothingFilter_GetPackingFactor_42(HandleRef pThis);

		/// <summary>
		/// Specify the packing factor. Larger numbers tend to loosen the overall
		/// packing of points. Note however that if the point density in a region is
		/// high, then the packing factor may have little effect (due to mutual
		/// inter-particle constraints). The default value is 1.0. (Note that a
		/// characteristic inter-particle radius R is computed at the onset of the
		/// algorithm (or can be manually specified). Within 0&lt;=r&lt;=R*PackingFactor a
		/// repulsive force is generated.)
		/// </summary>
		// Token: 0x0600CE84 RID: 52868 RVA: 0x0011F42C File Offset: 0x0011D62C
		public virtual double GetPackingFactor()
		{
			return vtkPointSmoothingFilter.vtkPointSmoothingFilter_GetPackingFactor_42(base.GetCppThis());
		}

		// Token: 0x0600CE85 RID: 52869
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPointSmoothingFilter_GetPackingFactorMaxValue_43(HandleRef pThis);

		/// <summary>
		/// Specify the packing factor. Larger numbers tend to loosen the overall
		/// packing of points. Note however that if the point density in a region is
		/// high, then the packing factor may have little effect (due to mutual
		/// inter-particle constraints). The default value is 1.0. (Note that a
		/// characteristic inter-particle radius R is computed at the onset of the
		/// algorithm (or can be manually specified). Within 0&lt;=r&lt;=R*PackingFactor a
		/// repulsive force is generated.)
		/// </summary>
		// Token: 0x0600CE86 RID: 52870 RVA: 0x0011F44C File Offset: 0x0011D64C
		public virtual double GetPackingFactorMaxValue()
		{
			return vtkPointSmoothingFilter.vtkPointSmoothingFilter_GetPackingFactorMaxValue_43(base.GetCppThis());
		}

		// Token: 0x0600CE87 RID: 52871
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPointSmoothingFilter_GetPackingFactorMinValue_44(HandleRef pThis);

		/// <summary>
		/// Specify the packing factor. Larger numbers tend to loosen the overall
		/// packing of points. Note however that if the point density in a region is
		/// high, then the packing factor may have little effect (due to mutual
		/// inter-particle constraints). The default value is 1.0. (Note that a
		/// characteristic inter-particle radius R is computed at the onset of the
		/// algorithm (or can be manually specified). Within 0&lt;=r&lt;=R*PackingFactor a
		/// repulsive force is generated.)
		/// </summary>
		// Token: 0x0600CE88 RID: 52872 RVA: 0x0011F46C File Offset: 0x0011D66C
		public virtual double GetPackingFactorMinValue()
		{
			return vtkPointSmoothingFilter.vtkPointSmoothingFilter_GetPackingFactorMinValue_44(base.GetCppThis());
		}

		// Token: 0x0600CE89 RID: 52873
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPointSmoothingFilter_GetPackingRadius_45(HandleRef pThis);

		/// <summary>
		/// Specify the packing radius R. This only takes effect if
		/// ComputePackingRadius is off. Note that the for two points separated by
		/// radius r, a repulsive force is generated when 0&lt;=r&lt;=R, and a repulsive
		/// force when R&lt;=r&lt;=(1+AttractionFactor*R). By default, the PackingRadius
		/// is automatically computed, but when ComputePackingRadius is off, then
		/// manually setting the PackingRadius is allowed. Note that the
		/// PackingRadius is updated after the algorithm runs (useful to examine the
		/// computed packing radius).
		/// </summary>
		// Token: 0x0600CE8A RID: 52874 RVA: 0x0011F48C File Offset: 0x0011D68C
		public virtual double GetPackingRadius()
		{
			return vtkPointSmoothingFilter.vtkPointSmoothingFilter_GetPackingRadius_45(base.GetCppThis());
		}

		// Token: 0x0600CE8B RID: 52875
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPointSmoothingFilter_GetPackingRadiusMaxValue_46(HandleRef pThis);

		/// <summary>
		/// Specify the packing radius R. This only takes effect if
		/// ComputePackingRadius is off. Note that the for two points separated by
		/// radius r, a repulsive force is generated when 0&lt;=r&lt;=R, and a repulsive
		/// force when R&lt;=r&lt;=(1+AttractionFactor*R). By default, the PackingRadius
		/// is automatically computed, but when ComputePackingRadius is off, then
		/// manually setting the PackingRadius is allowed. Note that the
		/// PackingRadius is updated after the algorithm runs (useful to examine the
		/// computed packing radius).
		/// </summary>
		// Token: 0x0600CE8C RID: 52876 RVA: 0x0011F4AC File Offset: 0x0011D6AC
		public virtual double GetPackingRadiusMaxValue()
		{
			return vtkPointSmoothingFilter.vtkPointSmoothingFilter_GetPackingRadiusMaxValue_46(base.GetCppThis());
		}

		// Token: 0x0600CE8D RID: 52877
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPointSmoothingFilter_GetPackingRadiusMinValue_47(HandleRef pThis);

		/// <summary>
		/// Specify the packing radius R. This only takes effect if
		/// ComputePackingRadius is off. Note that the for two points separated by
		/// radius r, a repulsive force is generated when 0&lt;=r&lt;=R, and a repulsive
		/// force when R&lt;=r&lt;=(1+AttractionFactor*R). By default, the PackingRadius
		/// is automatically computed, but when ComputePackingRadius is off, then
		/// manually setting the PackingRadius is allowed. Note that the
		/// PackingRadius is updated after the algorithm runs (useful to examine the
		/// computed packing radius).
		/// </summary>
		// Token: 0x0600CE8E RID: 52878 RVA: 0x0011F4CC File Offset: 0x0011D6CC
		public virtual double GetPackingRadiusMinValue()
		{
			return vtkPointSmoothingFilter.vtkPointSmoothingFilter_GetPackingRadiusMinValue_47(base.GetCppThis());
		}

		// Token: 0x0600CE8F RID: 52879
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSmoothingFilter_GetPlane_48(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the plane to which point motion is constrained. Only required if
		/// MotionConstraint is set to UNCONSTRAINED_MOTION.
		/// </summary>
		// Token: 0x0600CE90 RID: 52880 RVA: 0x0011F4EC File Offset: 0x0011D6EC
		public virtual vtkPlane GetPlane()
		{
			vtkPlane vtkPlane = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointSmoothingFilter.vtkPointSmoothingFilter_GetPlane_48(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600CE91 RID: 52881
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointSmoothingFilter_GetSmoothingMode_49(HandleRef pThis);

		/// <summary>
		/// Control how smoothing is to be performed. By default, if a point frame
		/// field is available then frame field smoothing will be performed; then if
		/// point tensors are available then anisotropic tensor smoothing will be
		/// used; the next choice is to use isotropic scalar smoothing; and finally
		/// if no frame field, tensors, or scalars are available, uniform smoothing
		/// will be used. If both scalars, tensors, and /or a frame field are
		/// present, the user can specify which to use; or to use uniform or
		/// geometric smoothing.
		/// </summary>
		// Token: 0x0600CE92 RID: 52882 RVA: 0x0011F55C File Offset: 0x0011D75C
		public virtual int GetSmoothingMode()
		{
			return vtkPointSmoothingFilter.vtkPointSmoothingFilter_GetSmoothingMode_49(base.GetCppThis());
		}

		// Token: 0x0600CE93 RID: 52883
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointSmoothingFilter_GetSmoothingModeMaxValue_50(HandleRef pThis);

		/// <summary>
		/// Control how smoothing is to be performed. By default, if a point frame
		/// field is available then frame field smoothing will be performed; then if
		/// point tensors are available then anisotropic tensor smoothing will be
		/// used; the next choice is to use isotropic scalar smoothing; and finally
		/// if no frame field, tensors, or scalars are available, uniform smoothing
		/// will be used. If both scalars, tensors, and /or a frame field are
		/// present, the user can specify which to use; or to use uniform or
		/// geometric smoothing.
		/// </summary>
		// Token: 0x0600CE94 RID: 52884 RVA: 0x0011F57C File Offset: 0x0011D77C
		public virtual int GetSmoothingModeMaxValue()
		{
			return vtkPointSmoothingFilter.vtkPointSmoothingFilter_GetSmoothingModeMaxValue_50(base.GetCppThis());
		}

		// Token: 0x0600CE95 RID: 52885
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointSmoothingFilter_GetSmoothingModeMinValue_51(HandleRef pThis);

		/// <summary>
		/// Control how smoothing is to be performed. By default, if a point frame
		/// field is available then frame field smoothing will be performed; then if
		/// point tensors are available then anisotropic tensor smoothing will be
		/// used; the next choice is to use isotropic scalar smoothing; and finally
		/// if no frame field, tensors, or scalars are available, uniform smoothing
		/// will be used. If both scalars, tensors, and /or a frame field are
		/// present, the user can specify which to use; or to use uniform or
		/// geometric smoothing.
		/// </summary>
		// Token: 0x0600CE96 RID: 52886 RVA: 0x0011F59C File Offset: 0x0011D79C
		public virtual int GetSmoothingModeMinValue()
		{
			return vtkPointSmoothingFilter.vtkPointSmoothingFilter_GetSmoothingModeMinValue_51(base.GetCppThis());
		}

		// Token: 0x0600CE97 RID: 52887
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointSmoothingFilter_IsA_52(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CE98 RID: 52888 RVA: 0x0011F5BC File Offset: 0x0011D7BC
		public override int IsA(string type)
		{
			return vtkPointSmoothingFilter.vtkPointSmoothingFilter_IsA_52(base.GetCppThis(), type);
		}

		// Token: 0x0600CE99 RID: 52889
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointSmoothingFilter_IsTypeOf_53([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CE9A RID: 52890 RVA: 0x0011F5DC File Offset: 0x0011D7DC
		public new static int IsTypeOf(string type)
		{
			return vtkPointSmoothingFilter.vtkPointSmoothingFilter_IsTypeOf_53(type);
		}

		// Token: 0x0600CE9B RID: 52891
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSmoothingFilter_NewInstance_55(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CE9C RID: 52892 RVA: 0x0011F5F8 File Offset: 0x0011D7F8
		public new vtkPointSmoothingFilter NewInstance()
		{
			vtkPointSmoothingFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointSmoothingFilter.vtkPointSmoothingFilter_NewInstance_55(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointSmoothingFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600CE9D RID: 52893
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSmoothingFilter_SafeDownCast_56(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CE9E RID: 52894 RVA: 0x0011F654 File Offset: 0x0011D854
		public new static vtkPointSmoothingFilter SafeDownCast(vtkObjectBase o)
		{
			vtkPointSmoothingFilter vtkPointSmoothingFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointSmoothingFilter.vtkPointSmoothingFilter_SafeDownCast_56((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointSmoothingFilter = (vtkPointSmoothingFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointSmoothingFilter.Register(null);
				}
			}
			return vtkPointSmoothingFilter;
		}

		// Token: 0x0600CE9F RID: 52895
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSmoothingFilter_SetAttractionFactor_57(HandleRef pThis, double _arg);

		/// <summary>
		/// Control the relative distance of inter-particle attraction. A value of
		/// 1.0 means that the radius of the attraction region is the same as the
		/// radius of repulsion. By default, a value of 0.5 is used (e.g., in the
		/// region 0&lt;=r&lt;=R a repulsive force is generated, while in R&lt;r&lt;=R*1.5 an
		/// attractive force is generated).
		/// </summary>
		// Token: 0x0600CEA0 RID: 52896 RVA: 0x0011F6D3 File Offset: 0x0011D8D3
		public virtual void SetAttractionFactor(double _arg)
		{
			vtkPointSmoothingFilter.vtkPointSmoothingFilter_SetAttractionFactor_57(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CEA1 RID: 52897
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSmoothingFilter_SetBoundaryAngle_58(HandleRef pThis, double _arg);

		/// <summary>
		/// Enable or disable constraints on points. Point constraints are used to
		/// prevent points from moving, or to move only on a plane. This can prevent
		/// shrinking or growing point clouds. If enabled, a local topological
		/// analysis is performed to determine whether a point should be marked
		/// "Fixed" i.e., never moves; "Plane", the point only moves on a plane; or
		/// "Unconstrained", the point can move freely. If all points in the
		/// neighborhood surrounding a point are in the cone defined by FixedAngle,
		/// then the point is classified "Fixed." If all points in the neighborhood
		/// surrounding a point are in the cone defined by BoundaryAngle, then the
		/// point is classified "Plane." (The angles are expressed in degrees.)
		/// </summary>
		// Token: 0x0600CEA2 RID: 52898 RVA: 0x0011F6E3 File Offset: 0x0011D8E3
		public virtual void SetBoundaryAngle(double _arg)
		{
			vtkPointSmoothingFilter.vtkPointSmoothingFilter_SetBoundaryAngle_58(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CEA3 RID: 52899
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSmoothingFilter_SetComputePackingRadius_59(HandleRef pThis, byte _arg);

		/// <summary>
		/// Enable / disable the computation of a packing radius. By default,
		/// a packing radius is computed as one half of the average distance
		/// between neighboring points. (Point neighbors are defined by the
		/// neighborhood size.)
		/// </summary>
		// Token: 0x0600CEA4 RID: 52900 RVA: 0x0011F6F3 File Offset: 0x0011D8F3
		public virtual void SetComputePackingRadius(bool _arg)
		{
			vtkPointSmoothingFilter.vtkPointSmoothingFilter_SetComputePackingRadius_59(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600CEA5 RID: 52901
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSmoothingFilter_SetConvergence_60(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify a convergence criterion for the iteration
		/// process. Smaller numbers result in more smoothing iterations.
		/// </summary>
		// Token: 0x0600CEA6 RID: 52902 RVA: 0x0011F70B File Offset: 0x0011D90B
		public virtual void SetConvergence(double _arg)
		{
			vtkPointSmoothingFilter.vtkPointSmoothingFilter_SetConvergence_60(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CEA7 RID: 52903
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSmoothingFilter_SetEnableConstraints_61(HandleRef pThis, byte _arg);

		/// <summary>
		/// Enable or disable constraints on points. Point constraints are used to
		/// prevent points from moving, or to move only on a plane. This can prevent
		/// shrinking or growing point clouds. If enabled, a local topological
		/// analysis is performed to determine whether a point should be marked
		/// "Fixed" i.e., never moves; "Plane", the point only moves on a plane; or
		/// "Unconstrained", the point can move freely. If all points in the
		/// neighborhood surrounding a point are in the cone defined by FixedAngle,
		/// then the point is classified "Fixed." If all points in the neighborhood
		/// surrounding a point are in the cone defined by BoundaryAngle, then the
		/// point is classified "Plane." (The angles are expressed in degrees.)
		/// </summary>
		// Token: 0x0600CEA8 RID: 52904 RVA: 0x0011F71B File Offset: 0x0011D91B
		public virtual void SetEnableConstraints(bool _arg)
		{
			vtkPointSmoothingFilter.vtkPointSmoothingFilter_SetEnableConstraints_61(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600CEA9 RID: 52905
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSmoothingFilter_SetFixedAngle_62(HandleRef pThis, double _arg);

		/// <summary>
		/// Enable or disable constraints on points. Point constraints are used to
		/// prevent points from moving, or to move only on a plane. This can prevent
		/// shrinking or growing point clouds. If enabled, a local topological
		/// analysis is performed to determine whether a point should be marked
		/// "Fixed" i.e., never moves; "Plane", the point only moves on a plane; or
		/// "Unconstrained", the point can move freely. If all points in the
		/// neighborhood surrounding a point are in the cone defined by FixedAngle,
		/// then the point is classified "Fixed." If all points in the neighborhood
		/// surrounding a point are in the cone defined by BoundaryAngle, then the
		/// point is classified "Plane." (The angles are expressed in degrees.)
		/// </summary>
		// Token: 0x0600CEAA RID: 52906 RVA: 0x0011F733 File Offset: 0x0011D933
		public virtual void SetFixedAngle(double _arg)
		{
			vtkPointSmoothingFilter.vtkPointSmoothingFilter_SetFixedAngle_62(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CEAB RID: 52907
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSmoothingFilter_SetFrameFieldArray_63(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the name of the frame field to use for smoothing. This
		/// information is only necessary if a frame field smoothing is enabled.
		/// </summary>
		// Token: 0x0600CEAC RID: 52908 RVA: 0x0011F744 File Offset: 0x0011D944
		public virtual void SetFrameFieldArray(vtkDataArray arg0)
		{
			vtkPointSmoothingFilter.vtkPointSmoothingFilter_SetFrameFieldArray_63(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600CEAD RID: 52909
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSmoothingFilter_SetGenerateConstraintNormals_64(HandleRef pThis, byte _arg);

		/// <summary>
		/// If point constraints are enabled, an output vector indicating the
		/// average normal at each point can be generated.
		/// </summary>
		// Token: 0x0600CEAE RID: 52910 RVA: 0x0011F773 File Offset: 0x0011D973
		public virtual void SetGenerateConstraintNormals(bool _arg)
		{
			vtkPointSmoothingFilter.vtkPointSmoothingFilter_SetGenerateConstraintNormals_64(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600CEAF RID: 52911
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSmoothingFilter_SetGenerateConstraintScalars_65(HandleRef pThis, byte _arg);

		/// <summary>
		/// If point constraints are enabled, an output scalar indicating the
		/// classification of points can be generated.
		/// </summary>
		// Token: 0x0600CEB0 RID: 52912 RVA: 0x0011F78B File Offset: 0x0011D98B
		public virtual void SetGenerateConstraintScalars(bool _arg)
		{
			vtkPointSmoothingFilter.vtkPointSmoothingFilter_SetGenerateConstraintScalars_65(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600CEB1 RID: 52913
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSmoothingFilter_SetLocator_66(HandleRef pThis, HandleRef locator);

		/// <summary>
		/// Specify a point locator. By default a vtkStaticPointLocator is
		/// used. The locator performs efficient searches to locate points
		/// around a sample point.
		/// </summary>
		// Token: 0x0600CEB2 RID: 52914 RVA: 0x0011F7A4 File Offset: 0x0011D9A4
		public void SetLocator(vtkAbstractPointLocator locator)
		{
			vtkPointSmoothingFilter.vtkPointSmoothingFilter_SetLocator_66(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		// Token: 0x0600CEB3 RID: 52915
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSmoothingFilter_SetMaximumStepSize_67(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the maximum smoothing step size for each smoothing iteration. This
		/// step size limits the the distance over which a point can move in each
		/// iteration.  As in all iterative methods, the stability of the process is
		/// sensitive to this parameter. In general, small step size and large
		/// numbers of iterations are more stable than a larger step size and a
		/// smaller numbers of iterations.
		/// </summary>
		// Token: 0x0600CEB4 RID: 52916 RVA: 0x0011F7D3 File Offset: 0x0011D9D3
		public virtual void SetMaximumStepSize(double _arg)
		{
			vtkPointSmoothingFilter.vtkPointSmoothingFilter_SetMaximumStepSize_67(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CEB5 RID: 52917
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSmoothingFilter_SetMotionConstraint_68(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify how to constrain the motion of points. By default, point motion is
		/// unconstrained. Points can also be constrained to a plane. If constrained to
		/// a plane, then an instance of vtkPlane must be specified.
		/// </summary>
		// Token: 0x0600CEB6 RID: 52918 RVA: 0x0011F7E3 File Offset: 0x0011D9E3
		public virtual void SetMotionConstraint(int _arg)
		{
			vtkPointSmoothingFilter.vtkPointSmoothingFilter_SetMotionConstraint_68(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CEB7 RID: 52919
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSmoothingFilter_SetMotionConstraintToPlane_69(HandleRef pThis);

		/// <summary>
		/// Specify how to constrain the motion of points. By default, point motion is
		/// unconstrained. Points can also be constrained to a plane. If constrained to
		/// a plane, then an instance of vtkPlane must be specified.
		/// </summary>
		// Token: 0x0600CEB8 RID: 52920 RVA: 0x0011F7F3 File Offset: 0x0011D9F3
		public void SetMotionConstraintToPlane()
		{
			vtkPointSmoothingFilter.vtkPointSmoothingFilter_SetMotionConstraintToPlane_69(base.GetCppThis());
		}

		// Token: 0x0600CEB9 RID: 52921
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSmoothingFilter_SetMotionConstraintToUnconstrained_70(HandleRef pThis);

		/// <summary>
		/// Specify how to constrain the motion of points. By default, point motion is
		/// unconstrained. Points can also be constrained to a plane. If constrained to
		/// a plane, then an instance of vtkPlane must be specified.
		/// </summary>
		// Token: 0x0600CEBA RID: 52922 RVA: 0x0011F802 File Offset: 0x0011DA02
		public void SetMotionConstraintToUnconstrained()
		{
			vtkPointSmoothingFilter.vtkPointSmoothingFilter_SetMotionConstraintToUnconstrained_70(base.GetCppThis());
		}

		// Token: 0x0600CEBB RID: 52923
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSmoothingFilter_SetNeighborhoodSize_71(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the neighborhood size. This controls the number of surrounding
		/// points that can affect a point to be smoothed.
		/// </summary>
		// Token: 0x0600CEBC RID: 52924 RVA: 0x0011F811 File Offset: 0x0011DA11
		public virtual void SetNeighborhoodSize(int _arg)
		{
			vtkPointSmoothingFilter.vtkPointSmoothingFilter_SetNeighborhoodSize_71(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CEBD RID: 52925
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSmoothingFilter_SetNumberOfIterations_72(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the number of smoothing iterations.
		/// </summary>
		// Token: 0x0600CEBE RID: 52926 RVA: 0x0011F821 File Offset: 0x0011DA21
		public virtual void SetNumberOfIterations(int _arg)
		{
			vtkPointSmoothingFilter.vtkPointSmoothingFilter_SetNumberOfIterations_72(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CEBF RID: 52927
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSmoothingFilter_SetNumberOfSubIterations_73(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the number of smoothing subiterations. This specifies the
		/// frequency of connectivity and data attribute updates.
		/// </summary>
		// Token: 0x0600CEC0 RID: 52928 RVA: 0x0011F831 File Offset: 0x0011DA31
		public virtual void SetNumberOfSubIterations(int _arg)
		{
			vtkPointSmoothingFilter.vtkPointSmoothingFilter_SetNumberOfSubIterations_73(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CEC1 RID: 52929
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSmoothingFilter_SetPackingFactor_74(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the packing factor. Larger numbers tend to loosen the overall
		/// packing of points. Note however that if the point density in a region is
		/// high, then the packing factor may have little effect (due to mutual
		/// inter-particle constraints). The default value is 1.0. (Note that a
		/// characteristic inter-particle radius R is computed at the onset of the
		/// algorithm (or can be manually specified). Within 0&lt;=r&lt;=R*PackingFactor a
		/// repulsive force is generated.)
		/// </summary>
		// Token: 0x0600CEC2 RID: 52930 RVA: 0x0011F841 File Offset: 0x0011DA41
		public virtual void SetPackingFactor(double _arg)
		{
			vtkPointSmoothingFilter.vtkPointSmoothingFilter_SetPackingFactor_74(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CEC3 RID: 52931
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSmoothingFilter_SetPackingRadius_75(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the packing radius R. This only takes effect if
		/// ComputePackingRadius is off. Note that the for two points separated by
		/// radius r, a repulsive force is generated when 0&lt;=r&lt;=R, and a repulsive
		/// force when R&lt;=r&lt;=(1+AttractionFactor*R). By default, the PackingRadius
		/// is automatically computed, but when ComputePackingRadius is off, then
		/// manually setting the PackingRadius is allowed. Note that the
		/// PackingRadius is updated after the algorithm runs (useful to examine the
		/// computed packing radius).
		/// </summary>
		// Token: 0x0600CEC4 RID: 52932 RVA: 0x0011F851 File Offset: 0x0011DA51
		public virtual void SetPackingRadius(double _arg)
		{
			vtkPointSmoothingFilter.vtkPointSmoothingFilter_SetPackingRadius_75(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CEC5 RID: 52933
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSmoothingFilter_SetPlane_76(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the plane to which point motion is constrained. Only required if
		/// MotionConstraint is set to UNCONSTRAINED_MOTION.
		/// </summary>
		// Token: 0x0600CEC6 RID: 52934 RVA: 0x0011F864 File Offset: 0x0011DA64
		public void SetPlane(vtkPlane arg0)
		{
			vtkPointSmoothingFilter.vtkPointSmoothingFilter_SetPlane_76(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600CEC7 RID: 52935
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSmoothingFilter_SetSmoothingMode_77(HandleRef pThis, int _arg);

		/// <summary>
		/// Control how smoothing is to be performed. By default, if a point frame
		/// field is available then frame field smoothing will be performed; then if
		/// point tensors are available then anisotropic tensor smoothing will be
		/// used; the next choice is to use isotropic scalar smoothing; and finally
		/// if no frame field, tensors, or scalars are available, uniform smoothing
		/// will be used. If both scalars, tensors, and /or a frame field are
		/// present, the user can specify which to use; or to use uniform or
		/// geometric smoothing.
		/// </summary>
		// Token: 0x0600CEC8 RID: 52936 RVA: 0x0011F893 File Offset: 0x0011DA93
		public virtual void SetSmoothingMode(int _arg)
		{
			vtkPointSmoothingFilter.vtkPointSmoothingFilter_SetSmoothingMode_77(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CEC9 RID: 52937
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSmoothingFilter_SetSmoothingModeToDefault_78(HandleRef pThis);

		/// <summary>
		/// Control how smoothing is to be performed. By default, if a point frame
		/// field is available then frame field smoothing will be performed; then if
		/// point tensors are available then anisotropic tensor smoothing will be
		/// used; the next choice is to use isotropic scalar smoothing; and finally
		/// if no frame field, tensors, or scalars are available, uniform smoothing
		/// will be used. If both scalars, tensors, and /or a frame field are
		/// present, the user can specify which to use; or to use uniform or
		/// geometric smoothing.
		/// </summary>
		// Token: 0x0600CECA RID: 52938 RVA: 0x0011F8A3 File Offset: 0x0011DAA3
		public void SetSmoothingModeToDefault()
		{
			vtkPointSmoothingFilter.vtkPointSmoothingFilter_SetSmoothingModeToDefault_78(base.GetCppThis());
		}

		// Token: 0x0600CECB RID: 52939
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSmoothingFilter_SetSmoothingModeToFrameField_79(HandleRef pThis);

		/// <summary>
		/// Control how smoothing is to be performed. By default, if a point frame
		/// field is available then frame field smoothing will be performed; then if
		/// point tensors are available then anisotropic tensor smoothing will be
		/// used; the next choice is to use isotropic scalar smoothing; and finally
		/// if no frame field, tensors, or scalars are available, uniform smoothing
		/// will be used. If both scalars, tensors, and /or a frame field are
		/// present, the user can specify which to use; or to use uniform or
		/// geometric smoothing.
		/// </summary>
		// Token: 0x0600CECC RID: 52940 RVA: 0x0011F8B2 File Offset: 0x0011DAB2
		public void SetSmoothingModeToFrameField()
		{
			vtkPointSmoothingFilter.vtkPointSmoothingFilter_SetSmoothingModeToFrameField_79(base.GetCppThis());
		}

		// Token: 0x0600CECD RID: 52941
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSmoothingFilter_SetSmoothingModeToGeometric_80(HandleRef pThis);

		/// <summary>
		/// Control how smoothing is to be performed. By default, if a point frame
		/// field is available then frame field smoothing will be performed; then if
		/// point tensors are available then anisotropic tensor smoothing will be
		/// used; the next choice is to use isotropic scalar smoothing; and finally
		/// if no frame field, tensors, or scalars are available, uniform smoothing
		/// will be used. If both scalars, tensors, and /or a frame field are
		/// present, the user can specify which to use; or to use uniform or
		/// geometric smoothing.
		/// </summary>
		// Token: 0x0600CECE RID: 52942 RVA: 0x0011F8C1 File Offset: 0x0011DAC1
		public void SetSmoothingModeToGeometric()
		{
			vtkPointSmoothingFilter.vtkPointSmoothingFilter_SetSmoothingModeToGeometric_80(base.GetCppThis());
		}

		// Token: 0x0600CECF RID: 52943
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSmoothingFilter_SetSmoothingModeToScalars_81(HandleRef pThis);

		/// <summary>
		/// Control how smoothing is to be performed. By default, if a point frame
		/// field is available then frame field smoothing will be performed; then if
		/// point tensors are available then anisotropic tensor smoothing will be
		/// used; the next choice is to use isotropic scalar smoothing; and finally
		/// if no frame field, tensors, or scalars are available, uniform smoothing
		/// will be used. If both scalars, tensors, and /or a frame field are
		/// present, the user can specify which to use; or to use uniform or
		/// geometric smoothing.
		/// </summary>
		// Token: 0x0600CED0 RID: 52944 RVA: 0x0011F8D0 File Offset: 0x0011DAD0
		public void SetSmoothingModeToScalars()
		{
			vtkPointSmoothingFilter.vtkPointSmoothingFilter_SetSmoothingModeToScalars_81(base.GetCppThis());
		}

		// Token: 0x0600CED1 RID: 52945
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSmoothingFilter_SetSmoothingModeToTensors_82(HandleRef pThis);

		/// <summary>
		/// Control how smoothing is to be performed. By default, if a point frame
		/// field is available then frame field smoothing will be performed; then if
		/// point tensors are available then anisotropic tensor smoothing will be
		/// used; the next choice is to use isotropic scalar smoothing; and finally
		/// if no frame field, tensors, or scalars are available, uniform smoothing
		/// will be used. If both scalars, tensors, and /or a frame field are
		/// present, the user can specify which to use; or to use uniform or
		/// geometric smoothing.
		/// </summary>
		// Token: 0x0600CED2 RID: 52946 RVA: 0x0011F8DF File Offset: 0x0011DADF
		public void SetSmoothingModeToTensors()
		{
			vtkPointSmoothingFilter.vtkPointSmoothingFilter_SetSmoothingModeToTensors_82(base.GetCppThis());
		}

		// Token: 0x0600CED3 RID: 52947
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSmoothingFilter_SetSmoothingModeToUniform_83(HandleRef pThis);

		/// <summary>
		/// Control how smoothing is to be performed. By default, if a point frame
		/// field is available then frame field smoothing will be performed; then if
		/// point tensors are available then anisotropic tensor smoothing will be
		/// used; the next choice is to use isotropic scalar smoothing; and finally
		/// if no frame field, tensors, or scalars are available, uniform smoothing
		/// will be used. If both scalars, tensors, and /or a frame field are
		/// present, the user can specify which to use; or to use uniform or
		/// geometric smoothing.
		/// </summary>
		// Token: 0x0600CED4 RID: 52948 RVA: 0x0011F8EE File Offset: 0x0011DAEE
		public void SetSmoothingModeToUniform()
		{
			vtkPointSmoothingFilter.vtkPointSmoothingFilter_SetSmoothingModeToUniform_83(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F3B RID: 3899
		public new const string MRFullTypeName = "Kitware.VTK.vtkPointSmoothingFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F3C RID: 3900
		public new static readonly string MRClassNameKey = "class vtkPointSmoothingFilter";

		/// <summary>
		/// Specify how smoothing is to be controlled.
		/// </summary>
		// Token: 0x02000455 RID: 1109
		public enum DEFAULT_SMOOTHING_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000F3E RID: 3902
			DEFAULT_SMOOTHING,
			/// <summary>enum member</summary>
			// Token: 0x04000F3F RID: 3903
			FRAME_FIELD_SMOOTHING = 5,
			/// <summary>enum member</summary>
			// Token: 0x04000F40 RID: 3904
			GEOMETRIC_SMOOTHING = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000F41 RID: 3905
			SCALAR_SMOOTHING = 3,
			/// <summary>enum member</summary>
			// Token: 0x04000F42 RID: 3906
			TENSOR_SMOOTHING,
			/// <summary>enum member</summary>
			// Token: 0x04000F43 RID: 3907
			UNIFORM_SMOOTHING = 2
		}

		/// <summary>
		/// Specify how point motion is to be constrained.
		/// </summary>
		// Token: 0x02000456 RID: 1110
		public enum PLANE_MOTION_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000F45 RID: 3909
			PLANE_MOTION = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000F46 RID: 3910
			UNCONSTRAINED_MOTION = 0
		}
	}
}
