using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkWin32RenderWindowInteractor
	/// </summary>
	/// <remarks>
	///    implements Win32 specific functions
	/// required by vtkRenderWindowInteractor.
	///
	///
	/// By default the interactor installs a MessageProc callback which
	/// intercepts windows' messages to the window and controls interactions by
	/// routing them to the InteractoStyle classes.
	/// MFC or BCB programs can prevent this and instead directly route any mouse/key
	/// messages into the event bindings by setting InstallMessageProc to false.
	/// This provides a minimal "Mapped" mode of interaction
	///
	/// </remarks>
	// Token: 0x020005FE RID: 1534
	public class vtkWin32RenderWindowInteractor : vtkRenderWindowInteractor
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06010A33 RID: 68147 RVA: 0x00173855 File Offset: 0x00171A55
		static vtkWin32RenderWindowInteractor()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkWin32RenderWindowInteractor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkWin32RenderWindowInteractor"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06010A34 RID: 68148 RVA: 0x0017387D File Offset: 0x00171A7D
		public vtkWin32RenderWindowInteractor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06010A35 RID: 68149
		[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWin32RenderWindowInteractor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object so that light follows camera motion.
		/// </summary>
		// Token: 0x06010A36 RID: 68150 RVA: 0x0017388C File Offset: 0x00171A8C
		public new static vtkWin32RenderWindowInteractor New()
		{
			vtkWin32RenderWindowInteractor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWin32RenderWindowInteractor.vtkWin32RenderWindowInteractor_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWin32RenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object so that light follows camera motion.
		/// </summary>
		// Token: 0x06010A37 RID: 68151 RVA: 0x001738E0 File Offset: 0x00171AE0
		public vtkWin32RenderWindowInteractor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkWin32RenderWindowInteractor.vtkWin32RenderWindowInteractor_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010A38 RID: 68152 RVA: 0x00173924 File Offset: 0x00171B24
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06010A39 RID: 68153
		[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32RenderWindowInteractor_Disable_01(HandleRef pThis);

		/// <summary>
		/// Enable/Disable interactions.  By default interactors are enabled when
		/// initialized.  Initialize() must be called prior to enabling/disabling
		/// interaction. These methods are used when a window/widget is being
		/// shared by multiple renderers and interactors.  This allows a "modal"
		/// display where one interactor is active when its data is to be displayed
		/// and all other interactors associated with the widget are disabled
		/// when their data is not displayed.
		/// </summary>
		// Token: 0x06010A3A RID: 68154 RVA: 0x0017392F File Offset: 0x00171B2F
		public override void Disable()
		{
			vtkWin32RenderWindowInteractor.vtkWin32RenderWindowInteractor_Disable_01(base.GetCppThis());
		}

		// Token: 0x06010A3B RID: 68155
		[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32RenderWindowInteractor_Enable_02(HandleRef pThis);

		/// <summary>
		/// Enable/Disable interactions.  By default interactors are enabled when
		/// initialized.  Initialize() must be called prior to enabling/disabling
		/// interaction. These methods are used when a window/widget is being
		/// shared by multiple renderers and interactors.  This allows a "modal"
		/// display where one interactor is active when its data is to be displayed
		/// and all other interactors associated with the widget are disabled
		/// when their data is not displayed.
		/// </summary>
		// Token: 0x06010A3C RID: 68156 RVA: 0x0017393E File Offset: 0x00171B3E
		public override void Enable()
		{
			vtkWin32RenderWindowInteractor.vtkWin32RenderWindowInteractor_Enable_02(base.GetCppThis());
		}

		// Token: 0x06010A3D RID: 68157
		[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32RenderWindowInteractor_ExitCallback_03(HandleRef pThis);

		/// <summary>
		/// These methods correspond to the Exit, User and Pick
		/// callbacks. They allow for the Style to invoke them.
		/// </summary>
		// Token: 0x06010A3E RID: 68158 RVA: 0x0017394D File Offset: 0x00171B4D
		public override void ExitCallback()
		{
			vtkWin32RenderWindowInteractor.vtkWin32RenderWindowInteractor_ExitCallback_03(base.GetCppThis());
		}

		// Token: 0x06010A3F RID: 68159
		[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWin32RenderWindowInteractor_GetInstallMessageProc_04(HandleRef pThis);

		/// <summary>
		/// By default the interactor installs a MessageProc callback which
		/// intercepts windows messages to the window and controls interactions.
		/// MFC or BCB programs can prevent this and instead directly route any mouse/key
		/// messages into the event bindings by setting InstallMessgeProc to false.
		/// </summary>
		// Token: 0x06010A40 RID: 68160 RVA: 0x0017395C File Offset: 0x00171B5C
		public virtual int GetInstallMessageProc()
		{
			return vtkWin32RenderWindowInteractor.vtkWin32RenderWindowInteractor_GetInstallMessageProc_04(base.GetCppThis());
		}

		// Token: 0x06010A41 RID: 68161
		[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWin32RenderWindowInteractor_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct object so that light follows camera motion.
		/// </summary>
		// Token: 0x06010A42 RID: 68162 RVA: 0x0017397C File Offset: 0x00171B7C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkWin32RenderWindowInteractor.vtkWin32RenderWindowInteractor_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06010A43 RID: 68163
		[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWin32RenderWindowInteractor_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct object so that light follows camera motion.
		/// </summary>
		// Token: 0x06010A44 RID: 68164 RVA: 0x0017399C File Offset: 0x00171B9C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkWin32RenderWindowInteractor.vtkWin32RenderWindowInteractor_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06010A45 RID: 68165
		[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32RenderWindowInteractor_Initialize_07(HandleRef pThis);

		/// <summary>
		/// Initialize the event handler
		/// </summary>
		// Token: 0x06010A46 RID: 68166 RVA: 0x001739B6 File Offset: 0x00171BB6
		public override void Initialize()
		{
			vtkWin32RenderWindowInteractor.vtkWin32RenderWindowInteractor_Initialize_07(base.GetCppThis());
		}

		// Token: 0x06010A47 RID: 68167
		[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32RenderWindowInteractor_InstallMessageProcOff_08(HandleRef pThis);

		/// <summary>
		/// By default the interactor installs a MessageProc callback which
		/// intercepts windows messages to the window and controls interactions.
		/// MFC or BCB programs can prevent this and instead directly route any mouse/key
		/// messages into the event bindings by setting InstallMessgeProc to false.
		/// </summary>
		// Token: 0x06010A48 RID: 68168 RVA: 0x001739C5 File Offset: 0x00171BC5
		public virtual void InstallMessageProcOff()
		{
			vtkWin32RenderWindowInteractor.vtkWin32RenderWindowInteractor_InstallMessageProcOff_08(base.GetCppThis());
		}

		// Token: 0x06010A49 RID: 68169
		[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32RenderWindowInteractor_InstallMessageProcOn_09(HandleRef pThis);

		/// <summary>
		/// By default the interactor installs a MessageProc callback which
		/// intercepts windows messages to the window and controls interactions.
		/// MFC or BCB programs can prevent this and instead directly route any mouse/key
		/// messages into the event bindings by setting InstallMessgeProc to false.
		/// </summary>
		// Token: 0x06010A4A RID: 68170 RVA: 0x001739D4 File Offset: 0x00171BD4
		public virtual void InstallMessageProcOn()
		{
			vtkWin32RenderWindowInteractor.vtkWin32RenderWindowInteractor_InstallMessageProcOn_09(base.GetCppThis());
		}

		// Token: 0x06010A4B RID: 68171
		[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWin32RenderWindowInteractor_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct object so that light follows camera motion.
		/// </summary>
		// Token: 0x06010A4C RID: 68172 RVA: 0x001739E4 File Offset: 0x00171BE4
		public override int IsA(string type)
		{
			return vtkWin32RenderWindowInteractor.vtkWin32RenderWindowInteractor_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x06010A4D RID: 68173
		[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWin32RenderWindowInteractor_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct object so that light follows camera motion.
		/// </summary>
		// Token: 0x06010A4E RID: 68174 RVA: 0x00173A04 File Offset: 0x00171C04
		public new static int IsTypeOf(string type)
		{
			return vtkWin32RenderWindowInteractor.vtkWin32RenderWindowInteractor_IsTypeOf_11(type);
		}

		// Token: 0x06010A4F RID: 68175
		[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWin32RenderWindowInteractor_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object so that light follows camera motion.
		/// </summary>
		// Token: 0x06010A50 RID: 68176 RVA: 0x00173A20 File Offset: 0x00171C20
		public new vtkWin32RenderWindowInteractor NewInstance()
		{
			vtkWin32RenderWindowInteractor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWin32RenderWindowInteractor.vtkWin32RenderWindowInteractor_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWin32RenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010A51 RID: 68177
		[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32RenderWindowInteractor_ProcessEvents_14(HandleRef pThis);

		/// <summary>
		/// Process all user-interaction, timer events and return.
		/// If there are no events, this method returns immediately.
		/// </summary>
		// Token: 0x06010A52 RID: 68178 RVA: 0x00173A7A File Offset: 0x00171C7A
		public override void ProcessEvents()
		{
			vtkWin32RenderWindowInteractor.vtkWin32RenderWindowInteractor_ProcessEvents_14(base.GetCppThis());
		}

		// Token: 0x06010A53 RID: 68179
		[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWin32RenderWindowInteractor_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object so that light follows camera motion.
		/// </summary>
		// Token: 0x06010A54 RID: 68180 RVA: 0x00173A8C File Offset: 0x00171C8C
		public new static vtkWin32RenderWindowInteractor SafeDownCast(vtkObjectBase o)
		{
			vtkWin32RenderWindowInteractor vtkWin32RenderWindowInteractor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWin32RenderWindowInteractor.vtkWin32RenderWindowInteractor_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWin32RenderWindowInteractor = (vtkWin32RenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWin32RenderWindowInteractor.Register(null);
				}
			}
			return vtkWin32RenderWindowInteractor;
		}

		// Token: 0x06010A55 RID: 68181
		[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32RenderWindowInteractor_SetInstallMessageProc_16(HandleRef pThis, int _arg);

		/// <summary>
		/// By default the interactor installs a MessageProc callback which
		/// intercepts windows messages to the window and controls interactions.
		/// MFC or BCB programs can prevent this and instead directly route any mouse/key
		/// messages into the event bindings by setting InstallMessgeProc to false.
		/// </summary>
		// Token: 0x06010A56 RID: 68182 RVA: 0x00173B0B File Offset: 0x00171D0B
		public virtual void SetInstallMessageProc(int _arg)
		{
			vtkWin32RenderWindowInteractor.vtkWin32RenderWindowInteractor_SetInstallMessageProc_16(base.GetCppThis(), _arg);
		}

		// Token: 0x06010A57 RID: 68183
		[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32RenderWindowInteractor_TerminateApp_17(HandleRef pThis);

		/// <summary>
		/// Win32 specific application terminate, calls ClassExitMethod then
		/// calls PostQuitMessage(0) to terminate the application. An application can Specify
		/// ExitMethod for alternative behavior (i.e. suppression of keyboard exit)
		/// </summary>
		// Token: 0x06010A58 RID: 68184 RVA: 0x00173B1B File Offset: 0x00171D1B
		public override void TerminateApp()
		{
			vtkWin32RenderWindowInteractor.vtkWin32RenderWindowInteractor_TerminateApp_17(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001352 RID: 4946
		public new const string MRFullTypeName = "Kitware.VTK.vtkWin32RenderWindowInteractor";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001353 RID: 4947
		public new static readonly string MRClassNameKey = "class vtkWin32RenderWindowInteractor";
	}
}
