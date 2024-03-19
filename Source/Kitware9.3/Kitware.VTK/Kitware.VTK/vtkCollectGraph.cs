using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCollectGraph
	/// </summary>
	/// <remarks>
	///    Collect distributed graph.
	///
	/// This filter has code to collect a graph from across processes onto vertex 0.
	/// Collection can be turned on or off using the "PassThrough" flag.
	/// </remarks>
	// Token: 0x020004F8 RID: 1272
	public class vtkCollectGraph : vtkGraphAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E534 RID: 58676 RVA: 0x0013F2C8 File Offset: 0x0013D4C8
		static vtkCollectGraph()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCollectGraph.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCollectGraph"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E535 RID: 58677 RVA: 0x0013F2F0 File Offset: 0x0013D4F0
		public vtkCollectGraph(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E536 RID: 58678
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCollectGraph_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E537 RID: 58679 RVA: 0x0013F300 File Offset: 0x0013D500
		public new static vtkCollectGraph New()
		{
			vtkCollectGraph result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCollectGraph.vtkCollectGraph_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCollectGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E538 RID: 58680 RVA: 0x0013F354 File Offset: 0x0013D554
		public vtkCollectGraph() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCollectGraph.vtkCollectGraph_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E539 RID: 58681 RVA: 0x0013F398 File Offset: 0x0013D598
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E53A RID: 58682
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCollectGraph_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// By default this filter uses the global controller,
		/// but this method can be used to set another instead.
		/// </summary>
		// Token: 0x0600E53B RID: 58683 RVA: 0x0013F3A4 File Offset: 0x0013D5A4
		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCollectGraph.vtkCollectGraph_GetController_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiProcessController = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiProcessController.Register(null);
				}
			}
			return vtkMultiProcessController;
		}

		// Token: 0x0600E53C RID: 58684
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCollectGraph_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E53D RID: 58685 RVA: 0x0013F414 File Offset: 0x0013D614
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCollectGraph.vtkCollectGraph_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600E53E RID: 58686
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCollectGraph_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E53F RID: 58687 RVA: 0x0013F434 File Offset: 0x0013D634
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCollectGraph.vtkCollectGraph_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600E540 RID: 58688
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCollectGraph_GetOutputType_04(HandleRef pThis);

		/// <summary>
		/// Directedness flag, used to signal whether the output graph is directed or undirected.
		/// DIRECTED_OUTPUT expects that this filter is generating a directed graph.
		/// UNDIRECTED_OUTPUT expects that this filter is generating an undirected graph.
		/// DIRECTED_OUTPUT and UNDIRECTED_OUTPUT flags should only be set on the client
		/// filter.  Server filters should be set to USE_INPUT_TYPE since they have valid
		/// input and the directedness is determined from the input type.
		/// </summary>
		// Token: 0x0600E541 RID: 58689 RVA: 0x0013F450 File Offset: 0x0013D650
		public virtual int GetOutputType()
		{
			return vtkCollectGraph.vtkCollectGraph_GetOutputType_04(base.GetCppThis());
		}

		// Token: 0x0600E542 RID: 58690
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCollectGraph_GetPassThrough_05(HandleRef pThis);

		/// <summary>
		/// To collect or just copy input to output. Off (collect) by default.
		/// </summary>
		// Token: 0x0600E543 RID: 58691 RVA: 0x0013F470 File Offset: 0x0013D670
		public virtual int GetPassThrough()
		{
			return vtkCollectGraph.vtkCollectGraph_GetPassThrough_05(base.GetCppThis());
		}

		// Token: 0x0600E544 RID: 58692
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCollectGraph_GetSocketController_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// When this filter is being used in client-server mode,
		/// this is the controller used to communicate between
		/// client and server.  Client should not set the other controller.
		/// </summary>
		// Token: 0x0600E545 RID: 58693 RVA: 0x0013F490 File Offset: 0x0013D690
		public virtual vtkSocketController GetSocketController()
		{
			vtkSocketController vtkSocketController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCollectGraph.vtkCollectGraph_GetSocketController_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSocketController = (vtkSocketController)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSocketController.Register(null);
				}
			}
			return vtkSocketController;
		}

		// Token: 0x0600E546 RID: 58694
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCollectGraph_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E547 RID: 58695 RVA: 0x0013F500 File Offset: 0x0013D700
		public override int IsA(string type)
		{
			return vtkCollectGraph.vtkCollectGraph_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0600E548 RID: 58696
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCollectGraph_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E549 RID: 58697 RVA: 0x0013F520 File Offset: 0x0013D720
		public new static int IsTypeOf(string type)
		{
			return vtkCollectGraph.vtkCollectGraph_IsTypeOf_08(type);
		}

		// Token: 0x0600E54A RID: 58698
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCollectGraph_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E54B RID: 58699 RVA: 0x0013F53C File Offset: 0x0013D73C
		public new vtkCollectGraph NewInstance()
		{
			vtkCollectGraph result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCollectGraph.vtkCollectGraph_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCollectGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E54C RID: 58700
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollectGraph_PassThroughOff_11(HandleRef pThis);

		/// <summary>
		/// To collect or just copy input to output. Off (collect) by default.
		/// </summary>
		// Token: 0x0600E54D RID: 58701 RVA: 0x0013F596 File Offset: 0x0013D796
		public virtual void PassThroughOff()
		{
			vtkCollectGraph.vtkCollectGraph_PassThroughOff_11(base.GetCppThis());
		}

		// Token: 0x0600E54E RID: 58702
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollectGraph_PassThroughOn_12(HandleRef pThis);

		/// <summary>
		/// To collect or just copy input to output. Off (collect) by default.
		/// </summary>
		// Token: 0x0600E54F RID: 58703 RVA: 0x0013F5A5 File Offset: 0x0013D7A5
		public virtual void PassThroughOn()
		{
			vtkCollectGraph.vtkCollectGraph_PassThroughOn_12(base.GetCppThis());
		}

		// Token: 0x0600E550 RID: 58704
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCollectGraph_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E551 RID: 58705 RVA: 0x0013F5B4 File Offset: 0x0013D7B4
		public new static vtkCollectGraph SafeDownCast(vtkObjectBase o)
		{
			vtkCollectGraph vtkCollectGraph = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCollectGraph.vtkCollectGraph_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCollectGraph = (vtkCollectGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCollectGraph.Register(null);
				}
			}
			return vtkCollectGraph;
		}

		// Token: 0x0600E552 RID: 58706
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollectGraph_SetController_14(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// By default this filter uses the global controller,
		/// but this method can be used to set another instead.
		/// </summary>
		// Token: 0x0600E553 RID: 58707 RVA: 0x0013F634 File Offset: 0x0013D834
		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkCollectGraph.vtkCollectGraph_SetController_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600E554 RID: 58708
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollectGraph_SetOutputType_15(HandleRef pThis, int _arg);

		/// <summary>
		/// Directedness flag, used to signal whether the output graph is directed or undirected.
		/// DIRECTED_OUTPUT expects that this filter is generating a directed graph.
		/// UNDIRECTED_OUTPUT expects that this filter is generating an undirected graph.
		/// DIRECTED_OUTPUT and UNDIRECTED_OUTPUT flags should only be set on the client
		/// filter.  Server filters should be set to USE_INPUT_TYPE since they have valid
		/// input and the directedness is determined from the input type.
		/// </summary>
		// Token: 0x0600E555 RID: 58709 RVA: 0x0013F663 File Offset: 0x0013D863
		public virtual void SetOutputType(int _arg)
		{
			vtkCollectGraph.vtkCollectGraph_SetOutputType_15(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E556 RID: 58710
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollectGraph_SetPassThrough_16(HandleRef pThis, int _arg);

		/// <summary>
		/// To collect or just copy input to output. Off (collect) by default.
		/// </summary>
		// Token: 0x0600E557 RID: 58711 RVA: 0x0013F673 File Offset: 0x0013D873
		public virtual void SetPassThrough(int _arg)
		{
			vtkCollectGraph.vtkCollectGraph_SetPassThrough_16(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E558 RID: 58712
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollectGraph_SetSocketController_17(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// When this filter is being used in client-server mode,
		/// this is the controller used to communicate between
		/// client and server.  Client should not set the other controller.
		/// </summary>
		// Token: 0x0600E559 RID: 58713 RVA: 0x0013F684 File Offset: 0x0013D884
		public virtual void SetSocketController(vtkSocketController arg0)
		{
			vtkCollectGraph.vtkCollectGraph_SetSocketController_17(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010D5 RID: 4309
		public new const string MRFullTypeName = "Kitware.VTK.vtkCollectGraph";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010D6 RID: 4310
		public new static readonly string MRClassNameKey = "class vtkCollectGraph";

		/// <summary>
		/// To collect or just copy input to output. Off (collect) by default.
		/// </summary>
		// Token: 0x020004F9 RID: 1273
		public enum DIRECTED_OUTPUT_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x040010D8 RID: 4312
			DIRECTED_OUTPUT,
			/// <summary>enum member</summary>
			// Token: 0x040010D9 RID: 4313
			UNDIRECTED_OUTPUT,
			/// <summary>enum member</summary>
			// Token: 0x040010DA RID: 4314
			USE_INPUT_TYPE
		}
	}
}
