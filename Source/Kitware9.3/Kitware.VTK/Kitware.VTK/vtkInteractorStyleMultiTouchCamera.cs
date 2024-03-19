using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInteractorStyleMultiTouchCamera
	/// </summary>
	/// <remarks>
	///    multitouch manipulation of the camera
	///
	/// vtkInteractorStyleMultiTouchCamera allows the user to interactively
	/// manipulate (rotate, pan, etc.) the camera, the viewpoint of the scene
	/// using multitouch gestures in addition to regular gestures
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkInteractorStyleTrackballActor vtkInteractorStyleJoystickCamera
	/// vtkInteractorStyleJoystickActor
	/// </seealso>
	// Token: 0x020003FC RID: 1020
	public class vtkInteractorStyleMultiTouchCamera : vtkInteractorStyleTrackballCamera
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C2AF RID: 49839 RVA: 0x0010EFDE File Offset: 0x0010D1DE
		static vtkInteractorStyleMultiTouchCamera()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInteractorStyleMultiTouchCamera.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleMultiTouchCamera"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C2B0 RID: 49840 RVA: 0x0010F006 File Offset: 0x0010D206
		public vtkInteractorStyleMultiTouchCamera(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C2B1 RID: 49841
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleMultiTouchCamera_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C2B2 RID: 49842 RVA: 0x0010F014 File Offset: 0x0010D214
		public new static vtkInteractorStyleMultiTouchCamera New()
		{
			vtkInteractorStyleMultiTouchCamera result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleMultiTouchCamera.vtkInteractorStyleMultiTouchCamera_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleMultiTouchCamera)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C2B3 RID: 49843 RVA: 0x0010F068 File Offset: 0x0010D268
		public vtkInteractorStyleMultiTouchCamera() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkInteractorStyleMultiTouchCamera.vtkInteractorStyleMultiTouchCamera_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C2B4 RID: 49844 RVA: 0x0010F0AC File Offset: 0x0010D2AC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C2B5 RID: 49845
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInteractorStyleMultiTouchCamera_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C2B6 RID: 49846 RVA: 0x0010F0B8 File Offset: 0x0010D2B8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInteractorStyleMultiTouchCamera.vtkInteractorStyleMultiTouchCamera_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600C2B7 RID: 49847
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInteractorStyleMultiTouchCamera_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C2B8 RID: 49848 RVA: 0x0010F0D8 File Offset: 0x0010D2D8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInteractorStyleMultiTouchCamera.vtkInteractorStyleMultiTouchCamera_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600C2B9 RID: 49849
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyleMultiTouchCamera_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C2BA RID: 49850 RVA: 0x0010F0F4 File Offset: 0x0010D2F4
		public override int IsA(string type)
		{
			return vtkInteractorStyleMultiTouchCamera.vtkInteractorStyleMultiTouchCamera_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600C2BB RID: 49851
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyleMultiTouchCamera_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C2BC RID: 49852 RVA: 0x0010F114 File Offset: 0x0010D314
		public new static int IsTypeOf(string type)
		{
			return vtkInteractorStyleMultiTouchCamera.vtkInteractorStyleMultiTouchCamera_IsTypeOf_04(type);
		}

		// Token: 0x0600C2BD RID: 49853
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleMultiTouchCamera_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C2BE RID: 49854 RVA: 0x0010F130 File Offset: 0x0010D330
		public new vtkInteractorStyleMultiTouchCamera NewInstance()
		{
			vtkInteractorStyleMultiTouchCamera result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleMultiTouchCamera.vtkInteractorStyleMultiTouchCamera_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleMultiTouchCamera)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C2BF RID: 49855
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleMultiTouchCamera_OnEndPan_07(HandleRef pThis);

		/// <summary>
		/// Event bindings for gestures
		/// </summary>
		// Token: 0x0600C2C0 RID: 49856 RVA: 0x0010F18A File Offset: 0x0010D38A
		public override void OnEndPan()
		{
			vtkInteractorStyleMultiTouchCamera.vtkInteractorStyleMultiTouchCamera_OnEndPan_07(base.GetCppThis());
		}

		// Token: 0x0600C2C1 RID: 49857
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleMultiTouchCamera_OnEndPinch_08(HandleRef pThis);

		/// <summary>
		/// Event bindings for gestures
		/// </summary>
		// Token: 0x0600C2C2 RID: 49858 RVA: 0x0010F199 File Offset: 0x0010D399
		public override void OnEndPinch()
		{
			vtkInteractorStyleMultiTouchCamera.vtkInteractorStyleMultiTouchCamera_OnEndPinch_08(base.GetCppThis());
		}

		// Token: 0x0600C2C3 RID: 49859
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleMultiTouchCamera_OnEndRotate_09(HandleRef pThis);

		/// <summary>
		/// Event bindings for gestures
		/// </summary>
		// Token: 0x0600C2C4 RID: 49860 RVA: 0x0010F1A8 File Offset: 0x0010D3A8
		public override void OnEndRotate()
		{
			vtkInteractorStyleMultiTouchCamera.vtkInteractorStyleMultiTouchCamera_OnEndRotate_09(base.GetCppThis());
		}

		// Token: 0x0600C2C5 RID: 49861
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleMultiTouchCamera_OnPan_10(HandleRef pThis);

		/// <summary>
		/// Event bindings for gestures
		/// </summary>
		// Token: 0x0600C2C6 RID: 49862 RVA: 0x0010F1B7 File Offset: 0x0010D3B7
		public override void OnPan()
		{
			vtkInteractorStyleMultiTouchCamera.vtkInteractorStyleMultiTouchCamera_OnPan_10(base.GetCppThis());
		}

		// Token: 0x0600C2C7 RID: 49863
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleMultiTouchCamera_OnPinch_11(HandleRef pThis);

		/// <summary>
		/// Event bindings for gestures
		/// </summary>
		// Token: 0x0600C2C8 RID: 49864 RVA: 0x0010F1C6 File Offset: 0x0010D3C6
		public override void OnPinch()
		{
			vtkInteractorStyleMultiTouchCamera.vtkInteractorStyleMultiTouchCamera_OnPinch_11(base.GetCppThis());
		}

		// Token: 0x0600C2C9 RID: 49865
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleMultiTouchCamera_OnRotate_12(HandleRef pThis);

		/// <summary>
		/// Event bindings for gestures
		/// </summary>
		// Token: 0x0600C2CA RID: 49866 RVA: 0x0010F1D5 File Offset: 0x0010D3D5
		public override void OnRotate()
		{
			vtkInteractorStyleMultiTouchCamera.vtkInteractorStyleMultiTouchCamera_OnRotate_12(base.GetCppThis());
		}

		// Token: 0x0600C2CB RID: 49867
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleMultiTouchCamera_OnStartPan_13(HandleRef pThis);

		/// <summary>
		/// Event bindings for gestures
		/// </summary>
		// Token: 0x0600C2CC RID: 49868 RVA: 0x0010F1E4 File Offset: 0x0010D3E4
		public override void OnStartPan()
		{
			vtkInteractorStyleMultiTouchCamera.vtkInteractorStyleMultiTouchCamera_OnStartPan_13(base.GetCppThis());
		}

		// Token: 0x0600C2CD RID: 49869
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleMultiTouchCamera_OnStartPinch_14(HandleRef pThis);

		/// <summary>
		/// Event bindings for gestures
		/// </summary>
		// Token: 0x0600C2CE RID: 49870 RVA: 0x0010F1F3 File Offset: 0x0010D3F3
		public override void OnStartPinch()
		{
			vtkInteractorStyleMultiTouchCamera.vtkInteractorStyleMultiTouchCamera_OnStartPinch_14(base.GetCppThis());
		}

		// Token: 0x0600C2CF RID: 49871
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleMultiTouchCamera_OnStartRotate_15(HandleRef pThis);

		/// <summary>
		/// Event bindings for gestures
		/// </summary>
		// Token: 0x0600C2D0 RID: 49872 RVA: 0x0010F202 File Offset: 0x0010D402
		public override void OnStartRotate()
		{
			vtkInteractorStyleMultiTouchCamera.vtkInteractorStyleMultiTouchCamera_OnStartRotate_15(base.GetCppThis());
		}

		// Token: 0x0600C2D1 RID: 49873
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleMultiTouchCamera_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C2D2 RID: 49874 RVA: 0x0010F214 File Offset: 0x0010D414
		public new static vtkInteractorStyleMultiTouchCamera SafeDownCast(vtkObjectBase o)
		{
			vtkInteractorStyleMultiTouchCamera vtkInteractorStyleMultiTouchCamera = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleMultiTouchCamera.vtkInteractorStyleMultiTouchCamera_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInteractorStyleMultiTouchCamera = (vtkInteractorStyleMultiTouchCamera)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInteractorStyleMultiTouchCamera.Register(null);
				}
			}
			return vtkInteractorStyleMultiTouchCamera;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E65 RID: 3685
		public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleMultiTouchCamera";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E66 RID: 3686
		public new static readonly string MRClassNameKey = "class vtkInteractorStyleMultiTouchCamera";
	}
}
