using System;
using System.Runtime.InteropServices;
using WindowsAPI.Enumerables;
using WindowsAPI.Classes;

namespace WindowsAPI.Interfaces
{
    interface IUtil
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern void MessageBox(IntPtr handleWindow, string text, string caption, MessageBoxOptions flag);

        [DllImport("kernel32.dll", EntryPoint = "GetSystemPowerStatus")]
        public static extern bool GetBatteryStatus(ref BatteryStatus battery);
    }
}
