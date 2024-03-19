using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkUnstructuredGridBase
	/// </summary>
	/// <remarks>
	///    dataset represents arbitrary combinations
	/// of all possible cell types. May be mapped onto a non-standard memory layout.
	///
	///
	/// vtkUnstructuredGridBase defines the core vtkUnstructuredGrid API, omitting
	/// functions that are implementation dependent.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkMappedDataArray vtkUnstructuredGrid
	/// </seealso>
	// Token: 0x020001B4 RID: 436
	public abstract class vtkUnstructuredGridBase : vtkPointSet
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060053F3 RID: 21491 RVA: 0x0007A31F File Offset: 0x0007851F
		static vtkUnstructuredGridBase()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUnstructuredGridBase.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGridBase"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060053F4 RID: 21492 RVA: 0x0007A347 File Offset: 0x00078547
		public vtkUnstructuredGridBase(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060053F5 RID: 21493 RVA: 0x0007A355 File Offset: 0x00078555
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060053F6 RID: 21494
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridBase_Allocate_01(HandleRef pThis, long numCells, int extSize);

		/// <summary>
		/// Allocate memory for the number of cells indicated. extSize is not used.
		/// </summary>
		// Token: 0x060053F7 RID: 21495 RVA: 0x0007A360 File Offset: 0x00078560
		public virtual void Allocate(long numCells, int extSize)
		{
			vtkUnstructuredGridBase.vtkUnstructuredGridBase_Allocate_01(base.GetCppThis(), numCells, extSize);
		}

		// Token: 0x060053F8 RID: 21496
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridBase_DeepCopy_02(HandleRef pThis, HandleRef src);

		/// <summary>
		/// Shallow and Deep copy.
		/// </summary>
		// Token: 0x060053F9 RID: 21497 RVA: 0x0007A374 File Offset: 0x00078574
		public override void DeepCopy(vtkDataObject src)
		{
			vtkUnstructuredGridBase.vtkUnstructuredGridBase_DeepCopy_02(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		// Token: 0x060053FA RID: 21498
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridBase_GetData_03(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x060053FB RID: 21499 RVA: 0x0007A3A4 File Offset: 0x000785A4
		public new static vtkUnstructuredGridBase GetData(vtkInformation info)
		{
			vtkUnstructuredGridBase vtkUnstructuredGridBase = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridBase.vtkUnstructuredGridBase_GetData_03((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGridBase = (vtkUnstructuredGridBase)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGridBase.Register(null);
				}
			}
			return vtkUnstructuredGridBase;
		}

		// Token: 0x060053FC RID: 21500
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridBase_GetData_04(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x060053FD RID: 21501 RVA: 0x0007A424 File Offset: 0x00078624
		public new static vtkUnstructuredGridBase GetData(vtkInformationVector v, int i)
		{
			vtkUnstructuredGridBase vtkUnstructuredGridBase = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridBase.vtkUnstructuredGridBase_GetData_04((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGridBase = (vtkUnstructuredGridBase)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGridBase.Register(null);
				}
			}
			return vtkUnstructuredGridBase;
		}

		// Token: 0x060053FE RID: 21502
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridBase_GetDataObjectType_05(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060053FF RID: 21503 RVA: 0x0007A4A4 File Offset: 0x000786A4
		public override int GetDataObjectType()
		{
			return vtkUnstructuredGridBase.vtkUnstructuredGridBase_GetDataObjectType_05(base.GetCppThis());
		}

		// Token: 0x06005400 RID: 21504
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridBase_GetIdsOfCellsOfType_06(HandleRef pThis, int type, HandleRef array);

		/// <summary>
		/// Fill vtkIdTypeArray container with list of cell Ids.  This
		/// method traverses all cells and, for a particular cell type,
		/// inserts the cell Id into the container.
		/// </summary>
		// Token: 0x06005401 RID: 21505 RVA: 0x0007A4C4 File Offset: 0x000786C4
		public virtual void GetIdsOfCellsOfType(int type, vtkIdTypeArray array)
		{
			vtkUnstructuredGridBase.vtkUnstructuredGridBase_GetIdsOfCellsOfType_06(base.GetCppThis(), type, (array == null) ? default(HandleRef) : array.GetCppThis());
		}

		// Token: 0x06005402 RID: 21506
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridBase_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005403 RID: 21507 RVA: 0x0007A4F4 File Offset: 0x000786F4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkUnstructuredGridBase.vtkUnstructuredGridBase_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x06005404 RID: 21508
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridBase_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005405 RID: 21509 RVA: 0x0007A514 File Offset: 0x00078714
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkUnstructuredGridBase.vtkUnstructuredGridBase_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x06005406 RID: 21510
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridBase_InsertNextCell_09(HandleRef pThis, int type, long npts, IntPtr ptIds);

		/// <summary>
		/// Insert/create cell in object by type and list of point ids defining
		/// cell topology. Most cells require just a type which implicitly defines
		/// a set of points and their ordering. For non-polyhedron cell type, npts
		/// is the number of unique points in the cell. pts are the list of global
		/// point Ids. For polyhedron cell, a special input format is required.
		/// npts is the number of faces in the cell. ptIds is the list of face stream:
		/// (numFace0Pts, id1, id2, id3, numFace1Pts,id1, id2, id3, ...)
		/// Make sure you have called Allocate() before calling this method
		/// </summary>
		// Token: 0x06005407 RID: 21511 RVA: 0x0007A530 File Offset: 0x00078730
		public long InsertNextCell(int type, long npts, IntPtr ptIds)
		{
			return vtkUnstructuredGridBase.vtkUnstructuredGridBase_InsertNextCell_09(base.GetCppThis(), type, npts, ptIds);
		}

		// Token: 0x06005408 RID: 21512
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridBase_InsertNextCell_10(HandleRef pThis, int type, HandleRef ptIds);

		/// <summary>
		/// Insert/create cell in object by a list of point ids defining
		/// cell topology. Most cells require just a type which implicitly defines
		/// a set of points and their ordering. For non-polyhedron cell type, ptIds
		/// is the list of global Ids of unique cell points. For polyhedron cell,
		/// a special ptIds input format is required:
		/// (numCellFaces, numFace0Pts, id1, id2, id3, numFace1Pts,id1, id2, id3, ...)
		/// Make sure you have called Allocate() before calling this method
		/// </summary>
		// Token: 0x06005409 RID: 21513 RVA: 0x0007A554 File Offset: 0x00078754
		public long InsertNextCell(int type, vtkIdList ptIds)
		{
			return vtkUnstructuredGridBase.vtkUnstructuredGridBase_InsertNextCell_10(base.GetCppThis(), type, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		// Token: 0x0600540A RID: 21514
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridBase_InsertNextCell_11(HandleRef pThis, int type, long npts, IntPtr ptIds, long nfaces, IntPtr faces);

		/// <summary>
		/// Insert/create cell in object by a list of point ids defining
		/// cell topology. Most cells require just a type which implicitly defines
		/// a set of points and their ordering. For non-polyhedron cell type, ptIds
		/// is the list of global Ids of unique cell points. For polyhedron cell,
		/// a special ptIds input format is required:
		/// (numCellFaces, numFace0Pts, id1, id2, id3, numFace1Pts,id1, id2, id3, ...)
		/// Make sure you have called Allocate() before calling this method
		/// </summary>
		// Token: 0x0600540B RID: 21515 RVA: 0x0007A58C File Offset: 0x0007878C
		public long InsertNextCell(int type, long npts, IntPtr ptIds, long nfaces, IntPtr faces)
		{
			return vtkUnstructuredGridBase.vtkUnstructuredGridBase_InsertNextCell_11(base.GetCppThis(), type, npts, ptIds, nfaces, faces);
		}

		// Token: 0x0600540C RID: 21516
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridBase_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600540D RID: 21517 RVA: 0x0007A5B4 File Offset: 0x000787B4
		public override int IsA(string type)
		{
			return vtkUnstructuredGridBase.vtkUnstructuredGridBase_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x0600540E RID: 21518
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridBase_IsHomogeneous_13(HandleRef pThis);

		/// <summary>
		/// Traverse cells and determine if cells are all of the same type.
		/// </summary>
		// Token: 0x0600540F RID: 21519 RVA: 0x0007A5D4 File Offset: 0x000787D4
		public virtual int IsHomogeneous()
		{
			return vtkUnstructuredGridBase.vtkUnstructuredGridBase_IsHomogeneous_13(base.GetCppThis());
		}

		// Token: 0x06005410 RID: 21520
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridBase_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005411 RID: 21521 RVA: 0x0007A5F4 File Offset: 0x000787F4
		public new static int IsTypeOf(string type)
		{
			return vtkUnstructuredGridBase.vtkUnstructuredGridBase_IsTypeOf_14(type);
		}

		// Token: 0x06005412 RID: 21522
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridBase_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005413 RID: 21523 RVA: 0x0007A610 File Offset: 0x00078810
		public new vtkUnstructuredGridBase NewInstance()
		{
			vtkUnstructuredGridBase result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridBase.vtkUnstructuredGridBase_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridBase)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06005414 RID: 21524
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridBase_ReplaceCell_16(HandleRef pThis, long cellId, int npts, IntPtr pts);

		/// <summary>
		/// Replace the points defining cell "cellId" with a new set of points. This
		/// operator is (typically) used when links from points to cells have not been
		/// built (i.e., BuildLinks() has not been executed). Use the operator
		/// ReplaceLinkedCell() to replace a cell when cell structure has been built.
		/// </summary>
		// Token: 0x06005415 RID: 21525 RVA: 0x0007A66A File Offset: 0x0007886A
		public void ReplaceCell(long cellId, int npts, IntPtr pts)
		{
			vtkUnstructuredGridBase.vtkUnstructuredGridBase_ReplaceCell_16(base.GetCppThis(), cellId, npts, pts);
		}

		// Token: 0x06005416 RID: 21526
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridBase_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005417 RID: 21527 RVA: 0x0007A67C File Offset: 0x0007887C
		public new static vtkUnstructuredGridBase SafeDownCast(vtkObjectBase o)
		{
			vtkUnstructuredGridBase vtkUnstructuredGridBase = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridBase.vtkUnstructuredGridBase_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGridBase = (vtkUnstructuredGridBase)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGridBase.Register(null);
				}
			}
			return vtkUnstructuredGridBase;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040007D5 RID: 2005
		public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGridBase";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040007D6 RID: 2006
		public new static readonly string MRClassNameKey = "class vtkUnstructuredGridBase";
	}
}
