using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGenericStreamTracer
	/// </summary>
	/// <remarks>
	///    Streamline generator
	///
	/// vtkGenericStreamTracer is a filter that integrates a vector field to
	/// generate streamlines. The integration is performed using the provided
	/// integrator. The default is second order Runge-Kutta.
	///
	/// vtkGenericStreamTracer generate polylines as output. Each cell (polyline)
	/// corresponds to one streamline. The values associated with each streamline
	/// are stored in the cell data whereas the values associated with points
	/// are stored in point data.
	///
	/// Note that vtkGenericStreamTracer can integrate both forward and backward.
	/// The length of the streamline is controlled by specifying either
	/// a maximum value in the units of length, cell length or elapsed time
	/// (the elapsed time is the time each particle would have traveled if
	/// flow were steady). Otherwise, the integration terminates after exiting
	/// the dataset or if the particle speed is reduced to a value less than
	/// the terminal speed or when a maximum number of steps is reached.
	/// The reason for the termination is stored in a cell array named
	/// ReasonForTermination.
	///
	/// The quality of integration can be controlled by setting integration
	/// step (InitialIntegrationStep) and in the case of adaptive solvers
	/// the maximum error, the minimum integration step and the maximum
	/// integration step. All of these can have units of length, cell length
	/// or elapsed time.
	///
	/// The integration time, vorticity, rotation and angular velocity
	/// are stored in point arrays named "IntegrationTime", "Vorticity",
	/// "Rotation" and "AngularVelocity" respectively (vorticity, rotation
	/// and angular velocity are computed only when ComputeVorticity is on).
	/// All point attributes in the source data set are interpolated on the
	/// new streamline points.
	///
	/// vtkGenericStreamTracer integrates through any type of dataset. As a result,
	/// if the dataset contains 2D cells such as polygons or triangles, the
	/// integration is constrained to lie on the surface defined by the 2D cells.
	///
	/// The starting point of traces may be defined in two different ways.
	/// Starting from global x-y-z "position" allows you to start a single trace
	/// at a specified x-y-z coordinate. If you specify a source object,
	/// a trace will be generated for each point in the source that is
	/// inside the dataset.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRibbonFilter vtkRuledSurfaceFilter vtkInitialValueProblemSolver
	/// vtkRungeKutta2 vtkRungeKutta4 vtkRungeKutta45
	/// </seealso>
	// Token: 0x020004A0 RID: 1184
	public class vtkGenericStreamTracer : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600DA50 RID: 55888 RVA: 0x0012F177 File Offset: 0x0012D377
		static vtkGenericStreamTracer()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenericStreamTracer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericStreamTracer"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600DA51 RID: 55889 RVA: 0x0012F19F File Offset: 0x0012D39F
		public vtkGenericStreamTracer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600DA52 RID: 55890
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericStreamTracer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object to start from position (0,0,0), integrate forward,
		/// terminal speed 1.0E-12, vorticity computation on, integration
		/// step length 0.5 (unit cell length), maximum number of steps 2000,
		/// using 2nd order Runge Kutta and maximum propagation 1.0 (unit length).
		/// </summary>
		// Token: 0x0600DA53 RID: 55891 RVA: 0x0012F1B0 File Offset: 0x0012D3B0
		public new static vtkGenericStreamTracer New()
		{
			vtkGenericStreamTracer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericStreamTracer.vtkGenericStreamTracer_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericStreamTracer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object to start from position (0,0,0), integrate forward,
		/// terminal speed 1.0E-12, vorticity computation on, integration
		/// step length 0.5 (unit cell length), maximum number of steps 2000,
		/// using 2nd order Runge Kutta and maximum propagation 1.0 (unit length).
		/// </summary>
		// Token: 0x0600DA54 RID: 55892 RVA: 0x0012F204 File Offset: 0x0012D404
		public vtkGenericStreamTracer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGenericStreamTracer.vtkGenericStreamTracer_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600DA55 RID: 55893 RVA: 0x0012F248 File Offset: 0x0012D448
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600DA56 RID: 55894
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericStreamTracer_AddInputData_01(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Add a dataset to the list inputs
		/// </summary>
		// Token: 0x0600DA57 RID: 55895 RVA: 0x0012F254 File Offset: 0x0012D454
		public void AddInputData(vtkGenericDataSet arg0)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_AddInputData_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600DA58 RID: 55896
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericStreamTracer_ComputeVorticityOff_02(HandleRef pThis);

		/// <summary>
		/// Turn on/off calculation of vorticity at streamline points
		/// (necessary for generating proper streamribbons using the
		/// vtkRibbonFilter.
		/// </summary>
		// Token: 0x0600DA59 RID: 55897 RVA: 0x0012F283 File Offset: 0x0012D483
		public virtual void ComputeVorticityOff()
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_ComputeVorticityOff_02(base.GetCppThis());
		}

		// Token: 0x0600DA5A RID: 55898
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericStreamTracer_ComputeVorticityOn_03(HandleRef pThis);

		/// <summary>
		/// Turn on/off calculation of vorticity at streamline points
		/// (necessary for generating proper streamribbons using the
		/// vtkRibbonFilter.
		/// </summary>
		// Token: 0x0600DA5B RID: 55899 RVA: 0x0012F292 File Offset: 0x0012D492
		public virtual void ComputeVorticityOn()
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_ComputeVorticityOn_03(base.GetCppThis());
		}

		// Token: 0x0600DA5C RID: 55900
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericStreamTracer_FillInputPortInformation_04(HandleRef pThis, int port, HandleRef info);

		/// <summary>
		/// Specify the source object used to generate starting points (seeds).
		/// New style.
		/// </summary>
		// Token: 0x0600DA5D RID: 55901 RVA: 0x0012F2A4 File Offset: 0x0012D4A4
		public virtual int FillInputPortInformation(int port, vtkInformation info)
		{
			return vtkGenericStreamTracer.vtkGenericStreamTracer_FillInputPortInformation_04(base.GetCppThis(), port, (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x0600DA5E RID: 55902
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericStreamTracer_GetComputeVorticity_05(HandleRef pThis);

		/// <summary>
		/// Turn on/off calculation of vorticity at streamline points
		/// (necessary for generating proper streamribbons using the
		/// vtkRibbonFilter.
		/// </summary>
		// Token: 0x0600DA5F RID: 55903 RVA: 0x0012F2DC File Offset: 0x0012D4DC
		public virtual int GetComputeVorticity()
		{
			return vtkGenericStreamTracer.vtkGenericStreamTracer_GetComputeVorticity_05(base.GetCppThis());
		}

		// Token: 0x0600DA60 RID: 55904
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGenericStreamTracer_GetInitialIntegrationStep_06(HandleRef pThis);

		/// <summary>
		/// Specify the initial step used in the integration expressed in
		/// one of the:
		/// TIME_UNIT        = 0
		/// LENGTH_UNIT      = 1
		/// CELL_LENGTH_UNIT = 2
		/// If the integrator is not adaptive, this is the actual
		/// step used.
		/// </summary>
		// Token: 0x0600DA61 RID: 55905 RVA: 0x0012F2FC File Offset: 0x0012D4FC
		public double GetInitialIntegrationStep()
		{
			return vtkGenericStreamTracer.vtkGenericStreamTracer_GetInitialIntegrationStep_06(base.GetCppThis());
		}

		// Token: 0x0600DA62 RID: 55906
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericStreamTracer_GetInitialIntegrationStepUnit_07(HandleRef pThis);

		/// <summary>
		/// Specify the initial step used in the integration expressed in
		/// one of the:
		/// TIME_UNIT        = 0
		/// LENGTH_UNIT      = 1
		/// CELL_LENGTH_UNIT = 2
		/// If the integrator is not adaptive, this is the actual
		/// step used.
		/// </summary>
		// Token: 0x0600DA63 RID: 55907 RVA: 0x0012F31C File Offset: 0x0012D51C
		public int GetInitialIntegrationStepUnit()
		{
			return vtkGenericStreamTracer.vtkGenericStreamTracer_GetInitialIntegrationStepUnit_07(base.GetCppThis());
		}

		// Token: 0x0600DA64 RID: 55908
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericStreamTracer_GetInputVectorsSelection_08(HandleRef pThis);

		/// <summary>
		/// If you want to generate traces using an arbitrary vector array,
		/// then set its name here. By default this in nullptr and the filter will
		/// use the active vector array.
		/// </summary>
		// Token: 0x0600DA65 RID: 55909 RVA: 0x0012F33C File Offset: 0x0012D53C
		public virtual string GetInputVectorsSelection()
		{
			string s = Marshal.PtrToStringAnsi(vtkGenericStreamTracer.vtkGenericStreamTracer_GetInputVectorsSelection_08(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600DA66 RID: 55910
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericStreamTracer_GetIntegrationDirection_09(HandleRef pThis);

		/// <summary>
		/// Specify whether the streamtrace will be generated in the
		/// upstream or downstream direction.
		/// </summary>
		// Token: 0x0600DA67 RID: 55911 RVA: 0x0012F378 File Offset: 0x0012D578
		public virtual int GetIntegrationDirection()
		{
			return vtkGenericStreamTracer.vtkGenericStreamTracer_GetIntegrationDirection_09(base.GetCppThis());
		}

		// Token: 0x0600DA68 RID: 55912
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericStreamTracer_GetIntegrationDirectionMaxValue_10(HandleRef pThis);

		/// <summary>
		/// Specify whether the streamtrace will be generated in the
		/// upstream or downstream direction.
		/// </summary>
		// Token: 0x0600DA69 RID: 55913 RVA: 0x0012F398 File Offset: 0x0012D598
		public virtual int GetIntegrationDirectionMaxValue()
		{
			return vtkGenericStreamTracer.vtkGenericStreamTracer_GetIntegrationDirectionMaxValue_10(base.GetCppThis());
		}

		// Token: 0x0600DA6A RID: 55914
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericStreamTracer_GetIntegrationDirectionMinValue_11(HandleRef pThis);

		/// <summary>
		/// Specify whether the streamtrace will be generated in the
		/// upstream or downstream direction.
		/// </summary>
		// Token: 0x0600DA6B RID: 55915 RVA: 0x0012F3B8 File Offset: 0x0012D5B8
		public virtual int GetIntegrationDirectionMinValue()
		{
			return vtkGenericStreamTracer.vtkGenericStreamTracer_GetIntegrationDirectionMinValue_11(base.GetCppThis());
		}

		// Token: 0x0600DA6C RID: 55916
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericStreamTracer_GetIntegrator_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get the integrator type to be used in the stream line
		/// calculation. The object passed is not actually used but
		/// is cloned with NewInstance in the process of integration
		/// (prototype pattern). The default is 2nd order Runge Kutta.
		/// The integrator can also be changed using SetIntegratorType.
		/// The recognized solvers are:
		/// RUNGE_KUTTA2  = 0
		/// RUNGE_KUTTA4  = 1
		/// RUNGE_KUTTA45 = 2
		/// </summary>
		// Token: 0x0600DA6D RID: 55917 RVA: 0x0012F3D8 File Offset: 0x0012D5D8
		public virtual vtkInitialValueProblemSolver GetIntegrator()
		{
			vtkInitialValueProblemSolver vtkInitialValueProblemSolver = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericStreamTracer.vtkGenericStreamTracer_GetIntegrator_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600DA6E RID: 55918
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericStreamTracer_GetIntegratorType_13(HandleRef pThis);

		/// <summary>
		/// Set/get the integrator type to be used in the stream line
		/// calculation. The object passed is not actually used but
		/// is cloned with NewInstance in the process of integration
		/// (prototype pattern). The default is 2nd order Runge Kutta.
		/// The integrator can also be changed using SetIntegratorType.
		/// The recognized solvers are:
		/// RUNGE_KUTTA2  = 0
		/// RUNGE_KUTTA4  = 1
		/// RUNGE_KUTTA45 = 2
		/// </summary>
		// Token: 0x0600DA6F RID: 55919 RVA: 0x0012F448 File Offset: 0x0012D648
		public int GetIntegratorType()
		{
			return vtkGenericStreamTracer.vtkGenericStreamTracer_GetIntegratorType_13(base.GetCppThis());
		}

		// Token: 0x0600DA70 RID: 55920
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGenericStreamTracer_GetMaximumError_14(HandleRef pThis);

		/// <summary>
		/// Specify the maximum error in the integration. This value
		/// is passed to the integrator. Therefore, it's meaning depends
		/// on the integrator used.
		/// </summary>
		// Token: 0x0600DA71 RID: 55921 RVA: 0x0012F468 File Offset: 0x0012D668
		public virtual double GetMaximumError()
		{
			return vtkGenericStreamTracer.vtkGenericStreamTracer_GetMaximumError_14(base.GetCppThis());
		}

		// Token: 0x0600DA72 RID: 55922
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGenericStreamTracer_GetMaximumIntegrationStep_15(HandleRef pThis);

		/// <summary>
		/// Specify the maximum step used in the integration expressed in
		/// one of the:
		/// TIME_UNIT        = 0
		/// LENGTH_UNIT      = 1
		/// CELL_LENGTH_UNIT = 2
		/// Only valid when using adaptive integrators.
		/// </summary>
		// Token: 0x0600DA73 RID: 55923 RVA: 0x0012F488 File Offset: 0x0012D688
		public double GetMaximumIntegrationStep()
		{
			return vtkGenericStreamTracer.vtkGenericStreamTracer_GetMaximumIntegrationStep_15(base.GetCppThis());
		}

		// Token: 0x0600DA74 RID: 55924
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericStreamTracer_GetMaximumIntegrationStepUnit_16(HandleRef pThis);

		/// <summary>
		/// Specify the maximum step used in the integration expressed in
		/// one of the:
		/// TIME_UNIT        = 0
		/// LENGTH_UNIT      = 1
		/// CELL_LENGTH_UNIT = 2
		/// Only valid when using adaptive integrators.
		/// </summary>
		// Token: 0x0600DA75 RID: 55925 RVA: 0x0012F4A8 File Offset: 0x0012D6A8
		public int GetMaximumIntegrationStepUnit()
		{
			return vtkGenericStreamTracer.vtkGenericStreamTracer_GetMaximumIntegrationStepUnit_16(base.GetCppThis());
		}

		// Token: 0x0600DA76 RID: 55926
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericStreamTracer_GetMaximumNumberOfSteps_17(HandleRef pThis);

		/// <summary>
		/// Specify the maximum number of steps used in the integration.
		/// </summary>
		// Token: 0x0600DA77 RID: 55927 RVA: 0x0012F4C8 File Offset: 0x0012D6C8
		public virtual long GetMaximumNumberOfSteps()
		{
			return vtkGenericStreamTracer.vtkGenericStreamTracer_GetMaximumNumberOfSteps_17(base.GetCppThis());
		}

		// Token: 0x0600DA78 RID: 55928
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGenericStreamTracer_GetMaximumPropagation_18(HandleRef pThis);

		/// <summary>
		/// Specify the maximum length of the streamlines expressed in
		/// one of the:
		/// TIME_UNIT        = 0
		/// LENGTH_UNIT      = 1
		/// CELL_LENGTH_UNIT = 2
		/// </summary>
		// Token: 0x0600DA79 RID: 55929 RVA: 0x0012F4E8 File Offset: 0x0012D6E8
		public double GetMaximumPropagation()
		{
			return vtkGenericStreamTracer.vtkGenericStreamTracer_GetMaximumPropagation_18(base.GetCppThis());
		}

		// Token: 0x0600DA7A RID: 55930
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericStreamTracer_GetMaximumPropagationUnit_19(HandleRef pThis);

		/// <summary>
		/// Specify the maximum length of the streamlines expressed in
		/// one of the:
		/// TIME_UNIT        = 0
		/// LENGTH_UNIT      = 1
		/// CELL_LENGTH_UNIT = 2
		/// </summary>
		// Token: 0x0600DA7B RID: 55931 RVA: 0x0012F508 File Offset: 0x0012D708
		public int GetMaximumPropagationUnit()
		{
			return vtkGenericStreamTracer.vtkGenericStreamTracer_GetMaximumPropagationUnit_19(base.GetCppThis());
		}

		// Token: 0x0600DA7C RID: 55932
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGenericStreamTracer_GetMinimumIntegrationStep_20(HandleRef pThis);

		/// <summary>
		/// Specify the minimum step used in the integration expressed in
		/// one of the:
		/// TIME_UNIT        = 0
		/// LENGTH_UNIT      = 1
		/// CELL_LENGTH_UNIT = 2
		/// Only valid when using adaptive integrators.
		/// </summary>
		// Token: 0x0600DA7D RID: 55933 RVA: 0x0012F528 File Offset: 0x0012D728
		public double GetMinimumIntegrationStep()
		{
			return vtkGenericStreamTracer.vtkGenericStreamTracer_GetMinimumIntegrationStep_20(base.GetCppThis());
		}

		// Token: 0x0600DA7E RID: 55934
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericStreamTracer_GetMinimumIntegrationStepUnit_21(HandleRef pThis);

		/// <summary>
		/// Specify the minimum step used in the integration expressed in
		/// one of the:
		/// TIME_UNIT        = 0
		/// LENGTH_UNIT      = 1
		/// CELL_LENGTH_UNIT = 2
		/// Only valid when using adaptive integrators.
		/// </summary>
		// Token: 0x0600DA7F RID: 55935 RVA: 0x0012F548 File Offset: 0x0012D748
		public int GetMinimumIntegrationStepUnit()
		{
			return vtkGenericStreamTracer.vtkGenericStreamTracer_GetMinimumIntegrationStepUnit_21(base.GetCppThis());
		}

		// Token: 0x0600DA80 RID: 55936
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericStreamTracer_GetNumberOfGenerationsFromBase_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DA81 RID: 55937 RVA: 0x0012F568 File Offset: 0x0012D768
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGenericStreamTracer.vtkGenericStreamTracer_GetNumberOfGenerationsFromBase_22(base.GetCppThis(), type);
		}

		// Token: 0x0600DA82 RID: 55938
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericStreamTracer_GetNumberOfGenerationsFromBaseType_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DA83 RID: 55939 RVA: 0x0012F588 File Offset: 0x0012D788
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGenericStreamTracer.vtkGenericStreamTracer_GetNumberOfGenerationsFromBaseType_23(type);
		}

		// Token: 0x0600DA84 RID: 55940
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGenericStreamTracer_GetRotationScale_24(HandleRef pThis);

		/// <summary>
		/// This can be used to scale the rate with which the streamribbons
		/// twist. The default is 1.
		/// </summary>
		// Token: 0x0600DA85 RID: 55941 RVA: 0x0012F5A4 File Offset: 0x0012D7A4
		public virtual double GetRotationScale()
		{
			return vtkGenericStreamTracer.vtkGenericStreamTracer_GetRotationScale_24(base.GetCppThis());
		}

		// Token: 0x0600DA86 RID: 55942
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericStreamTracer_GetSource_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the source object used to generate starting points.
		/// </summary>
		// Token: 0x0600DA87 RID: 55943 RVA: 0x0012F5C4 File Offset: 0x0012D7C4
		public vtkDataSet GetSource()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericStreamTracer.vtkGenericStreamTracer_GetSource_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600DA88 RID: 55944
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericStreamTracer_GetStartPosition_26(HandleRef pThis);

		/// <summary>
		/// Specify the start of the streamline in the global coordinate
		/// system. Search must be performed to find initial cell to start
		/// integration from.
		/// </summary>
		// Token: 0x0600DA89 RID: 55945 RVA: 0x0012F634 File Offset: 0x0012D834
		public virtual double[] GetStartPosition()
		{
			IntPtr intPtr = vtkGenericStreamTracer.vtkGenericStreamTracer_GetStartPosition_26(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600DA8A RID: 55946
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericStreamTracer_GetStartPosition_27(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Specify the start of the streamline in the global coordinate
		/// system. Search must be performed to find initial cell to start
		/// integration from.
		/// </summary>
		// Token: 0x0600DA8B RID: 55947 RVA: 0x0012F67C File Offset: 0x0012D87C
		public virtual void GetStartPosition(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_GetStartPosition_27(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600DA8C RID: 55948
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericStreamTracer_GetStartPosition_28(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify the start of the streamline in the global coordinate
		/// system. Search must be performed to find initial cell to start
		/// integration from.
		/// </summary>
		// Token: 0x0600DA8D RID: 55949 RVA: 0x0012F68E File Offset: 0x0012D88E
		public virtual void GetStartPosition(IntPtr _arg)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_GetStartPosition_28(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DA8E RID: 55950
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGenericStreamTracer_GetTerminalSpeed_29(HandleRef pThis);

		/// <summary>
		/// If at any point, the speed is below this value, the integration
		/// is terminated.
		/// </summary>
		// Token: 0x0600DA8F RID: 55951 RVA: 0x0012F6A0 File Offset: 0x0012D8A0
		public virtual double GetTerminalSpeed()
		{
			return vtkGenericStreamTracer.vtkGenericStreamTracer_GetTerminalSpeed_29(base.GetCppThis());
		}

		// Token: 0x0600DA90 RID: 55952
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericStreamTracer_IsA_30(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DA91 RID: 55953 RVA: 0x0012F6C0 File Offset: 0x0012D8C0
		public override int IsA(string type)
		{
			return vtkGenericStreamTracer.vtkGenericStreamTracer_IsA_30(base.GetCppThis(), type);
		}

		// Token: 0x0600DA92 RID: 55954
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericStreamTracer_IsTypeOf_31([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DA93 RID: 55955 RVA: 0x0012F6E0 File Offset: 0x0012D8E0
		public new static int IsTypeOf(string type)
		{
			return vtkGenericStreamTracer.vtkGenericStreamTracer_IsTypeOf_31(type);
		}

		// Token: 0x0600DA94 RID: 55956
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericStreamTracer_NewInstance_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DA95 RID: 55957 RVA: 0x0012F6FC File Offset: 0x0012D8FC
		public new vtkGenericStreamTracer NewInstance()
		{
			vtkGenericStreamTracer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericStreamTracer.vtkGenericStreamTracer_NewInstance_33(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericStreamTracer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600DA96 RID: 55958
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericStreamTracer_SafeDownCast_34(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DA97 RID: 55959 RVA: 0x0012F758 File Offset: 0x0012D958
		public new static vtkGenericStreamTracer SafeDownCast(vtkObjectBase o)
		{
			vtkGenericStreamTracer vtkGenericStreamTracer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericStreamTracer.vtkGenericStreamTracer_SafeDownCast_34((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericStreamTracer = (vtkGenericStreamTracer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericStreamTracer.Register(null);
				}
			}
			return vtkGenericStreamTracer;
		}

		// Token: 0x0600DA98 RID: 55960
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericStreamTracer_SelectInputVectors_35(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fieldName);

		/// <summary>
		/// If you want to generate traces using an arbitrary vector array,
		/// then set its name here. By default this in nullptr and the filter will
		/// use the active vector array.
		/// </summary>
		// Token: 0x0600DA99 RID: 55961 RVA: 0x0012F7D7 File Offset: 0x0012D9D7
		public void SelectInputVectors(string fieldName)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SelectInputVectors_35(base.GetCppThis(), fieldName);
		}

		// Token: 0x0600DA9A RID: 55962
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericStreamTracer_SetComputeVorticity_36(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off calculation of vorticity at streamline points
		/// (necessary for generating proper streamribbons using the
		/// vtkRibbonFilter.
		/// </summary>
		// Token: 0x0600DA9B RID: 55963 RVA: 0x0012F7E7 File Offset: 0x0012D9E7
		public virtual void SetComputeVorticity(int _arg)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetComputeVorticity_36(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DA9C RID: 55964
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericStreamTracer_SetInitialIntegrationStep_37(HandleRef pThis, int unit, double step);

		/// <summary>
		/// Specify the initial step used in the integration expressed in
		/// one of the:
		/// TIME_UNIT        = 0
		/// LENGTH_UNIT      = 1
		/// CELL_LENGTH_UNIT = 2
		/// If the integrator is not adaptive, this is the actual
		/// step used.
		/// </summary>
		// Token: 0x0600DA9D RID: 55965 RVA: 0x0012F7F7 File Offset: 0x0012D9F7
		public void SetInitialIntegrationStep(int unit, double step)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetInitialIntegrationStep_37(base.GetCppThis(), unit, step);
		}

		// Token: 0x0600DA9E RID: 55966
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericStreamTracer_SetInitialIntegrationStep_38(HandleRef pThis, double step);

		/// <summary>
		/// Specify the initial step used in the integration expressed in
		/// one of the:
		/// TIME_UNIT        = 0
		/// LENGTH_UNIT      = 1
		/// CELL_LENGTH_UNIT = 2
		/// If the integrator is not adaptive, this is the actual
		/// step used.
		/// </summary>
		// Token: 0x0600DA9F RID: 55967 RVA: 0x0012F808 File Offset: 0x0012DA08
		public void SetInitialIntegrationStep(double step)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetInitialIntegrationStep_38(base.GetCppThis(), step);
		}

		// Token: 0x0600DAA0 RID: 55968
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericStreamTracer_SetInitialIntegrationStepUnit_39(HandleRef pThis, int unit);

		/// <summary>
		/// Specify the initial step used in the integration expressed in
		/// one of the:
		/// TIME_UNIT        = 0
		/// LENGTH_UNIT      = 1
		/// CELL_LENGTH_UNIT = 2
		/// If the integrator is not adaptive, this is the actual
		/// step used.
		/// </summary>
		// Token: 0x0600DAA1 RID: 55969 RVA: 0x0012F818 File Offset: 0x0012DA18
		public void SetInitialIntegrationStepUnit(int unit)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetInitialIntegrationStepUnit_39(base.GetCppThis(), unit);
		}

		// Token: 0x0600DAA2 RID: 55970
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericStreamTracer_SetInitialIntegrationStepUnitToCellLengthUnit_40(HandleRef pThis);

		/// <summary>
		/// Specify the initial step used in the integration expressed in
		/// one of the:
		/// TIME_UNIT        = 0
		/// LENGTH_UNIT      = 1
		/// CELL_LENGTH_UNIT = 2
		/// If the integrator is not adaptive, this is the actual
		/// step used.
		/// </summary>
		// Token: 0x0600DAA3 RID: 55971 RVA: 0x0012F828 File Offset: 0x0012DA28
		public void SetInitialIntegrationStepUnitToCellLengthUnit()
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetInitialIntegrationStepUnitToCellLengthUnit_40(base.GetCppThis());
		}

		// Token: 0x0600DAA4 RID: 55972
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericStreamTracer_SetInitialIntegrationStepUnitToLengthUnit_41(HandleRef pThis);

		/// <summary>
		/// Specify the initial step used in the integration expressed in
		/// one of the:
		/// TIME_UNIT        = 0
		/// LENGTH_UNIT      = 1
		/// CELL_LENGTH_UNIT = 2
		/// If the integrator is not adaptive, this is the actual
		/// step used.
		/// </summary>
		// Token: 0x0600DAA5 RID: 55973 RVA: 0x0012F837 File Offset: 0x0012DA37
		public void SetInitialIntegrationStepUnitToLengthUnit()
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetInitialIntegrationStepUnitToLengthUnit_41(base.GetCppThis());
		}

		// Token: 0x0600DAA6 RID: 55974
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericStreamTracer_SetInitialIntegrationStepUnitToTimeUnit_42(HandleRef pThis);

		/// <summary>
		/// Specify the initial step used in the integration expressed in
		/// one of the:
		/// TIME_UNIT        = 0
		/// LENGTH_UNIT      = 1
		/// CELL_LENGTH_UNIT = 2
		/// If the integrator is not adaptive, this is the actual
		/// step used.
		/// </summary>
		// Token: 0x0600DAA7 RID: 55975 RVA: 0x0012F846 File Offset: 0x0012DA46
		public void SetInitialIntegrationStepUnitToTimeUnit()
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetInitialIntegrationStepUnitToTimeUnit_42(base.GetCppThis());
		}

		// Token: 0x0600DAA8 RID: 55976
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericStreamTracer_SetIntegrationDirection_43(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify whether the streamtrace will be generated in the
		/// upstream or downstream direction.
		/// </summary>
		// Token: 0x0600DAA9 RID: 55977 RVA: 0x0012F855 File Offset: 0x0012DA55
		public virtual void SetIntegrationDirection(int _arg)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetIntegrationDirection_43(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DAAA RID: 55978
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericStreamTracer_SetIntegrationDirectionToBackward_44(HandleRef pThis);

		/// <summary>
		/// Specify whether the streamtrace will be generated in the
		/// upstream or downstream direction.
		/// </summary>
		// Token: 0x0600DAAB RID: 55979 RVA: 0x0012F865 File Offset: 0x0012DA65
		public void SetIntegrationDirectionToBackward()
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetIntegrationDirectionToBackward_44(base.GetCppThis());
		}

		// Token: 0x0600DAAC RID: 55980
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericStreamTracer_SetIntegrationDirectionToBoth_45(HandleRef pThis);

		/// <summary>
		/// Specify whether the streamtrace will be generated in the
		/// upstream or downstream direction.
		/// </summary>
		// Token: 0x0600DAAD RID: 55981 RVA: 0x0012F874 File Offset: 0x0012DA74
		public void SetIntegrationDirectionToBoth()
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetIntegrationDirectionToBoth_45(base.GetCppThis());
		}

		// Token: 0x0600DAAE RID: 55982
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericStreamTracer_SetIntegrationDirectionToForward_46(HandleRef pThis);

		/// <summary>
		/// Specify whether the streamtrace will be generated in the
		/// upstream or downstream direction.
		/// </summary>
		// Token: 0x0600DAAF RID: 55983 RVA: 0x0012F883 File Offset: 0x0012DA83
		public void SetIntegrationDirectionToForward()
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetIntegrationDirectionToForward_46(base.GetCppThis());
		}

		// Token: 0x0600DAB0 RID: 55984
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericStreamTracer_SetIntegrationStepUnit_47(HandleRef pThis, int unit);

		/// <summary>
		/// Simplified API to set an homogeneous unit across Min/Max/Init IntegrationStepUnit
		/// </summary>
		// Token: 0x0600DAB1 RID: 55985 RVA: 0x0012F892 File Offset: 0x0012DA92
		public void SetIntegrationStepUnit(int unit)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetIntegrationStepUnit_47(base.GetCppThis(), unit);
		}

		// Token: 0x0600DAB2 RID: 55986
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericStreamTracer_SetIntegrator_48(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/get the integrator type to be used in the stream line
		/// calculation. The object passed is not actually used but
		/// is cloned with NewInstance in the process of integration
		/// (prototype pattern). The default is 2nd order Runge Kutta.
		/// The integrator can also be changed using SetIntegratorType.
		/// The recognized solvers are:
		/// RUNGE_KUTTA2  = 0
		/// RUNGE_KUTTA4  = 1
		/// RUNGE_KUTTA45 = 2
		/// </summary>
		// Token: 0x0600DAB3 RID: 55987 RVA: 0x0012F8A4 File Offset: 0x0012DAA4
		public void SetIntegrator(vtkInitialValueProblemSolver arg0)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetIntegrator_48(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600DAB4 RID: 55988
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericStreamTracer_SetIntegratorType_49(HandleRef pThis, int type);

		/// <summary>
		/// Set/get the integrator type to be used in the stream line
		/// calculation. The object passed is not actually used but
		/// is cloned with NewInstance in the process of integration
		/// (prototype pattern). The default is 2nd order Runge Kutta.
		/// The integrator can also be changed using SetIntegratorType.
		/// The recognized solvers are:
		/// RUNGE_KUTTA2  = 0
		/// RUNGE_KUTTA4  = 1
		/// RUNGE_KUTTA45 = 2
		/// </summary>
		// Token: 0x0600DAB5 RID: 55989 RVA: 0x0012F8D3 File Offset: 0x0012DAD3
		public void SetIntegratorType(int type)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetIntegratorType_49(base.GetCppThis(), type);
		}

		// Token: 0x0600DAB6 RID: 55990
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericStreamTracer_SetIntegratorTypeToRungeKutta2_50(HandleRef pThis);

		/// <summary>
		/// Set/get the integrator type to be used in the stream line
		/// calculation. The object passed is not actually used but
		/// is cloned with NewInstance in the process of integration
		/// (prototype pattern). The default is 2nd order Runge Kutta.
		/// The integrator can also be changed using SetIntegratorType.
		/// The recognized solvers are:
		/// RUNGE_KUTTA2  = 0
		/// RUNGE_KUTTA4  = 1
		/// RUNGE_KUTTA45 = 2
		/// </summary>
		// Token: 0x0600DAB7 RID: 55991 RVA: 0x0012F8E3 File Offset: 0x0012DAE3
		public void SetIntegratorTypeToRungeKutta2()
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetIntegratorTypeToRungeKutta2_50(base.GetCppThis());
		}

		// Token: 0x0600DAB8 RID: 55992
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericStreamTracer_SetIntegratorTypeToRungeKutta4_51(HandleRef pThis);

		/// <summary>
		/// Set/get the integrator type to be used in the stream line
		/// calculation. The object passed is not actually used but
		/// is cloned with NewInstance in the process of integration
		/// (prototype pattern). The default is 2nd order Runge Kutta.
		/// The integrator can also be changed using SetIntegratorType.
		/// The recognized solvers are:
		/// RUNGE_KUTTA2  = 0
		/// RUNGE_KUTTA4  = 1
		/// RUNGE_KUTTA45 = 2
		/// </summary>
		// Token: 0x0600DAB9 RID: 55993 RVA: 0x0012F8F2 File Offset: 0x0012DAF2
		public void SetIntegratorTypeToRungeKutta4()
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetIntegratorTypeToRungeKutta4_51(base.GetCppThis());
		}

		// Token: 0x0600DABA RID: 55994
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericStreamTracer_SetIntegratorTypeToRungeKutta45_52(HandleRef pThis);

		/// <summary>
		/// Set/get the integrator type to be used in the stream line
		/// calculation. The object passed is not actually used but
		/// is cloned with NewInstance in the process of integration
		/// (prototype pattern). The default is 2nd order Runge Kutta.
		/// The integrator can also be changed using SetIntegratorType.
		/// The recognized solvers are:
		/// RUNGE_KUTTA2  = 0
		/// RUNGE_KUTTA4  = 1
		/// RUNGE_KUTTA45 = 2
		/// </summary>
		// Token: 0x0600DABB RID: 55995 RVA: 0x0012F901 File Offset: 0x0012DB01
		public void SetIntegratorTypeToRungeKutta45()
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetIntegratorTypeToRungeKutta45_52(base.GetCppThis());
		}

		// Token: 0x0600DABC RID: 55996
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericStreamTracer_SetInterpolatorPrototype_53(HandleRef pThis, HandleRef ivf);

		/// <summary>
		/// The object used to interpolate the velocity field during
		/// integration is of the same class as this prototype.
		/// </summary>
		// Token: 0x0600DABD RID: 55997 RVA: 0x0012F910 File Offset: 0x0012DB10
		public void SetInterpolatorPrototype(vtkGenericInterpolatedVelocityField ivf)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetInterpolatorPrototype_53(base.GetCppThis(), (ivf == null) ? default(HandleRef) : ivf.GetCppThis());
		}

		// Token: 0x0600DABE RID: 55998
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericStreamTracer_SetMaximumError_54(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the maximum error in the integration. This value
		/// is passed to the integrator. Therefore, it's meaning depends
		/// on the integrator used.
		/// </summary>
		// Token: 0x0600DABF RID: 55999 RVA: 0x0012F93F File Offset: 0x0012DB3F
		public virtual void SetMaximumError(double _arg)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetMaximumError_54(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DAC0 RID: 56000
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericStreamTracer_SetMaximumIntegrationStep_55(HandleRef pThis, int unit, double step);

		/// <summary>
		/// Specify the maximum step used in the integration expressed in
		/// one of the:
		/// TIME_UNIT        = 0
		/// LENGTH_UNIT      = 1
		/// CELL_LENGTH_UNIT = 2
		/// Only valid when using adaptive integrators.
		/// </summary>
		// Token: 0x0600DAC1 RID: 56001 RVA: 0x0012F94F File Offset: 0x0012DB4F
		public void SetMaximumIntegrationStep(int unit, double step)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetMaximumIntegrationStep_55(base.GetCppThis(), unit, step);
		}

		// Token: 0x0600DAC2 RID: 56002
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericStreamTracer_SetMaximumIntegrationStep_56(HandleRef pThis, double step);

		/// <summary>
		/// Specify the maximum step used in the integration expressed in
		/// one of the:
		/// TIME_UNIT        = 0
		/// LENGTH_UNIT      = 1
		/// CELL_LENGTH_UNIT = 2
		/// Only valid when using adaptive integrators.
		/// </summary>
		// Token: 0x0600DAC3 RID: 56003 RVA: 0x0012F960 File Offset: 0x0012DB60
		public void SetMaximumIntegrationStep(double step)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetMaximumIntegrationStep_56(base.GetCppThis(), step);
		}

		// Token: 0x0600DAC4 RID: 56004
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericStreamTracer_SetMaximumIntegrationStepUnit_57(HandleRef pThis, int unit);

		/// <summary>
		/// Specify the maximum step used in the integration expressed in
		/// one of the:
		/// TIME_UNIT        = 0
		/// LENGTH_UNIT      = 1
		/// CELL_LENGTH_UNIT = 2
		/// Only valid when using adaptive integrators.
		/// </summary>
		// Token: 0x0600DAC5 RID: 56005 RVA: 0x0012F970 File Offset: 0x0012DB70
		public void SetMaximumIntegrationStepUnit(int unit)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetMaximumIntegrationStepUnit_57(base.GetCppThis(), unit);
		}

		// Token: 0x0600DAC6 RID: 56006
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericStreamTracer_SetMaximumIntegrationStepUnitToCellLengthUnit_58(HandleRef pThis);

		/// <summary>
		/// Specify the maximum step used in the integration expressed in
		/// one of the:
		/// TIME_UNIT        = 0
		/// LENGTH_UNIT      = 1
		/// CELL_LENGTH_UNIT = 2
		/// Only valid when using adaptive integrators.
		/// </summary>
		// Token: 0x0600DAC7 RID: 56007 RVA: 0x0012F980 File Offset: 0x0012DB80
		public void SetMaximumIntegrationStepUnitToCellLengthUnit()
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetMaximumIntegrationStepUnitToCellLengthUnit_58(base.GetCppThis());
		}

		// Token: 0x0600DAC8 RID: 56008
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericStreamTracer_SetMaximumIntegrationStepUnitToLengthUnit_59(HandleRef pThis);

		/// <summary>
		/// Specify the maximum step used in the integration expressed in
		/// one of the:
		/// TIME_UNIT        = 0
		/// LENGTH_UNIT      = 1
		/// CELL_LENGTH_UNIT = 2
		/// Only valid when using adaptive integrators.
		/// </summary>
		// Token: 0x0600DAC9 RID: 56009 RVA: 0x0012F98F File Offset: 0x0012DB8F
		public void SetMaximumIntegrationStepUnitToLengthUnit()
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetMaximumIntegrationStepUnitToLengthUnit_59(base.GetCppThis());
		}

		// Token: 0x0600DACA RID: 56010
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericStreamTracer_SetMaximumIntegrationStepUnitToTimeUnit_60(HandleRef pThis);

		/// <summary>
		/// Specify the maximum step used in the integration expressed in
		/// one of the:
		/// TIME_UNIT        = 0
		/// LENGTH_UNIT      = 1
		/// CELL_LENGTH_UNIT = 2
		/// Only valid when using adaptive integrators.
		/// </summary>
		// Token: 0x0600DACB RID: 56011 RVA: 0x0012F99E File Offset: 0x0012DB9E
		public void SetMaximumIntegrationStepUnitToTimeUnit()
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetMaximumIntegrationStepUnitToTimeUnit_60(base.GetCppThis());
		}

		// Token: 0x0600DACC RID: 56012
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericStreamTracer_SetMaximumNumberOfSteps_61(HandleRef pThis, long _arg);

		/// <summary>
		/// Specify the maximum number of steps used in the integration.
		/// </summary>
		// Token: 0x0600DACD RID: 56013 RVA: 0x0012F9AD File Offset: 0x0012DBAD
		public virtual void SetMaximumNumberOfSteps(long _arg)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetMaximumNumberOfSteps_61(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DACE RID: 56014
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericStreamTracer_SetMaximumPropagation_62(HandleRef pThis, int unit, double max);

		/// <summary>
		/// Specify the maximum length of the streamlines expressed in
		/// one of the:
		/// TIME_UNIT        = 0
		/// LENGTH_UNIT      = 1
		/// CELL_LENGTH_UNIT = 2
		/// </summary>
		// Token: 0x0600DACF RID: 56015 RVA: 0x0012F9BD File Offset: 0x0012DBBD
		public void SetMaximumPropagation(int unit, double max)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetMaximumPropagation_62(base.GetCppThis(), unit, max);
		}

		// Token: 0x0600DAD0 RID: 56016
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericStreamTracer_SetMaximumPropagation_63(HandleRef pThis, double max);

		/// <summary>
		/// Specify the maximum length of the streamlines expressed in
		/// one of the:
		/// TIME_UNIT        = 0
		/// LENGTH_UNIT      = 1
		/// CELL_LENGTH_UNIT = 2
		/// </summary>
		// Token: 0x0600DAD1 RID: 56017 RVA: 0x0012F9CE File Offset: 0x0012DBCE
		public void SetMaximumPropagation(double max)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetMaximumPropagation_63(base.GetCppThis(), max);
		}

		// Token: 0x0600DAD2 RID: 56018
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericStreamTracer_SetMaximumPropagationUnit_64(HandleRef pThis, int unit);

		/// <summary>
		/// Specify the maximum length of the streamlines expressed in
		/// one of the:
		/// TIME_UNIT        = 0
		/// LENGTH_UNIT      = 1
		/// CELL_LENGTH_UNIT = 2
		/// </summary>
		// Token: 0x0600DAD3 RID: 56019 RVA: 0x0012F9DE File Offset: 0x0012DBDE
		public void SetMaximumPropagationUnit(int unit)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetMaximumPropagationUnit_64(base.GetCppThis(), unit);
		}

		// Token: 0x0600DAD4 RID: 56020
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericStreamTracer_SetMaximumPropagationUnitToCellLengthUnit_65(HandleRef pThis);

		/// <summary>
		/// Specify the maximum length of the streamlines expressed in
		/// one of the:
		/// TIME_UNIT        = 0
		/// LENGTH_UNIT      = 1
		/// CELL_LENGTH_UNIT = 2
		/// </summary>
		// Token: 0x0600DAD5 RID: 56021 RVA: 0x0012F9EE File Offset: 0x0012DBEE
		public void SetMaximumPropagationUnitToCellLengthUnit()
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetMaximumPropagationUnitToCellLengthUnit_65(base.GetCppThis());
		}

		// Token: 0x0600DAD6 RID: 56022
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericStreamTracer_SetMaximumPropagationUnitToLengthUnit_66(HandleRef pThis);

		/// <summary>
		/// Specify the maximum length of the streamlines expressed in
		/// one of the:
		/// TIME_UNIT        = 0
		/// LENGTH_UNIT      = 1
		/// CELL_LENGTH_UNIT = 2
		/// </summary>
		// Token: 0x0600DAD7 RID: 56023 RVA: 0x0012F9FD File Offset: 0x0012DBFD
		public void SetMaximumPropagationUnitToLengthUnit()
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetMaximumPropagationUnitToLengthUnit_66(base.GetCppThis());
		}

		// Token: 0x0600DAD8 RID: 56024
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericStreamTracer_SetMaximumPropagationUnitToTimeUnit_67(HandleRef pThis);

		/// <summary>
		/// Specify the maximum length of the streamlines expressed in
		/// one of the:
		/// TIME_UNIT        = 0
		/// LENGTH_UNIT      = 1
		/// CELL_LENGTH_UNIT = 2
		/// </summary>
		// Token: 0x0600DAD9 RID: 56025 RVA: 0x0012FA0C File Offset: 0x0012DC0C
		public void SetMaximumPropagationUnitToTimeUnit()
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetMaximumPropagationUnitToTimeUnit_67(base.GetCppThis());
		}

		// Token: 0x0600DADA RID: 56026
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericStreamTracer_SetMinimumIntegrationStep_68(HandleRef pThis, int unit, double step);

		/// <summary>
		/// Specify the minimum step used in the integration expressed in
		/// one of the:
		/// TIME_UNIT        = 0
		/// LENGTH_UNIT      = 1
		/// CELL_LENGTH_UNIT = 2
		/// Only valid when using adaptive integrators.
		/// </summary>
		// Token: 0x0600DADB RID: 56027 RVA: 0x0012FA1B File Offset: 0x0012DC1B
		public void SetMinimumIntegrationStep(int unit, double step)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetMinimumIntegrationStep_68(base.GetCppThis(), unit, step);
		}

		// Token: 0x0600DADC RID: 56028
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericStreamTracer_SetMinimumIntegrationStep_69(HandleRef pThis, double step);

		/// <summary>
		/// Specify the minimum step used in the integration expressed in
		/// one of the:
		/// TIME_UNIT        = 0
		/// LENGTH_UNIT      = 1
		/// CELL_LENGTH_UNIT = 2
		/// Only valid when using adaptive integrators.
		/// </summary>
		// Token: 0x0600DADD RID: 56029 RVA: 0x0012FA2C File Offset: 0x0012DC2C
		public void SetMinimumIntegrationStep(double step)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetMinimumIntegrationStep_69(base.GetCppThis(), step);
		}

		// Token: 0x0600DADE RID: 56030
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericStreamTracer_SetMinimumIntegrationStepUnit_70(HandleRef pThis, int unit);

		/// <summary>
		/// Specify the minimum step used in the integration expressed in
		/// one of the:
		/// TIME_UNIT        = 0
		/// LENGTH_UNIT      = 1
		/// CELL_LENGTH_UNIT = 2
		/// Only valid when using adaptive integrators.
		/// </summary>
		// Token: 0x0600DADF RID: 56031 RVA: 0x0012FA3C File Offset: 0x0012DC3C
		public void SetMinimumIntegrationStepUnit(int unit)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetMinimumIntegrationStepUnit_70(base.GetCppThis(), unit);
		}

		// Token: 0x0600DAE0 RID: 56032
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericStreamTracer_SetMinimumIntegrationStepUnitToCellLengthUnit_71(HandleRef pThis);

		/// <summary>
		/// Specify the minimum step used in the integration expressed in
		/// one of the:
		/// TIME_UNIT        = 0
		/// LENGTH_UNIT      = 1
		/// CELL_LENGTH_UNIT = 2
		/// Only valid when using adaptive integrators.
		/// </summary>
		// Token: 0x0600DAE1 RID: 56033 RVA: 0x0012FA4C File Offset: 0x0012DC4C
		public void SetMinimumIntegrationStepUnitToCellLengthUnit()
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetMinimumIntegrationStepUnitToCellLengthUnit_71(base.GetCppThis());
		}

		// Token: 0x0600DAE2 RID: 56034
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericStreamTracer_SetMinimumIntegrationStepUnitToLengthUnit_72(HandleRef pThis);

		/// <summary>
		/// Specify the minimum step used in the integration expressed in
		/// one of the:
		/// TIME_UNIT        = 0
		/// LENGTH_UNIT      = 1
		/// CELL_LENGTH_UNIT = 2
		/// Only valid when using adaptive integrators.
		/// </summary>
		// Token: 0x0600DAE3 RID: 56035 RVA: 0x0012FA5B File Offset: 0x0012DC5B
		public void SetMinimumIntegrationStepUnitToLengthUnit()
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetMinimumIntegrationStepUnitToLengthUnit_72(base.GetCppThis());
		}

		// Token: 0x0600DAE4 RID: 56036
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericStreamTracer_SetMinimumIntegrationStepUnitToTimeUnit_73(HandleRef pThis);

		/// <summary>
		/// Specify the minimum step used in the integration expressed in
		/// one of the:
		/// TIME_UNIT        = 0
		/// LENGTH_UNIT      = 1
		/// CELL_LENGTH_UNIT = 2
		/// Only valid when using adaptive integrators.
		/// </summary>
		// Token: 0x0600DAE5 RID: 56037 RVA: 0x0012FA6A File Offset: 0x0012DC6A
		public void SetMinimumIntegrationStepUnitToTimeUnit()
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetMinimumIntegrationStepUnitToTimeUnit_73(base.GetCppThis());
		}

		// Token: 0x0600DAE6 RID: 56038
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericStreamTracer_SetRotationScale_74(HandleRef pThis, double _arg);

		/// <summary>
		/// This can be used to scale the rate with which the streamribbons
		/// twist. The default is 1.
		/// </summary>
		// Token: 0x0600DAE7 RID: 56039 RVA: 0x0012FA79 File Offset: 0x0012DC79
		public virtual void SetRotationScale(double _arg)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetRotationScale_74(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DAE8 RID: 56040
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericStreamTracer_SetSourceConnection_75(HandleRef pThis, HandleRef algOutput);

		/// <summary>
		/// Specify the source object used to generate starting points (seeds).
		/// New style.
		/// </summary>
		// Token: 0x0600DAE9 RID: 56041 RVA: 0x0012FA8C File Offset: 0x0012DC8C
		public void SetSourceConnection(vtkAlgorithmOutput algOutput)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetSourceConnection_75(base.GetCppThis(), (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}

		// Token: 0x0600DAEA RID: 56042
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericStreamTracer_SetSourceData_76(HandleRef pThis, HandleRef source);

		/// <summary>
		/// Specify the source object used to generate starting points.
		/// </summary>
		// Token: 0x0600DAEB RID: 56043 RVA: 0x0012FABC File Offset: 0x0012DCBC
		public void SetSourceData(vtkDataSet source)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetSourceData_76(base.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x0600DAEC RID: 56044
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericStreamTracer_SetStartPosition_77(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Specify the start of the streamline in the global coordinate
		/// system. Search must be performed to find initial cell to start
		/// integration from.
		/// </summary>
		// Token: 0x0600DAED RID: 56045 RVA: 0x0012FAEB File Offset: 0x0012DCEB
		public virtual void SetStartPosition(double _arg1, double _arg2, double _arg3)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetStartPosition_77(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600DAEE RID: 56046
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericStreamTracer_SetStartPosition_78(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify the start of the streamline in the global coordinate
		/// system. Search must be performed to find initial cell to start
		/// integration from.
		/// </summary>
		// Token: 0x0600DAEF RID: 56047 RVA: 0x0012FAFD File Offset: 0x0012DCFD
		public virtual void SetStartPosition(IntPtr _arg)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetStartPosition_78(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DAF0 RID: 56048
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericStreamTracer_SetTerminalSpeed_79(HandleRef pThis, double _arg);

		/// <summary>
		/// If at any point, the speed is below this value, the integration
		/// is terminated.
		/// </summary>
		// Token: 0x0600DAF1 RID: 56049 RVA: 0x0012FB0D File Offset: 0x0012DD0D
		public virtual void SetTerminalSpeed(double _arg)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetTerminalSpeed_79(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FE8 RID: 4072
		public new const string MRFullTypeName = "Kitware.VTK.vtkGenericStreamTracer";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FE9 RID: 4073
		public new static readonly string MRClassNameKey = "class vtkGenericStreamTracer";

		/// <summary>
		/// Simplified API to set an homogeneous unit across Min/Max/Init IntegrationStepUnit
		/// </summary>
		// Token: 0x020004A1 RID: 1185
		public enum BACKWARD_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000FEB RID: 4075
			BACKWARD = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000FEC RID: 4076
			BOTH,
			/// <summary>enum member</summary>
			// Token: 0x04000FED RID: 4077
			FORWARD = 0
		}

		/// <summary>
		/// Specify the source object used to generate starting points (seeds).
		/// New style.
		/// </summary>
		// Token: 0x020004A2 RID: 1186
		public enum ReasonForTermination
		{
			/// <summary>enum member</summary>
			// Token: 0x04000FEF RID: 4079
			NOT_INITIALIZED = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000FF0 RID: 4080
			OUT_OF_DOMAIN = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000FF1 RID: 4081
			OUT_OF_STEPS = 5,
			/// <summary>enum member</summary>
			// Token: 0x04000FF2 RID: 4082
			OUT_OF_TIME = 4,
			/// <summary>enum member</summary>
			// Token: 0x04000FF3 RID: 4083
			STAGNATION = 6,
			/// <summary>enum member</summary>
			// Token: 0x04000FF4 RID: 4084
			UNEXPECTED_VALUE = 3
		}

		/// <summary>
		/// Specify the source object used to generate starting points (seeds).
		/// New style.
		/// </summary>
		// Token: 0x020004A3 RID: 1187
		public enum Solvers
		{
			/// <summary>enum member</summary>
			// Token: 0x04000FF6 RID: 4086
			NONE = 3,
			/// <summary>enum member</summary>
			// Token: 0x04000FF7 RID: 4087
			RUNGE_KUTTA2 = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000FF8 RID: 4088
			RUNGE_KUTTA4,
			/// <summary>enum member</summary>
			// Token: 0x04000FF9 RID: 4089
			RUNGE_KUTTA45,
			/// <summary>enum member</summary>
			// Token: 0x04000FFA RID: 4090
			UNKNOWN = 4
		}

		/// <summary>
		/// Specify the source object used to generate starting points (seeds).
		/// New style.
		/// </summary>
		// Token: 0x020004A4 RID: 1188
		public enum Units
		{
			/// <summary>enum member</summary>
			// Token: 0x04000FFC RID: 4092
			CELL_LENGTH_UNIT = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000FFD RID: 4093
			LENGTH_UNIT = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000FFE RID: 4094
			TIME_UNIT = 0
		}
	}
}
