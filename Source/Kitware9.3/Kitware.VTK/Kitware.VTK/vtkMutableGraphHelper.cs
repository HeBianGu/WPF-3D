using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMutableGraphHelper
	/// </summary>
	/// <remarks>
	///    Helper class for building a directed or
	///   directed graph
	///
	///
	/// vtkMutableGraphHelper has helper methods AddVertex and AddEdge which
	/// add vertices/edges to the underlying mutable graph. This is helpful in
	/// filters which need to (re)construct graphs which may be either directed
	/// or undirected.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkGraph vtkMutableDirectedGraph vtkMutableUndirectedGraph
	/// </seealso>
	// Token: 0x02000686 RID: 1670
	public class vtkMutableGraphHelper : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011F03 RID: 73475 RVA: 0x00191B57 File Offset: 0x0018FD57
		static vtkMutableGraphHelper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMutableGraphHelper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMutableGraphHelper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011F04 RID: 73476 RVA: 0x00191B7F File Offset: 0x0018FD7F
		public vtkMutableGraphHelper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011F05 RID: 73477
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMutableGraphHelper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011F06 RID: 73478 RVA: 0x00191B90 File Offset: 0x0018FD90
		public new static vtkMutableGraphHelper New()
		{
			vtkMutableGraphHelper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMutableGraphHelper.vtkMutableGraphHelper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMutableGraphHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011F07 RID: 73479 RVA: 0x00191BE4 File Offset: 0x0018FDE4
		public vtkMutableGraphHelper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMutableGraphHelper.vtkMutableGraphHelper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011F08 RID: 73480 RVA: 0x00191C28 File Offset: 0x0018FE28
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011F09 RID: 73481
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMutableGraphHelper_AddGraphEdge_01(HandleRef pThis, long u, long v, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Add an edge to the underlying mutable graph.
		/// </summary>
		// Token: 0x06011F0A RID: 73482 RVA: 0x00191C34 File Offset: 0x0018FE34
		public vtkGraphEdge AddGraphEdge(long u, long v)
		{
			vtkGraphEdge vtkGraphEdge = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMutableGraphHelper.vtkMutableGraphHelper_AddGraphEdge_01(base.GetCppThis(), u, v, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06011F0B RID: 73483
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMutableGraphHelper_AddVertex_02(HandleRef pThis);

		/// <summary>
		/// Add a vertex to the underlying mutable graph.
		/// </summary>
		// Token: 0x06011F0C RID: 73484 RVA: 0x00191CA8 File Offset: 0x0018FEA8
		public long AddVertex()
		{
			return vtkMutableGraphHelper.vtkMutableGraphHelper_AddVertex_02(base.GetCppThis());
		}

		// Token: 0x06011F0D RID: 73485
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMutableGraphHelper_GetGraph_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the underlying graph that you want to modify with this helper.
		/// The graph must be an instance of vtkMutableDirectedGraph or
		/// vtkMutableUndirectedGraph.
		/// </summary>
		// Token: 0x06011F0E RID: 73486 RVA: 0x00191CC8 File Offset: 0x0018FEC8
		public vtkGraph GetGraph()
		{
			vtkGraph vtkGraph = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMutableGraphHelper.vtkMutableGraphHelper_GetGraph_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06011F0F RID: 73487
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMutableGraphHelper_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011F10 RID: 73488 RVA: 0x00191D38 File Offset: 0x0018FF38
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMutableGraphHelper.vtkMutableGraphHelper_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06011F11 RID: 73489
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMutableGraphHelper_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011F12 RID: 73490 RVA: 0x00191D58 File Offset: 0x0018FF58
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMutableGraphHelper.vtkMutableGraphHelper_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06011F13 RID: 73491
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMutableGraphHelper_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011F14 RID: 73492 RVA: 0x00191D74 File Offset: 0x0018FF74
		public override int IsA(string type)
		{
			return vtkMutableGraphHelper.vtkMutableGraphHelper_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06011F15 RID: 73493
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMutableGraphHelper_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011F16 RID: 73494 RVA: 0x00191D94 File Offset: 0x0018FF94
		public new static int IsTypeOf(string type)
		{
			return vtkMutableGraphHelper.vtkMutableGraphHelper_IsTypeOf_07(type);
		}

		// Token: 0x06011F17 RID: 73495
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMutableGraphHelper_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011F18 RID: 73496 RVA: 0x00191DB0 File Offset: 0x0018FFB0
		public new vtkMutableGraphHelper NewInstance()
		{
			vtkMutableGraphHelper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMutableGraphHelper.vtkMutableGraphHelper_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMutableGraphHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011F19 RID: 73497
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMutableGraphHelper_RemoveEdge_10(HandleRef pThis, long e);

		/// <summary>
		/// Remove an edge from the underlying mutable graph.
		/// </summary>
		// Token: 0x06011F1A RID: 73498 RVA: 0x00191E0A File Offset: 0x0019000A
		public void RemoveEdge(long e)
		{
			vtkMutableGraphHelper.vtkMutableGraphHelper_RemoveEdge_10(base.GetCppThis(), e);
		}

		// Token: 0x06011F1B RID: 73499
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMutableGraphHelper_RemoveEdges_11(HandleRef pThis, HandleRef edges);

		/// <summary>
		/// Remove a collection of edges from the underlying mutable graph.
		/// </summary>
		// Token: 0x06011F1C RID: 73500 RVA: 0x00191E1C File Offset: 0x0019001C
		public void RemoveEdges(vtkIdTypeArray edges)
		{
			vtkMutableGraphHelper.vtkMutableGraphHelper_RemoveEdges_11(base.GetCppThis(), (edges == null) ? default(HandleRef) : edges.GetCppThis());
		}

		// Token: 0x06011F1D RID: 73501
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMutableGraphHelper_RemoveVertex_12(HandleRef pThis, long v);

		/// <summary>
		/// Remove a vertex from the underlying mutable graph.
		/// </summary>
		// Token: 0x06011F1E RID: 73502 RVA: 0x00191E4B File Offset: 0x0019004B
		public void RemoveVertex(long v)
		{
			vtkMutableGraphHelper.vtkMutableGraphHelper_RemoveVertex_12(base.GetCppThis(), v);
		}

		// Token: 0x06011F1F RID: 73503
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMutableGraphHelper_RemoveVertices_13(HandleRef pThis, HandleRef verts);

		/// <summary>
		/// Remove a collection of vertices from the underlying mutable graph.
		/// </summary>
		// Token: 0x06011F20 RID: 73504 RVA: 0x00191E5C File Offset: 0x0019005C
		public void RemoveVertices(vtkIdTypeArray verts)
		{
			vtkMutableGraphHelper.vtkMutableGraphHelper_RemoveVertices_13(base.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis());
		}

		// Token: 0x06011F21 RID: 73505
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMutableGraphHelper_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011F22 RID: 73506 RVA: 0x00191E8C File Offset: 0x0019008C
		public new static vtkMutableGraphHelper SafeDownCast(vtkObjectBase o)
		{
			vtkMutableGraphHelper vtkMutableGraphHelper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMutableGraphHelper.vtkMutableGraphHelper_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMutableGraphHelper = (vtkMutableGraphHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMutableGraphHelper.Register(null);
				}
			}
			return vtkMutableGraphHelper;
		}

		// Token: 0x06011F23 RID: 73507
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMutableGraphHelper_SetGraph_15(HandleRef pThis, HandleRef g);

		/// <summary>
		/// Set the underlying graph that you want to modify with this helper.
		/// The graph must be an instance of vtkMutableDirectedGraph or
		/// vtkMutableUndirectedGraph.
		/// </summary>
		// Token: 0x06011F24 RID: 73508 RVA: 0x00191F0C File Offset: 0x0019010C
		public void SetGraph(vtkGraph g)
		{
			vtkMutableGraphHelper.vtkMutableGraphHelper_SetGraph_15(base.GetCppThis(), (g == null) ? default(HandleRef) : g.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014B5 RID: 5301
		public new const string MRFullTypeName = "Kitware.VTK.vtkMutableGraphHelper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014B6 RID: 5302
		public new static readonly string MRClassNameKey = "class vtkMutableGraphHelper";
	}
}
