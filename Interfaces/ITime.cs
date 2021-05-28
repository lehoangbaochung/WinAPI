using System.Runtime.InteropServices;
using WindowsAPI.Classes;

namespace WindowsAPI.Interfaces
{
    /// <summary>
    /// Provides the APIs relate to time acquisition system 
    /// </summary>
    interface ITime
    {
        /// <summary>
        /// Set the time acquisition system
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll")]
        public static extern bool SetSystemTime(ref Time time);

        [DllImport("kernel32.dll")]
        public static extern bool SetLocalTime(ref Time time);

        [DllImport("kernel32.dll")]
        public static extern void GetSystemTime(ref Time time);

        [DllImport("kernel32.dll")]
        public static extern void GetLocalTime(ref Time time);
    }
}
