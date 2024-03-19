using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAMRInformation
	/// </summary>
	/// <remarks>
	///    Meta data that describes the structure of an AMR data set
	///
	///
	/// vtkAMRInformation encapsulates the following meta information for an AMR data set
	/// - a list of vtkAMRBox objects
	/// - Refinement ratio between AMR levels
	/// - Grid spacing for each level
	/// - The file block index for each block
	/// - parent child information, if requested
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkOverlappingAMR, vtkAMRBox
	/// </seealso>
	// Token: 0x02000AE5 RID: 2789
	public class vtkAMRInformation : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D730 RID: 120624 RVA: 0x002996EA File Offset: 0x002978EA
		static vtkAMRInformation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAMRInformation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAMRInformation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D731 RID: 120625 RVA: 0x00299712 File Offset: 0x00297912
		public vtkAMRInformation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601D732 RID: 120626
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRInformation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D733 RID: 120627 RVA: 0x00299720 File Offset: 0x00297920
		public new static vtkAMRInformation New()
		{
			vtkAMRInformation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMRInformation.vtkAMRInformation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAMRInformation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D734 RID: 120628 RVA: 0x00299774 File Offset: 0x00297974
		public vtkAMRInformation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAMRInformation.vtkAMRInformation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D735 RID: 120629 RVA: 0x002997B8 File Offset: 0x002979B8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D736 RID: 120630
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAMRInformation_Audit_01(HandleRef pThis);

		/// <summary>
		/// Checks whether the meta data is internally consistent.
		/// </summary>
		// Token: 0x0601D737 RID: 120631 RVA: 0x002997C4 File Offset: 0x002979C4
		public bool Audit()
		{
			return vtkAMRInformation.vtkAMRInformation_Audit_01(base.GetCppThis()) != 0;
		}

		// Token: 0x0601D738 RID: 120632
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRInformation_ComputeIndexPair_02(HandleRef pThis, uint index, ref uint level, ref uint id);

		/// <summary>
		/// Returns the an index pair given a single index
		/// </summary>
		// Token: 0x0601D739 RID: 120633 RVA: 0x002997EA File Offset: 0x002979EA
		public void ComputeIndexPair(uint index, ref uint level, ref uint id)
		{
			vtkAMRInformation.vtkAMRInformation_ComputeIndexPair_02(base.GetCppThis(), index, ref level, ref id);
		}

		// Token: 0x0601D73A RID: 120634
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRInformation_DeepCopy_03(HandleRef pThis, HandleRef other);

		/// <summary>
		/// Returns internal arrays.
		/// </summary>
		// Token: 0x0601D73B RID: 120635 RVA: 0x002997FC File Offset: 0x002979FC
		public void DeepCopy(vtkAMRInformation other)
		{
			vtkAMRInformation.vtkAMRInformation_DeepCopy_03(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis());
		}

		// Token: 0x0601D73C RID: 120636
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAMRInformation_FindCell_04(HandleRef pThis, IntPtr q, uint level, uint index, ref int cellIdx);

		/// <summary>
		/// Given a point q, find whether q is bounded by the data set at
		/// (level,index).  If it is, set cellIdx to the cell index and return
		/// true; otherwise return false
		/// </summary>
		// Token: 0x0601D73D RID: 120637 RVA: 0x0029982C File Offset: 0x00297A2C
		public bool FindCell(IntPtr q, uint level, uint index, ref int cellIdx)
		{
			return vtkAMRInformation.vtkAMRInformation_FindCell_04(base.GetCppThis(), q, level, index, ref cellIdx) != 0;
		}

		// Token: 0x0601D73E RID: 120638
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAMRInformation_FindGrid_05(HandleRef pThis, IntPtr q, int level, ref uint gridId);

		/// <summary>
		/// find the grid that contains the point q at the specified level
		/// </summary>
		// Token: 0x0601D73F RID: 120639 RVA: 0x00299858 File Offset: 0x00297A58
		public bool FindGrid(IntPtr q, int level, ref uint gridId)
		{
			return vtkAMRInformation.vtkAMRInformation_FindGrid_05(base.GetCppThis(), q, level, ref gridId) != 0;
		}

		// Token: 0x0601D740 RID: 120640
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAMRInformation_FindGrid_06(HandleRef pThis, IntPtr q, ref uint level, ref uint gridId);

		/// <summary>
		/// Given a point q, find the highest level grid that contains it.
		/// </summary>
		// Token: 0x0601D741 RID: 120641 RVA: 0x00299884 File Offset: 0x00297A84
		public bool FindGrid(IntPtr q, ref uint level, ref uint gridId)
		{
			return vtkAMRInformation.vtkAMRInformation_FindGrid_06(base.GetCppThis(), q, ref level, ref gridId) != 0;
		}

		// Token: 0x0601D742 RID: 120642
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRInformation_GenerateParentChildInformation_07(HandleRef pThis);

		/// <summary>
		/// Generate the parent/child relationships - needed to be called
		/// before GetParents or GetChildren can be used!
		/// </summary>
		// Token: 0x0601D743 RID: 120643 RVA: 0x002998AD File Offset: 0x00297AAD
		public void GenerateParentChildInformation()
		{
			vtkAMRInformation.vtkAMRInformation_GenerateParentChildInformation_07(base.GetCppThis());
		}

		// Token: 0x0601D744 RID: 120644
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRInformation_GenerateRefinementRatio_08(HandleRef pThis);

		/// <summary>
		/// This method computes the refinement ratio at each level.
		/// At each level, l, the refinement ratio r_l is computed by
		/// r_l = D_{l} / D_{l+1}, where D_{l+1} and D_{l} are the grid
		/// spacings at the next and current level respectively.
		///
		/// .SECTION Assumptions
		/// 1) Within each level, the refinement ratios are the same for all blocks.
		/// 2) The refinement ratio is uniform along each dimension of the block.
		/// </summary>
		// Token: 0x0601D745 RID: 120645 RVA: 0x002998BC File Offset: 0x00297ABC
		public void GenerateRefinementRatio()
		{
			vtkAMRInformation.vtkAMRInformation_GenerateRefinementRatio_08(base.GetCppThis());
		}

		// Token: 0x0601D746 RID: 120646
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRInformation_GetAMRBlockSourceIndex_09(HandleRef pThis, int index);

		/// <summary>
		/// Get/Set the SourceIndex of a block. Typically, this is a file-type specific index
		/// that can be used by a reader to load a particular file block
		/// </summary>
		// Token: 0x0601D747 RID: 120647 RVA: 0x002998CC File Offset: 0x00297ACC
		public int GetAMRBlockSourceIndex(int index)
		{
			return vtkAMRInformation.vtkAMRInformation_GetAMRBlockSourceIndex_09(base.GetCppThis(), index);
		}

		// Token: 0x0601D748 RID: 120648
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRInformation_GetBounds_10(HandleRef pThis);

		/// <summary>
		/// Returns the bounds of the entire domain
		/// </summary>
		// Token: 0x0601D749 RID: 120649 RVA: 0x002998EC File Offset: 0x00297AEC
		public IntPtr GetBounds()
		{
			return vtkAMRInformation.vtkAMRInformation_GetBounds_10(base.GetCppThis());
		}

		// Token: 0x0601D74A RID: 120650
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRInformation_GetBounds_11(HandleRef pThis, uint level, uint id, IntPtr bb);

		/// <summary>
		/// Returns the bounding box of a given box
		/// </summary>
		// Token: 0x0601D74B RID: 120651 RVA: 0x0029990B File Offset: 0x00297B0B
		public void GetBounds(uint level, uint id, IntPtr bb)
		{
			vtkAMRInformation.vtkAMRInformation_GetBounds_11(base.GetCppThis(), level, id, bb);
		}

		// Token: 0x0601D74C RID: 120652
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRInformation_GetChildren_12(HandleRef pThis, uint level, uint index, ref uint numChildren);

		/// <summary>
		/// Return a pointer to Children of a block.  The first entry is the number
		/// of children the block has followed by its children ids in level+1.
		/// If none exits it returns nullptr.
		/// </summary>
		// Token: 0x0601D74D RID: 120653 RVA: 0x00299920 File Offset: 0x00297B20
		public IntPtr GetChildren(uint level, uint index, ref uint numChildren)
		{
			return vtkAMRInformation.vtkAMRInformation_GetChildren_12(base.GetCppThis(), level, index, ref numChildren);
		}

		// Token: 0x0601D74E RID: 120654
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRInformation_GetGridDescription_13(HandleRef pThis);

		/// <summary>
		/// returns the value of vtkUniformGrid::GridDescription() of any block
		/// </summary>
		// Token: 0x0601D74F RID: 120655 RVA: 0x00299944 File Offset: 0x00297B44
		public virtual int GetGridDescription()
		{
			return vtkAMRInformation.vtkAMRInformation_GetGridDescription_13(base.GetCppThis());
		}

		// Token: 0x0601D750 RID: 120656
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRInformation_GetIndex_14(HandleRef pThis, uint level, uint id);

		/// <summary>
		/// Returns the single index from a pair of indices
		/// </summary>
		// Token: 0x0601D751 RID: 120657 RVA: 0x00299964 File Offset: 0x00297B64
		public int GetIndex(uint level, uint id)
		{
			return vtkAMRInformation.vtkAMRInformation_GetIndex_14(base.GetCppThis(), level, id);
		}

		// Token: 0x0601D752 RID: 120658
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkAMRInformation_GetNumberOfDataSets_15(HandleRef pThis, uint level);

		/// <summary>
		/// Returns the number of datasets at the given levelx
		/// </summary>
		// Token: 0x0601D753 RID: 120659 RVA: 0x00299988 File Offset: 0x00297B88
		public uint GetNumberOfDataSets(uint level)
		{
			return vtkAMRInformation.vtkAMRInformation_GetNumberOfDataSets_15(base.GetCppThis(), level);
		}

		// Token: 0x0601D754 RID: 120660
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAMRInformation_GetNumberOfGenerationsFromBase_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D755 RID: 120661 RVA: 0x002999A8 File Offset: 0x00297BA8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAMRInformation.vtkAMRInformation_GetNumberOfGenerationsFromBase_16(base.GetCppThis(), type);
		}

		// Token: 0x0601D756 RID: 120662
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAMRInformation_GetNumberOfGenerationsFromBaseType_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D757 RID: 120663 RVA: 0x002999C8 File Offset: 0x00297BC8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAMRInformation.vtkAMRInformation_GetNumberOfGenerationsFromBaseType_17(type);
		}

		// Token: 0x0601D758 RID: 120664
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkAMRInformation_GetNumberOfLevels_18(HandleRef pThis);

		/// <summary>
		/// Return the number of levels
		/// </summary>
		// Token: 0x0601D759 RID: 120665 RVA: 0x002999E4 File Offset: 0x00297BE4
		public uint GetNumberOfLevels()
		{
			return vtkAMRInformation.vtkAMRInformation_GetNumberOfLevels_18(base.GetCppThis());
		}

		// Token: 0x0601D75A RID: 120666
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRInformation_GetOrigin_19(HandleRef pThis, IntPtr origin);

		/// <summary>
		/// Get the AMR dataset origin
		/// The origin is essentially the minimum of all the grids.
		/// </summary>
		// Token: 0x0601D75B RID: 120667 RVA: 0x00299A03 File Offset: 0x00297C03
		public void GetOrigin(IntPtr origin)
		{
			vtkAMRInformation.vtkAMRInformation_GetOrigin_19(base.GetCppThis(), origin);
		}

		// Token: 0x0601D75C RID: 120668
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRInformation_GetOrigin_20(HandleRef pThis);

		/// <summary>
		/// Get the AMR dataset origin
		/// The origin is essentially the minimum of all the grids.
		/// </summary>
		// Token: 0x0601D75D RID: 120669 RVA: 0x00299A14 File Offset: 0x00297C14
		public IntPtr GetOrigin()
		{
			return vtkAMRInformation.vtkAMRInformation_GetOrigin_20(base.GetCppThis());
		}

		// Token: 0x0601D75E RID: 120670
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAMRInformation_GetOrigin_21(HandleRef pThis, uint level, uint id, IntPtr origin);

		/// <summary>
		/// Returns the origin of the grid at (level,id)
		/// </summary>
		// Token: 0x0601D75F RID: 120671 RVA: 0x00299A34 File Offset: 0x00297C34
		public bool GetOrigin(uint level, uint id, IntPtr origin)
		{
			return vtkAMRInformation.vtkAMRInformation_GetOrigin_21(base.GetCppThis(), level, id, origin) != 0;
		}

		// Token: 0x0601D760 RID: 120672
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRInformation_GetParents_22(HandleRef pThis, uint level, uint index, ref uint numParents);

		/// <summary>
		/// Return a pointer to Parents of a block.  The first entry is the number
		/// of parents the block has followed by its parent ids in level-1.
		/// If none exits it returns nullptr.
		/// </summary>
		// Token: 0x0601D761 RID: 120673 RVA: 0x00299A60 File Offset: 0x00297C60
		public IntPtr GetParents(uint level, uint index, ref uint numParents)
		{
			return vtkAMRInformation.vtkAMRInformation_GetParents_22(base.GetCppThis(), level, index, ref numParents);
		}

		// Token: 0x0601D762 RID: 120674
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRInformation_GetRefinementRatio_23(HandleRef pThis, uint level);

		/// <summary>
		/// Returns the refinement of a given level.
		/// </summary>
		// Token: 0x0601D763 RID: 120675 RVA: 0x00299A84 File Offset: 0x00297C84
		public int GetRefinementRatio(uint level)
		{
			return vtkAMRInformation.vtkAMRInformation_GetRefinementRatio_23(base.GetCppThis(), level);
		}

		// Token: 0x0601D764 RID: 120676
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRInformation_GetSpacing_24(HandleRef pThis, uint level, IntPtr spacing);

		/// <summary>
		/// Return the spacing at the given fiven
		/// </summary>
		// Token: 0x0601D765 RID: 120677 RVA: 0x00299AA4 File Offset: 0x00297CA4
		public void GetSpacing(uint level, IntPtr spacing)
		{
			vtkAMRInformation.vtkAMRInformation_GetSpacing_24(base.GetCppThis(), level, spacing);
		}

		// Token: 0x0601D766 RID: 120678
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkAMRInformation_GetTotalNumberOfBlocks_25(HandleRef pThis);

		/// <summary>
		/// Returns total number of datasets
		/// </summary>
		// Token: 0x0601D767 RID: 120679 RVA: 0x00299AB8 File Offset: 0x00297CB8
		public uint GetTotalNumberOfBlocks()
		{
			return vtkAMRInformation.vtkAMRInformation_GetTotalNumberOfBlocks_25(base.GetCppThis());
		}

		// Token: 0x0601D768 RID: 120680
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAMRInformation_HasChildrenInformation_26(HandleRef pThis);

		/// <summary>
		/// Return whether parent child information has been generated
		/// </summary>
		// Token: 0x0601D769 RID: 120681 RVA: 0x00299AD8 File Offset: 0x00297CD8
		public bool HasChildrenInformation()
		{
			return vtkAMRInformation.vtkAMRInformation_HasChildrenInformation_26(base.GetCppThis()) != 0;
		}

		// Token: 0x0601D76A RID: 120682
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAMRInformation_HasRefinementRatio_27(HandleRef pThis);

		/// <summary>
		/// Returns whether refinement ratio has been set (either by calling
		/// GenerateRefinementRatio() or by calling SetRefinementRatio()
		/// </summary>
		// Token: 0x0601D76B RID: 120683 RVA: 0x00299B00 File Offset: 0x00297D00
		public bool HasRefinementRatio()
		{
			return vtkAMRInformation.vtkAMRInformation_HasRefinementRatio_27(base.GetCppThis()) != 0;
		}

		// Token: 0x0601D76C RID: 120684
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAMRInformation_HasSpacing_28(HandleRef pThis, uint level);

		/// <summary>
		/// Return the spacing at the given fiven
		/// </summary>
		// Token: 0x0601D76D RID: 120685 RVA: 0x00299B28 File Offset: 0x00297D28
		public bool HasSpacing(uint level)
		{
			return vtkAMRInformation.vtkAMRInformation_HasSpacing_28(base.GetCppThis(), level) != 0;
		}

		// Token: 0x0601D76E RID: 120686
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRInformation_Initialize_29(HandleRef pThis, int numLevels, IntPtr blocksPerLevel);

		/// <summary>
		/// Initialize the meta information
		/// numLevels is the number of levels
		/// blocksPerLevel[i] is the number of blocks at level i
		/// </summary>
		// Token: 0x0601D76F RID: 120687 RVA: 0x00299B4F File Offset: 0x00297D4F
		public void Initialize(int numLevels, IntPtr blocksPerLevel)
		{
			vtkAMRInformation.vtkAMRInformation_Initialize_29(base.GetCppThis(), numLevels, blocksPerLevel);
		}

		// Token: 0x0601D770 RID: 120688
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRInformation_IsA_30(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D771 RID: 120689 RVA: 0x00299B60 File Offset: 0x00297D60
		public override int IsA(string type)
		{
			return vtkAMRInformation.vtkAMRInformation_IsA_30(base.GetCppThis(), type);
		}

		// Token: 0x0601D772 RID: 120690
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRInformation_IsTypeOf_31([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D773 RID: 120691 RVA: 0x00299B80 File Offset: 0x00297D80
		public new static int IsTypeOf(string type)
		{
			return vtkAMRInformation.vtkAMRInformation_IsTypeOf_31(type);
		}

		// Token: 0x0601D774 RID: 120692
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRInformation_NewInstance_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D775 RID: 120693 RVA: 0x00299B9C File Offset: 0x00297D9C
		public new vtkAMRInformation NewInstance()
		{
			vtkAMRInformation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMRInformation.vtkAMRInformation_NewInstance_33(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAMRInformation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601D776 RID: 120694
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRInformation_PrintParentChildInfo_34(HandleRef pThis, uint level, uint index);

		/// <summary>
		/// Prints the parents and children of a requested block (Debug Routine)
		/// </summary>
		// Token: 0x0601D777 RID: 120695 RVA: 0x00299BF6 File Offset: 0x00297DF6
		public void PrintParentChildInfo(uint level, uint index)
		{
			vtkAMRInformation.vtkAMRInformation_PrintParentChildInfo_34(base.GetCppThis(), level, index);
		}

		// Token: 0x0601D778 RID: 120696
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRInformation_SafeDownCast_35(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D779 RID: 120697 RVA: 0x00299C08 File Offset: 0x00297E08
		public new static vtkAMRInformation SafeDownCast(vtkObjectBase o)
		{
			vtkAMRInformation vtkAMRInformation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMRInformation.vtkAMRInformation_SafeDownCast_35((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAMRInformation = (vtkAMRInformation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAMRInformation.Register(null);
				}
			}
			return vtkAMRInformation;
		}

		// Token: 0x0601D77A RID: 120698
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRInformation_SetAMRBlockSourceIndex_36(HandleRef pThis, int index, int sourceId);

		/// <summary>
		/// Get/Set the SourceIndex of a block. Typically, this is a file-type specific index
		/// that can be used by a reader to load a particular file block
		/// </summary>
		// Token: 0x0601D77B RID: 120699 RVA: 0x00299C87 File Offset: 0x00297E87
		public void SetAMRBlockSourceIndex(int index, int sourceId)
		{
			vtkAMRInformation.vtkAMRInformation_SetAMRBlockSourceIndex_36(base.GetCppThis(), index, sourceId);
		}

		// Token: 0x0601D77C RID: 120700
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRInformation_SetGridDescription_37(HandleRef pThis, int description);

		/// <summary>
		/// returns the value of vtkUniformGrid::GridDescription() of any block
		/// </summary>
		// Token: 0x0601D77D RID: 120701 RVA: 0x00299C98 File Offset: 0x00297E98
		public void SetGridDescription(int description)
		{
			vtkAMRInformation.vtkAMRInformation_SetGridDescription_37(base.GetCppThis(), description);
		}

		// Token: 0x0601D77E RID: 120702
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRInformation_SetOrigin_38(HandleRef pThis, IntPtr origin);

		/// <summary>
		/// Get the AMR dataset origin
		/// The origin is essentially the minimum of all the grids.
		/// </summary>
		// Token: 0x0601D77F RID: 120703 RVA: 0x00299CA8 File Offset: 0x00297EA8
		public void SetOrigin(IntPtr origin)
		{
			vtkAMRInformation.vtkAMRInformation_SetOrigin_38(base.GetCppThis(), origin);
		}

		// Token: 0x0601D780 RID: 120704
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRInformation_SetRefinementRatio_39(HandleRef pThis, uint level, int ratio);

		/// <summary>
		/// Set the refinement ratio at a level. This method should be
		/// called for all levels, if called at all.
		/// </summary>
		// Token: 0x0601D781 RID: 120705 RVA: 0x00299CB8 File Offset: 0x00297EB8
		public void SetRefinementRatio(uint level, int ratio)
		{
			vtkAMRInformation.vtkAMRInformation_SetRefinementRatio_39(base.GetCppThis(), level, ratio);
		}

		// Token: 0x0601D782 RID: 120706
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRInformation_SetSpacing_40(HandleRef pThis, uint level, IntPtr h);

		/// <summary>
		/// Set the spacing at a given level
		/// </summary>
		// Token: 0x0601D783 RID: 120707 RVA: 0x00299CC9 File Offset: 0x00297EC9
		public void SetSpacing(uint level, IntPtr h)
		{
			vtkAMRInformation.vtkAMRInformation_SetSpacing_40(base.GetCppThis(), level, h);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EF1 RID: 7921
		public new const string MRFullTypeName = "Kitware.VTK.vtkAMRInformation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EF2 RID: 7922
		public new static readonly string MRClassNameKey = "class vtkAMRInformation";
	}
}
