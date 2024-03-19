using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLagrangianBasicIntegrationModel
	/// </summary>
	/// <remarks>
	///    vtkFunctionSet abstract implementation to be used
	/// in the vtkLagrangianParticleTracker integrator.
	///
	/// This vtkFunctionSet abstract implementation
	/// is meant to be used as a parameter of vtkLagrangianParticleTracker.
	/// It manages multiple dataset locators in order to evaluate the
	/// vtkFunctionSet::FunctionValues method.
	/// The actual FunctionValues implementation should be found in the class inheriting
	/// this class.
	/// Input Arrays to process are expected as follows:
	/// Index 0 : "SurfaceType" array of surface input of the particle tracker
	///
	/// Inherited classes MUST implement
	/// int FunctionValues(vtkDataSet* detaSet, vtkIdType cellId, double* weights,
	///    double * x, double * f);
	/// to define how the integration works.
	///
	/// Inherited classes could reimplement InteractWithSurface or other surface interaction methods
	/// to change the way particles interact with surfaces.
	///
	/// Inherited classes could reimplement IntersectWithLine to use a specific algorithm
	/// to intersect particles and surface cells.
	///
	/// Inherited classes could reimplement CheckFreeFlightTermination to set
	/// the way particles terminate in free flight.
	///
	/// Inherited classes could reimplement Initialize*Data and Insert*Data in order
	/// to customize the output of the tracker
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkLagrangianParticleTracker vtkLagrangianParticle
	/// vtkLagrangianMatidaIntegrationModel
	/// </seealso>
	// Token: 0x020004AE RID: 1198
	public abstract class vtkLagrangianBasicIntegrationModel : vtkFunctionSet
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600DC3E RID: 56382 RVA: 0x0013185B File Offset: 0x0012FA5B
		static vtkLagrangianBasicIntegrationModel()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLagrangianBasicIntegrationModel.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLagrangianBasicIntegrationModel"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600DC3F RID: 56383 RVA: 0x00131883 File Offset: 0x0012FA83
		public vtkLagrangianBasicIntegrationModel(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600DC40 RID: 56384 RVA: 0x00131891 File Offset: 0x0012FA91
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600DC41 RID: 56385
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangianBasicIntegrationModel_AddDataSet_01(HandleRef pThis, HandleRef dataset, byte surface, uint surfaceFlatIndex);

		/// <summary>
		/// Add a dataset to locate cells in
		/// This create a specific locator for the provided dataset
		/// using the Locator member of this class
		/// The surface flag allow to manage surfaces datasets for surface interaction
		/// instead of flow datasets
		/// surfaceFlatIndex, used only with composite surface, in order to identify the
		/// flatIndex of the surface for particle interaction
		/// </summary>
		// Token: 0x0600DC42 RID: 56386 RVA: 0x0013189C File Offset: 0x0012FA9C
		public virtual void AddDataSet(vtkDataSet dataset, bool surface, uint surfaceFlatIndex)
		{
			vtkLagrangianBasicIntegrationModel.vtkLagrangianBasicIntegrationModel_AddDataSet_01(base.GetCppThis(), (dataset == null) ? default(HandleRef) : dataset.GetCppThis(), surface ? (byte)1 : (byte)0, surfaceFlatIndex);
		}

		// Token: 0x0600DC43 RID: 56387
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangianBasicIntegrationModel_ClearDataSets_02(HandleRef pThis, byte surface);

		/// <summary>
		/// Add a dataset to locate cells in
		/// This create a specific locator for the provided dataset
		/// using the Locator member of this class
		/// The surface flag allow to manage surfaces datasets for surface interaction
		/// instead of flow datasets
		/// surfaceFlatIndex, used only with composite surface, in order to identify the
		/// flatIndex of the surface for particle interaction
		/// </summary>
		// Token: 0x0600DC44 RID: 56388 RVA: 0x001318D5 File Offset: 0x0012FAD5
		public virtual void ClearDataSets(bool surface)
		{
			vtkLagrangianBasicIntegrationModel.vtkLagrangianBasicIntegrationModel_ClearDataSets_02(base.GetCppThis(), surface ? (byte)1 : (byte)0);
		}

		// Token: 0x0600DC45 RID: 56389
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkLagrangianBasicIntegrationModel_FinalizeOutputs_03(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		/// <summary>
		/// Enable model post process on output
		/// Return true if successful, false otherwise
		/// Empty and Always return true with basic model
		/// </summary>
		// Token: 0x0600DC46 RID: 56390 RVA: 0x001318F0 File Offset: 0x0012FAF0
		public virtual bool FinalizeOutputs(vtkPolyData arg0, vtkDataObject arg1)
		{
			return vtkLagrangianBasicIntegrationModel.vtkLagrangianBasicIntegrationModel_FinalizeOutputs_03(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis()) != 0;
		}

		// Token: 0x0600DC47 RID: 56391
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLagrangianBasicIntegrationModel_FunctionValues_04(HandleRef pThis, IntPtr x, IntPtr f, IntPtr userData);

		/// <summary>
		/// Evaluate integration model velocity f at position x.
		/// Look for the cell containing the position x in all its added datasets
		/// if found this will call
		/// FunctionValues(vtkDataSet* detaSet, vtkIdType cellId, double* x, double* f)
		/// This method is thread safe.
		/// </summary>
		// Token: 0x0600DC48 RID: 56392 RVA: 0x00131940 File Offset: 0x0012FB40
		public override int FunctionValues(IntPtr x, IntPtr f, IntPtr userData)
		{
			return vtkLagrangianBasicIntegrationModel.vtkLagrangianBasicIntegrationModel_FunctionValues_04(base.GetCppThis(), x, f, userData);
		}

		// Token: 0x0600DC49 RID: 56393
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangianBasicIntegrationModel_GetLocator_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the locator used to locate cells in the datasets.
		/// Only the locator class matter here, as it is used only to
		/// create NewInstance of it.
		/// Default is a vtkCellLocator.
		/// </summary>
		// Token: 0x0600DC4A RID: 56394 RVA: 0x00131964 File Offset: 0x0012FB64
		public virtual vtkAbstractCellLocator GetLocator()
		{
			vtkAbstractCellLocator vtkAbstractCellLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangianBasicIntegrationModel.vtkLagrangianBasicIntegrationModel_GetLocator_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractCellLocator = (vtkAbstractCellLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractCellLocator.Register(null);
				}
			}
			return vtkAbstractCellLocator;
		}

		// Token: 0x0600DC4B RID: 56395
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLagrangianBasicIntegrationModel_GetLocatorTolerance_06(HandleRef pThis);

		/// <summary>
		/// Get the specific tolerance to use with the locators.
		/// </summary>
		// Token: 0x0600DC4C RID: 56396 RVA: 0x001319D4 File Offset: 0x0012FBD4
		public virtual double GetLocatorTolerance()
		{
			return vtkLagrangianBasicIntegrationModel.vtkLagrangianBasicIntegrationModel_GetLocatorTolerance_06(base.GetCppThis());
		}

		// Token: 0x0600DC4D RID: 56397
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkLagrangianBasicIntegrationModel_GetLocatorsBuilt_07(HandleRef pThis);

		/// <summary>
		/// Get the state of the current locators
		/// </summary>
		// Token: 0x0600DC4E RID: 56398 RVA: 0x001319F4 File Offset: 0x0012FBF4
		public virtual bool GetLocatorsBuilt()
		{
			return vtkLagrangianBasicIntegrationModel.vtkLagrangianBasicIntegrationModel_GetLocatorsBuilt_07(base.GetCppThis()) != 0;
		}

		// Token: 0x0600DC4F RID: 56399
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkLagrangianBasicIntegrationModel_GetNonPlanarQuadSupport_08(HandleRef pThis);

		/// <summary>
		/// Set/Get Non Planar Quad Support
		/// </summary>
		// Token: 0x0600DC50 RID: 56400 RVA: 0x00131A1C File Offset: 0x0012FC1C
		public virtual bool GetNonPlanarQuadSupport()
		{
			return vtkLagrangianBasicIntegrationModel.vtkLagrangianBasicIntegrationModel_GetNonPlanarQuadSupport_08(base.GetCppThis()) != 0;
		}

		// Token: 0x0600DC51 RID: 56401
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLagrangianBasicIntegrationModel_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DC52 RID: 56402 RVA: 0x00131A44 File Offset: 0x0012FC44
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLagrangianBasicIntegrationModel.vtkLagrangianBasicIntegrationModel_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x0600DC53 RID: 56403
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLagrangianBasicIntegrationModel_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DC54 RID: 56404 RVA: 0x00131A64 File Offset: 0x0012FC64
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLagrangianBasicIntegrationModel.vtkLagrangianBasicIntegrationModel_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x0600DC55 RID: 56405
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLagrangianBasicIntegrationModel_GetNumberOfTrackedUserData_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of tracked user data attached to the particles.
		/// Tracked user data are data that are related to each particle position
		/// but are not integrated like the user variables.
		/// They are not saved in the particle path.
		/// Default is 0.
		/// </summary>
		// Token: 0x0600DC56 RID: 56406 RVA: 0x00131A80 File Offset: 0x0012FC80
		public virtual int GetNumberOfTrackedUserData()
		{
			return vtkLagrangianBasicIntegrationModel.vtkLagrangianBasicIntegrationModel_GetNumberOfTrackedUserData_11(base.GetCppThis());
		}

		// Token: 0x0600DC57 RID: 56407
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangianBasicIntegrationModel_GetSeedArray_12(HandleRef pThis, int idx, HandleRef pointData, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get a seed array, as set in setInputArrayToProcess
		/// from the provided seed point data
		/// </summary>
		// Token: 0x0600DC58 RID: 56408 RVA: 0x00131AA0 File Offset: 0x0012FCA0
		public virtual vtkAbstractArray GetSeedArray(int idx, vtkPointData pointData)
		{
			vtkAbstractArray vtkAbstractArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangianBasicIntegrationModel.vtkLagrangianBasicIntegrationModel_GetSeedArray_12(base.GetCppThis(), idx, (pointData == null) ? default(HandleRef) : pointData.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractArray = (vtkAbstractArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractArray.Register(null);
				}
			}
			return vtkAbstractArray;
		}

		// Token: 0x0600DC59 RID: 56409
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangianBasicIntegrationModel_GetSeedArrayComps_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the seed arrays expected number of components
		/// Used Only be the vtkLagrangianSeedHelper in ParaView plugins
		/// </summary>
		// Token: 0x0600DC5A RID: 56410 RVA: 0x00131B28 File Offset: 0x0012FD28
		public virtual vtkIntArray GetSeedArrayComps()
		{
			vtkIntArray vtkIntArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangianBasicIntegrationModel.vtkLagrangianBasicIntegrationModel_GetSeedArrayComps_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIntArray = (vtkIntArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIntArray.Register(null);
				}
			}
			return vtkIntArray;
		}

		// Token: 0x0600DC5B RID: 56411
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangianBasicIntegrationModel_GetSeedArrayNames_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the seed arrays expected name
		/// Used Only be the vtkLagrangianSeedHelper in ParaView plugins
		/// </summary>
		// Token: 0x0600DC5C RID: 56412 RVA: 0x00131B98 File Offset: 0x0012FD98
		public virtual vtkStringArray GetSeedArrayNames()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangianBasicIntegrationModel.vtkLagrangianBasicIntegrationModel_GetSeedArrayNames_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringArray = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringArray.Register(null);
				}
			}
			return vtkStringArray;
		}

		// Token: 0x0600DC5D RID: 56413
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangianBasicIntegrationModel_GetSeedArrayTypes_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the seed arrays expected type
		/// Used Only be the vtkLagrangianSeedHelper in ParaView plugins
		/// </summary>
		// Token: 0x0600DC5E RID: 56414 RVA: 0x00131C08 File Offset: 0x0012FE08
		public virtual vtkIntArray GetSeedArrayTypes()
		{
			vtkIntArray vtkIntArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangianBasicIntegrationModel.vtkLagrangianBasicIntegrationModel_GetSeedArrayTypes_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIntArray = (vtkIntArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIntArray.Register(null);
				}
			}
			return vtkIntArray;
		}

		// Token: 0x0600DC5F RID: 56415
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangianBasicIntegrationModel_GetSurfaceArrayComps_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the seed array expected number of components
		/// Used Only be the vtkLagrangianSurfaceHelper in ParaView plugins
		/// </summary>
		// Token: 0x0600DC60 RID: 56416 RVA: 0x00131C78 File Offset: 0x0012FE78
		public virtual vtkIntArray GetSurfaceArrayComps()
		{
			vtkIntArray vtkIntArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangianBasicIntegrationModel.vtkLagrangianBasicIntegrationModel_GetSurfaceArrayComps_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIntArray = (vtkIntArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIntArray.Register(null);
				}
			}
			return vtkIntArray;
		}

		// Token: 0x0600DC61 RID: 56417
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangianBasicIntegrationModel_GetSurfaceArrayDefaultValues_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the surface arrays default values for each leaf
		/// Used Only be the vtkLagrangianSurfaceHelper in ParaView plugins
		/// </summary>
		// Token: 0x0600DC62 RID: 56418 RVA: 0x00131CE8 File Offset: 0x0012FEE8
		public virtual vtkDoubleArray GetSurfaceArrayDefaultValues()
		{
			vtkDoubleArray vtkDoubleArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangianBasicIntegrationModel.vtkLagrangianBasicIntegrationModel_GetSurfaceArrayDefaultValues_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDoubleArray = (vtkDoubleArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDoubleArray.Register(null);
				}
			}
			return vtkDoubleArray;
		}

		// Token: 0x0600DC63 RID: 56419
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangianBasicIntegrationModel_GetSurfaceArrayEnumValues_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the surface arrays expected values and associated enums
		/// Used Only be the vtkLagrangianSurfaceHelper in ParaView plugins
		/// </summary>
		// Token: 0x0600DC64 RID: 56420 RVA: 0x00131D58 File Offset: 0x0012FF58
		public virtual vtkStringArray GetSurfaceArrayEnumValues()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangianBasicIntegrationModel.vtkLagrangianBasicIntegrationModel_GetSurfaceArrayEnumValues_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringArray = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringArray.Register(null);
				}
			}
			return vtkStringArray;
		}

		// Token: 0x0600DC65 RID: 56421
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangianBasicIntegrationModel_GetSurfaceArrayNames_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the surface arrays expected name
		/// Used Only be the vtkLagrangianSurfaceHelper in ParaView plugins
		/// </summary>
		// Token: 0x0600DC66 RID: 56422 RVA: 0x00131DC8 File Offset: 0x0012FFC8
		public virtual vtkStringArray GetSurfaceArrayNames()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangianBasicIntegrationModel.vtkLagrangianBasicIntegrationModel_GetSurfaceArrayNames_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringArray = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringArray.Register(null);
				}
			}
			return vtkStringArray;
		}

		// Token: 0x0600DC67 RID: 56423
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangianBasicIntegrationModel_GetSurfaceArrayTypes_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the surface arrays expected type
		/// Used Only be the vtkLagrangianSurfaceHelper in ParaView plugins
		/// </summary>
		// Token: 0x0600DC68 RID: 56424 RVA: 0x00131E38 File Offset: 0x00130038
		public virtual vtkIntArray GetSurfaceArrayTypes()
		{
			vtkIntArray vtkIntArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangianBasicIntegrationModel.vtkLagrangianBasicIntegrationModel_GetSurfaceArrayTypes_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIntArray = (vtkIntArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIntArray.Register(null);
				}
			}
			return vtkIntArray;
		}

		// Token: 0x0600DC69 RID: 56425
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLagrangianBasicIntegrationModel_GetTolerance_21(HandleRef pThis);

		/// <summary>
		/// Get the tolerance to use with this model.
		/// </summary>
		// Token: 0x0600DC6A RID: 56426 RVA: 0x00131EA8 File Offset: 0x001300A8
		public virtual double GetTolerance()
		{
			return vtkLagrangianBasicIntegrationModel.vtkLagrangianBasicIntegrationModel_GetTolerance_21(base.GetCppThis());
		}

		// Token: 0x0600DC6B RID: 56427
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkLagrangianBasicIntegrationModel_GetUseInitialIntegrationTime_22(HandleRef pThis);

		/// <summary>
		/// Set/Get the Use of initial integration input array to process
		/// </summary>
		// Token: 0x0600DC6C RID: 56428 RVA: 0x00131EC8 File Offset: 0x001300C8
		public virtual bool GetUseInitialIntegrationTime()
		{
			return vtkLagrangianBasicIntegrationModel.vtkLagrangianBasicIntegrationModel_GetUseInitialIntegrationTime_22(base.GetCppThis()) != 0;
		}

		// Token: 0x0600DC6D RID: 56429
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLagrangianBasicIntegrationModel_GetWeightsSize_23(HandleRef pThis);

		/// <summary>
		/// Get the maximum weights size necessary for calling
		/// FindInLocators with weights
		/// </summary>
		// Token: 0x0600DC6E RID: 56430 RVA: 0x00131EF0 File Offset: 0x001300F0
		public virtual int GetWeightsSize()
		{
			return vtkLagrangianBasicIntegrationModel.vtkLagrangianBasicIntegrationModel_GetWeightsSize_23(base.GetCppThis());
		}

		// Token: 0x0600DC6F RID: 56431
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangianBasicIntegrationModel_InitializeInteractionData_24(HandleRef pThis, HandleRef data);

		/// <summary>
		/// Method used by the LPT to initialize data insertion in the provided
		/// vtkFieldData. It initializes Interaction.
		/// Reimplement as needed in accordance with InsertInteractionData.
		/// </summary>
		// Token: 0x0600DC70 RID: 56432 RVA: 0x00131F10 File Offset: 0x00130110
		public virtual void InitializeInteractionData(vtkFieldData data)
		{
			vtkLagrangianBasicIntegrationModel.vtkLagrangianBasicIntegrationModel_InitializeInteractionData_24(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis());
		}

		// Token: 0x0600DC71 RID: 56433
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangianBasicIntegrationModel_InitializeParticleData_25(HandleRef pThis, HandleRef particleData, int maxTuples);

		/// <summary>
		/// Method used by the LPT to initialize data insertion in the provided
		/// vtkFieldData. It initializes StepNumber, ParticleVelocity, IntegrationTime.
		/// Reimplement as needed in accordance with InsertParticleData.
		/// </summary>
		// Token: 0x0600DC72 RID: 56434 RVA: 0x00131F40 File Offset: 0x00130140
		public virtual void InitializeParticleData(vtkFieldData particleData, int maxTuples)
		{
			vtkLagrangianBasicIntegrationModel.vtkLagrangianBasicIntegrationModel_InitializeParticleData_25(base.GetCppThis(), (particleData == null) ? default(HandleRef) : particleData.GetCppThis(), maxTuples);
		}

		// Token: 0x0600DC73 RID: 56435
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangianBasicIntegrationModel_InitializePathData_26(HandleRef pThis, HandleRef data);

		/// <summary>
		/// Method used by the LPT to initialize data insertion in the provided
		/// vtkFieldData. It initializes Id, ParentID, SeedID and Termination.
		/// Reimplement as needed in accordance with InsertPathData.
		/// </summary>
		// Token: 0x0600DC74 RID: 56436 RVA: 0x00131F70 File Offset: 0x00130170
		public virtual void InitializePathData(vtkFieldData data)
		{
			vtkLagrangianBasicIntegrationModel.vtkLagrangianBasicIntegrationModel_InitializePathData_26(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis());
		}

		// Token: 0x0600DC75 RID: 56437
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLagrangianBasicIntegrationModel_IsA_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DC76 RID: 56438 RVA: 0x00131FA0 File Offset: 0x001301A0
		public override int IsA(string type)
		{
			return vtkLagrangianBasicIntegrationModel.vtkLagrangianBasicIntegrationModel_IsA_27(base.GetCppThis(), type);
		}

		// Token: 0x0600DC77 RID: 56439
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLagrangianBasicIntegrationModel_IsTypeOf_28([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DC78 RID: 56440 RVA: 0x00131FC0 File Offset: 0x001301C0
		public new static int IsTypeOf(string type)
		{
			return vtkLagrangianBasicIntegrationModel.vtkLagrangianBasicIntegrationModel_IsTypeOf_28(type);
		}

		// Token: 0x0600DC79 RID: 56441
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangianBasicIntegrationModel_NewInstance_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DC7A RID: 56442 RVA: 0x00131FDC File Offset: 0x001301DC
		public new vtkLagrangianBasicIntegrationModel NewInstance()
		{
			vtkLagrangianBasicIntegrationModel result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangianBasicIntegrationModel.vtkLagrangianBasicIntegrationModel_NewInstance_29(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLagrangianBasicIntegrationModel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600DC7B RID: 56443
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangianBasicIntegrationModel_NonPlanarQuadSupportOff_30(HandleRef pThis);

		/// <summary>
		/// Set/Get Non Planar Quad Support
		/// </summary>
		// Token: 0x0600DC7C RID: 56444 RVA: 0x00132036 File Offset: 0x00130236
		public virtual void NonPlanarQuadSupportOff()
		{
			vtkLagrangianBasicIntegrationModel.vtkLagrangianBasicIntegrationModel_NonPlanarQuadSupportOff_30(base.GetCppThis());
		}

		// Token: 0x0600DC7D RID: 56445
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangianBasicIntegrationModel_NonPlanarQuadSupportOn_31(HandleRef pThis);

		/// <summary>
		/// Set/Get Non Planar Quad Support
		/// </summary>
		// Token: 0x0600DC7E RID: 56446 RVA: 0x00132045 File Offset: 0x00130245
		public virtual void NonPlanarQuadSupportOn()
		{
			vtkLagrangianBasicIntegrationModel.vtkLagrangianBasicIntegrationModel_NonPlanarQuadSupportOn_31(base.GetCppThis());
		}

		// Token: 0x0600DC7F RID: 56447
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangianBasicIntegrationModel_PreParticleInitalization_32(HandleRef pThis);

		/// <summary>
		/// Allow for model setup prior to Particle Initialization
		/// </summary>
		// Token: 0x0600DC80 RID: 56448 RVA: 0x00132054 File Offset: 0x00130254
		public virtual void PreParticleInitalization()
		{
			vtkLagrangianBasicIntegrationModel.vtkLagrangianBasicIntegrationModel_PreParticleInitalization_32(base.GetCppThis());
		}

		// Token: 0x0600DC81 RID: 56449
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangianBasicIntegrationModel_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DC82 RID: 56450 RVA: 0x00132064 File Offset: 0x00130264
		public new static vtkLagrangianBasicIntegrationModel SafeDownCast(vtkObjectBase o)
		{
			vtkLagrangianBasicIntegrationModel vtkLagrangianBasicIntegrationModel = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangianBasicIntegrationModel.vtkLagrangianBasicIntegrationModel_SafeDownCast_33((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600DC83 RID: 56451
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangianBasicIntegrationModel_SetInputArrayToProcess_34(HandleRef pThis, int idx, int port, int connection, int fieldAssociation, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Set a input array to process at a specific index, identified by a port,
		/// connection, fieldAssociation and a name.
		/// Each inherited class can specify their own input array to process
		/// </summary>
		// Token: 0x0600DC84 RID: 56452 RVA: 0x001320E3 File Offset: 0x001302E3
		public virtual void SetInputArrayToProcess(int idx, int port, int connection, int fieldAssociation, string name)
		{
			vtkLagrangianBasicIntegrationModel.vtkLagrangianBasicIntegrationModel_SetInputArrayToProcess_34(base.GetCppThis(), idx, port, connection, fieldAssociation, name);
		}

		// Token: 0x0600DC85 RID: 56453
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangianBasicIntegrationModel_SetLocator_35(HandleRef pThis, HandleRef locator);

		/// <summary>
		/// Set/Get the locator used to locate cells in the datasets.
		/// Only the locator class matter here, as it is used only to
		/// create NewInstance of it.
		/// Default is a vtkCellLocator.
		/// </summary>
		// Token: 0x0600DC86 RID: 56454 RVA: 0x001320FC File Offset: 0x001302FC
		public virtual void SetLocator(vtkAbstractCellLocator locator)
		{
			vtkLagrangianBasicIntegrationModel.vtkLagrangianBasicIntegrationModel_SetLocator_35(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		// Token: 0x0600DC87 RID: 56455
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangianBasicIntegrationModel_SetLocatorsBuilt_36(HandleRef pThis, byte _arg);

		/// <summary>
		/// Get the state of the current locators
		/// </summary>
		// Token: 0x0600DC88 RID: 56456 RVA: 0x0013212B File Offset: 0x0013032B
		public virtual void SetLocatorsBuilt(bool _arg)
		{
			vtkLagrangianBasicIntegrationModel.vtkLagrangianBasicIntegrationModel_SetLocatorsBuilt_36(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600DC89 RID: 56457
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangianBasicIntegrationModel_SetNonPlanarQuadSupport_37(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get Non Planar Quad Support
		/// </summary>
		// Token: 0x0600DC8A RID: 56458 RVA: 0x00132143 File Offset: 0x00130343
		public virtual void SetNonPlanarQuadSupport(bool _arg)
		{
			vtkLagrangianBasicIntegrationModel.vtkLagrangianBasicIntegrationModel_SetNonPlanarQuadSupport_37(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600DC8B RID: 56459
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangianBasicIntegrationModel_SetNumberOfTrackedUserData_38(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the number of tracked user data attached to the particles.
		/// Tracked user data are data that are related to each particle position
		/// but are not integrated like the user variables.
		/// They are not saved in the particle path.
		/// Default is 0.
		/// </summary>
		// Token: 0x0600DC8C RID: 56460 RVA: 0x0013215B File Offset: 0x0013035B
		public virtual void SetNumberOfTrackedUserData(int _arg)
		{
			vtkLagrangianBasicIntegrationModel.vtkLagrangianBasicIntegrationModel_SetNumberOfTrackedUserData_38(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DC8D RID: 56461
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangianBasicIntegrationModel_SetTracker_39(HandleRef pThis, HandleRef Tracker);

		/// <summary>
		/// Set the parent tracker.
		/// </summary>
		// Token: 0x0600DC8E RID: 56462 RVA: 0x0013216C File Offset: 0x0013036C
		public virtual void SetTracker(vtkLagrangianParticleTracker Tracker)
		{
			vtkLagrangianBasicIntegrationModel.vtkLagrangianBasicIntegrationModel_SetTracker_39(base.GetCppThis(), (Tracker == null) ? default(HandleRef) : Tracker.GetCppThis());
		}

		// Token: 0x0600DC8F RID: 56463
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangianBasicIntegrationModel_SetUseInitialIntegrationTime_40(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get the Use of initial integration input array to process
		/// </summary>
		// Token: 0x0600DC90 RID: 56464 RVA: 0x0013219B File Offset: 0x0013039B
		public virtual void SetUseInitialIntegrationTime(bool _arg)
		{
			vtkLagrangianBasicIntegrationModel.vtkLagrangianBasicIntegrationModel_SetUseInitialIntegrationTime_40(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600DC91 RID: 56465
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangianBasicIntegrationModel_UseInitialIntegrationTimeOff_41(HandleRef pThis);

		/// <summary>
		/// Set/Get the Use of initial integration input array to process
		/// </summary>
		// Token: 0x0600DC92 RID: 56466 RVA: 0x001321B3 File Offset: 0x001303B3
		public virtual void UseInitialIntegrationTimeOff()
		{
			vtkLagrangianBasicIntegrationModel.vtkLagrangianBasicIntegrationModel_UseInitialIntegrationTimeOff_41(base.GetCppThis());
		}

		// Token: 0x0600DC93 RID: 56467
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangianBasicIntegrationModel_UseInitialIntegrationTimeOn_42(HandleRef pThis);

		/// <summary>
		/// Set/Get the Use of initial integration input array to process
		/// </summary>
		// Token: 0x0600DC94 RID: 56468 RVA: 0x001321C2 File Offset: 0x001303C2
		public virtual void UseInitialIntegrationTimeOn()
		{
			vtkLagrangianBasicIntegrationModel.vtkLagrangianBasicIntegrationModel_UseInitialIntegrationTimeOn_42(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001013 RID: 4115
		public new const string MRFullTypeName = "Kitware.VTK.vtkLagrangianBasicIntegrationModel";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001014 RID: 4116
		public new static readonly string MRClassNameKey = "class vtkLagrangianBasicIntegrationModel";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x020004AF RID: 1199
		public enum SurfaceType
		{
			/// <summary>enum member</summary>
			// Token: 0x04001016 RID: 4118
			SURFACE_TYPE_BOUNCE = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001017 RID: 4119
			SURFACE_TYPE_BREAK,
			/// <summary>enum member</summary>
			// Token: 0x04001018 RID: 4120
			SURFACE_TYPE_MODEL = 0,
			/// <summary>enum member</summary>
			// Token: 0x04001019 RID: 4121
			SURFACE_TYPE_PASS = 4,
			/// <summary>enum member</summary>
			// Token: 0x0400101A RID: 4122
			SURFACE_TYPE_TERM = 1
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x020004B0 RID: 1200
		public enum VariableStep
		{
			/// <summary>enum member</summary>
			// Token: 0x0400101C RID: 4124
			VARIABLE_STEP_CURRENT,
			/// <summary>enum member</summary>
			// Token: 0x0400101D RID: 4125
			VARIABLE_STEP_NEXT,
			/// <summary>enum member</summary>
			// Token: 0x0400101E RID: 4126
			VARIABLE_STEP_PREV = -1
		}
	}
}
