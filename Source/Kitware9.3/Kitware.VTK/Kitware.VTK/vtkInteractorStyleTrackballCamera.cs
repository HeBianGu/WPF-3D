using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInteractorStyleTrackballCamera
	/// </summary>
	/// <remarks>
	///    interactive manipulation of the camera
	///
	/// vtkInteractorStyleTrackballCamera allows the user to interactively
	/// manipulate (rotate, pan, etc.) the camera, the viewpoint of the scene.  In
	/// trackball interaction, the magnitude of the mouse motion is proportional
	/// to the camera motion associated with a particular mouse binding. For
	/// example, small left-button motions cause small changes in the rotation of
	/// the camera around its focal point. For a 3-button mouse, the left button
	/// is for rotation, the right button for zooming, the middle button for
	/// panning, ctrl + left button for spinning, and shift + right button for
	/// environment rotation. (With fewer mouse buttons, ctrl + shift + left button
	/// is for zooming, and shift + left button is for panning.)
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkInteractorStyleTrackballActor vtkInteractorStyleJoystickCamera
	/// vtkInteractorStyleJoystickActor
	/// </seealso>
	// Token: 0x02000075 RID: 117
	public class vtkInteractorStyleTrackballCamera : vtkInteractorStyle
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06001558 RID: 5464 RVA: 0x00024279 File Offset: 0x00022479
		static vtkInteractorStyleTrackballCamera()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInteractorStyleTrackballCamera.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleTrackballCamera"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06001559 RID: 5465 RVA: 0x000242A1 File Offset: 0x000224A1
		public vtkInteractorStyleTrackballCamera(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600155A RID: 5466
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleTrackballCamera_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600155B RID: 5467 RVA: 0x000242B0 File Offset: 0x000224B0
		public new static vtkInteractorStyleTrackballCamera New()
		{
			vtkInteractorStyleTrackballCamera result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleTrackballCamera.vtkInteractorStyleTrackballCamera_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleTrackballCamera)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600155C RID: 5468 RVA: 0x00024304 File Offset: 0x00022504
		public vtkInteractorStyleTrackballCamera() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkInteractorStyleTrackballCamera.vtkInteractorStyleTrackballCamera_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600155D RID: 5469 RVA: 0x00024348 File Offset: 0x00022548
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600155E RID: 5470
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleTrackballCamera_Dolly_01(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600155F RID: 5471 RVA: 0x00024353 File Offset: 0x00022553
		public override void Dolly()
		{
			vtkInteractorStyleTrackballCamera.vtkInteractorStyleTrackballCamera_Dolly_01(base.GetCppThis());
		}

		// Token: 0x06001560 RID: 5472
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleTrackballCamera_EnvironmentRotate_02(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x06001561 RID: 5473 RVA: 0x00024362 File Offset: 0x00022562
		public override void EnvironmentRotate()
		{
			vtkInteractorStyleTrackballCamera.vtkInteractorStyleTrackballCamera_EnvironmentRotate_02(base.GetCppThis());
		}

		// Token: 0x06001562 RID: 5474
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkInteractorStyleTrackballCamera_GetMotionFactor_03(HandleRef pThis);

		/// <summary>
		/// Set the apparent sensitivity of the interactor style to mouse motion.
		/// </summary>
		// Token: 0x06001563 RID: 5475 RVA: 0x00024374 File Offset: 0x00022574
		public virtual double GetMotionFactor()
		{
			return vtkInteractorStyleTrackballCamera.vtkInteractorStyleTrackballCamera_GetMotionFactor_03(base.GetCppThis());
		}

		// Token: 0x06001564 RID: 5476
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInteractorStyleTrackballCamera_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001565 RID: 5477 RVA: 0x00024394 File Offset: 0x00022594
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInteractorStyleTrackballCamera.vtkInteractorStyleTrackballCamera_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06001566 RID: 5478
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInteractorStyleTrackballCamera_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001567 RID: 5479 RVA: 0x000243B4 File Offset: 0x000225B4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInteractorStyleTrackballCamera.vtkInteractorStyleTrackballCamera_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06001568 RID: 5480
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyleTrackballCamera_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001569 RID: 5481 RVA: 0x000243D0 File Offset: 0x000225D0
		public override int IsA(string type)
		{
			return vtkInteractorStyleTrackballCamera.vtkInteractorStyleTrackballCamera_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0600156A RID: 5482
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyleTrackballCamera_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600156B RID: 5483 RVA: 0x000243F0 File Offset: 0x000225F0
		public new static int IsTypeOf(string type)
		{
			return vtkInteractorStyleTrackballCamera.vtkInteractorStyleTrackballCamera_IsTypeOf_07(type);
		}

		// Token: 0x0600156C RID: 5484
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleTrackballCamera_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600156D RID: 5485 RVA: 0x0002440C File Offset: 0x0002260C
		public new vtkInteractorStyleTrackballCamera NewInstance()
		{
			vtkInteractorStyleTrackballCamera result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleTrackballCamera.vtkInteractorStyleTrackballCamera_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleTrackballCamera)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600156E RID: 5486
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleTrackballCamera_OnLeftButtonDown_10(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600156F RID: 5487 RVA: 0x00024466 File Offset: 0x00022666
		public override void OnLeftButtonDown()
		{
			vtkInteractorStyleTrackballCamera.vtkInteractorStyleTrackballCamera_OnLeftButtonDown_10(base.GetCppThis());
		}

		// Token: 0x06001570 RID: 5488
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleTrackballCamera_OnLeftButtonUp_11(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x06001571 RID: 5489 RVA: 0x00024475 File Offset: 0x00022675
		public override void OnLeftButtonUp()
		{
			vtkInteractorStyleTrackballCamera.vtkInteractorStyleTrackballCamera_OnLeftButtonUp_11(base.GetCppThis());
		}

		// Token: 0x06001572 RID: 5490
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleTrackballCamera_OnMiddleButtonDown_12(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x06001573 RID: 5491 RVA: 0x00024484 File Offset: 0x00022684
		public override void OnMiddleButtonDown()
		{
			vtkInteractorStyleTrackballCamera.vtkInteractorStyleTrackballCamera_OnMiddleButtonDown_12(base.GetCppThis());
		}

		// Token: 0x06001574 RID: 5492
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleTrackballCamera_OnMiddleButtonUp_13(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x06001575 RID: 5493 RVA: 0x00024493 File Offset: 0x00022693
		public override void OnMiddleButtonUp()
		{
			vtkInteractorStyleTrackballCamera.vtkInteractorStyleTrackballCamera_OnMiddleButtonUp_13(base.GetCppThis());
		}

		// Token: 0x06001576 RID: 5494
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleTrackballCamera_OnMouseMove_14(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x06001577 RID: 5495 RVA: 0x000244A2 File Offset: 0x000226A2
		public override void OnMouseMove()
		{
			vtkInteractorStyleTrackballCamera.vtkInteractorStyleTrackballCamera_OnMouseMove_14(base.GetCppThis());
		}

		// Token: 0x06001578 RID: 5496
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleTrackballCamera_OnMouseWheelBackward_15(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x06001579 RID: 5497 RVA: 0x000244B1 File Offset: 0x000226B1
		public override void OnMouseWheelBackward()
		{
			vtkInteractorStyleTrackballCamera.vtkInteractorStyleTrackballCamera_OnMouseWheelBackward_15(base.GetCppThis());
		}

		// Token: 0x0600157A RID: 5498
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleTrackballCamera_OnMouseWheelForward_16(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600157B RID: 5499 RVA: 0x000244C0 File Offset: 0x000226C0
		public override void OnMouseWheelForward()
		{
			vtkInteractorStyleTrackballCamera.vtkInteractorStyleTrackballCamera_OnMouseWheelForward_16(base.GetCppThis());
		}

		// Token: 0x0600157C RID: 5500
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleTrackballCamera_OnRightButtonDown_17(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600157D RID: 5501 RVA: 0x000244CF File Offset: 0x000226CF
		public override void OnRightButtonDown()
		{
			vtkInteractorStyleTrackballCamera.vtkInteractorStyleTrackballCamera_OnRightButtonDown_17(base.GetCppThis());
		}

		// Token: 0x0600157E RID: 5502
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleTrackballCamera_OnRightButtonUp_18(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600157F RID: 5503 RVA: 0x000244DE File Offset: 0x000226DE
		public override void OnRightButtonUp()
		{
			vtkInteractorStyleTrackballCamera.vtkInteractorStyleTrackballCamera_OnRightButtonUp_18(base.GetCppThis());
		}

		// Token: 0x06001580 RID: 5504
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleTrackballCamera_Pan_19(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x06001581 RID: 5505 RVA: 0x000244ED File Offset: 0x000226ED
		public override void Pan()
		{
			vtkInteractorStyleTrackballCamera.vtkInteractorStyleTrackballCamera_Pan_19(base.GetCppThis());
		}

		// Token: 0x06001582 RID: 5506
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleTrackballCamera_Rotate_20(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x06001583 RID: 5507 RVA: 0x000244FC File Offset: 0x000226FC
		public override void Rotate()
		{
			vtkInteractorStyleTrackballCamera.vtkInteractorStyleTrackballCamera_Rotate_20(base.GetCppThis());
		}

		// Token: 0x06001584 RID: 5508
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleTrackballCamera_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001585 RID: 5509 RVA: 0x0002450C File Offset: 0x0002270C
		public new static vtkInteractorStyleTrackballCamera SafeDownCast(vtkObjectBase o)
		{
			vtkInteractorStyleTrackballCamera vtkInteractorStyleTrackballCamera = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleTrackballCamera.vtkInteractorStyleTrackballCamera_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInteractorStyleTrackballCamera = (vtkInteractorStyleTrackballCamera)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInteractorStyleTrackballCamera.Register(null);
				}
			}
			return vtkInteractorStyleTrackballCamera;
		}

		// Token: 0x06001586 RID: 5510
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleTrackballCamera_SetMotionFactor_22(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the apparent sensitivity of the interactor style to mouse motion.
		/// </summary>
		// Token: 0x06001587 RID: 5511 RVA: 0x0002458B File Offset: 0x0002278B
		public virtual void SetMotionFactor(double _arg)
		{
			vtkInteractorStyleTrackballCamera.vtkInteractorStyleTrackballCamera_SetMotionFactor_22(base.GetCppThis(), _arg);
		}

		// Token: 0x06001588 RID: 5512
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleTrackballCamera_Spin_23(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x06001589 RID: 5513 RVA: 0x0002459B File Offset: 0x0002279B
		public override void Spin()
		{
			vtkInteractorStyleTrackballCamera.vtkInteractorStyleTrackballCamera_Spin_23(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400047C RID: 1148
		public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleTrackballCamera";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400047D RID: 1149
		public new static readonly string MRClassNameKey = "class vtkInteractorStyleTrackballCamera";
	}
}
