using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSmoothPolyDataFilter
	/// </summary>
	/// <remarks>
	///    adjust point positions using Laplacian smoothing
	///
	/// vtkSmoothPolyDataFilter is a filter that adjusts point coordinates using
	/// Laplacian smoothing. The effect is to "relax" the mesh, making the cells
	/// better shaped and the vertices more evenly distributed. Note that this
	/// filter operates on the lines, polygons, and triangle strips composing an
	/// instance of vtkPolyData. Vertex or poly-vertex cells are never modified.
	///
	/// The algorithm proceeds as follows. For each vertex v, a topological and
	/// geometric analysis is performed to determine which vertices are connected
	/// to v, and which cells are connected to v. Then, a connectivity array is
	/// constructed for each vertex. (The connectivity array is a list of lists
	/// of vertices that directly attach to each vertex.) Next, an iteration
	/// phase begins over all vertices. For each vertex v, the coordinates of v
	/// are modified according to an average of the connected vertices.  (A
	/// relaxation factor is available to control the amount of displacement of
	/// v).  The process repeats for each vertex. This pass over the list of
	/// vertices is a single iteration. Many iterations (generally around 20 or
	/// so) are repeated until the desired result is obtained.
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
	/// Simple vertices are smoothed as before (i.e., average of connected
	/// vertex coordinates). Interior edge vertices are smoothed only along
	/// their two connected edges, and only if the angle between the edges
	/// is less than the EdgeAngle ivar.
	///
	/// The total smoothing can be controlled by using two ivars. The
	/// NumberOfIterations is a cap on the maximum number of smoothing passes.
	/// The Convergence ivar is a limit on the maximum point motion. If the
	/// maximum motion during an iteration is less than Convergence, then the
	/// smoothing process terminates. (Convergence is expressed as a fraction of
	/// the diagonal of the bounding box.)
	///
	/// There are two instance variables that control the generation of error
	/// data. If the ivar GenerateErrorScalars is on, then a scalar value indicating
	/// the distance of each vertex from its original position is computed. If the
	/// ivar GenerateErrorVectors is on, then a vector representing change in
	/// position is computed.
	///
	/// Optionally you can further control the smoothing process by defining a
	/// second input: the Source. If defined, the input mesh is constrained to
	/// lie on the surface defined by the Source ivar.
	///
	///
	/// @warning
	/// The Laplacian operation reduces high frequency information in the geometry
	/// of the mesh. With excessive smoothing important details may be lost, and
	/// the surface may shrink towards the centroid. Enabling FeatureEdgeSmoothing
	/// helps reduce this effect, but cannot entirely eliminate it. You may also
	/// wish to try vtkWindowedSincPolyDataFilter. It does a better job of
	/// minimizing shrinkage. Another option is vtkConstrainedSmoothingFilter
	/// which limits the distance that points can move.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkWindowedSincPolyDataFilter vtkConstrainedSmoothingFilter
	/// vtkDecimate vtkDecimatePro
	/// </seealso>
	// Token: 0x0200099C RID: 2460
	public class vtkSmoothPolyDataFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06019AA5 RID: 105125 RVA: 0x0023AF4D File Offset: 0x0023914D
		static vtkSmoothPolyDataFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSmoothPolyDataFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSmoothPolyDataFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06019AA6 RID: 105126 RVA: 0x0023AF75 File Offset: 0x00239175
		public vtkSmoothPolyDataFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06019AA7 RID: 105127
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSmoothPolyDataFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with number of iterations 20; relaxation factor .01;
		/// feature edge smoothing turned off; feature
		/// angle 45 degrees; edge angle 15 degrees; and boundary smoothing turned
		/// on. Error scalars and vectors are not generated (by default). The
		/// convergence criterion is 0.0 of the bounding box diagonal.
		/// </summary>
		// Token: 0x06019AA8 RID: 105128 RVA: 0x0023AF84 File Offset: 0x00239184
		public new static vtkSmoothPolyDataFilter New()
		{
			vtkSmoothPolyDataFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSmoothPolyDataFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object with number of iterations 20; relaxation factor .01;
		/// feature edge smoothing turned off; feature
		/// angle 45 degrees; edge angle 15 degrees; and boundary smoothing turned
		/// on. Error scalars and vectors are not generated (by default). The
		/// convergence criterion is 0.0 of the bounding box diagonal.
		/// </summary>
		// Token: 0x06019AA9 RID: 105129 RVA: 0x0023AFD8 File Offset: 0x002391D8
		public vtkSmoothPolyDataFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06019AAA RID: 105130 RVA: 0x0023B01C File Offset: 0x0023921C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06019AAB RID: 105131
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSmoothPolyDataFilter_BoundarySmoothingOff_01(HandleRef pThis);

		/// <summary>
		/// Turn on/off the smoothing of vertices on the boundary of the mesh.
		/// </summary>
		// Token: 0x06019AAC RID: 105132 RVA: 0x0023B027 File Offset: 0x00239227
		public virtual void BoundarySmoothingOff()
		{
			vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_BoundarySmoothingOff_01(base.GetCppThis());
		}

		// Token: 0x06019AAD RID: 105133
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSmoothPolyDataFilter_BoundarySmoothingOn_02(HandleRef pThis);

		/// <summary>
		/// Turn on/off the smoothing of vertices on the boundary of the mesh.
		/// </summary>
		// Token: 0x06019AAE RID: 105134 RVA: 0x0023B036 File Offset: 0x00239236
		public virtual void BoundarySmoothingOn()
		{
			vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_BoundarySmoothingOn_02(base.GetCppThis());
		}

		// Token: 0x06019AAF RID: 105135
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSmoothPolyDataFilter_FeatureEdgeSmoothingOff_03(HandleRef pThis);

		/// <summary>
		/// Turn on/off smoothing along sharp interior edges.
		/// </summary>
		// Token: 0x06019AB0 RID: 105136 RVA: 0x0023B045 File Offset: 0x00239245
		public virtual void FeatureEdgeSmoothingOff()
		{
			vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_FeatureEdgeSmoothingOff_03(base.GetCppThis());
		}

		// Token: 0x06019AB1 RID: 105137
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSmoothPolyDataFilter_FeatureEdgeSmoothingOn_04(HandleRef pThis);

		/// <summary>
		/// Turn on/off smoothing along sharp interior edges.
		/// </summary>
		// Token: 0x06019AB2 RID: 105138 RVA: 0x0023B054 File Offset: 0x00239254
		public virtual void FeatureEdgeSmoothingOn()
		{
			vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_FeatureEdgeSmoothingOn_04(base.GetCppThis());
		}

		// Token: 0x06019AB3 RID: 105139
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSmoothPolyDataFilter_GenerateErrorScalarsOff_05(HandleRef pThis);

		/// <summary>
		/// Turn on/off the generation of scalar distance values.
		/// </summary>
		// Token: 0x06019AB4 RID: 105140 RVA: 0x0023B063 File Offset: 0x00239263
		public virtual void GenerateErrorScalarsOff()
		{
			vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_GenerateErrorScalarsOff_05(base.GetCppThis());
		}

		// Token: 0x06019AB5 RID: 105141
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSmoothPolyDataFilter_GenerateErrorScalarsOn_06(HandleRef pThis);

		/// <summary>
		/// Turn on/off the generation of scalar distance values.
		/// </summary>
		// Token: 0x06019AB6 RID: 105142 RVA: 0x0023B072 File Offset: 0x00239272
		public virtual void GenerateErrorScalarsOn()
		{
			vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_GenerateErrorScalarsOn_06(base.GetCppThis());
		}

		// Token: 0x06019AB7 RID: 105143
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSmoothPolyDataFilter_GenerateErrorVectorsOff_07(HandleRef pThis);

		/// <summary>
		/// Turn on/off the generation of error vectors.
		/// </summary>
		// Token: 0x06019AB8 RID: 105144 RVA: 0x0023B081 File Offset: 0x00239281
		public virtual void GenerateErrorVectorsOff()
		{
			vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_GenerateErrorVectorsOff_07(base.GetCppThis());
		}

		// Token: 0x06019AB9 RID: 105145
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSmoothPolyDataFilter_GenerateErrorVectorsOn_08(HandleRef pThis);

		/// <summary>
		/// Turn on/off the generation of error vectors.
		/// </summary>
		// Token: 0x06019ABA RID: 105146 RVA: 0x0023B090 File Offset: 0x00239290
		public virtual void GenerateErrorVectorsOn()
		{
			vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_GenerateErrorVectorsOn_08(base.GetCppThis());
		}

		// Token: 0x06019ABB RID: 105147
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSmoothPolyDataFilter_GetBoundarySmoothing_09(HandleRef pThis);

		/// <summary>
		/// Turn on/off the smoothing of vertices on the boundary of the mesh.
		/// </summary>
		// Token: 0x06019ABC RID: 105148 RVA: 0x0023B0A0 File Offset: 0x002392A0
		public virtual int GetBoundarySmoothing()
		{
			return vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_GetBoundarySmoothing_09(base.GetCppThis());
		}

		// Token: 0x06019ABD RID: 105149
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSmoothPolyDataFilter_GetConvergence_10(HandleRef pThis);

		/// <summary>
		/// Specify a convergence criterion for the iteration
		/// process. Smaller numbers result in more smoothing iterations.
		/// </summary>
		// Token: 0x06019ABE RID: 105150 RVA: 0x0023B0C0 File Offset: 0x002392C0
		public virtual double GetConvergence()
		{
			return vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_GetConvergence_10(base.GetCppThis());
		}

		// Token: 0x06019ABF RID: 105151
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSmoothPolyDataFilter_GetConvergenceMaxValue_11(HandleRef pThis);

		/// <summary>
		/// Specify a convergence criterion for the iteration
		/// process. Smaller numbers result in more smoothing iterations.
		/// </summary>
		// Token: 0x06019AC0 RID: 105152 RVA: 0x0023B0E0 File Offset: 0x002392E0
		public virtual double GetConvergenceMaxValue()
		{
			return vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_GetConvergenceMaxValue_11(base.GetCppThis());
		}

		// Token: 0x06019AC1 RID: 105153
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSmoothPolyDataFilter_GetConvergenceMinValue_12(HandleRef pThis);

		/// <summary>
		/// Specify a convergence criterion for the iteration
		/// process. Smaller numbers result in more smoothing iterations.
		/// </summary>
		// Token: 0x06019AC2 RID: 105154 RVA: 0x0023B100 File Offset: 0x00239300
		public virtual double GetConvergenceMinValue()
		{
			return vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_GetConvergenceMinValue_12(base.GetCppThis());
		}

		// Token: 0x06019AC3 RID: 105155
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSmoothPolyDataFilter_GetEdgeAngle_13(HandleRef pThis);

		/// <summary>
		/// Specify the edge angle to control smoothing along edges (either interior
		/// or boundary).
		/// </summary>
		// Token: 0x06019AC4 RID: 105156 RVA: 0x0023B120 File Offset: 0x00239320
		public virtual double GetEdgeAngle()
		{
			return vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_GetEdgeAngle_13(base.GetCppThis());
		}

		// Token: 0x06019AC5 RID: 105157
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSmoothPolyDataFilter_GetEdgeAngleMaxValue_14(HandleRef pThis);

		/// <summary>
		/// Specify the edge angle to control smoothing along edges (either interior
		/// or boundary).
		/// </summary>
		// Token: 0x06019AC6 RID: 105158 RVA: 0x0023B140 File Offset: 0x00239340
		public virtual double GetEdgeAngleMaxValue()
		{
			return vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_GetEdgeAngleMaxValue_14(base.GetCppThis());
		}

		// Token: 0x06019AC7 RID: 105159
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSmoothPolyDataFilter_GetEdgeAngleMinValue_15(HandleRef pThis);

		/// <summary>
		/// Specify the edge angle to control smoothing along edges (either interior
		/// or boundary).
		/// </summary>
		// Token: 0x06019AC8 RID: 105160 RVA: 0x0023B160 File Offset: 0x00239360
		public virtual double GetEdgeAngleMinValue()
		{
			return vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_GetEdgeAngleMinValue_15(base.GetCppThis());
		}

		// Token: 0x06019AC9 RID: 105161
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSmoothPolyDataFilter_GetFeatureAngle_16(HandleRef pThis);

		/// <summary>
		/// Specify the feature angle for sharp edge identification.
		/// </summary>
		// Token: 0x06019ACA RID: 105162 RVA: 0x0023B180 File Offset: 0x00239380
		public virtual double GetFeatureAngle()
		{
			return vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_GetFeatureAngle_16(base.GetCppThis());
		}

		// Token: 0x06019ACB RID: 105163
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSmoothPolyDataFilter_GetFeatureAngleMaxValue_17(HandleRef pThis);

		/// <summary>
		/// Specify the feature angle for sharp edge identification.
		/// </summary>
		// Token: 0x06019ACC RID: 105164 RVA: 0x0023B1A0 File Offset: 0x002393A0
		public virtual double GetFeatureAngleMaxValue()
		{
			return vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_GetFeatureAngleMaxValue_17(base.GetCppThis());
		}

		// Token: 0x06019ACD RID: 105165
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSmoothPolyDataFilter_GetFeatureAngleMinValue_18(HandleRef pThis);

		/// <summary>
		/// Specify the feature angle for sharp edge identification.
		/// </summary>
		// Token: 0x06019ACE RID: 105166 RVA: 0x0023B1C0 File Offset: 0x002393C0
		public virtual double GetFeatureAngleMinValue()
		{
			return vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_GetFeatureAngleMinValue_18(base.GetCppThis());
		}

		// Token: 0x06019ACF RID: 105167
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSmoothPolyDataFilter_GetFeatureEdgeSmoothing_19(HandleRef pThis);

		/// <summary>
		/// Turn on/off smoothing along sharp interior edges.
		/// </summary>
		// Token: 0x06019AD0 RID: 105168 RVA: 0x0023B1E0 File Offset: 0x002393E0
		public virtual int GetFeatureEdgeSmoothing()
		{
			return vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_GetFeatureEdgeSmoothing_19(base.GetCppThis());
		}

		// Token: 0x06019AD1 RID: 105169
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSmoothPolyDataFilter_GetGenerateErrorScalars_20(HandleRef pThis);

		/// <summary>
		/// Turn on/off the generation of scalar distance values.
		/// </summary>
		// Token: 0x06019AD2 RID: 105170 RVA: 0x0023B200 File Offset: 0x00239400
		public virtual int GetGenerateErrorScalars()
		{
			return vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_GetGenerateErrorScalars_20(base.GetCppThis());
		}

		// Token: 0x06019AD3 RID: 105171
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSmoothPolyDataFilter_GetGenerateErrorVectors_21(HandleRef pThis);

		/// <summary>
		/// Turn on/off the generation of error vectors.
		/// </summary>
		// Token: 0x06019AD4 RID: 105172 RVA: 0x0023B220 File Offset: 0x00239420
		public virtual int GetGenerateErrorVectors()
		{
			return vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_GetGenerateErrorVectors_21(base.GetCppThis());
		}

		// Token: 0x06019AD5 RID: 105173
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSmoothPolyDataFilter_GetNumberOfGenerationsFromBase_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to obtain type information, and print the
		/// state of a class instance.
		/// </summary>
		// Token: 0x06019AD6 RID: 105174 RVA: 0x0023B240 File Offset: 0x00239440
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_GetNumberOfGenerationsFromBase_22(base.GetCppThis(), type);
		}

		// Token: 0x06019AD7 RID: 105175
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSmoothPolyDataFilter_GetNumberOfGenerationsFromBaseType_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to obtain type information, and print the
		/// state of a class instance.
		/// </summary>
		// Token: 0x06019AD8 RID: 105176 RVA: 0x0023B260 File Offset: 0x00239460
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_GetNumberOfGenerationsFromBaseType_23(type);
		}

		// Token: 0x06019AD9 RID: 105177
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSmoothPolyDataFilter_GetNumberOfIterations_24(HandleRef pThis);

		/// <summary>
		/// Specify the number of iterations for Laplacian smoothing,
		/// </summary>
		// Token: 0x06019ADA RID: 105178 RVA: 0x0023B27C File Offset: 0x0023947C
		public virtual int GetNumberOfIterations()
		{
			return vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_GetNumberOfIterations_24(base.GetCppThis());
		}

		// Token: 0x06019ADB RID: 105179
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSmoothPolyDataFilter_GetNumberOfIterationsMaxValue_25(HandleRef pThis);

		/// <summary>
		/// Specify the number of iterations for Laplacian smoothing,
		/// </summary>
		// Token: 0x06019ADC RID: 105180 RVA: 0x0023B29C File Offset: 0x0023949C
		public virtual int GetNumberOfIterationsMaxValue()
		{
			return vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_GetNumberOfIterationsMaxValue_25(base.GetCppThis());
		}

		// Token: 0x06019ADD RID: 105181
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSmoothPolyDataFilter_GetNumberOfIterationsMinValue_26(HandleRef pThis);

		/// <summary>
		/// Specify the number of iterations for Laplacian smoothing,
		/// </summary>
		// Token: 0x06019ADE RID: 105182 RVA: 0x0023B2BC File Offset: 0x002394BC
		public virtual int GetNumberOfIterationsMinValue()
		{
			return vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_GetNumberOfIterationsMinValue_26(base.GetCppThis());
		}

		// Token: 0x06019ADF RID: 105183
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSmoothPolyDataFilter_GetOutputPointsPrecision_27(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06019AE0 RID: 105184 RVA: 0x0023B2DC File Offset: 0x002394DC
		public virtual int GetOutputPointsPrecision()
		{
			return vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_GetOutputPointsPrecision_27(base.GetCppThis());
		}

		// Token: 0x06019AE1 RID: 105185
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSmoothPolyDataFilter_GetRelaxationFactor_28(HandleRef pThis);

		/// <summary>
		/// Specify the relaxation factor for Laplacian smoothing. As in all
		/// iterative methods, the stability of the process is sensitive to
		/// this parameter. In general, small relaxation factors and large
		/// numbers of iterations are more stable than larger relaxation
		/// factors and smaller numbers of iterations.
		/// </summary>
		// Token: 0x06019AE2 RID: 105186 RVA: 0x0023B2FC File Offset: 0x002394FC
		public virtual double GetRelaxationFactor()
		{
			return vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_GetRelaxationFactor_28(base.GetCppThis());
		}

		// Token: 0x06019AE3 RID: 105187
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSmoothPolyDataFilter_GetSource_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the source object which is used to constrain smoothing. The
		/// source defines a surface that the input (as it is smoothed) is
		/// constrained to lie upon.
		/// </summary>
		// Token: 0x06019AE4 RID: 105188 RVA: 0x0023B31C File Offset: 0x0023951C
		public vtkPolyData GetSource()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_GetSource_29(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06019AE5 RID: 105189
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSmoothPolyDataFilter_IsA_30(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to obtain type information, and print the
		/// state of a class instance.
		/// </summary>
		// Token: 0x06019AE6 RID: 105190 RVA: 0x0023B38C File Offset: 0x0023958C
		public override int IsA(string type)
		{
			return vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_IsA_30(base.GetCppThis(), type);
		}

		// Token: 0x06019AE7 RID: 105191
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSmoothPolyDataFilter_IsTypeOf_31([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to obtain type information, and print the
		/// state of a class instance.
		/// </summary>
		// Token: 0x06019AE8 RID: 105192 RVA: 0x0023B3AC File Offset: 0x002395AC
		public new static int IsTypeOf(string type)
		{
			return vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_IsTypeOf_31(type);
		}

		// Token: 0x06019AE9 RID: 105193
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSmoothPolyDataFilter_NewInstance_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods to obtain type information, and print the
		/// state of a class instance.
		/// </summary>
		// Token: 0x06019AEA RID: 105194 RVA: 0x0023B3C8 File Offset: 0x002395C8
		public new vtkSmoothPolyDataFilter NewInstance()
		{
			vtkSmoothPolyDataFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_NewInstance_33(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSmoothPolyDataFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06019AEB RID: 105195
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSmoothPolyDataFilter_SafeDownCast_34(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods to obtain type information, and print the
		/// state of a class instance.
		/// </summary>
		// Token: 0x06019AEC RID: 105196 RVA: 0x0023B424 File Offset: 0x00239624
		public new static vtkSmoothPolyDataFilter SafeDownCast(vtkObjectBase o)
		{
			vtkSmoothPolyDataFilter vtkSmoothPolyDataFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_SafeDownCast_34((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSmoothPolyDataFilter = (vtkSmoothPolyDataFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSmoothPolyDataFilter.Register(null);
				}
			}
			return vtkSmoothPolyDataFilter;
		}

		// Token: 0x06019AED RID: 105197
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSmoothPolyDataFilter_SetBoundarySmoothing_35(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the smoothing of vertices on the boundary of the mesh.
		/// </summary>
		// Token: 0x06019AEE RID: 105198 RVA: 0x0023B4A3 File Offset: 0x002396A3
		public virtual void SetBoundarySmoothing(int _arg)
		{
			vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_SetBoundarySmoothing_35(base.GetCppThis(), _arg);
		}

		// Token: 0x06019AEF RID: 105199
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSmoothPolyDataFilter_SetConvergence_36(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify a convergence criterion for the iteration
		/// process. Smaller numbers result in more smoothing iterations.
		/// </summary>
		// Token: 0x06019AF0 RID: 105200 RVA: 0x0023B4B3 File Offset: 0x002396B3
		public virtual void SetConvergence(double _arg)
		{
			vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_SetConvergence_36(base.GetCppThis(), _arg);
		}

		// Token: 0x06019AF1 RID: 105201
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSmoothPolyDataFilter_SetEdgeAngle_37(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the edge angle to control smoothing along edges (either interior
		/// or boundary).
		/// </summary>
		// Token: 0x06019AF2 RID: 105202 RVA: 0x0023B4C3 File Offset: 0x002396C3
		public virtual void SetEdgeAngle(double _arg)
		{
			vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_SetEdgeAngle_37(base.GetCppThis(), _arg);
		}

		// Token: 0x06019AF3 RID: 105203
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSmoothPolyDataFilter_SetFeatureAngle_38(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the feature angle for sharp edge identification.
		/// </summary>
		// Token: 0x06019AF4 RID: 105204 RVA: 0x0023B4D3 File Offset: 0x002396D3
		public virtual void SetFeatureAngle(double _arg)
		{
			vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_SetFeatureAngle_38(base.GetCppThis(), _arg);
		}

		// Token: 0x06019AF5 RID: 105205
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSmoothPolyDataFilter_SetFeatureEdgeSmoothing_39(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off smoothing along sharp interior edges.
		/// </summary>
		// Token: 0x06019AF6 RID: 105206 RVA: 0x0023B4E3 File Offset: 0x002396E3
		public virtual void SetFeatureEdgeSmoothing(int _arg)
		{
			vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_SetFeatureEdgeSmoothing_39(base.GetCppThis(), _arg);
		}

		// Token: 0x06019AF7 RID: 105207
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSmoothPolyDataFilter_SetGenerateErrorScalars_40(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the generation of scalar distance values.
		/// </summary>
		// Token: 0x06019AF8 RID: 105208 RVA: 0x0023B4F3 File Offset: 0x002396F3
		public virtual void SetGenerateErrorScalars(int _arg)
		{
			vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_SetGenerateErrorScalars_40(base.GetCppThis(), _arg);
		}

		// Token: 0x06019AF9 RID: 105209
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSmoothPolyDataFilter_SetGenerateErrorVectors_41(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the generation of error vectors.
		/// </summary>
		// Token: 0x06019AFA RID: 105210 RVA: 0x0023B503 File Offset: 0x00239703
		public virtual void SetGenerateErrorVectors(int _arg)
		{
			vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_SetGenerateErrorVectors_41(base.GetCppThis(), _arg);
		}

		// Token: 0x06019AFB RID: 105211
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSmoothPolyDataFilter_SetNumberOfIterations_42(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the number of iterations for Laplacian smoothing,
		/// </summary>
		// Token: 0x06019AFC RID: 105212 RVA: 0x0023B513 File Offset: 0x00239713
		public virtual void SetNumberOfIterations(int _arg)
		{
			vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_SetNumberOfIterations_42(base.GetCppThis(), _arg);
		}

		// Token: 0x06019AFD RID: 105213
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSmoothPolyDataFilter_SetOutputPointsPrecision_43(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06019AFE RID: 105214 RVA: 0x0023B523 File Offset: 0x00239723
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_SetOutputPointsPrecision_43(base.GetCppThis(), _arg);
		}

		// Token: 0x06019AFF RID: 105215
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSmoothPolyDataFilter_SetRelaxationFactor_44(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the relaxation factor for Laplacian smoothing. As in all
		/// iterative methods, the stability of the process is sensitive to
		/// this parameter. In general, small relaxation factors and large
		/// numbers of iterations are more stable than larger relaxation
		/// factors and smaller numbers of iterations.
		/// </summary>
		// Token: 0x06019B00 RID: 105216 RVA: 0x0023B533 File Offset: 0x00239733
		public virtual void SetRelaxationFactor(double _arg)
		{
			vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_SetRelaxationFactor_44(base.GetCppThis(), _arg);
		}

		// Token: 0x06019B01 RID: 105217
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSmoothPolyDataFilter_SetSourceData_45(HandleRef pThis, HandleRef source);

		/// <summary>
		/// Specify the source object which is used to constrain smoothing. The
		/// source defines a surface that the input (as it is smoothed) is
		/// constrained to lie upon.
		/// </summary>
		// Token: 0x06019B02 RID: 105218 RVA: 0x0023B544 File Offset: 0x00239744
		public void SetSourceData(vtkPolyData source)
		{
			vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_SetSourceData_45(base.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BFD RID: 7165
		public new const string MRFullTypeName = "Kitware.VTK.vtkSmoothPolyDataFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BFE RID: 7166
		public new static readonly string MRClassNameKey = "class vtkSmoothPolyDataFilter";
	}
}
