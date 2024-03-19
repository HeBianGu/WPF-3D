using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkClustering2DLayoutStrategy
	/// </summary>
	/// <remarks>
	///    a simple fast 2D graph layout
	///
	///
	/// This class is a density grid based force directed layout strategy.
	/// Also please note that 'fast' is relative to quite slow. :)
	/// The layout running time is O(V+E) with an extremely high constant.
	/// @par Thanks:
	/// Thanks to Godzilla for not eating my computer so that this class
	/// could be written.
	/// </remarks>
	// Token: 0x02000287 RID: 647
	public class vtkClustering2DLayoutStrategy : vtkGraphLayoutStrategy
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060074D2 RID: 29906 RVA: 0x000A901F File Offset: 0x000A721F
		static vtkClustering2DLayoutStrategy()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkClustering2DLayoutStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkClustering2DLayoutStrategy"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060074D3 RID: 29907 RVA: 0x000A9047 File Offset: 0x000A7247
		public vtkClustering2DLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060074D4 RID: 29908
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClustering2DLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060074D5 RID: 29909 RVA: 0x000A9058 File Offset: 0x000A7258
		public new static vtkClustering2DLayoutStrategy New()
		{
			vtkClustering2DLayoutStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkClustering2DLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060074D6 RID: 29910 RVA: 0x000A90AC File Offset: 0x000A72AC
		public vtkClustering2DLayoutStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060074D7 RID: 29911 RVA: 0x000A90F0 File Offset: 0x000A72F0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060074D8 RID: 29912
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkClustering2DLayoutStrategy_GetCoolDownRate_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the Cool-down rate.
		/// The higher this number is, the longer it will take to "cool-down",
		/// and thus, the more the graph will be modified. The default is '10'
		/// for no particular reason.
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x060074D9 RID: 29913 RVA: 0x000A90FC File Offset: 0x000A72FC
		public virtual double GetCoolDownRate()
		{
			return vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_GetCoolDownRate_01(base.GetCppThis());
		}

		// Token: 0x060074DA RID: 29914
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkClustering2DLayoutStrategy_GetCoolDownRateMaxValue_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the Cool-down rate.
		/// The higher this number is, the longer it will take to "cool-down",
		/// and thus, the more the graph will be modified. The default is '10'
		/// for no particular reason.
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x060074DB RID: 29915 RVA: 0x000A911C File Offset: 0x000A731C
		public virtual double GetCoolDownRateMaxValue()
		{
			return vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_GetCoolDownRateMaxValue_02(base.GetCppThis());
		}

		// Token: 0x060074DC RID: 29916
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkClustering2DLayoutStrategy_GetCoolDownRateMinValue_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the Cool-down rate.
		/// The higher this number is, the longer it will take to "cool-down",
		/// and thus, the more the graph will be modified. The default is '10'
		/// for no particular reason.
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x060074DD RID: 29917 RVA: 0x000A913C File Offset: 0x000A733C
		public virtual double GetCoolDownRateMinValue()
		{
			return vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_GetCoolDownRateMinValue_03(base.GetCppThis());
		}

		// Token: 0x060074DE RID: 29918
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkClustering2DLayoutStrategy_GetInitialTemperature_04(HandleRef pThis);

		/// <summary>
		/// Set the initial temperature.  The temperature default is '5'
		/// for no particular reason
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x060074DF RID: 29919 RVA: 0x000A915C File Offset: 0x000A735C
		public virtual float GetInitialTemperature()
		{
			return vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_GetInitialTemperature_04(base.GetCppThis());
		}

		// Token: 0x060074E0 RID: 29920
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkClustering2DLayoutStrategy_GetInitialTemperatureMaxValue_05(HandleRef pThis);

		/// <summary>
		/// Set the initial temperature.  The temperature default is '5'
		/// for no particular reason
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x060074E1 RID: 29921 RVA: 0x000A917C File Offset: 0x000A737C
		public virtual float GetInitialTemperatureMaxValue()
		{
			return vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_GetInitialTemperatureMaxValue_05(base.GetCppThis());
		}

		// Token: 0x060074E2 RID: 29922
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkClustering2DLayoutStrategy_GetInitialTemperatureMinValue_06(HandleRef pThis);

		/// <summary>
		/// Set the initial temperature.  The temperature default is '5'
		/// for no particular reason
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x060074E3 RID: 29923 RVA: 0x000A919C File Offset: 0x000A739C
		public virtual float GetInitialTemperatureMinValue()
		{
			return vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_GetInitialTemperatureMinValue_06(base.GetCppThis());
		}

		// Token: 0x060074E4 RID: 29924
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClustering2DLayoutStrategy_GetIterationsPerLayout_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of iterations per layout.
		/// The only use for this ivar is for the application
		/// to do visualizations of the layout before it's complete.
		/// The default is '100' to match the default 'MaxNumberOfIterations'
		/// Note: Changing this parameter is just fine :)
		/// </summary>
		// Token: 0x060074E5 RID: 29925 RVA: 0x000A91BC File Offset: 0x000A73BC
		public virtual int GetIterationsPerLayout()
		{
			return vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_GetIterationsPerLayout_07(base.GetCppThis());
		}

		// Token: 0x060074E6 RID: 29926
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClustering2DLayoutStrategy_GetIterationsPerLayoutMaxValue_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of iterations per layout.
		/// The only use for this ivar is for the application
		/// to do visualizations of the layout before it's complete.
		/// The default is '100' to match the default 'MaxNumberOfIterations'
		/// Note: Changing this parameter is just fine :)
		/// </summary>
		// Token: 0x060074E7 RID: 29927 RVA: 0x000A91DC File Offset: 0x000A73DC
		public virtual int GetIterationsPerLayoutMaxValue()
		{
			return vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_GetIterationsPerLayoutMaxValue_08(base.GetCppThis());
		}

		// Token: 0x060074E8 RID: 29928
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClustering2DLayoutStrategy_GetIterationsPerLayoutMinValue_09(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of iterations per layout.
		/// The only use for this ivar is for the application
		/// to do visualizations of the layout before it's complete.
		/// The default is '100' to match the default 'MaxNumberOfIterations'
		/// Note: Changing this parameter is just fine :)
		/// </summary>
		// Token: 0x060074E9 RID: 29929 RVA: 0x000A91FC File Offset: 0x000A73FC
		public virtual int GetIterationsPerLayoutMinValue()
		{
			return vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_GetIterationsPerLayoutMinValue_09(base.GetCppThis());
		}

		// Token: 0x060074EA RID: 29930
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClustering2DLayoutStrategy_GetMaxNumberOfIterations_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum number of iterations to be used.
		/// The higher this number, the more iterations through the algorithm
		/// is possible, and thus, the more the graph gets modified.
		/// The default is '100' for no particular reason
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x060074EB RID: 29931 RVA: 0x000A921C File Offset: 0x000A741C
		public virtual int GetMaxNumberOfIterations()
		{
			return vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_GetMaxNumberOfIterations_10(base.GetCppThis());
		}

		// Token: 0x060074EC RID: 29932
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClustering2DLayoutStrategy_GetMaxNumberOfIterationsMaxValue_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum number of iterations to be used.
		/// The higher this number, the more iterations through the algorithm
		/// is possible, and thus, the more the graph gets modified.
		/// The default is '100' for no particular reason
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x060074ED RID: 29933 RVA: 0x000A923C File Offset: 0x000A743C
		public virtual int GetMaxNumberOfIterationsMaxValue()
		{
			return vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_GetMaxNumberOfIterationsMaxValue_11(base.GetCppThis());
		}

		// Token: 0x060074EE RID: 29934
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClustering2DLayoutStrategy_GetMaxNumberOfIterationsMinValue_12(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum number of iterations to be used.
		/// The higher this number, the more iterations through the algorithm
		/// is possible, and thus, the more the graph gets modified.
		/// The default is '100' for no particular reason
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x060074EF RID: 29935 RVA: 0x000A925C File Offset: 0x000A745C
		public virtual int GetMaxNumberOfIterationsMinValue()
		{
			return vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_GetMaxNumberOfIterationsMinValue_12(base.GetCppThis());
		}

		// Token: 0x060074F0 RID: 29936
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkClustering2DLayoutStrategy_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060074F1 RID: 29937 RVA: 0x000A927C File Offset: 0x000A747C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x060074F2 RID: 29938
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkClustering2DLayoutStrategy_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060074F3 RID: 29939 RVA: 0x000A929C File Offset: 0x000A749C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x060074F4 RID: 29940
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClustering2DLayoutStrategy_GetRandomSeed_15(HandleRef pThis);

		/// <summary>
		/// Seed the random number generator used to jitter point positions.
		/// This has a significant effect on their final positions when
		/// the layout is complete.
		/// </summary>
		// Token: 0x060074F5 RID: 29941 RVA: 0x000A92B8 File Offset: 0x000A74B8
		public virtual int GetRandomSeed()
		{
			return vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_GetRandomSeed_15(base.GetCppThis());
		}

		// Token: 0x060074F6 RID: 29942
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClustering2DLayoutStrategy_GetRandomSeedMaxValue_16(HandleRef pThis);

		/// <summary>
		/// Seed the random number generator used to jitter point positions.
		/// This has a significant effect on their final positions when
		/// the layout is complete.
		/// </summary>
		// Token: 0x060074F7 RID: 29943 RVA: 0x000A92D8 File Offset: 0x000A74D8
		public virtual int GetRandomSeedMaxValue()
		{
			return vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_GetRandomSeedMaxValue_16(base.GetCppThis());
		}

		// Token: 0x060074F8 RID: 29944
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClustering2DLayoutStrategy_GetRandomSeedMinValue_17(HandleRef pThis);

		/// <summary>
		/// Seed the random number generator used to jitter point positions.
		/// This has a significant effect on their final positions when
		/// the layout is complete.
		/// </summary>
		// Token: 0x060074F9 RID: 29945 RVA: 0x000A92F8 File Offset: 0x000A74F8
		public virtual int GetRandomSeedMinValue()
		{
			return vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_GetRandomSeedMinValue_17(base.GetCppThis());
		}

		// Token: 0x060074FA RID: 29946
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkClustering2DLayoutStrategy_GetRestDistance_18(HandleRef pThis);

		/// <summary>
		/// Manually set the resting distance. Otherwise the
		/// distance is computed automatically.
		/// </summary>
		// Token: 0x060074FB RID: 29947 RVA: 0x000A9318 File Offset: 0x000A7518
		public virtual float GetRestDistance()
		{
			return vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_GetRestDistance_18(base.GetCppThis());
		}

		// Token: 0x060074FC RID: 29948
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClustering2DLayoutStrategy_Initialize_19(HandleRef pThis);

		/// <summary>
		/// This strategy sets up some data structures
		/// for faster processing of each Layout() call
		/// </summary>
		// Token: 0x060074FD RID: 29949 RVA: 0x000A9337 File Offset: 0x000A7537
		public override void Initialize()
		{
			vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_Initialize_19(base.GetCppThis());
		}

		// Token: 0x060074FE RID: 29950
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClustering2DLayoutStrategy_IsA_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060074FF RID: 29951 RVA: 0x000A9348 File Offset: 0x000A7548
		public override int IsA(string type)
		{
			return vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_IsA_20(base.GetCppThis(), type);
		}

		// Token: 0x06007500 RID: 29952
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClustering2DLayoutStrategy_IsLayoutComplete_21(HandleRef pThis);

		/// <summary>
		/// I'm an iterative layout so this method lets the caller
		/// know if I'm done laying out the graph
		/// </summary>
		// Token: 0x06007501 RID: 29953 RVA: 0x000A9368 File Offset: 0x000A7568
		public override int IsLayoutComplete()
		{
			return vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_IsLayoutComplete_21(base.GetCppThis());
		}

		// Token: 0x06007502 RID: 29954
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClustering2DLayoutStrategy_IsTypeOf_22([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007503 RID: 29955 RVA: 0x000A9388 File Offset: 0x000A7588
		public new static int IsTypeOf(string type)
		{
			return vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_IsTypeOf_22(type);
		}

		// Token: 0x06007504 RID: 29956
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClustering2DLayoutStrategy_Layout_23(HandleRef pThis);

		/// <summary>
		/// This is the layout method where the graph that was
		/// set in SetGraph() is laid out. The method can either
		/// entirely layout the graph or iteratively lay out the
		/// graph. If you have an iterative layout please implement
		/// the IsLayoutComplete() method.
		/// </summary>
		// Token: 0x06007505 RID: 29957 RVA: 0x000A93A2 File Offset: 0x000A75A2
		public override void Layout()
		{
			vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_Layout_23(base.GetCppThis());
		}

		// Token: 0x06007506 RID: 29958
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClustering2DLayoutStrategy_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007507 RID: 29959 RVA: 0x000A93B4 File Offset: 0x000A75B4
		public new vtkClustering2DLayoutStrategy NewInstance()
		{
			vtkClustering2DLayoutStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_NewInstance_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkClustering2DLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06007508 RID: 29960
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClustering2DLayoutStrategy_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007509 RID: 29961 RVA: 0x000A9410 File Offset: 0x000A7610
		public new static vtkClustering2DLayoutStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkClustering2DLayoutStrategy vtkClustering2DLayoutStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkClustering2DLayoutStrategy = (vtkClustering2DLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkClustering2DLayoutStrategy.Register(null);
				}
			}
			return vtkClustering2DLayoutStrategy;
		}

		// Token: 0x0600750A RID: 29962
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClustering2DLayoutStrategy_SetCoolDownRate_27(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the Cool-down rate.
		/// The higher this number is, the longer it will take to "cool-down",
		/// and thus, the more the graph will be modified. The default is '10'
		/// for no particular reason.
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x0600750B RID: 29963 RVA: 0x000A948F File Offset: 0x000A768F
		public virtual void SetCoolDownRate(double _arg)
		{
			vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_SetCoolDownRate_27(base.GetCppThis(), _arg);
		}

		// Token: 0x0600750C RID: 29964
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClustering2DLayoutStrategy_SetInitialTemperature_28(HandleRef pThis, float _arg);

		/// <summary>
		/// Set the initial temperature.  The temperature default is '5'
		/// for no particular reason
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x0600750D RID: 29965 RVA: 0x000A949F File Offset: 0x000A769F
		public virtual void SetInitialTemperature(float _arg)
		{
			vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_SetInitialTemperature_28(base.GetCppThis(), _arg);
		}

		// Token: 0x0600750E RID: 29966
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClustering2DLayoutStrategy_SetIterationsPerLayout_29(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the number of iterations per layout.
		/// The only use for this ivar is for the application
		/// to do visualizations of the layout before it's complete.
		/// The default is '100' to match the default 'MaxNumberOfIterations'
		/// Note: Changing this parameter is just fine :)
		/// </summary>
		// Token: 0x0600750F RID: 29967 RVA: 0x000A94AF File Offset: 0x000A76AF
		public virtual void SetIterationsPerLayout(int _arg)
		{
			vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_SetIterationsPerLayout_29(base.GetCppThis(), _arg);
		}

		// Token: 0x06007510 RID: 29968
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClustering2DLayoutStrategy_SetMaxNumberOfIterations_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the maximum number of iterations to be used.
		/// The higher this number, the more iterations through the algorithm
		/// is possible, and thus, the more the graph gets modified.
		/// The default is '100' for no particular reason
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x06007511 RID: 29969 RVA: 0x000A94BF File Offset: 0x000A76BF
		public virtual void SetMaxNumberOfIterations(int _arg)
		{
			vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_SetMaxNumberOfIterations_30(base.GetCppThis(), _arg);
		}

		// Token: 0x06007512 RID: 29970
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClustering2DLayoutStrategy_SetRandomSeed_31(HandleRef pThis, int _arg);

		/// <summary>
		/// Seed the random number generator used to jitter point positions.
		/// This has a significant effect on their final positions when
		/// the layout is complete.
		/// </summary>
		// Token: 0x06007513 RID: 29971 RVA: 0x000A94CF File Offset: 0x000A76CF
		public virtual void SetRandomSeed(int _arg)
		{
			vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_SetRandomSeed_31(base.GetCppThis(), _arg);
		}

		// Token: 0x06007514 RID: 29972
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClustering2DLayoutStrategy_SetRestDistance_32(HandleRef pThis, float _arg);

		/// <summary>
		/// Manually set the resting distance. Otherwise the
		/// distance is computed automatically.
		/// </summary>
		// Token: 0x06007515 RID: 29973 RVA: 0x000A94DF File Offset: 0x000A76DF
		public virtual void SetRestDistance(float _arg)
		{
			vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_SetRestDistance_32(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A1C RID: 2588
		public new const string MRFullTypeName = "Kitware.VTK.vtkClustering2DLayoutStrategy";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A1D RID: 2589
		public new static readonly string MRClassNameKey = "class vtkClustering2DLayoutStrategy";
	}
}
