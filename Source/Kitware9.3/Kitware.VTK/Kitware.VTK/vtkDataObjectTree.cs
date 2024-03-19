using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDataObjectTree
	/// </summary>
	/// <remarks>
	///    provides implementation for most abstract
	/// methods in the superclass vtkCompositeDataSet
	///
	/// vtkDataObjectTree is represents a collection
	/// of datasets (including other composite datasets). It
	/// provides an interface to access the datasets through iterators.
	/// vtkDataObjectTree provides methods that are used by subclasses to store the
	/// datasets.
	/// vtkDataObjectTree provides the datastructure for a full tree
	/// representation. Subclasses provide the semantics for it and control how
	/// this tree is built.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkDataObjectTreeIterator
	/// </seealso>
	// Token: 0x02000A3A RID: 2618
	public class vtkDataObjectTree : vtkCompositeDataSet
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601B460 RID: 111712 RVA: 0x00261C4B File Offset: 0x0025FE4B
		static vtkDataObjectTree()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataObjectTree.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataObjectTree"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601B461 RID: 111713 RVA: 0x00261C73 File Offset: 0x0025FE73
		public vtkDataObjectTree(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601B462 RID: 111714 RVA: 0x00261C81 File Offset: 0x0025FE81
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601B463 RID: 111715
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectTree_CompositeShallowCopy_01(HandleRef pThis, HandleRef src);

		/// <summary>
		/// CompositeShallow, Shallow and Deep copy.
		/// </summary>
		// Token: 0x0601B464 RID: 111716 RVA: 0x00261C8C File Offset: 0x0025FE8C
		public override void CompositeShallowCopy(vtkCompositeDataSet src)
		{
			vtkDataObjectTree.vtkDataObjectTree_CompositeShallowCopy_01(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		// Token: 0x0601B465 RID: 111717
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectTree_CopyStructure_02(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Copies the tree structure from the input. All pointers to non-composite
		/// data objects are initialized to nullptr. This also shallow copies the meta data
		/// associated with all the nodes.
		/// </summary>
		// Token: 0x0601B466 RID: 111718 RVA: 0x00261CBC File Offset: 0x0025FEBC
		public override void CopyStructure(vtkCompositeDataSet input)
		{
			vtkDataObjectTree.vtkDataObjectTree_CopyStructure_02(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x0601B467 RID: 111719
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectTree_DeepCopy_03(HandleRef pThis, HandleRef src);

		/// <summary>
		/// CompositeShallow, Shallow and Deep copy.
		/// </summary>
		// Token: 0x0601B468 RID: 111720 RVA: 0x00261CEC File Offset: 0x0025FEEC
		public override void DeepCopy(vtkDataObject src)
		{
			vtkDataObjectTree.vtkDataObjectTree_DeepCopy_03(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		// Token: 0x0601B469 RID: 111721
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkDataObjectTree_GetActualMemorySize_04(HandleRef pThis);

		/// <summary>
		/// Return the actual size of the data in kibibytes (1024 bytes). This number
		/// is valid only after the pipeline has updated.
		/// </summary>
		// Token: 0x0601B46A RID: 111722 RVA: 0x00261D1C File Offset: 0x0025FF1C
		public override uint GetActualMemorySize()
		{
			return vtkDataObjectTree.vtkDataObjectTree_GetActualMemorySize_04(base.GetCppThis());
		}

		// Token: 0x0601B46B RID: 111723
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectTree_GetData_05(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x0601B46C RID: 111724 RVA: 0x00261D3C File Offset: 0x0025FF3C
		public new static vtkDataObjectTree GetData(vtkInformation info)
		{
			vtkDataObjectTree vtkDataObjectTree = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectTree.vtkDataObjectTree_GetData_05((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObjectTree = (vtkDataObjectTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObjectTree.Register(null);
				}
			}
			return vtkDataObjectTree;
		}

		// Token: 0x0601B46D RID: 111725
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectTree_GetData_06(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x0601B46E RID: 111726 RVA: 0x00261DBC File Offset: 0x0025FFBC
		public new static vtkDataObjectTree GetData(vtkInformationVector v, int i)
		{
			vtkDataObjectTree vtkDataObjectTree = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectTree.vtkDataObjectTree_GetData_06((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObjectTree = (vtkDataObjectTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObjectTree.Register(null);
				}
			}
			return vtkDataObjectTree;
		}

		// Token: 0x0601B46F RID: 111727
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectTree_GetDataObjectType_07(HandleRef pThis);

		/// <summary>
		/// Overridden to return `VTK_DATA_OBJECT_TREE`.
		/// </summary>
		// Token: 0x0601B470 RID: 111728 RVA: 0x00261E3C File Offset: 0x0026003C
		public override int GetDataObjectType()
		{
			return vtkDataObjectTree.vtkDataObjectTree_GetDataObjectType_07(base.GetCppThis());
		}

		// Token: 0x0601B471 RID: 111729
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectTree_GetDataSet_08(HandleRef pThis, HandleRef iter, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the dataset located at the position pointed by the iterator.
		/// The iterator does not need to be iterating over this dataset itself. It can
		/// be an iterator for composite dataset with similar structure (achieved by
		/// using CopyStructure).
		/// </summary>
		// Token: 0x0601B472 RID: 111730 RVA: 0x00261E5C File Offset: 0x0026005C
		public override vtkDataObject GetDataSet(vtkCompositeDataIterator iter)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectTree.vtkDataObjectTree_GetDataSet_08(base.GetCppThis(), (iter == null) ? default(HandleRef) : iter.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		// Token: 0x0601B473 RID: 111731
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectTree_GetMetaData_09(HandleRef pThis, HandleRef iter, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the meta-data associated with the position pointed by the iterator.
		/// This will create a new vtkInformation object if none already exists. Use
		/// HasMetaData to avoid creating the vtkInformation object unnecessarily.
		/// The iterator does not need to be iterating over this dataset itself. It can
		/// be an iterator for composite dataset with similar structure (achieved by
		/// using CopyStructure).
		/// </summary>
		// Token: 0x0601B474 RID: 111732 RVA: 0x00261EE4 File Offset: 0x002600E4
		public virtual vtkInformation GetMetaData(vtkCompositeDataIterator iter)
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectTree.vtkDataObjectTree_GetMetaData_09(base.GetCppThis(), (iter == null) ? default(HandleRef) : iter.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformation = (vtkInformation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformation.Register(null);
				}
			}
			return vtkInformation;
		}

		// Token: 0x0601B475 RID: 111733
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataObjectTree_GetNumberOfCells_10(HandleRef pThis);

		/// <summary>
		/// Returns the total number of cells of all blocks. This will
		/// iterate over all blocks and call GetNumberOfPoints() so it
		/// might be expensive.
		/// </summary>
		// Token: 0x0601B476 RID: 111734 RVA: 0x00261F6C File Offset: 0x0026016C
		public override long GetNumberOfCells()
		{
			return vtkDataObjectTree.vtkDataObjectTree_GetNumberOfCells_10(base.GetCppThis());
		}

		// Token: 0x0601B477 RID: 111735
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataObjectTree_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B478 RID: 111736 RVA: 0x00261F8C File Offset: 0x0026018C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDataObjectTree.vtkDataObjectTree_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x0601B479 RID: 111737
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataObjectTree_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B47A RID: 111738 RVA: 0x00261FAC File Offset: 0x002601AC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDataObjectTree.vtkDataObjectTree_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x0601B47B RID: 111739
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataObjectTree_GetNumberOfPoints_13(HandleRef pThis);

		/// <summary>
		/// Returns the total number of points of all blocks. This will
		/// iterate over all blocks and call GetNumberOfPoints() so it
		/// might be expansive.
		/// </summary>
		// Token: 0x0601B47C RID: 111740 RVA: 0x00261FC8 File Offset: 0x002601C8
		public override long GetNumberOfPoints()
		{
			return vtkDataObjectTree.vtkDataObjectTree_GetNumberOfPoints_13(base.GetCppThis());
		}

		// Token: 0x0601B47D RID: 111741
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectTree_HasMetaData_14(HandleRef pThis, HandleRef iter);

		/// <summary>
		/// Returns if any meta-data associated with the position pointed by the iterator.
		/// The iterator does not need to be iterating over this dataset itself. It can
		/// be an iterator for composite dataset with similar structure (achieved by
		/// using CopyStructure).
		/// </summary>
		// Token: 0x0601B47E RID: 111742 RVA: 0x00261FE8 File Offset: 0x002601E8
		public virtual int HasMetaData(vtkCompositeDataIterator iter)
		{
			return vtkDataObjectTree.vtkDataObjectTree_HasMetaData_14(base.GetCppThis(), (iter == null) ? default(HandleRef) : iter.GetCppThis());
		}

		// Token: 0x0601B47F RID: 111743
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectTree_Initialize_15(HandleRef pThis);

		/// <summary>
		/// Restore data object to initial state,
		/// </summary>
		// Token: 0x0601B480 RID: 111744 RVA: 0x0026201C File Offset: 0x0026021C
		public override void Initialize()
		{
			vtkDataObjectTree.vtkDataObjectTree_Initialize_15(base.GetCppThis());
		}

		// Token: 0x0601B481 RID: 111745
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectTree_IsA_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B482 RID: 111746 RVA: 0x0026202C File Offset: 0x0026022C
		public override int IsA(string type)
		{
			return vtkDataObjectTree.vtkDataObjectTree_IsA_16(base.GetCppThis(), type);
		}

		// Token: 0x0601B483 RID: 111747
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectTree_IsTypeOf_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B484 RID: 111748 RVA: 0x0026204C File Offset: 0x0026024C
		public new static int IsTypeOf(string type)
		{
			return vtkDataObjectTree.vtkDataObjectTree_IsTypeOf_17(type);
		}

		// Token: 0x0601B485 RID: 111749
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectTree_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B486 RID: 111750 RVA: 0x00262068 File Offset: 0x00260268
		public new vtkDataObjectTree NewInstance()
		{
			vtkDataObjectTree result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectTree.vtkDataObjectTree_NewInstance_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataObjectTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601B487 RID: 111751
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectTree_NewIterator_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return a new iterator (the iterator has to be deleted by user).
		///
		/// Use NewTreeIterator when you have a pointer to a vtkDataObjectTree
		/// and NewIterator when you have a pointer to a vtkCompositeDataSet;
		/// NewIterator is inherited and calls NewTreeIterator internally.
		/// </summary>
		// Token: 0x0601B488 RID: 111752 RVA: 0x002620C4 File Offset: 0x002602C4
		public override vtkCompositeDataIterator NewIterator()
		{
			vtkCompositeDataIterator vtkCompositeDataIterator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectTree.vtkDataObjectTree_NewIterator_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositeDataIterator = (vtkCompositeDataIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositeDataIterator.Register(null);
				}
			}
			return vtkCompositeDataIterator;
		}

		// Token: 0x0601B489 RID: 111753
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectTree_NewTreeIterator_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return a new iterator (the iterator has to be deleted by user).
		/// </summary>
		// Token: 0x0601B48A RID: 111754 RVA: 0x00262134 File Offset: 0x00260334
		public virtual vtkDataObjectTreeIterator NewTreeIterator()
		{
			vtkDataObjectTreeIterator vtkDataObjectTreeIterator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectTree.vtkDataObjectTree_NewTreeIterator_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObjectTreeIterator = (vtkDataObjectTreeIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObjectTreeIterator.Register(null);
				}
			}
			return vtkDataObjectTreeIterator;
		}

		// Token: 0x0601B48B RID: 111755
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectTree_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B48C RID: 111756 RVA: 0x002621A4 File Offset: 0x002603A4
		public new static vtkDataObjectTree SafeDownCast(vtkObjectBase o)
		{
			vtkDataObjectTree vtkDataObjectTree = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectTree.vtkDataObjectTree_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObjectTree = (vtkDataObjectTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObjectTree.Register(null);
				}
			}
			return vtkDataObjectTree;
		}

		// Token: 0x0601B48D RID: 111757
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectTree_SetDataSet_22(HandleRef pThis, HandleRef iter, HandleRef dataObj);

		/// <summary>
		/// Sets the data set at the location pointed by the iterator.
		/// The iterator does not need to be iterating over this dataset itself. It can
		/// be any composite datasite with similar structure (achieved by using
		/// CopyStructure).
		/// </summary>
		// Token: 0x0601B48E RID: 111758 RVA: 0x00262224 File Offset: 0x00260424
		public override void SetDataSet(vtkCompositeDataIterator iter, vtkDataObject dataObj)
		{
			vtkDataObjectTree.vtkDataObjectTree_SetDataSet_22(base.GetCppThis(), (iter == null) ? default(HandleRef) : iter.GetCppThis(), (dataObj == null) ? default(HandleRef) : dataObj.GetCppThis());
		}

		// Token: 0x0601B48F RID: 111759
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectTree_SetDataSetFrom_23(HandleRef pThis, HandleRef iter, HandleRef dataObj);

		/// <summary>
		/// Sets the data at the location provided by a vtkDataObjectTreeIterator
		/// </summary>
		// Token: 0x0601B490 RID: 111760 RVA: 0x00262268 File Offset: 0x00260468
		public void SetDataSetFrom(vtkDataObjectTreeIterator iter, vtkDataObject dataObj)
		{
			vtkDataObjectTree.vtkDataObjectTree_SetDataSetFrom_23(base.GetCppThis(), (iter == null) ? default(HandleRef) : iter.GetCppThis(), (dataObj == null) ? default(HandleRef) : dataObj.GetCppThis());
		}

		// Token: 0x0601B491 RID: 111761
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectTree_ShallowCopy_24(HandleRef pThis, HandleRef src);

		/// <summary>
		/// CompositeShallow, Shallow and Deep copy.
		/// </summary>
		// Token: 0x0601B492 RID: 111762 RVA: 0x002622AC File Offset: 0x002604AC
		public override void ShallowCopy(vtkDataObject src)
		{
			vtkDataObjectTree.vtkDataObjectTree_ShallowCopy_24(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D68 RID: 7528
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataObjectTree";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D69 RID: 7529
		public new static readonly string MRClassNameKey = "class vtkDataObjectTree";
	}
}
