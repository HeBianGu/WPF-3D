using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSimpleScalarTree
	/// </summary>
	/// <remarks>
	///    organize data according to scalar values (used to accelerate contouring operations)
	///
	/// vtkSimpleScalarTree creates a pointerless binary tree that helps search
	/// for cells that lie within a particular scalar range. This object is used
	/// to accelerate some contouring (and other scalar-based techniques).
	///
	/// The tree consists of an array of (min,max) scalar range pairs per
	/// node in the tree. The (min,max) range is determined from looking at
	/// the range of the children of the tree node. If the node is a leaf,
	/// then the range is determined by scanning the range of scalar data
	/// in n cells in the dataset. The n cells are determined by arbitrary
	/// selecting cell ids from id(i) to id(i+n), and where n is specified
	/// using the BranchingFactor ivar. Note that leaf node i=0 contains
	/// the scalar range computed from cell ids (0,n-1); leaf node i=1
	/// contains the range from cell ids (n,2n-1); and so on. The
	/// implication is that there are no direct lists of cell ids per leaf
	/// node, instead the cell ids are implicitly known. Despite the
	/// arbitrary grouping of cells, in practice this scalar tree actually
	/// performs quite well due to spatial/data coherence.
	///
	/// This class has an API that supports both serial and parallel
	/// operation.  The parallel API enables the using class to grab arrays
	/// (or batches) of cells that potentially intersect the
	/// isocontour. These batches can then be processed in separate
	/// threads.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkScalarTree vtkSpanSpace
	/// </seealso>
	// Token: 0x020009E3 RID: 2531
	public class vtkSimpleScalarTree : vtkScalarTree
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A536 RID: 107830 RVA: 0x00248D17 File Offset: 0x00246F17
		static vtkSimpleScalarTree()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSimpleScalarTree.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSimpleScalarTree"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A537 RID: 107831 RVA: 0x00248D3F File Offset: 0x00246F3F
		public vtkSimpleScalarTree(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601A538 RID: 107832
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSimpleScalarTree_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate scalar tree with maximum level of 20 and branching
		/// factor of three.
		/// </summary>
		// Token: 0x0601A539 RID: 107833 RVA: 0x00248D50 File Offset: 0x00246F50
		public new static vtkSimpleScalarTree New()
		{
			vtkSimpleScalarTree result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSimpleScalarTree.vtkSimpleScalarTree_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSimpleScalarTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate scalar tree with maximum level of 20 and branching
		/// factor of three.
		/// </summary>
		// Token: 0x0601A53A RID: 107834 RVA: 0x00248DA4 File Offset: 0x00246FA4
		public vtkSimpleScalarTree() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSimpleScalarTree.vtkSimpleScalarTree_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A53B RID: 107835 RVA: 0x00248DE8 File Offset: 0x00246FE8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A53C RID: 107836
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimpleScalarTree_BuildTree_01(HandleRef pThis);

		/// <summary>
		/// Construct the scalar tree from the dataset provided. Checks build times
		/// and modified time from input and reconstructs the tree if necessary.
		/// </summary>
		// Token: 0x0601A53D RID: 107837 RVA: 0x00248DF3 File Offset: 0x00246FF3
		public override void BuildTree()
		{
			vtkSimpleScalarTree.vtkSimpleScalarTree_BuildTree_01(base.GetCppThis());
		}

		// Token: 0x0601A53E RID: 107838
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimpleScalarTree_GetBranchingFactor_02(HandleRef pThis);

		/// <summary>
		/// Set the branching factor for the tree. This is the number of
		/// children per tree node. Smaller values (minimum is 2) mean deeper
		/// trees and more memory overhead. Larger values mean shallower
		/// trees, less memory usage, but worse performance.
		/// </summary>
		// Token: 0x0601A53F RID: 107839 RVA: 0x00248E04 File Offset: 0x00247004
		public virtual int GetBranchingFactor()
		{
			return vtkSimpleScalarTree.vtkSimpleScalarTree_GetBranchingFactor_02(base.GetCppThis());
		}

		// Token: 0x0601A540 RID: 107840
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimpleScalarTree_GetBranchingFactorMaxValue_03(HandleRef pThis);

		/// <summary>
		/// Set the branching factor for the tree. This is the number of
		/// children per tree node. Smaller values (minimum is 2) mean deeper
		/// trees and more memory overhead. Larger values mean shallower
		/// trees, less memory usage, but worse performance.
		/// </summary>
		// Token: 0x0601A541 RID: 107841 RVA: 0x00248E24 File Offset: 0x00247024
		public virtual int GetBranchingFactorMaxValue()
		{
			return vtkSimpleScalarTree.vtkSimpleScalarTree_GetBranchingFactorMaxValue_03(base.GetCppThis());
		}

		// Token: 0x0601A542 RID: 107842
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimpleScalarTree_GetBranchingFactorMinValue_04(HandleRef pThis);

		/// <summary>
		/// Set the branching factor for the tree. This is the number of
		/// children per tree node. Smaller values (minimum is 2) mean deeper
		/// trees and more memory overhead. Larger values mean shallower
		/// trees, less memory usage, but worse performance.
		/// </summary>
		// Token: 0x0601A543 RID: 107843 RVA: 0x00248E44 File Offset: 0x00247044
		public virtual int GetBranchingFactorMinValue()
		{
			return vtkSimpleScalarTree.vtkSimpleScalarTree_GetBranchingFactorMinValue_04(base.GetCppThis());
		}

		// Token: 0x0601A544 RID: 107844
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSimpleScalarTree_GetCellBatch_05(HandleRef pThis, long batchNum, ref long numCells);

		/// <summary>
		/// Return the array of cell ids in the specified batch. The method
		/// also returns the number of cell ids in the array. Make sure to
		/// call GetNumberOfCellBatches() beforehand.
		/// </summary>
		// Token: 0x0601A545 RID: 107845 RVA: 0x00248E64 File Offset: 0x00247064
		public override IntPtr GetCellBatch(long batchNum, ref long numCells)
		{
			return vtkSimpleScalarTree.vtkSimpleScalarTree_GetCellBatch_05(base.GetCppThis(), batchNum, ref numCells);
		}

		// Token: 0x0601A546 RID: 107846
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimpleScalarTree_GetLevel_06(HandleRef pThis);

		/// <summary>
		/// Get the level of the scalar tree. This value may change each time the
		/// scalar tree is built and the branching factor changes.
		/// </summary>
		// Token: 0x0601A547 RID: 107847 RVA: 0x00248E88 File Offset: 0x00247088
		public virtual int GetLevel()
		{
			return vtkSimpleScalarTree.vtkSimpleScalarTree_GetLevel_06(base.GetCppThis());
		}

		// Token: 0x0601A548 RID: 107848
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimpleScalarTree_GetMaxLevel_07(HandleRef pThis);

		/// <summary>
		/// Set the maximum allowable level for the tree.
		/// </summary>
		// Token: 0x0601A549 RID: 107849 RVA: 0x00248EA8 File Offset: 0x002470A8
		public virtual int GetMaxLevel()
		{
			return vtkSimpleScalarTree.vtkSimpleScalarTree_GetMaxLevel_07(base.GetCppThis());
		}

		// Token: 0x0601A54A RID: 107850
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimpleScalarTree_GetMaxLevelMaxValue_08(HandleRef pThis);

		/// <summary>
		/// Set the maximum allowable level for the tree.
		/// </summary>
		// Token: 0x0601A54B RID: 107851 RVA: 0x00248EC8 File Offset: 0x002470C8
		public virtual int GetMaxLevelMaxValue()
		{
			return vtkSimpleScalarTree.vtkSimpleScalarTree_GetMaxLevelMaxValue_08(base.GetCppThis());
		}

		// Token: 0x0601A54C RID: 107852
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimpleScalarTree_GetMaxLevelMinValue_09(HandleRef pThis);

		/// <summary>
		/// Set the maximum allowable level for the tree.
		/// </summary>
		// Token: 0x0601A54D RID: 107853 RVA: 0x00248EE8 File Offset: 0x002470E8
		public virtual int GetMaxLevelMinValue()
		{
			return vtkSimpleScalarTree.vtkSimpleScalarTree_GetMaxLevelMinValue_09(base.GetCppThis());
		}

		// Token: 0x0601A54E RID: 107854
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSimpleScalarTree_GetNextCell_10(HandleRef pThis, ref long cellId, HandleRef ptIds, HandleRef cellScalars, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the next cell that may contain scalar value specified to
		/// initialize traversal. The value nullptr is returned if the list is
		/// exhausted. Make sure that InitTraversal() has been invoked first or
		/// you'll get erratic behavior.
		/// </summary>
		// Token: 0x0601A54F RID: 107855 RVA: 0x00248F08 File Offset: 0x00247108
		public override vtkCell GetNextCell(ref long cellId, vtkIdList ptIds, vtkDataArray cellScalars)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSimpleScalarTree.vtkSimpleScalarTree_GetNextCell_10(base.GetCppThis(), ref cellId, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis(), (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601A550 RID: 107856
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSimpleScalarTree_GetNumberOfCellBatches_11(HandleRef pThis, double scalarValue);

		/// <summary>
		/// Get the number of cell batches available for processing as a function of
		/// the specified scalar value. Each batch contains a list of candidate
		/// cells that may contain the specified isocontour value.
		/// </summary>
		// Token: 0x0601A551 RID: 107857 RVA: 0x00248FA4 File Offset: 0x002471A4
		public override long GetNumberOfCellBatches(double scalarValue)
		{
			return vtkSimpleScalarTree.vtkSimpleScalarTree_GetNumberOfCellBatches_11(base.GetCppThis(), scalarValue);
		}

		// Token: 0x0601A552 RID: 107858
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSimpleScalarTree_GetNumberOfGenerationsFromBase_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard type related macros and PrintSelf() method.
		/// </summary>
		// Token: 0x0601A553 RID: 107859 RVA: 0x00248FC4 File Offset: 0x002471C4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSimpleScalarTree.vtkSimpleScalarTree_GetNumberOfGenerationsFromBase_12(base.GetCppThis(), type);
		}

		// Token: 0x0601A554 RID: 107860
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSimpleScalarTree_GetNumberOfGenerationsFromBaseType_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard type related macros and PrintSelf() method.
		/// </summary>
		// Token: 0x0601A555 RID: 107861 RVA: 0x00248FE4 File Offset: 0x002471E4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSimpleScalarTree.vtkSimpleScalarTree_GetNumberOfGenerationsFromBaseType_13(type);
		}

		// Token: 0x0601A556 RID: 107862
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimpleScalarTree_InitTraversal_14(HandleRef pThis, double scalarValue);

		/// <summary>
		/// Begin to traverse the cells based on a scalar value. Returned cells
		/// will likely have scalar values that span the scalar value specified.
		/// </summary>
		// Token: 0x0601A557 RID: 107863 RVA: 0x00248FFE File Offset: 0x002471FE
		public override void InitTraversal(double scalarValue)
		{
			vtkSimpleScalarTree.vtkSimpleScalarTree_InitTraversal_14(base.GetCppThis(), scalarValue);
		}

		// Token: 0x0601A558 RID: 107864
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimpleScalarTree_Initialize_15(HandleRef pThis);

		/// <summary>
		/// Initialize locator. Frees memory and resets object as appropriate.
		/// </summary>
		// Token: 0x0601A559 RID: 107865 RVA: 0x0024900E File Offset: 0x0024720E
		public override void Initialize()
		{
			vtkSimpleScalarTree.vtkSimpleScalarTree_Initialize_15(base.GetCppThis());
		}

		// Token: 0x0601A55A RID: 107866
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimpleScalarTree_IsA_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard type related macros and PrintSelf() method.
		/// </summary>
		// Token: 0x0601A55B RID: 107867 RVA: 0x00249020 File Offset: 0x00247220
		public override int IsA(string type)
		{
			return vtkSimpleScalarTree.vtkSimpleScalarTree_IsA_16(base.GetCppThis(), type);
		}

		// Token: 0x0601A55C RID: 107868
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimpleScalarTree_IsTypeOf_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard type related macros and PrintSelf() method.
		/// </summary>
		// Token: 0x0601A55D RID: 107869 RVA: 0x00249040 File Offset: 0x00247240
		public new static int IsTypeOf(string type)
		{
			return vtkSimpleScalarTree.vtkSimpleScalarTree_IsTypeOf_17(type);
		}

		// Token: 0x0601A55E RID: 107870
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSimpleScalarTree_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard type related macros and PrintSelf() method.
		/// </summary>
		// Token: 0x0601A55F RID: 107871 RVA: 0x0024905C File Offset: 0x0024725C
		public new vtkSimpleScalarTree NewInstance()
		{
			vtkSimpleScalarTree result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSimpleScalarTree.vtkSimpleScalarTree_NewInstance_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSimpleScalarTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A560 RID: 107872
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSimpleScalarTree_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard type related macros and PrintSelf() method.
		/// </summary>
		// Token: 0x0601A561 RID: 107873 RVA: 0x002490B8 File Offset: 0x002472B8
		public new static vtkSimpleScalarTree SafeDownCast(vtkObjectBase o)
		{
			vtkSimpleScalarTree vtkSimpleScalarTree = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSimpleScalarTree.vtkSimpleScalarTree_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSimpleScalarTree = (vtkSimpleScalarTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSimpleScalarTree.Register(null);
				}
			}
			return vtkSimpleScalarTree;
		}

		// Token: 0x0601A562 RID: 107874
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimpleScalarTree_SetBranchingFactor_21(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the branching factor for the tree. This is the number of
		/// children per tree node. Smaller values (minimum is 2) mean deeper
		/// trees and more memory overhead. Larger values mean shallower
		/// trees, less memory usage, but worse performance.
		/// </summary>
		// Token: 0x0601A563 RID: 107875 RVA: 0x00249137 File Offset: 0x00247337
		public virtual void SetBranchingFactor(int _arg)
		{
			vtkSimpleScalarTree.vtkSimpleScalarTree_SetBranchingFactor_21(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A564 RID: 107876
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimpleScalarTree_SetMaxLevel_22(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the maximum allowable level for the tree.
		/// </summary>
		// Token: 0x0601A565 RID: 107877 RVA: 0x00249147 File Offset: 0x00247347
		public virtual void SetMaxLevel(int _arg)
		{
			vtkSimpleScalarTree.vtkSimpleScalarTree_SetMaxLevel_22(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A566 RID: 107878
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimpleScalarTree_ShallowCopy_23(HandleRef pThis, HandleRef stree);

		/// <summary>
		/// This method is used to copy data members when cloning an instance of the
		/// class. It does not copy heavy data.
		/// </summary>
		// Token: 0x0601A567 RID: 107879 RVA: 0x00249158 File Offset: 0x00247358
		public override void ShallowCopy(vtkScalarTree stree)
		{
			vtkSimpleScalarTree.vtkSimpleScalarTree_ShallowCopy_23(base.GetCppThis(), (stree == null) ? default(HandleRef) : stree.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C96 RID: 7318
		public new const string MRFullTypeName = "Kitware.VTK.vtkSimpleScalarTree";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C97 RID: 7319
		public new static readonly string MRClassNameKey = "class vtkSimpleScalarTree";
	}
}
