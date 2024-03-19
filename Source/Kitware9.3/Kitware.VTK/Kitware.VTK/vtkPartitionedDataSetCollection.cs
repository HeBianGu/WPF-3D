using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPartitionedDataSetCollection
	/// </summary>
	/// <remarks>
	///    Composite dataset that groups datasets as a collection.
	///
	/// vtkPartitionedDataSetCollection is a vtkCompositeDataSet that stores
	/// a collection of non-null vtkPartitionedDataSets. These items can represent
	/// different concepts depending on the context. For example, they can
	/// represent region of different materials in a simulation or parts in
	/// an assembly. It is not requires that items have anything in common.
	/// For example, they can have completely different point or cell arrays.
	/// </remarks>
	// Token: 0x02000A8E RID: 2702
	public class vtkPartitionedDataSetCollection : vtkDataObjectTree
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601C51A RID: 115994 RVA: 0x0027C5F7 File Offset: 0x0027A7F7
		static vtkPartitionedDataSetCollection()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPartitionedDataSetCollection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPartitionedDataSetCollection"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601C51B RID: 115995 RVA: 0x0027C61F File Offset: 0x0027A81F
		public vtkPartitionedDataSetCollection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601C51C RID: 115996
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPartitionedDataSetCollection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C51D RID: 115997 RVA: 0x0027C630 File Offset: 0x0027A830
		public new static vtkPartitionedDataSetCollection New()
		{
			vtkPartitionedDataSetCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPartitionedDataSetCollection.vtkPartitionedDataSetCollection_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPartitionedDataSetCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C51E RID: 115998 RVA: 0x0027C684 File Offset: 0x0027A884
		public vtkPartitionedDataSetCollection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPartitionedDataSetCollection.vtkPartitionedDataSetCollection_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601C51F RID: 115999 RVA: 0x0027C6C8 File Offset: 0x0027A8C8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601C520 RID: 116000
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPartitionedDataSetCollection_CompositeShallowCopy_01(HandleRef pThis, HandleRef src);

		/// <summary>
		/// Overridden to handle vtkDataAssembly.
		/// </summary>
		// Token: 0x0601C521 RID: 116001 RVA: 0x0027C6D4 File Offset: 0x0027A8D4
		public override void CompositeShallowCopy(vtkCompositeDataSet src)
		{
			vtkPartitionedDataSetCollection.vtkPartitionedDataSetCollection_CompositeShallowCopy_01(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		// Token: 0x0601C522 RID: 116002
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPartitionedDataSetCollection_CopyStructure_02(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Overridden to handle vtkDataAssembly.
		/// </summary>
		// Token: 0x0601C523 RID: 116003 RVA: 0x0027C704 File Offset: 0x0027A904
		public override void CopyStructure(vtkCompositeDataSet input)
		{
			vtkPartitionedDataSetCollection.vtkPartitionedDataSetCollection_CopyStructure_02(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x0601C524 RID: 116004
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPartitionedDataSetCollection_DeepCopy_03(HandleRef pThis, HandleRef src);

		/// <summary>
		/// Overridden to handle vtkDataAssembly.
		/// </summary>
		// Token: 0x0601C525 RID: 116005 RVA: 0x0027C734 File Offset: 0x0027A934
		public override void DeepCopy(vtkDataObject src)
		{
			vtkPartitionedDataSetCollection.vtkPartitionedDataSetCollection_DeepCopy_03(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		// Token: 0x0601C526 RID: 116006
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkPartitionedDataSetCollection_GetCompositeIndex_04(HandleRef pThis, uint idx);

		/// <summary>
		/// Returns the composite index (sometimes referred to as the flat-index) for
		/// either a partitioned dataset or a specific partition in a partitioned
		/// dataset.
		/// </summary>
		// Token: 0x0601C527 RID: 116007 RVA: 0x0027C764 File Offset: 0x0027A964
		public uint GetCompositeIndex(uint idx)
		{
			return vtkPartitionedDataSetCollection.vtkPartitionedDataSetCollection_GetCompositeIndex_04(base.GetCppThis(), idx);
		}

		// Token: 0x0601C528 RID: 116008
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkPartitionedDataSetCollection_GetCompositeIndex_05(HandleRef pThis, uint idx, uint partition);

		/// <summary>
		/// Returns the composite index (sometimes referred to as the flat-index) for
		/// either a partitioned dataset or a specific partition in a partitioned
		/// dataset.
		/// </summary>
		// Token: 0x0601C529 RID: 116009 RVA: 0x0027C784 File Offset: 0x0027A984
		public uint GetCompositeIndex(uint idx, uint partition)
		{
			return vtkPartitionedDataSetCollection.vtkPartitionedDataSetCollection_GetCompositeIndex_05(base.GetCppThis(), idx, partition);
		}

		// Token: 0x0601C52A RID: 116010
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPartitionedDataSetCollection_GetData_06(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x0601C52B RID: 116011 RVA: 0x0027C7A8 File Offset: 0x0027A9A8
		public new static vtkPartitionedDataSetCollection GetData(vtkInformation info)
		{
			vtkPartitionedDataSetCollection vtkPartitionedDataSetCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPartitionedDataSetCollection.vtkPartitionedDataSetCollection_GetData_06((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPartitionedDataSetCollection = (vtkPartitionedDataSetCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPartitionedDataSetCollection.Register(null);
				}
			}
			return vtkPartitionedDataSetCollection;
		}

		// Token: 0x0601C52C RID: 116012
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPartitionedDataSetCollection_GetData_07(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x0601C52D RID: 116013 RVA: 0x0027C828 File Offset: 0x0027AA28
		public new static vtkPartitionedDataSetCollection GetData(vtkInformationVector v, int i)
		{
			vtkPartitionedDataSetCollection vtkPartitionedDataSetCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPartitionedDataSetCollection.vtkPartitionedDataSetCollection_GetData_07((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPartitionedDataSetCollection = (vtkPartitionedDataSetCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPartitionedDataSetCollection.Register(null);
				}
			}
			return vtkPartitionedDataSetCollection;
		}

		// Token: 0x0601C52E RID: 116014
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPartitionedDataSetCollection_GetDataAssembly_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// DataAssembly provides a way to define hierarchical organization of
		/// partitioned-datasets. These methods provide access to the data assembly
		/// instances associated, if any.
		/// </summary>
		// Token: 0x0601C52F RID: 116015 RVA: 0x0027C8A8 File Offset: 0x0027AAA8
		public virtual vtkDataAssembly GetDataAssembly()
		{
			vtkDataAssembly vtkDataAssembly = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPartitionedDataSetCollection.vtkPartitionedDataSetCollection_GetDataAssembly_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601C530 RID: 116016
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPartitionedDataSetCollection_GetDataObjectType_09(HandleRef pThis);

		/// <summary>
		/// Return class name of data type (see vtkType.h for
		/// definitions).
		/// </summary>
		// Token: 0x0601C531 RID: 116017 RVA: 0x0027C918 File Offset: 0x0027AB18
		public override int GetDataObjectType()
		{
			return vtkPartitionedDataSetCollection.vtkPartitionedDataSetCollection_GetDataObjectType_09(base.GetCppThis());
		}

		// Token: 0x0601C532 RID: 116018
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkPartitionedDataSetCollection_GetMTime_10(HandleRef pThis);

		/// <summary>
		/// Overridden to include DataAssembly MTime.
		/// </summary>
		// Token: 0x0601C533 RID: 116019 RVA: 0x0027C938 File Offset: 0x0027AB38
		public override ulong GetMTime()
		{
			return vtkPartitionedDataSetCollection.vtkPartitionedDataSetCollection_GetMTime_10(base.GetCppThis());
		}

		// Token: 0x0601C534 RID: 116020
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPartitionedDataSetCollection_GetMetaData_11(HandleRef pThis, uint idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the meta-data for the block. If none is already present, a new
		/// vtkInformation object will be allocated. Use HasMetaData to avoid
		/// allocating vtkInformation objects.
		/// </summary>
		// Token: 0x0601C535 RID: 116021 RVA: 0x0027C958 File Offset: 0x0027AB58
		public vtkInformation GetMetaData(uint idx)
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPartitionedDataSetCollection.vtkPartitionedDataSetCollection_GetMetaData_11(base.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601C536 RID: 116022
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPartitionedDataSetCollection_GetMetaData_12(HandleRef pThis, HandleRef iter, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Unhiding superclass method.
		/// </summary>
		// Token: 0x0601C537 RID: 116023 RVA: 0x0027C9C8 File Offset: 0x0027ABC8
		public override vtkInformation GetMetaData(vtkCompositeDataIterator iter)
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPartitionedDataSetCollection.vtkPartitionedDataSetCollection_GetMetaData_12(base.GetCppThis(), (iter == null) ? default(HandleRef) : iter.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601C538 RID: 116024
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPartitionedDataSetCollection_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C539 RID: 116025 RVA: 0x0027CA50 File Offset: 0x0027AC50
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPartitionedDataSetCollection.vtkPartitionedDataSetCollection_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x0601C53A RID: 116026
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPartitionedDataSetCollection_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C53B RID: 116027 RVA: 0x0027CA70 File Offset: 0x0027AC70
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPartitionedDataSetCollection.vtkPartitionedDataSetCollection_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x0601C53C RID: 116028
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkPartitionedDataSetCollection_GetNumberOfPartitionedDataSets_15(HandleRef pThis);

		/// <summary>
		/// Returns the number of blocks.
		/// </summary>
		// Token: 0x0601C53D RID: 116029 RVA: 0x0027CA8C File Offset: 0x0027AC8C
		public uint GetNumberOfPartitionedDataSets()
		{
			return vtkPartitionedDataSetCollection.vtkPartitionedDataSetCollection_GetNumberOfPartitionedDataSets_15(base.GetCppThis());
		}

		// Token: 0x0601C53E RID: 116030
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkPartitionedDataSetCollection_GetNumberOfPartitions_16(HandleRef pThis, uint idx);

		/// <summary>
		/// Returns the number of partitions in a partitioned dataset at the given index.
		/// </summary>
		// Token: 0x0601C53F RID: 116031 RVA: 0x0027CAAC File Offset: 0x0027ACAC
		public uint GetNumberOfPartitions(uint idx)
		{
			return vtkPartitionedDataSetCollection.vtkPartitionedDataSetCollection_GetNumberOfPartitions_16(base.GetCppThis(), idx);
		}

		// Token: 0x0601C540 RID: 116032
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPartitionedDataSetCollection_GetPartition_17(HandleRef pThis, uint idx, uint partition, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// API to get/set partitions using a tuple index.
		/// </summary>
		// Token: 0x0601C541 RID: 116033 RVA: 0x0027CACC File Offset: 0x0027ACCC
		public vtkDataSet GetPartition(uint idx, uint partition)
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPartitionedDataSetCollection.vtkPartitionedDataSetCollection_GetPartition_17(base.GetCppThis(), idx, partition, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601C542 RID: 116034
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPartitionedDataSetCollection_GetPartitionAsDataObject_18(HandleRef pThis, uint idx, uint partition, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// API to get/set partitions using a tuple index.
		/// </summary>
		// Token: 0x0601C543 RID: 116035 RVA: 0x0027CB40 File Offset: 0x0027AD40
		public vtkDataObject GetPartitionAsDataObject(uint idx, uint partition)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPartitionedDataSetCollection.vtkPartitionedDataSetCollection_GetPartitionAsDataObject_18(base.GetCppThis(), idx, partition, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601C544 RID: 116036
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPartitionedDataSetCollection_GetPartitionedDataSet_19(HandleRef pThis, uint idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the block at the given index. It is recommended that one uses the
		/// iterators to iterate over composite datasets rather than using this API.
		/// </summary>
		// Token: 0x0601C545 RID: 116037 RVA: 0x0027CBB4 File Offset: 0x0027ADB4
		public vtkPartitionedDataSet GetPartitionedDataSet(uint idx)
		{
			vtkPartitionedDataSet vtkPartitionedDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPartitionedDataSetCollection.vtkPartitionedDataSetCollection_GetPartitionedDataSet_19(base.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601C546 RID: 116038
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPartitionedDataSetCollection_HasMetaData_20(HandleRef pThis, uint idx);

		/// <summary>
		/// Returns true if meta-data is available for a given block.
		/// </summary>
		// Token: 0x0601C547 RID: 116039 RVA: 0x0027CC24 File Offset: 0x0027AE24
		public int HasMetaData(uint idx)
		{
			return vtkPartitionedDataSetCollection.vtkPartitionedDataSetCollection_HasMetaData_20(base.GetCppThis(), idx);
		}

		// Token: 0x0601C548 RID: 116040
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPartitionedDataSetCollection_HasMetaData_21(HandleRef pThis, HandleRef iter);

		/// <summary>
		/// Unhiding superclass method.
		/// </summary>
		// Token: 0x0601C549 RID: 116041 RVA: 0x0027CC44 File Offset: 0x0027AE44
		public override int HasMetaData(vtkCompositeDataIterator iter)
		{
			return vtkPartitionedDataSetCollection.vtkPartitionedDataSetCollection_HasMetaData_21(base.GetCppThis(), (iter == null) ? default(HandleRef) : iter.GetCppThis());
		}

		// Token: 0x0601C54A RID: 116042
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPartitionedDataSetCollection_Initialize_22(HandleRef pThis);

		/// <summary>
		/// Overridden to handle vtkDataAssembly.
		/// </summary>
		// Token: 0x0601C54B RID: 116043 RVA: 0x0027CC78 File Offset: 0x0027AE78
		public override void Initialize()
		{
			vtkPartitionedDataSetCollection.vtkPartitionedDataSetCollection_Initialize_22(base.GetCppThis());
		}

		// Token: 0x0601C54C RID: 116044
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPartitionedDataSetCollection_IsA_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C54D RID: 116045 RVA: 0x0027CC88 File Offset: 0x0027AE88
		public override int IsA(string type)
		{
			return vtkPartitionedDataSetCollection.vtkPartitionedDataSetCollection_IsA_23(base.GetCppThis(), type);
		}

		// Token: 0x0601C54E RID: 116046
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPartitionedDataSetCollection_IsTypeOf_24([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C54F RID: 116047 RVA: 0x0027CCA8 File Offset: 0x0027AEA8
		public new static int IsTypeOf(string type)
		{
			return vtkPartitionedDataSetCollection.vtkPartitionedDataSetCollection_IsTypeOf_24(type);
		}

		// Token: 0x0601C550 RID: 116048
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPartitionedDataSetCollection_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C551 RID: 116049 RVA: 0x0027CCC4 File Offset: 0x0027AEC4
		public new vtkPartitionedDataSetCollection NewInstance()
		{
			vtkPartitionedDataSetCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPartitionedDataSetCollection.vtkPartitionedDataSetCollection_NewInstance_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPartitionedDataSetCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601C552 RID: 116050
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPartitionedDataSetCollection_RemovePartitionedDataSet_27(HandleRef pThis, uint idx);

		/// <summary>
		/// Remove the given block from the dataset.
		/// </summary>
		// Token: 0x0601C553 RID: 116051 RVA: 0x0027CD1E File Offset: 0x0027AF1E
		public void RemovePartitionedDataSet(uint idx)
		{
			vtkPartitionedDataSetCollection.vtkPartitionedDataSetCollection_RemovePartitionedDataSet_27(base.GetCppThis(), idx);
		}

		// Token: 0x0601C554 RID: 116052
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPartitionedDataSetCollection_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C555 RID: 116053 RVA: 0x0027CD30 File Offset: 0x0027AF30
		public new static vtkPartitionedDataSetCollection SafeDownCast(vtkObjectBase o)
		{
			vtkPartitionedDataSetCollection vtkPartitionedDataSetCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPartitionedDataSetCollection.vtkPartitionedDataSetCollection_SafeDownCast_28((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPartitionedDataSetCollection = (vtkPartitionedDataSetCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPartitionedDataSetCollection.Register(null);
				}
			}
			return vtkPartitionedDataSetCollection;
		}

		// Token: 0x0601C556 RID: 116054
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPartitionedDataSetCollection_SetDataAssembly_29(HandleRef pThis, HandleRef assembly);

		/// <summary>
		/// DataAssembly provides a way to define hierarchical organization of
		/// partitioned-datasets. These methods provide access to the data assembly
		/// instances associated, if any.
		/// </summary>
		// Token: 0x0601C557 RID: 116055 RVA: 0x0027CDB0 File Offset: 0x0027AFB0
		public void SetDataAssembly(vtkDataAssembly assembly)
		{
			vtkPartitionedDataSetCollection.vtkPartitionedDataSetCollection_SetDataAssembly_29(base.GetCppThis(), (assembly == null) ? default(HandleRef) : assembly.GetCppThis());
		}

		// Token: 0x0601C558 RID: 116056
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPartitionedDataSetCollection_SetNumberOfPartitionedDataSets_30(HandleRef pThis, uint numDataSets);

		/// <summary>
		/// Set the number of blocks. This will cause allocation if the new number of
		/// blocks is greater than the current size. All new blocks are initialized to
		/// with empty `vtkPartitionedDataSetCollection` instances.
		/// </summary>
		// Token: 0x0601C559 RID: 116057 RVA: 0x0027CDDF File Offset: 0x0027AFDF
		public void SetNumberOfPartitionedDataSets(uint numDataSets)
		{
			vtkPartitionedDataSetCollection.vtkPartitionedDataSetCollection_SetNumberOfPartitionedDataSets_30(base.GetCppThis(), numDataSets);
		}

		// Token: 0x0601C55A RID: 116058
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPartitionedDataSetCollection_SetNumberOfPartitions_31(HandleRef pThis, uint idx, uint numPartitions);

		/// <summary>
		/// Set number of partitions at a given index. Note, this will call
		/// `SetNumberOfPartitionedDataSets` if needed to grow the collection.
		/// </summary>
		// Token: 0x0601C55B RID: 116059 RVA: 0x0027CDEF File Offset: 0x0027AFEF
		public void SetNumberOfPartitions(uint idx, uint numPartitions)
		{
			vtkPartitionedDataSetCollection.vtkPartitionedDataSetCollection_SetNumberOfPartitions_31(base.GetCppThis(), idx, numPartitions);
		}

		// Token: 0x0601C55C RID: 116060
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPartitionedDataSetCollection_SetPartition_32(HandleRef pThis, uint idx, uint partition, HandleRef arg2);

		/// <summary>
		/// API to get/set partitions using a tuple index.
		/// </summary>
		// Token: 0x0601C55D RID: 116061 RVA: 0x0027CE00 File Offset: 0x0027B000
		public void SetPartition(uint idx, uint partition, vtkDataObject arg2)
		{
			vtkPartitionedDataSetCollection.vtkPartitionedDataSetCollection_SetPartition_32(base.GetCppThis(), idx, partition, (arg2 == null) ? default(HandleRef) : arg2.GetCppThis());
		}

		// Token: 0x0601C55E RID: 116062
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPartitionedDataSetCollection_SetPartitionedDataSet_33(HandleRef pThis, uint idx, HandleRef dataset);

		/// <summary>
		/// Sets the data object as the given block. The total number of blocks will
		/// be resized to fit the requested block no.
		///
		/// @remark `dataset` cannot be nullptr.
		/// </summary>
		// Token: 0x0601C55F RID: 116063 RVA: 0x0027CE34 File Offset: 0x0027B034
		public void SetPartitionedDataSet(uint idx, vtkPartitionedDataSet dataset)
		{
			vtkPartitionedDataSetCollection.vtkPartitionedDataSetCollection_SetPartitionedDataSet_33(base.GetCppThis(), idx, (dataset == null) ? default(HandleRef) : dataset.GetCppThis());
		}

		// Token: 0x0601C560 RID: 116064
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPartitionedDataSetCollection_ShallowCopy_34(HandleRef pThis, HandleRef src);

		/// <summary>
		/// Overridden to handle vtkDataAssembly.
		/// </summary>
		// Token: 0x0601C561 RID: 116065 RVA: 0x0027CE64 File Offset: 0x0027B064
		public override void ShallowCopy(vtkDataObject src)
		{
			vtkPartitionedDataSetCollection.vtkPartitionedDataSetCollection_ShallowCopy_34(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E18 RID: 7704
		public new const string MRFullTypeName = "Kitware.VTK.vtkPartitionedDataSetCollection";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E19 RID: 7705
		public new static readonly string MRClassNameKey = "class vtkPartitionedDataSetCollection";
	}
}
