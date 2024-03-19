using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAMRDataSetCache
	///
	///
	///  A concrete implementation of vtkObject that provides functionality for
	///  caching AMR blocks. The primary intent of this class is to be used by the
	///  AMR reader infrastructure for caching blocks/data in memory to minimize
	///  out-of-core operations.
	/// </summary>
	// Token: 0x02000225 RID: 549
	public class vtkAMRDataSetCache : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006761 RID: 26465 RVA: 0x000952E8 File Offset: 0x000934E8
		static vtkAMRDataSetCache()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAMRDataSetCache.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAMRDataSetCache"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006762 RID: 26466 RVA: 0x00095310 File Offset: 0x00093510
		public vtkAMRDataSetCache(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006763 RID: 26467
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRDataSetCache_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006764 RID: 26468 RVA: 0x00095320 File Offset: 0x00093520
		public new static vtkAMRDataSetCache New()
		{
			vtkAMRDataSetCache result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMRDataSetCache.vtkAMRDataSetCache_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAMRDataSetCache)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006765 RID: 26469 RVA: 0x00095374 File Offset: 0x00093574
		public vtkAMRDataSetCache() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAMRDataSetCache.vtkAMRDataSetCache_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006766 RID: 26470 RVA: 0x000953B8 File Offset: 0x000935B8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006767 RID: 26471
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRDataSetCache_GetAMRBlock_01(HandleRef pThis, int compositeIdx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Given the composite index, this method returns the AMR block.
		/// NOTE: Null is returned if the AMR block does not exist in the cache.
		/// </summary>
		// Token: 0x06006768 RID: 26472 RVA: 0x000953C4 File Offset: 0x000935C4
		public vtkUniformGrid GetAMRBlock(int compositeIdx)
		{
			vtkUniformGrid vtkUniformGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMRDataSetCache.vtkAMRDataSetCache_GetAMRBlock_01(base.GetCppThis(), compositeIdx, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUniformGrid = (vtkUniformGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUniformGrid.Register(null);
				}
			}
			return vtkUniformGrid;
		}

		// Token: 0x06006769 RID: 26473
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRDataSetCache_GetAMRBlockCellData_02(HandleRef pThis, int compositeIdx, [MarshalAs(UnmanagedType.LPUTF8Str)] string dataName, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Given the name of the cell array and AMR block composite index, this
		/// method returns a pointer to the cell data array.
		/// NOTE: Null is returned if the cell array and/or block is not cached.
		/// </summary>
		// Token: 0x0600676A RID: 26474 RVA: 0x00095434 File Offset: 0x00093634
		public vtkDataArray GetAMRBlockCellData(int compositeIdx, string dataName)
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMRDataSetCache.vtkAMRDataSetCache_GetAMRBlockCellData_02(base.GetCppThis(), compositeIdx, dataName, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		// Token: 0x0600676B RID: 26475
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRDataSetCache_GetAMRBlockPointData_03(HandleRef pThis, int compositeIdx, [MarshalAs(UnmanagedType.LPUTF8Str)] string dataName, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Given the name of the point array and AMR block composite index, this
		/// method returns a pointer to the point data array.
		/// NOTE: Null is returned if the point array and /or block is not cached.
		/// </summary>
		// Token: 0x0600676C RID: 26476 RVA: 0x000954A8 File Offset: 0x000936A8
		public vtkDataArray GetAMRBlockPointData(int compositeIdx, string dataName)
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMRDataSetCache.vtkAMRDataSetCache_GetAMRBlockPointData_03(base.GetCppThis(), compositeIdx, dataName, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		// Token: 0x0600676D RID: 26477
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAMRDataSetCache_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600676E RID: 26478 RVA: 0x0009551C File Offset: 0x0009371C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAMRDataSetCache.vtkAMRDataSetCache_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0600676F RID: 26479
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAMRDataSetCache_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006770 RID: 26480 RVA: 0x0009553C File Offset: 0x0009373C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAMRDataSetCache.vtkAMRDataSetCache_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06006771 RID: 26481
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAMRDataSetCache_HasAMRBlock_06(HandleRef pThis, int compositeIdx);

		/// <summary>
		/// Checks if the AMR block associated with the given composite is cached.
		/// </summary>
		// Token: 0x06006772 RID: 26482 RVA: 0x00095558 File Offset: 0x00093758
		public bool HasAMRBlock(int compositeIdx)
		{
			return vtkAMRDataSetCache.vtkAMRDataSetCache_HasAMRBlock_06(base.GetCppThis(), compositeIdx) != 0;
		}

		// Token: 0x06006773 RID: 26483
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAMRDataSetCache_HasAMRBlockCellData_07(HandleRef pThis, int compositeIdx, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Checks if the cell data array, associated with the provided name, has
		/// been cached for the AMR block with the given composite index.
		/// </summary>
		// Token: 0x06006774 RID: 26484 RVA: 0x00095580 File Offset: 0x00093780
		public bool HasAMRBlockCellData(int compositeIdx, string name)
		{
			return vtkAMRDataSetCache.vtkAMRDataSetCache_HasAMRBlockCellData_07(base.GetCppThis(), compositeIdx, name) != 0;
		}

		// Token: 0x06006775 RID: 26485
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAMRDataSetCache_HasAMRBlockPointData_08(HandleRef pThis, int compositeIdx, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Checks if the point data array, associated with the provided name, has
		/// been cached for the AMR block with the given composite index.
		/// </summary>
		// Token: 0x06006776 RID: 26486 RVA: 0x000955A8 File Offset: 0x000937A8
		public bool HasAMRBlockPointData(int compositeIdx, string name)
		{
			return vtkAMRDataSetCache.vtkAMRDataSetCache_HasAMRBlockPointData_08(base.GetCppThis(), compositeIdx, name) != 0;
		}

		// Token: 0x06006777 RID: 26487
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRDataSetCache_InsertAMRBlock_09(HandleRef pThis, int compositeIdx, HandleRef amrGrid);

		/// <summary>
		/// Inserts an AMR block to the cache
		/// </summary>
		// Token: 0x06006778 RID: 26488 RVA: 0x000955D0 File Offset: 0x000937D0
		public void InsertAMRBlock(int compositeIdx, vtkUniformGrid amrGrid)
		{
			vtkAMRDataSetCache.vtkAMRDataSetCache_InsertAMRBlock_09(base.GetCppThis(), compositeIdx, (amrGrid == null) ? default(HandleRef) : amrGrid.GetCppThis());
		}

		// Token: 0x06006779 RID: 26489
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRDataSetCache_InsertAMRBlockCellData_10(HandleRef pThis, int compositeIdx, HandleRef dataArray);

		/// <summary>
		/// Inserts a cell data array to an already cached block
		/// NOTE: this-&gt;HasAMRBlock( compositeIdx ) == true
		/// </summary>
		// Token: 0x0600677A RID: 26490 RVA: 0x00095600 File Offset: 0x00093800
		public void InsertAMRBlockCellData(int compositeIdx, vtkDataArray dataArray)
		{
			vtkAMRDataSetCache.vtkAMRDataSetCache_InsertAMRBlockCellData_10(base.GetCppThis(), compositeIdx, (dataArray == null) ? default(HandleRef) : dataArray.GetCppThis());
		}

		// Token: 0x0600677B RID: 26491
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRDataSetCache_InsertAMRBlockPointData_11(HandleRef pThis, int compositeIdx, HandleRef dataArray);

		/// <summary>
		/// Inserts a point data array to an already cached block
		/// NOTE: this-&gt;HasAMRBlock( compositeIdx ) == true
		/// </summary>
		// Token: 0x0600677C RID: 26492 RVA: 0x00095630 File Offset: 0x00093830
		public void InsertAMRBlockPointData(int compositeIdx, vtkDataArray dataArray)
		{
			vtkAMRDataSetCache.vtkAMRDataSetCache_InsertAMRBlockPointData_11(base.GetCppThis(), compositeIdx, (dataArray == null) ? default(HandleRef) : dataArray.GetCppThis());
		}

		// Token: 0x0600677D RID: 26493
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRDataSetCache_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600677E RID: 26494 RVA: 0x00095660 File Offset: 0x00093860
		public override int IsA(string type)
		{
			return vtkAMRDataSetCache.vtkAMRDataSetCache_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x0600677F RID: 26495
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRDataSetCache_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006780 RID: 26496 RVA: 0x00095680 File Offset: 0x00093880
		public new static int IsTypeOf(string type)
		{
			return vtkAMRDataSetCache.vtkAMRDataSetCache_IsTypeOf_13(type);
		}

		// Token: 0x06006781 RID: 26497
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRDataSetCache_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006782 RID: 26498 RVA: 0x0009569C File Offset: 0x0009389C
		public new vtkAMRDataSetCache NewInstance()
		{
			vtkAMRDataSetCache result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMRDataSetCache.vtkAMRDataSetCache_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAMRDataSetCache)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006783 RID: 26499
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRDataSetCache_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006784 RID: 26500 RVA: 0x000956F8 File Offset: 0x000938F8
		public new static vtkAMRDataSetCache SafeDownCast(vtkObjectBase o)
		{
			vtkAMRDataSetCache vtkAMRDataSetCache = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMRDataSetCache.vtkAMRDataSetCache_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAMRDataSetCache = (vtkAMRDataSetCache)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAMRDataSetCache.Register(null);
				}
			}
			return vtkAMRDataSetCache;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000931 RID: 2353
		public new const string MRFullTypeName = "Kitware.VTK.vtkAMRDataSetCache";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000932 RID: 2354
		public new static readonly string MRClassNameKey = "class vtkAMRDataSetCache";
	}
}
