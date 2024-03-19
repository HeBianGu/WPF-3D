using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkForceDirectedLayoutStrategy
	/// </summary>
	/// <remarks>
	///    a force directed graph layout algorithm
	///
	///
	/// Lays out a graph in 2D or 3D using a force-directed algorithm.
	/// The user may specify whether to layout the graph randomly initially,
	/// the bounds, the number of dimensions (2 or 3), and the cool-down rate.
	///
	/// @par Thanks:
	/// Thanks to Brian Wylie for adding functionality for allowing this layout
	/// to be incremental.
	/// </remarks>
	// Token: 0x0200028E RID: 654
	public class vtkForceDirectedLayoutStrategy : vtkGraphLayoutStrategy
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06007656 RID: 30294 RVA: 0x000AAD7F File Offset: 0x000A8F7F
		static vtkForceDirectedLayoutStrategy()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkForceDirectedLayoutStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkForceDirectedLayoutStrategy"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06007657 RID: 30295 RVA: 0x000AADA7 File Offset: 0x000A8FA7
		public vtkForceDirectedLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06007658 RID: 30296
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkForceDirectedLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007659 RID: 30297 RVA: 0x000AADB8 File Offset: 0x000A8FB8
		public new static vtkForceDirectedLayoutStrategy New()
		{
			vtkForceDirectedLayoutStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkForceDirectedLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600765A RID: 30298 RVA: 0x000AAE0C File Offset: 0x000A900C
		public vtkForceDirectedLayoutStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600765B RID: 30299 RVA: 0x000AAE50 File Offset: 0x000A9050
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600765C RID: 30300
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkForceDirectedLayoutStrategy_AutomaticBoundsComputationOff_01(HandleRef pThis);

		/// <summary>
		/// Turn on/off automatic graph bounds calculation. If this
		/// boolean is off, then the manually specified GraphBounds is used.
		/// If on, then the input's bounds us used as the graph bounds.
		/// </summary>
		// Token: 0x0600765D RID: 30301 RVA: 0x000AAE5B File Offset: 0x000A905B
		public virtual void AutomaticBoundsComputationOff()
		{
			vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_AutomaticBoundsComputationOff_01(base.GetCppThis());
		}

		// Token: 0x0600765E RID: 30302
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkForceDirectedLayoutStrategy_AutomaticBoundsComputationOn_02(HandleRef pThis);

		/// <summary>
		/// Turn on/off automatic graph bounds calculation. If this
		/// boolean is off, then the manually specified GraphBounds is used.
		/// If on, then the input's bounds us used as the graph bounds.
		/// </summary>
		// Token: 0x0600765F RID: 30303 RVA: 0x000AAE6A File Offset: 0x000A906A
		public virtual void AutomaticBoundsComputationOn()
		{
			vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_AutomaticBoundsComputationOn_02(base.GetCppThis());
		}

		// Token: 0x06007660 RID: 30304
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkForceDirectedLayoutStrategy_GetAutomaticBoundsComputation_03(HandleRef pThis);

		/// <summary>
		/// Turn on/off automatic graph bounds calculation. If this
		/// boolean is off, then the manually specified GraphBounds is used.
		/// If on, then the input's bounds us used as the graph bounds.
		/// </summary>
		// Token: 0x06007661 RID: 30305 RVA: 0x000AAE7C File Offset: 0x000A907C
		public virtual int GetAutomaticBoundsComputation()
		{
			return vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_GetAutomaticBoundsComputation_03(base.GetCppThis());
		}

		// Token: 0x06007662 RID: 30306
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkForceDirectedLayoutStrategy_GetCoolDownRate_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the Cool-down rate.
		/// The higher this number is, the longer it will take to "cool-down",
		/// and thus, the more the graph will be modified.
		/// </summary>
		// Token: 0x06007663 RID: 30307 RVA: 0x000AAE9C File Offset: 0x000A909C
		public virtual double GetCoolDownRate()
		{
			return vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_GetCoolDownRate_04(base.GetCppThis());
		}

		// Token: 0x06007664 RID: 30308
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkForceDirectedLayoutStrategy_GetCoolDownRateMaxValue_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the Cool-down rate.
		/// The higher this number is, the longer it will take to "cool-down",
		/// and thus, the more the graph will be modified.
		/// </summary>
		// Token: 0x06007665 RID: 30309 RVA: 0x000AAEBC File Offset: 0x000A90BC
		public virtual double GetCoolDownRateMaxValue()
		{
			return vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_GetCoolDownRateMaxValue_05(base.GetCppThis());
		}

		// Token: 0x06007666 RID: 30310
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkForceDirectedLayoutStrategy_GetCoolDownRateMinValue_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the Cool-down rate.
		/// The higher this number is, the longer it will take to "cool-down",
		/// and thus, the more the graph will be modified.
		/// </summary>
		// Token: 0x06007667 RID: 30311 RVA: 0x000AAEDC File Offset: 0x000A90DC
		public virtual double GetCoolDownRateMinValue()
		{
			return vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_GetCoolDownRateMinValue_06(base.GetCppThis());
		}

		// Token: 0x06007668 RID: 30312
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkForceDirectedLayoutStrategy_GetGraphBounds_07(HandleRef pThis);

		/// <summary>
		/// Set / get the region in space in which to place the final graph.
		/// The GraphBounds only affects the results if AutomaticBoundsComputation
		/// is off.
		/// </summary>
		// Token: 0x06007669 RID: 30313 RVA: 0x000AAEFC File Offset: 0x000A90FC
		public virtual double[] GetGraphBounds()
		{
			IntPtr intPtr = vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_GetGraphBounds_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600766A RID: 30314
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkForceDirectedLayoutStrategy_GetGraphBounds_08(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set / get the region in space in which to place the final graph.
		/// The GraphBounds only affects the results if AutomaticBoundsComputation
		/// is off.
		/// </summary>
		// Token: 0x0600766B RID: 30315 RVA: 0x000AAF44 File Offset: 0x000A9144
		public virtual void GetGraphBounds(IntPtr data)
		{
			vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_GetGraphBounds_08(base.GetCppThis(), data);
		}

		// Token: 0x0600766C RID: 30316
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkForceDirectedLayoutStrategy_GetInitialTemperature_09(HandleRef pThis);

		/// <summary>
		/// Set the initial temperature.  If zero (the default) , the initial temperature
		/// will be computed automatically.
		/// </summary>
		// Token: 0x0600766D RID: 30317 RVA: 0x000AAF54 File Offset: 0x000A9154
		public virtual float GetInitialTemperature()
		{
			return vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_GetInitialTemperature_09(base.GetCppThis());
		}

		// Token: 0x0600766E RID: 30318
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkForceDirectedLayoutStrategy_GetInitialTemperatureMaxValue_10(HandleRef pThis);

		/// <summary>
		/// Set the initial temperature.  If zero (the default) , the initial temperature
		/// will be computed automatically.
		/// </summary>
		// Token: 0x0600766F RID: 30319 RVA: 0x000AAF74 File Offset: 0x000A9174
		public virtual float GetInitialTemperatureMaxValue()
		{
			return vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_GetInitialTemperatureMaxValue_10(base.GetCppThis());
		}

		// Token: 0x06007670 RID: 30320
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkForceDirectedLayoutStrategy_GetInitialTemperatureMinValue_11(HandleRef pThis);

		/// <summary>
		/// Set the initial temperature.  If zero (the default) , the initial temperature
		/// will be computed automatically.
		/// </summary>
		// Token: 0x06007671 RID: 30321 RVA: 0x000AAF94 File Offset: 0x000A9194
		public virtual float GetInitialTemperatureMinValue()
		{
			return vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_GetInitialTemperatureMinValue_11(base.GetCppThis());
		}

		// Token: 0x06007672 RID: 30322
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkForceDirectedLayoutStrategy_GetIterationsPerLayout_12(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of iterations per layout.
		/// The only use for this ivar is for the application
		/// to do visualizations of the layout before it's complete.
		/// The default is '50' to match the default 'MaxNumberOfIterations'
		/// </summary>
		// Token: 0x06007673 RID: 30323 RVA: 0x000AAFB4 File Offset: 0x000A91B4
		public virtual int GetIterationsPerLayout()
		{
			return vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_GetIterationsPerLayout_12(base.GetCppThis());
		}

		// Token: 0x06007674 RID: 30324
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkForceDirectedLayoutStrategy_GetIterationsPerLayoutMaxValue_13(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of iterations per layout.
		/// The only use for this ivar is for the application
		/// to do visualizations of the layout before it's complete.
		/// The default is '50' to match the default 'MaxNumberOfIterations'
		/// </summary>
		// Token: 0x06007675 RID: 30325 RVA: 0x000AAFD4 File Offset: 0x000A91D4
		public virtual int GetIterationsPerLayoutMaxValue()
		{
			return vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_GetIterationsPerLayoutMaxValue_13(base.GetCppThis());
		}

		// Token: 0x06007676 RID: 30326
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkForceDirectedLayoutStrategy_GetIterationsPerLayoutMinValue_14(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of iterations per layout.
		/// The only use for this ivar is for the application
		/// to do visualizations of the layout before it's complete.
		/// The default is '50' to match the default 'MaxNumberOfIterations'
		/// </summary>
		// Token: 0x06007677 RID: 30327 RVA: 0x000AAFF4 File Offset: 0x000A91F4
		public virtual int GetIterationsPerLayoutMinValue()
		{
			return vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_GetIterationsPerLayoutMinValue_14(base.GetCppThis());
		}

		// Token: 0x06007678 RID: 30328
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkForceDirectedLayoutStrategy_GetMaxNumberOfIterations_15(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum number of iterations to be used.
		/// The higher this number, the more iterations through the algorithm
		/// is possible, and thus, the more the graph gets modified.
		/// The default is '50' for no particular reason
		/// </summary>
		// Token: 0x06007679 RID: 30329 RVA: 0x000AB014 File Offset: 0x000A9214
		public virtual int GetMaxNumberOfIterations()
		{
			return vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_GetMaxNumberOfIterations_15(base.GetCppThis());
		}

		// Token: 0x0600767A RID: 30330
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkForceDirectedLayoutStrategy_GetMaxNumberOfIterationsMaxValue_16(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum number of iterations to be used.
		/// The higher this number, the more iterations through the algorithm
		/// is possible, and thus, the more the graph gets modified.
		/// The default is '50' for no particular reason
		/// </summary>
		// Token: 0x0600767B RID: 30331 RVA: 0x000AB034 File Offset: 0x000A9234
		public virtual int GetMaxNumberOfIterationsMaxValue()
		{
			return vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_GetMaxNumberOfIterationsMaxValue_16(base.GetCppThis());
		}

		// Token: 0x0600767C RID: 30332
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkForceDirectedLayoutStrategy_GetMaxNumberOfIterationsMinValue_17(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum number of iterations to be used.
		/// The higher this number, the more iterations through the algorithm
		/// is possible, and thus, the more the graph gets modified.
		/// The default is '50' for no particular reason
		/// </summary>
		// Token: 0x0600767D RID: 30333 RVA: 0x000AB054 File Offset: 0x000A9254
		public virtual int GetMaxNumberOfIterationsMinValue()
		{
			return vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_GetMaxNumberOfIterationsMinValue_17(base.GetCppThis());
		}

		// Token: 0x0600767E RID: 30334
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkForceDirectedLayoutStrategy_GetNumberOfGenerationsFromBase_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600767F RID: 30335 RVA: 0x000AB074 File Offset: 0x000A9274
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_GetNumberOfGenerationsFromBase_18(base.GetCppThis(), type);
		}

		// Token: 0x06007680 RID: 30336
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkForceDirectedLayoutStrategy_GetNumberOfGenerationsFromBaseType_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007681 RID: 30337 RVA: 0x000AB094 File Offset: 0x000A9294
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_GetNumberOfGenerationsFromBaseType_19(type);
		}

		// Token: 0x06007682 RID: 30338
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkForceDirectedLayoutStrategy_GetRandomInitialPoints_20(HandleRef pThis);

		/// <summary>
		/// Turn on/off use of random positions within the graph bounds as initial points.
		/// </summary>
		// Token: 0x06007683 RID: 30339 RVA: 0x000AB0B0 File Offset: 0x000A92B0
		public virtual int GetRandomInitialPoints()
		{
			return vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_GetRandomInitialPoints_20(base.GetCppThis());
		}

		// Token: 0x06007684 RID: 30340
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkForceDirectedLayoutStrategy_GetRandomSeed_21(HandleRef pThis);

		/// <summary>
		/// Seed the random number generator used to jitter point positions.
		/// This has a significant effect on their final positions when
		/// the layout is complete.
		/// </summary>
		// Token: 0x06007685 RID: 30341 RVA: 0x000AB0D0 File Offset: 0x000A92D0
		public virtual int GetRandomSeed()
		{
			return vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_GetRandomSeed_21(base.GetCppThis());
		}

		// Token: 0x06007686 RID: 30342
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkForceDirectedLayoutStrategy_GetRandomSeedMaxValue_22(HandleRef pThis);

		/// <summary>
		/// Seed the random number generator used to jitter point positions.
		/// This has a significant effect on their final positions when
		/// the layout is complete.
		/// </summary>
		// Token: 0x06007687 RID: 30343 RVA: 0x000AB0F0 File Offset: 0x000A92F0
		public virtual int GetRandomSeedMaxValue()
		{
			return vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_GetRandomSeedMaxValue_22(base.GetCppThis());
		}

		// Token: 0x06007688 RID: 30344
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkForceDirectedLayoutStrategy_GetRandomSeedMinValue_23(HandleRef pThis);

		/// <summary>
		/// Seed the random number generator used to jitter point positions.
		/// This has a significant effect on their final positions when
		/// the layout is complete.
		/// </summary>
		// Token: 0x06007689 RID: 30345 RVA: 0x000AB110 File Offset: 0x000A9310
		public virtual int GetRandomSeedMinValue()
		{
			return vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_GetRandomSeedMinValue_23(base.GetCppThis());
		}

		// Token: 0x0600768A RID: 30346
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkForceDirectedLayoutStrategy_GetThreeDimensionalLayout_24(HandleRef pThis);

		/// <summary>
		/// Turn on/off layout of graph in three dimensions. If off, graph
		/// layout occurs in two dimensions. By default, three dimensional
		/// layout is off.
		/// </summary>
		// Token: 0x0600768B RID: 30347 RVA: 0x000AB130 File Offset: 0x000A9330
		public virtual int GetThreeDimensionalLayout()
		{
			return vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_GetThreeDimensionalLayout_24(base.GetCppThis());
		}

		// Token: 0x0600768C RID: 30348
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkForceDirectedLayoutStrategy_Initialize_25(HandleRef pThis);

		/// <summary>
		/// This strategy sets up some data structures
		/// for faster processing of each Layout() call
		/// </summary>
		// Token: 0x0600768D RID: 30349 RVA: 0x000AB14F File Offset: 0x000A934F
		public override void Initialize()
		{
			vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_Initialize_25(base.GetCppThis());
		}

		// Token: 0x0600768E RID: 30350
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkForceDirectedLayoutStrategy_IsA_26(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600768F RID: 30351 RVA: 0x000AB160 File Offset: 0x000A9360
		public override int IsA(string type)
		{
			return vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_IsA_26(base.GetCppThis(), type);
		}

		// Token: 0x06007690 RID: 30352
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkForceDirectedLayoutStrategy_IsLayoutComplete_27(HandleRef pThis);

		/// <summary>
		/// I'm an iterative layout so this method lets the caller
		/// know if I'm done laying out the graph
		/// </summary>
		// Token: 0x06007691 RID: 30353 RVA: 0x000AB180 File Offset: 0x000A9380
		public override int IsLayoutComplete()
		{
			return vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_IsLayoutComplete_27(base.GetCppThis());
		}

		// Token: 0x06007692 RID: 30354
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkForceDirectedLayoutStrategy_IsTypeOf_28([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007693 RID: 30355 RVA: 0x000AB1A0 File Offset: 0x000A93A0
		public new static int IsTypeOf(string type)
		{
			return vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_IsTypeOf_28(type);
		}

		// Token: 0x06007694 RID: 30356
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkForceDirectedLayoutStrategy_Layout_29(HandleRef pThis);

		/// <summary>
		/// This is the layout method where the graph that was
		/// set in SetGraph() is laid out. The method can either
		/// entirely layout the graph or iteratively lay out the
		/// graph. If you have an iterative layout please implement
		/// the IsLayoutComplete() method.
		/// </summary>
		// Token: 0x06007695 RID: 30357 RVA: 0x000AB1BA File Offset: 0x000A93BA
		public override void Layout()
		{
			vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_Layout_29(base.GetCppThis());
		}

		// Token: 0x06007696 RID: 30358
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkForceDirectedLayoutStrategy_NewInstance_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007697 RID: 30359 RVA: 0x000AB1CC File Offset: 0x000A93CC
		public new vtkForceDirectedLayoutStrategy NewInstance()
		{
			vtkForceDirectedLayoutStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_NewInstance_31(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkForceDirectedLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06007698 RID: 30360
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkForceDirectedLayoutStrategy_RandomInitialPointsOff_32(HandleRef pThis);

		/// <summary>
		/// Turn on/off use of random positions within the graph bounds as initial points.
		/// </summary>
		// Token: 0x06007699 RID: 30361 RVA: 0x000AB226 File Offset: 0x000A9426
		public virtual void RandomInitialPointsOff()
		{
			vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_RandomInitialPointsOff_32(base.GetCppThis());
		}

		// Token: 0x0600769A RID: 30362
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkForceDirectedLayoutStrategy_RandomInitialPointsOn_33(HandleRef pThis);

		/// <summary>
		/// Turn on/off use of random positions within the graph bounds as initial points.
		/// </summary>
		// Token: 0x0600769B RID: 30363 RVA: 0x000AB235 File Offset: 0x000A9435
		public virtual void RandomInitialPointsOn()
		{
			vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_RandomInitialPointsOn_33(base.GetCppThis());
		}

		// Token: 0x0600769C RID: 30364
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkForceDirectedLayoutStrategy_SafeDownCast_34(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600769D RID: 30365 RVA: 0x000AB244 File Offset: 0x000A9444
		public new static vtkForceDirectedLayoutStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkForceDirectedLayoutStrategy vtkForceDirectedLayoutStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_SafeDownCast_34((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkForceDirectedLayoutStrategy = (vtkForceDirectedLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkForceDirectedLayoutStrategy.Register(null);
				}
			}
			return vtkForceDirectedLayoutStrategy;
		}

		// Token: 0x0600769E RID: 30366
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkForceDirectedLayoutStrategy_SetAutomaticBoundsComputation_35(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off automatic graph bounds calculation. If this
		/// boolean is off, then the manually specified GraphBounds is used.
		/// If on, then the input's bounds us used as the graph bounds.
		/// </summary>
		// Token: 0x0600769F RID: 30367 RVA: 0x000AB2C3 File Offset: 0x000A94C3
		public virtual void SetAutomaticBoundsComputation(int _arg)
		{
			vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_SetAutomaticBoundsComputation_35(base.GetCppThis(), _arg);
		}

		// Token: 0x060076A0 RID: 30368
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkForceDirectedLayoutStrategy_SetCoolDownRate_36(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the Cool-down rate.
		/// The higher this number is, the longer it will take to "cool-down",
		/// and thus, the more the graph will be modified.
		/// </summary>
		// Token: 0x060076A1 RID: 30369 RVA: 0x000AB2D3 File Offset: 0x000A94D3
		public virtual void SetCoolDownRate(double _arg)
		{
			vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_SetCoolDownRate_36(base.GetCppThis(), _arg);
		}

		// Token: 0x060076A2 RID: 30370
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkForceDirectedLayoutStrategy_SetGraphBounds_37(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		/// <summary>
		/// Set / get the region in space in which to place the final graph.
		/// The GraphBounds only affects the results if AutomaticBoundsComputation
		/// is off.
		/// </summary>
		// Token: 0x060076A3 RID: 30371 RVA: 0x000AB2E3 File Offset: 0x000A94E3
		public virtual void SetGraphBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_SetGraphBounds_37(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x060076A4 RID: 30372
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkForceDirectedLayoutStrategy_SetGraphBounds_38(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set / get the region in space in which to place the final graph.
		/// The GraphBounds only affects the results if AutomaticBoundsComputation
		/// is off.
		/// </summary>
		// Token: 0x060076A5 RID: 30373 RVA: 0x000AB2FB File Offset: 0x000A94FB
		public virtual void SetGraphBounds(IntPtr _arg)
		{
			vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_SetGraphBounds_38(base.GetCppThis(), _arg);
		}

		// Token: 0x060076A6 RID: 30374
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkForceDirectedLayoutStrategy_SetInitialTemperature_39(HandleRef pThis, float _arg);

		/// <summary>
		/// Set the initial temperature.  If zero (the default) , the initial temperature
		/// will be computed automatically.
		/// </summary>
		// Token: 0x060076A7 RID: 30375 RVA: 0x000AB30B File Offset: 0x000A950B
		public virtual void SetInitialTemperature(float _arg)
		{
			vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_SetInitialTemperature_39(base.GetCppThis(), _arg);
		}

		// Token: 0x060076A8 RID: 30376
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkForceDirectedLayoutStrategy_SetIterationsPerLayout_40(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the number of iterations per layout.
		/// The only use for this ivar is for the application
		/// to do visualizations of the layout before it's complete.
		/// The default is '50' to match the default 'MaxNumberOfIterations'
		/// </summary>
		// Token: 0x060076A9 RID: 30377 RVA: 0x000AB31B File Offset: 0x000A951B
		public virtual void SetIterationsPerLayout(int _arg)
		{
			vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_SetIterationsPerLayout_40(base.GetCppThis(), _arg);
		}

		// Token: 0x060076AA RID: 30378
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkForceDirectedLayoutStrategy_SetMaxNumberOfIterations_41(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the maximum number of iterations to be used.
		/// The higher this number, the more iterations through the algorithm
		/// is possible, and thus, the more the graph gets modified.
		/// The default is '50' for no particular reason
		/// </summary>
		// Token: 0x060076AB RID: 30379 RVA: 0x000AB32B File Offset: 0x000A952B
		public virtual void SetMaxNumberOfIterations(int _arg)
		{
			vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_SetMaxNumberOfIterations_41(base.GetCppThis(), _arg);
		}

		// Token: 0x060076AC RID: 30380
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkForceDirectedLayoutStrategy_SetRandomInitialPoints_42(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off use of random positions within the graph bounds as initial points.
		/// </summary>
		// Token: 0x060076AD RID: 30381 RVA: 0x000AB33B File Offset: 0x000A953B
		public virtual void SetRandomInitialPoints(int _arg)
		{
			vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_SetRandomInitialPoints_42(base.GetCppThis(), _arg);
		}

		// Token: 0x060076AE RID: 30382
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkForceDirectedLayoutStrategy_SetRandomSeed_43(HandleRef pThis, int _arg);

		/// <summary>
		/// Seed the random number generator used to jitter point positions.
		/// This has a significant effect on their final positions when
		/// the layout is complete.
		/// </summary>
		// Token: 0x060076AF RID: 30383 RVA: 0x000AB34B File Offset: 0x000A954B
		public virtual void SetRandomSeed(int _arg)
		{
			vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_SetRandomSeed_43(base.GetCppThis(), _arg);
		}

		// Token: 0x060076B0 RID: 30384
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkForceDirectedLayoutStrategy_SetThreeDimensionalLayout_44(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off layout of graph in three dimensions. If off, graph
		/// layout occurs in two dimensions. By default, three dimensional
		/// layout is off.
		/// </summary>
		// Token: 0x060076B1 RID: 30385 RVA: 0x000AB35B File Offset: 0x000A955B
		public virtual void SetThreeDimensionalLayout(int _arg)
		{
			vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_SetThreeDimensionalLayout_44(base.GetCppThis(), _arg);
		}

		// Token: 0x060076B2 RID: 30386
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkForceDirectedLayoutStrategy_ThreeDimensionalLayoutOff_45(HandleRef pThis);

		/// <summary>
		/// Turn on/off layout of graph in three dimensions. If off, graph
		/// layout occurs in two dimensions. By default, three dimensional
		/// layout is off.
		/// </summary>
		// Token: 0x060076B3 RID: 30387 RVA: 0x000AB36B File Offset: 0x000A956B
		public virtual void ThreeDimensionalLayoutOff()
		{
			vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_ThreeDimensionalLayoutOff_45(base.GetCppThis());
		}

		// Token: 0x060076B4 RID: 30388
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkForceDirectedLayoutStrategy_ThreeDimensionalLayoutOn_46(HandleRef pThis);

		/// <summary>
		/// Turn on/off layout of graph in three dimensions. If off, graph
		/// layout occurs in two dimensions. By default, three dimensional
		/// layout is off.
		/// </summary>
		// Token: 0x060076B5 RID: 30389 RVA: 0x000AB37A File Offset: 0x000A957A
		public virtual void ThreeDimensionalLayoutOn()
		{
			vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_ThreeDimensionalLayoutOn_46(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A2A RID: 2602
		public new const string MRFullTypeName = "Kitware.VTK.vtkForceDirectedLayoutStrategy";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A2B RID: 2603
		public new static readonly string MRClassNameKey = "class vtkForceDirectedLayoutStrategy";
	}
}
