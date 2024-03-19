using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTemporalFractal
	/// </summary>
	/// <remarks>
	///    A source to test AMR data object.
	///
	/// vtkTemporalFractal is a collection of uniform grids.  All have the same
	/// dimensions. Each block has a different origin and spacing.  It uses
	/// mandelbrot to create cell data. The fractal array is scaled to look like a
	/// volume fraction.
	///
	/// I may also add block id and level as extra cell arrays.
	/// This source produces a vtkHierarchicalBoxDataSet when
	/// GenerateRectilinearGrids is off, otherwise produces a vtkMultiBlockDataSet.
	/// </remarks>
	// Token: 0x0200061A RID: 1562
	public class vtkTemporalFractal : vtkAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06010F3C RID: 69436 RVA: 0x00179F73 File Offset: 0x00178173
		static vtkTemporalFractal()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTemporalFractal.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTemporalFractal"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06010F3D RID: 69437 RVA: 0x00179F9B File Offset: 0x0017819B
		public vtkTemporalFractal(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06010F3E RID: 69438
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTemporalFractal_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06010F3F RID: 69439 RVA: 0x00179FAC File Offset: 0x001781AC
		public new static vtkTemporalFractal New()
		{
			vtkTemporalFractal result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTemporalFractal.vtkTemporalFractal_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTemporalFractal)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06010F40 RID: 69440 RVA: 0x0017A000 File Offset: 0x00178200
		public vtkTemporalFractal() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTemporalFractal.vtkTemporalFractal_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010F41 RID: 69441 RVA: 0x0017A044 File Offset: 0x00178244
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06010F42 RID: 69442
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalFractal_AdaptiveSubdivisionOff_01(HandleRef pThis);

		/// <summary>
		/// Make the division adaptive or not, defaults to Adaptive
		/// </summary>
		// Token: 0x06010F43 RID: 69443 RVA: 0x0017A04F File Offset: 0x0017824F
		public virtual void AdaptiveSubdivisionOff()
		{
			vtkTemporalFractal.vtkTemporalFractal_AdaptiveSubdivisionOff_01(base.GetCppThis());
		}

		// Token: 0x06010F44 RID: 69444
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalFractal_AdaptiveSubdivisionOn_02(HandleRef pThis);

		/// <summary>
		/// Make the division adaptive or not, defaults to Adaptive
		/// </summary>
		// Token: 0x06010F45 RID: 69445 RVA: 0x0017A05E File Offset: 0x0017825E
		public virtual void AdaptiveSubdivisionOn()
		{
			vtkTemporalFractal.vtkTemporalFractal_AdaptiveSubdivisionOn_02(base.GetCppThis());
		}

		// Token: 0x06010F46 RID: 69446
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalFractal_DiscreteTimeStepsOff_03(HandleRef pThis);

		/// <summary>
		/// Limit this source to discrete integer time steps
		/// Default is off (continuous)
		/// </summary>
		// Token: 0x06010F47 RID: 69447 RVA: 0x0017A06D File Offset: 0x0017826D
		public virtual void DiscreteTimeStepsOff()
		{
			vtkTemporalFractal.vtkTemporalFractal_DiscreteTimeStepsOff_03(base.GetCppThis());
		}

		// Token: 0x06010F48 RID: 69448
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalFractal_DiscreteTimeStepsOn_04(HandleRef pThis);

		/// <summary>
		/// Limit this source to discrete integer time steps
		/// Default is off (continuous)
		/// </summary>
		// Token: 0x06010F49 RID: 69449 RVA: 0x0017A07C File Offset: 0x0017827C
		public virtual void DiscreteTimeStepsOn()
		{
			vtkTemporalFractal.vtkTemporalFractal_DiscreteTimeStepsOn_04(base.GetCppThis());
		}

		// Token: 0x06010F4A RID: 69450
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalFractal_GenerateRectilinearGridsOff_05(HandleRef pThis);

		/// <summary>
		/// Generate either rectilinear grids either uniform grids.
		/// Default is false.
		/// </summary>
		// Token: 0x06010F4B RID: 69451 RVA: 0x0017A08B File Offset: 0x0017828B
		public virtual void GenerateRectilinearGridsOff()
		{
			vtkTemporalFractal.vtkTemporalFractal_GenerateRectilinearGridsOff_05(base.GetCppThis());
		}

		// Token: 0x06010F4C RID: 69452
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalFractal_GenerateRectilinearGridsOn_06(HandleRef pThis);

		/// <summary>
		/// Generate either rectilinear grids either uniform grids.
		/// Default is false.
		/// </summary>
		// Token: 0x06010F4D RID: 69453 RVA: 0x0017A09A File Offset: 0x0017829A
		public virtual void GenerateRectilinearGridsOn()
		{
			vtkTemporalFractal.vtkTemporalFractal_GenerateRectilinearGridsOn_06(base.GetCppThis());
		}

		// Token: 0x06010F4E RID: 69454
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTemporalFractal_GetAdaptiveSubdivision_07(HandleRef pThis);

		/// <summary>
		/// Make the division adaptive or not, defaults to Adaptive
		/// </summary>
		// Token: 0x06010F4F RID: 69455 RVA: 0x0017A0AC File Offset: 0x001782AC
		public virtual int GetAdaptiveSubdivision()
		{
			return vtkTemporalFractal.vtkTemporalFractal_GetAdaptiveSubdivision_07(base.GetCppThis());
		}

		// Token: 0x06010F50 RID: 69456
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTemporalFractal_GetAsymmetric_08(HandleRef pThis);

		/// <summary>
		/// Test the case when the blocks do not have the same sizes.
		/// Adds 2 to the x extent of the far x blocks (level 1).
		/// </summary>
		// Token: 0x06010F51 RID: 69457 RVA: 0x0017A0CC File Offset: 0x001782CC
		public virtual int GetAsymmetric()
		{
			return vtkTemporalFractal.vtkTemporalFractal_GetAsymmetric_08(base.GetCppThis());
		}

		// Token: 0x06010F52 RID: 69458
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTemporalFractal_GetDimensions_09(HandleRef pThis);

		/// <summary>
		/// XYZ dimensions of cells.
		/// </summary>
		// Token: 0x06010F53 RID: 69459 RVA: 0x0017A0EC File Offset: 0x001782EC
		public virtual int GetDimensions()
		{
			return vtkTemporalFractal.vtkTemporalFractal_GetDimensions_09(base.GetCppThis());
		}

		// Token: 0x06010F54 RID: 69460
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTemporalFractal_GetDiscreteTimeSteps_10(HandleRef pThis);

		/// <summary>
		/// Limit this source to discrete integer time steps
		/// Default is off (continuous)
		/// </summary>
		// Token: 0x06010F55 RID: 69461 RVA: 0x0017A10C File Offset: 0x0017830C
		public virtual int GetDiscreteTimeSteps()
		{
			return vtkTemporalFractal.vtkTemporalFractal_GetDiscreteTimeSteps_10(base.GetCppThis());
		}

		// Token: 0x06010F56 RID: 69462
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkTemporalFractal_GetFractalValue_11(HandleRef pThis);

		/// <summary>
		/// Essentially the iso surface value.  The fractal array is scaled to map
		/// this value to 0.5 for use as a volume fraction.
		/// </summary>
		// Token: 0x06010F57 RID: 69463 RVA: 0x0017A12C File Offset: 0x0017832C
		public virtual float GetFractalValue()
		{
			return vtkTemporalFractal.vtkTemporalFractal_GetFractalValue_11(base.GetCppThis());
		}

		// Token: 0x06010F58 RID: 69464
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTemporalFractal_GetGenerateRectilinearGrids_12(HandleRef pThis);

		/// <summary>
		/// Generate either rectilinear grids either uniform grids.
		/// Default is false.
		/// </summary>
		// Token: 0x06010F59 RID: 69465 RVA: 0x0017A14C File Offset: 0x0017834C
		public virtual int GetGenerateRectilinearGrids()
		{
			return vtkTemporalFractal.vtkTemporalFractal_GetGenerateRectilinearGrids_12(base.GetCppThis());
		}

		// Token: 0x06010F5A RID: 69466
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTemporalFractal_GetGhostLevels_13(HandleRef pThis);

		/// <summary>
		/// For testing ghost levels.
		/// </summary>
		// Token: 0x06010F5B RID: 69467 RVA: 0x0017A16C File Offset: 0x0017836C
		public virtual int GetGhostLevels()
		{
			return vtkTemporalFractal.vtkTemporalFractal_GetGhostLevels_13(base.GetCppThis());
		}

		// Token: 0x06010F5C RID: 69468
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTemporalFractal_GetMaximumLevel_14(HandleRef pThis);

		/// <summary>
		/// Any blocks touching a predefined line will be subdivided to this level.
		/// Other blocks are subdivided so that neighboring blocks only differ
		/// by one level.
		/// </summary>
		// Token: 0x06010F5D RID: 69469 RVA: 0x0017A18C File Offset: 0x0017838C
		public virtual int GetMaximumLevel()
		{
			return vtkTemporalFractal.vtkTemporalFractal_GetMaximumLevel_14(base.GetCppThis());
		}

		// Token: 0x06010F5E RID: 69470
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTemporalFractal_GetNumberOfGenerationsFromBase_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06010F5F RID: 69471 RVA: 0x0017A1AC File Offset: 0x001783AC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTemporalFractal.vtkTemporalFractal_GetNumberOfGenerationsFromBase_15(base.GetCppThis(), type);
		}

		// Token: 0x06010F60 RID: 69472
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTemporalFractal_GetNumberOfGenerationsFromBaseType_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06010F61 RID: 69473 RVA: 0x0017A1CC File Offset: 0x001783CC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTemporalFractal.vtkTemporalFractal_GetNumberOfGenerationsFromBaseType_16(type);
		}

		// Token: 0x06010F62 RID: 69474
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTemporalFractal_GetTwoDimensional_17(HandleRef pThis);

		/// <summary>
		/// Make a 2D data set to test.
		/// </summary>
		// Token: 0x06010F63 RID: 69475 RVA: 0x0017A1E8 File Offset: 0x001783E8
		public virtual int GetTwoDimensional()
		{
			return vtkTemporalFractal.vtkTemporalFractal_GetTwoDimensional_17(base.GetCppThis());
		}

		// Token: 0x06010F64 RID: 69476
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalFractal_GhostLevelsOff_18(HandleRef pThis);

		/// <summary>
		/// For testing ghost levels.
		/// </summary>
		// Token: 0x06010F65 RID: 69477 RVA: 0x0017A207 File Offset: 0x00178407
		public virtual void GhostLevelsOff()
		{
			vtkTemporalFractal.vtkTemporalFractal_GhostLevelsOff_18(base.GetCppThis());
		}

		// Token: 0x06010F66 RID: 69478
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalFractal_GhostLevelsOn_19(HandleRef pThis);

		/// <summary>
		/// For testing ghost levels.
		/// </summary>
		// Token: 0x06010F67 RID: 69479 RVA: 0x0017A216 File Offset: 0x00178416
		public virtual void GhostLevelsOn()
		{
			vtkTemporalFractal.vtkTemporalFractal_GhostLevelsOn_19(base.GetCppThis());
		}

		// Token: 0x06010F68 RID: 69480
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTemporalFractal_IsA_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06010F69 RID: 69481 RVA: 0x0017A228 File Offset: 0x00178428
		public override int IsA(string type)
		{
			return vtkTemporalFractal.vtkTemporalFractal_IsA_20(base.GetCppThis(), type);
		}

		// Token: 0x06010F6A RID: 69482
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTemporalFractal_IsTypeOf_21([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06010F6B RID: 69483 RVA: 0x0017A248 File Offset: 0x00178448
		public new static int IsTypeOf(string type)
		{
			return vtkTemporalFractal.vtkTemporalFractal_IsTypeOf_21(type);
		}

		// Token: 0x06010F6C RID: 69484
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTemporalFractal_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06010F6D RID: 69485 RVA: 0x0017A264 File Offset: 0x00178464
		public new vtkTemporalFractal NewInstance()
		{
			vtkTemporalFractal result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTemporalFractal.vtkTemporalFractal_NewInstance_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTemporalFractal)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010F6E RID: 69486
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTemporalFractal_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06010F6F RID: 69487 RVA: 0x0017A2C0 File Offset: 0x001784C0
		public new static vtkTemporalFractal SafeDownCast(vtkObjectBase o)
		{
			vtkTemporalFractal vtkTemporalFractal = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTemporalFractal.vtkTemporalFractal_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTemporalFractal = (vtkTemporalFractal)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTemporalFractal.Register(null);
				}
			}
			return vtkTemporalFractal;
		}

		// Token: 0x06010F70 RID: 69488
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalFractal_SetAdaptiveSubdivision_25(HandleRef pThis, int _arg);

		/// <summary>
		/// Make the division adaptive or not, defaults to Adaptive
		/// </summary>
		// Token: 0x06010F71 RID: 69489 RVA: 0x0017A33F File Offset: 0x0017853F
		public virtual void SetAdaptiveSubdivision(int _arg)
		{
			vtkTemporalFractal.vtkTemporalFractal_SetAdaptiveSubdivision_25(base.GetCppThis(), _arg);
		}

		// Token: 0x06010F72 RID: 69490
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalFractal_SetAsymmetric_26(HandleRef pThis, int _arg);

		/// <summary>
		/// Test the case when the blocks do not have the same sizes.
		/// Adds 2 to the x extent of the far x blocks (level 1).
		/// </summary>
		// Token: 0x06010F73 RID: 69491 RVA: 0x0017A34F File Offset: 0x0017854F
		public virtual void SetAsymmetric(int _arg)
		{
			vtkTemporalFractal.vtkTemporalFractal_SetAsymmetric_26(base.GetCppThis(), _arg);
		}

		// Token: 0x06010F74 RID: 69492
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalFractal_SetDimensions_27(HandleRef pThis, int _arg);

		/// <summary>
		/// XYZ dimensions of cells.
		/// </summary>
		// Token: 0x06010F75 RID: 69493 RVA: 0x0017A35F File Offset: 0x0017855F
		public virtual void SetDimensions(int _arg)
		{
			vtkTemporalFractal.vtkTemporalFractal_SetDimensions_27(base.GetCppThis(), _arg);
		}

		// Token: 0x06010F76 RID: 69494
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalFractal_SetDiscreteTimeSteps_28(HandleRef pThis, int _arg);

		/// <summary>
		/// Limit this source to discrete integer time steps
		/// Default is off (continuous)
		/// </summary>
		// Token: 0x06010F77 RID: 69495 RVA: 0x0017A36F File Offset: 0x0017856F
		public virtual void SetDiscreteTimeSteps(int _arg)
		{
			vtkTemporalFractal.vtkTemporalFractal_SetDiscreteTimeSteps_28(base.GetCppThis(), _arg);
		}

		// Token: 0x06010F78 RID: 69496
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalFractal_SetFractalValue_29(HandleRef pThis, float _arg);

		/// <summary>
		/// Essentially the iso surface value.  The fractal array is scaled to map
		/// this value to 0.5 for use as a volume fraction.
		/// </summary>
		// Token: 0x06010F79 RID: 69497 RVA: 0x0017A37F File Offset: 0x0017857F
		public virtual void SetFractalValue(float _arg)
		{
			vtkTemporalFractal.vtkTemporalFractal_SetFractalValue_29(base.GetCppThis(), _arg);
		}

		// Token: 0x06010F7A RID: 69498
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalFractal_SetGenerateRectilinearGrids_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Generate either rectilinear grids either uniform grids.
		/// Default is false.
		/// </summary>
		// Token: 0x06010F7B RID: 69499 RVA: 0x0017A38F File Offset: 0x0017858F
		public virtual void SetGenerateRectilinearGrids(int _arg)
		{
			vtkTemporalFractal.vtkTemporalFractal_SetGenerateRectilinearGrids_30(base.GetCppThis(), _arg);
		}

		// Token: 0x06010F7C RID: 69500
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalFractal_SetGhostLevels_31(HandleRef pThis, int _arg);

		/// <summary>
		/// For testing ghost levels.
		/// </summary>
		// Token: 0x06010F7D RID: 69501 RVA: 0x0017A39F File Offset: 0x0017859F
		public virtual void SetGhostLevels(int _arg)
		{
			vtkTemporalFractal.vtkTemporalFractal_SetGhostLevels_31(base.GetCppThis(), _arg);
		}

		// Token: 0x06010F7E RID: 69502
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalFractal_SetMaximumLevel_32(HandleRef pThis, int _arg);

		/// <summary>
		/// Any blocks touching a predefined line will be subdivided to this level.
		/// Other blocks are subdivided so that neighboring blocks only differ
		/// by one level.
		/// </summary>
		// Token: 0x06010F7F RID: 69503 RVA: 0x0017A3AF File Offset: 0x001785AF
		public virtual void SetMaximumLevel(int _arg)
		{
			vtkTemporalFractal.vtkTemporalFractal_SetMaximumLevel_32(base.GetCppThis(), _arg);
		}

		// Token: 0x06010F80 RID: 69504
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalFractal_SetTwoDimensional_33(HandleRef pThis, int _arg);

		/// <summary>
		/// Make a 2D data set to test.
		/// </summary>
		// Token: 0x06010F81 RID: 69505 RVA: 0x0017A3BF File Offset: 0x001785BF
		public virtual void SetTwoDimensional(int _arg)
		{
			vtkTemporalFractal.vtkTemporalFractal_SetTwoDimensional_33(base.GetCppThis(), _arg);
		}

		// Token: 0x06010F82 RID: 69506
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalFractal_TwoDimensionalOff_34(HandleRef pThis);

		/// <summary>
		/// Make a 2D data set to test.
		/// </summary>
		// Token: 0x06010F83 RID: 69507 RVA: 0x0017A3CF File Offset: 0x001785CF
		public virtual void TwoDimensionalOff()
		{
			vtkTemporalFractal.vtkTemporalFractal_TwoDimensionalOff_34(base.GetCppThis());
		}

		// Token: 0x06010F84 RID: 69508
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalFractal_TwoDimensionalOn_35(HandleRef pThis);

		/// <summary>
		/// Make a 2D data set to test.
		/// </summary>
		// Token: 0x06010F85 RID: 69509 RVA: 0x0017A3DE File Offset: 0x001785DE
		public virtual void TwoDimensionalOn()
		{
			vtkTemporalFractal.vtkTemporalFractal_TwoDimensionalOn_35(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001396 RID: 5014
		public new const string MRFullTypeName = "Kitware.VTK.vtkTemporalFractal";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001397 RID: 5015
		public new static readonly string MRClassNameKey = "class vtkTemporalFractal";
	}
}
