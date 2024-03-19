using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDataObjectCollection
	/// </summary>
	/// <remarks>
	///    maintain an unordered list of data objects
	///
	/// vtkDataObjectCollection is an object that creates and manipulates ordered
	/// lists of data objects. See also vtkCollection and subclasses.
	/// </remarks>
	// Token: 0x02000A39 RID: 2617
	public class vtkDataObjectCollection : vtkCollection
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601B448 RID: 111688 RVA: 0x0026190B File Offset: 0x0025FB0B
		static vtkDataObjectCollection()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataObjectCollection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataObjectCollection"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601B449 RID: 111689 RVA: 0x00261933 File Offset: 0x0025FB33
		public vtkDataObjectCollection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601B44A RID: 111690
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectCollection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B44B RID: 111691 RVA: 0x00261944 File Offset: 0x0025FB44
		public new static vtkDataObjectCollection New()
		{
			vtkDataObjectCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectCollection.vtkDataObjectCollection_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataObjectCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B44C RID: 111692 RVA: 0x00261998 File Offset: 0x0025FB98
		public vtkDataObjectCollection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDataObjectCollection.vtkDataObjectCollection_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601B44D RID: 111693 RVA: 0x002619DC File Offset: 0x0025FBDC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601B44E RID: 111694
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectCollection_AddItem_01(HandleRef pThis, HandleRef ds);

		/// <summary>
		/// Add a data object to the bottom of the list.
		/// </summary>
		// Token: 0x0601B44F RID: 111695 RVA: 0x002619E8 File Offset: 0x0025FBE8
		public void AddItem(vtkDataObject ds)
		{
			vtkDataObjectCollection.vtkDataObjectCollection_AddItem_01(base.GetCppThis(), (ds == null) ? default(HandleRef) : ds.GetCppThis());
		}

		// Token: 0x0601B450 RID: 111696
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectCollection_GetItem_02(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the ith data object in the list.
		/// </summary>
		// Token: 0x0601B451 RID: 111697 RVA: 0x00261A18 File Offset: 0x0025FC18
		public vtkDataObject GetItem(int i)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectCollection.vtkDataObjectCollection_GetItem_02(base.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		// Token: 0x0601B452 RID: 111698
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectCollection_GetNextItem_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the next data object in the list.
		/// </summary>
		// Token: 0x0601B453 RID: 111699 RVA: 0x00261A88 File Offset: 0x0025FC88
		public vtkDataObject GetNextItem()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectCollection.vtkDataObjectCollection_GetNextItem_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		// Token: 0x0601B454 RID: 111700
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataObjectCollection_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B455 RID: 111701 RVA: 0x00261AF8 File Offset: 0x0025FCF8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDataObjectCollection.vtkDataObjectCollection_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601B456 RID: 111702
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataObjectCollection_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B457 RID: 111703 RVA: 0x00261B18 File Offset: 0x0025FD18
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDataObjectCollection.vtkDataObjectCollection_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601B458 RID: 111704
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectCollection_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B459 RID: 111705 RVA: 0x00261B34 File Offset: 0x0025FD34
		public override int IsA(string type)
		{
			return vtkDataObjectCollection.vtkDataObjectCollection_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0601B45A RID: 111706
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectCollection_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B45B RID: 111707 RVA: 0x00261B54 File Offset: 0x0025FD54
		public new static int IsTypeOf(string type)
		{
			return vtkDataObjectCollection.vtkDataObjectCollection_IsTypeOf_07(type);
		}

		// Token: 0x0601B45C RID: 111708
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectCollection_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B45D RID: 111709 RVA: 0x00261B70 File Offset: 0x0025FD70
		public new vtkDataObjectCollection NewInstance()
		{
			vtkDataObjectCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectCollection.vtkDataObjectCollection_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataObjectCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601B45E RID: 111710
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectCollection_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B45F RID: 111711 RVA: 0x00261BCC File Offset: 0x0025FDCC
		public new static vtkDataObjectCollection SafeDownCast(vtkObjectBase o)
		{
			vtkDataObjectCollection vtkDataObjectCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectCollection.vtkDataObjectCollection_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObjectCollection = (vtkDataObjectCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObjectCollection.Register(null);
				}
			}
			return vtkDataObjectCollection;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D66 RID: 7526
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataObjectCollection";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D67 RID: 7527
		public new static readonly string MRClassNameKey = "class vtkDataObjectCollection";
	}
}
