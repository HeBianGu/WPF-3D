using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOutputWindow
	/// </summary>
	/// <remarks>
	///    base class for writing debug output to a console
	///
	/// This class is used to encapsulate all text output, so that it will work
	/// with operating systems that have a stdout and stderr, and ones that
	/// do not.  (i.e windows does not).  Sub-classes can be provided which can
	/// redirect the output to a window.
	/// </remarks>
	// Token: 0x02000B51 RID: 2897
	public class vtkOutputWindow : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E422 RID: 123938 RVA: 0x002ACF27 File Offset: 0x002AB127
		static vtkOutputWindow()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOutputWindow.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOutputWindow"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E423 RID: 123939 RVA: 0x002ACF4F File Offset: 0x002AB14F
		public vtkOutputWindow(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601E424 RID: 123940
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOutputWindow_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates a new instance of vtkOutputWindow. Note this *will* create a new
		/// instance using the vtkObjectFactory. If you want to access the global
		/// instance, use `GetInstance` instead.
		/// </summary>
		// Token: 0x0601E425 RID: 123941 RVA: 0x002ACF60 File Offset: 0x002AB160
		public new static vtkOutputWindow New()
		{
			vtkOutputWindow result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOutputWindow.vtkOutputWindow_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOutputWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Creates a new instance of vtkOutputWindow. Note this *will* create a new
		/// instance using the vtkObjectFactory. If you want to access the global
		/// instance, use `GetInstance` instead.
		/// </summary>
		// Token: 0x0601E426 RID: 123942 RVA: 0x002ACFB4 File Offset: 0x002AB1B4
		public vtkOutputWindow() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOutputWindow.vtkOutputWindow_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E427 RID: 123943 RVA: 0x002ACFF8 File Offset: 0x002AB1F8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E428 RID: 123944
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOutputWindow_DisplayDebugText_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Display the text. Four virtual methods exist, depending on the type of
		/// message to display. This allows redirection or reformatting of the
		/// messages. The default implementation uses DisplayText for all.
		/// Consequently, subclasses can simply override DisplayText and use
		/// `GetCurrentMessageType` to determine the type of message that's being reported.
		/// </summary>
		// Token: 0x0601E429 RID: 123945 RVA: 0x002AD003 File Offset: 0x002AB203
		public virtual void DisplayDebugText(string arg0)
		{
			vtkOutputWindow.vtkOutputWindow_DisplayDebugText_01(base.GetCppThis(), arg0);
		}

		// Token: 0x0601E42A RID: 123946
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOutputWindow_DisplayErrorText_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Display the text. Four virtual methods exist, depending on the type of
		/// message to display. This allows redirection or reformatting of the
		/// messages. The default implementation uses DisplayText for all.
		/// Consequently, subclasses can simply override DisplayText and use
		/// `GetCurrentMessageType` to determine the type of message that's being reported.
		/// </summary>
		// Token: 0x0601E42B RID: 123947 RVA: 0x002AD013 File Offset: 0x002AB213
		public virtual void DisplayErrorText(string arg0)
		{
			vtkOutputWindow.vtkOutputWindow_DisplayErrorText_02(base.GetCppThis(), arg0);
		}

		// Token: 0x0601E42C RID: 123948
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOutputWindow_DisplayGenericWarningText_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Display the text. Four virtual methods exist, depending on the type of
		/// message to display. This allows redirection or reformatting of the
		/// messages. The default implementation uses DisplayText for all.
		/// Consequently, subclasses can simply override DisplayText and use
		/// `GetCurrentMessageType` to determine the type of message that's being reported.
		/// </summary>
		// Token: 0x0601E42D RID: 123949 RVA: 0x002AD023 File Offset: 0x002AB223
		public virtual void DisplayGenericWarningText(string arg0)
		{
			vtkOutputWindow.vtkOutputWindow_DisplayGenericWarningText_03(base.GetCppThis(), arg0);
		}

		// Token: 0x0601E42E RID: 123950
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOutputWindow_DisplayText_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Display the text. Four virtual methods exist, depending on the type of
		/// message to display. This allows redirection or reformatting of the
		/// messages. The default implementation uses DisplayText for all.
		/// Consequently, subclasses can simply override DisplayText and use
		/// `GetCurrentMessageType` to determine the type of message that's being reported.
		/// </summary>
		// Token: 0x0601E42F RID: 123951 RVA: 0x002AD033 File Offset: 0x002AB233
		public virtual void DisplayText(string arg0)
		{
			vtkOutputWindow.vtkOutputWindow_DisplayText_04(base.GetCppThis(), arg0);
		}

		// Token: 0x0601E430 RID: 123952
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOutputWindow_DisplayWarningText_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Display the text. Four virtual methods exist, depending on the type of
		/// message to display. This allows redirection or reformatting of the
		/// messages. The default implementation uses DisplayText for all.
		/// Consequently, subclasses can simply override DisplayText and use
		/// `GetCurrentMessageType` to determine the type of message that's being reported.
		/// </summary>
		// Token: 0x0601E431 RID: 123953 RVA: 0x002AD043 File Offset: 0x002AB243
		public virtual void DisplayWarningText(string arg0)
		{
			vtkOutputWindow.vtkOutputWindow_DisplayWarningText_05(base.GetCppThis(), arg0);
		}

		// Token: 0x0601E432 RID: 123954
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOutputWindow_GetDisplayMode_06(HandleRef pThis);

		/// <summary>
		/// Flag indicates how the vtkOutputWindow handles displaying of text to
		/// `stderr` / `stdout`. Default is `DEFAULT` except in
		/// `vtkWin32OutputWindow` where on non dashboard runs, the default is
		/// `NEVER`.
		///
		/// `NEVER` indicates that the messages should never be forwarded to the
		/// standard output/error streams.
		///
		/// `ALWAYS` will result in error/warning/debug messages being posted to the
		/// standard error stream, while text messages to standard output stream.
		///
		/// `ALWAYS_STDERR` will result in all messages being posted to the standard
		/// error stream (this was default behavior in VTK 8.1 and earlier).
		///
		/// `DEFAULT` is similar to `ALWAYS` except when logging is enabled. If
		/// logging is enabled, messages posted to the output window using VTK error/warning macros such as
		/// `vtkErrorMacro`, `vtkWarningMacro` etc. will not posted on any of the output streams. This is
		/// done to avoid duplicate messages on these streams since these macros also result in add items
		/// to the log.
		///
		/// @note vtkStringOutputWindow does not result this flag as is never forwards
		/// any text to the output streams.
		/// </summary>
		// Token: 0x0601E433 RID: 123955 RVA: 0x002AD054 File Offset: 0x002AB254
		public virtual int GetDisplayMode()
		{
			return vtkOutputWindow.vtkOutputWindow_GetDisplayMode_06(base.GetCppThis());
		}

		// Token: 0x0601E434 RID: 123956
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOutputWindow_GetDisplayModeMaxValue_07(HandleRef pThis);

		/// <summary>
		/// Flag indicates how the vtkOutputWindow handles displaying of text to
		/// `stderr` / `stdout`. Default is `DEFAULT` except in
		/// `vtkWin32OutputWindow` where on non dashboard runs, the default is
		/// `NEVER`.
		///
		/// `NEVER` indicates that the messages should never be forwarded to the
		/// standard output/error streams.
		///
		/// `ALWAYS` will result in error/warning/debug messages being posted to the
		/// standard error stream, while text messages to standard output stream.
		///
		/// `ALWAYS_STDERR` will result in all messages being posted to the standard
		/// error stream (this was default behavior in VTK 8.1 and earlier).
		///
		/// `DEFAULT` is similar to `ALWAYS` except when logging is enabled. If
		/// logging is enabled, messages posted to the output window using VTK error/warning macros such as
		/// `vtkErrorMacro`, `vtkWarningMacro` etc. will not posted on any of the output streams. This is
		/// done to avoid duplicate messages on these streams since these macros also result in add items
		/// to the log.
		///
		/// @note vtkStringOutputWindow does not result this flag as is never forwards
		/// any text to the output streams.
		/// </summary>
		// Token: 0x0601E435 RID: 123957 RVA: 0x002AD074 File Offset: 0x002AB274
		public virtual int GetDisplayModeMaxValue()
		{
			return vtkOutputWindow.vtkOutputWindow_GetDisplayModeMaxValue_07(base.GetCppThis());
		}

		// Token: 0x0601E436 RID: 123958
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOutputWindow_GetDisplayModeMinValue_08(HandleRef pThis);

		/// <summary>
		/// Flag indicates how the vtkOutputWindow handles displaying of text to
		/// `stderr` / `stdout`. Default is `DEFAULT` except in
		/// `vtkWin32OutputWindow` where on non dashboard runs, the default is
		/// `NEVER`.
		///
		/// `NEVER` indicates that the messages should never be forwarded to the
		/// standard output/error streams.
		///
		/// `ALWAYS` will result in error/warning/debug messages being posted to the
		/// standard error stream, while text messages to standard output stream.
		///
		/// `ALWAYS_STDERR` will result in all messages being posted to the standard
		/// error stream (this was default behavior in VTK 8.1 and earlier).
		///
		/// `DEFAULT` is similar to `ALWAYS` except when logging is enabled. If
		/// logging is enabled, messages posted to the output window using VTK error/warning macros such as
		/// `vtkErrorMacro`, `vtkWarningMacro` etc. will not posted on any of the output streams. This is
		/// done to avoid duplicate messages on these streams since these macros also result in add items
		/// to the log.
		///
		/// @note vtkStringOutputWindow does not result this flag as is never forwards
		/// any text to the output streams.
		/// </summary>
		// Token: 0x0601E437 RID: 123959 RVA: 0x002AD094 File Offset: 0x002AB294
		public virtual int GetDisplayModeMinValue()
		{
			return vtkOutputWindow.vtkOutputWindow_GetDisplayModeMinValue_08(base.GetCppThis());
		}

		// Token: 0x0601E438 RID: 123960
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOutputWindow_GetInstance_09(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the singleton instance with no reference counting.
		/// </summary>
		// Token: 0x0601E439 RID: 123961 RVA: 0x002AD0B4 File Offset: 0x002AB2B4
		public static vtkOutputWindow GetInstance()
		{
			vtkOutputWindow vtkOutputWindow = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOutputWindow.vtkOutputWindow_GetInstance_09(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOutputWindow = (vtkOutputWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOutputWindow.Register(null);
				}
			}
			return vtkOutputWindow;
		}

		// Token: 0x0601E43A RID: 123962
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOutputWindow_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E43B RID: 123963 RVA: 0x002AD120 File Offset: 0x002AB320
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOutputWindow.vtkOutputWindow_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x0601E43C RID: 123964
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOutputWindow_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E43D RID: 123965 RVA: 0x002AD140 File Offset: 0x002AB340
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOutputWindow.vtkOutputWindow_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x0601E43E RID: 123966
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOutputWindow_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E43F RID: 123967 RVA: 0x002AD15C File Offset: 0x002AB35C
		public override int IsA(string type)
		{
			return vtkOutputWindow.vtkOutputWindow_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x0601E440 RID: 123968
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOutputWindow_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E441 RID: 123969 RVA: 0x002AD17C File Offset: 0x002AB37C
		public new static int IsTypeOf(string type)
		{
			return vtkOutputWindow.vtkOutputWindow_IsTypeOf_13(type);
		}

		// Token: 0x0601E442 RID: 123970
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOutputWindow_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E443 RID: 123971 RVA: 0x002AD198 File Offset: 0x002AB398
		public new vtkOutputWindow NewInstance()
		{
			vtkOutputWindow result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOutputWindow.vtkOutputWindow_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOutputWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E444 RID: 123972
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOutputWindow_PromptUserOff_16(HandleRef pThis);

		/// <summary>
		/// If PromptUser is set to true then each time a line of text
		/// is displayed, the user is asked if they want to keep getting
		/// messages.
		///
		/// Note that PromptUser has not effect of messages displayed by directly
		/// calling `DisplayText`. The prompt is never shown for such messages.
		///
		/// </summary>
		// Token: 0x0601E445 RID: 123973 RVA: 0x002AD1F2 File Offset: 0x002AB3F2
		public virtual void PromptUserOff()
		{
			vtkOutputWindow.vtkOutputWindow_PromptUserOff_16(base.GetCppThis());
		}

		// Token: 0x0601E446 RID: 123974
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOutputWindow_PromptUserOn_17(HandleRef pThis);

		/// <summary>
		/// If PromptUser is set to true then each time a line of text
		/// is displayed, the user is asked if they want to keep getting
		/// messages.
		///
		/// Note that PromptUser has not effect of messages displayed by directly
		/// calling `DisplayText`. The prompt is never shown for such messages.
		///
		/// </summary>
		// Token: 0x0601E447 RID: 123975 RVA: 0x002AD201 File Offset: 0x002AB401
		public virtual void PromptUserOn()
		{
			vtkOutputWindow.vtkOutputWindow_PromptUserOn_17(base.GetCppThis());
		}

		// Token: 0x0601E448 RID: 123976
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOutputWindow_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E449 RID: 123977 RVA: 0x002AD210 File Offset: 0x002AB410
		public new static vtkOutputWindow SafeDownCast(vtkObjectBase o)
		{
			vtkOutputWindow vtkOutputWindow = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOutputWindow.vtkOutputWindow_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOutputWindow = (vtkOutputWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOutputWindow.Register(null);
				}
			}
			return vtkOutputWindow;
		}

		// Token: 0x0601E44A RID: 123978
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOutputWindow_SetDisplayMode_19(HandleRef pThis, int _arg);

		/// <summary>
		/// Flag indicates how the vtkOutputWindow handles displaying of text to
		/// `stderr` / `stdout`. Default is `DEFAULT` except in
		/// `vtkWin32OutputWindow` where on non dashboard runs, the default is
		/// `NEVER`.
		///
		/// `NEVER` indicates that the messages should never be forwarded to the
		/// standard output/error streams.
		///
		/// `ALWAYS` will result in error/warning/debug messages being posted to the
		/// standard error stream, while text messages to standard output stream.
		///
		/// `ALWAYS_STDERR` will result in all messages being posted to the standard
		/// error stream (this was default behavior in VTK 8.1 and earlier).
		///
		/// `DEFAULT` is similar to `ALWAYS` except when logging is enabled. If
		/// logging is enabled, messages posted to the output window using VTK error/warning macros such as
		/// `vtkErrorMacro`, `vtkWarningMacro` etc. will not posted on any of the output streams. This is
		/// done to avoid duplicate messages on these streams since these macros also result in add items
		/// to the log.
		///
		/// @note vtkStringOutputWindow does not result this flag as is never forwards
		/// any text to the output streams.
		/// </summary>
		// Token: 0x0601E44B RID: 123979 RVA: 0x002AD28F File Offset: 0x002AB48F
		public virtual void SetDisplayMode(int _arg)
		{
			vtkOutputWindow.vtkOutputWindow_SetDisplayMode_19(base.GetCppThis(), _arg);
		}

		// Token: 0x0601E44C RID: 123980
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOutputWindow_SetDisplayModeToAlways_20(HandleRef pThis);

		/// <summary>
		/// Flag indicates how the vtkOutputWindow handles displaying of text to
		/// `stderr` / `stdout`. Default is `DEFAULT` except in
		/// `vtkWin32OutputWindow` where on non dashboard runs, the default is
		/// `NEVER`.
		///
		/// `NEVER` indicates that the messages should never be forwarded to the
		/// standard output/error streams.
		///
		/// `ALWAYS` will result in error/warning/debug messages being posted to the
		/// standard error stream, while text messages to standard output stream.
		///
		/// `ALWAYS_STDERR` will result in all messages being posted to the standard
		/// error stream (this was default behavior in VTK 8.1 and earlier).
		///
		/// `DEFAULT` is similar to `ALWAYS` except when logging is enabled. If
		/// logging is enabled, messages posted to the output window using VTK error/warning macros such as
		/// `vtkErrorMacro`, `vtkWarningMacro` etc. will not posted on any of the output streams. This is
		/// done to avoid duplicate messages on these streams since these macros also result in add items
		/// to the log.
		///
		/// @note vtkStringOutputWindow does not result this flag as is never forwards
		/// any text to the output streams.
		/// </summary>
		// Token: 0x0601E44D RID: 123981 RVA: 0x002AD29F File Offset: 0x002AB49F
		public void SetDisplayModeToAlways()
		{
			vtkOutputWindow.vtkOutputWindow_SetDisplayModeToAlways_20(base.GetCppThis());
		}

		// Token: 0x0601E44E RID: 123982
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOutputWindow_SetDisplayModeToAlwaysStdErr_21(HandleRef pThis);

		/// <summary>
		/// Flag indicates how the vtkOutputWindow handles displaying of text to
		/// `stderr` / `stdout`. Default is `DEFAULT` except in
		/// `vtkWin32OutputWindow` where on non dashboard runs, the default is
		/// `NEVER`.
		///
		/// `NEVER` indicates that the messages should never be forwarded to the
		/// standard output/error streams.
		///
		/// `ALWAYS` will result in error/warning/debug messages being posted to the
		/// standard error stream, while text messages to standard output stream.
		///
		/// `ALWAYS_STDERR` will result in all messages being posted to the standard
		/// error stream (this was default behavior in VTK 8.1 and earlier).
		///
		/// `DEFAULT` is similar to `ALWAYS` except when logging is enabled. If
		/// logging is enabled, messages posted to the output window using VTK error/warning macros such as
		/// `vtkErrorMacro`, `vtkWarningMacro` etc. will not posted on any of the output streams. This is
		/// done to avoid duplicate messages on these streams since these macros also result in add items
		/// to the log.
		///
		/// @note vtkStringOutputWindow does not result this flag as is never forwards
		/// any text to the output streams.
		/// </summary>
		// Token: 0x0601E44F RID: 123983 RVA: 0x002AD2AE File Offset: 0x002AB4AE
		public void SetDisplayModeToAlwaysStdErr()
		{
			vtkOutputWindow.vtkOutputWindow_SetDisplayModeToAlwaysStdErr_21(base.GetCppThis());
		}

		// Token: 0x0601E450 RID: 123984
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOutputWindow_SetDisplayModeToDefault_22(HandleRef pThis);

		/// <summary>
		/// Flag indicates how the vtkOutputWindow handles displaying of text to
		/// `stderr` / `stdout`. Default is `DEFAULT` except in
		/// `vtkWin32OutputWindow` where on non dashboard runs, the default is
		/// `NEVER`.
		///
		/// `NEVER` indicates that the messages should never be forwarded to the
		/// standard output/error streams.
		///
		/// `ALWAYS` will result in error/warning/debug messages being posted to the
		/// standard error stream, while text messages to standard output stream.
		///
		/// `ALWAYS_STDERR` will result in all messages being posted to the standard
		/// error stream (this was default behavior in VTK 8.1 and earlier).
		///
		/// `DEFAULT` is similar to `ALWAYS` except when logging is enabled. If
		/// logging is enabled, messages posted to the output window using VTK error/warning macros such as
		/// `vtkErrorMacro`, `vtkWarningMacro` etc. will not posted on any of the output streams. This is
		/// done to avoid duplicate messages on these streams since these macros also result in add items
		/// to the log.
		///
		/// @note vtkStringOutputWindow does not result this flag as is never forwards
		/// any text to the output streams.
		/// </summary>
		// Token: 0x0601E451 RID: 123985 RVA: 0x002AD2BD File Offset: 0x002AB4BD
		public void SetDisplayModeToDefault()
		{
			vtkOutputWindow.vtkOutputWindow_SetDisplayModeToDefault_22(base.GetCppThis());
		}

		// Token: 0x0601E452 RID: 123986
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOutputWindow_SetDisplayModeToNever_23(HandleRef pThis);

		/// <summary>
		/// Flag indicates how the vtkOutputWindow handles displaying of text to
		/// `stderr` / `stdout`. Default is `DEFAULT` except in
		/// `vtkWin32OutputWindow` where on non dashboard runs, the default is
		/// `NEVER`.
		///
		/// `NEVER` indicates that the messages should never be forwarded to the
		/// standard output/error streams.
		///
		/// `ALWAYS` will result in error/warning/debug messages being posted to the
		/// standard error stream, while text messages to standard output stream.
		///
		/// `ALWAYS_STDERR` will result in all messages being posted to the standard
		/// error stream (this was default behavior in VTK 8.1 and earlier).
		///
		/// `DEFAULT` is similar to `ALWAYS` except when logging is enabled. If
		/// logging is enabled, messages posted to the output window using VTK error/warning macros such as
		/// `vtkErrorMacro`, `vtkWarningMacro` etc. will not posted on any of the output streams. This is
		/// done to avoid duplicate messages on these streams since these macros also result in add items
		/// to the log.
		///
		/// @note vtkStringOutputWindow does not result this flag as is never forwards
		/// any text to the output streams.
		/// </summary>
		// Token: 0x0601E453 RID: 123987 RVA: 0x002AD2CC File Offset: 0x002AB4CC
		public void SetDisplayModeToNever()
		{
			vtkOutputWindow.vtkOutputWindow_SetDisplayModeToNever_23(base.GetCppThis());
		}

		// Token: 0x0601E454 RID: 123988
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOutputWindow_SetInstance_24(HandleRef instance);

		/// <summary>
		/// Supply a user defined output window. Call -&gt;Delete() on the supplied
		/// instance after setting it.
		/// </summary>
		// Token: 0x0601E455 RID: 123989 RVA: 0x002AD2DC File Offset: 0x002AB4DC
		public static void SetInstance(vtkOutputWindow instance)
		{
			vtkOutputWindow.vtkOutputWindow_SetInstance_24((instance == null) ? default(HandleRef) : instance.GetCppThis());
		}

		// Token: 0x0601E456 RID: 123990
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOutputWindow_SetPromptUser_25(HandleRef pThis, byte _arg);

		/// <summary>
		/// If PromptUser is set to true then each time a line of text
		/// is displayed, the user is asked if they want to keep getting
		/// messages.
		///
		/// Note that PromptUser has not effect of messages displayed by directly
		/// calling `DisplayText`. The prompt is never shown for such messages.
		///
		/// </summary>
		// Token: 0x0601E457 RID: 123991 RVA: 0x002AD305 File Offset: 0x002AB505
		public virtual void SetPromptUser(bool _arg)
		{
			vtkOutputWindow.vtkOutputWindow_SetPromptUser_25(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400207E RID: 8318
		public new const string MRFullTypeName = "Kitware.VTK.vtkOutputWindow";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400207F RID: 8319
		public new static readonly string MRClassNameKey = "class vtkOutputWindow";

		/// <summary>
		/// Flag indicates how the vtkOutputWindow handles displaying of text to
		/// `stderr` / `stdout`. Default is `DEFAULT` except in
		/// `vtkWin32OutputWindow` where on non dashboard runs, the default is
		/// `NEVER`.
		///
		/// `NEVER` indicates that the messages should never be forwarded to the
		/// standard output/error streams.
		///
		/// `ALWAYS` will result in error/warning/debug messages being posted to the
		/// standard error stream, while text messages to standard output stream.
		///
		/// `ALWAYS_STDERR` will result in all messages being posted to the standard
		/// error stream (this was default behavior in VTK 8.1 and earlier).
		///
		/// `DEFAULT` is similar to `ALWAYS` except when logging is enabled. If
		/// logging is enabled, messages posted to the output window using VTK error/warning macros such as
		/// `vtkErrorMacro`, `vtkWarningMacro` etc. will not posted on any of the output streams. This is
		/// done to avoid duplicate messages on these streams since these macros also result in add items
		/// to the log.
		///
		/// @note vtkStringOutputWindow does not result this flag as is never forwards
		/// any text to the output streams.
		/// </summary>
		// Token: 0x02000B52 RID: 2898
		public enum DisplayModes
		{
			/// <summary>enum member</summary>
			// Token: 0x04002081 RID: 8321
			ALWAYS = 1,
			/// <summary>enum member</summary>
			// Token: 0x04002082 RID: 8322
			ALWAYS_STDERR,
			/// <summary>enum member</summary>
			// Token: 0x04002083 RID: 8323
			DEFAULT = -1,
			/// <summary>enum member</summary>
			// Token: 0x04002084 RID: 8324
			NEVER
		}
	}
}
