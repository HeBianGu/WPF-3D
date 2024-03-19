using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCollection
	/// </summary>
	/// <remarks>
	///    create and manipulate ordered lists of objects
	///
	/// vtkCollection is a general object for creating and manipulating lists
	/// of objects. The lists are ordered and allow duplicate entries.
	/// vtkCollection also serves as a base class for lists of specific types
	/// of objects.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkActorCollection vtkAssemblyPaths vtkDataSetCollection
	/// vtkImplicitFunctionCollection vtkLightCollection vtkPolyDataCollection
	/// vtkRenderWindowCollection vtkRendererCollection
	/// vtkStructuredPointsCollection vtkTransformCollection vtkVolumeCollection
	/// </seealso>
	// Token: 0x02000111 RID: 273
	public class vtkCollection : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060037D0 RID: 14288 RVA: 0x0005156B File Offset: 0x0004F76B
		static vtkCollection()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCollection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCollection"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060037D1 RID: 14289 RVA: 0x00051593 File Offset: 0x0004F793
		public vtkCollection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060037D2 RID: 14290
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCollection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct with empty list.
		/// </summary>
		// Token: 0x060037D3 RID: 14291 RVA: 0x000515A4 File Offset: 0x0004F7A4
		public new static vtkCollection New()
		{
			vtkCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCollection.vtkCollection_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct with empty list.
		/// </summary>
		// Token: 0x060037D4 RID: 14292 RVA: 0x000515F8 File Offset: 0x0004F7F8
		public vtkCollection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCollection.vtkCollection_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060037D5 RID: 14293 RVA: 0x0005163C File Offset: 0x0004F83C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060037D6 RID: 14294
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollection_AddItem_01(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Add an object to the bottom of the list. Does not prevent duplicate entries.
		/// </summary>
		// Token: 0x060037D7 RID: 14295 RVA: 0x00051648 File Offset: 0x0004F848
		public void AddItem(vtkObject arg0)
		{
			vtkCollection.vtkCollection_AddItem_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060037D8 RID: 14296
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCollection_GetItemAsObject_02(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the i'th item in the collection. nullptr is returned if i is out
		/// of range
		/// </summary>
		// Token: 0x060037D9 RID: 14297 RVA: 0x00051678 File Offset: 0x0004F878
		public vtkObject GetItemAsObject(int i)
		{
			vtkObject vtkObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCollection.vtkCollection_GetItemAsObject_02(base.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkObject = (vtkObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkObject.Register(null);
				}
			}
			return vtkObject;
		}

		// Token: 0x060037DA RID: 14298
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCollection_GetNextItemAsObject_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the next item in the collection. nullptr is returned if the collection
		/// is exhausted.
		/// </summary>
		// Token: 0x060037DB RID: 14299 RVA: 0x000516E8 File Offset: 0x0004F8E8
		public vtkObject GetNextItemAsObject()
		{
			vtkObject vtkObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCollection.vtkCollection_GetNextItemAsObject_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkObject = (vtkObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkObject.Register(null);
				}
			}
			return vtkObject;
		}

		// Token: 0x060037DC RID: 14300
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCollection_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060037DD RID: 14301 RVA: 0x00051758 File Offset: 0x0004F958
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCollection.vtkCollection_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x060037DE RID: 14302
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCollection_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060037DF RID: 14303 RVA: 0x00051778 File Offset: 0x0004F978
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCollection.vtkCollection_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x060037E0 RID: 14304
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCollection_GetNumberOfItems_06(HandleRef pThis);

		/// <summary>
		/// Return the number of objects in the list.
		/// </summary>
		// Token: 0x060037E1 RID: 14305 RVA: 0x00051794 File Offset: 0x0004F994
		public int GetNumberOfItems()
		{
			return vtkCollection.vtkCollection_GetNumberOfItems_06(base.GetCppThis());
		}

		// Token: 0x060037E2 RID: 14306
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCollection_IndexOfFirstOccurence_07(HandleRef pThis, HandleRef a);

		/// <summary>
		/// Search for an object and return location in list. If the return value is
		/// -1, the object was not found. If the object was found, the location is
		/// at the returned (0-based) index.
		/// </summary>
		// Token: 0x060037E3 RID: 14307 RVA: 0x000517B4 File Offset: 0x0004F9B4
		public int IndexOfFirstOccurence(vtkObject a)
		{
			return vtkCollection.vtkCollection_IndexOfFirstOccurence_07(base.GetCppThis(), (a == null) ? default(HandleRef) : a.GetCppThis());
		}

		// Token: 0x060037E4 RID: 14308
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollection_InitTraversal_08(HandleRef pThis);

		/// <summary>
		/// Initialize the traversal of the collection. This means the data pointer
		/// is set at the beginning of the list.
		/// </summary>
		// Token: 0x060037E5 RID: 14309 RVA: 0x000517E8 File Offset: 0x0004F9E8
		public void InitTraversal()
		{
			vtkCollection.vtkCollection_InitTraversal_08(base.GetCppThis());
		}

		// Token: 0x060037E6 RID: 14310
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollection_InsertItem_09(HandleRef pThis, int i, HandleRef arg1);

		/// <summary>
		/// Insert item into the list after the i'th item. Does not prevent duplicate entries.
		/// If i &lt; 0 the item is placed at the top of the list.
		/// </summary>
		// Token: 0x060037E7 RID: 14311 RVA: 0x000517F8 File Offset: 0x0004F9F8
		public void InsertItem(int i, vtkObject arg1)
		{
			vtkCollection.vtkCollection_InsertItem_09(base.GetCppThis(), i, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x060037E8 RID: 14312
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCollection_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060037E9 RID: 14313 RVA: 0x00051828 File Offset: 0x0004FA28
		public override int IsA(string type)
		{
			return vtkCollection.vtkCollection_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x060037EA RID: 14314
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCollection_IsItemPresent_11(HandleRef pThis, HandleRef a);

		/// <summary>
		/// Search for an object and return location in list. If the return value is
		/// 0, the object was not found. If the object was found, the location is
		/// the return value-1.
		/// </summary>
		// Token: 0x060037EB RID: 14315 RVA: 0x00051848 File Offset: 0x0004FA48
		public int IsItemPresent(vtkObject a)
		{
			return vtkCollection.vtkCollection_IsItemPresent_11(base.GetCppThis(), (a == null) ? default(HandleRef) : a.GetCppThis());
		}

		// Token: 0x060037EC RID: 14316
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCollection_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060037ED RID: 14317 RVA: 0x0005187C File Offset: 0x0004FA7C
		public new static int IsTypeOf(string type)
		{
			return vtkCollection.vtkCollection_IsTypeOf_12(type);
		}

		// Token: 0x060037EE RID: 14318
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCollection_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060037EF RID: 14319 RVA: 0x00051898 File Offset: 0x0004FA98
		public new vtkCollection NewInstance()
		{
			vtkCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCollection.vtkCollection_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060037F0 RID: 14320
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCollection_NewIterator_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get an iterator to traverse the objects in this collection.
		/// </summary>
		// Token: 0x060037F1 RID: 14321 RVA: 0x000518F4 File Offset: 0x0004FAF4
		public vtkCollectionIterator NewIterator()
		{
			vtkCollectionIterator vtkCollectionIterator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCollection.vtkCollection_NewIterator_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCollectionIterator = (vtkCollectionIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCollectionIterator.Register(null);
				}
			}
			return vtkCollectionIterator;
		}

		// Token: 0x060037F2 RID: 14322
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollection_RemoveAllItems_16(HandleRef pThis);

		/// <summary>
		/// Remove all objects from the list.
		/// </summary>
		// Token: 0x060037F3 RID: 14323 RVA: 0x00051963 File Offset: 0x0004FB63
		public void RemoveAllItems()
		{
			vtkCollection.vtkCollection_RemoveAllItems_16(base.GetCppThis());
		}

		// Token: 0x060037F4 RID: 14324
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollection_RemoveItem_17(HandleRef pThis, int i);

		/// <summary>
		/// Remove the i'th item in the list.
		/// Be careful if using this function during traversal of the list using
		/// GetNextItemAsObject (or GetNextItem in derived class).  The list WILL
		/// be shortened if a valid index is given!  If this-&gt;Current is equal to the
		/// element being removed, have it point to then next element in the list.
		/// </summary>
		// Token: 0x060037F5 RID: 14325 RVA: 0x00051972 File Offset: 0x0004FB72
		public void RemoveItem(int i)
		{
			vtkCollection.vtkCollection_RemoveItem_17(base.GetCppThis(), i);
		}

		// Token: 0x060037F6 RID: 14326
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollection_RemoveItem_18(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Remove an object from the list. Removes the first object found, not
		/// all occurrences. If no object found, list is unaffected.  See warning
		/// in description of RemoveItem(int).
		/// </summary>
		// Token: 0x060037F7 RID: 14327 RVA: 0x00051984 File Offset: 0x0004FB84
		public void RemoveItem(vtkObject arg0)
		{
			vtkCollection.vtkCollection_RemoveItem_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060037F8 RID: 14328
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollection_ReplaceItem_19(HandleRef pThis, int i, HandleRef arg1);

		/// <summary>
		/// Replace the i'th item in the collection with another item.
		/// </summary>
		// Token: 0x060037F9 RID: 14329 RVA: 0x000519B4 File Offset: 0x0004FBB4
		public void ReplaceItem(int i, vtkObject arg1)
		{
			vtkCollection.vtkCollection_ReplaceItem_19(base.GetCppThis(), i, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x060037FA RID: 14330
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCollection_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060037FB RID: 14331 RVA: 0x000519E4 File Offset: 0x0004FBE4
		public new static vtkCollection SafeDownCast(vtkObjectBase o)
		{
			vtkCollection vtkCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCollection.vtkCollection_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCollection = (vtkCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCollection.Register(null);
				}
			}
			return vtkCollection;
		}

		// Token: 0x060037FC RID: 14332
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCollection_UsesGarbageCollector_21(HandleRef pThis);

		/// <summary>
		/// Participate in garbage collection.
		/// </summary>
		// Token: 0x060037FD RID: 14333 RVA: 0x00051A64 File Offset: 0x0004FC64
		public override bool UsesGarbageCollector()
		{
			return vtkCollection.vtkCollection_UsesGarbageCollector_21(base.GetCppThis()) != 0;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400065A RID: 1626
		public new const string MRFullTypeName = "Kitware.VTK.vtkCollection";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400065B RID: 1627
		public new static readonly string MRClassNameKey = "class vtkCollection";
	}
}
