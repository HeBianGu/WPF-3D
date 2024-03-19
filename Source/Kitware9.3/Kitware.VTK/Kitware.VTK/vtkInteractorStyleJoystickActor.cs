using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInteractorStyleJoystickActor
	/// </summary>
	/// <remarks>
	///    manipulate objects in the scene independently of one another
	///
	/// The class vtkInteractorStyleJoystickActor allows the user to interact
	/// with (rotate, zoom, etc.) separate objects in the scene independent of
	/// each other.  The position of the mouse relative to the center of the
	/// object determines the speed of the object's motion.  The mouse's velocity
	/// determines the acceleration of the object's motion, so the object will
	/// continue moving even when the mouse is not moving.
	/// For a 3-button mouse, the left button is for rotation, the right button
	/// for zooming, the middle button for panning, and ctrl + left button for
	/// spinning.  (With fewer mouse buttons, ctrl + shift + left button is
	/// for zooming, and shift + left button is for panning.)
	/// </remarks>
	/// <seealso>
	///
	/// vtkInteractorStyleJoystickCamera vtkInteractorStyleTrackballActor
	/// vtkInteractorStyleTrackballCamera
	/// </seealso>
	// Token: 0x020003FA RID: 1018
	public class vtkInteractorStyleJoystickActor : vtkInteractorStyle
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C259 RID: 49753 RVA: 0x0010EA09 File Offset: 0x0010CC09
		static vtkInteractorStyleJoystickActor()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInteractorStyleJoystickActor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleJoystickActor"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C25A RID: 49754 RVA: 0x0010EA31 File Offset: 0x0010CC31
		public vtkInteractorStyleJoystickActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C25B RID: 49755
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleJoystickActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C25C RID: 49756 RVA: 0x0010EA40 File Offset: 0x0010CC40
		public new static vtkInteractorStyleJoystickActor New()
		{
			vtkInteractorStyleJoystickActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleJoystickActor.vtkInteractorStyleJoystickActor_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleJoystickActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C25D RID: 49757 RVA: 0x0010EA94 File Offset: 0x0010CC94
		public vtkInteractorStyleJoystickActor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkInteractorStyleJoystickActor.vtkInteractorStyleJoystickActor_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C25E RID: 49758 RVA: 0x0010EAD8 File Offset: 0x0010CCD8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C25F RID: 49759
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleJoystickActor_Dolly_01(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C260 RID: 49760 RVA: 0x0010EAE3 File Offset: 0x0010CCE3
		public override void Dolly()
		{
			vtkInteractorStyleJoystickActor.vtkInteractorStyleJoystickActor_Dolly_01(base.GetCppThis());
		}

		// Token: 0x0600C261 RID: 49761
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInteractorStyleJoystickActor_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C262 RID: 49762 RVA: 0x0010EAF4 File Offset: 0x0010CCF4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInteractorStyleJoystickActor.vtkInteractorStyleJoystickActor_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600C263 RID: 49763
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInteractorStyleJoystickActor_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C264 RID: 49764 RVA: 0x0010EB14 File Offset: 0x0010CD14
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInteractorStyleJoystickActor.vtkInteractorStyleJoystickActor_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600C265 RID: 49765
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyleJoystickActor_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C266 RID: 49766 RVA: 0x0010EB30 File Offset: 0x0010CD30
		public override int IsA(string type)
		{
			return vtkInteractorStyleJoystickActor.vtkInteractorStyleJoystickActor_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600C267 RID: 49767
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyleJoystickActor_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C268 RID: 49768 RVA: 0x0010EB50 File Offset: 0x0010CD50
		public new static int IsTypeOf(string type)
		{
			return vtkInteractorStyleJoystickActor.vtkInteractorStyleJoystickActor_IsTypeOf_05(type);
		}

		// Token: 0x0600C269 RID: 49769
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleJoystickActor_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C26A RID: 49770 RVA: 0x0010EB6C File Offset: 0x0010CD6C
		public new vtkInteractorStyleJoystickActor NewInstance()
		{
			vtkInteractorStyleJoystickActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleJoystickActor.vtkInteractorStyleJoystickActor_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleJoystickActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C26B RID: 49771
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleJoystickActor_OnLeftButtonDown_08(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C26C RID: 49772 RVA: 0x0010EBC6 File Offset: 0x0010CDC6
		public override void OnLeftButtonDown()
		{
			vtkInteractorStyleJoystickActor.vtkInteractorStyleJoystickActor_OnLeftButtonDown_08(base.GetCppThis());
		}

		// Token: 0x0600C26D RID: 49773
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleJoystickActor_OnLeftButtonUp_09(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C26E RID: 49774 RVA: 0x0010EBD5 File Offset: 0x0010CDD5
		public override void OnLeftButtonUp()
		{
			vtkInteractorStyleJoystickActor.vtkInteractorStyleJoystickActor_OnLeftButtonUp_09(base.GetCppThis());
		}

		// Token: 0x0600C26F RID: 49775
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleJoystickActor_OnMiddleButtonDown_10(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C270 RID: 49776 RVA: 0x0010EBE4 File Offset: 0x0010CDE4
		public override void OnMiddleButtonDown()
		{
			vtkInteractorStyleJoystickActor.vtkInteractorStyleJoystickActor_OnMiddleButtonDown_10(base.GetCppThis());
		}

		// Token: 0x0600C271 RID: 49777
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleJoystickActor_OnMiddleButtonUp_11(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C272 RID: 49778 RVA: 0x0010EBF3 File Offset: 0x0010CDF3
		public override void OnMiddleButtonUp()
		{
			vtkInteractorStyleJoystickActor.vtkInteractorStyleJoystickActor_OnMiddleButtonUp_11(base.GetCppThis());
		}

		// Token: 0x0600C273 RID: 49779
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleJoystickActor_OnMouseMove_12(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C274 RID: 49780 RVA: 0x0010EC02 File Offset: 0x0010CE02
		public override void OnMouseMove()
		{
			vtkInteractorStyleJoystickActor.vtkInteractorStyleJoystickActor_OnMouseMove_12(base.GetCppThis());
		}

		// Token: 0x0600C275 RID: 49781
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleJoystickActor_OnRightButtonDown_13(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C276 RID: 49782 RVA: 0x0010EC11 File Offset: 0x0010CE11
		public override void OnRightButtonDown()
		{
			vtkInteractorStyleJoystickActor.vtkInteractorStyleJoystickActor_OnRightButtonDown_13(base.GetCppThis());
		}

		// Token: 0x0600C277 RID: 49783
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleJoystickActor_OnRightButtonUp_14(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C278 RID: 49784 RVA: 0x0010EC20 File Offset: 0x0010CE20
		public override void OnRightButtonUp()
		{
			vtkInteractorStyleJoystickActor.vtkInteractorStyleJoystickActor_OnRightButtonUp_14(base.GetCppThis());
		}

		// Token: 0x0600C279 RID: 49785
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleJoystickActor_Pan_15(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C27A RID: 49786 RVA: 0x0010EC2F File Offset: 0x0010CE2F
		public override void Pan()
		{
			vtkInteractorStyleJoystickActor.vtkInteractorStyleJoystickActor_Pan_15(base.GetCppThis());
		}

		// Token: 0x0600C27B RID: 49787
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleJoystickActor_Rotate_16(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C27C RID: 49788 RVA: 0x0010EC3E File Offset: 0x0010CE3E
		public override void Rotate()
		{
			vtkInteractorStyleJoystickActor.vtkInteractorStyleJoystickActor_Rotate_16(base.GetCppThis());
		}

		// Token: 0x0600C27D RID: 49789
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleJoystickActor_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C27E RID: 49790 RVA: 0x0010EC50 File Offset: 0x0010CE50
		public new static vtkInteractorStyleJoystickActor SafeDownCast(vtkObjectBase o)
		{
			vtkInteractorStyleJoystickActor vtkInteractorStyleJoystickActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleJoystickActor.vtkInteractorStyleJoystickActor_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInteractorStyleJoystickActor = (vtkInteractorStyleJoystickActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInteractorStyleJoystickActor.Register(null);
				}
			}
			return vtkInteractorStyleJoystickActor;
		}

		// Token: 0x0600C27F RID: 49791
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleJoystickActor_Spin_18(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C280 RID: 49792 RVA: 0x0010ECCF File Offset: 0x0010CECF
		public override void Spin()
		{
			vtkInteractorStyleJoystickActor.vtkInteractorStyleJoystickActor_Spin_18(base.GetCppThis());
		}

		// Token: 0x0600C281 RID: 49793
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleJoystickActor_UniformScale_19(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x0600C282 RID: 49794 RVA: 0x0010ECDE File Offset: 0x0010CEDE
		public override void UniformScale()
		{
			vtkInteractorStyleJoystickActor.vtkInteractorStyleJoystickActor_UniformScale_19(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E61 RID: 3681
		public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleJoystickActor";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E62 RID: 3682
		public new static readonly string MRClassNameKey = "class vtkInteractorStyleJoystickActor";
	}
}
