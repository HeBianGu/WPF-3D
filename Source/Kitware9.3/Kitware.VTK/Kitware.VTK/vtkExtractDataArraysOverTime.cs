using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExtractDataArraysOverTime
	/// </summary>
	/// <remarks>
	///    extracts array from input dataset over time.
	///
	/// vtkExtractDataArraysOverTime extracts array from input dataset over time.
	/// The filter extracts attribute arrays, based on the chosen field association
	/// (vtkExtractDataArraysOverTime::SetFieldAssociation).
	///
	/// vtkExtractDataArraysOverTime::ReportStatisticsOnly determines if each element
	/// is individually tracked or only summary statistics for each timestep are
	/// tracked.
	///
	/// If ReportStatisticsOnly is off, the filter tracks each element in the input
	/// over time. It requires that it can identify matching elements from one
	/// timestep to another. There are several ways of doing that.
	///
	/// \li if vtkExtractDataArraysOverTime::UseGlobalIDs is true, then the filter
	///     will look for array marked as vtkDataSetAttributes::GLOBALIDS in the
	///     input and use that to track the element.
	/// \li if vtkExtractDataArraysOverTime::UseGlobalIDs is false or there are no
	///     element ids present, then the filter will look for the array chosen for
	///     processing using `vtkAlgorithm::SetInputArrayToProcess` at index 0.
	/// \li if earlier attempts fail, then simply the element id (i.e. index) is used.
	///
	/// The output is a vtkMultiBlockDataSet with single level, where leaf nodes can
	/// are vtkTable instances.
	///
	/// The output is structured as follows:
	///
	/// \li if vtkExtractDataArraysOverTime::ReportStatisticsOnly is true, then the
	///     stats are computed per input block (if input is a composite dataset) or on the whole
	///     input dataset and placed as blocks named as &lt;tt&gt;stats block=\&lt;block id\&gt;&lt;/tt&gt;.
	///     For non-composite input, the single leaf block is output is named as
	///     \c stats.
	///
	/// \li if vtkExtractDataArraysOverTime::ReportStatisticsOnly if off, then each
	///    tracked element is placed in a separate output block. The block name is of
	///    the form &lt;tt&gt;id=\&lt;id\&gt; block=\&lt;block id\&gt;&lt;/tt&gt; where the \em block= suffix is
	///    dropped for non-composite input datasets. If global ids are being used for
	///    tracking then the name is simply &lt;tt&gt;gid=\&lt;global id\&gt;&lt;/tt&gt;.
	///
	/// </remarks>
	/// <seealso>
	///  vtkPExtractDataArraysOverTime
	/// </seealso>
	// Token: 0x0200050F RID: 1295
	public class vtkExtractDataArraysOverTime : vtkMultiBlockDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E7F6 RID: 59382 RVA: 0x00143403 File Offset: 0x00141603
		static vtkExtractDataArraysOverTime()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractDataArraysOverTime.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractDataArraysOverTime"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E7F7 RID: 59383 RVA: 0x0014342B File Offset: 0x0014162B
		public vtkExtractDataArraysOverTime(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E7F8 RID: 59384
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractDataArraysOverTime_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E7F9 RID: 59385 RVA: 0x0014343C File Offset: 0x0014163C
		public new static vtkExtractDataArraysOverTime New()
		{
			vtkExtractDataArraysOverTime result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractDataArraysOverTime.vtkExtractDataArraysOverTime_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractDataArraysOverTime)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E7FA RID: 59386 RVA: 0x00143490 File Offset: 0x00141690
		public vtkExtractDataArraysOverTime() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExtractDataArraysOverTime.vtkExtractDataArraysOverTime_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E7FB RID: 59387 RVA: 0x001434D4 File Offset: 0x001416D4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E7FC RID: 59388
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractDataArraysOverTime_GetFieldAssociation_01(HandleRef pThis);

		/// <summary>
		/// FieldAssociation indicates which attributes to extract over time. This filter
		/// can extract only one type of attribute arrays. Currently, vtkDataObject::FIELD
		/// and vtkDataObject::POINT_THEN_CELL are not supported.
		/// </summary>
		// Token: 0x0600E7FD RID: 59389 RVA: 0x001434E0 File Offset: 0x001416E0
		public virtual int GetFieldAssociation()
		{
			return vtkExtractDataArraysOverTime.vtkExtractDataArraysOverTime_GetFieldAssociation_01(base.GetCppThis());
		}

		// Token: 0x0600E7FE RID: 59390
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractDataArraysOverTime_GetFieldAssociationMaxValue_02(HandleRef pThis);

		/// <summary>
		/// FieldAssociation indicates which attributes to extract over time. This filter
		/// can extract only one type of attribute arrays. Currently, vtkDataObject::FIELD
		/// and vtkDataObject::POINT_THEN_CELL are not supported.
		/// </summary>
		// Token: 0x0600E7FF RID: 59391 RVA: 0x00143500 File Offset: 0x00141700
		public virtual int GetFieldAssociationMaxValue()
		{
			return vtkExtractDataArraysOverTime.vtkExtractDataArraysOverTime_GetFieldAssociationMaxValue_02(base.GetCppThis());
		}

		// Token: 0x0600E800 RID: 59392
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractDataArraysOverTime_GetFieldAssociationMinValue_03(HandleRef pThis);

		/// <summary>
		/// FieldAssociation indicates which attributes to extract over time. This filter
		/// can extract only one type of attribute arrays. Currently, vtkDataObject::FIELD
		/// and vtkDataObject::POINT_THEN_CELL are not supported.
		/// </summary>
		// Token: 0x0600E801 RID: 59393 RVA: 0x00143520 File Offset: 0x00141720
		public virtual int GetFieldAssociationMinValue()
		{
			return vtkExtractDataArraysOverTime.vtkExtractDataArraysOverTime_GetFieldAssociationMinValue_03(base.GetCppThis());
		}

		// Token: 0x0600E802 RID: 59394
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractDataArraysOverTime_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E803 RID: 59395 RVA: 0x00143540 File Offset: 0x00141740
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExtractDataArraysOverTime.vtkExtractDataArraysOverTime_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0600E804 RID: 59396
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractDataArraysOverTime_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E805 RID: 59397 RVA: 0x00143560 File Offset: 0x00141760
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExtractDataArraysOverTime.vtkExtractDataArraysOverTime_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0600E806 RID: 59398
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractDataArraysOverTime_GetNumberOfTimeSteps_06(HandleRef pThis);

		/// <summary>
		/// Get the number of time steps
		/// </summary>
		// Token: 0x0600E807 RID: 59399 RVA: 0x0014357C File Offset: 0x0014177C
		public virtual int GetNumberOfTimeSteps()
		{
			return vtkExtractDataArraysOverTime.vtkExtractDataArraysOverTime_GetNumberOfTimeSteps_06(base.GetCppThis());
		}

		// Token: 0x0600E808 RID: 59400
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExtractDataArraysOverTime_GetReportStatisticsOnly_07(HandleRef pThis);

		/// <summary>
		/// Instead of breaking a data into a separate time-history
		/// table for each (block,ID)-tuple, you may call
		/// ReportStatisticsOnlyOn(). Then a single table per
		/// block of the input dataset will report the minimum, maximum,
		/// quartiles, and (for numerical arrays) the average and standard
		/// deviation of the data over time.
		///
		/// The default is off to preserve backwards-compatibility.
		/// </summary>
		// Token: 0x0600E809 RID: 59401 RVA: 0x0014359C File Offset: 0x0014179C
		public virtual bool GetReportStatisticsOnly()
		{
			return vtkExtractDataArraysOverTime.vtkExtractDataArraysOverTime_GetReportStatisticsOnly_07(base.GetCppThis()) != 0;
		}

		// Token: 0x0600E80A RID: 59402
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExtractDataArraysOverTime_GetUseGlobalIDs_08(HandleRef pThis);

		/// <summary>
		/// When ReportStatisticsOnly is false, if UseGlobalIDs is true, then the filter will track
		/// elements using their global ids, if present. Default is true.
		/// </summary>
		// Token: 0x0600E80B RID: 59403 RVA: 0x001435C4 File Offset: 0x001417C4
		public virtual bool GetUseGlobalIDs()
		{
			return vtkExtractDataArraysOverTime.vtkExtractDataArraysOverTime_GetUseGlobalIDs_08(base.GetCppThis()) != 0;
		}

		// Token: 0x0600E80C RID: 59404
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractDataArraysOverTime_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E80D RID: 59405 RVA: 0x001435EC File Offset: 0x001417EC
		public override int IsA(string type)
		{
			return vtkExtractDataArraysOverTime.vtkExtractDataArraysOverTime_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x0600E80E RID: 59406
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractDataArraysOverTime_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E80F RID: 59407 RVA: 0x0014360C File Offset: 0x0014180C
		public new static int IsTypeOf(string type)
		{
			return vtkExtractDataArraysOverTime.vtkExtractDataArraysOverTime_IsTypeOf_10(type);
		}

		// Token: 0x0600E810 RID: 59408
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractDataArraysOverTime_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E811 RID: 59409 RVA: 0x00143628 File Offset: 0x00141828
		public new vtkExtractDataArraysOverTime NewInstance()
		{
			vtkExtractDataArraysOverTime result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractDataArraysOverTime.vtkExtractDataArraysOverTime_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractDataArraysOverTime)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E812 RID: 59410
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractDataArraysOverTime_ReportStatisticsOnlyOff_13(HandleRef pThis);

		/// <summary>
		/// Instead of breaking a data into a separate time-history
		/// table for each (block,ID)-tuple, you may call
		/// ReportStatisticsOnlyOn(). Then a single table per
		/// block of the input dataset will report the minimum, maximum,
		/// quartiles, and (for numerical arrays) the average and standard
		/// deviation of the data over time.
		///
		/// The default is off to preserve backwards-compatibility.
		/// </summary>
		// Token: 0x0600E813 RID: 59411 RVA: 0x00143682 File Offset: 0x00141882
		public virtual void ReportStatisticsOnlyOff()
		{
			vtkExtractDataArraysOverTime.vtkExtractDataArraysOverTime_ReportStatisticsOnlyOff_13(base.GetCppThis());
		}

		// Token: 0x0600E814 RID: 59412
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractDataArraysOverTime_ReportStatisticsOnlyOn_14(HandleRef pThis);

		/// <summary>
		/// Instead of breaking a data into a separate time-history
		/// table for each (block,ID)-tuple, you may call
		/// ReportStatisticsOnlyOn(). Then a single table per
		/// block of the input dataset will report the minimum, maximum,
		/// quartiles, and (for numerical arrays) the average and standard
		/// deviation of the data over time.
		///
		/// The default is off to preserve backwards-compatibility.
		/// </summary>
		// Token: 0x0600E815 RID: 59413 RVA: 0x00143691 File Offset: 0x00141891
		public virtual void ReportStatisticsOnlyOn()
		{
			vtkExtractDataArraysOverTime.vtkExtractDataArraysOverTime_ReportStatisticsOnlyOn_14(base.GetCppThis());
		}

		// Token: 0x0600E816 RID: 59414
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractDataArraysOverTime_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E817 RID: 59415 RVA: 0x001436A0 File Offset: 0x001418A0
		public new static vtkExtractDataArraysOverTime SafeDownCast(vtkObjectBase o)
		{
			vtkExtractDataArraysOverTime vtkExtractDataArraysOverTime = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractDataArraysOverTime.vtkExtractDataArraysOverTime_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractDataArraysOverTime = (vtkExtractDataArraysOverTime)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractDataArraysOverTime.Register(null);
				}
			}
			return vtkExtractDataArraysOverTime;
		}

		// Token: 0x0600E818 RID: 59416
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractDataArraysOverTime_SetFieldAssociation_16(HandleRef pThis, int _arg);

		/// <summary>
		/// FieldAssociation indicates which attributes to extract over time. This filter
		/// can extract only one type of attribute arrays. Currently, vtkDataObject::FIELD
		/// and vtkDataObject::POINT_THEN_CELL are not supported.
		/// </summary>
		// Token: 0x0600E819 RID: 59417 RVA: 0x0014371F File Offset: 0x0014191F
		public virtual void SetFieldAssociation(int _arg)
		{
			vtkExtractDataArraysOverTime.vtkExtractDataArraysOverTime_SetFieldAssociation_16(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E81A RID: 59418
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractDataArraysOverTime_SetReportStatisticsOnly_17(HandleRef pThis, byte _arg);

		/// <summary>
		/// Instead of breaking a data into a separate time-history
		/// table for each (block,ID)-tuple, you may call
		/// ReportStatisticsOnlyOn(). Then a single table per
		/// block of the input dataset will report the minimum, maximum,
		/// quartiles, and (for numerical arrays) the average and standard
		/// deviation of the data over time.
		///
		/// The default is off to preserve backwards-compatibility.
		/// </summary>
		// Token: 0x0600E81B RID: 59419 RVA: 0x0014372F File Offset: 0x0014192F
		public virtual void SetReportStatisticsOnly(bool _arg)
		{
			vtkExtractDataArraysOverTime.vtkExtractDataArraysOverTime_SetReportStatisticsOnly_17(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600E81C RID: 59420
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractDataArraysOverTime_SetUseGlobalIDs_18(HandleRef pThis, byte _arg);

		/// <summary>
		/// When ReportStatisticsOnly is false, if UseGlobalIDs is true, then the filter will track
		/// elements using their global ids, if present. Default is true.
		/// </summary>
		// Token: 0x0600E81D RID: 59421 RVA: 0x00143747 File Offset: 0x00141947
		public virtual void SetUseGlobalIDs(bool _arg)
		{
			vtkExtractDataArraysOverTime.vtkExtractDataArraysOverTime_SetUseGlobalIDs_18(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001108 RID: 4360
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractDataArraysOverTime";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001109 RID: 4361
		public new static readonly string MRClassNameKey = "class vtkExtractDataArraysOverTime";
	}
}
