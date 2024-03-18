using HwndHostControl;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Interop;

namespace WpfApp2
{
    public class ProcessHwndHost : HwndHost
    {
        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, uint dwNewLong);

        public const int GWL_STYLE = (-16);
        public const int WS_CHILD = 0x40000000;
        protected override HandleRef BuildWindowCore(HandleRef hwndParent)
        {
            string path = "C:\\Users\\LENOVO\\My project (1)\\新建文件夹\\My project (1).exe";
            ProcessStartInfo psi1 = new ProcessStartInfo(path);
            Process proc1 = new Process() { StartInfo = psi1 };
            proc1.Start();
            proc1.WaitForInputIdle();
            Thread.Sleep(5000);
            IntPtr handle1 = proc1.MainWindowHandle;
            uint exStyle1 = WinAPI.GetWindowLongPtr(handle1, 1);
            SetWindowLong(handle1, GWL_STYLE, WS_CHILD);
            WinAPI.SetParent(handle1, hwndParent.Handle);
            //WinAPI.SetWindowPos(handle1, new IntPtr(1), 0, 0, 0, 0, (uint)SWP.HIDEWINDOW);
            return new HandleRef(this, handle1);

        }

        protected override void DestroyWindowCore(HandleRef hwnd)
        {
          
        }
    }

    //private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
    //private static readonly IntPtr HWND_NOTOPMOST = new IntPtr(-2);
    //private static readonly IntPtr HWND_TOP = new IntPtr(0);
    //private static readonly IntPtr HWND_BOTTOM = new IntPtr(1);

    ///// <summary>
    ///// SetWindowPos options
    ///// </summary>
    //[Flags]
    //internal enum SWP
    //{
    //    ASYNCWINDOWPOS = 0x4000,
    //    DEFERERASE = 0x2000,
    //    DRAWFRAME = 0x0020,
    //    FRAMECHANGED = 0x0020,
    //    HIDEWINDOW = 0x0080,
    //    NOACTIVATE = 0x0010,
    //    NOCOPYBITS = 0x0100,
    //    NOMOVE = 0x0002,
    //    NOOWNERZORDER = 0x0200,
    //    NOREDRAW = 0x0008,
    //    NOREPOSITION = 0x0200,
    //    NOSENDCHANGING = 0x0400,
    //    NOSIZE = 0x0001,
    //    NOZORDER = 0x0004,
    //    SHOWWINDOW = 0x0040,
    //    TOPMOST = SWP.NOACTIVATE | SWP.NOOWNERZORDER | SWP.NOSIZE | SWP.NOMOVE | SWP.NOREDRAW | SWP.NOSENDCHANGING,
    //}
}
