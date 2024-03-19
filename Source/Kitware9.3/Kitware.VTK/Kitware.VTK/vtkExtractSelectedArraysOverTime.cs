using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExtractSelectedArraysOverTime
	/// </summary>
	/// <remarks>
	///    extracts a selection over time.
	///
	/// vtkExtractSelectedArraysOverTime extracts a selection over time.
	/// This is combination of two filters, an vtkExtractSelection filter followed by
	/// vtkExtractDataArraysOverTime, to do its work.
	///
	/// The filter has two inputs - 0th input is the temporal data to extracted,
	/// while the second input is the selection (vtkSelection) to extract. Based on
	/// the type of the selection, this filter setups up properties on the internal
	/// vtkExtractDataArraysOverTime instance to produce a reasonable extract.
	///
	/// The output is a vtkMultiBlockDataSet. See vtkExtractDataArraysOverTime for
	/// details on how the output is structured.
	/// </remarks>
	// Token: 0x02000513 RID: 1299
	public class vtkExtractSelectedArraysOverTime : vtkMultiBlockDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E864 RID: 59492 RVA: 0x00143F8F File Offset: 0x0014218F
		static vtkExtractSelectedArraysOverTime()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractSelectedArraysOverTime.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractSelectedArraysOverTime"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E865 RID: 59493 RVA: 0x00143FB7 File Offset: 0x001421B7
		public vtkExtractSelectedArraysOverTime(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E866 RID: 59494
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractSelectedArraysOverTime_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E867 RID: 59495 RVA: 0x00143FC8 File Offset: 0x001421C8
		public new static vtkExtractSelectedArraysOverTime New()
		{
			vtkExtractSelectedArraysOverTime result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractSelectedArraysOverTime.vtkExtractSelectedArraysOverTime_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractSelectedArraysOverTime)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E868 RID: 59496 RVA: 0x0014401C File Offset: 0x0014221C
		public vtkExtractSelectedArraysOverTime() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExtractSelectedArraysOverTime.vtkExtractSelectedArraysOverTime_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E869 RID: 59497 RVA: 0x00144060 File Offset: 0x00142260
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E86A RID: 59498
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractSelectedArraysOverTime_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E86B RID: 59499 RVA: 0x0014406C File Offset: 0x0014226C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExtractSelectedArraysOverTime.vtkExtractSelectedArraysOverTime_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600E86C RID: 59500
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractSelectedArraysOverTime_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E86D RID: 59501 RVA: 0x0014408C File Offset: 0x0014228C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExtractSelectedArraysOverTime.vtkExtractSelectedArraysOverTime_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600E86E RID: 59502
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractSelectedArraysOverTime_GetNumberOfTimeSteps_03(HandleRef pThis);

		/// <summary>
		/// Get the number of time steps
		/// </summary>
		// Token: 0x0600E86F RID: 59503 RVA: 0x001440A8 File Offset: 0x001422A8
		public virtual int GetNumberOfTimeSteps()
		{
			return vtkExtractSelectedArraysOverTime.vtkExtractSelectedArraysOverTime_GetNumberOfTimeSteps_03(base.GetCppThis());
		}

		// Token: 0x0600E870 RID: 59504
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExtractSelectedArraysOverTime_GetReportStatisticsOnly_04(HandleRef pThis);

		/// <summary>
		/// Instead of breaking a selection into a separate time-history
		/// table for each (block,ID)-tuple, you may call
		/// ReportStatisticsOnlyOn(). Then a single table per
		/// block of the input dataset will report the minimum, maximum,
		/// quartiles, and (for numerical arrays) the average and standard
		/// deviation of the selection over time.
		///
		/// The default is off to preserve backwards-compatibility.
		/// </summary>
		// Token: 0x0600E871 RID: 59505 RVA: 0x001440C8 File Offset: 0x001422C8
		public virtual bool GetReportStatisticsOnly()
		{
			return vtkExtractSelectedArraysOverTime.vtkExtractSelectedArraysOverTime_GetReportStatisticsOnly_04(base.GetCppThis()) != 0;
		}

		// Token: 0x0600E872 RID: 59506
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractSelectedArraysOverTime_GetSelectionExtractor_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get the vtkExtractSelection instance used to obtain
		/// array values at each time step. By default, vtkExtractSelection is used.
		/// </summary>
		// Token: 0x0600E873 RID: 59507 RVA: 0x001440F0 File Offset: 0x001422F0
		public vtkExtractSelection GetSelectionExtractor()
		{
			vtkExtractSelection vtkExtractSelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractSelectedArraysOverTime.vtkExtractSelectedArraysOverTime_GetSelectionExtractor_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractSelection = (vtkExtractSelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractSelection.Register(null);
				}
			}
			return vtkExtractSelection;
		}

		// Token: 0x0600E874 RID: 59508
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractSelectedArraysOverTime_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E875 RID: 59509 RVA: 0x00144160 File Offset: 0x00142360
		public override int IsA(string type)
		{
			return vtkExtractSelectedArraysOverTime.vtkExtractSelectedArraysOverTime_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0600E876 RID: 59510
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractSelectedArraysOverTime_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E877 RID: 59511 RVA: 0x00144180 File Offset: 0x00142380
		public new static int IsTypeOf(string type)
		{
			return vtkExtractSelectedArraysOverTime.vtkExtractSelectedArraysOverTime_IsTypeOf_07(type);
		}

		// Token: 0x0600E878 RID: 59512
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractSelectedArraysOverTime_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E879 RID: 59513 RVA: 0x0014419C File Offset: 0x0014239C
		public new vtkExtractSelectedArraysOverTime NewInstance()
		{
			vtkExtractSelectedArraysOverTime result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractSelectedArraysOverTime.vtkExtractSelectedArraysOverTime_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractSelectedArraysOverTime)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E87A RID: 59514
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractSelectedArraysOverTime_ReportStatisticsOnlyOff_10(HandleRef pThis);

		/// <summary>
		/// Instead of breaking a selection into a separate time-history
		/// table for each (block,ID)-tuple, you may call
		/// ReportStatisticsOnlyOn(). Then a single table per
		/// block of the input dataset will report the minimum, maximum,
		/// quartiles, and (for numerical arrays) the average and standard
		/// deviation of the selection over time.
		///
		/// The default is off to preserve backwards-compatibility.
		/// </summary>
		// Token: 0x0600E87B RID: 59515 RVA: 0x001441F6 File Offset: 0x001423F6
		public virtual void ReportStatisticsOnlyOff()
		{
			vtkExtractSelectedArraysOverTime.vtkExtractSelectedArraysOverTime_ReportStatisticsOnlyOff_10(base.GetCppThis());
		}

		// Token: 0x0600E87C RID: 59516
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractSelectedArraysOverTime_ReportStatisticsOnlyOn_11(HandleRef pThis);

		/// <summary>
		/// Instead of breaking a selection into a separate time-history
		/// table for each (block,ID)-tuple, you may call
		/// ReportStatisticsOnlyOn(). Then a single table per
		/// block of the input dataset will report the minimum, maximum,
		/// quartiles, and (for numerical arrays) the average and standard
		/// deviation of the selection over time.
		///
		/// The default is off to preserve backwards-compatibility.
		/// </summary>
		// Token: 0x0600E87D RID: 59517 RVA: 0x00144205 File Offset: 0x00142405
		public virtual void ReportStatisticsOnlyOn()
		{
			vtkExtractSelectedArraysOverTime.vtkExtractSelectedArraysOverTime_ReportStatisticsOnlyOn_11(base.GetCppThis());
		}

		// Token: 0x0600E87E RID: 59518
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractSelectedArraysOverTime_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E87F RID: 59519 RVA: 0x00144214 File Offset: 0x00142414
		public new static vtkExtractSelectedArraysOverTime SafeDownCast(vtkObjectBase o)
		{
			vtkExtractSelectedArraysOverTime vtkExtractSelectedArraysOverTime = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractSelectedArraysOverTime.vtkExtractSelectedArraysOverTime_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractSelectedArraysOverTime = (vtkExtractSelectedArraysOverTime)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractSelectedArraysOverTime.Register(null);
				}
			}
			return vtkExtractSelectedArraysOverTime;
		}

		// Token: 0x0600E880 RID: 59520
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractSelectedArraysOverTime_SetReportStatisticsOnly_13(HandleRef pThis, byte _arg);

		/// <summary>
		/// Instead of breaking a selection into a separate time-history
		/// table for each (block,ID)-tuple, you may call
		/// ReportStatisticsOnlyOn(). Then a single table per
		/// block of the input dataset will report the minimum, maximum,
		/// quartiles, and (for numerical arrays) the average and standard
		/// deviation of the selection over time.
		///
		/// The default is off to preserve backwards-compatibility.
		/// </summary>
		// Token: 0x0600E881 RID: 59521 RVA: 0x00144293 File Offset: 0x00142493
		public virtual void SetReportStatisticsOnly(bool _arg)
		{
			vtkExtractSelectedArraysOverTime.vtkExtractSelectedArraysOverTime_SetReportStatisticsOnly_13(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600E882 RID: 59522
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractSelectedArraysOverTime_SetSelectionConnection_14(HandleRef pThis, HandleRef algOutput);

		/// <summary>
		/// Convenience method to specify the selection connection (2nd input
		/// port)
		/// </summary>
		// Token: 0x0600E883 RID: 59523 RVA: 0x001442AC File Offset: 0x001424AC
		public void SetSelectionConnection(vtkAlgorithmOutput algOutput)
		{
			vtkExtractSelectedArraysOverTime.vtkExtractSelectedArraysOverTime_SetSelectionConnection_14(base.GetCppThis(), (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}

		// Token: 0x0600E884 RID: 59524
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractSelectedArraysOverTime_SetSelectionExtractor_15(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/get the vtkExtractSelection instance used to obtain
		/// array values at each time step. By default, vtkExtractSelection is used.
		/// </summary>
		// Token: 0x0600E885 RID: 59525 RVA: 0x001442DC File Offset: 0x001424DC
		public virtual void SetSelectionExtractor(vtkExtractSelection arg0)
		{
			vtkExtractSelectedArraysOverTime.vtkExtractSelectedArraysOverTime_SetSelectionExtractor_15(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001110 RID: 4368
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractSelectedArraysOverTime";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001111 RID: 4369
		public new static readonly string MRClassNameKey = "class vtkExtractSelectedArraysOverTime";
	}
}
