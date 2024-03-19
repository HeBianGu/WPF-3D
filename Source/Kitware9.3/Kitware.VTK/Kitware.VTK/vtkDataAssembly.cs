using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkDataAssembly
	/// </summary>
	/// <remarks>
	///  hierarchical representation to use with
	/// vtkPartitionedDataSetCollection
	///
	/// vtkDataAssembly is a mechanism to represent hierarchical organization of
	/// items (or vtkPartitionedDataSet instances) in a vtkPartitionedDataSetCollection.
	/// vtkPartitionedDataSetCollection is similar to a vtkMultiBlockDataSet since it
	/// provides a means for putting together multiple non-composite datasets.
	/// However, vtkPartitionedDataSetCollection itself doesn't provide any mechanism
	/// to define relationships between items in the collections. That is done using
	/// vtkDataAssembly.
	///
	/// @section Overview Overview
	///
	/// At its core, vtkDataAssembly is simply a tree of nodes starting
	/// with the root node. Each node has a unique id and a string name (names need not
	/// be unique). On initialization with `vtkDataAssembly::Initialize`, an empty tree
	/// with a root node is created. The root node's id and name can be obtained
	/// using `vtkDataAssembly::GetRootNode` and `vtkDataAssembly::GetRootNodeName`.
	/// The root node's id is fixed (vtkDataAssembly::GetRootNode), however the name
	/// can be changed using `vtkDataAssembly::SetRootNodeName`.
	///
	/// Child nodes can be added using `vtkDataAssembly::AddNode` or
	/// `vtkDataAssembly::AddNodes`, each of which returns the ids for every child
	/// node added. A non-root node can be removed using `vtkDataAssembly::RemoveNode`.
	///
	/// Each node in the tree (including the root node) can have associated dataset
	/// indices. For a vtkDataAssembly associated with a
	/// vtkPartitionedDataSetCollection, these indices refer to the item index, or
	/// partitioned-dataset-index for items in the collection. Dataset indices can be
	/// specified using `vtkDataAssembly::AddDataSetIndex`,
	/// `vtkDataAssembly::AddDataSetIndices` and removed using `vtkDataAssembly::RemoveDataSetIndex`,
	/// `vtkDataAssembly::RemoveAllDataSetIndices`.
	/// `vtkDataAssembly::GetDataSetIndices` provides a mechanism to get the
	/// database indices associated with a node, and optionally, the entire subtree
	/// rooted at the chosen node.
	///
	/// @section Searching Searching
	///
	/// Each node in the vtkDataAssembly is assigned a unique id.
	/// `vtkDataAssembly::FindFirstNodeWithName` and
	/// `vtkDataAssembly::FindNodesWithName` can be used to get the id(s) for
	/// node(s) with given name.
	///
	/// `vtkDataAssembly::SelectNodes` provides a
	/// more flexible mechanism to find nodes using name-based queries. Section
	/// @ref DataAssemblyPathQueries covers supported queries.
	///
	/// @section Traversal Traversal
	///
	/// `vtkDataAssemblyVisitor` defines a visitor API. An instance of a concretized
	/// `vtkDataAssemblyVisitor` subclass can be passed to `vtkDataAssembly::Visit`
	/// to traverse the data-assembly hierarchy either in depth-first or
	/// breadth-first order.
	///
	/// @section DataAssemblyPathQueries Supported Path Queries
	///
	/// `vtkDataAssembly::SelectNodes` can be used find nodes that match the
	/// specified query (or queries) using XPath 1.0 syntax.
	///
	/// For example:
	///
	/// * '/' is used as the path separator. If a node name has a `/` it must be
	/// escaped using `\\` in the query. Note, escaping is not necessary when using
	/// `SetNodeName`/`GetNodeName`.
	///
	/// * '/' selects the root node.
	///
	/// * '/nodename' selects all child nodes of the root with the name 'nodename'.
	///
	/// * '//nodename' selects all nodes with 'nodename' that are descendants of the
	///   root; thus, this this will traverse the entire tree.
	///
	/// * '/nodename/' selects all child nodes of all nodes named 'nodename' under
	///   the root; thus, ending a query with '/' selects the children of the found
	///   nodes rather than the nodes themselves.
	///
	/// * '/nodename1/nodename2' selects all nodes named 'nodename2' which are
	///   children of nodes with name 'nodename1' that are themselves children of
	///   the root node.
	///
	/// * '//nodename1/nodename2' finds all nodes in the tree named 'nodename1' and
	///   then selects all children of these found nodes that are named 'nodename2'.
	///
	/// @section Applications Applications
	///
	/// The separation of dataset storage (vtkPartitionedDataSetCollection) and
	/// organization (vtkDataAssembly) enables development of algorithms that can
	/// expose APIs that are not tightly coupled to dataset storage. Together,
	/// vtkPartitionedDataSetCollection and vtkDataAssembly can be thought of as a
	/// different way of organizing data that was previously organized as a
	/// vtkMultiBlockDataSet. The advantage of the this newer approach is that
	/// filters can support specifying parameters using paths or path queries
	/// rather than composite indices. The composite indices suffered from the fact
	/// that they made no sense except for the specific vtkMultiBlockDataSet they
	/// were applied too. Thus, if the filters input was changed, the composite ids
	/// rarely made any sense and needed to be updated. Paths and path queries,
	/// however, do not suffer from this issue.
	///
	/// </remarks>
	// Token: 0x02000A36 RID: 2614
	public class vtkDataAssembly : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601B3D0 RID: 111568 RVA: 0x00260E4B File Offset: 0x0025F04B
		static vtkDataAssembly()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataAssembly.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataAssembly"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601B3D1 RID: 111569 RVA: 0x00260E73 File Offset: 0x0025F073
		public vtkDataAssembly(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601B3D2 RID: 111570
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataAssembly_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B3D3 RID: 111571 RVA: 0x00260E84 File Offset: 0x0025F084
		public new static vtkDataAssembly New()
		{
			vtkDataAssembly result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataAssembly.vtkDataAssembly_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataAssembly)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B3D4 RID: 111572 RVA: 0x00260ED8 File Offset: 0x0025F0D8
		public vtkDataAssembly() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDataAssembly.vtkDataAssembly_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601B3D5 RID: 111573 RVA: 0x00260F1C File Offset: 0x0025F11C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601B3D6 RID: 111574
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDataAssembly_AddDataSetIndex_01(HandleRef pThis, int id, uint dataset_index);

		/// <summary>
		/// Add a dataset index to a node. The node id can refer to any
		/// valid node in the assembly, including the root.
		///
		/// While the same dataset can be added multiple times in the assembly,
		/// it cannot be added multiple times to the same node. Additional adds
		/// will fail.
		///
		/// @returns true if addition succeeded else false.
		/// </summary>
		// Token: 0x0601B3D7 RID: 111575 RVA: 0x00260F28 File Offset: 0x0025F128
		public bool AddDataSetIndex(int id, uint dataset_index)
		{
			return vtkDataAssembly.vtkDataAssembly_AddDataSetIndex_01(base.GetCppThis(), id, dataset_index) != 0;
		}

		// Token: 0x0601B3D8 RID: 111576
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDataAssembly_AddDataSetIndexRange_02(HandleRef pThis, int id, uint index_start, int count);

		/// <summary>
		/// Same as `AddDataSetIndices` except this supports adding a contiguous range of dataset
		/// indices in one go.
		///
		/// @ returns true if any dataset index was successfully added.
		/// </summary>
		// Token: 0x0601B3D9 RID: 111577 RVA: 0x00260F50 File Offset: 0x0025F150
		public bool AddDataSetIndexRange(int id, uint index_start, int count)
		{
			return vtkDataAssembly.vtkDataAssembly_AddDataSetIndexRange_02(base.GetCppThis(), id, index_start, count) != 0;
		}

		// Token: 0x0601B3DA RID: 111578
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataAssembly_AddNode_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int parent);

		/// <summary>
		/// Adds a node to the assembly with the given name and returns its id. `parent` is the id for
		/// the parent node which defaults to the root node id (i.e. `GetRootNode`).
		///
		/// If `parent` is invalid, the add will fail.
		///
		/// @returns id of the newly added node on success, else -1.
		/// </summary>
		// Token: 0x0601B3DB RID: 111579 RVA: 0x00260F7C File Offset: 0x0025F17C
		public int AddNode(string name, int parent)
		{
			return vtkDataAssembly.vtkDataAssembly_AddNode_03(base.GetCppThis(), name, parent);
		}

		// Token: 0x0601B3DC RID: 111580
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataAssembly_AddSubtree_04(HandleRef pThis, int parent, HandleRef other, int otherParent);

		/// <summary>
		/// Add a subtree by copy the nodes from another tree starting with the
		/// specified parent index.
		/// </summary>
		// Token: 0x0601B3DD RID: 111581 RVA: 0x00260FA0 File Offset: 0x0025F1A0
		public int AddSubtree(int parent, vtkDataAssembly other, int otherParent)
		{
			return vtkDataAssembly.vtkDataAssembly_AddSubtree_04(base.GetCppThis(), parent, (other == null) ? default(HandleRef) : other.GetCppThis(), otherParent);
		}

		// Token: 0x0601B3DE RID: 111582
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataAssembly_DeepCopy_05(HandleRef pThis, HandleRef other);

		/// <summary>
		/// Deep copy the `other`.
		/// </summary>
		// Token: 0x0601B3DF RID: 111583 RVA: 0x00260FD8 File Offset: 0x0025F1D8
		public void DeepCopy(vtkDataAssembly other)
		{
			vtkDataAssembly.vtkDataAssembly_DeepCopy_05(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis());
		}

		// Token: 0x0601B3E0 RID: 111584
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataAssembly_FindFirstNodeWithName_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int traversal_order);

		/// <summary>
		/// Finds first node that is encountered in a breadth first traversal
		/// of the assembly with the given name.
		///
		/// @returns the if of the node if found, else -1.
		/// </summary>
		// Token: 0x0601B3E1 RID: 111585 RVA: 0x00261008 File Offset: 0x0025F208
		public int FindFirstNodeWithName(string name, int traversal_order)
		{
			return vtkDataAssembly.vtkDataAssembly_FindFirstNodeWithName_06(base.GetCppThis(), name, traversal_order);
		}

		// Token: 0x0601B3E2 RID: 111586
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDataAssembly_GetAttribute_07(HandleRef pThis, int id, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, ref int value);

		/// <summary>
		/// Get an attribute value. Returns true if a value was provided else false.
		/// </summary>
		// Token: 0x0601B3E3 RID: 111587 RVA: 0x0026102C File Offset: 0x0025F22C
		public bool GetAttribute(int id, string name, ref int value)
		{
			return vtkDataAssembly.vtkDataAssembly_GetAttribute_07(base.GetCppThis(), id, name, ref value) != 0;
		}

		// Token: 0x0601B3E4 RID: 111588
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDataAssembly_GetAttribute_08(HandleRef pThis, int id, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, ref uint value);

		/// <summary>
		/// Get an attribute value. Returns true if a value was provided else false.
		/// </summary>
		// Token: 0x0601B3E5 RID: 111589 RVA: 0x00261058 File Offset: 0x0025F258
		public bool GetAttribute(int id, string name, ref uint value)
		{
			return vtkDataAssembly.vtkDataAssembly_GetAttribute_08(base.GetCppThis(), id, name, ref value) != 0;
		}

		// Token: 0x0601B3E6 RID: 111590
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDataAssembly_GetAttribute_09(HandleRef pThis, int id, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, ref long value);

		/// <summary>
		/// Get an attribute value. Returns true if a value was provided else false.
		/// </summary>
		// Token: 0x0601B3E7 RID: 111591 RVA: 0x00261084 File Offset: 0x0025F284
		public bool GetAttribute(int id, string name, ref long value)
		{
			return vtkDataAssembly.vtkDataAssembly_GetAttribute_09(base.GetCppThis(), id, name, ref value) != 0;
		}

		// Token: 0x0601B3E8 RID: 111592
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataAssembly_GetAttributeOrDefault_10(HandleRef pThis, int id, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, [MarshalAs(UnmanagedType.LPUTF8Str)] string default_value);

		/// <summary>
		/// Get an attribute value. Returns the value associated with the node or the
		/// provided default value.
		/// </summary>
		// Token: 0x0601B3E9 RID: 111593 RVA: 0x002610B0 File Offset: 0x0025F2B0
		public string GetAttributeOrDefault(int id, string name, string default_value)
		{
			string s = Marshal.PtrToStringAnsi(vtkDataAssembly.vtkDataAssembly_GetAttributeOrDefault_10(base.GetCppThis(), id, name, default_value));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601B3EA RID: 111594
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataAssembly_GetAttributeOrDefault_11(HandleRef pThis, int id, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int default_value);

		/// <summary>
		/// Get an attribute value. Returns the value associated with the node or the
		/// provided default value.
		/// </summary>
		// Token: 0x0601B3EB RID: 111595 RVA: 0x002610F0 File Offset: 0x0025F2F0
		public int GetAttributeOrDefault(int id, string name, int default_value)
		{
			return vtkDataAssembly.vtkDataAssembly_GetAttributeOrDefault_11(base.GetCppThis(), id, name, default_value);
		}

		// Token: 0x0601B3EC RID: 111596
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkDataAssembly_GetAttributeOrDefault_12(HandleRef pThis, int id, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, uint default_value);

		/// <summary>
		/// Get an attribute value. Returns the value associated with the node or the
		/// provided default value.
		/// </summary>
		// Token: 0x0601B3ED RID: 111597 RVA: 0x00261114 File Offset: 0x0025F314
		public uint GetAttributeOrDefault(int id, string name, uint default_value)
		{
			return vtkDataAssembly.vtkDataAssembly_GetAttributeOrDefault_12(base.GetCppThis(), id, name, default_value);
		}

		// Token: 0x0601B3EE RID: 111598
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataAssembly_GetAttributeOrDefault_13(HandleRef pThis, int id, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, long default_value);

		/// <summary>
		/// Get an attribute value. Returns the value associated with the node or the
		/// provided default value.
		/// </summary>
		// Token: 0x0601B3EF RID: 111599 RVA: 0x00261138 File Offset: 0x0025F338
		public long GetAttributeOrDefault(int id, string name, long default_value)
		{
			return vtkDataAssembly.vtkDataAssembly_GetAttributeOrDefault_13(base.GetCppThis(), id, name, default_value);
		}

		// Token: 0x0601B3F0 RID: 111600
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataAssembly_GetChild_14(HandleRef pThis, int parent, int index);

		/// <summary>
		/// Returns the id for a child not at the given index, if valid, otherwise -1.
		/// </summary>
		// Token: 0x0601B3F1 RID: 111601 RVA: 0x0026115C File Offset: 0x0025F35C
		public int GetChild(int parent, int index)
		{
			return vtkDataAssembly.vtkDataAssembly_GetChild_14(base.GetCppThis(), parent, index);
		}

		// Token: 0x0601B3F2 RID: 111602
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataAssembly_GetChildIndex_15(HandleRef pThis, int parent, int child);

		/// <summary>
		/// Returns the index for a child under a given. -1 if invalid.
		/// </summary>
		// Token: 0x0601B3F3 RID: 111603 RVA: 0x00261180 File Offset: 0x0025F380
		public int GetChildIndex(int parent, int child)
		{
			return vtkDataAssembly.vtkDataAssembly_GetChildIndex_15(base.GetCppThis(), parent, child);
		}

		// Token: 0x0601B3F4 RID: 111604
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataAssembly_GetFirstNodeByPath_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string path);

		/// <summary>
		/// Return a node id given the path. Returns `-1` if path is not valid.
		/// </summary>
		// Token: 0x0601B3F5 RID: 111605 RVA: 0x002611A4 File Offset: 0x0025F3A4
		public int GetFirstNodeByPath(string path)
		{
			return vtkDataAssembly.vtkDataAssembly_GetFirstNodeByPath_16(base.GetCppThis(), path);
		}

		// Token: 0x0601B3F6 RID: 111606
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataAssembly_GetNodeName_17(HandleRef pThis, int id);

		/// <summary>
		/// Get/Set a node's name. If node id is invalid, `SetNodeName` will raise an
		/// error; `GetNodeName` will also raise an error and return nullptr.
		///
		/// `SetNodeName` will raise an error if the name is not valid. Name cannot be
		/// empty or nullptr.
		/// </summary>
		// Token: 0x0601B3F7 RID: 111607 RVA: 0x002611C4 File Offset: 0x0025F3C4
		public string GetNodeName(int id)
		{
			string s = Marshal.PtrToStringAnsi(vtkDataAssembly.vtkDataAssembly_GetNodeName_17(base.GetCppThis(), id));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601B3F8 RID: 111608
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkDataAssembly_GetNodePath_18(HandleRef pThis, int id);

		/// <summary>
		/// Returns the path for a node.
		/// </summary>
		// Token: 0x0601B3F9 RID: 111609 RVA: 0x00261200 File Offset: 0x0025F400
		public string GetNodePath(int id)
		{
			return vtkDataAssembly.vtkDataAssembly_GetNodePath_18(base.GetCppThis(), id);
		}

		// Token: 0x0601B3FA RID: 111610
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataAssembly_GetNumberOfChildren_19(HandleRef pThis, int parent);

		/// <summary>
		/// Returns the number of child nodes.
		///
		/// @returns the number of child nodes for the parent node or 0 if the parent
		/// is invalid.
		/// </summary>
		// Token: 0x0601B3FB RID: 111611 RVA: 0x00261220 File Offset: 0x0025F420
		public int GetNumberOfChildren(int parent)
		{
			return vtkDataAssembly.vtkDataAssembly_GetNumberOfChildren_19(base.GetCppThis(), parent);
		}

		// Token: 0x0601B3FC RID: 111612
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataAssembly_GetNumberOfGenerationsFromBase_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B3FD RID: 111613 RVA: 0x00261240 File Offset: 0x0025F440
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDataAssembly.vtkDataAssembly_GetNumberOfGenerationsFromBase_20(base.GetCppThis(), type);
		}

		// Token: 0x0601B3FE RID: 111614
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataAssembly_GetNumberOfGenerationsFromBaseType_21([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B3FF RID: 111615 RVA: 0x00261260 File Offset: 0x0025F460
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDataAssembly.vtkDataAssembly_GetNumberOfGenerationsFromBaseType_21(type);
		}

		// Token: 0x0601B400 RID: 111616
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataAssembly_GetParent_22(HandleRef pThis, int id);

		/// <summary>
		/// Returns the id for the parent node, if any.
		/// Returns -1 if the node is invalid or has no parent (i.e. is the root node).
		/// </summary>
		// Token: 0x0601B401 RID: 111617 RVA: 0x0026127C File Offset: 0x0025F47C
		public int GetParent(int id)
		{
			return vtkDataAssembly.vtkDataAssembly_GetParent_22(base.GetCppThis(), id);
		}

		// Token: 0x0601B402 RID: 111618
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataAssembly_GetRootNode_23();

		/// <summary>
		/// Returns the ID for the root node.
		/// This always returns 0.
		/// </summary>
		// Token: 0x0601B403 RID: 111619 RVA: 0x0026129C File Offset: 0x0025F49C
		public static int GetRootNode()
		{
			return vtkDataAssembly.vtkDataAssembly_GetRootNode_23();
		}

		// Token: 0x0601B404 RID: 111620
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataAssembly_GetRootNodeName_24(HandleRef pThis);

		/// <summary>
		/// Get/Set root node name. Defaults to DataAssembly.
		/// </summary>
		// Token: 0x0601B405 RID: 111621 RVA: 0x002612B8 File Offset: 0x0025F4B8
		public string GetRootNodeName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDataAssembly.vtkDataAssembly_GetRootNodeName_24(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601B406 RID: 111622
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDataAssembly_HasAttribute_25(HandleRef pThis, int id, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Returns true if attribute with the given name is present
		/// on the chosen node.
		/// </summary>
		// Token: 0x0601B407 RID: 111623 RVA: 0x002612F4 File Offset: 0x0025F4F4
		public bool HasAttribute(int id, string name)
		{
			return vtkDataAssembly.vtkDataAssembly_HasAttribute_25(base.GetCppThis(), id, name) != 0;
		}

		// Token: 0x0601B408 RID: 111624
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataAssembly_Initialize_26(HandleRef pThis);

		/// <summary>
		/// Initializes the data-assembly. When a new vtkDataAssembly instance is
		/// created, it is in initialized form and it is not required to call this
		/// method to initialize it.
		/// </summary>
		// Token: 0x0601B409 RID: 111625 RVA: 0x0026131C File Offset: 0x0025F51C
		public void Initialize()
		{
			vtkDataAssembly.vtkDataAssembly_Initialize_26(base.GetCppThis());
		}

		// Token: 0x0601B40A RID: 111626
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDataAssembly_InitializeFromXML_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string xmlcontents);

		/// <summary>
		/// Initializes a data-assembly using an XML representation of the assembly.
		/// Returns true if the initialization was successful, otherwise the assembly
		/// is set a clean state and returns false.
		/// </summary>
		// Token: 0x0601B40B RID: 111627 RVA: 0x0026132C File Offset: 0x0025F52C
		public bool InitializeFromXML(string xmlcontents)
		{
			return vtkDataAssembly.vtkDataAssembly_InitializeFromXML_27(base.GetCppThis(), xmlcontents) != 0;
		}

		// Token: 0x0601B40C RID: 111628
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataAssembly_IsA_28(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B40D RID: 111629 RVA: 0x00261354 File Offset: 0x0025F554
		public override int IsA(string type)
		{
			return vtkDataAssembly.vtkDataAssembly_IsA_28(base.GetCppThis(), type);
		}

		// Token: 0x0601B40E RID: 111630
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDataAssembly_IsNodeNameReserved_29([MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Returns true for node names that are reserved.
		/// </summary>
		// Token: 0x0601B40F RID: 111631 RVA: 0x00261374 File Offset: 0x0025F574
		public static bool IsNodeNameReserved(string name)
		{
			return vtkDataAssembly.vtkDataAssembly_IsNodeNameReserved_29(name) != 0;
		}

		// Token: 0x0601B410 RID: 111632
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDataAssembly_IsNodeNameValid_30([MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Validates a node name.
		/// </summary>
		// Token: 0x0601B411 RID: 111633 RVA: 0x00261398 File Offset: 0x0025F598
		public static bool IsNodeNameValid(string name)
		{
			return vtkDataAssembly.vtkDataAssembly_IsNodeNameValid_30(name) != 0;
		}

		// Token: 0x0601B412 RID: 111634
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataAssembly_IsTypeOf_31([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B413 RID: 111635 RVA: 0x002613BC File Offset: 0x0025F5BC
		public new static int IsTypeOf(string type)
		{
			return vtkDataAssembly.vtkDataAssembly_IsTypeOf_31(type);
		}

		// Token: 0x0601B414 RID: 111636
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkDataAssembly_MakeValidNodeName_32([MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Converts any string to a string that is a valid node name.
		/// This is done by simply discarding any non-supported character.
		/// Additionally, if the first character is not a "_" or an alphabet, then
		/// the "_" is prepended.
		/// </summary>
		// Token: 0x0601B415 RID: 111637 RVA: 0x002613D8 File Offset: 0x0025F5D8
		public static string MakeValidNodeName(string name)
		{
			return vtkDataAssembly.vtkDataAssembly_MakeValidNodeName_32(name);
		}

		// Token: 0x0601B416 RID: 111638
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataAssembly_NewInstance_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B417 RID: 111639 RVA: 0x002613F4 File Offset: 0x0025F5F4
		public new vtkDataAssembly NewInstance()
		{
			vtkDataAssembly result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataAssembly.vtkDataAssembly_NewInstance_34(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataAssembly)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601B418 RID: 111640
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDataAssembly_RemoveAllDataSetIndices_35(HandleRef pThis, int id, byte traverse_subtree);

		/// <summary>
		/// Clears all dataset indices from the node.
		///
		/// If `traverse_subtree` is true (default), recursively removes all
		/// dataset indices from all the child nodes.
		///
		/// @returns true on success, else returns false.
		/// </summary>
		// Token: 0x0601B419 RID: 111641 RVA: 0x00261450 File Offset: 0x0025F650
		public bool RemoveAllDataSetIndices(int id, bool traverse_subtree)
		{
			return vtkDataAssembly.vtkDataAssembly_RemoveAllDataSetIndices_35(base.GetCppThis(), id, traverse_subtree ? (byte)1 : (byte)0) != 0;
		}

		// Token: 0x0601B41A RID: 111642
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDataAssembly_RemoveDataSetIndex_36(HandleRef pThis, int id, uint dataset_index);

		/// <summary>
		/// Removes a dataset index from a node.
		///
		/// @returns true if the removal was successful, else returns false.
		/// </summary>
		// Token: 0x0601B41B RID: 111643 RVA: 0x00261480 File Offset: 0x0025F680
		public bool RemoveDataSetIndex(int id, uint dataset_index)
		{
			return vtkDataAssembly.vtkDataAssembly_RemoveDataSetIndex_36(base.GetCppThis(), id, dataset_index) != 0;
		}

		// Token: 0x0601B41C RID: 111644
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDataAssembly_RemoveNode_37(HandleRef pThis, int id);

		/// <summary>
		/// Removes a node from the assembly. The node identified by the id and all its
		/// children are removed.
		///
		/// Root node cannot be removed.
		///
		/// @returns true if removal was successful, false if the id is invalid or root
		/// node id.
		/// </summary>
		// Token: 0x0601B41D RID: 111645 RVA: 0x002614A8 File Offset: 0x0025F6A8
		public bool RemoveNode(int id)
		{
			return vtkDataAssembly.vtkDataAssembly_RemoveNode_37(base.GetCppThis(), id) != 0;
		}

		// Token: 0x0601B41E RID: 111646
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataAssembly_SafeDownCast_38(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B41F RID: 111647 RVA: 0x002614D0 File Offset: 0x0025F6D0
		public new static vtkDataAssembly SafeDownCast(vtkObjectBase o)
		{
			vtkDataAssembly vtkDataAssembly = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataAssembly.vtkDataAssembly_SafeDownCast_38((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataAssembly = (vtkDataAssembly)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataAssembly.Register(null);
				}
			}
			return vtkDataAssembly;
		}

		// Token: 0x0601B420 RID: 111648
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataAssembly_SetAttribute_39(HandleRef pThis, int id, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, [MarshalAs(UnmanagedType.LPUTF8Str)] string value);

		/// <summary>
		/// Set an attribute. Will replace an existing attribute with the same name if
		/// present.
		/// </summary>
		// Token: 0x0601B421 RID: 111649 RVA: 0x0026154F File Offset: 0x0025F74F
		public void SetAttribute(int id, string name, string value)
		{
			vtkDataAssembly.vtkDataAssembly_SetAttribute_39(base.GetCppThis(), id, name, value);
		}

		// Token: 0x0601B422 RID: 111650
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataAssembly_SetAttribute_40(HandleRef pThis, int id, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int value);

		/// <summary>
		/// Set an attribute. Will replace an existing attribute with the same name if
		/// present.
		/// </summary>
		// Token: 0x0601B423 RID: 111651 RVA: 0x00261561 File Offset: 0x0025F761
		public void SetAttribute(int id, string name, int value)
		{
			vtkDataAssembly.vtkDataAssembly_SetAttribute_40(base.GetCppThis(), id, name, value);
		}

		// Token: 0x0601B424 RID: 111652
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataAssembly_SetAttribute_41(HandleRef pThis, int id, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, uint value);

		/// <summary>
		/// Set an attribute. Will replace an existing attribute with the same name if
		/// present.
		/// </summary>
		// Token: 0x0601B425 RID: 111653 RVA: 0x00261573 File Offset: 0x0025F773
		public void SetAttribute(int id, string name, uint value)
		{
			vtkDataAssembly.vtkDataAssembly_SetAttribute_41(base.GetCppThis(), id, name, value);
		}

		// Token: 0x0601B426 RID: 111654
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataAssembly_SetAttribute_42(HandleRef pThis, int id, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, long value);

		/// <summary>
		/// Set an attribute. Will replace an existing attribute with the same name if
		/// present.
		/// </summary>
		// Token: 0x0601B427 RID: 111655 RVA: 0x00261585 File Offset: 0x0025F785
		public void SetAttribute(int id, string name, long value)
		{
			vtkDataAssembly.vtkDataAssembly_SetAttribute_42(base.GetCppThis(), id, name, value);
		}

		// Token: 0x0601B428 RID: 111656
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataAssembly_SetNodeName_43(HandleRef pThis, int id, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Get/Set a node's name. If node id is invalid, `SetNodeName` will raise an
		/// error; `GetNodeName` will also raise an error and return nullptr.
		///
		/// `SetNodeName` will raise an error if the name is not valid. Name cannot be
		/// empty or nullptr.
		/// </summary>
		// Token: 0x0601B429 RID: 111657 RVA: 0x00261597 File Offset: 0x0025F797
		public void SetNodeName(int id, string name)
		{
			vtkDataAssembly.vtkDataAssembly_SetNodeName_43(base.GetCppThis(), id, name);
		}

		// Token: 0x0601B42A RID: 111658
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataAssembly_SetRootNodeName_44(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Get/Set root node name. Defaults to DataAssembly.
		/// </summary>
		// Token: 0x0601B42B RID: 111659 RVA: 0x002615A8 File Offset: 0x0025F7A8
		public void SetRootNodeName(string name)
		{
			vtkDataAssembly.vtkDataAssembly_SetRootNodeName_44(base.GetCppThis(), name);
		}

		// Token: 0x0601B42C RID: 111660
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataAssembly_Visit_45(HandleRef pThis, HandleRef visitor, int traversal_order);

		/// <summary>
		/// Visit each node in the assembly for processing. The traversal order can be
		/// specified using `traversal_order` which defaults to depth-first.
		/// </summary>
		// Token: 0x0601B42D RID: 111661 RVA: 0x002615B8 File Offset: 0x0025F7B8
		public void Visit(vtkDataAssemblyVisitor visitor, int traversal_order)
		{
			vtkDataAssembly.vtkDataAssembly_Visit_45(base.GetCppThis(), (visitor == null) ? default(HandleRef) : visitor.GetCppThis(), traversal_order);
		}

		// Token: 0x0601B42E RID: 111662
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataAssembly_Visit_46(HandleRef pThis, int id, HandleRef visitor, int traversal_order);

		/// <summary>
		/// Visit each node in the assembly for processing. The traversal order can be
		/// specified using `traversal_order` which defaults to depth-first.
		/// </summary>
		// Token: 0x0601B42F RID: 111663 RVA: 0x002615E8 File Offset: 0x0025F7E8
		public void Visit(int id, vtkDataAssemblyVisitor visitor, int traversal_order)
		{
			vtkDataAssembly.vtkDataAssembly_Visit_46(base.GetCppThis(), id, (visitor == null) ? default(HandleRef) : visitor.GetCppThis(), traversal_order);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D5F RID: 7519
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataAssembly";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D60 RID: 7520
		public new static readonly string MRClassNameKey = "class vtkDataAssembly";

		/// <summary>
		/// Clears all dataset indices from the node.
		///
		/// If `traverse_subtree` is true (default), recursively removes all
		/// dataset indices from all the child nodes.
		///
		/// @returns true on success, else returns false.
		/// </summary>
		// Token: 0x02000A37 RID: 2615
		public enum TraversalOrder
		{
			/// <summary>enum member</summary>
			// Token: 0x04001D62 RID: 7522
			BreadthFirst = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001D63 RID: 7523
			DepthFirst = 0
		}
	}
}
