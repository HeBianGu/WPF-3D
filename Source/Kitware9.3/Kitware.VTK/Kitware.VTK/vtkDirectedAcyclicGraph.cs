using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDirectedAcyclicGraph
	/// </summary>
	/// <remarks>
	///    A rooted tree data structure.
	///
	///
	/// vtkDirectedAcyclicGraph is a connected directed graph with no cycles. A tree is a type of
	/// directed graph, so works with all graph algorithms.
	///
	/// vtkDirectedAcyclicGraph is a read-only data structure.
	/// To construct a tree, create an instance of vtkMutableDirectedGraph.
	/// Add vertices and edges with AddVertex() and AddEdge(). You may alternately
	/// start by adding a single vertex as the root then call graph-&gt;AddChild(parent)
	/// which adds a new vertex and connects the parent to the child.
	/// The tree MUST have all edges in the proper direction, from parent to child.
	/// After building the tree, call tree-&gt;CheckedShallowCopy(graph) to copy the
	/// structure into a vtkDirectedAcyclicGraph. This method will return false if the graph is
	/// an invalid tree.
	///
	/// vtkDirectedAcyclicGraph provides some convenience methods for obtaining the parent and
	/// children of a vertex, for finding the root, and determining if a vertex
	/// is a leaf (a vertex with no children).
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkDirectedGraph vtkMutableDirectedGraph vtkGraph
	/// </seealso>
	// Token: 0x02000A42 RID: 2626
	public class vtkDirectedAcyclicGraph : vtkDirectedGraph
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601B5C7 RID: 112071 RVA: 0x002643F7 File Offset: 0x002625F7
		static vtkDirectedAcyclicGraph()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDirectedAcyclicGraph.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDirectedAcyclicGraph"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601B5C8 RID: 112072 RVA: 0x0026441F File Offset: 0x0026261F
		public vtkDirectedAcyclicGraph(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601B5C9 RID: 112073
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDirectedAcyclicGraph_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B5CA RID: 112074 RVA: 0x00264430 File Offset: 0x00262630
		public new static vtkDirectedAcyclicGraph New()
		{
			vtkDirectedAcyclicGraph result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDirectedAcyclicGraph.vtkDirectedAcyclicGraph_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDirectedAcyclicGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B5CB RID: 112075 RVA: 0x00264484 File Offset: 0x00262684
		public vtkDirectedAcyclicGraph() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDirectedAcyclicGraph.vtkDirectedAcyclicGraph_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601B5CC RID: 112076 RVA: 0x002644C8 File Offset: 0x002626C8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601B5CD RID: 112077
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDirectedAcyclicGraph_GetData_01(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve a graph from an information vector.
		/// </summary>
		// Token: 0x0601B5CE RID: 112078 RVA: 0x002644D4 File Offset: 0x002626D4
		public new static vtkDirectedAcyclicGraph GetData(vtkInformation info)
		{
			vtkDirectedAcyclicGraph vtkDirectedAcyclicGraph = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDirectedAcyclicGraph.vtkDirectedAcyclicGraph_GetData_01((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDirectedAcyclicGraph = (vtkDirectedAcyclicGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDirectedAcyclicGraph.Register(null);
				}
			}
			return vtkDirectedAcyclicGraph;
		}

		// Token: 0x0601B5CF RID: 112079
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDirectedAcyclicGraph_GetData_02(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve a graph from an information vector.
		/// </summary>
		// Token: 0x0601B5D0 RID: 112080 RVA: 0x00264554 File Offset: 0x00262754
		public new static vtkDirectedAcyclicGraph GetData(vtkInformationVector v, int i)
		{
			vtkDirectedAcyclicGraph vtkDirectedAcyclicGraph = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDirectedAcyclicGraph.vtkDirectedAcyclicGraph_GetData_02((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDirectedAcyclicGraph = (vtkDirectedAcyclicGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDirectedAcyclicGraph.Register(null);
				}
			}
			return vtkDirectedAcyclicGraph;
		}

		// Token: 0x0601B5D1 RID: 112081
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDirectedAcyclicGraph_GetDataObjectType_03(HandleRef pThis);

		/// <summary>
		/// Return what type of dataset this is.
		/// </summary>
		// Token: 0x0601B5D2 RID: 112082 RVA: 0x002645D4 File Offset: 0x002627D4
		public override int GetDataObjectType()
		{
			return vtkDirectedAcyclicGraph.vtkDirectedAcyclicGraph_GetDataObjectType_03(base.GetCppThis());
		}

		// Token: 0x0601B5D3 RID: 112083
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDirectedAcyclicGraph_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B5D4 RID: 112084 RVA: 0x002645F4 File Offset: 0x002627F4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDirectedAcyclicGraph.vtkDirectedAcyclicGraph_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601B5D5 RID: 112085
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDirectedAcyclicGraph_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B5D6 RID: 112086 RVA: 0x00264614 File Offset: 0x00262814
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDirectedAcyclicGraph.vtkDirectedAcyclicGraph_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601B5D7 RID: 112087
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDirectedAcyclicGraph_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B5D8 RID: 112088 RVA: 0x00264630 File Offset: 0x00262830
		public override int IsA(string type)
		{
			return vtkDirectedAcyclicGraph.vtkDirectedAcyclicGraph_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0601B5D9 RID: 112089
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDirectedAcyclicGraph_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B5DA RID: 112090 RVA: 0x00264650 File Offset: 0x00262850
		public new static int IsTypeOf(string type)
		{
			return vtkDirectedAcyclicGraph.vtkDirectedAcyclicGraph_IsTypeOf_07(type);
		}

		// Token: 0x0601B5DB RID: 112091
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDirectedAcyclicGraph_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B5DC RID: 112092 RVA: 0x0026466C File Offset: 0x0026286C
		public new vtkDirectedAcyclicGraph NewInstance()
		{
			vtkDirectedAcyclicGraph result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDirectedAcyclicGraph.vtkDirectedAcyclicGraph_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDirectedAcyclicGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601B5DD RID: 112093
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDirectedAcyclicGraph_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B5DE RID: 112094 RVA: 0x002646C8 File Offset: 0x002628C8
		public new static vtkDirectedAcyclicGraph SafeDownCast(vtkObjectBase o)
		{
			vtkDirectedAcyclicGraph vtkDirectedAcyclicGraph = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDirectedAcyclicGraph.vtkDirectedAcyclicGraph_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDirectedAcyclicGraph = (vtkDirectedAcyclicGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDirectedAcyclicGraph.Register(null);
				}
			}
			return vtkDirectedAcyclicGraph;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D78 RID: 7544
		public new const string MRFullTypeName = "Kitware.VTK.vtkDirectedAcyclicGraph";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D79 RID: 7545
		public new static readonly string MRClassNameKey = "class vtkDirectedAcyclicGraph";
	}
}
