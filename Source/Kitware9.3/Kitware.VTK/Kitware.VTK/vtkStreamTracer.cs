using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkStreamTracer
	/// </summary>
	/// <remarks>
	///    Streamline generator
	///
	/// vtkStreamTracer is a filter that integrates a vector field to generate
	/// streamlines. The integration is performed using a specified integrator,
	/// by default Runge-Kutta2.
	///
	/// vtkStreamTracer produces polylines as the output, with each cell (i.e.,
	/// polyline) representing a streamline. The attribute values associated
	/// with each streamline are stored in the cell data, whereas those
	/// associated with streamline-points are stored in the point data.
	///
	/// vtkStreamTracer supports forward (the default), backward, and combined
	/// (i.e., BOTH) integration. The length of a streamline is governed by
	/// specifying a maximum value either in physical arc length or in (local)
	/// cell length. Otherwise, the integration terminates upon exiting the
	/// flow field domain, or if the particle speed is reduced to a value less
	/// than a specified terminal speed, or when a maximum number of steps is
	/// completed. The specific reason for the termination is stored in a cell
	/// array named ReasonForTermination.
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
	/// The quality of streamline integration can be controlled by setting the
	/// initial integration step (InitialIntegrationStep), particularly for
	/// Runge-Kutta2 and Runge-Kutta4 (with a fixed step size), and in the case
	/// of Runge-Kutta45 (with an adaptive step size and error control) the
	/// minimum integration step, the maximum integration step, and the maximum
	/// error. These steps are in either LENGTH_UNIT or CELL_LENGTH_UNIT while
	/// the error is in physical arc length. For the former two integrators,
	/// there is a trade-off between integration speed and streamline quality.
	///
	/// The integration time, vorticity, rotation and angular velocity are stored
	/// in point data arrays named "IntegrationTime", "Vorticity", "Rotation" and
	/// "AngularVelocity", respectively (vorticity, rotation and angular velocity
	/// are computed only when ComputeVorticity is on). All point data attributes
	/// in the source dataset are interpolated on the new streamline points.
	///
	/// vtkStreamTracer supports integration through any type of dataset. Thus if
	/// the dataset contains 2D cells like polygons or triangles, the integration
	/// is constrained to lie on the surface defined by 2D cells.
	///
	/// The starting point, or the so-called 'seed', of a streamline may be set in
	/// two different ways. Starting from global x-y-z "position" allows you to
	/// start a single trace at a specified x-y-z coordinate. If you specify a
	/// source object, traces will be generated from each point in the source that
	/// is inside the dataset. Note that if the integration direction is BOTH,
	/// then potentially 2N streamlines will be generated given N seed points.
	///
	/// @note This class has been threaded using vtkSMPTools. Each separate
	/// streamline (corresponding to the initial seeds) is processed in a
	/// separate thread. Consequently, if threading is enabled and many
	/// streamlines are generated, significant performance improvement is
	/// possible.
	///
	/// @note Field data is shallow copied to the output. When the input is a
	/// composite data set, field data associated with the root block is shallow-
	/// copied to the output vtkPolyData.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRibbonFilter vtkRuledSurfaceFilter vtkInitialValueProblemSolver
	/// vtkRungeKutta2 vtkRungeKutta4 vtkRungeKutta45 vtkParticleTracerBase
	/// vtkParticleTracer vtkParticlePathFilter vtkStreaklineFilter
	/// vtkAbstractInterpolatedVelocityField vtkCompositeInterpolatedVelocityField
	/// vtkAMRInterpolatedVelocityField vtkSMPTools vtkPStreamTracer
	/// </seealso>
	// Token: 0x020004BF RID: 1215
	public class vtkStreamTracer : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600DE85 RID: 56965 RVA: 0x00134E3B File Offset: 0x0013303B
		static vtkStreamTracer()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStreamTracer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStreamTracer"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600DE86 RID: 56966 RVA: 0x00134E63 File Offset: 0x00133063
		public vtkStreamTracer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600DE87 RID: 56967
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStreamTracer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct the object to start from position (0,0,0), with forward
		/// integration, terminal speed 1.0E-12, vorticity computation on,
		/// integration step size 0.5 (in cell length unit), maximum number
		/// of steps 2000, using Runge-Kutta2, and maximum propagation 1.0
		/// (in arc length unit).
		/// </summary>
		// Token: 0x0600DE88 RID: 56968 RVA: 0x00134E74 File Offset: 0x00133074
		public new static vtkStreamTracer New()
		{
			vtkStreamTracer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStreamTracer.vtkStreamTracer_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStreamTracer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct the object to start from position (0,0,0), with forward
		/// integration, terminal speed 1.0E-12, vorticity computation on,
		/// integration step size 0.5 (in cell length unit), maximum number
		/// of steps 2000, using Runge-Kutta2, and maximum propagation 1.0
		/// (in arc length unit).
		/// </summary>
		// Token: 0x0600DE89 RID: 56969 RVA: 0x00134EC8 File Offset: 0x001330C8
		public vtkStreamTracer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkStreamTracer.vtkStreamTracer_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600DE8A RID: 56970 RVA: 0x00134F0C File Offset: 0x0013310C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600DE8B RID: 56971
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStreamTracer_CalculateVorticity_01(HandleRef pThis, HandleRef cell, IntPtr pcoords, HandleRef cellVectors, IntPtr vorticity);

		/// <summary>
		/// Helper methods to generate normals on streamlines. Made public so internal threaded
		/// classes in anonymous namespace can invoke the methods.
		/// </summary>
		// Token: 0x0600DE8C RID: 56972 RVA: 0x00134F18 File Offset: 0x00133118
		public void CalculateVorticity(vtkGenericCell cell, IntPtr pcoords, vtkDoubleArray cellVectors, IntPtr vorticity)
		{
			vtkStreamTracer.vtkStreamTracer_CalculateVorticity_01(base.GetCppThis(), (cell == null) ? default(HandleRef) : cell.GetCppThis(), pcoords, (cellVectors == null) ? default(HandleRef) : cellVectors.GetCppThis(), vorticity);
		}

		// Token: 0x0600DE8D RID: 56973
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStreamTracer_ConvertIntervals_02(HandleRef pThis, ref double step, ref double minStep, ref double maxStep, int direction, double cellLength);

		/// <summary>
		/// Helper method to convert between length scales. Made public so internal threaded
		/// classes in anonymous namespace can invoke the method.
		/// </summary>
		// Token: 0x0600DE8E RID: 56974 RVA: 0x00134F5F File Offset: 0x0013315F
		public void ConvertIntervals(ref double step, ref double minStep, ref double maxStep, int direction, double cellLength)
		{
			vtkStreamTracer.vtkStreamTracer_ConvertIntervals_02(base.GetCppThis(), ref step, ref minStep, ref maxStep, direction, cellLength);
		}

		// Token: 0x0600DE8F RID: 56975
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStreamTracer_ForceSerialExecutionOff_03(HandleRef pThis);

		/// <summary>
		/// Force the filter to run stream tracer advection in serial. This affects
		/// the filter only if more than one streamline is to be generated.
		/// </summary>
		// Token: 0x0600DE90 RID: 56976 RVA: 0x00134F75 File Offset: 0x00133175
		public virtual void ForceSerialExecutionOff()
		{
			vtkStreamTracer.vtkStreamTracer_ForceSerialExecutionOff_03(base.GetCppThis());
		}

		// Token: 0x0600DE91 RID: 56977
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStreamTracer_ForceSerialExecutionOn_04(HandleRef pThis);

		/// <summary>
		/// Force the filter to run stream tracer advection in serial. This affects
		/// the filter only if more than one streamline is to be generated.
		/// </summary>
		// Token: 0x0600DE92 RID: 56978 RVA: 0x00134F84 File Offset: 0x00133184
		public virtual void ForceSerialExecutionOn()
		{
			vtkStreamTracer.vtkStreamTracer_ForceSerialExecutionOn_04(base.GetCppThis());
		}

		// Token: 0x0600DE93 RID: 56979
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStreamTracer_GenerateNormals_05(HandleRef pThis, HandleRef output, IntPtr firstNormal, [MarshalAs(UnmanagedType.LPUTF8Str)] string vecName);

		/// <summary>
		/// Helper methods to generate normals on streamlines. Made public so internal threaded
		/// classes in anonymous namespace can invoke the methods.
		/// </summary>
		// Token: 0x0600DE94 RID: 56980 RVA: 0x00134F94 File Offset: 0x00133194
		public void GenerateNormals(vtkPolyData output, IntPtr firstNormal, string vecName)
		{
			vtkStreamTracer.vtkStreamTracer_GenerateNormals_05(base.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis(), firstNormal, vecName);
		}

		// Token: 0x0600DE95 RID: 56981
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStreamTracer_GetComputeVorticity_06(HandleRef pThis);

		/// <summary>
		/// Turn on/off vorticity computation at streamline points
		/// (necessary for generating proper stream-ribbons using the
		/// vtkRibbonFilter).
		/// </summary>
		// Token: 0x0600DE96 RID: 56982 RVA: 0x00134FC8 File Offset: 0x001331C8
		public virtual bool GetComputeVorticity()
		{
			return vtkStreamTracer.vtkStreamTracer_GetComputeVorticity_06(base.GetCppThis()) != 0;
		}

		// Token: 0x0600DE97 RID: 56983
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStreamTracer_GetForceSerialExecution_07(HandleRef pThis);

		/// <summary>
		/// Force the filter to run stream tracer advection in serial. This affects
		/// the filter only if more than one streamline is to be generated.
		/// </summary>
		// Token: 0x0600DE98 RID: 56984 RVA: 0x00134FF0 File Offset: 0x001331F0
		public virtual bool GetForceSerialExecution()
		{
			return vtkStreamTracer.vtkStreamTracer_GetForceSerialExecution_07(base.GetCppThis()) != 0;
		}

		// Token: 0x0600DE99 RID: 56985
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkStreamTracer_GetInitialIntegrationStep_08(HandleRef pThis);

		/// <summary>
		/// Specify the Initial step size used for line integration, expressed in:
		/// LENGTH_UNIT      = 1
		/// CELL_LENGTH_UNIT = 2
		/// (either the starting size for an adaptive integrator, e.g., RK45,
		/// or the constant / fixed size for non-adaptive ones, i.e., RK2 and RK4)
		/// </summary>
		// Token: 0x0600DE9A RID: 56986 RVA: 0x00135018 File Offset: 0x00133218
		public virtual double GetInitialIntegrationStep()
		{
			return vtkStreamTracer.vtkStreamTracer_GetInitialIntegrationStep_08(base.GetCppThis());
		}

		// Token: 0x0600DE9B RID: 56987
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStreamTracer_GetIntegrationDirection_09(HandleRef pThis);

		/// <summary>
		/// Specify whether the streamline is integrated in the upstream or
		/// downstream direction, or in both directions. (If integrated in both
		/// directions, two separate streamlines are generated, both of which which
		/// start at the seed point with one traveling in the forward direction, and
		/// one in the backward direction.)
		/// </summary>
		// Token: 0x0600DE9C RID: 56988 RVA: 0x00135038 File Offset: 0x00133238
		public virtual int GetIntegrationDirection()
		{
			return vtkStreamTracer.vtkStreamTracer_GetIntegrationDirection_09(base.GetCppThis());
		}

		// Token: 0x0600DE9D RID: 56989
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStreamTracer_GetIntegrationDirectionMaxValue_10(HandleRef pThis);

		/// <summary>
		/// Specify whether the streamline is integrated in the upstream or
		/// downstream direction, or in both directions. (If integrated in both
		/// directions, two separate streamlines are generated, both of which which
		/// start at the seed point with one traveling in the forward direction, and
		/// one in the backward direction.)
		/// </summary>
		// Token: 0x0600DE9E RID: 56990 RVA: 0x00135058 File Offset: 0x00133258
		public virtual int GetIntegrationDirectionMaxValue()
		{
			return vtkStreamTracer.vtkStreamTracer_GetIntegrationDirectionMaxValue_10(base.GetCppThis());
		}

		// Token: 0x0600DE9F RID: 56991
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStreamTracer_GetIntegrationDirectionMinValue_11(HandleRef pThis);

		/// <summary>
		/// Specify whether the streamline is integrated in the upstream or
		/// downstream direction, or in both directions. (If integrated in both
		/// directions, two separate streamlines are generated, both of which which
		/// start at the seed point with one traveling in the forward direction, and
		/// one in the backward direction.)
		/// </summary>
		// Token: 0x0600DEA0 RID: 56992 RVA: 0x00135078 File Offset: 0x00133278
		public virtual int GetIntegrationDirectionMinValue()
		{
			return vtkStreamTracer.vtkStreamTracer_GetIntegrationDirectionMinValue_11(base.GetCppThis());
		}

		// Token: 0x0600DEA1 RID: 56993
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStreamTracer_GetIntegrationStepUnit_12(HandleRef pThis);

		/// <summary>
		/// Specify a uniform integration step unit for MinimumIntegrationStep,
		/// InitialIntegrationStep, and MaximumIntegrationStep. NOTE: The valid
		/// unit is now limited to only LENGTH_UNIT (1) and CELL_LENGTH_UNIT (2),
		/// EXCLUDING the previously-supported TIME_UNIT.
		/// </summary>
		// Token: 0x0600DEA2 RID: 56994 RVA: 0x00135098 File Offset: 0x00133298
		public int GetIntegrationStepUnit()
		{
			return vtkStreamTracer.vtkStreamTracer_GetIntegrationStepUnit_12(base.GetCppThis());
		}

		// Token: 0x0600DEA3 RID: 56995
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStreamTracer_GetIntegrator_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get the integrator type to be used for streamline generation.
		/// The object passed is not actually used but is cloned with
		/// NewInstance in the process of integration  (prototype pattern).
		/// The default is Runge-Kutta2. The integrator can also be changed
		/// using SetIntegratorType. The recognized solvers are:
		/// RUNGE_KUTTA2  = 0
		/// RUNGE_KUTTA4  = 1
		/// RUNGE_KUTTA45 = 2
		/// </summary>
		// Token: 0x0600DEA4 RID: 56996 RVA: 0x001350B8 File Offset: 0x001332B8
		public virtual vtkInitialValueProblemSolver GetIntegrator()
		{
			vtkInitialValueProblemSolver vtkInitialValueProblemSolver = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStreamTracer.vtkStreamTracer_GetIntegrator_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600DEA5 RID: 56997
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStreamTracer_GetIntegratorType_14(HandleRef pThis);

		/// <summary>
		/// Set/get the integrator type to be used for streamline generation.
		/// The object passed is not actually used but is cloned with
		/// NewInstance in the process of integration  (prototype pattern).
		/// The default is Runge-Kutta2. The integrator can also be changed
		/// using SetIntegratorType. The recognized solvers are:
		/// RUNGE_KUTTA2  = 0
		/// RUNGE_KUTTA4  = 1
		/// RUNGE_KUTTA45 = 2
		/// </summary>
		// Token: 0x0600DEA6 RID: 56998 RVA: 0x00135128 File Offset: 0x00133328
		public int GetIntegratorType()
		{
			return vtkStreamTracer.vtkStreamTracer_GetIntegratorType_14(base.GetCppThis());
		}

		// Token: 0x0600DEA7 RID: 56999
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkStreamTracer_GetMaximumError_15(HandleRef pThis);

		/// <summary>
		/// Specify the maximum error tolerated throughout streamline integration.
		/// </summary>
		// Token: 0x0600DEA8 RID: 57000 RVA: 0x00135148 File Offset: 0x00133348
		public virtual double GetMaximumError()
		{
			return vtkStreamTracer.vtkStreamTracer_GetMaximumError_15(base.GetCppThis());
		}

		// Token: 0x0600DEA9 RID: 57001
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkStreamTracer_GetMaximumIntegrationStep_16(HandleRef pThis);

		/// <summary>
		/// Specify the Maximum step size used for line integration, expressed in:
		/// LENGTH_UNIT      = 1
		/// CELL_LENGTH_UNIT = 2
		/// (Only valid for an adaptive integrator, e.g., RK45)
		/// </summary>
		// Token: 0x0600DEAA RID: 57002 RVA: 0x00135168 File Offset: 0x00133368
		public virtual double GetMaximumIntegrationStep()
		{
			return vtkStreamTracer.vtkStreamTracer_GetMaximumIntegrationStep_16(base.GetCppThis());
		}

		// Token: 0x0600DEAB RID: 57003
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStreamTracer_GetMaximumNumberOfSteps_17(HandleRef pThis);

		/// <summary>
		/// Specify the maximum number of steps for integrating a streamline. Note
		/// that the number of steps generated is always one greater than
		/// MaximumNumberOfSteps. So if MaximumNumberOfSteps==0, then only one step
		/// will be generated. This is useful for advection situations when the
		/// stream tracer is to be propagated just one step at a time (e.g., see
		/// vtkStreamSurface which depends on this behavior).
		/// </summary>
		// Token: 0x0600DEAC RID: 57004 RVA: 0x00135188 File Offset: 0x00133388
		public virtual long GetMaximumNumberOfSteps()
		{
			return vtkStreamTracer.vtkStreamTracer_GetMaximumNumberOfSteps_17(base.GetCppThis());
		}

		// Token: 0x0600DEAD RID: 57005
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkStreamTracer_GetMaximumPropagation_18(HandleRef pThis);

		/// <summary>
		/// Specify the maximum length of a streamline expressed in LENGTH_UNIT.
		/// </summary>
		// Token: 0x0600DEAE RID: 57006 RVA: 0x001351A8 File Offset: 0x001333A8
		public virtual double GetMaximumPropagation()
		{
			return vtkStreamTracer.vtkStreamTracer_GetMaximumPropagation_18(base.GetCppThis());
		}

		// Token: 0x0600DEAF RID: 57007
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkStreamTracer_GetMinimumIntegrationStep_19(HandleRef pThis);

		/// <summary>
		/// Specify the Minimum step size used for line integration, expressed in:
		/// LENGTH_UNIT      = 1
		/// CELL_LENGTH_UNIT = 2
		/// (Only valid for an adaptive integrator, e.g., RK45)
		/// </summary>
		// Token: 0x0600DEB0 RID: 57008 RVA: 0x001351C8 File Offset: 0x001333C8
		public virtual double GetMinimumIntegrationStep()
		{
			return vtkStreamTracer.vtkStreamTracer_GetMinimumIntegrationStep_19(base.GetCppThis());
		}

		// Token: 0x0600DEB1 RID: 57009
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStreamTracer_GetNumberOfGenerationsFromBase_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to obtain type information and print object state.
		/// </summary>
		// Token: 0x0600DEB2 RID: 57010 RVA: 0x001351E8 File Offset: 0x001333E8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkStreamTracer.vtkStreamTracer_GetNumberOfGenerationsFromBase_20(base.GetCppThis(), type);
		}

		// Token: 0x0600DEB3 RID: 57011
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStreamTracer_GetNumberOfGenerationsFromBaseType_21([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to obtain type information and print object state.
		/// </summary>
		// Token: 0x0600DEB4 RID: 57012 RVA: 0x00135208 File Offset: 0x00133408
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkStreamTracer.vtkStreamTracer_GetNumberOfGenerationsFromBaseType_21(type);
		}

		// Token: 0x0600DEB5 RID: 57013
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkStreamTracer_GetRotationScale_22(HandleRef pThis);

		/// <summary>
		/// This can be used to scale the rate with which the streamribbons
		/// twist. The default is 1.
		/// </summary>
		// Token: 0x0600DEB6 RID: 57014 RVA: 0x00135224 File Offset: 0x00133424
		public virtual double GetRotationScale()
		{
			return vtkStreamTracer.vtkStreamTracer_GetRotationScale_22(base.GetCppThis());
		}

		// Token: 0x0600DEB7 RID: 57015
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStreamTracer_GetSource_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the source object used to generate starting points (seeds).
		/// Note that this method does not connect the pipeline. The algorithm will
		/// work on the input data as it is without updating the producer of the data.
		/// See SetSourceConnection for connecting the pipeline.
		/// </summary>
		// Token: 0x0600DEB8 RID: 57016 RVA: 0x00135244 File Offset: 0x00133444
		public vtkDataSet GetSource()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStreamTracer.vtkStreamTracer_GetSource_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		// Token: 0x0600DEB9 RID: 57017
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStreamTracer_GetStartPosition_24(HandleRef pThis);

		/// <summary>
		/// Specify the starting point (seed) of a streamline in the global
		/// coordinate system. Search must be performed to find the initial cell
		/// from which to start integration.
		/// </summary>
		// Token: 0x0600DEBA RID: 57018 RVA: 0x001352B4 File Offset: 0x001334B4
		public virtual double[] GetStartPosition()
		{
			IntPtr intPtr = vtkStreamTracer.vtkStreamTracer_GetStartPosition_24(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600DEBB RID: 57019
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStreamTracer_GetStartPosition_25(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Specify the starting point (seed) of a streamline in the global
		/// coordinate system. Search must be performed to find the initial cell
		/// from which to start integration.
		/// </summary>
		// Token: 0x0600DEBC RID: 57020 RVA: 0x001352FC File Offset: 0x001334FC
		public virtual void GetStartPosition(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkStreamTracer.vtkStreamTracer_GetStartPosition_25(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600DEBD RID: 57021
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStreamTracer_GetStartPosition_26(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify the starting point (seed) of a streamline in the global
		/// coordinate system. Search must be performed to find the initial cell
		/// from which to start integration.
		/// </summary>
		// Token: 0x0600DEBE RID: 57022 RVA: 0x0013530E File Offset: 0x0013350E
		public virtual void GetStartPosition(IntPtr _arg)
		{
			vtkStreamTracer.vtkStreamTracer_GetStartPosition_26(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DEBF RID: 57023
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStreamTracer_GetSurfaceStreamlines_27(HandleRef pThis);

		/// <summary>
		/// Specify whether streamlines should be computed on a surface.
		/// </summary>
		// Token: 0x0600DEC0 RID: 57024 RVA: 0x00135320 File Offset: 0x00133520
		public virtual bool GetSurfaceStreamlines()
		{
			return vtkStreamTracer.vtkStreamTracer_GetSurfaceStreamlines_27(base.GetCppThis()) != 0;
		}

		// Token: 0x0600DEC1 RID: 57025
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkStreamTracer_GetTerminalSpeed_28(HandleRef pThis);

		/// <summary>
		/// Specify the terminal speed value, below which streamline integration is
		/// terminated.
		/// </summary>
		// Token: 0x0600DEC2 RID: 57026 RVA: 0x00135348 File Offset: 0x00133548
		public virtual double GetTerminalSpeed()
		{
			return vtkStreamTracer.vtkStreamTracer_GetTerminalSpeed_28(base.GetCppThis());
		}

		// Token: 0x0600DEC3 RID: 57027
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStreamTracer_GetUseLocalSeedSource_29(HandleRef pThis);

		/// <summary>
		/// If true the filter considers that the whole seed source is available on all ranks.
		/// Else the filter will aggregate all seed sources from all ranks and merge their points.
		///
		/// This property only makes sense when the filter is parallelized and is a no-op for its
		/// sequential version. However, this member function needs to be defined in this class to
		/// maintain a uniform interface between vtkStreamTracer and its parallel override class,
		/// vtkPStreamTracer.
		/// Default is true.
		/// </summary>
		// Token: 0x0600DEC4 RID: 57028 RVA: 0x00135368 File Offset: 0x00133568
		public virtual bool GetUseLocalSeedSource()
		{
			return vtkStreamTracer.vtkStreamTracer_GetUseLocalSeedSource_29(base.GetCppThis()) != 0;
		}

		// Token: 0x0600DEC5 RID: 57029
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStreamTracer_IsA_30(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to obtain type information and print object state.
		/// </summary>
		// Token: 0x0600DEC6 RID: 57030 RVA: 0x00135390 File Offset: 0x00133590
		public override int IsA(string type)
		{
			return vtkStreamTracer.vtkStreamTracer_IsA_30(base.GetCppThis(), type);
		}

		// Token: 0x0600DEC7 RID: 57031
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStreamTracer_IsTypeOf_31([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to obtain type information and print object state.
		/// </summary>
		// Token: 0x0600DEC8 RID: 57032 RVA: 0x001353B0 File Offset: 0x001335B0
		public new static int IsTypeOf(string type)
		{
			return vtkStreamTracer.vtkStreamTracer_IsTypeOf_31(type);
		}

		// Token: 0x0600DEC9 RID: 57033
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStreamTracer_NewInstance_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods to obtain type information and print object state.
		/// </summary>
		// Token: 0x0600DECA RID: 57034 RVA: 0x001353CC File Offset: 0x001335CC
		public new vtkStreamTracer NewInstance()
		{
			vtkStreamTracer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStreamTracer.vtkStreamTracer_NewInstance_33(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStreamTracer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600DECB RID: 57035
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStreamTracer_SafeDownCast_34(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods to obtain type information and print object state.
		/// </summary>
		// Token: 0x0600DECC RID: 57036 RVA: 0x00135428 File Offset: 0x00133628
		public new static vtkStreamTracer SafeDownCast(vtkObjectBase o)
		{
			vtkStreamTracer vtkStreamTracer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStreamTracer.vtkStreamTracer_SafeDownCast_34((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStreamTracer = (vtkStreamTracer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStreamTracer.Register(null);
				}
			}
			return vtkStreamTracer;
		}

		// Token: 0x0600DECD RID: 57037
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStreamTracer_SetComputeVorticity_35(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on/off vorticity computation at streamline points
		/// (necessary for generating proper stream-ribbons using the
		/// vtkRibbonFilter).
		/// </summary>
		// Token: 0x0600DECE RID: 57038 RVA: 0x001354A7 File Offset: 0x001336A7
		public virtual void SetComputeVorticity(bool _arg)
		{
			vtkStreamTracer.vtkStreamTracer_SetComputeVorticity_35(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600DECF RID: 57039
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStreamTracer_SetForceSerialExecution_36(HandleRef pThis, byte _arg);

		/// <summary>
		/// Force the filter to run stream tracer advection in serial. This affects
		/// the filter only if more than one streamline is to be generated.
		/// </summary>
		// Token: 0x0600DED0 RID: 57040 RVA: 0x001354BF File Offset: 0x001336BF
		public virtual void SetForceSerialExecution(bool _arg)
		{
			vtkStreamTracer.vtkStreamTracer_SetForceSerialExecution_36(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600DED1 RID: 57041
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStreamTracer_SetInitialIntegrationStep_37(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the Initial step size used for line integration, expressed in:
		/// LENGTH_UNIT      = 1
		/// CELL_LENGTH_UNIT = 2
		/// (either the starting size for an adaptive integrator, e.g., RK45,
		/// or the constant / fixed size for non-adaptive ones, i.e., RK2 and RK4)
		/// </summary>
		// Token: 0x0600DED2 RID: 57042 RVA: 0x001354D7 File Offset: 0x001336D7
		public virtual void SetInitialIntegrationStep(double _arg)
		{
			vtkStreamTracer.vtkStreamTracer_SetInitialIntegrationStep_37(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DED3 RID: 57043
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStreamTracer_SetIntegrationDirection_38(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify whether the streamline is integrated in the upstream or
		/// downstream direction, or in both directions. (If integrated in both
		/// directions, two separate streamlines are generated, both of which which
		/// start at the seed point with one traveling in the forward direction, and
		/// one in the backward direction.)
		/// </summary>
		// Token: 0x0600DED4 RID: 57044 RVA: 0x001354E7 File Offset: 0x001336E7
		public virtual void SetIntegrationDirection(int _arg)
		{
			vtkStreamTracer.vtkStreamTracer_SetIntegrationDirection_38(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DED5 RID: 57045
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStreamTracer_SetIntegrationDirectionToBackward_39(HandleRef pThis);

		/// <summary>
		/// Specify whether the streamline is integrated in the upstream or
		/// downstream direction, or in both directions. (If integrated in both
		/// directions, two separate streamlines are generated, both of which which
		/// start at the seed point with one traveling in the forward direction, and
		/// one in the backward direction.)
		/// </summary>
		// Token: 0x0600DED6 RID: 57046 RVA: 0x001354F7 File Offset: 0x001336F7
		public void SetIntegrationDirectionToBackward()
		{
			vtkStreamTracer.vtkStreamTracer_SetIntegrationDirectionToBackward_39(base.GetCppThis());
		}

		// Token: 0x0600DED7 RID: 57047
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStreamTracer_SetIntegrationDirectionToBoth_40(HandleRef pThis);

		/// <summary>
		/// Specify whether the streamline is integrated in the upstream or
		/// downstream direction, or in both directions. (If integrated in both
		/// directions, two separate streamlines are generated, both of which which
		/// start at the seed point with one traveling in the forward direction, and
		/// one in the backward direction.)
		/// </summary>
		// Token: 0x0600DED8 RID: 57048 RVA: 0x00135506 File Offset: 0x00133706
		public void SetIntegrationDirectionToBoth()
		{
			vtkStreamTracer.vtkStreamTracer_SetIntegrationDirectionToBoth_40(base.GetCppThis());
		}

		// Token: 0x0600DED9 RID: 57049
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStreamTracer_SetIntegrationDirectionToForward_41(HandleRef pThis);

		/// <summary>
		/// Specify whether the streamline is integrated in the upstream or
		/// downstream direction, or in both directions. (If integrated in both
		/// directions, two separate streamlines are generated, both of which which
		/// start at the seed point with one traveling in the forward direction, and
		/// one in the backward direction.)
		/// </summary>
		// Token: 0x0600DEDA RID: 57050 RVA: 0x00135515 File Offset: 0x00133715
		public void SetIntegrationDirectionToForward()
		{
			vtkStreamTracer.vtkStreamTracer_SetIntegrationDirectionToForward_41(base.GetCppThis());
		}

		// Token: 0x0600DEDB RID: 57051
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStreamTracer_SetIntegrationStepUnit_42(HandleRef pThis, int unit);

		/// <summary>
		/// Specify a uniform integration step unit for MinimumIntegrationStep,
		/// InitialIntegrationStep, and MaximumIntegrationStep. NOTE: The valid
		/// unit is now limited to only LENGTH_UNIT (1) and CELL_LENGTH_UNIT (2),
		/// EXCLUDING the previously-supported TIME_UNIT.
		/// </summary>
		// Token: 0x0600DEDC RID: 57052 RVA: 0x00135524 File Offset: 0x00133724
		public void SetIntegrationStepUnit(int unit)
		{
			vtkStreamTracer.vtkStreamTracer_SetIntegrationStepUnit_42(base.GetCppThis(), unit);
		}

		// Token: 0x0600DEDD RID: 57053
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStreamTracer_SetIntegrator_43(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/get the integrator type to be used for streamline generation.
		/// The object passed is not actually used but is cloned with
		/// NewInstance in the process of integration  (prototype pattern).
		/// The default is Runge-Kutta2. The integrator can also be changed
		/// using SetIntegratorType. The recognized solvers are:
		/// RUNGE_KUTTA2  = 0
		/// RUNGE_KUTTA4  = 1
		/// RUNGE_KUTTA45 = 2
		/// </summary>
		// Token: 0x0600DEDE RID: 57054 RVA: 0x00135534 File Offset: 0x00133734
		public void SetIntegrator(vtkInitialValueProblemSolver arg0)
		{
			vtkStreamTracer.vtkStreamTracer_SetIntegrator_43(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600DEDF RID: 57055
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStreamTracer_SetIntegratorType_44(HandleRef pThis, int type);

		/// <summary>
		/// Set/get the integrator type to be used for streamline generation.
		/// The object passed is not actually used but is cloned with
		/// NewInstance in the process of integration  (prototype pattern).
		/// The default is Runge-Kutta2. The integrator can also be changed
		/// using SetIntegratorType. The recognized solvers are:
		/// RUNGE_KUTTA2  = 0
		/// RUNGE_KUTTA4  = 1
		/// RUNGE_KUTTA45 = 2
		/// </summary>
		// Token: 0x0600DEE0 RID: 57056 RVA: 0x00135563 File Offset: 0x00133763
		public void SetIntegratorType(int type)
		{
			vtkStreamTracer.vtkStreamTracer_SetIntegratorType_44(base.GetCppThis(), type);
		}

		// Token: 0x0600DEE1 RID: 57057
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStreamTracer_SetIntegratorTypeToRungeKutta2_45(HandleRef pThis);

		/// <summary>
		/// Set/get the integrator type to be used for streamline generation.
		/// The object passed is not actually used but is cloned with
		/// NewInstance in the process of integration  (prototype pattern).
		/// The default is Runge-Kutta2. The integrator can also be changed
		/// using SetIntegratorType. The recognized solvers are:
		/// RUNGE_KUTTA2  = 0
		/// RUNGE_KUTTA4  = 1
		/// RUNGE_KUTTA45 = 2
		/// </summary>
		// Token: 0x0600DEE2 RID: 57058 RVA: 0x00135573 File Offset: 0x00133773
		public void SetIntegratorTypeToRungeKutta2()
		{
			vtkStreamTracer.vtkStreamTracer_SetIntegratorTypeToRungeKutta2_45(base.GetCppThis());
		}

		// Token: 0x0600DEE3 RID: 57059
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStreamTracer_SetIntegratorTypeToRungeKutta4_46(HandleRef pThis);

		/// <summary>
		/// Set/get the integrator type to be used for streamline generation.
		/// The object passed is not actually used but is cloned with
		/// NewInstance in the process of integration  (prototype pattern).
		/// The default is Runge-Kutta2. The integrator can also be changed
		/// using SetIntegratorType. The recognized solvers are:
		/// RUNGE_KUTTA2  = 0
		/// RUNGE_KUTTA4  = 1
		/// RUNGE_KUTTA45 = 2
		/// </summary>
		// Token: 0x0600DEE4 RID: 57060 RVA: 0x00135582 File Offset: 0x00133782
		public void SetIntegratorTypeToRungeKutta4()
		{
			vtkStreamTracer.vtkStreamTracer_SetIntegratorTypeToRungeKutta4_46(base.GetCppThis());
		}

		// Token: 0x0600DEE5 RID: 57061
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStreamTracer_SetIntegratorTypeToRungeKutta45_47(HandleRef pThis);

		/// <summary>
		/// Set/get the integrator type to be used for streamline generation.
		/// The object passed is not actually used but is cloned with
		/// NewInstance in the process of integration  (prototype pattern).
		/// The default is Runge-Kutta2. The integrator can also be changed
		/// using SetIntegratorType. The recognized solvers are:
		/// RUNGE_KUTTA2  = 0
		/// RUNGE_KUTTA4  = 1
		/// RUNGE_KUTTA45 = 2
		/// </summary>
		// Token: 0x0600DEE6 RID: 57062 RVA: 0x00135591 File Offset: 0x00133791
		public void SetIntegratorTypeToRungeKutta45()
		{
			vtkStreamTracer.vtkStreamTracer_SetIntegratorTypeToRungeKutta45_47(base.GetCppThis());
		}

		// Token: 0x0600DEE7 RID: 57063
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStreamTracer_SetInterpolatorPrototype_48(HandleRef pThis, HandleRef ivf);

		/// <summary>
		/// The object used to interpolate the velocity field during integration is
		/// of the same class as this prototype. The performance of streamline
		/// generations can be significantly affected by the choice of the
		/// interpolator, particularly its use of the locator to use.
		///
		/// For non AMR datasets, initialize a vtkCompositeInterpolatedVelocityField
		/// and set the FindCellStrategyType.
		/// </summary>
		// Token: 0x0600DEE8 RID: 57064 RVA: 0x001355A0 File Offset: 0x001337A0
		public void SetInterpolatorPrototype(vtkAbstractInterpolatedVelocityField ivf)
		{
			vtkStreamTracer.vtkStreamTracer_SetInterpolatorPrototype_48(base.GetCppThis(), (ivf == null) ? default(HandleRef) : ivf.GetCppThis());
		}

		// Token: 0x0600DEE9 RID: 57065
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStreamTracer_SetInterpolatorType_49(HandleRef pThis, int interpType);

		/// <summary>
		/// Set the type of the velocity field interpolator to determine whether
		/// INTERPOLATOR_WITH_DATASET_POINT_LOCATOR or INTERPOLATOR_WITH_CELL_LOCATOR
		/// is employed for locating cells during streamline integration. The latter
		/// (adopting vtkAbstractCellLocator sub-classes such as vtkCellLocator and
		/// vtkModifiedBSPTree) is more robust than the former (through vtkDataSet /
		/// vtkPointSet::FindCell() coupled with vtkPointLocator). However the former
		/// can be much faster and produce adequate results.
		/// </summary>
		// Token: 0x0600DEEA RID: 57066 RVA: 0x001355CF File Offset: 0x001337CF
		public void SetInterpolatorType(int interpType)
		{
			vtkStreamTracer.vtkStreamTracer_SetInterpolatorType_49(base.GetCppThis(), interpType);
		}

		// Token: 0x0600DEEB RID: 57067
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStreamTracer_SetInterpolatorTypeToCellLocator_50(HandleRef pThis);

		/// <summary>
		/// Set the velocity field interpolator type to one that uses a cell locator
		/// to perform spatial searching. Using a cell locator should always return
		/// the correct results, but it can be much slower that point locator-based
		/// searches.
		/// </summary>
		// Token: 0x0600DEEC RID: 57068 RVA: 0x001355DF File Offset: 0x001337DF
		public void SetInterpolatorTypeToCellLocator()
		{
			vtkStreamTracer.vtkStreamTracer_SetInterpolatorTypeToCellLocator_50(base.GetCppThis());
		}

		// Token: 0x0600DEED RID: 57069
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStreamTracer_SetInterpolatorTypeToDataSetPointLocator_51(HandleRef pThis);

		/// <summary>
		/// Set the velocity field interpolator type to one that uses a point
		/// locator to perform local spatial searching. Typically a point locator is
		/// faster than searches with a cell locator, but it may not always find the
		/// correct cells enclosing a point. This is particularly true with meshes
		/// that are disjoint at seams, or abut meshes in an incompatible manner.
		/// By default (and if a InterpolationPrototype is not set), a point locator
		/// is used.
		/// </summary>
		// Token: 0x0600DEEE RID: 57070 RVA: 0x001355EE File Offset: 0x001337EE
		public void SetInterpolatorTypeToDataSetPointLocator()
		{
			vtkStreamTracer.vtkStreamTracer_SetInterpolatorTypeToDataSetPointLocator_51(base.GetCppThis());
		}

		// Token: 0x0600DEEF RID: 57071
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStreamTracer_SetMaximumError_52(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the maximum error tolerated throughout streamline integration.
		/// </summary>
		// Token: 0x0600DEF0 RID: 57072 RVA: 0x001355FD File Offset: 0x001337FD
		public virtual void SetMaximumError(double _arg)
		{
			vtkStreamTracer.vtkStreamTracer_SetMaximumError_52(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DEF1 RID: 57073
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStreamTracer_SetMaximumIntegrationStep_53(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the Maximum step size used for line integration, expressed in:
		/// LENGTH_UNIT      = 1
		/// CELL_LENGTH_UNIT = 2
		/// (Only valid for an adaptive integrator, e.g., RK45)
		/// </summary>
		// Token: 0x0600DEF2 RID: 57074 RVA: 0x0013560D File Offset: 0x0013380D
		public virtual void SetMaximumIntegrationStep(double _arg)
		{
			vtkStreamTracer.vtkStreamTracer_SetMaximumIntegrationStep_53(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DEF3 RID: 57075
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStreamTracer_SetMaximumNumberOfSteps_54(HandleRef pThis, long _arg);

		/// <summary>
		/// Specify the maximum number of steps for integrating a streamline. Note
		/// that the number of steps generated is always one greater than
		/// MaximumNumberOfSteps. So if MaximumNumberOfSteps==0, then only one step
		/// will be generated. This is useful for advection situations when the
		/// stream tracer is to be propagated just one step at a time (e.g., see
		/// vtkStreamSurface which depends on this behavior).
		/// </summary>
		// Token: 0x0600DEF4 RID: 57076 RVA: 0x0013561D File Offset: 0x0013381D
		public virtual void SetMaximumNumberOfSteps(long _arg)
		{
			vtkStreamTracer.vtkStreamTracer_SetMaximumNumberOfSteps_54(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DEF5 RID: 57077
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStreamTracer_SetMaximumPropagation_55(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the maximum length of a streamline expressed in LENGTH_UNIT.
		/// </summary>
		// Token: 0x0600DEF6 RID: 57078 RVA: 0x0013562D File Offset: 0x0013382D
		public virtual void SetMaximumPropagation(double _arg)
		{
			vtkStreamTracer.vtkStreamTracer_SetMaximumPropagation_55(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DEF7 RID: 57079
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStreamTracer_SetMinimumIntegrationStep_56(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the Minimum step size used for line integration, expressed in:
		/// LENGTH_UNIT      = 1
		/// CELL_LENGTH_UNIT = 2
		/// (Only valid for an adaptive integrator, e.g., RK45)
		/// </summary>
		// Token: 0x0600DEF8 RID: 57080 RVA: 0x0013563D File Offset: 0x0013383D
		public virtual void SetMinimumIntegrationStep(double _arg)
		{
			vtkStreamTracer.vtkStreamTracer_SetMinimumIntegrationStep_56(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DEF9 RID: 57081
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStreamTracer_SetRotationScale_57(HandleRef pThis, double _arg);

		/// <summary>
		/// This can be used to scale the rate with which the streamribbons
		/// twist. The default is 1.
		/// </summary>
		// Token: 0x0600DEFA RID: 57082 RVA: 0x0013564D File Offset: 0x0013384D
		public virtual void SetRotationScale(double _arg)
		{
			vtkStreamTracer.vtkStreamTracer_SetRotationScale_57(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DEFB RID: 57083
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStreamTracer_SetSourceConnection_58(HandleRef pThis, HandleRef algOutput);

		/// <summary>
		/// Specify the source object used to generate starting points (seeds).
		/// This method connects to the pipeline: the Source will be updated
		/// and the results used as streamline seeds.
		/// </summary>
		// Token: 0x0600DEFC RID: 57084 RVA: 0x00135660 File Offset: 0x00133860
		public void SetSourceConnection(vtkAlgorithmOutput algOutput)
		{
			vtkStreamTracer.vtkStreamTracer_SetSourceConnection_58(base.GetCppThis(), (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}

		// Token: 0x0600DEFD RID: 57085
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStreamTracer_SetSourceData_59(HandleRef pThis, HandleRef source);

		/// <summary>
		/// Specify the source object used to generate starting points (seeds).
		/// Note that this method does not connect the pipeline. The algorithm will
		/// work on the input data as it is without updating the producer of the data.
		/// See SetSourceConnection for connecting the pipeline.
		/// </summary>
		// Token: 0x0600DEFE RID: 57086 RVA: 0x00135690 File Offset: 0x00133890
		public void SetSourceData(vtkDataSet source)
		{
			vtkStreamTracer.vtkStreamTracer_SetSourceData_59(base.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x0600DEFF RID: 57087
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStreamTracer_SetStartPosition_60(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Specify the starting point (seed) of a streamline in the global
		/// coordinate system. Search must be performed to find the initial cell
		/// from which to start integration.
		/// </summary>
		// Token: 0x0600DF00 RID: 57088 RVA: 0x001356BF File Offset: 0x001338BF
		public virtual void SetStartPosition(double _arg1, double _arg2, double _arg3)
		{
			vtkStreamTracer.vtkStreamTracer_SetStartPosition_60(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600DF01 RID: 57089
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStreamTracer_SetStartPosition_61(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify the starting point (seed) of a streamline in the global
		/// coordinate system. Search must be performed to find the initial cell
		/// from which to start integration.
		/// </summary>
		// Token: 0x0600DF02 RID: 57090 RVA: 0x001356D1 File Offset: 0x001338D1
		public virtual void SetStartPosition(IntPtr _arg)
		{
			vtkStreamTracer.vtkStreamTracer_SetStartPosition_61(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DF03 RID: 57091
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStreamTracer_SetSurfaceStreamlines_62(HandleRef pThis, byte _arg);

		/// <summary>
		/// Specify whether streamlines should be computed on a surface.
		/// </summary>
		// Token: 0x0600DF04 RID: 57092 RVA: 0x001356E1 File Offset: 0x001338E1
		public virtual void SetSurfaceStreamlines(bool _arg)
		{
			vtkStreamTracer.vtkStreamTracer_SetSurfaceStreamlines_62(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600DF05 RID: 57093
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStreamTracer_SetTerminalSpeed_63(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the terminal speed value, below which streamline integration is
		/// terminated.
		/// </summary>
		// Token: 0x0600DF06 RID: 57094 RVA: 0x001356F9 File Offset: 0x001338F9
		public virtual void SetTerminalSpeed(double _arg)
		{
			vtkStreamTracer.vtkStreamTracer_SetTerminalSpeed_63(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DF07 RID: 57095
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStreamTracer_SetUseLocalSeedSource_64(HandleRef pThis, byte _arg);

		/// <summary>
		/// If true the filter considers that the whole seed source is available on all ranks.
		/// Else the filter will aggregate all seed sources from all ranks and merge their points.
		///
		/// This property only makes sense when the filter is parallelized and is a no-op for its
		/// sequential version. However, this member function needs to be defined in this class to
		/// maintain a uniform interface between vtkStreamTracer and its parallel override class,
		/// vtkPStreamTracer.
		/// Default is true.
		/// </summary>
		// Token: 0x0600DF08 RID: 57096 RVA: 0x00135709 File Offset: 0x00133909
		public virtual void SetUseLocalSeedSource(bool _arg)
		{
			vtkStreamTracer.vtkStreamTracer_SetUseLocalSeedSource_64(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600DF09 RID: 57097
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStreamTracer_SurfaceStreamlinesOff_65(HandleRef pThis);

		/// <summary>
		/// Specify whether streamlines should be computed on a surface.
		/// </summary>
		// Token: 0x0600DF0A RID: 57098 RVA: 0x00135721 File Offset: 0x00133921
		public virtual void SurfaceStreamlinesOff()
		{
			vtkStreamTracer.vtkStreamTracer_SurfaceStreamlinesOff_65(base.GetCppThis());
		}

		// Token: 0x0600DF0B RID: 57099
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStreamTracer_SurfaceStreamlinesOn_66(HandleRef pThis);

		/// <summary>
		/// Specify whether streamlines should be computed on a surface.
		/// </summary>
		// Token: 0x0600DF0C RID: 57100 RVA: 0x00135730 File Offset: 0x00133930
		public virtual void SurfaceStreamlinesOn()
		{
			vtkStreamTracer.vtkStreamTracer_SurfaceStreamlinesOn_66(base.GetCppThis());
		}

		// Token: 0x0600DF0D RID: 57101
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStreamTracer_UseLocalSeedSourceOff_67(HandleRef pThis);

		/// <summary>
		/// If true the filter considers that the whole seed source is available on all ranks.
		/// Else the filter will aggregate all seed sources from all ranks and merge their points.
		///
		/// This property only makes sense when the filter is parallelized and is a no-op for its
		/// sequential version. However, this member function needs to be defined in this class to
		/// maintain a uniform interface between vtkStreamTracer and its parallel override class,
		/// vtkPStreamTracer.
		/// Default is true.
		/// </summary>
		// Token: 0x0600DF0E RID: 57102 RVA: 0x0013573F File Offset: 0x0013393F
		public virtual void UseLocalSeedSourceOff()
		{
			vtkStreamTracer.vtkStreamTracer_UseLocalSeedSourceOff_67(base.GetCppThis());
		}

		// Token: 0x0600DF0F RID: 57103
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStreamTracer_UseLocalSeedSourceOn_68(HandleRef pThis);

		/// <summary>
		/// If true the filter considers that the whole seed source is available on all ranks.
		/// Else the filter will aggregate all seed sources from all ranks and merge their points.
		///
		/// This property only makes sense when the filter is parallelized and is a no-op for its
		/// sequential version. However, this member function needs to be defined in this class to
		/// maintain a uniform interface between vtkStreamTracer and its parallel override class,
		/// vtkPStreamTracer.
		/// Default is true.
		/// </summary>
		// Token: 0x0600DF10 RID: 57104 RVA: 0x0013574E File Offset: 0x0013394E
		public virtual void UseLocalSeedSourceOn()
		{
			vtkStreamTracer.vtkStreamTracer_UseLocalSeedSourceOn_68(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001045 RID: 4165
		public new const string MRFullTypeName = "Kitware.VTK.vtkStreamTracer";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001046 RID: 4166
		public new static readonly string MRClassNameKey = "class vtkStreamTracer";

		/// <summary>
		/// Specify whether streamlines should be computed on a surface.
		/// </summary>
		// Token: 0x020004C0 RID: 1216
		public enum BACKWARD_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04001048 RID: 4168
			BACKWARD = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001049 RID: 4169
			BOTH,
			/// <summary>enum member</summary>
			// Token: 0x0400104A RID: 4170
			FORWARD = 0
		}

		/// <summary>
		/// Specify whether streamlines should be computed on a surface.
		/// </summary>
		// Token: 0x020004C1 RID: 1217
		public enum INTERPOLATOR_WITH_CELL_LOCATOR_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x0400104C RID: 4172
			INTERPOLATOR_WITH_CELL_LOCATOR = 1,
			/// <summary>enum member</summary>
			// Token: 0x0400104D RID: 4173
			INTERPOLATOR_WITH_DATASET_POINT_LOCATOR = 0
		}

		/// <summary>
		/// Specify the source object used to generate starting points (seeds).
		/// This method connects to the pipeline: the Source will be updated
		/// and the results used as streamline seeds.
		/// </summary>
		// Token: 0x020004C2 RID: 1218
		public enum ReasonForTermination
		{
			/// <summary>enum member</summary>
			// Token: 0x0400104F RID: 4175
			FIXED_REASONS_FOR_TERMINATION_COUNT = 7,
			/// <summary>enum member</summary>
			// Token: 0x04001050 RID: 4176
			NOT_INITIALIZED = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001051 RID: 4177
			OUT_OF_DOMAIN = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001052 RID: 4178
			OUT_OF_LENGTH = 4,
			/// <summary>enum member</summary>
			// Token: 0x04001053 RID: 4179
			OUT_OF_STEPS,
			/// <summary>enum member</summary>
			// Token: 0x04001054 RID: 4180
			STAGNATION,
			/// <summary>enum member</summary>
			// Token: 0x04001055 RID: 4181
			UNEXPECTED_VALUE = 3
		}

		/// <summary>
		/// Specify the source object used to generate starting points (seeds).
		/// This method connects to the pipeline: the Source will be updated
		/// and the results used as streamline seeds.
		/// </summary>
		// Token: 0x020004C3 RID: 1219
		public enum Solvers
		{
			/// <summary>enum member</summary>
			// Token: 0x04001057 RID: 4183
			NONE = 3,
			/// <summary>enum member</summary>
			// Token: 0x04001058 RID: 4184
			RUNGE_KUTTA2 = 0,
			/// <summary>enum member</summary>
			// Token: 0x04001059 RID: 4185
			RUNGE_KUTTA4,
			/// <summary>enum member</summary>
			// Token: 0x0400105A RID: 4186
			RUNGE_KUTTA45,
			/// <summary>enum member</summary>
			// Token: 0x0400105B RID: 4187
			UNKNOWN = 4
		}

		/// <summary>
		/// Specify the source object used to generate starting points (seeds).
		/// This method connects to the pipeline: the Source will be updated
		/// and the results used as streamline seeds.
		/// </summary>
		// Token: 0x020004C4 RID: 1220
		public enum Units
		{
			/// <summary>enum member</summary>
			// Token: 0x0400105D RID: 4189
			CELL_LENGTH_UNIT = 2,
			/// <summary>enum member</summary>
			// Token: 0x0400105E RID: 4190
			LENGTH_UNIT = 1
		}
	}
}
