using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCellArrayIterator
	/// </summary>
	/// <remarks>
	///    Encapsulate traversal logic for vtkCellArray.
	///
	/// This is iterator for thread-safe traversal of a vtkCellArray. It provides
	/// random access and forward iteration. Typical usage for forward iteration
	/// looks like:
	///
	/// ```
	/// auto iter = vtk::TakeSmartPointer(cellArray-&gt;NewIterator());
	/// for (iter-&gt;GoToFirstCell(); !iter-&gt;IsDoneWithTraversal(); iter-&gt;GoToNextCell())
	/// {
	///   // do work with iter
	///   iter-&gt;GetCurrentCell(numCellPts, cellPts);
	/// }
	/// ```
	///
	/// Typical usage for random access looks like:
	///
	/// ```
	/// auto iter = vtk::TakeSmartPointer(cellArray-&gt;NewIterator());
	/// iter-&gt;GetCellAtId(cellId, numCellPts, cellPts);
	/// ```
	///
	/// Here @a cellId is the id of the ith cell in the vtkCellArray;
	/// @a numCellPts is the number of points defining the cell represented
	/// as vtkIdType; and @a cellPts is a pointer to the point ids defined
	/// as vtkIdType const*&amp;.
	///
	/// Internally the iterator may copy data from the vtkCellArray, or reference
	/// the internal vtkCellArray storage. This depends on the relationship of
	/// vtkIdType to the type and structure of internal storage. If the type of
	/// storage is the same as vtkIdType, and the storage is a single-component
	/// AOS array (i.e., a 1D array), then shared access to the vtkCellArray
	/// storage is provided. Otherwise, the data from storage is copied into an
	/// internal iterator buffer. (Of course copying is slower and can result in
	/// 3-4x reduction in traversal performance. On the other hand, the
	/// vtkCellArray can use the appropriate storage to save memory, perform
	/// zero-copy, and/or efficiently represent the cell connectivity
	/// information.) Note that referencing internal vtkCellArray storage has
	/// implications on the validity of the iterator. If the underlying
	/// vtkCellArray storage changes while iterating, and the iterator is
	/// referencing this storage, unpredictable and catastrophic results are
	/// likely - hence do not modify the vtkCellArray while iterating.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkCellArray
	/// </seealso>
	// Token: 0x02000A14 RID: 2580
	public class vtkCellArrayIterator : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601AE0E RID: 110094 RVA: 0x0025745B File Offset: 0x0025565B
		static vtkCellArrayIterator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellArrayIterator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellArrayIterator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601AE0F RID: 110095 RVA: 0x00257483 File Offset: 0x00255683
		public vtkCellArrayIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601AE10 RID: 110096
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellArrayIterator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601AE11 RID: 110097 RVA: 0x00257494 File Offset: 0x00255694
		public new static vtkCellArrayIterator New()
		{
			vtkCellArrayIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellArrayIterator.vtkCellArrayIterator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellArrayIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601AE12 RID: 110098 RVA: 0x002574E8 File Offset: 0x002556E8
		public vtkCellArrayIterator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCellArrayIterator.vtkCellArrayIterator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601AE13 RID: 110099 RVA: 0x0025752C File Offset: 0x0025572C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601AE14 RID: 110100
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellArrayIterator_GetCellArray_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the vtkCellArray object over which iteration is occurring.
		/// </summary>
		// Token: 0x0601AE15 RID: 110101 RVA: 0x00257538 File Offset: 0x00255738
		public vtkCellArray GetCellArray()
		{
			vtkCellArray vtkCellArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellArrayIterator.vtkCellArrayIterator_GetCellArray_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellArray = (vtkCellArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellArray.Register(null);
				}
			}
			return vtkCellArray;
		}

		// Token: 0x0601AE16 RID: 110102
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellArrayIterator_GetCellAtId_02(HandleRef pThis, long cellId, HandleRef cellIds);

		/// <summary>
		/// Initialize the iterator to a specific cell and return the cell. Note
		/// that methods passing vtkIdLists always copy data from the vtkCellArray
		/// storage buffer into the vtkIdList. Otherwise, a fastpath returning
		/// (numCellPts,cellPts) which may return a pointer to internal vtkCellArray
		/// storage is possible, if vtkIdType is the same as the vtkCellArray buffer
		/// (which is typical).
		/// </summary>
		// Token: 0x0601AE17 RID: 110103 RVA: 0x002575A8 File Offset: 0x002557A8
		public void GetCellAtId(long cellId, vtkIdList cellIds)
		{
			vtkCellArrayIterator.vtkCellArrayIterator_GetCellAtId_02(base.GetCppThis(), cellId, (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis());
		}

		// Token: 0x0601AE18 RID: 110104
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellArrayIterator_GetCellAtId_03(HandleRef pThis, long cellId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Initialize the iterator to a specific cell and return the cell. Note
		/// that methods passing vtkIdLists always copy data from the vtkCellArray
		/// storage buffer into the vtkIdList. Otherwise, a fastpath returning
		/// (numCellPts,cellPts) which may return a pointer to internal vtkCellArray
		/// storage is possible, if vtkIdType is the same as the vtkCellArray buffer
		/// (which is typical).
		/// </summary>
		// Token: 0x0601AE19 RID: 110105 RVA: 0x002575D8 File Offset: 0x002557D8
		public vtkIdList GetCellAtId(long cellId)
		{
			vtkIdList vtkIdList = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellArrayIterator.vtkCellArrayIterator_GetCellAtId_03(base.GetCppThis(), cellId, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdList = (vtkIdList)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdList.Register(null);
				}
			}
			return vtkIdList;
		}

		// Token: 0x0601AE1A RID: 110106
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellArrayIterator_GetCurrentCell_04(HandleRef pThis, HandleRef ids);

		/// <summary>
		/// Returns the definition of the current cell during forward
		/// traversal. Note that methods passing vtkIdLists always copy data from
		/// the vtkCellArray storage buffer into the vtkIdList. Otherwise, a
		/// fastpath returning (numCellPts,cellPts) - which may return a pointer to
		/// internal vtkCellArray storage - is possible, if vtkIdType is the same as
		/// the vtkCellArray storage (which is typical).
		/// </summary>
		// Token: 0x0601AE1B RID: 110107 RVA: 0x00257648 File Offset: 0x00255848
		public void GetCurrentCell(vtkIdList ids)
		{
			vtkCellArrayIterator.vtkCellArrayIterator_GetCurrentCell_04(base.GetCppThis(), (ids == null) ? default(HandleRef) : ids.GetCppThis());
		}

		// Token: 0x0601AE1C RID: 110108
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellArrayIterator_GetCurrentCell_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the definition of the current cell during forward
		/// traversal. Note that methods passing vtkIdLists always copy data from
		/// the vtkCellArray storage buffer into the vtkIdList. Otherwise, a
		/// fastpath returning (numCellPts,cellPts) - which may return a pointer to
		/// internal vtkCellArray storage - is possible, if vtkIdType is the same as
		/// the vtkCellArray storage (which is typical).
		/// </summary>
		// Token: 0x0601AE1D RID: 110109 RVA: 0x00257678 File Offset: 0x00255878
		public vtkIdList GetCurrentCell()
		{
			vtkIdList vtkIdList = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellArrayIterator.vtkCellArrayIterator_GetCurrentCell_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdList = (vtkIdList)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdList.Register(null);
				}
			}
			return vtkIdList;
		}

		// Token: 0x0601AE1E RID: 110110
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellArrayIterator_GetCurrentCellId_06(HandleRef pThis);

		/// <summary>
		/// Returns the id of the current cell during forward iteration.
		/// </summary>
		// Token: 0x0601AE1F RID: 110111 RVA: 0x002576E8 File Offset: 0x002558E8
		public long GetCurrentCellId()
		{
			return vtkCellArrayIterator.vtkCellArrayIterator_GetCurrentCellId_06(base.GetCppThis());
		}

		// Token: 0x0601AE20 RID: 110112
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellArrayIterator_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601AE21 RID: 110113 RVA: 0x00257708 File Offset: 0x00255908
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCellArrayIterator.vtkCellArrayIterator_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0601AE22 RID: 110114
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellArrayIterator_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601AE23 RID: 110115 RVA: 0x00257728 File Offset: 0x00255928
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCellArrayIterator.vtkCellArrayIterator_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x0601AE24 RID: 110116
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellArrayIterator_GoToCell_09(HandleRef pThis, long cellId);

		/// <summary>
		/// Initialize the iterator to a specific cell. This will revalidate the
		/// iterator if the underlying vtkCellArray has been modified. This method
		/// can always be used to set the starting location for forward iteration,
		/// and it is also used to support random access.
		/// </summary>
		// Token: 0x0601AE25 RID: 110117 RVA: 0x00257742 File Offset: 0x00255942
		public void GoToCell(long cellId)
		{
			vtkCellArrayIterator.vtkCellArrayIterator_GoToCell_09(base.GetCppThis(), cellId);
		}

		// Token: 0x0601AE26 RID: 110118
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellArrayIterator_GoToFirstCell_10(HandleRef pThis);

		/// <summary>
		/// Initialize the iterator for forward iteration. This will revalidate the
		/// iterator if the underlying vtkCellArray has been modified.
		/// </summary>
		// Token: 0x0601AE27 RID: 110119 RVA: 0x00257752 File Offset: 0x00255952
		public void GoToFirstCell()
		{
			vtkCellArrayIterator.vtkCellArrayIterator_GoToFirstCell_10(base.GetCppThis());
		}

		// Token: 0x0601AE28 RID: 110120
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellArrayIterator_GoToNextCell_11(HandleRef pThis);

		/// <summary>
		/// Advance the forward iterator to the next cell.
		/// </summary>
		// Token: 0x0601AE29 RID: 110121 RVA: 0x00257761 File Offset: 0x00255961
		public void GoToNextCell()
		{
			vtkCellArrayIterator.vtkCellArrayIterator_GoToNextCell_11(base.GetCppThis());
		}

		// Token: 0x0601AE2A RID: 110122
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellArrayIterator_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601AE2B RID: 110123 RVA: 0x00257770 File Offset: 0x00255970
		public override int IsA(string type)
		{
			return vtkCellArrayIterator.vtkCellArrayIterator_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x0601AE2C RID: 110124
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCellArrayIterator_IsDoneWithTraversal_13(HandleRef pThis);

		/// <summary>
		/// Returns true if the iterator has completed the traversal.
		/// </summary>
		// Token: 0x0601AE2D RID: 110125 RVA: 0x00257790 File Offset: 0x00255990
		public bool IsDoneWithTraversal()
		{
			return vtkCellArrayIterator.vtkCellArrayIterator_IsDoneWithTraversal_13(base.GetCppThis()) != 0;
		}

		// Token: 0x0601AE2E RID: 110126
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellArrayIterator_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601AE2F RID: 110127 RVA: 0x002577B8 File Offset: 0x002559B8
		public new static int IsTypeOf(string type)
		{
			return vtkCellArrayIterator.vtkCellArrayIterator_IsTypeOf_14(type);
		}

		// Token: 0x0601AE30 RID: 110128
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellArrayIterator_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601AE31 RID: 110129 RVA: 0x002577D4 File Offset: 0x002559D4
		public new vtkCellArrayIterator NewInstance()
		{
			vtkCellArrayIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellArrayIterator.vtkCellArrayIterator_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellArrayIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601AE32 RID: 110130
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellArrayIterator_ReplaceCurrentCell_17(HandleRef pThis, HandleRef list);

		/// <summary>
		/// Replace the current cell with the ids in `list`. Note that this method
		/// CANNOT change the number of points in the cell, it can only redefine the
		/// ids (e.g. `list` must contain the same number of entries as the current
		/// cell's points).
		/// </summary>
		// Token: 0x0601AE33 RID: 110131 RVA: 0x00257830 File Offset: 0x00255A30
		public void ReplaceCurrentCell(vtkIdList list)
		{
			vtkCellArrayIterator.vtkCellArrayIterator_ReplaceCurrentCell_17(base.GetCppThis(), (list == null) ? default(HandleRef) : list.GetCppThis());
		}

		// Token: 0x0601AE34 RID: 110132
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellArrayIterator_ReplaceCurrentCell_18(HandleRef pThis, long npts, IntPtr pts);

		/// <summary>
		/// Replace the current cell with the ids in `pts`. Note that this method
		/// CANNOT change the number of points in the cell, it can only redefine the
		/// ids (e.g. `npts` must equal the current cell's number of points).
		/// </summary>
		// Token: 0x0601AE35 RID: 110133 RVA: 0x0025785F File Offset: 0x00255A5F
		public void ReplaceCurrentCell(long npts, IntPtr pts)
		{
			vtkCellArrayIterator.vtkCellArrayIterator_ReplaceCurrentCell_18(base.GetCppThis(), npts, pts);
		}

		// Token: 0x0601AE36 RID: 110134
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellArrayIterator_ReverseCurrentCell_19(HandleRef pThis);

		/// <summary>
		/// Reverses the order of the point ids in the current cell.
		/// </summary>
		// Token: 0x0601AE37 RID: 110135 RVA: 0x00257870 File Offset: 0x00255A70
		public void ReverseCurrentCell()
		{
			vtkCellArrayIterator.vtkCellArrayIterator_ReverseCurrentCell_19(base.GetCppThis());
		}

		// Token: 0x0601AE38 RID: 110136
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellArrayIterator_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601AE39 RID: 110137 RVA: 0x00257880 File Offset: 0x00255A80
		public new static vtkCellArrayIterator SafeDownCast(vtkObjectBase o)
		{
			vtkCellArrayIterator vtkCellArrayIterator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellArrayIterator.vtkCellArrayIterator_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellArrayIterator = (vtkCellArrayIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellArrayIterator.Register(null);
				}
			}
			return vtkCellArrayIterator;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D00 RID: 7424
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellArrayIterator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D01 RID: 7425
		public new static readonly string MRClassNameKey = "class vtkCellArrayIterator";
	}
}
