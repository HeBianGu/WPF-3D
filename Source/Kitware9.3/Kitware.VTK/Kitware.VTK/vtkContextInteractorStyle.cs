using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkContextInteractorStyle
	/// </summary>
	/// <remarks>
	///    An interactor for chart views.
	///
	///
	/// It observes the user events (mouse events) and propagates them
	/// to the scene. If the scene doesn't eat the event, it is propagated
	/// to the interactor style superclass.
	/// </remarks>
	// Token: 0x02000055 RID: 85
	public class vtkContextInteractorStyle : vtkInteractorStyle
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06000F60 RID: 3936 RVA: 0x0001BFF5 File Offset: 0x0001A1F5
		static vtkContextInteractorStyle()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkContextInteractorStyle.MRClassNameKey, Type.GetType("Kitware.VTK.vtkContextInteractorStyle"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06000F61 RID: 3937 RVA: 0x0001C01D File Offset: 0x0001A21D
		public vtkContextInteractorStyle(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06000F62 RID: 3938
		[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContextInteractorStyle_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000F63 RID: 3939 RVA: 0x0001C02C File Offset: 0x0001A22C
		public new static vtkContextInteractorStyle New()
		{
			vtkContextInteractorStyle result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContextInteractorStyle.vtkContextInteractorStyle_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContextInteractorStyle)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000F64 RID: 3940 RVA: 0x0001C080 File Offset: 0x0001A280
		public vtkContextInteractorStyle() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkContextInteractorStyle.vtkContextInteractorStyle_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06000F65 RID: 3941 RVA: 0x0001C0C4 File Offset: 0x0001A2C4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06000F66 RID: 3942
		[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkContextInteractorStyle_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000F67 RID: 3943 RVA: 0x0001C0D0 File Offset: 0x0001A2D0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkContextInteractorStyle.vtkContextInteractorStyle_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06000F68 RID: 3944
		[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkContextInteractorStyle_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000F69 RID: 3945 RVA: 0x0001C0F0 File Offset: 0x0001A2F0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkContextInteractorStyle.vtkContextInteractorStyle_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06000F6A RID: 3946
		[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContextInteractorStyle_GetScene_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the observed scene.
		/// </summary>
		// Token: 0x06000F6B RID: 3947 RVA: 0x0001C10C File Offset: 0x0001A30C
		public vtkContextScene GetScene()
		{
			vtkContextScene vtkContextScene = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContextInteractorStyle.vtkContextInteractorStyle_GetScene_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06000F6C RID: 3948
		[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContextInteractorStyle_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000F6D RID: 3949 RVA: 0x0001C17C File Offset: 0x0001A37C
		public override int IsA(string type)
		{
			return vtkContextInteractorStyle.vtkContextInteractorStyle_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06000F6E RID: 3950
		[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContextInteractorStyle_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000F6F RID: 3951 RVA: 0x0001C19C File Offset: 0x0001A39C
		public new static int IsTypeOf(string type)
		{
			return vtkContextInteractorStyle.vtkContextInteractorStyle_IsTypeOf_05(type);
		}

		// Token: 0x06000F70 RID: 3952
		[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContextInteractorStyle_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000F71 RID: 3953 RVA: 0x0001C1B8 File Offset: 0x0001A3B8
		public new vtkContextInteractorStyle NewInstance()
		{
			vtkContextInteractorStyle result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContextInteractorStyle.vtkContextInteractorStyle_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContextInteractorStyle)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000F72 RID: 3954
		[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextInteractorStyle_OnChar_08(HandleRef pThis);

		/// <summary>
		/// Handle key presses.
		/// </summary>
		// Token: 0x06000F73 RID: 3955 RVA: 0x0001C212 File Offset: 0x0001A412
		public override void OnChar()
		{
			vtkContextInteractorStyle.vtkContextInteractorStyle_OnChar_08(base.GetCppThis());
		}

		// Token: 0x06000F74 RID: 3956
		[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextInteractorStyle_OnKeyPress_09(HandleRef pThis);

		/// <summary>
		/// Called when the user presses a key.
		/// </summary>
		// Token: 0x06000F75 RID: 3957 RVA: 0x0001C221 File Offset: 0x0001A421
		public override void OnKeyPress()
		{
			vtkContextInteractorStyle.vtkContextInteractorStyle_OnKeyPress_09(base.GetCppThis());
		}

		// Token: 0x06000F76 RID: 3958
		[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextInteractorStyle_OnKeyRelease_10(HandleRef pThis);

		/// <summary>
		/// Called when the user releases a key.
		/// </summary>
		// Token: 0x06000F77 RID: 3959 RVA: 0x0001C230 File Offset: 0x0001A430
		public override void OnKeyRelease()
		{
			vtkContextInteractorStyle.vtkContextInteractorStyle_OnKeyRelease_10(base.GetCppThis());
		}

		// Token: 0x06000F78 RID: 3960
		[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextInteractorStyle_OnLeftButtonDoubleClick_11(HandleRef pThis);

		/// <summary>
		/// Called when the user double-clicks the mouse left button.
		/// Default behavior forwards the event to the observed scene.
		/// </summary>
		// Token: 0x06000F79 RID: 3961 RVA: 0x0001C23F File Offset: 0x0001A43F
		public override void OnLeftButtonDoubleClick()
		{
			vtkContextInteractorStyle.vtkContextInteractorStyle_OnLeftButtonDoubleClick_11(base.GetCppThis());
		}

		// Token: 0x06000F7A RID: 3962
		[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextInteractorStyle_OnLeftButtonDown_12(HandleRef pThis);

		/// <summary>
		/// Called when the user clicks the mouse left button.
		/// Default behavior forwards the event to the observed scene.
		/// </summary>
		// Token: 0x06000F7B RID: 3963 RVA: 0x0001C24E File Offset: 0x0001A44E
		public override void OnLeftButtonDown()
		{
			vtkContextInteractorStyle.vtkContextInteractorStyle_OnLeftButtonDown_12(base.GetCppThis());
		}

		// Token: 0x06000F7C RID: 3964
		[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextInteractorStyle_OnLeftButtonUp_13(HandleRef pThis);

		/// <summary>
		/// Called when the user releases the mouse left button.
		/// Default behavior forwards the event to the observed scene.
		/// </summary>
		// Token: 0x06000F7D RID: 3965 RVA: 0x0001C25D File Offset: 0x0001A45D
		public override void OnLeftButtonUp()
		{
			vtkContextInteractorStyle.vtkContextInteractorStyle_OnLeftButtonUp_13(base.GetCppThis());
		}

		// Token: 0x06000F7E RID: 3966
		[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextInteractorStyle_OnMiddleButtonDoubleClick_14(HandleRef pThis);

		/// <summary>
		/// Called when the user double-clicks the mouse middle button.
		/// Default behavior forwards the event to the observed scene.
		/// </summary>
		// Token: 0x06000F7F RID: 3967 RVA: 0x0001C26C File Offset: 0x0001A46C
		public override void OnMiddleButtonDoubleClick()
		{
			vtkContextInteractorStyle.vtkContextInteractorStyle_OnMiddleButtonDoubleClick_14(base.GetCppThis());
		}

		// Token: 0x06000F80 RID: 3968
		[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextInteractorStyle_OnMiddleButtonDown_15(HandleRef pThis);

		/// <summary>
		/// Called when the user clicks the mouse middle button.
		/// Default behavior forwards the event to the observed scene.
		/// </summary>
		// Token: 0x06000F81 RID: 3969 RVA: 0x0001C27B File Offset: 0x0001A47B
		public override void OnMiddleButtonDown()
		{
			vtkContextInteractorStyle.vtkContextInteractorStyle_OnMiddleButtonDown_15(base.GetCppThis());
		}

		// Token: 0x06000F82 RID: 3970
		[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextInteractorStyle_OnMiddleButtonUp_16(HandleRef pThis);

		/// <summary>
		/// Called when the user releases the mouse middle button.
		/// Default behavior forwards the event to the observed scene.
		/// </summary>
		// Token: 0x06000F83 RID: 3971 RVA: 0x0001C28A File Offset: 0x0001A48A
		public override void OnMiddleButtonUp()
		{
			vtkContextInteractorStyle.vtkContextInteractorStyle_OnMiddleButtonUp_16(base.GetCppThis());
		}

		// Token: 0x06000F84 RID: 3972
		[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextInteractorStyle_OnMouseMove_17(HandleRef pThis);

		/// <summary>
		/// Called when the user moves the mouse
		/// Default behavior forwards the event to the observed scene.
		/// </summary>
		// Token: 0x06000F85 RID: 3973 RVA: 0x0001C299 File Offset: 0x0001A499
		public override void OnMouseMove()
		{
			vtkContextInteractorStyle.vtkContextInteractorStyle_OnMouseMove_17(base.GetCppThis());
		}

		// Token: 0x06000F86 RID: 3974
		[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextInteractorStyle_OnMouseWheelBackward_18(HandleRef pThis);

		/// <summary>
		/// Called when the user moves the mouse wheel backward.
		/// Default behavior forwards the event to the observed scene.
		/// </summary>
		// Token: 0x06000F87 RID: 3975 RVA: 0x0001C2A8 File Offset: 0x0001A4A8
		public override void OnMouseWheelBackward()
		{
			vtkContextInteractorStyle.vtkContextInteractorStyle_OnMouseWheelBackward_18(base.GetCppThis());
		}

		// Token: 0x06000F88 RID: 3976
		[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextInteractorStyle_OnMouseWheelForward_19(HandleRef pThis);

		/// <summary>
		/// Called when the user moves the mouse wheel forward.
		/// Default behavior forwards the event to the observed scene.
		/// </summary>
		// Token: 0x06000F89 RID: 3977 RVA: 0x0001C2B7 File Offset: 0x0001A4B7
		public override void OnMouseWheelForward()
		{
			vtkContextInteractorStyle.vtkContextInteractorStyle_OnMouseWheelForward_19(base.GetCppThis());
		}

		// Token: 0x06000F8A RID: 3978
		[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextInteractorStyle_OnRightButtonDoubleClick_20(HandleRef pThis);

		/// <summary>
		/// Called when the user double-clicks the mouse right button.
		/// Default behavior forwards the event to the observed scene.
		/// </summary>
		// Token: 0x06000F8B RID: 3979 RVA: 0x0001C2C6 File Offset: 0x0001A4C6
		public override void OnRightButtonDoubleClick()
		{
			vtkContextInteractorStyle.vtkContextInteractorStyle_OnRightButtonDoubleClick_20(base.GetCppThis());
		}

		// Token: 0x06000F8C RID: 3980
		[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextInteractorStyle_OnRightButtonDown_21(HandleRef pThis);

		/// <summary>
		/// Called when the user clicks the mouse right button.
		/// Default behavior forwards the event to the observed scene.
		/// </summary>
		// Token: 0x06000F8D RID: 3981 RVA: 0x0001C2D5 File Offset: 0x0001A4D5
		public override void OnRightButtonDown()
		{
			vtkContextInteractorStyle.vtkContextInteractorStyle_OnRightButtonDown_21(base.GetCppThis());
		}

		// Token: 0x06000F8E RID: 3982
		[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextInteractorStyle_OnRightButtonUp_22(HandleRef pThis);

		/// <summary>
		/// Called when the user releases the mouse right button.
		/// Default behavior forwards the event to the observed scene.
		/// </summary>
		// Token: 0x06000F8F RID: 3983 RVA: 0x0001C2E4 File Offset: 0x0001A4E4
		public override void OnRightButtonUp()
		{
			vtkContextInteractorStyle.vtkContextInteractorStyle_OnRightButtonUp_22(base.GetCppThis());
		}

		// Token: 0x06000F90 RID: 3984
		[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextInteractorStyle_OnSceneModified_23(HandleRef pThis);

		/// <summary>
		/// Called when the scene is modified. Refresh the scene if needed.
		/// </summary>
		// Token: 0x06000F91 RID: 3985 RVA: 0x0001C2F3 File Offset: 0x0001A4F3
		public virtual void OnSceneModified()
		{
			vtkContextInteractorStyle.vtkContextInteractorStyle_OnSceneModified_23(base.GetCppThis());
		}

		// Token: 0x06000F92 RID: 3986
		[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextInteractorStyle_OnSelection_24(HandleRef pThis, IntPtr rect);

		/// <summary>
		/// Place holder for future implementation.
		/// Default behavior forwards the event to the observed scene.
		/// </summary>
		// Token: 0x06000F93 RID: 3987 RVA: 0x0001C302 File Offset: 0x0001A502
		public virtual void OnSelection(IntPtr rect)
		{
			vtkContextInteractorStyle.vtkContextInteractorStyle_OnSelection_24(base.GetCppThis(), rect);
		}

		// Token: 0x06000F94 RID: 3988
		[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContextInteractorStyle_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000F95 RID: 3989 RVA: 0x0001C314 File Offset: 0x0001A514
		public new static vtkContextInteractorStyle SafeDownCast(vtkObjectBase o)
		{
			vtkContextInteractorStyle vtkContextInteractorStyle = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContextInteractorStyle.vtkContextInteractorStyle_SafeDownCast_25((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkContextInteractorStyle = (vtkContextInteractorStyle)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkContextInteractorStyle.Register(null);
				}
			}
			return vtkContextInteractorStyle;
		}

		// Token: 0x06000F96 RID: 3990
		[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextInteractorStyle_SetScene_26(HandleRef pThis, HandleRef scene);

		/// <summary>
		/// Set the scene to forward user events to.
		/// Refresh the view when the scene is dirty and no event is being processed.
		/// The scene is observed (vtkCommand::ModifiedEvent) and a refresh on the
		/// view is called appropriately: scene is dirty and no event is being
		/// processed.
		/// </summary>
		// Token: 0x06000F97 RID: 3991 RVA: 0x0001C394 File Offset: 0x0001A594
		public void SetScene(vtkContextScene scene)
		{
			vtkContextInteractorStyle.vtkContextInteractorStyle_SetScene_26(base.GetCppThis(), (scene == null) ? default(HandleRef) : scene.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400042C RID: 1068
		public new const string MRFullTypeName = "Kitware.VTK.vtkContextInteractorStyle";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400042D RID: 1069
		public new static readonly string MRClassNameKey = "class vtkContextInteractorStyle";
	}
}
