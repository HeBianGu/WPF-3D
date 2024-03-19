using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCommunity2DLayoutStrategy
	/// </summary>
	/// <remarks>
	///    a simple fast 2D graph layout
	/// that looks for a community array on it's input and strengthens
	/// edges within a community and weakens edges not within the community.
	///
	///
	/// This class is a density grid based force directed layout strategy.
	/// Also please note that 'fast' is relative to quite slow. :)
	/// The layout running time is O(V+E) with an extremely high constant.
	/// @par Thanks:
	/// Thanks to Godzilla for not eating my computer so that this class
	/// could be written.
	/// </remarks>
	// Token: 0x02000288 RID: 648
	public class vtkCommunity2DLayoutStrategy : vtkGraphLayoutStrategy
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06007516 RID: 29974 RVA: 0x000A94EF File Offset: 0x000A76EF
		static vtkCommunity2DLayoutStrategy()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCommunity2DLayoutStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCommunity2DLayoutStrategy"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06007517 RID: 29975 RVA: 0x000A9517 File Offset: 0x000A7717
		public vtkCommunity2DLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06007518 RID: 29976
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCommunity2DLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007519 RID: 29977 RVA: 0x000A9528 File Offset: 0x000A7728
		public new static vtkCommunity2DLayoutStrategy New()
		{
			vtkCommunity2DLayoutStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCommunity2DLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600751A RID: 29978 RVA: 0x000A957C File Offset: 0x000A777C
		public vtkCommunity2DLayoutStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600751B RID: 29979 RVA: 0x000A95C0 File Offset: 0x000A77C0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600751C RID: 29980
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCommunity2DLayoutStrategy_GetCommunityArrayName_01(HandleRef pThis);

		/// <summary>
		/// Get/Set the community array name
		/// </summary>
		// Token: 0x0600751D RID: 29981 RVA: 0x000A95CC File Offset: 0x000A77CC
		public virtual string GetCommunityArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_GetCommunityArrayName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600751E RID: 29982
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkCommunity2DLayoutStrategy_GetCommunityStrength_02(HandleRef pThis);

		/// <summary>
		/// Set the community 'strength'.  The default is '1'
		/// which means vertices in the same community will be
		/// placed close together, values closer to .1 (minimum)
		/// will mean a layout closer to traditional force directed.
		/// </summary>
		// Token: 0x0600751F RID: 29983 RVA: 0x000A9608 File Offset: 0x000A7808
		public virtual float GetCommunityStrength()
		{
			return vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_GetCommunityStrength_02(base.GetCppThis());
		}

		// Token: 0x06007520 RID: 29984
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkCommunity2DLayoutStrategy_GetCommunityStrengthMaxValue_03(HandleRef pThis);

		/// <summary>
		/// Set the community 'strength'.  The default is '1'
		/// which means vertices in the same community will be
		/// placed close together, values closer to .1 (minimum)
		/// will mean a layout closer to traditional force directed.
		/// </summary>
		// Token: 0x06007521 RID: 29985 RVA: 0x000A9628 File Offset: 0x000A7828
		public virtual float GetCommunityStrengthMaxValue()
		{
			return vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_GetCommunityStrengthMaxValue_03(base.GetCppThis());
		}

		// Token: 0x06007522 RID: 29986
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkCommunity2DLayoutStrategy_GetCommunityStrengthMinValue_04(HandleRef pThis);

		/// <summary>
		/// Set the community 'strength'.  The default is '1'
		/// which means vertices in the same community will be
		/// placed close together, values closer to .1 (minimum)
		/// will mean a layout closer to traditional force directed.
		/// </summary>
		// Token: 0x06007523 RID: 29987 RVA: 0x000A9648 File Offset: 0x000A7848
		public virtual float GetCommunityStrengthMinValue()
		{
			return vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_GetCommunityStrengthMinValue_04(base.GetCppThis());
		}

		// Token: 0x06007524 RID: 29988
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCommunity2DLayoutStrategy_GetCoolDownRate_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the Cool-down rate.
		/// The higher this number is, the longer it will take to "cool-down",
		/// and thus, the more the graph will be modified. The default is '10'
		/// for no particular reason.
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x06007525 RID: 29989 RVA: 0x000A9668 File Offset: 0x000A7868
		public virtual double GetCoolDownRate()
		{
			return vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_GetCoolDownRate_05(base.GetCppThis());
		}

		// Token: 0x06007526 RID: 29990
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCommunity2DLayoutStrategy_GetCoolDownRateMaxValue_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the Cool-down rate.
		/// The higher this number is, the longer it will take to "cool-down",
		/// and thus, the more the graph will be modified. The default is '10'
		/// for no particular reason.
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x06007527 RID: 29991 RVA: 0x000A9688 File Offset: 0x000A7888
		public virtual double GetCoolDownRateMaxValue()
		{
			return vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_GetCoolDownRateMaxValue_06(base.GetCppThis());
		}

		// Token: 0x06007528 RID: 29992
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCommunity2DLayoutStrategy_GetCoolDownRateMinValue_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the Cool-down rate.
		/// The higher this number is, the longer it will take to "cool-down",
		/// and thus, the more the graph will be modified. The default is '10'
		/// for no particular reason.
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x06007529 RID: 29993 RVA: 0x000A96A8 File Offset: 0x000A78A8
		public virtual double GetCoolDownRateMinValue()
		{
			return vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_GetCoolDownRateMinValue_07(base.GetCppThis());
		}

		// Token: 0x0600752A RID: 29994
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkCommunity2DLayoutStrategy_GetInitialTemperature_08(HandleRef pThis);

		/// <summary>
		/// Set the initial temperature.  The temperature default is '5'
		/// for no particular reason
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x0600752B RID: 29995 RVA: 0x000A96C8 File Offset: 0x000A78C8
		public virtual float GetInitialTemperature()
		{
			return vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_GetInitialTemperature_08(base.GetCppThis());
		}

		// Token: 0x0600752C RID: 29996
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkCommunity2DLayoutStrategy_GetInitialTemperatureMaxValue_09(HandleRef pThis);

		/// <summary>
		/// Set the initial temperature.  The temperature default is '5'
		/// for no particular reason
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x0600752D RID: 29997 RVA: 0x000A96E8 File Offset: 0x000A78E8
		public virtual float GetInitialTemperatureMaxValue()
		{
			return vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_GetInitialTemperatureMaxValue_09(base.GetCppThis());
		}

		// Token: 0x0600752E RID: 29998
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkCommunity2DLayoutStrategy_GetInitialTemperatureMinValue_10(HandleRef pThis);

		/// <summary>
		/// Set the initial temperature.  The temperature default is '5'
		/// for no particular reason
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x0600752F RID: 29999 RVA: 0x000A9708 File Offset: 0x000A7908
		public virtual float GetInitialTemperatureMinValue()
		{
			return vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_GetInitialTemperatureMinValue_10(base.GetCppThis());
		}

		// Token: 0x06007530 RID: 30000
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunity2DLayoutStrategy_GetIterationsPerLayout_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of iterations per layout.
		/// The only use for this ivar is for the application
		/// to do visualizations of the layout before it's complete.
		/// The default is '100' to match the default 'MaxNumberOfIterations'
		/// Note: Changing this parameter is just fine :)
		/// </summary>
		// Token: 0x06007531 RID: 30001 RVA: 0x000A9728 File Offset: 0x000A7928
		public virtual int GetIterationsPerLayout()
		{
			return vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_GetIterationsPerLayout_11(base.GetCppThis());
		}

		// Token: 0x06007532 RID: 30002
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunity2DLayoutStrategy_GetIterationsPerLayoutMaxValue_12(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of iterations per layout.
		/// The only use for this ivar is for the application
		/// to do visualizations of the layout before it's complete.
		/// The default is '100' to match the default 'MaxNumberOfIterations'
		/// Note: Changing this parameter is just fine :)
		/// </summary>
		// Token: 0x06007533 RID: 30003 RVA: 0x000A9748 File Offset: 0x000A7948
		public virtual int GetIterationsPerLayoutMaxValue()
		{
			return vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_GetIterationsPerLayoutMaxValue_12(base.GetCppThis());
		}

		// Token: 0x06007534 RID: 30004
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunity2DLayoutStrategy_GetIterationsPerLayoutMinValue_13(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of iterations per layout.
		/// The only use for this ivar is for the application
		/// to do visualizations of the layout before it's complete.
		/// The default is '100' to match the default 'MaxNumberOfIterations'
		/// Note: Changing this parameter is just fine :)
		/// </summary>
		// Token: 0x06007535 RID: 30005 RVA: 0x000A9768 File Offset: 0x000A7968
		public virtual int GetIterationsPerLayoutMinValue()
		{
			return vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_GetIterationsPerLayoutMinValue_13(base.GetCppThis());
		}

		// Token: 0x06007536 RID: 30006
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunity2DLayoutStrategy_GetMaxNumberOfIterations_14(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum number of iterations to be used.
		/// The higher this number, the more iterations through the algorithm
		/// is possible, and thus, the more the graph gets modified.
		/// The default is '100' for no particular reason
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x06007537 RID: 30007 RVA: 0x000A9788 File Offset: 0x000A7988
		public virtual int GetMaxNumberOfIterations()
		{
			return vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_GetMaxNumberOfIterations_14(base.GetCppThis());
		}

		// Token: 0x06007538 RID: 30008
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunity2DLayoutStrategy_GetMaxNumberOfIterationsMaxValue_15(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum number of iterations to be used.
		/// The higher this number, the more iterations through the algorithm
		/// is possible, and thus, the more the graph gets modified.
		/// The default is '100' for no particular reason
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x06007539 RID: 30009 RVA: 0x000A97A8 File Offset: 0x000A79A8
		public virtual int GetMaxNumberOfIterationsMaxValue()
		{
			return vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_GetMaxNumberOfIterationsMaxValue_15(base.GetCppThis());
		}

		// Token: 0x0600753A RID: 30010
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunity2DLayoutStrategy_GetMaxNumberOfIterationsMinValue_16(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum number of iterations to be used.
		/// The higher this number, the more iterations through the algorithm
		/// is possible, and thus, the more the graph gets modified.
		/// The default is '100' for no particular reason
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x0600753B RID: 30011 RVA: 0x000A97C8 File Offset: 0x000A79C8
		public virtual int GetMaxNumberOfIterationsMinValue()
		{
			return vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_GetMaxNumberOfIterationsMinValue_16(base.GetCppThis());
		}

		// Token: 0x0600753C RID: 30012
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCommunity2DLayoutStrategy_GetNumberOfGenerationsFromBase_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600753D RID: 30013 RVA: 0x000A97E8 File Offset: 0x000A79E8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_GetNumberOfGenerationsFromBase_17(base.GetCppThis(), type);
		}

		// Token: 0x0600753E RID: 30014
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCommunity2DLayoutStrategy_GetNumberOfGenerationsFromBaseType_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600753F RID: 30015 RVA: 0x000A9808 File Offset: 0x000A7A08
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_GetNumberOfGenerationsFromBaseType_18(type);
		}

		// Token: 0x06007540 RID: 30016
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunity2DLayoutStrategy_GetRandomSeed_19(HandleRef pThis);

		/// <summary>
		/// Seed the random number generator used to jitter point positions.
		/// This has a significant effect on their final positions when
		/// the layout is complete.
		/// </summary>
		// Token: 0x06007541 RID: 30017 RVA: 0x000A9824 File Offset: 0x000A7A24
		public virtual int GetRandomSeed()
		{
			return vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_GetRandomSeed_19(base.GetCppThis());
		}

		// Token: 0x06007542 RID: 30018
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunity2DLayoutStrategy_GetRandomSeedMaxValue_20(HandleRef pThis);

		/// <summary>
		/// Seed the random number generator used to jitter point positions.
		/// This has a significant effect on their final positions when
		/// the layout is complete.
		/// </summary>
		// Token: 0x06007543 RID: 30019 RVA: 0x000A9844 File Offset: 0x000A7A44
		public virtual int GetRandomSeedMaxValue()
		{
			return vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_GetRandomSeedMaxValue_20(base.GetCppThis());
		}

		// Token: 0x06007544 RID: 30020
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunity2DLayoutStrategy_GetRandomSeedMinValue_21(HandleRef pThis);

		/// <summary>
		/// Seed the random number generator used to jitter point positions.
		/// This has a significant effect on their final positions when
		/// the layout is complete.
		/// </summary>
		// Token: 0x06007545 RID: 30021 RVA: 0x000A9864 File Offset: 0x000A7A64
		public virtual int GetRandomSeedMinValue()
		{
			return vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_GetRandomSeedMinValue_21(base.GetCppThis());
		}

		// Token: 0x06007546 RID: 30022
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkCommunity2DLayoutStrategy_GetRestDistance_22(HandleRef pThis);

		/// <summary>
		/// Manually set the resting distance. Otherwise the
		/// distance is computed automatically.
		/// </summary>
		// Token: 0x06007547 RID: 30023 RVA: 0x000A9884 File Offset: 0x000A7A84
		public virtual float GetRestDistance()
		{
			return vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_GetRestDistance_22(base.GetCppThis());
		}

		// Token: 0x06007548 RID: 30024
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCommunity2DLayoutStrategy_Initialize_23(HandleRef pThis);

		/// <summary>
		/// This strategy sets up some data structures
		/// for faster processing of each Layout() call
		/// </summary>
		// Token: 0x06007549 RID: 30025 RVA: 0x000A98A3 File Offset: 0x000A7AA3
		public override void Initialize()
		{
			vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_Initialize_23(base.GetCppThis());
		}

		// Token: 0x0600754A RID: 30026
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunity2DLayoutStrategy_IsA_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600754B RID: 30027 RVA: 0x000A98B4 File Offset: 0x000A7AB4
		public override int IsA(string type)
		{
			return vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_IsA_24(base.GetCppThis(), type);
		}

		// Token: 0x0600754C RID: 30028
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunity2DLayoutStrategy_IsLayoutComplete_25(HandleRef pThis);

		/// <summary>
		/// I'm an iterative layout so this method lets the caller
		/// know if I'm done laying out the graph
		/// </summary>
		// Token: 0x0600754D RID: 30029 RVA: 0x000A98D4 File Offset: 0x000A7AD4
		public override int IsLayoutComplete()
		{
			return vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_IsLayoutComplete_25(base.GetCppThis());
		}

		// Token: 0x0600754E RID: 30030
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunity2DLayoutStrategy_IsTypeOf_26([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600754F RID: 30031 RVA: 0x000A98F4 File Offset: 0x000A7AF4
		public new static int IsTypeOf(string type)
		{
			return vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_IsTypeOf_26(type);
		}

		// Token: 0x06007550 RID: 30032
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCommunity2DLayoutStrategy_Layout_27(HandleRef pThis);

		/// <summary>
		/// This is the layout method where the graph that was
		/// set in SetGraph() is laid out. The method can either
		/// entirely layout the graph or iteratively lay out the
		/// graph. If you have an iterative layout please implement
		/// the IsLayoutComplete() method.
		/// </summary>
		// Token: 0x06007551 RID: 30033 RVA: 0x000A990E File Offset: 0x000A7B0E
		public override void Layout()
		{
			vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_Layout_27(base.GetCppThis());
		}

		// Token: 0x06007552 RID: 30034
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCommunity2DLayoutStrategy_NewInstance_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007553 RID: 30035 RVA: 0x000A9920 File Offset: 0x000A7B20
		public new vtkCommunity2DLayoutStrategy NewInstance()
		{
			vtkCommunity2DLayoutStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_NewInstance_29(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCommunity2DLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06007554 RID: 30036
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCommunity2DLayoutStrategy_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007555 RID: 30037 RVA: 0x000A997C File Offset: 0x000A7B7C
		public new static vtkCommunity2DLayoutStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkCommunity2DLayoutStrategy vtkCommunity2DLayoutStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_SafeDownCast_30((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCommunity2DLayoutStrategy = (vtkCommunity2DLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCommunity2DLayoutStrategy.Register(null);
				}
			}
			return vtkCommunity2DLayoutStrategy;
		}

		// Token: 0x06007556 RID: 30038
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCommunity2DLayoutStrategy_SetCommunityArrayName_31(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Get/Set the community array name
		/// </summary>
		// Token: 0x06007557 RID: 30039 RVA: 0x000A99FB File Offset: 0x000A7BFB
		public virtual void SetCommunityArrayName(string _arg)
		{
			vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_SetCommunityArrayName_31(base.GetCppThis(), _arg);
		}

		// Token: 0x06007558 RID: 30040
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCommunity2DLayoutStrategy_SetCommunityStrength_32(HandleRef pThis, float _arg);

		/// <summary>
		/// Set the community 'strength'.  The default is '1'
		/// which means vertices in the same community will be
		/// placed close together, values closer to .1 (minimum)
		/// will mean a layout closer to traditional force directed.
		/// </summary>
		// Token: 0x06007559 RID: 30041 RVA: 0x000A9A0B File Offset: 0x000A7C0B
		public virtual void SetCommunityStrength(float _arg)
		{
			vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_SetCommunityStrength_32(base.GetCppThis(), _arg);
		}

		// Token: 0x0600755A RID: 30042
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCommunity2DLayoutStrategy_SetCoolDownRate_33(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the Cool-down rate.
		/// The higher this number is, the longer it will take to "cool-down",
		/// and thus, the more the graph will be modified. The default is '10'
		/// for no particular reason.
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x0600755B RID: 30043 RVA: 0x000A9A1B File Offset: 0x000A7C1B
		public virtual void SetCoolDownRate(double _arg)
		{
			vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_SetCoolDownRate_33(base.GetCppThis(), _arg);
		}

		// Token: 0x0600755C RID: 30044
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCommunity2DLayoutStrategy_SetInitialTemperature_34(HandleRef pThis, float _arg);

		/// <summary>
		/// Set the initial temperature.  The temperature default is '5'
		/// for no particular reason
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x0600755D RID: 30045 RVA: 0x000A9A2B File Offset: 0x000A7C2B
		public virtual void SetInitialTemperature(float _arg)
		{
			vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_SetInitialTemperature_34(base.GetCppThis(), _arg);
		}

		// Token: 0x0600755E RID: 30046
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCommunity2DLayoutStrategy_SetIterationsPerLayout_35(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the number of iterations per layout.
		/// The only use for this ivar is for the application
		/// to do visualizations of the layout before it's complete.
		/// The default is '100' to match the default 'MaxNumberOfIterations'
		/// Note: Changing this parameter is just fine :)
		/// </summary>
		// Token: 0x0600755F RID: 30047 RVA: 0x000A9A3B File Offset: 0x000A7C3B
		public virtual void SetIterationsPerLayout(int _arg)
		{
			vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_SetIterationsPerLayout_35(base.GetCppThis(), _arg);
		}

		// Token: 0x06007560 RID: 30048
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCommunity2DLayoutStrategy_SetMaxNumberOfIterations_36(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the maximum number of iterations to be used.
		/// The higher this number, the more iterations through the algorithm
		/// is possible, and thus, the more the graph gets modified.
		/// The default is '100' for no particular reason
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x06007561 RID: 30049 RVA: 0x000A9A4B File Offset: 0x000A7C4B
		public virtual void SetMaxNumberOfIterations(int _arg)
		{
			vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_SetMaxNumberOfIterations_36(base.GetCppThis(), _arg);
		}

		// Token: 0x06007562 RID: 30050
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCommunity2DLayoutStrategy_SetRandomSeed_37(HandleRef pThis, int _arg);

		/// <summary>
		/// Seed the random number generator used to jitter point positions.
		/// This has a significant effect on their final positions when
		/// the layout is complete.
		/// </summary>
		// Token: 0x06007563 RID: 30051 RVA: 0x000A9A5B File Offset: 0x000A7C5B
		public virtual void SetRandomSeed(int _arg)
		{
			vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_SetRandomSeed_37(base.GetCppThis(), _arg);
		}

		// Token: 0x06007564 RID: 30052
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCommunity2DLayoutStrategy_SetRestDistance_38(HandleRef pThis, float _arg);

		/// <summary>
		/// Manually set the resting distance. Otherwise the
		/// distance is computed automatically.
		/// </summary>
		// Token: 0x06007565 RID: 30053 RVA: 0x000A9A6B File Offset: 0x000A7C6B
		public virtual void SetRestDistance(float _arg)
		{
			vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_SetRestDistance_38(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A1E RID: 2590
		public new const string MRFullTypeName = "Kitware.VTK.vtkCommunity2DLayoutStrategy";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A1F RID: 2591
		public new static readonly string MRClassNameKey = "class vtkCommunity2DLayoutStrategy";
	}
}
