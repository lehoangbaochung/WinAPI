using System;
using System.Drawing;

namespace WindowsAPI.Classes
{
    public struct WindowInfo
    {
        /// <summary>
        /// Handle window
        /// </summary>
        public IntPtr HandleWindow;

        /// <summary>
        /// The name of window
        /// </summary>
        public string WindowName;

        /// <summary>
        /// The name of class
        /// </summary>
        public string ClassName;

        /// <summary>
        /// The size of the location information
        /// </summary>
        public Rectangle Rectangle;
    }
}
