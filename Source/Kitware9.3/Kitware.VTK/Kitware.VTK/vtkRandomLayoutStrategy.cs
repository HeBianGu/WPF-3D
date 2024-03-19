using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRandomLayoutStrategy
	/// </summary>
	/// <remarks>
	///    randomly places vertices in 2 or 3 dimensions
	///
	///
	/// Assigns points to the vertices of a graph randomly within a bounded range.
	///
	/// .SECTION Thanks
	/// Thanks to Brian Wylie from Sandia National Laboratories for adding incremental
	/// layout capabilities.
	/// </remarks>
	// Token: 0x02000297 RID: 663
	public class vtkRandomLayoutStrategy : vtkGraphLayoutStrategy
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060077D6 RID: 30678 RVA: 0x000ACDF3 File Offset: 0x000AAFF3
		static vtkRandomLayoutStrategy()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRandomLayoutStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRandomLayoutStrategy"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060077D7 RID: 30679 RVA: 0x000ACE1B File Offset: 0x000AB01B
		public vtkRandomLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060077D8 RID: 30680
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRandomLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060077D9 RID: 30681 RVA: 0x000ACE2C File Offset: 0x000AB02C
		public new static vtkRandomLayoutStrategy New()
		{
			vtkRandomLayoutStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRandomLayoutStrategy.vtkRandomLayoutStrategy_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRandomLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060077DA RID: 30682 RVA: 0x000ACE80 File Offset: 0x000AB080
		public vtkRandomLayoutStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRandomLayoutStrategy.vtkRandomLayoutStrategy_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060077DB RID: 30683 RVA: 0x000ACEC4 File Offset: 0x000AB0C4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060077DC RID: 30684
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomLayoutStrategy_AutomaticBoundsComputationOff_01(HandleRef pThis);

		/// <summary>
		/// Turn on/off automatic graph bounds calculation. If this
		/// boolean is off, then the manually specified GraphBounds is used.
		/// If on, then the input's bounds us used as the graph bounds.
		/// </summary>
		// Token: 0x060077DD RID: 30685 RVA: 0x000ACECF File Offset: 0x000AB0CF
		public virtual void AutomaticBoundsComputationOff()
		{
			vtkRandomLayoutStrategy.vtkRandomLayoutStrategy_AutomaticBoundsComputationOff_01(base.GetCppThis());
		}

		// Token: 0x060077DE RID: 30686
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomLayoutStrategy_AutomaticBoundsComputationOn_02(HandleRef pThis);

		/// <summary>
		/// Turn on/off automatic graph bounds calculation. If this
		/// boolean is off, then the manually specified GraphBounds is used.
		/// If on, then the input's bounds us used as the graph bounds.
		/// </summary>
		// Token: 0x060077DF RID: 30687 RVA: 0x000ACEDE File Offset: 0x000AB0DE
		public virtual void AutomaticBoundsComputationOn()
		{
			vtkRandomLayoutStrategy.vtkRandomLayoutStrategy_AutomaticBoundsComputationOn_02(base.GetCppThis());
		}

		// Token: 0x060077E0 RID: 30688
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRandomLayoutStrategy_GetAutomaticBoundsComputation_03(HandleRef pThis);

		/// <summary>
		/// Turn on/off automatic graph bounds calculation. If this
		/// boolean is off, then the manually specified GraphBounds is used.
		/// If on, then the input's bounds us used as the graph bounds.
		/// </summary>
		// Token: 0x060077E1 RID: 30689 RVA: 0x000ACEF0 File Offset: 0x000AB0F0
		public virtual int GetAutomaticBoundsComputation()
		{
			return vtkRandomLayoutStrategy.vtkRandomLayoutStrategy_GetAutomaticBoundsComputation_03(base.GetCppThis());
		}

		// Token: 0x060077E2 RID: 30690
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRandomLayoutStrategy_GetGraphBounds_04(HandleRef pThis);

		/// <summary>
		/// Set / get the region in space in which to place the final graph.
		/// The GraphBounds only affects the results if AutomaticBoundsComputation
		/// is off.
		/// </summary>
		// Token: 0x060077E3 RID: 30691 RVA: 0x000ACF10 File Offset: 0x000AB110
		public virtual double[] GetGraphBounds()
		{
			IntPtr intPtr = vtkRandomLayoutStrategy.vtkRandomLayoutStrategy_GetGraphBounds_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060077E4 RID: 30692
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomLayoutStrategy_GetGraphBounds_05(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set / get the region in space in which to place the final graph.
		/// The GraphBounds only affects the results if AutomaticBoundsComputation
		/// is off.
		/// </summary>
		// Token: 0x060077E5 RID: 30693 RVA: 0x000ACF58 File Offset: 0x000AB158
		public virtual void GetGraphBounds(IntPtr data)
		{
			vtkRandomLayoutStrategy.vtkRandomLayoutStrategy_GetGraphBounds_05(base.GetCppThis(), data);
		}

		// Token: 0x060077E6 RID: 30694
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRandomLayoutStrategy_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060077E7 RID: 30695 RVA: 0x000ACF68 File Offset: 0x000AB168
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRandomLayoutStrategy.vtkRandomLayoutStrategy_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x060077E8 RID: 30696
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRandomLayoutStrategy_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060077E9 RID: 30697 RVA: 0x000ACF88 File Offset: 0x000AB188
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRandomLayoutStrategy.vtkRandomLayoutStrategy_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x060077EA RID: 30698
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRandomLayoutStrategy_GetRandomSeed_08(HandleRef pThis);

		/// <summary>
		/// Seed the random number generator used to compute point positions.
		/// This has a significant effect on their final positions when
		/// the layout is complete.
		/// </summary>
		// Token: 0x060077EB RID: 30699 RVA: 0x000ACFA4 File Offset: 0x000AB1A4
		public virtual int GetRandomSeed()
		{
			return vtkRandomLayoutStrategy.vtkRandomLayoutStrategy_GetRandomSeed_08(base.GetCppThis());
		}

		// Token: 0x060077EC RID: 30700
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRandomLayoutStrategy_GetRandomSeedMaxValue_09(HandleRef pThis);

		/// <summary>
		/// Seed the random number generator used to compute point positions.
		/// This has a significant effect on their final positions when
		/// the layout is complete.
		/// </summary>
		// Token: 0x060077ED RID: 30701 RVA: 0x000ACFC4 File Offset: 0x000AB1C4
		public virtual int GetRandomSeedMaxValue()
		{
			return vtkRandomLayoutStrategy.vtkRandomLayoutStrategy_GetRandomSeedMaxValue_09(base.GetCppThis());
		}

		// Token: 0x060077EE RID: 30702
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRandomLayoutStrategy_GetRandomSeedMinValue_10(HandleRef pThis);

		/// <summary>
		/// Seed the random number generator used to compute point positions.
		/// This has a significant effect on their final positions when
		/// the layout is complete.
		/// </summary>
		// Token: 0x060077EF RID: 30703 RVA: 0x000ACFE4 File Offset: 0x000AB1E4
		public virtual int GetRandomSeedMinValue()
		{
			return vtkRandomLayoutStrategy.vtkRandomLayoutStrategy_GetRandomSeedMinValue_10(base.GetCppThis());
		}

		// Token: 0x060077F0 RID: 30704
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRandomLayoutStrategy_GetThreeDimensionalLayout_11(HandleRef pThis);

		/// <summary>
		/// Turn on/off layout of graph in three dimensions. If off, graph
		/// layout occurs in two dimensions. By default, three dimensional
		/// layout is on.
		/// </summary>
		// Token: 0x060077F1 RID: 30705 RVA: 0x000AD004 File Offset: 0x000AB204
		public virtual int GetThreeDimensionalLayout()
		{
			return vtkRandomLayoutStrategy.vtkRandomLayoutStrategy_GetThreeDimensionalLayout_11(base.GetCppThis());
		}

		// Token: 0x060077F2 RID: 30706
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRandomLayoutStrategy_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060077F3 RID: 30707 RVA: 0x000AD024 File Offset: 0x000AB224
		public override int IsA(string type)
		{
			return vtkRandomLayoutStrategy.vtkRandomLayoutStrategy_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x060077F4 RID: 30708
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRandomLayoutStrategy_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060077F5 RID: 30709 RVA: 0x000AD044 File Offset: 0x000AB244
		public new static int IsTypeOf(string type)
		{
			return vtkRandomLayoutStrategy.vtkRandomLayoutStrategy_IsTypeOf_13(type);
		}

		// Token: 0x060077F6 RID: 30710
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomLayoutStrategy_Layout_14(HandleRef pThis);

		/// <summary>
		/// Perform the random layout.
		/// </summary>
		// Token: 0x060077F7 RID: 30711 RVA: 0x000AD05E File Offset: 0x000AB25E
		public override void Layout()
		{
			vtkRandomLayoutStrategy.vtkRandomLayoutStrategy_Layout_14(base.GetCppThis());
		}

		// Token: 0x060077F8 RID: 30712
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRandomLayoutStrategy_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060077F9 RID: 30713 RVA: 0x000AD070 File Offset: 0x000AB270
		public new vtkRandomLayoutStrategy NewInstance()
		{
			vtkRandomLayoutStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRandomLayoutStrategy.vtkRandomLayoutStrategy_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRandomLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060077FA RID: 30714
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRandomLayoutStrategy_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060077FB RID: 30715 RVA: 0x000AD0CC File Offset: 0x000AB2CC
		public new static vtkRandomLayoutStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkRandomLayoutStrategy vtkRandomLayoutStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRandomLayoutStrategy.vtkRandomLayoutStrategy_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRandomLayoutStrategy = (vtkRandomLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRandomLayoutStrategy.Register(null);
				}
			}
			return vtkRandomLayoutStrategy;
		}

		// Token: 0x060077FC RID: 30716
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomLayoutStrategy_SetAutomaticBoundsComputation_18(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off automatic graph bounds calculation. If this
		/// boolean is off, then the manually specified GraphBounds is used.
		/// If on, then the input's bounds us used as the graph bounds.
		/// </summary>
		// Token: 0x060077FD RID: 30717 RVA: 0x000AD14B File Offset: 0x000AB34B
		public virtual void SetAutomaticBoundsComputation(int _arg)
		{
			vtkRandomLayoutStrategy.vtkRandomLayoutStrategy_SetAutomaticBoundsComputation_18(base.GetCppThis(), _arg);
		}

		// Token: 0x060077FE RID: 30718
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomLayoutStrategy_SetGraph_19(HandleRef pThis, HandleRef graph);

		/// <summary>
		/// Set the graph to layout.
		/// </summary>
		// Token: 0x060077FF RID: 30719 RVA: 0x000AD15C File Offset: 0x000AB35C
		public override void SetGraph(vtkGraph graph)
		{
			vtkRandomLayoutStrategy.vtkRandomLayoutStrategy_SetGraph_19(base.GetCppThis(), (graph == null) ? default(HandleRef) : graph.GetCppThis());
		}

		// Token: 0x06007800 RID: 30720
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomLayoutStrategy_SetGraphBounds_20(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		/// <summary>
		/// Set / get the region in space in which to place the final graph.
		/// The GraphBounds only affects the results if AutomaticBoundsComputation
		/// is off.
		/// </summary>
		// Token: 0x06007801 RID: 30721 RVA: 0x000AD18B File Offset: 0x000AB38B
		public virtual void SetGraphBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkRandomLayoutStrategy.vtkRandomLayoutStrategy_SetGraphBounds_20(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x06007802 RID: 30722
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomLayoutStrategy_SetGraphBounds_21(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set / get the region in space in which to place the final graph.
		/// The GraphBounds only affects the results if AutomaticBoundsComputation
		/// is off.
		/// </summary>
		// Token: 0x06007803 RID: 30723 RVA: 0x000AD1A3 File Offset: 0x000AB3A3
		public virtual void SetGraphBounds(IntPtr _arg)
		{
			vtkRandomLayoutStrategy.vtkRandomLayoutStrategy_SetGraphBounds_21(base.GetCppThis(), _arg);
		}

		// Token: 0x06007804 RID: 30724
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomLayoutStrategy_SetRandomSeed_22(HandleRef pThis, int _arg);

		/// <summary>
		/// Seed the random number generator used to compute point positions.
		/// This has a significant effect on their final positions when
		/// the layout is complete.
		/// </summary>
		// Token: 0x06007805 RID: 30725 RVA: 0x000AD1B3 File Offset: 0x000AB3B3
		public virtual void SetRandomSeed(int _arg)
		{
			vtkRandomLayoutStrategy.vtkRandomLayoutStrategy_SetRandomSeed_22(base.GetCppThis(), _arg);
		}

		// Token: 0x06007806 RID: 30726
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomLayoutStrategy_SetThreeDimensionalLayout_23(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off layout of graph in three dimensions. If off, graph
		/// layout occurs in two dimensions. By default, three dimensional
		/// layout is on.
		/// </summary>
		// Token: 0x06007807 RID: 30727 RVA: 0x000AD1C3 File Offset: 0x000AB3C3
		public virtual void SetThreeDimensionalLayout(int _arg)
		{
			vtkRandomLayoutStrategy.vtkRandomLayoutStrategy_SetThreeDimensionalLayout_23(base.GetCppThis(), _arg);
		}

		// Token: 0x06007808 RID: 30728
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomLayoutStrategy_ThreeDimensionalLayoutOff_24(HandleRef pThis);

		/// <summary>
		/// Turn on/off layout of graph in three dimensions. If off, graph
		/// layout occurs in two dimensions. By default, three dimensional
		/// layout is on.
		/// </summary>
		// Token: 0x06007809 RID: 30729 RVA: 0x000AD1D3 File Offset: 0x000AB3D3
		public virtual void ThreeDimensionalLayoutOff()
		{
			vtkRandomLayoutStrategy.vtkRandomLayoutStrategy_ThreeDimensionalLayoutOff_24(base.GetCppThis());
		}

		// Token: 0x0600780A RID: 30730
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomLayoutStrategy_ThreeDimensionalLayoutOn_25(HandleRef pThis);

		/// <summary>
		/// Turn on/off layout of graph in three dimensions. If off, graph
		/// layout occurs in two dimensions. By default, three dimensional
		/// layout is on.
		/// </summary>
		// Token: 0x0600780B RID: 30731 RVA: 0x000AD1E2 File Offset: 0x000AB3E2
		public virtual void ThreeDimensionalLayoutOn()
		{
			vtkRandomLayoutStrategy.vtkRandomLayoutStrategy_ThreeDimensionalLayoutOn_25(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A3C RID: 2620
		public new const string MRFullTypeName = "Kitware.VTK.vtkRandomLayoutStrategy";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A3D RID: 2621
		public new static readonly string MRClassNameKey = "class vtkRandomLayoutStrategy";
	}
}
