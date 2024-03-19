using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDataObjectTreeIterator
	/// </summary>
	/// <remarks>
	///    superclass for composite data iterators
	///
	/// vtkDataObjectTreeIterator provides an interface for accessing datasets
	/// in a collection (vtkDataObjectTreeIterator).
	/// </remarks>
	// Token: 0x02000A3B RID: 2619
	public class vtkDataObjectTreeIterator : vtkCompositeDataIterator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601B493 RID: 111763 RVA: 0x002622DB File Offset: 0x002604DB
		static vtkDataObjectTreeIterator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataObjectTreeIterator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataObjectTreeIterator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601B494 RID: 111764 RVA: 0x00262303 File Offset: 0x00260503
		public vtkDataObjectTreeIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601B495 RID: 111765
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectTreeIterator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B496 RID: 111766 RVA: 0x00262314 File Offset: 0x00260514
		public new static vtkDataObjectTreeIterator New()
		{
			vtkDataObjectTreeIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectTreeIterator.vtkDataObjectTreeIterator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataObjectTreeIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B497 RID: 111767 RVA: 0x00262368 File Offset: 0x00260568
		public vtkDataObjectTreeIterator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDataObjectTreeIterator.vtkDataObjectTreeIterator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601B498 RID: 111768 RVA: 0x002623AC File Offset: 0x002605AC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601B499 RID: 111769
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectTreeIterator_GetCurrentDataObject_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the current item. Valid only when IsDoneWithTraversal() returns 0.
		/// </summary>
		// Token: 0x0601B49A RID: 111770 RVA: 0x002623B8 File Offset: 0x002605B8
		public override vtkDataObject GetCurrentDataObject()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectTreeIterator.vtkDataObjectTreeIterator_GetCurrentDataObject_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601B49B RID: 111771
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkDataObjectTreeIterator_GetCurrentFlatIndex_02(HandleRef pThis);

		/// <summary>
		/// Flat index is an index obtained by traversing the tree in preorder.
		/// This can be used to uniquely identify nodes in the tree.
		/// Not valid if IsDoneWithTraversal() returns true.
		/// </summary>
		// Token: 0x0601B49C RID: 111772 RVA: 0x00262428 File Offset: 0x00260628
		public override uint GetCurrentFlatIndex()
		{
			return vtkDataObjectTreeIterator.vtkDataObjectTreeIterator_GetCurrentFlatIndex_02(base.GetCppThis());
		}

		// Token: 0x0601B49D RID: 111773
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectTreeIterator_GetCurrentMetaData_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the meta-data associated with the current item.
		/// Note that, depending on iterator implementation, the returned information
		/// is not necessarily stored on the current object. So modifying the information
		/// is forbidden.
		/// </summary>
		// Token: 0x0601B49E RID: 111774 RVA: 0x00262448 File Offset: 0x00260648
		public override vtkInformation GetCurrentMetaData()
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectTreeIterator.vtkDataObjectTreeIterator_GetCurrentMetaData_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601B49F RID: 111775
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataObjectTreeIterator_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B4A0 RID: 111776 RVA: 0x002624B8 File Offset: 0x002606B8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDataObjectTreeIterator.vtkDataObjectTreeIterator_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601B4A1 RID: 111777
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataObjectTreeIterator_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B4A2 RID: 111778 RVA: 0x002624D8 File Offset: 0x002606D8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDataObjectTreeIterator.vtkDataObjectTreeIterator_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601B4A3 RID: 111779
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectTreeIterator_GetTraverseSubTree_06(HandleRef pThis);

		/// <summary>
		/// If TraverseSubTree is set to true, the iterator will visit the entire tree
		/// structure, otherwise it only visits the first level children. Set to 1 by
		/// default.
		/// </summary>
		// Token: 0x0601B4A4 RID: 111780 RVA: 0x002624F4 File Offset: 0x002606F4
		public virtual int GetTraverseSubTree()
		{
			return vtkDataObjectTreeIterator.vtkDataObjectTreeIterator_GetTraverseSubTree_06(base.GetCppThis());
		}

		// Token: 0x0601B4A5 RID: 111781
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectTreeIterator_GetVisitOnlyLeaves_07(HandleRef pThis);

		/// <summary>
		/// If VisitOnlyLeaves is true, the iterator will only visit nodes
		/// (sub-datasets) that are not composite. If it encounters a composite
		/// data set, it will automatically traverse that composite dataset until
		/// it finds non-composite datasets. With this options, it is possible to
		/// visit all non-composite datasets in tree of composite datasets
		/// (composite of composite of composite for example :-) ) If
		/// VisitOnlyLeaves is false, GetCurrentDataObject() may return
		/// vtkCompositeDataSet. By default, VisitOnlyLeaves is 1.
		/// </summary>
		// Token: 0x0601B4A6 RID: 111782 RVA: 0x00262514 File Offset: 0x00260714
		public virtual int GetVisitOnlyLeaves()
		{
			return vtkDataObjectTreeIterator.vtkDataObjectTreeIterator_GetVisitOnlyLeaves_07(base.GetCppThis());
		}

		// Token: 0x0601B4A7 RID: 111783
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectTreeIterator_GoToFirstItem_08(HandleRef pThis);

		/// <summary>
		/// Move the iterator to the beginning of the collection.
		/// </summary>
		// Token: 0x0601B4A8 RID: 111784 RVA: 0x00262533 File Offset: 0x00260733
		public override void GoToFirstItem()
		{
			vtkDataObjectTreeIterator.vtkDataObjectTreeIterator_GoToFirstItem_08(base.GetCppThis());
		}

		// Token: 0x0601B4A9 RID: 111785
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectTreeIterator_GoToNextItem_09(HandleRef pThis);

		/// <summary>
		/// Move the iterator to the next item in the collection.
		/// </summary>
		// Token: 0x0601B4AA RID: 111786 RVA: 0x00262542 File Offset: 0x00260742
		public override void GoToNextItem()
		{
			vtkDataObjectTreeIterator.vtkDataObjectTreeIterator_GoToNextItem_09(base.GetCppThis());
		}

		// Token: 0x0601B4AB RID: 111787
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectTreeIterator_HasCurrentMetaData_10(HandleRef pThis);

		/// <summary>
		/// Returns if the a meta-data information object is present for the current
		/// item. Return 1 on success, 0 otherwise.
		/// </summary>
		// Token: 0x0601B4AC RID: 111788 RVA: 0x00262554 File Offset: 0x00260754
		public override int HasCurrentMetaData()
		{
			return vtkDataObjectTreeIterator.vtkDataObjectTreeIterator_HasCurrentMetaData_10(base.GetCppThis());
		}

		// Token: 0x0601B4AD RID: 111789
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectTreeIterator_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B4AE RID: 111790 RVA: 0x00262574 File Offset: 0x00260774
		public override int IsA(string type)
		{
			return vtkDataObjectTreeIterator.vtkDataObjectTreeIterator_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x0601B4AF RID: 111791
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectTreeIterator_IsDoneWithTraversal_12(HandleRef pThis);

		/// <summary>
		/// Test whether the iterator is finished with the traversal.
		/// Returns 1 for yes, and 0 for no.
		/// It is safe to call any of the GetCurrent...() methods only when
		/// IsDoneWithTraversal() returns 0.
		/// </summary>
		// Token: 0x0601B4B0 RID: 111792 RVA: 0x00262594 File Offset: 0x00260794
		public override int IsDoneWithTraversal()
		{
			return vtkDataObjectTreeIterator.vtkDataObjectTreeIterator_IsDoneWithTraversal_12(base.GetCppThis());
		}

		// Token: 0x0601B4B1 RID: 111793
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectTreeIterator_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B4B2 RID: 111794 RVA: 0x002625B4 File Offset: 0x002607B4
		public new static int IsTypeOf(string type)
		{
			return vtkDataObjectTreeIterator.vtkDataObjectTreeIterator_IsTypeOf_13(type);
		}

		// Token: 0x0601B4B3 RID: 111795
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectTreeIterator_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B4B4 RID: 111796 RVA: 0x002625D0 File Offset: 0x002607D0
		public new vtkDataObjectTreeIterator NewInstance()
		{
			vtkDataObjectTreeIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectTreeIterator.vtkDataObjectTreeIterator_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataObjectTreeIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601B4B5 RID: 111797
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectTreeIterator_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B4B6 RID: 111798 RVA: 0x0026262C File Offset: 0x0026082C
		public new static vtkDataObjectTreeIterator SafeDownCast(vtkObjectBase o)
		{
			vtkDataObjectTreeIterator vtkDataObjectTreeIterator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectTreeIterator.vtkDataObjectTreeIterator_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601B4B7 RID: 111799
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectTreeIterator_SetTraverseSubTree_17(HandleRef pThis, int _arg);

		/// <summary>
		/// If TraverseSubTree is set to true, the iterator will visit the entire tree
		/// structure, otherwise it only visits the first level children. Set to 1 by
		/// default.
		/// </summary>
		// Token: 0x0601B4B8 RID: 111800 RVA: 0x002626AB File Offset: 0x002608AB
		public virtual void SetTraverseSubTree(int _arg)
		{
			vtkDataObjectTreeIterator.vtkDataObjectTreeIterator_SetTraverseSubTree_17(base.GetCppThis(), _arg);
		}

		// Token: 0x0601B4B9 RID: 111801
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectTreeIterator_SetVisitOnlyLeaves_18(HandleRef pThis, int _arg);

		/// <summary>
		/// If VisitOnlyLeaves is true, the iterator will only visit nodes
		/// (sub-datasets) that are not composite. If it encounters a composite
		/// data set, it will automatically traverse that composite dataset until
		/// it finds non-composite datasets. With this options, it is possible to
		/// visit all non-composite datasets in tree of composite datasets
		/// (composite of composite of composite for example :-) ) If
		/// VisitOnlyLeaves is false, GetCurrentDataObject() may return
		/// vtkCompositeDataSet. By default, VisitOnlyLeaves is 1.
		/// </summary>
		// Token: 0x0601B4BA RID: 111802 RVA: 0x002626BB File Offset: 0x002608BB
		public virtual void SetVisitOnlyLeaves(int _arg)
		{
			vtkDataObjectTreeIterator.vtkDataObjectTreeIterator_SetVisitOnlyLeaves_18(base.GetCppThis(), _arg);
		}

		// Token: 0x0601B4BB RID: 111803
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectTreeIterator_TraverseSubTreeOff_19(HandleRef pThis);

		/// <summary>
		/// If TraverseSubTree is set to true, the iterator will visit the entire tree
		/// structure, otherwise it only visits the first level children. Set to 1 by
		/// default.
		/// </summary>
		// Token: 0x0601B4BC RID: 111804 RVA: 0x002626CB File Offset: 0x002608CB
		public virtual void TraverseSubTreeOff()
		{
			vtkDataObjectTreeIterator.vtkDataObjectTreeIterator_TraverseSubTreeOff_19(base.GetCppThis());
		}

		// Token: 0x0601B4BD RID: 111805
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectTreeIterator_TraverseSubTreeOn_20(HandleRef pThis);

		/// <summary>
		/// If TraverseSubTree is set to true, the iterator will visit the entire tree
		/// structure, otherwise it only visits the first level children. Set to 1 by
		/// default.
		/// </summary>
		// Token: 0x0601B4BE RID: 111806 RVA: 0x002626DA File Offset: 0x002608DA
		public virtual void TraverseSubTreeOn()
		{
			vtkDataObjectTreeIterator.vtkDataObjectTreeIterator_TraverseSubTreeOn_20(base.GetCppThis());
		}

		// Token: 0x0601B4BF RID: 111807
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectTreeIterator_VisitOnlyLeavesOff_21(HandleRef pThis);

		/// <summary>
		/// If VisitOnlyLeaves is true, the iterator will only visit nodes
		/// (sub-datasets) that are not composite. If it encounters a composite
		/// data set, it will automatically traverse that composite dataset until
		/// it finds non-composite datasets. With this options, it is possible to
		/// visit all non-composite datasets in tree of composite datasets
		/// (composite of composite of composite for example :-) ) If
		/// VisitOnlyLeaves is false, GetCurrentDataObject() may return
		/// vtkCompositeDataSet. By default, VisitOnlyLeaves is 1.
		/// </summary>
		// Token: 0x0601B4C0 RID: 111808 RVA: 0x002626E9 File Offset: 0x002608E9
		public virtual void VisitOnlyLeavesOff()
		{
			vtkDataObjectTreeIterator.vtkDataObjectTreeIterator_VisitOnlyLeavesOff_21(base.GetCppThis());
		}

		// Token: 0x0601B4C1 RID: 111809
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectTreeIterator_VisitOnlyLeavesOn_22(HandleRef pThis);

		/// <summary>
		/// If VisitOnlyLeaves is true, the iterator will only visit nodes
		/// (sub-datasets) that are not composite. If it encounters a composite
		/// data set, it will automatically traverse that composite dataset until
		/// it finds non-composite datasets. With this options, it is possible to
		/// visit all non-composite datasets in tree of composite datasets
		/// (composite of composite of composite for example :-) ) If
		/// VisitOnlyLeaves is false, GetCurrentDataObject() may return
		/// vtkCompositeDataSet. By default, VisitOnlyLeaves is 1.
		/// </summary>
		// Token: 0x0601B4C2 RID: 111810 RVA: 0x002626F8 File Offset: 0x002608F8
		public virtual void VisitOnlyLeavesOn()
		{
			vtkDataObjectTreeIterator.vtkDataObjectTreeIterator_VisitOnlyLeavesOn_22(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D6A RID: 7530
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataObjectTreeIterator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D6B RID: 7531
		public new static readonly string MRClassNameKey = "class vtkDataObjectTreeIterator";
	}
}
