using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSpanSpace
	/// </summary>
	/// <remarks>
	///    organize data according to scalar span space
	///
	/// This is a helper class used to accelerate contouring operations. Given an
	/// dataset, it organizes the dataset cells into a 2D binned space, with
	/// coordinate axes (scalar_min,scalar_max). This so-called span space can
	/// then be traversed quickly to find the cells that intersect a specified
	/// contour value.
	///
	/// This class has an API that supports both serial and parallel
	/// operation.  The parallel API enables the using class to grab arrays
	/// (or batches) of cells that lie along a particular row in the span
	/// space. These arrays can then be processed separately or in parallel.
	///
	/// Learn more about span space in these two publications: 1) "A Near
	/// Optimal Isosorface Extraction Algorithm Using the Span Space."
	/// Yarden Livnat et al. and 2) Isosurfacing in Span Space with Utmost
	/// Efficiency." Han-Wei Shen et al.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkScalarTree vtkSimpleScalarTree
	/// </seealso>
	// Token: 0x020009E4 RID: 2532
	public class vtkSpanSpace : vtkScalarTree
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A568 RID: 107880 RVA: 0x00249187 File Offset: 0x00247387
		static vtkSpanSpace()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSpanSpace.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSpanSpace"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A569 RID: 107881 RVA: 0x002491AF File Offset: 0x002473AF
		public vtkSpanSpace(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601A56A RID: 107882
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSpanSpace_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate a scalar tree with default resolution of 100 and automatic
		/// scalar range computation.
		/// </summary>
		// Token: 0x0601A56B RID: 107883 RVA: 0x002491C0 File Offset: 0x002473C0
		public new static vtkSpanSpace New()
		{
			vtkSpanSpace result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSpanSpace.vtkSpanSpace_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSpanSpace)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate a scalar tree with default resolution of 100 and automatic
		/// scalar range computation.
		/// </summary>
		// Token: 0x0601A56C RID: 107884 RVA: 0x00249214 File Offset: 0x00247414
		public vtkSpanSpace() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSpanSpace.vtkSpanSpace_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A56D RID: 107885 RVA: 0x00249258 File Offset: 0x00247458
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A56E RID: 107886
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpanSpace_BuildTree_01(HandleRef pThis);

		/// <summary>
		/// Construct the scalar tree from the dataset provided. Checks build times
		/// and modified time from input and reconstructs the tree if necessary.
		/// </summary>
		// Token: 0x0601A56F RID: 107887 RVA: 0x00249263 File Offset: 0x00247463
		public override void BuildTree()
		{
			vtkSpanSpace.vtkSpanSpace_BuildTree_01(base.GetCppThis());
		}

		// Token: 0x0601A570 RID: 107888
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpanSpace_ComputeResolutionOff_02(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether the resolution of span space is computed
		/// automatically from the average number of cells falling in each bucket.
		/// </summary>
		// Token: 0x0601A571 RID: 107889 RVA: 0x00249272 File Offset: 0x00247472
		public virtual void ComputeResolutionOff()
		{
			vtkSpanSpace.vtkSpanSpace_ComputeResolutionOff_02(base.GetCppThis());
		}

		// Token: 0x0601A572 RID: 107890
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpanSpace_ComputeResolutionOn_03(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether the resolution of span space is computed
		/// automatically from the average number of cells falling in each bucket.
		/// </summary>
		// Token: 0x0601A573 RID: 107891 RVA: 0x00249281 File Offset: 0x00247481
		public virtual void ComputeResolutionOn()
		{
			vtkSpanSpace.vtkSpanSpace_ComputeResolutionOn_03(base.GetCppThis());
		}

		// Token: 0x0601A574 RID: 107892
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpanSpace_ComputeScalarRangeOff_04(HandleRef pThis);

		/// <summary>
		/// This boolean controls whether the determination of the scalar range is
		/// computed from the input scalar data. By default this is enabled.
		/// </summary>
		// Token: 0x0601A575 RID: 107893 RVA: 0x00249290 File Offset: 0x00247490
		public virtual void ComputeScalarRangeOff()
		{
			vtkSpanSpace.vtkSpanSpace_ComputeScalarRangeOff_04(base.GetCppThis());
		}

		// Token: 0x0601A576 RID: 107894
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpanSpace_ComputeScalarRangeOn_05(HandleRef pThis);

		/// <summary>
		/// This boolean controls whether the determination of the scalar range is
		/// computed from the input scalar data. By default this is enabled.
		/// </summary>
		// Token: 0x0601A577 RID: 107895 RVA: 0x0024929F File Offset: 0x0024749F
		public virtual void ComputeScalarRangeOn()
		{
			vtkSpanSpace.vtkSpanSpace_ComputeScalarRangeOn_05(base.GetCppThis());
		}

		// Token: 0x0601A578 RID: 107896
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSpanSpace_GetBatchSize_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the size of the cell batches when processing in
		/// parallel. By default the batch size = 100 cells in each batch.
		/// </summary>
		// Token: 0x0601A579 RID: 107897 RVA: 0x002492B0 File Offset: 0x002474B0
		public virtual long GetBatchSize()
		{
			return vtkSpanSpace.vtkSpanSpace_GetBatchSize_06(base.GetCppThis());
		}

		// Token: 0x0601A57A RID: 107898
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSpanSpace_GetBatchSizeMaxValue_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the size of the cell batches when processing in
		/// parallel. By default the batch size = 100 cells in each batch.
		/// </summary>
		// Token: 0x0601A57B RID: 107899 RVA: 0x002492D0 File Offset: 0x002474D0
		public virtual long GetBatchSizeMaxValue()
		{
			return vtkSpanSpace.vtkSpanSpace_GetBatchSizeMaxValue_07(base.GetCppThis());
		}

		// Token: 0x0601A57C RID: 107900
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSpanSpace_GetBatchSizeMinValue_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the size of the cell batches when processing in
		/// parallel. By default the batch size = 100 cells in each batch.
		/// </summary>
		// Token: 0x0601A57D RID: 107901 RVA: 0x002492F0 File Offset: 0x002474F0
		public virtual long GetBatchSizeMinValue()
		{
			return vtkSpanSpace.vtkSpanSpace_GetBatchSizeMinValue_08(base.GetCppThis());
		}

		// Token: 0x0601A57E RID: 107902
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSpanSpace_GetCellBatch_09(HandleRef pThis, long batchNum, ref long numCells);

		/// <summary>
		/// Return the array of cell ids in the specified batch. The method
		/// also returns the number of cell ids in the array. Make sure to
		/// call GetNumberOfCellBatches() beforehand.
		/// </summary>
		// Token: 0x0601A57F RID: 107903 RVA: 0x00249310 File Offset: 0x00247510
		public override IntPtr GetCellBatch(long batchNum, ref long numCells)
		{
			return vtkSpanSpace.vtkSpanSpace_GetCellBatch_09(base.GetCppThis(), batchNum, ref numCells);
		}

		// Token: 0x0601A580 RID: 107904
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSpanSpace_GetComputeResolution_10(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether the resolution of span space is computed
		/// automatically from the average number of cells falling in each bucket.
		/// </summary>
		// Token: 0x0601A581 RID: 107905 RVA: 0x00249334 File Offset: 0x00247534
		public virtual int GetComputeResolution()
		{
			return vtkSpanSpace.vtkSpanSpace_GetComputeResolution_10(base.GetCppThis());
		}

		// Token: 0x0601A582 RID: 107906
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSpanSpace_GetComputeScalarRange_11(HandleRef pThis);

		/// <summary>
		/// This boolean controls whether the determination of the scalar range is
		/// computed from the input scalar data. By default this is enabled.
		/// </summary>
		// Token: 0x0601A583 RID: 107907 RVA: 0x00249354 File Offset: 0x00247554
		public virtual int GetComputeScalarRange()
		{
			return vtkSpanSpace.vtkSpanSpace_GetComputeScalarRange_11(base.GetCppThis());
		}

		// Token: 0x0601A584 RID: 107908
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSpanSpace_GetNextCell_12(HandleRef pThis, ref long cellId, HandleRef ptIds, HandleRef cellScalars, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the next cell that may contain scalar value specified to
		/// InitTraversal(). The value nullptr is returned if the list is
		/// exhausted. Make sure that InitTraversal() has been invoked first or
		/// you'll get undefined behavior. This is inherently a serial operation.
		/// </summary>
		// Token: 0x0601A585 RID: 107909 RVA: 0x00249374 File Offset: 0x00247574
		public override vtkCell GetNextCell(ref long cellId, vtkIdList ptIds, vtkDataArray cellScalars)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSpanSpace.vtkSpanSpace_GetNextCell_12(base.GetCppThis(), ref cellId, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis(), (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601A586 RID: 107910
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSpanSpace_GetNumberOfCellBatches_13(HandleRef pThis, double scalarValue);

		/// <summary>
		/// Get the number of cell batches available for processing as a function of
		/// the specified scalar value. Each batch contains a list of candidate
		/// cells that may contain the specified isocontour value.
		/// </summary>
		// Token: 0x0601A587 RID: 107911 RVA: 0x00249410 File Offset: 0x00247610
		public override long GetNumberOfCellBatches(double scalarValue)
		{
			return vtkSpanSpace.vtkSpanSpace_GetNumberOfCellBatches_13(base.GetCppThis(), scalarValue);
		}

		// Token: 0x0601A588 RID: 107912
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSpanSpace_GetNumberOfCellsPerBucket_14(HandleRef pThis);

		/// <summary>
		/// Specify the average number of cells in each bucket. This is used to
		/// indirectly control the resolution if ComputeResolution is enabled.
		/// </summary>
		// Token: 0x0601A589 RID: 107913 RVA: 0x00249430 File Offset: 0x00247630
		public virtual int GetNumberOfCellsPerBucket()
		{
			return vtkSpanSpace.vtkSpanSpace_GetNumberOfCellsPerBucket_14(base.GetCppThis());
		}

		// Token: 0x0601A58A RID: 107914
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSpanSpace_GetNumberOfCellsPerBucketMaxValue_15(HandleRef pThis);

		/// <summary>
		/// Specify the average number of cells in each bucket. This is used to
		/// indirectly control the resolution if ComputeResolution is enabled.
		/// </summary>
		// Token: 0x0601A58B RID: 107915 RVA: 0x00249450 File Offset: 0x00247650
		public virtual int GetNumberOfCellsPerBucketMaxValue()
		{
			return vtkSpanSpace.vtkSpanSpace_GetNumberOfCellsPerBucketMaxValue_15(base.GetCppThis());
		}

		// Token: 0x0601A58C RID: 107916
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSpanSpace_GetNumberOfCellsPerBucketMinValue_16(HandleRef pThis);

		/// <summary>
		/// Specify the average number of cells in each bucket. This is used to
		/// indirectly control the resolution if ComputeResolution is enabled.
		/// </summary>
		// Token: 0x0601A58D RID: 107917 RVA: 0x00249470 File Offset: 0x00247670
		public virtual int GetNumberOfCellsPerBucketMinValue()
		{
			return vtkSpanSpace.vtkSpanSpace_GetNumberOfCellsPerBucketMinValue_16(base.GetCppThis());
		}

		// Token: 0x0601A58E RID: 107918
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSpanSpace_GetNumberOfGenerationsFromBase_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard type related macros and PrintSelf() method.
		/// </summary>
		// Token: 0x0601A58F RID: 107919 RVA: 0x00249490 File Offset: 0x00247690
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSpanSpace.vtkSpanSpace_GetNumberOfGenerationsFromBase_17(base.GetCppThis(), type);
		}

		// Token: 0x0601A590 RID: 107920
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSpanSpace_GetNumberOfGenerationsFromBaseType_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard type related macros and PrintSelf() method.
		/// </summary>
		// Token: 0x0601A591 RID: 107921 RVA: 0x002494B0 File Offset: 0x002476B0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSpanSpace.vtkSpanSpace_GetNumberOfGenerationsFromBaseType_18(type);
		}

		// Token: 0x0601A592 RID: 107922
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSpanSpace_GetResolution_19(HandleRef pThis);

		/// <summary>
		/// Set/Get the resolution N of the span space. The span space can be
		/// envisioned as a rectangular lattice of NXN buckets/bins (i.e., N rows
		/// and N columns), where each bucket stores a list of cell ids. The i-j
		/// coordinate of each cell (hence its location in the lattice) is
		/// determined from the cell's 2-tuple (smin,smax) scalar range.  By default
		/// Resolution = 100, with a clamp of 10,000.
		/// </summary>
		// Token: 0x0601A593 RID: 107923 RVA: 0x002494CC File Offset: 0x002476CC
		public virtual long GetResolution()
		{
			return vtkSpanSpace.vtkSpanSpace_GetResolution_19(base.GetCppThis());
		}

		// Token: 0x0601A594 RID: 107924
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSpanSpace_GetResolutionMaxValue_20(HandleRef pThis);

		/// <summary>
		/// Set/Get the resolution N of the span space. The span space can be
		/// envisioned as a rectangular lattice of NXN buckets/bins (i.e., N rows
		/// and N columns), where each bucket stores a list of cell ids. The i-j
		/// coordinate of each cell (hence its location in the lattice) is
		/// determined from the cell's 2-tuple (smin,smax) scalar range.  By default
		/// Resolution = 100, with a clamp of 10,000.
		/// </summary>
		// Token: 0x0601A595 RID: 107925 RVA: 0x002494EC File Offset: 0x002476EC
		public virtual long GetResolutionMaxValue()
		{
			return vtkSpanSpace.vtkSpanSpace_GetResolutionMaxValue_20(base.GetCppThis());
		}

		// Token: 0x0601A596 RID: 107926
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSpanSpace_GetResolutionMinValue_21(HandleRef pThis);

		/// <summary>
		/// Set/Get the resolution N of the span space. The span space can be
		/// envisioned as a rectangular lattice of NXN buckets/bins (i.e., N rows
		/// and N columns), where each bucket stores a list of cell ids. The i-j
		/// coordinate of each cell (hence its location in the lattice) is
		/// determined from the cell's 2-tuple (smin,smax) scalar range.  By default
		/// Resolution = 100, with a clamp of 10,000.
		/// </summary>
		// Token: 0x0601A597 RID: 107927 RVA: 0x0024950C File Offset: 0x0024770C
		public virtual long GetResolutionMinValue()
		{
			return vtkSpanSpace.vtkSpanSpace_GetResolutionMinValue_21(base.GetCppThis());
		}

		// Token: 0x0601A598 RID: 107928
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSpanSpace_GetScalarRange_22(HandleRef pThis);

		/// <summary>
		/// Specify the scalar range in terms of minimum and maximum values
		/// (smin,smax). These values are used to build the span space. Note that
		/// setting the range can have significant impact on the performance of the
		/// span space as it controls the effective resolution near important
		/// isocontour values. By default the range is computed automatically; turn
		/// off ComputeScalarRange is you wish to manually specify it.
		/// </summary>
		// Token: 0x0601A599 RID: 107929 RVA: 0x0024952C File Offset: 0x0024772C
		public virtual double[] GetScalarRange()
		{
			IntPtr intPtr = vtkSpanSpace.vtkSpanSpace_GetScalarRange_22(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601A59A RID: 107930
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpanSpace_GetScalarRange_23(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify the scalar range in terms of minimum and maximum values
		/// (smin,smax). These values are used to build the span space. Note that
		/// setting the range can have significant impact on the performance of the
		/// span space as it controls the effective resolution near important
		/// isocontour values. By default the range is computed automatically; turn
		/// off ComputeScalarRange is you wish to manually specify it.
		/// </summary>
		// Token: 0x0601A59B RID: 107931 RVA: 0x00249574 File Offset: 0x00247774
		public virtual void GetScalarRange(IntPtr data)
		{
			vtkSpanSpace.vtkSpanSpace_GetScalarRange_23(base.GetCppThis(), data);
		}

		// Token: 0x0601A59C RID: 107932
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpanSpace_InitTraversal_24(HandleRef pThis, double scalarValue);

		/// <summary>
		/// Begin to traverse the cells based on a scalar value. Returned cells will
		/// have scalar values that span the scalar value specified (within the
		/// resolution of the span space). Note this method must be called prior to
		/// parallel or serial traversal since it specifies the scalar value to be
		/// extracted.
		/// </summary>
		// Token: 0x0601A59D RID: 107933 RVA: 0x00249584 File Offset: 0x00247784
		public override void InitTraversal(double scalarValue)
		{
			vtkSpanSpace.vtkSpanSpace_InitTraversal_24(base.GetCppThis(), scalarValue);
		}

		// Token: 0x0601A59E RID: 107934
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpanSpace_Initialize_25(HandleRef pThis);

		/// <summary>
		/// Initialize the span space. Frees memory and resets object as
		/// appropriate.
		/// </summary>
		// Token: 0x0601A59F RID: 107935 RVA: 0x00249594 File Offset: 0x00247794
		public override void Initialize()
		{
			vtkSpanSpace.vtkSpanSpace_Initialize_25(base.GetCppThis());
		}

		// Token: 0x0601A5A0 RID: 107936
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSpanSpace_IsA_26(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard type related macros and PrintSelf() method.
		/// </summary>
		// Token: 0x0601A5A1 RID: 107937 RVA: 0x002495A4 File Offset: 0x002477A4
		public override int IsA(string type)
		{
			return vtkSpanSpace.vtkSpanSpace_IsA_26(base.GetCppThis(), type);
		}

		// Token: 0x0601A5A2 RID: 107938
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSpanSpace_IsTypeOf_27([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard type related macros and PrintSelf() method.
		/// </summary>
		// Token: 0x0601A5A3 RID: 107939 RVA: 0x002495C4 File Offset: 0x002477C4
		public new static int IsTypeOf(string type)
		{
			return vtkSpanSpace.vtkSpanSpace_IsTypeOf_27(type);
		}

		// Token: 0x0601A5A4 RID: 107940
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSpanSpace_NewInstance_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard type related macros and PrintSelf() method.
		/// </summary>
		// Token: 0x0601A5A5 RID: 107941 RVA: 0x002495E0 File Offset: 0x002477E0
		public new vtkSpanSpace NewInstance()
		{
			vtkSpanSpace result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSpanSpace.vtkSpanSpace_NewInstance_29(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSpanSpace)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A5A6 RID: 107942
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSpanSpace_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard type related macros and PrintSelf() method.
		/// </summary>
		// Token: 0x0601A5A7 RID: 107943 RVA: 0x0024963C File Offset: 0x0024783C
		public new static vtkSpanSpace SafeDownCast(vtkObjectBase o)
		{
			vtkSpanSpace vtkSpanSpace = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSpanSpace.vtkSpanSpace_SafeDownCast_30((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSpanSpace = (vtkSpanSpace)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSpanSpace.Register(null);
				}
			}
			return vtkSpanSpace;
		}

		// Token: 0x0601A5A8 RID: 107944
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpanSpace_SetBatchSize_31(HandleRef pThis, long _arg);

		/// <summary>
		/// Set/Get the size of the cell batches when processing in
		/// parallel. By default the batch size = 100 cells in each batch.
		/// </summary>
		// Token: 0x0601A5A9 RID: 107945 RVA: 0x002496BB File Offset: 0x002478BB
		public virtual void SetBatchSize(long _arg)
		{
			vtkSpanSpace.vtkSpanSpace_SetBatchSize_31(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A5AA RID: 107946
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpanSpace_SetComputeResolution_32(HandleRef pThis, int _arg);

		/// <summary>
		/// Boolean controls whether the resolution of span space is computed
		/// automatically from the average number of cells falling in each bucket.
		/// </summary>
		// Token: 0x0601A5AB RID: 107947 RVA: 0x002496CB File Offset: 0x002478CB
		public virtual void SetComputeResolution(int _arg)
		{
			vtkSpanSpace.vtkSpanSpace_SetComputeResolution_32(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A5AC RID: 107948
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpanSpace_SetComputeScalarRange_33(HandleRef pThis, int _arg);

		/// <summary>
		/// This boolean controls whether the determination of the scalar range is
		/// computed from the input scalar data. By default this is enabled.
		/// </summary>
		// Token: 0x0601A5AD RID: 107949 RVA: 0x002496DB File Offset: 0x002478DB
		public virtual void SetComputeScalarRange(int _arg)
		{
			vtkSpanSpace.vtkSpanSpace_SetComputeScalarRange_33(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A5AE RID: 107950
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpanSpace_SetNumberOfCellsPerBucket_34(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the average number of cells in each bucket. This is used to
		/// indirectly control the resolution if ComputeResolution is enabled.
		/// </summary>
		// Token: 0x0601A5AF RID: 107951 RVA: 0x002496EB File Offset: 0x002478EB
		public virtual void SetNumberOfCellsPerBucket(int _arg)
		{
			vtkSpanSpace.vtkSpanSpace_SetNumberOfCellsPerBucket_34(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A5B0 RID: 107952
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpanSpace_SetResolution_35(HandleRef pThis, long _arg);

		/// <summary>
		/// Set/Get the resolution N of the span space. The span space can be
		/// envisioned as a rectangular lattice of NXN buckets/bins (i.e., N rows
		/// and N columns), where each bucket stores a list of cell ids. The i-j
		/// coordinate of each cell (hence its location in the lattice) is
		/// determined from the cell's 2-tuple (smin,smax) scalar range.  By default
		/// Resolution = 100, with a clamp of 10,000.
		/// </summary>
		// Token: 0x0601A5B1 RID: 107953 RVA: 0x002496FB File Offset: 0x002478FB
		public virtual void SetResolution(long _arg)
		{
			vtkSpanSpace.vtkSpanSpace_SetResolution_35(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A5B2 RID: 107954
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpanSpace_SetScalarRange_36(HandleRef pThis, double _arg1, double _arg2);

		/// <summary>
		/// Specify the scalar range in terms of minimum and maximum values
		/// (smin,smax). These values are used to build the span space. Note that
		/// setting the range can have significant impact on the performance of the
		/// span space as it controls the effective resolution near important
		/// isocontour values. By default the range is computed automatically; turn
		/// off ComputeScalarRange is you wish to manually specify it.
		/// </summary>
		// Token: 0x0601A5B3 RID: 107955 RVA: 0x0024970B File Offset: 0x0024790B
		public virtual void SetScalarRange(double _arg1, double _arg2)
		{
			vtkSpanSpace.vtkSpanSpace_SetScalarRange_36(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0601A5B4 RID: 107956
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpanSpace_SetScalarRange_37(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify the scalar range in terms of minimum and maximum values
		/// (smin,smax). These values are used to build the span space. Note that
		/// setting the range can have significant impact on the performance of the
		/// span space as it controls the effective resolution near important
		/// isocontour values. By default the range is computed automatically; turn
		/// off ComputeScalarRange is you wish to manually specify it.
		/// </summary>
		// Token: 0x0601A5B5 RID: 107957 RVA: 0x0024971C File Offset: 0x0024791C
		public void SetScalarRange(IntPtr _arg)
		{
			vtkSpanSpace.vtkSpanSpace_SetScalarRange_37(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A5B6 RID: 107958
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpanSpace_ShallowCopy_38(HandleRef pThis, HandleRef stree);

		/// <summary>
		/// This method is used to copy data members when cloning an instance of the
		/// class. It does not copy heavy data.
		/// </summary>
		// Token: 0x0601A5B7 RID: 107959 RVA: 0x0024972C File Offset: 0x0024792C
		public override void ShallowCopy(vtkScalarTree stree)
		{
			vtkSpanSpace.vtkSpanSpace_ShallowCopy_38(base.GetCppThis(), (stree == null) ? default(HandleRef) : stree.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C98 RID: 7320
		public new const string MRFullTypeName = "Kitware.VTK.vtkSpanSpace";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C99 RID: 7321
		public new static readonly string MRClassNameKey = "class vtkSpanSpace";
	}
}
