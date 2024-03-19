using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInteractorStyleUser
	/// </summary>
	/// <remarks>
	///    provides customizable interaction routines
	///
	///
	/// The most common way to customize user interaction is to write a subclass
	/// of vtkInteractorStyle: vtkInteractorStyleUser allows you to customize
	/// the interaction to without subclassing vtkInteractorStyle.  This is
	/// particularly useful for setting up custom interaction modes in
	/// scripting languages such as Python.  This class allows you
	/// to hook into the MouseMove, ButtonPress/Release, KeyPress/Release,
	/// etc. events.  If you want to hook into just a single mouse button,
	/// but leave the interaction modes for the others unchanged, you
	/// must use e.g. SetMiddleButtonPressMethod() instead of the more
	/// general SetButtonPressMethod().
	/// </remarks>
	// Token: 0x0200040A RID: 1034
	public class vtkInteractorStyleUser : vtkInteractorStyle
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C425 RID: 50213 RVA: 0x00110DF1 File Offset: 0x0010EFF1
		static vtkInteractorStyleUser()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInteractorStyleUser.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleUser"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C426 RID: 50214 RVA: 0x00110E19 File Offset: 0x0010F019
		public vtkInteractorStyleUser(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C427 RID: 50215
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleUser_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C428 RID: 50216 RVA: 0x00110E28 File Offset: 0x0010F028
		public new static vtkInteractorStyleUser New()
		{
			vtkInteractorStyleUser result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleUser.vtkInteractorStyleUser_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleUser)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C429 RID: 50217 RVA: 0x00110E7C File Offset: 0x0010F07C
		public vtkInteractorStyleUser() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkInteractorStyleUser.vtkInteractorStyleUser_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C42A RID: 50218 RVA: 0x00110EC0 File Offset: 0x0010F0C0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C42B RID: 50219
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyleUser_GetButton_01(HandleRef pThis);

		/// <summary>
		/// Get the mouse button that was last pressed inside the window
		/// (returns zero when the button is released).
		/// </summary>
		// Token: 0x0600C42C RID: 50220 RVA: 0x00110ECC File Offset: 0x0010F0CC
		public virtual int GetButton()
		{
			return vtkInteractorStyleUser.vtkInteractorStyleUser_GetButton_01(base.GetCppThis());
		}

		// Token: 0x0600C42D RID: 50221
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyleUser_GetChar_02(HandleRef pThis);

		/// <summary>
		/// Get the character for a Char event.
		/// </summary>
		// Token: 0x0600C42E RID: 50222 RVA: 0x00110EEC File Offset: 0x0010F0EC
		public virtual int GetChar()
		{
			return vtkInteractorStyleUser.vtkInteractorStyleUser_GetChar_02(base.GetCppThis());
		}

		// Token: 0x0600C42F RID: 50223
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyleUser_GetCtrlKey_03(HandleRef pThis);

		/// <summary>
		/// Test whether modifiers were held down when mouse button or key
		/// was pressed.
		/// </summary>
		// Token: 0x0600C430 RID: 50224 RVA: 0x00110F0C File Offset: 0x0010F10C
		public virtual int GetCtrlKey()
		{
			return vtkInteractorStyleUser.vtkInteractorStyleUser_GetCtrlKey_03(base.GetCppThis());
		}

		// Token: 0x0600C431 RID: 50225
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleUser_GetKeySym_04(HandleRef pThis);

		/// <summary>
		/// Get the KeySym (in the same format as vtkRenderWindowInteractor KeySyms)
		/// for a KeyPress or KeyRelease method.
		/// </summary>
		// Token: 0x0600C432 RID: 50226 RVA: 0x00110F2C File Offset: 0x0010F12C
		public virtual string GetKeySym()
		{
			string s = Marshal.PtrToStringAnsi(vtkInteractorStyleUser.vtkInteractorStyleUser_GetKeySym_04(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600C433 RID: 50227
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleUser_GetLastPos_05(HandleRef pThis);

		/// <summary>
		/// Get the most recent mouse position during mouse motion.
		/// In your user interaction method, you must use this to track
		/// the mouse movement.  Do not use GetEventPosition(), which records
		/// the last position where a mouse button was pressed.
		/// </summary>
		// Token: 0x0600C434 RID: 50228 RVA: 0x00110F68 File Offset: 0x0010F168
		public virtual int[] GetLastPos()
		{
			IntPtr intPtr = vtkInteractorStyleUser.vtkInteractorStyleUser_GetLastPos_05(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600C435 RID: 50229
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleUser_GetLastPos_06(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Get the most recent mouse position during mouse motion.
		/// In your user interaction method, you must use this to track
		/// the mouse movement.  Do not use GetEventPosition(), which records
		/// the last position where a mouse button was pressed.
		/// </summary>
		// Token: 0x0600C436 RID: 50230 RVA: 0x00110FB0 File Offset: 0x0010F1B0
		public virtual void GetLastPos(ref int _arg1, ref int _arg2)
		{
			vtkInteractorStyleUser.vtkInteractorStyleUser_GetLastPos_06(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x0600C437 RID: 50231
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleUser_GetLastPos_07(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get the most recent mouse position during mouse motion.
		/// In your user interaction method, you must use this to track
		/// the mouse movement.  Do not use GetEventPosition(), which records
		/// the last position where a mouse button was pressed.
		/// </summary>
		// Token: 0x0600C438 RID: 50232 RVA: 0x00110FC1 File Offset: 0x0010F1C1
		public virtual void GetLastPos(IntPtr _arg)
		{
			vtkInteractorStyleUser.vtkInteractorStyleUser_GetLastPos_07(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C439 RID: 50233
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInteractorStyleUser_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C43A RID: 50234 RVA: 0x00110FD4 File Offset: 0x0010F1D4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInteractorStyleUser.vtkInteractorStyleUser_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x0600C43B RID: 50235
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInteractorStyleUser_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C43C RID: 50236 RVA: 0x00110FF4 File Offset: 0x0010F1F4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInteractorStyleUser.vtkInteractorStyleUser_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x0600C43D RID: 50237
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleUser_GetOldPos_10(HandleRef pThis);

		/// <summary>
		/// Get the previous mouse position during mouse motion, or after
		/// a key press.  This can be used to calculate the relative
		/// displacement of the mouse.
		/// </summary>
		// Token: 0x0600C43E RID: 50238 RVA: 0x00111010 File Offset: 0x0010F210
		public virtual int[] GetOldPos()
		{
			IntPtr intPtr = vtkInteractorStyleUser.vtkInteractorStyleUser_GetOldPos_10(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600C43F RID: 50239
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleUser_GetOldPos_11(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Get the previous mouse position during mouse motion, or after
		/// a key press.  This can be used to calculate the relative
		/// displacement of the mouse.
		/// </summary>
		// Token: 0x0600C440 RID: 50240 RVA: 0x00111058 File Offset: 0x0010F258
		public virtual void GetOldPos(ref int _arg1, ref int _arg2)
		{
			vtkInteractorStyleUser.vtkInteractorStyleUser_GetOldPos_11(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x0600C441 RID: 50241
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleUser_GetOldPos_12(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get the previous mouse position during mouse motion, or after
		/// a key press.  This can be used to calculate the relative
		/// displacement of the mouse.
		/// </summary>
		// Token: 0x0600C442 RID: 50242 RVA: 0x00111069 File Offset: 0x0010F269
		public virtual void GetOldPos(IntPtr _arg)
		{
			vtkInteractorStyleUser.vtkInteractorStyleUser_GetOldPos_12(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C443 RID: 50243
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyleUser_GetShiftKey_13(HandleRef pThis);

		/// <summary>
		/// Test whether modifiers were held down when mouse button or key
		/// was pressed.
		/// </summary>
		// Token: 0x0600C444 RID: 50244 RVA: 0x0011107C File Offset: 0x0010F27C
		public virtual int GetShiftKey()
		{
			return vtkInteractorStyleUser.vtkInteractorStyleUser_GetShiftKey_13(base.GetCppThis());
		}

		// Token: 0x0600C445 RID: 50245
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyleUser_IsA_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C446 RID: 50246 RVA: 0x0011109C File Offset: 0x0010F29C
		public override int IsA(string type)
		{
			return vtkInteractorStyleUser.vtkInteractorStyleUser_IsA_14(base.GetCppThis(), type);
		}

		// Token: 0x0600C447 RID: 50247
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyleUser_IsTypeOf_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C448 RID: 50248 RVA: 0x001110BC File Offset: 0x0010F2BC
		public new static int IsTypeOf(string type)
		{
			return vtkInteractorStyleUser.vtkInteractorStyleUser_IsTypeOf_15(type);
		}

		// Token: 0x0600C449 RID: 50249
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleUser_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C44A RID: 50250 RVA: 0x001110D8 File Offset: 0x0010F2D8
		public new vtkInteractorStyleUser NewInstance()
		{
			vtkInteractorStyleUser result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleUser.vtkInteractorStyleUser_NewInstance_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleUser)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C44B RID: 50251
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleUser_OnChar_18(HandleRef pThis);

		/// <summary>
		/// Keyboard functions
		/// </summary>
		// Token: 0x0600C44C RID: 50252 RVA: 0x00111132 File Offset: 0x0010F332
		public override void OnChar()
		{
			vtkInteractorStyleUser.vtkInteractorStyleUser_OnChar_18(base.GetCppThis());
		}

		// Token: 0x0600C44D RID: 50253
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleUser_OnConfigure_19(HandleRef pThis);

		/// <summary>
		/// These are more esoteric events, but are useful in some cases.
		/// </summary>
		// Token: 0x0600C44E RID: 50254 RVA: 0x00111141 File Offset: 0x0010F341
		public override void OnConfigure()
		{
			vtkInteractorStyleUser.vtkInteractorStyleUser_OnConfigure_19(base.GetCppThis());
		}

		// Token: 0x0600C44F RID: 50255
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleUser_OnEnter_20(HandleRef pThis);

		/// <summary>
		/// These are more esoteric events, but are useful in some cases.
		/// </summary>
		// Token: 0x0600C450 RID: 50256 RVA: 0x00111150 File Offset: 0x0010F350
		public override void OnEnter()
		{
			vtkInteractorStyleUser.vtkInteractorStyleUser_OnEnter_20(base.GetCppThis());
		}

		// Token: 0x0600C451 RID: 50257
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleUser_OnExpose_21(HandleRef pThis);

		/// <summary>
		/// These are more esoteric events, but are useful in some cases.
		/// </summary>
		// Token: 0x0600C452 RID: 50258 RVA: 0x0011115F File Offset: 0x0010F35F
		public override void OnExpose()
		{
			vtkInteractorStyleUser.vtkInteractorStyleUser_OnExpose_21(base.GetCppThis());
		}

		// Token: 0x0600C453 RID: 50259
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleUser_OnKeyPress_22(HandleRef pThis);

		/// <summary>
		/// Keyboard functions
		/// </summary>
		// Token: 0x0600C454 RID: 50260 RVA: 0x0011116E File Offset: 0x0010F36E
		public override void OnKeyPress()
		{
			vtkInteractorStyleUser.vtkInteractorStyleUser_OnKeyPress_22(base.GetCppThis());
		}

		// Token: 0x0600C455 RID: 50261
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleUser_OnKeyRelease_23(HandleRef pThis);

		/// <summary>
		/// Keyboard functions
		/// </summary>
		// Token: 0x0600C456 RID: 50262 RVA: 0x0011117D File Offset: 0x0010F37D
		public override void OnKeyRelease()
		{
			vtkInteractorStyleUser.vtkInteractorStyleUser_OnKeyRelease_23(base.GetCppThis());
		}

		// Token: 0x0600C457 RID: 50263
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleUser_OnLeave_24(HandleRef pThis);

		/// <summary>
		/// These are more esoteric events, but are useful in some cases.
		/// </summary>
		// Token: 0x0600C458 RID: 50264 RVA: 0x0011118C File Offset: 0x0010F38C
		public override void OnLeave()
		{
			vtkInteractorStyleUser.vtkInteractorStyleUser_OnLeave_24(base.GetCppThis());
		}

		// Token: 0x0600C459 RID: 50265
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleUser_OnLeftButtonDown_25(HandleRef pThis);

		/// <summary>
		/// Generic event bindings
		/// </summary>
		// Token: 0x0600C45A RID: 50266 RVA: 0x0011119B File Offset: 0x0010F39B
		public override void OnLeftButtonDown()
		{
			vtkInteractorStyleUser.vtkInteractorStyleUser_OnLeftButtonDown_25(base.GetCppThis());
		}

		// Token: 0x0600C45B RID: 50267
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleUser_OnLeftButtonUp_26(HandleRef pThis);

		/// <summary>
		/// Generic event bindings
		/// </summary>
		// Token: 0x0600C45C RID: 50268 RVA: 0x001111AA File Offset: 0x0010F3AA
		public override void OnLeftButtonUp()
		{
			vtkInteractorStyleUser.vtkInteractorStyleUser_OnLeftButtonUp_26(base.GetCppThis());
		}

		// Token: 0x0600C45D RID: 50269
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleUser_OnMiddleButtonDown_27(HandleRef pThis);

		/// <summary>
		/// Generic event bindings
		/// </summary>
		// Token: 0x0600C45E RID: 50270 RVA: 0x001111B9 File Offset: 0x0010F3B9
		public override void OnMiddleButtonDown()
		{
			vtkInteractorStyleUser.vtkInteractorStyleUser_OnMiddleButtonDown_27(base.GetCppThis());
		}

		// Token: 0x0600C45F RID: 50271
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleUser_OnMiddleButtonUp_28(HandleRef pThis);

		/// <summary>
		/// Generic event bindings
		/// </summary>
		// Token: 0x0600C460 RID: 50272 RVA: 0x001111C8 File Offset: 0x0010F3C8
		public override void OnMiddleButtonUp()
		{
			vtkInteractorStyleUser.vtkInteractorStyleUser_OnMiddleButtonUp_28(base.GetCppThis());
		}

		// Token: 0x0600C461 RID: 50273
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleUser_OnMouseMove_29(HandleRef pThis);

		/// <summary>
		/// Generic event bindings
		/// </summary>
		// Token: 0x0600C462 RID: 50274 RVA: 0x001111D7 File Offset: 0x0010F3D7
		public override void OnMouseMove()
		{
			vtkInteractorStyleUser.vtkInteractorStyleUser_OnMouseMove_29(base.GetCppThis());
		}

		// Token: 0x0600C463 RID: 50275
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleUser_OnMouseWheelBackward_30(HandleRef pThis);

		/// <summary>
		/// Generic event bindings
		/// </summary>
		// Token: 0x0600C464 RID: 50276 RVA: 0x001111E6 File Offset: 0x0010F3E6
		public override void OnMouseWheelBackward()
		{
			vtkInteractorStyleUser.vtkInteractorStyleUser_OnMouseWheelBackward_30(base.GetCppThis());
		}

		// Token: 0x0600C465 RID: 50277
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleUser_OnMouseWheelForward_31(HandleRef pThis);

		/// <summary>
		/// Generic event bindings
		/// </summary>
		// Token: 0x0600C466 RID: 50278 RVA: 0x001111F5 File Offset: 0x0010F3F5
		public override void OnMouseWheelForward()
		{
			vtkInteractorStyleUser.vtkInteractorStyleUser_OnMouseWheelForward_31(base.GetCppThis());
		}

		// Token: 0x0600C467 RID: 50279
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleUser_OnRightButtonDown_32(HandleRef pThis);

		/// <summary>
		/// Generic event bindings
		/// </summary>
		// Token: 0x0600C468 RID: 50280 RVA: 0x00111204 File Offset: 0x0010F404
		public override void OnRightButtonDown()
		{
			vtkInteractorStyleUser.vtkInteractorStyleUser_OnRightButtonDown_32(base.GetCppThis());
		}

		// Token: 0x0600C469 RID: 50281
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleUser_OnRightButtonUp_33(HandleRef pThis);

		/// <summary>
		/// Generic event bindings
		/// </summary>
		// Token: 0x0600C46A RID: 50282 RVA: 0x00111213 File Offset: 0x0010F413
		public override void OnRightButtonUp()
		{
			vtkInteractorStyleUser.vtkInteractorStyleUser_OnRightButtonUp_33(base.GetCppThis());
		}

		// Token: 0x0600C46B RID: 50283
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleUser_OnTimer_34(HandleRef pThis);

		/// <summary>
		/// These are more esoteric events, but are useful in some cases.
		/// </summary>
		// Token: 0x0600C46C RID: 50284 RVA: 0x00111222 File Offset: 0x0010F422
		public override void OnTimer()
		{
			vtkInteractorStyleUser.vtkInteractorStyleUser_OnTimer_34(base.GetCppThis());
		}

		// Token: 0x0600C46D RID: 50285
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleUser_SafeDownCast_35(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C46E RID: 50286 RVA: 0x00111234 File Offset: 0x0010F434
		public new static vtkInteractorStyleUser SafeDownCast(vtkObjectBase o)
		{
			vtkInteractorStyleUser vtkInteractorStyleUser = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleUser.vtkInteractorStyleUser_SafeDownCast_35((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInteractorStyleUser = (vtkInteractorStyleUser)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInteractorStyleUser.Register(null);
				}
			}
			return vtkInteractorStyleUser;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E8C RID: 3724
		public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleUser";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E8D RID: 3725
		public new static readonly string MRClassNameKey = "class vtkInteractorStyleUser";
	}
}
