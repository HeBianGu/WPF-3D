using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCompositeDataSet
	/// </summary>
	/// <remarks>
	///    abstract superclass for composite
	/// (multi-block or AMR) datasets
	///
	/// vtkCompositeDataSet is an abstract class that represents a collection
	/// of datasets (including other composite datasets). It
	/// provides an interface to access the datasets through iterators.
	/// vtkCompositeDataSet provides methods that are used by subclasses to store the
	/// datasets.
	/// vtkCompositeDataSet provides the datastructure for a full tree
	/// representation. Subclasses provide the semantics for it and control how
	/// this tree is built.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkCompositeDataIterator
	/// </seealso>
	// Token: 0x02000A30 RID: 2608
	public abstract class vtkCompositeDataSet : vtkDataObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601B299 RID: 111257 RVA: 0x0025EF19 File Offset: 0x0025D119
		static vtkCompositeDataSet()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCompositeDataSet.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCompositeDataSet"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601B29A RID: 111258 RVA: 0x0025EF41 File Offset: 0x0025D141
		public vtkCompositeDataSet(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601B29B RID: 111259 RVA: 0x0025EF4F File Offset: 0x0025D14F
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601B29C RID: 111260
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeDataSet_CURRENT_PROCESS_CAN_LOAD_BLOCK_01(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Key used to indicate that the current process can load the data
		/// in the node.  Used for parallel readers where the nodes are assigned
		/// to the processes by the reader to indicate further down the pipeline
		/// which nodes will be on which processes.
		/// ***THIS IS AN EXPERIMENTAL KEY SUBJECT TO CHANGE WITHOUT NOTICE***
		/// </summary>
		// Token: 0x0601B29D RID: 111261 RVA: 0x0025EF5C File Offset: 0x0025D15C
		public static vtkInformationIntegerKey CURRENT_PROCESS_CAN_LOAD_BLOCK()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeDataSet.vtkCompositeDataSet_CURRENT_PROCESS_CAN_LOAD_BLOCK_01(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		// Token: 0x0601B29E RID: 111262
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataSet_CompositeShallowCopy_02(HandleRef pThis, HandleRef src);

		/// <summary>
		/// The goal of the method is to copy the data up to the dataset pointers only.
		/// The implementation is delegated to the differenent subclasses.
		/// If you want to copy up to array pointers, @see vtkDataObject::ShallowCopy.
		///
		/// This method just calls vtkDataObject::ShallowCopy.
		/// </summary>
		// Token: 0x0601B29F RID: 111263 RVA: 0x0025EFC8 File Offset: 0x0025D1C8
		public virtual void CompositeShallowCopy(vtkCompositeDataSet src)
		{
			vtkCompositeDataSet.vtkCompositeDataSet_CompositeShallowCopy_02(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		// Token: 0x0601B2A0 RID: 111264
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataSet_CopyStructure_03(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Copies the tree structure from the input. All pointers to non-composite
		/// data objects are initialized to nullptr. This also shallow copies the meta data
		/// associated with all the nodes.
		/// </summary>
		// Token: 0x0601B2A1 RID: 111265 RVA: 0x0025EFF8 File Offset: 0x0025D1F8
		public virtual void CopyStructure(vtkCompositeDataSet input)
		{
			vtkCompositeDataSet.vtkCompositeDataSet_CopyStructure_03(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x0601B2A2 RID: 111266
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkCompositeDataSet_GetActualMemorySize_04(HandleRef pThis);

		/// <summary>
		/// Return the actual size of the data in kibibytes (1024 bytes). This number
		/// is valid only after the pipeline has updated.
		/// </summary>
		// Token: 0x0601B2A3 RID: 111267 RVA: 0x0025F028 File Offset: 0x0025D228
		public override uint GetActualMemorySize()
		{
			return vtkCompositeDataSet.vtkCompositeDataSet_GetActualMemorySize_04(base.GetCppThis());
		}

		// Token: 0x0601B2A4 RID: 111268
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataSet_GetBounds_05(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Return the geometric bounding box in the form (xmin,xmax, ymin,ymax,
		/// zmin,zmax).  Note that if the composite dataset contains abstract types
		/// (i.e., non vtkDataSet types) such as tables these will be ignored by the
		/// method. In cases where no vtkDataSet is contained in the composite
		/// dataset then the returned bounds will be undefined. THIS METHOD IS
		/// THREAD SAFE IF FIRST CALLED FROM A SINGLE THREAD AND THE DATASET IS NOT
		/// MODIFIED.
		/// </summary>
		// Token: 0x0601B2A5 RID: 111269 RVA: 0x0025F047 File Offset: 0x0025D247
		public void GetBounds(IntPtr bounds)
		{
			vtkCompositeDataSet.vtkCompositeDataSet_GetBounds_05(base.GetCppThis(), bounds);
		}

		// Token: 0x0601B2A6 RID: 111270
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeDataSet_GetData_06(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x0601B2A7 RID: 111271 RVA: 0x0025F058 File Offset: 0x0025D258
		public new static vtkCompositeDataSet GetData(vtkInformation info)
		{
			vtkCompositeDataSet vtkCompositeDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeDataSet.vtkCompositeDataSet_GetData_06((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositeDataSet = (vtkCompositeDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositeDataSet.Register(null);
				}
			}
			return vtkCompositeDataSet;
		}

		// Token: 0x0601B2A8 RID: 111272
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeDataSet_GetData_07(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x0601B2A9 RID: 111273 RVA: 0x0025F0D8 File Offset: 0x0025D2D8
		public new static vtkCompositeDataSet GetData(vtkInformationVector v, int i)
		{
			vtkCompositeDataSet vtkCompositeDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeDataSet.vtkCompositeDataSet_GetData_07((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositeDataSet = (vtkCompositeDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositeDataSet.Register(null);
				}
			}
			return vtkCompositeDataSet;
		}

		// Token: 0x0601B2AA RID: 111274
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeDataSet_GetDataObjectType_08(HandleRef pThis);

		/// <summary>
		/// Return class name of data type (see vtkType.h for
		/// definitions).
		/// </summary>
		// Token: 0x0601B2AB RID: 111275 RVA: 0x0025F158 File Offset: 0x0025D358
		public override int GetDataObjectType()
		{
			return vtkCompositeDataSet.vtkCompositeDataSet_GetDataObjectType_08(base.GetCppThis());
		}

		// Token: 0x0601B2AC RID: 111276
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeDataSet_GetDataSet_09(HandleRef pThis, HandleRef iter, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the dataset located at the position pointed by the iterator.
		/// The iterator does not need to be iterating over this dataset itself. It can
		/// be an iterator for composite dataset with similar structure (achieved by
		/// using CopyStructure).
		/// </summary>
		// Token: 0x0601B2AD RID: 111277 RVA: 0x0025F178 File Offset: 0x0025D378
		public virtual vtkDataObject GetDataSet(vtkCompositeDataIterator iter)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeDataSet.vtkCompositeDataSet_GetDataSet_09(base.GetCppThis(), (iter == null) ? default(HandleRef) : iter.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601B2AE RID: 111278
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeDataSet_GetDataSet_10(HandleRef pThis, uint flatIndex, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the dataset located at the position pointed by the flatIndex.
		/// If no dataset has the same flat index, nullptr is returned.
		///
		/// It should be noted that this function should be used ONLY when you already know the flat index.
		/// It should NOT be used when you are iterating over the composite dataset (in that case, prefer
		/// the vtkCompositeDataIterator).
		/// </summary>
		// Token: 0x0601B2AF RID: 111279 RVA: 0x0025F200 File Offset: 0x0025D400
		public virtual vtkDataObject GetDataSet(uint flatIndex)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeDataSet.vtkCompositeDataSet_GetDataSet_10(base.GetCppThis(), flatIndex, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601B2B0 RID: 111280
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompositeDataSet_GetNumberOfCells_11(HandleRef pThis);

		/// <summary>
		/// Returns the total number of cells of all blocks. This will
		/// iterate over all blocks and call GetNumberOfPoints() so it
		/// might be expensive.
		/// </summary>
		// Token: 0x0601B2B1 RID: 111281 RVA: 0x0025F270 File Offset: 0x0025D470
		public virtual long GetNumberOfCells()
		{
			return vtkCompositeDataSet.vtkCompositeDataSet_GetNumberOfCells_11(base.GetCppThis());
		}

		// Token: 0x0601B2B2 RID: 111282
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompositeDataSet_GetNumberOfElements_12(HandleRef pThis, int type);

		/// <summary>
		/// Get the number of elements for a specific attribute type (POINT, CELL, etc.).
		/// </summary>
		// Token: 0x0601B2B3 RID: 111283 RVA: 0x0025F290 File Offset: 0x0025D490
		public override long GetNumberOfElements(int type)
		{
			return vtkCompositeDataSet.vtkCompositeDataSet_GetNumberOfElements_12(base.GetCppThis(), type);
		}

		// Token: 0x0601B2B4 RID: 111284
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompositeDataSet_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B2B5 RID: 111285 RVA: 0x0025F2B0 File Offset: 0x0025D4B0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCompositeDataSet.vtkCompositeDataSet_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x0601B2B6 RID: 111286
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompositeDataSet_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B2B7 RID: 111287 RVA: 0x0025F2D0 File Offset: 0x0025D4D0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCompositeDataSet.vtkCompositeDataSet_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x0601B2B8 RID: 111288
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompositeDataSet_GetNumberOfPoints_15(HandleRef pThis);

		/// <summary>
		/// Returns the total number of points of all blocks. This will
		/// iterate over all blocks and call GetNumberOfPoints() so it
		/// might be expensive.
		/// </summary>
		// Token: 0x0601B2B9 RID: 111289 RVA: 0x0025F2EC File Offset: 0x0025D4EC
		public virtual long GetNumberOfPoints()
		{
			return vtkCompositeDataSet.vtkCompositeDataSet_GetNumberOfPoints_15(base.GetCppThis());
		}

		// Token: 0x0601B2BA RID: 111290
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataSet_Initialize_16(HandleRef pThis);

		/// <summary>
		/// Restore data object to initial state,
		/// </summary>
		// Token: 0x0601B2BB RID: 111291 RVA: 0x0025F30B File Offset: 0x0025D50B
		public override void Initialize()
		{
			vtkCompositeDataSet.vtkCompositeDataSet_Initialize_16(base.GetCppThis());
		}

		// Token: 0x0601B2BC RID: 111292
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeDataSet_IsA_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B2BD RID: 111293 RVA: 0x0025F31C File Offset: 0x0025D51C
		public override int IsA(string type)
		{
			return vtkCompositeDataSet.vtkCompositeDataSet_IsA_17(base.GetCppThis(), type);
		}

		// Token: 0x0601B2BE RID: 111294
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeDataSet_IsTypeOf_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B2BF RID: 111295 RVA: 0x0025F33C File Offset: 0x0025D53C
		public new static int IsTypeOf(string type)
		{
			return vtkCompositeDataSet.vtkCompositeDataSet_IsTypeOf_18(type);
		}

		// Token: 0x0601B2C0 RID: 111296
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeDataSet_NAME_19(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Key used to put node name in the meta-data associated with a node.
		/// </summary>
		// Token: 0x0601B2C1 RID: 111297 RVA: 0x0025F358 File Offset: 0x0025D558
		public static vtkInformationStringKey NAME()
		{
			vtkInformationStringKey vtkInformationStringKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeDataSet.vtkCompositeDataSet_NAME_19(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationStringKey = (vtkInformationStringKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationStringKey.Register(null);
				}
			}
			return vtkInformationStringKey;
		}

		// Token: 0x0601B2C2 RID: 111298
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeDataSet_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B2C3 RID: 111299 RVA: 0x0025F3C4 File Offset: 0x0025D5C4
		public new vtkCompositeDataSet NewInstance()
		{
			vtkCompositeDataSet result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeDataSet.vtkCompositeDataSet_NewInstance_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositeDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601B2C4 RID: 111300
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeDataSet_NewIterator_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return a new iterator (the iterator has to be deleted by user).
		/// </summary>
		// Token: 0x0601B2C5 RID: 111301 RVA: 0x0025F420 File Offset: 0x0025D620
		public virtual vtkCompositeDataIterator NewIterator()
		{
			vtkCompositeDataIterator vtkCompositeDataIterator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeDataSet.vtkCompositeDataSet_NewIterator_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601B2C6 RID: 111302
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeDataSet_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B2C7 RID: 111303 RVA: 0x0025F490 File Offset: 0x0025D690
		public new static vtkCompositeDataSet SafeDownCast(vtkObjectBase o)
		{
			vtkCompositeDataSet vtkCompositeDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeDataSet.vtkCompositeDataSet_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositeDataSet = (vtkCompositeDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositeDataSet.Register(null);
				}
			}
			return vtkCompositeDataSet;
		}

		// Token: 0x0601B2C8 RID: 111304
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataSet_SetDataSet_23(HandleRef pThis, HandleRef iter, HandleRef dataObj);

		/// <summary>
		/// Sets the data set at the location pointed by the iterator.
		/// The iterator does not need to be iterating over this dataset itself. It can
		/// be any composite dataset with similar structure (achieved by using
		/// CopyStructure).
		/// </summary>
		// Token: 0x0601B2C9 RID: 111305 RVA: 0x0025F510 File Offset: 0x0025D710
		public virtual void SetDataSet(vtkCompositeDataIterator iter, vtkDataObject dataObj)
		{
			vtkCompositeDataSet.vtkCompositeDataSet_SetDataSet_23(base.GetCppThis(), (iter == null) ? default(HandleRef) : iter.GetCppThis(), (dataObj == null) ? default(HandleRef) : dataObj.GetCppThis());
		}

		// Token: 0x0601B2CA RID: 111306
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeDataSet_SupportsGhostArray_24(HandleRef pThis, int type);

		/// <summary>
		/// Returns true for POINT or CELL, false otherwise
		/// </summary>
		// Token: 0x0601B2CB RID: 111307 RVA: 0x0025F554 File Offset: 0x0025D754
		public override bool SupportsGhostArray(int type)
		{
			return vtkCompositeDataSet.vtkCompositeDataSet_SupportsGhostArray_24(base.GetCppThis(), type) != 0;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D53 RID: 7507
		public new const string MRFullTypeName = "Kitware.VTK.vtkCompositeDataSet";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D54 RID: 7508
		public new static readonly string MRClassNameKey = "class vtkCompositeDataSet";
	}
}
