using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkParallelCoordinatesInteractorStyle
	/// </summary>
	/// <remarks>
	///    interactive manipulation of the camera specialized for parallel coordinates
	///
	/// vtkParallelCoordinatesInteractorStyle allows the user to interactively manipulate
	/// (rotate, pan, zoom etc.) the camera.
	/// Several events are overloaded from its superclass
	/// vtkInteractorStyleTrackballCamera, hence the mouse bindings are different.
	/// (The bindings keep the camera's view plane normal perpendicular to the x-y plane.)
	/// In summary, the mouse events are as follows:
	/// + Left Mouse button triggers window level events
	/// + CTRL Left Mouse spins the camera around its view plane normal
	/// + SHIFT Left Mouse pans the camera
	/// + CTRL SHIFT Left Mouse dollys (a positional zoom) the camera
	/// + Middle mouse button pans the camera
	/// + Right mouse button dollys the camera.
	/// + SHIFT Right Mouse triggers pick events
	///
	/// Note that the renderer's actors are not moved; instead the camera is moved.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkInteractorStyle vtkInteractorStyleTrackballActor
	/// vtkInteractorStyleJoystickCamera vtkInteractorStyleJoystickActor
	/// </seealso>
	// Token: 0x0200040B RID: 1035
	public class vtkParallelCoordinatesInteractorStyle : vtkInteractorStyleTrackballCamera
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C46F RID: 50287 RVA: 0x001112B3 File Offset: 0x0010F4B3
		static vtkParallelCoordinatesInteractorStyle()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParallelCoordinatesInteractorStyle.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParallelCoordinatesInteractorStyle"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C470 RID: 50288 RVA: 0x001112DB File Offset: 0x0010F4DB
		public vtkParallelCoordinatesInteractorStyle(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C471 RID: 50289
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelCoordinatesInteractorStyle_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C472 RID: 50290 RVA: 0x001112EC File Offset: 0x0010F4EC
		public new static vtkParallelCoordinatesInteractorStyle New()
		{
			vtkParallelCoordinatesInteractorStyle result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParallelCoordinatesInteractorStyle)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C473 RID: 50291 RVA: 0x00111340 File Offset: 0x0010F540
		public vtkParallelCoordinatesInteractorStyle() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C474 RID: 50292 RVA: 0x00111384 File Offset: 0x0010F584
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C475 RID: 50293
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesInteractorStyle_EndInspect_01(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C476 RID: 50294 RVA: 0x0011138F File Offset: 0x0010F58F
		public virtual void EndInspect()
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_EndInspect_01(base.GetCppThis());
		}

		// Token: 0x0600C477 RID: 50295
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesInteractorStyle_EndPan_02(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C478 RID: 50296 RVA: 0x0011139E File Offset: 0x0010F59E
		public override void EndPan()
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_EndPan_02(base.GetCppThis());
		}

		// Token: 0x0600C479 RID: 50297
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesInteractorStyle_EndZoom_03(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C47A RID: 50298 RVA: 0x001113AD File Offset: 0x0010F5AD
		public override void EndZoom()
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_EndZoom_03(base.GetCppThis());
		}

		// Token: 0x0600C47B RID: 50299
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelCoordinatesInteractorStyle_GetCursorCurrentPosition_04(HandleRef pThis);

		/// <summary>
		/// Get the cursor positions in pixel coords
		/// </summary>
		// Token: 0x0600C47C RID: 50300 RVA: 0x001113BC File Offset: 0x0010F5BC
		public virtual int[] GetCursorCurrentPosition()
		{
			IntPtr intPtr = vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_GetCursorCurrentPosition_04(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600C47D RID: 50301
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesInteractorStyle_GetCursorCurrentPosition_05(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Get the cursor positions in pixel coords
		/// </summary>
		// Token: 0x0600C47E RID: 50302 RVA: 0x00111404 File Offset: 0x0010F604
		public virtual void GetCursorCurrentPosition(ref int _arg1, ref int _arg2)
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_GetCursorCurrentPosition_05(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x0600C47F RID: 50303
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesInteractorStyle_GetCursorCurrentPosition_06(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get the cursor positions in pixel coords
		/// </summary>
		// Token: 0x0600C480 RID: 50304 RVA: 0x00111415 File Offset: 0x0010F615
		public virtual void GetCursorCurrentPosition(IntPtr _arg)
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_GetCursorCurrentPosition_06(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C481 RID: 50305
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesInteractorStyle_GetCursorCurrentPosition_07(HandleRef pThis, HandleRef viewport, IntPtr pos);

		/// <summary>
		/// Get the cursor positions in a given coordinate system
		/// </summary>
		// Token: 0x0600C482 RID: 50306 RVA: 0x00111428 File Offset: 0x0010F628
		public void GetCursorCurrentPosition(vtkViewport viewport, IntPtr pos)
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_GetCursorCurrentPosition_07(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis(), pos);
		}

		// Token: 0x0600C483 RID: 50307
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelCoordinatesInteractorStyle_GetCursorLastPosition_08(HandleRef pThis);

		/// <summary>
		/// Get the cursor positions in pixel coords
		/// </summary>
		// Token: 0x0600C484 RID: 50308 RVA: 0x00111458 File Offset: 0x0010F658
		public virtual int[] GetCursorLastPosition()
		{
			IntPtr intPtr = vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_GetCursorLastPosition_08(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600C485 RID: 50309
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesInteractorStyle_GetCursorLastPosition_09(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Get the cursor positions in pixel coords
		/// </summary>
		// Token: 0x0600C486 RID: 50310 RVA: 0x001114A0 File Offset: 0x0010F6A0
		public virtual void GetCursorLastPosition(ref int _arg1, ref int _arg2)
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_GetCursorLastPosition_09(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x0600C487 RID: 50311
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesInteractorStyle_GetCursorLastPosition_10(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get the cursor positions in pixel coords
		/// </summary>
		// Token: 0x0600C488 RID: 50312 RVA: 0x001114B1 File Offset: 0x0010F6B1
		public virtual void GetCursorLastPosition(IntPtr _arg)
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_GetCursorLastPosition_10(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C489 RID: 50313
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesInteractorStyle_GetCursorLastPosition_11(HandleRef pThis, HandleRef viewport, IntPtr pos);

		/// <summary>
		/// Get the cursor positions in a given coordinate system
		/// </summary>
		// Token: 0x0600C48A RID: 50314 RVA: 0x001114C4 File Offset: 0x0010F6C4
		public void GetCursorLastPosition(vtkViewport viewport, IntPtr pos)
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_GetCursorLastPosition_11(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis(), pos);
		}

		// Token: 0x0600C48B RID: 50315
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelCoordinatesInteractorStyle_GetCursorStartPosition_12(HandleRef pThis);

		/// <summary>
		/// Get the cursor positions in pixel coords
		/// </summary>
		// Token: 0x0600C48C RID: 50316 RVA: 0x001114F4 File Offset: 0x0010F6F4
		public virtual int[] GetCursorStartPosition()
		{
			IntPtr intPtr = vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_GetCursorStartPosition_12(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600C48D RID: 50317
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesInteractorStyle_GetCursorStartPosition_13(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Get the cursor positions in pixel coords
		/// </summary>
		// Token: 0x0600C48E RID: 50318 RVA: 0x0011153C File Offset: 0x0010F73C
		public virtual void GetCursorStartPosition(ref int _arg1, ref int _arg2)
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_GetCursorStartPosition_13(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x0600C48F RID: 50319
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesInteractorStyle_GetCursorStartPosition_14(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get the cursor positions in pixel coords
		/// </summary>
		// Token: 0x0600C490 RID: 50320 RVA: 0x0011154D File Offset: 0x0010F74D
		public virtual void GetCursorStartPosition(IntPtr _arg)
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_GetCursorStartPosition_14(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C491 RID: 50321
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesInteractorStyle_GetCursorStartPosition_15(HandleRef pThis, HandleRef viewport, IntPtr pos);

		/// <summary>
		/// Get the cursor positions in a given coordinate system
		/// </summary>
		// Token: 0x0600C492 RID: 50322 RVA: 0x00111560 File Offset: 0x0010F760
		public void GetCursorStartPosition(vtkViewport viewport, IntPtr pos)
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_GetCursorStartPosition_15(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis(), pos);
		}

		// Token: 0x0600C493 RID: 50323
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParallelCoordinatesInteractorStyle_GetNumberOfGenerationsFromBase_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C494 RID: 50324 RVA: 0x00111590 File Offset: 0x0010F790
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_GetNumberOfGenerationsFromBase_16(base.GetCppThis(), type);
		}

		// Token: 0x0600C495 RID: 50325
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParallelCoordinatesInteractorStyle_GetNumberOfGenerationsFromBaseType_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C496 RID: 50326 RVA: 0x001115B0 File Offset: 0x0010F7B0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_GetNumberOfGenerationsFromBaseType_17(type);
		}

		// Token: 0x0600C497 RID: 50327
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesInteractorStyle_Inspect_18(HandleRef pThis, int x, int y);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C498 RID: 50328 RVA: 0x001115CA File Offset: 0x0010F7CA
		public virtual void Inspect(int x, int y)
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_Inspect_18(base.GetCppThis(), x, y);
		}

		// Token: 0x0600C499 RID: 50329
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelCoordinatesInteractorStyle_IsA_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C49A RID: 50330 RVA: 0x001115DC File Offset: 0x0010F7DC
		public override int IsA(string type)
		{
			return vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_IsA_19(base.GetCppThis(), type);
		}

		// Token: 0x0600C49B RID: 50331
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelCoordinatesInteractorStyle_IsTypeOf_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C49C RID: 50332 RVA: 0x001115FC File Offset: 0x0010F7FC
		public new static int IsTypeOf(string type)
		{
			return vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_IsTypeOf_20(type);
		}

		// Token: 0x0600C49D RID: 50333
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelCoordinatesInteractorStyle_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C49E RID: 50334 RVA: 0x00111618 File Offset: 0x0010F818
		public new vtkParallelCoordinatesInteractorStyle NewInstance()
		{
			vtkParallelCoordinatesInteractorStyle result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_NewInstance_22(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParallelCoordinatesInteractorStyle)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C49F RID: 50335
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesInteractorStyle_OnChar_23(HandleRef pThis);

		/// <summary>
		/// Override the "fly-to" (f keypress) for images.
		/// </summary>
		// Token: 0x0600C4A0 RID: 50336 RVA: 0x00111672 File Offset: 0x0010F872
		public override void OnChar()
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_OnChar_23(base.GetCppThis());
		}

		// Token: 0x0600C4A1 RID: 50337
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesInteractorStyle_OnLeave_24(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C4A2 RID: 50338 RVA: 0x00111681 File Offset: 0x0010F881
		public override void OnLeave()
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_OnLeave_24(base.GetCppThis());
		}

		// Token: 0x0600C4A3 RID: 50339
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesInteractorStyle_OnLeftButtonDown_25(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C4A4 RID: 50340 RVA: 0x00111690 File Offset: 0x0010F890
		public override void OnLeftButtonDown()
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_OnLeftButtonDown_25(base.GetCppThis());
		}

		// Token: 0x0600C4A5 RID: 50341
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesInteractorStyle_OnLeftButtonUp_26(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C4A6 RID: 50342 RVA: 0x0011169F File Offset: 0x0010F89F
		public override void OnLeftButtonUp()
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_OnLeftButtonUp_26(base.GetCppThis());
		}

		// Token: 0x0600C4A7 RID: 50343
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesInteractorStyle_OnMiddleButtonDown_27(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C4A8 RID: 50344 RVA: 0x001116AE File Offset: 0x0010F8AE
		public override void OnMiddleButtonDown()
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_OnMiddleButtonDown_27(base.GetCppThis());
		}

		// Token: 0x0600C4A9 RID: 50345
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesInteractorStyle_OnMiddleButtonUp_28(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C4AA RID: 50346 RVA: 0x001116BD File Offset: 0x0010F8BD
		public override void OnMiddleButtonUp()
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_OnMiddleButtonUp_28(base.GetCppThis());
		}

		// Token: 0x0600C4AB RID: 50347
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesInteractorStyle_OnMouseMove_29(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C4AC RID: 50348 RVA: 0x001116CC File Offset: 0x0010F8CC
		public override void OnMouseMove()
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_OnMouseMove_29(base.GetCppThis());
		}

		// Token: 0x0600C4AD RID: 50349
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesInteractorStyle_OnRightButtonDown_30(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C4AE RID: 50350 RVA: 0x001116DB File Offset: 0x0010F8DB
		public override void OnRightButtonDown()
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_OnRightButtonDown_30(base.GetCppThis());
		}

		// Token: 0x0600C4AF RID: 50351
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesInteractorStyle_OnRightButtonUp_31(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C4B0 RID: 50352 RVA: 0x001116EA File Offset: 0x0010F8EA
		public override void OnRightButtonUp()
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_OnRightButtonUp_31(base.GetCppThis());
		}

		// Token: 0x0600C4B1 RID: 50353
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesInteractorStyle_Pan_32(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C4B2 RID: 50354 RVA: 0x001116F9 File Offset: 0x0010F8F9
		public override void Pan()
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_Pan_32(base.GetCppThis());
		}

		// Token: 0x0600C4B3 RID: 50355
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelCoordinatesInteractorStyle_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C4B4 RID: 50356 RVA: 0x00111708 File Offset: 0x0010F908
		public new static vtkParallelCoordinatesInteractorStyle SafeDownCast(vtkObjectBase o)
		{
			vtkParallelCoordinatesInteractorStyle vtkParallelCoordinatesInteractorStyle = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_SafeDownCast_33((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParallelCoordinatesInteractorStyle = (vtkParallelCoordinatesInteractorStyle)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParallelCoordinatesInteractorStyle.Register(null);
				}
			}
			return vtkParallelCoordinatesInteractorStyle;
		}

		// Token: 0x0600C4B5 RID: 50357
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesInteractorStyle_StartInspect_34(HandleRef pThis, int x, int y);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C4B6 RID: 50358 RVA: 0x00111787 File Offset: 0x0010F987
		public virtual void StartInspect(int x, int y)
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_StartInspect_34(base.GetCppThis(), x, y);
		}

		// Token: 0x0600C4B7 RID: 50359
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesInteractorStyle_StartPan_35(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C4B8 RID: 50360 RVA: 0x00111798 File Offset: 0x0010F998
		public override void StartPan()
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_StartPan_35(base.GetCppThis());
		}

		// Token: 0x0600C4B9 RID: 50361
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesInteractorStyle_StartZoom_36(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C4BA RID: 50362 RVA: 0x001117A7 File Offset: 0x0010F9A7
		public override void StartZoom()
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_StartZoom_36(base.GetCppThis());
		}

		// Token: 0x0600C4BB RID: 50363
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesInteractorStyle_Zoom_37(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C4BC RID: 50364 RVA: 0x001117B6 File Offset: 0x0010F9B6
		public override void Zoom()
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_Zoom_37(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E8E RID: 3726
		public new const string MRFullTypeName = "Kitware.VTK.vtkParallelCoordinatesInteractorStyle";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E8F RID: 3727
		public new static readonly string MRClassNameKey = "class vtkParallelCoordinatesInteractorStyle";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0200040C RID: 1036
		public enum INTERACT_HOVER_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000E91 RID: 3729
			INTERACT_HOVER,
			/// <summary>enum member</summary>
			// Token: 0x04000E92 RID: 3730
			INTERACT_INSPECT,
			/// <summary>enum member</summary>
			// Token: 0x04000E93 RID: 3731
			INTERACT_PAN = 3,
			/// <summary>enum member</summary>
			// Token: 0x04000E94 RID: 3732
			INTERACT_ZOOM = 2
		}
	}
}
