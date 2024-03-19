using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTree
	/// </summary>
	/// <remarks>
	///    A rooted tree data structure.
	///
	///
	/// vtkTree is a connected directed graph with no cycles. A tree is a type of
	/// directed graph, so works with all graph algorithms.
	///
	/// vtkTree is a read-only data structure.
	/// To construct a tree, create an instance of vtkMutableDirectedGraph.
	/// Add vertices and edges with AddVertex() and AddEdge(). You may alternately
	/// start by adding a single vertex as the root then call graph-&gt;AddChild(parent)
	/// which adds a new vertex and connects the parent to the child.
	/// The tree MUST have all edges in the proper direction, from parent to child.
	/// After building the tree, call tree-&gt;CheckedShallowCopy(graph) to copy the
	/// structure into a vtkTree. This method will return false if the graph is
	/// an invalid tree.
	///
	/// vtkTree provides some convenience methods for obtaining the parent and
	/// children of a vertex, for finding the root, and determining if a vertex
	/// is a leaf (a vertex with no children).
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkDirectedGraph vtkMutableDirectedGraph vtkGraph
	/// </seealso>
	// Token: 0x02000AD4 RID: 2772
	public class vtkTree : vtkDirectedAcyclicGraph
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D357 RID: 119639 RVA: 0x00292FB1 File Offset: 0x002911B1
		static vtkTree()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTree.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTree"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D358 RID: 119640 RVA: 0x00292FD9 File Offset: 0x002911D9
		public vtkTree(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601D359 RID: 119641
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTree_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D35A RID: 119642 RVA: 0x00292FE8 File Offset: 0x002911E8
		public new static vtkTree New()
		{
			vtkTree result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTree.vtkTree_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D35B RID: 119643 RVA: 0x0029303C File Offset: 0x0029123C
		public vtkTree() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTree.vtkTree_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D35C RID: 119644 RVA: 0x00293080 File Offset: 0x00291280
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D35D RID: 119645
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTree_GetChild_01(HandleRef pThis, long v, long i);

		/// <summary>
		/// Get the i-th child of a parent vertex.
		/// </summary>
		// Token: 0x0601D35E RID: 119646 RVA: 0x0029308C File Offset: 0x0029128C
		public long GetChild(long v, long i)
		{
			return vtkTree.vtkTree_GetChild_01(base.GetCppThis(), v, i);
		}

		// Token: 0x0601D35F RID: 119647
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTree_GetChildren_02(HandleRef pThis, long v, HandleRef it);

		/// <summary>
		/// Get the child vertices of a vertex.
		/// This is a convenience method that functions exactly like
		/// GetAdjacentVertices.
		/// </summary>
		// Token: 0x0601D360 RID: 119648 RVA: 0x002930B0 File Offset: 0x002912B0
		public void GetChildren(long v, vtkAdjacentVertexIterator it)
		{
			vtkTree.vtkTree_GetChildren_02(base.GetCppThis(), v, (it == null) ? default(HandleRef) : it.GetCppThis());
		}

		// Token: 0x0601D361 RID: 119649
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTree_GetData_03(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve a graph from an information vector.
		/// </summary>
		// Token: 0x0601D362 RID: 119650 RVA: 0x002930E0 File Offset: 0x002912E0
		public new static vtkTree GetData(vtkInformation info)
		{
			vtkTree vtkTree = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTree.vtkTree_GetData_03((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTree = (vtkTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTree.Register(null);
				}
			}
			return vtkTree;
		}

		// Token: 0x0601D363 RID: 119651
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTree_GetData_04(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve a graph from an information vector.
		/// </summary>
		// Token: 0x0601D364 RID: 119652 RVA: 0x00293160 File Offset: 0x00291360
		public new static vtkTree GetData(vtkInformationVector v, int i)
		{
			vtkTree vtkTree = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTree.vtkTree_GetData_04((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTree = (vtkTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTree.Register(null);
				}
			}
			return vtkTree;
		}

		// Token: 0x0601D365 RID: 119653
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTree_GetDataObjectType_05(HandleRef pThis);

		/// <summary>
		/// Return what type of dataset this is.
		/// </summary>
		// Token: 0x0601D366 RID: 119654 RVA: 0x002931E0 File Offset: 0x002913E0
		public override int GetDataObjectType()
		{
			return vtkTree.vtkTree_GetDataObjectType_05(base.GetCppThis());
		}

		// Token: 0x0601D367 RID: 119655
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTree_GetLevel_06(HandleRef pThis, long v);

		/// <summary>
		/// Get the level of the vertex in the tree.  The root vertex has level 0.
		/// Returns -1 if the vertex id is &lt; 0 or greater than the number of vertices
		/// in the tree.
		/// </summary>
		// Token: 0x0601D368 RID: 119656 RVA: 0x00293200 File Offset: 0x00291400
		public long GetLevel(long v)
		{
			return vtkTree.vtkTree_GetLevel_06(base.GetCppThis(), v);
		}

		// Token: 0x0601D369 RID: 119657
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTree_GetNumberOfChildren_07(HandleRef pThis, long v);

		/// <summary>
		/// Get the number of children of a vertex.
		/// </summary>
		// Token: 0x0601D36A RID: 119658 RVA: 0x00293220 File Offset: 0x00291420
		public long GetNumberOfChildren(long v)
		{
			return vtkTree.vtkTree_GetNumberOfChildren_07(base.GetCppThis(), v);
		}

		// Token: 0x0601D36B RID: 119659
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTree_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D36C RID: 119660 RVA: 0x00293240 File Offset: 0x00291440
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTree.vtkTree_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x0601D36D RID: 119661
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTree_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D36E RID: 119662 RVA: 0x00293260 File Offset: 0x00291460
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTree.vtkTree_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x0601D36F RID: 119663
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTree_GetParent_10(HandleRef pThis, long v);

		/// <summary>
		/// Get the parent of a vertex.
		/// </summary>
		// Token: 0x0601D370 RID: 119664 RVA: 0x0029327C File Offset: 0x0029147C
		public long GetParent(long v)
		{
			return vtkTree.vtkTree_GetParent_10(base.GetCppThis(), v);
		}

		// Token: 0x0601D371 RID: 119665
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTree_GetRoot_11(HandleRef pThis);

		/// <summary>
		/// Get the root vertex of the tree.
		/// </summary>
		// Token: 0x0601D372 RID: 119666 RVA: 0x0029329C File Offset: 0x0029149C
		public virtual long GetRoot()
		{
			return vtkTree.vtkTree_GetRoot_11(base.GetCppThis());
		}

		// Token: 0x0601D373 RID: 119667
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTree_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D374 RID: 119668 RVA: 0x002932BC File Offset: 0x002914BC
		public override int IsA(string type)
		{
			return vtkTree.vtkTree_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x0601D375 RID: 119669
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTree_IsLeaf_13(HandleRef pThis, long vertex);

		/// <summary>
		/// Return whether the vertex is a leaf (i.e. it has no children).
		/// </summary>
		// Token: 0x0601D376 RID: 119670 RVA: 0x002932DC File Offset: 0x002914DC
		public bool IsLeaf(long vertex)
		{
			return vtkTree.vtkTree_IsLeaf_13(base.GetCppThis(), vertex) != 0;
		}

		// Token: 0x0601D377 RID: 119671
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTree_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D378 RID: 119672 RVA: 0x00293304 File Offset: 0x00291504
		public new static int IsTypeOf(string type)
		{
			return vtkTree.vtkTree_IsTypeOf_14(type);
		}

		// Token: 0x0601D379 RID: 119673
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTree_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D37A RID: 119674 RVA: 0x00293320 File Offset: 0x00291520
		public new vtkTree NewInstance()
		{
			vtkTree result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTree.vtkTree_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601D37B RID: 119675
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTree_ReorderChildren_17(HandleRef pThis, long parent, HandleRef children);

		/// <summary>
		/// Reorder the children of a parent vertex.
		/// The children array must contain all the children of parent,
		/// just in a different order.
		/// This does not change the topology of the tree.
		/// </summary>
		// Token: 0x0601D37C RID: 119676 RVA: 0x0029337C File Offset: 0x0029157C
		public virtual void ReorderChildren(long parent, vtkIdTypeArray children)
		{
			vtkTree.vtkTree_ReorderChildren_17(base.GetCppThis(), parent, (children == null) ? default(HandleRef) : children.GetCppThis());
		}

		// Token: 0x0601D37D RID: 119677
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTree_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D37E RID: 119678 RVA: 0x002933AC File Offset: 0x002915AC
		public new static vtkTree SafeDownCast(vtkObjectBase o)
		{
			vtkTree vtkTree = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTree.vtkTree_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTree = (vtkTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTree.Register(null);
				}
			}
			return vtkTree;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001ECE RID: 7886
		public new const string MRFullTypeName = "Kitware.VTK.vtkTree";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001ECF RID: 7887
		public new static readonly string MRClassNameKey = "class vtkTree";
	}
}
