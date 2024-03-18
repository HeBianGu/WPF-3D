using System.Runtime.InteropServices;
using System.Security;
using System.Windows;

namespace HeBianGu.Drawing3D.VTK
{
    public static class MousePoint
    {
        /// <summary>
        /// Retrieves the cursor's position, in screen coordinates.
        /// </summary>
        /// <param name="lpPoint"> [out] The point. </param>
        /// <returns> true if it succeeds, false if it fails. </returns>
        /// <see>See MSDN documentation for further information.</see>
        [SuppressUnmanagedCodeSecurity()]
        [DllImport("user32.dll")]
        internal static extern bool GetCursorPos(out POINT lpPoint);

        public static Point GetCursorPosition()
        {
            POINT lpPoint;
            GetCursorPos(out lpPoint);
            return lpPoint;
        }
    }
}
