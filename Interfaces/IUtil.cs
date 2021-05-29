using System;
using System.Runtime.InteropServices;
using WindowsAPI.Enumerables;
using WindowsAPI.Classes;

namespace WindowsAPI.Interfaces
{
    interface IUtil
    {
        /// <summary>
        /// Hàm gọi hiển thị hộp thoại thông báo
        /// </summary>
        /// <param name="handleWindow">Cửa sổ sẽ hiển thị thông báo</param>
        /// <param name="text">Nội dung hộp thoại</param>
        /// <param name="caption">Tựa đề hộp thoại</param>
        /// <param name="flag">Nút trên hộp thoại</param>
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern void MessageBox(IntPtr handleWindow, string text, string caption, MessageBoxButton flag);

        /// <summary>
        /// Lấy trạng thái liên quan tới pin
        /// </summary>
        /// <param name="battery">Thông số liên quan tới pin</param>
        /// <returns></returns>
        [DllImport("kernel32.dll", EntryPoint = "GetSystemPowerStatus")]
        public static extern bool GetBatteryStatus(ref BatteryStatus battery);
    }
}