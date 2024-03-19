using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkUnstructuredGridToCellGrid
	/// </summary>
	/// <remarks>
	///    Create a cell-grid that approximates a collection of vtkUnstructuredGrids.
	///
	/// This filter takes a partitioned dataset collection (or a single unstructured grid)
	/// as input, iterates each block's cells to find the shapes and orders of cells present;
	/// then it creates empty vtkCellGrids and runs its internal TranscribeQuery to construct
	/// cells and cell-attributes to match each input unstructured-grid.
	///
	/// Note that this filter assumes all the cells of the same shape in
	/// the vtkUnstructuredGrid are of the same order. This matches
	/// assumptions in the IOSS reader but may not be true of arbitrary
	/// unstructured grids.
	///
	/// ## Design notes
	///
	/// Even though this filter is named as though it processes a single unstructured grid
	/// at a time, it is multiblock aware (and indeed, always outputs a partitioned dataset
	/// collection). This was done in order to properly handle IOSS data, which includes
	/// metadata on the parent composite dataset that is relevant to conversions of individual
	/// child objects it contains.
	///
	/// There is no reason – apart from the development time required – that
	/// this filter couldn't accept any vtkDataSet as input (rather than just
	/// unstructured grids). However, without some analogs to structured
	/// dataset types, this would generally perform poorly. A set of spline
	/// cells would make representing many structured datasets space-efficient
	/// and amenable to smoothing/simplification.
	/// </remarks>
	// Token: 0x020004CF RID: 1231
	public class vtkUnstructuredGridToCellGrid : vtkPartitionedDataSetCollectionAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E058 RID: 57432 RVA: 0x00137317 File Offset: 0x00135517
		static vtkUnstructuredGridToCellGrid()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUnstructuredGridToCellGrid.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGridToCellGrid"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E059 RID: 57433 RVA: 0x0013733F File Offset: 0x0013553F
		public vtkUnstructuredGridToCellGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E05A RID: 57434
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridToCellGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E05B RID: 57435 RVA: 0x00137350 File Offset: 0x00135550
		public new static vtkUnstructuredGridToCellGrid New()
		{
			vtkUnstructuredGridToCellGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridToCellGrid.vtkUnstructuredGridToCellGrid_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridToCellGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E05C RID: 57436 RVA: 0x001373A4 File Offset: 0x001355A4
		public vtkUnstructuredGridToCellGrid() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkUnstructuredGridToCellGrid.vtkUnstructuredGridToCellGrid_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E05D RID: 57437 RVA: 0x001373E8 File Offset: 0x001355E8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E05E RID: 57438
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridToCellGrid_AddPreferredOutputType_01(HandleRef pThis, int inputCellType, vtkStringToken preferredOutputType, int priority);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E05F RID: 57439 RVA: 0x001373F3 File Offset: 0x001355F3
		public virtual void AddPreferredOutputType(int inputCellType, vtkStringToken preferredOutputType, int priority)
		{
			vtkUnstructuredGridToCellGrid.vtkUnstructuredGridToCellGrid_AddPreferredOutputType_01(base.GetCppThis(), inputCellType, preferredOutputType, priority);
		}

		// Token: 0x0600E060 RID: 57440
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridToCellGrid_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E061 RID: 57441 RVA: 0x00137408 File Offset: 0x00135608
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkUnstructuredGridToCellGrid.vtkUnstructuredGridToCellGrid_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600E062 RID: 57442
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridToCellGrid_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E063 RID: 57443 RVA: 0x00137428 File Offset: 0x00135628
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkUnstructuredGridToCellGrid.vtkUnstructuredGridToCellGrid_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600E064 RID: 57444
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridToCellGrid_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E065 RID: 57445 RVA: 0x00137444 File Offset: 0x00135644
		public override int IsA(string type)
		{
			return vtkUnstructuredGridToCellGrid.vtkUnstructuredGridToCellGrid_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600E066 RID: 57446
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridToCellGrid_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E067 RID: 57447 RVA: 0x00137464 File Offset: 0x00135664
		public new static int IsTypeOf(string type)
		{
			return vtkUnstructuredGridToCellGrid.vtkUnstructuredGridToCellGrid_IsTypeOf_05(type);
		}

		// Token: 0x0600E068 RID: 57448
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridToCellGrid_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E069 RID: 57449 RVA: 0x00137480 File Offset: 0x00135680
		public new vtkUnstructuredGridToCellGrid NewInstance()
		{
			vtkUnstructuredGridToCellGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridToCellGrid.vtkUnstructuredGridToCellGrid_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridToCellGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E06A RID: 57450
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridToCellGrid_Reset_08(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E06B RID: 57451 RVA: 0x001374DA File Offset: 0x001356DA
		public virtual void Reset()
		{
			vtkUnstructuredGridToCellGrid.vtkUnstructuredGridToCellGrid_Reset_08(base.GetCppThis());
		}

		// Token: 0x0600E06C RID: 57452
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridToCellGrid_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E06D RID: 57453 RVA: 0x001374EC File Offset: 0x001356EC
		public new static vtkUnstructuredGridToCellGrid SafeDownCast(vtkObjectBase o)
		{
			vtkUnstructuredGridToCellGrid vtkUnstructuredGridToCellGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridToCellGrid.vtkUnstructuredGridToCellGrid_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGridToCellGrid = (vtkUnstructuredGridToCellGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGridToCellGrid.Register(null);
				}
			}
			return vtkUnstructuredGridToCellGrid;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001079 RID: 4217
		public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGridToCellGrid";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400107A RID: 4218
		public new static readonly string MRClassNameKey = "class vtkUnstructuredGridToCellGrid";
	}
}
