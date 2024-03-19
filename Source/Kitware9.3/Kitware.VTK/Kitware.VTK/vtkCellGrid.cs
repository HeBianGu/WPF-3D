using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCellGrid
	/// </summary>
	/// <remarks>
	///    Visualization data composed of cells of arbitrary type.
	///
	/// vtkCellGrid inherits vtkDataObject in order to introduce the concept
	/// of cells that, instead of relying on spatial points to specify their
	/// shape, rely on degrees of freedom (which may or may not be embedded
	/// in a world coordinate system).
	///
	/// The degrees of freedom that define cells and the functions using those
	/// cells as their domain are provided in data arrays.
	/// The arrays are partitioned into groups (vtkDataSetAttributes) by the
	/// registered cell types. Each array in a group has the same number of tuples.
	///
	/// </remarks>
	/// <seealso>
	///  vtkDataObject vtkDataSetAttributes
	/// </seealso>
	// Token: 0x02000A1E RID: 2590
	public class vtkCellGrid : vtkDataObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601AFFA RID: 110586 RVA: 0x0025A627 File Offset: 0x00258827
		static vtkCellGrid()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellGrid.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellGrid"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601AFFB RID: 110587 RVA: 0x0025A64F File Offset: 0x0025884F
		public vtkCellGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601AFFC RID: 110588
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AFFD RID: 110589 RVA: 0x0025A660 File Offset: 0x00258860
		public new static vtkCellGrid New()
		{
			vtkCellGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGrid.vtkCellGrid_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AFFE RID: 110590 RVA: 0x0025A6B4 File Offset: 0x002588B4
		public vtkCellGrid() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCellGrid.vtkCellGrid_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601AFFF RID: 110591 RVA: 0x0025A6F8 File Offset: 0x002588F8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601B000 RID: 110592
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellGrid_AddAllCellMetadata_01(HandleRef pThis);

		/// <summary>
		///
		/// This is useful for queries that need to iterate over registered
		/// cell types in order to determine which type of cell to construct.
		/// Afterward, your VTK filter/source can call \a RemoveUnusedCellMetadata()
		/// to remove metadata for which no cells exist.
		///
		/// The number of metadata entries added is returned.
		/// </summary>
		// Token: 0x0601B001 RID: 110593 RVA: 0x0025A704 File Offset: 0x00258904
		public int AddAllCellMetadata()
		{
			return vtkCellGrid.vtkCellGrid_AddAllCellMetadata_01(base.GetCppThis());
		}

		// Token: 0x0601B002 RID: 110594
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCellGrid_AddCellAttribute_02(HandleRef pThis, HandleRef attribute);

		/// <summary>
		/// Add a cell-attribute to the dataset.
		/// A cell-attribute is an object representing a consistent
		/// collection of arrays that specify a function over the
		/// entire vtkCellGrid's domain (i.e., all cells of all types
		/// present in the vtkCellGrid), with custom storage available
		/// to each cell type to facilitate interpolation, rendering,
		/// and other basic visualization operations.
		/// </summary>
		// Token: 0x0601B003 RID: 110595 RVA: 0x0025A724 File Offset: 0x00258924
		public virtual bool AddCellAttribute(vtkCellAttribute attribute)
		{
			return vtkCellGrid.vtkCellGrid_AddCellAttribute_02(base.GetCppThis(), (attribute == null) ? default(HandleRef) : attribute.GetCppThis()) != 0;
		}

		// Token: 0x0601B004 RID: 110596
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGrid_AddCellMetadata_03(HandleRef pThis, HandleRef cellType, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///
		/// If this instance of vtkCellGrid contains the necessary attribute types
		/// (i.e., if FindAttributes returns a non-empty object for all the attribute IDs
		/// specified by the cell type), then insert an instance into this-&gt;Cells and
		/// return it. Otherwise, this method will return a null pointer.
		///
		/// If the cell type already exists, this will simply return the existing
		/// metadata object.
		/// </summary>
		// Token: 0x0601B005 RID: 110597 RVA: 0x0025A760 File Offset: 0x00258960
		public vtkCellMetadata AddCellMetadata(vtkCellMetadata cellType)
		{
			vtkCellMetadata vtkCellMetadata = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGrid.vtkCellGrid_AddCellMetadata_03(base.GetCppThis(), (cellType == null) ? default(HandleRef) : cellType.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellMetadata = (vtkCellMetadata)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellMetadata.Register(null);
				}
			}
			return vtkCellMetadata;
		}

		// Token: 0x0601B006 RID: 110598
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGrid_CorrespondingArray_04(HandleRef gridA, HandleRef arrayA, HandleRef gridB, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x0601B007 RID: 110599 RVA: 0x0025A7E8 File Offset: 0x002589E8
		public static vtkDataArray CorrespondingArray(vtkCellGrid gridA, vtkDataArray arrayA, vtkCellGrid gridB)
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGrid.vtkCellGrid_CorrespondingArray_04((gridA == null) ? default(HandleRef) : gridA.GetCppThis(), (arrayA == null) ? default(HandleRef) : arrayA.GetCppThis(), (gridB == null) ? default(HandleRef) : gridB.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		// Token: 0x0601B008 RID: 110600
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGrid_DeepCopy_05(HandleRef pThis, HandleRef baseSrc);

		/// <summary>
		/// Shallow and Deep copy. These copy the data, but not any pipeline connections.
		/// </summary>
		// Token: 0x0601B009 RID: 110601 RVA: 0x0025A894 File Offset: 0x00258A94
		public override void DeepCopy(vtkDataObject baseSrc)
		{
			vtkCellGrid.vtkCellGrid_DeepCopy_05(base.GetCppThis(), (baseSrc == null) ? default(HandleRef) : baseSrc.GetCppThis());
		}

		// Token: 0x0601B00A RID: 110602
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGrid_FindAttributes_06(HandleRef pThis, int type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Fetch a partition of DOF arrays.
		/// The GetAttributes method will create an empty one if no arrays of that type exist;
		/// the GetArrayGroups method returns the map from types to existing partitions.
		/// The FindAttributes method will return a null pointer if no arrays of that type exist.
		/// </summary>
		// Token: 0x0601B00B RID: 110603 RVA: 0x0025A8C4 File Offset: 0x00258AC4
		public vtkDataSetAttributes FindAttributes(int type)
		{
			vtkDataSetAttributes vtkDataSetAttributes = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGrid.vtkCellGrid_FindAttributes_06(base.GetCppThis(), type, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSetAttributes = (vtkDataSetAttributes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSetAttributes.Register(null);
				}
			}
			return vtkDataSetAttributes;
		}

		// Token: 0x0601B00C RID: 110604
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGrid_FindAttributes_07(HandleRef pThis, vtkStringToken type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Fetch a partition of DOF arrays.
		/// The GetAttributes method will create an empty one if no arrays of that type exist;
		/// the GetArrayGroups method returns the map from types to existing partitions.
		/// The FindAttributes method will return a null pointer if no arrays of that type exist.
		/// </summary>
		// Token: 0x0601B00D RID: 110605 RVA: 0x0025A934 File Offset: 0x00258B34
		public vtkDataSetAttributes FindAttributes(vtkStringToken type)
		{
			vtkDataSetAttributes vtkDataSetAttributes = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGrid.vtkCellGrid_FindAttributes_07(base.GetCppThis(), type, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSetAttributes = (vtkDataSetAttributes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSetAttributes.Register(null);
				}
			}
			return vtkDataSetAttributes;
		}

		// Token: 0x0601B00E RID: 110606
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkCellGrid_GetActualMemorySize_08(HandleRef pThis);

		/// <summary>
		/// Return the actual size of the data in kibibytes (1024 bytes). This number
		/// is valid only after the pipeline has updated. The memory size
		/// returned is guaranteed to be greater than or equal to the
		/// memory required to represent the data (e.g., extra space in
		/// arrays, etc. are not included in the return value).
		/// </summary>
		// Token: 0x0601B00F RID: 110607 RVA: 0x0025A9A4 File Offset: 0x00258BA4
		public override uint GetActualMemorySize()
		{
			return vtkCellGrid.vtkCellGrid_GetActualMemorySize_08(base.GetCppThis());
		}

		// Token: 0x0601B010 RID: 110608
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellGrid_GetAttributeTypeForArray_09(HandleRef pThis, HandleRef arr);

		/// <summary>
		/// Retrieves the attribute type that an array came from.
		/// This is useful for obtaining which attribute type a input array
		/// to an algorithm came from (retrieved from GetInputAbstractArrayToProcesss).
		/// </summary>
		// Token: 0x0601B011 RID: 110609 RVA: 0x0025A9C4 File Offset: 0x00258BC4
		public override int GetAttributeTypeForArray(vtkAbstractArray arr)
		{
			return vtkCellGrid.vtkCellGrid_GetAttributeTypeForArray_09(base.GetCppThis(), (arr == null) ? default(HandleRef) : arr.GetCppThis());
		}

		// Token: 0x0601B012 RID: 110610
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGrid_GetAttributes_10(HandleRef pThis, int type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Fetch a partition of DOF arrays.
		/// The GetAttributes method will create an empty one if no arrays of that type exist;
		/// the GetArrayGroups method returns the map from types to existing partitions.
		/// The FindAttributes method will return a null pointer if no arrays of that type exist.
		/// </summary>
		// Token: 0x0601B013 RID: 110611 RVA: 0x0025A9F8 File Offset: 0x00258BF8
		public override vtkDataSetAttributes GetAttributes(int type)
		{
			vtkDataSetAttributes vtkDataSetAttributes = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGrid.vtkCellGrid_GetAttributes_10(base.GetCppThis(), type, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSetAttributes = (vtkDataSetAttributes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSetAttributes.Register(null);
				}
			}
			return vtkDataSetAttributes;
		}

		// Token: 0x0601B014 RID: 110612
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGrid_GetAttributes_11(HandleRef pThis, vtkStringToken type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Fetch a partition of DOF arrays.
		/// The GetAttributes method will create an empty one if no arrays of that type exist;
		/// the GetArrayGroups method returns the map from types to existing partitions.
		/// The FindAttributes method will return a null pointer if no arrays of that type exist.
		/// </summary>
		// Token: 0x0601B015 RID: 110613 RVA: 0x0025AA68 File Offset: 0x00258C68
		public vtkDataSetAttributes GetAttributes(vtkStringToken type)
		{
			vtkDataSetAttributes vtkDataSetAttributes = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGrid.vtkCellGrid_GetAttributes_11(base.GetCppThis(), type, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSetAttributes = (vtkDataSetAttributes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSetAttributes.Register(null);
				}
			}
			return vtkDataSetAttributes;
		}

		// Token: 0x0601B016 RID: 110614
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGrid_GetBounds_12(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Fill the provided bounding box with the bounds of all the cells present in the grid.
		///
		/// If no cells are present, the bounding box will be reset to uninitialized bounds.
		/// It is up to each cell type to implement a specialization of the BoundsQuery operation.
		///
		/// The bounds are ordered { -x, +x, -y, +y, -z, +z }.
		/// </summary>
		// Token: 0x0601B017 RID: 110615 RVA: 0x0025AAD8 File Offset: 0x00258CD8
		public void GetBounds(IntPtr bounds)
		{
			vtkCellGrid.vtkCellGrid_GetBounds_12(base.GetCppThis(), bounds);
		}

		// Token: 0x0601B018 RID: 110616
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGrid_GetCellAttribute_13(HandleRef pThis, uint hash, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return an attribute given its hash.
		///
		/// This method is fast (O(1)) and preferred compared to the
		/// GetCellAttributeById and GetCellAttributeByName methods below.
		/// </summary>
		// Token: 0x0601B019 RID: 110617 RVA: 0x0025AAE8 File Offset: 0x00258CE8
		public vtkCellAttribute GetCellAttribute(uint hash)
		{
			vtkCellAttribute vtkCellAttribute = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGrid.vtkCellGrid_GetCellAttribute_13(base.GetCppThis(), hash, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellAttribute = (vtkCellAttribute)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellAttribute.Register(null);
				}
			}
			return vtkCellAttribute;
		}

		// Token: 0x0601B01A RID: 110618
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGrid_GetCellAttributeById_14(HandleRef pThis, int attributeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return an attribute given its name or identifier.
		///
		/// This is currently an O(n) process, but additional indices
		/// could be added internally if needed.
		///
		/// These methods may return a null pointer if no such attribute exists.
		///
		/// Multiple attributes with the same name are possible. The first match
		/// will be returned.
		/// </summary>
		// Token: 0x0601B01B RID: 110619 RVA: 0x0025AB58 File Offset: 0x00258D58
		public vtkCellAttribute GetCellAttributeById(int attributeId)
		{
			vtkCellAttribute vtkCellAttribute = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGrid.vtkCellGrid_GetCellAttributeById_14(base.GetCppThis(), attributeId, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellAttribute = (vtkCellAttribute)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellAttribute.Register(null);
				}
			}
			return vtkCellAttribute;
		}

		// Token: 0x0601B01C RID: 110620
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGrid_GetCellAttributeByName_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return an attribute given its name or identifier.
		///
		/// This is currently an O(n) process, but additional indices
		/// could be added internally if needed.
		///
		/// These methods may return a null pointer if no such attribute exists.
		///
		/// Multiple attributes with the same name are possible. The first match
		/// will be returned.
		/// </summary>
		// Token: 0x0601B01D RID: 110621 RVA: 0x0025ABC8 File Offset: 0x00258DC8
		public vtkCellAttribute GetCellAttributeByName(string name)
		{
			vtkCellAttribute vtkCellAttribute = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGrid.vtkCellGrid_GetCellAttributeByName_15(base.GetCppThis(), name, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellAttribute = (vtkCellAttribute)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellAttribute.Register(null);
				}
			}
			return vtkCellAttribute;
		}

		// Token: 0x0601B01E RID: 110622
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGrid_GetCellAttributeByNameAndType_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, vtkStringToken attType, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return an attribute given its name or identifier.
		///
		/// This is currently an O(n) process, but additional indices
		/// could be added internally if needed.
		///
		/// These methods may return a null pointer if no such attribute exists.
		///
		/// Multiple attributes with the same name are possible. The first match
		/// will be returned.
		/// </summary>
		// Token: 0x0601B01F RID: 110623 RVA: 0x0025AC38 File Offset: 0x00258E38
		public vtkCellAttribute GetCellAttributeByNameAndType(string name, vtkStringToken attType)
		{
			vtkCellAttribute vtkCellAttribute = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGrid.vtkCellGrid_GetCellAttributeByNameAndType_16(base.GetCppThis(), name, attType, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellAttribute = (vtkCellAttribute)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellAttribute.Register(null);
				}
			}
			return vtkCellAttribute;
		}

		// Token: 0x0601B020 RID: 110624
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCellGrid_GetCellAttributeRange_17(HandleRef pThis, HandleRef attribute, int componentIndex, IntPtr range, byte finiteRange);

		/// <summary>
		/// Remove a cell-attribute from the dataset.
		///
		/// This returns true if the cell-attribute was removed.
		/// Note that you cannot remove the shape attribute.
		/// </summary>
		// Token: 0x0601B021 RID: 110625 RVA: 0x0025ACAC File Offset: 0x00258EAC
		public virtual bool GetCellAttributeRange(vtkCellAttribute attribute, int componentIndex, IntPtr range, bool finiteRange)
		{
			return vtkCellGrid.vtkCellGrid_GetCellAttributeRange_17(base.GetCppThis(), (attribute == null) ? default(HandleRef) : attribute.GetCppThis(), componentIndex, range, finiteRange ? (byte)1 : (byte)0) != 0;
		}

		// Token: 0x0601B022 RID: 110626
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGrid_GetCellType_18(HandleRef pThis, vtkStringToken cellTypeName, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return an object that can operate on this vtkCellGrid's cells of the given type.
		/// </summary>
		// Token: 0x0601B023 RID: 110627 RVA: 0x0025ACF4 File Offset: 0x00258EF4
		public vtkCellMetadata GetCellType(vtkStringToken cellTypeName)
		{
			vtkCellMetadata vtkCellMetadata = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGrid.vtkCellGrid_GetCellType_18(base.GetCppThis(), cellTypeName, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellMetadata = (vtkCellMetadata)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellMetadata.Register(null);
				}
			}
			return vtkCellMetadata;
		}

		// Token: 0x0601B024 RID: 110628
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkCellGrid_GetContentVersion_19(HandleRef pThis);

		/// <summary>
		/// Perform a query on all the cells in this instance.
		///
		/// The return value indicates success (true when all cells respond
		/// to the query) or failure (false when some cell type is unable to
		/// handle the query).
		/// </summary>
		// Token: 0x0601B025 RID: 110629 RVA: 0x0025AD64 File Offset: 0x00258F64
		public virtual uint GetContentVersion()
		{
			return vtkCellGrid.vtkCellGrid_GetContentVersion_19(base.GetCppThis());
		}

		// Token: 0x0601B026 RID: 110630
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGrid_GetData_20(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x0601B027 RID: 110631 RVA: 0x0025AD84 File Offset: 0x00258F84
		public new static vtkCellGrid GetData(vtkInformation info)
		{
			vtkCellGrid vtkCellGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGrid.vtkCellGrid_GetData_20((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellGrid = (vtkCellGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellGrid.Register(null);
				}
			}
			return vtkCellGrid;
		}

		// Token: 0x0601B028 RID: 110632
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGrid_GetData_21(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x0601B029 RID: 110633 RVA: 0x0025AE04 File Offset: 0x00259004
		public new static vtkCellGrid GetData(vtkInformationVector v, int i)
		{
			vtkCellGrid vtkCellGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGrid.vtkCellGrid_GetData_21((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellGrid = (vtkCellGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellGrid.Register(null);
				}
			}
			return vtkCellGrid;
		}

		// Token: 0x0601B02A RID: 110634
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellGrid_GetDataObjectType_22(HandleRef pThis);

		/// <summary>
		/// Return class name of data type.
		/// THIS METHOD IS THREAD SAFE
		/// </summary>
		// Token: 0x0601B02B RID: 110635 RVA: 0x0025AE84 File Offset: 0x00259084
		public override int GetDataObjectType()
		{
			return vtkCellGrid.vtkCellGrid_GetDataObjectType_22(base.GetCppThis());
		}

		// Token: 0x0601B02C RID: 110636
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGrid_GetGhostArray_23(HandleRef pThis, int type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the ghost arrays of the data object of the specified
		/// attribute type. This may return a null pointer.
		/// </summary>
		// Token: 0x0601B02D RID: 110637 RVA: 0x0025AEA4 File Offset: 0x002590A4
		public override vtkUnsignedCharArray GetGhostArray(int type)
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGrid.vtkCellGrid_GetGhostArray_23(base.GetCppThis(), type, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedCharArray = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedCharArray.Register(null);
				}
			}
			return vtkUnsignedCharArray;
		}

		// Token: 0x0601B02E RID: 110638
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellGrid_GetNumberOfCells_24(HandleRef pThis);

		/// <summary>
		/// Get the number of elements for a specific attribute type (POINT, CELL, etc.).
		/// </summary>
		// Token: 0x0601B02F RID: 110639 RVA: 0x0025AF14 File Offset: 0x00259114
		public long GetNumberOfCells()
		{
			return vtkCellGrid.vtkCellGrid_GetNumberOfCells_24(base.GetCppThis());
		}

		// Token: 0x0601B030 RID: 110640
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellGrid_GetNumberOfElements_25(HandleRef pThis, int type);

		/// <summary>
		/// Get the number of elements for a specific attribute type (POINT, CELL, etc.).
		/// </summary>
		// Token: 0x0601B031 RID: 110641 RVA: 0x0025AF34 File Offset: 0x00259134
		public override long GetNumberOfElements(int type)
		{
			return vtkCellGrid.vtkCellGrid_GetNumberOfElements_25(base.GetCppThis(), type);
		}

		// Token: 0x0601B032 RID: 110642
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellGrid_GetNumberOfGenerationsFromBase_26(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B033 RID: 110643 RVA: 0x0025AF54 File Offset: 0x00259154
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCellGrid.vtkCellGrid_GetNumberOfGenerationsFromBase_26(base.GetCppThis(), type);
		}

		// Token: 0x0601B034 RID: 110644
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellGrid_GetNumberOfGenerationsFromBaseType_27([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B035 RID: 110645 RVA: 0x0025AF74 File Offset: 0x00259174
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCellGrid.vtkCellGrid_GetNumberOfGenerationsFromBaseType_27(type);
		}

		// Token: 0x0601B036 RID: 110646
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkStringToken vtkCellGrid_GetSchemaName_28(HandleRef pThis);

		/// <summary>
		/// Perform a query on all the cells in this instance.
		///
		/// The return value indicates success (true when all cells respond
		/// to the query) or failure (false when some cell type is unable to
		/// handle the query).
		/// </summary>
		// Token: 0x0601B037 RID: 110647 RVA: 0x0025AF90 File Offset: 0x00259190
		public virtual vtkStringToken GetSchemaName()
		{
			return vtkCellGrid.vtkCellGrid_GetSchemaName_28(base.GetCppThis());
		}

		// Token: 0x0601B038 RID: 110648
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkCellGrid_GetSchemaVersion_29(HandleRef pThis);

		/// <summary>
		/// Perform a query on all the cells in this instance.
		///
		/// The return value indicates success (true when all cells respond
		/// to the query) or failure (false when some cell type is unable to
		/// handle the query).
		/// </summary>
		// Token: 0x0601B039 RID: 110649 RVA: 0x0025AFB0 File Offset: 0x002591B0
		public virtual uint GetSchemaVersion()
		{
			return vtkCellGrid.vtkCellGrid_GetSchemaVersion_29(base.GetCppThis());
		}

		// Token: 0x0601B03A RID: 110650
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGrid_GetShapeAttribute_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get the "shape attribute" (i.e., a vector-valued cell-attribute
		/// that maps from reference to world coordinates).
		///
		/// If there is no shape attribute, then a vtkCellGrid cannot be rendered.
		///
		/// A shape attribute must have between 1 and 4 components (inclusive).
		///
		/// If you call SetShapeAttribute with an attribute that does not satisfy
		/// this constraint, this method will return false and have no effect.
		/// If you wish to "remove" a grid's shape, call SetShapeAttribute(nullptr).
		/// </summary>
		// Token: 0x0601B03B RID: 110651 RVA: 0x0025AFD0 File Offset: 0x002591D0
		public vtkCellAttribute GetShapeAttribute()
		{
			vtkCellAttribute vtkCellAttribute = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGrid.vtkCellGrid_GetShapeAttribute_30(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellAttribute = (vtkCellAttribute)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellAttribute.Register(null);
				}
			}
			return vtkCellAttribute;
		}

		// Token: 0x0601B03C RID: 110652
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGrid_Initialize_31(HandleRef pThis);

		/// <summary>
		/// Restore data object to initial state,
		/// </summary>
		// Token: 0x0601B03D RID: 110653 RVA: 0x0025B03F File Offset: 0x0025923F
		public override void Initialize()
		{
			vtkCellGrid.vtkCellGrid_Initialize_31(base.GetCppThis());
		}

		// Token: 0x0601B03E RID: 110654
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellGrid_IsA_32(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B03F RID: 110655 RVA: 0x0025B050 File Offset: 0x00259250
		public override int IsA(string type)
		{
			return vtkCellGrid.vtkCellGrid_IsA_32(base.GetCppThis(), type);
		}

		// Token: 0x0601B040 RID: 110656
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellGrid_IsTypeOf_33([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B041 RID: 110657 RVA: 0x0025B070 File Offset: 0x00259270
		public new static int IsTypeOf(string type)
		{
			return vtkCellGrid.vtkCellGrid_IsTypeOf_33(type);
		}

		// Token: 0x0601B042 RID: 110658
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGrid_NewInstance_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B043 RID: 110659 RVA: 0x0025B08C File Offset: 0x0025928C
		public new vtkCellGrid NewInstance()
		{
			vtkCellGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGrid.vtkCellGrid_NewInstance_35(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601B044 RID: 110660
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCellGrid_Query_36(HandleRef pThis, HandleRef query);

		/// <summary>
		/// Perform a query on all the cells in this instance.
		///
		/// The return value indicates success (true when all cells respond
		/// to the query) or failure (false when some cell type is unable to
		/// handle the query).
		/// </summary>
		// Token: 0x0601B045 RID: 110661 RVA: 0x0025B0E8 File Offset: 0x002592E8
		public bool Query(vtkCellGridQuery query)
		{
			return vtkCellGrid.vtkCellGrid_Query_36(base.GetCppThis(), (query == null) ? default(HandleRef) : query.GetCppThis()) != 0;
		}

		// Token: 0x0601B046 RID: 110662
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCellGrid_RemoveCellAttribute_37(HandleRef pThis, HandleRef attribute);

		/// <summary>
		/// Remove a cell-attribute from the dataset.
		///
		/// This returns true if the cell-attribute was removed.
		/// Note that you cannot remove the shape attribute.
		/// </summary>
		// Token: 0x0601B047 RID: 110663 RVA: 0x0025B124 File Offset: 0x00259324
		public virtual bool RemoveCellAttribute(vtkCellAttribute attribute)
		{
			return vtkCellGrid.vtkCellGrid_RemoveCellAttribute_37(base.GetCppThis(), (attribute == null) ? default(HandleRef) : attribute.GetCppThis()) != 0;
		}

		// Token: 0x0601B048 RID: 110664
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCellGrid_RemoveCellMetadata_38(HandleRef pThis, HandleRef meta);

		/// <summary>
		///
		/// This is useful for queries that need to iterate over registered
		/// cell types in order to determine which type of cell to construct.
		/// Afterward, your VTK filter/source can call \a RemoveUnusedCellMetadata()
		/// to remove metadata for which no cells exist.
		///
		/// The number of metadata entries added is returned.
		/// </summary>
		// Token: 0x0601B049 RID: 110665 RVA: 0x0025B160 File Offset: 0x00259360
		public bool RemoveCellMetadata(vtkCellMetadata meta)
		{
			return vtkCellGrid.vtkCellGrid_RemoveCellMetadata_38(base.GetCppThis(), (meta == null) ? default(HandleRef) : meta.GetCppThis()) != 0;
		}

		// Token: 0x0601B04A RID: 110666
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellGrid_RemoveUnusedCellMetadata_39(HandleRef pThis);

		/// <summary>
		///
		/// The number of metadata entries removed is returned.
		///
		/// \sa vtkCellGrid::AddAllCellMetadata
		/// </summary>
		// Token: 0x0601B04B RID: 110667 RVA: 0x0025B19C File Offset: 0x0025939C
		public int RemoveUnusedCellMetadata()
		{
			return vtkCellGrid.vtkCellGrid_RemoveUnusedCellMetadata_39(base.GetCppThis());
		}

		// Token: 0x0601B04C RID: 110668
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGrid_SafeDownCast_40(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B04D RID: 110669 RVA: 0x0025B1BC File Offset: 0x002593BC
		public new static vtkCellGrid SafeDownCast(vtkObjectBase o)
		{
			vtkCellGrid vtkCellGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGrid.vtkCellGrid_SafeDownCast_40((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellGrid = (vtkCellGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellGrid.Register(null);
				}
			}
			return vtkCellGrid;
		}

		// Token: 0x0601B04E RID: 110670
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGrid_SetContentVersion_41(HandleRef pThis, uint _arg);

		/// <summary>
		/// Perform a query on all the cells in this instance.
		///
		/// The return value indicates success (true when all cells respond
		/// to the query) or failure (false when some cell type is unable to
		/// handle the query).
		/// </summary>
		// Token: 0x0601B04F RID: 110671 RVA: 0x0025B23B File Offset: 0x0025943B
		public virtual void SetContentVersion(uint _arg)
		{
			vtkCellGrid.vtkCellGrid_SetContentVersion_41(base.GetCppThis(), _arg);
		}

		// Token: 0x0601B050 RID: 110672
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGrid_SetSchema_42(HandleRef pThis, vtkStringToken name, uint version);

		/// <summary>
		/// Perform a query on all the cells in this instance.
		///
		/// The return value indicates success (true when all cells respond
		/// to the query) or failure (false when some cell type is unable to
		/// handle the query).
		/// </summary>
		// Token: 0x0601B051 RID: 110673 RVA: 0x0025B24B File Offset: 0x0025944B
		public virtual void SetSchema(vtkStringToken name, uint version)
		{
			vtkCellGrid.vtkCellGrid_SetSchema_42(base.GetCppThis(), name, version);
		}

		// Token: 0x0601B052 RID: 110674
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCellGrid_SetShapeAttribute_43(HandleRef pThis, HandleRef shape);

		/// <summary>
		/// Set/get the "shape attribute" (i.e., a vector-valued cell-attribute
		/// that maps from reference to world coordinates).
		///
		/// If there is no shape attribute, then a vtkCellGrid cannot be rendered.
		///
		/// A shape attribute must have between 1 and 4 components (inclusive).
		///
		/// If you call SetShapeAttribute with an attribute that does not satisfy
		/// this constraint, this method will return false and have no effect.
		/// If you wish to "remove" a grid's shape, call SetShapeAttribute(nullptr).
		/// </summary>
		// Token: 0x0601B053 RID: 110675 RVA: 0x0025B25C File Offset: 0x0025945C
		public bool SetShapeAttribute(vtkCellAttribute shape)
		{
			return vtkCellGrid.vtkCellGrid_SetShapeAttribute_43(base.GetCppThis(), (shape == null) ? default(HandleRef) : shape.GetCppThis()) != 0;
		}

		// Token: 0x0601B054 RID: 110676
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGrid_ShallowCopy_44(HandleRef pThis, HandleRef baseSrc);

		/// <summary>
		/// Shallow and Deep copy. These copy the data, but not any pipeline connections.
		/// </summary>
		// Token: 0x0601B055 RID: 110677 RVA: 0x0025B298 File Offset: 0x00259498
		public override void ShallowCopy(vtkDataObject baseSrc)
		{
			vtkCellGrid.vtkCellGrid_ShallowCopy_44(base.GetCppThis(), (baseSrc == null) ? default(HandleRef) : baseSrc.GetCppThis());
		}

		// Token: 0x0601B056 RID: 110678
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCellGrid_SupportsGhostArray_45(HandleRef pThis, int type);

		/// <summary>
		/// Returns true if type is CELL, false otherwise
		/// </summary>
		// Token: 0x0601B057 RID: 110679 RVA: 0x0025B2C8 File Offset: 0x002594C8
		public override bool SupportsGhostArray(int type)
		{
			return vtkCellGrid.vtkCellGrid_SupportsGhostArray_45(base.GetCppThis(), type) != 0;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D2B RID: 7467
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellGrid";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D2C RID: 7468
		public new static readonly string MRClassNameKey = "class vtkCellGrid";
	}
}
