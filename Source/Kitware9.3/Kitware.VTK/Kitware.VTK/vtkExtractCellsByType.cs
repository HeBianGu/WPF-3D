using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExtractCellsByType
	/// </summary>
	/// <remarks>
	///    extract cells of a specified type
	///
	///
	/// Given an input vtkDataSet and a list of cell types, produce an output
	/// dataset containing only cells of the specified type(s). Note that if the
	/// input dataset is homogeneous (e.g., all cells are of the same type) and
	/// the cell type is one of the cells specified, then the input dataset is
	/// shallow copied to the output.
	///
	/// The type of output dataset is always the same as the input type. Since
	/// structured types of data (i.e., vtkImageData, vtkStructuredGrid,
	/// vtkRectilnearGrid, vtkUniformGrid) are all composed of a cell of the same
	/// type, the output is either empty, or a shallow copy of the
	/// input. Unstructured data (vtkUnstructuredGrid, vtkPolyData) input may
	/// produce a subset of the input data (depending on the selected cell types).
	///
	/// Note this filter can be used in a pipeline with composite datasets to
	/// extract blocks of (a) particular cell type(s).
	///
	/// @warning
	/// Unlike the filter vtkExtractCells which always produces
	/// vtkUnstructuredGrid output, this filter produces the same output type as
	/// input type (i.e., it is a vtkDataSetAlgorithm). Also, vtkExtractCells
	/// extracts cells based on their ids.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkExtractBlock vtkExtractCells
	/// </seealso>
	// Token: 0x020006A8 RID: 1704
	public class vtkExtractCellsByType : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060123B4 RID: 74676 RVA: 0x00198A5D File Offset: 0x00196C5D
		static vtkExtractCellsByType()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractCellsByType.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractCellsByType"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060123B5 RID: 74677 RVA: 0x00198A85 File Offset: 0x00196C85
		public vtkExtractCellsByType(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060123B6 RID: 74678
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractCellsByType_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for construction, type info, and printing.
		/// </summary>
		// Token: 0x060123B7 RID: 74679 RVA: 0x00198A94 File Offset: 0x00196C94
		public new static vtkExtractCellsByType New()
		{
			vtkExtractCellsByType result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractCellsByType.vtkExtractCellsByType_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractCellsByType)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for construction, type info, and printing.
		/// </summary>
		// Token: 0x060123B8 RID: 74680 RVA: 0x00198AE8 File Offset: 0x00196CE8
		public vtkExtractCellsByType() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExtractCellsByType.vtkExtractCellsByType_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060123B9 RID: 74681 RVA: 0x00198B2C File Offset: 0x00196D2C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060123BA RID: 74682
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractCellsByType_AddAllCellTypes_01(HandleRef pThis);

		/// <summary>
		/// Specify the cell types to extract. Any cells of the type specified are
		/// extracted. Methods for clearing the set of cells, adding all cells, and
		/// determining if a cell is in the set are also provided.
		/// </summary>
		// Token: 0x060123BB RID: 74683 RVA: 0x00198B37 File Offset: 0x00196D37
		public void AddAllCellTypes()
		{
			vtkExtractCellsByType.vtkExtractCellsByType_AddAllCellTypes_01(base.GetCppThis());
		}

		// Token: 0x060123BC RID: 74684
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractCellsByType_AddCellType_02(HandleRef pThis, uint type);

		/// <summary>
		/// Specify the cell types to extract. Any cells of the type specified are
		/// extracted. Methods for clearing the set of cells, adding all cells, and
		/// determining if a cell is in the set are also provided.
		/// </summary>
		// Token: 0x060123BD RID: 74685 RVA: 0x00198B46 File Offset: 0x00196D46
		public void AddCellType(uint type)
		{
			vtkExtractCellsByType.vtkExtractCellsByType_AddCellType_02(base.GetCppThis(), type);
		}

		// Token: 0x060123BE RID: 74686
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExtractCellsByType_ExtractCellType_03(HandleRef pThis, uint type);

		/// <summary>
		/// Specify the cell types to extract. Any cells of the type specified are
		/// extracted. Methods for clearing the set of cells, adding all cells, and
		/// determining if a cell is in the set are also provided.
		/// </summary>
		// Token: 0x060123BF RID: 74687 RVA: 0x00198B58 File Offset: 0x00196D58
		public bool ExtractCellType(uint type)
		{
			return vtkExtractCellsByType.vtkExtractCellsByType_ExtractCellType_03(base.GetCppThis(), type) != 0;
		}

		// Token: 0x060123C0 RID: 74688
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractCellsByType_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for construction, type info, and printing.
		/// </summary>
		// Token: 0x060123C1 RID: 74689 RVA: 0x00198B80 File Offset: 0x00196D80
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExtractCellsByType.vtkExtractCellsByType_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x060123C2 RID: 74690
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractCellsByType_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for construction, type info, and printing.
		/// </summary>
		// Token: 0x060123C3 RID: 74691 RVA: 0x00198BA0 File Offset: 0x00196DA0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExtractCellsByType.vtkExtractCellsByType_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x060123C4 RID: 74692
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractCellsByType_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for construction, type info, and printing.
		/// </summary>
		// Token: 0x060123C5 RID: 74693 RVA: 0x00198BBC File Offset: 0x00196DBC
		public override int IsA(string type)
		{
			return vtkExtractCellsByType.vtkExtractCellsByType_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x060123C6 RID: 74694
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractCellsByType_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for construction, type info, and printing.
		/// </summary>
		// Token: 0x060123C7 RID: 74695 RVA: 0x00198BDC File Offset: 0x00196DDC
		public new static int IsTypeOf(string type)
		{
			return vtkExtractCellsByType.vtkExtractCellsByType_IsTypeOf_07(type);
		}

		// Token: 0x060123C8 RID: 74696
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractCellsByType_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for construction, type info, and printing.
		/// </summary>
		// Token: 0x060123C9 RID: 74697 RVA: 0x00198BF8 File Offset: 0x00196DF8
		public new vtkExtractCellsByType NewInstance()
		{
			vtkExtractCellsByType result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractCellsByType.vtkExtractCellsByType_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractCellsByType)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060123CA RID: 74698
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractCellsByType_RemoveAllCellTypes_10(HandleRef pThis);

		/// <summary>
		/// Specify the cell types to extract. Any cells of the type specified are
		/// extracted. Methods for clearing the set of cells, adding all cells, and
		/// determining if a cell is in the set are also provided.
		/// </summary>
		// Token: 0x060123CB RID: 74699 RVA: 0x00198C52 File Offset: 0x00196E52
		public void RemoveAllCellTypes()
		{
			vtkExtractCellsByType.vtkExtractCellsByType_RemoveAllCellTypes_10(base.GetCppThis());
		}

		// Token: 0x060123CC RID: 74700
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractCellsByType_RemoveCellType_11(HandleRef pThis, uint type);

		/// <summary>
		/// Specify the cell types to extract. Any cells of the type specified are
		/// extracted. Methods for clearing the set of cells, adding all cells, and
		/// determining if a cell is in the set are also provided.
		/// </summary>
		// Token: 0x060123CD RID: 74701 RVA: 0x00198C61 File Offset: 0x00196E61
		public void RemoveCellType(uint type)
		{
			vtkExtractCellsByType.vtkExtractCellsByType_RemoveCellType_11(base.GetCppThis(), type);
		}

		// Token: 0x060123CE RID: 74702
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractCellsByType_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for construction, type info, and printing.
		/// </summary>
		// Token: 0x060123CF RID: 74703 RVA: 0x00198C74 File Offset: 0x00196E74
		public new static vtkExtractCellsByType SafeDownCast(vtkObjectBase o)
		{
			vtkExtractCellsByType vtkExtractCellsByType = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractCellsByType.vtkExtractCellsByType_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractCellsByType = (vtkExtractCellsByType)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractCellsByType.Register(null);
				}
			}
			return vtkExtractCellsByType;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014FE RID: 5374
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractCellsByType";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014FF RID: 5375
		public new static readonly string MRClassNameKey = "class vtkExtractCellsByType";
	}
}
