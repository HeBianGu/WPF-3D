using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkContextScene
	/// </summary>
	/// <remarks>
	///    Provides a 2D scene for vtkContextItem objects.
	///
	///
	/// Provides a 2D scene that vtkContextItem objects can be added to. Manages the
	/// items, ensures that they are rendered at the right times and passes on mouse
	/// events.
	/// </remarks>
	// Token: 0x020007AF RID: 1967
	public class vtkContextScene : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601430D RID: 82701 RVA: 0x001C8877 File Offset: 0x001C6A77
		static vtkContextScene()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkContextScene.MRClassNameKey, Type.GetType("Kitware.VTK.vtkContextScene"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601430E RID: 82702 RVA: 0x001C889F File Offset: 0x001C6A9F
		public vtkContextScene(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601430F RID: 82703
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContextScene_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates a 2D Painter object.
		/// </summary>
		// Token: 0x06014310 RID: 82704 RVA: 0x001C88B0 File Offset: 0x001C6AB0
		public new static vtkContextScene New()
		{
			vtkContextScene result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContextScene.vtkContextScene_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContextScene)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Creates a 2D Painter object.
		/// </summary>
		// Token: 0x06014311 RID: 82705 RVA: 0x001C8904 File Offset: 0x001C6B04
		public vtkContextScene() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkContextScene.vtkContextScene_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06014312 RID: 82706 RVA: 0x001C8948 File Offset: 0x001C6B48
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06014313 RID: 82707
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkContextScene_AddItem_01(HandleRef pThis, HandleRef item);

		/// <summary>
		/// Add child items to this item. Increments reference count of item.
		/// \return the index of the child item.
		/// </summary>
		// Token: 0x06014314 RID: 82708 RVA: 0x001C8954 File Offset: 0x001C6B54
		public uint AddItem(vtkAbstractContextItem item)
		{
			return vtkContextScene.vtkContextScene_AddItem_01(base.GetCppThis(), (item == null) ? default(HandleRef) : item.GetCppThis());
		}

		// Token: 0x06014315 RID: 82709
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextScene_ClearItems_02(HandleRef pThis);

		/// <summary>
		/// Remove all child items from this item.
		/// </summary>
		// Token: 0x06014316 RID: 82710 RVA: 0x001C8988 File Offset: 0x001C6B88
		public void ClearItems()
		{
			vtkContextScene.vtkContextScene_ClearItems_02(base.GetCppThis());
		}

		// Token: 0x06014317 RID: 82711
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContextScene_GetAnnotationLink_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the vtkAnnotationLink for the chart.
		/// </summary>
		// Token: 0x06014318 RID: 82712 RVA: 0x001C8998 File Offset: 0x001C6B98
		public virtual vtkAnnotationLink GetAnnotationLink()
		{
			vtkAnnotationLink vtkAnnotationLink = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContextScene.vtkContextScene_GetAnnotationLink_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAnnotationLink = (vtkAnnotationLink)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAnnotationLink.Register(null);
				}
			}
			return vtkAnnotationLink;
		}

		// Token: 0x06014319 RID: 82713
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContextScene_GetBufferId_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return buffer id.
		/// Not part of the end-user API. Can be used by context items to
		/// initialize their own colorbuffer id (when a context item is a container).
		/// </summary>
		// Token: 0x0601431A RID: 82714 RVA: 0x001C8A08 File Offset: 0x001C6C08
		public vtkAbstractContextBufferId GetBufferId()
		{
			vtkAbstractContextBufferId vtkAbstractContextBufferId = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContextScene.vtkContextScene_GetBufferId_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractContextBufferId = (vtkAbstractContextBufferId)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractContextBufferId.Register(null);
				}
			}
			return vtkAbstractContextBufferId;
		}

		// Token: 0x0601431B RID: 82715
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkContextScene_GetDirty_05(HandleRef pThis);

		/// <summary>
		/// Inform the scene that something changed that requires a repaint of the
		/// scene. This should only be used by the vtkContextItem derived objects in
		/// a scene in their event handlers.
		/// </summary>
		// Token: 0x0601431C RID: 82716 RVA: 0x001C8A78 File Offset: 0x001C6C78
		public bool GetDirty()
		{
			return vtkContextScene.vtkContextScene_GetDirty_05(base.GetCppThis()) != 0;
		}

		// Token: 0x0601431D RID: 82717
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContextScene_GetGeometry_06(HandleRef pThis);

		/// <summary>
		/// Get the width and height of the scene in pixels.
		/// </summary>
		// Token: 0x0601431E RID: 82718 RVA: 0x001C8AA0 File Offset: 0x001C6CA0
		public virtual int[] GetGeometry()
		{
			IntPtr intPtr = vtkContextScene.vtkContextScene_GetGeometry_06(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601431F RID: 82719
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextScene_GetGeometry_07(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Get the width and height of the scene in pixels.
		/// </summary>
		// Token: 0x06014320 RID: 82720 RVA: 0x001C8AE8 File Offset: 0x001C6CE8
		public virtual void GetGeometry(ref int _arg1, ref int _arg2)
		{
			vtkContextScene.vtkContextScene_GetGeometry_07(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06014321 RID: 82721
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextScene_GetGeometry_08(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get the width and height of the scene in pixels.
		/// </summary>
		// Token: 0x06014322 RID: 82722 RVA: 0x001C8AF9 File Offset: 0x001C6CF9
		public virtual void GetGeometry(IntPtr _arg)
		{
			vtkContextScene.vtkContextScene_GetGeometry_08(base.GetCppThis(), _arg);
		}

		// Token: 0x06014323 RID: 82723
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContextScene_GetItem_09(HandleRef pThis, uint index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the item at the specified index.
		/// \return the item at the specified index (null if index is invalid).
		/// </summary>
		// Token: 0x06014324 RID: 82724 RVA: 0x001C8B0C File Offset: 0x001C6D0C
		public vtkAbstractContextItem GetItem(uint index)
		{
			vtkAbstractContextItem vtkAbstractContextItem = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContextScene.vtkContextScene_GetItem_09(base.GetCppThis(), index, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06014325 RID: 82725
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContextScene_GetLogicalTileScale_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The tile scale of the target vtkRenderWindow. Hardcoded pixel offsets, etc
		/// should properly account for these &lt;x, y&gt; scale factors. This will simply
		/// return vtkVector2i(1, 1) if ScaleTiles is false or if this-&gt;Renderer is
		/// NULL.
		/// </summary>
		// Token: 0x06014326 RID: 82726 RVA: 0x001C8B7C File Offset: 0x001C6D7C
		public vtkVector2i GetLogicalTileScale()
		{
			vtkVector2i result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContextScene.vtkContextScene_GetLogicalTileScale_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVector2i)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014327 RID: 82727
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkContextScene_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014328 RID: 82728 RVA: 0x001C8BD8 File Offset: 0x001C6DD8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkContextScene.vtkContextScene_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x06014329 RID: 82729
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkContextScene_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601432A RID: 82730 RVA: 0x001C8BF8 File Offset: 0x001C6DF8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkContextScene.vtkContextScene_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x0601432B RID: 82731
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkContextScene_GetNumberOfItems_13(HandleRef pThis);

		/// <summary>
		/// Get the number of child items.
		/// </summary>
		// Token: 0x0601432C RID: 82732 RVA: 0x001C8C14 File Offset: 0x001C6E14
		public uint GetNumberOfItems()
		{
			return vtkContextScene.vtkContextScene_GetNumberOfItems_13(base.GetCppThis());
		}

		// Token: 0x0601432D RID: 82733
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContextScene_GetOrigin_14(HandleRef pThis);

		/// <summary>
		/// Get/Set the origin (bottom-left) coordinate of the scene in pixels (screen coordinates).
		/// </summary>
		// Token: 0x0601432E RID: 82734 RVA: 0x001C8C34 File Offset: 0x001C6E34
		public virtual int[] GetOrigin()
		{
			IntPtr intPtr = vtkContextScene.vtkContextScene_GetOrigin_14(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601432F RID: 82735
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextScene_GetOrigin_15(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Get/Set the origin (bottom-left) coordinate of the scene in pixels (screen coordinates).
		/// </summary>
		// Token: 0x06014330 RID: 82736 RVA: 0x001C8C7C File Offset: 0x001C6E7C
		public virtual void GetOrigin(ref int _arg1, ref int _arg2)
		{
			vtkContextScene.vtkContextScene_GetOrigin_15(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06014331 RID: 82737
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextScene_GetOrigin_16(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the origin (bottom-left) coordinate of the scene in pixels (screen coordinates).
		/// </summary>
		// Token: 0x06014332 RID: 82738 RVA: 0x001C8C8D File Offset: 0x001C6E8D
		public virtual void GetOrigin(IntPtr _arg)
		{
			vtkContextScene.vtkContextScene_GetOrigin_16(base.GetCppThis(), _arg);
		}

		// Token: 0x06014333 RID: 82739
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkContextScene_GetPickedItem_17(HandleRef pThis, int x, int y);

		/// <summary>
		/// Return the item id under mouse cursor at position (x,y).
		/// Return -1 if there is no item under the mouse cursor.
		/// \post valid_result: result&gt;=-1 &amp;&amp; result&lt;this-&gt;GetNumberOfItems()
		/// </summary>
		// Token: 0x06014334 RID: 82740 RVA: 0x001C8CA0 File Offset: 0x001C6EA0
		public long GetPickedItem(int x, int y)
		{
			return vtkContextScene.vtkContextScene_GetPickedItem_17(base.GetCppThis(), x, y);
		}

		// Token: 0x06014335 RID: 82741
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContextScene_GetPickedItem_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the item under the mouse.
		/// If no item is under the mouse, the method returns a null pointer.
		/// </summary>
		// Token: 0x06014336 RID: 82742 RVA: 0x001C8CC4 File Offset: 0x001C6EC4
		public vtkAbstractContextItem GetPickedItem()
		{
			vtkAbstractContextItem vtkAbstractContextItem = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContextScene.vtkContextScene_GetPickedItem_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06014337 RID: 82743
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContextScene_GetRenderer_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This should not be necessary as the context view should take care of
		/// rendering.
		/// </summary>
		// Token: 0x06014338 RID: 82744 RVA: 0x001C8D34 File Offset: 0x001C6F34
		public virtual vtkRenderer GetRenderer()
		{
			vtkRenderer vtkRenderer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContextScene.vtkContextScene_GetRenderer_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderer = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderer.Register(null);
				}
			}
			return vtkRenderer;
		}

		// Token: 0x06014339 RID: 82745
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkContextScene_GetScaleTiles_20(HandleRef pThis);

		/// <summary>
		/// Whether to scale the scene transform when tiling, for example when
		/// using vtkWindowToImageFilter to take a large screenshot.
		/// The default is true.
		/// </summary>
		// Token: 0x0601433A RID: 82746 RVA: 0x001C8DA4 File Offset: 0x001C6FA4
		public virtual bool GetScaleTiles()
		{
			return vtkContextScene.vtkContextScene_GetScaleTiles_20(base.GetCppThis()) != 0;
		}

		// Token: 0x0601433B RID: 82747
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContextScene_GetSceneBottom_21(HandleRef pThis);

		/// <summary>
		/// Get the bottom of the scene in screen coordinates.
		/// This is equivalent to GetOrigin[1].
		/// </summary>
		// Token: 0x0601433C RID: 82748 RVA: 0x001C8DCC File Offset: 0x001C6FCC
		public virtual int GetSceneBottom()
		{
			return vtkContextScene.vtkContextScene_GetSceneBottom_21(base.GetCppThis());
		}

		// Token: 0x0601433D RID: 82749
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContextScene_GetSceneHeight_22(HandleRef pThis);

		/// <summary>
		/// Get the height of the scene.
		/// </summary>
		// Token: 0x0601433E RID: 82750 RVA: 0x001C8DEC File Offset: 0x001C6FEC
		public int GetSceneHeight()
		{
			return vtkContextScene.vtkContextScene_GetSceneHeight_22(base.GetCppThis());
		}

		// Token: 0x0601433F RID: 82751
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContextScene_GetSceneLeft_23(HandleRef pThis);

		/// <summary>
		/// Get the left of the scene in screen coordinates.
		/// This is equivalent to GetOrigin[0].
		/// </summary>
		// Token: 0x06014340 RID: 82752 RVA: 0x001C8E0C File Offset: 0x001C700C
		public virtual int GetSceneLeft()
		{
			return vtkContextScene.vtkContextScene_GetSceneLeft_23(base.GetCppThis());
		}

		// Token: 0x06014341 RID: 82753
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContextScene_GetSceneWidth_24(HandleRef pThis);

		/// <summary>
		/// Get the width of the scene.
		/// </summary>
		// Token: 0x06014342 RID: 82754 RVA: 0x001C8E2C File Offset: 0x001C702C
		public int GetSceneWidth()
		{
			return vtkContextScene.vtkContextScene_GetSceneWidth_24(base.GetCppThis());
		}

		// Token: 0x06014343 RID: 82755
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContextScene_GetTransform_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the transform for the scene.
		/// </summary>
		// Token: 0x06014344 RID: 82756 RVA: 0x001C8E4C File Offset: 0x001C704C
		public vtkTransform2D GetTransform()
		{
			vtkTransform2D vtkTransform2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContextScene.vtkContextScene_GetTransform_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransform2D = (vtkTransform2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransform2D.Register(null);
				}
			}
			return vtkTransform2D;
		}

		// Token: 0x06014345 RID: 82757
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkContextScene_GetUseBufferId_26(HandleRef pThis);

		/// <summary>
		/// Get whether the scene is using the color buffer. Default is true.
		/// </summary>
		// Token: 0x06014346 RID: 82758 RVA: 0x001C8EBC File Offset: 0x001C70BC
		public virtual bool GetUseBufferId()
		{
			return vtkContextScene.vtkContextScene_GetUseBufferId_26(base.GetCppThis()) != 0;
		}

		// Token: 0x06014347 RID: 82759
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContextScene_GetViewHeight_27(HandleRef pThis);

		/// <summary>
		/// Get the height of the view (render window) containing this scene.
		/// Note that this might be larger than the scene height, which can
		/// be retrieved using the GetSceneHeight method, when multiple
		/// viewports are defined in the render window.
		/// </summary>
		// Token: 0x06014348 RID: 82760 RVA: 0x001C8EE4 File Offset: 0x001C70E4
		public virtual int GetViewHeight()
		{
			return vtkContextScene.vtkContextScene_GetViewHeight_27(base.GetCppThis());
		}

		// Token: 0x06014349 RID: 82761
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContextScene_GetViewWidth_28(HandleRef pThis);

		/// <summary>
		/// Get the width of the view (render window) containing this scene.
		/// Note that this might be larger than the scene width, which can
		/// be retrieved using the GetSceneWidth method, when multiple
		/// viewports are defined in the render window.
		/// </summary>
		// Token: 0x0601434A RID: 82762 RVA: 0x001C8F04 File Offset: 0x001C7104
		public virtual int GetViewWidth()
		{
			return vtkContextScene.vtkContextScene_GetViewWidth_28(base.GetCppThis());
		}

		// Token: 0x0601434B RID: 82763
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkContextScene_HasTransform_29(HandleRef pThis);

		/// <summary>
		/// Check whether the scene has a transform.
		/// </summary>
		// Token: 0x0601434C RID: 82764 RVA: 0x001C8F24 File Offset: 0x001C7124
		public bool HasTransform()
		{
			return vtkContextScene.vtkContextScene_HasTransform_29(base.GetCppThis()) != 0;
		}

		// Token: 0x0601434D RID: 82765
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContextScene_IsA_30(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601434E RID: 82766 RVA: 0x001C8F4C File Offset: 0x001C714C
		public override int IsA(string type)
		{
			return vtkContextScene.vtkContextScene_IsA_30(base.GetCppThis(), type);
		}

		// Token: 0x0601434F RID: 82767
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContextScene_IsTypeOf_31([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014350 RID: 82768 RVA: 0x001C8F6C File Offset: 0x001C716C
		public new static int IsTypeOf(string type)
		{
			return vtkContextScene.vtkContextScene_IsTypeOf_31(type);
		}

		// Token: 0x06014351 RID: 82769
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContextScene_NewInstance_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014352 RID: 82770 RVA: 0x001C8F88 File Offset: 0x001C7188
		public new vtkContextScene NewInstance()
		{
			vtkContextScene result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContextScene.vtkContextScene_NewInstance_33(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContextScene)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014353 RID: 82771
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkContextScene_Paint_34(HandleRef pThis, HandleRef painter);

		/// <summary>
		/// Paint event for the chart, called whenever the chart needs to be drawn
		/// </summary>
		// Token: 0x06014354 RID: 82772 RVA: 0x001C8FE4 File Offset: 0x001C71E4
		public virtual bool Paint(vtkContext2D painter)
		{
			return vtkContextScene.vtkContextScene_Paint_34(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		// Token: 0x06014355 RID: 82773
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextScene_ReleaseGraphicsResources_35(HandleRef pThis);

		/// <summary>
		/// Release graphics resources hold by the scene.
		/// </summary>
		// Token: 0x06014356 RID: 82774 RVA: 0x001C901F File Offset: 0x001C721F
		public void ReleaseGraphicsResources()
		{
			vtkContextScene.vtkContextScene_ReleaseGraphicsResources_35(base.GetCppThis());
		}

		// Token: 0x06014357 RID: 82775
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkContextScene_RemoveItem_36(HandleRef pThis, HandleRef item);

		/// <summary>
		/// Remove child item from this item. Decrements reference count of item.
		/// \param item the item to be removed.
		/// \return true on success, false otherwise.
		/// </summary>
		// Token: 0x06014358 RID: 82776 RVA: 0x001C9030 File Offset: 0x001C7230
		public bool RemoveItem(vtkAbstractContextItem item)
		{
			return vtkContextScene.vtkContextScene_RemoveItem_36(base.GetCppThis(), (item == null) ? default(HandleRef) : item.GetCppThis()) != 0;
		}

		// Token: 0x06014359 RID: 82777
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkContextScene_RemoveItem_37(HandleRef pThis, uint index);

		/// <summary>
		/// Remove child item from this item. Decrements reference count of item.
		/// \param index of the item to be removed.
		/// \return true on success, false otherwise.
		/// </summary>
		// Token: 0x0601435A RID: 82778 RVA: 0x001C906C File Offset: 0x001C726C
		public bool RemoveItem(uint index)
		{
			return vtkContextScene.vtkContextScene_RemoveItem_37(base.GetCppThis(), index) != 0;
		}

		// Token: 0x0601435B RID: 82779
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContextScene_SafeDownCast_38(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601435C RID: 82780 RVA: 0x001C9094 File Offset: 0x001C7294
		public new static vtkContextScene SafeDownCast(vtkObjectBase o)
		{
			vtkContextScene vtkContextScene = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContextScene.vtkContextScene_SafeDownCast_38((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601435D RID: 82781
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextScene_ScaleTilesOff_39(HandleRef pThis);

		/// <summary>
		/// Whether to scale the scene transform when tiling, for example when
		/// using vtkWindowToImageFilter to take a large screenshot.
		/// The default is true.
		/// </summary>
		// Token: 0x0601435E RID: 82782 RVA: 0x001C9113 File Offset: 0x001C7313
		public virtual void ScaleTilesOff()
		{
			vtkContextScene.vtkContextScene_ScaleTilesOff_39(base.GetCppThis());
		}

		// Token: 0x0601435F RID: 82783
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextScene_ScaleTilesOn_40(HandleRef pThis);

		/// <summary>
		/// Whether to scale the scene transform when tiling, for example when
		/// using vtkWindowToImageFilter to take a large screenshot.
		/// The default is true.
		/// </summary>
		// Token: 0x06014360 RID: 82784 RVA: 0x001C9122 File Offset: 0x001C7322
		public virtual void ScaleTilesOn()
		{
			vtkContextScene.vtkContextScene_ScaleTilesOn_40(base.GetCppThis());
		}

		// Token: 0x06014361 RID: 82785
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextScene_SetAnnotationLink_41(HandleRef pThis, HandleRef link);

		/// <summary>
		/// Set the vtkAnnotationLink for the chart.
		/// </summary>
		// Token: 0x06014362 RID: 82786 RVA: 0x001C9134 File Offset: 0x001C7334
		public virtual void SetAnnotationLink(vtkAnnotationLink link)
		{
			vtkContextScene.vtkContextScene_SetAnnotationLink_41(base.GetCppThis(), (link == null) ? default(HandleRef) : link.GetCppThis());
		}

		// Token: 0x06014363 RID: 82787
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextScene_SetDirty_42(HandleRef pThis, byte isDirty);

		/// <summary>
		/// Inform the scene that something changed that requires a repaint of the
		/// scene. This should only be used by the vtkContextItem derived objects in
		/// a scene in their event handlers.
		/// </summary>
		// Token: 0x06014364 RID: 82788 RVA: 0x001C9163 File Offset: 0x001C7363
		public void SetDirty(bool isDirty)
		{
			vtkContextScene.vtkContextScene_SetDirty_42(base.GetCppThis(), isDirty ? (byte)1 : (byte)0);
		}

		// Token: 0x06014365 RID: 82789
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextScene_SetGeometry_43(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Set the width and height of the scene in pixels.
		/// </summary>
		// Token: 0x06014366 RID: 82790 RVA: 0x001C917B File Offset: 0x001C737B
		public virtual void SetGeometry(int _arg1, int _arg2)
		{
			vtkContextScene.vtkContextScene_SetGeometry_43(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x06014367 RID: 82791
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextScene_SetGeometry_44(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the width and height of the scene in pixels.
		/// </summary>
		// Token: 0x06014368 RID: 82792 RVA: 0x001C918C File Offset: 0x001C738C
		public void SetGeometry(IntPtr _arg)
		{
			vtkContextScene.vtkContextScene_SetGeometry_44(base.GetCppThis(), _arg);
		}

		// Token: 0x06014369 RID: 82793
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextScene_SetOrigin_45(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Get/Set the origin (bottom-left) coordinate of the scene in pixels (screen coordinates).
		/// </summary>
		// Token: 0x0601436A RID: 82794 RVA: 0x001C919C File Offset: 0x001C739C
		public virtual void SetOrigin(int _arg1, int _arg2)
		{
			vtkContextScene.vtkContextScene_SetOrigin_45(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0601436B RID: 82795
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextScene_SetOrigin_46(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the origin (bottom-left) coordinate of the scene in pixels (screen coordinates).
		/// </summary>
		// Token: 0x0601436C RID: 82796 RVA: 0x001C91AD File Offset: 0x001C73AD
		public void SetOrigin(IntPtr _arg)
		{
			vtkContextScene.vtkContextScene_SetOrigin_46(base.GetCppThis(), _arg);
		}

		// Token: 0x0601436D RID: 82797
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextScene_SetRenderer_47(HandleRef pThis, HandleRef renderer);

		/// <summary>
		/// This should not be necessary as the context view should take care of
		/// rendering.
		/// </summary>
		// Token: 0x0601436E RID: 82798 RVA: 0x001C91C0 File Offset: 0x001C73C0
		public virtual void SetRenderer(vtkRenderer renderer)
		{
			vtkContextScene.vtkContextScene_SetRenderer_47(base.GetCppThis(), (renderer == null) ? default(HandleRef) : renderer.GetCppThis());
		}

		// Token: 0x0601436F RID: 82799
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextScene_SetScaleTiles_48(HandleRef pThis, byte _arg);

		/// <summary>
		/// Whether to scale the scene transform when tiling, for example when
		/// using vtkWindowToImageFilter to take a large screenshot.
		/// The default is true.
		/// </summary>
		// Token: 0x06014370 RID: 82800 RVA: 0x001C91EF File Offset: 0x001C73EF
		public virtual void SetScaleTiles(bool _arg)
		{
			vtkContextScene.vtkContextScene_SetScaleTiles_48(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06014371 RID: 82801
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextScene_SetTransform_49(HandleRef pThis, HandleRef transform);

		/// <summary>
		/// Set the transform for the scene.
		/// </summary>
		// Token: 0x06014372 RID: 82802 RVA: 0x001C9208 File Offset: 0x001C7408
		public virtual void SetTransform(vtkTransform2D transform)
		{
			vtkContextScene.vtkContextScene_SetTransform_49(base.GetCppThis(), (transform == null) ? default(HandleRef) : transform.GetCppThis());
		}

		// Token: 0x06014373 RID: 82803
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextScene_SetUseBufferId_50(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set whether the scene should use the color buffer. Default is true.
		/// </summary>
		// Token: 0x06014374 RID: 82804 RVA: 0x001C9237 File Offset: 0x001C7437
		public virtual void SetUseBufferId(bool _arg)
		{
			vtkContextScene.vtkContextScene_SetUseBufferId_50(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400176A RID: 5994
		public new const string MRFullTypeName = "Kitware.VTK.vtkContextScene";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400176B RID: 5995
		public new static readonly string MRClassNameKey = "class vtkContextScene";

		/// <summary>
		/// Enum of valid selection modes for charts in the scene
		/// </summary>
		// Token: 0x020007B0 RID: 1968
		public enum SelectionModifier
		{
			/// <summary>enum member</summary>
			// Token: 0x0400176D RID: 5997
			SELECTION_ADDITION = 1,
			/// <summary>enum member</summary>
			// Token: 0x0400176E RID: 5998
			SELECTION_DEFAULT = 0,
			/// <summary>enum member</summary>
			// Token: 0x0400176F RID: 5999
			SELECTION_SUBTRACTION = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001770 RID: 6000
			SELECTION_TOGGLE
		}
	}
}
