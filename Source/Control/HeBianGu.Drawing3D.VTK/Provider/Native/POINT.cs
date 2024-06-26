﻿using System.Runtime.InteropServices;
using System.Windows;

namespace HeBianGu.Drawing3D.VTK
{
    [StructLayout(LayoutKind.Sequential)]
    public struct POINT
    {
        public int X;
        public int Y;

        public static implicit operator Point(POINT point)
        {
            return new Point(point.X, point.Y);
        }
    }

}