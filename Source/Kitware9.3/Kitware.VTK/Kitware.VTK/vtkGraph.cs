using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGraph
	/// </summary>
	/// <remarks>
	///    Base class for graph data types.
	///
	///
	/// vtkGraph is the abstract base class that provides all read-only API for graph
	/// data types. A graph consists of a collection of vertices and a
	/// collection of edges connecting pairs of vertices. The vtkDirectedGraph
	/// subclass represents a graph whose edges have inherent order from source
	/// vertex to target vertex, while vtkUndirectedGraph is a graph whose edges
	/// have no inherent ordering.
	///
	/// Graph vertices may be traversed in two ways. In the current implementation,
	/// all vertices are assigned consecutive ids starting at zero, so they may
	/// be traversed in a simple for loop from 0 to graph-&gt;GetNumberOfVertices() - 1.
	/// You may alternately create a vtkVertexListIterator and call graph-&gt;GetVertices(it).
	/// it-&gt;Next() will return the id of the next vertex, while it-&gt;HasNext() indicates
	/// whether there are more vertices in the graph.
	/// This is the preferred method, since in the future graphs may support filtering
	/// or subsetting where the vertex ids may not be contiguous.
	///
	/// Graph edges must be traversed through iterators. To traverse all edges
	/// in a graph, create an instance of vtkEdgeListIterator and call graph-&gt;GetEdges(it).
	/// it-&gt;Next() returns lightweight vtkEdgeType structures, which contain the public
	/// fields Id, Source and Target. Id is the identifier for the edge, which may
	/// be used to look up values in associated edge data arrays. Source and Target
	/// store the ids of the source and target vertices of the edge. Note that the
	/// edge list iterator DOES NOT necessarily iterate over edges in order of ascending
	/// id. To traverse edges from wrapper code (Python, Java), use
	/// it-&gt;NextGraphEdge() instead of it-&gt;Next().  This will return a heavyweight,
	/// wrappable vtkGraphEdge object, which has the same fields as vtkEdgeType
	/// accessible through getter methods.
	///
	/// To traverse all edges outgoing from a vertex, create a vtkOutEdgeIterator and
	/// call graph-&gt;GetOutEdges(v, it). it-&gt;Next() returns a lightweight vtkOutEdgeType
	/// containing the fields Id and Target. The source of the edge is always the
	/// vertex that was passed as an argument to GetOutEdges().
	/// Incoming edges may be similarly traversed with vtkInEdgeIterator, which returns
	/// vtkInEdgeType structures with Id and Source fields.
	/// Both vtkOutEdgeIterator and vtkInEdgeIterator also provide the wrapper functions
	/// NextGraphEdge() which return vtkGraphEdge objects.
	///
	/// An additional iterator, vtkAdjacentVertexIterator can traverse outgoing vertices
	/// directly, instead needing to parse through edges. Initialize the iterator by
	/// calling graph-&gt;GetAdjacentVertices(v, it).
	///
	/// vtkGraph has two instances of vtkDataSetAttributes for associated
	/// vertex and edge data. It also has a vtkPoints instance which may store
	/// x,y,z locations for each vertex. This is populated by filters such as
	/// vtkGraphLayout and vtkAssignCoordinates.
	///
	/// All graph types share the same implementation, so the structure of one
	/// may be shared among multiple graphs, even graphs of different types.
	/// Structures from vtkUndirectedGraph and vtkMutableUndirectedGraph may be
	/// shared directly.  Structures from vtkDirectedGraph, vtkMutableDirectedGraph,
	/// and vtkTree may be shared directly with the exception that setting a
	/// structure to a tree requires that a "is a tree" test passes.
	///
	/// For graph types that are known to be compatible, calling ShallowCopy()
	/// or DeepCopy() will work as expected.  When the outcome of a conversion
	/// is unknown (i.e. setting a graph to a tree), CheckedShallowCopy() and
	/// CheckedDeepCopy() exist which are identical to ShallowCopy() and DeepCopy(),
	/// except that instead of emitting an error for an incompatible structure,
	/// the function returns false.  This allows you to programmatically check
	/// structure compatibility without causing error messages.
	///
	/// To construct a graph, use vtkMutableDirectedGraph or
	/// vtkMutableUndirectedGraph. You may then use CheckedShallowCopy
	/// to set the contents of a mutable graph type into one of the non-mutable
	/// types vtkDirectedGraph, vtkUndirectedGraph.
	/// To construct a tree, use vtkMutableDirectedGraph, with directed edges
	/// which point from the parent to the child, then use CheckedShallowCopy
	/// to set the structure to a vtkTree.
	///
	/// @warning
	/// All copy operations implement copy-on-write. The structures are initially
	/// shared, but if one of the graphs is modified, the structure is copied
	/// so that to the user they function as if they were deep copied. This means
	/// that care must be taken if different threads are accessing different graph
	/// instances that share the same structure. Race conditions may develop if
	/// one thread is modifying the graph at the same time that another graph is
	/// copying the structure.
	///
	/// @par Vertex pedigree IDs:
	/// The vertices in a vtkGraph can be associated with pedigree IDs
	/// through GetVertexData()-&gt;SetPedigreeIds. In this case, there is a
	/// 1-1 mapping between pedigree Ids and vertices. One can query the
	/// vertex ID based on the pedigree ID using FindVertex, add new
	/// vertices by pedigree ID with AddVertex, and add edges based on the
	/// pedigree IDs of the source and target vertices. For example,
	/// AddEdge("Here", "There") will find (or add) vertices with pedigree
	/// ID "Here" and "There" and then introduce an edge from "Here" to
	/// "There".
	///
	/// @par Vertex pedigree IDs:
	/// To configure the vtkGraph with a pedigree ID mapping, create a
	/// vtkDataArray that will store the pedigree IDs and set that array as
	/// the pedigree ID array for the vertices via
	/// GetVertexData()-&gt;SetPedigreeIds().
	///
	///
	/// @par Distributed graphs:
	/// vtkGraph instances can be distributed across multiple machines, to
	/// allow the construction and manipulation of graphs larger than a
	/// single machine could handle. A distributed graph will typically be
	/// distributed across many different nodes within a cluster, using the
	/// Message Passing Interface (MPI) to allow those cluster nodes to
	/// communicate.
	///
	/// @par Distributed graphs:
	/// An empty vtkGraph can be made into a distributed graph by attaching
	/// an instance of a vtkDistributedGraphHelper via the
	/// SetDistributedGraphHelper() method. To determine whether a graph is
	/// distributed or not, call GetDistributedGraphHelper() and check
	/// whether the result is non-nullptr. For a distributed graph, the number
	/// of processors across which the graph is distributed can be
	/// retrieved by extracting the value for the DATA_NUMBER_OF_PIECES key
	/// in the vtkInformation object (retrieved by GetInformation())
	/// associated with the graph. Similarly, the value corresponding to
	/// the DATA_PIECE_NUMBER key of the vtkInformation object describes
	/// which piece of the data this graph instance provides.
	///
	/// @par Distributed graphs:
	/// Distributed graphs behave somewhat differently from non-distributed
	/// graphs, and will require special care. In a distributed graph, each
	/// of the processors will contain a subset of the vertices in the
	/// graph. That subset of vertices can be accessed via the
	/// vtkVertexListIterator produced by GetVertices().
	/// GetNumberOfVertices(), therefore, returns the number of vertices
	/// stored locally: it does not account for vertices stored on other
	/// processors. A vertex (or edge) is identified by both the rank of
	/// its owning processor and by its index within that processor, both
	/// of which are encoded within the vtkIdType value that describes that
	/// vertex (or edge). The owning processor is a value between 0 and
	/// P-1, where P is the number of processors across which the vtkGraph
	/// has been distributed. The local index will be a value between 0 and
	/// GetNumberOfVertices(), for vertices, or GetNumberOfEdges(), for
	/// edges, and can be used to access the local parts of distributed
	/// data arrays. When given a vtkIdType identifying a vertex, one can
	/// determine the owner of the vertex with
	/// vtkDistributedGraphHelper::GetVertexOwner() and the local index
	/// with vtkDistributedGraphHelper::GetVertexIndex(). With edges, the
	/// appropriate methods are vtkDistributedGraphHelper::GetEdgeOwner()
	/// and vtkDistributedGraphHelper::GetEdgeIndex(), respectively. To
	/// construct a vtkIdType representing either a vertex or edge given
	/// only its owner and local index, use
	/// vtkDistributedGraphHelper::MakeDistributedId().
	///
	/// @par Distributed graphs:
	/// The edges in a distributed graph are always stored on the
	/// processors that own the vertices named by the edge. For example,
	/// given a directed edge (u, v), the edge will be stored in the
	/// out-edges list for vertex u on the processor that owns u, and in
	/// the in-edges list for vertex v on the processor that owns v. This
	/// "row-wise" decomposition of the graph means that, for any vertex
	/// that is local to a processor, that processor can look at all of the
	/// incoming and outgoing edges of the graph. Processors cannot,
	/// however, access the incoming or outgoing edge lists of vertex owned
	/// by other processors. Vertices owned by other processors will not be
	/// encountered when traversing the vertex list via GetVertices(), but
	/// may be encountered by traversing the in- and out-edge lists of
	/// local vertices or the edge list.
	///
	/// @par Distributed graphs:
	/// Distributed graphs can have pedigree IDs for the vertices in the
	/// same way that non-distributed graphs can. In this case, the
	/// distribution of the vertices in the graph is based on pedigree
	/// ID. For example, a vertex with the pedigree ID "Here" might land on
	/// processor 0 while a vertex pedigree ID "There" would end up on
	/// processor 3. By default, the pedigree IDs themselves are hashed to
	/// give a random (and, hopefully, even) distribution of the
	/// vertices. However, one can provide a different vertex distribution
	/// function by calling
	/// vtkDistributedGraphHelper::SetVertexPedigreeIdDistribution.  Once a
	/// distributed graph has pedigree IDs, the no-argument AddVertex()
	/// method can no longer be used. Additionally, once a vertex has a
	/// pedigree ID, that pedigree ID should not be changed unless the user
	/// can guarantee that the vertex distribution will still map that
	/// vertex to the same processor where it already resides.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkDirectedGraph vtkUndirectedGraph vtkMutableDirectedGraph
	/// vtkMutableUndirectedGraph vtkTree vtkDistributedGraphHelper
	///
	/// @par Thanks:
	/// Thanks to Brian Wylie, Timothy Shead, Ken Moreland of Sandia National
	/// Laboratories and Douglas Gregor of Indiana University for designing these
	/// classes.
	/// </seealso>
	// Token: 0x02000A40 RID: 2624
	public abstract class vtkGraph : vtkDataObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601B52A RID: 111914 RVA: 0x002633AB File Offset: 0x002615AB
		static vtkGraph()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGraph.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGraph"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601B52B RID: 111915 RVA: 0x002633D3 File Offset: 0x002615D3
		public vtkGraph(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601B52C RID: 111916 RVA: 0x002633E1 File Offset: 0x002615E1
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601B52D RID: 111917
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraph_AddEdgePoint_01(HandleRef pThis, long e, IntPtr x);

		/// <summary>
		/// Adds a point to the end of the list of edge points for a certain edge.
		/// </summary>
		// Token: 0x0601B52E RID: 111918 RVA: 0x002633EC File Offset: 0x002615EC
		public void AddEdgePoint(long e, IntPtr x)
		{
			vtkGraph.vtkGraph_AddEdgePoint_01(base.GetCppThis(), e, x);
		}

		// Token: 0x0601B52F RID: 111919
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraph_AddEdgePoint_02(HandleRef pThis, long e, double x, double y, double z);

		/// <summary>
		/// Adds a point to the end of the list of edge points for a certain edge.
		/// </summary>
		// Token: 0x0601B530 RID: 111920 RVA: 0x002633FD File Offset: 0x002615FD
		public void AddEdgePoint(long e, double x, double y, double z)
		{
			vtkGraph.vtkGraph_AddEdgePoint_02(base.GetCppThis(), e, x, y, z);
		}

		// Token: 0x0601B531 RID: 111921
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGraph_CheckedDeepCopy_03(HandleRef pThis, HandleRef g);

		/// <summary>
		/// Performs the same operation as DeepCopy(),
		/// but instead of reporting an error for an incompatible graph,
		/// returns false.
		/// </summary>
		// Token: 0x0601B532 RID: 111922 RVA: 0x00263414 File Offset: 0x00261614
		public virtual bool CheckedDeepCopy(vtkGraph g)
		{
			return vtkGraph.vtkGraph_CheckedDeepCopy_03(base.GetCppThis(), (g == null) ? default(HandleRef) : g.GetCppThis()) != 0;
		}

		// Token: 0x0601B533 RID: 111923
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGraph_CheckedShallowCopy_04(HandleRef pThis, HandleRef g);

		/// <summary>
		/// Performs the same operation as ShallowCopy(),
		/// but instead of reporting an error for an incompatible graph,
		/// returns false.
		/// </summary>
		// Token: 0x0601B534 RID: 111924 RVA: 0x00263450 File Offset: 0x00261650
		public virtual bool CheckedShallowCopy(vtkGraph g)
		{
			return vtkGraph.vtkGraph_CheckedShallowCopy_04(base.GetCppThis(), (g == null) ? default(HandleRef) : g.GetCppThis()) != 0;
		}

		// Token: 0x0601B535 RID: 111925
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraph_ClearEdgePoints_05(HandleRef pThis, long e);

		/// <summary>
		/// Clear all points associated with an edge.
		/// </summary>
		// Token: 0x0601B536 RID: 111926 RVA: 0x0026348B File Offset: 0x0026168B
		public void ClearEdgePoints(long e)
		{
			vtkGraph.vtkGraph_ClearEdgePoints_05(base.GetCppThis(), e);
		}

		// Token: 0x0601B537 RID: 111927
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraph_ComputeBounds_06(HandleRef pThis);

		/// <summary>
		/// Compute the bounds of the graph. In a distributed graph, this
		/// computes the bounds around the local part of the graph.
		/// </summary>
		// Token: 0x0601B538 RID: 111928 RVA: 0x0026349B File Offset: 0x0026169B
		public void ComputeBounds()
		{
			vtkGraph.vtkGraph_ComputeBounds_06(base.GetCppThis());
		}

		// Token: 0x0601B539 RID: 111929
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraph_CopyStructure_07(HandleRef pThis, HandleRef g);

		/// <summary>
		/// Does a shallow copy of the topological information,
		/// but not the associated attributes.
		/// </summary>
		// Token: 0x0601B53A RID: 111930 RVA: 0x002634AC File Offset: 0x002616AC
		public virtual void CopyStructure(vtkGraph g)
		{
			vtkGraph.vtkGraph_CopyStructure_07(base.GetCppThis(), (g == null) ? default(HandleRef) : g.GetCppThis());
		}

		// Token: 0x0601B53B RID: 111931
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraph_DeepCopy_08(HandleRef pThis, HandleRef obj);

		/// <summary>
		/// Deep copies the data object into this graph.
		/// If it is an incompatible graph, reports an error.
		/// </summary>
		// Token: 0x0601B53C RID: 111932 RVA: 0x002634DC File Offset: 0x002616DC
		public override void DeepCopy(vtkDataObject obj)
		{
			vtkGraph.vtkGraph_DeepCopy_08(base.GetCppThis(), (obj == null) ? default(HandleRef) : obj.GetCppThis());
		}

		// Token: 0x0601B53D RID: 111933
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraph_DeepCopyEdgePoints_09(HandleRef pThis, HandleRef g);

		/// <summary>
		/// Copy the internal edge point data from another graph into this graph.
		/// Both graphs must have the same number of edges.
		/// </summary>
		// Token: 0x0601B53E RID: 111934 RVA: 0x0026350C File Offset: 0x0026170C
		public void DeepCopyEdgePoints(vtkGraph g)
		{
			vtkGraph.vtkGraph_DeepCopyEdgePoints_09(base.GetCppThis(), (g == null) ? default(HandleRef) : g.GetCppThis());
		}

		// Token: 0x0601B53F RID: 111935
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraph_Dump_10(HandleRef pThis);

		/// <summary>
		/// Dump the contents of the graph to standard output.
		/// </summary>
		// Token: 0x0601B540 RID: 111936 RVA: 0x0026353B File Offset: 0x0026173B
		public void Dump()
		{
			vtkGraph.vtkGraph_Dump_10(base.GetCppThis());
		}

		// Token: 0x0601B541 RID: 111937
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraph_FindVertex_11(HandleRef pThis, HandleRef pedigreeID);

		/// <summary>
		/// Retrieve the vertex with the given pedigree ID. If successful,
		/// returns the ID of the vertex. Otherwise, either the vertex data
		/// does not have a pedigree ID array or there is no vertex with the
		/// given pedigree ID, so this function returns -1.
		/// If the graph is a distributed graph, this method will return the
		/// Distributed-ID of the vertex.
		/// </summary>
		// Token: 0x0601B542 RID: 111938 RVA: 0x0026354C File Offset: 0x0026174C
		public long FindVertex(vtkVariant pedigreeID)
		{
			return vtkGraph.vtkGraph_FindVertex_11(base.GetCppThis(), (pedigreeID == null) ? default(HandleRef) : pedigreeID.GetCppThis());
		}

		// Token: 0x0601B543 RID: 111939
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkGraph_GetActualMemorySize_12(HandleRef pThis);

		/// <summary>
		/// Return the actual size of the data in kibibytes (1024 bytes). This number
		/// is valid only after the pipeline has updated. The memory size
		/// returned is guaranteed to be greater than or equal to the
		/// memory required to represent the data (e.g., extra space in
		/// arrays, etc. are not included in the return value).
		/// </summary>
		// Token: 0x0601B544 RID: 111940 RVA: 0x00263580 File Offset: 0x00261780
		public override uint GetActualMemorySize()
		{
			return vtkGraph.vtkGraph_GetActualMemorySize_12(base.GetCppThis());
		}

		// Token: 0x0601B545 RID: 111941
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraph_GetAdjacentVertices_13(HandleRef pThis, long v, HandleRef it);

		/// <summary>
		/// Initializes the adjacent vertex iterator to iterate over
		/// all outgoing vertices from vertex v.  For an undirected graph,
		/// returns all adjacent vertices. In a distributed graph, the vertex
		/// v must be local to this processor.
		/// </summary>
		// Token: 0x0601B546 RID: 111942 RVA: 0x002635A0 File Offset: 0x002617A0
		public virtual void GetAdjacentVertices(long v, vtkAdjacentVertexIterator it)
		{
			vtkGraph.vtkGraph_GetAdjacentVertices_13(base.GetCppThis(), v, (it == null) ? default(HandleRef) : it.GetCppThis());
		}

		// Token: 0x0601B547 RID: 111943
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraph_GetAttributesAsFieldData_14(HandleRef pThis, int type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the attributes of the data object as a vtkFieldData.
		/// This returns non-null values in all the same cases as GetAttributes,
		/// in addition to the case of FIELD, which will return the field data
		/// for any vtkDataObject subclass.
		/// </summary>
		// Token: 0x0601B548 RID: 111944 RVA: 0x002635D0 File Offset: 0x002617D0
		public override vtkFieldData GetAttributesAsFieldData(int type)
		{
			vtkFieldData vtkFieldData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraph.vtkGraph_GetAttributesAsFieldData_14(base.GetCppThis(), type, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFieldData = (vtkFieldData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFieldData.Register(null);
				}
			}
			return vtkFieldData;
		}

		// Token: 0x0601B549 RID: 111945
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraph_GetBounds_15(HandleRef pThis);

		/// <summary>
		/// Return a pointer to the geometry bounding box in the form
		/// (xmin,xmax, ymin,ymax, zmin,zmax). In a distributed graph, this
		/// computes the bounds around the local part of the graph.
		/// </summary>
		// Token: 0x0601B54A RID: 111946 RVA: 0x00263640 File Offset: 0x00261840
		public IntPtr GetBounds()
		{
			return vtkGraph.vtkGraph_GetBounds_15(base.GetCppThis());
		}

		// Token: 0x0601B54B RID: 111947
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraph_GetBounds_16(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Return a pointer to the geometry bounding box in the form
		/// (xmin,xmax, ymin,ymax, zmin,zmax). In a distributed graph, this
		/// computes the bounds around the local part of the graph.
		/// </summary>
		// Token: 0x0601B54C RID: 111948 RVA: 0x0026365F File Offset: 0x0026185F
		public void GetBounds(IntPtr bounds)
		{
			vtkGraph.vtkGraph_GetBounds_16(base.GetCppThis(), bounds);
		}

		// Token: 0x0601B54D RID: 111949
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraph_GetData_17(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve a graph from an information vector.
		/// </summary>
		// Token: 0x0601B54E RID: 111950 RVA: 0x00263670 File Offset: 0x00261870
		public new static vtkGraph GetData(vtkInformation info)
		{
			vtkGraph vtkGraph = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraph.vtkGraph_GetData_17((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraph = (vtkGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraph.Register(null);
				}
			}
			return vtkGraph;
		}

		// Token: 0x0601B54F RID: 111951
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraph_GetData_18(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve a graph from an information vector.
		/// </summary>
		// Token: 0x0601B550 RID: 111952 RVA: 0x002636F0 File Offset: 0x002618F0
		public new static vtkGraph GetData(vtkInformationVector v, int i)
		{
			vtkGraph vtkGraph = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraph.vtkGraph_GetData_18((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraph = (vtkGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraph.Register(null);
				}
			}
			return vtkGraph;
		}

		// Token: 0x0601B551 RID: 111953
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraph_GetDataObjectType_19(HandleRef pThis);

		/// <summary>
		/// Return what type of dataset this is.
		/// </summary>
		// Token: 0x0601B552 RID: 111954 RVA: 0x00263770 File Offset: 0x00261970
		public override int GetDataObjectType()
		{
			return vtkGraph.vtkGraph_GetDataObjectType_19(base.GetCppThis());
		}

		// Token: 0x0601B553 RID: 111955
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraph_GetDegree_20(HandleRef pThis, long v);

		/// <summary>
		/// The total of all incoming and outgoing vertices for vertex v.
		/// For undirected graphs, this is simply the number of edges incident
		/// to v. In a distributed graph, the vertex v must be local to this
		/// processor.
		/// </summary>
		// Token: 0x0601B554 RID: 111956 RVA: 0x00263790 File Offset: 0x00261990
		public virtual long GetDegree(long v)
		{
			return vtkGraph.vtkGraph_GetDegree_20(base.GetCppThis(), v);
		}

		// Token: 0x0601B555 RID: 111957
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraph_GetDistributedGraphHelper_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieves the distributed graph helper for this graph
		/// </summary>
		// Token: 0x0601B556 RID: 111958 RVA: 0x002637B0 File Offset: 0x002619B0
		public vtkDistributedGraphHelper GetDistributedGraphHelper()
		{
			vtkDistributedGraphHelper vtkDistributedGraphHelper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraph.vtkGraph_GetDistributedGraphHelper_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDistributedGraphHelper = (vtkDistributedGraphHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDistributedGraphHelper.Register(null);
				}
			}
			return vtkDistributedGraphHelper;
		}

		// Token: 0x0601B557 RID: 111959
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraph_GetEdgeData_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the vertex or edge data.
		/// </summary>
		// Token: 0x0601B558 RID: 111960 RVA: 0x00263820 File Offset: 0x00261A20
		public virtual vtkDataSetAttributes GetEdgeData()
		{
			vtkDataSetAttributes vtkDataSetAttributes = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraph.vtkGraph_GetEdgeData_22(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSetAttributes = (vtkDataSetAttributes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSetAttributes.Register(null);
				}
			}
			return vtkDataSetAttributes;
		}

		// Token: 0x0601B559 RID: 111961
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraph_GetEdgeId_23(HandleRef pThis, long a, long b);

		/// <summary>
		/// Returns the Id of the edge between vertex a and vertex b.
		/// This is independent of directionality of the edge, that is,
		/// if edge A-&gt;B exists or if edge B-&gt;A exists, this function will
		/// return its Id. If multiple edges exist between a and b, here is no guarantee
		/// about which one will be returned.
		/// Returns -1 if no edge exists between a and b.
		/// </summary>
		// Token: 0x0601B55A RID: 111962 RVA: 0x00263890 File Offset: 0x00261A90
		public long GetEdgeId(long a, long b)
		{
			return vtkGraph.vtkGraph_GetEdgeId_23(base.GetCppThis(), a, b);
		}

		// Token: 0x0601B55B RID: 111963
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraph_GetEdgePoint_24(HandleRef pThis, long e, long i);

		/// <summary>
		/// Get the x,y,z location of a point along edge e.
		/// </summary>
		// Token: 0x0601B55C RID: 111964 RVA: 0x002638B4 File Offset: 0x00261AB4
		public double[] GetEdgePoint(long e, long i)
		{
			IntPtr intPtr = vtkGraph.vtkGraph_GetEdgePoint_24(base.GetCppThis(), e, i);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601B55D RID: 111965
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraph_GetEdges_25(HandleRef pThis, HandleRef it);

		/// <summary>
		/// Initializes the edge list iterator to iterate over all
		/// edges in the graph. Edges may not be traversed in order of
		/// increasing edge id. In a distributed graph, this returns edges
		/// that are stored locally.
		/// </summary>
		// Token: 0x0601B55E RID: 111966 RVA: 0x00263900 File Offset: 0x00261B00
		public virtual void GetEdges(vtkEdgeListIterator it)
		{
			vtkGraph.vtkGraph_GetEdges_25(base.GetCppThis(), (it == null) ? default(HandleRef) : it.GetCppThis());
		}

		// Token: 0x0601B55F RID: 111967
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraph_GetGraphInternals_26(HandleRef pThis, byte modifying, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the internal representation of the graph. If modifying is
		/// true, then the returned vtkGraphInternals object will be unique to
		/// this vtkGraph object.
		/// </summary>
		// Token: 0x0601B560 RID: 111968 RVA: 0x00263930 File Offset: 0x00261B30
		public vtkGraphInternals GetGraphInternals(bool modifying)
		{
			vtkGraphInternals vtkGraphInternals = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraph.vtkGraph_GetGraphInternals_26(base.GetCppThis(), modifying ? (byte)1 : (byte)0, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraphInternals = (vtkGraphInternals)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraphInternals.Register(null);
				}
			}
			return vtkGraphInternals;
		}

		// Token: 0x0601B561 RID: 111969
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraph_GetInDegree_27(HandleRef pThis, long v);

		/// <summary>
		/// The number of incoming edges to vertex v.
		/// For undirected graphs, returns the same as GetDegree(). In a
		/// distributed graph, the vertex v must be local to this processor.
		/// </summary>
		// Token: 0x0601B562 RID: 111970 RVA: 0x002639A8 File Offset: 0x00261BA8
		public virtual long GetInDegree(long v)
		{
			return vtkGraph.vtkGraph_GetInDegree_27(base.GetCppThis(), v);
		}

		// Token: 0x0601B563 RID: 111971
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraph_GetInEdge_28(HandleRef pThis, long v, long index, HandleRef e);

		/// <summary>
		/// Random-access method for retrieving incoming edges to vertex v.
		/// The method fills the vtkGraphEdge instance with the id, source, and
		/// target of the edge. This method is provided for wrappers,
		/// GetInEdge(vtkIdType, vtkIdType) is preferred.
		/// </summary>
		// Token: 0x0601B564 RID: 111972 RVA: 0x002639C8 File Offset: 0x00261BC8
		public virtual void GetInEdge(long v, long index, vtkGraphEdge e)
		{
			vtkGraph.vtkGraph_GetInEdge_28(base.GetCppThis(), v, index, (e == null) ? default(HandleRef) : e.GetCppThis());
		}

		// Token: 0x0601B565 RID: 111973
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraph_GetInEdges_29(HandleRef pThis, long v, HandleRef it);

		/// <summary>
		/// Initializes the in edge iterator to iterate over
		/// all incoming edges to vertex v.  For an undirected graph,
		/// returns all incident edges. In a distributed graph, the vertex
		/// v must be local to this processor.
		/// </summary>
		// Token: 0x0601B566 RID: 111974 RVA: 0x002639FC File Offset: 0x00261BFC
		public virtual void GetInEdges(long v, vtkInEdgeIterator it)
		{
			vtkGraph.vtkGraph_GetInEdges_29(base.GetCppThis(), v, (it == null) ? default(HandleRef) : it.GetCppThis());
		}

		// Token: 0x0601B567 RID: 111975
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraph_GetInducedEdges_30(HandleRef pThis, HandleRef verts, HandleRef edges);

		/// <summary>
		/// Fills a list of edge indices with the edges contained in the induced
		/// subgraph formed by the vertices in the vertex list.
		/// </summary>
		// Token: 0x0601B568 RID: 111976 RVA: 0x00263A2C File Offset: 0x00261C2C
		public void GetInducedEdges(vtkIdTypeArray verts, vtkIdTypeArray edges)
		{
			vtkGraph.vtkGraph_GetInducedEdges_30(base.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (edges == null) ? default(HandleRef) : edges.GetCppThis());
		}

		// Token: 0x0601B569 RID: 111977
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkGraph_GetMTime_31(HandleRef pThis);

		/// <summary>
		/// The modified time of the graph.
		/// </summary>
		// Token: 0x0601B56A RID: 111978 RVA: 0x00263A70 File Offset: 0x00261C70
		public override ulong GetMTime()
		{
			return vtkGraph.vtkGraph_GetMTime_31(base.GetCppThis());
		}

		// Token: 0x0601B56B RID: 111979
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraph_GetNumberOfEdgePoints_32(HandleRef pThis, long e);

		/// <summary>
		/// Get the number of edge points associated with an edge.
		/// </summary>
		// Token: 0x0601B56C RID: 111980 RVA: 0x00263A90 File Offset: 0x00261C90
		public long GetNumberOfEdgePoints(long e)
		{
			return vtkGraph.vtkGraph_GetNumberOfEdgePoints_32(base.GetCppThis(), e);
		}

		// Token: 0x0601B56D RID: 111981
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraph_GetNumberOfEdges_33(HandleRef pThis);

		/// <summary>
		/// The number of edges in the graph. In a distributed graph,
		/// this returns the number of edges stored locally.
		/// </summary>
		// Token: 0x0601B56E RID: 111982 RVA: 0x00263AB0 File Offset: 0x00261CB0
		public virtual long GetNumberOfEdges()
		{
			return vtkGraph.vtkGraph_GetNumberOfEdges_33(base.GetCppThis());
		}

		// Token: 0x0601B56F RID: 111983
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraph_GetNumberOfElements_34(HandleRef pThis, int type);

		/// <summary>
		/// Get the number of elements for a specific attribute type (VERTEX, EDGE, etc.).
		/// </summary>
		// Token: 0x0601B570 RID: 111984 RVA: 0x00263AD0 File Offset: 0x00261CD0
		public override long GetNumberOfElements(int type)
		{
			return vtkGraph.vtkGraph_GetNumberOfElements_34(base.GetCppThis(), type);
		}

		// Token: 0x0601B571 RID: 111985
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraph_GetNumberOfGenerationsFromBase_35(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B572 RID: 111986 RVA: 0x00263AF0 File Offset: 0x00261CF0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGraph.vtkGraph_GetNumberOfGenerationsFromBase_35(base.GetCppThis(), type);
		}

		// Token: 0x0601B573 RID: 111987
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraph_GetNumberOfGenerationsFromBaseType_36([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B574 RID: 111988 RVA: 0x00263B10 File Offset: 0x00261D10
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGraph.vtkGraph_GetNumberOfGenerationsFromBaseType_36(type);
		}

		// Token: 0x0601B575 RID: 111989
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraph_GetNumberOfVertices_37(HandleRef pThis);

		/// <summary>
		/// The number of vertices in the graph. In a distributed graph,
		/// returns the number of local vertices in the graph.
		/// </summary>
		// Token: 0x0601B576 RID: 111990 RVA: 0x00263B2C File Offset: 0x00261D2C
		public virtual long GetNumberOfVertices()
		{
			return vtkGraph.vtkGraph_GetNumberOfVertices_37(base.GetCppThis());
		}

		// Token: 0x0601B577 RID: 111991
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraph_GetOutDegree_38(HandleRef pThis, long v);

		/// <summary>
		/// The number of outgoing edges from vertex v.
		/// For undirected graphs, returns the same as GetDegree(). In a
		/// distributed graph, the vertex v must be local to this processor.
		/// </summary>
		// Token: 0x0601B578 RID: 111992 RVA: 0x00263B4C File Offset: 0x00261D4C
		public virtual long GetOutDegree(long v)
		{
			return vtkGraph.vtkGraph_GetOutDegree_38(base.GetCppThis(), v);
		}

		// Token: 0x0601B579 RID: 111993
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraph_GetOutEdge_39(HandleRef pThis, long v, long index, HandleRef e);

		/// <summary>
		/// Random-access method for retrieving outgoing edges from vertex v.
		/// The method fills the vtkGraphEdge instance with the id, source, and
		/// target of the edge. This method is provided for wrappers,
		/// GetOutEdge(vtkIdType, vtkIdType) is preferred.
		/// </summary>
		// Token: 0x0601B57A RID: 111994 RVA: 0x00263B6C File Offset: 0x00261D6C
		public virtual void GetOutEdge(long v, long index, vtkGraphEdge e)
		{
			vtkGraph.vtkGraph_GetOutEdge_39(base.GetCppThis(), v, index, (e == null) ? default(HandleRef) : e.GetCppThis());
		}

		// Token: 0x0601B57B RID: 111995
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraph_GetOutEdges_40(HandleRef pThis, long v, HandleRef it);

		/// <summary>
		/// Initializes the out edge iterator to iterate over
		/// all outgoing edges of vertex v.  For an undirected graph,
		/// returns all incident edges. In a distributed graph, the vertex
		/// v must be local to this processor.
		/// </summary>
		// Token: 0x0601B57C RID: 111996 RVA: 0x00263BA0 File Offset: 0x00261DA0
		public virtual void GetOutEdges(long v, vtkOutEdgeIterator it)
		{
			vtkGraph.vtkGraph_GetOutEdges_40(base.GetCppThis(), v, (it == null) ? default(HandleRef) : it.GetCppThis());
		}

		// Token: 0x0601B57D RID: 111997
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraph_GetPoint_41(HandleRef pThis, long ptId);

		/// <summary>
		/// These methods return the point (0,0,0) until the points structure
		/// is created, when it returns the actual point position. In a
		/// distributed graph, only the points for local vertices can be
		/// retrieved.
		/// </summary>
		// Token: 0x0601B57E RID: 111998 RVA: 0x00263BD0 File Offset: 0x00261DD0
		public IntPtr GetPoint(long ptId)
		{
			return vtkGraph.vtkGraph_GetPoint_41(base.GetCppThis(), ptId);
		}

		// Token: 0x0601B57F RID: 111999
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraph_GetPoint_42(HandleRef pThis, long ptId, IntPtr x);

		/// <summary>
		/// These methods return the point (0,0,0) until the points structure
		/// is created, when it returns the actual point position. In a
		/// distributed graph, only the points for local vertices can be
		/// retrieved.
		/// </summary>
		// Token: 0x0601B580 RID: 112000 RVA: 0x00263BF0 File Offset: 0x00261DF0
		public void GetPoint(long ptId, IntPtr x)
		{
			vtkGraph.vtkGraph_GetPoint_42(base.GetCppThis(), ptId, x);
		}

		// Token: 0x0601B581 RID: 112001
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraph_GetPoints_43(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the points array for this graph.
		/// If points is not yet constructed, generates and returns
		/// a new points array filled with (0,0,0) coordinates. In a
		/// distributed graph, only the points for local vertices can be
		/// retrieved or modified.
		/// </summary>
		// Token: 0x0601B582 RID: 112002 RVA: 0x00263C04 File Offset: 0x00261E04
		public vtkPoints GetPoints()
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraph.vtkGraph_GetPoints_43(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPoints = (vtkPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPoints.Register(null);
				}
			}
			return vtkPoints;
		}

		// Token: 0x0601B583 RID: 112003
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraph_GetSourceVertex_44(HandleRef pThis, long e);

		/// <summary>
		/// Retrieve the source and target vertices for an edge id.
		/// NOTE: The first time this is called, the graph will build
		/// a mapping array from edge id to source/target that is the
		/// same size as the number of edges in the graph. If you have
		/// access to a vtkOutEdgeType, vtkInEdgeType, vtkEdgeType, or
		/// vtkGraphEdge, you should directly use these structures
		/// to look up the source or target instead of this method.
		/// </summary>
		// Token: 0x0601B584 RID: 112004 RVA: 0x00263C74 File Offset: 0x00261E74
		public long GetSourceVertex(long e)
		{
			return vtkGraph.vtkGraph_GetSourceVertex_44(base.GetCppThis(), e);
		}

		// Token: 0x0601B585 RID: 112005
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraph_GetTargetVertex_45(HandleRef pThis, long e);

		/// <summary>
		/// Retrieve the source and target vertices for an edge id.
		/// NOTE: The first time this is called, the graph will build
		/// a mapping array from edge id to source/target that is the
		/// same size as the number of edges in the graph. If you have
		/// access to a vtkOutEdgeType, vtkInEdgeType, vtkEdgeType, or
		/// vtkGraphEdge, you should directly use these structures
		/// to look up the source or target instead of this method.
		/// </summary>
		// Token: 0x0601B586 RID: 112006 RVA: 0x00263C94 File Offset: 0x00261E94
		public long GetTargetVertex(long e)
		{
			return vtkGraph.vtkGraph_GetTargetVertex_45(base.GetCppThis(), e);
		}

		// Token: 0x0601B587 RID: 112007
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraph_GetVertexData_46(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the vertex or edge data.
		/// </summary>
		// Token: 0x0601B588 RID: 112008 RVA: 0x00263CB4 File Offset: 0x00261EB4
		public virtual vtkDataSetAttributes GetVertexData()
		{
			vtkDataSetAttributes vtkDataSetAttributes = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraph.vtkGraph_GetVertexData_46(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSetAttributes = (vtkDataSetAttributes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSetAttributes.Register(null);
				}
			}
			return vtkDataSetAttributes;
		}

		// Token: 0x0601B589 RID: 112009
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraph_GetVertices_47(HandleRef pThis, HandleRef it);

		/// <summary>
		/// Initializes the vertex list iterator to iterate over all
		/// vertices in the graph. In a distributed graph, the iterator
		/// traverses all local vertices.
		/// </summary>
		// Token: 0x0601B58A RID: 112010 RVA: 0x00263D24 File Offset: 0x00261F24
		public virtual void GetVertices(vtkVertexListIterator it)
		{
			vtkGraph.vtkGraph_GetVertices_47(base.GetCppThis(), (it == null) ? default(HandleRef) : it.GetCppThis());
		}

		// Token: 0x0601B58B RID: 112011
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraph_Initialize_48(HandleRef pThis);

		/// <summary>
		/// Initialize to an empty graph.
		/// </summary>
		// Token: 0x0601B58C RID: 112012 RVA: 0x00263D53 File Offset: 0x00261F53
		public override void Initialize()
		{
			vtkGraph.vtkGraph_Initialize_48(base.GetCppThis());
		}

		// Token: 0x0601B58D RID: 112013
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraph_IsA_49(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B58E RID: 112014 RVA: 0x00263D64 File Offset: 0x00261F64
		public override int IsA(string type)
		{
			return vtkGraph.vtkGraph_IsA_49(base.GetCppThis(), type);
		}

		// Token: 0x0601B58F RID: 112015
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGraph_IsSameStructure_50(HandleRef pThis, HandleRef other);

		/// <summary>
		/// Returns true if both graphs point to the same adjacency structure.
		/// Can be used to test the copy-on-write feature of the graph.
		/// </summary>
		// Token: 0x0601B590 RID: 112016 RVA: 0x00263D84 File Offset: 0x00261F84
		public bool IsSameStructure(vtkGraph other)
		{
			return vtkGraph.vtkGraph_IsSameStructure_50(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis()) != 0;
		}

		// Token: 0x0601B591 RID: 112017
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraph_IsTypeOf_51([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B592 RID: 112018 RVA: 0x00263DC0 File Offset: 0x00261FC0
		public new static int IsTypeOf(string type)
		{
			return vtkGraph.vtkGraph_IsTypeOf_51(type);
		}

		// Token: 0x0601B593 RID: 112019
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraph_NewInstance_52(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B594 RID: 112020 RVA: 0x00263DDC File Offset: 0x00261FDC
		public new vtkGraph NewInstance()
		{
			vtkGraph result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraph.vtkGraph_NewInstance_52(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601B595 RID: 112021
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraph_ReorderOutVertices_53(HandleRef pThis, long v, HandleRef vertices);

		/// <summary>
		/// Reorder the outgoing vertices of a vertex.
		/// The vertex list must have the same elements as the current out edge
		/// list, just in a different order.
		/// This method does not change the topology of the graph.
		/// In a distributed graph, the vertex v must be local.
		/// </summary>
		// Token: 0x0601B596 RID: 112022 RVA: 0x00263E38 File Offset: 0x00262038
		public void ReorderOutVertices(long v, vtkIdTypeArray vertices)
		{
			vtkGraph.vtkGraph_ReorderOutVertices_53(base.GetCppThis(), v, (vertices == null) ? default(HandleRef) : vertices.GetCppThis());
		}

		// Token: 0x0601B597 RID: 112023
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraph_SafeDownCast_54(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B598 RID: 112024 RVA: 0x00263E68 File Offset: 0x00262068
		public new static vtkGraph SafeDownCast(vtkObjectBase o)
		{
			vtkGraph vtkGraph = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraph.vtkGraph_SafeDownCast_54((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraph = (vtkGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraph.Register(null);
				}
			}
			return vtkGraph;
		}

		// Token: 0x0601B599 RID: 112025
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraph_SetDistributedGraphHelper_55(HandleRef pThis, HandleRef helper);

		/// <summary>
		/// Sets the distributed graph helper of this graph, turning it into a
		/// distributed graph. This operation can only be executed on an empty
		/// graph.
		/// </summary>
		// Token: 0x0601B59A RID: 112026 RVA: 0x00263EE8 File Offset: 0x002620E8
		public void SetDistributedGraphHelper(vtkDistributedGraphHelper helper)
		{
			vtkGraph.vtkGraph_SetDistributedGraphHelper_55(base.GetCppThis(), (helper == null) ? default(HandleRef) : helper.GetCppThis());
		}

		// Token: 0x0601B59B RID: 112027
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraph_SetEdgePoint_56(HandleRef pThis, long e, long i, IntPtr x);

		/// <summary>
		/// Set an x,y,z location of a point along an edge.
		/// This assumes there is already a point at location i, and simply
		/// overwrites it.
		/// </summary>
		// Token: 0x0601B59C RID: 112028 RVA: 0x00263F17 File Offset: 0x00262117
		public void SetEdgePoint(long e, long i, IntPtr x)
		{
			vtkGraph.vtkGraph_SetEdgePoint_56(base.GetCppThis(), e, i, x);
		}

		// Token: 0x0601B59D RID: 112029
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraph_SetEdgePoint_57(HandleRef pThis, long e, long i, double x, double y, double z);

		/// <summary>
		/// Set an x,y,z location of a point along an edge.
		/// This assumes there is already a point at location i, and simply
		/// overwrites it.
		/// </summary>
		// Token: 0x0601B59E RID: 112030 RVA: 0x00263F29 File Offset: 0x00262129
		public void SetEdgePoint(long e, long i, double x, double y, double z)
		{
			vtkGraph.vtkGraph_SetEdgePoint_57(base.GetCppThis(), e, i, x, y, z);
		}

		// Token: 0x0601B59F RID: 112031
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraph_SetEdgePoints_58(HandleRef pThis, long e, long npts, IntPtr pts);

		/// <summary>
		/// Get/Set the internal edge control points associated with each edge.
		/// The size of the pts array is 3*npts, and holds the x,y,z
		/// location of each edge control point.
		/// </summary>
		// Token: 0x0601B5A0 RID: 112032 RVA: 0x00263F3F File Offset: 0x0026213F
		public void SetEdgePoints(long e, long npts, IntPtr pts)
		{
			vtkGraph.vtkGraph_SetEdgePoints_58(base.GetCppThis(), e, npts, pts);
		}

		// Token: 0x0601B5A1 RID: 112033
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraph_SetPoints_59(HandleRef pThis, HandleRef points);

		/// <summary>
		/// Returns the points array for this graph.
		/// If points is not yet constructed, generates and returns
		/// a new points array filled with (0,0,0) coordinates. In a
		/// distributed graph, only the points for local vertices can be
		/// retrieved or modified.
		/// </summary>
		// Token: 0x0601B5A2 RID: 112034 RVA: 0x00263F54 File Offset: 0x00262154
		public virtual void SetPoints(vtkPoints points)
		{
			vtkGraph.vtkGraph_SetPoints_59(base.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis());
		}

		// Token: 0x0601B5A3 RID: 112035
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraph_ShallowCopy_60(HandleRef pThis, HandleRef obj);

		/// <summary>
		/// Shallow copies the data object into this graph.
		/// If it is an incompatible graph, reports an error.
		/// </summary>
		// Token: 0x0601B5A4 RID: 112036 RVA: 0x00263F84 File Offset: 0x00262184
		public override void ShallowCopy(vtkDataObject obj)
		{
			vtkGraph.vtkGraph_ShallowCopy_60(base.GetCppThis(), (obj == null) ? default(HandleRef) : obj.GetCppThis());
		}

		// Token: 0x0601B5A5 RID: 112037
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraph_ShallowCopyEdgePoints_61(HandleRef pThis, HandleRef g);

		/// <summary>
		/// Copy the internal edge point data from another graph into this graph.
		/// Both graphs must have the same number of edges.
		/// </summary>
		// Token: 0x0601B5A6 RID: 112038 RVA: 0x00263FB4 File Offset: 0x002621B4
		public void ShallowCopyEdgePoints(vtkGraph g)
		{
			vtkGraph.vtkGraph_ShallowCopyEdgePoints_61(base.GetCppThis(), (g == null) ? default(HandleRef) : g.GetCppThis());
		}

		// Token: 0x0601B5A7 RID: 112039
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraph_Squeeze_62(HandleRef pThis);

		/// <summary>
		/// Reclaim unused memory.
		/// </summary>
		// Token: 0x0601B5A8 RID: 112040 RVA: 0x00263FE3 File Offset: 0x002621E3
		public virtual void Squeeze()
		{
			vtkGraph.vtkGraph_Squeeze_62(base.GetCppThis());
		}

		// Token: 0x0601B5A9 RID: 112041
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGraph_ToDirectedGraph_63(HandleRef pThis, HandleRef g);

		/// <summary>
		/// Convert the graph to a directed graph.
		/// </summary>
		// Token: 0x0601B5AA RID: 112042 RVA: 0x00263FF4 File Offset: 0x002621F4
		public bool ToDirectedGraph(vtkDirectedGraph g)
		{
			return vtkGraph.vtkGraph_ToDirectedGraph_63(base.GetCppThis(), (g == null) ? default(HandleRef) : g.GetCppThis()) != 0;
		}

		// Token: 0x0601B5AB RID: 112043
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGraph_ToUndirectedGraph_64(HandleRef pThis, HandleRef g);

		/// <summary>
		/// Convert the graph to an undirected graph.
		/// </summary>
		// Token: 0x0601B5AC RID: 112044 RVA: 0x00264030 File Offset: 0x00262230
		public bool ToUndirectedGraph(vtkUndirectedGraph g)
		{
			return vtkGraph.vtkGraph_ToUndirectedGraph_64(base.GetCppThis(), (g == null) ? default(HandleRef) : g.GetCppThis()) != 0;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D74 RID: 7540
		public new const string MRFullTypeName = "Kitware.VTK.vtkGraph";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D75 RID: 7541
		public new static readonly string MRClassNameKey = "class vtkGraph";
	}
}
