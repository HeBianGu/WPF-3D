using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkFast2DLayoutStrategy
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
	// Token: 0x0200028D RID: 653
	public class vtkFast2DLayoutStrategy : vtkGraphLayoutStrategy
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06007612 RID: 30226 RVA: 0x000AA8AF File Offset: 0x000A8AAF
		static vtkFast2DLayoutStrategy()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFast2DLayoutStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFast2DLayoutStrategy"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06007613 RID: 30227 RVA: 0x000AA8D7 File Offset: 0x000A8AD7
		public vtkFast2DLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06007614 RID: 30228
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFast2DLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007615 RID: 30229 RVA: 0x000AA8E8 File Offset: 0x000A8AE8
		public new static vtkFast2DLayoutStrategy New()
		{
			vtkFast2DLayoutStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFast2DLayoutStrategy.vtkFast2DLayoutStrategy_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFast2DLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007616 RID: 30230 RVA: 0x000AA93C File Offset: 0x000A8B3C
		public vtkFast2DLayoutStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkFast2DLayoutStrategy.vtkFast2DLayoutStrategy_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06007617 RID: 30231 RVA: 0x000AA980 File Offset: 0x000A8B80
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06007618 RID: 30232
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkFast2DLayoutStrategy_GetCoolDownRate_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the Cool-down rate.
		/// The higher this number is, the longer it will take to "cool-down",
		/// and thus, the more the graph will be modified. The default is '10'
		/// for no particular reason.
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x06007619 RID: 30233 RVA: 0x000AA98C File Offset: 0x000A8B8C
		public virtual double GetCoolDownRate()
		{
			return vtkFast2DLayoutStrategy.vtkFast2DLayoutStrategy_GetCoolDownRate_01(base.GetCppThis());
		}

		// Token: 0x0600761A RID: 30234
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkFast2DLayoutStrategy_GetCoolDownRateMaxValue_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the Cool-down rate.
		/// The higher this number is, the longer it will take to "cool-down",
		/// and thus, the more the graph will be modified. The default is '10'
		/// for no particular reason.
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x0600761B RID: 30235 RVA: 0x000AA9AC File Offset: 0x000A8BAC
		public virtual double GetCoolDownRateMaxValue()
		{
			return vtkFast2DLayoutStrategy.vtkFast2DLayoutStrategy_GetCoolDownRateMaxValue_02(base.GetCppThis());
		}

		// Token: 0x0600761C RID: 30236
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkFast2DLayoutStrategy_GetCoolDownRateMinValue_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the Cool-down rate.
		/// The higher this number is, the longer it will take to "cool-down",
		/// and thus, the more the graph will be modified. The default is '10'
		/// for no particular reason.
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x0600761D RID: 30237 RVA: 0x000AA9CC File Offset: 0x000A8BCC
		public virtual double GetCoolDownRateMinValue()
		{
			return vtkFast2DLayoutStrategy.vtkFast2DLayoutStrategy_GetCoolDownRateMinValue_03(base.GetCppThis());
		}

		// Token: 0x0600761E RID: 30238
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkFast2DLayoutStrategy_GetInitialTemperature_04(HandleRef pThis);

		/// <summary>
		/// Set the initial temperature.  The temperature default is '5'
		/// for no particular reason
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x0600761F RID: 30239 RVA: 0x000AA9EC File Offset: 0x000A8BEC
		public virtual float GetInitialTemperature()
		{
			return vtkFast2DLayoutStrategy.vtkFast2DLayoutStrategy_GetInitialTemperature_04(base.GetCppThis());
		}

		// Token: 0x06007620 RID: 30240
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkFast2DLayoutStrategy_GetInitialTemperatureMaxValue_05(HandleRef pThis);

		/// <summary>
		/// Set the initial temperature.  The temperature default is '5'
		/// for no particular reason
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x06007621 RID: 30241 RVA: 0x000AAA0C File Offset: 0x000A8C0C
		public virtual float GetInitialTemperatureMaxValue()
		{
			return vtkFast2DLayoutStrategy.vtkFast2DLayoutStrategy_GetInitialTemperatureMaxValue_05(base.GetCppThis());
		}

		// Token: 0x06007622 RID: 30242
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkFast2DLayoutStrategy_GetInitialTemperatureMinValue_06(HandleRef pThis);

		/// <summary>
		/// Set the initial temperature.  The temperature default is '5'
		/// for no particular reason
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x06007623 RID: 30243 RVA: 0x000AAA2C File Offset: 0x000A8C2C
		public virtual float GetInitialTemperatureMinValue()
		{
			return vtkFast2DLayoutStrategy.vtkFast2DLayoutStrategy_GetInitialTemperatureMinValue_06(base.GetCppThis());
		}

		// Token: 0x06007624 RID: 30244
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFast2DLayoutStrategy_GetIterationsPerLayout_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of iterations per layout.
		/// The only use for this ivar is for the application
		/// to do visualizations of the layout before it's complete.
		/// The default is '100' to match the default 'MaxNumberOfIterations'
		/// Note: Changing this parameter is just fine :)
		/// </summary>
		// Token: 0x06007625 RID: 30245 RVA: 0x000AAA4C File Offset: 0x000A8C4C
		public virtual int GetIterationsPerLayout()
		{
			return vtkFast2DLayoutStrategy.vtkFast2DLayoutStrategy_GetIterationsPerLayout_07(base.GetCppThis());
		}

		// Token: 0x06007626 RID: 30246
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFast2DLayoutStrategy_GetIterationsPerLayoutMaxValue_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of iterations per layout.
		/// The only use for this ivar is for the application
		/// to do visualizations of the layout before it's complete.
		/// The default is '100' to match the default 'MaxNumberOfIterations'
		/// Note: Changing this parameter is just fine :)
		/// </summary>
		// Token: 0x06007627 RID: 30247 RVA: 0x000AAA6C File Offset: 0x000A8C6C
		public virtual int GetIterationsPerLayoutMaxValue()
		{
			return vtkFast2DLayoutStrategy.vtkFast2DLayoutStrategy_GetIterationsPerLayoutMaxValue_08(base.GetCppThis());
		}

		// Token: 0x06007628 RID: 30248
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFast2DLayoutStrategy_GetIterationsPerLayoutMinValue_09(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of iterations per layout.
		/// The only use for this ivar is for the application
		/// to do visualizations of the layout before it's complete.
		/// The default is '100' to match the default 'MaxNumberOfIterations'
		/// Note: Changing this parameter is just fine :)
		/// </summary>
		// Token: 0x06007629 RID: 30249 RVA: 0x000AAA8C File Offset: 0x000A8C8C
		public virtual int GetIterationsPerLayoutMinValue()
		{
			return vtkFast2DLayoutStrategy.vtkFast2DLayoutStrategy_GetIterationsPerLayoutMinValue_09(base.GetCppThis());
		}

		// Token: 0x0600762A RID: 30250
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFast2DLayoutStrategy_GetMaxNumberOfIterations_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum number of iterations to be used.
		/// The higher this number, the more iterations through the algorithm
		/// is possible, and thus, the more the graph gets modified.
		/// The default is '100' for no particular reason
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x0600762B RID: 30251 RVA: 0x000AAAAC File Offset: 0x000A8CAC
		public virtual int GetMaxNumberOfIterations()
		{
			return vtkFast2DLayoutStrategy.vtkFast2DLayoutStrategy_GetMaxNumberOfIterations_10(base.GetCppThis());
		}

		// Token: 0x0600762C RID: 30252
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFast2DLayoutStrategy_GetMaxNumberOfIterationsMaxValue_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum number of iterations to be used.
		/// The higher this number, the more iterations through the algorithm
		/// is possible, and thus, the more the graph gets modified.
		/// The default is '100' for no particular reason
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x0600762D RID: 30253 RVA: 0x000AAACC File Offset: 0x000A8CCC
		public virtual int GetMaxNumberOfIterationsMaxValue()
		{
			return vtkFast2DLayoutStrategy.vtkFast2DLayoutStrategy_GetMaxNumberOfIterationsMaxValue_11(base.GetCppThis());
		}

		// Token: 0x0600762E RID: 30254
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFast2DLayoutStrategy_GetMaxNumberOfIterationsMinValue_12(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum number of iterations to be used.
		/// The higher this number, the more iterations through the algorithm
		/// is possible, and thus, the more the graph gets modified.
		/// The default is '100' for no particular reason
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x0600762F RID: 30255 RVA: 0x000AAAEC File Offset: 0x000A8CEC
		public virtual int GetMaxNumberOfIterationsMinValue()
		{
			return vtkFast2DLayoutStrategy.vtkFast2DLayoutStrategy_GetMaxNumberOfIterationsMinValue_12(base.GetCppThis());
		}

		// Token: 0x06007630 RID: 30256
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFast2DLayoutStrategy_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007631 RID: 30257 RVA: 0x000AAB0C File Offset: 0x000A8D0C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkFast2DLayoutStrategy.vtkFast2DLayoutStrategy_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x06007632 RID: 30258
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFast2DLayoutStrategy_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007633 RID: 30259 RVA: 0x000AAB2C File Offset: 0x000A8D2C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkFast2DLayoutStrategy.vtkFast2DLayoutStrategy_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x06007634 RID: 30260
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFast2DLayoutStrategy_GetRandomSeed_15(HandleRef pThis);

		/// <summary>
		/// Seed the random number generator used to jitter point positions.
		/// This has a significant effect on their final positions when
		/// the layout is complete.
		/// </summary>
		// Token: 0x06007635 RID: 30261 RVA: 0x000AAB48 File Offset: 0x000A8D48
		public virtual int GetRandomSeed()
		{
			return vtkFast2DLayoutStrategy.vtkFast2DLayoutStrategy_GetRandomSeed_15(base.GetCppThis());
		}

		// Token: 0x06007636 RID: 30262
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFast2DLayoutStrategy_GetRandomSeedMaxValue_16(HandleRef pThis);

		/// <summary>
		/// Seed the random number generator used to jitter point positions.
		/// This has a significant effect on their final positions when
		/// the layout is complete.
		/// </summary>
		// Token: 0x06007637 RID: 30263 RVA: 0x000AAB68 File Offset: 0x000A8D68
		public virtual int GetRandomSeedMaxValue()
		{
			return vtkFast2DLayoutStrategy.vtkFast2DLayoutStrategy_GetRandomSeedMaxValue_16(base.GetCppThis());
		}

		// Token: 0x06007638 RID: 30264
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFast2DLayoutStrategy_GetRandomSeedMinValue_17(HandleRef pThis);

		/// <summary>
		/// Seed the random number generator used to jitter point positions.
		/// This has a significant effect on their final positions when
		/// the layout is complete.
		/// </summary>
		// Token: 0x06007639 RID: 30265 RVA: 0x000AAB88 File Offset: 0x000A8D88
		public virtual int GetRandomSeedMinValue()
		{
			return vtkFast2DLayoutStrategy.vtkFast2DLayoutStrategy_GetRandomSeedMinValue_17(base.GetCppThis());
		}

		// Token: 0x0600763A RID: 30266
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkFast2DLayoutStrategy_GetRestDistance_18(HandleRef pThis);

		/// <summary>
		/// Manually set the resting distance. Otherwise the
		/// distance is computed automatically.
		/// </summary>
		// Token: 0x0600763B RID: 30267 RVA: 0x000AABA8 File Offset: 0x000A8DA8
		public virtual float GetRestDistance()
		{
			return vtkFast2DLayoutStrategy.vtkFast2DLayoutStrategy_GetRestDistance_18(base.GetCppThis());
		}

		// Token: 0x0600763C RID: 30268
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFast2DLayoutStrategy_Initialize_19(HandleRef pThis);

		/// <summary>
		/// This strategy sets up some data structures
		/// for faster processing of each Layout() call
		/// </summary>
		// Token: 0x0600763D RID: 30269 RVA: 0x000AABC7 File Offset: 0x000A8DC7
		public override void Initialize()
		{
			vtkFast2DLayoutStrategy.vtkFast2DLayoutStrategy_Initialize_19(base.GetCppThis());
		}

		// Token: 0x0600763E RID: 30270
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFast2DLayoutStrategy_IsA_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600763F RID: 30271 RVA: 0x000AABD8 File Offset: 0x000A8DD8
		public override int IsA(string type)
		{
			return vtkFast2DLayoutStrategy.vtkFast2DLayoutStrategy_IsA_20(base.GetCppThis(), type);
		}

		// Token: 0x06007640 RID: 30272
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFast2DLayoutStrategy_IsLayoutComplete_21(HandleRef pThis);

		/// <summary>
		/// I'm an iterative layout so this method lets the caller
		/// know if I'm done laying out the graph
		/// </summary>
		// Token: 0x06007641 RID: 30273 RVA: 0x000AABF8 File Offset: 0x000A8DF8
		public override int IsLayoutComplete()
		{
			return vtkFast2DLayoutStrategy.vtkFast2DLayoutStrategy_IsLayoutComplete_21(base.GetCppThis());
		}

		// Token: 0x06007642 RID: 30274
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFast2DLayoutStrategy_IsTypeOf_22([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007643 RID: 30275 RVA: 0x000AAC18 File Offset: 0x000A8E18
		public new static int IsTypeOf(string type)
		{
			return vtkFast2DLayoutStrategy.vtkFast2DLayoutStrategy_IsTypeOf_22(type);
		}

		// Token: 0x06007644 RID: 30276
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFast2DLayoutStrategy_Layout_23(HandleRef pThis);

		/// <summary>
		/// This is the layout method where the graph that was
		/// set in SetGraph() is laid out. The method can either
		/// entirely layout the graph or iteratively lay out the
		/// graph. If you have an iterative layout please implement
		/// the IsLayoutComplete() method.
		/// </summary>
		// Token: 0x06007645 RID: 30277 RVA: 0x000AAC32 File Offset: 0x000A8E32
		public override void Layout()
		{
			vtkFast2DLayoutStrategy.vtkFast2DLayoutStrategy_Layout_23(base.GetCppThis());
		}

		// Token: 0x06007646 RID: 30278
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFast2DLayoutStrategy_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007647 RID: 30279 RVA: 0x000AAC44 File Offset: 0x000A8E44
		public new vtkFast2DLayoutStrategy NewInstance()
		{
			vtkFast2DLayoutStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFast2DLayoutStrategy.vtkFast2DLayoutStrategy_NewInstance_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFast2DLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06007648 RID: 30280
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFast2DLayoutStrategy_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007649 RID: 30281 RVA: 0x000AACA0 File Offset: 0x000A8EA0
		public new static vtkFast2DLayoutStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkFast2DLayoutStrategy vtkFast2DLayoutStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFast2DLayoutStrategy.vtkFast2DLayoutStrategy_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFast2DLayoutStrategy = (vtkFast2DLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFast2DLayoutStrategy.Register(null);
				}
			}
			return vtkFast2DLayoutStrategy;
		}

		// Token: 0x0600764A RID: 30282
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFast2DLayoutStrategy_SetCoolDownRate_27(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the Cool-down rate.
		/// The higher this number is, the longer it will take to "cool-down",
		/// and thus, the more the graph will be modified. The default is '10'
		/// for no particular reason.
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x0600764B RID: 30283 RVA: 0x000AAD1F File Offset: 0x000A8F1F
		public virtual void SetCoolDownRate(double _arg)
		{
			vtkFast2DLayoutStrategy.vtkFast2DLayoutStrategy_SetCoolDownRate_27(base.GetCppThis(), _arg);
		}

		// Token: 0x0600764C RID: 30284
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFast2DLayoutStrategy_SetInitialTemperature_28(HandleRef pThis, float _arg);

		/// <summary>
		/// Set the initial temperature.  The temperature default is '5'
		/// for no particular reason
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x0600764D RID: 30285 RVA: 0x000AAD2F File Offset: 0x000A8F2F
		public virtual void SetInitialTemperature(float _arg)
		{
			vtkFast2DLayoutStrategy.vtkFast2DLayoutStrategy_SetInitialTemperature_28(base.GetCppThis(), _arg);
		}

		// Token: 0x0600764E RID: 30286
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFast2DLayoutStrategy_SetIterationsPerLayout_29(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the number of iterations per layout.
		/// The only use for this ivar is for the application
		/// to do visualizations of the layout before it's complete.
		/// The default is '100' to match the default 'MaxNumberOfIterations'
		/// Note: Changing this parameter is just fine :)
		/// </summary>
		// Token: 0x0600764F RID: 30287 RVA: 0x000AAD3F File Offset: 0x000A8F3F
		public virtual void SetIterationsPerLayout(int _arg)
		{
			vtkFast2DLayoutStrategy.vtkFast2DLayoutStrategy_SetIterationsPerLayout_29(base.GetCppThis(), _arg);
		}

		// Token: 0x06007650 RID: 30288
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFast2DLayoutStrategy_SetMaxNumberOfIterations_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the maximum number of iterations to be used.
		/// The higher this number, the more iterations through the algorithm
		/// is possible, and thus, the more the graph gets modified.
		/// The default is '100' for no particular reason
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x06007651 RID: 30289 RVA: 0x000AAD4F File Offset: 0x000A8F4F
		public virtual void SetMaxNumberOfIterations(int _arg)
		{
			vtkFast2DLayoutStrategy.vtkFast2DLayoutStrategy_SetMaxNumberOfIterations_30(base.GetCppThis(), _arg);
		}

		// Token: 0x06007652 RID: 30290
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFast2DLayoutStrategy_SetRandomSeed_31(HandleRef pThis, int _arg);

		/// <summary>
		/// Seed the random number generator used to jitter point positions.
		/// This has a significant effect on their final positions when
		/// the layout is complete.
		/// </summary>
		// Token: 0x06007653 RID: 30291 RVA: 0x000AAD5F File Offset: 0x000A8F5F
		public virtual void SetRandomSeed(int _arg)
		{
			vtkFast2DLayoutStrategy.vtkFast2DLayoutStrategy_SetRandomSeed_31(base.GetCppThis(), _arg);
		}

		// Token: 0x06007654 RID: 30292
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFast2DLayoutStrategy_SetRestDistance_32(HandleRef pThis, float _arg);

		/// <summary>
		/// Manually set the resting distance. Otherwise the
		/// distance is computed automatically.
		/// </summary>
		// Token: 0x06007655 RID: 30293 RVA: 0x000AAD6F File Offset: 0x000A8F6F
		public virtual void SetRestDistance(float _arg)
		{
			vtkFast2DLayoutStrategy.vtkFast2DLayoutStrategy_SetRestDistance_32(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A28 RID: 2600
		public new const string MRFullTypeName = "Kitware.VTK.vtkFast2DLayoutStrategy";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A29 RID: 2601
		public new static readonly string MRClassNameKey = "class vtkFast2DLayoutStrategy";
	}
}
