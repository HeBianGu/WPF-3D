using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAbstractContextItem
	/// </summary>
	/// <remarks>
	///    base class for items that are part of a
	/// vtkContextScene.
	///
	///
	/// This class is the common base for all context scene items. You should
	/// generally derive from vtkContextItem, rather than this class, as it provides
	/// most of the commonly used API.
	/// </remarks>
	// Token: 0x02000060 RID: 96
	public class vtkAbstractContextItem : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06001156 RID: 4438 RVA: 0x0001EF94 File Offset: 0x0001D194
		static vtkAbstractContextItem()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAbstractContextItem.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAbstractContextItem"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06001157 RID: 4439 RVA: 0x0001EFBC File Offset: 0x0001D1BC
		public vtkAbstractContextItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06001158 RID: 4440 RVA: 0x0001EFCA File Offset: 0x0001D1CA
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06001159 RID: 4441
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractContextItem_AddItem_01(HandleRef pThis, HandleRef item);

		/// <summary>
		/// Add child items to this item. Increments reference count of item.
		/// \return the index of the child item.
		/// </summary>
		// Token: 0x0600115A RID: 4442 RVA: 0x0001EFD8 File Offset: 0x0001D1D8
		public long AddItem(vtkAbstractContextItem item)
		{
			return vtkAbstractContextItem.vtkAbstractContextItem_AddItem_01(base.GetCppThis(), (item == null) ? default(HandleRef) : item.GetCppThis());
		}

		// Token: 0x0600115B RID: 4443
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractContextItem_ClearItems_02(HandleRef pThis);

		/// <summary>
		/// Remove all child items from this item.
		/// </summary>
		// Token: 0x0600115C RID: 4444 RVA: 0x0001F00C File Offset: 0x0001D20C
		public void ClearItems()
		{
			vtkAbstractContextItem.vtkAbstractContextItem_ClearItems_02(base.GetCppThis());
		}

		// Token: 0x0600115D RID: 4445
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAbstractContextItem_GetInteractive_03(HandleRef pThis);

		/// <summary>
		/// Get if the item is interactive (should respond to mouse events).
		/// </summary>
		// Token: 0x0600115E RID: 4446 RVA: 0x0001F01C File Offset: 0x0001D21C
		public virtual bool GetInteractive()
		{
			return vtkAbstractContextItem.vtkAbstractContextItem_GetInteractive_03(base.GetCppThis()) != 0;
		}

		// Token: 0x0600115F RID: 4447
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractContextItem_GetItem_04(HandleRef pThis, long index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the item at the specified index.
		/// \return the item at the specified index (null if index is invalid).
		/// </summary>
		// Token: 0x06001160 RID: 4448 RVA: 0x0001F044 File Offset: 0x0001D244
		public vtkAbstractContextItem GetItem(long index)
		{
			vtkAbstractContextItem vtkAbstractContextItem = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractContextItem.vtkAbstractContextItem_GetItem_04(base.GetCppThis(), index, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractContextItem = (vtkAbstractContextItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractContextItem.Register(null);
				}
			}
			return vtkAbstractContextItem;
		}

		// Token: 0x06001161 RID: 4449
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractContextItem_GetItemIndex_05(HandleRef pThis, HandleRef item);

		/// <summary>
		/// Get the index of the specified item in itemIndex.
		/// \return the item index if found or -1 if not.
		/// </summary>
		// Token: 0x06001162 RID: 4450 RVA: 0x0001F0B4 File Offset: 0x0001D2B4
		public long GetItemIndex(vtkAbstractContextItem item)
		{
			return vtkAbstractContextItem.vtkAbstractContextItem_GetItemIndex_05(base.GetCppThis(), (item == null) ? default(HandleRef) : item.GetCppThis());
		}

		// Token: 0x06001163 RID: 4451
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractContextItem_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001164 RID: 4452 RVA: 0x0001F0E8 File Offset: 0x0001D2E8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAbstractContextItem.vtkAbstractContextItem_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x06001165 RID: 4453
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractContextItem_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001166 RID: 4454 RVA: 0x0001F108 File Offset: 0x0001D308
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAbstractContextItem.vtkAbstractContextItem_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x06001167 RID: 4455
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractContextItem_GetNumberOfItems_08(HandleRef pThis);

		/// <summary>
		/// Get the number of child items.
		/// </summary>
		// Token: 0x06001168 RID: 4456 RVA: 0x0001F124 File Offset: 0x0001D324
		public long GetNumberOfItems()
		{
			return vtkAbstractContextItem.vtkAbstractContextItem_GetNumberOfItems_08(base.GetCppThis());
		}

		// Token: 0x06001169 RID: 4457
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractContextItem_GetParent_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the parent item. The parent will be set for all items except top
		/// level items in a tree.
		/// </summary>
		// Token: 0x0600116A RID: 4458 RVA: 0x0001F144 File Offset: 0x0001D344
		public vtkAbstractContextItem GetParent()
		{
			vtkAbstractContextItem vtkAbstractContextItem = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractContextItem.vtkAbstractContextItem_GetParent_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractContextItem = (vtkAbstractContextItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractContextItem.Register(null);
				}
			}
			return vtkAbstractContextItem;
		}

		// Token: 0x0600116B RID: 4459
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractContextItem_GetScene_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the vtkContextScene for the item, always set for an item in a scene.
		/// </summary>
		// Token: 0x0600116C RID: 4460 RVA: 0x0001F1B4 File Offset: 0x0001D3B4
		public vtkContextScene GetScene()
		{
			vtkContextScene vtkContextScene = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractContextItem.vtkAbstractContextItem_GetScene_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkContextScene = (vtkContextScene)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkContextScene.Register(null);
				}
			}
			return vtkContextScene;
		}

		// Token: 0x0600116D RID: 4461
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAbstractContextItem_GetVisible_11(HandleRef pThis);

		/// <summary>
		/// Get the visibility of the item (should it be drawn).
		/// </summary>
		// Token: 0x0600116E RID: 4462 RVA: 0x0001F224 File Offset: 0x0001D424
		public virtual bool GetVisible()
		{
			return vtkAbstractContextItem.vtkAbstractContextItem_GetVisible_11(base.GetCppThis()) != 0;
		}

		// Token: 0x0600116F RID: 4463
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractContextItem_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001170 RID: 4464 RVA: 0x0001F24C File Offset: 0x0001D44C
		public override int IsA(string type)
		{
			return vtkAbstractContextItem.vtkAbstractContextItem_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x06001171 RID: 4465
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractContextItem_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001172 RID: 4466 RVA: 0x0001F26C File Offset: 0x0001D46C
		public new static int IsTypeOf(string type)
		{
			return vtkAbstractContextItem.vtkAbstractContextItem_IsTypeOf_13(type);
		}

		// Token: 0x06001173 RID: 4467
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractContextItem_Lower_14(HandleRef pThis, long index);

		/// <summary>
		/// Lowers the \a child to the bottom of the item's stack.
		/// \return The new index of the item
		/// \sa StackUnder(), Raise(), StackAbove()
		/// </summary>
		// Token: 0x06001174 RID: 4468 RVA: 0x0001F288 File Offset: 0x0001D488
		public long Lower(long index)
		{
			return vtkAbstractContextItem.vtkAbstractContextItem_Lower_14(base.GetCppThis(), index);
		}

		// Token: 0x06001175 RID: 4469
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractContextItem_MapFromParent_15(HandleRef pThis, HandleRef point, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Maps the point from the parent coordinate system.
		/// </summary>
		// Token: 0x06001176 RID: 4470 RVA: 0x0001F2A8 File Offset: 0x0001D4A8
		public virtual vtkVector2f MapFromParent(vtkVector2f point)
		{
			vtkVector2f result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractContextItem.vtkAbstractContextItem_MapFromParent_15(base.GetCppThis(), (point == null) ? default(HandleRef) : point.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVector2f)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06001177 RID: 4471
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractContextItem_MapFromScene_16(HandleRef pThis, HandleRef point, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Maps the point from the scene coordinate system.
		/// </summary>
		// Token: 0x06001178 RID: 4472 RVA: 0x0001F318 File Offset: 0x0001D518
		public virtual vtkVector2f MapFromScene(vtkVector2f point)
		{
			vtkVector2f result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractContextItem.vtkAbstractContextItem_MapFromScene_16(base.GetCppThis(), (point == null) ? default(HandleRef) : point.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVector2f)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06001179 RID: 4473
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractContextItem_MapToParent_17(HandleRef pThis, HandleRef point, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Maps the point to the parent coordinate system.
		/// </summary>
		// Token: 0x0600117A RID: 4474 RVA: 0x0001F388 File Offset: 0x0001D588
		public virtual vtkVector2f MapToParent(vtkVector2f point)
		{
			vtkVector2f result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractContextItem.vtkAbstractContextItem_MapToParent_17(base.GetCppThis(), (point == null) ? default(HandleRef) : point.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVector2f)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600117B RID: 4475
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractContextItem_MapToScene_18(HandleRef pThis, HandleRef point, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Maps the point to the scene coordinate system.
		/// </summary>
		// Token: 0x0600117C RID: 4476 RVA: 0x0001F3F8 File Offset: 0x0001D5F8
		public virtual vtkVector2f MapToScene(vtkVector2f point)
		{
			vtkVector2f result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractContextItem.vtkAbstractContextItem_MapToScene_18(base.GetCppThis(), (point == null) ? default(HandleRef) : point.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVector2f)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600117D RID: 4477
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractContextItem_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600117E RID: 4478 RVA: 0x0001F468 File Offset: 0x0001D668
		public new vtkAbstractContextItem NewInstance()
		{
			vtkAbstractContextItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractContextItem.vtkAbstractContextItem_NewInstance_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractContextItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600117F RID: 4479
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAbstractContextItem_Paint_20(HandleRef pThis, HandleRef painter);

		/// <summary>
		/// Paint event for the item, called whenever the item needs to be drawn.
		/// </summary>
		// Token: 0x06001180 RID: 4480 RVA: 0x0001F4C4 File Offset: 0x0001D6C4
		public virtual bool Paint(vtkContext2D painter)
		{
			return vtkAbstractContextItem.vtkAbstractContextItem_Paint_20(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		// Token: 0x06001181 RID: 4481
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAbstractContextItem_PaintChildren_21(HandleRef pThis, HandleRef painter);

		/// <summary>
		/// Paint the children of the item, should be called whenever the children
		/// need to be rendered.
		/// </summary>
		// Token: 0x06001182 RID: 4482 RVA: 0x0001F500 File Offset: 0x0001D700
		public virtual bool PaintChildren(vtkContext2D painter)
		{
			return vtkAbstractContextItem.vtkAbstractContextItem_PaintChildren_21(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		// Token: 0x06001183 RID: 4483
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractContextItem_Raise_22(HandleRef pThis, long index);

		/// <summary>
		/// Raises the \a child to the top of the item's stack.
		/// \return The new index of the item
		/// \sa StackAbove(), Lower(), LowerUnder()
		/// </summary>
		// Token: 0x06001184 RID: 4484 RVA: 0x0001F53C File Offset: 0x0001D73C
		public long Raise(long index)
		{
			return vtkAbstractContextItem.vtkAbstractContextItem_Raise_22(base.GetCppThis(), index);
		}

		// Token: 0x06001185 RID: 4485
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractContextItem_ReleaseGraphicsResources_23(HandleRef pThis);

		/// <summary>
		/// Release graphics resources hold by the item. The default implementation
		/// is empty.
		/// </summary>
		// Token: 0x06001186 RID: 4486 RVA: 0x0001F55C File Offset: 0x0001D75C
		public virtual void ReleaseGraphicsResources()
		{
			vtkAbstractContextItem.vtkAbstractContextItem_ReleaseGraphicsResources_23(base.GetCppThis());
		}

		// Token: 0x06001187 RID: 4487
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAbstractContextItem_RemoveItem_24(HandleRef pThis, HandleRef item);

		/// <summary>
		/// Remove child item from this item. Decrements reference count of item.
		/// \param item the item to be removed.
		/// \return true on success, false otherwise.
		/// </summary>
		// Token: 0x06001188 RID: 4488 RVA: 0x0001F56C File Offset: 0x0001D76C
		public bool RemoveItem(vtkAbstractContextItem item)
		{
			return vtkAbstractContextItem.vtkAbstractContextItem_RemoveItem_24(base.GetCppThis(), (item == null) ? default(HandleRef) : item.GetCppThis()) != 0;
		}

		// Token: 0x06001189 RID: 4489
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAbstractContextItem_RemoveItem_25(HandleRef pThis, long index);

		/// <summary>
		/// Remove child item from this item. Decrements reference count of item.
		/// \param index of the item to be removed.
		/// \return true on success, false otherwise.
		/// </summary>
		// Token: 0x0600118A RID: 4490 RVA: 0x0001F5A8 File Offset: 0x0001D7A8
		public bool RemoveItem(long index)
		{
			return vtkAbstractContextItem.vtkAbstractContextItem_RemoveItem_25(base.GetCppThis(), index) != 0;
		}

		// Token: 0x0600118B RID: 4491
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractContextItem_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600118C RID: 4492 RVA: 0x0001F5D0 File Offset: 0x0001D7D0
		public new static vtkAbstractContextItem SafeDownCast(vtkObjectBase o)
		{
			vtkAbstractContextItem vtkAbstractContextItem = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractContextItem.vtkAbstractContextItem_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractContextItem = (vtkAbstractContextItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractContextItem.Register(null);
				}
			}
			return vtkAbstractContextItem;
		}

		// Token: 0x0600118D RID: 4493
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractContextItem_SetInteractive_27(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set if the item is interactive (should respond to mouse events).
		/// </summary>
		// Token: 0x0600118E RID: 4494 RVA: 0x0001F64F File Offset: 0x0001D84F
		public virtual void SetInteractive(bool _arg)
		{
			vtkAbstractContextItem.vtkAbstractContextItem_SetInteractive_27(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600118F RID: 4495
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractContextItem_SetParent_28(HandleRef pThis, HandleRef parent);

		/// <summary>
		/// Set the parent item. The parent will be set for all items except top
		/// level items in a scene.
		/// </summary>
		// Token: 0x06001190 RID: 4496 RVA: 0x0001F668 File Offset: 0x0001D868
		public virtual void SetParent(vtkAbstractContextItem parent)
		{
			vtkAbstractContextItem.vtkAbstractContextItem_SetParent_28(base.GetCppThis(), (parent == null) ? default(HandleRef) : parent.GetCppThis());
		}

		// Token: 0x06001191 RID: 4497
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractContextItem_SetScene_29(HandleRef pThis, HandleRef scene);

		/// <summary>
		/// Set the vtkContextScene for the item, always set for an item in a scene.
		/// </summary>
		// Token: 0x06001192 RID: 4498 RVA: 0x0001F698 File Offset: 0x0001D898
		public virtual void SetScene(vtkContextScene scene)
		{
			vtkAbstractContextItem.vtkAbstractContextItem_SetScene_29(base.GetCppThis(), (scene == null) ? default(HandleRef) : scene.GetCppThis());
		}

		// Token: 0x06001193 RID: 4499
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractContextItem_SetVisible_30(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set the visibility of the item (should it be drawn).
		/// Visible by default.
		/// </summary>
		// Token: 0x06001194 RID: 4500 RVA: 0x0001F6C7 File Offset: 0x0001D8C7
		public virtual void SetVisible(bool _arg)
		{
			vtkAbstractContextItem.vtkAbstractContextItem_SetVisible_30(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06001195 RID: 4501
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractContextItem_StackAbove_31(HandleRef pThis, long index, long under);

		/// <summary>
		/// Raises the \a child above the \a under sibling. If \a under is invalid,
		/// the item is raised to the top of the item's stack.
		/// \return The new index of the item
		/// \sa Raise(), Lower(), StackUnder()
		/// </summary>
		// Token: 0x06001196 RID: 4502 RVA: 0x0001F6E0 File Offset: 0x0001D8E0
		public virtual long StackAbove(long index, long under)
		{
			return vtkAbstractContextItem.vtkAbstractContextItem_StackAbove_31(base.GetCppThis(), index, under);
		}

		// Token: 0x06001197 RID: 4503
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractContextItem_StackUnder_32(HandleRef pThis, long child, long above);

		/// <summary>
		/// Lowers the \a child under the \a above sibling. If \a above is invalid,
		/// the item is lowered to the bottom of the item's stack
		/// \return The new index of the item
		/// \sa Lower(), Raise(), StackAbove()
		/// </summary>
		// Token: 0x06001198 RID: 4504 RVA: 0x0001F704 File Offset: 0x0001D904
		public virtual long StackUnder(long child, long above)
		{
			return vtkAbstractContextItem.vtkAbstractContextItem_StackUnder_32(base.GetCppThis(), child, above);
		}

		// Token: 0x06001199 RID: 4505
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractContextItem_Update_33(HandleRef pThis);

		/// <summary>
		/// Perform any updates to the item that may be necessary before rendering.
		/// The scene should take care of calling this on all items before their
		/// Paint function is invoked.
		/// </summary>
		// Token: 0x0600119A RID: 4506 RVA: 0x0001F725 File Offset: 0x0001D925
		public virtual void Update()
		{
			vtkAbstractContextItem.vtkAbstractContextItem_Update_33(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000443 RID: 1091
		public new const string MRFullTypeName = "Kitware.VTK.vtkAbstractContextItem";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000444 RID: 1092
		public new static readonly string MRClassNameKey = "class vtkAbstractContextItem";
	}
}
