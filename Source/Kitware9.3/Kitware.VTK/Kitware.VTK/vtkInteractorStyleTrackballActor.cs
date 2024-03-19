using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInteractorStyleTrackballActor
	/// </summary>
	/// <remarks>
	///    manipulate objects in the scene independent of each other
	///
	/// vtkInteractorStyleTrackballActor allows the user to interact with (rotate,
	/// pan, etc.) objects in the scene independent of each other.  In trackball
	/// interaction, the magnitude of the mouse motion is proportional to the
	/// actor motion associated with a particular mouse binding. For example,
	/// small left-button motions cause small changes in the rotation of the
	/// actor around its center point.
	///
	/// The mouse bindings are as follows. For a 3-button mouse, the left button
	/// is for rotation, the right button for zooming, the middle button for
	/// panning, and ctrl + left button for spinning.  (With fewer mouse buttons,
	/// ctrl + shift + left button is for zooming, and shift + left button is for
	/// panning.)
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkInteractorStyleTrackballCamera vtkInteractorStyleJoystickActor
	/// vtkInteractorStyleJoystickCamera
	/// </seealso>
	// Token: 0x02000406 RID: 1030
	public class vtkInteractorStyleTrackballActor : vtkInteractorStyle
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C3D7 RID: 50135 RVA: 0x00110817 File Offset: 0x0010EA17
		static vtkInteractorStyleTrackballActor()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInteractorStyleTrackballActor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleTrackballActor"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C3D8 RID: 50136 RVA: 0x0011083F File Offset: 0x0010EA3F
		public vtkInteractorStyleTrackballActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C3D9 RID: 50137
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleTrackballActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C3DA RID: 50138 RVA: 0x00110850 File Offset: 0x0010EA50
		public new static vtkInteractorStyleTrackballActor New()
		{
			vtkInteractorStyleTrackballActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleTrackballActor.vtkInteractorStyleTrackballActor_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleTrackballActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C3DB RID: 50139 RVA: 0x001108A4 File Offset: 0x0010EAA4
		public vtkInteractorStyleTrackballActor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkInteractorStyleTrackballActor.vtkInteractorStyleTrackballActor_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C3DC RID: 50140 RVA: 0x001108E8 File Offset: 0x0010EAE8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C3DD RID: 50141
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleTrackballActor_Dolly_01(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C3DE RID: 50142 RVA: 0x001108F3 File Offset: 0x0010EAF3
		public override void Dolly()
		{
			vtkInteractorStyleTrackballActor.vtkInteractorStyleTrackballActor_Dolly_01(base.GetCppThis());
		}

		// Token: 0x0600C3DF RID: 50143
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInteractorStyleTrackballActor_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C3E0 RID: 50144 RVA: 0x00110904 File Offset: 0x0010EB04
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInteractorStyleTrackballActor.vtkInteractorStyleTrackballActor_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600C3E1 RID: 50145
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInteractorStyleTrackballActor_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C3E2 RID: 50146 RVA: 0x00110924 File Offset: 0x0010EB24
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInteractorStyleTrackballActor.vtkInteractorStyleTrackballActor_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600C3E3 RID: 50147
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyleTrackballActor_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C3E4 RID: 50148 RVA: 0x00110940 File Offset: 0x0010EB40
		public override int IsA(string type)
		{
			return vtkInteractorStyleTrackballActor.vtkInteractorStyleTrackballActor_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600C3E5 RID: 50149
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyleTrackballActor_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C3E6 RID: 50150 RVA: 0x00110960 File Offset: 0x0010EB60
		public new static int IsTypeOf(string type)
		{
			return vtkInteractorStyleTrackballActor.vtkInteractorStyleTrackballActor_IsTypeOf_05(type);
		}

		// Token: 0x0600C3E7 RID: 50151
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleTrackballActor_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C3E8 RID: 50152 RVA: 0x0011097C File Offset: 0x0010EB7C
		public new vtkInteractorStyleTrackballActor NewInstance()
		{
			vtkInteractorStyleTrackballActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleTrackballActor.vtkInteractorStyleTrackballActor_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleTrackballActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C3E9 RID: 50153
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleTrackballActor_OnLeftButtonDown_08(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C3EA RID: 50154 RVA: 0x001109D6 File Offset: 0x0010EBD6
		public override void OnLeftButtonDown()
		{
			vtkInteractorStyleTrackballActor.vtkInteractorStyleTrackballActor_OnLeftButtonDown_08(base.GetCppThis());
		}

		// Token: 0x0600C3EB RID: 50155
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleTrackballActor_OnLeftButtonUp_09(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C3EC RID: 50156 RVA: 0x001109E5 File Offset: 0x0010EBE5
		public override void OnLeftButtonUp()
		{
			vtkInteractorStyleTrackballActor.vtkInteractorStyleTrackballActor_OnLeftButtonUp_09(base.GetCppThis());
		}

		// Token: 0x0600C3ED RID: 50157
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleTrackballActor_OnMiddleButtonDown_10(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C3EE RID: 50158 RVA: 0x001109F4 File Offset: 0x0010EBF4
		public override void OnMiddleButtonDown()
		{
			vtkInteractorStyleTrackballActor.vtkInteractorStyleTrackballActor_OnMiddleButtonDown_10(base.GetCppThis());
		}

		// Token: 0x0600C3EF RID: 50159
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleTrackballActor_OnMiddleButtonUp_11(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C3F0 RID: 50160 RVA: 0x00110A03 File Offset: 0x0010EC03
		public override void OnMiddleButtonUp()
		{
			vtkInteractorStyleTrackballActor.vtkInteractorStyleTrackballActor_OnMiddleButtonUp_11(base.GetCppThis());
		}

		// Token: 0x0600C3F1 RID: 50161
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleTrackballActor_OnMouseMove_12(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C3F2 RID: 50162 RVA: 0x00110A12 File Offset: 0x0010EC12
		public override void OnMouseMove()
		{
			vtkInteractorStyleTrackballActor.vtkInteractorStyleTrackballActor_OnMouseMove_12(base.GetCppThis());
		}

		// Token: 0x0600C3F3 RID: 50163
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleTrackballActor_OnRightButtonDown_13(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C3F4 RID: 50164 RVA: 0x00110A21 File Offset: 0x0010EC21
		public override void OnRightButtonDown()
		{
			vtkInteractorStyleTrackballActor.vtkInteractorStyleTrackballActor_OnRightButtonDown_13(base.GetCppThis());
		}

		// Token: 0x0600C3F5 RID: 50165
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleTrackballActor_OnRightButtonUp_14(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C3F6 RID: 50166 RVA: 0x00110A30 File Offset: 0x0010EC30
		public override void OnRightButtonUp()
		{
			vtkInteractorStyleTrackballActor.vtkInteractorStyleTrackballActor_OnRightButtonUp_14(base.GetCppThis());
		}

		// Token: 0x0600C3F7 RID: 50167
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleTrackballActor_Pan_15(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C3F8 RID: 50168 RVA: 0x00110A3F File Offset: 0x0010EC3F
		public override void Pan()
		{
			vtkInteractorStyleTrackballActor.vtkInteractorStyleTrackballActor_Pan_15(base.GetCppThis());
		}

		// Token: 0x0600C3F9 RID: 50169
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleTrackballActor_Rotate_16(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C3FA RID: 50170 RVA: 0x00110A4E File Offset: 0x0010EC4E
		public override void Rotate()
		{
			vtkInteractorStyleTrackballActor.vtkInteractorStyleTrackballActor_Rotate_16(base.GetCppThis());
		}

		// Token: 0x0600C3FB RID: 50171
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleTrackballActor_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C3FC RID: 50172 RVA: 0x00110A60 File Offset: 0x0010EC60
		public new static vtkInteractorStyleTrackballActor SafeDownCast(vtkObjectBase o)
		{
			vtkInteractorStyleTrackballActor vtkInteractorStyleTrackballActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleTrackballActor.vtkInteractorStyleTrackballActor_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInteractorStyleTrackballActor = (vtkInteractorStyleTrackballActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInteractorStyleTrackballActor.Register(null);
				}
			}
			return vtkInteractorStyleTrackballActor;
		}

		// Token: 0x0600C3FD RID: 50173
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleTrackballActor_Spin_18(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C3FE RID: 50174 RVA: 0x00110ADF File Offset: 0x0010ECDF
		public override void Spin()
		{
			vtkInteractorStyleTrackballActor.vtkInteractorStyleTrackballActor_Spin_18(base.GetCppThis());
		}

		// Token: 0x0600C3FF RID: 50175
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleTrackballActor_UniformScale_19(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C400 RID: 50176 RVA: 0x00110AEE File Offset: 0x0010ECEE
		public override void UniformScale()
		{
			vtkInteractorStyleTrackballActor.vtkInteractorStyleTrackballActor_UniformScale_19(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E7E RID: 3710
		public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleTrackballActor";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E7F RID: 3711
		public new static readonly string MRClassNameKey = "class vtkInteractorStyleTrackballActor";
	}
}
