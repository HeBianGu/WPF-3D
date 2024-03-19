using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkFileOutputWindow
	/// </summary>
	/// <remarks>
	///    File Specific output window class
	///
	/// Writes debug/warning/error output to a log file instead of the console.
	/// To use this class, instantiate it and then call SetInstance(this).
	///
	/// </remarks>
	// Token: 0x02000B53 RID: 2899
	public class vtkFileOutputWindow : vtkOutputWindow
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E458 RID: 123992 RVA: 0x002AD31D File Offset: 0x002AB51D
		static vtkFileOutputWindow()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFileOutputWindow.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFileOutputWindow"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E459 RID: 123993 RVA: 0x002AD345 File Offset: 0x002AB545
		public vtkFileOutputWindow(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601E45A RID: 123994
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFileOutputWindow_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E45B RID: 123995 RVA: 0x002AD354 File Offset: 0x002AB554
		public new static vtkFileOutputWindow New()
		{
			vtkFileOutputWindow result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFileOutputWindow.vtkFileOutputWindow_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFileOutputWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E45C RID: 123996 RVA: 0x002AD3A8 File Offset: 0x002AB5A8
		public vtkFileOutputWindow() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkFileOutputWindow.vtkFileOutputWindow_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E45D RID: 123997 RVA: 0x002AD3EC File Offset: 0x002AB5EC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E45E RID: 123998
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFileOutputWindow_AppendOff_01(HandleRef pThis);

		/// <summary>
		/// Setting append will cause the log file to be
		/// opened in append mode.  Otherwise, if the log file exists,
		/// it will be overwritten each time the vtkFileOutputWindow
		/// is created.
		/// </summary>
		// Token: 0x0601E45F RID: 123999 RVA: 0x002AD3F7 File Offset: 0x002AB5F7
		public virtual void AppendOff()
		{
			vtkFileOutputWindow.vtkFileOutputWindow_AppendOff_01(base.GetCppThis());
		}

		// Token: 0x0601E460 RID: 124000
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFileOutputWindow_AppendOn_02(HandleRef pThis);

		/// <summary>
		/// Setting append will cause the log file to be
		/// opened in append mode.  Otherwise, if the log file exists,
		/// it will be overwritten each time the vtkFileOutputWindow
		/// is created.
		/// </summary>
		// Token: 0x0601E461 RID: 124001 RVA: 0x002AD406 File Offset: 0x002AB606
		public virtual void AppendOn()
		{
			vtkFileOutputWindow.vtkFileOutputWindow_AppendOn_02(base.GetCppThis());
		}

		// Token: 0x0601E462 RID: 124002
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFileOutputWindow_DisplayText_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Put the text into the log file.
		/// New lines are converted to carriage return new lines.
		/// </summary>
		// Token: 0x0601E463 RID: 124003 RVA: 0x002AD415 File Offset: 0x002AB615
		public override void DisplayText(string arg0)
		{
			vtkFileOutputWindow.vtkFileOutputWindow_DisplayText_03(base.GetCppThis(), arg0);
		}

		// Token: 0x0601E464 RID: 124004
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFileOutputWindow_FlushOff_04(HandleRef pThis);

		/// <summary>
		/// Turns on buffer flushing for the output
		/// to the log file.
		/// </summary>
		// Token: 0x0601E465 RID: 124005 RVA: 0x002AD425 File Offset: 0x002AB625
		public virtual void FlushOff()
		{
			vtkFileOutputWindow.vtkFileOutputWindow_FlushOff_04(base.GetCppThis());
		}

		// Token: 0x0601E466 RID: 124006
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFileOutputWindow_FlushOn_05(HandleRef pThis);

		/// <summary>
		/// Turns on buffer flushing for the output
		/// to the log file.
		/// </summary>
		// Token: 0x0601E467 RID: 124007 RVA: 0x002AD434 File Offset: 0x002AB634
		public virtual void FlushOn()
		{
			vtkFileOutputWindow.vtkFileOutputWindow_FlushOn_05(base.GetCppThis());
		}

		// Token: 0x0601E468 RID: 124008
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFileOutputWindow_GetAppend_06(HandleRef pThis);

		/// <summary>
		/// Setting append will cause the log file to be
		/// opened in append mode.  Otherwise, if the log file exists,
		/// it will be overwritten each time the vtkFileOutputWindow
		/// is created.
		/// </summary>
		// Token: 0x0601E469 RID: 124009 RVA: 0x002AD444 File Offset: 0x002AB644
		public virtual int GetAppend()
		{
			return vtkFileOutputWindow.vtkFileOutputWindow_GetAppend_06(base.GetCppThis());
		}

		// Token: 0x0601E46A RID: 124010
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFileOutputWindow_GetFileName_07(HandleRef pThis);

		/// <summary>
		/// Sets the name for the log file.
		/// </summary>
		// Token: 0x0601E46B RID: 124011 RVA: 0x002AD464 File Offset: 0x002AB664
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkFileOutputWindow.vtkFileOutputWindow_GetFileName_07(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601E46C RID: 124012
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFileOutputWindow_GetFlush_08(HandleRef pThis);

		/// <summary>
		/// Turns on buffer flushing for the output
		/// to the log file.
		/// </summary>
		// Token: 0x0601E46D RID: 124013 RVA: 0x002AD4A0 File Offset: 0x002AB6A0
		public virtual int GetFlush()
		{
			return vtkFileOutputWindow.vtkFileOutputWindow_GetFlush_08(base.GetCppThis());
		}

		// Token: 0x0601E46E RID: 124014
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFileOutputWindow_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E46F RID: 124015 RVA: 0x002AD4C0 File Offset: 0x002AB6C0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkFileOutputWindow.vtkFileOutputWindow_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x0601E470 RID: 124016
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFileOutputWindow_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E471 RID: 124017 RVA: 0x002AD4E0 File Offset: 0x002AB6E0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkFileOutputWindow.vtkFileOutputWindow_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x0601E472 RID: 124018
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFileOutputWindow_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E473 RID: 124019 RVA: 0x002AD4FC File Offset: 0x002AB6FC
		public override int IsA(string type)
		{
			return vtkFileOutputWindow.vtkFileOutputWindow_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x0601E474 RID: 124020
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFileOutputWindow_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E475 RID: 124021 RVA: 0x002AD51C File Offset: 0x002AB71C
		public new static int IsTypeOf(string type)
		{
			return vtkFileOutputWindow.vtkFileOutputWindow_IsTypeOf_12(type);
		}

		// Token: 0x0601E476 RID: 124022
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFileOutputWindow_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E477 RID: 124023 RVA: 0x002AD538 File Offset: 0x002AB738
		public new vtkFileOutputWindow NewInstance()
		{
			vtkFileOutputWindow result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFileOutputWindow.vtkFileOutputWindow_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFileOutputWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E478 RID: 124024
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFileOutputWindow_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E479 RID: 124025 RVA: 0x002AD594 File Offset: 0x002AB794
		public new static vtkFileOutputWindow SafeDownCast(vtkObjectBase o)
		{
			vtkFileOutputWindow vtkFileOutputWindow = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFileOutputWindow.vtkFileOutputWindow_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFileOutputWindow = (vtkFileOutputWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFileOutputWindow.Register(null);
				}
			}
			return vtkFileOutputWindow;
		}

		// Token: 0x0601E47A RID: 124026
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFileOutputWindow_SetAppend_16(HandleRef pThis, int _arg);

		/// <summary>
		/// Setting append will cause the log file to be
		/// opened in append mode.  Otherwise, if the log file exists,
		/// it will be overwritten each time the vtkFileOutputWindow
		/// is created.
		/// </summary>
		// Token: 0x0601E47B RID: 124027 RVA: 0x002AD613 File Offset: 0x002AB813
		public virtual void SetAppend(int _arg)
		{
			vtkFileOutputWindow.vtkFileOutputWindow_SetAppend_16(base.GetCppThis(), _arg);
		}

		// Token: 0x0601E47C RID: 124028
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFileOutputWindow_SetFileName_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Sets the name for the log file.
		/// </summary>
		// Token: 0x0601E47D RID: 124029 RVA: 0x002AD623 File Offset: 0x002AB823
		public virtual void SetFileName(string _arg)
		{
			vtkFileOutputWindow.vtkFileOutputWindow_SetFileName_17(base.GetCppThis(), _arg);
		}

		// Token: 0x0601E47E RID: 124030
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFileOutputWindow_SetFlush_18(HandleRef pThis, int _arg);

		/// <summary>
		/// Turns on buffer flushing for the output
		/// to the log file.
		/// </summary>
		// Token: 0x0601E47F RID: 124031 RVA: 0x002AD633 File Offset: 0x002AB833
		public virtual void SetFlush(int _arg)
		{
			vtkFileOutputWindow.vtkFileOutputWindow_SetFlush_18(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04002085 RID: 8325
		public new const string MRFullTypeName = "Kitware.VTK.vtkFileOutputWindow";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04002086 RID: 8326
		public new static readonly string MRClassNameKey = "class vtkFileOutputWindow";
	}
}
