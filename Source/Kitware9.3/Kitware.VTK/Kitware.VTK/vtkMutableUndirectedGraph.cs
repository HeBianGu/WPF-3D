using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMutableUndirectedGraph
	/// </summary>
	/// <remarks>
	///    An editable undirected graph.
	///
	///
	/// vtkMutableUndirectedGraph is an undirected graph with additional functions
	/// for adding vertices and edges. ShallowCopy(), DeepCopy(), CheckedShallowCopy(),
	/// and CheckedDeepCopy() will succeed when the argument is a vtkUndirectedGraph
	/// or vtkMutableUndirectedGraph.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkUndirectedGraph vtkGraph
	/// </seealso>
	// Token: 0x02000A88 RID: 2696
	public class vtkMutableUndirectedGraph : vtkUndirectedGraph
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601C3D0 RID: 115664 RVA: 0x0027A81C File Offset: 0x00278A1C
		static vtkMutableUndirectedGraph()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMutableUndirectedGraph.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMutableUndirectedGraph"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601C3D1 RID: 115665 RVA: 0x0027A844 File Offset: 0x00278A44
		public vtkMutableUndirectedGraph(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601C3D2 RID: 115666
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMutableUndirectedGraph_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C3D3 RID: 115667 RVA: 0x0027A854 File Offset: 0x00278A54
		public new static vtkMutableUndirectedGraph New()
		{
			vtkMutableUndirectedGraph result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMutableUndirectedGraph.vtkMutableUndirectedGraph_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMutableUndirectedGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C3D4 RID: 115668 RVA: 0x0027A8A8 File Offset: 0x00278AA8
		public vtkMutableUndirectedGraph() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMutableUndirectedGraph.vtkMutableUndirectedGraph_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601C3D5 RID: 115669 RVA: 0x0027A8EC File Offset: 0x00278AEC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601C3D6 RID: 115670
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMutableUndirectedGraph_AddGraphEdge_01(HandleRef pThis, long u, long v, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Variant of AddEdge() that returns a heavyweight \p vtkGraphEdge object.
		/// The graph owns the reference of the edge and will replace
		/// its contents on the next call to AddGraphEdge().
		///
		/// \note This is a less efficient method for use with wrappers.
		/// In C++ you should use the faster AddEdge().
		/// </summary>
		// Token: 0x0601C3D7 RID: 115671 RVA: 0x0027A8F8 File Offset: 0x00278AF8
		public vtkGraphEdge AddGraphEdge(long u, long v)
		{
			vtkGraphEdge vtkGraphEdge = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMutableUndirectedGraph.vtkMutableUndirectedGraph_AddGraphEdge_01(base.GetCppThis(), u, v, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601C3D8 RID: 115672
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMutableUndirectedGraph_AddVertex_02(HandleRef pThis);

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
		// Token: 0x0601C3D9 RID: 115673 RVA: 0x0027A96C File Offset: 0x00278B6C
		public long AddVertex()
		{
			return vtkMutableUndirectedGraph.vtkMutableUndirectedGraph_AddVertex_02(base.GetCppThis());
		}

		// Token: 0x0601C3DA RID: 115674
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMutableUndirectedGraph_AddVertex_03(HandleRef pThis, HandleRef propertyArr);

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
		// Token: 0x0601C3DB RID: 115675 RVA: 0x0027A98C File Offset: 0x00278B8C
		public long AddVertex(vtkVariantArray propertyArr)
		{
			return vtkMutableUndirectedGraph.vtkMutableUndirectedGraph_AddVertex_03(base.GetCppThis(), (propertyArr == null) ? default(HandleRef) : propertyArr.GetCppThis());
		}

		// Token: 0x0601C3DC RID: 115676
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMutableUndirectedGraph_AddVertex_04(HandleRef pThis, HandleRef pedigreeId);

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
		// Token: 0x0601C3DD RID: 115677 RVA: 0x0027A9C0 File Offset: 0x00278BC0
		public long AddVertex(vtkVariant pedigreeId)
		{
			return vtkMutableUndirectedGraph.vtkMutableUndirectedGraph_AddVertex_04(base.GetCppThis(), (pedigreeId == null) ? default(HandleRef) : pedigreeId.GetCppThis());
		}

		// Token: 0x0601C3DE RID: 115678
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMutableUndirectedGraph_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C3DF RID: 115679 RVA: 0x0027A9F4 File Offset: 0x00278BF4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMutableUndirectedGraph.vtkMutableUndirectedGraph_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0601C3E0 RID: 115680
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMutableUndirectedGraph_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C3E1 RID: 115681 RVA: 0x0027AA14 File Offset: 0x00278C14
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMutableUndirectedGraph.vtkMutableUndirectedGraph_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0601C3E2 RID: 115682
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMutableUndirectedGraph_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C3E3 RID: 115683 RVA: 0x0027AA30 File Offset: 0x00278C30
		public override int IsA(string type)
		{
			return vtkMutableUndirectedGraph.vtkMutableUndirectedGraph_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601C3E4 RID: 115684
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMutableUndirectedGraph_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C3E5 RID: 115685 RVA: 0x0027AA50 File Offset: 0x00278C50
		public new static int IsTypeOf(string type)
		{
			return vtkMutableUndirectedGraph.vtkMutableUndirectedGraph_IsTypeOf_08(type);
		}

		// Token: 0x0601C3E6 RID: 115686
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMutableUndirectedGraph_LazyAddEdge_09(HandleRef pThis, long u, long v);

		/// <summary>
		/// Adds an undirected edge from \p u to \p v,
		/// where \p u and \p v are vertex indices.
		///
		/// This method is lazily evaluated for distributed graphs (i.e. graphs
		/// whose DistributedHelper is non-null) the next time Synchronize is
		/// called on the helper.
		/// </summary>
		// Token: 0x0601C3E7 RID: 115687 RVA: 0x0027AA6A File Offset: 0x00278C6A
		public void LazyAddEdge(long u, long v)
		{
			vtkMutableUndirectedGraph.vtkMutableUndirectedGraph_LazyAddEdge_09(base.GetCppThis(), u, v);
		}

		// Token: 0x0601C3E8 RID: 115688
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMutableUndirectedGraph_LazyAddEdge_10(HandleRef pThis, long u, long v, HandleRef propertyArr);

		/// <summary>
		/// Adds an undirected edge from \p u to \p v,
		/// where \p u and \p v are vertex indices.
		///
		/// The number and order of values in
		/// \p propertyArr must match up with the arrays in the edge data
		/// retrieved by GetEdgeData().
		///
		/// This method is lazily evaluated for distributed graphs (i.e. graphs
		/// whose DistributedHelper is non-null) the next time Synchronize is
		/// called on the helper.
		/// </summary>
		// Token: 0x0601C3E9 RID: 115689 RVA: 0x0027AA7C File Offset: 0x00278C7C
		public void LazyAddEdge(long u, long v, vtkVariantArray propertyArr)
		{
			vtkMutableUndirectedGraph.vtkMutableUndirectedGraph_LazyAddEdge_10(base.GetCppThis(), u, v, (propertyArr == null) ? default(HandleRef) : propertyArr.GetCppThis());
		}

		// Token: 0x0601C3EA RID: 115690
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMutableUndirectedGraph_LazyAddEdge_11(HandleRef pThis, HandleRef u, long v, HandleRef propertyArr);

		/// <summary>
		/// Adds an undirected edge from \p u to \p v,
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
		// Token: 0x0601C3EB RID: 115691 RVA: 0x0027AAB0 File Offset: 0x00278CB0
		public void LazyAddEdge(vtkVariant u, long v, vtkVariantArray propertyArr)
		{
			vtkMutableUndirectedGraph.vtkMutableUndirectedGraph_LazyAddEdge_11(base.GetCppThis(), (u == null) ? default(HandleRef) : u.GetCppThis(), v, (propertyArr == null) ? default(HandleRef) : propertyArr.GetCppThis());
		}

		// Token: 0x0601C3EC RID: 115692
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMutableUndirectedGraph_LazyAddEdge_12(HandleRef pThis, long u, HandleRef v, HandleRef propertyArr);

		/// <summary>
		/// Adds an undirected edge from \p u to \p v,
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
		// Token: 0x0601C3ED RID: 115693 RVA: 0x0027AAF8 File Offset: 0x00278CF8
		public void LazyAddEdge(long u, vtkVariant v, vtkVariantArray propertyArr)
		{
			vtkMutableUndirectedGraph.vtkMutableUndirectedGraph_LazyAddEdge_12(base.GetCppThis(), u, (v == null) ? default(HandleRef) : v.GetCppThis(), (propertyArr == null) ? default(HandleRef) : propertyArr.GetCppThis());
		}

		// Token: 0x0601C3EE RID: 115694
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMutableUndirectedGraph_LazyAddEdge_13(HandleRef pThis, HandleRef u, HandleRef v, HandleRef propertyArr);

		/// <summary>
		/// Adds an undirected edge from \p u to \p v,
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
		// Token: 0x0601C3EF RID: 115695 RVA: 0x0027AB40 File Offset: 0x00278D40
		public void LazyAddEdge(vtkVariant u, vtkVariant v, vtkVariantArray propertyArr)
		{
			vtkMutableUndirectedGraph.vtkMutableUndirectedGraph_LazyAddEdge_13(base.GetCppThis(), (u == null) ? default(HandleRef) : u.GetCppThis(), (v == null) ? default(HandleRef) : v.GetCppThis(), (propertyArr == null) ? default(HandleRef) : propertyArr.GetCppThis());
		}

		// Token: 0x0601C3F0 RID: 115696
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMutableUndirectedGraph_LazyAddVertex_14(HandleRef pThis);

		/// <summary>
		/// Adds a vertex to the graph.
		///
		/// This method is lazily evaluated for distributed graphs (i.e. graphs
		/// whose DistributedHelper is non-null) the next time Synchronize is
		/// called on the helper.
		/// </summary>
		// Token: 0x0601C3F1 RID: 115697 RVA: 0x0027AB99 File Offset: 0x00278D99
		public void LazyAddVertex()
		{
			vtkMutableUndirectedGraph.vtkMutableUndirectedGraph_LazyAddVertex_14(base.GetCppThis());
		}

		// Token: 0x0601C3F2 RID: 115698
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMutableUndirectedGraph_LazyAddVertex_15(HandleRef pThis, HandleRef propertyArr);

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
		// Token: 0x0601C3F3 RID: 115699 RVA: 0x0027ABA8 File Offset: 0x00278DA8
		public void LazyAddVertex(vtkVariantArray propertyArr)
		{
			vtkMutableUndirectedGraph.vtkMutableUndirectedGraph_LazyAddVertex_15(base.GetCppThis(), (propertyArr == null) ? default(HandleRef) : propertyArr.GetCppThis());
		}

		// Token: 0x0601C3F4 RID: 115700
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMutableUndirectedGraph_LazyAddVertex_16(HandleRef pThis, HandleRef pedigreeId);

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
		// Token: 0x0601C3F5 RID: 115701 RVA: 0x0027ABD8 File Offset: 0x00278DD8
		public void LazyAddVertex(vtkVariant pedigreeId)
		{
			vtkMutableUndirectedGraph.vtkMutableUndirectedGraph_LazyAddVertex_16(base.GetCppThis(), (pedigreeId == null) ? default(HandleRef) : pedigreeId.GetCppThis());
		}

		// Token: 0x0601C3F6 RID: 115702
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMutableUndirectedGraph_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C3F7 RID: 115703 RVA: 0x0027AC08 File Offset: 0x00278E08
		public new vtkMutableUndirectedGraph NewInstance()
		{
			vtkMutableUndirectedGraph result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMutableUndirectedGraph.vtkMutableUndirectedGraph_NewInstance_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMutableUndirectedGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601C3F8 RID: 115704
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMutableUndirectedGraph_RemoveEdge_19(HandleRef pThis, long e);

		/// <summary>
		/// Removes the edge from the graph.
		/// Note: This invalidates the last edge index, which is reassigned to e.
		/// </summary>
		// Token: 0x0601C3F9 RID: 115705 RVA: 0x0027AC62 File Offset: 0x00278E62
		public void RemoveEdge(long e)
		{
			vtkMutableUndirectedGraph.vtkMutableUndirectedGraph_RemoveEdge_19(base.GetCppThis(), e);
		}

		// Token: 0x0601C3FA RID: 115706
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMutableUndirectedGraph_RemoveEdges_20(HandleRef pThis, HandleRef arr);

		/// <summary>
		/// Removes a collection of edges from the graph.
		/// </summary>
		// Token: 0x0601C3FB RID: 115707 RVA: 0x0027AC74 File Offset: 0x00278E74
		public void RemoveEdges(vtkIdTypeArray arr)
		{
			vtkMutableUndirectedGraph.vtkMutableUndirectedGraph_RemoveEdges_20(base.GetCppThis(), (arr == null) ? default(HandleRef) : arr.GetCppThis());
		}

		// Token: 0x0601C3FC RID: 115708
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMutableUndirectedGraph_RemoveVertex_21(HandleRef pThis, long v);

		/// <summary>
		/// Removes the vertex from the graph along with any connected edges.
		/// Note: This invalidates the last vertex index, which is reassigned to v.
		/// </summary>
		// Token: 0x0601C3FD RID: 115709 RVA: 0x0027ACA3 File Offset: 0x00278EA3
		public void RemoveVertex(long v)
		{
			vtkMutableUndirectedGraph.vtkMutableUndirectedGraph_RemoveVertex_21(base.GetCppThis(), v);
		}

		// Token: 0x0601C3FE RID: 115710
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMutableUndirectedGraph_RemoveVertices_22(HandleRef pThis, HandleRef arr);

		/// <summary>
		/// Removes a collection of vertices from the graph along with any connected edges.
		/// </summary>
		// Token: 0x0601C3FF RID: 115711 RVA: 0x0027ACB4 File Offset: 0x00278EB4
		public void RemoveVertices(vtkIdTypeArray arr)
		{
			vtkMutableUndirectedGraph.vtkMutableUndirectedGraph_RemoveVertices_22(base.GetCppThis(), (arr == null) ? default(HandleRef) : arr.GetCppThis());
		}

		// Token: 0x0601C400 RID: 115712
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMutableUndirectedGraph_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C401 RID: 115713 RVA: 0x0027ACE4 File Offset: 0x00278EE4
		public new static vtkMutableUndirectedGraph SafeDownCast(vtkObjectBase o)
		{
			vtkMutableUndirectedGraph vtkMutableUndirectedGraph = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMutableUndirectedGraph.vtkMutableUndirectedGraph_SafeDownCast_23((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMutableUndirectedGraph = (vtkMutableUndirectedGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMutableUndirectedGraph.Register(null);
				}
			}
			return vtkMutableUndirectedGraph;
		}

		// Token: 0x0601C402 RID: 115714
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMutableUndirectedGraph_SetNumberOfVertices_24(HandleRef pThis, long numVerts);

		/// <summary>
		/// Allocates space for the specified number of vertices in the graph's
		/// internal data structures.
		/// The previous number of vertices is returned on success and -1
		/// is returned on failure.
		///
		/// This has no effect on the number of vertex coordinate tuples or
		/// vertex attribute tuples allocated; you are responsible for
		/// guaranteeing these match.
		/// Also, this call is not implemented for distributed-memory graphs since
		/// the semantics are unclear; calling this function on a graph with a
		/// non-nullptr DistributedGraphHelper will generate an error message,
		/// no allocation will be performed, and a value of -1 will be returned.
		/// </summary>
		// Token: 0x0601C403 RID: 115715 RVA: 0x0027AD64 File Offset: 0x00278F64
		public virtual long SetNumberOfVertices(long numVerts)
		{
			return vtkMutableUndirectedGraph.vtkMutableUndirectedGraph_SetNumberOfVertices_24(base.GetCppThis(), numVerts);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E0C RID: 7692
		public new const string MRFullTypeName = "Kitware.VTK.vtkMutableUndirectedGraph";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E0D RID: 7693
		public new static readonly string MRClassNameKey = "class vtkMutableUndirectedGraph";
	}
}
