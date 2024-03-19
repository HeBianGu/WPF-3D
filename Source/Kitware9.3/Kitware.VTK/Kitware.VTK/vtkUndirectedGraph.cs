using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkUndirectedGraph
	/// </summary>
	/// <remarks>
	///    An undirected graph.
	///
	///
	/// vtkUndirectedGraph is a collection of vertices along with a collection of
	/// undirected edges (they connect two vertices in no particular order).
	/// ShallowCopy(), DeepCopy(), CheckedShallowCopy(), CheckedDeepCopy()
	/// accept instances of vtkUndirectedGraph and vtkMutableUndirectedGraph.
	/// GetOutEdges(v, it) and GetInEdges(v, it) return the same list of edges,
	/// which is the list of all edges which have a v as an endpoint.
	/// GetInDegree(v), GetOutDegree(v) and GetDegree(v) all return the full
	/// degree of vertex v.
	///
	/// vtkUndirectedGraph is read-only. To create an undirected graph,
	/// use an instance of vtkMutableUndirectedGraph, then you may set the
	/// structure to a vtkUndirectedGraph using ShallowCopy().
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkGraph vtkMutableUndirectedGraph
	/// </seealso>
	// Token: 0x02000A82 RID: 2690
	public class vtkUndirectedGraph : vtkGraph
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601C286 RID: 115334 RVA: 0x00277FCF File Offset: 0x002761CF
		static vtkUndirectedGraph()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUndirectedGraph.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUndirectedGraph"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601C287 RID: 115335 RVA: 0x00277FF7 File Offset: 0x002761F7
		public vtkUndirectedGraph(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601C288 RID: 115336
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUndirectedGraph_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C289 RID: 115337 RVA: 0x00278008 File Offset: 0x00276208
		public new static vtkUndirectedGraph New()
		{
			vtkUndirectedGraph result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUndirectedGraph.vtkUndirectedGraph_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUndirectedGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C28A RID: 115338 RVA: 0x0027805C File Offset: 0x0027625C
		public vtkUndirectedGraph() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkUndirectedGraph.vtkUndirectedGraph_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601C28B RID: 115339 RVA: 0x002780A0 File Offset: 0x002762A0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601C28C RID: 115340
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUndirectedGraph_GetData_01(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve a graph from an information vector.
		/// </summary>
		// Token: 0x0601C28D RID: 115341 RVA: 0x002780AC File Offset: 0x002762AC
		public new static vtkUndirectedGraph GetData(vtkInformation info)
		{
			vtkUndirectedGraph vtkUndirectedGraph = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUndirectedGraph.vtkUndirectedGraph_GetData_01((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUndirectedGraph = (vtkUndirectedGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUndirectedGraph.Register(null);
				}
			}
			return vtkUndirectedGraph;
		}

		// Token: 0x0601C28E RID: 115342
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUndirectedGraph_GetData_02(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve a graph from an information vector.
		/// </summary>
		// Token: 0x0601C28F RID: 115343 RVA: 0x0027812C File Offset: 0x0027632C
		public new static vtkUndirectedGraph GetData(vtkInformationVector v, int i)
		{
			vtkUndirectedGraph vtkUndirectedGraph = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUndirectedGraph.vtkUndirectedGraph_GetData_02((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUndirectedGraph = (vtkUndirectedGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUndirectedGraph.Register(null);
				}
			}
			return vtkUndirectedGraph;
		}

		// Token: 0x0601C290 RID: 115344
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUndirectedGraph_GetDataObjectType_03(HandleRef pThis);

		/// <summary>
		/// Return what type of dataset this is.
		/// </summary>
		// Token: 0x0601C291 RID: 115345 RVA: 0x002781AC File Offset: 0x002763AC
		public override int GetDataObjectType()
		{
			return vtkUndirectedGraph.vtkUndirectedGraph_GetDataObjectType_03(base.GetCppThis());
		}

		// Token: 0x0601C292 RID: 115346
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUndirectedGraph_GetInDegree_04(HandleRef pThis, long v);

		/// <summary>
		/// Returns the full degree of the vertex.
		/// </summary>
		// Token: 0x0601C293 RID: 115347 RVA: 0x002781CC File Offset: 0x002763CC
		public override long GetInDegree(long v)
		{
			return vtkUndirectedGraph.vtkUndirectedGraph_GetInDegree_04(base.GetCppThis(), v);
		}

		// Token: 0x0601C294 RID: 115348
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUndirectedGraph_GetInEdge_05(HandleRef pThis, long v, long i, HandleRef e);

		/// <summary>
		/// Random-access method for retrieving incoming edges to vertex v.
		/// The method fills the vtkGraphEdge instance with the id, source, and
		/// target of the edge. This method is provided for wrappers,
		/// GetInEdge(vtkIdType, vtkIdType) is preferred.
		/// </summary>
		// Token: 0x0601C295 RID: 115349 RVA: 0x002781EC File Offset: 0x002763EC
		public override void GetInEdge(long v, long i, vtkGraphEdge e)
		{
			vtkUndirectedGraph.vtkUndirectedGraph_GetInEdge_05(base.GetCppThis(), v, i, (e == null) ? default(HandleRef) : e.GetCppThis());
		}

		// Token: 0x0601C296 RID: 115350
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUndirectedGraph_GetInEdges_06(HandleRef pThis, long v, HandleRef it);

		/// <summary>
		/// Initialize the iterator to get the incoming edges to a vertex.
		/// For an undirected graph, this is all incident edges.
		/// </summary>
		// Token: 0x0601C297 RID: 115351 RVA: 0x00278220 File Offset: 0x00276420
		public override void GetInEdges(long v, vtkInEdgeIterator it)
		{
			vtkUndirectedGraph.vtkUndirectedGraph_GetInEdges_06(base.GetCppThis(), v, (it == null) ? default(HandleRef) : it.GetCppThis());
		}

		// Token: 0x0601C298 RID: 115352
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUndirectedGraph_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C299 RID: 115353 RVA: 0x00278250 File Offset: 0x00276450
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkUndirectedGraph.vtkUndirectedGraph_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0601C29A RID: 115354
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUndirectedGraph_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C29B RID: 115355 RVA: 0x00278270 File Offset: 0x00276470
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkUndirectedGraph.vtkUndirectedGraph_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x0601C29C RID: 115356
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUndirectedGraph_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C29D RID: 115357 RVA: 0x0027828C File Offset: 0x0027648C
		public override int IsA(string type)
		{
			return vtkUndirectedGraph.vtkUndirectedGraph_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x0601C29E RID: 115358
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkUndirectedGraph_IsStructureValid_10(HandleRef pThis, HandleRef g);

		/// <summary>
		/// Check the structure, and accept it if it is a valid
		/// undirected graph. This is public to allow
		/// the ToDirected/UndirectedGraph to work.
		/// </summary>
		// Token: 0x0601C29F RID: 115359 RVA: 0x002782AC File Offset: 0x002764AC
		public virtual bool IsStructureValid(vtkGraph g)
		{
			return vtkUndirectedGraph.vtkUndirectedGraph_IsStructureValid_10(base.GetCppThis(), (g == null) ? default(HandleRef) : g.GetCppThis()) != 0;
		}

		// Token: 0x0601C2A0 RID: 115360
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUndirectedGraph_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C2A1 RID: 115361 RVA: 0x002782E8 File Offset: 0x002764E8
		public new static int IsTypeOf(string type)
		{
			return vtkUndirectedGraph.vtkUndirectedGraph_IsTypeOf_11(type);
		}

		// Token: 0x0601C2A2 RID: 115362
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUndirectedGraph_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C2A3 RID: 115363 RVA: 0x00278304 File Offset: 0x00276504
		public new vtkUndirectedGraph NewInstance()
		{
			vtkUndirectedGraph result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUndirectedGraph.vtkUndirectedGraph_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUndirectedGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601C2A4 RID: 115364
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUndirectedGraph_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C2A5 RID: 115365 RVA: 0x00278360 File Offset: 0x00276560
		public new static vtkUndirectedGraph SafeDownCast(vtkObjectBase o)
		{
			vtkUndirectedGraph vtkUndirectedGraph = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUndirectedGraph.vtkUndirectedGraph_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUndirectedGraph = (vtkUndirectedGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUndirectedGraph.Register(null);
				}
			}
			return vtkUndirectedGraph;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E00 RID: 7680
		public new const string MRFullTypeName = "Kitware.VTK.vtkUndirectedGraph";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E01 RID: 7681
		public new static readonly string MRClassNameKey = "class vtkUndirectedGraph";
	}
}
