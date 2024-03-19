using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCollectionIterator
	/// </summary>
	/// <remarks>
	///    iterator through a vtkCollection.
	///
	/// vtkCollectionIterator provides an alternative way to traverse
	/// through the objects in a vtkCollection.  Unlike the collection's
	/// built in interface, this allows multiple iterators to
	/// simultaneously traverse the collection.  If items are removed from
	/// the collection, only the iterators currently pointing to those
	/// items are invalidated.  Other iterators will still continue to
	/// function normally.
	/// </remarks>
	// Token: 0x02000B49 RID: 2889
	public class vtkCollectionIterator : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E32E RID: 123694 RVA: 0x002AB747 File Offset: 0x002A9947
		static vtkCollectionIterator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCollectionIterator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCollectionIterator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E32F RID: 123695 RVA: 0x002AB76F File Offset: 0x002A996F
		public vtkCollectionIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601E330 RID: 123696
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCollectionIterator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E331 RID: 123697 RVA: 0x002AB780 File Offset: 0x002A9980
		public new static vtkCollectionIterator New()
		{
			vtkCollectionIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCollectionIterator.vtkCollectionIterator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCollectionIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E332 RID: 123698 RVA: 0x002AB7D4 File Offset: 0x002A99D4
		public vtkCollectionIterator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCollectionIterator.vtkCollectionIterator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E333 RID: 123699 RVA: 0x002AB818 File Offset: 0x002A9A18
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E334 RID: 123700
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCollectionIterator_GetCollection_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the collection over which to iterate.
		/// </summary>
		// Token: 0x0601E335 RID: 123701 RVA: 0x002AB824 File Offset: 0x002A9A24
		public virtual vtkCollection GetCollection()
		{
			vtkCollection vtkCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCollectionIterator.vtkCollectionIterator_GetCollection_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601E336 RID: 123702
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCollectionIterator_GetCurrentObject_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the item at the current iterator position.  Valid only when
		/// IsDoneWithTraversal() returns 1.
		/// </summary>
		// Token: 0x0601E337 RID: 123703 RVA: 0x002AB894 File Offset: 0x002A9A94
		public vtkObject GetCurrentObject()
		{
			vtkObject vtkObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCollectionIterator.vtkCollectionIterator_GetCurrentObject_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601E338 RID: 123704
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCollectionIterator_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E339 RID: 123705 RVA: 0x002AB904 File Offset: 0x002A9B04
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCollectionIterator.vtkCollectionIterator_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0601E33A RID: 123706
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCollectionIterator_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E33B RID: 123707 RVA: 0x002AB924 File Offset: 0x002A9B24
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCollectionIterator.vtkCollectionIterator_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0601E33C RID: 123708
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollectionIterator_GoToFirstItem_05(HandleRef pThis);

		/// <summary>
		/// Position the iterator at the first item in the collection.
		/// </summary>
		// Token: 0x0601E33D RID: 123709 RVA: 0x002AB93E File Offset: 0x002A9B3E
		public void GoToFirstItem()
		{
			vtkCollectionIterator.vtkCollectionIterator_GoToFirstItem_05(base.GetCppThis());
		}

		// Token: 0x0601E33E RID: 123710
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollectionIterator_GoToNextItem_06(HandleRef pThis);

		/// <summary>
		/// Move the iterator to the next item in the collection.
		/// </summary>
		// Token: 0x0601E33F RID: 123711 RVA: 0x002AB94D File Offset: 0x002A9B4D
		public void GoToNextItem()
		{
			vtkCollectionIterator.vtkCollectionIterator_GoToNextItem_06(base.GetCppThis());
		}

		// Token: 0x0601E340 RID: 123712
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollectionIterator_InitTraversal_07(HandleRef pThis);

		/// <summary>
		/// Position the iterator at the first item in the collection.
		/// </summary>
		// Token: 0x0601E341 RID: 123713 RVA: 0x002AB95C File Offset: 0x002A9B5C
		public void InitTraversal()
		{
			vtkCollectionIterator.vtkCollectionIterator_InitTraversal_07(base.GetCppThis());
		}

		// Token: 0x0601E342 RID: 123714
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCollectionIterator_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E343 RID: 123715 RVA: 0x002AB96C File Offset: 0x002A9B6C
		public override int IsA(string type)
		{
			return vtkCollectionIterator.vtkCollectionIterator_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0601E344 RID: 123716
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCollectionIterator_IsDoneWithTraversal_09(HandleRef pThis);

		/// <summary>
		/// Test whether the iterator is currently positioned at a valid item.
		/// Returns 1 for yes, 0 for no.
		/// </summary>
		// Token: 0x0601E345 RID: 123717 RVA: 0x002AB98C File Offset: 0x002A9B8C
		public int IsDoneWithTraversal()
		{
			return vtkCollectionIterator.vtkCollectionIterator_IsDoneWithTraversal_09(base.GetCppThis());
		}

		// Token: 0x0601E346 RID: 123718
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCollectionIterator_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E347 RID: 123719 RVA: 0x002AB9AC File Offset: 0x002A9BAC
		public new static int IsTypeOf(string type)
		{
			return vtkCollectionIterator.vtkCollectionIterator_IsTypeOf_10(type);
		}

		// Token: 0x0601E348 RID: 123720
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCollectionIterator_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E349 RID: 123721 RVA: 0x002AB9C8 File Offset: 0x002A9BC8
		public new vtkCollectionIterator NewInstance()
		{
			vtkCollectionIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCollectionIterator.vtkCollectionIterator_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCollectionIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E34A RID: 123722
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCollectionIterator_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E34B RID: 123723 RVA: 0x002ABA24 File Offset: 0x002A9C24
		public new static vtkCollectionIterator SafeDownCast(vtkObjectBase o)
		{
			vtkCollectionIterator vtkCollectionIterator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCollectionIterator.vtkCollectionIterator_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601E34C RID: 123724
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollectionIterator_SetCollection_14(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the collection over which to iterate.
		/// </summary>
		// Token: 0x0601E34D RID: 123725 RVA: 0x002ABAA4 File Offset: 0x002A9CA4
		public virtual void SetCollection(vtkCollection arg0)
		{
			vtkCollectionIterator.vtkCollectionIterator_SetCollection_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FE5 RID: 8165
		public new const string MRFullTypeName = "Kitware.VTK.vtkCollectionIterator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FE6 RID: 8166
		public new static readonly string MRClassNameKey = "class vtkCollectionIterator";
	}
}
