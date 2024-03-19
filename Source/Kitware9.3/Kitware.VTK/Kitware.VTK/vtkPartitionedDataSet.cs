using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPartitionedDataSet
	/// </summary>
	/// <remarks>
	///    composite dataset to encapsulates a dataset consisting of
	/// partitions.
	///
	/// A vtkPartitionedDataSet dataset groups multiple datasets together.
	/// For example, say a simulation running in parallel on 16 processes
	/// generated 16 datasets that when considering together form a whole
	/// dataset. These are referred to as the partitions of the whole dataset.
	/// Now imagine that we want to load a volume of 16 partitions in a
	/// visualization cluster of 4 nodes. Each node could get 4 partitions,
	/// not necessarily forming a whole rectangular region. In this case,
	/// it is not possible to append the 4 partitions together into a vtkImageData.
	/// We can then collect these 4 partitions together using a
	/// vtkPartitionedDataSet.
	///
	/// It is required that all non-empty partitions have the same arrays
	/// and that they can be processed together as a whole by the same kind of
	/// filter. However, it is not required that they are of the same type.
	/// For example, it is possible to have structured datasets together with
	/// unstructured datasets as long as they are compatible meshes (i.e. can
	/// be processed together for the same kind of filter).
	/// </remarks>
	// Token: 0x02000A85 RID: 2693
	public class vtkPartitionedDataSet : vtkDataObjectTree
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601C34C RID: 115532 RVA: 0x002797F0 File Offset: 0x002779F0
		static vtkPartitionedDataSet()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPartitionedDataSet.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPartitionedDataSet"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601C34D RID: 115533 RVA: 0x00279818 File Offset: 0x00277A18
		public vtkPartitionedDataSet(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601C34E RID: 115534
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPartitionedDataSet_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C34F RID: 115535 RVA: 0x00279828 File Offset: 0x00277A28
		public new static vtkPartitionedDataSet New()
		{
			vtkPartitionedDataSet result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPartitionedDataSet.vtkPartitionedDataSet_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPartitionedDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C350 RID: 115536 RVA: 0x0027987C File Offset: 0x00277A7C
		public vtkPartitionedDataSet() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPartitionedDataSet.vtkPartitionedDataSet_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601C351 RID: 115537 RVA: 0x002798C0 File Offset: 0x00277AC0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601C352 RID: 115538
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPartitionedDataSet_GetData_01(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x0601C353 RID: 115539 RVA: 0x002798CC File Offset: 0x00277ACC
		public new static vtkPartitionedDataSet GetData(vtkInformation info)
		{
			vtkPartitionedDataSet vtkPartitionedDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPartitionedDataSet.vtkPartitionedDataSet_GetData_01((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPartitionedDataSet = (vtkPartitionedDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPartitionedDataSet.Register(null);
				}
			}
			return vtkPartitionedDataSet;
		}

		// Token: 0x0601C354 RID: 115540
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPartitionedDataSet_GetData_02(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x0601C355 RID: 115541 RVA: 0x0027994C File Offset: 0x00277B4C
		public new static vtkPartitionedDataSet GetData(vtkInformationVector v, int i)
		{
			vtkPartitionedDataSet vtkPartitionedDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPartitionedDataSet.vtkPartitionedDataSet_GetData_02((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPartitionedDataSet = (vtkPartitionedDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPartitionedDataSet.Register(null);
				}
			}
			return vtkPartitionedDataSet;
		}

		// Token: 0x0601C356 RID: 115542
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPartitionedDataSet_GetDataObjectType_03(HandleRef pThis);

		/// <summary>
		/// Return class name of data type (see vtkType.h for
		/// definitions).
		/// </summary>
		// Token: 0x0601C357 RID: 115543 RVA: 0x002799CC File Offset: 0x00277BCC
		public override int GetDataObjectType()
		{
			return vtkPartitionedDataSet.vtkPartitionedDataSet_GetDataObjectType_03(base.GetCppThis());
		}

		// Token: 0x0601C358 RID: 115544
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPartitionedDataSet_GetMetaData_04(HandleRef pThis, uint idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the meta-data for the partition. If none is already present, a new
		/// vtkInformation object will be allocated. Use HasMetaData to avoid
		/// allocating vtkInformation objects.
		/// </summary>
		// Token: 0x0601C359 RID: 115545 RVA: 0x002799EC File Offset: 0x00277BEC
		public vtkInformation GetMetaData(uint idx)
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPartitionedDataSet.vtkPartitionedDataSet_GetMetaData_04(base.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601C35A RID: 115546
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPartitionedDataSet_GetMetaData_05(HandleRef pThis, HandleRef iter, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Unhiding superclass method.
		/// </summary>
		// Token: 0x0601C35B RID: 115547 RVA: 0x00279A5C File Offset: 0x00277C5C
		public override vtkInformation GetMetaData(vtkCompositeDataIterator iter)
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPartitionedDataSet.vtkPartitionedDataSet_GetMetaData_05(base.GetCppThis(), (iter == null) ? default(HandleRef) : iter.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601C35C RID: 115548
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPartitionedDataSet_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C35D RID: 115549 RVA: 0x00279AE4 File Offset: 0x00277CE4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPartitionedDataSet.vtkPartitionedDataSet_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0601C35E RID: 115550
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPartitionedDataSet_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C35F RID: 115551 RVA: 0x00279B04 File Offset: 0x00277D04
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPartitionedDataSet.vtkPartitionedDataSet_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0601C360 RID: 115552
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkPartitionedDataSet_GetNumberOfPartitions_08(HandleRef pThis);

		/// <summary>
		/// Returns the number of partitions.
		/// </summary>
		// Token: 0x0601C361 RID: 115553 RVA: 0x00279B20 File Offset: 0x00277D20
		public uint GetNumberOfPartitions()
		{
			return vtkPartitionedDataSet.vtkPartitionedDataSet_GetNumberOfPartitions_08(base.GetCppThis());
		}

		// Token: 0x0601C362 RID: 115554
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPartitionedDataSet_GetPartition_09(HandleRef pThis, uint idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the partition at the given index.
		/// </summary>
		// Token: 0x0601C363 RID: 115555 RVA: 0x00279B40 File Offset: 0x00277D40
		public vtkDataSet GetPartition(uint idx)
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPartitionedDataSet.vtkPartitionedDataSet_GetPartition_09(base.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		// Token: 0x0601C364 RID: 115556
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPartitionedDataSet_GetPartitionAsDataObject_10(HandleRef pThis, uint idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the partition at the given index.
		/// </summary>
		// Token: 0x0601C365 RID: 115557 RVA: 0x00279BB0 File Offset: 0x00277DB0
		public vtkDataObject GetPartitionAsDataObject(uint idx)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPartitionedDataSet.vtkPartitionedDataSet_GetPartitionAsDataObject_10(base.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601C366 RID: 115558
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPartitionedDataSet_HasMetaData_11(HandleRef pThis, uint idx);

		/// <summary>
		/// Returns true if meta-data is available for a given partition.
		/// </summary>
		// Token: 0x0601C367 RID: 115559 RVA: 0x00279C20 File Offset: 0x00277E20
		public int HasMetaData(uint idx)
		{
			return vtkPartitionedDataSet.vtkPartitionedDataSet_HasMetaData_11(base.GetCppThis(), idx);
		}

		// Token: 0x0601C368 RID: 115560
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPartitionedDataSet_HasMetaData_12(HandleRef pThis, HandleRef iter);

		/// <summary>
		/// Unhiding superclass method.
		/// </summary>
		// Token: 0x0601C369 RID: 115561 RVA: 0x00279C40 File Offset: 0x00277E40
		public override int HasMetaData(vtkCompositeDataIterator iter)
		{
			return vtkPartitionedDataSet.vtkPartitionedDataSet_HasMetaData_12(base.GetCppThis(), (iter == null) ? default(HandleRef) : iter.GetCppThis());
		}

		// Token: 0x0601C36A RID: 115562
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPartitionedDataSet_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C36B RID: 115563 RVA: 0x00279C74 File Offset: 0x00277E74
		public override int IsA(string type)
		{
			return vtkPartitionedDataSet.vtkPartitionedDataSet_IsA_13(base.GetCppThis(), type);
		}

		// Token: 0x0601C36C RID: 115564
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPartitionedDataSet_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C36D RID: 115565 RVA: 0x00279C94 File Offset: 0x00277E94
		public new static int IsTypeOf(string type)
		{
			return vtkPartitionedDataSet.vtkPartitionedDataSet_IsTypeOf_14(type);
		}

		// Token: 0x0601C36E RID: 115566
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPartitionedDataSet_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C36F RID: 115567 RVA: 0x00279CB0 File Offset: 0x00277EB0
		public new vtkPartitionedDataSet NewInstance()
		{
			vtkPartitionedDataSet result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPartitionedDataSet.vtkPartitionedDataSet_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPartitionedDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601C370 RID: 115568
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPartitionedDataSet_RemoveNullPartitions_17(HandleRef pThis);

		/// <summary>
		/// Removes all partitions that have null datasets and resizes the dataset.
		/// Note any meta data associated with the null datasets will get lost.
		/// </summary>
		// Token: 0x0601C371 RID: 115569 RVA: 0x00279D0A File Offset: 0x00277F0A
		public void RemoveNullPartitions()
		{
			vtkPartitionedDataSet.vtkPartitionedDataSet_RemoveNullPartitions_17(base.GetCppThis());
		}

		// Token: 0x0601C372 RID: 115570
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPartitionedDataSet_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C373 RID: 115571 RVA: 0x00279D1C File Offset: 0x00277F1C
		public new static vtkPartitionedDataSet SafeDownCast(vtkObjectBase o)
		{
			vtkPartitionedDataSet vtkPartitionedDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPartitionedDataSet.vtkPartitionedDataSet_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPartitionedDataSet = (vtkPartitionedDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPartitionedDataSet.Register(null);
				}
			}
			return vtkPartitionedDataSet;
		}

		// Token: 0x0601C374 RID: 115572
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPartitionedDataSet_SetNumberOfPartitions_19(HandleRef pThis, uint numPartitions);

		/// <summary>
		/// Set the number of partitions. This will cause allocation if the new number of
		/// partitions is greater than the current size. All new partitions are initialized to
		/// null.
		/// </summary>
		// Token: 0x0601C375 RID: 115573 RVA: 0x00279D9B File Offset: 0x00277F9B
		public void SetNumberOfPartitions(uint numPartitions)
		{
			vtkPartitionedDataSet.vtkPartitionedDataSet_SetNumberOfPartitions_19(base.GetCppThis(), numPartitions);
		}

		// Token: 0x0601C376 RID: 115574
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPartitionedDataSet_SetPartition_20(HandleRef pThis, uint idx, HandleRef partition);

		/// <summary>
		/// Sets the data object as the given partition. The total number of partitions will
		/// be resized to fit the requested partition no.
		/// </summary>
		// Token: 0x0601C377 RID: 115575 RVA: 0x00279DAC File Offset: 0x00277FAC
		public void SetPartition(uint idx, vtkDataObject partition)
		{
			vtkPartitionedDataSet.vtkPartitionedDataSet_SetPartition_20(base.GetCppThis(), idx, (partition == null) ? default(HandleRef) : partition.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E06 RID: 7686
		public new const string MRFullTypeName = "Kitware.VTK.vtkPartitionedDataSet";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E07 RID: 7687
		public new static readonly string MRClassNameKey = "class vtkPartitionedDataSet";
	}
}
