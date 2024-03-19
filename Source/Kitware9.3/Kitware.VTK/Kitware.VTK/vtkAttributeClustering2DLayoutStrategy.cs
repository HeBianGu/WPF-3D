using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAttributeClustering2DLayoutStrategy
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
	// Token: 0x0200027F RID: 639
	public class vtkAttributeClustering2DLayoutStrategy : vtkGraphLayoutStrategy
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060073E8 RID: 29672 RVA: 0x000A7953 File Offset: 0x000A5B53
		static vtkAttributeClustering2DLayoutStrategy()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAttributeClustering2DLayoutStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAttributeClustering2DLayoutStrategy"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060073E9 RID: 29673 RVA: 0x000A797B File Offset: 0x000A5B7B
		public vtkAttributeClustering2DLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060073EA RID: 29674
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAttributeClustering2DLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060073EB RID: 29675 RVA: 0x000A798C File Offset: 0x000A5B8C
		public new static vtkAttributeClustering2DLayoutStrategy New()
		{
			vtkAttributeClustering2DLayoutStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAttributeClustering2DLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060073EC RID: 29676 RVA: 0x000A79E0 File Offset: 0x000A5BE0
		public vtkAttributeClustering2DLayoutStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060073ED RID: 29677 RVA: 0x000A7A24 File Offset: 0x000A5C24
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060073EE RID: 29678
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAttributeClustering2DLayoutStrategy_GetCoolDownRate_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the Cool-down rate.
		/// The higher this number is, the longer it will take to "cool-down",
		/// and thus, the more the graph will be modified. The default is '10'
		/// for no particular reason.
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x060073EF RID: 29679 RVA: 0x000A7A30 File Offset: 0x000A5C30
		public virtual double GetCoolDownRate()
		{
			return vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_GetCoolDownRate_01(base.GetCppThis());
		}

		// Token: 0x060073F0 RID: 29680
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAttributeClustering2DLayoutStrategy_GetCoolDownRateMaxValue_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the Cool-down rate.
		/// The higher this number is, the longer it will take to "cool-down",
		/// and thus, the more the graph will be modified. The default is '10'
		/// for no particular reason.
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x060073F1 RID: 29681 RVA: 0x000A7A50 File Offset: 0x000A5C50
		public virtual double GetCoolDownRateMaxValue()
		{
			return vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_GetCoolDownRateMaxValue_02(base.GetCppThis());
		}

		// Token: 0x060073F2 RID: 29682
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAttributeClustering2DLayoutStrategy_GetCoolDownRateMinValue_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the Cool-down rate.
		/// The higher this number is, the longer it will take to "cool-down",
		/// and thus, the more the graph will be modified. The default is '10'
		/// for no particular reason.
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x060073F3 RID: 29683 RVA: 0x000A7A70 File Offset: 0x000A5C70
		public virtual double GetCoolDownRateMinValue()
		{
			return vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_GetCoolDownRateMinValue_03(base.GetCppThis());
		}

		// Token: 0x060073F4 RID: 29684
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkAttributeClustering2DLayoutStrategy_GetInitialTemperature_04(HandleRef pThis);

		/// <summary>
		/// Set the initial temperature.  The temperature default is '5'
		/// for no particular reason
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x060073F5 RID: 29685 RVA: 0x000A7A90 File Offset: 0x000A5C90
		public virtual float GetInitialTemperature()
		{
			return vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_GetInitialTemperature_04(base.GetCppThis());
		}

		// Token: 0x060073F6 RID: 29686
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkAttributeClustering2DLayoutStrategy_GetInitialTemperatureMaxValue_05(HandleRef pThis);

		/// <summary>
		/// Set the initial temperature.  The temperature default is '5'
		/// for no particular reason
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x060073F7 RID: 29687 RVA: 0x000A7AB0 File Offset: 0x000A5CB0
		public virtual float GetInitialTemperatureMaxValue()
		{
			return vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_GetInitialTemperatureMaxValue_05(base.GetCppThis());
		}

		// Token: 0x060073F8 RID: 29688
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkAttributeClustering2DLayoutStrategy_GetInitialTemperatureMinValue_06(HandleRef pThis);

		/// <summary>
		/// Set the initial temperature.  The temperature default is '5'
		/// for no particular reason
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x060073F9 RID: 29689 RVA: 0x000A7AD0 File Offset: 0x000A5CD0
		public virtual float GetInitialTemperatureMinValue()
		{
			return vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_GetInitialTemperatureMinValue_06(base.GetCppThis());
		}

		// Token: 0x060073FA RID: 29690
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAttributeClustering2DLayoutStrategy_GetIterationsPerLayout_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of iterations per layout.
		/// The only use for this ivar is for the application
		/// to do visualizations of the layout before it's complete.
		/// The default is '100' to match the default 'MaxNumberOfIterations'
		/// Note: Changing this parameter is just fine :)
		/// </summary>
		// Token: 0x060073FB RID: 29691 RVA: 0x000A7AF0 File Offset: 0x000A5CF0
		public virtual int GetIterationsPerLayout()
		{
			return vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_GetIterationsPerLayout_07(base.GetCppThis());
		}

		// Token: 0x060073FC RID: 29692
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAttributeClustering2DLayoutStrategy_GetIterationsPerLayoutMaxValue_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of iterations per layout.
		/// The only use for this ivar is for the application
		/// to do visualizations of the layout before it's complete.
		/// The default is '100' to match the default 'MaxNumberOfIterations'
		/// Note: Changing this parameter is just fine :)
		/// </summary>
		// Token: 0x060073FD RID: 29693 RVA: 0x000A7B10 File Offset: 0x000A5D10
		public virtual int GetIterationsPerLayoutMaxValue()
		{
			return vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_GetIterationsPerLayoutMaxValue_08(base.GetCppThis());
		}

		// Token: 0x060073FE RID: 29694
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAttributeClustering2DLayoutStrategy_GetIterationsPerLayoutMinValue_09(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of iterations per layout.
		/// The only use for this ivar is for the application
		/// to do visualizations of the layout before it's complete.
		/// The default is '100' to match the default 'MaxNumberOfIterations'
		/// Note: Changing this parameter is just fine :)
		/// </summary>
		// Token: 0x060073FF RID: 29695 RVA: 0x000A7B30 File Offset: 0x000A5D30
		public virtual int GetIterationsPerLayoutMinValue()
		{
			return vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_GetIterationsPerLayoutMinValue_09(base.GetCppThis());
		}

		// Token: 0x06007400 RID: 29696
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAttributeClustering2DLayoutStrategy_GetMaxNumberOfIterations_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum number of iterations to be used.
		/// The higher this number, the more iterations through the algorithm
		/// is possible, and thus, the more the graph gets modified.
		/// The default is '100' for no particular reason
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x06007401 RID: 29697 RVA: 0x000A7B50 File Offset: 0x000A5D50
		public virtual int GetMaxNumberOfIterations()
		{
			return vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_GetMaxNumberOfIterations_10(base.GetCppThis());
		}

		// Token: 0x06007402 RID: 29698
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAttributeClustering2DLayoutStrategy_GetMaxNumberOfIterationsMaxValue_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum number of iterations to be used.
		/// The higher this number, the more iterations through the algorithm
		/// is possible, and thus, the more the graph gets modified.
		/// The default is '100' for no particular reason
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x06007403 RID: 29699 RVA: 0x000A7B70 File Offset: 0x000A5D70
		public virtual int GetMaxNumberOfIterationsMaxValue()
		{
			return vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_GetMaxNumberOfIterationsMaxValue_11(base.GetCppThis());
		}

		// Token: 0x06007404 RID: 29700
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAttributeClustering2DLayoutStrategy_GetMaxNumberOfIterationsMinValue_12(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum number of iterations to be used.
		/// The higher this number, the more iterations through the algorithm
		/// is possible, and thus, the more the graph gets modified.
		/// The default is '100' for no particular reason
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x06007405 RID: 29701 RVA: 0x000A7B90 File Offset: 0x000A5D90
		public virtual int GetMaxNumberOfIterationsMinValue()
		{
			return vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_GetMaxNumberOfIterationsMinValue_12(base.GetCppThis());
		}

		// Token: 0x06007406 RID: 29702
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAttributeClustering2DLayoutStrategy_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007407 RID: 29703 RVA: 0x000A7BB0 File Offset: 0x000A5DB0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x06007408 RID: 29704
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAttributeClustering2DLayoutStrategy_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007409 RID: 29705 RVA: 0x000A7BD0 File Offset: 0x000A5DD0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x0600740A RID: 29706
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAttributeClustering2DLayoutStrategy_GetRandomSeed_15(HandleRef pThis);

		/// <summary>
		/// Seed the random number generator used to jitter point positions.
		/// This has a significant effect on their final positions when
		/// the layout is complete.
		/// </summary>
		// Token: 0x0600740B RID: 29707 RVA: 0x000A7BEC File Offset: 0x000A5DEC
		public virtual int GetRandomSeed()
		{
			return vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_GetRandomSeed_15(base.GetCppThis());
		}

		// Token: 0x0600740C RID: 29708
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAttributeClustering2DLayoutStrategy_GetRandomSeedMaxValue_16(HandleRef pThis);

		/// <summary>
		/// Seed the random number generator used to jitter point positions.
		/// This has a significant effect on their final positions when
		/// the layout is complete.
		/// </summary>
		// Token: 0x0600740D RID: 29709 RVA: 0x000A7C0C File Offset: 0x000A5E0C
		public virtual int GetRandomSeedMaxValue()
		{
			return vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_GetRandomSeedMaxValue_16(base.GetCppThis());
		}

		// Token: 0x0600740E RID: 29710
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAttributeClustering2DLayoutStrategy_GetRandomSeedMinValue_17(HandleRef pThis);

		/// <summary>
		/// Seed the random number generator used to jitter point positions.
		/// This has a significant effect on their final positions when
		/// the layout is complete.
		/// </summary>
		// Token: 0x0600740F RID: 29711 RVA: 0x000A7C2C File Offset: 0x000A5E2C
		public virtual int GetRandomSeedMinValue()
		{
			return vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_GetRandomSeedMinValue_17(base.GetCppThis());
		}

		// Token: 0x06007410 RID: 29712
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkAttributeClustering2DLayoutStrategy_GetRestDistance_18(HandleRef pThis);

		/// <summary>
		/// Manually set the resting distance. Otherwise the
		/// distance is computed automatically.
		/// </summary>
		// Token: 0x06007411 RID: 29713 RVA: 0x000A7C4C File Offset: 0x000A5E4C
		public virtual float GetRestDistance()
		{
			return vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_GetRestDistance_18(base.GetCppThis());
		}

		// Token: 0x06007412 RID: 29714
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAttributeClustering2DLayoutStrategy_GetVertexAttribute_19(HandleRef pThis);

		/// <summary>
		/// The name of the array on the vertices, whose values will be used for
		/// determining clusters.
		/// </summary>
		// Token: 0x06007413 RID: 29715 RVA: 0x000A7C6C File Offset: 0x000A5E6C
		public virtual string GetVertexAttribute()
		{
			string s = Marshal.PtrToStringAnsi(vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_GetVertexAttribute_19(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06007414 RID: 29716
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAttributeClustering2DLayoutStrategy_Initialize_20(HandleRef pThis);

		/// <summary>
		/// This strategy sets up some data structures
		/// for faster processing of each Layout() call
		/// </summary>
		// Token: 0x06007415 RID: 29717 RVA: 0x000A7CA6 File Offset: 0x000A5EA6
		public override void Initialize()
		{
			vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_Initialize_20(base.GetCppThis());
		}

		// Token: 0x06007416 RID: 29718
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAttributeClustering2DLayoutStrategy_IsA_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007417 RID: 29719 RVA: 0x000A7CB8 File Offset: 0x000A5EB8
		public override int IsA(string type)
		{
			return vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_IsA_21(base.GetCppThis(), type);
		}

		// Token: 0x06007418 RID: 29720
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAttributeClustering2DLayoutStrategy_IsLayoutComplete_22(HandleRef pThis);

		/// <summary>
		/// I'm an iterative layout so this method lets the caller
		/// know if I'm done laying out the graph
		/// </summary>
		// Token: 0x06007419 RID: 29721 RVA: 0x000A7CD8 File Offset: 0x000A5ED8
		public override int IsLayoutComplete()
		{
			return vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_IsLayoutComplete_22(base.GetCppThis());
		}

		// Token: 0x0600741A RID: 29722
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAttributeClustering2DLayoutStrategy_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600741B RID: 29723 RVA: 0x000A7CF8 File Offset: 0x000A5EF8
		public new static int IsTypeOf(string type)
		{
			return vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_IsTypeOf_23(type);
		}

		// Token: 0x0600741C RID: 29724
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAttributeClustering2DLayoutStrategy_Layout_24(HandleRef pThis);

		/// <summary>
		/// This is the layout method where the graph that was
		/// set in SetGraph() is laid out. The method can either
		/// entirely layout the graph or iteratively lay out the
		/// graph. If you have an iterative layout please implement
		/// the IsLayoutComplete() method.
		/// </summary>
		// Token: 0x0600741D RID: 29725 RVA: 0x000A7D12 File Offset: 0x000A5F12
		public override void Layout()
		{
			vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_Layout_24(base.GetCppThis());
		}

		// Token: 0x0600741E RID: 29726
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAttributeClustering2DLayoutStrategy_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600741F RID: 29727 RVA: 0x000A7D24 File Offset: 0x000A5F24
		public new vtkAttributeClustering2DLayoutStrategy NewInstance()
		{
			vtkAttributeClustering2DLayoutStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_NewInstance_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAttributeClustering2DLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06007420 RID: 29728
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAttributeClustering2DLayoutStrategy_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007421 RID: 29729 RVA: 0x000A7D80 File Offset: 0x000A5F80
		public new static vtkAttributeClustering2DLayoutStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkAttributeClustering2DLayoutStrategy vtkAttributeClustering2DLayoutStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_SafeDownCast_27((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAttributeClustering2DLayoutStrategy = (vtkAttributeClustering2DLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAttributeClustering2DLayoutStrategy.Register(null);
				}
			}
			return vtkAttributeClustering2DLayoutStrategy;
		}

		// Token: 0x06007422 RID: 29730
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAttributeClustering2DLayoutStrategy_SetCoolDownRate_28(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the Cool-down rate.
		/// The higher this number is, the longer it will take to "cool-down",
		/// and thus, the more the graph will be modified. The default is '10'
		/// for no particular reason.
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x06007423 RID: 29731 RVA: 0x000A7DFF File Offset: 0x000A5FFF
		public virtual void SetCoolDownRate(double _arg)
		{
			vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_SetCoolDownRate_28(base.GetCppThis(), _arg);
		}

		// Token: 0x06007424 RID: 29732
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAttributeClustering2DLayoutStrategy_SetInitialTemperature_29(HandleRef pThis, float _arg);

		/// <summary>
		/// Set the initial temperature.  The temperature default is '5'
		/// for no particular reason
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x06007425 RID: 29733 RVA: 0x000A7E0F File Offset: 0x000A600F
		public virtual void SetInitialTemperature(float _arg)
		{
			vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_SetInitialTemperature_29(base.GetCppThis(), _arg);
		}

		// Token: 0x06007426 RID: 29734
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAttributeClustering2DLayoutStrategy_SetIterationsPerLayout_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the number of iterations per layout.
		/// The only use for this ivar is for the application
		/// to do visualizations of the layout before it's complete.
		/// The default is '100' to match the default 'MaxNumberOfIterations'
		/// Note: Changing this parameter is just fine :)
		/// </summary>
		// Token: 0x06007427 RID: 29735 RVA: 0x000A7E1F File Offset: 0x000A601F
		public virtual void SetIterationsPerLayout(int _arg)
		{
			vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_SetIterationsPerLayout_30(base.GetCppThis(), _arg);
		}

		// Token: 0x06007428 RID: 29736
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAttributeClustering2DLayoutStrategy_SetMaxNumberOfIterations_31(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the maximum number of iterations to be used.
		/// The higher this number, the more iterations through the algorithm
		/// is possible, and thus, the more the graph gets modified.
		/// The default is '100' for no particular reason
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x06007429 RID: 29737 RVA: 0x000A7E2F File Offset: 0x000A602F
		public virtual void SetMaxNumberOfIterations(int _arg)
		{
			vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_SetMaxNumberOfIterations_31(base.GetCppThis(), _arg);
		}

		// Token: 0x0600742A RID: 29738
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAttributeClustering2DLayoutStrategy_SetRandomSeed_32(HandleRef pThis, int _arg);

		/// <summary>
		/// Seed the random number generator used to jitter point positions.
		/// This has a significant effect on their final positions when
		/// the layout is complete.
		/// </summary>
		// Token: 0x0600742B RID: 29739 RVA: 0x000A7E3F File Offset: 0x000A603F
		public virtual void SetRandomSeed(int _arg)
		{
			vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_SetRandomSeed_32(base.GetCppThis(), _arg);
		}

		// Token: 0x0600742C RID: 29740
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAttributeClustering2DLayoutStrategy_SetRestDistance_33(HandleRef pThis, float _arg);

		/// <summary>
		/// Manually set the resting distance. Otherwise the
		/// distance is computed automatically.
		/// </summary>
		// Token: 0x0600742D RID: 29741 RVA: 0x000A7E4F File Offset: 0x000A604F
		public virtual void SetRestDistance(float _arg)
		{
			vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_SetRestDistance_33(base.GetCppThis(), _arg);
		}

		// Token: 0x0600742E RID: 29742
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAttributeClustering2DLayoutStrategy_SetVertexAttribute_34(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// The name of the array on the vertices, whose values will be used for
		/// determining clusters.
		/// </summary>
		// Token: 0x0600742F RID: 29743 RVA: 0x000A7E5F File Offset: 0x000A605F
		public void SetVertexAttribute(string arg0)
		{
			vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_SetVertexAttribute_34(base.GetCppThis(), arg0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A0C RID: 2572
		public new const string MRFullTypeName = "Kitware.VTK.vtkAttributeClustering2DLayoutStrategy";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A0D RID: 2573
		public new static readonly string MRClassNameKey = "class vtkAttributeClustering2DLayoutStrategy";
	}
}
