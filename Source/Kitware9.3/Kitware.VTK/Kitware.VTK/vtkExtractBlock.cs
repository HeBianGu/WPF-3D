using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkExtractBlock
	/// </summary>
	/// <remarks>
	///  extracts blocks from a vtkDataObjectTree subclass.
	///
	/// vtkExtractBlock is a filter that extracts blocks from a vtkDataObjectTree
	/// subclass such as vtkPartitionedDataSet, vtkPartitionedDataSetCollection, etc.
	/// using their composite-ids (also called flat-index).
	///
	/// The composite-id can be obtained by performing a pre-order traversal of the
	/// tree (including empty nodes). For example, consider a tree with nodes named
	/// `A(B (D, E), C(F, G))`.  Pre-order traversal yields: `A, B, D, E, C, F, G`;
	/// hence, composite-id of `A` is `0`, while index of `C` is `4`.
	///
	/// `0` identifies the root-node. Thus, choosing `0` will result in the entire
	/// input dataset being passed to the output.
	/// </remarks>
	// Token: 0x020006A6 RID: 1702
	public class vtkExtractBlock : vtkPassInputTypeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601235C RID: 74588 RVA: 0x0019838B File Offset: 0x0019658B
		static vtkExtractBlock()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractBlock.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractBlock"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601235D RID: 74589 RVA: 0x001983B3 File Offset: 0x001965B3
		public vtkExtractBlock(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601235E RID: 74590
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractBlock_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601235F RID: 74591 RVA: 0x001983C4 File Offset: 0x001965C4
		public new static vtkExtractBlock New()
		{
			vtkExtractBlock result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractBlock.vtkExtractBlock_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractBlock)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06012360 RID: 74592 RVA: 0x00198418 File Offset: 0x00196618
		public vtkExtractBlock() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExtractBlock.vtkExtractBlock_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012361 RID: 74593 RVA: 0x0019845C File Offset: 0x0019665C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012362 RID: 74594
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractBlock_AddIndex_01(HandleRef pThis, uint index);

		/// <summary>
		/// Select the block indices to extract.  Each node in the multi-block tree
		/// is identified by an \c index. The index can be obtained by performing a
		/// preorder traversal of the tree (including empty nodes). eg. A(B (D, E),
		/// C(F, G)).  Inorder traversal yields: A, B, D, E, C, F, G Index of A is
		/// 0, while index of C is 4. (Note: specifying node 0 means the input is
		/// copied to the output.)
		/// </summary>
		// Token: 0x06012363 RID: 74595 RVA: 0x00198467 File Offset: 0x00196667
		public void AddIndex(uint index)
		{
			vtkExtractBlock.vtkExtractBlock_AddIndex_01(base.GetCppThis(), index);
		}

		// Token: 0x06012364 RID: 74596
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractBlock_GetMaintainStructure_02(HandleRef pThis);

		/// <summary>
		/// This is used only when PruneOutput is ON. By default, when pruning the
		/// output i.e. remove empty blocks, if node has only 1 non-null child block,
		/// then that node is removed. To preserve these parent nodes, set this flag to
		/// true. Off by default.
		///
		/// This has no effect for vtkPartitionedDataSetCollection.
		/// </summary>
		// Token: 0x06012365 RID: 74597 RVA: 0x00198478 File Offset: 0x00196678
		public virtual int GetMaintainStructure()
		{
			return vtkExtractBlock.vtkExtractBlock_GetMaintainStructure_02(base.GetCppThis());
		}

		// Token: 0x06012366 RID: 74598
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractBlock_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06012367 RID: 74599 RVA: 0x00198498 File Offset: 0x00196698
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExtractBlock.vtkExtractBlock_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06012368 RID: 74600
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractBlock_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06012369 RID: 74601 RVA: 0x001984B8 File Offset: 0x001966B8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExtractBlock.vtkExtractBlock_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0601236A RID: 74602
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractBlock_GetPruneOutput_05(HandleRef pThis);

		/// <summary>
		/// When set, the output multiblock dataset will be pruned to remove empty
		/// nodes. On by default.
		///
		/// This has no effect for vtkPartitionedDataSetCollection.
		/// </summary>
		// Token: 0x0601236B RID: 74603 RVA: 0x001984D4 File Offset: 0x001966D4
		public virtual int GetPruneOutput()
		{
			return vtkExtractBlock.vtkExtractBlock_GetPruneOutput_05(base.GetCppThis());
		}

		// Token: 0x0601236C RID: 74604
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractBlock_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601236D RID: 74605 RVA: 0x001984F4 File Offset: 0x001966F4
		public override int IsA(string type)
		{
			return vtkExtractBlock.vtkExtractBlock_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0601236E RID: 74606
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractBlock_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601236F RID: 74607 RVA: 0x00198514 File Offset: 0x00196714
		public new static int IsTypeOf(string type)
		{
			return vtkExtractBlock.vtkExtractBlock_IsTypeOf_07(type);
		}

		// Token: 0x06012370 RID: 74608
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractBlock_MaintainStructureOff_08(HandleRef pThis);

		/// <summary>
		/// This is used only when PruneOutput is ON. By default, when pruning the
		/// output i.e. remove empty blocks, if node has only 1 non-null child block,
		/// then that node is removed. To preserve these parent nodes, set this flag to
		/// true. Off by default.
		///
		/// This has no effect for vtkPartitionedDataSetCollection.
		/// </summary>
		// Token: 0x06012371 RID: 74609 RVA: 0x0019852E File Offset: 0x0019672E
		public virtual void MaintainStructureOff()
		{
			vtkExtractBlock.vtkExtractBlock_MaintainStructureOff_08(base.GetCppThis());
		}

		// Token: 0x06012372 RID: 74610
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractBlock_MaintainStructureOn_09(HandleRef pThis);

		/// <summary>
		/// This is used only when PruneOutput is ON. By default, when pruning the
		/// output i.e. remove empty blocks, if node has only 1 non-null child block,
		/// then that node is removed. To preserve these parent nodes, set this flag to
		/// true. Off by default.
		///
		/// This has no effect for vtkPartitionedDataSetCollection.
		/// </summary>
		// Token: 0x06012373 RID: 74611 RVA: 0x0019853D File Offset: 0x0019673D
		public virtual void MaintainStructureOn()
		{
			vtkExtractBlock.vtkExtractBlock_MaintainStructureOn_09(base.GetCppThis());
		}

		// Token: 0x06012374 RID: 74612
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractBlock_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06012375 RID: 74613 RVA: 0x0019854C File Offset: 0x0019674C
		public new vtkExtractBlock NewInstance()
		{
			vtkExtractBlock result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractBlock.vtkExtractBlock_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractBlock)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012376 RID: 74614
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractBlock_PruneOutputOff_12(HandleRef pThis);

		/// <summary>
		/// When set, the output multiblock dataset will be pruned to remove empty
		/// nodes. On by default.
		///
		/// This has no effect for vtkPartitionedDataSetCollection.
		/// </summary>
		// Token: 0x06012377 RID: 74615 RVA: 0x001985A6 File Offset: 0x001967A6
		public virtual void PruneOutputOff()
		{
			vtkExtractBlock.vtkExtractBlock_PruneOutputOff_12(base.GetCppThis());
		}

		// Token: 0x06012378 RID: 74616
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractBlock_PruneOutputOn_13(HandleRef pThis);

		/// <summary>
		/// When set, the output multiblock dataset will be pruned to remove empty
		/// nodes. On by default.
		///
		/// This has no effect for vtkPartitionedDataSetCollection.
		/// </summary>
		// Token: 0x06012379 RID: 74617 RVA: 0x001985B5 File Offset: 0x001967B5
		public virtual void PruneOutputOn()
		{
			vtkExtractBlock.vtkExtractBlock_PruneOutputOn_13(base.GetCppThis());
		}

		// Token: 0x0601237A RID: 74618
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractBlock_RemoveAllIndices_14(HandleRef pThis);

		/// <summary>
		/// Select the block indices to extract.  Each node in the multi-block tree
		/// is identified by an \c index. The index can be obtained by performing a
		/// preorder traversal of the tree (including empty nodes). eg. A(B (D, E),
		/// C(F, G)).  Inorder traversal yields: A, B, D, E, C, F, G Index of A is
		/// 0, while index of C is 4. (Note: specifying node 0 means the input is
		/// copied to the output.)
		/// </summary>
		// Token: 0x0601237B RID: 74619 RVA: 0x001985C4 File Offset: 0x001967C4
		public void RemoveAllIndices()
		{
			vtkExtractBlock.vtkExtractBlock_RemoveAllIndices_14(base.GetCppThis());
		}

		// Token: 0x0601237C RID: 74620
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractBlock_RemoveIndex_15(HandleRef pThis, uint index);

		/// <summary>
		/// Select the block indices to extract.  Each node in the multi-block tree
		/// is identified by an \c index. The index can be obtained by performing a
		/// preorder traversal of the tree (including empty nodes). eg. A(B (D, E),
		/// C(F, G)).  Inorder traversal yields: A, B, D, E, C, F, G Index of A is
		/// 0, while index of C is 4. (Note: specifying node 0 means the input is
		/// copied to the output.)
		/// </summary>
		// Token: 0x0601237D RID: 74621 RVA: 0x001985D3 File Offset: 0x001967D3
		public void RemoveIndex(uint index)
		{
			vtkExtractBlock.vtkExtractBlock_RemoveIndex_15(base.GetCppThis(), index);
		}

		// Token: 0x0601237E RID: 74622
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractBlock_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601237F RID: 74623 RVA: 0x001985E4 File Offset: 0x001967E4
		public new static vtkExtractBlock SafeDownCast(vtkObjectBase o)
		{
			vtkExtractBlock vtkExtractBlock = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractBlock.vtkExtractBlock_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractBlock = (vtkExtractBlock)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractBlock.Register(null);
				}
			}
			return vtkExtractBlock;
		}

		// Token: 0x06012380 RID: 74624
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractBlock_SetMaintainStructure_17(HandleRef pThis, int _arg);

		/// <summary>
		/// This is used only when PruneOutput is ON. By default, when pruning the
		/// output i.e. remove empty blocks, if node has only 1 non-null child block,
		/// then that node is removed. To preserve these parent nodes, set this flag to
		/// true. Off by default.
		///
		/// This has no effect for vtkPartitionedDataSetCollection.
		/// </summary>
		// Token: 0x06012381 RID: 74625 RVA: 0x00198663 File Offset: 0x00196863
		public virtual void SetMaintainStructure(int _arg)
		{
			vtkExtractBlock.vtkExtractBlock_SetMaintainStructure_17(base.GetCppThis(), _arg);
		}

		// Token: 0x06012382 RID: 74626
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractBlock_SetPruneOutput_18(HandleRef pThis, int _arg);

		/// <summary>
		/// When set, the output multiblock dataset will be pruned to remove empty
		/// nodes. On by default.
		///
		/// This has no effect for vtkPartitionedDataSetCollection.
		/// </summary>
		// Token: 0x06012383 RID: 74627 RVA: 0x00198673 File Offset: 0x00196873
		public virtual void SetPruneOutput(int _arg)
		{
			vtkExtractBlock.vtkExtractBlock_SetPruneOutput_18(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014FA RID: 5370
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractBlock";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014FB RID: 5371
		public new static readonly string MRClassNameKey = "class vtkExtractBlock";
	}
}
