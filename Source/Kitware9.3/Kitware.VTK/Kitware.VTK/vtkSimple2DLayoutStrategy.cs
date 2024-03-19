using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSimple2DLayoutStrategy
	/// </summary>
	/// <remarks>
	///    a simple 2D graph layout
	///
	///
	/// This class is an implementation of the work presented in:
	/// Fruchterman &amp; Reingold "Graph Drawing by Force-directed Placement"
	/// Software-Practice and Experience 21(11) 1991).
	/// The class includes some optimizations but nothing too fancy.
	///
	/// @par Thanks:
	/// Thanks to Brian Wylie from Sandia National Laboratories for creating this
	/// class.
	/// </remarks>
	// Token: 0x02000298 RID: 664
	public class vtkSimple2DLayoutStrategy : vtkGraphLayoutStrategy
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600780C RID: 30732 RVA: 0x000AD1F1 File Offset: 0x000AB3F1
		static vtkSimple2DLayoutStrategy()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSimple2DLayoutStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSimple2DLayoutStrategy"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600780D RID: 30733 RVA: 0x000AD219 File Offset: 0x000AB419
		public vtkSimple2DLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600780E RID: 30734
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSimple2DLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600780F RID: 30735 RVA: 0x000AD228 File Offset: 0x000AB428
		public new static vtkSimple2DLayoutStrategy New()
		{
			vtkSimple2DLayoutStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSimple2DLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007810 RID: 30736 RVA: 0x000AD27C File Offset: 0x000AB47C
		public vtkSimple2DLayoutStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06007811 RID: 30737 RVA: 0x000AD2C0 File Offset: 0x000AB4C0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06007812 RID: 30738
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSimple2DLayoutStrategy_GetCoolDownRate_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the Cool-down rate.
		/// The higher this number is, the longer it will take to "cool-down",
		/// and thus, the more the graph will be modified. The default is '10'
		/// for no particular reason.
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x06007813 RID: 30739 RVA: 0x000AD2CC File Offset: 0x000AB4CC
		public virtual double GetCoolDownRate()
		{
			return vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_GetCoolDownRate_01(base.GetCppThis());
		}

		// Token: 0x06007814 RID: 30740
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSimple2DLayoutStrategy_GetCoolDownRateMaxValue_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the Cool-down rate.
		/// The higher this number is, the longer it will take to "cool-down",
		/// and thus, the more the graph will be modified. The default is '10'
		/// for no particular reason.
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x06007815 RID: 30741 RVA: 0x000AD2EC File Offset: 0x000AB4EC
		public virtual double GetCoolDownRateMaxValue()
		{
			return vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_GetCoolDownRateMaxValue_02(base.GetCppThis());
		}

		// Token: 0x06007816 RID: 30742
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSimple2DLayoutStrategy_GetCoolDownRateMinValue_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the Cool-down rate.
		/// The higher this number is, the longer it will take to "cool-down",
		/// and thus, the more the graph will be modified. The default is '10'
		/// for no particular reason.
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x06007817 RID: 30743 RVA: 0x000AD30C File Offset: 0x000AB50C
		public virtual double GetCoolDownRateMinValue()
		{
			return vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_GetCoolDownRateMinValue_03(base.GetCppThis());
		}

		// Token: 0x06007818 RID: 30744
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkSimple2DLayoutStrategy_GetInitialTemperature_04(HandleRef pThis);

		/// <summary>
		/// Set the initial temperature.  The temperature default is '5'
		/// for no particular reason
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x06007819 RID: 30745 RVA: 0x000AD32C File Offset: 0x000AB52C
		public virtual float GetInitialTemperature()
		{
			return vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_GetInitialTemperature_04(base.GetCppThis());
		}

		// Token: 0x0600781A RID: 30746
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkSimple2DLayoutStrategy_GetInitialTemperatureMaxValue_05(HandleRef pThis);

		/// <summary>
		/// Set the initial temperature.  The temperature default is '5'
		/// for no particular reason
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x0600781B RID: 30747 RVA: 0x000AD34C File Offset: 0x000AB54C
		public virtual float GetInitialTemperatureMaxValue()
		{
			return vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_GetInitialTemperatureMaxValue_05(base.GetCppThis());
		}

		// Token: 0x0600781C RID: 30748
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkSimple2DLayoutStrategy_GetInitialTemperatureMinValue_06(HandleRef pThis);

		/// <summary>
		/// Set the initial temperature.  The temperature default is '5'
		/// for no particular reason
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x0600781D RID: 30749 RVA: 0x000AD36C File Offset: 0x000AB56C
		public virtual float GetInitialTemperatureMinValue()
		{
			return vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_GetInitialTemperatureMinValue_06(base.GetCppThis());
		}

		// Token: 0x0600781E RID: 30750
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimple2DLayoutStrategy_GetIterationsPerLayout_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of iterations per layout.
		/// The only use for this ivar is for the application
		/// to do visualizations of the layout before it's complete.
		/// The default is '100' to match the default 'MaxNumberOfIterations'
		/// Note: Changing this parameter is just fine :)
		/// </summary>
		// Token: 0x0600781F RID: 30751 RVA: 0x000AD38C File Offset: 0x000AB58C
		public virtual int GetIterationsPerLayout()
		{
			return vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_GetIterationsPerLayout_07(base.GetCppThis());
		}

		// Token: 0x06007820 RID: 30752
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimple2DLayoutStrategy_GetIterationsPerLayoutMaxValue_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of iterations per layout.
		/// The only use for this ivar is for the application
		/// to do visualizations of the layout before it's complete.
		/// The default is '100' to match the default 'MaxNumberOfIterations'
		/// Note: Changing this parameter is just fine :)
		/// </summary>
		// Token: 0x06007821 RID: 30753 RVA: 0x000AD3AC File Offset: 0x000AB5AC
		public virtual int GetIterationsPerLayoutMaxValue()
		{
			return vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_GetIterationsPerLayoutMaxValue_08(base.GetCppThis());
		}

		// Token: 0x06007822 RID: 30754
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimple2DLayoutStrategy_GetIterationsPerLayoutMinValue_09(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of iterations per layout.
		/// The only use for this ivar is for the application
		/// to do visualizations of the layout before it's complete.
		/// The default is '100' to match the default 'MaxNumberOfIterations'
		/// Note: Changing this parameter is just fine :)
		/// </summary>
		// Token: 0x06007823 RID: 30755 RVA: 0x000AD3CC File Offset: 0x000AB5CC
		public virtual int GetIterationsPerLayoutMinValue()
		{
			return vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_GetIterationsPerLayoutMinValue_09(base.GetCppThis());
		}

		// Token: 0x06007824 RID: 30756
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSimple2DLayoutStrategy_GetJitter_10(HandleRef pThis);

		/// <summary>
		/// Set Random jitter of the nodes at initialization
		/// to on or off.
		/// Note: It's strongly recommendation to have jitter ON
		/// even if you have initial coordinates in your graph.
		/// Default is ON
		/// </summary>
		// Token: 0x06007825 RID: 30757 RVA: 0x000AD3EC File Offset: 0x000AB5EC
		public virtual bool GetJitter()
		{
			return vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_GetJitter_10(base.GetCppThis()) != 0;
		}

		// Token: 0x06007826 RID: 30758
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimple2DLayoutStrategy_GetMaxNumberOfIterations_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum number of iterations to be used.
		/// The higher this number, the more iterations through the algorithm
		/// is possible, and thus, the more the graph gets modified.
		/// The default is '100' for no particular reason
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x06007827 RID: 30759 RVA: 0x000AD414 File Offset: 0x000AB614
		public virtual int GetMaxNumberOfIterations()
		{
			return vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_GetMaxNumberOfIterations_11(base.GetCppThis());
		}

		// Token: 0x06007828 RID: 30760
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimple2DLayoutStrategy_GetMaxNumberOfIterationsMaxValue_12(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum number of iterations to be used.
		/// The higher this number, the more iterations through the algorithm
		/// is possible, and thus, the more the graph gets modified.
		/// The default is '100' for no particular reason
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x06007829 RID: 30761 RVA: 0x000AD434 File Offset: 0x000AB634
		public virtual int GetMaxNumberOfIterationsMaxValue()
		{
			return vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_GetMaxNumberOfIterationsMaxValue_12(base.GetCppThis());
		}

		// Token: 0x0600782A RID: 30762
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimple2DLayoutStrategy_GetMaxNumberOfIterationsMinValue_13(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum number of iterations to be used.
		/// The higher this number, the more iterations through the algorithm
		/// is possible, and thus, the more the graph gets modified.
		/// The default is '100' for no particular reason
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x0600782B RID: 30763 RVA: 0x000AD454 File Offset: 0x000AB654
		public virtual int GetMaxNumberOfIterationsMinValue()
		{
			return vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_GetMaxNumberOfIterationsMinValue_13(base.GetCppThis());
		}

		// Token: 0x0600782C RID: 30764
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSimple2DLayoutStrategy_GetNumberOfGenerationsFromBase_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600782D RID: 30765 RVA: 0x000AD474 File Offset: 0x000AB674
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_GetNumberOfGenerationsFromBase_14(base.GetCppThis(), type);
		}

		// Token: 0x0600782E RID: 30766
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSimple2DLayoutStrategy_GetNumberOfGenerationsFromBaseType_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600782F RID: 30767 RVA: 0x000AD494 File Offset: 0x000AB694
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_GetNumberOfGenerationsFromBaseType_15(type);
		}

		// Token: 0x06007830 RID: 30768
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimple2DLayoutStrategy_GetRandomSeed_16(HandleRef pThis);

		/// <summary>
		/// Seed the random number generator used to jitter point positions.
		/// This has a significant effect on their final positions when
		/// the layout is complete.
		/// </summary>
		// Token: 0x06007831 RID: 30769 RVA: 0x000AD4B0 File Offset: 0x000AB6B0
		public virtual int GetRandomSeed()
		{
			return vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_GetRandomSeed_16(base.GetCppThis());
		}

		// Token: 0x06007832 RID: 30770
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimple2DLayoutStrategy_GetRandomSeedMaxValue_17(HandleRef pThis);

		/// <summary>
		/// Seed the random number generator used to jitter point positions.
		/// This has a significant effect on their final positions when
		/// the layout is complete.
		/// </summary>
		// Token: 0x06007833 RID: 30771 RVA: 0x000AD4D0 File Offset: 0x000AB6D0
		public virtual int GetRandomSeedMaxValue()
		{
			return vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_GetRandomSeedMaxValue_17(base.GetCppThis());
		}

		// Token: 0x06007834 RID: 30772
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimple2DLayoutStrategy_GetRandomSeedMinValue_18(HandleRef pThis);

		/// <summary>
		/// Seed the random number generator used to jitter point positions.
		/// This has a significant effect on their final positions when
		/// the layout is complete.
		/// </summary>
		// Token: 0x06007835 RID: 30773 RVA: 0x000AD4F0 File Offset: 0x000AB6F0
		public virtual int GetRandomSeedMinValue()
		{
			return vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_GetRandomSeedMinValue_18(base.GetCppThis());
		}

		// Token: 0x06007836 RID: 30774
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkSimple2DLayoutStrategy_GetRestDistance_19(HandleRef pThis);

		/// <summary>
		/// Manually set the resting distance. Otherwise the
		/// distance is computed automatically.
		/// </summary>
		// Token: 0x06007837 RID: 30775 RVA: 0x000AD510 File Offset: 0x000AB710
		public virtual float GetRestDistance()
		{
			return vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_GetRestDistance_19(base.GetCppThis());
		}

		// Token: 0x06007838 RID: 30776
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimple2DLayoutStrategy_Initialize_20(HandleRef pThis);

		/// <summary>
		/// This strategy sets up some data structures
		/// for faster processing of each Layout() call
		/// </summary>
		// Token: 0x06007839 RID: 30777 RVA: 0x000AD52F File Offset: 0x000AB72F
		public override void Initialize()
		{
			vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_Initialize_20(base.GetCppThis());
		}

		// Token: 0x0600783A RID: 30778
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimple2DLayoutStrategy_IsA_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600783B RID: 30779 RVA: 0x000AD540 File Offset: 0x000AB740
		public override int IsA(string type)
		{
			return vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_IsA_21(base.GetCppThis(), type);
		}

		// Token: 0x0600783C RID: 30780
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimple2DLayoutStrategy_IsLayoutComplete_22(HandleRef pThis);

		/// <summary>
		/// I'm an iterative layout so this method lets the caller
		/// know if I'm done laying out the graph
		/// </summary>
		// Token: 0x0600783D RID: 30781 RVA: 0x000AD560 File Offset: 0x000AB760
		public override int IsLayoutComplete()
		{
			return vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_IsLayoutComplete_22(base.GetCppThis());
		}

		// Token: 0x0600783E RID: 30782
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimple2DLayoutStrategy_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600783F RID: 30783 RVA: 0x000AD580 File Offset: 0x000AB780
		public new static int IsTypeOf(string type)
		{
			return vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_IsTypeOf_23(type);
		}

		// Token: 0x06007840 RID: 30784
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimple2DLayoutStrategy_Layout_24(HandleRef pThis);

		/// <summary>
		/// This is the layout method where the graph that was
		/// set in SetGraph() is laid out. The method can either
		/// entirely layout the graph or iteratively lay out the
		/// graph. If you have an iterative layout please implement
		/// the IsLayoutComplete() method.
		/// </summary>
		// Token: 0x06007841 RID: 30785 RVA: 0x000AD59A File Offset: 0x000AB79A
		public override void Layout()
		{
			vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_Layout_24(base.GetCppThis());
		}

		// Token: 0x06007842 RID: 30786
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSimple2DLayoutStrategy_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007843 RID: 30787 RVA: 0x000AD5AC File Offset: 0x000AB7AC
		public new vtkSimple2DLayoutStrategy NewInstance()
		{
			vtkSimple2DLayoutStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_NewInstance_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSimple2DLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06007844 RID: 30788
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSimple2DLayoutStrategy_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007845 RID: 30789 RVA: 0x000AD608 File Offset: 0x000AB808
		public new static vtkSimple2DLayoutStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkSimple2DLayoutStrategy vtkSimple2DLayoutStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_SafeDownCast_27((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSimple2DLayoutStrategy = (vtkSimple2DLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSimple2DLayoutStrategy.Register(null);
				}
			}
			return vtkSimple2DLayoutStrategy;
		}

		// Token: 0x06007846 RID: 30790
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimple2DLayoutStrategy_SetCoolDownRate_28(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the Cool-down rate.
		/// The higher this number is, the longer it will take to "cool-down",
		/// and thus, the more the graph will be modified. The default is '10'
		/// for no particular reason.
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x06007847 RID: 30791 RVA: 0x000AD687 File Offset: 0x000AB887
		public virtual void SetCoolDownRate(double _arg)
		{
			vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_SetCoolDownRate_28(base.GetCppThis(), _arg);
		}

		// Token: 0x06007848 RID: 30792
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimple2DLayoutStrategy_SetInitialTemperature_29(HandleRef pThis, float _arg);

		/// <summary>
		/// Set the initial temperature.  The temperature default is '5'
		/// for no particular reason
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x06007849 RID: 30793 RVA: 0x000AD697 File Offset: 0x000AB897
		public virtual void SetInitialTemperature(float _arg)
		{
			vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_SetInitialTemperature_29(base.GetCppThis(), _arg);
		}

		// Token: 0x0600784A RID: 30794
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimple2DLayoutStrategy_SetIterationsPerLayout_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the number of iterations per layout.
		/// The only use for this ivar is for the application
		/// to do visualizations of the layout before it's complete.
		/// The default is '100' to match the default 'MaxNumberOfIterations'
		/// Note: Changing this parameter is just fine :)
		/// </summary>
		// Token: 0x0600784B RID: 30795 RVA: 0x000AD6A7 File Offset: 0x000AB8A7
		public virtual void SetIterationsPerLayout(int _arg)
		{
			vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_SetIterationsPerLayout_30(base.GetCppThis(), _arg);
		}

		// Token: 0x0600784C RID: 30796
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimple2DLayoutStrategy_SetJitter_31(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set Random jitter of the nodes at initialization
		/// to on or off.
		/// Note: It's strongly recommendation to have jitter ON
		/// even if you have initial coordinates in your graph.
		/// Default is ON
		/// </summary>
		// Token: 0x0600784D RID: 30797 RVA: 0x000AD6B7 File Offset: 0x000AB8B7
		public virtual void SetJitter(bool _arg)
		{
			vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_SetJitter_31(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600784E RID: 30798
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimple2DLayoutStrategy_SetMaxNumberOfIterations_32(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the maximum number of iterations to be used.
		/// The higher this number, the more iterations through the algorithm
		/// is possible, and thus, the more the graph gets modified.
		/// The default is '100' for no particular reason
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x0600784F RID: 30799 RVA: 0x000AD6CF File Offset: 0x000AB8CF
		public virtual void SetMaxNumberOfIterations(int _arg)
		{
			vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_SetMaxNumberOfIterations_32(base.GetCppThis(), _arg);
		}

		// Token: 0x06007850 RID: 30800
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimple2DLayoutStrategy_SetRandomSeed_33(HandleRef pThis, int _arg);

		/// <summary>
		/// Seed the random number generator used to jitter point positions.
		/// This has a significant effect on their final positions when
		/// the layout is complete.
		/// </summary>
		// Token: 0x06007851 RID: 30801 RVA: 0x000AD6DF File Offset: 0x000AB8DF
		public virtual void SetRandomSeed(int _arg)
		{
			vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_SetRandomSeed_33(base.GetCppThis(), _arg);
		}

		// Token: 0x06007852 RID: 30802
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimple2DLayoutStrategy_SetRestDistance_34(HandleRef pThis, float _arg);

		/// <summary>
		/// Manually set the resting distance. Otherwise the
		/// distance is computed automatically.
		/// </summary>
		// Token: 0x06007853 RID: 30803 RVA: 0x000AD6EF File Offset: 0x000AB8EF
		public virtual void SetRestDistance(float _arg)
		{
			vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_SetRestDistance_34(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A3E RID: 2622
		public new const string MRFullTypeName = "Kitware.VTK.vtkSimple2DLayoutStrategy";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A3F RID: 2623
		public new static readonly string MRClassNameKey = "class vtkSimple2DLayoutStrategy";
	}
}
