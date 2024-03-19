using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExtractStructuredGridHelper
	/// </summary>
	/// <remarks>
	///    helper for extracting/sub-sampling
	///  structured datasets.
	///
	///
	/// vtkExtractStructuredGridHelper provides some common functionality that is
	/// used by filters that extract and sub-sample structured data. Specifically,
	/// it provides functionality for calculating the mapping from the output extent
	/// of each process to the input extent.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkExtractGrid vtkExtractVOI vtkExtractRectilinearGrid
	/// </seealso>
	// Token: 0x02000A48 RID: 2632
	public class vtkExtractStructuredGridHelper : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601B6EE RID: 112366 RVA: 0x0026628F File Offset: 0x0026448F
		static vtkExtractStructuredGridHelper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractStructuredGridHelper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractStructuredGridHelper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601B6EF RID: 112367 RVA: 0x002662B7 File Offset: 0x002644B7
		public vtkExtractStructuredGridHelper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601B6F0 RID: 112368
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractStructuredGridHelper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B6F1 RID: 112369 RVA: 0x002662C8 File Offset: 0x002644C8
		public new static vtkExtractStructuredGridHelper New()
		{
			vtkExtractStructuredGridHelper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractStructuredGridHelper.vtkExtractStructuredGridHelper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractStructuredGridHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B6F2 RID: 112370 RVA: 0x0026631C File Offset: 0x0026451C
		public vtkExtractStructuredGridHelper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExtractStructuredGridHelper.vtkExtractStructuredGridHelper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601B6F3 RID: 112371 RVA: 0x00266360 File Offset: 0x00264560
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601B6F4 RID: 112372
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractStructuredGridHelper_ComputeBeginAndEnd_01(HandleRef pThis, IntPtr inExt, IntPtr voi, IntPtr begin, IntPtr end);

		/// <summary>
		/// \brief Returns the begin &amp; end extent that intersects with the VOI
		/// \param inExt the input extent
		/// \param voi the volume of interest
		/// \param begin the begin extent
		/// \param end the end extent
		/// </summary>
		// Token: 0x0601B6F5 RID: 112373 RVA: 0x0026636B File Offset: 0x0026456B
		public void ComputeBeginAndEnd(IntPtr inExt, IntPtr voi, IntPtr begin, IntPtr end)
		{
			vtkExtractStructuredGridHelper.vtkExtractStructuredGridHelper_ComputeBeginAndEnd_01(base.GetCppThis(), inExt, voi, begin, end);
		}

		// Token: 0x0601B6F6 RID: 112374
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractStructuredGridHelper_CopyCellData_02(HandleRef pThis, IntPtr inExt, IntPtr outExt, HandleRef cd, HandleRef outCD);

		/// <summary>
		/// \brief Copies the cell data to the output.
		/// \param inExt the input grid extent.
		/// \param outExt the output grid extent.
		/// \param cd the input cell data.
		/// \param outCD the output cell data.
		/// \pre cd != nullptr.
		/// \pre outCD != nullptr.
		/// </summary>
		// Token: 0x0601B6F7 RID: 112375 RVA: 0x00266380 File Offset: 0x00264580
		public void CopyCellData(IntPtr inExt, IntPtr outExt, vtkCellData cd, vtkCellData outCD)
		{
			vtkExtractStructuredGridHelper.vtkExtractStructuredGridHelper_CopyCellData_02(base.GetCppThis(), inExt, outExt, (cd == null) ? default(HandleRef) : cd.GetCppThis(), (outCD == null) ? default(HandleRef) : outCD.GetCppThis());
		}

		// Token: 0x0601B6F8 RID: 112376
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractStructuredGridHelper_CopyPointsAndPointData_03(HandleRef pThis, IntPtr inExt, IntPtr outExt, HandleRef pd, HandleRef inpnts, HandleRef outPD, HandleRef outpnts);

		/// <summary>
		/// \brief Copies the points &amp; point data to the output.
		/// \param inExt the input grid extent.
		/// \param outExt the output grid extent.
		/// \param pd pointer to the input point data.
		/// \param inpnts pointer to the input points, or nullptr if uniform grid.
		/// \param outPD point to the output point data.
		/// \param outpnts pointer to the output points, or nullptr if uniform grid.
		/// \pre pd != nullptr.
		/// \pre outPD != nullptr.
		/// </summary>
		// Token: 0x0601B6F9 RID: 112377 RVA: 0x002663C8 File Offset: 0x002645C8
		public void CopyPointsAndPointData(IntPtr inExt, IntPtr outExt, vtkPointData pd, vtkPoints inpnts, vtkPointData outPD, vtkPoints outpnts)
		{
			vtkExtractStructuredGridHelper.vtkExtractStructuredGridHelper_CopyPointsAndPointData_03(base.GetCppThis(), inExt, outExt, (pd == null) ? default(HandleRef) : pd.GetCppThis(), (inpnts == null) ? default(HandleRef) : inpnts.GetCppThis(), (outPD == null) ? default(HandleRef) : outPD.GetCppThis(), (outpnts == null) ? default(HandleRef) : outpnts.GetCppThis());
		}

		// Token: 0x0601B6FA RID: 112378
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractStructuredGridHelper_GetMappedExtentValue_04(HandleRef pThis, int dim, int outExtVal);

		/// <summary>
		/// \brief Given a dimension and output extent value, return the corresponding
		/// input extent value. This method should be used to convert extent values.
		/// \param dim the data dimension.
		/// \param outExtVal The output extent value along the given dimension.
		/// \pre dim &gt;= 0 &amp;&amp; dim &lt; 3
		/// \pre outExtVal &gt;= this-&gt;GetOutputWholeExtent()[2*dim] &amp;&amp;
		/// outExtVal &lt;= this-&gt;GetOutputWholeExtent()[2*dim+1]
		/// \return The input extent value along the given dimension.
		/// \sa GetMappedIndex
		/// \sa GetMappedExtentValueFromIndex
		/// </summary>
		// Token: 0x0601B6FB RID: 112379 RVA: 0x00266440 File Offset: 0x00264640
		public int GetMappedExtentValue(int dim, int outExtVal)
		{
			return vtkExtractStructuredGridHelper.vtkExtractStructuredGridHelper_GetMappedExtentValue_04(base.GetCppThis(), dim, outExtVal);
		}

		// Token: 0x0601B6FC RID: 112380
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractStructuredGridHelper_GetMappedExtentValueFromIndex_05(HandleRef pThis, int dim, int outIdx);

		/// <summary>
		/// \brief Given a dimension and output extent index, return the corresponding
		/// input extent value. This method should be used to compute extent values
		/// from extent indices.
		/// \param dim the data dimension.
		/// \param outIdx The output index along the given dimension.
		/// \pre dim &gt;= 0 &amp;&amp; dim &lt; 3
		/// \pre outIdx &gt;= 0 &amp;&amp; outIdx &lt; this-&gt;GetSize( dim )
		/// \return The input extent value along the given dimension.
		/// \sa GetMappedIndex
		/// \sa GetMappedExtentValue
		/// </summary>
		// Token: 0x0601B6FD RID: 112381 RVA: 0x00266464 File Offset: 0x00264664
		public int GetMappedExtentValueFromIndex(int dim, int outIdx)
		{
			return vtkExtractStructuredGridHelper.vtkExtractStructuredGridHelper_GetMappedExtentValueFromIndex_05(base.GetCppThis(), dim, outIdx);
		}

		// Token: 0x0601B6FE RID: 112382
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractStructuredGridHelper_GetMappedIndex_06(HandleRef pThis, int dim, int outIdx);

		/// <summary>
		/// \brief Given a dimension and output index, return the corresponding
		/// extent index. This method should be used to convert array indices,
		/// such as the coordinate arrays for rectilinear grids.
		/// \param dim the data dimension
		/// \param outIdx The output index along the given dimension.
		/// \pre dim &gt;= 0 &amp;&amp; dim &lt; 3
		/// \pre outIdx &gt;= 0 &amp;&amp; outIdx &lt; this-&gt;GetSize( dim )
		/// \return The input extent index along the given dimension.
		/// \sa GetMappedExtentValue
		/// \sa GetMappedExtentValueFromIndex
		/// </summary>
		// Token: 0x0601B6FF RID: 112383 RVA: 0x00266488 File Offset: 0x00264688
		public int GetMappedIndex(int dim, int outIdx)
		{
			return vtkExtractStructuredGridHelper.vtkExtractStructuredGridHelper_GetMappedIndex_06(base.GetCppThis(), dim, outIdx);
		}

		// Token: 0x0601B700 RID: 112384
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractStructuredGridHelper_GetMappedIndexFromExtentValue_07(HandleRef pThis, int dim, int outExtVal);

		/// <summary>
		/// \brief Given a dimension and output extent value, return the corresponding
		/// input extent index. This method should be used to compute extent
		/// indices from extent values.
		/// \param dim the data dimension
		/// \param outExtVal The output extent value along the given dimension.
		/// \pre dim &gt;= 0 &amp;&amp; dim &lt; 3
		/// \pre outExtVal &gt;= this-&gt;GetOutputWholeExtent()[2*dim] &amp;&amp;
		/// outExtVal &lt;= this-&gt;GetOutputWholeExtent()[2*dim+1]
		/// \return The input extent index along the given dimension.
		/// \sa GetMappedExtentValue
		/// \sa GetMappedExtentValueFromIndex
		/// </summary>
		// Token: 0x0601B701 RID: 112385 RVA: 0x002664AC File Offset: 0x002646AC
		public int GetMappedIndexFromExtentValue(int dim, int outExtVal)
		{
			return vtkExtractStructuredGridHelper.vtkExtractStructuredGridHelper_GetMappedIndexFromExtentValue_07(base.GetCppThis(), dim, outExtVal);
		}

		// Token: 0x0601B702 RID: 112386
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractStructuredGridHelper_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B703 RID: 112387 RVA: 0x002664D0 File Offset: 0x002646D0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExtractStructuredGridHelper.vtkExtractStructuredGridHelper_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x0601B704 RID: 112388
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractStructuredGridHelper_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B705 RID: 112389 RVA: 0x002664F0 File Offset: 0x002646F0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExtractStructuredGridHelper.vtkExtractStructuredGridHelper_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x0601B706 RID: 112390
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractStructuredGridHelper_GetOutputWholeExtent_10(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B707 RID: 112391 RVA: 0x0026650C File Offset: 0x0026470C
		public virtual int[] GetOutputWholeExtent()
		{
			IntPtr intPtr = vtkExtractStructuredGridHelper.vtkExtractStructuredGridHelper_GetOutputWholeExtent_10(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601B708 RID: 112392
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractStructuredGridHelper_GetOutputWholeExtent_11(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B709 RID: 112393 RVA: 0x00266554 File Offset: 0x00264754
		public virtual void GetOutputWholeExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkExtractStructuredGridHelper.vtkExtractStructuredGridHelper_GetOutputWholeExtent_11(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		// Token: 0x0601B70A RID: 112394
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractStructuredGridHelper_GetOutputWholeExtent_12(HandleRef pThis, IntPtr _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B70B RID: 112395 RVA: 0x0026656C File Offset: 0x0026476C
		public virtual void GetOutputWholeExtent(IntPtr _arg)
		{
			vtkExtractStructuredGridHelper.vtkExtractStructuredGridHelper_GetOutputWholeExtent_12(base.GetCppThis(), _arg);
		}

		// Token: 0x0601B70C RID: 112396
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractStructuredGridHelper_GetPartitionedOutputExtent_13(IntPtr globalVOI, IntPtr partitionedVOI, IntPtr outputWholeExtent, IntPtr sampleRate, byte includeBoundary, IntPtr partitionedOutputExtent);

		/// <summary>
		/// Calculate the partitioned output extent for a partitioned structured
		/// dataset. This method sets \a partitionedOutputExtent to the correct extent
		/// of an extracted dataset, such that it properly fits with the other
		/// partitioned pieces while considering the \a globalVOI, the
		/// \a sampleRate, and the boundary conditions.
		/// \param globalVOI The full VOI for the entire distributed dataset.
		/// \param partitionedVOI The VOI used in the serial extraction.
		/// \param outputWholeExtent The output extent of the full dataset.
		/// \param sampleRate The sampling rate in each dimension.
		/// \param includeBoundary Whether or not to include the boundary of the VOI,
		/// even if it doesn't fit the spacing.
		/// \param partitionedOutputExtent The correct output extent of the extracted
		/// dataset.
		/// </summary>
		// Token: 0x0601B70D RID: 112397 RVA: 0x0026657C File Offset: 0x0026477C
		public static void GetPartitionedOutputExtent(IntPtr globalVOI, IntPtr partitionedVOI, IntPtr outputWholeExtent, IntPtr sampleRate, bool includeBoundary, IntPtr partitionedOutputExtent)
		{
			vtkExtractStructuredGridHelper.vtkExtractStructuredGridHelper_GetPartitionedOutputExtent_13(globalVOI, partitionedVOI, outputWholeExtent, sampleRate, includeBoundary ? (byte)1 : (byte)0, partitionedOutputExtent);
		}

		// Token: 0x0601B70E RID: 112398
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractStructuredGridHelper_GetPartitionedVOI_14(IntPtr globalVOI, IntPtr partitionedExtent, IntPtr sampleRate, byte includeBoundary, IntPtr partitionedVOI);

		/// <summary>
		/// Calculate the VOI for a partitioned structured dataset. This method sets
		/// \a partitionedVOI to the VOI that extracts as much of the
		/// \a partitionedExtent as possible while considering the \a globalVOI, the
		/// \a sampleRate, and the boundary conditions.
		/// \param globalVOI The full VOI for the entire distributed dataset.
		/// \param partitionedExtent Extent of the process's partitioned input data.
		/// \param sampleRate The sampling rate in each dimension.
		/// \param includeBoundary Whether or not to include the boundary of the VOI,
		/// even if it doesn't fit the spacing.
		/// \param partitionedVOI The extent of the process's partitioned dataset that
		/// should be extracted by a serial extraction filter.
		/// </summary>
		// Token: 0x0601B70F RID: 112399 RVA: 0x00266595 File Offset: 0x00264795
		public static void GetPartitionedVOI(IntPtr globalVOI, IntPtr partitionedExtent, IntPtr sampleRate, bool includeBoundary, IntPtr partitionedVOI)
		{
			vtkExtractStructuredGridHelper.vtkExtractStructuredGridHelper_GetPartitionedVOI_14(globalVOI, partitionedExtent, sampleRate, includeBoundary ? (byte)1 : (byte)0, partitionedVOI);
		}

		// Token: 0x0601B710 RID: 112400
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractStructuredGridHelper_GetSize_15(HandleRef pThis, int dim);

		/// <summary>
		/// \brief Returns the size along a given dimension
		/// \param dim the dimension in query
		/// \pre dim &gt;= 0 &amp;&amp; dim &lt; 3
		/// </summary>
		// Token: 0x0601B711 RID: 112401 RVA: 0x002665AC File Offset: 0x002647AC
		public int GetSize(int dim)
		{
			return vtkExtractStructuredGridHelper.vtkExtractStructuredGridHelper_GetSize_15(base.GetCppThis(), dim);
		}

		// Token: 0x0601B712 RID: 112402
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractStructuredGridHelper_Initialize_16(HandleRef pThis, IntPtr voi, IntPtr wholeExt, IntPtr sampleRate, byte includeBoundary);

		/// <summary>
		/// \brief Initializes the index map.
		/// \param voi the extent of the volume of interest
		/// \param wholeExt the whole extent of the domain
		/// \param sampleRate the sampling rate
		/// \param includeBoundary indicates whether to include the boundary or not.
		/// </summary>
		// Token: 0x0601B713 RID: 112403 RVA: 0x002665CC File Offset: 0x002647CC
		public void Initialize(IntPtr voi, IntPtr wholeExt, IntPtr sampleRate, bool includeBoundary)
		{
			vtkExtractStructuredGridHelper.vtkExtractStructuredGridHelper_Initialize_16(base.GetCppThis(), voi, wholeExt, sampleRate, includeBoundary ? (byte)1 : (byte)0);
		}

		// Token: 0x0601B714 RID: 112404
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractStructuredGridHelper_IsA_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B715 RID: 112405 RVA: 0x002665E8 File Offset: 0x002647E8
		public override int IsA(string type)
		{
			return vtkExtractStructuredGridHelper.vtkExtractStructuredGridHelper_IsA_17(base.GetCppThis(), type);
		}

		// Token: 0x0601B716 RID: 112406
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractStructuredGridHelper_IsTypeOf_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B717 RID: 112407 RVA: 0x00266608 File Offset: 0x00264808
		public new static int IsTypeOf(string type)
		{
			return vtkExtractStructuredGridHelper.vtkExtractStructuredGridHelper_IsTypeOf_18(type);
		}

		// Token: 0x0601B718 RID: 112408
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExtractStructuredGridHelper_IsValid_19(HandleRef pThis);

		/// <summary>
		/// Returns true if the helper is properly initialized.
		/// </summary>
		// Token: 0x0601B719 RID: 112409 RVA: 0x00266624 File Offset: 0x00264824
		public bool IsValid()
		{
			return vtkExtractStructuredGridHelper.vtkExtractStructuredGridHelper_IsValid_19(base.GetCppThis()) != 0;
		}

		// Token: 0x0601B71A RID: 112410
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractStructuredGridHelper_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B71B RID: 112411 RVA: 0x0026664C File Offset: 0x0026484C
		public new vtkExtractStructuredGridHelper NewInstance()
		{
			vtkExtractStructuredGridHelper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractStructuredGridHelper.vtkExtractStructuredGridHelper_NewInstance_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractStructuredGridHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601B71C RID: 112412
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractStructuredGridHelper_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B71D RID: 112413 RVA: 0x002666A8 File Offset: 0x002648A8
		public new static vtkExtractStructuredGridHelper SafeDownCast(vtkObjectBase o)
		{
			vtkExtractStructuredGridHelper vtkExtractStructuredGridHelper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractStructuredGridHelper.vtkExtractStructuredGridHelper_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractStructuredGridHelper = (vtkExtractStructuredGridHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractStructuredGridHelper.Register(null);
				}
			}
			return vtkExtractStructuredGridHelper;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D84 RID: 7556
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractStructuredGridHelper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D85 RID: 7557
		public new static readonly string MRClassNameKey = "class vtkExtractStructuredGridHelper";
	}
}
