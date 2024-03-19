using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkWin32OutputWindow
	/// </summary>
	/// <remarks>
	///    Win32 Specific output window class
	///
	/// This class is used for error and debug message output on the Windows
	/// platform.   It creates a read only EDIT control to display the
	/// output.   This class should not be used directly.   It should
	/// only be used through the interface of vtkOutputWindow.  This class
	/// only handles one output window per process.  If the window is destroyed,
	/// the vtkObject::GlobalWarningDisplayOff() function is called.  The
	/// window is created the next time text is written to the window.
	///
	/// In its constructor, vtkWin32OutputWindow changes the default
	/// `vtkOutputWindow::DisplayMode` to
	/// `vtkOutputWindow::NEVER` unless running on a dashboard machine,
	/// in which cause it's left as `vtkOutputWindow::DEFAULT`.
	/// </remarks>
	// Token: 0x02000B8D RID: 2957
	public class vtkWin32OutputWindow : vtkOutputWindow
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601ED5D RID: 126301 RVA: 0x002BBCA6 File Offset: 0x002B9EA6
		static vtkWin32OutputWindow()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkWin32OutputWindow.MRClassNameKey, Type.GetType("Kitware.VTK.vtkWin32OutputWindow"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601ED5E RID: 126302 RVA: 0x002BBCCE File Offset: 0x002B9ECE
		public vtkWin32OutputWindow(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601ED5F RID: 126303
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWin32OutputWindow_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create a vtkWin32OutputWindow.
		/// </summary>
		// Token: 0x0601ED60 RID: 126304 RVA: 0x002BBCDC File Offset: 0x002B9EDC
		public new static vtkWin32OutputWindow New()
		{
			vtkWin32OutputWindow result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWin32OutputWindow.vtkWin32OutputWindow_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWin32OutputWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Create a vtkWin32OutputWindow.
		/// </summary>
		// Token: 0x0601ED61 RID: 126305 RVA: 0x002BBD30 File Offset: 0x002B9F30
		public vtkWin32OutputWindow() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkWin32OutputWindow.vtkWin32OutputWindow_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601ED62 RID: 126306 RVA: 0x002BBD74 File Offset: 0x002B9F74
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601ED63 RID: 126307
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32OutputWindow_DisplayText_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// New lines are converted to carriage return new lines.
		/// </summary>
		// Token: 0x0601ED64 RID: 126308 RVA: 0x002BBD7F File Offset: 0x002B9F7F
		public override void DisplayText(string arg0)
		{
			vtkWin32OutputWindow.vtkWin32OutputWindow_DisplayText_01(base.GetCppThis(), arg0);
		}

		// Token: 0x0601ED65 RID: 126309
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWin32OutputWindow_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ED66 RID: 126310 RVA: 0x002BBD90 File Offset: 0x002B9F90
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkWin32OutputWindow.vtkWin32OutputWindow_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601ED67 RID: 126311
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWin32OutputWindow_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ED68 RID: 126312 RVA: 0x002BBDB0 File Offset: 0x002B9FB0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkWin32OutputWindow.vtkWin32OutputWindow_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601ED69 RID: 126313
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWin32OutputWindow_GetWindowTitle_04(HandleRef pThis);

		/// <summary>
		/// Returns the window title.
		/// </summary>
		// Token: 0x0601ED6A RID: 126314 RVA: 0x002BBDCC File Offset: 0x002B9FCC
		public virtual string GetWindowTitle()
		{
			string s = Marshal.PtrToStringAnsi(vtkWin32OutputWindow.vtkWin32OutputWindow_GetWindowTitle_04(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601ED6B RID: 126315
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWin32OutputWindow_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ED6C RID: 126316 RVA: 0x002BBE08 File Offset: 0x002BA008
		public override int IsA(string type)
		{
			return vtkWin32OutputWindow.vtkWin32OutputWindow_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0601ED6D RID: 126317
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWin32OutputWindow_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ED6E RID: 126318 RVA: 0x002BBE28 File Offset: 0x002BA028
		public new static int IsTypeOf(string type)
		{
			return vtkWin32OutputWindow.vtkWin32OutputWindow_IsTypeOf_06(type);
		}

		// Token: 0x0601ED6F RID: 126319
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWin32OutputWindow_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ED70 RID: 126320 RVA: 0x002BBE44 File Offset: 0x002BA044
		public new vtkWin32OutputWindow NewInstance()
		{
			vtkWin32OutputWindow result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWin32OutputWindow.vtkWin32OutputWindow_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWin32OutputWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601ED71 RID: 126321
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWin32OutputWindow_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ED72 RID: 126322 RVA: 0x002BBEA0 File Offset: 0x002BA0A0
		public new static vtkWin32OutputWindow SafeDownCast(vtkObjectBase o)
		{
			vtkWin32OutputWindow vtkWin32OutputWindow = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWin32OutputWindow.vtkWin32OutputWindow_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWin32OutputWindow = (vtkWin32OutputWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWin32OutputWindow.Register(null);
				}
			}
			return vtkWin32OutputWindow;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400210A RID: 8458
		public new const string MRFullTypeName = "Kitware.VTK.vtkWin32OutputWindow";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400210B RID: 8459
		public new static readonly string MRClassNameKey = "class vtkWin32OutputWindow";
	}
}
