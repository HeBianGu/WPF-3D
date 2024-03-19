using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInteractorStyleSwitch
	/// </summary>
	/// <remarks>
	///    class to swap between interactory styles
	///
	/// The class vtkInteractorStyleSwitch allows handles interactively switching
	/// between four interactor styles -- joystick actor, joystick camera,
	/// trackball actor, and trackball camera.  Type 'j' or 't' to select
	/// joystick or trackball, and type 'c' or 'a' to select camera or actor.
	/// The default interactor style is joystick camera.
	/// </remarks>
	/// <seealso>
	///
	/// vtkInteractorStyleJoystickActor vtkInteractorStyleJoystickCamera
	/// vtkInteractorStyleTrackballActor vtkInteractorStyleTrackballCamera
	/// </seealso>
	// Token: 0x02000404 RID: 1028
	public class vtkInteractorStyleSwitch : vtkInteractorStyleSwitchBase
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C39D RID: 50077 RVA: 0x0011024B File Offset: 0x0010E44B
		static vtkInteractorStyleSwitch()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInteractorStyleSwitch.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleSwitch"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C39E RID: 50078 RVA: 0x00110273 File Offset: 0x0010E473
		public vtkInteractorStyleSwitch(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C39F RID: 50079
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleSwitch_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C3A0 RID: 50080 RVA: 0x00110284 File Offset: 0x0010E484
		public new static vtkInteractorStyleSwitch New()
		{
			vtkInteractorStyleSwitch result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleSwitch.vtkInteractorStyleSwitch_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleSwitch)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C3A1 RID: 50081 RVA: 0x001102D8 File Offset: 0x0010E4D8
		public vtkInteractorStyleSwitch() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkInteractorStyleSwitch.vtkInteractorStyleSwitch_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C3A2 RID: 50082 RVA: 0x0011031C File Offset: 0x0010E51C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C3A3 RID: 50083
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleSwitch_GetCurrentStyle_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get current style
		/// </summary>
		// Token: 0x0600C3A4 RID: 50084 RVA: 0x00110328 File Offset: 0x0010E528
		public virtual vtkInteractorStyle GetCurrentStyle()
		{
			vtkInteractorStyle vtkInteractorStyle = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleSwitch.vtkInteractorStyleSwitch_GetCurrentStyle_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInteractorStyle = (vtkInteractorStyle)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInteractorStyle.Register(null);
				}
			}
			return vtkInteractorStyle;
		}

		// Token: 0x0600C3A5 RID: 50085
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInteractorStyleSwitch_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C3A6 RID: 50086 RVA: 0x00110398 File Offset: 0x0010E598
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInteractorStyleSwitch.vtkInteractorStyleSwitch_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600C3A7 RID: 50087
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInteractorStyleSwitch_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C3A8 RID: 50088 RVA: 0x001103B8 File Offset: 0x0010E5B8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInteractorStyleSwitch.vtkInteractorStyleSwitch_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600C3A9 RID: 50089
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyleSwitch_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C3AA RID: 50090 RVA: 0x001103D4 File Offset: 0x0010E5D4
		public override int IsA(string type)
		{
			return vtkInteractorStyleSwitch.vtkInteractorStyleSwitch_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600C3AB RID: 50091
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyleSwitch_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C3AC RID: 50092 RVA: 0x001103F4 File Offset: 0x0010E5F4
		public new static int IsTypeOf(string type)
		{
			return vtkInteractorStyleSwitch.vtkInteractorStyleSwitch_IsTypeOf_05(type);
		}

		// Token: 0x0600C3AD RID: 50093
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleSwitch_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C3AE RID: 50094 RVA: 0x00110410 File Offset: 0x0010E610
		public new vtkInteractorStyleSwitch NewInstance()
		{
			vtkInteractorStyleSwitch result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleSwitch.vtkInteractorStyleSwitch_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleSwitch)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C3AF RID: 50095
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleSwitch_OnChar_08(HandleRef pThis);

		/// <summary>
		/// Only care about the char event, which is used to switch between
		/// different styles.
		/// </summary>
		// Token: 0x0600C3B0 RID: 50096 RVA: 0x0011046A File Offset: 0x0010E66A
		public override void OnChar()
		{
			vtkInteractorStyleSwitch.vtkInteractorStyleSwitch_OnChar_08(base.GetCppThis());
		}

		// Token: 0x0600C3B1 RID: 50097
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleSwitch_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C3B2 RID: 50098 RVA: 0x0011047C File Offset: 0x0010E67C
		public new static vtkInteractorStyleSwitch SafeDownCast(vtkObjectBase o)
		{
			vtkInteractorStyleSwitch vtkInteractorStyleSwitch = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleSwitch.vtkInteractorStyleSwitch_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInteractorStyleSwitch = (vtkInteractorStyleSwitch)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInteractorStyleSwitch.Register(null);
				}
			}
			return vtkInteractorStyleSwitch;
		}

		// Token: 0x0600C3B3 RID: 50099
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleSwitch_SetAutoAdjustCameraClippingRange_10(HandleRef pThis, int value);

		/// <summary>
		/// We must override this method in order to pass the setting down to
		/// the underlying styles
		/// </summary>
		// Token: 0x0600C3B4 RID: 50100 RVA: 0x001104FB File Offset: 0x0010E6FB
		public override void SetAutoAdjustCameraClippingRange(int value)
		{
			vtkInteractorStyleSwitch.vtkInteractorStyleSwitch_SetAutoAdjustCameraClippingRange_10(base.GetCppThis(), value);
		}

		// Token: 0x0600C3B5 RID: 50101
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleSwitch_SetCurrentRenderer_11(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Overridden from vtkInteractorObserver because the interactor styles
		/// used by this class must also be updated.
		/// </summary>
		// Token: 0x0600C3B6 RID: 50102 RVA: 0x0011050C File Offset: 0x0010E70C
		public override void SetCurrentRenderer(vtkRenderer arg0)
		{
			vtkInteractorStyleSwitch.vtkInteractorStyleSwitch_SetCurrentRenderer_11(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600C3B7 RID: 50103
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleSwitch_SetCurrentStyleToJoystickActor_12(HandleRef pThis);

		/// <summary>
		/// Set/Get current style
		/// </summary>
		// Token: 0x0600C3B8 RID: 50104 RVA: 0x0011053B File Offset: 0x0010E73B
		public void SetCurrentStyleToJoystickActor()
		{
			vtkInteractorStyleSwitch.vtkInteractorStyleSwitch_SetCurrentStyleToJoystickActor_12(base.GetCppThis());
		}

		// Token: 0x0600C3B9 RID: 50105
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleSwitch_SetCurrentStyleToJoystickCamera_13(HandleRef pThis);

		/// <summary>
		/// Set/Get current style
		/// </summary>
		// Token: 0x0600C3BA RID: 50106 RVA: 0x0011054A File Offset: 0x0010E74A
		public void SetCurrentStyleToJoystickCamera()
		{
			vtkInteractorStyleSwitch.vtkInteractorStyleSwitch_SetCurrentStyleToJoystickCamera_13(base.GetCppThis());
		}

		// Token: 0x0600C3BB RID: 50107
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleSwitch_SetCurrentStyleToMultiTouchCamera_14(HandleRef pThis);

		/// <summary>
		/// Set/Get current style
		/// </summary>
		// Token: 0x0600C3BC RID: 50108 RVA: 0x00110559 File Offset: 0x0010E759
		public void SetCurrentStyleToMultiTouchCamera()
		{
			vtkInteractorStyleSwitch.vtkInteractorStyleSwitch_SetCurrentStyleToMultiTouchCamera_14(base.GetCppThis());
		}

		// Token: 0x0600C3BD RID: 50109
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleSwitch_SetCurrentStyleToTrackballActor_15(HandleRef pThis);

		/// <summary>
		/// Set/Get current style
		/// </summary>
		// Token: 0x0600C3BE RID: 50110 RVA: 0x00110568 File Offset: 0x0010E768
		public void SetCurrentStyleToTrackballActor()
		{
			vtkInteractorStyleSwitch.vtkInteractorStyleSwitch_SetCurrentStyleToTrackballActor_15(base.GetCppThis());
		}

		// Token: 0x0600C3BF RID: 50111
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleSwitch_SetCurrentStyleToTrackballCamera_16(HandleRef pThis);

		/// <summary>
		/// Set/Get current style
		/// </summary>
		// Token: 0x0600C3C0 RID: 50112 RVA: 0x00110577 File Offset: 0x0010E777
		public void SetCurrentStyleToTrackballCamera()
		{
			vtkInteractorStyleSwitch.vtkInteractorStyleSwitch_SetCurrentStyleToTrackballCamera_16(base.GetCppThis());
		}

		// Token: 0x0600C3C1 RID: 50113
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleSwitch_SetDefaultRenderer_17(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Overridden from vtkInteractorObserver because the interactor styles
		/// used by this class must also be updated.
		/// </summary>
		// Token: 0x0600C3C2 RID: 50114 RVA: 0x00110588 File Offset: 0x0010E788
		public override void SetDefaultRenderer(vtkRenderer arg0)
		{
			vtkInteractorStyleSwitch.vtkInteractorStyleSwitch_SetDefaultRenderer_17(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600C3C3 RID: 50115
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleSwitch_SetInteractor_18(HandleRef pThis, HandleRef iren);

		/// <summary>
		/// The sub styles need the interactor too.
		/// </summary>
		// Token: 0x0600C3C4 RID: 50116 RVA: 0x001105B8 File Offset: 0x0010E7B8
		public override void SetInteractor(vtkRenderWindowInteractor iren)
		{
			vtkInteractorStyleSwitch.vtkInteractorStyleSwitch_SetInteractor_18(base.GetCppThis(), (iren == null) ? default(HandleRef) : iren.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E7A RID: 3706
		public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleSwitch";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E7B RID: 3707
		public new static readonly string MRClassNameKey = "class vtkInteractorStyleSwitch";
	}
}
