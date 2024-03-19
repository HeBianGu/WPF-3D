using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDataSetCollection
	/// </summary>
	/// <remarks>
	///    maintain an unordered list of dataset objects
	///
	/// vtkDataSetCollection is an object that creates and manipulates ordered
	/// lists of datasets. See also vtkCollection and subclasses.
	/// </remarks>
	// Token: 0x02000A3F RID: 2623
	public class vtkDataSetCollection : vtkCollection
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601B50E RID: 111886 RVA: 0x00262F8B File Offset: 0x0026118B
		static vtkDataSetCollection()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataSetCollection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataSetCollection"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601B50F RID: 111887 RVA: 0x00262FB3 File Offset: 0x002611B3
		public vtkDataSetCollection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601B510 RID: 111888
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetCollection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B511 RID: 111889 RVA: 0x00262FC4 File Offset: 0x002611C4
		public new static vtkDataSetCollection New()
		{
			vtkDataSetCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetCollection.vtkDataSetCollection_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataSetCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B512 RID: 111890 RVA: 0x00263018 File Offset: 0x00261218
		public vtkDataSetCollection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDataSetCollection.vtkDataSetCollection_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601B513 RID: 111891 RVA: 0x0026305C File Offset: 0x0026125C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601B514 RID: 111892
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetCollection_AddItem_01(HandleRef pThis, HandleRef ds);

		/// <summary>
		/// Add a dataset to the bottom of the list.
		/// </summary>
		// Token: 0x0601B515 RID: 111893 RVA: 0x00263068 File Offset: 0x00261268
		public void AddItem(vtkDataSet ds)
		{
			vtkDataSetCollection.vtkDataSetCollection_AddItem_01(base.GetCppThis(), (ds == null) ? default(HandleRef) : ds.GetCppThis());
		}

		// Token: 0x0601B516 RID: 111894
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetCollection_GetDataSet_02(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the ith dataset in the list.
		/// </summary>
		// Token: 0x0601B517 RID: 111895 RVA: 0x00263098 File Offset: 0x00261298
		public vtkDataSet GetDataSet(int i)
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetCollection.vtkDataSetCollection_GetDataSet_02(base.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		// Token: 0x0601B518 RID: 111896
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetCollection_GetItem_03(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the ith dataset in the list.
		/// </summary>
		// Token: 0x0601B519 RID: 111897 RVA: 0x00263108 File Offset: 0x00261308
		public vtkDataSet GetItem(int i)
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetCollection.vtkDataSetCollection_GetItem_03(base.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		// Token: 0x0601B51A RID: 111898
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetCollection_GetNextDataSet_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the next dataset in the list.
		/// </summary>
		// Token: 0x0601B51B RID: 111899 RVA: 0x00263178 File Offset: 0x00261378
		public vtkDataSet GetNextDataSet()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetCollection.vtkDataSetCollection_GetNextDataSet_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		// Token: 0x0601B51C RID: 111900
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetCollection_GetNextItem_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the next dataset in the list.
		/// </summary>
		// Token: 0x0601B51D RID: 111901 RVA: 0x002631E8 File Offset: 0x002613E8
		public vtkDataSet GetNextItem()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetCollection.vtkDataSetCollection_GetNextItem_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		// Token: 0x0601B51E RID: 111902
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataSetCollection_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B51F RID: 111903 RVA: 0x00263258 File Offset: 0x00261458
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDataSetCollection.vtkDataSetCollection_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0601B520 RID: 111904
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataSetCollection_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B521 RID: 111905 RVA: 0x00263278 File Offset: 0x00261478
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDataSetCollection.vtkDataSetCollection_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0601B522 RID: 111906
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetCollection_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B523 RID: 111907 RVA: 0x00263294 File Offset: 0x00261494
		public override int IsA(string type)
		{
			return vtkDataSetCollection.vtkDataSetCollection_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0601B524 RID: 111908
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetCollection_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B525 RID: 111909 RVA: 0x002632B4 File Offset: 0x002614B4
		public new static int IsTypeOf(string type)
		{
			return vtkDataSetCollection.vtkDataSetCollection_IsTypeOf_09(type);
		}

		// Token: 0x0601B526 RID: 111910
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetCollection_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B527 RID: 111911 RVA: 0x002632D0 File Offset: 0x002614D0
		public new vtkDataSetCollection NewInstance()
		{
			vtkDataSetCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetCollection.vtkDataSetCollection_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataSetCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601B528 RID: 111912
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetCollection_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B529 RID: 111913 RVA: 0x0026332C File Offset: 0x0026152C
		public new static vtkDataSetCollection SafeDownCast(vtkObjectBase o)
		{
			vtkDataSetCollection vtkDataSetCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetCollection.vtkDataSetCollection_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSetCollection = (vtkDataSetCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSetCollection.Register(null);
				}
			}
			return vtkDataSetCollection;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D72 RID: 7538
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataSetCollection";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D73 RID: 7539
		public new static readonly string MRClassNameKey = "class vtkDataSetCollection";
	}
}
