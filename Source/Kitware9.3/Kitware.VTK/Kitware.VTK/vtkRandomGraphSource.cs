using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRandomGraphSource
	/// </summary>
	/// <remarks>
	///    a graph with random edges
	///
	///
	/// Generates a graph with a specified number of vertices, with the density of
	/// edges specified by either an exact number of edges or the probability of
	/// an edge.  You may additionally specify whether to begin with a random
	/// tree (which enforces graph connectivity).
	///
	/// </remarks>
	// Token: 0x0200068B RID: 1675
	public class vtkRandomGraphSource : vtkGraphAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011F85 RID: 73605 RVA: 0x00192A57 File Offset: 0x00190C57
		static vtkRandomGraphSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRandomGraphSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRandomGraphSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011F86 RID: 73606 RVA: 0x00192A7F File Offset: 0x00190C7F
		public vtkRandomGraphSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011F87 RID: 73607
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRandomGraphSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011F88 RID: 73608 RVA: 0x00192A90 File Offset: 0x00190C90
		public new static vtkRandomGraphSource New()
		{
			vtkRandomGraphSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRandomGraphSource.vtkRandomGraphSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRandomGraphSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011F89 RID: 73609 RVA: 0x00192AE4 File Offset: 0x00190CE4
		public vtkRandomGraphSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRandomGraphSource.vtkRandomGraphSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011F8A RID: 73610 RVA: 0x00192B28 File Offset: 0x00190D28
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011F8B RID: 73611
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomGraphSource_AllowParallelEdgesOff_01(HandleRef pThis);

		/// <summary>
		/// When set, multiple edges from a source to a target vertex are
		/// allowed. The default is to forbid such loops.
		/// </summary>
		// Token: 0x06011F8C RID: 73612 RVA: 0x00192B33 File Offset: 0x00190D33
		public virtual void AllowParallelEdgesOff()
		{
			vtkRandomGraphSource.vtkRandomGraphSource_AllowParallelEdgesOff_01(base.GetCppThis());
		}

		// Token: 0x06011F8D RID: 73613
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomGraphSource_AllowParallelEdgesOn_02(HandleRef pThis);

		/// <summary>
		/// When set, multiple edges from a source to a target vertex are
		/// allowed. The default is to forbid such loops.
		/// </summary>
		// Token: 0x06011F8E RID: 73614 RVA: 0x00192B42 File Offset: 0x00190D42
		public virtual void AllowParallelEdgesOn()
		{
			vtkRandomGraphSource.vtkRandomGraphSource_AllowParallelEdgesOn_02(base.GetCppThis());
		}

		// Token: 0x06011F8F RID: 73615
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomGraphSource_AllowSelfLoopsOff_03(HandleRef pThis);

		/// <summary>
		/// If this flag is set to true, edges where the source and target
		/// vertex are the same can be generated.  The default is to forbid
		/// such loops.
		/// </summary>
		// Token: 0x06011F90 RID: 73616 RVA: 0x00192B51 File Offset: 0x00190D51
		public virtual void AllowSelfLoopsOff()
		{
			vtkRandomGraphSource.vtkRandomGraphSource_AllowSelfLoopsOff_03(base.GetCppThis());
		}

		// Token: 0x06011F91 RID: 73617
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomGraphSource_AllowSelfLoopsOn_04(HandleRef pThis);

		/// <summary>
		/// If this flag is set to true, edges where the source and target
		/// vertex are the same can be generated.  The default is to forbid
		/// such loops.
		/// </summary>
		// Token: 0x06011F92 RID: 73618 RVA: 0x00192B60 File Offset: 0x00190D60
		public virtual void AllowSelfLoopsOn()
		{
			vtkRandomGraphSource.vtkRandomGraphSource_AllowSelfLoopsOn_04(base.GetCppThis());
		}

		// Token: 0x06011F93 RID: 73619
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomGraphSource_DirectedOff_05(HandleRef pThis);

		/// <summary>
		/// When set, creates a directed graph, as opposed to an undirected graph.
		/// </summary>
		// Token: 0x06011F94 RID: 73620 RVA: 0x00192B6F File Offset: 0x00190D6F
		public virtual void DirectedOff()
		{
			vtkRandomGraphSource.vtkRandomGraphSource_DirectedOff_05(base.GetCppThis());
		}

		// Token: 0x06011F95 RID: 73621
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomGraphSource_DirectedOn_06(HandleRef pThis);

		/// <summary>
		/// When set, creates a directed graph, as opposed to an undirected graph.
		/// </summary>
		// Token: 0x06011F96 RID: 73622 RVA: 0x00192B7E File Offset: 0x00190D7E
		public virtual void DirectedOn()
		{
			vtkRandomGraphSource.vtkRandomGraphSource_DirectedOn_06(base.GetCppThis());
		}

		// Token: 0x06011F97 RID: 73623
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomGraphSource_GeneratePedigreeIdsOff_07(HandleRef pThis);

		/// <summary>
		/// Add pedigree ids to vertex and edge data.
		/// </summary>
		// Token: 0x06011F98 RID: 73624 RVA: 0x00192B8D File Offset: 0x00190D8D
		public virtual void GeneratePedigreeIdsOff()
		{
			vtkRandomGraphSource.vtkRandomGraphSource_GeneratePedigreeIdsOff_07(base.GetCppThis());
		}

		// Token: 0x06011F99 RID: 73625
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomGraphSource_GeneratePedigreeIdsOn_08(HandleRef pThis);

		/// <summary>
		/// Add pedigree ids to vertex and edge data.
		/// </summary>
		// Token: 0x06011F9A RID: 73626 RVA: 0x00192B9C File Offset: 0x00190D9C
		public virtual void GeneratePedigreeIdsOn()
		{
			vtkRandomGraphSource.vtkRandomGraphSource_GeneratePedigreeIdsOn_08(base.GetCppThis());
		}

		// Token: 0x06011F9B RID: 73627
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRandomGraphSource_GetAllowParallelEdges_09(HandleRef pThis);

		/// <summary>
		/// When set, multiple edges from a source to a target vertex are
		/// allowed. The default is to forbid such loops.
		/// </summary>
		// Token: 0x06011F9C RID: 73628 RVA: 0x00192BAC File Offset: 0x00190DAC
		public virtual bool GetAllowParallelEdges()
		{
			return vtkRandomGraphSource.vtkRandomGraphSource_GetAllowParallelEdges_09(base.GetCppThis()) != 0;
		}

		// Token: 0x06011F9D RID: 73629
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRandomGraphSource_GetAllowSelfLoops_10(HandleRef pThis);

		/// <summary>
		/// If this flag is set to true, edges where the source and target
		/// vertex are the same can be generated.  The default is to forbid
		/// such loops.
		/// </summary>
		// Token: 0x06011F9E RID: 73630 RVA: 0x00192BD4 File Offset: 0x00190DD4
		public virtual bool GetAllowSelfLoops()
		{
			return vtkRandomGraphSource.vtkRandomGraphSource_GetAllowSelfLoops_10(base.GetCppThis()) != 0;
		}

		// Token: 0x06011F9F RID: 73631
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRandomGraphSource_GetDirected_11(HandleRef pThis);

		/// <summary>
		/// When set, creates a directed graph, as opposed to an undirected graph.
		/// </summary>
		// Token: 0x06011FA0 RID: 73632 RVA: 0x00192BFC File Offset: 0x00190DFC
		public virtual bool GetDirected()
		{
			return vtkRandomGraphSource.vtkRandomGraphSource_GetDirected_11(base.GetCppThis()) != 0;
		}

		// Token: 0x06011FA1 RID: 73633
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRandomGraphSource_GetEdgePedigreeIdArrayName_12(HandleRef pThis);

		/// <summary>
		/// The name of the edge pedigree id array. Default "edge id".
		/// </summary>
		// Token: 0x06011FA2 RID: 73634 RVA: 0x00192C24 File Offset: 0x00190E24
		public virtual string GetEdgePedigreeIdArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkRandomGraphSource.vtkRandomGraphSource_GetEdgePedigreeIdArrayName_12(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06011FA3 RID: 73635
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRandomGraphSource_GetEdgeProbability_13(HandleRef pThis);

		/// <summary>
		/// If UseEdgeProbability is on, adds an edge with this probability between 0 and 1
		/// for each pair of vertices in the graph.
		/// </summary>
		// Token: 0x06011FA4 RID: 73636 RVA: 0x00192C60 File Offset: 0x00190E60
		public virtual double GetEdgeProbability()
		{
			return vtkRandomGraphSource.vtkRandomGraphSource_GetEdgeProbability_13(base.GetCppThis());
		}

		// Token: 0x06011FA5 RID: 73637
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRandomGraphSource_GetEdgeProbabilityMaxValue_14(HandleRef pThis);

		/// <summary>
		/// If UseEdgeProbability is on, adds an edge with this probability between 0 and 1
		/// for each pair of vertices in the graph.
		/// </summary>
		// Token: 0x06011FA6 RID: 73638 RVA: 0x00192C80 File Offset: 0x00190E80
		public virtual double GetEdgeProbabilityMaxValue()
		{
			return vtkRandomGraphSource.vtkRandomGraphSource_GetEdgeProbabilityMaxValue_14(base.GetCppThis());
		}

		// Token: 0x06011FA7 RID: 73639
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRandomGraphSource_GetEdgeProbabilityMinValue_15(HandleRef pThis);

		/// <summary>
		/// If UseEdgeProbability is on, adds an edge with this probability between 0 and 1
		/// for each pair of vertices in the graph.
		/// </summary>
		// Token: 0x06011FA8 RID: 73640 RVA: 0x00192CA0 File Offset: 0x00190EA0
		public virtual double GetEdgeProbabilityMinValue()
		{
			return vtkRandomGraphSource.vtkRandomGraphSource_GetEdgeProbabilityMinValue_15(base.GetCppThis());
		}

		// Token: 0x06011FA9 RID: 73641
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRandomGraphSource_GetEdgeWeightArrayName_16(HandleRef pThis);

		/// <summary>
		/// The name of the edge weight array. Default "edge weight".
		/// </summary>
		// Token: 0x06011FAA RID: 73642 RVA: 0x00192CC0 File Offset: 0x00190EC0
		public virtual string GetEdgeWeightArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkRandomGraphSource.vtkRandomGraphSource_GetEdgeWeightArrayName_16(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06011FAB RID: 73643
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRandomGraphSource_GetGeneratePedigreeIds_17(HandleRef pThis);

		/// <summary>
		/// Add pedigree ids to vertex and edge data.
		/// </summary>
		// Token: 0x06011FAC RID: 73644 RVA: 0x00192CFC File Offset: 0x00190EFC
		public virtual bool GetGeneratePedigreeIds()
		{
			return vtkRandomGraphSource.vtkRandomGraphSource_GetGeneratePedigreeIds_17(base.GetCppThis()) != 0;
		}

		// Token: 0x06011FAD RID: 73645
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRandomGraphSource_GetIncludeEdgeWeights_18(HandleRef pThis);

		/// <summary>
		/// When set, includes edge weights in an array named "edge_weights".
		/// Defaults to off.  Weights are random between 0 and 1.
		/// </summary>
		// Token: 0x06011FAE RID: 73646 RVA: 0x00192D24 File Offset: 0x00190F24
		public virtual bool GetIncludeEdgeWeights()
		{
			return vtkRandomGraphSource.vtkRandomGraphSource_GetIncludeEdgeWeights_18(base.GetCppThis()) != 0;
		}

		// Token: 0x06011FAF RID: 73647
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRandomGraphSource_GetNumberOfEdges_19(HandleRef pThis);

		/// <summary>
		/// If UseEdgeProbability is off, creates a graph with the specified number
		/// of edges.  Duplicate (parallel) edges are allowed.
		/// </summary>
		// Token: 0x06011FB0 RID: 73648 RVA: 0x00192D4C File Offset: 0x00190F4C
		public virtual int GetNumberOfEdges()
		{
			return vtkRandomGraphSource.vtkRandomGraphSource_GetNumberOfEdges_19(base.GetCppThis());
		}

		// Token: 0x06011FB1 RID: 73649
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRandomGraphSource_GetNumberOfEdgesMaxValue_20(HandleRef pThis);

		/// <summary>
		/// If UseEdgeProbability is off, creates a graph with the specified number
		/// of edges.  Duplicate (parallel) edges are allowed.
		/// </summary>
		// Token: 0x06011FB2 RID: 73650 RVA: 0x00192D6C File Offset: 0x00190F6C
		public virtual int GetNumberOfEdgesMaxValue()
		{
			return vtkRandomGraphSource.vtkRandomGraphSource_GetNumberOfEdgesMaxValue_20(base.GetCppThis());
		}

		// Token: 0x06011FB3 RID: 73651
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRandomGraphSource_GetNumberOfEdgesMinValue_21(HandleRef pThis);

		/// <summary>
		/// If UseEdgeProbability is off, creates a graph with the specified number
		/// of edges.  Duplicate (parallel) edges are allowed.
		/// </summary>
		// Token: 0x06011FB4 RID: 73652 RVA: 0x00192D8C File Offset: 0x00190F8C
		public virtual int GetNumberOfEdgesMinValue()
		{
			return vtkRandomGraphSource.vtkRandomGraphSource_GetNumberOfEdgesMinValue_21(base.GetCppThis());
		}

		// Token: 0x06011FB5 RID: 73653
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRandomGraphSource_GetNumberOfGenerationsFromBase_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011FB6 RID: 73654 RVA: 0x00192DAC File Offset: 0x00190FAC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRandomGraphSource.vtkRandomGraphSource_GetNumberOfGenerationsFromBase_22(base.GetCppThis(), type);
		}

		// Token: 0x06011FB7 RID: 73655
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRandomGraphSource_GetNumberOfGenerationsFromBaseType_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011FB8 RID: 73656 RVA: 0x00192DCC File Offset: 0x00190FCC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRandomGraphSource.vtkRandomGraphSource_GetNumberOfGenerationsFromBaseType_23(type);
		}

		// Token: 0x06011FB9 RID: 73657
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRandomGraphSource_GetNumberOfVertices_24(HandleRef pThis);

		/// <summary>
		/// The number of vertices in the graph.
		/// </summary>
		// Token: 0x06011FBA RID: 73658 RVA: 0x00192DE8 File Offset: 0x00190FE8
		public virtual int GetNumberOfVertices()
		{
			return vtkRandomGraphSource.vtkRandomGraphSource_GetNumberOfVertices_24(base.GetCppThis());
		}

		// Token: 0x06011FBB RID: 73659
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRandomGraphSource_GetNumberOfVerticesMaxValue_25(HandleRef pThis);

		/// <summary>
		/// The number of vertices in the graph.
		/// </summary>
		// Token: 0x06011FBC RID: 73660 RVA: 0x00192E08 File Offset: 0x00191008
		public virtual int GetNumberOfVerticesMaxValue()
		{
			return vtkRandomGraphSource.vtkRandomGraphSource_GetNumberOfVerticesMaxValue_25(base.GetCppThis());
		}

		// Token: 0x06011FBD RID: 73661
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRandomGraphSource_GetNumberOfVerticesMinValue_26(HandleRef pThis);

		/// <summary>
		/// The number of vertices in the graph.
		/// </summary>
		// Token: 0x06011FBE RID: 73662 RVA: 0x00192E28 File Offset: 0x00191028
		public virtual int GetNumberOfVerticesMinValue()
		{
			return vtkRandomGraphSource.vtkRandomGraphSource_GetNumberOfVerticesMinValue_26(base.GetCppThis());
		}

		// Token: 0x06011FBF RID: 73663
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRandomGraphSource_GetSeed_27(HandleRef pThis);

		/// <summary>
		/// Control the seed used for pseudo-random-number generation.
		/// This ensures that vtkRandomGraphSource can produce repeatable
		/// results.
		/// </summary>
		// Token: 0x06011FC0 RID: 73664 RVA: 0x00192E48 File Offset: 0x00191048
		public virtual int GetSeed()
		{
			return vtkRandomGraphSource.vtkRandomGraphSource_GetSeed_27(base.GetCppThis());
		}

		// Token: 0x06011FC1 RID: 73665
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRandomGraphSource_GetStartWithTree_28(HandleRef pThis);

		/// <summary>
		/// When set, builds a random tree structure first, then adds additional
		/// random edges.
		/// </summary>
		// Token: 0x06011FC2 RID: 73666 RVA: 0x00192E68 File Offset: 0x00191068
		public virtual bool GetStartWithTree()
		{
			return vtkRandomGraphSource.vtkRandomGraphSource_GetStartWithTree_28(base.GetCppThis()) != 0;
		}

		// Token: 0x06011FC3 RID: 73667
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRandomGraphSource_GetUseEdgeProbability_29(HandleRef pThis);

		/// <summary>
		/// When set, uses the EdgeProbability parameter to determine the density
		/// of edges.  Otherwise, NumberOfEdges is used.
		/// </summary>
		// Token: 0x06011FC4 RID: 73668 RVA: 0x00192E90 File Offset: 0x00191090
		public virtual bool GetUseEdgeProbability()
		{
			return vtkRandomGraphSource.vtkRandomGraphSource_GetUseEdgeProbability_29(base.GetCppThis()) != 0;
		}

		// Token: 0x06011FC5 RID: 73669
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRandomGraphSource_GetVertexPedigreeIdArrayName_30(HandleRef pThis);

		/// <summary>
		/// The name of the vertex pedigree id array. Default "vertex id".
		/// </summary>
		// Token: 0x06011FC6 RID: 73670 RVA: 0x00192EB8 File Offset: 0x001910B8
		public virtual string GetVertexPedigreeIdArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkRandomGraphSource.vtkRandomGraphSource_GetVertexPedigreeIdArrayName_30(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06011FC7 RID: 73671
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomGraphSource_IncludeEdgeWeightsOff_31(HandleRef pThis);

		/// <summary>
		/// When set, includes edge weights in an array named "edge_weights".
		/// Defaults to off.  Weights are random between 0 and 1.
		/// </summary>
		// Token: 0x06011FC8 RID: 73672 RVA: 0x00192EF2 File Offset: 0x001910F2
		public virtual void IncludeEdgeWeightsOff()
		{
			vtkRandomGraphSource.vtkRandomGraphSource_IncludeEdgeWeightsOff_31(base.GetCppThis());
		}

		// Token: 0x06011FC9 RID: 73673
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomGraphSource_IncludeEdgeWeightsOn_32(HandleRef pThis);

		/// <summary>
		/// When set, includes edge weights in an array named "edge_weights".
		/// Defaults to off.  Weights are random between 0 and 1.
		/// </summary>
		// Token: 0x06011FCA RID: 73674 RVA: 0x00192F01 File Offset: 0x00191101
		public virtual void IncludeEdgeWeightsOn()
		{
			vtkRandomGraphSource.vtkRandomGraphSource_IncludeEdgeWeightsOn_32(base.GetCppThis());
		}

		// Token: 0x06011FCB RID: 73675
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRandomGraphSource_IsA_33(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011FCC RID: 73676 RVA: 0x00192F10 File Offset: 0x00191110
		public override int IsA(string type)
		{
			return vtkRandomGraphSource.vtkRandomGraphSource_IsA_33(base.GetCppThis(), type);
		}

		// Token: 0x06011FCD RID: 73677
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRandomGraphSource_IsTypeOf_34([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011FCE RID: 73678 RVA: 0x00192F30 File Offset: 0x00191130
		public new static int IsTypeOf(string type)
		{
			return vtkRandomGraphSource.vtkRandomGraphSource_IsTypeOf_34(type);
		}

		// Token: 0x06011FCF RID: 73679
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRandomGraphSource_NewInstance_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011FD0 RID: 73680 RVA: 0x00192F4C File Offset: 0x0019114C
		public new vtkRandomGraphSource NewInstance()
		{
			vtkRandomGraphSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRandomGraphSource.vtkRandomGraphSource_NewInstance_36(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRandomGraphSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011FD1 RID: 73681
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRandomGraphSource_SafeDownCast_37(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011FD2 RID: 73682 RVA: 0x00192FA8 File Offset: 0x001911A8
		public new static vtkRandomGraphSource SafeDownCast(vtkObjectBase o)
		{
			vtkRandomGraphSource vtkRandomGraphSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRandomGraphSource.vtkRandomGraphSource_SafeDownCast_37((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRandomGraphSource = (vtkRandomGraphSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRandomGraphSource.Register(null);
				}
			}
			return vtkRandomGraphSource;
		}

		// Token: 0x06011FD3 RID: 73683
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomGraphSource_SetAllowParallelEdges_38(HandleRef pThis, byte _arg);

		/// <summary>
		/// When set, multiple edges from a source to a target vertex are
		/// allowed. The default is to forbid such loops.
		/// </summary>
		// Token: 0x06011FD4 RID: 73684 RVA: 0x00193027 File Offset: 0x00191227
		public virtual void SetAllowParallelEdges(bool _arg)
		{
			vtkRandomGraphSource.vtkRandomGraphSource_SetAllowParallelEdges_38(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06011FD5 RID: 73685
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomGraphSource_SetAllowSelfLoops_39(HandleRef pThis, byte _arg);

		/// <summary>
		/// If this flag is set to true, edges where the source and target
		/// vertex are the same can be generated.  The default is to forbid
		/// such loops.
		/// </summary>
		// Token: 0x06011FD6 RID: 73686 RVA: 0x0019303F File Offset: 0x0019123F
		public virtual void SetAllowSelfLoops(bool _arg)
		{
			vtkRandomGraphSource.vtkRandomGraphSource_SetAllowSelfLoops_39(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06011FD7 RID: 73687
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomGraphSource_SetDirected_40(HandleRef pThis, byte _arg);

		/// <summary>
		/// When set, creates a directed graph, as opposed to an undirected graph.
		/// </summary>
		// Token: 0x06011FD8 RID: 73688 RVA: 0x00193057 File Offset: 0x00191257
		public virtual void SetDirected(bool _arg)
		{
			vtkRandomGraphSource.vtkRandomGraphSource_SetDirected_40(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06011FD9 RID: 73689
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomGraphSource_SetEdgePedigreeIdArrayName_41(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The name of the edge pedigree id array. Default "edge id".
		/// </summary>
		// Token: 0x06011FDA RID: 73690 RVA: 0x0019306F File Offset: 0x0019126F
		public virtual void SetEdgePedigreeIdArrayName(string _arg)
		{
			vtkRandomGraphSource.vtkRandomGraphSource_SetEdgePedigreeIdArrayName_41(base.GetCppThis(), _arg);
		}

		// Token: 0x06011FDB RID: 73691
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomGraphSource_SetEdgeProbability_42(HandleRef pThis, double _arg);

		/// <summary>
		/// If UseEdgeProbability is on, adds an edge with this probability between 0 and 1
		/// for each pair of vertices in the graph.
		/// </summary>
		// Token: 0x06011FDC RID: 73692 RVA: 0x0019307F File Offset: 0x0019127F
		public virtual void SetEdgeProbability(double _arg)
		{
			vtkRandomGraphSource.vtkRandomGraphSource_SetEdgeProbability_42(base.GetCppThis(), _arg);
		}

		// Token: 0x06011FDD RID: 73693
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomGraphSource_SetEdgeWeightArrayName_43(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The name of the edge weight array. Default "edge weight".
		/// </summary>
		// Token: 0x06011FDE RID: 73694 RVA: 0x0019308F File Offset: 0x0019128F
		public virtual void SetEdgeWeightArrayName(string _arg)
		{
			vtkRandomGraphSource.vtkRandomGraphSource_SetEdgeWeightArrayName_43(base.GetCppThis(), _arg);
		}

		// Token: 0x06011FDF RID: 73695
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomGraphSource_SetGeneratePedigreeIds_44(HandleRef pThis, byte _arg);

		/// <summary>
		/// Add pedigree ids to vertex and edge data.
		/// </summary>
		// Token: 0x06011FE0 RID: 73696 RVA: 0x0019309F File Offset: 0x0019129F
		public virtual void SetGeneratePedigreeIds(bool _arg)
		{
			vtkRandomGraphSource.vtkRandomGraphSource_SetGeneratePedigreeIds_44(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06011FE1 RID: 73697
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomGraphSource_SetIncludeEdgeWeights_45(HandleRef pThis, byte _arg);

		/// <summary>
		/// When set, includes edge weights in an array named "edge_weights".
		/// Defaults to off.  Weights are random between 0 and 1.
		/// </summary>
		// Token: 0x06011FE2 RID: 73698 RVA: 0x001930B7 File Offset: 0x001912B7
		public virtual void SetIncludeEdgeWeights(bool _arg)
		{
			vtkRandomGraphSource.vtkRandomGraphSource_SetIncludeEdgeWeights_45(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06011FE3 RID: 73699
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomGraphSource_SetNumberOfEdges_46(HandleRef pThis, int _arg);

		/// <summary>
		/// If UseEdgeProbability is off, creates a graph with the specified number
		/// of edges.  Duplicate (parallel) edges are allowed.
		/// </summary>
		// Token: 0x06011FE4 RID: 73700 RVA: 0x001930CF File Offset: 0x001912CF
		public virtual void SetNumberOfEdges(int _arg)
		{
			vtkRandomGraphSource.vtkRandomGraphSource_SetNumberOfEdges_46(base.GetCppThis(), _arg);
		}

		// Token: 0x06011FE5 RID: 73701
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomGraphSource_SetNumberOfVertices_47(HandleRef pThis, int _arg);

		/// <summary>
		/// The number of vertices in the graph.
		/// </summary>
		// Token: 0x06011FE6 RID: 73702 RVA: 0x001930DF File Offset: 0x001912DF
		public virtual void SetNumberOfVertices(int _arg)
		{
			vtkRandomGraphSource.vtkRandomGraphSource_SetNumberOfVertices_47(base.GetCppThis(), _arg);
		}

		// Token: 0x06011FE7 RID: 73703
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomGraphSource_SetSeed_48(HandleRef pThis, int _arg);

		/// <summary>
		/// Control the seed used for pseudo-random-number generation.
		/// This ensures that vtkRandomGraphSource can produce repeatable
		/// results.
		/// </summary>
		// Token: 0x06011FE8 RID: 73704 RVA: 0x001930EF File Offset: 0x001912EF
		public virtual void SetSeed(int _arg)
		{
			vtkRandomGraphSource.vtkRandomGraphSource_SetSeed_48(base.GetCppThis(), _arg);
		}

		// Token: 0x06011FE9 RID: 73705
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomGraphSource_SetStartWithTree_49(HandleRef pThis, byte _arg);

		/// <summary>
		/// When set, builds a random tree structure first, then adds additional
		/// random edges.
		/// </summary>
		// Token: 0x06011FEA RID: 73706 RVA: 0x001930FF File Offset: 0x001912FF
		public virtual void SetStartWithTree(bool _arg)
		{
			vtkRandomGraphSource.vtkRandomGraphSource_SetStartWithTree_49(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06011FEB RID: 73707
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomGraphSource_SetUseEdgeProbability_50(HandleRef pThis, byte _arg);

		/// <summary>
		/// When set, uses the EdgeProbability parameter to determine the density
		/// of edges.  Otherwise, NumberOfEdges is used.
		/// </summary>
		// Token: 0x06011FEC RID: 73708 RVA: 0x00193117 File Offset: 0x00191317
		public virtual void SetUseEdgeProbability(bool _arg)
		{
			vtkRandomGraphSource.vtkRandomGraphSource_SetUseEdgeProbability_50(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06011FED RID: 73709
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomGraphSource_SetVertexPedigreeIdArrayName_51(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The name of the vertex pedigree id array. Default "vertex id".
		/// </summary>
		// Token: 0x06011FEE RID: 73710 RVA: 0x0019312F File Offset: 0x0019132F
		public virtual void SetVertexPedigreeIdArrayName(string _arg)
		{
			vtkRandomGraphSource.vtkRandomGraphSource_SetVertexPedigreeIdArrayName_51(base.GetCppThis(), _arg);
		}

		// Token: 0x06011FEF RID: 73711
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomGraphSource_StartWithTreeOff_52(HandleRef pThis);

		/// <summary>
		/// When set, builds a random tree structure first, then adds additional
		/// random edges.
		/// </summary>
		// Token: 0x06011FF0 RID: 73712 RVA: 0x0019313F File Offset: 0x0019133F
		public virtual void StartWithTreeOff()
		{
			vtkRandomGraphSource.vtkRandomGraphSource_StartWithTreeOff_52(base.GetCppThis());
		}

		// Token: 0x06011FF1 RID: 73713
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomGraphSource_StartWithTreeOn_53(HandleRef pThis);

		/// <summary>
		/// When set, builds a random tree structure first, then adds additional
		/// random edges.
		/// </summary>
		// Token: 0x06011FF2 RID: 73714 RVA: 0x0019314E File Offset: 0x0019134E
		public virtual void StartWithTreeOn()
		{
			vtkRandomGraphSource.vtkRandomGraphSource_StartWithTreeOn_53(base.GetCppThis());
		}

		// Token: 0x06011FF3 RID: 73715
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomGraphSource_UseEdgeProbabilityOff_54(HandleRef pThis);

		/// <summary>
		/// When set, uses the EdgeProbability parameter to determine the density
		/// of edges.  Otherwise, NumberOfEdges is used.
		/// </summary>
		// Token: 0x06011FF4 RID: 73716 RVA: 0x0019315D File Offset: 0x0019135D
		public virtual void UseEdgeProbabilityOff()
		{
			vtkRandomGraphSource.vtkRandomGraphSource_UseEdgeProbabilityOff_54(base.GetCppThis());
		}

		// Token: 0x06011FF5 RID: 73717
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomGraphSource_UseEdgeProbabilityOn_55(HandleRef pThis);

		/// <summary>
		/// When set, uses the EdgeProbability parameter to determine the density
		/// of edges.  Otherwise, NumberOfEdges is used.
		/// </summary>
		// Token: 0x06011FF6 RID: 73718 RVA: 0x0019316C File Offset: 0x0019136C
		public virtual void UseEdgeProbabilityOn()
		{
			vtkRandomGraphSource.vtkRandomGraphSource_UseEdgeProbabilityOn_55(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014BF RID: 5311
		public new const string MRFullTypeName = "Kitware.VTK.vtkRandomGraphSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014C0 RID: 5312
		public new static readonly string MRClassNameKey = "class vtkRandomGraphSource";
	}
}
