using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTableToGraph
	/// </summary>
	/// <remarks>
	///    convert a vtkTable into a vtkGraph
	///
	///
	/// vtkTableToGraph converts a table to a graph using an auxiliary
	/// link graph.  The link graph specifies how each row in the table
	/// should be converted to an edge, or a collection of edges.  It also
	/// specifies which columns of the table should be considered part of
	/// the same domain, and which columns should be hidden.
	///
	/// A second, optional, table may be provided as the vertex table.
	/// This vertex table must have one or more domain columns whose values
	/// match values in the edge table.  The linked column name is specified in
	/// the domain array in the link graph.  The output graph will only contain
	/// vertices corresponding to a row in the vertex table.  For heterogeneous
	/// graphs, you may want to use vtkMergeTables to create a single vertex table.
	///
	/// The link graph contains the following arrays:
	///
	/// (1) The "column" array has the names of the columns to connect in each table row.
	/// This array is required.
	///
	/// (2) The optional "domain" array provides user-defined domain names for each column.
	/// Matching domains in multiple columns will merge vertices with the same
	/// value from those columns.  By default, all columns are in the same domain.
	/// If a vertex table is supplied, the domain indicates the column in the vertex
	/// table that the edge table column associates with.  If the user provides a
	/// vertex table but no domain names, the output will be an empty graph.
	/// Hidden columns do not need valid domain names.
	///
	/// (3) The optional "hidden" array is a bit array specifying whether the column should be
	/// hidden.  The resulting graph will contain edges representing connections
	/// "through" the hidden column, but the vertices for that column will not
	/// be present.  By default, no columns are hidden.  Hiding a column
	/// in a particular domain hides all columns in that domain.
	///
	/// The output graph will contain three additional arrays in the vertex data.
	/// The "domain" column is a string array containing the domain of each vertex.
	/// The "label" column is a string version of the distinct value that, along
	/// with the domain, defines that vertex. The "ids" column also contains
	/// the distinguishing value, but as a vtkVariant holding the raw value instead
	/// of being converted to a string. The "ids" column is set as the vertex pedigree
	/// ID attribute.
	/// </remarks>
	// Token: 0x02000695 RID: 1685
	public class vtkTableToGraph : vtkGraphAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060120FF RID: 73983 RVA: 0x001948BB File Offset: 0x00192ABB
		static vtkTableToGraph()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTableToGraph.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTableToGraph"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012100 RID: 73984 RVA: 0x001948E3 File Offset: 0x00192AE3
		public vtkTableToGraph(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012101 RID: 73985
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableToGraph_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012102 RID: 73986 RVA: 0x001948F4 File Offset: 0x00192AF4
		public new static vtkTableToGraph New()
		{
			vtkTableToGraph result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTableToGraph.vtkTableToGraph_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTableToGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012103 RID: 73987 RVA: 0x00194948 File Offset: 0x00192B48
		public vtkTableToGraph() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTableToGraph.vtkTableToGraph_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012104 RID: 73988 RVA: 0x0019498C File Offset: 0x00192B8C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012105 RID: 73989
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableToGraph_AddLinkEdge_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string column1, [MarshalAs(UnmanagedType.LPUTF8Str)] string column2);

		/// <summary>
		/// Add an edge to the link graph.  Specify the names of the columns to link.
		/// </summary>
		// Token: 0x06012106 RID: 73990 RVA: 0x00194997 File Offset: 0x00192B97
		public void AddLinkEdge(string column1, string column2)
		{
			vtkTableToGraph.vtkTableToGraph_AddLinkEdge_01(base.GetCppThis(), column1, column2);
		}

		// Token: 0x06012107 RID: 73991
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableToGraph_AddLinkVertex_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string column, [MarshalAs(UnmanagedType.LPUTF8Str)] string domain, int hidden);

		/// <summary>
		/// Add a vertex to the link graph.  Specify the column name, the domain name
		/// for the column, and whether the column is hidden.
		/// </summary>
		// Token: 0x06012108 RID: 73992 RVA: 0x001949A8 File Offset: 0x00192BA8
		public void AddLinkVertex(string column, string domain, int hidden)
		{
			vtkTableToGraph.vtkTableToGraph_AddLinkVertex_02(base.GetCppThis(), column, domain, hidden);
		}

		// Token: 0x06012109 RID: 73993
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableToGraph_ClearLinkEdges_03(HandleRef pThis);

		/// <summary>
		/// Clear the link graph edges.  The graph vertices will remain.
		/// </summary>
		// Token: 0x0601210A RID: 73994 RVA: 0x001949BA File Offset: 0x00192BBA
		public void ClearLinkEdges()
		{
			vtkTableToGraph.vtkTableToGraph_ClearLinkEdges_03(base.GetCppThis());
		}

		// Token: 0x0601210B RID: 73995
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableToGraph_ClearLinkVertices_04(HandleRef pThis);

		/// <summary>
		/// Clear the link graph vertices.  This also clears all edges.
		/// </summary>
		// Token: 0x0601210C RID: 73996 RVA: 0x001949C9 File Offset: 0x00192BC9
		public void ClearLinkVertices()
		{
			vtkTableToGraph.vtkTableToGraph_ClearLinkVertices_04(base.GetCppThis());
		}

		// Token: 0x0601210D RID: 73997
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableToGraph_DirectedOff_05(HandleRef pThis);

		/// <summary>
		/// Specify the directedness of the output graph.
		/// </summary>
		// Token: 0x0601210E RID: 73998 RVA: 0x001949D8 File Offset: 0x00192BD8
		public virtual void DirectedOff()
		{
			vtkTableToGraph.vtkTableToGraph_DirectedOff_05(base.GetCppThis());
		}

		// Token: 0x0601210F RID: 73999
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableToGraph_DirectedOn_06(HandleRef pThis);

		/// <summary>
		/// Specify the directedness of the output graph.
		/// </summary>
		// Token: 0x06012110 RID: 74000 RVA: 0x001949E7 File Offset: 0x00192BE7
		public virtual void DirectedOn()
		{
			vtkTableToGraph.vtkTableToGraph_DirectedOn_06(base.GetCppThis());
		}

		// Token: 0x06012111 RID: 74001
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTableToGraph_GetDirected_07(HandleRef pThis);

		/// <summary>
		/// Specify the directedness of the output graph.
		/// </summary>
		// Token: 0x06012112 RID: 74002 RVA: 0x001949F8 File Offset: 0x00192BF8
		public virtual bool GetDirected()
		{
			return vtkTableToGraph.vtkTableToGraph_GetDirected_07(base.GetCppThis()) != 0;
		}

		// Token: 0x06012113 RID: 74003
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableToGraph_GetLinkGraph_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The graph describing how to link the columns in the table.
		/// </summary>
		// Token: 0x06012114 RID: 74004 RVA: 0x00194A20 File Offset: 0x00192C20
		public virtual vtkMutableDirectedGraph GetLinkGraph()
		{
			vtkMutableDirectedGraph vtkMutableDirectedGraph = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTableToGraph.vtkTableToGraph_GetLinkGraph_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMutableDirectedGraph = (vtkMutableDirectedGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMutableDirectedGraph.Register(null);
				}
			}
			return vtkMutableDirectedGraph;
		}

		// Token: 0x06012115 RID: 74005
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkTableToGraph_GetMTime_09(HandleRef pThis);

		/// <summary>
		/// Get the current modified time.
		/// </summary>
		// Token: 0x06012116 RID: 74006 RVA: 0x00194A90 File Offset: 0x00192C90
		public override ulong GetMTime()
		{
			return vtkTableToGraph.vtkTableToGraph_GetMTime_09(base.GetCppThis());
		}

		// Token: 0x06012117 RID: 74007
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTableToGraph_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012118 RID: 74008 RVA: 0x00194AB0 File Offset: 0x00192CB0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTableToGraph.vtkTableToGraph_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x06012119 RID: 74009
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTableToGraph_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601211A RID: 74010 RVA: 0x00194AD0 File Offset: 0x00192CD0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTableToGraph.vtkTableToGraph_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x0601211B RID: 74011
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableToGraph_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601211C RID: 74012 RVA: 0x00194AEC File Offset: 0x00192CEC
		public override int IsA(string type)
		{
			return vtkTableToGraph.vtkTableToGraph_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x0601211D RID: 74013
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableToGraph_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601211E RID: 74014 RVA: 0x00194B0C File Offset: 0x00192D0C
		public new static int IsTypeOf(string type)
		{
			return vtkTableToGraph.vtkTableToGraph_IsTypeOf_13(type);
		}

		// Token: 0x0601211F RID: 74015
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableToGraph_LinkColumnPath_14(HandleRef pThis, HandleRef column, HandleRef domain, HandleRef hidden);

		/// <summary>
		/// Links the columns in a specific order.
		/// This creates a simple path as the link graph.
		/// </summary>
		// Token: 0x06012120 RID: 74016 RVA: 0x00194B28 File Offset: 0x00192D28
		public void LinkColumnPath(vtkStringArray column, vtkStringArray domain, vtkBitArray hidden)
		{
			vtkTableToGraph.vtkTableToGraph_LinkColumnPath_14(base.GetCppThis(), (column == null) ? default(HandleRef) : column.GetCppThis(), (domain == null) ? default(HandleRef) : domain.GetCppThis(), (hidden == null) ? default(HandleRef) : hidden.GetCppThis());
		}

		// Token: 0x06012121 RID: 74017
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableToGraph_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012122 RID: 74018 RVA: 0x00194B84 File Offset: 0x00192D84
		public new vtkTableToGraph NewInstance()
		{
			vtkTableToGraph result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTableToGraph.vtkTableToGraph_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTableToGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012123 RID: 74019
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableToGraph_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012124 RID: 74020 RVA: 0x00194BE0 File Offset: 0x00192DE0
		public new static vtkTableToGraph SafeDownCast(vtkObjectBase o)
		{
			vtkTableToGraph vtkTableToGraph = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTableToGraph.vtkTableToGraph_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTableToGraph = (vtkTableToGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTableToGraph.Register(null);
				}
			}
			return vtkTableToGraph;
		}

		// Token: 0x06012125 RID: 74021
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableToGraph_SetDirected_18(HandleRef pThis, byte _arg);

		/// <summary>
		/// Specify the directedness of the output graph.
		/// </summary>
		// Token: 0x06012126 RID: 74022 RVA: 0x00194C5F File Offset: 0x00192E5F
		public virtual void SetDirected(bool _arg)
		{
			vtkTableToGraph.vtkTableToGraph_SetDirected_18(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06012127 RID: 74023
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableToGraph_SetLinkGraph_19(HandleRef pThis, HandleRef g);

		/// <summary>
		/// The graph describing how to link the columns in the table.
		/// </summary>
		// Token: 0x06012128 RID: 74024 RVA: 0x00194C78 File Offset: 0x00192E78
		public void SetLinkGraph(vtkMutableDirectedGraph g)
		{
			vtkTableToGraph.vtkTableToGraph_SetLinkGraph_19(base.GetCppThis(), (g == null) ? default(HandleRef) : g.GetCppThis());
		}

		// Token: 0x06012129 RID: 74025
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableToGraph_SetVertexTableConnection_20(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// A convenience method for setting the vertex table input.  This
		/// is mainly for the benefit of the VTK client/server layer,
		/// vanilla VTK code should use e.g:
		///
		/// table_to_graph-&gt;SetInputConnection(1, vertex_table-&gt;output());
		/// </summary>
		// Token: 0x0601212A RID: 74026 RVA: 0x00194CA8 File Offset: 0x00192EA8
		public void SetVertexTableConnection(vtkAlgorithmOutput arg0)
		{
			vtkTableToGraph.vtkTableToGraph_SetVertexTableConnection_20(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014D5 RID: 5333
		public new const string MRFullTypeName = "Kitware.VTK.vtkTableToGraph";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014D6 RID: 5334
		public new static readonly string MRClassNameKey = "class vtkTableToGraph";
	}
}
