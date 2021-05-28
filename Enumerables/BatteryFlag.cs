using System;

namespace WindowsAPI.Enumerables
{
    [Flags]
    public enum BatteryFlag : byte
    {
        /// <summary>
        /// The battery is not charged and the battery capacity 
        /// is between high battery and low battery
        /// </summary>
        Middle = 0,

        /// <summary>
        /// The battery level is more than 66%
        /// </summary>
        High = 1,

        /// <summary>
        /// Battery level is less than 33%
        /// </summary>
        Low = 2,

        /// <summary>
        /// The battery is less than 5%
        /// </summary>
        Critical = 4, 

        /// <summary>
        /// The battery is changing
        /// </summary>
        Charging = 8,

        /// <summary>
        ///  No system battery
        /// </summary>
        NoSystemBattery = 128,

        /// <summary>
        /// Unable to read battery logo information
        /// </summary>
        UnknowStatus = 255
    }
}
