using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkParticleTracerBase
	/// </summary>
	/// <remarks>
	///    A particle tracer for vector fields
	///
	/// vtkParticleTracerBase is the base class for filters that advect particles
	/// in a vector field. Note that the input vtkPointData structure must
	/// be identical on all datasets.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRibbonFilter vtkRuledSurfaceFilter vtkInitialValueProblemSolver
	/// vtkRungeKutta2 vtkRungeKutta4 vtkRungeKutta45 vtkStreamTracer
	/// </seealso>
	// Token: 0x020004B8 RID: 1208
	public abstract class vtkParticleTracerBase : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600DDD8 RID: 56792 RVA: 0x00134087 File Offset: 0x00132287
		static vtkParticleTracerBase()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParticleTracerBase.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParticleTracerBase"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600DDD9 RID: 56793 RVA: 0x001340AF File Offset: 0x001322AF
		public vtkParticleTracerBase(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600DDDA RID: 56794 RVA: 0x001340BD File Offset: 0x001322BD
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600DDDB RID: 56795
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParticleTracerBase_AddSourceConnection_01(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Provide support for multiple seed sources
		/// </summary>
		// Token: 0x0600DDDC RID: 56796 RVA: 0x001340C8 File Offset: 0x001322C8
		public void AddSourceConnection(vtkAlgorithmOutput input)
		{
			vtkParticleTracerBase.vtkParticleTracerBase_AddSourceConnection_01(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x0600DDDD RID: 56797
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParticleTracerBase_DisableResetCacheOff_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag to disable cache
		/// This is off by default and turned on in special circumstances
		/// such as in a coprocessing workflow
		/// </summary>
		// Token: 0x0600DDDE RID: 56798 RVA: 0x001340F7 File Offset: 0x001322F7
		public virtual void DisableResetCacheOff()
		{
			vtkParticleTracerBase.vtkParticleTracerBase_DisableResetCacheOff_02(base.GetCppThis());
		}

		// Token: 0x0600DDDF RID: 56799
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParticleTracerBase_DisableResetCacheOn_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag to disable cache
		/// This is off by default and turned on in special circumstances
		/// such as in a coprocessing workflow
		/// </summary>
		// Token: 0x0600DDE0 RID: 56800 RVA: 0x00134106 File Offset: 0x00132306
		public virtual void DisableResetCacheOn()
		{
			vtkParticleTracerBase.vtkParticleTracerBase_DisableResetCacheOn_03(base.GetCppThis());
		}

		// Token: 0x0600DDE1 RID: 56801
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParticleTracerBase_EnableParticleWritingOff_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the filename to be used with the particle writer when
		/// dumping particles to disk
		/// </summary>
		// Token: 0x0600DDE2 RID: 56802 RVA: 0x00134115 File Offset: 0x00132315
		public virtual void EnableParticleWritingOff()
		{
			vtkParticleTracerBase.vtkParticleTracerBase_EnableParticleWritingOff_04(base.GetCppThis());
		}

		// Token: 0x0600DDE3 RID: 56803
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParticleTracerBase_EnableParticleWritingOn_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the filename to be used with the particle writer when
		/// dumping particles to disk
		/// </summary>
		// Token: 0x0600DDE4 RID: 56804 RVA: 0x00134124 File Offset: 0x00132324
		public virtual void EnableParticleWritingOn()
		{
			vtkParticleTracerBase.vtkParticleTracerBase_EnableParticleWritingOn_05(base.GetCppThis());
		}

		// Token: 0x0600DDE5 RID: 56805
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParticleTracerBase_ForceSerialExecutionOff_06(HandleRef pThis);

		/// <summary>
		/// Force the filter to run particle tracer in serial. This affects
		/// the filter only if more than 100 particles is to be generated.
		/// </summary>
		// Token: 0x0600DDE6 RID: 56806 RVA: 0x00134133 File Offset: 0x00132333
		public virtual void ForceSerialExecutionOff()
		{
			vtkParticleTracerBase.vtkParticleTracerBase_ForceSerialExecutionOff_06(base.GetCppThis());
		}

		// Token: 0x0600DDE7 RID: 56807
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParticleTracerBase_ForceSerialExecutionOn_07(HandleRef pThis);

		/// <summary>
		/// Force the filter to run particle tracer in serial. This affects
		/// the filter only if more than 100 particles is to be generated.
		/// </summary>
		// Token: 0x0600DDE8 RID: 56808 RVA: 0x00134142 File Offset: 0x00132342
		public virtual void ForceSerialExecutionOn()
		{
			vtkParticleTracerBase.vtkParticleTracerBase_ForceSerialExecutionOn_07(base.GetCppThis());
		}

		// Token: 0x0600DDE9 RID: 56809
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkParticleTracerBase_GetComputeVorticity_08(HandleRef pThis);

		/// <summary>
		/// Turn on/off vorticity computation at streamline points
		/// (necessary for generating proper stream-ribbons using the
		/// vtkRibbonFilter.
		/// </summary>
		// Token: 0x0600DDEA RID: 56810 RVA: 0x00134154 File Offset: 0x00132354
		public virtual bool GetComputeVorticity()
		{
			return vtkParticleTracerBase.vtkParticleTracerBase_GetComputeVorticity_08(base.GetCppThis()) != 0;
		}

		// Token: 0x0600DDEB RID: 56811
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParticleTracerBase_GetDisableResetCache_09(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag to disable cache
		/// This is off by default and turned on in special circumstances
		/// such as in a coprocessing workflow
		/// </summary>
		// Token: 0x0600DDEC RID: 56812 RVA: 0x0013417C File Offset: 0x0013237C
		public virtual int GetDisableResetCache()
		{
			return vtkParticleTracerBase.vtkParticleTracerBase_GetDisableResetCache_09(base.GetCppThis());
		}

		// Token: 0x0600DDED RID: 56813
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParticleTracerBase_GetEnableParticleWriting_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the filename to be used with the particle writer when
		/// dumping particles to disk
		/// </summary>
		// Token: 0x0600DDEE RID: 56814 RVA: 0x0013419C File Offset: 0x0013239C
		public virtual int GetEnableParticleWriting()
		{
			return vtkParticleTracerBase.vtkParticleTracerBase_GetEnableParticleWriting_10(base.GetCppThis());
		}

		// Token: 0x0600DDEF RID: 56815
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParticleTracerBase_GetForceReinjectionEveryNSteps_11(HandleRef pThis);

		/// <summary>
		/// When animating particles, it is nice to inject new ones every Nth step
		/// to produce a continuous flow. Setting ForceReinjectionEveryNSteps to a
		/// non zero value will cause the particle source to reinject particles
		/// every Nth step even if it is otherwise unchanged.
		/// Note that if the particle source is also animated, this flag will be
		/// redundant as the particles will be reinjected whenever the source changes
		/// anyway
		/// </summary>
		// Token: 0x0600DDF0 RID: 56816 RVA: 0x001341BC File Offset: 0x001323BC
		public virtual int GetForceReinjectionEveryNSteps()
		{
			return vtkParticleTracerBase.vtkParticleTracerBase_GetForceReinjectionEveryNSteps_11(base.GetCppThis());
		}

		// Token: 0x0600DDF1 RID: 56817
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkParticleTracerBase_GetForceSerialExecution_12(HandleRef pThis);

		/// <summary>
		/// Force the filter to run particle tracer in serial. This affects
		/// the filter only if more than 100 particles is to be generated.
		/// </summary>
		// Token: 0x0600DDF2 RID: 56818 RVA: 0x001341DC File Offset: 0x001323DC
		public virtual bool GetForceSerialExecution()
		{
			return vtkParticleTracerBase.vtkParticleTracerBase_GetForceSerialExecution_12(base.GetCppThis()) != 0;
		}

		// Token: 0x0600DDF3 RID: 56819
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParticleTracerBase_GetIgnorePipelineTime_13(HandleRef pThis);

		/// <summary>
		/// To get around problems with the Paraview Animation controls
		/// we can just animate the time step and ignore the TIME_ requests
		/// </summary>
		// Token: 0x0600DDF4 RID: 56820 RVA: 0x00134204 File Offset: 0x00132404
		public virtual int GetIgnorePipelineTime()
		{
			return vtkParticleTracerBase.vtkParticleTracerBase_GetIgnorePipelineTime_13(base.GetCppThis());
		}

		// Token: 0x0600DDF5 RID: 56821
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParticleTracerBase_GetIntegrator_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Setting TerminationTime to a positive value will cause particles
		/// to terminate when the time is reached. Use a vlue of zero to
		/// disable termination. The units of time should be consistent with the
		/// primary time variable.
		/// </summary>
		// Token: 0x0600DDF6 RID: 56822 RVA: 0x00134224 File Offset: 0x00132424
		public virtual vtkInitialValueProblemSolver GetIntegrator()
		{
			vtkInitialValueProblemSolver vtkInitialValueProblemSolver = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParticleTracerBase.vtkParticleTracerBase_GetIntegrator_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600DDF7 RID: 56823
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParticleTracerBase_GetIntegratorType_15(HandleRef pThis);

		/// <summary>
		/// Setting TerminationTime to a positive value will cause particles
		/// to terminate when the time is reached. Use a vlue of zero to
		/// disable termination. The units of time should be consistent with the
		/// primary time variable.
		/// </summary>
		// Token: 0x0600DDF8 RID: 56824 RVA: 0x00134294 File Offset: 0x00132494
		public int GetIntegratorType()
		{
			return vtkParticleTracerBase.vtkParticleTracerBase_GetIntegratorType_15(base.GetCppThis());
		}

		// Token: 0x0600DDF9 RID: 56825
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParticleTracerBase_GetMeshOverTime_16(HandleRef pThis);

		/// <summary>
		/// Types of Variance of Mesh over time
		/// </summary>
		// Token: 0x0600DDFA RID: 56826 RVA: 0x001342B4 File Offset: 0x001324B4
		public virtual int GetMeshOverTime()
		{
			return vtkParticleTracerBase.vtkParticleTracerBase_GetMeshOverTime_16(base.GetCppThis());
		}

		// Token: 0x0600DDFB RID: 56827
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParticleTracerBase_GetMeshOverTimeMaxValue_17(HandleRef pThis);

		/// <summary>
		/// Types of Variance of Mesh over time
		/// </summary>
		// Token: 0x0600DDFC RID: 56828 RVA: 0x001342D4 File Offset: 0x001324D4
		public virtual int GetMeshOverTimeMaxValue()
		{
			return vtkParticleTracerBase.vtkParticleTracerBase_GetMeshOverTimeMaxValue_17(base.GetCppThis());
		}

		// Token: 0x0600DDFD RID: 56829
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParticleTracerBase_GetMeshOverTimeMinValue_18(HandleRef pThis);

		/// <summary>
		/// Types of Variance of Mesh over time
		/// </summary>
		// Token: 0x0600DDFE RID: 56830 RVA: 0x001342F4 File Offset: 0x001324F4
		public virtual int GetMeshOverTimeMinValue()
		{
			return vtkParticleTracerBase.vtkParticleTracerBase_GetMeshOverTimeMinValue_18(base.GetCppThis());
		}

		// Token: 0x0600DDFF RID: 56831
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParticleTracerBase_GetNumberOfGenerationsFromBase_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DE00 RID: 56832 RVA: 0x00134314 File Offset: 0x00132514
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkParticleTracerBase.vtkParticleTracerBase_GetNumberOfGenerationsFromBase_19(base.GetCppThis(), type);
		}

		// Token: 0x0600DE01 RID: 56833
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParticleTracerBase_GetNumberOfGenerationsFromBaseType_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DE02 RID: 56834 RVA: 0x00134334 File Offset: 0x00132534
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkParticleTracerBase.vtkParticleTracerBase_GetNumberOfGenerationsFromBaseType_20(type);
		}

		// Token: 0x0600DE03 RID: 56835
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParticleTracerBase_GetParticleFileName_21(HandleRef pThis);

		/// <summary>
		/// Set/Get the filename to be used with the particle writer when
		/// dumping particles to disk
		/// </summary>
		// Token: 0x0600DE04 RID: 56836 RVA: 0x00134350 File Offset: 0x00132550
		public virtual string GetParticleFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkParticleTracerBase.vtkParticleTracerBase_GetParticleFileName_21(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600DE05 RID: 56837
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParticleTracerBase_GetParticleWriter_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the Writer associated with this Particle Tracer
		/// Ideally a parallel IO capable vtkH5PartWriter should be used
		/// which will collect particles from all parallel processes
		/// and write them to a single HDF5 file.
		/// </summary>
		// Token: 0x0600DE06 RID: 56838 RVA: 0x0013438C File Offset: 0x0013258C
		public virtual vtkAbstractParticleWriter GetParticleWriter()
		{
			vtkAbstractParticleWriter vtkAbstractParticleWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParticleTracerBase.vtkParticleTracerBase_GetParticleWriter_22(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractParticleWriter = (vtkAbstractParticleWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractParticleWriter.Register(null);
				}
			}
			return vtkAbstractParticleWriter;
		}

		// Token: 0x0600DE07 RID: 56839
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParticleTracerBase_GetRotationScale_23(HandleRef pThis);

		/// <summary>
		/// This can be used to scale the rate with which the streamribbons
		/// twist. The default is 1.
		/// </summary>
		// Token: 0x0600DE08 RID: 56840 RVA: 0x001343FC File Offset: 0x001325FC
		public virtual double GetRotationScale()
		{
			return vtkParticleTracerBase.vtkParticleTracerBase_GetRotationScale_23(base.GetCppThis());
		}

		// Token: 0x0600DE09 RID: 56841
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParticleTracerBase_GetStartTime_24(HandleRef pThis);

		/// <summary>
		/// Set the time value for particle tracing to begin. The units of time should
		/// be consistent with the primary time variable.
		/// </summary>
		// Token: 0x0600DE0A RID: 56842 RVA: 0x0013441C File Offset: 0x0013261C
		public virtual double GetStartTime()
		{
			return vtkParticleTracerBase.vtkParticleTracerBase_GetStartTime_24(base.GetCppThis());
		}

		// Token: 0x0600DE0B RID: 56843
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParticleTracerBase_GetStaticSeeds_25(HandleRef pThis);

		/// <summary>
		/// if StaticSeeds is set and the mesh is static,
		/// then every time particles are injected we can re-use the same
		/// injection information. We classify particles according to
		/// processor just once before start.
		/// If StaticSeeds is set and a moving seed source is specified
		/// the motion will be ignored and results will not be as expected.
		/// The default is that StaticSeeds is 0.
		/// </summary>
		// Token: 0x0600DE0C RID: 56844 RVA: 0x0013443C File Offset: 0x0013263C
		public virtual int GetStaticSeeds()
		{
			return vtkParticleTracerBase.vtkParticleTracerBase_GetStaticSeeds_25(base.GetCppThis());
		}

		// Token: 0x0600DE0D RID: 56845
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParticleTracerBase_GetTerminalSpeed_26(HandleRef pThis);

		/// <summary>
		/// Specify the terminal speed value, below which integration is terminated.
		/// </summary>
		// Token: 0x0600DE0E RID: 56846 RVA: 0x0013445C File Offset: 0x0013265C
		public virtual double GetTerminalSpeed()
		{
			return vtkParticleTracerBase.vtkParticleTracerBase_GetTerminalSpeed_26(base.GetCppThis());
		}

		// Token: 0x0600DE0F RID: 56847
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParticleTracerBase_GetTerminationTime_27(HandleRef pThis);

		/// <summary>
		/// Setting TerminationTime to a positive value will cause particles
		/// to terminate when the time is reached. Use a vlue of zero to
		/// disable termination. The units of time should be consistent with the
		/// primary time variable.
		/// </summary>
		// Token: 0x0600DE10 RID: 56848 RVA: 0x0013447C File Offset: 0x0013267C
		public virtual double GetTerminationTime()
		{
			return vtkParticleTracerBase.vtkParticleTracerBase_GetTerminationTime_27(base.GetCppThis());
		}

		// Token: 0x0600DE11 RID: 56849
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParticleTracerBase_IgnorePipelineTimeOff_28(HandleRef pThis);

		/// <summary>
		/// To get around problems with the Paraview Animation controls
		/// we can just animate the time step and ignore the TIME_ requests
		/// </summary>
		// Token: 0x0600DE12 RID: 56850 RVA: 0x0013449B File Offset: 0x0013269B
		public virtual void IgnorePipelineTimeOff()
		{
			vtkParticleTracerBase.vtkParticleTracerBase_IgnorePipelineTimeOff_28(base.GetCppThis());
		}

		// Token: 0x0600DE13 RID: 56851
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParticleTracerBase_IgnorePipelineTimeOn_29(HandleRef pThis);

		/// <summary>
		/// To get around problems with the Paraview Animation controls
		/// we can just animate the time step and ignore the TIME_ requests
		/// </summary>
		// Token: 0x0600DE14 RID: 56852 RVA: 0x001344AA File Offset: 0x001326AA
		public virtual void IgnorePipelineTimeOn()
		{
			vtkParticleTracerBase.vtkParticleTracerBase_IgnorePipelineTimeOn_29(base.GetCppThis());
		}

		// Token: 0x0600DE15 RID: 56853
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParticleTracerBase_IsA_30(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DE16 RID: 56854 RVA: 0x001344BC File Offset: 0x001326BC
		public override int IsA(string type)
		{
			return vtkParticleTracerBase.vtkParticleTracerBase_IsA_30(base.GetCppThis(), type);
		}

		// Token: 0x0600DE17 RID: 56855
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParticleTracerBase_IsTypeOf_31([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DE18 RID: 56856 RVA: 0x001344DC File Offset: 0x001326DC
		public new static int IsTypeOf(string type)
		{
			return vtkParticleTracerBase.vtkParticleTracerBase_IsTypeOf_31(type);
		}

		// Token: 0x0600DE19 RID: 56857
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParticleTracerBase_NewInstance_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DE1A RID: 56858 RVA: 0x001344F8 File Offset: 0x001326F8
		public new vtkParticleTracerBase NewInstance()
		{
			vtkParticleTracerBase result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParticleTracerBase.vtkParticleTracerBase_NewInstance_32(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParticleTracerBase)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600DE1B RID: 56859
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParticleTracerBase_PrintParticleHistories_33(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DE1C RID: 56860 RVA: 0x00134552 File Offset: 0x00132752
		public void PrintParticleHistories()
		{
			vtkParticleTracerBase.vtkParticleTracerBase_PrintParticleHistories_33(base.GetCppThis());
		}

		// Token: 0x0600DE1D RID: 56861
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParticleTracerBase_RemoveAllSources_34(HandleRef pThis);

		/// <summary>
		/// Provide support for multiple seed sources
		/// </summary>
		// Token: 0x0600DE1E RID: 56862 RVA: 0x00134561 File Offset: 0x00132761
		public void RemoveAllSources()
		{
			vtkParticleTracerBase.vtkParticleTracerBase_RemoveAllSources_34(base.GetCppThis());
		}

		// Token: 0x0600DE1F RID: 56863
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParticleTracerBase_SafeDownCast_35(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DE20 RID: 56864 RVA: 0x00134570 File Offset: 0x00132770
		public new static vtkParticleTracerBase SafeDownCast(vtkObjectBase o)
		{
			vtkParticleTracerBase vtkParticleTracerBase = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParticleTracerBase.vtkParticleTracerBase_SafeDownCast_35((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParticleTracerBase = (vtkParticleTracerBase)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParticleTracerBase.Register(null);
				}
			}
			return vtkParticleTracerBase;
		}

		// Token: 0x0600DE21 RID: 56865
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParticleTracerBase_SetComputeVorticity_36(HandleRef pThis, byte arg0);

		/// <summary>
		/// Turn on/off vorticity computation at streamline points
		/// (necessary for generating proper stream-ribbons using the
		/// vtkRibbonFilter.
		/// </summary>
		// Token: 0x0600DE22 RID: 56866 RVA: 0x001345EF File Offset: 0x001327EF
		public void SetComputeVorticity(bool arg0)
		{
			vtkParticleTracerBase.vtkParticleTracerBase_SetComputeVorticity_36(base.GetCppThis(), arg0 ? (byte)1 : (byte)0);
		}

		// Token: 0x0600DE23 RID: 56867
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParticleTracerBase_SetDisableResetCache_37(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the flag to disable cache
		/// This is off by default and turned on in special circumstances
		/// such as in a coprocessing workflow
		/// </summary>
		// Token: 0x0600DE24 RID: 56868 RVA: 0x00134607 File Offset: 0x00132807
		public virtual void SetDisableResetCache(int _arg)
		{
			vtkParticleTracerBase.vtkParticleTracerBase_SetDisableResetCache_37(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DE25 RID: 56869
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParticleTracerBase_SetEnableParticleWriting_38(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the filename to be used with the particle writer when
		/// dumping particles to disk
		/// </summary>
		// Token: 0x0600DE26 RID: 56870 RVA: 0x00134617 File Offset: 0x00132817
		public virtual void SetEnableParticleWriting(int _arg)
		{
			vtkParticleTracerBase.vtkParticleTracerBase_SetEnableParticleWriting_38(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DE27 RID: 56871
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParticleTracerBase_SetForceReinjectionEveryNSteps_39(HandleRef pThis, int arg0);

		/// <summary>
		/// When animating particles, it is nice to inject new ones every Nth step
		/// to produce a continuous flow. Setting ForceReinjectionEveryNSteps to a
		/// non zero value will cause the particle source to reinject particles
		/// every Nth step even if it is otherwise unchanged.
		/// Note that if the particle source is also animated, this flag will be
		/// redundant as the particles will be reinjected whenever the source changes
		/// anyway
		/// </summary>
		// Token: 0x0600DE28 RID: 56872 RVA: 0x00134627 File Offset: 0x00132827
		public void SetForceReinjectionEveryNSteps(int arg0)
		{
			vtkParticleTracerBase.vtkParticleTracerBase_SetForceReinjectionEveryNSteps_39(base.GetCppThis(), arg0);
		}

		// Token: 0x0600DE29 RID: 56873
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParticleTracerBase_SetForceSerialExecution_40(HandleRef pThis, byte _arg);

		/// <summary>
		/// Force the filter to run particle tracer in serial. This affects
		/// the filter only if more than 100 particles is to be generated.
		/// </summary>
		// Token: 0x0600DE2A RID: 56874 RVA: 0x00134637 File Offset: 0x00132837
		public virtual void SetForceSerialExecution(bool _arg)
		{
			vtkParticleTracerBase.vtkParticleTracerBase_SetForceSerialExecution_40(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600DE2B RID: 56875
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParticleTracerBase_SetIgnorePipelineTime_41(HandleRef pThis, int _arg);

		/// <summary>
		/// To get around problems with the Paraview Animation controls
		/// we can just animate the time step and ignore the TIME_ requests
		/// </summary>
		// Token: 0x0600DE2C RID: 56876 RVA: 0x0013464F File Offset: 0x0013284F
		public virtual void SetIgnorePipelineTime(int _arg)
		{
			vtkParticleTracerBase.vtkParticleTracerBase_SetIgnorePipelineTime_41(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DE2D RID: 56877
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParticleTracerBase_SetIntegrator_42(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Setting TerminationTime to a positive value will cause particles
		/// to terminate when the time is reached. Use a vlue of zero to
		/// disable termination. The units of time should be consistent with the
		/// primary time variable.
		/// </summary>
		// Token: 0x0600DE2E RID: 56878 RVA: 0x00134660 File Offset: 0x00132860
		public void SetIntegrator(vtkInitialValueProblemSolver arg0)
		{
			vtkParticleTracerBase.vtkParticleTracerBase_SetIntegrator_42(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600DE2F RID: 56879
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParticleTracerBase_SetIntegratorType_43(HandleRef pThis, int type);

		/// <summary>
		/// Setting TerminationTime to a positive value will cause particles
		/// to terminate when the time is reached. Use a vlue of zero to
		/// disable termination. The units of time should be consistent with the
		/// primary time variable.
		/// </summary>
		// Token: 0x0600DE30 RID: 56880 RVA: 0x0013468F File Offset: 0x0013288F
		public void SetIntegratorType(int type)
		{
			vtkParticleTracerBase.vtkParticleTracerBase_SetIntegratorType_43(base.GetCppThis(), type);
		}

		// Token: 0x0600DE31 RID: 56881
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParticleTracerBase_SetInterpolatorType_44(HandleRef pThis, int interpolatorType);

		/// <summary>
		/// Set the type of the velocity field interpolator to determine whether
		/// INTERPOLATOR_WITH_DATASET_POINT_LOCATOR or INTERPOLATOR_WITH_CELL_LOCATOR
		/// is employed for locating cells during streamline integration. The latter
		/// (adopting vtkAbstractCellLocator sub-classes such as vtkCellLocator and
		/// vtkModifiedBSPTree) is more robust than the former (through vtkDataSet /
		/// vtkPointSet::FindCell() coupled with vtkPointLocator). However the former
		/// can be much faster and produce adequate results.
		///
		/// Default is INTERPOLATOR_WITH_CELL_LOCATOR (to maintain backwards compatibility).
		/// </summary>
		// Token: 0x0600DE32 RID: 56882 RVA: 0x0013469F File Offset: 0x0013289F
		public void SetInterpolatorType(int interpolatorType)
		{
			vtkParticleTracerBase.vtkParticleTracerBase_SetInterpolatorType_44(base.GetCppThis(), interpolatorType);
		}

		// Token: 0x0600DE33 RID: 56883
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParticleTracerBase_SetInterpolatorTypeToCellLocator_45(HandleRef pThis);

		/// <summary>
		/// Set the velocity field interpolator type to one that uses a cell locator
		/// to perform spatial searching. Using a cell locator should always return
		/// the correct results, but it can be much slower that point locator-based
		/// searches. * By default a cell locator is used.
		/// </summary>
		// Token: 0x0600DE34 RID: 56884 RVA: 0x001346AF File Offset: 0x001328AF
		public void SetInterpolatorTypeToCellLocator()
		{
			vtkParticleTracerBase.vtkParticleTracerBase_SetInterpolatorTypeToCellLocator_45(base.GetCppThis());
		}

		// Token: 0x0600DE35 RID: 56885
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParticleTracerBase_SetInterpolatorTypeToDataSetPointLocator_46(HandleRef pThis);

		/// <summary>
		/// Set the velocity field interpolator type to one that uses a point
		/// locator to perform local spatial searching. Typically a point locator is
		/// faster than searches with a cell locator, but it may not always find the
		/// correct cells enclosing a point. This is particularly true with meshes
		/// that are disjoint at seams, or abut meshes in an incompatible manner.
		/// </summary>
		// Token: 0x0600DE36 RID: 56886 RVA: 0x001346BE File Offset: 0x001328BE
		public void SetInterpolatorTypeToDataSetPointLocator()
		{
			vtkParticleTracerBase.vtkParticleTracerBase_SetInterpolatorTypeToDataSetPointLocator_46(base.GetCppThis());
		}

		// Token: 0x0600DE37 RID: 56887
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParticleTracerBase_SetMeshOverTime_47(HandleRef pThis, int meshOverTime);

		/// <summary>
		/// Types of Variance of Mesh over time
		/// </summary>
		// Token: 0x0600DE38 RID: 56888 RVA: 0x001346CD File Offset: 0x001328CD
		public virtual void SetMeshOverTime(int meshOverTime)
		{
			vtkParticleTracerBase.vtkParticleTracerBase_SetMeshOverTime_47(base.GetCppThis(), meshOverTime);
		}

		// Token: 0x0600DE39 RID: 56889
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParticleTracerBase_SetMeshOverTimeToDifferent_48(HandleRef pThis);

		/// <summary>
		/// Types of Variance of Mesh over time
		/// </summary>
		// Token: 0x0600DE3A RID: 56890 RVA: 0x001346DD File Offset: 0x001328DD
		public void SetMeshOverTimeToDifferent()
		{
			vtkParticleTracerBase.vtkParticleTracerBase_SetMeshOverTimeToDifferent_48(base.GetCppThis());
		}

		// Token: 0x0600DE3B RID: 56891
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParticleTracerBase_SetMeshOverTimeToLinearTransformation_49(HandleRef pThis);

		/// <summary>
		/// Types of Variance of Mesh over time
		/// </summary>
		// Token: 0x0600DE3C RID: 56892 RVA: 0x001346EC File Offset: 0x001328EC
		public void SetMeshOverTimeToLinearTransformation()
		{
			vtkParticleTracerBase.vtkParticleTracerBase_SetMeshOverTimeToLinearTransformation_49(base.GetCppThis());
		}

		// Token: 0x0600DE3D RID: 56893
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParticleTracerBase_SetMeshOverTimeToSameTopology_50(HandleRef pThis);

		/// <summary>
		/// Types of Variance of Mesh over time
		/// </summary>
		// Token: 0x0600DE3E RID: 56894 RVA: 0x001346FB File Offset: 0x001328FB
		public void SetMeshOverTimeToSameTopology()
		{
			vtkParticleTracerBase.vtkParticleTracerBase_SetMeshOverTimeToSameTopology_50(base.GetCppThis());
		}

		// Token: 0x0600DE3F RID: 56895
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParticleTracerBase_SetMeshOverTimeToStatic_51(HandleRef pThis);

		/// <summary>
		/// Types of Variance of Mesh over time
		/// </summary>
		// Token: 0x0600DE40 RID: 56896 RVA: 0x0013470A File Offset: 0x0013290A
		public void SetMeshOverTimeToStatic()
		{
			vtkParticleTracerBase.vtkParticleTracerBase_SetMeshOverTimeToStatic_51(base.GetCppThis());
		}

		// Token: 0x0600DE41 RID: 56897
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParticleTracerBase_SetParticleFileName_52(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the filename to be used with the particle writer when
		/// dumping particles to disk
		/// </summary>
		// Token: 0x0600DE42 RID: 56898 RVA: 0x00134719 File Offset: 0x00132919
		public virtual void SetParticleFileName(string _arg)
		{
			vtkParticleTracerBase.vtkParticleTracerBase_SetParticleFileName_52(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DE43 RID: 56899
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParticleTracerBase_SetParticleWriter_53(HandleRef pThis, HandleRef pw);

		/// <summary>
		/// Set/Get the Writer associated with this Particle Tracer
		/// Ideally a parallel IO capable vtkH5PartWriter should be used
		/// which will collect particles from all parallel processes
		/// and write them to a single HDF5 file.
		/// </summary>
		// Token: 0x0600DE44 RID: 56900 RVA: 0x0013472C File Offset: 0x0013292C
		public virtual void SetParticleWriter(vtkAbstractParticleWriter pw)
		{
			vtkParticleTracerBase.vtkParticleTracerBase_SetParticleWriter_53(base.GetCppThis(), (pw == null) ? default(HandleRef) : pw.GetCppThis());
		}

		// Token: 0x0600DE45 RID: 56901
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParticleTracerBase_SetRotationScale_54(HandleRef pThis, double arg0);

		/// <summary>
		/// This can be used to scale the rate with which the streamribbons
		/// twist. The default is 1.
		/// </summary>
		// Token: 0x0600DE46 RID: 56902 RVA: 0x0013475B File Offset: 0x0013295B
		public void SetRotationScale(double arg0)
		{
			vtkParticleTracerBase.vtkParticleTracerBase_SetRotationScale_54(base.GetCppThis(), arg0);
		}

		// Token: 0x0600DE47 RID: 56903
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParticleTracerBase_SetStartTime_55(HandleRef pThis, double t);

		/// <summary>
		/// Set the time value for particle tracing to begin. The units of time should
		/// be consistent with the primary time variable.
		/// </summary>
		// Token: 0x0600DE48 RID: 56904 RVA: 0x0013476B File Offset: 0x0013296B
		public void SetStartTime(double t)
		{
			vtkParticleTracerBase.vtkParticleTracerBase_SetStartTime_55(base.GetCppThis(), t);
		}

		// Token: 0x0600DE49 RID: 56905
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParticleTracerBase_SetStaticSeeds_56(HandleRef pThis, int _arg);

		/// <summary>
		/// if StaticSeeds is set and the mesh is static,
		/// then every time particles are injected we can re-use the same
		/// injection information. We classify particles according to
		/// processor just once before start.
		/// If StaticSeeds is set and a moving seed source is specified
		/// the motion will be ignored and results will not be as expected.
		/// The default is that StaticSeeds is 0.
		/// </summary>
		// Token: 0x0600DE4A RID: 56906 RVA: 0x0013477B File Offset: 0x0013297B
		public virtual void SetStaticSeeds(int _arg)
		{
			vtkParticleTracerBase.vtkParticleTracerBase_SetStaticSeeds_56(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DE4B RID: 56907
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParticleTracerBase_SetTerminalSpeed_57(HandleRef pThis, double arg0);

		/// <summary>
		/// Specify the terminal speed value, below which integration is terminated.
		/// </summary>
		// Token: 0x0600DE4C RID: 56908 RVA: 0x0013478B File Offset: 0x0013298B
		public void SetTerminalSpeed(double arg0)
		{
			vtkParticleTracerBase.vtkParticleTracerBase_SetTerminalSpeed_57(base.GetCppThis(), arg0);
		}

		// Token: 0x0600DE4D RID: 56909
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParticleTracerBase_SetTerminationTime_58(HandleRef pThis, double t);

		/// <summary>
		/// Setting TerminationTime to a positive value will cause particles
		/// to terminate when the time is reached. Use a vlue of zero to
		/// disable termination. The units of time should be consistent with the
		/// primary time variable.
		/// </summary>
		// Token: 0x0600DE4E RID: 56910 RVA: 0x0013479B File Offset: 0x0013299B
		public void SetTerminationTime(double t)
		{
			vtkParticleTracerBase.vtkParticleTracerBase_SetTerminationTime_58(base.GetCppThis(), t);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400102F RID: 4143
		public new const string MRFullTypeName = "Kitware.VTK.vtkParticleTracerBase";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001030 RID: 4144
		public new static readonly string MRClassNameKey = "class vtkParticleTracerBase";

		/// <summary>
		/// if StaticMesh is set, many optimizations for cell caching
		/// can be assumed. if StaticMesh is not set, the algorithm
		/// will attempt to find out if optimizations can be used, but
		/// setting it to true will force all optimizations.
		/// Do not Set StaticMesh to true if a dynamic mesh is being used
		/// as this will invalidate all results.
		/// The default is that StaticMesh is 0.
		/// </summary>
		// Token: 0x020004B9 RID: 1209
		public enum INTERPOLATOR_WITH_CELL_LOCATOR_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04001032 RID: 4146
			INTERPOLATOR_WITH_CELL_LOCATOR = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001033 RID: 4147
			INTERPOLATOR_WITH_DATASET_POINT_LOCATOR = 0
		}

		/// <summary>
		/// Types of Variance of Mesh over time
		/// </summary>
		// Token: 0x020004BA RID: 1210
		public enum MeshOverTimeTypes
		{
			/// <summary>enum member</summary>
			// Token: 0x04001035 RID: 4149
			DIFFERENT,
			/// <summary>enum member</summary>
			// Token: 0x04001036 RID: 4150
			LINEAR_TRANSFORMATION = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001037 RID: 4151
			SAME_TOPOLOGY,
			/// <summary>enum member</summary>
			// Token: 0x04001038 RID: 4152
			STATIC = 1
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x020004BB RID: 1211
		public enum Solvers
		{
			/// <summary>enum member</summary>
			// Token: 0x0400103A RID: 4154
			NONE = 3,
			/// <summary>enum member</summary>
			// Token: 0x0400103B RID: 4155
			RUNGE_KUTTA2 = 0,
			/// <summary>enum member</summary>
			// Token: 0x0400103C RID: 4156
			RUNGE_KUTTA4,
			/// <summary>enum member</summary>
			// Token: 0x0400103D RID: 4157
			RUNGE_KUTTA45,
			/// <summary>enum member</summary>
			// Token: 0x0400103E RID: 4158
			UNKNOWN = 4
		}
	}
}
