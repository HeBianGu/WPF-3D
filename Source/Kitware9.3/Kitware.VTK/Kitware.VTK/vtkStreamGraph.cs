using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkStreamGraph
	/// </summary>
	/// <remarks>
	///    combines two graphs
	///
	///
	/// vtkStreamGraph iteratively collects information from the input graph
	/// and combines it in the output graph. It internally maintains a graph
	/// instance that is incrementally updated every time the filter is called.
	///
	/// Each update, vtkMergeGraphs is used to combine this filter's input with the
	/// internal graph.
	///
	/// If you can use an edge window array to filter out old edges based on a
	/// moving threshold.
	/// </remarks>
	// Token: 0x02000691 RID: 1681
	public class vtkStreamGraph : vtkGraphAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012053 RID: 73811 RVA: 0x00193B47 File Offset: 0x00191D47
		static vtkStreamGraph()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStreamGraph.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStreamGraph"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012054 RID: 73812 RVA: 0x00193B6F File Offset: 0x00191D6F
		public vtkStreamGraph(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012055 RID: 73813
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStreamGraph_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012056 RID: 73814 RVA: 0x00193B80 File Offset: 0x00191D80
		public new static vtkStreamGraph New()
		{
			vtkStreamGraph result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStreamGraph.vtkStreamGraph_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStreamGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012057 RID: 73815 RVA: 0x00193BD4 File Offset: 0x00191DD4
		public vtkStreamGraph() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkStreamGraph.vtkStreamGraph_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012058 RID: 73816 RVA: 0x00193C18 File Offset: 0x00191E18
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012059 RID: 73817
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkStreamGraph_GetEdgeWindow_01(HandleRef pThis);

		/// <summary>
		/// The time window amount. Edges with values lower
		/// than the maximum value minus this window will be
		/// removed from the graph. The default edge window is
		/// 10000.
		/// </summary>
		// Token: 0x0601205A RID: 73818 RVA: 0x00193C24 File Offset: 0x00191E24
		public virtual double GetEdgeWindow()
		{
			return vtkStreamGraph.vtkStreamGraph_GetEdgeWindow_01(base.GetCppThis());
		}

		// Token: 0x0601205B RID: 73819
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStreamGraph_GetEdgeWindowArrayName_02(HandleRef pThis);

		/// <summary>
		/// The edge window array. The default array name is "time".
		/// </summary>
		// Token: 0x0601205C RID: 73820 RVA: 0x00193C44 File Offset: 0x00191E44
		public virtual string GetEdgeWindowArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkStreamGraph.vtkStreamGraph_GetEdgeWindowArrayName_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601205D RID: 73821
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStreamGraph_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601205E RID: 73822 RVA: 0x00193C80 File Offset: 0x00191E80
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkStreamGraph.vtkStreamGraph_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0601205F RID: 73823
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStreamGraph_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012060 RID: 73824 RVA: 0x00193CA0 File Offset: 0x00191EA0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkStreamGraph.vtkStreamGraph_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06012061 RID: 73825
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStreamGraph_GetUseEdgeWindow_05(HandleRef pThis);

		/// <summary>
		/// Whether to use an edge window array. The default is to
		/// not use a window array.
		/// </summary>
		// Token: 0x06012062 RID: 73826 RVA: 0x00193CBC File Offset: 0x00191EBC
		public virtual bool GetUseEdgeWindow()
		{
			return vtkStreamGraph.vtkStreamGraph_GetUseEdgeWindow_05(base.GetCppThis()) != 0;
		}

		// Token: 0x06012063 RID: 73827
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStreamGraph_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012064 RID: 73828 RVA: 0x00193CE4 File Offset: 0x00191EE4
		public override int IsA(string type)
		{
			return vtkStreamGraph.vtkStreamGraph_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06012065 RID: 73829
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStreamGraph_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012066 RID: 73830 RVA: 0x00193D04 File Offset: 0x00191F04
		public new static int IsTypeOf(string type)
		{
			return vtkStreamGraph.vtkStreamGraph_IsTypeOf_07(type);
		}

		// Token: 0x06012067 RID: 73831
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStreamGraph_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012068 RID: 73832 RVA: 0x00193D20 File Offset: 0x00191F20
		public new vtkStreamGraph NewInstance()
		{
			vtkStreamGraph result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStreamGraph.vtkStreamGraph_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStreamGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012069 RID: 73833
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStreamGraph_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601206A RID: 73834 RVA: 0x00193D7C File Offset: 0x00191F7C
		public new static vtkStreamGraph SafeDownCast(vtkObjectBase o)
		{
			vtkStreamGraph vtkStreamGraph = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStreamGraph.vtkStreamGraph_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStreamGraph = (vtkStreamGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStreamGraph.Register(null);
				}
			}
			return vtkStreamGraph;
		}

		// Token: 0x0601206B RID: 73835
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStreamGraph_SetEdgeWindow_11(HandleRef pThis, double _arg);

		/// <summary>
		/// The time window amount. Edges with values lower
		/// than the maximum value minus this window will be
		/// removed from the graph. The default edge window is
		/// 10000.
		/// </summary>
		// Token: 0x0601206C RID: 73836 RVA: 0x00193DFB File Offset: 0x00191FFB
		public virtual void SetEdgeWindow(double _arg)
		{
			vtkStreamGraph.vtkStreamGraph_SetEdgeWindow_11(base.GetCppThis(), _arg);
		}

		// Token: 0x0601206D RID: 73837
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStreamGraph_SetEdgeWindowArrayName_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The edge window array. The default array name is "time".
		/// </summary>
		// Token: 0x0601206E RID: 73838 RVA: 0x00193E0B File Offset: 0x0019200B
		public virtual void SetEdgeWindowArrayName(string _arg)
		{
			vtkStreamGraph.vtkStreamGraph_SetEdgeWindowArrayName_12(base.GetCppThis(), _arg);
		}

		// Token: 0x0601206F RID: 73839
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStreamGraph_SetUseEdgeWindow_13(HandleRef pThis, byte _arg);

		/// <summary>
		/// Whether to use an edge window array. The default is to
		/// not use a window array.
		/// </summary>
		// Token: 0x06012070 RID: 73840 RVA: 0x00193E1B File Offset: 0x0019201B
		public virtual void SetUseEdgeWindow(bool _arg)
		{
			vtkStreamGraph.vtkStreamGraph_SetUseEdgeWindow_13(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06012071 RID: 73841
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStreamGraph_UseEdgeWindowOff_14(HandleRef pThis);

		/// <summary>
		/// Whether to use an edge window array. The default is to
		/// not use a window array.
		/// </summary>
		// Token: 0x06012072 RID: 73842 RVA: 0x00193E33 File Offset: 0x00192033
		public virtual void UseEdgeWindowOff()
		{
			vtkStreamGraph.vtkStreamGraph_UseEdgeWindowOff_14(base.GetCppThis());
		}

		// Token: 0x06012073 RID: 73843
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStreamGraph_UseEdgeWindowOn_15(HandleRef pThis);

		/// <summary>
		/// Whether to use an edge window array. The default is to
		/// not use a window array.
		/// </summary>
		// Token: 0x06012074 RID: 73844 RVA: 0x00193E42 File Offset: 0x00192042
		public virtual void UseEdgeWindowOn()
		{
			vtkStreamGraph.vtkStreamGraph_UseEdgeWindowOn_15(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014CD RID: 5325
		public new const string MRFullTypeName = "Kitware.VTK.vtkStreamGraph";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014CE RID: 5326
		public new static readonly string MRClassNameKey = "class vtkStreamGraph";
	}
}
