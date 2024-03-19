using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkExtractBlockUsingDataAssembly
	/// </summary>
	/// <remarks>
	///  extract blocks from certain composite datasets
	///
	/// vtkExtractBlockUsingDataAssembly is intended to extract selected blocks
	/// from certain composite datasets. Blocks to extract are selected using
	/// selectors. For supported selectors see `vtkDataAssembly::SelectNodes`.
	///
	/// The specific data-assembly to use to apply the selectors to determine the
	/// blocks to extract is chosen using `vtkExtractBlockUsingDataAssembly::SetAssemblyName`.
	///
	/// @section vtkExtractBlockUsingDataAssembly-SupportedDataTypes Supported Data Types
	///
	/// This filter accepts `vtkUniformGridAMR`,
	/// `vtkMultiBlockDataSet`, and `vtkPartitionedDataSetCollection` (and
	/// subclasses). vtkMultiPieceDataSet and vtkPartitionedDataSet are not accepted
	/// as inputs since those composite datasets are not comprised of "blocks".
	///
	/// For vtkOverlappingAMR, since extracting blocks cannot always guarantee a valid
	/// overlapping AMR, this filter generates a `vtkPartitionedDataSetCollection`
	/// instead. Any blanking information present in the input vtkOverlappingAMR is
	/// also discarded for the same reason.
	///
	/// For all other supported input data types, the type is preserved.
	/// </remarks>
	// Token: 0x020006A7 RID: 1703
	public class vtkExtractBlockUsingDataAssembly : vtkCompositeDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012384 RID: 74628 RVA: 0x00198683 File Offset: 0x00196883
		static vtkExtractBlockUsingDataAssembly()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractBlockUsingDataAssembly.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractBlockUsingDataAssembly"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012385 RID: 74629 RVA: 0x001986AB File Offset: 0x001968AB
		public vtkExtractBlockUsingDataAssembly(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012386 RID: 74630
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractBlockUsingDataAssembly_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012387 RID: 74631 RVA: 0x001986BC File Offset: 0x001968BC
		public new static vtkExtractBlockUsingDataAssembly New()
		{
			vtkExtractBlockUsingDataAssembly result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractBlockUsingDataAssembly.vtkExtractBlockUsingDataAssembly_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractBlockUsingDataAssembly)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012388 RID: 74632 RVA: 0x00198710 File Offset: 0x00196910
		public vtkExtractBlockUsingDataAssembly() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExtractBlockUsingDataAssembly.vtkExtractBlockUsingDataAssembly_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012389 RID: 74633 RVA: 0x00198754 File Offset: 0x00196954
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601238A RID: 74634
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExtractBlockUsingDataAssembly_AddSelector_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string selector);

		/// <summary>
		/// API to set selectors. Multiple selectors can be added using `AddSelector`.
		/// The order in which selectors are specified is not preserved and has no
		/// impact on the result.
		///
		/// `AddSelector` returns true if the selector was added, false if the selector
		/// was already specified and hence not added.
		///
		/// @sa vtkDataAssembly::SelectNodes
		/// </summary>
		// Token: 0x0601238B RID: 74635 RVA: 0x00198760 File Offset: 0x00196960
		public bool AddSelector(string selector)
		{
			return vtkExtractBlockUsingDataAssembly.vtkExtractBlockUsingDataAssembly_AddSelector_01(base.GetCppThis(), selector) != 0;
		}

		// Token: 0x0601238C RID: 74636
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractBlockUsingDataAssembly_ClearSelectors_02(HandleRef pThis);

		/// <summary>
		/// API to set selectors. Multiple selectors can be added using `AddSelector`.
		/// The order in which selectors are specified is not preserved and has no
		/// impact on the result.
		///
		/// `AddSelector` returns true if the selector was added, false if the selector
		/// was already specified and hence not added.
		///
		/// @sa vtkDataAssembly::SelectNodes
		/// </summary>
		// Token: 0x0601238D RID: 74637 RVA: 0x00198787 File Offset: 0x00196987
		public void ClearSelectors()
		{
			vtkExtractBlockUsingDataAssembly.vtkExtractBlockUsingDataAssembly_ClearSelectors_02(base.GetCppThis());
		}

		// Token: 0x0601238E RID: 74638
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractBlockUsingDataAssembly_GetAssemblyName_03(HandleRef pThis);

		/// <summary>
		/// Get/Set the active assembly to use. The chosen assembly is used
		/// in combination with the selectors specified to determine which blocks
		/// are to be extracted.
		///
		/// By default, this is set to
		/// vtkDataAssemblyUtilities::HierarchyName().
		/// </summary>
		// Token: 0x0601238F RID: 74639 RVA: 0x00198798 File Offset: 0x00196998
		public virtual string GetAssemblyName()
		{
			string s = Marshal.PtrToStringAnsi(vtkExtractBlockUsingDataAssembly.vtkExtractBlockUsingDataAssembly_GetAssemblyName_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06012390 RID: 74640
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractBlockUsingDataAssembly_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012391 RID: 74641 RVA: 0x001987D4 File Offset: 0x001969D4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExtractBlockUsingDataAssembly.vtkExtractBlockUsingDataAssembly_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06012392 RID: 74642
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractBlockUsingDataAssembly_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012393 RID: 74643 RVA: 0x001987F4 File Offset: 0x001969F4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExtractBlockUsingDataAssembly.vtkExtractBlockUsingDataAssembly_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06012394 RID: 74644
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractBlockUsingDataAssembly_GetNumberOfSelectors_06(HandleRef pThis);

		/// <summary>
		/// API to access selectors.
		/// </summary>
		// Token: 0x06012395 RID: 74645 RVA: 0x00198810 File Offset: 0x00196A10
		public int GetNumberOfSelectors()
		{
			return vtkExtractBlockUsingDataAssembly.vtkExtractBlockUsingDataAssembly_GetNumberOfSelectors_06(base.GetCppThis());
		}

		// Token: 0x06012396 RID: 74646
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExtractBlockUsingDataAssembly_GetPruneDataAssembly_07(HandleRef pThis);

		/// <summary>
		/// When set to true (default), the data assembly is pruned to remove
		/// branches that were not selected.
		/// </summary>
		// Token: 0x06012397 RID: 74647 RVA: 0x00198830 File Offset: 0x00196A30
		public virtual bool GetPruneDataAssembly()
		{
			return vtkExtractBlockUsingDataAssembly.vtkExtractBlockUsingDataAssembly_GetPruneDataAssembly_07(base.GetCppThis()) != 0;
		}

		// Token: 0x06012398 RID: 74648
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExtractBlockUsingDataAssembly_GetSelectSubtrees_08(HandleRef pThis);

		/// <summary>
		/// When set to true (default) subtrees for chosen paths are treated as
		/// selected.
		/// </summary>
		// Token: 0x06012399 RID: 74649 RVA: 0x00198858 File Offset: 0x00196A58
		public virtual bool GetSelectSubtrees()
		{
			return vtkExtractBlockUsingDataAssembly.vtkExtractBlockUsingDataAssembly_GetSelectSubtrees_08(base.GetCppThis()) != 0;
		}

		// Token: 0x0601239A RID: 74650
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractBlockUsingDataAssembly_GetSelector_09(HandleRef pThis, int index);

		/// <summary>
		/// API to access selectors.
		/// </summary>
		// Token: 0x0601239B RID: 74651 RVA: 0x00198880 File Offset: 0x00196A80
		public string GetSelector(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkExtractBlockUsingDataAssembly.vtkExtractBlockUsingDataAssembly_GetSelector_09(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601239C RID: 74652
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractBlockUsingDataAssembly_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601239D RID: 74653 RVA: 0x001988BC File Offset: 0x00196ABC
		public override int IsA(string type)
		{
			return vtkExtractBlockUsingDataAssembly.vtkExtractBlockUsingDataAssembly_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x0601239E RID: 74654
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractBlockUsingDataAssembly_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601239F RID: 74655 RVA: 0x001988DC File Offset: 0x00196ADC
		public new static int IsTypeOf(string type)
		{
			return vtkExtractBlockUsingDataAssembly.vtkExtractBlockUsingDataAssembly_IsTypeOf_11(type);
		}

		// Token: 0x060123A0 RID: 74656
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractBlockUsingDataAssembly_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060123A1 RID: 74657 RVA: 0x001988F8 File Offset: 0x00196AF8
		public new vtkExtractBlockUsingDataAssembly NewInstance()
		{
			vtkExtractBlockUsingDataAssembly result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractBlockUsingDataAssembly.vtkExtractBlockUsingDataAssembly_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractBlockUsingDataAssembly)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060123A2 RID: 74658
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractBlockUsingDataAssembly_PruneDataAssemblyOff_14(HandleRef pThis);

		/// <summary>
		/// When set to true (default), the data assembly is pruned to remove
		/// branches that were not selected.
		/// </summary>
		// Token: 0x060123A3 RID: 74659 RVA: 0x00198952 File Offset: 0x00196B52
		public virtual void PruneDataAssemblyOff()
		{
			vtkExtractBlockUsingDataAssembly.vtkExtractBlockUsingDataAssembly_PruneDataAssemblyOff_14(base.GetCppThis());
		}

		// Token: 0x060123A4 RID: 74660
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractBlockUsingDataAssembly_PruneDataAssemblyOn_15(HandleRef pThis);

		/// <summary>
		/// When set to true (default), the data assembly is pruned to remove
		/// branches that were not selected.
		/// </summary>
		// Token: 0x060123A5 RID: 74661 RVA: 0x00198961 File Offset: 0x00196B61
		public virtual void PruneDataAssemblyOn()
		{
			vtkExtractBlockUsingDataAssembly.vtkExtractBlockUsingDataAssembly_PruneDataAssemblyOn_15(base.GetCppThis());
		}

		// Token: 0x060123A6 RID: 74662
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractBlockUsingDataAssembly_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060123A7 RID: 74663 RVA: 0x00198970 File Offset: 0x00196B70
		public new static vtkExtractBlockUsingDataAssembly SafeDownCast(vtkObjectBase o)
		{
			vtkExtractBlockUsingDataAssembly vtkExtractBlockUsingDataAssembly = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractBlockUsingDataAssembly.vtkExtractBlockUsingDataAssembly_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractBlockUsingDataAssembly = (vtkExtractBlockUsingDataAssembly)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractBlockUsingDataAssembly.Register(null);
				}
			}
			return vtkExtractBlockUsingDataAssembly;
		}

		// Token: 0x060123A8 RID: 74664
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractBlockUsingDataAssembly_SelectSubtreesOff_17(HandleRef pThis);

		/// <summary>
		/// When set to true (default) subtrees for chosen paths are treated as
		/// selected.
		/// </summary>
		// Token: 0x060123A9 RID: 74665 RVA: 0x001989EF File Offset: 0x00196BEF
		public virtual void SelectSubtreesOff()
		{
			vtkExtractBlockUsingDataAssembly.vtkExtractBlockUsingDataAssembly_SelectSubtreesOff_17(base.GetCppThis());
		}

		// Token: 0x060123AA RID: 74666
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractBlockUsingDataAssembly_SelectSubtreesOn_18(HandleRef pThis);

		/// <summary>
		/// When set to true (default) subtrees for chosen paths are treated as
		/// selected.
		/// </summary>
		// Token: 0x060123AB RID: 74667 RVA: 0x001989FE File Offset: 0x00196BFE
		public virtual void SelectSubtreesOn()
		{
			vtkExtractBlockUsingDataAssembly.vtkExtractBlockUsingDataAssembly_SelectSubtreesOn_18(base.GetCppThis());
		}

		// Token: 0x060123AC RID: 74668
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractBlockUsingDataAssembly_SetAssemblyName_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Get/Set the active assembly to use. The chosen assembly is used
		/// in combination with the selectors specified to determine which blocks
		/// are to be extracted.
		///
		/// By default, this is set to
		/// vtkDataAssemblyUtilities::HierarchyName().
		/// </summary>
		// Token: 0x060123AD RID: 74669 RVA: 0x00198A0D File Offset: 0x00196C0D
		public virtual void SetAssemblyName(string _arg)
		{
			vtkExtractBlockUsingDataAssembly.vtkExtractBlockUsingDataAssembly_SetAssemblyName_19(base.GetCppThis(), _arg);
		}

		// Token: 0x060123AE RID: 74670
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractBlockUsingDataAssembly_SetPruneDataAssembly_20(HandleRef pThis, byte _arg);

		/// <summary>
		/// When set to true (default), the data assembly is pruned to remove
		/// branches that were not selected.
		/// </summary>
		// Token: 0x060123AF RID: 74671 RVA: 0x00198A1D File Offset: 0x00196C1D
		public virtual void SetPruneDataAssembly(bool _arg)
		{
			vtkExtractBlockUsingDataAssembly.vtkExtractBlockUsingDataAssembly_SetPruneDataAssembly_20(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060123B0 RID: 74672
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractBlockUsingDataAssembly_SetSelectSubtrees_21(HandleRef pThis, byte _arg);

		/// <summary>
		/// When set to true (default) subtrees for chosen paths are treated as
		/// selected.
		/// </summary>
		// Token: 0x060123B1 RID: 74673 RVA: 0x00198A35 File Offset: 0x00196C35
		public virtual void SetSelectSubtrees(bool _arg)
		{
			vtkExtractBlockUsingDataAssembly.vtkExtractBlockUsingDataAssembly_SetSelectSubtrees_21(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060123B2 RID: 74674
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractBlockUsingDataAssembly_SetSelector_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string selector);

		/// <summary>
		/// Convenience method to set a single selector.
		/// This clears any other existing selectors.
		/// </summary>
		// Token: 0x060123B3 RID: 74675 RVA: 0x00198A4D File Offset: 0x00196C4D
		public void SetSelector(string selector)
		{
			vtkExtractBlockUsingDataAssembly.vtkExtractBlockUsingDataAssembly_SetSelector_22(base.GetCppThis(), selector);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014FC RID: 5372
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractBlockUsingDataAssembly";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014FD RID: 5373
		public new static readonly string MRClassNameKey = "class vtkExtractBlockUsingDataAssembly";
	}
}
