using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkWin32HardwareWindow
	/// </summary>
	/// <remarks>
	///    represents a window in a windows GUI
	/// </remarks>
	// Token: 0x020005FD RID: 1533
	public class vtkWin32HardwareWindow : vtkHardwareWindow
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06010A0D RID: 68109 RVA: 0x00173553 File Offset: 0x00171753
		static vtkWin32HardwareWindow()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkWin32HardwareWindow.MRClassNameKey, Type.GetType("Kitware.VTK.vtkWin32HardwareWindow"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06010A0E RID: 68110 RVA: 0x0017357B File Offset: 0x0017177B
		public vtkWin32HardwareWindow(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06010A0F RID: 68111
		[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWin32HardwareWindow_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010A10 RID: 68112 RVA: 0x0017358C File Offset: 0x0017178C
		public new static vtkWin32HardwareWindow New()
		{
			vtkWin32HardwareWindow result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWin32HardwareWindow.vtkWin32HardwareWindow_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWin32HardwareWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010A11 RID: 68113 RVA: 0x001735E0 File Offset: 0x001717E0
		public vtkWin32HardwareWindow() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkWin32HardwareWindow.vtkWin32HardwareWindow_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010A12 RID: 68114 RVA: 0x00173624 File Offset: 0x00171824
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06010A13 RID: 68115
		[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32HardwareWindow_Create_01(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010A14 RID: 68116 RVA: 0x0017362F File Offset: 0x0017182F
		public override void Create()
		{
			vtkWin32HardwareWindow.vtkWin32HardwareWindow_Create_01(base.GetCppThis());
		}

		// Token: 0x06010A15 RID: 68117
		[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32HardwareWindow_Destroy_02(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010A16 RID: 68118 RVA: 0x0017363E File Offset: 0x0017183E
		public override void Destroy()
		{
			vtkWin32HardwareWindow.vtkWin32HardwareWindow_Destroy_02(base.GetCppThis());
		}

		// Token: 0x06010A17 RID: 68119
		[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWin32HardwareWindow_GetGenericDisplayId_03(HandleRef pThis);

		/// <summary>
		/// These are window system independent methods that are used
		/// to help interface vtkWindow to native windowing systems.
		/// </summary>
		// Token: 0x06010A18 RID: 68120 RVA: 0x00173650 File Offset: 0x00171850
		public override IntPtr GetGenericDisplayId()
		{
			return vtkWin32HardwareWindow.vtkWin32HardwareWindow_GetGenericDisplayId_03(base.GetCppThis());
		}

		// Token: 0x06010A19 RID: 68121
		[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWin32HardwareWindow_GetGenericParentId_04(HandleRef pThis);

		/// <summary>
		/// These are window system independent methods that are used
		/// to help interface vtkWindow to native windowing systems.
		/// </summary>
		// Token: 0x06010A1A RID: 68122 RVA: 0x00173670 File Offset: 0x00171870
		public override IntPtr GetGenericParentId()
		{
			return vtkWin32HardwareWindow.vtkWin32HardwareWindow_GetGenericParentId_04(base.GetCppThis());
		}

		// Token: 0x06010A1B RID: 68123
		[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWin32HardwareWindow_GetGenericWindowId_05(HandleRef pThis);

		/// <summary>
		/// These are window system independent methods that are used
		/// to help interface vtkWindow to native windowing systems.
		/// </summary>
		// Token: 0x06010A1C RID: 68124 RVA: 0x00173690 File Offset: 0x00171890
		public override IntPtr GetGenericWindowId()
		{
			return vtkWin32HardwareWindow.vtkWin32HardwareWindow_GetGenericWindowId_05(base.GetCppThis());
		}

		// Token: 0x06010A1D RID: 68125
		[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWin32HardwareWindow_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010A1E RID: 68126 RVA: 0x001736B0 File Offset: 0x001718B0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkWin32HardwareWindow.vtkWin32HardwareWindow_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x06010A1F RID: 68127
		[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWin32HardwareWindow_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010A20 RID: 68128 RVA: 0x001736D0 File Offset: 0x001718D0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkWin32HardwareWindow.vtkWin32HardwareWindow_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x06010A21 RID: 68129
		[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWin32HardwareWindow_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010A22 RID: 68130 RVA: 0x001736EC File Offset: 0x001718EC
		public override int IsA(string type)
		{
			return vtkWin32HardwareWindow.vtkWin32HardwareWindow_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x06010A23 RID: 68131
		[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWin32HardwareWindow_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010A24 RID: 68132 RVA: 0x0017370C File Offset: 0x0017190C
		public new static int IsTypeOf(string type)
		{
			return vtkWin32HardwareWindow.vtkWin32HardwareWindow_IsTypeOf_09(type);
		}

		// Token: 0x06010A25 RID: 68133
		[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWin32HardwareWindow_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010A26 RID: 68134 RVA: 0x00173728 File Offset: 0x00171928
		public new vtkWin32HardwareWindow NewInstance()
		{
			vtkWin32HardwareWindow result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWin32HardwareWindow.vtkWin32HardwareWindow_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWin32HardwareWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010A27 RID: 68135
		[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWin32HardwareWindow_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010A28 RID: 68136 RVA: 0x00173784 File Offset: 0x00171984
		public new static vtkWin32HardwareWindow SafeDownCast(vtkObjectBase o)
		{
			vtkWin32HardwareWindow vtkWin32HardwareWindow = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWin32HardwareWindow.vtkWin32HardwareWindow_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWin32HardwareWindow = (vtkWin32HardwareWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWin32HardwareWindow.Register(null);
				}
			}
			return vtkWin32HardwareWindow;
		}

		// Token: 0x06010A29 RID: 68137
		[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32HardwareWindow_SetDisplayId_13(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// These are window system independent methods that are used
		/// to help interface vtkWindow to native windowing systems.
		/// </summary>
		// Token: 0x06010A2A RID: 68138 RVA: 0x00173803 File Offset: 0x00171A03
		public override void SetDisplayId(IntPtr arg0)
		{
			vtkWin32HardwareWindow.vtkWin32HardwareWindow_SetDisplayId_13(base.GetCppThis(), arg0);
		}

		// Token: 0x06010A2B RID: 68139
		[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32HardwareWindow_SetParentId_14(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// These are window system independent methods that are used
		/// to help interface vtkWindow to native windowing systems.
		/// </summary>
		// Token: 0x06010A2C RID: 68140 RVA: 0x00173813 File Offset: 0x00171A13
		public override void SetParentId(IntPtr arg0)
		{
			vtkWin32HardwareWindow.vtkWin32HardwareWindow_SetParentId_14(base.GetCppThis(), arg0);
		}

		// Token: 0x06010A2D RID: 68141
		[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32HardwareWindow_SetPosition_15(HandleRef pThis, int arg0, int arg1);

		/// <summary>
		/// Set the position of the window.
		/// </summary>
		// Token: 0x06010A2E RID: 68142 RVA: 0x00173823 File Offset: 0x00171A23
		public override void SetPosition(int arg0, int arg1)
		{
			vtkWin32HardwareWindow.vtkWin32HardwareWindow_SetPosition_15(base.GetCppThis(), arg0, arg1);
		}

		// Token: 0x06010A2F RID: 68143
		[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32HardwareWindow_SetSize_16(HandleRef pThis, int arg0, int arg1);

		/// <summary>
		/// Set the size of the window in pixels.
		/// </summary>
		// Token: 0x06010A30 RID: 68144 RVA: 0x00173834 File Offset: 0x00171A34
		public override void SetSize(int arg0, int arg1)
		{
			vtkWin32HardwareWindow.vtkWin32HardwareWindow_SetSize_16(base.GetCppThis(), arg0, arg1);
		}

		// Token: 0x06010A31 RID: 68145
		[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32HardwareWindow_SetWindowId_17(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// These are window system independent methods that are used
		/// to help interface vtkWindow to native windowing systems.
		/// </summary>
		// Token: 0x06010A32 RID: 68146 RVA: 0x00173845 File Offset: 0x00171A45
		public override void SetWindowId(IntPtr arg0)
		{
			vtkWin32HardwareWindow.vtkWin32HardwareWindow_SetWindowId_17(base.GetCppThis(), arg0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001350 RID: 4944
		public new const string MRFullTypeName = "Kitware.VTK.vtkWin32HardwareWindow";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001351 RID: 4945
		public new static readonly string MRClassNameKey = "class vtkWin32HardwareWindow";
	}
}
