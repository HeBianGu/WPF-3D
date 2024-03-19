using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLagrangianParticleTracker
	/// </summary>
	/// <remarks>
	///    Filter to inject and track particles in a flow
	///
	///
	///
	/// Introduce LagrangianParticleTracker
	///
	/// This is a very flexible and adaptive filter to inject and track particles in a
	/// flow. It takes three inputs :
	/// * port 0 : Flow Input, a volumic dataset containing data to integrate with,
	///     any kind of data object, support distributed input.
	/// * port 1 : Seed (source) Input, a dataset containing point to generate particles
	///     with, any kind of data object, support distributed input. Only first leaf
	///     of composite dataset is used.
	/// * port 2 : Optional Surface Input, containing dataset to interact with, any
	///     kind of data object, support distributed input.
	///
	/// It has two outputs :
	/// * port 0 : ParticlePaths : a multipiece of polyData (one per thread) of polyLines showing the
	/// paths of particles in the flow
	/// * port 1 : ParticleInteractions : empty if no surface input, contains a
	///     a multiblock with as many children as the number of threads, each children containing a
	/// multiblock with the same structure as the surfaces. The leafs of these structures contain a
	/// polydata of vertices corresponding to the interactions. with the same composite layout of surface
	/// input if any, showing all interactions between particles and the surface input.
	///
	/// It has a parallel implementation which streams particle between domains.
	///
	/// The most important parameters of this filter is it's integrationModel.
	/// Only one integration model implementation exist currently in ParaView
	/// ,vtkLagrangianMatidaIntegrationModel but the design enables plugin developers
	/// to expand this tracker by creating new models.
	/// A model can define  :
	/// * The number of integration variable and new user defined integration variable
	/// * the way the particle are integrated
	/// * the way particles intersect and interact with the surface
	/// * the way freeFlight termination is handled
	/// * PreProcess and PostProcess methods
	/// * Manual Integration, Manual partichle shifting
	/// see vtkLagrangianBasicIntegrationModel and vtkLagrangianMatidaIntegrationModel
	/// for more information
	///
	/// It also let the user choose the Locator to use when integrating in the flow,
	/// as well as the Integrator to use. Integration steps are also highly configurable,
	/// step, step min and step max are passed down to the integrator (hence min and max
	/// does not matter with a non adaptive integrator like RK4/5)
	///
	///  An IntegrationModel is a very specific vtkFunctionSet with a lot of features
	/// allowing inherited classes
	/// to concentrate on the mathematical part of the code.
	///  a Particle is basically a class wrapper around three table containing variables
	/// about the particle at previous, current and next position.
	///  The particle is passed to the integrator, which use the integration model to
	/// integrate the particle in the flow.
	///
	/// It has other features also, including :
	///  * Adaptative Step Reintegration, to retry the step with different time step
	///      when the next position is too far
	///  * Different kind of cell length computation, including a divergence theorem
	///      based computation
	///  * Optional lines rendering controlled by a threshold
	///  * Ghost cell support
	///  * Non planar quad interaction support
	///  * Built-in support for surface interaction including, terminate, bounce,
	///      break-up and pass-through surface
	/// The serial and parallel filters are fully tested.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkLagrangianMatidaIntegrationModel vtkLagrangianParticle
	/// vtkLagrangianBasicIntegrationModel
	/// </seealso>
	// Token: 0x020004B2 RID: 1202
	public class vtkLagrangianParticleTracker : vtkDataObjectAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600DCB1 RID: 56497 RVA: 0x0013248D File Offset: 0x0013068D
		static vtkLagrangianParticleTracker()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLagrangianParticleTracker.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLagrangianParticleTracker"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600DCB2 RID: 56498 RVA: 0x001324B5 File Offset: 0x001306B5
		public vtkLagrangianParticleTracker(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600DCB3 RID: 56499
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangianParticleTracker_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DCB4 RID: 56500 RVA: 0x001324C4 File Offset: 0x001306C4
		public new static vtkLagrangianParticleTracker New()
		{
			vtkLagrangianParticleTracker result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangianParticleTracker.vtkLagrangianParticleTracker_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLagrangianParticleTracker)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DCB5 RID: 56501 RVA: 0x00132518 File Offset: 0x00130718
		public vtkLagrangianParticleTracker() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLagrangianParticleTracker.vtkLagrangianParticleTracker_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600DCB6 RID: 56502 RVA: 0x0013255C File Offset: 0x0013075C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600DCB7 RID: 56503
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangianParticleTracker_AdaptiveStepReintegrationOff_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the Adaptive Step Reintegration feature.
		/// it checks the step size after the integration
		/// and if it is too big will retry with a smaller step
		/// Default is false.
		/// </summary>
		// Token: 0x0600DCB8 RID: 56504 RVA: 0x00132567 File Offset: 0x00130767
		public virtual void AdaptiveStepReintegrationOff()
		{
			vtkLagrangianParticleTracker.vtkLagrangianParticleTracker_AdaptiveStepReintegrationOff_01(base.GetCppThis());
		}

		// Token: 0x0600DCB9 RID: 56505
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangianParticleTracker_AdaptiveStepReintegrationOn_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the Adaptive Step Reintegration feature.
		/// it checks the step size after the integration
		/// and if it is too big will retry with a smaller step
		/// Default is false.
		/// </summary>
		// Token: 0x0600DCBA RID: 56506 RVA: 0x00132576 File Offset: 0x00130776
		public virtual void AdaptiveStepReintegrationOn()
		{
			vtkLagrangianParticleTracker.vtkLagrangianParticleTracker_AdaptiveStepReintegrationOn_02(base.GetCppThis());
		}

		// Token: 0x0600DCBB RID: 56507
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLagrangianParticleTracker_FillInputPortInformation_03(HandleRef pThis, int port, HandleRef info);

		/// <summary>
		/// Declare input port type
		/// </summary>
		// Token: 0x0600DCBC RID: 56508 RVA: 0x00132588 File Offset: 0x00130788
		public virtual int FillInputPortInformation(int port, vtkInformation info)
		{
			return vtkLagrangianParticleTracker.vtkLagrangianParticleTracker_FillInputPortInformation_03(base.GetCppThis(), port, (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x0600DCBD RID: 56509
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLagrangianParticleTracker_FillOutputPortInformation_04(HandleRef pThis, int port, HandleRef info);

		/// <summary>
		/// Declare output port type
		/// </summary>
		// Token: 0x0600DCBE RID: 56510 RVA: 0x001325C0 File Offset: 0x001307C0
		public virtual int FillOutputPortInformation(int port, vtkInformation info)
		{
			return vtkLagrangianParticleTracker.vtkLagrangianParticleTracker_FillOutputPortInformation_04(base.GetCppThis(), port, (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x0600DCBF RID: 56511
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangianParticleTracker_GenerateParticlePathsOutputOff_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the generation of the particle path output,
		/// Default is true.
		/// </summary>
		// Token: 0x0600DCC0 RID: 56512 RVA: 0x001325F5 File Offset: 0x001307F5
		public virtual void GenerateParticlePathsOutputOff()
		{
			vtkLagrangianParticleTracker.vtkLagrangianParticleTracker_GenerateParticlePathsOutputOff_05(base.GetCppThis());
		}

		// Token: 0x0600DCC1 RID: 56513
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangianParticleTracker_GenerateParticlePathsOutputOn_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the generation of the particle path output,
		/// Default is true.
		/// </summary>
		// Token: 0x0600DCC2 RID: 56514 RVA: 0x00132604 File Offset: 0x00130804
		public virtual void GenerateParticlePathsOutputOn()
		{
			vtkLagrangianParticleTracker.vtkLagrangianParticleTracker_GenerateParticlePathsOutputOn_06(base.GetCppThis());
		}

		// Token: 0x0600DCC3 RID: 56515
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkLagrangianParticleTracker_GetAdaptiveStepReintegration_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the Adaptive Step Reintegration feature.
		/// it checks the step size after the integration
		/// and if it is too big will retry with a smaller step
		/// Default is false.
		/// </summary>
		// Token: 0x0600DCC4 RID: 56516 RVA: 0x00132614 File Offset: 0x00130814
		public virtual bool GetAdaptiveStepReintegration()
		{
			return vtkLagrangianParticleTracker.vtkLagrangianParticleTracker_GetAdaptiveStepReintegration_07(base.GetCppThis()) != 0;
		}

		// Token: 0x0600DCC5 RID: 56517
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLagrangianParticleTracker_GetCellLengthComputationMode_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the cell length computation mode.
		/// Available modes are :
		/// - STEP_CUR_CELL_LENGTH :
		/// Compute cell length using getLength method
		/// on the current cell the particle is in
		/// - STEP_CUR_CELL_VEL_DIR :
		/// Compute cell length using the particle velocity
		/// and the edges of the last cell the particle was in.
		/// - STEP_CUR_CELL_DIV_THEO :
		/// Compute cell length using the particle velocity
		/// and the divergence theorem.
		/// </summary>
		// Token: 0x0600DCC6 RID: 56518 RVA: 0x0013263C File Offset: 0x0013083C
		public virtual int GetCellLengthComputationMode()
		{
			return vtkLagrangianParticleTracker.vtkLagrangianParticleTracker_GetCellLengthComputationMode_08(base.GetCppThis());
		}

		// Token: 0x0600DCC7 RID: 56519
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkLagrangianParticleTracker_GetGenerateParticlePathsOutput_09(HandleRef pThis);

		/// <summary>
		/// Set/Get the generation of the particle path output,
		/// Default is true.
		/// </summary>
		// Token: 0x0600DCC8 RID: 56520 RVA: 0x0013265C File Offset: 0x0013085C
		public virtual bool GetGenerateParticlePathsOutput()
		{
			return vtkLagrangianParticleTracker.vtkLagrangianParticleTracker_GetGenerateParticlePathsOutput_09(base.GetCppThis()) != 0;
		}

		// Token: 0x0600DCC9 RID: 56521
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkLagrangianParticleTracker_GetGeneratePolyVertexInteractionOutput_10(HandleRef pThis);

		/// <summary>
		/// Set/Get whether or not to use PolyVertex cell type
		/// for the interaction output
		/// Default is false
		/// </summary>
		// Token: 0x0600DCCA RID: 56522 RVA: 0x00132684 File Offset: 0x00130884
		public virtual bool GetGeneratePolyVertexInteractionOutput()
		{
			return vtkLagrangianParticleTracker.vtkLagrangianParticleTracker_GetGeneratePolyVertexInteractionOutput_10(base.GetCppThis()) != 0;
		}

		// Token: 0x0600DCCB RID: 56523
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangianParticleTracker_GetIntegrationModel_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the integration model.
		/// Default is vtkLagrangianMatidaIntegrationModel
		/// </summary>
		// Token: 0x0600DCCC RID: 56524 RVA: 0x001326AC File Offset: 0x001308AC
		public vtkLagrangianBasicIntegrationModel GetIntegrationModel()
		{
			vtkLagrangianBasicIntegrationModel vtkLagrangianBasicIntegrationModel = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangianParticleTracker.vtkLagrangianParticleTracker_GetIntegrationModel_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLagrangianBasicIntegrationModel = (vtkLagrangianBasicIntegrationModel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLagrangianBasicIntegrationModel.Register(null);
				}
			}
			return vtkLagrangianBasicIntegrationModel;
		}

		// Token: 0x0600DCCD RID: 56525
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangianParticleTracker_GetIntegrator_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the integrator.
		/// Default is vtkRungeKutta2
		/// </summary>
		// Token: 0x0600DCCE RID: 56526 RVA: 0x0013271C File Offset: 0x0013091C
		public vtkInitialValueProblemSolver GetIntegrator()
		{
			vtkInitialValueProblemSolver vtkInitialValueProblemSolver = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangianParticleTracker.vtkLagrangianParticleTracker_GetIntegrator_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600DCCF RID: 56527
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkLagrangianParticleTracker_GetMTime_13(HandleRef pThis);

		/// <summary>
		/// Get the tracker modified time taking into account the integration model
		/// and the integrator.
		/// </summary>
		// Token: 0x0600DCD0 RID: 56528 RVA: 0x0013278C File Offset: 0x0013098C
		public override ulong GetMTime()
		{
			return vtkLagrangianParticleTracker.vtkLagrangianParticleTracker_GetMTime_13(base.GetCppThis());
		}

		// Token: 0x0600DCD1 RID: 56529
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLagrangianParticleTracker_GetMaximumIntegrationTime_14(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum integration time. A negative value means no limit.
		/// Default is -1.
		/// </summary>
		// Token: 0x0600DCD2 RID: 56530 RVA: 0x001327AC File Offset: 0x001309AC
		public virtual double GetMaximumIntegrationTime()
		{
			return vtkLagrangianParticleTracker.vtkLagrangianParticleTracker_GetMaximumIntegrationTime_14(base.GetCppThis());
		}

		// Token: 0x0600DCD3 RID: 56531
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLagrangianParticleTracker_GetMaximumNumberOfSteps_15(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum number of steps. -1 means no limit. Default is 100.
		/// </summary>
		// Token: 0x0600DCD4 RID: 56532 RVA: 0x001327CC File Offset: 0x001309CC
		public virtual int GetMaximumNumberOfSteps()
		{
			return vtkLagrangianParticleTracker.vtkLagrangianParticleTracker_GetMaximumNumberOfSteps_15(base.GetCppThis());
		}

		// Token: 0x0600DCD5 RID: 56533
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLagrangianParticleTracker_GetNewParticleId_16(HandleRef pThis);

		/// <summary>
		/// Get an unique id for a particle
		/// This method is thread safe
		/// </summary>
		// Token: 0x0600DCD6 RID: 56534 RVA: 0x001327EC File Offset: 0x001309EC
		public virtual long GetNewParticleId()
		{
			return vtkLagrangianParticleTracker.vtkLagrangianParticleTracker_GetNewParticleId_16(base.GetCppThis());
		}

		// Token: 0x0600DCD7 RID: 56535
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLagrangianParticleTracker_GetNumberOfGenerationsFromBase_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DCD8 RID: 56536 RVA: 0x0013280C File Offset: 0x00130A0C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLagrangianParticleTracker.vtkLagrangianParticleTracker_GetNumberOfGenerationsFromBase_17(base.GetCppThis(), type);
		}

		// Token: 0x0600DCD9 RID: 56537
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLagrangianParticleTracker_GetNumberOfGenerationsFromBaseType_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DCDA RID: 56538 RVA: 0x0013282C File Offset: 0x00130A2C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLagrangianParticleTracker.vtkLagrangianParticleTracker_GetNumberOfGenerationsFromBaseType_18(type);
		}

		// Token: 0x0600DCDB RID: 56539
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangianParticleTracker_GetSource_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the source object used to generate particle initial position (seeds).
		/// Note that this method does not connect the pipeline. The algorithm will
		/// work on the input data as it is without updating the producer of the data.
		/// See SetSourceConnection for connecting the pipeline.
		/// </summary>
		// Token: 0x0600DCDC RID: 56540 RVA: 0x00132848 File Offset: 0x00130A48
		public vtkDataObject GetSource()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangianParticleTracker.vtkLagrangianParticleTracker_GetSource_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		// Token: 0x0600DCDD RID: 56541
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLagrangianParticleTracker_GetStepFactor_20(HandleRef pThis);

		/// <summary>
		/// Set/Get the integration step factor. Default is 1.0.
		/// </summary>
		// Token: 0x0600DCDE RID: 56542 RVA: 0x001328B8 File Offset: 0x00130AB8
		public virtual double GetStepFactor()
		{
			return vtkLagrangianParticleTracker.vtkLagrangianParticleTracker_GetStepFactor_20(base.GetCppThis());
		}

		// Token: 0x0600DCDF RID: 56543
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLagrangianParticleTracker_GetStepFactorMax_21(HandleRef pThis);

		/// <summary>
		/// Set/Get the integration step factor max. Default is 1.5.
		/// </summary>
		// Token: 0x0600DCE0 RID: 56544 RVA: 0x001328D8 File Offset: 0x00130AD8
		public virtual double GetStepFactorMax()
		{
			return vtkLagrangianParticleTracker.vtkLagrangianParticleTracker_GetStepFactorMax_21(base.GetCppThis());
		}

		// Token: 0x0600DCE1 RID: 56545
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLagrangianParticleTracker_GetStepFactorMin_22(HandleRef pThis);

		/// <summary>
		/// Set/Get the integration step factor min. Default is 0.5.
		/// </summary>
		// Token: 0x0600DCE2 RID: 56546 RVA: 0x001328F8 File Offset: 0x00130AF8
		public virtual double GetStepFactorMin()
		{
			return vtkLagrangianParticleTracker.vtkLagrangianParticleTracker_GetStepFactorMin_22(base.GetCppThis());
		}

		// Token: 0x0600DCE3 RID: 56547
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangianParticleTracker_GetSurface_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the source object used to compute surface interaction with
		/// Note that this method does not connect the pipeline. The algorithm will
		/// work on the input data as it is without updating the producer of the data.
		/// See SetSurfaceConnection for connecting the pipeline.
		/// </summary>
		// Token: 0x0600DCE4 RID: 56548 RVA: 0x00132918 File Offset: 0x00130B18
		public vtkDataObject GetSurface()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangianParticleTracker.vtkLagrangianParticleTracker_GetSurface_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		// Token: 0x0600DCE5 RID: 56549
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLagrangianParticleTracker_IsA_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DCE6 RID: 56550 RVA: 0x00132988 File Offset: 0x00130B88
		public override int IsA(string type)
		{
			return vtkLagrangianParticleTracker.vtkLagrangianParticleTracker_IsA_24(base.GetCppThis(), type);
		}

		// Token: 0x0600DCE7 RID: 56551
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLagrangianParticleTracker_IsTypeOf_25([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DCE8 RID: 56552 RVA: 0x001329A8 File Offset: 0x00130BA8
		public new static int IsTypeOf(string type)
		{
			return vtkLagrangianParticleTracker.vtkLagrangianParticleTracker_IsTypeOf_25(type);
		}

		// Token: 0x0600DCE9 RID: 56553
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangianParticleTracker_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DCEA RID: 56554 RVA: 0x001329C4 File Offset: 0x00130BC4
		public new vtkLagrangianParticleTracker NewInstance()
		{
			vtkLagrangianParticleTracker result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangianParticleTracker.vtkLagrangianParticleTracker_NewInstance_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLagrangianParticleTracker)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600DCEB RID: 56555
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangianParticleTracker_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DCEC RID: 56556 RVA: 0x00132A20 File Offset: 0x00130C20
		public new static vtkLagrangianParticleTracker SafeDownCast(vtkObjectBase o)
		{
			vtkLagrangianParticleTracker vtkLagrangianParticleTracker = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangianParticleTracker.vtkLagrangianParticleTracker_SafeDownCast_28((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLagrangianParticleTracker = (vtkLagrangianParticleTracker)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLagrangianParticleTracker.Register(null);
				}
			}
			return vtkLagrangianParticleTracker;
		}

		// Token: 0x0600DCED RID: 56557
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangianParticleTracker_SetAdaptiveStepReintegration_29(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get the Adaptive Step Reintegration feature.
		/// it checks the step size after the integration
		/// and if it is too big will retry with a smaller step
		/// Default is false.
		/// </summary>
		// Token: 0x0600DCEE RID: 56558 RVA: 0x00132A9F File Offset: 0x00130C9F
		public virtual void SetAdaptiveStepReintegration(bool _arg)
		{
			vtkLagrangianParticleTracker.vtkLagrangianParticleTracker_SetAdaptiveStepReintegration_29(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600DCEF RID: 56559
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangianParticleTracker_SetCellLengthComputationMode_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the cell length computation mode.
		/// Available modes are :
		/// - STEP_CUR_CELL_LENGTH :
		/// Compute cell length using getLength method
		/// on the current cell the particle is in
		/// - STEP_CUR_CELL_VEL_DIR :
		/// Compute cell length using the particle velocity
		/// and the edges of the last cell the particle was in.
		/// - STEP_CUR_CELL_DIV_THEO :
		/// Compute cell length using the particle velocity
		/// and the divergence theorem.
		/// </summary>
		// Token: 0x0600DCF0 RID: 56560 RVA: 0x00132AB7 File Offset: 0x00130CB7
		public virtual void SetCellLengthComputationMode(int _arg)
		{
			vtkLagrangianParticleTracker.vtkLagrangianParticleTracker_SetCellLengthComputationMode_30(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DCF1 RID: 56561
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangianParticleTracker_SetGenerateParticlePathsOutput_31(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get the generation of the particle path output,
		/// Default is true.
		/// </summary>
		// Token: 0x0600DCF2 RID: 56562 RVA: 0x00132AC7 File Offset: 0x00130CC7
		public virtual void SetGenerateParticlePathsOutput(bool _arg)
		{
			vtkLagrangianParticleTracker.vtkLagrangianParticleTracker_SetGenerateParticlePathsOutput_31(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600DCF3 RID: 56563
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangianParticleTracker_SetGeneratePolyVertexInteractionOutput_32(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get whether or not to use PolyVertex cell type
		/// for the interaction output
		/// Default is false
		/// </summary>
		// Token: 0x0600DCF4 RID: 56564 RVA: 0x00132ADF File Offset: 0x00130CDF
		public virtual void SetGeneratePolyVertexInteractionOutput(bool _arg)
		{
			vtkLagrangianParticleTracker.vtkLagrangianParticleTracker_SetGeneratePolyVertexInteractionOutput_32(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600DCF5 RID: 56565
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangianParticleTracker_SetIntegrationModel_33(HandleRef pThis, HandleRef integrationModel);

		/// <summary>
		/// Set/Get the integration model.
		/// Default is vtkLagrangianMatidaIntegrationModel
		/// </summary>
		// Token: 0x0600DCF6 RID: 56566 RVA: 0x00132AF8 File Offset: 0x00130CF8
		public void SetIntegrationModel(vtkLagrangianBasicIntegrationModel integrationModel)
		{
			vtkLagrangianParticleTracker.vtkLagrangianParticleTracker_SetIntegrationModel_33(base.GetCppThis(), (integrationModel == null) ? default(HandleRef) : integrationModel.GetCppThis());
		}

		// Token: 0x0600DCF7 RID: 56567
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangianParticleTracker_SetIntegrator_34(HandleRef pThis, HandleRef integrator);

		/// <summary>
		/// Set/Get the integrator.
		/// Default is vtkRungeKutta2
		/// </summary>
		// Token: 0x0600DCF8 RID: 56568 RVA: 0x00132B28 File Offset: 0x00130D28
		public void SetIntegrator(vtkInitialValueProblemSolver integrator)
		{
			vtkLagrangianParticleTracker.vtkLagrangianParticleTracker_SetIntegrator_34(base.GetCppThis(), (integrator == null) ? default(HandleRef) : integrator.GetCppThis());
		}

		// Token: 0x0600DCF9 RID: 56569
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangianParticleTracker_SetMaximumIntegrationTime_35(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the maximum integration time. A negative value means no limit.
		/// Default is -1.
		/// </summary>
		// Token: 0x0600DCFA RID: 56570 RVA: 0x00132B57 File Offset: 0x00130D57
		public virtual void SetMaximumIntegrationTime(double _arg)
		{
			vtkLagrangianParticleTracker.vtkLagrangianParticleTracker_SetMaximumIntegrationTime_35(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DCFB RID: 56571
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangianParticleTracker_SetMaximumNumberOfSteps_36(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the maximum number of steps. -1 means no limit. Default is 100.
		/// </summary>
		// Token: 0x0600DCFC RID: 56572 RVA: 0x00132B67 File Offset: 0x00130D67
		public virtual void SetMaximumNumberOfSteps(int _arg)
		{
			vtkLagrangianParticleTracker.vtkLagrangianParticleTracker_SetMaximumNumberOfSteps_36(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DCFD RID: 56573
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangianParticleTracker_SetSourceConnection_37(HandleRef pThis, HandleRef algOutput);

		/// <summary>
		/// Specify the source object used to generate particle initial position (seeds).
		/// </summary>
		// Token: 0x0600DCFE RID: 56574 RVA: 0x00132B78 File Offset: 0x00130D78
		public void SetSourceConnection(vtkAlgorithmOutput algOutput)
		{
			vtkLagrangianParticleTracker.vtkLagrangianParticleTracker_SetSourceConnection_37(base.GetCppThis(), (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}

		// Token: 0x0600DCFF RID: 56575
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangianParticleTracker_SetSourceData_38(HandleRef pThis, HandleRef source);

		/// <summary>
		/// Specify the source object used to generate particle initial position (seeds).
		/// Note that this method does not connect the pipeline. The algorithm will
		/// work on the input data as it is without updating the producer of the data.
		/// See SetSourceConnection for connecting the pipeline.
		/// </summary>
		// Token: 0x0600DD00 RID: 56576 RVA: 0x00132BA8 File Offset: 0x00130DA8
		public void SetSourceData(vtkDataObject source)
		{
			vtkLagrangianParticleTracker.vtkLagrangianParticleTracker_SetSourceData_38(base.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x0600DD01 RID: 56577
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangianParticleTracker_SetStepFactor_39(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the integration step factor. Default is 1.0.
		/// </summary>
		// Token: 0x0600DD02 RID: 56578 RVA: 0x00132BD7 File Offset: 0x00130DD7
		public virtual void SetStepFactor(double _arg)
		{
			vtkLagrangianParticleTracker.vtkLagrangianParticleTracker_SetStepFactor_39(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DD03 RID: 56579
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangianParticleTracker_SetStepFactorMax_40(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the integration step factor max. Default is 1.5.
		/// </summary>
		// Token: 0x0600DD04 RID: 56580 RVA: 0x00132BE7 File Offset: 0x00130DE7
		public virtual void SetStepFactorMax(double _arg)
		{
			vtkLagrangianParticleTracker.vtkLagrangianParticleTracker_SetStepFactorMax_40(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DD05 RID: 56581
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangianParticleTracker_SetStepFactorMin_41(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the integration step factor min. Default is 0.5.
		/// </summary>
		// Token: 0x0600DD06 RID: 56582 RVA: 0x00132BF7 File Offset: 0x00130DF7
		public virtual void SetStepFactorMin(double _arg)
		{
			vtkLagrangianParticleTracker.vtkLagrangianParticleTracker_SetStepFactorMin_41(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DD07 RID: 56583
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangianParticleTracker_SetSurfaceConnection_42(HandleRef pThis, HandleRef algOutput);

		/// <summary>
		/// Specify the object used to compute surface interaction with.
		/// </summary>
		// Token: 0x0600DD08 RID: 56584 RVA: 0x00132C08 File Offset: 0x00130E08
		public void SetSurfaceConnection(vtkAlgorithmOutput algOutput)
		{
			vtkLagrangianParticleTracker.vtkLagrangianParticleTracker_SetSurfaceConnection_42(base.GetCppThis(), (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}

		// Token: 0x0600DD09 RID: 56585
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangianParticleTracker_SetSurfaceData_43(HandleRef pThis, HandleRef source);

		/// <summary>
		/// Specify the source object used to compute surface interaction with
		/// Note that this method does not connect the pipeline. The algorithm will
		/// work on the input data as it is without updating the producer of the data.
		/// See SetSurfaceConnection for connecting the pipeline.
		/// </summary>
		// Token: 0x0600DD0A RID: 56586 RVA: 0x00132C38 File Offset: 0x00130E38
		public void SetSurfaceData(vtkDataObject source)
		{
			vtkLagrangianParticleTracker.vtkLagrangianParticleTracker_SetSurfaceData_43(base.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001021 RID: 4129
		public new const string MRFullTypeName = "Kitware.VTK.vtkLagrangianParticleTracker";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001022 RID: 4130
		public new static readonly string MRClassNameKey = "class vtkLagrangianParticleTracker";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x020004B3 RID: 1203
		public enum CellLengthComputation
		{
			/// <summary>enum member</summary>
			// Token: 0x04001024 RID: 4132
			STEP_CUR_CELL_DIV_THEO = 5,
			/// <summary>enum member</summary>
			// Token: 0x04001025 RID: 4133
			STEP_CUR_CELL_LENGTH = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001026 RID: 4134
			STEP_CUR_CELL_VEL_DIR = 3
		}
	}
}
