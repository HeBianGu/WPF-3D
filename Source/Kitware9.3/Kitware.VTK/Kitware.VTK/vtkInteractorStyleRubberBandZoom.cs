using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInteractorStyleRubberBandZoom
	/// </summary>
	/// <remarks>
	///    zoom in by amount indicated by rubber band box
	///
	/// This interactor style allows the user to draw a rectangle in the render
	/// window using the left mouse button.  When the mouse button is released,
	/// the current camera zooms by an amount determined from the shorter side of
	/// the drawn rectangle.
	/// </remarks>
	// Token: 0x02000401 RID: 1025
	public class vtkInteractorStyleRubberBandZoom : vtkInteractorStyle
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C329 RID: 49961 RVA: 0x0010F91A File Offset: 0x0010DB1A
		static vtkInteractorStyleRubberBandZoom()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInteractorStyleRubberBandZoom.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleRubberBandZoom"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C32A RID: 49962 RVA: 0x0010F942 File Offset: 0x0010DB42
		public vtkInteractorStyleRubberBandZoom(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C32B RID: 49963
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleRubberBandZoom_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C32C RID: 49964 RVA: 0x0010F950 File Offset: 0x0010DB50
		public new static vtkInteractorStyleRubberBandZoom New()
		{
			vtkInteractorStyleRubberBandZoom result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleRubberBandZoom.vtkInteractorStyleRubberBandZoom_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleRubberBandZoom)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C32D RID: 49965 RVA: 0x0010F9A4 File Offset: 0x0010DBA4
		public vtkInteractorStyleRubberBandZoom() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkInteractorStyleRubberBandZoom.vtkInteractorStyleRubberBandZoom_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C32E RID: 49966 RVA: 0x0010F9E8 File Offset: 0x0010DBE8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C32F RID: 49967
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleRubberBandZoom_CenterAtStartPositionOff_01(HandleRef pThis);

		/// <summary>
		/// When set to true (default, false), the position where the user starts the
		/// interaction is treated as the center of the box rather that one of the
		/// corners of the box.
		///
		/// During interaction, modifier keys `Shift` or `Control` can be used to toggle
		/// this flag temporarily. In other words, if `Shift` or `Control` key is pressed,
		/// this class will act as if CenterAtStartPosition was opposite of what it is
		/// set to.
		/// </summary>
		// Token: 0x0600C330 RID: 49968 RVA: 0x0010F9F3 File Offset: 0x0010DBF3
		public virtual void CenterAtStartPositionOff()
		{
			vtkInteractorStyleRubberBandZoom.vtkInteractorStyleRubberBandZoom_CenterAtStartPositionOff_01(base.GetCppThis());
		}

		// Token: 0x0600C331 RID: 49969
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleRubberBandZoom_CenterAtStartPositionOn_02(HandleRef pThis);

		/// <summary>
		/// When set to true (default, false), the position where the user starts the
		/// interaction is treated as the center of the box rather that one of the
		/// corners of the box.
		///
		/// During interaction, modifier keys `Shift` or `Control` can be used to toggle
		/// this flag temporarily. In other words, if `Shift` or `Control` key is pressed,
		/// this class will act as if CenterAtStartPosition was opposite of what it is
		/// set to.
		/// </summary>
		// Token: 0x0600C332 RID: 49970 RVA: 0x0010FA02 File Offset: 0x0010DC02
		public virtual void CenterAtStartPositionOn()
		{
			vtkInteractorStyleRubberBandZoom.vtkInteractorStyleRubberBandZoom_CenterAtStartPositionOn_02(base.GetCppThis());
		}

		// Token: 0x0600C333 RID: 49971
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkInteractorStyleRubberBandZoom_GetCenterAtStartPosition_03(HandleRef pThis);

		/// <summary>
		/// When set to true (default, false), the position where the user starts the
		/// interaction is treated as the center of the box rather that one of the
		/// corners of the box.
		///
		/// During interaction, modifier keys `Shift` or `Control` can be used to toggle
		/// this flag temporarily. In other words, if `Shift` or `Control` key is pressed,
		/// this class will act as if CenterAtStartPosition was opposite of what it is
		/// set to.
		/// </summary>
		// Token: 0x0600C334 RID: 49972 RVA: 0x0010FA14 File Offset: 0x0010DC14
		public virtual bool GetCenterAtStartPosition()
		{
			return vtkInteractorStyleRubberBandZoom.vtkInteractorStyleRubberBandZoom_GetCenterAtStartPosition_03(base.GetCppThis()) != 0;
		}

		// Token: 0x0600C335 RID: 49973
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkInteractorStyleRubberBandZoom_GetLockAspectToViewport_04(HandleRef pThis);

		/// <summary>
		/// When set to true (default, false), the interactor will lock the rendered box to the
		/// viewport's aspect ratio.
		/// </summary>
		// Token: 0x0600C336 RID: 49974 RVA: 0x0010FA3C File Offset: 0x0010DC3C
		public virtual bool GetLockAspectToViewport()
		{
			return vtkInteractorStyleRubberBandZoom.vtkInteractorStyleRubberBandZoom_GetLockAspectToViewport_04(base.GetCppThis()) != 0;
		}

		// Token: 0x0600C337 RID: 49975
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInteractorStyleRubberBandZoom_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C338 RID: 49976 RVA: 0x0010FA64 File Offset: 0x0010DC64
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInteractorStyleRubberBandZoom.vtkInteractorStyleRubberBandZoom_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0600C339 RID: 49977
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInteractorStyleRubberBandZoom_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C33A RID: 49978 RVA: 0x0010FA84 File Offset: 0x0010DC84
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInteractorStyleRubberBandZoom.vtkInteractorStyleRubberBandZoom_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0600C33B RID: 49979
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkInteractorStyleRubberBandZoom_GetUseDollyForPerspectiveProjection_07(HandleRef pThis);

		/// <summary>
		/// If camera is in perspective projection mode, this interactor style uses
		/// vtkCamera::Dolly to dolly the camera ahead for zooming. However, that can
		/// have unintended consequences such as the camera entering into the data.
		/// Another option is to use vtkCamera::Zoom instead. In that case, the camera
		/// position is left unchanged, instead the focal point is changed to the
		/// center of the target box and then the view angle is changed to zoom in.
		/// To use this approach, set this parameter to false (default, true).
		/// </summary>
		// Token: 0x0600C33C RID: 49980 RVA: 0x0010FAA0 File Offset: 0x0010DCA0
		public virtual bool GetUseDollyForPerspectiveProjection()
		{
			return vtkInteractorStyleRubberBandZoom.vtkInteractorStyleRubberBandZoom_GetUseDollyForPerspectiveProjection_07(base.GetCppThis()) != 0;
		}

		// Token: 0x0600C33D RID: 49981
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyleRubberBandZoom_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C33E RID: 49982 RVA: 0x0010FAC8 File Offset: 0x0010DCC8
		public override int IsA(string type)
		{
			return vtkInteractorStyleRubberBandZoom.vtkInteractorStyleRubberBandZoom_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0600C33F RID: 49983
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyleRubberBandZoom_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C340 RID: 49984 RVA: 0x0010FAE8 File Offset: 0x0010DCE8
		public new static int IsTypeOf(string type)
		{
			return vtkInteractorStyleRubberBandZoom.vtkInteractorStyleRubberBandZoom_IsTypeOf_09(type);
		}

		// Token: 0x0600C341 RID: 49985
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleRubberBandZoom_LockAspectToViewportOff_10(HandleRef pThis);

		/// <summary>
		/// When set to true (default, false), the interactor will lock the rendered box to the
		/// viewport's aspect ratio.
		/// </summary>
		// Token: 0x0600C342 RID: 49986 RVA: 0x0010FB02 File Offset: 0x0010DD02
		public virtual void LockAspectToViewportOff()
		{
			vtkInteractorStyleRubberBandZoom.vtkInteractorStyleRubberBandZoom_LockAspectToViewportOff_10(base.GetCppThis());
		}

		// Token: 0x0600C343 RID: 49987
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleRubberBandZoom_LockAspectToViewportOn_11(HandleRef pThis);

		/// <summary>
		/// When set to true (default, false), the interactor will lock the rendered box to the
		/// viewport's aspect ratio.
		/// </summary>
		// Token: 0x0600C344 RID: 49988 RVA: 0x0010FB11 File Offset: 0x0010DD11
		public virtual void LockAspectToViewportOn()
		{
			vtkInteractorStyleRubberBandZoom.vtkInteractorStyleRubberBandZoom_LockAspectToViewportOn_11(base.GetCppThis());
		}

		// Token: 0x0600C345 RID: 49989
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleRubberBandZoom_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C346 RID: 49990 RVA: 0x0010FB20 File Offset: 0x0010DD20
		public new vtkInteractorStyleRubberBandZoom NewInstance()
		{
			vtkInteractorStyleRubberBandZoom result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleRubberBandZoom.vtkInteractorStyleRubberBandZoom_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleRubberBandZoom)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C347 RID: 49991
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleRubberBandZoom_OnLeftButtonDown_14(HandleRef pThis);

		/// <summary>
		/// Event bindings
		/// </summary>
		// Token: 0x0600C348 RID: 49992 RVA: 0x0010FB7A File Offset: 0x0010DD7A
		public override void OnLeftButtonDown()
		{
			vtkInteractorStyleRubberBandZoom.vtkInteractorStyleRubberBandZoom_OnLeftButtonDown_14(base.GetCppThis());
		}

		// Token: 0x0600C349 RID: 49993
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleRubberBandZoom_OnLeftButtonUp_15(HandleRef pThis);

		/// <summary>
		/// Event bindings
		/// </summary>
		// Token: 0x0600C34A RID: 49994 RVA: 0x0010FB89 File Offset: 0x0010DD89
		public override void OnLeftButtonUp()
		{
			vtkInteractorStyleRubberBandZoom.vtkInteractorStyleRubberBandZoom_OnLeftButtonUp_15(base.GetCppThis());
		}

		// Token: 0x0600C34B RID: 49995
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleRubberBandZoom_OnMouseMove_16(HandleRef pThis);

		/// <summary>
		/// Event bindings
		/// </summary>
		// Token: 0x0600C34C RID: 49996 RVA: 0x0010FB98 File Offset: 0x0010DD98
		public override void OnMouseMove()
		{
			vtkInteractorStyleRubberBandZoom.vtkInteractorStyleRubberBandZoom_OnMouseMove_16(base.GetCppThis());
		}

		// Token: 0x0600C34D RID: 49997
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleRubberBandZoom_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C34E RID: 49998 RVA: 0x0010FBA8 File Offset: 0x0010DDA8
		public new static vtkInteractorStyleRubberBandZoom SafeDownCast(vtkObjectBase o)
		{
			vtkInteractorStyleRubberBandZoom vtkInteractorStyleRubberBandZoom = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleRubberBandZoom.vtkInteractorStyleRubberBandZoom_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInteractorStyleRubberBandZoom = (vtkInteractorStyleRubberBandZoom)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInteractorStyleRubberBandZoom.Register(null);
				}
			}
			return vtkInteractorStyleRubberBandZoom;
		}

		// Token: 0x0600C34F RID: 49999
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleRubberBandZoom_SetCenterAtStartPosition_18(HandleRef pThis, byte _arg);

		/// <summary>
		/// When set to true (default, false), the position where the user starts the
		/// interaction is treated as the center of the box rather that one of the
		/// corners of the box.
		///
		/// During interaction, modifier keys `Shift` or `Control` can be used to toggle
		/// this flag temporarily. In other words, if `Shift` or `Control` key is pressed,
		/// this class will act as if CenterAtStartPosition was opposite of what it is
		/// set to.
		/// </summary>
		// Token: 0x0600C350 RID: 50000 RVA: 0x0010FC27 File Offset: 0x0010DE27
		public virtual void SetCenterAtStartPosition(bool _arg)
		{
			vtkInteractorStyleRubberBandZoom.vtkInteractorStyleRubberBandZoom_SetCenterAtStartPosition_18(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600C351 RID: 50001
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleRubberBandZoom_SetLockAspectToViewport_19(HandleRef pThis, byte _arg);

		/// <summary>
		/// When set to true (default, false), the interactor will lock the rendered box to the
		/// viewport's aspect ratio.
		/// </summary>
		// Token: 0x0600C352 RID: 50002 RVA: 0x0010FC3F File Offset: 0x0010DE3F
		public virtual void SetLockAspectToViewport(bool _arg)
		{
			vtkInteractorStyleRubberBandZoom.vtkInteractorStyleRubberBandZoom_SetLockAspectToViewport_19(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600C353 RID: 50003
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleRubberBandZoom_SetUseDollyForPerspectiveProjection_20(HandleRef pThis, byte _arg);

		/// <summary>
		/// If camera is in perspective projection mode, this interactor style uses
		/// vtkCamera::Dolly to dolly the camera ahead for zooming. However, that can
		/// have unintended consequences such as the camera entering into the data.
		/// Another option is to use vtkCamera::Zoom instead. In that case, the camera
		/// position is left unchanged, instead the focal point is changed to the
		/// center of the target box and then the view angle is changed to zoom in.
		/// To use this approach, set this parameter to false (default, true).
		/// </summary>
		// Token: 0x0600C354 RID: 50004 RVA: 0x0010FC57 File Offset: 0x0010DE57
		public virtual void SetUseDollyForPerspectiveProjection(bool _arg)
		{
			vtkInteractorStyleRubberBandZoom.vtkInteractorStyleRubberBandZoom_SetUseDollyForPerspectiveProjection_20(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600C355 RID: 50005
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleRubberBandZoom_UseDollyForPerspectiveProjectionOff_21(HandleRef pThis);

		/// <summary>
		/// If camera is in perspective projection mode, this interactor style uses
		/// vtkCamera::Dolly to dolly the camera ahead for zooming. However, that can
		/// have unintended consequences such as the camera entering into the data.
		/// Another option is to use vtkCamera::Zoom instead. In that case, the camera
		/// position is left unchanged, instead the focal point is changed to the
		/// center of the target box and then the view angle is changed to zoom in.
		/// To use this approach, set this parameter to false (default, true).
		/// </summary>
		// Token: 0x0600C356 RID: 50006 RVA: 0x0010FC6F File Offset: 0x0010DE6F
		public virtual void UseDollyForPerspectiveProjectionOff()
		{
			vtkInteractorStyleRubberBandZoom.vtkInteractorStyleRubberBandZoom_UseDollyForPerspectiveProjectionOff_21(base.GetCppThis());
		}

		// Token: 0x0600C357 RID: 50007
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleRubberBandZoom_UseDollyForPerspectiveProjectionOn_22(HandleRef pThis);

		/// <summary>
		/// If camera is in perspective projection mode, this interactor style uses
		/// vtkCamera::Dolly to dolly the camera ahead for zooming. However, that can
		/// have unintended consequences such as the camera entering into the data.
		/// Another option is to use vtkCamera::Zoom instead. In that case, the camera
		/// position is left unchanged, instead the focal point is changed to the
		/// center of the target box and then the view angle is changed to zoom in.
		/// To use this approach, set this parameter to false (default, true).
		/// </summary>
		// Token: 0x0600C358 RID: 50008 RVA: 0x0010FC7E File Offset: 0x0010DE7E
		public virtual void UseDollyForPerspectiveProjectionOn()
		{
			vtkInteractorStyleRubberBandZoom.vtkInteractorStyleRubberBandZoom_UseDollyForPerspectiveProjectionOn_22(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E74 RID: 3700
		public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleRubberBandZoom";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E75 RID: 3701
		public new static readonly string MRClassNameKey = "class vtkInteractorStyleRubberBandZoom";
	}
}
