using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkScalarTree
	/// </summary>
	/// <remarks>
	///    organize data according to scalar values (used to accelerate contouring operations)
	///
	///
	/// vtkScalarTree is an abstract class that defines the API to concrete
	/// scalar tree subclasses. A scalar tree is a data structure that organizes
	/// data according to its scalar value. This allows rapid access to data for
	/// those algorithms that access the data based on scalar value. For example,
	/// isocontouring operates on cells based on the scalar (isocontour) value.
	///
	/// To use subclasses of this class, you must specify a dataset to operate on,
	/// and then specify a scalar value in the InitTraversal() method. Then
	/// calls to GetNextCell() return cells whose scalar data contains the
	/// scalar value specified. (This describes serial traversal.)
	///
	/// Methods supporting parallel traversal (such as threading) are also
	/// supported. Basically thread-safe batches of cells (which are a
	/// portion of the whole dataset) are available for processing using a
	/// parallel For() operation. First request the number of batches, and
	/// then for each batch, retrieve the array of cell ids in that batch. These
	/// batches contain cell ids that are likely to contain the isosurface.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkSimpleScalarTree vtkSpanSpace
	/// </seealso>
	// Token: 0x020009E1 RID: 2529
	public abstract class vtkScalarTree : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A500 RID: 107776 RVA: 0x0024874F File Offset: 0x0024694F
		static vtkScalarTree()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkScalarTree.MRClassNameKey, Type.GetType("Kitware.VTK.vtkScalarTree"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A501 RID: 107777 RVA: 0x00248777 File Offset: 0x00246977
		public vtkScalarTree(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A502 RID: 107778 RVA: 0x00248785 File Offset: 0x00246985
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A503 RID: 107779
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarTree_BuildTree_01(HandleRef pThis);

		/// <summary>
		/// Construct the scalar tree from the dataset provided. Checks build times
		/// and modified time from input and reconstructs the tree if necessary.
		/// </summary>
		// Token: 0x0601A504 RID: 107780 RVA: 0x00248790 File Offset: 0x00246990
		public virtual void BuildTree()
		{
			vtkScalarTree.vtkScalarTree_BuildTree_01(base.GetCppThis());
		}

		// Token: 0x0601A505 RID: 107781
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScalarTree_GetCellBatch_02(HandleRef pThis, long batchNum, ref long numCells);

		/// <summary>
		/// Return the array of cell ids in the specified batch. The method
		/// also returns the number of cell ids in the array. Make sure to
		/// call GetNumberOfCellBatches() beforehand.
		/// </summary>
		// Token: 0x0601A506 RID: 107782 RVA: 0x002487A0 File Offset: 0x002469A0
		public virtual IntPtr GetCellBatch(long batchNum, ref long numCells)
		{
			return vtkScalarTree.vtkScalarTree_GetCellBatch_02(base.GetCppThis(), batchNum, ref numCells);
		}

		// Token: 0x0601A507 RID: 107783
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScalarTree_GetDataSet_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Build the tree from the points/cells and scalars defining this
		/// dataset.
		/// </summary>
		// Token: 0x0601A508 RID: 107784 RVA: 0x002487C4 File Offset: 0x002469C4
		public virtual vtkDataSet GetDataSet()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScalarTree.vtkScalarTree_GetDataSet_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601A509 RID: 107785
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScalarTree_GetNextCell_04(HandleRef pThis, ref long cellId, HandleRef ptIds, HandleRef cellScalars, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the next cell that may contain scalar value specified to
		/// InitTraversal() (serial traversal). The value nullptr is returned if the
		/// list is exhausted. Make sure that InitTraversal() has been invoked first
		/// or you'll get erratic behavior.
		/// </summary>
		// Token: 0x0601A50A RID: 107786 RVA: 0x00248834 File Offset: 0x00246A34
		public virtual vtkCell GetNextCell(ref long cellId, vtkIdList ptIds, vtkDataArray cellScalars)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScalarTree.vtkScalarTree_GetNextCell_04(base.GetCppThis(), ref cellId, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis(), (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCell = (vtkCell)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCell.Register(null);
				}
			}
			return vtkCell;
		}

		// Token: 0x0601A50B RID: 107787
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkScalarTree_GetNumberOfCellBatches_05(HandleRef pThis, double scalarValue);

		/// <summary>
		/// Get the number of cell batches available for processing as a function of
		/// the specified scalar value. Each batch contains a list of candidate
		/// cells that may contain the specified isocontour value.
		/// </summary>
		// Token: 0x0601A50C RID: 107788 RVA: 0x002488D0 File Offset: 0x00246AD0
		public virtual long GetNumberOfCellBatches(double scalarValue)
		{
			return vtkScalarTree.vtkScalarTree_GetNumberOfCellBatches_05(base.GetCppThis(), scalarValue);
		}

		// Token: 0x0601A50D RID: 107789
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkScalarTree_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard type related macros and PrintSelf() method.
		/// </summary>
		// Token: 0x0601A50E RID: 107790 RVA: 0x002488F0 File Offset: 0x00246AF0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkScalarTree.vtkScalarTree_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0601A50F RID: 107791
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkScalarTree_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard type related macros and PrintSelf() method.
		/// </summary>
		// Token: 0x0601A510 RID: 107792 RVA: 0x00248910 File Offset: 0x00246B10
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkScalarTree.vtkScalarTree_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0601A511 RID: 107793
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkScalarTree_GetScalarValue_08(HandleRef pThis);

		/// <summary>
		/// Return the current scalar value over which tree traversal is proceeding.
		/// This is the scalar value provided in InitTraversal().
		/// </summary>
		// Token: 0x0601A512 RID: 107794 RVA: 0x0024892C File Offset: 0x00246B2C
		public double GetScalarValue()
		{
			return vtkScalarTree.vtkScalarTree_GetScalarValue_08(base.GetCppThis());
		}

		// Token: 0x0601A513 RID: 107795
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScalarTree_GetScalars_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Build the tree from the points/cells and scalars defining the
		/// dataset and scalars provided. Typically the scalars come from
		/// the vtkDataSet specified, but sometimes a separate vtkDataArray
		/// is provided to specify the scalars. If the scalar array is
		/// explicitly set, then it takes precedence over the scalars held
		/// in the vtkDataSet.
		/// </summary>
		// Token: 0x0601A514 RID: 107796 RVA: 0x0024894C File Offset: 0x00246B4C
		public virtual vtkDataArray GetScalars()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScalarTree.vtkScalarTree_GetScalars_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601A515 RID: 107797
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarTree_InitTraversal_10(HandleRef pThis, double scalarValue);

		/// <summary>
		/// Begin to traverse the cells based on a scalar value (serial
		/// traversal). Returned cells will have scalar values that span the scalar
		/// value specified. Note that changing the scalarValue does not cause the
		/// scalar tree to be modified, and hence it does not rebuild.
		/// </summary>
		// Token: 0x0601A516 RID: 107798 RVA: 0x002489BB File Offset: 0x00246BBB
		public virtual void InitTraversal(double scalarValue)
		{
			vtkScalarTree.vtkScalarTree_InitTraversal_10(base.GetCppThis(), scalarValue);
		}

		// Token: 0x0601A517 RID: 107799
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarTree_Initialize_11(HandleRef pThis);

		/// <summary>
		/// Initialize locator. Frees memory and resets object as appropriate.
		/// </summary>
		// Token: 0x0601A518 RID: 107800 RVA: 0x002489CB File Offset: 0x00246BCB
		public virtual void Initialize()
		{
			vtkScalarTree.vtkScalarTree_Initialize_11(base.GetCppThis());
		}

		// Token: 0x0601A519 RID: 107801
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarTree_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard type related macros and PrintSelf() method.
		/// </summary>
		// Token: 0x0601A51A RID: 107802 RVA: 0x002489DC File Offset: 0x00246BDC
		public override int IsA(string type)
		{
			return vtkScalarTree.vtkScalarTree_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x0601A51B RID: 107803
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarTree_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard type related macros and PrintSelf() method.
		/// </summary>
		// Token: 0x0601A51C RID: 107804 RVA: 0x002489FC File Offset: 0x00246BFC
		public new static int IsTypeOf(string type)
		{
			return vtkScalarTree.vtkScalarTree_IsTypeOf_13(type);
		}

		// Token: 0x0601A51D RID: 107805
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScalarTree_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard type related macros and PrintSelf() method.
		/// </summary>
		// Token: 0x0601A51E RID: 107806 RVA: 0x00248A18 File Offset: 0x00246C18
		public new vtkScalarTree NewInstance()
		{
			vtkScalarTree result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScalarTree.vtkScalarTree_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkScalarTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A51F RID: 107807
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScalarTree_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard type related macros and PrintSelf() method.
		/// </summary>
		// Token: 0x0601A520 RID: 107808 RVA: 0x00248A74 File Offset: 0x00246C74
		public new static vtkScalarTree SafeDownCast(vtkObjectBase o)
		{
			vtkScalarTree vtkScalarTree = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScalarTree.vtkScalarTree_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScalarTree = (vtkScalarTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScalarTree.Register(null);
				}
			}
			return vtkScalarTree;
		}

		// Token: 0x0601A521 RID: 107809
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarTree_SetDataSet_16(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Build the tree from the points/cells and scalars defining this
		/// dataset.
		/// </summary>
		// Token: 0x0601A522 RID: 107810 RVA: 0x00248AF4 File Offset: 0x00246CF4
		public virtual void SetDataSet(vtkDataSet arg0)
		{
			vtkScalarTree.vtkScalarTree_SetDataSet_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601A523 RID: 107811
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarTree_SetScalars_17(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Build the tree from the points/cells and scalars defining the
		/// dataset and scalars provided. Typically the scalars come from
		/// the vtkDataSet specified, but sometimes a separate vtkDataArray
		/// is provided to specify the scalars. If the scalar array is
		/// explicitly set, then it takes precedence over the scalars held
		/// in the vtkDataSet.
		/// </summary>
		// Token: 0x0601A524 RID: 107812 RVA: 0x00248B24 File Offset: 0x00246D24
		public virtual void SetScalars(vtkDataArray arg0)
		{
			vtkScalarTree.vtkScalarTree_SetScalars_17(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601A525 RID: 107813
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarTree_ShallowCopy_18(HandleRef pThis, HandleRef stree);

		/// <summary>
		/// This method is used to copy data members when cloning an instance of the
		/// class. It does not copy heavy data.
		/// </summary>
		// Token: 0x0601A526 RID: 107814 RVA: 0x00248B54 File Offset: 0x00246D54
		public virtual void ShallowCopy(vtkScalarTree stree)
		{
			vtkScalarTree.vtkScalarTree_ShallowCopy_18(base.GetCppThis(), (stree == null) ? default(HandleRef) : stree.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C92 RID: 7314
		public new const string MRFullTypeName = "Kitware.VTK.vtkScalarTree";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C93 RID: 7315
		public new static readonly string MRClassNameKey = "class vtkScalarTree";
	}
}
