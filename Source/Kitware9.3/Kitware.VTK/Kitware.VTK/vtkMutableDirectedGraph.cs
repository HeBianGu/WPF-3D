using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMutableDirectedGraph
	/// </summary>
	/// <remarks>
	///    An editable directed graph.
	///
	///
	/// vtkMutableDirectedGraph is a directed graph which has additional methods
	/// for adding edges and vertices. AddChild() is a convenience method for
	/// constructing trees. ShallowCopy(), DeepCopy(), CheckedShallowCopy() and
	/// CheckedDeepCopy() will succeed for instances of vtkDirectedGraph,
	/// vtkMutableDirectedGraph and vtkTree.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkDirectedGraph vtkGraph vtkTree
	/// </seealso>
	// Token: 0x02000A87 RID: 2695
	public class vtkMutableDirectedGraph : vtkDirectedGraph
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601C39A RID: 115610 RVA: 0x0027A26C File Offset: 0x0027846C
		static vtkMutableDirectedGraph()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMutableDirectedGraph.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMutableDirectedGraph"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601C39B RID: 115611 RVA: 0x0027A294 File Offset: 0x00278494
		public vtkMutableDirectedGraph(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601C39C RID: 115612
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMutableDirectedGraph_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C39D RID: 115613 RVA: 0x0027A2A4 File Offset: 0x002784A4
		public new static vtkMutableDirectedGraph New()
		{
			vtkMutableDirectedGraph result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMutableDirectedGraph.vtkMutableDirectedGraph_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMutableDirectedGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C39E RID: 115614 RVA: 0x0027A2F8 File Offset: 0x002784F8
		public vtkMutableDirectedGraph() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMutableDirectedGraph.vtkMutableDirectedGraph_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601C39F RID: 115615 RVA: 0x0027A33C File Offset: 0x0027853C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601C3A0 RID: 115616
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMutableDirectedGraph_AddChild_01(HandleRef pThis, long parent, HandleRef propertyArr);

		/// <summary>
		/// Convenience method for creating trees.
		/// Returns the newly created vertex id.
		/// Shortcut for
		/// <code>
		/// vtkIdType v = g-&gt;AddVertex();
		/// g-&gt;AddEdge(parent, v);
		/// </code>
		/// If non-null, \p propertyArr provides edge properties
		/// for the newly-created edge. The values in \p propertyArr must match
		/// up with the arrays in the edge data returned by GetEdgeData().
		/// </summary>
		// Token: 0x0601C3A1 RID: 115617 RVA: 0x0027A348 File Offset: 0x00278548
		public long AddChild(long parent, vtkVariantArray propertyArr)
		{
			return vtkMutableDirectedGraph.vtkMutableDirectedGraph_AddChild_01(base.GetCppThis(), parent, (propertyArr == null) ? default(HandleRef) : propertyArr.GetCppThis());
		}

		// Token: 0x0601C3A2 RID: 115618
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMutableDirectedGraph_AddChild_02(HandleRef pThis, long parent);

		/// <summary>
		/// Convenience method for creating trees.
		/// Returns the newly created vertex id.
		/// Shortcut for
		/// <code>
		/// vtkIdType v = g-&gt;AddVertex();
		/// g-&gt;AddEdge(parent, v);
		/// </code>
		/// If non-null, \p propertyArr provides edge properties
		/// for the newly-created edge. The values in \p propertyArr must match
		/// up with the arrays in the edge data returned by GetEdgeData().
		/// </summary>
		// Token: 0x0601C3A3 RID: 115619 RVA: 0x0027A380 File Offset: 0x00278580
		public long AddChild(long parent)
		{
			return vtkMutableDirectedGraph.vtkMutableDirectedGraph_AddChild_02(base.GetCppThis(), parent);
		}

		// Token: 0x0601C3A4 RID: 115620
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMutableDirectedGraph_AddGraphEdge_03(HandleRef pThis, long u, long v, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Variant of AddEdge() that returns a heavyweight \p vtkGraphEdge object.
		/// The graph owns the reference of the edge and will replace
		/// its contents on the next call to AddGraphEdge().
		///
		/// \note This is a less efficient method for use with wrappers.
		/// In C++ you should use the faster AddEdge().
		/// </summary>
		// Token: 0x0601C3A5 RID: 115621 RVA: 0x0027A3A0 File Offset: 0x002785A0
		public vtkGraphEdge AddGraphEdge(long u, long v)
		{
			vtkGraphEdge vtkGraphEdge = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMutableDirectedGraph.vtkMutableDirectedGraph_AddGraphEdge_03(base.GetCppThis(), u, v, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraphEdge = (vtkGraphEdge)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraphEdge.Register(null);
				}
			}
			return vtkGraphEdge;
		}

		// Token: 0x0601C3A6 RID: 115622
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMutableDirectedGraph_AddVertex_04(HandleRef pThis);

		/// <summary>
		/// Adds a vertex to the graph and returns the index of the new vertex.
		///
		/// \note In a distributed graph (i.e. a graph whose DistributedHelper
		/// is non-null), this routine cannot be used to add a vertex
		/// if the vertices in the graph have pedigree IDs, because this routine
		/// will always add the vertex locally, which may conflict with the
		/// proper location of the vertex based on the distribution of the
		/// pedigree IDs.
		/// </summary>
		// Token: 0x0601C3A7 RID: 115623 RVA: 0x0027A414 File Offset: 0x00278614
		public long AddVertex()
		{
			return vtkMutableDirectedGraph.vtkMutableDirectedGraph_AddVertex_04(base.GetCppThis());
		}

		// Token: 0x0601C3A8 RID: 115624
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMutableDirectedGraph_AddVertex_05(HandleRef pThis, HandleRef propertyArr);

		/// <summary>
		/// Adds a vertex to the graph with associated properties defined in
		/// \p propertyArr and returns the index of the new vertex.
		/// The number and order of values in \p propertyArr must match up with the
		/// arrays in the vertex data retrieved by GetVertexData().
		///
		/// If a vertex with the given pedigree ID already exists, its properties will be
		/// overwritten with the properties in \p propertyArr and the existing
		/// vertex index will be returned.
		///
		/// \note In a distributed graph (i.e. a graph whose DistributedHelper
		/// is non-null) the vertex added or found might not be local. In this case,
		/// AddVertex will wait until the vertex can be added or found
		/// remotely, so that the proper vertex index can be returned. If you
		/// don't actually need to use the vertex index, consider calling
		/// LazyAddVertex, which provides better performance by eliminating
		/// the delays associated with returning the vertex index.
		/// </summary>
		// Token: 0x0601C3A9 RID: 115625 RVA: 0x0027A434 File Offset: 0x00278634
		public long AddVertex(vtkVariantArray propertyArr)
		{
			return vtkMutableDirectedGraph.vtkMutableDirectedGraph_AddVertex_05(base.GetCppThis(), (propertyArr == null) ? default(HandleRef) : propertyArr.GetCppThis());
		}

		// Token: 0x0601C3AA RID: 115626
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMutableDirectedGraph_AddVertex_06(HandleRef pThis, HandleRef pedigreeId);

		/// <summary>
		/// Adds a vertex with the given \p pedigreeID to the graph and
		/// returns the index of the new vertex.
		///
		/// If a vertex with the given pedigree ID already exists,
		/// the existing vertex index will be returned.
		///
		/// \note In a distributed graph (i.e. a graph whose DistributedHelper
		/// is non-null) the vertex added or found might not be local. In this case,
		/// AddVertex will wait until the vertex can be added or found
		/// remotely, so that the proper vertex index can be returned. If you
		/// don't actually need to use the vertex index, consider calling
		/// LazyAddVertex, which provides better performance by eliminating
		/// the delays associated with returning the vertex index.
		/// </summary>
		// Token: 0x0601C3AB RID: 115627 RVA: 0x0027A468 File Offset: 0x00278668
		public long AddVertex(vtkVariant pedigreeId)
		{
			return vtkMutableDirectedGraph.vtkMutableDirectedGraph_AddVertex_06(base.GetCppThis(), (pedigreeId == null) ? default(HandleRef) : pedigreeId.GetCppThis());
		}

		// Token: 0x0601C3AC RID: 115628
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMutableDirectedGraph_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C3AD RID: 115629 RVA: 0x0027A49C File Offset: 0x0027869C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMutableDirectedGraph.vtkMutableDirectedGraph_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0601C3AE RID: 115630
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMutableDirectedGraph_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C3AF RID: 115631 RVA: 0x0027A4BC File Offset: 0x002786BC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMutableDirectedGraph.vtkMutableDirectedGraph_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x0601C3B0 RID: 115632
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMutableDirectedGraph_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C3B1 RID: 115633 RVA: 0x0027A4D8 File Offset: 0x002786D8
		public override int IsA(string type)
		{
			return vtkMutableDirectedGraph.vtkMutableDirectedGraph_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x0601C3B2 RID: 115634
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMutableDirectedGraph_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C3B3 RID: 115635 RVA: 0x0027A4F8 File Offset: 0x002786F8
		public new static int IsTypeOf(string type)
		{
			return vtkMutableDirectedGraph.vtkMutableDirectedGraph_IsTypeOf_10(type);
		}

		// Token: 0x0601C3B4 RID: 115636
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMutableDirectedGraph_LazyAddEdge_11(HandleRef pThis, long u, long v, HandleRef propertyArr);

		/// <summary>
		/// Adds a directed edge from \p u to \p v,
		/// where \p u and \p v are vertex indices.
		///
		/// The number and order of values in the optional parameter
		/// \p propertyArr must match up with the arrays in the edge data
		/// retrieved by GetEdgeData().
		///
		/// This method is lazily evaluated for distributed graphs (i.e. graphs
		/// whose DistributedHelper is non-null) the next time Synchronize is
		/// called on the helper.
		/// </summary>
		// Token: 0x0601C3B5 RID: 115637 RVA: 0x0027A514 File Offset: 0x00278714
		public void LazyAddEdge(long u, long v, vtkVariantArray propertyArr)
		{
			vtkMutableDirectedGraph.vtkMutableDirectedGraph_LazyAddEdge_11(base.GetCppThis(), u, v, (propertyArr == null) ? default(HandleRef) : propertyArr.GetCppThis());
		}

		// Token: 0x0601C3B6 RID: 115638
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMutableDirectedGraph_LazyAddEdge_12(HandleRef pThis, HandleRef u, long v, HandleRef propertyArr);

		/// <summary>
		/// Adds a directed edge from \p u to \p v,
		/// where \p u is a vertex pedigree ID and \p v is a vertex index.
		///
		/// The number and order of values in the optional parameter
		/// \p propertyArr must match up with the arrays in the edge data
		/// retrieved by GetEdgeData().
		///
		/// This method is lazily evaluated for distributed graphs (i.e. graphs
		/// whose DistributedHelper is non-null) the next time Synchronize is
		/// called on the helper.
		/// </summary>
		// Token: 0x0601C3B7 RID: 115639 RVA: 0x0027A548 File Offset: 0x00278748
		public void LazyAddEdge(vtkVariant u, long v, vtkVariantArray propertyArr)
		{
			vtkMutableDirectedGraph.vtkMutableDirectedGraph_LazyAddEdge_12(base.GetCppThis(), (u == null) ? default(HandleRef) : u.GetCppThis(), v, (propertyArr == null) ? default(HandleRef) : propertyArr.GetCppThis());
		}

		// Token: 0x0601C3B8 RID: 115640
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMutableDirectedGraph_LazyAddEdge_13(HandleRef pThis, long u, HandleRef v, HandleRef propertyArr);

		/// <summary>
		/// Adds a directed edge from \p u to \p v,
		/// where \p u is a vertex index and \p v is a vertex pedigree ID.
		///
		/// The number and order of values in the optional parameter
		/// \p propertyArr must match up with the arrays in the edge data
		/// retrieved by GetEdgeData().
		///
		/// This method is lazily evaluated for distributed graphs (i.e. graphs
		/// whose DistributedHelper is non-null) the next time Synchronize is
		/// called on the helper.
		/// </summary>
		// Token: 0x0601C3B9 RID: 115641 RVA: 0x0027A590 File Offset: 0x00278790
		public void LazyAddEdge(long u, vtkVariant v, vtkVariantArray propertyArr)
		{
			vtkMutableDirectedGraph.vtkMutableDirectedGraph_LazyAddEdge_13(base.GetCppThis(), u, (v == null) ? default(HandleRef) : v.GetCppThis(), (propertyArr == null) ? default(HandleRef) : propertyArr.GetCppThis());
		}

		// Token: 0x0601C3BA RID: 115642
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMutableDirectedGraph_LazyAddEdge_14(HandleRef pThis, HandleRef u, HandleRef v, HandleRef propertyArr);

		/// <summary>
		/// Adds a directed edge from \p u to \p v,
		/// where \p u and \p v are vertex pedigree IDs.
		///
		/// The number and order of values in the optional parameter
		/// \p propertyArr must match up with the arrays in the edge data
		/// retrieved by GetEdgeData().
		///
		/// This method is lazily evaluated for distributed graphs (i.e. graphs
		/// whose DistributedHelper is non-null) the next time Synchronize is
		/// called on the helper.
		/// </summary>
		// Token: 0x0601C3BB RID: 115643 RVA: 0x0027A5D8 File Offset: 0x002787D8
		public void LazyAddEdge(vtkVariant u, vtkVariant v, vtkVariantArray propertyArr)
		{
			vtkMutableDirectedGraph.vtkMutableDirectedGraph_LazyAddEdge_14(base.GetCppThis(), (u == null) ? default(HandleRef) : u.GetCppThis(), (v == null) ? default(HandleRef) : v.GetCppThis(), (propertyArr == null) ? default(HandleRef) : propertyArr.GetCppThis());
		}

		// Token: 0x0601C3BC RID: 115644
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMutableDirectedGraph_LazyAddVertex_15(HandleRef pThis);

		/// <summary>
		/// Adds a vertex to the graph.
		///
		/// This method is lazily evaluated for distributed graphs (i.e. graphs
		/// whose DistributedHelper is non-null) the next time Synchronize is
		/// called on the helper.
		/// </summary>
		// Token: 0x0601C3BD RID: 115645 RVA: 0x0027A631 File Offset: 0x00278831
		public void LazyAddVertex()
		{
			vtkMutableDirectedGraph.vtkMutableDirectedGraph_LazyAddVertex_15(base.GetCppThis());
		}

		// Token: 0x0601C3BE RID: 115646
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMutableDirectedGraph_LazyAddVertex_16(HandleRef pThis, HandleRef propertyArr);

		/// <summary>
		/// Adds a vertex to the graph with associated properties defined in
		/// \p propertyArr.
		/// The number and order of values in \p propertyArr must match up with the
		/// arrays in the vertex data retrieved by GetVertexData().
		///
		/// If a vertex with the given pedigree ID already exists, its properties will be
		/// overwritten with the properties in \p propertyArr.
		///
		/// This method is lazily evaluated for distributed graphs (i.e. graphs
		/// whose DistributedHelper is non-null) the next time Synchronize is
		/// called on the helper.
		/// </summary>
		// Token: 0x0601C3BF RID: 115647 RVA: 0x0027A640 File Offset: 0x00278840
		public void LazyAddVertex(vtkVariantArray propertyArr)
		{
			vtkMutableDirectedGraph.vtkMutableDirectedGraph_LazyAddVertex_16(base.GetCppThis(), (propertyArr == null) ? default(HandleRef) : propertyArr.GetCppThis());
		}

		// Token: 0x0601C3C0 RID: 115648
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMutableDirectedGraph_LazyAddVertex_17(HandleRef pThis, HandleRef pedigreeId);

		/// <summary>
		/// Adds a vertex with the given \p pedigreeID to the graph.
		///
		/// If a vertex with the given pedigree ID already exists,
		/// no operation is performed.
		///
		/// This method is lazily evaluated for distributed graphs (i.e. graphs
		/// whose DistributedHelper is non-null) the next time Synchronize is
		/// called on the helper.
		/// </summary>
		// Token: 0x0601C3C1 RID: 115649 RVA: 0x0027A670 File Offset: 0x00278870
		public void LazyAddVertex(vtkVariant pedigreeId)
		{
			vtkMutableDirectedGraph.vtkMutableDirectedGraph_LazyAddVertex_17(base.GetCppThis(), (pedigreeId == null) ? default(HandleRef) : pedigreeId.GetCppThis());
		}

		// Token: 0x0601C3C2 RID: 115650
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMutableDirectedGraph_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C3C3 RID: 115651 RVA: 0x0027A6A0 File Offset: 0x002788A0
		public new vtkMutableDirectedGraph NewInstance()
		{
			vtkMutableDirectedGraph result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMutableDirectedGraph.vtkMutableDirectedGraph_NewInstance_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMutableDirectedGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601C3C4 RID: 115652
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMutableDirectedGraph_RemoveEdge_20(HandleRef pThis, long e);

		/// <summary>
		/// Removes the edge from the graph.
		/// Note: This invalidates the last edge index, which is reassigned to e.
		/// </summary>
		// Token: 0x0601C3C5 RID: 115653 RVA: 0x0027A6FA File Offset: 0x002788FA
		public void RemoveEdge(long e)
		{
			vtkMutableDirectedGraph.vtkMutableDirectedGraph_RemoveEdge_20(base.GetCppThis(), e);
		}

		// Token: 0x0601C3C6 RID: 115654
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMutableDirectedGraph_RemoveEdges_21(HandleRef pThis, HandleRef arr);

		/// <summary>
		/// Removes a collection of edges from the graph.
		/// </summary>
		// Token: 0x0601C3C7 RID: 115655 RVA: 0x0027A70C File Offset: 0x0027890C
		public void RemoveEdges(vtkIdTypeArray arr)
		{
			vtkMutableDirectedGraph.vtkMutableDirectedGraph_RemoveEdges_21(base.GetCppThis(), (arr == null) ? default(HandleRef) : arr.GetCppThis());
		}

		// Token: 0x0601C3C8 RID: 115656
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMutableDirectedGraph_RemoveVertex_22(HandleRef pThis, long v);

		/// <summary>
		/// Removes the vertex from the graph along with any connected edges.
		/// Note: This invalidates the last vertex index, which is reassigned to v.
		/// </summary>
		// Token: 0x0601C3C9 RID: 115657 RVA: 0x0027A73B File Offset: 0x0027893B
		public void RemoveVertex(long v)
		{
			vtkMutableDirectedGraph.vtkMutableDirectedGraph_RemoveVertex_22(base.GetCppThis(), v);
		}

		// Token: 0x0601C3CA RID: 115658
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMutableDirectedGraph_RemoveVertices_23(HandleRef pThis, HandleRef arr);

		/// <summary>
		/// Removes a collection of vertices from the graph along with any connected edges.
		/// </summary>
		// Token: 0x0601C3CB RID: 115659 RVA: 0x0027A74C File Offset: 0x0027894C
		public void RemoveVertices(vtkIdTypeArray arr)
		{
			vtkMutableDirectedGraph.vtkMutableDirectedGraph_RemoveVertices_23(base.GetCppThis(), (arr == null) ? default(HandleRef) : arr.GetCppThis());
		}

		// Token: 0x0601C3CC RID: 115660
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMutableDirectedGraph_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C3CD RID: 115661 RVA: 0x0027A77C File Offset: 0x0027897C
		public new static vtkMutableDirectedGraph SafeDownCast(vtkObjectBase o)
		{
			vtkMutableDirectedGraph vtkMutableDirectedGraph = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMutableDirectedGraph.vtkMutableDirectedGraph_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601C3CE RID: 115662
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMutableDirectedGraph_SetNumberOfVertices_25(HandleRef pThis, long numVerts);

		/// <summary>
		/// Allocates space for the specified number of vertices in the graph's
		/// internal data structures.
		///
		/// This has no effect on the number of vertex coordinate tuples or
		/// vertex attribute tuples allocated; you are responsible for
		/// guaranteeing these match.
		/// Also, this call is not implemented for distributed-memory graphs since
		/// the semantics are unclear; calling this function on a graph with a
		/// non-nullptr DistributedGraphHelper will generate an error message and
		/// no allocation will be performed.
		/// </summary>
		// Token: 0x0601C3CF RID: 115663 RVA: 0x0027A7FC File Offset: 0x002789FC
		public virtual long SetNumberOfVertices(long numVerts)
		{
			return vtkMutableDirectedGraph.vtkMutableDirectedGraph_SetNumberOfVertices_25(base.GetCppThis(), numVerts);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E0A RID: 7690
		public new const string MRFullTypeName = "Kitware.VTK.vtkMutableDirectedGraph";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E0B RID: 7691
		public new static readonly string MRClassNameKey = "class vtkMutableDirectedGraph";
	}
}
