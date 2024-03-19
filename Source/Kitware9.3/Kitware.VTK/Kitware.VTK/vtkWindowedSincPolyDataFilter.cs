using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkWindowedSincPolyDataFilter
	/// </summary>
	/// <remarks>
	///    adjust point positions using a windowed sinc function interpolation kernel
	///
	/// vtkWindowedSincPolyDataFiler adjusts point coordinates using a windowed
	/// sinc function interpolation kernel. The effect is to "relax" or "smooth"
	/// the mesh, making the cells better shaped and the vertices more evenly
	/// distributed.  Note that this filter operates the lines, polygons, and
	/// triangle strips composing an instance of vtkPolyData. Vertex or
	/// poly-vertex cells are never modified.
	///
	/// The algorithm proceeds as follows. For each vertex v, a topological and
	/// geometric analysis is performed to determine which vertices are connected
	/// to v, and which cells are connected to v. Then, a connectivity array is
	/// constructed for each vertex. (The connectivity array is a list of lists
	/// of vertices that directly attach to each vertex, the so-called smoothing
	/// stencil.) Next, an iteration phase begins over all vertices. For each
	/// vertex v, the coordinates of v are modified using a windowed sinc function
	/// interpolation kernel.  Taubin describes this methodology is the IBM tech
	/// report RC-20404 (#90237, dated 3/12/96) "Optimal Surface Smoothing as
	/// Filter Design" G. Taubin, T. Zhang and G. Golub. (Zhang and Golub are at
	/// Stanford University.)
	///
	/// This report discusses using standard signal processing low-pass filters
	/// (in particular windowed sinc functions) to smooth polyhedra. The
	/// transfer functions of the low-pass filters are approximated by
	/// Chebyshev polynomials. This facilitates applying the filters in an
	/// iterative diffusion process (as opposed to a kernel convolution).  The
	/// more smoothing iterations applied, the higher the degree of polynomial
	/// approximating the low-pass filter transfer function. Each smoothing
	/// iteration, therefore, applies the next higher term of the Chebyshev
	/// filter approximation to the polyhedron. This decoupling of the filter
	/// into an iteratively applied polynomial is possible since the Chebyshev
	/// polynomials are orthogonal, i.e. increasing the order of the
	/// approximation to the filter transfer function does not alter the
	/// previously calculated coefficients for the low order terms.
	///
	/// Note: Care must be taken to avoid smoothing with too few iterations.
	/// A Chebyshev approximation with too few terms is a poor approximation.
	/// The first few smoothing iterations represent a severe scaling and
	/// translation of the data.  Subsequent iterations cause the smoothed
	/// polyhedron to converge to the true location and scale of the object.
	/// We have attempted to protect against this by automatically adjusting
	/// the filter, effectively widening the pass band. This adjustment is only
	/// possible if the number of iterations is greater than 1.  Note that this
	/// sacrifices some degree of smoothing for model integrity. For those
	/// interested, the filter is adjusted by searching for a value sigma
	/// such that the actual pass band is k_pb + sigma and such that the
	/// filter transfer function evaluates to unity at k_pb, i.e. f(k_pb) = 1
	///
	/// To improve the numerical stability of the solution, and minimize the
	/// scaling the translation effects, the algorithm can translate and
	/// scale the position coordinates to within the unit cube [-1, 1],
	/// perform the smoothing, and translate and scale the position
	/// coordinates back to the original coordinate frame.  This mode is
	/// controlled with the NormalizeCoordinatesOn() /
	/// NormalizeCoordinatesOff() methods.  For legacy reasons, the default
	/// is NormalizeCoordinatesOff.
	///
	/// This implementation is currently limited to using an interpolation
	/// kernel based on Hamming windows.  Other windows (such as Hann, Blackman,
	/// Kaiser, Lanczos, Gaussian, and exponential windows) could be used
	/// instead.
	///
	/// There are some special instance variables used to control the execution
	/// of this filter. (These ivars basically control what vertices can be
	/// smoothed, and the creation of the connectivity array.) The
	/// BoundarySmoothing ivar enables/disables the smoothing operation on
	/// vertices that are on the "boundary" of the mesh. A boundary vertex is one
	/// that is surrounded by a semi-cycle of polygons (or used by a single
	/// line).
	///
	/// Another important ivar is FeatureEdgeSmoothing. If this ivar is
	/// enabled, then interior vertices are classified as either "simple",
	/// "interior edge", or "fixed", and smoothed differently. (Interior
	/// vertices are manifold vertices surrounded by a cycle of polygons; or used
	/// by two line cells.) The classification is based on the number of feature
	/// edges attached to v. A feature edge occurs when the angle between the two
	/// surface normals of a polygon sharing an edge is greater than the
	/// FeatureAngle ivar. Then, vertices used by no feature edges are classified
	/// "simple", vertices used by exactly two feature edges are classified
	/// "interior edge", and all others are "fixed" vertices.
	///
	/// Once the classification is known, the vertices are smoothed
	/// differently. Corner (i.e., fixed) vertices are not smoothed at all.
	/// Simple vertices are smoothed as before. Interior edge vertices are
	/// smoothed only along their two connected edges, and only if the angle
	/// between the edges is less than the EdgeAngle ivar.
	///
	/// The total smoothing can be controlled by using two ivars. The
	/// NumberOfIterations determines the maximum number of smoothing passes.
	/// The NumberOfIterations corresponds to the degree of the polynomial that
	/// is used to approximate the windowed sinc function. Ten or twenty
	/// iterations is all the is usually necessary. Contrast this with
	/// vtkSmoothPolyDataFilter which usually requires 100 to 200 smoothing
	/// iterations. vtkSmoothPolyDataFilter is also not an approximation to
	/// an ideal low-pass filter, which can cause the geometry to shrink as the
	/// amount of smoothing increases.
	///
	/// The second ivar is the specification of the PassBand for the windowed
	/// sinc filter.  By design, the PassBand is specified as a doubling point
	/// number between 0 and 2.  Lower PassBand values produce more smoothing.
	/// A good default value for the PassBand is 0.1 (for those interested, the
	/// PassBand (and frequencies) for PolyData are based on the valence of the
	/// vertices, this limits all the frequency modes in a polyhedral mesh to
	/// between 0 and 2.)
	///
	/// There are two instance variables that control the generation of error
	/// data. If the ivar GenerateErrorScalars is on, then a scalar value
	/// indicating the distance of each vertex from its original position is
	/// computed. If the ivar GenerateErrorVectors is on, then a vector
	/// representing change in position is computed.
	///
	/// @warning
	/// The smoothing operation reduces high frequency information in the
	/// geometry of the mesh. With excessive smoothing important details may be
	/// lost. Enabling FeatureEdgeSmoothing helps reduce this effect, but cannot
	/// entirely eliminate it.
	///
	/// @warning
	/// For maximum performance, do not enable BoundarySmoothing,
	/// NonManifoldSmoothing, or FeatureEdgeSmoothing. FeatureEdgeSmoothing is
	/// particularly expensive as it requires building topological links and
	/// computing local polygon normals which are relatively expensive
	/// operations. BoundarySmoothing and NonManifoldSmoothing have a modest
	/// impact on performance.
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential execution type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// </remarks>
	/// <seealso>
	///
	/// Another useful documentation resource is this SIGGRAPH publication:
	/// Gabriel Taubin. "A Signal Processing Approach To Fair Surface Design".
	///
	///
	/// vtkSmoothPolyDataFilter vtkConstrainedSmoothingFilter vtkPointSmoothingFilter
	/// vtkAttributeSmoothingFilter vtkDecimate vtkDecimatePro vtkQuadricDecimation
	/// </seealso>
	// Token: 0x020009C4 RID: 2500
	public class vtkWindowedSincPolyDataFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A1AB RID: 106923 RVA: 0x00242E8B File Offset: 0x0024108B
		static vtkWindowedSincPolyDataFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkWindowedSincPolyDataFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkWindowedSincPolyDataFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A1AC RID: 106924 RVA: 0x00242EB3 File Offset: 0x002410B3
		public vtkWindowedSincPolyDataFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601A1AD RID: 106925
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWindowedSincPolyDataFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with number of iterations 20; passband .1; feature edge
		/// smoothing turned off; feature angle 45 degrees; edge angle 15 degrees;
		/// and boundary smoothing turned on. Error scalars and vectors are not
		/// generated (by default).
		/// </summary>
		// Token: 0x0601A1AE RID: 106926 RVA: 0x00242EC4 File Offset: 0x002410C4
		public new static vtkWindowedSincPolyDataFilter New()
		{
			vtkWindowedSincPolyDataFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWindowedSincPolyDataFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object with number of iterations 20; passband .1; feature edge
		/// smoothing turned off; feature angle 45 degrees; edge angle 15 degrees;
		/// and boundary smoothing turned on. Error scalars and vectors are not
		/// generated (by default).
		/// </summary>
		// Token: 0x0601A1AF RID: 106927 RVA: 0x00242F18 File Offset: 0x00241118
		public vtkWindowedSincPolyDataFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A1B0 RID: 106928 RVA: 0x00242F5C File Offset: 0x0024115C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A1B1 RID: 106929
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowedSincPolyDataFilter_BoundarySmoothingOff_01(HandleRef pThis);

		/// <summary>
		/// Turn on/off the smoothing of points on the boundary of the mesh.
		/// Enabled this option has a modest impact on performance.
		/// </summary>
		// Token: 0x0601A1B2 RID: 106930 RVA: 0x00242F67 File Offset: 0x00241167
		public virtual void BoundarySmoothingOff()
		{
			vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_BoundarySmoothingOff_01(base.GetCppThis());
		}

		// Token: 0x0601A1B3 RID: 106931
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowedSincPolyDataFilter_BoundarySmoothingOn_02(HandleRef pThis);

		/// <summary>
		/// Turn on/off the smoothing of points on the boundary of the mesh.
		/// Enabled this option has a modest impact on performance.
		/// </summary>
		// Token: 0x0601A1B4 RID: 106932 RVA: 0x00242F76 File Offset: 0x00241176
		public virtual void BoundarySmoothingOn()
		{
			vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_BoundarySmoothingOn_02(base.GetCppThis());
		}

		// Token: 0x0601A1B5 RID: 106933
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowedSincPolyDataFilter_FeatureEdgeSmoothingOff_03(HandleRef pThis);

		/// <summary>
		/// Turn on/off smoothing points along sharp interior edges. Enabling this
		/// option has a performance impact on the algorithm since neihborhood
		/// information (cell links) and polygon normals must be computed.
		/// </summary>
		// Token: 0x0601A1B6 RID: 106934 RVA: 0x00242F85 File Offset: 0x00241185
		public virtual void FeatureEdgeSmoothingOff()
		{
			vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_FeatureEdgeSmoothingOff_03(base.GetCppThis());
		}

		// Token: 0x0601A1B7 RID: 106935
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowedSincPolyDataFilter_FeatureEdgeSmoothingOn_04(HandleRef pThis);

		/// <summary>
		/// Turn on/off smoothing points along sharp interior edges. Enabling this
		/// option has a performance impact on the algorithm since neihborhood
		/// information (cell links) and polygon normals must be computed.
		/// </summary>
		// Token: 0x0601A1B8 RID: 106936 RVA: 0x00242F94 File Offset: 0x00241194
		public virtual void FeatureEdgeSmoothingOn()
		{
			vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_FeatureEdgeSmoothingOn_04(base.GetCppThis());
		}

		// Token: 0x0601A1B9 RID: 106937
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowedSincPolyDataFilter_GenerateErrorScalarsOff_05(HandleRef pThis);

		/// <summary>
		/// Turn on/off the generation of scalar distance values.
		/// </summary>
		// Token: 0x0601A1BA RID: 106938 RVA: 0x00242FA3 File Offset: 0x002411A3
		public virtual void GenerateErrorScalarsOff()
		{
			vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_GenerateErrorScalarsOff_05(base.GetCppThis());
		}

		// Token: 0x0601A1BB RID: 106939
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowedSincPolyDataFilter_GenerateErrorScalarsOn_06(HandleRef pThis);

		/// <summary>
		/// Turn on/off the generation of scalar distance values.
		/// </summary>
		// Token: 0x0601A1BC RID: 106940 RVA: 0x00242FB2 File Offset: 0x002411B2
		public virtual void GenerateErrorScalarsOn()
		{
			vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_GenerateErrorScalarsOn_06(base.GetCppThis());
		}

		// Token: 0x0601A1BD RID: 106941
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowedSincPolyDataFilter_GenerateErrorVectorsOff_07(HandleRef pThis);

		/// <summary>
		/// Turn on/off the generation of error vectors.
		/// </summary>
		// Token: 0x0601A1BE RID: 106942 RVA: 0x00242FC1 File Offset: 0x002411C1
		public virtual void GenerateErrorVectorsOff()
		{
			vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_GenerateErrorVectorsOff_07(base.GetCppThis());
		}

		// Token: 0x0601A1BF RID: 106943
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowedSincPolyDataFilter_GenerateErrorVectorsOn_08(HandleRef pThis);

		/// <summary>
		/// Turn on/off the generation of error vectors.
		/// </summary>
		// Token: 0x0601A1C0 RID: 106944 RVA: 0x00242FD0 File Offset: 0x002411D0
		public virtual void GenerateErrorVectorsOn()
		{
			vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_GenerateErrorVectorsOn_08(base.GetCppThis());
		}

		// Token: 0x0601A1C1 RID: 106945
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWindowedSincPolyDataFilter_GetBoundarySmoothing_09(HandleRef pThis);

		/// <summary>
		/// Turn on/off the smoothing of points on the boundary of the mesh.
		/// Enabled this option has a modest impact on performance.
		/// </summary>
		// Token: 0x0601A1C2 RID: 106946 RVA: 0x00242FE0 File Offset: 0x002411E0
		public virtual int GetBoundarySmoothing()
		{
			return vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_GetBoundarySmoothing_09(base.GetCppThis());
		}

		// Token: 0x0601A1C3 RID: 106947
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkWindowedSincPolyDataFilter_GetEdgeAngle_10(HandleRef pThis);

		/// <summary>
		/// Specify the edge angle to control smoothing along edges (either interior
		/// or boundary).
		/// </summary>
		// Token: 0x0601A1C4 RID: 106948 RVA: 0x00243000 File Offset: 0x00241200
		public virtual double GetEdgeAngle()
		{
			return vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_GetEdgeAngle_10(base.GetCppThis());
		}

		// Token: 0x0601A1C5 RID: 106949
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkWindowedSincPolyDataFilter_GetEdgeAngleMaxValue_11(HandleRef pThis);

		/// <summary>
		/// Specify the edge angle to control smoothing along edges (either interior
		/// or boundary).
		/// </summary>
		// Token: 0x0601A1C6 RID: 106950 RVA: 0x00243020 File Offset: 0x00241220
		public virtual double GetEdgeAngleMaxValue()
		{
			return vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_GetEdgeAngleMaxValue_11(base.GetCppThis());
		}

		// Token: 0x0601A1C7 RID: 106951
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkWindowedSincPolyDataFilter_GetEdgeAngleMinValue_12(HandleRef pThis);

		/// <summary>
		/// Specify the edge angle to control smoothing along edges (either interior
		/// or boundary).
		/// </summary>
		// Token: 0x0601A1C8 RID: 106952 RVA: 0x00243040 File Offset: 0x00241240
		public virtual double GetEdgeAngleMinValue()
		{
			return vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_GetEdgeAngleMinValue_12(base.GetCppThis());
		}

		// Token: 0x0601A1C9 RID: 106953
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkWindowedSincPolyDataFilter_GetFeatureAngle_13(HandleRef pThis);

		/// <summary>
		/// Specify the feature angle for sharp edge identification. It only affects
		/// the filter when FeatureEdgeSmoothing is enabled.
		/// </summary>
		// Token: 0x0601A1CA RID: 106954 RVA: 0x00243060 File Offset: 0x00241260
		public virtual double GetFeatureAngle()
		{
			return vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_GetFeatureAngle_13(base.GetCppThis());
		}

		// Token: 0x0601A1CB RID: 106955
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkWindowedSincPolyDataFilter_GetFeatureAngleMaxValue_14(HandleRef pThis);

		/// <summary>
		/// Specify the feature angle for sharp edge identification. It only affects
		/// the filter when FeatureEdgeSmoothing is enabled.
		/// </summary>
		// Token: 0x0601A1CC RID: 106956 RVA: 0x00243080 File Offset: 0x00241280
		public virtual double GetFeatureAngleMaxValue()
		{
			return vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_GetFeatureAngleMaxValue_14(base.GetCppThis());
		}

		// Token: 0x0601A1CD RID: 106957
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkWindowedSincPolyDataFilter_GetFeatureAngleMinValue_15(HandleRef pThis);

		/// <summary>
		/// Specify the feature angle for sharp edge identification. It only affects
		/// the filter when FeatureEdgeSmoothing is enabled.
		/// </summary>
		// Token: 0x0601A1CE RID: 106958 RVA: 0x002430A0 File Offset: 0x002412A0
		public virtual double GetFeatureAngleMinValue()
		{
			return vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_GetFeatureAngleMinValue_15(base.GetCppThis());
		}

		// Token: 0x0601A1CF RID: 106959
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWindowedSincPolyDataFilter_GetFeatureEdgeSmoothing_16(HandleRef pThis);

		/// <summary>
		/// Turn on/off smoothing points along sharp interior edges. Enabling this
		/// option has a performance impact on the algorithm since neihborhood
		/// information (cell links) and polygon normals must be computed.
		/// </summary>
		// Token: 0x0601A1D0 RID: 106960 RVA: 0x002430C0 File Offset: 0x002412C0
		public virtual int GetFeatureEdgeSmoothing()
		{
			return vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_GetFeatureEdgeSmoothing_16(base.GetCppThis());
		}

		// Token: 0x0601A1D1 RID: 106961
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWindowedSincPolyDataFilter_GetGenerateErrorScalars_17(HandleRef pThis);

		/// <summary>
		/// Turn on/off the generation of scalar distance values.
		/// </summary>
		// Token: 0x0601A1D2 RID: 106962 RVA: 0x002430E0 File Offset: 0x002412E0
		public virtual int GetGenerateErrorScalars()
		{
			return vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_GetGenerateErrorScalars_17(base.GetCppThis());
		}

		// Token: 0x0601A1D3 RID: 106963
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWindowedSincPolyDataFilter_GetGenerateErrorVectors_18(HandleRef pThis);

		/// <summary>
		/// Turn on/off the generation of error vectors.
		/// </summary>
		// Token: 0x0601A1D4 RID: 106964 RVA: 0x00243100 File Offset: 0x00241300
		public virtual int GetGenerateErrorVectors()
		{
			return vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_GetGenerateErrorVectors_18(base.GetCppThis());
		}

		// Token: 0x0601A1D5 RID: 106965
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWindowedSincPolyDataFilter_GetNonManifoldSmoothing_19(HandleRef pThis);

		/// <summary>
		/// Smooth non-manifold points. Enabling this option has a modest
		/// impact on performance.
		/// </summary>
		// Token: 0x0601A1D6 RID: 106966 RVA: 0x00243120 File Offset: 0x00241320
		public virtual int GetNonManifoldSmoothing()
		{
			return vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_GetNonManifoldSmoothing_19(base.GetCppThis());
		}

		// Token: 0x0601A1D7 RID: 106967
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWindowedSincPolyDataFilter_GetNormalizeCoordinates_20(HandleRef pThis);

		/// <summary>
		/// Turn on/off coordinate normalization.  The positions can be translated
		/// and scaled such that they fit within a [-1, 1] prior to the smoothing
		/// computation. The default is off.  The numerical stability of the
		/// solution can be improved by turning normalization on.  If normalization
		/// is on, the coordinates will be rescaled to the original coordinate
		/// system after smoothing has completed.
		/// </summary>
		// Token: 0x0601A1D8 RID: 106968 RVA: 0x00243140 File Offset: 0x00241340
		public virtual int GetNormalizeCoordinates()
		{
			return vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_GetNormalizeCoordinates_20(base.GetCppThis());
		}

		// Token: 0x0601A1D9 RID: 106969
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWindowedSincPolyDataFilter_GetNumberOfGenerationsFromBase_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to obtain information, and print information about the
		/// the object.
		/// </summary>
		// Token: 0x0601A1DA RID: 106970 RVA: 0x00243160 File Offset: 0x00241360
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_GetNumberOfGenerationsFromBase_21(base.GetCppThis(), type);
		}

		// Token: 0x0601A1DB RID: 106971
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWindowedSincPolyDataFilter_GetNumberOfGenerationsFromBaseType_22([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to obtain information, and print information about the
		/// the object.
		/// </summary>
		// Token: 0x0601A1DC RID: 106972 RVA: 0x00243180 File Offset: 0x00241380
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_GetNumberOfGenerationsFromBaseType_22(type);
		}

		// Token: 0x0601A1DD RID: 106973
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWindowedSincPolyDataFilter_GetNumberOfIterations_23(HandleRef pThis);

		/// <summary>
		/// Specify the number of iterations (i.e., the degree of the polynomial
		/// approximating the windowed sinc function). Typically values around 20
		/// are used.
		/// </summary>
		// Token: 0x0601A1DE RID: 106974 RVA: 0x0024319C File Offset: 0x0024139C
		public virtual int GetNumberOfIterations()
		{
			return vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_GetNumberOfIterations_23(base.GetCppThis());
		}

		// Token: 0x0601A1DF RID: 106975
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWindowedSincPolyDataFilter_GetNumberOfIterationsMaxValue_24(HandleRef pThis);

		/// <summary>
		/// Specify the number of iterations (i.e., the degree of the polynomial
		/// approximating the windowed sinc function). Typically values around 20
		/// are used.
		/// </summary>
		// Token: 0x0601A1E0 RID: 106976 RVA: 0x002431BC File Offset: 0x002413BC
		public virtual int GetNumberOfIterationsMaxValue()
		{
			return vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_GetNumberOfIterationsMaxValue_24(base.GetCppThis());
		}

		// Token: 0x0601A1E1 RID: 106977
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWindowedSincPolyDataFilter_GetNumberOfIterationsMinValue_25(HandleRef pThis);

		/// <summary>
		/// Specify the number of iterations (i.e., the degree of the polynomial
		/// approximating the windowed sinc function). Typically values around 20
		/// are used.
		/// </summary>
		// Token: 0x0601A1E2 RID: 106978 RVA: 0x002431DC File Offset: 0x002413DC
		public virtual int GetNumberOfIterationsMinValue()
		{
			return vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_GetNumberOfIterationsMinValue_25(base.GetCppThis());
		}

		// Token: 0x0601A1E3 RID: 106979
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkWindowedSincPolyDataFilter_GetPassBand_26(HandleRef pThis);

		/// <summary>
		/// Set the passband value for the windowed sinc filter.
		/// </summary>
		// Token: 0x0601A1E4 RID: 106980 RVA: 0x002431FC File Offset: 0x002413FC
		public virtual double GetPassBand()
		{
			return vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_GetPassBand_26(base.GetCppThis());
		}

		// Token: 0x0601A1E5 RID: 106981
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkWindowedSincPolyDataFilter_GetPassBandMaxValue_27(HandleRef pThis);

		/// <summary>
		/// Set the passband value for the windowed sinc filter.
		/// </summary>
		// Token: 0x0601A1E6 RID: 106982 RVA: 0x0024321C File Offset: 0x0024141C
		public virtual double GetPassBandMaxValue()
		{
			return vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_GetPassBandMaxValue_27(base.GetCppThis());
		}

		// Token: 0x0601A1E7 RID: 106983
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkWindowedSincPolyDataFilter_GetPassBandMinValue_28(HandleRef pThis);

		/// <summary>
		/// Set the passband value for the windowed sinc filter.
		/// </summary>
		// Token: 0x0601A1E8 RID: 106984 RVA: 0x0024323C File Offset: 0x0024143C
		public virtual double GetPassBandMinValue()
		{
			return vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_GetPassBandMinValue_28(base.GetCppThis());
		}

		// Token: 0x0601A1E9 RID: 106985
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWindowedSincPolyDataFilter_GetWeightNonManifoldEdges_29(HandleRef pThis);

		/// <summary>
		/// When non-manifold smoothing is enabled, better smoothing performance may
		/// be possible by providing extra weighting to non-manifold edges. By default,
		/// WeightNonManifoldEdges is enabled (this is to preserve consistent behavior
		/// with previous versions of this filter).
		/// </summary>
		// Token: 0x0601A1EA RID: 106986 RVA: 0x0024325C File Offset: 0x0024145C
		public virtual int GetWeightNonManifoldEdges()
		{
			return vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_GetWeightNonManifoldEdges_29(base.GetCppThis());
		}

		// Token: 0x0601A1EB RID: 106987
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWindowedSincPolyDataFilter_IsA_30(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to obtain information, and print information about the
		/// the object.
		/// </summary>
		// Token: 0x0601A1EC RID: 106988 RVA: 0x0024327C File Offset: 0x0024147C
		public override int IsA(string type)
		{
			return vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_IsA_30(base.GetCppThis(), type);
		}

		// Token: 0x0601A1ED RID: 106989
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWindowedSincPolyDataFilter_IsTypeOf_31([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to obtain information, and print information about the
		/// the object.
		/// </summary>
		// Token: 0x0601A1EE RID: 106990 RVA: 0x0024329C File Offset: 0x0024149C
		public new static int IsTypeOf(string type)
		{
			return vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_IsTypeOf_31(type);
		}

		// Token: 0x0601A1EF RID: 106991
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWindowedSincPolyDataFilter_NewInstance_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods to obtain information, and print information about the
		/// the object.
		/// </summary>
		// Token: 0x0601A1F0 RID: 106992 RVA: 0x002432B8 File Offset: 0x002414B8
		public new vtkWindowedSincPolyDataFilter NewInstance()
		{
			vtkWindowedSincPolyDataFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_NewInstance_33(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWindowedSincPolyDataFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A1F1 RID: 106993
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowedSincPolyDataFilter_NonManifoldSmoothingOff_34(HandleRef pThis);

		/// <summary>
		/// Smooth non-manifold points. Enabling this option has a modest
		/// impact on performance.
		/// </summary>
		// Token: 0x0601A1F2 RID: 106994 RVA: 0x00243312 File Offset: 0x00241512
		public virtual void NonManifoldSmoothingOff()
		{
			vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_NonManifoldSmoothingOff_34(base.GetCppThis());
		}

		// Token: 0x0601A1F3 RID: 106995
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowedSincPolyDataFilter_NonManifoldSmoothingOn_35(HandleRef pThis);

		/// <summary>
		/// Smooth non-manifold points. Enabling this option has a modest
		/// impact on performance.
		/// </summary>
		// Token: 0x0601A1F4 RID: 106996 RVA: 0x00243321 File Offset: 0x00241521
		public virtual void NonManifoldSmoothingOn()
		{
			vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_NonManifoldSmoothingOn_35(base.GetCppThis());
		}

		// Token: 0x0601A1F5 RID: 106997
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowedSincPolyDataFilter_NormalizeCoordinatesOff_36(HandleRef pThis);

		/// <summary>
		/// Turn on/off coordinate normalization.  The positions can be translated
		/// and scaled such that they fit within a [-1, 1] prior to the smoothing
		/// computation. The default is off.  The numerical stability of the
		/// solution can be improved by turning normalization on.  If normalization
		/// is on, the coordinates will be rescaled to the original coordinate
		/// system after smoothing has completed.
		/// </summary>
		// Token: 0x0601A1F6 RID: 106998 RVA: 0x00243330 File Offset: 0x00241530
		public virtual void NormalizeCoordinatesOff()
		{
			vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_NormalizeCoordinatesOff_36(base.GetCppThis());
		}

		// Token: 0x0601A1F7 RID: 106999
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowedSincPolyDataFilter_NormalizeCoordinatesOn_37(HandleRef pThis);

		/// <summary>
		/// Turn on/off coordinate normalization.  The positions can be translated
		/// and scaled such that they fit within a [-1, 1] prior to the smoothing
		/// computation. The default is off.  The numerical stability of the
		/// solution can be improved by turning normalization on.  If normalization
		/// is on, the coordinates will be rescaled to the original coordinate
		/// system after smoothing has completed.
		/// </summary>
		// Token: 0x0601A1F8 RID: 107000 RVA: 0x0024333F File Offset: 0x0024153F
		public virtual void NormalizeCoordinatesOn()
		{
			vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_NormalizeCoordinatesOn_37(base.GetCppThis());
		}

		// Token: 0x0601A1F9 RID: 107001
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWindowedSincPolyDataFilter_SafeDownCast_38(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods to obtain information, and print information about the
		/// the object.
		/// </summary>
		// Token: 0x0601A1FA RID: 107002 RVA: 0x00243350 File Offset: 0x00241550
		public new static vtkWindowedSincPolyDataFilter SafeDownCast(vtkObjectBase o)
		{
			vtkWindowedSincPolyDataFilter vtkWindowedSincPolyDataFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_SafeDownCast_38((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWindowedSincPolyDataFilter = (vtkWindowedSincPolyDataFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWindowedSincPolyDataFilter.Register(null);
				}
			}
			return vtkWindowedSincPolyDataFilter;
		}

		// Token: 0x0601A1FB RID: 107003
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowedSincPolyDataFilter_SetBoundarySmoothing_39(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the smoothing of points on the boundary of the mesh.
		/// Enabled this option has a modest impact on performance.
		/// </summary>
		// Token: 0x0601A1FC RID: 107004 RVA: 0x002433CF File Offset: 0x002415CF
		public virtual void SetBoundarySmoothing(int _arg)
		{
			vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_SetBoundarySmoothing_39(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A1FD RID: 107005
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowedSincPolyDataFilter_SetEdgeAngle_40(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the edge angle to control smoothing along edges (either interior
		/// or boundary).
		/// </summary>
		// Token: 0x0601A1FE RID: 107006 RVA: 0x002433DF File Offset: 0x002415DF
		public virtual void SetEdgeAngle(double _arg)
		{
			vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_SetEdgeAngle_40(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A1FF RID: 107007
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowedSincPolyDataFilter_SetFeatureAngle_41(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the feature angle for sharp edge identification. It only affects
		/// the filter when FeatureEdgeSmoothing is enabled.
		/// </summary>
		// Token: 0x0601A200 RID: 107008 RVA: 0x002433EF File Offset: 0x002415EF
		public virtual void SetFeatureAngle(double _arg)
		{
			vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_SetFeatureAngle_41(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A201 RID: 107009
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowedSincPolyDataFilter_SetFeatureEdgeSmoothing_42(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off smoothing points along sharp interior edges. Enabling this
		/// option has a performance impact on the algorithm since neihborhood
		/// information (cell links) and polygon normals must be computed.
		/// </summary>
		// Token: 0x0601A202 RID: 107010 RVA: 0x002433FF File Offset: 0x002415FF
		public virtual void SetFeatureEdgeSmoothing(int _arg)
		{
			vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_SetFeatureEdgeSmoothing_42(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A203 RID: 107011
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowedSincPolyDataFilter_SetGenerateErrorScalars_43(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the generation of scalar distance values.
		/// </summary>
		// Token: 0x0601A204 RID: 107012 RVA: 0x0024340F File Offset: 0x0024160F
		public virtual void SetGenerateErrorScalars(int _arg)
		{
			vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_SetGenerateErrorScalars_43(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A205 RID: 107013
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowedSincPolyDataFilter_SetGenerateErrorVectors_44(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the generation of error vectors.
		/// </summary>
		// Token: 0x0601A206 RID: 107014 RVA: 0x0024341F File Offset: 0x0024161F
		public virtual void SetGenerateErrorVectors(int _arg)
		{
			vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_SetGenerateErrorVectors_44(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A207 RID: 107015
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowedSincPolyDataFilter_SetNonManifoldSmoothing_45(HandleRef pThis, int _arg);

		/// <summary>
		/// Smooth non-manifold points. Enabling this option has a modest
		/// impact on performance.
		/// </summary>
		// Token: 0x0601A208 RID: 107016 RVA: 0x0024342F File Offset: 0x0024162F
		public virtual void SetNonManifoldSmoothing(int _arg)
		{
			vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_SetNonManifoldSmoothing_45(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A209 RID: 107017
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowedSincPolyDataFilter_SetNormalizeCoordinates_46(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off coordinate normalization.  The positions can be translated
		/// and scaled such that they fit within a [-1, 1] prior to the smoothing
		/// computation. The default is off.  The numerical stability of the
		/// solution can be improved by turning normalization on.  If normalization
		/// is on, the coordinates will be rescaled to the original coordinate
		/// system after smoothing has completed.
		/// </summary>
		// Token: 0x0601A20A RID: 107018 RVA: 0x0024343F File Offset: 0x0024163F
		public virtual void SetNormalizeCoordinates(int _arg)
		{
			vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_SetNormalizeCoordinates_46(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A20B RID: 107019
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowedSincPolyDataFilter_SetNumberOfIterations_47(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the number of iterations (i.e., the degree of the polynomial
		/// approximating the windowed sinc function). Typically values around 20
		/// are used.
		/// </summary>
		// Token: 0x0601A20C RID: 107020 RVA: 0x0024344F File Offset: 0x0024164F
		public virtual void SetNumberOfIterations(int _arg)
		{
			vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_SetNumberOfIterations_47(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A20D RID: 107021
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowedSincPolyDataFilter_SetPassBand_48(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the passband value for the windowed sinc filter.
		/// </summary>
		// Token: 0x0601A20E RID: 107022 RVA: 0x0024345F File Offset: 0x0024165F
		public virtual void SetPassBand(double _arg)
		{
			vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_SetPassBand_48(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A20F RID: 107023
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowedSincPolyDataFilter_SetWeightNonManifoldEdges_49(HandleRef pThis, int _arg);

		/// <summary>
		/// When non-manifold smoothing is enabled, better smoothing performance may
		/// be possible by providing extra weighting to non-manifold edges. By default,
		/// WeightNonManifoldEdges is enabled (this is to preserve consistent behavior
		/// with previous versions of this filter).
		/// </summary>
		// Token: 0x0601A210 RID: 107024 RVA: 0x0024346F File Offset: 0x0024166F
		public virtual void SetWeightNonManifoldEdges(int _arg)
		{
			vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_SetWeightNonManifoldEdges_49(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A211 RID: 107025
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowedSincPolyDataFilter_WeightNonManifoldEdgesOff_50(HandleRef pThis);

		/// <summary>
		/// When non-manifold smoothing is enabled, better smoothing performance may
		/// be possible by providing extra weighting to non-manifold edges. By default,
		/// WeightNonManifoldEdges is enabled (this is to preserve consistent behavior
		/// with previous versions of this filter).
		/// </summary>
		// Token: 0x0601A212 RID: 107026 RVA: 0x0024347F File Offset: 0x0024167F
		public virtual void WeightNonManifoldEdgesOff()
		{
			vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_WeightNonManifoldEdgesOff_50(base.GetCppThis());
		}

		// Token: 0x0601A213 RID: 107027
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowedSincPolyDataFilter_WeightNonManifoldEdgesOn_51(HandleRef pThis);

		/// <summary>
		/// When non-manifold smoothing is enabled, better smoothing performance may
		/// be possible by providing extra weighting to non-manifold edges. By default,
		/// WeightNonManifoldEdges is enabled (this is to preserve consistent behavior
		/// with previous versions of this filter).
		/// </summary>
		// Token: 0x0601A214 RID: 107028 RVA: 0x0024348E File Offset: 0x0024168E
		public virtual void WeightNonManifoldEdgesOn()
		{
			vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_WeightNonManifoldEdgesOn_51(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C55 RID: 7253
		public new const string MRFullTypeName = "Kitware.VTK.vtkWindowedSincPolyDataFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C56 RID: 7254
		public new static readonly string MRClassNameKey = "class vtkWindowedSincPolyDataFilter";
	}
}
