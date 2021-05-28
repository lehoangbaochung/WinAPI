namespace WindowsAPI.Enumerables
{
    public enum WindowFlag
    {
        /// <summary>
        /// Hide window
        /// </summary>
        Hide = 0,

        /// <summary>
        ///  Maximized window
        /// </summary>
        Maximize = 3,

        /// <summary>
        ///  Minimized windows
        /// </summary>
        Minimize = 6,

        /// <summary>
        ///  A window is displayed with the original size and position,
        ///  so that it enters the active state while
        /// </summary>
        Restore = 9,

        /// <summary>
        ///  A display window with the current size and position,
        ///  so that it enters the active state while
        /// </summary>
        Show = 5,

        /// <summary>
        ///  Maximize the window, and activate
        /// </summary>
        ShowMaximized = 3,

        /// <summary>
        ///  Minimize the window, and activate it
        /// </summary>
        ShowMinimized = 2,

        /// <summary>
        ///  Minimize a window, while not changing the active window
        /// </summary>
        ShowMinNoActive = 7,

        /// <summary>
        ///  With the current size and position of a display window,
        ///  the active window is not changed
        /// </summary>
        ShowNA = 8,

        /// <summary>
        ///  With recent size and position of a window display,
        ///  while not changing the active window
        /// </summary>
        ShowNoActive = 4,

        /// <summary>
        ///  With the original size and position of a window display,
        ///  so that it simultaneously enters the active state, the same Restore
        /// </summary>
        ShowNormal = 1,

        /// <summary>
        ///  Close the form
        /// </summary>
        Close = 0x10
    }
}
