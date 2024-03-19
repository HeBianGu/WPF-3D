using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCellLinks
	/// </summary>
	/// <remarks>
	///    object represents upward pointers from points to list of cells using each point
	///
	/// vtkCellLinks is a supplemental object to vtkCellArray and vtkCellTypes,
	/// enabling access from points to the cells using the points. vtkCellLinks is
	/// a list of cell ids, each such link representing a dynamic list of cell ids
	/// using the point. The information provided by this object can be used to
	/// determine neighbors and construct other local topological information.
	///
	/// @warning
	/// vtkCellLinks supports incremental (i.e., "editable") operations such as
	/// inserting a new cell, or deleting a point. Because of this, it is less
	/// memory efficient, and slower to construct and delete than static classes
	/// such as vtkStaticCellLinks or vtkStaticCellLinksTemplate. However these
	/// other classes are typically meant for one-time (static) construction.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkCellArray vtkCellTypes vtkStaticCellLinks vtkStaticCellLinksTemplate
	/// </seealso>
	// Token: 0x02000A27 RID: 2599
	public class vtkCellLinks : vtkAbstractCellLinks
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601B129 RID: 110889 RVA: 0x0025CA23 File Offset: 0x0025AC23
		static vtkCellLinks()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellLinks.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellLinks"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601B12A RID: 110890 RVA: 0x0025CA4B File Offset: 0x0025AC4B
		public vtkCellLinks(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601B12B RID: 110891
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellLinks_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods to instantiate, print, and obtain type information.
		/// </summary>
		// Token: 0x0601B12C RID: 110892 RVA: 0x0025CA5C File Offset: 0x0025AC5C
		public new static vtkCellLinks New()
		{
			vtkCellLinks result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellLinks.vtkCellLinks_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellLinks)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods to instantiate, print, and obtain type information.
		/// </summary>
		// Token: 0x0601B12D RID: 110893 RVA: 0x0025CAB0 File Offset: 0x0025ACB0
		public vtkCellLinks() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCellLinks.vtkCellLinks_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601B12E RID: 110894 RVA: 0x0025CAF4 File Offset: 0x0025ACF4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601B12F RID: 110895
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellLinks_AddCellReference_01(HandleRef pThis, long cellId, long ptId);

		/// <summary>
		/// Add the reference to the cell (cellId) from the point (ptId). This
		/// adds a reference to the cellId from the cell list, but does not resize
		/// the list (extend memory with ResizeCellList(), if necessary).
		/// </summary>
		// Token: 0x0601B130 RID: 110896 RVA: 0x0025CAFF File Offset: 0x0025ACFF
		public void AddCellReference(long cellId, long ptId)
		{
			vtkCellLinks.vtkCellLinks_AddCellReference_01(base.GetCppThis(), cellId, ptId);
		}

		// Token: 0x0601B131 RID: 110897
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellLinks_Allocate_02(HandleRef pThis, long numLinks, long ext);

		/// <summary>
		/// Allocate the specified number of links (i.e., number of points) that
		/// will be built.
		/// </summary>
		// Token: 0x0601B132 RID: 110898 RVA: 0x0025CB10 File Offset: 0x0025AD10
		public void Allocate(long numLinks, long ext)
		{
			vtkCellLinks.vtkCellLinks_Allocate_02(base.GetCppThis(), numLinks, ext);
		}

		// Token: 0x0601B133 RID: 110899
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellLinks_BuildLinks_03(HandleRef pThis);

		/// <summary>
		/// Build the link list array from the input dataset.
		/// </summary>
		// Token: 0x0601B134 RID: 110900 RVA: 0x0025CB21 File Offset: 0x0025AD21
		public override void BuildLinks()
		{
			vtkCellLinks.vtkCellLinks_BuildLinks_03(base.GetCppThis());
		}

		// Token: 0x0601B135 RID: 110901
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellLinks_DeepCopy_04(HandleRef pThis, HandleRef src);

		/// <summary>
		/// Standard DeepCopy method.  Since this object contains no reference
		/// to other objects, there is no ShallowCopy.
		/// </summary>
		// Token: 0x0601B136 RID: 110902 RVA: 0x0025CB30 File Offset: 0x0025AD30
		public override void DeepCopy(vtkAbstractCellLinks src)
		{
			vtkCellLinks.vtkCellLinks_DeepCopy_04(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		// Token: 0x0601B137 RID: 110903
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellLinks_DeletePoint_05(HandleRef pThis, long ptId);

		/// <summary>
		/// Delete point (and storage) by destroying links to using cells.
		/// </summary>
		// Token: 0x0601B138 RID: 110904 RVA: 0x0025CB5F File Offset: 0x0025AD5F
		public void DeletePoint(long ptId)
		{
			vtkCellLinks.vtkCellLinks_DeletePoint_05(base.GetCppThis(), ptId);
		}

		// Token: 0x0601B139 RID: 110905
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkCellLinks_GetActualMemorySize_06(HandleRef pThis);

		/// <summary>
		/// Return the memory in kibibytes (1024 bytes) consumed by this cell links array.
		/// Used to support streaming and reading/writing data. The value
		/// returned is guaranteed to be greater than or equal to the memory
		/// required to actually represent the data represented by this object.
		/// The information returned is valid only after the pipeline has
		/// been updated.
		/// </summary>
		// Token: 0x0601B13A RID: 110906 RVA: 0x0025CB70 File Offset: 0x0025AD70
		public override uint GetActualMemorySize()
		{
			return vtkCellLinks.vtkCellLinks_GetActualMemorySize_06(base.GetCppThis());
		}

		// Token: 0x0601B13B RID: 110907
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellLinks_GetCells_07(HandleRef pThis, long ptId);

		/// <summary>
		/// Return a list of cell ids using the point.
		/// </summary>
		// Token: 0x0601B13C RID: 110908 RVA: 0x0025CB90 File Offset: 0x0025AD90
		public IntPtr GetCells(long ptId)
		{
			return vtkCellLinks.vtkCellLinks_GetCells_07(base.GetCppThis(), ptId);
		}

		// Token: 0x0601B13D RID: 110909
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellLinks_GetNcells_08(HandleRef pThis, long ptId);

		/// <summary>
		/// Get the number of cells using the point specified by ptId.
		/// </summary>
		// Token: 0x0601B13E RID: 110910 RVA: 0x0025CBB0 File Offset: 0x0025ADB0
		public long GetNcells(long ptId)
		{
			return vtkCellLinks.vtkCellLinks_GetNcells_08(base.GetCppThis(), ptId);
		}

		// Token: 0x0601B13F RID: 110911
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellLinks_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to instantiate, print, and obtain type information.
		/// </summary>
		// Token: 0x0601B140 RID: 110912 RVA: 0x0025CBD0 File Offset: 0x0025ADD0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCellLinks.vtkCellLinks_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x0601B141 RID: 110913
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellLinks_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to instantiate, print, and obtain type information.
		/// </summary>
		// Token: 0x0601B142 RID: 110914 RVA: 0x0025CBF0 File Offset: 0x0025ADF0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCellLinks.vtkCellLinks_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x0601B143 RID: 110915
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellLinks_Initialize_11(HandleRef pThis);

		/// <summary>
		/// Clear out any previously allocated data structures
		/// </summary>
		// Token: 0x0601B144 RID: 110916 RVA: 0x0025CC0A File Offset: 0x0025AE0A
		public override void Initialize()
		{
			vtkCellLinks.vtkCellLinks_Initialize_11(base.GetCppThis());
		}

		// Token: 0x0601B145 RID: 110917
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellLinks_InsertNextCellReference_12(HandleRef pThis, long ptId, long cellId);

		/// <summary>
		/// Insert a cell id into the list of cells (at the end) using the cell id
		/// provided. (Make sure to extend the link list (if necessary) using the
		/// method ResizeCellList().)
		/// </summary>
		// Token: 0x0601B146 RID: 110918 RVA: 0x0025CC19 File Offset: 0x0025AE19
		public void InsertNextCellReference(long ptId, long cellId)
		{
			vtkCellLinks.vtkCellLinks_InsertNextCellReference_12(base.GetCppThis(), ptId, cellId);
		}

		// Token: 0x0601B147 RID: 110919
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellLinks_InsertNextPoint_13(HandleRef pThis, int numLinks);

		/// <summary>
		/// Insert a new point into the cell-links data structure. The size parameter
		/// is the initial size of the list.
		/// </summary>
		// Token: 0x0601B148 RID: 110920 RVA: 0x0025CC2C File Offset: 0x0025AE2C
		public long InsertNextPoint(int numLinks)
		{
			return vtkCellLinks.vtkCellLinks_InsertNextPoint_13(base.GetCppThis(), numLinks);
		}

		// Token: 0x0601B149 RID: 110921
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellLinks_IsA_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to instantiate, print, and obtain type information.
		/// </summary>
		// Token: 0x0601B14A RID: 110922 RVA: 0x0025CC4C File Offset: 0x0025AE4C
		public override int IsA(string type)
		{
			return vtkCellLinks.vtkCellLinks_IsA_14(base.GetCppThis(), type);
		}

		// Token: 0x0601B14B RID: 110923
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellLinks_IsTypeOf_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to instantiate, print, and obtain type information.
		/// </summary>
		// Token: 0x0601B14C RID: 110924 RVA: 0x0025CC6C File Offset: 0x0025AE6C
		public new static int IsTypeOf(string type)
		{
			return vtkCellLinks.vtkCellLinks_IsTypeOf_15(type);
		}

		// Token: 0x0601B14D RID: 110925
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellLinks_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods to instantiate, print, and obtain type information.
		/// </summary>
		// Token: 0x0601B14E RID: 110926 RVA: 0x0025CC88 File Offset: 0x0025AE88
		public new vtkCellLinks NewInstance()
		{
			vtkCellLinks result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellLinks.vtkCellLinks_NewInstance_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellLinks)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601B14F RID: 110927
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellLinks_RemoveCellReference_18(HandleRef pThis, long cellId, long ptId);

		/// <summary>
		/// Delete the reference to the cell (cellId) from the point (ptId). This
		/// removes the reference to the cellId from the cell list, but does not
		/// resize the list (recover memory with ResizeCellList(), if necessary).
		/// </summary>
		// Token: 0x0601B150 RID: 110928 RVA: 0x0025CCE2 File Offset: 0x0025AEE2
		public void RemoveCellReference(long cellId, long ptId)
		{
			vtkCellLinks.vtkCellLinks_RemoveCellReference_18(base.GetCppThis(), cellId, ptId);
		}

		// Token: 0x0601B151 RID: 110929
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellLinks_Reset_19(HandleRef pThis);

		/// <summary>
		/// Reset to a state of no entries without freeing the memory.
		/// </summary>
		// Token: 0x0601B152 RID: 110930 RVA: 0x0025CCF3 File Offset: 0x0025AEF3
		public override void Reset()
		{
			vtkCellLinks.vtkCellLinks_Reset_19(base.GetCppThis());
		}

		// Token: 0x0601B153 RID: 110931
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellLinks_ResizeCellList_20(HandleRef pThis, long ptId, int size);

		/// <summary>
		/// Change the length of a point's link list (i.e., list of cells using a
		/// point) by the size specified.
		/// </summary>
		// Token: 0x0601B154 RID: 110932 RVA: 0x0025CD02 File Offset: 0x0025AF02
		public void ResizeCellList(long ptId, int size)
		{
			vtkCellLinks.vtkCellLinks_ResizeCellList_20(base.GetCppThis(), ptId, size);
		}

		// Token: 0x0601B155 RID: 110933
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellLinks_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods to instantiate, print, and obtain type information.
		/// </summary>
		// Token: 0x0601B156 RID: 110934 RVA: 0x0025CD14 File Offset: 0x0025AF14
		public new static vtkCellLinks SafeDownCast(vtkObjectBase o)
		{
			vtkCellLinks vtkCellLinks = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellLinks.vtkCellLinks_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellLinks = (vtkCellLinks)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellLinks.Register(null);
				}
			}
			return vtkCellLinks;
		}

		// Token: 0x0601B157 RID: 110935
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellLinks_SelectCells_22(HandleRef pThis, IntPtr minMaxDegree, IntPtr cellSelection);

		/// <summary>
		/// Select all cells with a point degree in the range [minDegree,maxDegree).
		/// The degree is the number of cells using a point. The selection is
		/// indicated through the provided unsigned char array, with a non-zero
		/// value indicates selection. The memory allocated for cellSelection must
		/// be the maximum cell id referenced in the links.
		/// </summary>
		// Token: 0x0601B158 RID: 110936 RVA: 0x0025CD93 File Offset: 0x0025AF93
		public override void SelectCells(IntPtr minMaxDegree, IntPtr cellSelection)
		{
			vtkCellLinks.vtkCellLinks_SelectCells_22(base.GetCppThis(), minMaxDegree, cellSelection);
		}

		// Token: 0x0601B159 RID: 110937
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellLinks_Squeeze_23(HandleRef pThis);

		/// <summary>
		/// Reclaim any unused memory.
		/// </summary>
		// Token: 0x0601B15A RID: 110938 RVA: 0x0025CDA4 File Offset: 0x0025AFA4
		public override void Squeeze()
		{
			vtkCellLinks.vtkCellLinks_Squeeze_23(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D41 RID: 7489
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellLinks";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D42 RID: 7490
		public new static readonly string MRClassNameKey = "class vtkCellLinks";
	}
}
