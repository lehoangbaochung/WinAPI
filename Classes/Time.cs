using System;
using WindowsAPI.Interfaces;

namespace WindowsAPI.Classes
{
    struct Time
    {
        public ushort Year;
        public ushort Month;
        public ushort DayOfWeek;
        public ushort Day;
        public ushort Hour;
        public ushort Minute;
        public ushort Second;
        public ushort Millisecond;

        public void SetDateTime(DateTime dateTime)
        {
            Year = (ushort)dateTime.Year;
            Month = (ushort)dateTime.Month;
            DayOfWeek = (ushort)dateTime.DayOfWeek;
            Day = (ushort)dateTime.Day;
            Hour = (ushort)dateTime.Hour;
            Minute = (ushort)dateTime.Minute;
            Second = (ushort)dateTime.Second;
            Millisecond = (ushort)dateTime.Millisecond;
        }

        public static bool SetLocalTimeByString(string timeString)
        {
            DateTime dateTime;

            try
            {
                dateTime = Convert.ToDateTime(timeString);
            }
            catch (FormatException e)
            {
                IUtil.MessageBox(new IntPtr(0), e.StackTrace, "Error", 0);
                return false;
            }         

            var time = new Time
            {
                Year = Convert.ToUInt16(dateTime.Year),
                Month = Convert.ToUInt16(dateTime.Month),
                Day = Convert.ToUInt16(dateTime.Day),
                Hour = Convert.ToUInt16(dateTime.Hour),
                Minute = Convert.ToUInt16(dateTime.Minute),
                Second = Convert.ToUInt16(dateTime.Second)
            };

            return ITime.SetLocalTime(ref time);
        }

        public override string ToString()
        {
            string dayOfWeek = DayOfWeek switch
            {
                0 => "Sunday",
                1 => "Monday",
                2 => "Tuesday",
                3 => "Wednesday",
                4 => "Thursday",
                5 => "Friday",
                6 => "Sarturday",
                _ => "Unknown",
            };

            return $"Year: { Year }\n"
                + $"Month: { Month }\n"
                + $"Day: { Day }\n"
                + $"Hour: { Hour }\n"
                + $"Minute: { Minute }\n"
                + $"Second: { Second }\n"
                + $"Millisecond: { Millisecond }\n"
                + $"DayOfWeek: { dayOfWeek }\n";
        }
    }
}
