using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVectorFieldTopology
	/// </summary>
	/// <remarks>
	///    Extract the topological skeleton as output datasets
	///
	/// vtkVectorFieldTopology is a filter that extracts the critical points and the 1D separatrices
	/// (lines) If the data is 3D and the user enables ComputeSurfaces, also the 2D separatrices are
	/// computed (surfaces)
	///
	/// @par Thanks:
	/// Developed by Roxana Bujack and Karen Tsai at Los Alamos National Laboratory under LDRD 20190143ER
	/// </remarks>
	// Token: 0x020004C9 RID: 1225
	public class vtkVectorFieldTopology : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600DF79 RID: 57209 RVA: 0x00136080 File Offset: 0x00134280
		static vtkVectorFieldTopology()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVectorFieldTopology.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVectorFieldTopology"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600DF7A RID: 57210 RVA: 0x001360A8 File Offset: 0x001342A8
		public vtkVectorFieldTopology(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600DF7B RID: 57211
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVectorFieldTopology_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DF7C RID: 57212 RVA: 0x001360B8 File Offset: 0x001342B8
		public new static vtkVectorFieldTopology New()
		{
			vtkVectorFieldTopology result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVectorFieldTopology.vtkVectorFieldTopology_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVectorFieldTopology)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DF7D RID: 57213 RVA: 0x0013610C File Offset: 0x0013430C
		public vtkVectorFieldTopology() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkVectorFieldTopology.vtkVectorFieldTopology_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600DF7E RID: 57214 RVA: 0x00136150 File Offset: 0x00134350
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600DF7F RID: 57215
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkVectorFieldTopology_GetComputeSurfaces_01(HandleRef pThis);

		/// <summary>
		/// Specify/see if the separating surfaces (separatrices in 3D) are computed or not
		/// </summary>
		// Token: 0x0600DF80 RID: 57216 RVA: 0x0013615C File Offset: 0x0013435C
		public virtual bool GetComputeSurfaces()
		{
			return vtkVectorFieldTopology.vtkVectorFieldTopology_GetComputeSurfaces_01(base.GetCppThis()) != 0;
		}

		// Token: 0x0600DF81 RID: 57217
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkVectorFieldTopology_GetEpsilonCriticalPoint_02(HandleRef pThis);

		/// <summary>
		/// Specify EpsilonCriticalPoint for classifying critical points. The default is 1e-10.
		/// </summary>
		// Token: 0x0600DF82 RID: 57218 RVA: 0x00136184 File Offset: 0x00134384
		public virtual double GetEpsilonCriticalPoint()
		{
			return vtkVectorFieldTopology.vtkVectorFieldTopology_GetEpsilonCriticalPoint_02(base.GetCppThis());
		}

		// Token: 0x0600DF83 RID: 57219
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkVectorFieldTopology_GetExcludeBoundary_03(HandleRef pThis);

		/// <summary>
		/// Specify/see if the boundary cells are treated or not
		/// </summary>
		// Token: 0x0600DF84 RID: 57220 RVA: 0x001361A4 File Offset: 0x001343A4
		public virtual bool GetExcludeBoundary()
		{
			return vtkVectorFieldTopology.vtkVectorFieldTopology_GetExcludeBoundary_03(base.GetCppThis()) != 0;
		}

		// Token: 0x0600DF85 RID: 57221
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkVectorFieldTopology_GetIntegrationStepSize_04(HandleRef pThis);

		/// <summary>
		/// Specify the Initial, minimum, and maximum step size used for line integration,
		/// expressed in IntegrationStepUnit
		/// </summary>
		// Token: 0x0600DF86 RID: 57222 RVA: 0x001361CC File Offset: 0x001343CC
		public virtual double GetIntegrationStepSize()
		{
			return vtkVectorFieldTopology.vtkVectorFieldTopology_GetIntegrationStepSize_04(base.GetCppThis());
		}

		// Token: 0x0600DF87 RID: 57223
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVectorFieldTopology_GetIntegrationStepUnit_05(HandleRef pThis);

		/// <summary>
		/// Specify a uniform integration step unit for MinimumIntegrationStep,
		/// InitialIntegrationStep, and MaximumIntegrationStep.
		/// 1 = LENGTH_UNIT, i.e. all sizes are expressed in coordinate scale or cell scale
		/// 2 = CELL_LENGTH_UNIT, i.e. all sizes are expressed in cell scale
		/// </summary>
		// Token: 0x0600DF88 RID: 57224 RVA: 0x001361EC File Offset: 0x001343EC
		public virtual int GetIntegrationStepUnit()
		{
			return vtkVectorFieldTopology.vtkVectorFieldTopology_GetIntegrationStepUnit_05(base.GetCppThis());
		}

		// Token: 0x0600DF89 RID: 57225
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVectorFieldTopology_GetMaxNumSteps_06(HandleRef pThis);

		/// <summary>
		/// Specify/see the maximal number of iterations in this class and in vtkStreamTracer
		/// </summary>
		// Token: 0x0600DF8A RID: 57226 RVA: 0x0013620C File Offset: 0x0013440C
		public virtual int GetMaxNumSteps()
		{
			return vtkVectorFieldTopology.vtkVectorFieldTopology_GetMaxNumSteps_06(base.GetCppThis());
		}

		// Token: 0x0600DF8B RID: 57227
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVectorFieldTopology_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DF8C RID: 57228 RVA: 0x0013622C File Offset: 0x0013442C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVectorFieldTopology.vtkVectorFieldTopology_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0600DF8D RID: 57229
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVectorFieldTopology_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DF8E RID: 57230 RVA: 0x0013624C File Offset: 0x0013444C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVectorFieldTopology.vtkVectorFieldTopology_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x0600DF8F RID: 57231
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkVectorFieldTopology_GetOffsetAwayFromBoundary_09(HandleRef pThis);

		/// <summary>
		/// Specify the OffsetAwayFromBoundary to shift seeds for computing separating lines/surfaces
		/// </summary>
		// Token: 0x0600DF90 RID: 57232 RVA: 0x00136268 File Offset: 0x00134468
		public virtual double GetOffsetAwayFromBoundary()
		{
			return vtkVectorFieldTopology.vtkVectorFieldTopology_GetOffsetAwayFromBoundary_09(base.GetCppThis());
		}

		// Token: 0x0600DF91 RID: 57233
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkVectorFieldTopology_GetSeparatrixDistance_10(HandleRef pThis);

		/// <summary>
		/// Specify/see the distance by which the seedpoints of the separatrices are placed away from the
		/// saddle expressed in IntegrationStepUnit
		/// </summary>
		// Token: 0x0600DF92 RID: 57234 RVA: 0x00136288 File Offset: 0x00134488
		public virtual double GetSeparatrixDistance()
		{
			return vtkVectorFieldTopology.vtkVectorFieldTopology_GetSeparatrixDistance_10(base.GetCppThis());
		}

		// Token: 0x0600DF93 RID: 57235
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkVectorFieldTopology_GetUseBoundarySwitchPoints_11(HandleRef pThis);

		/// <summary>
		/// Specify/see whether to use boundary switch points/lines points as seeds or not
		/// </summary>
		// Token: 0x0600DF94 RID: 57236 RVA: 0x001362A8 File Offset: 0x001344A8
		public virtual bool GetUseBoundarySwitchPoints()
		{
			return vtkVectorFieldTopology.vtkVectorFieldTopology_GetUseBoundarySwitchPoints_11(base.GetCppThis()) != 0;
		}

		// Token: 0x0600DF95 RID: 57237
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkVectorFieldTopology_GetUseIterativeSeeding_12(HandleRef pThis);

		/// <summary>
		/// Specify/see if the simple (fast) or iterative (correct) version is called
		/// </summary>
		// Token: 0x0600DF96 RID: 57238 RVA: 0x001362D0 File Offset: 0x001344D0
		public virtual bool GetUseIterativeSeeding()
		{
			return vtkVectorFieldTopology.vtkVectorFieldTopology_GetUseIterativeSeeding_12(base.GetCppThis()) != 0;
		}

		// Token: 0x0600DF97 RID: 57239
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkVectorFieldTopology_GetVectorAngleThreshold_13(HandleRef pThis);

		/// <summary>
		/// Specify the VectorAngleThreshold to remove noisy boundary switch points/lines
		/// When computing boundary switch point, if the vectors of the two points within a cell are almost
		/// parallel, the boundary switch point computed is considered as a noise point. Let v0 and v1 be
		/// the vectors of the two points, and their norm equal to 1. The dot product between them
		/// Dot(v0,v1) = cos(theta), where theta is the angle between v0 and v1. When v0 and v1 are almost
		/// parallel, abs(Dot(v0,v1)) is close to 1. The range of this threshold is [0,1]. For any
		/// abs(Dot(v0,v1)) &gt; VectorAngleThreshold, the boundary switch point computed is a noise point.
		/// </summary>
		// Token: 0x0600DF98 RID: 57240 RVA: 0x001362F8 File Offset: 0x001344F8
		public virtual double GetVectorAngleThreshold()
		{
			return vtkVectorFieldTopology.vtkVectorFieldTopology_GetVectorAngleThreshold_13(base.GetCppThis());
		}

		// Token: 0x0600DF99 RID: 57241
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVectorFieldTopology_IsA_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DF9A RID: 57242 RVA: 0x00136318 File Offset: 0x00134518
		public override int IsA(string type)
		{
			return vtkVectorFieldTopology.vtkVectorFieldTopology_IsA_14(base.GetCppThis(), type);
		}

		// Token: 0x0600DF9B RID: 57243
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVectorFieldTopology_IsTypeOf_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DF9C RID: 57244 RVA: 0x00136338 File Offset: 0x00134538
		public new static int IsTypeOf(string type)
		{
			return vtkVectorFieldTopology.vtkVectorFieldTopology_IsTypeOf_15(type);
		}

		// Token: 0x0600DF9D RID: 57245
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVectorFieldTopology_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DF9E RID: 57246 RVA: 0x00136354 File Offset: 0x00134554
		public new vtkVectorFieldTopology NewInstance()
		{
			vtkVectorFieldTopology result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVectorFieldTopology.vtkVectorFieldTopology_NewInstance_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVectorFieldTopology)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600DF9F RID: 57247
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVectorFieldTopology_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DFA0 RID: 57248 RVA: 0x001363B0 File Offset: 0x001345B0
		public new static vtkVectorFieldTopology SafeDownCast(vtkObjectBase o)
		{
			vtkVectorFieldTopology vtkVectorFieldTopology = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVectorFieldTopology.vtkVectorFieldTopology_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVectorFieldTopology = (vtkVectorFieldTopology)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVectorFieldTopology.Register(null);
				}
			}
			return vtkVectorFieldTopology;
		}

		// Token: 0x0600DFA1 RID: 57249
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVectorFieldTopology_SetComputeSurfaces_19(HandleRef pThis, byte _arg);

		/// <summary>
		/// Specify/see if the separating surfaces (separatrices in 3D) are computed or not
		/// </summary>
		// Token: 0x0600DFA2 RID: 57250 RVA: 0x0013642F File Offset: 0x0013462F
		public virtual void SetComputeSurfaces(bool _arg)
		{
			vtkVectorFieldTopology.vtkVectorFieldTopology_SetComputeSurfaces_19(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600DFA3 RID: 57251
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVectorFieldTopology_SetEpsilonCriticalPoint_20(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify EpsilonCriticalPoint for classifying critical points. The default is 1e-10.
		/// </summary>
		// Token: 0x0600DFA4 RID: 57252 RVA: 0x00136447 File Offset: 0x00134647
		public virtual void SetEpsilonCriticalPoint(double _arg)
		{
			vtkVectorFieldTopology.vtkVectorFieldTopology_SetEpsilonCriticalPoint_20(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DFA5 RID: 57253
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVectorFieldTopology_SetExcludeBoundary_21(HandleRef pThis, byte _arg);

		/// <summary>
		/// Specify/see if the boundary cells are treated or not
		/// </summary>
		// Token: 0x0600DFA6 RID: 57254 RVA: 0x00136457 File Offset: 0x00134657
		public virtual void SetExcludeBoundary(bool _arg)
		{
			vtkVectorFieldTopology.vtkVectorFieldTopology_SetExcludeBoundary_21(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600DFA7 RID: 57255
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVectorFieldTopology_SetIntegrationStepSize_22(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the Initial, minimum, and maximum step size used for line integration,
		/// expressed in IntegrationStepUnit
		/// </summary>
		// Token: 0x0600DFA8 RID: 57256 RVA: 0x0013646F File Offset: 0x0013466F
		public virtual void SetIntegrationStepSize(double _arg)
		{
			vtkVectorFieldTopology.vtkVectorFieldTopology_SetIntegrationStepSize_22(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DFA9 RID: 57257
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVectorFieldTopology_SetIntegrationStepUnit_23(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify a uniform integration step unit for MinimumIntegrationStep,
		/// InitialIntegrationStep, and MaximumIntegrationStep.
		/// 1 = LENGTH_UNIT, i.e. all sizes are expressed in coordinate scale or cell scale
		/// 2 = CELL_LENGTH_UNIT, i.e. all sizes are expressed in cell scale
		/// </summary>
		// Token: 0x0600DFAA RID: 57258 RVA: 0x0013647F File Offset: 0x0013467F
		public virtual void SetIntegrationStepUnit(int _arg)
		{
			vtkVectorFieldTopology.vtkVectorFieldTopology_SetIntegrationStepUnit_23(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DFAB RID: 57259
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVectorFieldTopology_SetInterpolatorType_24(HandleRef pThis, int interpType);

		/// <summary>
		/// Set the type of the velocity field interpolator to determine whether
		/// INTERPOLATOR_WITH_DATASET_POINT_LOCATOR or INTERPOLATOR_WITH_CELL_LOCATOR is employed for
		/// locating cells during streamline integration.
		/// </summary>
		// Token: 0x0600DFAC RID: 57260 RVA: 0x0013648F File Offset: 0x0013468F
		public void SetInterpolatorType(int interpType)
		{
			vtkVectorFieldTopology.vtkVectorFieldTopology_SetInterpolatorType_24(base.GetCppThis(), interpType);
		}

		// Token: 0x0600DFAD RID: 57261
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVectorFieldTopology_SetInterpolatorTypeToCellLocator_25(HandleRef pThis);

		/// <summary>
		/// Set the velocity field interpolator type to the one involving a cell locator.
		/// </summary>
		// Token: 0x0600DFAE RID: 57262 RVA: 0x0013649F File Offset: 0x0013469F
		public void SetInterpolatorTypeToCellLocator()
		{
			vtkVectorFieldTopology.vtkVectorFieldTopology_SetInterpolatorTypeToCellLocator_25(base.GetCppThis());
		}

		// Token: 0x0600DFAF RID: 57263
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVectorFieldTopology_SetInterpolatorTypeToDataSetPointLocator_26(HandleRef pThis);

		/// <summary>
		/// Set the velocity field interpolator type to the one involving a dataset point locator.
		/// </summary>
		// Token: 0x0600DFB0 RID: 57264 RVA: 0x001364AE File Offset: 0x001346AE
		public void SetInterpolatorTypeToDataSetPointLocator()
		{
			vtkVectorFieldTopology.vtkVectorFieldTopology_SetInterpolatorTypeToDataSetPointLocator_26(base.GetCppThis());
		}

		// Token: 0x0600DFB1 RID: 57265
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVectorFieldTopology_SetMaxNumSteps_27(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify/see the maximal number of iterations in this class and in vtkStreamTracer
		/// </summary>
		// Token: 0x0600DFB2 RID: 57266 RVA: 0x001364BD File Offset: 0x001346BD
		public virtual void SetMaxNumSteps(int _arg)
		{
			vtkVectorFieldTopology.vtkVectorFieldTopology_SetMaxNumSteps_27(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DFB3 RID: 57267
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVectorFieldTopology_SetOffsetAwayFromBoundary_28(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the OffsetAwayFromBoundary to shift seeds for computing separating lines/surfaces
		/// </summary>
		// Token: 0x0600DFB4 RID: 57268 RVA: 0x001364CD File Offset: 0x001346CD
		public virtual void SetOffsetAwayFromBoundary(double _arg)
		{
			vtkVectorFieldTopology.vtkVectorFieldTopology_SetOffsetAwayFromBoundary_28(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DFB5 RID: 57269
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVectorFieldTopology_SetSeparatrixDistance_29(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify/see the distance by which the seedpoints of the separatrices are placed away from the
		/// saddle expressed in IntegrationStepUnit
		/// </summary>
		// Token: 0x0600DFB6 RID: 57270 RVA: 0x001364DD File Offset: 0x001346DD
		public virtual void SetSeparatrixDistance(double _arg)
		{
			vtkVectorFieldTopology.vtkVectorFieldTopology_SetSeparatrixDistance_29(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DFB7 RID: 57271
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVectorFieldTopology_SetUseBoundarySwitchPoints_30(HandleRef pThis, byte _arg);

		/// <summary>
		/// Specify/see whether to use boundary switch points/lines points as seeds or not
		/// </summary>
		// Token: 0x0600DFB8 RID: 57272 RVA: 0x001364ED File Offset: 0x001346ED
		public virtual void SetUseBoundarySwitchPoints(bool _arg)
		{
			vtkVectorFieldTopology.vtkVectorFieldTopology_SetUseBoundarySwitchPoints_30(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600DFB9 RID: 57273
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVectorFieldTopology_SetUseIterativeSeeding_31(HandleRef pThis, byte _arg);

		/// <summary>
		/// Specify/see if the simple (fast) or iterative (correct) version is called
		/// </summary>
		// Token: 0x0600DFBA RID: 57274 RVA: 0x00136505 File Offset: 0x00134705
		public virtual void SetUseIterativeSeeding(bool _arg)
		{
			vtkVectorFieldTopology.vtkVectorFieldTopology_SetUseIterativeSeeding_31(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600DFBB RID: 57275
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVectorFieldTopology_SetVectorAngleThreshold_32(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the VectorAngleThreshold to remove noisy boundary switch points/lines
		/// When computing boundary switch point, if the vectors of the two points within a cell are almost
		/// parallel, the boundary switch point computed is considered as a noise point. Let v0 and v1 be
		/// the vectors of the two points, and their norm equal to 1. The dot product between them
		/// Dot(v0,v1) = cos(theta), where theta is the angle between v0 and v1. When v0 and v1 are almost
		/// parallel, abs(Dot(v0,v1)) is close to 1. The range of this threshold is [0,1]. For any
		/// abs(Dot(v0,v1)) &gt; VectorAngleThreshold, the boundary switch point computed is a noise point.
		/// </summary>
		// Token: 0x0600DFBC RID: 57276 RVA: 0x0013651D File Offset: 0x0013471D
		public virtual void SetVectorAngleThreshold(double _arg)
		{
			vtkVectorFieldTopology.vtkVectorFieldTopology_SetVectorAngleThreshold_32(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400106D RID: 4205
		public new const string MRFullTypeName = "Kitware.VTK.vtkVectorFieldTopology";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400106E RID: 4206
		public new static readonly string MRClassNameKey = "class vtkVectorFieldTopology";
	}
}
