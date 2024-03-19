using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkHyperTree
	/// </summary>
	/// <remarks>
	///    A data object structured as a tree.
	///
	/// An hypertree grid is a dataobject containing a rectilinear grid of
	/// elements that can be either null or a hypertree.
	/// An hypertree is a dataobject describing a decomposition tree.
	/// A VERTICE is an element of this tree.
	/// A NODE, also called COARSE cell, is a specific vertice which is
	/// refined and than has either exactly f^d children, where f in {2,3}
	/// is the branching factor, the same value for all trees in this
	/// hypertree grid, and d in {1,2,3} is the spatial dimension. It is
	/// called coarse because there are smaller child cells.
	/// A LEAF, also called FINE cell, is a vertice without children, not
	/// refined. It is called fine because in the same space there are no
	/// finer cells.
	/// In a tree, we can find coarse cells smaller than fine cell but not
	/// in the same space.
	///
	/// Such trees have particular names for f=2:
	/// - bintree (d=1),
	/// - quadtree (d=2),
	/// - octree (d=3).
	///
	/// The original octree class name came from the following paper:
	/// \verbatim
	/// @ARTICLE{yau-srihari-1983,
	///  author={Mann-May Yau and Sargur N. Srihari},
	///  title={A Hierarchical Data Structure for Multidimensional Digital Images},
	///  journal={Communications of the ACM},
	///  month={July},
	///  year={1983},
	///  volume={26},
	///  number={7},
	///  pages={504--515}
	///  }
	/// \endverbatim
	///
	/// Attributes are associated with (all) cells, not with points. The
	/// attributes that are associated with coarses, it's used for LoD
	/// (Level-of-Detail). The attributes on coarse cells can be given by the
	/// code or/and computed by the use of a specific filter exploiting the
	/// values from its children (which can be leaves or not).
	///
	/// The geometry is implicitly given by the size of the root node on each
	/// axis and position of the origin. In fact, in 3D, the geometry is then
	/// not limited to a cube but can have a rectangular shape.
	///
	/// By construction, an hypertree is efficient in memory usage. The LoD
	/// feature allows for quick culling of part of the dataobject.
	///
	/// This is an abstract class used as a superclass by a custom templated
	/// compact class. Other versions of this code could be made available
	/// to meet other needs without questioning cursors and filters.
	/// All methods are pure virtual. This is done to hide templates.
	///
	/// @par Case octree with f=2, d=3:
	/// For each node (coarse cell), 8 children are encoded in a child index
	/// (from 0 to 7) in the following orientation described in hypertree grid.
	/// It is easy to access each child as a cell of a grid.
	/// Note also that the binary representation is relevant, each bit codes
	/// a side:
	/// bit 0 encodes -x side (0) or +x side (1)
	/// bit 1 encodes -y side (0) or +y side (1)
	/// bit 2 encodes -z side (0) or +z side (1)
	/// -z side is first, in counter-clockwise order:
	///  0: -y -x sides
	///  1: -y +x sides
	///  2: +y -x sides
	///  3: +y +x sides
	/// +z side is last, in counter-clockwise order:
	///  4: -y -x sides
	///  5: -y +x sides
	///  6: +y -x sides
	///  7: +y +x sides
	/// \verbatim
	///              +y
	/// +-+-+        ^
	/// |2|3|        |
	/// +-+-+  O +z  +-&gt; +x
	/// |0|1|
	/// +-+-+
	///              +y
	/// +-+-+        ^
	/// |6|7|        |
	/// +-+-+  1 +z  +-&gt; +x
	/// |4|5|
	/// +-+-+
	/// \endverbatim
	///
	/// @par Case quadtree with f=2, d=2:
	/// Just use 2 bits.
	/// \verbatim
	///              +y
	/// +-+-+        ^
	/// |2|3|        |
	/// +-+-+        +-&gt; +x
	/// |0|1|
	/// +-+-+
	/// \endverbatim
	///
	/// @par Case bintree with f=2, d=1:
	/// Just use 1 bits.
	/// \verbatim
	///             O+-&gt; +x
	/// \endverbatim
	///
	/// It's more difficult with f=3.
	///
	/// @par Thanks:
	/// This class was written by Philippe Pebay, Joachim Pouderoux, and
	/// Charles Law, Kitware 2013
	/// This class was modified by Guenole Harel and Jacques-Bernard Lekien 2014
	/// This class was modified by Philippe Pebay, 2016
	/// Among others, this class was simplified, optimized (memory), documented and
	/// completed for to improve IO XML by Jacques-Bernard Lekien 2018-19
	/// This work was supported by Commissariat a l'Energie Atomique
	/// CEA, DAM, DIF, F-91297 Arpajon, France.
	/// </remarks>
	// Token: 0x02000A5D RID: 2653
	public abstract class vtkHyperTree : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601BB6A RID: 113514 RVA: 0x0026CF33 File Offset: 0x0026B133
		static vtkHyperTree()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHyperTree.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHyperTree"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601BB6B RID: 113515 RVA: 0x0026CF5B File Offset: 0x0026B15B
		public vtkHyperTree(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601BB6C RID: 113516 RVA: 0x0026CF69 File Offset: 0x0026B169
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601BB6D RID: 113517
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTree_BuildFromBreadthFirstOrderDescriptor_01(HandleRef pThis, HandleRef descriptor, long numberOfBits, long startIndex);

		/// <summary>
		/// This method builds the indexing of this tree given a breadth first order
		/// descriptor. This descriptor is the same bit array that would be created by
		/// `ComputeBreadthFirstOrderDescriptor`. The current tree is ready to use
		/// after calling this method.
		///
		/// @param descriptor is a binary descriptor, in breadth first order, that describes
		/// the tree topology. If vertex of index `id` in breadth first order has
		/// children, then the corresponding value in `descriptor` is one. Otherwise, it
		/// is set to zero. Remember that arrays are appended, meaning that the index
		/// in `descriptor` corresponding to `id` in the current tree
		/// would be the size of `descriptor`
		/// before calling this method, plus `id`.
		///
		/// @param numberOfBits: Number of bits to be read in the descriptor to build
		/// the tree. Remember that the last depth of the tree is not encoded in the
		/// descriptor, as we know that they are full of zeros (because leaves have no children).
		///
		/// @param startIndex: Input descriptor is being read starting at this index.
		/// </summary>
		// Token: 0x0601BB6E RID: 113518 RVA: 0x0026CF74 File Offset: 0x0026B174
		public virtual void BuildFromBreadthFirstOrderDescriptor(vtkBitArray descriptor, long numberOfBits, long startIndex)
		{
			vtkHyperTree.vtkHyperTree_BuildFromBreadthFirstOrderDescriptor_01(base.GetCppThis(), (descriptor == null) ? default(HandleRef) : descriptor.GetCppThis(), numberOfBits, startIndex);
		}

		// Token: 0x0601BB6F RID: 113519
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTree_ComputeBreadthFirstOrderDescriptor_02(HandleRef pThis, HandleRef inputMask, HandleRef numberOfVerticesPerDepth, HandleRef descriptor, HandleRef breadthFirstIdMap);

		/// <summary>
		/// This method computes the breadth first order descriptor of the current
		/// tree. It takes as input the input mask `inputMask` which should be provided
		/// by the `vtkHyperTreeGrid` in which this `vtkHyperTree` lies. In addition to
		/// computing the descriptor, it computes the mapping between the current
		/// memory layout of this tree with the breadth first order version of it.
		///
		/// Outputs are `numberOfVerticesPerDepth`, `descriptor` and
		/// `breadthFirstIdMap`. Each of those arrays are appended with new data, so
		/// one can create one unique big array for an entire `vtkHyperTreeGrid`
		/// concatenating breadth first order description and mapping of concatenated
		/// trees.
		///
		/// @param inputMask the mask provided by `vtkHyperTreeGrid`.
		///
		/// @param numberOfVerticesPerDepth is self explanatory: from depth 0 to the maximum
		/// depth of the tree, it stores the number of vertices at each depth. If the
		/// input tree has masked subtrees such that getting rid of those subtrees
		/// reduces the depth, then `numberOfVerticesPerDepth` will take this smaller
		/// depth into account rather than adding zeros. In other words,
		/// `numberOfVerticesPerDepth` cannot have zero values.
		///
		/// @param descriptor is a binary descriptor, in breadth first order, that describes
		/// the tree topology. If vertex of index `id` in breadth first order has
		/// children, then the corresponding value in `descriptor` is one. Otherwise, it
		/// is set to zero. Remember that arrays are appended, meaning that the index
		/// in `descriptor` corresponding to `id` in the current tree
		/// would be the size of `descriptor`
		/// before calling this method, plus `id`.
		///
		/// @param breadthFirstIdMap maps breadth first ordering to current indexing of the
		/// current tree. In other word, the value at appended position `id` in this
		/// array gives the corresponding index in the current tree.
		///
		/// @warning Masked subtrees of the input are ignored, so the topology of the
		/// output tree can differ from the input depending on that.
		/// </summary>
		// Token: 0x0601BB70 RID: 113520 RVA: 0x0026CFA8 File Offset: 0x0026B1A8
		public virtual void ComputeBreadthFirstOrderDescriptor(vtkBitArray inputMask, vtkTypeInt64Array numberOfVerticesPerDepth, vtkBitArray descriptor, vtkIdList breadthFirstIdMap)
		{
			vtkHyperTree.vtkHyperTree_ComputeBreadthFirstOrderDescriptor_02(base.GetCppThis(), (inputMask == null) ? default(HandleRef) : inputMask.GetCppThis(), (numberOfVerticesPerDepth == null) ? default(HandleRef) : numberOfVerticesPerDepth.GetCppThis(), (descriptor == null) ? default(HandleRef) : descriptor.GetCppThis(), (breadthFirstIdMap == null) ? default(HandleRef) : breadthFirstIdMap.GetCppThis());
		}

		// Token: 0x0601BB71 RID: 113521
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTree_CopyStructure_03(HandleRef pThis, HandleRef ht);

		/// <summary>
		/// Copy the structure by sharing the decomposition description
		/// of the tree.
		/// \pre ht_exist: ht!=nullptr
		/// </summary>
		// Token: 0x0601BB72 RID: 113522 RVA: 0x0026D018 File Offset: 0x0026B218
		public void CopyStructure(vtkHyperTree ht)
		{
			vtkHyperTree.vtkHyperTree_CopyStructure_03(base.GetCppThis(), (ht == null) ? default(HandleRef) : ht.GetCppThis());
		}

		// Token: 0x0601BB73 RID: 113523
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHyperTree_CreateInstance_04(byte branchFactor, byte dimension, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return an instance of an implementation of a hypertree for
		/// given branch factor and dimension.
		/// Other versions of this code could be made available to meet
		/// other needs without questioning cursors and filters.
		/// Since an instance, an other instance can be creating by call
		/// the method Freeze (by default, nothing more, instance currently
		/// is returning).
		/// </summary>
		// Token: 0x0601BB74 RID: 113524 RVA: 0x0026D048 File Offset: 0x0026B248
		public static vtkHyperTree CreateInstance(byte branchFactor, byte dimension)
		{
			vtkHyperTree result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHyperTree.vtkHyperTree_CreateInstance_04(branchFactor, dimension, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHyperTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601BB75 RID: 113525
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHyperTree_Freeze_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string mode, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return a freeze instance (a priori compact but potentially
		/// unmodifiable).
		/// This method is calling by the Squeeze method of hypertree grid.
		/// The mode parameter will allow to propose different instances.
		/// Today, there is none, the freeze call does not do anything.
		/// </summary>
		// Token: 0x0601BB76 RID: 113526 RVA: 0x0026D0A0 File Offset: 0x0026B2A0
		public virtual vtkHyperTree Freeze(string mode)
		{
			vtkHyperTree vtkHyperTree = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHyperTree.vtkHyperTree_Freeze_05(base.GetCppThis(), mode, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHyperTree = (vtkHyperTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHyperTree.Register(null);
				}
			}
			return vtkHyperTree;
		}

		// Token: 0x0601BB77 RID: 113527
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkHyperTree_GetActualMemorySize_06(HandleRef pThis);

		/// <summary>
		/// Return memory used in kibibytes (1024 bytes).
		/// NB: Ignore the attribute array because its size is added by the data set.
		/// </summary>
		// Token: 0x0601BB78 RID: 113528 RVA: 0x0026D110 File Offset: 0x0026B310
		public uint GetActualMemorySize()
		{
			return vtkHyperTree.vtkHyperTree_GetActualMemorySize_06(base.GetCppThis());
		}

		// Token: 0x0601BB79 RID: 113529
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkHyperTree_GetActualMemorySizeBytes_07(HandleRef pThis);

		/// <summary>
		/// Return memory used in bytes.
		/// NB: Ignore the attribute array because its size is added by the data set.
		/// </summary>
		// Token: 0x0601BB7A RID: 113530 RVA: 0x0026D130 File Offset: 0x0026B330
		public virtual uint GetActualMemorySizeBytes()
		{
			return vtkHyperTree.vtkHyperTree_GetActualMemorySizeBytes_07(base.GetCppThis());
		}

		// Token: 0x0601BB7B RID: 113531
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHyperTree_GetBranchFactor_08(HandleRef pThis);

		/// <summary>
		/// Return the branch factor of the tree.
		/// </summary>
		// Token: 0x0601BB7C RID: 113532 RVA: 0x0026D150 File Offset: 0x0026B350
		public int GetBranchFactor()
		{
			return vtkHyperTree.vtkHyperTree_GetBranchFactor_08(base.GetCppThis());
		}

		// Token: 0x0601BB7D RID: 113533
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHyperTree_GetDimension_09(HandleRef pThis);

		/// <summary>
		/// Return the spatial dimension of the tree.
		/// </summary>
		// Token: 0x0601BB7E RID: 113534 RVA: 0x0026D170 File Offset: 0x0026B370
		public int GetDimension()
		{
			return vtkHyperTree.vtkHyperTree_GetDimension_09(base.GetCppThis());
		}

		// Token: 0x0601BB7F RID: 113535
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHyperTree_GetElderChildIndex_10(HandleRef pThis, uint index_parent);

		/// <summary>
		/// Return the elder child index, local index node of first child, of
		/// node, coarse cell, identified by index_parent.
		/// \pre not_valid_index_parent
		/// Public only for entry: vtkHyperTreeGridEntry,
		/// vtkHyperTreeGridGeometryEntry, vtkHyperTreeGridGeometryLevelEntry
		/// </summary>
		// Token: 0x0601BB80 RID: 113536 RVA: 0x0026D190 File Offset: 0x0026B390
		public virtual long GetElderChildIndex(uint index_parent)
		{
			return vtkHyperTree.vtkHyperTree_GetElderChildIndex_10(base.GetCppThis(), index_parent);
		}

		// Token: 0x0601BB81 RID: 113537
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHyperTree_GetElderChildIndexArray_11(HandleRef pThis, ref ulong nbElements);

		/// <summary>
		/// Return the elder child index array, internals of the tree structure
		/// Should be used with great care, for consulting and not modifying.
		/// </summary>
		// Token: 0x0601BB82 RID: 113538 RVA: 0x0026D1B0 File Offset: 0x0026B3B0
		public virtual IntPtr GetElderChildIndexArray(ref ulong nbElements)
		{
			return vtkHyperTree.vtkHyperTree_GetElderChildIndexArray_11(base.GetCppThis(), ref nbElements);
		}

		// Token: 0x0601BB83 RID: 113539
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHyperTree_GetGlobalIndexFromLocal_12(HandleRef pThis, long index);

		/// <summary>
		/// Get the global id of a local node identified by index.
		/// Use the explicit mapping function if available or the implicit
		/// mapping build with start global index.
		/// \pre not_valid_index
		/// \pre not_positive_start_index (case implicit global index mapping)
		/// \pre not_positive_global_index (case explicit global index mapping)
		/// </summary>
		// Token: 0x0601BB84 RID: 113540 RVA: 0x0026D1D0 File Offset: 0x0026B3D0
		public virtual long GetGlobalIndexFromLocal(long index)
		{
			return vtkHyperTree.vtkHyperTree_GetGlobalIndexFromLocal_12(base.GetCppThis(), index);
		}

		// Token: 0x0601BB85 RID: 113541
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHyperTree_GetGlobalIndexStart_13(HandleRef pThis);

		/// <summary>
		/// Get the start global index for the current tree for implicit global
		/// index mapping.
		/// </summary>
		// Token: 0x0601BB86 RID: 113542 RVA: 0x0026D1F0 File Offset: 0x0026B3F0
		public long GetGlobalIndexStart()
		{
			return vtkHyperTree.vtkHyperTree_GetGlobalIndexStart_13(base.GetCppThis());
		}

		// Token: 0x0601BB87 RID: 113543
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHyperTree_GetGlobalNodeIndexMax_14(HandleRef pThis);

		/// <summary>
		/// Return the maximum value reached by global index mapping
		/// (implicit or explicit).
		/// </summary>
		// Token: 0x0601BB88 RID: 113544 RVA: 0x0026D210 File Offset: 0x0026B410
		public virtual long GetGlobalNodeIndexMax()
		{
			return vtkHyperTree.vtkHyperTree_GetGlobalNodeIndexMax_14(base.GetCppThis());
		}

		// Token: 0x0601BB89 RID: 113545
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHyperTree_GetNumberOfChildren_15(HandleRef pThis);

		/// <summary>
		/// Return the number of children per node of the tree.
		/// This value is branchfactoring scale spatial dimension (f^d).
		/// </summary>
		// Token: 0x0601BB8A RID: 113546 RVA: 0x0026D230 File Offset: 0x0026B430
		public long GetNumberOfChildren()
		{
			return vtkHyperTree.vtkHyperTree_GetNumberOfChildren_15(base.GetCppThis());
		}

		// Token: 0x0601BB8B RID: 113547
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHyperTree_GetNumberOfGenerationsFromBase_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BB8C RID: 113548 RVA: 0x0026D250 File Offset: 0x0026B450
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkHyperTree.vtkHyperTree_GetNumberOfGenerationsFromBase_16(base.GetCppThis(), type);
		}

		// Token: 0x0601BB8D RID: 113549
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHyperTree_GetNumberOfGenerationsFromBaseType_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BB8E RID: 113550 RVA: 0x0026D270 File Offset: 0x0026B470
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkHyperTree.vtkHyperTree_GetNumberOfGenerationsFromBaseType_17(type);
		}

		// Token: 0x0601BB8F RID: 113551
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHyperTree_GetNumberOfLeaves_18(HandleRef pThis);

		/// <summary>
		/// Return the number of leaf (fine) in the tree.
		/// </summary>
		// Token: 0x0601BB90 RID: 113552 RVA: 0x0026D28C File Offset: 0x0026B48C
		public long GetNumberOfLeaves()
		{
			return vtkHyperTree.vtkHyperTree_GetNumberOfLeaves_18(base.GetCppThis());
		}

		// Token: 0x0601BB91 RID: 113553
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkHyperTree_GetNumberOfLevels_19(HandleRef pThis);

		/// <summary>
		/// Return the number of levels.
		/// </summary>
		// Token: 0x0601BB92 RID: 113554 RVA: 0x0026D2AC File Offset: 0x0026B4AC
		public uint GetNumberOfLevels()
		{
			return vtkHyperTree.vtkHyperTree_GetNumberOfLevels_19(base.GetCppThis());
		}

		// Token: 0x0601BB93 RID: 113555
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHyperTree_GetNumberOfNodes_20(HandleRef pThis);

		/// <summary>
		/// Return the number of nodes (coarse) in the tree.
		/// </summary>
		// Token: 0x0601BB94 RID: 113556 RVA: 0x0026D2CC File Offset: 0x0026B4CC
		public long GetNumberOfNodes()
		{
			return vtkHyperTree.vtkHyperTree_GetNumberOfNodes_20(base.GetCppThis());
		}

		// Token: 0x0601BB95 RID: 113557
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHyperTree_GetNumberOfVertices_21(HandleRef pThis);

		/// <summary>
		/// Return the number of all vertices (coarse and fine) in the tree.
		/// </summary>
		// Token: 0x0601BB96 RID: 113558 RVA: 0x0026D2EC File Offset: 0x0026B4EC
		public long GetNumberOfVertices()
		{
			return vtkHyperTree.vtkHyperTree_GetNumberOfVertices_21(base.GetCppThis());
		}

		// Token: 0x0601BB97 RID: 113559
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTree_GetScale_22(HandleRef pThis, IntPtr s);

		/// <summary>
		/// Set/Get scale of the tree in each direction for the ground
		/// level (0).
		/// </summary>
		// Token: 0x0601BB98 RID: 113560 RVA: 0x0026D30B File Offset: 0x0026B50B
		public void GetScale(IntPtr s)
		{
			vtkHyperTree.vtkHyperTree_GetScale_22(base.GetCppThis(), s);
		}

		// Token: 0x0601BB99 RID: 113561
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkHyperTree_GetScale_23(HandleRef pThis, uint d);

		/// <summary>
		/// Set/Get scale of the tree in each direction for the ground
		/// level (0).
		/// </summary>
		// Token: 0x0601BB9A RID: 113562 RVA: 0x0026D31C File Offset: 0x0026B51C
		public double GetScale(uint d)
		{
			return vtkHyperTree.vtkHyperTree_GetScale_23(base.GetCppThis(), d);
		}

		// Token: 0x0601BB9B RID: 113563
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHyperTree_GetTreeIndex_24(HandleRef pThis);

		/// <summary>
		/// Set/Get tree index in hypertree grid.
		/// Services for internal use between hypertree grid and hypertree.
		/// </summary>
		// Token: 0x0601BB9C RID: 113564 RVA: 0x0026D33C File Offset: 0x0026B53C
		public long GetTreeIndex()
		{
			return vtkHyperTree.vtkHyperTree_GetTreeIndex_24(base.GetCppThis());
		}

		// Token: 0x0601BB9D RID: 113565
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHyperTree_HasScales_25(HandleRef pThis);

		/// <summary>
		/// Return the existence scales.
		/// </summary>
		// Token: 0x0601BB9E RID: 113566 RVA: 0x0026D35C File Offset: 0x0026B55C
		public bool HasScales()
		{
			return vtkHyperTree.vtkHyperTree_HasScales_25(base.GetCppThis()) != 0;
		}

		// Token: 0x0601BB9F RID: 113567
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTree_Initialize_26(HandleRef pThis, byte branchFactor, byte dimension, byte numberOfChildren);

		/// <summary>
		/// Restore the initial state: only one vertice is then a leaf:
		/// the root cell for the hypertree.
		/// @param branchFactor
		/// @param dimension
		/// @param numberOfChildren
		/// </summary>
		// Token: 0x0601BBA0 RID: 113568 RVA: 0x0026D382 File Offset: 0x0026B582
		public void Initialize(byte branchFactor, byte dimension, byte numberOfChildren)
		{
			vtkHyperTree.vtkHyperTree_Initialize_26(base.GetCppThis(), branchFactor, dimension, numberOfChildren);
		}

		// Token: 0x0601BBA1 RID: 113569
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTree_InitializeForReader_27(HandleRef pThis, long numberOfLevels, long nbVertices, long nbVerticesOfLastLevel, HandleRef isParent, HandleRef isMasked, HandleRef outIsMasked);

		/// <summary>
		/// Restore a state from read data, without using a cursor
		/// Call after create hypertree with initialize.
		///
		/// @param numberOfLevels: the maximum number of levels.
		/// @param nbVertices: the number of vertices of the future tree
		/// (coarse and leaves), fixed either the information loading
		/// (for load reduction) or defined by the fixed level of reader.
		/// @param nbVerticesOfLastLevel: the number of vertices of last
		/// valid level.
		/// @param isParent: a binary decomposition tree by level with
		/// constraint all describe children. It is useless to declare
		/// all the latest values to False, especially the last level
		/// may not be defined.
		/// @param isMasked: a binary mask corresponding. It is useless
		/// to declare all the latest values to False.
		/// @param outIsMasked: the mask of hypertree grid including
		/// this hypertree which is a vtkBitArray.
		/// </summary>
		// Token: 0x0601BBA2 RID: 113570 RVA: 0x0026D394 File Offset: 0x0026B594
		public virtual void InitializeForReader(long numberOfLevels, long nbVertices, long nbVerticesOfLastLevel, vtkBitArray isParent, vtkBitArray isMasked, vtkBitArray outIsMasked)
		{
			vtkHyperTree.vtkHyperTree_InitializeForReader_27(base.GetCppThis(), numberOfLevels, nbVertices, nbVerticesOfLastLevel, (isParent == null) ? default(HandleRef) : isParent.GetCppThis(), (isMasked == null) ? default(HandleRef) : isMasked.GetCppThis(), (outIsMasked == null) ? default(HandleRef) : outIsMasked.GetCppThis());
		}

		// Token: 0x0601BBA3 RID: 113571
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHyperTree_IsA_28(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BBA4 RID: 113572 RVA: 0x0026D3F8 File Offset: 0x0026B5F8
		public override int IsA(string type)
		{
			return vtkHyperTree.vtkHyperTree_IsA_28(base.GetCppThis(), type);
		}

		// Token: 0x0601BBA5 RID: 113573
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHyperTree_IsGlobalIndexImplicit_29(HandleRef pThis);

		/// <summary>
		/// Return if implicit global index mapping has been used.
		/// If true, the initialize has been done by SetGlobalIndexStart (one call
		/// by hypertree).
		/// If false, the initialize has been done by SetGlobalIndexFromLocal (one
		/// call by cell of hypertree).
		/// GetGlobalIndexFromLocel get the good value of global index mapping for
		/// one cell what ever the initialize metho used.
		/// </summary>
		// Token: 0x0601BBA6 RID: 113574 RVA: 0x0026D418 File Offset: 0x0026B618
		public virtual bool IsGlobalIndexImplicit()
		{
			return vtkHyperTree.vtkHyperTree_IsGlobalIndexImplicit_29(base.GetCppThis()) != 0;
		}

		// Token: 0x0601BBA7 RID: 113575
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHyperTree_IsLeaf_30(HandleRef pThis, long index);

		/// <summary>
		/// Return if a vertice identified by index in tree as being leaf.
		/// \pre not_valid_index
		/// </summary>
		// Token: 0x0601BBA8 RID: 113576 RVA: 0x0026D440 File Offset: 0x0026B640
		public virtual bool IsLeaf(long index)
		{
			return vtkHyperTree.vtkHyperTree_IsLeaf_30(base.GetCppThis(), index) != 0;
		}

		// Token: 0x0601BBA9 RID: 113577
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHyperTree_IsTerminalNode_31(HandleRef pThis, long index);

		/// <summary>
		/// Return if a vertice identified by index in tree as a terminal node.
		/// For this, all children must be all leaves.
		/// \pre not_valid_index
		/// \pre not_valid_child_index
		/// </summary>
		// Token: 0x0601BBAA RID: 113578 RVA: 0x0026D468 File Offset: 0x0026B668
		public virtual bool IsTerminalNode(long index)
		{
			return vtkHyperTree.vtkHyperTree_IsTerminalNode_31(base.GetCppThis(), index) != 0;
		}

		// Token: 0x0601BBAB RID: 113579
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHyperTree_IsTypeOf_32([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BBAC RID: 113580 RVA: 0x0026D490 File Offset: 0x0026B690
		public new static int IsTypeOf(string type)
		{
			return vtkHyperTree.vtkHyperTree_IsTypeOf_32(type);
		}

		// Token: 0x0601BBAD RID: 113581
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHyperTree_NewInstance_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BBAE RID: 113582 RVA: 0x0026D4AC File Offset: 0x0026B6AC
		public new vtkHyperTree NewInstance()
		{
			vtkHyperTree result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHyperTree.vtkHyperTree_NewInstance_33(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHyperTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601BBAF RID: 113583
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHyperTree_SafeDownCast_34(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BBB0 RID: 113584 RVA: 0x0026D508 File Offset: 0x0026B708
		public new static vtkHyperTree SafeDownCast(vtkObjectBase o)
		{
			vtkHyperTree vtkHyperTree = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHyperTree.vtkHyperTree_SafeDownCast_34((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHyperTree = (vtkHyperTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHyperTree.Register(null);
				}
			}
			return vtkHyperTree;
		}

		// Token: 0x0601BBB1 RID: 113585
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTree_SetGlobalIndexFromLocal_35(HandleRef pThis, long index, long global);

		/// <summary>
		/// Set the mapping between a node index in tree and a explicit global
		/// index mapping.
		/// This global index mapping permits to access a value of
		/// field for a cell, in explicit, the index depend of order values.
		/// For this tree, in debug, assert is calling if tried call
		/// SetGlobalIndexStart.
		/// \pre not_global_index_from_local_if_use_global_index_start
		/// </summary>
		// Token: 0x0601BBB2 RID: 113586 RVA: 0x0026D587 File Offset: 0x0026B787
		public virtual void SetGlobalIndexFromLocal(long index, long global)
		{
			vtkHyperTree.vtkHyperTree_SetGlobalIndexFromLocal_35(base.GetCppThis(), index, global);
		}

		// Token: 0x0601BBB3 RID: 113587
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTree_SetGlobalIndexStart_36(HandleRef pThis, long start);

		/// <summary>
		/// Set the start implicit global index mapping for the first cell in the
		/// current tree.
		/// The implicit global index mapping of a node will be computed by
		/// this start index + the node index (local offset in tree).
		/// The node index begin by 0, the origin cell in tree. The follow values
		/// are organizing by fatrie as i to i+NumberOfChildren, for all children
		/// of one coarse cell, i is 1+8*s with s in integer. The order of fatrie
		/// depend of order to call SubdivideLeaf.
		/// This global index mapping permits to access a value of
		/// field for a cell, in implicit, the order values depends of implicit
		/// order linking with the order build of this tree.
		/// WARNING: See of hypertree grid, for to use a implicit global index
		/// mapping, you have to build hypertree by hypertree without to recome
		/// in hypertree also build.
		/// For this tree, in debug, assert is calling if tried call
		/// SetGlobalIndexFromLocal.
		/// \pre not_global_index_start_if_use_global_index_from_local
		/// </summary>
		// Token: 0x0601BBB4 RID: 113588 RVA: 0x0026D598 File Offset: 0x0026B798
		public virtual void SetGlobalIndexStart(long start)
		{
			vtkHyperTree.vtkHyperTree_SetGlobalIndexStart_36(base.GetCppThis(), start);
		}

		// Token: 0x0601BBB5 RID: 113589
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTree_SetTreeIndex_37(HandleRef pThis, long treeIndex);

		/// <summary>
		/// Set/Get tree index in hypertree grid.
		/// Services for internal use between hypertree grid and hypertree.
		/// </summary>
		// Token: 0x0601BBB6 RID: 113590 RVA: 0x0026D5A8 File Offset: 0x0026B7A8
		public void SetTreeIndex(long treeIndex)
		{
			vtkHyperTree.vtkHyperTree_SetTreeIndex_37(base.GetCppThis(), treeIndex);
		}

		// Token: 0x0601BBB7 RID: 113591
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTree_SubdivideLeaf_38(HandleRef pThis, long index, uint level);

		/// <summary>
		/// Subdivide a vertice, only if its a leaf.
		/// \pre not_valide_index
		/// \pre not_leaf
		/// </summary>
		// Token: 0x0601BBB8 RID: 113592 RVA: 0x0026D5B8 File Offset: 0x0026B7B8
		public virtual void SubdivideLeaf(long index, uint level)
		{
			vtkHyperTree.vtkHyperTree_SubdivideLeaf_38(base.GetCppThis(), index, level);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DAE RID: 7598
		public new const string MRFullTypeName = "Kitware.VTK.vtkHyperTree";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DAF RID: 7599
		public new static readonly string MRClassNameKey = "class vtkHyperTree";
	}
}
