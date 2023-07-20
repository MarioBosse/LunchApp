using System;
using System.Runtime.InteropServices;
using System.Text;

namespace LunchApp.IO
{
    #region Retrieve list of windows



    public class FocusMonitor
    {
        [DllImport("user32")]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);
        [DllImport("user32")]
        private static extern IntPtr GetForegroundWindow();
        //[DllImport("USER32.DLL")]
        //private static extern bool EnumWindows(EnumWindowsProc enumFunc, int lParam);


        private String GetActiveWindowTitle()
        {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
            IntPtr handle = GetForegroundWindow();

            if (GetWindowText(handle, Buff, nChars) > 0)
            {
                return Buff.ToString();
            }
            return null;
        }
        public FocusMonitor()
        {
            var g = GetActiveWindowTitle();
        }
    }
    #endregion
}
