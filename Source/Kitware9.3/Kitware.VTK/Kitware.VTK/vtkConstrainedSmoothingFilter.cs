using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkConstrainedSmoothingFilter
	/// </summary>
	/// <remarks>
	///    adjust point positions using constrained smoothing
	///
	/// vtkConstrainedSmoothingFilter is a filter that adjusts point coordinates
	/// using a modified Laplacian smoothing approach. The effect is to "relax"
	/// or "smooth" the mesh, making the cells better shaped and the points more
	/// evenly distributed. Note that this filter operates on any vtkPointSet and
	/// derived classes. Cell topology is never modified; note however if the
	/// constraints are too lax, cells may self-intersect or otherwise be deformed
	/// in unfavorable ways.
	///
	/// A central concept of this filter is the point smoothing stencil. A
	/// smoothing stencil for a point pi is the list of points pj which connect to
	/// pi via an edge. To smooth the point pi, pi is moved towards the average
	/// position of pj multiplied by the relaxation factor, and limited by the
	/// constraint distance. This process is repeated either until convergence
	/// occurs, or the maximum number of iterations is reached. Note that
	/// smoothing stencils may be specified; or if not provided, the stencils are
	/// computed from the input cells connected edges (using vtkExtractEdges with
	/// UseAllPoints enabled).
	///
	/// To constrain the motion of the points, either set the filter's constraint
	/// distance or constraint box, or provide an input point data array (of type
	/// vtkDoubleArray) named "SmoothingConstraints." The filter's constraint
	/// distance (or constraint box if selected) defines a local sphere (or box)
	/// centered on each point to restrict point motion and is applied to all
	/// points; whereas the smoothing data array may have different constraint
	/// values per point. If provided by the user, by default the smoothing data
	/// array takes precedence over the filter's constraint distance and
	/// constraint box.
	///
	/// @warning
	/// The smoothing process reduces high frequency information in the geometry
	/// of the mesh. With excessive smoothing important details may be lost, and
	/// the surface may shrink towards the centroid. The constraints on point
	/// movement help significantly in preventing shrinkage from happening.
	///
	/// @warning
	/// This filter is used internally by the filters vtkSurfaceNets2D and
	/// vtkSurfaceNets3D. vtkConstrainedSmoothingFilter is used by these filters
	/// to smooth the extracted surface net, with the constraint distance and
	/// constraint box set in relation to a volume voxel.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkWindowedSincPolyDataFilter vtkSmoothPolyDataFilter
	/// vtkAttributeSmoothingFilter vtkExtractEdges vtkSurfaceNets2D
	/// vtkSurfaceNets3D
	/// </seealso>
	// Token: 0x0200094E RID: 2382
	public class vtkConstrainedSmoothingFilter : vtkPointSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06018B2E RID: 101166 RVA: 0x00227F6E File Offset: 0x0022616E
		static vtkConstrainedSmoothingFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkConstrainedSmoothingFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkConstrainedSmoothingFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06018B2F RID: 101167 RVA: 0x00227F96 File Offset: 0x00226196
		public vtkConstrainedSmoothingFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06018B30 RID: 101168
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConstrainedSmoothingFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, to obtain type information, and
		/// print the state of a class instance.
		/// </summary>
		// Token: 0x06018B31 RID: 101169 RVA: 0x00227FA4 File Offset: 0x002261A4
		public new static vtkConstrainedSmoothingFilter New()
		{
			vtkConstrainedSmoothingFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConstrainedSmoothingFilter.vtkConstrainedSmoothingFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkConstrainedSmoothingFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, to obtain type information, and
		/// print the state of a class instance.
		/// </summary>
		// Token: 0x06018B32 RID: 101170 RVA: 0x00227FF8 File Offset: 0x002261F8
		public vtkConstrainedSmoothingFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkConstrainedSmoothingFilter.vtkConstrainedSmoothingFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06018B33 RID: 101171 RVA: 0x0022803C File Offset: 0x0022623C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06018B34 RID: 101172
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrainedSmoothingFilter_GenerateErrorScalarsOff_01(HandleRef pThis);

		/// <summary>
		/// Turn on/off the generation of scalar distance values. By default, the
		/// generation of error scalars is disabled.
		/// </summary>
		// Token: 0x06018B35 RID: 101173 RVA: 0x00228047 File Offset: 0x00226247
		public virtual void GenerateErrorScalarsOff()
		{
			vtkConstrainedSmoothingFilter.vtkConstrainedSmoothingFilter_GenerateErrorScalarsOff_01(base.GetCppThis());
		}

		// Token: 0x06018B36 RID: 101174
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrainedSmoothingFilter_GenerateErrorScalarsOn_02(HandleRef pThis);

		/// <summary>
		/// Turn on/off the generation of scalar distance values. By default, the
		/// generation of error scalars is disabled.
		/// </summary>
		// Token: 0x06018B37 RID: 101175 RVA: 0x00228056 File Offset: 0x00226256
		public virtual void GenerateErrorScalarsOn()
		{
			vtkConstrainedSmoothingFilter.vtkConstrainedSmoothingFilter_GenerateErrorScalarsOn_02(base.GetCppThis());
		}

		// Token: 0x06018B38 RID: 101176
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrainedSmoothingFilter_GenerateErrorVectorsOff_03(HandleRef pThis);

		/// <summary>
		/// Turn on/off the generation of error vectors. By default, the generation
		/// of error vectors is disabled.
		/// </summary>
		// Token: 0x06018B39 RID: 101177 RVA: 0x00228065 File Offset: 0x00226265
		public virtual void GenerateErrorVectorsOff()
		{
			vtkConstrainedSmoothingFilter.vtkConstrainedSmoothingFilter_GenerateErrorVectorsOff_03(base.GetCppThis());
		}

		// Token: 0x06018B3A RID: 101178
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrainedSmoothingFilter_GenerateErrorVectorsOn_04(HandleRef pThis);

		/// <summary>
		/// Turn on/off the generation of error vectors. By default, the generation
		/// of error vectors is disabled.
		/// </summary>
		// Token: 0x06018B3B RID: 101179 RVA: 0x00228074 File Offset: 0x00226274
		public virtual void GenerateErrorVectorsOn()
		{
			vtkConstrainedSmoothingFilter.vtkConstrainedSmoothingFilter_GenerateErrorVectorsOn_04(base.GetCppThis());
		}

		// Token: 0x06018B3C RID: 101180
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConstrainedSmoothingFilter_GetConstraintBox_05(HandleRef pThis);

		/// <summary>
		/// Specify a constraint box for point motion. By default, if a point data
		/// array constraint distance (named "SmoothingConstraints") is provided in
		/// the input point data, then the array takes precedence. By default, the
		/// constraint box is (1,1,1). Setting the constraint strategy to
		/// CONSTRAINT_BOX forces the box to be used.
		/// </summary>
		// Token: 0x06018B3D RID: 101181 RVA: 0x00228084 File Offset: 0x00226284
		public virtual double[] GetConstraintBox()
		{
			IntPtr intPtr = vtkConstrainedSmoothingFilter.vtkConstrainedSmoothingFilter_GetConstraintBox_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06018B3E RID: 101182
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrainedSmoothingFilter_GetConstraintBox_06(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify a constraint box for point motion. By default, if a point data
		/// array constraint distance (named "SmoothingConstraints") is provided in
		/// the input point data, then the array takes precedence. By default, the
		/// constraint box is (1,1,1). Setting the constraint strategy to
		/// CONSTRAINT_BOX forces the box to be used.
		/// </summary>
		// Token: 0x06018B3F RID: 101183 RVA: 0x002280CC File Offset: 0x002262CC
		public virtual void GetConstraintBox(IntPtr data)
		{
			vtkConstrainedSmoothingFilter.vtkConstrainedSmoothingFilter_GetConstraintBox_06(base.GetCppThis(), data);
		}

		// Token: 0x06018B40 RID: 101184
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkConstrainedSmoothingFilter_GetConstraintDistance_07(HandleRef pThis);

		/// <summary>
		/// Specify a constraint distance for point motion (this defines a a local
		/// constraint sphere which is placed around each point to restrict its
		/// motion). By default, if a point data array constraint distance (named
		/// "SmoothingConstraints") is provided in the input point data, then the
		/// array takes precedence. By default, the constraint distance is
		/// 0.001. Setting the constraint strategy to CONSTRAINT_DISTANCE forces the
		/// box to be used.
		/// </summary>
		// Token: 0x06018B41 RID: 101185 RVA: 0x002280DC File Offset: 0x002262DC
		public virtual double GetConstraintDistance()
		{
			return vtkConstrainedSmoothingFilter.vtkConstrainedSmoothingFilter_GetConstraintDistance_07(base.GetCppThis());
		}

		// Token: 0x06018B42 RID: 101186
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkConstrainedSmoothingFilter_GetConstraintDistanceMaxValue_08(HandleRef pThis);

		/// <summary>
		/// Specify a constraint distance for point motion (this defines a a local
		/// constraint sphere which is placed around each point to restrict its
		/// motion). By default, if a point data array constraint distance (named
		/// "SmoothingConstraints") is provided in the input point data, then the
		/// array takes precedence. By default, the constraint distance is
		/// 0.001. Setting the constraint strategy to CONSTRAINT_DISTANCE forces the
		/// box to be used.
		/// </summary>
		// Token: 0x06018B43 RID: 101187 RVA: 0x002280FC File Offset: 0x002262FC
		public virtual double GetConstraintDistanceMaxValue()
		{
			return vtkConstrainedSmoothingFilter.vtkConstrainedSmoothingFilter_GetConstraintDistanceMaxValue_08(base.GetCppThis());
		}

		// Token: 0x06018B44 RID: 101188
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkConstrainedSmoothingFilter_GetConstraintDistanceMinValue_09(HandleRef pThis);

		/// <summary>
		/// Specify a constraint distance for point motion (this defines a a local
		/// constraint sphere which is placed around each point to restrict its
		/// motion). By default, if a point data array constraint distance (named
		/// "SmoothingConstraints") is provided in the input point data, then the
		/// array takes precedence. By default, the constraint distance is
		/// 0.001. Setting the constraint strategy to CONSTRAINT_DISTANCE forces the
		/// box to be used.
		/// </summary>
		// Token: 0x06018B45 RID: 101189 RVA: 0x0022811C File Offset: 0x0022631C
		public virtual double GetConstraintDistanceMinValue()
		{
			return vtkConstrainedSmoothingFilter.vtkConstrainedSmoothingFilter_GetConstraintDistanceMinValue_09(base.GetCppThis());
		}

		// Token: 0x06018B46 RID: 101190
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConstrainedSmoothingFilter_GetConstraintStrategy_10(HandleRef pThis);

		/// <summary>
		/// Indicate how to apply constraints. By default, a constraint array takes
		/// precedence over the filter's constraint distance or constraint box, but
		/// if not available then the constraint distance is used. If a
		/// CONSTRAINT_ARRAY strategy is specified, and no constraint array is
		/// available from the point data, then the points are unconstrained. If the
		/// strategy is set to CONSTRAINT_DISTANCE, then a constraint sphere defined
		/// by ConstraintDistance is used; while setting the strategy to
		/// CONSTRAINT_BOX an axis-aligned x-y-z box is used to constrain point
		/// motion (using constraint distance is slightly faster than using a
		/// constraint box). Note that is also possible to turn off constraints
		/// completely by simply specifying a very large constraint distance. The
		/// default constraint strategy is DEFAULT.
		/// </summary>
		// Token: 0x06018B47 RID: 101191 RVA: 0x0022813C File Offset: 0x0022633C
		public virtual int GetConstraintStrategy()
		{
			return vtkConstrainedSmoothingFilter.vtkConstrainedSmoothingFilter_GetConstraintStrategy_10(base.GetCppThis());
		}

		// Token: 0x06018B48 RID: 101192
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConstrainedSmoothingFilter_GetConstraintStrategyMaxValue_11(HandleRef pThis);

		/// <summary>
		/// Indicate how to apply constraints. By default, a constraint array takes
		/// precedence over the filter's constraint distance or constraint box, but
		/// if not available then the constraint distance is used. If a
		/// CONSTRAINT_ARRAY strategy is specified, and no constraint array is
		/// available from the point data, then the points are unconstrained. If the
		/// strategy is set to CONSTRAINT_DISTANCE, then a constraint sphere defined
		/// by ConstraintDistance is used; while setting the strategy to
		/// CONSTRAINT_BOX an axis-aligned x-y-z box is used to constrain point
		/// motion (using constraint distance is slightly faster than using a
		/// constraint box). Note that is also possible to turn off constraints
		/// completely by simply specifying a very large constraint distance. The
		/// default constraint strategy is DEFAULT.
		/// </summary>
		// Token: 0x06018B49 RID: 101193 RVA: 0x0022815C File Offset: 0x0022635C
		public virtual int GetConstraintStrategyMaxValue()
		{
			return vtkConstrainedSmoothingFilter.vtkConstrainedSmoothingFilter_GetConstraintStrategyMaxValue_11(base.GetCppThis());
		}

		// Token: 0x06018B4A RID: 101194
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConstrainedSmoothingFilter_GetConstraintStrategyMinValue_12(HandleRef pThis);

		/// <summary>
		/// Indicate how to apply constraints. By default, a constraint array takes
		/// precedence over the filter's constraint distance or constraint box, but
		/// if not available then the constraint distance is used. If a
		/// CONSTRAINT_ARRAY strategy is specified, and no constraint array is
		/// available from the point data, then the points are unconstrained. If the
		/// strategy is set to CONSTRAINT_DISTANCE, then a constraint sphere defined
		/// by ConstraintDistance is used; while setting the strategy to
		/// CONSTRAINT_BOX an axis-aligned x-y-z box is used to constrain point
		/// motion (using constraint distance is slightly faster than using a
		/// constraint box). Note that is also possible to turn off constraints
		/// completely by simply specifying a very large constraint distance. The
		/// default constraint strategy is DEFAULT.
		/// </summary>
		// Token: 0x06018B4B RID: 101195 RVA: 0x0022817C File Offset: 0x0022637C
		public virtual int GetConstraintStrategyMinValue()
		{
			return vtkConstrainedSmoothingFilter.vtkConstrainedSmoothingFilter_GetConstraintStrategyMinValue_12(base.GetCppThis());
		}

		// Token: 0x06018B4C RID: 101196
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkConstrainedSmoothingFilter_GetConvergence_13(HandleRef pThis);

		/// <summary>
		/// Specify a convergence criterion for the iteration process. Smaller
		/// numbers result in more smoothing iterations. Convergence occurs
		/// when, for the current iteration, the maximum distance any point moves
		/// is less than or equal to Convergence. The default value is 0.
		/// </summary>
		// Token: 0x06018B4D RID: 101197 RVA: 0x0022819C File Offset: 0x0022639C
		public virtual double GetConvergence()
		{
			return vtkConstrainedSmoothingFilter.vtkConstrainedSmoothingFilter_GetConvergence_13(base.GetCppThis());
		}

		// Token: 0x06018B4E RID: 101198
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkConstrainedSmoothingFilter_GetConvergenceMaxValue_14(HandleRef pThis);

		/// <summary>
		/// Specify a convergence criterion for the iteration process. Smaller
		/// numbers result in more smoothing iterations. Convergence occurs
		/// when, for the current iteration, the maximum distance any point moves
		/// is less than or equal to Convergence. The default value is 0.
		/// </summary>
		// Token: 0x06018B4F RID: 101199 RVA: 0x002281BC File Offset: 0x002263BC
		public virtual double GetConvergenceMaxValue()
		{
			return vtkConstrainedSmoothingFilter.vtkConstrainedSmoothingFilter_GetConvergenceMaxValue_14(base.GetCppThis());
		}

		// Token: 0x06018B50 RID: 101200
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkConstrainedSmoothingFilter_GetConvergenceMinValue_15(HandleRef pThis);

		/// <summary>
		/// Specify a convergence criterion for the iteration process. Smaller
		/// numbers result in more smoothing iterations. Convergence occurs
		/// when, for the current iteration, the maximum distance any point moves
		/// is less than or equal to Convergence. The default value is 0.
		/// </summary>
		// Token: 0x06018B51 RID: 101201 RVA: 0x002281DC File Offset: 0x002263DC
		public virtual double GetConvergenceMinValue()
		{
			return vtkConstrainedSmoothingFilter.vtkConstrainedSmoothingFilter_GetConvergenceMinValue_15(base.GetCppThis());
		}

		// Token: 0x06018B52 RID: 101202
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkConstrainedSmoothingFilter_GetGenerateErrorScalars_16(HandleRef pThis);

		/// <summary>
		/// Turn on/off the generation of scalar distance values. By default, the
		/// generation of error scalars is disabled.
		/// </summary>
		// Token: 0x06018B53 RID: 101203 RVA: 0x002281FC File Offset: 0x002263FC
		public virtual bool GetGenerateErrorScalars()
		{
			return vtkConstrainedSmoothingFilter.vtkConstrainedSmoothingFilter_GetGenerateErrorScalars_16(base.GetCppThis()) != 0;
		}

		// Token: 0x06018B54 RID: 101204
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkConstrainedSmoothingFilter_GetGenerateErrorVectors_17(HandleRef pThis);

		/// <summary>
		/// Turn on/off the generation of error vectors. By default, the generation
		/// of error vectors is disabled.
		/// </summary>
		// Token: 0x06018B55 RID: 101205 RVA: 0x00228224 File Offset: 0x00226424
		public virtual bool GetGenerateErrorVectors()
		{
			return vtkConstrainedSmoothingFilter.vtkConstrainedSmoothingFilter_GetGenerateErrorVectors_17(base.GetCppThis()) != 0;
		}

		// Token: 0x06018B56 RID: 101206
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkConstrainedSmoothingFilter_GetNumberOfGenerationsFromBase_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, to obtain type information, and
		/// print the state of a class instance.
		/// </summary>
		// Token: 0x06018B57 RID: 101207 RVA: 0x0022824C File Offset: 0x0022644C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkConstrainedSmoothingFilter.vtkConstrainedSmoothingFilter_GetNumberOfGenerationsFromBase_18(base.GetCppThis(), type);
		}

		// Token: 0x06018B58 RID: 101208
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkConstrainedSmoothingFilter_GetNumberOfGenerationsFromBaseType_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, to obtain type information, and
		/// print the state of a class instance.
		/// </summary>
		// Token: 0x06018B59 RID: 101209 RVA: 0x0022826C File Offset: 0x0022646C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkConstrainedSmoothingFilter.vtkConstrainedSmoothingFilter_GetNumberOfGenerationsFromBaseType_19(type);
		}

		// Token: 0x06018B5A RID: 101210
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConstrainedSmoothingFilter_GetNumberOfIterations_20(HandleRef pThis);

		/// <summary>
		/// Specify the maximum number of iterations for smoothing. The number
		/// of iterations may be less if the smoothing process converges. The
		/// default value is 10.
		/// </summary>
		// Token: 0x06018B5B RID: 101211 RVA: 0x00228288 File Offset: 0x00226488
		public virtual int GetNumberOfIterations()
		{
			return vtkConstrainedSmoothingFilter.vtkConstrainedSmoothingFilter_GetNumberOfIterations_20(base.GetCppThis());
		}

		// Token: 0x06018B5C RID: 101212
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConstrainedSmoothingFilter_GetNumberOfIterationsMaxValue_21(HandleRef pThis);

		/// <summary>
		/// Specify the maximum number of iterations for smoothing. The number
		/// of iterations may be less if the smoothing process converges. The
		/// default value is 10.
		/// </summary>
		// Token: 0x06018B5D RID: 101213 RVA: 0x002282A8 File Offset: 0x002264A8
		public virtual int GetNumberOfIterationsMaxValue()
		{
			return vtkConstrainedSmoothingFilter.vtkConstrainedSmoothingFilter_GetNumberOfIterationsMaxValue_21(base.GetCppThis());
		}

		// Token: 0x06018B5E RID: 101214
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConstrainedSmoothingFilter_GetNumberOfIterationsMinValue_22(HandleRef pThis);

		/// <summary>
		/// Specify the maximum number of iterations for smoothing. The number
		/// of iterations may be less if the smoothing process converges. The
		/// default value is 10.
		/// </summary>
		// Token: 0x06018B5F RID: 101215 RVA: 0x002282C8 File Offset: 0x002264C8
		public virtual int GetNumberOfIterationsMinValue()
		{
			return vtkConstrainedSmoothingFilter.vtkConstrainedSmoothingFilter_GetNumberOfIterationsMinValue_22(base.GetCppThis());
		}

		// Token: 0x06018B60 RID: 101216
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConstrainedSmoothingFilter_GetOutputPointsPrecision_23(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06018B61 RID: 101217 RVA: 0x002282E8 File Offset: 0x002264E8
		public virtual int GetOutputPointsPrecision()
		{
			return vtkConstrainedSmoothingFilter.vtkConstrainedSmoothingFilter_GetOutputPointsPrecision_23(base.GetCppThis());
		}

		// Token: 0x06018B62 RID: 101218
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkConstrainedSmoothingFilter_GetRelaxationFactor_24(HandleRef pThis);

		/// <summary>
		/// Specify the relaxation factor for smoothing. As in all iterative
		/// methods, the stability of the process is sensitive to this parameter. In
		/// general, small relaxation factors and large numbers of iterations are
		/// more stable than larger relaxation factors and smaller numbers of
		/// iterations. The default value is 0.01.
		/// </summary>
		// Token: 0x06018B63 RID: 101219 RVA: 0x00228308 File Offset: 0x00226508
		public virtual double GetRelaxationFactor()
		{
			return vtkConstrainedSmoothingFilter.vtkConstrainedSmoothingFilter_GetRelaxationFactor_24(base.GetCppThis());
		}

		// Token: 0x06018B64 RID: 101220
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConstrainedSmoothingFilter_GetSmoothingStencils_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set / get the point smoothing stencils. Here we are repurposing a cell
		/// array to define stencils. Basically what's happening is that each point
		/// is treated a "cell" connected to a list of point ids (i.e., the
		/// "stencil") that defines the smoothing edge connections. By default, no
		/// smoothing stencils are defined.
		/// </summary>
		// Token: 0x06018B65 RID: 101221 RVA: 0x00228328 File Offset: 0x00226528
		public virtual vtkCellArray GetSmoothingStencils()
		{
			vtkCellArray vtkCellArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConstrainedSmoothingFilter.vtkConstrainedSmoothingFilter_GetSmoothingStencils_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellArray = (vtkCellArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellArray.Register(null);
				}
			}
			return vtkCellArray;
		}

		// Token: 0x06018B66 RID: 101222
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConstrainedSmoothingFilter_IsA_26(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, to obtain type information, and
		/// print the state of a class instance.
		/// </summary>
		// Token: 0x06018B67 RID: 101223 RVA: 0x00228398 File Offset: 0x00226598
		public override int IsA(string type)
		{
			return vtkConstrainedSmoothingFilter.vtkConstrainedSmoothingFilter_IsA_26(base.GetCppThis(), type);
		}

		// Token: 0x06018B68 RID: 101224
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConstrainedSmoothingFilter_IsTypeOf_27([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, to obtain type information, and
		/// print the state of a class instance.
		/// </summary>
		// Token: 0x06018B69 RID: 101225 RVA: 0x002283B8 File Offset: 0x002265B8
		public new static int IsTypeOf(string type)
		{
			return vtkConstrainedSmoothingFilter.vtkConstrainedSmoothingFilter_IsTypeOf_27(type);
		}

		// Token: 0x06018B6A RID: 101226
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConstrainedSmoothingFilter_NewInstance_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, to obtain type information, and
		/// print the state of a class instance.
		/// </summary>
		// Token: 0x06018B6B RID: 101227 RVA: 0x002283D4 File Offset: 0x002265D4
		public new vtkConstrainedSmoothingFilter NewInstance()
		{
			vtkConstrainedSmoothingFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConstrainedSmoothingFilter.vtkConstrainedSmoothingFilter_NewInstance_29(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkConstrainedSmoothingFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06018B6C RID: 101228
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConstrainedSmoothingFilter_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, to obtain type information, and
		/// print the state of a class instance.
		/// </summary>
		// Token: 0x06018B6D RID: 101229 RVA: 0x00228430 File Offset: 0x00226630
		public new static vtkConstrainedSmoothingFilter SafeDownCast(vtkObjectBase o)
		{
			vtkConstrainedSmoothingFilter vtkConstrainedSmoothingFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConstrainedSmoothingFilter.vtkConstrainedSmoothingFilter_SafeDownCast_30((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06018B6E RID: 101230
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrainedSmoothingFilter_SetConstraintBox_31(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Specify a constraint box for point motion. By default, if a point data
		/// array constraint distance (named "SmoothingConstraints") is provided in
		/// the input point data, then the array takes precedence. By default, the
		/// constraint box is (1,1,1). Setting the constraint strategy to
		/// CONSTRAINT_BOX forces the box to be used.
		/// </summary>
		// Token: 0x06018B6F RID: 101231 RVA: 0x002284AF File Offset: 0x002266AF
		public virtual void SetConstraintBox(double _arg1, double _arg2, double _arg3)
		{
			vtkConstrainedSmoothingFilter.vtkConstrainedSmoothingFilter_SetConstraintBox_31(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06018B70 RID: 101232
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrainedSmoothingFilter_SetConstraintBox_32(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify a constraint box for point motion. By default, if a point data
		/// array constraint distance (named "SmoothingConstraints") is provided in
		/// the input point data, then the array takes precedence. By default, the
		/// constraint box is (1,1,1). Setting the constraint strategy to
		/// CONSTRAINT_BOX forces the box to be used.
		/// </summary>
		// Token: 0x06018B71 RID: 101233 RVA: 0x002284C1 File Offset: 0x002266C1
		public virtual void SetConstraintBox(IntPtr _arg)
		{
			vtkConstrainedSmoothingFilter.vtkConstrainedSmoothingFilter_SetConstraintBox_32(base.GetCppThis(), _arg);
		}

		// Token: 0x06018B72 RID: 101234
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrainedSmoothingFilter_SetConstraintDistance_33(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify a constraint distance for point motion (this defines a a local
		/// constraint sphere which is placed around each point to restrict its
		/// motion). By default, if a point data array constraint distance (named
		/// "SmoothingConstraints") is provided in the input point data, then the
		/// array takes precedence. By default, the constraint distance is
		/// 0.001. Setting the constraint strategy to CONSTRAINT_DISTANCE forces the
		/// box to be used.
		/// </summary>
		// Token: 0x06018B73 RID: 101235 RVA: 0x002284D1 File Offset: 0x002266D1
		public virtual void SetConstraintDistance(double _arg)
		{
			vtkConstrainedSmoothingFilter.vtkConstrainedSmoothingFilter_SetConstraintDistance_33(base.GetCppThis(), _arg);
		}

		// Token: 0x06018B74 RID: 101236
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrainedSmoothingFilter_SetConstraintStrategy_34(HandleRef pThis, int _arg);

		/// <summary>
		/// Indicate how to apply constraints. By default, a constraint array takes
		/// precedence over the filter's constraint distance or constraint box, but
		/// if not available then the constraint distance is used. If a
		/// CONSTRAINT_ARRAY strategy is specified, and no constraint array is
		/// available from the point data, then the points are unconstrained. If the
		/// strategy is set to CONSTRAINT_DISTANCE, then a constraint sphere defined
		/// by ConstraintDistance is used; while setting the strategy to
		/// CONSTRAINT_BOX an axis-aligned x-y-z box is used to constrain point
		/// motion (using constraint distance is slightly faster than using a
		/// constraint box). Note that is also possible to turn off constraints
		/// completely by simply specifying a very large constraint distance. The
		/// default constraint strategy is DEFAULT.
		/// </summary>
		// Token: 0x06018B75 RID: 101237 RVA: 0x002284E1 File Offset: 0x002266E1
		public virtual void SetConstraintStrategy(int _arg)
		{
			vtkConstrainedSmoothingFilter.vtkConstrainedSmoothingFilter_SetConstraintStrategy_34(base.GetCppThis(), _arg);
		}

		// Token: 0x06018B76 RID: 101238
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrainedSmoothingFilter_SetConstraintStrategyToConstraintArray_35(HandleRef pThis);

		/// <summary>
		/// Indicate how to apply constraints. By default, a constraint array takes
		/// precedence over the filter's constraint distance or constraint box, but
		/// if not available then the constraint distance is used. If a
		/// CONSTRAINT_ARRAY strategy is specified, and no constraint array is
		/// available from the point data, then the points are unconstrained. If the
		/// strategy is set to CONSTRAINT_DISTANCE, then a constraint sphere defined
		/// by ConstraintDistance is used; while setting the strategy to
		/// CONSTRAINT_BOX an axis-aligned x-y-z box is used to constrain point
		/// motion (using constraint distance is slightly faster than using a
		/// constraint box). Note that is also possible to turn off constraints
		/// completely by simply specifying a very large constraint distance. The
		/// default constraint strategy is DEFAULT.
		/// </summary>
		// Token: 0x06018B77 RID: 101239 RVA: 0x002284F1 File Offset: 0x002266F1
		public void SetConstraintStrategyToConstraintArray()
		{
			vtkConstrainedSmoothingFilter.vtkConstrainedSmoothingFilter_SetConstraintStrategyToConstraintArray_35(base.GetCppThis());
		}

		// Token: 0x06018B78 RID: 101240
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrainedSmoothingFilter_SetConstraintStrategyToConstraintBox_36(HandleRef pThis);

		/// <summary>
		/// Indicate how to apply constraints. By default, a constraint array takes
		/// precedence over the filter's constraint distance or constraint box, but
		/// if not available then the constraint distance is used. If a
		/// CONSTRAINT_ARRAY strategy is specified, and no constraint array is
		/// available from the point data, then the points are unconstrained. If the
		/// strategy is set to CONSTRAINT_DISTANCE, then a constraint sphere defined
		/// by ConstraintDistance is used; while setting the strategy to
		/// CONSTRAINT_BOX an axis-aligned x-y-z box is used to constrain point
		/// motion (using constraint distance is slightly faster than using a
		/// constraint box). Note that is also possible to turn off constraints
		/// completely by simply specifying a very large constraint distance. The
		/// default constraint strategy is DEFAULT.
		/// </summary>
		// Token: 0x06018B79 RID: 101241 RVA: 0x00228500 File Offset: 0x00226700
		public void SetConstraintStrategyToConstraintBox()
		{
			vtkConstrainedSmoothingFilter.vtkConstrainedSmoothingFilter_SetConstraintStrategyToConstraintBox_36(base.GetCppThis());
		}

		// Token: 0x06018B7A RID: 101242
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrainedSmoothingFilter_SetConstraintStrategyToConstraintDistance_37(HandleRef pThis);

		/// <summary>
		/// Indicate how to apply constraints. By default, a constraint array takes
		/// precedence over the filter's constraint distance or constraint box, but
		/// if not available then the constraint distance is used. If a
		/// CONSTRAINT_ARRAY strategy is specified, and no constraint array is
		/// available from the point data, then the points are unconstrained. If the
		/// strategy is set to CONSTRAINT_DISTANCE, then a constraint sphere defined
		/// by ConstraintDistance is used; while setting the strategy to
		/// CONSTRAINT_BOX an axis-aligned x-y-z box is used to constrain point
		/// motion (using constraint distance is slightly faster than using a
		/// constraint box). Note that is also possible to turn off constraints
		/// completely by simply specifying a very large constraint distance. The
		/// default constraint strategy is DEFAULT.
		/// </summary>
		// Token: 0x06018B7B RID: 101243 RVA: 0x0022850F File Offset: 0x0022670F
		public void SetConstraintStrategyToConstraintDistance()
		{
			vtkConstrainedSmoothingFilter.vtkConstrainedSmoothingFilter_SetConstraintStrategyToConstraintDistance_37(base.GetCppThis());
		}

		// Token: 0x06018B7C RID: 101244
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrainedSmoothingFilter_SetConstraintStrategyToDefault_38(HandleRef pThis);

		/// <summary>
		/// Indicate how to apply constraints. By default, a constraint array takes
		/// precedence over the filter's constraint distance or constraint box, but
		/// if not available then the constraint distance is used. If a
		/// CONSTRAINT_ARRAY strategy is specified, and no constraint array is
		/// available from the point data, then the points are unconstrained. If the
		/// strategy is set to CONSTRAINT_DISTANCE, then a constraint sphere defined
		/// by ConstraintDistance is used; while setting the strategy to
		/// CONSTRAINT_BOX an axis-aligned x-y-z box is used to constrain point
		/// motion (using constraint distance is slightly faster than using a
		/// constraint box). Note that is also possible to turn off constraints
		/// completely by simply specifying a very large constraint distance. The
		/// default constraint strategy is DEFAULT.
		/// </summary>
		// Token: 0x06018B7D RID: 101245 RVA: 0x0022851E File Offset: 0x0022671E
		public void SetConstraintStrategyToDefault()
		{
			vtkConstrainedSmoothingFilter.vtkConstrainedSmoothingFilter_SetConstraintStrategyToDefault_38(base.GetCppThis());
		}

		// Token: 0x06018B7E RID: 101246
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrainedSmoothingFilter_SetConvergence_39(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify a convergence criterion for the iteration process. Smaller
		/// numbers result in more smoothing iterations. Convergence occurs
		/// when, for the current iteration, the maximum distance any point moves
		/// is less than or equal to Convergence. The default value is 0.
		/// </summary>
		// Token: 0x06018B7F RID: 101247 RVA: 0x0022852D File Offset: 0x0022672D
		public virtual void SetConvergence(double _arg)
		{
			vtkConstrainedSmoothingFilter.vtkConstrainedSmoothingFilter_SetConvergence_39(base.GetCppThis(), _arg);
		}

		// Token: 0x06018B80 RID: 101248
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrainedSmoothingFilter_SetGenerateErrorScalars_40(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on/off the generation of scalar distance values. By default, the
		/// generation of error scalars is disabled.
		/// </summary>
		// Token: 0x06018B81 RID: 101249 RVA: 0x0022853D File Offset: 0x0022673D
		public virtual void SetGenerateErrorScalars(bool _arg)
		{
			vtkConstrainedSmoothingFilter.vtkConstrainedSmoothingFilter_SetGenerateErrorScalars_40(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06018B82 RID: 101250
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrainedSmoothingFilter_SetGenerateErrorVectors_41(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on/off the generation of error vectors. By default, the generation
		/// of error vectors is disabled.
		/// </summary>
		// Token: 0x06018B83 RID: 101251 RVA: 0x00228555 File Offset: 0x00226755
		public virtual void SetGenerateErrorVectors(bool _arg)
		{
			vtkConstrainedSmoothingFilter.vtkConstrainedSmoothingFilter_SetGenerateErrorVectors_41(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06018B84 RID: 101252
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrainedSmoothingFilter_SetNumberOfIterations_42(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the maximum number of iterations for smoothing. The number
		/// of iterations may be less if the smoothing process converges. The
		/// default value is 10.
		/// </summary>
		// Token: 0x06018B85 RID: 101253 RVA: 0x0022856D File Offset: 0x0022676D
		public virtual void SetNumberOfIterations(int _arg)
		{
			vtkConstrainedSmoothingFilter.vtkConstrainedSmoothingFilter_SetNumberOfIterations_42(base.GetCppThis(), _arg);
		}

		// Token: 0x06018B86 RID: 101254
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrainedSmoothingFilter_SetOutputPointsPrecision_43(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06018B87 RID: 101255 RVA: 0x0022857D File Offset: 0x0022677D
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkConstrainedSmoothingFilter.vtkConstrainedSmoothingFilter_SetOutputPointsPrecision_43(base.GetCppThis(), _arg);
		}

		// Token: 0x06018B88 RID: 101256
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrainedSmoothingFilter_SetRelaxationFactor_44(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the relaxation factor for smoothing. As in all iterative
		/// methods, the stability of the process is sensitive to this parameter. In
		/// general, small relaxation factors and large numbers of iterations are
		/// more stable than larger relaxation factors and smaller numbers of
		/// iterations. The default value is 0.01.
		/// </summary>
		// Token: 0x06018B89 RID: 101257 RVA: 0x0022858D File Offset: 0x0022678D
		public virtual void SetRelaxationFactor(double _arg)
		{
			vtkConstrainedSmoothingFilter.vtkConstrainedSmoothingFilter_SetRelaxationFactor_44(base.GetCppThis(), _arg);
		}

		// Token: 0x06018B8A RID: 101258
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrainedSmoothingFilter_SetSmoothingStencils_45(HandleRef pThis, HandleRef _arg);

		/// <summary>
		/// Set / get the point smoothing stencils. Here we are repurposing a cell
		/// array to define stencils. Basically what's happening is that each point
		/// is treated a "cell" connected to a list of point ids (i.e., the
		/// "stencil") that defines the smoothing edge connections. By default, no
		/// smoothing stencils are defined.
		/// </summary>
		// Token: 0x06018B8B RID: 101259 RVA: 0x002285A0 File Offset: 0x002267A0
		public virtual void SetSmoothingStencils(vtkCellArray _arg)
		{
			vtkConstrainedSmoothingFilter.vtkConstrainedSmoothingFilter_SetSmoothingStencils_45(base.GetCppThis(), (_arg == null) ? default(HandleRef) : _arg.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B52 RID: 6994
		public new const string MRFullTypeName = "Kitware.VTK.vtkConstrainedSmoothingFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B53 RID: 6995
		public new static readonly string MRClassNameKey = "class vtkConstrainedSmoothingFilter";

		/// <summary>
		/// Specify the relaxation factor for smoothing. As in all iterative
		/// methods, the stability of the process is sensitive to this parameter. In
		/// general, small relaxation factors and large numbers of iterations are
		/// more stable than larger relaxation factors and smaller numbers of
		/// iterations. The default value is 0.01.
		/// </summary>
		// Token: 0x0200094F RID: 2383
		public enum ConstraintStrategyType
		{
			/// <summary>enum member</summary>
			// Token: 0x04001B55 RID: 6997
			CONSTRAINT_ARRAY = 3,
			/// <summary>enum member</summary>
			// Token: 0x04001B56 RID: 6998
			CONSTRAINT_BOX = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001B57 RID: 6999
			CONSTRAINT_DISTANCE = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001B58 RID: 7000
			DEFAULT = 0
		}
	}
}
