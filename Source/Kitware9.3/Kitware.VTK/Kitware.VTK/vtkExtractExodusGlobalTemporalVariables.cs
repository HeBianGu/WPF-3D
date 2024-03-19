using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkExtractExodusGlobalTemporalVariables
	/// </summary>
	/// <remarks>
	///  extract global temporal arrays or suitable field data arrays
	///
	/// vtkExtractExodusGlobalTemporalVariables extracts field data arrays that it
	/// determines to represent temporal quantities. This determination is done as
	/// follows:
	///
	/// * If `AutoDetectGlobalTemporalDataArrays` is true, it checks if to see if the
	///   field data has any array with a key named "GLOBAL_TEMPORAL_VARIABLE". If
	///   found, only arrays with this key are extracted.
	/// * If such an array is not found, or if `AutoDetectGlobalTemporalDataArrays` is
	///   false, then all arrays with single tuple are extracted.
	///
	/// If an array has GLOBAL_TEMPORAL_VARIABLE key in its information, it means
	/// that the array has multiple tuples each associated with the specific
	/// timestep. This was pattern first introduced in `vtkExodusIIReader` and hence
	/// the name for this class. This class was originally only intended to extract
	/// such arrays. It has since been expanded to support other arrays in field
	/// data.
	///
	/// If the number of tuples in a GLOBAL_TEMPORAL_VARIABLE array is less than the
	/// number of timesteps, we assume that we are dealing with restarted files and
	/// hence update the pipeline appropriately to request the remaining tuples
	/// iteratively.
	///
	/// For arrays without GLOBAL_TEMPORAL_VARIABLE, we always iterate over all input
	/// timesteps one at a time and accumulate the results.
	///
	/// </remarks>
	/// <seealso>
	///  vtkExodusIIReader, vtkExodusIIReader::GLOBAL_TEMPORAL_VARIABLE.
	/// </seealso>
	// Token: 0x02000511 RID: 1297
	public class vtkExtractExodusGlobalTemporalVariables : vtkTableAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E834 RID: 59444 RVA: 0x00143A2F File Offset: 0x00141C2F
		static vtkExtractExodusGlobalTemporalVariables()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractExodusGlobalTemporalVariables.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractExodusGlobalTemporalVariables"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E835 RID: 59445 RVA: 0x00143A57 File Offset: 0x00141C57
		public vtkExtractExodusGlobalTemporalVariables(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E836 RID: 59446
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractExodusGlobalTemporalVariables_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E837 RID: 59447 RVA: 0x00143A68 File Offset: 0x00141C68
		public new static vtkExtractExodusGlobalTemporalVariables New()
		{
			vtkExtractExodusGlobalTemporalVariables result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractExodusGlobalTemporalVariables.vtkExtractExodusGlobalTemporalVariables_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractExodusGlobalTemporalVariables)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E838 RID: 59448 RVA: 0x00143ABC File Offset: 0x00141CBC
		public vtkExtractExodusGlobalTemporalVariables() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExtractExodusGlobalTemporalVariables.vtkExtractExodusGlobalTemporalVariables_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E839 RID: 59449 RVA: 0x00143B00 File Offset: 0x00141D00
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E83A RID: 59450
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractExodusGlobalTemporalVariables_AutoDetectGlobalTemporalDataArraysOff_01(HandleRef pThis);

		/// <summary>
		/// When set to true (default) this filter will check if any of the arrays in
		/// the input field data has a key named `GLOBAL_TEMPORAL_VARIABLE`. If so,
		/// this filter will only extract those arrays. If no such array is found, then
		/// all single-tuple arrays are extracted. Set this to false to disable this
		/// auto-detection and simply extract all single-tuple arrays.
		///
		/// @sa `vtkExodusIIReader::GLOBAL_TEMPORAL_VARIABLE`
		/// </summary>
		// Token: 0x0600E83B RID: 59451 RVA: 0x00143B0B File Offset: 0x00141D0B
		public virtual void AutoDetectGlobalTemporalDataArraysOff()
		{
			vtkExtractExodusGlobalTemporalVariables.vtkExtractExodusGlobalTemporalVariables_AutoDetectGlobalTemporalDataArraysOff_01(base.GetCppThis());
		}

		// Token: 0x0600E83C RID: 59452
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractExodusGlobalTemporalVariables_AutoDetectGlobalTemporalDataArraysOn_02(HandleRef pThis);

		/// <summary>
		/// When set to true (default) this filter will check if any of the arrays in
		/// the input field data has a key named `GLOBAL_TEMPORAL_VARIABLE`. If so,
		/// this filter will only extract those arrays. If no such array is found, then
		/// all single-tuple arrays are extracted. Set this to false to disable this
		/// auto-detection and simply extract all single-tuple arrays.
		///
		/// @sa `vtkExodusIIReader::GLOBAL_TEMPORAL_VARIABLE`
		/// </summary>
		// Token: 0x0600E83D RID: 59453 RVA: 0x00143B1A File Offset: 0x00141D1A
		public virtual void AutoDetectGlobalTemporalDataArraysOn()
		{
			vtkExtractExodusGlobalTemporalVariables.vtkExtractExodusGlobalTemporalVariables_AutoDetectGlobalTemporalDataArraysOn_02(base.GetCppThis());
		}

		// Token: 0x0600E83E RID: 59454
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExtractExodusGlobalTemporalVariables_GetAutoDetectGlobalTemporalDataArrays_03(HandleRef pThis);

		/// <summary>
		/// When set to true (default) this filter will check if any of the arrays in
		/// the input field data has a key named `GLOBAL_TEMPORAL_VARIABLE`. If so,
		/// this filter will only extract those arrays. If no such array is found, then
		/// all single-tuple arrays are extracted. Set this to false to disable this
		/// auto-detection and simply extract all single-tuple arrays.
		///
		/// @sa `vtkExodusIIReader::GLOBAL_TEMPORAL_VARIABLE`
		/// </summary>
		// Token: 0x0600E83F RID: 59455 RVA: 0x00143B2C File Offset: 0x00141D2C
		public virtual bool GetAutoDetectGlobalTemporalDataArrays()
		{
			return vtkExtractExodusGlobalTemporalVariables.vtkExtractExodusGlobalTemporalVariables_GetAutoDetectGlobalTemporalDataArrays_03(base.GetCppThis()) != 0;
		}

		// Token: 0x0600E840 RID: 59456
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractExodusGlobalTemporalVariables_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E841 RID: 59457 RVA: 0x00143B54 File Offset: 0x00141D54
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExtractExodusGlobalTemporalVariables.vtkExtractExodusGlobalTemporalVariables_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0600E842 RID: 59458
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractExodusGlobalTemporalVariables_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E843 RID: 59459 RVA: 0x00143B74 File Offset: 0x00141D74
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExtractExodusGlobalTemporalVariables.vtkExtractExodusGlobalTemporalVariables_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0600E844 RID: 59460
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractExodusGlobalTemporalVariables_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E845 RID: 59461 RVA: 0x00143B90 File Offset: 0x00141D90
		public override int IsA(string type)
		{
			return vtkExtractExodusGlobalTemporalVariables.vtkExtractExodusGlobalTemporalVariables_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0600E846 RID: 59462
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractExodusGlobalTemporalVariables_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E847 RID: 59463 RVA: 0x00143BB0 File Offset: 0x00141DB0
		public new static int IsTypeOf(string type)
		{
			return vtkExtractExodusGlobalTemporalVariables.vtkExtractExodusGlobalTemporalVariables_IsTypeOf_07(type);
		}

		// Token: 0x0600E848 RID: 59464
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractExodusGlobalTemporalVariables_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E849 RID: 59465 RVA: 0x00143BCC File Offset: 0x00141DCC
		public new vtkExtractExodusGlobalTemporalVariables NewInstance()
		{
			vtkExtractExodusGlobalTemporalVariables result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractExodusGlobalTemporalVariables.vtkExtractExodusGlobalTemporalVariables_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractExodusGlobalTemporalVariables)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E84A RID: 59466
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractExodusGlobalTemporalVariables_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E84B RID: 59467 RVA: 0x00143C28 File Offset: 0x00141E28
		public new static vtkExtractExodusGlobalTemporalVariables SafeDownCast(vtkObjectBase o)
		{
			vtkExtractExodusGlobalTemporalVariables vtkExtractExodusGlobalTemporalVariables = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractExodusGlobalTemporalVariables.vtkExtractExodusGlobalTemporalVariables_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractExodusGlobalTemporalVariables = (vtkExtractExodusGlobalTemporalVariables)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractExodusGlobalTemporalVariables.Register(null);
				}
			}
			return vtkExtractExodusGlobalTemporalVariables;
		}

		// Token: 0x0600E84C RID: 59468
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractExodusGlobalTemporalVariables_SetAutoDetectGlobalTemporalDataArrays_11(HandleRef pThis, byte _arg);

		/// <summary>
		/// When set to true (default) this filter will check if any of the arrays in
		/// the input field data has a key named `GLOBAL_TEMPORAL_VARIABLE`. If so,
		/// this filter will only extract those arrays. If no such array is found, then
		/// all single-tuple arrays are extracted. Set this to false to disable this
		/// auto-detection and simply extract all single-tuple arrays.
		///
		/// @sa `vtkExodusIIReader::GLOBAL_TEMPORAL_VARIABLE`
		/// </summary>
		// Token: 0x0600E84D RID: 59469 RVA: 0x00143CA7 File Offset: 0x00141EA7
		public virtual void SetAutoDetectGlobalTemporalDataArrays(bool _arg)
		{
			vtkExtractExodusGlobalTemporalVariables.vtkExtractExodusGlobalTemporalVariables_SetAutoDetectGlobalTemporalDataArrays_11(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400110C RID: 4364
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractExodusGlobalTemporalVariables";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400110D RID: 4365
		public new static readonly string MRClassNameKey = "class vtkExtractExodusGlobalTemporalVariables";
	}
}
