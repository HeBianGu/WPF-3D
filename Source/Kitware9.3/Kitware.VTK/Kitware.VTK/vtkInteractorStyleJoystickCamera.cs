using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInteractorStyleJoystickCamera
	/// </summary>
	/// <remarks>
	///    interactive manipulation of the camera
	///
	///
	/// vtkInteractorStyleJoystickCamera allows the user to move (rotate, pan,
	/// etc.) the camera, the point of view for the scene.  The position of the
	/// mouse relative to the center of the scene determines the speed at which
	/// the camera moves, and the speed of the mouse movement determines the
	/// acceleration of the camera, so the camera continues to move even if the
	/// mouse if not moving.
	/// For a 3-button mouse, the left button is for rotation, the right button
	/// for zooming, the middle button for panning, and ctrl + left button for
	/// spinning.  (With fewer mouse buttons, ctrl + shift + left button is
	/// for zooming, and shift + left button is for panning.)
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkInteractorStyleJoystickActor vtkInteractorStyleTrackballCamera
	/// vtkInteractorStyleTrackballActor
	/// </seealso>
	// Token: 0x020003FB RID: 1019
	public class vtkInteractorStyleJoystickCamera : vtkInteractorStyle
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C283 RID: 49795 RVA: 0x0010ECED File Offset: 0x0010CEED
		static vtkInteractorStyleJoystickCamera()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInteractorStyleJoystickCamera.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleJoystickCamera"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C284 RID: 49796 RVA: 0x0010ED15 File Offset: 0x0010CF15
		public vtkInteractorStyleJoystickCamera(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C285 RID: 49797
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleJoystickCamera_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C286 RID: 49798 RVA: 0x0010ED24 File Offset: 0x0010CF24
		public new static vtkInteractorStyleJoystickCamera New()
		{
			vtkInteractorStyleJoystickCamera result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleJoystickCamera.vtkInteractorStyleJoystickCamera_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleJoystickCamera)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C287 RID: 49799 RVA: 0x0010ED78 File Offset: 0x0010CF78
		public vtkInteractorStyleJoystickCamera() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkInteractorStyleJoystickCamera.vtkInteractorStyleJoystickCamera_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C288 RID: 49800 RVA: 0x0010EDBC File Offset: 0x0010CFBC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C289 RID: 49801
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleJoystickCamera_Dolly_01(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C28A RID: 49802 RVA: 0x0010EDC7 File Offset: 0x0010CFC7
		public override void Dolly()
		{
			vtkInteractorStyleJoystickCamera.vtkInteractorStyleJoystickCamera_Dolly_01(base.GetCppThis());
		}

		// Token: 0x0600C28B RID: 49803
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInteractorStyleJoystickCamera_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C28C RID: 49804 RVA: 0x0010EDD8 File Offset: 0x0010CFD8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInteractorStyleJoystickCamera.vtkInteractorStyleJoystickCamera_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600C28D RID: 49805
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInteractorStyleJoystickCamera_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C28E RID: 49806 RVA: 0x0010EDF8 File Offset: 0x0010CFF8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInteractorStyleJoystickCamera.vtkInteractorStyleJoystickCamera_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600C28F RID: 49807
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyleJoystickCamera_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C290 RID: 49808 RVA: 0x0010EE14 File Offset: 0x0010D014
		public override int IsA(string type)
		{
			return vtkInteractorStyleJoystickCamera.vtkInteractorStyleJoystickCamera_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600C291 RID: 49809
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyleJoystickCamera_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C292 RID: 49810 RVA: 0x0010EE34 File Offset: 0x0010D034
		public new static int IsTypeOf(string type)
		{
			return vtkInteractorStyleJoystickCamera.vtkInteractorStyleJoystickCamera_IsTypeOf_05(type);
		}

		// Token: 0x0600C293 RID: 49811
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleJoystickCamera_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C294 RID: 49812 RVA: 0x0010EE50 File Offset: 0x0010D050
		public new vtkInteractorStyleJoystickCamera NewInstance()
		{
			vtkInteractorStyleJoystickCamera result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleJoystickCamera.vtkInteractorStyleJoystickCamera_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleJoystickCamera)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C295 RID: 49813
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleJoystickCamera_OnLeftButtonDown_08(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C296 RID: 49814 RVA: 0x0010EEAA File Offset: 0x0010D0AA
		public override void OnLeftButtonDown()
		{
			vtkInteractorStyleJoystickCamera.vtkInteractorStyleJoystickCamera_OnLeftButtonDown_08(base.GetCppThis());
		}

		// Token: 0x0600C297 RID: 49815
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleJoystickCamera_OnLeftButtonUp_09(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C298 RID: 49816 RVA: 0x0010EEB9 File Offset: 0x0010D0B9
		public override void OnLeftButtonUp()
		{
			vtkInteractorStyleJoystickCamera.vtkInteractorStyleJoystickCamera_OnLeftButtonUp_09(base.GetCppThis());
		}

		// Token: 0x0600C299 RID: 49817
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleJoystickCamera_OnMiddleButtonDown_10(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C29A RID: 49818 RVA: 0x0010EEC8 File Offset: 0x0010D0C8
		public override void OnMiddleButtonDown()
		{
			vtkInteractorStyleJoystickCamera.vtkInteractorStyleJoystickCamera_OnMiddleButtonDown_10(base.GetCppThis());
		}

		// Token: 0x0600C29B RID: 49819
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleJoystickCamera_OnMiddleButtonUp_11(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C29C RID: 49820 RVA: 0x0010EED7 File Offset: 0x0010D0D7
		public override void OnMiddleButtonUp()
		{
			vtkInteractorStyleJoystickCamera.vtkInteractorStyleJoystickCamera_OnMiddleButtonUp_11(base.GetCppThis());
		}

		// Token: 0x0600C29D RID: 49821
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleJoystickCamera_OnMouseMove_12(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C29E RID: 49822 RVA: 0x0010EEE6 File Offset: 0x0010D0E6
		public override void OnMouseMove()
		{
			vtkInteractorStyleJoystickCamera.vtkInteractorStyleJoystickCamera_OnMouseMove_12(base.GetCppThis());
		}

		// Token: 0x0600C29F RID: 49823
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleJoystickCamera_OnMouseWheelBackward_13(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C2A0 RID: 49824 RVA: 0x0010EEF5 File Offset: 0x0010D0F5
		public override void OnMouseWheelBackward()
		{
			vtkInteractorStyleJoystickCamera.vtkInteractorStyleJoystickCamera_OnMouseWheelBackward_13(base.GetCppThis());
		}

		// Token: 0x0600C2A1 RID: 49825
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleJoystickCamera_OnMouseWheelForward_14(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C2A2 RID: 49826 RVA: 0x0010EF04 File Offset: 0x0010D104
		public override void OnMouseWheelForward()
		{
			vtkInteractorStyleJoystickCamera.vtkInteractorStyleJoystickCamera_OnMouseWheelForward_14(base.GetCppThis());
		}

		// Token: 0x0600C2A3 RID: 49827
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleJoystickCamera_OnRightButtonDown_15(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C2A4 RID: 49828 RVA: 0x0010EF13 File Offset: 0x0010D113
		public override void OnRightButtonDown()
		{
			vtkInteractorStyleJoystickCamera.vtkInteractorStyleJoystickCamera_OnRightButtonDown_15(base.GetCppThis());
		}

		// Token: 0x0600C2A5 RID: 49829
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleJoystickCamera_OnRightButtonUp_16(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C2A6 RID: 49830 RVA: 0x0010EF22 File Offset: 0x0010D122
		public override void OnRightButtonUp()
		{
			vtkInteractorStyleJoystickCamera.vtkInteractorStyleJoystickCamera_OnRightButtonUp_16(base.GetCppThis());
		}

		// Token: 0x0600C2A7 RID: 49831
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleJoystickCamera_Pan_17(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C2A8 RID: 49832 RVA: 0x0010EF31 File Offset: 0x0010D131
		public override void Pan()
		{
			vtkInteractorStyleJoystickCamera.vtkInteractorStyleJoystickCamera_Pan_17(base.GetCppThis());
		}

		// Token: 0x0600C2A9 RID: 49833
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleJoystickCamera_Rotate_18(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C2AA RID: 49834 RVA: 0x0010EF40 File Offset: 0x0010D140
		public override void Rotate()
		{
			vtkInteractorStyleJoystickCamera.vtkInteractorStyleJoystickCamera_Rotate_18(base.GetCppThis());
		}

		// Token: 0x0600C2AB RID: 49835
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleJoystickCamera_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C2AC RID: 49836 RVA: 0x0010EF50 File Offset: 0x0010D150
		public new static vtkInteractorStyleJoystickCamera SafeDownCast(vtkObjectBase o)
		{
			vtkInteractorStyleJoystickCamera vtkInteractorStyleJoystickCamera = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleJoystickCamera.vtkInteractorStyleJoystickCamera_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInteractorStyleJoystickCamera = (vtkInteractorStyleJoystickCamera)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInteractorStyleJoystickCamera.Register(null);
				}
			}
			return vtkInteractorStyleJoystickCamera;
		}

		// Token: 0x0600C2AD RID: 49837
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleJoystickCamera_Spin_20(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C2AE RID: 49838 RVA: 0x0010EFCF File Offset: 0x0010D1CF
		public override void Spin()
		{
			vtkInteractorStyleJoystickCamera.vtkInteractorStyleJoystickCamera_Spin_20(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E63 RID: 3683
		public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleJoystickCamera";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E64 RID: 3684
		public new static readonly string MRClassNameKey = "class vtkInteractorStyleJoystickCamera";
	}
}
