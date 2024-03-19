using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkConstrained2DLayoutStrategy
	/// </summary>
	/// <remarks>
	///    a simple fast 2D graph layout
	/// that looks for a 'constraint' array (vtkDoubleArray). Any entry in the
	/// constraint array will indicate the level of impedance a node has to
	/// the force calculations during the layout optimization. The array is
	/// assumed to be normalized between zero and one, with one being totally
	/// constrained, so no force will be applied to the node (i.e. no movement),
	/// and zero being full range of movement (no constraints).
	///
	///
	/// This class is a density grid based force directed layout strategy.
	/// Also please note that 'fast' is relative to quite slow. :)
	/// The layout running time is O(V+E) with an extremely high constant.
	/// @par Thanks:
	/// We would like to thank Mothra for distracting Godzilla while we
	/// wrote this class.
	/// </remarks>
	// Token: 0x0200028A RID: 650
	public class vtkConstrained2DLayoutStrategy : vtkGraphLayoutStrategy
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600758A RID: 30090 RVA: 0x000A9D6B File Offset: 0x000A7F6B
		static vtkConstrained2DLayoutStrategy()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkConstrained2DLayoutStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkConstrained2DLayoutStrategy"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600758B RID: 30091 RVA: 0x000A9D93 File Offset: 0x000A7F93
		public vtkConstrained2DLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600758C RID: 30092
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConstrained2DLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600758D RID: 30093 RVA: 0x000A9DA4 File Offset: 0x000A7FA4
		public new static vtkConstrained2DLayoutStrategy New()
		{
			vtkConstrained2DLayoutStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkConstrained2DLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600758E RID: 30094 RVA: 0x000A9DF8 File Offset: 0x000A7FF8
		public vtkConstrained2DLayoutStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600758F RID: 30095 RVA: 0x000A9E3C File Offset: 0x000A803C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06007590 RID: 30096
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkConstrained2DLayoutStrategy_GetCoolDownRate_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the Cool-down rate.
		/// The higher this number is, the longer it will take to "cool-down",
		/// and thus, the more the graph will be modified. The default is '10'
		/// for no particular reason.
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x06007591 RID: 30097 RVA: 0x000A9E48 File Offset: 0x000A8048
		public virtual double GetCoolDownRate()
		{
			return vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_GetCoolDownRate_01(base.GetCppThis());
		}

		// Token: 0x06007592 RID: 30098
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkConstrained2DLayoutStrategy_GetCoolDownRateMaxValue_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the Cool-down rate.
		/// The higher this number is, the longer it will take to "cool-down",
		/// and thus, the more the graph will be modified. The default is '10'
		/// for no particular reason.
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x06007593 RID: 30099 RVA: 0x000A9E68 File Offset: 0x000A8068
		public virtual double GetCoolDownRateMaxValue()
		{
			return vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_GetCoolDownRateMaxValue_02(base.GetCppThis());
		}

		// Token: 0x06007594 RID: 30100
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkConstrained2DLayoutStrategy_GetCoolDownRateMinValue_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the Cool-down rate.
		/// The higher this number is, the longer it will take to "cool-down",
		/// and thus, the more the graph will be modified. The default is '10'
		/// for no particular reason.
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x06007595 RID: 30101 RVA: 0x000A9E88 File Offset: 0x000A8088
		public virtual double GetCoolDownRateMinValue()
		{
			return vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_GetCoolDownRateMinValue_03(base.GetCppThis());
		}

		// Token: 0x06007596 RID: 30102
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkConstrained2DLayoutStrategy_GetInitialTemperature_04(HandleRef pThis);

		/// <summary>
		/// Set the initial temperature.  The temperature default is '5'
		/// for no particular reason
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x06007597 RID: 30103 RVA: 0x000A9EA8 File Offset: 0x000A80A8
		public virtual float GetInitialTemperature()
		{
			return vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_GetInitialTemperature_04(base.GetCppThis());
		}

		// Token: 0x06007598 RID: 30104
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkConstrained2DLayoutStrategy_GetInitialTemperatureMaxValue_05(HandleRef pThis);

		/// <summary>
		/// Set the initial temperature.  The temperature default is '5'
		/// for no particular reason
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x06007599 RID: 30105 RVA: 0x000A9EC8 File Offset: 0x000A80C8
		public virtual float GetInitialTemperatureMaxValue()
		{
			return vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_GetInitialTemperatureMaxValue_05(base.GetCppThis());
		}

		// Token: 0x0600759A RID: 30106
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkConstrained2DLayoutStrategy_GetInitialTemperatureMinValue_06(HandleRef pThis);

		/// <summary>
		/// Set the initial temperature.  The temperature default is '5'
		/// for no particular reason
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x0600759B RID: 30107 RVA: 0x000A9EE8 File Offset: 0x000A80E8
		public virtual float GetInitialTemperatureMinValue()
		{
			return vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_GetInitialTemperatureMinValue_06(base.GetCppThis());
		}

		// Token: 0x0600759C RID: 30108
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConstrained2DLayoutStrategy_GetInputArrayName_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the input constraint array name. If no input array
		/// name is set then the name 'constraint' is used.
		/// </summary>
		// Token: 0x0600759D RID: 30109 RVA: 0x000A9F08 File Offset: 0x000A8108
		public virtual string GetInputArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_GetInputArrayName_07(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600759E RID: 30110
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConstrained2DLayoutStrategy_GetIterationsPerLayout_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of iterations per layout.
		/// The only use for this ivar is for the application
		/// to do visualizations of the layout before it's complete.
		/// The default is '100' to match the default 'MaxNumberOfIterations'
		/// Note: Changing this parameter is just fine :)
		/// </summary>
		// Token: 0x0600759F RID: 30111 RVA: 0x000A9F44 File Offset: 0x000A8144
		public virtual int GetIterationsPerLayout()
		{
			return vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_GetIterationsPerLayout_08(base.GetCppThis());
		}

		// Token: 0x060075A0 RID: 30112
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConstrained2DLayoutStrategy_GetIterationsPerLayoutMaxValue_09(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of iterations per layout.
		/// The only use for this ivar is for the application
		/// to do visualizations of the layout before it's complete.
		/// The default is '100' to match the default 'MaxNumberOfIterations'
		/// Note: Changing this parameter is just fine :)
		/// </summary>
		// Token: 0x060075A1 RID: 30113 RVA: 0x000A9F64 File Offset: 0x000A8164
		public virtual int GetIterationsPerLayoutMaxValue()
		{
			return vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_GetIterationsPerLayoutMaxValue_09(base.GetCppThis());
		}

		// Token: 0x060075A2 RID: 30114
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConstrained2DLayoutStrategy_GetIterationsPerLayoutMinValue_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of iterations per layout.
		/// The only use for this ivar is for the application
		/// to do visualizations of the layout before it's complete.
		/// The default is '100' to match the default 'MaxNumberOfIterations'
		/// Note: Changing this parameter is just fine :)
		/// </summary>
		// Token: 0x060075A3 RID: 30115 RVA: 0x000A9F84 File Offset: 0x000A8184
		public virtual int GetIterationsPerLayoutMinValue()
		{
			return vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_GetIterationsPerLayoutMinValue_10(base.GetCppThis());
		}

		// Token: 0x060075A4 RID: 30116
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConstrained2DLayoutStrategy_GetMaxNumberOfIterations_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum number of iterations to be used.
		/// The higher this number, the more iterations through the algorithm
		/// is possible, and thus, the more the graph gets modified.
		/// The default is '100' for no particular reason
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x060075A5 RID: 30117 RVA: 0x000A9FA4 File Offset: 0x000A81A4
		public virtual int GetMaxNumberOfIterations()
		{
			return vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_GetMaxNumberOfIterations_11(base.GetCppThis());
		}

		// Token: 0x060075A6 RID: 30118
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConstrained2DLayoutStrategy_GetMaxNumberOfIterationsMaxValue_12(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum number of iterations to be used.
		/// The higher this number, the more iterations through the algorithm
		/// is possible, and thus, the more the graph gets modified.
		/// The default is '100' for no particular reason
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x060075A7 RID: 30119 RVA: 0x000A9FC4 File Offset: 0x000A81C4
		public virtual int GetMaxNumberOfIterationsMaxValue()
		{
			return vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_GetMaxNumberOfIterationsMaxValue_12(base.GetCppThis());
		}

		// Token: 0x060075A8 RID: 30120
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConstrained2DLayoutStrategy_GetMaxNumberOfIterationsMinValue_13(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum number of iterations to be used.
		/// The higher this number, the more iterations through the algorithm
		/// is possible, and thus, the more the graph gets modified.
		/// The default is '100' for no particular reason
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x060075A9 RID: 30121 RVA: 0x000A9FE4 File Offset: 0x000A81E4
		public virtual int GetMaxNumberOfIterationsMinValue()
		{
			return vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_GetMaxNumberOfIterationsMinValue_13(base.GetCppThis());
		}

		// Token: 0x060075AA RID: 30122
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkConstrained2DLayoutStrategy_GetNumberOfGenerationsFromBase_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060075AB RID: 30123 RVA: 0x000AA004 File Offset: 0x000A8204
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_GetNumberOfGenerationsFromBase_14(base.GetCppThis(), type);
		}

		// Token: 0x060075AC RID: 30124
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkConstrained2DLayoutStrategy_GetNumberOfGenerationsFromBaseType_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060075AD RID: 30125 RVA: 0x000AA024 File Offset: 0x000A8224
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_GetNumberOfGenerationsFromBaseType_15(type);
		}

		// Token: 0x060075AE RID: 30126
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConstrained2DLayoutStrategy_GetRandomSeed_16(HandleRef pThis);

		/// <summary>
		/// Seed the random number generator used to jitter point positions.
		/// This has a significant effect on their final positions when
		/// the layout is complete.
		/// </summary>
		// Token: 0x060075AF RID: 30127 RVA: 0x000AA040 File Offset: 0x000A8240
		public virtual int GetRandomSeed()
		{
			return vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_GetRandomSeed_16(base.GetCppThis());
		}

		// Token: 0x060075B0 RID: 30128
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConstrained2DLayoutStrategy_GetRandomSeedMaxValue_17(HandleRef pThis);

		/// <summary>
		/// Seed the random number generator used to jitter point positions.
		/// This has a significant effect on their final positions when
		/// the layout is complete.
		/// </summary>
		// Token: 0x060075B1 RID: 30129 RVA: 0x000AA060 File Offset: 0x000A8260
		public virtual int GetRandomSeedMaxValue()
		{
			return vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_GetRandomSeedMaxValue_17(base.GetCppThis());
		}

		// Token: 0x060075B2 RID: 30130
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConstrained2DLayoutStrategy_GetRandomSeedMinValue_18(HandleRef pThis);

		/// <summary>
		/// Seed the random number generator used to jitter point positions.
		/// This has a significant effect on their final positions when
		/// the layout is complete.
		/// </summary>
		// Token: 0x060075B3 RID: 30131 RVA: 0x000AA080 File Offset: 0x000A8280
		public virtual int GetRandomSeedMinValue()
		{
			return vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_GetRandomSeedMinValue_18(base.GetCppThis());
		}

		// Token: 0x060075B4 RID: 30132
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkConstrained2DLayoutStrategy_GetRestDistance_19(HandleRef pThis);

		/// <summary>
		/// Manually set the resting distance. Otherwise the
		/// distance is computed automatically.
		/// </summary>
		// Token: 0x060075B5 RID: 30133 RVA: 0x000AA0A0 File Offset: 0x000A82A0
		public virtual float GetRestDistance()
		{
			return vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_GetRestDistance_19(base.GetCppThis());
		}

		// Token: 0x060075B6 RID: 30134
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrained2DLayoutStrategy_Initialize_20(HandleRef pThis);

		/// <summary>
		/// This strategy sets up some data structures
		/// for faster processing of each Layout() call
		/// </summary>
		// Token: 0x060075B7 RID: 30135 RVA: 0x000AA0BF File Offset: 0x000A82BF
		public override void Initialize()
		{
			vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_Initialize_20(base.GetCppThis());
		}

		// Token: 0x060075B8 RID: 30136
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConstrained2DLayoutStrategy_IsA_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060075B9 RID: 30137 RVA: 0x000AA0D0 File Offset: 0x000A82D0
		public override int IsA(string type)
		{
			return vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_IsA_21(base.GetCppThis(), type);
		}

		// Token: 0x060075BA RID: 30138
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConstrained2DLayoutStrategy_IsLayoutComplete_22(HandleRef pThis);

		/// <summary>
		/// I'm an iterative layout so this method lets the caller
		/// know if I'm done laying out the graph
		/// </summary>
		// Token: 0x060075BB RID: 30139 RVA: 0x000AA0F0 File Offset: 0x000A82F0
		public override int IsLayoutComplete()
		{
			return vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_IsLayoutComplete_22(base.GetCppThis());
		}

		// Token: 0x060075BC RID: 30140
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConstrained2DLayoutStrategy_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060075BD RID: 30141 RVA: 0x000AA110 File Offset: 0x000A8310
		public new static int IsTypeOf(string type)
		{
			return vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_IsTypeOf_23(type);
		}

		// Token: 0x060075BE RID: 30142
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrained2DLayoutStrategy_Layout_24(HandleRef pThis);

		/// <summary>
		/// This is the layout method where the graph that was
		/// set in SetGraph() is laid out. The method can either
		/// entirely layout the graph or iteratively lay out the
		/// graph. If you have an iterative layout please implement
		/// the IsLayoutComplete() method.
		/// </summary>
		// Token: 0x060075BF RID: 30143 RVA: 0x000AA12A File Offset: 0x000A832A
		public override void Layout()
		{
			vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_Layout_24(base.GetCppThis());
		}

		// Token: 0x060075C0 RID: 30144
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConstrained2DLayoutStrategy_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060075C1 RID: 30145 RVA: 0x000AA13C File Offset: 0x000A833C
		public new vtkConstrained2DLayoutStrategy NewInstance()
		{
			vtkConstrained2DLayoutStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_NewInstance_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkConstrained2DLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060075C2 RID: 30146
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConstrained2DLayoutStrategy_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060075C3 RID: 30147 RVA: 0x000AA198 File Offset: 0x000A8398
		public new static vtkConstrained2DLayoutStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkConstrained2DLayoutStrategy vtkConstrained2DLayoutStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_SafeDownCast_27((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkConstrained2DLayoutStrategy = (vtkConstrained2DLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkConstrained2DLayoutStrategy.Register(null);
				}
			}
			return vtkConstrained2DLayoutStrategy;
		}

		// Token: 0x060075C4 RID: 30148
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrained2DLayoutStrategy_SetCoolDownRate_28(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the Cool-down rate.
		/// The higher this number is, the longer it will take to "cool-down",
		/// and thus, the more the graph will be modified. The default is '10'
		/// for no particular reason.
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x060075C5 RID: 30149 RVA: 0x000AA217 File Offset: 0x000A8417
		public virtual void SetCoolDownRate(double _arg)
		{
			vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_SetCoolDownRate_28(base.GetCppThis(), _arg);
		}

		// Token: 0x060075C6 RID: 30150
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrained2DLayoutStrategy_SetInitialTemperature_29(HandleRef pThis, float _arg);

		/// <summary>
		/// Set the initial temperature.  The temperature default is '5'
		/// for no particular reason
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x060075C7 RID: 30151 RVA: 0x000AA227 File Offset: 0x000A8427
		public virtual void SetInitialTemperature(float _arg)
		{
			vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_SetInitialTemperature_29(base.GetCppThis(), _arg);
		}

		// Token: 0x060075C8 RID: 30152
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrained2DLayoutStrategy_SetInputArrayName_30(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the input constraint array name. If no input array
		/// name is set then the name 'constraint' is used.
		/// </summary>
		// Token: 0x060075C9 RID: 30153 RVA: 0x000AA237 File Offset: 0x000A8437
		public virtual void SetInputArrayName(string _arg)
		{
			vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_SetInputArrayName_30(base.GetCppThis(), _arg);
		}

		// Token: 0x060075CA RID: 30154
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrained2DLayoutStrategy_SetIterationsPerLayout_31(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the number of iterations per layout.
		/// The only use for this ivar is for the application
		/// to do visualizations of the layout before it's complete.
		/// The default is '100' to match the default 'MaxNumberOfIterations'
		/// Note: Changing this parameter is just fine :)
		/// </summary>
		// Token: 0x060075CB RID: 30155 RVA: 0x000AA247 File Offset: 0x000A8447
		public virtual void SetIterationsPerLayout(int _arg)
		{
			vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_SetIterationsPerLayout_31(base.GetCppThis(), _arg);
		}

		// Token: 0x060075CC RID: 30156
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrained2DLayoutStrategy_SetMaxNumberOfIterations_32(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the maximum number of iterations to be used.
		/// The higher this number, the more iterations through the algorithm
		/// is possible, and thus, the more the graph gets modified.
		/// The default is '100' for no particular reason
		/// Note: The strong recommendation is that you do not change
		/// this parameter. :)
		/// </summary>
		// Token: 0x060075CD RID: 30157 RVA: 0x000AA257 File Offset: 0x000A8457
		public virtual void SetMaxNumberOfIterations(int _arg)
		{
			vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_SetMaxNumberOfIterations_32(base.GetCppThis(), _arg);
		}

		// Token: 0x060075CE RID: 30158
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrained2DLayoutStrategy_SetRandomSeed_33(HandleRef pThis, int _arg);

		/// <summary>
		/// Seed the random number generator used to jitter point positions.
		/// This has a significant effect on their final positions when
		/// the layout is complete.
		/// </summary>
		// Token: 0x060075CF RID: 30159 RVA: 0x000AA267 File Offset: 0x000A8467
		public virtual void SetRandomSeed(int _arg)
		{
			vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_SetRandomSeed_33(base.GetCppThis(), _arg);
		}

		// Token: 0x060075D0 RID: 30160
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrained2DLayoutStrategy_SetRestDistance_34(HandleRef pThis, float _arg);

		/// <summary>
		/// Manually set the resting distance. Otherwise the
		/// distance is computed automatically.
		/// </summary>
		// Token: 0x060075D1 RID: 30161 RVA: 0x000AA277 File Offset: 0x000A8477
		public virtual void SetRestDistance(float _arg)
		{
			vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_SetRestDistance_34(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A22 RID: 2594
		public new const string MRFullTypeName = "Kitware.VTK.vtkConstrained2DLayoutStrategy";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A23 RID: 2595
		public new static readonly string MRClassNameKey = "class vtkConstrained2DLayoutStrategy";
	}
}
