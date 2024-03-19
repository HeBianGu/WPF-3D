using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMergeDataObjectFilter
	/// </summary>
	/// <remarks>
	///    merge dataset and data object field to create dataset with attribute data
	///
	/// vtkMergeDataObjectFilter is a filter that merges the field from a
	/// vtkDataObject with a vtkDataSet. The resulting combined dataset can
	/// then be processed by other filters (e.g.,
	/// vtkFieldDataToAttributeDataFilter) to create attribute data like
	/// scalars, vectors, etc.
	///
	/// The filter operates as follows. The field data from the
	/// vtkDataObject is merged with the input's vtkDataSet and then placed
	/// in the output. You can choose to place the field data into the cell
	/// data field, the point data field, or the datasets field (i.e., the
	/// one inherited from vtkDataSet's superclass vtkDataObject). All this
	/// data shuffling occurs via reference counting, therefore memory is
	/// not copied.
	///
	/// One of the uses of this filter is to allow you to read/generate the
	/// structure of a dataset independent of the attributes. So, for
	/// example, you could store the dataset geometry/topology in one file,
	/// and field data in another. Then use this filter in combination with
	/// vtkFieldDataToAttributeData to create a dataset ready for
	/// processing in the visualization pipeline.
	/// </remarks>
	// Token: 0x0200097D RID: 2429
	public class vtkMergeDataObjectFilter : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060194EF RID: 103663 RVA: 0x00234167 File Offset: 0x00232367
		static vtkMergeDataObjectFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMergeDataObjectFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMergeDataObjectFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060194F0 RID: 103664 RVA: 0x0023418F File Offset: 0x0023238F
		public vtkMergeDataObjectFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060194F1 RID: 103665
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMergeDataObjectFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060194F2 RID: 103666 RVA: 0x002341A0 File Offset: 0x002323A0
		public new static vtkMergeDataObjectFilter New()
		{
			vtkMergeDataObjectFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMergeDataObjectFilter.vtkMergeDataObjectFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMergeDataObjectFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060194F3 RID: 103667 RVA: 0x002341F4 File Offset: 0x002323F4
		public vtkMergeDataObjectFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMergeDataObjectFilter.vtkMergeDataObjectFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060194F4 RID: 103668 RVA: 0x00234238 File Offset: 0x00232438
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060194F5 RID: 103669
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMergeDataObjectFilter_GetDataObject_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the data object to merge with the input dataset.
		/// </summary>
		// Token: 0x060194F6 RID: 103670 RVA: 0x00234244 File Offset: 0x00232444
		public vtkDataObject GetDataObject()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMergeDataObjectFilter.vtkMergeDataObjectFilter_GetDataObject_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060194F7 RID: 103671
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMergeDataObjectFilter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060194F8 RID: 103672 RVA: 0x002342B4 File Offset: 0x002324B4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMergeDataObjectFilter.vtkMergeDataObjectFilter_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060194F9 RID: 103673
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMergeDataObjectFilter_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060194FA RID: 103674 RVA: 0x002342D4 File Offset: 0x002324D4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMergeDataObjectFilter.vtkMergeDataObjectFilter_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x060194FB RID: 103675
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMergeDataObjectFilter_GetOutputField_04(HandleRef pThis);

		/// <summary>
		/// Specify where to place the field data during the merge process.  There
		/// are three choices: the field data associated with the vtkDataObject
		/// superclass; the point field attribute data; and the cell field attribute
		/// data.
		/// </summary>
		// Token: 0x060194FC RID: 103676 RVA: 0x002342F0 File Offset: 0x002324F0
		public virtual int GetOutputField()
		{
			return vtkMergeDataObjectFilter.vtkMergeDataObjectFilter_GetOutputField_04(base.GetCppThis());
		}

		// Token: 0x060194FD RID: 103677
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMergeDataObjectFilter_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060194FE RID: 103678 RVA: 0x00234310 File Offset: 0x00232510
		public override int IsA(string type)
		{
			return vtkMergeDataObjectFilter.vtkMergeDataObjectFilter_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x060194FF RID: 103679
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMergeDataObjectFilter_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019500 RID: 103680 RVA: 0x00234330 File Offset: 0x00232530
		public new static int IsTypeOf(string type)
		{
			return vtkMergeDataObjectFilter.vtkMergeDataObjectFilter_IsTypeOf_06(type);
		}

		// Token: 0x06019501 RID: 103681
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMergeDataObjectFilter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019502 RID: 103682 RVA: 0x0023434C File Offset: 0x0023254C
		public new vtkMergeDataObjectFilter NewInstance()
		{
			vtkMergeDataObjectFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMergeDataObjectFilter.vtkMergeDataObjectFilter_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMergeDataObjectFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06019503 RID: 103683
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMergeDataObjectFilter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019504 RID: 103684 RVA: 0x002343A8 File Offset: 0x002325A8
		public new static vtkMergeDataObjectFilter SafeDownCast(vtkObjectBase o)
		{
			vtkMergeDataObjectFilter vtkMergeDataObjectFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMergeDataObjectFilter.vtkMergeDataObjectFilter_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMergeDataObjectFilter = (vtkMergeDataObjectFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMergeDataObjectFilter.Register(null);
				}
			}
			return vtkMergeDataObjectFilter;
		}

		// Token: 0x06019505 RID: 103685
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeDataObjectFilter_SetDataObjectInputData_10(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the data object to merge with the input dataset.
		/// </summary>
		// Token: 0x06019506 RID: 103686 RVA: 0x00234428 File Offset: 0x00232628
		public void SetDataObjectInputData(vtkDataObject arg0)
		{
			vtkMergeDataObjectFilter.vtkMergeDataObjectFilter_SetDataObjectInputData_10(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06019507 RID: 103687
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeDataObjectFilter_SetOutputField_11(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify where to place the field data during the merge process.  There
		/// are three choices: the field data associated with the vtkDataObject
		/// superclass; the point field attribute data; and the cell field attribute
		/// data.
		/// </summary>
		// Token: 0x06019508 RID: 103688 RVA: 0x00234457 File Offset: 0x00232657
		public virtual void SetOutputField(int _arg)
		{
			vtkMergeDataObjectFilter.vtkMergeDataObjectFilter_SetOutputField_11(base.GetCppThis(), _arg);
		}

		// Token: 0x06019509 RID: 103689
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeDataObjectFilter_SetOutputFieldToCellDataField_12(HandleRef pThis);

		/// <summary>
		/// Specify where to place the field data during the merge process.  There
		/// are three choices: the field data associated with the vtkDataObject
		/// superclass; the point field attribute data; and the cell field attribute
		/// data.
		/// </summary>
		// Token: 0x0601950A RID: 103690 RVA: 0x00234467 File Offset: 0x00232667
		public void SetOutputFieldToCellDataField()
		{
			vtkMergeDataObjectFilter.vtkMergeDataObjectFilter_SetOutputFieldToCellDataField_12(base.GetCppThis());
		}

		// Token: 0x0601950B RID: 103691
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeDataObjectFilter_SetOutputFieldToDataObjectField_13(HandleRef pThis);

		/// <summary>
		/// Specify where to place the field data during the merge process.  There
		/// are three choices: the field data associated with the vtkDataObject
		/// superclass; the point field attribute data; and the cell field attribute
		/// data.
		/// </summary>
		// Token: 0x0601950C RID: 103692 RVA: 0x00234476 File Offset: 0x00232676
		public void SetOutputFieldToDataObjectField()
		{
			vtkMergeDataObjectFilter.vtkMergeDataObjectFilter_SetOutputFieldToDataObjectField_13(base.GetCppThis());
		}

		// Token: 0x0601950D RID: 103693
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeDataObjectFilter_SetOutputFieldToPointDataField_14(HandleRef pThis);

		/// <summary>
		/// Specify where to place the field data during the merge process.  There
		/// are three choices: the field data associated with the vtkDataObject
		/// superclass; the point field attribute data; and the cell field attribute
		/// data.
		/// </summary>
		// Token: 0x0601950E RID: 103694 RVA: 0x00234485 File Offset: 0x00232685
		public void SetOutputFieldToPointDataField()
		{
			vtkMergeDataObjectFilter.vtkMergeDataObjectFilter_SetOutputFieldToPointDataField_14(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BB6 RID: 7094
		public new const string MRFullTypeName = "Kitware.VTK.vtkMergeDataObjectFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BB7 RID: 7095
		public new static readonly string MRClassNameKey = "class vtkMergeDataObjectFilter";
	}
}
