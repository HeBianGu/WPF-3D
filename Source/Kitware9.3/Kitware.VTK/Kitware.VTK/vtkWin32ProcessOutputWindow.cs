using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkWin32ProcessOutputWindow
	/// </summary>
	/// <remarks>
	///    Win32-specific output window class
	///
	/// vtkWin32ProcessOutputWindow executes a process and sends messages
	/// to its standard input pipe.  This is useful to have a separate
	/// process display VTK errors so that if a VTK application crashes,
	/// the error messages are still available.
	/// </remarks>
	// Token: 0x02000B8E RID: 2958
	public class vtkWin32ProcessOutputWindow : vtkOutputWindow
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601ED73 RID: 126323 RVA: 0x002BBF1F File Offset: 0x002BA11F
		static vtkWin32ProcessOutputWindow()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkWin32ProcessOutputWindow.MRClassNameKey, Type.GetType("Kitware.VTK.vtkWin32ProcessOutputWindow"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601ED74 RID: 126324 RVA: 0x002BBF47 File Offset: 0x002BA147
		public vtkWin32ProcessOutputWindow(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601ED75 RID: 126325
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWin32ProcessOutputWindow_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ED76 RID: 126326 RVA: 0x002BBF58 File Offset: 0x002BA158
		public new static vtkWin32ProcessOutputWindow New()
		{
			vtkWin32ProcessOutputWindow result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWin32ProcessOutputWindow.vtkWin32ProcessOutputWindow_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWin32ProcessOutputWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ED77 RID: 126327 RVA: 0x002BBFAC File Offset: 0x002BA1AC
		public vtkWin32ProcessOutputWindow() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkWin32ProcessOutputWindow.vtkWin32ProcessOutputWindow_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601ED78 RID: 126328 RVA: 0x002BBFF0 File Offset: 0x002BA1F0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601ED79 RID: 126329
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32ProcessOutputWindow_DisplayText_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Send text to the output window process.
		/// </summary>
		// Token: 0x0601ED7A RID: 126330 RVA: 0x002BBFFB File Offset: 0x002BA1FB
		public override void DisplayText(string arg0)
		{
			vtkWin32ProcessOutputWindow.vtkWin32ProcessOutputWindow_DisplayText_01(base.GetCppThis(), arg0);
		}

		// Token: 0x0601ED7B RID: 126331
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWin32ProcessOutputWindow_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ED7C RID: 126332 RVA: 0x002BC00C File Offset: 0x002BA20C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkWin32ProcessOutputWindow.vtkWin32ProcessOutputWindow_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601ED7D RID: 126333
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWin32ProcessOutputWindow_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ED7E RID: 126334 RVA: 0x002BC02C File Offset: 0x002BA22C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkWin32ProcessOutputWindow.vtkWin32ProcessOutputWindow_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601ED7F RID: 126335
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWin32ProcessOutputWindow_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ED80 RID: 126336 RVA: 0x002BC048 File Offset: 0x002BA248
		public override int IsA(string type)
		{
			return vtkWin32ProcessOutputWindow.vtkWin32ProcessOutputWindow_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0601ED81 RID: 126337
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWin32ProcessOutputWindow_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ED82 RID: 126338 RVA: 0x002BC068 File Offset: 0x002BA268
		public new static int IsTypeOf(string type)
		{
			return vtkWin32ProcessOutputWindow.vtkWin32ProcessOutputWindow_IsTypeOf_05(type);
		}

		// Token: 0x0601ED83 RID: 126339
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWin32ProcessOutputWindow_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ED84 RID: 126340 RVA: 0x002BC084 File Offset: 0x002BA284
		public new vtkWin32ProcessOutputWindow NewInstance()
		{
			vtkWin32ProcessOutputWindow result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWin32ProcessOutputWindow.vtkWin32ProcessOutputWindow_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWin32ProcessOutputWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601ED85 RID: 126341
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWin32ProcessOutputWindow_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ED86 RID: 126342 RVA: 0x002BC0E0 File Offset: 0x002BA2E0
		public new static vtkWin32ProcessOutputWindow SafeDownCast(vtkObjectBase o)
		{
			vtkWin32ProcessOutputWindow vtkWin32ProcessOutputWindow = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWin32ProcessOutputWindow.vtkWin32ProcessOutputWindow_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWin32ProcessOutputWindow = (vtkWin32ProcessOutputWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWin32ProcessOutputWindow.Register(null);
				}
			}
			return vtkWin32ProcessOutputWindow;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400210C RID: 8460
		public new const string MRFullTypeName = "Kitware.VTK.vtkWin32ProcessOutputWindow";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400210D RID: 8461
		public new static readonly string MRClassNameKey = "class vtkWin32ProcessOutputWindow";
	}
}
