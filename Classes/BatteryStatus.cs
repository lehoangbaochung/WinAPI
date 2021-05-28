using WindowsAPI.Enumerables;

namespace WindowsAPI.Classes
{
    /// <summary>
    /// An instant relate to power of system
    /// </summary>
    struct BatteryStatus
    {
        /// <summary>
        /// AC power status
        /// </summary>
        public ACLineStatus ACLineStatus;

        /// <summary>
        /// Battery charging status
        /// </summary>
        public BatteryFlag BatteryFlag;

        /// <summary>
        /// Percentage of remaining power.
        /// The value of this member can be in the range of 0 to 100, if the status is unknown, it can be 255
        /// </summary>
        public byte BatteryLifePercent;

        /// <summary>
        /// Power saving mode
        /// </summary>
        public PowerSavingFlag PowerSavingFlag;

        /// <summary>
        /// The number of seconds of battery life remaining.
        /// If the remaining seconds are unknown or the device is connected to AC power, it is -1
        /// </summary>
        public int BatteryLifeTime;

        /// <summary>
        /// The number of seconds of battery life when fully charged.
        /// If the full life of the battery is unknown or the device is connected to AC power, it is -1
        /// </summary>
        public int BatteryFullLifeTime;

        public override string ToString()
        {
            var status = new string[6];

            switch (ACLineStatus)
            {
                case ACLineStatus.Offline:
                    status.SetValue("Offline", 0);
                    break;
                case ACLineStatus.Online:
                    status.SetValue("Online", 0);
                    break;
                default:
                    status.SetValue("Unknown", 0);
                    break;
            }

            switch (BatteryFlag)
            {
                case BatteryFlag.Charging:
                    status.SetValue("Charging", 1);
                    break;
                case BatteryFlag.Critical:
                    status.SetValue("Very low", 1);
                    break;
                case BatteryFlag.High:
                    status.SetValue("High", 1);
                    break;
                case BatteryFlag.Low:
                    status.SetValue("Low", 1);
                    break;
                case BatteryFlag.Middle:
                    status.SetValue("Middle", 1);
                    break;
                case BatteryFlag.NoSystemBattery:
                    status.SetValue("No information", 1);
                    break;
                case BatteryFlag.UnknowStatus:
                default:
                    status.SetValue("Unknown", 1);
                    break;
            }

            switch (PowerSavingFlag)
            {
                case PowerSavingFlag.Off:
                    status.SetValue("Off", 2);
                    break;
                case PowerSavingFlag.On:
                    status.SetValue("On", 2);
                    break;
                default:
                    status.SetValue("Unknown", 2);
                    break;
            }

            if (BatteryLifeTime == -1)
                status.SetValue("Unknown", 3);
            else
                status.SetValue(BatteryLifeTime, 3);

            if (BatteryFullLifeTime == -1)
                status.SetValue("Unknown", 4);
            else
                status.SetValue(BatteryFullLifeTime, 4);

            return $"AC line charging: { status.GetValue(0) }\n"
                + $"Status: { status.GetValue(1) }\n"
                + $"Power saving mode: { status.GetValue(2) }\n"
                + $"Current life: { BatteryLifePercent }%\n"
                + $"Life time: { status.GetValue(3) }\n"
                + $"Full life time: { status.GetValue(4) }\n";
        }
    }
}
