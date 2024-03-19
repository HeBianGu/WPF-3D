using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMultiBlockDataSet
	/// </summary>
	/// <remarks>
	///    Composite dataset that organizes datasets into
	/// blocks.
	///
	/// vtkMultiBlockDataSet is a vtkCompositeDataSet that stores
	/// a hierarchy of datasets. The dataset collection consists of
	/// multiple blocks. Each block can itself be a vtkMultiBlockDataSet, thus
	/// providing for a full tree structure.
	/// Sub-blocks are usually used to distribute blocks across processors.
	/// For example, a 1 block dataset can be distributed as following:
	/// @verbatim
	/// proc 0:
	/// Block 0:
	///   * ds 0
	///   * (null)
	///
	/// proc 1:
	/// Block 0:
	///   * (null)
	///   * ds 1
	/// @endverbatim
	/// </remarks>
	// Token: 0x02000A84 RID: 2692
	public class vtkMultiBlockDataSet : vtkDataObjectTree
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601C322 RID: 115490 RVA: 0x00279273 File Offset: 0x00277473
		static vtkMultiBlockDataSet()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMultiBlockDataSet.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMultiBlockDataSet"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601C323 RID: 115491 RVA: 0x0027929B File Offset: 0x0027749B
		public vtkMultiBlockDataSet(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601C324 RID: 115492
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiBlockDataSet_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C325 RID: 115493 RVA: 0x002792AC File Offset: 0x002774AC
		public new static vtkMultiBlockDataSet New()
		{
			vtkMultiBlockDataSet result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiBlockDataSet.vtkMultiBlockDataSet_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMultiBlockDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C326 RID: 115494 RVA: 0x00279300 File Offset: 0x00277500
		public vtkMultiBlockDataSet() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMultiBlockDataSet.vtkMultiBlockDataSet_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601C327 RID: 115495 RVA: 0x00279344 File Offset: 0x00277544
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601C328 RID: 115496
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiBlockDataSet_GetBlock_01(HandleRef pThis, uint blockno, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the block at the given index. It is recommended that one uses the
		/// iterators to iterate over composite datasets rather than using this API.
		/// </summary>
		// Token: 0x0601C329 RID: 115497 RVA: 0x00279350 File Offset: 0x00277550
		public vtkDataObject GetBlock(uint blockno)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiBlockDataSet.vtkMultiBlockDataSet_GetBlock_01(base.GetCppThis(), blockno, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601C32A RID: 115498
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiBlockDataSet_GetData_02(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x0601C32B RID: 115499 RVA: 0x002793C0 File Offset: 0x002775C0
		public new static vtkMultiBlockDataSet GetData(vtkInformation info)
		{
			vtkMultiBlockDataSet vtkMultiBlockDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiBlockDataSet.vtkMultiBlockDataSet_GetData_02((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiBlockDataSet = (vtkMultiBlockDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiBlockDataSet.Register(null);
				}
			}
			return vtkMultiBlockDataSet;
		}

		// Token: 0x0601C32C RID: 115500
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiBlockDataSet_GetData_03(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x0601C32D RID: 115501 RVA: 0x00279440 File Offset: 0x00277640
		public new static vtkMultiBlockDataSet GetData(vtkInformationVector v, int i)
		{
			vtkMultiBlockDataSet vtkMultiBlockDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiBlockDataSet.vtkMultiBlockDataSet_GetData_03((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiBlockDataSet = (vtkMultiBlockDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiBlockDataSet.Register(null);
				}
			}
			return vtkMultiBlockDataSet;
		}

		// Token: 0x0601C32E RID: 115502
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiBlockDataSet_GetDataObjectType_04(HandleRef pThis);

		/// <summary>
		/// Return class name of data type (see vtkType.h for
		/// definitions).
		/// </summary>
		// Token: 0x0601C32F RID: 115503 RVA: 0x002794C0 File Offset: 0x002776C0
		public override int GetDataObjectType()
		{
			return vtkMultiBlockDataSet.vtkMultiBlockDataSet_GetDataObjectType_04(base.GetCppThis());
		}

		// Token: 0x0601C330 RID: 115504
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiBlockDataSet_GetMetaData_05(HandleRef pThis, uint blockno, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the meta-data for the block. If none is already present, a new
		/// vtkInformation object will be allocated. Use HasMetaData to avoid
		/// allocating vtkInformation objects.
		/// </summary>
		// Token: 0x0601C331 RID: 115505 RVA: 0x002794E0 File Offset: 0x002776E0
		public vtkInformation GetMetaData(uint blockno)
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiBlockDataSet.vtkMultiBlockDataSet_GetMetaData_05(base.GetCppThis(), blockno, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601C332 RID: 115506
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiBlockDataSet_GetMetaData_06(HandleRef pThis, HandleRef iter, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Unhiding superclass method.
		/// </summary>
		// Token: 0x0601C333 RID: 115507 RVA: 0x00279550 File Offset: 0x00277750
		public override vtkInformation GetMetaData(vtkCompositeDataIterator iter)
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiBlockDataSet.vtkMultiBlockDataSet_GetMetaData_06(base.GetCppThis(), (iter == null) ? default(HandleRef) : iter.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601C334 RID: 115508
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkMultiBlockDataSet_GetNumberOfBlocks_07(HandleRef pThis);

		/// <summary>
		/// Returns the number of blocks.
		/// </summary>
		// Token: 0x0601C335 RID: 115509 RVA: 0x002795D8 File Offset: 0x002777D8
		public uint GetNumberOfBlocks()
		{
			return vtkMultiBlockDataSet.vtkMultiBlockDataSet_GetNumberOfBlocks_07(base.GetCppThis());
		}

		// Token: 0x0601C336 RID: 115510
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMultiBlockDataSet_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C337 RID: 115511 RVA: 0x002795F8 File Offset: 0x002777F8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMultiBlockDataSet.vtkMultiBlockDataSet_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x0601C338 RID: 115512
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMultiBlockDataSet_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C339 RID: 115513 RVA: 0x00279618 File Offset: 0x00277818
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMultiBlockDataSet.vtkMultiBlockDataSet_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x0601C33A RID: 115514
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiBlockDataSet_HasMetaData_10(HandleRef pThis, uint blockno);

		/// <summary>
		/// Returns true if meta-data is available for a given block.
		/// </summary>
		// Token: 0x0601C33B RID: 115515 RVA: 0x00279634 File Offset: 0x00277834
		public int HasMetaData(uint blockno)
		{
			return vtkMultiBlockDataSet.vtkMultiBlockDataSet_HasMetaData_10(base.GetCppThis(), blockno);
		}

		// Token: 0x0601C33C RID: 115516
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiBlockDataSet_HasMetaData_11(HandleRef pThis, HandleRef iter);

		/// <summary>
		/// Unhiding superclass method.
		/// </summary>
		// Token: 0x0601C33D RID: 115517 RVA: 0x00279654 File Offset: 0x00277854
		public override int HasMetaData(vtkCompositeDataIterator iter)
		{
			return vtkMultiBlockDataSet.vtkMultiBlockDataSet_HasMetaData_11(base.GetCppThis(), (iter == null) ? default(HandleRef) : iter.GetCppThis());
		}

		// Token: 0x0601C33E RID: 115518
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiBlockDataSet_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C33F RID: 115519 RVA: 0x00279688 File Offset: 0x00277888
		public override int IsA(string type)
		{
			return vtkMultiBlockDataSet.vtkMultiBlockDataSet_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x0601C340 RID: 115520
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiBlockDataSet_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C341 RID: 115521 RVA: 0x002796A8 File Offset: 0x002778A8
		public new static int IsTypeOf(string type)
		{
			return vtkMultiBlockDataSet.vtkMultiBlockDataSet_IsTypeOf_13(type);
		}

		// Token: 0x0601C342 RID: 115522
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiBlockDataSet_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C343 RID: 115523 RVA: 0x002796C4 File Offset: 0x002778C4
		public new vtkMultiBlockDataSet NewInstance()
		{
			vtkMultiBlockDataSet result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiBlockDataSet.vtkMultiBlockDataSet_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMultiBlockDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601C344 RID: 115524
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockDataSet_RemoveBlock_16(HandleRef pThis, uint blockno);

		/// <summary>
		/// Remove the given block from the dataset.
		/// </summary>
		// Token: 0x0601C345 RID: 115525 RVA: 0x0027971E File Offset: 0x0027791E
		public void RemoveBlock(uint blockno)
		{
			vtkMultiBlockDataSet.vtkMultiBlockDataSet_RemoveBlock_16(base.GetCppThis(), blockno);
		}

		// Token: 0x0601C346 RID: 115526
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiBlockDataSet_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C347 RID: 115527 RVA: 0x00279730 File Offset: 0x00277930
		public new static vtkMultiBlockDataSet SafeDownCast(vtkObjectBase o)
		{
			vtkMultiBlockDataSet vtkMultiBlockDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiBlockDataSet.vtkMultiBlockDataSet_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiBlockDataSet = (vtkMultiBlockDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiBlockDataSet.Register(null);
				}
			}
			return vtkMultiBlockDataSet;
		}

		// Token: 0x0601C348 RID: 115528
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockDataSet_SetBlock_18(HandleRef pThis, uint blockno, HandleRef block);

		/// <summary>
		/// Sets the data object as the given block. The total number of blocks will
		/// be resized to fit the requested block no.
		///
		/// @remark while most vtkDataObject subclasses, including vtkMultiBlockDataSet
		/// as acceptable as a block, `vtkPartitionedDataSet`,
		/// `vtkPartitionedDataSetCollection`, and `vtkUniformGridAMR`
		/// are not valid.
		/// </summary>
		// Token: 0x0601C349 RID: 115529 RVA: 0x002797B0 File Offset: 0x002779B0
		public void SetBlock(uint blockno, vtkDataObject block)
		{
			vtkMultiBlockDataSet.vtkMultiBlockDataSet_SetBlock_18(base.GetCppThis(), blockno, (block == null) ? default(HandleRef) : block.GetCppThis());
		}

		// Token: 0x0601C34A RID: 115530
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockDataSet_SetNumberOfBlocks_19(HandleRef pThis, uint numBlocks);

		/// <summary>
		/// Set the number of blocks. This will cause allocation if the new number of
		/// blocks is greater than the current size. All new blocks are initialized to
		/// null.
		/// </summary>
		// Token: 0x0601C34B RID: 115531 RVA: 0x002797E0 File Offset: 0x002779E0
		public void SetNumberOfBlocks(uint numBlocks)
		{
			vtkMultiBlockDataSet.vtkMultiBlockDataSet_SetNumberOfBlocks_19(base.GetCppThis(), numBlocks);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E04 RID: 7684
		public new const string MRFullTypeName = "Kitware.VTK.vtkMultiBlockDataSet";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E05 RID: 7685
		public new static readonly string MRClassNameKey = "class vtkMultiBlockDataSet";
	}
}
