using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkEvenlySpacedStreamlines2D
	/// </summary>
	/// <remarks>
	///    Evenly spaced streamline generator for 2D.
	///
	/// vtkEvenlySpacedStreamlines2D is a filter that integrates a 2D
	/// vector field to generate evenly-spaced streamlines.
	///
	/// We implement
	/// the algorithm described in:
	/// Jobard, Bruno, and Wilfrid Lefer. "Creating evenly-spaced
	/// streamlines of arbitrary density." Visualization in Scientific
	/// Computing '97. Springer Vienna, 1997. 43-55.
	/// The loop detection is described in:
	/// Liu, Zhanping, Robert Moorhead, and Joe Groner.
	/// "An advanced evenly-spaced streamline placement algorithm."
	/// IEEE Transactions on Visualization and Computer Graphics 12.5 (2006): 965-972.
	///
	/// The integration is performed using a specified integrator,
	/// by default Runge-Kutta2.
	///
	/// vtkEvenlySpacedStreamlines2D produces polylines as the output, with
	/// each cell (i.e., polyline) representing a streamline. The attribute
	/// values associated with each streamline are stored in the cell data,
	/// whereas those associated with streamline-points are stored in the
	/// point data.
	///
	/// vtkEvenlySpacedStreamlines2D integrates streamlines both forward
	/// and backward. The integration for a streamline terminates upon
	/// exiting the flow field domain, or if the particle speed is reduced
	/// to a value less than a specified terminal speed, if the current
	/// streamline gets too close to other streamlines
	/// (vtkStreamTracer::FIXED_REASONS_FOR_TERMINATION_COUNT + 1) or if
	/// the streamline forms a loop
	/// (vtkStreamTracer::FIXED_REASONS_FOR_TERMINATION_COUNT). The
	/// specific reason for the termination is stored in a cell array named
	/// ReasonForTermination.
	///
	/// Note that normalized vectors are adopted in streamline integration,
	/// which achieves high numerical accuracy/smoothness of flow lines that is
	/// particularly guaranteed for Runge-Kutta45 with adaptive step size and
	/// error control). In support of this feature, the underlying step size is
	/// ALWAYS in arc length unit (LENGTH_UNIT) while the 'real' time interval
	/// (virtual for steady flows) that a particle actually takes to trave in a
	/// single step is obtained by dividing the arc length by the LOCAL speed.
	/// The overall elapsed time (i.e., the life span) of the particle is the
	/// sum of those individual step-wise time intervals.
	///
	/// The quality of streamline integration can be controlled by setting
	/// the initial integration step (InitialIntegrationStep), particularly
	/// for Runge-Kutta2 and Runge-Kutta4 (with a fixed step size). We do
	/// not support Runge-Kutta45 (with an adaptive step size and error
	/// control) because a requirement of the algorithm is that sample
	/// points along a streamline be evenly spaced. These steps are in
	/// either LENGTH_UNIT or CELL_LENGTH_UNIT.
	///
	/// The integration time, vorticity, rotation and angular velocity are stored
	/// in point data arrays named "IntegrationTime", "Vorticity", "Rotation" and
	/// "AngularVelocity", respectively (vorticity, rotation and angular velocity
	/// are computed only when ComputeVorticity is on). All point data attributes
	/// in the source dataset are interpolated on the new streamline points.
	///
	/// vtkEvenlySpacedStreamlines2D supports integration through any type of 2D dataset.
	///
	/// The starting point, or the so-called 'seed', of the first streamline is set
	/// by setting StartPosition
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkStreamTracer vtkRibbonFilter vtkRuledSurfaceFilter vtkInitialValueProblemSolver
	/// vtkRungeKutta2 vtkRungeKutta4 vtkRungeKutta45 vtkParticleTracerBase
	/// vtkParticleTracer vtkParticlePathFilter vtkStreaklineFilter
	/// vtkAbstractInterpolatedVelocityField vtkCompositeInterpolatedVelocityField
	/// vtkAMRInterpolatedVelocityField
	/// </seealso>
	// Token: 0x020004AC RID: 1196
	public class vtkEvenlySpacedStreamlines2D : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600DBD4 RID: 56276 RVA: 0x0013102F File Offset: 0x0012F22F
		static vtkEvenlySpacedStreamlines2D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEvenlySpacedStreamlines2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEvenlySpacedStreamlines2D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600DBD5 RID: 56277 RVA: 0x00131057 File Offset: 0x0012F257
		public vtkEvenlySpacedStreamlines2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600DBD6 RID: 56278
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEvenlySpacedStreamlines2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object to start from position (0,0,0), with forward
		/// integration, terminal speed 1.0E-12, vorticity computation on,
		/// integration step size 0.5 (in cell length unit), maximum number
		/// of steps 2000, using Runge-Kutta2, and maximum propagation 1.0
		/// (in arc length unit).
		/// </summary>
		// Token: 0x0600DBD7 RID: 56279 RVA: 0x00131068 File Offset: 0x0012F268
		public new static vtkEvenlySpacedStreamlines2D New()
		{
			vtkEvenlySpacedStreamlines2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEvenlySpacedStreamlines2D.vtkEvenlySpacedStreamlines2D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEvenlySpacedStreamlines2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object to start from position (0,0,0), with forward
		/// integration, terminal speed 1.0E-12, vorticity computation on,
		/// integration step size 0.5 (in cell length unit), maximum number
		/// of steps 2000, using Runge-Kutta2, and maximum propagation 1.0
		/// (in arc length unit).
		/// </summary>
		// Token: 0x0600DBD8 RID: 56280 RVA: 0x001310BC File Offset: 0x0012F2BC
		public vtkEvenlySpacedStreamlines2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkEvenlySpacedStreamlines2D.vtkEvenlySpacedStreamlines2D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600DBD9 RID: 56281 RVA: 0x00131100 File Offset: 0x0012F300
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600DBDA RID: 56282
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkEvenlySpacedStreamlines2D_GetClosedLoopMaximumDistance_01(HandleRef pThis);

		/// <summary>
		/// Loops are considered closed if the have two points at distance less than this.
		/// This is expressed in IntegrationStepUnit.
		/// </summary>
		// Token: 0x0600DBDB RID: 56283 RVA: 0x0013110C File Offset: 0x0012F30C
		public virtual double GetClosedLoopMaximumDistance()
		{
			return vtkEvenlySpacedStreamlines2D.vtkEvenlySpacedStreamlines2D_GetClosedLoopMaximumDistance_01(base.GetCppThis());
		}

		// Token: 0x0600DBDC RID: 56284
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkEvenlySpacedStreamlines2D_GetComputeVorticity_02(HandleRef pThis);

		/// <summary>
		/// Turn on/off vorticity computation at streamline points
		/// (necessary for generating proper stream-ribbons using the
		/// vtkRibbonFilter.
		/// </summary>
		// Token: 0x0600DBDD RID: 56285 RVA: 0x0013112C File Offset: 0x0012F32C
		public virtual bool GetComputeVorticity()
		{
			return vtkEvenlySpacedStreamlines2D.vtkEvenlySpacedStreamlines2D_GetComputeVorticity_02(base.GetCppThis()) != 0;
		}

		// Token: 0x0600DBDE RID: 56286
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkEvenlySpacedStreamlines2D_GetInitialIntegrationStep_03(HandleRef pThis);

		/// <summary>
		/// Specify the Initial step size used for line integration, expressed in
		/// IntegrationStepUnit
		///
		/// This is the constant / fixed size for non-adaptive integration
		/// methods, i.e., RK2 and RK4
		/// </summary>
		// Token: 0x0600DBDF RID: 56287 RVA: 0x00131154 File Offset: 0x0012F354
		public virtual double GetInitialIntegrationStep()
		{
			return vtkEvenlySpacedStreamlines2D.vtkEvenlySpacedStreamlines2D_GetInitialIntegrationStep_03(base.GetCppThis());
		}

		// Token: 0x0600DBE0 RID: 56288
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEvenlySpacedStreamlines2D_GetIntegrationStepUnit_04(HandleRef pThis);

		/// <summary>
		/// Specify a uniform integration step unit for
		/// InitialIntegrationStep, and SeparatingDistance. Valid units are
		/// LENGTH_UNIT (1) (value is in global coordinates) and CELL_LENGTH_UNIT (2)
		/// (the value is in number of cell lengths)
		/// </summary>
		// Token: 0x0600DBE1 RID: 56289 RVA: 0x00131174 File Offset: 0x0012F374
		public int GetIntegrationStepUnit()
		{
			return vtkEvenlySpacedStreamlines2D.vtkEvenlySpacedStreamlines2D_GetIntegrationStepUnit_04(base.GetCppThis());
		}

		// Token: 0x0600DBE2 RID: 56290
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEvenlySpacedStreamlines2D_GetIntegrator_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get the integrator type to be used for streamline generation.
		/// The object passed is not actually used but is cloned with
		/// NewInstance in the process of integration  (prototype pattern).
		/// The default is Runge-Kutta2. The integrator can also be changed
		/// using SetIntegratorType. The recognized solvers are:
		/// RUNGE_KUTTA2  = 0
		/// RUNGE_KUTTA4  = 1
		/// </summary>
		// Token: 0x0600DBE3 RID: 56291 RVA: 0x00131194 File Offset: 0x0012F394
		public virtual vtkInitialValueProblemSolver GetIntegrator()
		{
			vtkInitialValueProblemSolver vtkInitialValueProblemSolver = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEvenlySpacedStreamlines2D.vtkEvenlySpacedStreamlines2D_GetIntegrator_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInitialValueProblemSolver = (vtkInitialValueProblemSolver)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInitialValueProblemSolver.Register(null);
				}
			}
			return vtkInitialValueProblemSolver;
		}

		// Token: 0x0600DBE4 RID: 56292
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEvenlySpacedStreamlines2D_GetIntegratorType_06(HandleRef pThis);

		/// <summary>
		/// Set/get the integrator type to be used for streamline generation.
		/// The object passed is not actually used but is cloned with
		/// NewInstance in the process of integration  (prototype pattern).
		/// The default is Runge-Kutta2. The integrator can also be changed
		/// using SetIntegratorType. The recognized solvers are:
		/// RUNGE_KUTTA2  = 0
		/// RUNGE_KUTTA4  = 1
		/// </summary>
		// Token: 0x0600DBE5 RID: 56293 RVA: 0x00131204 File Offset: 0x0012F404
		public int GetIntegratorType()
		{
			return vtkEvenlySpacedStreamlines2D.vtkEvenlySpacedStreamlines2D_GetIntegratorType_06(base.GetCppThis());
		}

		// Token: 0x0600DBE6 RID: 56294
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkEvenlySpacedStreamlines2D_GetLoopAngle_07(HandleRef pThis);

		/// <summary>
		/// The angle (in radians) between the vector created by p0p1 and the
		/// velocity in the point closing the loop. p0 is the current point
		/// and p1 is the point before that.  Default value is 20 degrees in radians.
		/// </summary>
		// Token: 0x0600DBE7 RID: 56295 RVA: 0x00131224 File Offset: 0x0012F424
		public virtual double GetLoopAngle()
		{
			return vtkEvenlySpacedStreamlines2D.vtkEvenlySpacedStreamlines2D_GetLoopAngle_07(base.GetCppThis());
		}

		// Token: 0x0600DBE8 RID: 56296
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEvenlySpacedStreamlines2D_GetMaximumNumberOfSteps_08(HandleRef pThis);

		/// <summary>
		/// Specify the maximum number of steps for integrating a streamline.
		/// </summary>
		// Token: 0x0600DBE9 RID: 56297 RVA: 0x00131244 File Offset: 0x0012F444
		public virtual long GetMaximumNumberOfSteps()
		{
			return vtkEvenlySpacedStreamlines2D.vtkEvenlySpacedStreamlines2D_GetMaximumNumberOfSteps_08(base.GetCppThis());
		}

		// Token: 0x0600DBEA RID: 56298
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEvenlySpacedStreamlines2D_GetMinimumNumberOfLoopPoints_09(HandleRef pThis);

		/// <summary>
		/// We don't try to eliminate loops with fewer points than this. Default value
		/// is 4.
		/// </summary>
		// Token: 0x0600DBEB RID: 56299 RVA: 0x00131264 File Offset: 0x0012F464
		public virtual long GetMinimumNumberOfLoopPoints()
		{
			return vtkEvenlySpacedStreamlines2D.vtkEvenlySpacedStreamlines2D_GetMinimumNumberOfLoopPoints_09(base.GetCppThis());
		}

		// Token: 0x0600DBEC RID: 56300
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEvenlySpacedStreamlines2D_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DBED RID: 56301 RVA: 0x00131284 File Offset: 0x0012F484
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkEvenlySpacedStreamlines2D.vtkEvenlySpacedStreamlines2D_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x0600DBEE RID: 56302
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEvenlySpacedStreamlines2D_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DBEF RID: 56303 RVA: 0x001312A4 File Offset: 0x0012F4A4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkEvenlySpacedStreamlines2D.vtkEvenlySpacedStreamlines2D_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x0600DBF0 RID: 56304
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkEvenlySpacedStreamlines2D_GetSeparatingDistance_12(HandleRef pThis);

		/// <summary>
		/// Specify the separation distance between streamlines expressed in
		/// IntegrationStepUnit.
		/// </summary>
		// Token: 0x0600DBF1 RID: 56305 RVA: 0x001312C0 File Offset: 0x0012F4C0
		public virtual double GetSeparatingDistance()
		{
			return vtkEvenlySpacedStreamlines2D.vtkEvenlySpacedStreamlines2D_GetSeparatingDistance_12(base.GetCppThis());
		}

		// Token: 0x0600DBF2 RID: 56306
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkEvenlySpacedStreamlines2D_GetSeparatingDistanceRatio_13(HandleRef pThis);

		/// <summary>
		/// Streamline integration is stopped if streamlines are closer than
		/// SeparatingDistance*SeparatingDistanceRatio to other streamlines.
		/// </summary>
		// Token: 0x0600DBF3 RID: 56307 RVA: 0x001312E0 File Offset: 0x0012F4E0
		public virtual double GetSeparatingDistanceRatio()
		{
			return vtkEvenlySpacedStreamlines2D.vtkEvenlySpacedStreamlines2D_GetSeparatingDistanceRatio_13(base.GetCppThis());
		}

		// Token: 0x0600DBF4 RID: 56308
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEvenlySpacedStreamlines2D_GetStartPosition_14(HandleRef pThis);

		/// <summary>
		/// Specify the starting point (seed) of the first streamline in the global
		/// coordinate system. Search must be performed to find the initial cell
		/// from which to start integration. If the seed is not specified a
		/// random position in the input data is chosen.
		/// </summary>
		// Token: 0x0600DBF5 RID: 56309 RVA: 0x00131300 File Offset: 0x0012F500
		public virtual double[] GetStartPosition()
		{
			IntPtr intPtr = vtkEvenlySpacedStreamlines2D.vtkEvenlySpacedStreamlines2D_GetStartPosition_14(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600DBF6 RID: 56310
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEvenlySpacedStreamlines2D_GetStartPosition_15(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Specify the starting point (seed) of the first streamline in the global
		/// coordinate system. Search must be performed to find the initial cell
		/// from which to start integration. If the seed is not specified a
		/// random position in the input data is chosen.
		/// </summary>
		// Token: 0x0600DBF7 RID: 56311 RVA: 0x00131348 File Offset: 0x0012F548
		public virtual void GetStartPosition(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkEvenlySpacedStreamlines2D.vtkEvenlySpacedStreamlines2D_GetStartPosition_15(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600DBF8 RID: 56312
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEvenlySpacedStreamlines2D_GetStartPosition_16(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify the starting point (seed) of the first streamline in the global
		/// coordinate system. Search must be performed to find the initial cell
		/// from which to start integration. If the seed is not specified a
		/// random position in the input data is chosen.
		/// </summary>
		// Token: 0x0600DBF9 RID: 56313 RVA: 0x0013135A File Offset: 0x0012F55A
		public virtual void GetStartPosition(IntPtr _arg)
		{
			vtkEvenlySpacedStreamlines2D.vtkEvenlySpacedStreamlines2D_GetStartPosition_16(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DBFA RID: 56314
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkEvenlySpacedStreamlines2D_GetTerminalSpeed_17(HandleRef pThis);

		/// <summary>
		/// Specify the terminal speed value, below which integration is terminated.
		/// </summary>
		// Token: 0x0600DBFB RID: 56315 RVA: 0x0013136C File Offset: 0x0012F56C
		public virtual double GetTerminalSpeed()
		{
			return vtkEvenlySpacedStreamlines2D.vtkEvenlySpacedStreamlines2D_GetTerminalSpeed_17(base.GetCppThis());
		}

		// Token: 0x0600DBFC RID: 56316
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEvenlySpacedStreamlines2D_IsA_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DBFD RID: 56317 RVA: 0x0013138C File Offset: 0x0012F58C
		public override int IsA(string type)
		{
			return vtkEvenlySpacedStreamlines2D.vtkEvenlySpacedStreamlines2D_IsA_18(base.GetCppThis(), type);
		}

		// Token: 0x0600DBFE RID: 56318
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEvenlySpacedStreamlines2D_IsTypeOf_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DBFF RID: 56319 RVA: 0x001313AC File Offset: 0x0012F5AC
		public new static int IsTypeOf(string type)
		{
			return vtkEvenlySpacedStreamlines2D.vtkEvenlySpacedStreamlines2D_IsTypeOf_19(type);
		}

		// Token: 0x0600DC00 RID: 56320
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEvenlySpacedStreamlines2D_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DC01 RID: 56321 RVA: 0x001313C8 File Offset: 0x0012F5C8
		public new vtkEvenlySpacedStreamlines2D NewInstance()
		{
			vtkEvenlySpacedStreamlines2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEvenlySpacedStreamlines2D.vtkEvenlySpacedStreamlines2D_NewInstance_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEvenlySpacedStreamlines2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600DC02 RID: 56322
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEvenlySpacedStreamlines2D_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DC03 RID: 56323 RVA: 0x00131424 File Offset: 0x0012F624
		public new static vtkEvenlySpacedStreamlines2D SafeDownCast(vtkObjectBase o)
		{
			vtkEvenlySpacedStreamlines2D vtkEvenlySpacedStreamlines2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEvenlySpacedStreamlines2D.vtkEvenlySpacedStreamlines2D_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEvenlySpacedStreamlines2D = (vtkEvenlySpacedStreamlines2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEvenlySpacedStreamlines2D.Register(null);
				}
			}
			return vtkEvenlySpacedStreamlines2D;
		}

		// Token: 0x0600DC04 RID: 56324
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEvenlySpacedStreamlines2D_SetClosedLoopMaximumDistance_23(HandleRef pThis, double _arg);

		/// <summary>
		/// Loops are considered closed if the have two points at distance less than this.
		/// This is expressed in IntegrationStepUnit.
		/// </summary>
		// Token: 0x0600DC05 RID: 56325 RVA: 0x001314A3 File Offset: 0x0012F6A3
		public virtual void SetClosedLoopMaximumDistance(double _arg)
		{
			vtkEvenlySpacedStreamlines2D.vtkEvenlySpacedStreamlines2D_SetClosedLoopMaximumDistance_23(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DC06 RID: 56326
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEvenlySpacedStreamlines2D_SetComputeVorticity_24(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on/off vorticity computation at streamline points
		/// (necessary for generating proper stream-ribbons using the
		/// vtkRibbonFilter.
		/// </summary>
		// Token: 0x0600DC07 RID: 56327 RVA: 0x001314B3 File Offset: 0x0012F6B3
		public virtual void SetComputeVorticity(bool _arg)
		{
			vtkEvenlySpacedStreamlines2D.vtkEvenlySpacedStreamlines2D_SetComputeVorticity_24(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600DC08 RID: 56328
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEvenlySpacedStreamlines2D_SetInitialIntegrationStep_25(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the Initial step size used for line integration, expressed in
		/// IntegrationStepUnit
		///
		/// This is the constant / fixed size for non-adaptive integration
		/// methods, i.e., RK2 and RK4
		/// </summary>
		// Token: 0x0600DC09 RID: 56329 RVA: 0x001314CB File Offset: 0x0012F6CB
		public virtual void SetInitialIntegrationStep(double _arg)
		{
			vtkEvenlySpacedStreamlines2D.vtkEvenlySpacedStreamlines2D_SetInitialIntegrationStep_25(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DC0A RID: 56330
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEvenlySpacedStreamlines2D_SetIntegrationStepUnit_26(HandleRef pThis, int unit);

		/// <summary>
		/// Specify a uniform integration step unit for
		/// InitialIntegrationStep, and SeparatingDistance. Valid units are
		/// LENGTH_UNIT (1) (value is in global coordinates) and CELL_LENGTH_UNIT (2)
		/// (the value is in number of cell lengths)
		/// </summary>
		// Token: 0x0600DC0B RID: 56331 RVA: 0x001314DB File Offset: 0x0012F6DB
		public void SetIntegrationStepUnit(int unit)
		{
			vtkEvenlySpacedStreamlines2D.vtkEvenlySpacedStreamlines2D_SetIntegrationStepUnit_26(base.GetCppThis(), unit);
		}

		// Token: 0x0600DC0C RID: 56332
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEvenlySpacedStreamlines2D_SetIntegrator_27(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/get the integrator type to be used for streamline generation.
		/// The object passed is not actually used but is cloned with
		/// NewInstance in the process of integration  (prototype pattern).
		/// The default is Runge-Kutta2. The integrator can also be changed
		/// using SetIntegratorType. The recognized solvers are:
		/// RUNGE_KUTTA2  = 0
		/// RUNGE_KUTTA4  = 1
		/// </summary>
		// Token: 0x0600DC0D RID: 56333 RVA: 0x001314EC File Offset: 0x0012F6EC
		public void SetIntegrator(vtkInitialValueProblemSolver arg0)
		{
			vtkEvenlySpacedStreamlines2D.vtkEvenlySpacedStreamlines2D_SetIntegrator_27(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600DC0E RID: 56334
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEvenlySpacedStreamlines2D_SetIntegratorType_28(HandleRef pThis, int type);

		/// <summary>
		/// Set/get the integrator type to be used for streamline generation.
		/// The object passed is not actually used but is cloned with
		/// NewInstance in the process of integration  (prototype pattern).
		/// The default is Runge-Kutta2. The integrator can also be changed
		/// using SetIntegratorType. The recognized solvers are:
		/// RUNGE_KUTTA2  = 0
		/// RUNGE_KUTTA4  = 1
		/// </summary>
		// Token: 0x0600DC0F RID: 56335 RVA: 0x0013151B File Offset: 0x0012F71B
		public void SetIntegratorType(int type)
		{
			vtkEvenlySpacedStreamlines2D.vtkEvenlySpacedStreamlines2D_SetIntegratorType_28(base.GetCppThis(), type);
		}

		// Token: 0x0600DC10 RID: 56336
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEvenlySpacedStreamlines2D_SetIntegratorTypeToRungeKutta2_29(HandleRef pThis);

		/// <summary>
		/// Set/get the integrator type to be used for streamline generation.
		/// The object passed is not actually used but is cloned with
		/// NewInstance in the process of integration  (prototype pattern).
		/// The default is Runge-Kutta2. The integrator can also be changed
		/// using SetIntegratorType. The recognized solvers are:
		/// RUNGE_KUTTA2  = 0
		/// RUNGE_KUTTA4  = 1
		/// </summary>
		// Token: 0x0600DC11 RID: 56337 RVA: 0x0013152B File Offset: 0x0012F72B
		public void SetIntegratorTypeToRungeKutta2()
		{
			vtkEvenlySpacedStreamlines2D.vtkEvenlySpacedStreamlines2D_SetIntegratorTypeToRungeKutta2_29(base.GetCppThis());
		}

		// Token: 0x0600DC12 RID: 56338
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEvenlySpacedStreamlines2D_SetIntegratorTypeToRungeKutta4_30(HandleRef pThis);

		/// <summary>
		/// Set/get the integrator type to be used for streamline generation.
		/// The object passed is not actually used but is cloned with
		/// NewInstance in the process of integration  (prototype pattern).
		/// The default is Runge-Kutta2. The integrator can also be changed
		/// using SetIntegratorType. The recognized solvers are:
		/// RUNGE_KUTTA2  = 0
		/// RUNGE_KUTTA4  = 1
		/// </summary>
		// Token: 0x0600DC13 RID: 56339 RVA: 0x0013153A File Offset: 0x0012F73A
		public void SetIntegratorTypeToRungeKutta4()
		{
			vtkEvenlySpacedStreamlines2D.vtkEvenlySpacedStreamlines2D_SetIntegratorTypeToRungeKutta4_30(base.GetCppThis());
		}

		// Token: 0x0600DC14 RID: 56340
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEvenlySpacedStreamlines2D_SetInterpolatorPrototype_31(HandleRef pThis, HandleRef ivf);

		/// <summary>
		/// The object used to interpolate the velocity field during
		/// integration is of the same class as this prototype.
		/// </summary>
		// Token: 0x0600DC15 RID: 56341 RVA: 0x0013154C File Offset: 0x0012F74C
		public void SetInterpolatorPrototype(vtkAbstractInterpolatedVelocityField ivf)
		{
			vtkEvenlySpacedStreamlines2D.vtkEvenlySpacedStreamlines2D_SetInterpolatorPrototype_31(base.GetCppThis(), (ivf == null) ? default(HandleRef) : ivf.GetCppThis());
		}

		// Token: 0x0600DC16 RID: 56342
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEvenlySpacedStreamlines2D_SetInterpolatorType_32(HandleRef pThis, int interpType);

		/// <summary>
		/// Set the type of the velocity field interpolator to determine whether
		/// INTERPOLATOR_WITH_DATASET_POINT_LOCATOR or INTERPOLATOR_WITH_CELL_LOCATOR
		/// is employed for locating cells during streamline integration. The latter
		/// (adopting vtkAbstractCellLocator sub-classes such as vtkCellLocator and
		/// vtkModifiedBSPTree) is more robust then the former (through vtkDataSet /
		/// vtkPointSet::FindCell() coupled with vtkPointLocator).
		/// </summary>
		// Token: 0x0600DC17 RID: 56343 RVA: 0x0013157B File Offset: 0x0012F77B
		public void SetInterpolatorType(int interpType)
		{
			vtkEvenlySpacedStreamlines2D.vtkEvenlySpacedStreamlines2D_SetInterpolatorType_32(base.GetCppThis(), interpType);
		}

		// Token: 0x0600DC18 RID: 56344
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEvenlySpacedStreamlines2D_SetInterpolatorTypeToCellLocator_33(HandleRef pThis);

		/// <summary>
		/// Set the velocity field interpolator type to the one involving
		/// a cell locator.
		/// </summary>
		// Token: 0x0600DC19 RID: 56345 RVA: 0x0013158B File Offset: 0x0012F78B
		public void SetInterpolatorTypeToCellLocator()
		{
			vtkEvenlySpacedStreamlines2D.vtkEvenlySpacedStreamlines2D_SetInterpolatorTypeToCellLocator_33(base.GetCppThis());
		}

		// Token: 0x0600DC1A RID: 56346
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEvenlySpacedStreamlines2D_SetInterpolatorTypeToDataSetPointLocator_34(HandleRef pThis);

		/// <summary>
		/// Set the velocity field interpolator type to the one involving
		/// a dataset point locator.
		/// </summary>
		// Token: 0x0600DC1B RID: 56347 RVA: 0x0013159A File Offset: 0x0012F79A
		public void SetInterpolatorTypeToDataSetPointLocator()
		{
			vtkEvenlySpacedStreamlines2D.vtkEvenlySpacedStreamlines2D_SetInterpolatorTypeToDataSetPointLocator_34(base.GetCppThis());
		}

		// Token: 0x0600DC1C RID: 56348
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEvenlySpacedStreamlines2D_SetLoopAngle_35(HandleRef pThis, double _arg);

		/// <summary>
		/// The angle (in radians) between the vector created by p0p1 and the
		/// velocity in the point closing the loop. p0 is the current point
		/// and p1 is the point before that.  Default value is 20 degrees in radians.
		/// </summary>
		// Token: 0x0600DC1D RID: 56349 RVA: 0x001315A9 File Offset: 0x0012F7A9
		public virtual void SetLoopAngle(double _arg)
		{
			vtkEvenlySpacedStreamlines2D.vtkEvenlySpacedStreamlines2D_SetLoopAngle_35(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DC1E RID: 56350
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEvenlySpacedStreamlines2D_SetMaximumNumberOfSteps_36(HandleRef pThis, long _arg);

		/// <summary>
		/// Specify the maximum number of steps for integrating a streamline.
		/// </summary>
		// Token: 0x0600DC1F RID: 56351 RVA: 0x001315B9 File Offset: 0x0012F7B9
		public virtual void SetMaximumNumberOfSteps(long _arg)
		{
			vtkEvenlySpacedStreamlines2D.vtkEvenlySpacedStreamlines2D_SetMaximumNumberOfSteps_36(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DC20 RID: 56352
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEvenlySpacedStreamlines2D_SetMinimumNumberOfLoopPoints_37(HandleRef pThis, long _arg);

		/// <summary>
		/// We don't try to eliminate loops with fewer points than this. Default value
		/// is 4.
		/// </summary>
		// Token: 0x0600DC21 RID: 56353 RVA: 0x001315C9 File Offset: 0x0012F7C9
		public virtual void SetMinimumNumberOfLoopPoints(long _arg)
		{
			vtkEvenlySpacedStreamlines2D.vtkEvenlySpacedStreamlines2D_SetMinimumNumberOfLoopPoints_37(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DC22 RID: 56354
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEvenlySpacedStreamlines2D_SetSeparatingDistance_38(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the separation distance between streamlines expressed in
		/// IntegrationStepUnit.
		/// </summary>
		// Token: 0x0600DC23 RID: 56355 RVA: 0x001315D9 File Offset: 0x0012F7D9
		public virtual void SetSeparatingDistance(double _arg)
		{
			vtkEvenlySpacedStreamlines2D.vtkEvenlySpacedStreamlines2D_SetSeparatingDistance_38(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DC24 RID: 56356
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEvenlySpacedStreamlines2D_SetSeparatingDistanceRatio_39(HandleRef pThis, double _arg);

		/// <summary>
		/// Streamline integration is stopped if streamlines are closer than
		/// SeparatingDistance*SeparatingDistanceRatio to other streamlines.
		/// </summary>
		// Token: 0x0600DC25 RID: 56357 RVA: 0x001315E9 File Offset: 0x0012F7E9
		public virtual void SetSeparatingDistanceRatio(double _arg)
		{
			vtkEvenlySpacedStreamlines2D.vtkEvenlySpacedStreamlines2D_SetSeparatingDistanceRatio_39(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DC26 RID: 56358
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEvenlySpacedStreamlines2D_SetStartPosition_40(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Specify the starting point (seed) of the first streamline in the global
		/// coordinate system. Search must be performed to find the initial cell
		/// from which to start integration. If the seed is not specified a
		/// random position in the input data is chosen.
		/// </summary>
		// Token: 0x0600DC27 RID: 56359 RVA: 0x001315F9 File Offset: 0x0012F7F9
		public virtual void SetStartPosition(double _arg1, double _arg2, double _arg3)
		{
			vtkEvenlySpacedStreamlines2D.vtkEvenlySpacedStreamlines2D_SetStartPosition_40(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600DC28 RID: 56360
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEvenlySpacedStreamlines2D_SetStartPosition_41(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify the starting point (seed) of the first streamline in the global
		/// coordinate system. Search must be performed to find the initial cell
		/// from which to start integration. If the seed is not specified a
		/// random position in the input data is chosen.
		/// </summary>
		// Token: 0x0600DC29 RID: 56361 RVA: 0x0013160B File Offset: 0x0012F80B
		public virtual void SetStartPosition(IntPtr _arg)
		{
			vtkEvenlySpacedStreamlines2D.vtkEvenlySpacedStreamlines2D_SetStartPosition_41(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DC2A RID: 56362
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEvenlySpacedStreamlines2D_SetTerminalSpeed_42(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the terminal speed value, below which integration is terminated.
		/// </summary>
		// Token: 0x0600DC2B RID: 56363 RVA: 0x0013161B File Offset: 0x0012F81B
		public virtual void SetTerminalSpeed(double _arg)
		{
			vtkEvenlySpacedStreamlines2D.vtkEvenlySpacedStreamlines2D_SetTerminalSpeed_42(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400100F RID: 4111
		public new const string MRFullTypeName = "Kitware.VTK.vtkEvenlySpacedStreamlines2D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001010 RID: 4112
		public new static readonly string MRClassNameKey = "class vtkEvenlySpacedStreamlines2D";
	}
}
