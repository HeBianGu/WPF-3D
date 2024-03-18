using System;
using System.Windows.Interop;
using System.Windows.Controls;

namespace WpfApp1
{
    internal class OverlayControl : ContentControl, IDisposable
    {
        OverlayWindow w;
        HwndHostEx host;
        public OverlayControl()
        {
            Loaded +=OverlayControl_Loaded;
        }

        private void OverlayControl_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            var content = Content;
            
            w = new OverlayWindow();
            w.Content = content;
            w.Show();

            IntPtr windowHandle = new WindowInteropHelper(w).Handle;

            host = new HwndHostEx(windowHandle);
            Content = host;
        }

        public void Dispose()
        {
            host?.Dispose();
            w?.Close();
        }
    }
}
