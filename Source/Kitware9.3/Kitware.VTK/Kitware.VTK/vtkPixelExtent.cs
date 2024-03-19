using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPixelExtent
	///
	/// Representation of a cartesian pixel plane and common operations
	/// on it. The implementation is intended to be fast and light
	/// so that it may be used in place of int[4] with little or no
	/// performance penalty.
	///
	/// NOTE in most cases operation on an empty object produces
	/// incorrect results. If it an issue query Empty() first.
	/// </summary>
	// Token: 0x02000A96 RID: 2710
	public class vtkPixelExtent : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601C6B6 RID: 116406 RVA: 0x0027ED0D File Offset: 0x0027CF0D
		static vtkPixelExtent()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPixelExtent.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPixelExtent"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601C6B7 RID: 116407 RVA: 0x0027ED35 File Offset: 0x0027CF35
		public vtkPixelExtent(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601C6B8 RID: 116408 RVA: 0x0027ED43 File Offset: 0x0027CF43
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601C6B9 RID: 116409
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPixelExtent_CellToNode_01(HandleRef pThis);

		/// <summary>
		/// In-place conversion from cell based to node based extent, and vise-versa.
		/// </summary>
		// Token: 0x0601C6BA RID: 116410 RVA: 0x0027ED4E File Offset: 0x0027CF4E
		public void CellToNode()
		{
			vtkPixelExtent.vtkPixelExtent_CellToNode_01(base.GetCppThis());
		}

		// Token: 0x0601C6BB RID: 116411
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkPixelExtent vtkPixelExtent_CellToNode_02(vtkPixelExtent inputExt);

		/// <summary>
		/// Convert from cell extent to point extent
		/// while respecting the dimensionality of the data.
		/// </summary>
		// Token: 0x0601C6BC RID: 116412 RVA: 0x0027ED60 File Offset: 0x0027CF60
		public static vtkPixelExtent CellToNode(vtkPixelExtent inputExt)
		{
			return vtkPixelExtent.vtkPixelExtent_CellToNode_02(inputExt);
		}

		// Token: 0x0601C6BD RID: 116413
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPixelExtent_Clear_03(HandleRef pThis);

		/// <summary>
		/// Set the extent.
		/// </summary>
		// Token: 0x0601C6BE RID: 116414 RVA: 0x0027ED7A File Offset: 0x0027CF7A
		public void Clear()
		{
			vtkPixelExtent.vtkPixelExtent_Clear_03(base.GetCppThis());
		}

		// Token: 0x0601C6BF RID: 116415
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPixelExtent_Contains_04(HandleRef pThis, vtkPixelExtent other);

		/// <summary>
		/// Return non-zero if this extent contains the other.
		/// </summary>
		// Token: 0x0601C6C0 RID: 116416 RVA: 0x0027ED8C File Offset: 0x0027CF8C
		public int Contains(vtkPixelExtent other)
		{
			return vtkPixelExtent.vtkPixelExtent_Contains_04(base.GetCppThis(), other);
		}

		// Token: 0x0601C6C1 RID: 116417
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPixelExtent_Contains_05(HandleRef pThis, int i, int j);

		/// <summary>
		/// Return non-zero if this extent contains the other.
		/// </summary>
		// Token: 0x0601C6C2 RID: 116418 RVA: 0x0027EDAC File Offset: 0x0027CFAC
		public int Contains(int i, int j)
		{
			return vtkPixelExtent.vtkPixelExtent_Contains_05(base.GetCppThis(), i, j);
		}

		// Token: 0x0601C6C3 RID: 116419
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPixelExtent_Disjoint_06(HandleRef pThis, vtkPixelExtent other);

		/// <summary>
		/// Return non-zero if the extent is disjoint from the other
		/// </summary>
		// Token: 0x0601C6C4 RID: 116420 RVA: 0x0027EDD0 File Offset: 0x0027CFD0
		public int Disjoint(vtkPixelExtent other)
		{
			return vtkPixelExtent.vtkPixelExtent_Disjoint_06(base.GetCppThis(), other);
		}

		// Token: 0x0601C6C5 RID: 116421
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPixelExtent_Empty_07(HandleRef pThis);

		/// <summary>
		/// Return true if empty.
		/// </summary>
		// Token: 0x0601C6C6 RID: 116422 RVA: 0x0027EDF0 File Offset: 0x0027CFF0
		public int Empty()
		{
			return vtkPixelExtent.vtkPixelExtent_Empty_07(base.GetCppThis());
		}

		// Token: 0x0601C6C7 RID: 116423
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPixelExtent_GetData_08(HandleRef pThis);

		/// <summary>
		/// Direct access to internal data.
		/// </summary>
		// Token: 0x0601C6C8 RID: 116424 RVA: 0x0027EE10 File Offset: 0x0027D010
		public IntPtr GetData()
		{
			return vtkPixelExtent.vtkPixelExtent_GetData_08(base.GetCppThis());
		}

		// Token: 0x0601C6C9 RID: 116425
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPixelExtent_GetDataU_09(HandleRef pThis);

		/// <summary>
		/// Direct access to internal data.
		/// </summary>
		// Token: 0x0601C6CA RID: 116426 RVA: 0x0027EE30 File Offset: 0x0027D030
		public IntPtr GetDataU()
		{
			return vtkPixelExtent.vtkPixelExtent_GetDataU_09(base.GetCppThis());
		}

		// Token: 0x0601C6CB RID: 116427
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPixelExtent_GetEndIndex_10(HandleRef pThis, IntPtr last);

		/// <summary>
		/// Get the start/end index.
		/// </summary>
		// Token: 0x0601C6CC RID: 116428 RVA: 0x0027EE4F File Offset: 0x0027D04F
		public void GetEndIndex(IntPtr last)
		{
			vtkPixelExtent.vtkPixelExtent_GetEndIndex_10(base.GetCppThis(), last);
		}

		// Token: 0x0601C6CD RID: 116429
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPixelExtent_GetStartIndex_11(HandleRef pThis, IntPtr first);

		/// <summary>
		/// Get the start/end index.
		/// </summary>
		// Token: 0x0601C6CE RID: 116430 RVA: 0x0027EE5F File Offset: 0x0027D05F
		public void GetStartIndex(IntPtr first)
		{
			vtkPixelExtent.vtkPixelExtent_GetStartIndex_11(base.GetCppThis(), first);
		}

		// Token: 0x0601C6CF RID: 116431
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPixelExtent_GetStartIndex_12(HandleRef pThis, IntPtr first, IntPtr origin);

		/// <summary>
		/// Get the start/end index.
		/// </summary>
		// Token: 0x0601C6D0 RID: 116432 RVA: 0x0027EE6F File Offset: 0x0027D06F
		public void GetStartIndex(IntPtr first, IntPtr origin)
		{
			vtkPixelExtent.vtkPixelExtent_GetStartIndex_12(base.GetCppThis(), first, origin);
		}

		// Token: 0x0601C6D1 RID: 116433
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPixelExtent_Grow_13(HandleRef pThis, int n);

		/// <summary>
		/// Expand the extents by n.
		/// </summary>
		// Token: 0x0601C6D2 RID: 116434 RVA: 0x0027EE80 File Offset: 0x0027D080
		public void Grow(int n)
		{
			vtkPixelExtent.vtkPixelExtent_Grow_13(base.GetCppThis(), n);
		}

		// Token: 0x0601C6D3 RID: 116435
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPixelExtent_Grow_14(HandleRef pThis, int q, int n);

		/// <summary>
		/// Expand the extents by n.
		/// </summary>
		// Token: 0x0601C6D4 RID: 116436 RVA: 0x0027EE90 File Offset: 0x0027D090
		public void Grow(int q, int n)
		{
			vtkPixelExtent.vtkPixelExtent_Grow_14(base.GetCppThis(), q, n);
		}

		// Token: 0x0601C6D5 RID: 116437
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkPixelExtent vtkPixelExtent_Grow_15(vtkPixelExtent inputExt, int n);

		/// <summary>
		/// Add or remove ghost cells. If a problem domain is
		/// provided then the result is clipled to be within the
		/// problem domain.
		/// </summary>
		// Token: 0x0601C6D6 RID: 116438 RVA: 0x0027EEA4 File Offset: 0x0027D0A4
		public static vtkPixelExtent Grow(vtkPixelExtent inputExt, int n)
		{
			return vtkPixelExtent.vtkPixelExtent_Grow_15(inputExt, n);
		}

		// Token: 0x0601C6D7 RID: 116439
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkPixelExtent vtkPixelExtent_Grow_16(vtkPixelExtent inputExt, vtkPixelExtent problemDomain, int n);

		/// <summary>
		/// Add or remove ghost cells. If a problem domain is
		/// provided then the result is clipled to be within the
		/// problem domain.
		/// </summary>
		// Token: 0x0601C6D8 RID: 116440 RVA: 0x0027EEC0 File Offset: 0x0027D0C0
		public static vtkPixelExtent Grow(vtkPixelExtent inputExt, vtkPixelExtent problemDomain, int n)
		{
			return vtkPixelExtent.vtkPixelExtent_Grow_16(inputExt, problemDomain, n);
		}

		// Token: 0x0601C6D9 RID: 116441
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPixelExtent_GrowHigh_17(HandleRef pThis, int q, int n);

		/// <summary>
		/// Expand the extents by n.
		/// </summary>
		// Token: 0x0601C6DA RID: 116442 RVA: 0x0027EEDC File Offset: 0x0027D0DC
		public void GrowHigh(int q, int n)
		{
			vtkPixelExtent.vtkPixelExtent_GrowHigh_17(base.GetCppThis(), q, n);
		}

		// Token: 0x0601C6DB RID: 116443
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkPixelExtent vtkPixelExtent_GrowHigh_18(vtkPixelExtent ext, int q, int n);

		/// <summary>
		/// Add or remove ghost cells. If a problem domain is
		/// provided then the result is clipled to be within the
		/// problem domain.
		/// </summary>
		// Token: 0x0601C6DC RID: 116444 RVA: 0x0027EEF0 File Offset: 0x0027D0F0
		public static vtkPixelExtent GrowHigh(vtkPixelExtent ext, int q, int n)
		{
			return vtkPixelExtent.vtkPixelExtent_GrowHigh_18(ext, q, n);
		}

		// Token: 0x0601C6DD RID: 116445
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPixelExtent_GrowLow_19(HandleRef pThis, int q, int n);

		/// <summary>
		/// Expand the extents by n.
		/// </summary>
		// Token: 0x0601C6DE RID: 116446 RVA: 0x0027EF0C File Offset: 0x0027D10C
		public void GrowLow(int q, int n)
		{
			vtkPixelExtent.vtkPixelExtent_GrowLow_19(base.GetCppThis(), q, n);
		}

		// Token: 0x0601C6DF RID: 116447
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkPixelExtent vtkPixelExtent_GrowLow_20(vtkPixelExtent ext, int q, int n);

		/// <summary>
		/// Add or remove ghost cells. If a problem domain is
		/// provided then the result is clipled to be within the
		/// problem domain.
		/// </summary>
		// Token: 0x0601C6E0 RID: 116448 RVA: 0x0027EF20 File Offset: 0x0027D120
		public static vtkPixelExtent GrowLow(vtkPixelExtent ext, int q, int n)
		{
			return vtkPixelExtent.vtkPixelExtent_GrowLow_20(ext, q, n);
		}

		// Token: 0x0601C6E1 RID: 116449
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPixelExtent_NodeToCell_21(HandleRef pThis);

		/// <summary>
		/// In-place conversion from cell based to node based extent, and vise-versa.
		/// </summary>
		// Token: 0x0601C6E2 RID: 116450 RVA: 0x0027EF3C File Offset: 0x0027D13C
		public void NodeToCell()
		{
			vtkPixelExtent.vtkPixelExtent_NodeToCell_21(base.GetCppThis());
		}

		// Token: 0x0601C6E3 RID: 116451
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkPixelExtent vtkPixelExtent_NodeToCell_22(vtkPixelExtent inputExt);

		/// <summary>
		/// Convert from point extent to cell extent
		/// while respecting the dimensionality of the data.
		/// </summary>
		// Token: 0x0601C6E4 RID: 116452 RVA: 0x0027EF4C File Offset: 0x0027D14C
		public static vtkPixelExtent NodeToCell(vtkPixelExtent inputExt)
		{
			return vtkPixelExtent.vtkPixelExtent_NodeToCell_22(inputExt);
		}

		// Token: 0x0601C6E5 RID: 116453
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPixelExtent_SetData_23(HandleRef pThis, vtkPixelExtent ext);

		/// <summary>
		/// Set the extent.
		/// </summary>
		// Token: 0x0601C6E6 RID: 116454 RVA: 0x0027EF66 File Offset: 0x0027D166
		public void SetData(vtkPixelExtent ext)
		{
			vtkPixelExtent.vtkPixelExtent_SetData_23(base.GetCppThis(), ext);
		}

		// Token: 0x0601C6E7 RID: 116455
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPixelExtent_SetData_24(HandleRef pThis, IntPtr ext);

		/// <summary>
		/// Stream insertion operator for formatted output of pixel extents.
		/// </summary>
		// Token: 0x0601C6E8 RID: 116456 RVA: 0x0027EF76 File Offset: 0x0027D176
		public void SetData(IntPtr ext)
		{
			vtkPixelExtent.vtkPixelExtent_SetData_24(base.GetCppThis(), ext);
		}

		// Token: 0x0601C6E9 RID: 116457
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPixelExtent_SetData_25(HandleRef pThis, int ilo, int ihi, int jlo, int jhi);

		/// <summary>
		/// Stream insertion operator for formatted output of pixel extents.
		/// </summary>
		// Token: 0x0601C6EA RID: 116458 RVA: 0x0027EF86 File Offset: 0x0027D186
		public void SetData(int ilo, int ihi, int jlo, int jhi)
		{
			vtkPixelExtent.vtkPixelExtent_SetData_25(base.GetCppThis(), ilo, ihi, jlo, jhi);
		}

		// Token: 0x0601C6EB RID: 116459
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPixelExtent_Shift_26(HandleRef pThis);

		/// <summary>
		/// Shifts by low corner of this, moving to the origin.
		/// </summary>
		// Token: 0x0601C6EC RID: 116460 RVA: 0x0027EF9A File Offset: 0x0027D19A
		public void Shift()
		{
			vtkPixelExtent.vtkPixelExtent_Shift_26(base.GetCppThis());
		}

		// Token: 0x0601C6ED RID: 116461
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPixelExtent_Shift_27(HandleRef pThis, vtkPixelExtent ext);

		/// <summary>
		/// Shift by low corner of the given extent.
		/// </summary>
		// Token: 0x0601C6EE RID: 116462 RVA: 0x0027EFA9 File Offset: 0x0027D1A9
		public void Shift(vtkPixelExtent ext)
		{
			vtkPixelExtent.vtkPixelExtent_Shift_27(base.GetCppThis(), ext);
		}

		// Token: 0x0601C6EF RID: 116463
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPixelExtent_Shift_28(HandleRef pThis, IntPtr n);

		/// <summary>
		/// Shift by the given amount.
		/// </summary>
		// Token: 0x0601C6F0 RID: 116464 RVA: 0x0027EFB9 File Offset: 0x0027D1B9
		public void Shift(IntPtr n)
		{
			vtkPixelExtent.vtkPixelExtent_Shift_28(base.GetCppThis(), n);
		}

		// Token: 0x0601C6F1 RID: 116465
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPixelExtent_Shift_29(HandleRef pThis, int q, int n);

		/// <summary>
		/// Shift by the given amount in the given direction.
		/// </summary>
		// Token: 0x0601C6F2 RID: 116466 RVA: 0x0027EFC9 File Offset: 0x0027D1C9
		public void Shift(int q, int n)
		{
			vtkPixelExtent.vtkPixelExtent_Shift_29(base.GetCppThis(), q, n);
		}

		// Token: 0x0601C6F3 RID: 116467
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPixelExtent_Shift_30(IntPtr ij, int n);

		/// <summary>
		/// Shift by the given amount while respecting mode.
		/// </summary>
		// Token: 0x0601C6F4 RID: 116468 RVA: 0x0027EFDA File Offset: 0x0027D1DA
		public static void Shift(IntPtr ij, int n)
		{
			vtkPixelExtent.vtkPixelExtent_Shift_30(ij, n);
		}

		// Token: 0x0601C6F5 RID: 116469
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPixelExtent_Shift_31(IntPtr ij, IntPtr n);

		/// <summary>
		/// Shift by the given amount while respecting mode.
		/// </summary>
		// Token: 0x0601C6F6 RID: 116470 RVA: 0x0027EFE5 File Offset: 0x0027D1E5
		public static void Shift(IntPtr ij, IntPtr n)
		{
			vtkPixelExtent.vtkPixelExtent_Shift_31(ij, n);
		}

		// Token: 0x0601C6F7 RID: 116471
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPixelExtent_Shrink_32(HandleRef pThis, int n);

		/// <summary>
		/// Shrink the extent by n.
		/// </summary>
		// Token: 0x0601C6F8 RID: 116472 RVA: 0x0027EFF0 File Offset: 0x0027D1F0
		public void Shrink(int n)
		{
			vtkPixelExtent.vtkPixelExtent_Shrink_32(base.GetCppThis(), n);
		}

		// Token: 0x0601C6F9 RID: 116473
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPixelExtent_Shrink_33(HandleRef pThis, int q, int n);

		/// <summary>
		/// Shrink the extent by n.
		/// </summary>
		// Token: 0x0601C6FA RID: 116474 RVA: 0x0027F000 File Offset: 0x0027D200
		public void Shrink(int q, int n)
		{
			vtkPixelExtent.vtkPixelExtent_Shrink_33(base.GetCppThis(), q, n);
		}

		// Token: 0x0601C6FB RID: 116475
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkPixelExtent vtkPixelExtent_Shrink_34(vtkPixelExtent inputExt, vtkPixelExtent problemDomain, int n);

		/// <summary>
		/// Remove ghost cells. If a problem domain is
		/// provided the input is pinned at the domain.
		/// </summary>
		// Token: 0x0601C6FC RID: 116476 RVA: 0x0027F014 File Offset: 0x0027D214
		public static vtkPixelExtent Shrink(vtkPixelExtent inputExt, vtkPixelExtent problemDomain, int n)
		{
			return vtkPixelExtent.vtkPixelExtent_Shrink_34(inputExt, problemDomain, n);
		}

		// Token: 0x0601C6FD RID: 116477
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkPixelExtent vtkPixelExtent_Shrink_35(vtkPixelExtent inputExt, int n);

		/// <summary>
		/// Remove ghost cells. If a problem domain is
		/// provided the input is pinned at the domain.
		/// </summary>
		// Token: 0x0601C6FE RID: 116478 RVA: 0x0027F030 File Offset: 0x0027D230
		public static vtkPixelExtent Shrink(vtkPixelExtent inputExt, int n)
		{
			return vtkPixelExtent.vtkPixelExtent_Shrink_35(inputExt, n);
		}

		// Token: 0x0601C6FF RID: 116479
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkPixelExtent_Size_36(HandleRef pThis);

		/// <summary>
		/// Get the total number.
		/// </summary>
		// Token: 0x0601C700 RID: 116480 RVA: 0x0027F04C File Offset: 0x0027D24C
		public ulong Size()
		{
			return vtkPixelExtent.vtkPixelExtent_Size_36(base.GetCppThis());
		}

		// Token: 0x0601C701 RID: 116481
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkPixelExtent_Size_37(vtkPixelExtent ext);

		/// <summary>
		/// Get the total number.
		/// </summary>
		// Token: 0x0601C702 RID: 116482 RVA: 0x0027F06C File Offset: 0x0027D26C
		public static ulong Size(vtkPixelExtent ext)
		{
			return vtkPixelExtent.vtkPixelExtent_Size_37(ext);
		}

		// Token: 0x0601C703 RID: 116483
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkPixelExtent vtkPixelExtent_Split_38(HandleRef pThis, int dir);

		/// <summary>
		/// Divide the extent in half in the given direction. The
		/// operation is done in-place the other half of the split
		/// extent is returned. The return will be empty if the split
		/// could not be made.
		/// </summary>
		// Token: 0x0601C704 RID: 116484 RVA: 0x0027F088 File Offset: 0x0027D288
		public vtkPixelExtent Split(int dir)
		{
			return vtkPixelExtent.vtkPixelExtent_Split_38(base.GetCppThis(), dir);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E2D RID: 7725
		public new const string MRFullTypeName = "Kitware.VTK.vtkPixelExtent";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E2E RID: 7726
		public new static readonly string MRClassNameKey = "class vtkPixelExtent";
	}
}
