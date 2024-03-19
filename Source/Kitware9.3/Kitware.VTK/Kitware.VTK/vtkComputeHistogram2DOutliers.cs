using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkComputeHistogram2DOutliers
	/// </summary>
	/// <remarks>
	///    compute the outliers in a set
	///  of 2D histograms and extract the corresponding row data.
	///
	///
	///  This class takes a table and one or more vtkImageData histograms as input
	///  and computes the outliers in that data.  In general it does so by
	///  identifying histogram bins that are removed by a median (salt and pepper)
	///  filter and below a threshold.  This threshold is automatically identified
	///  to retrieve a number of outliers close to a user-determined value.  This
	///  value is set by calling SetPreferredNumberOfOutliers(int).
	///
	///  The image data input can come either as a multiple vtkImageData via the
	///  repeatable INPUT_HISTOGRAM_IMAGE_DATA port, or as a single
	///  vtkMultiBlockDataSet containing vtkImageData objects as blocks.  One
	///  or the other must be set, not both (or neither).
	///
	///  The output can be retrieved as a set of row ids in a vtkSelection or
	///  as a vtkTable containing the actual outlier row data.
	///
	/// </remarks>
	/// <seealso>
	///
	///  vtkExtractHistogram2D vtkPComputeHistogram2DOutliers
	///
	/// @par Thanks:
	///  Developed by David Feng at Sandia National Laboratories
	///             ------------------------------------------------------------------------------
	/// </seealso>
	// Token: 0x0200046E RID: 1134
	public class vtkComputeHistogram2DOutliers : vtkSelectionAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D20C RID: 53772 RVA: 0x001244D7 File Offset: 0x001226D7
		static vtkComputeHistogram2DOutliers()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkComputeHistogram2DOutliers.MRClassNameKey, Type.GetType("Kitware.VTK.vtkComputeHistogram2DOutliers"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D20D RID: 53773 RVA: 0x001244FF File Offset: 0x001226FF
		public vtkComputeHistogram2DOutliers(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600D20E RID: 53774
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkComputeHistogram2DOutliers_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D20F RID: 53775 RVA: 0x00124510 File Offset: 0x00122710
		public new static vtkComputeHistogram2DOutliers New()
		{
			vtkComputeHistogram2DOutliers result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkComputeHistogram2DOutliers.vtkComputeHistogram2DOutliers_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkComputeHistogram2DOutliers)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D210 RID: 53776 RVA: 0x00124564 File Offset: 0x00122764
		public vtkComputeHistogram2DOutliers() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkComputeHistogram2DOutliers.vtkComputeHistogram2DOutliers_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D211 RID: 53777 RVA: 0x001245A8 File Offset: 0x001227A8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D212 RID: 53778
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkComputeHistogram2DOutliers_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D213 RID: 53779 RVA: 0x001245B4 File Offset: 0x001227B4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkComputeHistogram2DOutliers.vtkComputeHistogram2DOutliers_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600D214 RID: 53780
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkComputeHistogram2DOutliers_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D215 RID: 53781 RVA: 0x001245D4 File Offset: 0x001227D4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkComputeHistogram2DOutliers.vtkComputeHistogram2DOutliers_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600D216 RID: 53782
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkComputeHistogram2DOutliers_GetOutputTable_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D217 RID: 53783 RVA: 0x001245F0 File Offset: 0x001227F0
		public vtkTable GetOutputTable()
		{
			vtkTable vtkTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkComputeHistogram2DOutliers.vtkComputeHistogram2DOutliers_GetOutputTable_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTable = (vtkTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTable.Register(null);
				}
			}
			return vtkTable;
		}

		// Token: 0x0600D218 RID: 53784
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkComputeHistogram2DOutliers_GetPreferredNumberOfOutliers_04(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D219 RID: 53785 RVA: 0x00124660 File Offset: 0x00122860
		public virtual int GetPreferredNumberOfOutliers()
		{
			return vtkComputeHistogram2DOutliers.vtkComputeHistogram2DOutliers_GetPreferredNumberOfOutliers_04(base.GetCppThis());
		}

		// Token: 0x0600D21A RID: 53786
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkComputeHistogram2DOutliers_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D21B RID: 53787 RVA: 0x00124680 File Offset: 0x00122880
		public override int IsA(string type)
		{
			return vtkComputeHistogram2DOutliers.vtkComputeHistogram2DOutliers_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600D21C RID: 53788
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkComputeHistogram2DOutliers_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D21D RID: 53789 RVA: 0x001246A0 File Offset: 0x001228A0
		public new static int IsTypeOf(string type)
		{
			return vtkComputeHistogram2DOutliers.vtkComputeHistogram2DOutliers_IsTypeOf_06(type);
		}

		// Token: 0x0600D21E RID: 53790
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkComputeHistogram2DOutliers_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D21F RID: 53791 RVA: 0x001246BC File Offset: 0x001228BC
		public new vtkComputeHistogram2DOutliers NewInstance()
		{
			vtkComputeHistogram2DOutliers result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkComputeHistogram2DOutliers.vtkComputeHistogram2DOutliers_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkComputeHistogram2DOutliers)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D220 RID: 53792
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkComputeHistogram2DOutliers_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D221 RID: 53793 RVA: 0x00124718 File Offset: 0x00122918
		public new static vtkComputeHistogram2DOutliers SafeDownCast(vtkObjectBase o)
		{
			vtkComputeHistogram2DOutliers vtkComputeHistogram2DOutliers = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkComputeHistogram2DOutliers.vtkComputeHistogram2DOutliers_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkComputeHistogram2DOutliers = (vtkComputeHistogram2DOutliers)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkComputeHistogram2DOutliers.Register(null);
				}
			}
			return vtkComputeHistogram2DOutliers;
		}

		// Token: 0x0600D222 RID: 53794
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkComputeHistogram2DOutliers_SetInputHistogramImageDataConnection_10(HandleRef pThis, HandleRef cxn);

		/// <summary>
		/// Set the input histogram data as a (repeatable) vtkImageData
		/// </summary>
		// Token: 0x0600D223 RID: 53795 RVA: 0x00124798 File Offset: 0x00122998
		public void SetInputHistogramImageDataConnection(vtkAlgorithmOutput cxn)
		{
			vtkComputeHistogram2DOutliers.vtkComputeHistogram2DOutliers_SetInputHistogramImageDataConnection_10(base.GetCppThis(), (cxn == null) ? default(HandleRef) : cxn.GetCppThis());
		}

		// Token: 0x0600D224 RID: 53796
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkComputeHistogram2DOutliers_SetInputHistogramMultiBlockConnection_11(HandleRef pThis, HandleRef cxn);

		/// <summary>
		/// Set the input histogram data as a vtkMultiBlockData set
		/// containing multiple vtkImageData objects.
		/// </summary>
		// Token: 0x0600D225 RID: 53797 RVA: 0x001247C8 File Offset: 0x001229C8
		public void SetInputHistogramMultiBlockConnection(vtkAlgorithmOutput cxn)
		{
			vtkComputeHistogram2DOutliers.vtkComputeHistogram2DOutliers_SetInputHistogramMultiBlockConnection_11(base.GetCppThis(), (cxn == null) ? default(HandleRef) : cxn.GetCppThis());
		}

		// Token: 0x0600D226 RID: 53798
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkComputeHistogram2DOutliers_SetInputTableConnection_12(HandleRef pThis, HandleRef cxn);

		/// <summary>
		/// Set the source table data, from which data will be filtered.
		/// </summary>
		// Token: 0x0600D227 RID: 53799 RVA: 0x001247F8 File Offset: 0x001229F8
		public void SetInputTableConnection(vtkAlgorithmOutput cxn)
		{
			vtkComputeHistogram2DOutliers.vtkComputeHistogram2DOutliers_SetInputTableConnection_12(base.GetCppThis(), (cxn == null) ? default(HandleRef) : cxn.GetCppThis());
		}

		// Token: 0x0600D228 RID: 53800
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkComputeHistogram2DOutliers_SetPreferredNumberOfOutliers_13(HandleRef pThis, int _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D229 RID: 53801 RVA: 0x00124827 File Offset: 0x00122A27
		public virtual void SetPreferredNumberOfOutliers(int _arg)
		{
			vtkComputeHistogram2DOutliers.vtkComputeHistogram2DOutliers_SetPreferredNumberOfOutliers_13(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F7D RID: 3965
		public new const string MRFullTypeName = "Kitware.VTK.vtkComputeHistogram2DOutliers";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F7E RID: 3966
		public new static readonly string MRClassNameKey = "class vtkComputeHistogram2DOutliers";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0200046F RID: 1135
		public enum InputPorts
		{
			/// <summary>enum member</summary>
			// Token: 0x04000F80 RID: 3968
			INPUT_HISTOGRAMS_IMAGE_DATA = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000F81 RID: 3969
			INPUT_HISTOGRAMS_MULTIBLOCK,
			/// <summary>enum member</summary>
			// Token: 0x04000F82 RID: 3970
			INPUT_TABLE_DATA = 0
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x02000470 RID: 1136
		public enum OutputPorts
		{
			/// <summary>enum member</summary>
			// Token: 0x04000F84 RID: 3972
			OUTPUT_SELECTED_ROWS,
			/// <summary>enum member</summary>
			// Token: 0x04000F85 RID: 3973
			OUTPUT_SELECTED_TABLE_DATA
		}
	}
}
