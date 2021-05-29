using System;
using System.Runtime.InteropServices;
using System.Text;
using WindowsAPI.Enumerables;

namespace WindowsAPI.Interfaces
{
    interface IForm
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(string className, string windowName);

        [DllImport("user32.dll", EntryPoint = "FindWindowEx", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindowEx(IntPtr handleWindowParent, IntPtr handleWindowChildAfter, string className, string windowName);

        [DllImport("user32.dll")]
        public static extern int MouseEvent(MouseEventFlags flag, int x, int y, int button, int extraInfo);

        [DllImport("user32.dll", EntryPoint = "MoveWindow")]
        public static extern bool MoveWindow(IntPtr windowHandle, int x, int y, int width, int height, bool BRePaint);

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        public static extern bool SetCursorPosition(int x, int y);

        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr windowHandle);

        [DllImport("user32.dll", ExactSpelling = true)]
        public static extern bool EnumChildWindows(IntPtr handleWindowParent, EnumWindowsProc lpEnumFunc, int lParam);

        [DllImport("user32.dll")]
        public static extern int GetWindowText(IntPtr handleWindow, [MarshalAs(UnmanagedType.LPWStr)]StringBuilder stringBuilder, int maxCount);

        [DllImport("user32.dll")]
        public static extern int GetClassName(IntPtr handleWindow, [MarshalAs(UnmanagedType.LPWStr)]StringBuilder stringBuilder, int maxCount);

        [DllImport("user32.dll")]
        public static extern bool GetWindowRectangle(IntPtr hWnd, ref System.Drawing.Rectangle rectangle);

        public delegate bool EnumWindowsProc(IntPtr handleWindow, int parameter);
    }
}
