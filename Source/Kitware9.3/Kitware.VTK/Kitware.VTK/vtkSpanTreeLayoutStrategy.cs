using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSpanTreeLayoutStrategy
	///
	/// vtkSpanTreeLayout is a strategy for drawing directed graphs that
	/// works by first extracting a spanning tree (more accurately, a
	/// spanning forest), and using this both to position graph vertices
	/// and to plan the placement of non-tree edges.  The latter are drawn
	/// with the aid of edge points to produce a tidy drawing.
	///
	/// The approach is best suited to "quasi-trees", graphs where the number
	/// of edges is of the same order as the number of nodes; it is less well
	/// suited to denser graphs.  The boolean flag DepthFirstSpanningTree
	/// determines whether a depth-first or breadth-first strategy is used to
	/// construct the underlying forest, and the choice of strategy affects
	/// the output layout significantly.  Informal experiments suggest that
	/// the breadth-first strategy is better for denser graphs.
	///
	/// Different layouts could also be produced by plugging in alternative
	/// tree layout strategies.  To work with the method of routing non-tree
	/// edges, any strategy should draw a tree so that levels are equally
	/// spaced along the z-axis, precluding for example the use of a radial
	/// or balloon layout.
	///
	/// vtkSpanTreeLayout is based on an approach to 3D graph layout first
	/// developed as part of the "tulip" tool by Dr. David Auber at LaBRI,
	/// U.Bordeaux: see www.tulip-software.org
	///
	/// This implementation departs from the original version in that:
	/// (a) it is reconstructed to use Titan/VTK data structures;
	/// (b) it uses a faster method for dealing with non-tree edges,
	///     requiring at most two edge points per edge
	/// (c) allows for plugging in different tree layout methods
	/// (d) allows selection of two different strategies for building
	///     the underlying layout tree, which can yield significantly
	///     different results depending on the data.
	///
	/// @par Thanks:
	/// Thanks to David Duke from the University of Leeds for providing this
	/// implementation.
	/// </summary>
	// Token: 0x0200029C RID: 668
	public class vtkSpanTreeLayoutStrategy : vtkGraphLayoutStrategy
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060078C6 RID: 30918 RVA: 0x000AE10F File Offset: 0x000AC30F
		static vtkSpanTreeLayoutStrategy()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSpanTreeLayoutStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSpanTreeLayoutStrategy"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060078C7 RID: 30919 RVA: 0x000AE137 File Offset: 0x000AC337
		public vtkSpanTreeLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060078C8 RID: 30920
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSpanTreeLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060078C9 RID: 30921 RVA: 0x000AE148 File Offset: 0x000AC348
		public new static vtkSpanTreeLayoutStrategy New()
		{
			vtkSpanTreeLayoutStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSpanTreeLayoutStrategy.vtkSpanTreeLayoutStrategy_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSpanTreeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060078CA RID: 30922 RVA: 0x000AE19C File Offset: 0x000AC39C
		public vtkSpanTreeLayoutStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSpanTreeLayoutStrategy.vtkSpanTreeLayoutStrategy_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060078CB RID: 30923 RVA: 0x000AE1E0 File Offset: 0x000AC3E0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060078CC RID: 30924
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpanTreeLayoutStrategy_DepthFirstSpanningTreeOff_01(HandleRef pThis);

		/// <summary>
		/// If set, base the layout on a depth-first spanning tree,
		/// rather than the default breadth-first spanning tree.
		/// Switching between DFT and BFT may significantly change
		/// the layout, and choice must be made on a per-graph basis.
		/// Default value is off.
		/// </summary>
		// Token: 0x060078CD RID: 30925 RVA: 0x000AE1EB File Offset: 0x000AC3EB
		public virtual void DepthFirstSpanningTreeOff()
		{
			vtkSpanTreeLayoutStrategy.vtkSpanTreeLayoutStrategy_DepthFirstSpanningTreeOff_01(base.GetCppThis());
		}

		// Token: 0x060078CE RID: 30926
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpanTreeLayoutStrategy_DepthFirstSpanningTreeOn_02(HandleRef pThis);

		/// <summary>
		/// If set, base the layout on a depth-first spanning tree,
		/// rather than the default breadth-first spanning tree.
		/// Switching between DFT and BFT may significantly change
		/// the layout, and choice must be made on a per-graph basis.
		/// Default value is off.
		/// </summary>
		// Token: 0x060078CF RID: 30927 RVA: 0x000AE1FA File Offset: 0x000AC3FA
		public virtual void DepthFirstSpanningTreeOn()
		{
			vtkSpanTreeLayoutStrategy.vtkSpanTreeLayoutStrategy_DepthFirstSpanningTreeOn_02(base.GetCppThis());
		}

		// Token: 0x060078D0 RID: 30928
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSpanTreeLayoutStrategy_GetDepthFirstSpanningTree_03(HandleRef pThis);

		/// <summary>
		/// If set, base the layout on a depth-first spanning tree,
		/// rather than the default breadth-first spanning tree.
		/// Switching between DFT and BFT may significantly change
		/// the layout, and choice must be made on a per-graph basis.
		/// Default value is off.
		/// </summary>
		// Token: 0x060078D1 RID: 30929 RVA: 0x000AE20C File Offset: 0x000AC40C
		public virtual bool GetDepthFirstSpanningTree()
		{
			return vtkSpanTreeLayoutStrategy.vtkSpanTreeLayoutStrategy_GetDepthFirstSpanningTree_03(base.GetCppThis()) != 0;
		}

		// Token: 0x060078D2 RID: 30930
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSpanTreeLayoutStrategy_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060078D3 RID: 30931 RVA: 0x000AE234 File Offset: 0x000AC434
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSpanTreeLayoutStrategy.vtkSpanTreeLayoutStrategy_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x060078D4 RID: 30932
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSpanTreeLayoutStrategy_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060078D5 RID: 30933 RVA: 0x000AE254 File Offset: 0x000AC454
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSpanTreeLayoutStrategy.vtkSpanTreeLayoutStrategy_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x060078D6 RID: 30934
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSpanTreeLayoutStrategy_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060078D7 RID: 30935 RVA: 0x000AE270 File Offset: 0x000AC470
		public override int IsA(string type)
		{
			return vtkSpanTreeLayoutStrategy.vtkSpanTreeLayoutStrategy_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x060078D8 RID: 30936
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSpanTreeLayoutStrategy_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060078D9 RID: 30937 RVA: 0x000AE290 File Offset: 0x000AC490
		public new static int IsTypeOf(string type)
		{
			return vtkSpanTreeLayoutStrategy.vtkSpanTreeLayoutStrategy_IsTypeOf_07(type);
		}

		// Token: 0x060078DA RID: 30938
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpanTreeLayoutStrategy_Layout_08(HandleRef pThis);

		/// <summary>
		/// Perform the layout.
		/// </summary>
		// Token: 0x060078DB RID: 30939 RVA: 0x000AE2AA File Offset: 0x000AC4AA
		public override void Layout()
		{
			vtkSpanTreeLayoutStrategy.vtkSpanTreeLayoutStrategy_Layout_08(base.GetCppThis());
		}

		// Token: 0x060078DC RID: 30940
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSpanTreeLayoutStrategy_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060078DD RID: 30941 RVA: 0x000AE2BC File Offset: 0x000AC4BC
		public new vtkSpanTreeLayoutStrategy NewInstance()
		{
			vtkSpanTreeLayoutStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSpanTreeLayoutStrategy.vtkSpanTreeLayoutStrategy_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSpanTreeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060078DE RID: 30942
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSpanTreeLayoutStrategy_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060078DF RID: 30943 RVA: 0x000AE318 File Offset: 0x000AC518
		public new static vtkSpanTreeLayoutStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkSpanTreeLayoutStrategy vtkSpanTreeLayoutStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSpanTreeLayoutStrategy.vtkSpanTreeLayoutStrategy_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSpanTreeLayoutStrategy = (vtkSpanTreeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSpanTreeLayoutStrategy.Register(null);
				}
			}
			return vtkSpanTreeLayoutStrategy;
		}

		// Token: 0x060078E0 RID: 30944
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpanTreeLayoutStrategy_SetDepthFirstSpanningTree_12(HandleRef pThis, byte _arg);

		/// <summary>
		/// If set, base the layout on a depth-first spanning tree,
		/// rather than the default breadth-first spanning tree.
		/// Switching between DFT and BFT may significantly change
		/// the layout, and choice must be made on a per-graph basis.
		/// Default value is off.
		/// </summary>
		// Token: 0x060078E1 RID: 30945 RVA: 0x000AE397 File Offset: 0x000AC597
		public virtual void SetDepthFirstSpanningTree(bool _arg)
		{
			vtkSpanTreeLayoutStrategy.vtkSpanTreeLayoutStrategy_SetDepthFirstSpanningTree_12(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A47 RID: 2631
		public new const string MRFullTypeName = "Kitware.VTK.vtkSpanTreeLayoutStrategy";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A48 RID: 2632
		public new static readonly string MRClassNameKey = "class vtkSpanTreeLayoutStrategy";
	}
}
