using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkModelMetadata
	/// </summary>
	/// <remarks>
	///    This class encapsulates the metadata
	///   that appear in mesh-based file formats but do not appear in
	///   vtkUnstructuredGrid.
	///
	///
	///   This class is inspired by the Exodus II file format, but
	///   because this class does not depend on the Exodus library, it
	///   should be possible to use it to represent metadata for other
	///   dataset file formats.  Sandia Labs uses it in their Exodus II
	///   reader, their Exodus II writer and their EnSight writer.
	///   vtkDistributedDataFilter looks for metadata attached to
	///   it's input and redistributes the metadata with the grid.
	///
	///   The fields in this class are those described in the document
	///   "EXODUS II: A Finite Element Data Model", SAND92-2137, November 1995.
	///
	///   Element and node IDs stored in this object must be global IDs,
	///   in the event that the original dataset was partitioned across
	///   many files.
	///
	///   One way to initialize this object is by using vtkExodusModel
	///   (a Sandia class used by the Sandia Exodus reader).
	///   That class will take an open Exodus II file and a
	///   vtkUnstructuredGrid drawn from it and will set the required fields.
	///
	///   Alternatively, you can use all the Set*
	///   methods to set the individual fields. This class does not
	///   copy the data, it simply uses your pointer. This
	///   class will free the storage associated with your pointer
	///   when the class is deleted.  Most fields have sensible defaults.
	///   The only requirement is that if you are using this ModelMetadata
	///   to write out an Exodus or EnSight file in parallel, you must
	///   SetBlockIds and SetBlockIdArrayName.  Your vtkUnstructuredGrid must
	///   have a cell array giving the block ID for each cell.
	///
	/// @warning
	///   The Exodus II library supports an optimized element order map
	///   (section 3.7 in the SAND document).  It contains all the element
	///   IDs, listed in the order in which a solver should process them.
	///   We don't include this, and won't unless there is a request.
	///
	/// @warning
	///   There is an assumption in some classes that the name of the cell
	///   array containing global element ids is "GlobalElementId" and the
	///   name of the point array containing global node ids is "GlobalNodeId".
	///   (element == cell) and (node == point).
	///
	/// </remarks>
	/// <seealso>
	///
	///   vtkDistributedDataFilter vtkExtractCells
	/// </seealso>
	// Token: 0x020001BD RID: 445
	public class vtkModelMetadata : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060056EE RID: 22254 RVA: 0x0007DC23 File Offset: 0x0007BE23
		static vtkModelMetadata()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkModelMetadata.MRClassNameKey, Type.GetType("Kitware.VTK.vtkModelMetadata"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060056EF RID: 22255 RVA: 0x0007DC4B File Offset: 0x0007BE4B
		public vtkModelMetadata(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060056F0 RID: 22256
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkModelMetadata_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060056F1 RID: 22257 RVA: 0x0007DC5C File Offset: 0x0007BE5C
		public new static vtkModelMetadata New()
		{
			vtkModelMetadata result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkModelMetadata.vtkModelMetadata_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkModelMetadata)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060056F2 RID: 22258 RVA: 0x0007DCB0 File Offset: 0x0007BEB0
		public vtkModelMetadata() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkModelMetadata.vtkModelMetadata_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060056F3 RID: 22259 RVA: 0x0007DCF4 File Offset: 0x0007BEF4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060056F4 RID: 22260
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkModelMetadata_AllVariablesDefinedInAllBlocksOff_01(HandleRef pThis);

		/// <summary>
		/// Instead of a truth table of all "1"s, you can set this
		/// instance variable to indicate that all variables are
		/// defined in all blocks.
		/// </summary>
		// Token: 0x060056F5 RID: 22261 RVA: 0x0007DCFF File Offset: 0x0007BEFF
		public virtual void AllVariablesDefinedInAllBlocksOff()
		{
			vtkModelMetadata.vtkModelMetadata_AllVariablesDefinedInAllBlocksOff_01(base.GetCppThis());
		}

		// Token: 0x060056F6 RID: 22262
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkModelMetadata_AllVariablesDefinedInAllBlocksOn_02(HandleRef pThis);

		/// <summary>
		/// Instead of a truth table of all "1"s, you can set this
		/// instance variable to indicate that all variables are
		/// defined in all blocks.
		/// </summary>
		// Token: 0x060056F7 RID: 22263 RVA: 0x0007DD0E File Offset: 0x0007BF0E
		public virtual void AllVariablesDefinedInAllBlocksOn()
		{
			vtkModelMetadata.vtkModelMetadata_AllVariablesDefinedInAllBlocksOn_02(base.GetCppThis());
		}

		// Token: 0x060056F8 RID: 22264
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkModelMetadata_FreeAllGlobalData_03(HandleRef pThis);

		/// <summary>
		/// Free selected portions of the metadata when updating values
		/// in the vtkModelMetadata object.  Resetting a particular field,
		/// (i.e. SetNodeSetIds) frees the previous setting, but if you
		/// are not setting every field, you may want to do a wholesale
		/// "Free" first.
		///
		/// FreeAllGlobalData frees all the fields which don't depend on
		/// which time step, which blocks, or which variables are in the input.
		/// FreeAllLocalData frees all the fields which do depend on which
		/// time step, blocks or variables are in the input.
		/// FreeBlockDependentData frees all metadata fields which depend on
		/// which blocks were read in.
		/// </summary>
		// Token: 0x060056F9 RID: 22265 RVA: 0x0007DD1D File Offset: 0x0007BF1D
		public void FreeAllGlobalData()
		{
			vtkModelMetadata.vtkModelMetadata_FreeAllGlobalData_03(base.GetCppThis());
		}

		// Token: 0x060056FA RID: 22266
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkModelMetadata_FreeAllLocalData_04(HandleRef pThis);

		/// <summary>
		/// Free selected portions of the metadata when updating values
		/// in the vtkModelMetadata object.  Resetting a particular field,
		/// (i.e. SetNodeSetIds) frees the previous setting, but if you
		/// are not setting every field, you may want to do a wholesale
		/// "Free" first.
		///
		/// FreeAllGlobalData frees all the fields which don't depend on
		/// which time step, which blocks, or which variables are in the input.
		/// FreeAllLocalData frees all the fields which do depend on which
		/// time step, blocks or variables are in the input.
		/// FreeBlockDependentData frees all metadata fields which depend on
		/// which blocks were read in.
		/// </summary>
		// Token: 0x060056FB RID: 22267 RVA: 0x0007DD2C File Offset: 0x0007BF2C
		public void FreeAllLocalData()
		{
			vtkModelMetadata.vtkModelMetadata_FreeAllLocalData_04(base.GetCppThis());
		}

		// Token: 0x060056FC RID: 22268
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkModelMetadata_FreeBlockDependentData_05(HandleRef pThis);

		/// <summary>
		/// Free selected portions of the metadata when updating values
		/// in the vtkModelMetadata object.  Resetting a particular field,
		/// (i.e. SetNodeSetIds) frees the previous setting, but if you
		/// are not setting every field, you may want to do a wholesale
		/// "Free" first.
		///
		/// FreeAllGlobalData frees all the fields which don't depend on
		/// which time step, which blocks, or which variables are in the input.
		/// FreeAllLocalData frees all the fields which do depend on which
		/// time step, blocks or variables are in the input.
		/// FreeBlockDependentData frees all metadata fields which depend on
		/// which blocks were read in.
		/// </summary>
		// Token: 0x060056FD RID: 22269 RVA: 0x0007DD3B File Offset: 0x0007BF3B
		public void FreeBlockDependentData()
		{
			vtkModelMetadata.vtkModelMetadata_FreeBlockDependentData_05(base.GetCppThis());
		}

		// Token: 0x060056FE RID: 22270
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkModelMetadata_FreeOriginalElementVariableNames_06(HandleRef pThis);

		/// <summary>
		/// Free selected portions of the metadata when updating values
		/// in the vtkModelMetadata object.  Resetting a particular field,
		/// (i.e. SetNodeSetIds) frees the previous setting, but if you
		/// are not setting every field, you may want to do a wholesale
		/// "Free" first.
		///
		/// FreeAllGlobalData frees all the fields which don't depend on
		/// which time step, which blocks, or which variables are in the input.
		/// FreeAllLocalData frees all the fields which do depend on which
		/// time step, blocks or variables are in the input.
		/// FreeBlockDependentData frees all metadata fields which depend on
		/// which blocks were read in.
		/// </summary>
		// Token: 0x060056FF RID: 22271 RVA: 0x0007DD4A File Offset: 0x0007BF4A
		public void FreeOriginalElementVariableNames()
		{
			vtkModelMetadata.vtkModelMetadata_FreeOriginalElementVariableNames_06(base.GetCppThis());
		}

		// Token: 0x06005700 RID: 22272
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkModelMetadata_FreeOriginalNodeVariableNames_07(HandleRef pThis);

		/// <summary>
		/// Free selected portions of the metadata when updating values
		/// in the vtkModelMetadata object.  Resetting a particular field,
		/// (i.e. SetNodeSetIds) frees the previous setting, but if you
		/// are not setting every field, you may want to do a wholesale
		/// "Free" first.
		///
		/// FreeAllGlobalData frees all the fields which don't depend on
		/// which time step, which blocks, or which variables are in the input.
		/// FreeAllLocalData frees all the fields which do depend on which
		/// time step, blocks or variables are in the input.
		/// FreeBlockDependentData frees all metadata fields which depend on
		/// which blocks were read in.
		/// </summary>
		// Token: 0x06005701 RID: 22273 RVA: 0x0007DD59 File Offset: 0x0007BF59
		public void FreeOriginalNodeVariableNames()
		{
			vtkModelMetadata.vtkModelMetadata_FreeOriginalNodeVariableNames_07(base.GetCppThis());
		}

		// Token: 0x06005702 RID: 22274
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkModelMetadata_FreeUsedElementVariableNames_08(HandleRef pThis);

		/// <summary>
		/// Free selected portions of the metadata when updating values
		/// in the vtkModelMetadata object.  Resetting a particular field,
		/// (i.e. SetNodeSetIds) frees the previous setting, but if you
		/// are not setting every field, you may want to do a wholesale
		/// "Free" first.
		///
		/// FreeAllGlobalData frees all the fields which don't depend on
		/// which time step, which blocks, or which variables are in the input.
		/// FreeAllLocalData frees all the fields which do depend on which
		/// time step, blocks or variables are in the input.
		/// FreeBlockDependentData frees all metadata fields which depend on
		/// which blocks were read in.
		/// </summary>
		// Token: 0x06005703 RID: 22275 RVA: 0x0007DD68 File Offset: 0x0007BF68
		public void FreeUsedElementVariableNames()
		{
			vtkModelMetadata.vtkModelMetadata_FreeUsedElementVariableNames_08(base.GetCppThis());
		}

		// Token: 0x06005704 RID: 22276
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkModelMetadata_FreeUsedElementVariables_09(HandleRef pThis);

		/// <summary>
		/// Free selected portions of the metadata when updating values
		/// in the vtkModelMetadata object.  Resetting a particular field,
		/// (i.e. SetNodeSetIds) frees the previous setting, but if you
		/// are not setting every field, you may want to do a wholesale
		/// "Free" first.
		///
		/// FreeAllGlobalData frees all the fields which don't depend on
		/// which time step, which blocks, or which variables are in the input.
		/// FreeAllLocalData frees all the fields which do depend on which
		/// time step, blocks or variables are in the input.
		/// FreeBlockDependentData frees all metadata fields which depend on
		/// which blocks were read in.
		/// </summary>
		// Token: 0x06005705 RID: 22277 RVA: 0x0007DD77 File Offset: 0x0007BF77
		public void FreeUsedElementVariables()
		{
			vtkModelMetadata.vtkModelMetadata_FreeUsedElementVariables_09(base.GetCppThis());
		}

		// Token: 0x06005706 RID: 22278
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkModelMetadata_FreeUsedNodeVariableNames_10(HandleRef pThis);

		/// <summary>
		/// Free selected portions of the metadata when updating values
		/// in the vtkModelMetadata object.  Resetting a particular field,
		/// (i.e. SetNodeSetIds) frees the previous setting, but if you
		/// are not setting every field, you may want to do a wholesale
		/// "Free" first.
		///
		/// FreeAllGlobalData frees all the fields which don't depend on
		/// which time step, which blocks, or which variables are in the input.
		/// FreeAllLocalData frees all the fields which do depend on which
		/// time step, blocks or variables are in the input.
		/// FreeBlockDependentData frees all metadata fields which depend on
		/// which blocks were read in.
		/// </summary>
		// Token: 0x06005707 RID: 22279 RVA: 0x0007DD86 File Offset: 0x0007BF86
		public void FreeUsedNodeVariableNames()
		{
			vtkModelMetadata.vtkModelMetadata_FreeUsedNodeVariableNames_10(base.GetCppThis());
		}

		// Token: 0x06005708 RID: 22280
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkModelMetadata_FreeUsedNodeVariables_11(HandleRef pThis);

		/// <summary>
		/// Free selected portions of the metadata when updating values
		/// in the vtkModelMetadata object.  Resetting a particular field,
		/// (i.e. SetNodeSetIds) frees the previous setting, but if you
		/// are not setting every field, you may want to do a wholesale
		/// "Free" first.
		///
		/// FreeAllGlobalData frees all the fields which don't depend on
		/// which time step, which blocks, or which variables are in the input.
		/// FreeAllLocalData frees all the fields which do depend on which
		/// time step, blocks or variables are in the input.
		/// FreeBlockDependentData frees all metadata fields which depend on
		/// which blocks were read in.
		/// </summary>
		// Token: 0x06005709 RID: 22281 RVA: 0x0007DD95 File Offset: 0x0007BF95
		public void FreeUsedNodeVariables()
		{
			vtkModelMetadata.vtkModelMetadata_FreeUsedNodeVariables_11(base.GetCppThis());
		}

		// Token: 0x0600570A RID: 22282
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkModelMetadata_GetAllVariablesDefinedInAllBlocks_12(HandleRef pThis);

		/// <summary>
		/// Instead of a truth table of all "1"s, you can set this
		/// instance variable to indicate that all variables are
		/// defined in all blocks.
		/// </summary>
		// Token: 0x0600570B RID: 22283 RVA: 0x0007DDA4 File Offset: 0x0007BFA4
		public int GetAllVariablesDefinedInAllBlocks()
		{
			return vtkModelMetadata.vtkModelMetadata_GetAllVariablesDefinedInAllBlocks_12(base.GetCppThis());
		}

		// Token: 0x0600570C RID: 22284
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkModelMetadata_GetBlockAttributes_13(HandleRef pThis);

		/// <summary>
		/// Set or get a pointer to a list of the attributes for all
		/// blocks.  The order of the list should be by block, by element
		/// within the block, by attribute.  Omit blocks that don't
		/// have element attributes.
		/// </summary>
		// Token: 0x0600570D RID: 22285 RVA: 0x0007DDC4 File Offset: 0x0007BFC4
		public IntPtr GetBlockAttributes()
		{
			return vtkModelMetadata.vtkModelMetadata_GetBlockAttributes_13(base.GetCppThis());
		}

		// Token: 0x0600570E RID: 22286
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkModelMetadata_GetBlockAttributesIndex_14(HandleRef pThis);

		/// <summary>
		/// Get a list of the index into the BlockAttributes of the
		/// start of each block's element attribute list.
		/// </summary>
		// Token: 0x0600570F RID: 22287 RVA: 0x0007DDE4 File Offset: 0x0007BFE4
		public IntPtr GetBlockAttributesIndex()
		{
			return vtkModelMetadata.vtkModelMetadata_GetBlockAttributesIndex_14(base.GetCppThis());
		}

		// Token: 0x06005710 RID: 22288
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkModelMetadata_GetBlockElementIdList_15(HandleRef pThis);

		/// <summary>
		/// Set or get a pointer to a list global element IDs for the
		/// elements in each block.
		/// We use your pointers, and free the memory when the object is freed.
		/// </summary>
		// Token: 0x06005711 RID: 22289 RVA: 0x0007DE04 File Offset: 0x0007C004
		public IntPtr GetBlockElementIdList()
		{
			return vtkModelMetadata.vtkModelMetadata_GetBlockElementIdList_15(base.GetCppThis());
		}

		// Token: 0x06005712 RID: 22290
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkModelMetadata_GetBlockElementIdListIndex_16(HandleRef pThis);

		/// <summary>
		/// Get a list of the index into the BlockElementIdList of the
		/// start of each block's elements.
		/// </summary>
		// Token: 0x06005713 RID: 22291 RVA: 0x0007DE24 File Offset: 0x0007C024
		public IntPtr GetBlockElementIdListIndex()
		{
			return vtkModelMetadata.vtkModelMetadata_GetBlockElementIdListIndex_16(base.GetCppThis());
		}

		// Token: 0x06005714 RID: 22292
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkModelMetadata_GetBlockIds_17(HandleRef pThis);

		/// <summary>
		/// An arbitrary integer ID for each block.
		/// We use your pointer, and free the memory when the object is freed.
		/// </summary>
		// Token: 0x06005715 RID: 22293 RVA: 0x0007DE44 File Offset: 0x0007C044
		public IntPtr GetBlockIds()
		{
			return vtkModelMetadata.vtkModelMetadata_GetBlockIds_17(base.GetCppThis());
		}

		// Token: 0x06005716 RID: 22294
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkModelMetadata_GetBlockNodesPerElement_18(HandleRef pThis);

		/// <summary>
		/// Set or get a pointer to a list of the number of nodes in the
		/// elements of each block.
		/// We use your pointers, and free the memory when the object is freed.
		/// </summary>
		// Token: 0x06005717 RID: 22295 RVA: 0x0007DE64 File Offset: 0x0007C064
		public IntPtr GetBlockNodesPerElement()
		{
			return vtkModelMetadata.vtkModelMetadata_GetBlockNodesPerElement_18(base.GetCppThis());
		}

		// Token: 0x06005718 RID: 22296
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkModelMetadata_GetBlockNumberOfAttributesPerElement_19(HandleRef pThis);

		/// <summary>
		/// Set or get a pointer to a list of the number of attributes
		/// stored for the elements in each block.
		/// We use your pointers, and free the memory when the object is freed.
		/// </summary>
		// Token: 0x06005719 RID: 22297 RVA: 0x0007DE84 File Offset: 0x0007C084
		public IntPtr GetBlockNumberOfAttributesPerElement()
		{
			return vtkModelMetadata.vtkModelMetadata_GetBlockNumberOfAttributesPerElement_19(base.GetCppThis());
		}

		// Token: 0x0600571A RID: 22298
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkModelMetadata_GetBlockNumberOfElements_20(HandleRef pThis);

		/// <summary>
		/// Set or get a pointer to a list of the number of elements in
		/// each block.
		/// We use your pointers, and free the memory when the object is freed.
		/// </summary>
		// Token: 0x0600571B RID: 22299 RVA: 0x0007DEA4 File Offset: 0x0007C0A4
		public IntPtr GetBlockNumberOfElements()
		{
			return vtkModelMetadata.vtkModelMetadata_GetBlockNumberOfElements_20(base.GetCppThis());
		}

		// Token: 0x0600571C RID: 22300
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkModelMetadata_GetBlockPropertyValue_21(HandleRef pThis);

		/// <summary>
		/// Set or get value for each variable for each block.  List
		/// the integer values in order by variable and within variable
		/// by block.
		/// </summary>
		// Token: 0x0600571D RID: 22301 RVA: 0x0007DEC4 File Offset: 0x0007C0C4
		public IntPtr GetBlockPropertyValue()
		{
			return vtkModelMetadata.vtkModelMetadata_GetBlockPropertyValue_21(base.GetCppThis());
		}

		// Token: 0x0600571E RID: 22302
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkModelMetadata_GetDimension_22(HandleRef pThis);

		/// <summary>
		/// Get the dimension of the model.  This is also the number
		/// of coordinate names.
		/// </summary>
		// Token: 0x0600571F RID: 22303 RVA: 0x0007DEE4 File Offset: 0x0007C0E4
		public int GetDimension()
		{
			return vtkModelMetadata.vtkModelMetadata_GetDimension_22(base.GetCppThis());
		}

		// Token: 0x06005720 RID: 22304
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkModelMetadata_GetElementVariableNumberOfComponents_23(HandleRef pThis);

		/// <summary>
		/// The ModelMetadata object may contain these lists:
		/// o  the variables in the original data file
		/// o  the variables created in the u grid from those original variables
		/// o  a mapping from the grid variable names to the original names
		/// o  a list of the number of components each grid variable has
		///
		/// (Example: Variables in Exodus II files are all scalars.  Some are
		/// combined by the ExodusReader into vector variables in the grid.)
		///
		/// These methods return names of the original variables, the names
		/// of the grid variables, a list of the number of components in
		/// each grid variable, and a list of the index into the list of
		/// original variable names where the original name of the first
		/// component of a grid variable may be found.  The names of subsequent
		/// components would immediately follow the name of the first
		/// component.
		/// </summary>
		// Token: 0x06005721 RID: 22305 RVA: 0x0007DF04 File Offset: 0x0007C104
		public IntPtr GetElementVariableNumberOfComponents()
		{
			return vtkModelMetadata.vtkModelMetadata_GetElementVariableNumberOfComponents_23(base.GetCppThis());
		}

		// Token: 0x06005722 RID: 22306
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkModelMetadata_GetElementVariableTruthTable_24(HandleRef pThis);

		/// <summary>
		/// A truth table indicating which element variables are
		/// defined for which blocks. The variables are all the original
		/// element variables that were in the file.
		/// The table is by block ID and within block ID by variable.
		/// </summary>
		// Token: 0x06005723 RID: 22307 RVA: 0x0007DF24 File Offset: 0x0007C124
		public IntPtr GetElementVariableTruthTable()
		{
			return vtkModelMetadata.vtkModelMetadata_GetElementVariableTruthTable_24(base.GetCppThis());
		}

		// Token: 0x06005724 RID: 22308
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkModelMetadata_GetGlobalVariableValue_25(HandleRef pThis);

		/// <summary>
		/// Set or get the values of the global variables at the current
		/// time step.
		/// </summary>
		// Token: 0x06005725 RID: 22309 RVA: 0x0007DF44 File Offset: 0x0007C144
		public IntPtr GetGlobalVariableValue()
		{
			return vtkModelMetadata.vtkModelMetadata_GetGlobalVariableValue_25(base.GetCppThis());
		}

		// Token: 0x06005726 RID: 22310
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkModelMetadata_GetMapToOriginalElementVariableNames_26(HandleRef pThis);

		/// <summary>
		/// The ModelMetadata object may contain these lists:
		/// o  the variables in the original data file
		/// o  the variables created in the u grid from those original variables
		/// o  a mapping from the grid variable names to the original names
		/// o  a list of the number of components each grid variable has
		///
		/// (Example: Variables in Exodus II files are all scalars.  Some are
		/// combined by the ExodusReader into vector variables in the grid.)
		///
		/// These methods return names of the original variables, the names
		/// of the grid variables, a list of the number of components in
		/// each grid variable, and a list of the index into the list of
		/// original variable names where the original name of the first
		/// component of a grid variable may be found.  The names of subsequent
		/// components would immediately follow the name of the first
		/// component.
		/// </summary>
		// Token: 0x06005727 RID: 22311 RVA: 0x0007DF64 File Offset: 0x0007C164
		public IntPtr GetMapToOriginalElementVariableNames()
		{
			return vtkModelMetadata.vtkModelMetadata_GetMapToOriginalElementVariableNames_26(base.GetCppThis());
		}

		// Token: 0x06005728 RID: 22312
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkModelMetadata_GetMapToOriginalNodeVariableNames_27(HandleRef pThis);

		/// <summary>
		/// The ModelMetadata object may contain these lists:
		/// o  the variables in the original data file
		/// o  the variables created in the u grid from those original variables
		/// o  a mapping from the grid variable names to the original names
		/// o  a list of the number of components each grid variable has
		///
		/// (Example: Variables in Exodus II files are all scalars.  Some are
		/// combined by the ExodusReader into vector variables in the grid.)
		///
		/// These methods return names of the original variables, the names
		/// of the grid variables, a list of the number of components in
		/// each grid variable, and a list of the index into the list of
		/// original variable names where the original name of the first
		/// component of a grid variable may be found.  The names of subsequent
		/// components would immediately follow the name of the first
		/// component.
		/// </summary>
		// Token: 0x06005729 RID: 22313 RVA: 0x0007DF84 File Offset: 0x0007C184
		public IntPtr GetMapToOriginalNodeVariableNames()
		{
			return vtkModelMetadata.vtkModelMetadata_GetMapToOriginalNodeVariableNames_27(base.GetCppThis());
		}

		// Token: 0x0600572A RID: 22314
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkModelMetadata_GetNodeSetDistributionFactorIndex_28(HandleRef pThis);

		/// <summary>
		/// Get a list of the index of the starting entry for each node set
		/// in the list of node set distribution factors.
		/// </summary>
		// Token: 0x0600572B RID: 22315 RVA: 0x0007DFA4 File Offset: 0x0007C1A4
		public IntPtr GetNodeSetDistributionFactorIndex()
		{
			return vtkModelMetadata.vtkModelMetadata_GetNodeSetDistributionFactorIndex_28(base.GetCppThis());
		}

		// Token: 0x0600572C RID: 22316
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkModelMetadata_GetNodeSetDistributionFactors_29(HandleRef pThis);

		/// <summary>
		/// Set or get a list of the distribution factors for the node sets.
		/// The list is organized by node set, and within node set by node.
		/// We use your pointer, and free the memory when the object is freed.
		/// </summary>
		// Token: 0x0600572D RID: 22317 RVA: 0x0007DFC4 File Offset: 0x0007C1C4
		public IntPtr GetNodeSetDistributionFactors()
		{
			return vtkModelMetadata.vtkModelMetadata_GetNodeSetDistributionFactors_29(base.GetCppThis());
		}

		// Token: 0x0600572E RID: 22318
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkModelMetadata_GetNodeSetIds_30(HandleRef pThis);

		/// <summary>
		/// Set or get the list the IDs for each node set.
		/// Length of list is the number of node sets.
		/// We use your pointer, and free the memory when the object is freed.
		/// </summary>
		// Token: 0x0600572F RID: 22319 RVA: 0x0007DFE4 File Offset: 0x0007C1E4
		public IntPtr GetNodeSetIds()
		{
			return vtkModelMetadata.vtkModelMetadata_GetNodeSetIds_30(base.GetCppThis());
		}

		// Token: 0x06005730 RID: 22320
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkModelMetadata_GetNodeSetNames_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The number of node sets in the file.  Set this value before
		/// setting the various node set arrays.
		/// </summary>
		// Token: 0x06005731 RID: 22321 RVA: 0x0007E004 File Offset: 0x0007C204
		public vtkStringArray GetNodeSetNames()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkModelMetadata.vtkModelMetadata_GetNodeSetNames_31(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringArray = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringArray.Register(null);
				}
			}
			return vtkStringArray;
		}

		// Token: 0x06005732 RID: 22322
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkModelMetadata_GetNodeSetNodeIdList_32(HandleRef pThis);

		/// <summary>
		/// Set or get a pointer to a concatenated list of the
		/// IDs of all nodes in each node set.  First list all IDs in
		/// node set 0, then all IDs in node set 1, and so on.
		/// We use your pointer, and free the memory when the object is freed.
		/// </summary>
		// Token: 0x06005733 RID: 22323 RVA: 0x0007E074 File Offset: 0x0007C274
		public IntPtr GetNodeSetNodeIdList()
		{
			return vtkModelMetadata.vtkModelMetadata_GetNodeSetNodeIdList_32(base.GetCppThis());
		}

		// Token: 0x06005734 RID: 22324
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkModelMetadata_GetNodeSetNodeIdListIndex_33(HandleRef pThis);

		/// <summary>
		/// Get a list of the index of the starting entry for each node set
		/// in the list of node set node IDs.
		/// </summary>
		// Token: 0x06005735 RID: 22325 RVA: 0x0007E094 File Offset: 0x0007C294
		public IntPtr GetNodeSetNodeIdListIndex()
		{
			return vtkModelMetadata.vtkModelMetadata_GetNodeSetNodeIdListIndex_33(base.GetCppThis());
		}

		// Token: 0x06005736 RID: 22326
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkModelMetadata_GetNodeSetNumberOfDistributionFactors_34(HandleRef pThis);

		/// <summary>
		/// Set or get a list of the number of distribution factors stored
		/// by each node set.  This is either 0 or equal to the number of
		/// nodes in the node set.
		/// Length of list is number of node sets.
		/// We use your pointer, and free the memory when the object is freed.
		/// </summary>
		// Token: 0x06005737 RID: 22327 RVA: 0x0007E0B4 File Offset: 0x0007C2B4
		public IntPtr GetNodeSetNumberOfDistributionFactors()
		{
			return vtkModelMetadata.vtkModelMetadata_GetNodeSetNumberOfDistributionFactors_34(base.GetCppThis());
		}

		// Token: 0x06005738 RID: 22328
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkModelMetadata_GetNodeSetPropertyValue_35(HandleRef pThis);

		/// <summary>
		/// Set or get value for each variable for each node set.  List
		/// the integer values in order by variable and within variable
		/// by node set.
		/// </summary>
		// Token: 0x06005739 RID: 22329 RVA: 0x0007E0D4 File Offset: 0x0007C2D4
		public IntPtr GetNodeSetPropertyValue()
		{
			return vtkModelMetadata.vtkModelMetadata_GetNodeSetPropertyValue_35(base.GetCppThis());
		}

		// Token: 0x0600573A RID: 22330
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkModelMetadata_GetNodeSetSize_36(HandleRef pThis);

		/// <summary>
		/// Set or get a pointer to a list of the number of nodes in each node set.
		/// We use your pointer, and free the memory when the object is freed.
		/// </summary>
		// Token: 0x0600573B RID: 22331 RVA: 0x0007E0F4 File Offset: 0x0007C2F4
		public IntPtr GetNodeSetSize()
		{
			return vtkModelMetadata.vtkModelMetadata_GetNodeSetSize_36(base.GetCppThis());
		}

		// Token: 0x0600573C RID: 22332
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkModelMetadata_GetNodeVariableNumberOfComponents_37(HandleRef pThis);

		/// <summary>
		/// The ModelMetadata object may contain these lists:
		/// o  the variables in the original data file
		/// o  the variables created in the u grid from those original variables
		/// o  a mapping from the grid variable names to the original names
		/// o  a list of the number of components each grid variable has
		///
		/// (Example: Variables in Exodus II files are all scalars.  Some are
		/// combined by the ExodusReader into vector variables in the grid.)
		///
		/// These methods return names of the original variables, the names
		/// of the grid variables, a list of the number of components in
		/// each grid variable, and a list of the index into the list of
		/// original variable names where the original name of the first
		/// component of a grid variable may be found.  The names of subsequent
		/// components would immediately follow the name of the first
		/// component.
		/// </summary>
		// Token: 0x0600573D RID: 22333 RVA: 0x0007E114 File Offset: 0x0007C314
		public IntPtr GetNodeVariableNumberOfComponents()
		{
			return vtkModelMetadata.vtkModelMetadata_GetNodeVariableNumberOfComponents_37(base.GetCppThis());
		}

		// Token: 0x0600573E RID: 22334
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkModelMetadata_GetNumberOfBlockProperties_38(HandleRef pThis);

		/// <summary>
		/// The number of block properties (global variables)
		/// </summary>
		// Token: 0x0600573F RID: 22335 RVA: 0x0007E134 File Offset: 0x0007C334
		public int GetNumberOfBlockProperties()
		{
			return vtkModelMetadata.vtkModelMetadata_GetNumberOfBlockProperties_38(base.GetCppThis());
		}

		// Token: 0x06005740 RID: 22336
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkModelMetadata_GetNumberOfBlocks_39(HandleRef pThis);

		/// <summary>
		/// The number of blocks in the file.  Set this before setting
		/// any of the block arrays.
		/// </summary>
		// Token: 0x06005741 RID: 22337 RVA: 0x0007E154 File Offset: 0x0007C354
		public int GetNumberOfBlocks()
		{
			return vtkModelMetadata.vtkModelMetadata_GetNumberOfBlocks_39(base.GetCppThis());
		}

		// Token: 0x06005742 RID: 22338
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkModelMetadata_GetNumberOfElementVariables_40(HandleRef pThis);

		/// <summary>
		/// The ModelMetadata object may contain these lists:
		/// o  the variables in the original data file
		/// o  the variables created in the u grid from those original variables
		/// o  a mapping from the grid variable names to the original names
		/// o  a list of the number of components each grid variable has
		///
		/// (Example: Variables in Exodus II files are all scalars.  Some are
		/// combined by the ExodusReader into vector variables in the grid.)
		///
		/// These methods return names of the original variables, the names
		/// of the grid variables, a list of the number of components in
		/// each grid variable, and a list of the index into the list of
		/// original variable names where the original name of the first
		/// component of a grid variable may be found.  The names of subsequent
		/// components would immediately follow the name of the first
		/// component.
		/// </summary>
		// Token: 0x06005743 RID: 22339 RVA: 0x0007E174 File Offset: 0x0007C374
		public int GetNumberOfElementVariables()
		{
			return vtkModelMetadata.vtkModelMetadata_GetNumberOfElementVariables_40(base.GetCppThis());
		}

		// Token: 0x06005744 RID: 22340
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkModelMetadata_GetNumberOfGenerationsFromBase_41(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005745 RID: 22341 RVA: 0x0007E194 File Offset: 0x0007C394
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkModelMetadata.vtkModelMetadata_GetNumberOfGenerationsFromBase_41(base.GetCppThis(), type);
		}

		// Token: 0x06005746 RID: 22342
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkModelMetadata_GetNumberOfGenerationsFromBaseType_42([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005747 RID: 22343 RVA: 0x0007E1B4 File Offset: 0x0007C3B4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkModelMetadata.vtkModelMetadata_GetNumberOfGenerationsFromBaseType_42(type);
		}

		// Token: 0x06005748 RID: 22344
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkModelMetadata_GetNumberOfGlobalVariables_43(HandleRef pThis);

		/// <summary>
		/// Get the number of global variables per time step
		/// </summary>
		// Token: 0x06005749 RID: 22345 RVA: 0x0007E1D0 File Offset: 0x0007C3D0
		public int GetNumberOfGlobalVariables()
		{
			return vtkModelMetadata.vtkModelMetadata_GetNumberOfGlobalVariables_43(base.GetCppThis());
		}

		// Token: 0x0600574A RID: 22346
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkModelMetadata_GetNumberOfInformationLines_44(HandleRef pThis);

		/// <summary>
		/// Get the number of information lines.
		/// </summary>
		// Token: 0x0600574B RID: 22347 RVA: 0x0007E1F0 File Offset: 0x0007C3F0
		public int GetNumberOfInformationLines()
		{
			return vtkModelMetadata.vtkModelMetadata_GetNumberOfInformationLines_44(base.GetCppThis());
		}

		// Token: 0x0600574C RID: 22348
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkModelMetadata_GetNumberOfNodeSetProperties_45(HandleRef pThis);

		/// <summary>
		/// The number of node set properties (global variables)
		/// </summary>
		// Token: 0x0600574D RID: 22349 RVA: 0x0007E210 File Offset: 0x0007C410
		public int GetNumberOfNodeSetProperties()
		{
			return vtkModelMetadata.vtkModelMetadata_GetNumberOfNodeSetProperties_45(base.GetCppThis());
		}

		// Token: 0x0600574E RID: 22350
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkModelMetadata_GetNumberOfNodeSets_46(HandleRef pThis);

		/// <summary>
		/// The number of node sets in the file.  Set this value before
		/// setting the various node set arrays.
		/// </summary>
		// Token: 0x0600574F RID: 22351 RVA: 0x0007E230 File Offset: 0x0007C430
		public int GetNumberOfNodeSets()
		{
			return vtkModelMetadata.vtkModelMetadata_GetNumberOfNodeSets_46(base.GetCppThis());
		}

		// Token: 0x06005750 RID: 22352
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkModelMetadata_GetNumberOfNodeVariables_47(HandleRef pThis);

		/// <summary>
		/// The ModelMetadata object may contain these lists:
		/// o  the variables in the original data file
		/// o  the variables created in the u grid from those original variables
		/// o  a mapping from the grid variable names to the original names
		/// o  a list of the number of components each grid variable has
		///
		/// (Example: Variables in Exodus II files are all scalars.  Some are
		/// combined by the ExodusReader into vector variables in the grid.)
		///
		/// These methods return names of the original variables, the names
		/// of the grid variables, a list of the number of components in
		/// each grid variable, and a list of the index into the list of
		/// original variable names where the original name of the first
		/// component of a grid variable may be found.  The names of subsequent
		/// components would immediately follow the name of the first
		/// component.
		/// </summary>
		// Token: 0x06005751 RID: 22353 RVA: 0x0007E250 File Offset: 0x0007C450
		public int GetNumberOfNodeVariables()
		{
			return vtkModelMetadata.vtkModelMetadata_GetNumberOfNodeVariables_47(base.GetCppThis());
		}

		// Token: 0x06005752 RID: 22354
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkModelMetadata_GetNumberOfSideSetProperties_48(HandleRef pThis);

		/// <summary>
		/// The number of side set properties (global variables)
		/// </summary>
		// Token: 0x06005753 RID: 22355 RVA: 0x0007E270 File Offset: 0x0007C470
		public int GetNumberOfSideSetProperties()
		{
			return vtkModelMetadata.vtkModelMetadata_GetNumberOfSideSetProperties_48(base.GetCppThis());
		}

		// Token: 0x06005754 RID: 22356
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkModelMetadata_GetNumberOfSideSets_49(HandleRef pThis);

		/// <summary>
		/// Set or get the number of side sets.  Set this value before
		/// setting any of the other side set arrays.
		/// </summary>
		// Token: 0x06005755 RID: 22357 RVA: 0x0007E290 File Offset: 0x0007C490
		public int GetNumberOfSideSets()
		{
			return vtkModelMetadata.vtkModelMetadata_GetNumberOfSideSets_49(base.GetCppThis());
		}

		// Token: 0x06005756 RID: 22358
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkModelMetadata_GetNumberOfTimeSteps_50(HandleRef pThis);

		/// <summary>
		/// Set the total number of time steps in the file,
		/// and the value at each time step.  We use your time
		/// step value array and delete it when we're done.
		/// </summary>
		// Token: 0x06005757 RID: 22359 RVA: 0x0007E2B0 File Offset: 0x0007C4B0
		public int GetNumberOfTimeSteps()
		{
			return vtkModelMetadata.vtkModelMetadata_GetNumberOfTimeSteps_50(base.GetCppThis());
		}

		// Token: 0x06005758 RID: 22360
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkModelMetadata_GetOriginalNumberOfElementVariables_51(HandleRef pThis);

		/// <summary>
		/// The ModelMetadata object may contain these lists:
		/// o  the variables in the original data file
		/// o  the variables created in the u grid from those original variables
		/// o  a mapping from the grid variable names to the original names
		/// o  a list of the number of components each grid variable has
		///
		/// (Example: Variables in Exodus II files are all scalars.  Some are
		/// combined by the ExodusReader into vector variables in the grid.)
		///
		/// These methods return names of the original variables, the names
		/// of the grid variables, a list of the number of components in
		/// each grid variable, and a list of the index into the list of
		/// original variable names where the original name of the first
		/// component of a grid variable may be found.  The names of subsequent
		/// components would immediately follow the name of the first
		/// component.
		/// </summary>
		// Token: 0x06005759 RID: 22361 RVA: 0x0007E2D0 File Offset: 0x0007C4D0
		public int GetOriginalNumberOfElementVariables()
		{
			return vtkModelMetadata.vtkModelMetadata_GetOriginalNumberOfElementVariables_51(base.GetCppThis());
		}

		// Token: 0x0600575A RID: 22362
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkModelMetadata_GetOriginalNumberOfNodeVariables_52(HandleRef pThis);

		/// <summary>
		/// The ModelMetadata object may contain these lists:
		/// o  the variables in the original data file
		/// o  the variables created in the u grid from those original variables
		/// o  a mapping from the grid variable names to the original names
		/// o  a list of the number of components each grid variable has
		///
		/// (Example: Variables in Exodus II files are all scalars.  Some are
		/// combined by the ExodusReader into vector variables in the grid.)
		///
		/// These methods return names of the original variables, the names
		/// of the grid variables, a list of the number of components in
		/// each grid variable, and a list of the index into the list of
		/// original variable names where the original name of the first
		/// component of a grid variable may be found.  The names of subsequent
		/// components would immediately follow the name of the first
		/// component.
		/// </summary>
		// Token: 0x0600575B RID: 22363 RVA: 0x0007E2F0 File Offset: 0x0007C4F0
		public int GetOriginalNumberOfNodeVariables()
		{
			return vtkModelMetadata.vtkModelMetadata_GetOriginalNumberOfNodeVariables_52(base.GetCppThis());
		}

		// Token: 0x0600575C RID: 22364
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkModelMetadata_GetSideSetDistributionFactorIndex_53(HandleRef pThis);

		/// <summary>
		/// Get a list of the index of the starting entry for each side set
		/// in the list of side set distribution factors.
		/// </summary>
		// Token: 0x0600575D RID: 22365 RVA: 0x0007E310 File Offset: 0x0007C510
		public IntPtr GetSideSetDistributionFactorIndex()
		{
			return vtkModelMetadata.vtkModelMetadata_GetSideSetDistributionFactorIndex_53(base.GetCppThis());
		}

		// Token: 0x0600575E RID: 22366
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkModelMetadata_GetSideSetDistributionFactors_54(HandleRef pThis);

		/// <summary>
		/// Set or get a pointer to a list of all the distribution factors.
		/// For every side set that has distribution factors, the number of
		/// factors per node was given in the SideSetNumberOfDistributionFactors
		/// array.  If this number for a given side set is N, then for that
		/// side set we have N floating point values for each node for each
		/// side in the side set.  If nodes are repeated in more than one
		/// side, we repeat the distribution factors.  So this list is in order
		/// by side set, by node.
		/// We use your pointer, and free the memory when the object is freed.
		/// </summary>
		// Token: 0x0600575F RID: 22367 RVA: 0x0007E330 File Offset: 0x0007C530
		public IntPtr GetSideSetDistributionFactors()
		{
			return vtkModelMetadata.vtkModelMetadata_GetSideSetDistributionFactors_54(base.GetCppThis());
		}

		// Token: 0x06005760 RID: 22368
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkModelMetadata_GetSideSetElementList_55(HandleRef pThis);

		/// <summary>
		/// Set or get a pointer to a list of the elements containing each
		/// side in each side set.  The list is organized by side set, and
		/// within side set by element.
		/// We use your pointer, and free the memory when the object is freed.
		/// </summary>
		// Token: 0x06005761 RID: 22369 RVA: 0x0007E350 File Offset: 0x0007C550
		public IntPtr GetSideSetElementList()
		{
			return vtkModelMetadata.vtkModelMetadata_GetSideSetElementList_55(base.GetCppThis());
		}

		// Token: 0x06005762 RID: 22370
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkModelMetadata_GetSideSetIds_56(HandleRef pThis);

		/// <summary>
		/// Set or get a pointer to a list giving the ID of each side set.
		/// We use your pointer, and free the memory when the object is freed.
		/// </summary>
		// Token: 0x06005763 RID: 22371 RVA: 0x0007E370 File Offset: 0x0007C570
		public IntPtr GetSideSetIds()
		{
			return vtkModelMetadata.vtkModelMetadata_GetSideSetIds_56(base.GetCppThis());
		}

		// Token: 0x06005764 RID: 22372
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkModelMetadata_GetSideSetListIndex_57(HandleRef pThis);

		/// <summary>
		/// Get a list of the index of the starting entry for each side set
		/// in the list of side set side IDs.
		/// </summary>
		// Token: 0x06005765 RID: 22373 RVA: 0x0007E390 File Offset: 0x0007C590
		public IntPtr GetSideSetListIndex()
		{
			return vtkModelMetadata.vtkModelMetadata_GetSideSetListIndex_57(base.GetCppThis());
		}

		// Token: 0x06005766 RID: 22374
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkModelMetadata_GetSideSetNames_58(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set or get the number of side sets.  Set this value before
		/// setting any of the other side set arrays.
		/// </summary>
		// Token: 0x06005767 RID: 22375 RVA: 0x0007E3B0 File Offset: 0x0007C5B0
		public vtkStringArray GetSideSetNames()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkModelMetadata.vtkModelMetadata_GetSideSetNames_58(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringArray = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringArray.Register(null);
				}
			}
			return vtkStringArray;
		}

		// Token: 0x06005768 RID: 22376
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkModelMetadata_GetSideSetNumDFPerSide_59(HandleRef pThis);

		/// <summary>
		/// Set or get a pointer to a list of the number of nodes in each
		/// side of each side set.  This list is organized by side set, and
		/// within side set by side.
		/// We use your pointer, and free the memory when the object is freed.
		/// </summary>
		// Token: 0x06005769 RID: 22377 RVA: 0x0007E420 File Offset: 0x0007C620
		public IntPtr GetSideSetNumDFPerSide()
		{
			return vtkModelMetadata.vtkModelMetadata_GetSideSetNumDFPerSide_59(base.GetCppThis());
		}

		// Token: 0x0600576A RID: 22378
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkModelMetadata_GetSideSetNumberOfDistributionFactors_60(HandleRef pThis);

		/// <summary>
		/// Set or get a pointer to a list of the number of distribution
		/// factors stored by each side set.   Each side set has either
		/// no distribution factors, or 1 per node in the side set.
		/// We use your pointer, and free the memory when the object is freed.
		/// </summary>
		// Token: 0x0600576B RID: 22379 RVA: 0x0007E440 File Offset: 0x0007C640
		public IntPtr GetSideSetNumberOfDistributionFactors()
		{
			return vtkModelMetadata.vtkModelMetadata_GetSideSetNumberOfDistributionFactors_60(base.GetCppThis());
		}

		// Token: 0x0600576C RID: 22380
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkModelMetadata_GetSideSetPropertyValue_61(HandleRef pThis);

		/// <summary>
		/// Set or get value for each variable for each side set.  List
		/// the integer values in order by variable and within variable
		/// by side set.
		/// </summary>
		// Token: 0x0600576D RID: 22381 RVA: 0x0007E460 File Offset: 0x0007C660
		public IntPtr GetSideSetPropertyValue()
		{
			return vtkModelMetadata.vtkModelMetadata_GetSideSetPropertyValue_61(base.GetCppThis());
		}

		// Token: 0x0600576E RID: 22382
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkModelMetadata_GetSideSetSideList_62(HandleRef pThis);

		/// <summary>
		/// Set or get a pointer to the element side for each side in the side set.
		/// (See the manual for the convention for numbering sides in different
		/// types of cells.)  Side Ids are arranged by side set and within
		/// side set by side, and correspond to the SideSetElementList.
		/// We use your pointer, and free the memory when the object is freed.
		/// </summary>
		// Token: 0x0600576F RID: 22383 RVA: 0x0007E480 File Offset: 0x0007C680
		public IntPtr GetSideSetSideList()
		{
			return vtkModelMetadata.vtkModelMetadata_GetSideSetSideList_62(base.GetCppThis());
		}

		// Token: 0x06005770 RID: 22384
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkModelMetadata_GetSideSetSize_63(HandleRef pThis);

		/// <summary>
		/// Set or get a pointer to a list of the number of sides in each side set.
		/// We use your pointer, and free the memory when the object is freed.
		/// </summary>
		// Token: 0x06005771 RID: 22385 RVA: 0x0007E4A0 File Offset: 0x0007C6A0
		public IntPtr GetSideSetSize()
		{
			return vtkModelMetadata.vtkModelMetadata_GetSideSetSize_63(base.GetCppThis());
		}

		// Token: 0x06005772 RID: 22386
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkModelMetadata_GetSizeBlockAttributeArray_64(HandleRef pThis);

		/// <summary>
		/// Get the length of the list of floating point block attributes.
		/// </summary>
		// Token: 0x06005773 RID: 22387 RVA: 0x0007E4C0 File Offset: 0x0007C6C0
		public int GetSizeBlockAttributeArray()
		{
			return vtkModelMetadata.vtkModelMetadata_GetSizeBlockAttributeArray_64(base.GetCppThis());
		}

		// Token: 0x06005774 RID: 22388
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkModelMetadata_GetSumDistFactPerNodeSet_65(HandleRef pThis);

		/// <summary>
		/// Get the total number of distribution factors stored for all node sets
		/// </summary>
		// Token: 0x06005775 RID: 22389 RVA: 0x0007E4E0 File Offset: 0x0007C6E0
		public int GetSumDistFactPerNodeSet()
		{
			return vtkModelMetadata.vtkModelMetadata_GetSumDistFactPerNodeSet_65(base.GetCppThis());
		}

		// Token: 0x06005776 RID: 22390
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkModelMetadata_GetSumDistFactPerSideSet_66(HandleRef pThis);

		/// <summary>
		/// Get the total number of distribution factors stored for all side sets
		/// </summary>
		// Token: 0x06005777 RID: 22391 RVA: 0x0007E500 File Offset: 0x0007C700
		public int GetSumDistFactPerSideSet()
		{
			return vtkModelMetadata.vtkModelMetadata_GetSumDistFactPerSideSet_66(base.GetCppThis());
		}

		// Token: 0x06005778 RID: 22392
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkModelMetadata_GetSumElementsPerBlock_67(HandleRef pThis);

		/// <summary>
		/// Get the length of the list of elements in every block.
		/// </summary>
		// Token: 0x06005779 RID: 22393 RVA: 0x0007E520 File Offset: 0x0007C720
		public int GetSumElementsPerBlock()
		{
			return vtkModelMetadata.vtkModelMetadata_GetSumElementsPerBlock_67(base.GetCppThis());
		}

		// Token: 0x0600577A RID: 22394
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkModelMetadata_GetSumNodesPerNodeSet_68(HandleRef pThis);

		/// <summary>
		/// Get the total number of nodes in all node sets
		/// </summary>
		// Token: 0x0600577B RID: 22395 RVA: 0x0007E540 File Offset: 0x0007C740
		public int GetSumNodesPerNodeSet()
		{
			return vtkModelMetadata.vtkModelMetadata_GetSumNodesPerNodeSet_68(base.GetCppThis());
		}

		// Token: 0x0600577C RID: 22396
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkModelMetadata_GetSumSidesPerSideSet_69(HandleRef pThis);

		/// <summary>
		/// Get the total number of sides in all side sets
		/// </summary>
		// Token: 0x0600577D RID: 22397 RVA: 0x0007E560 File Offset: 0x0007C760
		public int GetSumSidesPerSideSet()
		{
			return vtkModelMetadata.vtkModelMetadata_GetSumSidesPerSideSet_69(base.GetCppThis());
		}

		// Token: 0x0600577E RID: 22398
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkModelMetadata_GetTimeStepIndex_70(HandleRef pThis);

		/// <summary>
		/// Set the index of the time step represented by the results
		/// data in the file attached to this ModelMetadata object.  Time
		/// step indices start at 0 in this file, they start at 1 in
		/// an Exodus file.
		/// </summary>
		// Token: 0x0600577F RID: 22399 RVA: 0x0007E580 File Offset: 0x0007C780
		public int GetTimeStepIndex()
		{
			return vtkModelMetadata.vtkModelMetadata_GetTimeStepIndex_70(base.GetCppThis());
		}

		// Token: 0x06005780 RID: 22400
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkModelMetadata_GetTimeStepValues_71(HandleRef pThis);

		/// <summary>
		/// Get the time step values
		/// </summary>
		// Token: 0x06005781 RID: 22401 RVA: 0x0007E5A0 File Offset: 0x0007C7A0
		public IntPtr GetTimeStepValues()
		{
			return vtkModelMetadata.vtkModelMetadata_GetTimeStepValues_71(base.GetCppThis());
		}

		// Token: 0x06005782 RID: 22402
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkModelMetadata_GetTitle_72(HandleRef pThis);

		/// <summary>
		/// The title of the dataset.
		/// </summary>
		// Token: 0x06005783 RID: 22403 RVA: 0x0007E5C0 File Offset: 0x0007C7C0
		public string GetTitle()
		{
			string s = Marshal.PtrToStringAnsi(vtkModelMetadata.vtkModelMetadata_GetTitle_72(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005784 RID: 22404
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkModelMetadata_IsA_73(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005785 RID: 22405 RVA: 0x0007E5FC File Offset: 0x0007C7FC
		public override int IsA(string type)
		{
			return vtkModelMetadata.vtkModelMetadata_IsA_73(base.GetCppThis(), type);
		}

		// Token: 0x06005786 RID: 22406
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkModelMetadata_IsTypeOf_74([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005787 RID: 22407 RVA: 0x0007E61C File Offset: 0x0007C81C
		public new static int IsTypeOf(string type)
		{
			return vtkModelMetadata.vtkModelMetadata_IsTypeOf_74(type);
		}

		// Token: 0x06005788 RID: 22408
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkModelMetadata_NewInstance_76(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005789 RID: 22409 RVA: 0x0007E638 File Offset: 0x0007C838
		public new vtkModelMetadata NewInstance()
		{
			vtkModelMetadata result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkModelMetadata.vtkModelMetadata_NewInstance_76(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkModelMetadata)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600578A RID: 22410
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkModelMetadata_PrintGlobalInformation_77(HandleRef pThis);

		/// <summary>
		/// The global fields are those which pertain to the whole
		/// file.  Examples are the title, information lines,
		/// and list of block IDs.  This method prints out all the
		/// global information.
		/// </summary>
		// Token: 0x0600578B RID: 22411 RVA: 0x0007E692 File Offset: 0x0007C892
		public virtual void PrintGlobalInformation()
		{
			vtkModelMetadata.vtkModelMetadata_PrintGlobalInformation_77(base.GetCppThis());
		}

		// Token: 0x0600578C RID: 22412
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkModelMetadata_PrintLocalInformation_78(HandleRef pThis);

		/// <summary>
		/// The local fields are those which depend on exactly which
		/// blocks, which time step, and which variables you read in
		/// from the file.  Examples are the number of cells in
		/// each block, and the list of nodes in a node set, or the
		/// value of the global variables at a time step.  If
		/// VERBOSE_TESTING is defined in your execution environment,
		/// this method will print more than mere counts, and actually
		/// print a few of the IDs, distribution factors and so on.  If
		/// VERY_VERBOSE_TESTING is defined, it will print out
		/// all ID lists, distribution factor lists, and so on.
		/// </summary>
		// Token: 0x0600578D RID: 22413 RVA: 0x0007E6A1 File Offset: 0x0007C8A1
		public virtual void PrintLocalInformation()
		{
			vtkModelMetadata.vtkModelMetadata_PrintLocalInformation_78(base.GetCppThis());
		}

		// Token: 0x0600578E RID: 22414
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkModelMetadata_Reset_79(HandleRef pThis);

		/// <summary>
		/// Set the object back to it's initial state
		/// </summary>
		// Token: 0x0600578F RID: 22415 RVA: 0x0007E6B0 File Offset: 0x0007C8B0
		public void Reset()
		{
			vtkModelMetadata.vtkModelMetadata_Reset_79(base.GetCppThis());
		}

		// Token: 0x06005790 RID: 22416
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkModelMetadata_SafeDownCast_80(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005791 RID: 22417 RVA: 0x0007E6C0 File Offset: 0x0007C8C0
		public new static vtkModelMetadata SafeDownCast(vtkObjectBase o)
		{
			vtkModelMetadata vtkModelMetadata = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkModelMetadata.vtkModelMetadata_SafeDownCast_80((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkModelMetadata = (vtkModelMetadata)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkModelMetadata.Register(null);
				}
			}
			return vtkModelMetadata;
		}

		// Token: 0x06005792 RID: 22418
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkModelMetadata_SetAllVariablesDefinedInAllBlocks_81(HandleRef pThis, int _arg);

		/// <summary>
		/// Instead of a truth table of all "1"s, you can set this
		/// instance variable to indicate that all variables are
		/// defined in all blocks.
		/// </summary>
		// Token: 0x06005793 RID: 22419 RVA: 0x0007E73F File Offset: 0x0007C93F
		public virtual void SetAllVariablesDefinedInAllBlocks(int _arg)
		{
			vtkModelMetadata.vtkModelMetadata_SetAllVariablesDefinedInAllBlocks_81(base.GetCppThis(), _arg);
		}

		// Token: 0x06005794 RID: 22420
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkModelMetadata_SetBlockAttributes_82(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// Set or get a pointer to a list of the attributes for all
		/// blocks.  The order of the list should be by block, by element
		/// within the block, by attribute.  Omit blocks that don't
		/// have element attributes.
		/// </summary>
		// Token: 0x06005795 RID: 22421 RVA: 0x0007E74F File Offset: 0x0007C94F
		public void SetBlockAttributes(IntPtr arg0)
		{
			vtkModelMetadata.vtkModelMetadata_SetBlockAttributes_82(base.GetCppThis(), arg0);
		}

		// Token: 0x06005796 RID: 22422
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkModelMetadata_SetBlockElementIdList_83(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// Set or get a pointer to a list global element IDs for the
		/// elements in each block.
		/// We use your pointers, and free the memory when the object is freed.
		/// </summary>
		// Token: 0x06005797 RID: 22423 RVA: 0x0007E75F File Offset: 0x0007C95F
		public void SetBlockElementIdList(IntPtr arg0)
		{
			vtkModelMetadata.vtkModelMetadata_SetBlockElementIdList_83(base.GetCppThis(), arg0);
		}

		// Token: 0x06005798 RID: 22424
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkModelMetadata_SetBlockIds_84(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// An arbitrary integer ID for each block.
		/// We use your pointer, and free the memory when the object is freed.
		/// </summary>
		// Token: 0x06005799 RID: 22425 RVA: 0x0007E76F File Offset: 0x0007C96F
		public void SetBlockIds(IntPtr arg0)
		{
			vtkModelMetadata.vtkModelMetadata_SetBlockIds_84(base.GetCppThis(), arg0);
		}

		// Token: 0x0600579A RID: 22426
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkModelMetadata_SetBlockNodesPerElement_85(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// Set or get a pointer to a list of the number of nodes in the
		/// elements of each block.
		/// We use your pointers, and free the memory when the object is freed.
		/// </summary>
		// Token: 0x0600579B RID: 22427 RVA: 0x0007E77F File Offset: 0x0007C97F
		public void SetBlockNodesPerElement(IntPtr arg0)
		{
			vtkModelMetadata.vtkModelMetadata_SetBlockNodesPerElement_85(base.GetCppThis(), arg0);
		}

		// Token: 0x0600579C RID: 22428
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkModelMetadata_SetBlockNumberOfAttributesPerElement_86(HandleRef pThis, IntPtr natts);

		/// <summary>
		/// Set or get a pointer to a list of the number of attributes
		/// stored for the elements in each block.
		/// We use your pointers, and free the memory when the object is freed.
		/// </summary>
		// Token: 0x0600579D RID: 22429 RVA: 0x0007E790 File Offset: 0x0007C990
		public int SetBlockNumberOfAttributesPerElement(IntPtr natts)
		{
			return vtkModelMetadata.vtkModelMetadata_SetBlockNumberOfAttributesPerElement_86(base.GetCppThis(), natts);
		}

		// Token: 0x0600579E RID: 22430
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkModelMetadata_SetBlockNumberOfElements_87(HandleRef pThis, IntPtr nelts);

		/// <summary>
		/// Set or get a pointer to a list of the number of elements in
		/// each block.
		/// We use your pointers, and free the memory when the object is freed.
		/// </summary>
		// Token: 0x0600579F RID: 22431 RVA: 0x0007E7B0 File Offset: 0x0007C9B0
		public int SetBlockNumberOfElements(IntPtr nelts)
		{
			return vtkModelMetadata.vtkModelMetadata_SetBlockNumberOfElements_87(base.GetCppThis(), nelts);
		}

		// Token: 0x060057A0 RID: 22432
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkModelMetadata_SetBlockPropertyValue_88(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// Set or get value for each variable for each block.  List
		/// the integer values in order by variable and within variable
		/// by block.
		/// </summary>
		// Token: 0x060057A1 RID: 22433 RVA: 0x0007E7D0 File Offset: 0x0007C9D0
		public void SetBlockPropertyValue(IntPtr arg0)
		{
			vtkModelMetadata.vtkModelMetadata_SetBlockPropertyValue_88(base.GetCppThis(), arg0);
		}

		// Token: 0x060057A2 RID: 22434
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkModelMetadata_SetElementVariableTruthTable_89(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// A truth table indicating which element variables are
		/// defined for which blocks. The variables are all the original
		/// element variables that were in the file.
		/// The table is by block ID and within block ID by variable.
		/// </summary>
		// Token: 0x060057A3 RID: 22435 RVA: 0x0007E7E0 File Offset: 0x0007C9E0
		public void SetElementVariableTruthTable(IntPtr arg0)
		{
			vtkModelMetadata.vtkModelMetadata_SetElementVariableTruthTable_89(base.GetCppThis(), arg0);
		}

		// Token: 0x060057A4 RID: 22436
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkModelMetadata_SetGlobalVariableValue_90(HandleRef pThis, IntPtr f);

		/// <summary>
		/// Set or get the values of the global variables at the current
		/// time step.
		/// </summary>
		// Token: 0x060057A5 RID: 22437 RVA: 0x0007E7F0 File Offset: 0x0007C9F0
		public void SetGlobalVariableValue(IntPtr f)
		{
			vtkModelMetadata.vtkModelMetadata_SetGlobalVariableValue_90(base.GetCppThis(), f);
		}

		// Token: 0x060057A6 RID: 22438
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkModelMetadata_SetNodeSetDistributionFactors_91(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// Set or get a list of the distribution factors for the node sets.
		/// The list is organized by node set, and within node set by node.
		/// We use your pointer, and free the memory when the object is freed.
		/// </summary>
		// Token: 0x060057A7 RID: 22439 RVA: 0x0007E800 File Offset: 0x0007CA00
		public void SetNodeSetDistributionFactors(IntPtr arg0)
		{
			vtkModelMetadata.vtkModelMetadata_SetNodeSetDistributionFactors_91(base.GetCppThis(), arg0);
		}

		// Token: 0x060057A8 RID: 22440
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkModelMetadata_SetNodeSetIds_92(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// Set or get the list the IDs for each node set.
		/// Length of list is the number of node sets.
		/// We use your pointer, and free the memory when the object is freed.
		/// </summary>
		// Token: 0x060057A9 RID: 22441 RVA: 0x0007E810 File Offset: 0x0007CA10
		public void SetNodeSetIds(IntPtr arg0)
		{
			vtkModelMetadata.vtkModelMetadata_SetNodeSetIds_92(base.GetCppThis(), arg0);
		}

		// Token: 0x060057AA RID: 22442
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkModelMetadata_SetNodeSetNames_93(HandleRef pThis, HandleRef names);

		/// <summary>
		/// The number of node sets in the file.  Set this value before
		/// setting the various node set arrays.
		/// </summary>
		// Token: 0x060057AB RID: 22443 RVA: 0x0007E820 File Offset: 0x0007CA20
		public void SetNodeSetNames(vtkStringArray names)
		{
			vtkModelMetadata.vtkModelMetadata_SetNodeSetNames_93(base.GetCppThis(), (names == null) ? default(HandleRef) : names.GetCppThis());
		}

		// Token: 0x060057AC RID: 22444
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkModelMetadata_SetNodeSetNodeIdList_94(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// Set or get a pointer to a concatenated list of the
		/// IDs of all nodes in each node set.  First list all IDs in
		/// node set 0, then all IDs in node set 1, and so on.
		/// We use your pointer, and free the memory when the object is freed.
		/// </summary>
		// Token: 0x060057AD RID: 22445 RVA: 0x0007E84F File Offset: 0x0007CA4F
		public void SetNodeSetNodeIdList(IntPtr arg0)
		{
			vtkModelMetadata.vtkModelMetadata_SetNodeSetNodeIdList_94(base.GetCppThis(), arg0);
		}

		// Token: 0x060057AE RID: 22446
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkModelMetadata_SetNodeSetNumberOfDistributionFactors_95(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// Set or get a list of the number of distribution factors stored
		/// by each node set.  This is either 0 or equal to the number of
		/// nodes in the node set.
		/// Length of list is number of node sets.
		/// We use your pointer, and free the memory when the object is freed.
		/// </summary>
		// Token: 0x060057AF RID: 22447 RVA: 0x0007E85F File Offset: 0x0007CA5F
		public void SetNodeSetNumberOfDistributionFactors(IntPtr arg0)
		{
			vtkModelMetadata.vtkModelMetadata_SetNodeSetNumberOfDistributionFactors_95(base.GetCppThis(), arg0);
		}

		// Token: 0x060057B0 RID: 22448
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkModelMetadata_SetNodeSetPropertyValue_96(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// Set or get value for each variable for each node set.  List
		/// the integer values in order by variable and within variable
		/// by node set.
		/// </summary>
		// Token: 0x060057B1 RID: 22449 RVA: 0x0007E86F File Offset: 0x0007CA6F
		public void SetNodeSetPropertyValue(IntPtr arg0)
		{
			vtkModelMetadata.vtkModelMetadata_SetNodeSetPropertyValue_96(base.GetCppThis(), arg0);
		}

		// Token: 0x060057B2 RID: 22450
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkModelMetadata_SetNodeSetSize_97(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// Set or get a pointer to a list of the number of nodes in each node set.
		/// We use your pointer, and free the memory when the object is freed.
		/// </summary>
		// Token: 0x060057B3 RID: 22451 RVA: 0x0007E87F File Offset: 0x0007CA7F
		public void SetNodeSetSize(IntPtr arg0)
		{
			vtkModelMetadata.vtkModelMetadata_SetNodeSetSize_97(base.GetCppThis(), arg0);
		}

		// Token: 0x060057B4 RID: 22452
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkModelMetadata_SetNumberOfBlocks_98(HandleRef pThis, int _arg);

		/// <summary>
		/// The number of blocks in the file.  Set this before setting
		/// any of the block arrays.
		/// </summary>
		// Token: 0x060057B5 RID: 22453 RVA: 0x0007E88F File Offset: 0x0007CA8F
		public virtual void SetNumberOfBlocks(int _arg)
		{
			vtkModelMetadata.vtkModelMetadata_SetNumberOfBlocks_98(base.GetCppThis(), _arg);
		}

		// Token: 0x060057B6 RID: 22454
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkModelMetadata_SetNumberOfNodeSets_99(HandleRef pThis, int _arg);

		/// <summary>
		/// The number of node sets in the file.  Set this value before
		/// setting the various node set arrays.
		/// </summary>
		// Token: 0x060057B7 RID: 22455 RVA: 0x0007E89F File Offset: 0x0007CA9F
		public virtual void SetNumberOfNodeSets(int _arg)
		{
			vtkModelMetadata.vtkModelMetadata_SetNumberOfNodeSets_99(base.GetCppThis(), _arg);
		}

		// Token: 0x060057B8 RID: 22456
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkModelMetadata_SetNumberOfSideSets_100(HandleRef pThis, int _arg);

		/// <summary>
		/// Set or get the number of side sets.  Set this value before
		/// setting any of the other side set arrays.
		/// </summary>
		// Token: 0x060057B9 RID: 22457 RVA: 0x0007E8AF File Offset: 0x0007CAAF
		public virtual void SetNumberOfSideSets(int _arg)
		{
			vtkModelMetadata.vtkModelMetadata_SetNumberOfSideSets_100(base.GetCppThis(), _arg);
		}

		// Token: 0x060057BA RID: 22458
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkModelMetadata_SetSideSetDistributionFactors_101(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// Set or get a pointer to a list of all the distribution factors.
		/// For every side set that has distribution factors, the number of
		/// factors per node was given in the SideSetNumberOfDistributionFactors
		/// array.  If this number for a given side set is N, then for that
		/// side set we have N floating point values for each node for each
		/// side in the side set.  If nodes are repeated in more than one
		/// side, we repeat the distribution factors.  So this list is in order
		/// by side set, by node.
		/// We use your pointer, and free the memory when the object is freed.
		/// </summary>
		// Token: 0x060057BB RID: 22459 RVA: 0x0007E8BF File Offset: 0x0007CABF
		public void SetSideSetDistributionFactors(IntPtr arg0)
		{
			vtkModelMetadata.vtkModelMetadata_SetSideSetDistributionFactors_101(base.GetCppThis(), arg0);
		}

		// Token: 0x060057BC RID: 22460
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkModelMetadata_SetSideSetElementList_102(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// Set or get a pointer to a list of the elements containing each
		/// side in each side set.  The list is organized by side set, and
		/// within side set by element.
		/// We use your pointer, and free the memory when the object is freed.
		/// </summary>
		// Token: 0x060057BD RID: 22461 RVA: 0x0007E8CF File Offset: 0x0007CACF
		public void SetSideSetElementList(IntPtr arg0)
		{
			vtkModelMetadata.vtkModelMetadata_SetSideSetElementList_102(base.GetCppThis(), arg0);
		}

		// Token: 0x060057BE RID: 22462
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkModelMetadata_SetSideSetIds_103(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// Set or get a pointer to a list giving the ID of each side set.
		/// We use your pointer, and free the memory when the object is freed.
		/// </summary>
		// Token: 0x060057BF RID: 22463 RVA: 0x0007E8DF File Offset: 0x0007CADF
		public void SetSideSetIds(IntPtr arg0)
		{
			vtkModelMetadata.vtkModelMetadata_SetSideSetIds_103(base.GetCppThis(), arg0);
		}

		// Token: 0x060057C0 RID: 22464
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkModelMetadata_SetSideSetNames_104(HandleRef pThis, HandleRef names);

		/// <summary>
		/// Set or get the number of side sets.  Set this value before
		/// setting any of the other side set arrays.
		/// </summary>
		// Token: 0x060057C1 RID: 22465 RVA: 0x0007E8F0 File Offset: 0x0007CAF0
		public void SetSideSetNames(vtkStringArray names)
		{
			vtkModelMetadata.vtkModelMetadata_SetSideSetNames_104(base.GetCppThis(), (names == null) ? default(HandleRef) : names.GetCppThis());
		}

		// Token: 0x060057C2 RID: 22466
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkModelMetadata_SetSideSetNumDFPerSide_105(HandleRef pThis, IntPtr numNodes);

		/// <summary>
		/// Set or get a pointer to a list of the number of nodes in each
		/// side of each side set.  This list is organized by side set, and
		/// within side set by side.
		/// We use your pointer, and free the memory when the object is freed.
		/// </summary>
		// Token: 0x060057C3 RID: 22467 RVA: 0x0007E91F File Offset: 0x0007CB1F
		public void SetSideSetNumDFPerSide(IntPtr numNodes)
		{
			vtkModelMetadata.vtkModelMetadata_SetSideSetNumDFPerSide_105(base.GetCppThis(), numNodes);
		}

		// Token: 0x060057C4 RID: 22468
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkModelMetadata_SetSideSetNumberOfDistributionFactors_106(HandleRef pThis, IntPtr df);

		/// <summary>
		/// Set or get a pointer to a list of the number of distribution
		/// factors stored by each side set.   Each side set has either
		/// no distribution factors, or 1 per node in the side set.
		/// We use your pointer, and free the memory when the object is freed.
		/// </summary>
		// Token: 0x060057C5 RID: 22469 RVA: 0x0007E930 File Offset: 0x0007CB30
		public int SetSideSetNumberOfDistributionFactors(IntPtr df)
		{
			return vtkModelMetadata.vtkModelMetadata_SetSideSetNumberOfDistributionFactors_106(base.GetCppThis(), df);
		}

		// Token: 0x060057C6 RID: 22470
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkModelMetadata_SetSideSetPropertyValue_107(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// Set or get value for each variable for each side set.  List
		/// the integer values in order by variable and within variable
		/// by side set.
		/// </summary>
		// Token: 0x060057C7 RID: 22471 RVA: 0x0007E950 File Offset: 0x0007CB50
		public void SetSideSetPropertyValue(IntPtr arg0)
		{
			vtkModelMetadata.vtkModelMetadata_SetSideSetPropertyValue_107(base.GetCppThis(), arg0);
		}

		// Token: 0x060057C8 RID: 22472
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkModelMetadata_SetSideSetSideList_108(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// Set or get a pointer to the element side for each side in the side set.
		/// (See the manual for the convention for numbering sides in different
		/// types of cells.)  Side Ids are arranged by side set and within
		/// side set by side, and correspond to the SideSetElementList.
		/// We use your pointer, and free the memory when the object is freed.
		/// </summary>
		// Token: 0x060057C9 RID: 22473 RVA: 0x0007E960 File Offset: 0x0007CB60
		public void SetSideSetSideList(IntPtr arg0)
		{
			vtkModelMetadata.vtkModelMetadata_SetSideSetSideList_108(base.GetCppThis(), arg0);
		}

		// Token: 0x060057CA RID: 22474
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkModelMetadata_SetSideSetSize_109(HandleRef pThis, IntPtr sizes);

		/// <summary>
		/// Set or get a pointer to a list of the number of sides in each side set.
		/// We use your pointer, and free the memory when the object is freed.
		/// </summary>
		// Token: 0x060057CB RID: 22475 RVA: 0x0007E970 File Offset: 0x0007CB70
		public int SetSideSetSize(IntPtr sizes)
		{
			return vtkModelMetadata.vtkModelMetadata_SetSideSetSize_109(base.GetCppThis(), sizes);
		}

		// Token: 0x060057CC RID: 22476
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkModelMetadata_SetSumNodesPerNodeSet_110(HandleRef pThis, int _arg);

		/// <summary>
		/// Get the total number of nodes in all node sets
		/// </summary>
		// Token: 0x060057CD RID: 22477 RVA: 0x0007E990 File Offset: 0x0007CB90
		public virtual void SetSumNodesPerNodeSet(int _arg)
		{
			vtkModelMetadata.vtkModelMetadata_SetSumNodesPerNodeSet_110(base.GetCppThis(), _arg);
		}

		// Token: 0x060057CE RID: 22478
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkModelMetadata_SetSumSidesPerSideSet_111(HandleRef pThis, int _arg);

		/// <summary>
		/// Get the total number of sides in all side sets
		/// </summary>
		// Token: 0x060057CF RID: 22479 RVA: 0x0007E9A0 File Offset: 0x0007CBA0
		public virtual void SetSumSidesPerSideSet(int _arg)
		{
			vtkModelMetadata.vtkModelMetadata_SetSumSidesPerSideSet_111(base.GetCppThis(), _arg);
		}

		// Token: 0x060057D0 RID: 22480
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkModelMetadata_SetTimeStepIndex_112(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the index of the time step represented by the results
		/// data in the file attached to this ModelMetadata object.  Time
		/// step indices start at 0 in this file, they start at 1 in
		/// an Exodus file.
		/// </summary>
		// Token: 0x060057D1 RID: 22481 RVA: 0x0007E9B0 File Offset: 0x0007CBB0
		public virtual void SetTimeStepIndex(int _arg)
		{
			vtkModelMetadata.vtkModelMetadata_SetTimeStepIndex_112(base.GetCppThis(), _arg);
		}

		// Token: 0x060057D2 RID: 22482
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkModelMetadata_SetTimeSteps_113(HandleRef pThis, int numberOfTimeSteps, IntPtr timeStepValues);

		/// <summary>
		/// Set the total number of time steps in the file,
		/// and the value at each time step.  We use your time
		/// step value array and delete it when we're done.
		/// </summary>
		// Token: 0x060057D3 RID: 22483 RVA: 0x0007E9C0 File Offset: 0x0007CBC0
		public void SetTimeSteps(int numberOfTimeSteps, IntPtr timeStepValues)
		{
			vtkModelMetadata.vtkModelMetadata_SetTimeSteps_113(base.GetCppThis(), numberOfTimeSteps, timeStepValues);
		}

		// Token: 0x060057D4 RID: 22484
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkModelMetadata_SetTitle_114(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The title of the dataset.
		/// </summary>
		// Token: 0x060057D5 RID: 22485 RVA: 0x0007E9D1 File Offset: 0x0007CBD1
		public virtual void SetTitle(string _arg)
		{
			vtkModelMetadata.vtkModelMetadata_SetTitle_114(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400081B RID: 2075
		public new const string MRFullTypeName = "Kitware.VTK.vtkModelMetadata";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400081C RID: 2076
		public new static readonly string MRClassNameKey = "class vtkModelMetadata";
	}
}
